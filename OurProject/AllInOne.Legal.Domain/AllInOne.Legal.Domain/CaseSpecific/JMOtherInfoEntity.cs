namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for JMOtherInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class JMOtherInfoEntity : AbstractLastModified, ICaseSpecificEntity
    {
        #region Properties
        
        /// <summary>
        /// Gets or sets the JMOther Info Id.
        /// </summary>
        /// <value>The JMOther Info Id.</value>
        public string JMOtherInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseInfoId field.
        /// </summary>
        /// <value>The case info id.</value>
        public string CaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is IPCRCompliedWith.
        /// </summary>
        /// <value>The is PCRCompliedWith.</value>
        public YesNo IsPCRCompliedWith
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AnyOther Info .
        /// </summary>
        /// <value>The AnyOtherInfoRem.</value>
        public string AnyOtherInfoRem
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the writ IsInfoSent.
        /// </summary>
        /// <value>The writ IsInfoSent.</value>
        public YesNo IsInfoSent
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

            JMOtherInfoEntity toCompareWith = obj as JMOtherInfoEntity;
            return toCompareWith == null ? false : ((this.JMOtherInfoId == toCompareWith.JMOtherInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.JMOtherInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}