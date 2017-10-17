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

namespace IhalematikPro.Forms
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //button3_Click(new object(), EventArgs.Empty);//bu da iş görür
            this.InvokeOnClick(button2, EventArgs.Empty);//bu daha iyi iş görür
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fire");
        }

    }
}