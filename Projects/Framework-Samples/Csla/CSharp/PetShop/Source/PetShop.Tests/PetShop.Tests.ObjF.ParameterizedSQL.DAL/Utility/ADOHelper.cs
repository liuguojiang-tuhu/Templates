﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
//     Changes to this template will not be lost.
//
//     Template: ADOHelper.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

using Csla.Data;


#endregion

namespace PetShop.Tests.ObjF.ParameterizedSQL.DAL
{
    public static class ADOHelper
    {
        #region "Preserved Code"

        private static string _connectionString = string.Empty;

        /// <summary>
        /// Returns the Connection String.
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                if(string.IsNullOrEmpty(_connectionString))
                {
                    _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PetShopConnectionString"].ConnectionString;
                }
                
                return _connectionString;
            }
        }

        #endregion

        #region Methods
        
        /// <summary>
        /// Returns an array of SqlParameters
        /// </summary>
        public static SqlParameter[] SqlParameters(Dictionary<string, object> bag)
        {
            return new List<SqlParameter>(bag.Select(pair => new SqlParameter(string.Format("@p_{0}", pair.Key), pair.Value))).ToArray();
        }

        /// <summary>
        /// Returns a where clause for the current Criteria object.
        /// </summary>
        /// <returns>Returns a where clause for the current Criteria object.</returns>
        public static string BuildWhereStatement(Dictionary<string, object> bag)
        {
            if (bag.Count == 0)
                return string.Empty;

            string columnNames = bag.Keys.Aggregate(string.Empty, (current, columnName) => current + string.Format("[{0}] = @p_{0} AND ", columnName));
            return string.Format("WHERE {0}", columnNames.Remove(columnNames.Length - 5, 5));
        }

        /// <summary>
        /// Returns the Bytes stored in a binary column.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="columnName">The column name.</param>
        /// <returns>Bytes Stored in a column.</returns>
        public static byte[] GetBytes(SafeDataReader reader, string columnName)
        {
            var buffer = new byte[1024];
            long fieldOffset = 0;
            
            using (var stream = new MemoryStream())
            {
                long bytesRead;

                while ((bytesRead = reader.GetBytes(columnName, fieldOffset, buffer, 0, buffer.Length)) > 0)
                {
                    var actualRead = new byte[bytesRead];
                    Buffer.BlockCopy(buffer, 0, actualRead, 0, (int)bytesRead);
                    stream.Write(actualRead, 0, actualRead.Length);
                    fieldOffset += bytesRead;
                }

                return stream.ToArray();
            }
        }

        #endregion
    }
}
