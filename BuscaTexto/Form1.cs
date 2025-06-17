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
        private String path = "";

        public Form1() {
            InitializeComponent();
        }

        private void clickNovo(object sender, EventArgs e) {
            texto.Text = "";
            path = "";
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
            if (OPFile.ShowDialog() == DialogResult.OK)
            {
                abrirArquivo(OPFile.FileName);
            }
        }

        public void abrirArquivo(string path)
        {
            this.path = path;
            try
            {
                StreamReader s = new StreamReader(path);

                texto.Text = s.ReadToEnd();
                s.Close();
            }
            catch (Exception eX)
            {
                this.path = "";
                MessageBox.Show("Erro ao abrir arquivo. " + eX.Message);
            }
        }

        private void clickSalvar(object sender, EventArgs e)
        {
            if(!path.Equals(""))
            {
                salvarArquivo(path);
            } else if (SVFile.ShowDialog() == DialogResult.OK)
            {
                salvarArquivo(SVFile.FileName);
            }
        }

        private void clickSalvarComo(object sender, EventArgs e)
        {
            if (SVFile.ShowDialog() == DialogResult.OK)
            {
                salvarArquivo(SVFile.FileName);
            }
        }

        private void salvarArquivo(string path)
        {
            this.path = path;
            try
            {
                StreamWriter r = new StreamWriter(path);
                r.WriteLine(texto.Text);
                r.Close();
            }
            catch (IOException eX)
            {
                this.path = "";
                MessageBox.Show("Erro ao gravar o arquivo. " + eX.Message);
            }
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
                ExecutarBusca(padrao, textoInformado, BuscaForcaBruta.forcaBruta);
            }
            else if (btnKMP.Checked)
            {
                ExecutarBusca(padrao, textoInformado, BuscaKMP.KMPSearch);
            }
            else
            {
                ExecutarBusca(padrao, textoInformado, BuscaRabinKarp.RKSearch);
            }
        }
        // [R]

        private void ExecutarBusca(string padrao, string textoInformado, Func<string, string, int> algoritmoBusca)
        {
            int posicaoModificado = 0, posicao = 0;
            String textoModificado = textoInformado; 
            while(posicaoModificado != -1)
            {
                if(!textoModificado.Equals(""))
                    posicaoModificado = algoritmoBusca(padrao, textoModificado);
                else
                    posicaoModificado = -1;
                if (posicaoModificado != -1)
                {
                    posicao += posicaoModificado;
                    textoModificado = textoModificado.Substring(posicaoModificado + padrao.Length, textoModificado.Length - (posicaoModificado + padrao.Length));
                    texto.Select(posicao, padrao.Length);
                    texto.SelectionBackColor = Color.Yellow;
                    texto.SelectionStart = posicao + padrao.Length;
                    texto.ScrollToCaret();
                    posicao += padrao.Length;
                }
            }
        }

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

        // [F]
        private void clickCaseSensitive(object sender, EventArgs e)
        {
            btnCaseSensitive.Checked = !btnCaseSensitive.Checked;
        }

        private void clickCoringa(object sender, EventArgs e)
        {
            btnCoringa.Checked = !btnCoringa.Checked;
        }
        // [F]
    }
}
