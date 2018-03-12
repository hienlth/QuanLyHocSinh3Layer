using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHSDTO;
using QLHSDAO;
using System.Windows;

namespace QLHSBUS
{
    public class HocSinhBUS
    {
        public static bool themHocSinh(HocSinh hs)
        {
            //kiểm tra ràng buộc tự nhiên
            //RBTN1: tên phải có
            if (hs.TenHS == "") return false;
            //kiểm tra ràng buộc nghiệp vụ
            //RBNV1 : tuổi tối thiểu 15
            int tuoi = DateTime.Now.Year - hs.NgaySinh.Year;
            if (tuoi < 15) return false;
            //thực hiện thêm
            try
            {
                HocSinhDAO.themHocSinh(hs);
                return true;
            }
            catch
            {               
                return false;
            }
        }

        public static bool xoaHocSinh(string mahs)
        {
            try
            {
                HocSinhDAO.xoaHocSinh(mahs);
                return true;
            }
            catch
            {
                return false;
            } 
        }

        public static bool suaHocSinh(HocSinh hs)
        {
            //kiểm tra ràng buộc tự nhiên
            //RBTN1: tên phải có
            if (hs.TenHS == "") return false;
            //kiểm tra ràng buộc nghiệp vụ
            //RBNV1 : tuổi tối thiểu 15
            int tuoi = DateTime.Now.Year - hs.NgaySinh.Year;
            if (tuoi < 15) return false;
            //thực hiện thêm
            try
            {
                HocSinhDAO.suaHocSinh(hs);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<HocSinh> layDSHocSinh()
        {
            return HocSinhDAO.layDSHocSinh();
        }
        public static List<HocSinh> layDSHocSinhTheoLop(string malop)
        {
            return HocSinhDAO.layDSHSTheoLop(malop);
        }
        public static List<HocSinh> timHocSinhTheoTen(string ten)
        {
            return HocSinhDAO.timTheoTenHS(ten);
        }
    }
}
