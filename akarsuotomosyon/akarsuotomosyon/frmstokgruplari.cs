using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace akarsuotomosyon
{
	public partial class frmstokgruplari: DevExpress.XtraEditors.XtraForm
	{
        public bool secim = false;
        public frmstokgruplari()
		{
            InitializeComponent();
		}

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void frmstokgruplari_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {

        }
    }
}