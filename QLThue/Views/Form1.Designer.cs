namespace QLThue
{
    partial class Form1
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
            this.Login = new System.Windows.Forms.Label();
            this.Acc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.LoginAcc = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Crimson;
            this.Login.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Login.Location = new System.Drawing.Point(244, 36);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(238, 50);
            this.Login.TabIndex = 0;
            this.Login.Text = "ĐĂNG NHẬP";
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Acc
            // 
            this.Acc.AutoSize = true;
            this.Acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc.Location = new System.Drawing.Point(107, 175);
            this.Acc.Name = "Acc";
            this.Acc.Size = new System.Drawing.Size(108, 25);
            this.Acc.TabIndex = 1;
            this.Acc.Text = "Tài khoản";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(248, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(107, 246);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(101, 25);
            this.Pass.TabIndex = 4;
            this.Pass.Text = "Mật khẩu";
            // 
            // LoginAcc
            // 
            this.LoginAcc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAcc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginAcc.Location = new System.Drawing.Point(234, 328);
            this.LoginAcc.Name = "LoginAcc";
            this.LoginAcc.Size = new System.Drawing.Size(152, 42);
            this.LoginAcc.TabIndex = 5;
            this.LoginAcc.Text = "ĐĂNG NHẬP";
            this.LoginAcc.UseVisualStyleBackColor = true;
            this.LoginAcc.Click += new System.EventHandler(this.LoginAcc_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Firebrick;
            this.Exit.Location = new System.Drawing.Point(481, 315);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(115, 55);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 434);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LoginAcc);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Acc);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Acc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Button LoginAcc;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

