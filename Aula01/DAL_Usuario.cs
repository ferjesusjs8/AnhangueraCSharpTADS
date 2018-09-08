using Aula01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aula01
{
    public class DAL_Usuario : BaseDal
    {
        public DAL_Usuario(string stringConnect)
            : base(stringConnect) { }

        public int InsereUsuario(Usuario usuario)
        {
            string cmd = "INSERT INTO USUARIO (nome, email, senha) VALUES ('{0}','{1}','{2}')";
            return base.executarComando(string.Format(cmd, usuario.Nome, usuario.Email, usuario.Senha));
        }

        public int lerUsuario()
        {
            
            return 0;
        }
    }

    public List<Usuario> ListaUsuario()
    {
        List<Usuario> usuarios = new List<Usuario>();

        using (con = new SqlConnection(connectionString))
        {
            con.Open();
            comando = new SqlCommand("SELECT * FROM USUARIO", con);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Usuario usuario = new Usuario();
                usuario.Id = Convert.ToInt32(reader["id"]);
                usuario.Nome = reader["nome"].ToString();
                usuario.Email = reader["email"].ToString();
                usuario.Senha = reader["senha"].ToString();

                usuarios.Add(usuario);
            }

            reader.Close();
            con.Close();
        }

        return usuarios;
    }
}
}
