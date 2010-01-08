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
Imports System.Data.Linq
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports CodeSmith.Data.Linq
Imports CodeSmith.Data.Linq.Dynamic

Namespace Tracker.Core.Data
    ''' <summary>
    ''' The query extension class for TaskExtended.
    ''' </summary>
    Public Module TaskExtendedExtensions
        ''' <summary>
        ''' Gets an instance by the primary key.
        ''' </summary>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function GetByKey(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal taskId As Integer) As Tracker.Core.Data.TaskExtended

            Dim entity As System.Data.Linq.Table(Of Tracker.Core.Data.TaskExtended) = CType(queryable, Table(Of Tracker.Core.Data.TaskExtended))
            If (entity IsNot Nothing AndAlso entity.Context.LoadOptions Is Nothing) Then
                Return Query.GetByKey.Invoke(DirectCast(entity.Context, Tracker.Core.Data.TrackerDataContext), taskId)
            End If

            Return queryable.FirstOrDefault(Function(t)t.TaskId = taskId)
        End Function
        
        ''' <summary>
        ''' Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        ''' </summary>
        ''' <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        ''' <returns>The number of rows deleted from the database.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function Delete(ByVal table As System.Data.Linq.Table(Of Tracker.Core.Data.TaskExtended), ByVal taskId As Integer) As Integer
            Return table.Delete(Function(t)t.TaskId = taskId)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="taskId">TaskId to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByTaskId(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal taskId As Integer) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            Return queryable.Where(Function(t)t.TaskId = taskId)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="taskId">TaskId to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByTaskId(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal taskId As Integer, ByVal ParamArray additionalValues As Integer()) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            Dim values = New List(Of Integer)()
            values.Add(taskId)
        
            If additionalValues IsNot Nothing Then
                values.AddRange(additionalValues)
            End If
        
            If values.Count = 1 Then
                Return queryable.ByTaskId(values(0))
            End If
        
            Return queryable.ByTaskId(values)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="values">The values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByTaskId(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal values As IEnumerable(Of Integer)) As IQueryable(Of Tracker.Core.Data.TaskExtended)
                Return queryable.Where(Function(t) values.Contains(t.TaskId))
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="taskId">TaskId to search for.</param>
        ''' <param name="comparison">The comparison operator.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByTaskId(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal taskId As Integer, ByVal comparison As ComparisonOperator) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            Select Case comparison
                Case ComparisonOperator.GreaterThan
                    Return queryable.Where(Function(t) taskId > t.TaskId)
                Case ComparisonOperator.GreaterThanOrEquals
                    Return queryable.Where(Function(t) taskId >= t.TaskId)
                Case ComparisonOperator.LessThan
                    Return queryable.Where(Function(t) taskId < t.TaskId)
                Case ComparisonOperator.LessThanOrEquals
                    Return queryable.Where(Function(t) taskId <= t.TaskId)
                Case ComparisonOperator.NotEquals
                    Return queryable.Where(Function(t) t.TaskId <> taskId)
                Case Else
                    Return queryable.Where(Function(t) t.TaskId = taskId)
            End Select
        End Function


        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="browser">Browser to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByBrowser(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal browser As String) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            Return queryable.Where(Function(t) Object.Equals(t.Browser, browser))
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="browser">Browser to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByBrowser(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal browser As String, ByVal ParamArray additionalValues As String()) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            Dim values = New List(Of String)()
            values.Add(browser)
        
            If additionalValues IsNot Nothing Then
                values.AddRange(additionalValues)
            Else
                values.Add(Nothing)
            End If
        
            If values.Count = 1 Then
                Return queryable.ByBrowser(values(0))
            End If
        
            Return queryable.ByBrowser(values)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="values">The values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByBrowser(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal values As IEnumerable(Of String)) As IQueryable(Of Tracker.Core.Data.TaskExtended)
                ' creating dynmic expression to support nulls
                Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.TaskExtended, Boolean)("Browser", values)
                Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="browser">Browser to search for.</param>
        ''' <param name="containment">The containment operator.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByBrowser(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal browser As String, ByVal containment As ContainmentOperator) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            If browser Is Nothing AndAlso containment <> ContainmentOperator.Equals AndAlso containment <> ContainmentOperator.NotEquals Then
                Throw New ArgumentNullException("browser", "Parameter 'browser' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.")
            End If
            
            Select Case containment
                Case ContainmentOperator.Contains
                    Return queryable.Where(Function(t) t.Browser.Contains(browser))
                Case ContainmentOperator.StartsWith
                    Return queryable.Where(Function(t) t.Browser.StartsWith(browser))
                Case ContainmentOperator.EndsWith
                    Return queryable.Where(Function(t) t.Browser.EndsWith(browser))
                Case ContainmentOperator.NotContains
                    Return queryable.Where(Function(t) t.Browser.Contains(browser) = False)
                Case ContainmentOperator.NotEquals
                    Return queryable.Where(Function(t) Object.Equals(t.Browser, browser) = False)
                Case Else
                    Return queryable.Where(Function(t) Object.Equals(t.Browser, browser))
            End Select
        End Function
        

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="os">Os to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByOs(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal os As String) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            Return queryable.Where(Function(t) Object.Equals(t.Os, os))
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="os">Os to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByOs(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal os As String, ByVal ParamArray additionalValues As String()) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            Dim values = New List(Of String)()
            values.Add(os)
        
            If additionalValues IsNot Nothing Then
                values.AddRange(additionalValues)
            Else
                values.Add(Nothing)
            End If
        
            If values.Count = 1 Then
                Return queryable.ByOs(values(0))
            End If
        
            Return queryable.ByOs(values)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="values">The values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByOs(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal values As IEnumerable(Of String)) As IQueryable(Of Tracker.Core.Data.TaskExtended)
                ' creating dynmic expression to support nulls
                Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.TaskExtended, Boolean)("Os", values)
                Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="os">Os to search for.</param>
        ''' <param name="containment">The containment operator.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByOs(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal os As String, ByVal containment As ContainmentOperator) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            If os Is Nothing AndAlso containment <> ContainmentOperator.Equals AndAlso containment <> ContainmentOperator.NotEquals Then
                Throw New ArgumentNullException("os", "Parameter 'os' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.")
            End If
            
            Select Case containment
                Case ContainmentOperator.Contains
                    Return queryable.Where(Function(t) t.Os.Contains(os))
                Case ContainmentOperator.StartsWith
                    Return queryable.Where(Function(t) t.Os.StartsWith(os))
                Case ContainmentOperator.EndsWith
                    Return queryable.Where(Function(t) t.Os.EndsWith(os))
                Case ContainmentOperator.NotContains
                    Return queryable.Where(Function(t) t.Os.Contains(os) = False)
                Case ContainmentOperator.NotEquals
                    Return queryable.Where(Function(t) Object.Equals(t.Os, os) = False)
                Case Else
                    Return queryable.Where(Function(t) Object.Equals(t.Os, os))
            End Select
        End Function
        

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="createdDate">CreatedDate to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByCreatedDate(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal createdDate As Date) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            Return queryable.Where(Function(t)t.CreatedDate = createdDate)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="createdDate">CreatedDate to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByCreatedDate(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal createdDate As Date, ByVal ParamArray additionalValues As Date()) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            Dim values = New List(Of Date)()
            values.Add(createdDate)
        
            If additionalValues IsNot Nothing Then
                values.AddRange(additionalValues)
            End If
        
            If values.Count = 1 Then
                Return queryable.ByCreatedDate(values(0))
            End If
        
            Return queryable.ByCreatedDate(values)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="values">The values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByCreatedDate(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal values As IEnumerable(Of Date)) As IQueryable(Of Tracker.Core.Data.TaskExtended)
                Return queryable.Where(Function(t) values.Contains(t.CreatedDate))
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="createdDate">CreatedDate to search for.</param>
        ''' <param name="comparison">The comparison operator.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByCreatedDate(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal createdDate As Date, ByVal comparison As ComparisonOperator) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            Select Case comparison
                Case ComparisonOperator.GreaterThan
                    Return queryable.Where(Function(t) createdDate > t.CreatedDate)
                Case ComparisonOperator.GreaterThanOrEquals
                    Return queryable.Where(Function(t) createdDate >= t.CreatedDate)
                Case ComparisonOperator.LessThan
                    Return queryable.Where(Function(t) createdDate < t.CreatedDate)
                Case ComparisonOperator.LessThanOrEquals
                    Return queryable.Where(Function(t) createdDate <= t.CreatedDate)
                Case ComparisonOperator.NotEquals
                    Return queryable.Where(Function(t) t.CreatedDate <> createdDate)
                Case Else
                    Return queryable.Where(Function(t) t.CreatedDate = createdDate)
            End Select
        End Function


        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="modifiedDate">ModifiedDate to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByModifiedDate(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal modifiedDate As Date) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            Return queryable.Where(Function(t)t.ModifiedDate = modifiedDate)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="modifiedDate">ModifiedDate to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByModifiedDate(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal modifiedDate As Date, ByVal ParamArray additionalValues As Date()) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            Dim values = New List(Of Date)()
            values.Add(modifiedDate)
        
            If additionalValues IsNot Nothing Then
                values.AddRange(additionalValues)
            End If
        
            If values.Count = 1 Then
                Return queryable.ByModifiedDate(values(0))
            End If
        
            Return queryable.ByModifiedDate(values)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="values">The values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByModifiedDate(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal values As IEnumerable(Of Date)) As IQueryable(Of Tracker.Core.Data.TaskExtended)
                Return queryable.Where(Function(t) values.Contains(t.ModifiedDate))
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.TaskExtended"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="modifiedDate">ModifiedDate to search for.</param>
        ''' <param name="comparison">The comparison operator.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByModifiedDate(ByVal queryable As IQueryable(Of Tracker.Core.Data.TaskExtended), ByVal modifiedDate As Date, ByVal comparison As ComparisonOperator) As IQueryable(Of Tracker.Core.Data.TaskExtended)
            Select Case comparison
                Case ComparisonOperator.GreaterThan
                    Return queryable.Where(Function(t) modifiedDate > t.ModifiedDate)
                Case ComparisonOperator.GreaterThanOrEquals
                    Return queryable.Where(Function(t) modifiedDate >= t.ModifiedDate)
                Case ComparisonOperator.LessThan
                    Return queryable.Where(Function(t) modifiedDate < t.ModifiedDate)
                Case ComparisonOperator.LessThanOrEquals
                    Return queryable.Where(Function(t) modifiedDate <= t.ModifiedDate)
                Case ComparisonOperator.NotEquals
                    Return queryable.Where(Function(t) t.ModifiedDate <> modifiedDate)
                Case Else
                    Return queryable.Where(Function(t) t.ModifiedDate = modifiedDate)
            End Select
        End Function


        'Insert User Defined Extensions here.
        'Anything outside of this Region will be lost at regeneration
        #Region "User Extensions"


        #End Region

        #Region "Query"
        ''' <summary>
        ''' A private class for lazy loading static compiled queries.
        ''' </summary>
        Private Partial Class Query


            Friend Shared ReadOnly GetByKey As Func(Of TrackerDataContext, Integer, Tracker.Core.Data.TaskExtended) = _
                CompiledQuery.Compile( _
                    Function(db As TrackerDataContext , ByVal taskId As Integer) _
                        db.TaskExtended.FirstOrDefault(Function(t)t.TaskId = taskId))

            ' Add your compiled queries here.
            'Anything outside of this Region will be lost at regeneration
            #Region "User Queries"

            #End Region

        End Class
        #End Region
    End Module
End Namespace
