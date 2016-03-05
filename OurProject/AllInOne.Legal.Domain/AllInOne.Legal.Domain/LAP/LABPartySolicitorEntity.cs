#region Header

/*****************************************************************************************************
* Description : This file represents a standard LABPartySolicitor entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LABPartySolicitorEntity.cs
// Description: Represents a standard LABPartySolicitor entity.
// </summary>
// <copyright file= "LABPartySolicitorEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LAP
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for LABPartySolicitor.
    /// It inherits from <see cref="AbstractLABParty"/>
    /// </summary>
    [Serializable]
    public class LABPartySolicitorEntity : AbstractLABParty, ILAPEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the LABPartySolicitorId field.
        /// </summary>
        /// <value>The LAB party solicitor id.</value>
        public String LABPartySolicitorId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFID.
        /// </summary>
        /// <value>The LFID.</value>
        public String LFID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RepresentedBy field.
        /// </summary>
        /// <value>The represented by.</value>
        public PartyRepresentedBy RepresentedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SolicitorId field.
        /// </summary>
        /// <value>The solicitor id.</value>
        public Int64? SolicitorId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SolicitorName field.
        /// </summary>
        /// <value>The name of the solicitor.</value>
        public String SolicitorName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the StartDate field.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UEN field.
        /// </summary>
        /// <value>The UEN.</value>
        public String UEN
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

            LABPartySolicitorEntity toCompareWith = obj as LABPartySolicitorEntity;
            return toCompareWith == null ? false : ((this.LABPartySolicitorId == toCompareWith.LABPartySolicitorId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LABPartySolicitorId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}