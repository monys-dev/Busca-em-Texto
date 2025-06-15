using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BuscaTexto
{
    public class InputBoxDialog : Form
    {
        private TextBox textBox;
        private Button okButton;
        private Button cancelButton;

        public InputBoxDialog(string prompt, string title, string defaultValue)
        {
            // Configurações do Form
            this.Text = title;
            this.Width = 300;
            this.Height = 150;

            // Criação do TextBox
            textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(10, 20);
            textBox.Size = new System.Drawing.Size(270, 20);
            textBox.Text = defaultValue;
            this.Controls.Add(textBox);

            // Criação do botão OK
            okButton = new Button();
            okButton.Location = new System.Drawing.Point(60, 50);
            okButton.Text = "OK";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Click += new System.EventHandler(okButton_Click);
            this.Controls.Add(okButton);

            // Criação do botão Cancelar
            cancelButton = new Button();
            cancelButton.Location = new System.Drawing.Point(150, 50);
            cancelButton.Text = "Cancelar";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Click += new System.EventHandler(cancelButton_Click);
            this.Controls.Add(cancelButton);

            // Configurações do Form
            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;

        }

        private string _input;
        public string InputValue
        {
            get
            {
                return _input;
            }
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            _input = textBox.Text;
            this.Close();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            _input = null;
            this.Close();
        }

        public static string ShowDialog(string prompt, string title, string defaultValue)
        {
            InputBoxDialog inputBox = new InputBoxDialog(prompt, title, defaultValue);
            inputBox.ShowDialog();

            return inputBox.InputValue;
        }
    }
}
