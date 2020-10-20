using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaPilas
{
    public partial class Form1 : Form
    {

        EmpresaOrgEventosSociales EmpresaNueva;//Objeto Rojo

        ClasePilaDinamica<EmpresaOrgEventosSociales> PilaEmpresa = new ClasePilaDinamica<EmpresaOrgEventosSociales>();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgDatosEmpleado.Columns.Add("Nombre de Empresa", "Nombre de Empresa");
            dtgDatosEmpleado.Columns.Add("No. Empleados", "No. Empleados");
            dtgDatosEmpleado.Columns.Add("Rank en FB", "Rank en FB");
            dtgDatosEmpleado.Columns.Add("Sueldo Empleados", "Sueldo Empleados");
            dtgDatosEmpleado.Columns.Add("Seguro", "Seguro");
            dtgDatosEmpleado.Columns.Add("Fecha de Apertura", "Fecha de Apertura");

            dtgDatosEmpleado.AllowUserToAddRows = false;
            dtgDatosEmpleado.AllowUserToDeleteRows = false;
            dtgDatosEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatosEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatosEmpleado.MultiSelect = false;
            dtgDatosEmpleado.ReadOnly = true;
        }

        public void AgregarALista()
        {

            dtgDatosEmpleado.Rows.Clear();
            foreach (EmpresaOrgEventosSociales miEmpresa in PilaEmpresa)
            {
                dtgDatosEmpleado.Rows.Add(miEmpresa.NombreEmpresa, miEmpresa.NumEmpleados, miEmpresa.RankDeCalidad, miEmpresa.SueldoEmpleados, miEmpresa.CuentaConSeguroParaEmpleados ? "Si" : "No", miEmpresa.FechaAperturaEmpresa);
            }


        }
        private void btnAgregarDatos_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea agregar los datos de la Empresa a la lista?", "Agregado a la lista.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    EmpresaNueva = new EmpresaOrgEventosSociales();

                    EmpresaNueva.NombreEmpresa = txtNombreEmpresa.Text;
                    EmpresaNueva.NumEmpleados = int.Parse(txtNumEmpleados.Text);
                    EmpresaNueva.RankDeCalidad = char.Parse(cboRank.Text);
                    if (rad15k.Checked)
                    {
                        EmpresaNueva.SueldoEmpleados = 15000;
                    }
                    if (rad20k.Checked)
                    {
                        EmpresaNueva.SueldoEmpleados = 20000;
                    }

                    EmpresaNueva.CuentaConSeguroParaEmpleados = chkSeguro.Checked;


                    EmpresaNueva.FechaAperturaEmpresa = dtmFechaApertura.Value;

                    PilaEmpresa.Push(EmpresaNueva);
                    AgregarALista();
                    break;
                case DialogResult.No:
                    break;
            }
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("¿Desea buscar la empresa seleccionada?", "Buscar datos.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    EmpresaOrgEventosSociales objTemp = new EmpresaOrgEventosSociales();

                    string y = "";

                    objTemp.NombreEmpresa = dtgDatosEmpleado.CurrentRow.Cells[0].Value.ToString();
                    objTemp.NumEmpleados = int.Parse(dtgDatosEmpleado.CurrentRow.Cells[1].Value.ToString());
                    objTemp.RankDeCalidad = char.Parse(dtgDatosEmpleado.CurrentRow.Cells[2].Value.ToString());
                    objTemp.SueldoEmpleados = double.Parse(dtgDatosEmpleado.CurrentRow.Cells[3].Value.ToString());
                    objTemp.FechaAperturaEmpresa = DateTime.Parse(dtgDatosEmpleado.CurrentRow.Cells[5].Value.ToString());
                    if (((dtgDatosEmpleado.CurrentRow.Cells[4].Value.ToString()) == "Si"))
                    {
                        objTemp.CuentaConSeguroParaEmpleados = true;
                        y += "Si.";
                    }
                    if (((dtgDatosEmpleado.CurrentRow.Cells[4].Value.ToString()) == "No"))
                    {
                        objTemp.CuentaConSeguroParaEmpleados = false;
                        y += "No.";
                    }

                    var x = PilaEmpresa.BuscarNodo(objTemp);
                    MessageBox.Show("Nombre de la Empresa:" + x.NombreEmpresa + "\nNumero de Empleados:" + x.NumEmpleados + "\nRanking:" + x.RankDeCalidad +
                        "\nSueldo de Empleados:" + x.SueldoEmpleados + "\nFecha de Apertura:" + x.FechaAperturaEmpresa + "\nCuenta con seguro para empleados:" + y.ToString(), "Datos encontrados.");

                    break;
                case DialogResult.No:
                    break;
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar la empresa seleccionada?", "Eliminar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    EmpresaOrgEventosSociales objTemp = new EmpresaOrgEventosSociales();



                    objTemp.NombreEmpresa = dtgDatosEmpleado.CurrentRow.Cells[0].Value.ToString();
                    objTemp.NumEmpleados = int.Parse(dtgDatosEmpleado.CurrentRow.Cells[1].Value.ToString());
                    objTemp.RankDeCalidad = char.Parse(dtgDatosEmpleado.CurrentRow.Cells[2].Value.ToString());
                    objTemp.SueldoEmpleados = double.Parse(dtgDatosEmpleado.CurrentRow.Cells[3].Value.ToString());
                    objTemp.FechaAperturaEmpresa = DateTime.Parse(dtgDatosEmpleado.CurrentRow.Cells[5].Value.ToString());
                    if (((dtgDatosEmpleado.CurrentRow.Cells[4].Value.ToString()) == "Si"))
                    {
                        objTemp.CuentaConSeguroParaEmpleados = true;
                    }
                    if (((dtgDatosEmpleado.CurrentRow.Cells[4].Value.ToString()) == "No"))
                    {
                        objTemp.CuentaConSeguroParaEmpleados = false;
                    }
            
                    PilaEmpresa.Pop(objTemp);
                    AgregarALista();

                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea vaciar la lista de empresas?", "Vaciado de lista.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    PilaEmpresa.Vaciar();
                    AgregarALista();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            string strNombreArchivo = CargarImagen();
            if (strNombreArchivo != null)
                MostrarImagen(strNombreArchivo);
        }

        private string CargarImagen()
        {
            string strNombreArchivo = null;
            // Declaración de variable para seleccionar el archivo
            OpenFileDialog miArchivoFoto = new OpenFileDialog();
            miArchivoFoto.Title = "Seleccione la imagen que desea cargar";
            miArchivoFoto.Filter = "Archivos JPEG (*.jpg) | *.jpg";
            miArchivoFoto.InitialDirectory = "Mis documentos";
            if (miArchivoFoto.ShowDialog() == DialogResult.OK)
            {
                strNombreArchivo = miArchivoFoto.FileName;
                return (strNombreArchivo);
            }
            else return (null);
        }

        private void MostrarImagen(string strNombreArchivo)
        {
            Bitmap miImagen = new Bitmap(strNombreArchivo);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoto.Image = (Image)miImagen;
            picFoto.Refresh();
        }

        private void btnUltEmpresa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea eliminar la última empresa agregada?", "Vaciado de lista.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    PilaEmpresa.Pop();
                    AgregarALista();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
