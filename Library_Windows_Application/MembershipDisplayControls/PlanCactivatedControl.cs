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
    public partial class PlanCactivatedControl : UserControl
    {
        public PlanCactivatedControl()
        {
            InitializeComponent();
        }

        public Button RenewC => RenewPlanC_Btn;
        public Button UpgradeToA => UpgradeToPlanA_Btn;
        public Button UpgradeToB => UpgradeToPlanB_Btn;
        public Label ErrorDate => DateError;
    }
}
