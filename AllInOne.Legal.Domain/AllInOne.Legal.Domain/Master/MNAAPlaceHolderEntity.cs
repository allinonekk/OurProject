#region Header

/*****************************************************************************************************
* Description : This file represents a standard MNAAPlaceHolder entity.
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
// File: MNAAPlaceHolderEntity.cs
// Description: Represents a standard MNAAPlaceHolderEntity entity.
// </summary>
// <copyright file= "MNAAPlaceHolderEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MNAAPlaceHolderEntity.
    /// </summary>
    [Serializable]
    public class MNAAPlaceHolderEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Fields

        private Int32 _placeHolderID;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MNAAPlaceHolder"/> class.
        /// </summary>
        public MNAAPlaceHolderEntity()
            : base()
        {
            _placeHolderID = default(System.Int32);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AdditionalRemarks field.
        /// </summary>
        /// <value>The additional remarks.</value>
        public String AdditionalRemarks
        {
            get; set;
        }

        /// <summary>
        /// Gets the PlaceHolderID field.
        /// </summary>
        /// <value>The place holder ID.</value>
        public Int32 PlaceHolderID
        {
            get { return _placeHolderID; }
        }

        /// <summary>
        /// Gets or sets the PlaceHolderName field.
        /// </summary>
        /// <value>The name of the place holder.</value>
        public String PlaceHolderName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the PlaceHolderType field.
        /// </summary>
        /// <value>The type of the place holder.</value>
        public String PlaceHolderType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SampleOutput field.
        /// </summary>
        /// <value>The sample output.</value>
        public String SampleOutput
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SampleUsage field.
        /// </summary>
        /// <value>The sample usage.</value>
        public String SampleUsage
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SampleValue field.
        /// </summary>
        /// <value>The sample value.</value>
        public String SampleValue
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
            MNAAPlaceHolderEntity toCompareWith = obj as MNAAPlaceHolderEntity;
            return toCompareWith == null ? false : ((this.PlaceHolderID == toCompareWith.PlaceHolderID));
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
            toReturn ^= this.PlaceHolderID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}