namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.Abstract;


    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class NumberOfJudgeAssignDetailHistoryEntity :AbstractLastModified, IBackEndSpecificEntity
    {
        #region Properties


        /// <summary>
        /// Gets or sets the number of judge assign detail id.
        /// </summary>
        /// <value>The number of judge assign detail id.</value>
        public string NumberOfJudgeAssignDetailHistoryId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the case info id.
        /// </summary>
        /// <value>The case info id.</value>
        public string NumberOfJudgeAssignDetailId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the sub case info id.
        /// </summary>
        /// <value>The sub case info id.</value>
        public Int64 ItemNo
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public string HistoryRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the track.
        /// </summary>
        /// <value>The track.</value>
        public Int64 Track
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the name of the JLC.
        /// </summary>
        /// <value>The name of the JLC.</value>
        public string JLCName
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the is JLC.
        /// </summary>
        /// <value>The is JLC.</value>
        public YesNo IsJLC
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
            NumberOfJudgeAssignDetailHistoryEntity toCompareWith = obj as NumberOfJudgeAssignDetailHistoryEntity;
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