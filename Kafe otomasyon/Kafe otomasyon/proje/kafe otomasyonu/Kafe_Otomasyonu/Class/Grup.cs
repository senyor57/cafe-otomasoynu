using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe_Restorant_Yonetim_Sistemi
{
    class Grup
    {
        public static bool grupEkle(object Adi)
        {
            Veritabani.baglantiKontrol();
            try
            {
                OleDbCommand cmd = new OleDbCommand("insert into UrunGrubu (Adi) values (@Adi)", Veritabani.con);
                cmd.Parameters.Add("@Adi", OleDbType.VarWChar).Value = Adi;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }

        }//Ürün grubu eklemek için
        public static bool grupDuzenle(object grupNo, object adi)
        {
            Veritabani.baglantiKontrol();
            try
            {
                OleDbCommand cmd = new OleDbCommand("update UrunGrubu set Adi=@adi where UrunGrupNo=@grupno", Veritabani.con);
                cmd.Parameters.Add("@adi", OleDbType.VarWChar).Value = adi;
                cmd.Parameters.Add("@grupno", OleDbType.Integer).Value = Convert.ToInt32(grupNo);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }//ürün grubu düzenlemek için
    }
}
