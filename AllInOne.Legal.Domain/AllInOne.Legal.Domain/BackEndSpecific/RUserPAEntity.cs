namespace AllInOne.Legal.Domain.BackEndSpecific{
	using System;
	using System.Collections.Generic;
    using AllInOne.Legal.Domain.Interfaces;

	/// <summary>
	///	Generated by MyGeneration using the NHibernate Object Mapping template
	/// </summary>
	[Serializable]
    public class RUserPAEntity : IBackEndSpecificEntity
	{
        #region Properties

        public System.String UserId
        { get; set; }

        public System.String PAUserId
        { get; set; }

        public System.DateTime StartDate
        { get; set; }

        public Nullable<System.DateTime> EndDate
        { get; set; }

        public System.String ObsInd
        { get; set; }

        public System.String LastModifiedBy
        { get; set; }

        public System.DateTime LastModifiedDate
        { get; set; }

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
            RUserPAEntity toCompareWith = obj as RUserPAEntity;
            return toCompareWith == null ? false : ((this.UserId == toCompareWith.UserId) && (this.PAUserId == toCompareWith.PAUserId) && (this.StartDate == toCompareWith.StartDate));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.UserId.GetHashCode();
            toReturn ^= this.PAUserId.GetHashCode();
            toReturn ^= this.StartDate.GetHashCode();
            return toReturn;
        }
        #endregion Methods
	}
}
