using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace PI
{
    class ChatDAO:Chat
    {

        private string sql;
        private BD bd = new BD();

        /// <summary>
        /// insere conforme os dados do fornecedor
        /// </summary>
        /// <returns>variavel bool confirmando a insersão</returns>
        public bool insert()
        {
            sql = "INSERT INTO chat(id_mensagem,id_usuario,id_fornecedor) " +
                "VALUES(@id_mensagem,@id_usuario,@id_fornecedor);  ";

            try
            {
                bd.getConnection();
                bd.cmd = new SqlCommand(sql, bd.con);
                bd.cmd.Parameters.Add("@id_mensagem", idMensagem);
                bd.cmd.Parameters.Add("@id_usuario", idUsuario);
                bd.cmd.Parameters.Add("@id_fornecedor", idFornecedor);

                bd.cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                return false;
            }
        }

        /*
         *                  SEM UPDATE NO CHAT
         * /// <summary>
        /// altera conforme os dados do fornecedor
        /// </summary>
        /// <returns>variavel bool confirmando a insersão</returns>
        public bool update()
        {
            sql = "UPDATE servicos SET descricao = @descricao, categoria = @categoria, preco = @preco" +
                " WHERE id_servicos = @id_servicos ";

            try
            {
                bd.getConnection();
                bd.cmd = new SqlCommand(sql, bd.con);
                bd.cmd.Parameters.Add("@descricao", descricao);
                bd.cmd.Parameters.Add("@categoria", categoria);
                bd.cmd.Parameters.Add("@preco", preco);
                bd.cmd.Parameters.Add("@id_servicos", idServicos);

                bd.cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                return false;
            }
        }*/
        /*
         *                          AINDA NÃO SEI SE VAI USAR
        /// <summary>
        /// deleta conforme os dados do fornecedor
        /// </summary>
        /// <returns>variavel bool confirmando a insersão</returns>
        public bool delete()
        {
            sql = "DELETE FROM servico WHERE id_servicos = @id_servicos ";

            try
            {
                bd.getConnection();
                bd.cmd = new SqlCommand(sql, bd.con);

                bd.cmd.Parameters.Add("@id_servicos", idServicos);

                bd.cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                return false;
            }
        }*/

        /// <summary>
        /// seleciona todos itens conforme os dados do fornecedor
        /// </summary>
        /// <returns>variavel bool confirmando a insersão</returns>
        public ArrayList select()
        {
            sql = "SELECT * FROM chat";
            ArrayList array = new ArrayList();
            try
            {
                bd.cmd = new SqlCommand(sql, bd.con);
                bd.getConnection();

                bd.con.Open();

                bd.dr = bd.cmd.ExecuteReader();

                while (bd.dr.Read())
                {
                    Chat c = new Chat();
                    c.idFornecedor = Convert.ToInt32(bd.dr["id_fornecedor"].ToString());
                    c.idChat = Convert.ToInt32(bd.dr["id_chat"].ToString());
                    c.idMensagem = Convert.ToInt32(bd.dr["id_mensagem"].ToString());
                    c.idUsuario = Convert.ToInt32(bd.dr["id_usuario"].ToString());

                    array.Add(c);
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
