namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using System.Collections.Generic;

    /// <summary>Class which represents the entity 'Common.ForeignUserRegistrationDetailsEntity'</summary>
    [Serializable]
    public class ForeignUserRegistrationDetailsEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        public string ForeignUserRegistrationId { get; set; }
        public string Salutation { get; set; }
        public string FullName { get; set; }
        public string IDTypeCode { get; set; }
        public string IDNumber { get; set; }
        public string GenderCode { get; set; }
        public string NationalityCode { get; set; }
        public string MobileCountryCode { get; set; }
        public string MobileNumber { get; set; }
        public string TelCountryCode { get; set; }
        public string TelAreaCode { get; set; }
        public string TelNumber { get; set; }
        public string FaxCountryCode { get; set; }
        public string FaxAreaCode { get; set; }
        public string Email { get; set; }
        public long UserDetailId { get; set; }
        public YesNo ObsInd { get; set; }
        public string FaxNumber { get; set; }
        public string RFLType { get; set; }
        public string AccountID { get; set; }


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
            ForeignUserRegistrationDetailsEntity toCompareWith = obj as ForeignUserRegistrationDetailsEntity;
            return toCompareWith == null ? false : ((this.ForeignUserRegistrationId == toCompareWith.ForeignUserRegistrationId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ForeignUserRegistrationId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}