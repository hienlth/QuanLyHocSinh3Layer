using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHSDTO;
using System.Data;
using EC17_ADONET;
using System.Data.SqlClient;

namespace QLHSDAO
{
    //Viết các hàm liên quan tới đối tượng HocSinh bao gồm Thêm, Xóa, Sửa, Lấy, tìm kiếm
    public class HocSinhDAO
    {
        public static List<HocSinh> layDSHocSinh()
        {
            List<HocSinh> dsHS = new List<HocSinh>();
            DataTable dtHS = DataProvider.TruyVan_LayDuLieu("SELECT * FROM HocSinh");
            foreach(DataRow r in dtHS.Rows)
            {
                HocSinh hs = new HocSinh
                {
                    MaHS = r["MaHS"].ToString(),
                    TenHS = r["TenHS"].ToString(),
                    DiaChi = r["DiaChi"].ToString(),
                    MaLop = r["MaLop"].ToString()
                };
                if (r["NgaySinh"].ToString() != "")
                    hs.NgaySinh = DateTime.Parse(r["NgaySinh"].ToString());
                if (r["DTB"].ToString() != "")
                    hs.DTB = double.Parse(r["DTB"].ToString());
                dsHS.Add(hs);
            }
            return dsHS;
        }

        /// <summary>
        /// Thêm 1 học sinh mới
        /// </summary>
        /// <param name="hs">Thông tin học sinh</param>
        public static void themHocSinh(HocSinh hs){
            string sql = "INSERT INTO HocSinh(MaHS, TenHS, NgaySinh, DiaChi, DTB, MaLop) VALUES(@MaHS, @TenHS, @NgaySinh, @DiaChi, @DTB, @MaLop)";
            SqlParameter[] pa = new SqlParameter[6];
            pa[0] = new SqlParameter("MaHS", hs.MaHS);
            pa[1] = new SqlParameter("TenHS", hs.TenHS);
            pa[2] = new SqlParameter("NgaySinh", SqlDbType.DateTime);
            pa[2].Value = hs.NgaySinh;
            pa[3] = new SqlParameter("DiaChi", hs.DiaChi);
            pa[4] = new SqlParameter("DTB", SqlDbType.Real);
            pa[4].Value = hs.DTB;
            pa[5] = new SqlParameter("MaLop", hs.MaLop);
            DataProvider.ExcuteNonQuery(sql, CommandType.Text, pa);
        }

        public static void xoaHocSinh(string MaHS) {
            string sql = "DELETE FROM HocSinh WHERE MaHS = @MaHS";
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("MaHS", MaHS);            
            DataProvider.ExcuteNonQuery(sql, CommandType.Text, pa);
        }

        public static void suaHocSinh(HocSinh hs) {
            string sql = "UPDATE HocSinh SET TenHS=@TenHS, NgaySinh=@NgaySinh, DiaChi=@DiaChi, DTB=@DTB, MaLop=@MaLop WHERE MaHS = @MaHS";
            SqlParameter[] pa = new SqlParameter[6];
            pa[0] = new SqlParameter("MaHS", hs.MaHS);
            pa[1] = new SqlParameter("TenHS", hs.TenHS);
            pa[2] = new SqlParameter("NgaySinh", SqlDbType.DateTime);
            pa[2].Value = hs.NgaySinh;
            pa[3] = new SqlParameter("DiaChi", hs.DiaChi);
            pa[4] = new SqlParameter("DTB", SqlDbType.Real);
            pa[4].Value = hs.DTB;
            pa[5] = new SqlParameter("MaLop", hs.MaLop);
            DataProvider.ExcuteNonQuery(sql, CommandType.Text, pa);
        }

        public static List<HocSinh> timTheoTenHS(string ten) {
            List<HocSinh> dsHS = new List<HocSinh>();
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("Ten", ten);
            DataTable dtHS = DataProvider.SelectData("SELECT * FROM HocSinh WHERE TenHS LIKE N'%' + @Ten + '%'", CommandType.Text, pa);
            foreach (DataRow r in dtHS.Rows)
            {
                HocSinh hs = new HocSinh
                {
                    MaHS = r["MaHS"].ToString(),
                    TenHS = r["TenHS"].ToString(),
                    DiaChi = r["DiaChi"].ToString(),
                    MaLop = r["MaLop"].ToString()
                };
                if (r["NgaySinh"].ToString() != "")
                    hs.NgaySinh = DateTime.Parse(r["NgaySinh"].ToString());
                if (r["DTB"].ToString() != "")
                    hs.DTB = double.Parse(r["DTB"].ToString());
                dsHS.Add(hs);
            }
            return dsHS;
        }

        public static List<HocSinh> layDSHSTheoLop(string malop)
        {
            List<HocSinh> dsHS = new List<HocSinh>();
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("MaLop", malop);
            DataTable dtHS = DataProvider.SelectData("SELECT * FROM HocSinh WHERE MaLop = @MaLop", CommandType.Text, pa);
            foreach (DataRow r in dtHS.Rows)
            {
                HocSinh hs = new HocSinh
                {
                    MaHS = r["MaHS"].ToString(),
                    TenHS = r["TenHS"].ToString(),
                    DiaChi = r["DiaChi"].ToString(),
                    MaLop = r["MaLop"].ToString()
                };
                if (r["NgaySinh"].ToString() != "")
                    hs.NgaySinh = DateTime.Parse(r["NgaySinh"].ToString());
                if (r["DTB"].ToString() != "")
                    hs.DTB = double.Parse(r["DTB"].ToString());
                dsHS.Add(hs);
            }
            return dsHS;
        }
    }
}
