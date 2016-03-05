#region Header

/*****************************************************************************************************
* Description : This file represents a standard SerialNumber entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   14/11/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: SerialNumberEntity.cs
// Description: Represents a standard SerialNumber entity.
// </summary>
// <copyright file= "SerialNumberEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for SerialNumber.
    /// </summary>
    [Serializable]
    public class UndoSerialNumberEntity :AbstractLastModified,  IBackEndSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the DocPrefix field. </summary>
        public System.String DocPrefix
        {
            get;
            set;
        }

        /// <summary>Gets or sets the GenerateFrequency field. </summary>
        
        /// <summary>Gets or sets the SNo field. </summary>
        public System.String SNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Year field. </summary>
        public System.Int32 Year
        {
            get;
            set;
        }

        public string CourtID { get; set; }

        public string ForumID { get; set; }

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
            UndoSerialNumberEntity toCompareWith = obj as UndoSerialNumberEntity;
            return toCompareWith == null ? false : ((this.DocPrefix == toCompareWith.DocPrefix && this.Year == toCompareWith.Year && this.ForumID == toCompareWith.ForumID));
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