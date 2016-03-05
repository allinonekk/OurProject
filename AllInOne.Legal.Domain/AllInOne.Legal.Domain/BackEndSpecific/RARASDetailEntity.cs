namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    [Serializable]
    public class RARASDetailEntity : AbstractLastModified, IBackEndSpecificEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="RARASDetailEntity"/> class.</summary>
        public RARASDetailEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

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

        /// <summary>Gets or sets the RARASDetailId field. </summary>
        public System.String RARASDetailId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SendAutoNotification field. </summary>
        public YesNo SendAutoNotification
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

        /// <summary>Gets or sets the TimeForGDCT field. </summary>
        public System.String TimeForGDCT
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TimeTakenForHearing field. </summary>
        public System.String TimeTakenForHearing
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
            RARASDetailEntity toCompareWith = obj as RARASDetailEntity;
            return toCompareWith == null ? false : ((this.RARASDetailId == toCompareWith.RARASDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RARASDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}