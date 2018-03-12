using QLHSDAO;
using QLHSDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSBUS
{
    public class LopHocBUS
    {
        public static List<LopHoc> LayDSLop()
        {
            return LopHocDAO.layDSLop();
        }
    }
}
