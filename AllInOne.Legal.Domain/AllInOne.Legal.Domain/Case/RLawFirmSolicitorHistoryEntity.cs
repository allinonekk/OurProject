﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;
    using System;
    /// <summary>Class which represents the entity 'Case.RLawFirmSolicitorsEntity'</summary>
    public class RLawFirmSolicitorHistoryEntity : AbstractLastModified, ICaseEntity
    {
        #region Properties

        public string LFID
        {
            get;
            set;
        }

        public long SolicitorID
        {
            get;
            set;
        }

        public DateTime StartDate
        {
            get;
            set;
        }

        public DateTime EndDate { get; set; }
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
            RLawFirmSolicitorsEntity toCompareWith = obj as RLawFirmSolicitorsEntity;
            return toCompareWith == null ? false : ((this.LFID == toCompareWith.LFID) && (this.SolicitorID == toCompareWith.SolicitorID)
                && (this.StartDate == toCompareWith.StartDate));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LFID.GetHashCode();
            toReturn ^= this.SolicitorID.GetHashCode();
            toReturn ^= this.StartDate.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}