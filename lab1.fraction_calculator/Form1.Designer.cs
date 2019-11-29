namespace lab1.calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonCompose = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.buttonGetResult = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonReverce = new System.Windows.Forms.Button();
            this.buttonPOW = new System.Windows.Forms.Button();
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(258, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(6, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox2.Location = new System.Drawing.Point(127, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox3.Location = new System.Drawing.Point(127, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 21);
            this.textBox3.TabIndex = 3;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(2, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "integral";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(124, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "numerator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(124, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "denominator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.pictureBox1.Location = new System.Drawing.Point(127, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 3);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 3);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // buttonPlus
            // 
            this.buttonPlus.CausesValidation = false;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPlus.Location = new System.Drawing.Point(157, 176);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(44, 44);
            this.buttonPlus.TabIndex = 9;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonFunc);
            // 
            // buttonMinus
            // 
            this.buttonMinus.CausesValidation = false;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMinus.Location = new System.Drawing.Point(207, 176);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(44, 44);
            this.buttonMinus.TabIndex = 10;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonFunc);
            // 
            // buttonDivide
            // 
            this.buttonDivide.CausesValidation = false;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDivide.Location = new System.Drawing.Point(207, 126);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(44, 44);
            this.buttonDivide.TabIndex = 12;
            this.buttonDivide.TabStop = false;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonFunc);
            // 
            // buttonCompose
            // 
            this.buttonCompose.CausesValidation = false;
            this.buttonCompose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCompose.Location = new System.Drawing.Point(157, 126);
            this.buttonCompose.Name = "buttonCompose";
            this.buttonCompose.Size = new System.Drawing.Size(44, 44);
            this.buttonCompose.TabIndex = 11;
            this.buttonCompose.TabStop = false;
            this.buttonCompose.Text = "x";
            this.buttonCompose.UseVisualStyleBackColor = true;
            this.buttonCompose.Click += new System.EventHandler(this.buttonFunc);
            // 
            // buttonClear
            // 
            this.buttonClear.CausesValidation = false;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonClear.Location = new System.Drawing.Point(6, 276);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(44, 44);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonNum3
            // 
            this.buttonNum3.CausesValidation = false;
            this.buttonNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNum3.Location = new System.Drawing.Point(97, 126);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(44, 44);
            this.buttonNum3.TabIndex = 17;
            this.buttonNum3.TabStop = false;
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = true;
            this.buttonNum3.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum2
            // 
            this.buttonNum2.CausesValidation = false;
            this.buttonNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNum2.Location = new System.Drawing.Point(52, 126);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(44, 44);
            this.buttonNum2.TabIndex = 16;
            this.buttonNum2.TabStop = false;
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = true;
            this.buttonNum2.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum6
            // 
            this.buttonNum6.CausesValidation = false;
            this.buttonNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNum6.Location = new System.Drawing.Point(97, 176);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(44, 44);
            this.buttonNum6.TabIndex = 20;
            this.buttonNum6.TabStop = false;
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = true;
            this.buttonNum6.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum5
            // 
            this.buttonNum5.CausesValidation = false;
            this.buttonNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNum5.Location = new System.Drawing.Point(52, 176);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(44, 44);
            this.buttonNum5.TabIndex = 19;
            this.buttonNum5.TabStop = false;
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = true;
            this.buttonNum5.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum4
            // 
            this.buttonNum4.CausesValidation = false;
            this.buttonNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNum4.Location = new System.Drawing.Point(6, 176);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(44, 44);
            this.buttonNum4.TabIndex = 18;
            this.buttonNum4.TabStop = false;
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = true;
            this.buttonNum4.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum9
            // 
            this.buttonNum9.CausesValidation = false;
            this.buttonNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNum9.Location = new System.Drawing.Point(97, 226);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(44, 44);
            this.buttonNum9.TabIndex = 23;
            this.buttonNum9.TabStop = false;
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = true;
            this.buttonNum9.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum8
            // 
            this.buttonNum8.CausesValidation = false;
            this.buttonNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNum8.Location = new System.Drawing.Point(52, 226);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(44, 44);
            this.buttonNum8.TabIndex = 22;
            this.buttonNum8.TabStop = false;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = true;
            this.buttonNum8.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNum7
            // 
            this.buttonNum7.CausesValidation = false;
            this.buttonNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNum7.Location = new System.Drawing.Point(6, 226);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(44, 44);
            this.buttonNum7.TabIndex = 21;
            this.buttonNum7.TabStop = false;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = true;
            this.buttonNum7.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonGetResult
            // 
            this.buttonGetResult.CausesValidation = false;
            this.buttonGetResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonGetResult.Location = new System.Drawing.Point(207, 276);
            this.buttonGetResult.Name = "buttonGetResult";
            this.buttonGetResult.Size = new System.Drawing.Size(44, 44);
            this.buttonGetResult.TabIndex = 24;
            this.buttonGetResult.TabStop = false;
            this.buttonGetResult.Text = "=";
            this.buttonGetResult.UseVisualStyleBackColor = true;
            this.buttonGetResult.Click += new System.EventHandler(this.buttonGetResult_Click);
            // 
            // buttonNum0
            // 
            this.buttonNum0.CausesValidation = false;
            this.buttonNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNum0.Location = new System.Drawing.Point(52, 276);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(44, 44);
            this.buttonNum0.TabIndex = 25;
            this.buttonNum0.TabStop = false;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = true;
            this.buttonNum0.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonM
            // 
            this.buttonM.CausesValidation = false;
            this.buttonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonM.Location = new System.Drawing.Point(157, 276);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(44, 44);
            this.buttonM.TabIndex = 26;
            this.buttonM.TabStop = false;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.CausesValidation = false;
            this.buttonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBackspace.Location = new System.Drawing.Point(97, 276);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(44, 44);
            this.buttonBackspace.TabIndex = 27;
            this.buttonBackspace.TabStop = false;
            this.buttonBackspace.Text = "←";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonReverce
            // 
            this.buttonReverce.CausesValidation = false;
            this.buttonReverce.Enabled = false;
            this.buttonReverce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonReverce.Location = new System.Drawing.Point(157, 226);
            this.buttonReverce.Name = "buttonReverce";
            this.buttonReverce.Size = new System.Drawing.Size(44, 44);
            this.buttonReverce.TabIndex = 28;
            this.buttonReverce.TabStop = false;
            this.buttonReverce.Text = "1/x";
            this.buttonReverce.UseVisualStyleBackColor = true;
            this.buttonReverce.Click += new System.EventHandler(this.buttonReverce_Click);
            // 
            // buttonPOW
            // 
            this.buttonPOW.CausesValidation = false;
            this.buttonPOW.Enabled = false;
            this.buttonPOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPOW.Location = new System.Drawing.Point(207, 226);
            this.buttonPOW.Name = "buttonPOW";
            this.buttonPOW.Size = new System.Drawing.Size(44, 44);
            this.buttonPOW.TabIndex = 29;
            this.buttonPOW.TabStop = false;
            this.buttonPOW.Text = "^2";
            this.buttonPOW.UseVisualStyleBackColor = true;
            // 
            // buttonNum1
            // 
            this.buttonNum1.CausesValidation = false;
            this.buttonNum1.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNum1.Location = new System.Drawing.Point(6, 126);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(44, 44);
            this.buttonNum1.TabIndex = 15;
            this.buttonNum1.TabStop = false;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = true;
            this.buttonNum1.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 325);
            this.ControlBox = false;
            this.Controls.Add(this.buttonPOW);
            this.Controls.Add(this.buttonReverce);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonNum0);
            this.Controls.Add(this.buttonGetResult);
            this.Controls.Add(this.buttonNum9);
            this.Controls.Add(this.buttonNum8);
            this.Controls.Add(this.buttonNum7);
            this.Controls.Add(this.buttonNum6);
            this.Controls.Add(this.buttonNum5);
            this.Controls.Add(this.buttonNum4);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonCompose);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonNum1);
            this.Controls.Add(this.buttonNum2);
            this.Controls.Add(this.buttonNum3);
            this.Controls.Add(this.buttonBackspace);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonCompose;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonNum3;
        private System.Windows.Forms.Button buttonNum2;
        private System.Windows.Forms.Button buttonNum6;
        private System.Windows.Forms.Button buttonNum5;
        private System.Windows.Forms.Button buttonNum4;
        private System.Windows.Forms.Button buttonNum9;
        private System.Windows.Forms.Button buttonNum8;
        private System.Windows.Forms.Button buttonNum7;
        private System.Windows.Forms.Button buttonGetResult;
        private System.Windows.Forms.Button buttonNum0;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonReverce;
        private System.Windows.Forms.Button buttonPOW;
        private System.Windows.Forms.Button buttonNum1;
    }
}

