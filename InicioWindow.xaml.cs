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
using System.Windows.Shapes;

namespace Atividade1e2
{
    /// <summary>
    /// Lógica interna para InicioWindow.xaml
    /// </summary>
    public partial class InicioWindow : Window
    {
        public InicioWindow()
        {
            InitializeComponent();
            Loaded += InicioWindow_Loaded;
        }

        private void InicioWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txtAltura.Focus();
        }

        private void txtAltura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtPeso.Focus();
            }
        }

        private void txtPeso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                btCalcular_Click(sender, e);
            }
        }

        private void btCalcular_Click(object sender, RoutedEventArgs e)
        {
            double resultado, peso, altura;

            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);

            resultado = peso / (altura * altura);

            txtResultado.Text = resultado.ToString();

            if(resultado < 18.5)
            {
                MessageBox.Show("Abaixo do peso", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if(resultado >= 18.5 && resultado <= 24.9)
            {
                MessageBox.Show("Peso normal", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if(resultado >= 25 && resultado <= 29.9)
            {
                MessageBox.Show("Sobrepeso", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if(resultado >= 30 && resultado <= 34.9)
            {
                MessageBox.Show("Obesidade grau 1", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if(resultado >= 35 && resultado <= 39.9)
            {
                MessageBox.Show("Obesidade grau 2", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if(resultado >= 40)
            {
                MessageBox.Show("Obesidade grau 3 ou mórbida", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            txtAltura.Clear();
            txtPeso.Clear();
            txtResultado.Clear();
            txtAltura.Focus();
        }
    }
}
