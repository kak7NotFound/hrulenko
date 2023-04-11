using System;
using System.Windows.Forms;

namespace hd.forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Пожарная безопасность","20","Не пройдено");
            dataGridView1.Rows.Add("Станок ММУ13-Л3","80","Не пройдено");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}