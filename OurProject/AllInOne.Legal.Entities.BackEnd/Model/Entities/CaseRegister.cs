namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class CaseRegister: ICaseSpecific
    {
        #region Properties

        public virtual string CaseRegisterId { get; set; }

        public virtual MForumType MForumType
        {
            get;
            set;
        }
        public virtual int ItemNo
        {
            get;
            set;
        }
        public virtual DateTime CommencementDate
        {
            get;
            set;
        }
        public virtual DateTime? DisposedDate
        {
            get;
            set;
        }
        public virtual MPartyStatus MPartyStatus
        {
            get;
            set;
        }
        public virtual string IsCurrentLife
        {
            get;
            set;
        }

        public virtual string ObsInd
        {
            get;
            set;
        }

        public virtual string Remarks
        {
            get;
            set;
        }

        public virtual long CaseInfoId { get; set; }

        public virtual string LastModifiedBy { get; set; }

        public virtual DateTime LastModifiedDate { get; set; }

        public virtual string CRCaseTypeCode { get; set; }
       
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
            CaseRegister toCompareWith = obj as CaseRegister;
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