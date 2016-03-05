#region Header

/*****************************************************************************************************
* Description : This file represents a standard LAPInterfaceFile entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LAPInterfaceFileEntity.cs
// Description: Represents a standard LAPInterfaceFile entity.
// </summary>
// <copyright file= "LAPInterfaceFileEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LAP
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for LAPInterfaceFile.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class LAPInterfaceFileEntity : AbstractLastModified, ILAPEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the FileId field.
        /// </summary>
        /// <value>The file id.</value>
        public String FileId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ProcessedDateTime field.
        /// </summary>
        /// <value>The processed date time.</value>
        public DateTime? ProcessedDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ProcessedFileLocation field.
        /// </summary>
        /// <value>The processed file location.</value>
        public String ProcessedFileLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ProcessedFileName field.
        /// </summary>
        /// <value>The processed name of the file.</value>
        public String ProcessedFileName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Remarks field.
        /// </summary>
        /// <value>The remarks.</value>
        public String Remarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Status field.
        /// </summary>
        /// <value>The status.</value>
        public LAPInterfaceFileStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UploadedBy field.
        /// </summary>
        /// <value>The uploaded by.</value>
        public String UploadedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UploadedDateTime field.
        /// </summary>
        /// <value>The uploaded date time.</value>
        public DateTime UploadedDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UploadFileLocation field.
        /// </summary>
        /// <value>The upload file location.</value>
        public String UploadFileLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UploadFileName field.
        /// </summary>
        /// <value>The name of the upload file.</value>
        public String UploadFileName
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
            if(obj == null)
            {
                return false;
            }

            LAPInterfaceFileEntity toCompareWith = obj as LAPInterfaceFileEntity;
            return toCompareWith == null ? false : ((this.FileId == toCompareWith.FileId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FileId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}