using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_Project_02
{
    public partial class Information_Homestay : Form
    {
        public Information_Homestay()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;
        
        DataTable dtHouseInfo;
        
        string selectedHouse; //bwt info house
        string namastaff;

        public void nama_staff(string namastaff)
        {
            this.namastaff = namastaff;
        }
        private void Information_Homestay_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=; database=indramar_20232_dbd_3");
            dtHouseInfo = new DataTable();
            sqlQuery = "SELECT * FROM rumah";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHouseInfo);
            dgv_InformationHouse.DataSource = dtHouseInfo;

            lb_HID.Hide();
            lb_HName.Hide();
            lb_HAddress.Hide();
            lb_HJmlKmr.Hide();
            lb_HDetailInfo.Hide();
            lb_HPrice.Hide();
            dgv_InformationHouse.ClearSelection();
        }

        private void dgv_InformationHouse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_InformationHouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_HID.Show();
            lb_HName.Show();
            lb_HJmlKmr.Show();
            lb_HPrice.Show();
            lb_HDetailInfo.Show();
            lb_HID.Show();
            lb_HAddress.Show();

            DataGridViewRow dgvDetailH = dgv_InformationHouse.CurrentRow; //SPY TAU CURRENTROW NYA BRP

            lb_HID.Text = dgvDetailH.Cells[0].Value.ToString();
            lb_HName.Text = dgvDetailH.Cells[2].Value.ToString();
            lb_HAddress.Text = dgvDetailH.Cells[3].Value.ToString();
            lb_HJmlKmr.Text = dgvDetailH.Cells[4].Value.ToString();
            lb_HDetailInfo.Text = dgvDetailH.Cells[5].Value.ToString();
            
            lb_HPrice.Text = "Rp. " + Convert.ToInt32(dgvDetailH.Cells[6].Value.ToString()).ToString("C2").Remove(0, 2);

            selectedHouse = dgvDetailH.Cells[0].Value.ToString();
            string alamatR = "D:\\RUMAH_ID\\" + selectedHouse + ".jpg";
            //pbox_InformationHouse.Image = new Bitmap(alamatR);
        }

        private void btn_InformationHouseBack_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.nama_staff(namastaff);
            MF.Show();
            this.Close();
        }
    }
}
