namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Common.AccountantsReportInfoEntity'</summary>
    public class AccountantsReportInfoEntity : AbstractSubmissionGroup, ISubCaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the AccountantsReportInfoId field. </summary>
        public System.String AccountantsReportInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AccountingFromDate field. </summary>
        public Nullable<System.DateTime> AccountingFromDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AccountingToDate field. </summary>
        public Nullable<System.DateTime> AccountingToDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CertainTrivialBreaches field. </summary>
        public YesNo CertainTrivialBreaches
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DoesAcctRptComplyS73LPA field. </summary>
        public YesNo DoesAcctRptComplyS73LPA
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DoesHaveDiffInComparision field. </summary>
        public YesNo DoesHaveDiffInComparision
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IdNumberOfAccountant field. </summary>
        public System.String IdNumberOfAccountant
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MatterSetOutFirstSection field. </summary>
        public YesNo MatterSetOutFirstSection
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MatterSetOutSecondSection field. </summary>
        public YesNo MatterSetOutSecondSection
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
            if(obj == null)
            {
                return false;
            }
            AccountantsReportInfoEntity toCompareWith = obj as AccountantsReportInfoEntity;
            return toCompareWith == null ? false : ((this.AccountantsReportInfoId == toCompareWith.AccountantsReportInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AccountantsReportInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}