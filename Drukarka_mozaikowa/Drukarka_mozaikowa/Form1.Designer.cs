namespace Drukarka_mozaikowa
{
    partial class Form1
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxPortName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPortStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.textBoxTextToWrite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.Salmon;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.ForeColor = System.Drawing.Color.Black;
            this.buttonOpen.Location = new System.Drawing.Point(377, 496);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(88, 31);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Drukuj";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textBoxPortName
            // 
            this.textBoxPortName.BackColor = System.Drawing.Color.Salmon;
            this.textBoxPortName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPortName.Location = new System.Drawing.Point(44, 94);
            this.textBoxPortName.Multiline = true;
            this.textBoxPortName.Name = "textBoxPortName";
            this.textBoxPortName.Size = new System.Drawing.Size(213, 29);
            this.textBoxPortName.TabIndex = 1;
            this.textBoxPortName.Text = "COM1";
            this.textBoxPortName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Podaj nazwę portu:";
            // 
            // labelPortStatus
            // 
            this.labelPortStatus.AutoSize = true;
            this.labelPortStatus.BackColor = System.Drawing.Color.Maroon;
            this.labelPortStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPortStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPortStatus.Location = new System.Drawing.Point(588, 498);
            this.labelPortStatus.Name = "labelPortStatus";
            this.labelPortStatus.Size = new System.Drawing.Size(169, 29);
            this.labelPortStatus.TabIndex = 3;
            this.labelPortStatus.Text = "Port zamknięty";
            this.labelPortStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz czcionkę:";
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(44, 208);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(213, 24);
            this.comboBoxFont.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wybierz rozmiar:";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(44, 317);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(213, 24);
            this.comboBoxSize.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wybierz styl:";
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Location = new System.Drawing.Point(49, 426);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(208, 24);
            this.comboBoxStyle.TabIndex = 9;
            // 
            // textBoxTextToWrite
            // 
            this.textBoxTextToWrite.Location = new System.Drawing.Point(419, 132);
            this.textBoxTextToWrite.Multiline = true;
            this.textBoxTextToWrite.Name = "textBoxTextToWrite";
            this.textBoxTextToWrite.Size = new System.Drawing.Size(298, 264);
            this.textBoxTextToWrite.TabIndex = 10;
            this.textBoxTextToWrite.Text = "Test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(414, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Podaj tekst:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTextToWrite);
            this.Controls.Add(this.comboBoxStyle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPortStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPortName);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "Drukarka mozaikowa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBoxPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPortStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.TextBox textBoxTextToWrite;
        private System.Windows.Forms.Label label5;
    }
}

