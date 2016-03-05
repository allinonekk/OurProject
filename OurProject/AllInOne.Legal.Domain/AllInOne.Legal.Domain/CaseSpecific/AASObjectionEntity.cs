namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.AASObjectionEntity'</summary>
    public class AASObjectionEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the AASObjectionId field. </summary>
        public String AASObjectionId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BLEObjection field. </summary>
        public YesNo BLEObjection
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public String CaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LawSocObjection field. </summary>
        public YesNo LawSocObjection
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PublicObjection field. </summary>
        public YesNo PublicObjection
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SALObjection field. </summary>
        public YesNo SALObjection
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
            AASObjectionEntity toCompareWith = obj as AASObjectionEntity;
            return toCompareWith == null ? false : ((this.AASObjectionId == toCompareWith.AASObjectionId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AASObjectionId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}