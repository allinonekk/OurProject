namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.ClaimAmountEntity'</summary>
    [Serializable]
    public class ClaimAmountEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the AdmissionOn field. </summary>
        public string CaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ClassOfDegree field. </summary>
        public string DocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ConfermentOfDegree field. </summary>
        public string DOCCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CourseLength field. </summary>
        public string ClaimType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DegreeInfoId field. </summary>
        public decimal ClaimAmount
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
            ClaimAmountEntity toCompareWith = obj as ClaimAmountEntity;
            return toCompareWith == null ? false : ((this.CaseInfoId == toCompareWith.CaseInfoId)
                && (this.DOCCode == toCompareWith.DOCCode)
                && (this.DocId == toCompareWith.DocId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseInfoId.GetHashCode();
            toReturn ^= this.DOCCode.GetHashCode();
            toReturn ^= this.DocId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}