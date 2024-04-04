using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_I
{
    public partial class Form1 : Form
    {
        //Cargar listas
        List<Alumno> alumnos = new List<Alumno>();
        List<Taller> talleres = new List<Taller>();
        List<Inscripcion> inscripciones = new List<Inscripcion>();
        List<Reporte> reportes = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
        }

        public void CargarAlumnos()
        {
            //Leer el archivo y cargarlo a la lista
            string fileName = "Alumnos.txt";

            //Abrimos el archivo, en este caso lo abrimos para lectura
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //Un ciclo para leer el archivo hasta el final del archivo
            while (reader.Peek() > -1)
            {
                //Leer los datos de un alumno
                Alumno alumno = new Alumno();
                alumno.Dpi = Convert.ToInt32(reader.ReadLine());
                alumno.Nombre = reader.ReadLine();
                alumno.Direccion = Convert.ToInt32(reader.ReadLine());

                //Guardar al alumno en la lista de alumnos
                alumnos.Add(alumno);
            }
            reader.Close();
        }

        public void CargarTalleres()
        {
            //Leer el archivo y cargarlo a la lista
            string fileName = "Talleres.txt";

            //Abrimos el archivo, en este caso lo abrimos para lectura
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //Un ciclo para leer el archivo hasta el final del archivo
            while (reader.Peek() > -1)
            {
                //Leer los datos de un taller
                Taller taller = new Taller();
                taller.Codigo = Convert.ToInt32(reader.ReadLine());
                taller.Nombre = reader.ReadLine();
                taller.Costo = Convert.ToInt32(reader.ReadLine());

                //Guardar al taller en la lista de talleres
                talleres.Add(taller);
            }
            reader.Close();
        }

        public void MostrarInscripcion()
        {
            //Mostrar la lista de alumnos en el DataGridView
            dataGridView.DataSource = null;
            dataGridView.DataSource = inscripciones;
            dataGridView.Refresh();
        }

        public void MostrarReporte()
        {
            //Mostrar la lista de reportes en el DataGridView
            dataGridView.DataSource = null;
            dataGridView.DataSource = reportes;
            dataGridView.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
            CargarTalleres();

            comboBoxAlumno.DisplayMember = "Nombre";
            comboBoxAlumno.ValueMember = "Dpi";
            comboBoxAlumno.DataSource = alumnos;

            comboBoxTaller.DisplayMember = "Nombre";
            comboBoxTaller.ValueMember = "Codigo";
            comboBoxTaller.DataSource = talleres;
        }

        private void GrabarInscripciones()
        {
            FileStream stream = new FileStream("Inscripciones.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var inscripcion in inscripciones)
            {
                writer.WriteLine(inscripcion.Dpi);
                writer.WriteLine(inscripcion.Codigo);
                writer.WriteLine(inscripcion.Fecha);
            }
            writer.Close();
        }

        private void buttonIngresarDatos_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.Dpi = Convert.ToInt32(comboBoxAlumno.SelectedValue);
            inscripcion.Codigo = Convert.ToInt32(comboBoxTaller.SelectedValue);
            inscripcion.Fecha = DateTime.Now;

            inscripciones.Add(inscripcion);
            GrabarInscripciones();
            MostrarInscripcion();
        }

        private void comboBoxAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dpi = Convert.ToInt16(comboBoxAlumno.SelectedValue);
        }

        private void comboBoxTaller_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt16(comboBoxTaller.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ya deben estar llenas todas las listas
            reportes.Clear();
            //Recorre cada departamento
            foreach (var alumno in alumnos)
            {
                foreach (var inscripcion in inscripciones)
                {
                    if (alumno.Dpi == inscripcion.Dpi)
                    {
                        Reporte reporte = new Reporte();
                        reporte.Nombre = alumno.Nombre;
                        reporte.Taller = Convert.ToString(inscripcion.Codigo);

                        reportes.Add(reporte);
                    }
                }
            }
            MostrarReporte();
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            //Ordenar de forma ascendente
            reportes = reportes.OrderBy(p => p.Taller).ToList();

            MostrarReporte();
        }

        private void buttonCantidadEstudiantes_Click(object sender, EventArgs e)
        {

        }
    }
}
