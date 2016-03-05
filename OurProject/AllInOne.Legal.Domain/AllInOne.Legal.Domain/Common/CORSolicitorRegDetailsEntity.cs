namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.CORSolicitorRegDetailsEntity'</summary>
    [Serializable]
    public class CORSolicitorRegDetailsEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        public String CORSolicitorRegDetailsId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CORSolicitorRegId field. </summary>
        public String CORSolicitorRegId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PCInfoID field. </summary>
        public String PCInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId id.</value>
        public Int64 SubCaseInfoId
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
            CORSolicitorRegDetailsEntity toCompareWith = obj as CORSolicitorRegDetailsEntity;
            return toCompareWith == null ? false : ((this.CORSolicitorRegDetailsId == toCompareWith.CORSolicitorRegDetailsId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CORSolicitorRegId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}