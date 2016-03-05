namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using AllInOne.Legal.Domain.Interfaces;
using AllInOne.Legal.Domain.Abstract;
using System;
using AllInOne.Legal.Domain.Master;

    public class NOCInfoEntity:AbstractSubmissionGroup, ISubCaseSpecificEntity
    {
        #region Properties
        public string NOCInfoId { get; set; }

        public string CaseInfoId
        {
            get;
            set;
        }

        public string DOCID
        {
            get;
            set;
        }

        public long? SubCaseInfoID
        {
            get;
            set;
        }

        public YesNo IsCeased
        {
            get;
            set;
        }

        public DateTime? CeasedDate
        {
            get;
            set;
        }

        public YesNo ObsInd
        {
            get;
            set;
        }

        public string CeasedRemarks
        {
            get;
            set;
        }

        public YesNo IsPresentlyEmployeed
        {
            get;
            set;
        }

        public YesNo IsDisqualifiedR26
        {
            get;
            set;
        }

        public string IsDisqualifiedRemarks
        {
            get;
            set;
        }

        public YesNo PCCERT_IND
        {
            get;
            set;
        }

        public MLawPracticeTypeEntity MLawPracticeTypeEntity
        {
            get;
            set;
        }
        public string CertificateRegNumber
        {
            get;
            set;
        }

        public decimal? CertificateRegYear
        {
            get;
            set;
        }

        public DateTime? CertificateRegPeriodFrom
        {
            get;
            set;
        }

        public DateTime? CertificateRegPeriodTo
        {
            get;
            set;
        }

        #endregion

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
            NOCInfoEntity toCompareWith = obj as NOCInfoEntity;
            return toCompareWith == null ? false : ((this.NOCInfoId == toCompareWith.NOCInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NOCInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods


    }
}
