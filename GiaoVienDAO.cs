using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapvenha_W03
{
    internal class GiaoVienDAO
    {
        DBConnection dbc = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr1);
        public void Them(GiaoVien gv)
        {
            string sqlStr = string.Format("INSERT INTO GiaoVien(MaGV,Ten , Quequan,Ngay, Cmnd, Email,Sdt) VALUES ('{0}', '{1}', '{2}','{3}','{4}','{5}','{6}')", gv.Magv, gv.Ten, gv.Quequan, gv.Ngay, gv.Cmnd, gv.Email, gv.Sdt);
            dbc.check_rongGV(gv);          
            dbc.Check_mail(gv.Email);
            dbc.check_sdt(gv.Sdt);
            dbc.Thucthi(sqlStr, conn);
        }
        public void Xoa(GiaoVien gv) 
        {
            string sqlStr = string.Format("DELETE from GiaoVien WHERE MaGV ='{0}'", gv.Magv);
            dbc.Thucthi(sqlStr, conn);
        }
        public void Sua(GiaoVien gv)
        {
            string sqlStr = string.Format("UPDATE GiaoVien SET Ten = '{0}', Quequan = '{1}',Ngay = '{2}', Cmnd = '{3}',Email ='{4}', Sdt = '{5}'  WHERE MaGV = '{6}'", gv.Ten, gv.Quequan,gv.Ngay, gv.Cmnd, gv.Email, gv.Sdt,gv.Magv);
            dbc.Check_mail(gv.Email);
            dbc.check_sdt(gv.Sdt);
            dbc.Thucthi(sqlStr, conn);
        }
    }
}
