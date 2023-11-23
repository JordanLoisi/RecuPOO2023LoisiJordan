namespace RecuPOO2023.Windows
{
    partial class frmMonedaAE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            rbtEuro = new RadioButton();
            rbtDolar = new RadioButton();
            rbtPeso = new RadioButton();
            label1 = new Label();
            txtCantidad = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtEuro);
            groupBox1.Controls.Add(rbtDolar);
            groupBox1.Controls.Add(rbtPeso);
            groupBox1.Location = new Point(41, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Monedas ";
            // 
            // rbtEuro
            // 
            rbtEuro.AutoSize = true;
            rbtEuro.Location = new Point(22, 72);
            rbtEuro.Name = "rbtEuro";
            rbtEuro.Size = new Size(49, 19);
            rbtEuro.TabIndex = 0;
            rbtEuro.Text = "Euro";
            rbtEuro.UseVisualStyleBackColor = true;
            // 
            // rbtDolar
            // 
            rbtDolar.AutoSize = true;
            rbtDolar.Location = new Point(22, 47);
            rbtDolar.Name = "rbtDolar";
            rbtDolar.Size = new Size(53, 19);
            rbtDolar.TabIndex = 0;
            rbtDolar.Text = "Dólar";
            rbtDolar.UseVisualStyleBackColor = true;
            // 
            // rbtPeso
            // 
            rbtPeso.AutoSize = true;
            rbtPeso.Checked = true;
            rbtPeso.Location = new Point(22, 22);
            rbtPeso.Name = "rbtPeso";
            rbtPeso.Size = new Size(50, 19);
            rbtPeso.TabIndex = 0;
            rbtPeso.TabStop = true;
            rbtPeso.Text = "Peso";
            rbtPeso.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 170);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(45, 200);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(196, 23);
            txtCantidad.TabIndex = 2;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(27, 259);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 52);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(166, 259);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 52);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmMonedaAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 327);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtCantidad);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmMonedaAE";
            Text = "frmMonedaAE";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbtDolar;
        private RadioButton rbtPeso;
        private RadioButton rbtEuro;
        private Label label1;
        private TextBox txtCantidad;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}