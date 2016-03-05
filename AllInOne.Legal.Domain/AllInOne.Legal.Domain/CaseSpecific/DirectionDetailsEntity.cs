namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for DirectionDetailsEntity.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class DirectionDetailsEntity : AbstractLastModified, ICaseSpecificEntity
    {
        #region Properties
        
        /// <summary>
        /// Gets or sets the HRGID Id.
        /// </summary>
        /// <value>The HRGID Id.</value>
        public String HRGID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseInfoId field.
        /// </summary>
        /// <value>The case info id.</value>
        public String CaseInfoID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is SubCaseInfoID.
        /// </summary>
        /// <value>The is SubCaseInfoID.</value>
        public String SubCaseInfoID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is DocID.
        /// </summary>
        /// <value>The is DocID.</value>
        public string DocID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is DirCode.
        /// </summary>
        /// <value>The is DirCode.</value>
        public string DirCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the writ ObsInd.
        /// </summary>
        /// <value>The writ ObsInd.</value>
        public YesNo ObsInd
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

            DirectionDetailsEntity toCompareWith = obj as DirectionDetailsEntity;
            return toCompareWith == null ? false : ((this.HRGID == toCompareWith.HRGID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HRGID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}