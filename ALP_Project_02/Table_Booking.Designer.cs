namespace ALP_Project_02
{
    partial class Table_Booking
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
            this.btn_BookingBack = new System.Windows.Forms.Button();
            this.btn_BookingReset = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_BookingSearch = new System.Windows.Forms.Button();
            this.tb_BookingID = new System.Windows.Forms.TextBox();
            this.dgv_Booking = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Booking)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BookingBack
            // 
            this.btn_BookingBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_BookingBack.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_BookingBack.ForeColor = System.Drawing.Color.White;
            this.btn_BookingBack.Location = new System.Drawing.Point(829, 31);
            this.btn_BookingBack.Name = "btn_BookingBack";
            this.btn_BookingBack.Size = new System.Drawing.Size(108, 36);
            this.btn_BookingBack.TabIndex = 4;
            this.btn_BookingBack.Text = "Back";
            this.btn_BookingBack.UseVisualStyleBackColor = false;
            this.btn_BookingBack.Click += new System.EventHandler(this.btn_BookingBack_Click);
            // 
            // btn_BookingReset
            // 
            this.btn_BookingReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_BookingReset.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_BookingReset.ForeColor = System.Drawing.Color.White;
            this.btn_BookingReset.Location = new System.Drawing.Point(849, 115);
            this.btn_BookingReset.Name = "btn_BookingReset";
            this.btn_BookingReset.Size = new System.Drawing.Size(88, 36);
            this.btn_BookingReset.TabIndex = 3;
            this.btn_BookingReset.Text = "Reset";
            this.btn_BookingReset.UseVisualStyleBackColor = false;
            this.btn_BookingReset.Click += new System.EventHandler(this.btn_BookingReset_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label22.Location = new System.Drawing.Point(45, 86);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 18);
            this.label22.TabIndex = 113;
            this.label22.Text = "Booking ID :";
            // 
            // btn_BookingSearch
            // 
            this.btn_BookingSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_BookingSearch.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_BookingSearch.ForeColor = System.Drawing.Color.White;
            this.btn_BookingSearch.Location = new System.Drawing.Point(182, 115);
            this.btn_BookingSearch.Name = "btn_BookingSearch";
            this.btn_BookingSearch.Size = new System.Drawing.Size(319, 36);
            this.btn_BookingSearch.TabIndex = 2;
            this.btn_BookingSearch.Text = "Search";
            this.btn_BookingSearch.UseVisualStyleBackColor = false;
            this.btn_BookingSearch.Click += new System.EventHandler(this.btn_BookingSearch_Click);
            // 
            // tb_BookingID
            // 
            this.tb_BookingID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.tb_BookingID.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.tb_BookingID.Location = new System.Drawing.Point(182, 84);
            this.tb_BookingID.Name = "tb_BookingID";
            this.tb_BookingID.Size = new System.Drawing.Size(319, 27);
            this.tb_BookingID.TabIndex = 1;
            // 
            // dgv_Booking
            // 
            this.dgv_Booking.AllowUserToAddRows = false;
            this.dgv_Booking.AllowUserToDeleteRows = false;
            this.dgv_Booking.AllowUserToResizeColumns = false;
            this.dgv_Booking.AllowUserToResizeRows = false;
            this.dgv_Booking.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Booking.Location = new System.Drawing.Point(46, 160);
            this.dgv_Booking.MultiSelect = false;
            this.dgv_Booking.Name = "dgv_Booking";
            this.dgv_Booking.ReadOnly = true;
            this.dgv_Booking.RowHeadersWidth = 62;
            this.dgv_Booking.RowTemplate.Height = 28;
            this.dgv_Booking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Booking.Size = new System.Drawing.Size(891, 353);
            this.dgv_Booking.TabIndex = 110;
            this.dgv_Booking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Booking_CellDoubleClick);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana Pro Cond", 14F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(42, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(185, 34);
            this.label21.TabIndex = 116;
            this.label21.Text = "Booking Data";
            // 
            // Table_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btn_BookingBack);
            this.Controls.Add(this.btn_BookingReset);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btn_BookingSearch);
            this.Controls.Add(this.tb_BookingID);
            this.Controls.Add(this.dgv_Booking);
            this.Controls.Add(this.label21);
            this.MaximizeBox = false;
            this.Name = "Table_Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table_Booking";
            this.Load += new System.EventHandler(this.Table_Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Booking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BookingBack;
        private System.Windows.Forms.Button btn_BookingReset;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_BookingSearch;
        private System.Windows.Forms.TextBox tb_BookingID;
        private System.Windows.Forms.DataGridView dgv_Booking;
        private System.Windows.Forms.Label label21;
    }
}