#region Header

/*****************************************************************************************************
* Description : This file represents a standard MEMSADMExecLocation entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   27/06/2012  		      Yan Nai             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MEMSADMExecLocationEntity.cs
// Description: Represents a standard MEMSADMExecLocation entity.
// </summary>
// <copyright file= "MEMSADMExecLocationEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MEMSADMExecLocation.
    /// </summary>
    [Serializable]
    public class MEMSADMExecLocationEntity : AbstractMasterInfo, IMasterEntity
    { 
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MEMSADMExecLocationEntity"/> class.</summary>
        public MEMSADMExecLocationEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the EMSADMExecLocationCode field. </summary>
        public System.String EMSADMExecLocationCode
        {
            get;
            set;
        }

        public YesNo SyncRequired
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
            MEMSADMExecLocationEntity toCompareWith = obj as MEMSADMExecLocationEntity;
            return toCompareWith == null ? false : ((this.EMSADMExecLocationCode == toCompareWith.EMSADMExecLocationCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSADMExecLocationCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}