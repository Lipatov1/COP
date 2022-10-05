using LipatovNonVisualComponents.Enums;
using System.Collections.Generic;

namespace LipatovNonVisualComponents.HelperModels {
    public class ChartParameters {
        public string Path { get; set; }
        public string Title { get; set; }
        public string ChartName { get; set; }
        public ChartLegendLocation ChartLegendLocation { get; set; }
        public List<ChartData> Data { get; set; }
    }
}