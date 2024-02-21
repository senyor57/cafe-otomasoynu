using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Kafe_Restorant_Yonetim_Sistemi
{
    class Veritabani
    {

        #region Degiskenler
        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source = Veritabani/kafe.mdb");//baglan 
        #endregion
        public static void baglantiKontrol()//Bağlantı kapalıysa açmak için kullandık
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Veri Tabanı Bağlantısı Yapılamadı");
                    Application.Exit();
                }
            }
        }

        public static DataTable VeriGetir(string sql) //Tüm işlemler için
        {
            baglantiKontrol();
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

      
      
    }
}
