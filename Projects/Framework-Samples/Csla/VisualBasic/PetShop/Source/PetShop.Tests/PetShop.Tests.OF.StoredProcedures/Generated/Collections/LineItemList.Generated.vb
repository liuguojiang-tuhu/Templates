﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'LineItemList.vb.
'
'     Template: EditableRootList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data

<Serializable()> _
<Csla.Server.ObjectFactory(FactoryNames.LineItemListFactoryName)> _
Public Partial Class LineItemList 
    Inherits BusinessListBase(Of LineItemList, LineItem)

    #Region "Contructor(s)"
    
    Private Sub New()
        AllowNew = true
    End Sub
    
    #End Region

    #Region "Factory Methods"

    Public Shared Function NewList() As LineItemList
        Return DataPortal.Create(Of LineItemList)()
    End Function

    Public Shared Function GetByOrderIdLineNum(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As LineItemList 
        Dim criteria As New LineItemCriteria()
        criteria.OrderId = orderId
			criteria.LineNum = lineNum

        Return DataPortal.Fetch(Of LineItemList)(criteria)
    End Function

    Public Shared Function GetByOrderId(ByVal orderId As System.Int32) As LineItemList 
        Dim criteria As New LineItemCriteria()
        criteria.OrderId = orderId

        Return DataPortal.Fetch(Of LineItemList)(criteria)
    End Function

    Public Shared Function GetAll() As LineItemList
        Return DataPortal.Fetch(Of LineItemList)(New LineItemCriteria())
    End Function

    #End Region

    #Region "Properties"

    Protected Overrides Function AddNewCore() As Object
        Dim item As LineItem = PetShop.Tests.OF.StoredProcedures.LineItem.NewLineItem()
        Me.Add(item)
        Return item
    End Function

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As LineItemCriteria) As Boolean
        Return PetShop.Tests.OF.StoredProcedures.LineItem.Exists(criteria)
    End Function

    #End Region

        #Region "Property overrides"

        ''' <summary>
        ''' Returns true if any children are dirty
        ''' </summary>
        Public Shadows ReadOnly Property IsDirty() As Boolean
            Get
                For Each item As LineItem In Me.Items
                    If item.IsDirty Then
                        Return True
                    End If
                Next
        
                Return False
            End Get
        End Property

        #End Region

End Class