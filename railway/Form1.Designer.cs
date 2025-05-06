namespace project
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            label1 = new Label();
            guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            password = new Guna.UI2.WinForms.Guna2TextBox();
            user = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2GradientCircleButton1
            // 
            guna2GradientCircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientCircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientCircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientCircleButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientCircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientCircleButton1.FillColor = Color.Crimson;
            guna2GradientCircleButton1.FillColor2 = Color.FromArgb(128, 64, 64);
            guna2GradientCircleButton1.Font = new Font("Segoe UI", 9F);
            guna2GradientCircleButton1.ForeColor = Color.White;
            guna2GradientCircleButton1.Location = new Point(-181, 1);
            guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            guna2GradientCircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2GradientCircleButton1.Size = new Size(365, 499);
            guna2GradientCircleButton1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(423, 47);
            label1.Name = "label1";
            label1.Size = new Size(124, 35);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            label1.Click += label1_Click;
            // 
            // guna2TileButton1
            // 
            guna2TileButton1.CustomizableEdges = customizableEdges2;
            guna2TileButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2TileButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2TileButton1.FillColor = Color.Crimson;
            guna2TileButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2TileButton1.ForeColor = Color.Black;
            guna2TileButton1.Location = new Point(423, 360);
            guna2TileButton1.Name = "guna2TileButton1";
            guna2TileButton1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2TileButton1.Size = new Size(193, 54);
            guna2TileButton1.TabIndex = 2;
            guna2TileButton1.Text = "Login";
            guna2TileButton1.Click += guna2TileButton1_Click;
            // 
            // password
            // 
            password.CustomizableEdges = customizableEdges4;
            password.DefaultText = "";
            password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            password.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            password.Location = new Point(386, 247);
            password.Margin = new Padding(4, 5, 4, 5);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "";
            password.SelectedText = "";
            password.ShadowDecoration.CustomizableEdges = customizableEdges5;
            password.Size = new Size(288, 41);
            password.TabIndex = 3;
            password.KeyPress += password_KeyPress;
            // 
            // user
            // 
            user.CustomizableEdges = customizableEdges6;
            user.DefaultText = "";
            user.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            user.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            user.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            user.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            user.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            user.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            user.Location = new Point(386, 161);
            user.Margin = new Padding(4, 5, 4, 5);
            user.Name = "user";
            user.PasswordChar = '\0';
            user.PlaceholderText = "";
            user.SelectedText = "";
            user.ShadowDecoration.CustomizableEdges = customizableEdges7;
            user.Size = new Size(288, 41);
            user.TabIndex = 4;
            user.TextChanged += user_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_train_50;
            pictureBox1.Location = new Point(220, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(231, 173);
            label2.Name = "label2";
            label2.Size = new Size(125, 29);
            label2.TabIndex = 6;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(231, 259);
            label3.Name = "label3";
            label3.Size = new Size(111, 29);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(694, 12);
            label4.Name = "label4";
            label4.Size = new Size(30, 35);
            label4.TabIndex = 8;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 496);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(user);
            Controls.Add(password);
            Controls.Add(guna2TileButton1);
            Controls.Add(label1);
            Controls.Add(guna2GradientCircleButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2TextBox user;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
