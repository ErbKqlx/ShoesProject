using Microsoft.EntityFrameworkCore;
using ShoesProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesProject
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDate = new DataGridViewTextBoxColumn();
            colDate.Name = "colDate";
            colDate.FillWeight = 10;
            colDate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOrders.Columns.AddRange([
                colInfo, colDate,
                ]);

            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (var db = new ShopDbContext())
                {
                    var orders = db.Orders
                        .Include(i => i.Status)
                        .Include(i => i.DeliveryPoint)
                        .ToList();

                    dgvOrders.SuspendLayout();
                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        int rowIndex = dgvOrders.Rows.Add();
                        var row = dgvOrders.Rows[rowIndex];

                        row.Cells["colInfo"].Value = FormatOrderInfo(order);

                        row.Cells["colDate"].Value = $"{order.DeliveryDate}";
                        row.Cells["colDate"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }

                    dgvOrders.ResumeLayout();
                    dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatOrderInfo(Order order)
        {
            string articleText = "";

            var productsOrders = order.ProductsOrders;

            foreach (var product in productsOrders)
            {
                articleText += product.Product.Art + ", " + product.Quantity;
            }

            return $"{articleText}" + Environment.NewLine +
                $"Статус заказа: {order.Status.StatusName}" + Environment.NewLine +
                $"Адрес пункта выдачи: {order.DeliveryPoint.DeliveryAddress}" + Environment.NewLine +
                $"Дата заказа: {order.OrderDate}";
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    base.OnFormClosing(e);
        //}
    }
}
