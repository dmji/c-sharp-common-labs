namespace lab2.circle
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
            this.pbCircle = new System.Windows.Forms.PictureBox();
            this.checkRad = new System.Windows.Forms.RadioButton();
            this.checkDeg = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sinPage = new System.Windows.Forms.TabPage();
            this.graphSin = new System.Windows.Forms.PictureBox();
            this.cosPage = new System.Windows.Forms.TabPage();
            this.graphCos = new System.Windows.Forms.PictureBox();
            this.tgPage = new System.Windows.Forms.TabPage();
            this.graphTan = new System.Windows.Forms.PictureBox();
            this.ctgPage = new System.Windows.Forms.TabPage();
            this.graphCTan = new System.Windows.Forms.PictureBox();
            this.fSin = new System.Windows.Forms.Label();
            this.fCos = new System.Windows.Forms.Label();
            this.fCtg = new System.Windows.Forms.Label();
            this.fTg = new System.Windows.Forms.Label();
            this.trackY = new System.Windows.Forms.TrackBar();
            this.trackX = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.sinPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphSin)).BeginInit();
            this.cosPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphCos)).BeginInit();
            this.tgPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphTan)).BeginInit();
            this.ctgPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphCTan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackX)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCircle
            // 
            this.pbCircle.Location = new System.Drawing.Point(12, 12);
            this.pbCircle.Name = "pbCircle";
            this.pbCircle.Size = new System.Drawing.Size(300, 300);
            this.pbCircle.TabIndex = 0;
            this.pbCircle.TabStop = false;
            // 
            // checkRad
            // 
            this.checkRad.AutoSize = true;
            this.checkRad.Location = new System.Drawing.Point(589, 12);
            this.checkRad.Name = "checkRad";
            this.checkRad.Size = new System.Drawing.Size(59, 17);
            this.checkRad.TabIndex = 1;
            this.checkRad.Text = "Radian";
            this.checkRad.UseVisualStyleBackColor = true;
            // 
            // checkDeg
            // 
            this.checkDeg.AutoSize = true;
            this.checkDeg.Checked = true;
            this.checkDeg.Location = new System.Drawing.Point(589, 35);
            this.checkDeg.Name = "checkDeg";
            this.checkDeg.Size = new System.Drawing.Size(60, 17);
            this.checkDeg.TabIndex = 2;
            this.checkDeg.TabStop = true;
            this.checkDeg.Text = "Degree";
            this.checkDeg.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(318, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 38);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sinPage);
            this.tabControl1.Controls.Add(this.cosPage);
            this.tabControl1.Controls.Add(this.tgPage);
            this.tabControl1.Controls.Add(this.ctgPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabControl1.Location = new System.Drawing.Point(12, 318);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 285);
            this.tabControl1.TabIndex = 4;
            // 
            // sinPage
            // 
            this.sinPage.Controls.Add(this.graphSin);
            this.sinPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sinPage.Location = new System.Drawing.Point(4, 24);
            this.sinPage.Name = "sinPage";
            this.sinPage.Padding = new System.Windows.Forms.Padding(3);
            this.sinPage.Size = new System.Drawing.Size(628, 257);
            this.sinPage.TabIndex = 0;
            this.sinPage.Text = "Sinus";
            this.sinPage.UseVisualStyleBackColor = true;
            // 
            // graphSin
            // 
            this.graphSin.Location = new System.Drawing.Point(3, 3);
            this.graphSin.Name = "graphSin";
            this.graphSin.Size = new System.Drawing.Size(619, 248);
            this.graphSin.TabIndex = 0;
            this.graphSin.TabStop = false;
            // 
            // cosPage
            // 
            this.cosPage.Controls.Add(this.graphCos);
            this.cosPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cosPage.Location = new System.Drawing.Point(4, 24);
            this.cosPage.Name = "cosPage";
            this.cosPage.Padding = new System.Windows.Forms.Padding(3);
            this.cosPage.Size = new System.Drawing.Size(628, 257);
            this.cosPage.TabIndex = 1;
            this.cosPage.Text = "cosinus";
            this.cosPage.UseVisualStyleBackColor = true;
            // 
            // graphCos
            // 
            this.graphCos.Location = new System.Drawing.Point(3, 3);
            this.graphCos.Name = "graphCos";
            this.graphCos.Size = new System.Drawing.Size(619, 248);
            this.graphCos.TabIndex = 1;
            this.graphCos.TabStop = false;
            // 
            // tgPage
            // 
            this.tgPage.Controls.Add(this.graphTan);
            this.tgPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tgPage.Location = new System.Drawing.Point(4, 24);
            this.tgPage.Name = "tgPage";
            this.tgPage.Padding = new System.Windows.Forms.Padding(3);
            this.tgPage.Size = new System.Drawing.Size(628, 257);
            this.tgPage.TabIndex = 2;
            this.tgPage.Text = "tangens";
            this.tgPage.UseVisualStyleBackColor = true;
            // 
            // graphTan
            // 
            this.graphTan.Location = new System.Drawing.Point(3, 3);
            this.graphTan.Name = "graphTan";
            this.graphTan.Size = new System.Drawing.Size(619, 248);
            this.graphTan.TabIndex = 2;
            this.graphTan.TabStop = false;
            // 
            // ctgPage
            // 
            this.ctgPage.Controls.Add(this.graphCTan);
            this.ctgPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctgPage.Location = new System.Drawing.Point(4, 24);
            this.ctgPage.Name = "ctgPage";
            this.ctgPage.Padding = new System.Windows.Forms.Padding(3);
            this.ctgPage.Size = new System.Drawing.Size(628, 257);
            this.ctgPage.TabIndex = 3;
            this.ctgPage.Text = "cotangens";
            this.ctgPage.UseVisualStyleBackColor = true;
            // 
            // graphCTan
            // 
            this.graphCTan.Location = new System.Drawing.Point(3, 3);
            this.graphCTan.Name = "graphCTan";
            this.graphCTan.Size = new System.Drawing.Size(619, 248);
            this.graphCTan.TabIndex = 2;
            this.graphCTan.TabStop = false;
            // 
            // fSin
            // 
            this.fSin.AutoSize = true;
            this.fSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fSin.Location = new System.Drawing.Point(318, 60);
            this.fSin.Name = "fSin";
            this.fSin.Size = new System.Drawing.Size(0, 17);
            this.fSin.TabIndex = 5;
            // 
            // fCos
            // 
            this.fCos.AutoSize = true;
            this.fCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fCos.Location = new System.Drawing.Point(318, 79);
            this.fCos.Name = "fCos";
            this.fCos.Size = new System.Drawing.Size(0, 17);
            this.fCos.TabIndex = 6;
            // 
            // fCtg
            // 
            this.fCtg.AutoSize = true;
            this.fCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fCtg.Location = new System.Drawing.Point(318, 113);
            this.fCtg.Name = "fCtg";
            this.fCtg.Size = new System.Drawing.Size(0, 17);
            this.fCtg.TabIndex = 8;
            // 
            // fTg
            // 
            this.fTg.AutoSize = true;
            this.fTg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fTg.Location = new System.Drawing.Point(318, 96);
            this.fTg.Name = "fTg";
            this.fTg.Size = new System.Drawing.Size(0, 17);
            this.fTg.TabIndex = 7;
            // 
            // trackY
            // 
            this.trackY.LargeChange = 10;
            this.trackY.Location = new System.Drawing.Point(492, 291);
            this.trackY.Minimum = 2;
            this.trackY.Name = "trackY";
            this.trackY.Size = new System.Drawing.Size(130, 45);
            this.trackY.TabIndex = 10;
            this.trackY.Value = 2;
            this.trackY.Scroll += new System.EventHandler(this.trackY_Scroll);
            // 
            // trackX
            // 
            this.trackX.Location = new System.Drawing.Point(356, 291);
            this.trackX.Maximum = 310;
            this.trackX.Minimum = 105;
            this.trackX.Name = "trackX";
            this.trackX.Size = new System.Drawing.Size(130, 45);
            this.trackX.TabIndex = 11;
            this.trackX.Value = 110;
            this.trackX.Scroll += new System.EventHandler(this.trackX_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(318, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackX);
            this.Controls.Add(this.trackY);
            this.Controls.Add(this.fCtg);
            this.Controls.Add(this.fTg);
            this.Controls.Add(this.fCos);
            this.Controls.Add(this.fSin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkDeg);
            this.Controls.Add(this.checkRad);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pbCircle);
            this.Name = "Form1";
            this.Text = "Trigonometry circle";
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.sinPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphSin)).EndInit();
            this.cosPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphCos)).EndInit();
            this.tgPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphTan)).EndInit();
            this.ctgPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphCTan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCircle;
        private System.Windows.Forms.RadioButton checkRad;
        private System.Windows.Forms.RadioButton checkDeg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sinPage;
        private System.Windows.Forms.TabPage cosPage;
        private System.Windows.Forms.TabPage tgPage;
        private System.Windows.Forms.TabPage ctgPage;
        private System.Windows.Forms.Label fSin;
        private System.Windows.Forms.Label fCos;
        private System.Windows.Forms.Label fCtg;
        private System.Windows.Forms.Label fTg;
        private System.Windows.Forms.PictureBox graphSin;
        private System.Windows.Forms.PictureBox graphCos;
        private System.Windows.Forms.PictureBox graphTan;
        private System.Windows.Forms.PictureBox graphCTan;
        private System.Windows.Forms.TrackBar trackY;
        private System.Windows.Forms.TrackBar trackX;
        private System.Windows.Forms.Label label1;
    }
}

