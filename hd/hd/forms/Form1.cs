using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hd.forms;

namespace hd
{
    public partial class Form1 : Form
    {
        static public DataBase database = null;
        public Form1()
        {
            if (database == null)
            {
                database = new DataBase();
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (var reader = database.GetReader("select * from accounts"))
            {
                while (reader.Read())
                {
                    if (textBox1.Text.Equals(reader.GetValue(0)))
                    {
                        if (textBox2.Text.Equals(reader.GetValue(1)))
                        {
                            this.Hide();
                            new MainForm(reader.GetValue(3).ToString(), textBox1.Text).Show();
                        }
                    }
                    else
                    {
                        Console.WriteLine(@"wrong log or pass");
                    }
                }
            }

        }
    }
}