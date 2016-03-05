namespace AllInOne.Common.DataAccess
{
    #region Enumerations

    /// <summary>
    /// Defines the DataAccessLayer implemented data provider types.
    /// </summary>
    public enum DataProviderType
    {
        /// <summary>
        /// For Access data access.
        /// Currently, not supported.
        /// </summary>
        Access,

        /// <summary>
        /// For Odbc data access.
        /// Currently, not supported.
        /// </summary>
        Odbc,

        /// <summary>
        /// For OleDb data access.
        /// Currently, not supported.
        /// </summary>
        OleDb,

        /// <summary>
        /// For Oracle data access.
        /// Currently, not supported.
        /// </summary>
        Oracle,

        /// <summary>
        /// For Sql data access.
        /// </summary>
        Sql
    }

    #endregion Enumerations
}