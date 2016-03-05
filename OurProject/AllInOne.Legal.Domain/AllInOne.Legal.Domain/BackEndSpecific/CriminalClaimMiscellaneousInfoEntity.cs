﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'BackEndSpecific.CriminalClaimMiscellaneousInfo'</summary>
    public class CriminalClaimMiscellaneousInfoEntity : IBackEndSpecificEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="CriminalClaimMiscellaneousInfo"/> class.</summary>
        public CriminalClaimMiscellaneousInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AmountClaimed field. </summary>
        public Decimal? AmountClaimed
        {
            get;
            set;
        }

        /*
        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.CriminalClaimMiscellaneousInfo.CriminalClaimInfo - BackEndSpecific.CriminalClaimInfo.CriminalClaimMiscellaneousInfos (m:1)'</summary>
        public CriminalClaimInfoEntity CriminalClaimInfoEntity
        {
            get;
            set;
        }*/
        /// <summary>Gets or sets the CriminalClaimInfoId field. </summary>
        public String CriminalClaimInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CriminalClaimMiscellaneousInfoId field. </summary>
        public String CriminalClaimMiscellaneousInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Description field. </summary>
        public String Description
        {
            get;
            set;
        }

        /// <summary>Gets or sets the GSTAmount field. </summary>
        public Decimal? GSTAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public DateTime LastModifiedDate
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
            CriminalClaimMiscellaneousInfoEntity toCompareWith = obj as CriminalClaimMiscellaneousInfoEntity;
            return toCompareWith == null ? false : ((this.CriminalClaimMiscellaneousInfoId == toCompareWith.CriminalClaimMiscellaneousInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CriminalClaimMiscellaneousInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}