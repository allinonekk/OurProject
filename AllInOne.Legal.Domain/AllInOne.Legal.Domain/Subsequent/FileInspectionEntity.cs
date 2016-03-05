#region Header

/*****************************************************************************************************
 * Description : This file represents a standard FileInspectionEntity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 23/01/2011   		      Nithin             	 	Created
 *****************************************************************************************************/
// <summary>
// File: FileInspectionEntity.cs
// Description: Represents a standard FileInspectionEntity.
// </summary>
// <copyright file= "FileInspectionEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for FileInspectionEntity.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class FileInspectionEntity : AbstractLastModified, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Subsequent.FileInspection.DocumentInfo - Document.DocumentInfo.FileInspections (m:1)'
        /// </summary>
        /// <value>The doc id.</value>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the EMail field.
        /// </summary>
        /// <value>The E mail.</value>
        public String EMail
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ExpiryDate field.
        /// </summary>
        /// <value>The expiry date.</value>
        public DateTime? ExpiryDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FileInspectionId field.
        /// </summary>
        /// <value>The file inspection id.</value>
        public String FileInspectionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdNumber field.
        /// </summary>
        /// <value>The id number.</value>
        public String IdNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the InspectionLocation field.
        /// </summary>
        /// <value>The inspection location.</value>
        //TODO:Foreign Key is Missing in db
        public Int32 InspectionLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the InspectionPeriod field.
        /// </summary>
        /// <value>The inspection period.</value>
        public Int32? InspectionPeriod
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the InspectionStartedDate field.
        /// </summary>
        /// <value>The inspection started date.</value>
        public DateTime? InspectionStartedDate
        {
            get;
            set;
        }

        public String InspectionToken
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Subsequent.FileInspection.MCountry - Master.MCountry.FileInspections (m:1)'
        /// </summary>
        /// <value>The M country.</value>
        public MCountryEntity MCountry
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Subsequent.FileInspection.MPersonIDType - Master.MPersonIDType.FileInspections (m:1)'
        /// </summary>
        /// <value>The type of the M person ID.</value>
        public MPersonIDTypeEntity MPersonIDType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Status field.
        /// </summary>
        /// <value>The status.</value>
        public FileInspectionStatus Status
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            FileInspectionEntity toCompareWith = obj as FileInspectionEntity;
            return toCompareWith == null ? false : ((this.FileInspectionId == toCompareWith.FileInspectionId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FileInspectionId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}