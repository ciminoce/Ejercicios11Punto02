using System;
using System.Windows.Forms;
using Ejercicios11Punto02.Entidades;
using Ejercicios11Punto02.Enum;

namespace Ejercicios11Punto02.Windows
{
    public partial class FrmCircunferenciasAE : Form
    {
        public FrmCircunferenciasAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboBordes();
            CargarDatosComboRellenos();
        }

        private void CargarDatosComboRellenos()
        {
            RellenoComboBox.Items.Add("Sin Relleno");
            RellenoComboBox.Items.Add("Sólido");
            RellenoComboBox.Items.Add("Degradado");
            RellenoComboBox.Items.Add("Textura");

            RellenoComboBox.SelectedIndex = 0;
        }

        private void CargarDatosComboBordes()
        {
            BordeComboBox.DataSource = System.Enum.GetValues(typeof(Borde));
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private Circunferencia circunferencia;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (circunferencia==null)
                {
                    circunferencia=new Circunferencia
                    {
                        Centro=new Punto()
                    };
                }

                circunferencia.Radio = int.Parse(RadioTextBox.Text);
                circunferencia.Centro.CoordenadaX = int.Parse(XTextBox.Text);
                circunferencia.Centro.CoordenadaY = int.Parse(YTextBox.Text);
                circunferencia.Borde =(Borde) BordeComboBox.SelectedItem;
                circunferencia.Relleno = RellenoComboBox.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            return true;
        }

        public Circunferencia GetCircunferencia()
        {
            return circunferencia;
        }
    }
}
