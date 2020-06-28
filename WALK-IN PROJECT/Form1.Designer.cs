namespace WALK_IN_PROJECT
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTamu = new System.Windows.Forms.Button();
            this.btnReservasi = new System.Windows.Forms.Button();
            this.btnKamar = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1440, 97);
            this.panelHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1294, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(567, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masker Hotel";
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panelNav.Controls.Add(this.btnLogout);
            this.panelNav.Controls.Add(this.btnTamu);
            this.panelNav.Controls.Add(this.btnReservasi);
            this.panelNav.Controls.Add(this.btnKamar);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 97);
            this.panelNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(231, 784);
            this.panelNav.TabIndex = 1;
            this.panelNav.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(35, 277);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 48);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnTamu
            // 
            this.btnTamu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTamu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTamu.Location = new System.Drawing.Point(35, 198);
            this.btnTamu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamu.Name = "btnTamu";
            this.btnTamu.Size = new System.Drawing.Size(158, 48);
            this.btnTamu.TabIndex = 3;
            this.btnTamu.Text = "Tamu";
            this.btnTamu.UseVisualStyleBackColor = true;
            // 
            // btnReservasi
            // 
            this.btnReservasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservasi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReservasi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReservasi.Location = new System.Drawing.Point(35, 119);
            this.btnReservasi.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservasi.Name = "btnReservasi";
            this.btnReservasi.Size = new System.Drawing.Size(158, 48);
            this.btnReservasi.TabIndex = 3;
            this.btnReservasi.Text = "Reservasi";
            this.btnReservasi.UseVisualStyleBackColor = true;
            // 
            // btnKamar
            // 
            this.btnKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKamar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKamar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKamar.Location = new System.Drawing.Point(35, 42);
            this.btnKamar.Margin = new System.Windows.Forms.Padding(4);
            this.btnKamar.Name = "btnKamar";
            this.btnKamar.Size = new System.Drawing.Size(158, 48);
            this.btnKamar.TabIndex = 3;
            this.btnKamar.Text = "Kamar";
            this.btnKamar.UseVisualStyleBackColor = true;
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl.Location = new System.Drawing.Point(228, 97);
            this.panelControl.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1212, 784);
            this.panelControl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 881);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Software Reservasi Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKamar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTamu;
        private System.Windows.Forms.Button btnReservasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelControl;
    }
}

