using EC17_ADONET;
using QLHSDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSDAO
{
    public class LopHocDAO
    {
        public static List<LopHoc> layDSLop()
        {            
            List<LopHoc> dsLop = new List<LopHoc>();
            try
            {
                DataTable dtLop = DataProvider.TruyVan_LayDuLieu("SELECT * FROM Lop");
                foreach (DataRow r in dtLop.Rows)
                {
                    LopHoc lh = new LopHoc
                    {
                        MaLop = r["MaLop"].ToString(),
                        TenLop = r["TenLop"].ToString(),
                        SiSo = int.Parse(r["SiSo"].ToString())
                    };
                    dsLop.Add(lh);
                }
            }
            catch
            {
                dsLop = new List<LopHoc>();
            }           
            return dsLop;
        }
    }
}
