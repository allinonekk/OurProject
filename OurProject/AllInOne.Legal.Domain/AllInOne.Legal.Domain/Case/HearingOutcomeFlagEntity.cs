namespace AllInOne.Legal.Domain.Case
{
    using System;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class HearingOutcomeFlagEntity : AbstractSubmissionGroup, ICaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the HRGID.
        /// </summary>
        /// <value>The HRGID.</value>
        public Int64 HRGID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public int ItemNo
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the HRG out come flag code.
        /// </summary>
        /// <value>The HRG out come flag code.</value>
        public MHRGOutComeFlagEntity MHRGOutComeFlagEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the obsInd.
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
            HearingOutcomeFlagEntity toCompareWith = obj as HearingOutcomeFlagEntity;
            return toCompareWith == null ? false : ((this.HRGID == toCompareWith.HRGID) && (this.ItemNo == toCompareWith.ItemNo));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HRGID.GetHashCode();
            toReturn ^= this.ItemNo.GetHashCode();
            return toReturn;
        }

        #endregion Methods

    }
}