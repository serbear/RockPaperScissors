namespace RockPaperScissors
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
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.pnlComputer = new System.Windows.Forms.Panel();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            this.pnlComputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPaper
            // 
            this.btnPaper.Image = ((System.Drawing.Image)(resources.GetObject("btnPaper.Image")));
            this.btnPaper.Location = new System.Drawing.Point(10, 114);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(80, 80);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnRock
            // 
            this.btnRock.Image = ((System.Drawing.Image)(resources.GetObject("btnRock.Image")));
            this.btnRock.Location = new System.Drawing.Point(96, 114);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(80, 80);
            this.btnRock.TabIndex = 2;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Image = ((System.Drawing.Image)(resources.GetObject("btnScissors.Image")));
            this.btnScissors.Location = new System.Drawing.Point(182, 114);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(80, 80);
            this.btnScissors.TabIndex = 3;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // picPaper
            // 
            this.picPaper.Image = ((System.Drawing.Image)(resources.GetObject("picPaper.Image")));
            this.picPaper.InitialImage = null;
            this.picPaper.Location = new System.Drawing.Point(101, 22);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(44, 64);
            this.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPaper.TabIndex = 3;
            this.picPaper.TabStop = false;
            this.picPaper.Visible = false;
            // 
            // picRock
            // 
            this.picRock.Image = ((System.Drawing.Image)(resources.GetObject("picRock.Image")));
            this.picRock.Location = new System.Drawing.Point(101, 38);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(44, 48);
            this.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRock.TabIndex = 4;
            this.picRock.TabStop = false;
            this.picRock.Visible = false;
            // 
            // picScissors
            // 
            this.picScissors.Image = ((System.Drawing.Image)(resources.GetObject("picScissors.Image")));
            this.picScissors.Location = new System.Drawing.Point(101, 16);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(44, 70);
            this.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picScissors.TabIndex = 5;
            this.picScissors.TabStop = false;
            this.picScissors.Visible = false;
            // 
            // pnlComputer
            // 
            this.pnlComputer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComputer.Controls.Add(this.picRock);
            this.pnlComputer.Controls.Add(this.picScissors);
            this.pnlComputer.Controls.Add(this.picPaper);
            this.pnlComputer.Location = new System.Drawing.Point(10, 8);
            this.pnlComputer.Name = "pnlComputer";
            this.pnlComputer.Size = new System.Drawing.Size(252, 100);
            this.pnlComputer.TabIndex = 6;
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(187, 212);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(75, 23);
            this.btnAgain.TabIndex = 0;
            this.btnAgain.Text = "Play";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(10, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Quit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAgain;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(276, 249);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.pnlComputer);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnPaper);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            this.pnlComputer.ResumeLayout(false);
            this.pnlComputer.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Panel pnlComputer;

        private System.Windows.Forms.GroupBox grbComChoice;
        private System.Windows.Forms.GroupBox grbUserChoice;

        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picScissors;

        #endregion
    }
}