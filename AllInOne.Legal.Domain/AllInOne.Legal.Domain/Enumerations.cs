#region Header

/*****************************************************************************************************
* Description : This file represents a list of generic enumerations, referenced in Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   18/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: Enumerations.cs
// Description: Representing a list of generic enumerations, referenced in Domain objects.
// </summary>
// <copyright file= "Enumerations.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain
{
    using System;
    using System.ComponentModel;

    #region Enumerations

    /// <summary>
    /// List of Visit Status Options.
    /// </summary>
    [Serializable]
    public enum VisitStatus
    {
        /// <summary>
        /// Success.
        /// </summary>
        S,

        /// <summary>
        /// Error.
        /// </summary>
        E,

        /// <summary>
        /// Violation.
        /// </summary>
        V
    }

    /// <summary>
    /// List of "PrintJobType" Types.
    /// </summary>
    [Serializable]
    public enum PrintStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "New Record – applicable only for conversion"
        /// </summary>
        NR,

        /// <summary>
        /// Represents "Ready to Print".
        /// </summary>
        RP,

        /// <summary>
        /// Represents "Sent to print".
        /// </summary>
        SR,

        /// <summary>
        /// Represents "Error  during printing".
        /// </summary>
        ER,

        /// <summary>
        /// Represents "Error during conversion".
        /// </summary>
        EC,

        /// <summary>
        /// Represents "Ready to Process".
        /// 
        P,

        /// <summary>
        /// Represents "Document Downloaded and Converted".
        /// 
        D,


        /// <summary>
        /// Represents "Completed with out Error".
        /// 
        C

    }

    /// <summary>
    /// List of "AASPCPaidStatus" Types.
    /// </summary>
    [Serializable]
    public enum AASPCPaidStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Paid".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Not Paid".
        /// </summary>
        N
    }

    /// <summary>
    /// List of "AASPCVoteStatus" Types.
    /// </summary>
    [Serializable]
    public enum AASPCVoteStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Voted".
        /// </summary>
        VT,

        /// <summary>
        /// Represents " Not Voted".
        /// </summary>
        NV,

        /// <summary>
        /// Represents "No Need To Vote".
        /// </summary>
        NN,

        /// <summary>
        /// Represents "Penalty Paid".
        /// </summary>
        PP
    }

    /// <summary>
    /// List of address format type.
    /// </summary>
    [Serializable]
    public enum AddLess
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Add "
        /// </summary>
        A,

        /// <summary>
        /// Represents "Less"
        /// </summary>
        L
    }

    /// <summary>
    /// List of address availability types.
    /// </summary>
    [Serializable]
    public enum AddressAvailabilityType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Not Known" address availability type.
        /// </summary>
        NK,

        /// <summary>
        /// Represents "Details as follows" address availability type.
        /// </summary>
        DF
    }

    /// <summary>
    /// List of address format type.
    /// </summary>
    [Serializable]
    public enum AddressFormatType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Old " address format type.
        /// </summary>
        O,

        /// <summary>
        /// Represents "Local" address format type.
        /// </summary>
        L,

        /// <summary>
        /// Represents "Foreign" address format type.
        /// </summary>
        F,

        /// <summary>
        /// Represents "Not Applicable"
        /// </summary>
        S //added to avoid failure at QA Sinc eFiling inserting this--Requested by Haj on Aug 30/2012


    }

    /// <summary>
    /// List of address types.
    /// </summary>
    [Serializable]
    public enum AddressType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Registered" address type.
        /// </summary>
        REG,

        /// <summary>
        /// Represents "Residential" address type.
        /// </summary>
        RES,

        /// <summary>
        /// Represents "Service" address type.
        /// </summary>
        SER
    }

    /// <summary>
    /// List of Admiralty Type.
    /// </summary>
    [Serializable]
    public enum AdmiralityType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Auction/Sale
        /// </summary>
        S,

        /// <summary>
        /// Execution
        /// </summary>
        E,

        /// <summary>
        /// Release
        /// </summary>
        R
    }

    /// <summary>
    /// List for Admiralty Writ Types.
    /// </summary>
    [Serializable]
    public enum AdmiraltyWritType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Rem" value.
        /// </summary>
        R,

        /// <summary>
        /// Represents "Personam".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Both".
        /// </summary>
        B
    }

    /// <summary>
    /// List of AdmLetterUsed status
    /// </summary>
    [Serializable]
    public enum AdmLetterUsed
    {
        /// <summary>
        /// NULL.
        /// </summary>
        Null,
        /// <summary>
        /// Commission
        /// </summary>
        C,
        /// <summary>
        /// Refund
        /// </summary>
        R
    }

    /// <summary>
    /// List of affidavit AEIC types.
    /// </summary>
    [Serializable]
    public enum AffidavitAEICType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Expert Evidence this is applicable only for AEIC - affidavit".
        /// </summary>
        E,

        /// <summary>
        /// Represents "Evidence of Fact".
        /// </summary>
        F
    }

    /// <summary>
    /// List of AgreeOrNotAgree status
    /// </summary>
    [Serializable]
    public enum AgreeOrNotAgree
    {
        /// <summary>
        /// NULL.
        /// </summary>
        Null,
        /// <summary>
        /// Agree
        /// </summary>
        A,
        /// <summary>
        /// Not Agree
        /// </summary>
        NA
    }

    /// <summary>
    /// List of AmendmentInSupport.
    /// </summary>
    [Serializable]
    public enum AmendmentInSupport
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Supporting Document".
        /// </summary>
        SD,

        /// <summary>
        /// Represents "Leave of Court".
        /// </summary>
        LC
    }

    /// <summary>
    /// List of AmendmentInSupport.
    /// </summary>
    [Serializable]
    public enum AmendmentPerformedAt
    {
        /// <summary>
        /// Represents "Front End".
        /// </summary>
        FE,

        /// <summary>
        /// Represents "Back End".
        /// </summary>
        BE
    }

    /// <summary>
    /// List of AmendmentInSupport.
    /// </summary>
    [Serializable]
    public enum AmendmentStatus
    {
        /// <summary>
        /// Represents "Pending" value.
        /// </summary>
        P,

        /// <summary>
        /// Represents "Rejected".
        /// </summary>
        R,

        /// <summary>
        /// Represents "Approval".
        /// </summary>
        A
    }

    /// <summary>
    /// List of AppealsAgainst types.
    /// </summary>
    [Serializable]
    public enum AppealsAgainst
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "The Whole Appeal".
        /// </summary>
        W,

        /// <summary>
        /// Represents "Part of the decision".
        /// </summary>
        P
    }

    /// <summary>
    /// List of ApplicantType
    /// </summary>
    [Serializable]
    public enum ApplicantType
    {
        /// <summary>
        /// Represents "NULL" Value
        /// </summary>
        Null,
        /// <summary>
        ///Court appointed guardian(s) of the infant
        /// </summary>
        CAG,
        /// <summary>
        /// Next of kin nominated by the infant(s) to apply for letters of administration
        /// </summary>
        NOK,
        /// <summary>
        /// Person(s) assigned as guardian(s) by Registrar
        /// </summary>
        PAG,
        /// <summary>
        /// Others
        /// </summary>
        OTH,
        /// <summary>
        /// Others "EFiling Following this
        /// </summary>
        O
    }

    /// <summary>
    /// List of ApplicationLimitation
    /// </summary>
    [Serializable]
    public enum ApplicationLimitation
    {
        /// <summary>
        /// Represents "NULL" Value
        /// </summary>
        Null,
        /// <summary>
        ///None
        /// </summary>
        N,
        /// <summary>
        /// Admitting copy of the will
        /// </summary>
        AD,
        /// <summary>
        /// Limited to specific property
        /// </summary>
        SP,
        /// <summary>
        /// Limited until the infants attain the age of 21 years and obtain Grant of Letters of Administration to themselves
        /// </summary>
        IA,
        /// <summary>
        /// Limited until the Donor obtains Grant of Letter s of Administration for himself/herself
        /// </summary>
        DG,
        /// <summary>
        /// Limited until the beneficiary becomes of sound mind and obtains a grant to himself/herself
        /// </summary>
        BG,
        /// <summary>
        /// Others
        /// </summary>
        O,
        /// <summary>
        /// Limited until the infant beneficiary attains the age of 21 years and obtains Grant of Letters of Administration to himself/herself
        /// </summary>
        IAS,
        /// <summary>
        /// Limited until the Donor obtains Grant of Letters of Administration for himself/herself
        /// </summary>
        DGS,
        /// <summary>
        /// Limited until the Donor obtains Probate for himself/herself
        /// </summary>
        DPS,
        /// <summary>
        /// Limited until the beneficiaries become of sound mind and obtain Grant of Letters of Administration to themselves
        /// </summary>
        BGS,
        /// <summary>
        /// Limited until the Donors obtain Probate for themselves
        /// </summary>
        DP
    }

    /// <summary>
    /// List of Work Item AppointmentOutcomeCode
    /// </summary>
    [Serializable]
    public enum AppointmentApptReason
    {
        /// <summary>
        /// NULL.
        /// </summary>
        Null,
        /// <summary>
        /// Others*
        /// </summary>
        AHAATTOTH,
        /// <summary>
        /// As per court order
        /// </summary>
        AHAATTPCO,
        /// <summary>
        /// Absent
        /// </summary>
        AHAUNAABS,
        /// <summary>
        /// Called off
        /// </summary>
        AHAUNACAL,
        /// <summary>
        /// Docs not in order
        /// </summary>
        AHAUNADNO,
        /// <summary>
        /// Others*
        /// </summary>
        AHAUNAOTH,
        /// <summary>
        /// Postponed
        /// </summary>
        AHAUNAPOS,
        /// <summary>
        /// Withdrawn
        /// </summary>
        AHAUNAWIT,
        /// <summary>
        /// None
        /// </summary>
        ARRASCNON,
        /// <summary>
        /// Others*
        /// </summary>
        ARRASCOTH,
        /// <summary>
        /// None
        /// </summary>
        ARRASPNON,
        /// <summary>
        /// Others*.
        /// </summary>
        ARRASPOTH,
        /// <summary>
        /// Application Set Aside.
        /// </summary>
        ARRSUSASA,
        /// <summary>
        /// Installment Payment.
        /// </summary>
        ARRSUSINS,
        /// <summary>
        /// Others*.
        /// </summary>
        ARRSUSOTH,
        /// <summary>
        /// Stay of Execution.
        /// </summary>
        ARRSUSSOE,
        /// <summary>
        /// Absent.
        /// </summary>
        ARRUNAABS,
        /// <summary>
        /// Called off.
        /// </summary>
        ARRUNACAL,
        /// <summary>
        /// Docs not in order
        /// </summary>
        ARRUNADNO,
        /// <summary>
        /// Others*.
        /// </summary>
        ARRUNAOTH,
        /// <summary>
        /// Postponed.
        /// </summary>
        ARRUNAPOS,
        /// <summary>
        /// Withdrawn.
        /// </summary>
        ARRUNAWIT,
        /// <summary>
        ///Defendant not at Place of Execution.
        /// </summary>
        ARRUNSDEF,
        /// <summary>
        /// Door locked.
        /// </summary>
        ARRUNSDLK,
        /// <summary>
        /// Occupants refused entry.
        /// </summary>
        ARRUNSORE,
        /// <summary>
        /// Others*.
        /// </summary>
        ARRUNSOTH,
        /// <summary>
        /// Unable to overcome hurdles.
        /// </summary>
        ARRUNSUOH,
        /// <summary>
        /// None.
        /// </summary>
        COMCOMNON,
        /// <summary>
        /// Others*.
        /// </summary>
        COMCOMOTH,
        /// <summary>
        /// Application Set Aside.
        /// </summary>
        COMSUSASA,
        /// <summary>
        /// Installment Payment.
        /// </summary>
        COMSUSINS,
        /// <summary>
        /// Others*.
        /// </summary>
        COMSUSOTH,
        /// <summary>
        /// Stay of Execution.
        /// </summary>
        COMSUSSOE,
        /// <summary>
        /// Absent.
        /// </summary>
        COMUNAABS,
        /// <summary>
        /// Called off.
        /// </summary>
        COMUNACAL,
        /// <summary>
        /// Docs not in order.
        /// </summary>
        COMUNADNO,
        /// <summary>
        /// Others*.
        /// </summary>
        COMUNAOTH,
        /// <summary>
        /// Postponed.
        /// </summary>
        COMUNAPOS,
        /// <summary>
        /// Withdrawn.
        /// </summary>
        COMUNAWIT,
        /// <summary>
        /// Defendant not at Place of Execution.
        /// </summary>
        COMUNSDEF,
        /// <summary>
        /// Door Locked.
        /// </summary>
        COMUNSDLK,
        /// <summary>
        /// Occupants refused entry.
        /// </summary>
        COMUNSORE,
        /// <summary>
        /// Others*.
        /// </summary>
        COMUNSOTH,
        /// <summary>
        /// Unable to overcome hurdles.
        /// </summary>
        COMUNSUOH,
        /// <summary>
        /// None.
        /// </summary>
        DELDELNON,
        /// <summary>
        /// Others*.
        /// </summary>
        DELDELOTH,
        /// <summary>
        /// Application Set Aside.
        /// </summary>
        DELSUSASA,
        /// <summary>
        /// Installment Payment.
        /// </summary>
        DELSUSINS,
        /// <summary>
        /// Others*.
        /// </summary>
        DELSUSOTH,
        /// <summary>
        /// Stay of Execution.
        /// </summary>
        DELSUSSOE,
        /// <summary>
        /// Absent.
        /// </summary>
        DELUNAABS,
        /// <summary>
        /// Called off.
        /// </summary>
        DELUNACAL,
        /// <summary>
        /// Docs not in order.
        /// </summary>
        DELUNADNO,
        /// <summary>
        /// Others*.
        /// </summary>
        DELUNAOTH,
        /// <summary>
        /// Postponed.
        /// </summary>
        DELUNAPOS,
        /// <summary>
        /// Withdrawn.
        /// </summary>
        DELUNAWIT,
        /// <summary>
        /// Dog in premises.
        /// </summary>
        DELUNSDIP,
        /// <summary>
        /// Door Locked.
        /// </summary>
        DELUNSDLK,
        /// <summary>
        /// Payment in Court.
        /// </summary>
        SALSETPIC,
        /// <summary>
        /// Payment in Court.
        /// </summary>
        SEISETPIC
    }

    /// <summary>
    /// List of Work Item RecTransType
    /// </summary>
    [Serializable]
    public enum AppointmentApptType
    {
        /// <summary>
        /// NULL.
        /// </summary>
        Null,
        /// <summary>
        /// Ad hoc Attendance
        /// </summary>
        AHA,
        /// <summary>
        /// Arrest
        /// </summary>
        ARR,
        /// <summary>
        /// Committal
        /// </summary>
        COM,
        /// <summary>
        /// Delivery
        /// </summary>
        DEL,
        /// <summary>
        /// Lotting
        /// </summary>
        LOT,
        /// <summary>
        /// Notice of Sale
        /// </summary>
        NOS,
        /// <summary>
        /// Possession
        /// </summary>
        POS,
        /// <summary>
        /// Sale
        /// </summary>
        SAL,
        /// <summary>
        /// Seizure
        /// </summary>
        SEI
    }

    /// <summary>
    /// List of "AASPCPaidStatus" Types.
    /// </summary>
    [Serializable]
    public enum AppointmentOrganisationType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "LAW CORPORATION".
        /// </summary>
        LC,

        /// <summary>
        /// Represents "LAWFIRM".
        /// </summary>
        LF
    }

    /// <summary>
    /// List of Work Item AppointmentOutcomeCode
    /// </summary>
    [Serializable]
    public enum AppointmentOutcomeCode
    {
        /// <summary>
        /// NULL.
        /// </summary>
        Null,
        /// <summary>
        /// Attended
        /// </summary>
        AHAATT,
        /// <summary>
        /// Unattended
        /// </summary>
        AHAUNA,
        /// <summary>
        /// Arrested - sent to Court
        /// </summary>
        ARRASC,
        /// <summary>
        /// Arrested - sent to Prison
        /// </summary>
        ARRASP,
        /// <summary>
        /// Suspended
        /// </summary>
        ARRSUS,
        /// <summary>
        /// Unattended
        /// </summary>
        ARRUNA,
        /// <summary>
        /// Unsuccessful
        /// </summary>
        ARRUNS,
        /// <summary>
        /// Committed
        /// </summary>
        COMCOM,
        /// <summary>
        /// Suspended
        /// </summary>
        COMSUS,
        /// <summary>
        /// Unattended
        /// </summary>
        COMUNA,
        /// <summary>
        /// Unsuccessful
        /// </summary>
        COMUNS,
        /// <summary>
        /// Delivered.
        /// </summary>
        DELDEL,
        /// <summary>
        /// Suspended.
        /// </summary>
        DELSUS,
        /// <summary>
        /// Unattended.
        /// </summary>
        DELUNA,
        /// <summary>
        /// Unsuccessful.
        /// </summary>
        DELUNS,
        /// <summary>
        /// Successful.
        /// </summary>
        LOTSUC,
        /// <summary>
        /// Unsuccessful.
        /// </summary>
        LOTUNS,
        /// <summary>
        /// Served.
        /// </summary>
        NOSSER,
        /// <summary>
        /// Unable to Serve.
        /// </summary>
        NOSUTS,
        /// <summary>
        /// Suspended.
        /// </summary>
        POSSUS,
        /// <summary>
        /// Unattended.
        /// </summary>
        POSUNA,
        /// <summary>
        /// Unsuccessful.
        /// </summary>
        POSUNS,
        /// <summary>
        /// Vacant Possession Delivered.
        /// </summary>
        POSVPD,
        /// <summary>
        /// Released.
        /// </summary>
        SALREL,
        /// <summary>
        /// Settled.
        /// </summary>
        SALSET,
        /// <summary>
        /// Sold.
        /// </summary>
        SALSOL,
        /// <summary>
        /// Suspended.
        /// </summary>
        SALSUS,
        /// <summary>
        /// Unattended.
        /// </summary>
        SALUNA,
        /// <summary>
        /// Unsuccessful.
        /// </summary>
        SALUNS,
        /// <summary>
        /// Seized.
        /// </summary>
        SEISEI,
        /// <summary>
        /// Settled.
        /// </summary>
        SEISET,
        /// <summary>
        /// Suspended.
        /// </summary>
        SEISUS,
        /// <summary>
        /// Unattended.
        /// </summary>
        SEIUNA,
        /// <summary>
        /// Unsuccessful.
        /// </summary>
        SEIUNS
    }

    /// <summary>
    /// List of AttachmentType
    /// </summary>
    [Serializable]
    public enum AttachmentType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Statement of Claim
        /// </summary>
        S,

        /// <summary>
        /// Generally Endorsement Writ’
        /// </summary>
        E,
    }

    /// <summary>
    /// List of SubpoenaPurpose.
    /// </summary>
    [Serializable]
    public enum AttendanceMode
    {
        /// <summary>
        /// Represens "Null" Value
        /// </summary>
        Null,

        /// <summary>
        /// Represents "In Person" Value
        /// </summary>
        P,

        /// <summary>
        /// Represents "By Agent" Value
        /// </summary>
        A
    }

    [Serializable]
    public enum AuditTrailBackEndFuctions
    {
        /// <summary>
        /// Generic add.
        /// </summary>
        Add,
        /// <summary>
        /// add code tables
        /// </summary>
        AddCodeTables,
        /// <summary>
        ///  Add config items
        /// </summary>
        AddConfigItems,
        /// <summary>
        ///  add config tables
        /// </summary>
        AddConfigTables,
        /// <summary>
        /// add functionality
        /// </summary>
        AddFunctionality,
        /// <summary>
        /// add new fees
        /// </summary>
        AddNewFees,
        /// <summary>
        /// add roles
        /// </summary>
        AddRoles,
        /// <summary>
        /// add sections
        /// </summary>
        AddSections,
        /// <summary>
        /// approve
        /// </summary>
        Approve,
        /// <summary>
        /// cedit case status
        /// </summary>
        CeditCaseStatus,
        /// <summary>
        /// Create a service out tracking
        /// </summary>
        CreateAServiceOutTracking,
        /// <summary>
        /// create non electronic case
        /// </summary>
        CreateNonElectronicCase,
        /// <summary>
        /// create smart object
        /// </summary>
        CreateSmartObject,
        /// <summary>
        /// delete config items
        /// </summary>
        DeleteConfigItems,
        /// <summary>
        /// delete code tables
        /// </summary>
        DeleteCodeTables,
        /// <summary>
        /// delete
        /// </summary>
        Delete,
        /// <summary>
        /// delete fees
        /// </summary>
        DeleteFees,
        /// <summary>
        /// delete smart object
        /// </summary>
        DeleteSmartObject,
        /// <summary>
        /// delete task
        /// </summary>
        DeleteTask,
        /// <summary>
        /// delete users
        /// </summary>
        DeleteUsers,
        /// <summary>
        /// documents
        /// </summary>
        Documents,
        /// <summary>
        /// download reports
        /// </summary>
        DownloadReports,
        /// <summary>
        /// Edit
        /// </summary>
        Edit,
        /// <summary>
        /// Edit case name
        /// </summary>
        EditCaseName,
        /// <summary>
        /// edit config tables
        /// </summary>
        EditConfigTables,
        /// <summary>
        /// Edit CYPA
        /// </summary>
        EditCYPA,
        /// <summary>
        /// Edit Diary
        /// </summary>
        EditDiary,
        /// <summary>
        /// Edit Hearing
        /// </summary>
        EditHearing,
        /// <summary>
        /// Edit High Profile Case
        /// </summary>
        EditHighProfileCase,
        /// <summary>
        /// edit party status
        /// </summary>
        EditPartyStatus,
        /// <summary>
        /// edit users
        /// </summary>
        EditUsers,
        /// <summary>
        /// edit WF
        /// </summary>
        EditWF,
        /// <summary>
        /// Fee Rule Maintenance
        /// </summary>
        FeeRuleMaintenance,
        /// <summary>
        /// Finance Tab
        /// </summary>
        FinanceTab,
        /// <summary>
        /// Fix Hearing
        /// </summary>
        FixHearing,
        /// <summary>
        /// generate document
        /// </summary>
        GenerateDocument,
        /// <summary>
        /// generate minute sheet
        /// </summary>
        GenerateMinuteSheet,
        /// <summary>
        /// generate report
        /// </summary>
        GenerateReport,
        /// <summary>
        /// generate reports
        /// </summary>
        GenerateReports,
        /// <summary>
        /// Index documents
        /// </summary>
        IndexDocuments,
        /// <summary>
        /// Inspect Case
        /// </summary>
        InspectCase,
        /// <summary>
        /// Lock Registrar Diary
        /// </summary>
        LockRegistrarDiary,
        /// <summary>
        /// Login
        /// </summary>
        Login,
        /// <summary>
        /// maintain account
        /// </summary>
        MaintainAccount,
        /// <summary>
        /// Map Fee Rule to Documents
        /// </summary>
        MapFeeRuleToDocuments,
        /// <summary>
        /// modify fees
        /// </summary>
        ModifyFees,
        /// <summary>
        /// modify fixture hearing
        /// </summary>
        ModifyFixtureHearing,
        /// <summary>
        /// Modify hearing list
        /// </summary>
        ModifyHearingList,
        /// <summary>
        /// open documents
        /// </summary>
        OpenDocuments,
        /// <summary>
        /// Pack n Go
        /// </summary>
        PackNGo,
        /// <summary>
        /// Print Hearing list
        /// </summary>
        PrintHearingList,
        /// <summary>
        /// re route
        /// </summary>
        ReRoute,
        /// <summary>
        /// Reject
        /// </summary>
        Reject,
        /// <summary>
        /// remove roles
        /// </summary>
        RemoveRoles,
        /// <summary>
        /// retrieve document
        /// </summary>
        RetrieveDocument,
        /// <summary>
        /// route to
        /// </summary>
        RouteTo,
        /// <summary>
        /// save code tables
        /// </summary>
        SaveCodeTables,
        /// <summary>
        /// save config items
        /// </summary>
        SaveConfigItems,
        /// <summary>
        /// save config tables
        /// </summary>
        SaveConfigTables,
        /// <summary>
        /// Save Diary
        /// </summary>
        SaveDiary,
        /// <summary>
        /// save fees
        /// </summary>
        SaveFees,
        /// <summary>
        /// Save Hearing
        /// </summary>
        SaveHearing,
        /// <summary>
        /// Save minute sheet
        /// </summary>
        SaveMinuteSheet,
        /// <summary>
        /// save WF
        /// </summary>
        SaveWF,
        /// <summary>
        /// save
        /// </summary>
        Save,
        /// <summary>
        /// schedule hearing
        /// </summary>
        ScheduleHearing,
        /// <summary>
        /// seek direction
        /// </summary>
        SeekDirection,
        /// <summary>
        /// stop hearing
        /// </summary>
        StopHearing,
        /// <summary>
        /// Undo accept
        /// </summary>
        UndoAccept,
        /// <summary>
        /// View 
        /// </summary>
        View,
        /// <summary>
        /// View Court room
        /// </summary>
        ViewCourtRoom,
        /// <summary>
        /// View Diary
        /// </summary>
        ViewDiary,
        /// <summary>
        /// view Hearing list
        /// </summary>
        ViewHearingList,
        /// <summary>
        /// view Hearing Queue
        /// </summary>
        ViewHearingQueue,
        /// <summary>
        /// view minute sheet
        /// </summary>
        ViewMinuteSheet,
        /// <summary>
        /// view reports
        /// </summary>
        ViewReports,
        /// <summary>
        /// View users
        /// </summary>
        ViewUsers,
        /// <summary>
        /// Weekly Sales Report
        /// </summary>        
        WeeklySalesReport,
        /// <summary>
        /// Edit Case Parties
        /// </summary>
        EditCaseParties,
        PrintBarcodeSticker,
        PrintBarCodeRollerSticker,
        PrintMinuteSheet,
        AdvancedSearchHearing,
        CreatePersonalSchedule,
        CreateHearingSchedule,
        EditPersonalSchedule,
        LockDiary,
        UnLockDiary,
        MoveHearing,
        ApproveCAHearings,
        ManageFixture,
        /// <summary>
        /// Add Appointment
        /// </summary>
        AddAppointment,
        /// <summary>
        /// Update Appointment
        /// </summary>
        UpdateAppointment,
        /// <summary>
        /// Update Appointment from UnAssigned Tray
        /// </summary>
        UpdateAppointment_tray,
        /// <summary>
        /// Fix Appointment
        /// </summary>
        FixAppointment,
        /// <summary>
        /// Delete Appointment
        /// </summary>
        DeleteAppointment,
        /// <summary>
        /// Drag And Drop Appointment
        /// </summary>
        DragNDropAppointment,
        /// <summary>
        /// Print
        /// </summary>
        Print,
        /// <summary>
        /// Payment Voucher Print
        /// </summary>
        PaymentVoucherPrint,
        /// <summary>
        /// Update
        /// </summary>
        Update,
        /// <summary>
        /// Create
        /// </summary>
        Create,
        /// <summary>
        /// Add Case Assignment
        /// </summary>
        AddCaseAssignment,
        /// <summary>
        /// Edit Case Assignment
        /// </summary>
        EditCaseAssignment,
        /// <summary>
        /// Delete Case Assignment
        /// </summary>
        DeleteCaseAssignment,
        /// <summary>
        /// Delete Document
        /// </summary>
        DeleteDocument,
        /// <summary>
        /// Delete Hearing
        /// </summary>
        DeleteHearing,
        /// <summary>
        /// Update Document Access For Users
        /// </summary>
        EditDocumentAccessForUsers,
        /// <summary>
        /// Edit Case Officer
        /// </summary>
        EditCaseOfficer,
        /// <summary>
        /// Edit Total Value of Liquidated Claim
        /// </summary>
        EditTotalValueofLiquidatedClaim,
        /// <summary>
        /// Edit Total Estimated Value of Unliquidated Claim
        /// </summary>
        EditTotalEstimatedValueofUnliquidatedClaim,
        /// <summary>
        /// Edit Case Tier
        /// </summary>
        EditCaseTier,
        /// <summary>
        /// Redact Party
        /// </summary>
        RedactParty,
        /// <summary>
        /// Redact CaseName
        /// </summary>
        RedactCaseName,
        UpdateHearingOutcomeOnly,
        UpdateHearingOutcome,
        CaseConvesion,
        UndoCaseConversion,
        CaseTransfer,
        UndoTransfer,
        MyCasesAndCaseassignment,
        FeeCollection,
        EditNatureOfCase,
        EditActofParliamentAndSubsidiaryLegislation
    }

    [Serializable]
    public enum AuditTrailBackEndModule
    {
        /// <summary>
        /// Administration
        /// </summary>
        Administration,
        /// <summary>
        /// Content Management
        /// </summary>
        ContentManagement,
        /// <summary>
        /// DocumentReports
        /// </summary>
        DocumentReports,
        /// <summary>
        /// FinanceMgmt
        /// </summary>
        FinanceMgmt,
        /// <summary>
        /// Hearing Management
        /// </summary>
        HearingManagement,
        /// <summary>
        /// Home
        /// </summary>
        Home,
        /// <summary>
        /// WorkFlow
        /// </summary>
        WorkFlow,
        /// <summary>
        /// Enforcement module
        /// </summary>
        Enforcement,
        /// <summary>
        /// OutGoingCorrespondence module
        /// </summary>
        OutGoingCorrespondence,
        /// <summary>
        /// SOPIPO module
        /// </summary>
        SOPIPO,
        /// <summary>
        /// AAS module
        /// </summary>
        AAS,
        /// <summary>
        /// BE CaseFile module
        /// </summary>
        BECaseFile,

        /// <summary>
        /// Reports Module
        /// </summary>
        Reports,
        /// <summary>
        /// Reports Module
        /// </summary>
        FeeCollection
    }

    [Serializable]
    public enum AuditTrailBackEndSubModule
    {
        /// <summary>
        /// Account Management
        /// </summary>
        AccountManagement,
        /// <summary>
        /// Approval UI
        /// </summary>
        ApprovalUI,
        /// <summary>
        /// BE - Case File
        /// </summary>
        BECaseFile,
        /// <summary>
        /// BE - Finance Reports
        /// </summary>
        BEFinanceReports,
        /// <summary>
        /// Code Maintenance
        /// </summary>
        CodeMaintenance,
        /// <summary>
        /// Court Room View
        /// </summary>
        CourtRoomView,
        /// <summary>
        /// Dashboard/Reports
        /// </summary>
        DashboardReports,
        /// <summary>
        /// DB logs
        /// </summary>
        DBlogs,
        /// <summary>
        /// e-Hearing
        /// </summary>
        eHearing,
        /// <summary>
        /// Fee Rule Maintenance
        /// </summary>
        FeeRuleMaintenance,
        /// <summary>
        /// File Inspection
        /// </summary>
        FileInspection,
        /// <summary>
        /// Finance Configuration
        /// </summary>
        FinanceConfiguration,
        /// <summary>
        /// Generate Document
        /// </summary>
        GenerateDocument,
        /// <summary>
        /// Hearing List
        /// </summary>
        HearingList,
        /// <summary>
        /// Indexing
        /// </summary>
        Indexing,
        /// <summary>
        /// Judge’s Diary
        /// </summary>
        JudgesDiary,
        /// <summary>
        /// Manage Fixture
        /// </summary>
        ManageFixture,
        /// <summary>
        /// Non-Electronic Case Creation
        /// </summary>
        NonElectronicCaseCreation,
        /// <summary>
        /// Notification Configuration
        /// </summary>
        NotificationConfiguration,
        /// <summary>
        /// Online Enquiry
        /// </summary>
        OnlineEnquiry,
        /// <summary>
        /// Registrar’s Diary
        /// </summary>
        RegistrarsDiary,
        /// <summary>
        /// Resource Management
        /// </summary>
        ResourceManagement,
        /// <summary>
        /// Schedule Hearing
        /// </summary>
        ScheduleHearing,
        /// <summary>
        /// Search
        /// </summary>
        Search,
        /// <summary>
        /// Service Out Tracking
        /// </summary>
        ServiceOutTracking,
        /// <summary>
        /// System Logs
        /// </summary>
        SystemLogs,
        /// <summary>
        /// Task item
        /// </summary>
        Taskitem,
        /// <summary>
        /// User Profile
        /// </summary>
        UserProfile,
        /// <summary>
        /// VSA Configuration
        /// </summary>
        VSAConfiguration,
        /// <summary>
        /// Workflow
        /// </summary>
        Workflow,
        /// <summary>
        /// CivilProceedings
        /// </summary>
        CivilProceedings,
        /// <summary>
        /// CriminalProceedings
        /// </summary>
        CriminalProceedings,
        /// <summary>
        /// Admiralty
        /// </summary>
        Admiralty,
        /// <summary>
        /// Enquiries
        /// </summary>
        Enquiries,
        /// <summary>
        /// Accounting
        /// </summary>
        Accounting,
        /// <summary>
        /// BailiffActivity
        /// </summary>
        BailiffActivity,
        /// <summary>
        /// BailiffDiary
        /// </summary>
        BailiffDiary,
        /// <summary>
        /// Finance
        /// </summary>
        Finance,
        /// <summary>
        /// OGCScheduler job
        /// </summary>
        OGCScheduler,
        /// <summary>
        /// UploadGD
        /// </summary>
        UploadGD,
        /// <summary>
        /// CourtRoom
        /// </summary>
        CourtRoom,
        /// <summary>
        /// CivilRegistry
        /// </summary>
        CivilRegistry,
        /// <summary>
        /// CivilPDRC
        /// </summary>
        CivilPDRC,
        /// <summary>
        /// CivilTrial
        /// </summary>
        CivilTrial,
        /// <summary>
        /// CivilCourtRoom
        /// </summary>
        CivilCourtRoom,
        /// <summary>
        /// FamilyRegistry
        /// </summary>
        FamilyRegistry,
        /// <summary>
        /// FamilyTrial
        /// </summary>
        FamilyTrial,
        /// <summary>
        /// FamilyFRC
        /// </summary>
        FamilyFRC,
        /// <summary>
        /// FamilyCAPS
        /// </summary>
        FamilyCAPS,
        /// <summary>
        /// FamilyCourtRoom
        /// </summary>
        FamilyCourtRoom,
        /// <summary>
        /// HeadNotes
        /// </summary>
        HeadNotes,
        /// <summary>
        /// OnlineMinuteSheet
        /// </summary>
        OnlineMinuteSheet,
        /// <summary>
        /// PrintAASDocuments
        /// </summary>
        PrintAASDocuments,
        /// <summary>
        /// SendRegistrarNotice
        /// </summary>
        SendRegistrarNotice,
        /// <summary>
        /// UploadMinutesheet
        /// </summary>
        UploadMinutesheet,
        /// <summary>
        /// UnclaimedAmount
        /// </summary>
        UnclaimedAmount,
        /// <summary>
        /// BECaseParty
        /// </summary>
        BECaseParty,
        /// <summary>
        /// CaseIndicators
        /// </summary>
        CaseIndicators,
        /// <summary>
        /// CaseName
        /// </summary>
        CaseName,
        /// <summary>
        /// CaseOfficer
        /// </summary>
        CaseOfficer,
        /// <summary>
        /// CaseAssignment
        /// </summary>
        CaseAssignment,
        /// <summary>
        /// EnquiryPlusConfiguration(for Online Enquiry Plus Configuration)
        /// </summary>
        EnquiryPlusConfiguration,
        /// <summary>
        /// BailiffCalendar
        /// </summary>
        BailiffCalendar,
        /// <summary>
        /// PacknGo
        /// </summary>
        PacknGo,
        /// <summary>
        /// CaseTier
        /// </summary>
        CaseTier,
        /// <summary>
        /// Hearing
        /// </summary>
        Hearing,
        /// <summary>
        /// MinuteSheetCronJob
        /// </summary>
        MinuteSheetCronJob,
        /// <summary>
        /// FeeCollection
        /// </summary>
        FeeCollection
    }

    [Serializable]
    public enum AuditTrailFrontEndFuctions
    {
        /// <summary>
        /// Add User
        /// </summary>
        AddUser,

        /// <summary>
        /// Acting In Capacity
        /// </summary>
        ActingInCapacity,

        /// <summary>
        /// Add Party from other records
        /// </summary>
        AddPartyFromOtherRecords,

        /// <summary>
        /// Add Party Manually
        /// </summary>
        AddPartyManually,

        /// <summary>
        /// Administrator Details
        /// </summary>
        AdministratorDetails,

        /// <summary>
        /// Amend Document
        /// </summary>
        AmendDocument,

        /// <summary>
        /// Case Info
        /// </summary>
        CaseInfo,
        /// <summary>
        /// Case Relationship - View case details
        /// </summary>
        CaseRelationshipViewCaseDetails,
        /// <summary>
        /// Certificate of Service
        /// </summary>
        CertificateofService,

        /// <summary>
        /// Checklist
        /// </summary>
        Checklist,
        /// <summary>
        /// Client - Collaboration View
        /// </summary>
        ClientCollaborationView,

        /// <summary>
        /// Clients/ Counsel
        /// </summary>
        ClientsCounsel,

        /// <summary>
        /// Collaborate
        /// </summary>
        Collaborate,

        /// <summary>
        /// Collaboration Tab
        /// </summary>
        CollaborationTab,

        /// <summary>
        /// Confirmation of Pre-Registration
        /// </summary>
        ConfirmationOfPreRegistration,
        /// <summary>
        /// Contact Person Details
        /// </summary>
        ContactPersonDetails,

        /// <summary>
        /// Decision Maker Details
        /// </summary>
        DecisionMakerDetails,

        /// <summary>
        /// Deferred File and Serve
        /// </summary>
        DeferredFileAndServe,
        /// <summary>
        /// Delete Party
        /// </summary>
        DeleteParty,

        /// <summary>
        /// De-Register Law Practice
        /// </summary>
        DeRegisterLawPractice,

        /// <summary>
        /// De-Register User
        /// </summary>
        DeRegisterUser,

        /// <summary>
        /// Document Selection
        /// </summary>
        DocumentSelection,

        /// <summary>
        /// Edit Party
        /// </summary>
        EditParty,

        /// <summary>
        /// Edit User
        /// </summary>
        EditUser,

        /// <summary>
        /// eService
        /// </summary>
        EService,

        /// <summary>
        /// eService from Document Tab of FE Case File
        /// </summary>
        EServiceFromDocumentTabOfFECaseFile,

        /// <summary>
        /// Fees Report
        /// </summary>
        FeesReport,

        /// <summary>
        /// File and Exchange
        /// </summary>
        FileAndExchange,

        /// <summary>
        /// Finance Report
        /// </summary>
        FinanceReport,

        /// <summary>
        /// Immediate File and Serve
        /// </summary>
        ImmediateFileAndServe,

        /// <summary>
        /// Law Firm reference No
        /// </summary>
        LawFirmReferenceNo,

        /// <summary>
        /// Law Practice Address
        /// </summary>
        LawPracticeAddress,

        /// <summary>
        /// Login
        /// </summary>
        Login,

        /// <summary>
        /// Manage Case Access
        /// </summary>
        ManageCaseAccess,

        /// <summary>
        /// Manage Law Practice
        /// </summary>
        ManageLawPractice,

        /// <summary>
        /// Manage Team List
        /// </summary>
        ManageTeamList,

        /// <summary>
        /// Manage Team Assignment
        /// </summary>
        ManageTeamAssignment,

        /// <summary>
        /// Manage User
        /// </summary>
        ManageUser,

        /// <summary>
        /// Manage User Access
        /// </summary>
        ManageUserAccess,

        /// <summary>
        /// Normal File and Serve
        /// </summary>
        NormalFileAndServe,

        /// <summary>
        /// Order of Court
        /// </summary>
        OrderOfCourt,

        /// <summary>
        /// Originating Case Info
        /// </summary>
        OriginatingCaseInfo,

        /// <summary>
        /// Pack & Go
        /// </summary>
        PackAndGo,

        /// <summary>
        /// Party Details
        /// </summary>
        PartyDetails,

        /// <summary>
        /// Party Details (Amendment Basket 1 & 2)
        /// </summary>
        PartyDetailsAmendmentBasket1And2,

        /// <summary>
        /// Pre- Registration
        /// </summary>
        PreRegistration,

        /// <summary>
        /// Received Replies Report
        /// </summary>
        ReceivedRepliesReport,

        /// <summary>
        /// Reconciliation Report
        /// </summary>
        ReconciliationReport,

        /// <summary>
        /// Re-Register Law Practice
        /// </summary>
        ReRegisterLawPractice,

        /// <summary>
        /// Register New User
        /// </summary>
        RegisterNewUser,

        /// <summary>
        /// Re-Register user
        /// </summary>
        ReRegisterUser,

        /// <summary>
        /// Search & View Case File
        /// </summary>
        SearchAndViewCaseFile,

        /// <summary>
        /// Share Name
        /// </summary>
        ShareName,

        /// <summary>
        /// Singpass authentication
        /// </summary>
        SingpassAuthentication,

        /// <summary>
        /// Select Affidavit
        /// </summary>
        SelectAffidavit,

        /// <summary>
        /// Step 2: eForm Compose
        /// </summary>
        Step2EformCompose,

        /// <summary>
        /// Step 2: eForm Delete
        /// </summary>
        Step2EformDelete,

        /// <summary>
        /// Step 3- Hearing Details
        /// </summary>
        Step3HearingDetails,

        /// <summary>
        /// Step 2: eForm Upload
        /// </summary>
        Step2EformUpload,

        /// <summary>
        /// Step 3- Backdate Request
        /// </summary>
        Step3BackdateRequest,

        /// <summary>
        /// Step 3-  Urgent Request
        /// </summary>
        Step3UrgentRequest,

        /// <summary>
        /// Step 3 - Waiver request
        /// </summary>
        Step3Waiverrequest,

        /// <summary>
        /// Step 3 - eService Details
        /// </summary>
        Step3EServiceDetails,

        /// <summary>
        /// Step 3- Fee Details
        /// </summary>
        Step3FeeDetails,

        /// <summary>
        /// Step 4: Submit eFiling
        /// </summary>
        Step4SubmitFiling,

        /// <summary>
        /// Step 2: Form
        /// </summary>
        Step2Form,

        /// <summary>
        /// Step 3: Admin Details
        /// </summary>
        Step3AdminDetails,

        /// <summary>
        /// Submission Sent Report
        /// </summary>
        SubmissionSentReport,

        /// <summary>
        /// SuspensionTermination Report
        /// </summary>
        SuspensionTermination,

        /// <summary>
        /// Tax Invoice
        /// </summary>
        TaxInvoice,

        /// <summary>
        /// Verification of Pre-Registration
        /// </summary>
        VerificationOfPreRegistration,

        /// <summary>
        /// View fee details
        /// </summary>
        ViewFeeDetails,

        /// <summary>
        /// Step2 Next
        /// </summary>
        Step2Next,


        /// <summary>
        /// step 2 Cancel
        /// </summary>
        step2Cancel,

        /// <summary>
        /// step2SaveSupportingDocs
        /// </summary>
        step2SaveSupportingDocs,

        /// <summary>
        /// step2SaveSupportingDoc
        /// </summary>
        step2SaveSupportingDoc,

        /// <summary>
        /// step2SetDownBundle
        /// </summary>
        step2SetDownBundle,

        /// <summary>
        /// step2OSFMCASupDocs
        /// </summary>        
        step2OSFMCASupDocs,

        /// <summary>
        /// step2redirectingstep3
        /// </summary>        
        step2redirectingstep3,

        /// <summary>
        /// step2Previousbutton
        /// </summary>        
        step2Previousbutton,

        /// <summary>
        /// step3Hearingdetails
        /// </summary>        
        step3Hearingdetails,

        /// <summary>
        /// step3FeesPayable
        /// </summary>        
        step3FeesPayable,

        /// <summary>
        /// step3ExternalAgencyFeeDetails
        /// </summary>        
        step3ExternalAgencyFeeDetails,

        /// <summary>
        /// step3BackDateRequest
        /// </summary>        
        step3BackDateRequest,


        /// <summary>
        /// Step3EServicesdetails
        /// </summary>        
        Step3EServicesdetails,

        /// <summary>
        /// FECalendarView
        /// </summary>
        FECalendarDetails,

        /// <summary>
        /// CBS - Step 2
        /// </summary>
        CBS_Step2,

        /// <summary>
        /// CBS - Step 3A
        /// </summary>
        CBS_Step3A,

        /// <summary>
        /// CBS - Step 3B
        /// </summary>
        CBS_Step3B,

        /// <summary>
        /// CBS - Step 3C
        /// </summary>
        CBS_Step3C,

        /// <summary>
        /// Step 3 Next
        /// </summary>
        Step3Next,
        /// <summary>
        /// PCApplication
        /// </summary>
        PCApplication,
        /// <summary>
        /// PCNOCApplication
        /// </summary>
        PCNOCApplication,

        /// <summary>
        /// SICC - Step 1
        /// </summary>
        SICC_Step1,

        /// <summary>
        /// SICC - Step 2
        /// </summary>
        SICC_Step2,

        /// <summary>
        /// SICC - Step 3
        /// </summary>
        SICC_Step3,
        
        /// <summary>
        /// SICC - Registration
        /// </summary>
        SICC_Registration
    }

    [Serializable]
    public enum AuditTrailFrontEndModule
    {
        /// <summary>
        /// Case Information Repository
        /// </summary>
        CaseInformationRepository,
        /// <summary>
        /// EFiling
        /// </summary>
        EFiling,
        /// <summary>
        /// EService
        /// </summary>
        EService,
        /// <summary>
        /// Finance Management
        /// </summary>
        FinanceManagement,
        /// <summary>
        /// Home
        /// </summary>
        Home,
        /// <summary>
        /// Law Practice Registration
        /// </summary>
        LawPracticeRegistration,
        /// <summary>
        /// Security and Account Management
        /// </summary>
        SecurityAndAccountManagement,

        /// <summary>
        /// FECalendar
        /// </summary>
        FECalendar,

        /// <summary>
        /// Cause Book Search
        /// </summary>
        CauseBookSearch,

        /// <summary>
        /// Verify Application
        /// </summary>
        VerifyApplication,

        /// <summary>
        /// SICC
        /// </summary>
        SICC,
    }

    [Serializable]
    public enum AuditTrailFrontEndSubModule
    {
        /// <summary>
        /// Authentication
        /// </summary>
        Authentication,

        /// <summary>
        /// Authorisation & Access Control Management
        /// </summary>
        AuthorisationAndAccessControlManagement,

        /// <summary>
        /// Case File - Summary Tab
        /// </summary>
        CaseFileSummaryTab,

        /// <summary>
        /// Case File - Document Tab
        /// </summary>
        CaseFileDocumentTab,

        /// <summary>
        /// Case File - Bill Details Tab
        /// </summary>
        CaseFileBillDetailsTab,

        /// <summary>
        /// Certificate of Service
        /// </summary>
        CertificateOfService,

        /// <summary>
        /// Commence a New Case
        /// </summary>
        CommenceANewCase,

        /// <summary>
        /// Collaboration
        /// </summary>
        Collaboration,

        /// <summary>
        /// eService
        /// </summary>
        EService,

        /// <summary>
        /// File a Document
        /// </summary>
        FileADocument,

        /// <summary>
        /// File an Affidavit
        /// </summary>
        FileAnAffidavit,

        /// <summary>
        /// File and Serve
        /// </summary>
        FileAndServe,

        /// <summary>
        /// FEFinanceReports
        /// </summary>
        FinanceReports,

        /// <summary>
        /// FE- Reports
        /// </summary>
        FrontEndReports,

        /// <summary>
        /// Manage Law Practice via Customer Administrator
        /// </summary>
        ManageLawPracticeViaCustomerAdministrator,

        /// <summary>
        /// Manage Law Practice via Law Practice Administrator
        /// </summary>
        ManageLawPracticeViaLawPracticeAdministrator,

        /// <summary>
        /// Manage User via Customer Administrator
        /// </summary>
        ManageUserViaCustomerAdministrator,

        /// <summary>
        /// Manage User via Law Practice Administrator
        /// </summary>
        ManageUserViaLawPracticeAdministrator,

        /// <summary>
        /// Manage Team via Customer Administrator
        /// </summary>
        ManageTeamViaCustomerAdministrator,

        /// <summary>
        /// Manage Team via Law Practice Administrator
        /// </summary>
        ManageTeamViaLawPracticeAdministrator,

        /// <summary>
        /// Pack & Go
        /// </summary>
        PackAndGo,

        /// <summary>
        /// Re-filing of Rejected main document
        /// </summary>
        ReFilingOfRejectedMainDocument,

        /// <summary>
        /// Registration
        /// </summary>
        Registration,

        /// <summary>
        /// Search Case File
        /// </summary>
        SearchCaseFile,

        /// <summary>
        /// PC Application
        /// </summary>
        PCApplication,

        /// <summary>
        /// PC NOC Application
        /// </summary>
        PCNOCApplication,

        /// <summary>
        /// For Cause Book Search or other modules with no submodule
        /// </summary>
        None



    }

    [Serializable]
    public enum AuditTrialActionType
    {
        /// <summary>
        /// Add
        /// </summary>
        A,
        /// <summary>
        /// Update
        /// </summary>
        U,
        /// <summary>
        /// View
        /// </summary>
        V,
        /// <summary>
        /// Delete
        /// </summary>
        D,
        /// <summary>
        /// Print
        /// </summary>
        P
    }

    /// <summary>
    /// List of Yes and No.
    /// </summary>
    [Serializable]
    public enum AutionType
    {
        //BUG-ENFPROD-SC-2013100702
        /// <summary>
        /// Represents None.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Private Treaty".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Public Aution".
        /// </summary>
        A,

        /// <summary>
        /// Represents "Others".
        /// </summary>
        O
    }

    /// <summary>
    /// List of Auto Testing Modes.
    /// </summary>
    [Serializable]
    public enum AutoTestingMode
    {
        /// <summary>
        /// Represents "Normal" mode.
        /// </summary>
        N,

        /// <summary>
        /// Represents "WatiN" mode.
        /// </summary>
        W,

        /// <summary>
        /// Represents "QTP" mode.
        /// </summary>
        Q
    }

    /// <summary>
    /// List of Backdate status.
    /// </summary>
    [Serializable]
    public enum BackdateStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Not Applicable".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Pending".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Allowed".
        /// </summary>
        A,

        /// <summary>
        /// Represents "Refused".
        /// </summary>
        R,

        /// <summary>
        /// Represents "Others".
        /// </summary>
        O
    }

    public enum BailiffClaimStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        ///  Pending
        /// </summary>
        P,

        /// <summary>
        /// Rejected
        /// </summary>
        R,

        /// <summary>
        /// Vetted
        /// </summary>
        V,

        /// <summary>
        /// Approved
        /// </summary>
        A
    }

    /// <summary>
    /// List of BizMon status
    /// </summary>
    [Serializable]
    public enum BizMonStatus
    {
        /// <summary>
        /// Represents "Null"
        /// </summary>
        Null,
        /// <summary>
        /// Represents "Active"
        /// </summary>
        A,
        /// <summary>
        /// Represents "In Progress"
        /// </summary>
        I,
        /// <summary>
        /// Represents "Completed"
        /// </summary>
        C,
        /// <summary>
        /// Represents "Error"
        /// </summary>
        E,
        /// <summary>
        /// Represents "No Action taken"
        /// </summary>
        N
    }

    /// <summary>
    /// List of BTS Routing Queue statuses
    /// </summary>
    [Serializable]
    public enum BTSRoutingQueueStatus
    {
        /// <summary>
        /// Represents filing broker success.
        /// </summary>
        FILINGBROKER_SUCCESS,

        /// <summary>
        /// Represents filing broker failure.
        /// </summary>
        FILINGBROKER_FAILURE,

        /// <summary>
        /// Represents FB success for BizTalk to poll.
        /// </summary>
        FBSuccess,

        /// <summary>
        /// Represents marked for hold for BizTalk to poll.
        /// </summary>
        MARKED_FOR_HOLD,

        /// <summary>
        /// Represents marked for recovery for BizTalk to poll.
        /// </summary>
        MARKED_FOR_RECOVERY,

        /// <summary>
        /// Represents New for BizTalk to poll.
        /// </summary>
        N
    }

    /// <summary>
    /// List of Case Indicator types
    /// </summary>
    [Serializable]
    public enum CaseIndType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "No".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Yes".
        /// </summary>
        Y,

        /// <summary>
        /// Represents "Chinese".
        /// </summary>
        C,

        /// <summary>
        /// Represents "Malay".
        /// </summary>
        M,

        /// <summary>
        /// Represents "Tamil".
        /// </summary>
        T,

        /// <summary>
        /// Represents "Secured".
        /// </summary>
        S
    }

    /// <summary>
    /// List of case party represented by types.
    /// </summary>
    [Serializable]
    public enum CasePartyRepresentedBy
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "In Person or Self".
        /// </summary>
        S,

        /// <summary>
        /// Represents "Represented By Solicitor".
        /// </summary>
        R
    }

    /// <summary>
    /// List of Case Track.
    /// </summary>
    [Serializable]
    public enum CaseTrack
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Normal" (default).
        /// When a new case is created in IELS system.
        /// </summary>
        N,

        /// <summary>
        /// Represents "Fast".
        /// </summary>
        F,

        /// <summary>
        /// Represents "Complex".
        /// </summary>
        C
    }

    /// <summary>
    /// List of different CaseType.
    /// </summary>
    [Serializable]
    public enum CaseType
    {
        /// <summary>
        /// Default will be NONE
        /// </summary>
        NONE,

        /// <summary>
        /// Admission Of Advocates And Solicitors
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        AAS,

        /// <summary>
        /// Admiralty
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        ADM,

        /// <summary>
        /// Bankruptcy
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        B,

        /// <summary>
        /// Taxation
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        BC,

        /// <summary>
        /// Taxation
        /// <remarks>Applicable to DC, DCF and MC Forum</remarks>
        /// </summary>
        BCS,

        /// <summary>
        /// Bill of Sale
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        BS,

        /// <summary>
        /// Court Of Appeal
        /// <remarks>Applicable to CA Forum</remarks>
        /// </summary>
        CA,

        /// <summary>
        /// Family Counselling
        /// <remarks>Applicable to DCF Forum</remarks>
        /// </summary>
        CAPS,

        /// <summary>
        /// Caveat For Admiralty
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        CAVA,

        /// <summary>
        /// Caveat For Probate
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        CAVP,

        /// <summary>
        /// Criminal Case
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        CC,

        /// <summary>
        /// Criminal Case Appeal
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        CCA,

        /// <summary>
        /// Committal Hearing
        /// <remarks>TODO:</remarks>
        /// </summary>
        CH,

        /// <summary>
        /// Criminal Motion
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        CM,

        /// <summary>
        /// Criminal Revision
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        CR,

        /// <summary>
        /// Criminal Reference
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        CRF,

        /// <summary>
        /// Company Winding Up
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        CWU,

        /// <summary>
        /// Divorce
        /// <remarks>Applicable to DCF Forum</remarks>
        /// </summary>
        D,

        /// <summary>
        /// WOS (District Court)
        /// <remarks>Applicable to DC Forum</remarks>
        /// </summary>
        DC,

        /// <summary>
        /// District Court Appeal
        /// <remarks>Applicable to DC, DCF and MC Forum</remarks>
        /// </summary>
        DCA,

        /// <summary>
        /// Caveat for Probate (District Court)
        /// <remarks>Applicable to DC Forum</remarks>
        /// </summary>
        DCCVP,

        /// <summary>
        /// Probate
        /// <remarks>Applicable to DC Forum</remarks>
        /// </summary>
        DCP,

        /// <summary>
        /// Divorce (Transferred)
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        DT,

        /// <summary>
        /// Warrant to Levy
        /// <remarks>Applicable to - Forum</remarks>
        /// </summary>
        FCWL,

        /// <summary>
        /// Warrant of Attachment
        /// <remarks>Applicable to - Forum</remarks>
        /// </summary>
        FCWOA,

        /// <summary>
        /// Family Mediation/ Counseling
        /// <remarks>Applicable to DCF Forum</remarks>
        /// </summary>
        FRC,

        /// <summary>
        /// Transmission Proceeding
        /// <remarks>TODO:</remarks>
        /// </summary>
        HC,

        /// <summary>
        /// Magistrate Appeal (Criminal)
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        MA,

        /// <summary>
        /// WOS (Magistrate Court)
        /// <remarks>Applicable to MC Forum</remarks>
        /// </summary>
        MC,

        /// <summary>
        /// Enforcement of Commissioner of Labour Order(s)
        /// <remarks>Applicable to TRI Forum</remarks>
        /// </summary>
        MOM,

        /// <summary>
        /// Originating Summons
        /// <remarks>Applicable to HC and CA Forum</remarks>
        /// </summary>
        OS,

        /// <summary>
        /// Originating Summons (Adoption)
        /// <remarks>Applicable to DCF Forum</remarks>
        /// </summary>
        OSA,

        /// <summary>
        /// Originating Summons (Bankruptcy)
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        OSB,

        /// <summary>
        /// Originating Summons (Family)
        /// <remarks>Applicable to DCF Forum</remarks>
        /// </summary>
        OSF,

        /// <summary>
        /// Originating Summons
        /// <remarks>Applicable to DC and MC Forum</remarks>
        /// </summary>
        OSS,

        /// <summary>
        /// Probate
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        P,

        /// <summary>
        /// Power Of Attorney
        /// <remarks>Applicable to HC Forum</remarks>
        /// </summary>
        PA,


        /// <summary>
        /// Preliminary inquiry
        /// <remarks>Applicable to HC Forum</remarks>
        PI,

        /// <summary>
        /// Writ Of Summons
        /// <remarks>Applicable to HC Forum</remarks>
        S,

        /// <summary>
        /// Enforcement of Order of Tribunal
        /// <remarks>Applicable to TRI Forum</remarks>
        /// </summary>
        SCT,

        /// <summary>
        /// Tribunal Appeal
        /// <remarks>TODO:</remarks>
        /// </summary>
        TA,

        /// <summary>
        /// Warrant to Levy
        /// <remarks>Applicable to - Forum</remarks>
        /// </summary>
        WL,

        /// <summary>
        /// Warrant to Levy CPF Contributions
        /// <remarks>Applicable to - Forum</remarks>
        /// </summary>
        WLCPF,

        /// <summary>
        /// Warrant of Attachment
        /// <remarks>Applicable to - Forum</remarks>
        /// </summary>
        WOA,

        /// <summary>
        /// Warrant of Attachment
        /// <remarks>Applicable to - Forum</remarks>
        /// </summary>
        WOAS,

        /// <summary>
        /// Warrant to Levy
        /// <remarks>Applicable to - Forum</remarks>
        /// </summary>
        WTL,

        /// <summary>
        /// Registrar's Appeal
        /// <remarks>Applicable to HC (after case transfer), DC, MC, DCF forum</remarks>
        /// </summary>
        RAS,

        /// <summary>
        /// 
        /// <remarks></remarks>
        /// </summary>
        WTXS,

        /// <summary>
        /// 
        /// <remarks></remarks>
        /// </summary>
        WTXL,

        /// <summary>
        /// 
        /// <remarks></remarks>
        /// </summary>
        CPF,

        /// <summary>
        /// Originating Summons (Guardianship of Infant)
        /// <remarks>Applicable to FC Forum</remarks>
        /// </summary>
        OSG,

        /// <summary>
        /// Originating Summons (Mental Capacity Act)
        /// <remarks>Applicable to FC Forum</remarks>
        /// </summary>
        OSM,

        /// <summary>
        /// Originating Summons (Legitimacy Act)
        /// <remarks>Applicable to FC Forum</remarks>
        /// </summary>
        OSN,

        /// <summary>
        /// Magistrate's Appeal (Family Division)
        /// </summary>
        MAF,

        /// <summary>
        /// Youth Court Appeal
        /// </summary>
        YA,

        /// <summary>
        /// SICC Originating Summons
        /// </summary>
        SICCOS,

        /// <summary>
        /// Transfered of Originating Of Summons
        /// </summary>
        SICCOST,

        /// <summary>
        /// SICC Writ Of Summons
        /// </summary>
        SICCS,

        /// <summary>
        /// Transferred of Writ Of Summons
        /// </summary>
        SICCST,

        /// <summary>
        /// Registration of Foreign Lawyer
        /// </summary>
        RFL,

        /// <summary>
        /// Originating Summons (Probate and Administration)
        /// </summary>
        OSP,

        /// <summary>
        /// Pre Action Certificate
        /// </summary>
        PAC,

        /// <summary>
        /// Originating Summons (POHA)
        /// </summary>
        PHA,

        /// <summary>
        /// Appeal from District Judge in Chambers (Ord 55C, Protection from Harassment Act)
        /// </summary>
        CJTA,

        /// <summary>
        /// Appeal from District Judge (Ord 55D, Protection from Harassment Act)
        /// </summary>
        CJTB
    }

    /// <summary>
    /// List of different CaseType Group.
    /// </summary>
    [Serializable]
    public enum CaseTypeGroup
    {
        /// <summary>
        /// Default will be NONE
        /// </summary>
        NONE,

        /// <summary>
        /// Admission Of Advocates And Solicitors
        /// </summary>
        AAS,

        /// <summary>
        /// Writ of Admirality
        /// </summary>
        AD,

        /// <summary>
        /// Writ of Summons
        /// </summary>
        AW,

        /// <summary>
        /// Bankruptcy Application
        /// </summary>
        BA,

        /// <summary>
        /// Bill of Costs
        /// </summary>
        BC,

        /// <summary>
        /// Bill of Sale
        /// </summary>
        BS,

        /// <summary>
        /// Appeal
        /// </summary>
        CA,

        /// <summary>
        /// Criminal Case
        /// </summary>
        CC,

        /// <summary>
        /// Criminal Appeal
        /// </summary>
        CCA,

        /// <summary>
        /// Committal Hearing
        /// </summary>
        CH,

        /// <summary>
        /// Criminal Motion
        /// </summary>
        CM,

        /// <summary>
        /// Criminal Revision
        /// </summary>
        CR,

        /// <summary>
        /// Criminal Reference
        /// </summary>
        CRF,

        /// <summary>
        /// Caveat
        /// </summary>
        CV,

        /// <summary>
        /// Corporate Entity Winding Up Application
        /// </summary>
        CWU,

        /// <summary>
        /// District Court Appeal
        /// </summary>
        DCA,

        /// <summary>
        /// Family Counselling
        /// </summary>
        FC,

        /// <summary>
        /// Family Mediation/Joint Conference
        /// </summary>
        FRC,

        /// <summary>
        /// Transmission Proceeding
        /// </summary>
        HC,

        /// <summary>
        /// Magistrate's Appeal
        /// </summary>
        MA,

        /// <summary>
        /// Enforcement of Commissioner for Labour Order(s)
        /// </summary>
        MOM,

        /// <summary>
        /// Originating Summons
        /// </summary>
        OS,

        /// <summary>
        /// Adoption Application
        /// </summary>
        OSA,

        /// <summary>
        /// Originating Summons (Bankruptcy)
        /// </summary>
        OSB,

        /// <summary>
        /// Power of Attorney
        /// </summary>
        PA,

        /// <summary>
        /// Probate Application/Citation
        /// </summary>
        PB,

        /// <summary>
        /// Enforcement of Order of Tribunal
        /// </summary>
        SCT,

        /// <summary>
        /// Writ of Divorce
        /// </summary>
        WD
    }

    public enum CashBookItemType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Cash Book
        /// </summary>
        C,

        /// <summary>
        /// Bank Statement
        /// </summary>
        B
    }

    [Serializable]
    public enum CashBookReconcileStatus
    {
        /// <summary>
        /// Lock
        /// </summary>
        L,
        /// <summary>
        /// Un Lock
        /// </summary>
        U
    }

    /// <summary>
    /// List of ChargeStatusType.
    /// </summary>
    [Serializable]
    public enum ChargeStatusType
    {
        /// <summary>
        /// "NULL" Value - If Null, means there is no status yet.
        /// </summary>
        Null,
        /// <summary>
        /// Withdrawn
        /// </summary>
        WD,
        /// <summary>
        /// Convicted
        /// </summary>
        CV,
        /// <summary>
        /// Sentenced
        /// </summary>
        SN,
        /// <summary>
        /// Convicted and Sentenced
        /// </summary>
        CS,
        /// <summary>
        /// Acquitted
        /// </summary>
        AC,
        /// <summary>
        /// Abated
        /// </summary>
        AB,
        /// <summary>
        /// Taken into Consideration
        /// </summary>
        TI,
        /// <summary>
        /// Appeal Allowed
        /// </summary>
        AA,
        /// <summary>
        /// Appeal Dismissed
        /// </summary>
        AD
    }

    /// <summary>
    /// List of ChecklistCommentType.
    /// </summary>
    [Serializable]
    public enum ChecklistCommentStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Draft".
        /// </summary>
        D,

        /// <summary>
        /// Represents "Sent".
        /// </summary>
        S
    }

    /// <summary>
    /// List of ChecklistCommentType.
    /// </summary>
    [Serializable]
    public enum ChecklistCommentType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Internal".
        /// </summary>
        I,

        /// <summary>
        /// Represents "External".
        /// </summary>
        E
    }

    /// <summary>
    /// List of Checklist Status.
    /// </summary>
    [Serializable]
    public enum ChecklistStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "In Process".
        /// </summary>
        I,

        /// <summary>
        /// Represents "Completed".
        /// </summary>
        C
    }

    /// <summary>
    /// List for Child Of.
    /// </summary>
    [Serializable]
    public enum ChildOf
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Plaintiff".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Defendant".
        /// </summary>
        D
    }

    //
    /// <summary>
    /// List of CitizenshipStatus.
    /// </summary>
    [Serializable]
    public enum CitizenshipStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,
        // <summary>
        /// Represents "Previous" value.
        /// </summary>
        P,
        // <summary>
        /// Represents "Current" value.
        /// </summary>
        C
    }

    public enum CivilCriminalSaleConductedBy
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Auctioneer
        /// </summary>
        A,

        /// <summary>
        /// Bailiff
        /// </summary>
        B,

        /// <summary>
        /// Tender
        /// </summary>
        T,

        /// <summary>
        /// Others
        /// </summary>
        O
    }

    /// <summary>
    /// List of ClaimForPNOrDef
    /// </summary>
    [Serializable]
    public enum ClaimForPNOrDef
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Plaintiff
        /// </summary>
        P,

        /// <summary>
        /// Defendant
        /// </summary>
        D
    }

    public enum ClaimType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Miscellaneous
        /// </summary>
        M,

        /// <summary>
        /// Transport
        /// </summary>
        T,

        /// <summary>
        /// Disbursement
        /// </summary>
        D
    }

    /// <summary>
    /// List of Consolidated Type Indicators.
    /// </summary>
    [Serializable]
    public enum ConsolidatedTypeInd
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Not Applicable" (default).
        /// </summary>
        N,

        /// <summary>
        /// Represents "Leading Case" which is a valid case.
        /// </summary>
        L,

        /// <summary>
        /// Represents "Related Case" which is not a valid case.
        /// System should not process any operation to such cases.
        /// </summary>
        R
    }

    /// <summary>
    /// List of Contact types.
    /// </summary>
    [Serializable]
    public enum ContactType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Local".
        /// </summary>
        L,

        /// <summary>
        /// Represents "Foreign".
        /// </summary>
        F
    }

    /// <summary>
    /// List of AttachmentType
    /// </summary>
    [Serializable]
    public enum ControlType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Partner
        /// </summary>
        P,

        /// <summary>
        /// Manager
        /// </summary>
        M,
        /// <summary>
        /// Partner  and Manager
        /// </summary>
        B,
    }

    /// <summary>
    /// List of Yes and No.
    /// </summary>
    [Serializable]
    public enum CreditDebit
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Debit".
        /// </summary>
        D,

        /// <summary>
        /// Represents "Credit".
        /// </summary>
        C
    }

    /// <summary>
    /// List of CrimeCase.
    /// </summary>
    [Serializable]
    public enum CrimeCase
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Normal Case Types".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Read With".
        /// </summary>
        R,
        /// <summary>
        /// Represents "Punishable Under".
        /// </summary>
        P,
        /// <summary>
        /// Offence Information".
        /// </summary>
        O
    }

    /// <summary>
    /// List of Crime Claim Hearing Type code.
    /// </summary>
    [Serializable]
    public enum CrimeClaimHearingType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Pre-Trial Conference
        /// </summary>
        PTC,

        /// <summary>
        /// Committal Hearing
        /// </summary>
        CH,

        /// <summary>
        /// Trials
        /// </summary>
        T,

        /// <summary>
        /// Appeals
        /// </summary>
        APP
    }

    /// <summary>
    /// List of Criminal Claim status
    /// </summary>
    [Serializable]
    public enum CriminalClaimStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Pending Submission
        /// </summary>
        P,

        /// <summary>
        /// Pending Supervisor
        /// </summary>
        PS,

        /// <summary>
        /// Pending AR
        /// </summary>
        PA,

        /// <summary>
        /// Pending Finance
        /// </summary>
        PF,

        /// <summary>
        /// Rejected By Supervisor
        /// </summary>
        RS,

        /// <summary>
        /// Rejected By AR
        /// </summary>
        RA,

        /// <summary>
        /// Rejected By Finance
        /// </summary>
        RF,

        /// <summary>
        /// Claim Successful
        /// </summary>
        CS
    }

    /// <summary>
    /// List of Criminal Counsels.
    /// </summary>
    [Serializable]
    public enum CriminalCounselTypes
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Lead Counsel".
        /// </summary>
        L,

        /// <summary>
        /// Represents "Assisting Counsel".
        /// </summary>
        A,

        /// <summary>
        /// Represents "None".
        /// </summary>
        N
    }

    /// <summary>
    /// List of Nature of Sentence.
    /// </summary>
    [Serializable]
    public enum CriminalNatureOfSentence
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Consecutive".
        /// </summary>
        CS,

        /// <summary>
        /// Represents "Concurrent".
        /// </summary>
        CN,
    }

    /// <summary>
    /// List of Criminal "Party In" Types.
    /// </summary>
    [Serializable]
    public enum CriminalPartyInType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Bail".
        /// </summary>
        BL,

        /// <summary>
        /// Represents "Remand".
        /// </summary>
        RD,

        /// <summary>
        /// Represents "Custody".
        /// </summary>
        CD,

        /// <summary>
        /// Represents "Warrant".
        /// </summary>
        WT,

        /// <summary>
        /// Represents "Acquittal".
        /// </summary>
        AQ,

        /// <summary>
        /// Represents "Others".
        /// </summary>
        OT
    }

    /// <summary>
    /// List of CriminalRelease Types.
    /// </summary>
    [Serializable]
    public enum CriminalReleaseType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Full Release
        /// </summary>
        F,

        /// <summary>
        /// Partial Release
        /// </summary>
        P
    }

    /// <summary>
    /// List of Status of Sentence.
    /// </summary>
    [Serializable]
    public enum CriminalStatusOfSentence
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Fine Paid".
        /// </summary>
        FP,

        /// <summary>
        /// Represents "Fine Not Paid".
        /// </summary>
        FNP,

        /// <summary>
        /// Represents "Paying by Instalments".
        /// </summary>
        PBI,

        /// <summary>
        /// Represents "Serving Sentence".
        /// </summary>
        SS,

        /// <summary>
        /// Represents "Sentence Served".
        /// </summary>
        SSD
    }

    /// <summary>
    /// List of Custody and Remand.
    /// </summary>
    [Serializable]
    public enum CustodyRemand
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Custody".
        /// </summary>
        C,

        /// <summary>
        /// Represents "Remand".
        /// </summary>
        R,

        /// <summary>
        /// Represents "Both".
        /// </summary>
        B
    }

    /// <summary>
    /// List of DayInTheWeek.
    /// </summary>
    [Serializable]
    public enum DayInTheWeek
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Monday" value.
        /// </summary>
        Monday,

        /// <summary>
        /// Represents "Tuesday" value.
        /// </summary>
        Tuesday,

        /// <summary>
        /// Represents "Wednesday" value.
        /// </summary>
        Wednesday,

        /// <summary>
        /// Represents "Thursday" value.
        /// </summary>
        Thursday,

        /// <summary>
        /// Represents "Friday" value.
        /// </summary>
        Friday,

        /// <summary>
        /// Represents "Saturday" value.
        /// </summary>
        Saturday,

        /// <summary>
        /// Represents "Sunday" value.
        /// </summary>
        Sunday
    }

    /// <summary>
    /// List of DegreeType.
    /// </summary>
    [Serializable]
    public enum DegreeType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,
        /// <summary>
        /// Represents Law Degree
        /// </summary>
        Y,
        /// <summary>
        /// Represents Any Other Degree
        /// </summary>
        N
    }

    [Serializable]
    public enum DenyAccessType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,
        /// <summary>
        /// Represents "Pop-up" value.
        /// </summary>
        B,
        /// <summary>
        /// Represents "Hide" value.
        /// </summary>
        H,
        /// <summary>
        /// Represents "Show" value.
        /// </summary>
        D
    }

    /// <summary>
    /// List of Divorce Case Nature types.
    /// </summary>
    [Serializable]
    public enum DivorceCaseNature
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Contested Divorce" type.
        /// </summary>
        CD,

        /// <summary>
        /// Represents "Uncontested Divorce" type.
        /// </summary>
        UD
    }

    /// <summary>
    /// List of Update type for Case Party.
    /// </summary>
    [Serializable]
    public enum DocCasePartyUpdateType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Add".
        /// <remarks>Party is added newly.</remarks>
        /// </summary>
        A,

        /// <summary>
        /// Represents "No change".
        /// <remarks>Party is neither added nor party's details are updated.</remarks>
        /// </summary>
        N,

        /// <summary>
        /// Represents "Update".
        /// <remarks>Party's details are updated.</remarks>
        /// </summary>
        U
    }

    /// <summary>
    /// List of DocCommentType.
    /// </summary>
    [Serializable]
    public enum DocCommentType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "S".
        /// </summary>
        S,

        /// <summary>
        /// Represents "G".
        /// </summary>
        G
    }

    [Serializable]
    public enum DocInitiatedLocation
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,
        /// <summary>
        /// Represents "FrontEnd" value.
        /// </summary>
        FE,
        /// <summary>
        /// Represents "HighCourt" value.
        /// </summary>
        HC,
        /// <summary>
        /// Represents "SubCourt" value.
        /// </summary>
        SU,
        /// <summary>
        /// Represents "Family Justice Courts" value.
        /// </summary>
        FJ
    }

    [Serializable]
    public enum CourtIndicator
    {
        /// <summary>
        /// In a situation when there is no valid indicator
        /// </summary>
        Null,
        /// <summary>
        /// Represents "High Court" value.
        /// </summary>
        HC,
        /// <summary>
        /// Represents "State Court" value.
        /// </summary>
        SU,
        /// <summary>
        /// Represents "Family Justic Court" value.
        /// </summary>
        FJ
    }

    /// <summary>
    /// List of document status code.
    /// </summary>
    [Serializable]
    public enum DocStatus
    {
        /// <summary>
        /// Represents accepted
        /// </summary>
        A,

        /// <summary>
        /// Represents draft
        /// </summary>
        D,

        /// <summary>
        /// Represents pending (not processed yet)
        /// </summary>
        P,

        /// <summary>
        /// Represents pending for process
        /// </summary>
        PP,

        /// <summary>
        /// Represents rejected
        /// </summary>
        R,

        /// <summary>
        /// Represents sent
        /// </summary>
        S
    }

    /// <summary>
    /// List of document file type.
    /// </summary>
    [Serializable]
    public enum DocumentFileType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Eform documents".
        /// </summary>
        E,

        /// <summary>
        /// Represents "Pdf documents".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Word document".
        /// </summary>
        W,


        /// <summary>
        /// Represents "Office 2007 (.docx) Word document".
        /// </summary>
        X,

        /// <summary>
        /// Represents "Minute Sheet".
        /// </summary>
        M
    }

    /// <summary>
    /// List of Document Filing Type.
    /// </summary>
    [Serializable]
    public enum DocumentFilingType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Normal" filing.
        /// </summary>
        N,

        /// <summary>
        /// Represents "Amendment" filing.
        /// </summary>
        A,

        /// <summary>
        /// Represents "Refile" filing.
        /// </summary>
        R,

        /// <summary>
        /// Represents "Reply Form" filing.
        /// </summary>
        F,

        ///// <summary>
        ///// Represents "Checklist" filing.
        ///// </summary>
        //C,

        /// <summary>
        /// Represents "Generic Back End Correspondence" filing.
        /// </summary>
        G
    }

    /// <summary>
    /// List of Document Process Type.
    /// </summary>
    [Serializable]
    public enum DocumentProcessType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Not Applicable".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Auto".
        /// </summary>
        A,

        /// <summary>
        /// Represents "Manual".
        /// </summary>
        M
    }

    [Serializable]
    public enum DSCIN
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,
        /// <summary>
        /// Represents "Whole" value.
        /// </summary>
        W,
        /// <summary>
        /// Represents "Part" value.
        /// </summary>
        P
    }

    [Serializable]
    public enum DSCType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,
        /// <summary>
        /// Represents "Action" value.
        /// </summary>
        A,
        /// <summary>
        /// Represents "Defence" value.
        /// </summary>
        D,
        /// <summary>
        /// Represents "Counterclaim" value.
        /// </summary>
        C,
        /// <summary>
        /// Represents "Defence and Counterclaim" value.
        /// </summary>
        F
    }

    [Serializable]
    public enum EHearingStatus
    {
        Null,
        E,
        P,
        S,
        N
    }

    public enum EMSType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Civil
        /// </summary>
        CIV,

        /// <summary>
        /// Criminal
        /// </summary>
        CRM,

        /// <summary>
        /// Admiralty
        /// </summary>
        ADM,

        /// <summary>
        /// Criminal WLCPF
        /// </summary>
        CPF
    }

    /// <summary>
    /// List of EndorsementTypes.
    /// </summary>
    [Serializable]
    public enum EndorsementType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "No endorsements required".
        /// </summary>
        N,

        /// <summary>
        /// Represents "By-consent application".
        /// </summary>
        C,

        /// <summary>
        /// Represents "Ex-parte application".
        /// </summary>
        E
    }

    public enum ExecLedgerCode
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Account Transfer
        /// </summary>
        ATR,

        /// <summary>
        /// Attendance Fee
        /// </summary>
        ATT,

        /// <summary>
        /// Payment to Bailiff
        /// </summary>
        BAL,

        /// <summary>
        /// Cancelled cheque re-credited
        /// </summary>
        CCC,

        /// <summary>
        /// Cancelled cheque re-issued
        /// </summary>
        CCI,

        /// <summary>
        /// Court Commission
        /// </summary>
        COM,

        /// <summary>
        /// Dishonoured Cheque re-credited
        /// </summary>
        DHC,

        /// <summary>
        /// Dishonoured Cheque re-issued
        /// </summary>
        DHI,

        /// <summary>
        /// Dishonoured Cheque
        /// </summary>
        DHQ,

        /// <summary>
        /// Deposit
        /// </summary>
        DPT,

        /// <summary>
        /// Expired cheque re-credited
        /// </summary>
        ECC,

        /// <summary>
        /// Expired cheque re-issued
        /// </summary>
        ECI,

        /// <summary>
        /// Fund Transfer
        /// </summary>
        FTR,

        /// <summary>
        /// Payment for Debt & Cost
        /// </summary>
        PDC,

        /// <summary>
        /// Payment to Others
        /// </summary>
        PTO,

        /// <summary>
        /// Received from Auctioneer
        /// </summary>
        RAT,

        /// <summary>
        /// Received Payment for Debt & Cost
        /// </summary>
        RDC,

        /// <summary>
        /// Refund of Deposit
        /// </summary>
        ROD,

        /// <summary>
        /// Other Receivables
        /// </summary>
        ROT,

        /// <summary>
        /// Transfer from Revenue
        /// </summary>
        TFR,

        /// <summary>
        /// Transfer to Revenue
        /// </summary>
        TTR,

        /// <summary>
        /// Void Receipt
        /// </summary>
        VRT,

        /// <summary>
        ///
        /// </summary>
        NPS,

        /// <summary>
        /// Registrar Supreme Court
        /// </summary>
        RSC //BUG-ENFPROD-2013042202 - Mantis:00009031
    }

    public enum ExecutionOutcome
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Successful
        /// </summary>
        S,

        /// <summary>
        /// Unsuccessful
        /// </summary>
        U
    }

    [Serializable]
    public enum ExecutorStatus
    {
        /// <summary>
        /// Null
        /// </summary>
        Null,
        /// <summary>
        /// Renounced
        /// </summary>
        R,
        /// <summary>
        /// Deceased
        /// </summary>
        D,
        /// <summary>
        /// Leave being reserved to come in and prove the Will
        /// </summary>
        L,
        /// <summary>
        /// Others
        /// </summary>
        O
    }

    /// <summary>
    /// List of RefundStatus.
    /// </summary>
    [Serializable]
    public enum FeeRuleType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        //TODO: F - value.
        /// <summary>
        /// Represents "" value.
        /// </summary>
        F,

        /// <summary>
        /// Represents "" value.
        /// </summary>
        C,

        /// <summary>
        /// Represents "" value.
        /// </summary>
        H
    }

    /// <summary>
    /// List of LFGroupCode.
    /// </summary>
    [Serializable]
    public enum FiledUserType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Normal User" value.
        /// </summary>
        N,

        /// <summary>
        /// Represents "– Umbrella User" value.
        /// </summary>
        U
    }

    /// <summary>
    /// List of FileInspectionDocStatus.
    /// </summary>
    [Serializable]
    public enum FileInspectionDocStatus
    {
        /// <summary>
        /// Represents "Draft" Value
        /// </summary>
        D,

        /// <summary>
        /// Represents "New" Value
        /// </summary>
        N,

        /// <summary>
        /// Represents "Active" Value
        /// </summary>
        A,

        /// <summary>
        /// Represents "Expired" Value
        /// </summary>
        E
    }

    /// <summary>
    /// List of FileInspectionStatus.
    /// </summary>
    [Serializable]
    public enum FileInspectionStatus
    {
        /// <summary>
        /// Represents "Pending Approval (Front End Filing)" Value
        /// </summary>
        P,

        /// <summary>
        /// Represents "Approved (Duty Registrar approval)" Value
        /// </summary>
        A,

        /// <summary>
        /// Represents "Rejected (Duty Registrar rejection)" Value
        /// </summary>
        R,

        /// <summary>
        /// Represents "Completed (Case Officer case assignment completion)" Value
        /// </summary>
        C
    }

    /// <summary>
    /// List of FilingFrom.
    /// </summary>
    [Serializable]
    public enum FilingFrom
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Notification".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Subsequent".
        /// </summary>
        S
    }

    /// <summary>
    /// List of types for which order is being filed for.
    /// </summary>
    [Serializable]
    public enum FilingOrderFor
    {
        /// <summary>
        /// Represents "Summons".
        /// </summary>
        S,

        /// <summary>
        /// Represents "Others".
        /// </summary>
        O,
        /// <summary>
        /// Represents "Interim Judgement"
        /// </summary>
        I,
        /// <summary>
        /// Represents "Judicial Separation"
        /// </summary>
        J,
        /// <summary>
        /// Represents "CPF Order"
        /// </summary>
        C
    }

    /// <summary>
    /// List of Filing party indicator.
    /// </summary>
    [Serializable]
    public enum FilingPartyInd
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Not a filing party".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Filing party".
        /// </summary>
        Y
    }

    /// <summary>
    /// List of different FilingType
    /// </summary>
    public enum FilingType
    {
        /// <summary>
        /// Default will be NONE
        /// </summary>
        NONE,

        /// <summary>
        /// Commencing
        /// </summary>
        Commencing,

        /// <summary>
        /// Subsequent
        /// </summary>
        Subsequent
    }

    /// <summary>
    /// List of FrequencyType.
    /// </summary>
    [Serializable]
    public enum FrequencyType
    {
        /// <summary>
        /// Minute
        /// </summary>
        MM,
        /// <summary>
        /// Hour
        /// </summary>
        H,
        /// <summary>
        /// Day
        /// </summary>
        D,
        /// <summary>
        /// Week
        /// </summary>
        W,
        /// <summary>
        /// Month
        /// </summary>
        M
    }

    /// <summary>
    /// List of HearingAccessInd types.
    /// </summary>
    [Serializable]
    public enum HearingAccessInd
    {
        /// <summary>
        /// Represents "Assigned".
        /// </summary>
        A,

        /// <summary>
        /// Represents "Disqualified".
        /// </summary>
        D,

        /// <summary>
        /// Represents "Prefer".
        /// </summary>
        P
    }

    /// <summary>
    /// List of HearingCategory
    /// </summary>
    [Serializable]
    public enum HearingCategory
    {
        /// <summary>
        /// NULL.
        /// </summary>
        Null,
        /// <summary>
        ///Counseling Mandatory
        /// </summary>
        CM,
        /// <summary>
        /// Counseling Not Mandatory
        /// </summary>
        CNM,
        /// <summary>
        /// Access Evaluation Report
        /// </summary>
        AER,
        /// <summary>
        /// Custody Evaluation Report
        /// </summary>
        CER,
        /// <summary>
        /// Mediation Mandatory
        /// </summary>
        MM,
        /// <summary>
        /// Mediation Not Mandatory
        /// </summary>
        MNM,
        /// <summary>
        /// Face to Face
        /// </summary>
        DRT,
        /// <summary>
        /// Telephone
        /// </summary>
        TLP,
        /// <summary>
        /// Video
        /// </summary>
        VDO,
        /// <summary>
        /// Others
        /// </summary>
        OTH
    }

    /// <summary>
    /// List of hearing mode indicator
    /// </summary>
    [Serializable]
    public enum HearingModeInd
    {
        /// <summary>
        /// Normal hearing
        /// </summary>
        N,

        /// <summary>
        /// Paper hearing
        /// </summary>
        P
    }

    /// <summary>
    /// List of ICA Interface Status
    /// </summary>
    [Serializable]
    public enum ICAInterfaceStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Initial".
        /// </summary>
        I,

        /// <summary>
        /// Represents "Processing".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Completed".
        /// </summary>
        C,

        /// <summary>
        /// Represents "Error due to download eform".
        /// </summary>
        ED,

        /// <summary>
        /// Represents "Error due to PDF conversion".
        /// </summary>
        EC,

        /// <summary>
        /// Represents "Error due to FTP to ICA".
        /// </summary>
        EF
    }

    /// <summary>
    /// List of InterfaceCriminalStatus
    /// </summary>
    [Serializable]
    public enum InterfaceCriminalStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// New
        /// </summary>
        N,

        /// <summary>
        /// Created
        /// </summary>
        C,

        /// <summary>
        /// Draft
        /// </summary>
        D
    }

    /// <summary>
    /// List of Case Track.
    /// </summary>
    [Serializable]
    public enum InterpreterLanguage
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Not Applicable" (default).
        /// When a new case is created in IELS system.
        /// </summary>
        N,

        /// <summary>
        /// Represents "Chinese" language.
        /// </summary>
        C,

        /// <summary>
        /// Represents "Malay" language.
        /// </summary>
        M,

        /// <summary>
        /// Represents "Tamil" language.
        /// </summary>
        T
    }

    /// <summary>
    /// List of Involvement indicator.
    /// </summary>
    [Serializable]
    public enum InvolvementInd
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Judgment Against".
        /// <remarks>Judgment Against (used in WOS – Judgment Order)</remarks>
        /// </summary>
        J,

        /// <summary>
        /// Represents "Discontinuance filed".
        /// <remarks>Party who is discontinued ‘The Notice of Discontinuance form’ filed against party.</remarks>
        /// </summary>
        D,

        /// <summary>
        /// Represents "Hearing against".
        /// <remarks>Hearing Against – party selected in Notice of appointment for assessment of damages.</remarks>
        /// </summary>
        H,

        /// <summary>
        /// Represents "Entering appearance".
        /// <remarks>Entering appearance for MOA doc filing parties.</remarks>
        /// </summary>
        E,

        /// <summary>
        /// Represents "Person Cited".
        /// <remarks> Person Cited for “Citation” doc filing as subsequent.</remarks>
        /// </summary>
        P,

        /// <summary>
        /// Represents "Warning Against".
        /// <remarks> Warning Against for “Warning to Caveat”  doc filing in Probate.</remarks>
        /// </summary>
        W,
        /// <summary>
        /// Represents "Party Against".
        /// <remarks>Party Against</remarks>
        /// </summary>
        A
    }

    /// <summary>
    /// List of IsAppealFiledCorrectly types.
    /// </summary>
    [Serializable]
    public enum IsAppealFiledCorrectly
    {
        /// <summary>
        /// Yes, it should be filed as an RAS under Order 55C
        /// </summary>
        Y55C,

        /// <summary>
        /// No, it should be filed as a DCA under Order 55D
        /// </summary>
        N55D,

        /// <summary>
        /// No, it should be filed as an RA under Order 55B
        /// </summary>
        N55B
    }

    /// <summary>
    /// List of JudgmentFor.
    /// </summary>
    [Serializable]
    public enum JudgmentFor
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        ///
        /// </summary>
        OT,

        /// <summary>
        ///
        /// </summary>
        LQ,
        /// <summary>
        ///
        /// </summary>
        UQ
    }

    /// <summary>
    /// List of Jurisdiction Domicile For Party types.
    /// </summary>
    [Serializable]
    public enum JurisdictionDomicileForParty
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Singapore Citizen" type.
        /// </summary>
        SC,

        /// <summary>
        /// Represents "Singapore Permanent Resident" type.
        /// </summary>
        SPR,
        /// <summary>
        /// Represents "Others"
        /// </summary>
        OTH
    }

    /// <summary>
    /// List for Admiralty Writ Types.
    /// </summary>
    [Serializable]
    public enum JurisdictionInSingapore
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Yes" value.
        /// </summary>
        Y,

        /// <summary>
        /// Represents "No".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Unknown ".
        /// </summary>
        U
    }

    /// <summary>
    /// List of LAC Concluded Status.
    /// </summary>
    [Serializable]
    public enum LACConcludedStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Cancelled (Once Cancellation document is filed)".
        /// </summary>
        CC,

        /// <summary>
        /// Represents "Expired (Expired as per the expiry date)".
        /// </summary>
        EX,

        /// <summary>
        /// Represents "Revoked (Applicable to PGA, when GA overrides it)".
        /// </summary>
        RV,

        /// <summary>
        /// Represents "Closed".
        /// </summary>
        CS,
        /// <summary>
        /// Represents "Concluded By Court
        /// </summary>
        BC
    }

    /// <summary>
    /// List of LAC Document Status.
    /// </summary>
    [Serializable]
    public enum LACDocStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Draft".
        /// </summary>
        D,

        /// <summary>
        /// Represents "New".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Referred".
        /// </summary>
        R,

        /// <summary>
        /// Represents "Active".
        /// </summary>
        A,

        /// <summary>
        /// Represents "Concluded".
        /// </summary>
        C
    }

    /// <summary>
    /// List of LAC Status.
    /// </summary>
    [Serializable]
    public enum LACRefStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "New".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Active".
        /// </summary>
        A,

        /// <summary>
        /// Represents "Concluded".
        /// </summary>
        C
    }

    /// <summary>
    /// List of LAC Status.
    /// </summary>
    [Serializable]
    public enum LACStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Draft".
        /// </summary>
        D,

        /// <summary>
        /// Represents "New".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Active".
        /// </summary>
        A,

        /// <summary>
        /// Represents "Concluded".
        /// </summary>
        C
    }

    /// <summary>
    /// List of LAC Type.
    /// </summary>
    [Serializable]
    public enum LACType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Grant of Aid".
        /// </summary>
        G,

        /// <summary>
        /// Represents "Provisional Grant of Aid".
        /// </summary>
        P
    }

    /// <summary>
    /// List of LAP Interface File Status.
    /// </summary>
    [Serializable]
    public enum LAPInterfaceFileStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "File Uploaded".
        /// </summary>
        U,

        /// <summary>
        /// Represents "File Processed".
        /// </summary>
        P
    }

    /// <summary>
    /// List of LawFirmContact types.
    /// </summary>
    [Serializable]
    public enum LawPracticeType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Cause Book Organization"
        /// </summary>
        B,
        /// <summary>
        /// Represents "Law Firm".
        /// </summary>
        L,

        /// <summary>
        /// Represents "Foreign Law Alliance".
        /// </summary>
        F,

        /// <summary>
        /// Represents "Joint Law Venture".
        /// </summary>
        J,

        /// <summary>
        /// Represents "Concurrent foreign Law practice".
        /// </summary>
        C,

        /// <summary>
        /// Represents "Licensed foreign Law practice".
        /// </summary>
        I,

        /// <summary>
        /// Represents "Qualifying foreign Law practice".
        /// </summary>
        Q,
        /// <summary>
        /// Represents "Singapore Law Practice".
        /// </summary>
        S
    }

    /// <summary>
    /// List of LeaveToAppeal types.
    /// </summary>
    [Serializable]
    public enum LeaveToAppeal
    {
        /// <summary>
        /// The matter is not appealable
        /// </summary>
        NA,

        /// <summary>
        /// Leave to appeal is required
        /// </summary>
        AR,

        /// <summary>
        /// Leave to appeal is not required
        /// </summary>
        NRC2,

        /// <summary>
        /// - NE  will be forwarded in 4 weeks
        /// </summary>
        GDCTNE4W,

        /// <summary>
        /// GD/CT will be forwarded in 8 weeks
        /// </summary>
        GDCT8W,

        /// <summary>
        /// GD/CT will be forwarded in 3 months
        /// </summary>
        GDCT3M
    }

    /// <summary>
    /// List of LegalExperienceType.
    /// </summary>
    [Serializable]
    public enum LegalExperienceType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,
        /// <summary>
        /// Represents "Relevant Legal Training" value.
        /// </summary>
        RLT,
        /// <summary>
        /// Represents "Relevant Legal Practice or work" value.
        /// </summary>
        RLP,
        /// <summary>
        /// Represents "Relevant work” obtained on or before 1st August 2009" value.
        /// </summary>
        B09,
        /// <summary>
        /// Represents "Relevant work” obtained after 1st August 2009" value.
        /// </summary>
        A09,
        /// <summary>
        /// Represents "Any other legal experience " value.
        /// </summary>
        OTH,
        /// <summary>
        /// Represents "Law Practice" value.
        /// </summary>
        LP,
        /// <summary>
        /// Represents "Law Firm" value.
        /// </summary>
        LF,
        /// <summary>
        /// Represents "Law Soceity" value.
        /// </summary>
        LS,
        /// <summary>
        /// Represents "Law Corporation" value.
        /// </summary>
        LC,
        /// <summary>
        /// Represents "In House" value.
        /// </summary>
        IH,
        /// <summary>
        /// Represent "Statutory Board"
        /// </summary>
        SCB
    }

    [Serializable]
    public enum LegalOrganizationType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,
        /// <summary>
        /// Represents "State Board" value.
        /// </summary>
        SB,
        /// <summary>
        /// Represents "In House Legal" value.
        /// </summary>
        IHL
    }

    /// <summary>
    /// List of LFGroupCode.
    /// </summary>
    [Serializable]
    public enum LFGroupCode
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Normal Law firm" value.
        /// </summary>
        LF,

        /// <summary>
        /// Represents "Service Bureau" value.
        /// </summary>
        SB,

        /// <summary>
        /// Represents " Legal Aid Bureau" value.
        /// </summary>
        LB,
        /// <summary>
        /// Represents "Insolvency and Public Trustee's Office" value.
        /// </summary>
        IPTO,
        /// <summary>
        /// Represents " Attorney General Council" value.
        /// </summary>
        AGC,
        /// <summary>
        /// Represents "Attorney-General's Chambers (Criminal Justice Division)" value.
        /// </summary>
        AGCCD,
        /// <summary>
        /// Represents "Singapore Institute of Legal Education" value.
        /// </summary>
        BLE,
        /// <summary>
        /// Represents "Cause Book Organization" value.
        /// </summary>
        CBS,
        /// <summary>
        /// Represents "Call Centre" value.
        /// </summary>
        CC,
        /// <summary>
        /// Represents " Court FE Admin" value.
        /// </summary>
        CO,
        /// <summary>
        /// Represents "Law Society" value.
        /// </summary>
        LAWSO
    }

    /// <summary>
    /// List of LogicalOperator
    /// </summary>
    [Serializable]
    public enum LogicalOperator
    {
        /// <summary>
        /// AND Operator
        /// </summary>
        AND,

        /// <summary>
        /// OR Operator
        /// </summary>
        OR,

        /// <summary>
        /// NOT Operator
        /// </summary>
        NOT
    }

    /// <summary>
    /// List of LPA LPR Section or Provision.
    /// </summary>
    [Serializable]
    public enum LPALPRSectionOrProvision
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Rule25".
        /// </summary>
        Rule25,

        /// <summary>
        /// Represents "Rule27".
        /// </summary>
        Rule27
    }

    /// <summary>
    /// List of Mailbox MessageType.
    /// </summary>
    [Serializable]
    public enum MailboxMessageType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Notification".
        /// </summary>
        N,

        /// <summary>
        /// Represents "EService".
        /// </summary>
        E,

        /// <summary>
        /// Represents "Draft".
        /// </summary>
        D,

        /// <summary>
        /// Represents "OutBox".
        /// </summary>
        O,

        /// <summary>
        /// Represents "Pending for Acknowledgement".
        /// </summary>
        PA
    }

    /// <summary>
    /// List of Mailbox status.
    /// </summary>
    [Serializable]
    public enum MailboxStatus
    {
        /// <summary>
        /// Represents "Accepted".
        /// </summary>
        A,

        /// <summary>
        /// Represents "Pending".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Rejected".
        /// </summary>
        R,

        /// <summary>
        /// Represents "Draft".
        /// </summary>
        D
    }

    //public enum MiscellaneousClaimStatus
    //{
    //    /// <summary>
    //    /// Represents "NULL" value.
    //    /// </summary>
    //    Null,
    //    /// <summary>
    //    ///  Pending
    //    /// </summary>
    //    P,
    //    /// <summary>
    //    /// Rejected
    //    /// </summary>
    //    R,
    //    /// <summary>
    //    /// Vetted
    //    /// </summary>
    //    V,
    //    /// <summary>
    //    /// Approved
    //    /// </summary>
    //    A
    //}
    /// <summary>
    /// List of ModeOfAmendment.
    /// </summary>
    [Serializable]
    public enum ModeOfAmendment
    {
        /// <summary>
        /// Represents "Administrative" value.
        /// </summary>
        Administrative,

        /// <summary>
        /// Represents "Court Approval".
        /// </summary>
        CourtApproval,

        /// <summary>
        /// Represents "Amendment from Court".
        /// </summary>
        AmendmentFromCourt
    }

    /// <summary>
    /// List of NatureOfCDR types.
    /// </summary>
    [Serializable]
    public enum NatureOfCDR
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Mediation" type.
        /// </summary>
        M,

        /// <summary>
        /// Represents "Indication" type.
        /// </summary>
        I,

        /// <summary>
        /// Represents "Others" type.
        /// </summary>
        O,
    }

    /// <summary>
    /// List of NatureOfDeputyShip
    /// </summary>
    [Serializable]
    public enum NatureOfDeputyShip
    {
        /// <summary>
        /// Represents "Null" Value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Personal welfare".
        /// </summary>
        PW,

        /// <summary>
        /// Represents "Property and Affairs".
        /// </summary>
        PA,

        /// <summary>
        /// Represents "Personal Welfare, Property and affairs".
        /// </summary>
        PWPA
    }

    /// <summary>
    /// List of OCRStatus.
    /// </summary>
    [Serializable]
    public enum OCRStatus
    {
        /// <summary>
        /// Not applicable
        /// </summary>
        N,

        /// <summary>
        ///Marked for OCR
        /// </summary>
        M,

        /// <summary>
        ///OCR in Progress
        /// </summary>
        I,

        /// <summary>
        ///Has been OCR
        /// </summary>
        O,

        /// <summary>
        /// OCR Failed
        /// </summary>
        F
    }

    [Serializable]
    public enum OGCQueueStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,
        /// <summary>
        /// Represents "New" value.
        /// </summary>
        N,
        /// <summary>
        /// Represents "In-Process" value.
        /// </summary>
        I,
        /// <summary>
        /// Represents "Queued" value.
        /// </summary>
        Q,
        /// <summary>
        /// Represents "Sucess" value.
        /// </summary>
        S,
        /// <summary>
        /// Represents "Error" value.
        /// </summary>
        E,
        /// <summary>
        /// Represents "Recover" value.
        /// </summary>
        R,
        /// <summary>
        /// Represents "KIV" value.
        /// </summary>
        K,
        /// <summary>
        /// Represents "View" value.
        /// </summary>
        V
    }

    /// <summary>
    /// List of OnlineEnquiryReport Type.
    /// </summary>
    [Serializable]
    public enum OnlineEnquiryReportType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Operational Report" value.
        /// </summary>
        OR,

        /// <summary>
        /// Represents "Management Report" value.
        /// </summary>
        MR
    }

    /// <summary>
    /// List of OnlineEnquirySchedulerInfo.
    /// </summary>
    [Serializable]
    public enum OnlineEnquirySchedulerInfo
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Daily" value.
        /// </summary>
        D,

        /// <summary>
        /// Represents "Weekly" value.
        /// </summary>
        W,

        /// <summary>
        /// Represents "Monthly" value.
        /// </summary>
        M,

        /// <summary>
        /// Represents "Yearly" value.
        /// </summary>
        Y
    }

    /// <summary>
    /// List of WOE Order Enforced Types
    /// </summary>
    [Serializable]
    public enum OrderEnforcedTypes
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Employment Act
        /// </summary>
        E,

        /// <summary>
        /// Work Injury Compensation Act
        /// </summary>
        W
    }

    /// <summary>
    /// List of Order Made In types.
    /// </summary>
    [Serializable]
    public enum OrderMadeIn
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Open Court".
        /// </summary>
        OC,

        /// <summary>
        /// Represents "Chambers".
        /// </summary>
        CH
    }

    /// <summary>
    /// List of OrderType
    /// </summary>
    [Serializable]
    public enum OrderType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Leave Of Court" value.
        /// </summary>
        LOC,

        /// <summary>
        /// Represents "Extension Of Time" value.
        /// </summary>
        EOT,

        /// <summary>
        /// Represents "Judgment" value.
        /// </summary>
        JOC,

        /// <summary>
        /// Represents "Order" value.
        /// </summary>
        ORC
    }

    [Serializable]
    public enum Origin
    {
        /// <summary>
        /// Null
        /// </summary>
        Null,
        /// <summary>
        /// Commonwealth
        /// </summary>
        C,
        /// <summary>
        /// Gazetted
        /// </summary>
        G,
        /// <summary>
        /// Others
        /// </summary>
        O
    }

    //public enum DebtorClaimantIdentifierType
    //{
    //    /// <summary>
    //    /// Represents "NULL" value.
    //    /// </summary>
    //    Null,
    //    /// <summary>
    //    ///  Debtor
    //    /// </summary>
    //    D,
    //    /// <summary>
    //    /// Claimant
    //    /// </summary>
    //    C
    //}

    [Flags]
    public enum OtherPartyType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null = 0,

        /// <summary>
        ///  Debtor
        /// </summary>
        D = 1 << 0,

        /// <summary>
        /// Claimant
        /// </summary>
        C = 1 << 1,

        /// <summary>
        /// Other
        /// </summary>
        O = 1 << 2,

        /// <summary>
        /// Non-Party
        /// </summary>
        N = 1 << 3,

        /// <summary>
        /// Respondant
        /// </summary>
        R = 1 << 4,

        /// <summary>
        /// Registrar Supreme Court for Adm
        /// </summary>
        S = 1 << 5,

        /// <summary>
        /// Bailiff for Adm
        /// </summary>
        B = 1 << 6,

        /// <summary>
        /// Appraiser for Adm
        /// </summary>
        P = 1 << 7,

        /// <summary>
        /// Advertiser for Adm
        /// </summary>
        V = 1 << 8,

        /// <summary>
        /// Auctioneer for Adm
        /// </summary>
        U = 1 << 9,

        /// <summary>
        /// Sale Agent for Adm
        /// </summary>
        A = 1 << 10,

        /// <summary>
        /// Security Guard for Adm
        /// </summary>
        G = 1 << 11,

        /// <summary>
        /// Maritime Authority
        /// </summary>
        M = 1 << 12,

        /// <summary>
        /// Attendance Fee
        /// </summary>
        F = 1 << 13,

        /// <summary>
        /// Court Commission
        /// </summary>
        I = 1 << 14,

        /// <summary>
        /// Other Depositor
        /// </summary>
        T = 1 << 15
    }

    /// <summary>
    /// List of OutgoingCorrespondanceSentCopy types.
    /// </summary>
    [Serializable]
    public enum OutgoingCorrespondanceSentCopy
    {
        /// <summary>
        /// Outgoing Correspondance sent To Lawfirms
        /// </summary>
        T,

        /// <summary>
        /// Outgoing Correspondance sent CC Lawfirms
        /// </summary>
        C
    }

    /// <summary>
    /// List of OutOfOfficeStatus status
    /// </summary>
    [Serializable]
    public enum OutOfOfficeStatus
    {
        /// <summary>
        /// NULL.
        /// </summary>
        Null,
        /// <summary>
        /// Out of Office Hours requested, request Pending
        /// </summary>
        P,
        /// <summary>
        /// Out of Office Hours requested, request approved
        /// </summary>
        A,
        /// <summary>
        /// Out of Office Hours requested, request rejected
        /// </summary>
        R,
        /// <summary>
        /// No Out of Office Hours request (default)
        /// </summary>
        N,
        /// <summary>
        /// Yes Out of Office Hours request (default)
        /// </summary>
        Y
    }

    /// <summary>
    /// List of Yes and No.
    /// </summary>
    [Serializable]
    public enum OutstandingPaymentType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Payment for Debt & Cost".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Additional Deposit".
        /// </summary>
        A
    }

    /// <summary>
    /// List for ParentingPlan.
    /// </summary>
    [Serializable]
    public enum ParentingPlan
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Not filed" value.
        /// </summary>
        N,

        /// <summary>
        /// Represents "Agreed".
        /// </summary>
        A,

        /// <summary>
        /// Represents "Plaintiffs Proposal".
        /// </summary>
        P
    }

    /// <summary>
    /// List of WOE Order Enforced Types
    /// </summary>
    [Serializable]
    public enum PartyRepresentationType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represented
        /// </summary>
        RP,

        /// <summary>
        /// In-Person
        /// </summary>
        IP,
        /// <summary>
        /// Absent
        /// </summary>
        AB,
        /// <summary>
        /// Party Not Required
        /// </summary>
        PNR,
        /// <summary>
        /// Party With Represented
        /// </summary>
        PWR,
        /// <summary>
        /// Party On Behalf
        /// </summary>
        OBB
    }

    /// <summary>
    /// List of party represented by types.
    /// </summary>
    [Serializable]
    public enum PartyRepresentedBy
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "In Person or Self".
        /// </summary>
        S,

        /// <summary>
        /// Represents "Represented By Solicitor".
        /// </summary>
        R
    }


    public enum PartyType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        ///  Accused Person
        /// </summary>
        AC,

        /// <summary>
        ///  Applicant
        /// </summary>
        APL,

        /// <summary>
        ///  Appellant
        /// </summary>
        APP,

        /// <summary>
        ///  Borrower
        /// </summary>
        BOR,

        /// <summary>
        ///  Caveator
        /// </summary>
        CAVT,

        /// <summary>
        /// Claimant
        /// </summary>
        CLMT,

        /// <summary>
        /// Complainant
        /// </summary>
        CMPNT,

        /// <summary>
        ///  Contributor
        /// </summary>
        CNBT,

        /// <summary>
        ///  Citor
        /// </summary>
        CTOR,

        /// <summary>
        ///  Amicus Curiae
        /// </summary>
        CU,

        /// <summary>
        /// Defendent
        /// </summary>
        DF,

        /// <summary>
        ///  Defendant in Counterclaim
        /// </summary>
        DFIC,

        /// <summary>
        /// Defendant in Issue
        /// </summary>
        DFII,

        /// <summary>
        /// Donee
        /// </summary>
        DNE,

        /// <summary>
        /// Donar
        /// </summary>
        DNR,

        /// <summary>
        /// Deputy
        /// </summary>
        DPY,

        /// <summary>
        /// Creditor
        /// </summary>
        EC,

        /// <summary>
        /// Debtor
        /// </summary>
        ED,

        /// <summary>
        /// Employee
        /// </summary>
        EMP,

        /// <summary>
        /// Employer
        /// </summary>
        EMPR,

        /// <summary>
        ///  Garnishee
        /// </summary>
        GS,

        /// <summary>
        ///  Intervener
        /// </summary>
        ITVR,

        /// <summary>
        /// Lender
        /// </summary>
        LEN,

        /// <summary>
        /// LawFirm
        /// </summary>
        LFIRM,

        /// <summary>
        /// Natural Father
        /// </summary>
        NF,

        /// <summary>
        /// Natural Mother
        /// </summary>
        NM,

        /// <summary>
        /// Non-Party
        /// </summary>
        NPTY,

        /// <summary>
        /// Official Assignee
        /// </summary>
        OA,

        /// <summary>
        /// Person Cited
        /// </summary>
        PCIT,

        /// <summary>
        /// Plaintiff
        /// </summary>
        PLTF,

        /// <summary>
        ///  Plaintiff in Counterclaim
        /// </summary>
        PLTFCC,

        /// <summary>
        ///  Plaintiff in Issue
        /// </summary>
        PLTFII,

        /// <summary>
        /// Person Name
        /// </summary>
        PN,

        /// <summary>
        /// Public Prosecutor
        /// </summary>
        PP,

        /// <summary>
        /// Petitioner
        /// </summary>
        PT,

        /// <summary>
        /// Person to be committed
        /// </summary>
        PTC,

        /// <summary>
        /// Person warning
        /// </summary>
        PWAR,

        /// <summary>
        /// Respondent
        /// </summary>
        RES,

        /// <summary>
        ///  Successor Deputy
        /// </summary>
        SDPY,

        /// <summary>
        ///  Subsequence party in Counterclaim
        /// </summary>
        SPICC,

        /// <summary>
        ///  Subsequence party in Issue
        /// </summary>
        SPII,

        /// <summary>
        ///  Subsequent Party
        /// </summary>
        SUBPTY,

        /// <summary>
        ///  Co-Defendant
        /// </summary>
        SUC1,

        /// <summary>
        /// Surety
        /// </summary>
        SUTY,

        /// <summary>
        /// Transferred Lender
        /// </summary>
        TL,

        /// <summary>
        /// Third Party in Issue
        /// </summary>
        TPII,

        /// <summary>
        ///  Third Party
        /// </summary>
        TPTY,

        /// <summary>
        ///  Third Party in Counterclaim
        /// </summary>
        TPTYCC
    }

    /// <summary>
    /// List of Party update ind.
    /// </summary>
    [Serializable]
    public enum PartyUpdateInd
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Party is added".
        /// </summary>
        A,

        /// <summary>
        /// Represents "Party is updated".
        /// </summary>
        U,

        /// <summary>
        /// Represents "Party is neither added nor updated".
        /// </summary>
        N
    }

    /// <summary>
    /// List of Paying In type.
    /// </summary>
    [Serializable]
    public enum PayingInType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Cash".
        /// </summary>
        CH,

        /// <summary>
        /// Represents "Funds & Securities".
        /// </summary>
        FS
    }

    public enum PaymentChequeStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Unpresented
        /// </summary>
        U,

        /// <summary>
        /// Presented
        /// </summary>
        P,

        /// <summary>
        /// Cancelled
        /// </summary>
        C,

        /// <summary>
        /// Expired
        /// </summary>
        E,

        /// <summary>
        /// Dishonoured
        /// </summary>
        D,

        /// <summary>
        /// Unpresented Cheque for x days to be updated as Expired.
        /// </summary>
        EXCHEQ
    }

    /// <summary>
    /// List of Paying In Reason type.
    /// </summary>
    [Serializable]
    public enum PaymentInReasonType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Pursuant to Order of Court".
        /// </summary>
        POC,

        /// <summary>
        /// Represents "Security for Costs for Appeal/Application".
        /// </summary>
        SCA,

        /// <summary>
        /// Represents "Satisfy a Claim".
        /// </summary>
        SAC,

        /// <summary>
        /// Represents "Others".
        /// </summary>
        OTH,
    }

    public enum PaymentStatus
    {
        /// <summary>
        /// Un-Processed
        /// </summary>
        U,

        /// <summary>
        /// Processed
        /// </summary>
        P
    }

    public enum PaymentType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Miscellaneous
        /// </summary>
        MIS,

        /// <summary>
        /// Transport
        /// </summary>
        TPT,

        /// <summary>
        /// Disbursement
        /// </summary>
        DIS,

        /// <summary>
        /// Creditor
        /// </summary>
        ECR,

        /// <summary>
        /// Debtor
        /// </summary>
        EDR,

        /// <summary>
        /// Claimant
        /// </summary>
        CLM,

        /// <summary>
        /// Other
        /// </summary>
        OTH,

        /// <summary>
        /// Registrar Supreme Court
        /// </summary>
        RSC,

        /// <summary>
        /// Attendant Fee
        /// </summary>
        ATT,

        /// <summary>
        /// Fund Transfer
        /// </summary>
        FTR,

        /// <summary>
        /// Court Commission
        /// </summary>
        CCM,

        /// <summary>
        /// Transfer to Revenue
        /// </summary>
        TTR,

        /// <summary>
        /// Registrar Subordanate Court
        /// </summary>
        RSU //CR-ENFUAT-2013082202 - Mantis:0010099
    }

    public enum PaymentVoucherStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Pending
        /// </summary>
        P,

        /// <summary>
        /// Rejected
        /// </summary>
        R,

        /// <summary>
        /// Vetted
        /// </summary>
        V,

        /// <summary>
        /// Approved
        /// </summary>
        A,

        /// <summary>
        /// Cheque Processed
        /// </summary>
        C
    }

    public enum PaymentVoucherType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Ad hoc
        /// </summary>
        H,

        /// <summary>
        /// Final
        /// </summary>
        F,

        /// <summary>
        /// Admiralty
        /// </summary>
        A,
    }

    /// <summary>
    /// List of ProbateInfoType
    /// </summary>
    [Serializable]
    public enum ProbateInfoType
    {
        Null,
        /// <summary>
        /// Probate
        /// </summary>
        P,
        /// <summary>
        /// Citation
        /// </summary>
        C
    }

    public enum PropertyType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Aircraft
        /// </summary>
        A,

        /// <summary>
        /// Bunker
        /// </summary>
        B,

        /// <summary>
        /// Cargo
        /// </summary>
        C,

        /// <summary>
        /// Vessel
        /// </summary>
        V
    }

    public enum ReceiptAduitType
    {
        /// <summary>
        /// Edit
        /// </summary>
        E,

        /// <summary>
        /// Reprint
        /// </summary>
        R,

        /// <summary>
        /// Void
        /// </summary>
        V
    }

    public enum ReceiptStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Added
        /// </summary>
        A,

        /// <summary>
        /// Edited
        /// </summary>
        E,

        /// <summary>
        /// Reprinted
        /// </summary>
        R,

        /// <summary>
        /// Voided
        /// </summary>
        V,

        /// <summary>
        /// Dishonoured
        /// </summary>
        D,

        /// <summary>
        /// Void after generating the PV (in Pending and Rejected status)
        /// </summary>
        U,

        /// <summary>
        /// Dishonoured after generating the PV (in Pending and Rejected status)
        /// </summary>
        H
    }

    /// <summary>
    /// List of Work Item RecTransType
    /// </summary>
    [Serializable]
    public enum RecTransType
    {
        /// <summary>
        /// NULL.
        /// </summary>
        Null,
        /// <summary>
        /// Account Transfer
        /// </summary>
        ATR,
        /// <summary>
        /// Deposit
        /// </summary>
        DPT,
        /// <summary>
        /// Received from Auctioneer
        /// </summary>
        RAT,
        /// <summary>
        /// Received Payment for Debt & Cost
        /// </summary>
        RDC,
        /// <summary>
        /// Other Receivables
        /// </summary>
        ROT,
        /// <summary>
        /// Transfer from Revenue
        /// </summary>
        TFR,
        /// <summary>
        /// ADM - Accounting only
        /// </summary>
        AAC,
        /// <summary>
        /// Payment Of Invoice
        /// </summary>
        POI
    }

    /// <summary>
    /// List of RefundFeeType.
    /// </summary>
    [Serializable]
    public enum RefundFeeType
    {
        /// <summary>
        /// NULL.
        /// </summary>
        Null,

        /// <summary>
        /// EFiling Fee
        /// </summary>
        EFilingFee,

        /// <summary>
        /// Hearing Fee
        /// </summary>
        HearingFee
    }

    /// <summary>
    /// List of RefundOrWaiver Status
    /// </summary>
    [Serializable]
    public enum RefundOrWaiverStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Pending
        /// </summary>
        P,

        /// <summary>
        /// Approved
        /// </summary>
        A,

        /// <summary>
        /// Rejected
        /// </summary>
        R
    }

    /// <summary>
    /// List of Refund Or Waiver types.
    /// </summary>
    [Serializable]
    public enum RefundOrWaiverType
    {
        /// <summary>
        /// Represents "NULL" Value
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Partial" Value
        /// </summary>
        P,

        /// <summary>
        /// Represents "Full" Value
        /// </summary>
        F
    }

    // TODO: Update enum.
    /// <summary>
    /// List of RefundStatus.
    /// </summary>
    [Serializable]
    public enum RefundStatus
    {
        /// <summary>
        ///
        /// </summary>
        P,

        Y,

        A,

        N


    }

    /// <summary>
    /// List of RefundType.
    /// </summary>
    [Serializable]
    public enum RefundType
    {
        /// <summary>
        /// Represents "NULL" Value
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Partial" Value
        /// </summary>
        P,

        /// <summary>
        /// Represents "Full" Value
        /// </summary>
        F
    }

    public enum ReleaseType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Plaintiff
        /// </summary>
        P,

        /// <summary>
        /// Other
        /// </summary>
        O,
        /// <summary>
        /// Defendant
        /// </summary>
        D
    }

    /// <summary>
    /// List of ReprintType
    /// </summary>
    [Serializable]
    public enum ReprintType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Original.
        /// </summary>
        O,

        /// <summary>
        /// Duplicate.
        /// </summary>
        D
    }

    /// <summary>
    /// List of RefundType.
    /// </summary>
    [Serializable]
    public enum RequestType
    {
        /// <summary>
        /// Represents "TopUp" Value
        /// </summary>
        T,

        /// <summary>
        /// Represents "Refund" Value
        /// </summary>
        R
    }

    public enum SaleType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Civil / Criminal
        /// </summary>
        C,

        /// <summary>
        /// Admiralty
        /// </summary>
        A
    }

    /// <summary>
    /// List of Staus of Job.
    /// </summary>
    [Serializable]
    public enum ScheduleJobFiredStatus
    {
        /// <summary>
        ///Triggered.
        /// </summary>
        T,
        /// <summary>
        /// In Progress
        /// </summary>
        I,
        /// <summary>
        /// Success
        /// </summary>
        S,
        /// <summary>
        /// Failed
        /// </summary>
        F
    }

    /// <summary>
    /// List of ScheduleJobType.
    /// </summary>
    [Serializable]
    public enum ScheduleJobType
    {
        /// <summary>
        /// Minute
        /// </summary>
        MM,
        /// <summary>
        /// Hour
        /// </summary>
        H,
        /// <summary>
        /// Day
        /// </summary>
        D,
        /// <summary>
        /// Week
        /// </summary>
        W,
        /// <summary>
        /// Month
        /// </summary>
        M,
        ///<summary>
        ///Year
        ///</summary>
        YY
    }

    /// <summary>
    /// List of SchedulerProcessStatus.
    /// </summary>
    [Serializable]
    public enum SchedulerProcessStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Pending".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Completed".
        /// </summary>
        C,
        /// <summary>
        /// Represents "Manual".
        /// </summary>
        M
    }

    /// <summary>
    /// List of Service Status.
    /// </summary>
    [Serializable]
    public enum ServiceStatus
    {
        /// <summary>
        /// Represents "Pending".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Completed".
        /// </summary>
        C
    }

    /// <summary>
    /// List of SetDownPursuantTo types.
    /// </summary>
    [Serializable]
    public enum SetDownPursuantTo
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Order Of Court" type.
        /// </summary>
        O,

        /// <summary>
        /// Represents "Order 25 r 8" type.
        /// </summary>
        R
    }

    /// <summary>
    /// List of Setting Down status
    /// </summary>
    [Serializable]
    public enum SettingDownStatus
    {
        /// <summary>
        /// NULL.
        /// </summary>
        Null,
        /// <summary>
        /// Contested
        /// </summary>
        CD,
        /// <summary>
        /// Uncontested in Chamber
        /// </summary>
        UDIC,
        /// <summary>
        /// Uncontested In Open Court
        /// </summary>
        UDOC
    }

    /// <summary>
    /// List of Yes and No.
    /// </summary>
    [Serializable]
    public enum SettlementOutcomeType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Payment".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Direction".
        /// </summary>
        D,

        /// <summary>
        /// Represents "Default Sentence".
        /// </summary>
        S,

        /// <summary>
        /// Represents "Cause Shown".
        /// </summary>
        C,

        /// <summary>
        /// Represents "Other".
        /// </summary>
        O
    }

    /// <summary>
    /// List of SortDirection.
    /// </summary>
    [Serializable]
    public enum SortingDirection
    {
        /// <summary>
        /// Represents No Sort Direction.
        /// </summary>
        Null,

        /// <summary>
        /// Asscending
        /// </summary>
        ASC,

        /// <summary>
        /// Decending
        /// </summary>
        DESC
    }

    /// <summary>
    /// List for Admiralty Writ Types.
    /// </summary>
    [Serializable]
    public enum StatementOrEndorsementInWrit
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Statement of Claim" value.
        /// </summary>
        S,

        /// <summary>
        /// Represents "Generally Endorsement Writ".
        /// </summary>
        E
    }

    /// <summary>
    /// List for StatusCode.
    /// </summary>
    [Serializable]
    public enum StatusCode
    {

        /// <summary>
        /// Active
        /// </summary>
        AC,

        /// <summary>
        /// Approved
        /// </summary>
        BA,

        /// <summary>
        /// Pending
        /// </summary>
        BP,

        /// <summary>
        /// Rejected
        /// </summary>
        BR,

        /// <summary>
        /// De-register
        /// </summary>
        DR,

        /// <summary>
        /// Inactive
        /// </summary>
        IA,
        /// <summary>
        /// Approved
        /// </summary>
        LA,
        /// <summary>
        /// Reject
        /// </summary>
        LR,
        /// <summary>
        /// Registered
        /// </summary>
        RG,
        /// <summary>
        /// Request
        /// </summary>
        RQ,
        /// <summary>
        /// Re-register
        /// </summary>
        RR,
        /// <summary>
        /// De-Activated
        /// </summary>
        SP
    }

    /// <summary>
    /// List of different SubcaseType.
    /// </summary>
    [Serializable]
    public enum SubcaseType
    {
        /// <summary>
        /// Default will be NONE
        /// </summary>
        NONE,

        /// <summary>
        /// Assesment of Damages
        /// </summary>
        AD,

        /// <summary>
        /// Family Counselling inherited from Divorce
        /// </summary>
        CAPSS,

        /// <summary>
        /// Writ of Delivery
        /// </summary>
        DLY,

        /// <summary>
        /// Deed of Rectification
        /// </summary>
        DN,

        /// <summary>
        /// Deed of Revocation
        /// </summary>
        DR,

        /// <summary>
        /// Payment In (High Court)
        /// </summary>
        DRI,

        /// <summary>
        /// Payment In (Subordinate Courts)
        /// </summary>
        DRIS,

        /// <summary>
        /// Payment Out
        /// </summary>
        DRO,

        /// <summary>
        /// Payment Out
        /// </summary>
        DROS,

        /// <summary>
        /// Deed of Substitution
        /// </summary>
        DS,

        /// <summary>
        /// Enforcement - Others
        /// </summary>
        ENF,

        /// <summary>
        /// FRC inherited from Divorce
        /// </summary>
        FRCS,

        /// <summary>
        /// Request for Further Hearing of Originating Summons
        /// </summary>
        NFH,

        /// <summary>
        /// Practising Certificate
        /// </summary>
        PC,

        /// <summary>
        /// Registrar's Appeal 
        /// </summary>
        RA,

        /// <summary>
        /// Registrar's Appeal 
        /// </summary>
        RAS,

        /// <summary>
        /// Show Cause (Criminal)
        /// </summary>
        SCH,

        /// <summary>
        /// Deed of Supplementary
        /// </summary>
        SD,

        /// <summary>
        /// Service of Document
        /// </summary>
        SOD,

        /// <summary>
        /// Service of Document
        /// </summary>
        SODS,

        /// <summary>
        /// Summons
        /// </summary>
        SUM,

        /// <summary>
        /// Notice of Appointment for Taking of Accounts / Inquiries
        /// </summary>
        TAI,

        /// <summary>
        /// Warrant of Arrest
        /// </summary>
        WA,

        /// <summary>
        /// Warrant Of Arrest (Criminal)
        /// </summary>
        WAC,

        /// <summary>
        /// Writ of Distress
        /// </summary>
        WD,

        /// <summary>
        /// Warrant for Committal
        /// </summary>
        WFC,

        /// <summary>
        /// Writ of Possession
        /// </summary>
        WP,

        /// <summary>
        /// Writ of Seizure and Sale
        /// </summary>
        WSS
    }

    /// <summary>
    /// List of SubmissionStage types.
    /// </summary>
    [Serializable]
    public enum SubmissionStage
    {
        /// <summary>
        /// Represents "Submission Draft" type.
        /// </summary>
        DRAFT,

        /// <summary>
        /// Represents "Efiling Submission Process Complete" type.
        /// </summary>
        EFSC,

        /// <summary>
        /// Represents "FrontEnd Filing Broker Sending Process Complete" type.
        /// </summary>
        FEFBSC,

        /// <summary>
        /// Represents "BackEnd Filing Broker Receiving Process Complete" type.
        /// </summary>
        BEFBRC,

        /// <summary>
        /// Represents "Workflow Receiving Process Complete" type.
        /// </summary>
        WFRPC,

        /// <summary>
        /// Represents "Task list Process Complete" type.
        /// </summary>
        TLPC,

        /// <summary>
        /// Represents "Workflow Sending Process Complete" type.
        /// </summary>
        WFSPC,

        /// <summary>
        /// Represents "BackEnd Filing Broker Sending Process Complete" type.
        /// </summary>
        BEFBSC,

        /// <summary>
        /// Represents "FrontEnd Filing Broker Receiving Process Complete" type.
        /// </summary>
        FEFBRC
    }

    /// <summary>
    /// List of SubpoenaPurpose.
    /// </summary>
    [Serializable]
    public enum SubpoenaPurpose
    {
        /// <summary>
        /// Represens "Null" Value
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Attendance of witness to testify" Value
        /// </summary>
        WTT,

        /// <summary>
        /// Represents "Documents specified hereunder" Value
        /// </summary>
        DSH,

        /// <summary>
        /// Represents "Testify and to produce the following documents" Value
        /// </summary>
        TPFD
    }

    /// <summary>
    /// List of different SubsequentFilingType
    /// </summary>
    public enum SubsequentFilingType
    {
        /// <summary>
        /// Default will be NONE
        /// </summary>
        NONE,

        /// <summary>
        /// Affidavits
        /// </summary>
        Affidavits,

        /// <summary>
        /// MakeARequest
        /// </summary>
        MakeARequest = 7,

        /// <summary>
        /// Basket3NOCOS
        /// </summary>
        Basket3NOCOS = 16,

        /// <summary>
        ///
        /// </summary>
        MakeARequestHearing = 19,
        /// <summary>
        ///
        /// </summary>
        MakeARequestFees = 20,
        /// <summary>
        ///
        /// </summary>
        MakeARequestSubpoena = 21,
        /// <summary>
        ///
        /// </summary>
        MakeARequestFileInspection = 22,
        /// <summary>
        ///
        /// </summary>
        PartyAmendment = 23,
        /// <summary>
        ///
        /// </summary>
        Basket1 = 24,
        /// <summary>
        ///
        /// </summary>
        Basket2 = 25,
        /// <summary>
        ///
        /// </summary>
        Payment = 26
    }

    /// <summary>
    /// List of System Indicators.
    /// </summary>
    [Serializable]
    public enum SystemInd
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "IELS" (default).
        /// When a new case is created in IELS system.
        /// </summary>
        I,

        /// <summary>
        /// Represents "EFS".
        /// If the case is previously migrated from EFS system.
        /// </summary>
        E,

        /// <summary>
        /// Represents "Civil".
        /// If the case is previously migrated from Civil system.
        /// </summary>
        C,

        /// <summary>
        /// Represents "Non Electronic case".
        /// If the previous case is re-created in IELS system.
        /// </summary>
        N
    }

    /// <summary>
    /// List of TaskList Message Types
    /// </summary>
    [Serializable]
    public enum TasklistMessageType
    {
        ///
        /// Represents "Null"
        ///
        Null,

        /// <summary>
        /// Auto Processing
        /// </summary>
        AP,
        /// <summary>
        /// Checklist - Front End Filing
        /// </summary>
        C,

        /// <summary>
        /// Checklist Pending Processing
        /// </summary>
        CP,

        /// <summary>
        /// Caveat Workitem
        /// </summary>
        CW,

        /// <summary>
        /// File Inspection – Case Officer
        /// </summary>
        FI,

        /// <summary>
        /// Hearing Workitem
        /// </summary>
        HW,

        /// <summary>
        /// Inbox/Front End Filing
        /// </summary>
        I,

        /// <summary>
        /// Indexing Draft
        /// </summary>
        ID,

        /// <summary>
        /// Minute Sheet Draft
        /// </summary>
        MD,

        /// <summary>
        /// Notification
        /// </summary>
        N,

        /// <summary>
        /// Outbox (Undo)
        /// </summary>
        O,

        /// <summary>
        /// Outgoing Correspondence
        /// </summary>
        OC,

        /// <summary>
        /// Outgoing Correspondence Draft
        /// </summary>
        OD,

        /// <summary>
        /// Pack n Go
        /// </summary>
        PG,

        /// <summary>
        /// Reminder
        /// </summary>
        RM,

        /// <summary>
        /// Sent
        /// </summary>
        S,

        /// <summary>
        /// Party/Case Status Update Workitem
        /// </summary>
        SW,

        /// <summary>
        /// Workitem Draft
        /// </summary>
        WD,

        /// <summary>
        /// Workitem (External)
        /// </summary>
        WE,

        /// <summary>
        /// Workitem (Internal)
        /// </summary>
        WI,

        /// <summary>
        /// Workitem (Internal)
        /// </summary>
        MI,

        /// <summary>
        /// Notification Inbox/Common Workitem (Internal)
        /// </summary>
        IN,

        /// <summary>
        /// InProgress (Undo)
        /// </summary>
        IP
    }

    /// <summary>
    /// List of TaskList status.
    /// </summary>
    [Serializable]
    public enum TaskListStatus
    {
        /// <summary>
        /// Represents "Null".
        /// </summary>
        Null,
        /// <summary>
        /// Represents "Accepted".
        /// </summary>
        A,

        /// <summary>
        /// Represents "Pending".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Rejected".
        /// </summary>
        R,

        /// <summary>
        /// Represents "". To check with Rajendra what is this
        /// </summary>
        C,

        /// <summary>
        /// Represents "Draft".
        /// </summary>
        D,

        /// <summary>
        /// Represents "Deleted".
        /// </summary>
        DL
    }

    /// <summary>
    /// List of TaskListType Code
    /// </summary>
    [Serializable]
    public enum TaskListType
    {
        /// <summary>
        /// AR Routing
        /// </summary>
        ARROUTE,
        /// <summary>
        /// Incoming Fax (BE)
        /// </summary>
        BEINFAX,
        /// <summary>
        /// DTS Recordings
        /// </summary>
        CADTSR,
        /// <summary>
        /// CA Report Download
        /// </summary>
        CARPT,
        /// <summary>
        /// Duty Registrar's Direction
        /// </summary>
        DRD,
        /// <summary>
        /// Fix Hearing for Appeals
        /// </summary>
        FHFA,
        /// <summary>
        /// Instructions to Registry
        /// </summary>
        MSHTIN,
        /// <summary>
        /// Notice Of Appeal
        /// </summary>
        NOA,
        /// <summary>
        /// Operational Report
        /// </summary>
        OPR,
        /// <summary>
        /// Vacate Case Hearings
        /// </summary>
        VCHRG,
        /// <summary>
        /// Reschedule PTC Hearing
        /// </summary>
        RPTC,
        /// <summary>
        /// Schedule an Expedited Writ Conference
        /// </summary>
        SEWC
    }

    /// <summary>
    /// List of TaskRoutingType
    /// </summary>
    [Serializable]
    public enum TaskRoutingType
    {
        /// <summary>
        /// Represents "Round Robin" value
        /// </summary>
        R,

        /// <summary>
        /// Represents "Common Pool" value
        /// </summary>
        C,

        /// <summary>
        /// Represents "Round Robin Sticky" value
        /// </summary>
        S
    }

    public enum TeamManagementProceedingType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Civil
        /// </summary>
        CIV,

        /// <summary>
        /// Criminal
        /// </summary>
        CRM
    }

    /// <summary>
    /// List of TimeForGDCT types.
    /// </summary>
    [Serializable]
    public enum TimeForGDCT
    {
        /// <summary>
        /// The matter is not appealable.
        /// </summary>
        NA,

        /// <summary>
        /// Leave to appeal is required.
        /// </summary>
        AR,

        /// <summary>
        /// - Leave to appeal is not required.
        /// </summary>
        NRC2,

        /// <summary>
        /// - Leave to appeal is not required. GD is required. GD/CT will be forwarded in 4 weeks
        /// </summary>
        NRC4,

        /// <summary>
        /// - No GD is required, CT will be forwarded within 2 weeks
        /// </summary>
        GDRC2,

        /// <summary>
        /// - GD is required. CT/GD will be forwarded in 4 weeks
        /// </summary>
        GDRC4,

        /// <summary>
        /// - NE  will be forwarded in 4 weeks
        /// </summary>
        GDCTNE4W,

        /// <summary>
        /// - GD/CT  will be forwarded in 8 weeks (normal list)
        /// </summary>
        GDCT8WNL,

        /// <summary>
        /// - GD/CT will be forwarded in 8 weeks (special list).
        /// </summary>
        GDCT8WSL,

        /// <summary>
        /// - GD/CT will be forwarded in 12 weeks (Case heard more than 1 day or with cross examination of witnesses)
        /// </summary>
        GDCT12W
    }

    /// <summary>
    /// List of TimeTakenForHearing types.
    /// </summary>
    [Serializable]
    public enum TimeTakenForHearing
    {
        /// <summary>
        /// Less than one day
        /// </summary>
        L,

        /// <summary>
        /// More than one day
        /// </summary>
        M
    }

    [Serializable]
    public enum TransferStateFundStatus
    {
        /// <summary>
        /// Represents "Draft" mode which means the fund are waiting for approval for tranfer.
        /// </summary>
        Draft,
        /// <summary>
        /// Represents "Final" mode which means the fund are transfered.
        /// </summary>
        Final
    }

    /// <summary>
    /// List of Transfer Type Indicators.
    /// </summary>
    [Serializable]
    public enum TransferTypeInd
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Original Case" (default).
        /// When a new case is created in IELS system.
        /// </summary>
        O,

        /// <summary>
        /// Represents "Transferred Case".
        /// If the case is transferred to another court.
        /// </summary>
        T,

        /// <summary>
        /// Represents "Incoming Case".
        /// If the case is received from another court.
        /// </summary>
        I
    }

    /// <summary>
    /// List for Type Of Arrest.
    /// </summary>
    [Serializable]
    public enum TypeOfArrest
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Cargo".
        /// </summary>
        C,

        /// <summary>
        /// Represents "Vessel ".
        /// </summary>
        V,

        /// <summary>
        /// Represents "Cargo and Vessel".
        /// </summary>
        CV,

        /// <summary>
        /// Represents "Others ".
        /// </summary>
        O
    }

    /// <summary>
    /// List for TypeOfJurisdiction.
    /// </summary>
    [Serializable]
    public enum TypeOfJurisdiction
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Habitual".
        /// </summary>
        H,

        /// <summary>
        /// Represents "Domicile".
        /// </summary>
        D,
        /// <summary>
        /// Represents "Both".
        /// </summary>
        B
    }

    /// <summary>
    /// List for Unliquidated Claim Types.
    /// </summary>
    [Serializable]
    public enum UnliquidatedClaimType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Damages to be assessed" value.
        /// </summary>
        D,

        /// <summary>
        /// Represents "Others".
        /// </summary>
        O
    }

    //TODO: Need to Check with Swaroop
    [Serializable]
    public enum VerStatus
    {
        Null,
        A,
        C
    }

    /// <summary>
    /// List of VesselId Type.
    /// </summary>
    [Serializable]
    public enum VesselIdType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "IMO" type.
        /// </summary>
        I,

        /// <summary>
        /// Represents "Registration Number" type.
        /// </summary>
        R,

        /// <summary>
        /// Represents "Both" type.
        /// </summary>
        B
    }

    /// <summary>
    /// List of ViewInModule.
    /// </summary>
    [Serializable]
    public enum ViewInModule
    {
        /// <summary>
        /// Represents Eform
        /// </summary>
        E,
        /// <summary>
        /// Represents Case File’s Solicitor Tab
        /// </summary>
        S,
        /// <summary>
        /// Represents Both Eform and Solicitor Tab
        /// </summary>
        B
    }

    /// <summary>
    /// List of VoidReason.
    /// </summary>
    [Serializable]
    public enum VoidReason
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Payment entered in error.
        /// </summary>
        P,

        /// <summary>
        /// Others.
        /// </summary>
        O
    }

    /// <summary>
    /// List of WaiverInd.
    /// </summary>
    [Serializable]
    public enum WaiverInd
    {
        /// <summary>
        /// Not applicable
        /// </summary>
        Null,

        /// <summary>
        /// Draft
        /// </summary>
        D,

        /// <summary>
        /// Pending
        /// </summary>
        P,

        /// <summary>
        /// Approved
        /// </summary>
        A,

        /// <summary>
        /// Rejected
        /// </summary>
        R,

        /// <summary>
        /// Others
        /// </summary>
        O
    }

    /// <summary>
    /// List of waiver status.
    /// </summary>
    [Serializable]
    public enum WaiverStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Not Applicable".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Pending".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Allowed".
        /// </summary>
        A,

        /// <summary>
        /// Represents "Refused".
        /// </summary>
        R,

        /// <summary>
        /// Represents "Others".
        /// </summary>
        O
    }

    /// <summary>
    /// List of Waiver type.
    /// </summary>
    [Serializable]
    public enum WaiverType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "None".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Partial".
        /// </summary>
        P,

        /// <summary>
        /// Represents "Full".
        /// </summary>
        F
    }

    /// <summary>
    /// List of winding types.
    /// </summary>
    [Serializable]
    public enum WindingType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Company" winding type.
        /// </summary>
        COM,

        /// <summary>
        /// Represents "Limited Liability Partnership" winding type.
        /// </summary>
        LLP
    }

    /// <summary>
    /// List of Witness Type code.
    /// </summary>
    [Serializable]
    public enum WitnessType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Local Factual
        /// </summary>
        LF,

        /// <summary>
        /// Local Expert
        /// </summary>
        LE,

        /// <summary>
        /// Foreign Factual
        /// </summary>
        FF,

        /// <summary>
        /// Foreign Expert
        /// </summary>
        FE
    }

    /// <summary>
    /// List of WOE Employee act order type
    /// </summary>
    [Serializable]
    public enum WOEEmpActOrderType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Prohibitory Order
        /// </summary>
        P,

        /// <summary>
        /// Others
        /// </summary>
        O
    }

    public enum WOEInfoClaimStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        ///  Admitting
        /// </summary>
        A,

        /// <summary>
        /// Disputing
        /// </summary>
        D,
    }

    public enum WOEInfoClaimType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Items
        /// </summary>
        I,

        /// <summary>
        /// Proceeds
        /// </summary>
        P
    }

    public enum WOEType
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Examination of Judgment Debtor Application
        /// </summary>
        EJD,

        /// <summary>
        /// Garnishee Proceedings
        /// </summary>
        GON,

        /// <summary>
        /// Interpleader Summons
        /// </summary>
        IS,

        /// <summary>
        /// Judgment Debtor Summons
        /// </summary>
        JDS,

        /// <summary>
        /// Judgment Notice
        /// </summary>
        JN,

        /// <summary>
        /// Notice by Claimant of Property taken in Execution
        /// </summary>
        NCPE,

        /// <summary>
        /// Notice by Execution Creditor of Property taken in Execution
        /// </summary>
        NECPE,

        /// <summary>
        /// Warrant  for Committal
        /// </summary>
        WFC,

        /// <summary>
        /// Writ of Delivery
        /// </summary>
        DLY,

        /// <summary>
        /// Writ of Distress
        /// </summary>
        WD,

        /// <summary>
        /// Writ of Possession
        /// </summary>
        WP,

        /// <summary>
        /// Writ of Possession under Order 81
        /// </summary>
        WP81,

        /// <summary>
        /// Writ of Seizure and Sale
        /// </summary>
        WSS,

        /// <summary>
        /// Writ of Seizure and Sale including Securities
        /// </summary>
        WSSS,

        /// <summary>
        /// Writ of Seizure & Sale in Respect of Immovable Property
        /// </summary>
        WSSI,

        /// <summary>
        /// Others
        /// </summary>
        ENF
    }

    /// <summary>
    /// List of Workflow Incoming/Outgoing Queue status
    /// </summary>
    [Serializable]
    public enum WorkflowQueueStatus
    {
        /// <summary>
        /// New
        /// </summary>
        N,
        /// <summary>
        /// In Progress
        /// </summary>
        I,
        /// <summary>
        /// Success
        /// </summary>
        S,
        /// <summary>
        /// Failed
        /// </summary>
        F
    }

    /// <summary>
    /// List of WorkItemDetails indicator status
    /// </summary>
    [Serializable]
    public enum WorkItemDetailsIndType
    {
        /// <summary>
        /// NULL.
        /// </summary>
        Null,
        /// <summary>
        /// Internal
        /// </summary>
        I,
        /// <summary>
        /// External
        /// </summary>
        E
    }

    /// <summary>
    /// List of Work Item Recipient status
    /// </summary>
    [Serializable]
    public enum WorkItemRecipientStatus
    {
        /// <summary>
        /// NULL.
        /// </summary>
        Null,
        /// <summary>
        /// Sent
        /// </summary>
        S,
        /// <summary>
        /// Received
        /// </summary>
        R
    }

    /// <summary>
    /// List of Yes and No.
    /// </summary>
    [Serializable]
    public enum YesNo
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "No".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Yes".
        /// </summary>
        Y
    }

    /// <summary>
    /// Forum Type(s).
    /// </summary>
    [Serializable]
    public enum ForumType
    {
        /// <summary>
        /// Default will be NONE.
        /// </summary>
        NONE,

        /// <summary>
        /// Court of Appeal.
        /// </summary>
        CA,

        /// <summary>
        /// District Court.
        /// </summary>
        DC,

        /// <summary>
        /// District Court(Family).
        /// </summary>
        DCF,

        /// <summary>
        /// High Court.
        /// </summary>
        HC,

        /// <summary>
        /// Magistrate Court.
        /// </summary>
        MC,

        /// <summary>
        /// Tribunal.
        /// </summary>
        TRI,

        /// <summary>
        /// Court of 3 Judges
        /// </summary>
        C3J,
        /// <summary>
        /// Family Courts
        /// </summary>
        FC,
        /// <summary>
        /// Family Division of the High Court
        /// </summary>
        HCF,
        /// <summary>
        ///Singapore International Court committee
        ///</summary>
        SIC
    }

    /// <summary>
    /// PartyFlippingCategory
    /// </summary>
    [Serializable]
    public enum PartyFlippingCategory
    {
        /// <summary>
        /// Represents "Null"
        /// </summary>
        Null,
        /// <summary>
        /// Represents "Not Applicable"
        /// </summary>
        NA,
        /// <summary>
        /// Represents "Claiming Party"
        /// </summary>
        CP,
        /// <summary>
        /// Represents "Opposition Party"
        /// </summary>
        OP
    }

    /// <summary>
    /// PurposeOfOrder
    /// </summary>
    [Serializable]
    public enum PurposeOfOrder
    {
        /// <summary>
        /// Represents "Null"
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Amendment"
        /// </summary>
        A
    }

    [Serializable]
    public enum RoleCode
    {
        /// <summary>
        /// Represents "Null"
        /// </summary>
        Null,
        /// <summary>
        /// Represent "Applicant"
        /// </summary>
        A,
        /// <summary>
        /// Represents "Respondent"
        /// </summary>
        R,
        /// <summary>
        /// Represents "NONE"
        /// </summary>
        N

    }

    [Serializable]
    public enum CAReportType
    {
        /// <summary>
        /// Represents "DocumentA"
        /// </summary>
        DocumentA,
        /// <summary>
        /// Represents "DocumentB"
        /// </summary>
        DocumentB,
        /// <summary>
        /// Represents "DocumentC"
        /// </summary>
        DocumentC,
        /// <summary>
        /// Represents "DocumentD"
        /// </summary>
        DocumentD
    }

    [Serializable]
    public enum YesNoMandatory
    {
        /// <summary>
        /// Represents "No"
        /// </summary>
        N,
        /// <summary>
        /// Represent "Yes"
        /// </summary>
        Y
    }

    [Serializable]
    public enum DivorceFilingFor
    {
        /// <summary>
        /// Represents "Null"
        /// </summary>
        Null,
        /// <summary>
        /// Represents "Self"
        /// </summary>
        S,
        /// <summary>
        /// Represents "Behalf Of"
        /// </summary>
        B
    }

    [Serializable]
    public enum HRGSlotFrequencyCode
    {
        /// <summary>
        /// Represents "Weekly"
        /// </summary>

        Weekly,
        /// <summary>
        /// Represents "Fortnight"
        /// </summary>
        /// 
        Fortnightly,
        /// <summary>
        /// Represents "Monthly"
        /// </summary>
        /// 
        Monthly,
        /// <summary>
        /// Represents "Yearly"
        /// </summary>
        Yearly
    }



    [Serializable]
    public enum CAReportFileStatus
    {
        /// <summary>
        /// No Action
        /// </summary>
        NA,
        /// <summary>
        /// Success
        /// </summary>
        S,
        /// <summary>
        /// Failed
        /// </summary>
        F
    }

    [Serializable]
    public enum DefaultVenueType
    {
        /// <summary>
        /// Chamber
        /// </summary>
        C,
        /// <summary>
        /// Open Court
        /// </summary>
        O
    }

    [Serializable]
    public enum JudgeAssignStatus
    {
        /// <summary>
        /// Approved
        /// </summary>
        A,
        /// <summary>
        /// Pending
        /// </summary>
        P
    }

    [Serializable]
    public enum ReqDecision
    {
        /// <summary>
        /// Null
        /// </summary>
        Null,
        /// <summary>
        /// Accepted
        /// </summary>
        A,
        /// <summary>
        /// Rejected
        /// </summary>
        R,
        /// <summary>
        /// Others
        /// </summary>
        O
    }


    [Serializable]
    public enum OGCProcessType
    {
        /// <summary>
        /// Null
        /// </summary>
        Null,
        /// <summary>
        /// Auto Processing
        /// </summary>
        A,
        /// <summary>
        /// Manual Processing
        /// </summary>
        M
    }

    [Serializable]
    public enum AdmChargeType
    {
        /// <summary>
        /// Null
        /// </summary>
        Null,
        /// <summary>
        /// Guard Charges
        /// </summary>
        GURDCH,
        /// <summary>
        /// PSA Port Dues
        /// </summary>
        PSACH,
        /// <summary>
        /// Delivery Fees
        /// </summary>
        DELFEE,
        /// <summary>
        /// Notary Fees
        /// </summary>
        NOTFEE,
        /// <summary>
        /// Crew Wages
        /// </summary>
        CREWAG,
        /// <summary>
        /// Banking Transport
        /// </summary>
        BNKTPT,
        /// <summary>
        /// Gazette Notice Charges
        /// </summary>
        GAZNCH,
        /// <summary>
        /// Berth Charges
        /// </summary>
        BERTCH,
        /// <summary>
        /// Other Expenses
        /// </summary>
        OTHEX,
        /// <summary>
        /// Sheriff's Sale Commission (Excl. Bunker Commission)
        /// </summary>
        SHSCOM
    }

    [Serializable]
    public enum RejectionFeeType
    {
        Null,

        NFWBD,
        FFFDD,
        AFPDD,
        AFOWD

    }
    [Serializable]
    public enum TransferActionType
    {
        /// <summary>
        /// Represents Transfer
        /// </summary>
        T,
        /// <summary>
        /// Represents Update
        /// </summary>
        U
    }

    [Serializable]
    public enum FilingbrokerQueueStatus
    {
        /// <summary>
        /// Represents "New"
        /// </summary>
        N,
        /// <summary>
        /// Represents "Error"
        /// </summary>
        E,
        /// <summary>
        /// Represents "Failed"
        /// </summary>
        F,
        /// <summary>
        /// Represents "InProgress"
        /// </summary>
        I,
        /// <summary>
        /// Represents "Queued"
        /// </summary>
        Q,
        /// <summary>
        /// Represents "Success"
        /// </summary>
        S
    }

    [Serializable]

    public enum SubCaseRequestInd
    {
        /// <summary>
        /// Represents "Null"
        /// </summary>
        Null,
        /// <summary>
        /// Represents "N.A"
        /// </summary>

        N,
        /// <summary>
        /// Represents "FRC"
        /// </summary>
        F,
        /// <summary>
        /// Represents "JointConference"
        /// </summary>
        J,
        /// <summary>
        /// Represents "Counselling"
        /// </summary>
        C
    }

    [Serializable]
    public enum IsConfidential
    {
        /// <summary>
        /// NOt confidential
        /// </summary>
        N,
        /// <summary>
        /// MinuteSheet Confidential
        /// </summary>
        M,
        /// <summary>
        /// IsCOnfidential
        /// </summary>
        Y,
        /// <summary>
        /// ReportsConfidential
        /// </summary>
        R
    }

    [Serializable]
    public enum MaintainChequeType
    {
        /// <summary>
        /// Maintain Cheque Main
        /// </summary>
        M,
        /// <summary>
        /// Maintain Cheque History
        /// </summary>
        H,
        /// <summary>
        /// Maintain Cheque State Fund
        /// </summary>
        S
    }

    [Serializable]
    public enum HCLocationGroup
    {
        /// <summary>
        /// High Court
        /// </summary>
        ALL,
        HC,
        CA,
        C3J,
        SIC
    }

    [Serializable]
    public enum SCLocationGroup
    {
        /// <summary>
        /// Civil Court
        /// </summary>
        CIV,
        /// <summary>
        /// Family Court
        /// </summary>
        FAM
    }

    [Serializable]
    public enum LocationGroup
    {
        /// <summary>
        /// High Court
        /// </summary>
        HC,
        /// <summary>
        /// Civil Court
        /// </summary>
        CIV,
        /// <summary>
        /// Family Court
        /// </summary>
        FAM
    }

    [Serializable]
    public enum CPDRequirements
    {
        /// <summary>
        /// Represents "Null"
        /// </summary>
        Null,
        /// <summary>
        /// PC Info eform when user selects option-A
        /// </summary>
        A,
        /// <summary>
        /// PC Info eform when user selects option-B
        /// </summary>
        B,
        /// <summary>
        /// PC Info eform when user selects option-C
        /// </summary>
        C
    }

    [Serializable]

    public enum VoteInfoValue
    {

        /// <summary>
        /// Represents "Null"
        /// </summary>
        Null,
        /// <summary>
        /// Represents "Voted"
        /// </summary>
        VT,
        /// <summary>
        /// Represents "Not Voted"
        /// </summary>
        NV
    }

    [Serializable]
    public enum PaymentMode
    {
        /// <summary>
        /// Represents "Null"
        /// </summary>
        Null,
        /// <summary>
        /// Represents GIRO
        /// </summary>
        G,
        /// <summary>
        /// Represents Ledget
        /// </summary>
        L
    }

    /// <summary>
    /// List of InterfaceStatus to Outgoing Correspondence Fee.
    /// </summary>
    [Serializable]
    public enum InterfaceStatus
    {
        /// <summary>
        /// Represents "NULL" value.
        /// </summary>
        Null,

        /// <summary>
        /// Represents "Is Interface = No".
        /// </summary>
        N,

        /// <summary>
        /// Represents "Is Interface = Yes".
        /// </summary>
        Y,

        /// <summary>
        /// Represents "Is Interface = Print".
        /// </summary>
        P
    }

    #endregion Enumerations
}
