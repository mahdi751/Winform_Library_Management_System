using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Windows_Application.MembershipDisplays
{
    public partial class PlanBactivatedControl : UserControl
    {
        public PlanBactivatedControl()
        {
            InitializeComponent();
        }

        public Button RenewB => RenewPlanB_Btn;
        public Button UpgradeToA => UpgradeToPlanA_Btn;
        public Button UpgradeToC => UpgradeToPlanC_Btn;
        public Label ErrorDate => DateError;
    }
}
