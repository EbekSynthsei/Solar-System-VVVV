extern alias e2;
extern alias e70;
extern alias e20;

using n2 = _VL_FuzzySearch_;
using n4 = _VL_Text_SimMetrics_.Text.Metrics.Experimental;
using n6 = e20::SimMetricsCore.Metric;
using n12 = _VL_CoreLib_;
using n8 = _VL_FuzzySearch_.Text.FuzzySearch;
using n7 = _VL_Text_SimMetrics_.Text;
using n3 = _VL_Text_SimMetrics_.Text.Metrics;
using n5 = e20::SimMetricsCore.API;
using n14 = e70::VL.App.WindowsForms;
using n11 = e2::VL.Core;
using n13 = global::System;
using n1 = e2::VL.Core.CompilerServices;
using n9 = _VL_FuzzySearch_.Text.FuzzySearch.Search;
using n10 = _VL_Text_SimMetrics_;

[assembly: n1.CompilerVersionAttribute("2021.4.9-971+1d0a0c7789")]
[assembly: n1.AssemblyInitializerAttribute(typeof(n2.QDVtT0Z8fBYMjLwlcbJ0WvInitializer))]
[assembly: n1.TypeImportAttribute("Levenshtein", "Text.Metrics", typeof(n3.Levenshtein_OJrvV9iNlszM3NMnpNJNBc), typeof(n3.Levenshtein_OJrvV9iNlszM3NMnpNJNBc), false)]
[assembly: n1.TypeImportAttribute("ChapmanMeanLength", "Text.Metrics", typeof(n3.ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C), typeof(n3.ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C), false)]
[assembly: n1.TypeImportAttribute("ChapmanLengthDeviation", "Text.Metrics", typeof(n3.ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH), typeof(n3.ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH), false)]
[assembly: n1.TypeImportAttribute("Jaro", "Text.Metrics", typeof(n3.Jaro_DrcW6V6F6QmOXG2v7r86Hc), typeof(n3.Jaro_DrcW6V6F6QmOXG2v7r86Hc), false)]
[assembly: n1.TypeImportAttribute("JaroWinkler", "Text.Metrics", typeof(n3.JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t), typeof(n3.JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t), false)]
[assembly: n1.TypeImportAttribute("BlockDistance", "Text.Metrics", typeof(n4.BlockDistance_ChgRU4uGRHlOnnQOfxuh83), typeof(n4.BlockDistance_ChgRU4uGRHlOnnQOfxuh83), false)]
[assembly: n1.TypeImportAttribute("CosineSimilarity", "Text.Metrics", typeof(n4.CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna), typeof(n4.CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna), false)]
[assembly: n1.TypeImportAttribute("DiceSimilarity", "Text.Metrics", typeof(n4.DiceSimilarity_K2wlsa7dCqKLHM44uddjlv), typeof(n4.DiceSimilarity_K2wlsa7dCqKLHM44uddjlv), false)]
[assembly: n1.TypeImportAttribute("EuclideanDistance", "Text.Metrics", typeof(n4.EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl), typeof(n4.EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl), false)]
[assembly: n1.TypeImportAttribute("JaccardSimilarity", "Text.Metrics", typeof(n4.JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a), typeof(n4.JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a), false)]
[assembly: n1.TypeImportAttribute("NeedlemanWunch", "Text.Metrics", typeof(n4.NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn), typeof(n4.NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn), false)]
[assembly: n1.TypeImportAttribute("IStringMetric", "Text.Metrics", typeof(n5.IStringMetric), null, false)]
[assembly: n1.TypeImportAttribute("Levenstein", "Text.Metrics", typeof(n6.Levenstein), typeof(n6.Levenstein), false)]
[assembly: n1.TypeImportAttribute("ChapmanLengthDeviation", "Text.Metrics", typeof(n6.ChapmanLengthDeviation), typeof(n6.ChapmanLengthDeviation), false)]
[assembly: n1.TypeImportAttribute("ChapmanMeanLength", "Text.Metrics", typeof(n6.ChapmanMeanLength), typeof(n6.ChapmanMeanLength), false)]
[assembly: n1.TypeImportAttribute("BlockDistance", "Text.Metrics", typeof(n6.BlockDistance), typeof(n6.BlockDistance), false)]
[assembly: n1.TypeImportAttribute("CosineSimilarity", "Text.Metrics", typeof(n6.CosineSimilarity), typeof(n6.CosineSimilarity), false)]
[assembly: n1.TypeImportAttribute("DiceSimilarity", "Text.Metrics", typeof(n6.DiceSimilarity), typeof(n6.DiceSimilarity), false)]
[assembly: n1.TypeImportAttribute("EuclideanDistance", "Text.Metrics", typeof(n6.EuclideanDistance), typeof(n6.EuclideanDistance), false)]
[assembly: n1.TypeImportAttribute("JaccardSimilarity", "Text.Metrics", typeof(n6.JaccardSimilarity), typeof(n6.JaccardSimilarity), false)]
[assembly: n1.TypeImportAttribute("Jaro", "Text.Metrics", typeof(n6.Jaro), typeof(n6.Jaro), false)]
[assembly: n1.TypeImportAttribute("JaroWinkler", "Text.Metrics", typeof(n6.JaroWinkler), typeof(n6.JaroWinkler), false)]
[assembly: n1.TypeImportAttribute("VL.Text.SimMetricsApplication", "Text", typeof(n7.VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP), typeof(n7.VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP), false)]
[assembly: n1.TypeImportAttribute("Search", "Text.FuzzySearch", typeof(n8.Search_Vihr5DFy03FLLX8M2rP0e3), typeof(n8.Search_Vihr5DFy03FLLX8M2rP0e3), false)]
[assembly: n1.TypeImportAttribute("SpliceSearchResult", "Text.FuzzySearch", typeof(n8.SpliceSearchResult_QTgqAnyg4VMNspLitcV86m), typeof(n8.SpliceSearchResult_QTgqAnyg4VMNspLitcV86m), false)]
[assembly: n1.TypeImportAttribute("SearchResult", "Text.FuzzySearch.Search", typeof(n9.SearchResult_R), typeof(n9.SearchResult_R), true)]
[assembly: n1.TypeImportAttribute("Similarity", "Text.FuzzySearch.Search", typeof(n9.Similarity_R), typeof(n9.Similarity_R), true)]
[assembly: n1.TypeImportAttribute("Preprocessor", "Text.FuzzySearch.Search", typeof(n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa), typeof(n9.Preprocessor_OKbFWImbj2eQKzAF2Fggxa), false)]
[assembly: n1.TypeImportAttribute("SearchWithoutPreprocessor", "Text.FuzzySearch", typeof(n8.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ), typeof(n8.SearchWithoutPreprocessor_QNoCSs9ybjcOpshRtevLwJ), false)]
[assembly: n1.TypeImportAttribute("VL.FuzzySearchApplication", "Text.FuzzySearch", typeof(n8.VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP), typeof(n8.VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP), false)]
[assembly: n1.AdaptiveImplementationsAttribute(typeof(n10.__AdaptiveImplementations__Q2hkq2dyP13NaENHCi4CLy))]
[assembly: n1.AdaptiveImplementationsAttribute(typeof(n2.__AdaptiveImplementations__QDVtT0Z8fBYMjLwlcbJ0Wv))]
namespace _VL_FuzzySearch_
{
    public sealed class QDVtT0Z8fBYMjLwlcbJ0WvInitializer : n1.AssemblyInitializer<n2.QDVtT0Z8fBYMjLwlcbJ0WvInitializer>
    {
        protected override sealed void RegisterServices(n11.IVLFactory factory)
        {
            n12.LMFQrbYrtQvO4pn4vSywS3Initializer.Default.Init(factory);
        }
    }
}

internal sealed class Program
{
    [n13.STAThreadAttribute()]
    public static void Main()
    {
        using (var appHost = new n14.WindowsFormsAppHost<n8.VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP>(c => n8.VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP.Create(c), s => ((n8.VL_FuzzySearchApplication_Bhs4SL1pMxOPqTWtYYsSWP)s).Update()))
            appHost.Run();
    }
}