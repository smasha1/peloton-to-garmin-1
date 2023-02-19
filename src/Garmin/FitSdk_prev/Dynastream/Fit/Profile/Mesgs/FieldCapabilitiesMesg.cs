#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2022 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.94Release
// Tag = production/akw/21.94.00-0-g0f668193
/////////////////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the FieldCapabilities profile message.
    /// </summary>
    public class FieldCapabilitiesMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="FieldCapabilitiesMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte File = 0;
            public const byte MesgNum = 1;
            public const byte FieldNum = 2;
            public const byte Count = 3;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public FieldCapabilitiesMesg() : base(Profile.GetMesg(MesgNum.FieldCapabilities))
        {
        }

        public FieldCapabilitiesMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the MessageIndex field</summary>
        /// <returns>Returns nullable ushort representing the MessageIndex field</returns>
        public ushort? GetMessageIndex()
        {
            Object val = GetFieldValue(254, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MessageIndex field</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the File field</summary>
        /// <returns>Returns nullable File enum representing the File field</returns>
        public File? GetFile()
        {
            object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            File? value = obj == null ? (File?)null : (File)obj;
            return value;
        }

        /// <summary>
        /// Set File field</summary>
        /// <param name="file_">Nullable field value to be set</param>
        public void SetFile(File? file_)
        {
            SetFieldValue(0, 0, file_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MesgNum field</summary>
        /// <returns>Returns nullable ushort representing the MesgNum field</returns>
        public ushort? GetMesgNum()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MesgNum field</summary>
        /// <param name="mesgNum_">Nullable field value to be set</param>
        public void SetMesgNum(ushort? mesgNum_)
        {
            SetFieldValue(1, 0, mesgNum_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the FieldNum field</summary>
        /// <returns>Returns nullable byte representing the FieldNum field</returns>
        public byte? GetFieldNum()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set FieldNum field</summary>
        /// <param name="fieldNum_">Nullable field value to be set</param>
        public void SetFieldNum(byte? fieldNum_)
        {
            SetFieldValue(2, 0, fieldNum_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Count field</summary>
        /// <returns>Returns nullable ushort representing the Count field</returns>
        public ushort? GetCount()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set Count field</summary>
        /// <param name="count_">Nullable field value to be set</param>
        public void SetCount(ushort? count_)
        {
            SetFieldValue(3, 0, count_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
