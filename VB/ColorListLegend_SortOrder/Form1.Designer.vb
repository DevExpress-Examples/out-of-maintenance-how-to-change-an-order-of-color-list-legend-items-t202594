Namespace ColorListLegend_SortOrder
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.lbSortOrder = New System.Windows.Forms.ListBox()
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl
            ' 
            Me.mapControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl.Location = New System.Drawing.Point(0, 0)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(384, 261)
            Me.mapControl.TabIndex = 0
            ' 
            ' lbSortOrder
            ' 
            Me.lbSortOrder.FormattingEnabled = True
            Me.lbSortOrder.Location = New System.Drawing.Point(13, 13)
            Me.lbSortOrder.Name = "lbSortOrder"
            Me.lbSortOrder.Size = New System.Drawing.Size(184, 43)
            Me.lbSortOrder.TabIndex = 1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(384, 261)
            Me.Controls.Add(Me.lbSortOrder)
            Me.Controls.Add(Me.mapControl)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mapControl As DevExpress.XtraMap.MapControl
        Private WithEvents lbSortOrder As System.Windows.Forms.ListBox
    End Class
End Namespace

