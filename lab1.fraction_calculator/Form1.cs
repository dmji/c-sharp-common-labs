using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab1.calculator;

namespace lab1.calculator
{
    public partial class Form1 : Form
    {
        object focus;
        int M=0;
        fractionC total = new fractionC(0, 0);

        public Form1()
        {
            InitializeComponent();
            focus = ((TextBox)textBox1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about info = new about();
            info.Show();
        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            checkin();
            clearcolor();
            total.fractionCompile( ( ( (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox3.Text) ) + Convert.ToInt32(textBox2.Text) )*(Convert.ToInt16(Math.Pow(-1,M))) ), Convert.ToInt32(textBox3.Text) );
            total.option = "Null";
            textBox1.Text = total.getInt.ToString();
            textBox2.Text = total.getNum.ToString();
            textBox3.Text = total.getDen.ToString();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            if(M==0)
            {
                M++;
                buttonM.BackColor = Color.Green;
            }
            else
            {
                M--;
                buttonM.BackColor = buttonNum1.BackColor;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            total.setNum(0, 1);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            ((TextBox)focus).Text = ((TextBox)focus).Text.Substring(0, ((TextBox)focus).Text.Length - 1);
        }

        private void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            focus = ((TextBox)sender);
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            ((TextBox)focus).Text += ((Button)sender).Text;
        }

        private void buttonFunc(object sender, EventArgs e)
        {
            checkin();
            total.setNum((((Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox3.Text)) + Convert.ToInt32(textBox2.Text)) * (Convert.ToInt16(Math.Pow(-1, M)))), Convert.ToInt32(textBox3.Text));
            if (total.option=="Null")
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            clearcolor();
            ((Button)sender).BackColor = Color.Green;
            total.option = ((Button)sender).Name;
        }

        private void clearcolor()
        {
            buttonPlus.BackColor = buttonNum8.BackColor;
            buttonMinus.BackColor = buttonNum8.BackColor;
            buttonDivide.BackColor = buttonNum8.BackColor;
            buttonCompose.BackColor = buttonNum8.BackColor;
        }

        private void buttonReverce_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) == total.getInt && Convert.ToInt32(textBox2.Text) == total.getNum && Convert.ToInt32(textBox3.Text) == total.getDen)
            {
                total.option = ((Button)sender).Name;
                total.fractionCompile(1, 1);
                total.option = "Null";
            }
            else
            {
                string temp = textBox3.Text;
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox2.Text));
            }
        }

        private void checkin()
        {
            if (textBox2.Text.Length == 0 && textBox1.Text.Length != 0)
                textBox3.Text = "1";
            if (textBox1.Text.Length == 0)
                textBox1.Text = "0";
            if (textBox2.Text.Length == 0)
                textBox2.Text = "0";
            if (textBox3.Text.Length == 0)
                textBox3.Text = "0";
        }

        private void ddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            Console.WriteLine(folderBrowserDialog1.SelectedPath);
        }
    }
}
