namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Common.ForeignUserPracticeInformationEntity'</summary>
    [Serializable]
    public class ForeignUserRegAddressDetailsEntity : AbstractLastModified, ICommonEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ForeignUserRegAddressDetailsEntity"/> class.</summary>
        public ForeignUserRegAddressDetailsEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public string ForeignUserRegAddressId { get; set; }
        public string ForeignUserRegistrationId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryCode { get; set; }
        public string PostalCode { get; set; }
        public YesNo ObsInd { get; set; }
        public string RegistrationOfForeignLawyerId{ get; set; }

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
            ForeignUserRegAddressDetailsEntity toCompareWith = obj as ForeignUserRegAddressDetailsEntity;
            return toCompareWith == null ? false : ((this.ForeignUserRegAddressId == toCompareWith.ForeignUserRegAddressId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ForeignUserRegAddressId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}