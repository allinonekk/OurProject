#region Header

/*****************************************************************************************************
* Description : This file represents a standard MForumType entity.
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
// File: MForumTypeEntity.cs
// Description: Represents a standard MForumType entity.
// </summary>
// <copyright file= "MForumTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MForumType.
    /// </summary>
    [Serializable]
    public class MForumTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MForumType"/> class.
        /// </summary>
        public MForumTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the CourtId field.
        /// </summary>
        /// <value>The court Id.</value>
        public String CourtId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CourtSeal field.
        /// </summary>
        /// <value>The court seal.</value>
        public String CourtSeal
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the forum id.
        /// </summary>
        /// <value>The forum id.</value>
        public String ForumId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NeutralCiteCode field.
        /// </summary>
        /// <value>The neutral cite code.</value>
        public String NeutralCiteCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RegSignature field.
        /// </summary>
        /// <value>The reg signature.</value>
        public String RegSignature
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SeqNo field.
        /// </summary>
        /// <value>The seq no.</value>
        public Int32 SeqNo
        {
            get;
            set;
        }

        public String HeaderCentreImagePath
        {
            get;
            set;
        }

        public string HeaderRightImagePath
        {
            get;
            set;
        }

        public string FooterCentreImagePath
        {
            get;
            set;
        }

        public string ADMHeaderRightImagePath
        {
            get;
            set;
        }

        public string ForumSeal { get; set; }

        public string ForumSignature { get; set; }

        public string EFormHeaderDescription { get; set; }

        public string EFormFooterDescription { get; set; }
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
            MForumTypeEntity toCompareWith = obj as MForumTypeEntity;
            return toCompareWith == null ? false : ((this.ForumId == toCompareWith.ForumId));
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
            toReturn ^= this.ForumId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}