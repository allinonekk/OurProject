namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    [Serializable]
    public class MinuteSheetInfoEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public String CaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HearingCategory field. </summary>
        public HearingCategory HearingCategory
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGID field. </summary>
        public Int64 HRGID
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

        /// <summary>Gets or sets the NoteOfEvidence field. </summary>
        public String NoteOfEvidence
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OrderMadeIn field. </summary>
        public OrderMadeIn OrderMadeIn
        {
            get;
            set;
        }

        /// <summary>Gets or sets the RegistryInstruction field. </summary>
        public String RegistryInstruction
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SessionProceedingStatus field. </summary>
        public String SessionProceedingStatus
        {
            get;
            set;
        }

        public string InstrToFrcAndCapsStaff
        {
            get;
            set;
        }

        public SubCaseRequestInd RequestForSubCaseInd { get; set; }

        public YesNo RequestForSplLetterInd { get; set; }

        public string OtherDirections { get; set; }

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
            MinuteSheetInfoEntity toCompareWith = obj as MinuteSheetInfoEntity;
            return toCompareWith == null ? false : ((this.MinuteSheetInfoId == toCompareWith.MinuteSheetInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.MinuteSheetInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}