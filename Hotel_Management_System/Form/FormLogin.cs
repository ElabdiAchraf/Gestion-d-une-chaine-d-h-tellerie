using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using n = Npgsql;
using AMRConnector;

namespace Hotel_Management_System
{
    public partial class FormLogin : Form
    {
        static string strConnString = "server=localhost;port=5432;user id=postgres;password=postgresPW;database=postgresDB";
        //NpgsqlConnection db;
        n.NpgsqlConnection cnx = new n.NpgsqlConnection(strConnString);
        n.NpgsqlCommand cmd;
        n.NpgsqlDataAdapter ada;
        DataTable dt;

        public FormLogin()
        {
            InitializeComponent();


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            cmd = new n.NpgsqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM public.users";
            ada = new n.NpgsqlDataAdapter(cmd);
            /*
            try
            {
                NpgsqlConnection objConn = new NpgsqlConnection(strConnString);
                objConn.Open();
                string strpostgracecommand = "select User_ID , User_name , User_Password  from User_Table";
                NpgsqlDataAdapter objDataAdapter = new NpgsqlDataAdapter(strpostgracecommand, strpostgracecommand);
                System.Windows.Forms.MessageBox.Show(objDataAdapter.ToString(), "Succes message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objConn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            */

        }

       

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            cnx.Open();

            // bool check = db.IsValidNamePass(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());

            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == String.Empty)
                MessageBox.Show("Please fill out all field", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                /*
                if (check)
                {
                */
                dt = new DataTable();
                ada.Fill(dt);
                MessageBox.Show("Welcome " + textBoxUsername.Text, "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDashboard fd = new FormDashboard();
                fd.Username = textBoxUsername.Text;
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                fd.Show();
                /*
                }
                else MessageBox.Show("Invalid Username or Password", "Username or Password ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                */
            }

            //FormDashboard fd = new FormDashboard();
            // fd.Show();

            cnx.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
