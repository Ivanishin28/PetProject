namespace PetProject.Forms
{
    partial class MainForm
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
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.beforeDTP = new System.Windows.Forms.DateTimePicker();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.afterDTPCheckBox = new System.Windows.Forms.CheckBox();
            this.afterDTP = new System.Windows.Forms.DateTimePicker();
            this.beforeDTPCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obWordRB = new System.Windows.Forms.RadioButton();
            this.obAddedDateRB = new System.Windows.Forms.RadioButton();
            this.obTranslationNumberRB = new System.Windows.Forms.RadioButton();
            this.isDescendingCB = new System.Windows.Forms.CheckBox();
            this.orderByPanel = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.filterPanel.SuspendLayout();
            this.orderByPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(12, 97);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 29;
            this.dataTable.Size = new System.Drawing.Size(776, 580);
            this.dataTable.TabIndex = 0;
            // 
            // languageBox
            // 
            this.languageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Location = new System.Drawing.Point(820, 97);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(383, 28);
            this.languageBox.TabIndex = 1;
            this.languageBox.SelectedIndexChanged += new System.EventHandler(this.languageBox_SelectedIndexChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(820, 295);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(383, 73);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // beforeDTP
            // 
            this.beforeDTP.Enabled = false;
            this.beforeDTP.Location = new System.Drawing.Point(108, 16);
            this.beforeDTP.Name = "beforeDTP";
            this.beforeDTP.Size = new System.Drawing.Size(268, 27);
            this.beforeDTP.TabIndex = 4;
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.afterDTPCheckBox);
            this.filterPanel.Controls.Add(this.afterDTP);
            this.filterPanel.Controls.Add(this.beforeDTPCheckBox);
            this.filterPanel.Controls.Add(this.beforeDTP);
            this.filterPanel.Location = new System.Drawing.Point(820, 154);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(383, 100);
            this.filterPanel.TabIndex = 5;
            // 
            // afterDTPCheckBox
            // 
            this.afterDTPCheckBox.AutoSize = true;
            this.afterDTPCheckBox.Location = new System.Drawing.Point(27, 62);
            this.afterDTPCheckBox.Name = "afterDTPCheckBox";
            this.afterDTPCheckBox.Size = new System.Drawing.Size(62, 24);
            this.afterDTPCheckBox.TabIndex = 7;
            this.afterDTPCheckBox.Text = "after";
            this.afterDTPCheckBox.UseVisualStyleBackColor = true;
            this.afterDTPCheckBox.CheckedChanged += new System.EventHandler(this.afterDTPCheckBox_CheckedChanged);
            // 
            // afterDTP
            // 
            this.afterDTP.Enabled = false;
            this.afterDTP.Location = new System.Drawing.Point(108, 54);
            this.afterDTP.Name = "afterDTP";
            this.afterDTP.Size = new System.Drawing.Size(268, 27);
            this.afterDTP.TabIndex = 6;
            // 
            // beforeDTPCheckBox
            // 
            this.beforeDTPCheckBox.AutoSize = true;
            this.beforeDTPCheckBox.Location = new System.Drawing.Point(27, 20);
            this.beforeDTPCheckBox.Name = "beforeDTPCheckBox";
            this.beforeDTPCheckBox.Size = new System.Drawing.Size(75, 24);
            this.beforeDTPCheckBox.TabIndex = 5;
            this.beforeDTPCheckBox.Text = "before";
            this.beforeDTPCheckBox.UseVisualStyleBackColor = true;
            this.beforeDTPCheckBox.CheckedChanged += new System.EventHandler(this.beforeDTPCheckBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obWordRB
            // 
            this.obWordRB.AutoSize = true;
            this.obWordRB.Location = new System.Drawing.Point(6, 94);
            this.obWordRB.Name = "obWordRB";
            this.obWordRB.Size = new System.Drawing.Size(66, 24);
            this.obWordRB.TabIndex = 0;
            this.obWordRB.TabStop = true;
            this.obWordRB.Text = "Word";
            this.obWordRB.UseVisualStyleBackColor = true;
            // 
            // obAddedDateRB
            // 
            this.obAddedDateRB.AutoSize = true;
            this.obAddedDateRB.Location = new System.Drawing.Point(6, 136);
            this.obAddedDateRB.Name = "obAddedDateRB";
            this.obAddedDateRB.Size = new System.Drawing.Size(109, 24);
            this.obAddedDateRB.TabIndex = 0;
            this.obAddedDateRB.TabStop = true;
            this.obAddedDateRB.Text = "Added date";
            this.obAddedDateRB.UseVisualStyleBackColor = true;
            // 
            // obTranslationNumberRB
            // 
            this.obTranslationNumberRB.AutoSize = true;
            this.obTranslationNumberRB.Location = new System.Drawing.Point(6, 182);
            this.obTranslationNumberRB.Name = "obTranslationNumberRB";
            this.obTranslationNumberRB.Size = new System.Drawing.Size(163, 24);
            this.obTranslationNumberRB.TabIndex = 0;
            this.obTranslationNumberRB.TabStop = true;
            this.obTranslationNumberRB.Text = "Translations number";
            this.obTranslationNumberRB.UseVisualStyleBackColor = true;
            // 
            // isDescendingCB
            // 
            this.isDescendingCB.AutoSize = true;
            this.isDescendingCB.Location = new System.Drawing.Point(6, 40);
            this.isDescendingCB.Name = "isDescendingCB";
            this.isDescendingCB.Size = new System.Drawing.Size(169, 24);
            this.isDescendingCB.TabIndex = 1;
            this.isDescendingCB.Text = "Order by descending";
            this.isDescendingCB.UseVisualStyleBackColor = true;
            // 
            // orderByPanel
            // 
            this.orderByPanel.Controls.Add(this.isDescendingCB);
            this.orderByPanel.Controls.Add(this.obTranslationNumberRB);
            this.orderByPanel.Controls.Add(this.obAddedDateRB);
            this.orderByPanel.Controls.Add(this.obWordRB);
            this.orderByPanel.Location = new System.Drawing.Point(820, 436);
            this.orderByPanel.Name = "orderByPanel";
            this.orderByPanel.Size = new System.Drawing.Size(383, 241);
            this.orderByPanel.TabIndex = 2;
            this.orderByPanel.TabStop = false;
            this.orderByPanel.Text = "Order by";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "New Word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(318, 60);
            this.button3.TabIndex = 9;
            this.button3.Text = "Not implemented";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 844);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderByPanel);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.languageBox);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.orderByPanel.ResumeLayout(false);
            this.orderByPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataTable;
        private ComboBox languageBox;
        private Button browseButton;
        private DateTimePicker beforeDTP;
        private Panel filterPanel;
        private CheckBox beforeDTPCheckBox;
        private CheckBox afterDTPCheckBox;
        private DateTimePicker afterDTP;
        private MenuStrip menuStrip1;
        private RadioButton obWordRB;
        private RadioButton obAddedDateRB;
        private RadioButton obTranslationNumberRB;
        private CheckBox isDescendingCB;
        private GroupBox orderByPanel;
        private Button button1;
        private Button button3;
    }
}