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

namespace IhalematikPro.Forms
{
    public partial class frm_Teklif_Adim3 : DevExpress.XtraEditors.XtraForm
    {
        public frm_Teklif_Adim3()
        {
            InitializeComponent();

            //GlobalVeriablesManager.MaterialListIsWorkship.ForEach(p => p.TenderEquipments = GlobalVeriablesManager.CurrentTender.Equipments);
            grdMaterialListIsWorkship.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PozOBFNumber";
            column.Name = "POZ/ÖBF";
            column.ReadOnly = true;
            grdMaterialListIsWorkship.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PozOBFDescription";
            column.Name = "AÇIKLAMA";
            column.ReadOnly = true;
            column.Width = 340;
            grdMaterialListIsWorkship.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Quantity";
            column.Name = "MİKTAR";
            column.ReadOnly = true;
            grdMaterialListIsWorkship.Columns.Add(column);


            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "KDVPercentage";
            column.Name = "KDV ORAN";
            column.ReadOnly = true;
            //column.CellTemplate
            grdMaterialListIsWorkship.Columns.Add(column);


            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "KDVAmount";
            column.Name = "KDV TUTAR";
            column.ReadOnly = true;
            grdMaterialListIsWorkship.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "WorkerMarkup";
            column.Name = "WorkerMarkup";
            column.HeaderText = "KAR %";
            column.ReadOnly = false;
            grdMaterialListIsWorkship.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "UnitTime";
            column.Name = "BIRIM SURE";
            column.ReadOnly = false;
            grdMaterialListIsWorkship.Columns.Add(column);

            column = new DataGridViewComboBoxColumn { DataSource = GetUnitTimes(), ValueMember = "Self", DisplayMember = "DisplayText" };

            column.DataPropertyName = "UnitTimeType";
            column.Name = "Zaman Tipi";
            column.ReadOnly = false;

            grdMaterialListIsWorkship.Columns.Add(column);


            if (GlobalVeriablesManager.CurrentTender.Equipments != null)
            {
                List<TenderEquipment> equipmentItems = GlobalVeriablesManager.CurrentTender.Equipments.OrderBy(p => !p.IsWorker).ToList();

                foreach (TenderEquipment item in equipmentItems)
                {
                    GridColumn unbColumn = new GridColumn();
                    column = new DataGridViewTextBoxColumn();

                    if (item.IsWorker)
                    {
                        //column.DataPropertyName = "item.Worker.Title.Name";
                        column.Name = item.Worker.Title.Name;
                        column.HeaderText = item.Worker.Title.Name;
                    }
                    else
                    {
                        //column = new DataGridViewTextBoxColumn();
                        column.Name = item.Vehicle.Title.Name;
                        column.HeaderText = item.Vehicle.Title.Name;
                    }
                    grdMaterialListIsWorkship.Columns.Add(column);
                }
            }
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "WorkerUnitPrice";
            column.Name = "ISCILIK(MALZEME) BIRIM FIYAT";
            column.ReadOnly = false;
            grdMaterialListIsWorkship.Columns.Add(column);

            grdMaterialListIsWorkship.CellValueChanged += GrdMaterialListIsWorkship_CellValueChanged;
        }

