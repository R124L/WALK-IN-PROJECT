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
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodeReservasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niIdentitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(452, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 56);
            this.button1.TabIndex = 17;
            this.button1.Text = "Check-Out";
            this.button1.UseVisualStyleBackColor = false;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeReservasi,
            this.niIdentitas});
            this.dataGridView1.Location = new System.Drawing.Point(72, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 451);
            this.dataGridView1.TabIndex = 14;
            // 
            // kodeReservasi
            // 
            this.kodeReservasi.HeaderText = "Kode Reservasi";
            this.kodeReservasi.MinimumWidth = 6;
            this.kodeReservasi.Name = "kodeReservasi";
            this.kodeReservasi.Width = 125;
            // 
            // niIdentitas
            // 
            this.niIdentitas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.niIdentitas.HeaderText = "No Identitas";
            this.niIdentitas.MinimumWidth = 6;
            this.niIdentitas.Name = "niIdentitas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 52);
            this.label1.TabIndex = 13;
            this.label1.Text = "Check Out";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "CheckOut";
            this.Size = new System.Drawing.Size(1150, 727);
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeReservasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn niIdentitas;
        private System.Windows.Forms.Label label1;
    }
}
