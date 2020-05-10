namespace DogRace
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
            this.rbJhon = new System.Windows.Forms.RadioButton();
            this.rbPatlu = new System.Windows.Forms.RadioButton();
            this.rbMoto = new System.Windows.Forms.RadioButton();
            this.btnBet = new System.Windows.Forms.Button();
            this.udBoxBet = new System.Windows.Forms.NumericUpDown();
            this.udBoxDog = new System.Windows.Forms.NumericUpDown();
            this.btnRace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblJhon = new System.Windows.Forms.Label();
            this.lblPatlu = new System.Windows.Forms.Label();
            this.lblMoto = new System.Windows.Forms.Label();
            this.lblBettor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLockIn = new System.Windows.Forms.Button();
            this.pbDog1 = new System.Windows.Forms.PictureBox();
            this.pbDog4 = new System.Windows.Forms.PictureBox();
            this.pbDog3 = new System.Windows.Forms.PictureBox();
            this.pbDog2 = new System.Windows.Forms.PictureBox();
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // rbJhon
            // 
            this.rbJhon.AutoSize = true;
            this.rbJhon.Location = new System.Drawing.Point(44, 334);
            this.rbJhon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbJhon.Name = "rbJhon";
            this.rbJhon.Size = new System.Drawing.Size(60, 21);
            this.rbJhon.TabIndex = 3;
            this.rbJhon.TabStop = true;
            this.rbJhon.Text = "Jhon";
            this.rbJhon.UseVisualStyleBackColor = true;
            this.rbJhon.CheckedChanged += new System.EventHandler(this.rbJhon_CheckedChanged);
            // 
            // rbPatlu
            // 
            this.rbPatlu.AutoSize = true;
            this.rbPatlu.Location = new System.Drawing.Point(44, 361);
            this.rbPatlu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPatlu.Name = "rbPatlu";
            this.rbPatlu.Size = new System.Drawing.Size(61, 21);
            this.rbPatlu.TabIndex = 4;
            this.rbPatlu.TabStop = true;
            this.rbPatlu.Text = "Patlu";
            this.rbPatlu.UseVisualStyleBackColor = true;
            this.rbPatlu.CheckedChanged += new System.EventHandler(this.rbPatlu_CheckedChanged);
            // 
            // rbMoto
            // 
            this.rbMoto.AutoSize = true;
            this.rbMoto.Location = new System.Drawing.Point(44, 389);
            this.rbMoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMoto.Name = "rbMoto";
            this.rbMoto.Size = new System.Drawing.Size(60, 21);
            this.rbMoto.TabIndex = 5;
            this.rbMoto.TabStop = true;
            this.rbMoto.Text = "Moto";
            this.rbMoto.UseVisualStyleBackColor = true;
            this.rbMoto.CheckedChanged += new System.EventHandler(this.rbMoto_CheckedChanged);
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBet.Location = new System.Drawing.Point(358, 460);
            this.btnBet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(167, 80);
            this.btnBet.TabIndex = 7;
            this.btnBet.Text = "Place Bet!";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // udBoxBet
            // 
            this.udBoxBet.Location = new System.Drawing.Point(116, 448);
            this.udBoxBet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.udBoxBet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udBoxBet.Name = "udBoxBet";
            this.udBoxBet.Size = new System.Drawing.Size(75, 22);
            this.udBoxBet.TabIndex = 8;
            // 
            // udBoxDog
            // 
            this.udBoxDog.Location = new System.Drawing.Point(116, 506);
            this.udBoxDog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.udBoxDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udBoxDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udBoxDog.Name = "udBoxDog";
            this.udBoxDog.Size = new System.Drawing.Size(75, 22);
            this.udBoxDog.TabIndex = 9;
            this.udBoxDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRace.Enabled = false;
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRace.Location = new System.Drawing.Point(704, 460);
            this.btnRace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(167, 80);
            this.btnRace.TabIndex = 11;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bet  $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dog  #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bettor Name:     Cash Available:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblJhon
            // 
            this.lblJhon.Location = new System.Drawing.Point(429, 335);
            this.lblJhon.Name = "lblJhon";
            this.lblJhon.Size = new System.Drawing.Size(407, 23);
            this.lblJhon.TabIndex = 22;
            this.lblJhon.Text = "label4";
            // 
            // lblPatlu
            // 
            this.lblPatlu.Location = new System.Drawing.Point(429, 363);
            this.lblPatlu.Name = "lblPatlu";
            this.lblPatlu.Size = new System.Drawing.Size(407, 23);
            this.lblPatlu.TabIndex = 23;
            this.lblPatlu.Text = "label5";
            // 
            // lblMoto
            // 
            this.lblMoto.Location = new System.Drawing.Point(429, 391);
            this.lblMoto.Name = "lblMoto";
            this.lblMoto.Size = new System.Drawing.Size(407, 23);
            this.lblMoto.TabIndex = 24;
            this.lblMoto.Text = "label6";
            // 
            // lblBettor
            // 
            this.lblBettor.AutoSize = true;
            this.lblBettor.Location = new System.Drawing.Point(229, 480);
            this.lblBettor.Name = "lblBettor";
            this.lblBettor.Size = new System.Drawing.Size(46, 17);
            this.lblBettor.TabIndex = 25;
            this.lblBettor.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Bettor:";
            // 
            // btnLockIn
            // 
            this.btnLockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLockIn.Location = new System.Drawing.Point(531, 460);
            this.btnLockIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLockIn.Name = "btnLockIn";
            this.btnLockIn.Size = new System.Drawing.Size(167, 80);
            this.btnLockIn.TabIndex = 27;
            this.btnLockIn.Text = "Lock In Bets!";
            this.btnLockIn.UseVisualStyleBackColor = false;
            this.btnLockIn.Click += new System.EventHandler(this.btnLockIn_Click);
            // 
            // pbDog1
            // 
            this.pbDog1.Image = ((System.Drawing.Image)(resources.GetObject("pbDog1.Image")));
            this.pbDog1.Location = new System.Drawing.Point(64, 31);
            this.pbDog1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDog1.Name = "pbDog1";
            this.pbDog1.Size = new System.Drawing.Size(81, 48);
            this.pbDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog1.TabIndex = 17;
            this.pbDog1.TabStop = false;
            // 
            // pbDog4
            // 
            this.pbDog4.Image = ((System.Drawing.Image)(resources.GetObject("pbDog4.Image")));
            this.pbDog4.Location = new System.Drawing.Point(64, 233);
            this.pbDog4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDog4.Name = "pbDog4";
            this.pbDog4.Size = new System.Drawing.Size(81, 37);
            this.pbDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog4.TabIndex = 20;
            this.pbDog4.TabStop = false;
            // 
            // pbDog3
            // 
            this.pbDog3.Image = ((System.Drawing.Image)(resources.GetObject("pbDog3.Image")));
            this.pbDog3.Location = new System.Drawing.Point(64, 162);
            this.pbDog3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDog3.Name = "pbDog3";
            this.pbDog3.Size = new System.Drawing.Size(81, 47);
            this.pbDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog3.TabIndex = 19;
            this.pbDog3.TabStop = false;
            // 
            // pbDog2
            // 
            this.pbDog2.Image = ((System.Drawing.Image)(resources.GetObject("pbDog2.Image")));
            this.pbDog2.Location = new System.Drawing.Point(64, 100);
            this.pbDog2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDog2.Name = "pbDog2";
            this.pbDog2.Size = new System.Drawing.Size(81, 37);
            this.pbDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog2.TabIndex = 18;
            this.pbDog2.TabStop = false;
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.Image = ((System.Drawing.Image)(resources.GetObject("pbRaceTrack.Image")));
            this.pbRaceTrack.Location = new System.Drawing.Point(12, 6);
            this.pbRaceTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(859, 293);
            this.pbRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaceTrack.TabIndex = 21;
            this.pbRaceTrack.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(875, 551);
            this.Controls.Add(this.btnLockIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBettor);
            this.Controls.Add(this.lblMoto);
            this.Controls.Add(this.lblPatlu);
            this.Controls.Add(this.lblJhon);
            this.Controls.Add(this.pbDog1);
            this.Controls.Add(this.pbDog4);
            this.Controls.Add(this.pbDog3);
            this.Controls.Add(this.pbDog2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.udBoxDog);
            this.Controls.Add(this.udBoxBet);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.rbMoto);
            this.Controls.Add(this.rbPatlu);
            this.Controls.Add(this.rbJhon);
            this.Controls.Add(this.pbRaceTrack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Dog Race!";
            ((System.ComponentModel.ISupportInitialize)(this.udBoxBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbJhon;
        private System.Windows.Forms.RadioButton rbPatlu;
        private System.Windows.Forms.RadioButton rbMoto;
        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.NumericUpDown udBoxBet;
        private System.Windows.Forms.NumericUpDown udBoxDog;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbDog1;
        private System.Windows.Forms.PictureBox pbDog2;
        private System.Windows.Forms.PictureBox pbDog3;
        private System.Windows.Forms.PictureBox pbDog4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblJhon;
        private System.Windows.Forms.Label lblPatlu;
        private System.Windows.Forms.Label lblMoto;
        private System.Windows.Forms.Label lblBettor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLockIn;
    }
}
