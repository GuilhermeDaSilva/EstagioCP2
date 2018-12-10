using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using Estagio.DAL;

namespace Estagio.DAL
{
    class LoginDaoComandos
    {
        public bool taok;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool cadastrar(String matricula, String nome, String disciplina, Int32 cargah, Boolean coord)
        {
            taok = true;
            
            cmd.CommandText = "insert into Professor values (@matricula, @nome, @disciplina, @cargah, @coordenador);";
            cmd.Parameters.AddWithValue("@matricula", matricula);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@disciplina", disciplina);
            cmd.Parameters.AddWithValue("@cargah", cargah);
            cmd.Parameters.AddWithValue("@coordenador", coord);               

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                taok = true;
            }
            catch (SqlException)
            {
                taok = false;
            }
            return taok;
        }
    }
}
