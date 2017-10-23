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
using IhalematikPro.Model;
using IhalematikPro.Manager;

namespace IhalematikPro.Forms
{
    public partial class frm_AracTanimlama : DevExpress.XtraEditors.XtraForm
    {
        public frm_AracTanimlama()
        {
            InitializeComponent();
            InitilalizeForm();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void araçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void InitilalizeForm()
        {
            List<VehicleTitleModel> models = UIVehicleTitleManager.Instance.GetVehicleTitles();
            ddlVehicleTitle.Properties.Items.AddRange(models);
            ddlVehicleTitle.SelectedIndex = 0;
        }

        private void LoadGrid()
        {
            List<VehicleModel> models = UIVehicleManager.Instance.GetVehicles();
            grdVehicle.DataSource = models;
        }
        private void frm_AracTanimlama_Load(object sender, EventArgs e)
        {
            LoadGrid();
            this.KeyPreview = true;
            this.KeyDown +=new KeyEventHandler(Frm_AracTanimlama_KeyDown);
        }

        private void Frm_AracTanimlama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frm_AracEkle frm = new frm_AracEkle();
                frm.ShowDialog();
            }
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            VehicleModel model = new VehicleModel();
            model.HourPrice = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>(txtExpenseHour.Text);
            //model.IsCompanyVehicle = rbCompanyVehicle.Checked;
            model.OtherPrice = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>(txtOtherPrice.Text);
            model.WorkHour = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>(txtWorkHour.Text);
            model.TitleId = ((VehicleTitleModel)ddlVehicleTitle.SelectedItem).Id.Value;
            model.Save();
            LoadGrid();
        }

        private void yeniAraçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AracEkle frm = new frm_AracEkle();
            frm.ShowDialog();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void rbCompanyVehicle_CheckedChanged(object sender, EventArgs e)
        {
            PanelSirket.Visible = true;
            PanelKira.Visible = false;
            PanelSirket.Location = new Point(13, 72);
        }

        private void rbAsgariUcret_CheckedChanged(object sender, EventArgs e)
        {
            PanelKira.Visible = true;
            PanelSirket.Visible = false;
            PanelKira.Location = new Point(13, 72);

            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_AracEkle frm = new frm_AracEkle();
            frm.ShowDialog();
        }
    }
}