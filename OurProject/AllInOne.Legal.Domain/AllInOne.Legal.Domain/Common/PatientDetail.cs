namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for WOSInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class PatientDetailEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        public String Addr1
        {
            get;
            set;
        }

        public String Addr2
        {
            get;
            set;
        }

        public String Addr3
        {
            get;
            set;
        }

        public String Addr4
        {
            get;
            set;
        }

        public String BlkNo
        {
            get;
            set;
        }

        public String BuildingName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is injunction filed.
        /// </summary>
        /// <value>The is injunction filed.</value>
        public DateTime? DateOfBirth
        {
            get;
            set;
        }

        public String FloorNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the total LIQ awarded amount.
        /// </summary>
        /// <value>The total LIQ awarded amount.</value>
        public AddressFormatType FormatInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is serve out JDC.
        /// </summary>
        /// <value>The is serve out JDC.</value>
        public String IdNumber
        {
            get;
            set;
        }

        public String IdRemarks
        {
            get;
            set;
        }

        public MAccomodationTypeEntity MAccomodationType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is partner in firm.
        /// </summary>
        /// <value>The is partner in firm.</value>
        public MCountryEntity MCountry
        {
            get;
            set;
        }

        public MMaritalStatusEntity MMaritalStatus
        {
            get;
            set;
        }

        public MOccupationEntity MOccupation
        {
            get;
            set;
        }

        public MPersonIDGroupEntity MPersonIDGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is managed EWT.
        /// </summary>
        /// <value>The is managed EWT.</value>
        public MPersonIDTypeEntity MPersonIDType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the control.
        /// </summary>
        /// <value>The type of the control.</value>
        public String Name
        {
            get;
            set;
        }

        public Int32? NoOfRevPersons
        {
            get;
            set;
        }

        public String OtherAccommodation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the attachment.
        /// </summary>
        /// <value>The type of the attachment.</value>
        public String PatientId
        {
            get;
            set;
        }

        public String PostalCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the total LIQ claim amount.
        /// </summary>
        /// <value>The total LIQ claim amount.</value>
        public String ResAddress
        {
            get;
            set;
        }

        public String StreetName
        {
            get;
            set;
        }

        public String UnitNo
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

            PatientDetailEntity toCompareWith = obj as PatientDetailEntity;
            return toCompareWith == null ? false : ((this.PatientId == toCompareWith.PatientId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PatientId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}