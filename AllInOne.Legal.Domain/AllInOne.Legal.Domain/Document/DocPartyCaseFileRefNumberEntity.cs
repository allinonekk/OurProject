
namespace AllInOne.Legal.Domain.Document
{
    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using System;

    /// <summary>
    /// Represents a standard domain entity for DocPartyCaseFileRefNumber.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    /// 
    [Serializable]
    public class DocPartyCaseFileRefNumberEntity : AbstractDocCaseParty, IDocumentEntity
    {
        #region Properties
        public string CaseInfoID
        {
            get;
            set;
        }
        public string LFFileRefNumber
        {
            get;
            set;
        }
        public string DocPartyCaseFileRefNumberId
        {
            get;
            set;
        }
        public string LFID
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
            DocPartyCaseFileRefNumberEntity toCompareWith = obj as DocPartyCaseFileRefNumberEntity;
            return toCompareWith == null ? false : ((this.DocPartyCaseFileRefNumberId == toCompareWith.DocPartyCaseFileRefNumberId) && (this.CaseInfoID == toCompareWith.CaseInfoID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocPartyCaseFileRefNumberId.GetHashCode();
            toReturn ^= this.CaseInfoID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}