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

    /// <summary>Class which represents the entity 'Master.MCalendarType'</summary>
    public partial class MCalendarType : IMaster
    {
        #region Fields

        private System.String _calendarTypeDesc;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MForumType _mForumType;

        #endregion Fields

       

        #region Properties

        /// <summary>Gets or sets the CalendarTypeDesc field. </summary>
        public virtual System.String CalendarTypeDesc
        {
            get { return _calendarTypeDesc; }
            set { _calendarTypeDesc = value; }
        }

        /// <summary>Gets the CalendarTypeId field. </summary>
        public virtual System.Int64 CalendarTypeId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get { return _lastModifiedBy; }
            set { _lastModifiedBy = value; }
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get { return _lastModifiedDate; }
            set { _lastModifiedDate = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MCalendarType.MForumType - Master.MForumType.MCalendarTypes (m:1)'</summary>
        public virtual MForumType MForumType
        {
            get { return _mForumType; }
            set { _mForumType = value; }
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
            MCalendarType toCompareWith = obj as MCalendarType;
            return toCompareWith == null ? false : ((this.CalendarTypeId == toCompareWith.CalendarTypeId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CalendarTypeId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}