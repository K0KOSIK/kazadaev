namespace kazadaev
{
    partial class Avtorisation
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
            business = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Login = new Label();
            Password = new Label();
            button1 = new Button();
            panel1 = new Panel();
            bt_min = new Button();
            bt_max = new Button();
            bt_exit = new Button();
            lbRole = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // business
            // 
            business.Anchor = AnchorStyles.Top;
            business.AutoSize = true;
            business.Font = new Font("Magneto", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            business.ForeColor = SystemColors.ButtonHighlight;
            business.Location = new Point(281, 53);
            business.Name = "business";
            business.Size = new Size(239, 35);
            business.TabIndex = 0;
            business.Text = "business start";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(128, 128, 255);
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(338, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.BackColor = Color.FromArgb(128, 128, 255);
            textBox2.ForeColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(338, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 23);
            textBox2.TabIndex = 2;
            // 
            // Login
            // 
            Login.Anchor = AnchorStyles.Top;
            Login.AutoSize = true;
            Login.Font = new Font("Magneto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.ButtonHighlight;
            Login.Location = new Point(364, 136);
            Login.Name = "Login";
            Login.Size = new Size(73, 24);
            Login.TabIndex = 3;
            Login.Text = "Login";
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Top;
            Password.AutoSize = true;
            Password.Font = new Font("Magneto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.ForeColor = SystemColors.ButtonHighlight;
            Password.Location = new Point(346, 199);
            Password.Name = "Password";
            Password.Size = new Size(109, 24);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Forte", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(353, 350);
            button1.Name = "button1";
            button1.Size = new Size(95, 57);
            button1.TabIndex = 5;
            button1.Text = "ВХОД";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(bt_min);
            panel1.Controls.Add(bt_max);
            panel1.Controls.Add(bt_exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 25);
            panel1.TabIndex = 6;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // bt_min
            // 
            bt_min.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_min.BackColor = Color.Navy;
            bt_min.Location = new Point(716, 0);
            bt_min.Name = "bt_min";
            bt_min.Size = new Size(24, 23);
            bt_min.TabIndex = 2;
            bt_min.UseVisualStyleBackColor = false;
            bt_min.Click += bt_min_Click;
            // 
            // bt_max
            // 
            bt_max.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_max.BackColor = Color.Green;
            bt_max.Location = new Point(746, 0);
            bt_max.Name = "bt_max";
            bt_max.Size = new Size(22, 23);
            bt_max.TabIndex = 1;
            bt_max.UseVisualStyleBackColor = false;
            bt_max.Click += bt_max_Click;
            // 
            // bt_exit
            // 
            bt_exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_exit.BackColor = Color.Red;
            bt_exit.Location = new Point(774, 0);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(23, 23);
            bt_exit.TabIndex = 0;
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // lbRole
            // 
            lbRole.Anchor = AnchorStyles.Top;
            lbRole.Font = new Font("Magneto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRole.ForeColor = SystemColors.ActiveCaption;
            lbRole.Location = new Point(313, 260);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(174, 24);
            lbRole.TabIndex = 7;
            lbRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Avtorisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(lbRole);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(Password);
            Controls.Add(Login);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(business);
            Name = "Avtorisation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Avtorisation";
            Load += Avtorisation_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label business;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Login;
        private Label Password;
        private Button button1;
        private Panel panel1;
        private Button bt_exit;
        private Button bt_max;
        private Button bt_min;
        private Label lbRole;
    }
}
