using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEjemploListaNombre
{
    public partial class frmMostrarLista : Form
    {
        public frmMostrarLista()
        {
            InitializeComponent();
        }

        private List<string> lista;

        private void cerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetLista(List<string> nombres)
        {
            lista = nombres;
        }

        private void frmMostrarLista_Load(object sender, EventArgs e)
        {
            //si no tengo nada me voy
            if (lista.Count==0)
            {
                return;
            }
            //Si tengo nombres, muestro la lista
           MostrarLista();

        }

        private void MostrarLista()
        {
            foreach (string nombre in lista)
            {
                //Crear una fila en blanco
                var r = ConstruirFila();
                SetearFila(r, nombre);
                AgregarFila(r);


            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            datosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, string nombre)
        {
            r.Cells[colNombre.Index].Value = nombre;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(datosDataGridView);
            return r;
        }
    }
}
