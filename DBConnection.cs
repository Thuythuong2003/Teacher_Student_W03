using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Baitapvenha_W03
{
    internal class DBConnection
    {
        public void Thucthi(string sqlStr, SqlConnection conn)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show(" thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LayDS(string sqlStr, SqlConnection conn)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtDsach = new DataTable();
                adapter.Fill(dtDsach);
                return dtDsach;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public void Check_mail(string email)
        {
            try
            {
                MailAddress em = new MailAddress(email);
            }
            catch(FormatException)
            {
                MessageBox.Show("Email khong hop le, vui long nhap lai");
                throw;
            }
        }
        public void check_rongHS(HocSinh hs)
        {
            try
            {
                if (hs.Mahs == "" || hs.Ten == "" || hs.Quequan == "" || hs.Cmnd == "" || hs.Email == "" || hs.Sdt == "")
                {
                    MessageBox.Show(" Vui long nhap day du thong tin ");
                    throw new Exception();
                }
        }
            catch(Exception)
            {
                throw;
            }
}
        public void check_rongGV(GiaoVien gv)
        {
            try
            {
                if (gv.Magv == "" || gv.Ten == "" || gv.Quequan == "" || gv.Cmnd == "" || gv.Email == "" || gv.Sdt == "")
                {
                    MessageBox.Show(" Vui long nhap day du thong tin ");
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void check_sdt(string sdt)
        {
            try
            {
                for (int i = 0; i < sdt.Length; i++)
                {
                    if (sdt.Length>10 || char.IsDigit(sdt[i]) == false)
                    {
                        MessageBox.Show("So dien thoai khong hop le, vui long nhap lai");
                        throw new Exception();
                    }                   
                }
            }
            catch(Exception) 
            {
                throw;
            }
        }
    }
}
