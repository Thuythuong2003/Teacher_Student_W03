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
    public partial class FHocSinh : Form
    {
        DBConnection dbc = new DBConnection();
        HocSinhDAO hsd = new HocSinhDAO();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string sqlStr = string.Format("SELECT*FROM HocSinh");
        void Hienthi()
        {
            gvHsinh.DataSource = dbc.LayDS(sqlStr, conn);
        }
        public FHocSinh()
        {
            InitializeComponent();
        }
        private void FHocSinh_Load(object sender, EventArgs e)
        {
            Hienthi();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtMaHS.Text, txtTen.Text, txtQuequan.Text, dateTimePicker1.Value, txtCmnd.Text, txtEmail.Text, txtSđt.Text);
            hsd.Them(hs);
            Hienthi();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtMaHS.Text, txtTen.Text, txtQuequan.Text, dateTimePicker1.Value, txtCmnd.Text, txtEmail.Text, txtSđt.Text);
            hsd.Xoa(hs);
            Hienthi();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtMaHS.Text, txtTen.Text, txtQuequan.Text, dateTimePicker1.Value, txtCmnd.Text, txtEmail.Text, txtSđt.Text);
            hsd.Sua(hs);
            Hienthi();
        }
        private void dtgHsinh(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gvHsinh.Rows[e.RowIndex];
            txtMaHS.Text=Convert.ToString(row.Cells[0].Value);
            txtTen.Text=Convert.ToString(row.Cells[1].Value);
            txtQuequan.Text=Convert.ToString(row.Cells[2].Value);
            dateTimePicker1.Text=Convert.ToString(row.Cells[3].Value);
            txtCmnd.Text=Convert.ToString(row.Cells[4].Value);
            txtEmail.Text=Convert.ToString(row.Cells[5].Value);
            txtSđt.Text=Convert.ToString(row.Cells[6].Value);
        }
    }
}
