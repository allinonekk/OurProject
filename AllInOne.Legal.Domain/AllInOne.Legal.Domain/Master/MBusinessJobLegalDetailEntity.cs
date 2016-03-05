namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    public class MBusinessJobLegalDetailEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the BusinessJobLegalDetailId field.
        /// </summary>
        /// <value>The Business Job Legal Detail id.</value>
        public String BusinessJobLegalDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BusinessJobLegalInfoId.
        /// </summary>
        /// <value>The BusinessJobLegalInfoId.</value>
        public String BusinessJobLegalInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Timeframe.
        /// </summary>
        /// <value>The Timeframe.</value>
        public Int32 Timeframe
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
            MBusinessJobLegalDetailEntity toCompareWith = obj as MBusinessJobLegalDetailEntity;
            return toCompareWith == null ? false : ((this.BusinessJobLegalDetailId == toCompareWith.BusinessJobLegalDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BusinessJobLegalDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}