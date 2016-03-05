﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

    /// <summary>Class which represents the entity 'SubCaseSpecific.PCInfo'</summary>
    public partial class PBAdminBond : ICaseSpecific
    {
        #region Properties

        /// <summary>Gets or sets the CountriesQualifiedForPractice field. </summary>
        public virtual string PBAdminBondId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfAGCCertIssued field. </summary>
        public virtual string SubmissionGroupId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CircumstancesAndJurisdictions field. </summary>
        public virtual decimal? EstimatedValue
        {
            get;
            set;
        }
        public virtual decimal? FixedValue
        {
            get;
            set;
        }
        public virtual decimal? OtherValue
        {
            get;
            set;
        }
        public virtual decimal? ActualValue
        {
            get;
            set;
        }
        public virtual decimal? SupplimentaryValue
        {
            get;
            set;
        }
        public virtual decimal? EstateValue
        {
            get;
            set;
        }
        public virtual decimal? ExpensesIncurred
        {
            get;
            set;
        }


        /// <summary>Gets or sets the HasSection251dSatisfied field. </summary>
        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HasSection251bSatisfied field. </summary>
        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsAreaOfLPDisclosed field. </summary>
        public virtual string AdminBondReqInd
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
            PBAdminBond toCompareWith = obj as PBAdminBond;
            return toCompareWith == null ? false : ((this.PBAdminBondId == toCompareWith.PBAdminBondId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PBAdminBondId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}