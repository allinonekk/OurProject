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
    public class ArchiveNumberOfJudgeAssignDetailHistoryEntity :AbstractLastModified, IBackEndSpecificEntity
    {
        #region Properties


        /// <summary>
        /// Gets or sets the number of judge assign detail id.
        /// </summary>
        /// <value>The number of judge assign detail id.</value>
        public string ArchiveNumberOfJudgeAssignDetailHistoryId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the case info id.
        /// </summary>
        /// <value>The case info id.</value>
        public string ArchiveNumberOfJudgeAssignDetailId
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
            ArchiveNumberOfJudgeAssignDetailHistoryEntity toCompareWith = obj as ArchiveNumberOfJudgeAssignDetailHistoryEntity;
            return toCompareWith == null ? false : ((this.ArchiveNumberOfJudgeAssignDetailHistoryId == toCompareWith.ArchiveNumberOfJudgeAssignDetailHistoryId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ArchiveNumberOfJudgeAssignDetailHistoryId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}