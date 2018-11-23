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

namespace MysqlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string nev = nev_form.Text;
            string jelszo = jelszo_form.Text;
            DateTime regdatum = szuletesiido.Value;

            using (var conn = new MySqlConnection("Server=localhost;Database=regisztracio;UID=root;Pwd=")) {
                var command = conn.CreateCommand();

                command.CommandText = "insert into felhasznalo (nev, jelszo, regdatum) values (@nev,@jelszo,@regdatum)";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum", regdatum);
                command.ExecuteNonQuery();


            }

        }
    }
}
