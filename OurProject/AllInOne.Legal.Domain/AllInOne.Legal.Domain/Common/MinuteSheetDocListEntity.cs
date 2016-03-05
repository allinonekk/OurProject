namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    [Serializable]
    public class MinuteSheetDocListEntity : AbstractLastModified, ICommonEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MinuteSheetDocListEntity"/> class.</summary>
        public MinuteSheetDocListEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the DocId field. </summary>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MinuteSheetDocListId field. </summary>
        public String MinuteSheetDocListId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MinuteSheetInfoId field. </summary>
        public String MinuteSheetInfoId
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
            MinuteSheetDocListEntity toCompareWith = obj as MinuteSheetDocListEntity;
            return toCompareWith == null ? false : ((this.MinuteSheetDocListId == toCompareWith.MinuteSheetDocListId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.MinuteSheetDocListId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}