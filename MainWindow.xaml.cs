using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Atividade1e2
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txtAcesso.Focus();
        }

        private void txtAcesso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                pwSenha.Focus();
            }
        }

        private void pwSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Button_Click(sender, e);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string senha = pwSenha.Password.ToString();
            string acesso = txtAcesso.Text;

            if (acesso == "João" && senha == "joao")
            {
                MessageBox.Show("Acesso feito com sucesso!");
                InicioWindow inicio = new InicioWindow();
                inicio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erro no Login!", "ERRO", MessageBoxButton.OK, MessageBoxImage.Error);
                pwSenha.Clear();
                txtAcesso.Clear();
                txtAcesso.Focus();
            }
        }
    }
}
