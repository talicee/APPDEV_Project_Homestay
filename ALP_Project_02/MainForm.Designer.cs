namespace ALP_Project_02
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.lbl_staffname = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.butt_logout = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_DSearch = new System.Windows.Forms.Button();
            this.btn_THomestayTransaction = new System.Windows.Forms.Button();
            this.btn_RFinancial = new System.Windows.Forms.Button();
            this.btn_RHomestay = new System.Windows.Forms.Button();
            this.btn_RGuest = new System.Windows.Forms.Button();
            this.btn_IStaff = new System.Windows.Forms.Button();
            this.btn_IBooking = new System.Windows.Forms.Button();
            this.btn_IHomestay = new System.Windows.Forms.Button();
            this.btn_DMainBoard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_staffname
            // 
            this.lbl_staffname.AutoSize = true;
            this.lbl_staffname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.lbl_staffname.Font = new System.Drawing.Font("Verdana Pro Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffname.Location = new System.Drawing.Point(54, 514);
            this.lbl_staffname.Name = "lbl_staffname";
            this.lbl_staffname.Size = new System.Drawing.Size(26, 18);
            this.lbl_staffname.TabIndex = 11;
            this.lbl_staffname.Text = "---";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.lbl_time.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.lbl_time.Location = new System.Drawing.Point(848, 514);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(32, 18);
            this.lbl_time.TabIndex = 12;
            this.lbl_time.Text = "----";
            // 
            // butt_logout
            // 
            this.butt_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.butt_logout.Font = new System.Drawing.Font("Verdana Pro Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_logout.ForeColor = System.Drawing.Color.White;
            this.butt_logout.Location = new System.Drawing.Point(813, 21);
            this.butt_logout.Name = "butt_logout";
            this.butt_logout.Size = new System.Drawing.Size(108, 36);
            this.butt_logout.TabIndex = 10;
            this.butt_logout.Text = "Log Out";
            this.butt_logout.UseVisualStyleBackColor = false;
            this.butt_logout.Click += new System.EventHandler(this.butt_logout_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.lbl_date.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.lbl_date.Location = new System.Drawing.Point(755, 514);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(56, 18);
            this.lbl_date.TabIndex = 13;
            this.lbl_date.Text = "--------";
            // 
            // btn_DSearch
            // 
            this.btn_DSearch.Font = new System.Drawing.Font("Verdana Pro Cond", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DSearch.Image = global::ALP_Project_02.Properties.Resources.Screenshot_2024_06_04_153908;
            this.btn_DSearch.Location = new System.Drawing.Point(76, 415);
            this.btn_DSearch.Name = "btn_DSearch";
            this.btn_DSearch.Size = new System.Drawing.Size(170, 33);
            this.btn_DSearch.TabIndex = 2;
            this.btn_DSearch.Text = "Search";
            this.btn_DSearch.UseVisualStyleBackColor = true;
            this.btn_DSearch.Click += new System.EventHandler(this.btn_DSearch_Click);
            // 
            // btn_THomestayTransaction
            // 
            this.btn_THomestayTransaction.Font = new System.Drawing.Font("Verdana Pro Cond", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_THomestayTransaction.Image = global::ALP_Project_02.Properties.Resources.Screenshot_2024_06_04_153908;
            this.btn_THomestayTransaction.Location = new System.Drawing.Point(731, 378);
            this.btn_THomestayTransaction.Name = "btn_THomestayTransaction";
            this.btn_THomestayTransaction.Size = new System.Drawing.Size(170, 33);
            this.btn_THomestayTransaction.TabIndex = 9;
            this.btn_THomestayTransaction.Text = "Homestay Transaction";
            this.btn_THomestayTransaction.UseVisualStyleBackColor = true;
            this.btn_THomestayTransaction.Click += new System.EventHandler(this.btn_THomestayTransaction_Click);
            // 
            // btn_RFinancial
            // 
            this.btn_RFinancial.Font = new System.Drawing.Font("Verdana Pro Cond", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RFinancial.Image = global::ALP_Project_02.Properties.Resources.Screenshot_2024_06_04_153908;
            this.btn_RFinancial.Location = new System.Drawing.Point(512, 453);
            this.btn_RFinancial.Name = "btn_RFinancial";
            this.btn_RFinancial.Size = new System.Drawing.Size(170, 33);
            this.btn_RFinancial.TabIndex = 8;
            this.btn_RFinancial.Text = "Financial";
            this.btn_RFinancial.UseVisualStyleBackColor = true;
            this.btn_RFinancial.Click += new System.EventHandler(this.btn_RFinancial_Click);
            // 
            // btn_RHomestay
            // 
            this.btn_RHomestay.Font = new System.Drawing.Font("Verdana Pro Cond", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RHomestay.Image = global::ALP_Project_02.Properties.Resources.Screenshot_2024_06_04_153908;
            this.btn_RHomestay.Location = new System.Drawing.Point(512, 415);
            this.btn_RHomestay.Name = "btn_RHomestay";
            this.btn_RHomestay.Size = new System.Drawing.Size(170, 33);
            this.btn_RHomestay.TabIndex = 7;
            this.btn_RHomestay.Text = "Homestay";
            this.btn_RHomestay.UseVisualStyleBackColor = true;
            this.btn_RHomestay.Click += new System.EventHandler(this.btn_RHomestay_Click);
            // 
            // btn_RGuest
            // 
            this.btn_RGuest.Font = new System.Drawing.Font("Verdana Pro Cond", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RGuest.Image = global::ALP_Project_02.Properties.Resources.Screenshot_2024_06_04_153908;
            this.btn_RGuest.Location = new System.Drawing.Point(512, 378);
            this.btn_RGuest.Name = "btn_RGuest";
            this.btn_RGuest.Size = new System.Drawing.Size(170, 33);
            this.btn_RGuest.TabIndex = 6;
            this.btn_RGuest.Text = "Guest";
            this.btn_RGuest.UseVisualStyleBackColor = true;
            this.btn_RGuest.Click += new System.EventHandler(this.btn_RGuest_Click);
            // 
            // btn_IStaff
            // 
            this.btn_IStaff.Font = new System.Drawing.Font("Verdana Pro Cond", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IStaff.Image = global::ALP_Project_02.Properties.Resources.Screenshot_2024_06_04_153908;
            this.btn_IStaff.Location = new System.Drawing.Point(293, 453);
            this.btn_IStaff.Name = "btn_IStaff";
            this.btn_IStaff.Size = new System.Drawing.Size(170, 33);
            this.btn_IStaff.TabIndex = 5;
            this.btn_IStaff.Text = "Staff";
            this.btn_IStaff.UseVisualStyleBackColor = true;
            this.btn_IStaff.Click += new System.EventHandler(this.btn_IStaff_Click);
            // 
            // btn_IBooking
            // 
            this.btn_IBooking.Font = new System.Drawing.Font("Verdana Pro Cond", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IBooking.Image = global::ALP_Project_02.Properties.Resources.Screenshot_2024_06_04_153908;
            this.btn_IBooking.Location = new System.Drawing.Point(293, 415);
            this.btn_IBooking.Name = "btn_IBooking";
            this.btn_IBooking.Size = new System.Drawing.Size(170, 33);
            this.btn_IBooking.TabIndex = 4;
            this.btn_IBooking.Text = "Booking";
            this.btn_IBooking.UseVisualStyleBackColor = true;
            this.btn_IBooking.Click += new System.EventHandler(this.btn_IBooking_Click);
            // 
            // btn_IHomestay
            // 
            this.btn_IHomestay.Font = new System.Drawing.Font("Verdana Pro Cond", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IHomestay.Image = global::ALP_Project_02.Properties.Resources.Screenshot_2024_06_04_153908;
            this.btn_IHomestay.Location = new System.Drawing.Point(293, 378);
            this.btn_IHomestay.Name = "btn_IHomestay";
            this.btn_IHomestay.Size = new System.Drawing.Size(170, 33);
            this.btn_IHomestay.TabIndex = 3;
            this.btn_IHomestay.Text = "Homestay";
            this.btn_IHomestay.UseVisualStyleBackColor = true;
            this.btn_IHomestay.Click += new System.EventHandler(this.btn_IHomestay_Click);
            // 
            // btn_DMainBoard
            // 
            this.btn_DMainBoard.Font = new System.Drawing.Font("Verdana Pro Cond", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DMainBoard.Image = global::ALP_Project_02.Properties.Resources.Screenshot_2024_06_04_153908;
            this.btn_DMainBoard.Location = new System.Drawing.Point(76, 378);
            this.btn_DMainBoard.Name = "btn_DMainBoard";
            this.btn_DMainBoard.Size = new System.Drawing.Size(170, 33);
            this.btn_DMainBoard.TabIndex = 1;
            this.btn_DMainBoard.Text = "Main Board";
            this.btn_DMainBoard.UseVisualStyleBackColor = true;
            this.btn_DMainBoard.Click += new System.EventHandler(this.btn_DMainBoard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Image = global::ALP_Project_02.Properties.Resources.Screenshot_2024_06_04_153355;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(979, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btn_DSearch);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_staffname);
            this.Controls.Add(this.butt_logout);
            this.Controls.Add(this.btn_THomestayTransaction);
            this.Controls.Add(this.btn_RFinancial);
            this.Controls.Add(this.btn_RHomestay);
            this.Controls.Add(this.btn_RGuest);
            this.Controls.Add(this.btn_IStaff);
            this.Controls.Add(this.btn_IBooking);
            this.Controls.Add(this.btn_IHomestay);
            this.Controls.Add(this.btn_DMainBoard);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_DMainBoard;
        private System.Windows.Forms.Button btn_IHomestay;
        private System.Windows.Forms.Button btn_IBooking;
        private System.Windows.Forms.Button btn_IStaff;
        private System.Windows.Forms.Button btn_RFinancial;
        private System.Windows.Forms.Button btn_RHomestay;
        private System.Windows.Forms.Button btn_RGuest;
        private System.Windows.Forms.Button btn_THomestayTransaction;
        private System.Windows.Forms.Button butt_logout;
        private System.Windows.Forms.Label lbl_staffname;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_DSearch;
    }
}