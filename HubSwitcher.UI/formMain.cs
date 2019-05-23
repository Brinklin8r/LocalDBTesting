using System;
using System.Windows.Forms;
using LocalDBTesting;
using HubSwitcher.Persistance;

namespace HubSwitcher.UI {
    public partial class formMain : Form {
        public formMain() {
            InitializeComponent();

            FileSystem FileInfo = new FileSystem();

            ConfigSettings ConfigInfo = new ConfigSettings();
            var bob = ConfigInfo.GetSettings();

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
