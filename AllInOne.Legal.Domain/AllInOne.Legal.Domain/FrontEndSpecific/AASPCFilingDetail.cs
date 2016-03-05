namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'FrontEndSpecific.AASPCFilingDetailEntity'</summary>
    public class AASPCFilingDetailEntity : AbstractSubmissionGroup, IFrontEndSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the AASPCFilingDetailId field. </summary>
        public System.String AASPCFilingDetailId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AASPCFilingType field. </summary>
        public System.String AASPCFilingType
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
            AASPCFilingDetailEntity toCompareWith = obj as AASPCFilingDetailEntity;
            return toCompareWith == null ? false : ((this.AASPCFilingDetailId == toCompareWith.AASPCFilingDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AASPCFilingDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}