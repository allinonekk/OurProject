namespace AllInOne.Legal.Domain.Master
{

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Abstract;

    /// <summary>Class which represents the entity 'Master.MChargeOutcomeEntity'</summary>
    public class MChargeOutcomeEntity : AbstractMasterInfo,IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the OutcomeCode field. </summary>
        public string OutcomeCode
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
            MChargeOutcomeEntity toCompareWith = obj as MChargeOutcomeEntity;
            return toCompareWith == null ? false : ((this.OutcomeCode == toCompareWith.OutcomeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.OutcomeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}