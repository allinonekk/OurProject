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

    /// <summary>Class which represents the entity 'Master.MFormProcess'</summary>
    public partial class MFormProcess : IMaster
    {
        #region Fields

        private System.String _dOCCODE;
        private System.String _iNSTANCECLASSNAME;
        private System.String _mANAGERCLASSNAME;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MFormProcess"/> class.</summary>
        public MFormProcess()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the DOCCODE field. </summary>
        public virtual System.String DOCCODE
        {
            get { return _dOCCODE; }
            set { _dOCCODE = value; }
        }

        /// <summary>Gets or sets the INSTANCECLASSNAME field. </summary>
        public virtual System.String INSTANCECLASSNAME
        {
            get { return _iNSTANCECLASSNAME; }
            set { _iNSTANCECLASSNAME = value; }
        }

        /// <summary>Gets or sets the MANAGERCLASSNAME field. </summary>
        public virtual System.String MANAGERCLASSNAME
        {
            get { return _mANAGERCLASSNAME; }
            set { _mANAGERCLASSNAME = value; }
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
            MFormProcess toCompareWith = obj as MFormProcess;
            return toCompareWith == null ? false : ((this.DOCCODE == toCompareWith.DOCCODE));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DOCCODE.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}