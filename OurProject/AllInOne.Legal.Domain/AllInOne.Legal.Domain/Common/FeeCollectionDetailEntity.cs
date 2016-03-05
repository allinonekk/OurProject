namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Common.FeeCollectionDetail'</summary>
    [Serializable]
    public class FeeCollectionDetailEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        public string FeeCollectionDetailid { get; set; }
        public string CaseNo { get; set; }
        public long Caseinfoid { get; set; }
        public string Docid { get; set; }
        public string Doccode { get; set; }
        public string DocTitle { get; set; }
        public string Submissiongroupid { get; set; }
        public Nullable<System.DateTime> GenaratedDatetime { get; set; }
        public Nullable<System.Decimal> Amounttobecollected { get; set; }
        public string Name { get; set; }
        public YesNo Collectionstatus { get; set; }
        public Nullable<System.Decimal> CollectionAmount { get; set; }
        public string CollectionRemarks { get; set; }
        public string PaymentTxnNo { get; set; }
        public string AddtionalFeeCollectType { get; set; }
        public string CollectedBy { get; set; }
        public Nullable<System.DateTime> CollectionDate { get; set; }
        public string SupportuplDocid { get; set; }
        public YesNo ObsInd { get; set; }

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
            FeeCollectionDetailEntity toCompareWith = obj as FeeCollectionDetailEntity;
            return toCompareWith == null ? false : ((this.FeeCollectionDetailid == toCompareWith.FeeCollectionDetailid) );
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FeeCollectionDetailid.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}