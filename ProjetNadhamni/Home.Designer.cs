namespace ProjetNadhamni
{
    partial class Home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.txt_username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pic_fb = new System.Windows.Forms.PictureBox();
            this.pic_google = new System.Windows.Forms.PictureBox();
            this.pic_twitter = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.exitHome = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnUpPic = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSignIn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.circularPic1 = new ProjetNadhamni.CircularPic();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_google)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_twitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPic1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.HideSelection = false;
            this.txt_username.Location = new System.Drawing.Point(75, 147);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(180, 15);
            this.txt_username.TabIndex = 2;
            this.txt_username.TabStop = false;
            this.txt_username.Text = "Username";
            this.txt_username.Click += new System.EventHandler(this.txt_username_click);
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(45, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.HideSelection = false;
            this.txt_password.Location = new System.Drawing.Point(75, 188);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(180, 15);
            this.txt_password.TabIndex = 5;
            this.txt_password.TabStop = false;
            this.txt_password.Text = "Password";
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Email.HideSelection = false;
            this.txt_Email.Location = new System.Drawing.Point(75, 230);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(180, 15);
            this.txt_Email.TabIndex = 6;
            this.txt_Email.TabStop = false;
            this.txt_Email.Text = "Email";
            this.txt_Email.Click += new System.EventHandler(this.txt_Email_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(45, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(45, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 9;
            // 
            // pic_fb
            // 
            this.pic_fb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_fb.Image = global::ProjetNadhamni.Properties.Resources.facebook__4_;
            this.pic_fb.Location = new System.Drawing.Point(76, 384);
            this.pic_fb.Name = "pic_fb";
            this.pic_fb.Size = new System.Drawing.Size(40, 40);
            this.pic_fb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_fb.TabIndex = 16;
            this.pic_fb.TabStop = false;
            this.pic_fb.Click += new System.EventHandler(this.pic_fb_Click);
            // 
            // pic_google
            // 
            this.pic_google.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_google.Image = global::ProjetNadhamni.Properties.Resources.google_plus;
            this.pic_google.Location = new System.Drawing.Point(124, 384);
            this.pic_google.Name = "pic_google";
            this.pic_google.Size = new System.Drawing.Size(40, 40);
            this.pic_google.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_google.TabIndex = 15;
            this.pic_google.TabStop = false;
            this.pic_google.Click += new System.EventHandler(this.pic_google_Click);
            // 
            // pic_twitter
            // 
            this.pic_twitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_twitter.Image = global::ProjetNadhamni.Properties.Resources.twitter;
            this.pic_twitter.Location = new System.Drawing.Point(170, 384);
            this.pic_twitter.Name = "pic_twitter";
            this.pic_twitter.Size = new System.Drawing.Size(40, 40);
            this.pic_twitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_twitter.TabIndex = 14;
            this.pic_twitter.TabStop = false;
            this.pic_twitter.Click += new System.EventHandler(this.pic_twitter_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjetNadhamni.Properties.Resources.email;
            this.pictureBox4.Location = new System.Drawing.Point(45, 221);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjetNadhamni.Properties.Resources.password__1_;
            this.pictureBox3.Location = new System.Drawing.Point(45, 179);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetNadhamni.Properties.Resources.user__1_;
            this.pictureBox2.Location = new System.Drawing.Point(45, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(109, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Login with ?";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // exitHome
            // 
            this.exitHome.AutoSize = true;
            this.exitHome.ForeColor = System.Drawing.Color.White;
            this.exitHome.Location = new System.Drawing.Point(279, 9);
            this.exitHome.Name = "exitHome";
            this.exitHome.Size = new System.Drawing.Size(14, 13);
            this.exitHome.TabIndex = 30;
            this.exitHome.Text = "X";
            this.exitHome.Click += new System.EventHandler(this.exitHome_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 10;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 10;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(92, 258);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 17);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Still remember Me ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnUpPic
            // 
            this.btnUpPic.ActiveBorderThickness = 1;
            this.btnUpPic.ActiveCornerRadius = 20;
            this.btnUpPic.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnUpPic.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpPic.ActiveLineColor = System.Drawing.Color.Silver;
            this.btnUpPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnUpPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpPic.BackgroundImage")));
            this.btnUpPic.ButtonText = "Upload";
            this.btnUpPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpPic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpPic.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnUpPic.IdleBorderThickness = 2;
            this.btnUpPic.IdleCornerRadius = 20;
            this.btnUpPic.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnUpPic.IdleForecolor = System.Drawing.Color.White;
            this.btnUpPic.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnUpPic.Location = new System.Drawing.Point(88, 95);
            this.btnUpPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpPic.Name = "btnUpPic";
            this.btnUpPic.Size = new System.Drawing.Size(122, 37);
            this.btnUpPic.TabIndex = 108;
            this.btnUpPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpPic.Click += new System.EventHandler(this.btnUpPic_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.ActiveBorderThickness = 1;
            this.btnSignIn.ActiveCornerRadius = 20;
            this.btnSignIn.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnSignIn.ActiveForecolor = System.Drawing.Color.White;
            this.btnSignIn.ActiveLineColor = System.Drawing.Color.Silver;
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignIn.BackgroundImage")));
            this.btnSignIn.ButtonText = "Sign In";
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.IdleBorderThickness = 2;
            this.btnSignIn.IdleCornerRadius = 20;
            this.btnSignIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnSignIn.IdleForecolor = System.Drawing.Color.White;
            this.btnSignIn.IdleLineColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(45, 282);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(210, 37);
            this.btnSignIn.TabIndex = 109;
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveBorderThickness = 1;
            this.btnRegister.ActiveCornerRadius = 20;
            this.btnRegister.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnRegister.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegister.ActiveLineColor = System.Drawing.Color.Silver;
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.ButtonText = "Register";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnRegister.IdleBorderThickness = 2;
            this.btnRegister.IdleCornerRadius = 20;
            this.btnRegister.IdleFillColor = System.Drawing.Color.White;
            this.btnRegister.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnRegister.IdleLineColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(45, 317);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(210, 37);
            this.btnRegister.TabIndex = 110;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // circularPic1
            // 
            this.circularPic1.Image = ((System.Drawing.Image)(resources.GetObject("circularPic1.Image")));
            this.circularPic1.Location = new System.Drawing.Point(112, 25);
            this.circularPic1.Name = "circularPic1";
            this.circularPic1.Size = new System.Drawing.Size(71, 76);
            this.circularPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPic1.TabIndex = 111;
            this.circularPic1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(305, 446);
            this.Controls.Add(this.circularPic1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnUpPic);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.exitHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_fb);
            this.Controls.Add(this.pic_google);
            this.Controls.Add(this.pic_twitter);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_fb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_google)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_twitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pic_twitter;
        private System.Windows.Forms.PictureBox pic_google;
        private System.Windows.Forms.PictureBox pic_fb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label exitHome;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.CheckBox checkBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpPic;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignIn;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private CircularPic circularPic1;
    }
}

