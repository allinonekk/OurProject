namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    [Serializable]
    public class CaseStatusRuleInfoEntity : AbstractCaseInfo, IBackEndSpecificEntity
    {

        #region Properties

        /// <summary>Gets or sets the CaseStatusRuleInfoId field. </summary>
        public string CaseStatusRuleInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the rule.
        /// </summary>
        /// <value>The type of the rule.</value>
        public string RuleType
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
            CaseStatusRuleInfoEntity toCompareWith = obj as CaseStatusRuleInfoEntity;
            return toCompareWith == null ? false : ((this.CaseStatusRuleInfoId == toCompareWith.CaseStatusRuleInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseStatusRuleInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}