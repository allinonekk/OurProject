#region Header

/*****************************************************************************************************
* Description : This file represents a standard MSummonsParam entity.
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
// File: MSummonsParamEntity.cs
// Description: Represents a standard MSummonsParam entity.
// </summary>
// <copyright file= "MSummonsParamEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MSummonsParamEntity.
    /// </summary>
    [Serializable]
    public class MSummonsParamEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MSummonsParam"/> class.
        /// </summary>
        public MSummonsParamEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the CorrespondingFormNo field.
        /// </summary>
        /// <value>The corresponding form no.</value>
        public String CorrespondingFormNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DOCCode field.
        /// </summary>
        /// <value>The DOC code.</value>
        public String DOCCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MainBodyText field.
        /// </summary>
        /// <value>The main body text.</value>
        public String MainBodyText
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Master.MSummonsParam.MCourtType - Master.MCourtType.MSummonsParams (m:1)'
        /// </summary>
        /// <value>The type of the M court.</value>
        public MCourtTypeEntity MCourtType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Master.MSummonsParam.MNOACode - Master.MNOACode.MSummonsParams (m:1)'
        /// </summary>
        /// <value>The MNOA code.</value>
        public MNOACodeEntity MNOACode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ParamID field.
        /// </summary>
        /// <value>The param ID.</value>
        public String ParamID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ShowGrounds field.
        /// </summary>
        /// <value>The show grounds.</value>
        public String ShowGrounds
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ShowPrayers field.
        /// </summary>
        /// <value>The show prayers.</value>
        public String ShowPrayers
        {
            get;
            set;
        }

        public string DefaultEndorsementType
        {
            get;
            set;
        }

        public MCaseTypeEntity MCaseType
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
            MSummonsParamEntity toCompareWith = obj as MSummonsParamEntity;
            return toCompareWith == null ? false : ((this.ParamID == toCompareWith.ParamID));
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
            toReturn ^= this.ParamID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}