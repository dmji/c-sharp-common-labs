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

namespace lab5.voyageur
{
    public partial class Form1 : Form
    {
        int count = 0;
        int[] way;
        int[] optiway;
        double[,] matrix;
        Bitmap btm;
        Graphics graph;
        Point[] matrixPos;
        Point[] picboxPos;
        Pen liner = new Pen(Color.Black, 1);
        Pen fatliner = new Pen(Color.Black, 3);
        Pen redliner = new Pen(Color.Red, 1);
        Font drawFont = new Font("Arial", 10);
        SolidBrush drawBrush = new SolidBrush(Color.Black);

        public Form1()
        {
            InitializeComponent();
        }

        private void newFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                count = 0;
                string temp;
                int i = 0, j = 0;
                StreamReader file = new StreamReader(openFileDialog.FileName);
                temp=file.ReadToEnd();

                while (temp.Contains(' '))
                {
                    count++;
                    temp = temp.Substring(temp.IndexOf(' ') + 1);
                }
                file.Close();
                file = new StreamReader(openFileDialog.FileName);
                temp = file.ReadToEnd();
                file.Close();
                matrix = new double[count, count];
                matrixPos = new Point[count+1];
                while (temp.Contains(' '))
                {
                    matrixPos[i].X = Convert.ToInt32(temp.Substring(0,temp.IndexOf(' ')));
                    if (matrixPos[count].X < matrixPos[i].X)
                        matrixPos[count].X = matrixPos[i].X;
                    temp = temp.Substring(temp.IndexOf(' ') + 1);
                    if (temp.Contains('\n'))
                        matrixPos[i].Y = Convert.ToInt32(temp.Substring(0, temp.IndexOf('\n')));
                    else
                        matrixPos[i].Y = Convert.ToInt32(temp);
                    if (matrixPos[count].Y < matrixPos[i].Y)
                        matrixPos[count].Y = matrixPos[i].Y;

                    if (matrixPos[count].X == 0)
                        matrixPos[count].X = matrixPos[i].X;
                    if (matrixPos[count].Y == 0)
                        matrixPos[count].Y = matrixPos[i].Y;

                    temp = temp.Substring(temp.IndexOf('\n') + 1);
                    i++;
                }
                for(i=0;i<count;i++)
                {
                    for (j = 0; j < count; j++)
                        matrix[i, j] = (double)Math.Sqrt(Math.Pow(matrixPos[i].X - matrixPos[j].X, 2) + Math.Pow(matrixPos[i].Y - matrixPos[j].Y, 2));
                }
                picboxPos = new Point[count];
                for(i=0;i<count;i++)
                {
                    picboxPos[i].X = 5 + Convert.ToInt32((Convert.ToDouble(matrixPos[i].X) / Convert.ToDouble(matrixPos[count].X))* (picBoard.Width - 30));
                    picboxPos[i].Y = 5 + Convert.ToInt32((Convert.ToDouble(matrixPos[i].Y) / Convert.ToDouble(matrixPos[count].Y)) * (picBoard.Height - 30));
                }
                int startpoint=0;
                bool[] flag=new bool[count];
                flag[0] = true;
                way = new int[count];
                calculGraph(0,startpoint, ref flag);
                optiway = new int[count];
                double jfunc = calcfunc(ref way);
                double joptfunc = jfunc;
                for (i = 0; i < count; i++)
                    optiway[i] = way[i];
                for (i = 0; i < count-2; i++)
                {
                    int buft=optiway[i+1];
                    optiway[i + 1] = optiway[i];
                    optiway[i] = buft;
                    if(calcfunc(ref optiway)>jfunc)
                    {
                        optiway[i] = optiway[i + 1];
                        optiway[i + 1] = buft;
                    }
                    else
                        joptfunc = calcfunc(ref optiway);
                }
                label1.Text = "F=" + jfunc + "\nF*=" + joptfunc;
                if (radioButton1.Checked == true)
                    drawGraph(ref way);
                else
                    drawGraph(ref optiway);
            }
        }

        private double calcfunc(ref int[] tway)
        {
            double result=0;
            for(int i=0;i<count;i++)
            {
                if (i == 0)
                    result += matrix[0, tway[i]];
                else
                    result += matrix[tway[i], tway[i - 1]];
            }
            return result;
        }

        private void calculGraph(int j,int point, ref bool[] flag)
        {
            int min=-1;
            for (int i = 0; i < count; i++)
            {
                if (matrix[point, i] != 0)
                {
                    if (flag[i] == false)
                    {
                        if (min == -1)
                            min = i;
                        else if (matrix[point, min] > matrix[point, i])
                            min = i;
                    }
                }
            }
            if (min != -1)
            {
                flag[min] = true;
                way[j] = min;
                calculGraph(j + 1, min, ref flag);
            }
        }

        private void drawGraph(ref int[] tway)
        {
            btm = new Bitmap(picBoard.Width, picBoard.Height);
            dataGridView.Rows.Clear();
            graph = Graphics.FromImage(btm);
            for (int i = 0; i < count; i++)
            {
                if (i == 0)
                    dataGridView.Rows.Add(new object[] { matrixPos[i], Convert.ToDouble(matrix[0, tway[i]]) });
                else
                    dataGridView.Rows.Add(new object[] { matrixPos[i], matrix[tway[i - 1], tway[i]] });

                graph.DrawEllipse(fatliner, picboxPos[i].X, picboxPos[i].Y, -1, -1);
                graph.DrawString(Convert.ToString(i), drawFont, drawBrush, picboxPos[i].X, picboxPos[i].Y);
                if (i == 0)
                    graph.DrawLine(liner, picboxPos[tway[i]], picboxPos[0]);
                else
                    graph.DrawLine(liner, picboxPos[tway[i]], picboxPos[tway[i - 1]]);
            }
            
            picBoard.Image = btm;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            drawGraph(ref way);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            drawGraph(ref optiway);
        }
    }
}
