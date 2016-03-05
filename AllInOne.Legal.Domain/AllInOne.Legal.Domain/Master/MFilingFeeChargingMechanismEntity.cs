namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MFilingFeeChargingMechanismEntity'</summary>
    [Serializable]
    public class MFilingFeeChargingMechanismEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

        public String FeeChargeID
        {
            get;
            set;
        }


        public MFilingFeeEntity MFilingFeeEntity
        {
            get;
            set;
        }

        public decimal? FlatFeeRate
        { get; set; }

        public decimal? PerRateFee
        {
            get;
            set;
        }

        public decimal? MinimumFee
        {
            get;
            set;
        }

        public string PerRateUnit
        { 
            get; 
            set; 
        }

        public decimal ProcFee
        {
            get;
            set;
        }

        public decimal TransFee
        {
            get;
            set;
        }

        public decimal? UrgentFee
        {
            get;
            set;
        }

        public decimal? BaseFee
        {
            get;
            set;
        }

        public decimal? AdditionalFee
        {
            get;
            set;
        }

        public DateTime EffectiveFrom
        {
            get;
            set;
        }

        public DateTime? EffectiveTo
        {
            get;
            set;
        }

        public YesNo IsInterfaced
        {
            get;
            set;
        }

        public YesNo ObsInd
        {
            get;
            set;
        }

        public decimal? Perdocument
        {
            get;
            set;
        }

        public int? InExcessOf
        {
            get;
            set;
        }

        public decimal? CourtFeePercent
        {
            get;
            set;
        }

        public decimal? TierType
        {
            get;
            set;
        }

        public string ForumID
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
            MFilingFeeChargingMechanismEntity toCompareWith = obj as MFilingFeeChargingMechanismEntity;
            return toCompareWith == null ? false : ((this.FeeChargeID == toCompareWith.FeeChargeID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FeeChargeID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}