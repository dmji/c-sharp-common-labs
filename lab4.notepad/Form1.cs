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

namespace lab4.notepad
{
    public partial class Form1 : Form
    {
        
        string[] undo = new string[2];
        bool saved=true;
        string path="";

        public Form1()
        {
            InitializeComponent();
            ((Form)this).Text = "Unitiled - Notepad";
            undo[0] = "";
        }

        private void statusBarToggle_CheckedChanged(object sender, EventArgs e)
        {
            statusBar.Visible = !statusBar.Visible;
        }

        private void aboutWindowShow_MouseDown(object sender, MouseEventArgs e)
        {
            about About = new about();
            About.ShowDialog();
        }

        private void exitToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            int sw = 2;
            if (saved == false)
            {
                sw = CheckSaveToFile();
                if(sw==1)
                    saveToolStripSave_Click(null, null);
            }
            if(sw!=0)
             Close();
        }

        private void openToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            fileToolStripMenuItem.HideDropDown();
            int sw = 2;
            if (saved == false)
            {
                sw = CheckSaveToFile();
                if (sw == 1)
                    saveToolStripSave_Click(null, null);
            }
            if (sw != 0)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    StreamReader file = new StreamReader(openFileDialog.FileName);
                    txtBody.Text = file.ReadToEnd();
                    file.Close();
                    ((Form)this).Text = path.Substring(path.LastIndexOf("\\") + 1, path.LastIndexOf(".") - path.LastIndexOf("\\") - 1) + " - Notepad";
                }
            }
        }

        private void txtBody_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBody_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            undo[0] = undo[1];
            undo[1] = txtBody.Text;
            if (path.Length != 0)
            {
                StreamReader file = new StreamReader(path);
                if (file.ReadToEnd() != txtBody.Text)
                {
                    ((Form)this).Text = path.Substring(path.LastIndexOf("\\") + 1, path.LastIndexOf(".") - path.LastIndexOf("\\") - 1) + "*" + " - Notepad";
                    saved = false;
                }
                else
                {
                    ((Form)this).Text = path.Substring(path.LastIndexOf("\\") + 1, path.LastIndexOf(".") - path.LastIndexOf("\\") - 1) + " - Notepad";
                    saved = true;
                }
                file.Close();
            }

            int CountLine = 1;
            string temp = txtBody.Text;
            while (temp.Contains("\n"))
            {
                temp = temp.Substring(temp.IndexOf("\n") + 1);
                CountLine++;
            }
            txtBody_Check(null, null);
        }

        private void wordWarpToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (wordWarpToolStripMenuItem.Checked == true)
            {
                txtBody.WordWrap = true;
                statusBarToggle.Checked = false;
                statusBarToggle.Enabled = false;
            }
            else
            {
                txtBody.WordWrap = false;
                statusBarToggle.Enabled = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.Font = txtBody.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtBody.Font = fontDialog.Font;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sw = 2;
            if (saved == false)
            {
                sw = CheckSaveToFile();
                if (sw == 1)
                    saveToolStripSave_Click(null, null);
            }
            if (sw != 0)
            {
                path = "";
                ((Form)this).Text = "Unitiled - Notepad";
                txtBody.Text = "";
            }
        }

        private void saveToolStripSave_Click(object sender, EventArgs e)
        {
            if (path.Length == 0)
            {
                saveAsToolStripMenuItem_Click(null, null);
            }
            else
            {
                StreamWriter file = new StreamWriter(path);
                file.WriteLine(txtBody.Text);
                file.Close();
                ((Form)this).Text = path.Substring(path.LastIndexOf("\\") + 1, path.LastIndexOf(".") - path.LastIndexOf("\\") - 1) + " - Notepad";
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                if (!path.Substring(path.LastIndexOf('\\')).Contains(".txt"))
                    path = path + ".txt";
                if (!File.Exists(path))
                    File.CreateText(path).Close();
                StreamWriter file = new StreamWriter(path);
                file.WriteLine(txtBody.Text);
                file.Close();
                ((Form)this).Text = path.Substring(path.LastIndexOf("\\") + 1, path.LastIndexOf(".") - path.LastIndexOf("\\") - 1) + " - Notepad";
            }
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp_pos = txtBody.SelectionStart;
            txtBody.Text=txtBody.Text.Insert(temp_pos, DateTime.Now.ToString());
            txtBody.SelectionStart = temp_pos + DateTime.Now.ToString().Length;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp_pos = txtBody.SelectionStart;
            txtBody.Text = txtBody.Text.Insert(temp_pos, Clipboard.GetText());
            txtBody.SelectionStart = temp_pos + Clipboard.GetText().Length;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(undo[1]==null)
                undoToolStripMenuItem.Enabled = false;
            else
                undoToolStripMenuItem.Enabled = true;
            if (txtBody.Text.Length==0)
            {
                deleteToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                selectAllToolStripMenuItem.Enabled = false;
            }
            else
            {
                deleteToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
            }
            if(Clipboard.ContainsText() == false)
            {
                pasteToolStripMenuItem.Enabled = false;
            }
            else
            {
                pasteToolStripMenuItem.Enabled = true;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp=txtBody.SelectionStart;
            txtBody.Text = undo[0];
            txtBody.SelectionStart = temp;
        }

        private void txtBody_Check(object sender, EventArgs e)
        {
            statusBarLabel.Text = "Line: " + (txtBody.GetLineFromCharIndex(txtBody.SelectionStart) + 1) + ", Column: " + ((-txtBody.GetFirstCharIndexFromLine(txtBody.GetLineFromCharIndex(txtBody.SelectionStart)) + txtBody.SelectionStart) + 1);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp_pos = txtBody.SelectionStart;
            txtBody.Text = txtBody.Text.Remove(temp_pos, txtBody.SelectionLength);
            txtBody.SelectionStart = temp_pos;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBody.SelectionStart = 0;
            txtBody.SelectionLength = txtBody.Text.Length;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp_pos = txtBody.SelectionStart;
            Clipboard.SetText(txtBody.Text.Substring(temp_pos, txtBody.SelectionLength));
            txtBody.SelectionStart = temp_pos;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp_pos = txtBody.SelectionStart;
            Clipboard.SetText(txtBody.Text.Substring(temp_pos, txtBody.SelectionLength));
            txtBody.Text = txtBody.Text.Remove(temp_pos, txtBody.SelectionLength);
            txtBody.SelectionStart = temp_pos;
        }

        private int CheckSaveToFile()
        {
            saveTo msg = new saveTo(this.Text.Substring(0, this.Text.Length - 11));
            msg.ShowDialog();
            return msg.Mode();
        }
    }
}
