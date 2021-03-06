namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    ///	Generated by MyGeneration using the NHibernate Object Mapping template
    /// </summary>
    [Serializable]
    public class SolicitorDetailsViewEntity : IFrontEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CaseNo field.
        /// </summary>
        public System.String CaseNo
        {
            get;
             			set;
        }

        /// <summary>
        /// Gets or sets the IDNumber field.
        /// </summary>
        public System.String IDNumber
        {
            get;
             			set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedBy field.
        /// </summary>
        public System.String LastModifiedBy
        {
            get;
             			set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedDate field.
        /// </summary>
        public DateTime LastModifiedDate
        {
            get;
             			set;
        }

        /// <summary>
        /// Gets or sets the LFID field.
        /// </summary>
        public System.String LFID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Name field.
        /// </summary>
        public System.String Name
        {
            get;
             			set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        public System.String ObsInd
        {
            get;
             			set;
        }

        /// <summary>
        /// Gets or sets the SolicitorID field.
        /// </summary>
        public System.Int64 SolicitorID
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
            SolicitorDetailsViewEntity toCompareWith = obj as SolicitorDetailsViewEntity;
            return toCompareWith == null ? false : ((this.SolicitorID == toCompareWith.SolicitorID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SolicitorID.GetHashCode();
            return toReturn;
        }

        public override string ToString()
        {
            return 		"SolicitorID=" + SolicitorID + "--" +
            "IDNumber=" + IDNumber + "--" +
            "CaseNo=" + CaseNo + "--" +
            "Name=" + Name + "--" +
            "ObsInd=" + ObsInd + "--" +
            "LastModifiedBy=" + LastModifiedBy + "--" +
            "LastModifiedDate=" + LastModifiedDate + "--" +
            "";
        }

        #endregion Methods
    }
}