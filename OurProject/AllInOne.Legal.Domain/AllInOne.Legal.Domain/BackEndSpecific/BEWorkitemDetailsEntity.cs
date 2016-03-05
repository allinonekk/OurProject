#region Header

/*****************************************************************************************************
* Description : This file represents a standard WorkitemDetails entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   21/06/2011  		      CJ             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: FEWorkitemDetailsEntity.cs
// Description: Represents a standard WorkitemDetails entity (FE).
// </summary>
// <copyright file= "FEWorkitemDetailsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for WorkitemDetails.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class BEWorkitemDetailsEntity : AbstractLastModified, IBackEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CaseInfoID field.
        /// </summary>
        /// <value>The CaseInfoID.</value>
        public Int64 CaseInfoID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocID field.
        /// </summary>
        /// <value>The doc id.</value>
        public String DocID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoID field.
        /// </summary>
        /// <value>The SubCaseInfoID.</value>
        public Int64? SubCaseInfoID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkflowSerialNo field.
        /// </summary>
        /// <value>The Work flow Serial no.</value>
        public String WorkflowSerialNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkitemInd field.
        /// </summary>
        /// <value>The WorkitemInd.</value>
        public WorkItemDetailsIndType WorkitemInd
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
            BEWorkitemDetailsEntity toCompareWith = obj as BEWorkitemDetailsEntity;
            return toCompareWith == null ? false : ((this.WorkflowSerialNo == toCompareWith.WorkflowSerialNo) && (this.CaseInfoID == toCompareWith.CaseInfoID) && (this.DocID == toCompareWith.DocID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WorkflowSerialNo.GetHashCode();
            toReturn ^= this.CaseInfoID.GetHashCode();
            toReturn ^= this.DocID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}