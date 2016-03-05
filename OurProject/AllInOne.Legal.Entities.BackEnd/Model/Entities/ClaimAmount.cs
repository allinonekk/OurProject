namespace AllInOne.Legal.Entities.BackEnd
{

    using System;

     
    public partial  class ClaimAmount: ICommon
    {
        #region Properties

        /// <summary>Gets or sets the AdmissionOn field. </summary>
        public virtual  Int64 CaseInfoId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the doc id.
        /// </summary>
        /// <value>The doc id.</value>
        public virtual string DocId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the DOC code.
        /// </summary>
        /// <value>The DOC code.</value>
        public virtual string DOCCode
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the type of the claim.
        /// </summary>
        /// <value>The type of the claim.</value>
        public virtual string ClaimType
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        public virtual decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public virtual string LastModifiedBy
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the last modified date.
        /// </summary>
        /// <value>The last modified date.</value>
        public virtual DateTime LastModifiedDate
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
            ClaimAmount toCompareWith = obj as ClaimAmount;
            return toCompareWith == null ? false : ((this.CaseInfoId == toCompareWith.CaseInfoId)
                && (this.DOCCode == toCompareWith.DOCCode)
                && (this.DocId == toCompareWith.DocId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseInfoId.GetHashCode();
            toReturn ^= this.DOCCode.GetHashCode();
            toReturn ^= this.DocId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}