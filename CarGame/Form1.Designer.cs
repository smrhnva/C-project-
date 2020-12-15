namespace CarGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.award = new System.Windows.Forms.PictureBox();
            this.bom = new System.Windows.Forms.PictureBox();
            this.PLAYer = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.Road2 = new System.Windows.Forms.PictureBox();
            this.Road1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.bom);
            this.panel1.Controls.Add(this.PLAYer);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.Road2);
            this.panel1.Controls.Add(this.Road1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 423);
            this.panel1.TabIndex = 0;
            // 
            // award
            // 
            this.award.Image = ((System.Drawing.Image)(resources.GetObject("award.Image")));
            this.award.Location = new System.Drawing.Point(120, 155);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 4;
            this.award.TabStop = false;
            // 
            // bom
            // 
            this.bom.Image = ((System.Drawing.Image)(resources.GetObject("bom.Image")));
            this.bom.Location = new System.Drawing.Point(347, 287);
            this.bom.Name = "bom";
            this.bom.Size = new System.Drawing.Size(64, 64);
            this.bom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bom.TabIndex = 4;
            this.bom.TabStop = false;
            // 
            // PLAYer
            // 
            this.PLAYer.Image = ((System.Drawing.Image)(resources.GetObject("PLAYer.Image")));
            this.PLAYer.Location = new System.Drawing.Point(212, 306);
            this.PLAYer.Name = "PLAYer";
            this.PLAYer.Size = new System.Drawing.Size(50, 99);
            this.PLAYer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PLAYer.TabIndex = 4;
            this.PLAYer.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.Image = ((System.Drawing.Image)(resources.GetObject("AI2.Image")));
            this.AI2.Location = new System.Drawing.Point(347, 49);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 100);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI2.TabIndex = 4;
            this.AI2.TabStop = false;
            this.AI2.Tag = "carRight";
            // 
            // AI1
            // 
            this.AI1.Image = ((System.Drawing.Image)(resources.GetObject("AI1.Image")));
            this.AI1.Location = new System.Drawing.Point(81, 0);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI1.TabIndex = 4;
            this.AI1.TabStop = false;
            this.AI1.Tag = "carLeft";
            // 
            // Road2
            // 
            this.Road2.Image = ((System.Drawing.Image)(resources.GetObject("Road2.Image")));
            this.Road2.Location = new System.Drawing.Point(0, 0);
            this.Road2.Name = "Road2";
            this.Road2.Size = new System.Drawing.Size(475, 423);
            this.Road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road2.TabIndex = 4;
            this.Road2.TabStop = false;
            this.Road2.UseWaitCursor = true;
            // 
            // Road1
            // 
            this.Road1.Image = ((System.Drawing.Image)(resources.GetObject("Road1.Image")));
            this.Road1.Location = new System.Drawing.Point(0, -519);
            this.Road1.Name = "Road1";
            this.Road1.Size = new System.Drawing.Size(475, 423);
            this.Road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road1.TabIndex = 4;
            this.Road1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(386, 605);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 46);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.reStartGame);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(12, 560);
            this.txtScore.MaximumSize = new System.Drawing.Size(515, 0);
            this.txtScore.MinimumSize = new System.Drawing.Size(475, 30);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(475, 30);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Счет: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 122);
            this.label2.TabIndex = 3;
            this.label2.Text = "Нажимай и начинай игру! \r\n\r\nПытайся не врезаться в другие машины!\r\n\r\nУдачи тебе, " +
    "игрок!\r\n";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 697);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Car Game BY Rimms";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Road1;
        private System.Windows.Forms.PictureBox Road2;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox bom;
        private System.Windows.Forms.PictureBox PLAYer;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.Timer GameTimer;
    }
}

