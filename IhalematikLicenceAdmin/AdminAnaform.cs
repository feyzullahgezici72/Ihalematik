using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;


namespace IhalematikLicenceAdmin
{
    public partial class AdminAnaform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AdminAnaform()
        {
            InitializeComponent();
        }




        MusteriOlustur pl;
        private void btnMusteri_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pl == null)
            {
                pl = new MusteriOlustur();
                pl.MdiParent = this;
                pl.FormClosed +=new FormClosedEventHandler(Pl_FormClosed);
                pl.Show();
            }
            else
            {
                pl.Activate();
            }

        }

        private void Pl_FormClosed(object sender, FormClosedEventArgs e)
        {
            pl = null;
        }

        private void AdminAnaform_Load(object sender, EventArgs e)
        {

        }
    }
}