namespace SutarciuSistema
{
    partial class logregform
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
            this.userbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.regbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userbox
            // 
            this.userbox.Location = new System.Drawing.Point(327, 107);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(155, 22);
            this.userbox.TabIndex = 0;
            this.userbox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(327, 169);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(155, 22);
            this.passbox.TabIndex = 1;
            this.passbox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "User name";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(308, 241);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(184, 32);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // regbutton
            // 
            this.regbutton.Location = new System.Drawing.Point(308, 313);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(184, 44);
            this.regbutton.TabIndex = 5;
            this.regbutton.Text = "Don\'t have an account? Register";
            this.regbutton.UseVisualStyleBackColor = true;
            this.regbutton.Click += new System.EventHandler(this.Regbutton_Click);
            // 
            // logregform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.userbox);
            this.Name = "logregform";
            this.Text = "logregform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.Button regbutton;
    }
}