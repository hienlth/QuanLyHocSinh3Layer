using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSDTO
{
    public class LopHoc
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public List<HocSinh> dsHocSinh { get; set; }
    }
}
