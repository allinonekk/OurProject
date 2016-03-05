namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for WOSInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class WOSInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the type of the attachment.
        /// </summary>
        /// <value>The type of the attachment.</value>
        public AttachmentType AttachmentType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the control.
        /// </summary>
        /// <value>The type of the control.</value>
        public ControlType ControlType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is injunction filed.
        /// </summary>
        /// <value>The is injunction filed.</value>
        public YesNo IsInjunctionFiled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is managed EWT.
        /// </summary>
        /// <value>The is managed EWT.</value>
        public YesNo IsManagedEWT
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is partner in firm.
        /// </summary>
        /// <value>The is partner in firm.</value>
        public YesNo IsPartnerInFirm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is serve out JDC.
        /// </summary>
        /// <value>The is serve out JDC.</value>
        public YesNo IsServeOutJDC
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the total LIQ awarded amount.
        /// </summary>
        /// <value>The total LIQ awarded amount.</value>
        public Decimal? TotalLIQAwardedAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the total LIQ claim amount.
        /// </summary>
        /// <value>The total LIQ claim amount.</value>
        public Decimal? TotalLIQClaimAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the total un LIQEST amount.
        /// </summary>
        /// <value>The total un LIQEST amount.</value>
        public Decimal? TotalUnLIQESTAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the totla un LIQ awarded amount.
        /// </summary>
        /// <value>The totla un LIQ awarded amount.</value>
        public Decimal? TotlaUnLIQAwardedAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WOS info id.
        /// </summary>
        /// <value>The WOS info id.</value>
        public string WOSInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the writ expiry date.
        /// </summary>
        /// <value>The writ expiry date.</value>
        public DateTime? WritExpiryDate
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the writ expiry date.
        /// </summary>
        /// <value>The writ isPOHA.</value>
        public YesNo IsPOHA
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the StatutoryTortType .
        /// </summary>
        /// <value>The Statutory Tort Type.</value>
        public string StatutoryTortType
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

            WOSInfoEntity toCompareWith = obj as WOSInfoEntity;
            return toCompareWith == null ? false : ((this.WOSInfoId == toCompareWith.WOSInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WOSInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}