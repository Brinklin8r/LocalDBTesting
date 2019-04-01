namespace HubSwitcher.UI {
    partial class formDBUpdate {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblSystem = new System.Windows.Forms.Label();
            this.tbSystem = new System.Windows.Forms.TextBox();
            this.tbURI = new System.Windows.Forms.TextBox();
            this.lblURI = new System.Windows.Forms.Label();
            this.tbUIN = new System.Windows.Forms.TextBox();
            this.lblUIN = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvDataBase = new System.Windows.Forms.DataGridView();
            this.lblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Location = new System.Drawing.Point(13, 13);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(75, 13);
            this.lblSystem.TabIndex = 0;
            this.lblSystem.Text = "System Name:";
            // 
            // tbSystem
            // 
            this.tbSystem.Location = new System.Drawing.Point(94, 10);
            this.tbSystem.Name = "tbSystem";
            this.tbSystem.Size = new System.Drawing.Size(256, 20);
            this.tbSystem.TabIndex = 1;
            // 
            // tbURI
            // 
            this.tbURI.Location = new System.Drawing.Point(94, 36);
            this.tbURI.Name = "tbURI";
            this.tbURI.Size = new System.Drawing.Size(256, 20);
            this.tbURI.TabIndex = 3;
            // 
            // lblURI
            // 
            this.lblURI.AutoSize = true;
            this.lblURI.Location = new System.Drawing.Point(22, 39);
            this.lblURI.Name = "lblURI";
            this.lblURI.Size = new System.Drawing.Size(66, 13);
            this.lblURI.TabIndex = 2;
            this.lblURI.Text = "System URI:";
            // 
            // tbUIN
            // 
            this.tbUIN.Location = new System.Drawing.Point(94, 62);
            this.tbUIN.Name = "tbUIN";
            this.tbUIN.Size = new System.Drawing.Size(256, 20);
            this.tbUIN.TabIndex = 5;
            // 
            // lblUIN
            // 
            this.lblUIN.AutoSize = true;
            this.lblUIN.Location = new System.Drawing.Point(22, 65);
            this.lblUIN.Name = "lblUIN";
            this.lblUIN.Size = new System.Drawing.Size(66, 13);
            this.lblUIN.TabIndex = 4;
            this.lblUIN.Text = "System UIN:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(18, 103);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(105, 44);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(129, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 44);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(240, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 44);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvDataBase
            // 
            this.dgvDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBase.Location = new System.Drawing.Point(16, 154);
            this.dgvDataBase.Name = "dgvDataBase";
            this.dgvDataBase.Size = new System.Drawing.Size(378, 272);
            this.dgvDataBase.TabIndex = 9;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(13, 433);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 13);
            this.lblResults.TabIndex = 10;
            // 
            // formDBUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.dgvDataBase);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbUIN);
            this.Controls.Add(this.lblUIN);
            this.Controls.Add(this.tbURI);
            this.Controls.Add(this.lblURI);
            this.Controls.Add(this.tbSystem);
            this.Controls.Add(this.lblSystem);
            this.Name = "formDBUpdate";
            this.Text = "Hub Switcher - DB update";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.TextBox tbSystem;
        private System.Windows.Forms.TextBox tbURI;
        private System.Windows.Forms.Label lblURI;
        private System.Windows.Forms.TextBox tbUIN;
        private System.Windows.Forms.Label lblUIN;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvDataBase;
        private System.Windows.Forms.Label lblResults;
    }
}