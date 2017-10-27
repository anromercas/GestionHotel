using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace GestionHotel.Vista
{
    public partial class Main : Form
    {
        //Datos para armar el string de conexión
        string ora_connect = "User Id=recepcion;Password=recepcion;Data Source=DATOS03;";
       // string oradb = "Data Source=OraDb;User Id=scott;Password=tiger;";
        OracleConnection con = new OracleConnection();

        public Main()
        {
            InitializeComponent();

            //Agregamos el string de conexión
            con.ConnectionString = ora_connect;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnEstancias_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        public void mostrarDatos()
        {
            try
            {
                con.Open();
                String sql = "SELECT * FROM habitaciones";
                OracleDataAdapter datos = new OracleDataAdapter(sql, con);

                DataSet data = new DataSet();
                datos.Fill(data);
                int to = data.Tables[0].Rows.Count;
                if (to > 0)
                {
                    for (int i = 0; i < to; i++)
                    {
                        tbDatos.Rows.Add(data.Tables[0].Rows[i][0], data.Tables[0].Rows[i][1],
                            data.Tables[0].Rows[i][2], data.Tables[0].Rows[i][3],
                            data.Tables[0].Rows[i][4]);
                    }
                }
                else
                {
                    MessageBox.Show("no hay nada de que mostrar");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ha ocurrido una excepción");
                return;
            }
            finally
            {
                con.Close();
            }

        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
