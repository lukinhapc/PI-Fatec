using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace PI
{
    class ServicosDAO:Servicos
    {

        private string sql;
        private BD bd = new BD();

        /// <summary>
        /// insere conforme os dados do fornecedor
        /// </summary>
        /// <returns>variavel bool confirmando a insersão</returns>
        public bool insert()
        {
            sql = "INSERT INTO servicos(descricao,categoria,preco,id_fornecedor) " +
                "VALUES(@descricao,@categoria,@preco,@id_fornecedor);  ";

            try
            {
                bd.getConnection();
                bd.cmd = new SqlCommand(sql, bd.con);
                bd.cmd.Parameters.Add("@descricao", descricao);
                bd.cmd.Parameters.Add("@categoria", categoria);
                bd.cmd.Parameters.Add("@preco", preco);
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

        /// <summary>
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
        }

        /// <summary>
        /// deleta conforme os dados do fornecedor
        /// </summary>
        /// <returns>variavel bool confirmando a insersão</returns>
        public bool delete()
        {
            sql = "DELETE FROM servicos WHERE id_servicos = @id_servicos ";

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
        }

        /// <summary>
        /// seleciona todos itens conforme os dados do fornecedor
        /// </summary>
        /// <returns>variavel bool confirmando a insersão</returns>
        public ArrayList select()
        {
            sql = "SELECT * FROM servicos";
            ArrayList array = new ArrayList();
            try
            {
                bd.cmd = new SqlCommand(sql, bd.con);
                bd.getConnection();
           
                bd.con.Open();

                bd.dr = bd.cmd.ExecuteReader();

                while (bd.dr.Read())
                {
                    Servicos f = new Servicos();
                    f.idFornecedor = Convert.ToInt32(bd.dr["id_fornecedor"].ToString());
                    f.idServicos = Convert.ToInt32(bd.dr["id_servicos"].ToString());
                    f.descricao = bd.dr["descricao"].ToString();
                    f.categoria = bd.dr["categoria"].ToString();
                    f.preco = Convert.ToDouble(bd.dr["preco"].ToString());

                    array.Add(f);
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
