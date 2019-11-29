using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using lab3.graph;

namespace lab3.graph
{
    public partial class Form1 : Form
    {
        string path;
        int vertex = 0;
        Bitmap btm;
        Graphics graph;
        Pen liner = new Pen(Color.Black, 1);
        Pen fatliner = new Pen(Color.Black, 5);
        Font drawFont = new Font("Arial", 10);
        SolidBrush drawBrush = new SolidBrush(Color.Black);

        public Form1()
        {
            InitializeComponent();
            path = @"..\..\input.txt";
            path = File.ReadAllText(path);
            vertex = Convert.ToInt32(path.Substring(0, path.IndexOf('\r')));
            path = path.Substring(path.IndexOf('\n') + 1);
            drawGraph_CheckedChanged(null, null);
        }

        private void stringToMatr()
        {
            btm = new Bitmap(picBoard.Width, picBoard.Height);
            graph = Graphics.FromImage(btm);
            for (int i = 0; i < vertex; i++)
            {
                graph.DrawEllipse(fatliner, Convert.ToInt32(picBoard.Width / 2 + (picBoard.Width / 2 - 25) * Math.Cos((360 / vertex) * i * Math.PI / 180)), Convert.ToInt32(picBoard.Height / 2 - Math.Sin((360 / vertex) * i * Math.PI / 180) * ((picBoard.Height / 2 - 25))), -1, -1);
                graph.DrawString(Convert.ToString(i), drawFont, drawBrush, Convert.ToInt32(picBoard.Width / 2 + (picBoard.Width / 2 - 25) * Math.Cos((360 / vertex) * i * Math.PI / 180)), Convert.ToInt32(picBoard.Height / 2 - Math.Sin((360 / vertex) * i * Math.PI / 180) * ((picBoard.Height / 2 - 25))));
            }
            string temp = path;
            for (int i = 0; i < vertex; i++)
            {
                for (int j = 0; j < vertex; j++)
                    if (Convert.ToInt32(temp.Substring(j * 2, 1)) == 1)
                        graph.DrawLine(liner, Convert.ToInt32(picBoard.Width / 2 + (picBoard.Width / 2 - 25) * Math.Cos((360 / vertex) * i * Math.PI / 180)), Convert.ToInt32(picBoard.Height / 2 - Math.Sin((360 / vertex) * i * Math.PI / 180) * ((picBoard.Height / 2 - 25))), Convert.ToInt32(picBoard.Width / 2 + (picBoard.Width / 2 - 25) * Math.Cos((360 / vertex) * j * Math.PI / 180)), Convert.ToInt32(picBoard.Height / 2 - Math.Sin((360 / vertex) * j * Math.PI / 180) * ((picBoard.Height / 2 - 25))));
                if (temp.Length != vertex * 2 - 1)
                    temp = temp.Substring(2 * vertex + 1);
            }
            picBoard.Image = btm;
        }

        private void modToTree(string pathMod, int vertModCount, int par, ref int[] flag, ref Point[] vertModPos, int level)
        {
            string temp = pathMod.Substring(par * ((vertModCount + 1) * 2 - 1), vertModCount * 2 - 1);
            int pos = 0;
            int levelcount = 0;
            for (int i = 0; i < vertModCount; i++)
                if (Convert.ToInt32(temp.Substring(i * 2, 1)) == 1 && flag[i] == 0)
                    levelcount++;
            int[] thislevel=new int[levelcount];
            for (int i = 0; i < vertModCount; i++)
                if (Convert.ToInt32(temp.Substring(i * 2, 1)) == 1 && flag[i] == 0)
                {
                    vertModPos[i].X = picBoard.Width / (levelcount * 2) * (1+2*pos);
                    vertModPos[i].Y = picBoard.Height / vertModCount * level;
                    flag[i] = 1;
                    thislevel[pos] = i;
                    pos++;
                }
            for(int i=0;i<pos;i++)
                modToTree(pathMod, vertModCount, thislevel[i], ref flag, ref vertModPos, level + 1);
        }

