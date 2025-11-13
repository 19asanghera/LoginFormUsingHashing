namespace LoginFormUsingHashing
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
            txtUserName = new TextBox();
            txtPwd = new TextBox();
            txtPwd2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblPwd2 = new Label();
            btnLogin = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(137, 12);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(137, 41);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(100, 23);
            txtPwd.TabIndex = 1;
            // 
            // txtPwd2
            // 
            txtPwd2.Location = new Point(137, 70);
            txtPwd2.Name = "txtPwd2";
            txtPwd2.Size = new Size(100, 23);
            txtPwd2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 15);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 41);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // lblPwd2
            // 
            lblPwd2.AutoSize = true;
            lblPwd2.Location = new Point(20, 73);
            lblPwd2.Name = "lblPwd2";
            lblPwd2.Size = new Size(105, 15);
            lblPwd2.TabIndex = 3;
            lblPwd2.Text = "Re-Enter Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(255, 15);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 49);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 110);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "New Account";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 144);
            Controls.Add(checkBox1);
            Controls.Add(btnLogin);
            Controls.Add(lblPwd2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPwd2);
            Controls.Add(txtPwd);
            Controls.Add(txtUserName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPwd;
        private TextBox txtPwd2;
        private Label label1;
        private Label label2;
        private Label lblPwd2;
        private Button btnLogin;
        private CheckBox checkBox1;
    }
}
