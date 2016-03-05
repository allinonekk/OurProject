#region Header

/*****************************************************************************************************
* Description : This file represents a standard DCACAInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   14/01/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: DCACAInfoEntity.cs
// Description: Represents a standard DCACAInfo entity.
// </summary>
// <copyright file= "DCACAInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for JMChecklistInfoEntity.
    /// It inherits from <see cref="ICaseSpecificEntity"/>
    /// </summary>
    [Serializable]
    public class JMChecklistInfoEntity : AbstractLastModified, ICaseSpecificEntity
    {
        #region Properties

        public String JMChecklistInfoid { get; set;}
        public String DocId  { get; set;}
        public DateTime? DateOfService { get; set; }
        public String EnglishNewsPaperName  { get; set;}
        public DateTime? EnglishNewsPaperPubDate { get; set; }
        public String ChineseNewsPaperName  { get; set;}
        public DateTime? ChineseNewsPaperPubDate { get; set; }
        public DateTime? GazetteNotificationDate { get; set; }
        public DateTime? AcraLodgmentDate { get; set; }
        public String ReceiptNumber  { get; set;}
        public DateTime DepositDate { get; set; }
        public Decimal? DepositAmount { get; set; }

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
            if (obj == null)
            {
                return false;
            }

            JMChecklistInfoEntity toCompareWith = obj as JMChecklistInfoEntity;
            return toCompareWith == null ? false : ((this.JMChecklistInfoid == toCompareWith.JMChecklistInfoid));
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
            toReturn ^= this.JMChecklistInfoid.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}