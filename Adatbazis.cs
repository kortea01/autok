using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _2024_jan_21_autok_kortea
{
    internal class Adatbazis
    {
        MySqlConnection conn=null;
        MySqlCommand sql=null;
        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "autok";
            builder.CharacterSet = "utf8";
            conn = new MySqlConnection(builder.ConnectionString);
            sql=conn.CreateCommand();

            try
            {
                kapcsolatNyit();                
            }
            catch (MySqlException ex) 
            {
                MessageBox.Show(ex.Message);                
                Environment.Exit(0);
            
            } finally
            {
                kapcsolatZar();
            }

        }

        private void kapcsolatZar()
        {
            if (conn.State != System.Data.ConnectionState.Closed) conn.Close();
        }

        private void kapcsolatNyit()
        {
            if(conn.State!=System.Data.ConnectionState.Open) conn.Open();
        }

        internal List<Autok> getAllAuto()
        {
            List<Autok> autok = new List<Autok>();
            sql.CommandText = "SELECT * FROM `auto` ORDER BY `marka`;";
            try
            {
                kapcsolatNyit();
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string rendszam = dr.GetString("rendszam");
                        string marka = dr.GetString("marka");
                        string modell = dr.GetString("modell");
                        int gyartasi_ev = dr.GetInt32("gyartasiev");
                        DateTime forgalmi_erv = dr.GetDateTime("forgalmiErvenyesseg");
                        int vetelar = dr.GetInt32("vetelar");
                        int km_allas = dr.GetInt32("kmallas");
                        int hengerurtartalom = dr.GetInt32("hengerűrtartalom");
                        int tomeg = dr.GetInt32("tomeg");
                        int teljesitmeny = dr.GetInt32("teljesitmeny");
                        autok.Add(new Autok(forgalmi_erv, rendszam, marka, modell, gyartasi_ev, vetelar, km_allas, hengerurtartalom, tomeg, teljesitmeny));
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally 
            {              
                
                kapcsolatZar();
            }
            return autok;
        }

        internal void updateAuto(Autok auto)
        {
            sql.CommandText = "UPDATE `auto` SET " +
                "`marka`=@marka," +
                "`modell`=@modell," +
                "`gyartasi_ev`=@gyartasi_ev," +
                "`forgalmi_erv`=@forgalmi_erv," +
                "`vetelar`=@vetelar," +
                "`km_allas`=@km_allas," +
                "`hengerurtartalom`=@hengerurtartalom," +
                "`tomeg`=@tomeg," +
                "`teljesitmeny`=@teljesitmeny " +
                "WHERE `rendszam`=@rendszam";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@marka", auto.Marka);
            try
            {
                kapcsolatNyit();
                sql.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { kapcsolatZar(); }
        }

        internal void deleteAuto(Autok auto)
        {
            sql.CommandText = "DELETE * from `auto`" +                
                "WHERE `rendszam`=@rendszam";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@marka", auto.Marka);
            try
            {
                kapcsolatNyit();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { kapcsolatZar(); }
        }

        internal void insertAuto(Autok auto)
        {
            sql.CommandText = "INSERT into `auto` ( " +
                "`marka`," +
                "`modell`," +
                "`gyartasi_ev`," +
                "`forgalmi_erv`," +
                "`vetelar`," +
                "`km_allas`," +
                "`hengerurtartalom`," +
                "`tomeg`," +
                "`teljesitmeny`)" +
                "VALUES (@marka,@modell" +
                ",@gyartasi_ev,@forgalmi_erv," +
                "@vetelar,@km_allas,@hengerurtartalom," +
                "@tomeg,@teljesitmeny)";
            ;
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@marka", auto.Marka);
            try
            {
                kapcsolatNyit();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { kapcsolatZar(); }
        }
    }
}
