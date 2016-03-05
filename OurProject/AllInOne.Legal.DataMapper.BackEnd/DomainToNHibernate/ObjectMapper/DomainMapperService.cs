namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for FrontEndSpecific from Domain objects to NHibernate entities.
    /// </summary>
    public class DomainMapperService
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DomainMapperService));

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
        /// <param name="VSectionUserACLEntity"><see cref="VSectionUserACLEntity"/></param>
        /// <returns>Returns <see cref="VSectionUserACL"/>, else null.</returns>
        public static VSectionUserACL GetVSectionUserACL(VSectionUserACLEntity entity)
        {
            VSectionUserACL data = null;

            try
            {
                if (entity != null)
                {
                    data = Mapper.Map<VSectionUserACLEntity, VSectionUserACL>(entity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetVSectionUserACL", ex);
                throw;
            }

            return data;
        }

        /// <summary>
        /// Gets the <see cref="VSecuredCaseAccessInfo"/> from <see cref="VSecuredCaseAccessInfoEntity"/> input.
        /// </summary>
        /// <param name="VSecuredCaseAccessInfoEntity"><see cref="VSecuredCaseAccessInfoEntity"/></param>
        /// <returns>Returns <see cref="VSecuredCaseAccessInfo"/>, else null.</returns>
        public static VSecuredCaseAccessInfo GetVSecuredCaseAccessInfo(VSecuredCaseAccessInfoEntity entity)
        {
            VSecuredCaseAccessInfo data = null;

            try
            {
                if (entity != null)
                {
                    data = Mapper.Map<VSecuredCaseAccessInfoEntity, VSecuredCaseAccessInfo>(entity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetVSecuredCaseAccessInfo", ex);
                throw;
            }

            return data;
        }

        public static VSecuredDocAccessInfo GetVSecuredDocAccessInfo(VSecuredDocAccessInfoEntity entity)
        {
            VSecuredDocAccessInfo data = null;

            try
            {
                if (entity != null)
                {
                    data = Mapper.Map<VSecuredDocAccessInfoEntity, VSecuredDocAccessInfo>(entity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetVSecuredDocAccessInfo", ex);
                throw;
            }

            return data;
        }

        #endregion Methods
    }
}