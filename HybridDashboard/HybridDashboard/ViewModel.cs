using Syncfusion.Blazor.Calendars;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HybridDashboard
{
    public class ViewModel
    {
    public DateTime MinDate { get; set; } = new DateTime(2024, 01, 01);
    public DateTime MaxDate { get; set; } = new DateTime(2024, 12, 31);

    public DateTime? StartDate { get; set; } = new DateTime(2024, 01, 01);
    public DateTime? EndDate { get; set; } = new DateTime(2024, 12, 31);

    public string totalRevenue = "";
    public string totalOrders = "";
    public string activeCustomers = "";
    public string customerRetentionRate = "";

    public class SalesData
    {
        public DateTime Date { get; set; }
        public double Revenue { get; set; }
        public string Color { get; set; }
    }

    public List<SalesData> SalesDataSource = new List<SalesData>
    {
        new SalesData { Date = new DateTime(2024, 01, 01), Revenue = 15200, Color="#ff6347" },
        new SalesData { Date = new DateTime(2024, 02, 01), Revenue = 18500, Color="#ff69b4" },
        new SalesData { Date = new DateTime(2024, 03, 01), Revenue = 14800, Color="#17becf" },
        new SalesData { Date = new DateTime(2024, 04, 01), Revenue = 22000, Color="#bcbd22" },
        new SalesData { Date = new DateTime(2024, 05, 01), Revenue = 20300, Color="#7f7f7f" },
        new SalesData { Date = new DateTime(2024, 06, 01), Revenue = 27500, Color="#e377c2" },
        new SalesData { Date = new DateTime(2024, 07, 01), Revenue = 23200, Color="#8c564b" },
        new SalesData { Date = new DateTime(2024, 08, 01), Revenue = 26700, Color="#9467bd" },
        new SalesData { Date = new DateTime(2024, 09, 01), Revenue = 19500, Color="#d62728" },
        new SalesData { Date = new DateTime(2024, 10, 01), Revenue = 21800, Color="#2ca02c" },
        new SalesData { Date = new DateTime(2024, 11, 01), Revenue = 30400, Color="#ff7f0e" },
        new SalesData { Date = new DateTime(2024, 12, 01), Revenue = 28100, Color="#1f77b4" }
    };

        public List<SalesData> FilteredSalesDataSource { get; set; }

    public class OrderData
    {
        public string? Country { get; set; }
        public double OrderCount { get; set; }
    }

    public List<OrderData> OrderDataSource { get; set; }

    public class ProductData
    {
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCategory { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsSold { get; set; }
        public double TotalSales { get; set; }
    }

    public List<ProductData> ProductDataSource { get; set; }

        public ViewModel()
        {
            totalRevenue = "$15.0M";
            totalOrders = "5,900";
            activeCustomers = "2118";
            customerRetentionRate = "55%";

            FilteredSalesDataSource = SalesDataSource.Where(s => s.Date >= StartDate && s.Date <= EndDate).ToList();

            OrderDataSource = new List<OrderData>
        {
            new OrderData { Country = "France", OrderCount = 190 },
            new OrderData { Country = "Germany", OrderCount = 700 },
            new OrderData { Country = "Canada", OrderCount = 330 },
            new OrderData { Country = "USA", OrderCount = 620 },
            new OrderData { Country = "Brazil", OrderCount = 180 },
            new OrderData { Country = "India", OrderCount = 450 },
            new OrderData { Country = "Japan", OrderCount = 520 },
            new OrderData { Country = "China", OrderCount = 290 },
            new OrderData { Country = "UAE", OrderCount = 700 },
            new OrderData { Country = "UK", OrderCount = 210 }
        };

            ProductDataSource = new List<ProductData>
        {
            new ProductData { ProductId = "PROD-001", ProductName = "Laptop", ProductCategory = "Electronics", UnitPrice = 400, UnitsSold = 20, TotalSales = 8000 },
            new ProductData { ProductId = "PROD-002", ProductName = "Smartphone", ProductCategory = "Electronics", UnitPrice = 350, UnitsSold = 18, TotalSales = 5600 },
            new ProductData { ProductId = "PROD-003", ProductName = "Tablet", ProductCategory = "Electronics", UnitPrice = 300, UnitsSold = 16, TotalSales = 4800 },
            new ProductData { ProductId = "PROD-004", ProductName = "Headphones", ProductCategory = "Accessories", UnitPrice = 250, UnitsSold = 15, TotalSales = 3750 },
            new ProductData { ProductId = "PROD-005", ProductName = "Smartwatch", ProductCategory = "Accessories", UnitPrice = 200, UnitsSold = 12, TotalSales = 2400 },
            new ProductData { ProductId = "PROD-006", ProductName = "Office Chair", ProductCategory = "Furniture", UnitPrice = 150, UnitsSold = 10, TotalSales = 1500 },
            new ProductData { ProductId = "PROD-007", ProductName = "DSLR Camera", ProductCategory = "Electronics", UnitPrice = 140, UnitsSold = 10, TotalSales = 1400 },
            new ProductData { ProductId = "PROD-008", ProductName = "Coffee Maker", ProductCategory = "Appliances", UnitPrice = 100, UnitsSold = 10, TotalSales = 1000 },
            new ProductData { ProductId = "PROD-009", ProductName = "Gaming Mouse", ProductCategory = "Accessories", UnitPrice = 50, UnitsSold = 8, TotalSales = 400 },
            new ProductData { ProductId = "PROD-210", ProductName = "Keyboard", ProductCategory = "Electronics", UnitPrice = 100, UnitsSold = 1, TotalSales = 100 }
        };
        }

        public void ValueChangeHandler(RangePickerEventArgs<DateTime?> args)
        {
            StartDate = args.StartDate;
            EndDate = args.EndDate;
            SetPanelComponentDataSource(StartDate, EndDate);
            //StateHasChanged();
        }

        private void SetPanelComponentDataSource(DateTime? startDate, DateTime? endDate)
        {
            totalRevenue = "$1.25M";
            totalOrders = "1,600";
            activeCustomers = "254";
            customerRetentionRate = "74%";

            FilteredSalesDataSource = SalesDataSource.Where(s => s.Date >= startDate && s.Date <= endDate).ToList();

            OrderDataSource = new List<OrderData>
        {
            new OrderData { Country = "France", OrderCount = 290 },
            new OrderData { Country = "Germany", OrderCount = 520 },
            new OrderData { Country = "Canada", OrderCount = 620 },
            new OrderData { Country = "USA", OrderCount = 310 },
            new OrderData { Country = "Brazil", OrderCount = 400 },
            new OrderData { Country = "India", OrderCount = 190 },
            new OrderData { Country = "Japan", OrderCount = 280 },
            new OrderData { Country = "China", OrderCount = 330 },
            new OrderData { Country = "UAE", OrderCount = 210 },
            new OrderData { Country = "UK", OrderCount = 450 }
        };

            ProductDataSource = new List<ProductData>
        {
            new ProductData { ProductId = "PROD-209", ProductName = "Laptop", ProductCategory = "Electronics", UnitPrice = 400, UnitsSold = 15, TotalSales = 6000 },
            new ProductData { ProductId = "PROD-206", ProductName = "Headphones", ProductCategory = "Accessories", UnitPrice = 250, UnitsSold = 15, TotalSales = 3750 },
            new ProductData { ProductId = "PROD-208", ProductName = "Smartphone", ProductCategory = "Electronics", UnitPrice = 350, UnitsSold = 10, TotalSales = 3500 },
            new ProductData { ProductId = "PROD-204", ProductName = "Office Chair", ProductCategory = "Furniture", UnitPrice = 150, UnitsSold = 10, TotalSales = 1500 },
            new ProductData { ProductId = "PROD-202", ProductName = "Coffee Maker", ProductCategory = "Appliances", UnitPrice = 100, UnitsSold = 9, TotalSales = 900 },
            new ProductData { ProductId = "PROD-201", ProductName = "Gaming Mouse", ProductCategory = "Accessories", UnitPrice = 50, UnitsSold = 9, TotalSales = 450 },
            new ProductData { ProductId = "PROD-203", ProductName = "DSLR Camera", ProductCategory = "Electronics", UnitPrice = 140, UnitsSold = 3, TotalSales = 420 },
            new ProductData { ProductId = "PROD-207", ProductName = "Tablet", ProductCategory = "Electronics", UnitPrice = 300, UnitsSold = 1, TotalSales = 300 },
            new ProductData { ProductId = "PROD-205", ProductName = "Smartwatch", ProductCategory = "Accessories", UnitPrice = 200, UnitsSold = 1, TotalSales = 200 },
            new ProductData { ProductId = "PROD-210", ProductName = "Keyboard", ProductCategory = "Electronics", UnitPrice = 100, UnitsSold = 1, TotalSales = 100 }
        };
        }
    }
}
