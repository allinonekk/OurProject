namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Audit;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// 
    /// </summary>
    public class AuditMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AuditMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Creates the mapping.
        /// </summary>
        public void CreateMapping()
        {
            MapAuditModuleVisitToAuditModuleVisitEntity();
        }

        /// <summary>
        /// Method which maps the <see cref="AuditModuleVisit"/> to <see cref="AuditModuleVisitEntity"/>.
        /// </summary>
        internal void MapAuditModuleVisitToAuditModuleVisitEntity()
        {
            try
            {
                Mapper.CreateMap<AuditModuleVisit, AuditModuleVisitEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAuditModuleVisitToAuditModuleVisitEntity", ex);
                throw ex;
            }
        }
        #endregion
    }
}
