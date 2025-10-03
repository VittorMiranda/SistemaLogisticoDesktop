
using LogisticaApp.Repositorios;
using Sistema_Logistico.Entidades;
using Sistema_Logistico.Repositorios;
using Sistema_Logistico.Utils;

namespace Sistema_Logistico
{

    public partial class Form1 : Form
    {
        private VeiculoRepository veiculoRepository = new VeiculoRepository();
        private int? veiculoSelecionadoId = null;
        private Veiculo veiculoAtual;
        private MotoristaRepository motoristaRepository = new MotoristaRepository();
        private Motorista motoristaAtual;
        private int? motoristaSelecionadoId = null;
        private RotaRepository rotaRepository = new RotaRepository();
        private Rota rotaAtual;
        private int? rotaSelecionadaId = null;
        private PrecoCombustivelRepository precoCombustivelRepository = new PrecoCombustivelRepository();
        private PrecoCombustivel precoAtual;
        private int? precoSelecionadoId = null;
        private ViagemRepository viagemRepository = new ViagemRepository();
        private Viagem viagemAtual;
        public Form1()
        {
            InitializeComponent();
            CarregarCombos();
            textBoxCargaMaxima.KeyPress += InputHelper.ApenasNumeros;
            textBoxConsumoMedio.KeyPress += InputHelper.ApenasDecimal;
            textBoxCNH.KeyPress += InputHelper.ApenasNumeros;
            textBoxNumeroCelular.KeyPress += InputHelper.ApenasNumeros;
            textBoxDistancia.KeyPress += InputHelper.ApenasDecimal;
            textBoxPrecoPrecomb.KeyPress += InputHelper.ApenasDecimal;            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                var veiculo = new Veiculo
                {
                    Modelo = textBoxModelo.Text,
                    Placa = textBoxPlaca.Text,
                    ConsumoMedio = Convert.ToDecimal(textBoxConsumoMedio.Text),
                    CargaMaxima = Convert.ToDecimal(textBoxCargaMaxima.Text)
                };

                if (veiculoSelecionadoId == null)
                {
                    // Inserir
                    veiculoRepository.Inserir(veiculo);
                    MessageBox.Show("Veículo cadastrado!");
                }
                else
                {
                    // Atualizar
                    veiculo = new Veiculo(veiculoSelecionadoId.Value, veiculo.Modelo, veiculo.Placa, veiculo.ConsumoMedio, veiculo.CargaMaxima);
                    veiculoRepository.Atualizar(veiculo);
                    MessageBox.Show("Veículo atualizado!");
                    veiculoSelecionadoId = null;
                }

                LimparCamposVeiculo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void LimparCamposVeiculo()
        {
            textBoxModelo.Clear();
            textBoxPlaca.Clear();
            textBoxConsumoMedio.Clear();
            textBoxCargaMaxima.Clear();
            veiculoAtual = null;
        }

        private void buttonSearchVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = new VeiculoRepository().Listar();
                using (var frm = new Form2("Lista de Veículos", lista))
                {
                    if (frm.ShowDialog() == DialogResult.OK && frm.ItemSelecionado is Veiculo veiculo != false)
                    {
                        veiculoAtual = veiculo;
                        textBoxVeiculoId.Text = veiculoAtual.VeiculoId.ToString();
                        textBoxModelo.Text = veiculoAtual.Modelo;
                        textBoxPlaca.Text = veiculoAtual.Placa;
                        textBoxConsumoMedio.Text = veiculoAtual.ConsumoMedio.ToString("0.00");
                        textBoxCargaMaxima.Text = veiculoAtual.CargaMaxima.ToString("0.00");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar veículos: " + ex.Message);
            }
        }
        private void buttonEditVeiculo_Click(object sender, EventArgs e)
        {
            
            if (veiculoAtual == null)
            {
                MessageBox.Show("Selecione um veículo primeiro.");
                return;
            }

            try
            {
                veiculoAtual.Modelo = textBoxModelo.Text;
                veiculoAtual.Placa = textBoxPlaca.Text;
                veiculoAtual.ConsumoMedio = Convert.ToDecimal(textBoxConsumoMedio.Text);
                veiculoAtual.CargaMaxima = Convert.ToDecimal(textBoxCargaMaxima.Text);
                veiculoAtual.VeiculoId = Convert.ToInt32(textBoxVeiculoId.Text);

                veiculoRepository.Atualizar(veiculoAtual);
                MessageBox.Show("Veículo atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar veículo: {ex.Message}");
            }
        }

        private void buttonDeleteVeiculo_Click(object sender, EventArgs e)
        {
            if (veiculoAtual == null)
            {
                MessageBox.Show("Selecione um veículo primeiro.");
                return;
            }

            var confirmar = MessageBox.Show(
                "Tem certeza que deseja excluir este veículo?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    veiculoRepository.ExcluirLogico(veiculoAtual.VeiculoId);
                    MessageBox.Show("Veículo excluído com sucesso!");
                    LimparCamposVeiculo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir veículo: {ex.Message}");
                }
            }

        }

