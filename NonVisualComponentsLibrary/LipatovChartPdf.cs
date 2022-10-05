using MigraDoc.DocumentObjectModel.Shapes.Charts;
using LipatovNonVisualComponents.HelperModels;
using LipatovNonVisualComponents.Enums;
using MigraDoc.DocumentObjectModel;
using System.ComponentModel;
using MigraDoc.Rendering;
using System;

namespace LipatovNonVisualComponents {
    public partial class LipatovChartPdf : Component {
        public string ErrorMessage { get; set; }

        public LipatovChartPdf() {
            InitializeComponent();
        }

        public LipatovChartPdf(IContainer container) {
            container.Add(this);
            InitializeComponent();
        }

        private bool CheckInput(ChartParameters parameters) {
            if (parameters == null) {
                ErrorMessage = "Не указаны параметры диаграммы";
                return false;
            }

            if (string.IsNullOrEmpty(parameters.Path)) {
                ErrorMessage = "Не указан путь";
                return false;
            }

            if (string.IsNullOrEmpty(parameters.Title)) {
                ErrorMessage = "Не указан заголовок";
                return false;
            }

            if (string.IsNullOrEmpty(parameters.ChartName)) {
                ErrorMessage = "Не указано название диаграммы";
                return false;
            }

            if (!Enum.IsDefined(typeof(ChartLegendLocation), parameters.ChartLegendLocation)) {
                ErrorMessage = "Не указано местоположение легенды";
                return false;
            }

            if (parameters.Data == null) {
                ErrorMessage = "Не указаны данные";
                return false;
            }

            return true;
        }

        public bool CreateDocument(ChartParameters parameters) {
            if (!CheckInput(parameters)) {
                return false;
            }

            var document = new Document();

            var styleTitle = document.Styles["Normal"];
            styleTitle.Font.Name = "Times New Roman";
            styleTitle.Font.Size = 14;
            styleTitle.Font.Color = Colors.Black;
            styleTitle.Font.Bold = true;
            document.Styles.AddStyle("NormalTitle", "Normal");

            var section = document.AddSection();
            var paragraph = section.AddParagraph(parameters.Title);
            paragraph.Format.Alignment = ParagraphAlignment.Left;
            paragraph.Style = "NormalTitle";

            var chart = section.AddChart(ChartType.Pie2D);
            chart.Left = 0;
            chart.Width = Unit.FromCentimeter(16);
            chart.Height = Unit.FromCentimeter(10);
            chart.HeaderArea.AddParagraph(parameters.ChartName);
            chart.HeaderArea.Format.Font.Bold = false;

            switch (parameters.ChartLegendLocation) {
                case ChartLegendLocation.Top: {
                        chart.TopArea.AddLegend();
                        break;
                    }
                case ChartLegendLocation.Right: {
                        chart.RightArea.AddLegend();
                        break;
                    }
                case ChartLegendLocation.Bottom: {
                        chart.BottomArea.AddLegend();
                        break;
                    }
                case ChartLegendLocation.Left: {
                        chart.LeftArea.AddLegend();
                        break;
                    }
                default: {
                        chart.BottomArea.AddLegend();
                        break;
                    }
            }

            Series series = chart.SeriesCollection.AddSeries();
            XSeries xseries = chart.XValues.AddXSeries();

            foreach (var data in parameters.Data) {
                series.Add(data.Series);
                xseries.Add(data.XSeries);
            }

            chart.DataLabel.Type = DataLabelType.Percent;
            chart.DataLabel.Position = DataLabelPosition.OutsideEnd;

            var renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always) { Document = document };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(parameters.Path);
            return true;
        }
    }
}