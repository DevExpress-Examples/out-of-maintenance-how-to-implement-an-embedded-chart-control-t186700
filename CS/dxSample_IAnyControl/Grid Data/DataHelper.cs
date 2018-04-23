using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace dxSample_IAnyControl.IAny_Files {
    public class DataHelper {
        public static object GetData() {
            DataTable dt = new DataTable();
            dt.Columns.Add("PersonID", typeof(int));
            dt.Columns.Add("PersonFirstName", typeof(string));
            dt.Columns.Add("PersonLastName", typeof(string));
            dt.Columns.Add("PersonTitle", typeof(string));
            dt.Columns.Add("HireDate", typeof(DateTime));
            dt.Columns.Add("HomePhone", typeof(string));
            dt.Columns.Add("SalesByProductCategory", typeof(object));
            FillDataTable(dt);
            return dt;
        }
        internal static void FillDataTable(DataTable dt) {
            dt.Rows.Add(new object[] { 0, "Nancy", "Davolio", "Sales Representative", "5/1/2005", "(206) 555-9857", GetEmployeeSellingsByCategoryChartDataEx(10) });
            dt.Rows.Add(new object[] { 1, "Andrew", "Fuller", "Sales Representative", "5/1/2005", "(206) 555-9857", GetEmployeeSellingsByCategoryChartDataEx(7) });
            dt.Rows.Add(new object[] { 2, "Mike", "Livingston", "Sales Representative", "5/1/2005", "(206) 555-9857", GetEmployeeSellingsByCategoryChartDataEx(5) });
            dt.Rows.Add(new object[] { 3, "Margared", "Peacock", "Sales Representative", "5/1/2005", "(206) 555-9857", GetEmployeeSellingsByCategoryChartDataEx(1) });
        }
        private static List<EmployeeSellingByCategoryChartData> GetEmployeeSellingsByCategoryChartDataEx(int key) {
            List<EmployeeSellingByCategoryChartData> res = new List<EmployeeSellingByCategoryChartData>();
            res.Add(new EmployeeSellingByCategoryChartData() {
                CategoryName = "Beverages", Quantity = key * 200
            });
            res.Add(new EmployeeSellingByCategoryChartData() {
                CategoryName = "Condiments", Quantity = key * 50
            });
            res.Add(new EmployeeSellingByCategoryChartData() {
                CategoryName = "Confections", Quantity = key * 100
            });
            res.Add(new EmployeeSellingByCategoryChartData() {
                CategoryName = "Diary products", Quantity = key * 90
            });
            res.Add(new EmployeeSellingByCategoryChartData() {
                CategoryName = "Grans / Cereals", Quantity = key * 150
            });
            res.Add(new EmployeeSellingByCategoryChartData() {
                CategoryName = "Meat / Poultry", Quantity = key * 30
            });
            res.Add(new EmployeeSellingByCategoryChartData() {
                CategoryName = "Produce ", Quantity = key * 120
            });
            res.Add(new EmployeeSellingByCategoryChartData() {
                CategoryName = "Seafood ", Quantity = key * 90
            });
            return res;
        }
    }
}