        private void buttonSalvarMotorista_Click(object sender, EventArgs e)
        {
            try
            {
                var motorista = new Motorista
                {
                    Nome = textBoxNomeMotorista.Text,
                    CNH = textBoxCNH.Text,
                    Telefone = textBoxNumeroCelular.Text
                };

                if (motoristaSelecionadoId == null)
                {
                    // Inserir
                    motoristaRepository.Inserir(motorista);
                    MessageBox.Show("Motorista cadastrado com sucesso!");
                }
                else
                {
                    // Atualizar
                    motorista = new Motorista
                    {
                        MotoristaId = motoristaSelecionadoId.Value,
                        Nome = motorista.Nome,
                        CNH = motorista.CNH,
                        Telefone = motorista.Telefone
                    };
                    motoristaRepository.Atualizar(motorista);
                    MessageBox.Show("Motorista atualizado com sucesso!");
                    motoristaSelecionadoId = null;
                }

                LimparCamposMotorista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void LimparCamposMotorista()
        {
            textBoxNomeMotorista.Clear();
            textBoxCNH.Clear();
            textBoxNumeroCelular.Clear();
            textBoxMotoristaId.Clear();
            motoristaAtual = null;
            motoristaSelecionadoId = null;
        }

        private void buttonEditMotorista_Click(object sender, EventArgs e)
        {
            if (motoristaAtual == null)
            {
                MessageBox.Show("Selecione um motorista primeiro.");
                return;
            }

            try
            {
                motoristaAtual.Nome = textBoxNomeMotorista.Text;
                motoristaAtual.CNH = textBoxCNH.Text;
                motoristaAtual.Telefone = textBoxNumeroCelular.Text;
                motoristaAtual.MotoristaId = Convert.ToInt32(textBoxMotoristaId.Text);

                motoristaRepository.Atualizar(motoristaAtual);
                MessageBox.Show("Motorista atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar motorista: {ex.Message}");
            }
        }

        private void buttonSearchMotorista_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = motoristaRepository.Listar();
                using (var frm = new Form2("Lista de Motoristas", lista))
                {
                    if (frm.ShowDialog() == DialogResult.OK && frm.ItemSelecionado is Motorista motorista)
                    {
                        motoristaAtual = motorista;
                        motoristaSelecionadoId = motorista.MotoristaId;

                        textBoxMotoristaId.Text = motoristaAtual.MotoristaId.ToString();
                        textBoxNomeMotorista.Text = motoristaAtual.Nome;
                        textBoxCNH.Text = motoristaAtual.CNH;
                        textBoxNumeroCelular.Text = motoristaAtual.Telefone;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar motoristas: " + ex.Message);
            }
        }

        private void buttonDeleteMotorista_Click(object sender, EventArgs e)
        {
            if (motoristaAtual == null)
            {
                MessageBox.Show("Selecione um motorista primeiro.");
                return;
            }

            var confirmar = MessageBox.Show(
                "Deseja realmente desativar este motorista?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    motoristaRepository.ExcluirLogico(motoristaAtual.MotoristaId);
                    MessageBox.Show("Motorista desativado com sucesso!");
                    LimparCamposMotorista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao desativar motorista: {ex.Message}");
                }
            }
        }

        private void buttonSalvarRota_Click(object sender, EventArgs e)
        {
            try
            {
                var rota = new Rota
                {
                    Origem = textBoxOrigem.Text,
                    Destino = textBoxDestino.Text,
                    Distancia = Convert.ToDecimal(textBoxDistancia.Text)
                };

                if (rotaSelecionadaId == null)
                {
                    rotaRepository.Inserir(rota);
                    MessageBox.Show("Rota cadastrada com sucesso!");
                }
                else
                {
                    rota.RotaId = rotaSelecionadaId.Value;
                    rotaRepository.Atualizar(rota);
                    MessageBox.Show("Rota atualizada com sucesso!");
                    rotaSelecionadaId = null;
                }

                LimparCamposRota();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void buttonEditRota_Click(object sender, EventArgs e)
        {
            if (rotaAtual == null)
            {
                MessageBox.Show("Selecione uma rota primeiro.");
                return;
            }
            try
            {
                rotaAtual.Origem = textBoxOrigem.Text;
                rotaAtual.Destino = textBoxDestino.Text;
                rotaAtual.Distancia = Convert.ToDecimal(textBoxDistancia.Text);
                rotaRepository.Atualizar(rotaAtual);
                MessageBox.Show("Rota atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar rota: {ex.Message}");
            }
        }

        private void buttonSearchRota_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = rotaRepository.Listar();
                using (var frm = new Form2("Lista de Rotas", lista))
                {
                    if (frm.ShowDialog() == DialogResult.OK && frm.ItemSelecionado is Rota rota)
                    {
                        rotaAtual = rota;
                        rotaSelecionadaId = rota.RotaId;

                        textBoxRotaId.Text = rotaAtual.RotaId.ToString();
                        textBoxOrigem.Text = rotaAtual.Origem;
                        textBoxDestino.Text = rotaAtual.Destino;
                        textBoxDistancia.Text = rotaAtual.Distancia.ToString("0.00");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar rotas: " + ex.Message);
            }
        }

        private void buttonDeleteRota_Click(object sender, EventArgs e)
        {
            if (rotaAtual == null)
            {
                MessageBox.Show("Selecione uma rota primeiro.");
                return;
            }

            var confirmar = MessageBox.Show(
                "Tem certeza que deseja excluir esta rota?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                try {                 
                    rotaRepository.ExcluirLogico(rotaAtual.RotaId);
                    MessageBox.Show("Rota excluída com sucesso!");
                    LimparCamposRota();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir rota: {ex.Message}");
                }
            }
        }
        private void LimparCamposRota()
        {
            textBoxOrigem.Clear();
            textBoxDestino.Clear();
            textBoxDistancia.Clear();
            textBoxRotaId.Clear();
            rotaAtual = null;
            rotaSelecionadaId = null;
        }

        private void buttonSavePreco_Click(object sender, EventArgs e)
        {
            try
            {
                var preco = new PrecoCombustivel
                {
                    Combustivel = textBoxCombustivelPrecomb.Text,
                    Preco = Convert.ToDecimal(textBoxPrecoPrecomb.Text),
                    DataConsulta = dateTimePickerDataConsultaPrecomb.Value
                };

                if (precoSelecionadoId == null)
                {
                    precoCombustivelRepository.Inserir(preco);
                    MessageBox.Show("Preço de combustível cadastrado!");
                }
                else
                {
                    preco.PrecoId = precoSelecionadoId.Value;
                    precoCombustivelRepository.Atualizar(preco);
                    MessageBox.Show("Preço atualizado!");
                    precoSelecionadoId = null;
                }

                LimparCamposPreco();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void buttonEditPreco_Click(object sender, EventArgs e)
        {
            if (precoAtual == null)
            {
                MessageBox.Show("Selecione um preço primeiro.");
                return;
            }
            try
            {
                precoAtual.Combustivel = textBoxCombustivelPrecomb.Text;
                precoAtual.Preco = Convert.ToDecimal(textBoxPrecoPrecomb.Text);
                precoAtual.DataConsulta = dateTimePickerDataConsultaPrecomb.Value;

                precoCombustivelRepository.Atualizar(precoAtual);
                MessageBox.Show("Preço atualizado com sucesso!");
                LimparCamposPreco();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar preço: {ex.Message}");
            }
        }

        private void buttonSearchPreco_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = precoCombustivelRepository.Listar();
                using (var frm = new Form2("Lista de Preços de Combustível", lista))
                {
                    if (frm.ShowDialog() == DialogResult.OK && frm.ItemSelecionado is PrecoCombustivel preco)
                    {
                        precoAtual = preco;
                        precoSelecionadoId = preco.PrecoId;

                        textBoxCombustivelId.Text = preco.PrecoId.ToString();
                        textBoxCombustivelPrecomb.Text = preco.Combustivel;
                        textBoxPrecoPrecomb.Text = preco.Preco.ToString("0.00");
                        dateTimePickerDataConsultaPrecomb.Value = preco.DataConsulta;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar preços: " + ex.Message);
            }
        }

        private void buttonDeletePreco_Click(object sender, EventArgs e)
        {
            if (precoAtual == null)
            {
                MessageBox.Show("Selecione um preço primeiro.");
                return;
            }

            var confirmar = MessageBox.Show(
                "Tem certeza que deseja excluir este preço?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    precoCombustivelRepository.Excluir(precoAtual.PrecoId);
                    MessageBox.Show("Preço excluído com sucesso!");
                    LimparCamposPreco();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir preço: {ex.Message}");
                }
            }
        }
        private void LimparCamposPreco()
        {
            textBoxCombustivelPrecomb.Clear();
            textBoxPrecoPrecomb.Clear();
            dateTimePickerDataChegada.Value = DateTime.Now;
            textBoxCombustivelPrecomb.Clear();
            textBoxCombustivelId.Clear();
        }

        private void buttonSaveViagem_Click(object sender, EventArgs e)
        {
            try
            {
                var viagem = new Viagem
                {
                    MotoristaId = (int)comboBoxMotoristaViagem.SelectedValue,
                    VeiculoId = (int)comboBoxVeiculoViagem.SelectedValue,
                    RotaId = (int)comboBoxRotaViagem.SelectedValue,
                    DataSaida = dateTimePickerDataSaida.Value,
                    DataChegada = dateTimePickerDataChegada.Value,
                    Situacao = textBoxSituacaoViagem.Text
                };

                if (viagemAtual == null)
                {
                    viagemRepository.Inserir(viagem);
                    MessageBox.Show("Viagem cadastrada com sucesso!");
                }
                else
                {
                    viagem.ViagemId = viagemAtual.ViagemId;
                    viagemRepository.Atualizar(viagem);
                    MessageBox.Show("Viagem atualizada com sucesso!");
                }

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void buttonEditViagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (viagemAtual == null)
                {
                    MessageBox.Show("Selecione uma viagem primeiro usando o botão de busca.");
                    return;
                }

                var confirmacao = MessageBox.Show(
                    "Tem certeza que deseja alterar esta viagem?",
                    "Confirmação de exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacao == DialogResult.No)
                    return;

                viagemAtual.MotoristaId = Convert.ToInt32(comboBoxMotoristaViagem.SelectedValue);
                viagemAtual.VeiculoId = Convert.ToInt32(comboBoxVeiculoViagem.SelectedValue);
                viagemAtual.RotaId = Convert.ToInt32(comboBoxRotaViagem.SelectedValue);
                viagemAtual.DataSaida = dateTimePickerDataSaida.Value;
                viagemAtual.DataChegada = dateTimePickerDataChegada.Value;
                viagemAtual.Situacao = textBoxSituacaoViagem.Text.Trim();

                viagemRepository.Atualizar(viagemAtual);

                MessageBox.Show("Viagem atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar viagem: {ex.Message}");
            }
        }

        private void buttonSearchViagem_Click(object sender, EventArgs e)
        {
            try
            {
                // Carrega todas as viagens ativas
                var lista = viagemRepository.ListarResumo();

                using (var frm = new Form2("Lista de Viagens", lista))
                {
                    if (frm.ShowDialog() == DialogResult.OK && frm.ItemSelecionado is Viagem viagem)
                    {
                        viagemAtual = viagem;

                        // Preenche os campos do form
                        comboBoxMotoristaViagem.SelectedValue = viagem.MotoristaId;
                        comboBoxVeiculoViagem.SelectedValue = viagem.VeiculoId;
                        comboBoxRotaViagem.SelectedValue = viagem.RotaId;

                        textBoxSituacaoViagem.Text = viagem.Situacao;
                        dateTimePickerDataSaida.Value = viagem.DataSaida;

                        if (viagem.DataChegada != null)
                            dateTimePickerDataChegada.Value = viagem.DataChegada.Value;
                        else
                            dateTimePickerDataChegada.Checked = false; // limpa se não tiver chegada
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar viagens: {ex.Message}");
            }
        }

        private void buttonDeleteViagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (viagemAtual == null)
                {
                    MessageBox.Show("Selecione uma viagem primeiro usando o botão de busca.");
                    return;
                }

                var confirmacao = MessageBox.Show(
                    "Tem certeza que deseja excluir esta viagem?",
                    "Confirmação de exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacao == DialogResult.No)
                    return;

                
                viagemRepository.Excluir(viagemAtual.ViagemId);

                MessageBox.Show("Viagem excluída com sucesso!");

                // Limpa o formulário
                comboBoxMotoristaViagem.SelectedIndex = -1;
                comboBoxVeiculoViagem.SelectedIndex = -1;
                comboBoxRotaViagem.SelectedIndex = -1;
                textBoxSituacaoViagem.Clear();
                dateTimePickerDataSaida.Value = DateTime.Now;
                dateTimePickerDataChegada.Value = DateTime.Now;
                viagemAtual = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir viagem: {ex.Message}");
            }
        }

        private void LimparCampos()
        {
            comboBoxMotoristaViagem.SelectedIndex = -1;
            comboBoxVeiculoViagem.SelectedIndex = -1;
            comboBoxRotaViagem.SelectedIndex = -1;
            dateTimePickerDataSaida.Value = DateTime.Now;
            dateTimePickerDataChegada.Value = DateTime.Now;
            textBoxSituacaoViagem.Clear();
            viagemAtual = null;
        }


        private void CarregarCombos()
        {
            var motoristaRepo = new MotoristaRepository();
            var veiculoRepo = new VeiculoRepository();
            var rotaRepo = new RotaRepository();

            comboBoxMotoristaViagem.DataSource = motoristaRepo.Listar();
            comboBoxMotoristaViagem.DisplayMember = "Nome";
            comboBoxMotoristaViagem.ValueMember = "MotoristaId";
            comboBoxMotoristaViagem.SelectedIndex = -1;

            comboBoxVeiculoViagem.DataSource = veiculoRepo.Listar();
            comboBoxVeiculoViagem.DisplayMember = "Placa";
            comboBoxVeiculoViagem.ValueMember = "VeiculoId";
            comboBoxVeiculoViagem.SelectedIndex = -1;

            comboBoxRotaViagem.DataSource = rotaRepo.Listar();
            comboBoxRotaViagem.DisplayMember = "Descricao";
            comboBoxRotaViagem.ValueMember = "RotaId";
            comboBoxRotaViagem.SelectedIndex = -1;
        }
    }
}
