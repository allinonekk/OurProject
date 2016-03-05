namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.AASStatingObjOrNoObjDetailEntity'</summary>
    [Serializable]
    public class AASStatingObjOrNoObjDetailEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the AASStatingObjOrNoObjDetailId field. </summary>
        public String AASStatingObjOrNoObjDetailId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ActionDate field. </summary>
        public DateTime? ActionDate
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

        /// <summary>Gets or sets the DocId field. </summary>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MDocStatus field. </summary>
        public MDocStatusEntity MDocStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the RequestHRGDocId field. </summary>
        public String RequestHRGDocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UserId field. </summary>
        public String UserId
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
            AASStatingObjOrNoObjDetailEntity toCompareWith = obj as AASStatingObjOrNoObjDetailEntity;
            return toCompareWith == null ? false : ((this.AASStatingObjOrNoObjDetailId == toCompareWith.AASStatingObjOrNoObjDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AASStatingObjOrNoObjDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}