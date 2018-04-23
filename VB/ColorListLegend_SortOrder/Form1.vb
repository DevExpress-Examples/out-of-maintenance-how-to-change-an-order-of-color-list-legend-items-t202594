Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace ColorListLegend_SortOrder
    Partial Public Class Form1
        Inherits Form

        Private legend As ColorListLegend

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            legend = New ColorListLegend() With {.Alignment = LegendAlignment.TopRight}
            legend.CustomItems.Add(New ColorLegendItem() With {.Color = Color.Orange, .Text = "First color"})
            legend.CustomItems.Add(New ColorLegendItem() With {.Color = Color.LightGray, .Text = "Second color"})
            legend.CustomItems.Add(New ColorLegendItem() With {.Color = Color.Coral, .Text = "Third color"})
            mapControl.Legends.Add(legend)

            lbSortOrder.DataSource = System.Enum.GetValues(GetType(LegendItemsSortOrder))
        End Sub

        Private Sub lbSortOrder_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbSortOrder.SelectedIndexChanged
            legend.SortOrder = DirectCast(lbSortOrder.SelectedValue, LegendItemsSortOrder)
        End Sub
    End Class
End Namespace
