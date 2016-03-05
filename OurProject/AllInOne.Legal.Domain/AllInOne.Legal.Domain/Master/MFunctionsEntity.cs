#region Header

/*****************************************************************************************************
* Description : This file represents a standard MFunctions entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MFunctionsEntity.cs
// Description: Represents a standard MFunctions entity.
// </summary>
// <copyright file= "MFunctionsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MFunctions.
    /// </summary>
    [Serializable]
    public class MFunctionsEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        public DenyAccessType DenyAccessType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FunctionCode field. </summary>
        public System.String FunctionCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FunctionName field. </summary>
        public System.String FunctionControlName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FunctionName field. </summary>
        public System.String FunctionName
        {
            get;
            set;
        }

        public YesNo IsForMenu
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MenuId field. </summary>
        public System.String MenuId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MenuURL field. </summary>
        public String MenuURL
        {
            get;
            set;
        }

        public String Module
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ParentFunctionCode field. </summary>
        public System.String ParentFunctionCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the seq no.
        /// </summary>
        /// <value>The seq no.</value>
        public Int32? SeqNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the functionUrl field.
        /// </summary>
        public System.String functionUrl
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            MFunctionsEntity toCompareWith = obj as MFunctionsEntity;
            return toCompareWith == null ? false : ((this.FunctionCode == toCompareWith.FunctionCode));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FunctionCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}