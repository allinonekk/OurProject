namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MFilingFeeEntity'</summary>
    [Serializable]
    public class MFilingFeeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        public String FeeRuleCode
        {
            get;
            set;
        }

        public FeeRuleType FeeRuleType
        {
            get;
            set;
        }

        public String ForumId
        {
            get;
            set;
        }

        public YesNo IsSystemRule
        {
            get;
            set;
        }

        public MFilingFeeTypeEntity MFilingFeeType
        {
            get;
            set;
        }

        public String ROCReference
        {
            get;
            set;
        }

        public String RuleName
        {
            get;
            set;
        }

        public MFilingFeeLegislationActEntity MFilingFeeLegislationAct
        {
            get;
            set;
        }

        public decimal? TierType
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
            MFilingFeeEntity toCompareWith = obj as MFilingFeeEntity;
            return toCompareWith == null ? false : ((this.FeeRuleCode == toCompareWith.FeeRuleCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FeeRuleCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}