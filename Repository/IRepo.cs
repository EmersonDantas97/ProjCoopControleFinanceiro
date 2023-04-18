namespace ProjCoopControleFinanceiro.Repository
{
    /// <summary>
    /// Interface de repositório para 
    /// a manipulação de dados do banco
    /// </summary>
    /// <typeparam name="T">O objeto que vai ser manipulado no banco</typeparam>
    internal interface IRepo<T>
    {
        int Insert(T value);
        int Delete(int id);
        int Update(T value);
        List<T> getAll();
        T getById(int id);
        T getByCondition(string condition, T value);
        List<T> getByCondition(string condition,T value, out int count);
    }
}
