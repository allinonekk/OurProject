#region Header

/*****************************************************************************************************
* Description : This file represents a standard WitnessInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   24/06/2011                 CJ             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: WitnessInfoEntity.cs
// Description: Represents a standard WitnessInfo entity.
// </summary>
// <copyright file= "WitnessInfoEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for WitnessInfo.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class WitnessInfoEntity : AbstractLastModified, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the DateOfStatement field.
        /// </summary>
        /// <value>The Date Of Statement.</value>
        public DateTime DateOfStatement
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocId field.
        /// </summary>
        /// <value>The Document Id.</value>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdCountryTypeCode field.
        /// </summary>
        /// <value>The IdCountryTypeCode of witness.</value>
        public MCountryEntity IdCountryTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdGroupCode  field.
        /// </summary>
        /// <value>The IdGroupCode witness.</value>
        public MPersonIDGroupEntity IdGroupCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdNumber field.
        /// </summary>
        /// <value>The IdNumber of witness.</value>
        public String IdNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdRemarks field.
        /// </summary>
        /// <value>The IdRemarks of witness.</value>
        public String IdRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdTypeCode field.
        /// </summary>
        /// <value>The IdTypeCode of witness.</value>
        public MPersonIDTypeEntity IdTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Name field.
        /// </summary>
        /// <value>The Name of witness.</value>
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obselete indicator.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OtherWitnessType field.
        /// </summary>
        /// <value>The OtherWitnessType - entry for witness type if 'OTH' is chosen .</value>
        public String OtherWitnessType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WitnessInfoId field.
        /// </summary>
        /// <value>The WitnessInfo id.</value>
        public String WitnessInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WitnessType field.
        /// </summary>
        /// <value>The WitnessType of witness.</value>
        public MCriminalClaimantTypeEntity WitnessType
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

            WitnessInfoEntity toCompareWith = obj as WitnessInfoEntity;
            return toCompareWith == null ? false : ((this.WitnessInfoId == toCompareWith.WitnessInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WitnessInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}