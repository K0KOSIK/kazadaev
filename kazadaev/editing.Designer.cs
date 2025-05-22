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
            label1 = new Label();
            label2 = new Label();
            input3 = new TextBox();
            input4 = new TextBox();
            input5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // cancellation
            // 
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
            input.Location = new Point(41, 60);
            input.Name = "input";
            input.Size = new Size(100, 23);
            input.TabIndex = 2;
            // 
            // input2
            // 
            input2.Location = new Point(41, 111);
            input2.Name = "input2";
            input2.Size = new Size(100, 23);
            input2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 93);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // input3
            // 
            input3.Location = new Point(234, 60);
            input3.Name = "input3";
            input3.Size = new Size(100, 23);
            input3.TabIndex = 6;
            // 
            // input4
            // 
            input4.Location = new Point(234, 111);
            input4.Name = "input4";
            input4.Size = new Size(100, 23);
            input4.TabIndex = 7;
            // 
            // input5
            // 
            input5.Location = new Point(397, 60);
            input5.Name = "input5";
            input5.Size = new Size(100, 23);
            input5.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 42);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 93);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(397, 42);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 11;
            label5.Text = "label5";
            // 
            // editing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(input5);
            Controls.Add(input4);
            Controls.Add(input3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(input2);
            Controls.Add(input);
            Controls.Add(save_click);
            Controls.Add(cancellation);
            Name = "editing";
            Text = "editing";
            Load += editing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancellation;
        private Button save_click;
        private TextBox input;
        private TextBox input2;
        private Label label1;
        private Label label2;
        private TextBox input3;
        private TextBox input4;
        private TextBox input5;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}