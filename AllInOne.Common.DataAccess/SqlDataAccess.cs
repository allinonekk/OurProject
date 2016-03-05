namespace AllInOne.Common.DataAccess
{
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    /// The SQLDataAccessLayer contains the data access layer for Microsoft SQL Server. 
    /// This class implements the abstract methods in the DataAccessLayerBaseClass class.
    /// </summary>
    public class SqlDataAccess : BaseDataAccess
    {
        #region Constructors

        // Provide class constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDataAccess"/> class.
        /// </summary>
        public SqlDataAccess()
        {
            // Do Nothing.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDataAccess"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public SqlDataAccess(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Data provider specific implementation for executing SQL statement while connected to a data source.
        /// </summary>
        /// <returns></returns>
        internal override IDbCommand GeDataProviderCommand()
        {
            return new SqlCommand();
        }

        // DataAccessLayerBaseClass Members
        /// <summary>
        /// Data provider specific implementation for accessing relational databases.
        /// </summary>
        /// <returns></returns>
        internal override IDbConnection GetDataProviderConnection()
        {
            return new SqlConnection();
        }

        /// <summary>
        /// Data provider specific implementation for filling the DataSet.
        /// </summary>
        /// <returns></returns>
        internal override IDbDataAdapter GetDataProviderDataAdapter()
        {
            return new SqlDataAdapter();
        }

        #endregion Methods
    }
}