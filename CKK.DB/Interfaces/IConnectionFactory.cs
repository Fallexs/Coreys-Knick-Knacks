namespace CKK.DB.Interfaces {

    public interface IConnectionFactory<IDbConnection> {
        IDbConnection GetConnection { get; }
    }
}