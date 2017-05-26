namespace Shareekee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AnalClock = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPerdak = new System.Windows.Forms.Label();
            this.YobaBox = new System.Windows.Forms.PictureBox();
            this.EBLABEL = new System.Windows.Forms.Label();
            this.ScoreL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YobaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Новая игра";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(818, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Справка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnalClock
            // 
            this.AnalClock.Interval = 60;
            this.AnalClock.Tick += new System.EventHandler(this.AnalClock_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new System.Drawing.Point(6, 16);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(28, 27);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Location = new System.Drawing.Point(818, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Счёт";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPerdak);
            this.groupBox2.Location = new System.Drawing.Point(818, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 55);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Температура пердака";
            // 
            // lblPerdak
            // 
            this.lblPerdak.AutoSize = true;
            this.lblPerdak.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPerdak.Location = new System.Drawing.Point(7, 16);
            this.lblPerdak.Name = "lblPerdak";
            this.lblPerdak.Size = new System.Drawing.Size(28, 27);
            this.lblPerdak.TabIndex = 5;
            this.lblPerdak.Text = "0";
            // 
            // YobaBox
            // 
            this.YobaBox.BackColor = System.Drawing.SystemColors.Window;
            this.YobaBox.BackgroundImage = global::Shareekee.Properties.Resources.zadnique1;
            this.YobaBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YobaBox.Image = global::Shareekee.Properties.Resources.zadnique1;
            this.YobaBox.Location = new System.Drawing.Point(12, 12);
            this.YobaBox.Name = "YobaBox";
            this.YobaBox.Size = new System.Drawing.Size(800, 600);
            this.YobaBox.TabIndex = 0;
            this.YobaBox.TabStop = false;
            this.YobaBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.YobaBox_MouseClick);
            this.YobaBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.YobaBox_MouseMove);
            // 
            // EBLABEL
            // 
            this.EBLABEL.AutoSize = true;
            this.EBLABEL.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EBLABEL.Location = new System.Drawing.Point(42, 460);
            this.EBLABEL.Name = "EBLABEL";
            this.EBLABEL.Size = new System.Drawing.Size(0, 45);
            this.EBLABEL.TabIndex = 7;
            // 
            // ScoreL
            // 
            this.ScoreL.AutoSize = true;
            this.ScoreL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreL.Location = new System.Drawing.Point(107, 517);
            this.ScoreL.Name = "ScoreL";
            this.ScoreL.Size = new System.Drawing.Size(0, 25);
            this.ScoreL.TabIndex = 8;
            this.ScoreL.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 624);
            this.Controls.Add(this.ScoreL);
            this.Controls.Add(this.EBLABEL);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.YobaBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PEREKATI-YOBA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YobaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox YobaBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer AnalClock;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPerdak;
        private System.Windows.Forms.Label EBLABEL;
        private System.Windows.Forms.Label ScoreL;
    }
}

