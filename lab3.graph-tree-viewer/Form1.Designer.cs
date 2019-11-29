namespace lab3.graph
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
            this.picBoard = new System.Windows.Forms.PictureBox();
            this.btAddVert = new System.Windows.Forms.Button();
            this.btRemoveVert = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btRemoveEdge = new System.Windows.Forms.Button();
            this.btAddEdge = new System.Windows.Forms.Button();
            this.drawTree = new System.Windows.Forms.RadioButton();
            this.drawGraph = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoard
            // 
            this.picBoard.Location = new System.Drawing.Point(0, 0);
            this.picBoard.Name = "picBoard";
            this.picBoard.Size = new System.Drawing.Size(600, 600);
            this.picBoard.TabIndex = 1;
            this.picBoard.TabStop = false;
            // 
            // btAddVert
            // 
            this.btAddVert.Location = new System.Drawing.Point(609, 516);
            this.btAddVert.Name = "btAddVert";
            this.btAddVert.Size = new System.Drawing.Size(116, 23);
            this.btAddVert.TabIndex = 2;
            this.btAddVert.Text = "Add vertex";
            this.btAddVert.UseVisualStyleBackColor = true;
            this.btAddVert.Click += new System.EventHandler(this.btAddVert_Click);
            // 
            // btRemoveVert
            // 
            this.btRemoveVert.Location = new System.Drawing.Point(609, 545);
            this.btRemoveVert.Name = "btRemoveVert";
            this.btRemoveVert.Size = new System.Drawing.Size(116, 23);
            this.btRemoveVert.TabIndex = 3;
            this.btRemoveVert.Text = "Remove vertex";
            this.btRemoveVert.UseVisualStyleBackColor = true;
            this.btRemoveVert.Click += new System.EventHandler(this.btRemoveVert_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(609, 575);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(116, 23);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Save to file";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btRemoveEdge
            // 
            this.btRemoveEdge.Location = new System.Drawing.Point(609, 487);
            this.btRemoveEdge.Name = "btRemoveEdge";
            this.btRemoveEdge.Size = new System.Drawing.Size(116, 23);
            this.btRemoveEdge.TabIndex = 7;
            this.btRemoveEdge.Text = "Remove edge";
            this.btRemoveEdge.UseVisualStyleBackColor = true;
            this.btRemoveEdge.Click += new System.EventHandler(this.btAddEdge_Click);
            // 
            // btAddEdge
            // 
            this.btAddEdge.Location = new System.Drawing.Point(609, 458);
            this.btAddEdge.Name = "btAddEdge";
            this.btAddEdge.Size = new System.Drawing.Size(116, 23);
            this.btAddEdge.TabIndex = 6;
            this.btAddEdge.Text = "Add edge";
            this.btAddEdge.UseVisualStyleBackColor = true;
            this.btAddEdge.Click += new System.EventHandler(this.btAddEdge_Click);
            // 
            // drawTree
            // 
            this.drawTree.AutoSize = true;
            this.drawTree.Location = new System.Drawing.Point(609, 421);
            this.drawTree.Name = "drawTree";
            this.drawTree.Size = new System.Drawing.Size(58, 17);
            this.drawTree.TabIndex = 8;
            this.drawTree.Text = "As tree";
            this.drawTree.UseVisualStyleBackColor = true;
            // 
            // drawGraph
            // 
            this.drawGraph.AutoSize = true;
            this.drawGraph.Checked = true;
            this.drawGraph.Location = new System.Drawing.Point(609, 398);
            this.drawGraph.Name = "drawGraph";
            this.drawGraph.Size = new System.Drawing.Size(67, 17);
            this.drawGraph.TabIndex = 9;
            this.drawGraph.TabStop = true;
            this.drawGraph.Text = "As graph";
            this.drawGraph.UseVisualStyleBackColor = true;
            this.drawGraph.CheckedChanged += new System.EventHandler(this.drawGraph_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 605);
            this.Controls.Add(this.drawGraph);
            this.Controls.Add(this.drawTree);
            this.Controls.Add(this.btRemoveEdge);
            this.Controls.Add(this.btAddEdge);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btRemoveVert);
            this.Controls.Add(this.btAddVert);
            this.Controls.Add(this.picBoard);
            this.Name = "Form1";
            this.Text = "Graph & tree viewer";
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoard;
        private System.Windows.Forms.Button btAddVert;
        private System.Windows.Forms.Button btRemoveVert;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRemoveEdge;
        private System.Windows.Forms.Button btAddEdge;
        private System.Windows.Forms.RadioButton drawTree;
        private System.Windows.Forms.RadioButton drawGraph;
    }
}

