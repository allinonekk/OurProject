namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    [Serializable]
    public class DCADetailEntity : AbstractLastModified, IBackEndSpecificEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="DCADetailEntity"/> class.</summary>
        public DCADetailEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the DCADetailId field. </summary>
        public System.String DCADetailId
        {
            get;
            set;
        }

        public DateTime? GDDueDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsAppealFiledCorrectly field. </summary>
        public System.String IsAppealFiledCorrectly
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LeaveToAppeal field. </summary>
        public System.String LeaveToAppeal
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
            DCADetailEntity toCompareWith = obj as DCADetailEntity;
            return toCompareWith == null ? false : ((this.DCADetailId == toCompareWith.DCADetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DCADetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}