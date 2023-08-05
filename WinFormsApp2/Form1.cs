using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<Cliente> Clientes = new List<Cliente>();
        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e )
        {

            try
            {
                Cliente cliente = new Cliente(Convert.ToInt32(txtId.Text),
                            txtNome.Text);

                MessageBox.Show($"Cliente adicionado com sucesso\n{cliente.Id}:{cliente.Nome}",
                    "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clientes.Add(cliente);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"{ex.HResult} - Formato inválido!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.HResult} - {ex.Message}");
            }

            txtNome.Clear();
            txtNome.Clear();
            txtNome.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var cliente in Clientes)
            {
                //MessageBox.Show(${cliente.Id):{cliente.Nome}")
                lstClientes.Items.Add($"{cliente.Id}-{cliente.Nome}");

            }

            Clientes[2].Nome = "Projeto";
            MessageBox.Show(Clientes[2].Nome);
        }
    }
}

