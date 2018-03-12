using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHSBUS;

namespace QLHSGUI
{
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            //load ds lớp
            cboLop.DataSource = LopHocBUS.LayDSLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.SelectedIndexChanged += new EventHandler(cboLop_SelectedIndexChanged);

            loadDSHocSinh();
            dgvHocSinh.AutoResizeColumns();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string malop = cboLop.SelectedValue.ToString();
            dgvHocSinh.DataSource = HocSinhBUS.layDSHocSinhTheoLop(malop);
            dgvHocSinh.AutoResizeColumns();
        }

        private void loadDSHocSinh()
        {
            dgvHocSinh.DataSource = HocSinhBUS.layDSHocSinh();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = HocSinhBUS.timHocSinhTheoTen(txtTenHSSearch.Text.Trim());
            dgvHocSinh.AutoResizeColumns();
        }
    }
}
