namespace WALK_IN_PROJECT
{
    partial class CheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            this.label1 = new System.Windows.Forms.Label();
            this.checkInTable = new System.Windows.Forms.DataGridView();
            this.btnCkeckIn = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.checkInTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check In";
            // 
            // checkInTable
            // 
            this.checkInTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkInTable.Location = new System.Drawing.Point(71, 146);
            this.checkInTable.Name = "checkInTable";
            this.checkInTable.RowHeadersWidth = 40;
            this.checkInTable.RowTemplate.Height = 24;
            this.checkInTable.Size = new System.Drawing.Size(987, 441);
            this.checkInTable.TabIndex = 4;
            this.checkInTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCkeckIn
            // 
            this.btnCkeckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(161)))), ((int)(((byte)(95)))));
            this.btnCkeckIn.FlatAppearance.BorderSize = 0;
            this.btnCkeckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCkeckIn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCkeckIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCkeckIn.Location = new System.Drawing.Point(333, 609);
            this.btnCkeckIn.Name = "btnCkeckIn";
            this.btnCkeckIn.Size = new System.Drawing.Size(183, 53);
            this.btnCkeckIn.TabIndex = 12;
            this.btnCkeckIn.Text = "Check-In";
            this.btnCkeckIn.UseVisualStyleBackColor = false;
            this.btnCkeckIn.Click += new System.EventHandler(this.btnCkeckIn_Click);
            // 
            // btnCancell
            // 
            this.btnCancell.BackColor = System.Drawing.Color.Red;
            this.btnCancell.FlatAppearance.BorderSize = 0;
            this.btnCancell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancell.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancell.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancell.Location = new System.Drawing.Point(596, 609);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(183, 53);
            this.btnCancell.TabIndex = 12;
            this.btnCancell.Text = "Cancell";
            this.btnCancell.UseVisualStyleBackColor = false;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(417, 90);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(285, 33);
            this.bunifuTextbox1.TabIndex = 5;
            this.bunifuTextbox1.text = "Search...";
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.btnCkeckIn);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.checkInTable);
            this.Controls.Add(this.label1);
            this.Name = "CheckIn";
            this.Size = new System.Drawing.Size(1144, 719);
            this.Load += new System.EventHandler(this.CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkInTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView checkInTable;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.Button btnCkeckIn;
        private System.Windows.Forms.Button btnCancell;
    }
}
