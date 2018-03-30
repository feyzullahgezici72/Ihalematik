using IhalematikProUI.Forms;
using IhalematikProUI.Forms.Base;
using IhalematikProUI.Forms.Genel;
using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IhalematikProUI.Manager
{
    public class LoadingManager : SingletonBase<LoadingManager>
    {
        public IhalematikBaseForm _MainForm = null;
        public frm_wait frm_wait;
        public void Show(IhalematikBaseForm MainForm)
        {
            this._MainForm = MainForm;
            this.frm_wait = new frm_wait();
            ShowProgress();
        }
        private void StartProgress(String strStatusText)
        {
            frm_wait = new frm_wait();
            //frm_wait.strStatus = strStatusText;
            ShowProgress();
        }
        private void CloseProgress()
        {
            Thread.Sleep(200);
            this.frm_wait.Invoke(new Action(this.frm_wait.Close));
        }
        private void ShowProgress()
        {
            try
            {
                if (this._MainForm.InvokeRequired)
                {
                    try
                    {
                        this.frm_wait.ShowDialog();
                    }
                    catch (Exception ex) { }
                }
                else
                {
                    Thread th = new Thread(ShowProgress);
                    th.IsBackground = false;
                    th.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Hide()
        {
            this.CloseProgress();
        }
    }
}
