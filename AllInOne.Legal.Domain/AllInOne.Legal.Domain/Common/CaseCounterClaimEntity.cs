namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.CaseCounterClaimEntity'</summary>
    [Serializable]
    public class CaseCounterClaimEntity : ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the CaseCounterClaimID field. </summary>
        public System.String CaseCounterClaimID
        {
            get;
            set;
        }

        /// <summary>CaseInfoID</summary>
        public String CaseInfoID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public System.DateTime LastModifiedDate
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
            CaseCounterClaimEntity toCompareWith = obj as CaseCounterClaimEntity;
            return toCompareWith == null ? false : ((this.CaseCounterClaimID == toCompareWith.CaseCounterClaimID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseCounterClaimID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}