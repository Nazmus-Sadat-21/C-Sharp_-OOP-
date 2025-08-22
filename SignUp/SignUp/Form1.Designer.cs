namespace SignUp
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
            label = new Label();
            button1 = new Button();
            nbox = new TextBox();
            label2 = new Label();
            ebox = new TextBox();
            label1 = new Label();
            mbox = new TextBox();
            label3 = new Label();
            nation = new TextBox();
            label4 = new Label();
            passbox = new TextBox();
            label5 = new Label();
            retypepassbox = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(31, 115);
            label.Name = "label";
            label.Size = new Size(177, 38);
            label.TabIndex = 0;
            label.Text = "User Name :";
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.Window;
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(417, 566);
            button1.Name = "button1";
            button1.Size = new Size(156, 52);
            button1.TabIndex = 1;
            button1.Text = "SignUp";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // nbox
            // 
            nbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nbox.Location = new Point(214, 119);
            nbox.Name = "nbox";
            nbox.Size = new Size(359, 34);
            nbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(230, 26);
            label2.Name = "label2";
            label2.Size = new Size(137, 46);
            label2.TabIndex = 3;
            label2.Text = "SignUp";
            // 
            // ebox
            // 
            ebox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ebox.Location = new Point(214, 190);
            ebox.Name = "ebox";
            ebox.Size = new Size(359, 34);
            ebox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 186);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 4;
            label1.Text = "Email :";
            // 
            // mbox
            // 
            mbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mbox.Location = new Point(214, 269);
            mbox.Name = "mbox";
            mbox.Size = new Size(359, 34);
            mbox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 265);
            label3.Name = "label3";
            label3.Size = new Size(176, 38);
            label3.TabIndex = 6;
            label3.Text = "Mobile NO :";
            // 
            // nation
            // 
            nation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nation.Location = new Point(214, 352);
            nation.Name = "nation";
            nation.Size = new Size(359, 34);
            nation.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 348);
            label4.Name = "label4";
            label4.Size = new Size(180, 38);
            label4.TabIndex = 8;
            label4.Text = "Nationality :";
            // 
            // passbox
            // 
            passbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passbox.Location = new Point(214, 420);
            passbox.Name = "passbox";
            passbox.Size = new Size(359, 34);
            passbox.TabIndex = 12;
            passbox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 416);
            label5.Name = "label5";
            label5.Size = new Size(155, 38);
            label5.TabIndex = 11;
            label5.Text = "Password :";
            // 
            // retypepassbox
            // 
            retypepassbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            retypepassbox.Location = new Point(217, 488);
            retypepassbox.Name = "retypepassbox";
            retypepassbox.Size = new Size(359, 34);
            retypepassbox.TabIndex = 15;
            retypepassbox.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 484);
            label6.Name = "label6";
            label6.Size = new Size(187, 38);
            label6.TabIndex = 14;
            label6.Text = "Retype pass :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 661);
            Controls.Add(retypepassbox);
            Controls.Add(label6);
            Controls.Add(passbox);
            Controls.Add(label5);
            Controls.Add(nation);
            Controls.Add(label4);
            Controls.Add(mbox);
            Controls.Add(label3);
            Controls.Add(ebox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(nbox);
            Controls.Add(button1);
            Controls.Add(label);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Button button1;
        private TextBox nbox;
        private Label label2;
        private TextBox ebox;
        private Label label1;
        private TextBox mbox;
        private Label label3;
        private TextBox nation;
        private Label label4;
        private TextBox passbox;
        private Label label5;
        private TextBox retypepassbox;
        private Label label6;
    }
}
