namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'BackEndSpecific.DisciplinaryActionInfoEntity'</summary>
    public class DisciplinaryActionInfoEntity : AbstractSubmissionGroup, IBackEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the DACCaseNumber.
        /// </summary>
        public String DACCaseNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DisciplinaryActionInfoId.
        /// </summary>
        public String DisciplinaryActionInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DisciplinaryTypeRemarks.
        /// </summary>
        public String DisciplinaryTypeRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MAASDisciplinaryResultType.
        /// </summary>
        public MAASDisciplinaryResultTypeEntity MAASDisciplinaryResultType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MAASDisciplinaryType.
        /// </summary>
        public MAASDisciplinaryTypeEntity MAASDisciplinaryType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PeriodEndDate.
        /// </summary>
        public DateTime? PeriodEndDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PeriodStartDate.
        /// </summary>
        public DateTime? PeriodStartDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Remarks.
        /// </summary>
        public String Remarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Result.
        /// </summary>
        public String Result
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

            DisciplinaryActionInfoEntity toCompareWith = obj as DisciplinaryActionInfoEntity;
            return toCompareWith == null ? false : ((this.DisciplinaryActionInfoId == toCompareWith.DisciplinaryActionInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DisciplinaryActionInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}