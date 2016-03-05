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

    /// <summary>Class which represents the entity 'Common.ForeignLPSolicitorRegDetail'</summary>
    public partial class ForeignLPSolicitorRegDetail : ICommon
    {
        #region Properties

        public virtual String ForeignLPSolicitorRegId
        {
            get;
            set;
        }

        public virtual Int32 ItemNo
        {
            get;
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

        /// <summary>Represents the navigator which is mapped onto the association 'LawFirm.ForeignLPSolicitorReg.LawFirmForeignLFID - LawFirm.LawFirm.ForeignLPSolicitorRegForeignLFID (m:1)'</summary>
        public virtual string ForeignLFID
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LawFirm.ForeignLPSolicitorReg.LawFirmSingaporeLFID - LawFirm.LawFirm.ForeignLPSolicitorRegSingaporeLFID (m:1)'</summary>
        public virtual string SingaporeLFID
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LawFirm.ForeignLPSolicitorReg.MTypeOfForeignLawPractice - Master.MTypeOfForeignLawPractice.ForeignLPSolicitorRegs (m:1)'</summary>
        public virtual MLawPracticeType MLawPracticeType
        {
            get;
            set;
        }


        public virtual string ObsInd
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
            ForeignLPSolicitorRegDetail toCompareWith = obj as ForeignLPSolicitorRegDetail;
            return toCompareWith == null ? false : ((this.ForeignLPSolicitorRegId == toCompareWith.ForeignLPSolicitorRegId) && (this.ItemNo == toCompareWith.ItemNo));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ForeignLPSolicitorRegId.GetHashCode();
            toReturn ^= this.ItemNo.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}