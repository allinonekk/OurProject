using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllInOne.Legal.Entities.BackEnd
{
   public partial class NOCInfo:ISubCaseSpecific
    {

        #region Properties
        public virtual string NOCInfoId { get; set; }

        public virtual string CaseInfoId
        {
            get;
            set;
        }

        public virtual string DOCID
        {
            get;
            set;
        }

        public virtual long? SubCaseInfoID
        {
            get;
            set;
        }

        public virtual string IsCeased
        {
            get;
            set;
        }

        public virtual DateTime? CeasedDate
        {
            get;
            set;
        }

        public virtual string ObsInd
        {
            get;
            set;
        }

        public virtual string CeasedRemarks
        {
            get;
            set;
        }

        public virtual string IsPresentlyEmployed
        {
            get;
            set;
        }

        public virtual string IsDisqualifiedR26
        {
            get;
            set;
        }

        public virtual string IsDisqualifiedRemarks
        {
            get;
            set;
        }

        public virtual string PCCERT_IND
        {
            get;
            set;
        }

        public virtual string CertificateRegNumber
        {
            get;
            set;
        }

        public virtual decimal? CertificateRegYear
        {
            get;
            set;
        }

        public virtual DateTime? CertificateRegPeriodFrom
        {
            get;
            set;
        }

        public virtual DateTime? CertificateRegPeriodTo
        {
            get;
            set;
        }
        public virtual MLawPracticeType MLawPracticeType
        {
            get;
            set;
        }

        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        public virtual string SubmissionGroupId
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
            NOCInfo toCompareWith = obj as NOCInfo;
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
