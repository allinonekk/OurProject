namespace AllInOne.Common.DataAccess
{
    using System;
    using System.Data;

    using log4net;

    /// <summary>
    /// The BaseDataAccess lists all the abstract methods that each data access layer provider (SQL Server, OleDb, etc.) must implement.
    /// </summary>
    public abstract class BaseDataAccess
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(typeof(BaseDataAccess));

        /// <summary>
        /// Variable to store <see cref="IDbCommand"/> object.
        /// </summary>
        private IDbCommand command;

        /// <summary>
        /// Variable to store <see cref="IDbConnection"/> object.
        /// </summary>
        private IDbConnection connection;

        /// <summary>
        /// Variable to store connection string. 
        /// </summary>
        private string connectionString;

        /// <summary>
        /// Variable to store <see cref="IDbTransaction"/> object.
        /// </summary>
        private IDbTransaction transaction;

        #endregion Fields

        #region Constructors

        // Since this is an abstract class, for better documentation and readability of source code,
        // class is defined with an explicit protected constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDataAccess"/> class.
        /// </summary>
        protected BaseDataAccess()
        {
            // Do nothing.
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the string used to open a database.
        /// </summary>
        /// <value>The connection string.</value>
        public string ConnectionString
        {
            get
            {
                // make sure connection string is not empty
                if (connectionString == string.Empty || connectionString.Length == 0)
                {
                    throw new ArgumentException("Invalid database connection string.");
                }

                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Begins a database transaction.
        /// </summary>
        public void BeginTransaction()
        {
            if (transaction != null)
            {
                return;
            }

            try
            {
                // instantiate a connection object
                connection = GetDataProviderConnection();
                connection.ConnectionString = this.ConnectionString;
                // open connection
                connection.Open();
                // begin a database transaction with a read committed isolation level
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            }
            catch (Exception ex)
            {
                logger.Error("Error encountered at BeginTransaction.", ex);
                connection.Close();
                throw;
            }
        }

        /// <summary>
        /// Commits the database transaction.
        /// </summary>
        public void CommitTransaction()
        {
            if (transaction == null)
            {
                return;
            }

            try
            {
                // Commit transaction
                transaction.Commit();
            }
            catch (Exception ex)
            {
                logger.Error("Error encountered at CommitTransaction.", ex);
                // rollback transaction
                RollbackTransaction();
                throw;
            }
            finally
            {
                connection.Close();
                transaction = null;
            }
        }

        /// <summary>
        /// Executes the CommandText against the Connection and builds an IDataReader.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <returns></returns>
        public IDataReader ExecuteDataReader(string commandText)
        {
            return this.ExecuteDataReader(commandText, CommandType.Text, null);
        }

        /// <summary>
        /// Executes the CommandText against the Connection and builds an IDataReader.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public IDataReader ExecuteDataReader(string commandText, CommandType commandType)
        {
            return this.ExecuteDataReader(commandText, commandType, null);
        }

        /// <summary>
        /// Executes a parameterized CommandText against the Connection and builds an IDataReader.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandParameters">The command parameters.</param>
        /// <returns></returns>
        public IDataReader ExecuteDataReader(string commandText, IDataParameter[] commandParameters)
        {
            return this.ExecuteDataReader(commandText, CommandType.Text, commandParameters);
        }

        /// <summary>
        /// Executes a stored procedure against the Connection and builds an IDataReader.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="commandParameters">The command parameters.</param>
        /// <returns></returns>
        public IDataReader ExecuteDataReader(string commandText, CommandType commandType, IDataParameter[] commandParameters)
        {
            try
            {
                PrepareCommand(commandType, commandText, commandParameters);

                IDataReader dr;

                if (transaction == null)
                {
                    // Generate the reader. CommandBehavior.CloseConnection causes the
                    // the connection to be closed when the reader object is closed
                    dr = command.ExecuteReader(CommandBehavior.CloseConnection);
                }
                else
                {
                    dr = command.ExecuteReader();
                }

                return dr;
            }
            catch (Exception ex)
            {
                logger.Error("Error encountered at ExecuteDataReader.", ex);
                if (transaction == null)
                {
                    connection.Close();
                    command.Dispose();
                }
                else
                {
                    RollbackTransaction();
                }

                throw;
            }
        }

        /// <summary>
        /// Executes a stored procedure against the Connection and builds an IDataReader.
        /// Allows caller to specify the timeout when the command is executed.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="commandParameters">The command parameters.</param>
        /// /// /// <param name="commandTimeout">The command timeout.</param>
        /// <returns></returns>
        public IDataReader ExecuteDataReader(string commandText, CommandType commandType, IDataParameter[] commandParameters, int commandTimeout)
        {
            try
            {
                PrepareCommand(commandType, commandText, commandParameters, commandTimeout);

                IDataReader dr;

                if (transaction == null)
                {
                    // Generate the reader. CommandBehavior.CloseConnection causes the
                    // the connection to be closed when the reader object is closed
                    dr = command.ExecuteReader(CommandBehavior.CloseConnection);
                }
                else
                {
                    dr = command.ExecuteReader();
                }

                return dr;
            }
            catch (Exception ex)
            {
                logger.Error("Error encountered at ExecuteDataReader.", ex);
                if (transaction == null)
                {
                    connection.Close();
                    command.Dispose();
                }
                else
                {
                    RollbackTransaction();
                }

                throw;
            }
        }

        /// <summary>
        /// Adds or refreshes rows in the DataSet to match those in the data source using the DataSet name, and creates a DataTable named "Table".
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <returns></returns>
        public DataSet ExecuteDataSet(string commandText)
        {
            return this.ExecuteDataSet(commandText, CommandType.Text, null);
        }

        /// <summary>
        /// Adds or refreshes rows in the DataSet to match those in the data source using the DataSet name, and creates a DataTable named "Table".
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public DataSet ExecuteDataSet(string commandText, CommandType commandType)
        {
            return this.ExecuteDataSet(commandText, commandType, null);
        }

        /// <summary>
        /// Adds or refreshes rows in the DataSet to match those in the data source using the DataSet name, and creates a DataTable named "Table".
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandParameters">The command parameters.</param>
        /// <returns></returns>
        public DataSet ExecuteDataSet(string commandText, IDataParameter[] commandParameters)
        {
            return this.ExecuteDataSet(commandText, CommandType.Text, commandParameters);
        }

        /// <summary>
        /// Adds or refreshes rows in the DataSet to match those in the data source using the DataSet name, and creates a DataTable named "Table".
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="commandParameters">The command parameters.</param>
        /// <returns></returns>
        public DataSet ExecuteDataSet(string commandText, CommandType commandType, IDataParameter[] commandParameters)
        {
            try
            {
                PrepareCommand(commandType, commandText, commandParameters);
                //create the DataAdapter & DataSet
                IDbDataAdapter da = GetDataProviderDataAdapter();
                da.SelectCommand = command;
                DataSet ds = new DataSet();

                //fill the DataSet using default values for DataTable names, etc.
                da.Fill(ds);

                //return the dataset
                return ds;
            }
            catch (Exception ex)
            {
                logger.Error("Error encountered at ExecuteDataSet.", ex);
                if (transaction == null)
                {
                    connection.Close();
                }
                else
                {
                    RollbackTransaction();
                }

                throw;
            }
            finally
            {
                if (transaction == null)
                {
                    connection.Close();
                    command.Dispose();
                }
            }
        }

        /// <summary>
        /// Executes an SQL statement against the Connection object of a .NET Framework data provider, and returns the number of rows affected.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <returns></returns>
        public int ExecuteQuery(string commandText)
        {
            return this.ExecuteQuery(commandText, CommandType.Text, null);
        }

        /// <summary>
        /// Executes an SQL statement against the Connection object of a .NET Framework data provider, and returns the number of rows affected.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public int ExecuteQuery(string commandText, CommandType commandType)
        {
            return this.ExecuteQuery(commandText, commandType, null);
        }

        /// <summary>
        /// Executes an SQL parameterized statement against the Connection object of a .NET Framework data provider, and returns the number of rows affected.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandParameters">The command parameters.</param>
        /// <returns></returns>
        public int ExecuteQuery(string commandText, IDataParameter[] commandParameters)
        {
            return this.ExecuteQuery(commandText, CommandType.Text, commandParameters);
        }

        /// <summary>
        /// Executes a stored procedure against the Connection object of a .NET Framework data provider, and returns the number of rows affected.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="commandParameters">The command parameters.</param>
        /// <returns></returns>
        public int ExecuteQuery(string commandText, CommandType commandType, IDataParameter[] commandParameters)
        {
            try
            {
                PrepareCommand(commandType, commandText, commandParameters);

                // execute command
                int intAffectedRows = command.ExecuteNonQuery();
                // return no of affected records
                return intAffectedRows;
            }
            catch (Exception ex)
            {
                logger.Error("Error encountered at ExecuteQuery.", ex);
                if (transaction != null)
                    RollbackTransaction();

                throw;
            }
            finally
            {
                if (transaction == null)
                {
                    connection.Close();
                    command.Dispose();
                }
            }
        }

        /// <summary>
        /// Executes a stored procedure against the Connection object of a .NET Framework data provider, and returns the number of rows affected.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="commandParameters">The command parameters.</param>
        /// <returns></returns>
        public int ExecuteQuery(string commandText, CommandType commandType, IDataParameter[] commandParameters,int CommandTimeOut)
        {
            try
            {
                PrepareCommand(commandType, commandText, commandParameters, CommandTimeOut);

                // execute command
                int intAffectedRows = command.ExecuteNonQuery();
                // return no of affected records
                return intAffectedRows;
            }
            catch (Exception ex)
            {
                logger.Error("Error encountered at ExecuteQuery.", ex);
                if (transaction != null)
                    RollbackTransaction();

                throw;
            }
            finally
            {
                if (transaction == null)
                {
                    connection.Close();
                    command.Dispose();
                }
            }
        }

        /// <summary>
        /// Executes the query, and returns the first column of the first row in the resultset returned by the query. Extra columns or rows are ignored.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <returns></returns>
        public object ExecuteScalar(string commandText)
        {
            return this.ExecuteScalar(commandText, CommandType.Text, null);
        }

        /// <summary>
        /// Executes the query, and returns the first column of the first row in the resultset returned by the query. Extra columns or rows are ignored.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public object ExecuteScalar(string commandText, CommandType commandType)
        {
            return this.ExecuteScalar(commandText, commandType, null);
        }

        /// <summary>
        /// Executes a parameterized query, and returns the first column of the first row in the resultset returned by the query. Extra columns or rows are ignored.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandParameters">The command parameters.</param>
        /// <returns></returns>
        public object ExecuteScalar(string commandText, IDataParameter[] commandParameters)
        {
            return this.ExecuteScalar(commandText, CommandType.Text, commandParameters);
        }

        /// <summary>
        /// Executes a stored procedure, and returns the first column of the first row in the resultset returned by the query. Extra columns or rows are ignored.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="commandParameters">The command parameters.</param>
        /// <returns></returns>
        public object ExecuteScalar(string commandText, CommandType commandType, IDataParameter[] commandParameters)
        {
            try
            {
                PrepareCommand(commandType, commandText, commandParameters);

                // execute command
                object objValue = command.ExecuteScalar();
                // check on value
                if (objValue != DBNull.Value)
                {
                    // return value
                    return objValue;
                }
                else
                {
                    // return null instead of dbnull value
                    return null;
                }
            }
            catch (Exception ex)
            {
                logger.Error("Error encountered at ExecuteScalar.", ex);
                if (transaction != null)
                {
                    RollbackTransaction();
                }

                throw;
            }
            finally
            {
                if (transaction == null)
                {
                    connection.Close();
                    command.Dispose();
                }
            }
        }

        /// <summary>
        /// Rolls back a transaction from a pending state.
        /// </summary>
        public void RollbackTransaction()
        {
            if (transaction == null)
                return;

            try
            {
                transaction.Rollback();
            }
            catch (Exception ex)
            {
                logger.Error("Error encountered at RollbackTransaction.", ex);
                // Do nothing.
            }
            finally
            {
                connection.Close();
                transaction = null;
            }
        }

        /// <summary>
        /// Data provider specific implementation for executing SQL statement while connected to a data source.
        /// </summary>
        internal abstract IDbCommand GeDataProviderCommand();

        /// <summary>
        /// Data provider specific implementation for accessing relational databases.
        /// </summary>
        internal abstract IDbConnection GetDataProviderConnection();

        /// <summary>
        /// Data provider specific implementation for filling the DataSet.
        /// </summary>
        internal abstract IDbDataAdapter GetDataProviderDataAdapter();

        /// <summary>
        /// This method opens (if necessary) and assigns a connection, transaction, command type and parameters
        /// to the provided command.
        /// </summary>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandParameters">The command parameters.</param>
        private void PrepareCommand(CommandType commandType, string commandText, IDataParameter[] commandParameters)
        {
            // provide the specific data provider connection object, if the connection object is null
            if (connection == null)
            {
                connection = GetDataProviderConnection();
                connection.ConnectionString = this.ConnectionString;
            }

            // if the provided connection is not open, then open it
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            // Provide the specific data provider command object, if the command object is null
            //if (command == null)
            //{
            command = GeDataProviderCommand();
            //}

            // associate the connection with the command
            command.Connection = connection;
            // set the command text (stored procedure name or SQL statement)
            command.CommandText = commandText;
            // set the command type
            command.CommandType = commandType;

            // if a transaction is provided, then assign it.
            if (transaction != null)
            {
                command.Transaction = transaction;
            }

            // attach the command parameters if they are provided
            if (commandParameters != null)
            {
                foreach (IDataParameter param in commandParameters)
                {
                    command.Parameters.Add(param);
                }
            }
        }

        /// <summary>
        /// This method opens (if necessary) and assigns a connection, transaction, command type and parameters
        /// to the provided command.
        /// </summary>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="commandText">The command text.</param>
        /// <param name="commandParameters">The command parameters.</param>
        /// /// <param name="commandTimeout">The command timeout.</param>
        private void PrepareCommand(CommandType commandType, string commandText, IDataParameter[] commandParameters, int commandTimeout)
        {
            // provide the specific data provider connection object, if the connection object is null
            if (connection == null)
            {
                connection = GetDataProviderConnection();
                connection.ConnectionString = this.ConnectionString;
            }

            // if the provided connection is not open, then open it
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            // Provide the specific data provider command object, if the command object is null
            //if (command == null)
            //{
            command = GeDataProviderCommand();
            //}

            // associate the connection with the command
            command.Connection = connection;
            // set the command text (stored procedure name or SQL statement)
            command.CommandText = commandText;
            // set the command type
            command.CommandType = commandType;
            // set the timeout
            if (commandTimeout > 0)
                command.CommandTimeout = commandTimeout;

            // if a transaction is provided, then assign it.
            if (transaction != null)
            {
                command.Transaction = transaction;
            }

            // attach the command parameters if they are provided
            if (commandParameters != null)
            {
                foreach (IDataParameter param in commandParameters)
                {
                    command.Parameters.Add(param);
                }
            }
        }

        #endregion Methods
    }
}