#region Header

/*****************************************************************************************************
* Description : This file represents a standard ServiceOfDocDocument entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ServiceOfDocDocumentEntity.cs
// Description: Represents a standard ServiceOfDocDocument entity.
// </summary>
// <copyright file= "ServiceOfDocDocumentEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for ServiceOfDocDocument.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class ServiceOfDocDocumentEntity : AbstractLastModified, ISubCaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CreatedBy field.
        /// </summary>
        /// <value>The created by.</value>
        public String CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CreatedDate field.
        /// </summary>
        /// <value>The created date.</value>
        public DateTime CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ServiceOfDocDocument.DocumentInfo - Document.DocumentInfo.ServiceOfDocDocuments (m:1)'
        /// </summary>
        /// <value>The doc id.</value>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ServiceOfDocDocStatusId field.
        /// </summary>
        /// <value>The service of doc doc status id.</value>
        public String ServiceOfDocDocStatusId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ServiceOfDocDocument.ServiceOfDocInfoDetail - Common.ServiceOfDocInfoDetail.ServiceOfDocDocuments (m:1)'
        /// </summary>
        /// <value>The service of doc info detail.</value>
        public String ServiceOfDocInfoDetailId
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
            if(obj == null)
            {
                return false;
            }
            ServiceOfDocDocumentEntity toCompareWith = obj as ServiceOfDocDocumentEntity;
            return toCompareWith == null ? false : ((this.ServiceOfDocDocStatusId == toCompareWith.ServiceOfDocDocStatusId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ServiceOfDocDocStatusId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}