namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
{
    using System;

    using AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping;

    using log4net;

    /// <summary>
    /// Class implementing call to all the Map methods, mapping NHibernate entities to Domain objects.
    /// </summary>
    public class MapAllNHibernateToDomain
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MapAllNHibernateToDomain));


        HospitalMapping hospitalMapping=null ;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapAllNHibernateToDomain"/> class.
        /// </summary>
        /// <remarks>Initializes all the mapping.</remarks>
        public MapAllNHibernateToDomain()
        {           
            hospitalMapping = new HospitalMapping();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Method which calls to all the Map methods, mapping Domain objects to NHibernate entities. 
        /// </summary>
        public void MapAll()
        {
            Logger.Debug("Initialised MapAll");
            try
            {
                hospitalMapping.MapPatientInfoEntity();
               
            }
            catch (Exception ex)
            {
                Logger.Error("Error at NHibernateToDomain>> Mapping >> MapAll", ex);
                throw;
            }
        }

        #endregion Methods
    }
}