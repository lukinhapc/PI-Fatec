using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace PI
{
    class UsuarioDAO : Usuario
    {

        private string sql;
        private BD bd = new BD();

        /// <summary>
        /// insere conforme os dados do fornecedor
        /// </summary>
        /// <returns>variavel bool confirmando a insersão</returns>
        public bool insert()
        {
            sql = "INSERT INTO usuario(foto,telefone,senha,nome,usuario,cpf,email,cep) " +
                "VALUES(@foto,@telefone,@senha,@nome,@usuario,@cpf,@email,@cep);  ";

            try
            {
                bd.getConnection();
                bd.cmd = new SqlCommand(sql, bd.con);
                bd.cmd.Parameters.Add("@foto", foto);
                bd.cmd.Parameters.Add("@telefone", telefone);
                bd.cmd.Parameters.Add("@senha", senha);
                bd.cmd.Parameters.Add("@nome", nome);
                bd.cmd.Parameters.Add("@usuario", usuario);
                bd.cmd.Parameters.Add("@cpf", cpf);
                bd.cmd.Parameters.Add("@email", cep);

                bd.cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                return false;
            }
        }

        /// <summary>
        /// altera conforme os dados do fornecedor
        /// </summary>
        /// <returns>variavel bool confirmando a insersão</returns>
        public bool update()
        {
            sql = "UPDATE usuario SET foto = @foto, telefone = @telefone," +
                    "senha = @senha, nome = @nome,usuario = @usuario,email = @email,cep = @cep " +
                " WHERE nome like @nome AND cpf = @cpf ";

            try
            {
                bd.getConnection();
                bd.cmd = new SqlCommand(sql, bd.con);
                bd.cmd.Parameters.Add("@foto", foto);
                bd.cmd.Parameters.Add("@telefone", telefone);
                bd.cmd.Parameters.Add("@senha", senha);
                bd.cmd.Parameters.Add("@nome", nome);
                bd.cmd.Parameters.Add("@usuario", usuario);
                bd.cmd.Parameters.Add("@cpf", cpf);
                bd.cmd.Parameters.Add("@email", email);
                bd.cmd.Parameters.Add("@cep", cep);

                bd.cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                return false;
            }
        }

        /// <summary>
        /// deleta conforme os dados do fornecedor
        /// </summary>
        /// <returns>variavel bool confirmando a insersão</returns>
        public bool delete()
        {
            sql = "DELETE FROM usuario WHERE nome like @nome AND cpf = @cpf ";

            try
            {
                bd.getConnection();
                bd.cmd = new SqlCommand(sql, bd.con);

                bd.cmd.Parameters.Add("@nome", nome);
                bd.cmd.Parameters.Add("@cpf", cpf);

                bd.cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                return false;
            }
        }

        /// <summary>
        /// seleciona todos itens conforme os dados do fornecedor
        /// </summary>
        /// <returns>variavel bool confirmando a insersão</returns>
        public ArrayList select()
        {
            sql = "SELECT * FROM usuario WHERE nome like @nome AND cpf = @cpf ";
            ArrayList array = new ArrayList();
            try
            {
                bd.cmd = new SqlCommand(sql, bd.con);
                bd.getConnection();

                bd.cmd.Parameters.Add("@nome", nome);
                bd.cmd.Parameters.Add("@cpf", cpf);

                bd.con.Open();

                bd.dr = bd.cmd.ExecuteReader();

                while (bd.dr.Read())
                {
                    Usuario u = new Usuario();
                    u.idUsuario = Convert.ToInt32(bd.dr["id_usuario"].ToString());
                    u.nome = bd.dr["nome"].ToString();
                    u.email = bd.dr["email"].ToString();
                    u.cep = bd.dr["cep"].ToString();
                    u.foto = bd.dr["foto"].ToString();
                    u.telefone = bd.dr["telefone"].ToString();
                    u.senha = bd.dr["senha"].ToString();
                    u.usuario = bd.dr["usuario"].ToString();
                    u.cpf = bd.dr["cpf"].ToString();

                    array.Add(u);
                }

                return array;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                array.Clear();
                return array;
            }
        }
    }
}
