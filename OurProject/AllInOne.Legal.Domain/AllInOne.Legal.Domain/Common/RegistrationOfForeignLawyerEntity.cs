namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using System.Collections.Generic;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.RegistrationOfForeignLawyerEntity'</summary>
    [Serializable]
    public class RegistrationOfForeignLawyerEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="RegistrationOfForeignLawyerEntity"/> class.</summary>
        public RegistrationOfForeignLawyerEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties


        public string RegistrationOfForeignLawyerId { get; set; }
        public string ForeignUserRegistrationId { get; set; }
        public string Salutation { get; set; }
        public string FullName { get; set; }
        public string IDTypeCode { get; set; }
        public string IDNumber { get; set; }
        public MGenderEntity Gender { get; set; }
        public MNationalityEntity Nationality { get; set; }
        public string MobileCountryCode { get; set; }
        public string MobileNumber { get; set; }
        public string TelCountryCode { get; set; }
        public string TelAreaCode { get; set; }
        public string TelNumber { get; set; }
        public string FaxCountryCode { get; set; }
        public string FaxAreaCode { get; set; }
        public string Email { get; set; }
        public string UserDetailId { get; set; }
        public YesNo ObsInd { get; set; }
        public string FaxNumber { get; set; }
        public string RFLType { get; set; }
        public string FileRefNo { get; set; }
        public MCaseTypeEntity CaseType { get; set; }
        public string OrderNumber { get; set; }
        public string CaseNo { get; set; }
        public string PaymentMode { get; set; }

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
            RegistrationOfForeignLawyerEntity toCompareWith = obj as RegistrationOfForeignLawyerEntity;
            return toCompareWith == null ? false : ((this.RegistrationOfForeignLawyerId == toCompareWith.RegistrationOfForeignLawyerId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RegistrationOfForeignLawyerId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}