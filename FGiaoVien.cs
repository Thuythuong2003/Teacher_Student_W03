using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitapvenha_W03
{
    public partial class FGiaoVien : Form
    {
        DBConnection dbc = new DBConnection();
        GiaoVienDAO hsd = new GiaoVienDAO();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr1);
        string sqlStr = string.Format("SELECT*FROM GiaoVien");
        void Hienthi()
        {
            gvGvien.DataSource = dbc.LayDS(sqlStr, conn);
        }
        public FGiaoVien()
        {
            InitializeComponent();
        }
        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            Hienthi();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtMaGV.Text, txtTen.Text, txtQuequan.Text, dateTimePicker1.Value, txtCmnd.Text, txtEmail.Text, txtSđt.Text);
            hsd.Them(gv);
            Hienthi();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtMaGV.Text, txtTen.Text, txtQuequan.Text, dateTimePicker1.Value, txtCmnd.Text, txtEmail.Text, txtSđt.Text);
            hsd.Xoa(gv);
            Hienthi();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtMaGV.Text, txtTen.Text, txtQuequan.Text, dateTimePicker1.Value, txtCmnd.Text, txtEmail.Text, txtSđt.Text);
            hsd.Sua(gv);
            Hienthi();
        }
        private void dtgGvien(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gvGvien.Rows[e.RowIndex];
            txtMaGV.Text = Convert.ToString(row.Cells[0].Value);
            txtTen.Text = Convert.ToString(row.Cells[1].Value);
            txtQuequan.Text = Convert.ToString(row.Cells[2].Value);
            dateTimePicker1.Text = Convert.ToString(row.Cells[3].Value);
            txtCmnd.Text = Convert.ToString(row.Cells[4].Value);
            txtEmail.Text = Convert.ToString(row.Cells[5].Value);
            txtSđt.Text = Convert.ToString(row.Cells[6].Value);
        }
    }
}
