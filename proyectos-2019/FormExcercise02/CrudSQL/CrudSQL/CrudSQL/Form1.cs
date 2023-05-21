using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletoLoteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cRUD_CSHARPDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.cRUD_CSHARPDataSet.Usuarios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cramos y abrimos la conexion
            var conexion = "Data Source=DESKTOP-NPFL5BR;Initial Catalog=CRUD_CSHARP;User ID = sa;Password=ALEKZANDER2002";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            //Insertamos los datos con parametros
            SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios VALUES (@id,@nombre,@apellido,@correo,@telefono)",con);
            cmd.Parameters.AddWithValue("@id",int.Parse(txtIdUsuario.Text));
            cmd.Parameters.AddWithValue("@nombre",txtNombre.Text);
            cmd.Parameters.AddWithValue("@apellido",txtApellido.Text);
            cmd.Parameters.AddWithValue("@correo",txtCorreo.Text);
            cmd.Parameters.AddWithValue("@telefono",txtTelefono.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Usuario Agregado Exitosamente!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var conexion = "Data Source=DESKTOP-NPFL5BR;Initial Catalog=CRUD_CSHARP;User ID = sa;Password=ALEKZANDER2002";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            //Edición de Datos
            SqlCommand cmd = new SqlCommand("UPDATE Usuarios set name_usuarios=@nombre WHERE id_usuarios = @id",con);
            cmd.Parameters.AddWithValue("@id",int.Parse(txtIdUsuario.Text));
            cmd.Parameters.AddWithValue("@nombre",txtNombre.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Usuario Editado Correctamente!");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var conexion = "Data Source=DESKTOP-NPFL5BR;Initial Catalog=CRUD_CSHARP;User ID = sa;Password=ALEKZANDER2002";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Usuarios WHERE id_usuarios=@id",con);
            cmd.Parameters.AddWithValue("@id",int.Parse(txtIdUsuario.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Usuario Eliminado Correctamente");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var conexion = "Data Source=DESKTOP-NPFL5BR;Initial Catalog=CRUD_CSHARP;User ID = sa;Password=ALEKZANDER2002";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            //Buscar datos por ID
            SqlCommand cmd = new SqlCommand("SELECT id_usuarios,name_usuarios,apellido_usuarios,correo_usuarios,telefono_usuarios FROM Usuarios WHERE id_usuarios = @id",con);
            cmd.Parameters.AddWithValue("@id",int.Parse(txtIdUsuario.Text));
            if(txtIdUsuario.Text == "")
            {
                MessageBox.Show("El usuario no se ha encontrado");
            }
            else
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Usuario Encontrado con exito");
            }
        }
    }
}
