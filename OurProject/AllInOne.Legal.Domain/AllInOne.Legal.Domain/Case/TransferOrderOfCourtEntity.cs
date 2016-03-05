namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for TransferOrderOfCourt.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class TransferOrderOfCourtEntity : AbstractLastModified, ICaseEntity
    {
        #region Properties

        /// <summary>Gets or sets the TransferOrderOfCourtId field. </summary>
        public String TransferOrderOfCourtId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkedDate field. </summary>
        public String CaseInfoID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkedDate field. </summary>
        public String OrderCaseNo
        {
            get;
            set;
        }

        public DateTime? OrderMadeHrgDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public string CoramName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CrossCourtInd field. </summary>
        public MDesignationEntity MDesignationEntity
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkedDate field. </summary>
        public String ORCRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkedDate field. </summary>
        public YesNo ObsInd
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

            TransferOrderOfCourtEntity toCompareWith = obj as TransferOrderOfCourtEntity;
            return toCompareWith == null ? false : (this.TransferOrderOfCourtId == toCompareWith.TransferOrderOfCourtId);
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.TransferOrderOfCourtId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}