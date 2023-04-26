using Dapper;
using ProjCoopControleFinanceiro.Model;

namespace ProjCoopControleFinanceiro.Repository
{
    internal class ContaRepo : IRepo<Conta>
    {
        //TABELA_CONTAS
        public int Delete(int id)
        {
            string ssql = $"DELETE FROM {RepoConstant.TABELA_CONTAS} WHERE id = @id";
            using (var db = Connection.getConnection())
            {
                return db.Execute(ssql, new { id });
            }
        }

        public List<Conta> getAll()
        {
            string ssql = $"SELECT * FROM {RepoConstant.TABELA_CONTAS}";
            using (var db = Connection.getConnection())
            {
                return db.Query<Conta>(ssql).ToList();
            }
        }

        public Conta getByCondition(string condition, Conta value)
        {
            string ssql = $"SELECT * FROM {RepoConstant.TABELA_CONTAS} WHERE {condition}";
            using (var db = Connection.getConnection())
            {
                return db.QueryFirstOrDefault<Conta>(ssql, value);
            }
        }

        public List<Conta> getByCondition(string condition, Conta value, out int count)
        {
            string ssql = $"SELECT * FROM {RepoConstant.TABELA_CONTAS} WHERE {condition}";
            using (var db = Connection.getConnection())
            {
                var result = db.Query<Conta>(ssql, value).ToList();
                count = result.Count();
                return result;
            }
        }

        public Conta getById(int id)
        {
            string ssql = $"SELECT * FROM {RepoConstant.TABELA_CONTAS} WHERE id = @id";
            using (var db = Connection.getConnection())
            {
                return db.QueryFirstOrDefault<Conta>(ssql, new { id });
            }
        }

        public int Insert(Conta value)
        {
            string ssql = $"INSERT INTO {RepoConstant.TABELA_CONTAS}(data_registro,nome" +
                $",valor,tipo,data_emissao,data_pagar,obs,duracao,forma_pagamento,pago,incerto" +
                $"parcela_atual,qtd_parcela,cartao) VALUES (@data_registro,@nome,@valor,@tipo,@data_emissao,@data_pagar," +
                $"@obs,@duracao,@forma_pagaemnto,@pago,@incerto,@parcela_atual,@qtd_parcela,@cartao)";
            using (var db = Connection.getConnection())
            {
                return db.Execute(ssql, value);
            }

        }

        public int Update(Conta value)
        {
            string ssql = $"UPDATE {RepoConstant.TABELA_CONTAS} SET data_registro = @data_registro,valor = @valor," +
                $"tipo = @tipo,data_emissao = @data_emissao,data_pagar = @data_pagar,obs = @obs,duracao = @duracao," +
                $"forma_pagamento = @forma_pagamento,pago = @pago, incerto = @incerto,parcela_atual = @parcela_atual" +
                $",qtd_parcela = @qtd_parcela,cartao = @cartao";
            using (var db = Connection.getConnection())
            {
                return db.Execute(ssql, value);
            }

        }
    }
}
