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
using IhalematikPro.Manager;
using IhalematikProBL.Entity;
using IhalematikPro.Model;
using IhalematikProUI.Model;
using IhalematikProBL.Provider;
using IhalematikProUI.Manager;
using IhalematikProUI.Forms.Base;
using IhalematikProBL.Enum;

namespace IhalematikProUI.Forms.Taseron
{
    public partial class frm_IsMalzemeEkle : IhalematikBaseForm
    {
        private double TotalMarkupNonKDVPreview = 0;

        private double OtherTotalAmount = 0;
        public double OtherCost { get; set; }

        frm_IhaleTasereEt _owner;
        public frm_IsMalzemeEkle(frm_IhaleTasereEt Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            JobberTender currentJobberTender = UICurrentManager.Instance.CurrentJobberTender;
            if (currentJobberTender.MaterialList != null)
            {
                List<JobberMaterialList> items = currentJobberTender.MaterialList;
                foreach (JobberMaterialList item in items)
                {
                    JobberMaterialListProvider.Instance.Save(item);
                }
            }

            this._owner.LoadTenderMaterialList();
            this.Close();
        }

        private void frm_IsMalzemeEkle_Shown(object sender, EventArgs e)
        {
            this.LoadMaterialListGrid();
            this.LoadAddedMaterialListGrid();
            this.RPSTTaseronTipi();
        }

        private void RPSTTaseronTipi()
        {
            List<DropDownModel> jobberTypes = new List<DropDownModel>(); //UIWorkerManager.Instance.GetDropDownWorkers();
            jobberTypes.Add(new DropDownModel() { Text = "İşçilik", Id = 0 });
            jobberTypes.Add(new DropDownModel() { Text = "Malzeme", Id = 1 });
            jobberTypes.Add(new DropDownModel() { Text = "İşçilik/Malzeme", Id = 2 });

            repositoryTaseronTipi.DataSource = jobberTypes;
            repositoryTaseronTipi.DisplayMember = "Text";
            repositoryTaseronTipi.ValueMember = "Id";
            repositoryTaseronTipi.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            repositoryTaseronTipi.NullText = string.Empty;
            repositoryTaseronTipi.ForceInitialize();
            repositoryTaseronTipi.PopulateColumns();
            repositoryTaseronTipi.Properties.Columns["Id"].Visible = false;
            repositoryTaseronTipi.ShowHeader = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            JobberTender currentJobberTender = UICurrentManager.Instance.CurrentJobberTender;
            int[] selectedRows = gridViewMaterialList.GetSelectedRows();
            List<MaterialListModel> dataSource = grdMaterialList.DataSource as List<MaterialListModel>;
            if (dataSource == null)
            {
                return;
            }

            MaterialListModel[] selectedRowsItems = dataSource.ToArray();

            foreach (int item in selectedRows)
            {
                MaterialListModel materialListModel = selectedRowsItems[item];
                JobberMaterialList jobberMaterialList = new JobberMaterialList();
                if (materialListModel.JobberTypeValue == 0)
                {
                    jobberMaterialList.JobberType = JobberTypesEnum.Material;
                }
                else if (materialListModel.JobberTypeValue == 1)
                {
                    jobberMaterialList.JobberType = JobberTypesEnum.Worker;
                }
                if (materialListModel.JobberTypeValue == 2)
                {
                    jobberMaterialList.JobberType = JobberTypesEnum.WorkerMaterial;
                }
                jobberMaterialList.JobberTenderId = currentJobberTender.Id;
                jobberMaterialList.MaterialListId = materialListModel.Id.Value;
                List<JobberMaterialList> items = currentJobberTender.MaterialList.Where(p => p.Id == materialListModel.Id).ToList();

                if (items.Count == 0)
                {
                    currentJobberTender.MaterialList.Add(jobberMaterialList);
                }
            }
            this.LoadMaterialListGrid();
            this.LoadAddedMaterialListGrid();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            JobberTender currentJobberTender = UICurrentManager.Instance.CurrentJobberTender;
            int[] selectedRows = gridView2.GetSelectedRows();
            List<MaterialListModel> models = (List<MaterialListModel>)gridView2.DataSource;

            MaterialListModel[] selectedRowsItems = models.ToArray();
            foreach (int item in selectedRows)
            {
                MaterialListModel pozModel = selectedRowsItems[item];
                JobberMaterialList selectedItem = currentJobberTender.MaterialList.Where(p => p.MaterialListId == pozModel.Id).FirstOrDefault();
                currentJobberTender.MaterialList.Remove(selectedItem);
                if (selectedItem.Id > 0)
                {
                    selectedItem.IsMarkedForDeletion = true;
                    JobberMaterialListProvider.Instance.Save(selectedItem);
                }
            }

            List<MaterialListModel> dataSoruce = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(currentJobberTender.MaterialList.Select(p => p.MaterialList).ToList()).ToList();

            grdAddedJobberMaterialList.DataSource = null;
            grdAddedJobberMaterialList.DataSource = dataSoruce;
            this.LoadMaterialListGrid();
        }

