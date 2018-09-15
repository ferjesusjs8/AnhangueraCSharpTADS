using Aula01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace Aula01
{
    public class DAL_Usuario : BaseDal
    {
        public DAL_Usuario(string stringConnect)
            : base(stringConnect) { }

        public int InsereUsuario(Usuario usuario)
        {

            var senha = Encryptor.MD5Hash(usuario.Senha);

            return base.executarComando($"INSERT INTO Usuario (Nome, Email, Senha) Values ('{usuario.Nome}', '{usuario.Email}', '{senha}')");
        }

        public int lerUsuario()
        {

            return 0;
        }

        public List<Usuario> ListaUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();
            DataTable lista = base.ListaDados("SELECT * FROM USUARIO");

            foreach (DataRow r in lista.Rows)
            {
                Usuario user = new Usuario();

                user.Id     = Convert.ToInt32(r["IdUsuario"].ToString());
                user.Nome   = r["Nome"].ToString();
                user.Email  = r["Email"].ToString();
                user.Senha  = r["Senha"].ToString();

                usuarios.Add(user);
            }

            return usuarios;
        }
    }
}
