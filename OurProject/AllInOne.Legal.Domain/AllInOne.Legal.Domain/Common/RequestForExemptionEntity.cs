namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using System.Collections.Generic;

    /// <summary>Class which represents the entity 'Common.RequestForExemptionEntity'</summary>
    [Serializable]
    public class RequestForExemptionEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        public string RequestForExemptionId { get; set; }
        public string CaseinfoId { get; set; }
        public DateTime PCStartYear { get; set; }
        public DateTime PCEndYear { get; set; }
        public Int64 PCYear { get; set; }
        public string Status { get; set; }
        public YesNo ObsInd { get; set; }

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
            RequestForExemptionEntity toCompareWith = obj as RequestForExemptionEntity;
            return toCompareWith == null ? false : ((this.RequestForExemptionId == toCompareWith.RequestForExemptionId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RequestForExemptionId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}