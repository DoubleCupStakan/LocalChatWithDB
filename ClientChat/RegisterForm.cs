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
    public partial class RegisterForm : Form
    {
        private SqlConnection sqlConnection = null;
        //Form1 username;
        //Form1 password;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ClientDB"].ConnectionString);

            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение установлено");
            } 
            
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"INSERT INTO [UserID] (Username, Password) VALUES (@Username, @Password)", sqlConnection);
            cmd.Parameters.AddWithValue("Username", tbUserAutho.Text);
            cmd.Parameters.AddWithValue("Password", tbPassAutho.Text);

            MessageBox.Show(cmd.ExecuteNonQuery().ToString());

            Form1 form1 = new Form1();
            form1.Txt = tbUserAutho.Text;

            this.Hide();
            Form1 CLient = new Form1();
            CLient.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthorizeForm A = new AuthorizeForm();
            A.ShowDialog();
        }
    }
}
