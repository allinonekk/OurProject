namespace AllInOne.Legal.Domain.CaseSpecific
{
    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using System;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class CaseRegisterEntity : AbstractCaseInfo, ICaseSpecificEntity
    {
        #region Properties

        public string CaseRegisterId { get; set; }

        public MForumTypeEntity MForumTypeEntity
        {
            get;
            set;
        }
        public int ItemNo
        {
            get;
            set;
        }
        public DateTime CommencementDate
        {
            get;
            set;
        }
        public DateTime? DisposedDate
        {
            get;
            set;
        }
        public MPartyStatusEntity MPartyStatusEntity
        {
            get;
            set;
        }
        public YesNo IsCurrentLife
        {
            get;
            set;
        }

        public YesNo ObsInd
        {
            get;
            set;
        }

        public string Remarks
        {
            get;
            set;
        }
        public string CRCaseTypeCode { get; set; }
       
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
            CaseRegisterEntity toCompareWith = obj as CaseRegisterEntity;
            return toCompareWith == null ? false : ((this.CaseRegisterId == toCompareWith.CaseRegisterId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseRegisterId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}