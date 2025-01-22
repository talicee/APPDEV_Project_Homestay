namespace ALP_Project_02
{
    partial class Transaction
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
            this.label21 = new System.Windows.Forms.Label();
            this.dgv_transaction = new System.Windows.Forms.DataGridView();
            this.txbx_InformationBooking = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_TransactionSearch = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_InformationBookingReset
            // 
            this.btn_InformationBookingReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_InformationBookingReset.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_InformationBookingReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_InformationBookingReset.Location = new System.Drawing.Point(850, 113);
            this.btn_InformationBookingReset.Name = "btn_InformationBookingReset";
            this.btn_InformationBookingReset.Size = new System.Drawing.Size(88, 36);
            this.btn_InformationBookingReset.TabIndex = 3;
            this.btn_InformationBookingReset.Text = "Reset";
            this.btn_InformationBookingReset.UseVisualStyleBackColor = false;
            this.btn_InformationBookingReset.Click += new System.EventHandler(this.btn_InformationBookingReset_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana Pro Cond", 14F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(41, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(327, 34);
            this.label21.TabIndex = 26;
            this.label21.Text = "Transaction Information";
            // 
            // dgv_transaction
            // 
            this.dgv_transaction.AllowUserToAddRows = false;
            this.dgv_transaction.AllowUserToDeleteRows = false;
            this.dgv_transaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_transaction.BackgroundColor = System.Drawing.Color.White;
            this.dgv_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaction.Location = new System.Drawing.Point(47, 152);
            this.dgv_transaction.MultiSelect = false;
            this.dgv_transaction.Name = "dgv_transaction";
            this.dgv_transaction.ReadOnly = true;
            this.dgv_transaction.RowHeadersVisible = false;
            this.dgv_transaction.RowHeadersWidth = 62;
            this.dgv_transaction.RowTemplate.Height = 28;
            this.dgv_transaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_transaction.Size = new System.Drawing.Size(891, 353);
            this.dgv_transaction.TabIndex = 27;
            // 
            // txbx_InformationBooking
            // 
            this.txbx_InformationBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.txbx_InformationBooking.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.txbx_InformationBooking.Location = new System.Drawing.Point(144, 82);
            this.txbx_InformationBooking.Name = "txbx_InformationBooking";
            this.txbx_InformationBooking.Size = new System.Drawing.Size(319, 27);
            this.txbx_InformationBooking.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label22.Location = new System.Drawing.Point(44, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 18);
            this.label22.TabIndex = 28;
            this.label22.Text = "Booking ID :";
            // 
            // btn_TransactionSearch
            // 
            this.btn_TransactionSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_TransactionSearch.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_TransactionSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TransactionSearch.Location = new System.Drawing.Point(144, 113);
            this.btn_TransactionSearch.Name = "btn_TransactionSearch";
            this.btn_TransactionSearch.Size = new System.Drawing.Size(319, 36);
            this.btn_TransactionSearch.TabIndex = 2;
            this.btn_TransactionSearch.Text = "Search";
            this.btn_TransactionSearch.UseVisualStyleBackColor = false;
            this.btn_TransactionSearch.Click += new System.EventHandler(this.btn_TransactionSearch_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_back.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(830, 25);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(108, 36);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_TransactionSearch);
            this.Controls.Add(this.btn_InformationBookingReset);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dgv_transaction);
            this.Controls.Add(this.txbx_InformationBooking);
            this.Controls.Add(this.label22);
            this.MaximizeBox = false;
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_InformationBookingReset;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgv_transaction;
        private System.Windows.Forms.TextBox txbx_InformationBooking;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_TransactionSearch;
        private System.Windows.Forms.Button btn_back;
    }
}