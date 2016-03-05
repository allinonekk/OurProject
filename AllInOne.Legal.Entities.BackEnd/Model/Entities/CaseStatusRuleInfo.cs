namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

    [Serializable]
    public class CaseStatusRuleInfo : IBackEndSpecific
    {
       
        #region Properties

        /// <summary>Gets or sets the CaseStatusRuleInfoId field. </summary>
        public virtual string CaseStatusRuleInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the rule.
        /// </summary>
        /// <value>The type of the rule.</value>
        public virtual string RuleType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the case info id.
        /// </summary>
        /// <value>The case info id.</value>
        public virtual Int64 CaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified date.
        /// </summary>
        /// <value>The last modified date.</value>
        public virtual DateTime LastModifiedDate
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
            CaseStatusRuleInfo toCompareWith = obj as CaseStatusRuleInfo;
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