namespace DiscordNETOP.Core
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.login = new FlatUI.FlatButton();
            this.exit = new FlatUI.FlatButton();
            this.formSkin1 = new FlatUI.FormSkin();
            this.label1 = new System.Windows.Forms.Label();
            this.flatTextBox2 = new FlatUI.FlatTextBox();
            this.flatTextBox1 = new FlatUI.FlatTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flatAlertBox1 = new FlatUI.FlatAlertBox();
            this.formSkin1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.login.Location = new System.Drawing.Point(150, 300);
            this.login.Name = "login";
            this.login.Rounded = false;
            this.login.Size = new System.Drawing.Size(500, 50);
            this.login.TabIndex = 0;
            this.login.Text = "Connect";
            this.login.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.login.Click += new System.EventHandler(this.login_ClickAsync);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exit.Location = new System.Drawing.Point(150, 375);
            this.exit.Name = "exit";
            this.exit.Rounded = false;
            this.exit.Size = new System.Drawing.Size(500, 50);
            this.exit.TabIndex = 1;
            this.exit.Text = "Cancel";
            this.exit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatAlertBox1);
            this.formSkin1.Controls.Add(this.label1);
            this.formSkin1.Controls.Add(this.flatTextBox2);
            this.formSkin1.Controls.Add(this.flatTextBox1);
            this.formSkin1.Controls.Add(this.panel1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(800, 450);
            this.formSkin1.TabIndex = 2;
            this.formSkin1.Text = "Discord NETOP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 81);
            this.label1.TabIndex = 5;
            this.label1.Text = "Discord NETOP";
            // 
            // flatTextBox2
            // 
            this.flatTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox2.FocusOnHover = false;
            this.flatTextBox2.Location = new System.Drawing.Point(150, 220);
            this.flatTextBox2.MaxLength = 32767;
            this.flatTextBox2.Multiline = false;
            this.flatTextBox2.Name = "flatTextBox2";
            this.flatTextBox2.ReadOnly = false;
            this.flatTextBox2.Size = new System.Drawing.Size(500, 34);
            this.flatTextBox2.TabIndex = 4;
            this.flatTextBox2.Text = "Client ID";
            this.flatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox2.UseSystemPasswordChar = false;
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox1.FocusOnHover = false;
            this.flatTextBox1.Location = new System.Drawing.Point(150, 260);
            this.flatTextBox1.MaxLength = 32767;
            this.flatTextBox1.Multiline = false;
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.ReadOnly = false;
            this.flatTextBox1.Size = new System.Drawing.Size(500, 34);
            this.flatTextBox1.TabIndex = 3;
            this.flatTextBox1.Text = "Client Token";
            this.flatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox1.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // flatAlertBox1
            // 
            this.flatAlertBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatAlertBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatAlertBox1.kind = FlatUI.FlatAlertBox._Kind.Error;
            this.flatAlertBox1.Location = new System.Drawing.Point(114, 60);
            this.flatAlertBox1.Name = "flatAlertBox1";
            this.flatAlertBox1.Size = new System.Drawing.Size(576, 42);
            this.flatAlertBox1.TabIndex = 6;
            this.flatAlertBox1.Text = "Invalid Client ID";
            this.flatAlertBox1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.login);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord NETOP";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FlatButton login;
        private FlatUI.FlatButton exit;
        private FlatUI.FormSkin formSkin1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FlatUI.FlatTextBox flatTextBox2;
        private FlatUI.FlatTextBox flatTextBox1;
        private FlatUI.FlatAlertBox flatAlertBox1;
    }
}