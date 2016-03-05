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
    public class PBExecutorDetailEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        public DateTime? DateOfDeath
        {
            get;
            set;
        }

        public Int32 ItemNo
        {
            get;
            set;
        }

        public String OtherStatus
        {
            get;
            set;
        }

        public String PBExecutorDetailId
        {
            get;
            set;
        }

        public ExecutorStatus Status
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
            PBExecutorDetailEntity toCompareWith = obj as PBExecutorDetailEntity;
            return toCompareWith == null ? false : ((this.PBExecutorDetailId == toCompareWith.PBExecutorDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PBExecutorDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}