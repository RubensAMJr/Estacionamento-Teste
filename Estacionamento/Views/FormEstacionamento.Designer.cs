namespace Estacionamento
{
    partial class FormEstacionamento
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
            label1 = new Label();
            labelQuantidadeVagasRestantes = new Label();
            label2 = new Label();
            labelQuantidadeVagasTotais = new Label();
            splitter1 = new Splitter();
            label3 = new Label();
            CBTipoVeiculo = new ComboBox();
            CBTipoVaga = new ComboBox();
            label4 = new Label();
            btnEstacionar = new Button();
            label5 = new Label();
            PlacaVeiculo = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblQuantidadeVagasMoto = new Label();
            lblQuantidadeVagasCarro = new Label();
            lblQuantidadeVagasVan = new Label();
            label9 = new Label();
            lblQuantidadeVagasOcupadasVans = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 18);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 0;
            label1.Text = "Quantidade de vagas restantes:";
            // 
            // labelQuantidadeVagasRestantes
            // 
            labelQuantidadeVagasRestantes.AutoSize = true;
            labelQuantidadeVagasRestantes.Location = new Point(473, 18);
            labelQuantidadeVagasRestantes.Name = "labelQuantidadeVagasRestantes";
            labelQuantidadeVagasRestantes.Size = new Size(0, 15);
            labelQuantidadeVagasRestantes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 43);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantidade de vagas totais:";
            // 
            // labelQuantidadeVagasTotais
            // 
            labelQuantidadeVagasTotais.AutoSize = true;
            labelQuantidadeVagasTotais.Location = new Point(467, 43);
            labelQuantidadeVagasTotais.Name = "labelQuantidadeVagasTotais";
            labelQuantidadeVagasTotais.Size = new Size(0, 15);
            labelQuantidadeVagasTotais.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(290, 450);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Estacionar:";
            // 
            // CBTipoVeiculo
            // 
            CBTipoVeiculo.FormattingEnabled = true;
            CBTipoVeiculo.Location = new Point(12, 40);
            CBTipoVeiculo.Name = "CBTipoVeiculo";
            CBTipoVeiculo.Size = new Size(75, 23);
            CBTipoVeiculo.TabIndex = 6;
            // 
            // CBTipoVaga
            // 
            CBTipoVaga.FormattingEnabled = true;
            CBTipoVaga.Location = new Point(165, 40);
            CBTipoVaga.Name = "CBTipoVaga";
            CBTipoVaga.Size = new Size(67, 23);
            CBTipoVaga.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 43);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 8;
            label4.Text = "Na vaga de";
            // 
            // btnEstacionar
            // 
            btnEstacionar.BackColor = Color.FromArgb(33, 33, 33);
            btnEstacionar.Location = new Point(12, 119);
            btnEstacionar.Name = "btnEstacionar";
            btnEstacionar.Size = new Size(75, 23);
            btnEstacionar.TabIndex = 9;
            btnEstacionar.Text = "Estacionar";
            btnEstacionar.UseVisualStyleBackColor = false;
            btnEstacionar.Click += btnEstacionar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 77);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "Placa:";
            // 
            // PlacaVeiculo
            // 
            PlacaVeiculo.Location = new Point(56, 74);
            PlacaVeiculo.Name = "PlacaVeiculo";
            PlacaVeiculo.Size = new Size(100, 23);
            PlacaVeiculo.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 164);
            label6.Name = "label6";
            label6.Size = new Size(219, 15);
            label6.TabIndex = 12;
            label6.Text = "Quantidade de vagas de Moto restantes:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 191);
            label7.Name = "label7";
            label7.Size = new Size(219, 15);
            label7.TabIndex = 13;
            label7.Text = "Quantidade de vagas de Carro restantes:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 217);
            label8.Name = "label8";
            label8.Size = new Size(209, 15);
            label8.TabIndex = 14;
            label8.Text = "Quantidade de vagas de Van restantes:";
            // 
            // lblQuantidadeVagasMoto
            // 
            lblQuantidadeVagasMoto.AutoSize = true;
            lblQuantidadeVagasMoto.Location = new Point(228, 164);
            lblQuantidadeVagasMoto.Name = "lblQuantidadeVagasMoto";
            lblQuantidadeVagasMoto.Size = new Size(0, 15);
            lblQuantidadeVagasMoto.TabIndex = 15;
            // 
            // lblQuantidadeVagasCarro
            // 
            lblQuantidadeVagasCarro.AutoSize = true;
            lblQuantidadeVagasCarro.Location = new Point(228, 191);
            lblQuantidadeVagasCarro.Name = "lblQuantidadeVagasCarro";
            lblQuantidadeVagasCarro.Size = new Size(0, 15);
            lblQuantidadeVagasCarro.TabIndex = 16;
            // 
            // lblQuantidadeVagasVan
            // 
            lblQuantidadeVagasVan.AutoSize = true;
            lblQuantidadeVagasVan.Location = new Point(222, 217);
            lblQuantidadeVagasVan.Name = "lblQuantidadeVagasVan";
            lblQuantidadeVagasVan.Size = new Size(0, 15);
            lblQuantidadeVagasVan.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 243);
            label9.Name = "label9";
            label9.Size = new Size(223, 15);
            label9.TabIndex = 18;
            label9.Text = "Quantidade de vagas ocupadas por Vans:";
            // 
            // lblQuantidadeVagasOcupadasVans
            // 
            lblQuantidadeVagasOcupadasVans.AutoSize = true;
            lblQuantidadeVagasOcupadasVans.Location = new Point(241, 243);
            lblQuantidadeVagasOcupadasVans.Name = "lblQuantidadeVagasOcupadasVans";
            lblQuantidadeVagasOcupadasVans.Size = new Size(0, 15);
            lblQuantidadeVagasOcupadasVans.TabIndex = 19;
            // 
            // FormEstacionamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(519, 450);
            Controls.Add(lblQuantidadeVagasOcupadasVans);
            Controls.Add(label9);
            Controls.Add(lblQuantidadeVagasVan);
            Controls.Add(lblQuantidadeVagasCarro);
            Controls.Add(lblQuantidadeVagasMoto);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(PlacaVeiculo);
            Controls.Add(label5);
            Controls.Add(btnEstacionar);
            Controls.Add(label4);
            Controls.Add(CBTipoVaga);
            Controls.Add(CBTipoVeiculo);
            Controls.Add(label3);
            Controls.Add(splitter1);
            Controls.Add(labelQuantidadeVagasTotais);
            Controls.Add(label2);
            Controls.Add(labelQuantidadeVagasRestantes);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "FormEstacionamento";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelQuantidadeVagasRestantes;
        private Label label2;
        private Label labelQuantidadeVagasTotais;
        private Splitter splitter1;
        private Label label3;
        private ComboBox CBTipoVeiculo;
        private ComboBox CBTipoVaga;
        private Label label4;
        private Button btnEstacionar;
        private Label label5;
        private TextBox PlacaVeiculo;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblQuantidadeVagasMoto;
        private Label lblQuantidadeVagasCarro;
        private Label lblQuantidadeVagasVan;
        private Label label9;
        private Label lblQuantidadeVagasOcupadasVans;
    }
}
