using ModeloDesSoftware.Repositorio.Entidade;
using ModeloDesSoftware.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfModuloDesSoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IClienteRepositorio clienteRepositorio;
        public ObservableCollection<Cliente> ListClientes { get; set; }
        public MainWindow(IClienteRepositorio clienteRepositorio)
        {
            InitializeComponent();
            this.clienteRepositorio = clienteRepositorio;
        }

        private void btnInserir_Click(object sender, RoutedEventArgs e)
        {
            clienteRepositorio.Adicionar(GetCliente());
            MessageBox.Show("Cliente Cadastrado com Sucesso");
            CarregarGrid();
        }
        private void LimparCampos()
        {
            txtIdCliente.Text = String.Empty;
            txtCPFCliente.Text = String.Empty;
            txtNomeCliente.Text = String.Empty;
            txtRGCliente.Text = String.Empty;
            txtEnderecoCliente.Text = String.Empty;
            txtPrecoVendaCliente.Text = String.Empty;
            txtProdutoCliente.Text = String.Empty;
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            clienteRepositorio.Atualizar(GetCliente());
            MessageBox.Show("Cliente Atualizado com Sucesso");
            CarregarGrid();
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            var cliente = clienteRepositorio.Consultar(Convert.ToInt32(txtIdCliente.Text));
            clienteRepositorio.Excluir(cliente);
            MessageBox.Show("Cliente Excluido com Sucesso");
            CarregarGrid();
        }

        private Cliente GetCliente()
        {
            var cliente = new Cliente
            {
                IdCliente = Convert.ToInt32(txtIdCliente.Text),
                NomeCliente = txtNomeCliente.Text,
                CPF = txtCPFCliente.Text,
                RG = txtRGCliente.Text,
                Endereco = txtEnderecoCliente.Text,
                PrecoVenda = Convert.ToDecimal(txtPrecoVendaCliente.Text),
                Produto = txtProdutoCliente.Text
            };
            return cliente;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            var clienteBusca = clienteRepositorio.Consultar(Convert.ToInt32(txtIdCliente.Text));
            var list = new ObservableCollection<Cliente>
            {
                clienteBusca
            };
            GridCliente.ItemsSource = list;

            txtCPFCliente.Text = clienteBusca.CPF;
            txtNomeCliente.Text = clienteBusca.NomeCliente;
            txtRGCliente.Text = clienteBusca.RG;
            txtEnderecoCliente.Text = clienteBusca.Endereco;
            txtPrecoVendaCliente.Text = clienteBusca.PrecoVenda.ToString();
            txtProdutoCliente.Text = clienteBusca.Produto;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            LimparCampos();
            var lista = clienteRepositorio.Listar();
            ListClientes = new ObservableCollection<Cliente>(lista);
            GridCliente.ItemsSource = ListClientes;

        }
        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            CarregarGrid();
        }
    }
}
