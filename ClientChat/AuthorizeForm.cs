using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientChat
{
    public partial class AuthorizeForm : Form
    {
        private SqlConnection sqlConnection = null;
        public AuthorizeForm()
        {
            InitializeComponent();
        }


        private void bLogin_Click(object sender, EventArgs e)
        {
            String loginU = tbUserAutho.Text;
            String passU = tbPassAutho.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            SqlConnection conn = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [UserID] where Username = @Username AND Password = @Password", sqlConnection);
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = loginU;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = passU;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("Not");
            }

        }

        private void AuthorizeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm R = new RegisterForm();
            R.ShowDialog();
        }
    }
}
