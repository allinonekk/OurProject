#region Header

/*****************************************************************************************************
* Description : This file represents a standard MHRGTimeLine entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   26/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MHRGTimeLineEntity.cs
// Description: Represents a standard MHRGTimeLineEntity entity.
// </summary>
// <copyright file= "MHRGTimeLineEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MHRGTimeLineEntity.
    /// </summary>
    [Serializable]
    public class MHRGTimeLineEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Fields

        private Int64 _hrgTimeLineID;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MHRGTimeLine"/> class.
        /// </summary>
        public MHRGTimeLineEntity()
            : base()
        {
            _hrgTimeLineID = default(Int64);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the CommencingDocCode field.
        /// </summary>
        /// <value>The commencing doc code.</value>
        public String CommencingDocCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the CourtInd field.
        /// </summary>
        /// <value>The court ind.</value>
        public String CourtInd
        {
            get; set;
        }

        /// <summary>
        /// Gets the HrgTimeLineID field.
        /// </summary>
        /// <value>The HRG time line ID.</value>
        public Int64 HrgTimeLineID
        {
            get { return _hrgTimeLineID; }
        }

        /// <summary>
        /// Gets or sets the SubDoCCode field.
        /// </summary>
        /// <value>The sub do C code.</value>
        public String SubDoCCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the TimeLineDays field.
        /// </summary>
        /// <value>The time line days.</value>
        public Int32? TimeLineDays
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
            if (obj == null)
            {
                return false;
            }
            MHRGTimeLineEntity toCompareWith = obj as MHRGTimeLineEntity;
            return toCompareWith == null ? false : ((this.CourtInd == toCompareWith.CourtInd) && (this.HrgTimeLineID == toCompareWith.HrgTimeLineID));
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
            toReturn ^= this.CourtInd.GetHashCode();
            toReturn ^= this.HrgTimeLineID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}