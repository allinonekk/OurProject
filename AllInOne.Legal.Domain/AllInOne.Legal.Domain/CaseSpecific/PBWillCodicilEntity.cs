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
    public class PBWillCodicilEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        public String CaseInfoId
        {
            get;
            set;
        }

        public DateTime? CodicilWillDate
        {
            get;
            set;
        }

        public String DateRemarks
        {
            get;
            set;
        }

        public String DocId
        {
            get;
            set;
        }

        public MDocCodeEntity MDocCode
        {
            get;
            set;
        }

        public String PBWillCodicilId
        {
            get;
            set;
        }

        public String RegisterPageNo
        {
            get;
            set;
        }

        public String RegisterVolumeNo
        {
            get;
            set;
        }

        public DateTime? SubmitDate
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
            PBWillCodicilEntity toCompareWith = obj as PBWillCodicilEntity;
            return toCompareWith == null ? false : ((this.PBWillCodicilId == toCompareWith.PBWillCodicilId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PBWillCodicilId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}