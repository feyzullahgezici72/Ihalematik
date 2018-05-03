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
using System.Xml;
using IhalematikProUI.Forms;
using IhalematikProBL.Manager;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikPro.Manager;

namespace IhalematikPro.Forms
{
    public partial class frm_DovizKurlari : DevExpress.XtraEditors.XtraForm
    {
        public frm_DovizKurlari()
        {
            InitializeComponent();
        }

        private void frm_DovizKurlari_Load(object sender, EventArgs e)
        {

            try
            {
                txtDolar.Text = CurrentManager.Instance.CurrentExchangeRateUSD.UnitPrice.ToString();
                txtEuro.Text = CurrentManager.Instance.CurrentExchangeRateEUR.UnitPrice.ToString();
            }
            catch (Exception ex)
            {
                LoggingManager.Instance.SaveErrorLog(ex);
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGizliKapat_Click(object sender, EventArgs e)
        {
             this.Close();
        }
      

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
       

        private void btnOnlineAl_Click(object sender, EventArgs e)
        {
            try
            {
                txtDolar.Text = CurrentManager.Instance.GetRate("USD").ToString();
                txtEuro.Text = CurrentManager.Instance.GetRate("EUR").ToString();
            }
            catch (Exception ex)
            {
                LoggingManager.Instance.SaveErrorLog(ex);
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "İnternet Bağlantınız olmadığından\n Döviz kurları alınamadı...";
                mf.ShowDialog();
            }
        
        }

        private void btnKurKaydet_Click(object sender, EventArgs e)
        {
            double usd = double.Parse(txtDolar.Text);
            double euro = double.Parse(txtEuro.Text);

            ExchangeRate exchangeRateUSD = new ExchangeRate();
            exchangeRateUSD.CurrencyType = IhalematikProBL.Enum.CurrencyTypesEnum.USD;
            exchangeRateUSD.UnitPrice = usd;
            ExchangeRateProvider.Instance.Save(exchangeRateUSD);


            ExchangeRate exchangeRateEURO = new ExchangeRate();
            exchangeRateEURO.CurrencyType = IhalematikProBL.Enum.CurrencyTypesEnum.EUR;
            exchangeRateEURO.UnitPrice = euro;
            ExchangeRateProvider.Instance.Save(exchangeRateEURO);
        }
    }
}