using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapvenha_W03
{
    internal class HocSinhDAO
    {
        DBConnection dbc = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void Them(HocSinh hs)
        {
            string sqlStr = string.Format("INSERT INTO Hocsinh(MaHS,Ten , Quequan,Ngay, Cmnd, Email,Sdt) VALUES ('{0}', '{1}', '{2}','{3}','{4}','{5}','{6}')", hs.Mahs,hs.Ten,hs.Quequan,hs.Ngay,hs.Cmnd,hs.Email,hs.Sdt);
            dbc.check_rongHS(hs);
            dbc.Check_mail(hs.Email);
            dbc.check_sdt(hs.Sdt);
            dbc.Thucthi(sqlStr, conn);
        }
        public void Xoa(HocSinh hs)
        {
            string sqlStr = string.Format("DELETE from HocSinh WHERE MaHS ='{0}'", hs.Mahs);
            dbc.Thucthi(sqlStr, conn);
        }
        public void Sua(HocSinh hs)
        {
            string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', Quequan = '{1}',Ngay = '{2}', Cmnd = '{3}',Email ='{4}', Sdt = '{5}'  WHERE MaHS = '{6}'",hs.Ten,hs.Quequan,hs.Ngay,hs.Cmnd,hs.Email,hs.Sdt,hs.Mahs);
            dbc.Check_mail(hs.Email);
            dbc.check_sdt(hs.Sdt);
            dbc.Thucthi(sqlStr, conn);
        }
    }
}
