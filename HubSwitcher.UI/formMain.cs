using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubSwitcher.UI {
    public partial class formMain : Form {
        public formMain() {
            InitializeComponent();
        }

        private void BtnConfig_Click(object sender, EventArgs e) {
            formDBUpdate frmDBUpdate = new formDBUpdate();
            frmDBUpdate.ShowDialog();
        }
    }
}
