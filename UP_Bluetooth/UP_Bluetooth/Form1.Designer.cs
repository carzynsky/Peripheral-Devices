namespace UP_Bluetooth
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxAvailableDevices = new System.Windows.Forms.ComboBox();
            this.buttonFindDevices = new System.Windows.Forms.Button();
            this.textBoxDeviceName = new System.Windows.Forms.TextBox();
            this.textBoxdeviceAuthenticated = new System.Windows.Forms.TextBox();
            this.textBoxDeviceConnected = new System.Windows.Forms.TextBox();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonPair = new System.Windows.Forms.Button();
            this.labelDeviceAddressTitle = new System.Windows.Forms.Label();
            this.textBoxDeviceAddress = new System.Windows.Forms.TextBox();
            this.labelDetectedDevices = new System.Windows.Forms.Label();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAvailableDevices
            // 
            this.comboBoxAvailableDevices.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxAvailableDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxAvailableDevices.FormattingEnabled = true;
            this.comboBoxAvailableDevices.ItemHeight = 16;
            this.comboBoxAvailableDevices.Location = new System.Drawing.Point(490, 113);
            this.comboBoxAvailableDevices.Name = "comboBoxAvailableDevices";
            this.comboBoxAvailableDevices.Size = new System.Drawing.Size(271, 24);
            this.comboBoxAvailableDevices.TabIndex = 0;
            this.comboBoxAvailableDevices.SelectedIndexChanged += new System.EventHandler(this.comboBoxAvailableDevices_SelectedIndexChanged);
            // 
            // buttonFindDevices
            // 
            this.buttonFindDevices.BackColor = System.Drawing.Color.Transparent;
            this.buttonFindDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindDevices.ForeColor = System.Drawing.Color.SlateGray;
            this.buttonFindDevices.Location = new System.Drawing.Point(627, 400);
            this.buttonFindDevices.Name = "buttonFindDevices";
            this.buttonFindDevices.Size = new System.Drawing.Size(134, 40);
            this.buttonFindDevices.TabIndex = 1;
            this.buttonFindDevices.Text = "Szukaj urządzeń";
            this.buttonFindDevices.UseVisualStyleBackColor = false;
            this.buttonFindDevices.Click += new System.EventHandler(this.buttonFindDevices_Click);
            // 
            // textBoxDeviceName
            // 
            this.textBoxDeviceName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDeviceName.Location = new System.Drawing.Point(490, 184);
            this.textBoxDeviceName.Name = "textBoxDeviceName";
            this.textBoxDeviceName.Size = new System.Drawing.Size(246, 22);
            this.textBoxDeviceName.TabIndex = 2;
            // 
            // textBoxdeviceAuthenticated
            // 
            this.textBoxdeviceAuthenticated.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxdeviceAuthenticated.Location = new System.Drawing.Point(490, 292);
            this.textBoxdeviceAuthenticated.Name = "textBoxdeviceAuthenticated";
            this.textBoxdeviceAuthenticated.Size = new System.Drawing.Size(100, 22);
            this.textBoxdeviceAuthenticated.TabIndex = 3;
            // 
            // textBoxDeviceConnected
            // 
            this.textBoxDeviceConnected.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDeviceConnected.Location = new System.Drawing.Point(490, 340);
            this.textBoxDeviceConnected.Name = "textBoxDeviceConnected";
            this.textBoxDeviceConnected.Size = new System.Drawing.Size(97, 22);
            this.textBoxDeviceConnected.TabIndex = 4;
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.BackColor = System.Drawing.Color.Transparent;
            this.labelDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDeviceName.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelDeviceName.Location = new System.Drawing.Point(295, 184);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(152, 20);
            this.labelDeviceName.TabIndex = 5;
            this.labelDeviceName.Text = "Nazwa urządzenia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(330, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Autoryzowany:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(349, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Enabled = false;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.SlateGray;
            this.buttonSearch.Location = new System.Drawing.Point(519, 400);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(102, 40);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Szukaj plik";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Transparent;
            this.buttonSend.Enabled = false;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.ForeColor = System.Drawing.Color.SlateGray;
            this.buttonSend.Location = new System.Drawing.Point(418, 400);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(95, 40);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Wyślj plik";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonPair
            // 
            this.buttonPair.BackColor = System.Drawing.Color.Transparent;
            this.buttonPair.Enabled = false;
            this.buttonPair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPair.ForeColor = System.Drawing.Color.SlateGray;
            this.buttonPair.Location = new System.Drawing.Point(322, 400);
            this.buttonPair.Name = "buttonPair";
            this.buttonPair.Size = new System.Drawing.Size(90, 40);
            this.buttonPair.TabIndex = 10;
            this.buttonPair.Text = "Paruj";
            this.buttonPair.UseVisualStyleBackColor = false;
            this.buttonPair.Click += new System.EventHandler(this.buttonPair_Click);
            // 
            // labelDeviceAddressTitle
            // 
            this.labelDeviceAddressTitle.AutoSize = true;
            this.labelDeviceAddressTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelDeviceAddressTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDeviceAddressTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelDeviceAddressTitle.Location = new System.Drawing.Point(296, 233);
            this.labelDeviceAddressTitle.Name = "labelDeviceAddressTitle";
            this.labelDeviceAddressTitle.Size = new System.Drawing.Size(163, 18);
            this.labelDeviceAddressTitle.TabIndex = 12;
            this.labelDeviceAddressTitle.Text = "Adres MAC urządzenia:";
            // 
            // textBoxDeviceAddress
            // 
            this.textBoxDeviceAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDeviceAddress.Location = new System.Drawing.Point(490, 233);
            this.textBoxDeviceAddress.Name = "textBoxDeviceAddress";
            this.textBoxDeviceAddress.Size = new System.Drawing.Size(246, 22);
            this.textBoxDeviceAddress.TabIndex = 11;
            // 
            // labelDetectedDevices
            // 
            this.labelDetectedDevices.AutoSize = true;
            this.labelDetectedDevices.BackColor = System.Drawing.Color.Transparent;
            this.labelDetectedDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDetectedDevices.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelDetectedDevices.Location = new System.Drawing.Point(240, 108);
            this.labelDetectedDevices.Name = "labelDetectedDevices";
            this.labelDetectedDevices.Size = new System.Drawing.Size(219, 29);
            this.labelDetectedDevices.TabIndex = 13;
            this.labelDetectedDevices.Text = "Wykryte urządzenia";
            // 
            // buttonReceive
            // 
            this.buttonReceive.BackColor = System.Drawing.Color.Transparent;
            this.buttonReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReceive.ForeColor = System.Drawing.Color.SlateGray;
            this.buttonReceive.Location = new System.Drawing.Point(226, 400);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(90, 40);
            this.buttonReceive.TabIndex = 14;
            this.buttonReceive.Text = "Odbierz";
            this.buttonReceive.UseVisualStyleBackColor = false;
            this.buttonReceive.Click += new System.EventHandler(this.buttonReceive_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::UP_Bluetooth.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 505);
            this.Controls.Add(this.buttonReceive);
            this.Controls.Add(this.labelDetectedDevices);
            this.Controls.Add(this.labelDeviceAddressTitle);
            this.Controls.Add(this.textBoxDeviceAddress);
            this.Controls.Add(this.buttonPair);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDeviceName);
            this.Controls.Add(this.textBoxDeviceConnected);
            this.Controls.Add(this.textBoxdeviceAuthenticated);
            this.Controls.Add(this.textBoxDeviceName);
            this.Controls.Add(this.buttonFindDevices);
            this.Controls.Add(this.comboBoxAvailableDevices);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormMain";
            this.Text = "UP Bluetooth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAvailableDevices;
        private System.Windows.Forms.Button buttonFindDevices;
        private System.Windows.Forms.TextBox textBoxDeviceName;
        private System.Windows.Forms.TextBox textBoxdeviceAuthenticated;
        private System.Windows.Forms.TextBox textBoxDeviceConnected;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonPair;
        private System.Windows.Forms.Label labelDeviceAddressTitle;
        private System.Windows.Forms.TextBox textBoxDeviceAddress;
        private System.Windows.Forms.Label labelDetectedDevices;
        private System.Windows.Forms.Button buttonReceive;
    }
}

