#region Header

/*****************************************************************************************************
* Description : This file represents a standard BillOfSaleInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   16/11/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: BillOfSaleInfoEntity.cs
// Description: Represents a standard BillOfSaleInfo entity.
// </summary>
// <copyright file= "BillOfSaleInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for BillOfSaleInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class BillOfSaleInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the BillOfSaleInfoId field.
        /// </summary>
        /// <value>The bill of sale info id.</value>
        public String BillOfSaleInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the InstrumentDate field.
        /// </summary>
        /// <value>The instrument date.</value>
        public DateTime? InstrumentDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the InstrumentName field.
        /// </summary>
        /// <value>The name of the instrument.</value>
        public String InstrumentName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsAbsoluteBillOfSale field.
        /// </summary>
        /// <value>The is absolute bill of sale.</value>
        public YesNo IsAbsoluteBillOfSale
        {
            get;
            set;
        }

        public DateTime? SatisfactionDate
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

            BillOfSaleInfoEntity toCompareWith = obj as BillOfSaleInfoEntity;
            return toCompareWith == null ? false : ((this.BillOfSaleInfoId == toCompareWith.BillOfSaleInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BillOfSaleInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}