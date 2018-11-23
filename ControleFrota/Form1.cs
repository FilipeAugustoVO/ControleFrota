using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFrota
{
    public partial class ControleFrota : Form
    {
        public ControleFrota()
        {
            InitializeComponent();
            //esconder Eixos.
            lblEixos.Visible = false;
            txtEixos.Visible = false;
        }

        private void ControleFrota_Load(object sender, EventArgs e)
        {
            
            try
            {
                txtCarros.Text = Properties.Settings.Default.TextoCarros;
                txtCaminhoes.Text = Properties.Settings.Default.TextoCaminhoes;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
                        
        private void lblmodelo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public class Veiculo
        {
            //criação dos metodos. Encapsulamento da variável, tornando-a privada e acessando por metodos. Propriedades auto-implementadas
            public string modelo { get; set; }
            public string placa { get; set; }
            public string km { get; set; }

            public override string ToString()
            {
                return modelo + "\t";
            }
        }

        public class Caminhao : Veiculo
        {
            public string eixo { get; set; }
        }



        private void btnCarros_Click(object sender, EventArgs e)
        {
            //esconder Eixos.
            lblEixos.Visible = false;
            txtEixos.Visible = false;
        }

        private void Limpar()
        {
            txtModelo.Clear();
            txtPlaca.Clear();
            txtKm.Clear();
            txtEixos.Clear();
        }


        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCaminhoes_Click(object sender, EventArgs e)
        {
            //exibir Eixos
            lblEixos.Visible = true;
            txtEixos.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtEixos.Text))
                {
                    Veiculo novoCarro = new Veiculo(); //instanciando a classe Veiculo


                    novoCarro.modelo = txtModelo.Text;
                    novoCarro.placa = txtPlaca.Text;
                    novoCarro.km = txtKm.Text;

                    txtCarros.AppendText(novoCarro.modelo + "\t" + novoCarro.placa + "\t" + novoCarro.km + "\n");
                    Limpar();

                }

                else

                {
                    Caminhao novoCaminhao = new Caminhao(); //instanciando a classe Veiculo


                    novoCaminhao.modelo = txtModelo.Text;
                    novoCaminhao.placa = txtPlaca.Text;
                    novoCaminhao.km = txtKm.Text;
                    novoCaminhao.eixo = txtEixos.Text;

                    txtCaminhoes.AppendText(novoCaminhao.modelo + "\t" + novoCaminhao.placa + "\t" + novoCaminhao.km + "\t" + novoCaminhao.eixo + "\n");
                    Limpar();
                }

            }
        }
        
        private void ControleFrota_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Properties.Settings.Default.TextoCarros = txtCarros.Text;
                Properties.Settings.Default.TextoCaminhoes = txtCaminhoes.Text;
                Properties.Settings.Default.Save();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}



    



