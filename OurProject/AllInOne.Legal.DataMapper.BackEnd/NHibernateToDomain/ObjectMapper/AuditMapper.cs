namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;

    using AutoMapper;
        
    using AllInOne.Legal.Domain.Audit;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;


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


        #region Methods
        /// <summary>
        /// Gets the entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="E"></typeparam>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public static E GetEntity<T, E>(T data)
        {
            if (data == null)
                return default(E);
            try
            {
                return Mapper.Map<T, E>(data);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at Get Mapped Entity", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the <see cref="AuditModuleVisit"/> from <see cref="AuditModuleVisitEntity"/> input.
        /// </summary>
        /// <param name="AuditModuleVisit"><see cref="AuditModuleVisit"/></param>
        /// <returns>Returns <see cref="AuditModuleVisitEntity"/>, else null.</returns>
        public static AuditModuleVisitEntity GetAuditModuleVisitEntity(AuditModuleVisit data)
        {
            AuditModuleVisitEntity entity = null;

            try
            {
                if (data != null)
                {
                    entity = Mapper.Map<AuditModuleVisit, AuditModuleVisitEntity>(data);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetAuditModuleVisitEntity", ex);
                throw ex;
            }

            return entity;
        }

        #endregion

    }
}
