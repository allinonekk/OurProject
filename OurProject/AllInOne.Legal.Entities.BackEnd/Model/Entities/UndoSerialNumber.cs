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

    /// <summary>Class which represents the entity 'Enforcement.SerialNumber'</summary>
    public partial class UndoSerialNumber : IBackEndSpecific
    {


        #region Properties


        /// <summary>Gets or sets the DocPrefix field. </summary>
        public virtual System.String DocPrefix
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


        /// <summary>Gets or sets the SNo field. </summary>
        public virtual System.String SNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Year field. </summary>
        public virtual System.Int32 Year
        {
            get;
            set;
        }

        public virtual string CourtID { get; set; }

        public virtual string ForumID{ get; set; }
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
            UndoSerialNumber toCompareWith = obj as UndoSerialNumber;
            return toCompareWith == null ? false : ((this.DocPrefix == toCompareWith.DocPrefix
                && this.Year == toCompareWith.Year
                && this.ForumID == toCompareWith.ForumID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocPrefix.GetHashCode();
            toReturn ^= this.Year.GetHashCode();
            toReturn ^= this.ForumID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}