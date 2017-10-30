using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IhalematikProUI.CustomComponent
{
    public class CustomDataGridView : DataGridView
    {
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }

            set
            {
                base.BackColor = value;
            }
        }
    }
}
