using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_10._2021
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                int k = 0;
                try
                {
                    if (textBox2.Text == "")
                    {
                        textBox2.Focus();
                        throw new Exception("Либо ты айзер либо ты айзер");
                    }
                    string s = textBox3.Text;
                    k++;
                    int kl = Convert.ToInt32(textBox4.Text);
                    k++;


                }
                catch (FormatException)
                {
                    if (k == 0)
                    {
                        textBox3.Focus();
                        MessageBox.Show("Не та группа братанчик");
                    }
                    else if (k == 1)
                    {
                        textBox4.Focus();
                        MessageBox.Show("Оценочка");
                    }          
                    
                    e.Cancel = true;
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    e.Cancel = true;
                }
            }
        }
    }
}
