namespace HubSwitcher.UI {
    partial class formMain {
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
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbCapture = new System.Windows.Forms.RadioButton();
            this.rbCorrection = new System.Windows.Forms.RadioButton();
            this.lblSystem = new System.Windows.Forms.Label();
            this.tbSystem = new System.Windows.Forms.TextBox();
            this.tbURI = new System.Windows.Forms.TextBox();
            this.lblURI = new System.Windows.Forms.Label();
            this.tbUIN = new System.Windows.Forms.TextBox();
            this.lblUIN = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Checked = true;
            this.rbAdmin.Location = new System.Drawing.Point(13, 13);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(90, 17);
            this.rbAdmin.TabIndex = 0;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "IP Hub Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbCapture
            // 
            this.rbCapture.AutoSize = true;
            this.rbCapture.Enabled = false;
            this.rbCapture.Location = new System.Drawing.Point(13, 36);
            this.rbCapture.Name = "rbCapture";
            this.rbCapture.Size = new System.Drawing.Size(98, 17);
            this.rbCapture.TabIndex = 1;
            this.rbCapture.Text = "IP Hub Capture";
            this.rbCapture.UseVisualStyleBackColor = true;
            // 
            // rbCorrection
            // 
            this.rbCorrection.AutoSize = true;
            this.rbCorrection.Enabled = false;
            this.rbCorrection.Location = new System.Drawing.Point(13, 59);
            this.rbCorrection.Name = "rbCorrection";
            this.rbCorrection.Size = new System.Drawing.Size(109, 17);
            this.rbCorrection.TabIndex = 2;
            this.rbCorrection.Text = "IP Hub Correction";
            this.rbCorrection.UseVisualStyleBackColor = true;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Location = new System.Drawing.Point(187, 13);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(44, 13);
            this.lblSystem.TabIndex = 3;
            this.lblSystem.Text = "System:";
            // 
            // tbSystem
            // 
            this.tbSystem.Location = new System.Drawing.Point(237, 10);
            this.tbSystem.Name = "tbSystem";
            this.tbSystem.Size = new System.Drawing.Size(229, 20);
            this.tbSystem.TabIndex = 4;
            // 
            // tbURI
            // 
            this.tbURI.Location = new System.Drawing.Point(237, 33);
            this.tbURI.Name = "tbURI";
            this.tbURI.Size = new System.Drawing.Size(229, 20);
            this.tbURI.TabIndex = 6;
            // 
            // lblURI
            // 
            this.lblURI.AutoSize = true;
            this.lblURI.Location = new System.Drawing.Point(202, 36);
            this.lblURI.Name = "lblURI";
            this.lblURI.Size = new System.Drawing.Size(29, 13);
            this.lblURI.TabIndex = 5;
            this.lblURI.Text = "URI:";
            // 
            // tbUIN
            // 
            this.tbUIN.Location = new System.Drawing.Point(237, 56);
            this.tbUIN.Name = "tbUIN";
            this.tbUIN.Size = new System.Drawing.Size(229, 20);
            this.tbUIN.TabIndex = 8;
            // 
            // lblUIN
            // 
            this.lblUIN.AutoSize = true;
            this.lblUIN.Location = new System.Drawing.Point(202, 59);
            this.lblUIN.Name = "lblUIN";
            this.lblUIN.Size = new System.Drawing.Size(29, 13);
            this.lblUIN.TabIndex = 7;
            this.lblUIN.Text = "UIN:";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(237, 105);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(229, 41);
            this.btnLaunch.TabIndex = 9;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(13, 105);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(109, 40);
            this.btnConfig.TabIndex = 10;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 158);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.tbUIN);
            this.Controls.Add(this.lblUIN);
            this.Controls.Add(this.tbURI);
            this.Controls.Add(this.lblURI);
            this.Controls.Add(this.tbSystem);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.rbCorrection);
            this.Controls.Add(this.rbCapture);
            this.Controls.Add(this.rbAdmin);
            this.Name = "formMain";
            this.Text = "Hub Switcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbCapture;
        private System.Windows.Forms.RadioButton rbCorrection;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.TextBox tbSystem;
        private System.Windows.Forms.TextBox tbURI;
        private System.Windows.Forms.Label lblURI;
        private System.Windows.Forms.TextBox tbUIN;
        private System.Windows.Forms.Label lblUIN;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnConfig;
    }
}

