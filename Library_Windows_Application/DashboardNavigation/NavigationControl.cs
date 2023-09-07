using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Windows_Application.Dashboard_Controls
{
    public class NavigationControl
    {
        List<UserControl> _userControlList = new List<UserControl>();
        Panel _panel;

        public NavigationControl(List<UserControl> userControlList,Panel panel)
        {
            _panel = panel;
            _userControlList = userControlList;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for(int i=0; i<_userControlList.Count; i++)
            {
                _userControlList[i].Dock = DockStyle.Fill;
                _panel.Controls.Add(_userControlList[i]);
            }
        }

        public void Display(int index)
        {
            _userControlList[index].BringToFront();
        }
    }
}
