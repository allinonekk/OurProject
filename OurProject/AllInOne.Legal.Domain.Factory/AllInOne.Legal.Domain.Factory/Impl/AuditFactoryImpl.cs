namespace AllInOne.Legal.Domain.Factory.Impl
{
    using AllInOne.Legal.Domain.Audit;

    /// <summary>
    /// Represents a standard implementation for case factory.
    /// It inherits from <see cref="IAuditFactory"/>.
    /// </summary>
    public class AuditFactoryImpl : IAuditFactory
    {
        #region Fields

        /// <summary>
        /// Variable to store ApplicationEnvironment.
        /// </summary>
        private ApplicationEnvironment applicationEnvironment;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditFactoryImpl"/> class.
        /// </summary>
        /// <param name="applicationEnvironment">The application environment.</param>
        public AuditFactoryImpl(ApplicationEnvironment applicationEnvironment)
        {
            this.applicationEnvironment = applicationEnvironment;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the <see cref="AuditModuleVisitEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="AuditModuleVisitEntity"/>
        /// </returns>
        public AuditModuleVisitEntity GetAuditModuleVisitEntityInstance()
        {
            return new AuditModuleVisitEntity { AuditModuleVisitId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        #endregion Methods
    }
}