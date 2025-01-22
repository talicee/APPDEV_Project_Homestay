using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_Project_02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void butt_logout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        string namastaff;
        public void nama_staff(string namastaff)
        {
            this.namastaff = namastaff;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_staffname.Text = Data.namastaff.ToString();
            string time = DateTime.Today.ToString("dd MMM yyyy");
            lbl_date.Text = time;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btn_DMainBoard_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.nama_staff(namastaff);
            home.Show();
            this.Close();
        }

        private void btn_IHomestay_Click(object sender, EventArgs e)
        {
            Information_Homestay IH = new Information_Homestay();
            IH.nama_staff(namastaff);
            IH.Show();
            this.Close();
        }

        private void btn_IBooking_Click(object sender, EventArgs e)
        {
            Information_Booking IH = new Information_Booking();
            IH.nama_staff(namastaff);
            IH.Show();
            this.Close();
        }

        private void btn_IStaff_Click(object sender, EventArgs e)
        {
            Information_Staff IH = new Information_Staff();
            IH.nama_staff(namastaff);
            IH.Show();
            this.Close();
        }

        private void btn_RGuest_Click(object sender, EventArgs e)
        {
            Registration_Guest IH = new Registration_Guest();
            IH.nama_staff(namastaff);
            IH.Show();
            this.Close();
        }

        private void btn_RHomestay_Click(object sender, EventArgs e)
        {
            Registration_Homestay IH = new Registration_Homestay();
            IH.nama_staff(namastaff);
            IH.Show();
            this.Close();
        }

        private void btn_RFinancial_Click(object sender, EventArgs e)
        {
            RegistFinancial IH = new RegistFinancial();
            IH.nama_staff(namastaff);
            IH.Show();
            this.Close();
        }

        private void btn_THomestayTransaction_Click(object sender, EventArgs e)
        {
            Transaction IH = new Transaction();
            IH.nama_staff(namastaff);
            IH.Show();
            this.Close();
        }

        private void btn_DSearch_Click(object sender, EventArgs e)
        {
            DashboardSearch IH = new DashboardSearch();
            IH.nama_staff(namastaff);
            IH.Show();
            this.Close();
        }
    }
}
