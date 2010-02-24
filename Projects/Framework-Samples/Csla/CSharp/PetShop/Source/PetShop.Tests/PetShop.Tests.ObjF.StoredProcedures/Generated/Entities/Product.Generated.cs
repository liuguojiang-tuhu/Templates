﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Product.cs'.
//
//     Template: SwitchableObject.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Data;
using Csla.Validation;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures
{
    [Serializable]
    [Csla.Server.ObjectFactory(FactoryNames.ProductFactoryName)]
    public partial class Product : BusinessBase< Product >
    {
        #region Contructor(s)

        private Product()
        { /* Require use of factory methods */ }

        internal Product(System.String productId)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_productIdProperty, productId);
            }
        }
        #endregion

        #region Validation Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            ValidationRules.AddRule(CommonRules.StringRequired, _productIdProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_productIdProperty, 10));
            ValidationRules.AddRule(CommonRules.StringRequired, _categoryIdProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_categoryIdProperty, 10));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_nameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_descriptionProperty, 255));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_imageProperty, 80));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo< System.String > _productIdProperty = RegisterProperty< System.String >(p => p.ProductId);
		[System.ComponentModel.DataObjectField(true, false)]
        public System.String ProductId
        {
            get { return GetProperty(_productIdProperty); }
            set{ SetProperty(_productIdProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _originalProductIdProperty = RegisterProperty< System.String >(p => p.OriginalProductId);
        /// <summary>
        /// Holds the original value for ProductId. This is used for non identity primary keys.
        /// </summary>
        internal System.String OriginalProductId
        {
            get { return GetProperty(_originalProductIdProperty); }
            set{ SetProperty(_originalProductIdProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _categoryIdProperty = RegisterProperty< System.String >(p => p.CategoryId);
        public System.String CategoryId
        {
            get { return GetProperty(_categoryIdProperty); }
            set{ SetProperty(_categoryIdProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _nameProperty = RegisterProperty< System.String >(p => p.Name);
        public System.String Name
        {
            get { return GetProperty(_nameProperty); }
            set{ SetProperty(_nameProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _descriptionProperty = RegisterProperty< System.String >(p => p.Description);
        public System.String Description
        {
            get { return GetProperty(_descriptionProperty); }
            set{ SetProperty(_descriptionProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _imageProperty = RegisterProperty< System.String >(p => p.Image);
        public System.String Image
        {
            get { return GetProperty(_imageProperty); }
            set{ SetProperty(_imageProperty, value); }
        }

        //AssociatedManyToOne
        private static readonly PropertyInfo< Category > _categoryMemberProperty = RegisterProperty< Category >(p => p.CategoryMember, Csla.RelationshipTypes.Child);
        public Category CategoryMember
        {
            get
            {
                if(!FieldManager.FieldExists(_categoryMemberProperty))
                {
                    if(IsNew || !PetShop.Tests.ObjF.StoredProcedures.Category.Exists(new PetShop.Tests.ObjF.StoredProcedures.CategoryCriteria {CategoryId = CategoryId}))
                        LoadProperty(_categoryMemberProperty, PetShop.Tests.ObjF.StoredProcedures.Category.NewCategory());
                    else
                        LoadProperty(_categoryMemberProperty, PetShop.Tests.ObjF.StoredProcedures.Category.GetByCategoryId(CategoryId));
                }

                return GetProperty(_categoryMemberProperty); 
            }
        }



        //AssociatedOneToMany
        private static readonly PropertyInfo< ItemList > _itemsProperty = RegisterProperty<ItemList>(p => p.Items, Csla.RelationshipTypes.Child);
        public ItemList Items
        {
            get
            {
                if(!FieldManager.FieldExists(_itemsProperty))
                {
                    if(IsNew || !PetShop.Tests.ObjF.StoredProcedures.ItemList.Exists(new PetShop.Tests.ObjF.StoredProcedures.ItemCriteria {ProductId = ProductId}))
                        LoadProperty(_itemsProperty, PetShop.Tests.ObjF.StoredProcedures.ItemList.NewList());
                    else
                        LoadProperty(_itemsProperty, PetShop.Tests.ObjF.StoredProcedures.ItemList.GetByProductId(ProductId));
                }

                return GetProperty(_itemsProperty);
            }
        }

        #endregion

        #region Root Factory Methods 
        
        public static Product NewProduct()
        {
            return DataPortal.Create< Product >();
        }

        public static Product GetByProductId(System.String productId)
        {
            return DataPortal.Fetch< Product >(
                new ProductCriteria {ProductId = productId});
        }

        public static Product GetByName(System.String name)
        {
            return DataPortal.Fetch< Product >(
                new ProductCriteria {Name = name});
        }

        public static Product GetByCategoryId(System.String categoryId)
        {
            return DataPortal.Fetch< Product >(
                new ProductCriteria {CategoryId = categoryId});
        }

        public static Product GetByCategoryIdName(System.String categoryId, System.String name)
        {
            return DataPortal.Fetch< Product >(
                new ProductCriteria {CategoryId = categoryId, Name = name});
        }

        public static Product GetByCategoryIdProductIdName(System.String categoryId, System.String productId, System.String name)
        {
            return DataPortal.Fetch< Product >(
                new ProductCriteria {CategoryId = categoryId, ProductId = productId, Name = name});
        }

        public static void DeleteProduct(System.String productId)
        {
                DataPortal.Delete(new ProductCriteria (productId));
        }
        
        #endregion

        #region Child Factory Methods 
        
        internal static Product NewProductChild()
        {
            return DataPortal.CreateChild< Product >();
        }
        internal static Product GetByProductIdChild(System.String productId)
        {
            return DataPortal.FetchChild< Product >(
                new ProductCriteria {ProductId = productId});
        }
        internal static Product GetByNameChild(System.String name)
        {
            return DataPortal.FetchChild< Product >(
                new ProductCriteria {Name = name});
        }
        internal static Product GetByCategoryIdChild(System.String categoryId)
        {
            return DataPortal.FetchChild< Product >(
                new ProductCriteria {CategoryId = categoryId});
        }
        internal static Product GetByCategoryIdNameChild(System.String categoryId, System.String name)
        {
            return DataPortal.FetchChild< Product >(
                new ProductCriteria {CategoryId = categoryId, Name = name});
        }
        internal static Product GetByCategoryIdProductIdNameChild(System.String categoryId, System.String productId, System.String name)
        {
            return DataPortal.FetchChild< Product >(
                new ProductCriteria {CategoryId = categoryId, ProductId = productId, Name = name});
        }

        #endregion

        #region Exists Command

        public static bool Exists(ProductCriteria criteria)
        {
            return ExistsCommand.Execute(criteria);
        }

        #endregion

        #region Overridden properties

        /// <summary>
        /// Returns true if the business object or any of its children properties are dirty.
        /// </summary>
        public override bool IsDirty
        {
            get
            {
                if (base.IsDirty) return true;
                if (FieldManager.FieldExists(_categoryMemberProperty) && CategoryMember.IsDirty) return true;
                if (FieldManager.FieldExists(_itemsProperty) && Items.IsDirty) return true;

                return false;
            }
        }

        #endregion


    }
}