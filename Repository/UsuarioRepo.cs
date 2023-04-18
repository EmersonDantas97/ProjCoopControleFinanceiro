using Dapper;
using ProjCoopControleFinanceiro.Model;
using Tabelas = ProjCoopControleFinanceiro.Repository.RepoConstant;

namespace ProjCoopControleFinanceiro.Repository
{
    /// <summary>
    /// Classe responsável pela manipulação de dados da tabela "usuarios"
    /// </summary>
    internal class UsuarioRepo : IRepo<Usuario>
    {
        public int Delete(int id)
        {
            string ssql = $"DELETE FROM {Tabelas.TABELA_USUARIOS} WHERE id = @id";
            using (var db = Connection.getConnection())
            {
                return db.Execute(ssql, new { id });
            }
        }

        public List<Usuario> getAll()
        {
            string ssql = $"SELECT * FROM {Tabelas.TABELA_USUARIOS}";
            using (var db = Connection.getConnection())
            {
                return db.Query<Usuario>(ssql).ToList();
            }
        }

        public Usuario getByCondition(string condition, Usuario value)
        {
            string ssql = $"SELECT * FROM {Tabelas.TABELA_USUARIOS} WHERE " + condition;
            using (var db = Connection.getConnection())
            {
                return db.QueryFirstOrDefault<Usuario>(ssql, value);
            }
        }

        public List<Usuario> getByCondition(string condition, Usuario value, out int count)
        {
            string ssql = $"SELECT * FROM {Tabelas.TABELA_USUARIOS} WHERE " + condition;
            using (var db = Connection.getConnection())
            {
                var list = db.Query<Usuario>(ssql, value).ToList();
                count = list.Count();
                return list;
            }
        }

        public Usuario getById(int id)
        {
            string ssql = $"SELECT * FROM {Tabelas.TABELA_USUARIOS} WHERE id = @id";
            using (var db = Connection.getConnection())
            {
                return db.QueryFirstOrDefault<Usuario>(ssql, new { id });
            }
        }

        public int Insert(Usuario value)
        {
            string ssql = $"INSERT INTO {Tabelas.TABELA_USUARIOS} (usuario,senha) VALUES (@usuario,@senha)";
            using (var db = Connection.getConnection())
            {
                return db.Execute(ssql, value);
            }
        }

        public int Update(Usuario value)
        {
            string ssql = $"UPDATE {Tabelas.TABELA_USUARIOS} SET usuario = @usuario, senha = @senha WHERE id = @id";
            using (var db = Connection.getConnection())
            {
                return db.Execute(ssql, value);
            }
        }
    }
}
