namespace Estacionamento.Views
{
    partial class FormConfiguracao
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
            VagaMoto = new Label();
            label2 = new Label();
            label3 = new Label();
            quantidadeVagasMoto = new NumericUpDown();
            quantidadeVagasCarro = new NumericUpDown();
            quantidadeVagasVan = new NumericUpDown();
            btn_inicializar = new Button();
            ((System.ComponentModel.ISupportInitialize)quantidadeVagasMoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantidadeVagasCarro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantidadeVagasVan).BeginInit();
            SuspendLayout();
            // 
            // VagaMoto
            // 
            VagaMoto.AutoSize = true;
            VagaMoto.Location = new Point(25, 26);
            VagaMoto.Name = "VagaMoto";
            VagaMoto.Size = new Size(88, 15);
            VagaMoto.TabIndex = 0;
            VagaMoto.Text = "Vagas de Moto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 65);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Vagas de Carro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 98);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Vagas de Van:";
            // 
            // quantidadeVagasMoto
            // 
            quantidadeVagasMoto.Location = new Point(119, 24);
            quantidadeVagasMoto.Name = "quantidadeVagasMoto";
            quantidadeVagasMoto.Size = new Size(120, 23);
            quantidadeVagasMoto.TabIndex = 3;
            // 
            // quantidadeVagasCarro
            // 
            quantidadeVagasCarro.Location = new Point(119, 63);
            quantidadeVagasCarro.Name = "quantidadeVagasCarro";
            quantidadeVagasCarro.Size = new Size(120, 23);
            quantidadeVagasCarro.TabIndex = 4;
            // 
            // quantidadeVagasVan
            // 
            quantidadeVagasVan.Location = new Point(119, 98);
            quantidadeVagasVan.Name = "quantidadeVagasVan";
            quantidadeVagasVan.Size = new Size(120, 23);
            quantidadeVagasVan.TabIndex = 5;
            // 
            // btn_inicializar
            // 
            btn_inicializar.BackColor = Color.FromArgb(33, 33, 33);
            btn_inicializar.ForeColor = Color.White;
            btn_inicializar.Location = new Point(172, 159);
            btn_inicializar.Name = "btn_inicializar";
            btn_inicializar.Size = new Size(75, 23);
            btn_inicializar.TabIndex = 6;
            btn_inicializar.Text = "Inicializar";
            btn_inicializar.UseVisualStyleBackColor = false;
            btn_inicializar.Click += btn_inicializar_Click;
            // 
            // FormConfiguracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(259, 193);
            Controls.Add(btn_inicializar);
            Controls.Add(quantidadeVagasVan);
            Controls.Add(quantidadeVagasCarro);
            Controls.Add(quantidadeVagasMoto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(VagaMoto);
            ForeColor = Color.White;
            Name = "FormConfiguracao";
            Text = "FormConfiguracao";
            ((System.ComponentModel.ISupportInitialize)quantidadeVagasMoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantidadeVagasCarro).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantidadeVagasVan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label VagaMoto;
        private Label label2;
        private Label label3;
        private NumericUpDown quantidadeVagasMoto;
        private NumericUpDown quantidadeVagasCarro;
        private NumericUpDown quantidadeVagasVan;
        private Button btn_inicializar;
    }
}