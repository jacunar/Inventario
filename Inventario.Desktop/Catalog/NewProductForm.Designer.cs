namespace Inventario.Desktop.Catalog {
    partial class NewProductForm {
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            IdTextBox = new TextBox();
            NameTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            UnitPriceNumericUpDown = new NumericUpDown();
            StockNumericUpDown = new NumericUpDown();
            MinStockTextBox = new TextBox();
            CategoriaCB = new ComboBox();
            ProveedorCB = new ComboBox();
            GuardarButton = new Button();
            CancelarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)UnitPriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StockNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 47);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 85);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 123);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "Precio Unitario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 161);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 4;
            label5.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 199);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 5;
            label6.Text = "Stock Minimo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 237);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 6;
            label7.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 275);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 7;
            label8.Text = "Proveedor";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(161, 6);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(321, 27);
            IdTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(161, 44);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(321, 27);
            NameTextBox.TabIndex = 9;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(161, 82);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(321, 27);
            DescriptionTextBox.TabIndex = 10;
            // 
            // UnitPriceNumericUpDown
            // 
            UnitPriceNumericUpDown.DecimalPlaces = 2;
            UnitPriceNumericUpDown.Location = new Point(161, 121);
            UnitPriceNumericUpDown.Name = "UnitPriceNumericUpDown";
            UnitPriceNumericUpDown.Size = new Size(120, 27);
            UnitPriceNumericUpDown.TabIndex = 11;
            // 
            // StockNumericUpDown
            // 
            StockNumericUpDown.Location = new Point(161, 154);
            StockNumericUpDown.Name = "StockNumericUpDown";
            StockNumericUpDown.Size = new Size(120, 27);
            StockNumericUpDown.TabIndex = 12;
            // 
            // MinStockTextBox
            // 
            MinStockTextBox.Location = new Point(161, 192);
            MinStockTextBox.Name = "MinStockTextBox";
            MinStockTextBox.Size = new Size(120, 27);
            MinStockTextBox.TabIndex = 13;
            // 
            // CategoriaCB
            // 
            CategoriaCB.FormattingEnabled = true;
            CategoriaCB.Location = new Point(161, 229);
            CategoriaCB.Name = "CategoriaCB";
            CategoriaCB.Size = new Size(202, 28);
            CategoriaCB.TabIndex = 14;
            // 
            // ProveedorCB
            // 
            ProveedorCB.FormattingEnabled = true;
            ProveedorCB.Location = new Point(161, 272);
            ProveedorCB.Name = "ProveedorCB";
            ProveedorCB.Size = new Size(202, 28);
            ProveedorCB.TabIndex = 15;
            // 
            // GuardarButton
            // 
            GuardarButton.Location = new Point(161, 320);
            GuardarButton.Name = "GuardarButton";
            GuardarButton.Size = new Size(120, 30);
            GuardarButton.TabIndex = 16;
            GuardarButton.Text = "Guardar";
            GuardarButton.UseVisualStyleBackColor = true;
            GuardarButton.Click += GuardarButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(302, 320);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(120, 30);
            CancelarButton.TabIndex = 17;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // NewProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 362);
            Controls.Add(CancelarButton);
            Controls.Add(GuardarButton);
            Controls.Add(ProveedorCB);
            Controls.Add(CategoriaCB);
            Controls.Add(MinStockTextBox);
            Controls.Add(StockNumericUpDown);
            Controls.Add(UnitPriceNumericUpDown);
            Controls.Add(DescriptionTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "NewProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EDITAR PRODUCTO";
            Load += NewProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)UnitPriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)StockNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox IdTextBox;
        private TextBox NameTextBox;
        private TextBox DescriptionTextBox;
        private NumericUpDown UnitPriceNumericUpDown;
        private NumericUpDown StockNumericUpDown;
        private TextBox MinStockTextBox;
        private ComboBox CategoriaCB;
        private ComboBox ProveedorCB;
        private Button GuardarButton;
        private Button CancelarButton;
    }
}