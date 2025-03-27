using System;
using System.Windows.Forms;

namespace LanchoneteVirtual
{
    public class MainForm : Form
    {
        private ComboBox cbProdutos;
        private NumericUpDown numQuantidade;
        private Button btnAdicionar, btnRemover, btnVisualizar, btnFinalizar;
        private Label lblTotal;

        public MainForm()
        {
            // Configuração da Janela
            this.Text = "Lanchonete Virtual";
            this.Size = new System.Drawing.Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            // ComboBox de produtos
            cbProdutos = new ComboBox { Left = 20, Top = 20, Width = 200 };
            cbProdutos.Items.AddRange(new string[] { "X-Burguer", "Refrigerante", "Sorvete" });
            this.Controls.Add(cbProdutos);

            // Campo de quantidade
            numQuantidade = new NumericUpDown { Left = 230, Top = 20, Width = 50 };
            numQuantidade.Minimum = 1;
            this.Controls.Add(numQuantidade);

            // Botões
            btnAdicionar = new Button { Left = 20, Top = 60, Width = 100, Text = "Adicionar" };
            btnRemover = new Button { Left = 130, Top = 60, Width = 100, Text = "Remover" };
            btnVisualizar = new Button { Left = 240, Top = 60, Width = 120, Text = "Visualizar Pedido" };
            btnFinalizar = new Button { Left = 20, Top = 100, Width = 100, Text = "Finalizar" };

            this.Controls.Add(btnAdicionar);
            this.Controls.Add(btnRemover);
            this.Controls.Add(btnVisualizar);
            this.Controls.Add(btnFinalizar);

            // Label do total
            lblTotal = new Label { Left = 20, Top = 140, Width = 200, Text = "Total: R$ 0,00" };
            this.Controls.Add(lblTotal);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
