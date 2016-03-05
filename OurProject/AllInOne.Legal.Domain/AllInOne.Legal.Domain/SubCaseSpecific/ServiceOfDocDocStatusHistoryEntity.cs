#region Header

/*****************************************************************************************************
* Description : This file represents a standard ServiceOfDocDocStatusHistory entity.
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
// File: ServiceOfDocDocStatusHistoryEntity.cs
// Description: Represents a standard ServiceOfDocDocStatusHistory entity.
// </summary>
// <copyright file= "ServiceOfDocDocStatusHistoryEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for ServiceOfDocDocStatusHistory.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class ServiceOfDocDocStatusHistoryEntity : AbstractLastModified, ISubCaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ServiceOfDocDocStatusHistory.MServeStatus - Master.MServeStatus.ServiceOfDocDocStatusHistories (m:1)'
        /// </summary>
        /// <value>The M serve status.</value>
        public MServeStatusEntity MServeStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ServiceOfDocDocStatusHistory.DocumentInfo - Document.DocumentInfo.ServiceOfDocDocStatusHistories (m:1)'
        /// </summary>
        /// <value>The document info.</value>
        public String RemainderAttDocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RemainderMessage field.
        /// </summary>
        /// <value>The remainder message.</value>
        public String RemainderMessage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RemainderSubject field.
        /// </summary>
        /// <value>The remainder subject.</value>
        public String RemainderSubject
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RemainderTo field.
        /// </summary>
        /// <value>The remainder to.</value>
        public String RemainderTo
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
        /// Gets or sets the ServiceOfDocInfoId field.
        /// </summary>
        /// <value>The service of doc info id.</value>
        public String ServiceOfDocInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the StatusDate field.
        /// </summary>
        /// <value>The status date.</value>
        public DateTime StatusDate
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

            ServiceOfDocDocStatusHistoryEntity toCompareWith = obj as ServiceOfDocDocStatusHistoryEntity;
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