        private void GrdMaterialListIsWorkship_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string currentColumnName = grdMaterialListIsWorkship.Columns[e.ColumnIndex].Name;
            List<MaterialListModel> items = GlobalVeriablesManager.MaterialListIsWorkship;
            MaterialListModel materialListModel = GlobalVeriablesManager.MaterialListIsWorkship.ToArray()[e.RowIndex];
            if (currentColumnName.Equals("WorkerMarkup"))
            {
                double value = Convert.ToDouble(grdMaterialListIsWorkship["WorkerMarkup", grdMaterialListIsWorkship.CurrentRow.Index].Value);
                materialListModel.WorkerMarkup = value;
            }
            else if (currentColumnName.Equals("UnitTime"))
            {

            }
            else if (materialListModel.TenderEquipments != null)
            {
                foreach (TenderEquipment equipmentItem in materialListModel.TenderEquipments)
                {
                    string columnName = string.Empty;
                    if (equipmentItem.IsWorker)
                    {
                        columnName = equipmentItem.Worker.Title.Name;
                    }
                    else
                    {
                        columnName = equipmentItem.Vehicle.Title.Name;
                    }
                    if (columnName.Equals(currentColumnName))
                    {
                        int value = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(grdMaterialListIsWorkship[columnName, grdMaterialListIsWorkship.CurrentRow.Index].Value);
                        equipmentItem.Quantity = value;
                    }
                }
            }
        }
        private List<UnitTimeTypesModel> GetUnitTimes()
        {
            List<UnitTimeTypesModel> models = new List<UnitTimeTypesModel>();

            foreach (UnitTimeTypesEnum unitTimeType in Enum.GetValues(typeof(UnitTimeTypesEnum)))
            {
                UnitTimeTypesModel model = new UnitTimeTypesModel();
                model.DisplayText = this.GetUnitTimeTypesDisplayText(unitTimeType);
                model.Id = (int)unitTimeType;
                models.Add(model);
            }

            return models;
        }

        private string GetUnitTimeTypesDisplayText(UnitTimeTypesEnum UnitTimeType)
        {
            string displayText = string.Empty;
            switch (UnitTimeType)
            {
                case UnitTimeTypesEnum.Minute:
                    displayText = "Dakika";
                    break;
                case UnitTimeTypesEnum.Hour:
                    displayText = "Saat";
                    break;
                case UnitTimeTypesEnum.Day:
                    displayText = "Gün";
                    break;
                case UnitTimeTypesEnum.Week:
                    displayText = "Hafta";
                    break;
                case UnitTimeTypesEnum.Month:
                    displayText = "Ay";
                    break;
                case UnitTimeTypesEnum.Year:
                    displayText = "Yıl";
                    break;
                default:
                    break;
            }

            return displayText;
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Teklif_Adim3_Load(object sender, EventArgs e)
        {
            lblTenderDescription.Text = GlobalVeriablesManager.CurrentTender.Description;
            lblTenderNumber.Text = GlobalVeriablesManager.CurrentTender.DisplayNumber;

            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            GlobalVeriablesManager.MaterialListIsWorkship = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);

            if (GlobalVeriablesManager.CurrentTender.Equipments != null)
            {
                List<TenderEquipment> equipmentItems = GlobalVeriablesManager.CurrentTender.Equipments.OrderBy(p => !p.IsWorker).ToList();
                List<TenderEquipment> workers = equipmentItems.Where(p => p.IsWorker).ToList();
                List<TenderEquipment> vehicles = equipmentItems.Where(p => !p.IsWorker).ToList();
                int i = 8;
                //grdMaterialListIsWorkship2.BeginUpdate();
                foreach (TenderEquipment item in equipmentItems)
                {

                    GridColumn unbColumn = new GridColumn();
                    if (item.IsWorker)
                    {
                        //  GridColumn unbColumn = new GridColumn();// grdMaterialListIsWorkship2.Columns.Insert();
                        unbColumn.Caption = item.Worker.Title.Name;
                        unbColumn.Name = item.Worker.Title.Name;
                        unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
                        unbColumn.OptionsColumn.AllowEdit = true;
                        unbColumn.VisibleIndex = i;
                    }
                    else
                    {// grdMaterialListIsWorkship2.Columns.Add();
                        unbColumn.Name = item.Vehicle.Title.Name;
                        unbColumn.Caption = item.Vehicle.Title.Name;
                        unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
                        unbColumn.OptionsColumn.AllowEdit = true;
                        unbColumn.VisibleIndex = i;
                    }

                    // grdMaterialListIsWorkship2.Columns.Add(unbColumn);

                    i++;
                }

                //grdMaterialListIsWorkship2.EndUpdate();
            }

            //bindingSource1.DataSource = GlobalVeriablesManager.MaterialListIsWorkship;
            grdMaterialListIsWorkship.DataSource = GlobalVeriablesManager.MaterialListIsWorkship;//bindingSource1;
            double baseAmount = 0;
            this.CalculateInnerValue(ref baseAmount);

        }


