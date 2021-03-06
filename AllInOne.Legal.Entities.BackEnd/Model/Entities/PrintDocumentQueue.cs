﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>Class which represents the entity 'PrintDocumentQueue'</summary>
    public partial class PrintDocumentQueue : ICommon
    {
        #region Fields

        private System.String _printDocumentQueueId;
        private System.String _docId;
        private System.String _filePath;
        private System.String _jobType;
        private System.String _targetPrinterName;
        private System.String _status;
        private System.String _printRemarks;
        private System.String _docConversionRemarks;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="PrintDocumentQueue"/> class.</summary>
        public PrintDocumentQueue()
            : base()
        {}

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the PrintDocumentQueueId field. </summary>
        public virtual System.String PrintDocumentQueueId
        {
            get { return _printDocumentQueueId; }
            set { _printDocumentQueueId = value; }
        }

        /// <summary>Gets or sets the DocId field. </summary>
        public virtual System.String DocId
        {
            get { return _docId; }
            set { _docId = value; }
        }

        /// <summary>Gets or sets the FilePath field. </summary>
        public virtual System.String FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        /// <summary>Gets or sets the JobType field. </summary>
        public virtual System.String JobType
        {
            get { return _jobType; }
            set { _jobType = value; }
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get { return _lastModifiedBy; }
            set { _lastModifiedBy = value; }
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get { return _lastModifiedDate; }
            set { _lastModifiedDate = value; }
        }

        /// <summary>Gets or sets the TargetPrinterName field. </summary>
        public virtual System.String TargetPrinterName
        {
            get { return _targetPrinterName; }
            set { _targetPrinterName = value; }
        }

        /// <summary>Gets or sets the Status field. </summary>
        public virtual System.String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>Gets or sets the PrintRemarks field. </summary>
        public virtual System.String PrintRemarks
        {
            get { return _printRemarks; }
            set { _printRemarks = value; }
        }

        /// <summary>Gets or sets the DocConversionRemarks field. </summary>
        public virtual System.String DocConversionRemarks
        {
            get { return _docConversionRemarks; }
            set { _docConversionRemarks = value; }
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
            PrintDocumentQueue toCompareWith = obj as PrintDocumentQueue;
            return toCompareWith == null ? false : ((this.PrintDocumentQueueId == toCompareWith.PrintDocumentQueueId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PrintDocumentQueueId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}