using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFerroVelho.FormHelpers
{
    class FormCleaner
    {
        public static void ClearAllForm(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if(item.HasChildren)
                {
                    ClearAllForm(item);
                }
                if(item is TextBoxBase)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = 0;
                }
            }


        }
    }
}
