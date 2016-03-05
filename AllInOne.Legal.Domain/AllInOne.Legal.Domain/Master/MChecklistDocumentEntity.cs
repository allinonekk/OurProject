#region Header

/*****************************************************************************************************
* Description : This file represents a standard MChecklistDocument entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MChecklistDocumentEntity.cs
// Description: Represents a standard MChecklistDocument entity.
// </summary>
// <copyright file= "MChecklistDocumentEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MChecklistDocument.
    /// </summary>
    [Serializable]
    public class MChecklistDocumentEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets the ChecklistDocId field.
        /// </summary>
        /// <value>The checklist doc id.</value>
        public Int64 ChecklistDocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the checklist id.
        /// </summary>
        /// <value>The checklist id.</value>
        public Int64? ChecklistId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocCode field.
        /// </summary>
        /// <value>The doc code.</value>
        public String DocCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item no.</value>
        public Int32? ItemNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the MainDocInd field.
        /// </summary>
        /// <value>The main doc ind.</value>
        public String MainDocInd
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the MandatoryInd field.
        /// </summary>
        /// <value>The mandatory ind.</value>
        public String MandatoryInd
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the StageNo field.
        /// </summary>
        /// <value>The stage no.</value>
        public Int32? StageNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ValidationRule field.
        /// </summary>
        /// <value>The validation rule.</value>
        public String ValidationRule
        {
            get; set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            MChecklistDocumentEntity toCompareWith = obj as MChecklistDocumentEntity;
            return toCompareWith == null ? false : ((this.ChecklistDocId == toCompareWith.ChecklistDocId));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ChecklistDocId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}