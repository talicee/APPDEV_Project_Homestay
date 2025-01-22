using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_Project_02
{
    public partial class Information_Staff : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;
        DataTable dtStaffInfo;
        string selectedStaff;

        public Information_Staff()
        {
            InitializeComponent();
        }
        string namastaff;
        public void nama_staff(string namastaff)
        {
            this.namastaff = namastaff;
        }
        
        private void Information_Staff_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost; uid=root; password=; database=indramar_20232_dbd_3");
            dtStaffInfo = new DataTable();
            sqlQuery = "SELECT * FROM staff";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtStaffInfo);
            dgv_InformationStaff.DataSource = dtStaffInfo;

            lb_SID.Hide();
            lb_SNIK.Hide();
            lb_SName.Hide();
            lb_SGender.Hide();
            lable.Hide();
            lablellll.Hide();
            lb_SPhone.Hide();
            lb_SEmail.Hide();
            dgv_InformationStaff.ClearSelection();
        }

        private void btn_InformationStaffBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.nama_staff(namastaff);
            mainForm.Show();
            this.Close();
        }

        private void dgv_InformationStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_SID.Show();
            lb_SNIK.Show();
            lb_SName.Show();
            lb_SGender.Show();
            lable.Show();
            lablellll.Show();
            lb_SPhone.Show();
            lb_SEmail.Show();

            DataGridViewRow dgvDetailS = dgv_InformationStaff.CurrentRow;
            lb_SID.Text = dgvDetailS.Cells[0].Value.ToString();
            lb_SNIK.Text = dgvDetailS.Cells[1].Value.ToString();
            lb_SName.Text = dgvDetailS.Cells[2].Value.ToString();
            lb_SGender.Text = dgvDetailS.Cells[3].Value.ToString();
            lb_SBirthday.Text = dgvDetailS.Cells[4].Value.ToString().Substring(0,10);
            lb_SAddress.Text = dgvDetailS.Cells[5].Value.ToString();
            lb_SPhone.Text = dgvDetailS.Cells[6].Value.ToString();
            lb_SEmail.Text = dgvDetailS.Cells[7].Value.ToString();

            selectedStaff = dgvDetailS.Cells[0].Value.ToString();
            string alamatS = "D:\\STAFF_ID\\" + selectedStaff + ".jpg";
            //pbox_InformationStaff.Image = new Bitmap(alamatS);
        }
    }
}
