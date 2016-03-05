namespace AllInOne.Common.DataAccess
{
    using System;

    /// <summary>
    /// Loads different data access layer provider depending on the configuration settings file or the caller defined data provider type.
    /// </summary>
    public sealed class DataAccessFactory
    {
        #region Constructors

        // Since this class provides only static methods, make the default constructor private to prevent
        // instances from being created with "new DataAccessFactory()"
        private DataAccessFactory()
        {
            // Do Nothing.
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Constructs a data access layer based on caller specific data provider.
        /// Caller of this method must provide the database connection string through ConnectionString property.
        /// </summary>
        public static BaseDataAccess GetDataAccessLayer(DataProviderType dataProviderType)
        {
            return GetDataAccessLayer(dataProviderType, null);
        }

        /// <summary>
        /// Constructs a data access layer data provider.
        /// </summary>
        public static BaseDataAccess GetDataAccessLayer(DataProviderType dataProviderType, string connectionString)
        {
            // construct specific data access provider class
            switch (dataProviderType)
            {
                case DataProviderType.Access:
                    {
                        //return new OleDbDataAccess(connectionString);
                        throw new NotImplementedException("AccessData is currently not supported.");
                    }
                case DataProviderType.OleDb:
                    {
                        //return new OleDbDataAccess(connectionString);
                        throw new NotImplementedException("OleDbData is currently not supported.");
                    }

                case DataProviderType.Odbc:
                    {
                        //return new OdbcDataAccess(connectionString);
                        throw new NotImplementedException("OdbcData is currently not supported.");
                    }

                case DataProviderType.Oracle:
                    {
                        //return new OracleDataAccessconnectionString);
                        throw new NotImplementedException("OracleData is currently not supported.");
                    }

                case DataProviderType.Sql:
                    {
                        return new SqlDataAccess(connectionString);
                    }

                default:
                    throw new ArgumentException("Invalid data access provider type.");
            }
        }

        #endregion Methods
    }
}