namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class ProbateInfoEntity : AbstractSubmissionGroup
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="WOSInfoEntity"/> class.</summary> 
        public ProbateInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public DateTime? ApplicantAppointedDate
        {
            get;
            set;
        }

        public ApplicantType ApplicantType
        {
            get;
            set;
        }

        public YesNo ApplicationWithin6Months
        {
            get;
            set;
        }

        public String CaseNo
        {
            get;
            set;
        }

        public YesNo CaveatInd
        {
            get;
            set;
        }

        public YesNo DeceasedResided
        {
            get;
            set;
        }

        public YesNo DuefromDeceased
        {
            get;
            set;
        }

        public YesNo EstateValue3M
        {
            get;
            set;
        }

        public YesNo ExecutorDied
        {
            get;
            set;
        }

        public YesNo ExecutorRenounced
        {
            get;
            set;
        }

        public YesNo FirstCertification
        {
            get;
            set;
        }

        public String ForeignCourtAddr1
        {
            get;
            set;
        }

        public String ForeignCourtAddr2
        {
            get;
            set;
        }

        public String ForeignCourtAddr3
        {
            get;
            set;
        }

        public String ForeignCourtAddr4
        {
            get;
            set;
        }

        public String ForeignGrantCourtName
        {
            get;
            set;
        }

        public String ForeignPBDescription
        {
            get;
            set;
        }

        public Int32? ForeignPBOption
        {
            get;
            set;
        }

        public DateTime? GrantDate
        {
            get;
            set;
        }

        public YesNo HasCodicil
        {
            get;
            set;
        }

        public YesNo HasOtherApplicant
        {
            get;
            set;
        }

        public YesNo IsApplyingLAAnnexed
        {
            get;
            set;
        }

        public YesNo IsApplyingLAInfant
        {
            get;
            set;
        }

        public YesNo IsApplyingLAWithPA
        {
            get;
            set;
        }

        public YesNo IsApplyingLAWithUE
        {
            get;
            set;
        }

        public YesNo IsWrittenWill
        {
            get;
            set;
        }

        public ApplicationLimitation Limitations
        {
            get;
            set;
        }

        public MCountryEntity MCountry
        {
            get;
            set;
        }

        public MProbateNatureEntity MProbateNature
        {
            get;
            set;
        }

        public MProbateNatureGroupEntity MProbateNatureGroup
        {
            get;
            set;
        }

        public String NatureOfForeignGrant
        {
            get;
            set;
        }

        public Int32? NoOfCodicil
        {
            get;
            set;
        }

        public Origin Origin
        {
            get;
            set;
        }

        public String OSRelevantInfo
        {
            get;
            set;
        }

        public YesNo OtherAnnexed
        {
            get;
            set;
        }

        public string OtherAnnexedReason
        {
            get;
            set;
        }

        public String OtherApplicantType
        {
            get;
            set;
        }

        public String OtherLimitations
        {
            get;
            set;
        }

        public String ProbateInfoId
        {
            get;
            set;
        }

        public ProbateInfoType ProbateInfoType
        {
            get;
            set;
        }

        public String ReasonOfLapse
        {
            get;
            set;
        }

        public YesNo SecondCertification
        {
            get;
            set;
        }

        public YesNo TstDidNotNameExec
        {
            get;
            set;
        }

        public YesNo TstDidNotNameRL
        {
            get;
            set;
        }

        public YesNo SOAHardCopyInd
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
            ProbateInfoEntity toCompareWith = obj as ProbateInfoEntity;
            return toCompareWith == null ? false : ((this.ProbateInfoId == toCompareWith.ProbateInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ProbateInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}