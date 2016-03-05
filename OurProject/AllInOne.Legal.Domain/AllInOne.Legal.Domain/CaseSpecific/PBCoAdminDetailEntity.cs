namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class PBCoAdminDetailEntity : AbstractSubmissionGroup, ICaseSpecificEntity
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

        public String Address
        {
            get;
            set;
        }

        public YesNo AddrInd
        {
            get;
            set;
        }

        public String ApplicantCapacityRemarks
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

        public String FloorNo
        {
            get;
            set;
        }

        public AddressFormatType FormatInd
        {
            get;
            set;
        }

        public String FullName
        {
            get;
            set;
        }

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

        public Int32 ItemNo
        {
            get;
            set;
        }

        public MApplicantCapacityEntity MApplicantCapacity
        {
            get;
            set;
        }

        public MCountryEntity MCountry
        {
            get;
            set;
        }

        public MGenderEntity MGender
        {
            get;
            set;
        }

        public MPersonIDGroupEntity MPersonIDGroup
        {
            get;
            set;
        }

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

        public String PBCoAdminDetailId
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
            PBCoAdminDetailEntity toCompareWith = obj as PBCoAdminDetailEntity;
            return toCompareWith == null ? false : ((this.PBCoAdminDetailId == toCompareWith.PBCoAdminDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PBCoAdminDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}