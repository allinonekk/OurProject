namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LawFirm;

    /// <summary>Class which represents the entity 'Common.EmploymentInfoEntity'</summary>
    [Serializable]
    public class EmploymentInfoEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the DateOfExpiry field. </summary>
        public Nullable<System.DateTime> DateOfExpiry
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfIssue field. </summary>
        public Nullable<System.DateTime> DateOfIssue
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Designation field. </summary>
        public System.String Designation
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EmploymentInfoId field. </summary>
        public System.String EmploymentInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EmploymentPassNumber field. </summary>
        public System.String EmploymentPassNumber
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.EmploymentInfo.LawFirm - Common.LawFirm.EmploymentInfos (m:1)'</summary>
        //public  LawFirmEntity LawFirm
        //{
        //    get;
        //    set;
        //}
        /// <summary>Gets or sets the LFID field. </summary>
        public System.String LFID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OtherLawPractice field. </summary>
        public System.String OtherLawPractice
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
            EmploymentInfoEntity toCompareWith = obj as EmploymentInfoEntity;
            return toCompareWith == null ? false : ((this.EmploymentInfoId == toCompareWith.EmploymentInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EmploymentInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}