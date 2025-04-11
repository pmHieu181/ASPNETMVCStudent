using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ticketsystem
{
    public partial class SelectDestination : Form
    {
        public SelectDestination()
        {
            InitializeComponent();
        }

        private void SelectDestination_Load(object sender, EventArgs e)
        {
            foreach (Control c in grpFrom.Controls)
            {
                if (c is Button)
                {
                    c.Click += LocationButton_Click;
                    c.Tag = "From"; // đánh dấu đây là nút thuộc nhóm From
                }
            }

            foreach (Control c in grpTo.Controls)
            {
                if (c is Button)
                {
                    c.Click += LocationButton_Click;
                    c.Tag = "To"; // đánh dấu đây là nút thuộc nhóm To
                }
            }
        }
        private void LocationButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            string location = btn.Text;
            string type = btn.Tag.ToString(); // From hoặc To

            if (type == "From")
            {
                startLocation = location;
                lblFromSelected.Text = "From: " + startLocation;
            }
            else if (type == "To")
            {
                endLocation = location;
                lblToSelected.Text = "To: " + endLocation;
            }
        }
        private string startLocation = "";
        private string endLocation = "";
        private bool isSelectingFrom = true; // mặc định chọn điểm xuất phát

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(startLocation) || string.IsNullOrEmpty(endLocation))
            {
                MessageBox.Show("Please select From and to.", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị xác nhận (có thể bỏ qua bước này nếu không cần)
            string route = $"Route From {startLocation} to {endLocation}";
            MessageBox.Show(route, "Successfully Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mở form khác và truyền dữ liệu
            SelectPayment detailsForm = new SelectPayment(startLocation, endLocation);
            detailsForm.Show();
            this.Hide(); // Ẩn form hiện tại
        }
    }
}
