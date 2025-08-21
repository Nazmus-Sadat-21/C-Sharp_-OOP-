namespace LoginForm
{
    partial class Message
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
            label1 = new Label();
            logout = new Button();
            mssgbox = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 106);
            label1.Name = "label1";
            label1.Size = new Size(0, 54);
            label1.TabIndex = 0;
            // 
            // logout
            // 
            logout.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.Location = new Point(127, 258);
            logout.Name = "logout";
            logout.Size = new Size(211, 59);
            logout.TabIndex = 1;
            logout.Text = "logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // mssgbox
            // 
            mssgbox.AutoSize = true;
            mssgbox.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mssgbox.Location = new Point(174, 97);
            mssgbox.Name = "mssgbox";
            mssgbox.Size = new Size(137, 54);
            mssgbox.TabIndex = 2;
            mssgbox.Text = "label2";
            mssgbox.Click += mssgbox_Click;
            // 
            // Message
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 354);
            Controls.Add(mssgbox);
            Controls.Add(logout);
            Controls.Add(label1);
            Name = "Message";
            Text = "Message";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button logout;
        private Label mssgbox;
    }
}