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
    public class DeputyDetailEntity : AbstractSubmissionGroup, ICaseSpecificEntity
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

        /// <summary>
        /// Gets or sets the type of the attachment.
        /// </summary>
        /// <value>The type of the attachment.</value>
        public String DeputyId
        {
            get;
            set;
        }

        public String Email
        {
            get;
            set;
        }

        public String EmpAddr1
        {
            get;
            set;
        }

        public String EmpAddr2
        {
            get;
            set;
        }

        public String EmpAddr3
        {
            get;
            set;
        }

        public String EmpAddr4
        {
            get;
            set;
        }

        public String EmpAddress
        {
            get;
            set;
        }

        public String EmpBlkNo
        {
            get;
            set;
        }

        public String EmpBuildingName
        {
            get;
            set;
        }

        public String EmpFloorNo
        {
            get;
            set;
        }

        public AddressFormatType EmpFormatInd
        {
            get;
            set;
        }

        public String EmpName
        {
            get;
            set;
        }

        public String EmpPostalCode
        {
            get;
            set;
        }

        public String EmpStreetName
        {
            get;
            set;
        }

        public String EmpUnitNo
        {
            get;
            set;
        }

        public String FaxAreaCode
        {
            get;
            set;
        }

        public String FaxCountryCode
        {
            get;
            set;
        }

        public String FaxNumber
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

        public String IDRemarks
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

        public String MobileCountryCode
        {
            get;
            set;
        }

        public String MobileNumber
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

        public MRelationshipEntity MRelationship
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

        public String PostalCode
        {
            get;
            set;
        }

        public String RelationshipRemarks
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

        public String TelAreaCode
        {
            get;
            set;
        }

        public String TelCountryCode
        {
            get;
            set;
        }

        public String TelNumber
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

            DeputyDetailEntity toCompareWith = obj as DeputyDetailEntity;
            return toCompareWith == null ? false : ((this.DeputyId == toCompareWith.DeputyId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DeputyId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}