        public static Type BuildDynamicTypeWithProperties()
        {
            AppDomain myDomain = Thread.GetDomain();
            AssemblyName myAsmName = new AssemblyName();
            myAsmName.Name = typeof(Program).Assembly.GetName().Name;

            // To generate a persistable assembly, specify AssemblyBuilderAccess.RunAndSave.
            AssemblyBuilder myAsmBuilder = myDomain.DefineDynamicAssembly(myAsmName,
                                                            AssemblyBuilderAccess.RunAndSave);
            // Generate a persistable single-module assembly.
            ModuleBuilder myModBuilder =
                myAsmBuilder.DefineDynamicModule(myAsmName.Name, myAsmName.Name + ".dll");

            TypeBuilder myTypeBuilder = myModBuilder.DefineType("MaterialListModel",
                                                            TypeAttributes.Public);

            FieldBuilder customerNameBldr = myTypeBuilder.DefineField("MaterialListModel",
                                                            typeof(string),
                                                            FieldAttributes.Private);

            // The last argument of DefineProperty is null, because the
            // property has no parameters. (If you don't specify null, you must
            // specify an array of Type objects. For a parameterless property,
            // use an array with no elements: new Type[] {})
            PropertyBuilder custNamePropBldr = myTypeBuilder.DefineProperty("CustomerName",
                                                             System.Reflection.PropertyAttributes.HasDefault,
                                                             typeof(string),
                                                             null);

            // The property set and property get methods require a special
            // set of attributes.
            MethodAttributes getSetAttr =
                MethodAttributes.Public | MethodAttributes.SpecialName |
                    MethodAttributes.HideBySig;

            // Define the "get" accessor method for CustomerName.
            MethodBuilder custNameGetPropMthdBldr =
                myTypeBuilder.DefineMethod("get_CustomerName",
                                           getSetAttr,
                                           typeof(string),
                                           Type.EmptyTypes);

            ILGenerator custNameGetIL = custNameGetPropMthdBldr.GetILGenerator();

            custNameGetIL.Emit(OpCodes.Ldarg_0);
            custNameGetIL.Emit(OpCodes.Ldfld, customerNameBldr);
            custNameGetIL.Emit(OpCodes.Ret);

            // Define the "set" accessor method for CustomerName.
            MethodBuilder custNameSetPropMthdBldr =
                myTypeBuilder.DefineMethod("set_CustomerName",
                                           getSetAttr,
                                           null,
                                           new Type[] { typeof(string) });

            ILGenerator custNameSetIL = custNameSetPropMthdBldr.GetILGenerator();

            custNameSetIL.Emit(OpCodes.Ldarg_0);
            custNameSetIL.Emit(OpCodes.Ldarg_1);
            custNameSetIL.Emit(OpCodes.Stfld, customerNameBldr);
            custNameSetIL.Emit(OpCodes.Ret);

            // Last, we must map the two methods created above to our PropertyBuilder to 
            // their corresponding behaviors, "get" and "set" respectively. 
            custNamePropBldr.SetGetMethod(custNameGetPropMthdBldr);
            custNamePropBldr.SetSetMethod(custNameSetPropMthdBldr);


            Type retval = myTypeBuilder.CreateType();

            // Save the assembly so it can be examined with Ildasm.exe,
            // or referenced by a test program.
            myAsmBuilder.Save(myAsmName.Name + ".dll");
            return retval;
        }


