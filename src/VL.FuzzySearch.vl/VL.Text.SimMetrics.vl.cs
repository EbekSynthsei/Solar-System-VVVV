extern alias e3;
extern alias e2;
extern alias e20;

using n5 = _VL_Text_SimMetrics_.Text.Metrics.Experimental;
using n7 = e20::SimMetricsCore.Metric;
using n10 = _VL_Text_SimMetrics_.Text;
using n4 = _VL_Text_SimMetrics_.Text.Metrics;
using n11 = global::System.Collections.Generic;
using n3 = e20::SimMetricsCore.API;
using n8 = e3::VL.Lib.Primitive;
using n1 = e2::VL.Core;
using n2 = global::System;
using n6 = e2::VL.Core.CompilerServices;
using n9 = global::System.Runtime.CompilerServices;

namespace _VL_Text_SimMetrics_.Text.Metrics
{
    [n1.ElementAttribute(TracingId = 223486U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "OJrvV9iNlszM3NMnpNJNBc", Name = "Levenshtein_OJrvV9iNlszM3NMnpNJNBc")]
    [n2.SerializableAttribute]
    public class Levenshtein_OJrvV9iNlszM3NMnpNJNBc : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.Levenshtein_OJrvV9iNlszM3NMnpNJNBc Create(n1.NodeContext Node_Context)
        {
            var instance = new Levenshtein_OJrvV9iNlszM3NMnpNJNBc(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.Levenshtein_OJrvV9iNlszM3NMnpNJNBc CreateDefault()
        {
            var instance = new Levenshtein_OJrvV9iNlszM3NMnpNJNBc(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Levenshtein_OJrvV9iNlszM3NMnpNJNBc Get(out n3.IStringMetric Output_Out)
        {
            n7.Levenstein __pad_Ir8xnXGlyQLP24NudO06xR_0 = this.__slot_Ir8xnXGlyQLP24NudO06xR;
            n3.IStringMetric Output_Out_1 = (n3.IStringMetric)__pad_Ir8xnXGlyQLP24NudO06xR_0;
            Output_Out = Output_Out_1;
            return this;
        }

        public n4.Levenshtein_OJrvV9iNlszM3NMnpNJNBc __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n7.Levenstein();
            n7.Levenstein __pad_Ir8xnXGlyQLP24NudO06xR_1 = Output_0;
            n4.Levenshtein_OJrvV9iNlszM3NMnpNJNBc that_2 = this;
            this.__slot_Ir8xnXGlyQLP24NudO06xR = Output_0;
            return that_2;
        }

        public n4.Levenshtein_OJrvV9iNlszM3NMnpNJNBc __CreateDefault__()
        {
            n4.Levenshtein_OJrvV9iNlszM3NMnpNJNBc that_0 = this;
            this.__slot_Ir8xnXGlyQLP24NudO06xR = default(n7.Levenstein);
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 223499U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "Ir8xnXGlyQLP24NudO06xR", Name = "__slot_Ir8xnXGlyQLP24NudO06xR")]
        public n7.Levenstein __slot_Ir8xnXGlyQLP24NudO06xR;
        public Levenshtein_OJrvV9iNlszM3NMnpNJNBc(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Levenshtein_OJrvV9iNlszM3NMnpNJNBc(Levenshtein_OJrvV9iNlszM3NMnpNJNBc other): base(other)
        {
            this.__slot_Ir8xnXGlyQLP24NudO06xR = other.__slot_Ir8xnXGlyQLP24NudO06xR;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Ir8xnXGlyQLP24NudO06xR", in __slot_Ir8xnXGlyQLP24NudO06xR));
        }

        internal Levenshtein_OJrvV9iNlszM3NMnpNJNBc __WITH__(n7.Levenstein __slot_Ir8xnXGlyQLP24NudO06xR)
        {
            n4.Levenshtein_OJrvV9iNlszM3NMnpNJNBc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_Ir8xnXGlyQLP24NudO06xR != this.__slot_Ir8xnXGlyQLP24NudO06xR ? new Levenshtein_OJrvV9iNlszM3NMnpNJNBc(this)
                {__slot_Ir8xnXGlyQLP24NudO06xR = __slot_Ir8xnXGlyQLP24NudO06xR} : that_0;
            else
            {
                this.__slot_Ir8xnXGlyQLP24NudO06xR = __slot_Ir8xnXGlyQLP24NudO06xR;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 223525U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "NAsvC5tzRDsMKMGoq8eG8C", Name = "ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C")]
    [n2.SerializableAttribute]
    public class ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C Create(n1.NodeContext Node_Context)
        {
            var instance = new ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C CreateDefault()
        {
            var instance = new ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C Get(out n3.IStringMetric Output_Out)
        {
            n7.ChapmanMeanLength __pad_Jt7H6frXgG0Mado5BaYSWd_0 = this.__slot_Jt7H6frXgG0Mado5BaYSWd;
            n3.IStringMetric Output_Out_1 = (n3.IStringMetric)__pad_Jt7H6frXgG0Mado5BaYSWd_0;
            Output_Out = Output_Out_1;
            return this;
        }

        public n4.ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n7.ChapmanMeanLength();
            n7.ChapmanMeanLength __pad_Jt7H6frXgG0Mado5BaYSWd_1 = Output_0;
            n4.ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C that_2 = this;
            this.__slot_Jt7H6frXgG0Mado5BaYSWd = Output_0;
            return that_2;
        }

        public n4.ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C __CreateDefault__()
        {
            n4.ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C that_0 = this;
            this.__slot_Jt7H6frXgG0Mado5BaYSWd = default(n7.ChapmanMeanLength);
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 223535U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "Jt7H6frXgG0Mado5BaYSWd", Name = "__slot_Jt7H6frXgG0Mado5BaYSWd")]
        public n7.ChapmanMeanLength __slot_Jt7H6frXgG0Mado5BaYSWd;
        public ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C(ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C other): base(other)
        {
            this.__slot_Jt7H6frXgG0Mado5BaYSWd = other.__slot_Jt7H6frXgG0Mado5BaYSWd;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Jt7H6frXgG0Mado5BaYSWd", in __slot_Jt7H6frXgG0Mado5BaYSWd));
        }

        internal ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C __WITH__(n7.ChapmanMeanLength __slot_Jt7H6frXgG0Mado5BaYSWd)
        {
            n4.ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_Jt7H6frXgG0Mado5BaYSWd != this.__slot_Jt7H6frXgG0Mado5BaYSWd ? new ChapmanMeanLength_NAsvC5tzRDsMKMGoq8eG8C(this)
                {__slot_Jt7H6frXgG0Mado5BaYSWd = __slot_Jt7H6frXgG0Mado5BaYSWd} : that_0;
            else
            {
                this.__slot_Jt7H6frXgG0Mado5BaYSWd = __slot_Jt7H6frXgG0Mado5BaYSWd;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 223552U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "JLvV853tCs2M4p8ov3jSsH", Name = "ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH")]
    [n2.SerializableAttribute]
    public class ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH Create(n1.NodeContext Node_Context)
        {
            var instance = new ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH CreateDefault()
        {
            var instance = new ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH Get(out n3.IStringMetric Output_Out)
        {
            n7.ChapmanLengthDeviation __pad_Olv9UGhE3XqNlmFHE7daEd_0 = this.__slot_Olv9UGhE3XqNlmFHE7daEd;
            n3.IStringMetric Output_Out_1 = (n3.IStringMetric)__pad_Olv9UGhE3XqNlmFHE7daEd_0;
            Output_Out = Output_Out_1;
            return this;
        }

        public n4.ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n7.ChapmanLengthDeviation();
            n7.ChapmanLengthDeviation __pad_Olv9UGhE3XqNlmFHE7daEd_1 = Output_0;
            n4.ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH that_2 = this;
            this.__slot_Olv9UGhE3XqNlmFHE7daEd = Output_0;
            return that_2;
        }

        public n4.ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH __CreateDefault__()
        {
            n4.ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH that_0 = this;
            this.__slot_Olv9UGhE3XqNlmFHE7daEd = default(n7.ChapmanLengthDeviation);
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 223564U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "Olv9UGhE3XqNlmFHE7daEd", Name = "__slot_Olv9UGhE3XqNlmFHE7daEd")]
        public n7.ChapmanLengthDeviation __slot_Olv9UGhE3XqNlmFHE7daEd;
        public ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH(ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH other): base(other)
        {
            this.__slot_Olv9UGhE3XqNlmFHE7daEd = other.__slot_Olv9UGhE3XqNlmFHE7daEd;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Olv9UGhE3XqNlmFHE7daEd", in __slot_Olv9UGhE3XqNlmFHE7daEd));
        }

        internal ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH __WITH__(n7.ChapmanLengthDeviation __slot_Olv9UGhE3XqNlmFHE7daEd)
        {
            n4.ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_Olv9UGhE3XqNlmFHE7daEd != this.__slot_Olv9UGhE3XqNlmFHE7daEd ? new ChapmanLengthDeviation_JLvV853tCs2M4p8ov3jSsH(this)
                {__slot_Olv9UGhE3XqNlmFHE7daEd = __slot_Olv9UGhE3XqNlmFHE7daEd} : that_0;
            else
            {
                this.__slot_Olv9UGhE3XqNlmFHE7daEd = __slot_Olv9UGhE3XqNlmFHE7daEd;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 223595U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "DrcW6V6F6QmOXG2v7r86Hc", Name = "Jaro_DrcW6V6F6QmOXG2v7r86Hc")]
    [n2.SerializableAttribute]
    public class Jaro_DrcW6V6F6QmOXG2v7r86Hc : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.Jaro_DrcW6V6F6QmOXG2v7r86Hc Create(n1.NodeContext Node_Context)
        {
            var instance = new Jaro_DrcW6V6F6QmOXG2v7r86Hc(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.Jaro_DrcW6V6F6QmOXG2v7r86Hc CreateDefault()
        {
            var instance = new Jaro_DrcW6V6F6QmOXG2v7r86Hc(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Jaro_DrcW6V6F6QmOXG2v7r86Hc Get(out n3.IStringMetric Output_Out)
        {
            n7.Jaro __pad_MfbjwObX8TIL7hlnTMVqdo_0 = this.__slot_MfbjwObX8TIL7hlnTMVqdo;
            n3.IStringMetric Output_Out_1 = (n3.IStringMetric)__pad_MfbjwObX8TIL7hlnTMVqdo_0;
            Output_Out = Output_Out_1;
            return this;
        }

        public n4.Jaro_DrcW6V6F6QmOXG2v7r86Hc __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n7.Jaro();
            n7.Jaro __pad_MfbjwObX8TIL7hlnTMVqdo_1 = Output_0;
            n4.Jaro_DrcW6V6F6QmOXG2v7r86Hc that_2 = this;
            this.__slot_MfbjwObX8TIL7hlnTMVqdo = Output_0;
            return that_2;
        }

        public n4.Jaro_DrcW6V6F6QmOXG2v7r86Hc __CreateDefault__()
        {
            n4.Jaro_DrcW6V6F6QmOXG2v7r86Hc that_0 = this;
            this.__slot_MfbjwObX8TIL7hlnTMVqdo = default(n7.Jaro);
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 223609U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "MfbjwObX8TIL7hlnTMVqdo", Name = "__slot_MfbjwObX8TIL7hlnTMVqdo")]
        public n7.Jaro __slot_MfbjwObX8TIL7hlnTMVqdo;
        public Jaro_DrcW6V6F6QmOXG2v7r86Hc(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Jaro_DrcW6V6F6QmOXG2v7r86Hc(Jaro_DrcW6V6F6QmOXG2v7r86Hc other): base(other)
        {
            this.__slot_MfbjwObX8TIL7hlnTMVqdo = other.__slot_MfbjwObX8TIL7hlnTMVqdo;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_MfbjwObX8TIL7hlnTMVqdo", in __slot_MfbjwObX8TIL7hlnTMVqdo));
        }

        internal Jaro_DrcW6V6F6QmOXG2v7r86Hc __WITH__(n7.Jaro __slot_MfbjwObX8TIL7hlnTMVqdo)
        {
            n4.Jaro_DrcW6V6F6QmOXG2v7r86Hc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_MfbjwObX8TIL7hlnTMVqdo != this.__slot_MfbjwObX8TIL7hlnTMVqdo ? new Jaro_DrcW6V6F6QmOXG2v7r86Hc(this)
                {__slot_MfbjwObX8TIL7hlnTMVqdo = __slot_MfbjwObX8TIL7hlnTMVqdo} : that_0;
            else
            {
                this.__slot_MfbjwObX8TIL7hlnTMVqdo = __slot_MfbjwObX8TIL7hlnTMVqdo;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 223637U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "Qz1VyqzW42QN7Z3jdFYX0t", Name = "JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t")]
    [n2.SerializableAttribute]
    public class JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t Create(n1.NodeContext Node_Context)
        {
            var instance = new JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t CreateDefault()
        {
            var instance = new JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t Get(out n3.IStringMetric Output_Out)
        {
            n7.JaroWinkler __pad_J9BJyLfwebyPlyvxp1rXeN_0 = this.__slot_J9BJyLfwebyPlyvxp1rXeN;
            n3.IStringMetric Output_Out_1 = (n3.IStringMetric)__pad_J9BJyLfwebyPlyvxp1rXeN_0;
            Output_Out = Output_Out_1;
            return this;
        }

        public n4.JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n7.JaroWinkler();
            n7.JaroWinkler __pad_J9BJyLfwebyPlyvxp1rXeN_1 = Output_0;
            n4.JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t that_2 = this;
            this.__slot_J9BJyLfwebyPlyvxp1rXeN = Output_0;
            return that_2;
        }

        public n4.JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t __CreateDefault__()
        {
            n4.JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t that_0 = this;
            this.__slot_J9BJyLfwebyPlyvxp1rXeN = default(n7.JaroWinkler);
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 223648U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "J9BJyLfwebyPlyvxp1rXeN", Name = "__slot_J9BJyLfwebyPlyvxp1rXeN")]
        public n7.JaroWinkler __slot_J9BJyLfwebyPlyvxp1rXeN;
        public JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t(JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t other): base(other)
        {
            this.__slot_J9BJyLfwebyPlyvxp1rXeN = other.__slot_J9BJyLfwebyPlyvxp1rXeN;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_J9BJyLfwebyPlyvxp1rXeN", in __slot_J9BJyLfwebyPlyvxp1rXeN));
        }

        internal JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t __WITH__(n7.JaroWinkler __slot_J9BJyLfwebyPlyvxp1rXeN)
        {
            n4.JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_J9BJyLfwebyPlyvxp1rXeN != this.__slot_J9BJyLfwebyPlyvxp1rXeN ? new JaroWinkler_Qz1VyqzW42QN7Z3jdFYX0t(this)
                {__slot_J9BJyLfwebyPlyvxp1rXeN = __slot_J9BJyLfwebyPlyvxp1rXeN} : that_0;
            else
            {
                this.__slot_J9BJyLfwebyPlyvxp1rXeN = __slot_J9BJyLfwebyPlyvxp1rXeN;
            }

            return that_0;
        }
    }
}

namespace _VL_Text_SimMetrics_.Text.Metrics.Experimental
{
    [n1.ElementAttribute(TracingId = 223678U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "ChgRU4uGRHlOnnQOfxuh83", Name = "BlockDistance_ChgRU4uGRHlOnnQOfxuh83")]
    [n2.SerializableAttribute]
    public class BlockDistance_ChgRU4uGRHlOnnQOfxuh83 : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.BlockDistance_ChgRU4uGRHlOnnQOfxuh83 Create(n1.NodeContext Node_Context)
        {
            var instance = new BlockDistance_ChgRU4uGRHlOnnQOfxuh83(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.BlockDistance_ChgRU4uGRHlOnnQOfxuh83 CreateDefault()
        {
            var instance = new BlockDistance_ChgRU4uGRHlOnnQOfxuh83(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.BlockDistance_ChgRU4uGRHlOnnQOfxuh83 Get(out n3.IStringMetric Output_Out)
        {
            n7.BlockDistance __pad_BrTFUapwkq9OnmnLyknemj_0 = this.__slot_BrTFUapwkq9OnmnLyknemj;
            n3.IStringMetric Output_Out_1 = (n3.IStringMetric)__pad_BrTFUapwkq9OnmnLyknemj_0;
            Output_Out = Output_Out_1;
            return this;
        }

        public n5.BlockDistance_ChgRU4uGRHlOnnQOfxuh83 __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.ITokeniser Tokeniser_To_Use_0 = default(n3.ITokeniser);
            var Output_1 = new n7.BlockDistance(tokeniserToUse: Tokeniser_To_Use_0);
            n7.BlockDistance __pad_BrTFUapwkq9OnmnLyknemj_2 = Output_1;
            n5.BlockDistance_ChgRU4uGRHlOnnQOfxuh83 that_3 = this;
            this.__slot_BrTFUapwkq9OnmnLyknemj = Output_1;
            return that_3;
        }

        public n5.BlockDistance_ChgRU4uGRHlOnnQOfxuh83 __CreateDefault__()
        {
            n5.BlockDistance_ChgRU4uGRHlOnnQOfxuh83 that_0 = this;
            this.__slot_BrTFUapwkq9OnmnLyknemj = default(n7.BlockDistance);
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 223696U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "BrTFUapwkq9OnmnLyknemj", Name = "__slot_BrTFUapwkq9OnmnLyknemj")]
        public n7.BlockDistance __slot_BrTFUapwkq9OnmnLyknemj;
        public BlockDistance_ChgRU4uGRHlOnnQOfxuh83(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BlockDistance_ChgRU4uGRHlOnnQOfxuh83(BlockDistance_ChgRU4uGRHlOnnQOfxuh83 other): base(other)
        {
            this.__slot_BrTFUapwkq9OnmnLyknemj = other.__slot_BrTFUapwkq9OnmnLyknemj;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_BrTFUapwkq9OnmnLyknemj", in __slot_BrTFUapwkq9OnmnLyknemj));
        }

        internal BlockDistance_ChgRU4uGRHlOnnQOfxuh83 __WITH__(n7.BlockDistance __slot_BrTFUapwkq9OnmnLyknemj)
        {
            n5.BlockDistance_ChgRU4uGRHlOnnQOfxuh83 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_BrTFUapwkq9OnmnLyknemj != this.__slot_BrTFUapwkq9OnmnLyknemj ? new BlockDistance_ChgRU4uGRHlOnnQOfxuh83(this)
                {__slot_BrTFUapwkq9OnmnLyknemj = __slot_BrTFUapwkq9OnmnLyknemj} : that_0;
            else
            {
                this.__slot_BrTFUapwkq9OnmnLyknemj = __slot_BrTFUapwkq9OnmnLyknemj;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 223731U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "BzbuyZpQ0EQL3oTG0jTgna", Name = "CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna")]
    [n2.SerializableAttribute]
    public class CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna Create(n1.NodeContext Node_Context)
        {
            var instance = new CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna CreateDefault()
        {
            var instance = new CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna Get(out n3.IStringMetric Output_Out)
        {
            n7.CosineSimilarity __pad_HAjfVH4QYAHO8vtrtWfEmH_0 = this.__slot_HAjfVH4QYAHO8vtrtWfEmH;
            n3.IStringMetric Output_Out_1 = (n3.IStringMetric)__pad_HAjfVH4QYAHO8vtrtWfEmH_0;
            Output_Out = Output_Out_1;
            return this;
        }

        public n5.CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.ITokeniser Tokeniser_To_Use_0 = default(n3.ITokeniser);
            var Output_1 = new n7.CosineSimilarity(tokeniserToUse: Tokeniser_To_Use_0);
            n7.CosineSimilarity __pad_HAjfVH4QYAHO8vtrtWfEmH_2 = Output_1;
            n5.CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna that_3 = this;
            this.__slot_HAjfVH4QYAHO8vtrtWfEmH = Output_1;
            return that_3;
        }

        public n5.CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna __CreateDefault__()
        {
            n5.CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna that_0 = this;
            this.__slot_HAjfVH4QYAHO8vtrtWfEmH = default(n7.CosineSimilarity);
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 223751U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "HAjfVH4QYAHO8vtrtWfEmH", Name = "__slot_HAjfVH4QYAHO8vtrtWfEmH")]
        public n7.CosineSimilarity __slot_HAjfVH4QYAHO8vtrtWfEmH;
        public CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna(CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna other): base(other)
        {
            this.__slot_HAjfVH4QYAHO8vtrtWfEmH = other.__slot_HAjfVH4QYAHO8vtrtWfEmH;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_HAjfVH4QYAHO8vtrtWfEmH", in __slot_HAjfVH4QYAHO8vtrtWfEmH));
        }

        internal CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna __WITH__(n7.CosineSimilarity __slot_HAjfVH4QYAHO8vtrtWfEmH)
        {
            n5.CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_HAjfVH4QYAHO8vtrtWfEmH != this.__slot_HAjfVH4QYAHO8vtrtWfEmH ? new CosineSimilarity_BzbuyZpQ0EQL3oTG0jTgna(this)
                {__slot_HAjfVH4QYAHO8vtrtWfEmH = __slot_HAjfVH4QYAHO8vtrtWfEmH} : that_0;
            else
            {
                this.__slot_HAjfVH4QYAHO8vtrtWfEmH = __slot_HAjfVH4QYAHO8vtrtWfEmH;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 223783U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "K2wlsa7dCqKLHM44uddjlv", Name = "DiceSimilarity_K2wlsa7dCqKLHM44uddjlv")]
    [n2.SerializableAttribute]
    public class DiceSimilarity_K2wlsa7dCqKLHM44uddjlv : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.DiceSimilarity_K2wlsa7dCqKLHM44uddjlv Create(n1.NodeContext Node_Context)
        {
            var instance = new DiceSimilarity_K2wlsa7dCqKLHM44uddjlv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.DiceSimilarity_K2wlsa7dCqKLHM44uddjlv CreateDefault()
        {
            var instance = new DiceSimilarity_K2wlsa7dCqKLHM44uddjlv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.DiceSimilarity_K2wlsa7dCqKLHM44uddjlv Get(out n3.IStringMetric Output_Out)
        {
            n7.DiceSimilarity __pad_Qf5cuGvBfRDMNNTSBlTCdC_0 = this.__slot_Qf5cuGvBfRDMNNTSBlTCdC;
            n3.IStringMetric Output_Out_1 = (n3.IStringMetric)__pad_Qf5cuGvBfRDMNNTSBlTCdC_0;
            Output_Out = Output_Out_1;
            return this;
        }

        public n5.DiceSimilarity_K2wlsa7dCqKLHM44uddjlv __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.ITokeniser Tokeniser_To_Use_0 = default(n3.ITokeniser);
            var Output_1 = new n7.DiceSimilarity(tokeniserToUse: Tokeniser_To_Use_0);
            n7.DiceSimilarity __pad_Qf5cuGvBfRDMNNTSBlTCdC_2 = Output_1;
            n5.DiceSimilarity_K2wlsa7dCqKLHM44uddjlv that_3 = this;
            this.__slot_Qf5cuGvBfRDMNNTSBlTCdC = Output_1;
            return that_3;
        }

        public n5.DiceSimilarity_K2wlsa7dCqKLHM44uddjlv __CreateDefault__()
        {
            n5.DiceSimilarity_K2wlsa7dCqKLHM44uddjlv that_0 = this;
            this.__slot_Qf5cuGvBfRDMNNTSBlTCdC = default(n7.DiceSimilarity);
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 223799U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "Qf5cuGvBfRDMNNTSBlTCdC", Name = "__slot_Qf5cuGvBfRDMNNTSBlTCdC")]
        public n7.DiceSimilarity __slot_Qf5cuGvBfRDMNNTSBlTCdC;
        public DiceSimilarity_K2wlsa7dCqKLHM44uddjlv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DiceSimilarity_K2wlsa7dCqKLHM44uddjlv(DiceSimilarity_K2wlsa7dCqKLHM44uddjlv other): base(other)
        {
            this.__slot_Qf5cuGvBfRDMNNTSBlTCdC = other.__slot_Qf5cuGvBfRDMNNTSBlTCdC;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Qf5cuGvBfRDMNNTSBlTCdC", in __slot_Qf5cuGvBfRDMNNTSBlTCdC));
        }

        internal DiceSimilarity_K2wlsa7dCqKLHM44uddjlv __WITH__(n7.DiceSimilarity __slot_Qf5cuGvBfRDMNNTSBlTCdC)
        {
            n5.DiceSimilarity_K2wlsa7dCqKLHM44uddjlv that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_Qf5cuGvBfRDMNNTSBlTCdC != this.__slot_Qf5cuGvBfRDMNNTSBlTCdC ? new DiceSimilarity_K2wlsa7dCqKLHM44uddjlv(this)
                {__slot_Qf5cuGvBfRDMNNTSBlTCdC = __slot_Qf5cuGvBfRDMNNTSBlTCdC} : that_0;
            else
            {
                this.__slot_Qf5cuGvBfRDMNNTSBlTCdC = __slot_Qf5cuGvBfRDMNNTSBlTCdC;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 223832U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "Fh2iyUkOKysOk9oMAkXBfl", Name = "EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl")]
    [n2.SerializableAttribute]
    public class EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl Create(n1.NodeContext Node_Context)
        {
            var instance = new EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl CreateDefault()
        {
            var instance = new EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl Get(out n3.IStringMetric Output_Out)
        {
            n7.EuclideanDistance __pad_HnnFuh3NQt9L32ia77frcG_0 = this.__slot_HnnFuh3NQt9L32ia77frcG;
            n3.IStringMetric Output_Out_1 = (n3.IStringMetric)__pad_HnnFuh3NQt9L32ia77frcG_0;
            Output_Out = Output_Out_1;
            return this;
        }

        public n5.EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.ITokeniser Tokeniser_To_Use_0 = default(n3.ITokeniser);
            var Output_1 = new n7.EuclideanDistance(tokeniserToUse: Tokeniser_To_Use_0);
            n7.EuclideanDistance __pad_HnnFuh3NQt9L32ia77frcG_2 = Output_1;
            n5.EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl that_3 = this;
            this.__slot_HnnFuh3NQt9L32ia77frcG = Output_1;
            return that_3;
        }

        public n5.EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl __CreateDefault__()
        {
            n5.EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl that_0 = this;
            this.__slot_HnnFuh3NQt9L32ia77frcG = default(n7.EuclideanDistance);
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 223852U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "HnnFuh3NQt9L32ia77frcG", Name = "__slot_HnnFuh3NQt9L32ia77frcG")]
        public n7.EuclideanDistance __slot_HnnFuh3NQt9L32ia77frcG;
        public EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl(EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl other): base(other)
        {
            this.__slot_HnnFuh3NQt9L32ia77frcG = other.__slot_HnnFuh3NQt9L32ia77frcG;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_HnnFuh3NQt9L32ia77frcG", in __slot_HnnFuh3NQt9L32ia77frcG));
        }

        internal EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl __WITH__(n7.EuclideanDistance __slot_HnnFuh3NQt9L32ia77frcG)
        {
            n5.EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_HnnFuh3NQt9L32ia77frcG != this.__slot_HnnFuh3NQt9L32ia77frcG ? new EuclideanDistance_Fh2iyUkOKysOk9oMAkXBfl(this)
                {__slot_HnnFuh3NQt9L32ia77frcG = __slot_HnnFuh3NQt9L32ia77frcG} : that_0;
            else
            {
                this.__slot_HnnFuh3NQt9L32ia77frcG = __slot_HnnFuh3NQt9L32ia77frcG;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 223892U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "UvYtmqMATKKOgPrzUo1U3a", Name = "JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a")]
    [n2.SerializableAttribute]
    public class JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a Create(n1.NodeContext Node_Context)
        {
            var instance = new JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a CreateDefault()
        {
            var instance = new JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a Get(out n3.IStringMetric Output_Out)
        {
            n7.JaccardSimilarity __pad_MND8O9izzEXLQFVbLy6ZNQ_0 = this.__slot_MND8O9izzEXLQFVbLy6ZNQ;
            n3.IStringMetric Output_Out_1 = (n3.IStringMetric)__pad_MND8O9izzEXLQFVbLy6ZNQ_0;
            Output_Out = Output_Out_1;
            return this;
        }

        public n5.JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.ITokeniser Tokeniser_To_Use_0 = default(n3.ITokeniser);
            var Output_1 = new n7.JaccardSimilarity(tokeniserToUse: Tokeniser_To_Use_0);
            n7.JaccardSimilarity __pad_MND8O9izzEXLQFVbLy6ZNQ_2 = Output_1;
            n5.JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a that_3 = this;
            this.__slot_MND8O9izzEXLQFVbLy6ZNQ = Output_1;
            return that_3;
        }

        public n5.JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a __CreateDefault__()
        {
            n5.JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a that_0 = this;
            this.__slot_MND8O9izzEXLQFVbLy6ZNQ = default(n7.JaccardSimilarity);
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 223918U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "MND8O9izzEXLQFVbLy6ZNQ", Name = "__slot_MND8O9izzEXLQFVbLy6ZNQ")]
        public n7.JaccardSimilarity __slot_MND8O9izzEXLQFVbLy6ZNQ;
        public JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a(JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a other): base(other)
        {
            this.__slot_MND8O9izzEXLQFVbLy6ZNQ = other.__slot_MND8O9izzEXLQFVbLy6ZNQ;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_MND8O9izzEXLQFVbLy6ZNQ", in __slot_MND8O9izzEXLQFVbLy6ZNQ));
        }

        internal JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a __WITH__(n7.JaccardSimilarity __slot_MND8O9izzEXLQFVbLy6ZNQ)
        {
            n5.JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_MND8O9izzEXLQFVbLy6ZNQ != this.__slot_MND8O9izzEXLQFVbLy6ZNQ ? new JaccardSimilarity_UvYtmqMATKKOgPrzUo1U3a(this)
                {__slot_MND8O9izzEXLQFVbLy6ZNQ = __slot_MND8O9izzEXLQFVbLy6ZNQ} : that_0;
            else
            {
                this.__slot_MND8O9izzEXLQFVbLy6ZNQ = __slot_MND8O9izzEXLQFVbLy6ZNQ;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 223984U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "SddzYkDQtxNNgOIHGBmKPn", Name = "NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn")]
    [n2.SerializableAttribute]
    public class NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn Create(n1.NodeContext Node_Context)
        {
            var instance = new NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn CreateDefault()
        {
            var instance = new NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn Get(out n3.IStringMetric Output_Out)
        {
            n7.NeedlemanWunch __pad_UuPQMsRGomWPs5tu6yqnAF_0 = this.__slot_UuPQMsRGomWPs5tu6yqnAF;
            n3.IStringMetric Output_Out_1 = (n3.IStringMetric)__pad_UuPQMsRGomWPs5tu6yqnAF_0;
            Output_Out = Output_Out_1;
            return this;
        }

        public n5.NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            double Cost_G_0 = 0;
            n3.AbstractSubstitutionCost Cost_Function_1 = default(n3.AbstractSubstitutionCost);
            var Output_2 = new n7.NeedlemanWunch(costG: Cost_G_0, costFunction: Cost_Function_1);
            n7.NeedlemanWunch __pad_UuPQMsRGomWPs5tu6yqnAF_3 = Output_2;
            n5.NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn that_4 = this;
            this.__slot_UuPQMsRGomWPs5tu6yqnAF = Output_2;
            return that_4;
        }

        public n5.NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn __CreateDefault__()
        {
            n5.NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn that_0 = this;
            this.__slot_UuPQMsRGomWPs5tu6yqnAF = default(n7.NeedlemanWunch);
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 224011U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "UuPQMsRGomWPs5tu6yqnAF", Name = "__slot_UuPQMsRGomWPs5tu6yqnAF")]
        public n7.NeedlemanWunch __slot_UuPQMsRGomWPs5tu6yqnAF;
        public NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn(NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn other): base(other)
        {
            this.__slot_UuPQMsRGomWPs5tu6yqnAF = other.__slot_UuPQMsRGomWPs5tu6yqnAF;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_UuPQMsRGomWPs5tu6yqnAF", in __slot_UuPQMsRGomWPs5tu6yqnAF));
        }

        internal NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn __WITH__(n7.NeedlemanWunch __slot_UuPQMsRGomWPs5tu6yqnAF)
        {
            n5.NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_UuPQMsRGomWPs5tu6yqnAF != this.__slot_UuPQMsRGomWPs5tu6yqnAF ? new NeedlemanWunch_SddzYkDQtxNNgOIHGBmKPn(this)
                {__slot_UuPQMsRGomWPs5tu6yqnAF = __slot_UuPQMsRGomWPs5tu6yqnAF} : that_0;
            else
            {
                this.__slot_UuPQMsRGomWPs5tu6yqnAF = __slot_UuPQMsRGomWPs5tu6yqnAF;
            }

            return that_0;
        }
    }
}

namespace _VL_Text_SimMetrics_.Text.Metrics.IStringMetric
{
    [n1.ElementAttribute(TracingId = 223476U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void GetSimilarity(n3.IStringMetric Input_In, string First_Word_In, string Second_Word_In, out n3.IStringMetric Output_Out, out float Result_Out)
        {
            var Result_0 = ((n3.IStringMetric)Input_In).GetSimilarity(firstWord: First_Word_In, secondWord: Second_Word_In);
            var Result_1 = n8.IntegerConversions.ToFloat32(input: Result_0);
            Output_Out = Input_In;
            Result_Out = Result_1;
            return;
        }
    }
}

namespace _VL_Text_SimMetrics_.Text
{
    [n1.ElementAttribute(TracingId = 224294U, DocumentId = "Q2hkq2dyP13NaENHCi4CLy", PersistentId = "Bhs4SL1pMxOPqTWtYYsSWP", Name = "VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP")]
    [n2.SerializableAttribute]
    public class VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n10.VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n10.VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP CreateDefault()
        {
            var instance = new VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP Update()
        {
            return this;
        }

        public n10.VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n10.VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP __CreateDefault__()
        {
            return this;
        }

        public void Dispose()
        {
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        public VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP(VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_Text_SimMetricsApplication_Bhs4SL1pMxOPqTWtYYsSWP __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Text_SimMetrics_
{
    public struct __AdaptiveImplementations__Q2hkq2dyP13NaENHCi4CLy
    {
    }
}