#region Header

/*************************************************************************************************************************
* Description : This file represents a standard DocumentInfo entity.
*
*-------------------------------------------------------------------------------------------------------------------------
*	                                    File History
*-------------------------------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-------------------------------------------------------------------------------------------------------------------------
*   14/09/2010   		      Swaroop                   Created
*   16/02/2011                Rajeev                    Modified - Added IComparable interface for Sorting the ListItems.
*************************************************************************************************************************/
// <summary>
// File: DocumentInfoEntity.cs
// Description: Represents a standard DocumentInfo entity.
// </summary>
// <copyright file= "DocumentInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for DocumentInfo.
    /// </summary>
    [Serializable]
    public class DocumentInfoEntity : AbstractSubCaseInfo, IDocumentEntity, IComparable<DocumentInfoEntity>
    {

        public DocumentInfoEntity()
        {

        }

        public DocumentInfoEntity
            (
                string _DOCID,
                string _DOCCode,
                string _DocType,
                decimal? _DocSerialNo,
                decimal? _DocYear,
                string _DocTitle,
                string _ParentDocId,
                decimal? _Version,
            string _FilingType,
                string _DocNatureCode,
                DateTime? _FilingDateTime,
                DateTime? _ActualFilingDateTime,
                DateTime? _InTrayDateTime,
             string _ProcessedBy,
              DateTime _ProcessedTime,
                string _ForumID,
                string _SubmissionGroupID,
               string _DocStatusCode,
                decimal? _NumberOfPages,
                string _ExpungeInd,
                string _DocSecurityCode,
                string _BackdateApprInd,
                DateTime? _BackDateTime,
                string _JOUserIdApprBackDate,
                string _BackDateReasonFrLawFirm,
                string _BackDateReasonFrCourt,
                DateTime? _HearingDateTime,
                string _SpecHandlingReqInd,
                string _SpecHandlingReqRsn,
                string _SpecHandlingReqRem,
                string _WaiverInd,
                string _CurrencyCode,
                decimal? _LFWaiverReqFee,
                string _LFWaiverReqReason,
                string _WaiverApproveInd,
                string _WaiverApproveUserId,
                decimal? _WaiverApprFee,
                string _WaiverApprReason,
                string _Remarks,
                string _LFID,
                string _EndorsementType,
                string _DraftFileName,
                string _DraftLocation,
                string _DraftProcessType,
                string _DraftFormName,
                DateTime? _DraftDateTime,
                string _SentFileName,
                string _SentLocation,
                string _SentProcessType,
                string _SentFormName,
                DateTime? _SentDateTime,
                string _RecFileName,
                string _RecLocation,
                string _RecProcessType,
                string _RecFormName,
                DateTime? _RecDateTime,
                string _ObsInd,
                string _LastModifiedBy,
                DateTime _LastModifiedDate,
                string _IsValidated,
                string _ProcessType,
                string _FiledBy,
            //string _EServiceInd,
                long? _HRGID,
                string _IsUrgent,
                string _RelatedDocID,
                string _FECopy,
                string _OCRInd,
                string _DraftFNID,
                string _SentFNID,
                string _RecFNID,
                string _IsReplyProcessed,
                string _DisplayName,
                int? _NoOfAttachments,
                string _HideInd,
                long? _DraftFileSize,
                long? _SentFileSize,
                long? _RecFileSize,
                string _RequestDocID,
                string _FileType,
                string _DocSystemInd,
                string _WorkflowSerialNo,
                string _SubmSignature,
                long? _CaseInfoId,
                long? _SubCaseInfoId,
                string _AutoTestingMode,
            string _OCRPdfFNId,
            string _privateAnnoPdfFNId,
                string _OCRStatus,
                string _DIYHrgTypeCode,
                string _DIYHrgslotcode,
                string _JOLInd,
                string _DocInitiated,
                string _EFormContentRetain,
                string _ReqDecision,
                string _ReqDecisionRemark,
                string _HrgDateToBeFixedInd,
                string _IsCrossCourt
            )
        {
            DocId = _DOCID;
            if (!string.IsNullOrEmpty(_DOCCode.Trim()))
            {
                MDocCode = new MDocCodeEntity { DOCCode = _DOCCode };
            }

            DocType = _DocType;
            DocSerialNo = _DocSerialNo;
            DocYear = _DocYear;
            DocTitle = _DocTitle;
            ParentDocId = _ParentDocId;
            Version = _Version;

            if (!string.IsNullOrEmpty(_FilingType.Trim()))
            {
                FilingType = (DocumentFilingType)Enum.Parse(typeof(DocumentFilingType), _FilingType, true);
            }
            if (!string.IsNullOrEmpty(_DocNatureCode.Trim()))
            {
                MDocNature = new MDocNatureEntity { DocNatureCode = _DocNatureCode };
            }

            FilingDateTime = _FilingDateTime;
            ActualFilingDateTime = _ActualFilingDateTime;
            InTrayDateTime = _InTrayDateTime;
            ProcessedBy = _ProcessedBy;
            ProcessedTime = _ProcessedTime;
            if (!string.IsNullOrEmpty(_ForumID.Trim()))
            {
                MForumType = new MForumTypeEntity { ForumId = _ForumID };
            }

            SubmissionGroupId = _SubmissionGroupID;


            if (!string.IsNullOrEmpty(_DocStatusCode.Trim()))
            {
                MDocStatus = new MDocStatusEntity { DocStatus = _DocStatusCode };
            }

            NumberOfPages = _NumberOfPages;

            if (!string.IsNullOrEmpty(_ExpungeInd.Trim()))
            {
                ExpungeInd = (YesNo)Enum.Parse(typeof(YesNo), _ExpungeInd, true);
            }
            if (!string.IsNullOrEmpty(_DocSecurityCode.Trim()))
            {
                MDocSecurity = new MDocSecurityEntity { DocSecurityCode = _DocSecurityCode };
            }
            if (!string.IsNullOrEmpty(_BackdateApprInd.Trim()))
            {
                BackdateApprInd = (BackdateStatus)Enum.Parse(typeof(BackdateStatus), _BackdateApprInd, true);
            }
            BackDateTime = _BackDateTime;
            JOUserIdApprBackDate = _JOUserIdApprBackDate;
            BackDateReasonFrLawFirm = _BackDateReasonFrLawFirm;
            BackDateReasonFrCourt = _BackDateReasonFrCourt;
            HearingDateTime = _HearingDateTime;
            if (!string.IsNullOrEmpty(_SpecHandlingReqInd.Trim()))
            {
                SpecHandlingReqInd = (YesNo)Enum.Parse(typeof(YesNo), _SpecHandlingReqInd, true);
            }
            SpecHandlingReqRsn = _SpecHandlingReqRsn;
            SpecHandlingReqRem = _SpecHandlingReqRem;

            if (!string.IsNullOrEmpty(_WaiverInd.Trim()))
            {
                WaiverInd = (WaiverType)Enum.Parse(typeof(WaiverType), _WaiverInd, true);
            }

            if (!string.IsNullOrEmpty(_CurrencyCode.Trim()))
            {
                MCurrency = new MCurrencyEntity { CurrencyCode = _CurrencyCode };
            }

            LFWaiverReqFee = _LFWaiverReqFee;
            LFWaiverReqReason = _LFWaiverReqReason;

            if (!string.IsNullOrEmpty(_WaiverApproveInd.Trim()))
            {
                WaiverApproveInd = (WaiverStatus)Enum.Parse(typeof(WaiverStatus), _WaiverApproveInd, true);
            }

            WaiverApproveUserId = _WaiverApproveUserId;
            WaiverApprFee = _WaiverApprFee;
            WaiverApprReason = _WaiverApprReason;
            Remarks = _Remarks;
            LFID = _LFID;

            if (!string.IsNullOrEmpty(_EndorsementType.Trim()))
            {
                EndorsementType = (EndorsementType)Enum.Parse(typeof(EndorsementType), _EndorsementType, true);
            }
            DraftFileName = _DraftFileName;
            DraftLocation = _DraftLocation;
            DraftFormName = _DraftFormName;
            DraftDateTime = _DraftDateTime;
            SentFileName = _SentFileName;
            SentLocation = _SentLocation;
            SentFormName = _SentFormName;
            SentDateTime = _SentDateTime;
            RecFileName = _RecFileName;
            RecLocation = _RecLocation;
            RecFormName = _RecFormName;
            RecDateTime = _RecDateTime;

            if (!string.IsNullOrEmpty(_ObsInd.Trim()))
            {
                ObsInd = (YesNo)Enum.Parse(typeof(YesNo), _ObsInd, true);
            }

            LastModifiedBy = _LastModifiedBy;
            LastModifiedDate = _LastModifiedDate;


            if (!string.IsNullOrEmpty(_IsValidated.Trim()))
            {
                IsValidated = (YesNo)Enum.Parse(typeof(YesNo), _IsValidated, true);
            }

            if (!string.IsNullOrEmpty(_ProcessType.Trim()))
            {
                ProcessType = (DocumentProcessType)Enum.Parse(typeof(DocumentProcessType), _ProcessType, true);
            }

            FiledBy = _FiledBy;
            HRGID = _HRGID;

            if (!string.IsNullOrEmpty(_IsUrgent.Trim()))
            {
                IsUrgent = (YesNo)Enum.Parse(typeof(YesNo), _IsUrgent, true);
            }

            RelatedDocId = _RelatedDocID;

            FECopy = _FECopy;

            if (!string.IsNullOrEmpty(_OCRInd.Trim()))
            {
                OCRInd = (YesNo)Enum.Parse(typeof(YesNo), _OCRInd, true);
            }
            DraftFNID = _DraftFNID;
            SentFNID = _SentFNID;
            RecFNID = _RecFNID;
            if (!string.IsNullOrEmpty(_IsReplyProcessed.Trim()))
            {
                IsReplyProcessed = (YesNo)Enum.Parse(typeof(YesNo), _IsReplyProcessed, true);
            }
            DisplayName = _DisplayName;
            NoOfAttachments = _NoOfAttachments;

            if (!string.IsNullOrEmpty(_HideInd.Trim()))
            {
                HideInd = (YesNo)Enum.Parse(typeof(YesNo), _HideInd, true);
            }
            DraftFileSize = _DraftFileSize;
            SentFileSize = _SentFileSize;
            RecFileSize = _RecFileSize;

            RequestDocId = _RequestDocID;
            if (!string.IsNullOrEmpty(_FileType.Trim()))
            {
                FileType = (DocumentFileType)Enum.Parse(typeof(DocumentFileType), _FileType, true);
            }

            if (!string.IsNullOrEmpty(_DocSystemInd.Trim()))
            {
                DocSystemInd = (SystemInd)Enum.Parse(typeof(SystemInd), _DocSystemInd, true);
            }
            WorkflowSerialNo = _WorkflowSerialNo;

            SubmissionSignature = _SubmSignature;

            CaseInfoId = Convert.ToString(_CaseInfoId);
            SubCaseInfoId = Convert.ToString(_SubCaseInfoId);

            if (!string.IsNullOrEmpty(_AutoTestingMode.Trim()))
            {
                AutoTestingMode = (AutoTestingMode)Enum.Parse(typeof(AutoTestingMode), _AutoTestingMode, true);
            }

            DIYHrgTypeCode = _DIYHrgTypeCode;
            DIYHrgSlotCode = _DIYHrgslotcode;

            if (!string.IsNullOrEmpty(_JOLInd.Trim()))
            {
                JOLInd = (YesNo)Enum.Parse(typeof(YesNo), _JOLInd, true);
            }

            if (!string.IsNullOrEmpty(_DocInitiated.Trim()))
            {
                DocInitiated = (DocInitiatedLocation)Enum.Parse(typeof(DocInitiatedLocation), _DocInitiated, true);
            }


            if (!string.IsNullOrEmpty(_ReqDecision.Trim()))
            {
                ReqDecision = (ReqDecision)Enum.Parse(typeof(ReqDecision), _ReqDecision, true);
            }

            ReqDecisionRemark = _ReqDecisionRemark;

            if (!string.IsNullOrEmpty(_HrgDateToBeFixedInd.Trim()))
            {
                HrgDateToBeFixedInd = (YesNoMandatory)Enum.Parse(typeof(YesNoMandatory), _HrgDateToBeFixedInd, true);
            }

            if (!string.IsNullOrEmpty(_IsCrossCourt.Trim()))
            {
                IsCrossCourt = (YesNoMandatory)Enum.Parse(typeof(YesNoMandatory), _IsCrossCourt, true);
            }



        }
        #region Properties

        /// <summary>
        /// Gets or sets the ActualFilingDateTime field.
        /// </summary>
        /// <value>The actual filing date time.</value>
        public DateTime? ActualFilingDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the auto testing mode.
        /// </summary>
        /// <value>The auto testing mode.</value>
        public AutoTestingMode AutoTestingMode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BackdateApprInd field.
        /// </summary>
        /// <value>The backdate approved ind.</value>
        public BackdateStatus BackdateApprInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BackDateReasonFrCourt field.
        /// </summary>
        /// <value>The back date reason fr court.</value>
        public String BackDateReasonFrCourt
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BackDateReasonFrLawFirm field.
        /// </summary>
        /// <value>The back date reason fr law firm.</value>
        public String BackDateReasonFrLawFirm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BackDateTime field.
        /// </summary>
        /// <value>The back date time.</value>
        public DateTime? BackDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DisplayName field.
        /// </summary>
        /// <value>The display name.</value>
        public String DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets Or Sets the DIYHrgSlotcode
        /// </summary>
        public String DIYHrgSlotCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets Or Sets the DIYHrgTypeCode
        /// </summary>
        public String DIYHrgTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocId field.
        /// </summary>
        /// <value>The DocId.</value>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DocInitiated field. </summary>
        public DocInitiatedLocation DocInitiated
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocSerialNo field.
        /// </summary>
        /// <value>The doc serial no.</value>
        public Decimal? DocSerialNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocSystemInd field.
        /// </summary>
        /// <value>The doc system ind.</value>
        public SystemInd DocSystemInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocTitle field.
        /// </summary>
        /// <value>The doc title.</value>
        public String DocTitle
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
        /// Gets or sets the DocYear field.
        /// </summary>
        /// <value>The doc year.</value>
        public Decimal? DocYear
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DraftDateTime field.
        /// </summary>
        /// <value>The draft date time.</value>
        public DateTime? DraftDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DraftFileName field.
        /// </summary>
        /// <value>The name of the draft file.</value>
        public String DraftFileName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the size of the draft file.
        /// </summary>
        /// <value>The size of the draft file.</value>
        public Int64? DraftFileSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the draft Filenet Id.
        /// </summary>
        /// <value>The draft Filenet Id.</value>
        public String DraftFNID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DraftFormName field.
        /// </summary>
        /// <value>The name of the draft form.</value>
        public String DraftFormName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DraftLocation field.
        /// </summary>
        /// <value>The draft location.</value>
        public String DraftLocation
        {
            get;
            set;
        }

        ///// <summary>
        ///// Gets or sets the DraftProcessType field.
        ///// </summary>
        ///// <value>The type of the draft process.</value>
        //public String DraftProcessType
        //{
        //    get;
        //    set;
        //}
        /// <summary>
        /// Gets or sets the EndorsementType field.
        /// </summary>
        /// <value>The type of the endorsement.</value>
        public EndorsementType EndorsementType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the EServiceInd field.
        /// </summary>
        /// <value>The E service ind.</value>
        public YesNo EServiceInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ExpungeInd field.
        /// </summary>
        /// <value>The expunge ind.</value>
        public YesNo ExpungeInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FE copy.
        /// </summary>
        /// <value>The FE copy.</value>
        public String FECopy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FiledBy field.
        /// </summary>
        /// <value>The filed by.</value>
        public String FiledBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FileType field.
        /// </summary>
        /// TODO: Change FileType from varchar(20) to char(1).
        /// <value>The type of the file.</value>
        public DocumentFileType FileType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FilingDateTime field.
        /// </summary>
        /// <value>The filing date time.</value>
        public DateTime? FilingDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the filing.
        /// </summary>
        /// <value>The type of the filing.</value>
        public DocumentFilingType FilingType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HearingDateTime field.
        /// </summary>
        /// <value>The hearing date time.</value>
        public DateTime? HearingDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HideInd field.
        /// </summary>
        /// <value>The hide ind.</value>
        public YesNo HideInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGID field.
        /// </summary>
        /// <value>The HRGID.</value>
        public Int64? HRGID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the InTrayDateTime field.
        /// </summary>
        /// <value>The in tray date time.</value>
        public DateTime? InTrayDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsReplyProcessed field.
        /// </summary>
        /// <value>The is reply processed.</value>
        public YesNo IsReplyProcessed
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsUrgent field.
        /// </summary>
        /// <value>The is urgent.</value>
        public YesNo IsUrgent
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsValidated field.
        /// </summary>
        /// <value>The is validated.</value>
        public YesNo IsValidated
        {
            get;
            set;
        }

        public YesNo JOLInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the JO user back date time.
        /// </summary>
        /// <value>The JO user back date time.</value>
        public DateTime? JOUserBackDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the JOUserIdApprBackDate field.
        /// </summary>
        /// <value>The JO user id appr back date.</value>
        public String JOUserIdApprBackDate
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
        /// Gets or sets the LFWaiverReqFee field.
        /// </summary>
        /// <value>The LF waiver req fee.</value>
        public Decimal? LFWaiverReqFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFWaiverReqReason field.
        /// </summary>
        /// <value>The LF waiver req reason.</value>
        public String LFWaiverReqReason
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MailBoxId field.
        /// </summary>
        /// <value>The mail box Id.</value>
        public Int64? MailBoxId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Document.DocumentInfo.MCurrency - Master.MCurrency.DocumentInfos (m:1)'
        /// </summary>
        /// <value>The M currency.</value>
        public MCurrencyEntity MCurrency
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MDocCode field.
        /// </summary>
        /// <value>The MDocCode.</value>
        public MDocCodeEntity MDocCode
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Document.DocumentInfo.MDocNature - Master.MDocNature.DocumentInfos (m:1)'
        /// </summary>
        /// <value>The M doc nature.</value>
        public MDocNatureEntity MDocNature
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Document.DocumentInfo.MDocSecurity - Master.MDocSecurity.DocumentInfos (m:1)'
        /// </summary>
        /// <value>The M doc security.</value>
        public MDocSecurityEntity MDocSecurity
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Document.DocumentInfo.MDocStatus - Master.MDocStatus.DocumentInfos (m:1)'
        /// </summary>
        /// <value>The M doc status.</value>
        public MDocStatusEntity MDocStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Document.DocumentInfo.MForumType - Master.MForumType.DocumentInfos (m:1)'
        /// </summary>
        /// <value>The type of the M forum.</value>
        public MForumTypeEntity MForumType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NoOfAttachments field.
        /// </summary>
        /// <value>The no of attachments.</value>
        public Int32? NoOfAttachments
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NumberOfPages field.
        /// </summary>
        /// <value>The number of pages.</value>
        public Decimal? NumberOfPages
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
        /// Gets or sets the OCRInd field.
        /// </summary>
        /// <value>The OCR ind.</value>
        public YesNo OCRInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OCRPdfFNID.
        /// </summary>
        /// <value>The OCRPdfFNID.</value>
        public String OCRPdfFNID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OCRStatus field.
        /// </summary>
        /// <value>The OCRStatus.</value>
        public OCRStatus OCRStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ParentDocId field.
        /// </summary>
        /// <value>The parent doc id.</value>
        public String ParentDocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PrivateAnnoPdfFNID
        /// </summary>
        /// <value>The PrivateAnnoPdfFNID</value>
        public String PrivateAnnoPdfFNID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ProcessedBy field.
        /// </summary>
        /// <value>The processed by.</value>
        public String ProcessedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ProcessedTime field.
        /// </summary>
        /// <value>The processed time.</value>
        public DateTime? ProcessedTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ProcessType field.
        /// </summary>
        /// <value>The type of the process.</value>
        public DocumentProcessType ProcessType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RecDateTime field.
        /// </summary>
        /// <value>The rec date time.</value>
        public DateTime? RecDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RecFileName field.
        /// </summary>
        /// <value>The name of the rec file.</value>
        public String RecFileName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the size of the rec file.
        /// </summary>
        /// <value>The size of the rec file.</value>
        public Int64? RecFileSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the rec filenet Id.
        /// </summary>
        /// <value>The rec filenet Id.</value>
        public String RecFNID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RecFormName field.
        /// </summary>
        /// <value>The name of the rec form.</value>
        public String RecFormName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RecLocation field.
        /// </summary>
        /// <value>The rec location.</value>
        public String RecLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RelatedDocId field.
        /// </summary>
        /// <value>The related doc Id.</value>
        public String RelatedDocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Remarks field.
        /// </summary>
        /// <value>The remarks.</value>
        public String Remarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RequestDocId field.
        /// </summary>
        /// <value>The request doc Id.</value>
        public String RequestDocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SentDateTime field.
        /// </summary>
        /// <value>The sent date time.</value>
        public DateTime? SentDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SentFileName field.
        /// </summary>
        /// <value>The name of the sent file.</value>
        public String SentFileName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the size of the sent file.
        /// </summary>
        /// <value>The size of the sent file.</value>
        public Int64? SentFileSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the sent filenet Id.
        /// </summary>
        /// <value>The sent filenet Id.</value>
        public String SentFNID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SentFormName field.
        /// </summary>
        /// <value>The name of the sent form.</value>
        public String SentFormName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SentLocation field.
        /// </summary>
        /// <value>The sent location.</value>
        public String SentLocation
        {
            get;
            set;
        }

        ///// <summary>
        ///// Gets or sets the SentProcessType field.
        ///// </summary>
        ///// <value>The type of the sent process.</value>
        //public String SentProcessType
        //{
        //    get;
        //    set;
        //}
        /// <summary>
        /// Gets or sets the SpecHandlingReqInd field.
        /// </summary>
        /// <value>The spec handling req ind.</value>
        public YesNo SpecHandlingReqInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SpecHandlingReqRem field.
        /// </summary>
        /// <value>The spec handling req rem.</value>
        public String SpecHandlingReqRem
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SpecHandlingReqRsn field.
        /// </summary>
        /// <value>The spec handling req RSN.</value>
        public String SpecHandlingReqRsn
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group Id.</value>
        public String SubmissionGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmSignature field.
        /// </summary>
        /// <value>The submission signature.</value>
        public String SubmissionSignature
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Version field.
        /// </summary>
        /// <value>The version.</value>
        public Decimal? Version
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WaiverApprFee field.
        /// </summary>
        /// <value>The waiver approved fee.</value>
        public Decimal? WaiverApprFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WaiverApproveInd field.
        /// </summary>
        /// <value>The waiver approve ind.</value>
        public WaiverStatus WaiverApproveInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WaiverApproveUserId field.
        /// </summary>
        /// <value>The waiver approve user id.</value>
        public String WaiverApproveUserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WaiverApprReason field.
        /// </summary>
        /// <value>The waiver appr reason.</value>
        public String WaiverApprReason
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WaiverInd field.
        /// </summary>
        /// <value>The waiver ind.</value>
        public WaiverType WaiverInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the workflow serial no.
        /// </summary>
        /// <value>The workflow serial no.</value>
        public String WorkflowSerialNo
        {
            get;
            set;
        }

        public YesNoMandatory HrgDateToBeFixedInd
        {
            get;
            set;
        }

        public YesNoMandatory IsCrossCourt
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the req decision.
        /// </summary>
        /// <value>The req decision.</value>
        public ReqDecision ReqDecision
        {
            get;
            set;
        }

        public string ReqDecisionRemark
        {
            get;
            set;
        }

        public YesNo IsDocArchived
        {
            get;
            set;
        }

        public RejectionFeeType RejectionFeeActionType
        {
            get;
            set;
        }

        public IsConfidential IsConfidential { get; set; }

        public YesNoMandatory EformContentRetain { get; set; }

        public string HashCode { get; set; }

        public string FiledByLoginId { get; set; }

        public string Step4TermAndConditionVersion { get; set; }

        public string DocNo { get; set; }

        public YesNo DIYSelectbyUser { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// The method accepts an object as a parameter and returns an integer.
        /// Added by Rajeev KK.
        /// </summary>
        /// <param name="toCompareDocInfoEntity">DocumentInfoEntity object as a parameter for compare.</param>
        /// <returns>
        /// A return value of zero means that the two objects we are comparing are equal to each other.
        /// A negative return value means that the first object comes before the second object.
        /// A positive return value means that the first object comes after the second object.
        /// </returns>
        public int CompareTo(DocumentInfoEntity toCompareDocInfoEntity)
        {
            if (toCompareDocInfoEntity == null)
                return 0;

            if (this.DocTitle != null)
            {
                int result = this.DocTitle.CompareTo(toCompareDocInfoEntity.DocTitle);
                if (result == 0)
                    result = this.DocTitle.CompareTo(toCompareDocInfoEntity.DocTitle);
                return result;
            }
            else
                return 0;
        }

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            DocumentInfoEntity toCompareWith = obj as DocumentInfoEntity;
            return toCompareWith == null ? false : ((this.DocId == toCompareWith.DocId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}