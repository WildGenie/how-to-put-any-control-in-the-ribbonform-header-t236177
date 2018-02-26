using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            this.AllowFormGlass = toggleSwitch1.IsOn ? DefaultBoolean.True : DefaultBoolean.False;
        }

        private Control GetHeaderControl()
        {
            if (toggleSwitch2.IsOn)
                return simpleButton1;
            else 
                return pictureBox1;
        }


        private void toggleSwitch2_Toggled(object sender, EventArgs e)
        {
            userControlReplaceHelper1.HeaderControl = GetHeaderControl();
        }
    }
}
