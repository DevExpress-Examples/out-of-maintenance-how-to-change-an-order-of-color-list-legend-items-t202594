namespace ColorListLegend_SortOrder {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.lbSortOrder = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl
            // 
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(384, 261);
            this.mapControl.TabIndex = 0;
            // 
            // lbSortOrder
            // 
            this.lbSortOrder.FormattingEnabled = true;
            this.lbSortOrder.Location = new System.Drawing.Point(13, 13);
            this.lbSortOrder.Name = "lbSortOrder";
            this.lbSortOrder.Size = new System.Drawing.Size(184, 43);
            this.lbSortOrder.TabIndex = 1;
            this.lbSortOrder.SelectedIndexChanged += new System.EventHandler(this.lbSortOrder_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lbSortOrder);
            this.Controls.Add(this.mapControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl;
        private System.Windows.Forms.ListBox lbSortOrder;
    }
}

