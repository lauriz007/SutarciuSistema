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
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
namespace SutarciuSistema
{
    public partial class Form1 : Form
    {
        int uid = 0;
        string defdir = Directory.GetCurrentDirectory();
        public Form1(int u)
        {
            InitializeComponent();
            uid = u;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Refresh();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;database=sutartys";
            MySqlConnection myConn = new MySqlConnection(constring);
            MySqlCommand sc = new MySqlCommand("select *from sutartys.users where id='" + uid+"';", myConn);
            MySqlDataReader myReader;
            myConn.Open();
            try
            {
                myReader = sc.ExecuteReader();
                string vardas = "name";                
                while (myReader.Read())
                {
                    vardas = myReader.GetString("name");
                  
                }
                greetingslable.Text = "Sveiki " + vardas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Refresh();
        }
      
        

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Pavardebox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;database=sutartys";
            MySqlConnection myConn = new MySqlConnection(constring);
            string Querry = "update sutartys.sutartys set nr='" + this.idbox.Text + "',vardas='" + this.vardasbox.Text + "',pavarde='" + this.pavardebox.Text + "',asmens_kodas='" + this.akodbox.Text + "',tel_nr='" + this.telbox.Text + "',el_pastas='" + this.emailb.Text + "' where nr='" + this.idbox.Text + "' and uid="+uid+";";

            MySqlCommand cmdDataBase = new MySqlCommand(Querry, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Sutartis atnaujinta");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;database=sutartys";
            MySqlConnection myConn = new MySqlConnection(constring);
            string Querry = "delete from sutartys.sutartys where nr='" + this.idbox.Text +  "' and uid="+uid+";";

            MySqlCommand cmdDataBase = new MySqlCommand(Querry, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Sutartis atnaujinta");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Refresh();
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;database=sutartys";
            MySqlConnection myConn = new MySqlConnection(constring);
            string Querry = "insert into sutartys.sutartys (nr,vardas,pavarde,asmens_kodas,tel_nr,el_pastas, uid) values ('"+this.idbox.Text+"','"+this.vardasbox.Text + "','" +this.pavardebox.Text + "','" +this.akodbox.Text + "','" +this.telbox.Text + "','" +this.emailb.Text+"',"+uid+");";
            
            MySqlCommand cmdDataBase = new MySqlCommand(Querry, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Sutartis sukurta");
                while(myReader.Read())
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Refresh();
        }

        private void Akodbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Idbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        public void Refresh()
        {
            string constring = "server=localhost;user id=root;database=sutartys";
            MySqlConnection myConn = new MySqlConnection(constring);
            string Querry = "select nr, vardas, pavarde, asmens_kodas, tel_nr, el_pastas from sutartys.sutartys where uid="+uid+";";

            MySqlCommand cmdDataBase = new MySqlCommand(Querry, myConn);
            
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;

                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                sutartystable.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sutartystable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = this.sutartystable.Rows[e.RowIndex];
                idbox.Text = row.Cells["nr"].Value.ToString();
                vardasbox.Text = row.Cells["vardas"].Value.ToString();
                pavardebox.Text = row.Cells["pavarde"].Value.ToString();
                akodbox.Text = row.Cells["asmens_kodas"].Value.ToString();
                telbox.Text = row.Cells["tel_nr"].Value.ToString();
                emailb.Text = row.Cells["el_pastas"].Value.ToString();
            }
        }

        private void Telbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Printbutton_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
            //string defdir = Directory.GetCurrentDirectory();
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("sutartis.pdf",FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph("Sutarties numeris: "+idbox.Text+" \n\n\n"+vardasbox.Text+" "+pavardebox.Text+" sutinka su pateiktom salygom\n \n \n Pasirašiusiojo Kontaktai:\n Tel. nr:"+telbox.Text+"\n el paštas: "+emailb.Text+"\n \n \n \n \n Parašas:___________________________________" );
            doc.Add(paragraph);
            doc.Close();
            MessageBox.Show("Sutartis sukurta:, faila rasite:"+defdir);
        }

        private void Greetingslable_Click(object sender, EventArgs e)
        {

        }

        private void Log_out_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            logregform lr = new logregform();
            lr.Show();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try { 
            string constring = "server=localhost;user id=root;database=sutartys";
            MySqlConnection myConn = new MySqlConnection(constring);
            string Querry = "select nr, vardas, pavarde, asmens_kodas, tel_nr, el_pastas from sutartys.sutartys where uid=" + uid;
            if(!String.IsNullOrEmpty(this.idbox.Text))
            {
                
                Querry += " and nr=" + this.idbox.Text;
                
            }
            
                if (!String.IsNullOrEmpty(this.vardasbox.Text))
            {
                
                    Querry += " and vardas='" + this.vardasbox.Text+"' ";
                
            }
                
            if (!String.IsNullOrEmpty(this.pavardebox.Text))
            {
                
                                
                    Querry += " and pavarde='" + this.pavardebox.Text+"' ";
                
            }
                if (!String.IsNullOrEmpty(this.akodbox.Text))
                {


                    Querry += " and asmens_kodas=" + this.akodbox.Text + " ";
                }   
            
            if (!String.IsNullOrEmpty(this.telbox.Text))
            {
               
                    Querry += " and tel_nr= " + this.telbox.Text+"";
                
            }
            if (!String.IsNullOrEmpty(this.emailb.Text))
            {
               
                    Querry += " and el_pastas='" + this.emailb.Text+"'";
                
            }
            Querry += ";";
            MessageBox.Show(Querry);
            MySqlCommand cmdDataBase = new MySqlCommand(Querry, myConn);

            
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;

                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                sutartystable.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
