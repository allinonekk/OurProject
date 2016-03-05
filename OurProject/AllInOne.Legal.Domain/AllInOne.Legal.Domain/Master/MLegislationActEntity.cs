#region Header

/*****************************************************************************************************
* Description : This file represents a standard MLegislation entity.
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
// File: MLegislationEntity.cs
// Description: Represents a standard MLegislationEntity entity.
// </summary>
// <copyright file= "MLegislationEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MLegislationEntity.
    /// </summary>
    [Serializable]
    public class MLegislationActEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MLegislationAct"/> class.
        /// </summary>
        public MLegislationActEntity()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MLegislationAct"/> for NHibernate Pagination.
        /// </summary>
        public MLegislationActEntity(string actCode, string description, string isInterfaced, string obsInd)
            : base()
        {
            ActCode = actCode;
            Description = description;
            IsInterfaced = isInterfaced;
            ObsInd = (YesNo)Enum.Parse(typeof(YesNo), obsInd.ToString(), true);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ActCode field.
        /// </summary>
        /// <value>The act code.</value>
        public String ActCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public String IsInterfaced
        {
            get;
            set;
        }

        public DateTime? EffectiveDate
        {
            get;
            set;
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
            MLegislationActEntity toCompareWith = obj as MLegislationActEntity;
            return toCompareWith == null ? false : ((this.ActCode == toCompareWith.ActCode));
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
            toReturn ^= this.ActCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}