namespace PetProject.Forms
{
    partial class NewWordForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.createNewWordsButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.themeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(313, 15);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(475, 546);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = " ";
            // 
            // createNewWordsButton
            // 
            this.createNewWordsButton.Location = new System.Drawing.Point(52, 15);
            this.createNewWordsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createNewWordsButton.Name = "createNewWordsButton";
            this.createNewWordsButton.Size = new System.Drawing.Size(174, 101);
            this.createNewWordsButton.TabIndex = 2;
            this.createNewWordsButton.Text = "translateButton";
            this.createNewWordsButton.UseVisualStyleBackColor = true;
            this.createNewWordsButton.Click += new System.EventHandler(this.trunslateButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 238);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 384);
            this.listBox1.TabIndex = 3;
            // 
            // languageBox
            // 
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Location = new System.Drawing.Point(12, 134);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(273, 28);
            this.languageBox.TabIndex = 4;
            this.languageBox.SelectedIndexChanged += new System.EventHandler(this.languageBox_SelectedIndexChanged);
            // 
            // themeBox
            // 
            this.themeBox.FormattingEnabled = true;
            this.themeBox.Location = new System.Drawing.Point(12, 186);
            this.themeBox.Name = "themeBox";
            this.themeBox.Size = new System.Drawing.Size(273, 28);
            this.themeBox.TabIndex = 5;
            this.themeBox.SelectedIndexChanged += new System.EventHandler(this.themeBox_SelectedIndexChanged);
            // 
            // NewWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.themeBox);
            this.Controls.Add(this.languageBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.createNewWordsButton);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewWordForm";
            this.Text = "NewWordForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewWordForm_FormClosing);
            this.Load += new System.EventHandler(this.NewWordForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button createNewWordsButton;
        private System.Windows.Forms.ListBox listBox1;
        private ComboBox languageBox;
        private ComboBox themeBox;
    }
}