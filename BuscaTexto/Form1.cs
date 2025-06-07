using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaTexto {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void clickNovo(object sender, EventArgs e) {
            texto.Text = "";
        }

        private void clickSobre(object sender, EventArgs e) {
            MessageBox.Show(this,
               "Busca em Texto - 2025/1\n\nDesenvolvido por:\n72301104 - Ramonys Santos\n72301201 - Felipe Vandevelde\n\nProf. Virgílio Borges de Oliveira\n\nAlgoritmos e Estruturas de Dados II\nFaculdade COTEMIG\nSomente para fins didáticos.",
               "Sobre o trabalho...",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        // [F]
        private void clickAbrir(object sender, EventArgs e) {
            // Testando mudanças
            // Caixa de diálogo de abrir arquivo com filtro para extensão txt e rtf edição 
        }
        // [F]

        private void clickSair(object sender, EventArgs e) {
            Application.Exit();
        }

        // [R]
        private void clickPesquisar(object sender, EventArgs e)
        {

        }
        // [R]

        // []
        private void clickBoyerMoore(object sender, EventArgs e)
        {

        }
        // []

        // []
        private void clickForcaBruta(object sender, EventArgs e)
        {

        }
        // []

        // []
        private void clickKMP(object sender, EventArgs e)
        {

        }
        // []

        // []
        private void clickRabinKarp(object sender, EventArgs e)
        {

        }
        // []
    }
}
