using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FrequenceFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] allWords;
        List<string> words = new List<string>();
        List<int> WordsCountList = new List<int>();

        int sortColumn = 1;

        private void btn_Open_Click(object sender, EventArgs e)
        {
            // creating open dialog
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = ".txtFile|*.txt";
            dialog.Title = "Select text file";

            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                InputBox.Text = String.Empty; //reset
                try
                {
                    InputBox.Text = File.ReadAllText(dialog.FileName, Encoding.Default);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_frq_Click(object sender, EventArgs e)
        {
            if (InputBox.Text != string.Empty && InputBox.Text.Contains(" "))
            {
                //reset everything to default
                words.Clear();
                WordsCountList.Clear();
                listView1.Items.Clear();

                //preparing the text for getting better results
                allWords = RemovePunctuationNSplit(InputBox.Text);

                //comparing all words
                #region Core algorithm

                for (int i = 0; i < allWords.Length; i++)
                {
                    //if the word is not in the list -- add it
                    if (!words.Contains(allWords[i]))
                    {
                        words.Add(allWords[i]);
                        WordsCountList.Add(1);
                    }
                    else //else increase its count number
                    {
                        for (int k = 0; k < words.Count; k++)
                        {
                            if (words[k] == allWords[i]) WordsCountList[k]++;
                        }
                    }
                }//end for
                #endregion

                totalCount.Text = "Total word count:\r\n" + allWords.Length;

                //showing results in the listView
                for (int i = 0; i < words.Count; i++)
                {
                    //adding word to the listViewItem
                    ListViewItem item = new ListViewItem(words[i]);

                    //adding number of occurrencies to the listViewItem
                    item.SubItems.Add(WordsCountList[i].ToString());

                    //adding frequency to the listViewItem
                    float frequency = (float)WordsCountList[i] / (float)allWords.Length;
                    item.SubItems.Add(frequency.ToString());

                    //adding item to the listView
                    listView1.Items.Add(item);
                }

                //sorting by frequency
                this.listView1.ListViewItemSorter = new ListViewItemComparer(sortColumn, SortOrder.Descending);
                // Call the sort method to manually sort.
                listView1.Sort();


            }
            else MessageBox.Show("There is no text in the field.", "Word Frequency Finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                // creating save dialog
                SaveFileDialog dialog = new SaveFileDialog();

                dialog.Filter = ".txt File|*.txt";
                dialog.Title = "Save TXT file";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> frequencies = new List<string>();

                    //adding some commentaries
                    frequencies.Add("# Compiled with Word Frequency Finder at " + DateTime.Now.ToString("H:mm dd/mm/yyyy"));
                    frequencies.Add("# Total word count: " + allWords.Length);
                    frequencies.Add(string.Format("{0,-18} {1,-10} {2}", "WORD", "COUNT", "FREQUENCY"));

                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        //adding item information
                        string itemStr = string.Format("{0,-18} {1,-10} {2}", listView1.Items[i].Text,
                            listView1.Items[i].SubItems[1].Text, listView1.Items[i].SubItems[2].Text);
                        frequencies.Add(itemStr);
                    }

                    File.WriteAllLines(dialog.FileName, frequencies.ToArray());

                    MessageBox.Show("Operation completed!", "Word Frequency Finder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("No word information!", "Word Frequency Finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_wordFrqnc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(InputBox.Text) && InputBox.Text.Contains(" "))
            {
                int wordCount = 0;

                //preparing the text for getting better results
                allWords = RemovePunctuationNSplit(InputBox.Text);

                // if the word is the one we are looking for -- increase its count indicator
                for (int i = 0; i < allWords.Length; i++)
                {
                    if (checkIgnoreCase.Checked) textBox_word.Text = textBox_word.Text.ToLower();
                        
                    if (allWords[i] == textBox_word.Text) wordCount++;
                }

                //calculating the frequency
                float frqnc = (float)wordCount / (float)allWords.Length;

                //showing the information
                wordCount_label.Text = "Word count: " + wordCount;
                totalCount.Text = "Total word count:\r\n" + allWords.Length;
                frquency_label.Text = "Frequency is:\r\n" + frqnc;
            }
            else MessageBox.Show("There is no text.", "Word Frequency Finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string[] RemovePunctuationNSplit(string text)
        {
            //one way to ignore upercase is to make everything lowercase
            if (checkIgnoreCase.Checked) text = text.ToLower();

            //getting rid of punctuation
            if (checkBoxIgnorePunct.Checked)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '’' || text[i] == '\'')
                    {
                        //keeping apostrophe sign
                    }
                    else if (char.IsPunctuation(text[i]) || text[i] == '\"')
                    {
                        text = text.Remove(i, 1);
                        i--;//to avoid messing up with the length as we removed one character
                    }
                }
            }
            return text.Split(new string[] { "\n", " " }, StringSplitOptions.RemoveEmptyEntries);
        }

        //based on the MSDN manual on how to sort a listview column
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                listView1.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listView1.Sorting == SortOrder.Ascending)
                    listView1.Sorting = SortOrder.Descending;
                else
                    listView1.Sorting = SortOrder.Ascending;
            }
            // Set the ListViewItemSorter property to a new ListViewItemComparer object.
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, listView1.Sorting);
            // Call the sort method to manually sort.
            listView1.Sort();

        }
    }

    //based on the MSDN manual on how to sort a listview column
    class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;

        //ctor with two parameters
        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }
        public int Compare(object x, object y)
        {
            int returnVal;
            // Determine whether the type being compared is a number.
            if (col == 1 || col == 2)
            {
                decimal first = decimal.Parse(((ListViewItem)x).SubItems[col].Text);
                decimal second = decimal.Parse(((ListViewItem)y).SubItems[col].Text);
                returnVal = decimal.Compare(first, second);
            }// If neither compared object has a valid number format, compare as a string.
            else
            {
                // Compare the two items as a string.
                returnVal = String.Compare(
                    ((ListViewItem)x).SubItems[col].Text,
                    ((ListViewItem)y).SubItems[col].Text);
            }
            // Determine whether the sort order is descending.
            //If positive Invert the value returned by String.Compare.
            if (order == SortOrder.Descending) returnVal *= -1;

            return returnVal;
        }
    }

}