        private void stringToTree()
        {
            Point[] vertModPos = new Point[vertex];
            btm = new Bitmap(picBoard.Width, picBoard.Height);
            graph = Graphics.FromImage(btm);
            int startpos=0;
            int vertModCount = 0;

            int[] flag = new int[vertex];
            for (int i = 0; i < vertex; i++)
                flag[i] = 0;
            for (int i = vertex - 1; i >= 0; i--)
                if (!path.Substring(i * ((vertex + 1) * 2 - 1), vertex * 2 - 1).Contains("1"))
                {
                    vertModCount++;
                    flag[i] = 1;
                }
            int pos = 0;
            for (int i = 0; i < vertex; i++)
                if (flag[i] == 1)
                {
                    vertModPos[i].X = picBoard.Width / (vertModCount * 2) * (1 + pos * 2);
                    vertModPos[i].Y = picBoard.Height - 20;
                    pos++;
                }
            while (flag[startpos] == 1)
                startpos++;
            flag[startpos] = 1;
            vertModPos[startpos].Y = 20;
            vertModPos[startpos].X = picBoard.Width / 2;
            modToTree(path, vertex, startpos, ref flag, ref vertModPos, 1);
            for (int i = 0; i < vertex; i++)
            {
                graph.DrawEllipse(fatliner, vertModPos[i].X, vertModPos[i].Y, -1, -1);
                graph.DrawString(Convert.ToString(i), drawFont, drawBrush, vertModPos[i].X, vertModPos[i].Y);
                string temp = path.Substring(i * ((vertex + 1) * 2 - 1), vertex * 2 - 1);
                for (int j = 0; j < vertex; j++)
                    if (temp.Substring(j * 2, 1) == "1")
                        graph.DrawLine(liner, vertModPos[i], vertModPos[j]);
            }
            picBoard.Image = btm;
        }
           
        private void btAddVert_Click(object sender, EventArgs e)
        {
            path = path + "\r\n0";
            for (int i = 0; i < vertex; i++)
            {
                path = path.Insert(vertex * i * 2 + 3 * i + 2 * vertex - 1, " 0");
                path = path + " 0";
            }
            vertex++;
            drawGraph_CheckedChanged(null, null);
        }

        private void btRemoveVert_Click(object sender, EventArgs e)
        {
            msg mes = new msg("Enter number vertex to remove: ", vertex);
            mes.textBox1.Visible = false;
            mes.ShowDialog();
            path = path.Remove(vertex * 2 * mes.getId + 1, vertex * 2 + 1);
            for (int i = 0; i < vertex - 1; i++)
                if (mes.getId == 0)
                    path = path.Remove(mes.getId * 2 + i * (vertex - 1) * 2 + 1 * i, 2);
                else
                    path = path.Remove(mes.getId * 2 - 1 + i * (vertex - 1) * 2 + 1 * i, 2);
            vertex--;
            drawGraph_CheckedChanged(null, null);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"F:\csharp\lab3.graph\lab3.graph\output.txt", Convert.ToString(vertex) + "\r\n" + path);
        }

        private void drawGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (drawGraph.Checked)
                stringToMatr();
            else
                stringToTree();
        }

        private void btAddEdge_Click(object sender, EventArgs e)
        {
            string sym = "0";
            msg mes = new msg("What vertex to connect: ", vertex);
            mes.ShowDialog();
            if (mes.getId!=-1)
            {
                int i = mes.getId, j = mes.getId_2;
                if (((Button)sender).Name == "btAddEdge")
                    sym = "1";
                path = path.Remove(i * (vertex * 2 + 1) + j * 2, 1).Insert(i * (vertex * 2 + 1) + j * 2, sym);
                path = path.Remove(j * (vertex * 2 + 1) + i * 2, 1).Insert(j * (vertex * 2 + 1) + i * 2, sym);
                drawGraph_CheckedChanged(null, null);
            }
        }
    }
}