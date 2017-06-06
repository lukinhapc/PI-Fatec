using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace PI{
    class FornecedorDAO: Fornecedor{

        private string sql;
        private BD bd = new BD();

        /// <summary>
        /// insere conforme os dados do fornecedor
        /// </summary>
        /// <returns>variavel bool confirmando a insersão</returns>
        public bool insert(){
            sql = "INSERT INTO fornecedor(foto,telefone,senha,nome,usuario,cpf,email,cep) "+
                "VALUES(@foto,@telefone,@senha,@nome,@usuario,@cpf,@email,@cep);  ";

            try
            {
                bd.getConnection();
                bd.con.Open();
                bd.cmd = new SqlCommand(sql,bd.con);
                bd.cmd.Parameters.Add("@foto",foto);
                bd.cmd.Parameters.Add("@telefone", telefone);
                bd.cmd.Parameters.Add("@senha", senha);
                bd.cmd.Parameters.Add("@nome", nome);
                bd.cmd.Parameters.Add("@usuario", usuario);
                bd.cmd.Parameters.Add("@cpf", cpf);
                bd.cmd.Parameters.Add("@email", email);
                bd.cmd.Parameters.Add("@cep", cep);

                bd.cmd.ExecuteNonQuery();

                return true;
            }catch (Exception e){
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
            sql = "UPDATE fornecedor SET foto = @foto, telefone = @telefone,"+
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
            sql = "DELETE FROM fornecedor WHERE nome like @nome AND cpf = @cpf ";

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
            sql = "SELECT * FROM fornecedor WHERE nome like @nome AND cpf like @cpf ";
            ArrayList array = new ArrayList();
            try
            {
                bd.getConnection();
                bd.con.Open();
                bd.cmd = new SqlCommand(sql, bd.con);
                

                bd.cmd.Parameters.Add("@nome", "%"+nome+ "%" );
                bd.cmd.Parameters.Add("@cpf", "%" + cpf +"%");
 
                 

                bd.dr = bd.cmd.ExecuteReader();

                while (bd.dr.Read())
                {
                    Console.Write("Cara foi!");
                    Fornecedor f = new Fornecedor();
                    f.idFornecedor = Convert.ToInt32(bd.dr["id_fornecedor"].ToString());
                    f.nome = bd.dr["nome"].ToString();
                    f.email = bd.dr["email"].ToString();
                    f.cep = bd.dr["cep"].ToString();
                    f.foto = bd.dr["foto"].ToString();
                    f.telefone = bd.dr["telefone"].ToString();
                    f.senha = bd.dr["senha"].ToString();
                    f.usuario = bd.dr["usuario"].ToString();
                    f.cpf = bd.dr["cpf"].ToString();

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
