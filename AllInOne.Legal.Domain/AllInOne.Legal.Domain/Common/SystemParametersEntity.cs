namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.SystemParametersEntity'</summary>
    [Serializable]
    public class SystemParametersEntity : AbstractMasterInfo, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the ConfigKey field. </summary>
        public String ConfigKey
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ConfigType field. </summary>
        public String ConfigType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ModuleName field. </summary>
        public String ModuleName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Value field. </summary>
        public String Value
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
            SystemParametersEntity toCompareWith = obj as SystemParametersEntity;
            return toCompareWith == null ? false : ((this.ConfigKey == toCompareWith.ConfigKey));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ConfigKey.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}