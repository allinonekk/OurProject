namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.CORSolicitorRegEntity'</summary>
    [Serializable]
    public class CORSolicitorRegEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the CertficateRegPeriodFrom field. </summary>
        public DateTime? CertficateRegPeriodFrom
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CertficateRegPeriodTo field. </summary>
        public DateTime? CertficateRegPeriodTo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CORSolicitorRegId field. </summary>
        public String CORSolicitorRegId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PCDocCode field. </summary>
        public String PCDocCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LFIDGroupID field. </summary>
        public String LFIDGroupID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsAccRptStatus field. </summary>
        public YesNo IsAccRptStatus
        {
            get;
            set;
        }

        public String CertificateRegNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the CaseInfoId field.
        /// </summary>
        /// <value>The case info id.</value>
        public Int64 Caseinfoid
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
            CORSolicitorRegEntity toCompareWith = obj as CORSolicitorRegEntity;
            return toCompareWith == null ? false : ((this.CORSolicitorRegId == toCompareWith.CORSolicitorRegId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CORSolicitorRegId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}