namespace CrimsonLogic.Legal.Domain.Common
{
    using System;

    using CrimsonLogic.Legal.Domain.Abstract;
    using CrimsonLogic.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Common.ForeignUserRegistrationDetailsEntity'</summary>
    [Serializable]
    public class ForeignUserPracticeInformationEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        public string ForeignUserPracticeInfoId { get; set; }
        public string ForeignUserRegistrationId { get; set; }
        public string PartyId { get; set; }
        public string TypeOfDegree { get; set; }
        public string University { get; set; }
        public string IssuingCountry { get; set; }
        public DateTime ConferementOfDegree { get; set; }
        public string Qualification { get; set; }
        public string Remarks { get; set; }
        public YesNo ObsInd { get; set; }
        
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
            ForeignUserPracticeInformationEntity toCompareWith = obj as ForeignUserPracticeInformationEntity;
            return toCompareWith == null ? false : ((this.ForeignUserPracticeInfoId == toCompareWith.ForeignUserPracticeInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ForeignUserPracticeInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}