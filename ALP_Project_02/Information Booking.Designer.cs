namespace ALP_Project_02
{
    partial class Information_Booking
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
            this.btn_InformationBookingReset = new System.Windows.Forms.Button();
            this.tb_InformationBooking = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dgv_InformationBook = new System.Windows.Forms.DataGridView();
            this.btn_InformationBookingSearch = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InformationBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_InformationBookingReset
            // 
            this.btn_InformationBookingReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_InformationBookingReset.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_InformationBookingReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_InformationBookingReset.Location = new System.Drawing.Point(848, 116);
            this.btn_InformationBookingReset.Name = "btn_InformationBookingReset";
            this.btn_InformationBookingReset.Size = new System.Drawing.Size(88, 36);
            this.btn_InformationBookingReset.TabIndex = 4;
            this.btn_InformationBookingReset.Text = "Reset";
            this.btn_InformationBookingReset.UseVisualStyleBackColor = false;
            this.btn_InformationBookingReset.Click += new System.EventHandler(this.btn_InformationBookingReset_Click);
            // 
            // tb_InformationBooking
            // 
            this.tb_InformationBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.tb_InformationBooking.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.tb_InformationBooking.Location = new System.Drawing.Point(154, 84);
            this.tb_InformationBooking.Name = "tb_InformationBooking";
            this.tb_InformationBooking.Size = new System.Drawing.Size(319, 27);
            this.tb_InformationBooking.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label22.Location = new System.Drawing.Point(41, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 18);
            this.label22.TabIndex = 17;
            this.label22.Text = "Guest Name :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana Pro Cond", 14F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(39, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(283, 34);
            this.label21.TabIndex = 15;
            this.label21.Text = "Booking Information";
            // 
            // dgv_InformationBook
            // 
            this.dgv_InformationBook.AllowUserToAddRows = false;
            this.dgv_InformationBook.AllowUserToDeleteRows = false;
            this.dgv_InformationBook.AllowUserToResizeColumns = false;
            this.dgv_InformationBook.AllowUserToResizeRows = false;
            this.dgv_InformationBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_InformationBook.BackgroundColor = System.Drawing.Color.White;
            this.dgv_InformationBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InformationBook.Location = new System.Drawing.Point(45, 158);
            this.dgv_InformationBook.MultiSelect = false;
            this.dgv_InformationBook.Name = "dgv_InformationBook";
            this.dgv_InformationBook.ReadOnly = true;
            this.dgv_InformationBook.RowHeadersVisible = false;
            this.dgv_InformationBook.RowHeadersWidth = 62;
            this.dgv_InformationBook.RowTemplate.Height = 28;
            this.dgv_InformationBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_InformationBook.Size = new System.Drawing.Size(891, 353);
            this.dgv_InformationBook.TabIndex = 16;
            this.dgv_InformationBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_InformationBook_CellClick);
            // 
            // btn_InformationBookingSearch
            // 
            this.btn_InformationBookingSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_InformationBookingSearch.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_InformationBookingSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_InformationBookingSearch.Location = new System.Drawing.Point(154, 115);
            this.btn_InformationBookingSearch.Name = "btn_InformationBookingSearch";
            this.btn_InformationBookingSearch.Size = new System.Drawing.Size(319, 36);
            this.btn_InformationBookingSearch.TabIndex = 2;
            this.btn_InformationBookingSearch.Text = "Search";
            this.btn_InformationBookingSearch.UseVisualStyleBackColor = false;
            this.btn_InformationBookingSearch.Click += new System.EventHandler(this.btn_InformationBookingSearch_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_back.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(828, 25);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(108, 36);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_preview.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_preview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_preview.Location = new System.Drawing.Point(754, 116);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(88, 36);
            this.btn_preview.TabIndex = 3;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // Information_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_InformationBookingSearch);
            this.Controls.Add(this.btn_InformationBookingReset);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dgv_InformationBook);
            this.Controls.Add(this.tb_InformationBooking);
            this.Controls.Add(this.label22);
            this.MaximizeBox = false;
            this.Name = "Information_Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information_Booking";
            this.Load += new System.EventHandler(this.Information_Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InformationBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_InformationBookingReset;
        private System.Windows.Forms.TextBox tb_InformationBooking;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgv_InformationBook;
        private System.Windows.Forms.Button btn_InformationBookingSearch;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_preview;
    }
}