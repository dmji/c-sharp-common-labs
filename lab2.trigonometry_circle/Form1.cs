using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2.circle
{

    public partial class Form1 : Form
    {
        int scale = 4;
        int scy = 110;
        Pen liner = new Pen(Color.Black, 2);
        Pen fatliner = new Pen(Color.Red, 5);
        Bitmap btm;
        Bitmap[] btmGraph = new Bitmap[4];
        Graphics graph;
        double angle = 0;

        public Form1()
        {
            InitializeComponent();
            clearbtmGraph();
            clearbtm();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox1.Text!="-")
            {
                if (checkDeg.Checked)
                    angle = Convert.ToDouble(((TextBox)textBox1).Text) * Math.PI / 180;
                else if (checkRad.Checked)
                    angle = Convert.ToDouble(textBox1.Text);
                clearbtm();
                graph.DrawEllipse(fatliner, Convert.ToInt32(pbCircle.Width / 2 + (pbCircle.Width / 2 - 25) * Math.Cos(angle)), Convert.ToInt32(pbCircle.Height / 2 - Math.Sin(angle) * ((pbCircle.Height / 2 - 25))), -1, -1);
                pbCircle.Image = btm;
                calculateTrig();
                label1.Text = "Current angle = \n(in Rad)" + angle + " \n(in Deg)" + angle * 180 / Math.PI;
            }
            else
            {
                clearbtm();
                fSin.Text = "NODATA";
                fCos.Text = "NODATA";
                fTg.Text = "NODATA";
                fCtg.Text = "NODATA";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar==((char)Keys.Back) || e.KeyChar == '-' || e.KeyChar == '.')
                return;
            else
                e.Handled = true;
        }

        private void calculateTrig()
        {
            clearbtmGraph();
            fCos.Text = "cos = " + Convert.ToString(Math.Cos(angle));
            fSin.Text = "sin = " + Convert.ToString(Math.Sin(angle));
            fTg.Text = "tg = " + Convert.ToString(Math.Tan(angle));
            fCtg.Text = "ctg = " + Convert.ToString(1 / Math.Tan(angle));

            graph = Graphics.FromImage(btmGraph[0]);
            graph.DrawLine(fatliner, 0, Convert.ToInt32(graphCos.Height / 2 - Math.Cos(angle) * (-20 + graphCos.Height / 2)), graphCos.Width, Convert.ToInt32(graphCos.Height / 2 - Math.Cos(angle) * (-20 + graphCos.Height / 2)));

            graph = Graphics.FromImage(btmGraph[1]);
            graph.DrawLine(fatliner, 0, Convert.ToInt32(graphCos.Height / 2 - Math.Sin(angle) * (-20 + graphCos.Height / 2)), graphCos.Width, Convert.ToInt32(graphCos.Height / 2 - Math.Sin(angle) * (-20 + graphCos.Height / 2)));

            graph = Graphics.FromImage(btmGraph[2]);
            if (Math.Abs(Math.Cos(angle)) > 0.01)
                graph.DrawLine(fatliner, 0, Convert.ToInt32(graphCos.Height / 2 - Math.Tan(angle) * (-20 + graphCos.Height / scale)), graphCos.Width, Convert.ToInt32(graphCos.Height / 2 - Math.Tan(angle) * (-20 + graphCos.Height / scale)));

            graph = Graphics.FromImage(btmGraph[3]);
            if (Math.Abs(Math.Sin(angle)) > 0.01)
                graph.DrawLine(fatliner, 0, Convert.ToInt32(graphCos.Height / 2 - 1 / Math.Tan(angle) * (-20 + graphCos.Height / scale)), graphCos.Width, Convert.ToInt32(graphCos.Height / 2 - 1 / Math.Tan(angle) * (-20 + graphCos.Height / scale)));

            graphCos.Image = btmGraph[0];
            graphSin.Image = btmGraph[1];
            graphTan.Image = btmGraph[2];
            graphCTan.Image = btmGraph[3];
        }

        private void clearbtm()
        {
            btm = new Bitmap(pbCircle.Width, pbCircle.Height);
            graph = Graphics.FromImage(btm);
            graph.DrawEllipse(liner, 25, 25, pbCircle.Width - 50, pbCircle.Height - 50);
            graph.DrawLine(liner, 0, (pbCircle.Height) / 2, pbCircle.Width, (pbCircle.Height) / 2);
            graph.DrawLine(liner, pbCircle.Width / 2, 0, pbCircle.Width / 2, pbCircle.Height);
            pbCircle.Image = btm;
        }

        private void clearbtmGraph()
        {
            for (int i = 0; i < 4; i++)
            {
                btmGraph[i] = new Bitmap(graphCos.Width, graphCos.Height);
                graph = Graphics.FromImage(btmGraph[i]);
                graph.DrawLine(liner, 0, (graphCos.Height) / 2, graphCos.Width, (graphCos.Height) / 2);
                graph.DrawLine(liner, graphCos.Width / 2, 0, graphCos.Width / 2, graphCos.Height);
            }

            graph = Graphics.FromImage(btmGraph[0]);
            for (int x = -graphCos.Width / 2; x < graphCos.Width / 2; x++)
                drawFunc(1, x, Math.Cos((x * Math.PI) / scy));

            graph = Graphics.FromImage(btmGraph[1]);
            for (int x = -graphCos.Width / 2; x < graphCos.Width / 2; x++)
                drawFunc(1, x, Math.Sin((x * Math.PI) / scy));

            graph = Graphics.FromImage(btmGraph[2]);
            for (int x = -graphCos.Width / 2; x < graphCos.Width / 2; x++)
                if (Math.Abs(Math.Cos((x * Math.PI) / scy)) > 0.01)
                    drawFunc(scale, 1, x, Math.Tan((x * Math.PI) / scy));
           
            graph = Graphics.FromImage(btmGraph[3]);
            for (int x = -graphCos.Width / 2; x < graphCos.Width / 2; x++)
                if (Math.Abs(Math.Sin((x * Math.PI) / scy)) > 0.01)
                    drawFunc(scale, 1, x, 1/Math.Tan((x * Math.PI) / scy));

            graphCos.Image = btmGraph[0];
            graphSin.Image = btmGraph[1];
            graphTan.Image = btmGraph[2];
            graphCTan.Image = btmGraph[3];
        }

        private void drawFunc(int th, int x, double func)
        {
            graph.DrawRectangle(liner, (int)x + graphCos.Width / 2, (int)(graphCos.Height / 2 - ((-20 + graphCos.Height / 2) * func)), (int)1, (int)th);
        }
        private void drawFunc(int scale, int th, int x, double func)
        {
            graph.DrawRectangle(liner, (int)x + graphCos.Width / 2, (int)(graphCos.Height / 2 - ((-20 + graphCos.Height / scale) * func)), (int)1, (int)th);
        }

        private void trackY_Scroll(object sender, EventArgs e)
        {
            scale = trackY.Value;
            clearbtmGraph();
            textBox1_TextChanged(sender, e);
        }

        private void trackX_Scroll(object sender, EventArgs e)
        {
            scy = trackX.Value;
            clearbtmGraph();
            textBox1_TextChanged(sender, e);
        }
    }
}
