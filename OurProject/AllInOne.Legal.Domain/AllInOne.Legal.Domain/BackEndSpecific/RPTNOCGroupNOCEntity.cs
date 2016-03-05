namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class RPTNOCGroupNOCEntity:IBackEndSpecificEntity
    {
        #region Properties


        /// <summary>
        /// Gets or sets the RPTNOC group NOC code.
        /// </summary>
        /// <value>The RPTNOC group NOC code.</value>
        public string RPTNOCGroupNOCCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the noc group code.
        /// </summary>
        /// <value>The noc group code.</value>
        public string NocGroupCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NOC code.
        /// </summary>
        /// <value>The NOC code.</value>
        public string NOCCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the obsInd.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedDate.
        /// </summary>
        /// <value>The LastModifiedDate.</value>
        public DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public string LastModifiedBy
        {
            get;
            set;
        }

        public string ActCode
        {
            get;
            set;
        }

        public string NocGroupName
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
            RPTNOCGroupNOCEntity toCompareWith = obj as RPTNOCGroupNOCEntity;
            return toCompareWith == null ? false : ((this.RPTNOCGroupNOCCode == toCompareWith.RPTNOCGroupNOCCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RPTNOCGroupNOCCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods

    }
}