//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.8.X CodeSmith Templates.
//       Changes to this template will not be lost.
//
//     Template: EditableRootList.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using Csla;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    public partial class LineItemList
    {
        #region Authorization Rules

        protected void AddAuthorizationRules()
        {
            //// More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).

            //string[] canWrite = { "AdminUser", "RegularUser" };
            //string[] canRead = { "AdminUser", "RegularUser", "ReadOnlyUser" };
            //string[] admin = { "AdminUser" };

            // AuthorizationRules.AllowCreate(typeof(LineItemList), admin);
            // AuthorizationRules.AllowDelete(typeof(LineItemList), admin);
            // AuthorizationRules.AllowEdit(typeof(LineItemList), canWrite);
            // AuthorizationRules.AllowGet(typeof(LineItemList), canRead);

            //// OrderId
            // AuthorizationRules.AllowRead(_orderIdProperty, canRead);

            //// LineNum
            // AuthorizationRules.AllowRead(_lineNumProperty, canRead);

            //// ItemId
            // AuthorizationRules.AllowRead(_itemIdProperty, canRead);

            //// Quantity
            // AuthorizationRules.AllowRead(_quantityProperty, canRead);

            //// UnitPrice
            // AuthorizationRules.AllowRead(_unitPriceProperty, canRead);

            //// OrderMember
            // AuthorizationRules.AllowRead(_orderMemberProperty, canRead);

// NOTE: Many-To-Many support coming soon.
        }

        #endregion

    }
}