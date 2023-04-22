using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace hd
{
    public partial class TestForm : Form
    {
        private readonly JArray _questions;
        private int _currentQuestionIndex;
        private int _correctAnswersCount;

        public TestForm(string filename)
        {
            InitializeComponent();
            // Читаем JSON файл и парсим его в объект JArray
            string json = Test.Read(filename);
            _questions = JsonConvert.DeserializeObject<JObject>(json)["questions"] as JArray;

            _currentQuestionIndex = 0;
            _correctAnswersCount = 0;
            ShowQuestion();

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            ShowQuestion();
        }
        

        private void ShowQuestion()
        {
            if (_currentQuestionIndex >= _questions.Count)
            {
                // Показываем результаты после прохождения всех вопросов
                MessageBox.Show($"Вы ответили правильно на {_correctAnswersCount} из {_questions.Count} вопросов.");
                this.Close();
                return;
            }

            var question = _questions[_currentQuestionIndex]["question"];
            questionLabel.Text = question.Value<string>("text");
            option1RadioButton.Text = question["options"][0].Value<string>();
            option2RadioButton.Text = question["options"][1].Value<string>();
            option3RadioButton.Text = question["options"][2].Value<string>();
        }

        private void nextButton_Click1(object sender, EventArgs e)
        {
            var question = _questions[_currentQuestionIndex]["question"];
            if (option1RadioButton.Checked && option1RadioButton.Text == question.Value<string>("answer"))
            {
                _correctAnswersCount++;
            }
            else if (option2RadioButton.Checked && option2RadioButton.Text == question.Value<string>("answer"))
            {
                _correctAnswersCount++;
            }
            else if (option3RadioButton.Checked && option3RadioButton.Text == question.Value<string>("answer"))
            {
                _correctAnswersCount++;
            }

            _currentQuestionIndex++;
            ShowQuestion();
        }
    }
}
