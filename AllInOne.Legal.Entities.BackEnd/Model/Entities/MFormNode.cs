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

    /// <summary>Class which represents the entity 'Master.MFormNode'</summary>
    public partial class MFormNode : IMaster
    {
        #region Fields

        private System.String _docCode;
        private System.String _isMandatoryInd;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.Int32 _nodeItemNo;
        private System.String _nodeName;
        private System.String _nodePath;
        private System.String _obsInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MFormNode"/> class.</summary>
        public MFormNode()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the DocCode field. </summary>
        public virtual System.String DocCode
        {
            get { return _docCode; }
            set { _docCode = value; }
        }

        /// <summary>Gets or sets the IsMandatoryInd field. </summary>
        public virtual System.String IsMandatoryInd
        {
            get { return _isMandatoryInd; }
            set { _isMandatoryInd = value; }
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

        /// <summary>Gets or sets the NodeItemNo field. </summary>
        public virtual System.Int32 NodeItemNo
        {
            get { return _nodeItemNo; }
            set { _nodeItemNo = value; }
        }

        /// <summary>Gets or sets the NodeName field. </summary>
        public virtual System.String NodeName
        {
            get { return _nodeName; }
            set { _nodeName = value; }
        }

        /// <summary>Gets or sets the NodePath field. </summary>
        public virtual System.String NodePath
        {
            get { return _nodePath; }
            set { _nodePath = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
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
            MFormNode toCompareWith = obj as MFormNode;
            return toCompareWith == null ? false : ((this.NodeItemNo == toCompareWith.NodeItemNo));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NodeItemNo.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}