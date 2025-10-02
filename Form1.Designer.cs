namespace Sistema_Logistico
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sistemaLogistico = new TabControl();
            tabPage1 = new TabPage();
            buttonDeleteVeiculo = new Button();
            buttonSearchVeiculo = new Button();
            buttonEditVeiculo = new Button();
            textBoxConsumoMedio = new TextBox();
            textBoxCargaMaxima = new TextBox();
            labelCargaMaxima = new Label();
            textBoxPlaca = new TextBox();
            textBoxModelo = new TextBox();
            textBoxVeiculoId = new TextBox();
            labelConsumoMedio = new Label();
            labelPlaca = new Label();
            labelModelo = new Label();
            labelVeiculoId = new Label();
            buttonSaveVeiculo = new Button();
            tabPage2 = new TabPage();
            textBoxNumeroCelular = new TextBox();
            textBoxCNH = new TextBox();
            textBoxNomeMotorista = new TextBox();
            textBoxMotoristaId = new TextBox();
            labelNumeroCelular = new Label();
            labelCNH = new Label();
            labelNomeMotorista = new Label();
            labelMotoristaId = new Label();
            buttonDeleteMotorista = new Button();
            buttonSearchMotorista = new Button();
            buttonEditMotorista = new Button();
            buttonSalvarMotorista = new Button();
            tabPage3 = new TabPage();
            textBoxDistancia = new TextBox();
            textBoxDestino = new TextBox();
            textBoxOrigem = new TextBox();
            textBoxRotaId = new TextBox();
            labelDistancia = new Label();
            labelDestino = new Label();
            labelOrigem = new Label();
            labelRotaId = new Label();
            buttonDeleteRota = new Button();
            buttonSearchRota = new Button();
            buttonEditRota = new Button();
            buttonSalvarRota = new Button();
            tabPage4 = new TabPage();
            dateTimePickerDataConsultaPrecomb = new DateTimePicker();
            textBoxPrecoPrecomb = new TextBox();
            textBoxCombustivelPrecomb = new TextBox();
            textBoxCombustivelId = new TextBox();
            labelPrecoPrecomb = new Label();
            labelDataConsultaPrecomb = new Label();
            labelCombustivelPrecomb = new Label();
            labelCombustivelId = new Label();
            buttonDeletePreco = new Button();
            buttonSearchPreco = new Button();
            buttonEditPreco = new Button();
            buttonSavePreco = new Button();
            tabPage5 = new TabPage();
            labelSituacao = new Label();
            textBoxSituacaoViagem = new TextBox();
            comboBoxMotoristaViagem = new ComboBox();
            labelMotoristaViagem = new Label();
            comboBoxRotaViagem = new ComboBox();
            labelRotaViagem = new Label();
            comboBoxVeiculoViagem = new ComboBox();
            dateTimePickerDataSaida = new DateTimePicker();
            dateTimePickerDataChegada = new DateTimePicker();
            textBoxViagemId = new TextBox();
            labelVeiculoViagem = new Label();
            labelDataChegada = new Label();
            labelDataSaida = new Label();
            labelViagemId = new Label();
            buttonDeleteViagem = new Button();
            buttonSearchViagem = new Button();
            buttonEditViagem = new Button();
            buttonSaveViagem = new Button();
            sistemaLogistico.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // sistemaLogistico
            // 
            sistemaLogistico.Controls.Add(tabPage1);
            sistemaLogistico.Controls.Add(tabPage2);
            sistemaLogistico.Controls.Add(tabPage3);
            sistemaLogistico.Controls.Add(tabPage4);
            sistemaLogistico.Controls.Add(tabPage5);
            sistemaLogistico.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sistemaLogistico.Location = new Point(-1, -1);
            sistemaLogistico.Margin = new Padding(4);
            sistemaLogistico.Name = "sistemaLogistico";
            sistemaLogistico.SelectedIndex = 0;
            sistemaLogistico.Size = new Size(550, 400);
            sistemaLogistico.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(buttonDeleteVeiculo);
            tabPage1.Controls.Add(buttonSearchVeiculo);
            tabPage1.Controls.Add(buttonEditVeiculo);
            tabPage1.Controls.Add(textBoxConsumoMedio);
            tabPage1.Controls.Add(textBoxCargaMaxima);
            tabPage1.Controls.Add(labelCargaMaxima);
            tabPage1.Controls.Add(textBoxPlaca);
            tabPage1.Controls.Add(textBoxModelo);
            tabPage1.Controls.Add(textBoxVeiculoId);
            tabPage1.Controls.Add(labelConsumoMedio);
            tabPage1.Controls.Add(labelPlaca);
            tabPage1.Controls.Add(labelModelo);
            tabPage1.Controls.Add(labelVeiculoId);
            tabPage1.Controls.Add(buttonSaveVeiculo);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(542, 366);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Veículo";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteVeiculo
            // 
            buttonDeleteVeiculo.BackgroundImage = (Image)resources.GetObject("buttonDeleteVeiculo.BackgroundImage");
            buttonDeleteVeiculo.BackgroundImageLayout = ImageLayout.Center;
            buttonDeleteVeiculo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDeleteVeiculo.Location = new Point(472, 250);
            buttonDeleteVeiculo.Margin = new Padding(4);
            buttonDeleteVeiculo.Name = "buttonDeleteVeiculo";
            buttonDeleteVeiculo.Size = new Size(60, 60);
            buttonDeleteVeiculo.TabIndex = 31;
            buttonDeleteVeiculo.UseVisualStyleBackColor = true;
            buttonDeleteVeiculo.Click += buttonDeleteVeiculo_Click;
            // 
            // buttonSearchVeiculo
            // 
            buttonSearchVeiculo.BackgroundImage = (Image)resources.GetObject("buttonSearchVeiculo.BackgroundImage");
            buttonSearchVeiculo.BackgroundImageLayout = ImageLayout.Center;
            buttonSearchVeiculo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearchVeiculo.Location = new Point(472, 182);
            buttonSearchVeiculo.Margin = new Padding(4);
            buttonSearchVeiculo.Name = "buttonSearchVeiculo";
            buttonSearchVeiculo.Size = new Size(60, 60);
            buttonSearchVeiculo.TabIndex = 30;
            buttonSearchVeiculo.UseVisualStyleBackColor = true;
            buttonSearchVeiculo.Click += buttonSearchVeiculo_Click;
            // 
            // buttonEditVeiculo
            // 
            buttonEditVeiculo.BackgroundImage = (Image)resources.GetObject("buttonEditVeiculo.BackgroundImage");
            buttonEditVeiculo.BackgroundImageLayout = ImageLayout.Center;
            buttonEditVeiculo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditVeiculo.Location = new Point(472, 113);
            buttonEditVeiculo.Margin = new Padding(4);
            buttonEditVeiculo.Name = "buttonEditVeiculo";
            buttonEditVeiculo.Size = new Size(60, 60);
            buttonEditVeiculo.TabIndex = 29;
            buttonEditVeiculo.UseVisualStyleBackColor = true;
            buttonEditVeiculo.Click += buttonEditVeiculo_Click;
            // 
            // textBoxConsumoMedio
            // 
            textBoxConsumoMedio.Location = new Point(15, 246);
            textBoxConsumoMedio.Margin = new Padding(4);
            textBoxConsumoMedio.Name = "textBoxConsumoMedio";
            textBoxConsumoMedio.Size = new Size(200, 29);
            textBoxConsumoMedio.TabIndex = 28;
            // 
            // textBoxCargaMaxima
            // 
            textBoxCargaMaxima.Location = new Point(15, 321);
            textBoxCargaMaxima.Margin = new Padding(4);
            textBoxCargaMaxima.Name = "textBoxCargaMaxima";
            textBoxCargaMaxima.Size = new Size(200, 29);
            textBoxCargaMaxima.TabIndex = 27;
            // 
            // labelCargaMaxima
            // 
            labelCargaMaxima.AutoSize = true;
            labelCargaMaxima.Location = new Point(15, 296);
            labelCargaMaxima.Margin = new Padding(4, 0, 4, 0);
            labelCargaMaxima.Name = "labelCargaMaxima";
            labelCargaMaxima.Size = new Size(113, 21);
            labelCargaMaxima.TabIndex = 26;
            labelCargaMaxima.Text = "Carga máxima:";
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(15, 177);
            textBoxPlaca.Margin = new Padding(4);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(200, 29);
            textBoxPlaca.TabIndex = 24;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(15, 108);
            textBoxModelo.Margin = new Padding(4);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(400, 29);
            textBoxModelo.TabIndex = 23;
            // 
            // textBoxVeiculoId
            // 
            textBoxVeiculoId.Location = new Point(15, 42);
            textBoxVeiculoId.Margin = new Padding(4);
            textBoxVeiculoId.Name = "textBoxVeiculoId";
            textBoxVeiculoId.ReadOnly = true;
            textBoxVeiculoId.Size = new Size(200, 29);
            textBoxVeiculoId.TabIndex = 22;
            // 
            // labelConsumoMedio
            // 
            labelConsumoMedio.AutoSize = true;
            labelConsumoMedio.Location = new Point(15, 221);
            labelConsumoMedio.Margin = new Padding(4, 0, 4, 0);
            labelConsumoMedio.Name = "labelConsumoMedio";
            labelConsumoMedio.Size = new Size(128, 21);
            labelConsumoMedio.TabIndex = 21;
            labelConsumoMedio.Text = "Consumo médio:";
            // 
            // labelPlaca
            // 
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(15, 152);
            labelPlaca.Margin = new Padding(4, 0, 4, 0);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(49, 21);
            labelPlaca.TabIndex = 20;
            labelPlaca.Text = "Placa:";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(15, 83);
            labelModelo.Margin = new Padding(4, 0, 4, 0);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(66, 21);
            labelModelo.TabIndex = 19;
            labelModelo.Text = "Modelo:";
            // 
            // labelVeiculoId
            // 
            labelVeiculoId.AutoSize = true;
            labelVeiculoId.Location = new Point(15, 17);
            labelVeiculoId.Margin = new Padding(4, 0, 4, 0);
            labelVeiculoId.Name = "labelVeiculoId";
            labelVeiculoId.Size = new Size(82, 21);
            labelVeiculoId.TabIndex = 18;
            labelVeiculoId.Text = "Veículo ID:";
            // 
            // buttonSaveVeiculo
            // 
            buttonSaveVeiculo.BackgroundImage = (Image)resources.GetObject("buttonSaveVeiculo.BackgroundImage");
            buttonSaveVeiculo.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveVeiculo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveVeiculo.Location = new Point(472, 42);
            buttonSaveVeiculo.Margin = new Padding(4);
            buttonSaveVeiculo.Name = "buttonSaveVeiculo";
            buttonSaveVeiculo.Size = new Size(60, 60);
            buttonSaveVeiculo.TabIndex = 14;
            buttonSaveVeiculo.UseVisualStyleBackColor = true;
            buttonSaveVeiculo.Click += button16_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(textBoxNumeroCelular);
            tabPage2.Controls.Add(textBoxCNH);
            tabPage2.Controls.Add(textBoxNomeMotorista);
            tabPage2.Controls.Add(textBoxMotoristaId);
            tabPage2.Controls.Add(labelNumeroCelular);
            tabPage2.Controls.Add(labelCNH);
            tabPage2.Controls.Add(labelNomeMotorista);
            tabPage2.Controls.Add(labelMotoristaId);
            tabPage2.Controls.Add(buttonDeleteMotorista);
            tabPage2.Controls.Add(buttonSearchMotorista);
            tabPage2.Controls.Add(buttonEditMotorista);
            tabPage2.Controls.Add(buttonSalvarMotorista);
            tabPage2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(542, 366);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Motorista";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxNumeroCelular
            // 
            textBoxNumeroCelular.Location = new Point(15, 246);
            textBoxNumeroCelular.Margin = new Padding(4);
            textBoxNumeroCelular.Name = "textBoxNumeroCelular";
            textBoxNumeroCelular.Size = new Size(200, 29);
            textBoxNumeroCelular.TabIndex = 25;
            // 
            // textBoxCNH
            // 
            textBoxCNH.Location = new Point(15, 177);
            textBoxCNH.Margin = new Padding(4);
            textBoxCNH.Name = "textBoxCNH";
            textBoxCNH.Size = new Size(200, 29);
            textBoxCNH.TabIndex = 24;
            // 
            // textBoxNomeMotorista
            // 
            textBoxNomeMotorista.Location = new Point(15, 108);
            textBoxNomeMotorista.Margin = new Padding(4);
            textBoxNomeMotorista.Name = "textBoxNomeMotorista";
            textBoxNomeMotorista.Size = new Size(400, 29);
            textBoxNomeMotorista.TabIndex = 23;
            // 
            // textBoxMotoristaId
            // 
            textBoxMotoristaId.Location = new Point(15, 42);
            textBoxMotoristaId.Margin = new Padding(4);
            textBoxMotoristaId.Name = "textBoxMotoristaId";
            textBoxMotoristaId.ReadOnly = true;
            textBoxMotoristaId.Size = new Size(200, 29);
            textBoxMotoristaId.TabIndex = 22;
            // 
            // labelNumeroCelular
            // 
            labelNumeroCelular.AutoSize = true;
            labelNumeroCelular.Location = new Point(15, 221);
            labelNumeroCelular.Margin = new Padding(4, 0, 4, 0);
            labelNumeroCelular.Name = "labelNumeroCelular";
            labelNumeroCelular.Size = new Size(142, 21);
            labelNumeroCelular.TabIndex = 21;
            labelNumeroCelular.Text = "Número de celular:";
            // 
            // labelCNH
            // 
            labelCNH.AutoSize = true;
            labelCNH.Location = new Point(15, 152);
            labelCNH.Margin = new Padding(4, 0, 4, 0);
            labelCNH.Name = "labelCNH";
            labelCNH.Size = new Size(46, 21);
            labelCNH.TabIndex = 20;
            labelCNH.Text = "CNH:";
            // 
            // labelNomeMotorista
            // 
            labelNomeMotorista.AutoSize = true;
            labelNomeMotorista.Location = new Point(15, 83);
            labelNomeMotorista.Margin = new Padding(4, 0, 4, 0);
            labelNomeMotorista.Name = "labelNomeMotorista";
            labelNomeMotorista.Size = new Size(56, 21);
            labelNomeMotorista.TabIndex = 19;
            labelNomeMotorista.Text = "Nome:";
            // 
            // labelMotoristaId
            // 
            labelMotoristaId.AutoSize = true;
            labelMotoristaId.Location = new Point(15, 17);
            labelMotoristaId.Margin = new Padding(4, 0, 4, 0);
            labelMotoristaId.Name = "labelMotoristaId";
            labelMotoristaId.Size = new Size(99, 21);
            labelMotoristaId.TabIndex = 18;
            labelMotoristaId.Text = "Motorista ID:";
            // 
            // buttonDeleteMotorista
            // 
            buttonDeleteMotorista.BackgroundImage = (Image)resources.GetObject("buttonDeleteMotorista.BackgroundImage");
            buttonDeleteMotorista.BackgroundImageLayout = ImageLayout.Center;
            buttonDeleteMotorista.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDeleteMotorista.Location = new Point(472, 276);
            buttonDeleteMotorista.Margin = new Padding(4);
            buttonDeleteMotorista.Name = "buttonDeleteMotorista";
            buttonDeleteMotorista.Size = new Size(60, 60);
            buttonDeleteMotorista.TabIndex = 17;
            buttonDeleteMotorista.UseVisualStyleBackColor = true;
            buttonDeleteMotorista.Click += buttonDeleteMotorista_Click;
            // 
            // buttonSearchMotorista
            // 
            buttonSearchMotorista.BackgroundImage = (Image)resources.GetObject("buttonSearchMotorista.BackgroundImage");
            buttonSearchMotorista.BackgroundImageLayout = ImageLayout.Center;
            buttonSearchMotorista.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearchMotorista.Location = new Point(472, 201);
            buttonSearchMotorista.Margin = new Padding(4);
            buttonSearchMotorista.Name = "buttonSearchMotorista";
            buttonSearchMotorista.Size = new Size(60, 60);
            buttonSearchMotorista.TabIndex = 16;
            buttonSearchMotorista.UseVisualStyleBackColor = true;
            buttonSearchMotorista.Click += buttonSearchMotorista_Click;
            // 
            // buttonEditMotorista
            // 
            buttonEditMotorista.BackgroundImage = (Image)resources.GetObject("buttonEditMotorista.BackgroundImage");
            buttonEditMotorista.BackgroundImageLayout = ImageLayout.Center;
            buttonEditMotorista.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditMotorista.Location = new Point(472, 122);
            buttonEditMotorista.Margin = new Padding(4);
            buttonEditMotorista.Name = "buttonEditMotorista";
            buttonEditMotorista.Size = new Size(60, 60);
            buttonEditMotorista.TabIndex = 15;
            buttonEditMotorista.UseVisualStyleBackColor = true;
            buttonEditMotorista.Click += buttonEditMotorista_Click;
            // 
            // buttonSalvarMotorista
            // 
            buttonSalvarMotorista.BackgroundImage = (Image)resources.GetObject("buttonSalvarMotorista.BackgroundImage");
            buttonSalvarMotorista.BackgroundImageLayout = ImageLayout.Center;
            buttonSalvarMotorista.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvarMotorista.Location = new Point(472, 42);
            buttonSalvarMotorista.Margin = new Padding(4);
            buttonSalvarMotorista.Name = "buttonSalvarMotorista";
            buttonSalvarMotorista.Size = new Size(60, 60);
            buttonSalvarMotorista.TabIndex = 14;
            buttonSalvarMotorista.UseVisualStyleBackColor = true;
            buttonSalvarMotorista.Click += buttonSalvarMotorista_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(textBoxDistancia);
            tabPage3.Controls.Add(textBoxDestino);
            tabPage3.Controls.Add(textBoxOrigem);
            tabPage3.Controls.Add(textBoxRotaId);
            tabPage3.Controls.Add(labelDistancia);
            tabPage3.Controls.Add(labelDestino);
            tabPage3.Controls.Add(labelOrigem);
            tabPage3.Controls.Add(labelRotaId);
            tabPage3.Controls.Add(buttonDeleteRota);
            tabPage3.Controls.Add(buttonSearchRota);
            tabPage3.Controls.Add(buttonEditRota);
            tabPage3.Controls.Add(buttonSalvarRota);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4);
            tabPage3.Size = new Size(542, 366);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rota";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxDistancia
            // 
            textBoxDistancia.Location = new Point(15, 246);
            textBoxDistancia.Margin = new Padding(4);
            textBoxDistancia.Name = "textBoxDistancia";
            textBoxDistancia.Size = new Size(200, 29);
            textBoxDistancia.TabIndex = 25;
            // 
            // textBoxDestino
            // 
            textBoxDestino.Location = new Point(15, 177);
            textBoxDestino.Margin = new Padding(4);
            textBoxDestino.Name = "textBoxDestino";
            textBoxDestino.Size = new Size(400, 29);
            textBoxDestino.TabIndex = 24;
            // 
            // textBoxOrigem
            // 
            textBoxOrigem.Location = new Point(15, 108);
            textBoxOrigem.Margin = new Padding(4);
            textBoxOrigem.Name = "textBoxOrigem";
            textBoxOrigem.Size = new Size(400, 29);
            textBoxOrigem.TabIndex = 23;
            // 
            // textBoxRotaId
            // 
            textBoxRotaId.Location = new Point(15, 42);
            textBoxRotaId.Margin = new Padding(4);
            textBoxRotaId.Name = "textBoxRotaId";
            textBoxRotaId.ReadOnly = true;
            textBoxRotaId.Size = new Size(200, 29);
            textBoxRotaId.TabIndex = 22;
            // 
            // labelDistancia
            // 
            labelDistancia.AutoSize = true;
            labelDistancia.Location = new Point(15, 221);
            labelDistancia.Margin = new Padding(4, 0, 4, 0);
            labelDistancia.Name = "labelDistancia";
            labelDistancia.Size = new Size(108, 21);
            labelDistancia.TabIndex = 21;
            labelDistancia.Text = "Distância:(km)";
            // 
            // labelDestino
            // 
            labelDestino.AutoSize = true;
            labelDestino.Location = new Point(15, 152);
            labelDestino.Margin = new Padding(4, 0, 4, 0);
            labelDestino.Name = "labelDestino";
            labelDestino.Size = new Size(66, 21);
            labelDestino.TabIndex = 20;
            labelDestino.Text = "Destino:";
            // 
            // labelOrigem
            // 
            labelOrigem.AutoSize = true;
            labelOrigem.Location = new Point(15, 83);
            labelOrigem.Margin = new Padding(4, 0, 4, 0);
            labelOrigem.Name = "labelOrigem";
            labelOrigem.Size = new Size(66, 21);
            labelOrigem.TabIndex = 19;
            labelOrigem.Text = "Origem:";
            // 
            // labelRotaId
            // 
            labelRotaId.AutoSize = true;
            labelRotaId.Location = new Point(15, 17);
            labelRotaId.Margin = new Padding(4, 0, 4, 0);
            labelRotaId.Name = "labelRotaId";
            labelRotaId.Size = new Size(64, 21);
            labelRotaId.TabIndex = 18;
            labelRotaId.Text = "Rota ID:";
            // 
            // buttonDeleteRota
            // 
            buttonDeleteRota.BackgroundImage = (Image)resources.GetObject("buttonDeleteRota.BackgroundImage");
            buttonDeleteRota.BackgroundImageLayout = ImageLayout.Center;
            buttonDeleteRota.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDeleteRota.Location = new Point(472, 276);
            buttonDeleteRota.Margin = new Padding(4);
            buttonDeleteRota.Name = "buttonDeleteRota";
            buttonDeleteRota.Size = new Size(60, 60);
            buttonDeleteRota.TabIndex = 17;
            buttonDeleteRota.UseVisualStyleBackColor = true;
            buttonDeleteRota.Click += buttonDeleteRota_Click;
            // 
            // buttonSearchRota
            // 
            buttonSearchRota.BackgroundImage = (Image)resources.GetObject("buttonSearchRota.BackgroundImage");
            buttonSearchRota.BackgroundImageLayout = ImageLayout.Center;
            buttonSearchRota.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearchRota.Location = new Point(472, 201);
            buttonSearchRota.Margin = new Padding(4);
            buttonSearchRota.Name = "buttonSearchRota";
            buttonSearchRota.Size = new Size(60, 60);
            buttonSearchRota.TabIndex = 16;
            buttonSearchRota.UseVisualStyleBackColor = true;
            buttonSearchRota.Click += buttonSearchRota_Click;
            // 
            // buttonEditRota
            // 
            buttonEditRota.BackgroundImage = (Image)resources.GetObject("buttonEditRota.BackgroundImage");
            buttonEditRota.BackgroundImageLayout = ImageLayout.Center;
            buttonEditRota.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditRota.Location = new Point(472, 122);
            buttonEditRota.Margin = new Padding(4);
            buttonEditRota.Name = "buttonEditRota";
            buttonEditRota.Size = new Size(60, 60);
            buttonEditRota.TabIndex = 15;
            buttonEditRota.UseVisualStyleBackColor = true;
            buttonEditRota.Click += buttonEditRota_Click;
            // 
            // buttonSalvarRota
            // 
            buttonSalvarRota.BackgroundImage = (Image)resources.GetObject("buttonSalvarRota.BackgroundImage");
            buttonSalvarRota.BackgroundImageLayout = ImageLayout.Center;
            buttonSalvarRota.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvarRota.Location = new Point(472, 42);
            buttonSalvarRota.Margin = new Padding(4);
            buttonSalvarRota.Name = "buttonSalvarRota";
            buttonSalvarRota.Size = new Size(60, 60);
            buttonSalvarRota.TabIndex = 14;
            buttonSalvarRota.UseVisualStyleBackColor = true;
            buttonSalvarRota.Click += buttonSalvarRota_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage4.Controls.Add(dateTimePickerDataConsultaPrecomb);
            tabPage4.Controls.Add(textBoxPrecoPrecomb);
            tabPage4.Controls.Add(textBoxCombustivelPrecomb);
            tabPage4.Controls.Add(textBoxCombustivelId);
            tabPage4.Controls.Add(labelPrecoPrecomb);
            tabPage4.Controls.Add(labelDataConsultaPrecomb);
            tabPage4.Controls.Add(labelCombustivelPrecomb);
            tabPage4.Controls.Add(labelCombustivelId);
            tabPage4.Controls.Add(buttonDeletePreco);
            tabPage4.Controls.Add(buttonSearchPreco);
            tabPage4.Controls.Add(buttonEditPreco);
            tabPage4.Controls.Add(buttonSavePreco);
            tabPage4.Location = new Point(4, 30);
            tabPage4.Margin = new Padding(4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(4);
            tabPage4.Size = new Size(542, 366);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Preço Combustivel";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataConsultaPrecomb
            // 
            dateTimePickerDataConsultaPrecomb.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dateTimePickerDataConsultaPrecomb.Format = DateTimePickerFormat.Custom;
            dateTimePickerDataConsultaPrecomb.ImeMode = ImeMode.NoControl;
            dateTimePickerDataConsultaPrecomb.Location = new Point(15, 176);
            dateTimePickerDataConsultaPrecomb.Name = "dateTimePickerDataConsultaPrecomb";
            dateTimePickerDataConsultaPrecomb.Size = new Size(200, 29);
            dateTimePickerDataConsultaPrecomb.TabIndex = 28;
            // 
            // textBoxPrecoPrecomb
            // 
            textBoxPrecoPrecomb.Location = new Point(15, 246);
            textBoxPrecoPrecomb.Margin = new Padding(4);
            textBoxPrecoPrecomb.Name = "textBoxPrecoPrecomb";
            textBoxPrecoPrecomb.Size = new Size(200, 29);
            textBoxPrecoPrecomb.TabIndex = 25;
            // 
            // textBoxCombustivelPrecomb
            // 
            textBoxCombustivelPrecomb.Location = new Point(15, 108);
            textBoxCombustivelPrecomb.Margin = new Padding(4);
            textBoxCombustivelPrecomb.Name = "textBoxCombustivelPrecomb";
            textBoxCombustivelPrecomb.Size = new Size(300, 29);
            textBoxCombustivelPrecomb.TabIndex = 23;
            // 
            // textBoxCombustivelId
            // 
            textBoxCombustivelId.Location = new Point(15, 42);
            textBoxCombustivelId.Margin = new Padding(4);
            textBoxCombustivelId.Name = "textBoxCombustivelId";
            textBoxCombustivelId.ReadOnly = true;
            textBoxCombustivelId.Size = new Size(200, 29);
            textBoxCombustivelId.TabIndex = 22;
            // 
            // labelPrecoPrecomb
            // 
            labelPrecoPrecomb.AutoSize = true;
            labelPrecoPrecomb.Location = new Point(15, 221);
            labelPrecoPrecomb.Margin = new Padding(4, 0, 4, 0);
            labelPrecoPrecomb.Name = "labelPrecoPrecomb";
            labelPrecoPrecomb.Size = new Size(140, 21);
            labelPrecoPrecomb.TabIndex = 21;
            labelPrecoPrecomb.Text = "Preco do precomb:";
            // 
            // labelDataConsultaPrecomb
            // 
            labelDataConsultaPrecomb.AutoSize = true;
            labelDataConsultaPrecomb.Location = new Point(15, 152);
            labelDataConsultaPrecomb.Margin = new Padding(4, 0, 4, 0);
            labelDataConsultaPrecomb.Name = "labelDataConsultaPrecomb";
            labelDataConsultaPrecomb.Size = new Size(195, 21);
            labelDataConsultaPrecomb.TabIndex = 20;
            labelDataConsultaPrecomb.Text = "Data consulta do precomb:";
            // 
            // labelCombustivelPrecomb
            // 
            labelCombustivelPrecomb.AutoSize = true;
            labelCombustivelPrecomb.Location = new Point(15, 83);
            labelCombustivelPrecomb.Margin = new Padding(4, 0, 4, 0);
            labelCombustivelPrecomb.Name = "labelCombustivelPrecomb";
            labelCombustivelPrecomb.Size = new Size(187, 21);
            labelCombustivelPrecomb.TabIndex = 19;
            labelCombustivelPrecomb.Text = "Combustível da precomb:";
            // 
            // labelCombustivelId
            // 
            labelCombustivelId.AutoSize = true;
            labelCombustivelId.Location = new Point(15, 17);
            labelCombustivelId.Margin = new Padding(4, 0, 4, 0);
            labelCombustivelId.Name = "labelCombustivelId";
            labelCombustivelId.Size = new Size(119, 21);
            labelCombustivelId.TabIndex = 18;
            labelCombustivelId.Text = "Combustível ID:";
            // 
            // buttonDeletePreco
            // 
            buttonDeletePreco.BackgroundImage = (Image)resources.GetObject("buttonDeletePreco.BackgroundImage");
            buttonDeletePreco.BackgroundImageLayout = ImageLayout.Center;
            buttonDeletePreco.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDeletePreco.Location = new Point(472, 276);
            buttonDeletePreco.Margin = new Padding(4);
            buttonDeletePreco.Name = "buttonDeletePreco";
            buttonDeletePreco.Size = new Size(60, 60);
            buttonDeletePreco.TabIndex = 17;
            buttonDeletePreco.UseVisualStyleBackColor = true;
            buttonDeletePreco.Click += buttonDeletePreco_Click;
            // 
            // buttonSearchPreco
            // 
            buttonSearchPreco.BackgroundImage = (Image)resources.GetObject("buttonSearchPreco.BackgroundImage");
            buttonSearchPreco.BackgroundImageLayout = ImageLayout.Center;
            buttonSearchPreco.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearchPreco.Location = new Point(472, 201);
            buttonSearchPreco.Margin = new Padding(4);
            buttonSearchPreco.Name = "buttonSearchPreco";
            buttonSearchPreco.Size = new Size(60, 60);
            buttonSearchPreco.TabIndex = 16;
            buttonSearchPreco.UseVisualStyleBackColor = true;
            buttonSearchPreco.Click += buttonSearchPreco_Click;
            // 
            // buttonEditPreco
            // 
            buttonEditPreco.BackgroundImage = (Image)resources.GetObject("buttonEditPreco.BackgroundImage");
            buttonEditPreco.BackgroundImageLayout = ImageLayout.Center;
            buttonEditPreco.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditPreco.Location = new Point(472, 122);
            buttonEditPreco.Margin = new Padding(4);
            buttonEditPreco.Name = "buttonEditPreco";
            buttonEditPreco.Size = new Size(60, 60);
            buttonEditPreco.TabIndex = 15;
            buttonEditPreco.UseVisualStyleBackColor = true;
            buttonEditPreco.Click += buttonEditPreco_Click;
            // 
            // buttonSavePreco
            // 
            buttonSavePreco.BackgroundImage = (Image)resources.GetObject("buttonSavePreco.BackgroundImage");
            buttonSavePreco.BackgroundImageLayout = ImageLayout.Center;
            buttonSavePreco.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSavePreco.Location = new Point(472, 42);
            buttonSavePreco.Margin = new Padding(4);
            buttonSavePreco.Name = "buttonSavePreco";
            buttonSavePreco.Size = new Size(60, 60);
            buttonSavePreco.TabIndex = 14;
            buttonSavePreco.UseVisualStyleBackColor = true;
            buttonSavePreco.Click += buttonSavePreco_Click;
            // 
            // tabPage5
            // 
            tabPage5.BackgroundImage = (Image)resources.GetObject("tabPage5.BackgroundImage");
            tabPage5.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage5.Controls.Add(labelSituacao);
            tabPage5.Controls.Add(textBoxSituacaoViagem);
            tabPage5.Controls.Add(comboBoxMotoristaViagem);
            tabPage5.Controls.Add(labelMotoristaViagem);
            tabPage5.Controls.Add(comboBoxRotaViagem);
            tabPage5.Controls.Add(labelRotaViagem);
            tabPage5.Controls.Add(comboBoxVeiculoViagem);
            tabPage5.Controls.Add(dateTimePickerDataSaida);
            tabPage5.Controls.Add(dateTimePickerDataChegada);
            tabPage5.Controls.Add(textBoxViagemId);
            tabPage5.Controls.Add(labelVeiculoViagem);
            tabPage5.Controls.Add(labelDataChegada);
            tabPage5.Controls.Add(labelDataSaida);
            tabPage5.Controls.Add(labelViagemId);
            tabPage5.Controls.Add(buttonDeleteViagem);
            tabPage5.Controls.Add(buttonSearchViagem);
            tabPage5.Controls.Add(buttonEditViagem);
            tabPage5.Controls.Add(buttonSaveViagem);
            tabPage5.Location = new Point(4, 30);
            tabPage5.Margin = new Padding(4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(4);
            tabPage5.Size = new Size(542, 366);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Viagem";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // labelSituacao
            // 
            labelSituacao.AutoSize = true;
            labelSituacao.Location = new Point(234, 153);
            labelSituacao.Margin = new Padding(4, 0, 4, 0);
            labelSituacao.Name = "labelSituacao";
            labelSituacao.Size = new Size(72, 21);
            labelSituacao.TabIndex = 48;
            labelSituacao.Text = "Situação:";
            // 
            // textBoxSituacaoViagem
            // 
            textBoxSituacaoViagem.Location = new Point(234, 177);
            textBoxSituacaoViagem.Margin = new Padding(4);
            textBoxSituacaoViagem.Multiline = true;
            textBoxSituacaoViagem.Name = "textBoxSituacaoViagem";
            textBoxSituacaoViagem.ScrollBars = ScrollBars.Vertical;
            textBoxSituacaoViagem.Size = new Size(200, 166);
            textBoxSituacaoViagem.TabIndex = 47;
            // 
            // comboBoxMotoristaViagem
            // 
            comboBoxMotoristaViagem.FormattingEnabled = true;
            comboBoxMotoristaViagem.Location = new Point(13, 314);
            comboBoxMotoristaViagem.Name = "comboBoxMotoristaViagem";
            comboBoxMotoristaViagem.Size = new Size(200, 29);
            comboBoxMotoristaViagem.TabIndex = 46;
            // 
            // labelMotoristaViagem
            // 
            labelMotoristaViagem.AutoSize = true;
            labelMotoristaViagem.Location = new Point(13, 290);
            labelMotoristaViagem.Margin = new Padding(4, 0, 4, 0);
            labelMotoristaViagem.Name = "labelMotoristaViagem";
            labelMotoristaViagem.Size = new Size(80, 21);
            labelMotoristaViagem.TabIndex = 45;
            labelMotoristaViagem.Text = "Motorista:";
            // 
            // comboBoxRotaViagem
            // 
            comboBoxRotaViagem.FormattingEnabled = true;
            comboBoxRotaViagem.Location = new Point(13, 248);
            comboBoxRotaViagem.Name = "comboBoxRotaViagem";
            comboBoxRotaViagem.Size = new Size(200, 29);
            comboBoxRotaViagem.TabIndex = 44;
            // 
            // labelRotaViagem
            // 
            labelRotaViagem.AutoSize = true;
            labelRotaViagem.Location = new Point(13, 224);
            labelRotaViagem.Margin = new Padding(4, 0, 4, 0);
            labelRotaViagem.Name = "labelRotaViagem";
            labelRotaViagem.Size = new Size(45, 21);
            labelRotaViagem.TabIndex = 43;
            labelRotaViagem.Text = "Rota:";
            // 
            // comboBoxVeiculoViagem
            // 
            comboBoxVeiculoViagem.FormattingEnabled = true;
            comboBoxVeiculoViagem.Location = new Point(13, 177);
            comboBoxVeiculoViagem.Name = "comboBoxVeiculoViagem";
            comboBoxVeiculoViagem.Size = new Size(200, 29);
            comboBoxVeiculoViagem.TabIndex = 42;
            // 
            // dateTimePickerDataSaida
            // 
            dateTimePickerDataSaida.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dateTimePickerDataSaida.Format = DateTimePickerFormat.Custom;
            dateTimePickerDataSaida.ImeMode = ImeMode.NoControl;
            dateTimePickerDataSaida.Location = new Point(13, 114);
            dateTimePickerDataSaida.Name = "dateTimePickerDataSaida";
            dateTimePickerDataSaida.Size = new Size(200, 29);
            dateTimePickerDataSaida.TabIndex = 41;
            // 
            // dateTimePickerDataChegada
            // 
            dateTimePickerDataChegada.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dateTimePickerDataChegada.Format = DateTimePickerFormat.Custom;
            dateTimePickerDataChegada.ImeMode = ImeMode.NoControl;
            dateTimePickerDataChegada.Location = new Point(234, 114);
            dateTimePickerDataChegada.Name = "dateTimePickerDataChegada";
            dateTimePickerDataChegada.Size = new Size(200, 29);
            dateTimePickerDataChegada.TabIndex = 40;
            // 
            // textBoxViagemId
            // 
            textBoxViagemId.Location = new Point(13, 49);
            textBoxViagemId.Margin = new Padding(4);
            textBoxViagemId.Name = "textBoxViagemId";
            textBoxViagemId.ReadOnly = true;
            textBoxViagemId.Size = new Size(200, 29);
            textBoxViagemId.TabIndex = 37;
            // 
            // labelVeiculoViagem
            // 
            labelVeiculoViagem.AutoSize = true;
            labelVeiculoViagem.Location = new Point(13, 153);
            labelVeiculoViagem.Margin = new Padding(4, 0, 4, 0);
            labelVeiculoViagem.Name = "labelVeiculoViagem";
            labelVeiculoViagem.Size = new Size(63, 21);
            labelVeiculoViagem.TabIndex = 36;
            labelVeiculoViagem.Text = "Veículo:";
            // 
            // labelDataChegada
            // 
            labelDataChegada.AutoSize = true;
            labelDataChegada.Location = new Point(234, 90);
            labelDataChegada.Margin = new Padding(4, 0, 4, 0);
            labelDataChegada.Name = "labelDataChegada";
            labelDataChegada.Size = new Size(107, 21);
            labelDataChegada.TabIndex = 35;
            labelDataChegada.Text = "Data chegada:";
            // 
            // labelDataSaida
            // 
            labelDataSaida.AutoSize = true;
            labelDataSaida.Location = new Point(13, 90);
            labelDataSaida.Margin = new Padding(4, 0, 4, 0);
            labelDataSaida.Name = "labelDataSaida";
            labelDataSaida.Size = new Size(85, 21);
            labelDataSaida.TabIndex = 34;
            labelDataSaida.Text = "Data saída:";
            // 
            // labelViagemId
            // 
            labelViagemId.AutoSize = true;
            labelViagemId.Location = new Point(13, 24);
            labelViagemId.Margin = new Padding(4, 0, 4, 0);
            labelViagemId.Name = "labelViagemId";
            labelViagemId.Size = new Size(85, 21);
            labelViagemId.TabIndex = 33;
            labelViagemId.Text = "Viagem ID:";
            // 
            // buttonDeleteViagem
            // 
            buttonDeleteViagem.BackgroundImage = (Image)resources.GetObject("buttonDeleteViagem.BackgroundImage");
            buttonDeleteViagem.BackgroundImageLayout = ImageLayout.Center;
            buttonDeleteViagem.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDeleteViagem.Location = new Point(470, 283);
            buttonDeleteViagem.Margin = new Padding(4);
            buttonDeleteViagem.Name = "buttonDeleteViagem";
            buttonDeleteViagem.Size = new Size(60, 60);
            buttonDeleteViagem.TabIndex = 32;
            buttonDeleteViagem.UseVisualStyleBackColor = true;
            buttonDeleteViagem.Click += buttonDeleteViagem_Click;
            // 
            // buttonSearchViagem
            // 
            buttonSearchViagem.BackgroundImage = (Image)resources.GetObject("buttonSearchViagem.BackgroundImage");
            buttonSearchViagem.BackgroundImageLayout = ImageLayout.Center;
            buttonSearchViagem.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearchViagem.Location = new Point(470, 208);
            buttonSearchViagem.Margin = new Padding(4);
            buttonSearchViagem.Name = "buttonSearchViagem";
            buttonSearchViagem.Size = new Size(60, 60);
            buttonSearchViagem.TabIndex = 31;
            buttonSearchViagem.UseVisualStyleBackColor = true;
            buttonSearchViagem.Click += buttonSearchViagem_Click;
            // 
            // buttonEditViagem
            // 
            buttonEditViagem.BackgroundImage = (Image)resources.GetObject("buttonEditViagem.BackgroundImage");
            buttonEditViagem.BackgroundImageLayout = ImageLayout.Center;
            buttonEditViagem.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditViagem.Location = new Point(470, 129);
            buttonEditViagem.Margin = new Padding(4);
            buttonEditViagem.Name = "buttonEditViagem";
            buttonEditViagem.Size = new Size(60, 60);
            buttonEditViagem.TabIndex = 30;
            buttonEditViagem.UseVisualStyleBackColor = true;
            buttonEditViagem.Click += buttonEditViagem_Click;
            // 
            // buttonSaveViagem
            // 
            buttonSaveViagem.BackgroundImage = (Image)resources.GetObject("buttonSaveViagem.BackgroundImage");
            buttonSaveViagem.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveViagem.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveViagem.Location = new Point(470, 49);
            buttonSaveViagem.Margin = new Padding(4);
            buttonSaveViagem.Name = "buttonSaveViagem";
            buttonSaveViagem.Size = new Size(60, 60);
            buttonSaveViagem.TabIndex = 29;
            buttonSaveViagem.UseVisualStyleBackColor = true;
            buttonSaveViagem.Click += buttonSaveViagem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(549, 399);
            Controls.Add(sistemaLogistico);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            sistemaLogistico.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl sistemaLogistico;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TextBox textBoxCargaMaxima;
        private Label labelCargaMaxima;
        private TextBox textBoxPlaca;
        private TextBox textBoxModelo;
        private TextBox textBoxVeiculoId;
        private Label labelConsumoMedio;
        private Label labelPlaca;
        private Label labelModelo;
        private Label labelVeiculoId;
        private Button buttonDelete;
        private Button buttonSearch;
        private Button buttonEdit;
        private Button buttonSave;
        private TextBox textBox16;
        private Label label16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Button button15;
        private Button buttonSaveVeiculo;
        private TextBox textBox11;
        private Label label11;
        private TextBox textBoxNumeroCelular;
        private TextBox textBoxCNH;
        private TextBox textBoxNomeMotorista;
        private TextBox textBoxMotoristaId;
        private Label labelNumeroCelular;
        private Label labelCNH;
        private Label labelNomeMotorista;
        private Label labelMotoristaId;
        private Button buttonDeleteMotorista;
        private Button buttonSearchMotorista;
        private Button buttonEditMotorista;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button buttonSalvarMotorista;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBoxDistancia;
        private TextBox textBoxDestino;
        private TextBox textBoxOrigem;
        private TextBox textBoxRotaId;
        private Label labelDistancia;
        private Label labelDestino;
        private Label labelOrigem;
        private Label labelRotaId;
        private Button buttonDeleteRota;
        private Button buttonSearchRota;
        private Button buttonEditRota;
        private Button buttonSalvarRota;
        private TextBox textBoxPrecoPrecomb;
        private TextBox textBoxCombustivelPrecomb;
        private TextBox textBoxCombustivelId;
        private Label labelPrecoPrecomb;
        private Label labelDataConsultaPrecomb;
        private Label labelCombustivelPrecomb;
        private Label labelCombustivelId;
        private Button buttonDeletePreco;
        private Button buttonSearchPreco;
        private Button buttonEditPreco;
        private Button buttonSavePreco;
        private TextBox textBoxConsumoMedio;
        private Button buttonDeleteVeiculo;
        private Button buttonSearchVeiculo;
        private Button buttonEditVeiculo;
        private DateTimePicker dateTimePickerDataConsultaPrecomb;
        private DateTimePicker dateTimePickerDataSaida;
        private DateTimePicker dateTimePickerDataChegada;
        private TextBox textBoxViagemId;
        private Label labelVeiculoViagem;
        private Label labelDataChegada;
        private Label labelDataSaida;
        private Label labelViagemId;
        private Button buttonDeleteViagem;
        private Button buttonSearchViagem;
        private Button buttonEditViagem;
        private Button buttonSaveViagem;
        private ComboBox comboBoxMotoristaViagem;
        private Label labelMotoristaViagem;
        private ComboBox comboBoxRotaViagem;
        private Label labelRotaViagem;
        private ComboBox comboBoxVeiculoViagem;
        private Label labelSituacao;
        private TextBox textBoxSituacaoViagem;
    }
}
