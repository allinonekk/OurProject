#region Header

/*****************************************************************************************************
* Description : This file represents a standard ADMWAInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   16/11/2010   		      Swaroop             	 	Created
*****************************************************************************************************/
// <summary>
// File: ADMWAInfoEntity.cs
// Description: Represents a standard ADMWAInfo entity.
// </summary>
// <copyright file= "ADMWAInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for ADMWAInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class ADMWAInfoEntity : AbstractSubmissionGroup, ISubCaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ADMWAInfoId field.
        /// </summary>
        /// <value>The ADMWA info id.</value>
        public String ADMWAInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Admirality.ADMWAInfo.CasePartyAICDetail - Case.CasePartyAICDetail.ADMWAInfos (m:1)'
        /// </summary>
        /// <value>The case party AIC detail.</value>
        public String AICID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CargoAICID field. </summary>
        public System.String CargoAICID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CargoDCPAICID field. </summary>
        public System.String CargoDCPAICID
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Admirality.ADMWAInfo.DocCasePartyAICDetail - Document.DocCasePartyAICDetail.ADMWAInfos (m:1)'
        /// </summary>
        /// <value>The doc case party AIC detail.</value>
        public String DCPAICID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WAType field.
        /// </summary>
        /// <value>The type of the WA.</value>
        public TypeOfArrest WAType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WA type remarks.
        /// </summary>
        /// <value>The WA type remarks.</value>
        public String WATypeRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is exec out off hour.
        /// </summary>
        /// <value>The is exec out off hour.</value>
        public YesNo IsExecOutOffHour
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

            ADMWAInfoEntity toCompareWith = obj as ADMWAInfoEntity;
            return toCompareWith == null ? false : ((this.ADMWAInfoId == toCompareWith.ADMWAInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ADMWAInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}