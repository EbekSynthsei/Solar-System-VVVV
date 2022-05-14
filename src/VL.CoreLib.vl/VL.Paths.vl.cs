extern alias e5;

using n4 = e5::VL.Core.CompilerServices;
using n6 = global::System.Collections.Generic;
using n3 = _VL_Paths_.Math.Path;
using n10 = _CoreLibBasics_.Math.Adaptive;
using n11 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n1 = e5::VL.Core;
using n2 = global::System;
using n9 = _VL_Collections_.Collections.Sequence;
using n5 = global::System.Runtime.CompilerServices;
using n7 = e5::VL.Lib.Collections;
using n8 = _VL_Collections_.Collections.Spread;

namespace _VL_Paths_.Math.Path
{
    [n1.ElementAttribute(TracingId = 218007U, DocumentId = "DekR8FeSWkILGLRrir5wUO", PersistentId = "PoXsDZfcuYSL7l3kZlTMLp", Name = "VL_PathsApplication_PoXsDZfcuYSL7l3kZlTMLp")]
    [n2.SerializableAttribute]
    public class VL_PathsApplication_PoXsDZfcuYSL7l3kZlTMLp : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.VL_PathsApplication_PoXsDZfcuYSL7l3kZlTMLp Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_PathsApplication_PoXsDZfcuYSL7l3kZlTMLp(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.VL_PathsApplication_PoXsDZfcuYSL7l3kZlTMLp CreateDefault()
        {
            var instance = new VL_PathsApplication_PoXsDZfcuYSL7l3kZlTMLp(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VL_PathsApplication_PoXsDZfcuYSL7l3kZlTMLp Update()
        {
            return this;
        }

        public n3.VL_PathsApplication_PoXsDZfcuYSL7l3kZlTMLp __Create__(n1.NodeContext Node_Context)
        {
            n5.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.VL_PathsApplication_PoXsDZfcuYSL7l3kZlTMLp __CreateDefault__()
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

        public VL_PathsApplication_PoXsDZfcuYSL7l3kZlTMLp(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_PathsApplication_PoXsDZfcuYSL7l3kZlTMLp(VL_PathsApplication_PoXsDZfcuYSL7l3kZlTMLp other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_PathsApplication_PoXsDZfcuYSL7l3kZlTMLp __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 217062U, DocumentId = "DekR8FeSWkILGLRrir5wUO", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ArcLength<T3, T, AdM>(T3 Points_In, n6.IEnumerable<float> Position_On_Curve_In, out n7.Spread<T> Point_Out, out n7.Spread<int> Segment_Index_Out, out float Total_Length_Out)
            where T3 : n6.IEnumerable<T> where AdM : struct, n10.IAdaptiveLength<T>, n10.IAdaptiveLerp<T>, n11.IAdaptiveCreateDefault<T>, n10.IAdaptiveOperatorMinus<T>
        {
            n7.Spread<T> __cp_DmHx44zl7szPA1iJJasus4 = n8._Operations_.CreateDefault<T>();
            n7.Spread<int> __cp_E5i7Emx30q3MT1SSNyaOWk = n8._Operations_.CreateDefault<int>();
            var w_0 = default(AdM);
            n6.IEnumerable<T> Input_1 = (n6.IEnumerable<T>)Points_In;
            n8._Operations_.FromSequence<T>(Input_In: Input_1, Result_Out: out n7.Spread<T> Result_2);
            n3._Operations_.CalculateLengths<T, AdM>(Points_In: Result_2, Points_Out: out n7.Spread<T> Points_3, Output_Out: out n7.Spread<float> Output_4, Total_Length_Out: out float Total_Length_5);
            n8._Operations_.FromSequence<float>(Input_In: Position_On_Curve_In, Result_Out: out n7.Spread<float> Result_6);
            var builder_38 = n4.CollectionBuilders.GetBuilder(__cp_DmHx44zl7szPA1iJJasus4, 16);
            n7.Spread<T> output_39;
            var builder_40 = n4.CollectionBuilders.GetBuilder(__cp_E5i7Emx30q3MT1SSNyaOWk, 16);
            n7.Spread<int> output_41;
            try
            {
                var i_9 = 0;
                foreach (var item_7 in n4.CollectionExtensions.AsSpan(Result_6))
                {
                    var splicer_8 = item_7;
                    var i_local_10 = i_9;
                    float __pad_LmP9IxMOv1BMg1CqJEJ1Lp_11 = __slot_LmP9IxMOv1BMg1CqJEJ1Lp;
                    var Result_12 = splicer_8 > __pad_LmP9IxMOv1BMg1CqJEJ1Lp_11;
                    w_0.CreateDefault(Output_Out: out T Output_13);
                    n9._Operations_.FirstOrDefault<n7.Spread<T>, T>(Input_In: Points_3, Default_Value_In: Output_13, Output_Out: out n7.Spread<T> Output_14, Result_Out: out T Result_15);
                    w_0.CreateDefault(Output_Out: out T Output_16);
                    n9._Operations_.LastOrDefault<n7.Spread<T>, T>(Input_In: Points_3, Default_Value_In: Output_16, Output_Out: out n7.Spread<T> Output_17, Result_Out: out T Result_18);
                    T Point_19;
                    int Index_20;
                    if (Result_12)
                    {
                        float __pad_EYXcir2a44mQSMCBlAmEE7_21 = __slot_EYXcir2a44mQSMCBlAmEE7;
                        var Result_22 = splicer_8 < __pad_EYXcir2a44mQSMCBlAmEE7_21;
                        n8._Operations_.Count<T>(Input_In: Points_3, Count_Out: out int Count_23);
                        T Point_24;
                        int Index_25;
                        if (Result_22)
                        {
                            bool Apply_26 = true;
                            var Output_27 = splicer_8;
                            if (Apply_26)
                            {
                                var Output_28 = splicer_8 * Total_Length_5;
                                Output_27 = Output_28;
                            }

                            float Default_Value_29 = 0F;
                            var __fallback___30 = n1.ServiceRegistry.Current;
                            n9._Operations_.LastOrDefault_Predicate<n7.Spread<float>, float>(Input_In: Output_4, Default_Value_In: Default_Value_29, Predicate_In: (float Source_In_32) =>
                            {
                                using var __current_31 = __fallback___30.MakeCurrentIfNone();
                                var Result_33 = Source_In_32 <= Output_27;
                                return Result_33;
                            }

                            , Output_Out: out n7.Spread<float> Output_34, Result_Out: out float Result_35);
                            n8._Operations_.IndexOf<float>(Input_In: Output_4, Item_In: Result_35, Result_Out: out int Result_36);
                            n3._Operations_.FindPoint<T, AdM>(Points_In: Points_3, Position_On_Curve_In: Output_27, Partial_Length_In: Output_4, Index_In: Result_36, Output_Out: out T Output_37);
                            Index_25 = Result_36;
                            Point_24 = Output_37;
                        }
                        else
                        {
                            Point_24 = Result_18;
                            Index_25 = Count_23;
                        }

                        Point_19 = Point_24;
                        Index_20 = Index_25;
                    }
                    else
                    {
                        Point_19 = Result_15;
                        Index_20 = 0;
                    }

                    builder_38.Add(Point_19);
                    builder_40.Add(Index_20);
                    i_9++;
                }
            }
            finally
            {
                output_39 = builder_38.Commit();
                output_41 = builder_40.Commit();
            }

            Point_Out = output_39;
            Segment_Index_Out = output_41;
            Total_Length_Out = Total_Length_5;
            return;
        }

        public static void CalculateLengths<T, AdM>(n7.Spread<T> Points_In, out n7.Spread<T> Points_Out, out n7.Spread<float> Output_Out, out float Total_Length_Out)
            where AdM : struct, n10.IAdaptiveLength<T>, n11.IAdaptiveCreateDefault<T>, n10.IAdaptiveOperatorMinus<T>
        {
            n7.Spread<T> __cp_DZ4E2CuvjdNO1Fv95Sowm9 = n8._Operations_.CreateDefault<T>();
            n7.Spread<float> __cp_UbWaauoIDd5LWW4VYc7up4 = n8._Operations_.CreateDefault<float>();
            var w_0 = default(AdM);
            int __pad_GvVszVGHMkVNZWoNlb1DhT_1 = __slot_GvVszVGHMkVNZWoNlb1DhT;
            n8._Operations_.Count<T>(Input_In: Points_In, Count_Out: out int Count_2);
            bool Apply_3 = true;
            var Output_4 = Count_2;
            if (Apply_3)
            {
                var Output_5 = Count_2 - __pad_GvVszVGHMkVNZWoNlb1DhT_1;
                Output_4 = Output_5;
            }

            float accumulator_7 = 0F;
            var builder_28 = n4.CollectionBuilders.GetBuilder(__cp_DZ4E2CuvjdNO1Fv95Sowm9, 16);
            n7.Spread<T> output_29;
            var builder_30 = n4.CollectionBuilders.GetBuilder(__cp_UbWaauoIDd5LWW4VYc7up4, 16);
            n7.Spread<float> output_31;
            try
            {
                var Point_Count_8 = Points_In.Count;
                var __safeGuard_9 = Point_Count_8 >= Output_4;
                for (var i_6 = 0; i_6 < Output_4; i_6++)
                {
                    var splicer_10 = __safeGuard_9 ? Points_In[i_6] : Point_Count_8 > 0 ? Points_In[i_6 % Point_Count_8] : default(T);
                    var i_local_11 = i_6;
                    int __pad_JSPttGjKYQjM6mimUlSxqn_12 = __slot_JSPttGjKYQjM6mimUlSxqn;
                    float __pad_BlqJysOllrPLISe6NQJkmZ_13 = __slot_BlqJysOllrPLISe6NQJkmZ;
                    w_0.CreateDefault(Output_Out: out T Output_14);
                    n8._Operations_.GetSlice<T>(Input_In: Points_In, Default_Value_In: Output_14, Index_In: i_local_11, Result_Out: out T Result_15);
                    w_0.CreateDefault(Output_Out: out T Output_16);
                    bool Apply_17 = true;
                    var Output_18 = i_local_11;
                    if (Apply_17)
                    {
                        var Output_19 = i_local_11 + __pad_JSPttGjKYQjM6mimUlSxqn_12;
                        Output_18 = Output_19;
                    }

                    n8._Operations_.GetSlice<T>(Input_In: Points_In, Default_Value_In: Output_16, Index_In: Output_18, Result_Out: out T Result_20);
                    bool Apply_21 = true;
                    var Output_22 = Result_15;
                    if (Apply_21)
                    {
                        w_0.OperatorMinus(Input_In: Result_15, Input_2_In: Result_20, Output_Out: out Output_22);
                    }

                    w_0.Length(Input_In: Output_22, Result_Out: out float Result_23);
                    bool Apply_24 = true;
                    var Output_25 = Result_23;
                    if (Apply_24)
                    {
                        var Output_26 = Result_23 + accumulator_7;
                        Output_25 = Output_26;
                    }

                    var Result_27 = Result_23 > __pad_BlqJysOllrPLISe6NQJkmZ_13;
                    if (Result_27)
                    {
                        builder_28.Add(splicer_10);
                        builder_30.Add(Output_25);
                    }

                    accumulator_7 = Output_25;
                }
            }
            finally
            {
                output_29 = builder_28.Commit();
                output_31 = builder_30.Commit();
            }

            w_0.CreateDefault(Output_Out: out T Output_32);
            n9._Operations_.LastOrDefault<n7.Spread<T>, T>(Input_In: Points_In, Default_Value_In: Output_32, Output_Out: out n7.Spread<T> Output_33, Result_Out: out T Result_34);
            bool Apply_35 = true;
            var Output_36 = output_29;
            if (Apply_35)
            {
                n8._Operations_.Add<T>(Input_In: output_29, Item_In: Result_34, Output_Out: out Output_36);
            }

            int Index_37 = 0;
            float Value_38 = 0F;
            bool Apply_39 = true;
            var Output_40 = output_31;
            if (Apply_39)
            {
                n8._Operations_.InsertSlice<float>(Input_In: output_31, Index_In: Index_37, Value_In: Value_38, Output_Out: out Output_40);
            }

            Points_Out = Output_36;
            Output_Out = Output_40;
            Total_Length_Out = accumulator_7;
            return;
        }

        public static void FindPoint<T, AdM>(n7.Spread<T> Points_In, float Position_On_Curve_In, n7.Spread<float> Partial_Length_In, int Index_In, out T Output_Out)
            where AdM : struct, n10.IAdaptiveLerp<T>, n11.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            float __pad_ESe3VwCFfpoLOLmuhB4LpG_1 = __slot_ESe3VwCFfpoLOLmuhB4LpG;
            int __pad_TE04raGyVXPNEwlQnbeiqg_2 = __slot_TE04raGyVXPNEwlQnbeiqg;
            w_0.CreateDefault(Output_Out: out T Output_3);
            bool Apply_4 = true;
            var Output_5 = Index_In;
            if (Apply_4)
            {
                var Output_6 = Index_In + __pad_TE04raGyVXPNEwlQnbeiqg_2;
                Output_5 = Output_6;
            }

            n8._Operations_.GetSlice<T>(Input_In: Points_In, Default_Value_In: Output_3, Index_In: Output_5, Result_Out: out T Result_7);
            w_0.CreateDefault(Output_Out: out T Output_8);
            n8._Operations_.GetSlice<T>(Input_In: Points_In, Default_Value_In: Output_8, Index_In: Index_In, Result_Out: out T Result_9);
            float Default_Value_10 = 0F;
            n8._Operations_.GetSlice<float>(Input_In: Partial_Length_In, Default_Value_In: Default_Value_10, Index_In: Output_5, Result_Out: out float Result_11);
            bool Apply_12 = true;
            var Output_13 = Position_On_Curve_In;
            if (Apply_12)
            {
                var Output_14 = Position_On_Curve_In - Result_11;
                Output_13 = Output_14;
            }

            float Default_Value_15 = 0F;
            n8._Operations_.GetSlice<float>(Input_In: Partial_Length_In, Default_Value_In: Default_Value_15, Index_In: Index_In, Result_Out: out float Result_16);
            bool Apply_17 = true;
            var Output_18 = Result_16;
            if (Apply_17)
            {
                var Output_19 = Result_16 - Result_11;
                Output_18 = Output_19;
            }

            var Result_20 = Output_18 != __pad_ESe3VwCFfpoLOLmuhB4LpG_1;
            var Output_21 = Output_13;
            if (Result_20)
            {
                var Output_22 = (float)Output_13 / Output_18;
                Output_21 = Output_22;
            }

            var Output_23 = Result_7;
            if (Result_20)
            {
                w_0.Lerp(Input_In: Result_7, Input_2_In: Result_9, Scalar_In: Output_21, Output_Out: out Output_23);
            }

            Output_Out = Output_23;
            return;
        }

        [n1.ElementAttribute(TracingId = 217111U, DocumentId = "DekR8FeSWkILGLRrir5wUO", PersistentId = "LmP9IxMOv1BMg1CqJEJ1Lp", Name = "__slot_LmP9IxMOv1BMg1CqJEJ1Lp")]
        public static float __slot_LmP9IxMOv1BMg1CqJEJ1Lp = 0F;
        [n1.ElementAttribute(TracingId = 217179U, DocumentId = "DekR8FeSWkILGLRrir5wUO", PersistentId = "EYXcir2a44mQSMCBlAmEE7", Name = "__slot_EYXcir2a44mQSMCBlAmEE7")]
        public static float __slot_EYXcir2a44mQSMCBlAmEE7 = 1F;
        [n1.ElementAttribute(TracingId = 217495U, DocumentId = "DekR8FeSWkILGLRrir5wUO", PersistentId = "GvVszVGHMkVNZWoNlb1DhT", Name = "__slot_GvVszVGHMkVNZWoNlb1DhT")]
        public static int __slot_GvVszVGHMkVNZWoNlb1DhT = 1;
        [n1.ElementAttribute(TracingId = 217622U, DocumentId = "DekR8FeSWkILGLRrir5wUO", PersistentId = "JSPttGjKYQjM6mimUlSxqn", Name = "__slot_JSPttGjKYQjM6mimUlSxqn")]
        public static int __slot_JSPttGjKYQjM6mimUlSxqn = 1;
        [n1.ElementAttribute(TracingId = 217630U, DocumentId = "DekR8FeSWkILGLRrir5wUO", PersistentId = "BlqJysOllrPLISe6NQJkmZ", Name = "__slot_BlqJysOllrPLISe6NQJkmZ")]
        public static float __slot_BlqJysOllrPLISe6NQJkmZ = 1E-05F;
        [n1.ElementAttribute(TracingId = 217856U, DocumentId = "DekR8FeSWkILGLRrir5wUO", PersistentId = "ESe3VwCFfpoLOLmuhB4LpG", Name = "__slot_ESe3VwCFfpoLOLmuhB4LpG")]
        public static float __slot_ESe3VwCFfpoLOLmuhB4LpG = 0F;
        [n1.ElementAttribute(TracingId = 217852U, DocumentId = "DekR8FeSWkILGLRrir5wUO", PersistentId = "TE04raGyVXPNEwlQnbeiqg", Name = "__slot_TE04raGyVXPNEwlQnbeiqg")]
        public static int __slot_TE04raGyVXPNEwlQnbeiqg = 1;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Paths_
{
    public struct __AdaptiveImplementations__DekR8FeSWkILGLRrir5wUO
    {
    }
}