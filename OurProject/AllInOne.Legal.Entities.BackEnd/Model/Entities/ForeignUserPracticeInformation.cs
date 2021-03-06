﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

    /// <summary>Class which represents the entity 'Common.ForeignUserPracticeInformation'</summary>
    [Serializable]
    public partial class ForeignUserPracticeInformation : ICommon
    {

        #region Constructors
        /// <summary> /// Initializes a new instance of the <see cref="ForeignUserPracticeInformation"/> class./// </summary>
        public ForeignUserPracticeInformation()
            : base()
        {

        }
        #endregion Constructors

        #region Properties

        public virtual string ForeignUserPracticeInfoId { get; set; }
        public virtual string PartyId { get; set; }
        public virtual string TypeOfDegree { get; set; }
        public virtual string University { get; set; }
        public virtual string IssuingCountry { get; set; }
        public virtual DateTime ConferementOfDegree { get; set; }
        public virtual string Qualification { get; set; }
        public virtual string Remarks { get; set; }
        public virtual string ObsInd { get; set; }
        public virtual string LastModifiedBy { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }
        public virtual string RegistrationOfForeignLawyerId { get; set; }
        public virtual decimal? YearOfConferement { get; set; }
        public virtual decimal? AdmissionYear { get; set; }
        public virtual string InformationType { get; set; }
        public virtual System.Int32 SequenceNo { get; set; }

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
            ForeignUserPracticeInformation toCompareWith = obj as ForeignUserPracticeInformation;
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