namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MPrinterEntity'</summary>
    [Serializable]
    public class MPrinterEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the ModuleCode field. </summary>
        public System.String ModuleCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ModuleDescription field. </summary>
        public System.String ModuleDescription
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PrinterName field. </summary>
        public System.String PrinterName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PrinterDescription field. </summary>
        public System.String PrinterDescription
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public System.DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public System.String ObsInd
        {
            get;
            set;
        }
        
        /// <summary>Gets or sets the EmailAddress field. </summary>
        public System.String EmailAddress
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DeliveryMode field. </summary>
        public System.String DeliveryMode
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
            if(obj == null)
            {
                return false;
            }
            MPrinterEntity toCompareWith = obj as MPrinterEntity;
            return toCompareWith == null ? false : ((this.ModuleCode == toCompareWith.ModuleCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ModuleCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}