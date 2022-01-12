namespace MyTransportApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.lblYourConnections = new System.Windows.Forms.Label();
            this.dataGridConnections = new System.Windows.Forms.DataGridView();
            this.ColDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStartTIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndTIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDriveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxConnections = new System.Windows.Forms.ListBox();
            this.lblAbfahrtsplan = new System.Windows.Forms.Label();
            this.combVon = new System.Windows.Forms.ComboBox();
            this.combNach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeStations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Transport App";
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(403, 133);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(177, 32);
            this.btnSearchConnections.TabIndex = 3;
            this.btnSearchConnections.Text = "Verbindung suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(24, 140);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(38, 13);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "Datum";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(243, 143);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(25, 13);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Zeit";
            // 
            // tbxTime
            // 
            this.tbxTime.Location = new System.Drawing.Point(246, 164);
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(37, 20);
            this.tbxTime.TabIndex = 7;
            this.tbxTime.Text = "12:00";
            // 
            // lblYourConnections
            // 
            this.lblYourConnections.AutoSize = true;
            this.lblYourConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourConnections.Location = new System.Drawing.Point(23, 202);
            this.lblYourConnections.Name = "lblYourConnections";
            this.lblYourConnections.Size = new System.Drawing.Size(163, 20);
            this.lblYourConnections.TabIndex = 8;
            this.lblYourConnections.Text = "Ihre Verbindungen:";
            // 
            // dataGridConnections
            // 
            this.dataGridConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDeparture,
            this.ColStartTIme,
            this.ColEndTIme,
            this.ColDriveTime,
            this.ColDelay});
            this.dataGridConnections.Location = new System.Drawing.Point(27, 251);
            this.dataGridConnections.Name = "dataGridConnections";
            this.dataGridConnections.Size = new System.Drawing.Size(565, 158);
            this.dataGridConnections.TabIndex = 9;
            // 
            // ColDeparture
            // 
            this.ColDeparture.HeaderText = "Gleis";
            this.ColDeparture.Name = "ColDeparture";
            this.ColDeparture.ReadOnly = true;
            this.ColDeparture.Width = 70;
            // 
            // ColStartTIme
            // 
            this.ColStartTIme.HeaderText = "Abfahrt";
            this.ColStartTIme.Name = "ColStartTIme";
            this.ColStartTIme.ReadOnly = true;
            this.ColStartTIme.Width = 140;
            // 
            // ColEndTIme
            // 
            this.ColEndTIme.HeaderText = "Ankunft";
            this.ColEndTIme.Name = "ColEndTIme";
            this.ColEndTIme.ReadOnly = true;
            this.ColEndTIme.Width = 140;
            // 
            // ColDriveTime
            // 
            this.ColDriveTime.HeaderText = "Fahrtdauer";
            this.ColDriveTime.Name = "ColDriveTime";
            this.ColDriveTime.ReadOnly = true;
            // 
            // ColDelay
            // 
            this.ColDelay.HeaderText = "Verspätung";
            this.ColDelay.Name = "ColDelay";
            this.ColDelay.ReadOnly = true;
            this.ColDelay.Width = 70;
            // 
            // listBoxConnections
            // 
            this.listBoxConnections.FormattingEnabled = true;
            this.listBoxConnections.Location = new System.Drawing.Point(27, 450);
            this.listBoxConnections.Name = "listBoxConnections";
            this.listBoxConnections.Size = new System.Drawing.Size(177, 147);
            this.listBoxConnections.TabIndex = 10;
            // 
            // lblAbfahrtsplan
            // 
            this.lblAbfahrtsplan.AutoSize = true;
            this.lblAbfahrtsplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbfahrtsplan.Location = new System.Drawing.Point(22, 422);
            this.lblAbfahrtsplan.Name = "lblAbfahrtsplan";
            this.lblAbfahrtsplan.Size = new System.Drawing.Size(145, 25);
            this.lblAbfahrtsplan.TabIndex = 11;
            this.lblAbfahrtsplan.Text = "Abfahrtsplan";
            // 
            // combVon
            // 
            this.combVon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.combVon.FormattingEnabled = true;
            this.combVon.Location = new System.Drawing.Point(27, 97);
            this.combVon.Name = "combVon";
            this.combVon.Size = new System.Drawing.Size(177, 21);
            this.combVon.TabIndex = 13;
            this.combVon.DropDown += new System.EventHandler(this.combVon_DropDown);
            // 
            // combNach
            // 
            this.combNach.FormattingEnabled = true;
            this.combNach.Location = new System.Drawing.Point(246, 97);
            this.combNach.Name = "combNach";
            this.combNach.Size = new System.Drawing.Size(177, 21);
            this.combNach.TabIndex = 14;
            this.combNach.DropDown += new System.EventHandler(this.combNach_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Von...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nach...";
            // 
            // btnChangeStations
            // 
            this.btnChangeStations.Location = new System.Drawing.Point(403, 171);
            this.btnChangeStations.Name = "btnChangeStations";
            this.btnChangeStations.Size = new System.Drawing.Size(177, 32);
            this.btnChangeStations.TabIndex = 17;
            this.btnChangeStations.Text = "Stationen tauschen";
            this.btnChangeStations.UseVisualStyleBackColor = true;
            this.btnChangeStations.Click += new System.EventHandler(this.btnChangeStations_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(615, 624);
            this.Controls.Add(this.btnChangeStations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combNach);
            this.Controls.Add(this.combVon);
            this.Controls.Add(this.lblAbfahrtsplan);
            this.Controls.Add(this.listBoxConnections);
            this.Controls.Add(this.dataGridConnections);
            this.Controls.Add(this.lblYourConnections);
            this.Controls.Add(this.tbxTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSearchConnections);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "My Transport App";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox tbxTime;
        private System.Windows.Forms.Label lblYourConnections;
        private System.Windows.Forms.DataGridView dataGridConnections;
        private System.Windows.Forms.ListBox listBoxConnections;
        private System.Windows.Forms.Label lblAbfahrtsplan;
        private System.Windows.Forms.ComboBox combVon;
        private System.Windows.Forms.ComboBox combNach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStartTIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndTIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDriveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeStations;
    }
}

