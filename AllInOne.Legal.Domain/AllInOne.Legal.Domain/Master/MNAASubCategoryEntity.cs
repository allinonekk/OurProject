#region Header

/*****************************************************************************************************
* Description : This file represents a standard MNAASubCategory entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   26/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MNAASubCategoryEntity.cs
// Description: Represents a standard MNAASubCategoryEntity entity.
// </summary>
// <copyright file= "MNAASubCategoryEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MNAASubCategoryEntity.
    /// </summary>
    [Serializable]
    public class MNAASubCategoryEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MNAASubCategory"/> class.
        /// </summary>
        public MNAASubCategoryEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the BEAlert field.
        /// </summary>
        /// <value>The BE alert.</value>
        public String BEAlert
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the BELocation field.
        /// </summary>
        /// <value>The BE location.</value>
        public String BELocation
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the BETaskName field.
        /// </summary>
        /// <value>The name of the BE task.</value>
        public String BETaskName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the CaseSpecific field.
        /// </summary>
        /// <value>The case specific.</value>
        public String CaseSpecific
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the CoramAvailable field.
        /// </summary>
        /// <value>The coram available.</value>
        public String CoramAvailable
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the FEAlert field.
        /// </summary>
        /// <value>The FE alert.</value>
        public String FEAlert
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the HearingAvailable field.
        /// </summary>
        /// <value>The hearing available.</value>
        public String HearingAvailable
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SubCategoryID field.
        /// </summary>
        /// <value>The sub category ID.</value>
        public Int32 SubCategoryID
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SyncMessageFlag field.
        /// </summary>
        /// <value>The sync message flag.</value>
        public String SyncMessageFlag
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the VenueAvailable field.
        /// </summary>
        /// <value>The venue available.</value>
        public String VenueAvailable
        {
            get; set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            MNAASubCategoryEntity toCompareWith = obj as MNAASubCategoryEntity;
            return toCompareWith == null ? false : ((this.SubCategoryID == toCompareWith.SubCategoryID));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SubCategoryID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}