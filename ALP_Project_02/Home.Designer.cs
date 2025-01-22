namespace ALP_Project_02
{
    partial class Home
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
            this.cobox_HomeNumberOfRooms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_HomeOk = new System.Windows.Forms.Button();
            this.dgv_Home = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_guest = new System.Windows.Forms.DataGridView();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_guest = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_jmlrumah = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_guest)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cobox_HomeNumberOfRooms
            // 
            this.cobox_HomeNumberOfRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.cobox_HomeNumberOfRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobox_HomeNumberOfRooms.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.cobox_HomeNumberOfRooms.FormattingEnabled = true;
            this.cobox_HomeNumberOfRooms.Location = new System.Drawing.Point(203, 125);
            this.cobox_HomeNumberOfRooms.Name = "cobox_HomeNumberOfRooms";
            this.cobox_HomeNumberOfRooms.Size = new System.Drawing.Size(284, 26);
            this.cobox_HomeNumberOfRooms.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana Pro Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Available Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label2.Location = new System.Drawing.Point(48, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number Of Rooms :";
            // 
            // btn_HomeOk
            // 
            this.btn_HomeOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_HomeOk.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_HomeOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_HomeOk.Location = new System.Drawing.Point(203, 169);
            this.btn_HomeOk.Name = "btn_HomeOk";
            this.btn_HomeOk.Size = new System.Drawing.Size(284, 36);
            this.btn_HomeOk.TabIndex = 3;
            this.btn_HomeOk.Text = "OK";
            this.btn_HomeOk.UseVisualStyleBackColor = false;
            this.btn_HomeOk.Click += new System.EventHandler(this.btn_HomeOk_Click);
            // 
            // dgv_Home
            // 
            this.dgv_Home.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Home.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Home.Location = new System.Drawing.Point(52, 268);
            this.dgv_Home.MultiSelect = false;
            this.dgv_Home.Name = "dgv_Home";
            this.dgv_Home.ReadOnly = true;
            this.dgv_Home.RowHeadersVisible = false;
            this.dgv_Home.RowHeadersWidth = 80;
            this.dgv_Home.RowTemplate.Height = 28;
            this.dgv_Home.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Home.Size = new System.Drawing.Size(435, 257);
            this.dgv_Home.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana Pro Cond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dashboard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana Pro Cond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Booked Homestay";
            // 
            // dgv_guest
            // 
            this.dgv_guest.AllowUserToAddRows = false;
            this.dgv_guest.AllowUserToDeleteRows = false;
            this.dgv_guest.AllowUserToResizeColumns = false;
            this.dgv_guest.AllowUserToResizeRows = false;
            this.dgv_guest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_guest.BackgroundColor = System.Drawing.Color.White;
            this.dgv_guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_guest.Location = new System.Drawing.Point(499, 81);
            this.dgv_guest.MultiSelect = false;
            this.dgv_guest.Name = "dgv_guest";
            this.dgv_guest.ReadOnly = true;
            this.dgv_guest.RowHeadersVisible = false;
            this.dgv_guest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_guest.RowTemplate.Height = 28;
            this.dgv_guest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_guest.Size = new System.Drawing.Size(424, 170);
            this.dgv_guest.TabIndex = 20;
            // 
            // datepick
            // 
            this.datepick.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.datepick.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.datepick.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.datepick.CalendarTitleForeColor = System.Drawing.SystemColors.Control;
            this.datepick.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.datepick.Location = new System.Drawing.Point(203, 81);
            this.datepick.Name = "datepick";
            this.datepick.Size = new System.Drawing.Size(284, 27);
            this.datepick.TabIndex = 1;
            this.datepick.ValueChanged += new System.EventHandler(this.datepick_ValueChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_reset.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Location = new System.Drawing.Point(394, 226);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(88, 36);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana Pro Cond", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(47, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Available Homestay";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_back.Font = new System.Drawing.Font("Verdana Pro Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(815, 15);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(108, 36);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ALP_Project_02.Properties.Resources.Screenshot_2024_06_04_225508;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lb_guest);
            this.panel1.Controls.Add(this.lb_total);
            this.panel1.Controls.Add(this.lb_jmlrumah);
            this.panel1.Location = new System.Drawing.Point(499, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 257);
            this.panel1.TabIndex = 26;
            // 
            // lb_guest
            // 
            this.lb_guest.AutoSize = true;
            this.lb_guest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.lb_guest.Font = new System.Drawing.Font("Verdana Pro Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_guest.Location = new System.Drawing.Point(82, 219);
            this.lb_guest.Name = "lb_guest";
            this.lb_guest.Size = new System.Drawing.Size(19, 22);
            this.lb_guest.TabIndex = 19;
            this.lb_guest.Text = "-";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.lb_total.Font = new System.Drawing.Font("Verdana Pro Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(82, 37);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(19, 22);
            this.lb_total.TabIndex = 17;
            this.lb_total.Text = "-";
            // 
            // lb_jmlrumah
            // 
            this.lb_jmlrumah.AutoSize = true;
            this.lb_jmlrumah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.lb_jmlrumah.Font = new System.Drawing.Font("Verdana Pro Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lb_jmlrumah.Location = new System.Drawing.Point(82, 127);
            this.lb_jmlrumah.Name = "lb_jmlrumah";
            this.lb_jmlrumah.Size = new System.Drawing.Size(19, 22);
            this.lb_jmlrumah.TabIndex = 20;
            this.lb_jmlrumah.Text = "-";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.datepick);
            this.Controls.Add(this.dgv_guest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_HomeOk);
            this.Controls.Add(this.dgv_Home);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cobox_HomeNumberOfRooms);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_guest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cobox_HomeNumberOfRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_HomeOk;
        private System.Windows.Forms.DataGridView dgv_Home;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_guest;
        private System.Windows.Forms.DataGridView dgv_guest;
        private System.Windows.Forms.DateTimePicker datepick;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_jmlrumah;
        private System.Windows.Forms.Button btn_back;
    }
}