﻿#region Header

/*************************************************************************************************************************
* Description : This file represents a standard CaseParty entity.
*
*-------------------------------------------------------------------------------------------------------------------------
*	                                    File History
*-------------------------------------------------------------------------------------------------------------------------
*
*	Date			        Author			        Description
*-------------------------------------------------------------------------------------------------------------------------
* 20/09/2010                Japheth             	Created
* 25/09/2010   		        Swaroop             	Updated
* 25/09/2010   		        Swaroop             	Updated
* 16/02/2011                Rajeev                  Modified - Added IComparable interface for Sorting the ListItems.
*************************************************************************************************************************/
// <summary>
// File: CasePartyEntity.cs
// Description: Represents a standard CaseParty entity.
// </summary>
// <copyright file= "CasePartyEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;


    /// <summary>
    /// Represents a standard domain entity for CaseParty.
    /// It inherits from <see cref="AbstractCasePartyCaseInfo"/>
    /// </summary>
  
    public partial class InterimCasePartyStatus: ICase
    {
        #region Properties
        public virtual string InterimCasePartyStatusId { get; set; }

        public virtual string WorkflowSerialNo { get; set; }

        public virtual string DocId { get; set; }

        public virtual string CasePartyId { get; set; }

        public virtual MPartyStatus PartyStatusCode { get; set; }

        public virtual DateTime? PartyStatusDate { get; set; }

        public virtual MPartyStatus CounterClaimPartyStatusCode { get; set; }

        public virtual DateTime? CounterClaimPartyStatusDate { get; set; }

        public virtual string LastModifiedBy { get; set; }

        public virtual DateTime LastModifiedDate { get; set; }
     
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

            InterimCasePartyStatus toCompareWith = obj as InterimCasePartyStatus;
            return toCompareWith == null ? false : ((this.InterimCasePartyStatusId == toCompareWith.InterimCasePartyStatusId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.InterimCasePartyStatusId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}