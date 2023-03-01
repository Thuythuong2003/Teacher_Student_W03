using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapvenha_W03
{
    internal class GiaoVien
    {
        private string magv;
        private string ten;
        private string quequan;
        private DateTime ngay;
        private string cmnd;
        private string email;
        private string sdt;
        public GiaoVien(string magv, string ten, string quequan, DateTime ngay, string cmnd, string email, string sdt)
        {
            this.magv = magv;
            this.ten = ten;
            this.quequan = quequan;
            this.ngay = ngay;
            this.cmnd = cmnd;
            this.email = email;
            this.sdt = sdt;
        }
        public string Magv 
        {
            get { return magv; }
            set { magv = value; }
        }
        public string Ten 
        {
            get { return ten; }
            set { ten = value; }
        }
        public string Quequan 
        {
            get { return quequan; }
            set { quequan = value; }    
        }
        public DateTime Ngay 
        {
            get { return ngay; }
            set { ngay = value; }
        }
        public string Cmnd 
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        public string Email 
        {
            get { return email; }
            set { email = value; }
        }
        public string Sdt 
        {
            get { return sdt; }
            set { sdt = value; }
        }
    }
}
