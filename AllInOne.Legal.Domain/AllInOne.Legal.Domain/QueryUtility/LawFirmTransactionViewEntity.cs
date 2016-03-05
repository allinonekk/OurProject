namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;
    using System.Collections;

    using AllInOne.Legal.Domain.Interfaces;

    [Serializable]
    public class LawFirmTransactionViewEntity : IFrontEndSpecificEntity
    {
        #region Properties

       
        /// <summary>
        /// Gets or sets the CaseNo field.
        /// </summary>
        /// <value>The DocId.</value>
        public String CaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocId field.
        /// </summary>
        /// <value>The DocId.</value>
        public String DocNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocSerialNo field.
        /// </summary>
        /// <value>The doc serial no.</value>
        public String DocTitle
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Document.DocumentInfo.MDocStatus - Master.MDocStatus.DocumentInfos (m:1)'
        /// </summary>
        /// <value>The M doc status.</value>
        public DateTime FilingDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DisplayName field.
        /// </summary>
        /// <value>The doc title.</value>
        public String SubmissionGroupID
        {
            get;
            set;
        }

        
        /// <summary>
        /// Gets or sets the DocType field.
        /// </summary>
        /// <value>The type of the doc.</value>
        public String FiledBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocYear field.
        /// </summary>
        /// <value>The doc year.</value>
        public String Status
        {
            get;
            set;
        }

        public string LFID
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
            LawFirmTransactionViewEntity toCompareWith = obj as LawFirmTransactionViewEntity;
            return toCompareWith == null ? false : ((this.SubmissionGroupID == toCompareWith.SubmissionGroupID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SubmissionGroupID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}