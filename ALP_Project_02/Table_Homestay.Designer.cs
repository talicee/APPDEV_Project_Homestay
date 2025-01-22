namespace ALP_Project_02
{
    partial class Table_Homestay
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
            this.dgv_Homestay = new System.Windows.Forms.DataGridView();
            this.tb_RumahName = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_RegistrationGuestBack = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Homestay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Homestay
            // 
            this.dgv_Homestay.AllowUserToAddRows = false;
            this.dgv_Homestay.AllowUserToDeleteRows = false;
            this.dgv_Homestay.AllowUserToResizeColumns = false;
            this.dgv_Homestay.AllowUserToResizeRows = false;
            this.dgv_Homestay.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Homestay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Homestay.Location = new System.Drawing.Point(44, 153);
            this.dgv_Homestay.MultiSelect = false;
            this.dgv_Homestay.Name = "dgv_Homestay";
            this.dgv_Homestay.ReadOnly = true;
            this.dgv_Homestay.RowHeadersWidth = 62;
            this.dgv_Homestay.RowTemplate.Height = 28;
            this.dgv_Homestay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Homestay.Size = new System.Drawing.Size(891, 353);
            this.dgv_Homestay.TabIndex = 0;
            this.dgv_Homestay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Homestay_CellDoubleClick);
            // 
            // tb_RumahName
            // 
            this.tb_RumahName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.tb_RumahName.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.tb_RumahName.Location = new System.Drawing.Point(180, 77);
            this.tb_RumahName.Name = "tb_RumahName";
            this.tb_RumahName.Size = new System.Drawing.Size(319, 27);
            this.tb_RumahName.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_Search.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(180, 108);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(319, 36);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label22.Location = new System.Drawing.Point(43, 79);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(131, 18);
            this.label22.TabIndex = 18;
            this.label22.Text = "Homestay Name :";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_Reset.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(847, 108);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(88, 36);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_RegistrationGuestBack
            // 
            this.btn_RegistrationGuestBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_RegistrationGuestBack.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_RegistrationGuestBack.ForeColor = System.Drawing.Color.White;
            this.btn_RegistrationGuestBack.Location = new System.Drawing.Point(827, 24);
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
            this.label21.Size = new System.Drawing.Size(208, 34);
            this.label21.TabIndex = 109;
            this.label21.Text = "Homestay Data";
            // 
            // Table_Homestay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btn_RegistrationGuestBack);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_RumahName);
            this.Controls.Add(this.dgv_Homestay);
            this.Controls.Add(this.label21);
            this.MaximizeBox = false;
            this.Name = "Table_Homestay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table_Homestay";
            this.Load += new System.EventHandler(this.Table_Homestay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Homestay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Homestay;
        private System.Windows.Forms.TextBox tb_RumahName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_RegistrationGuestBack;
        private System.Windows.Forms.Label label21;
    }
}