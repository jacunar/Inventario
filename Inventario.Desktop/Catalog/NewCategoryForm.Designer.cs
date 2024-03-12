namespace Inventario.Desktop.Catalog {
    partial class NewCategoryForm {
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            GuardarButton = new Button();
            CancelarButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(23, 19);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 25);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(273, 25);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 4;
            label3.Text = "Descripcion";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(145, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(273, 25);
            textBox3.TabIndex = 5;
            // 
            // GuardarButton
            // 
            GuardarButton.Location = new Point(145, 126);
            GuardarButton.Name = "GuardarButton";
            GuardarButton.Size = new Size(117, 30);
            GuardarButton.TabIndex = 6;
            GuardarButton.Text = "Guardar";
            GuardarButton.UseVisualStyleBackColor = true;
            GuardarButton.Click += GuardarButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(301, 126);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(117, 30);
            CancelarButton.TabIndex = 7;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // NewCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 173);
            Controls.Add(CancelarButton);
            Controls.Add(GuardarButton);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            Name = "NewCategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EDITAR CATEGORIA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button GuardarButton;
        private Button CancelarButton;
    }
}