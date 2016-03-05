#region Header

/*****************************************************************************************************
* Description : This file represents a standard MNAAAlertEventsTemplate entity.
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
// File: MNAAAlertEventsTemplateEntity.cs
// Description: Represents a standard MNAAAlertEventsTemplateEntity entity.
// </summary>
// <copyright file= "MNAAAlertEventsTemplateEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MNAAAlertEventsTemplateEntity.
    /// </summary>
    [Serializable]
    public class MNAAAlertEventsTemplateEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Fields

        private Int32 _alertEventTemplateID;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MNAAAlertEventsTemplate"/> class.
        /// </summary>
        public MNAAAlertEventsTemplateEntity()
            : base()
        {
            _alertEventTemplateID = default(System.Int32);
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets the AlertEventTemplateID field. </summary>
        public Int32 AlertEventTemplateID
        {
            get { return _alertEventTemplateID; }
        }

        /// <summary>
        /// Gets or sets the BEInboxLocation field.
        /// </summary>
        /// <value>The BE inbox location.</value>
        public String BEInboxLocation
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the BETaskItemMessage field.
        /// </summary>
        /// <value>The BE task item message.</value>
        public String BETaskItemMessage
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the EmailMessage field.
        /// </summary>
        /// <value>The email message.</value>
        public String EmailMessage
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the EmailSubject field.
        /// </summary>
        /// <value>The email subject.</value>
        public String EmailSubject
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the FAXMessage field.
        /// </summary>
        /// <value>The FAX message.</value>
        public String FAXMessage
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the FETaskItemMessage field.
        /// </summary>
        /// <value>The FE task item message.</value>
        public String FETaskItemMessage
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the IsGroupAllowed field.
        /// </summary>
        /// <value>The is group allowed.</value>
        public String IsGroupAllowed
        {
            get; set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Master.MNAAAlertEventsTemplate.MCaseType - Master.MCaseType.MNAAAlertEventsTemplates (m:1)'
        /// </summary>
        /// <value>The type of the M case.</value>
        public MCaseTypeEntity MCaseType
        {
            get; set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Master.MNAAAlertEventsTemplate.MCourtType - Master.MCourtType.MNAAAlertEventsTemplates (m:1)'
        /// </summary>
        /// <value>The type of the M court.</value>
        public MCourtTypeEntity MCourtType
        {
            get; set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Master.MNAAAlertEventsTemplate.MNAASubCategory - Master.MNAASubCategory.MNAAAlertEventsTemplates (m:1)'
        /// </summary>
        /// <value>The MNAA sub category.</value>
        public MNAASubCategoryEntity MNAASubCategory
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SMSMessage field.
        /// </summary>
        /// <value>The SMS message.</value>
        public String SMSMessage
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
            MNAAAlertEventsTemplateEntity toCompareWith = obj as MNAAAlertEventsTemplateEntity;
            return toCompareWith == null ? false : ((this.AlertEventTemplateID == toCompareWith.AlertEventTemplateID));
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
            toReturn ^= this.AlertEventTemplateID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}