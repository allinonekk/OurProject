namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for BackEndSpecific from Domain objects to NHibernate entities.
    /// </summary>
    public class HibernateMapperService
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(HibernateMapperService));

        #endregion Fields

        #region Methods

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
        /// Gets the <see cref="VSectionUserACL"/> from <see cref="VSectionUserACLEntity"/> input.
        /// </summary>
        /// <param name="VSectionUserACL"><see cref="VSectionUserACL"/></param>
        /// <returns>Returns <see cref="VSectionUserACLEntity"/>, else null.</returns>
        public static VSectionUserACLEntity GetVSectionUserACLEntity(VSectionUserACL data)
        {
            VSectionUserACLEntity entity = null;

            try
            {
                if (data != null)
                {
                    entity = Mapper.Map<VSectionUserACL, VSectionUserACLEntity>(data);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetVSectionUserACLEntity", ex);
                throw;
            }

            return entity;
        }

        /// <summary>
        /// Gets the <see cref="VSecuredCaseAccessInfo"/> from <see cref="VSecuredCaseAccessInfoEntity"/> input.
        /// </summary>
        /// <param name="VSecuredCaseAccessInfo"><see cref="VSecuredCaseAccessInfo"/></param>
        /// <returns>Returns <see cref="VSecuredCaseAccessInfoEntity"/>, else null.</returns>
        public static VSecuredCaseAccessInfoEntity GetVSecuredCaseAccessInfoEntity(VSecuredCaseAccessInfo data)
        {
            VSecuredCaseAccessInfoEntity entity = null;

            try
            {
                if (data != null)
                {
                    entity = Mapper.Map<VSecuredCaseAccessInfo, VSecuredCaseAccessInfoEntity>(data);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetVSecuredCaseAccessInfoEntity", ex);
                throw;
            }

            return entity;
        }

        /// <summary>
        /// Gets the <see cref="VSecuredDocAccessInfo"/> from <see cref="VSecuredDocAccessInfoEntity"/> input.
        /// </summary>
        /// <param name="VSecuredDocAccessInfo"><see cref="VSecuredDocAccessInfo"/></param>
        /// <returns>Returns <see cref="VSecuredDocAccessInfoEntity"/>, else null.</returns>
        public static VSecuredDocAccessInfoEntity GetVSecuredDocAccessInfoEntity(VSecuredDocAccessInfo data)
        {
            VSecuredDocAccessInfoEntity entity = null;

            try
            {
                if (data != null)
                {
                    entity = Mapper.Map<VSecuredDocAccessInfo, VSecuredDocAccessInfoEntity>(data);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetVSecuredDocAccessInfoEntity", ex);
                throw;
            }

            return entity;
        }

        #endregion Methods
    }
}