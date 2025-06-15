using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing.Drawing2D;
using System.IO;

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
            string textoInformado = texto.Text; // "texto" = RichTextBox do Form1
            string padrao = texto.SelectedText;

            if (string.IsNullOrWhiteSpace(textoInformado))
            {
                MessageBox.Show(this, "O texto base está vazio", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(padrao))
            {
                padrao = Interaction.InputBox("Digite o texto a ser pesquisado:", "Padrão da pesquisa");

                if (string.IsNullOrWhiteSpace(padrao))
                    return;
            }

            if (btnBoyerMoore.Checked)
            {
                ExecutarBusca(padrao, textoInformado, BuscaBoyerMoore.BMSearch);
                
            }
            else if (btnForcaBruta.Checked)
            {
                posicao = BuscaForcaBruta.forcaBruta(padrao, textoInformado);
            }
            else if (btnKMP.Checked)
            {
                posicao = BuscaKMP.KMPSearch(padrao, textoInformado);
            }
            else {
                posicao = BuscaRabinKarp.RKSearch(padrao, textoInformado);
            }


            if (posicao >= 0)
            {
                MessageBox.Show(this, $"Padrão encontrado na posição {posicao}.", "Resultado da busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show(this, "Padrão não encontrado.", "Resultado da busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // [R]

        private void ExecutarBusca(string padrao, string textoInformado, Func<string, string, int> algoritmoBusca)
        {
            //array de numeros
         // textoInformado.substring(posicao, padrao.Length-posicao);
         // Precisamos

            int posicao = 0;
            while(posicao != -1)
            {
                posicao = algoritmoBusca(padrao, textoInformado.Substring(posicao, textoInformado.Length - (posicao + padrao.Length)));
                int a = 1;
                //pinta as parada
            }
        }

        // [F]
        private void digitarTextoPesquisado()
        {
            
           /* string input = .InputBox("Digite um peso maior ou igual a zero", "Editar peso", null);
            if (input == "")
            {
                return "";
            } else {
                return "";
            }*/
        }
        // [F]

        // [F]
        private void clickBoyerMoore(object sender, EventArgs e)
        {
            if (!btnBoyerMoore.Checked)
            {
                btnBoyerMoore.Checked = true;
                btnForcaBruta.Checked = false;
                btnKMP.Checked = false;
                btnRabinKarp.Checked = false;
            }
        }
        // [F]

        // [F]
        private void clickForcaBruta(object sender, EventArgs e)
        {
            if (!btnForcaBruta.Checked)
            {
                btnBoyerMoore.Checked = false;
                btnForcaBruta.Checked = true;
                btnKMP.Checked = false;
                btnRabinKarp.Checked = false;
            }
        }
        // [F]

        // [F]
        private void clickKMP(object sender, EventArgs e)
        {
            if (!btnKMP.Checked)
            {
                btnBoyerMoore.Checked = false;
                btnForcaBruta.Checked = false;
                btnKMP.Checked = true;
                btnRabinKarp.Checked = false;
            }
        }
        // [F]

        // [F]
        private void clickRabinKarp(object sender, EventArgs e)
        {
            if (!btnRabinKarp.Checked)
            {
                btnBoyerMoore.Checked = false;
                btnForcaBruta.Checked = false;
                btnKMP.Checked = false;
                btnRabinKarp.Checked = true;
            }
        }
        // [F]
    }
}
