namespace project
{
    partial class Reservation
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            panel1 = new Panel();
            reset = new Guna.UI2.WinForms.Guna2TileButton();
            reserdv = new Guna.UI2.WinForms.Guna2DataGridView();
            travco = new ComboBox();
            label2 = new Label();
            pid = new ComboBox();
            label6 = new Label();
            guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reserdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(reset);
            panel1.Controls.Add(reserdv);
            panel1.Controls.Add(travco);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pid);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(guna2TileButton1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(1271, 763);
            panel1.TabIndex = 3;
            // 
            // reset
            // 
            reset.CustomizableEdges = customizableEdges1;
            reset.DisabledState.BorderColor = Color.DarkGray;
            reset.DisabledState.CustomBorderColor = Color.DarkGray;
            reset.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            reset.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            reset.FillColor = Color.Crimson;
            reset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reset.ForeColor = Color.Black;
            reset.Location = new Point(505, 706);
            reset.Name = "reset";
            reset.ShadowDecoration.CustomizableEdges = customizableEdges2;
            reset.Size = new Size(193, 54);
            reset.TabIndex = 38;
            reset.Text = "Back";
            reset.Click += reset_Click;
            // 
            // reserdv
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            reserdv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            reserdv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            reserdv.ColumnHeadersHeight = 25;
            reserdv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            reserdv.DefaultCellStyle = dataGridViewCellStyle3;
            reserdv.GridColor = Color.FromArgb(231, 229, 255);
            reserdv.Location = new Point(62, 369);
            reserdv.Name = "reserdv";
            reserdv.RowHeadersVisible = false;
            reserdv.RowHeadersWidth = 62;
            reserdv.RowTemplate.Height = 25;
            reserdv.Size = new Size(1185, 331);
            reserdv.TabIndex = 37;
            reserdv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            reserdv.ThemeStyle.AlternatingRowsStyle.Font = null;
            reserdv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            reserdv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            reserdv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            reserdv.ThemeStyle.BackColor = Color.White;
            reserdv.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            reserdv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            reserdv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            reserdv.ThemeStyle.HeaderStyle.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reserdv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            reserdv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            reserdv.ThemeStyle.HeaderStyle.Height = 25;
            reserdv.ThemeStyle.ReadOnly = false;
            reserdv.ThemeStyle.RowsStyle.BackColor = Color.White;
            reserdv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            reserdv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            reserdv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            reserdv.ThemeStyle.RowsStyle.Height = 25;
            reserdv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(192, 192, 255);
            reserdv.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            reserdv.CellContentClick += reserdv_CellContentClick;
            // 
            // travco
            // 
            travco.FormattingEnabled = true;
            travco.Items.AddRange(new object[] { "1245", "1235", "1243", "1245", "1255" });
            travco.Location = new Point(645, 142);
            travco.Name = "travco";
            travco.Size = new Size(182, 33);
            travco.TabIndex = 32;
            travco.SelectionChangeCommitted += travco_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(645, 83);
            label2.Name = "label2";
            label2.Size = new Size(150, 35);
            label2.TabIndex = 31;
            label2.Text = "Travel Code";
            // 
            // pid
            // 
            pid.FormattingEnabled = true;
            pid.Items.AddRange(new object[] { "345", "346", "348", "235", "235", "349" });
            pid.Location = new Point(417, 142);
            pid.Name = "pid";
            pid.Size = new Size(182, 33);
            pid.TabIndex = 28;
            pid.SelectionChangeCommitted += pid_SelectionChangeCommitted;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(128, 64, 0);
            label6.Location = new Point(417, 83);
            label6.Name = "label6";
            label6.Size = new Size(156, 35);
            label6.TabIndex = 27;
            label6.Text = "PassengerID";
            // 
            // guna2TileButton1
            // 
            guna2TileButton1.CustomizableEdges = customizableEdges3;
            guna2TileButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2TileButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2TileButton1.FillColor = Color.Crimson;
            guna2TileButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2TileButton1.ForeColor = Color.Black;
            guna2TileButton1.Location = new Point(501, 213);
            guna2TileButton1.Name = "guna2TileButton1";
            guna2TileButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TileButton1.Size = new Size(231, 54);
            guna2TileButton1.TabIndex = 23;
            guna2TileButton1.Text = "Add Reservation";
            guna2TileButton1.Click += guna2TileButton1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(128, 64, 64);
            label5.Location = new Point(544, 296);
            label5.Name = "label5";
            label5.Size = new Size(199, 35);
            label5.TabIndex = 22;
            label5.Text = "Reservation List";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(749, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(501, 26);
            label1.Name = "label1";
            label1.Size = new Size(242, 35);
            label1.TabIndex = 2;
            label1.Text = "Reservation Master";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(503, 7);
            label7.Name = "label7";
            label7.Size = new Size(211, 35);
            label7.TabIndex = 32;
            label7.Text = "National Railway";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1215, 7);
            label9.Name = "label9";
            label9.Size = new Size(30, 35);
            label9.TabIndex = 33;
            label9.Text = "X";
            label9.Click += label9_Click;
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(1271, 832);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation";
            Load += Reservation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reserdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox pid;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label7;
        private ComboBox travco;
        private Label label2;
        private Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView reserdv;
        private Guna.UI2.WinForms.Guna2TileButton reset;
    }
}