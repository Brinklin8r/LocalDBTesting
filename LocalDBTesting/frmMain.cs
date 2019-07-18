using System;
using System.Windows.Forms;
using DataManipulation;

namespace LocalDBTesting {
    public partial class frmMain : Form {
        DBMaint dbm = new DBMaint();

        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public frmMain() {
            InitializeComponent();
            DisplayData();
        }
        //Insert Data  
        private void btn_Insert_Click(object sender, EventArgs e) {
            if (txt_Name.Text != "" && txt_State.Text != "") {
                dbm.InsertIntoDB(txt_Name.Text, txt_State.Text);
                DisplayData();
                ClearData();
            } else {
                MessageBox.Show("Please Provide Details!");
            }
        }
        //Display Data in DataGridView  
        private void DisplayData() {
            dataGridView1.DataSource = dbm.ReadFromDB();
        }
        //Clear Data  
        private void ClearData() {
            txt_Name.Text = "";
            txt_State.Text = "";
            ID = 0;
        }
        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_State.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        //Update Record  
        private void btn_Update_Click(object sender, EventArgs e) {
            if (txt_Name.Text != "" && txt_State.Text != "") {
                dbm.UpdateDB(ID, txt_Name.Text, txt_State.Text);
                DisplayData();
                ClearData();
            } else {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        //Delete Record  
        private void btn_Delete_Click(object sender, EventArgs e) {
            if (ID != 0) {
                dbm.DeleteFromDB(ID);
                DisplayData();
                ClearData();
            } else {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}
