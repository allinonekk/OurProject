namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Common.PCConditionInfoEntity'</summary>
    [Serializable]
    public class PCConditionInfoEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the AGCProcDateTime field. </summary>
        public System.DateTime? AGCProcDateTime
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Description field. </summary>
        public String Description
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HasJudicialOffUpdated field. </summary>
        public YesNo HasJudicialOffUpdated
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsAGCApproved field. </summary>
        public YesNo IsAGCApproved
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsLAWSOCApproved field. </summary>
        public YesNo IsLAWSOCApproved
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsSALApproved field. </summary>
        public YesNo IsSALApproved
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public System.Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LAWSOCProcDateTime field. </summary>
        public System.DateTime? LAWSOCProcDateTime
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PCConditionInfoId field. </summary>
        public String PCConditionInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SALProcDateTime field. </summary>
        public System.DateTime? SALProcDateTime
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
            PCConditionInfoEntity toCompareWith = obj as PCConditionInfoEntity;
            return toCompareWith == null ? false : ((this.PCConditionInfoId == toCompareWith.PCConditionInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PCConditionInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}