#region Header

/*****************************************************************************************************
* Description : This file represents a standard Mailbox entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   28/10/2010  		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MailboxEntity.cs
// Description: Represents a standard Mailbox entity.
// </summary>
// <copyright file= "MailboxEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for Mailbox.
    /// It inherits from <see cref="AbstractDocCaseParty"/>
    /// </summary>
    [Serializable]
    public class MailboxEntity : AbstractCaseInfoSubmissionGroup, IFrontEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AlertItemsCount field.
        /// </summary>
        /// <value>The alert items count.</value>
        public Int32? AlertItemsCount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseName field.
        /// </summary>
        /// <value>The name of the case.</value>
        public String CaseName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseNo field.
        /// </summary>
        /// <value>The case no.</value>
        public String CaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CheckListInstanceID field.
        /// </summary>
        /// <value>The check list instance id.</value>
        public String CheckListInstanceId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CourtItemsCount field.
        /// </summary>
        /// <value>The court items count.</value>
        public Int32? CourtItemsCount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Date field.
        /// </summary>
        /// <value>The date.</value>
        public DateTime? Date
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocCode field.
        /// </summary>
        /// <value>The DocCode.</value>
        public MDocCodeEntity DocCode
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.Mailbox.DocumentInfo - Document.DocumentInfo.Mailboxes (m:1)'
        /// </summary>
        /// <value>The document info.</value>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocumentTitle field.
        /// </summary>
        /// <value>The document title.</value>
        public String DocumentTitle
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.Mailbox.EServiceInfo - EService.EServiceInfo.Mailboxes (m:1)'
        /// </summary>
        /// <value>The E service info.</value>
        public String EServiceInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FileLocation field.
        /// </summary>
        /// <value>The file location.</value>
        public String FileLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FilingType field.
        /// </summary>
        /// <value>The FilingType.</value>
        public DocumentFilingType FilingType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the GroupID field.
        /// </summary>
        /// <value>The group ID.</value>
        public Int64? GroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsUrgent field.
        /// </summary>
        /// <value>The IsUrgent.</value>
        public YesNo IsUrgent
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UserId field.
        /// </summary>
        /// <value>The user Id.</value>
        public String LawfirmUserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFID field.
        /// </summary>
        /// <value>The LFID.</value>
        public String LFID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the MailBoxId field.
        /// </summary>
        /// <value>The mail box id.</value>
        public Int64 MailBoxId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MessageDescription field.
        /// </summary>
        /// <value>The message description.</value>
        public String MessageDescription
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MessageType field.
        /// </summary>
        /// <value>The type of the message.</value>
        public MailboxMessageType MessageType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ParentDocId field.
        /// </summary>
        /// <value>The ParentDocId.</value>
        public String ParentDocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ReadStatus field.
        /// </summary>
        /// <value>The read status.</value>
        public Boolean ReadStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Status field.
        /// </summary>
        /// <value>The status.</value>
        public MailboxStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public String SubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseNo field.
        /// </summary>
        /// <value>The sub case no.</value>
        public String SubCaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UserId Field.
        /// </summary>
        /// <value>The user id.</value>
        public String UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkitemGroupId field.
        /// </summary>
        /// <value>The workitem group Id.</value>
        public String WorkitemGroupId
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
            if (obj == null)
            {
                return false;
            }

            MailboxEntity toCompareWith = obj as MailboxEntity;
            return toCompareWith == null ? false : ((this.MailBoxId == toCompareWith.MailBoxId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.MailBoxId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}