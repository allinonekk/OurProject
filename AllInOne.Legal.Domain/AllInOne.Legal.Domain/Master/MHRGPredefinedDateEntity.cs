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

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MHRGPredefinedDate'</summary>
    [Serializable]
    public class MHRGPredefinedDateEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the SentenceCode field. </summary>
        public string HRGPredefinedDateId
        {
            get;
            set;
        }

        public string HRGTypeCode
        {
            get;
            set;
        }

        public string FixInfoDescription
        {
            get;
            set;
        }

        public DateTime HrgDateTime
        {
            get;
            set;
        }

        public YesNo ObsInd
        {
            get;
            set;
        }

        public string CoramCode
        {
            get;
            set;
        }

        public string UserID
        {
            get;
            set;
        }

        public string DSGCode
        {
            get;
            set;
        }

        public string HRGRoomCode
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
            MHRGPredefinedDateEntity toCompareWith = obj as MHRGPredefinedDateEntity;
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