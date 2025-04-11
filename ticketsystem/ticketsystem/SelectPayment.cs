using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticketsystem
{
    public partial class SelectPayment : Form
    {
        private string from;
        private string to;

        // Constructor có 2 tham số
        public SelectPayment(string startLocation, string endLocation)
        {
            InitializeComponent();
            from = startLocation;
            to = endLocation;

            // Gán dữ liệu vào label, textbox hoặc xử lý tiếp tại đây
            // Ví dụ:
            lblRoute.Text = $"Route: {from} → {to}";
            ShowRouteInfo();
        }
        public SelectPayment()
        {
            InitializeComponent();
        }

        private void SelectPayment_Load(object sender, EventArgs e)
        {

        }
        private readonly string[] stations = new string[]
        {
    "BenThanh", "Saigon Opera House", "BaSon", "Van Thanh Park", "Tan Cang",
    "Thao Dien", "An Phu", "Rach Chiec", "Phuoc Long", "Binh Thai",
    "Thu Duc", "Hi-Tech Park", "National University", "Suoi Tien Terminal"
        };

        private readonly int[,] priceTable = new int[,]
        {
    {  0,  7,  7,  7,  9, 10, 12, 14, 16, 17, 18, 19, 20, 20 },
    {  7,  0,  7,  7,  9, 10, 12, 14, 16, 17, 18, 19, 20, 20 },
    {  7,  7,  0,  7,  7,  9, 10, 12, 14, 16, 17, 18, 19, 20 },
    {  7,  7,  7,  0,  7,  7,  9, 10, 12, 14, 16, 17, 18, 19 },
    {  9,  9,  7,  7,  0,  7,  7,  9, 10, 12, 14, 16, 17, 18 },
    { 10, 10,  9,  7,  7,  0,  7,  7,  9, 10, 12, 14, 16, 17 },
    { 12, 12, 10,  9,  7,  7,  0,  7,  7,  9, 10, 12, 14, 16 },
    { 14, 14, 12, 10,  9,  7,  7,  0,  7,  7,  9, 10, 12, 14 },
    { 16, 16, 14, 12, 10,  9,  7,  7,  0,  7,  7,  9, 10, 11 },
    { 17, 17, 16, 14, 12, 10,  9,  7,  7,  0,  7,  7,  9, 10 },
    { 18, 18, 17, 16, 14, 12, 10,  9,  7,  7,  0,  7,  7,  8 },
    { 19, 19, 18, 17, 16, 14, 12, 10,  9,  7,  7,  0,  7,  7 },
    { 20, 20, 19, 18, 17, 16, 14, 12, 10,  9,  7,  7,  0,  7 },
    { 20, 20, 20, 19, 18, 17, 16, 14, 11, 10,  8,  7,  7,  0 }
        };

        private int CalculatePrice(string from, string to)
        {
            int fromIndex = Array.IndexOf(stations, from);
            int toIndex = Array.IndexOf(stations, to);

            if (fromIndex == -1 || toIndex == -1)
                return 0; // Không tìm thấy

            return priceTable[fromIndex, toIndex] * 1000;      
        }


        private void ShowRouteInfo()
        {
            int price = CalculatePrice(from, to);
            lblRoute.Text = $"Lộ trình: {from} → {to}\nGiá vé: {price:N0} VNĐ";
        }

    }
}
