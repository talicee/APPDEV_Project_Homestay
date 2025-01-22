namespace ALP_Project_02
{
    partial class Table_Guest
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
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_GuestName = new System.Windows.Forms.TextBox();
            this.dgv_Guest = new System.Windows.Forms.DataGridView();
            this.btn_RegistrationGuestBack = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Guest)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_Reset.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(849, 116);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(88, 36);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label22.Location = new System.Drawing.Point(43, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 18);
            this.label22.TabIndex = 23;
            this.label22.Text = "Guest Name :";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_Search.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(151, 116);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(319, 36);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_GuestName
            // 
            this.tb_GuestName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.tb_GuestName.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.tb_GuestName.Location = new System.Drawing.Point(151, 85);
            this.tb_GuestName.Name = "tb_GuestName";
            this.tb_GuestName.Size = new System.Drawing.Size(319, 27);
            this.tb_GuestName.TabIndex = 1;
            // 
            // dgv_Guest
            // 
            this.dgv_Guest.AllowUserToAddRows = false;
            this.dgv_Guest.AllowUserToDeleteRows = false;
            this.dgv_Guest.AllowUserToResizeColumns = false;
            this.dgv_Guest.AllowUserToResizeRows = false;
            this.dgv_Guest.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Guest.Location = new System.Drawing.Point(46, 158);
            this.dgv_Guest.MultiSelect = false;
            this.dgv_Guest.Name = "dgv_Guest";
            this.dgv_Guest.ReadOnly = true;
            this.dgv_Guest.RowHeadersWidth = 62;
            this.dgv_Guest.RowTemplate.Height = 28;
            this.dgv_Guest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Guest.Size = new System.Drawing.Size(891, 353);
            this.dgv_Guest.TabIndex = 20;
            this.dgv_Guest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Guest_CellDoubleClick);
            // 
            // btn_RegistrationGuestBack
            // 
            this.btn_RegistrationGuestBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_RegistrationGuestBack.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_RegistrationGuestBack.ForeColor = System.Drawing.Color.White;
            this.btn_RegistrationGuestBack.Location = new System.Drawing.Point(829, 24);
            this.btn_RegistrationGuestBack.Name = "btn_RegistrationGuestBack";
            this.btn_RegistrationGuestBack.Size = new System.Drawing.Size(108, 36);
            this.btn_RegistrationGuestBack.TabIndex = 4;
            this.btn_RegistrationGuestBack.Text = "Back";
            this.btn_RegistrationGuestBack.UseVisualStyleBackColor = false;
            this.btn_RegistrationGuestBack.Click += new System.EventHandler(this.btn_RegistrationGuestBack_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana Pro Cond", 14F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(40, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(153, 34);
            this.label21.TabIndex = 69;
            this.label21.Text = "Guest Data";
            // 
            // Table_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btn_RegistrationGuestBack);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_GuestName);
            this.Controls.Add(this.dgv_Guest);
            this.MaximizeBox = false;
            this.Name = "Table_Guest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table_Guest";
            this.Load += new System.EventHandler(this.Table_Guest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Guest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_GuestName;
        private System.Windows.Forms.DataGridView dgv_Guest;
        private System.Windows.Forms.Button btn_RegistrationGuestBack;
        private System.Windows.Forms.Label label21;
    }
}