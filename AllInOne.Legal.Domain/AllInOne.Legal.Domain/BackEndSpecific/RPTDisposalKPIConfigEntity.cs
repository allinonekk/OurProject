namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class RPTDisposalKPIConfigEntity:IBackEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the RPT disposal KPI config id.
        /// </summary>
        /// <value>The RPT disposal KPI config id.</value>
        public int RPTDisposalKPIConfigId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the noc group code.
        /// </summary>
        /// <value>The noc group code.</value>
        public string NocGroupCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the case type code.
        /// </summary>
        /// <value>The case type code.</value>
        public string CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the disposal periodin MNTHS.
        /// </summary>
        /// <value>The disposal periodin MNTHS.</value>
        public int DisposalPeriodinMnths
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the KPI percentge.
        /// </summary>
        /// <value>The KPI percentge.</value>
        public int KPIPercentge
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the out come code.
        /// </summary>
        /// <value>The type of the out come code.</value>
        public string OutComeCodeType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the obs ind.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedDate.
        /// </summary>
        /// <value>The LastModifiedDate.</value>
        public DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public string LastModifiedBy
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
            RPTDisposalKPIConfigEntity toCompareWith = obj as RPTDisposalKPIConfigEntity;
            return toCompareWith == null ? false : ((this.RPTDisposalKPIConfigId == toCompareWith.RPTDisposalKPIConfigId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RPTDisposalKPIConfigId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}