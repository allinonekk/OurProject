namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;
    using System.Text;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    [Serializable]
    public class DocumentInfoViewEntity : IFrontEndSpecificEntity
    {
        #region Properties

        public  String DocID
        {
            get;set;
        }

        public  String FormType
        {
            get;set;
        }

        public  String IsUrgent
        {
            get;set;
        }

        public  DateTime LastModifiedDate
        {
            get;set;
        }

        public  String ParentDocID
        {
            get;set;
        }

        public  String ProcessType
        {
            get;set;
        }

        public  Int64 SubCaseInfoID
        {
            get;set;
        }

        public  String SubmissionGroupId
        {
            get;set;
        }

        public String FiledBy
        {
            get;set;
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            DocumentInfoViewEntity toCompareWith = obj as DocumentInfoViewEntity;
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

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("DocID=").Append(DocID).Append("--")
                .Append("FormType=").Append(FormType).Append("--")
                .Append("ProcessType=").Append(ProcessType).Append("--")
                .Append("SubCaseInfoID=").Append(SubCaseInfoID).Append("--")
                .Append("ParentDocID=").Append(ParentDocID).Append("--")
                .Append("IsUrgent=").Append(IsUrgent).Append("--");

            return str.ToString();
        }

        #endregion Methods
    }
}