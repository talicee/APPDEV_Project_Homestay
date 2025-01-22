using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ALP_Project_02
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dt_staff = new DataTable();

        private void Login_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection(
               $"server=localhost;" +
               $"uid=root;" +
               $"pwd=.;" +
               $"database=indramar_20232_dbd_3");

            string sql = "select staff_id, date_format(staff_tgl_lahir , \"%d%m%Y\"), staff_nama \r\nfrom staff; ";
            sqlCommand = new MySqlCommand(sql, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_staff);

            //user: staff_id , pass: tgl lahir staff
            //tb_username.Text = "S01";
            //tb_password.Text = "01031995";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool exit = true;
            for (int i = 0; i < dt_staff.Columns.Count; i++)
            {
                for (int j = 0; j < dt_staff.Rows.Count; j++)
                {
                    if (tb_username.Text == dt_staff.Rows[j][0].ToString() && tb_password.Text == dt_staff.Rows[j][1].ToString())
                    {
                        MessageBox.Show("Login Success!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Data.namastaff = dt_staff.Rows[j][2].ToString();
                        MainForm MF = new MainForm();
                        MF.nama_staff(tb_username.Text);
                        MF.Show();
                        this.Hide();
                        exit = false;
                    }
                }
                break;
            }

            if (exit == true)
            {
                MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_username.Text = "";
                tb_password.Text = "";
            }
        }

        private void tb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_username.Text.Length >= 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //USERNAME: nama staff
        //PASSWORD: id staff

    }
}
