namespace Inventario.Desktop.Catalog {
    partial class ProvidersForm {
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
            components = new System.ComponentModel.Container();
            toolStrip1 = new ToolStrip();
            AddTSB = new ToolStripButton();
            EditTSB = new ToolStripButton();
            DeleteTSB = new ToolStripButton();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activeDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            creationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modificationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            providerBindingSource = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)providerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddTSB, EditTSB, DeleteTSB });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 31);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // AddTSB
            // 
            AddTSB.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AddTSB.Image = Properties.Resources.plus_math_26;
            AddTSB.ImageTransparentColor = Color.Magenta;
            AddTSB.Name = "AddTSB";
            AddTSB.Size = new Size(28, 28);
            AddTSB.Text = "toolStripButton1";
            AddTSB.Click += AddTSB_Click;
            // 
            // EditTSB
            // 
            EditTSB.DisplayStyle = ToolStripItemDisplayStyle.Image;
            EditTSB.Image = Properties.Resources.edit_24;
            EditTSB.ImageTransparentColor = Color.Magenta;
            EditTSB.Name = "EditTSB";
            EditTSB.Size = new Size(28, 28);
            EditTSB.Text = "toolStripButton2";
            // 
            // DeleteTSB
            // 
            DeleteTSB.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DeleteTSB.Image = Properties.Resources.close_26;
            DeleteTSB.ImageTransparentColor = Color.Magenta;
            DeleteTSB.Name = "DeleteTSB";
            DeleteTSB.Size = new Size(28, 28);
            DeleteTSB.Text = "toolStripButton3";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, activeDataGridViewCheckBoxColumn, creationDateDataGridViewTextBoxColumn, modificationDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = providerBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 419);
            dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            activeDataGridViewCheckBoxColumn.ReadOnly = true;
            activeDataGridViewCheckBoxColumn.Visible = false;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            creationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate";
            creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            creationDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // modificationDateDataGridViewTextBoxColumn
            // 
            modificationDateDataGridViewTextBoxColumn.DataPropertyName = "ModificationDate";
            modificationDateDataGridViewTextBoxColumn.HeaderText = "ModificationDate";
            modificationDateDataGridViewTextBoxColumn.Name = "modificationDateDataGridViewTextBoxColumn";
            modificationDateDataGridViewTextBoxColumn.ReadOnly = true;
            modificationDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // providerBindingSource
            // 
            providerBindingSource.DataSource = typeof(Core.Entities.Provider);
            // 
            // ProvidersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Name = "ProvidersForm";
            Text = "PROVEEDORES";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)providerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton AddTSB;
        private ToolStripButton EditTSB;
        private ToolStripButton DeleteTSB;
        private DataGridView dataGridView1;
        private BindingSource providerBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modificationDateDataGridViewTextBoxColumn;
    }
}