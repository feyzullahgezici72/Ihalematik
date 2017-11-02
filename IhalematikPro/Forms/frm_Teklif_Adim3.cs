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
using IhalematikProBL.Entity;
using IhalematikPro.Manager;
using IhalematikPro.Model;
using DevExpress.XtraEditors.Repository;
using System.Reflection;
using System.Dynamic;
using System.Threading;
using System.Reflection.Emit;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using IhalematikProUI.Model;
using IhalematikProBL.Enum;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms;
using SimpleApplicationBase.BL.Base;

namespace IhalematikPro.Forms
{
    public partial class frm_Teklif_Adim3 : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        public bool IsInitializeTenderMaterialListEquipment = false;
        public bool isDataGridFormatted = false;
        private object a4;

        #endregion

        #region initialize
        public frm_Teklif_Adim3()
        {
            InitializeComponent();
            //repositoryItemLookUpEdit1.DataSource = this.GetUnitTimes();
            //repositoryItemLookUpEdit1.DisplayMember = "DisplayText";
            //repositoryItemLookUpEdit1.ValueMember = "Id";
            //repositoryItemLookUpEdit1.ForceInitialize();
            //repositoryItemLookUpEdit1.PopulateColumns();

            //repositoryItemLookUpEdit1.Properties.Columns["Id"].Visible = false;
            //repositoryItemLookUpEdit1.Properties.Columns["UnitTimeType"].Visible = false;

            //List<StokModel> models = new List<StokModel>();
            //for (int i = 0; i < 3; i++)
            //{
            //    StokModel m = new StokModel()
            //    {
            //        Quantity = 10,
            //        Total = 20,
            //        UnitTime = 10
            //    };
            //    models.Add(m);
            //}

            bindingSourceAddWorker.DataSource = typeof(List<TenderMaterialListEquipmentModel>);

            grdAddWorker.DataSource = bindingSourceAddWorker;
        }

        #endregion

        #region Custom Methods
        public void panelKapat()
        {
            isciAracGirisPaneli.Top = 0;
            isciAracGirisPaneli.Visible = false;
            grdMaterialListIsWorkship.Enabled = true;
        }
        public void panelAc(MaterialListModel CurrentItem)
        {
            txtCurrentNumber.Text = CurrentItem.PozOBFNumber;
            txtCurrentDescription.Text = CurrentItem.PozOBFDescription;
            txtCurrentQuantity.Text = CurrentItem.Quantity.ToString();
            txtCurrentUnit.Text = CurrentItem.PozOBFUnit;

            isciAracGirisPaneli.Top = 0;
            isciAracGirisPaneli.Visible = true;
            grdMaterialListIsWorkship.Enabled = false;

            //grdAddWorker.DataSource = CurrentItem.TenderMaterialListEquipment;
        }

        private List<UnitTimeTypesModel> GetUnitTimes()
        {
            List<UnitTimeTypesModel> models = new List<UnitTimeTypesModel>();

            foreach (UnitTimeTypesEnum unitTimeType in Enum.GetValues(typeof(UnitTimeTypesEnum)))
            {
                UnitTimeTypesModel model = new UnitTimeTypesModel().Create(unitTimeType);
                models.Add(model);
            }

            return models;
        }

        #endregion

        #region Form Event
        private void frm_Teklif_Adim3_Load(object sender, EventArgs e)
        {
            //panel
            isciAracGirisPaneli.Top = 0;
            isciAracGirisPaneli.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (isciAracGirisPaneli.Width / 2);
            //panel 
            lblTenderDescription.Text = CurrentManager.CurrentTender.Description;
            lblTenderNumber.Text = CurrentManager.CurrentTender.DisplayNumber;
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            grdMaterialListIsWorkship.DataSource = models;
            //InitializeTenderMaterialListEquipment();
            txtBaseAmount.Text = models.Sum(p => p.Quantity * p.WorkerUnitPrice).ToString("c2");
            txtMarkupAmount.Text = models.Sum(p => p.MarkupUnitPrice).ToString("c2");
            txtTotalAmount.Text = models.Sum(p => (p.Quantity * p.WorkerUnitPrice) + p.MarkupUnitPrice).ToString("c2");
        }

