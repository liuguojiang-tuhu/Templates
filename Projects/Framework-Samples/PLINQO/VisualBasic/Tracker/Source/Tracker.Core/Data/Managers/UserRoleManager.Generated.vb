﻿
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
Imports System.Linq
Imports System.Text
Imports CodeSmith.Data.Linq
Imports CodeSmith.Data.Linq.Dynamic

Namespace Tracker.Core.Data
    ''' <summary>
    ''' The manager class for UserRole.
    ''' </summary>
    Partial Public Class UserRoleManager 
        Inherits CodeSmith.Data.EntityManagerBase(Of TrackerDataManager, Tracker.Core.Data.UserRole)

        ''' <summary>
        ''' Initializes the <see cref="UserRoleManager"/> class.
        ''' </summary>
        ''' <param name="manager">The current manager.</param>
        Public Sub New(ByVal manager As TrackerDataManager) 
            MyBase.New(manager)
            OnCreated()
        End Sub

        ''' <summary>
        ''' Gets the current context.
        ''' </summary>
        Protected ReadOnly Property Context() As Tracker.Core.Data.TrackerDataContext
            Get
                return Manager.Context
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the entity for this manager.
        ''' </summary>
        Protected ReadOnly Property Entity() As System.Data.Linq.Table(Of Tracker.Core.Data.UserRole)
            Get 
                return Manager.Context.UserRole
            End Get
        End Property
        
        
        ''' <summary>
        ''' Creates the key for this entity.
        ''' </summary>
        Public Shared Function CreateKey(ByVal userId As Integer, ByVal roleId As Integer) As CodeSmith.Data.IEntityKey(Of Integer, Integer)
            Return New CodeSmith.Data.EntityKey(Of Integer, Integer)(userId, roleId)
        End Function
        
        ''' <summary>
        ''' Gets an entity by the primary key.
        ''' </summary>
        ''' <param name="key">The key for the entity.</param>
        ''' <returns>
        ''' An instance of the entity or null if not found.
        ''' </returns>
        ''' <remarks>
        ''' This method is expecting key to be of type IEntityKey(Of Integer, Integer).
        ''' </remarks>
        ''' <exception cref="ArgumentException">Thrown when key is not of type IEntityKey(Of Integer, Integer).</exception>
        Public Overrides Function GetByKey(ByVal key As CodeSmith.Data.IEntityKey) As Tracker.Core.Data.UserRole
            If (key Is GetType(CodeSmith.Data.IEntityKey(Of Integer, Integer))) Then
                Dim entityKey As CodeSmith.Data.IEntityKey(Of Integer, Integer) = DirectCast(key, CodeSmith.Data.IEntityKey(Of Integer, Integer))
                return GetByKey(entityKey.Key, entityKey.Key1)
            Else
                Throw New ArgumentException("Invalid key, expected key to be of type IEntityKey(Of Integer, Integer)")
            End If
        End Function
        
        ''' <summary>
        ''' Gets an instance by the primary key.
        ''' </summary>
        ''' <returns>An instance of the entity or null if not found.</returns>
        Public Overloads Function GetByKey(ByVal userId As Integer, ByVal roleId As Integer) As Tracker.Core.Data.UserRole
            If (Context.LoadOptions Is Nothing) Then 
                return Query.GetByKey.Invoke(Context, userId, roleId)
            Else
                return Entity.FirstOrDefault(Function(u)u.UserId = userId _
					AndAlso u.RoleId = roleId)
            End If
        End Function
        
        ''' <summary>
        ''' Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        ''' </summary>
        ''' <returns>The number of rows deleted from the database.</returns>
        Public Function Delete(ByVal userId As Integer, ByVal roleId As Integer) As Integer
            return Entity.Delete(Function(u)u.UserId = userId _
					AndAlso u.RoleId = roleId)
        End Function
        
        ''' <summary>
        ''' Gets a query by an index.
        ''' </summary>
        Public Overloads Function GetByUserId(ByVal userId As Integer) As IQueryable(Of Tracker.Core.Data.UserRole)
            If Context.LoadOptions Is Nothing Then 
                return Query.GetByUserId.Invoke(Context, userId)
            Else
                return Entity.Where(Function(u)u.UserId = userId)
            End If
        End Function
        
        ''' <summary>
        ''' Gets a query by an index.
        ''' </summary>
        Public Overloads Function GetByRoleId(ByVal roleId As Integer) As IQueryable(Of Tracker.Core.Data.UserRole)
            If Context.LoadOptions Is Nothing Then 
                return Query.GetByRoleId.Invoke(Context, roleId)
            Else
                return Entity.Where(Function(u)u.RoleId = roleId)
            End If
        End Function

        #Region "Extensibility Method Definitions"
        ''' <summary>Called when the class is created.</summary>
        Partial Private Sub OnCreated()
        End Sub
        #End Region
        
        #Region "Query"
        ''' <summary>
        ''' A private class for lazy loading static compiled queries.
        ''' </summary>
        Private Partial Class Query

            Friend Shared Readonly GetByKey As Func(Of Tracker.Core.Data.TrackerDataContext, Integer, Integer, Tracker.Core.Data.UserRole) = _
                CompiledQuery.Compile( _
                     Function(db As Tracker.Core.Data.TrackerDataContext, ByVal userId As Integer, ByVal roleId As Integer) _
                        db.UserRole.FirstOrDefault(Function(u)u.UserId = userId _
							AndAlso u.RoleId = roleId))

            Friend Shared Readonly  GetByUserId As Func(Of Tracker.Core.Data.TrackerDataContext, Integer, IQueryable(Of Tracker.Core.Data.UserRole)) = _
                CompiledQuery.Compile( _
                    Function( db As Tracker.Core.Data.TrackerDataContext , ByVal userId As Integer) _
                        db.UserRole.Where(Function(u)u.UserId = userId))

            Friend Shared Readonly  GetByRoleId As Func(Of Tracker.Core.Data.TrackerDataContext, Integer, IQueryable(Of Tracker.Core.Data.UserRole)) = _
                CompiledQuery.Compile( _
                    Function( db As Tracker.Core.Data.TrackerDataContext , ByVal roleId As Integer) _
                        db.UserRole.Where(Function(u)u.RoleId = roleId))

        End Class
        #End Region
    End Class
End Namespace

