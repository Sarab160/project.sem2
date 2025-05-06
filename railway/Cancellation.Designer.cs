namespace project
{
    partial class Cancellation
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cancellation));
            panel1 = new Panel();
            Ticid = new ComboBox();
            label6 = new Label();
            reset = new Guna.UI2.WinForms.Guna2TileButton();
            cancel = new Guna.UI2.WinForms.Guna2TileButton();
            label5 = new Label();
            cagdv = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cagdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Ticid);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(reset);
            panel1.Controls.Add(cancel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cagdv);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(1266, 688);
            panel1.TabIndex = 3;
            // 
            // Ticid
            // 
            Ticid.FormattingEnabled = true;
            Ticid.Items.AddRange(new object[] { "1234", "1344", "2567", "3537", "3578", "2345" });
            Ticid.Location = new Point(545, 146);
            Ticid.Name = "Ticid";
            Ticid.Size = new Size(182, 33);
            Ticid.TabIndex = 28;
            Ticid.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(128, 64, 0);
            label6.Location = new Point(545, 86);
            label6.Name = "label6";
            label6.Size = new Size(109, 35);
            label6.TabIndex = 27;
            label6.Text = "TicketID";
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
            reset.Location = new Point(678, 219);
            reset.Name = "reset";
            reset.ShadowDecoration.CustomizableEdges = customizableEdges2;
            reset.Size = new Size(193, 54);
            reset.TabIndex = 26;
            reset.Text = "Back";
            reset.Click += reset_Click;
            // 
            // cancel
            // 
            cancel.CustomizableEdges = customizableEdges3;
            cancel.DisabledState.BorderColor = Color.DarkGray;
            cancel.DisabledState.CustomBorderColor = Color.DarkGray;
            cancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cancel.FillColor = Color.Crimson;
            cancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel.ForeColor = Color.Black;
            cancel.Location = new Point(398, 219);
            cancel.Name = "cancel";
            cancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cancel.Size = new Size(193, 54);
            cancel.TabIndex = 25;
            cancel.Text = "Cancel";
            cancel.Click += guna2TileButton3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(128, 64, 64);
            label5.Location = new Point(545, 296);
            label5.Name = "label5";
            label5.Size = new Size(205, 35);
            label5.TabIndex = 22;
            label5.Text = "Cancellation List";
            // 
            // cagdv
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            cagdv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            cagdv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            cagdv.ColumnHeadersHeight = 25;
            cagdv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            cagdv.DefaultCellStyle = dataGridViewCellStyle3;
            cagdv.GridColor = Color.FromArgb(231, 229, 255);
            cagdv.Location = new Point(96, 347);
            cagdv.Name = "cagdv";
            cagdv.RowHeadersVisible = false;
            cagdv.RowHeadersWidth = 62;
            cagdv.Size = new Size(1089, 322);
            cagdv.TabIndex = 21;
            cagdv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            cagdv.ThemeStyle.AlternatingRowsStyle.Font = null;
            cagdv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            cagdv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            cagdv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            cagdv.ThemeStyle.BackColor = Color.White;
            cagdv.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            cagdv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            cagdv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            cagdv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            cagdv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            cagdv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            cagdv.ThemeStyle.HeaderStyle.Height = 25;
            cagdv.ThemeStyle.ReadOnly = false;
            cagdv.ThemeStyle.RowsStyle.BackColor = Color.White;
            cagdv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            cagdv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            cagdv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            cagdv.ThemeStyle.RowsStyle.Height = 33;
            cagdv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            cagdv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(755, 3);
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
            label1.Size = new Size(248, 35);
            label1.TabIndex = 2;
            label1.Text = "Cancellation Master";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(520, 1);
            label7.Name = "label7";
            label7.Size = new Size(211, 35);
            label7.TabIndex = 31;
            label7.Text = "National Railway";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1212, 1);
            label9.Name = "label9";
            label9.Size = new Size(30, 35);
            label9.TabIndex = 33;
            label9.Text = "X";
            label9.Click += label9_Click;
            // 
            // Cancellation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(1267, 765);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cancellation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cancellation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cagdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox Ticid;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TileButton reset;
        private Guna.UI2.WinForms.Guna2TileButton cancel;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView cagdv;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label7;
        private Label label9;
    }
}