namespace kazadaev
{
    partial class editing
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
            cancellation = new Button();
            save_click = new Button();
            input = new TextBox();
            input2 = new TextBox();
            inputs1 = new Label();
            inputs2 = new Label();
            input3 = new TextBox();
            input4 = new TextBox();
            input5 = new TextBox();
            inputs3 = new Label();
            inputs4 = new Label();
            inputs5 = new Label();
            domainUpDown1 = new DomainUpDown();
            domainUpDown2 = new DomainUpDown();
            SuspendLayout();
            // 
            // cancellation
            // 
            cancellation.Anchor = AnchorStyles.Top;
            cancellation.Location = new Point(500, 285);
            cancellation.Name = "cancellation";
            cancellation.Size = new Size(75, 23);
            cancellation.TabIndex = 0;
            cancellation.Text = "Отмена";
            cancellation.UseVisualStyleBackColor = true;
            cancellation.Click += cancellation_Click;
            // 
            // save_click
            // 
            save_click.Anchor = AnchorStyles.Top;
            save_click.Location = new Point(597, 285);
            save_click.Name = "save_click";
            save_click.Size = new Size(75, 23);
            save_click.TabIndex = 1;
            save_click.Text = "Сохронить ";
            save_click.UseVisualStyleBackColor = true;
            save_click.Click += save_click_Click;
            // 
            // input
            // 
            input.Anchor = AnchorStyles.Top;
            input.Location = new Point(41, 60);
            input.Name = "input";
            input.Size = new Size(100, 23);
            input.TabIndex = 2;
            // 
            // input2
            // 
            input2.Anchor = AnchorStyles.Top;
            input2.Location = new Point(41, 111);
            input2.Name = "input2";
            input2.Size = new Size(100, 23);
            input2.TabIndex = 3;
            // 
            // inputs1
            // 
            inputs1.Anchor = AnchorStyles.Top;
            inputs1.AutoSize = true;
            inputs1.Location = new Point(41, 42);
            inputs1.Name = "inputs1";
            inputs1.Size = new Size(40, 15);
            inputs1.TabIndex = 4;
            inputs1.Text = "inputs";
            // 
            // inputs2
            // 
            inputs2.Anchor = AnchorStyles.Top;
            inputs2.AutoSize = true;
            inputs2.Location = new Point(41, 93);
            inputs2.Name = "inputs2";
            inputs2.Size = new Size(40, 15);
            inputs2.TabIndex = 5;
            inputs2.Text = "inputs";
            // 
            // input3
            // 
            input3.Anchor = AnchorStyles.Top;
            input3.Location = new Point(234, 60);
            input3.Name = "input3";
            input3.Size = new Size(100, 23);
            input3.TabIndex = 6;
            // 
            // input4
            // 
            input4.Anchor = AnchorStyles.Top;
            input4.Location = new Point(234, 111);
            input4.Name = "input4";
            input4.Size = new Size(100, 23);
            input4.TabIndex = 7;
            // 
            // input5
            // 
            input5.Anchor = AnchorStyles.Top;
            input5.Location = new Point(397, 60);
            input5.Name = "input5";
            input5.Size = new Size(100, 23);
            input5.TabIndex = 8;
            // 
            // inputs3
            // 
            inputs3.Anchor = AnchorStyles.Top;
            inputs3.AutoSize = true;
            inputs3.Location = new Point(234, 42);
            inputs3.Name = "inputs3";
            inputs3.Size = new Size(40, 15);
            inputs3.TabIndex = 9;
            inputs3.Text = "inputs";
            inputs3.Click += label3_Click;
            // 
            // inputs4
            // 
            inputs4.Anchor = AnchorStyles.Top;
            inputs4.AutoSize = true;
            inputs4.Location = new Point(234, 93);
            inputs4.Name = "inputs4";
            inputs4.Size = new Size(40, 15);
            inputs4.TabIndex = 10;
            inputs4.Text = "inputs";
            // 
            // inputs5
            // 
            inputs5.Anchor = AnchorStyles.Top;
            inputs5.AutoSize = true;
            inputs5.Location = new Point(397, 42);
            inputs5.Name = "inputs5";
            inputs5.Size = new Size(40, 15);
            inputs5.TabIndex = 11;
            inputs5.Text = "inputs";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Anchor = AnchorStyles.Top;
            domainUpDown1.Location = new Point(41, 111);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 12;
            // 
            // domainUpDown2
            // 
            domainUpDown2.Anchor = AnchorStyles.Top;
            domainUpDown2.Location = new Point(234, 112);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(120, 23);
            domainUpDown2.TabIndex = 13;
            // 
            // editing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(domainUpDown2);
            Controls.Add(domainUpDown1);
            Controls.Add(inputs5);
            Controls.Add(inputs4);
            Controls.Add(inputs3);
            Controls.Add(input5);
            Controls.Add(input4);
            Controls.Add(input3);
            Controls.Add(inputs2);
            Controls.Add(inputs1);
            Controls.Add(input2);
            Controls.Add(input);
            Controls.Add(save_click);
            Controls.Add(cancellation);
            FormBorderStyle = FormBorderStyle.None;
            Name = "editing";
            Text = "editing";
            Load += editing_Load;
            MouseDown += panelTop_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancellation;
        private Button save_click;
        private TextBox input;
        private TextBox input2;
        private Label inputs1;
        private Label inputs2;
        private TextBox input3;
        private TextBox input4;
        private TextBox input5;
        private Label inputs3;
        private Label inputs4;
        private Label inputs5;
        private DomainUpDown domainUpDown1;
        private DomainUpDown domainUpDown2;
    }
}