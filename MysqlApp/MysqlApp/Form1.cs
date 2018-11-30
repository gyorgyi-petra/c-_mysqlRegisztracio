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


        const string AdatLetrehozasSql = @"
            CREATE TABLE IF NOT EXISTS felhasznalo (
            
            id INTEGER AUTO_INCREMENT PRIMARY KEY,
            nev VARCHAR(80) NOT NULL UNIQUE,
            jelszo VARCHAR(100) NOT NULL,
            regdatum DATE NOT NULL 
    )
";

        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            try
            {
                conn = new MySqlConnection("Server=localhost;Database=regisztracio;UID=root;Pwd=");

                conn.Open();

                var letrehozas = conn.CreateCommand();
                letrehozas.CommandText = AdatLetrehozasSql;
                letrehozas.ExecuteNonQuery();
            }
            catch (MySqlException ex) {
                MessageBox.Show("Adatbázis hiba: \n" + ex.Message);
                this.Close();
            }
        }

        public void UpdateRegUserek() {
            string kiirando = "Regisztralt {0} db felhastnalo: ";
            var c = conn.CreateCommand();
            c.CommandText = " SELECT COUNT(*) FROM felhasznalo ";
            long darabszam = (long)c.ExecuteScalar();

            reg_userek_label.Text = string.Format(kiirando, darabszam);

            var cFelhasznalok = conn.CreateCommand();
            cFelhasznalok.CommandText = "SELECT nev,regdatum FROM felhasznalo ORDER BY nev";
            using (var reader = cFelhasznalok.ExecuteReader())
            {

                regisztraltak_list.Items.Clear();
                while (reader.Read())
                {
                    var nev = reader.GetString("nev");
                    var datum = reader.GetDateTime("regdatum");
                    regisztraltak_list.Items.Add(
                            string.Format(" {1:yyyy.MM.dd.} - {0}", nev, datum)
                        );
                }
            }

            var cStat = conn.CreateCommand();
            cStat.CommandText = "SELECT regdatum, COUNT(*) db FROM felhasznalo GROUP BY regdatum ORDER BY regdatum";
            using (var reader  = cStat.ExecuteReader()) {
                stat_list.Items.Clear();
                while (reader.Read()) {
                    DateTime datum = reader.GetDateTime("regdatum");
                    long db = reader.GetInt64("db");
                    stat_list.Items.Add(
                        string.Format(" {0:yyyy.MM.dd.} - {1}" , datum,db)
                        );
                };
            }

            var adapter = new MySqlDataAdapter("SELECT nev,regdatum FROM felhasznalo ORDER BY nev", conn);
            var builder = new MySqlCommandBuilder(adapter);
            var table = new DataTable();
          
            adapter.Fill(table);
            dataGridView1.DataSource = table;


            table.RowChanged += (sender, args) =>
            {
                long id = (long)args.Row["id"];
                string nev = (string)args.Row["nev"];
                DateTime datum = (DateTime)args.Row["regdatum"];
                var cUpdate = conn.CreateCommand();
                cUpdate.CommandText = "UPDATE felhasznalo SET nev = @nev, jelszo = @jelszo , regdatum = @regdatum WHERE id = @id";
                cUpdate.Parameters.AddWithValue("@nev", nev);
                cUpdate.Parameters.AddWithValue("@regdatum", datum);
                cUpdate.Parameters.AddWithValue("@id", id);
                cUpdate.ExecuteNonQuery();
            };

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string nev = nev_form.Text;
            string jelszo = jelszo_form.Text;
            DateTime regdatum = szuletesiido.Value;

           
               

                


                var ellenorzes = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) FROM felhasznalo WHERE nev = @nev";
                ellenorzes.Parameters.AddWithValue("@nev", nev);
                var darab = (long)ellenorzes.ExecuteScalar();

                if (darab != 0)
                {
                    MessageBox.Show("Ez a felhasznalonev mar szerepel!");
                    return;

                }


                var command = conn.CreateCommand();
                command.CommandText = "INSERT INTO felhasznalo (nev, jelszo, regdatum) VALUES (@nev,@jelszo,@regdatum)";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum", regdatum);
                int erintettsorok = command.ExecuteNonQuery();

            UpdateRegUserek();

        }
            private void delButton_Click(object sender, EventArgs e)
        {
            string nev = nev_form.Text;
            string jelszo = jelszo_form.Text;
            DateTime regdatum = szuletesiido.Value;
            using (var conn = new MySqlConnection("Server=localhost;Database=regisztracio;UID=root;Pwd="))
            {
                conn.Open();

                var torles_command = conn.CreateCommand();
                torles_command.CommandText = "DELETE FROM felhasznalo WHERE nev = @nev";
                torles_command.Parameters.AddWithValue("@nev", nev);
                int erintettsorok = torles_command.ExecuteNonQuery();

                UpdateRegUserek();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string nev = nev_form.Text;
            string jelszo = jelszo_form.Text;
            DateTime regdatum = szuletesiido.Value;
            using (var conn = new MySqlConnection("Server=localhost;Database=regisztracio;UID=root;Pwd="))
            {
                conn.Open();

                var command = conn.CreateCommand();
                command.CommandText = "UPDATE felhasznalo SET nev = @nev, jelszo = @jelszo , regdatum = @regdatum WHERE nev = @nev";
                command.Parameters.AddWithValue("@nev", nev);
                int erintettsorok = command.ExecuteNonQuery();

                UpdateRegUserek();
            }

        }
    }
}

