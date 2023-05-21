using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using(CRUD_CSHARPEntities conexion = new CRUD_CSHARPEntities())
            {
                //Agregar un nuevo usuario
                var lst = conexion.Usuarios;
                Usuarios newUsuario = new Usuarios();
                newUsuario.id_usuarios = 3;
                newUsuario.name_usuarios = "Pedro Garcia";
                newUsuario.apellido_usuarios = "Sanches Lopez";
                newUsuario.correo_usuarios = "pedroG@gmail.com";
                newUsuario.telefono_usuarios = "945678452";
                //conexion.Usuarios.Add(newUsuario);


                //Editar los datos de la BD
                Usuarios editUser = conexion.Usuarios.Where(datos => datos.id_usuarios == 3).First();
                editUser.name_usuarios = "Renato Garcia";

                //Eliminamos la base de datos
                Usuarios removeUser = conexion.Usuarios.Find(3);
                conexion.Usuarios.Remove(removeUser);
                conexion.SaveChanges();
                //Obtenemos los datos de la bd
                foreach(var rowUsuarios in lst)
                {
                    Console.WriteLine("Tu nombre es: " + rowUsuarios.name_usuarios);
                }
                conexion.SaveChanges();
            }
                Console.Read();
        }
    }
}
