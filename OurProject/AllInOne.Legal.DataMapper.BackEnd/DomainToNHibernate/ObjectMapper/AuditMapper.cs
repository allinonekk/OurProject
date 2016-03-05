namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Audit;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;
    using AllInOne.Legal.Domain.BackEndSpecific;

    /// <summary>
    /// 
    /// </summary>
    public class AuditMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AuditMapper));

        #endregion Fields

        #region Method

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static T GetData<E, T>(E entity)
        {
            if (entity == null)
                return default(T);
            try
            {
                return Mapper.Map<E, T>(entity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at Get Mapped Data", ex);
                throw;
            }
        }

        public static IAudit GetAuditEntity<T>(T auditEntity)
        {
            if (auditEntity.GetType().Equals(typeof(AuditModuleVisitEntity)))
                return AuditMapper.GetAuditModuleVisit(auditEntity as AuditModuleVisitEntity);

            else if (auditEntity.GetType().Equals(typeof(AuditTrailJudicialVisitEntity)))
                return AuditMapper.GetAuditTrailJudicialVisit(auditEntity as AuditTrailJudicialVisitEntity);

            else
                throw new MissingMethodException("This Audit Entity is not Implemented");
        }
        /// <summary>
        /// Gets the <see cref="AuditModuleVisit"/> from <see cref="AuditModuleVisitEntity"/> input.
        /// </summary>
        /// <param name="AuditModuleVisitEntity"><see cref="AuditModuleVisitEntity"/></param>
        /// <returns>Returns <see cref="AuditModuleVisit"/>, else null.</returns>
        public static AuditModuleVisit GetAuditModuleVisit(AuditModuleVisitEntity entity)
        {
            AuditModuleVisit data = null;

            try
            {
                if (entity != null)
                {
                    data = Mapper.Map<AuditModuleVisitEntity, AuditModuleVisit>(entity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetAuditModuleVisit", ex);
                throw ex;
            }

            return data;
        }

        public static AuditTrailJudicialVisit GetAuditTrailJudicialVisit(AuditTrailJudicialVisitEntity auditTrailJudicialVisitEntity)
        {
            AuditTrailJudicialVisit auditTrailJudicialVisit = null;
            try
            {
                if (auditTrailJudicialVisitEntity != null)
                {
                    auditTrailJudicialVisit = Mapper.Map<AuditTrailJudicialVisitEntity, AuditTrailJudicialVisit>(auditTrailJudicialVisitEntity);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAuditTrailJudicialVisit", ex);
                throw;
            }
            return auditTrailJudicialVisit;
        }

        #endregion
    }
}
