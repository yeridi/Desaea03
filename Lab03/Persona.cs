using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Persona : Form
    {
        SqlConnection conn;
        public Persona(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void Persona_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sql = "SELECT * FROM People";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListato.DataSource = dt;
                dgvListato.Refresh();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sql = "Select * FROM tbl_usuario";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListato.DataSource = dt;
                dgvListato.Refresh();
            }
            else 
            {
                MessageBox.Show("La conexion esta cerrada");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String FirstName = txtNombre.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BuscarPersonaNombre";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@FirstName";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = FirstName;

                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListato.DataSource = dt;
                dgvListato.Refresh();
            }
            else {
                MessageBox.Show("La conexcion esta cerrada");
            }
        }

        private void Buscar2_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String FirstName = txtNombre.Text;
                List<PersonN> people = new List<PersonN>();
                SqlCommand command = new SqlCommand("BuscarPersonaNombre",conn);

                command.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlParameter2 = new SqlParameter();
                sqlParameter2.SqlDbType = SqlDbType.VarChar;
                sqlParameter2.ParameterName = "@FirstName";
                sqlParameter2.Value = FirstName;

                command.Parameters.Add(sqlParameter2);

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    people.Add(new PersonN
                    {
                        PersonId = dataReader["PersonId"].ToString(),
                        LastName = dataReader["LastName"].ToString(),
                        FirstName = dataReader["FirstName"].ToString(),
                        FullName = string.Concat(dataReader["FirstName"].ToString(), " ", dataReader["LastName"].ToString())
                    });
                }
                dgvListato.DataSource = people;
                dataReader.Close();
            }
            else
            {
                MessageBox.Show("La conexion esta cerrada");
            }
        }
    }

    internal class People
    {
    }
}
