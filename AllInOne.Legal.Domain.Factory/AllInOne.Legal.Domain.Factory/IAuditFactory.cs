namespace AllInOne.Legal.Domain.Factory
{
    using AllInOne.Legal.Domain.Audit;

    /// <summary>
    /// Represents a standard interface for creating instances of objects related with Audit.
    /// </summary>
    internal interface IAuditFactory
    {
        #region Methods

        /// <summary>
        /// Gets the <see cref="AuditModuleVisitEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="AuditModuleVisitEntity"/></returns>
        AuditModuleVisitEntity GetAuditModuleVisitEntityInstance();

        #endregion Methods
    }
}