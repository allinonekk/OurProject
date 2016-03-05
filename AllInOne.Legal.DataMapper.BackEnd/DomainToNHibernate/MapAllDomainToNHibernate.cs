#region Header

/*****************************************************************************************************
* Description : This file handles call to all the Map methods, mapping Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			            Description
*-----------------------------------------------------------------------------------------------------
*   27/09/2010   		        Yan Nai                	 	Created
*   27/10/2010                  Swaroop                     Added logging and comments.
*****************************************************************************************************/
// <summary>
// File: MapAllDomainToNHibernate.cs
// Description: This file handles call to all the Map methods, mapping Domain objects to NHibernate entities.
// </summary>
// <copyright file= "MapAllDomainToNHibernate.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate
{
    using System;

    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping;

    using log4net;

    /// <summary>
    /// Class implementing call to all the Map methods, mapping Domain objects to NHibernate entities.
    /// </summary>
    public class MapAllDomainToNHibernate
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MapAllDomainToNHibernate));


        PatientMapping hospitalMapping = null;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapAllDomainToNHibernate"/> class.
        /// </summary>
        public MapAllDomainToNHibernate()
        {
            hospitalMapping = new PatientMapping();
            
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Method which calls to all the Map methods, mapping Domain objects to NHibernate entities.
        /// </summary>
        /// <exception cref="System.Exception">Error in Mapping, Domain to NHibernate. -  + exp.Message</exception>
        public void MapAll()
        {
            Logger.Debug("MapAll Initialised");
            try
            {
                hospitalMapping.MapPatientInfoEntityToPatientInfo();
                
            }
            catch (Exception exp)
            {
                throw new Exception("Error in Mapping, Domain to NHibernate. - " + exp.Message, exp);
            }
        }

        #endregion Methods
    }
}