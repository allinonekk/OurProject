namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.AreaOfLegalPracticeEntity'</summary>
    [Serializable]
    public class AreaOfLegalPracticeEntity : AbstractSubmissionGroup, ISubCaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the AreaOfLegalPracticeId field. </summary>
        public System.String AreaOfLegalPracticeId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EndDate field. </summary>
        public Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsForeignLawPractice field. </summary>
        public YesNo IsForeignLawPractice
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MCountry field. </summary>
        public MCountryEntity MCountry
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.AreaOfLegalPractice.MLegalPractice - Master.MLegalPractice.AreaOfLegalPractices (m:1)'</summary>
        public MLegalPracticeEntity MLegalPractice
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ReasonForCeasing field. </summary>
        public String ReasonForCeasing
        {
            get;
            set;
        }

        /// <summary>Gets or sets the StartDate field. </summary>
        public Nullable<System.DateTime> StartDate
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
            AreaOfLegalPracticeEntity toCompareWith = obj as AreaOfLegalPracticeEntity;
            return toCompareWith == null ? false : ((this.AreaOfLegalPracticeId == toCompareWith.AreaOfLegalPracticeId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AreaOfLegalPracticeId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}