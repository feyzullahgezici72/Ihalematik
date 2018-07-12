namespace IhalematikProUI.Forms.Genel
{
    partial class frm_IsTakvimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_IsTakvimi));
            DevExpress.XtraScheduler.Printing.DailyPrintStyle dailyPrintStyle1 = new DevExpress.XtraScheduler.Printing.DailyPrintStyle();
            DevExpress.XtraScheduler.Printing.WeeklyPrintStyle weeklyPrintStyle1 = new DevExpress.XtraScheduler.Printing.WeeklyPrintStyle();
            DevExpress.XtraScheduler.Printing.MonthlyPrintStyle monthlyPrintStyle1 = new DevExpress.XtraScheduler.Printing.MonthlyPrintStyle();
            DevExpress.XtraScheduler.Printing.TriFoldPrintStyle triFoldPrintStyle1 = new DevExpress.XtraScheduler.Printing.TriFoldPrintStyle();
            DevExpress.XtraScheduler.Printing.CalendarDetailsPrintStyle calendarDetailsPrintStyle1 = new DevExpress.XtraScheduler.Printing.CalendarDetailsPrintStyle();
            DevExpress.XtraScheduler.Printing.MemoPrintStyle memoPrintStyle1 = new DevExpress.XtraScheduler.Printing.MemoPrintStyle();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateNavigator1.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateNavigator1.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("dateNavigator1.AppearanceHeader.Image")));
            this.dateNavigator1.AppearanceHeader.Options.UseFont = true;
            this.dateNavigator1.AppearanceHeader.Options.UseForeColor = true;
            this.dateNavigator1.AppearanceHeader.Options.UseImage = true;
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateNavigator1.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.Default;
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(994, 0);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.SchedulerControl = this.schedulerControl1;
            this.dateNavigator1.Size = new System.Drawing.Size(250, 648);
            this.dateNavigator1.TabIndex = 16;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            dailyPrintStyle1.ResourceOptions.ResourcesKind = DevExpress.XtraScheduler.Printing.ResourcesKind.OnScreen;
            this.schedulerControl1.PrintStyles.Add(dailyPrintStyle1);
            this.schedulerControl1.PrintStyles.Add(weeklyPrintStyle1);
            this.schedulerControl1.PrintStyles.Add(monthlyPrintStyle1);
            this.schedulerControl1.PrintStyles.Add(triFoldPrintStyle1);
            this.schedulerControl1.PrintStyles.Add(calendarDetailsPrintStyle1);
            this.schedulerControl1.PrintStyles.Add(memoPrintStyle1);
            this.schedulerControl1.Size = new System.Drawing.Size(994, 648);
            this.schedulerControl1.Start = new System.DateTime(2018, 5, 21, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 17;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            // 
            // frm_IsTakvimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 648);
            this.Controls.Add(this.schedulerControl1);
            this.Controls.Add(this.dateNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_IsTakvimi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETKİNLİK TAKVİMİ";
            this.Load += new System.EventHandler(this.frm_IsTakvimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
    }
}