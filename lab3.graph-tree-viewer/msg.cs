using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3.graph
{
    public partial class msg : Form
    {
        int vertex;
        public msg(string str, int vert)
        {
            InitializeComponent();
            vertex = vert;
            label1.Text = str;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar==((Char)Keys.Back))
                return;
            else
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e) //dodelat` proverky na debila
        {
            if (!(textBox1.Text == "" && textBox2.Text == ""))
            {
                if ((Convert.ToInt32(textBox2.Text) >= vertex && textBox1.Visible == false) && ((Convert.ToInt32(textBox1.Text) >= vertex || Convert.ToInt32(textBox2.Text) >= vertex) || textBox1.Text == textBox2.Text ))
                {
                    msg eror = new msg("Incorrect data. Plese do it correct", 1);
                    eror.textBox1.Text = "";
                    eror.textBox2.Text = "";
                    eror.textBox1.Visible = false;
                    eror.textBox2.Visible = false;
                    textBox2.Text = "";
                    textBox1.Text = "";
                    eror.ShowDialog();
                }
                else
                    Close();
            }
            else
                Close();
        }

        public int getId
        {
            get {
                if (textBox2.Text.Length != 0)
                    return Convert.ToInt32(textBox2.Text);
                else return -1;
            }
        }
        public int getId_2
        {
            get { return Convert.ToInt32(textBox1.Text); }
        }
    }
}
