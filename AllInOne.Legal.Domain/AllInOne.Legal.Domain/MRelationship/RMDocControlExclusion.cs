namespace AllInOne.Legal.Domain.MRelationship
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using System.Collections.Generic;
    using AllInOne.Legal.Domain.Master;


    /// <summary>Class which represents the entity 'Master.RMDocControlExclusionEntity'</summary>
    [Serializable]
    public class RMDocControlExclusionEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

        public string RMDocControlExclusionId { get; set; }
        public MForumTypeEntity ForumID { get; set; }
        public MCaseTypeEntity CaseTypeCode { get; set; }
        public MCaseTypeEntity SubCaseTypeCode { get; set; }
        public MDocCodeEntity DocCode { get; set; }
        public YesNo IsInterfaced { get; set; }

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
            RMDocControlExclusionEntity toCompareWith = obj as RMDocControlExclusionEntity;
            return toCompareWith == null ? false : ((this.RMDocControlExclusionId == toCompareWith.RMDocControlExclusionId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RMDocControlExclusionId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}