using System;
using System.Windows.Forms;
using LocalDBTesting;

namespace HubSwitcher.UI {
    public partial class formMain : Form {
        public formMain() {
            InitializeComponent();
            tbSystem.Text = "Some Text Here";
        }

        private void btnConfig_Click(object sender, EventArgs e) {
            formDBUpdate frmDBUpdate = new formDBUpdate();
            frmDBUpdate.ShowDialog();
            tbSystem.Text = "testing";
        }

        private void btnLaunch_Click(object sender, EventArgs e) {
            frmMain frmOldMain = new frmMain();
            frmOldMain.ShowDialog();
            tbSystem.Text = "testing2";
        }
    }
}
