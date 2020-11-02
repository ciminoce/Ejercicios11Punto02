using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ejercicios11Punto02.Datos;
using Ejercicios11Punto02.Entidades;

namespace Ejercicios11Punto02.Windows
{
    public partial class FrmCircunferencias : Form
    {
        public FrmCircunferencias()
        {
            InitializeComponent();
        }

        private RepositorioDeCircunferencias repositorio;
        private List<Circunferencia> lista;
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmCircunferenciasAE frm = new FrmCircunferenciasAE() {Text = "Nueva Circunferencia"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                Circunferencia circunferencia = frm.GetCircunferencia();
                repositorio.Agregar(circunferencia);
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, circunferencia);
                AgregarFila(r);

            }
        }

        private DataGridViewRow ConstruirFila()
        {
            var r=new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void FrmCircunferencias_Load(object sender, EventArgs e)
        {
            repositorio=new RepositorioDeCircunferencias();
            lista = repositorio.GetLista();
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var item in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, item);
                AgregarFila(r);

            }
        }
        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Circunferencia circ)
        {
            r.Cells[cmnPunto.Index].Value = circ.Centro;
            r.Cells[cmnRadio.Index].Value = circ.Radio;
            r.Cells[cmnBorde.Index].Value = circ.Borde;
            r.Cells[cmnRelleno.Index].Value = circ.Relleno;

            r.Tag = circ;

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
