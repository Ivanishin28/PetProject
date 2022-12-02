using PetProject.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetProject.Forms
{
    //Not implemented!!
    public partial class TestingForm : Form
    {
        public TestingForm(List<TestingDto> testingDtos)
        {
            words = testingDtos;
            InitializeComponent();
        }
        private readonly List<TestingDto> words;
        private readonly List<int> answeredQuestionsIds
            = new List<int>();
        private int currentQuestion = -1;
        private void TestingForm_Load(object sender, EventArgs e)
        {
        }
        event EventHandler e;

        private void checkAnswerButton_Click(object sender, EventArgs e)
        {
            if (answeredQuestionsIds.Contains(currentQuestion))
            {
                return;
            }
            string userAnswer = answerBox.Text;
            if(userAnswer == words[currentQuestion].WordText)
            {
                answeredQuestionsIds.Add(currentQuestion);
            }
        }

        private void lastQuestionButton_Click(object sender, EventArgs e)
        {
            if(currentQuestion - 1 >= 0)
            {
                ShowQuestion(currentQuestion--);
            }
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (currentQuestion + 1 < words.Count)
            {
                ShowQuestion(currentQuestion++);
            }
        }
        private void ShowQuestion(int questionId)
        {
            TestingDto word = words[questionId];
            
            answerBox.Text = "";
            questionLabel.Text = word.TranslationsString;

            if (!answeredQuestionsIds.Contains(questionId))
            {
                answerBox.Text = word.WordText;
            }
        }
    }
}