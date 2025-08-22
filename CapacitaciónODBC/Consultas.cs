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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        void cargar()
        {
            string cadena = "SELECT * FROM empleados";
            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conexion());
            DataTable dt = new DataTable();

            datos.Fill(dt);

            Dgv_emp.DataSource = dt;


        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {

            cargar();
        }
    }
}
