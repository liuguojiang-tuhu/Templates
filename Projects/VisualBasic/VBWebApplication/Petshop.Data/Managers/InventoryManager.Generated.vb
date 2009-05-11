
'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO NOT MODIFY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic
Imports System.Data.Linq
Imports System.Data.SqlTypes
Imports System.Linq
Imports System.Text
Imports CodeSmith.Data
Imports CodeSmith.Data.Rules
Imports CodeSmith.Data.Rules.Assign
Imports CodeSmith.Data.Rules.Validation

Namespace Petshop.Data
    ''' <summary>
    ''' The manager class for Inventory.
    ''' </summary>
    Partial Public Class InventoryManager 
    Inherits EntityManagerBase(Of PetshopDataManager,Inventory)
        ''' <summary>
        ''' Initializes the <see cref="InventoryManager"/> class.
        ''' </summary>
        Shared Sub New()
            RuleManager.AddShared(Of Inventory )(GetType(PetshopDataContext))
            
            AddRules()
            
        End Sub

        ''' <summary>
        ''' Initializes the <see cref="InventoryManager"/> class.
        ''' </summary>
        ''' <param name="manager">The current manager.</param>
        Public Sub New(ByVal manager As PetshopDataManager) 
            MyBase.New(manager)
            OnCreated()
        End Sub

        ''' <summary>
        ''' Gets the current context.
        ''' </summary>
        Protected ReadOnly Property Context As PetshopDataContext
            Get
                return Manager.Context
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the entity for this manager.
        ''' </summary>
        Protected ReadOnly Property Entity As Table(Of Inventory)
            Get 
                return Manager.Context.Inventory
            End Get
        End Property
        
        
        ''' <summary>
        ''' Creates the key for this entity.
        ''' </summary>
        Public Shared Function CreateKey(itemId As String) As IEntityKey(Of String)
            Return New EntityKey(Of String)(itemId)
        End Function
        
        ''' <summary>
        ''' Gets an entity by the primary key.
        ''' </summary>
        ''' <param name="key">The key for the entity.</param>
        ''' <returns>
        ''' An instance of the entity or null if not found.
        ''' </returns>
        ''' <remarks>
        ''' This method is expecting key to be of type IEntityKey(Of String).
        ''' </remarks>
        ''' <exception cref="ArgumentException">Thrown when key is not of type IEntityKey(Of String).</exception>
        Public Overrides Function GetByKey(ByVal key As IEntityKey) As Inventory
            If (key Is GetType(IEntityKey(Of String))) Then
                Dim entityKey As IEntityKey(Of String) = DirectCast(key,IEntityKey(Of String))
                return GetByKey(entityKey.Key)
            Else
                Throw New ArgumentException("Invalid key, expected key to be of type IEntityKey(Of String)")
            End If
        End Function
        
        ''' <summary>
        ''' Gets an instance by the primary key.
        ''' </summary>
        ''' <returns>An instance of the entity or null if not found.</returns>
        Public Overloads Function GetByKey(itemId As String) As Inventory
            If (Context.LoadOptions Is Nothing) Then 
                return Query.GetByKey.Invoke(Context, itemId)
            Else
                return Entity.FirstOrDefault(Function(i)i.ItemId = itemId)
            End If
        End Function

        #Region "Extensibility Method Definitions"
        ''' <summary>Called by the static constructor to add shared rules.</summary>
        Shared Partial Private Sub AddRules()
        End Sub
        ''' <summary>Called when the class is created.</summary>
        Partial Private Sub OnCreated()
        End Sub
        #End Region
        
        #Region "Query"
        ''' <summary>
        ''' A private class for lazy loading static compiled queries.
        ''' </summary>
        Private Partial Class Query

            Friend Shared Readonly GetByKey As Func(Of PetshopDataContext, String, Inventory) = _
                CompiledQuery.Compile( _
                     Function(db As PetshopDataContext, itemId As String) _
                        db.Inventory.FirstOrDefault(Function(i)i.ItemId = itemId))

        End Class
        #End Region
    End Class
End Namespace
