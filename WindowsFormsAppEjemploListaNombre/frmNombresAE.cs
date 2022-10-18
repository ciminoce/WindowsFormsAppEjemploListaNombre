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
    public partial class frmNombreAE : Form
    {
        public frmNombreAE()
        {
            InitializeComponent();
        }
        //Defino una lista de strings llamada nombres
        private List<string> nombres = new List<string>();

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var nombre = nombreTextBox.Text;
                nombres.Add(nombre);
                if (nombres.Count>0)
                {
                    filtrarButton.Enabled = true;
                }
                else
                {
                    filtrarButton.Enabled = false;
                }
                InicializarControles();
                cantidadTextBox.Text = nombres.Count.ToString();

            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(nombreTextBox,"Debe ingresar un nombre");
            }
            else if(nombreTextBox.Text.Length>12)
            {
                valido = false;
                errorProvider1.SetError(nombreTextBox,"Los nombres no pueden superar los 12 caracteres");
            }

            return valido;
        }

        private void InicializarControles()
        {
            nombreTextBox.Clear();
            nombreTextBox.Focus();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void mostrarListaButton_Click(object sender, EventArgs e)
        {
            frmMostrarLista frm = new frmMostrarLista() { Text = "Mostrando la lista..." };
            if (ordenarCheckBox.Checked)
            {
                var listaOrdenada = nombres.OrderBy(n => n).ToList();
                frm.SetLista(listaOrdenada);
            }
            else
            {
                frm.SetLista(nombres);//paso la lista al otro formulario
                
            }
            frm.ShowDialog(this);
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            var letra = letraTextBox.Text;
            if (letra.Length==0)
            {
                return;
            }

            var listaFiltrada = FiltrarLista(letra.ToUpper());
            frmMostrarLista frm=new frmMostrarLista(){Text = $"Mostrar lista filtrada por {letra.ToUpper()}"};
            frm.SetLista(listaFiltrada);
            frm.ShowDialog(this);


        }

        private List<string> FiltrarLista(string letra)
        {
            List<string> listaFiltrada = new List<string>();
            foreach (var nombre in nombres)
            {
                if (nombre.StartsWith(letra))
                {
                    listaFiltrada.Add(nombre);
                }
            }

            return listaFiltrada;
        }

        private void comienzanVocalButton_Click(object sender, EventArgs e)
        {
            var vocales = "AEIOU";
            var listaFiltrada = new List<string>();
            foreach (var nombre in nombres)
            {
                var letra = nombre.Substring(0, 1);//obtengo el primer caracter
                if (vocales.Contains(letra))
                {
                    listaFiltrada.Add(nombre);
                }
            }

            var frm = new frmMostrarLista() { Text = "Comienzan con Vocal" };
            frm.SetLista(listaFiltrada);
            frm.ShowDialog(this);

        }

        private void nombresInvertidosButton_Click(object sender, EventArgs e)
        {
            var listaInvertida = new List<string>();
            foreach (var nombre in nombres)
            {
                var nombreInvertido = InvertirNombre(nombre);
                listaInvertida.Add(nombreInvertido);
            }

            var frm = new frmMostrarLista() { Text = "Nombres invertidos" };
            frm.SetLista(listaInvertida);
            frm.ShowDialog(this);

        }

        private string InvertirNombre(string nombre)
        {
            var cantidadCaracteres = nombre.Length;
            var nombreInvertido = string.Empty;
            for (int i = cantidadCaracteres-1; i >= 0; i--)
            {
                nombreInvertido += nombre[i];//tomo cada caracter
            }

            return nombreInvertido;
        }
    }
}
