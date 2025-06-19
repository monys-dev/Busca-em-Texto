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
using System.Threading;
using System.Diagnostics;

namespace BuscaTexto {
    public partial class Form1 : Form {
        private string path = "";

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
        

        private void clickSair(object sender, EventArgs e) {
            Application.Exit();
        }

        
        private void clickPesquisar(object sender = null, EventArgs e = null)
        {
            string textoInformado = texto.Text;
            string padrao = texto.SelectedText;

            if (string.IsNullOrWhiteSpace(textoInformado))
            {
                MessageBox.Show(this, "O texto base está vazio", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(padrao))
            {
                padrao = Interaction.InputBox("Digite o texto a ser pesquisado:", "Padrão da pesquisa");

                if (string.IsNullOrWhiteSpace(padrao))
                    return;
            }

            if (!btnCaseSensitive.Checked)
            {
                textoInformado = textoInformado.ToLower();
                padrao = padrao.ToLower();
            }

            if (btnBoyerMoore.Checked)
            {
                ExecutarBusca(padrao, textoInformado, BuscaBoyerMoore.BMSearch, e == null ? 1: 0);
            }
            else if (btnForcaBruta.Checked)
            {
                ExecutarBusca(padrao, textoInformado, BuscaForcaBruta.forcaBruta, e == null ? 1 : 0);
            }
            else if (btnKMP.Checked)
            {
                ExecutarBusca(padrao, textoInformado, BuscaKMP.KMPSearch, e == null ? 1 : 0);
            }
            else
            {
                ExecutarBusca(padrao, textoInformado, BuscaRabinKarp.RKSearch, e == null ? 1 : 0);
            }
        }        

        private void clickSubstituir(object sender, EventArgs e)
        {
            clickPesquisar();
        }

        private void substituirTexto(string[] textosEncontrados, int vezes)
        {
            string substituido = Interaction.InputBox("Digite o texto a ser substituido:", "Substituição");
            if (string.IsNullOrWhiteSpace(substituido))
                return;

            for (int i = 0; i < vezes; i++)
            {
                string s = textosEncontrados[i];
                texto.Text = texto.Text.Replace(s, substituido);
            }
            refreshTela(texto);
        }

        private void ExecutarBusca(string padrao, string textoInformado, Func<string, string, Tuple<int, int>> algoritmoBusca, int result)
        {
            string line = "\n____________________________________________\n\n";
            var stopwatch = new Stopwatch();
            int posicaoModificado = 0, posicao = 0, vezes = 0, totalTestes = 0;
            string posicoes = "";
            string textoModificado = textoInformado;
            string[] encontrados = new string[Text.Length];

            stopwatch.Start();
            while(posicaoModificado != -1)
            {
                if (!textoModificado.Equals(""))
                {
                    Tuple<int, int> resultado = algoritmoBusca(padrao, textoModificado);
                    posicaoModificado = resultado.Item1;
                    totalTestes += resultado.Item2;
                }
                else
                    posicaoModificado = -1;
                if (posicaoModificado != -1)
                {
                    posicao += posicaoModificado;
                    posicoes += "(" + posicao.ToString() + $" -> {posicao + padrao.Length - 1})" + ", ";
                    textoModificado = textoModificado.Substring(posicaoModificado + padrao.Length, textoModificado.Length - (posicaoModificado + padrao.Length));
                    encontrados[vezes] = texto.Text.Substring(posicao, padrao.Length);
                    texto.Select(posicao, padrao.Length);
                    texto.SelectionBackColor = Color.Yellow;
                    vezes++;
                    Thread.Sleep(300);
                    texto.SelectionStart = posicao + padrao.Length;
                    texto.ScrollToCaret();
                    posicao += padrao.Length;
                }
            }
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            texto.SelectionBackColor = Color.White;
            if(posicao != 0)
                MessageBox.Show(this, $"Padrão encontrado {vezes} vezes, nas posições:\n {posicoes.Substring(0, posicoes.Length-2)}" +
                $"{line + totalTestes} testes, " +
                $"{String.Format("execução em {0:F4} seg", elapsed_time / 1000.0)}", "Busca concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show(this, $"Padrão não foi encontrado." +
                    $"{line + totalTestes} testes, " +
                $"{String.Format("execução em {0:F4} seg", elapsed_time / 1000.0)}", "Busca concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshTela(texto);
                return;
            }

            if(result == 0)
            {
                result = ((int)Interaction.MsgBox("Deseja substituir?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Substituição"));
                if (result == 7)
                {
                    refreshTela(texto);
                    return;
                }
            }

            substituirTexto(encontrados, vezes);
        }

        private void refreshTela(RichTextBox rtx)
        {
            string textoEmTela = rtx.Text;
            rtx.ResetText();
            rtx.Text = textoEmTela;
            rtx.SelectionStart = int.MaxValue;
        }

        
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
        

        
        private void clickCaseSensitive(object sender, EventArgs e)
        {
            btnCaseSensitive.Checked = !btnCaseSensitive.Checked;
        }

        private void clickCoringa(object sender, EventArgs e)
        {
            btnCoringa.Checked = !btnCoringa.Checked;
            BuscaForcaBruta.setCoringa(btnCoringa.Checked);
            if (btnCoringa.Checked)
            {
                btnBoyerMoore.Enabled = false;
                btnKMP.Enabled = false;
                btnRabinKarp.Enabled = false;
                btnForcaBruta.Checked = true;
                btnBoyerMoore.Checked = false;
            }
            else
            {
                btnBoyerMoore.Enabled = true;
                btnForcaBruta.Enabled = true;
                btnKMP.Enabled = true;
                btnRabinKarp.Enabled = true;
            }
        }
        
    }
}
