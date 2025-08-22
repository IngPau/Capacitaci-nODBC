using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CapacitaciónODBC
{
    public partial class Receta : Form
    {
        public Receta()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();
        void insertarEmpleado()
        {


            //cadena a insertar
            string cadena = "INSERT INTO empleados (nombre_completo, puesto, departamento) VALUES ('" + txt_nombre.Text + "', '" + txt_puesto.Text + "', '" + txt_depto.Text + "')";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Receta_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            insertarEmpleado();
            txt_depto.Text = "";
            txt_puesto.Text = "";
            txt_nombre.Text = "";

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            Consultas frm = new Consultas();
            frm.Show();
        }
    }
}
