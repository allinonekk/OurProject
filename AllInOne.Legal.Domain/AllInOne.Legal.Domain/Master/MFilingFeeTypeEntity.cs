namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MFilingFeeEntity'</summary>
    [Serializable]
    public class MFilingFeeTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the CalculationType field. </summary>
        public String CalculationType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FeeTypeCode field. </summary>
        public String FeeTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FeeTypeName field. </summary>
        public String FeeTypeName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Formula field. </summary>
        public String Formula
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
            MFilingFeeTypeEntity toCompareWith = obj as MFilingFeeTypeEntity;
            return toCompareWith == null ? false : ((this.FeeTypeCode == toCompareWith.FeeTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FeeTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}