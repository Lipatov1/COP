using MigraDoc.DocumentObjectModel;
using System.ComponentModel;
using MigraDoc.Rendering;

namespace LipatovNonVisualComponents {
    public partial class LipatovContextPdf : Component {
        [Category("Пользовательская категория"), Description("Содержание ошибки")]
        public string ErrorMessage { get; set; }

        public LipatovContextPdf() {
            InitializeComponent();
        }

        public LipatovContextPdf(IContainer container) {
            container.Add(this);
            InitializeComponent();
        }

        public bool CreateDocument(string Path, string Title, string[] ImagesFileNames) {
            if (string.IsNullOrEmpty(Path)) {
                ErrorMessage = "Не указан путь";
                return false;
            }

            if (string.IsNullOrEmpty(Title)) {
                ErrorMessage = "Не указан заголовок";
                return false;
            }

            if (ImagesFileNames == null) {
                ErrorMessage = "Не указан массив изображений";
                return false;
            }

            Document document = new Document();
            Section section = document.AddSection();
            Paragraph paragraph = section.AddParagraph();
            paragraph.AddFormattedText(Title, TextFormat.Bold);
            paragraph.Format.Alignment = ParagraphAlignment.Center;

            foreach (var image in ImagesFileNames) {
                section.AddImage(image);
            }

            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always) { Document = document };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(Path);
            return true;
        }
    }
}