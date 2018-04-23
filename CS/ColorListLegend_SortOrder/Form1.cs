using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace ColorListLegend_SortOrder {
    public partial class Form1 : Form {
        ColorListLegend legend;
        
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            legend = new ColorListLegend() { Alignment = LegendAlignment.TopRight };
            legend.CustomItems.Add(new ColorLegendItem() { 
                Color = Color.Orange, 
                Text = "First color" 
            });
            legend.CustomItems.Add(new ColorLegendItem() {
                Color = Color.LightGray,
                Text = "Second color"
            });
            legend.CustomItems.Add(new ColorLegendItem() {
                Color = Color.Coral,
                Text = "Third color"
            });
            mapControl.Legends.Add(legend);

            lbSortOrder.DataSource = Enum.GetValues(typeof(LegendItemsSortOrder));
        }

        private void lbSortOrder_SelectedIndexChanged(object sender, EventArgs e) {
            legend.SortOrder = (LegendItemsSortOrder)lbSortOrder.SelectedValue;
        }
    }
}
