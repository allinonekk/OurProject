namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.ForeignLawPracticeRegEntity'</summary>
    /// 
    [Serializable]
    public class ForeignLawPracticeRegEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the Email field. </summary>
        public System.String Email
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FaxAreaCode field. </summary>
        public System.String FaxAreaCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FaxCountryCode field. </summary>
        public System.String FaxCountryCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FaxNumber field. </summary>
        public System.String FaxNumber
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ForeignLawPracticeRegId field. </summary>
        public System.String ForeignLawPracticeRegId
        {
            get;
            set;
        }

        public String LFID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LicenseNumber field. </summary>
        public System.String LicenseNumber
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LicenseYear field. </summary>
        public System.Decimal LicenseYear
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MobileCountryCode field. </summary>
        public System.String MobileCountryCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MobileNumber field. </summary>
        public System.String MobileNumber
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.ForeignLawPracticeReg.MTypeOfForeignLawPractice - Master.MTypeOfForeignLawPractice.ForeignLawPracticeRegs (m:1)'</summary>
        public MTypeOfForeignLawPracticeEntity MTypeOfForeignLawPractice
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NameForeignLP field. </summary>
        public System.String NameForeignLP
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NameJointLawVenture field. </summary>
        public System.String NameJointLawVenture
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NameSGLP field. </summary>
        public System.String NameSGLP
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TelAreaCode field. </summary>
        public System.String TelAreaCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TelCountryCode field. </summary>
        public System.String TelCountryCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TelNumber field. </summary>
        public System.String TelNumber
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UENNumber field. </summary>
        public System.String UENNumber
        {
            get;
            set;
        }

       
        public string SingaporeLFID { get; set; }

        public string ForeignLFID { get; set; }

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
            ForeignLawPracticeRegEntity toCompareWith = obj as ForeignLawPracticeRegEntity;
            return toCompareWith == null ? false : ((this.ForeignLawPracticeRegId == toCompareWith.ForeignLawPracticeRegId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ForeignLawPracticeRegId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}