namespace SetMACAdrress
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxAdapters = new System.Windows.Forms.ComboBox();
            this.labelSelectAdapter = new System.Windows.Forms.Label();
            this.labelCurrentMac = new System.Windows.Forms.Label();
            this.textBoxNewMac = new System.Windows.Forms.TextBox();
            this.labelNewMac = new System.Windows.Forms.Label();
            this.btnChangeMac = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ComboBox for selecting adapters
            this.comboBoxAdapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdapters.FormattingEnabled = true;
            this.comboBoxAdapters.Location = new System.Drawing.Point(30, 40);
            this.comboBoxAdapters.Name = "comboBoxAdapters";
            this.comboBoxAdapters.Size = new System.Drawing.Size(240, 24);
            this.comboBoxAdapters.TabIndex = 0;
            this.comboBoxAdapters.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdapters_SelectedIndexChanged);

            // Label for "Select Adapter"
            this.labelSelectAdapter.AutoSize = true;
            this.labelSelectAdapter.Location = new System.Drawing.Point(30, 20);
            this.labelSelectAdapter.Name = "labelSelectAdapter";
            this.labelSelectAdapter.Size = new System.Drawing.Size(109, 17);
            this.labelSelectAdapter.TabIndex = 1;
            this.labelSelectAdapter.Text = "Select Adapter:";

            // Label to display the current MAC address
            this.labelCurrentMac.AutoSize = true;
            this.labelCurrentMac.Location = new System.Drawing.Point(30, 80);
            this.labelCurrentMac.Name = "labelCurrentMac";
            this.labelCurrentMac.Size = new System.Drawing.Size(99, 17);
            this.labelCurrentMac.TabIndex = 2;
            this.labelCurrentMac.Text = "Current MAC: ";

            // TextBox to input the new MAC address
            this.textBoxNewMac.Location = new System.Drawing.Point(30, 140);
            this.textBoxNewMac.Name = "textBoxNewMac";
            this.textBoxNewMac.Size = new System.Drawing.Size(240, 22);
            this.textBoxNewMac.TabIndex = 3;

            // Label for "New MAC Address"
            this.labelNewMac.AutoSize = true;
            this.labelNewMac.Location = new System.Drawing.Point(30, 120);
            this.labelNewMac.Name = "labelNewMac";
            this.labelNewMac.Size = new System.Drawing.Size(121, 17);
            this.labelNewMac.TabIndex = 4;
            this.labelNewMac.Text = "New MAC Address:";

            // Button to trigger MAC change
            this.btnChangeMac.Location = new System.Drawing.Point(180, 180);
            this.btnChangeMac.Name = "btnChangeMac";
            this.btnChangeMac.Size = new System.Drawing.Size(90, 30);
            this.btnChangeMac.TabIndex = 5;
            this.btnChangeMac.Text = "Change MAC";
            this.btnChangeMac.UseVisualStyleBackColor = true;
            this.btnChangeMac.Click += new System.EventHandler(this.btnChangeMac_Click);

            // Form settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.btnChangeMac);
            this.Controls.Add(this.labelNewMac);
            this.Controls.Add(this.textBoxNewMac);
            this.Controls.Add(this.labelCurrentMac);
            this.Controls.Add(this.labelSelectAdapter);
            this.Controls.Add(this.comboBoxAdapters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MacChangerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAC Address Changer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Fields for the controls
        private System.Windows.Forms.ComboBox comboBoxAdapters;
        private System.Windows.Forms.Label labelSelectAdapter;
        private System.Windows.Forms.Label labelCurrentMac;
        private System.Windows.Forms.TextBox textBoxNewMac;
        private System.Windows.Forms.Label labelNewMac;
        private System.Windows.Forms.Button btnChangeMac;
        #endregion
    }
}