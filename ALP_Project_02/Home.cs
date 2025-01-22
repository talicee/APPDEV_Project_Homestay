using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ALP_Project_02
{
    public partial class Home : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtrefund = new DataTable();
        DataTable dtlunas = new DataTable();
        DataTable dtguest = new DataTable();
        DataTable dtfilter = new DataTable();

        public Home()
        {
            InitializeComponent();
        }

        string datepicker = "";
        string namastaff;
        public void nama_staff(string namastaff)
        {
            this.namastaff = namastaff;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection(
               $"server=localhost;" +
               $"uid=root;" +
               $"pwd=;" +
               $"database=indramar_20232_dbd_3");

            sqlConnect.Open();
            sqlConnect.Close();

            //TOTAL PENDAPATAN
            string sql = "select sum(trans_jml_bayar) \r\nfrom financial_transaction\r\nwhere trans_tipe_bayar = 'Refund'; ";
            sqlCommand = new MySqlCommand(sql, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtrefund);

            string sql2 = "select sum(trans_jml_bayar) \r\nfrom financial_transaction\r\nwhere trans_tipe_bayar = 'DP' or trans_tipe_bayar = 'Lunas'";
            sqlCommand = new MySqlCommand(sql2, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtlunas);

            long harga = Convert.ToInt64(dtlunas.Rows[0][0]) - Convert.ToInt64(dtrefund.Rows[0][0]);
            lb_total.Text = "Rp. " + Convert.ToInt32(harga).ToString("C2").Remove(0, 2);

            //JUMLAH GUEST YANG SEDANG MENGINAP 
            jumlah_guest();

            //DGV 
            rumah_tersedia();
            int count = 0;
            foreach (DataRow dr in dtfilter.Rows)
            {
                count++;
            }
            lb_jmlrumah.Text = count.ToString();
            cobox_HomeNumberOfRooms.Items.Add("2 ");
            cobox_HomeNumberOfRooms.Items.Add("3 ");
            cobox_HomeNumberOfRooms.Items.Add("4 ");
            cobox_HomeNumberOfRooms.Items.Add("5 ");
            datepick.Value = DateTime.Today;
            dtfilter.Rows.Clear();
            jumlah_guest();

            //TAMBAHAN
            if (cobox_HomeNumberOfRooms.Text != "")
            {
                //edit
                string sql5 = $"(select r.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                   $"from rumah r " +
                   $"where r.rumah_id not in(select distinct b.rumah_id " +
                                           $"from booking_information b, financial_transaction f " +
                                           $"where f.booking_id = b.booking_id " +
                                           $"and '{datepicker}' between cast(b.booking_tgl_cin as date) " +
                                           $"and cast(date_sub(b.booking_tgl_cout, INTERVAL 1 DAY) as date) " +
                                           $"and f.trans_tipe_bayar != 'Refund') " +
                                           $"and r.rumah_jml_kamar = '{Convert.ToInt16(cobox_HomeNumberOfRooms.Text)}' " +
                   $"order by 3,1) " +
                   $"UNION " +
                   $"(select distinct b.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                   $"from booking_information b, financial_transaction f, rumah r " +
                   $"where r.rumah_id = b.rumah_id " +
                   $"and f.booking_id = b.booking_id " +
                   $"and '{datepicker}' between cast(b.booking_tgl_cin as date) " +
                   $"and cast(date_sub(b.booking_tgl_cout, INTERVAL 1 DAY) as date) " +
                   $"and f.trans_tipe_bayar = 'Refund' " +
                   $"and r.rumah_jml_kamar = '{Convert.ToInt16(cobox_HomeNumberOfRooms.Text)}');";
                sqlCommand = new MySqlCommand(sql5, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtfilter);
                dgv_Home.DataSource = dtfilter;
                jumlah_rumah_tersedia();

            }
            else if (cobox_HomeNumberOfRooms.Text == "")
            {
                //edit
                string sql5 = $"(select r.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                    $"from rumah r " +
                    $"where r.rumah_id not in(select distinct b.rumah_id " +
                                            $"from booking_information b, financial_transaction f " +
                                            $"where f.booking_id = b.booking_id " +
                                            $"and '{datepicker}' between cast(b.booking_tgl_cin as date) " +
                                            $"and cast(date_sub(b.booking_tgl_cout, INTERVAL 1 DAY) as date) " +
                                            $"and f.trans_tipe_bayar != 'Refund') " +
                    $"order by 3,1) " +
                    $"UNION " +
                    $"(select distinct b.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                    $"from booking_information b, financial_transaction f, rumah r " +
                    $"where r.rumah_id = b.rumah_id " +
                    $"and f.booking_id = b.booking_id " +
                    $"and '{datepicker}' between cast(b.booking_tgl_cin as date) " +
                    $"and cast(date_sub(b.booking_tgl_cout, INTERVAL 1 DAY) as date) " +
                    $"and f.trans_tipe_bayar = 'Refund');";
                sqlCommand = new MySqlCommand(sql5, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtfilter);
                dgv_Home.DataSource = dtfilter;
                jumlah_rumah_tersedia();

            }
            cobox_HomeNumberOfRooms.Text = "";
            dgv_Home.ClearSelection();
            dgv_guest.ClearSelection();
        }

        void jumlah_guest()
        {
            dtguest.Clear();
            //edit
            string sql4 = $"select guest_nama as Nama, b.rumah_id as `Rumah ID` " +
                $"from guest_information g " +
                $"join booking_information b on g.guest_id = b.guest_id " +
                $"join financial_transaction f on f.booking_id = b.booking_id " +
                $"where f.booking_id = b.booking_id " +
                $"and '{datepicker}' between cast(b.booking_tgl_cin as date) " +
                $"and cast(date_sub(b.booking_tgl_cout, INTERVAL 1 DAY) as date) " +
                $"and f.trans_tipe_bayar = 'Lunas'; ";
            sqlCommand = new MySqlCommand(sql4, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtguest);
            dgv_guest.DataSource = dtguest;

            int count = 0;
            for (int i = 0; i < dtguest.Rows.Count; i++)
            {
                count++;
            }
            lb_guest.Text = count.ToString();
        }


        void rumah_tersedia()
        {
            string sql5 = $"(select r.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                    $"from rumah r " +
                    $"where r.rumah_id not in(select distinct b.rumah_id " +
                                            $"from booking_information b, financial_transaction f " +
                                            $"where f.booking_id = b.booking_id " +
                                            $"and '{datepicker}' between cast(b.booking_tgl_cin as date) " +
                                            $"and cast(date_sub(b.booking_tgl_cout, INTERVAL 1 DAY) as date) " +
                                            $"and f.trans_tipe_bayar != 'Refund') " +
                                            $"order by 3,1) " +
                    $"UNION " +
                    $"(select distinct b.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                    $"from booking_information b, financial_transaction f, rumah r " +
                    $"where r.rumah_id = b.rumah_id " +
                    $"and f.booking_id = b.booking_id " +
                    $"and '{datepicker}' between cast(b.booking_tgl_cin as date) " +
                    $"and cast(date_sub(b.booking_tgl_cout, INTERVAL 1 DAY) as date) " +
                    $"and f.trans_tipe_bayar = 'Refund');";
            sqlCommand = new MySqlCommand(sql5, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtfilter);
            dgv_Home.DataSource = dtfilter;
        }

        void jumlah_rumah_tersedia()
        {
            int count = 0;
            foreach (DataRow dr in dtfilter.Rows)
            {
                count++;
            }
            lb_jmlrumah.Text = count.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dtguest.Clear();
            dtfilter.Clear();
            rumah_tersedia();
            datepick.Value = DateTime.Today;
            cobox_HomeNumberOfRooms.SelectedIndex = -1;
            int count = 0;
            foreach (DataRow dr in dtfilter.Rows)
            {
                count++;
            }
            lb_jmlrumah.Text = count.ToString();
            dgv_Home.ClearSelection();
            dgv_guest.ClearSelection();
        }

        private void datepick_ValueChanged(object sender, EventArgs e)
        {
            var tahun = datepick.Value.Year;
            var month = datepick.Value.Month;
            var day = datepick.Value.Day;
            datepicker = tahun.ToString() + "-" + month.ToString() + "-" + day.ToString();
        }

        private void btn_HomeOk_Click(object sender, EventArgs e)
        {
            dtfilter.Rows.Clear();
            jumlah_guest();
            if (cobox_HomeNumberOfRooms.Text != "")
            {
                //edit
                string sql5 = $"(select r.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                    $"from rumah r " +
                    $"where r.rumah_id not in(select distinct b.rumah_id " +
                                            $"from booking_information b, financial_transaction f " +
                                            $"where f.booking_id = b.booking_id " +
                                            $"and '{datepicker}' between cast(b.booking_tgl_cin as date) " +
                                            $"and cast(date_sub(b.booking_tgl_cout, INTERVAL 1 DAY) as date) " +
                                            $"and f.trans_tipe_bayar != 'Refund') " +
                                            $"and r.rumah_jml_kamar = '{Convert.ToInt16(cobox_HomeNumberOfRooms.Text)}' " +
                    $"order by 3,1) " +
                    $"UNION " +
                    $"(select distinct b.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                    $"from booking_information b, financial_transaction f, rumah r " +
                    $"where r.rumah_id = b.rumah_id " +
                    $"and f.booking_id = b.booking_id " +
                    $"and '{datepicker}' between cast(b.booking_tgl_cin as date) " +
                    $"and cast(date_sub(b.booking_tgl_cout, INTERVAL 1 DAY) as date) " +
                    $"and f.trans_tipe_bayar = 'Refund' " +
                    $"and r.rumah_jml_kamar = '{Convert.ToInt16(cobox_HomeNumberOfRooms.Text)}');";
                sqlCommand = new MySqlCommand(sql5, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtfilter);
                dgv_Home.DataSource = dtfilter;
                jumlah_rumah_tersedia();
            }
            else if (cobox_HomeNumberOfRooms.Text == "")
            {
                //edit
                string sql5 = $"(select r.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                    $"from rumah r " +
                    $"where r.rumah_id not in(select distinct b.rumah_id " +
                                            $"from booking_information b, financial_transaction f " +
                                            $"where f.booking_id = b.booking_id " +
                                            $"and '{datepicker}' between cast(b.booking_tgl_cin as date) " +
                                            $"and cast(date_sub(b.booking_tgl_cout, INTERVAL 1 DAY) as date) " +
                                            $"and f.trans_tipe_bayar != 'Refund') " +
                    $"order by 3,1) " +
                    $"UNION " +
                    $"(select distinct b.rumah_id, r.rumah_nama, r.rumah_jml_kamar " +
                    $"from booking_information b, financial_transaction f, rumah r " +
                    $"where r.rumah_id = b.rumah_id " +
                    $"and f.booking_id = b.booking_id " +
                    $"and '{datepicker}' between cast(b.booking_tgl_cin as date) " +
                    $"and cast(date_sub(b.booking_tgl_cout, INTERVAL 1 DAY) as date) " +
                    $"and f.trans_tipe_bayar = 'Refund');";
                sqlCommand = new MySqlCommand(sql5, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtfilter);
                dgv_Home.DataSource = dtfilter;
                jumlah_rumah_tersedia();
            }
            cobox_HomeNumberOfRooms.Text = "";
            cobox_HomeNumberOfRooms.Text = "";
            dgv_Home.ClearSelection();
            dgv_guest.ClearSelection();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.nama_staff(namastaff);
            mainForm.Show();
            this.Close();
        }
    }
}
