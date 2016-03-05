#region Header

/*****************************************************************************************************
* Description : This file represents a standard MDocCode entity.
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
// File: MDocCodeEntity.cs
// Description: Represents a standard MDocCode entity.
// </summary>
// <copyright file= "MDocCodeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MDocCode.
    /// </summary>
    [Serializable]
    public class MDocCodeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MDocCode"/> class.
        /// </summary>
        public MDocCodeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AmendPartyInd field.
        /// </summary>
        /// <value>The amend party ind.</value>
        public String AmendPartyInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AttachmentInd field.
        /// </summary>
        /// <value>The attachment ind.</value>
        public String AttachmentInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ConfigType field.
        /// </summary>
        /// <value>The type of the config.</value>
        public String ConfigType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocCategoryCode field.
        /// </summary>
        /// <value>The doc category code.</value>
        public String DocCategoryCode
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
        /// Gets or sets the DocInd field.
        /// </summary>
        /// <value>The doc ind.</value>
        public String DocInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocLegislationCode field.
        /// </summary>
        /// <value>The doc legislation code.</value>
        public String DocLegislationCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocType field.
        /// </summary>
        /// <value>The type of the doc.</value>
        public String DocType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FormNumber field.
        /// </summary>
        /// <value>The form number.</value>
        public String FormNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the GenDocCode field.
        /// </summary>
        /// <value>The gen doc code.</value>
        public String GenDocCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HideFrFE field.
        /// </summary>
        /// <value>The hide fr FE.</value>
        public String HideFrFE
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IndexDocInd field.
        /// </summary>
        /// <value>The index doc ind.</value>
        public String IndexDocInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the InternalDocInd field.
        /// </summary>
        /// <value>The internal doc ind.</value>
        public String InternalDocInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsDocAmendment field.
        /// </summary>
        /// <value>The is doc amendment.</value>
        public String IsDocAmendment
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsDocRefiled field.
        /// </summary>
        /// <value>The is doc refiled.</value>
        public String IsDocRefiled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsEditAllowed field.
        /// </summary>
        /// <value>The is edit allowed.</value>
        public String IsEditAllowed
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsHidden field.
        /// </summary>
        /// <value>The is hidden.</value>
        public String IsHidden
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MainGroup field.
        /// </summary>
        /// <value>The main group.</value>
        public String MainGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RelatedDocCode field.
        /// </summary>
        /// <value>The related doc code.</value>
        public String RelatedDocCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SealInd field.
        /// </summary>
        /// <value>The seal ind.</value>
        public String SealInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Section field.
        /// </summary>
        /// <value>The section.</value>
        public String Section
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Seqno field.
        /// </summary>
        /// <value>The seqno.</value>
        public Int32 Seqno
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCategory field.
        /// </summary>
        /// <value>The sub category.</value>
        public String SubCategory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubFormNumber field.
        /// </summary>
        /// <value>The sub form number.</value>
        public String SubFormNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the target recipient.
        /// </summary>
        /// <value>The type of the target recipient.</value>
        public String TargetRecipientType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Title field.
        /// </summary>
        /// <value>The title.</value>
        public String Title
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WFType field.
        /// </summary>
        /// <value>The type of the WF.</value>
        public String WFType
        {
            get;
            set;
        }

        public string TitlePrefix
        {
            get;
            set;
        }

        public string IsDocFeeTobeDeducted
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
            MDocCodeEntity toCompareWith = obj as MDocCodeEntity;
            return toCompareWith == null ? false : ((this.DOCCode == toCompareWith.DOCCode));
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
            toReturn ^= this.DOCCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}