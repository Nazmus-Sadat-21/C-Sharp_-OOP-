namespace SignUp
{
    partial class Confrim
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            name = new Label();
            label2 = new Label();
            username = new Label();
            email = new Label();
            nationality = new Label();
            mobile = new Label();
            pass = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 387);
            label5.Name = "label5";
            label5.Size = new Size(155, 38);
            label5.TabIndex = 24;
            label5.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 327);
            label4.Name = "label4";
            label4.Size = new Size(180, 38);
            label4.TabIndex = 22;
            label4.Text = "Nationality :";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 262);
            label3.Name = "label3";
            label3.Size = new Size(176, 38);
            label3.TabIndex = 20;
            label3.Text = "Mobile NO :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 198);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 18;
            label1.Text = "Email :";
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Transparent;
            name.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(29, 141);
            name.Name = "name";
            name.Size = new Size(177, 38);
            name.TabIndex = 16;
            name.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(135, 43);
            label2.Name = "label2";
            label2.Size = new Size(214, 46);
            label2.TabIndex = 28;
            label2.Text = "Information";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.Location = new Point(237, 141);
            username.Name = "username";
            username.Size = new Size(86, 35);
            username.TabIndex = 29;
            username.Text = "label7";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.Location = new Point(237, 198);
            email.Name = "email";
            email.Size = new Size(86, 35);
            email.TabIndex = 30;
            email.Text = "label8";
            // 
            // nationality
            // 
            nationality.AutoSize = true;
            nationality.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nationality.Location = new Point(237, 329);
            nationality.Name = "nationality";
            nationality.Size = new Size(86, 35);
            nationality.TabIndex = 31;
            nationality.Text = "label9";
            // 
            // mobile
            // 
            mobile.AutoSize = true;
            mobile.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mobile.Location = new Point(237, 265);
            mobile.Name = "mobile";
            mobile.Size = new Size(100, 35);
            mobile.TabIndex = 32;
            mobile.Text = "label10";
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pass.Location = new Point(237, 390);
            pass.Name = "pass";
            pass.Size = new Size(100, 35);
            pass.TabIndex = 33;
            pass.Text = "label11";
            // 
            // Confrim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 475);
            Controls.Add(pass);
            Controls.Add(mobile);
            Controls.Add(nationality);
            Controls.Add(email);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(name);
            Name = "Confrim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confrim";
            Load += Confrim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label name;
        private Label label2;
        private Label username;
        private Label email;
        private Label nationality;
        private Label mobile;
        private Label pass;
    }
}