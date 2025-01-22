namespace ALP_Project_02
{
    partial class DashboardSearch
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
            this.btn_back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.datetime_cin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SearchOk = new System.Windows.Forms.Button();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cobox_HomeNumberOfRooms = new System.Windows.Forms.ComboBox();
            this.datetime_cout = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_back.Font = new System.Drawing.Font("Verdana Pro Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(833, 17);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(108, 36);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana Pro Cond", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(52, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Available Homestay";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_reset.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Location = new System.Drawing.Point(853, 224);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(88, 36);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // datetime_cin
            // 
            this.datetime_cin.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.datetime_cin.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.datetime_cin.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.datetime_cin.CalendarTitleForeColor = System.Drawing.SystemColors.Control;
            this.datetime_cin.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.datetime_cin.Location = new System.Drawing.Point(188, 77);
            this.datetime_cin.Name = "datetime_cin";
            this.datetime_cin.Size = new System.Drawing.Size(284, 27);
            this.datetime_cin.TabIndex = 1;
            this.datetime_cin.ValueChanged += new System.EventHandler(this.datetime_cin_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana Pro Cond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 34);
            this.label3.TabIndex = 34;
            this.label3.Text = "Search";
            // 
            // btn_SearchOk
            // 
            this.btn_SearchOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_SearchOk.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_SearchOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SearchOk.Location = new System.Drawing.Point(188, 175);
            this.btn_SearchOk.Name = "btn_SearchOk";
            this.btn_SearchOk.Size = new System.Drawing.Size(284, 36);
            this.btn_SearchOk.TabIndex = 4;
            this.btn_SearchOk.Text = "OK";
            this.btn_SearchOk.UseVisualStyleBackColor = false;
            this.btn_SearchOk.Click += new System.EventHandler(this.btn_SearchOk_Click);
            // 
            // dgv_Search
            // 
            this.dgv_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search.Location = new System.Drawing.Point(41, 270);
            this.dgv_Search.MultiSelect = false;
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.ReadOnly = true;
            this.dgv_Search.RowHeadersVisible = false;
            this.dgv_Search.RowHeadersWidth = 80;
            this.dgv_Search.RowTemplate.Height = 28;
            this.dgv_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Search.Size = new System.Drawing.Size(900, 257);
            this.dgv_Search.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana Pro Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Check In :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label2.Location = new System.Drawing.Point(38, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Number Of Rooms :";
            // 
            // cobox_HomeNumberOfRooms
            // 
            this.cobox_HomeNumberOfRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.cobox_HomeNumberOfRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobox_HomeNumberOfRooms.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.cobox_HomeNumberOfRooms.FormattingEnabled = true;
            this.cobox_HomeNumberOfRooms.Location = new System.Drawing.Point(188, 127);
            this.cobox_HomeNumberOfRooms.Name = "cobox_HomeNumberOfRooms";
            this.cobox_HomeNumberOfRooms.Size = new System.Drawing.Size(284, 26);
            this.cobox_HomeNumberOfRooms.TabIndex = 3;
            // 
            // datetime_cout
            // 
            this.datetime_cout.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.datetime_cout.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.datetime_cout.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.datetime_cout.CalendarTitleForeColor = System.Drawing.SystemColors.Control;
            this.datetime_cout.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.datetime_cout.Location = new System.Drawing.Point(657, 74);
            this.datetime_cout.Name = "datetime_cout";
            this.datetime_cout.Size = new System.Drawing.Size(284, 27);
            this.datetime_cout.TabIndex = 2;
            this.datetime_cout.ValueChanged += new System.EventHandler(this.datetime_cout_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.label4.Font = new System.Drawing.Font("Verdana Pro Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Check Out :";
            // 
            // DashboardSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.datetime_cout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.datetime_cin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SearchOk);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cobox_HomeNumberOfRooms);
            this.MaximizeBox = false;
            this.Name = "DashboardSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardSearch";
            this.Load += new System.EventHandler(this.DashboardSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DateTimePicker datetime_cin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SearchOk;
        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobox_HomeNumberOfRooms;
        private System.Windows.Forms.DateTimePicker datetime_cout;
        private System.Windows.Forms.Label label4;
    }
}