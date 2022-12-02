namespace PetProject.Forms
{
    partial class TestingForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.checkAnswerButton = new System.Windows.Forms.Button();
            this.lastQuestionButton = new System.Windows.Forms.Button();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(45, 47);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(50, 20);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "label1";
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(45, 192);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(431, 27);
            this.answerBox.TabIndex = 1;
            // 
            // checkAnswerButton
            // 
            this.checkAnswerButton.Location = new System.Drawing.Point(45, 277);
            this.checkAnswerButton.Name = "checkAnswerButton";
            this.checkAnswerButton.Size = new System.Drawing.Size(273, 43);
            this.checkAnswerButton.TabIndex = 2;
            this.checkAnswerButton.Text = "checkAnswerButton";
            this.checkAnswerButton.UseVisualStyleBackColor = true;
            this.checkAnswerButton.Click += new System.EventHandler(this.checkAnswerButton_Click);
            // 
            // lastQuestionButton
            // 
            this.lastQuestionButton.Location = new System.Drawing.Point(522, 192);
            this.lastQuestionButton.Name = "lastQuestionButton";
            this.lastQuestionButton.Size = new System.Drawing.Size(94, 29);
            this.lastQuestionButton.TabIndex = 3;
            this.lastQuestionButton.Text = "<";
            this.lastQuestionButton.UseVisualStyleBackColor = true;
            this.lastQuestionButton.Click += new System.EventHandler(this.lastQuestionButton_Click);
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Location = new System.Drawing.Point(622, 192);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(94, 29);
            this.nextQuestionButton.TabIndex = 4;
            this.nextQuestionButton.Text = ">";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.lastQuestionButton);
            this.Controls.Add(this.checkAnswerButton);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.questionLabel);
            this.Name = "TestingForm";
            this.Text = "TestingForm";
            this.Load += new System.EventHandler(this.TestingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label questionLabel;
        private TextBox answerBox;
        private Button checkAnswerButton;
        private Button lastQuestionButton;
        private Button nextQuestionButton;
    }
}