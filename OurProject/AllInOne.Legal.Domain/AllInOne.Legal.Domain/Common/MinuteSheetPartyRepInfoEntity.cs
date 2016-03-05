namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    [Serializable]
    public class MinuteSheetPartyRepInfoEntity : AbstractLastModified, ICommonEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MinuteSheetDocListEntity"/> class.</summary>
        public MinuteSheetPartyRepInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public String CasePartyId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGID field. </summary>
        public String MinuteSheetInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MinuteSheetInfoId field. </summary>
        public String MinuteSheetPartyRepInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the order made in.
        /// </summary>
        /// <value>The order made in.</value>
        public PartyRepresentationType PartyRepresentationType
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
            MinuteSheetPartyRepInfoEntity toCompareWith = obj as MinuteSheetPartyRepInfoEntity;
            return toCompareWith == null ? false : ((this.MinuteSheetPartyRepInfoId == toCompareWith.MinuteSheetPartyRepInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.MinuteSheetPartyRepInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}