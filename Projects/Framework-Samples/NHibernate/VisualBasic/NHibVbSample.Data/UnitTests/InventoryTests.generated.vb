Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports NHibVbSample.Generated.ManagerObjects
Imports NHibVbSample.Generated.BusinessObjects
Imports NHibVbSample.Generated.Base

Namespace NHibVbSample.Generated.UnitTests
	<TestFixture()> _
	Public Partial Class InventoryTests
		Inherits UNuitTestBase
		
		Protected manager As IInventoryManager

		Public Sub New()
			manager = managerFactory.GetInventoryManager()
		End Sub

		Protected Function CreateNewInventory() As Inventory
			Dim entity As New Inventory()

			' You may need to maually enter this key if there is a constraint violation.
			entity.Id = "Test Te"
			
			entity.Qty = 86

			Return entity
		End Function
		Protected Function GetFirstInventory() As Inventory
			Dim entityList As IList(Of Inventory) = manager.GetAll(1)
			If entityList.Count = 0 Then
				Assert.Fail("All tables must have at least one row for unit tests to succeed.")
			End If
			Return entityList(0)
		End Function

		<Test()> _
		Public Sub Create()
			Try
				Dim entity As Inventory = CreateNewInventory()

				Dim result As Object = manager.Save(entity)

				Assert.IsNotNull(result)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Read()
			Try
				Dim entityA As Inventory = CreateNewInventory()
				manager.Save(entityA)

				Dim entityB As Inventory = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA, entityB)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Update()
			Try
				Dim entityA As Inventory = GetFirstInventory()
				
				entityA.Qty = 15
				
				manager.Update(entityA)

				Dim entityB As Inventory = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA.Qty, entityB.Qty)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Delete()
			Try
				Dim entity As Inventory = GetFirstInventory()

				manager.Delete(entity)

                entity = manager.GetById(entity.Id)
                Assert.IsNull(entity)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
	End Class
End Namespace
