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
                if (repositorio.Agregar(circunferencia))
                {
                    DataGridViewRow r = ConstruirFila();
                    SetearFila(r, circunferencia);
                    AgregarFila(r);
                    MessageBox.Show("Registro agregado", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error al intentar agregar un registro");
                }

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
            r.Cells[cmnPerimetro.Index].Value = circ.GetPerimetro();
            r.Cells[cmnSuperficie.Index].Value = circ.GetSuperficie();

            r.Tag = circ;

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count==0)
            {
                return;
            }

            DataGridViewRow r = dgvDatos.SelectedRows[0];
            Circunferencia circunferencia = (Circunferencia) r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja la circunferencia de radio {circunferencia.Radio} seleccionada?",
                "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }

            if (repositorio.Borrar(circunferencia))
            {
                dgvDatos.Rows.Remove(r);
                MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al intentar borrar un registro");
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count==0)
            {
                return;
            }

            DataGridViewRow r = dgvDatos.SelectedRows[0];
            Circunferencia circunferencia = (Circunferencia) r.Tag;
            Circunferencia circVieja = (Circunferencia) circunferencia.Clone();
            FrmCircunferenciasAE frm = new FrmCircunferenciasAE() {Text = "Edición de Circ"};
            frm.SetCircunferencia(circunferencia);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                circunferencia = frm.GetCircunferencia();
                if (repositorio.Editar(circVieja, circunferencia))
                {
                    SetearFila(r,circunferencia);
                    MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error al intentar editar una circ");
                    SetearFila(r,circVieja);
                }
            }

        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenarPorCoordenadaXDelCentro();
            MostrarDatosEnGrilla();
        }
    }
}
