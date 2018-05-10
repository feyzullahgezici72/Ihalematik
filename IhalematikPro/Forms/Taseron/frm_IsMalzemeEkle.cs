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

namespace IhalematikProUI.Forms.Taseron
{
    public partial class frm_IsMalzemeEkle : DevExpress.XtraEditors.XtraForm
    {
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
            grdMaterialList.DataSource = null;
            grdMaterialList.DataSource = dataSource;
        }

        private void LoadAddedMaterialListGrid()
        {
            List<JobberMaterialList> items = UICurrentManager.Instance.CurrentJobberTender.MaterialList;
            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items.Select(p => p.MaterialList).ToList()).ToList();
            grdAddedJobberMaterialList.DataSource = dataSource;
        }
    }
}