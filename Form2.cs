using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogisticaApp.Repositorios;
using Sistema_Logistico.Entidades;

namespace Sistema_Logistico
{
    public partial class Form2 : Form
    {
        
        public object ItemSelecionado { get; private set; }
        public Form2(string titulo, object dados)
        {
            InitializeComponent();
            Text = titulo;

            // Define o DataSource dinamicamente
            dataGridView1.DataSource = dados;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ItemSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
