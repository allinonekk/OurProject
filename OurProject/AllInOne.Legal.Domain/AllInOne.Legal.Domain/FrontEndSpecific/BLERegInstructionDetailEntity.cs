namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'FrontEndSpecific.BLERegInstructionDetailEntity'</summary>
    public class BLERegInstructionDetailEntity : AbstractSubmissionGroup, IFrontEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the BLERegInstructionDetailId field.
        /// </summary>
        /// <value>The BLERegInstructionDetailId.</value>
        public String BLERegInstructionDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsAcademicTranscripts field.
        /// </summary>
        /// <value>The IsAcademicTranscripts.</value>
        public YesNo IsAcademicTranscripts
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsDegreeCert.
        /// </summary>
        /// <value>The IsDegreeCert.</value>
        public YesNo IsDegreeCert
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsLawDegreeFromAusNZUS field.
        /// </summary>
        /// <value>The IsLawDegreeFromAusNZUS.</value>
        public YesNo IsLawDegreeFromAusNZUS
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsLawDegreeFromNUS field.
        /// </summary>
        /// <value>The IsLawDegreeFromNUS.</value>
        public YesNo IsLawDegreeFromNUS
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsLawDegreeFromUKIreland field.
        /// </summary>
        /// <value>The IsLawDegreeFromUKIreland.</value>
        public YesNo IsLawDegreeFromUKIreland
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsLetterOfExemptionFromML field.
        /// </summary>
        /// <value>The IsLetterOfExemptionFromML.</value>
        public YesNo IsLetterOfExemptionFromML
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsProofOfCitizenship field.
        /// </summary>
        /// <value>The IsProofOfCitizenship.</value>
        public YesNo IsProofOfCitizenship
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsProofOfSingaporePR field.
        /// </summary>
        /// <value>The IsProofOfSingaporePR.</value>
        public YesNo IsProofOfSingaporePR
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsReceivedLegalTraining field.
        /// </summary>
        /// <value>The IsReceivedLegalTraining.</value>
        public YesNo IsReceivedLegalTraining
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsSingaporeBarExamPassed field.
        /// </summary>
        /// <value>The IsSingaporeBarExamPassed.</value>
        public YesNo IsSingaporeBarExamPassed
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CheckListInstanceID field.
        /// </summary>
        /// <value>The check list instance id.</value>
        public YesNo IsTrueCopyForMalayanPrac
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsTrueCopyForMalayanPracSec field.
        /// </summary>
        /// <value>The IsTrueCopyForMalayanPracSec.</value>
        public YesNo IsTrueCopyForMalayanPracSec
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

            BLERegInstructionDetailEntity toCompareWith = obj as BLERegInstructionDetailEntity;
            return toCompareWith == null ? false : ((this.BLERegInstructionDetailId == toCompareWith.BLERegInstructionDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BLERegInstructionDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}