        private void CalculateInnerValue(ref double BaseAmount)
        {
            if (GlobalVeriablesManager.MaterialListIsWorkship != null && GlobalVeriablesManager.MaterialListIsWorkship.Count > 0)
            {
                BaseAmount = GlobalVeriablesManager.MaterialListIsWorkship.Sum(p => p.MarkupUnitPrice * p.Quantity);
                double baseKDVAmount = GlobalVeriablesManager.MaterialListIsWorkship.Sum(p => p.KDVAmount);
                txtBaseAmount.Text = string.Format("{0:C2}", BaseAmount);
                txtBaseKDVAmount.Text = string.Format("{0:C2}", baseKDVAmount);
                txtTotalAmount.Text = string.Format("{0:C2}", Math.Round((baseKDVAmount + BaseAmount), 2));
            }
        }

        private void btnTumuneUygulaIscilik_Click(object sender, EventArgs e)
        {
            double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtWorkerMarkup.Text);
            GlobalVeriablesManager.MaterialListIsWorkship.ForEach(p => p.WorkerMarkup = markup);
            grdMaterialListIsWorkship.DataSource = GlobalVeriablesManager.MaterialListIsWorkship;
            grdMaterialListIsWorkship.Refresh();
        }

        private void btnTumuneUygulaMalzeme_Click(object sender, EventArgs e)
        {
            //double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtMaterialMarkup.Text);
            //GlobalVeriablesManager.MaterialListIsWorkship.ForEach(p => p.MaterialMarkup = markup);
            //grdMaterialListIsWorkship.DataSource = GlobalVeriablesManager.MaterialListIsWorkship;
            ////grdMaterialListIsWorkship.RefreshDataSource();
        }
        public double currentCellValue = 0;

        public bool IsChanged = false;

        public string ColumnName = string.Empty;
        private void grdMaterialListIsWorkship2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (this.IsChanged)
            {
                return;
            }
            //TenderMaterialEquipment entity = new TenderMaterialEquipment();

            //MaterialListModel[] items = GlobalVeriablesManager.MaterialListIsWorkship.ToArray();
            //int rowIndex = e.RowHandle;
            //MaterialListModel materialListModel = items[rowIndex];

            //List<TenderEquipment> equipmentItems = GlobalVeriablesManager.CurrentTender.Equipments;
            //TenderEquipment equipmentItem = equipmentItems.Where(p => p.IsWorker && p.Worker.Title.Name == e.Column.FieldName).FirstOrDefault();

            //if (equipmentItem == null)
            //{
            //    equipmentItem = equipmentItems.Where(p => !p.IsWorker && p.Vehicle.Title.Name == e.Column.FieldName).FirstOrDefault();
            //}
            //else
            //{
            //    entity.IsWorker = true;
            //}

            //entity.TenderId = GlobalVeriablesManager.CurrentTender.Id;
            //entity.EquipmentId = equipmentItem.Id;
            //entity.MaterialId = materialListModel.Id.Value;
            //entity.Quantity = this.currentCellValue;

            // DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            this.IsChanged = true;
            this.ColumnName = e.Column.FieldName;
            //grdMaterialListIsWorkship2.SetRowCellValue(grdMaterialListIsWorkship2.FocusedRowHandle, grdMaterialListIsWorkship2.Columns[e.Column.Name], currentCellValue);

            //grdMaterialListIsWorkship2.RefreshRowCell(view.FocusedRowHandle, view.Columns[e.Column.Name]);
            // this.currentCellValue = 0;
        }

        private void grdMaterialListIsWorkship2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            this.currentCellValue = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
            this.IsChanged = false;
        }

        private void grdMaterialListIsWorkship2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            //view.SetRowCellValue(view.FocusedRowHandle, view.Columns[this.ColumnName], this.currentCellValue);
        }

        Dictionary<int, string> parameters = new Dictionary<int, string>();
        private void grdMaterialListIsWorkship2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

            //e.Value = 10;
            //this.ColumnName = e.Column.FieldName;
            //grdMaterialListIsWorkship2.SetRowCellValue(grdMaterialListIsWorkship2.FocusedRowHandle, grdMaterialListIsWorkship2.Columns[this.ColumnName], currentCellValue);
        }

        private void grdMaterialListIsWorkship2_RowUpdated_1(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTumuneUygulaMalzeme_Click_1(object sender, EventArgs e)
        {

        }
    }
}