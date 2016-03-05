namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;
    using System.Collections;

    using AllInOne.Legal.Domain.Interfaces;

    [Serializable]
    public class EFilingTransactionViewEntity : IFrontEndSpecificEntity
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

        public string DocNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DisplayName field.
        /// </summary>
        /// <value>The doc title.</value>
        public String DocTitle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NumberOfPages field.
        /// </summary>
        /// <value>The number of pages.</value>
        public Decimal NoOfPages
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FilingDateTime field.
        /// </summary>
        /// <value>The actual filing date time.</value>
        public DateTime FilingDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group Id.</value>
        public String SubmissionGroupID
        {
            get;
            set;
        }

        public string DocID
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Document.DocumentInfo.MDocStatus - Master.MDocStatus.DocumentInfos (m:1)'
        /// </summary>
        /// <value>The M doc status.</value>
        public String DocStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FiledBy field.
        /// </summary>
        /// <value>The filed by.</value>
        public String FiledBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFID field.
        /// </summary>
        /// <value>The LFID.</value>
        public String LFID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the organization.
        /// </summary>
        /// <value>The name of the organization.</value>
        public string OrganizationName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the send from front end.
        /// </summary>
        /// <value>The send from front end.</value>
        public string SentFromFE
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the outgoing remarks.
        /// </summary>
        /// <value>The outgoing remarks.</value>
        public string OutgoingRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the reply from court.
        /// </summary>
        /// <value>The reply from court.</value>
        public string ReplyFromCourt
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the incoming remarks.
        /// </summary>
        /// <value>The incoming remarks.</value>
        public string IncomingRemarks
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// The method accepts an object as a parameter and returns an integer.
        /// Added by Rajeev KK.
        /// </summary>
        /// <param name="toCompareDocInfoEntity">DocumentInfoEntity object as a parameter for compare.</param>
        /// <returns>
        /// A return value of zero means that the two objects we are comparing are equal to each other.
        /// A negative return value means that the first object comes before the second object.
        /// A positive return value means that the first object comes after the second object.
        /// </returns>
        public int CompareTo(EFilingTransactionViewEntity toCompareDocInfoEntity)
        {
            if (toCompareDocInfoEntity == null)
                return 0;

            if (this.DocID != null)
            {
                int result = this.DocID.CompareTo(toCompareDocInfoEntity.DocID);
                if (result == 0)
                    result = this.DocID.CompareTo(toCompareDocInfoEntity.DocID);
                return result;
            }
            else
                return 0;
        }

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            EFilingTransactionViewEntity toCompareWith = obj as EFilingTransactionViewEntity;
            return toCompareWith == null ? false : ((this.DocID == toCompareWith.DocID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}