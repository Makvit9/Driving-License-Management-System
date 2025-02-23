using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.Applications
{
    public partial class ShowApplicationInfo: Form
    {
        public ShowApplicationInfo()
        {
            InitializeComponent();
        }

        public ShowApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            localApplicationInfo1.LoadApplicationInfo(LocalDrivingLicenseApplicationID);
        }

    }
}
