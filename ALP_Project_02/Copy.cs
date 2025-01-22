using MySql.Data.MySqlClient;
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
    public partial class BookingPreview : Form
    {
        public BookingPreview()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        
        DataTable dtBookInfo;
        DataTable dtBookPreview = new DataTable();
        int index = 0;
        string namastaff;

        public void nama_staff(string namastaff)
        {
            this.namastaff = namastaff;
        }

        public void data(DataTable dtBookInfo, int index)
        { 
            this.dtBookInfo = dtBookInfo;
            this.index = index;
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=; database=indramar_20232_dbd_3");
            sqlQuery = "select r.rumah_nama, r.rumah_alamat, r.rumah_jml_kamar, " +
                "g.guest_alamat, g.guest_kewarganegaraan, DATE_FORMAT(LEFT(bi.booking_tgl_cin,10), " +
                "'%d %M %Y'), DATE_FORMAT(LEFT(bi.booking_tgl_cout,10), '%d %M %Y') " +
                "from rumah r, guest_information g, booking_information bi Where " +
                $"g.guest_id = '{dtBookInfo.Rows[index][3].ToString()}' AND r.rumah_id = " +
                $"'{dtBookInfo.Rows[index][1].ToString()}' AND bi.rumah_id = " +
                $"'{dtBookInfo.Rows[index][1].ToString()}' AND bi.guest_id = " +
                $"'{dtBookInfo.Rows[index][3].ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtBookPreview);
        }

        private void BookingPreview_Load(object sender, EventArgs e)
        {
            lb_BookingID.Text = dtBookInfo.Rows[index][0].ToString();
            lb_guestname.Text = dtBookInfo.Rows[index][8].ToString();
            lb_guestid.Text = dtBookInfo.Rows[index][3].ToString();
            lb_homeaddress.Text = dtBookPreview.Rows[0][1].ToString();
            lb_guestnationality.Text = dtBookPreview.Rows[0][4].ToString();
            lb_homename.Text = dtBookPreview.Rows[0][0].ToString();
            lb_homeid.Text = dtBookInfo.Rows[index][1].ToString();
            lb_guestaddress.Text = dtBookPreview.Rows[0][3].ToString();
            lb_homeroom.Text = dtBookPreview.Rows[0][2].ToString();
            lb_cin.Text = dtBookPreview.Rows[0][5].ToString();
            lb_cout.Text = dtBookPreview.Rows[0][6].ToString();
            lb_fee.Text = "Rp. " + Convert.ToInt32(dtBookInfo.Rows[index][5].ToString()).ToString("C2").Remove(0,2);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Information_Booking IB = new Information_Booking();
            IB.nama_staff(namastaff);
            IB.Show();
            this.Close();
        }
    }
}
