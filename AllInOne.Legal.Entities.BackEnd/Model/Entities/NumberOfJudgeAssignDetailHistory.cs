namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class NumberOfJudgeAssignDetailHistory : IBackEndSpecific
    {
        #region Properties


        /// <summary>
        /// Gets or sets the number of judge assign detail id.
        /// </summary>
        /// <value>The number of judge assign detail id.</value>
        public virtual string NumberOfJudgeAssignDetailHistoryId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the case info id.
        /// </summary>
        /// <value>The case info id.</value>
        public virtual string NumberOfJudgeAssignDetailId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the sub case info id.
        /// </summary>
        /// <value>The sub case info id.</value>
        public virtual Int64 ItemNo
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public virtual string HistoryRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified date.
        /// </summary>
        /// <value>The last modified date.</value>
        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the track.
        /// </summary>
        /// <value>The track.</value>
        public virtual int Track
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the name of the JLC.
        /// </summary>
        /// <value>The name of the JLC.</value>
        public virtual string JLCName
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the is JLC.
        /// </summary>
        /// <value>The is JLC.</value>
        public virtual string IsJLC
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
            NumberOfJudgeAssignDetailHistory toCompareWith = obj as NumberOfJudgeAssignDetailHistory;
            return toCompareWith == null ? false : ((this.NumberOfJudgeAssignDetailHistoryId == toCompareWith.NumberOfJudgeAssignDetailHistoryId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NumberOfJudgeAssignDetailHistoryId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}