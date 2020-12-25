using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DepartmentalStoreApp
{
    public class HelperClass
    {
        public static void makeFieldsBlank(Control ctrl)
        {
            foreach (Control a in ctrl.Controls)
            {
                if (a is TextBox)
                    a.Text = "";
                if (a is RadioButton)
                    a.Text = "";
                if (a is ComboBox)
                    a.Text = null;
                if (a is DateTimePicker)
                    a.Text = "";
                if (a is CheckBox)
                    a.Text = "";
            }
        }
    }
}
