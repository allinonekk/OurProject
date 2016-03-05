#region Header

/*****************************************************************************************************
* Description : This file represents a standard MHRGPredefinedDate entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   23/07/2012   		      Nithin                 	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MHRGPredefinedDateEntity.cs
// Description: Represents a standard MSentence entity.
// </summary>
// <copyright file= "MHRGPredefinedDateEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

    /// <summary>Class which represents the entity 'Master.MHRGPredefinedDate'</summary>
    [Serializable]
    public class MHRGPredefinedDate: IMaster
    {
        #region Properties

        /// <summary>Gets or sets the SentenceCode field. </summary>
        public virtual string HRGPredefinedDateId
        {
            get;
            set;
        }

        public virtual string HRGTypeCode
        {
            get;
            set;
        }

        public virtual string FixInfoDescription
        {
            get;
            set;
        }

        public virtual DateTime HrgDateTime
        {
            get;
            set;
        }

        public virtual string ObsInd
        {
            get;
            set;
        }

        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }
        public virtual string CoramCode
        {
            get;
            set;
        }
        public virtual string UserID
        {
            get;
            set;
        }
        public virtual string DSGCode
        {
            get;
            set;
        }
        public virtual string HRGRoomCode
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
            MHRGPredefinedDate toCompareWith = obj as MHRGPredefinedDate;
            return toCompareWith == null ? false : ((this.HRGPredefinedDateId == toCompareWith.HRGPredefinedDateId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HRGPredefinedDateId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}