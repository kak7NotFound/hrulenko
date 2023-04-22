using System;
using System.Windows.Forms;

namespace hd.forms
{
    public partial class MainForm : Form
    {
        public MainForm(String name, String login)
        {
            InitializeComponent();
            label1.Text = @"Имя: " + name; 
            using (var reader =
                Form1.database.GetReader($"select * from tests"))
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetValue(0).ToString(), Test.QuestionCount(reader.GetValue(1).ToString()), "Не пройдено");
                }
            }

            label2.Text = @"Пройдено: 100% (1/" + dataGridView1.Rows.Count + ")";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new TestForm("test.json").Show();
        }
    }
}