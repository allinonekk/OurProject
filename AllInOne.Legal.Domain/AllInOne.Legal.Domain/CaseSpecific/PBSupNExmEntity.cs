namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class PBSupNExmEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        public decimal EstValue { get; set; }

        public int ItemNo{ get; set; }

        public string PropertyDesc
        {
            get;
            set;
        }

        public string ValueType
        {
            get;
            set;
        }

        public string PBSupNExmId
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
            PBSupNExmEntity toCompareWith = obj as PBSupNExmEntity;
            return toCompareWith == null ? false : ((this.PBSupNExmId == toCompareWith.PBSupNExmId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PBSupNExmId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}