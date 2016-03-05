#region Header

/*****************************************************************************************************
* Description : This file represents a standard MTaskListType entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   05/04/2011   		      CJ                 	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MTaskListTypeEntity.cs
// Description: Represents a standard MTaskListType entity.
// </summary>
// <copyright file= "MTaskListTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MTaskListType'</summary>
    [Serializable]
    public class MTaskListTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the TaskListTypeCode field. </summary>
        public String TaskListTypeCode
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
            MTaskListTypeEntity toCompareWith = obj as MTaskListTypeEntity;
            return toCompareWith == null ? false : ((this.TaskListTypeCode == toCompareWith.TaskListTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.TaskListTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}