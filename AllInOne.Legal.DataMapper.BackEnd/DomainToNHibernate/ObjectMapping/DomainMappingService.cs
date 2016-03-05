namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for BackEndSpecific related from Domain objects to NHibernate entities.
    /// </summary>
    internal class DomainMappingService
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DomainMappingService));

        #endregion Fields

        #region Methods

        public void CreateMapping()
        {
            //MapMailboxViewEntityToMailboxView();
            MapFunctionsByRoleEntityToFunctionsByRole();
            MapFunctionsByUserEntityToFunctionsByUser();
            MapUsersEntityToUsers();
            MapVSectionUserACLEntityToVSectionUserACL();
            MapVSecuredCaseAccessInfoEntityToVSecuredCaseAccessInfo();
            MapVSecuredDocAccessInfoEntityToVSecuredDocAccessInfo();
        }

        /// <summary>
        /// Method which maps the <see cref="SBFilingInfoEntity"/> to <see cref="SBFilingInfo"/>.
        /// </summary>
        /*
        internal void MapSBFilingInfoEntityToSBFilingInfo()
        {
            try
            {
                Mapper.CreateMap<SBFilingInfoEntity, SBFilingInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSBFilingInfoEntityToSBFilingInfo", ex);
                throw;
            }
        }
        */
        /// <summary>
        /// Method which maps the <see cref="FunctionsByRoleEntity"/> to <see cref="FunctionsByRole"/>.
        /// </summary>
        internal void MapFunctionsByRoleEntityToFunctionsByRole()
        {
            try
            {
                Mapper.CreateMap<FunctionsByRoleEntity, FunctionsByRole>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapFunctionsByRoleEntityToFunctionsByRole", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="FunctionsByUserEntity"/> to <see cref="FunctionsByUser"/>.
        /// </summary>
        internal void MapFunctionsByUserEntityToFunctionsByUser()
        {
            try
            {
                Mapper.CreateMap<FunctionsByUserEntity, FunctionsByUser>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapFunctionsByUserEntityToFunctionsByUser", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="UsersEntity"/> to <see cref="Users"/>.
        /// </summary>
        internal void MapUsersEntityToUsers()
        {
            try
            {
                Mapper.CreateMap<UsersEntity, Users>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapUsersEntityToUsers", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="VSectionUserACLEntity"/> to <see cref="VSectionUserACL"/>.
        /// </summary>
        internal void MapVSectionUserACLEntityToVSectionUserACL()
        {
            try
            {
                Mapper.CreateMap<VSectionUserACLEntity, VSectionUserACL>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapVSectionUserACLEntityToVSectionUserACL", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="VSecuredCaseAccessInfoEntity"/> to <see cref="VSecuredCaseAccessInfo"/>.
        /// </summary>
        internal void MapVSecuredCaseAccessInfoEntityToVSecuredCaseAccessInfo()
        {
            try
            {
                Mapper.CreateMap<VSecuredCaseAccessInfoEntity, VSecuredCaseAccessInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapVSecuredCaseAccessInfoEntityToVSecuredCaseAccessInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="VSecuredDocAccessInfoEntity"/> to <see cref="VSecuredDocAccessInfo"/>.
        /// </summary>
        internal void MapVSecuredDocAccessInfoEntityToVSecuredDocAccessInfo()
        {
            try
            {
                Mapper.CreateMap<VSecuredDocAccessInfoEntity, VSecuredDocAccessInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapVSecuredDocAccessInfoEntityToVSecuredDocAccessInfo", ex);
                throw;
            }
        }

        #endregion Methods
    }
}