        private void btnTumuneUygulaIscilik_Click(object sender, EventArgs e)
        {
            //double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtWorkerMarkup.Text);
            //List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            //List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            //models.ForEach(p => p.Markup = markup);
            //foreach (var item in items)
            //{
            //    item.Markup = markup;
            //    OperationResult result = MaterialListProvider.Instance.Save(item);
            //    if (!result.Success)
            //    {
            //        //TODO feyzullahg
            //    }
            //}
            //grdMaterialListIsWorkship.DataSource = models;
            //grdMaterialListIsWorkship.Refresh();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            foreach (MaterialListModel materialListModel in models)
            {
                materialListModel.Save();

                //foreach (TenderMaterialListEquipment tenderMaterialListEquipment in materialListModel.TenderMaterialListEquipment)
                //{
                //    TenderMaterialListEquipmentProvider.Instance.Save(tenderMaterialListEquipment);
                //}
            }
            frm_ihaleOlustuMesaj msj = new frm_ihaleOlustuMesaj();
            msj.lblMesaj.Text = "Kaydedildi...";
            msj.ShowDialog();
            this.Close();


            frm_TeklifAdimSon a4 = (frm_TeklifAdimSon)Application.OpenForms[" frm_TeklifSonAdim"];

            if (a4 == null)
            {
                a4 = new frm_TeklifAdimSon();
                a4.MdiParent = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                a4.FormClosed += new FormClosedEventHandler(a4_FormClosed);
                a4.Show();

            }
            else
            {
                a4.Activate();
            }


        }

        private void a4_FormClosed(object sender, FormClosedEventArgs e)
        {
            a4 = null;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtWorkerMarkup.Text.Replace("%", ""));
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            models.ForEach(p => p.Markup = markup);
            foreach (var item in items)
            {
                item.WorkerMarkup = markup;
                OperationResult result = MaterialListProvider.Instance.Save(item);
                if (!result.Success)
                {
                    //TODO feyzullahg
                }
            }
            this.frm_Teklif_Adim3_Load(null, null);
        }

        private void btnPanelKapat_Click(object sender, EventArgs e)
        {
            panelKapat();
            grdMaterialListIsWorkship.Refresh();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            panelKapat();
        }

        #endregion

        #region Grid Event
        private void btnCalisanlarveAraclar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int currentId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            List<MaterialListModel> models = grdMaterialListIsWorkship.DataSource as List<MaterialListModel>;
            foreach (var item in models)
            {
                if (item.Id == currentId)
                {
                    item.TenderMaterialListEquipment = null;
                    this.panelAc(item);
                    List<TenderMaterialListEquipmentModel> tenderMaterialListEquipmentModels = new List<TenderMaterialListEquipmentModel>();

                    if (item.TenderMaterialListEquipment != null)
                    {
                        foreach (TenderMaterialListEquipment tenderMaterialListEquipment in item.TenderMaterialListEquipment)
                        {
                            TenderMaterialListEquipmentModel tenderMaterialListEquipmentModel = new TenderMaterialListEquipmentModel(tenderMaterialListEquipment);
                            tenderMaterialListEquipmentModels.Add(tenderMaterialListEquipmentModel);
                        }
                    }
                    bindingSourceAddWorker.DataSource = tenderMaterialListEquipmentModels;
                    break;
                }
            }
        }

        private void gridViewAddWorker_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int currentId = Convert.ToInt32(gridViewAddWorker.GetFocusedRowCellValue("Id"));
            List<TenderMaterialListEquipmentModel> items = (List<TenderMaterialListEquipmentModel>)bindingSourceAddWorker.DataSource;
            TenderMaterialListEquipmentModel currentItem = new TenderMaterialListEquipmentModel();
            foreach (TenderMaterialListEquipmentModel item in items)
            {
                if (item.Id == currentId)
                {
                    currentItem = item;
                    break;
                }
            }
            if (e.Column == colQuantity)
            {
                currentItem.Quantity = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
            }
            else if (e.Column == colUnitTime)
            {
                currentItem.UnitTime = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(e.Value);
            }
            else if (e.Column == colUnitTimeType)
            {
                currentItem.UnitTimeType = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<UnitTimeTypesEnum>(e.Value);
            }

            currentItem.Save();
        }

        #endregion
    }
}