        private void LoadMaterialListGrid()
        {
            JobberTender currentJobberTender = UICurrentManager.Instance.CurrentJobberTender;
            List<JobberMaterialList> selectedMaterialLists = UICurrentManager.Instance.CurrentJobberTender.MaterialList;
            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(currentJobberTender.Tender.MaterialList.ToList()).ToList();

            if (selectedMaterialLists != null)
            {
                foreach (JobberMaterialList item in selectedMaterialLists)
                {
                    bool isExisting = false;
                    MaterialListModel removeModel = new IhalematikPro.Model.MaterialListModel();
                    foreach (var materialListModel in dataSource)
                    {
                        if (materialListModel.Id == item.MaterialList.Id)
                        {
                            isExisting = true;
                            removeModel = materialListModel;
                            break;
                        }
                    }

                    if (isExisting)
                    {
                        int index = dataSource.FindIndex(p => p.Id == removeModel.Id);
                        dataSource.RemoveAt(index);
                    }
                }
            }

            this.LoadMaterialListGridCalculate(dataSource);
        }

        private void LoadMaterialListGridCalculate(List<MaterialListModel> DataSource)
        {
            LoadingManager.Instance.Show(this);

            Tender currentTender = UICurrentManager.Instance.CurrentJobberTender.Tender;
            this.TotalMarkupNonKDVPreview = DataSource.Sum(p => p.TotalFare);
            //Tender currentTender = UICurrentManager.Instance.CurrentTender;
            IhalematikProBL.Entity.Rule provisionalBond = RuleProvider.Instance.GetItems("Code", "ProvisionalBond").FirstOrDefault();
            IhalematikProBL.Entity.Rule completionBond = RuleProvider.Instance.GetItems("Code", "CompletionBond").FirstOrDefault();
            IhalematikProBL.Entity.Rule tradingStamps = RuleProvider.Instance.GetItems("Code", "TradingStamps").FirstOrDefault();

            double KDVTefkifat = 0;
            double carriage = currentTender.Carriage; //double.Parse(string.IsNullOrEmpty(txtCarriage.Text) ? "0" : txtCarriage.Text.Replace("TL", string.Empty));
            double accountingCosts = 0;
            if (currentTender.TenderType == TenderTypeEnum.DirectSupply)
            {
                accountingCosts = (this.TotalMarkupNonKDVPreview * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(completionBond.Value) / 100);
            }
            else
            {
                KDVTefkifat = this.TotalMarkupNonKDVPreview * 0.18 / 10 * 3;
                accountingCosts = (this.TotalMarkupNonKDVPreview * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(provisionalBond.Value) / 100) + (this.TotalMarkupNonKDVPreview * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(completionBond.Value) / 100) +
                    (this.TotalMarkupNonKDVPreview * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(tradingStamps.Value) / 100) + KDVTefkifat;

            }

            List<OtherExpenses> otherExpenses = OtherExpensesProvider.Instance.GetItems("TenderId", currentTender.Id);
            this.OtherCost = otherExpenses.Sum(p => p.Price);

            double otherCosts = this.OtherCost; //double.Parse(string.IsNullOrEmpty(txtOtherCoast.Text) ? "0" : txtOtherCoast.Text.Replace("TL", string.Empty));

            currentTender.Carriage = carriage;
            currentTender.AccountingCosts = accountingCosts;
            this.OtherTotalAmount = accountingCosts + otherCosts;
            double increaseAmount = (this.OtherTotalAmount / this.TotalMarkupNonKDVPreview);
            double totalMarkupZeroCarriage = DataSource.Where(p => p.CarriagePercent == 0).Sum(p => p.TotalFare);
            double otherCarriageZeroAmountPercent = DataSource.Sum(p => p.CarriagePercent);
            double increaseZeroCarriage = (carriage * (100 - otherCarriageZeroAmountPercent) / 100 / totalMarkupZeroCarriage);
            double increaseCarriageAmount = (carriage / increaseZeroCarriage);

            if (carriage == 0)
            {
                increaseCarriageAmount = 0;
            }

            foreach (MaterialListModel item in DataSource)
            {
                double increaseOtherFare = 0;
                increaseOtherFare = ((increaseAmount * item.TotalFare) / item.Quantity);
                if (item.CarriagePercent == 0)
                {

                    increaseOtherFare += ((increaseZeroCarriage * item.TotalFare) / item.Quantity);
                    item.UnitTotalFarePreview = (item.UnitTotalFare + increaseOtherFare);
                }
                else
                {
                    increaseOtherFare += (item.CarriagePercent * carriage / 100 / item.Quantity);
                    item.UnitTotalFarePreview = (item.UnitTotalFare + increaseOtherFare);
                }
            }
            LoadingManager.Instance.Hide();
            grdMaterialList.DataSource = null;
            grdMaterialList.DataSource = DataSource;
        }

        private void LoadAddedMaterialListGrid()
        {
            List<JobberMaterialList> items = UICurrentManager.Instance.CurrentJobberTender.MaterialList;
            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items.Select(p => p.MaterialList).ToList()).ToList();
            grdAddedJobberMaterialList.DataSource = dataSource;
        }

        private void repositoryTaseronTipi_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
        }
    }
}