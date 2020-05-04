using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace SutarciuSistema
{
    public partial class logregform : Form
    {
        public logregform()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Regbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerform rf = new registerform();
            rf.ShowDialog();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;database=sutartys";
            MySqlConnection myConn = new MySqlConnection(constring);
            MySqlCommand sc = new MySqlCommand("select *from sutartys.users where username='" + this.userbox.Text + "' and password='" + this.passbox.Text + "';", myConn);
            MySqlDataReader myReader;
            myConn.Open();
            try
            {
                myReader = sc.ExecuteReader();
                int count = 0;
                int uid = 0;
                while (myReader.Read())
                {
                    uid = myReader.GetInt32("id");
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Username and password is correct");
                    this.Hide();
                    Form1 f1 = new Form1(uid);
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username and password is incorrect");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
