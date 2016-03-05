namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    [Serializable]
    public class MinuteSheetDocList : ICommon
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MinuteSheetDocList"/> class.</summary>
        public MinuteSheetDocList()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the DocId field. </summary>
        public virtual System.String DocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MinuteSheetDocListId field. </summary>
        public virtual System.String MinuteSheetDocListId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MinuteSheetInfoId field. </summary>
        public virtual System.String MinuteSheetInfoId
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
            MinuteSheetDocList toCompareWith = obj as MinuteSheetDocList;
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