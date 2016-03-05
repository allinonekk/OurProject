﻿#region Header

/*****************************************************************************************************
* Description : This file represents a standard MBillType entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MBillTypeEntity.cs
// Description: Represents a standard MBillType entity.
// </summary>
// <copyright file= "MBillTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MBillType.
    /// </summary>
    [Serializable]
    public class RMHRGTypePaperMinuteSheetTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MBillType"/> class.
        /// </summary>
        public RMHRGTypePaperMinuteSheetTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public string HRGTypePaperMinuteSheetID
        {
            get;
            set;
        }

        public MForumTypeEntity MForumType
        {
            get;
            set;
        }

        public MHearingTypeEntity MHearingType
        {
            get;
            set;

        }

        public MDesignationEntity MDesignation
        {
            get;
            set;
        }

        public MPaperMinuteSheetTypeEntity MPaperMinuteSheetType
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the BillTypeCode field.
        /// </summary>
        /// <value>The bill type code.</value>
        public string PaperMSTypeCode
        {
            get;
            set;
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
            if (obj == null)
            {
                return false;
            }
            RMHRGTypePaperMinuteSheetTypeEntity toCompareWith = obj as RMHRGTypePaperMinuteSheetTypeEntity;
            return toCompareWith == null ? false : ((this.HRGTypePaperMinuteSheetID == toCompareWith.HRGTypePaperMinuteSheetID));
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
            toReturn ^= this.HRGTypePaperMinuteSheetID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}