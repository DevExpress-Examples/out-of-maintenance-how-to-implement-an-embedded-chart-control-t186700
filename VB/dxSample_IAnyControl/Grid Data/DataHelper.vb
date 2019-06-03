Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace dxSample_IAnyControl.IAny_Files
	Public Class DataHelper
		Public Shared Function GetData() As Object
			Dim dt As New DataTable()
			dt.Columns.Add("PersonID", GetType(Integer))
			dt.Columns.Add("PersonFirstName", GetType(String))
			dt.Columns.Add("PersonLastName", GetType(String))
			dt.Columns.Add("PersonTitle", GetType(String))
			dt.Columns.Add("HireDate", GetType(Date))
			dt.Columns.Add("HomePhone", GetType(String))
			dt.Columns.Add("SalesByProductCategory", GetType(Object))
			FillDataTable(dt)
			Return dt
		End Function
		Friend Shared Sub FillDataTable(ByVal dt As DataTable)
			dt.Rows.Add(New Object() { 0, "Nancy", "Davolio", "Sales Representative", "5/1/2005", "(206) 555-9857", GetEmployeeSellingsByCategoryChartDataEx(10) })
			dt.Rows.Add(New Object() { 1, "Andrew", "Fuller", "Sales Representative", "5/1/2005", "(206) 555-9857", GetEmployeeSellingsByCategoryChartDataEx(7) })
			dt.Rows.Add(New Object() { 2, "Mike", "Livingston", "Sales Representative", "5/1/2005", "(206) 555-9857", GetEmployeeSellingsByCategoryChartDataEx(5) })
			dt.Rows.Add(New Object() { 3, "Margared", "Peacock", "Sales Representative", "5/1/2005", "(206) 555-9857", GetEmployeeSellingsByCategoryChartDataEx(1) })
		End Sub
		Private Shared Function GetEmployeeSellingsByCategoryChartDataEx(ByVal key As Integer) As List(Of EmployeeSellingByCategoryChartData)
			Dim res As New List(Of EmployeeSellingByCategoryChartData)()
			res.Add(New EmployeeSellingByCategoryChartData() With {.CategoryName = "Beverages", .Quantity = key * 200})
			res.Add(New EmployeeSellingByCategoryChartData() With {.CategoryName = "Condiments", .Quantity = key * 50})
			res.Add(New EmployeeSellingByCategoryChartData() With {.CategoryName = "Confections", .Quantity = key * 100})
			res.Add(New EmployeeSellingByCategoryChartData() With {.CategoryName = "Diary products", .Quantity = key * 90})
			res.Add(New EmployeeSellingByCategoryChartData() With {.CategoryName = "Grans / Cereals", .Quantity = key * 150})
			res.Add(New EmployeeSellingByCategoryChartData() With {.CategoryName = "Meat / Poultry", .Quantity = key * 30})
			res.Add(New EmployeeSellingByCategoryChartData() With {.CategoryName = "Produce ", .Quantity = key * 120})
			res.Add(New EmployeeSellingByCategoryChartData() With {.CategoryName = "Seafood ", .Quantity = key * 90})
			Return res
		End Function
	End Class
End Namespace
