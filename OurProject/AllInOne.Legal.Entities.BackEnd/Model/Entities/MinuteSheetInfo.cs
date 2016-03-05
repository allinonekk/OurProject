﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>Class which represents the entity 'Master.MinuteSheet'</summary>
    public partial class MinuteSheetInfo : ICommon
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MinuteSheet"/> class.</summary>
        public MinuteSheetInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public virtual System.Int64 CaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HearingCategory field. </summary>
        public virtual System.String HearingCategory
        {
            get ;
            set ;
        }

        /// <summary>Gets or sets the HRGID field. </summary>
        public virtual System.Int64 HRGID
        {
            get ;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MinuteSheetInfoId field. </summary>
        public virtual System.String MinuteSheetInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NoteOfEvidence field. </summary>
        public virtual System.String NoteOfEvidence
        {
            get ;
            set;
        }

        /// <summary>Gets or sets the OrderMadeIn field. </summary>
        public virtual System.String OrderMadeIn
        {
            get ;
            set;
        }

        /// <summary>Gets or sets the RegistryInstruction field. </summary>
        public virtual System.String RegistryInstruction
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SessionProceedingStatus field. </summary>        
        public virtual System.String SessionProceedingStatus
        {
            get;
            set ;
        }

        public virtual string InstrToFrcAndCapsStaff
        {
            get;
            set;
        }

        public virtual string RequestForSubCaseInd { get; set; }

        public virtual string RequestForSplLetterInd { get; set; }

        public virtual string OtherDirections { get; set; }

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
            MinuteSheetInfo toCompareWith = obj as MinuteSheetInfo;
            return toCompareWith == null ? false : ((this.MinuteSheetInfoId == toCompareWith.MinuteSheetInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.MinuteSheetInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}