namespace TestWindowsFormsApp {
    partial class NonVisualComponentsTestForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.groupBoxContext = new System.Windows.Forms.GroupBox();
            this.buttonGenerateContext = new System.Windows.Forms.Button();
            this.labelTitleContext = new System.Windows.Forms.Label();
            this.textBoxTitleContext = new System.Windows.Forms.TextBox();
            this.lipatovContextPdf = new LipatovNonVisualComponents.LipatovContextPdf(this.components);
            this.groupBoxTable = new System.Windows.Forms.GroupBox();
            this.buttonGenerateTable = new System.Windows.Forms.Button();
            this.labelTitleTable = new System.Windows.Forms.Label();
            this.textBoxTitleTable = new System.Windows.Forms.TextBox();
            this.lipatovTablePdf = new LipatovNonVisualComponents.LipatovTablePdf(this.components);
            this.groupBoxChart = new System.Windows.Forms.GroupBox();
            this.buttonGenerateChart = new System.Windows.Forms.Button();
            this.labelTitleChart = new System.Windows.Forms.Label();
            this.textBoxTitleChart = new System.Windows.Forms.TextBox();
            this.labelNameChart = new System.Windows.Forms.Label();
            this.textBoxNameChart = new System.Windows.Forms.TextBox();
            this.lipatovChartPdf = new LipatovNonVisualComponents.LipatovChartPdf(this.components);
            this.groupBoxContext.SuspendLayout();
            this.groupBoxTable.SuspendLayout();
            this.groupBoxChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxContext
            // 
            this.groupBoxContext.Controls.Add(this.buttonGenerateContext);
            this.groupBoxContext.Controls.Add(this.labelTitleContext);
            this.groupBoxContext.Controls.Add(this.textBoxTitleContext);
            this.groupBoxContext.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxContext.Location = new System.Drawing.Point(12, 12);
            this.groupBoxContext.Name = "groupBoxContext";
            this.groupBoxContext.Size = new System.Drawing.Size(245, 143);
            this.groupBoxContext.TabIndex = 0;
            this.groupBoxContext.TabStop = false;
            this.groupBoxContext.Text = "Компонент 1";
            // 
            // buttonGenerateContext
            // 
            this.buttonGenerateContext.Location = new System.Drawing.Point(6, 95);
            this.buttonGenerateContext.Name = "buttonGenerateContext";
            this.buttonGenerateContext.Size = new System.Drawing.Size(233, 32);
            this.buttonGenerateContext.TabIndex = 3;
            this.buttonGenerateContext.Text = "Сгенерировать";
            this.buttonGenerateContext.UseVisualStyleBackColor = true;
            this.buttonGenerateContext.Click += new System.EventHandler(this.buttonGenerateContext_Click);
            // 
            // labelTitleContext
            // 
            this.labelTitleContext.Location = new System.Drawing.Point(6, 25);
            this.labelTitleContext.Name = "labelTitleContext";
            this.labelTitleContext.Size = new System.Drawing.Size(233, 22);
            this.labelTitleContext.TabIndex = 2;
            this.labelTitleContext.Text = "Заголовок документа:";
            this.labelTitleContext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTitleContext
            // 
            this.textBoxTitleContext.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitleContext.Location = new System.Drawing.Point(6, 55);
            this.textBoxTitleContext.Name = "textBoxTitleContext";
            this.textBoxTitleContext.Size = new System.Drawing.Size(233, 29);
            this.textBoxTitleContext.TabIndex = 1;
            // 
            // lipatovContextPdf
            // 
            this.lipatovContextPdf.ErrorMessage = null;
            // 
            // groupBoxTable
            // 
            this.groupBoxTable.Controls.Add(this.buttonGenerateTable);
            this.groupBoxTable.Controls.Add(this.labelTitleTable);
            this.groupBoxTable.Controls.Add(this.textBoxTitleTable);
            this.groupBoxTable.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTable.Location = new System.Drawing.Point(268, 12);
            this.groupBoxTable.Name = "groupBoxTable";
            this.groupBoxTable.Size = new System.Drawing.Size(245, 143);
            this.groupBoxTable.TabIndex = 4;
            this.groupBoxTable.TabStop = false;
            this.groupBoxTable.Text = "Компонент 2";
            // 
            // buttonGenerateTable
            // 
            this.buttonGenerateTable.Location = new System.Drawing.Point(6, 95);
            this.buttonGenerateTable.Name = "buttonGenerateTable";
            this.buttonGenerateTable.Size = new System.Drawing.Size(233, 32);
            this.buttonGenerateTable.TabIndex = 3;
            this.buttonGenerateTable.Text = "Сгенерировать";
            this.buttonGenerateTable.UseVisualStyleBackColor = true;
            this.buttonGenerateTable.Click += new System.EventHandler(this.buttonGenerateTable_Click);
            // 
            // labelTitleTable
            // 
            this.labelTitleTable.Location = new System.Drawing.Point(6, 25);
            this.labelTitleTable.Name = "labelTitleTable";
            this.labelTitleTable.Size = new System.Drawing.Size(233, 22);
            this.labelTitleTable.TabIndex = 2;
            this.labelTitleTable.Text = "Заголовок документа:";
            this.labelTitleTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTitleTable
            // 
            this.textBoxTitleTable.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitleTable.Location = new System.Drawing.Point(6, 55);
            this.textBoxTitleTable.Name = "textBoxTitleTable";
            this.textBoxTitleTable.Size = new System.Drawing.Size(233, 29);
            this.textBoxTitleTable.TabIndex = 1;
            // 
            // lipatovTablePdf
            // 
            this.lipatovTablePdf.ErrorMessage = null;
            // 
            // groupBoxChart
            // 
            this.groupBoxChart.Controls.Add(this.labelNameChart);
            this.groupBoxChart.Controls.Add(this.textBoxNameChart);
            this.groupBoxChart.Controls.Add(this.buttonGenerateChart);
            this.groupBoxChart.Controls.Add(this.labelTitleChart);
            this.groupBoxChart.Controls.Add(this.textBoxTitleChart);
            this.groupBoxChart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxChart.Location = new System.Drawing.Point(524, 12);
            this.groupBoxChart.Name = "groupBoxChart";
            this.groupBoxChart.Size = new System.Drawing.Size(245, 208);
            this.groupBoxChart.TabIndex = 5;
            this.groupBoxChart.TabStop = false;
            this.groupBoxChart.Text = "Компонент 3";
            // 
            // buttonGenerateChart
            // 
            this.buttonGenerateChart.Location = new System.Drawing.Point(0, 162);
            this.buttonGenerateChart.Name = "buttonGenerateChart";
            this.buttonGenerateChart.Size = new System.Drawing.Size(233, 32);
            this.buttonGenerateChart.TabIndex = 3;
            this.buttonGenerateChart.Text = "Сгенерировать";
            this.buttonGenerateChart.UseVisualStyleBackColor = true;
            this.buttonGenerateChart.Click += new System.EventHandler(this.buttonGenerateChart_Click);
            // 
            // labelTitleChart
            // 
            this.labelTitleChart.Location = new System.Drawing.Point(6, 25);
            this.labelTitleChart.Name = "labelTitleChart";
            this.labelTitleChart.Size = new System.Drawing.Size(233, 22);
            this.labelTitleChart.TabIndex = 2;
            this.labelTitleChart.Text = "Заголовок документа:";
            this.labelTitleChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTitleChart
            // 
            this.textBoxTitleChart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitleChart.Location = new System.Drawing.Point(6, 55);
            this.textBoxTitleChart.Name = "textBoxTitleChart";
            this.textBoxTitleChart.Size = new System.Drawing.Size(233, 29);
            this.textBoxTitleChart.TabIndex = 1;
            // 
            // labelNameChart
            // 
            this.labelNameChart.Location = new System.Drawing.Point(6, 92);
            this.labelNameChart.Name = "labelNameChart";
            this.labelNameChart.Size = new System.Drawing.Size(233, 22);
            this.labelNameChart.TabIndex = 5;
            this.labelNameChart.Text = "Название диаграммы:";
            this.labelNameChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNameChart
            // 
            this.textBoxNameChart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameChart.Location = new System.Drawing.Point(6, 122);
            this.textBoxNameChart.Name = "textBoxNameChart";
            this.textBoxNameChart.Size = new System.Drawing.Size(233, 29);
            this.textBoxNameChart.TabIndex = 4;
            // 
            // lipatovChartPdf
            // 
            this.lipatovChartPdf.ErrorMessage = null;
            // 
            // NonVisualComponentsTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 225);
            this.Controls.Add(this.groupBoxChart);
            this.Controls.Add(this.groupBoxTable);
            this.Controls.Add(this.groupBoxContext);
            this.Name = "NonVisualComponentsTestForm";
            this.Text = "Тестовое приложение";
            this.groupBoxContext.ResumeLayout(false);
            this.groupBoxContext.PerformLayout();
            this.groupBoxTable.ResumeLayout(false);
            this.groupBoxTable.PerformLayout();
            this.groupBoxChart.ResumeLayout(false);
            this.groupBoxChart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxContext;
        private System.Windows.Forms.Button buttonGenerateContext;
        private System.Windows.Forms.Label labelTitleContext;
        private System.Windows.Forms.TextBox textBoxTitleContext;
        private LipatovNonVisualComponents.LipatovContextPdf lipatovContextPdf;
        private System.Windows.Forms.GroupBox groupBoxTable;
        private System.Windows.Forms.Button buttonGenerateTable;
        private System.Windows.Forms.Label labelTitleTable;
        private System.Windows.Forms.TextBox textBoxTitleTable;
        private LipatovNonVisualComponents.LipatovTablePdf lipatovTablePdf;
        private System.Windows.Forms.GroupBox groupBoxChart;
        private System.Windows.Forms.Label labelNameChart;
        private System.Windows.Forms.TextBox textBoxNameChart;
        private System.Windows.Forms.Button buttonGenerateChart;
        private System.Windows.Forms.Label labelTitleChart;
        private System.Windows.Forms.TextBox textBoxTitleChart;
        private LipatovNonVisualComponents.LipatovChartPdf lipatovChartPdf;
    }
}