﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'SupplierList.vb.
'
'     Template: EditableChildList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla
Imports Csla.Data

<Serializable()> _
<Csla.Server.ObjectFactory(FactoryNames.SupplierListFactoryName)> _
Public Partial Class SupplierList 
    Inherits BusinessListBase(Of SupplierList, Supplier)

    #Region "Contructor(s)"

    Private Sub New()
        AllowNew = true
        MarkAsChild()
    End Sub

    #End Region

    #Region "Factory Methods" 

    Friend Shared Function NewList() As SupplierList
        Return DataPortal.CreateChild(Of SupplierList)()
    End Function

    Friend Shared Function GetBySuppId(ByVal suppId As System.Int32) As SupplierList 
        Dim criteria As New SupplierCriteria()
        criteria.SuppId = suppId

        Return DataPortal.FetchChild(Of SupplierList)(criteria)
    End Function

    Friend Shared Function GetAll() As SupplierList
        Return DataPortal.FetchChild(Of SupplierList)(New SupplierCriteria())
    End Function

    #End Region

    #Region "Properties"

    Protected Overrides Function AddNewCore() As Object
        Dim item As Supplier = PetShop.Tests.OF.ParameterizedSQL.Supplier.NewSupplier()
                Me.Add(item)
                Return item
    End Function

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As SupplierCriteria) As Boolean
        Return PetShop.Tests.OF.ParameterizedSQL.Supplier.Exists(criteria)
    End Function

    #End Region

        #Region "Property overrides"

        ''' <summary>
        ''' Returns true if any children are dirty
        ''' </summary>
        Public Shadows ReadOnly Property IsDirty() As Boolean
            Get
                For Each item As Supplier In Me.Items
                    If item.IsDirty Then
                        Return True
                    End If
                Next
        
                Return False
            End Get
        End Property

        #End Region

    End Class