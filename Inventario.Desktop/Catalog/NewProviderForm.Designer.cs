namespace Inventario.Desktop.Catalog {
    partial class NewProviderForm {
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            CancelarButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(23, 19);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 2;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 126);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 3;
            label4.Text = "Ciudad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 162);
            label5.Name = "label5";
            label5.Size = new Size(82, 19);
            label5.TabIndex = 4;
            label5.Text = "No Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 198);
            label6.Name = "label6";
            label6.Size = new Size(41, 19);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 25);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 25);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(114, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(318, 25);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(114, 123);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(266, 25);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(114, 159);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(266, 25);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(114, 195);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(266, 25);
            textBox6.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(113, 235);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 12;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(257, 235);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(123, 34);
            CancelarButton.TabIndex = 13;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // NewProviderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 293);
            Controls.Add(CancelarButton);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            Name = "NewProviderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EDITAR PROVEEDOR";
            Load += NewProviderForm_Load;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button CancelarButton;
    }
}