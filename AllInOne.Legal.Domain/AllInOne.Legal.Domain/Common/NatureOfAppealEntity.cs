namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    [Serializable]
    public class NatureOfAppealEntity : AbstractLastModified, ICommonEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="NatureOfAppealEntity"/> class.</summary>
        public NatureOfAppealEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the MNatureOfAppeal field. </summary>
        public MNatureOfAppealEntity MNatureOfAppeal
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NatureOfAppealId field. </summary>
        public System.String NatureOfAppealId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NatureOfAppealRemarks field. </summary>
        public System.String NatureOfAppealRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public System.String SubmissionGroupId
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
            NatureOfAppealEntity toCompareWith = obj as NatureOfAppealEntity;
            return toCompareWith == null ? false : ((this.NatureOfAppealId == toCompareWith.NatureOfAppealId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NatureOfAppealId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}