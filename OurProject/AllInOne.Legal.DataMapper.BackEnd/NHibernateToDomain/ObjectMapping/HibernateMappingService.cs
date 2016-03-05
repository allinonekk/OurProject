namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for FrontEndSpecific from NHibernate entities to Domain objects.
    /// </summary>
    internal class HibernateMappingService
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(HibernateMappingService));

        #endregion Fields

        #region Methods

        public void CreateMapping()
        {
            //MapMailboxViewToMailboxViewEntity();
            MapFunctionsByRoleToFunctionsByRoleEntity();
            MapFunctionsByUserToFunctionsByUserEntity();
            MapUsersToUsersEntity();
            MapVSectionUserACLToVSectionUserACLEntity();
            MapVSecuredCaseAccessInfoToVSecuredCaseAccessInfoEntity();
            MapVSecuredDocAccessInfoToVSecuredDocAccessInfoEntity();
        }

        /// <summary>
        /// Method which maps the <see cref="MailboxView"/> to <see cref="MailboxViewEntity"/>.
        /// </summary>
        /*
        internal void MapMailboxViewToMailboxViewEntity()
        {
            try
            {
                Mapper.CreateMap<MailboxView, MailboxViewEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMailboxViewToMailboxViewEntity", ex);
                throw;
            }
        }
        */
        /// <summary>
        /// Method which maps the <see cref="FunctionsByRole"/> to <see cref="FunctionsByRoleEntity"/>.
        /// </summary>
        internal void MapFunctionsByRoleToFunctionsByRoleEntity()
        {
            try
            {
                Mapper.CreateMap<FunctionsByRole, FunctionsByRoleEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapFunctionsByRoleToFunctionsByRoleEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="FunctionsByUser"/> to <see cref="FunctionsByUserEntity"/>.
        /// </summary>
        internal void MapFunctionsByUserToFunctionsByUserEntity()
        {
            try
            {
                Mapper.CreateMap<FunctionsByUser, FunctionsByUserEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapFunctionsByUserToFunctionsByUserEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="Users"/> to <see cref="UsersEntity"/>.
        /// </summary>
        internal void MapUsersToUsersEntity()
        {
            try
            {
                Mapper.CreateMap<Users, UsersEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapUsersToUsersEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="VSectionUserACL"/> to <see cref="VSectionUserACLEntity"/>.
        /// </summary>
        internal void MapVSectionUserACLToVSectionUserACLEntity()
        {
            try
            {
                Mapper.CreateMap<VSectionUserACL, VSectionUserACLEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapVSectionUserACLToVSectionUserACLEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="VSecuredCaseAccessInfo"/> to <see cref="VSecuredCaseAccessInfoEntity"/>.
        /// </summary>
        internal void MapVSecuredCaseAccessInfoToVSecuredCaseAccessInfoEntity()
        {
            try
            {
                Mapper.CreateMap<VSecuredCaseAccessInfo, VSecuredCaseAccessInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapVSecuredCaseAccessInfoToVSecuredCaseAccessInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="VSecuredDocAccessInfo"/> to <see cref="VSecuredDocAccessInfoEntity"/>.
        /// </summary>
        internal void MapVSecuredDocAccessInfoToVSecuredDocAccessInfoEntity()
        {
            try
            {
                Mapper.CreateMap<VSecuredDocAccessInfo, VSecuredDocAccessInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapVSecuredDocAccessInfoToVSecuredDocAccessInfoEntity", ex);
                throw;
            }
        }

        #endregion Methods
    }
}