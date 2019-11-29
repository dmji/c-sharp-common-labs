using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4.notepad
{
    public partial class saveTo : Form
    {
        int mode = 0;
        public saveTo(string fname)
        {
            InitializeComponent();
            label1.Text = label1.Text + fname;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mode = 1;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mode = 2;
            Close();
        }

        public int Mode()
        {
            return mode;
        }
    }
}
