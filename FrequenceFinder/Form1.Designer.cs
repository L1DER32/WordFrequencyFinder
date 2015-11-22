namespace FrequenceFinder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_frq = new System.Windows.Forms.Button();
            this.btn_wordFrqnc = new System.Windows.Forms.Button();
            this.textBox_word = new System.Windows.Forms.TextBox();
            this.wordCount_label = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Save = new System.Windows.Forms.Button();
            this.totalCount = new System.Windows.Forms.Label();
            this.frquency_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.Location = new System.Drawing.Point(3, 3);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(331, 373);
            this.InputBox.TabIndex = 0;
            this.InputBox.Text = "";
            // 
            // btn_Open
            // 
            this.btn_Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Open.Location = new System.Drawing.Point(340, 3);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(104, 53);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "Open text file";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_frq
            // 
            this.btn_frq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_frq.Location = new System.Drawing.Point(340, 62);
            this.btn_frq.Name = "btn_frq";
            this.btn_frq.Size = new System.Drawing.Size(104, 53);
            this.btn_frq.TabIndex = 2;
            this.btn_frq.Text = "Get all frequencies";
            this.btn_frq.UseVisualStyleBackColor = true;
            this.btn_frq.Click += new System.EventHandler(this.btn_frq_Click);
            // 
            // btn_wordFrqnc
            // 
            this.btn_wordFrqnc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_wordFrqnc.Location = new System.Drawing.Point(340, 235);
            this.btn_wordFrqnc.Name = "btn_wordFrqnc";
            this.btn_wordFrqnc.Size = new System.Drawing.Size(104, 53);
            this.btn_wordFrqnc.TabIndex = 3;
            this.btn_wordFrqnc.Text = "Get frequency of a specific form";
            this.btn_wordFrqnc.UseVisualStyleBackColor = true;
            this.btn_wordFrqnc.Click += new System.EventHandler(this.btn_wordFrqnc_Click);
            // 
            // textBox_word
            // 
            this.textBox_word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_word.Location = new System.Drawing.Point(340, 294);
            this.textBox_word.Name = "textBox_word";
            this.textBox_word.Size = new System.Drawing.Size(101, 20);
            this.textBox_word.TabIndex = 4;
            // 
            // wordCount_label
            // 
            this.wordCount_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wordCount_label.AutoSize = true;
            this.wordCount_label.Location = new System.Drawing.Point(340, 317);
            this.wordCount_label.Name = "wordCount_label";
            this.wordCount_label.Size = new System.Drawing.Size(66, 13);
            this.wordCount_label.TabIndex = 5;
            this.wordCount_label.Text = "Word count:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(450, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(383, 379);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Word";
            this.columnHeader1.Width = 163;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Frequency";
            this.columnHeader3.Width = 123;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(340, 121);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(104, 53);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save frequencies\r\nin a text file";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // totalCount
            // 
            this.totalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalCount.AutoSize = true;
            this.totalCount.Location = new System.Drawing.Point(340, 177);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(90, 13);
            this.totalCount.TabIndex = 8;
            this.totalCount.Text = "Total word count:";
            // 
            // frquency_label
            // 
            this.frquency_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frquency_label.AutoSize = true;
            this.frquency_label.Location = new System.Drawing.Point(340, 339);
            this.frquency_label.Name = "frquency_label";
            this.frquency_label.Size = new System.Drawing.Size(60, 13);
            this.frquency_label.TabIndex = 9;
            this.frquency_label.Text = "Frequency:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 379);
            this.Controls.Add(this.frquency_label);
            this.Controls.Add(this.totalCount);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.wordCount_label);
            this.Controls.Add(this.textBox_word);
            this.Controls.Add(this.btn_wordFrqnc);
            this.Controls.Add(this.btn_frq);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.InputBox);
            this.MinimumSize = new System.Drawing.Size(700, 417);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Frequency Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_frq;
        private System.Windows.Forms.Button btn_wordFrqnc;
        private System.Windows.Forms.TextBox textBox_word;
        private System.Windows.Forms.Label wordCount_label;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label totalCount;
        private System.Windows.Forms.Label frquency_label;
    }
}

