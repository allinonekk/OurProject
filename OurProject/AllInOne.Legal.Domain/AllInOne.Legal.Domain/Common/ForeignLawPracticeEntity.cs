namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Common.ForeignLawPracticeEntity'</summary>
    public class ForeignLawPracticeEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the ForeignLawPracticeId field. </summary>
        public System.String ForeignLawPracticeId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NameForeignLawPractice field. </summary>
        public System.String NameForeignLawPractice
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
            ForeignLawPracticeEntity toCompareWith = obj as ForeignLawPracticeEntity;
            return toCompareWith == null ? false : ((this.ForeignLawPracticeId == toCompareWith.ForeignLawPracticeId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ForeignLawPracticeId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}