namespace QLThue.Views
{
    partial class Form2
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
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.TAOPHIEUTHUEbt = new System.Windows.Forms.Button();
            this.TINHTRANGbt = new System.Windows.Forms.Button();
            this.KHACHHANGbt = new System.Windows.Forms.Button();
            this.SANPHAMbt = new System.Windows.Forms.Button();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Menu.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.SystemColors.Info;
            this.panel_Menu.Controls.Add(this.TAOPHIEUTHUEbt);
            this.panel_Menu.Controls.Add(this.TINHTRANGbt);
            this.panel_Menu.Controls.Add(this.KHACHHANGbt);
            this.panel_Menu.Controls.Add(this.SANPHAMbt);
            this.panel_Menu.Controls.Add(this.panel_Top);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Menu.Location = new System.Drawing.Point(912, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(262, 652);
            this.panel_Menu.TabIndex = 0;
            // 
            // TAOPHIEUTHUEbt
            // 
            this.TAOPHIEUTHUEbt.Dock = System.Windows.Forms.DockStyle.Top;
            this.TAOPHIEUTHUEbt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAOPHIEUTHUEbt.Location = new System.Drawing.Point(0, 449);
            this.TAOPHIEUTHUEbt.Name = "TAOPHIEUTHUEbt";
            this.TAOPHIEUTHUEbt.Size = new System.Drawing.Size(262, 70);
            this.TAOPHIEUTHUEbt.TabIndex = 3;
            this.TAOPHIEUTHUEbt.Text = "TẠO PHIẾU THUÊ";
            this.TAOPHIEUTHUEbt.UseVisualStyleBackColor = true;
            this.TAOPHIEUTHUEbt.Click += new System.EventHandler(this.TAOPHIEUTHUEbt_Click);
            // 
            // TINHTRANGbt
            // 
            this.TINHTRANGbt.Dock = System.Windows.Forms.DockStyle.Top;
            this.TINHTRANGbt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TINHTRANGbt.Location = new System.Drawing.Point(0, 379);
            this.TINHTRANGbt.Name = "TINHTRANGbt";
            this.TINHTRANGbt.Size = new System.Drawing.Size(262, 70);
            this.TINHTRANGbt.TabIndex = 2;
            this.TINHTRANGbt.Text = "TÌNH TRẠNG CHO THUÊ";
            this.TINHTRANGbt.UseVisualStyleBackColor = true;
            this.TINHTRANGbt.Click += new System.EventHandler(this.TINHTRANGbt_Click);
            // 
            // KHACHHANGbt
            // 
            this.KHACHHANGbt.Dock = System.Windows.Forms.DockStyle.Top;
            this.KHACHHANGbt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KHACHHANGbt.Location = new System.Drawing.Point(0, 309);
            this.KHACHHANGbt.Name = "KHACHHANGbt";
            this.KHACHHANGbt.Size = new System.Drawing.Size(262, 70);
            this.KHACHHANGbt.TabIndex = 1;
            this.KHACHHANGbt.Text = "KHÁCH HÀNG";
            this.KHACHHANGbt.UseVisualStyleBackColor = true;
            this.KHACHHANGbt.Click += new System.EventHandler(this.KHACHHANGbt_Click);
            // 
            // SANPHAMbt
            // 
            this.SANPHAMbt.Dock = System.Windows.Forms.DockStyle.Top;
            this.SANPHAMbt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SANPHAMbt.Location = new System.Drawing.Point(0, 239);
            this.SANPHAMbt.Name = "SANPHAMbt";
            this.SANPHAMbt.Size = new System.Drawing.Size(262, 70);
            this.SANPHAMbt.TabIndex = 0;
            this.SANPHAMbt.Text = "SẢN PHẨM";
            this.SANPHAMbt.UseVisualStyleBackColor = true;
            this.SANPHAMbt.Click += new System.EventHandler(this.SANPHAMbt_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(912, 652);
            this.panel_Body.TabIndex = 1;
            // 
            // panel_Top
            // 
            this.panel_Top.BackgroundImage = global::QLThue.Properties.Resources.hutao;
            this.panel_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(262, 239);
            this.panel_Top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 652);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Menu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel_Menu.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button TAOPHIEUTHUEbt;
        private System.Windows.Forms.Button TINHTRANGbt;
        private System.Windows.Forms.Button KHACHHANGbt;
        private System.Windows.Forms.Button SANPHAMbt;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Label label1;
    }
}