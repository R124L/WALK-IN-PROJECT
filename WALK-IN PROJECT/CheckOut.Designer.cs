namespace WALK_IN_PROJECT
{
    partial class CheckOut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.tabelCheckOut = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckOut.Location = new System.Drawing.Point(452, 657);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(220, 56);
            this.btnCheckOut.TabIndex = 17;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(418, 91);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(285, 33);
            this.bunifuTextbox1.TabIndex = 15;
            this.bunifuTextbox1.text = "Search...";
            // 
            // tabelCheckOut
            // 
            this.tabelCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelCheckOut.Location = new System.Drawing.Point(86, 153);
            this.tabelCheckOut.Name = "tabelCheckOut";
            this.tabelCheckOut.RowHeadersWidth = 40;
            this.tabelCheckOut.RowTemplate.Height = 24;
            this.tabelCheckOut.Size = new System.Drawing.Size(981, 451);
            this.tabelCheckOut.TabIndex = 14;
            this.tabelCheckOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelCheckOut_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 51);
            this.label1.TabIndex = 13;
            this.label1.Text = "Check Out";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.tabelCheckOut);
            this.Controls.Add(this.label1);
            this.Name = "CheckOut";
            this.Size = new System.Drawing.Size(1150, 727);
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckOut;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.DataGridView tabelCheckOut;
        private System.Windows.Forms.Label label1;
    }
}
