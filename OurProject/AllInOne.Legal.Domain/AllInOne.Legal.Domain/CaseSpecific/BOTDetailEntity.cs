namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Case.BOTDetail'</summary>
    [Serializable]
    public class BOTDetailEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the BOTRemarks field. </summary>
        public String BOTRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MBasisOfTaxationType field. </summary>
        public MBasisOfTaxationTypeEntity MBasisOfTaxationType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TaxationBOTDetailId field. </summary>
        public String TaxationBOTDetailId
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
            BOTDetailEntity toCompareWith = obj as BOTDetailEntity;
            return toCompareWith == null ? false : ((this.TaxationBOTDetailId == toCompareWith.TaxationBOTDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.TaxationBOTDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}