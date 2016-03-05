#region Header

/*****************************************************************************************************
* Description : This file represents a standard InterfaceICA entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			        Author			        Description
*-----------------------------------------------------------------------------------------------------
* 15/10/2010                Swaroop             	 	Created
*****************************************************************************************************/
// <summary>
// File: InterfaceICAEntity.cs
// Description: Represents a standard InterfaceICA entity.
// </summary>
// <copyright file= "InterfaceICAEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;

    /// <summary>
    /// Represents a standard domain entity for InterfaceICA.
    /// It inherits from <see cref="AbstractDocId"/>
    /// </summary>
    [Serializable]
    public class InterfaceICAEntity : AbstractDocId
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CaseNo field.
        /// </summary>
        /// <value>The case no.</value>
        public String CaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfOrder field.
        /// </summary>
        /// <value>The date of order.</value>
        public DateTime? DateOfOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ICAInterfaceId field.
        /// </summary>
        /// <value>The ICA interface id.</value>
        public String ICAInterfaceId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NoOfTry field.
        /// </summary>
        /// <value>The no of try.</value>
        public Int32 NoOfTry
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OrderNo field.
        /// </summary>
        /// <value>The order no.</value>
        public String OrderNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Status field.
        /// </summary>
        /// <value>The status.</value>
        public ICAInterfaceStatus Status
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

            InterfaceICAEntity toCompareWith = obj as InterfaceICAEntity;
            return toCompareWith == null ? false : ((this.ICAInterfaceId == toCompareWith.ICAInterfaceId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ICAInterfaceId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}