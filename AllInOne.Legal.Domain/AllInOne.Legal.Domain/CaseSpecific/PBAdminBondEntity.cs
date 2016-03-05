namespace AllInOne.Legal.Domain.CaseSpecific
{
    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using System;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class PBAdminBondEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        public string PBAdminBondId { get; set; }

        public decimal? EstimatedValue
        {
            get;
            set;
        }
        public decimal? FixedValue
        {
            get;
            set;
        }
        public decimal? OtherValue
        {
            get;
            set;
        }
        public decimal? ActualValue
        {
            get;
            set;
        }
        public decimal? SupplimentaryValue
        {
            get;
            set;
        }
        public decimal? EstateValue
        {
            get;
            set;
        }

        public decimal? ExpensesIncurred
        {
            get;
            set;
        }

        public string AdminBondReqInd
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
            PBAdminBondEntity toCompareWith = obj as PBAdminBondEntity;
            return toCompareWith == null ? false : ((this.PBAdminBondId == toCompareWith.PBAdminBondId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PBAdminBondId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}