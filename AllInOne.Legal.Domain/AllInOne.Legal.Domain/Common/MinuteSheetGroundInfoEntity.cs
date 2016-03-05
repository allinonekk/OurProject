namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    [Serializable]
    public class MinuteSheetGroundInfoEntity : AbstractLastModified, ICommonEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MinuteSheetDocListEntity"/> class.</summary>
        public MinuteSheetGroundInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the IJMadeFinalAfter field. </summary>
        public ClaimForPNOrDef ClaimForPNOrDef
        {
            get;
            set;
        }

        public YesNo Is3YearsSeparationWithConsent
        {
            get;
            set;
        }

        public YesNo Is4YearsSeparation
        {
            get;
            set;
        }

        public YesNo IsAdultery
        {
            get;
            set;
        }

        public YesNo IsDesertionFor2Years
        {
            get;
            set;
        }

        public ClaimForPNOrDef IsNonConsummationFor
        {
            get;
            set;
        }

        public YesNo IsNonConsummationOwingToInCap
        {
            get;
            set;
        }

        public YesNo IsNonConsummationRefused
        {
            get;
            set;
        }

        public YesNo IsOthers
        {
            get;
            set;
        }

        public YesNo IsUnreasonableBehavior
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MinuteSheetInfoId field. </summary>
        public String MinuteSheetGroundInfoId
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

        public String OtherRemarks
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
            MinuteSheetGroundInfoEntity toCompareWith = obj as MinuteSheetGroundInfoEntity;
            return toCompareWith == null ? false : ((this.MinuteSheetGroundInfoId == toCompareWith.MinuteSheetGroundInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.MinuteSheetGroundInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}