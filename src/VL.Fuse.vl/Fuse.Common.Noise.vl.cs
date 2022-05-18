extern alias e3;
extern alias e2;
extern alias e71;
extern alias e4;

using n42 = _Fuse_Common_Noise_.Fuse.Common.Noise.NoiseGradient__3D_Scalar;
using n37 = _CoreLibBasics_.Control.Advanced;
using n15 = e2::VL.Lib.Collections;
using n9 = e3::VL.Lib.Primitive.CacheRegion;
using n31 = global::System.Reactive.Subjects;
using n7 = e71::Fuse.Common.Noise;
using n28 = _CoreLibBasics_.Control;
using n21 = _VL_Collections_.Collections.Dictionary;
using n20 = global::System.Collections.Immutable;
using n38 = _Fuse_Common_Noise_.Fuse.Common.Noise.Noise__2D_Vector;
using n6 = e71::Fuse;
using n44 = _Fuse_Common_Noise_.Fuse.Common.Noise.Noise__1D;
using n33 = _VL_Reactive_.Reactive.Subjects.Subject.Advanced;
using n14 = _Fuse_Common_Noise_.Fuse.Common.Noise.Internal;
using n4 = _Fuse_Common_Noise_.Fuse.Common.Noise;
using n47 = _Fuse_Common_Noise_.Fuse.Common.Noise.WorleyNoise__3D_Scalar;
using n34 = _VL_Lang_.VL.Session;
using n27 = _Fuse_Common_Noise_;
using n11 = _Fuse_Core_.Fuse.Core.Function;
using n17 = global::System.Collections.Generic;
using n30 = _Fuse_Core_.Fuse.Core.Split;
using n39 = _Fuse_Common_Noise_.Fuse.Common.Noise.Noise__3D_Scalar;
using n18 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n13 = _Fuse_Core_Math_.Fuse.Core.Math;
using n35 = _Fuse_Core_.Fuse.Core.Join;
using n45 = _Fuse_Common_Noise_.Fuse.Common.Noise.WorleyNoise__1D;
using n40 = _Fuse_Common_Noise_.Fuse.Common.Noise.Noise__3D_Vector;
using n25 = _Fuse_Core_Domain_.Fuse.Core.Domain;
using n23 = e71::Fuse.math;
using n2 = e2::VL.Core;
using n36 = _Fuse_Common_Noise_.Fuse.Common.Noise.Noise__2D_Scalar;
using n24 = _Fuse_Core_.Fuse.Core.Value;
using n3 = global::System;
using n29 = e4::Stride.Core.Mathematics;
using n32 = e3::VL.Lib.Primitive.Object;
using n41 = _Fuse_Core_.Fuse.Core.Swizzle;
using n5 = e2::VL.Core.CompilerServices;
using n8 = e71::Fuse.noise;
using n43 = _Fuse_Common_Noise_.Fuse.Common.Noise.NoiseDivergenceFree__3D_Vector;
using n12 = _Fuse_Core_.Fuse.Core.Implementation;
using n10 = _Fuse_Core_.Fuse.Core.Util;
using n22 = _VL_Collections_.Collections.Sequence;
using n46 = _Fuse_Common_Noise_.Fuse.Common.Noise.WorleyNoise__2D_Scalar;
using n19 = global::System.Runtime.CompilerServices;
using n26 = _Fuse_Core_.Fuse.Core.Conversion;
using n16 = _VL_Collections_.Collections.Spread;
using n48 = _CoreLibBasics_.Primitive.Advanced;

namespace _Fuse_Common_Noise_.Fuse.Common.Noise
{
    [n2.ElementAttribute(TracingId = 316733U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "T2NdM1scOJdNoW9OUkWQPp", Name = "Noise_T2NdM1scOJdNoW9OUkWQPp")]
    [n3.SerializableAttribute]
    public class Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T> : n2.VLObject, n3.IDisposable where T2 : struct where T : struct
    {
        [n5.CreateNewAttribute]
        public static n4.Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T> Create(n2.NodeContext Node_Context)
        {
            var instance = new Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T>(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T> CreateDefault()
        {
            var instance = new Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T>(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T> Update<AdM>(n6.GpuValue<T2> TDomain_In, n6.GpuValue<T2> Frequency_In, n6.GpuValue<T> Amplitude_In, n6.GpuValue<T2> Offset_In, n6.GpuValue<T> Center_In, n6.GpuValue<T> Bias_In, n7.NoiseBasisInflection Inflection_In, [n5.SerializedDefaultValueAttribute("GradientNoise", false)] n8.NoiseType Noise_Type_In, n6.GpuValue<T> default_In, out n6.GpuValue<T> Output_Out)
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.GpuValue<T>>
        {
            var w_0 = default(AdM);
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_GdjD8WTEZQxNefec3EBtDI;
            if (manager_3 is null)
            {
                manager_3 = new n9.Manager<n3.ValueTuple<n6.GpuValue<T2>, n6.GpuValue<T2>, n6.GpuValue<T2>, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<T>, n7.NoiseBasisInflection, n3.ValueTuple<n8.NoiseType, n6.GpuValue<T>>>, n3.ValueTuple<n6.GpuValue<T>>>(n3.ValueTuple.Create(default(n6.GpuValue<T>)));
            }

            var inputs_4 = (TDomain_In, Frequency_In, Offset_In, Amplitude_In, Center_In, Bias_In, Inflection_In, Noise_Type_In, default_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n2.CompilationHelper.Restore<__J29Z2Q4tfLJLauFyt5yfcs>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __J29Z2Q4tfLJLauFyt5yfcs(__GetContext__(), n2.VLObject.NewIdentity())
                    {__slot_K2TzOaU39UzLCJXLavOjVO = "", __slot_HiwRKZIpHhRO4GGlub13Kn = default(n7.NoiseBasisInflection)};
                    n2.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "DUannbB572bQWoNEItfzdr", 316762U);
                    var Output_9 = n10.CheckDefaultConstant_Ej9DptZqqqWMg2zCCtmZZO<T>.Create(Node_Context: Node_Context_8);
                    state_7.__p_DUannbB572bQWoNEItfzdr = Output_9;
                    n2.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "LsZkvHlsrPiOnmkC1x20gf", 316788U);
                    var Output_11 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T2>.Create(Node_Context: Node_Context_10);
                    state_7.__p_LsZkvHlsrPiOnmkC1x20gf = Output_11;
                    n2.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "CASrcKFvARWNCz4XeMuRaa", 316810U);
                    var Output_13 = n12.AdaptiveConversion_Sp2TuEPpP5UN2UzDkOfU9d<T2, T>.Create(Node_Context: Node_Context_12);
                    state_7.__p_CASrcKFvARWNCz4XeMuRaa = Output_13;
                    n2.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "K2MRG3VS0GoPcQPRsJB0rj", 316825U);
                    var Output_15 = n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T2>.Create(Node_Context: Node_Context_14);
                    state_7.__p_K2MRG3VS0GoPcQPRsJB0rj = Output_15;
                    n2.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "IKQKXW0ipByPyybjRP6IA6", 316836U);
                    var Output_17 = n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T>.Create(Node_Context: Node_Context_16);
                    state_7.__p_IKQKXW0ipByPyybjRP6IA6 = Output_17;
                    n2.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "NZFv63buKXnOa5GONt6DFs", 316852U);
                    var Output_19 = n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5.Create(Node_Context: Node_Context_18);
                    state_7.__p_NZFv63buKXnOa5GONt6DFs = Output_19;
                }

                n15.Spread<string> __pad_QIPvGtYVW4mQMTdkfMvUtz_20 = __slot_QIPvGtYVW4mQMTdkfMvUtz;
                float The_Value_2_21 = 0F;
                var State_Output_23 = state_7.__p_DUannbB572bQWoNEItfzdr.Update(GpuValue_2_In: default_In, The_Value_2_In: The_Value_2_21, Output_Out: out n6.GpuValue<T> Output_22);
                int Id_24 = 0;
                var State_Output_26 = state_7.__p_LsZkvHlsrPiOnmkC1x20gf.Update(The_Override_In: TDomain_In, Id_In: Id_24, Output_Out: out n6.GpuValue<T2> Output_25);
                var State_Output_28 = state_7.__p_K2MRG3VS0GoPcQPRsJB0rj.Update(Value_In: Output_25, Scale_In: Frequency_In, Add_In: Offset_In, Output_Out: out n6.GpuValue<T2> Output_27);
                var Output_30 = state_7.__p_NZFv63buKXnOa5GONt6DFs.Update(Singleton_Out: out string Singleton_29);
                int Index_31 = (int)Noise_Type_In;
                string Default_Value_32 = "";
                n16._Operations_.GetSlice<string>(Input_In: __pad_QIPvGtYVW4mQMTdkfMvUtz_20, Default_Value_In: Default_Value_32, Index_In: Index_31, Result_Out: out string Result_33);
                string __pad_K2TzOaU39UzLCJXLavOjVO_34 = Result_33;
                var State_Output_37 = state_7.__p_CASrcKFvARWNCz4XeMuRaa.Update(x_In: Output_27, default_In: Output_22, mixin_In: Singleton_29, functionName_In: __pad_K2TzOaU39UzLCJXLavOjVO_34, Output_Out: out n6.GpuValue<T> Output_35, Signature_Out: out string Signature_36);
                n7.NoiseBasisInflection __pad_HiwRKZIpHhRO4GGlub13Kn_38 = Inflection_In;
                var State_Output_40 = state_7.__p_IKQKXW0ipByPyybjRP6IA6.Update<AdM>(Input_In: Output_35, Amplitude_In: Amplitude_In, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: __pad_HiwRKZIpHhRO4GGlub13Kn_38, Output_Out: out n6.GpuValue<T> Output_39);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_23 != state_7.__p_DUannbB572bQWoNEItfzdr || State_Output_26 != state_7.__p_LsZkvHlsrPiOnmkC1x20gf || State_Output_28 != state_7.__p_K2MRG3VS0GoPcQPRsJB0rj || Output_30 != state_7.__p_NZFv63buKXnOa5GONt6DFs || Result_33 != state_7.__slot_K2TzOaU39UzLCJXLavOjVO || State_Output_37 != state_7.__p_CASrcKFvARWNCz4XeMuRaa || !n17.EqualityComparer<n7.NoiseBasisInflection>.Default.Equals(Inflection_In, state_7.__slot_HiwRKZIpHhRO4GGlub13Kn) || State_Output_40 != state_7.__p_IKQKXW0ipByPyybjRP6IA6 ? new __J29Z2Q4tfLJLauFyt5yfcs(state_7)
                    {__p_DUannbB572bQWoNEItfzdr = State_Output_23, __p_LsZkvHlsrPiOnmkC1x20gf = State_Output_26, __p_K2MRG3VS0GoPcQPRsJB0rj = State_Output_28, __p_NZFv63buKXnOa5GONt6DFs = Output_30, __slot_K2TzOaU39UzLCJXLavOjVO = Result_33, __p_CASrcKFvARWNCz4XeMuRaa = State_Output_37, __slot_HiwRKZIpHhRO4GGlub13Kn = Inflection_In, __p_IKQKXW0ipByPyybjRP6IA6 = State_Output_40} : state_7;
                else
                {
                    state_7.__p_DUannbB572bQWoNEItfzdr = State_Output_23;
                    state_7.__p_LsZkvHlsrPiOnmkC1x20gf = State_Output_26;
                    state_7.__p_K2MRG3VS0GoPcQPRsJB0rj = State_Output_28;
                    state_7.__p_NZFv63buKXnOa5GONt6DFs = Output_30;
                    state_7.__slot_K2TzOaU39UzLCJXLavOjVO = Result_33;
                    state_7.__p_CASrcKFvARWNCz4XeMuRaa = State_Output_37;
                    state_7.__slot_HiwRKZIpHhRO4GGlub13Kn = Inflection_In;
                    state_7.__p_IKQKXW0ipByPyybjRP6IA6 = State_Output_40;
                }

                outputs_5 = n3.ValueTuple.Create(Output_39);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_41 = outputs_5.Item1;
            Output_Out = __auto_41;
            n4.Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T> that_42 = this;
            if (this.__GetContext__().IsImmutable)
                that_42 = manager_3 != this.__cache_GdjD8WTEZQxNefec3EBtDI ? new Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T>(this)
                {__cache_GdjD8WTEZQxNefec3EBtDI = manager_3} : that_42;
            else
            {
                this.__cache_GdjD8WTEZQxNefec3EBtDI = manager_3;
            }

            return that_42;
        }

        public n4.Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T> __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T> that_0 = this;
            this.__cache_GdjD8WTEZQxNefec3EBtDI = null;
            return that_0;
        }

        public n4.Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T> __CreateDefault__()
        {
            n4.Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T> that_0 = this;
            this.__cache_GdjD8WTEZQxNefec3EBtDI = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_GdjD8WTEZQxNefec3EBtDI);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 316736U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "GdjD8WTEZQxNefec3EBtDI", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<n6.GpuValue<T2>, n6.GpuValue<T2>, n6.GpuValue<T2>, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<T>, n7.NoiseBasisInflection, n3.ValueTuple<n8.NoiseType, n6.GpuValue<T>>>, n3.ValueTuple<n6.GpuValue<T>>> __cache_GdjD8WTEZQxNefec3EBtDI = null;
        [n2.ElementAttribute(TracingId = 316794U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "QIPvGtYVW4mQMTdkfMvUtz", Name = "__slot_QIPvGtYVW4mQMTdkfMvUtz")]
        public static n15.Spread<string> __slot_QIPvGtYVW4mQMTdkfMvUtz = n2.CompilationHelper.Deserialize<n15.Spread<string>>("<Value xmlns=\"property\">\r\n  <Item xmlns=\"\">sineNoise</Item>\r\n  <Item xmlns=\"\">valueNoise</Item>\r\n  <Item xmlns=\"\">gradientNoise</Item>\r\n  <Item xmlns=\"\">simplexNoise</Item>\r\n  <Item xmlns=\"\">worleySimpleNoise</Item>\r\n  <Item xmlns=\"\">randomNoise</Item>\r\n</Value>", true, "THHHRoIOybiP3bK7HRl5JW", "QIPvGtYVW4mQMTdkfMvUtz");
        static Noise_T2NdM1scOJdNoW9OUkWQPp()
        {
        }

        public Noise_T2NdM1scOJdNoW9OUkWQPp(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Noise_T2NdM1scOJdNoW9OUkWQPp(Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T> other): base(other)
        {
            this.__cache_GdjD8WTEZQxNefec3EBtDI = other.__cache_GdjD8WTEZQxNefec3EBtDI;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_GdjD8WTEZQxNefec3EBtDI", in __cache_GdjD8WTEZQxNefec3EBtDI));
        }

        internal Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T> __WITH__(n9.Manager<n3.ValueTuple<n6.GpuValue<T2>, n6.GpuValue<T2>, n6.GpuValue<T2>, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<T>, n7.NoiseBasisInflection, n3.ValueTuple<n8.NoiseType, n6.GpuValue<T>>>, n3.ValueTuple<n6.GpuValue<T>>> __cache_GdjD8WTEZQxNefec3EBtDI)
        {
            n4.Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_GdjD8WTEZQxNefec3EBtDI != this.__cache_GdjD8WTEZQxNefec3EBtDI ? new Noise_T2NdM1scOJdNoW9OUkWQPp<T2, T>(this)
                {__cache_GdjD8WTEZQxNefec3EBtDI = __cache_GdjD8WTEZQxNefec3EBtDI} : that_0;
            else
            {
                this.__cache_GdjD8WTEZQxNefec3EBtDI = __cache_GdjD8WTEZQxNefec3EBtDI;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "J29Z2Q4tfLJLauFyt5yfcs", Name = "__J29Z2Q4tfLJLauFyt5yfcs")]
        [n3.SerializableAttribute]
        public class __J29Z2Q4tfLJLauFyt5yfcs : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_DUannbB572bQWoNEItfzdr);
                n2.CompilationHelper.SafeDispose(this.__p_LsZkvHlsrPiOnmkC1x20gf);
                n2.CompilationHelper.SafeDispose(this.__p_CASrcKFvARWNCz4XeMuRaa);
                n2.CompilationHelper.SafeDispose(this.__p_K2MRG3VS0GoPcQPRsJB0rj);
                n2.CompilationHelper.SafeDispose(this.__p_IKQKXW0ipByPyybjRP6IA6);
                n2.CompilationHelper.SafeDispose(this.__p_NZFv63buKXnOa5GONt6DFs);
                return;
            }

            [n2.ElementAttribute(TracingId = 316762U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "DUannbB572bQWoNEItfzdr", Name = "CheckDefaultConstant", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefaultConstant_Ej9DptZqqqWMg2zCCtmZZO<T> __p_DUannbB572bQWoNEItfzdr;
            [n2.ElementAttribute(TracingId = 316788U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LsZkvHlsrPiOnmkC1x20gf", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T2> __p_LsZkvHlsrPiOnmkC1x20gf;
            [n2.ElementAttribute(TracingId = 316810U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "CASrcKFvARWNCz4XeMuRaa", Name = "AdaptiveConversion", IsManaged = true, IsAutoGenerated = true)]
            public n12.AdaptiveConversion_Sp2TuEPpP5UN2UzDkOfU9d<T2, T> __p_CASrcKFvARWNCz4XeMuRaa;
            [n2.ElementAttribute(TracingId = 316825U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "K2MRG3VS0GoPcQPRsJB0rj", Name = "ScaleAndAdd", IsManaged = true, IsAutoGenerated = true)]
            public n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T2> __p_K2MRG3VS0GoPcQPRsJB0rj;
            [n2.ElementAttribute(TracingId = 316836U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "IKQKXW0ipByPyybjRP6IA6", Name = "NoiseShaper", IsManaged = true, IsAutoGenerated = true)]
            public n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> __p_IKQKXW0ipByPyybjRP6IA6;
            [n2.ElementAttribute(TracingId = 316852U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NZFv63buKXnOa5GONt6DFs", Name = "FuseCommonNoise (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 __p_NZFv63buKXnOa5GONt6DFs;
            [n2.ElementAttribute(TracingId = 316760U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "K2TzOaU39UzLCJXLavOjVO", Name = "__slot_K2TzOaU39UzLCJXLavOjVO")]
            public string __slot_K2TzOaU39UzLCJXLavOjVO;
            [n2.ElementAttribute(TracingId = 316784U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HiwRKZIpHhRO4GGlub13Kn", Name = "__slot_HiwRKZIpHhRO4GGlub13Kn")]
            public n7.NoiseBasisInflection __slot_HiwRKZIpHhRO4GGlub13Kn;
            public __J29Z2Q4tfLJLauFyt5yfcs(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __J29Z2Q4tfLJLauFyt5yfcs(__J29Z2Q4tfLJLauFyt5yfcs other): base(other)
            {
                this.__p_DUannbB572bQWoNEItfzdr = other.__p_DUannbB572bQWoNEItfzdr;
                this.__p_LsZkvHlsrPiOnmkC1x20gf = other.__p_LsZkvHlsrPiOnmkC1x20gf;
                this.__p_CASrcKFvARWNCz4XeMuRaa = other.__p_CASrcKFvARWNCz4XeMuRaa;
                this.__p_K2MRG3VS0GoPcQPRsJB0rj = other.__p_K2MRG3VS0GoPcQPRsJB0rj;
                this.__p_IKQKXW0ipByPyybjRP6IA6 = other.__p_IKQKXW0ipByPyybjRP6IA6;
                this.__p_NZFv63buKXnOa5GONt6DFs = other.__p_NZFv63buKXnOa5GONt6DFs;
                this.__slot_K2TzOaU39UzLCJXLavOjVO = other.__slot_K2TzOaU39UzLCJXLavOjVO;
                this.__slot_HiwRKZIpHhRO4GGlub13Kn = other.__slot_HiwRKZIpHhRO4GGlub13Kn;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_DUannbB572bQWoNEItfzdr", in __p_DUannbB572bQWoNEItfzdr), n2.CompilationHelper.GetValueOrExisting(values, "__p_LsZkvHlsrPiOnmkC1x20gf", in __p_LsZkvHlsrPiOnmkC1x20gf), n2.CompilationHelper.GetValueOrExisting(values, "__p_CASrcKFvARWNCz4XeMuRaa", in __p_CASrcKFvARWNCz4XeMuRaa), n2.CompilationHelper.GetValueOrExisting(values, "__p_K2MRG3VS0GoPcQPRsJB0rj", in __p_K2MRG3VS0GoPcQPRsJB0rj), n2.CompilationHelper.GetValueOrExisting(values, "__p_IKQKXW0ipByPyybjRP6IA6", in __p_IKQKXW0ipByPyybjRP6IA6), n2.CompilationHelper.GetValueOrExisting(values, "__p_NZFv63buKXnOa5GONt6DFs", in __p_NZFv63buKXnOa5GONt6DFs), n2.CompilationHelper.GetValueOrExisting(values, "__slot_K2TzOaU39UzLCJXLavOjVO", in __slot_K2TzOaU39UzLCJXLavOjVO), n2.CompilationHelper.GetValueOrExisting(values, "__slot_HiwRKZIpHhRO4GGlub13Kn", in __slot_HiwRKZIpHhRO4GGlub13Kn));
            }

            internal __J29Z2Q4tfLJLauFyt5yfcs __WITH__(n10.CheckDefaultConstant_Ej9DptZqqqWMg2zCCtmZZO<T> __p_DUannbB572bQWoNEItfzdr, n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T2> __p_LsZkvHlsrPiOnmkC1x20gf, n12.AdaptiveConversion_Sp2TuEPpP5UN2UzDkOfU9d<T2, T> __p_CASrcKFvARWNCz4XeMuRaa, n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T2> __p_K2MRG3VS0GoPcQPRsJB0rj, n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> __p_IKQKXW0ipByPyybjRP6IA6, n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 __p_NZFv63buKXnOa5GONt6DFs, string __slot_K2TzOaU39UzLCJXLavOjVO, n7.NoiseBasisInflection __slot_HiwRKZIpHhRO4GGlub13Kn)
            {
                __J29Z2Q4tfLJLauFyt5yfcs that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_DUannbB572bQWoNEItfzdr != this.__p_DUannbB572bQWoNEItfzdr || __p_LsZkvHlsrPiOnmkC1x20gf != this.__p_LsZkvHlsrPiOnmkC1x20gf || __p_CASrcKFvARWNCz4XeMuRaa != this.__p_CASrcKFvARWNCz4XeMuRaa || __p_K2MRG3VS0GoPcQPRsJB0rj != this.__p_K2MRG3VS0GoPcQPRsJB0rj || __p_IKQKXW0ipByPyybjRP6IA6 != this.__p_IKQKXW0ipByPyybjRP6IA6 || __p_NZFv63buKXnOa5GONt6DFs != this.__p_NZFv63buKXnOa5GONt6DFs || __slot_K2TzOaU39UzLCJXLavOjVO != this.__slot_K2TzOaU39UzLCJXLavOjVO || !n17.EqualityComparer<n7.NoiseBasisInflection>.Default.Equals(__slot_HiwRKZIpHhRO4GGlub13Kn, this.__slot_HiwRKZIpHhRO4GGlub13Kn) ? new __J29Z2Q4tfLJLauFyt5yfcs(this)
                    {__p_DUannbB572bQWoNEItfzdr = __p_DUannbB572bQWoNEItfzdr, __p_LsZkvHlsrPiOnmkC1x20gf = __p_LsZkvHlsrPiOnmkC1x20gf, __p_CASrcKFvARWNCz4XeMuRaa = __p_CASrcKFvARWNCz4XeMuRaa, __p_K2MRG3VS0GoPcQPRsJB0rj = __p_K2MRG3VS0GoPcQPRsJB0rj, __p_IKQKXW0ipByPyybjRP6IA6 = __p_IKQKXW0ipByPyybjRP6IA6, __p_NZFv63buKXnOa5GONt6DFs = __p_NZFv63buKXnOa5GONt6DFs, __slot_K2TzOaU39UzLCJXLavOjVO = __slot_K2TzOaU39UzLCJXLavOjVO, __slot_HiwRKZIpHhRO4GGlub13Kn = __slot_HiwRKZIpHhRO4GGlub13Kn} : that_0;
                else
                {
                    this.__p_DUannbB572bQWoNEItfzdr = __p_DUannbB572bQWoNEItfzdr;
                    this.__p_LsZkvHlsrPiOnmkC1x20gf = __p_LsZkvHlsrPiOnmkC1x20gf;
                    this.__p_CASrcKFvARWNCz4XeMuRaa = __p_CASrcKFvARWNCz4XeMuRaa;
                    this.__p_K2MRG3VS0GoPcQPRsJB0rj = __p_K2MRG3VS0GoPcQPRsJB0rj;
                    this.__p_IKQKXW0ipByPyybjRP6IA6 = __p_IKQKXW0ipByPyybjRP6IA6;
                    this.__p_NZFv63buKXnOa5GONt6DFs = __p_NZFv63buKXnOa5GONt6DFs;
                    this.__slot_K2TzOaU39UzLCJXLavOjVO = __slot_K2TzOaU39UzLCJXLavOjVO;
                    this.__slot_HiwRKZIpHhRO4GGlub13Kn = __slot_HiwRKZIpHhRO4GGlub13Kn;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 317061U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "VdI1inNX1RhNTbDtnXSqHr", Name = "WorleyNoise_VdI1inNX1RhNTbDtnXSqHr")]
    [n3.SerializableAttribute]
    public class WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T> : n2.VLObject, n3.IDisposable where T : struct
    {
        [n5.CreateNewAttribute]
        public static n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T> Create(n2.NodeContext Node_Context)
        {
            var instance = new WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T>(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T> CreateDefault()
        {
            var instance = new WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T>(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T> Update(n6.GpuValue<T> TDomain_In, n6.GpuValue<T> Frequency_In, [n5.SerializedDefaultValueAttribute("1", false)] n6.GpuValue<float> Amplitude_In, [n5.SerializedDefaultValueAttribute("0", false)] n6.GpuValue<float> Center_In, [n5.SerializedDefaultValueAttribute("0.5", false)] n6.GpuValue<float> Bias_In, n6.GpuValue<T> Offset_In, [n5.SerializedDefaultValueAttribute("0.01", false)] n6.GpuValue<float> Smooth_In, [n5.SerializedDefaultValueAttribute("0.7", false)] n6.GpuValue<float> Jitter_In, n23.DistanceMetricsSelector Metric_In, [n5.SerializedDefaultValueAttribute("4", false)] n6.GpuValue<float> Minkowski_Power_In, out n6.GpuValue<float> Output_Out, out n6.GpuValue<T> Cell_Position_Out, out n6.GpuValue<float> Cell_ID_Out)
        {
            string __pad_Qc2aywkbO6VNJae0QQtIZC_0 = __slot_Qc2aywkbO6VNJae0QQtIZC;
            n6.GpuValue<T> __pad_QAnPRIu6NZzQL53UP2Bnbl_1 = __slot_QAnPRIu6NZzQL53UP2Bnbl;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_J6icajiHhTpQKb4TnamZSk;
            if (manager_4 is null)
            {
                manager_4 = new n9.Manager<n3.ValueTuple<n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<float>, string, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<T>, n6.GpuValue<float>>>((default(n6.GpuValue<float>), default(n6.GpuValue<T>), default(n6.GpuValue<float>)));
            }

            var inputs_5 = (TDomain_In, Frequency_In, Offset_In, Smooth_In, Jitter_In, __pad_Qc2aywkbO6VNJae0QQtIZC_0, Amplitude_In, Center_In, Bias_In, Metric_In, Minkowski_Power_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n2.CompilationHelper.Restore<__O7aCnTvdqygNw2xxqCIox9>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __O7aCnTvdqygNw2xxqCIox9(__GetContext__(), n2.VLObject.NewIdentity())
                    {__pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt = n21._Operations_.CreateDefault<string, string>(), __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj = n16._Operations_.CreateDefault<n6.GpuValue<T>>(), __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM = n16._Operations_.CreateDefault<n6.GpuValue<T>>(), __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3 = n16._Operations_.CreateDefault<n6.AbstractGpuValue>(), __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1 = n16._Operations_.CreateDefault<n6.IFunctionInvokeNode>(), __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO = n16._Operations_.CreateDefault<string>(), __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd = n16._Operations_.CreateDefault<n6.AbstractGpuValue>(), __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY = n16._Operations_.CreateDefault<n6.GpuValue<float>>(), __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo = n16._Operations_.CreateDefault<n6.GpuValue<T>>(), __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH = n16._Operations_.CreateDefault<n6.GpuValue<float>>()};
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "T2yzNuzHjPlLn2x6czYiwM", 317094U);
                    var Output_10 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T>.Create(Node_Context: Node_Context_9);
                    state_8.__p_T2yzNuzHjPlLn2x6czYiwM = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "BWaUObAYTPAPdhPIDUNpR4", 317102U);
                    var Output_12 = n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T>.Create(Node_Context: Node_Context_11);
                    state_8.__p_BWaUObAYTPAPdhPIDUNpR4 = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "JGpPadVjwxKLy38ivpic9I", 317113U);
                    var Output_14 = n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<float>.Create(Node_Context: Node_Context_13);
                    state_8.__p_JGpPadVjwxKLy38ivpic9I = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "SdBPO97NVmcMGYCDAPzPTd", 317125U);
                    var Output_16 = n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n17.IEnumerable<n6.InputModifier>>.Create(Node_Context: Node_Context_15);
                    state_8.__p_SdBPO97NVmcMGYCDAPzPTd = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "JxhKP3VHSMhL34Qkaw4QXE", 317192U);
                    var Output_18 = n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<T>.Create(Node_Context: Node_Context_17);
                    state_8.__p_JxhKP3VHSMhL34Qkaw4QXE = Output_18;
                    n2.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "C89448eVzDDLeoKZjzgyiS", 317212U);
                    var Output_20 = n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<float>.Create(Node_Context: Node_Context_19);
                    state_8.__p_C89448eVzDDLeoKZjzgyiS = Output_20;
                    n2.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "SxjaFlBKAccMS6GaQ3KGgG", 317229U);
                    var Output_22 = n25.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T>.Create(Node_Context: Node_Context_21);
                    state_8.__p_SxjaFlBKAccMS6GaQ3KGgG = Output_22;
                    n2.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "LPSI90HEGhbNQCZAuantNj", 317265U);
                    var Output_24 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_23);
                    state_8.__p_LPSI90HEGhbNQCZAuantNj = Output_24;
                    n2.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "QxzUPAbB6xbNoWgVIHoFZM", 317276U);
                    var Output_26 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_25);
                    state_8.__p_QxzUPAbB6xbNoWgVIHoFZM = Output_26;
                    n2.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "BWPpPVZe86SLQRleCv0vJY", 317286U);
                    var Output_28 = n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_27);
                    state_8.__p_BWPpPVZe86SLQRleCv0vJY = Output_28;
                    n2.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "O96ogctl9yMLOwNJrlX5Rl", 317298U);
                    var Output_30 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_29);
                    state_8.__p_O96ogctl9yMLOwNJrlX5Rl = Output_30;
                    n2.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "VsTTbonr8pQPmgqrU91LZH", 317310U);
                    var Output_32 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float>.Create(Node_Context: Node_Context_31);
                    state_8.__p_VsTTbonr8pQPmgqrU91LZH = Output_32;
                    n2.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Rzl53njDjBAOiJXESidCMo", 317328U);
                    var Output_34 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_33);
                    state_8.__p_Rzl53njDjBAOiJXESidCMo = Output_34;
                    n2.NodeContext Node_Context_35 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "R8158v7wqwzNvTzaC2tvAn", 317339U);
                    var Output_36 = n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, T>.Create(Node_Context: Node_Context_35);
                    state_8.__p_R8158v7wqwzNvTzaC2tvAn = Output_36;
                    n2.NodeContext Node_Context_37 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "NpdrSJAx0M6M01FgA3bR2X", 317352U);
                    var Output_38 = n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8.Create(Node_Context: Node_Context_37);
                    state_8.__p_NpdrSJAx0M6M01FgA3bR2X = Output_38;
                    n2.NodeContext Node_Context_39 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "F6KDA9Bc0mtOeKaQaO91q3", 317355U);
                    var Output_40 = n11.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.Create(Node_Context: Node_Context_39);
                    state_8.__p_F6KDA9Bc0mtOeKaQaO91q3 = Output_40;
                    n2.NodeContext Node_Context_41 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "TPptEVlAZXcOsfG3EqEYh2", 317368U);
                    var Output_42 = n11.FunctionParameter__2_Parameters_MrNZAlN5DurPW7lYURP3Qu<T, T>.Create(Node_Context: Node_Context_41);
                    state_8.__p_TPptEVlAZXcOsfG3EqEYh2 = Output_42;
                }

                string __pad_U4d4GxfT9bYQJrutfBphp1_43 = __slot_U4d4GxfT9bYQJrutfBphp1;
                float __pad_Ujc4mjlXzPgQdSzD8Y9Pt2_44 = __slot_Ujc4mjlXzPgQdSzD8Y9Pt2;
                string __pad_VDJDDWNUHewMzLdQKhhSxa_45 = __slot_VDJDDWNUHewMzLdQKhhSxa;
                n7.NoiseBasisInflection __pad_OBPk7d2RznNMG3poGbesuE_46 = __slot_OBPk7d2RznNMG3poGbesuE;
                int Id_47 = 0;
                var State_Output_49 = state_8.__p_T2yzNuzHjPlLn2x6czYiwM.Update(The_Override_In: TDomain_In, Id_In: Id_47, Output_Out: out n6.GpuValue<T> Output_48);
                var Result_50 = n6.TypeHelpers.GetTypeByGeneric<T>(theValue: TDomain_In);
                var Output_51 = Result_50.ToLowerInvariant();
                var builder_52 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt, 1);
                builder_52.Add("DOMAIN", Output_51);
                var __pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt_53 = builder_52.Commit();
                n21._Operations_.Cons<string>(Input_In: __pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt_53, Output_Out: out n20.ImmutableDictionary<string, string> Output_54);
                var State_Output_56 = state_8.__p_BWaUObAYTPAPdhPIDUNpR4.Update(Value_In: Output_48, Scale_In: Frequency_In, Add_In: Offset_In, Output_Out: out n6.GpuValue<T> Output_55);
                n6.GpuValue<T> The_Value_57 = default(n6.GpuValue<T>);
                var State_Output_59 = state_8.__p_JxhKP3VHSMhL34Qkaw4QXE.Update(The_Value_In: The_Value_57, Output_Out: out n6.GpuValue<T> Output_58);
                n6.GpuValue<float> The_Value_60 = default(n6.GpuValue<float>);
                var State_Output_62 = state_8.__p_C89448eVzDDLeoKZjzgyiS.Update(The_Value_In: The_Value_60, Output_Out: out n6.GpuValue<float> Output_61);
                var State_Output_65 = state_8.__p_TPptEVlAZXcOsfG3EqEYh2.Update(Input_In: __pad_QAnPRIu6NZzQL53UP2Bnbl_1, Input2_In: __pad_QAnPRIu6NZzQL53UP2Bnbl_1, Output_Out: out n6.GpuValue<T> Output_63, Output2_Out: out n6.GpuValue<T> Output2_64);
                var State_Output_67 = state_8.__p_SxjaFlBKAccMS6GaQ3KGgG.Update(Input_In: Output_63, Input_2_In: Output2_64, Metric_In: Metric_In, Minkowski_Power_In: Minkowski_Power_In, Output_Out: out n6.GpuValue<float> Output_66);
                n6.GpuValue<T> Input_2_68 = default(n6.GpuValue<T>);
                var builder_69 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_LPSI90HEGhbNQCZAuantNj, 2);
                builder_69.Add(__pad_QAnPRIu6NZzQL53UP2Bnbl_1);
                builder_69.Add(Input_2_68);
                var __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj_70 = builder_69.Commit();
                var State_Output_72 = state_8.__p_LPSI90HEGhbNQCZAuantNj.Update(Input_In: __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj_70, Output_Out: out n6.GpuValue<T> Output_71);
                n6.GpuValue<T> Input_2_73 = default(n6.GpuValue<T>);
                var builder_74 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM, 2);
                builder_74.Add(__pad_QAnPRIu6NZzQL53UP2Bnbl_1);
                builder_74.Add(Input_2_73);
                var __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM_75 = builder_74.Commit();
                var State_Output_77 = state_8.__p_QxzUPAbB6xbNoWgVIHoFZM.Update(Input_In: __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM_75, Output_Out: out n6.GpuValue<T> Output_76);
                var builder_78 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3, 2);
                builder_78.Add(Output_71);
                builder_78.Add(Output_76);
                var __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3_79 = builder_78.Commit();
                var State_Output_81 = state_8.__p_F6KDA9Bc0mtOeKaQaO91q3.Update(Function_In: Output_66, Parameters_In: __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3_79, Id_In: __pad_U4d4GxfT9bYQJrutfBphp1_43, Output_Out: out n6.FunctionInvokeNode<float> Output_80);
                n6.IFunctionInvokeNode Input_82 = (n6.IFunctionInvokeNode)Output_80;
                var builder_83 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1, 1);
                builder_83.Add(Input_82);
                var __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1_84 = builder_83.Commit();
                n16._Operations_.FromValue<n6.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1_84, Result_Out: out n15.Spread<n6.IFunctionInvokeNode> Result_85);
                var Output_87 = state_8.__p_NpdrSJAx0M6M01FgA3bR2X.Update(Singleton_Out: out string Singleton_86);
                var builder_88 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_U2RXTOLvwolOVozPTLllhO, 1);
                builder_88.Add(Singleton_86);
                var __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO_89 = builder_88.Commit();
                n16._Operations_.FromValue<string>(Input_In: __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO_89, Result_Out: out n15.Spread<string> Result_90);
                n17.IEnumerable<string> Mixins_91 = (n17.IEnumerable<string>)Result_90;
                n6.GpuValue<float> Default_Result_92 = default(n6.GpuValue<float>);
                bool Is_Groupable_93 = false;
                n17.IEnumerable<n6.InputModifier> The_Modifiers_94 = n22._Operations_.CreateDefault<n6.InputModifier>();
                var builder_95 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd, 5);
                builder_95.Add(Output_55);
                builder_95.Add(Output_58);
                builder_95.Add(Output_61);
                builder_95.Add(Smooth_In);
                builder_95.Add(Jitter_In);
                var __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd_96 = builder_95.Commit();
                var State_Output_99 = state_8.__p_SdBPO97NVmcMGYCDAPzPTd.Update(Arguments_In: __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd_96, Function_Name_In: __pad_VDJDDWNUHewMzLdQKhhSxa_45, Code_Template_In: __pad_Qc2aywkbO6VNJae0QQtIZC_0, Default_Result_In: Default_Result_92, Functions_In: Result_85, Mixins_In: Mixins_91, Template_Values_In: Output_54, Is_Groupable_In: Is_Groupable_93, The_Modifiers_In: The_Modifiers_94, Output_Out: out n6.GpuValue<float> Output_97, AdditionalOutputs_Out: out n15.Spread<n6.AbstractGpuValue> AdditionalOutputs_98);
                var Output_101 = state_8.__p_O96ogctl9yMLOwNJrlX5Rl.Update(Value_In: __pad_Ujc4mjlXzPgQdSzD8Y9Pt2_44, GpuValue_Out: out n6.GpuValue<float> GpuValue_100);
                var builder_102 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY, 2);
                builder_102.Add(Output_97);
                builder_102.Add(GpuValue_100);
                var __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY_103 = builder_102.Commit();
                var State_Output_105 = state_8.__p_BWPpPVZe86SLQRleCv0vJY.Update(Input_In: __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY_103, Output_Out: out n6.GpuValue<float> Output_104);
                n6.GpuValue<T> default_106 = default(n6.GpuValue<T>);
                var State_Output_108 = state_8.__p_R8158v7wqwzNvTzaC2tvAn.Update(x_In: Output_104, default_In: default_106, Output_Out: out n6.GpuValue<T> Output_107);
                var builder_109 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_Rzl53njDjBAOiJXESidCMo, 2);
                builder_109.Add(Output_107);
                builder_109.Add(Output_58);
                var __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo_110 = builder_109.Commit();
                var State_Output_112 = state_8.__p_Rzl53njDjBAOiJXESidCMo.Update(Input_In: __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo_110, Output_Out: out n6.GpuValue<T> Output_111);
                var builder_113 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH, 2);
                builder_113.Add(Output_104);
                builder_113.Add(Output_61);
                var __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH_114 = builder_113.Commit();
                var State_Output_116 = state_8.__p_VsTTbonr8pQPmgqrU91LZH.Update(Input_In: __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH_114, Output_Out: out n6.GpuValue<float> Output_115);
                var State_Output_118 = state_8.__p_JGpPadVjwxKLy38ivpic9I.Update<n27.__AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW>(Input_In: Output_97, Amplitude_In: Amplitude_In, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: __pad_OBPk7d2RznNMG3poGbesuE_46, Output_Out: out n6.GpuValue<float> Output_117);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_49 != state_8.__p_T2yzNuzHjPlLn2x6czYiwM || __pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt_53 != state_8.__pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt || State_Output_56 != state_8.__p_BWaUObAYTPAPdhPIDUNpR4 || State_Output_59 != state_8.__p_JxhKP3VHSMhL34Qkaw4QXE || State_Output_62 != state_8.__p_C89448eVzDDLeoKZjzgyiS || State_Output_65 != state_8.__p_TPptEVlAZXcOsfG3EqEYh2 || State_Output_67 != state_8.__p_SxjaFlBKAccMS6GaQ3KGgG || __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj_70 != state_8.__pin_group_Input_In_LPSI90HEGhbNQCZAuantNj || State_Output_72 != state_8.__p_LPSI90HEGhbNQCZAuantNj || __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM_75 != state_8.__pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM || State_Output_77 != state_8.__p_QxzUPAbB6xbNoWgVIHoFZM || __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3_79 != state_8.__pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3 || State_Output_81 != state_8.__p_F6KDA9Bc0mtOeKaQaO91q3 || __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1_84 != state_8.__pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1 || Output_87 != state_8.__p_NpdrSJAx0M6M01FgA3bR2X || __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO_89 != state_8.__pin_group_Input_In_U2RXTOLvwolOVozPTLllhO || __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd_96 != state_8.__pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd || State_Output_99 != state_8.__p_SdBPO97NVmcMGYCDAPzPTd || Output_101 != state_8.__p_O96ogctl9yMLOwNJrlX5Rl || __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY_103 != state_8.__pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY || State_Output_105 != state_8.__p_BWPpPVZe86SLQRleCv0vJY || State_Output_108 != state_8.__p_R8158v7wqwzNvTzaC2tvAn || __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo_110 != state_8.__pin_group_Input_In_Rzl53njDjBAOiJXESidCMo || State_Output_112 != state_8.__p_Rzl53njDjBAOiJXESidCMo || __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH_114 != state_8.__pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH || State_Output_116 != state_8.__p_VsTTbonr8pQPmgqrU91LZH || State_Output_118 != state_8.__p_JGpPadVjwxKLy38ivpic9I ? new __O7aCnTvdqygNw2xxqCIox9(state_8)
                    {__p_T2yzNuzHjPlLn2x6czYiwM = State_Output_49, __pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt = __pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt_53, __p_BWaUObAYTPAPdhPIDUNpR4 = State_Output_56, __p_JxhKP3VHSMhL34Qkaw4QXE = State_Output_59, __p_C89448eVzDDLeoKZjzgyiS = State_Output_62, __p_TPptEVlAZXcOsfG3EqEYh2 = State_Output_65, __p_SxjaFlBKAccMS6GaQ3KGgG = State_Output_67, __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj = __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj_70, __p_LPSI90HEGhbNQCZAuantNj = State_Output_72, __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM = __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM_75, __p_QxzUPAbB6xbNoWgVIHoFZM = State_Output_77, __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3 = __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3_79, __p_F6KDA9Bc0mtOeKaQaO91q3 = State_Output_81, __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1 = __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1_84, __p_NpdrSJAx0M6M01FgA3bR2X = Output_87, __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO = __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO_89, __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd = __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd_96, __p_SdBPO97NVmcMGYCDAPzPTd = State_Output_99, __p_O96ogctl9yMLOwNJrlX5Rl = Output_101, __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY = __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY_103, __p_BWPpPVZe86SLQRleCv0vJY = State_Output_105, __p_R8158v7wqwzNvTzaC2tvAn = State_Output_108, __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo = __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo_110, __p_Rzl53njDjBAOiJXESidCMo = State_Output_112, __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH = __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH_114, __p_VsTTbonr8pQPmgqrU91LZH = State_Output_116, __p_JGpPadVjwxKLy38ivpic9I = State_Output_118} : state_8;
                else
                {
                    state_8.__p_T2yzNuzHjPlLn2x6czYiwM = State_Output_49;
                    state_8.__pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt = __pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt_53;
                    state_8.__p_BWaUObAYTPAPdhPIDUNpR4 = State_Output_56;
                    state_8.__p_JxhKP3VHSMhL34Qkaw4QXE = State_Output_59;
                    state_8.__p_C89448eVzDDLeoKZjzgyiS = State_Output_62;
                    state_8.__p_TPptEVlAZXcOsfG3EqEYh2 = State_Output_65;
                    state_8.__p_SxjaFlBKAccMS6GaQ3KGgG = State_Output_67;
                    state_8.__pin_group_Input_In_LPSI90HEGhbNQCZAuantNj = __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj_70;
                    state_8.__p_LPSI90HEGhbNQCZAuantNj = State_Output_72;
                    state_8.__pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM = __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM_75;
                    state_8.__p_QxzUPAbB6xbNoWgVIHoFZM = State_Output_77;
                    state_8.__pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3 = __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3_79;
                    state_8.__p_F6KDA9Bc0mtOeKaQaO91q3 = State_Output_81;
                    state_8.__pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1 = __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1_84;
                    state_8.__p_NpdrSJAx0M6M01FgA3bR2X = Output_87;
                    state_8.__pin_group_Input_In_U2RXTOLvwolOVozPTLllhO = __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO_89;
                    state_8.__pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd = __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd_96;
                    state_8.__p_SdBPO97NVmcMGYCDAPzPTd = State_Output_99;
                    state_8.__p_O96ogctl9yMLOwNJrlX5Rl = Output_101;
                    state_8.__pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY = __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY_103;
                    state_8.__p_BWPpPVZe86SLQRleCv0vJY = State_Output_105;
                    state_8.__p_R8158v7wqwzNvTzaC2tvAn = State_Output_108;
                    state_8.__pin_group_Input_In_Rzl53njDjBAOiJXESidCMo = __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo_110;
                    state_8.__p_Rzl53njDjBAOiJXESidCMo = State_Output_112;
                    state_8.__pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH = __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH_114;
                    state_8.__p_VsTTbonr8pQPmgqrU91LZH = State_Output_116;
                    state_8.__p_JGpPadVjwxKLy38ivpic9I = State_Output_118;
                }

                outputs_6 = (Output_117, Output_111, Output_115);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var(__auto_119, __auto_120, __auto_121) = outputs_6;
            Output_Out = __auto_119;
            Cell_Position_Out = __auto_120;
            Cell_ID_Out = __auto_121;
            n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T> that_122 = this;
            if (this.__GetContext__().IsImmutable)
                that_122 = manager_4 != this.__cache_J6icajiHhTpQKb4TnamZSk ? new WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T>(this)
                {__cache_J6icajiHhTpQKb4TnamZSk = manager_4} : that_122;
            else
            {
                this.__cache_J6icajiHhTpQKb4TnamZSk = manager_4;
            }

            return that_122;
        }

        public n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T> __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T> that_0 = this;
            this.__cache_J6icajiHhTpQKb4TnamZSk = null;
            return that_0;
        }

        public n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T> __CreateDefault__()
        {
            n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T> that_0 = this;
            this.__cache_J6icajiHhTpQKb4TnamZSk = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_J6icajiHhTpQKb4TnamZSk);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 317415U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Qc2aywkbO6VNJae0QQtIZC", Name = "__slot_Qc2aywkbO6VNJae0QQtIZC")]
        public static string __slot_Qc2aywkbO6VNJae0QQtIZC = "//WorleySmooth\r\n#ifndef DistOverride\r\n#define DistOverride\r\noverride float distFunc(${DOMAIN} a, ${DOMAIN} b)\r\n{\r\n\treturn ${DIST_FUNC}(a, b);\r\n}\r\n#endif\r\n\r\nfloat ${signature} (${DOMAIN} p, out ${DOMAIN} cellPosition, out float cellID, float smooth = .2, float jitter = .7)\r\n{\r\n\treturn worleySmoothF1(p, cellPosition,  cellID, smooth, jitter);\r\n}";
        [n2.ElementAttribute(TracingId = 317436U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "QAnPRIu6NZzQL53UP2Bnbl", Name = "__slot_QAnPRIu6NZzQL53UP2Bnbl")]
        public static n6.GpuValue<T> __slot_QAnPRIu6NZzQL53UP2Bnbl = default(n6.GpuValue<T>);
        [n2.ElementAttribute(TracingId = 317067U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "J6icajiHhTpQKb4TnamZSk", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<float>, string, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<T>, n6.GpuValue<float>>> __cache_J6icajiHhTpQKb4TnamZSk = null;
        [n2.ElementAttribute(TracingId = 317159U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "U4d4GxfT9bYQJrutfBphp1", Name = "__slot_U4d4GxfT9bYQJrutfBphp1")]
        public static string __slot_U4d4GxfT9bYQJrutfBphp1 = "DIST_FUNC";
        [n2.ElementAttribute(TracingId = 317306U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Ujc4mjlXzPgQdSzD8Y9Pt2", Name = "__slot_Ujc4mjlXzPgQdSzD8Y9Pt2")]
        public static float __slot_Ujc4mjlXzPgQdSzD8Y9Pt2 = 0F;
        [n2.ElementAttribute(TracingId = 317239U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "VDJDDWNUHewMzLdQKhhSxa", Name = "__slot_VDJDDWNUHewMzLdQKhhSxa")]
        public static string __slot_VDJDDWNUHewMzLdQKhhSxa = "SmoothWorley";
        [n2.ElementAttribute(TracingId = 317380U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "OBPk7d2RznNMG3poGbesuE", Name = "__slot_OBPk7d2RznNMG3poGbesuE")]
        public static n7.NoiseBasisInflection __slot_OBPk7d2RznNMG3poGbesuE = n2.CompilationHelper.Deserialize<n7.NoiseBasisInflection>("None", false, "THHHRoIOybiP3bK7HRl5JW", "OBPk7d2RznNMG3poGbesuE");
        static WorleyNoise_VdI1inNX1RhNTbDtnXSqHr()
        {
        }

        public WorleyNoise_VdI1inNX1RhNTbDtnXSqHr(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal WorleyNoise_VdI1inNX1RhNTbDtnXSqHr(WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T> other): base(other)
        {
            this.__cache_J6icajiHhTpQKb4TnamZSk = other.__cache_J6icajiHhTpQKb4TnamZSk;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_J6icajiHhTpQKb4TnamZSk", in __cache_J6icajiHhTpQKb4TnamZSk));
        }

        internal WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T> __WITH__(n9.Manager<n3.ValueTuple<n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<float>, string, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<T>, n6.GpuValue<float>>> __cache_J6icajiHhTpQKb4TnamZSk)
        {
            n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_J6icajiHhTpQKb4TnamZSk != this.__cache_J6icajiHhTpQKb4TnamZSk ? new WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<T>(this)
                {__cache_J6icajiHhTpQKb4TnamZSk = __cache_J6icajiHhTpQKb4TnamZSk} : that_0;
            else
            {
                this.__cache_J6icajiHhTpQKb4TnamZSk = __cache_J6icajiHhTpQKb4TnamZSk;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "O7aCnTvdqygNw2xxqCIox9", Name = "__O7aCnTvdqygNw2xxqCIox9")]
        [n3.SerializableAttribute]
        public class __O7aCnTvdqygNw2xxqCIox9 : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_T2yzNuzHjPlLn2x6czYiwM);
                n2.CompilationHelper.SafeDispose(this.__p_BWaUObAYTPAPdhPIDUNpR4);
                n2.CompilationHelper.SafeDispose(this.__p_JGpPadVjwxKLy38ivpic9I);
                n2.CompilationHelper.SafeDispose(this.__p_SdBPO97NVmcMGYCDAPzPTd);
                n2.CompilationHelper.SafeDispose(this.__p_JxhKP3VHSMhL34Qkaw4QXE);
                n2.CompilationHelper.SafeDispose(this.__p_C89448eVzDDLeoKZjzgyiS);
                n2.CompilationHelper.SafeDispose(this.__p_SxjaFlBKAccMS6GaQ3KGgG);
                n2.CompilationHelper.SafeDispose(this.__p_LPSI90HEGhbNQCZAuantNj);
                n2.CompilationHelper.SafeDispose(this.__p_QxzUPAbB6xbNoWgVIHoFZM);
                n2.CompilationHelper.SafeDispose(this.__p_BWPpPVZe86SLQRleCv0vJY);
                n2.CompilationHelper.SafeDispose(this.__p_O96ogctl9yMLOwNJrlX5Rl);
                n2.CompilationHelper.SafeDispose(this.__p_VsTTbonr8pQPmgqrU91LZH);
                n2.CompilationHelper.SafeDispose(this.__p_Rzl53njDjBAOiJXESidCMo);
                n2.CompilationHelper.SafeDispose(this.__p_R8158v7wqwzNvTzaC2tvAn);
                n2.CompilationHelper.SafeDispose(this.__p_NpdrSJAx0M6M01FgA3bR2X);
                n2.CompilationHelper.SafeDispose(this.__p_F6KDA9Bc0mtOeKaQaO91q3);
                n2.CompilationHelper.SafeDispose(this.__p_TPptEVlAZXcOsfG3EqEYh2);
                return;
            }

            [n2.ElementAttribute(TracingId = 317094U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "T2yzNuzHjPlLn2x6czYiwM", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T> __p_T2yzNuzHjPlLn2x6czYiwM;
            [n2.ElementAttribute(TracingId = 317102U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BWaUObAYTPAPdhPIDUNpR4", Name = "ScaleAndAdd", IsManaged = true, IsAutoGenerated = true)]
            public n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T> __p_BWaUObAYTPAPdhPIDUNpR4;
            [n2.ElementAttribute(TracingId = 317113U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "JGpPadVjwxKLy38ivpic9I", Name = "NoiseShaper", IsManaged = true, IsAutoGenerated = true)]
            public n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<float> __p_JGpPadVjwxKLy38ivpic9I;
            [n2.ElementAttribute(TracingId = 317125U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SdBPO97NVmcMGYCDAPzPTd", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n17.IEnumerable<n6.InputModifier>> __p_SdBPO97NVmcMGYCDAPzPTd;
            [n2.ElementAttribute(TracingId = 317192U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "JxhKP3VHSMhL34Qkaw4QXE", Name = "DeclareValue", IsManaged = true, IsAutoGenerated = true)]
            public n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<T> __p_JxhKP3VHSMhL34Qkaw4QXE;
            [n2.ElementAttribute(TracingId = 317212U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "C89448eVzDDLeoKZjzgyiS", Name = "DeclareValue", IsManaged = true, IsAutoGenerated = true)]
            public n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<float> __p_C89448eVzDDLeoKZjzgyiS;
            [n2.ElementAttribute(TracingId = 317229U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SxjaFlBKAccMS6GaQ3KGgG", Name = "DistanceMetrics", IsManaged = true, IsAutoGenerated = true)]
            public n25.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> __p_SxjaFlBKAccMS6GaQ3KGgG;
            [n2.ElementAttribute(TracingId = 317265U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LPSI90HEGhbNQCZAuantNj", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_LPSI90HEGhbNQCZAuantNj;
            [n2.ElementAttribute(TracingId = 317276U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "QxzUPAbB6xbNoWgVIHoFZM", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_QxzUPAbB6xbNoWgVIHoFZM;
            [n2.ElementAttribute(TracingId = 317286U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BWPpPVZe86SLQRleCv0vJY", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_BWPpPVZe86SLQRleCv0vJY;
            [n2.ElementAttribute(TracingId = 317298U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "O96ogctl9yMLOwNJrlX5Rl", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_O96ogctl9yMLOwNJrlX5Rl;
            [n2.ElementAttribute(TracingId = 317310U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "VsTTbonr8pQPmgqrU91LZH", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_VsTTbonr8pQPmgqrU91LZH;
            [n2.ElementAttribute(TracingId = 317328U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Rzl53njDjBAOiJXESidCMo", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_Rzl53njDjBAOiJXESidCMo;
            [n2.ElementAttribute(TracingId = 317339U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "R8158v7wqwzNvTzaC2tvAn", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_R8158v7wqwzNvTzaC2tvAn;
            [n2.ElementAttribute(TracingId = 317352U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NpdrSJAx0M6M01FgA3bR2X", Name = "FuseCommonNoiseWorley (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 __p_NpdrSJAx0M6M01FgA3bR2X;
            [n2.ElementAttribute(TracingId = 317355U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "F6KDA9Bc0mtOeKaQaO91q3", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n11.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_F6KDA9Bc0mtOeKaQaO91q3;
            [n2.ElementAttribute(TracingId = 317368U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "TPptEVlAZXcOsfG3EqEYh2", Name = "FunctionParameter (2 Parameters)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__2_Parameters_MrNZAlN5DurPW7lYURP3Qu<T, T> __p_TPptEVlAZXcOsfG3EqEYh2;
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n20.ImmutableDictionary<string, string> __pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt = default(n20.ImmutableDictionary<string, string>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj = default(n15.Spread<n6.GpuValue<T>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM = default(n15.Spread<n6.GpuValue<T>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3 = default(n15.Spread<n6.AbstractGpuValue>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.IFunctionInvokeNode> __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1 = default(n15.Spread<n6.IFunctionInvokeNode>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<string> __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO = default(n15.Spread<string>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd = default(n15.Spread<n6.AbstractGpuValue>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY = default(n15.Spread<n6.GpuValue<float>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo = default(n15.Spread<n6.GpuValue<T>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH = default(n15.Spread<n6.GpuValue<float>>);
            public __O7aCnTvdqygNw2xxqCIox9(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __O7aCnTvdqygNw2xxqCIox9(__O7aCnTvdqygNw2xxqCIox9 other): base(other)
            {
                this.__p_T2yzNuzHjPlLn2x6czYiwM = other.__p_T2yzNuzHjPlLn2x6czYiwM;
                this.__p_BWaUObAYTPAPdhPIDUNpR4 = other.__p_BWaUObAYTPAPdhPIDUNpR4;
                this.__p_JGpPadVjwxKLy38ivpic9I = other.__p_JGpPadVjwxKLy38ivpic9I;
                this.__p_SdBPO97NVmcMGYCDAPzPTd = other.__p_SdBPO97NVmcMGYCDAPzPTd;
                this.__p_JxhKP3VHSMhL34Qkaw4QXE = other.__p_JxhKP3VHSMhL34Qkaw4QXE;
                this.__p_C89448eVzDDLeoKZjzgyiS = other.__p_C89448eVzDDLeoKZjzgyiS;
                this.__p_SxjaFlBKAccMS6GaQ3KGgG = other.__p_SxjaFlBKAccMS6GaQ3KGgG;
                this.__p_LPSI90HEGhbNQCZAuantNj = other.__p_LPSI90HEGhbNQCZAuantNj;
                this.__p_QxzUPAbB6xbNoWgVIHoFZM = other.__p_QxzUPAbB6xbNoWgVIHoFZM;
                this.__p_BWPpPVZe86SLQRleCv0vJY = other.__p_BWPpPVZe86SLQRleCv0vJY;
                this.__p_O96ogctl9yMLOwNJrlX5Rl = other.__p_O96ogctl9yMLOwNJrlX5Rl;
                this.__p_VsTTbonr8pQPmgqrU91LZH = other.__p_VsTTbonr8pQPmgqrU91LZH;
                this.__p_Rzl53njDjBAOiJXESidCMo = other.__p_Rzl53njDjBAOiJXESidCMo;
                this.__p_R8158v7wqwzNvTzaC2tvAn = other.__p_R8158v7wqwzNvTzaC2tvAn;
                this.__p_NpdrSJAx0M6M01FgA3bR2X = other.__p_NpdrSJAx0M6M01FgA3bR2X;
                this.__p_F6KDA9Bc0mtOeKaQaO91q3 = other.__p_F6KDA9Bc0mtOeKaQaO91q3;
                this.__p_TPptEVlAZXcOsfG3EqEYh2 = other.__p_TPptEVlAZXcOsfG3EqEYh2;
                this.__pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt = other.__pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt;
                this.__pin_group_Input_In_LPSI90HEGhbNQCZAuantNj = other.__pin_group_Input_In_LPSI90HEGhbNQCZAuantNj;
                this.__pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM = other.__pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM;
                this.__pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3 = other.__pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3;
                this.__pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1 = other.__pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1;
                this.__pin_group_Input_In_U2RXTOLvwolOVozPTLllhO = other.__pin_group_Input_In_U2RXTOLvwolOVozPTLllhO;
                this.__pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd = other.__pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd;
                this.__pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY = other.__pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY;
                this.__pin_group_Input_In_Rzl53njDjBAOiJXESidCMo = other.__pin_group_Input_In_Rzl53njDjBAOiJXESidCMo;
                this.__pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH = other.__pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_T2yzNuzHjPlLn2x6czYiwM", in __p_T2yzNuzHjPlLn2x6czYiwM), n2.CompilationHelper.GetValueOrExisting(values, "__p_BWaUObAYTPAPdhPIDUNpR4", in __p_BWaUObAYTPAPdhPIDUNpR4), n2.CompilationHelper.GetValueOrExisting(values, "__p_JGpPadVjwxKLy38ivpic9I", in __p_JGpPadVjwxKLy38ivpic9I), n2.CompilationHelper.GetValueOrExisting(values, "__p_SdBPO97NVmcMGYCDAPzPTd", in __p_SdBPO97NVmcMGYCDAPzPTd), n2.CompilationHelper.GetValueOrExisting(values, "__p_JxhKP3VHSMhL34Qkaw4QXE", in __p_JxhKP3VHSMhL34Qkaw4QXE), n2.CompilationHelper.GetValueOrExisting(values, "__p_C89448eVzDDLeoKZjzgyiS", in __p_C89448eVzDDLeoKZjzgyiS), n2.CompilationHelper.GetValueOrExisting(values, "__p_SxjaFlBKAccMS6GaQ3KGgG", in __p_SxjaFlBKAccMS6GaQ3KGgG), n2.CompilationHelper.GetValueOrExisting(values, "__p_LPSI90HEGhbNQCZAuantNj", in __p_LPSI90HEGhbNQCZAuantNj), n2.CompilationHelper.GetValueOrExisting(values, "__p_QxzUPAbB6xbNoWgVIHoFZM", in __p_QxzUPAbB6xbNoWgVIHoFZM), n2.CompilationHelper.GetValueOrExisting(values, "__p_BWPpPVZe86SLQRleCv0vJY", in __p_BWPpPVZe86SLQRleCv0vJY), n2.CompilationHelper.GetValueOrExisting(values, "__p_O96ogctl9yMLOwNJrlX5Rl", in __p_O96ogctl9yMLOwNJrlX5Rl), n2.CompilationHelper.GetValueOrExisting(values, "__p_VsTTbonr8pQPmgqrU91LZH", in __p_VsTTbonr8pQPmgqrU91LZH), n2.CompilationHelper.GetValueOrExisting(values, "__p_Rzl53njDjBAOiJXESidCMo", in __p_Rzl53njDjBAOiJXESidCMo), n2.CompilationHelper.GetValueOrExisting(values, "__p_R8158v7wqwzNvTzaC2tvAn", in __p_R8158v7wqwzNvTzaC2tvAn), n2.CompilationHelper.GetValueOrExisting(values, "__p_NpdrSJAx0M6M01FgA3bR2X", in __p_NpdrSJAx0M6M01FgA3bR2X), n2.CompilationHelper.GetValueOrExisting(values, "__p_F6KDA9Bc0mtOeKaQaO91q3", in __p_F6KDA9Bc0mtOeKaQaO91q3), n2.CompilationHelper.GetValueOrExisting(values, "__p_TPptEVlAZXcOsfG3EqEYh2", in __p_TPptEVlAZXcOsfG3EqEYh2), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt", in __pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_LPSI90HEGhbNQCZAuantNj", in __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM", in __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3", in __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1", in __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_U2RXTOLvwolOVozPTLllhO", in __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd", in __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY", in __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Rzl53njDjBAOiJXESidCMo", in __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH", in __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH));
            }

            internal __O7aCnTvdqygNw2xxqCIox9 __WITH__(n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T> __p_T2yzNuzHjPlLn2x6czYiwM, n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T> __p_BWaUObAYTPAPdhPIDUNpR4, n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<float> __p_JGpPadVjwxKLy38ivpic9I, n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n17.IEnumerable<n6.InputModifier>> __p_SdBPO97NVmcMGYCDAPzPTd, n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<T> __p_JxhKP3VHSMhL34Qkaw4QXE, n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<float> __p_C89448eVzDDLeoKZjzgyiS, n25.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> __p_SxjaFlBKAccMS6GaQ3KGgG, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_LPSI90HEGhbNQCZAuantNj, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_QxzUPAbB6xbNoWgVIHoFZM, n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_BWPpPVZe86SLQRleCv0vJY, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_O96ogctl9yMLOwNJrlX5Rl, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_VsTTbonr8pQPmgqrU91LZH, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_Rzl53njDjBAOiJXESidCMo, n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_R8158v7wqwzNvTzaC2tvAn, n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 __p_NpdrSJAx0M6M01FgA3bR2X, n11.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_F6KDA9Bc0mtOeKaQaO91q3, n11.FunctionParameter__2_Parameters_MrNZAlN5DurPW7lYURP3Qu<T, T> __p_TPptEVlAZXcOsfG3EqEYh2, n20.ImmutableDictionary<string, string> __pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt, n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj, n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM, n15.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3, n15.Spread<n6.IFunctionInvokeNode> __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1, n15.Spread<string> __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO, n15.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd, n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY, n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo, n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH)
            {
                __O7aCnTvdqygNw2xxqCIox9 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_T2yzNuzHjPlLn2x6czYiwM != this.__p_T2yzNuzHjPlLn2x6czYiwM || __p_BWaUObAYTPAPdhPIDUNpR4 != this.__p_BWaUObAYTPAPdhPIDUNpR4 || __p_JGpPadVjwxKLy38ivpic9I != this.__p_JGpPadVjwxKLy38ivpic9I || __p_SdBPO97NVmcMGYCDAPzPTd != this.__p_SdBPO97NVmcMGYCDAPzPTd || __p_JxhKP3VHSMhL34Qkaw4QXE != this.__p_JxhKP3VHSMhL34Qkaw4QXE || __p_C89448eVzDDLeoKZjzgyiS != this.__p_C89448eVzDDLeoKZjzgyiS || __p_SxjaFlBKAccMS6GaQ3KGgG != this.__p_SxjaFlBKAccMS6GaQ3KGgG || __p_LPSI90HEGhbNQCZAuantNj != this.__p_LPSI90HEGhbNQCZAuantNj || __p_QxzUPAbB6xbNoWgVIHoFZM != this.__p_QxzUPAbB6xbNoWgVIHoFZM || __p_BWPpPVZe86SLQRleCv0vJY != this.__p_BWPpPVZe86SLQRleCv0vJY || __p_O96ogctl9yMLOwNJrlX5Rl != this.__p_O96ogctl9yMLOwNJrlX5Rl || __p_VsTTbonr8pQPmgqrU91LZH != this.__p_VsTTbonr8pQPmgqrU91LZH || __p_Rzl53njDjBAOiJXESidCMo != this.__p_Rzl53njDjBAOiJXESidCMo || __p_R8158v7wqwzNvTzaC2tvAn != this.__p_R8158v7wqwzNvTzaC2tvAn || __p_NpdrSJAx0M6M01FgA3bR2X != this.__p_NpdrSJAx0M6M01FgA3bR2X || __p_F6KDA9Bc0mtOeKaQaO91q3 != this.__p_F6KDA9Bc0mtOeKaQaO91q3 || __p_TPptEVlAZXcOsfG3EqEYh2 != this.__p_TPptEVlAZXcOsfG3EqEYh2 || __pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt != this.__pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt || __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj != this.__pin_group_Input_In_LPSI90HEGhbNQCZAuantNj || __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM != this.__pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM || __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3 != this.__pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3 || __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1 != this.__pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1 || __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO != this.__pin_group_Input_In_U2RXTOLvwolOVozPTLllhO || __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd != this.__pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd || __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY != this.__pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY || __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo != this.__pin_group_Input_In_Rzl53njDjBAOiJXESidCMo || __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH != this.__pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH ? new __O7aCnTvdqygNw2xxqCIox9(this)
                    {__p_T2yzNuzHjPlLn2x6czYiwM = __p_T2yzNuzHjPlLn2x6czYiwM, __p_BWaUObAYTPAPdhPIDUNpR4 = __p_BWaUObAYTPAPdhPIDUNpR4, __p_JGpPadVjwxKLy38ivpic9I = __p_JGpPadVjwxKLy38ivpic9I, __p_SdBPO97NVmcMGYCDAPzPTd = __p_SdBPO97NVmcMGYCDAPzPTd, __p_JxhKP3VHSMhL34Qkaw4QXE = __p_JxhKP3VHSMhL34Qkaw4QXE, __p_C89448eVzDDLeoKZjzgyiS = __p_C89448eVzDDLeoKZjzgyiS, __p_SxjaFlBKAccMS6GaQ3KGgG = __p_SxjaFlBKAccMS6GaQ3KGgG, __p_LPSI90HEGhbNQCZAuantNj = __p_LPSI90HEGhbNQCZAuantNj, __p_QxzUPAbB6xbNoWgVIHoFZM = __p_QxzUPAbB6xbNoWgVIHoFZM, __p_BWPpPVZe86SLQRleCv0vJY = __p_BWPpPVZe86SLQRleCv0vJY, __p_O96ogctl9yMLOwNJrlX5Rl = __p_O96ogctl9yMLOwNJrlX5Rl, __p_VsTTbonr8pQPmgqrU91LZH = __p_VsTTbonr8pQPmgqrU91LZH, __p_Rzl53njDjBAOiJXESidCMo = __p_Rzl53njDjBAOiJXESidCMo, __p_R8158v7wqwzNvTzaC2tvAn = __p_R8158v7wqwzNvTzaC2tvAn, __p_NpdrSJAx0M6M01FgA3bR2X = __p_NpdrSJAx0M6M01FgA3bR2X, __p_F6KDA9Bc0mtOeKaQaO91q3 = __p_F6KDA9Bc0mtOeKaQaO91q3, __p_TPptEVlAZXcOsfG3EqEYh2 = __p_TPptEVlAZXcOsfG3EqEYh2, __pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt = __pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt, __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj = __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj, __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM = __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM, __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3 = __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3, __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1 = __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1, __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO = __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO, __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd = __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd, __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY = __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY, __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo = __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo, __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH = __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH} : that_0;
                else
                {
                    this.__p_T2yzNuzHjPlLn2x6czYiwM = __p_T2yzNuzHjPlLn2x6czYiwM;
                    this.__p_BWaUObAYTPAPdhPIDUNpR4 = __p_BWaUObAYTPAPdhPIDUNpR4;
                    this.__p_JGpPadVjwxKLy38ivpic9I = __p_JGpPadVjwxKLy38ivpic9I;
                    this.__p_SdBPO97NVmcMGYCDAPzPTd = __p_SdBPO97NVmcMGYCDAPzPTd;
                    this.__p_JxhKP3VHSMhL34Qkaw4QXE = __p_JxhKP3VHSMhL34Qkaw4QXE;
                    this.__p_C89448eVzDDLeoKZjzgyiS = __p_C89448eVzDDLeoKZjzgyiS;
                    this.__p_SxjaFlBKAccMS6GaQ3KGgG = __p_SxjaFlBKAccMS6GaQ3KGgG;
                    this.__p_LPSI90HEGhbNQCZAuantNj = __p_LPSI90HEGhbNQCZAuantNj;
                    this.__p_QxzUPAbB6xbNoWgVIHoFZM = __p_QxzUPAbB6xbNoWgVIHoFZM;
                    this.__p_BWPpPVZe86SLQRleCv0vJY = __p_BWPpPVZe86SLQRleCv0vJY;
                    this.__p_O96ogctl9yMLOwNJrlX5Rl = __p_O96ogctl9yMLOwNJrlX5Rl;
                    this.__p_VsTTbonr8pQPmgqrU91LZH = __p_VsTTbonr8pQPmgqrU91LZH;
                    this.__p_Rzl53njDjBAOiJXESidCMo = __p_Rzl53njDjBAOiJXESidCMo;
                    this.__p_R8158v7wqwzNvTzaC2tvAn = __p_R8158v7wqwzNvTzaC2tvAn;
                    this.__p_NpdrSJAx0M6M01FgA3bR2X = __p_NpdrSJAx0M6M01FgA3bR2X;
                    this.__p_F6KDA9Bc0mtOeKaQaO91q3 = __p_F6KDA9Bc0mtOeKaQaO91q3;
                    this.__p_TPptEVlAZXcOsfG3EqEYh2 = __p_TPptEVlAZXcOsfG3EqEYh2;
                    this.__pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt = __pin_group_Input_In_LqgSmojizQAOU9f9PX1ULt;
                    this.__pin_group_Input_In_LPSI90HEGhbNQCZAuantNj = __pin_group_Input_In_LPSI90HEGhbNQCZAuantNj;
                    this.__pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM = __pin_group_Input_In_QxzUPAbB6xbNoWgVIHoFZM;
                    this.__pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3 = __pin_group_Parameters_In_F6KDA9Bc0mtOeKaQaO91q3;
                    this.__pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1 = __pin_group_Input_In_VoLR6tY8SlFQJAu04xI6r1;
                    this.__pin_group_Input_In_U2RXTOLvwolOVozPTLllhO = __pin_group_Input_In_U2RXTOLvwolOVozPTLllhO;
                    this.__pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd = __pin_group_Arguments_In_SdBPO97NVmcMGYCDAPzPTd;
                    this.__pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY = __pin_group_Input_In_BWPpPVZe86SLQRleCv0vJY;
                    this.__pin_group_Input_In_Rzl53njDjBAOiJXESidCMo = __pin_group_Input_In_Rzl53njDjBAOiJXESidCMo;
                    this.__pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH = __pin_group_Input_In_VsTTbonr8pQPmgqrU91LZH;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 317597U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Dgswt5gkY9gMlvk9nQAhGD", Name = "WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD")]
    [n3.SerializableAttribute]
    public class WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T> : n2.VLObject, n3.IDisposable where T : struct
    {
        [n5.CreateNewAttribute]
        public static n4.WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T> Create(n2.NodeContext Node_Context)
        {
            var instance = new WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T>(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T> CreateDefault()
        {
            var instance = new WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T>(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T> Update(n6.GpuValue<T> Input_In, n6.GpuValue<T> Frequency_In, n6.GpuValue<float> Amplitude_In, n6.GpuValue<float> Center_In, n6.GpuValue<float> Bias_In, n7.NoiseBasisInflection Inflection_In, n6.GpuValue<T> Offset_In, n6.GpuValue<float> Jitter_In, out n6.GpuValue<float> Edge_Distance_Out, out n6.GpuValue<T> Cell_Pos_Out, out n6.GpuValue<float> Cell_ID_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_O4apmsabDpNLBt7NBahGE1;
            if (manager_2 is null)
            {
                manager_2 = new n9.Manager<n3.ValueTuple<n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<float>, n7.NoiseBasisInflection, n3.ValueTuple<n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<T>, n6.GpuValue<float>>>((default(n6.GpuValue<float>), default(n6.GpuValue<T>), default(n6.GpuValue<float>)));
            }

            var inputs_3 = (Input_In, Frequency_In, Amplitude_In, Offset_In, Center_In, Bias_In, Inflection_In, Jitter_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n2.CompilationHelper.Restore<__VFqzSzp6uJCLaInn3fJFqT>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __VFqzSzp6uJCLaInn3fJFqT(__GetContext__(), n2.VLObject.NewIdentity())
                    {__pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa = n21._Operations_.CreateDefault<string, string>(), __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl = n16._Operations_.CreateDefault<n6.AbstractGpuValue>(), __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ = n16._Operations_.CreateDefault<n6.GpuValue<float>>(), __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ = n16._Operations_.CreateDefault<n6.GpuValue<T>>(), __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2 = n16._Operations_.CreateDefault<n6.GpuValue<float>>()};
                    n2.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "QT9xxI48rVhQaxrnfYrPyp", 317633U);
                    var Output_8 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_QT9xxI48rVhQaxrnfYrPyp = Output_8;
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "FARol2wXRZoN23yji0xHwg", 317639U);
                    var Output_10 = n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_FARol2wXRZoN23yji0xHwg = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "H9Pwo8VLRGUPeY8tL75K1W", 317648U);
                    var Output_12 = n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<float>.Create(Node_Context: Node_Context_11);
                    state_6.__p_H9Pwo8VLRGUPeY8tL75K1W = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "QWFseRb0rI4Qc8rb9PCzwR", 317673U);
                    var Output_14 = n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<T>.Create(Node_Context: Node_Context_13);
                    state_6.__p_QWFseRb0rI4Qc8rb9PCzwR = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "HimAjBn6wunN2sUATCTgyh", 317679U);
                    var Output_16 = n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<float>.Create(Node_Context: Node_Context_15);
                    state_6.__p_HimAjBn6wunN2sUATCTgyh = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "NAOncz7vqumM8ASBQhfYRs", 317699U);
                    var Output_18 = n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_17);
                    state_6.__p_NAOncz7vqumM8ASBQhfYRs = Output_18;
                    n2.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "LMJQE83anzuQA0rnOiu5DQ", 317709U);
                    var Output_20 = n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_19);
                    state_6.__p_LMJQE83anzuQA0rnOiu5DQ = Output_20;
                    n2.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "E3qOEnxKmDcNkS40kjlI9D", 317716U);
                    var Output_22 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_21);
                    state_6.__p_E3qOEnxKmDcNkS40kjlI9D = Output_22;
                    n2.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "VOQ8f6Un9kTNoC3QdqBdp2", 317724U);
                    var Output_24 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float>.Create(Node_Context: Node_Context_23);
                    state_6.__p_VOQ8f6Un9kTNoC3QdqBdp2 = Output_24;
                    n2.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "G575AdKOByeOfHlJpqJsMZ", 317740U);
                    var Output_26 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_25);
                    state_6.__p_G575AdKOByeOfHlJpqJsMZ = Output_26;
                    n2.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "TW9IboHWv19OxAIz94ZBg7", 317747U);
                    var Output_28 = n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, T>.Create(Node_Context: Node_Context_27);
                    state_6.__p_TW9IboHWv19OxAIz94ZBg7 = Output_28;
                    n2.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "QbdqpmYbdXTPCRDJ4iOoAl", 317754U);
                    var Output_30 = n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<float>.Create(Node_Context: Node_Context_29);
                    state_6.__p_QbdqpmYbdXTPCRDJ4iOoAl = Output_30;
                    n2.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "OKaNC7eDBUGMzsOc3GxkYT", 317781U);
                    var Output_32 = n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8.Create(Node_Context: Node_Context_31);
                    state_6.__p_OKaNC7eDBUGMzsOc3GxkYT = Output_32;
                }

                string __pad_PbMWepcR2YGNkbRk7Oy930_33 = __slot_PbMWepcR2YGNkbRk7Oy930;
                float __pad_MnlRgUy49pEOje0XaZOxxG_34 = __slot_MnlRgUy49pEOje0XaZOxxG;
                int Id_35 = 0;
                var State_Output_37 = state_6.__p_QT9xxI48rVhQaxrnfYrPyp.Update(The_Override_In: Input_In, Id_In: Id_35, Output_Out: out n6.GpuValue<T> Output_36);
                var Result_38 = n6.TypeHelpers.GetTypeByGeneric<T>(theValue: Input_In);
                var Output_39 = Result_38.ToLowerInvariant();
                var builder_40 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa, 1);
                builder_40.Add("DOMAIN", Output_39);
                var __pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa_41 = builder_40.Commit();
                n21._Operations_.Cons<string>(Input_In: __pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa_41, Output_Out: out n20.ImmutableDictionary<string, string> Output_42);
                var State_Output_44 = state_6.__p_FARol2wXRZoN23yji0xHwg.Update(Value_In: Output_36, Scale_In: Frequency_In, Add_In: Offset_In, Output_Out: out n6.GpuValue<T> Output_43);
                n6.GpuValue<T> The_Value_45 = default(n6.GpuValue<T>);
                var State_Output_47 = state_6.__p_QWFseRb0rI4Qc8rb9PCzwR.Update(The_Value_In: The_Value_45, Output_Out: out n6.GpuValue<T> Output_46);
                n6.GpuValue<float> The_Value_48 = default(n6.GpuValue<float>);
                var State_Output_50 = state_6.__p_HimAjBn6wunN2sUATCTgyh.Update(The_Value_In: The_Value_48, Output_Out: out n6.GpuValue<float> Output_49);
                float The_Value_51 = 0.7F;
                var State_Output_53 = state_6.__p_NAOncz7vqumM8ASBQhfYRs.Update(GpuValue_In: Jitter_In, The_Value_In: The_Value_51, Output_Out: out n6.GpuValue<float> Output_52);
                var Output_55 = state_6.__p_OKaNC7eDBUGMzsOc3GxkYT.Update(Singleton_Out: out string Singleton_54);
                n6.GpuValue<float> Default_56 = default(n6.GpuValue<float>);
                bool Is_Groupable_57 = false;
                n17.IEnumerable<n6.InputModifier> The_Modifiers_58 = n22._Operations_.CreateDefault<n6.InputModifier>();
                var builder_59 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl, 4);
                builder_59.Add(Output_43);
                builder_59.Add(Output_46);
                builder_59.Add(Output_49);
                builder_59.Add(Output_52);
                var __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl_60 = builder_59.Commit();
                var State_Output_63 = state_6.__p_QbdqpmYbdXTPCRDJ4iOoAl.Update(Arguments_In: __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl_60, Function_Name_In: __pad_PbMWepcR2YGNkbRk7Oy930_33, Default_In: Default_56, Mixins_In: Singleton_54, Is_Groupable_In: Is_Groupable_57, The_Modifiers_In: The_Modifiers_58, Output_Out: out n6.GpuValue<float> Output_61, Additional_Outputs_Out: out n15.Spread<n6.AbstractGpuValue> Additional_Outputs_62);
                var Output_65 = state_6.__p_E3qOEnxKmDcNkS40kjlI9D.Update(Value_In: __pad_MnlRgUy49pEOje0XaZOxxG_34, GpuValue_Out: out n6.GpuValue<float> GpuValue_64);
                var builder_66 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ, 2);
                builder_66.Add(Output_61);
                builder_66.Add(GpuValue_64);
                var __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ_67 = builder_66.Commit();
                var State_Output_69 = state_6.__p_LMJQE83anzuQA0rnOiu5DQ.Update(Input_In: __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ_67, Output_Out: out n6.GpuValue<float> Output_68);
                n6.GpuValue<T> default_70 = default(n6.GpuValue<T>);
                var State_Output_72 = state_6.__p_TW9IboHWv19OxAIz94ZBg7.Update(x_In: Output_68, default_In: default_70, Output_Out: out n6.GpuValue<T> Output_71);
                var builder_73 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ, 2);
                builder_73.Add(Output_71);
                builder_73.Add(Output_46);
                var __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ_74 = builder_73.Commit();
                var State_Output_76 = state_6.__p_G575AdKOByeOfHlJpqJsMZ.Update(Input_In: __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ_74, Output_Out: out n6.GpuValue<T> Output_75);
                var builder_77 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2, 2);
                builder_77.Add(Output_68);
                builder_77.Add(Output_49);
                var __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2_78 = builder_77.Commit();
                var State_Output_80 = state_6.__p_VOQ8f6Un9kTNoC3QdqBdp2.Update(Input_In: __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2_78, Output_Out: out n6.GpuValue<float> Output_79);
                var State_Output_82 = state_6.__p_H9Pwo8VLRGUPeY8tL75K1W.Update<n27.__AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW>(Input_In: Output_61, Amplitude_In: Amplitude_In, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: Inflection_In, Output_Out: out n6.GpuValue<float> Output_81);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_37 != state_6.__p_QT9xxI48rVhQaxrnfYrPyp || __pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa_41 != state_6.__pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa || State_Output_44 != state_6.__p_FARol2wXRZoN23yji0xHwg || State_Output_47 != state_6.__p_QWFseRb0rI4Qc8rb9PCzwR || State_Output_50 != state_6.__p_HimAjBn6wunN2sUATCTgyh || State_Output_53 != state_6.__p_NAOncz7vqumM8ASBQhfYRs || Output_55 != state_6.__p_OKaNC7eDBUGMzsOc3GxkYT || __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl_60 != state_6.__pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl || State_Output_63 != state_6.__p_QbdqpmYbdXTPCRDJ4iOoAl || Output_65 != state_6.__p_E3qOEnxKmDcNkS40kjlI9D || __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ_67 != state_6.__pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ || State_Output_69 != state_6.__p_LMJQE83anzuQA0rnOiu5DQ || State_Output_72 != state_6.__p_TW9IboHWv19OxAIz94ZBg7 || __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ_74 != state_6.__pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ || State_Output_76 != state_6.__p_G575AdKOByeOfHlJpqJsMZ || __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2_78 != state_6.__pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2 || State_Output_80 != state_6.__p_VOQ8f6Un9kTNoC3QdqBdp2 || State_Output_82 != state_6.__p_H9Pwo8VLRGUPeY8tL75K1W ? new __VFqzSzp6uJCLaInn3fJFqT(state_6)
                    {__p_QT9xxI48rVhQaxrnfYrPyp = State_Output_37, __pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa = __pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa_41, __p_FARol2wXRZoN23yji0xHwg = State_Output_44, __p_QWFseRb0rI4Qc8rb9PCzwR = State_Output_47, __p_HimAjBn6wunN2sUATCTgyh = State_Output_50, __p_NAOncz7vqumM8ASBQhfYRs = State_Output_53, __p_OKaNC7eDBUGMzsOc3GxkYT = Output_55, __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl = __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl_60, __p_QbdqpmYbdXTPCRDJ4iOoAl = State_Output_63, __p_E3qOEnxKmDcNkS40kjlI9D = Output_65, __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ = __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ_67, __p_LMJQE83anzuQA0rnOiu5DQ = State_Output_69, __p_TW9IboHWv19OxAIz94ZBg7 = State_Output_72, __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ = __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ_74, __p_G575AdKOByeOfHlJpqJsMZ = State_Output_76, __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2 = __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2_78, __p_VOQ8f6Un9kTNoC3QdqBdp2 = State_Output_80, __p_H9Pwo8VLRGUPeY8tL75K1W = State_Output_82} : state_6;
                else
                {
                    state_6.__p_QT9xxI48rVhQaxrnfYrPyp = State_Output_37;
                    state_6.__pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa = __pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa_41;
                    state_6.__p_FARol2wXRZoN23yji0xHwg = State_Output_44;
                    state_6.__p_QWFseRb0rI4Qc8rb9PCzwR = State_Output_47;
                    state_6.__p_HimAjBn6wunN2sUATCTgyh = State_Output_50;
                    state_6.__p_NAOncz7vqumM8ASBQhfYRs = State_Output_53;
                    state_6.__p_OKaNC7eDBUGMzsOc3GxkYT = Output_55;
                    state_6.__pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl = __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl_60;
                    state_6.__p_QbdqpmYbdXTPCRDJ4iOoAl = State_Output_63;
                    state_6.__p_E3qOEnxKmDcNkS40kjlI9D = Output_65;
                    state_6.__pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ = __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ_67;
                    state_6.__p_LMJQE83anzuQA0rnOiu5DQ = State_Output_69;
                    state_6.__p_TW9IboHWv19OxAIz94ZBg7 = State_Output_72;
                    state_6.__pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ = __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ_74;
                    state_6.__p_G575AdKOByeOfHlJpqJsMZ = State_Output_76;
                    state_6.__pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2 = __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2_78;
                    state_6.__p_VOQ8f6Un9kTNoC3QdqBdp2 = State_Output_80;
                    state_6.__p_H9Pwo8VLRGUPeY8tL75K1W = State_Output_82;
                }

                outputs_4 = (Output_81, Output_75, Output_79);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_83, __auto_84, __auto_85) = outputs_4;
            Edge_Distance_Out = __auto_83;
            Cell_Pos_Out = __auto_84;
            Cell_ID_Out = __auto_85;
            n4.WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T> that_86 = this;
            if (this.__GetContext__().IsImmutable)
                that_86 = manager_2 != this.__cache_O4apmsabDpNLBt7NBahGE1 ? new WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T>(this)
                {__cache_O4apmsabDpNLBt7NBahGE1 = manager_2} : that_86;
            else
            {
                this.__cache_O4apmsabDpNLBt7NBahGE1 = manager_2;
            }

            return that_86;
        }

        public n4.WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T> __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T> that_0 = this;
            this.__cache_O4apmsabDpNLBt7NBahGE1 = null;
            return that_0;
        }

        public n4.WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T> __CreateDefault__()
        {
            n4.WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T> that_0 = this;
            this.__cache_O4apmsabDpNLBt7NBahGE1 = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_O4apmsabDpNLBt7NBahGE1);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 317602U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "O4apmsabDpNLBt7NBahGE1", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<float>, n7.NoiseBasisInflection, n3.ValueTuple<n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<T>, n6.GpuValue<float>>> __cache_O4apmsabDpNLBt7NBahGE1 = null;
        [n2.ElementAttribute(TracingId = 317773U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "PbMWepcR2YGNkbRk7Oy930", Name = "__slot_PbMWepcR2YGNkbRk7Oy930")]
        public static string __slot_PbMWepcR2YGNkbRk7Oy930 = "worleyEdgeDist";
        [n2.ElementAttribute(TracingId = 317723U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "MnlRgUy49pEOje0XaZOxxG", Name = "__slot_MnlRgUy49pEOje0XaZOxxG")]
        public static float __slot_MnlRgUy49pEOje0XaZOxxG = 0F;
        static WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD()
        {
        }

        public WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD(WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T> other): base(other)
        {
            this.__cache_O4apmsabDpNLBt7NBahGE1 = other.__cache_O4apmsabDpNLBt7NBahGE1;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_O4apmsabDpNLBt7NBahGE1", in __cache_O4apmsabDpNLBt7NBahGE1));
        }

        internal WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T> __WITH__(n9.Manager<n3.ValueTuple<n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<float>, n7.NoiseBasisInflection, n3.ValueTuple<n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<T>, n6.GpuValue<float>>> __cache_O4apmsabDpNLBt7NBahGE1)
        {
            n4.WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_O4apmsabDpNLBt7NBahGE1 != this.__cache_O4apmsabDpNLBt7NBahGE1 ? new WorleyEdgeDistance_Dgswt5gkY9gMlvk9nQAhGD<T>(this)
                {__cache_O4apmsabDpNLBt7NBahGE1 = __cache_O4apmsabDpNLBt7NBahGE1} : that_0;
            else
            {
                this.__cache_O4apmsabDpNLBt7NBahGE1 = __cache_O4apmsabDpNLBt7NBahGE1;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "VFqzSzp6uJCLaInn3fJFqT", Name = "__VFqzSzp6uJCLaInn3fJFqT")]
        [n3.SerializableAttribute]
        public class __VFqzSzp6uJCLaInn3fJFqT : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_QT9xxI48rVhQaxrnfYrPyp);
                n2.CompilationHelper.SafeDispose(this.__p_FARol2wXRZoN23yji0xHwg);
                n2.CompilationHelper.SafeDispose(this.__p_H9Pwo8VLRGUPeY8tL75K1W);
                n2.CompilationHelper.SafeDispose(this.__p_QWFseRb0rI4Qc8rb9PCzwR);
                n2.CompilationHelper.SafeDispose(this.__p_HimAjBn6wunN2sUATCTgyh);
                n2.CompilationHelper.SafeDispose(this.__p_NAOncz7vqumM8ASBQhfYRs);
                n2.CompilationHelper.SafeDispose(this.__p_LMJQE83anzuQA0rnOiu5DQ);
                n2.CompilationHelper.SafeDispose(this.__p_E3qOEnxKmDcNkS40kjlI9D);
                n2.CompilationHelper.SafeDispose(this.__p_VOQ8f6Un9kTNoC3QdqBdp2);
                n2.CompilationHelper.SafeDispose(this.__p_G575AdKOByeOfHlJpqJsMZ);
                n2.CompilationHelper.SafeDispose(this.__p_TW9IboHWv19OxAIz94ZBg7);
                n2.CompilationHelper.SafeDispose(this.__p_QbdqpmYbdXTPCRDJ4iOoAl);
                n2.CompilationHelper.SafeDispose(this.__p_OKaNC7eDBUGMzsOc3GxkYT);
                return;
            }

            [n2.ElementAttribute(TracingId = 317633U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "QT9xxI48rVhQaxrnfYrPyp", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T> __p_QT9xxI48rVhQaxrnfYrPyp;
            [n2.ElementAttribute(TracingId = 317639U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "FARol2wXRZoN23yji0xHwg", Name = "ScaleAndAdd", IsManaged = true, IsAutoGenerated = true)]
            public n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T> __p_FARol2wXRZoN23yji0xHwg;
            [n2.ElementAttribute(TracingId = 317648U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "H9Pwo8VLRGUPeY8tL75K1W", Name = "NoiseShaper", IsManaged = true, IsAutoGenerated = true)]
            public n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<float> __p_H9Pwo8VLRGUPeY8tL75K1W;
            [n2.ElementAttribute(TracingId = 317673U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "QWFseRb0rI4Qc8rb9PCzwR", Name = "DeclareValue", IsManaged = true, IsAutoGenerated = true)]
            public n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<T> __p_QWFseRb0rI4Qc8rb9PCzwR;
            [n2.ElementAttribute(TracingId = 317679U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HimAjBn6wunN2sUATCTgyh", Name = "DeclareValue", IsManaged = true, IsAutoGenerated = true)]
            public n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<float> __p_HimAjBn6wunN2sUATCTgyh;
            [n2.ElementAttribute(TracingId = 317699U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NAOncz7vqumM8ASBQhfYRs", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_NAOncz7vqumM8ASBQhfYRs;
            [n2.ElementAttribute(TracingId = 317709U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LMJQE83anzuQA0rnOiu5DQ", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_LMJQE83anzuQA0rnOiu5DQ;
            [n2.ElementAttribute(TracingId = 317716U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "E3qOEnxKmDcNkS40kjlI9D", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_E3qOEnxKmDcNkS40kjlI9D;
            [n2.ElementAttribute(TracingId = 317724U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "VOQ8f6Un9kTNoC3QdqBdp2", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_VOQ8f6Un9kTNoC3QdqBdp2;
            [n2.ElementAttribute(TracingId = 317740U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "G575AdKOByeOfHlJpqJsMZ", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_G575AdKOByeOfHlJpqJsMZ;
            [n2.ElementAttribute(TracingId = 317747U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "TW9IboHWv19OxAIz94ZBg7", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_TW9IboHWv19OxAIz94ZBg7;
            [n2.ElementAttribute(TracingId = 317754U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "QbdqpmYbdXTPCRDJ4iOoAl", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<float> __p_QbdqpmYbdXTPCRDJ4iOoAl;
            [n2.ElementAttribute(TracingId = 317781U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "OKaNC7eDBUGMzsOc3GxkYT", Name = "FuseCommonNoiseWorley (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 __p_OKaNC7eDBUGMzsOc3GxkYT;
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n20.ImmutableDictionary<string, string> __pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa = default(n20.ImmutableDictionary<string, string>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl = default(n15.Spread<n6.AbstractGpuValue>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ = default(n15.Spread<n6.GpuValue<float>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ = default(n15.Spread<n6.GpuValue<T>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2 = default(n15.Spread<n6.GpuValue<float>>);
            public __VFqzSzp6uJCLaInn3fJFqT(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __VFqzSzp6uJCLaInn3fJFqT(__VFqzSzp6uJCLaInn3fJFqT other): base(other)
            {
                this.__p_QT9xxI48rVhQaxrnfYrPyp = other.__p_QT9xxI48rVhQaxrnfYrPyp;
                this.__p_FARol2wXRZoN23yji0xHwg = other.__p_FARol2wXRZoN23yji0xHwg;
                this.__p_H9Pwo8VLRGUPeY8tL75K1W = other.__p_H9Pwo8VLRGUPeY8tL75K1W;
                this.__p_QWFseRb0rI4Qc8rb9PCzwR = other.__p_QWFseRb0rI4Qc8rb9PCzwR;
                this.__p_HimAjBn6wunN2sUATCTgyh = other.__p_HimAjBn6wunN2sUATCTgyh;
                this.__p_NAOncz7vqumM8ASBQhfYRs = other.__p_NAOncz7vqumM8ASBQhfYRs;
                this.__p_LMJQE83anzuQA0rnOiu5DQ = other.__p_LMJQE83anzuQA0rnOiu5DQ;
                this.__p_E3qOEnxKmDcNkS40kjlI9D = other.__p_E3qOEnxKmDcNkS40kjlI9D;
                this.__p_VOQ8f6Un9kTNoC3QdqBdp2 = other.__p_VOQ8f6Un9kTNoC3QdqBdp2;
                this.__p_G575AdKOByeOfHlJpqJsMZ = other.__p_G575AdKOByeOfHlJpqJsMZ;
                this.__p_TW9IboHWv19OxAIz94ZBg7 = other.__p_TW9IboHWv19OxAIz94ZBg7;
                this.__p_QbdqpmYbdXTPCRDJ4iOoAl = other.__p_QbdqpmYbdXTPCRDJ4iOoAl;
                this.__p_OKaNC7eDBUGMzsOc3GxkYT = other.__p_OKaNC7eDBUGMzsOc3GxkYT;
                this.__pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa = other.__pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa;
                this.__pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl = other.__pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl;
                this.__pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ = other.__pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ;
                this.__pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ = other.__pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ;
                this.__pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2 = other.__pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_QT9xxI48rVhQaxrnfYrPyp", in __p_QT9xxI48rVhQaxrnfYrPyp), n2.CompilationHelper.GetValueOrExisting(values, "__p_FARol2wXRZoN23yji0xHwg", in __p_FARol2wXRZoN23yji0xHwg), n2.CompilationHelper.GetValueOrExisting(values, "__p_H9Pwo8VLRGUPeY8tL75K1W", in __p_H9Pwo8VLRGUPeY8tL75K1W), n2.CompilationHelper.GetValueOrExisting(values, "__p_QWFseRb0rI4Qc8rb9PCzwR", in __p_QWFseRb0rI4Qc8rb9PCzwR), n2.CompilationHelper.GetValueOrExisting(values, "__p_HimAjBn6wunN2sUATCTgyh", in __p_HimAjBn6wunN2sUATCTgyh), n2.CompilationHelper.GetValueOrExisting(values, "__p_NAOncz7vqumM8ASBQhfYRs", in __p_NAOncz7vqumM8ASBQhfYRs), n2.CompilationHelper.GetValueOrExisting(values, "__p_LMJQE83anzuQA0rnOiu5DQ", in __p_LMJQE83anzuQA0rnOiu5DQ), n2.CompilationHelper.GetValueOrExisting(values, "__p_E3qOEnxKmDcNkS40kjlI9D", in __p_E3qOEnxKmDcNkS40kjlI9D), n2.CompilationHelper.GetValueOrExisting(values, "__p_VOQ8f6Un9kTNoC3QdqBdp2", in __p_VOQ8f6Un9kTNoC3QdqBdp2), n2.CompilationHelper.GetValueOrExisting(values, "__p_G575AdKOByeOfHlJpqJsMZ", in __p_G575AdKOByeOfHlJpqJsMZ), n2.CompilationHelper.GetValueOrExisting(values, "__p_TW9IboHWv19OxAIz94ZBg7", in __p_TW9IboHWv19OxAIz94ZBg7), n2.CompilationHelper.GetValueOrExisting(values, "__p_QbdqpmYbdXTPCRDJ4iOoAl", in __p_QbdqpmYbdXTPCRDJ4iOoAl), n2.CompilationHelper.GetValueOrExisting(values, "__p_OKaNC7eDBUGMzsOc3GxkYT", in __p_OKaNC7eDBUGMzsOc3GxkYT), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa", in __pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl", in __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ", in __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ", in __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2", in __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2));
            }

            internal __VFqzSzp6uJCLaInn3fJFqT __WITH__(n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T> __p_QT9xxI48rVhQaxrnfYrPyp, n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T> __p_FARol2wXRZoN23yji0xHwg, n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<float> __p_H9Pwo8VLRGUPeY8tL75K1W, n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<T> __p_QWFseRb0rI4Qc8rb9PCzwR, n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<float> __p_HimAjBn6wunN2sUATCTgyh, n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_NAOncz7vqumM8ASBQhfYRs, n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_LMJQE83anzuQA0rnOiu5DQ, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_E3qOEnxKmDcNkS40kjlI9D, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_VOQ8f6Un9kTNoC3QdqBdp2, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_G575AdKOByeOfHlJpqJsMZ, n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_TW9IboHWv19OxAIz94ZBg7, n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<float> __p_QbdqpmYbdXTPCRDJ4iOoAl, n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 __p_OKaNC7eDBUGMzsOc3GxkYT, n20.ImmutableDictionary<string, string> __pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa, n15.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl, n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ, n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ, n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2)
            {
                __VFqzSzp6uJCLaInn3fJFqT that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_QT9xxI48rVhQaxrnfYrPyp != this.__p_QT9xxI48rVhQaxrnfYrPyp || __p_FARol2wXRZoN23yji0xHwg != this.__p_FARol2wXRZoN23yji0xHwg || __p_H9Pwo8VLRGUPeY8tL75K1W != this.__p_H9Pwo8VLRGUPeY8tL75K1W || __p_QWFseRb0rI4Qc8rb9PCzwR != this.__p_QWFseRb0rI4Qc8rb9PCzwR || __p_HimAjBn6wunN2sUATCTgyh != this.__p_HimAjBn6wunN2sUATCTgyh || __p_NAOncz7vqumM8ASBQhfYRs != this.__p_NAOncz7vqumM8ASBQhfYRs || __p_LMJQE83anzuQA0rnOiu5DQ != this.__p_LMJQE83anzuQA0rnOiu5DQ || __p_E3qOEnxKmDcNkS40kjlI9D != this.__p_E3qOEnxKmDcNkS40kjlI9D || __p_VOQ8f6Un9kTNoC3QdqBdp2 != this.__p_VOQ8f6Un9kTNoC3QdqBdp2 || __p_G575AdKOByeOfHlJpqJsMZ != this.__p_G575AdKOByeOfHlJpqJsMZ || __p_TW9IboHWv19OxAIz94ZBg7 != this.__p_TW9IboHWv19OxAIz94ZBg7 || __p_QbdqpmYbdXTPCRDJ4iOoAl != this.__p_QbdqpmYbdXTPCRDJ4iOoAl || __p_OKaNC7eDBUGMzsOc3GxkYT != this.__p_OKaNC7eDBUGMzsOc3GxkYT || __pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa != this.__pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa || __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl != this.__pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl || __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ != this.__pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ || __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ != this.__pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ || __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2 != this.__pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2 ? new __VFqzSzp6uJCLaInn3fJFqT(this)
                    {__p_QT9xxI48rVhQaxrnfYrPyp = __p_QT9xxI48rVhQaxrnfYrPyp, __p_FARol2wXRZoN23yji0xHwg = __p_FARol2wXRZoN23yji0xHwg, __p_H9Pwo8VLRGUPeY8tL75K1W = __p_H9Pwo8VLRGUPeY8tL75K1W, __p_QWFseRb0rI4Qc8rb9PCzwR = __p_QWFseRb0rI4Qc8rb9PCzwR, __p_HimAjBn6wunN2sUATCTgyh = __p_HimAjBn6wunN2sUATCTgyh, __p_NAOncz7vqumM8ASBQhfYRs = __p_NAOncz7vqumM8ASBQhfYRs, __p_LMJQE83anzuQA0rnOiu5DQ = __p_LMJQE83anzuQA0rnOiu5DQ, __p_E3qOEnxKmDcNkS40kjlI9D = __p_E3qOEnxKmDcNkS40kjlI9D, __p_VOQ8f6Un9kTNoC3QdqBdp2 = __p_VOQ8f6Un9kTNoC3QdqBdp2, __p_G575AdKOByeOfHlJpqJsMZ = __p_G575AdKOByeOfHlJpqJsMZ, __p_TW9IboHWv19OxAIz94ZBg7 = __p_TW9IboHWv19OxAIz94ZBg7, __p_QbdqpmYbdXTPCRDJ4iOoAl = __p_QbdqpmYbdXTPCRDJ4iOoAl, __p_OKaNC7eDBUGMzsOc3GxkYT = __p_OKaNC7eDBUGMzsOc3GxkYT, __pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa = __pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa, __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl = __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl, __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ = __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ, __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ = __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ, __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2 = __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2} : that_0;
                else
                {
                    this.__p_QT9xxI48rVhQaxrnfYrPyp = __p_QT9xxI48rVhQaxrnfYrPyp;
                    this.__p_FARol2wXRZoN23yji0xHwg = __p_FARol2wXRZoN23yji0xHwg;
                    this.__p_H9Pwo8VLRGUPeY8tL75K1W = __p_H9Pwo8VLRGUPeY8tL75K1W;
                    this.__p_QWFseRb0rI4Qc8rb9PCzwR = __p_QWFseRb0rI4Qc8rb9PCzwR;
                    this.__p_HimAjBn6wunN2sUATCTgyh = __p_HimAjBn6wunN2sUATCTgyh;
                    this.__p_NAOncz7vqumM8ASBQhfYRs = __p_NAOncz7vqumM8ASBQhfYRs;
                    this.__p_LMJQE83anzuQA0rnOiu5DQ = __p_LMJQE83anzuQA0rnOiu5DQ;
                    this.__p_E3qOEnxKmDcNkS40kjlI9D = __p_E3qOEnxKmDcNkS40kjlI9D;
                    this.__p_VOQ8f6Un9kTNoC3QdqBdp2 = __p_VOQ8f6Un9kTNoC3QdqBdp2;
                    this.__p_G575AdKOByeOfHlJpqJsMZ = __p_G575AdKOByeOfHlJpqJsMZ;
                    this.__p_TW9IboHWv19OxAIz94ZBg7 = __p_TW9IboHWv19OxAIz94ZBg7;
                    this.__p_QbdqpmYbdXTPCRDJ4iOoAl = __p_QbdqpmYbdXTPCRDJ4iOoAl;
                    this.__p_OKaNC7eDBUGMzsOc3GxkYT = __p_OKaNC7eDBUGMzsOc3GxkYT;
                    this.__pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa = __pin_group_Input_In_T4ruW81yuwtPTfAJVKK5oa;
                    this.__pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl = __pin_group_Arguments_In_QbdqpmYbdXTPCRDJ4iOoAl;
                    this.__pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ = __pin_group_Input_In_LMJQE83anzuQA0rnOiu5DQ;
                    this.__pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ = __pin_group_Input_In_G575AdKOByeOfHlJpqJsMZ;
                    this.__pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2 = __pin_group_Input_In_VOQ8f6Un9kTNoC3QdqBdp2;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 317960U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "U0wLdif0D7hNPYlsruiDCG", Name = "WorleyF1F2_U0wLdif0D7hNPYlsruiDCG")]
    [n3.SerializableAttribute]
    public class WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T> : n2.VLObject, n3.IDisposable where T : struct
    {
        [n5.CreateNewAttribute]
        public static n4.WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T> Create(n2.NodeContext Node_Context)
        {
            var instance = new WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T>(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T> CreateDefault()
        {
            var instance = new WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T>(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T> Update(n6.GpuValue<T> TDomain_In, n6.GpuValue<T> Frequency_In, n6.GpuValue<n29.Vector2> Amplitude_In, n6.GpuValue<n29.Vector2> Center_In, n6.GpuValue<n29.Vector2> Bias_In, n7.NoiseBasisInflection Inflection_In, n6.GpuValue<T> Offset_In, n6.GpuValue<float> Jitter_In, n23.DistanceMetricsSelector Metric_In, n6.GpuValue<float> Minkowski_Power_In, out n6.GpuValue<float> F1_Distance_Out, out n6.GpuValue<float> F2_Distance_Out, out n6.GpuValue<T> F1_Position_Out, out n6.GpuValue<T> F2_Position_Out, out n6.GpuValue<float> F1_ID_Out, out n6.GpuValue<float> F2_ID_Out)
        {
            string __pad_NcmyZOjyEx5PLcW4GTAPcn_0 = __slot_NcmyZOjyEx5PLcW4GTAPcn;
            n6.GpuValue<T> __pad_NJA6jx6xI7fL43MOCnHK5j_1 = __slot_NJA6jx6xI7fL43MOCnHK5j;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_RbAHL3cmBiWMd0AbcEarfZ;
            if (manager_4 is null)
            {
                manager_4 = new n9.Manager<n3.ValueTuple<string, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<n29.Vector2>, n6.GpuValue<T>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n3.ValueTuple<n7.NoiseBasisInflection, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<float>>>((default(n6.GpuValue<float>), default(n6.GpuValue<float>), default(n6.GpuValue<T>), default(n6.GpuValue<T>), default(n6.GpuValue<float>), default(n6.GpuValue<float>)));
            }

            var inputs_5 = (__pad_NcmyZOjyEx5PLcW4GTAPcn_0, TDomain_In, Frequency_In, Amplitude_In, Offset_In, Center_In, Bias_In, Inflection_In, Jitter_In, Metric_In, Minkowski_Power_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n2.CompilationHelper.Restore<__SDTQ2xa7YkCNVmZVaiuWdZ>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __SDTQ2xa7YkCNVmZVaiuWdZ(__GetContext__(), n2.VLObject.NewIdentity())
                    {__pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV = n21._Operations_.CreateDefault<string, string>(), __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU = n16._Operations_.CreateDefault<n6.GpuValue<T>>(), __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF = n16._Operations_.CreateDefault<n6.GpuValue<T>>(), __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK = n16._Operations_.CreateDefault<n6.AbstractGpuValue>(), __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT = n16._Operations_.CreateDefault<n6.IFunctionInvokeNode>(), __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz = n16._Operations_.CreateDefault<string>(), __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4 = n16._Operations_.CreateDefault<n6.AbstractGpuValue>(), __pin_group_Input_In_NaD60wKKkivME1dblxtGa1 = n16._Operations_.CreateDefault<n6.GpuValue<float>>(), __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV = n16._Operations_.CreateDefault<n6.GpuValue<T>>(), __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn = n16._Operations_.CreateDefault<n6.GpuValue<T>>(), __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE = n16._Operations_.CreateDefault<n6.GpuValue<float>>(), __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4 = n16._Operations_.CreateDefault<n6.GpuValue<float>>()};
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "LBU67G6xnS3PqrwX8ElUKu", 318019U);
                    var Output_10 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T>.Create(Node_Context: Node_Context_9);
                    state_8.__p_LBU67G6xnS3PqrwX8ElUKu = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "AncIVyIIDlFNMjrHt6Repz", 318028U);
                    var Output_12 = n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T>.Create(Node_Context: Node_Context_11);
                    state_8.__p_AncIVyIIDlFNMjrHt6Repz = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "E1oevnuce9qObQGBiFisIx", 318040U);
                    var Output_14 = n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<n29.Vector2>.Create(Node_Context: Node_Context_13);
                    state_8.__p_E1oevnuce9qObQGBiFisIx = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "EtR4UpnBHQBL8vedVT1rC4", 318050U);
                    var Output_16 = n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<n29.Vector2, n17.IEnumerable<n6.InputModifier>>.Create(Node_Context: Node_Context_15);
                    state_8.__p_EtR4UpnBHQBL8vedVT1rC4 = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "FyI5BfQpEfbPgNif4Dd53K", 318103U);
                    var Output_18 = n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<T>.Create(Node_Context: Node_Context_17);
                    state_8.__p_FyI5BfQpEfbPgNif4Dd53K = Output_18;
                    n2.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "EZmuIA9L29wNjXjL5KLjV4", 318111U);
                    var Output_20 = n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<float>.Create(Node_Context: Node_Context_19);
                    state_8.__p_EZmuIA9L29wNjXjL5KLjV4 = Output_20;
                    n2.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "F6hPybtN6SAO5DHFVporpm", 318122U);
                    var Output_22 = n25.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T>.Create(Node_Context: Node_Context_21);
                    state_8.__p_F6hPybtN6SAO5DHFVporpm = Output_22;
                    n2.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "HpyvrVO1aAKLOb56BlWhxI", 318143U);
                    var Output_24 = n11.FunctionParameter__2_Parameters_MrNZAlN5DurPW7lYURP3Qu<T, T>.Create(Node_Context: Node_Context_23);
                    state_8.__p_HpyvrVO1aAKLOb56BlWhxI = Output_24;
                    n2.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "I8idI8zhyFkMKTzmmsKVEU", 318174U);
                    var Output_26 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_25);
                    state_8.__p_I8idI8zhyFkMKTzmmsKVEU = Output_26;
                    n2.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "IRxR4inpEPwL7LXSxH1sqF", 318182U);
                    var Output_28 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_27);
                    state_8.__p_IRxR4inpEPwL7LXSxH1sqF = Output_28;
                    n2.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Fh1Crphg5XhQTfEjoG2naF", 318191U);
                    var Output_30 = n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_29);
                    state_8.__p_Fh1Crphg5XhQTfEjoG2naF = Output_30;
                    n2.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "NaD60wKKkivME1dblxtGa1", 318200U);
                    var Output_32 = n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_31);
                    state_8.__p_NaD60wKKkivME1dblxtGa1 = Output_32;
                    n2.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "UpUlSxZyjUKLfTcMiEyc64", 318207U);
                    var Output_34 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_33);
                    state_8.__p_UpUlSxZyjUKLfTcMiEyc64 = Output_34;
                    n2.NodeContext Node_Context_35 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "BgChoZ4peyiMqDx5DTYvHE", 318216U);
                    var Output_36 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float>.Create(Node_Context: Node_Context_35);
                    state_8.__p_BgChoZ4peyiMqDx5DTYvHE = Output_36;
                    n2.NodeContext Node_Context_37 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "IAcEzBQuwu7NLXw97ojHTV", 318227U);
                    var Output_38 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_37);
                    state_8.__p_IAcEzBQuwu7NLXw97ojHTV = Output_38;
                    n2.NodeContext Node_Context_39 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "RMvmyMX9cBNLFIszreIXwt", 318238U);
                    var Output_40 = n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, T>.Create(Node_Context: Node_Context_39);
                    state_8.__p_RMvmyMX9cBNLFIszreIXwt = Output_40;
                    n2.NodeContext Node_Context_41 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "AWpRcsszxWBMHzEnWLiB7Q", 318261U);
                    var Output_42 = n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<float>.Create(Node_Context: Node_Context_41);
                    state_8.__p_AWpRcsszxWBMHzEnWLiB7Q = Output_42;
                    n2.NodeContext Node_Context_43 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "M9TAFSD4oNUOYMx6LkTrMB", 318275U);
                    var Output_44 = n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<T>.Create(Node_Context: Node_Context_43);
                    state_8.__p_M9TAFSD4oNUOYMx6LkTrMB = Output_44;
                    n2.NodeContext Node_Context_45 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "GAhGAgUlRo3Lci0HDWAVK4", 318289U);
                    var Output_46 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float>.Create(Node_Context: Node_Context_45);
                    state_8.__p_GAhGAgUlRo3Lci0HDWAVK4 = Output_46;
                    n2.NodeContext Node_Context_47 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Kw1noU4j1U4NUMvwr5OFdn", 318297U);
                    var Output_48 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_47);
                    state_8.__p_Kw1noU4j1U4NUMvwr5OFdn = Output_48;
                    n2.NodeContext Node_Context_49 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Uy8ScJ1hrSUPxcn1TzdKrL", 318306U);
                    var Output_50 = n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, T>.Create(Node_Context: Node_Context_49);
                    state_8.__p_Uy8ScJ1hrSUPxcn1TzdKrL = Output_50;
                    n2.NodeContext Node_Context_51 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "QqKLzh9IY6vNAh3QnjZT6u", 318314U);
                    var Output_52 = n30.xMy_split_OlHtbWbJLVYNwNtomhsBtR.Create(Node_Context: Node_Context_51);
                    state_8.__p_QqKLzh9IY6vNAh3QnjZT6u = Output_52;
                    n2.NodeContext Node_Context_53 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "N8OfgewbBSFMNUBg6uwDCR", 318321U);
                    var Output_54 = n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8.Create(Node_Context: Node_Context_53);
                    state_8.__p_N8OfgewbBSFMNUBg6uwDCR = Output_54;
                    n2.NodeContext Node_Context_55 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "NuoA9XaToNWNGtUF7YHBvK", 318327U);
                    var Output_56 = n11.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.Create(Node_Context: Node_Context_55);
                    state_8.__p_NuoA9XaToNWNGtUF7YHBvK = Output_56;
                }

                string __pad_HnlLOu9U4tPMzoKbM1RUuW_57 = __slot_HnlLOu9U4tPMzoKbM1RUuW;
                float __pad_RydL0nYumMUObm4KjllICf_58 = __slot_RydL0nYumMUObm4KjllICf;
                string __pad_FvJdSa9rdfhNdi1Ly0F00N_59 = __slot_FvJdSa9rdfhNdi1Ly0F00N;
                int Id_60 = 0;
                var State_Output_62 = state_8.__p_LBU67G6xnS3PqrwX8ElUKu.Update(The_Override_In: TDomain_In, Id_In: Id_60, Output_Out: out n6.GpuValue<T> Output_61);
                var Result_63 = n6.TypeHelpers.GetTypeByGeneric<T>(theValue: TDomain_In);
                var Output_64 = Result_63.ToLowerInvariant();
                var builder_65 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV, 1);
                builder_65.Add("DOMAIN", Output_64);
                var __pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV_66 = builder_65.Commit();
                n21._Operations_.Cons<string>(Input_In: __pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV_66, Output_Out: out n20.ImmutableDictionary<string, string> Output_67);
                var State_Output_69 = state_8.__p_AncIVyIIDlFNMjrHt6Repz.Update(Value_In: Output_61, Scale_In: Frequency_In, Add_In: Offset_In, Output_Out: out n6.GpuValue<T> Output_68);
                n6.GpuValue<T> The_Value_70 = default(n6.GpuValue<T>);
                var State_Output_72 = state_8.__p_FyI5BfQpEfbPgNif4Dd53K.Update(The_Value_In: The_Value_70, Output_Out: out n6.GpuValue<T> Output_71);
                n6.GpuValue<T> The_Value_73 = default(n6.GpuValue<T>);
                var State_Output_75 = state_8.__p_M9TAFSD4oNUOYMx6LkTrMB.Update(The_Value_In: The_Value_73, Output_Out: out n6.GpuValue<T> Output_74);
                n6.GpuValue<float> The_Value_76 = default(n6.GpuValue<float>);
                var State_Output_78 = state_8.__p_EZmuIA9L29wNjXjL5KLjV4.Update(The_Value_In: The_Value_76, Output_Out: out n6.GpuValue<float> Output_77);
                n6.GpuValue<float> The_Value_79 = default(n6.GpuValue<float>);
                var State_Output_81 = state_8.__p_AWpRcsszxWBMHzEnWLiB7Q.Update(The_Value_In: The_Value_79, Output_Out: out n6.GpuValue<float> Output_80);
                float The_Value_82 = 0.7F;
                var State_Output_84 = state_8.__p_Fh1Crphg5XhQTfEjoG2naF.Update(GpuValue_In: Jitter_In, The_Value_In: The_Value_82, Output_Out: out n6.GpuValue<float> Output_83);
                var State_Output_87 = state_8.__p_HpyvrVO1aAKLOb56BlWhxI.Update(Input_In: __pad_NJA6jx6xI7fL43MOCnHK5j_1, Input2_In: __pad_NJA6jx6xI7fL43MOCnHK5j_1, Output_Out: out n6.GpuValue<T> Output_85, Output2_Out: out n6.GpuValue<T> Output2_86);
                var State_Output_89 = state_8.__p_F6hPybtN6SAO5DHFVporpm.Update(Input_In: Output_85, Input_2_In: Output2_86, Metric_In: Metric_In, Minkowski_Power_In: Minkowski_Power_In, Output_Out: out n6.GpuValue<float> Output_88);
                n6.GpuValue<T> Input_2_90 = default(n6.GpuValue<T>);
                var builder_91 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU, 2);
                builder_91.Add(__pad_NJA6jx6xI7fL43MOCnHK5j_1);
                builder_91.Add(Input_2_90);
                var __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU_92 = builder_91.Commit();
                var State_Output_94 = state_8.__p_I8idI8zhyFkMKTzmmsKVEU.Update(Input_In: __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU_92, Output_Out: out n6.GpuValue<T> Output_93);
                n6.GpuValue<T> Input_2_95 = default(n6.GpuValue<T>);
                var builder_96 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF, 2);
                builder_96.Add(__pad_NJA6jx6xI7fL43MOCnHK5j_1);
                builder_96.Add(Input_2_95);
                var __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF_97 = builder_96.Commit();
                var State_Output_99 = state_8.__p_IRxR4inpEPwL7LXSxH1sqF.Update(Input_In: __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF_97, Output_Out: out n6.GpuValue<T> Output_98);
                var builder_100 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK, 2);
                builder_100.Add(Output_93);
                builder_100.Add(Output_98);
                var __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK_101 = builder_100.Commit();
                var State_Output_103 = state_8.__p_NuoA9XaToNWNGtUF7YHBvK.Update(Function_In: Output_88, Parameters_In: __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK_101, Id_In: __pad_HnlLOu9U4tPMzoKbM1RUuW_57, Output_Out: out n6.FunctionInvokeNode<float> Output_102);
                n6.IFunctionInvokeNode Input_104 = (n6.IFunctionInvokeNode)Output_102;
                var builder_105 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT, 1);
                builder_105.Add(Input_104);
                var __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT_106 = builder_105.Commit();
                n16._Operations_.FromValue<n6.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT_106, Result_Out: out n15.Spread<n6.IFunctionInvokeNode> Result_107);
                var Output_109 = state_8.__p_N8OfgewbBSFMNUBg6uwDCR.Update(Singleton_Out: out string Singleton_108);
                var builder_110 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz, 1);
                builder_110.Add(Singleton_108);
                var __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz_111 = builder_110.Commit();
                n16._Operations_.FromValue<string>(Input_In: __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz_111, Result_Out: out n15.Spread<string> Result_112);
                n17.IEnumerable<string> Mixins_113 = (n17.IEnumerable<string>)Result_112;
                n6.GpuValue<n29.Vector2> Default_Result_114 = default(n6.GpuValue<n29.Vector2>);
                bool Is_Groupable_115 = false;
                n17.IEnumerable<n6.InputModifier> The_Modifiers_116 = n22._Operations_.CreateDefault<n6.InputModifier>();
                var builder_117 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4, 6);
                builder_117.Add(Output_68);
                builder_117.Add(Output_71);
                builder_117.Add(Output_74);
                builder_117.Add(Output_77);
                builder_117.Add(Output_80);
                builder_117.Add(Output_83);
                var __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4_118 = builder_117.Commit();
                var State_Output_121 = state_8.__p_EtR4UpnBHQBL8vedVT1rC4.Update(Arguments_In: __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4_118, Function_Name_In: __pad_FvJdSa9rdfhNdi1Ly0F00N_59, Code_Template_In: __pad_NcmyZOjyEx5PLcW4GTAPcn_0, Default_Result_In: Default_Result_114, Functions_In: Result_107, Mixins_In: Mixins_113, Template_Values_In: Output_67, Is_Groupable_In: Is_Groupable_115, The_Modifiers_In: The_Modifiers_116, Output_Out: out n6.GpuValue<n29.Vector2> Output_119, AdditionalOutputs_Out: out n15.Spread<n6.AbstractGpuValue> AdditionalOutputs_120);
                var State_Output_123 = state_8.__p_E1oevnuce9qObQGBiFisIx.Update<n27.__AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW>(Input_In: Output_119, Amplitude_In: Amplitude_In, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: Inflection_In, Output_Out: out n6.GpuValue<n29.Vector2> Output_122);
                var Output_126 = state_8.__p_QqKLzh9IY6vNAh3QnjZT6u.Update(value_In: Output_122, x_Out: out n6.GpuValue<float> x_124, y_Out: out n6.GpuValue<float> y_125);
                var Output_128 = state_8.__p_UpUlSxZyjUKLfTcMiEyc64.Update(Value_In: __pad_RydL0nYumMUObm4KjllICf_58, GpuValue_Out: out n6.GpuValue<float> GpuValue_127);
                var builder_129 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_NaD60wKKkivME1dblxtGa1, 2);
                builder_129.Add(x_124);
                builder_129.Add(GpuValue_127);
                var __pin_group_Input_In_NaD60wKKkivME1dblxtGa1_130 = builder_129.Commit();
                var State_Output_132 = state_8.__p_NaD60wKKkivME1dblxtGa1.Update(Input_In: __pin_group_Input_In_NaD60wKKkivME1dblxtGa1_130, Output_Out: out n6.GpuValue<float> Output_131);
                n6.GpuValue<T> default_133 = default(n6.GpuValue<T>);
                var State_Output_135 = state_8.__p_RMvmyMX9cBNLFIszreIXwt.Update(x_In: Output_131, default_In: default_133, Output_Out: out n6.GpuValue<T> Output_134);
                var builder_136 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV, 2);
                builder_136.Add(Output_134);
                builder_136.Add(Output_71);
                var __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV_137 = builder_136.Commit();
                var State_Output_139 = state_8.__p_IAcEzBQuwu7NLXw97ojHTV.Update(Input_In: __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV_137, Output_Out: out n6.GpuValue<T> Output_138);
                n6.GpuValue<T> default_140 = default(n6.GpuValue<T>);
                var State_Output_142 = state_8.__p_Uy8ScJ1hrSUPxcn1TzdKrL.Update(x_In: Output_131, default_In: default_140, Output_Out: out n6.GpuValue<T> Output_141);
                var builder_143 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn, 2);
                builder_143.Add(Output_141);
                builder_143.Add(Output_74);
                var __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn_144 = builder_143.Commit();
                var State_Output_146 = state_8.__p_Kw1noU4j1U4NUMvwr5OFdn.Update(Input_In: __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn_144, Output_Out: out n6.GpuValue<T> Output_145);
                var builder_147 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE, 2);
                builder_147.Add(Output_131);
                builder_147.Add(Output_77);
                var __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE_148 = builder_147.Commit();
                var State_Output_150 = state_8.__p_BgChoZ4peyiMqDx5DTYvHE.Update(Input_In: __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE_148, Output_Out: out n6.GpuValue<float> Output_149);
                var builder_151 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4, 2);
                builder_151.Add(Output_80);
                builder_151.Add(Output_131);
                var __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4_152 = builder_151.Commit();
                var State_Output_154 = state_8.__p_GAhGAgUlRo3Lci0HDWAVK4.Update(Input_In: __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4_152, Output_Out: out n6.GpuValue<float> Output_153);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_62 != state_8.__p_LBU67G6xnS3PqrwX8ElUKu || __pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV_66 != state_8.__pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV || State_Output_69 != state_8.__p_AncIVyIIDlFNMjrHt6Repz || State_Output_72 != state_8.__p_FyI5BfQpEfbPgNif4Dd53K || State_Output_75 != state_8.__p_M9TAFSD4oNUOYMx6LkTrMB || State_Output_78 != state_8.__p_EZmuIA9L29wNjXjL5KLjV4 || State_Output_81 != state_8.__p_AWpRcsszxWBMHzEnWLiB7Q || State_Output_84 != state_8.__p_Fh1Crphg5XhQTfEjoG2naF || State_Output_87 != state_8.__p_HpyvrVO1aAKLOb56BlWhxI || State_Output_89 != state_8.__p_F6hPybtN6SAO5DHFVporpm || __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU_92 != state_8.__pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU || State_Output_94 != state_8.__p_I8idI8zhyFkMKTzmmsKVEU || __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF_97 != state_8.__pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF || State_Output_99 != state_8.__p_IRxR4inpEPwL7LXSxH1sqF || __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK_101 != state_8.__pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK || State_Output_103 != state_8.__p_NuoA9XaToNWNGtUF7YHBvK || __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT_106 != state_8.__pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT || Output_109 != state_8.__p_N8OfgewbBSFMNUBg6uwDCR || __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz_111 != state_8.__pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz || __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4_118 != state_8.__pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4 || State_Output_121 != state_8.__p_EtR4UpnBHQBL8vedVT1rC4 || State_Output_123 != state_8.__p_E1oevnuce9qObQGBiFisIx || Output_126 != state_8.__p_QqKLzh9IY6vNAh3QnjZT6u || Output_128 != state_8.__p_UpUlSxZyjUKLfTcMiEyc64 || __pin_group_Input_In_NaD60wKKkivME1dblxtGa1_130 != state_8.__pin_group_Input_In_NaD60wKKkivME1dblxtGa1 || State_Output_132 != state_8.__p_NaD60wKKkivME1dblxtGa1 || State_Output_135 != state_8.__p_RMvmyMX9cBNLFIszreIXwt || __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV_137 != state_8.__pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV || State_Output_139 != state_8.__p_IAcEzBQuwu7NLXw97ojHTV || State_Output_142 != state_8.__p_Uy8ScJ1hrSUPxcn1TzdKrL || __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn_144 != state_8.__pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn || State_Output_146 != state_8.__p_Kw1noU4j1U4NUMvwr5OFdn || __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE_148 != state_8.__pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE || State_Output_150 != state_8.__p_BgChoZ4peyiMqDx5DTYvHE || __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4_152 != state_8.__pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4 || State_Output_154 != state_8.__p_GAhGAgUlRo3Lci0HDWAVK4 ? new __SDTQ2xa7YkCNVmZVaiuWdZ(state_8)
                    {__p_LBU67G6xnS3PqrwX8ElUKu = State_Output_62, __pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV = __pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV_66, __p_AncIVyIIDlFNMjrHt6Repz = State_Output_69, __p_FyI5BfQpEfbPgNif4Dd53K = State_Output_72, __p_M9TAFSD4oNUOYMx6LkTrMB = State_Output_75, __p_EZmuIA9L29wNjXjL5KLjV4 = State_Output_78, __p_AWpRcsszxWBMHzEnWLiB7Q = State_Output_81, __p_Fh1Crphg5XhQTfEjoG2naF = State_Output_84, __p_HpyvrVO1aAKLOb56BlWhxI = State_Output_87, __p_F6hPybtN6SAO5DHFVporpm = State_Output_89, __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU = __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU_92, __p_I8idI8zhyFkMKTzmmsKVEU = State_Output_94, __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF = __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF_97, __p_IRxR4inpEPwL7LXSxH1sqF = State_Output_99, __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK = __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK_101, __p_NuoA9XaToNWNGtUF7YHBvK = State_Output_103, __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT = __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT_106, __p_N8OfgewbBSFMNUBg6uwDCR = Output_109, __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz = __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz_111, __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4 = __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4_118, __p_EtR4UpnBHQBL8vedVT1rC4 = State_Output_121, __p_E1oevnuce9qObQGBiFisIx = State_Output_123, __p_QqKLzh9IY6vNAh3QnjZT6u = Output_126, __p_UpUlSxZyjUKLfTcMiEyc64 = Output_128, __pin_group_Input_In_NaD60wKKkivME1dblxtGa1 = __pin_group_Input_In_NaD60wKKkivME1dblxtGa1_130, __p_NaD60wKKkivME1dblxtGa1 = State_Output_132, __p_RMvmyMX9cBNLFIszreIXwt = State_Output_135, __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV = __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV_137, __p_IAcEzBQuwu7NLXw97ojHTV = State_Output_139, __p_Uy8ScJ1hrSUPxcn1TzdKrL = State_Output_142, __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn = __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn_144, __p_Kw1noU4j1U4NUMvwr5OFdn = State_Output_146, __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE = __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE_148, __p_BgChoZ4peyiMqDx5DTYvHE = State_Output_150, __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4 = __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4_152, __p_GAhGAgUlRo3Lci0HDWAVK4 = State_Output_154} : state_8;
                else
                {
                    state_8.__p_LBU67G6xnS3PqrwX8ElUKu = State_Output_62;
                    state_8.__pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV = __pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV_66;
                    state_8.__p_AncIVyIIDlFNMjrHt6Repz = State_Output_69;
                    state_8.__p_FyI5BfQpEfbPgNif4Dd53K = State_Output_72;
                    state_8.__p_M9TAFSD4oNUOYMx6LkTrMB = State_Output_75;
                    state_8.__p_EZmuIA9L29wNjXjL5KLjV4 = State_Output_78;
                    state_8.__p_AWpRcsszxWBMHzEnWLiB7Q = State_Output_81;
                    state_8.__p_Fh1Crphg5XhQTfEjoG2naF = State_Output_84;
                    state_8.__p_HpyvrVO1aAKLOb56BlWhxI = State_Output_87;
                    state_8.__p_F6hPybtN6SAO5DHFVporpm = State_Output_89;
                    state_8.__pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU = __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU_92;
                    state_8.__p_I8idI8zhyFkMKTzmmsKVEU = State_Output_94;
                    state_8.__pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF = __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF_97;
                    state_8.__p_IRxR4inpEPwL7LXSxH1sqF = State_Output_99;
                    state_8.__pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK = __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK_101;
                    state_8.__p_NuoA9XaToNWNGtUF7YHBvK = State_Output_103;
                    state_8.__pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT = __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT_106;
                    state_8.__p_N8OfgewbBSFMNUBg6uwDCR = Output_109;
                    state_8.__pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz = __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz_111;
                    state_8.__pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4 = __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4_118;
                    state_8.__p_EtR4UpnBHQBL8vedVT1rC4 = State_Output_121;
                    state_8.__p_E1oevnuce9qObQGBiFisIx = State_Output_123;
                    state_8.__p_QqKLzh9IY6vNAh3QnjZT6u = Output_126;
                    state_8.__p_UpUlSxZyjUKLfTcMiEyc64 = Output_128;
                    state_8.__pin_group_Input_In_NaD60wKKkivME1dblxtGa1 = __pin_group_Input_In_NaD60wKKkivME1dblxtGa1_130;
                    state_8.__p_NaD60wKKkivME1dblxtGa1 = State_Output_132;
                    state_8.__p_RMvmyMX9cBNLFIszreIXwt = State_Output_135;
                    state_8.__pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV = __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV_137;
                    state_8.__p_IAcEzBQuwu7NLXw97ojHTV = State_Output_139;
                    state_8.__p_Uy8ScJ1hrSUPxcn1TzdKrL = State_Output_142;
                    state_8.__pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn = __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn_144;
                    state_8.__p_Kw1noU4j1U4NUMvwr5OFdn = State_Output_146;
                    state_8.__pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE = __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE_148;
                    state_8.__p_BgChoZ4peyiMqDx5DTYvHE = State_Output_150;
                    state_8.__pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4 = __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4_152;
                    state_8.__p_GAhGAgUlRo3Lci0HDWAVK4 = State_Output_154;
                }

                outputs_6 = (x_124, y_125, Output_138, Output_145, Output_149, Output_153);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var(__auto_155, __auto_156, __auto_157, __auto_158, __auto_159, __auto_160) = outputs_6;
            F1_Distance_Out = __auto_155;
            F2_Distance_Out = __auto_156;
            F1_Position_Out = __auto_157;
            F2_Position_Out = __auto_158;
            F1_ID_Out = __auto_159;
            F2_ID_Out = __auto_160;
            n4.WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T> that_161 = this;
            if (this.__GetContext__().IsImmutable)
                that_161 = manager_4 != this.__cache_RbAHL3cmBiWMd0AbcEarfZ ? new WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T>(this)
                {__cache_RbAHL3cmBiWMd0AbcEarfZ = manager_4} : that_161;
            else
            {
                this.__cache_RbAHL3cmBiWMd0AbcEarfZ = manager_4;
            }

            return that_161;
        }

        public n4.WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T> __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T> that_0 = this;
            this.__cache_RbAHL3cmBiWMd0AbcEarfZ = null;
            return that_0;
        }

        public n4.WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T> __CreateDefault__()
        {
            n4.WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T> that_0 = this;
            this.__cache_RbAHL3cmBiWMd0AbcEarfZ = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_RbAHL3cmBiWMd0AbcEarfZ);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 318366U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NcmyZOjyEx5PLcW4GTAPcn", Name = "__slot_NcmyZOjyEx5PLcW4GTAPcn")]
        public static string __slot_NcmyZOjyEx5PLcW4GTAPcn = "//Worley F1 F2\r\n#ifndef DistOverride\r\n#define DistOverride\r\noverride float distFunc(${DOMAIN} a, ${DOMAIN} b)\r\n{\r\n\treturn ${DIST_FUNC}(a, b);\r\n}\r\n#endif\r\n\r\nfloat2 ${signature} (${DOMAIN} p, out ${DOMAIN} F1Pos, out ${DOMAIN} F2Pos, out float F1ID, out float F2ID, float jitter)\r\n{\r\n\treturn worleyF1F2(p, F1Pos, F2Pos, F1ID, F2ID, jitter);\r\n}";
        [n2.ElementAttribute(TracingId = 318392U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NJA6jx6xI7fL43MOCnHK5j", Name = "__slot_NJA6jx6xI7fL43MOCnHK5j")]
        public static n6.GpuValue<T> __slot_NJA6jx6xI7fL43MOCnHK5j = default(n6.GpuValue<T>);
        [n2.ElementAttribute(TracingId = 317967U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RbAHL3cmBiWMd0AbcEarfZ", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<string, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<n29.Vector2>, n6.GpuValue<T>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n3.ValueTuple<n7.NoiseBasisInflection, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<float>>> __cache_RbAHL3cmBiWMd0AbcEarfZ = null;
        [n2.ElementAttribute(TracingId = 318082U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HnlLOu9U4tPMzoKbM1RUuW", Name = "__slot_HnlLOu9U4tPMzoKbM1RUuW")]
        public static string __slot_HnlLOu9U4tPMzoKbM1RUuW = "DIST_FUNC";
        [n2.ElementAttribute(TracingId = 318213U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RydL0nYumMUObm4KjllICf", Name = "__slot_RydL0nYumMUObm4KjllICf")]
        public static float __slot_RydL0nYumMUObm4KjllICf = 0F;
        [n2.ElementAttribute(TracingId = 318158U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "FvJdSa9rdfhNdi1Ly0F00N", Name = "__slot_FvJdSa9rdfhNdi1Ly0F00N")]
        public static string __slot_FvJdSa9rdfhNdi1Ly0F00N = "F1F2";
        static WorleyF1F2_U0wLdif0D7hNPYlsruiDCG()
        {
        }

        public WorleyF1F2_U0wLdif0D7hNPYlsruiDCG(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal WorleyF1F2_U0wLdif0D7hNPYlsruiDCG(WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T> other): base(other)
        {
            this.__cache_RbAHL3cmBiWMd0AbcEarfZ = other.__cache_RbAHL3cmBiWMd0AbcEarfZ;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_RbAHL3cmBiWMd0AbcEarfZ", in __cache_RbAHL3cmBiWMd0AbcEarfZ));
        }

        internal WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T> __WITH__(n9.Manager<n3.ValueTuple<string, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<n29.Vector2>, n6.GpuValue<T>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n3.ValueTuple<n7.NoiseBasisInflection, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<float>>> __cache_RbAHL3cmBiWMd0AbcEarfZ)
        {
            n4.WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_RbAHL3cmBiWMd0AbcEarfZ != this.__cache_RbAHL3cmBiWMd0AbcEarfZ ? new WorleyF1F2_U0wLdif0D7hNPYlsruiDCG<T>(this)
                {__cache_RbAHL3cmBiWMd0AbcEarfZ = __cache_RbAHL3cmBiWMd0AbcEarfZ} : that_0;
            else
            {
                this.__cache_RbAHL3cmBiWMd0AbcEarfZ = __cache_RbAHL3cmBiWMd0AbcEarfZ;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SDTQ2xa7YkCNVmZVaiuWdZ", Name = "__SDTQ2xa7YkCNVmZVaiuWdZ")]
        [n3.SerializableAttribute]
        public class __SDTQ2xa7YkCNVmZVaiuWdZ : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_LBU67G6xnS3PqrwX8ElUKu);
                n2.CompilationHelper.SafeDispose(this.__p_AncIVyIIDlFNMjrHt6Repz);
                n2.CompilationHelper.SafeDispose(this.__p_E1oevnuce9qObQGBiFisIx);
                n2.CompilationHelper.SafeDispose(this.__p_EtR4UpnBHQBL8vedVT1rC4);
                n2.CompilationHelper.SafeDispose(this.__p_FyI5BfQpEfbPgNif4Dd53K);
                n2.CompilationHelper.SafeDispose(this.__p_EZmuIA9L29wNjXjL5KLjV4);
                n2.CompilationHelper.SafeDispose(this.__p_F6hPybtN6SAO5DHFVporpm);
                n2.CompilationHelper.SafeDispose(this.__p_HpyvrVO1aAKLOb56BlWhxI);
                n2.CompilationHelper.SafeDispose(this.__p_I8idI8zhyFkMKTzmmsKVEU);
                n2.CompilationHelper.SafeDispose(this.__p_IRxR4inpEPwL7LXSxH1sqF);
                n2.CompilationHelper.SafeDispose(this.__p_Fh1Crphg5XhQTfEjoG2naF);
                n2.CompilationHelper.SafeDispose(this.__p_NaD60wKKkivME1dblxtGa1);
                n2.CompilationHelper.SafeDispose(this.__p_UpUlSxZyjUKLfTcMiEyc64);
                n2.CompilationHelper.SafeDispose(this.__p_BgChoZ4peyiMqDx5DTYvHE);
                n2.CompilationHelper.SafeDispose(this.__p_IAcEzBQuwu7NLXw97ojHTV);
                n2.CompilationHelper.SafeDispose(this.__p_RMvmyMX9cBNLFIszreIXwt);
                n2.CompilationHelper.SafeDispose(this.__p_AWpRcsszxWBMHzEnWLiB7Q);
                n2.CompilationHelper.SafeDispose(this.__p_M9TAFSD4oNUOYMx6LkTrMB);
                n2.CompilationHelper.SafeDispose(this.__p_GAhGAgUlRo3Lci0HDWAVK4);
                n2.CompilationHelper.SafeDispose(this.__p_Kw1noU4j1U4NUMvwr5OFdn);
                n2.CompilationHelper.SafeDispose(this.__p_Uy8ScJ1hrSUPxcn1TzdKrL);
                n2.CompilationHelper.SafeDispose(this.__p_QqKLzh9IY6vNAh3QnjZT6u);
                n2.CompilationHelper.SafeDispose(this.__p_N8OfgewbBSFMNUBg6uwDCR);
                n2.CompilationHelper.SafeDispose(this.__p_NuoA9XaToNWNGtUF7YHBvK);
                return;
            }

            [n2.ElementAttribute(TracingId = 318019U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LBU67G6xnS3PqrwX8ElUKu", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T> __p_LBU67G6xnS3PqrwX8ElUKu;
            [n2.ElementAttribute(TracingId = 318028U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "AncIVyIIDlFNMjrHt6Repz", Name = "ScaleAndAdd", IsManaged = true, IsAutoGenerated = true)]
            public n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T> __p_AncIVyIIDlFNMjrHt6Repz;
            [n2.ElementAttribute(TracingId = 318040U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "E1oevnuce9qObQGBiFisIx", Name = "NoiseShaper", IsManaged = true, IsAutoGenerated = true)]
            public n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<n29.Vector2> __p_E1oevnuce9qObQGBiFisIx;
            [n2.ElementAttribute(TracingId = 318050U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "EtR4UpnBHQBL8vedVT1rC4", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<n29.Vector2, n17.IEnumerable<n6.InputModifier>> __p_EtR4UpnBHQBL8vedVT1rC4;
            [n2.ElementAttribute(TracingId = 318103U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "FyI5BfQpEfbPgNif4Dd53K", Name = "DeclareValue", IsManaged = true, IsAutoGenerated = true)]
            public n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<T> __p_FyI5BfQpEfbPgNif4Dd53K;
            [n2.ElementAttribute(TracingId = 318111U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "EZmuIA9L29wNjXjL5KLjV4", Name = "DeclareValue", IsManaged = true, IsAutoGenerated = true)]
            public n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<float> __p_EZmuIA9L29wNjXjL5KLjV4;
            [n2.ElementAttribute(TracingId = 318122U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "F6hPybtN6SAO5DHFVporpm", Name = "DistanceMetrics", IsManaged = true, IsAutoGenerated = true)]
            public n25.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> __p_F6hPybtN6SAO5DHFVporpm;
            [n2.ElementAttribute(TracingId = 318143U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HpyvrVO1aAKLOb56BlWhxI", Name = "FunctionParameter (2 Parameters)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__2_Parameters_MrNZAlN5DurPW7lYURP3Qu<T, T> __p_HpyvrVO1aAKLOb56BlWhxI;
            [n2.ElementAttribute(TracingId = 318174U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "I8idI8zhyFkMKTzmmsKVEU", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_I8idI8zhyFkMKTzmmsKVEU;
            [n2.ElementAttribute(TracingId = 318182U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "IRxR4inpEPwL7LXSxH1sqF", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_IRxR4inpEPwL7LXSxH1sqF;
            [n2.ElementAttribute(TracingId = 318191U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Fh1Crphg5XhQTfEjoG2naF", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_Fh1Crphg5XhQTfEjoG2naF;
            [n2.ElementAttribute(TracingId = 318200U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NaD60wKKkivME1dblxtGa1", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_NaD60wKKkivME1dblxtGa1;
            [n2.ElementAttribute(TracingId = 318207U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "UpUlSxZyjUKLfTcMiEyc64", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_UpUlSxZyjUKLfTcMiEyc64;
            [n2.ElementAttribute(TracingId = 318216U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BgChoZ4peyiMqDx5DTYvHE", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_BgChoZ4peyiMqDx5DTYvHE;
            [n2.ElementAttribute(TracingId = 318227U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "IAcEzBQuwu7NLXw97ojHTV", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_IAcEzBQuwu7NLXw97ojHTV;
            [n2.ElementAttribute(TracingId = 318238U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RMvmyMX9cBNLFIszreIXwt", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_RMvmyMX9cBNLFIszreIXwt;
            [n2.ElementAttribute(TracingId = 318261U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "AWpRcsszxWBMHzEnWLiB7Q", Name = "DeclareValue", IsManaged = true, IsAutoGenerated = true)]
            public n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<float> __p_AWpRcsszxWBMHzEnWLiB7Q;
            [n2.ElementAttribute(TracingId = 318275U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "M9TAFSD4oNUOYMx6LkTrMB", Name = "DeclareValue", IsManaged = true, IsAutoGenerated = true)]
            public n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<T> __p_M9TAFSD4oNUOYMx6LkTrMB;
            [n2.ElementAttribute(TracingId = 318289U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "GAhGAgUlRo3Lci0HDWAVK4", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_GAhGAgUlRo3Lci0HDWAVK4;
            [n2.ElementAttribute(TracingId = 318297U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Kw1noU4j1U4NUMvwr5OFdn", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_Kw1noU4j1U4NUMvwr5OFdn;
            [n2.ElementAttribute(TracingId = 318306U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Uy8ScJ1hrSUPxcn1TzdKrL", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_Uy8ScJ1hrSUPxcn1TzdKrL;
            [n2.ElementAttribute(TracingId = 318314U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "QqKLzh9IY6vNAh3QnjZT6u", Name = "x-y (split)", IsManaged = true, IsAutoGenerated = true)]
            public n30.xMy_split_OlHtbWbJLVYNwNtomhsBtR __p_QqKLzh9IY6vNAh3QnjZT6u;
            [n2.ElementAttribute(TracingId = 318321U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "N8OfgewbBSFMNUBg6uwDCR", Name = "FuseCommonNoiseWorley (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 __p_N8OfgewbBSFMNUBg6uwDCR;
            [n2.ElementAttribute(TracingId = 318327U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NuoA9XaToNWNGtUF7YHBvK", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n11.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_NuoA9XaToNWNGtUF7YHBvK;
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n20.ImmutableDictionary<string, string> __pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV = default(n20.ImmutableDictionary<string, string>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU = default(n15.Spread<n6.GpuValue<T>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF = default(n15.Spread<n6.GpuValue<T>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK = default(n15.Spread<n6.AbstractGpuValue>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.IFunctionInvokeNode> __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT = default(n15.Spread<n6.IFunctionInvokeNode>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<string> __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz = default(n15.Spread<string>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4 = default(n15.Spread<n6.AbstractGpuValue>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_NaD60wKKkivME1dblxtGa1 = default(n15.Spread<n6.GpuValue<float>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV = default(n15.Spread<n6.GpuValue<T>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn = default(n15.Spread<n6.GpuValue<T>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE = default(n15.Spread<n6.GpuValue<float>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4 = default(n15.Spread<n6.GpuValue<float>>);
            public __SDTQ2xa7YkCNVmZVaiuWdZ(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SDTQ2xa7YkCNVmZVaiuWdZ(__SDTQ2xa7YkCNVmZVaiuWdZ other): base(other)
            {
                this.__p_LBU67G6xnS3PqrwX8ElUKu = other.__p_LBU67G6xnS3PqrwX8ElUKu;
                this.__p_AncIVyIIDlFNMjrHt6Repz = other.__p_AncIVyIIDlFNMjrHt6Repz;
                this.__p_E1oevnuce9qObQGBiFisIx = other.__p_E1oevnuce9qObQGBiFisIx;
                this.__p_EtR4UpnBHQBL8vedVT1rC4 = other.__p_EtR4UpnBHQBL8vedVT1rC4;
                this.__p_FyI5BfQpEfbPgNif4Dd53K = other.__p_FyI5BfQpEfbPgNif4Dd53K;
                this.__p_EZmuIA9L29wNjXjL5KLjV4 = other.__p_EZmuIA9L29wNjXjL5KLjV4;
                this.__p_F6hPybtN6SAO5DHFVporpm = other.__p_F6hPybtN6SAO5DHFVporpm;
                this.__p_HpyvrVO1aAKLOb56BlWhxI = other.__p_HpyvrVO1aAKLOb56BlWhxI;
                this.__p_I8idI8zhyFkMKTzmmsKVEU = other.__p_I8idI8zhyFkMKTzmmsKVEU;
                this.__p_IRxR4inpEPwL7LXSxH1sqF = other.__p_IRxR4inpEPwL7LXSxH1sqF;
                this.__p_Fh1Crphg5XhQTfEjoG2naF = other.__p_Fh1Crphg5XhQTfEjoG2naF;
                this.__p_NaD60wKKkivME1dblxtGa1 = other.__p_NaD60wKKkivME1dblxtGa1;
                this.__p_UpUlSxZyjUKLfTcMiEyc64 = other.__p_UpUlSxZyjUKLfTcMiEyc64;
                this.__p_BgChoZ4peyiMqDx5DTYvHE = other.__p_BgChoZ4peyiMqDx5DTYvHE;
                this.__p_IAcEzBQuwu7NLXw97ojHTV = other.__p_IAcEzBQuwu7NLXw97ojHTV;
                this.__p_RMvmyMX9cBNLFIszreIXwt = other.__p_RMvmyMX9cBNLFIszreIXwt;
                this.__p_AWpRcsszxWBMHzEnWLiB7Q = other.__p_AWpRcsszxWBMHzEnWLiB7Q;
                this.__p_M9TAFSD4oNUOYMx6LkTrMB = other.__p_M9TAFSD4oNUOYMx6LkTrMB;
                this.__p_GAhGAgUlRo3Lci0HDWAVK4 = other.__p_GAhGAgUlRo3Lci0HDWAVK4;
                this.__p_Kw1noU4j1U4NUMvwr5OFdn = other.__p_Kw1noU4j1U4NUMvwr5OFdn;
                this.__p_Uy8ScJ1hrSUPxcn1TzdKrL = other.__p_Uy8ScJ1hrSUPxcn1TzdKrL;
                this.__p_QqKLzh9IY6vNAh3QnjZT6u = other.__p_QqKLzh9IY6vNAh3QnjZT6u;
                this.__p_N8OfgewbBSFMNUBg6uwDCR = other.__p_N8OfgewbBSFMNUBg6uwDCR;
                this.__p_NuoA9XaToNWNGtUF7YHBvK = other.__p_NuoA9XaToNWNGtUF7YHBvK;
                this.__pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV = other.__pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV;
                this.__pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU = other.__pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU;
                this.__pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF = other.__pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF;
                this.__pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK = other.__pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK;
                this.__pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT = other.__pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT;
                this.__pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz = other.__pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz;
                this.__pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4 = other.__pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4;
                this.__pin_group_Input_In_NaD60wKKkivME1dblxtGa1 = other.__pin_group_Input_In_NaD60wKKkivME1dblxtGa1;
                this.__pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV = other.__pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV;
                this.__pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn = other.__pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn;
                this.__pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE = other.__pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE;
                this.__pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4 = other.__pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_LBU67G6xnS3PqrwX8ElUKu", in __p_LBU67G6xnS3PqrwX8ElUKu), n2.CompilationHelper.GetValueOrExisting(values, "__p_AncIVyIIDlFNMjrHt6Repz", in __p_AncIVyIIDlFNMjrHt6Repz), n2.CompilationHelper.GetValueOrExisting(values, "__p_E1oevnuce9qObQGBiFisIx", in __p_E1oevnuce9qObQGBiFisIx), n2.CompilationHelper.GetValueOrExisting(values, "__p_EtR4UpnBHQBL8vedVT1rC4", in __p_EtR4UpnBHQBL8vedVT1rC4), n2.CompilationHelper.GetValueOrExisting(values, "__p_FyI5BfQpEfbPgNif4Dd53K", in __p_FyI5BfQpEfbPgNif4Dd53K), n2.CompilationHelper.GetValueOrExisting(values, "__p_EZmuIA9L29wNjXjL5KLjV4", in __p_EZmuIA9L29wNjXjL5KLjV4), n2.CompilationHelper.GetValueOrExisting(values, "__p_F6hPybtN6SAO5DHFVporpm", in __p_F6hPybtN6SAO5DHFVporpm), n2.CompilationHelper.GetValueOrExisting(values, "__p_HpyvrVO1aAKLOb56BlWhxI", in __p_HpyvrVO1aAKLOb56BlWhxI), n2.CompilationHelper.GetValueOrExisting(values, "__p_I8idI8zhyFkMKTzmmsKVEU", in __p_I8idI8zhyFkMKTzmmsKVEU), n2.CompilationHelper.GetValueOrExisting(values, "__p_IRxR4inpEPwL7LXSxH1sqF", in __p_IRxR4inpEPwL7LXSxH1sqF), n2.CompilationHelper.GetValueOrExisting(values, "__p_Fh1Crphg5XhQTfEjoG2naF", in __p_Fh1Crphg5XhQTfEjoG2naF), n2.CompilationHelper.GetValueOrExisting(values, "__p_NaD60wKKkivME1dblxtGa1", in __p_NaD60wKKkivME1dblxtGa1), n2.CompilationHelper.GetValueOrExisting(values, "__p_UpUlSxZyjUKLfTcMiEyc64", in __p_UpUlSxZyjUKLfTcMiEyc64), n2.CompilationHelper.GetValueOrExisting(values, "__p_BgChoZ4peyiMqDx5DTYvHE", in __p_BgChoZ4peyiMqDx5DTYvHE), n2.CompilationHelper.GetValueOrExisting(values, "__p_IAcEzBQuwu7NLXw97ojHTV", in __p_IAcEzBQuwu7NLXw97ojHTV), n2.CompilationHelper.GetValueOrExisting(values, "__p_RMvmyMX9cBNLFIszreIXwt", in __p_RMvmyMX9cBNLFIszreIXwt), n2.CompilationHelper.GetValueOrExisting(values, "__p_AWpRcsszxWBMHzEnWLiB7Q", in __p_AWpRcsszxWBMHzEnWLiB7Q), n2.CompilationHelper.GetValueOrExisting(values, "__p_M9TAFSD4oNUOYMx6LkTrMB", in __p_M9TAFSD4oNUOYMx6LkTrMB), n2.CompilationHelper.GetValueOrExisting(values, "__p_GAhGAgUlRo3Lci0HDWAVK4", in __p_GAhGAgUlRo3Lci0HDWAVK4), n2.CompilationHelper.GetValueOrExisting(values, "__p_Kw1noU4j1U4NUMvwr5OFdn", in __p_Kw1noU4j1U4NUMvwr5OFdn), n2.CompilationHelper.GetValueOrExisting(values, "__p_Uy8ScJ1hrSUPxcn1TzdKrL", in __p_Uy8ScJ1hrSUPxcn1TzdKrL), n2.CompilationHelper.GetValueOrExisting(values, "__p_QqKLzh9IY6vNAh3QnjZT6u", in __p_QqKLzh9IY6vNAh3QnjZT6u), n2.CompilationHelper.GetValueOrExisting(values, "__p_N8OfgewbBSFMNUBg6uwDCR", in __p_N8OfgewbBSFMNUBg6uwDCR), n2.CompilationHelper.GetValueOrExisting(values, "__p_NuoA9XaToNWNGtUF7YHBvK", in __p_NuoA9XaToNWNGtUF7YHBvK), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV", in __pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU", in __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF", in __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK", in __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT", in __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz", in __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4", in __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_NaD60wKKkivME1dblxtGa1", in __pin_group_Input_In_NaD60wKKkivME1dblxtGa1), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV", in __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn", in __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE", in __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4", in __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4));
            }

            internal __SDTQ2xa7YkCNVmZVaiuWdZ __WITH__(n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T> __p_LBU67G6xnS3PqrwX8ElUKu, n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T> __p_AncIVyIIDlFNMjrHt6Repz, n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<n29.Vector2> __p_E1oevnuce9qObQGBiFisIx, n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<n29.Vector2, n17.IEnumerable<n6.InputModifier>> __p_EtR4UpnBHQBL8vedVT1rC4, n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<T> __p_FyI5BfQpEfbPgNif4Dd53K, n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<float> __p_EZmuIA9L29wNjXjL5KLjV4, n25.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> __p_F6hPybtN6SAO5DHFVporpm, n11.FunctionParameter__2_Parameters_MrNZAlN5DurPW7lYURP3Qu<T, T> __p_HpyvrVO1aAKLOb56BlWhxI, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_I8idI8zhyFkMKTzmmsKVEU, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_IRxR4inpEPwL7LXSxH1sqF, n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_Fh1Crphg5XhQTfEjoG2naF, n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_NaD60wKKkivME1dblxtGa1, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_UpUlSxZyjUKLfTcMiEyc64, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_BgChoZ4peyiMqDx5DTYvHE, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_IAcEzBQuwu7NLXw97ojHTV, n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_RMvmyMX9cBNLFIszreIXwt, n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<float> __p_AWpRcsszxWBMHzEnWLiB7Q, n24.DeclareValue_Tth4waqiyuFPTW10aFkGRD<T> __p_M9TAFSD4oNUOYMx6LkTrMB, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_GAhGAgUlRo3Lci0HDWAVK4, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_Kw1noU4j1U4NUMvwr5OFdn, n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_Uy8ScJ1hrSUPxcn1TzdKrL, n30.xMy_split_OlHtbWbJLVYNwNtomhsBtR __p_QqKLzh9IY6vNAh3QnjZT6u, n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 __p_N8OfgewbBSFMNUBg6uwDCR, n11.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_NuoA9XaToNWNGtUF7YHBvK, n20.ImmutableDictionary<string, string> __pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV, n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU, n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF, n15.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK, n15.Spread<n6.IFunctionInvokeNode> __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT, n15.Spread<string> __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz, n15.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4, n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_NaD60wKKkivME1dblxtGa1, n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV, n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn, n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE, n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4)
            {
                __SDTQ2xa7YkCNVmZVaiuWdZ that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_LBU67G6xnS3PqrwX8ElUKu != this.__p_LBU67G6xnS3PqrwX8ElUKu || __p_AncIVyIIDlFNMjrHt6Repz != this.__p_AncIVyIIDlFNMjrHt6Repz || __p_E1oevnuce9qObQGBiFisIx != this.__p_E1oevnuce9qObQGBiFisIx || __p_EtR4UpnBHQBL8vedVT1rC4 != this.__p_EtR4UpnBHQBL8vedVT1rC4 || __p_FyI5BfQpEfbPgNif4Dd53K != this.__p_FyI5BfQpEfbPgNif4Dd53K || __p_EZmuIA9L29wNjXjL5KLjV4 != this.__p_EZmuIA9L29wNjXjL5KLjV4 || __p_F6hPybtN6SAO5DHFVporpm != this.__p_F6hPybtN6SAO5DHFVporpm || __p_HpyvrVO1aAKLOb56BlWhxI != this.__p_HpyvrVO1aAKLOb56BlWhxI || __p_I8idI8zhyFkMKTzmmsKVEU != this.__p_I8idI8zhyFkMKTzmmsKVEU || __p_IRxR4inpEPwL7LXSxH1sqF != this.__p_IRxR4inpEPwL7LXSxH1sqF || __p_Fh1Crphg5XhQTfEjoG2naF != this.__p_Fh1Crphg5XhQTfEjoG2naF || __p_NaD60wKKkivME1dblxtGa1 != this.__p_NaD60wKKkivME1dblxtGa1 || __p_UpUlSxZyjUKLfTcMiEyc64 != this.__p_UpUlSxZyjUKLfTcMiEyc64 || __p_BgChoZ4peyiMqDx5DTYvHE != this.__p_BgChoZ4peyiMqDx5DTYvHE || __p_IAcEzBQuwu7NLXw97ojHTV != this.__p_IAcEzBQuwu7NLXw97ojHTV || __p_RMvmyMX9cBNLFIszreIXwt != this.__p_RMvmyMX9cBNLFIszreIXwt || __p_AWpRcsszxWBMHzEnWLiB7Q != this.__p_AWpRcsszxWBMHzEnWLiB7Q || __p_M9TAFSD4oNUOYMx6LkTrMB != this.__p_M9TAFSD4oNUOYMx6LkTrMB || __p_GAhGAgUlRo3Lci0HDWAVK4 != this.__p_GAhGAgUlRo3Lci0HDWAVK4 || __p_Kw1noU4j1U4NUMvwr5OFdn != this.__p_Kw1noU4j1U4NUMvwr5OFdn || __p_Uy8ScJ1hrSUPxcn1TzdKrL != this.__p_Uy8ScJ1hrSUPxcn1TzdKrL || __p_QqKLzh9IY6vNAh3QnjZT6u != this.__p_QqKLzh9IY6vNAh3QnjZT6u || __p_N8OfgewbBSFMNUBg6uwDCR != this.__p_N8OfgewbBSFMNUBg6uwDCR || __p_NuoA9XaToNWNGtUF7YHBvK != this.__p_NuoA9XaToNWNGtUF7YHBvK || __pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV != this.__pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV || __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU != this.__pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU || __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF != this.__pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF || __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK != this.__pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK || __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT != this.__pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT || __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz != this.__pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz || __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4 != this.__pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4 || __pin_group_Input_In_NaD60wKKkivME1dblxtGa1 != this.__pin_group_Input_In_NaD60wKKkivME1dblxtGa1 || __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV != this.__pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV || __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn != this.__pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn || __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE != this.__pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE || __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4 != this.__pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4 ? new __SDTQ2xa7YkCNVmZVaiuWdZ(this)
                    {__p_LBU67G6xnS3PqrwX8ElUKu = __p_LBU67G6xnS3PqrwX8ElUKu, __p_AncIVyIIDlFNMjrHt6Repz = __p_AncIVyIIDlFNMjrHt6Repz, __p_E1oevnuce9qObQGBiFisIx = __p_E1oevnuce9qObQGBiFisIx, __p_EtR4UpnBHQBL8vedVT1rC4 = __p_EtR4UpnBHQBL8vedVT1rC4, __p_FyI5BfQpEfbPgNif4Dd53K = __p_FyI5BfQpEfbPgNif4Dd53K, __p_EZmuIA9L29wNjXjL5KLjV4 = __p_EZmuIA9L29wNjXjL5KLjV4, __p_F6hPybtN6SAO5DHFVporpm = __p_F6hPybtN6SAO5DHFVporpm, __p_HpyvrVO1aAKLOb56BlWhxI = __p_HpyvrVO1aAKLOb56BlWhxI, __p_I8idI8zhyFkMKTzmmsKVEU = __p_I8idI8zhyFkMKTzmmsKVEU, __p_IRxR4inpEPwL7LXSxH1sqF = __p_IRxR4inpEPwL7LXSxH1sqF, __p_Fh1Crphg5XhQTfEjoG2naF = __p_Fh1Crphg5XhQTfEjoG2naF, __p_NaD60wKKkivME1dblxtGa1 = __p_NaD60wKKkivME1dblxtGa1, __p_UpUlSxZyjUKLfTcMiEyc64 = __p_UpUlSxZyjUKLfTcMiEyc64, __p_BgChoZ4peyiMqDx5DTYvHE = __p_BgChoZ4peyiMqDx5DTYvHE, __p_IAcEzBQuwu7NLXw97ojHTV = __p_IAcEzBQuwu7NLXw97ojHTV, __p_RMvmyMX9cBNLFIszreIXwt = __p_RMvmyMX9cBNLFIszreIXwt, __p_AWpRcsszxWBMHzEnWLiB7Q = __p_AWpRcsszxWBMHzEnWLiB7Q, __p_M9TAFSD4oNUOYMx6LkTrMB = __p_M9TAFSD4oNUOYMx6LkTrMB, __p_GAhGAgUlRo3Lci0HDWAVK4 = __p_GAhGAgUlRo3Lci0HDWAVK4, __p_Kw1noU4j1U4NUMvwr5OFdn = __p_Kw1noU4j1U4NUMvwr5OFdn, __p_Uy8ScJ1hrSUPxcn1TzdKrL = __p_Uy8ScJ1hrSUPxcn1TzdKrL, __p_QqKLzh9IY6vNAh3QnjZT6u = __p_QqKLzh9IY6vNAh3QnjZT6u, __p_N8OfgewbBSFMNUBg6uwDCR = __p_N8OfgewbBSFMNUBg6uwDCR, __p_NuoA9XaToNWNGtUF7YHBvK = __p_NuoA9XaToNWNGtUF7YHBvK, __pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV = __pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV, __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU = __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU, __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF = __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF, __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK = __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK, __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT = __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT, __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz = __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz, __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4 = __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4, __pin_group_Input_In_NaD60wKKkivME1dblxtGa1 = __pin_group_Input_In_NaD60wKKkivME1dblxtGa1, __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV = __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV, __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn = __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn, __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE = __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE, __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4 = __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4} : that_0;
                else
                {
                    this.__p_LBU67G6xnS3PqrwX8ElUKu = __p_LBU67G6xnS3PqrwX8ElUKu;
                    this.__p_AncIVyIIDlFNMjrHt6Repz = __p_AncIVyIIDlFNMjrHt6Repz;
                    this.__p_E1oevnuce9qObQGBiFisIx = __p_E1oevnuce9qObQGBiFisIx;
                    this.__p_EtR4UpnBHQBL8vedVT1rC4 = __p_EtR4UpnBHQBL8vedVT1rC4;
                    this.__p_FyI5BfQpEfbPgNif4Dd53K = __p_FyI5BfQpEfbPgNif4Dd53K;
                    this.__p_EZmuIA9L29wNjXjL5KLjV4 = __p_EZmuIA9L29wNjXjL5KLjV4;
                    this.__p_F6hPybtN6SAO5DHFVporpm = __p_F6hPybtN6SAO5DHFVporpm;
                    this.__p_HpyvrVO1aAKLOb56BlWhxI = __p_HpyvrVO1aAKLOb56BlWhxI;
                    this.__p_I8idI8zhyFkMKTzmmsKVEU = __p_I8idI8zhyFkMKTzmmsKVEU;
                    this.__p_IRxR4inpEPwL7LXSxH1sqF = __p_IRxR4inpEPwL7LXSxH1sqF;
                    this.__p_Fh1Crphg5XhQTfEjoG2naF = __p_Fh1Crphg5XhQTfEjoG2naF;
                    this.__p_NaD60wKKkivME1dblxtGa1 = __p_NaD60wKKkivME1dblxtGa1;
                    this.__p_UpUlSxZyjUKLfTcMiEyc64 = __p_UpUlSxZyjUKLfTcMiEyc64;
                    this.__p_BgChoZ4peyiMqDx5DTYvHE = __p_BgChoZ4peyiMqDx5DTYvHE;
                    this.__p_IAcEzBQuwu7NLXw97ojHTV = __p_IAcEzBQuwu7NLXw97ojHTV;
                    this.__p_RMvmyMX9cBNLFIszreIXwt = __p_RMvmyMX9cBNLFIszreIXwt;
                    this.__p_AWpRcsszxWBMHzEnWLiB7Q = __p_AWpRcsszxWBMHzEnWLiB7Q;
                    this.__p_M9TAFSD4oNUOYMx6LkTrMB = __p_M9TAFSD4oNUOYMx6LkTrMB;
                    this.__p_GAhGAgUlRo3Lci0HDWAVK4 = __p_GAhGAgUlRo3Lci0HDWAVK4;
                    this.__p_Kw1noU4j1U4NUMvwr5OFdn = __p_Kw1noU4j1U4NUMvwr5OFdn;
                    this.__p_Uy8ScJ1hrSUPxcn1TzdKrL = __p_Uy8ScJ1hrSUPxcn1TzdKrL;
                    this.__p_QqKLzh9IY6vNAh3QnjZT6u = __p_QqKLzh9IY6vNAh3QnjZT6u;
                    this.__p_N8OfgewbBSFMNUBg6uwDCR = __p_N8OfgewbBSFMNUBg6uwDCR;
                    this.__p_NuoA9XaToNWNGtUF7YHBvK = __p_NuoA9XaToNWNGtUF7YHBvK;
                    this.__pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV = __pin_group_Input_In_ECHZLzL86j3M7kKcXQzvpV;
                    this.__pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU = __pin_group_Input_In_I8idI8zhyFkMKTzmmsKVEU;
                    this.__pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF = __pin_group_Input_In_IRxR4inpEPwL7LXSxH1sqF;
                    this.__pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK = __pin_group_Parameters_In_NuoA9XaToNWNGtUF7YHBvK;
                    this.__pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT = __pin_group_Input_In_FaDcDMkkNXoN6jIR7zzLLT;
                    this.__pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz = __pin_group_Input_In_KcPESxwLLIfQOSCqFHNTYz;
                    this.__pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4 = __pin_group_Arguments_In_EtR4UpnBHQBL8vedVT1rC4;
                    this.__pin_group_Input_In_NaD60wKKkivME1dblxtGa1 = __pin_group_Input_In_NaD60wKKkivME1dblxtGa1;
                    this.__pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV = __pin_group_Input_In_IAcEzBQuwu7NLXw97ojHTV;
                    this.__pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn = __pin_group_Input_In_Kw1noU4j1U4NUMvwr5OFdn;
                    this.__pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE = __pin_group_Input_In_BgChoZ4peyiMqDx5DTYvHE;
                    this.__pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4 = __pin_group_Input_In_GAhGAgUlRo3Lci0HDWAVK4;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 318600U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "R2XNajYvBjnNOs5M8Fn7H4", Name = "FBM_R2XNajYvBjnNOs5M8Fn7H4")]
    [n3.SerializableAttribute]
    public class FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T> : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T> Create(n2.NodeContext Node_Context)
        {
            var instance = new FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T>(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T> CreateDefault()
        {
            var instance = new FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T>(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T> Update<AdM>(n6.GpuValue<T2> Input_In, n6.GpuValue<T> TDomain_In, [n5.SerializedDefaultValueAttribute("0.5", false)] n6.GpuValue<float> Gain_In, [n5.SerializedDefaultValueAttribute("2", false)] n6.GpuValue<float> Lacunarity_In, [n5.SerializedDefaultValueAttribute("5", false)] n6.GpuValue<float> Octaves_In, n7.FBMBasisType FBM_Type_In, out n6.GpuValue<T2> Output_Out)
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.GpuValue<T2>>
        {
            var w_0 = default(AdM);
            n31.Subject<bool> __auto_1 = this.Output;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_N6y5WHQop9ELTNDz19MP41;
            if (manager_4 is null)
            {
                manager_4 = new n9.Manager<n3.ValueTuple<n6.GpuValue<T2>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n7.FBMBasisType>, n3.ValueTuple<n6.GpuValue<T2>>>(n3.ValueTuple.Create(default(n6.GpuValue<T2>)));
            }

            var inputs_5 = (Input_In, TDomain_In, Gain_In, Lacunarity_In, Octaves_In, FBM_Type_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n2.CompilationHelper.Restore<__IkBkIVDdaVcLbWcaeoIpQt>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __IkBkIVDdaVcLbWcaeoIpQt(__GetContext__(), n2.VLObject.NewIdentity())
                    {__pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS = n16._Operations_.CreateDefault<n6.GpuValue<T2>>()};
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "HujsSKORjVILYhKooANoqu", 318636U);
                    var Output_10 = n14.AddFBM_RV7KOk6ScLcObloqv9Zuyx<T, T2>.Create(Node_Context: Node_Context_9);
                    state_8.__p_HujsSKORjVILYhKooANoqu = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "ILmkTOcP0yQPW4USzEhSg9", 318648U);
                    var Output_12 = n14.MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T, T2>.Create(Node_Context: Node_Context_11);
                    state_8.__p_ILmkTOcP0yQPW4USzEhSg9 = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "O9epuejJiGiLa938qKoZqB", 318660U);
                    var Output_14 = n14.HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T, T2>.Create(Node_Context: Node_Context_13);
                    state_8.__p_O9epuejJiGiLa938qKoZqB = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "NzIBMw7IagzP6tA6mDvSbs", 318675U);
                    var Output_16 = n14.HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T, T2>.Create(Node_Context: Node_Context_15);
                    state_8.__p_NzIBMw7IagzP6tA6mDvSbs = Output_16;
                }

                int Index_17 = (int)FBM_Type_In;
                float Gain_Default_18 = 0.5F;
                float Lacunarity_Default_19 = 2F;
                float Octaves_Default_20 = 1F;
                var State_Output_22 = state_8.__p_HujsSKORjVILYhKooANoqu.Update(Input_In: TDomain_In, Gain_In: Gain_In, Gain_Default_In: Gain_Default_18, Lacunarity_In: Lacunarity_In, Lacunarity_Default_In: Lacunarity_Default_19, Octaves_In: Octaves_In, Octaves_Default_In: Octaves_Default_20, Noise_In: Input_In, Output_Out: out n6.GpuValue<T2> Output_21);
                float Gain_Default_23 = 0.35F;
                float Lacunarity_Default_24 = 2F;
                float Octaves_Default_25 = 5F;
                var State_Output_27 = state_8.__p_ILmkTOcP0yQPW4USzEhSg9.Update(Input_In: TDomain_In, Gain_In: Gain_In, Gain_Default_In: Gain_Default_23, Lacunarity_In: Lacunarity_In, Lacunarity_Default_In: Lacunarity_Default_24, Octaves_In: Octaves_In, Octaves_Default_In: Octaves_Default_25, Noise_In: Input_In, Output_Out: out n6.GpuValue<T2> Output_26);
                float Gain_Default_28 = 0.95F;
                float Lacunarity_Default_29 = 2F;
                float Octaves_Default_30 = 5F;
                var State_Output_32 = state_8.__p_O9epuejJiGiLa938qKoZqB.Update(Input_In: TDomain_In, Gain_In: Gain_In, Gain_Default_In: Gain_Default_28, Lacunarity_In: Lacunarity_In, Lacunarity_Default_In: Lacunarity_Default_29, Octaves_In: Octaves_In, Octaves_Default_In: Octaves_Default_30, Noise_In: Input_In, Output_Out: out n6.GpuValue<T2> Output_31);
                float Gain_Default_33 = 0.5F;
                float Lacunarity_Default_34 = 2F;
                float Octaves_Default_35 = 5F;
                var State_Output_37 = state_8.__p_NzIBMw7IagzP6tA6mDvSbs.Update(Input_In: TDomain_In, Gain_In: Gain_In, Gain_Default_In: Gain_Default_33, Lacunarity_In: Lacunarity_In, Lacunarity_Default_In: Lacunarity_Default_34, Octaves_In: Octaves_In, Octaves_Default_In: Octaves_Default_35, Noise_In: Input_In, Output_Out: out n6.GpuValue<T2> Output_36);
                var builder_38 = n5.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS, 4);
                builder_38.Add(Output_21);
                builder_38.Add(Output_26);
                builder_38.Add(Output_31);
                builder_38.Add(Output_36);
                var __pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS_39 = builder_38.Commit();
                n28._Operations_.Switch<n6.GpuValue<T2>, AdM>(Index_In: Index_17, Input_In: __pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS_39, Output_Out: out n6.GpuValue<T2> Output_40);
                n32.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_41, notAssigned: out bool Not_Assigned_42);
                bool __auto_43;
                if (Result_41)
                {
                    var Parent_Node_45 = Input_In.ParentNode;
                    var Result_46 = Parent_Node_45.Delegates();
                    n17.IEnumerable<n6.IFunctionParameter> Input_47 = (n17.IEnumerable<n6.IFunctionParameter>)Result_46;
                    n22._Operations_.Count<n6.IFunctionParameter>(Input_In: Input_47, Result_Out: out int Result_48);
                    int Input_2_49 = 1;
                    var Result_50 = Result_48 == Input_2_49;
                    var Output_51 = !Result_50;
                    __auto_43 = Output_51;
                }
                else
                {
                    __auto_43 = false;
                }

                n33._Operations_.OnNext<bool>(Input_In: __auto_1, Value_In: __auto_43, Output_Out: out n31.Subject<bool> Output_52);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_22 != state_8.__p_HujsSKORjVILYhKooANoqu || State_Output_27 != state_8.__p_ILmkTOcP0yQPW4USzEhSg9 || State_Output_32 != state_8.__p_O9epuejJiGiLa938qKoZqB || State_Output_37 != state_8.__p_NzIBMw7IagzP6tA6mDvSbs || __pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS_39 != state_8.__pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS ? new __IkBkIVDdaVcLbWcaeoIpQt(state_8)
                    {__p_HujsSKORjVILYhKooANoqu = State_Output_22, __p_ILmkTOcP0yQPW4USzEhSg9 = State_Output_27, __p_O9epuejJiGiLa938qKoZqB = State_Output_32, __p_NzIBMw7IagzP6tA6mDvSbs = State_Output_37, __pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS = __pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS_39} : state_8;
                else
                {
                    state_8.__p_HujsSKORjVILYhKooANoqu = State_Output_22;
                    state_8.__p_ILmkTOcP0yQPW4USzEhSg9 = State_Output_27;
                    state_8.__p_O9epuejJiGiLa938qKoZqB = State_Output_32;
                    state_8.__p_NzIBMw7IagzP6tA6mDvSbs = State_Output_37;
                    state_8.__pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS = __pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS_39;
                }

                outputs_6 = n3.ValueTuple.Create(Output_40);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_53 = outputs_6.Item1;
            Output_Out = __auto_53;
            n4.FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T> that_54 = this;
            if (this.__GetContext__().IsImmutable)
                that_54 = manager_4 != this.__cache_N6y5WHQop9ELTNDz19MP41 ? new FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T>(this)
                {__cache_N6y5WHQop9ELTNDz19MP41 = manager_4} : that_54;
            else
            {
                this.__cache_N6y5WHQop9ELTNDz19MP41 = manager_4;
            }

            return that_54;
        }

        public n4.FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T> __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n2.NodeContext Node_Context_0 = Node_Context.CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "H4ZEJ7fhy4rQSUaR0E8vm9", 318847U);
            n33._Operations_.Create<bool>(Node_Context: Node_Context_0, Output_Out: out n31.Subject<bool> Output_1);
            n31.Subject<bool> __auto_2 = Output_1;
            n3.IObservable<bool> WARN_3 = (n3.IObservable<bool>)__auto_2;
            n2.NodeContext Node_Context_4 = Node_Context.CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Isdd10h8MClPYKeNzaLBqz", 318840U);
            string Warning_5 = "WARNING";
            string Why_6 = "";
            string How_7 = "";
            string Ignore_8 = "";
            int Depth_9 = 9999;
            var Output_10 = n34.Warn_Reactive_C.Create(WARN_In: WARN_3, Node_Context_In: Node_Context_4, Warning_In: Warning_5, Why_In: Why_6, How_In: How_7, Ignore_In: Ignore_8, Depth_In: Depth_9);
            n4.FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T> that_11 = this;
            this.Output = Output_1;
            this.__p_Isdd10h8MClPYKeNzaLBqz = Output_10;
            this.__cache_N6y5WHQop9ELTNDz19MP41 = null;
            return that_11;
        }

        public n4.FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T> __CreateDefault__()
        {
            n4.FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T> that_0 = this;
            this.Output = default(n31.Subject<bool>);
            this.__cache_N6y5WHQop9ELTNDz19MP41 = null;
            this.__p_Isdd10h8MClPYKeNzaLBqz = n34.Warn_Reactive_C.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_N6y5WHQop9ELTNDz19MP41);
            n2.CompilationHelper.SafeDispose(this.__p_Isdd10h8MClPYKeNzaLBqz);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 318851U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "FhgTpzPZKfcMUkPQHCdiOL", Name = "Output")]
        public n31.Subject<bool> Output;
        [n2.ElementAttribute(TracingId = 318605U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "N6y5WHQop9ELTNDz19MP41", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<n6.GpuValue<T2>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n7.FBMBasisType>, n3.ValueTuple<n6.GpuValue<T2>>> __cache_N6y5WHQop9ELTNDz19MP41 = null;
        [n2.ElementAttribute(TracingId = 318840U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Isdd10h8MClPYKeNzaLBqz", Name = "Warn (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n34.Warn_Reactive_C __p_Isdd10h8MClPYKeNzaLBqz;
        public FBM_R2XNajYvBjnNOs5M8Fn7H4(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FBM_R2XNajYvBjnNOs5M8Fn7H4(FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T> other): base(other)
        {
            this.Output = other.Output;
            this.__cache_N6y5WHQop9ELTNDz19MP41 = other.__cache_N6y5WHQop9ELTNDz19MP41;
            this.__p_Isdd10h8MClPYKeNzaLBqz = other.__p_Isdd10h8MClPYKeNzaLBqz;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "Output", in Output), n2.CompilationHelper.GetValueOrExisting(values, "__cache_N6y5WHQop9ELTNDz19MP41", in __cache_N6y5WHQop9ELTNDz19MP41), n2.CompilationHelper.GetValueOrExisting(values, "__p_Isdd10h8MClPYKeNzaLBqz", in __p_Isdd10h8MClPYKeNzaLBqz));
        }

        internal FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T> __WITH__(n31.Subject<bool> Output, n9.Manager<n3.ValueTuple<n6.GpuValue<T2>, n6.GpuValue<T>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n7.FBMBasisType>, n3.ValueTuple<n6.GpuValue<T2>>> __cache_N6y5WHQop9ELTNDz19MP41, n34.Warn_Reactive_C __p_Isdd10h8MClPYKeNzaLBqz)
        {
            n4.FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Output != this.Output || __cache_N6y5WHQop9ELTNDz19MP41 != this.__cache_N6y5WHQop9ELTNDz19MP41 || __p_Isdd10h8MClPYKeNzaLBqz != this.__p_Isdd10h8MClPYKeNzaLBqz ? new FBM_R2XNajYvBjnNOs5M8Fn7H4<T2, T>(this)
                {Output = Output, __cache_N6y5WHQop9ELTNDz19MP41 = __cache_N6y5WHQop9ELTNDz19MP41, __p_Isdd10h8MClPYKeNzaLBqz = __p_Isdd10h8MClPYKeNzaLBqz} : that_0;
            else
            {
                this.Output = Output;
                this.__cache_N6y5WHQop9ELTNDz19MP41 = __cache_N6y5WHQop9ELTNDz19MP41;
                this.__p_Isdd10h8MClPYKeNzaLBqz = __p_Isdd10h8MClPYKeNzaLBqz;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "IkBkIVDdaVcLbWcaeoIpQt", Name = "__IkBkIVDdaVcLbWcaeoIpQt")]
        [n3.SerializableAttribute]
        public class __IkBkIVDdaVcLbWcaeoIpQt : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_HujsSKORjVILYhKooANoqu);
                n2.CompilationHelper.SafeDispose(this.__p_ILmkTOcP0yQPW4USzEhSg9);
                n2.CompilationHelper.SafeDispose(this.__p_O9epuejJiGiLa938qKoZqB);
                n2.CompilationHelper.SafeDispose(this.__p_NzIBMw7IagzP6tA6mDvSbs);
                return;
            }

            [n2.ElementAttribute(TracingId = 318636U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HujsSKORjVILYhKooANoqu", Name = "AddFBM", IsManaged = true, IsAutoGenerated = true)]
            public n14.AddFBM_RV7KOk6ScLcObloqv9Zuyx<T, T2> __p_HujsSKORjVILYhKooANoqu;
            [n2.ElementAttribute(TracingId = 318648U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "ILmkTOcP0yQPW4USzEhSg9", Name = "MultiFBM", IsManaged = true, IsAutoGenerated = true)]
            public n14.MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T, T2> __p_ILmkTOcP0yQPW4USzEhSg9;
            [n2.ElementAttribute(TracingId = 318660U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "O9epuejJiGiLa938qKoZqB", Name = "HybridFBM", IsManaged = true, IsAutoGenerated = true)]
            public n14.HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T, T2> __p_O9epuejJiGiLa938qKoZqB;
            [n2.ElementAttribute(TracingId = 318675U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NzIBMw7IagzP6tA6mDvSbs", Name = "HeteroFBM", IsManaged = true, IsAutoGenerated = true)]
            public n14.HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T, T2> __p_NzIBMw7IagzP6tA6mDvSbs;
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<T2>> __pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS = default(n15.Spread<n6.GpuValue<T2>>);
            public __IkBkIVDdaVcLbWcaeoIpQt(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __IkBkIVDdaVcLbWcaeoIpQt(__IkBkIVDdaVcLbWcaeoIpQt other): base(other)
            {
                this.__p_HujsSKORjVILYhKooANoqu = other.__p_HujsSKORjVILYhKooANoqu;
                this.__p_ILmkTOcP0yQPW4USzEhSg9 = other.__p_ILmkTOcP0yQPW4USzEhSg9;
                this.__p_O9epuejJiGiLa938qKoZqB = other.__p_O9epuejJiGiLa938qKoZqB;
                this.__p_NzIBMw7IagzP6tA6mDvSbs = other.__p_NzIBMw7IagzP6tA6mDvSbs;
                this.__pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS = other.__pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_HujsSKORjVILYhKooANoqu", in __p_HujsSKORjVILYhKooANoqu), n2.CompilationHelper.GetValueOrExisting(values, "__p_ILmkTOcP0yQPW4USzEhSg9", in __p_ILmkTOcP0yQPW4USzEhSg9), n2.CompilationHelper.GetValueOrExisting(values, "__p_O9epuejJiGiLa938qKoZqB", in __p_O9epuejJiGiLa938qKoZqB), n2.CompilationHelper.GetValueOrExisting(values, "__p_NzIBMw7IagzP6tA6mDvSbs", in __p_NzIBMw7IagzP6tA6mDvSbs), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS", in __pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS));
            }

            internal __IkBkIVDdaVcLbWcaeoIpQt __WITH__(n14.AddFBM_RV7KOk6ScLcObloqv9Zuyx<T, T2> __p_HujsSKORjVILYhKooANoqu, n14.MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T, T2> __p_ILmkTOcP0yQPW4USzEhSg9, n14.HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T, T2> __p_O9epuejJiGiLa938qKoZqB, n14.HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T, T2> __p_NzIBMw7IagzP6tA6mDvSbs, n15.Spread<n6.GpuValue<T2>> __pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS)
            {
                __IkBkIVDdaVcLbWcaeoIpQt that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_HujsSKORjVILYhKooANoqu != this.__p_HujsSKORjVILYhKooANoqu || __p_ILmkTOcP0yQPW4USzEhSg9 != this.__p_ILmkTOcP0yQPW4USzEhSg9 || __p_O9epuejJiGiLa938qKoZqB != this.__p_O9epuejJiGiLa938qKoZqB || __p_NzIBMw7IagzP6tA6mDvSbs != this.__p_NzIBMw7IagzP6tA6mDvSbs || __pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS != this.__pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS ? new __IkBkIVDdaVcLbWcaeoIpQt(this)
                    {__p_HujsSKORjVILYhKooANoqu = __p_HujsSKORjVILYhKooANoqu, __p_ILmkTOcP0yQPW4USzEhSg9 = __p_ILmkTOcP0yQPW4USzEhSg9, __p_O9epuejJiGiLa938qKoZqB = __p_O9epuejJiGiLa938qKoZqB, __p_NzIBMw7IagzP6tA6mDvSbs = __p_NzIBMw7IagzP6tA6mDvSbs, __pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS = __pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS} : that_0;
                else
                {
                    this.__p_HujsSKORjVILYhKooANoqu = __p_HujsSKORjVILYhKooANoqu;
                    this.__p_ILmkTOcP0yQPW4USzEhSg9 = __p_ILmkTOcP0yQPW4USzEhSg9;
                    this.__p_O9epuejJiGiLa938qKoZqB = __p_O9epuejJiGiLa938qKoZqB;
                    this.__p_NzIBMw7IagzP6tA6mDvSbs = __p_NzIBMw7IagzP6tA6mDvSbs;
                    this.__pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS = __pin_group_Input_In_JX7T04bIvGrNlSwTjOuvBS;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 320249U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Aws8DaD8VhiLll3JX3qEHm", Name = "Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm")]
    [n3.SerializableAttribute]
    public class Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm Create(n2.NodeContext Node_Context)
        {
            var instance = new Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm CreateDefault()
        {
            var instance = new Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm Update(n6.GpuValue<n29.Vector2> TDomain_In, n6.GpuValue<float> Time_In, [n5.SerializedDefaultValueAttribute("2, 2", false)] n6.GpuValue<n29.Vector2> Frequency_In, [n5.SerializedDefaultValueAttribute("1", false)] n6.GpuValue<float> Amplitude_In, [n5.SerializedDefaultValueAttribute("0, 0", false)] n6.GpuValue<n29.Vector2> Offset_In, [n5.SerializedDefaultValueAttribute("0", false)] n6.GpuValue<float> Center_In, [n5.SerializedDefaultValueAttribute("0.5", false)] n6.GpuValue<float> Bias_In, n7.NoiseBasisInflection Inflection_In, [n5.SerializedDefaultValueAttribute("GradientNoise", false)] n8.NoiseType Noise_Type_In, out n6.GpuValue<float> Output_Out)
        {
            bool __pad_BziPdInElbcMZj9AkKRhwN_0 = __slot_BziPdInElbcMZj9AkKRhwN;
            n32.ObjectHelpers.IsAssigned(x: Time_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_O9PnS6dotRlPCpwqHmjT0S;
            if (manager_4 is null)
            {
                manager_4 = new n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<float>>>(n3.ValueTuple.Create(default(n6.GpuValue<float>)));
            }

            var inputs_5 = (Result_1, TDomain_In, Time_In, Frequency_In, Amplitude_In, Offset_In, Center_In, Bias_In, Inflection_In, Noise_Type_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = __pad_BziPdInElbcMZj9AkKRhwN_0 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n2.CompilationHelper.Restore<__LqvhVyl3gHBMzf2QEyToNO>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __LqvhVyl3gHBMzf2QEyToNO(__GetContext__(), n2.VLObject.NewIdentity())
                    {__slot_KdazVx16DdZOtDv6ATPyOs = default(n6.GpuValue<n29.Vector2>), __slot_RLG7SEp77NBLS2yxphAMkn = default(n6.GpuValue<n29.Vector3>)};
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "GdEQiP2wTB6QOSCSmVPl0n", 320287U);
                    var Output_10 = n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector2, float>.Create(Node_Context: Node_Context_9);
                    state_8.__p_GdEQiP2wTB6QOSCSmVPl0n = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "IGwqaFeU8FBNuVTa5rx5GI", 320308U);
                    var Output_12 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector2>.Create(Node_Context: Node_Context_11);
                    state_8.__p_IGwqaFeU8FBNuVTa5rx5GI = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "KJG5NAQlbNgOyLyk3xE0T7", 320314U);
                    var Output_14 = n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr.Create(Node_Context: Node_Context_13);
                    state_8.__p_KJG5NAQlbNgOyLyk3xE0T7 = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "BkPTe9xDcrcO4l9zJf5729", 320329U);
                    var Output_16 = n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector3, float>.Create(Node_Context: Node_Context_15);
                    state_8.__p_BkPTe9xDcrcO4l9zJf5729 = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "RvReHqrRDXCLtDdtCyyDDu", 320350U);
                    var Output_18 = n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr.Create(Node_Context: Node_Context_17);
                    state_8.__p_RvReHqrRDXCLtDdtCyyDDu = Output_18;
                    n2.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "FqeizimU6dSMRNXkHNgHpV", 320373U);
                    var Output_20 = n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr.Create(Node_Context: Node_Context_19);
                    state_8.__p_FqeizimU6dSMRNXkHNgHpV = Output_20;
                    n2.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "F6uQan0typdQTkiVcCLhC6", 320386U);
                    var Output_22 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_21);
                    state_8.__p_F6uQan0typdQTkiVcCLhC6 = Output_22;
                    n2.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "DPqpAC6xUflPLYWpVUZsZH", 320405U);
                    var Output_24 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_23);
                    state_8.__p_DPqpAC6xUflPLYWpVUZsZH = Output_24;
                    n2.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "TLlm9f4R0AkOo3nKAfja3g", 320425U);
                    var Output_26 = n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<n29.Vector2>.Create(Node_Context: Node_Context_25);
                    state_8.__p_TLlm9f4R0AkOo3nKAfja3g = Output_26;
                    n36._Operations_.Noise2DScalarID(Output_Out: out string Output_27);
                    n2.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "FZFhBxlVO0uMRr3OInQeME", 320441U);
                    var Output_29 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_28, ID_In: Output_27);
                    state_8.__p_FZFhBxlVO0uMRr3OInQeME = Output_29;
                }

                float __pad_TswWmBX96OSPgnxSyYhAbC_30 = __slot_TswWmBX96OSPgnxSyYhAbC;
                float __pad_HsbimpKRe7OQNn5PS8IPW9_31 = __slot_HsbimpKRe7OQNn5PS8IPW9;
                int Id_32 = 0;
                var State_Output_34 = state_8.__p_IGwqaFeU8FBNuVTa5rx5GI.Update(The_Override_In: TDomain_In, Id_In: Id_32, Output_Out: out n6.GpuValue<n29.Vector2> Output_33);
                n6.GpuValue<n29.Vector2> __pad_KdazVx16DdZOtDv6ATPyOs_35 = Output_33;
                n6.GpuValue<float> default_36 = default(n6.GpuValue<float>);
                var State_Output_38 = state_8.__p_GdEQiP2wTB6QOSCSmVPl0n.Update<n27.__AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW>(TDomain_In: __pad_KdazVx16DdZOtDv6ATPyOs_35, Frequency_In: Frequency_In, Amplitude_In: Amplitude_In, Offset_In: Offset_In, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: Inflection_In, Noise_Type_In: Noise_Type_In, default_In: default_36, Output_Out: out n6.GpuValue<float> Output_37);
                var State_Output_40 = state_8.__p_KJG5NAQlbNgOyLyk3xE0T7.Update(xy_In: Output_33, z_In: Time_In, Output_Out: out n6.GpuValue<n29.Vector3> Output_39);
                n6.GpuValue<n29.Vector3> __pad_RLG7SEp77NBLS2yxphAMkn_41 = Output_39;
                float The_Value_42 = 1F;
                var State_Output_44 = state_8.__p_TLlm9f4R0AkOo3nKAfja3g.Update(GpuValue_In: Frequency_In, The_Value_In: The_Value_42, Output_Out: out n6.GpuValue<n29.Vector2> Output_43);
                var Output_46 = state_8.__p_F6uQan0typdQTkiVcCLhC6.Update(Value_In: __pad_TswWmBX96OSPgnxSyYhAbC_30, GpuValue_Out: out n6.GpuValue<float> GpuValue_45);
                var State_Output_48 = state_8.__p_FqeizimU6dSMRNXkHNgHpV.Update(xy_In: Output_43, z_In: GpuValue_45, Output_Out: out n6.GpuValue<n29.Vector3> Output_47);
                var Output_50 = state_8.__p_DPqpAC6xUflPLYWpVUZsZH.Update(Value_In: __pad_HsbimpKRe7OQNn5PS8IPW9_31, GpuValue_Out: out n6.GpuValue<float> GpuValue_49);
                var State_Output_52 = state_8.__p_RvReHqrRDXCLtDdtCyyDDu.Update(xy_In: Offset_In, z_In: GpuValue_49, Output_Out: out n6.GpuValue<n29.Vector3> Output_51);
                n6.GpuValue<float> default_53 = default(n6.GpuValue<float>);
                var State_Output_55 = state_8.__p_BkPTe9xDcrcO4l9zJf5729.Update<n27.__AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW>(TDomain_In: __pad_RLG7SEp77NBLS2yxphAMkn_41, Frequency_In: Output_47, Amplitude_In: Amplitude_In, Offset_In: Output_51, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: Inflection_In, Noise_Type_In: Noise_Type_In, default_In: default_53, Output_Out: out n6.GpuValue<float> Output_54);
                n37._Operations_.Switch_Boolean<n6.GpuValue<float>>(Condition_In: Result_1, Input_In: Output_37, Input_2_In: Output_54, Output_Out: out n6.GpuValue<float> Output_56);
                bool Update_57 = true;
                var Output_58 = state_8.__p_FZFhBxlVO0uMRr3OInQeME;
                if (Update_57)
                {
                    Output_58 = state_8.__p_FZFhBxlVO0uMRr3OInQeME.Update(Input_In: Output_56);
                }

                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_34 != state_8.__p_IGwqaFeU8FBNuVTa5rx5GI || Output_33 != state_8.__slot_KdazVx16DdZOtDv6ATPyOs || State_Output_38 != state_8.__p_GdEQiP2wTB6QOSCSmVPl0n || State_Output_40 != state_8.__p_KJG5NAQlbNgOyLyk3xE0T7 || Output_39 != state_8.__slot_RLG7SEp77NBLS2yxphAMkn || State_Output_44 != state_8.__p_TLlm9f4R0AkOo3nKAfja3g || Output_46 != state_8.__p_F6uQan0typdQTkiVcCLhC6 || State_Output_48 != state_8.__p_FqeizimU6dSMRNXkHNgHpV || Output_50 != state_8.__p_DPqpAC6xUflPLYWpVUZsZH || State_Output_52 != state_8.__p_RvReHqrRDXCLtDdtCyyDDu || State_Output_55 != state_8.__p_BkPTe9xDcrcO4l9zJf5729 || Output_58 != state_8.__p_FZFhBxlVO0uMRr3OInQeME ? new __LqvhVyl3gHBMzf2QEyToNO(state_8)
                    {__p_IGwqaFeU8FBNuVTa5rx5GI = State_Output_34, __slot_KdazVx16DdZOtDv6ATPyOs = Output_33, __p_GdEQiP2wTB6QOSCSmVPl0n = State_Output_38, __p_KJG5NAQlbNgOyLyk3xE0T7 = State_Output_40, __slot_RLG7SEp77NBLS2yxphAMkn = Output_39, __p_TLlm9f4R0AkOo3nKAfja3g = State_Output_44, __p_F6uQan0typdQTkiVcCLhC6 = Output_46, __p_FqeizimU6dSMRNXkHNgHpV = State_Output_48, __p_DPqpAC6xUflPLYWpVUZsZH = Output_50, __p_RvReHqrRDXCLtDdtCyyDDu = State_Output_52, __p_BkPTe9xDcrcO4l9zJf5729 = State_Output_55, __p_FZFhBxlVO0uMRr3OInQeME = Output_58} : state_8;
                else
                {
                    state_8.__p_IGwqaFeU8FBNuVTa5rx5GI = State_Output_34;
                    state_8.__slot_KdazVx16DdZOtDv6ATPyOs = Output_33;
                    state_8.__p_GdEQiP2wTB6QOSCSmVPl0n = State_Output_38;
                    state_8.__p_KJG5NAQlbNgOyLyk3xE0T7 = State_Output_40;
                    state_8.__slot_RLG7SEp77NBLS2yxphAMkn = Output_39;
                    state_8.__p_TLlm9f4R0AkOo3nKAfja3g = State_Output_44;
                    state_8.__p_F6uQan0typdQTkiVcCLhC6 = Output_46;
                    state_8.__p_FqeizimU6dSMRNXkHNgHpV = State_Output_48;
                    state_8.__p_DPqpAC6xUflPLYWpVUZsZH = Output_50;
                    state_8.__p_RvReHqrRDXCLtDdtCyyDDu = State_Output_52;
                    state_8.__p_BkPTe9xDcrcO4l9zJf5729 = State_Output_55;
                    state_8.__p_FZFhBxlVO0uMRr3OInQeME = Output_58;
                }

                outputs_6 = n3.ValueTuple.Create(Output_56);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_59 = outputs_6.Item1;
            Output_Out = __auto_59;
            n4.Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm that_60 = this;
            if (this.__GetContext__().IsImmutable)
                that_60 = manager_4 != this.__cache_O9PnS6dotRlPCpwqHmjT0S ? new Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm(this)
                {__cache_O9PnS6dotRlPCpwqHmjT0S = manager_4} : that_60;
            else
            {
                this.__cache_O9PnS6dotRlPCpwqHmjT0S = manager_4;
            }

            return that_60;
        }

        public n4.Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm that_0 = this;
            this.__cache_O9PnS6dotRlPCpwqHmjT0S = null;
            return that_0;
        }

        public n4.Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm __CreateDefault__()
        {
            n4.Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm that_0 = this;
            this.__cache_O9PnS6dotRlPCpwqHmjT0S = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_O9PnS6dotRlPCpwqHmjT0S);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 320476U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BziPdInElbcMZj9AkKRhwN", Name = "__slot_BziPdInElbcMZj9AkKRhwN")]
        public static bool __slot_BziPdInElbcMZj9AkKRhwN = false;
        [n2.ElementAttribute(TracingId = 320255U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "O9PnS6dotRlPCpwqHmjT0S", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<float>>> __cache_O9PnS6dotRlPCpwqHmjT0S = null;
        [n2.ElementAttribute(TracingId = 320399U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "TswWmBX96OSPgnxSyYhAbC", Name = "__slot_TswWmBX96OSPgnxSyYhAbC")]
        public static float __slot_TswWmBX96OSPgnxSyYhAbC = 1F;
        [n2.ElementAttribute(TracingId = 320418U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HsbimpKRe7OQNn5PS8IPW9", Name = "__slot_HsbimpKRe7OQNn5PS8IPW9")]
        public static float __slot_HsbimpKRe7OQNn5PS8IPW9 = 0F;
        static Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm()
        {
        }

        public Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm(Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm other): base(other)
        {
            this.__cache_O9PnS6dotRlPCpwqHmjT0S = other.__cache_O9PnS6dotRlPCpwqHmjT0S;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_O9PnS6dotRlPCpwqHmjT0S", in __cache_O9PnS6dotRlPCpwqHmjT0S));
        }

        internal Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm __WITH__(n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<float>>> __cache_O9PnS6dotRlPCpwqHmjT0S)
        {
            n4.Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_O9PnS6dotRlPCpwqHmjT0S != this.__cache_O9PnS6dotRlPCpwqHmjT0S ? new Noise__2D_Scalar_Aws8DaD8VhiLll3JX3qEHm(this)
                {__cache_O9PnS6dotRlPCpwqHmjT0S = __cache_O9PnS6dotRlPCpwqHmjT0S} : that_0;
            else
            {
                this.__cache_O9PnS6dotRlPCpwqHmjT0S = __cache_O9PnS6dotRlPCpwqHmjT0S;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LqvhVyl3gHBMzf2QEyToNO", Name = "__LqvhVyl3gHBMzf2QEyToNO")]
        [n3.SerializableAttribute]
        public class __LqvhVyl3gHBMzf2QEyToNO : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_GdEQiP2wTB6QOSCSmVPl0n);
                n2.CompilationHelper.SafeDispose(this.__p_IGwqaFeU8FBNuVTa5rx5GI);
                n2.CompilationHelper.SafeDispose(this.__p_KJG5NAQlbNgOyLyk3xE0T7);
                n2.CompilationHelper.SafeDispose(this.__p_BkPTe9xDcrcO4l9zJf5729);
                n2.CompilationHelper.SafeDispose(this.__p_RvReHqrRDXCLtDdtCyyDDu);
                n2.CompilationHelper.SafeDispose(this.__p_FqeizimU6dSMRNXkHNgHpV);
                n2.CompilationHelper.SafeDispose(this.__p_F6uQan0typdQTkiVcCLhC6);
                n2.CompilationHelper.SafeDispose(this.__p_DPqpAC6xUflPLYWpVUZsZH);
                n2.CompilationHelper.SafeDispose(this.__p_TLlm9f4R0AkOo3nKAfja3g);
                n2.CompilationHelper.SafeDispose(this.__p_FZFhBxlVO0uMRr3OInQeME);
                return;
            }

            [n2.ElementAttribute(TracingId = 320287U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "GdEQiP2wTB6QOSCSmVPl0n", Name = "Noise", IsManaged = true, IsAutoGenerated = true)]
            public n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector2, float> __p_GdEQiP2wTB6QOSCSmVPl0n;
            [n2.ElementAttribute(TracingId = 320308U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "IGwqaFeU8FBNuVTa5rx5GI", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector2> __p_IGwqaFeU8FBNuVTa5rx5GI;
            [n2.ElementAttribute(TracingId = 320314U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "KJG5NAQlbNgOyLyk3xE0T7", Name = "xy+z (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_KJG5NAQlbNgOyLyk3xE0T7;
            [n2.ElementAttribute(TracingId = 320329U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BkPTe9xDcrcO4l9zJf5729", Name = "Noise", IsManaged = true, IsAutoGenerated = true)]
            public n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector3, float> __p_BkPTe9xDcrcO4l9zJf5729;
            [n2.ElementAttribute(TracingId = 320350U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RvReHqrRDXCLtDdtCyyDDu", Name = "xy+z (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_RvReHqrRDXCLtDdtCyyDDu;
            [n2.ElementAttribute(TracingId = 320373U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "FqeizimU6dSMRNXkHNgHpV", Name = "xy+z (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_FqeizimU6dSMRNXkHNgHpV;
            [n2.ElementAttribute(TracingId = 320386U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "F6uQan0typdQTkiVcCLhC6", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_F6uQan0typdQTkiVcCLhC6;
            [n2.ElementAttribute(TracingId = 320405U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "DPqpAC6xUflPLYWpVUZsZH", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_DPqpAC6xUflPLYWpVUZsZH;
            [n2.ElementAttribute(TracingId = 320425U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "TLlm9f4R0AkOo3nKAfja3g", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<n29.Vector2> __p_TLlm9f4R0AkOo3nKAfja3g;
            [n2.ElementAttribute(TracingId = 320441U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "FZFhBxlVO0uMRr3OInQeME", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_FZFhBxlVO0uMRr3OInQeME;
            [n2.ElementAttribute(TracingId = 320324U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "KdazVx16DdZOtDv6ATPyOs", Name = "__slot_KdazVx16DdZOtDv6ATPyOs")]
            public n6.GpuValue<n29.Vector2> __slot_KdazVx16DdZOtDv6ATPyOs;
            [n2.ElementAttribute(TracingId = 320327U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RLG7SEp77NBLS2yxphAMkn", Name = "__slot_RLG7SEp77NBLS2yxphAMkn")]
            public n6.GpuValue<n29.Vector3> __slot_RLG7SEp77NBLS2yxphAMkn;
            public __LqvhVyl3gHBMzf2QEyToNO(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __LqvhVyl3gHBMzf2QEyToNO(__LqvhVyl3gHBMzf2QEyToNO other): base(other)
            {
                this.__p_GdEQiP2wTB6QOSCSmVPl0n = other.__p_GdEQiP2wTB6QOSCSmVPl0n;
                this.__p_IGwqaFeU8FBNuVTa5rx5GI = other.__p_IGwqaFeU8FBNuVTa5rx5GI;
                this.__p_KJG5NAQlbNgOyLyk3xE0T7 = other.__p_KJG5NAQlbNgOyLyk3xE0T7;
                this.__p_BkPTe9xDcrcO4l9zJf5729 = other.__p_BkPTe9xDcrcO4l9zJf5729;
                this.__p_RvReHqrRDXCLtDdtCyyDDu = other.__p_RvReHqrRDXCLtDdtCyyDDu;
                this.__p_FqeizimU6dSMRNXkHNgHpV = other.__p_FqeizimU6dSMRNXkHNgHpV;
                this.__p_F6uQan0typdQTkiVcCLhC6 = other.__p_F6uQan0typdQTkiVcCLhC6;
                this.__p_DPqpAC6xUflPLYWpVUZsZH = other.__p_DPqpAC6xUflPLYWpVUZsZH;
                this.__p_TLlm9f4R0AkOo3nKAfja3g = other.__p_TLlm9f4R0AkOo3nKAfja3g;
                this.__p_FZFhBxlVO0uMRr3OInQeME = other.__p_FZFhBxlVO0uMRr3OInQeME;
                this.__slot_KdazVx16DdZOtDv6ATPyOs = other.__slot_KdazVx16DdZOtDv6ATPyOs;
                this.__slot_RLG7SEp77NBLS2yxphAMkn = other.__slot_RLG7SEp77NBLS2yxphAMkn;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_GdEQiP2wTB6QOSCSmVPl0n", in __p_GdEQiP2wTB6QOSCSmVPl0n), n2.CompilationHelper.GetValueOrExisting(values, "__p_IGwqaFeU8FBNuVTa5rx5GI", in __p_IGwqaFeU8FBNuVTa5rx5GI), n2.CompilationHelper.GetValueOrExisting(values, "__p_KJG5NAQlbNgOyLyk3xE0T7", in __p_KJG5NAQlbNgOyLyk3xE0T7), n2.CompilationHelper.GetValueOrExisting(values, "__p_BkPTe9xDcrcO4l9zJf5729", in __p_BkPTe9xDcrcO4l9zJf5729), n2.CompilationHelper.GetValueOrExisting(values, "__p_RvReHqrRDXCLtDdtCyyDDu", in __p_RvReHqrRDXCLtDdtCyyDDu), n2.CompilationHelper.GetValueOrExisting(values, "__p_FqeizimU6dSMRNXkHNgHpV", in __p_FqeizimU6dSMRNXkHNgHpV), n2.CompilationHelper.GetValueOrExisting(values, "__p_F6uQan0typdQTkiVcCLhC6", in __p_F6uQan0typdQTkiVcCLhC6), n2.CompilationHelper.GetValueOrExisting(values, "__p_DPqpAC6xUflPLYWpVUZsZH", in __p_DPqpAC6xUflPLYWpVUZsZH), n2.CompilationHelper.GetValueOrExisting(values, "__p_TLlm9f4R0AkOo3nKAfja3g", in __p_TLlm9f4R0AkOo3nKAfja3g), n2.CompilationHelper.GetValueOrExisting(values, "__p_FZFhBxlVO0uMRr3OInQeME", in __p_FZFhBxlVO0uMRr3OInQeME), n2.CompilationHelper.GetValueOrExisting(values, "__slot_KdazVx16DdZOtDv6ATPyOs", in __slot_KdazVx16DdZOtDv6ATPyOs), n2.CompilationHelper.GetValueOrExisting(values, "__slot_RLG7SEp77NBLS2yxphAMkn", in __slot_RLG7SEp77NBLS2yxphAMkn));
            }

            internal __LqvhVyl3gHBMzf2QEyToNO __WITH__(n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector2, float> __p_GdEQiP2wTB6QOSCSmVPl0n, n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector2> __p_IGwqaFeU8FBNuVTa5rx5GI, n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_KJG5NAQlbNgOyLyk3xE0T7, n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector3, float> __p_BkPTe9xDcrcO4l9zJf5729, n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_RvReHqrRDXCLtDdtCyyDDu, n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_FqeizimU6dSMRNXkHNgHpV, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_F6uQan0typdQTkiVcCLhC6, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_DPqpAC6xUflPLYWpVUZsZH, n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<n29.Vector2> __p_TLlm9f4R0AkOo3nKAfja3g, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_FZFhBxlVO0uMRr3OInQeME, n6.GpuValue<n29.Vector2> __slot_KdazVx16DdZOtDv6ATPyOs, n6.GpuValue<n29.Vector3> __slot_RLG7SEp77NBLS2yxphAMkn)
            {
                __LqvhVyl3gHBMzf2QEyToNO that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_GdEQiP2wTB6QOSCSmVPl0n != this.__p_GdEQiP2wTB6QOSCSmVPl0n || __p_IGwqaFeU8FBNuVTa5rx5GI != this.__p_IGwqaFeU8FBNuVTa5rx5GI || __p_KJG5NAQlbNgOyLyk3xE0T7 != this.__p_KJG5NAQlbNgOyLyk3xE0T7 || __p_BkPTe9xDcrcO4l9zJf5729 != this.__p_BkPTe9xDcrcO4l9zJf5729 || __p_RvReHqrRDXCLtDdtCyyDDu != this.__p_RvReHqrRDXCLtDdtCyyDDu || __p_FqeizimU6dSMRNXkHNgHpV != this.__p_FqeizimU6dSMRNXkHNgHpV || __p_F6uQan0typdQTkiVcCLhC6 != this.__p_F6uQan0typdQTkiVcCLhC6 || __p_DPqpAC6xUflPLYWpVUZsZH != this.__p_DPqpAC6xUflPLYWpVUZsZH || __p_TLlm9f4R0AkOo3nKAfja3g != this.__p_TLlm9f4R0AkOo3nKAfja3g || __p_FZFhBxlVO0uMRr3OInQeME != this.__p_FZFhBxlVO0uMRr3OInQeME || __slot_KdazVx16DdZOtDv6ATPyOs != this.__slot_KdazVx16DdZOtDv6ATPyOs || __slot_RLG7SEp77NBLS2yxphAMkn != this.__slot_RLG7SEp77NBLS2yxphAMkn ? new __LqvhVyl3gHBMzf2QEyToNO(this)
                    {__p_GdEQiP2wTB6QOSCSmVPl0n = __p_GdEQiP2wTB6QOSCSmVPl0n, __p_IGwqaFeU8FBNuVTa5rx5GI = __p_IGwqaFeU8FBNuVTa5rx5GI, __p_KJG5NAQlbNgOyLyk3xE0T7 = __p_KJG5NAQlbNgOyLyk3xE0T7, __p_BkPTe9xDcrcO4l9zJf5729 = __p_BkPTe9xDcrcO4l9zJf5729, __p_RvReHqrRDXCLtDdtCyyDDu = __p_RvReHqrRDXCLtDdtCyyDDu, __p_FqeizimU6dSMRNXkHNgHpV = __p_FqeizimU6dSMRNXkHNgHpV, __p_F6uQan0typdQTkiVcCLhC6 = __p_F6uQan0typdQTkiVcCLhC6, __p_DPqpAC6xUflPLYWpVUZsZH = __p_DPqpAC6xUflPLYWpVUZsZH, __p_TLlm9f4R0AkOo3nKAfja3g = __p_TLlm9f4R0AkOo3nKAfja3g, __p_FZFhBxlVO0uMRr3OInQeME = __p_FZFhBxlVO0uMRr3OInQeME, __slot_KdazVx16DdZOtDv6ATPyOs = __slot_KdazVx16DdZOtDv6ATPyOs, __slot_RLG7SEp77NBLS2yxphAMkn = __slot_RLG7SEp77NBLS2yxphAMkn} : that_0;
                else
                {
                    this.__p_GdEQiP2wTB6QOSCSmVPl0n = __p_GdEQiP2wTB6QOSCSmVPl0n;
                    this.__p_IGwqaFeU8FBNuVTa5rx5GI = __p_IGwqaFeU8FBNuVTa5rx5GI;
                    this.__p_KJG5NAQlbNgOyLyk3xE0T7 = __p_KJG5NAQlbNgOyLyk3xE0T7;
                    this.__p_BkPTe9xDcrcO4l9zJf5729 = __p_BkPTe9xDcrcO4l9zJf5729;
                    this.__p_RvReHqrRDXCLtDdtCyyDDu = __p_RvReHqrRDXCLtDdtCyyDDu;
                    this.__p_FqeizimU6dSMRNXkHNgHpV = __p_FqeizimU6dSMRNXkHNgHpV;
                    this.__p_F6uQan0typdQTkiVcCLhC6 = __p_F6uQan0typdQTkiVcCLhC6;
                    this.__p_DPqpAC6xUflPLYWpVUZsZH = __p_DPqpAC6xUflPLYWpVUZsZH;
                    this.__p_TLlm9f4R0AkOo3nKAfja3g = __p_TLlm9f4R0AkOo3nKAfja3g;
                    this.__p_FZFhBxlVO0uMRr3OInQeME = __p_FZFhBxlVO0uMRr3OInQeME;
                    this.__slot_KdazVx16DdZOtDv6ATPyOs = __slot_KdazVx16DdZOtDv6ATPyOs;
                    this.__slot_RLG7SEp77NBLS2yxphAMkn = __slot_RLG7SEp77NBLS2yxphAMkn;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 320628U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "VnsEYg4UwjxOlBkQhfPBHn", Name = "Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn")]
    [n3.SerializableAttribute]
    public class Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn Create(n2.NodeContext Node_Context)
        {
            var instance = new Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn CreateDefault()
        {
            var instance = new Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn Update(n6.GpuValue<n29.Vector2> TDomain_In, n6.GpuValue<float> Time_In, [n5.SerializedDefaultValueAttribute("2, 2", false)] n6.GpuValue<n29.Vector2> Frequency_In, [n5.SerializedDefaultValueAttribute("1, 1", false)] n6.GpuValue<n29.Vector2> Amplitude_In, [n5.SerializedDefaultValueAttribute("0, 0", false)] n6.GpuValue<n29.Vector2> Offset_In, [n5.SerializedDefaultValueAttribute("0, 0", false)] n6.GpuValue<n29.Vector2> Center_In, [n5.SerializedDefaultValueAttribute("0.5, 0.5", false)] n6.GpuValue<n29.Vector2> Bias_In, n7.NoiseBasisInflection Inflection_In, [n5.SerializedDefaultValueAttribute("GradientNoise", false)] n8.NoiseType Noise_Type_In, out n6.GpuValue<n29.Vector2> Output_Out)
        {
            bool __pad_T3ly8CB7pTULnPnkMtLrVA_0 = __slot_T3ly8CB7pTULnPnkMtLrVA;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_P2ji000o1g3PPuF1lFqNHr;
            if (manager_2 is null)
            {
                manager_2 = new n9.Manager<n3.ValueTuple<n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n3.ValueTuple<n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<n29.Vector2>>>(n3.ValueTuple.Create(default(n6.GpuValue<n29.Vector2>)));
            }

            var inputs_3 = (TDomain_In, Time_In, Frequency_In, Amplitude_In, Offset_In, Center_In, Bias_In, Inflection_In, Noise_Type_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = __pad_T3ly8CB7pTULnPnkMtLrVA_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n2.CompilationHelper.Restore<__D3vMFgdxOStLiliQCdjk1B>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __D3vMFgdxOStLiliQCdjk1B(__GetContext__(), n2.VLObject.NewIdentity())
                    {__slot_Hc19YMljH1fLdLUMROdkid = default(n6.GpuValue<n29.Vector2>), __slot_MascDC6TdypO0CX7te9UNr = default(n6.GpuValue<n29.Vector3>)};
                    n2.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "GW3P7jk1zc5N1DUIXMqC7J", 320658U);
                    var Output_8 = n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector2, n29.Vector2>.Create(Node_Context: Node_Context_7);
                    state_6.__p_GW3P7jk1zc5N1DUIXMqC7J = Output_8;
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "J0CMdODq8IBLAN3XrvffpQ", 320675U);
                    var Output_10 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector2>.Create(Node_Context: Node_Context_9);
                    state_6.__p_J0CMdODq8IBLAN3XrvffpQ = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "ELy1zCX7mMyMiZWkqhjDue", 320685U);
                    var Output_12 = n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr.Create(Node_Context: Node_Context_11);
                    state_6.__p_ELy1zCX7mMyMiZWkqhjDue = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "VIzuXysHxGGP3gwscqIn7E", 320697U);
                    var Output_14 = n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector3, n29.Vector2>.Create(Node_Context: Node_Context_13);
                    state_6.__p_VIzuXysHxGGP3gwscqIn7E = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "J3Ec9vkXSdYPMzqM0lmlgX", 320719U);
                    var Output_16 = n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr.Create(Node_Context: Node_Context_15);
                    state_6.__p_J3Ec9vkXSdYPMzqM0lmlgX = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "SfWAWDgar66OXqwXYBx7o7", 320733U);
                    var Output_18 = n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr.Create(Node_Context: Node_Context_17);
                    state_6.__p_SfWAWDgar66OXqwXYBx7o7 = Output_18;
                    n2.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "OwweBxREuKVOo9SLQeNvNB", 320750U);
                    var Output_20 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_19);
                    state_6.__p_OwweBxREuKVOo9SLQeNvNB = Output_20;
                    n2.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "BQzcbj7iPthNDIcO4Fdn7T", 320767U);
                    var Output_22 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_21);
                    state_6.__p_BQzcbj7iPthNDIcO4Fdn7T = Output_22;
                    n2.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "QaojukeTMiVMZVZ2mDpaoq", 320785U);
                    var Output_24 = n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<n29.Vector2>.Create(Node_Context: Node_Context_23);
                    state_6.__p_QaojukeTMiVMZVZ2mDpaoq = Output_24;
                    n38._Operations_.Noise2DVectorID(Output_Out: out string Output_25);
                    n2.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Fmdv79vhzlCOrPf6mRpIDy", 320798U);
                    var Output_27 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_26, ID_In: Output_25);
                    state_6.__p_Fmdv79vhzlCOrPf6mRpIDy = Output_27;
                }

                float __pad_FlrOUYNI4okNfgZ5VZ2Em9_28 = __slot_FlrOUYNI4okNfgZ5VZ2Em9;
                float __pad_MJJS0yfpUfKLRTiYLxXfJ6_29 = __slot_MJJS0yfpUfKLRTiYLxXfJ6;
                int Id_30 = 0;
                var State_Output_32 = state_6.__p_J0CMdODq8IBLAN3XrvffpQ.Update(The_Override_In: TDomain_In, Id_In: Id_30, Output_Out: out n6.GpuValue<n29.Vector2> Output_31);
                n6.GpuValue<n29.Vector2> __pad_Hc19YMljH1fLdLUMROdkid_33 = Output_31;
                n6.GpuValue<n29.Vector2> default_34 = default(n6.GpuValue<n29.Vector2>);
                var State_Output_36 = state_6.__p_GW3P7jk1zc5N1DUIXMqC7J.Update<n27.__AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW>(TDomain_In: __pad_Hc19YMljH1fLdLUMROdkid_33, Frequency_In: Frequency_In, Amplitude_In: Amplitude_In, Offset_In: Offset_In, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: Inflection_In, Noise_Type_In: Noise_Type_In, default_In: default_34, Output_Out: out n6.GpuValue<n29.Vector2> Output_35);
                var State_Output_38 = state_6.__p_ELy1zCX7mMyMiZWkqhjDue.Update(xy_In: Output_31, z_In: Time_In, Output_Out: out n6.GpuValue<n29.Vector3> Output_37);
                n6.GpuValue<n29.Vector3> __pad_MascDC6TdypO0CX7te9UNr_39 = Output_37;
                float The_Value_40 = 1F;
                var State_Output_42 = state_6.__p_QaojukeTMiVMZVZ2mDpaoq.Update(GpuValue_In: Frequency_In, The_Value_In: The_Value_40, Output_Out: out n6.GpuValue<n29.Vector2> Output_41);
                var Output_44 = state_6.__p_OwweBxREuKVOo9SLQeNvNB.Update(Value_In: __pad_FlrOUYNI4okNfgZ5VZ2Em9_28, GpuValue_Out: out n6.GpuValue<float> GpuValue_43);
                var State_Output_46 = state_6.__p_SfWAWDgar66OXqwXYBx7o7.Update(xy_In: Output_41, z_In: GpuValue_43, Output_Out: out n6.GpuValue<n29.Vector3> Output_45);
                var Output_48 = state_6.__p_BQzcbj7iPthNDIcO4Fdn7T.Update(Value_In: __pad_MJJS0yfpUfKLRTiYLxXfJ6_29, GpuValue_Out: out n6.GpuValue<float> GpuValue_47);
                var State_Output_50 = state_6.__p_J3Ec9vkXSdYPMzqM0lmlgX.Update(xy_In: Offset_In, z_In: GpuValue_47, Output_Out: out n6.GpuValue<n29.Vector3> Output_49);
                n6.GpuValue<n29.Vector2> default_51 = default(n6.GpuValue<n29.Vector2>);
                var State_Output_53 = state_6.__p_VIzuXysHxGGP3gwscqIn7E.Update<n27.__AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW>(TDomain_In: __pad_MascDC6TdypO0CX7te9UNr_39, Frequency_In: Output_45, Amplitude_In: Amplitude_In, Offset_In: Output_49, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: Inflection_In, Noise_Type_In: Noise_Type_In, default_In: default_51, Output_Out: out n6.GpuValue<n29.Vector2> Output_52);
                n32.ObjectHelpers.IsAssigned(x: Time_In, result: out bool Result_54, notAssigned: out bool Not_Assigned_55);
                n37._Operations_.Switch_Boolean<n6.GpuValue<n29.Vector2>>(Condition_In: Result_54, Input_In: Output_35, Input_2_In: Output_52, Output_Out: out n6.GpuValue<n29.Vector2> Output_56);
                bool Update_57 = true;
                var Output_58 = state_6.__p_Fmdv79vhzlCOrPf6mRpIDy;
                if (Update_57)
                {
                    Output_58 = state_6.__p_Fmdv79vhzlCOrPf6mRpIDy.Update(Input_In: Output_56);
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_32 != state_6.__p_J0CMdODq8IBLAN3XrvffpQ || Output_31 != state_6.__slot_Hc19YMljH1fLdLUMROdkid || State_Output_36 != state_6.__p_GW3P7jk1zc5N1DUIXMqC7J || State_Output_38 != state_6.__p_ELy1zCX7mMyMiZWkqhjDue || Output_37 != state_6.__slot_MascDC6TdypO0CX7te9UNr || State_Output_42 != state_6.__p_QaojukeTMiVMZVZ2mDpaoq || Output_44 != state_6.__p_OwweBxREuKVOo9SLQeNvNB || State_Output_46 != state_6.__p_SfWAWDgar66OXqwXYBx7o7 || Output_48 != state_6.__p_BQzcbj7iPthNDIcO4Fdn7T || State_Output_50 != state_6.__p_J3Ec9vkXSdYPMzqM0lmlgX || State_Output_53 != state_6.__p_VIzuXysHxGGP3gwscqIn7E || Output_58 != state_6.__p_Fmdv79vhzlCOrPf6mRpIDy ? new __D3vMFgdxOStLiliQCdjk1B(state_6)
                    {__p_J0CMdODq8IBLAN3XrvffpQ = State_Output_32, __slot_Hc19YMljH1fLdLUMROdkid = Output_31, __p_GW3P7jk1zc5N1DUIXMqC7J = State_Output_36, __p_ELy1zCX7mMyMiZWkqhjDue = State_Output_38, __slot_MascDC6TdypO0CX7te9UNr = Output_37, __p_QaojukeTMiVMZVZ2mDpaoq = State_Output_42, __p_OwweBxREuKVOo9SLQeNvNB = Output_44, __p_SfWAWDgar66OXqwXYBx7o7 = State_Output_46, __p_BQzcbj7iPthNDIcO4Fdn7T = Output_48, __p_J3Ec9vkXSdYPMzqM0lmlgX = State_Output_50, __p_VIzuXysHxGGP3gwscqIn7E = State_Output_53, __p_Fmdv79vhzlCOrPf6mRpIDy = Output_58} : state_6;
                else
                {
                    state_6.__p_J0CMdODq8IBLAN3XrvffpQ = State_Output_32;
                    state_6.__slot_Hc19YMljH1fLdLUMROdkid = Output_31;
                    state_6.__p_GW3P7jk1zc5N1DUIXMqC7J = State_Output_36;
                    state_6.__p_ELy1zCX7mMyMiZWkqhjDue = State_Output_38;
                    state_6.__slot_MascDC6TdypO0CX7te9UNr = Output_37;
                    state_6.__p_QaojukeTMiVMZVZ2mDpaoq = State_Output_42;
                    state_6.__p_OwweBxREuKVOo9SLQeNvNB = Output_44;
                    state_6.__p_SfWAWDgar66OXqwXYBx7o7 = State_Output_46;
                    state_6.__p_BQzcbj7iPthNDIcO4Fdn7T = Output_48;
                    state_6.__p_J3Ec9vkXSdYPMzqM0lmlgX = State_Output_50;
                    state_6.__p_VIzuXysHxGGP3gwscqIn7E = State_Output_53;
                    state_6.__p_Fmdv79vhzlCOrPf6mRpIDy = Output_58;
                }

                outputs_4 = n3.ValueTuple.Create(Output_56);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_59 = outputs_4.Item1;
            Output_Out = __auto_59;
            n4.Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn that_60 = this;
            if (this.__GetContext__().IsImmutable)
                that_60 = manager_2 != this.__cache_P2ji000o1g3PPuF1lFqNHr ? new Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn(this)
                {__cache_P2ji000o1g3PPuF1lFqNHr = manager_2} : that_60;
            else
            {
                this.__cache_P2ji000o1g3PPuF1lFqNHr = manager_2;
            }

            return that_60;
        }

        public n4.Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn that_0 = this;
            this.__cache_P2ji000o1g3PPuF1lFqNHr = null;
            return that_0;
        }

        public n4.Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn __CreateDefault__()
        {
            n4.Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn that_0 = this;
            this.__cache_P2ji000o1g3PPuF1lFqNHr = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_P2ji000o1g3PPuF1lFqNHr);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 320832U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "T3ly8CB7pTULnPnkMtLrVA", Name = "__slot_T3ly8CB7pTULnPnkMtLrVA")]
        public static bool __slot_T3ly8CB7pTULnPnkMtLrVA = false;
        [n2.ElementAttribute(TracingId = 320632U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "P2ji000o1g3PPuF1lFqNHr", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n3.ValueTuple<n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<n29.Vector2>>> __cache_P2ji000o1g3PPuF1lFqNHr = null;
        [n2.ElementAttribute(TracingId = 320766U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "FlrOUYNI4okNfgZ5VZ2Em9", Name = "__slot_FlrOUYNI4okNfgZ5VZ2Em9")]
        public static float __slot_FlrOUYNI4okNfgZ5VZ2Em9 = 1F;
        [n2.ElementAttribute(TracingId = 320780U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "MJJS0yfpUfKLRTiYLxXfJ6", Name = "__slot_MJJS0yfpUfKLRTiYLxXfJ6")]
        public static float __slot_MJJS0yfpUfKLRTiYLxXfJ6 = 0F;
        static Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn()
        {
        }

        public Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn(Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn other): base(other)
        {
            this.__cache_P2ji000o1g3PPuF1lFqNHr = other.__cache_P2ji000o1g3PPuF1lFqNHr;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_P2ji000o1g3PPuF1lFqNHr", in __cache_P2ji000o1g3PPuF1lFqNHr));
        }

        internal Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn __WITH__(n9.Manager<n3.ValueTuple<n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n6.GpuValue<n29.Vector2>, n3.ValueTuple<n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<n29.Vector2>>> __cache_P2ji000o1g3PPuF1lFqNHr)
        {
            n4.Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_P2ji000o1g3PPuF1lFqNHr != this.__cache_P2ji000o1g3PPuF1lFqNHr ? new Noise__2D_Vector_VnsEYg4UwjxOlBkQhfPBHn(this)
                {__cache_P2ji000o1g3PPuF1lFqNHr = __cache_P2ji000o1g3PPuF1lFqNHr} : that_0;
            else
            {
                this.__cache_P2ji000o1g3PPuF1lFqNHr = __cache_P2ji000o1g3PPuF1lFqNHr;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "D3vMFgdxOStLiliQCdjk1B", Name = "__D3vMFgdxOStLiliQCdjk1B")]
        [n3.SerializableAttribute]
        public class __D3vMFgdxOStLiliQCdjk1B : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_GW3P7jk1zc5N1DUIXMqC7J);
                n2.CompilationHelper.SafeDispose(this.__p_J0CMdODq8IBLAN3XrvffpQ);
                n2.CompilationHelper.SafeDispose(this.__p_ELy1zCX7mMyMiZWkqhjDue);
                n2.CompilationHelper.SafeDispose(this.__p_VIzuXysHxGGP3gwscqIn7E);
                n2.CompilationHelper.SafeDispose(this.__p_J3Ec9vkXSdYPMzqM0lmlgX);
                n2.CompilationHelper.SafeDispose(this.__p_SfWAWDgar66OXqwXYBx7o7);
                n2.CompilationHelper.SafeDispose(this.__p_OwweBxREuKVOo9SLQeNvNB);
                n2.CompilationHelper.SafeDispose(this.__p_BQzcbj7iPthNDIcO4Fdn7T);
                n2.CompilationHelper.SafeDispose(this.__p_QaojukeTMiVMZVZ2mDpaoq);
                n2.CompilationHelper.SafeDispose(this.__p_Fmdv79vhzlCOrPf6mRpIDy);
                return;
            }

            [n2.ElementAttribute(TracingId = 320658U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "GW3P7jk1zc5N1DUIXMqC7J", Name = "Noise", IsManaged = true, IsAutoGenerated = true)]
            public n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector2, n29.Vector2> __p_GW3P7jk1zc5N1DUIXMqC7J;
            [n2.ElementAttribute(TracingId = 320675U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "J0CMdODq8IBLAN3XrvffpQ", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector2> __p_J0CMdODq8IBLAN3XrvffpQ;
            [n2.ElementAttribute(TracingId = 320685U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "ELy1zCX7mMyMiZWkqhjDue", Name = "xy+z (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_ELy1zCX7mMyMiZWkqhjDue;
            [n2.ElementAttribute(TracingId = 320697U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "VIzuXysHxGGP3gwscqIn7E", Name = "Noise", IsManaged = true, IsAutoGenerated = true)]
            public n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector3, n29.Vector2> __p_VIzuXysHxGGP3gwscqIn7E;
            [n2.ElementAttribute(TracingId = 320719U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "J3Ec9vkXSdYPMzqM0lmlgX", Name = "xy+z (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_J3Ec9vkXSdYPMzqM0lmlgX;
            [n2.ElementAttribute(TracingId = 320733U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SfWAWDgar66OXqwXYBx7o7", Name = "xy+z (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_SfWAWDgar66OXqwXYBx7o7;
            [n2.ElementAttribute(TracingId = 320750U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "OwweBxREuKVOo9SLQeNvNB", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_OwweBxREuKVOo9SLQeNvNB;
            [n2.ElementAttribute(TracingId = 320767U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BQzcbj7iPthNDIcO4Fdn7T", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_BQzcbj7iPthNDIcO4Fdn7T;
            [n2.ElementAttribute(TracingId = 320785U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "QaojukeTMiVMZVZ2mDpaoq", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<n29.Vector2> __p_QaojukeTMiVMZVZ2mDpaoq;
            [n2.ElementAttribute(TracingId = 320798U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Fmdv79vhzlCOrPf6mRpIDy", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Fmdv79vhzlCOrPf6mRpIDy;
            [n2.ElementAttribute(TracingId = 320691U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Hc19YMljH1fLdLUMROdkid", Name = "__slot_Hc19YMljH1fLdLUMROdkid")]
            public n6.GpuValue<n29.Vector2> __slot_Hc19YMljH1fLdLUMROdkid;
            [n2.ElementAttribute(TracingId = 320693U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "MascDC6TdypO0CX7te9UNr", Name = "__slot_MascDC6TdypO0CX7te9UNr")]
            public n6.GpuValue<n29.Vector3> __slot_MascDC6TdypO0CX7te9UNr;
            public __D3vMFgdxOStLiliQCdjk1B(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __D3vMFgdxOStLiliQCdjk1B(__D3vMFgdxOStLiliQCdjk1B other): base(other)
            {
                this.__p_GW3P7jk1zc5N1DUIXMqC7J = other.__p_GW3P7jk1zc5N1DUIXMqC7J;
                this.__p_J0CMdODq8IBLAN3XrvffpQ = other.__p_J0CMdODq8IBLAN3XrvffpQ;
                this.__p_ELy1zCX7mMyMiZWkqhjDue = other.__p_ELy1zCX7mMyMiZWkqhjDue;
                this.__p_VIzuXysHxGGP3gwscqIn7E = other.__p_VIzuXysHxGGP3gwscqIn7E;
                this.__p_J3Ec9vkXSdYPMzqM0lmlgX = other.__p_J3Ec9vkXSdYPMzqM0lmlgX;
                this.__p_SfWAWDgar66OXqwXYBx7o7 = other.__p_SfWAWDgar66OXqwXYBx7o7;
                this.__p_OwweBxREuKVOo9SLQeNvNB = other.__p_OwweBxREuKVOo9SLQeNvNB;
                this.__p_BQzcbj7iPthNDIcO4Fdn7T = other.__p_BQzcbj7iPthNDIcO4Fdn7T;
                this.__p_QaojukeTMiVMZVZ2mDpaoq = other.__p_QaojukeTMiVMZVZ2mDpaoq;
                this.__p_Fmdv79vhzlCOrPf6mRpIDy = other.__p_Fmdv79vhzlCOrPf6mRpIDy;
                this.__slot_Hc19YMljH1fLdLUMROdkid = other.__slot_Hc19YMljH1fLdLUMROdkid;
                this.__slot_MascDC6TdypO0CX7te9UNr = other.__slot_MascDC6TdypO0CX7te9UNr;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_GW3P7jk1zc5N1DUIXMqC7J", in __p_GW3P7jk1zc5N1DUIXMqC7J), n2.CompilationHelper.GetValueOrExisting(values, "__p_J0CMdODq8IBLAN3XrvffpQ", in __p_J0CMdODq8IBLAN3XrvffpQ), n2.CompilationHelper.GetValueOrExisting(values, "__p_ELy1zCX7mMyMiZWkqhjDue", in __p_ELy1zCX7mMyMiZWkqhjDue), n2.CompilationHelper.GetValueOrExisting(values, "__p_VIzuXysHxGGP3gwscqIn7E", in __p_VIzuXysHxGGP3gwscqIn7E), n2.CompilationHelper.GetValueOrExisting(values, "__p_J3Ec9vkXSdYPMzqM0lmlgX", in __p_J3Ec9vkXSdYPMzqM0lmlgX), n2.CompilationHelper.GetValueOrExisting(values, "__p_SfWAWDgar66OXqwXYBx7o7", in __p_SfWAWDgar66OXqwXYBx7o7), n2.CompilationHelper.GetValueOrExisting(values, "__p_OwweBxREuKVOo9SLQeNvNB", in __p_OwweBxREuKVOo9SLQeNvNB), n2.CompilationHelper.GetValueOrExisting(values, "__p_BQzcbj7iPthNDIcO4Fdn7T", in __p_BQzcbj7iPthNDIcO4Fdn7T), n2.CompilationHelper.GetValueOrExisting(values, "__p_QaojukeTMiVMZVZ2mDpaoq", in __p_QaojukeTMiVMZVZ2mDpaoq), n2.CompilationHelper.GetValueOrExisting(values, "__p_Fmdv79vhzlCOrPf6mRpIDy", in __p_Fmdv79vhzlCOrPf6mRpIDy), n2.CompilationHelper.GetValueOrExisting(values, "__slot_Hc19YMljH1fLdLUMROdkid", in __slot_Hc19YMljH1fLdLUMROdkid), n2.CompilationHelper.GetValueOrExisting(values, "__slot_MascDC6TdypO0CX7te9UNr", in __slot_MascDC6TdypO0CX7te9UNr));
            }

            internal __D3vMFgdxOStLiliQCdjk1B __WITH__(n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector2, n29.Vector2> __p_GW3P7jk1zc5N1DUIXMqC7J, n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector2> __p_J0CMdODq8IBLAN3XrvffpQ, n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_ELy1zCX7mMyMiZWkqhjDue, n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector3, n29.Vector2> __p_VIzuXysHxGGP3gwscqIn7E, n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_J3Ec9vkXSdYPMzqM0lmlgX, n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_SfWAWDgar66OXqwXYBx7o7, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_OwweBxREuKVOo9SLQeNvNB, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_BQzcbj7iPthNDIcO4Fdn7T, n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<n29.Vector2> __p_QaojukeTMiVMZVZ2mDpaoq, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Fmdv79vhzlCOrPf6mRpIDy, n6.GpuValue<n29.Vector2> __slot_Hc19YMljH1fLdLUMROdkid, n6.GpuValue<n29.Vector3> __slot_MascDC6TdypO0CX7te9UNr)
            {
                __D3vMFgdxOStLiliQCdjk1B that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_GW3P7jk1zc5N1DUIXMqC7J != this.__p_GW3P7jk1zc5N1DUIXMqC7J || __p_J0CMdODq8IBLAN3XrvffpQ != this.__p_J0CMdODq8IBLAN3XrvffpQ || __p_ELy1zCX7mMyMiZWkqhjDue != this.__p_ELy1zCX7mMyMiZWkqhjDue || __p_VIzuXysHxGGP3gwscqIn7E != this.__p_VIzuXysHxGGP3gwscqIn7E || __p_J3Ec9vkXSdYPMzqM0lmlgX != this.__p_J3Ec9vkXSdYPMzqM0lmlgX || __p_SfWAWDgar66OXqwXYBx7o7 != this.__p_SfWAWDgar66OXqwXYBx7o7 || __p_OwweBxREuKVOo9SLQeNvNB != this.__p_OwweBxREuKVOo9SLQeNvNB || __p_BQzcbj7iPthNDIcO4Fdn7T != this.__p_BQzcbj7iPthNDIcO4Fdn7T || __p_QaojukeTMiVMZVZ2mDpaoq != this.__p_QaojukeTMiVMZVZ2mDpaoq || __p_Fmdv79vhzlCOrPf6mRpIDy != this.__p_Fmdv79vhzlCOrPf6mRpIDy || __slot_Hc19YMljH1fLdLUMROdkid != this.__slot_Hc19YMljH1fLdLUMROdkid || __slot_MascDC6TdypO0CX7te9UNr != this.__slot_MascDC6TdypO0CX7te9UNr ? new __D3vMFgdxOStLiliQCdjk1B(this)
                    {__p_GW3P7jk1zc5N1DUIXMqC7J = __p_GW3P7jk1zc5N1DUIXMqC7J, __p_J0CMdODq8IBLAN3XrvffpQ = __p_J0CMdODq8IBLAN3XrvffpQ, __p_ELy1zCX7mMyMiZWkqhjDue = __p_ELy1zCX7mMyMiZWkqhjDue, __p_VIzuXysHxGGP3gwscqIn7E = __p_VIzuXysHxGGP3gwscqIn7E, __p_J3Ec9vkXSdYPMzqM0lmlgX = __p_J3Ec9vkXSdYPMzqM0lmlgX, __p_SfWAWDgar66OXqwXYBx7o7 = __p_SfWAWDgar66OXqwXYBx7o7, __p_OwweBxREuKVOo9SLQeNvNB = __p_OwweBxREuKVOo9SLQeNvNB, __p_BQzcbj7iPthNDIcO4Fdn7T = __p_BQzcbj7iPthNDIcO4Fdn7T, __p_QaojukeTMiVMZVZ2mDpaoq = __p_QaojukeTMiVMZVZ2mDpaoq, __p_Fmdv79vhzlCOrPf6mRpIDy = __p_Fmdv79vhzlCOrPf6mRpIDy, __slot_Hc19YMljH1fLdLUMROdkid = __slot_Hc19YMljH1fLdLUMROdkid, __slot_MascDC6TdypO0CX7te9UNr = __slot_MascDC6TdypO0CX7te9UNr} : that_0;
                else
                {
                    this.__p_GW3P7jk1zc5N1DUIXMqC7J = __p_GW3P7jk1zc5N1DUIXMqC7J;
                    this.__p_J0CMdODq8IBLAN3XrvffpQ = __p_J0CMdODq8IBLAN3XrvffpQ;
                    this.__p_ELy1zCX7mMyMiZWkqhjDue = __p_ELy1zCX7mMyMiZWkqhjDue;
                    this.__p_VIzuXysHxGGP3gwscqIn7E = __p_VIzuXysHxGGP3gwscqIn7E;
                    this.__p_J3Ec9vkXSdYPMzqM0lmlgX = __p_J3Ec9vkXSdYPMzqM0lmlgX;
                    this.__p_SfWAWDgar66OXqwXYBx7o7 = __p_SfWAWDgar66OXqwXYBx7o7;
                    this.__p_OwweBxREuKVOo9SLQeNvNB = __p_OwweBxREuKVOo9SLQeNvNB;
                    this.__p_BQzcbj7iPthNDIcO4Fdn7T = __p_BQzcbj7iPthNDIcO4Fdn7T;
                    this.__p_QaojukeTMiVMZVZ2mDpaoq = __p_QaojukeTMiVMZVZ2mDpaoq;
                    this.__p_Fmdv79vhzlCOrPf6mRpIDy = __p_Fmdv79vhzlCOrPf6mRpIDy;
                    this.__slot_Hc19YMljH1fLdLUMROdkid = __slot_Hc19YMljH1fLdLUMROdkid;
                    this.__slot_MascDC6TdypO0CX7te9UNr = __slot_MascDC6TdypO0CX7te9UNr;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 321008U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "MiqYtrtnNbZN69eS4FTbgI", Name = "Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI")]
    [n3.SerializableAttribute]
    public class Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI Create(n2.NodeContext Node_Context)
        {
            var instance = new Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI CreateDefault()
        {
            var instance = new Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI Update(n6.GpuValue<n29.Vector3> TDomain_In, n6.GpuValue<float> Time_In, [n5.SerializedDefaultValueAttribute("2, 2, 2", false)] n6.GpuValue<n29.Vector3> Frequency_In, [n5.SerializedDefaultValueAttribute("1", false)] n6.GpuValue<float> Amplitude_In, [n5.SerializedDefaultValueAttribute("0, 0, 0", false)] n6.GpuValue<n29.Vector3> Offset_In, [n5.SerializedDefaultValueAttribute("0", false)] n6.GpuValue<float> Center_In, [n5.SerializedDefaultValueAttribute("0.5", false)] n6.GpuValue<float> Bias_In, n7.NoiseBasisInflection Inflection_In, [n5.SerializedDefaultValueAttribute("GradientNoise", false)] n8.NoiseType Noise_Type_In, out n6.GpuValue<float> Output_Out)
        {
            bool __pad_NYmW71xvdt6NrGybyuVfAO_0 = __slot_NYmW71xvdt6NrGybyuVfAO;
            n32.ObjectHelpers.IsAssigned(x: Time_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_TBU4m9JQOM5Ob51Wv3D51f;
            if (manager_4 is null)
            {
                manager_4 = new n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<float>>>(n3.ValueTuple.Create(default(n6.GpuValue<float>)));
            }

            var inputs_5 = (Result_1, TDomain_In, Time_In, Frequency_In, Amplitude_In, Offset_In, Center_In, Bias_In, Inflection_In, Noise_Type_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = __pad_NYmW71xvdt6NrGybyuVfAO_0 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n2.CompilationHelper.Restore<__TppkDXlk7eFNob3rUhOoFd>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __TppkDXlk7eFNob3rUhOoFd(__GetContext__(), n2.VLObject.NewIdentity())
                    {__slot_OESxl6e3o5uPQ7gLkyizCU = default(n6.GpuValue<n29.Vector3>), __slot_Bwk8EQQjnkTLxlEtfEpkan = default(n6.GpuValue<n29.Vector4>)};
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Squ9in67dDyQIx74cYKJmq", 321035U);
                    var Output_10 = n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector3, float>.Create(Node_Context: Node_Context_9);
                    state_8.__p_Squ9in67dDyQIx74cYKJmq = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "UFZPVAwOVwELv5x6sWzLJ5", 321047U);
                    var Output_12 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3>.Create(Node_Context: Node_Context_11);
                    state_8.__p_UFZPVAwOVwELv5x6sWzLJ5 = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "A2F4jSr5lFSM3SGWQi4YCu", 321050U);
                    var Output_14 = n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_13);
                    state_8.__p_A2F4jSr5lFSM3SGWQi4YCu = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "BCbTd4DmXdkOFfuPZiHmGK", 321056U);
                    var Output_16 = n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector4, float>.Create(Node_Context: Node_Context_15);
                    state_8.__p_BCbTd4DmXdkOFfuPZiHmGK = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "IWs4AtvlVkRNNNBD3MxQaD", 321071U);
                    var Output_18 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_17);
                    state_8.__p_IWs4AtvlVkRNNNBD3MxQaD = Output_18;
                    n2.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "GkmcxDztw9XOttiCis70XQ", 321075U);
                    var Output_20 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_19);
                    state_8.__p_GkmcxDztw9XOttiCis70XQ = Output_20;
                    n2.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "DNCLliW3TszNawKXxxM2i1", 321079U);
                    var Output_22 = n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<n29.Vector3>.Create(Node_Context: Node_Context_21);
                    state_8.__p_DNCLliW3TszNawKXxxM2i1 = Output_22;
                    n2.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "AxNeNuKOkAANdvabUiJqnC", 321083U);
                    var Output_24 = n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_23);
                    state_8.__p_AxNeNuKOkAANdvabUiJqnC = Output_24;
                    n2.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "CeUGO9eW1J5NIH3AOfK41P", 321087U);
                    var Output_26 = n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_25);
                    state_8.__p_CeUGO9eW1J5NIH3AOfK41P = Output_26;
                    n39._Operations_.Noise3DScalarID(Output_Out: out string Output_27);
                    n2.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Jbd9mJENhdIL4Zjqkl4d6E", 321091U);
                    var Output_29 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_28, ID_In: Output_27);
                    state_8.__p_Jbd9mJENhdIL4Zjqkl4d6E = Output_29;
                }

                float __pad_VPKvUoVOqmMMJLD5mMc1tf_30 = __slot_VPKvUoVOqmMMJLD5mMc1tf;
                float __pad_JoATiVVPwBKLz77dgdlVga_31 = __slot_JoATiVVPwBKLz77dgdlVga;
                int Id_32 = 0;
                var State_Output_34 = state_8.__p_UFZPVAwOVwELv5x6sWzLJ5.Update(The_Override_In: TDomain_In, Id_In: Id_32, Output_Out: out n6.GpuValue<n29.Vector3> Output_33);
                n6.GpuValue<n29.Vector3> __pad_OESxl6e3o5uPQ7gLkyizCU_35 = Output_33;
                n6.GpuValue<float> default_36 = default(n6.GpuValue<float>);
                var State_Output_38 = state_8.__p_Squ9in67dDyQIx74cYKJmq.Update<n27.__AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW>(TDomain_In: __pad_OESxl6e3o5uPQ7gLkyizCU_35, Frequency_In: Frequency_In, Amplitude_In: Amplitude_In, Offset_In: Offset_In, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: Inflection_In, Noise_Type_In: Noise_Type_In, default_In: default_36, Output_Out: out n6.GpuValue<float> Output_37);
                var State_Output_40 = state_8.__p_A2F4jSr5lFSM3SGWQi4YCu.Update(xyz_In: Output_33, w_In: Time_In, Output_Out: out n6.GpuValue<n29.Vector4> Output_39);
                n6.GpuValue<n29.Vector4> __pad_Bwk8EQQjnkTLxlEtfEpkan_41 = Output_39;
                float The_Value_42 = 1F;
                var State_Output_44 = state_8.__p_DNCLliW3TszNawKXxxM2i1.Update(GpuValue_In: Frequency_In, The_Value_In: The_Value_42, Output_Out: out n6.GpuValue<n29.Vector3> Output_43);
                var Output_46 = state_8.__p_IWs4AtvlVkRNNNBD3MxQaD.Update(Value_In: __pad_VPKvUoVOqmMMJLD5mMc1tf_30, GpuValue_Out: out n6.GpuValue<float> GpuValue_45);
                var State_Output_48 = state_8.__p_AxNeNuKOkAANdvabUiJqnC.Update(xyz_In: Output_43, w_In: GpuValue_45, Output_Out: out n6.GpuValue<n29.Vector4> Output_47);
                var Output_50 = state_8.__p_GkmcxDztw9XOttiCis70XQ.Update(Value_In: __pad_JoATiVVPwBKLz77dgdlVga_31, GpuValue_Out: out n6.GpuValue<float> GpuValue_49);
                var State_Output_52 = state_8.__p_CeUGO9eW1J5NIH3AOfK41P.Update(xyz_In: Offset_In, w_In: GpuValue_49, Output_Out: out n6.GpuValue<n29.Vector4> Output_51);
                n6.GpuValue<float> default_53 = default(n6.GpuValue<float>);
                var State_Output_55 = state_8.__p_BCbTd4DmXdkOFfuPZiHmGK.Update<n27.__AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW>(TDomain_In: __pad_Bwk8EQQjnkTLxlEtfEpkan_41, Frequency_In: Output_47, Amplitude_In: Amplitude_In, Offset_In: Output_51, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: Inflection_In, Noise_Type_In: Noise_Type_In, default_In: default_53, Output_Out: out n6.GpuValue<float> Output_54);
                n37._Operations_.Switch_Boolean<n6.GpuValue<float>>(Condition_In: Result_1, Input_In: Output_37, Input_2_In: Output_54, Output_Out: out n6.GpuValue<float> Output_56);
                bool Update_57 = true;
                var Output_58 = state_8.__p_Jbd9mJENhdIL4Zjqkl4d6E;
                if (Update_57)
                {
                    Output_58 = state_8.__p_Jbd9mJENhdIL4Zjqkl4d6E.Update(Input_In: Output_56);
                }

                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_34 != state_8.__p_UFZPVAwOVwELv5x6sWzLJ5 || Output_33 != state_8.__slot_OESxl6e3o5uPQ7gLkyizCU || State_Output_38 != state_8.__p_Squ9in67dDyQIx74cYKJmq || State_Output_40 != state_8.__p_A2F4jSr5lFSM3SGWQi4YCu || Output_39 != state_8.__slot_Bwk8EQQjnkTLxlEtfEpkan || State_Output_44 != state_8.__p_DNCLliW3TszNawKXxxM2i1 || Output_46 != state_8.__p_IWs4AtvlVkRNNNBD3MxQaD || State_Output_48 != state_8.__p_AxNeNuKOkAANdvabUiJqnC || Output_50 != state_8.__p_GkmcxDztw9XOttiCis70XQ || State_Output_52 != state_8.__p_CeUGO9eW1J5NIH3AOfK41P || State_Output_55 != state_8.__p_BCbTd4DmXdkOFfuPZiHmGK || Output_58 != state_8.__p_Jbd9mJENhdIL4Zjqkl4d6E ? new __TppkDXlk7eFNob3rUhOoFd(state_8)
                    {__p_UFZPVAwOVwELv5x6sWzLJ5 = State_Output_34, __slot_OESxl6e3o5uPQ7gLkyizCU = Output_33, __p_Squ9in67dDyQIx74cYKJmq = State_Output_38, __p_A2F4jSr5lFSM3SGWQi4YCu = State_Output_40, __slot_Bwk8EQQjnkTLxlEtfEpkan = Output_39, __p_DNCLliW3TszNawKXxxM2i1 = State_Output_44, __p_IWs4AtvlVkRNNNBD3MxQaD = Output_46, __p_AxNeNuKOkAANdvabUiJqnC = State_Output_48, __p_GkmcxDztw9XOttiCis70XQ = Output_50, __p_CeUGO9eW1J5NIH3AOfK41P = State_Output_52, __p_BCbTd4DmXdkOFfuPZiHmGK = State_Output_55, __p_Jbd9mJENhdIL4Zjqkl4d6E = Output_58} : state_8;
                else
                {
                    state_8.__p_UFZPVAwOVwELv5x6sWzLJ5 = State_Output_34;
                    state_8.__slot_OESxl6e3o5uPQ7gLkyizCU = Output_33;
                    state_8.__p_Squ9in67dDyQIx74cYKJmq = State_Output_38;
                    state_8.__p_A2F4jSr5lFSM3SGWQi4YCu = State_Output_40;
                    state_8.__slot_Bwk8EQQjnkTLxlEtfEpkan = Output_39;
                    state_8.__p_DNCLliW3TszNawKXxxM2i1 = State_Output_44;
                    state_8.__p_IWs4AtvlVkRNNNBD3MxQaD = Output_46;
                    state_8.__p_AxNeNuKOkAANdvabUiJqnC = State_Output_48;
                    state_8.__p_GkmcxDztw9XOttiCis70XQ = Output_50;
                    state_8.__p_CeUGO9eW1J5NIH3AOfK41P = State_Output_52;
                    state_8.__p_BCbTd4DmXdkOFfuPZiHmGK = State_Output_55;
                    state_8.__p_Jbd9mJENhdIL4Zjqkl4d6E = Output_58;
                }

                outputs_6 = n3.ValueTuple.Create(Output_56);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_59 = outputs_6.Item1;
            Output_Out = __auto_59;
            n4.Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI that_60 = this;
            if (this.__GetContext__().IsImmutable)
                that_60 = manager_4 != this.__cache_TBU4m9JQOM5Ob51Wv3D51f ? new Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI(this)
                {__cache_TBU4m9JQOM5Ob51Wv3D51f = manager_4} : that_60;
            else
            {
                this.__cache_TBU4m9JQOM5Ob51Wv3D51f = manager_4;
            }

            return that_60;
        }

        public n4.Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI that_0 = this;
            this.__cache_TBU4m9JQOM5Ob51Wv3D51f = null;
            return that_0;
        }

        public n4.Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI __CreateDefault__()
        {
            n4.Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI that_0 = this;
            this.__cache_TBU4m9JQOM5Ob51Wv3D51f = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_TBU4m9JQOM5Ob51Wv3D51f);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 321110U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NYmW71xvdt6NrGybyuVfAO", Name = "__slot_NYmW71xvdt6NrGybyuVfAO")]
        public static bool __slot_NYmW71xvdt6NrGybyuVfAO = false;
        [n2.ElementAttribute(TracingId = 321014U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "TBU4m9JQOM5Ob51Wv3D51f", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<float>>> __cache_TBU4m9JQOM5Ob51Wv3D51f = null;
        [n2.ElementAttribute(TracingId = 321074U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "VPKvUoVOqmMMJLD5mMc1tf", Name = "__slot_VPKvUoVOqmMMJLD5mMc1tf")]
        public static float __slot_VPKvUoVOqmMMJLD5mMc1tf = 1F;
        [n2.ElementAttribute(TracingId = 321078U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "JoATiVVPwBKLz77dgdlVga", Name = "__slot_JoATiVVPwBKLz77dgdlVga")]
        public static float __slot_JoATiVVPwBKLz77dgdlVga = 0F;
        static Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI()
        {
        }

        public Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI(Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI other): base(other)
        {
            this.__cache_TBU4m9JQOM5Ob51Wv3D51f = other.__cache_TBU4m9JQOM5Ob51Wv3D51f;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_TBU4m9JQOM5Ob51Wv3D51f", in __cache_TBU4m9JQOM5Ob51Wv3D51f));
        }

        internal Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI __WITH__(n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<float>>> __cache_TBU4m9JQOM5Ob51Wv3D51f)
        {
            n4.Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_TBU4m9JQOM5Ob51Wv3D51f != this.__cache_TBU4m9JQOM5Ob51Wv3D51f ? new Noise__3D_Scalar_MiqYtrtnNbZN69eS4FTbgI(this)
                {__cache_TBU4m9JQOM5Ob51Wv3D51f = __cache_TBU4m9JQOM5Ob51Wv3D51f} : that_0;
            else
            {
                this.__cache_TBU4m9JQOM5Ob51Wv3D51f = __cache_TBU4m9JQOM5Ob51Wv3D51f;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "TppkDXlk7eFNob3rUhOoFd", Name = "__TppkDXlk7eFNob3rUhOoFd")]
        [n3.SerializableAttribute]
        public class __TppkDXlk7eFNob3rUhOoFd : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_Squ9in67dDyQIx74cYKJmq);
                n2.CompilationHelper.SafeDispose(this.__p_UFZPVAwOVwELv5x6sWzLJ5);
                n2.CompilationHelper.SafeDispose(this.__p_A2F4jSr5lFSM3SGWQi4YCu);
                n2.CompilationHelper.SafeDispose(this.__p_BCbTd4DmXdkOFfuPZiHmGK);
                n2.CompilationHelper.SafeDispose(this.__p_IWs4AtvlVkRNNNBD3MxQaD);
                n2.CompilationHelper.SafeDispose(this.__p_GkmcxDztw9XOttiCis70XQ);
                n2.CompilationHelper.SafeDispose(this.__p_DNCLliW3TszNawKXxxM2i1);
                n2.CompilationHelper.SafeDispose(this.__p_AxNeNuKOkAANdvabUiJqnC);
                n2.CompilationHelper.SafeDispose(this.__p_CeUGO9eW1J5NIH3AOfK41P);
                n2.CompilationHelper.SafeDispose(this.__p_Jbd9mJENhdIL4Zjqkl4d6E);
                return;
            }

            [n2.ElementAttribute(TracingId = 321035U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Squ9in67dDyQIx74cYKJmq", Name = "Noise", IsManaged = true, IsAutoGenerated = true)]
            public n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector3, float> __p_Squ9in67dDyQIx74cYKJmq;
            [n2.ElementAttribute(TracingId = 321047U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "UFZPVAwOVwELv5x6sWzLJ5", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3> __p_UFZPVAwOVwELv5x6sWzLJ5;
            [n2.ElementAttribute(TracingId = 321050U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "A2F4jSr5lFSM3SGWQi4YCu", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_A2F4jSr5lFSM3SGWQi4YCu;
            [n2.ElementAttribute(TracingId = 321056U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BCbTd4DmXdkOFfuPZiHmGK", Name = "Noise", IsManaged = true, IsAutoGenerated = true)]
            public n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector4, float> __p_BCbTd4DmXdkOFfuPZiHmGK;
            [n2.ElementAttribute(TracingId = 321071U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "IWs4AtvlVkRNNNBD3MxQaD", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_IWs4AtvlVkRNNNBD3MxQaD;
            [n2.ElementAttribute(TracingId = 321075U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "GkmcxDztw9XOttiCis70XQ", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_GkmcxDztw9XOttiCis70XQ;
            [n2.ElementAttribute(TracingId = 321079U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "DNCLliW3TszNawKXxxM2i1", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<n29.Vector3> __p_DNCLliW3TszNawKXxxM2i1;
            [n2.ElementAttribute(TracingId = 321083U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "AxNeNuKOkAANdvabUiJqnC", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_AxNeNuKOkAANdvabUiJqnC;
            [n2.ElementAttribute(TracingId = 321087U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "CeUGO9eW1J5NIH3AOfK41P", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_CeUGO9eW1J5NIH3AOfK41P;
            [n2.ElementAttribute(TracingId = 321091U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Jbd9mJENhdIL4Zjqkl4d6E", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Jbd9mJENhdIL4Zjqkl4d6E;
            [n2.ElementAttribute(TracingId = 321054U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "OESxl6e3o5uPQ7gLkyizCU", Name = "__slot_OESxl6e3o5uPQ7gLkyizCU")]
            public n6.GpuValue<n29.Vector3> __slot_OESxl6e3o5uPQ7gLkyizCU;
            [n2.ElementAttribute(TracingId = 321055U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Bwk8EQQjnkTLxlEtfEpkan", Name = "__slot_Bwk8EQQjnkTLxlEtfEpkan")]
            public n6.GpuValue<n29.Vector4> __slot_Bwk8EQQjnkTLxlEtfEpkan;
            public __TppkDXlk7eFNob3rUhOoFd(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __TppkDXlk7eFNob3rUhOoFd(__TppkDXlk7eFNob3rUhOoFd other): base(other)
            {
                this.__p_Squ9in67dDyQIx74cYKJmq = other.__p_Squ9in67dDyQIx74cYKJmq;
                this.__p_UFZPVAwOVwELv5x6sWzLJ5 = other.__p_UFZPVAwOVwELv5x6sWzLJ5;
                this.__p_A2F4jSr5lFSM3SGWQi4YCu = other.__p_A2F4jSr5lFSM3SGWQi4YCu;
                this.__p_BCbTd4DmXdkOFfuPZiHmGK = other.__p_BCbTd4DmXdkOFfuPZiHmGK;
                this.__p_IWs4AtvlVkRNNNBD3MxQaD = other.__p_IWs4AtvlVkRNNNBD3MxQaD;
                this.__p_GkmcxDztw9XOttiCis70XQ = other.__p_GkmcxDztw9XOttiCis70XQ;
                this.__p_DNCLliW3TszNawKXxxM2i1 = other.__p_DNCLliW3TszNawKXxxM2i1;
                this.__p_AxNeNuKOkAANdvabUiJqnC = other.__p_AxNeNuKOkAANdvabUiJqnC;
                this.__p_CeUGO9eW1J5NIH3AOfK41P = other.__p_CeUGO9eW1J5NIH3AOfK41P;
                this.__p_Jbd9mJENhdIL4Zjqkl4d6E = other.__p_Jbd9mJENhdIL4Zjqkl4d6E;
                this.__slot_OESxl6e3o5uPQ7gLkyizCU = other.__slot_OESxl6e3o5uPQ7gLkyizCU;
                this.__slot_Bwk8EQQjnkTLxlEtfEpkan = other.__slot_Bwk8EQQjnkTLxlEtfEpkan;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_Squ9in67dDyQIx74cYKJmq", in __p_Squ9in67dDyQIx74cYKJmq), n2.CompilationHelper.GetValueOrExisting(values, "__p_UFZPVAwOVwELv5x6sWzLJ5", in __p_UFZPVAwOVwELv5x6sWzLJ5), n2.CompilationHelper.GetValueOrExisting(values, "__p_A2F4jSr5lFSM3SGWQi4YCu", in __p_A2F4jSr5lFSM3SGWQi4YCu), n2.CompilationHelper.GetValueOrExisting(values, "__p_BCbTd4DmXdkOFfuPZiHmGK", in __p_BCbTd4DmXdkOFfuPZiHmGK), n2.CompilationHelper.GetValueOrExisting(values, "__p_IWs4AtvlVkRNNNBD3MxQaD", in __p_IWs4AtvlVkRNNNBD3MxQaD), n2.CompilationHelper.GetValueOrExisting(values, "__p_GkmcxDztw9XOttiCis70XQ", in __p_GkmcxDztw9XOttiCis70XQ), n2.CompilationHelper.GetValueOrExisting(values, "__p_DNCLliW3TszNawKXxxM2i1", in __p_DNCLliW3TszNawKXxxM2i1), n2.CompilationHelper.GetValueOrExisting(values, "__p_AxNeNuKOkAANdvabUiJqnC", in __p_AxNeNuKOkAANdvabUiJqnC), n2.CompilationHelper.GetValueOrExisting(values, "__p_CeUGO9eW1J5NIH3AOfK41P", in __p_CeUGO9eW1J5NIH3AOfK41P), n2.CompilationHelper.GetValueOrExisting(values, "__p_Jbd9mJENhdIL4Zjqkl4d6E", in __p_Jbd9mJENhdIL4Zjqkl4d6E), n2.CompilationHelper.GetValueOrExisting(values, "__slot_OESxl6e3o5uPQ7gLkyizCU", in __slot_OESxl6e3o5uPQ7gLkyizCU), n2.CompilationHelper.GetValueOrExisting(values, "__slot_Bwk8EQQjnkTLxlEtfEpkan", in __slot_Bwk8EQQjnkTLxlEtfEpkan));
            }

            internal __TppkDXlk7eFNob3rUhOoFd __WITH__(n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector3, float> __p_Squ9in67dDyQIx74cYKJmq, n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3> __p_UFZPVAwOVwELv5x6sWzLJ5, n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_A2F4jSr5lFSM3SGWQi4YCu, n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector4, float> __p_BCbTd4DmXdkOFfuPZiHmGK, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_IWs4AtvlVkRNNNBD3MxQaD, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_GkmcxDztw9XOttiCis70XQ, n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<n29.Vector3> __p_DNCLliW3TszNawKXxxM2i1, n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_AxNeNuKOkAANdvabUiJqnC, n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_CeUGO9eW1J5NIH3AOfK41P, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Jbd9mJENhdIL4Zjqkl4d6E, n6.GpuValue<n29.Vector3> __slot_OESxl6e3o5uPQ7gLkyizCU, n6.GpuValue<n29.Vector4> __slot_Bwk8EQQjnkTLxlEtfEpkan)
            {
                __TppkDXlk7eFNob3rUhOoFd that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Squ9in67dDyQIx74cYKJmq != this.__p_Squ9in67dDyQIx74cYKJmq || __p_UFZPVAwOVwELv5x6sWzLJ5 != this.__p_UFZPVAwOVwELv5x6sWzLJ5 || __p_A2F4jSr5lFSM3SGWQi4YCu != this.__p_A2F4jSr5lFSM3SGWQi4YCu || __p_BCbTd4DmXdkOFfuPZiHmGK != this.__p_BCbTd4DmXdkOFfuPZiHmGK || __p_IWs4AtvlVkRNNNBD3MxQaD != this.__p_IWs4AtvlVkRNNNBD3MxQaD || __p_GkmcxDztw9XOttiCis70XQ != this.__p_GkmcxDztw9XOttiCis70XQ || __p_DNCLliW3TszNawKXxxM2i1 != this.__p_DNCLliW3TszNawKXxxM2i1 || __p_AxNeNuKOkAANdvabUiJqnC != this.__p_AxNeNuKOkAANdvabUiJqnC || __p_CeUGO9eW1J5NIH3AOfK41P != this.__p_CeUGO9eW1J5NIH3AOfK41P || __p_Jbd9mJENhdIL4Zjqkl4d6E != this.__p_Jbd9mJENhdIL4Zjqkl4d6E || __slot_OESxl6e3o5uPQ7gLkyizCU != this.__slot_OESxl6e3o5uPQ7gLkyizCU || __slot_Bwk8EQQjnkTLxlEtfEpkan != this.__slot_Bwk8EQQjnkTLxlEtfEpkan ? new __TppkDXlk7eFNob3rUhOoFd(this)
                    {__p_Squ9in67dDyQIx74cYKJmq = __p_Squ9in67dDyQIx74cYKJmq, __p_UFZPVAwOVwELv5x6sWzLJ5 = __p_UFZPVAwOVwELv5x6sWzLJ5, __p_A2F4jSr5lFSM3SGWQi4YCu = __p_A2F4jSr5lFSM3SGWQi4YCu, __p_BCbTd4DmXdkOFfuPZiHmGK = __p_BCbTd4DmXdkOFfuPZiHmGK, __p_IWs4AtvlVkRNNNBD3MxQaD = __p_IWs4AtvlVkRNNNBD3MxQaD, __p_GkmcxDztw9XOttiCis70XQ = __p_GkmcxDztw9XOttiCis70XQ, __p_DNCLliW3TszNawKXxxM2i1 = __p_DNCLliW3TszNawKXxxM2i1, __p_AxNeNuKOkAANdvabUiJqnC = __p_AxNeNuKOkAANdvabUiJqnC, __p_CeUGO9eW1J5NIH3AOfK41P = __p_CeUGO9eW1J5NIH3AOfK41P, __p_Jbd9mJENhdIL4Zjqkl4d6E = __p_Jbd9mJENhdIL4Zjqkl4d6E, __slot_OESxl6e3o5uPQ7gLkyizCU = __slot_OESxl6e3o5uPQ7gLkyizCU, __slot_Bwk8EQQjnkTLxlEtfEpkan = __slot_Bwk8EQQjnkTLxlEtfEpkan} : that_0;
                else
                {
                    this.__p_Squ9in67dDyQIx74cYKJmq = __p_Squ9in67dDyQIx74cYKJmq;
                    this.__p_UFZPVAwOVwELv5x6sWzLJ5 = __p_UFZPVAwOVwELv5x6sWzLJ5;
                    this.__p_A2F4jSr5lFSM3SGWQi4YCu = __p_A2F4jSr5lFSM3SGWQi4YCu;
                    this.__p_BCbTd4DmXdkOFfuPZiHmGK = __p_BCbTd4DmXdkOFfuPZiHmGK;
                    this.__p_IWs4AtvlVkRNNNBD3MxQaD = __p_IWs4AtvlVkRNNNBD3MxQaD;
                    this.__p_GkmcxDztw9XOttiCis70XQ = __p_GkmcxDztw9XOttiCis70XQ;
                    this.__p_DNCLliW3TszNawKXxxM2i1 = __p_DNCLliW3TszNawKXxxM2i1;
                    this.__p_AxNeNuKOkAANdvabUiJqnC = __p_AxNeNuKOkAANdvabUiJqnC;
                    this.__p_CeUGO9eW1J5NIH3AOfK41P = __p_CeUGO9eW1J5NIH3AOfK41P;
                    this.__p_Jbd9mJENhdIL4Zjqkl4d6E = __p_Jbd9mJENhdIL4Zjqkl4d6E;
                    this.__slot_OESxl6e3o5uPQ7gLkyizCU = __slot_OESxl6e3o5uPQ7gLkyizCU;
                    this.__slot_Bwk8EQQjnkTLxlEtfEpkan = __slot_Bwk8EQQjnkTLxlEtfEpkan;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 321191U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "IfMa5FzLvMkLUTUBn5nO6x", Name = "Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x")]
    [n3.SerializableAttribute]
    public class Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x Create(n2.NodeContext Node_Context)
        {
            var instance = new Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x CreateDefault()
        {
            var instance = new Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x Update(n6.GpuValue<n29.Vector3> TDomain_In, n6.GpuValue<float> Time_In, [n5.SerializedDefaultValueAttribute("2, 2, 2", false)] n6.GpuValue<n29.Vector3> Frequency_In, [n5.SerializedDefaultValueAttribute("1, 1, 1", false)] n6.GpuValue<n29.Vector3> Amplitude_In, n6.GpuValue<n29.Vector3> Offset_In, n6.GpuValue<n29.Vector3> Center_In, [n5.SerializedDefaultValueAttribute("0.5, 0.5, 0.5", false)] n6.GpuValue<n29.Vector3> Bias_In, n7.NoiseBasisInflection Inflection_In, [n5.SerializedDefaultValueAttribute("GradientNoise", false)] n8.NoiseType Noise_Type_In, out n6.GpuValue<n29.Vector3> Output_Out)
        {
            bool __pad_RQrTi6Sh0wDNlzx3QvhPnp_0 = __slot_RQrTi6Sh0wDNlzx3QvhPnp;
            n32.ObjectHelpers.IsAssigned(x: Time_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_EicZ2DZjJlRLXPfKpgTo4q;
            if (manager_4 is null)
            {
                manager_4 = new n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n3.ValueTuple<n6.GpuValue<n29.Vector3>, n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<n29.Vector3>>>(n3.ValueTuple.Create(default(n6.GpuValue<n29.Vector3>)));
            }

            var inputs_5 = (Result_1, TDomain_In, Time_In, Frequency_In, Amplitude_In, Offset_In, Center_In, Bias_In, Inflection_In, Noise_Type_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = __pad_RQrTi6Sh0wDNlzx3QvhPnp_0 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n2.CompilationHelper.Restore<__MwWmToIwG7gNMdo7hTFPrB>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __MwWmToIwG7gNMdo7hTFPrB(__GetContext__(), n2.VLObject.NewIdentity())
                    {__slot_HMTxfvsNJSUPsa0dJJKYhf = default(n6.GpuValue<n29.Vector3>), __slot_KFHmrVF8fyeNozcMjjB3oh = default(n6.GpuValue<n29.Vector4>)};
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "VyCkcG11WxxLAHkk8bnFku", 321212U);
                    var Output_10 = n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector3, n29.Vector3>.Create(Node_Context: Node_Context_9);
                    state_8.__p_VyCkcG11WxxLAHkk8bnFku = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "TURbzUVOpALM3S5eV0iOXn", 321222U);
                    var Output_12 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3>.Create(Node_Context: Node_Context_11);
                    state_8.__p_TURbzUVOpALM3S5eV0iOXn = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "JWOxKuwC66gQJpMxtz7Vcx", 321225U);
                    var Output_14 = n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_13);
                    state_8.__p_JWOxKuwC66gQJpMxtz7Vcx = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "BZyXvVeIF1hMTPqRj0Bg9d", 321231U);
                    var Output_16 = n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector4, n29.Vector3>.Create(Node_Context: Node_Context_15);
                    state_8.__p_BZyXvVeIF1hMTPqRj0Bg9d = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "BIbc06GeHg7QQDtknXCukX", 321246U);
                    var Output_18 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_17);
                    state_8.__p_BIbc06GeHg7QQDtknXCukX = Output_18;
                    n2.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "DR9IJiAwW7jLKcec6agi9j", 321250U);
                    var Output_20 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_19);
                    state_8.__p_DR9IJiAwW7jLKcec6agi9j = Output_20;
                    n2.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "HutesfPRhFHNvJapP9Ohv3", 321254U);
                    var Output_22 = n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<n29.Vector3>.Create(Node_Context: Node_Context_21);
                    state_8.__p_HutesfPRhFHNvJapP9Ohv3 = Output_22;
                    n2.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "PofsoAPmSykNWNA4L5SyMA", 321258U);
                    var Output_24 = n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_23);
                    state_8.__p_PofsoAPmSykNWNA4L5SyMA = Output_24;
                    n2.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "EKA4uJ2LougMimsvNNn6Gk", 321262U);
                    var Output_26 = n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_25);
                    state_8.__p_EKA4uJ2LougMimsvNNn6Gk = Output_26;
                    n40._Operations_.Noise3DVectorID(Output_Out: out string Output_27);
                    n2.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Pg9N8zNiPVZNhXdg083BIi", 321266U);
                    var Output_29 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_28, ID_In: Output_27);
                    state_8.__p_Pg9N8zNiPVZNhXdg083BIi = Output_29;
                }

                float __pad_COjAaJrdO5fQSfQ5gbWakt_30 = __slot_COjAaJrdO5fQSfQ5gbWakt;
                float __pad_H9F3RDEWDFVN2flKYfzT3H_31 = __slot_H9F3RDEWDFVN2flKYfzT3H;
                int Id_32 = 0;
                var State_Output_34 = state_8.__p_TURbzUVOpALM3S5eV0iOXn.Update(The_Override_In: TDomain_In, Id_In: Id_32, Output_Out: out n6.GpuValue<n29.Vector3> Output_33);
                n6.GpuValue<n29.Vector3> __pad_HMTxfvsNJSUPsa0dJJKYhf_35 = Output_33;
                n6.GpuValue<n29.Vector3> default_36 = default(n6.GpuValue<n29.Vector3>);
                var State_Output_38 = state_8.__p_VyCkcG11WxxLAHkk8bnFku.Update<n27.__AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW>(TDomain_In: __pad_HMTxfvsNJSUPsa0dJJKYhf_35, Frequency_In: Frequency_In, Amplitude_In: Amplitude_In, Offset_In: Offset_In, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: Inflection_In, Noise_Type_In: Noise_Type_In, default_In: default_36, Output_Out: out n6.GpuValue<n29.Vector3> Output_37);
                var State_Output_40 = state_8.__p_JWOxKuwC66gQJpMxtz7Vcx.Update(xyz_In: Output_33, w_In: Time_In, Output_Out: out n6.GpuValue<n29.Vector4> Output_39);
                n6.GpuValue<n29.Vector4> __pad_KFHmrVF8fyeNozcMjjB3oh_41 = Output_39;
                float The_Value_42 = 1F;
                var State_Output_44 = state_8.__p_HutesfPRhFHNvJapP9Ohv3.Update(GpuValue_In: Frequency_In, The_Value_In: The_Value_42, Output_Out: out n6.GpuValue<n29.Vector3> Output_43);
                var Output_46 = state_8.__p_BIbc06GeHg7QQDtknXCukX.Update(Value_In: __pad_COjAaJrdO5fQSfQ5gbWakt_30, GpuValue_Out: out n6.GpuValue<float> GpuValue_45);
                var State_Output_48 = state_8.__p_PofsoAPmSykNWNA4L5SyMA.Update(xyz_In: Output_43, w_In: GpuValue_45, Output_Out: out n6.GpuValue<n29.Vector4> Output_47);
                var Output_50 = state_8.__p_DR9IJiAwW7jLKcec6agi9j.Update(Value_In: __pad_H9F3RDEWDFVN2flKYfzT3H_31, GpuValue_Out: out n6.GpuValue<float> GpuValue_49);
                var State_Output_52 = state_8.__p_EKA4uJ2LougMimsvNNn6Gk.Update(xyz_In: Offset_In, w_In: GpuValue_49, Output_Out: out n6.GpuValue<n29.Vector4> Output_51);
                n6.GpuValue<n29.Vector3> default_53 = default(n6.GpuValue<n29.Vector3>);
                var State_Output_55 = state_8.__p_BZyXvVeIF1hMTPqRj0Bg9d.Update<n27.__AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW>(TDomain_In: __pad_KFHmrVF8fyeNozcMjjB3oh_41, Frequency_In: Output_47, Amplitude_In: Amplitude_In, Offset_In: Output_51, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: Inflection_In, Noise_Type_In: Noise_Type_In, default_In: default_53, Output_Out: out n6.GpuValue<n29.Vector3> Output_54);
                n37._Operations_.Switch_Boolean<n6.GpuValue<n29.Vector3>>(Condition_In: Result_1, Input_In: Output_37, Input_2_In: Output_54, Output_Out: out n6.GpuValue<n29.Vector3> Output_56);
                bool Update_57 = true;
                var Output_58 = state_8.__p_Pg9N8zNiPVZNhXdg083BIi;
                if (Update_57)
                {
                    Output_58 = state_8.__p_Pg9N8zNiPVZNhXdg083BIi.Update(Input_In: Output_56);
                }

                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_34 != state_8.__p_TURbzUVOpALM3S5eV0iOXn || Output_33 != state_8.__slot_HMTxfvsNJSUPsa0dJJKYhf || State_Output_38 != state_8.__p_VyCkcG11WxxLAHkk8bnFku || State_Output_40 != state_8.__p_JWOxKuwC66gQJpMxtz7Vcx || Output_39 != state_8.__slot_KFHmrVF8fyeNozcMjjB3oh || State_Output_44 != state_8.__p_HutesfPRhFHNvJapP9Ohv3 || Output_46 != state_8.__p_BIbc06GeHg7QQDtknXCukX || State_Output_48 != state_8.__p_PofsoAPmSykNWNA4L5SyMA || Output_50 != state_8.__p_DR9IJiAwW7jLKcec6agi9j || State_Output_52 != state_8.__p_EKA4uJ2LougMimsvNNn6Gk || State_Output_55 != state_8.__p_BZyXvVeIF1hMTPqRj0Bg9d || Output_58 != state_8.__p_Pg9N8zNiPVZNhXdg083BIi ? new __MwWmToIwG7gNMdo7hTFPrB(state_8)
                    {__p_TURbzUVOpALM3S5eV0iOXn = State_Output_34, __slot_HMTxfvsNJSUPsa0dJJKYhf = Output_33, __p_VyCkcG11WxxLAHkk8bnFku = State_Output_38, __p_JWOxKuwC66gQJpMxtz7Vcx = State_Output_40, __slot_KFHmrVF8fyeNozcMjjB3oh = Output_39, __p_HutesfPRhFHNvJapP9Ohv3 = State_Output_44, __p_BIbc06GeHg7QQDtknXCukX = Output_46, __p_PofsoAPmSykNWNA4L5SyMA = State_Output_48, __p_DR9IJiAwW7jLKcec6agi9j = Output_50, __p_EKA4uJ2LougMimsvNNn6Gk = State_Output_52, __p_BZyXvVeIF1hMTPqRj0Bg9d = State_Output_55, __p_Pg9N8zNiPVZNhXdg083BIi = Output_58} : state_8;
                else
                {
                    state_8.__p_TURbzUVOpALM3S5eV0iOXn = State_Output_34;
                    state_8.__slot_HMTxfvsNJSUPsa0dJJKYhf = Output_33;
                    state_8.__p_VyCkcG11WxxLAHkk8bnFku = State_Output_38;
                    state_8.__p_JWOxKuwC66gQJpMxtz7Vcx = State_Output_40;
                    state_8.__slot_KFHmrVF8fyeNozcMjjB3oh = Output_39;
                    state_8.__p_HutesfPRhFHNvJapP9Ohv3 = State_Output_44;
                    state_8.__p_BIbc06GeHg7QQDtknXCukX = Output_46;
                    state_8.__p_PofsoAPmSykNWNA4L5SyMA = State_Output_48;
                    state_8.__p_DR9IJiAwW7jLKcec6agi9j = Output_50;
                    state_8.__p_EKA4uJ2LougMimsvNNn6Gk = State_Output_52;
                    state_8.__p_BZyXvVeIF1hMTPqRj0Bg9d = State_Output_55;
                    state_8.__p_Pg9N8zNiPVZNhXdg083BIi = Output_58;
                }

                outputs_6 = n3.ValueTuple.Create(Output_56);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_59 = outputs_6.Item1;
            Output_Out = __auto_59;
            n4.Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x that_60 = this;
            if (this.__GetContext__().IsImmutable)
                that_60 = manager_4 != this.__cache_EicZ2DZjJlRLXPfKpgTo4q ? new Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x(this)
                {__cache_EicZ2DZjJlRLXPfKpgTo4q = manager_4} : that_60;
            else
            {
                this.__cache_EicZ2DZjJlRLXPfKpgTo4q = manager_4;
            }

            return that_60;
        }

        public n4.Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x that_0 = this;
            this.__cache_EicZ2DZjJlRLXPfKpgTo4q = null;
            return that_0;
        }

        public n4.Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x __CreateDefault__()
        {
            n4.Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x that_0 = this;
            this.__cache_EicZ2DZjJlRLXPfKpgTo4q = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_EicZ2DZjJlRLXPfKpgTo4q);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 321285U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RQrTi6Sh0wDNlzx3QvhPnp", Name = "__slot_RQrTi6Sh0wDNlzx3QvhPnp")]
        public static bool __slot_RQrTi6Sh0wDNlzx3QvhPnp = false;
        [n2.ElementAttribute(TracingId = 321194U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "EicZ2DZjJlRLXPfKpgTo4q", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n3.ValueTuple<n6.GpuValue<n29.Vector3>, n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<n29.Vector3>>> __cache_EicZ2DZjJlRLXPfKpgTo4q = null;
        [n2.ElementAttribute(TracingId = 321249U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "COjAaJrdO5fQSfQ5gbWakt", Name = "__slot_COjAaJrdO5fQSfQ5gbWakt")]
        public static float __slot_COjAaJrdO5fQSfQ5gbWakt = 1F;
        [n2.ElementAttribute(TracingId = 321253U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "H9F3RDEWDFVN2flKYfzT3H", Name = "__slot_H9F3RDEWDFVN2flKYfzT3H")]
        public static float __slot_H9F3RDEWDFVN2flKYfzT3H = 0F;
        static Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x()
        {
        }

        public Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x(Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x other): base(other)
        {
            this.__cache_EicZ2DZjJlRLXPfKpgTo4q = other.__cache_EicZ2DZjJlRLXPfKpgTo4q;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_EicZ2DZjJlRLXPfKpgTo4q", in __cache_EicZ2DZjJlRLXPfKpgTo4q));
        }

        internal Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x __WITH__(n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n3.ValueTuple<n6.GpuValue<n29.Vector3>, n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<n29.Vector3>>> __cache_EicZ2DZjJlRLXPfKpgTo4q)
        {
            n4.Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_EicZ2DZjJlRLXPfKpgTo4q != this.__cache_EicZ2DZjJlRLXPfKpgTo4q ? new Noise__3D_Vector_IfMa5FzLvMkLUTUBn5nO6x(this)
                {__cache_EicZ2DZjJlRLXPfKpgTo4q = __cache_EicZ2DZjJlRLXPfKpgTo4q} : that_0;
            else
            {
                this.__cache_EicZ2DZjJlRLXPfKpgTo4q = __cache_EicZ2DZjJlRLXPfKpgTo4q;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "MwWmToIwG7gNMdo7hTFPrB", Name = "__MwWmToIwG7gNMdo7hTFPrB")]
        [n3.SerializableAttribute]
        public class __MwWmToIwG7gNMdo7hTFPrB : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_VyCkcG11WxxLAHkk8bnFku);
                n2.CompilationHelper.SafeDispose(this.__p_TURbzUVOpALM3S5eV0iOXn);
                n2.CompilationHelper.SafeDispose(this.__p_JWOxKuwC66gQJpMxtz7Vcx);
                n2.CompilationHelper.SafeDispose(this.__p_BZyXvVeIF1hMTPqRj0Bg9d);
                n2.CompilationHelper.SafeDispose(this.__p_BIbc06GeHg7QQDtknXCukX);
                n2.CompilationHelper.SafeDispose(this.__p_DR9IJiAwW7jLKcec6agi9j);
                n2.CompilationHelper.SafeDispose(this.__p_HutesfPRhFHNvJapP9Ohv3);
                n2.CompilationHelper.SafeDispose(this.__p_PofsoAPmSykNWNA4L5SyMA);
                n2.CompilationHelper.SafeDispose(this.__p_EKA4uJ2LougMimsvNNn6Gk);
                n2.CompilationHelper.SafeDispose(this.__p_Pg9N8zNiPVZNhXdg083BIi);
                return;
            }

            [n2.ElementAttribute(TracingId = 321212U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "VyCkcG11WxxLAHkk8bnFku", Name = "Noise", IsManaged = true, IsAutoGenerated = true)]
            public n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector3, n29.Vector3> __p_VyCkcG11WxxLAHkk8bnFku;
            [n2.ElementAttribute(TracingId = 321222U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "TURbzUVOpALM3S5eV0iOXn", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3> __p_TURbzUVOpALM3S5eV0iOXn;
            [n2.ElementAttribute(TracingId = 321225U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "JWOxKuwC66gQJpMxtz7Vcx", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_JWOxKuwC66gQJpMxtz7Vcx;
            [n2.ElementAttribute(TracingId = 321231U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BZyXvVeIF1hMTPqRj0Bg9d", Name = "Noise", IsManaged = true, IsAutoGenerated = true)]
            public n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector4, n29.Vector3> __p_BZyXvVeIF1hMTPqRj0Bg9d;
            [n2.ElementAttribute(TracingId = 321246U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BIbc06GeHg7QQDtknXCukX", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_BIbc06GeHg7QQDtknXCukX;
            [n2.ElementAttribute(TracingId = 321250U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "DR9IJiAwW7jLKcec6agi9j", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_DR9IJiAwW7jLKcec6agi9j;
            [n2.ElementAttribute(TracingId = 321254U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HutesfPRhFHNvJapP9Ohv3", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<n29.Vector3> __p_HutesfPRhFHNvJapP9Ohv3;
            [n2.ElementAttribute(TracingId = 321258U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "PofsoAPmSykNWNA4L5SyMA", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_PofsoAPmSykNWNA4L5SyMA;
            [n2.ElementAttribute(TracingId = 321262U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "EKA4uJ2LougMimsvNNn6Gk", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_EKA4uJ2LougMimsvNNn6Gk;
            [n2.ElementAttribute(TracingId = 321266U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Pg9N8zNiPVZNhXdg083BIi", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Pg9N8zNiPVZNhXdg083BIi;
            [n2.ElementAttribute(TracingId = 321229U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HMTxfvsNJSUPsa0dJJKYhf", Name = "__slot_HMTxfvsNJSUPsa0dJJKYhf")]
            public n6.GpuValue<n29.Vector3> __slot_HMTxfvsNJSUPsa0dJJKYhf;
            [n2.ElementAttribute(TracingId = 321230U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "KFHmrVF8fyeNozcMjjB3oh", Name = "__slot_KFHmrVF8fyeNozcMjjB3oh")]
            public n6.GpuValue<n29.Vector4> __slot_KFHmrVF8fyeNozcMjjB3oh;
            public __MwWmToIwG7gNMdo7hTFPrB(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MwWmToIwG7gNMdo7hTFPrB(__MwWmToIwG7gNMdo7hTFPrB other): base(other)
            {
                this.__p_VyCkcG11WxxLAHkk8bnFku = other.__p_VyCkcG11WxxLAHkk8bnFku;
                this.__p_TURbzUVOpALM3S5eV0iOXn = other.__p_TURbzUVOpALM3S5eV0iOXn;
                this.__p_JWOxKuwC66gQJpMxtz7Vcx = other.__p_JWOxKuwC66gQJpMxtz7Vcx;
                this.__p_BZyXvVeIF1hMTPqRj0Bg9d = other.__p_BZyXvVeIF1hMTPqRj0Bg9d;
                this.__p_BIbc06GeHg7QQDtknXCukX = other.__p_BIbc06GeHg7QQDtknXCukX;
                this.__p_DR9IJiAwW7jLKcec6agi9j = other.__p_DR9IJiAwW7jLKcec6agi9j;
                this.__p_HutesfPRhFHNvJapP9Ohv3 = other.__p_HutesfPRhFHNvJapP9Ohv3;
                this.__p_PofsoAPmSykNWNA4L5SyMA = other.__p_PofsoAPmSykNWNA4L5SyMA;
                this.__p_EKA4uJ2LougMimsvNNn6Gk = other.__p_EKA4uJ2LougMimsvNNn6Gk;
                this.__p_Pg9N8zNiPVZNhXdg083BIi = other.__p_Pg9N8zNiPVZNhXdg083BIi;
                this.__slot_HMTxfvsNJSUPsa0dJJKYhf = other.__slot_HMTxfvsNJSUPsa0dJJKYhf;
                this.__slot_KFHmrVF8fyeNozcMjjB3oh = other.__slot_KFHmrVF8fyeNozcMjjB3oh;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_VyCkcG11WxxLAHkk8bnFku", in __p_VyCkcG11WxxLAHkk8bnFku), n2.CompilationHelper.GetValueOrExisting(values, "__p_TURbzUVOpALM3S5eV0iOXn", in __p_TURbzUVOpALM3S5eV0iOXn), n2.CompilationHelper.GetValueOrExisting(values, "__p_JWOxKuwC66gQJpMxtz7Vcx", in __p_JWOxKuwC66gQJpMxtz7Vcx), n2.CompilationHelper.GetValueOrExisting(values, "__p_BZyXvVeIF1hMTPqRj0Bg9d", in __p_BZyXvVeIF1hMTPqRj0Bg9d), n2.CompilationHelper.GetValueOrExisting(values, "__p_BIbc06GeHg7QQDtknXCukX", in __p_BIbc06GeHg7QQDtknXCukX), n2.CompilationHelper.GetValueOrExisting(values, "__p_DR9IJiAwW7jLKcec6agi9j", in __p_DR9IJiAwW7jLKcec6agi9j), n2.CompilationHelper.GetValueOrExisting(values, "__p_HutesfPRhFHNvJapP9Ohv3", in __p_HutesfPRhFHNvJapP9Ohv3), n2.CompilationHelper.GetValueOrExisting(values, "__p_PofsoAPmSykNWNA4L5SyMA", in __p_PofsoAPmSykNWNA4L5SyMA), n2.CompilationHelper.GetValueOrExisting(values, "__p_EKA4uJ2LougMimsvNNn6Gk", in __p_EKA4uJ2LougMimsvNNn6Gk), n2.CompilationHelper.GetValueOrExisting(values, "__p_Pg9N8zNiPVZNhXdg083BIi", in __p_Pg9N8zNiPVZNhXdg083BIi), n2.CompilationHelper.GetValueOrExisting(values, "__slot_HMTxfvsNJSUPsa0dJJKYhf", in __slot_HMTxfvsNJSUPsa0dJJKYhf), n2.CompilationHelper.GetValueOrExisting(values, "__slot_KFHmrVF8fyeNozcMjjB3oh", in __slot_KFHmrVF8fyeNozcMjjB3oh));
            }

            internal __MwWmToIwG7gNMdo7hTFPrB __WITH__(n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector3, n29.Vector3> __p_VyCkcG11WxxLAHkk8bnFku, n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3> __p_TURbzUVOpALM3S5eV0iOXn, n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_JWOxKuwC66gQJpMxtz7Vcx, n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector4, n29.Vector3> __p_BZyXvVeIF1hMTPqRj0Bg9d, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_BIbc06GeHg7QQDtknXCukX, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_DR9IJiAwW7jLKcec6agi9j, n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<n29.Vector3> __p_HutesfPRhFHNvJapP9Ohv3, n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_PofsoAPmSykNWNA4L5SyMA, n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_EKA4uJ2LougMimsvNNn6Gk, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Pg9N8zNiPVZNhXdg083BIi, n6.GpuValue<n29.Vector3> __slot_HMTxfvsNJSUPsa0dJJKYhf, n6.GpuValue<n29.Vector4> __slot_KFHmrVF8fyeNozcMjjB3oh)
            {
                __MwWmToIwG7gNMdo7hTFPrB that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_VyCkcG11WxxLAHkk8bnFku != this.__p_VyCkcG11WxxLAHkk8bnFku || __p_TURbzUVOpALM3S5eV0iOXn != this.__p_TURbzUVOpALM3S5eV0iOXn || __p_JWOxKuwC66gQJpMxtz7Vcx != this.__p_JWOxKuwC66gQJpMxtz7Vcx || __p_BZyXvVeIF1hMTPqRj0Bg9d != this.__p_BZyXvVeIF1hMTPqRj0Bg9d || __p_BIbc06GeHg7QQDtknXCukX != this.__p_BIbc06GeHg7QQDtknXCukX || __p_DR9IJiAwW7jLKcec6agi9j != this.__p_DR9IJiAwW7jLKcec6agi9j || __p_HutesfPRhFHNvJapP9Ohv3 != this.__p_HutesfPRhFHNvJapP9Ohv3 || __p_PofsoAPmSykNWNA4L5SyMA != this.__p_PofsoAPmSykNWNA4L5SyMA || __p_EKA4uJ2LougMimsvNNn6Gk != this.__p_EKA4uJ2LougMimsvNNn6Gk || __p_Pg9N8zNiPVZNhXdg083BIi != this.__p_Pg9N8zNiPVZNhXdg083BIi || __slot_HMTxfvsNJSUPsa0dJJKYhf != this.__slot_HMTxfvsNJSUPsa0dJJKYhf || __slot_KFHmrVF8fyeNozcMjjB3oh != this.__slot_KFHmrVF8fyeNozcMjjB3oh ? new __MwWmToIwG7gNMdo7hTFPrB(this)
                    {__p_VyCkcG11WxxLAHkk8bnFku = __p_VyCkcG11WxxLAHkk8bnFku, __p_TURbzUVOpALM3S5eV0iOXn = __p_TURbzUVOpALM3S5eV0iOXn, __p_JWOxKuwC66gQJpMxtz7Vcx = __p_JWOxKuwC66gQJpMxtz7Vcx, __p_BZyXvVeIF1hMTPqRj0Bg9d = __p_BZyXvVeIF1hMTPqRj0Bg9d, __p_BIbc06GeHg7QQDtknXCukX = __p_BIbc06GeHg7QQDtknXCukX, __p_DR9IJiAwW7jLKcec6agi9j = __p_DR9IJiAwW7jLKcec6agi9j, __p_HutesfPRhFHNvJapP9Ohv3 = __p_HutesfPRhFHNvJapP9Ohv3, __p_PofsoAPmSykNWNA4L5SyMA = __p_PofsoAPmSykNWNA4L5SyMA, __p_EKA4uJ2LougMimsvNNn6Gk = __p_EKA4uJ2LougMimsvNNn6Gk, __p_Pg9N8zNiPVZNhXdg083BIi = __p_Pg9N8zNiPVZNhXdg083BIi, __slot_HMTxfvsNJSUPsa0dJJKYhf = __slot_HMTxfvsNJSUPsa0dJJKYhf, __slot_KFHmrVF8fyeNozcMjjB3oh = __slot_KFHmrVF8fyeNozcMjjB3oh} : that_0;
                else
                {
                    this.__p_VyCkcG11WxxLAHkk8bnFku = __p_VyCkcG11WxxLAHkk8bnFku;
                    this.__p_TURbzUVOpALM3S5eV0iOXn = __p_TURbzUVOpALM3S5eV0iOXn;
                    this.__p_JWOxKuwC66gQJpMxtz7Vcx = __p_JWOxKuwC66gQJpMxtz7Vcx;
                    this.__p_BZyXvVeIF1hMTPqRj0Bg9d = __p_BZyXvVeIF1hMTPqRj0Bg9d;
                    this.__p_BIbc06GeHg7QQDtknXCukX = __p_BIbc06GeHg7QQDtknXCukX;
                    this.__p_DR9IJiAwW7jLKcec6agi9j = __p_DR9IJiAwW7jLKcec6agi9j;
                    this.__p_HutesfPRhFHNvJapP9Ohv3 = __p_HutesfPRhFHNvJapP9Ohv3;
                    this.__p_PofsoAPmSykNWNA4L5SyMA = __p_PofsoAPmSykNWNA4L5SyMA;
                    this.__p_EKA4uJ2LougMimsvNNn6Gk = __p_EKA4uJ2LougMimsvNNn6Gk;
                    this.__p_Pg9N8zNiPVZNhXdg083BIi = __p_Pg9N8zNiPVZNhXdg083BIi;
                    this.__slot_HMTxfvsNJSUPsa0dJJKYhf = __slot_HMTxfvsNJSUPsa0dJJKYhf;
                    this.__slot_KFHmrVF8fyeNozcMjjB3oh = __slot_KFHmrVF8fyeNozcMjjB3oh;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 321371U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "L8SAX5bxsDPOkoK6qK5FDb", Name = "NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb")]
    [n3.SerializableAttribute]
    public class NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb Create(n2.NodeContext Node_Context)
        {
            var instance = new NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb CreateDefault()
        {
            var instance = new NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb Update(n6.GpuValue<n29.Vector3> TDomain_In, n6.GpuValue<n29.Vector3> Frequency_In, n6.GpuValue<float> Amplitude_In, n6.GpuValue<n29.Vector3> Offset_In, n6.GpuValue<float> Center_In, [n5.SerializedDefaultValueAttribute("GradientNoise", false)] n7.NoiseBasisType Noise_Type_In, out n6.GpuValue<float> Output_Out, out n6.GpuValue<n29.Vector3> Gradient_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_Csc0Q5oSfcsPNf8EOGzw2r;
            if (manager_2 is null)
            {
                manager_2 = new n9.Manager<n3.ValueTuple<n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<float>, n7.NoiseBasisType>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<n29.Vector3>>>((default(n6.GpuValue<float>), default(n6.GpuValue<n29.Vector3>)));
            }

            var inputs_3 = (TDomain_In, Frequency_In, Offset_In, Amplitude_In, Center_In, Noise_Type_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n2.CompilationHelper.Restore<__KQIvkyBRNV7PN501mLnieq>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __KQIvkyBRNV7PN501mLnieq(__GetContext__(), n2.VLObject.NewIdentity())
                    {__slot_NE5HikpUQKkONtT0oxhnLB = default(n7.NoiseBasisType), __slot_T4j5ED1W9jcQSdssHuh8H8 = "", __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2 = n16._Operations_.CreateDefault<n6.AbstractGpuValue>(), __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx = n16._Operations_.CreateDefault<n6.GpuValue<n29.Vector4>>(), __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS = n16._Operations_.CreateDefault<n6.GpuValue<float>>()};
                    n2.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "HppTIT7HVaPLd6yhA5gCGH", 321390U);
                    var Output_8 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3>.Create(Node_Context: Node_Context_7);
                    state_6.__p_HppTIT7HVaPLd6yhA5gCGH = Output_8;
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "NZQM7WuZGdVM1HuEVvKnzk", 321399U);
                    var Output_10 = n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<n29.Vector3>.Create(Node_Context: Node_Context_9);
                    state_6.__p_NZQM7WuZGdVM1HuEVvKnzk = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "R7XU2Qkpn2fMnBuokFXtSB", 321405U);
                    var Output_12 = n41.Swizzle_DwOc96VdFLlOotWwxmIY1P<n29.Vector4, float>.Create(Node_Context: Node_Context_11);
                    state_6.__p_R7XU2Qkpn2fMnBuokFXtSB = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "NtraOQXtk2fNknrL8N8RXt", 321409U);
                    var Output_14 = n41.Swizzle_DwOc96VdFLlOotWwxmIY1P<n29.Vector4, n29.Vector3>.Create(Node_Context: Node_Context_13);
                    state_6.__p_NtraOQXtk2fNknrL8N8RXt = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "McBjtUxeF04OEj39LRLvbx", 321413U);
                    var Output_16 = n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n29.Vector4>.Create(Node_Context: Node_Context_15);
                    state_6.__p_McBjtUxeF04OEj39LRLvbx = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "TCsaeRTzXg4OgafIKDSPWp", 321417U);
                    var Output_18 = n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, n29.Vector4>.Create(Node_Context: Node_Context_17);
                    state_6.__p_TCsaeRTzXg4OgafIKDSPWp = Output_18;
                    n2.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Mo4GN6uV1h7Pl0pRCHlDXS", 321421U);
                    var Output_20 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float>.Create(Node_Context: Node_Context_19);
                    state_6.__p_Mo4GN6uV1h7Pl0pRCHlDXS = Output_20;
                    n2.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "FnrG3eMV0JsO9uTiRxxTm2", 321427U);
                    var Output_22 = n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n29.Vector4>.Create(Node_Context: Node_Context_21);
                    state_6.__p_FnrG3eMV0JsO9uTiRxxTm2 = Output_22;
                    n2.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "HDatOwF8D9FOPpfvovc5dS", 321434U);
                    var Output_24 = n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5.Create(Node_Context: Node_Context_23);
                    state_6.__p_HDatOwF8D9FOPpfvovc5dS = Output_24;
                    n42._Operations_.Noise3DGradientID(Output_Out: out string Output_25);
                    n2.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "BhOfhsbVExYLsiaXvJzb9d", 321439U);
                    var Output_27 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_26, ID_In: Output_25);
                    state_6.__p_BhOfhsbVExYLsiaXvJzb9d = Output_27;
                    n42._Operations_.Noise3DGradientGradID(Output_Out: out string Output_28);
                    n2.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "PgCWFiMDRq2NyJ5GDy0Sia", 321442U);
                    var Output_30 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_29, ID_In: Output_28);
                    state_6.__p_PgCWFiMDRq2NyJ5GDy0Sia = Output_30;
                }

                string __pad_R3OqhzC4LgfMia6sv7VOt6_31 = __slot_R3OqhzC4LgfMia6sv7VOt6;
                string __pad_TkReiSSvUU7LRSzykv7hom_32 = __slot_TkReiSSvUU7LRSzykv7hom;
                n15.Spread<string> __pad_I5ipEqJwsqjLdpWkeKUvPd_33 = __slot_I5ipEqJwsqjLdpWkeKUvPd;
                int Id_34 = 0;
                var State_Output_36 = state_6.__p_HppTIT7HVaPLd6yhA5gCGH.Update(The_Override_In: TDomain_In, Id_In: Id_34, Output_Out: out n6.GpuValue<n29.Vector3> Output_35);
                var State_Output_38 = state_6.__p_NZQM7WuZGdVM1HuEVvKnzk.Update(Value_In: Output_35, Scale_In: Frequency_In, Add_In: Offset_In, Output_Out: out n6.GpuValue<n29.Vector3> Output_37);
                n7.NoiseBasisType __pad_NE5HikpUQKkONtT0oxhnLB_39 = Noise_Type_In;
                int Index_40 = (int)__pad_NE5HikpUQKkONtT0oxhnLB_39;
                string Default_Value_41 = "";
                n16._Operations_.GetSlice<string>(Input_In: __pad_I5ipEqJwsqjLdpWkeKUvPd_33, Default_Value_In: Default_Value_41, Index_In: Index_40, Result_Out: out string Result_42);
                string __pad_T4j5ED1W9jcQSdssHuh8H8_43 = Result_42;
                var Output_45 = state_6.__p_HDatOwF8D9FOPpfvovc5dS.Update(Singleton_Out: out string Singleton_44);
                n6.GpuValue<n29.Vector4> Default_46 = default(n6.GpuValue<n29.Vector4>);
                bool Is_Groupable_47 = false;
                n17.IEnumerable<n6.InputModifier> The_Modifiers_48 = n22._Operations_.CreateDefault<n6.InputModifier>();
                var builder_49 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2, 1);
                builder_49.Add(Output_37);
                var __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2_50 = builder_49.Commit();
                var State_Output_53 = state_6.__p_FnrG3eMV0JsO9uTiRxxTm2.Update(Arguments_In: __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2_50, Function_Name_In: __pad_T4j5ED1W9jcQSdssHuh8H8_43, Default_In: Default_46, Mixins_In: Singleton_44, Is_Groupable_In: Is_Groupable_47, The_Modifiers_In: The_Modifiers_48, Output_Out: out n6.GpuValue<n29.Vector4> Output_51, Additional_Outputs_Out: out n15.Spread<n6.AbstractGpuValue> Additional_Outputs_52);
                n26._Operations_.TypeVector4(Input_In: Output_51, Output_Out: out n6.GpuValue<n29.Vector4> Output_54);
                n6.GpuValue<n29.Vector4> default_55 = default(n6.GpuValue<n29.Vector4>);
                var State_Output_57 = state_6.__p_TCsaeRTzXg4OgafIKDSPWp.Update(x_In: Amplitude_In, default_In: default_55, Output_Out: out n6.GpuValue<n29.Vector4> Output_56);
                var builder_58 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_McBjtUxeF04OEj39LRLvbx, 2);
                builder_58.Add(Output_54);
                builder_58.Add(Output_56);
                var __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx_59 = builder_58.Commit();
                var State_Output_61 = state_6.__p_McBjtUxeF04OEj39LRLvbx.Update(Input_In: __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx_59, Output_Out: out n6.GpuValue<n29.Vector4> Output_60);
                int TypeDimension_62 = 1;
                float Default_63 = 0F;
                bool Update_64 = true;
                var Output_65 = state_6.__p_NtraOQXtk2fNknrL8N8RXt;
                if (Update_64)
                {
                    Output_65 = state_6.__p_NtraOQXtk2fNknrL8N8RXt.Update(Input_In: Output_60, TypeDimension_In: TypeDimension_62, Default_In: Default_63, The_Member_In: __pad_R3OqhzC4LgfMia6sv7VOt6_31);
                }

                var State_Output_67 = Output_65.GetOutput(Output_Out: out n6.GpuValue<n29.Vector3> Output_66);
                int TypeDimension_68 = 1;
                float Default_69 = 0F;
                bool Update_70 = true;
                var Output_71 = state_6.__p_R7XU2Qkpn2fMnBuokFXtSB;
                if (Update_70)
                {
                    Output_71 = state_6.__p_R7XU2Qkpn2fMnBuokFXtSB.Update(Input_In: Output_60, TypeDimension_In: TypeDimension_68, Default_In: Default_69, The_Member_In: __pad_TkReiSSvUU7LRSzykv7hom_32);
                }

                var State_Output_73 = Output_71.GetOutput(Output_Out: out n6.GpuValue<float> Output_72);
                var builder_74 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS, 2);
                builder_74.Add(Output_72);
                builder_74.Add(Center_In);
                var __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS_75 = builder_74.Commit();
                var State_Output_77 = state_6.__p_Mo4GN6uV1h7Pl0pRCHlDXS.Update(Input_In: __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS_75, Output_Out: out n6.GpuValue<float> Output_76);
                bool Update_78 = true;
                var Output_79 = state_6.__p_BhOfhsbVExYLsiaXvJzb9d;
                if (Update_78)
                {
                    Output_79 = state_6.__p_BhOfhsbVExYLsiaXvJzb9d.Update(Input_In: Output_76);
                }

                bool Update_80 = true;
                var Output_81 = state_6.__p_PgCWFiMDRq2NyJ5GDy0Sia;
                if (Update_80)
                {
                    Output_81 = state_6.__p_PgCWFiMDRq2NyJ5GDy0Sia.Update(Input_In: Output_66);
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_36 != state_6.__p_HppTIT7HVaPLd6yhA5gCGH || State_Output_38 != state_6.__p_NZQM7WuZGdVM1HuEVvKnzk || !n17.EqualityComparer<n7.NoiseBasisType>.Default.Equals(Noise_Type_In, state_6.__slot_NE5HikpUQKkONtT0oxhnLB) || Result_42 != state_6.__slot_T4j5ED1W9jcQSdssHuh8H8 || Output_45 != state_6.__p_HDatOwF8D9FOPpfvovc5dS || __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2_50 != state_6.__pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2 || State_Output_53 != state_6.__p_FnrG3eMV0JsO9uTiRxxTm2 || State_Output_57 != state_6.__p_TCsaeRTzXg4OgafIKDSPWp || __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx_59 != state_6.__pin_group_Input_In_McBjtUxeF04OEj39LRLvbx || State_Output_61 != state_6.__p_McBjtUxeF04OEj39LRLvbx || State_Output_67 != state_6.__p_NtraOQXtk2fNknrL8N8RXt || State_Output_73 != state_6.__p_R7XU2Qkpn2fMnBuokFXtSB || __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS_75 != state_6.__pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS || State_Output_77 != state_6.__p_Mo4GN6uV1h7Pl0pRCHlDXS || Output_79 != state_6.__p_BhOfhsbVExYLsiaXvJzb9d || Output_81 != state_6.__p_PgCWFiMDRq2NyJ5GDy0Sia ? new __KQIvkyBRNV7PN501mLnieq(state_6)
                    {__p_HppTIT7HVaPLd6yhA5gCGH = State_Output_36, __p_NZQM7WuZGdVM1HuEVvKnzk = State_Output_38, __slot_NE5HikpUQKkONtT0oxhnLB = Noise_Type_In, __slot_T4j5ED1W9jcQSdssHuh8H8 = Result_42, __p_HDatOwF8D9FOPpfvovc5dS = Output_45, __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2 = __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2_50, __p_FnrG3eMV0JsO9uTiRxxTm2 = State_Output_53, __p_TCsaeRTzXg4OgafIKDSPWp = State_Output_57, __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx = __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx_59, __p_McBjtUxeF04OEj39LRLvbx = State_Output_61, __p_NtraOQXtk2fNknrL8N8RXt = State_Output_67, __p_R7XU2Qkpn2fMnBuokFXtSB = State_Output_73, __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS = __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS_75, __p_Mo4GN6uV1h7Pl0pRCHlDXS = State_Output_77, __p_BhOfhsbVExYLsiaXvJzb9d = Output_79, __p_PgCWFiMDRq2NyJ5GDy0Sia = Output_81} : state_6;
                else
                {
                    state_6.__p_HppTIT7HVaPLd6yhA5gCGH = State_Output_36;
                    state_6.__p_NZQM7WuZGdVM1HuEVvKnzk = State_Output_38;
                    state_6.__slot_NE5HikpUQKkONtT0oxhnLB = Noise_Type_In;
                    state_6.__slot_T4j5ED1W9jcQSdssHuh8H8 = Result_42;
                    state_6.__p_HDatOwF8D9FOPpfvovc5dS = Output_45;
                    state_6.__pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2 = __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2_50;
                    state_6.__p_FnrG3eMV0JsO9uTiRxxTm2 = State_Output_53;
                    state_6.__p_TCsaeRTzXg4OgafIKDSPWp = State_Output_57;
                    state_6.__pin_group_Input_In_McBjtUxeF04OEj39LRLvbx = __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx_59;
                    state_6.__p_McBjtUxeF04OEj39LRLvbx = State_Output_61;
                    state_6.__p_NtraOQXtk2fNknrL8N8RXt = State_Output_67;
                    state_6.__p_R7XU2Qkpn2fMnBuokFXtSB = State_Output_73;
                    state_6.__pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS = __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS_75;
                    state_6.__p_Mo4GN6uV1h7Pl0pRCHlDXS = State_Output_77;
                    state_6.__p_BhOfhsbVExYLsiaXvJzb9d = Output_79;
                    state_6.__p_PgCWFiMDRq2NyJ5GDy0Sia = Output_81;
                }

                outputs_4 = (Output_76, Output_66);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_82, __auto_83) = outputs_4;
            Output_Out = __auto_82;
            Gradient_Out = __auto_83;
            n4.NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb that_84 = this;
            if (this.__GetContext__().IsImmutable)
                that_84 = manager_2 != this.__cache_Csc0Q5oSfcsPNf8EOGzw2r ? new NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb(this)
                {__cache_Csc0Q5oSfcsPNf8EOGzw2r = manager_2} : that_84;
            else
            {
                this.__cache_Csc0Q5oSfcsPNf8EOGzw2r = manager_2;
            }

            return that_84;
        }

        public n4.NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb that_0 = this;
            this.__cache_Csc0Q5oSfcsPNf8EOGzw2r = null;
            return that_0;
        }

        public n4.NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb __CreateDefault__()
        {
            n4.NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb that_0 = this;
            this.__cache_Csc0Q5oSfcsPNf8EOGzw2r = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_Csc0Q5oSfcsPNf8EOGzw2r);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 321374U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Csc0Q5oSfcsPNf8EOGzw2r", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<float>, n7.NoiseBasisType>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<n29.Vector3>>> __cache_Csc0Q5oSfcsPNf8EOGzw2r = null;
        [n2.ElementAttribute(TracingId = 321425U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "R3OqhzC4LgfMia6sv7VOt6", Name = "__slot_R3OqhzC4LgfMia6sv7VOt6")]
        public static string __slot_R3OqhzC4LgfMia6sv7VOt6 = "yzw";
        [n2.ElementAttribute(TracingId = 321426U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "TkReiSSvUU7LRSzykv7hom", Name = "__slot_TkReiSSvUU7LRSzykv7hom")]
        public static string __slot_TkReiSSvUU7LRSzykv7hom = "x";
        [n2.ElementAttribute(TracingId = 321393U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "I5ipEqJwsqjLdpWkeKUvPd", Name = "__slot_I5ipEqJwsqjLdpWkeKUvPd")]
        public static n15.Spread<string> __slot_I5ipEqJwsqjLdpWkeKUvPd = n2.CompilationHelper.Deserialize<n15.Spread<string>>("<Value xmlns=\"property\">\r\n  <Item xmlns=\"\">sineNoiseGrad</Item>\r\n  <Item xmlns=\"\">valueNoiseGrad</Item>\r\n  <Item xmlns=\"\">gradientNoiseGrad</Item>\r\n  <Item xmlns=\"\">simplexNoiseGrad</Item>\r\n  <Item xmlns=\"\">worleySimpleNoiseGrad</Item>\r\n  <Item xmlns=\"\">sineNoiseGrad</Item>\r\n</Value>", true, "THHHRoIOybiP3bK7HRl5JW", "I5ipEqJwsqjLdpWkeKUvPd");
        static NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb()
        {
        }

        public NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb(NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb other): base(other)
        {
            this.__cache_Csc0Q5oSfcsPNf8EOGzw2r = other.__cache_Csc0Q5oSfcsPNf8EOGzw2r;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_Csc0Q5oSfcsPNf8EOGzw2r", in __cache_Csc0Q5oSfcsPNf8EOGzw2r));
        }

        internal NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb __WITH__(n9.Manager<n3.ValueTuple<n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<float>, n7.NoiseBasisType>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<n29.Vector3>>> __cache_Csc0Q5oSfcsPNf8EOGzw2r)
        {
            n4.NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Csc0Q5oSfcsPNf8EOGzw2r != this.__cache_Csc0Q5oSfcsPNf8EOGzw2r ? new NoiseGradient__3D_Scalar_L8SAX5bxsDPOkoK6qK5FDb(this)
                {__cache_Csc0Q5oSfcsPNf8EOGzw2r = __cache_Csc0Q5oSfcsPNf8EOGzw2r} : that_0;
            else
            {
                this.__cache_Csc0Q5oSfcsPNf8EOGzw2r = __cache_Csc0Q5oSfcsPNf8EOGzw2r;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "KQIvkyBRNV7PN501mLnieq", Name = "__KQIvkyBRNV7PN501mLnieq")]
        [n3.SerializableAttribute]
        public class __KQIvkyBRNV7PN501mLnieq : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_HppTIT7HVaPLd6yhA5gCGH);
                n2.CompilationHelper.SafeDispose(this.__p_NZQM7WuZGdVM1HuEVvKnzk);
                n2.CompilationHelper.SafeDispose(this.__p_R7XU2Qkpn2fMnBuokFXtSB);
                n2.CompilationHelper.SafeDispose(this.__p_NtraOQXtk2fNknrL8N8RXt);
                n2.CompilationHelper.SafeDispose(this.__p_McBjtUxeF04OEj39LRLvbx);
                n2.CompilationHelper.SafeDispose(this.__p_TCsaeRTzXg4OgafIKDSPWp);
                n2.CompilationHelper.SafeDispose(this.__p_Mo4GN6uV1h7Pl0pRCHlDXS);
                n2.CompilationHelper.SafeDispose(this.__p_FnrG3eMV0JsO9uTiRxxTm2);
                n2.CompilationHelper.SafeDispose(this.__p_HDatOwF8D9FOPpfvovc5dS);
                n2.CompilationHelper.SafeDispose(this.__p_BhOfhsbVExYLsiaXvJzb9d);
                n2.CompilationHelper.SafeDispose(this.__p_PgCWFiMDRq2NyJ5GDy0Sia);
                return;
            }

            [n2.ElementAttribute(TracingId = 321390U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HppTIT7HVaPLd6yhA5gCGH", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3> __p_HppTIT7HVaPLd6yhA5gCGH;
            [n2.ElementAttribute(TracingId = 321399U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NZQM7WuZGdVM1HuEVvKnzk", Name = "ScaleAndAdd", IsManaged = true, IsAutoGenerated = true)]
            public n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<n29.Vector3> __p_NZQM7WuZGdVM1HuEVvKnzk;
            [n2.ElementAttribute(TracingId = 321405U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "R7XU2Qkpn2fMnBuokFXtSB", Name = "Swizzle", IsManaged = true, IsAutoGenerated = true)]
            public n41.Swizzle_DwOc96VdFLlOotWwxmIY1P<n29.Vector4, float> __p_R7XU2Qkpn2fMnBuokFXtSB;
            [n2.ElementAttribute(TracingId = 321409U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NtraOQXtk2fNknrL8N8RXt", Name = "Swizzle", IsManaged = true, IsAutoGenerated = true)]
            public n41.Swizzle_DwOc96VdFLlOotWwxmIY1P<n29.Vector4, n29.Vector3> __p_NtraOQXtk2fNknrL8N8RXt;
            [n2.ElementAttribute(TracingId = 321413U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "McBjtUxeF04OEj39LRLvbx", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n29.Vector4> __p_McBjtUxeF04OEj39LRLvbx;
            [n2.ElementAttribute(TracingId = 321417U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "TCsaeRTzXg4OgafIKDSPWp", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, n29.Vector4> __p_TCsaeRTzXg4OgafIKDSPWp;
            [n2.ElementAttribute(TracingId = 321421U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Mo4GN6uV1h7Pl0pRCHlDXS", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_Mo4GN6uV1h7Pl0pRCHlDXS;
            [n2.ElementAttribute(TracingId = 321427U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "FnrG3eMV0JsO9uTiRxxTm2", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n29.Vector4> __p_FnrG3eMV0JsO9uTiRxxTm2;
            [n2.ElementAttribute(TracingId = 321434U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HDatOwF8D9FOPpfvovc5dS", Name = "FuseCommonNoise (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 __p_HDatOwF8D9FOPpfvovc5dS;
            [n2.ElementAttribute(TracingId = 321439U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BhOfhsbVExYLsiaXvJzb9d", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_BhOfhsbVExYLsiaXvJzb9d;
            [n2.ElementAttribute(TracingId = 321442U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "PgCWFiMDRq2NyJ5GDy0Sia", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_PgCWFiMDRq2NyJ5GDy0Sia;
            [n2.ElementAttribute(TracingId = 321404U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NE5HikpUQKkONtT0oxhnLB", Name = "__slot_NE5HikpUQKkONtT0oxhnLB")]
            public n7.NoiseBasisType __slot_NE5HikpUQKkONtT0oxhnLB;
            [n2.ElementAttribute(TracingId = 321389U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "T4j5ED1W9jcQSdssHuh8H8", Name = "__slot_T4j5ED1W9jcQSdssHuh8H8")]
            public string __slot_T4j5ED1W9jcQSdssHuh8H8;
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2 = default(n15.Spread<n6.AbstractGpuValue>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<n29.Vector4>> __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx = default(n15.Spread<n6.GpuValue<n29.Vector4>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS = default(n15.Spread<n6.GpuValue<float>>);
            public __KQIvkyBRNV7PN501mLnieq(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __KQIvkyBRNV7PN501mLnieq(__KQIvkyBRNV7PN501mLnieq other): base(other)
            {
                this.__p_HppTIT7HVaPLd6yhA5gCGH = other.__p_HppTIT7HVaPLd6yhA5gCGH;
                this.__p_NZQM7WuZGdVM1HuEVvKnzk = other.__p_NZQM7WuZGdVM1HuEVvKnzk;
                this.__p_R7XU2Qkpn2fMnBuokFXtSB = other.__p_R7XU2Qkpn2fMnBuokFXtSB;
                this.__p_NtraOQXtk2fNknrL8N8RXt = other.__p_NtraOQXtk2fNknrL8N8RXt;
                this.__p_McBjtUxeF04OEj39LRLvbx = other.__p_McBjtUxeF04OEj39LRLvbx;
                this.__p_TCsaeRTzXg4OgafIKDSPWp = other.__p_TCsaeRTzXg4OgafIKDSPWp;
                this.__p_Mo4GN6uV1h7Pl0pRCHlDXS = other.__p_Mo4GN6uV1h7Pl0pRCHlDXS;
                this.__p_FnrG3eMV0JsO9uTiRxxTm2 = other.__p_FnrG3eMV0JsO9uTiRxxTm2;
                this.__p_HDatOwF8D9FOPpfvovc5dS = other.__p_HDatOwF8D9FOPpfvovc5dS;
                this.__p_BhOfhsbVExYLsiaXvJzb9d = other.__p_BhOfhsbVExYLsiaXvJzb9d;
                this.__p_PgCWFiMDRq2NyJ5GDy0Sia = other.__p_PgCWFiMDRq2NyJ5GDy0Sia;
                this.__slot_NE5HikpUQKkONtT0oxhnLB = other.__slot_NE5HikpUQKkONtT0oxhnLB;
                this.__slot_T4j5ED1W9jcQSdssHuh8H8 = other.__slot_T4j5ED1W9jcQSdssHuh8H8;
                this.__pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2 = other.__pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2;
                this.__pin_group_Input_In_McBjtUxeF04OEj39LRLvbx = other.__pin_group_Input_In_McBjtUxeF04OEj39LRLvbx;
                this.__pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS = other.__pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_HppTIT7HVaPLd6yhA5gCGH", in __p_HppTIT7HVaPLd6yhA5gCGH), n2.CompilationHelper.GetValueOrExisting(values, "__p_NZQM7WuZGdVM1HuEVvKnzk", in __p_NZQM7WuZGdVM1HuEVvKnzk), n2.CompilationHelper.GetValueOrExisting(values, "__p_R7XU2Qkpn2fMnBuokFXtSB", in __p_R7XU2Qkpn2fMnBuokFXtSB), n2.CompilationHelper.GetValueOrExisting(values, "__p_NtraOQXtk2fNknrL8N8RXt", in __p_NtraOQXtk2fNknrL8N8RXt), n2.CompilationHelper.GetValueOrExisting(values, "__p_McBjtUxeF04OEj39LRLvbx", in __p_McBjtUxeF04OEj39LRLvbx), n2.CompilationHelper.GetValueOrExisting(values, "__p_TCsaeRTzXg4OgafIKDSPWp", in __p_TCsaeRTzXg4OgafIKDSPWp), n2.CompilationHelper.GetValueOrExisting(values, "__p_Mo4GN6uV1h7Pl0pRCHlDXS", in __p_Mo4GN6uV1h7Pl0pRCHlDXS), n2.CompilationHelper.GetValueOrExisting(values, "__p_FnrG3eMV0JsO9uTiRxxTm2", in __p_FnrG3eMV0JsO9uTiRxxTm2), n2.CompilationHelper.GetValueOrExisting(values, "__p_HDatOwF8D9FOPpfvovc5dS", in __p_HDatOwF8D9FOPpfvovc5dS), n2.CompilationHelper.GetValueOrExisting(values, "__p_BhOfhsbVExYLsiaXvJzb9d", in __p_BhOfhsbVExYLsiaXvJzb9d), n2.CompilationHelper.GetValueOrExisting(values, "__p_PgCWFiMDRq2NyJ5GDy0Sia", in __p_PgCWFiMDRq2NyJ5GDy0Sia), n2.CompilationHelper.GetValueOrExisting(values, "__slot_NE5HikpUQKkONtT0oxhnLB", in __slot_NE5HikpUQKkONtT0oxhnLB), n2.CompilationHelper.GetValueOrExisting(values, "__slot_T4j5ED1W9jcQSdssHuh8H8", in __slot_T4j5ED1W9jcQSdssHuh8H8), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2", in __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_McBjtUxeF04OEj39LRLvbx", in __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS", in __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS));
            }

            internal __KQIvkyBRNV7PN501mLnieq __WITH__(n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3> __p_HppTIT7HVaPLd6yhA5gCGH, n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<n29.Vector3> __p_NZQM7WuZGdVM1HuEVvKnzk, n41.Swizzle_DwOc96VdFLlOotWwxmIY1P<n29.Vector4, float> __p_R7XU2Qkpn2fMnBuokFXtSB, n41.Swizzle_DwOc96VdFLlOotWwxmIY1P<n29.Vector4, n29.Vector3> __p_NtraOQXtk2fNknrL8N8RXt, n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n29.Vector4> __p_McBjtUxeF04OEj39LRLvbx, n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, n29.Vector4> __p_TCsaeRTzXg4OgafIKDSPWp, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_Mo4GN6uV1h7Pl0pRCHlDXS, n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n29.Vector4> __p_FnrG3eMV0JsO9uTiRxxTm2, n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 __p_HDatOwF8D9FOPpfvovc5dS, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_BhOfhsbVExYLsiaXvJzb9d, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_PgCWFiMDRq2NyJ5GDy0Sia, n7.NoiseBasisType __slot_NE5HikpUQKkONtT0oxhnLB, string __slot_T4j5ED1W9jcQSdssHuh8H8, n15.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2, n15.Spread<n6.GpuValue<n29.Vector4>> __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx, n15.Spread<n6.GpuValue<float>> __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS)
            {
                __KQIvkyBRNV7PN501mLnieq that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_HppTIT7HVaPLd6yhA5gCGH != this.__p_HppTIT7HVaPLd6yhA5gCGH || __p_NZQM7WuZGdVM1HuEVvKnzk != this.__p_NZQM7WuZGdVM1HuEVvKnzk || __p_R7XU2Qkpn2fMnBuokFXtSB != this.__p_R7XU2Qkpn2fMnBuokFXtSB || __p_NtraOQXtk2fNknrL8N8RXt != this.__p_NtraOQXtk2fNknrL8N8RXt || __p_McBjtUxeF04OEj39LRLvbx != this.__p_McBjtUxeF04OEj39LRLvbx || __p_TCsaeRTzXg4OgafIKDSPWp != this.__p_TCsaeRTzXg4OgafIKDSPWp || __p_Mo4GN6uV1h7Pl0pRCHlDXS != this.__p_Mo4GN6uV1h7Pl0pRCHlDXS || __p_FnrG3eMV0JsO9uTiRxxTm2 != this.__p_FnrG3eMV0JsO9uTiRxxTm2 || __p_HDatOwF8D9FOPpfvovc5dS != this.__p_HDatOwF8D9FOPpfvovc5dS || __p_BhOfhsbVExYLsiaXvJzb9d != this.__p_BhOfhsbVExYLsiaXvJzb9d || __p_PgCWFiMDRq2NyJ5GDy0Sia != this.__p_PgCWFiMDRq2NyJ5GDy0Sia || !n17.EqualityComparer<n7.NoiseBasisType>.Default.Equals(__slot_NE5HikpUQKkONtT0oxhnLB, this.__slot_NE5HikpUQKkONtT0oxhnLB) || __slot_T4j5ED1W9jcQSdssHuh8H8 != this.__slot_T4j5ED1W9jcQSdssHuh8H8 || __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2 != this.__pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2 || __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx != this.__pin_group_Input_In_McBjtUxeF04OEj39LRLvbx || __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS != this.__pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS ? new __KQIvkyBRNV7PN501mLnieq(this)
                    {__p_HppTIT7HVaPLd6yhA5gCGH = __p_HppTIT7HVaPLd6yhA5gCGH, __p_NZQM7WuZGdVM1HuEVvKnzk = __p_NZQM7WuZGdVM1HuEVvKnzk, __p_R7XU2Qkpn2fMnBuokFXtSB = __p_R7XU2Qkpn2fMnBuokFXtSB, __p_NtraOQXtk2fNknrL8N8RXt = __p_NtraOQXtk2fNknrL8N8RXt, __p_McBjtUxeF04OEj39LRLvbx = __p_McBjtUxeF04OEj39LRLvbx, __p_TCsaeRTzXg4OgafIKDSPWp = __p_TCsaeRTzXg4OgafIKDSPWp, __p_Mo4GN6uV1h7Pl0pRCHlDXS = __p_Mo4GN6uV1h7Pl0pRCHlDXS, __p_FnrG3eMV0JsO9uTiRxxTm2 = __p_FnrG3eMV0JsO9uTiRxxTm2, __p_HDatOwF8D9FOPpfvovc5dS = __p_HDatOwF8D9FOPpfvovc5dS, __p_BhOfhsbVExYLsiaXvJzb9d = __p_BhOfhsbVExYLsiaXvJzb9d, __p_PgCWFiMDRq2NyJ5GDy0Sia = __p_PgCWFiMDRq2NyJ5GDy0Sia, __slot_NE5HikpUQKkONtT0oxhnLB = __slot_NE5HikpUQKkONtT0oxhnLB, __slot_T4j5ED1W9jcQSdssHuh8H8 = __slot_T4j5ED1W9jcQSdssHuh8H8, __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2 = __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2, __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx = __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx, __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS = __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS} : that_0;
                else
                {
                    this.__p_HppTIT7HVaPLd6yhA5gCGH = __p_HppTIT7HVaPLd6yhA5gCGH;
                    this.__p_NZQM7WuZGdVM1HuEVvKnzk = __p_NZQM7WuZGdVM1HuEVvKnzk;
                    this.__p_R7XU2Qkpn2fMnBuokFXtSB = __p_R7XU2Qkpn2fMnBuokFXtSB;
                    this.__p_NtraOQXtk2fNknrL8N8RXt = __p_NtraOQXtk2fNknrL8N8RXt;
                    this.__p_McBjtUxeF04OEj39LRLvbx = __p_McBjtUxeF04OEj39LRLvbx;
                    this.__p_TCsaeRTzXg4OgafIKDSPWp = __p_TCsaeRTzXg4OgafIKDSPWp;
                    this.__p_Mo4GN6uV1h7Pl0pRCHlDXS = __p_Mo4GN6uV1h7Pl0pRCHlDXS;
                    this.__p_FnrG3eMV0JsO9uTiRxxTm2 = __p_FnrG3eMV0JsO9uTiRxxTm2;
                    this.__p_HDatOwF8D9FOPpfvovc5dS = __p_HDatOwF8D9FOPpfvovc5dS;
                    this.__p_BhOfhsbVExYLsiaXvJzb9d = __p_BhOfhsbVExYLsiaXvJzb9d;
                    this.__p_PgCWFiMDRq2NyJ5GDy0Sia = __p_PgCWFiMDRq2NyJ5GDy0Sia;
                    this.__slot_NE5HikpUQKkONtT0oxhnLB = __slot_NE5HikpUQKkONtT0oxhnLB;
                    this.__slot_T4j5ED1W9jcQSdssHuh8H8 = __slot_T4j5ED1W9jcQSdssHuh8H8;
                    this.__pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2 = __pin_group_Arguments_In_FnrG3eMV0JsO9uTiRxxTm2;
                    this.__pin_group_Input_In_McBjtUxeF04OEj39LRLvbx = __pin_group_Input_In_McBjtUxeF04OEj39LRLvbx;
                    this.__pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS = __pin_group_Input_In_Mo4GN6uV1h7Pl0pRCHlDXS;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 321529U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "PhaSttWeZoqLS6wHU0qrpx", Name = "NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx")]
    [n3.SerializableAttribute]
    public class NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx Create(n2.NodeContext Node_Context)
        {
            var instance = new NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx CreateDefault()
        {
            var instance = new NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx Update(n6.GpuValue<n29.Vector3> TDomain_In, [n5.SerializedDefaultValueAttribute("2, 2, 2", false)] n6.GpuValue<n29.Vector3> Frequency_In, [n5.SerializedDefaultValueAttribute("1", false)] n6.GpuValue<float> Amplitude_In, [n5.SerializedDefaultValueAttribute("0, 0, 0", false)] n6.GpuValue<n29.Vector3> Offset_In, [n5.SerializedDefaultValueAttribute("0, 0, 0", false)] n6.GpuValue<n29.Vector3> Center_In, [n5.SerializedDefaultValueAttribute("GradientNoise", false)] n7.NoiseBasisType Noise_Type_In, out n6.GpuValue<n29.Vector3> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_EgoBFDzogrIPmvSGIl7Ds6;
            if (manager_2 is null)
            {
                manager_2 = new n9.Manager<n3.ValueTuple<n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n7.NoiseBasisType>, n3.ValueTuple<n6.GpuValue<n29.Vector3>>>(n3.ValueTuple.Create(default(n6.GpuValue<n29.Vector3>)));
            }

            var inputs_3 = (TDomain_In, Frequency_In, Offset_In, Amplitude_In, Center_In, Noise_Type_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n2.CompilationHelper.Restore<__RFT4rBsIY40MhojPcYkUya>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __RFT4rBsIY40MhojPcYkUya(__GetContext__(), n2.VLObject.NewIdentity())
                    {__slot_LedFDcbdMjUOEnZ4PgQGXl = default(n7.NoiseBasisType), __slot_ObBRvsKzvsYNsFiE56Wwds = "", __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x = n16._Operations_.CreateDefault<n6.AbstractGpuValue>(), __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS = n16._Operations_.CreateDefault<n6.GpuValue<n29.Vector3>>(), __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL = n16._Operations_.CreateDefault<n6.GpuValue<n29.Vector3>>()};
                    n2.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "B3gnl0S6uMUMy56An5qsSA", 321547U);
                    var Output_8 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3>.Create(Node_Context: Node_Context_7);
                    state_6.__p_B3gnl0S6uMUMy56An5qsSA = Output_8;
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "T19m23KKpfsPqRPNDHltmG", 321556U);
                    var Output_10 = n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<n29.Vector3>.Create(Node_Context: Node_Context_9);
                    state_6.__p_T19m23KKpfsPqRPNDHltmG = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "PUPe4RdafMCPE1SkUdcepS", 321562U);
                    var Output_12 = n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n29.Vector3>.Create(Node_Context: Node_Context_11);
                    state_6.__p_PUPe4RdafMCPE1SkUdcepS = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "H0oTa7ym35KM6oQVHioxF6", 321566U);
                    var Output_14 = n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, n29.Vector3>.Create(Node_Context: Node_Context_13);
                    state_6.__p_H0oTa7ym35KM6oQVHioxF6 = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "LNDp4Kqei0xNU6fnvW1vuL", 321570U);
                    var Output_16 = n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n29.Vector3>.Create(Node_Context: Node_Context_15);
                    state_6.__p_LNDp4Kqei0xNU6fnvW1vuL = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "DOHlYG4PnYXMgZM6cTLE3x", 321574U);
                    var Output_18 = n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n29.Vector3>.Create(Node_Context: Node_Context_17);
                    state_6.__p_DOHlYG4PnYXMgZM6cTLE3x = Output_18;
                    n2.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "ByKq5SUgVC6NFRTAsyumIW", 321581U);
                    var Output_20 = n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5.Create(Node_Context: Node_Context_19);
                    state_6.__p_ByKq5SUgVC6NFRTAsyumIW = Output_20;
                    n43._Operations_.NoiseDivergenceFree3DVectorID(Output_Out: out string Output_21);
                    n2.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "THZFpzM0CoNPjr7yWiRSEf", 321586U);
                    var Output_23 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_22, ID_In: Output_21);
                    state_6.__p_THZFpzM0CoNPjr7yWiRSEf = Output_23;
                }

                n15.Spread<string> __pad_J3Q05lWybF7Mgt62Y4l86i_24 = __slot_J3Q05lWybF7Mgt62Y4l86i;
                int Id_25 = 0;
                var State_Output_27 = state_6.__p_B3gnl0S6uMUMy56An5qsSA.Update(The_Override_In: TDomain_In, Id_In: Id_25, Output_Out: out n6.GpuValue<n29.Vector3> Output_26);
                var State_Output_29 = state_6.__p_T19m23KKpfsPqRPNDHltmG.Update(Value_In: Output_26, Scale_In: Frequency_In, Add_In: Offset_In, Output_Out: out n6.GpuValue<n29.Vector3> Output_28);
                n7.NoiseBasisType __pad_LedFDcbdMjUOEnZ4PgQGXl_30 = Noise_Type_In;
                int Index_31 = (int)__pad_LedFDcbdMjUOEnZ4PgQGXl_30;
                string Default_Value_32 = "";
                n16._Operations_.GetSlice<string>(Input_In: __pad_J3Q05lWybF7Mgt62Y4l86i_24, Default_Value_In: Default_Value_32, Index_In: Index_31, Result_Out: out string Result_33);
                string __pad_ObBRvsKzvsYNsFiE56Wwds_34 = Result_33;
                var Output_36 = state_6.__p_ByKq5SUgVC6NFRTAsyumIW.Update(Singleton_Out: out string Singleton_35);
                n6.GpuValue<n29.Vector3> Default_37 = default(n6.GpuValue<n29.Vector3>);
                bool Is_Groupable_38 = false;
                n17.IEnumerable<n6.InputModifier> The_Modifiers_39 = n22._Operations_.CreateDefault<n6.InputModifier>();
                var builder_40 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x, 1);
                builder_40.Add(Output_28);
                var __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x_41 = builder_40.Commit();
                var State_Output_44 = state_6.__p_DOHlYG4PnYXMgZM6cTLE3x.Update(Arguments_In: __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x_41, Function_Name_In: __pad_ObBRvsKzvsYNsFiE56Wwds_34, Default_In: Default_37, Mixins_In: Singleton_35, Is_Groupable_In: Is_Groupable_38, The_Modifiers_In: The_Modifiers_39, Output_Out: out n6.GpuValue<n29.Vector3> Output_42, Additional_Outputs_Out: out n15.Spread<n6.AbstractGpuValue> Additional_Outputs_43);
                n26._Operations_.TypeVector3(Input_In: Output_42, Output_Out: out n6.GpuValue<n29.Vector3> Output_45);
                n6.GpuValue<n29.Vector3> default_46 = default(n6.GpuValue<n29.Vector3>);
                var State_Output_48 = state_6.__p_H0oTa7ym35KM6oQVHioxF6.Update(x_In: Amplitude_In, default_In: default_46, Output_Out: out n6.GpuValue<n29.Vector3> Output_47);
                var builder_49 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS, 2);
                builder_49.Add(Output_45);
                builder_49.Add(Output_47);
                var __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS_50 = builder_49.Commit();
                var State_Output_52 = state_6.__p_PUPe4RdafMCPE1SkUdcepS.Update(Input_In: __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS_50, Output_Out: out n6.GpuValue<n29.Vector3> Output_51);
                var builder_53 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL, 2);
                builder_53.Add(Output_51);
                builder_53.Add(Center_In);
                var __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL_54 = builder_53.Commit();
                var State_Output_56 = state_6.__p_LNDp4Kqei0xNU6fnvW1vuL.Update(Input_In: __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL_54, Output_Out: out n6.GpuValue<n29.Vector3> Output_55);
                bool Update_57 = true;
                var Output_58 = state_6.__p_THZFpzM0CoNPjr7yWiRSEf;
                if (Update_57)
                {
                    Output_58 = state_6.__p_THZFpzM0CoNPjr7yWiRSEf.Update(Input_In: Output_55);
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_27 != state_6.__p_B3gnl0S6uMUMy56An5qsSA || State_Output_29 != state_6.__p_T19m23KKpfsPqRPNDHltmG || !n17.EqualityComparer<n7.NoiseBasisType>.Default.Equals(Noise_Type_In, state_6.__slot_LedFDcbdMjUOEnZ4PgQGXl) || Result_33 != state_6.__slot_ObBRvsKzvsYNsFiE56Wwds || Output_36 != state_6.__p_ByKq5SUgVC6NFRTAsyumIW || __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x_41 != state_6.__pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x || State_Output_44 != state_6.__p_DOHlYG4PnYXMgZM6cTLE3x || State_Output_48 != state_6.__p_H0oTa7ym35KM6oQVHioxF6 || __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS_50 != state_6.__pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS || State_Output_52 != state_6.__p_PUPe4RdafMCPE1SkUdcepS || __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL_54 != state_6.__pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL || State_Output_56 != state_6.__p_LNDp4Kqei0xNU6fnvW1vuL || Output_58 != state_6.__p_THZFpzM0CoNPjr7yWiRSEf ? new __RFT4rBsIY40MhojPcYkUya(state_6)
                    {__p_B3gnl0S6uMUMy56An5qsSA = State_Output_27, __p_T19m23KKpfsPqRPNDHltmG = State_Output_29, __slot_LedFDcbdMjUOEnZ4PgQGXl = Noise_Type_In, __slot_ObBRvsKzvsYNsFiE56Wwds = Result_33, __p_ByKq5SUgVC6NFRTAsyumIW = Output_36, __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x = __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x_41, __p_DOHlYG4PnYXMgZM6cTLE3x = State_Output_44, __p_H0oTa7ym35KM6oQVHioxF6 = State_Output_48, __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS = __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS_50, __p_PUPe4RdafMCPE1SkUdcepS = State_Output_52, __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL = __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL_54, __p_LNDp4Kqei0xNU6fnvW1vuL = State_Output_56, __p_THZFpzM0CoNPjr7yWiRSEf = Output_58} : state_6;
                else
                {
                    state_6.__p_B3gnl0S6uMUMy56An5qsSA = State_Output_27;
                    state_6.__p_T19m23KKpfsPqRPNDHltmG = State_Output_29;
                    state_6.__slot_LedFDcbdMjUOEnZ4PgQGXl = Noise_Type_In;
                    state_6.__slot_ObBRvsKzvsYNsFiE56Wwds = Result_33;
                    state_6.__p_ByKq5SUgVC6NFRTAsyumIW = Output_36;
                    state_6.__pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x = __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x_41;
                    state_6.__p_DOHlYG4PnYXMgZM6cTLE3x = State_Output_44;
                    state_6.__p_H0oTa7ym35KM6oQVHioxF6 = State_Output_48;
                    state_6.__pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS = __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS_50;
                    state_6.__p_PUPe4RdafMCPE1SkUdcepS = State_Output_52;
                    state_6.__pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL = __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL_54;
                    state_6.__p_LNDp4Kqei0xNU6fnvW1vuL = State_Output_56;
                    state_6.__p_THZFpzM0CoNPjr7yWiRSEf = Output_58;
                }

                outputs_4 = n3.ValueTuple.Create(Output_55);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_59 = outputs_4.Item1;
            Output_Out = __auto_59;
            n4.NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx that_60 = this;
            if (this.__GetContext__().IsImmutable)
                that_60 = manager_2 != this.__cache_EgoBFDzogrIPmvSGIl7Ds6 ? new NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx(this)
                {__cache_EgoBFDzogrIPmvSGIl7Ds6 = manager_2} : that_60;
            else
            {
                this.__cache_EgoBFDzogrIPmvSGIl7Ds6 = manager_2;
            }

            return that_60;
        }

        public n4.NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx that_0 = this;
            this.__cache_EgoBFDzogrIPmvSGIl7Ds6 = null;
            return that_0;
        }

        public n4.NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx __CreateDefault__()
        {
            n4.NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx that_0 = this;
            this.__cache_EgoBFDzogrIPmvSGIl7Ds6 = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_EgoBFDzogrIPmvSGIl7Ds6);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 321532U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "EgoBFDzogrIPmvSGIl7Ds6", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n7.NoiseBasisType>, n3.ValueTuple<n6.GpuValue<n29.Vector3>>> __cache_EgoBFDzogrIPmvSGIl7Ds6 = null;
        [n2.ElementAttribute(TracingId = 321550U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "J3Q05lWybF7Mgt62Y4l86i", Name = "__slot_J3Q05lWybF7Mgt62Y4l86i")]
        public static n15.Spread<string> __slot_J3Q05lWybF7Mgt62Y4l86i = n2.CompilationHelper.Deserialize<n15.Spread<string>>("<Value xmlns=\"property\">\r\n  <Item xmlns=\"\">sineNoiseDFV</Item>\r\n  <Item xmlns=\"\">valueNoiseDFV</Item>\r\n  <Item xmlns=\"\">gradientNoiseDFV</Item>\r\n  <Item xmlns=\"\">simplexNoiseDFV</Item>\r\n  <Item xmlns=\"\">worleySimpleNoiseDFV</Item>\r\n  <Item xmlns=\"\">sineNoiseDFV</Item>\r\n</Value>", true, "THHHRoIOybiP3bK7HRl5JW", "J3Q05lWybF7Mgt62Y4l86i");
        static NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx()
        {
        }

        public NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx(NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx other): base(other)
        {
            this.__cache_EgoBFDzogrIPmvSGIl7Ds6 = other.__cache_EgoBFDzogrIPmvSGIl7Ds6;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_EgoBFDzogrIPmvSGIl7Ds6", in __cache_EgoBFDzogrIPmvSGIl7Ds6));
        }

        internal NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx __WITH__(n9.Manager<n3.ValueTuple<n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n7.NoiseBasisType>, n3.ValueTuple<n6.GpuValue<n29.Vector3>>> __cache_EgoBFDzogrIPmvSGIl7Ds6)
        {
            n4.NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_EgoBFDzogrIPmvSGIl7Ds6 != this.__cache_EgoBFDzogrIPmvSGIl7Ds6 ? new NoiseDivergenceFree__3D_Vector_PhaSttWeZoqLS6wHU0qrpx(this)
                {__cache_EgoBFDzogrIPmvSGIl7Ds6 = __cache_EgoBFDzogrIPmvSGIl7Ds6} : that_0;
            else
            {
                this.__cache_EgoBFDzogrIPmvSGIl7Ds6 = __cache_EgoBFDzogrIPmvSGIl7Ds6;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RFT4rBsIY40MhojPcYkUya", Name = "__RFT4rBsIY40MhojPcYkUya")]
        [n3.SerializableAttribute]
        public class __RFT4rBsIY40MhojPcYkUya : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_B3gnl0S6uMUMy56An5qsSA);
                n2.CompilationHelper.SafeDispose(this.__p_T19m23KKpfsPqRPNDHltmG);
                n2.CompilationHelper.SafeDispose(this.__p_PUPe4RdafMCPE1SkUdcepS);
                n2.CompilationHelper.SafeDispose(this.__p_H0oTa7ym35KM6oQVHioxF6);
                n2.CompilationHelper.SafeDispose(this.__p_LNDp4Kqei0xNU6fnvW1vuL);
                n2.CompilationHelper.SafeDispose(this.__p_DOHlYG4PnYXMgZM6cTLE3x);
                n2.CompilationHelper.SafeDispose(this.__p_ByKq5SUgVC6NFRTAsyumIW);
                n2.CompilationHelper.SafeDispose(this.__p_THZFpzM0CoNPjr7yWiRSEf);
                return;
            }

            [n2.ElementAttribute(TracingId = 321547U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "B3gnl0S6uMUMy56An5qsSA", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3> __p_B3gnl0S6uMUMy56An5qsSA;
            [n2.ElementAttribute(TracingId = 321556U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "T19m23KKpfsPqRPNDHltmG", Name = "ScaleAndAdd", IsManaged = true, IsAutoGenerated = true)]
            public n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<n29.Vector3> __p_T19m23KKpfsPqRPNDHltmG;
            [n2.ElementAttribute(TracingId = 321562U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "PUPe4RdafMCPE1SkUdcepS", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n29.Vector3> __p_PUPe4RdafMCPE1SkUdcepS;
            [n2.ElementAttribute(TracingId = 321566U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "H0oTa7ym35KM6oQVHioxF6", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, n29.Vector3> __p_H0oTa7ym35KM6oQVHioxF6;
            [n2.ElementAttribute(TracingId = 321570U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LNDp4Kqei0xNU6fnvW1vuL", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n29.Vector3> __p_LNDp4Kqei0xNU6fnvW1vuL;
            [n2.ElementAttribute(TracingId = 321574U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "DOHlYG4PnYXMgZM6cTLE3x", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n29.Vector3> __p_DOHlYG4PnYXMgZM6cTLE3x;
            [n2.ElementAttribute(TracingId = 321581U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "ByKq5SUgVC6NFRTAsyumIW", Name = "FuseCommonNoise (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 __p_ByKq5SUgVC6NFRTAsyumIW;
            [n2.ElementAttribute(TracingId = 321586U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "THZFpzM0CoNPjr7yWiRSEf", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_THZFpzM0CoNPjr7yWiRSEf;
            [n2.ElementAttribute(TracingId = 321561U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LedFDcbdMjUOEnZ4PgQGXl", Name = "__slot_LedFDcbdMjUOEnZ4PgQGXl")]
            public n7.NoiseBasisType __slot_LedFDcbdMjUOEnZ4PgQGXl;
            [n2.ElementAttribute(TracingId = 321546U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "ObBRvsKzvsYNsFiE56Wwds", Name = "__slot_ObBRvsKzvsYNsFiE56Wwds")]
            public string __slot_ObBRvsKzvsYNsFiE56Wwds;
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x = default(n15.Spread<n6.AbstractGpuValue>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<n29.Vector3>> __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS = default(n15.Spread<n6.GpuValue<n29.Vector3>>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<n29.Vector3>> __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL = default(n15.Spread<n6.GpuValue<n29.Vector3>>);
            public __RFT4rBsIY40MhojPcYkUya(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RFT4rBsIY40MhojPcYkUya(__RFT4rBsIY40MhojPcYkUya other): base(other)
            {
                this.__p_B3gnl0S6uMUMy56An5qsSA = other.__p_B3gnl0S6uMUMy56An5qsSA;
                this.__p_T19m23KKpfsPqRPNDHltmG = other.__p_T19m23KKpfsPqRPNDHltmG;
                this.__p_PUPe4RdafMCPE1SkUdcepS = other.__p_PUPe4RdafMCPE1SkUdcepS;
                this.__p_H0oTa7ym35KM6oQVHioxF6 = other.__p_H0oTa7ym35KM6oQVHioxF6;
                this.__p_LNDp4Kqei0xNU6fnvW1vuL = other.__p_LNDp4Kqei0xNU6fnvW1vuL;
                this.__p_DOHlYG4PnYXMgZM6cTLE3x = other.__p_DOHlYG4PnYXMgZM6cTLE3x;
                this.__p_ByKq5SUgVC6NFRTAsyumIW = other.__p_ByKq5SUgVC6NFRTAsyumIW;
                this.__p_THZFpzM0CoNPjr7yWiRSEf = other.__p_THZFpzM0CoNPjr7yWiRSEf;
                this.__slot_LedFDcbdMjUOEnZ4PgQGXl = other.__slot_LedFDcbdMjUOEnZ4PgQGXl;
                this.__slot_ObBRvsKzvsYNsFiE56Wwds = other.__slot_ObBRvsKzvsYNsFiE56Wwds;
                this.__pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x = other.__pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x;
                this.__pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS = other.__pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS;
                this.__pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL = other.__pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_B3gnl0S6uMUMy56An5qsSA", in __p_B3gnl0S6uMUMy56An5qsSA), n2.CompilationHelper.GetValueOrExisting(values, "__p_T19m23KKpfsPqRPNDHltmG", in __p_T19m23KKpfsPqRPNDHltmG), n2.CompilationHelper.GetValueOrExisting(values, "__p_PUPe4RdafMCPE1SkUdcepS", in __p_PUPe4RdafMCPE1SkUdcepS), n2.CompilationHelper.GetValueOrExisting(values, "__p_H0oTa7ym35KM6oQVHioxF6", in __p_H0oTa7ym35KM6oQVHioxF6), n2.CompilationHelper.GetValueOrExisting(values, "__p_LNDp4Kqei0xNU6fnvW1vuL", in __p_LNDp4Kqei0xNU6fnvW1vuL), n2.CompilationHelper.GetValueOrExisting(values, "__p_DOHlYG4PnYXMgZM6cTLE3x", in __p_DOHlYG4PnYXMgZM6cTLE3x), n2.CompilationHelper.GetValueOrExisting(values, "__p_ByKq5SUgVC6NFRTAsyumIW", in __p_ByKq5SUgVC6NFRTAsyumIW), n2.CompilationHelper.GetValueOrExisting(values, "__p_THZFpzM0CoNPjr7yWiRSEf", in __p_THZFpzM0CoNPjr7yWiRSEf), n2.CompilationHelper.GetValueOrExisting(values, "__slot_LedFDcbdMjUOEnZ4PgQGXl", in __slot_LedFDcbdMjUOEnZ4PgQGXl), n2.CompilationHelper.GetValueOrExisting(values, "__slot_ObBRvsKzvsYNsFiE56Wwds", in __slot_ObBRvsKzvsYNsFiE56Wwds), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x", in __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS", in __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL", in __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL));
            }

            internal __RFT4rBsIY40MhojPcYkUya __WITH__(n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3> __p_B3gnl0S6uMUMy56An5qsSA, n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<n29.Vector3> __p_T19m23KKpfsPqRPNDHltmG, n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n29.Vector3> __p_PUPe4RdafMCPE1SkUdcepS, n26.To_Qgkn15Kxt1HLURmAdSAN7m<float, n29.Vector3> __p_H0oTa7ym35KM6oQVHioxF6, n13.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n29.Vector3> __p_LNDp4Kqei0xNU6fnvW1vuL, n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n29.Vector3> __p_DOHlYG4PnYXMgZM6cTLE3x, n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 __p_ByKq5SUgVC6NFRTAsyumIW, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_THZFpzM0CoNPjr7yWiRSEf, n7.NoiseBasisType __slot_LedFDcbdMjUOEnZ4PgQGXl, string __slot_ObBRvsKzvsYNsFiE56Wwds, n15.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x, n15.Spread<n6.GpuValue<n29.Vector3>> __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS, n15.Spread<n6.GpuValue<n29.Vector3>> __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL)
            {
                __RFT4rBsIY40MhojPcYkUya that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_B3gnl0S6uMUMy56An5qsSA != this.__p_B3gnl0S6uMUMy56An5qsSA || __p_T19m23KKpfsPqRPNDHltmG != this.__p_T19m23KKpfsPqRPNDHltmG || __p_PUPe4RdafMCPE1SkUdcepS != this.__p_PUPe4RdafMCPE1SkUdcepS || __p_H0oTa7ym35KM6oQVHioxF6 != this.__p_H0oTa7ym35KM6oQVHioxF6 || __p_LNDp4Kqei0xNU6fnvW1vuL != this.__p_LNDp4Kqei0xNU6fnvW1vuL || __p_DOHlYG4PnYXMgZM6cTLE3x != this.__p_DOHlYG4PnYXMgZM6cTLE3x || __p_ByKq5SUgVC6NFRTAsyumIW != this.__p_ByKq5SUgVC6NFRTAsyumIW || __p_THZFpzM0CoNPjr7yWiRSEf != this.__p_THZFpzM0CoNPjr7yWiRSEf || !n17.EqualityComparer<n7.NoiseBasisType>.Default.Equals(__slot_LedFDcbdMjUOEnZ4PgQGXl, this.__slot_LedFDcbdMjUOEnZ4PgQGXl) || __slot_ObBRvsKzvsYNsFiE56Wwds != this.__slot_ObBRvsKzvsYNsFiE56Wwds || __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x != this.__pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x || __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS != this.__pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS || __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL != this.__pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL ? new __RFT4rBsIY40MhojPcYkUya(this)
                    {__p_B3gnl0S6uMUMy56An5qsSA = __p_B3gnl0S6uMUMy56An5qsSA, __p_T19m23KKpfsPqRPNDHltmG = __p_T19m23KKpfsPqRPNDHltmG, __p_PUPe4RdafMCPE1SkUdcepS = __p_PUPe4RdafMCPE1SkUdcepS, __p_H0oTa7ym35KM6oQVHioxF6 = __p_H0oTa7ym35KM6oQVHioxF6, __p_LNDp4Kqei0xNU6fnvW1vuL = __p_LNDp4Kqei0xNU6fnvW1vuL, __p_DOHlYG4PnYXMgZM6cTLE3x = __p_DOHlYG4PnYXMgZM6cTLE3x, __p_ByKq5SUgVC6NFRTAsyumIW = __p_ByKq5SUgVC6NFRTAsyumIW, __p_THZFpzM0CoNPjr7yWiRSEf = __p_THZFpzM0CoNPjr7yWiRSEf, __slot_LedFDcbdMjUOEnZ4PgQGXl = __slot_LedFDcbdMjUOEnZ4PgQGXl, __slot_ObBRvsKzvsYNsFiE56Wwds = __slot_ObBRvsKzvsYNsFiE56Wwds, __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x = __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x, __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS = __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS, __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL = __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL} : that_0;
                else
                {
                    this.__p_B3gnl0S6uMUMy56An5qsSA = __p_B3gnl0S6uMUMy56An5qsSA;
                    this.__p_T19m23KKpfsPqRPNDHltmG = __p_T19m23KKpfsPqRPNDHltmG;
                    this.__p_PUPe4RdafMCPE1SkUdcepS = __p_PUPe4RdafMCPE1SkUdcepS;
                    this.__p_H0oTa7ym35KM6oQVHioxF6 = __p_H0oTa7ym35KM6oQVHioxF6;
                    this.__p_LNDp4Kqei0xNU6fnvW1vuL = __p_LNDp4Kqei0xNU6fnvW1vuL;
                    this.__p_DOHlYG4PnYXMgZM6cTLE3x = __p_DOHlYG4PnYXMgZM6cTLE3x;
                    this.__p_ByKq5SUgVC6NFRTAsyumIW = __p_ByKq5SUgVC6NFRTAsyumIW;
                    this.__p_THZFpzM0CoNPjr7yWiRSEf = __p_THZFpzM0CoNPjr7yWiRSEf;
                    this.__slot_LedFDcbdMjUOEnZ4PgQGXl = __slot_LedFDcbdMjUOEnZ4PgQGXl;
                    this.__slot_ObBRvsKzvsYNsFiE56Wwds = __slot_ObBRvsKzvsYNsFiE56Wwds;
                    this.__pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x = __pin_group_Arguments_In_DOHlYG4PnYXMgZM6cTLE3x;
                    this.__pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS = __pin_group_Input_In_PUPe4RdafMCPE1SkUdcepS;
                    this.__pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL = __pin_group_Input_In_LNDp4Kqei0xNU6fnvW1vuL;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 321655U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "UZj2Kr4gSSIPHvL8nkrVQJ", Name = "Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ")]
    [n3.SerializableAttribute]
    public class Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ Create(n2.NodeContext Node_Context)
        {
            var instance = new Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ CreateDefault()
        {
            var instance = new Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ Update(n6.GpuValue<float> TDomain_In, n6.GpuValue<float> Time_In, [n5.SerializedDefaultValueAttribute("2", false)] n6.GpuValue<float> Frequency_In, [n5.SerializedDefaultValueAttribute("1", false)] n6.GpuValue<float> Amplitude_In, n6.GpuValue<float> Offset_In, n6.GpuValue<float> Center_In, [n5.SerializedDefaultValueAttribute("0.5", false)] n6.GpuValue<float> Bias_In, n7.NoiseBasisInflection Inflection_In, [n5.SerializedDefaultValueAttribute("GradientNoise", false)] n8.NoiseType Noise_Type_In, out n6.GpuValue<float> Output_Out)
        {
            bool __pad_OIlmSRfoeXmMELPZV6AnPP_0 = __slot_OIlmSRfoeXmMELPZV6AnPP;
            n32.ObjectHelpers.IsAssigned(x: Time_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_BRIAazXfjt2OsMYyHokR78;
            if (manager_4 is null)
            {
                manager_4 = new n9.Manager<n3.ValueTuple<bool, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<float>>>(n3.ValueTuple.Create(default(n6.GpuValue<float>)));
            }

            var inputs_5 = (Result_1, TDomain_In, Time_In, Frequency_In, Amplitude_In, Offset_In, Center_In, Bias_In, Inflection_In, Noise_Type_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = __pad_OIlmSRfoeXmMELPZV6AnPP_0 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n2.CompilationHelper.Restore<__UTBOFOqCX5TM9Zx041ZGPu>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __UTBOFOqCX5TM9Zx041ZGPu(__GetContext__(), n2.VLObject.NewIdentity())
                    {__slot_LjoCvhZjCyPOFNbdLhormo = default(n6.GpuValue<float>), __slot_T0GUoN5VF1bLbf9HnY2phV = default(n6.GpuValue<n29.Vector2>)};
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "BrRy5eLfYfmO6Oxwn7E3G7", 321676U);
                    var Output_10 = n4.Noise_T2NdM1scOJdNoW9OUkWQPp<float, float>.Create(Node_Context: Node_Context_9);
                    state_8.__p_BrRy5eLfYfmO6Oxwn7E3G7 = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Qqr9JX5a7kDP64HUPA39gk", 321686U);
                    var Output_12 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<float>.Create(Node_Context: Node_Context_11);
                    state_8.__p_Qqr9JX5a7kDP64HUPA39gk = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "IBt3DQvrZEUPerIITt2yTf", 321689U);
                    var Output_14 = n35.xPy_join_JIONWu6byjBM6yvKcs4o8k.Create(Node_Context: Node_Context_13);
                    state_8.__p_IBt3DQvrZEUPerIITt2yTf = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "K8BEX4RlrxYLykhDH5V9tY", 321695U);
                    var Output_16 = n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector2, float>.Create(Node_Context: Node_Context_15);
                    state_8.__p_K8BEX4RlrxYLykhDH5V9tY = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "RYg709wnCKwPU2kfohi2Ao", 321705U);
                    var Output_18 = n35.xPy_join_JIONWu6byjBM6yvKcs4o8k.Create(Node_Context: Node_Context_17);
                    state_8.__p_RYg709wnCKwPU2kfohi2Ao = Output_18;
                    n2.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "GMUfBwmsuPnMoH6KPtkmG2", 321716U);
                    var Output_20 = n35.xPy_join_JIONWu6byjBM6yvKcs4o8k.Create(Node_Context: Node_Context_19);
                    state_8.__p_GMUfBwmsuPnMoH6KPtkmG2 = Output_20;
                    n2.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Slmx3LU36QXNIRNkTknTkt", 321722U);
                    var Output_22 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_21);
                    state_8.__p_Slmx3LU36QXNIRNkTknTkt = Output_22;
                    n2.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "SHdwc6ed3PRNjtkjcoURHL", 321726U);
                    var Output_24 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_23);
                    state_8.__p_SHdwc6ed3PRNjtkjcoURHL = Output_24;
                    n2.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Kqho3VTZ85GNsHULyEb9oW", 321730U);
                    var Output_26 = n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_25);
                    state_8.__p_Kqho3VTZ85GNsHULyEb9oW = Output_26;
                    n44._Operations_.Noise1DID(Output_Out: out string Output_27);
                    n2.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "UhNH6wsCUFSNe3POGCVcYp", 321734U);
                    var Output_29 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_28, ID_In: Output_27);
                    state_8.__p_UhNH6wsCUFSNe3POGCVcYp = Output_29;
                }

                float __pad_UMOyuk6zPtgNyZMJ0WalfK_30 = __slot_UMOyuk6zPtgNyZMJ0WalfK;
                float __pad_LPbVSAg93JnNPEYtTUxa1O_31 = __slot_LPbVSAg93JnNPEYtTUxa1O;
                int Id_32 = 0;
                var State_Output_34 = state_8.__p_Qqr9JX5a7kDP64HUPA39gk.Update(The_Override_In: TDomain_In, Id_In: Id_32, Output_Out: out n6.GpuValue<float> Output_33);
                n6.GpuValue<float> __pad_LjoCvhZjCyPOFNbdLhormo_35 = Output_33;
                n6.GpuValue<float> default_36 = default(n6.GpuValue<float>);
                var State_Output_38 = state_8.__p_BrRy5eLfYfmO6Oxwn7E3G7.Update<n27.__AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW>(TDomain_In: __pad_LjoCvhZjCyPOFNbdLhormo_35, Frequency_In: Frequency_In, Amplitude_In: Amplitude_In, Offset_In: Offset_In, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: Inflection_In, Noise_Type_In: Noise_Type_In, default_In: default_36, Output_Out: out n6.GpuValue<float> Output_37);
                var State_Output_40 = state_8.__p_IBt3DQvrZEUPerIITt2yTf.Update(x_In: Output_33, y_In: Time_In, Output_Out: out n6.GpuValue<n29.Vector2> Output_39);
                n6.GpuValue<n29.Vector2> __pad_T0GUoN5VF1bLbf9HnY2phV_41 = Output_39;
                float The_Value_42 = 1F;
                var State_Output_44 = state_8.__p_Kqho3VTZ85GNsHULyEb9oW.Update(GpuValue_In: Frequency_In, The_Value_In: The_Value_42, Output_Out: out n6.GpuValue<float> Output_43);
                var Output_46 = state_8.__p_Slmx3LU36QXNIRNkTknTkt.Update(Value_In: __pad_UMOyuk6zPtgNyZMJ0WalfK_30, GpuValue_Out: out n6.GpuValue<float> GpuValue_45);
                var State_Output_48 = state_8.__p_GMUfBwmsuPnMoH6KPtkmG2.Update(x_In: Output_43, y_In: GpuValue_45, Output_Out: out n6.GpuValue<n29.Vector2> Output_47);
                var Output_50 = state_8.__p_SHdwc6ed3PRNjtkjcoURHL.Update(Value_In: __pad_LPbVSAg93JnNPEYtTUxa1O_31, GpuValue_Out: out n6.GpuValue<float> GpuValue_49);
                var State_Output_52 = state_8.__p_RYg709wnCKwPU2kfohi2Ao.Update(x_In: Offset_In, y_In: GpuValue_49, Output_Out: out n6.GpuValue<n29.Vector2> Output_51);
                n6.GpuValue<float> default_53 = default(n6.GpuValue<float>);
                var State_Output_55 = state_8.__p_K8BEX4RlrxYLykhDH5V9tY.Update<n27.__AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW>(TDomain_In: __pad_T0GUoN5VF1bLbf9HnY2phV_41, Frequency_In: Output_47, Amplitude_In: Amplitude_In, Offset_In: Output_51, Center_In: Center_In, Bias_In: Bias_In, Inflection_In: Inflection_In, Noise_Type_In: Noise_Type_In, default_In: default_53, Output_Out: out n6.GpuValue<float> Output_54);
                n37._Operations_.Switch_Boolean<n6.GpuValue<float>>(Condition_In: Result_1, Input_In: Output_37, Input_2_In: Output_54, Output_Out: out n6.GpuValue<float> Output_56);
                bool Update_57 = true;
                var Output_58 = state_8.__p_UhNH6wsCUFSNe3POGCVcYp;
                if (Update_57)
                {
                    Output_58 = state_8.__p_UhNH6wsCUFSNe3POGCVcYp.Update(Input_In: Output_56);
                }

                n26._Operations_.TypeFloat(Input_In: Output_56, Output_Out: out n6.GpuValue<float> Output_59);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_34 != state_8.__p_Qqr9JX5a7kDP64HUPA39gk || Output_33 != state_8.__slot_LjoCvhZjCyPOFNbdLhormo || State_Output_38 != state_8.__p_BrRy5eLfYfmO6Oxwn7E3G7 || State_Output_40 != state_8.__p_IBt3DQvrZEUPerIITt2yTf || Output_39 != state_8.__slot_T0GUoN5VF1bLbf9HnY2phV || State_Output_44 != state_8.__p_Kqho3VTZ85GNsHULyEb9oW || Output_46 != state_8.__p_Slmx3LU36QXNIRNkTknTkt || State_Output_48 != state_8.__p_GMUfBwmsuPnMoH6KPtkmG2 || Output_50 != state_8.__p_SHdwc6ed3PRNjtkjcoURHL || State_Output_52 != state_8.__p_RYg709wnCKwPU2kfohi2Ao || State_Output_55 != state_8.__p_K8BEX4RlrxYLykhDH5V9tY || Output_58 != state_8.__p_UhNH6wsCUFSNe3POGCVcYp ? new __UTBOFOqCX5TM9Zx041ZGPu(state_8)
                    {__p_Qqr9JX5a7kDP64HUPA39gk = State_Output_34, __slot_LjoCvhZjCyPOFNbdLhormo = Output_33, __p_BrRy5eLfYfmO6Oxwn7E3G7 = State_Output_38, __p_IBt3DQvrZEUPerIITt2yTf = State_Output_40, __slot_T0GUoN5VF1bLbf9HnY2phV = Output_39, __p_Kqho3VTZ85GNsHULyEb9oW = State_Output_44, __p_Slmx3LU36QXNIRNkTknTkt = Output_46, __p_GMUfBwmsuPnMoH6KPtkmG2 = State_Output_48, __p_SHdwc6ed3PRNjtkjcoURHL = Output_50, __p_RYg709wnCKwPU2kfohi2Ao = State_Output_52, __p_K8BEX4RlrxYLykhDH5V9tY = State_Output_55, __p_UhNH6wsCUFSNe3POGCVcYp = Output_58} : state_8;
                else
                {
                    state_8.__p_Qqr9JX5a7kDP64HUPA39gk = State_Output_34;
                    state_8.__slot_LjoCvhZjCyPOFNbdLhormo = Output_33;
                    state_8.__p_BrRy5eLfYfmO6Oxwn7E3G7 = State_Output_38;
                    state_8.__p_IBt3DQvrZEUPerIITt2yTf = State_Output_40;
                    state_8.__slot_T0GUoN5VF1bLbf9HnY2phV = Output_39;
                    state_8.__p_Kqho3VTZ85GNsHULyEb9oW = State_Output_44;
                    state_8.__p_Slmx3LU36QXNIRNkTknTkt = Output_46;
                    state_8.__p_GMUfBwmsuPnMoH6KPtkmG2 = State_Output_48;
                    state_8.__p_SHdwc6ed3PRNjtkjcoURHL = Output_50;
                    state_8.__p_RYg709wnCKwPU2kfohi2Ao = State_Output_52;
                    state_8.__p_K8BEX4RlrxYLykhDH5V9tY = State_Output_55;
                    state_8.__p_UhNH6wsCUFSNe3POGCVcYp = Output_58;
                }

                outputs_6 = n3.ValueTuple.Create(Output_59);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_60 = outputs_6.Item1;
            Output_Out = __auto_60;
            n4.Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ that_61 = this;
            if (this.__GetContext__().IsImmutable)
                that_61 = manager_4 != this.__cache_BRIAazXfjt2OsMYyHokR78 ? new Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ(this)
                {__cache_BRIAazXfjt2OsMYyHokR78 = manager_4} : that_61;
            else
            {
                this.__cache_BRIAazXfjt2OsMYyHokR78 = manager_4;
            }

            return that_61;
        }

        public n4.Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ that_0 = this;
            this.__cache_BRIAazXfjt2OsMYyHokR78 = null;
            return that_0;
        }

        public n4.Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ __CreateDefault__()
        {
            n4.Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ that_0 = this;
            this.__cache_BRIAazXfjt2OsMYyHokR78 = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_BRIAazXfjt2OsMYyHokR78);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 321756U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "OIlmSRfoeXmMELPZV6AnPP", Name = "__slot_OIlmSRfoeXmMELPZV6AnPP")]
        public static bool __slot_OIlmSRfoeXmMELPZV6AnPP = false;
        [n2.ElementAttribute(TracingId = 321658U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BRIAazXfjt2OsMYyHokR78", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<bool, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<float>>> __cache_BRIAazXfjt2OsMYyHokR78 = null;
        [n2.ElementAttribute(TracingId = 321725U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "UMOyuk6zPtgNyZMJ0WalfK", Name = "__slot_UMOyuk6zPtgNyZMJ0WalfK")]
        public static float __slot_UMOyuk6zPtgNyZMJ0WalfK = 1F;
        [n2.ElementAttribute(TracingId = 321729U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LPbVSAg93JnNPEYtTUxa1O", Name = "__slot_LPbVSAg93JnNPEYtTUxa1O")]
        public static float __slot_LPbVSAg93JnNPEYtTUxa1O = 0F;
        static Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ()
        {
        }

        public Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ(Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ other): base(other)
        {
            this.__cache_BRIAazXfjt2OsMYyHokR78 = other.__cache_BRIAazXfjt2OsMYyHokR78;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_BRIAazXfjt2OsMYyHokR78", in __cache_BRIAazXfjt2OsMYyHokR78));
        }

        internal Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ __WITH__(n9.Manager<n3.ValueTuple<bool, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n7.NoiseBasisInflection, n8.NoiseType>>, n3.ValueTuple<n6.GpuValue<float>>> __cache_BRIAazXfjt2OsMYyHokR78)
        {
            n4.Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_BRIAazXfjt2OsMYyHokR78 != this.__cache_BRIAazXfjt2OsMYyHokR78 ? new Noise__1D_UZj2Kr4gSSIPHvL8nkrVQJ(this)
                {__cache_BRIAazXfjt2OsMYyHokR78 = __cache_BRIAazXfjt2OsMYyHokR78} : that_0;
            else
            {
                this.__cache_BRIAazXfjt2OsMYyHokR78 = __cache_BRIAazXfjt2OsMYyHokR78;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "UTBOFOqCX5TM9Zx041ZGPu", Name = "__UTBOFOqCX5TM9Zx041ZGPu")]
        [n3.SerializableAttribute]
        public class __UTBOFOqCX5TM9Zx041ZGPu : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_BrRy5eLfYfmO6Oxwn7E3G7);
                n2.CompilationHelper.SafeDispose(this.__p_Qqr9JX5a7kDP64HUPA39gk);
                n2.CompilationHelper.SafeDispose(this.__p_IBt3DQvrZEUPerIITt2yTf);
                n2.CompilationHelper.SafeDispose(this.__p_K8BEX4RlrxYLykhDH5V9tY);
                n2.CompilationHelper.SafeDispose(this.__p_RYg709wnCKwPU2kfohi2Ao);
                n2.CompilationHelper.SafeDispose(this.__p_GMUfBwmsuPnMoH6KPtkmG2);
                n2.CompilationHelper.SafeDispose(this.__p_Slmx3LU36QXNIRNkTknTkt);
                n2.CompilationHelper.SafeDispose(this.__p_SHdwc6ed3PRNjtkjcoURHL);
                n2.CompilationHelper.SafeDispose(this.__p_Kqho3VTZ85GNsHULyEb9oW);
                n2.CompilationHelper.SafeDispose(this.__p_UhNH6wsCUFSNe3POGCVcYp);
                return;
            }

            [n2.ElementAttribute(TracingId = 321676U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BrRy5eLfYfmO6Oxwn7E3G7", Name = "Noise", IsManaged = true, IsAutoGenerated = true)]
            public n4.Noise_T2NdM1scOJdNoW9OUkWQPp<float, float> __p_BrRy5eLfYfmO6Oxwn7E3G7;
            [n2.ElementAttribute(TracingId = 321686U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Qqr9JX5a7kDP64HUPA39gk", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<float> __p_Qqr9JX5a7kDP64HUPA39gk;
            [n2.ElementAttribute(TracingId = 321689U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "IBt3DQvrZEUPerIITt2yTf", Name = "x+y (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_IBt3DQvrZEUPerIITt2yTf;
            [n2.ElementAttribute(TracingId = 321695U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "K8BEX4RlrxYLykhDH5V9tY", Name = "Noise", IsManaged = true, IsAutoGenerated = true)]
            public n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector2, float> __p_K8BEX4RlrxYLykhDH5V9tY;
            [n2.ElementAttribute(TracingId = 321705U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RYg709wnCKwPU2kfohi2Ao", Name = "x+y (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_RYg709wnCKwPU2kfohi2Ao;
            [n2.ElementAttribute(TracingId = 321716U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "GMUfBwmsuPnMoH6KPtkmG2", Name = "x+y (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_GMUfBwmsuPnMoH6KPtkmG2;
            [n2.ElementAttribute(TracingId = 321722U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Slmx3LU36QXNIRNkTknTkt", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_Slmx3LU36QXNIRNkTknTkt;
            [n2.ElementAttribute(TracingId = 321726U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SHdwc6ed3PRNjtkjcoURHL", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_SHdwc6ed3PRNjtkjcoURHL;
            [n2.ElementAttribute(TracingId = 321730U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Kqho3VTZ85GNsHULyEb9oW", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_Kqho3VTZ85GNsHULyEb9oW;
            [n2.ElementAttribute(TracingId = 321734U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "UhNH6wsCUFSNe3POGCVcYp", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_UhNH6wsCUFSNe3POGCVcYp;
            [n2.ElementAttribute(TracingId = 321693U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LjoCvhZjCyPOFNbdLhormo", Name = "__slot_LjoCvhZjCyPOFNbdLhormo")]
            public n6.GpuValue<float> __slot_LjoCvhZjCyPOFNbdLhormo;
            [n2.ElementAttribute(TracingId = 321694U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "T0GUoN5VF1bLbf9HnY2phV", Name = "__slot_T0GUoN5VF1bLbf9HnY2phV")]
            public n6.GpuValue<n29.Vector2> __slot_T0GUoN5VF1bLbf9HnY2phV;
            public __UTBOFOqCX5TM9Zx041ZGPu(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __UTBOFOqCX5TM9Zx041ZGPu(__UTBOFOqCX5TM9Zx041ZGPu other): base(other)
            {
                this.__p_BrRy5eLfYfmO6Oxwn7E3G7 = other.__p_BrRy5eLfYfmO6Oxwn7E3G7;
                this.__p_Qqr9JX5a7kDP64HUPA39gk = other.__p_Qqr9JX5a7kDP64HUPA39gk;
                this.__p_IBt3DQvrZEUPerIITt2yTf = other.__p_IBt3DQvrZEUPerIITt2yTf;
                this.__p_K8BEX4RlrxYLykhDH5V9tY = other.__p_K8BEX4RlrxYLykhDH5V9tY;
                this.__p_RYg709wnCKwPU2kfohi2Ao = other.__p_RYg709wnCKwPU2kfohi2Ao;
                this.__p_GMUfBwmsuPnMoH6KPtkmG2 = other.__p_GMUfBwmsuPnMoH6KPtkmG2;
                this.__p_Slmx3LU36QXNIRNkTknTkt = other.__p_Slmx3LU36QXNIRNkTknTkt;
                this.__p_SHdwc6ed3PRNjtkjcoURHL = other.__p_SHdwc6ed3PRNjtkjcoURHL;
                this.__p_Kqho3VTZ85GNsHULyEb9oW = other.__p_Kqho3VTZ85GNsHULyEb9oW;
                this.__p_UhNH6wsCUFSNe3POGCVcYp = other.__p_UhNH6wsCUFSNe3POGCVcYp;
                this.__slot_LjoCvhZjCyPOFNbdLhormo = other.__slot_LjoCvhZjCyPOFNbdLhormo;
                this.__slot_T0GUoN5VF1bLbf9HnY2phV = other.__slot_T0GUoN5VF1bLbf9HnY2phV;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_BrRy5eLfYfmO6Oxwn7E3G7", in __p_BrRy5eLfYfmO6Oxwn7E3G7), n2.CompilationHelper.GetValueOrExisting(values, "__p_Qqr9JX5a7kDP64HUPA39gk", in __p_Qqr9JX5a7kDP64HUPA39gk), n2.CompilationHelper.GetValueOrExisting(values, "__p_IBt3DQvrZEUPerIITt2yTf", in __p_IBt3DQvrZEUPerIITt2yTf), n2.CompilationHelper.GetValueOrExisting(values, "__p_K8BEX4RlrxYLykhDH5V9tY", in __p_K8BEX4RlrxYLykhDH5V9tY), n2.CompilationHelper.GetValueOrExisting(values, "__p_RYg709wnCKwPU2kfohi2Ao", in __p_RYg709wnCKwPU2kfohi2Ao), n2.CompilationHelper.GetValueOrExisting(values, "__p_GMUfBwmsuPnMoH6KPtkmG2", in __p_GMUfBwmsuPnMoH6KPtkmG2), n2.CompilationHelper.GetValueOrExisting(values, "__p_Slmx3LU36QXNIRNkTknTkt", in __p_Slmx3LU36QXNIRNkTknTkt), n2.CompilationHelper.GetValueOrExisting(values, "__p_SHdwc6ed3PRNjtkjcoURHL", in __p_SHdwc6ed3PRNjtkjcoURHL), n2.CompilationHelper.GetValueOrExisting(values, "__p_Kqho3VTZ85GNsHULyEb9oW", in __p_Kqho3VTZ85GNsHULyEb9oW), n2.CompilationHelper.GetValueOrExisting(values, "__p_UhNH6wsCUFSNe3POGCVcYp", in __p_UhNH6wsCUFSNe3POGCVcYp), n2.CompilationHelper.GetValueOrExisting(values, "__slot_LjoCvhZjCyPOFNbdLhormo", in __slot_LjoCvhZjCyPOFNbdLhormo), n2.CompilationHelper.GetValueOrExisting(values, "__slot_T0GUoN5VF1bLbf9HnY2phV", in __slot_T0GUoN5VF1bLbf9HnY2phV));
            }

            internal __UTBOFOqCX5TM9Zx041ZGPu __WITH__(n4.Noise_T2NdM1scOJdNoW9OUkWQPp<float, float> __p_BrRy5eLfYfmO6Oxwn7E3G7, n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<float> __p_Qqr9JX5a7kDP64HUPA39gk, n35.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_IBt3DQvrZEUPerIITt2yTf, n4.Noise_T2NdM1scOJdNoW9OUkWQPp<n29.Vector2, float> __p_K8BEX4RlrxYLykhDH5V9tY, n35.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_RYg709wnCKwPU2kfohi2Ao, n35.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_GMUfBwmsuPnMoH6KPtkmG2, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_Slmx3LU36QXNIRNkTknTkt, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_SHdwc6ed3PRNjtkjcoURHL, n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_Kqho3VTZ85GNsHULyEb9oW, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_UhNH6wsCUFSNe3POGCVcYp, n6.GpuValue<float> __slot_LjoCvhZjCyPOFNbdLhormo, n6.GpuValue<n29.Vector2> __slot_T0GUoN5VF1bLbf9HnY2phV)
            {
                __UTBOFOqCX5TM9Zx041ZGPu that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_BrRy5eLfYfmO6Oxwn7E3G7 != this.__p_BrRy5eLfYfmO6Oxwn7E3G7 || __p_Qqr9JX5a7kDP64HUPA39gk != this.__p_Qqr9JX5a7kDP64HUPA39gk || __p_IBt3DQvrZEUPerIITt2yTf != this.__p_IBt3DQvrZEUPerIITt2yTf || __p_K8BEX4RlrxYLykhDH5V9tY != this.__p_K8BEX4RlrxYLykhDH5V9tY || __p_RYg709wnCKwPU2kfohi2Ao != this.__p_RYg709wnCKwPU2kfohi2Ao || __p_GMUfBwmsuPnMoH6KPtkmG2 != this.__p_GMUfBwmsuPnMoH6KPtkmG2 || __p_Slmx3LU36QXNIRNkTknTkt != this.__p_Slmx3LU36QXNIRNkTknTkt || __p_SHdwc6ed3PRNjtkjcoURHL != this.__p_SHdwc6ed3PRNjtkjcoURHL || __p_Kqho3VTZ85GNsHULyEb9oW != this.__p_Kqho3VTZ85GNsHULyEb9oW || __p_UhNH6wsCUFSNe3POGCVcYp != this.__p_UhNH6wsCUFSNe3POGCVcYp || __slot_LjoCvhZjCyPOFNbdLhormo != this.__slot_LjoCvhZjCyPOFNbdLhormo || __slot_T0GUoN5VF1bLbf9HnY2phV != this.__slot_T0GUoN5VF1bLbf9HnY2phV ? new __UTBOFOqCX5TM9Zx041ZGPu(this)
                    {__p_BrRy5eLfYfmO6Oxwn7E3G7 = __p_BrRy5eLfYfmO6Oxwn7E3G7, __p_Qqr9JX5a7kDP64HUPA39gk = __p_Qqr9JX5a7kDP64HUPA39gk, __p_IBt3DQvrZEUPerIITt2yTf = __p_IBt3DQvrZEUPerIITt2yTf, __p_K8BEX4RlrxYLykhDH5V9tY = __p_K8BEX4RlrxYLykhDH5V9tY, __p_RYg709wnCKwPU2kfohi2Ao = __p_RYg709wnCKwPU2kfohi2Ao, __p_GMUfBwmsuPnMoH6KPtkmG2 = __p_GMUfBwmsuPnMoH6KPtkmG2, __p_Slmx3LU36QXNIRNkTknTkt = __p_Slmx3LU36QXNIRNkTknTkt, __p_SHdwc6ed3PRNjtkjcoURHL = __p_SHdwc6ed3PRNjtkjcoURHL, __p_Kqho3VTZ85GNsHULyEb9oW = __p_Kqho3VTZ85GNsHULyEb9oW, __p_UhNH6wsCUFSNe3POGCVcYp = __p_UhNH6wsCUFSNe3POGCVcYp, __slot_LjoCvhZjCyPOFNbdLhormo = __slot_LjoCvhZjCyPOFNbdLhormo, __slot_T0GUoN5VF1bLbf9HnY2phV = __slot_T0GUoN5VF1bLbf9HnY2phV} : that_0;
                else
                {
                    this.__p_BrRy5eLfYfmO6Oxwn7E3G7 = __p_BrRy5eLfYfmO6Oxwn7E3G7;
                    this.__p_Qqr9JX5a7kDP64HUPA39gk = __p_Qqr9JX5a7kDP64HUPA39gk;
                    this.__p_IBt3DQvrZEUPerIITt2yTf = __p_IBt3DQvrZEUPerIITt2yTf;
                    this.__p_K8BEX4RlrxYLykhDH5V9tY = __p_K8BEX4RlrxYLykhDH5V9tY;
                    this.__p_RYg709wnCKwPU2kfohi2Ao = __p_RYg709wnCKwPU2kfohi2Ao;
                    this.__p_GMUfBwmsuPnMoH6KPtkmG2 = __p_GMUfBwmsuPnMoH6KPtkmG2;
                    this.__p_Slmx3LU36QXNIRNkTknTkt = __p_Slmx3LU36QXNIRNkTknTkt;
                    this.__p_SHdwc6ed3PRNjtkjcoURHL = __p_SHdwc6ed3PRNjtkjcoURHL;
                    this.__p_Kqho3VTZ85GNsHULyEb9oW = __p_Kqho3VTZ85GNsHULyEb9oW;
                    this.__p_UhNH6wsCUFSNe3POGCVcYp = __p_UhNH6wsCUFSNe3POGCVcYp;
                    this.__slot_LjoCvhZjCyPOFNbdLhormo = __slot_LjoCvhZjCyPOFNbdLhormo;
                    this.__slot_T0GUoN5VF1bLbf9HnY2phV = __slot_T0GUoN5VF1bLbf9HnY2phV;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 321839U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Kk9ZffwdUrOQRXG4WfwvUd", Name = "WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd")]
    [n3.SerializableAttribute]
    public class WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd Create(n2.NodeContext Node_Context)
        {
            var instance = new WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd CreateDefault()
        {
            var instance = new WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd Update(n6.GpuValue<float> TDomain_In, n6.GpuValue<float> Time_In, [n5.SerializedDefaultValueAttribute("2", false)] n6.GpuValue<float> Frequency_In, [n5.SerializedDefaultValueAttribute("1", false)] n6.GpuValue<float> Amplitude_In, [n5.SerializedDefaultValueAttribute("0", false)] n6.GpuValue<float> Offset_In, [n5.SerializedDefaultValueAttribute("0", false)] n6.GpuValue<float> Center_In, [n5.SerializedDefaultValueAttribute("0.5", false)] n6.GpuValue<float> Bias_In, [n5.SerializedDefaultValueAttribute("0.01", false)] n6.GpuValue<float> Smooth_In, [n5.SerializedDefaultValueAttribute("0.7", false)] n6.GpuValue<float> Jitter_In, n23.DistanceMetricsSelector Metric_In, [n5.SerializedDefaultValueAttribute("4", false)] n6.GpuValue<float> Minkowski_Power_In, out n6.GpuValue<float> Output_Out, out n6.GpuValue<float> Cell_Position_Out, out n6.GpuValue<float> Cell_ID_Out)
        {
            bool __pad_INpvWispqm4NyHGTMYdpm4_0 = __slot_INpvWispqm4NyHGTMYdpm4;
            n32.ObjectHelpers.IsAssigned(x: Time_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_Gt2Rs3jQ4pjLLrVdGyiYvI;
            if (manager_4 is null)
            {
                manager_4 = new n9.Manager<n3.ValueTuple<bool, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>>>((default(n6.GpuValue<float>), default(n6.GpuValue<float>), default(n6.GpuValue<float>)));
            }

            var inputs_5 = (Result_1, TDomain_In, Time_In, Frequency_In, Amplitude_In, Offset_In, Center_In, Bias_In, Smooth_In, Jitter_In, Metric_In, Minkowski_Power_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = __pad_INpvWispqm4NyHGTMYdpm4_0 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n2.CompilationHelper.Restore<__AEsyU74UeFUNUDrtoHqo6l>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __AEsyU74UeFUNUDrtoHqo6l(__GetContext__(), n2.VLObject.NewIdentity())
                    {__slot_OjKkk8QC1YyMCCcMty0sFK = default(n6.GpuValue<float>), __slot_KVhMz76HGelNarxRuuPTtD = default(n6.GpuValue<n29.Vector2>)};
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "OQXhxXdkhRYPmQ3JP4igQR", 321864U);
                    var Output_10 = n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<float>.Create(Node_Context: Node_Context_9);
                    state_8.__p_OQXhxXdkhRYPmQ3JP4igQR = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "HbX998xoQYgPJWzjizirAC", 321878U);
                    var Output_12 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<float>.Create(Node_Context: Node_Context_11);
                    state_8.__p_HbX998xoQYgPJWzjizirAC = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "U4NZ8aIp51dM7lOmUW1yNr", 321881U);
                    var Output_14 = n35.xPy_join_JIONWu6byjBM6yvKcs4o8k.Create(Node_Context: Node_Context_13);
                    state_8.__p_U4NZ8aIp51dM7lOmUW1yNr = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "MPO5dhB2OlULHURhnfktqR", 321887U);
                    var Output_16 = n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector2>.Create(Node_Context: Node_Context_15);
                    state_8.__p_MPO5dhB2OlULHURhnfktqR = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "KVPjosncVWXQSq92GglHDK", 321901U);
                    var Output_18 = n35.xPy_join_JIONWu6byjBM6yvKcs4o8k.Create(Node_Context: Node_Context_17);
                    state_8.__p_KVPjosncVWXQSq92GglHDK = Output_18;
                    n2.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "J1jMdRcNczMMqZdZS7Eqbq", 321910U);
                    var Output_20 = n13.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float>.Create(Node_Context: Node_Context_19);
                    state_8.__p_J1jMdRcNczMMqZdZS7Eqbq = Output_20;
                    n2.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "NsmSCV3ooXELw3Fnpt0l7K", 321912U);
                    var Output_22 = n35.xPy_join_JIONWu6byjBM6yvKcs4o8k.Create(Node_Context: Node_Context_21);
                    state_8.__p_NsmSCV3ooXELw3Fnpt0l7K = Output_22;
                    n2.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "DbmKuH598AXNncq96OaPWS", 321916U);
                    var Output_24 = n13.ONE_K5Kfj2u1J7gOSuWnHDoU3n<float>.Create(Node_Context: Node_Context_23);
                    state_8.__p_DbmKuH598AXNncq96OaPWS = Output_24;
                    n45._Operations_.WorleySmooth1DID(Output_Out: out string Output_25);
                    n2.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "LbgDcsFQRFEPN4Tn44UutP", 321918U);
                    var Output_27 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_26, ID_In: Output_25);
                    state_8.__p_LbgDcsFQRFEPN4Tn44UutP = Output_27;
                    n2.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "DXvcsTiKZi3Pv7QHkbs2JH", 321929U);
                    var Output_29 = n41.x_CThKQPdF8roMfrpnCR01ll<n29.Vector2>.Create(Node_Context: Node_Context_28);
                    state_8.__p_DXvcsTiKZi3Pv7QHkbs2JH = Output_29;
                    n45._Operations_.WorleySmooth1DCellID(Output_Out: out string Output_30);
                    n2.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "O8pOwKDG7KzLxmlbd9RwT2", 321940U);
                    var Output_32 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_31, ID_In: Output_30);
                    state_8.__p_O8pOwKDG7KzLxmlbd9RwT2 = Output_32;
                    n45._Operations_.WorleySmooth1DCellPosID(Output_Out: out string Output_33);
                    n2.NodeContext Node_Context_34 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "N6DxssSuCW2PU5Z3WVIURo", 321945U);
                    var Output_35 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_34, ID_In: Output_33);
                    state_8.__p_N6DxssSuCW2PU5Z3WVIURo = Output_35;
                }

                int Id_36 = 0;
                var State_Output_38 = state_8.__p_HbX998xoQYgPJWzjizirAC.Update(The_Override_In: TDomain_In, Id_In: Id_36, Output_Out: out n6.GpuValue<float> Output_37);
                n6.GpuValue<float> __pad_OjKkk8QC1YyMCCcMty0sFK_39 = Output_37;
                var State_Output_43 = state_8.__p_OQXhxXdkhRYPmQ3JP4igQR.Update(TDomain_In: __pad_OjKkk8QC1YyMCCcMty0sFK_39, Frequency_In: Frequency_In, Amplitude_In: Amplitude_In, Center_In: Center_In, Bias_In: Bias_In, Offset_In: Offset_In, Smooth_In: Smooth_In, Jitter_In: Jitter_In, Metric_In: Metric_In, Minkowski_Power_In: Minkowski_Power_In, Output_Out: out n6.GpuValue<float> Output_40, Cell_Position_Out: out n6.GpuValue<float> Cell_Position_41, Cell_ID_Out: out n6.GpuValue<float> Cell_ID_42);
                var State_Output_45 = state_8.__p_U4NZ8aIp51dM7lOmUW1yNr.Update(x_In: Output_37, y_In: Time_In, Output_Out: out n6.GpuValue<n29.Vector2> Output_44);
                n6.GpuValue<n29.Vector2> __pad_KVhMz76HGelNarxRuuPTtD_46 = Output_44;
                var State_Output_48 = state_8.__p_DbmKuH598AXNncq96OaPWS.Update(Output_Out: out n6.GpuValue<float> Output_47);
                var State_Output_50 = state_8.__p_NsmSCV3ooXELw3Fnpt0l7K.Update(x_In: Frequency_In, y_In: Output_47, Output_Out: out n6.GpuValue<n29.Vector2> Output_49);
                var State_Output_52 = state_8.__p_J1jMdRcNczMMqZdZS7Eqbq.Update(Output_Out: out n6.GpuValue<float> Output_51);
                var State_Output_54 = state_8.__p_KVPjosncVWXQSq92GglHDK.Update(x_In: Offset_In, y_In: Output_51, Output_Out: out n6.GpuValue<n29.Vector2> Output_53);
                var State_Output_58 = state_8.__p_MPO5dhB2OlULHURhnfktqR.Update(TDomain_In: __pad_KVhMz76HGelNarxRuuPTtD_46, Frequency_In: Output_49, Amplitude_In: Amplitude_In, Center_In: Center_In, Bias_In: Bias_In, Offset_In: Output_53, Smooth_In: Smooth_In, Jitter_In: Jitter_In, Metric_In: Metric_In, Minkowski_Power_In: Minkowski_Power_In, Output_Out: out n6.GpuValue<float> Output_55, Cell_Position_Out: out n6.GpuValue<n29.Vector2> Cell_Position_56, Cell_ID_Out: out n6.GpuValue<float> Cell_ID_57);
                bool __pad_BlzvByHn5GwOolRRopgqxk_59 = Result_1;
                n37._Operations_.Switch_Boolean<n6.GpuValue<float>>(Condition_In: __pad_BlzvByHn5GwOolRRopgqxk_59, Input_In: Output_40, Input_2_In: Output_55, Output_Out: out n6.GpuValue<float> Output_60);
                bool Update_61 = true;
                var Output_62 = state_8.__p_LbgDcsFQRFEPN4Tn44UutP;
                if (Update_61)
                {
                    Output_62 = state_8.__p_LbgDcsFQRFEPN4Tn44UutP.Update(Input_In: Output_60);
                }

                n26._Operations_.TypeFloat(Input_In: Output_60, Output_Out: out n6.GpuValue<float> Output_63);
                var State_Output_65 = state_8.__p_DXvcsTiKZi3Pv7QHkbs2JH.Update(Input_In: Cell_Position_56, Output_Out: out n6.GpuValue<float> Output_64);
                n37._Operations_.Switch_Boolean<n6.GpuValue<float>>(Condition_In: __pad_BlzvByHn5GwOolRRopgqxk_59, Input_In: Cell_Position_41, Input_2_In: Output_64, Output_Out: out n6.GpuValue<float> Output_66);
                n26._Operations_.TypeFloat(Input_In: Output_66, Output_Out: out n6.GpuValue<float> Output_67);
                bool Update_68 = true;
                var Output_69 = state_8.__p_N6DxssSuCW2PU5Z3WVIURo;
                if (Update_68)
                {
                    Output_69 = state_8.__p_N6DxssSuCW2PU5Z3WVIURo.Update(Input_In: Output_67);
                }

                n37._Operations_.Switch_Boolean<n6.GpuValue<float>>(Condition_In: __pad_BlzvByHn5GwOolRRopgqxk_59, Input_In: Cell_ID_42, Input_2_In: Cell_ID_57, Output_Out: out n6.GpuValue<float> Output_70);
                bool Update_71 = true;
                var Output_72 = state_8.__p_O8pOwKDG7KzLxmlbd9RwT2;
                if (Update_71)
                {
                    Output_72 = state_8.__p_O8pOwKDG7KzLxmlbd9RwT2.Update(Input_In: Output_70);
                }

                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_38 != state_8.__p_HbX998xoQYgPJWzjizirAC || Output_37 != state_8.__slot_OjKkk8QC1YyMCCcMty0sFK || State_Output_43 != state_8.__p_OQXhxXdkhRYPmQ3JP4igQR || State_Output_45 != state_8.__p_U4NZ8aIp51dM7lOmUW1yNr || Output_44 != state_8.__slot_KVhMz76HGelNarxRuuPTtD || State_Output_48 != state_8.__p_DbmKuH598AXNncq96OaPWS || State_Output_50 != state_8.__p_NsmSCV3ooXELw3Fnpt0l7K || State_Output_52 != state_8.__p_J1jMdRcNczMMqZdZS7Eqbq || State_Output_54 != state_8.__p_KVPjosncVWXQSq92GglHDK || State_Output_58 != state_8.__p_MPO5dhB2OlULHURhnfktqR || Result_1 != state_8.__slot_BlzvByHn5GwOolRRopgqxk || Output_62 != state_8.__p_LbgDcsFQRFEPN4Tn44UutP || State_Output_65 != state_8.__p_DXvcsTiKZi3Pv7QHkbs2JH || Output_69 != state_8.__p_N6DxssSuCW2PU5Z3WVIURo || Output_72 != state_8.__p_O8pOwKDG7KzLxmlbd9RwT2 ? new __AEsyU74UeFUNUDrtoHqo6l(state_8)
                    {__p_HbX998xoQYgPJWzjizirAC = State_Output_38, __slot_OjKkk8QC1YyMCCcMty0sFK = Output_37, __p_OQXhxXdkhRYPmQ3JP4igQR = State_Output_43, __p_U4NZ8aIp51dM7lOmUW1yNr = State_Output_45, __slot_KVhMz76HGelNarxRuuPTtD = Output_44, __p_DbmKuH598AXNncq96OaPWS = State_Output_48, __p_NsmSCV3ooXELw3Fnpt0l7K = State_Output_50, __p_J1jMdRcNczMMqZdZS7Eqbq = State_Output_52, __p_KVPjosncVWXQSq92GglHDK = State_Output_54, __p_MPO5dhB2OlULHURhnfktqR = State_Output_58, __slot_BlzvByHn5GwOolRRopgqxk = Result_1, __p_LbgDcsFQRFEPN4Tn44UutP = Output_62, __p_DXvcsTiKZi3Pv7QHkbs2JH = State_Output_65, __p_N6DxssSuCW2PU5Z3WVIURo = Output_69, __p_O8pOwKDG7KzLxmlbd9RwT2 = Output_72} : state_8;
                else
                {
                    state_8.__p_HbX998xoQYgPJWzjizirAC = State_Output_38;
                    state_8.__slot_OjKkk8QC1YyMCCcMty0sFK = Output_37;
                    state_8.__p_OQXhxXdkhRYPmQ3JP4igQR = State_Output_43;
                    state_8.__p_U4NZ8aIp51dM7lOmUW1yNr = State_Output_45;
                    state_8.__slot_KVhMz76HGelNarxRuuPTtD = Output_44;
                    state_8.__p_DbmKuH598AXNncq96OaPWS = State_Output_48;
                    state_8.__p_NsmSCV3ooXELw3Fnpt0l7K = State_Output_50;
                    state_8.__p_J1jMdRcNczMMqZdZS7Eqbq = State_Output_52;
                    state_8.__p_KVPjosncVWXQSq92GglHDK = State_Output_54;
                    state_8.__p_MPO5dhB2OlULHURhnfktqR = State_Output_58;
                    state_8.__slot_BlzvByHn5GwOolRRopgqxk = Result_1;
                    state_8.__p_LbgDcsFQRFEPN4Tn44UutP = Output_62;
                    state_8.__p_DXvcsTiKZi3Pv7QHkbs2JH = State_Output_65;
                    state_8.__p_N6DxssSuCW2PU5Z3WVIURo = Output_69;
                    state_8.__p_O8pOwKDG7KzLxmlbd9RwT2 = Output_72;
                }

                outputs_6 = (Output_63, Output_67, Output_70);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var(__auto_73, __auto_74, __auto_75) = outputs_6;
            Output_Out = __auto_73;
            Cell_Position_Out = __auto_74;
            Cell_ID_Out = __auto_75;
            n4.WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd that_76 = this;
            if (this.__GetContext__().IsImmutable)
                that_76 = manager_4 != this.__cache_Gt2Rs3jQ4pjLLrVdGyiYvI ? new WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd(this)
                {__cache_Gt2Rs3jQ4pjLLrVdGyiYvI = manager_4} : that_76;
            else
            {
                this.__cache_Gt2Rs3jQ4pjLLrVdGyiYvI = manager_4;
            }

            return that_76;
        }

        public n4.WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd that_0 = this;
            this.__cache_Gt2Rs3jQ4pjLLrVdGyiYvI = null;
            return that_0;
        }

        public n4.WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd __CreateDefault__()
        {
            n4.WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd that_0 = this;
            this.__cache_Gt2Rs3jQ4pjLLrVdGyiYvI = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_Gt2Rs3jQ4pjLLrVdGyiYvI);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 321965U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "INpvWispqm4NyHGTMYdpm4", Name = "__slot_INpvWispqm4NyHGTMYdpm4")]
        public static bool __slot_INpvWispqm4NyHGTMYdpm4 = false;
        [n2.ElementAttribute(TracingId = 321842U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Gt2Rs3jQ4pjLLrVdGyiYvI", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<bool, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>>> __cache_Gt2Rs3jQ4pjLLrVdGyiYvI = null;
        static WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd()
        {
        }

        public WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd(WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd other): base(other)
        {
            this.__cache_Gt2Rs3jQ4pjLLrVdGyiYvI = other.__cache_Gt2Rs3jQ4pjLLrVdGyiYvI;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_Gt2Rs3jQ4pjLLrVdGyiYvI", in __cache_Gt2Rs3jQ4pjLLrVdGyiYvI));
        }

        internal WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd __WITH__(n9.Manager<n3.ValueTuple<bool, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>>> __cache_Gt2Rs3jQ4pjLLrVdGyiYvI)
        {
            n4.WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Gt2Rs3jQ4pjLLrVdGyiYvI != this.__cache_Gt2Rs3jQ4pjLLrVdGyiYvI ? new WorleyNoise__1D_Kk9ZffwdUrOQRXG4WfwvUd(this)
                {__cache_Gt2Rs3jQ4pjLLrVdGyiYvI = __cache_Gt2Rs3jQ4pjLLrVdGyiYvI} : that_0;
            else
            {
                this.__cache_Gt2Rs3jQ4pjLLrVdGyiYvI = __cache_Gt2Rs3jQ4pjLLrVdGyiYvI;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "AEsyU74UeFUNUDrtoHqo6l", Name = "__AEsyU74UeFUNUDrtoHqo6l")]
        [n3.SerializableAttribute]
        public class __AEsyU74UeFUNUDrtoHqo6l : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_OQXhxXdkhRYPmQ3JP4igQR);
                n2.CompilationHelper.SafeDispose(this.__p_HbX998xoQYgPJWzjizirAC);
                n2.CompilationHelper.SafeDispose(this.__p_U4NZ8aIp51dM7lOmUW1yNr);
                n2.CompilationHelper.SafeDispose(this.__p_MPO5dhB2OlULHURhnfktqR);
                n2.CompilationHelper.SafeDispose(this.__p_KVPjosncVWXQSq92GglHDK);
                n2.CompilationHelper.SafeDispose(this.__p_J1jMdRcNczMMqZdZS7Eqbq);
                n2.CompilationHelper.SafeDispose(this.__p_NsmSCV3ooXELw3Fnpt0l7K);
                n2.CompilationHelper.SafeDispose(this.__p_DbmKuH598AXNncq96OaPWS);
                n2.CompilationHelper.SafeDispose(this.__p_LbgDcsFQRFEPN4Tn44UutP);
                n2.CompilationHelper.SafeDispose(this.__p_DXvcsTiKZi3Pv7QHkbs2JH);
                n2.CompilationHelper.SafeDispose(this.__p_O8pOwKDG7KzLxmlbd9RwT2);
                n2.CompilationHelper.SafeDispose(this.__p_N6DxssSuCW2PU5Z3WVIURo);
                return;
            }

            [n2.ElementAttribute(TracingId = 321864U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "OQXhxXdkhRYPmQ3JP4igQR", Name = "WorleyNoise", IsManaged = true, IsAutoGenerated = true)]
            public n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<float> __p_OQXhxXdkhRYPmQ3JP4igQR;
            [n2.ElementAttribute(TracingId = 321878U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HbX998xoQYgPJWzjizirAC", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<float> __p_HbX998xoQYgPJWzjizirAC;
            [n2.ElementAttribute(TracingId = 321881U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "U4NZ8aIp51dM7lOmUW1yNr", Name = "x+y (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_U4NZ8aIp51dM7lOmUW1yNr;
            [n2.ElementAttribute(TracingId = 321887U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "MPO5dhB2OlULHURhnfktqR", Name = "WorleyNoise", IsManaged = true, IsAutoGenerated = true)]
            public n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector2> __p_MPO5dhB2OlULHURhnfktqR;
            [n2.ElementAttribute(TracingId = 321901U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "KVPjosncVWXQSq92GglHDK", Name = "x+y (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_KVPjosncVWXQSq92GglHDK;
            [n2.ElementAttribute(TracingId = 321910U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "J1jMdRcNczMMqZdZS7Eqbq", Name = "ZERO", IsManaged = true, IsAutoGenerated = true)]
            public n13.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float> __p_J1jMdRcNczMMqZdZS7Eqbq;
            [n2.ElementAttribute(TracingId = 321912U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NsmSCV3ooXELw3Fnpt0l7K", Name = "x+y (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_NsmSCV3ooXELw3Fnpt0l7K;
            [n2.ElementAttribute(TracingId = 321916U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "DbmKuH598AXNncq96OaPWS", Name = "ONE", IsManaged = true, IsAutoGenerated = true)]
            public n13.ONE_K5Kfj2u1J7gOSuWnHDoU3n<float> __p_DbmKuH598AXNncq96OaPWS;
            [n2.ElementAttribute(TracingId = 321918U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LbgDcsFQRFEPN4Tn44UutP", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_LbgDcsFQRFEPN4Tn44UutP;
            [n2.ElementAttribute(TracingId = 321929U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "DXvcsTiKZi3Pv7QHkbs2JH", Name = "x", IsManaged = true, IsAutoGenerated = true)]
            public n41.x_CThKQPdF8roMfrpnCR01ll<n29.Vector2> __p_DXvcsTiKZi3Pv7QHkbs2JH;
            [n2.ElementAttribute(TracingId = 321940U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "O8pOwKDG7KzLxmlbd9RwT2", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_O8pOwKDG7KzLxmlbd9RwT2;
            [n2.ElementAttribute(TracingId = 321945U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "N6DxssSuCW2PU5Z3WVIURo", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_N6DxssSuCW2PU5Z3WVIURo;
            [n2.ElementAttribute(TracingId = 321885U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "OjKkk8QC1YyMCCcMty0sFK", Name = "__slot_OjKkk8QC1YyMCCcMty0sFK")]
            public n6.GpuValue<float> __slot_OjKkk8QC1YyMCCcMty0sFK;
            [n2.ElementAttribute(TracingId = 321886U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "KVhMz76HGelNarxRuuPTtD", Name = "__slot_KVhMz76HGelNarxRuuPTtD")]
            public n6.GpuValue<n29.Vector2> __slot_KVhMz76HGelNarxRuuPTtD;
            [n2.ElementAttribute(TracingId = 321937U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BlzvByHn5GwOolRRopgqxk", Name = "__slot_BlzvByHn5GwOolRRopgqxk")]
            public bool __slot_BlzvByHn5GwOolRRopgqxk;
            public __AEsyU74UeFUNUDrtoHqo6l(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __AEsyU74UeFUNUDrtoHqo6l(__AEsyU74UeFUNUDrtoHqo6l other): base(other)
            {
                this.__p_OQXhxXdkhRYPmQ3JP4igQR = other.__p_OQXhxXdkhRYPmQ3JP4igQR;
                this.__p_HbX998xoQYgPJWzjizirAC = other.__p_HbX998xoQYgPJWzjizirAC;
                this.__p_U4NZ8aIp51dM7lOmUW1yNr = other.__p_U4NZ8aIp51dM7lOmUW1yNr;
                this.__p_MPO5dhB2OlULHURhnfktqR = other.__p_MPO5dhB2OlULHURhnfktqR;
                this.__p_KVPjosncVWXQSq92GglHDK = other.__p_KVPjosncVWXQSq92GglHDK;
                this.__p_J1jMdRcNczMMqZdZS7Eqbq = other.__p_J1jMdRcNczMMqZdZS7Eqbq;
                this.__p_NsmSCV3ooXELw3Fnpt0l7K = other.__p_NsmSCV3ooXELw3Fnpt0l7K;
                this.__p_DbmKuH598AXNncq96OaPWS = other.__p_DbmKuH598AXNncq96OaPWS;
                this.__p_LbgDcsFQRFEPN4Tn44UutP = other.__p_LbgDcsFQRFEPN4Tn44UutP;
                this.__p_DXvcsTiKZi3Pv7QHkbs2JH = other.__p_DXvcsTiKZi3Pv7QHkbs2JH;
                this.__p_O8pOwKDG7KzLxmlbd9RwT2 = other.__p_O8pOwKDG7KzLxmlbd9RwT2;
                this.__p_N6DxssSuCW2PU5Z3WVIURo = other.__p_N6DxssSuCW2PU5Z3WVIURo;
                this.__slot_OjKkk8QC1YyMCCcMty0sFK = other.__slot_OjKkk8QC1YyMCCcMty0sFK;
                this.__slot_KVhMz76HGelNarxRuuPTtD = other.__slot_KVhMz76HGelNarxRuuPTtD;
                this.__slot_BlzvByHn5GwOolRRopgqxk = other.__slot_BlzvByHn5GwOolRRopgqxk;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_OQXhxXdkhRYPmQ3JP4igQR", in __p_OQXhxXdkhRYPmQ3JP4igQR), n2.CompilationHelper.GetValueOrExisting(values, "__p_HbX998xoQYgPJWzjizirAC", in __p_HbX998xoQYgPJWzjizirAC), n2.CompilationHelper.GetValueOrExisting(values, "__p_U4NZ8aIp51dM7lOmUW1yNr", in __p_U4NZ8aIp51dM7lOmUW1yNr), n2.CompilationHelper.GetValueOrExisting(values, "__p_MPO5dhB2OlULHURhnfktqR", in __p_MPO5dhB2OlULHURhnfktqR), n2.CompilationHelper.GetValueOrExisting(values, "__p_KVPjosncVWXQSq92GglHDK", in __p_KVPjosncVWXQSq92GglHDK), n2.CompilationHelper.GetValueOrExisting(values, "__p_J1jMdRcNczMMqZdZS7Eqbq", in __p_J1jMdRcNczMMqZdZS7Eqbq), n2.CompilationHelper.GetValueOrExisting(values, "__p_NsmSCV3ooXELw3Fnpt0l7K", in __p_NsmSCV3ooXELw3Fnpt0l7K), n2.CompilationHelper.GetValueOrExisting(values, "__p_DbmKuH598AXNncq96OaPWS", in __p_DbmKuH598AXNncq96OaPWS), n2.CompilationHelper.GetValueOrExisting(values, "__p_LbgDcsFQRFEPN4Tn44UutP", in __p_LbgDcsFQRFEPN4Tn44UutP), n2.CompilationHelper.GetValueOrExisting(values, "__p_DXvcsTiKZi3Pv7QHkbs2JH", in __p_DXvcsTiKZi3Pv7QHkbs2JH), n2.CompilationHelper.GetValueOrExisting(values, "__p_O8pOwKDG7KzLxmlbd9RwT2", in __p_O8pOwKDG7KzLxmlbd9RwT2), n2.CompilationHelper.GetValueOrExisting(values, "__p_N6DxssSuCW2PU5Z3WVIURo", in __p_N6DxssSuCW2PU5Z3WVIURo), n2.CompilationHelper.GetValueOrExisting(values, "__slot_OjKkk8QC1YyMCCcMty0sFK", in __slot_OjKkk8QC1YyMCCcMty0sFK), n2.CompilationHelper.GetValueOrExisting(values, "__slot_KVhMz76HGelNarxRuuPTtD", in __slot_KVhMz76HGelNarxRuuPTtD), n2.CompilationHelper.GetValueOrExisting(values, "__slot_BlzvByHn5GwOolRRopgqxk", in __slot_BlzvByHn5GwOolRRopgqxk));
            }

            internal __AEsyU74UeFUNUDrtoHqo6l __WITH__(n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<float> __p_OQXhxXdkhRYPmQ3JP4igQR, n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<float> __p_HbX998xoQYgPJWzjizirAC, n35.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_U4NZ8aIp51dM7lOmUW1yNr, n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector2> __p_MPO5dhB2OlULHURhnfktqR, n35.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_KVPjosncVWXQSq92GglHDK, n13.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float> __p_J1jMdRcNczMMqZdZS7Eqbq, n35.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_NsmSCV3ooXELw3Fnpt0l7K, n13.ONE_K5Kfj2u1J7gOSuWnHDoU3n<float> __p_DbmKuH598AXNncq96OaPWS, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_LbgDcsFQRFEPN4Tn44UutP, n41.x_CThKQPdF8roMfrpnCR01ll<n29.Vector2> __p_DXvcsTiKZi3Pv7QHkbs2JH, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_O8pOwKDG7KzLxmlbd9RwT2, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_N6DxssSuCW2PU5Z3WVIURo, n6.GpuValue<float> __slot_OjKkk8QC1YyMCCcMty0sFK, n6.GpuValue<n29.Vector2> __slot_KVhMz76HGelNarxRuuPTtD, bool __slot_BlzvByHn5GwOolRRopgqxk)
            {
                __AEsyU74UeFUNUDrtoHqo6l that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_OQXhxXdkhRYPmQ3JP4igQR != this.__p_OQXhxXdkhRYPmQ3JP4igQR || __p_HbX998xoQYgPJWzjizirAC != this.__p_HbX998xoQYgPJWzjizirAC || __p_U4NZ8aIp51dM7lOmUW1yNr != this.__p_U4NZ8aIp51dM7lOmUW1yNr || __p_MPO5dhB2OlULHURhnfktqR != this.__p_MPO5dhB2OlULHURhnfktqR || __p_KVPjosncVWXQSq92GglHDK != this.__p_KVPjosncVWXQSq92GglHDK || __p_J1jMdRcNczMMqZdZS7Eqbq != this.__p_J1jMdRcNczMMqZdZS7Eqbq || __p_NsmSCV3ooXELw3Fnpt0l7K != this.__p_NsmSCV3ooXELw3Fnpt0l7K || __p_DbmKuH598AXNncq96OaPWS != this.__p_DbmKuH598AXNncq96OaPWS || __p_LbgDcsFQRFEPN4Tn44UutP != this.__p_LbgDcsFQRFEPN4Tn44UutP || __p_DXvcsTiKZi3Pv7QHkbs2JH != this.__p_DXvcsTiKZi3Pv7QHkbs2JH || __p_O8pOwKDG7KzLxmlbd9RwT2 != this.__p_O8pOwKDG7KzLxmlbd9RwT2 || __p_N6DxssSuCW2PU5Z3WVIURo != this.__p_N6DxssSuCW2PU5Z3WVIURo || __slot_OjKkk8QC1YyMCCcMty0sFK != this.__slot_OjKkk8QC1YyMCCcMty0sFK || __slot_KVhMz76HGelNarxRuuPTtD != this.__slot_KVhMz76HGelNarxRuuPTtD || __slot_BlzvByHn5GwOolRRopgqxk != this.__slot_BlzvByHn5GwOolRRopgqxk ? new __AEsyU74UeFUNUDrtoHqo6l(this)
                    {__p_OQXhxXdkhRYPmQ3JP4igQR = __p_OQXhxXdkhRYPmQ3JP4igQR, __p_HbX998xoQYgPJWzjizirAC = __p_HbX998xoQYgPJWzjizirAC, __p_U4NZ8aIp51dM7lOmUW1yNr = __p_U4NZ8aIp51dM7lOmUW1yNr, __p_MPO5dhB2OlULHURhnfktqR = __p_MPO5dhB2OlULHURhnfktqR, __p_KVPjosncVWXQSq92GglHDK = __p_KVPjosncVWXQSq92GglHDK, __p_J1jMdRcNczMMqZdZS7Eqbq = __p_J1jMdRcNczMMqZdZS7Eqbq, __p_NsmSCV3ooXELw3Fnpt0l7K = __p_NsmSCV3ooXELw3Fnpt0l7K, __p_DbmKuH598AXNncq96OaPWS = __p_DbmKuH598AXNncq96OaPWS, __p_LbgDcsFQRFEPN4Tn44UutP = __p_LbgDcsFQRFEPN4Tn44UutP, __p_DXvcsTiKZi3Pv7QHkbs2JH = __p_DXvcsTiKZi3Pv7QHkbs2JH, __p_O8pOwKDG7KzLxmlbd9RwT2 = __p_O8pOwKDG7KzLxmlbd9RwT2, __p_N6DxssSuCW2PU5Z3WVIURo = __p_N6DxssSuCW2PU5Z3WVIURo, __slot_OjKkk8QC1YyMCCcMty0sFK = __slot_OjKkk8QC1YyMCCcMty0sFK, __slot_KVhMz76HGelNarxRuuPTtD = __slot_KVhMz76HGelNarxRuuPTtD, __slot_BlzvByHn5GwOolRRopgqxk = __slot_BlzvByHn5GwOolRRopgqxk} : that_0;
                else
                {
                    this.__p_OQXhxXdkhRYPmQ3JP4igQR = __p_OQXhxXdkhRYPmQ3JP4igQR;
                    this.__p_HbX998xoQYgPJWzjizirAC = __p_HbX998xoQYgPJWzjizirAC;
                    this.__p_U4NZ8aIp51dM7lOmUW1yNr = __p_U4NZ8aIp51dM7lOmUW1yNr;
                    this.__p_MPO5dhB2OlULHURhnfktqR = __p_MPO5dhB2OlULHURhnfktqR;
                    this.__p_KVPjosncVWXQSq92GglHDK = __p_KVPjosncVWXQSq92GglHDK;
                    this.__p_J1jMdRcNczMMqZdZS7Eqbq = __p_J1jMdRcNczMMqZdZS7Eqbq;
                    this.__p_NsmSCV3ooXELw3Fnpt0l7K = __p_NsmSCV3ooXELw3Fnpt0l7K;
                    this.__p_DbmKuH598AXNncq96OaPWS = __p_DbmKuH598AXNncq96OaPWS;
                    this.__p_LbgDcsFQRFEPN4Tn44UutP = __p_LbgDcsFQRFEPN4Tn44UutP;
                    this.__p_DXvcsTiKZi3Pv7QHkbs2JH = __p_DXvcsTiKZi3Pv7QHkbs2JH;
                    this.__p_O8pOwKDG7KzLxmlbd9RwT2 = __p_O8pOwKDG7KzLxmlbd9RwT2;
                    this.__p_N6DxssSuCW2PU5Z3WVIURo = __p_N6DxssSuCW2PU5Z3WVIURo;
                    this.__slot_OjKkk8QC1YyMCCcMty0sFK = __slot_OjKkk8QC1YyMCCcMty0sFK;
                    this.__slot_KVhMz76HGelNarxRuuPTtD = __slot_KVhMz76HGelNarxRuuPTtD;
                    this.__slot_BlzvByHn5GwOolRRopgqxk = __slot_BlzvByHn5GwOolRRopgqxk;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 322097U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "QeTRBCjJuAjQE1NHmAmea8", Name = "WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8")]
    [n3.SerializableAttribute]
    public class WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8 : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8 Create(n2.NodeContext Node_Context)
        {
            var instance = new WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8 CreateDefault()
        {
            var instance = new WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8 Update(n6.GpuValue<n29.Vector2> TDomain_In, n6.GpuValue<float> Time_In, [n5.SerializedDefaultValueAttribute("2, 2", false)] n6.GpuValue<n29.Vector2> Frequency_In, [n5.SerializedDefaultValueAttribute("1", false)] n6.GpuValue<float> Amplitude_In, [n5.SerializedDefaultValueAttribute("0, 0", false)] n6.GpuValue<n29.Vector2> Offset_In, [n5.SerializedDefaultValueAttribute("0", false)] n6.GpuValue<float> Center_In, [n5.SerializedDefaultValueAttribute("0.5", false)] n6.GpuValue<float> Bias_In, [n5.SerializedDefaultValueAttribute("0.01", false)] n6.GpuValue<float> Smooth_In, [n5.SerializedDefaultValueAttribute("0.7", false)] n6.GpuValue<float> Jitter_In, n23.DistanceMetricsSelector Metric_In, [n5.SerializedDefaultValueAttribute("4", false)] n6.GpuValue<float> Minkowski_Power_In, out n6.GpuValue<float> Output_Out, out n6.GpuValue<n29.Vector2> Cell_Position_Out, out n6.GpuValue<float> Cell_ID_Out)
        {
            bool __pad_L0c4DR5QG7zLvvRFy7hI6b_0 = __slot_L0c4DR5QG7zLvvRFy7hI6b;
            n32.ObjectHelpers.IsAssigned(x: Time_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_IiwVyomd49uQCUQUvUDud2;
            if (manager_4 is null)
            {
                manager_4 = new n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>>>((default(n6.GpuValue<float>), default(n6.GpuValue<n29.Vector2>), default(n6.GpuValue<float>)));
            }

            var inputs_5 = (Result_1, TDomain_In, Time_In, Frequency_In, Amplitude_In, Offset_In, Center_In, Bias_In, Smooth_In, Jitter_In, Metric_In, Minkowski_Power_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = __pad_L0c4DR5QG7zLvvRFy7hI6b_0 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n2.CompilationHelper.Restore<__GkUZfLauKImQZFHTzVfXOd>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __GkUZfLauKImQZFHTzVfXOd(__GetContext__(), n2.VLObject.NewIdentity());
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "PG0eblKaqHBL4iJHHgHFpk", 322122U);
                    var Output_10 = n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector2>.Create(Node_Context: Node_Context_9);
                    state_8.__p_PG0eblKaqHBL4iJHHgHFpk = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Siwc9LananqOfYPhbq5AUp", 322136U);
                    var Output_12 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector2>.Create(Node_Context: Node_Context_11);
                    state_8.__p_Siwc9LananqOfYPhbq5AUp = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "KuqW1XvEP1FOVHwnh2bPe5", 322139U);
                    var Output_14 = n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector3>.Create(Node_Context: Node_Context_13);
                    state_8.__p_KuqW1XvEP1FOVHwnh2bPe5 = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "CPeypS3oFADOzrBd5HX74d", 322153U);
                    var Output_16 = n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr.Create(Node_Context: Node_Context_15);
                    state_8.__p_CPeypS3oFADOzrBd5HX74d = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "ANRQg2tquYBO4OQAgUqrT9", 322162U);
                    var Output_18 = n13.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float>.Create(Node_Context: Node_Context_17);
                    state_8.__p_ANRQg2tquYBO4OQAgUqrT9 = Output_18;
                    n2.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "LGnGOBnQu2uMpPSV3j3mS8", 322164U);
                    var Output_20 = n13.ONE_K5Kfj2u1J7gOSuWnHDoU3n<float>.Create(Node_Context: Node_Context_19);
                    state_8.__p_LGnGOBnQu2uMpPSV3j3mS8 = Output_20;
                    n46._Operations_.WorleySmooth2DID(Output_Out: out string Output_21);
                    n2.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "AUIHbiedpwSMXdkqfTcQ7w", 322166U);
                    var Output_23 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_22, ID_In: Output_21);
                    state_8.__p_AUIHbiedpwSMXdkqfTcQ7w = Output_23;
                    n46._Operations_.WorleySmooth2DCellID(Output_Out: out string Output_24);
                    n2.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "SAXhSkTq9pIPXZb5iFJlPR", 322183U);
                    var Output_26 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_25, ID_In: Output_24);
                    state_8.__p_SAXhSkTq9pIPXZb5iFJlPR = Output_26;
                    n46._Operations_.WorleySmooth2DCellPosID(Output_Out: out string Output_27);
                    n2.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "CRx0MSK6e2wNS5uQQmNJ3V", 322186U);
                    var Output_29 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_28, ID_In: Output_27);
                    state_8.__p_CRx0MSK6e2wNS5uQQmNJ3V = Output_29;
                    n2.NodeContext Node_Context_30 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "JE4hgUuiflLO9AnwwaC0v5", 322195U);
                    var Output_31 = n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr.Create(Node_Context: Node_Context_30);
                    state_8.__p_JE4hgUuiflLO9AnwwaC0v5 = Output_31;
                    n2.NodeContext Node_Context_32 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "C4eNu2aFBnWPpvjXmke3rw", 322199U);
                    var Output_33 = n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr.Create(Node_Context: Node_Context_32);
                    state_8.__p_C4eNu2aFBnWPpvjXmke3rw = Output_33;
                    n2.NodeContext Node_Context_34 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "IUYVb1IXfmvO9nDU7lUOPC", 322203U);
                    var Output_35 = n41.xy_EiegIBeM6c8OnN5CcRLRyU<n29.Vector3>.Create(Node_Context: Node_Context_34);
                    state_8.__p_IUYVb1IXfmvO9nDU7lUOPC = Output_35;
                }

                int Id_36 = 0;
                var State_Output_38 = state_8.__p_Siwc9LananqOfYPhbq5AUp.Update(The_Override_In: TDomain_In, Id_In: Id_36, Output_Out: out n6.GpuValue<n29.Vector2> Output_37);
                n26._Operations_.TypeVector2(Input_In: Output_37, Output_Out: out n6.GpuValue<n29.Vector2> Output_39);
                var State_Output_43 = state_8.__p_PG0eblKaqHBL4iJHHgHFpk.Update(TDomain_In: Output_39, Frequency_In: Frequency_In, Amplitude_In: Amplitude_In, Center_In: Center_In, Bias_In: Bias_In, Offset_In: Offset_In, Smooth_In: Smooth_In, Jitter_In: Jitter_In, Metric_In: Metric_In, Minkowski_Power_In: Minkowski_Power_In, Output_Out: out n6.GpuValue<float> Output_40, Cell_Position_Out: out n6.GpuValue<n29.Vector2> Cell_Position_41, Cell_ID_Out: out n6.GpuValue<float> Cell_ID_42);
                var State_Output_45 = state_8.__p_JE4hgUuiflLO9AnwwaC0v5.Update(xy_In: Output_39, z_In: Time_In, Output_Out: out n6.GpuValue<n29.Vector3> Output_44);
                var State_Output_47 = state_8.__p_LGnGOBnQu2uMpPSV3j3mS8.Update(Output_Out: out n6.GpuValue<float> Output_46);
                var State_Output_49 = state_8.__p_C4eNu2aFBnWPpvjXmke3rw.Update(xy_In: Frequency_In, z_In: Output_46, Output_Out: out n6.GpuValue<n29.Vector3> Output_48);
                var State_Output_51 = state_8.__p_ANRQg2tquYBO4OQAgUqrT9.Update(Output_Out: out n6.GpuValue<float> Output_50);
                var State_Output_53 = state_8.__p_CPeypS3oFADOzrBd5HX74d.Update(xy_In: Offset_In, z_In: Output_50, Output_Out: out n6.GpuValue<n29.Vector3> Output_52);
                var State_Output_57 = state_8.__p_KuqW1XvEP1FOVHwnh2bPe5.Update(TDomain_In: Output_44, Frequency_In: Output_48, Amplitude_In: Amplitude_In, Center_In: Center_In, Bias_In: Bias_In, Offset_In: Output_52, Smooth_In: Smooth_In, Jitter_In: Jitter_In, Metric_In: Metric_In, Minkowski_Power_In: Minkowski_Power_In, Output_Out: out n6.GpuValue<float> Output_54, Cell_Position_Out: out n6.GpuValue<n29.Vector3> Cell_Position_55, Cell_ID_Out: out n6.GpuValue<float> Cell_ID_56);
                bool __pad_HFOBqrnMjERPixpwcIFhG6_58 = Result_1;
                n37._Operations_.Switch_Boolean<n6.GpuValue<float>>(Condition_In: __pad_HFOBqrnMjERPixpwcIFhG6_58, Input_In: Output_40, Input_2_In: Output_54, Output_Out: out n6.GpuValue<float> Output_59);
                n26._Operations_.TypeFloat(Input_In: Output_59, Output_Out: out n6.GpuValue<float> Output_60);
                bool Update_61 = true;
                var Output_62 = state_8.__p_AUIHbiedpwSMXdkqfTcQ7w;
                if (Update_61)
                {
                    Output_62 = state_8.__p_AUIHbiedpwSMXdkqfTcQ7w.Update(Input_In: Output_60);
                }

                var State_Output_64 = state_8.__p_IUYVb1IXfmvO9nDU7lUOPC.Update(Input_In: Cell_Position_55, Output_Out: out n6.GpuValue<n29.Vector2> Output_63);
                n37._Operations_.Switch_Boolean<n6.GpuValue<n29.Vector2>>(Condition_In: __pad_HFOBqrnMjERPixpwcIFhG6_58, Input_In: Cell_Position_41, Input_2_In: Output_63, Output_Out: out n6.GpuValue<n29.Vector2> Output_65);
                n26._Operations_.TypeVector2(Input_In: Output_65, Output_Out: out n6.GpuValue<n29.Vector2> Output_66);
                bool Update_67 = true;
                var Output_68 = state_8.__p_CRx0MSK6e2wNS5uQQmNJ3V;
                if (Update_67)
                {
                    Output_68 = state_8.__p_CRx0MSK6e2wNS5uQQmNJ3V.Update(Input_In: Output_66);
                }

                n37._Operations_.Switch_Boolean<n6.GpuValue<float>>(Condition_In: __pad_HFOBqrnMjERPixpwcIFhG6_58, Input_In: Cell_ID_42, Input_2_In: Cell_ID_56, Output_Out: out n6.GpuValue<float> Output_69);
                bool Update_70 = true;
                var Output_71 = state_8.__p_SAXhSkTq9pIPXZb5iFJlPR;
                if (Update_70)
                {
                    Output_71 = state_8.__p_SAXhSkTq9pIPXZb5iFJlPR.Update(Input_In: Output_69);
                }

                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_38 != state_8.__p_Siwc9LananqOfYPhbq5AUp || State_Output_43 != state_8.__p_PG0eblKaqHBL4iJHHgHFpk || State_Output_45 != state_8.__p_JE4hgUuiflLO9AnwwaC0v5 || State_Output_47 != state_8.__p_LGnGOBnQu2uMpPSV3j3mS8 || State_Output_49 != state_8.__p_C4eNu2aFBnWPpvjXmke3rw || State_Output_51 != state_8.__p_ANRQg2tquYBO4OQAgUqrT9 || State_Output_53 != state_8.__p_CPeypS3oFADOzrBd5HX74d || State_Output_57 != state_8.__p_KuqW1XvEP1FOVHwnh2bPe5 || Result_1 != state_8.__slot_HFOBqrnMjERPixpwcIFhG6 || Output_62 != state_8.__p_AUIHbiedpwSMXdkqfTcQ7w || State_Output_64 != state_8.__p_IUYVb1IXfmvO9nDU7lUOPC || Output_68 != state_8.__p_CRx0MSK6e2wNS5uQQmNJ3V || Output_71 != state_8.__p_SAXhSkTq9pIPXZb5iFJlPR ? new __GkUZfLauKImQZFHTzVfXOd(state_8)
                    {__p_Siwc9LananqOfYPhbq5AUp = State_Output_38, __p_PG0eblKaqHBL4iJHHgHFpk = State_Output_43, __p_JE4hgUuiflLO9AnwwaC0v5 = State_Output_45, __p_LGnGOBnQu2uMpPSV3j3mS8 = State_Output_47, __p_C4eNu2aFBnWPpvjXmke3rw = State_Output_49, __p_ANRQg2tquYBO4OQAgUqrT9 = State_Output_51, __p_CPeypS3oFADOzrBd5HX74d = State_Output_53, __p_KuqW1XvEP1FOVHwnh2bPe5 = State_Output_57, __slot_HFOBqrnMjERPixpwcIFhG6 = Result_1, __p_AUIHbiedpwSMXdkqfTcQ7w = Output_62, __p_IUYVb1IXfmvO9nDU7lUOPC = State_Output_64, __p_CRx0MSK6e2wNS5uQQmNJ3V = Output_68, __p_SAXhSkTq9pIPXZb5iFJlPR = Output_71} : state_8;
                else
                {
                    state_8.__p_Siwc9LananqOfYPhbq5AUp = State_Output_38;
                    state_8.__p_PG0eblKaqHBL4iJHHgHFpk = State_Output_43;
                    state_8.__p_JE4hgUuiflLO9AnwwaC0v5 = State_Output_45;
                    state_8.__p_LGnGOBnQu2uMpPSV3j3mS8 = State_Output_47;
                    state_8.__p_C4eNu2aFBnWPpvjXmke3rw = State_Output_49;
                    state_8.__p_ANRQg2tquYBO4OQAgUqrT9 = State_Output_51;
                    state_8.__p_CPeypS3oFADOzrBd5HX74d = State_Output_53;
                    state_8.__p_KuqW1XvEP1FOVHwnh2bPe5 = State_Output_57;
                    state_8.__slot_HFOBqrnMjERPixpwcIFhG6 = Result_1;
                    state_8.__p_AUIHbiedpwSMXdkqfTcQ7w = Output_62;
                    state_8.__p_IUYVb1IXfmvO9nDU7lUOPC = State_Output_64;
                    state_8.__p_CRx0MSK6e2wNS5uQQmNJ3V = Output_68;
                    state_8.__p_SAXhSkTq9pIPXZb5iFJlPR = Output_71;
                }

                outputs_6 = (Output_60, Output_66, Output_69);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var(__auto_72, __auto_73, __auto_74) = outputs_6;
            Output_Out = __auto_72;
            Cell_Position_Out = __auto_73;
            Cell_ID_Out = __auto_74;
            n4.WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8 that_75 = this;
            if (this.__GetContext__().IsImmutable)
                that_75 = manager_4 != this.__cache_IiwVyomd49uQCUQUvUDud2 ? new WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8(this)
                {__cache_IiwVyomd49uQCUQUvUDud2 = manager_4} : that_75;
            else
            {
                this.__cache_IiwVyomd49uQCUQUvUDud2 = manager_4;
            }

            return that_75;
        }

        public n4.WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8 __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8 that_0 = this;
            this.__cache_IiwVyomd49uQCUQUvUDud2 = null;
            return that_0;
        }

        public n4.WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8 __CreateDefault__()
        {
            n4.WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8 that_0 = this;
            this.__cache_IiwVyomd49uQCUQUvUDud2 = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_IiwVyomd49uQCUQUvUDud2);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 322224U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "L0c4DR5QG7zLvvRFy7hI6b", Name = "__slot_L0c4DR5QG7zLvvRFy7hI6b")]
        public static bool __slot_L0c4DR5QG7zLvvRFy7hI6b = false;
        [n2.ElementAttribute(TracingId = 322100U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "IiwVyomd49uQCUQUvUDud2", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>>> __cache_IiwVyomd49uQCUQUvUDud2 = null;
        static WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8()
        {
        }

        public WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8(WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8 other): base(other)
        {
            this.__cache_IiwVyomd49uQCUQUvUDud2 = other.__cache_IiwVyomd49uQCUQUvUDud2;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_IiwVyomd49uQCUQUvUDud2", in __cache_IiwVyomd49uQCUQUvUDud2));
        }

        internal WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8 __WITH__(n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<n29.Vector2>, n6.GpuValue<float>>> __cache_IiwVyomd49uQCUQUvUDud2)
        {
            n4.WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_IiwVyomd49uQCUQUvUDud2 != this.__cache_IiwVyomd49uQCUQUvUDud2 ? new WorleyNoise__2D_Scalar_QeTRBCjJuAjQE1NHmAmea8(this)
                {__cache_IiwVyomd49uQCUQUvUDud2 = __cache_IiwVyomd49uQCUQUvUDud2} : that_0;
            else
            {
                this.__cache_IiwVyomd49uQCUQUvUDud2 = __cache_IiwVyomd49uQCUQUvUDud2;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "GkUZfLauKImQZFHTzVfXOd", Name = "__GkUZfLauKImQZFHTzVfXOd")]
        [n3.SerializableAttribute]
        public class __GkUZfLauKImQZFHTzVfXOd : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_PG0eblKaqHBL4iJHHgHFpk);
                n2.CompilationHelper.SafeDispose(this.__p_Siwc9LananqOfYPhbq5AUp);
                n2.CompilationHelper.SafeDispose(this.__p_KuqW1XvEP1FOVHwnh2bPe5);
                n2.CompilationHelper.SafeDispose(this.__p_CPeypS3oFADOzrBd5HX74d);
                n2.CompilationHelper.SafeDispose(this.__p_ANRQg2tquYBO4OQAgUqrT9);
                n2.CompilationHelper.SafeDispose(this.__p_LGnGOBnQu2uMpPSV3j3mS8);
                n2.CompilationHelper.SafeDispose(this.__p_AUIHbiedpwSMXdkqfTcQ7w);
                n2.CompilationHelper.SafeDispose(this.__p_SAXhSkTq9pIPXZb5iFJlPR);
                n2.CompilationHelper.SafeDispose(this.__p_CRx0MSK6e2wNS5uQQmNJ3V);
                n2.CompilationHelper.SafeDispose(this.__p_JE4hgUuiflLO9AnwwaC0v5);
                n2.CompilationHelper.SafeDispose(this.__p_C4eNu2aFBnWPpvjXmke3rw);
                n2.CompilationHelper.SafeDispose(this.__p_IUYVb1IXfmvO9nDU7lUOPC);
                return;
            }

            [n2.ElementAttribute(TracingId = 322122U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "PG0eblKaqHBL4iJHHgHFpk", Name = "WorleyNoise", IsManaged = true, IsAutoGenerated = true)]
            public n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector2> __p_PG0eblKaqHBL4iJHHgHFpk;
            [n2.ElementAttribute(TracingId = 322136U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Siwc9LananqOfYPhbq5AUp", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector2> __p_Siwc9LananqOfYPhbq5AUp;
            [n2.ElementAttribute(TracingId = 322139U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "KuqW1XvEP1FOVHwnh2bPe5", Name = "WorleyNoise", IsManaged = true, IsAutoGenerated = true)]
            public n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector3> __p_KuqW1XvEP1FOVHwnh2bPe5;
            [n2.ElementAttribute(TracingId = 322153U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "CPeypS3oFADOzrBd5HX74d", Name = "xy+z (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_CPeypS3oFADOzrBd5HX74d;
            [n2.ElementAttribute(TracingId = 322162U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "ANRQg2tquYBO4OQAgUqrT9", Name = "ZERO", IsManaged = true, IsAutoGenerated = true)]
            public n13.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float> __p_ANRQg2tquYBO4OQAgUqrT9;
            [n2.ElementAttribute(TracingId = 322164U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LGnGOBnQu2uMpPSV3j3mS8", Name = "ONE", IsManaged = true, IsAutoGenerated = true)]
            public n13.ONE_K5Kfj2u1J7gOSuWnHDoU3n<float> __p_LGnGOBnQu2uMpPSV3j3mS8;
            [n2.ElementAttribute(TracingId = 322166U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "AUIHbiedpwSMXdkqfTcQ7w", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_AUIHbiedpwSMXdkqfTcQ7w;
            [n2.ElementAttribute(TracingId = 322183U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SAXhSkTq9pIPXZb5iFJlPR", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_SAXhSkTq9pIPXZb5iFJlPR;
            [n2.ElementAttribute(TracingId = 322186U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "CRx0MSK6e2wNS5uQQmNJ3V", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_CRx0MSK6e2wNS5uQQmNJ3V;
            [n2.ElementAttribute(TracingId = 322195U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "JE4hgUuiflLO9AnwwaC0v5", Name = "xy+z (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_JE4hgUuiflLO9AnwwaC0v5;
            [n2.ElementAttribute(TracingId = 322199U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "C4eNu2aFBnWPpvjXmke3rw", Name = "xy+z (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_C4eNu2aFBnWPpvjXmke3rw;
            [n2.ElementAttribute(TracingId = 322203U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "IUYVb1IXfmvO9nDU7lUOPC", Name = "xy", IsManaged = true, IsAutoGenerated = true)]
            public n41.xy_EiegIBeM6c8OnN5CcRLRyU<n29.Vector3> __p_IUYVb1IXfmvO9nDU7lUOPC;
            [n2.ElementAttribute(TracingId = 322182U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HFOBqrnMjERPixpwcIFhG6", Name = "__slot_HFOBqrnMjERPixpwcIFhG6")]
            public bool __slot_HFOBqrnMjERPixpwcIFhG6;
            public __GkUZfLauKImQZFHTzVfXOd(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __GkUZfLauKImQZFHTzVfXOd(__GkUZfLauKImQZFHTzVfXOd other): base(other)
            {
                this.__p_PG0eblKaqHBL4iJHHgHFpk = other.__p_PG0eblKaqHBL4iJHHgHFpk;
                this.__p_Siwc9LananqOfYPhbq5AUp = other.__p_Siwc9LananqOfYPhbq5AUp;
                this.__p_KuqW1XvEP1FOVHwnh2bPe5 = other.__p_KuqW1XvEP1FOVHwnh2bPe5;
                this.__p_CPeypS3oFADOzrBd5HX74d = other.__p_CPeypS3oFADOzrBd5HX74d;
                this.__p_ANRQg2tquYBO4OQAgUqrT9 = other.__p_ANRQg2tquYBO4OQAgUqrT9;
                this.__p_LGnGOBnQu2uMpPSV3j3mS8 = other.__p_LGnGOBnQu2uMpPSV3j3mS8;
                this.__p_AUIHbiedpwSMXdkqfTcQ7w = other.__p_AUIHbiedpwSMXdkqfTcQ7w;
                this.__p_SAXhSkTq9pIPXZb5iFJlPR = other.__p_SAXhSkTq9pIPXZb5iFJlPR;
                this.__p_CRx0MSK6e2wNS5uQQmNJ3V = other.__p_CRx0MSK6e2wNS5uQQmNJ3V;
                this.__p_JE4hgUuiflLO9AnwwaC0v5 = other.__p_JE4hgUuiflLO9AnwwaC0v5;
                this.__p_C4eNu2aFBnWPpvjXmke3rw = other.__p_C4eNu2aFBnWPpvjXmke3rw;
                this.__p_IUYVb1IXfmvO9nDU7lUOPC = other.__p_IUYVb1IXfmvO9nDU7lUOPC;
                this.__slot_HFOBqrnMjERPixpwcIFhG6 = other.__slot_HFOBqrnMjERPixpwcIFhG6;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_PG0eblKaqHBL4iJHHgHFpk", in __p_PG0eblKaqHBL4iJHHgHFpk), n2.CompilationHelper.GetValueOrExisting(values, "__p_Siwc9LananqOfYPhbq5AUp", in __p_Siwc9LananqOfYPhbq5AUp), n2.CompilationHelper.GetValueOrExisting(values, "__p_KuqW1XvEP1FOVHwnh2bPe5", in __p_KuqW1XvEP1FOVHwnh2bPe5), n2.CompilationHelper.GetValueOrExisting(values, "__p_CPeypS3oFADOzrBd5HX74d", in __p_CPeypS3oFADOzrBd5HX74d), n2.CompilationHelper.GetValueOrExisting(values, "__p_ANRQg2tquYBO4OQAgUqrT9", in __p_ANRQg2tquYBO4OQAgUqrT9), n2.CompilationHelper.GetValueOrExisting(values, "__p_LGnGOBnQu2uMpPSV3j3mS8", in __p_LGnGOBnQu2uMpPSV3j3mS8), n2.CompilationHelper.GetValueOrExisting(values, "__p_AUIHbiedpwSMXdkqfTcQ7w", in __p_AUIHbiedpwSMXdkqfTcQ7w), n2.CompilationHelper.GetValueOrExisting(values, "__p_SAXhSkTq9pIPXZb5iFJlPR", in __p_SAXhSkTq9pIPXZb5iFJlPR), n2.CompilationHelper.GetValueOrExisting(values, "__p_CRx0MSK6e2wNS5uQQmNJ3V", in __p_CRx0MSK6e2wNS5uQQmNJ3V), n2.CompilationHelper.GetValueOrExisting(values, "__p_JE4hgUuiflLO9AnwwaC0v5", in __p_JE4hgUuiflLO9AnwwaC0v5), n2.CompilationHelper.GetValueOrExisting(values, "__p_C4eNu2aFBnWPpvjXmke3rw", in __p_C4eNu2aFBnWPpvjXmke3rw), n2.CompilationHelper.GetValueOrExisting(values, "__p_IUYVb1IXfmvO9nDU7lUOPC", in __p_IUYVb1IXfmvO9nDU7lUOPC), n2.CompilationHelper.GetValueOrExisting(values, "__slot_HFOBqrnMjERPixpwcIFhG6", in __slot_HFOBqrnMjERPixpwcIFhG6));
            }

            internal __GkUZfLauKImQZFHTzVfXOd __WITH__(n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector2> __p_PG0eblKaqHBL4iJHHgHFpk, n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector2> __p_Siwc9LananqOfYPhbq5AUp, n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector3> __p_KuqW1XvEP1FOVHwnh2bPe5, n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_CPeypS3oFADOzrBd5HX74d, n13.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float> __p_ANRQg2tquYBO4OQAgUqrT9, n13.ONE_K5Kfj2u1J7gOSuWnHDoU3n<float> __p_LGnGOBnQu2uMpPSV3j3mS8, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_AUIHbiedpwSMXdkqfTcQ7w, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_SAXhSkTq9pIPXZb5iFJlPR, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_CRx0MSK6e2wNS5uQQmNJ3V, n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_JE4hgUuiflLO9AnwwaC0v5, n35.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_C4eNu2aFBnWPpvjXmke3rw, n41.xy_EiegIBeM6c8OnN5CcRLRyU<n29.Vector3> __p_IUYVb1IXfmvO9nDU7lUOPC, bool __slot_HFOBqrnMjERPixpwcIFhG6)
            {
                __GkUZfLauKImQZFHTzVfXOd that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_PG0eblKaqHBL4iJHHgHFpk != this.__p_PG0eblKaqHBL4iJHHgHFpk || __p_Siwc9LananqOfYPhbq5AUp != this.__p_Siwc9LananqOfYPhbq5AUp || __p_KuqW1XvEP1FOVHwnh2bPe5 != this.__p_KuqW1XvEP1FOVHwnh2bPe5 || __p_CPeypS3oFADOzrBd5HX74d != this.__p_CPeypS3oFADOzrBd5HX74d || __p_ANRQg2tquYBO4OQAgUqrT9 != this.__p_ANRQg2tquYBO4OQAgUqrT9 || __p_LGnGOBnQu2uMpPSV3j3mS8 != this.__p_LGnGOBnQu2uMpPSV3j3mS8 || __p_AUIHbiedpwSMXdkqfTcQ7w != this.__p_AUIHbiedpwSMXdkqfTcQ7w || __p_SAXhSkTq9pIPXZb5iFJlPR != this.__p_SAXhSkTq9pIPXZb5iFJlPR || __p_CRx0MSK6e2wNS5uQQmNJ3V != this.__p_CRx0MSK6e2wNS5uQQmNJ3V || __p_JE4hgUuiflLO9AnwwaC0v5 != this.__p_JE4hgUuiflLO9AnwwaC0v5 || __p_C4eNu2aFBnWPpvjXmke3rw != this.__p_C4eNu2aFBnWPpvjXmke3rw || __p_IUYVb1IXfmvO9nDU7lUOPC != this.__p_IUYVb1IXfmvO9nDU7lUOPC || __slot_HFOBqrnMjERPixpwcIFhG6 != this.__slot_HFOBqrnMjERPixpwcIFhG6 ? new __GkUZfLauKImQZFHTzVfXOd(this)
                    {__p_PG0eblKaqHBL4iJHHgHFpk = __p_PG0eblKaqHBL4iJHHgHFpk, __p_Siwc9LananqOfYPhbq5AUp = __p_Siwc9LananqOfYPhbq5AUp, __p_KuqW1XvEP1FOVHwnh2bPe5 = __p_KuqW1XvEP1FOVHwnh2bPe5, __p_CPeypS3oFADOzrBd5HX74d = __p_CPeypS3oFADOzrBd5HX74d, __p_ANRQg2tquYBO4OQAgUqrT9 = __p_ANRQg2tquYBO4OQAgUqrT9, __p_LGnGOBnQu2uMpPSV3j3mS8 = __p_LGnGOBnQu2uMpPSV3j3mS8, __p_AUIHbiedpwSMXdkqfTcQ7w = __p_AUIHbiedpwSMXdkqfTcQ7w, __p_SAXhSkTq9pIPXZb5iFJlPR = __p_SAXhSkTq9pIPXZb5iFJlPR, __p_CRx0MSK6e2wNS5uQQmNJ3V = __p_CRx0MSK6e2wNS5uQQmNJ3V, __p_JE4hgUuiflLO9AnwwaC0v5 = __p_JE4hgUuiflLO9AnwwaC0v5, __p_C4eNu2aFBnWPpvjXmke3rw = __p_C4eNu2aFBnWPpvjXmke3rw, __p_IUYVb1IXfmvO9nDU7lUOPC = __p_IUYVb1IXfmvO9nDU7lUOPC, __slot_HFOBqrnMjERPixpwcIFhG6 = __slot_HFOBqrnMjERPixpwcIFhG6} : that_0;
                else
                {
                    this.__p_PG0eblKaqHBL4iJHHgHFpk = __p_PG0eblKaqHBL4iJHHgHFpk;
                    this.__p_Siwc9LananqOfYPhbq5AUp = __p_Siwc9LananqOfYPhbq5AUp;
                    this.__p_KuqW1XvEP1FOVHwnh2bPe5 = __p_KuqW1XvEP1FOVHwnh2bPe5;
                    this.__p_CPeypS3oFADOzrBd5HX74d = __p_CPeypS3oFADOzrBd5HX74d;
                    this.__p_ANRQg2tquYBO4OQAgUqrT9 = __p_ANRQg2tquYBO4OQAgUqrT9;
                    this.__p_LGnGOBnQu2uMpPSV3j3mS8 = __p_LGnGOBnQu2uMpPSV3j3mS8;
                    this.__p_AUIHbiedpwSMXdkqfTcQ7w = __p_AUIHbiedpwSMXdkqfTcQ7w;
                    this.__p_SAXhSkTq9pIPXZb5iFJlPR = __p_SAXhSkTq9pIPXZb5iFJlPR;
                    this.__p_CRx0MSK6e2wNS5uQQmNJ3V = __p_CRx0MSK6e2wNS5uQQmNJ3V;
                    this.__p_JE4hgUuiflLO9AnwwaC0v5 = __p_JE4hgUuiflLO9AnwwaC0v5;
                    this.__p_C4eNu2aFBnWPpvjXmke3rw = __p_C4eNu2aFBnWPpvjXmke3rw;
                    this.__p_IUYVb1IXfmvO9nDU7lUOPC = __p_IUYVb1IXfmvO9nDU7lUOPC;
                    this.__slot_HFOBqrnMjERPixpwcIFhG6 = __slot_HFOBqrnMjERPixpwcIFhG6;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 322355U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "OKUU3U50Q9QPwdxc68aSHX", Name = "WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX")]
    [n3.SerializableAttribute]
    public class WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX Create(n2.NodeContext Node_Context)
        {
            var instance = new WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX CreateDefault()
        {
            var instance = new WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX Update(n6.GpuValue<n29.Vector3> TDomain_In, n6.GpuValue<float> Time_In, [n5.SerializedDefaultValueAttribute("2, 2, 2", false)] n6.GpuValue<n29.Vector3> Frequency_In, [n5.SerializedDefaultValueAttribute("1", false)] n6.GpuValue<float> Amplitude_In, [n5.SerializedDefaultValueAttribute("0, 0", false)] n6.GpuValue<n29.Vector3> Offset_In, [n5.SerializedDefaultValueAttribute("0", false)] n6.GpuValue<float> Center_In, [n5.SerializedDefaultValueAttribute("0.5", false)] n6.GpuValue<float> Bias_In, [n5.SerializedDefaultValueAttribute("0.01", false)] n6.GpuValue<float> Smooth_In, [n5.SerializedDefaultValueAttribute("0.7", false)] n6.GpuValue<float> Jitter_In, n23.DistanceMetricsSelector Metric_In, [n5.SerializedDefaultValueAttribute("4", false)] n6.GpuValue<float> Minkowski_Power_In, out n6.GpuValue<float> Output_Out, out n6.GpuValue<n29.Vector3> Cell_Position_Out, out n6.GpuValue<float> Cell_ID_Out)
        {
            bool __pad_RapOzBVT6lWMfNKrxg41LS_0 = __slot_RapOzBVT6lWMfNKrxg41LS;
            n32.ObjectHelpers.IsAssigned(x: Time_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_NiXcxUjdioIMgyv3GY5cM7;
            if (manager_4 is null)
            {
                manager_4 = new n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>>>((default(n6.GpuValue<float>), default(n6.GpuValue<n29.Vector3>), default(n6.GpuValue<float>)));
            }

            var inputs_5 = (Result_1, TDomain_In, Time_In, Frequency_In, Amplitude_In, Offset_In, Center_In, Bias_In, Smooth_In, Jitter_In, Metric_In, Minkowski_Power_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = __pad_RapOzBVT6lWMfNKrxg41LS_0 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n2.CompilationHelper.Restore<__BPlRqeAE4qfOeyQhyAnvoG>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __BPlRqeAE4qfOeyQhyAnvoG(__GetContext__(), n2.VLObject.NewIdentity());
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "U4oIIkCiMrkP89RhFa663q", 322380U);
                    var Output_10 = n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector3>.Create(Node_Context: Node_Context_9);
                    state_8.__p_U4oIIkCiMrkP89RhFa663q = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "HElkICzHHzULutuGXs1hDy", 322394U);
                    var Output_12 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3>.Create(Node_Context: Node_Context_11);
                    state_8.__p_HElkICzHHzULutuGXs1hDy = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "SKZA6H8F86XN6TYB8wQptl", 322397U);
                    var Output_14 = n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector4>.Create(Node_Context: Node_Context_13);
                    state_8.__p_SKZA6H8F86XN6TYB8wQptl = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "MHCtg581giWNm94cTc16pi", 322411U);
                    var Output_16 = n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_15);
                    state_8.__p_MHCtg581giWNm94cTc16pi = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Gqe7HoIcmTwL4mf2wlSc3i", 322420U);
                    var Output_18 = n13.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float>.Create(Node_Context: Node_Context_17);
                    state_8.__p_Gqe7HoIcmTwL4mf2wlSc3i = Output_18;
                    n2.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "BkHkxnYNaOLNSEvcn0oAt3", 322422U);
                    var Output_20 = n13.ONE_K5Kfj2u1J7gOSuWnHDoU3n<float>.Create(Node_Context: Node_Context_19);
                    state_8.__p_BkHkxnYNaOLNSEvcn0oAt3 = Output_20;
                    n47._Operations_.WorleySmooth3DID(Output_Out: out string Output_21);
                    n2.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "MBuE3d75cogQPbH2qqeK9Z", 322424U);
                    var Output_23 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_22, ID_In: Output_21);
                    state_8.__p_MBuE3d75cogQPbH2qqeK9Z = Output_23;
                    n47._Operations_.WorleySmooth3DCellID(Output_Out: out string Output_24);
                    n2.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Lw2KKrKKV3rMrII7MCOvB6", 322441U);
                    var Output_26 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_25, ID_In: Output_24);
                    state_8.__p_Lw2KKrKKV3rMrII7MCOvB6 = Output_26;
                    n47._Operations_.WorleySmooth3DCellPosID(Output_Out: out string Output_27);
                    n2.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "J1fDEGVY22FMUfEUwPTlv9", 322444U);
                    var Output_29 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_28, ID_In: Output_27);
                    state_8.__p_J1fDEGVY22FMUfEUwPTlv9 = Output_29;
                    n2.NodeContext Node_Context_30 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "LsEM4wbbHmnPHc8AXJ2OYs", 322453U);
                    var Output_31 = n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_30);
                    state_8.__p_LsEM4wbbHmnPHc8AXJ2OYs = Output_31;
                    n2.NodeContext Node_Context_32 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "EQ83IZhrsWpNX149yOqBDa", 322457U);
                    var Output_33 = n41.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_32);
                    state_8.__p_EQ83IZhrsWpNX149yOqBDa = Output_33;
                    n2.NodeContext Node_Context_34 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "NmwRR6QpxNhMfdHZ0MvRyc", 322466U);
                    var Output_35 = n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_34);
                    state_8.__p_NmwRR6QpxNhMfdHZ0MvRyc = Output_35;
                }

                int Id_36 = 0;
                var State_Output_38 = state_8.__p_HElkICzHHzULutuGXs1hDy.Update(The_Override_In: TDomain_In, Id_In: Id_36, Output_Out: out n6.GpuValue<n29.Vector3> Output_37);
                n26._Operations_.TypeVector3(Input_In: Output_37, Output_Out: out n6.GpuValue<n29.Vector3> Output_39);
                var State_Output_43 = state_8.__p_U4oIIkCiMrkP89RhFa663q.Update(TDomain_In: Output_39, Frequency_In: Frequency_In, Amplitude_In: Amplitude_In, Center_In: Center_In, Bias_In: Bias_In, Offset_In: Offset_In, Smooth_In: Smooth_In, Jitter_In: Jitter_In, Metric_In: Metric_In, Minkowski_Power_In: Minkowski_Power_In, Output_Out: out n6.GpuValue<float> Output_40, Cell_Position_Out: out n6.GpuValue<n29.Vector3> Cell_Position_41, Cell_ID_Out: out n6.GpuValue<float> Cell_ID_42);
                var State_Output_45 = state_8.__p_NmwRR6QpxNhMfdHZ0MvRyc.Update(xyz_In: Output_39, w_In: Time_In, Output_Out: out n6.GpuValue<n29.Vector4> Output_44);
                var State_Output_47 = state_8.__p_BkHkxnYNaOLNSEvcn0oAt3.Update(Output_Out: out n6.GpuValue<float> Output_46);
                var State_Output_49 = state_8.__p_LsEM4wbbHmnPHc8AXJ2OYs.Update(xyz_In: Frequency_In, w_In: Output_46, Output_Out: out n6.GpuValue<n29.Vector4> Output_48);
                var State_Output_51 = state_8.__p_Gqe7HoIcmTwL4mf2wlSc3i.Update(Output_Out: out n6.GpuValue<float> Output_50);
                var State_Output_53 = state_8.__p_MHCtg581giWNm94cTc16pi.Update(xyz_In: Offset_In, w_In: Output_50, Output_Out: out n6.GpuValue<n29.Vector4> Output_52);
                var State_Output_57 = state_8.__p_SKZA6H8F86XN6TYB8wQptl.Update(TDomain_In: Output_44, Frequency_In: Output_48, Amplitude_In: Amplitude_In, Center_In: Center_In, Bias_In: Bias_In, Offset_In: Output_52, Smooth_In: Smooth_In, Jitter_In: Jitter_In, Metric_In: Metric_In, Minkowski_Power_In: Minkowski_Power_In, Output_Out: out n6.GpuValue<float> Output_54, Cell_Position_Out: out n6.GpuValue<n29.Vector4> Cell_Position_55, Cell_ID_Out: out n6.GpuValue<float> Cell_ID_56);
                bool __pad_SX7wAVouC0yL9UK027Fd1y_58 = Result_1;
                n37._Operations_.Switch_Boolean<n6.GpuValue<float>>(Condition_In: __pad_SX7wAVouC0yL9UK027Fd1y_58, Input_In: Output_40, Input_2_In: Output_54, Output_Out: out n6.GpuValue<float> Output_59);
                n26._Operations_.TypeFloat(Input_In: Output_59, Output_Out: out n6.GpuValue<float> Output_60);
                bool Update_61 = true;
                var Output_62 = state_8.__p_MBuE3d75cogQPbH2qqeK9Z;
                if (Update_61)
                {
                    Output_62 = state_8.__p_MBuE3d75cogQPbH2qqeK9Z.Update(Input_In: Output_60);
                }

                var State_Output_64 = state_8.__p_EQ83IZhrsWpNX149yOqBDa.Update(Input_In: Cell_Position_55, Output_Out: out n6.GpuValue<n29.Vector3> Output_63);
                n37._Operations_.Switch_Boolean<n6.GpuValue<n29.Vector3>>(Condition_In: __pad_SX7wAVouC0yL9UK027Fd1y_58, Input_In: Cell_Position_41, Input_2_In: Output_63, Output_Out: out n6.GpuValue<n29.Vector3> Output_65);
                n26._Operations_.TypeVector3(Input_In: Output_65, Output_Out: out n6.GpuValue<n29.Vector3> Output_66);
                bool Update_67 = true;
                var Output_68 = state_8.__p_J1fDEGVY22FMUfEUwPTlv9;
                if (Update_67)
                {
                    Output_68 = state_8.__p_J1fDEGVY22FMUfEUwPTlv9.Update(Input_In: Output_66);
                }

                n37._Operations_.Switch_Boolean<n6.GpuValue<float>>(Condition_In: __pad_SX7wAVouC0yL9UK027Fd1y_58, Input_In: Cell_ID_42, Input_2_In: Cell_ID_56, Output_Out: out n6.GpuValue<float> Output_69);
                bool Update_70 = true;
                var Output_71 = state_8.__p_Lw2KKrKKV3rMrII7MCOvB6;
                if (Update_70)
                {
                    Output_71 = state_8.__p_Lw2KKrKKV3rMrII7MCOvB6.Update(Input_In: Output_69);
                }

                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_38 != state_8.__p_HElkICzHHzULutuGXs1hDy || State_Output_43 != state_8.__p_U4oIIkCiMrkP89RhFa663q || State_Output_45 != state_8.__p_NmwRR6QpxNhMfdHZ0MvRyc || State_Output_47 != state_8.__p_BkHkxnYNaOLNSEvcn0oAt3 || State_Output_49 != state_8.__p_LsEM4wbbHmnPHc8AXJ2OYs || State_Output_51 != state_8.__p_Gqe7HoIcmTwL4mf2wlSc3i || State_Output_53 != state_8.__p_MHCtg581giWNm94cTc16pi || State_Output_57 != state_8.__p_SKZA6H8F86XN6TYB8wQptl || Result_1 != state_8.__slot_SX7wAVouC0yL9UK027Fd1y || Output_62 != state_8.__p_MBuE3d75cogQPbH2qqeK9Z || State_Output_64 != state_8.__p_EQ83IZhrsWpNX149yOqBDa || Output_68 != state_8.__p_J1fDEGVY22FMUfEUwPTlv9 || Output_71 != state_8.__p_Lw2KKrKKV3rMrII7MCOvB6 ? new __BPlRqeAE4qfOeyQhyAnvoG(state_8)
                    {__p_HElkICzHHzULutuGXs1hDy = State_Output_38, __p_U4oIIkCiMrkP89RhFa663q = State_Output_43, __p_NmwRR6QpxNhMfdHZ0MvRyc = State_Output_45, __p_BkHkxnYNaOLNSEvcn0oAt3 = State_Output_47, __p_LsEM4wbbHmnPHc8AXJ2OYs = State_Output_49, __p_Gqe7HoIcmTwL4mf2wlSc3i = State_Output_51, __p_MHCtg581giWNm94cTc16pi = State_Output_53, __p_SKZA6H8F86XN6TYB8wQptl = State_Output_57, __slot_SX7wAVouC0yL9UK027Fd1y = Result_1, __p_MBuE3d75cogQPbH2qqeK9Z = Output_62, __p_EQ83IZhrsWpNX149yOqBDa = State_Output_64, __p_J1fDEGVY22FMUfEUwPTlv9 = Output_68, __p_Lw2KKrKKV3rMrII7MCOvB6 = Output_71} : state_8;
                else
                {
                    state_8.__p_HElkICzHHzULutuGXs1hDy = State_Output_38;
                    state_8.__p_U4oIIkCiMrkP89RhFa663q = State_Output_43;
                    state_8.__p_NmwRR6QpxNhMfdHZ0MvRyc = State_Output_45;
                    state_8.__p_BkHkxnYNaOLNSEvcn0oAt3 = State_Output_47;
                    state_8.__p_LsEM4wbbHmnPHc8AXJ2OYs = State_Output_49;
                    state_8.__p_Gqe7HoIcmTwL4mf2wlSc3i = State_Output_51;
                    state_8.__p_MHCtg581giWNm94cTc16pi = State_Output_53;
                    state_8.__p_SKZA6H8F86XN6TYB8wQptl = State_Output_57;
                    state_8.__slot_SX7wAVouC0yL9UK027Fd1y = Result_1;
                    state_8.__p_MBuE3d75cogQPbH2qqeK9Z = Output_62;
                    state_8.__p_EQ83IZhrsWpNX149yOqBDa = State_Output_64;
                    state_8.__p_J1fDEGVY22FMUfEUwPTlv9 = Output_68;
                    state_8.__p_Lw2KKrKKV3rMrII7MCOvB6 = Output_71;
                }

                outputs_6 = (Output_60, Output_66, Output_69);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var(__auto_72, __auto_73, __auto_74) = outputs_6;
            Output_Out = __auto_72;
            Cell_Position_Out = __auto_73;
            Cell_ID_Out = __auto_74;
            n4.WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX that_75 = this;
            if (this.__GetContext__().IsImmutable)
                that_75 = manager_4 != this.__cache_NiXcxUjdioIMgyv3GY5cM7 ? new WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX(this)
                {__cache_NiXcxUjdioIMgyv3GY5cM7 = manager_4} : that_75;
            else
            {
                this.__cache_NiXcxUjdioIMgyv3GY5cM7 = manager_4;
            }

            return that_75;
        }

        public n4.WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX that_0 = this;
            this.__cache_NiXcxUjdioIMgyv3GY5cM7 = null;
            return that_0;
        }

        public n4.WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX __CreateDefault__()
        {
            n4.WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX that_0 = this;
            this.__cache_NiXcxUjdioIMgyv3GY5cM7 = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_NiXcxUjdioIMgyv3GY5cM7);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 322482U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RapOzBVT6lWMfNKrxg41LS", Name = "__slot_RapOzBVT6lWMfNKrxg41LS")]
        public static bool __slot_RapOzBVT6lWMfNKrxg41LS = false;
        [n2.ElementAttribute(TracingId = 322358U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NiXcxUjdioIMgyv3GY5cM7", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>>> __cache_NiXcxUjdioIMgyv3GY5cM7 = null;
        static WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX()
        {
        }

        public WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX(WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX other): base(other)
        {
            this.__cache_NiXcxUjdioIMgyv3GY5cM7 = other.__cache_NiXcxUjdioIMgyv3GY5cM7;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_NiXcxUjdioIMgyv3GY5cM7", in __cache_NiXcxUjdioIMgyv3GY5cM7));
        }

        internal WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX __WITH__(n9.Manager<n3.ValueTuple<bool, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>, n23.DistanceMetricsSelector, n6.GpuValue<float>>>, n3.ValueTuple<n6.GpuValue<float>, n6.GpuValue<n29.Vector3>, n6.GpuValue<float>>> __cache_NiXcxUjdioIMgyv3GY5cM7)
        {
            n4.WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_NiXcxUjdioIMgyv3GY5cM7 != this.__cache_NiXcxUjdioIMgyv3GY5cM7 ? new WorleyNoise__3D_Scalar_OKUU3U50Q9QPwdxc68aSHX(this)
                {__cache_NiXcxUjdioIMgyv3GY5cM7 = __cache_NiXcxUjdioIMgyv3GY5cM7} : that_0;
            else
            {
                this.__cache_NiXcxUjdioIMgyv3GY5cM7 = __cache_NiXcxUjdioIMgyv3GY5cM7;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BPlRqeAE4qfOeyQhyAnvoG", Name = "__BPlRqeAE4qfOeyQhyAnvoG")]
        [n3.SerializableAttribute]
        public class __BPlRqeAE4qfOeyQhyAnvoG : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_U4oIIkCiMrkP89RhFa663q);
                n2.CompilationHelper.SafeDispose(this.__p_HElkICzHHzULutuGXs1hDy);
                n2.CompilationHelper.SafeDispose(this.__p_SKZA6H8F86XN6TYB8wQptl);
                n2.CompilationHelper.SafeDispose(this.__p_MHCtg581giWNm94cTc16pi);
                n2.CompilationHelper.SafeDispose(this.__p_Gqe7HoIcmTwL4mf2wlSc3i);
                n2.CompilationHelper.SafeDispose(this.__p_BkHkxnYNaOLNSEvcn0oAt3);
                n2.CompilationHelper.SafeDispose(this.__p_MBuE3d75cogQPbH2qqeK9Z);
                n2.CompilationHelper.SafeDispose(this.__p_Lw2KKrKKV3rMrII7MCOvB6);
                n2.CompilationHelper.SafeDispose(this.__p_J1fDEGVY22FMUfEUwPTlv9);
                n2.CompilationHelper.SafeDispose(this.__p_LsEM4wbbHmnPHc8AXJ2OYs);
                n2.CompilationHelper.SafeDispose(this.__p_EQ83IZhrsWpNX149yOqBDa);
                n2.CompilationHelper.SafeDispose(this.__p_NmwRR6QpxNhMfdHZ0MvRyc);
                return;
            }

            [n2.ElementAttribute(TracingId = 322380U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "U4oIIkCiMrkP89RhFa663q", Name = "WorleyNoise", IsManaged = true, IsAutoGenerated = true)]
            public n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector3> __p_U4oIIkCiMrkP89RhFa663q;
            [n2.ElementAttribute(TracingId = 322394U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HElkICzHHzULutuGXs1hDy", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3> __p_HElkICzHHzULutuGXs1hDy;
            [n2.ElementAttribute(TracingId = 322397U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SKZA6H8F86XN6TYB8wQptl", Name = "WorleyNoise", IsManaged = true, IsAutoGenerated = true)]
            public n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector4> __p_SKZA6H8F86XN6TYB8wQptl;
            [n2.ElementAttribute(TracingId = 322411U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "MHCtg581giWNm94cTc16pi", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_MHCtg581giWNm94cTc16pi;
            [n2.ElementAttribute(TracingId = 322420U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Gqe7HoIcmTwL4mf2wlSc3i", Name = "ZERO", IsManaged = true, IsAutoGenerated = true)]
            public n13.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float> __p_Gqe7HoIcmTwL4mf2wlSc3i;
            [n2.ElementAttribute(TracingId = 322422U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BkHkxnYNaOLNSEvcn0oAt3", Name = "ONE", IsManaged = true, IsAutoGenerated = true)]
            public n13.ONE_K5Kfj2u1J7gOSuWnHDoU3n<float> __p_BkHkxnYNaOLNSEvcn0oAt3;
            [n2.ElementAttribute(TracingId = 322424U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "MBuE3d75cogQPbH2qqeK9Z", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_MBuE3d75cogQPbH2qqeK9Z;
            [n2.ElementAttribute(TracingId = 322441U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Lw2KKrKKV3rMrII7MCOvB6", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Lw2KKrKKV3rMrII7MCOvB6;
            [n2.ElementAttribute(TracingId = 322444U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "J1fDEGVY22FMUfEUwPTlv9", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_J1fDEGVY22FMUfEUwPTlv9;
            [n2.ElementAttribute(TracingId = 322453U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LsEM4wbbHmnPHc8AXJ2OYs", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_LsEM4wbbHmnPHc8AXJ2OYs;
            [n2.ElementAttribute(TracingId = 322457U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "EQ83IZhrsWpNX149yOqBDa", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
            public n41.xyz_T2WwCF9xAltPhlUuLjVDje __p_EQ83IZhrsWpNX149yOqBDa;
            [n2.ElementAttribute(TracingId = 322466U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NmwRR6QpxNhMfdHZ0MvRyc", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_NmwRR6QpxNhMfdHZ0MvRyc;
            [n2.ElementAttribute(TracingId = 322440U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SX7wAVouC0yL9UK027Fd1y", Name = "__slot_SX7wAVouC0yL9UK027Fd1y")]
            public bool __slot_SX7wAVouC0yL9UK027Fd1y;
            public __BPlRqeAE4qfOeyQhyAnvoG(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BPlRqeAE4qfOeyQhyAnvoG(__BPlRqeAE4qfOeyQhyAnvoG other): base(other)
            {
                this.__p_U4oIIkCiMrkP89RhFa663q = other.__p_U4oIIkCiMrkP89RhFa663q;
                this.__p_HElkICzHHzULutuGXs1hDy = other.__p_HElkICzHHzULutuGXs1hDy;
                this.__p_SKZA6H8F86XN6TYB8wQptl = other.__p_SKZA6H8F86XN6TYB8wQptl;
                this.__p_MHCtg581giWNm94cTc16pi = other.__p_MHCtg581giWNm94cTc16pi;
                this.__p_Gqe7HoIcmTwL4mf2wlSc3i = other.__p_Gqe7HoIcmTwL4mf2wlSc3i;
                this.__p_BkHkxnYNaOLNSEvcn0oAt3 = other.__p_BkHkxnYNaOLNSEvcn0oAt3;
                this.__p_MBuE3d75cogQPbH2qqeK9Z = other.__p_MBuE3d75cogQPbH2qqeK9Z;
                this.__p_Lw2KKrKKV3rMrII7MCOvB6 = other.__p_Lw2KKrKKV3rMrII7MCOvB6;
                this.__p_J1fDEGVY22FMUfEUwPTlv9 = other.__p_J1fDEGVY22FMUfEUwPTlv9;
                this.__p_LsEM4wbbHmnPHc8AXJ2OYs = other.__p_LsEM4wbbHmnPHc8AXJ2OYs;
                this.__p_EQ83IZhrsWpNX149yOqBDa = other.__p_EQ83IZhrsWpNX149yOqBDa;
                this.__p_NmwRR6QpxNhMfdHZ0MvRyc = other.__p_NmwRR6QpxNhMfdHZ0MvRyc;
                this.__slot_SX7wAVouC0yL9UK027Fd1y = other.__slot_SX7wAVouC0yL9UK027Fd1y;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_U4oIIkCiMrkP89RhFa663q", in __p_U4oIIkCiMrkP89RhFa663q), n2.CompilationHelper.GetValueOrExisting(values, "__p_HElkICzHHzULutuGXs1hDy", in __p_HElkICzHHzULutuGXs1hDy), n2.CompilationHelper.GetValueOrExisting(values, "__p_SKZA6H8F86XN6TYB8wQptl", in __p_SKZA6H8F86XN6TYB8wQptl), n2.CompilationHelper.GetValueOrExisting(values, "__p_MHCtg581giWNm94cTc16pi", in __p_MHCtg581giWNm94cTc16pi), n2.CompilationHelper.GetValueOrExisting(values, "__p_Gqe7HoIcmTwL4mf2wlSc3i", in __p_Gqe7HoIcmTwL4mf2wlSc3i), n2.CompilationHelper.GetValueOrExisting(values, "__p_BkHkxnYNaOLNSEvcn0oAt3", in __p_BkHkxnYNaOLNSEvcn0oAt3), n2.CompilationHelper.GetValueOrExisting(values, "__p_MBuE3d75cogQPbH2qqeK9Z", in __p_MBuE3d75cogQPbH2qqeK9Z), n2.CompilationHelper.GetValueOrExisting(values, "__p_Lw2KKrKKV3rMrII7MCOvB6", in __p_Lw2KKrKKV3rMrII7MCOvB6), n2.CompilationHelper.GetValueOrExisting(values, "__p_J1fDEGVY22FMUfEUwPTlv9", in __p_J1fDEGVY22FMUfEUwPTlv9), n2.CompilationHelper.GetValueOrExisting(values, "__p_LsEM4wbbHmnPHc8AXJ2OYs", in __p_LsEM4wbbHmnPHc8AXJ2OYs), n2.CompilationHelper.GetValueOrExisting(values, "__p_EQ83IZhrsWpNX149yOqBDa", in __p_EQ83IZhrsWpNX149yOqBDa), n2.CompilationHelper.GetValueOrExisting(values, "__p_NmwRR6QpxNhMfdHZ0MvRyc", in __p_NmwRR6QpxNhMfdHZ0MvRyc), n2.CompilationHelper.GetValueOrExisting(values, "__slot_SX7wAVouC0yL9UK027Fd1y", in __slot_SX7wAVouC0yL9UK027Fd1y));
            }

            internal __BPlRqeAE4qfOeyQhyAnvoG __WITH__(n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector3> __p_U4oIIkCiMrkP89RhFa663q, n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n29.Vector3> __p_HElkICzHHzULutuGXs1hDy, n4.WorleyNoise_VdI1inNX1RhNTbDtnXSqHr<n29.Vector4> __p_SKZA6H8F86XN6TYB8wQptl, n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_MHCtg581giWNm94cTc16pi, n13.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float> __p_Gqe7HoIcmTwL4mf2wlSc3i, n13.ONE_K5Kfj2u1J7gOSuWnHDoU3n<float> __p_BkHkxnYNaOLNSEvcn0oAt3, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_MBuE3d75cogQPbH2qqeK9Z, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Lw2KKrKKV3rMrII7MCOvB6, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_J1fDEGVY22FMUfEUwPTlv9, n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_LsEM4wbbHmnPHc8AXJ2OYs, n41.xyz_T2WwCF9xAltPhlUuLjVDje __p_EQ83IZhrsWpNX149yOqBDa, n35.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_NmwRR6QpxNhMfdHZ0MvRyc, bool __slot_SX7wAVouC0yL9UK027Fd1y)
            {
                __BPlRqeAE4qfOeyQhyAnvoG that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_U4oIIkCiMrkP89RhFa663q != this.__p_U4oIIkCiMrkP89RhFa663q || __p_HElkICzHHzULutuGXs1hDy != this.__p_HElkICzHHzULutuGXs1hDy || __p_SKZA6H8F86XN6TYB8wQptl != this.__p_SKZA6H8F86XN6TYB8wQptl || __p_MHCtg581giWNm94cTc16pi != this.__p_MHCtg581giWNm94cTc16pi || __p_Gqe7HoIcmTwL4mf2wlSc3i != this.__p_Gqe7HoIcmTwL4mf2wlSc3i || __p_BkHkxnYNaOLNSEvcn0oAt3 != this.__p_BkHkxnYNaOLNSEvcn0oAt3 || __p_MBuE3d75cogQPbH2qqeK9Z != this.__p_MBuE3d75cogQPbH2qqeK9Z || __p_Lw2KKrKKV3rMrII7MCOvB6 != this.__p_Lw2KKrKKV3rMrII7MCOvB6 || __p_J1fDEGVY22FMUfEUwPTlv9 != this.__p_J1fDEGVY22FMUfEUwPTlv9 || __p_LsEM4wbbHmnPHc8AXJ2OYs != this.__p_LsEM4wbbHmnPHc8AXJ2OYs || __p_EQ83IZhrsWpNX149yOqBDa != this.__p_EQ83IZhrsWpNX149yOqBDa || __p_NmwRR6QpxNhMfdHZ0MvRyc != this.__p_NmwRR6QpxNhMfdHZ0MvRyc || __slot_SX7wAVouC0yL9UK027Fd1y != this.__slot_SX7wAVouC0yL9UK027Fd1y ? new __BPlRqeAE4qfOeyQhyAnvoG(this)
                    {__p_U4oIIkCiMrkP89RhFa663q = __p_U4oIIkCiMrkP89RhFa663q, __p_HElkICzHHzULutuGXs1hDy = __p_HElkICzHHzULutuGXs1hDy, __p_SKZA6H8F86XN6TYB8wQptl = __p_SKZA6H8F86XN6TYB8wQptl, __p_MHCtg581giWNm94cTc16pi = __p_MHCtg581giWNm94cTc16pi, __p_Gqe7HoIcmTwL4mf2wlSc3i = __p_Gqe7HoIcmTwL4mf2wlSc3i, __p_BkHkxnYNaOLNSEvcn0oAt3 = __p_BkHkxnYNaOLNSEvcn0oAt3, __p_MBuE3d75cogQPbH2qqeK9Z = __p_MBuE3d75cogQPbH2qqeK9Z, __p_Lw2KKrKKV3rMrII7MCOvB6 = __p_Lw2KKrKKV3rMrII7MCOvB6, __p_J1fDEGVY22FMUfEUwPTlv9 = __p_J1fDEGVY22FMUfEUwPTlv9, __p_LsEM4wbbHmnPHc8AXJ2OYs = __p_LsEM4wbbHmnPHc8AXJ2OYs, __p_EQ83IZhrsWpNX149yOqBDa = __p_EQ83IZhrsWpNX149yOqBDa, __p_NmwRR6QpxNhMfdHZ0MvRyc = __p_NmwRR6QpxNhMfdHZ0MvRyc, __slot_SX7wAVouC0yL9UK027Fd1y = __slot_SX7wAVouC0yL9UK027Fd1y} : that_0;
                else
                {
                    this.__p_U4oIIkCiMrkP89RhFa663q = __p_U4oIIkCiMrkP89RhFa663q;
                    this.__p_HElkICzHHzULutuGXs1hDy = __p_HElkICzHHzULutuGXs1hDy;
                    this.__p_SKZA6H8F86XN6TYB8wQptl = __p_SKZA6H8F86XN6TYB8wQptl;
                    this.__p_MHCtg581giWNm94cTc16pi = __p_MHCtg581giWNm94cTc16pi;
                    this.__p_Gqe7HoIcmTwL4mf2wlSc3i = __p_Gqe7HoIcmTwL4mf2wlSc3i;
                    this.__p_BkHkxnYNaOLNSEvcn0oAt3 = __p_BkHkxnYNaOLNSEvcn0oAt3;
                    this.__p_MBuE3d75cogQPbH2qqeK9Z = __p_MBuE3d75cogQPbH2qqeK9Z;
                    this.__p_Lw2KKrKKV3rMrII7MCOvB6 = __p_Lw2KKrKKV3rMrII7MCOvB6;
                    this.__p_J1fDEGVY22FMUfEUwPTlv9 = __p_J1fDEGVY22FMUfEUwPTlv9;
                    this.__p_LsEM4wbbHmnPHc8AXJ2OYs = __p_LsEM4wbbHmnPHc8AXJ2OYs;
                    this.__p_EQ83IZhrsWpNX149yOqBDa = __p_EQ83IZhrsWpNX149yOqBDa;
                    this.__p_NmwRR6QpxNhMfdHZ0MvRyc = __p_NmwRR6QpxNhMfdHZ0MvRyc;
                    this.__slot_SX7wAVouC0yL9UK027Fd1y = __slot_SX7wAVouC0yL9UK027Fd1y;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 322619U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Irt0YFriJdfL2EJnYYiPxv", Name = "Fuse_Common_NoiseApplication_Irt0YFriJdfL2EJnYYiPxv")]
    [n3.SerializableAttribute]
    public class Fuse_Common_NoiseApplication_Irt0YFriJdfL2EJnYYiPxv : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Fuse_Common_NoiseApplication_Irt0YFriJdfL2EJnYYiPxv Create(n2.NodeContext Node_Context)
        {
            var instance = new Fuse_Common_NoiseApplication_Irt0YFriJdfL2EJnYYiPxv(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Fuse_Common_NoiseApplication_Irt0YFriJdfL2EJnYYiPxv CreateDefault()
        {
            var instance = new Fuse_Common_NoiseApplication_Irt0YFriJdfL2EJnYYiPxv(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Fuse_Common_NoiseApplication_Irt0YFriJdfL2EJnYYiPxv Update()
        {
            return this;
        }

        public n4.Fuse_Common_NoiseApplication_Irt0YFriJdfL2EJnYYiPxv __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n4.Fuse_Common_NoiseApplication_Irt0YFriJdfL2EJnYYiPxv __CreateDefault__()
        {
            return this;
        }

        public void Dispose()
        {
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        public Fuse_Common_NoiseApplication_Irt0YFriJdfL2EJnYYiPxv(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Fuse_Common_NoiseApplication_Irt0YFriJdfL2EJnYYiPxv(Fuse_Common_NoiseApplication_Irt0YFriJdfL2EJnYYiPxv other): base(other)
        {
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__();
        }

        internal Fuse_Common_NoiseApplication_Irt0YFriJdfL2EJnYYiPxv __WITH__()
        {
            return this;
        }
    }
}

namespace _Fuse_Common_Noise_.Fuse.Common.Noise.Internal
{
    [n2.ElementAttribute(TracingId = 318987U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "I5QpRRYzVrHNue97OWvauy", Name = "BaseFBM_I5QpRRYzVrHNue97OWvauy")]
    [n3.SerializableAttribute]
    public class BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut> : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut> Create(n2.NodeContext Node_Context)
        {
            var instance = new BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut>(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut> CreateDefault()
        {
            var instance = new BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut>(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut> Update(n6.GpuValue<TIn> Input_In, n6.GpuValue<float> Gain_In, [n5.SerializedDefaultValueAttribute("0.5", false)] float Gain_Default_In, n6.GpuValue<float> Lacunarity_In, [n5.SerializedDefaultValueAttribute("2", false)] float Lacunarity_Default_In, n6.GpuValue<float> Octaves_In, [n5.SerializedDefaultValueAttribute("1", false)] float Octaves_Default_In, string functionName_In, string codeTemplate_In, n6.GpuValue<TOut> Noise_In, out n6.GpuValue<TOut> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_FRRZJFx2dV8PKKCtL983LG;
            if (manager_2 is null)
            {
                manager_2 = new n9.Manager<n3.ValueTuple<n6.GpuValue<TIn>, n6.GpuValue<float>, float, n6.GpuValue<float>, float, n6.GpuValue<float>, float, n3.ValueTuple<string, string, n6.GpuValue<TOut>>>, n3.ValueTuple<n6.GpuValue<TOut>>>(n3.ValueTuple.Create(default(n6.GpuValue<TOut>)));
            }

            var inputs_3 = (Input_In, Gain_In, Gain_Default_In, Lacunarity_In, Lacunarity_Default_In, Octaves_In, Octaves_Default_In, functionName_In, codeTemplate_In, Noise_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n2.CompilationHelper.Restore<__J7j7IXcPJ63OXgvzRSIuHH>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __J7j7IXcPJ63OXgvzRSIuHH(__GetContext__(), n2.VLObject.NewIdentity())
                    {__pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx = n16._Operations_.CreateDefault<n6.AbstractGpuValue>(), __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj = n16._Operations_.CreateDefault<n6.IFunctionInvokeNode>(), __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5 = n21._Operations_.CreateDefault<string, string>(), __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD = n16._Operations_.CreateDefault<n6.AbstractGpuValue>()};
                    n2.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "SHDckLXH4rtPOr3Bg1KnsD", 319044U);
                    var Output_8 = n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<TOut, n17.IEnumerable<n6.InputModifier>>.Create(Node_Context: Node_Context_7);
                    state_6.__p_SHDckLXH4rtPOr3Bg1KnsD = Output_8;
                    n2.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "KaJNVQj4yNtMHrIiaZEZIV", 319105U);
                    var Output_10 = n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_9);
                    state_6.__p_KaJNVQj4yNtMHrIiaZEZIV = Output_10;
                    n2.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "GLuFiAQ0th8PQg8MFlOwuT", 319118U);
                    var Output_12 = n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_11);
                    state_6.__p_GLuFiAQ0th8PQg8MFlOwuT = Output_12;
                    n2.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "RGmAhTXVVuoOMXDyc04NsN", 319127U);
                    var Output_14 = n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_13);
                    state_6.__p_RGmAhTXVVuoOMXDyc04NsN = Output_14;
                    n2.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "UgNWC0vyx2SQPjA4NwfSE9", 319174U);
                    var Output_16 = n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<TIn>.Create(Node_Context: Node_Context_15);
                    state_6.__p_UgNWC0vyx2SQPjA4NwfSE9 = Output_16;
                    n2.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "BGaUZCr0dgGOH3thh2n9qx", 319183U);
                    var Output_18 = n11.Function_IubJYJ2Zy72PGqdBGy0rgZ<TOut>.Create(Node_Context: Node_Context_17);
                    state_6.__p_BGaUZCr0dgGOH3thh2n9qx = Output_18;
                }

                string __pad_SWsd7NfY7z1N25Y3zQXZb3_19 = __slot_SWsd7NfY7z1N25Y3zQXZb3;
                int Id_20 = 0;
                var State_Output_22 = state_6.__p_UgNWC0vyx2SQPjA4NwfSE9.Update(The_Override_In: Input_In, Id_In: Id_20, Output_Out: out n6.GpuValue<TIn> Output_21);
                var State_Output_24 = state_6.__p_KaJNVQj4yNtMHrIiaZEZIV.Update(GpuValue_In: Gain_In, The_Value_In: Gain_Default_In, Output_Out: out n6.GpuValue<float> Output_23);
                var State_Output_26 = state_6.__p_GLuFiAQ0th8PQg8MFlOwuT.Update(GpuValue_In: Octaves_In, The_Value_In: Octaves_Default_In, Output_Out: out n6.GpuValue<float> Output_25);
                var State_Output_28 = state_6.__p_RGmAhTXVVuoOMXDyc04NsN.Update(GpuValue_In: Lacunarity_In, The_Value_In: Lacunarity_Default_In, Output_Out: out n6.GpuValue<float> Output_27);
                var builder_29 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx, 1);
                builder_29.Add(Output_21);
                var __pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx_30 = builder_29.Commit();
                var State_Output_32 = state_6.__p_BGaUZCr0dgGOH3thh2n9qx.Update(Function_In: Noise_In, Parameters_In: __pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx_30, Id_In: __pad_SWsd7NfY7z1N25Y3zQXZb3_19, Output_Out: out n6.FunctionInvokeNode<TOut> Output_31);
                n6.IFunctionInvokeNode Input_33 = (n6.IFunctionInvokeNode)Output_31;
                var builder_34 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj, 1);
                builder_34.Add(Input_33);
                var __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj_35 = builder_34.Commit();
                n16._Operations_.FromValue<n6.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj_35, Result_Out: out n15.Spread<n6.IFunctionInvokeNode> Result_36);
                var Result_37 = n6.TypeHelpers.GetTypeByGeneric<TIn>(theValue: Output_21);
                var Output_38 = Result_37.ToLowerInvariant();
                var builder_39 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5, 1);
                builder_39.Add("argumentType", Output_38);
                var __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5_40 = builder_39.Commit();
                n21._Operations_.Cons<string>(Input_In: __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5_40, Output_Out: out n20.ImmutableDictionary<string, string> Output_41);
                n6.GpuValue<TOut> Default_Result_42 = default(n6.GpuValue<TOut>);
                n17.IEnumerable<string> Mixins_43 = n22._Operations_.CreateDefault<string>();
                bool Is_Groupable_44 = false;
                n17.IEnumerable<n6.InputModifier> The_Modifiers_45 = n22._Operations_.CreateDefault<n6.InputModifier>();
                var builder_46 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD, 4);
                builder_46.Add(Output_21);
                builder_46.Add(Output_23);
                builder_46.Add(Output_25);
                builder_46.Add(Output_27);
                var __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD_47 = builder_46.Commit();
                var State_Output_50 = state_6.__p_SHDckLXH4rtPOr3Bg1KnsD.Update(Arguments_In: __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD_47, Function_Name_In: functionName_In, Code_Template_In: codeTemplate_In, Default_Result_In: Default_Result_42, Functions_In: Result_36, Mixins_In: Mixins_43, Template_Values_In: Output_41, Is_Groupable_In: Is_Groupable_44, The_Modifiers_In: The_Modifiers_45, Output_Out: out n6.GpuValue<TOut> Output_48, AdditionalOutputs_Out: out n15.Spread<n6.AbstractGpuValue> AdditionalOutputs_49);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_22 != state_6.__p_UgNWC0vyx2SQPjA4NwfSE9 || State_Output_24 != state_6.__p_KaJNVQj4yNtMHrIiaZEZIV || State_Output_26 != state_6.__p_GLuFiAQ0th8PQg8MFlOwuT || State_Output_28 != state_6.__p_RGmAhTXVVuoOMXDyc04NsN || __pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx_30 != state_6.__pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx || State_Output_32 != state_6.__p_BGaUZCr0dgGOH3thh2n9qx || __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj_35 != state_6.__pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj || __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5_40 != state_6.__pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5 || __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD_47 != state_6.__pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD || State_Output_50 != state_6.__p_SHDckLXH4rtPOr3Bg1KnsD ? new __J7j7IXcPJ63OXgvzRSIuHH(state_6)
                    {__p_UgNWC0vyx2SQPjA4NwfSE9 = State_Output_22, __p_KaJNVQj4yNtMHrIiaZEZIV = State_Output_24, __p_GLuFiAQ0th8PQg8MFlOwuT = State_Output_26, __p_RGmAhTXVVuoOMXDyc04NsN = State_Output_28, __pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx = __pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx_30, __p_BGaUZCr0dgGOH3thh2n9qx = State_Output_32, __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj = __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj_35, __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5 = __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5_40, __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD = __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD_47, __p_SHDckLXH4rtPOr3Bg1KnsD = State_Output_50} : state_6;
                else
                {
                    state_6.__p_UgNWC0vyx2SQPjA4NwfSE9 = State_Output_22;
                    state_6.__p_KaJNVQj4yNtMHrIiaZEZIV = State_Output_24;
                    state_6.__p_GLuFiAQ0th8PQg8MFlOwuT = State_Output_26;
                    state_6.__p_RGmAhTXVVuoOMXDyc04NsN = State_Output_28;
                    state_6.__pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx = __pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx_30;
                    state_6.__p_BGaUZCr0dgGOH3thh2n9qx = State_Output_32;
                    state_6.__pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj = __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj_35;
                    state_6.__pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5 = __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5_40;
                    state_6.__pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD = __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD_47;
                    state_6.__p_SHDckLXH4rtPOr3Bg1KnsD = State_Output_50;
                }

                outputs_4 = n3.ValueTuple.Create(Output_48);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_51 = outputs_4.Item1;
            Output_Out = __auto_51;
            n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut> that_52 = this;
            if (this.__GetContext__().IsImmutable)
                that_52 = manager_2 != this.__cache_FRRZJFx2dV8PKKCtL983LG ? new BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut>(this)
                {__cache_FRRZJFx2dV8PKKCtL983LG = manager_2} : that_52;
            else
            {
                this.__cache_FRRZJFx2dV8PKKCtL983LG = manager_2;
            }

            return that_52;
        }

        public n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut> __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut> that_0 = this;
            this.__cache_FRRZJFx2dV8PKKCtL983LG = null;
            return that_0;
        }

        public n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut> __CreateDefault__()
        {
            n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut> that_0 = this;
            this.__cache_FRRZJFx2dV8PKKCtL983LG = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_FRRZJFx2dV8PKKCtL983LG);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 318999U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "FRRZJFx2dV8PKKCtL983LG", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<n6.GpuValue<TIn>, n6.GpuValue<float>, float, n6.GpuValue<float>, float, n6.GpuValue<float>, float, n3.ValueTuple<string, string, n6.GpuValue<TOut>>>, n3.ValueTuple<n6.GpuValue<TOut>>> __cache_FRRZJFx2dV8PKKCtL983LG = null;
        [n2.ElementAttribute(TracingId = 319169U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SWsd7NfY7z1N25Y3zQXZb3", Name = "__slot_SWsd7NfY7z1N25Y3zQXZb3")]
        public static string __slot_SWsd7NfY7z1N25Y3zQXZb3 = "noise";
        static BaseFBM_I5QpRRYzVrHNue97OWvauy()
        {
        }

        public BaseFBM_I5QpRRYzVrHNue97OWvauy(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BaseFBM_I5QpRRYzVrHNue97OWvauy(BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut> other): base(other)
        {
            this.__cache_FRRZJFx2dV8PKKCtL983LG = other.__cache_FRRZJFx2dV8PKKCtL983LG;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_FRRZJFx2dV8PKKCtL983LG", in __cache_FRRZJFx2dV8PKKCtL983LG));
        }

        internal BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut> __WITH__(n9.Manager<n3.ValueTuple<n6.GpuValue<TIn>, n6.GpuValue<float>, float, n6.GpuValue<float>, float, n6.GpuValue<float>, float, n3.ValueTuple<string, string, n6.GpuValue<TOut>>>, n3.ValueTuple<n6.GpuValue<TOut>>> __cache_FRRZJFx2dV8PKKCtL983LG)
        {
            n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_FRRZJFx2dV8PKKCtL983LG != this.__cache_FRRZJFx2dV8PKKCtL983LG ? new BaseFBM_I5QpRRYzVrHNue97OWvauy<TIn, TOut>(this)
                {__cache_FRRZJFx2dV8PKKCtL983LG = __cache_FRRZJFx2dV8PKKCtL983LG} : that_0;
            else
            {
                this.__cache_FRRZJFx2dV8PKKCtL983LG = __cache_FRRZJFx2dV8PKKCtL983LG;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "J7j7IXcPJ63OXgvzRSIuHH", Name = "__J7j7IXcPJ63OXgvzRSIuHH")]
        [n3.SerializableAttribute]
        public class __J7j7IXcPJ63OXgvzRSIuHH : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_SHDckLXH4rtPOr3Bg1KnsD);
                n2.CompilationHelper.SafeDispose(this.__p_KaJNVQj4yNtMHrIiaZEZIV);
                n2.CompilationHelper.SafeDispose(this.__p_GLuFiAQ0th8PQg8MFlOwuT);
                n2.CompilationHelper.SafeDispose(this.__p_RGmAhTXVVuoOMXDyc04NsN);
                n2.CompilationHelper.SafeDispose(this.__p_UgNWC0vyx2SQPjA4NwfSE9);
                n2.CompilationHelper.SafeDispose(this.__p_BGaUZCr0dgGOH3thh2n9qx);
                return;
            }

            [n2.ElementAttribute(TracingId = 319044U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SHDckLXH4rtPOr3Bg1KnsD", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<TOut, n17.IEnumerable<n6.InputModifier>> __p_SHDckLXH4rtPOr3Bg1KnsD;
            [n2.ElementAttribute(TracingId = 319105U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "KaJNVQj4yNtMHrIiaZEZIV", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_KaJNVQj4yNtMHrIiaZEZIV;
            [n2.ElementAttribute(TracingId = 319118U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "GLuFiAQ0th8PQg8MFlOwuT", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_GLuFiAQ0th8PQg8MFlOwuT;
            [n2.ElementAttribute(TracingId = 319127U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RGmAhTXVVuoOMXDyc04NsN", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_RGmAhTXVVuoOMXDyc04NsN;
            [n2.ElementAttribute(TracingId = 319174U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "UgNWC0vyx2SQPjA4NwfSE9", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<TIn> __p_UgNWC0vyx2SQPjA4NwfSE9;
            [n2.ElementAttribute(TracingId = 319183U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BGaUZCr0dgGOH3thh2n9qx", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n11.Function_IubJYJ2Zy72PGqdBGy0rgZ<TOut> __p_BGaUZCr0dgGOH3thh2n9qx;
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx = default(n15.Spread<n6.AbstractGpuValue>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.IFunctionInvokeNode> __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj = default(n15.Spread<n6.IFunctionInvokeNode>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n20.ImmutableDictionary<string, string> __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5 = default(n20.ImmutableDictionary<string, string>);
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD = default(n15.Spread<n6.AbstractGpuValue>);
            public __J7j7IXcPJ63OXgvzRSIuHH(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __J7j7IXcPJ63OXgvzRSIuHH(__J7j7IXcPJ63OXgvzRSIuHH other): base(other)
            {
                this.__p_SHDckLXH4rtPOr3Bg1KnsD = other.__p_SHDckLXH4rtPOr3Bg1KnsD;
                this.__p_KaJNVQj4yNtMHrIiaZEZIV = other.__p_KaJNVQj4yNtMHrIiaZEZIV;
                this.__p_GLuFiAQ0th8PQg8MFlOwuT = other.__p_GLuFiAQ0th8PQg8MFlOwuT;
                this.__p_RGmAhTXVVuoOMXDyc04NsN = other.__p_RGmAhTXVVuoOMXDyc04NsN;
                this.__p_UgNWC0vyx2SQPjA4NwfSE9 = other.__p_UgNWC0vyx2SQPjA4NwfSE9;
                this.__p_BGaUZCr0dgGOH3thh2n9qx = other.__p_BGaUZCr0dgGOH3thh2n9qx;
                this.__pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx = other.__pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx;
                this.__pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj = other.__pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj;
                this.__pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5 = other.__pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5;
                this.__pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD = other.__pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_SHDckLXH4rtPOr3Bg1KnsD", in __p_SHDckLXH4rtPOr3Bg1KnsD), n2.CompilationHelper.GetValueOrExisting(values, "__p_KaJNVQj4yNtMHrIiaZEZIV", in __p_KaJNVQj4yNtMHrIiaZEZIV), n2.CompilationHelper.GetValueOrExisting(values, "__p_GLuFiAQ0th8PQg8MFlOwuT", in __p_GLuFiAQ0th8PQg8MFlOwuT), n2.CompilationHelper.GetValueOrExisting(values, "__p_RGmAhTXVVuoOMXDyc04NsN", in __p_RGmAhTXVVuoOMXDyc04NsN), n2.CompilationHelper.GetValueOrExisting(values, "__p_UgNWC0vyx2SQPjA4NwfSE9", in __p_UgNWC0vyx2SQPjA4NwfSE9), n2.CompilationHelper.GetValueOrExisting(values, "__p_BGaUZCr0dgGOH3thh2n9qx", in __p_BGaUZCr0dgGOH3thh2n9qx), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx", in __pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj", in __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5", in __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD", in __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD));
            }

            internal __J7j7IXcPJ63OXgvzRSIuHH __WITH__(n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<TOut, n17.IEnumerable<n6.InputModifier>> __p_SHDckLXH4rtPOr3Bg1KnsD, n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_KaJNVQj4yNtMHrIiaZEZIV, n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_GLuFiAQ0th8PQg8MFlOwuT, n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_RGmAhTXVVuoOMXDyc04NsN, n11.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<TIn> __p_UgNWC0vyx2SQPjA4NwfSE9, n11.Function_IubJYJ2Zy72PGqdBGy0rgZ<TOut> __p_BGaUZCr0dgGOH3thh2n9qx, n15.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx, n15.Spread<n6.IFunctionInvokeNode> __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj, n20.ImmutableDictionary<string, string> __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5, n15.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD)
            {
                __J7j7IXcPJ63OXgvzRSIuHH that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_SHDckLXH4rtPOr3Bg1KnsD != this.__p_SHDckLXH4rtPOr3Bg1KnsD || __p_KaJNVQj4yNtMHrIiaZEZIV != this.__p_KaJNVQj4yNtMHrIiaZEZIV || __p_GLuFiAQ0th8PQg8MFlOwuT != this.__p_GLuFiAQ0th8PQg8MFlOwuT || __p_RGmAhTXVVuoOMXDyc04NsN != this.__p_RGmAhTXVVuoOMXDyc04NsN || __p_UgNWC0vyx2SQPjA4NwfSE9 != this.__p_UgNWC0vyx2SQPjA4NwfSE9 || __p_BGaUZCr0dgGOH3thh2n9qx != this.__p_BGaUZCr0dgGOH3thh2n9qx || __pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx != this.__pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx || __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj != this.__pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj || __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5 != this.__pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5 || __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD != this.__pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD ? new __J7j7IXcPJ63OXgvzRSIuHH(this)
                    {__p_SHDckLXH4rtPOr3Bg1KnsD = __p_SHDckLXH4rtPOr3Bg1KnsD, __p_KaJNVQj4yNtMHrIiaZEZIV = __p_KaJNVQj4yNtMHrIiaZEZIV, __p_GLuFiAQ0th8PQg8MFlOwuT = __p_GLuFiAQ0th8PQg8MFlOwuT, __p_RGmAhTXVVuoOMXDyc04NsN = __p_RGmAhTXVVuoOMXDyc04NsN, __p_UgNWC0vyx2SQPjA4NwfSE9 = __p_UgNWC0vyx2SQPjA4NwfSE9, __p_BGaUZCr0dgGOH3thh2n9qx = __p_BGaUZCr0dgGOH3thh2n9qx, __pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx = __pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx, __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj = __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj, __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5 = __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5, __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD = __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD} : that_0;
                else
                {
                    this.__p_SHDckLXH4rtPOr3Bg1KnsD = __p_SHDckLXH4rtPOr3Bg1KnsD;
                    this.__p_KaJNVQj4yNtMHrIiaZEZIV = __p_KaJNVQj4yNtMHrIiaZEZIV;
                    this.__p_GLuFiAQ0th8PQg8MFlOwuT = __p_GLuFiAQ0th8PQg8MFlOwuT;
                    this.__p_RGmAhTXVVuoOMXDyc04NsN = __p_RGmAhTXVVuoOMXDyc04NsN;
                    this.__p_UgNWC0vyx2SQPjA4NwfSE9 = __p_UgNWC0vyx2SQPjA4NwfSE9;
                    this.__p_BGaUZCr0dgGOH3thh2n9qx = __p_BGaUZCr0dgGOH3thh2n9qx;
                    this.__pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx = __pin_group_Parameters_In_BGaUZCr0dgGOH3thh2n9qx;
                    this.__pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj = __pin_group_Input_In_B9wzQ4MMkP5Nz3PAoR4fuj;
                    this.__pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5 = __pin_group_Input_In_MppRRCwBZeqPJRe91jJ1X5;
                    this.__pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD = __pin_group_Arguments_In_SHDckLXH4rtPOr3Bg1KnsD;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 319337U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "UZub8jUAWz3MKHxFu76LB5", Name = "FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5")]
    [n3.SerializableAttribute]
    public class FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 Create(n2.NodeContext Node_Context)
        {
            var instance = new FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 CreateDefault()
        {
            var instance = new FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 Update(out string Singleton_Out)
        {
            string __pad_OiEfZi81jyBPurz2o1nF5h_0 = __slot_OiEfZi81jyBPurz2o1nF5h;
            Singleton_Out = __pad_OiEfZi81jyBPurz2o1nF5h_0;
            return this;
        }

        public n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n14.FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 __CreateDefault__()
        {
            return this;
        }

        public void Dispose()
        {
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 319350U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "OiEfZi81jyBPurz2o1nF5h", Name = "__slot_OiEfZi81jyBPurz2o1nF5h")]
        public static string __slot_OiEfZi81jyBPurz2o1nF5h = "FuseCommonNoise";
        static FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5()
        {
        }

        public FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5(FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 other): base(other)
        {
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__();
        }

        internal FuseCommonNoise_Mixin_UZub8jUAWz3MKHxFu76LB5 __WITH__()
        {
            return this;
        }
    }

    [n2.ElementAttribute(TracingId = 319391U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RV7KOk6ScLcObloqv9Zuyx", Name = "AddFBM_RV7KOk6ScLcObloqv9Zuyx")]
    [n3.SerializableAttribute]
    public class AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T> : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n14.AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T> Create(n2.NodeContext Node_Context)
        {
            var instance = new AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T>(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n14.AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T> CreateDefault()
        {
            var instance = new AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T>(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T> Update(n6.GpuValue<T2> Input_In, n6.GpuValue<float> Gain_In, [n5.SerializedDefaultValueAttribute("0.5", false)] float Gain_Default_In, n6.GpuValue<float> Lacunarity_In, [n5.SerializedDefaultValueAttribute("2", false)] float Lacunarity_Default_In, n6.GpuValue<float> Octaves_In, [n5.SerializedDefaultValueAttribute("1", false)] float Octaves_Default_In, n6.GpuValue<T> Noise_In, out n6.GpuValue<T> Output_Out)
        {
            string __pad_H8Ns40fxAN1NUtsoxwLi8C_0 = __slot_H8Ns40fxAN1NUtsoxwLi8C;
            string __pad_J0cah0005lNLrCyOZFvoSJ_1 = __slot_J0cah0005lNLrCyOZFvoSJ;
            var State_Output_3 = this.__p_RqPgCsKDhJOOjOoNU0aPIv.Update(Input_In: Input_In, Gain_In: Gain_In, Gain_Default_In: Gain_Default_In, Lacunarity_In: Lacunarity_In, Lacunarity_Default_In: Lacunarity_Default_In, Octaves_In: Octaves_In, Octaves_Default_In: Octaves_Default_In, functionName_In: __pad_J0cah0005lNLrCyOZFvoSJ_1, codeTemplate_In: __pad_H8Ns40fxAN1NUtsoxwLi8C_0, Noise_In: Noise_In, Output_Out: out n6.GpuValue<T> Output_2);
            Output_Out = Output_2;
            n14.AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T> that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = State_Output_3 != this.__p_RqPgCsKDhJOOjOoNU0aPIv ? new AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T>(this)
                {__p_RqPgCsKDhJOOjOoNU0aPIv = State_Output_3} : that_4;
            else
            {
                this.__p_RqPgCsKDhJOOjOoNU0aPIv = State_Output_3;
            }

            return that_4;
        }

        public n14.AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T> __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n2.NodeContext Node_Context_0 = Node_Context.CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "RqPgCsKDhJOOjOoNU0aPIv", 319435U);
            var Output_1 = n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T>.Create(Node_Context: Node_Context_0);
            n14.AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T> that_2 = this;
            this.__p_RqPgCsKDhJOOjOoNU0aPIv = Output_1;
            return that_2;
        }

        public n14.AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T> __CreateDefault__()
        {
            n14.AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T> that_0 = this;
            this.__p_RqPgCsKDhJOOjOoNU0aPIv = n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__p_RqPgCsKDhJOOjOoNU0aPIv);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 319417U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "H8Ns40fxAN1NUtsoxwLi8C", Name = "__slot_H8Ns40fxAN1NUtsoxwLi8C")]
        public static string __slot_H8Ns40fxAN1NUtsoxwLi8C = "// FBM\r\n${resultType} ${signature}(${argumentType} p,float gain, float octaves, float lacunarity)\r\n{\r\n\r\n    float myScale = 1;\r\n    float myFallOff = gain;\r\n    int iOctaves = int(floor(octaves)); \r\n    ${resultType} myResult = 0.;  \r\n    float myAmp = 0.;\r\n    for(int i = 0; i < iOctaves;i++)\r\n    {\r\n        myResult += ${noise}(p * myScale) * myFallOff;\r\n        myAmp += myFallOff;\r\n        myFallOff *= gain;\r\n        myScale *= lacunarity;\r\n    }\r\n    float myBlend = octaves - float(iOctaves);\r\n    myResult += ${noise}(p * myScale) * myFallOff * myBlend;    \r\n    myAmp += myFallOff * myBlend;\r\n    if(myAmp > 0.0) myResult /= myAmp;\r\n    return myResult;\r\n}";
        [n2.ElementAttribute(TracingId = 319447U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "J0cah0005lNLrCyOZFvoSJ", Name = "__slot_J0cah0005lNLrCyOZFvoSJ")]
        public static string __slot_J0cah0005lNLrCyOZFvoSJ = "fbm";
        [n2.ElementAttribute(TracingId = 319435U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RqPgCsKDhJOOjOoNU0aPIv", Name = "BaseFBM", IsManaged = true, IsAutoGenerated = true)]
        public n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T> __p_RqPgCsKDhJOOjOoNU0aPIv;
        static AddFBM_RV7KOk6ScLcObloqv9Zuyx()
        {
        }

        public AddFBM_RV7KOk6ScLcObloqv9Zuyx(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AddFBM_RV7KOk6ScLcObloqv9Zuyx(AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T> other): base(other)
        {
            this.__p_RqPgCsKDhJOOjOoNU0aPIv = other.__p_RqPgCsKDhJOOjOoNU0aPIv;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_RqPgCsKDhJOOjOoNU0aPIv", in __p_RqPgCsKDhJOOjOoNU0aPIv));
        }

        internal AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T> __WITH__(n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T> __p_RqPgCsKDhJOOjOoNU0aPIv)
        {
            n14.AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_RqPgCsKDhJOOjOoNU0aPIv != this.__p_RqPgCsKDhJOOjOoNU0aPIv ? new AddFBM_RV7KOk6ScLcObloqv9Zuyx<T2, T>(this)
                {__p_RqPgCsKDhJOOjOoNU0aPIv = __p_RqPgCsKDhJOOjOoNU0aPIv} : that_0;
            else
            {
                this.__p_RqPgCsKDhJOOjOoNU0aPIv = __p_RqPgCsKDhJOOjOoNU0aPIv;
            }

            return that_0;
        }
    }

    [n2.ElementAttribute(TracingId = 319503U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "HcsTLn1bWt3Lz2GZfBTUyd", Name = "MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd")]
    [n3.SerializableAttribute]
    public class MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T> : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n14.MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T> Create(n2.NodeContext Node_Context)
        {
            var instance = new MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T>(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n14.MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T> CreateDefault()
        {
            var instance = new MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T>(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T> Update(n6.GpuValue<T2> Input_In, n6.GpuValue<float> Gain_In, [n5.SerializedDefaultValueAttribute("0.35", false)] float Gain_Default_In, n6.GpuValue<float> Lacunarity_In, [n5.SerializedDefaultValueAttribute("2", false)] float Lacunarity_Default_In, n6.GpuValue<float> Octaves_In, [n5.SerializedDefaultValueAttribute("5", false)] float Octaves_Default_In, n6.GpuValue<T> Noise_In, out n6.GpuValue<T> Output_Out)
        {
            string __pad_DIoRzYJKCDHMehxaPtlCuE_0 = __slot_DIoRzYJKCDHMehxaPtlCuE;
            string __pad_Mz0SoGAMXAKQdBcrVKdqWY_1 = __slot_Mz0SoGAMXAKQdBcrVKdqWY;
            var State_Output_3 = this.__p_DkpTkwbKixELD2kdOzFKYp.Update(Input_In: Input_In, Gain_In: Gain_In, Gain_Default_In: Gain_Default_In, Lacunarity_In: Lacunarity_In, Lacunarity_Default_In: Lacunarity_Default_In, Octaves_In: Octaves_In, Octaves_Default_In: Octaves_Default_In, functionName_In: __pad_Mz0SoGAMXAKQdBcrVKdqWY_1, codeTemplate_In: __pad_DIoRzYJKCDHMehxaPtlCuE_0, Noise_In: Noise_In, Output_Out: out n6.GpuValue<T> Output_2);
            Output_Out = Output_2;
            n14.MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T> that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = State_Output_3 != this.__p_DkpTkwbKixELD2kdOzFKYp ? new MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T>(this)
                {__p_DkpTkwbKixELD2kdOzFKYp = State_Output_3} : that_4;
            else
            {
                this.__p_DkpTkwbKixELD2kdOzFKYp = State_Output_3;
            }

            return that_4;
        }

        public n14.MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T> __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n2.NodeContext Node_Context_0 = Node_Context.CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "DkpTkwbKixELD2kdOzFKYp", 319541U);
            var Output_1 = n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T>.Create(Node_Context: Node_Context_0);
            n14.MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T> that_2 = this;
            this.__p_DkpTkwbKixELD2kdOzFKYp = Output_1;
            return that_2;
        }

        public n14.MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T> __CreateDefault__()
        {
            n14.MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T> that_0 = this;
            this.__p_DkpTkwbKixELD2kdOzFKYp = n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__p_DkpTkwbKixELD2kdOzFKYp);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 319528U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "DIoRzYJKCDHMehxaPtlCuE", Name = "__slot_DIoRzYJKCDHMehxaPtlCuE")]
        public static string __slot_DIoRzYJKCDHMehxaPtlCuE = "// Multifractal FBM\r\n${resultType} ${signature}(${argumentType} p,float gain, float lacunarity, float octaves)\r\n{\r\n    int iOctaves = int(floor(octaves)); \r\n    ${resultType} result = 1.;  \r\n    float ampScale = 1.;\r\n\t\r\n    for(int i = 0; i < iOctaves; i++)\r\n    {\r\n        result *=  ampScale * ${noise}(p) + 1.0; \r\n        ampScale *= gain;\r\n        p *= lacunarity;\r\n    }\r\n\t\r\n\tfloat remainder = octaves - float(iOctaves);\t\r\n\tif (remainder > 0. && octaves > 1.0) \r\n\t{\r\n\t\t${resultType} fracResult = result * (ampScale * ${noise}(p) + 1);\r\n\t\tresult = lerp(result, fracResult, remainder);\r\n\t}\r\n\treturn result - 1.0;\r\n}";
        [n2.ElementAttribute(TracingId = 319559U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Mz0SoGAMXAKQdBcrVKdqWY", Name = "__slot_Mz0SoGAMXAKQdBcrVKdqWY")]
        public static string __slot_Mz0SoGAMXAKQdBcrVKdqWY = "MultifractalFBM";
        [n2.ElementAttribute(TracingId = 319541U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "DkpTkwbKixELD2kdOzFKYp", Name = "BaseFBM", IsManaged = true, IsAutoGenerated = true)]
        public n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T> __p_DkpTkwbKixELD2kdOzFKYp;
        static MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd()
        {
        }

        public MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd(MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T> other): base(other)
        {
            this.__p_DkpTkwbKixELD2kdOzFKYp = other.__p_DkpTkwbKixELD2kdOzFKYp;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_DkpTkwbKixELD2kdOzFKYp", in __p_DkpTkwbKixELD2kdOzFKYp));
        }

        internal MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T> __WITH__(n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T> __p_DkpTkwbKixELD2kdOzFKYp)
        {
            n14.MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_DkpTkwbKixELD2kdOzFKYp != this.__p_DkpTkwbKixELD2kdOzFKYp ? new MultiFBM_HcsTLn1bWt3Lz2GZfBTUyd<T2, T>(this)
                {__p_DkpTkwbKixELD2kdOzFKYp = __p_DkpTkwbKixELD2kdOzFKYp} : that_0;
            else
            {
                this.__p_DkpTkwbKixELD2kdOzFKYp = __p_DkpTkwbKixELD2kdOzFKYp;
            }

            return that_0;
        }
    }

    [n2.ElementAttribute(TracingId = 319632U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "OhttpvmP9CKOmrUgtGO8f6", Name = "HeteroFBM_OhttpvmP9CKOmrUgtGO8f6")]
    [n3.SerializableAttribute]
    public class HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T> : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n14.HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T> Create(n2.NodeContext Node_Context)
        {
            var instance = new HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T>(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n14.HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T> CreateDefault()
        {
            var instance = new HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T>(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T> Update(n6.GpuValue<T2> Input_In, n6.GpuValue<float> Gain_In, [n5.SerializedDefaultValueAttribute("0.5", false)] float Gain_Default_In, n6.GpuValue<float> Lacunarity_In, [n5.SerializedDefaultValueAttribute("2", false)] float Lacunarity_Default_In, n6.GpuValue<float> Octaves_In, [n5.SerializedDefaultValueAttribute("5", false)] float Octaves_Default_In, n6.GpuValue<T> Noise_In, out n6.GpuValue<T> Output_Out)
        {
            string __pad_UBpQDMxC0JFQN1sTP5zTcV_0 = __slot_UBpQDMxC0JFQN1sTP5zTcV;
            string __pad_JnLVDYhQrskLv0HmasExga_1 = __slot_JnLVDYhQrskLv0HmasExga;
            var State_Output_3 = this.__p_LwfgQO0iRbKLWwsae3gTX1.Update(Input_In: Input_In, Gain_In: Gain_In, Gain_Default_In: Gain_Default_In, Lacunarity_In: Lacunarity_In, Lacunarity_Default_In: Lacunarity_Default_In, Octaves_In: Octaves_In, Octaves_Default_In: Octaves_Default_In, functionName_In: __pad_JnLVDYhQrskLv0HmasExga_1, codeTemplate_In: __pad_UBpQDMxC0JFQN1sTP5zTcV_0, Noise_In: Noise_In, Output_Out: out n6.GpuValue<T> Output_2);
            Output_Out = Output_2;
            n14.HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T> that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = State_Output_3 != this.__p_LwfgQO0iRbKLWwsae3gTX1 ? new HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T>(this)
                {__p_LwfgQO0iRbKLWwsae3gTX1 = State_Output_3} : that_4;
            else
            {
                this.__p_LwfgQO0iRbKLWwsae3gTX1 = State_Output_3;
            }

            return that_4;
        }

        public n14.HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T> __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n2.NodeContext Node_Context_0 = Node_Context.CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "LwfgQO0iRbKLWwsae3gTX1", 319655U);
            var Output_1 = n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T>.Create(Node_Context: Node_Context_0);
            n14.HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T> that_2 = this;
            this.__p_LwfgQO0iRbKLWwsae3gTX1 = Output_1;
            return that_2;
        }

        public n14.HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T> __CreateDefault__()
        {
            n14.HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T> that_0 = this;
            this.__p_LwfgQO0iRbKLWwsae3gTX1 = n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__p_LwfgQO0iRbKLWwsae3gTX1);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 319646U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "UBpQDMxC0JFQN1sTP5zTcV", Name = "__slot_UBpQDMxC0JFQN1sTP5zTcV")]
        public static string __slot_UBpQDMxC0JFQN1sTP5zTcV = "// Heterogeneous FBM\r\n${resultType} ${signature}(${argumentType} p,float gain, float lacunarity, float octaves)\r\n{\r\n\tint iOctaves = int(floor(octaves)); \r\n\t${resultType} value;\t\r\n\t${resultType} increment;\r\n\tfloat ampScale = gain;\r\n\t\r\n\tvalue = ${noise}(p);      \r\n\tp *= lacunarity;\r\n\t\r\n    for(int i = 1; i < iOctaves; i++)\r\n\t{\r\n\t\tincrement = ${noise}(p) * ampScale * value;\r\n\t\tvalue += increment;\r\n\t\tampScale *= gain;\r\n        p *= lacunarity;\r\n\t}\r\n\tfloat remainder = octaves - float(iOctaves);\r\n\tif (remainder > 0. && octaves > 1.0) \r\n\t{\r\n\t\tincrement = ${noise}(p)  * ampScale * value;\r\n\t\tvalue += (remainder * increment);\r\n\t}\r\n\treturn value;\r\n}";
        [n2.ElementAttribute(TracingId = 319679U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "JnLVDYhQrskLv0HmasExga", Name = "__slot_JnLVDYhQrskLv0HmasExga")]
        public static string __slot_JnLVDYhQrskLv0HmasExga = "HeterogeneousFBM";
        [n2.ElementAttribute(TracingId = 319655U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LwfgQO0iRbKLWwsae3gTX1", Name = "BaseFBM", IsManaged = true, IsAutoGenerated = true)]
        public n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T> __p_LwfgQO0iRbKLWwsae3gTX1;
        static HeteroFBM_OhttpvmP9CKOmrUgtGO8f6()
        {
        }

        public HeteroFBM_OhttpvmP9CKOmrUgtGO8f6(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HeteroFBM_OhttpvmP9CKOmrUgtGO8f6(HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T> other): base(other)
        {
            this.__p_LwfgQO0iRbKLWwsae3gTX1 = other.__p_LwfgQO0iRbKLWwsae3gTX1;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_LwfgQO0iRbKLWwsae3gTX1", in __p_LwfgQO0iRbKLWwsae3gTX1));
        }

        internal HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T> __WITH__(n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T> __p_LwfgQO0iRbKLWwsae3gTX1)
        {
            n14.HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_LwfgQO0iRbKLWwsae3gTX1 != this.__p_LwfgQO0iRbKLWwsae3gTX1 ? new HeteroFBM_OhttpvmP9CKOmrUgtGO8f6<T2, T>(this)
                {__p_LwfgQO0iRbKLWwsae3gTX1 = __p_LwfgQO0iRbKLWwsae3gTX1} : that_0;
            else
            {
                this.__p_LwfgQO0iRbKLWwsae3gTX1 = __p_LwfgQO0iRbKLWwsae3gTX1;
            }

            return that_0;
        }
    }

    [n2.ElementAttribute(TracingId = 319742U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Q2aZy9EZqoQNQtJRzoXIYH", Name = "HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH")]
    [n3.SerializableAttribute]
    public class HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T> : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n14.HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T> Create(n2.NodeContext Node_Context)
        {
            var instance = new HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T>(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n14.HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T> CreateDefault()
        {
            var instance = new HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T>(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T> Update(n6.GpuValue<T2> Input_In, n6.GpuValue<float> Gain_In, [n5.SerializedDefaultValueAttribute("0.95", false)] float Gain_Default_In, n6.GpuValue<float> Lacunarity_In, [n5.SerializedDefaultValueAttribute("2", false)] float Lacunarity_Default_In, n6.GpuValue<float> Octaves_In, [n5.SerializedDefaultValueAttribute("5", false)] float Octaves_Default_In, n6.GpuValue<T> Noise_In, out n6.GpuValue<T> Output_Out)
        {
            string __pad_BI7hr1k6rSuOco9teByyx3_0 = __slot_BI7hr1k6rSuOco9teByyx3;
            string __pad_KFAsQbkkMNtNZiKVWt3ai8_1 = __slot_KFAsQbkkMNtNZiKVWt3ai8;
            var State_Output_3 = this.__p_S77rNu1EhXAQE8xomXXihl.Update(Input_In: Input_In, Gain_In: Gain_In, Gain_Default_In: Gain_Default_In, Lacunarity_In: Lacunarity_In, Lacunarity_Default_In: Lacunarity_Default_In, Octaves_In: Octaves_In, Octaves_Default_In: Octaves_Default_In, functionName_In: __pad_KFAsQbkkMNtNZiKVWt3ai8_1, codeTemplate_In: __pad_BI7hr1k6rSuOco9teByyx3_0, Noise_In: Noise_In, Output_Out: out n6.GpuValue<T> Output_2);
            Output_Out = Output_2;
            n14.HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T> that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = State_Output_3 != this.__p_S77rNu1EhXAQE8xomXXihl ? new HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T>(this)
                {__p_S77rNu1EhXAQE8xomXXihl = State_Output_3} : that_4;
            else
            {
                this.__p_S77rNu1EhXAQE8xomXXihl = State_Output_3;
            }

            return that_4;
        }

        public n14.HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T> __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n2.NodeContext Node_Context_0 = Node_Context.CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "S77rNu1EhXAQE8xomXXihl", 319764U);
            var Output_1 = n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T>.Create(Node_Context: Node_Context_0);
            n14.HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T> that_2 = this;
            this.__p_S77rNu1EhXAQE8xomXXihl = Output_1;
            return that_2;
        }

        public n14.HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T> __CreateDefault__()
        {
            n14.HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T> that_0 = this;
            this.__p_S77rNu1EhXAQE8xomXXihl = n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__p_S77rNu1EhXAQE8xomXXihl);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 319756U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "BI7hr1k6rSuOco9teByyx3", Name = "__slot_BI7hr1k6rSuOco9teByyx3")]
        public static string __slot_BI7hr1k6rSuOco9teByyx3 = "// Hybrid FBM\r\n${resultType} ${signature}(${argumentType} p,float gain, float lacunarity, float octaves)\r\n{\r\n\tint iOctaves = int(floor(octaves)); \r\n\t${resultType} signal = 0.0;\r\n\t${resultType} result = ${noise}(p);  \r\n\t${resultType} weight = result;\r\n\tfloat ampScale = gain; \r\n\tp *= lacunarity;\r\n\tampScale *= gain;\r\n\r\n\tfor (int i=1; i<iOctaves && weight > 0.001; i++)\r\n\t{\r\n\t\tweight = min(weight, 1.0);\r\n\t\tsignal = ampScale * ${noise}(p);\r\n\t\tresult += weight * signal;\r\n\t\tweight *= gain * signal;\r\n\t\tampScale *= gain;\r\n\t\tp *= lacunarity;\r\n\t}\r\n\t\r\n    float remainder = octaves - float(iOctaves);\r\n\tif (remainder > 0. && octaves > 1.0)\r\n\t{\r\n\t\tweight = min(weight, 1.0);\r\n\t\tsignal = ampScale * ${noise}(p);\r\n\t\t${resultType} fracResult = result + weight * signal;\r\n\t\tresult = lerp(result, fracResult, remainder);\r\n\t}\r\n\treturn result;\r\n}";
        [n2.ElementAttribute(TracingId = 319787U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "KFAsQbkkMNtNZiKVWt3ai8", Name = "__slot_KFAsQbkkMNtNZiKVWt3ai8")]
        public static string __slot_KFAsQbkkMNtNZiKVWt3ai8 = "HybridFBM";
        [n2.ElementAttribute(TracingId = 319764U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "S77rNu1EhXAQE8xomXXihl", Name = "BaseFBM", IsManaged = true, IsAutoGenerated = true)]
        public n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T> __p_S77rNu1EhXAQE8xomXXihl;
        static HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH()
        {
        }

        public HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH(HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T> other): base(other)
        {
            this.__p_S77rNu1EhXAQE8xomXXihl = other.__p_S77rNu1EhXAQE8xomXXihl;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_S77rNu1EhXAQE8xomXXihl", in __p_S77rNu1EhXAQE8xomXXihl));
        }

        internal HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T> __WITH__(n14.BaseFBM_I5QpRRYzVrHNue97OWvauy<T2, T> __p_S77rNu1EhXAQE8xomXXihl)
        {
            n14.HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_S77rNu1EhXAQE8xomXXihl != this.__p_S77rNu1EhXAQE8xomXXihl ? new HybridFBM_Q2aZy9EZqoQNQtJRzoXIYH<T2, T>(this)
                {__p_S77rNu1EhXAQE8xomXXihl = __p_S77rNu1EhXAQE8xomXXihl} : that_0;
            else
            {
                this.__p_S77rNu1EhXAQE8xomXXihl = __p_S77rNu1EhXAQE8xomXXihl;
            }

            return that_0;
        }
    }

    [n2.ElementAttribute(TracingId = 319858U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "UhZnfwmPymmL5WkIk0tnx8", Name = "FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8")]
    [n3.SerializableAttribute]
    public class FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 : n2.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 Create(n2.NodeContext Node_Context)
        {
            var instance = new FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 CreateDefault()
        {
            var instance = new FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 Update(out string Singleton_Out)
        {
            string __pad_DaKSqIwMByPMGTPCRe5W4c_0 = __slot_DaKSqIwMByPMGTPCRe5W4c;
            Singleton_Out = __pad_DaKSqIwMByPMGTPCRe5W4c_0;
            return this;
        }

        public n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n14.FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 __CreateDefault__()
        {
            return this;
        }

        public void Dispose()
        {
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 319863U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "DaKSqIwMByPMGTPCRe5W4c", Name = "__slot_DaKSqIwMByPMGTPCRe5W4c")]
        public static string __slot_DaKSqIwMByPMGTPCRe5W4c = "FuseCommonNoiseWorley";
        static FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8()
        {
        }

        public FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8(FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 other): base(other)
        {
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__();
        }

        internal FuseCommonNoiseWorley_Mixin_UhZnfwmPymmL5WkIk0tnx8 __WITH__()
        {
            return this;
        }
    }

    [n2.ElementAttribute(TracingId = 319937U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RvLt71NM0ixOjnh8J1JqId", Name = "Inflection_RvLt71NM0ixOjnh8J1JqId")]
    [n3.SerializableAttribute]
    public class Inflection_RvLt71NM0ixOjnh8J1JqId<T> : n2.VLObject, n3.IDisposable where T : struct
    {
        [n5.CreateNewAttribute]
        public static n14.Inflection_RvLt71NM0ixOjnh8J1JqId<T> Create(n2.NodeContext Node_Context)
        {
            var instance = new Inflection_RvLt71NM0ixOjnh8J1JqId<T>(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n14.Inflection_RvLt71NM0ixOjnh8J1JqId<T> CreateDefault()
        {
            var instance = new Inflection_RvLt71NM0ixOjnh8J1JqId<T>(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.Inflection_RvLt71NM0ixOjnh8J1JqId<T> Update<AdM>(n6.GpuValue<T> Input_In, n7.NoiseBasisInflection Inflection_In, out n6.GpuValue<T> Output_Out)
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.GpuValue<T>>
        {
            var w_0 = default(AdM);
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_OYMcmR5Ufe5MWdO1abzDEr;
            if (manager_3 is null)
            {
                manager_3 = new n9.Manager<n3.ValueTuple<n6.GpuValue<T>, n7.NoiseBasisInflection>, n3.ValueTuple<n6.GpuValue<T>>>(n3.ValueTuple.Create(default(n6.GpuValue<T>)));
            }

            var inputs_4 = (Input_In, Inflection_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n2.CompilationHelper.Restore<__RQuvteaqhzTOzLgbqtev9S>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __RQuvteaqhzTOzLgbqtev9S(__GetContext__(), n2.VLObject.NewIdentity())
                    {__slot_La6NOqXVLroL8e8mKltQXI = default(n7.NoiseBasisInflection), __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw = n16._Operations_.CreateDefault<n6.GpuValue<T>>()};
                    n2.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "SXbHy8OlO9QMVdApopPXGz", 319967U);
                    var Output_9 = n13.Abs_HYWPOtC1lkrNB5uGryHr5l<T>.Create(Node_Context: Node_Context_8);
                    state_7.__p_SXbHy8OlO9QMVdApopPXGz = Output_9;
                    n2.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "Q1qw4pLnELyQawQoMXCSyx", 319988U);
                    var Output_11 = n13.OneMinus_TZSID1klGMVLkhX7sgErcR<T>.Create(Node_Context: Node_Context_10);
                    state_7.__p_Q1qw4pLnELyQawQoMXCSyx = Output_11;
                }

                var Output_13 = state_7.__p_SXbHy8OlO9QMVdApopPXGz.Update(Input_In: Input_In, Out_Out: out n6.GpuValue<T> Out_12);
                n7.NoiseBasisInflection __pad_La6NOqXVLroL8e8mKltQXI_14 = Inflection_In;
                int Index_15 = (int)__pad_La6NOqXVLroL8e8mKltQXI_14;
                var State_Output_17 = state_7.__p_Q1qw4pLnELyQawQoMXCSyx.Update(Input_In: Out_12, Output_Out: out n6.GpuValue<T> Output_16);
                var builder_18 = n5.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw, 3);
                builder_18.Add(Input_In);
                builder_18.Add(Output_16);
                builder_18.Add(Out_12);
                var __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw_19 = builder_18.Commit();
                n28._Operations_.Switch<n6.GpuValue<T>, AdM>(Index_In: Index_15, Input_In: __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw_19, Output_Out: out n6.GpuValue<T> Output_20);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_13 != state_7.__p_SXbHy8OlO9QMVdApopPXGz || !n17.EqualityComparer<n7.NoiseBasisInflection>.Default.Equals(Inflection_In, state_7.__slot_La6NOqXVLroL8e8mKltQXI) || State_Output_17 != state_7.__p_Q1qw4pLnELyQawQoMXCSyx || __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw_19 != state_7.__pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw ? new __RQuvteaqhzTOzLgbqtev9S(state_7)
                    {__p_SXbHy8OlO9QMVdApopPXGz = Output_13, __slot_La6NOqXVLroL8e8mKltQXI = Inflection_In, __p_Q1qw4pLnELyQawQoMXCSyx = State_Output_17, __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw = __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw_19} : state_7;
                else
                {
                    state_7.__p_SXbHy8OlO9QMVdApopPXGz = Output_13;
                    state_7.__slot_La6NOqXVLroL8e8mKltQXI = Inflection_In;
                    state_7.__p_Q1qw4pLnELyQawQoMXCSyx = State_Output_17;
                    state_7.__pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw = __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw_19;
                }

                outputs_5 = n3.ValueTuple.Create(Output_20);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_21 = outputs_5.Item1;
            Output_Out = __auto_21;
            n14.Inflection_RvLt71NM0ixOjnh8J1JqId<T> that_22 = this;
            if (this.__GetContext__().IsImmutable)
                that_22 = manager_3 != this.__cache_OYMcmR5Ufe5MWdO1abzDEr ? new Inflection_RvLt71NM0ixOjnh8J1JqId<T>(this)
                {__cache_OYMcmR5Ufe5MWdO1abzDEr = manager_3} : that_22;
            else
            {
                this.__cache_OYMcmR5Ufe5MWdO1abzDEr = manager_3;
            }

            return that_22;
        }

        public n14.Inflection_RvLt71NM0ixOjnh8J1JqId<T> __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n14.Inflection_RvLt71NM0ixOjnh8J1JqId<T> that_0 = this;
            this.__cache_OYMcmR5Ufe5MWdO1abzDEr = null;
            return that_0;
        }

        public n14.Inflection_RvLt71NM0ixOjnh8J1JqId<T> __CreateDefault__()
        {
            n14.Inflection_RvLt71NM0ixOjnh8J1JqId<T> that_0 = this;
            this.__cache_OYMcmR5Ufe5MWdO1abzDEr = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_OYMcmR5Ufe5MWdO1abzDEr);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 319940U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "OYMcmR5Ufe5MWdO1abzDEr", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<n6.GpuValue<T>, n7.NoiseBasisInflection>, n3.ValueTuple<n6.GpuValue<T>>> __cache_OYMcmR5Ufe5MWdO1abzDEr = null;
        public Inflection_RvLt71NM0ixOjnh8J1JqId(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Inflection_RvLt71NM0ixOjnh8J1JqId(Inflection_RvLt71NM0ixOjnh8J1JqId<T> other): base(other)
        {
            this.__cache_OYMcmR5Ufe5MWdO1abzDEr = other.__cache_OYMcmR5Ufe5MWdO1abzDEr;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_OYMcmR5Ufe5MWdO1abzDEr", in __cache_OYMcmR5Ufe5MWdO1abzDEr));
        }

        internal Inflection_RvLt71NM0ixOjnh8J1JqId<T> __WITH__(n9.Manager<n3.ValueTuple<n6.GpuValue<T>, n7.NoiseBasisInflection>, n3.ValueTuple<n6.GpuValue<T>>> __cache_OYMcmR5Ufe5MWdO1abzDEr)
        {
            n14.Inflection_RvLt71NM0ixOjnh8J1JqId<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_OYMcmR5Ufe5MWdO1abzDEr != this.__cache_OYMcmR5Ufe5MWdO1abzDEr ? new Inflection_RvLt71NM0ixOjnh8J1JqId<T>(this)
                {__cache_OYMcmR5Ufe5MWdO1abzDEr = __cache_OYMcmR5Ufe5MWdO1abzDEr} : that_0;
            else
            {
                this.__cache_OYMcmR5Ufe5MWdO1abzDEr = __cache_OYMcmR5Ufe5MWdO1abzDEr;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "RQuvteaqhzTOzLgbqtev9S", Name = "__RQuvteaqhzTOzLgbqtev9S")]
        [n3.SerializableAttribute]
        public class __RQuvteaqhzTOzLgbqtev9S : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_SXbHy8OlO9QMVdApopPXGz);
                n2.CompilationHelper.SafeDispose(this.__p_Q1qw4pLnELyQawQoMXCSyx);
                return;
            }

            [n2.ElementAttribute(TracingId = 319967U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SXbHy8OlO9QMVdApopPXGz", Name = "Abs", IsManaged = true, IsAutoGenerated = true)]
            public n13.Abs_HYWPOtC1lkrNB5uGryHr5l<T> __p_SXbHy8OlO9QMVdApopPXGz;
            [n2.ElementAttribute(TracingId = 319988U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Q1qw4pLnELyQawQoMXCSyx", Name = "OneMinus", IsManaged = true, IsAutoGenerated = true)]
            public n13.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_Q1qw4pLnELyQawQoMXCSyx;
            [n2.ElementAttribute(TracingId = 319985U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "La6NOqXVLroL8e8mKltQXI", Name = "__slot_La6NOqXVLroL8e8mKltQXI")]
            public n7.NoiseBasisInflection __slot_La6NOqXVLroL8e8mKltQXI;
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw = default(n15.Spread<n6.GpuValue<T>>);
            public __RQuvteaqhzTOzLgbqtev9S(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RQuvteaqhzTOzLgbqtev9S(__RQuvteaqhzTOzLgbqtev9S other): base(other)
            {
                this.__p_SXbHy8OlO9QMVdApopPXGz = other.__p_SXbHy8OlO9QMVdApopPXGz;
                this.__p_Q1qw4pLnELyQawQoMXCSyx = other.__p_Q1qw4pLnELyQawQoMXCSyx;
                this.__slot_La6NOqXVLroL8e8mKltQXI = other.__slot_La6NOqXVLroL8e8mKltQXI;
                this.__pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw = other.__pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_SXbHy8OlO9QMVdApopPXGz", in __p_SXbHy8OlO9QMVdApopPXGz), n2.CompilationHelper.GetValueOrExisting(values, "__p_Q1qw4pLnELyQawQoMXCSyx", in __p_Q1qw4pLnELyQawQoMXCSyx), n2.CompilationHelper.GetValueOrExisting(values, "__slot_La6NOqXVLroL8e8mKltQXI", in __slot_La6NOqXVLroL8e8mKltQXI), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw", in __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw));
            }

            internal __RQuvteaqhzTOzLgbqtev9S __WITH__(n13.Abs_HYWPOtC1lkrNB5uGryHr5l<T> __p_SXbHy8OlO9QMVdApopPXGz, n13.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_Q1qw4pLnELyQawQoMXCSyx, n7.NoiseBasisInflection __slot_La6NOqXVLroL8e8mKltQXI, n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw)
            {
                __RQuvteaqhzTOzLgbqtev9S that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_SXbHy8OlO9QMVdApopPXGz != this.__p_SXbHy8OlO9QMVdApopPXGz || __p_Q1qw4pLnELyQawQoMXCSyx != this.__p_Q1qw4pLnELyQawQoMXCSyx || !n17.EqualityComparer<n7.NoiseBasisInflection>.Default.Equals(__slot_La6NOqXVLroL8e8mKltQXI, this.__slot_La6NOqXVLroL8e8mKltQXI) || __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw != this.__pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw ? new __RQuvteaqhzTOzLgbqtev9S(this)
                    {__p_SXbHy8OlO9QMVdApopPXGz = __p_SXbHy8OlO9QMVdApopPXGz, __p_Q1qw4pLnELyQawQoMXCSyx = __p_Q1qw4pLnELyQawQoMXCSyx, __slot_La6NOqXVLroL8e8mKltQXI = __slot_La6NOqXVLroL8e8mKltQXI, __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw = __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw} : that_0;
                else
                {
                    this.__p_SXbHy8OlO9QMVdApopPXGz = __p_SXbHy8OlO9QMVdApopPXGz;
                    this.__p_Q1qw4pLnELyQawQoMXCSyx = __p_Q1qw4pLnELyQawQoMXCSyx;
                    this.__slot_La6NOqXVLroL8e8mKltQXI = __slot_La6NOqXVLroL8e8mKltQXI;
                    this.__pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw = __pin_group_Input_In_FJdqQBEvyDfPTy1IrlFrHw;
                }

                return that_0;
            }
        }
    }

    [n2.ElementAttribute(TracingId = 320042U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "EUUud5Q7sNpMkAWzSsjils", Name = "NoiseShaper_EUUud5Q7sNpMkAWzSsjils")]
    [n3.SerializableAttribute]
    public class NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> : n2.VLObject, n3.IDisposable where T : struct
    {
        [n5.CreateNewAttribute]
        public static n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> Create(n2.NodeContext Node_Context)
        {
            var instance = new NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T>(Node_Context, n2.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> CreateDefault()
        {
            var instance = new NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T>(n2.NodeContext.Default, n2.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> Update<AdM>(n6.GpuValue<T> Input_In, n6.GpuValue<T> Amplitude_In, n6.GpuValue<T> Center_In, n6.GpuValue<T> Bias_In, n7.NoiseBasisInflection Inflection_In, out n6.GpuValue<T> Output_Out)
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.GpuValue<T>>
        {
            var w_0 = default(AdM);
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_KZa4mQ400ATPEHYOwWpUk1;
            if (manager_3 is null)
            {
                manager_3 = new n9.Manager<n3.ValueTuple<n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<T>, n7.NoiseBasisInflection>, n3.ValueTuple<n6.GpuValue<T>>>(n3.ValueTuple.Create(default(n6.GpuValue<T>)));
            }

            var inputs_4 = (Input_In, Amplitude_In, Center_In, Bias_In, Inflection_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n2.CompilationHelper.Restore<__OfEXPMMkFkhLHehOQ0i36i>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __OfEXPMMkFkhLHehOQ0i36i(__GetContext__(), n2.VLObject.NewIdentity())
                    {__pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r = n16._Operations_.CreateDefault<n6.GpuValue<T>>(), __slot_Bnep8yzkGL1NbUQL1LL6y8 = default(n7.NoiseBasisInflection)};
                    n2.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "UFGEhJIVEiLQIsp6fgCuxP", 320063U);
                    var Output_9 = n13.Bias_Jjk7Fh6rwfkOVW9xjDuP30<T>.Create(Node_Context: Node_Context_8);
                    state_7.__p_UFGEhJIVEiLQIsp6fgCuxP = Output_9;
                    n2.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "AkAaV2KCVUJOm4FEYtRigP", 320070U);
                    var Output_11 = n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<T>.Create(Node_Context: Node_Context_10);
                    state_7.__p_AkAaV2KCVUJOm4FEYtRigP = Output_11;
                    n2.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "FqtDThc3OUKPNBGgf8dQBx", 320082U);
                    var Output_13 = n13.Abs_HYWPOtC1lkrNB5uGryHr5l<T>.Create(Node_Context: Node_Context_12);
                    state_7.__p_FqtDThc3OUKPNBGgf8dQBx = Output_13;
                    n2.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "DWt9WKPAa6kPlXTfBDPhwe", 320090U);
                    var Output_15 = n13.Sign_UX4v0iAYvhPMxCdeQTTGha<T>.Create(Node_Context: Node_Context_14);
                    state_7.__p_DWt9WKPAa6kPlXTfBDPhwe = Output_15;
                    n2.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "SrYAp1oDLt1Mm1Y3DRxI3r", 320096U);
                    var Output_17 = n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_16);
                    state_7.__p_SrYAp1oDLt1Mm1Y3DRxI3r = Output_17;
                    n2.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "LhqIdoT4pD9PN4Ng7HZzwo", 320104U);
                    var Output_19 = n14.Inflection_RvLt71NM0ixOjnh8J1JqId<T>.Create(Node_Context: Node_Context_18);
                    state_7.__p_LhqIdoT4pD9PN4Ng7HZzwo = Output_19;
                    n2.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("THHHRoIOybiP3bK7HRl5JW", "F0aAaTbyzqJPAavDUwWlxq", 320109U);
                    var Output_21 = n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T>.Create(Node_Context: Node_Context_20);
                    state_7.__p_F0aAaTbyzqJPAavDUwWlxq = Output_21;
                }

                float __pad_U5tGgflxFJiNgbMsoe7cu2_22 = __slot_U5tGgflxFJiNgbMsoe7cu2;
                var Output_24 = state_7.__p_FqtDThc3OUKPNBGgf8dQBx.Update(Input_In: Input_In, Out_Out: out n6.GpuValue<T> Out_23);
                var State_Output_26 = state_7.__p_AkAaV2KCVUJOm4FEYtRigP.Update(GpuValue_In: Bias_In, The_Value_In: __pad_U5tGgflxFJiNgbMsoe7cu2_22, Output_Out: out n6.GpuValue<T> Output_25);
                var State_Output_28 = state_7.__p_UFGEhJIVEiLQIsp6fgCuxP.Update(Input_In: Out_23, Control_In: Output_25, Output_Out: out n6.GpuValue<T> Output_27);
                var Output_30 = state_7.__p_DWt9WKPAa6kPlXTfBDPhwe.Update(Input_In: Input_In, Out_Out: out n6.GpuValue<T> Out_29);
                var builder_31 = n5.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r, 2);
                builder_31.Add(Out_29);
                builder_31.Add(Output_27);
                var __pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r_32 = builder_31.Commit();
                var State_Output_34 = state_7.__p_SrYAp1oDLt1Mm1Y3DRxI3r.Update(Input_In: __pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r_32, Output_Out: out n6.GpuValue<T> Output_33);
                n7.NoiseBasisInflection __pad_Bnep8yzkGL1NbUQL1LL6y8_35 = Inflection_In;
                var State_Output_37 = state_7.__p_LhqIdoT4pD9PN4Ng7HZzwo.Update<AdM>(Input_In: Output_33, Inflection_In: __pad_Bnep8yzkGL1NbUQL1LL6y8_35, Output_Out: out n6.GpuValue<T> Output_36);
                var State_Output_39 = state_7.__p_F0aAaTbyzqJPAavDUwWlxq.Update(Value_In: Output_36, Scale_In: Amplitude_In, Add_In: Center_In, Output_Out: out n6.GpuValue<T> Output_38);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_24 != state_7.__p_FqtDThc3OUKPNBGgf8dQBx || State_Output_26 != state_7.__p_AkAaV2KCVUJOm4FEYtRigP || State_Output_28 != state_7.__p_UFGEhJIVEiLQIsp6fgCuxP || Output_30 != state_7.__p_DWt9WKPAa6kPlXTfBDPhwe || __pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r_32 != state_7.__pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r || State_Output_34 != state_7.__p_SrYAp1oDLt1Mm1Y3DRxI3r || !n17.EqualityComparer<n7.NoiseBasisInflection>.Default.Equals(Inflection_In, state_7.__slot_Bnep8yzkGL1NbUQL1LL6y8) || State_Output_37 != state_7.__p_LhqIdoT4pD9PN4Ng7HZzwo || State_Output_39 != state_7.__p_F0aAaTbyzqJPAavDUwWlxq ? new __OfEXPMMkFkhLHehOQ0i36i(state_7)
                    {__p_FqtDThc3OUKPNBGgf8dQBx = Output_24, __p_AkAaV2KCVUJOm4FEYtRigP = State_Output_26, __p_UFGEhJIVEiLQIsp6fgCuxP = State_Output_28, __p_DWt9WKPAa6kPlXTfBDPhwe = Output_30, __pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r = __pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r_32, __p_SrYAp1oDLt1Mm1Y3DRxI3r = State_Output_34, __slot_Bnep8yzkGL1NbUQL1LL6y8 = Inflection_In, __p_LhqIdoT4pD9PN4Ng7HZzwo = State_Output_37, __p_F0aAaTbyzqJPAavDUwWlxq = State_Output_39} : state_7;
                else
                {
                    state_7.__p_FqtDThc3OUKPNBGgf8dQBx = Output_24;
                    state_7.__p_AkAaV2KCVUJOm4FEYtRigP = State_Output_26;
                    state_7.__p_UFGEhJIVEiLQIsp6fgCuxP = State_Output_28;
                    state_7.__p_DWt9WKPAa6kPlXTfBDPhwe = Output_30;
                    state_7.__pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r = __pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r_32;
                    state_7.__p_SrYAp1oDLt1Mm1Y3DRxI3r = State_Output_34;
                    state_7.__slot_Bnep8yzkGL1NbUQL1LL6y8 = Inflection_In;
                    state_7.__p_LhqIdoT4pD9PN4Ng7HZzwo = State_Output_37;
                    state_7.__p_F0aAaTbyzqJPAavDUwWlxq = State_Output_39;
                }

                outputs_5 = n3.ValueTuple.Create(Output_38);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_40 = outputs_5.Item1;
            Output_Out = __auto_40;
            n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> that_41 = this;
            if (this.__GetContext__().IsImmutable)
                that_41 = manager_3 != this.__cache_KZa4mQ400ATPEHYOwWpUk1 ? new NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T>(this)
                {__cache_KZa4mQ400ATPEHYOwWpUk1 = manager_3} : that_41;
            else
            {
                this.__cache_KZa4mQ400ATPEHYOwWpUk1 = manager_3;
            }

            return that_41;
        }

        public n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> __Create__(n2.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> that_0 = this;
            this.__cache_KZa4mQ400ATPEHYOwWpUk1 = null;
            return that_0;
        }

        public n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> __CreateDefault__()
        {
            n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> that_0 = this;
            this.__cache_KZa4mQ400ATPEHYOwWpUk1 = null;
            return that_0;
        }

        public void Dispose()
        {
            n2.CompilationHelper.SafeDispose(this.__cache_KZa4mQ400ATPEHYOwWpUk1);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n2.ElementAttribute(TracingId = 320144U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "UnUiZdP9q5rNEwiYhE2e7S", Name = "__slot_UnUiZdP9q5rNEwiYhE2e7S")]
        public static string __slot_UnUiZdP9q5rNEwiYhE2e7S = "Apply Bias";
        [n2.ElementAttribute(TracingId = 320151U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "EE7PfNVhn9BOxxY7m9IEiL", Name = "__slot_EE7PfNVhn9BOxxY7m9IEiL")]
        public static string __slot_EE7PfNVhn9BOxxY7m9IEiL = "Apply Inflection ";
        [n2.ElementAttribute(TracingId = 320153U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "PIONizziP28MLBO9Nq0kMk", Name = "__slot_PIONizziP28MLBO9Nq0kMk")]
        public static string __slot_PIONizziP28MLBO9Nq0kMk = "Multiply and offset the Result";
        [n2.ElementAttribute(TracingId = 320045U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "KZa4mQ400ATPEHYOwWpUk1", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n9.Manager<n3.ValueTuple<n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<T>, n7.NoiseBasisInflection>, n3.ValueTuple<n6.GpuValue<T>>> __cache_KZa4mQ400ATPEHYOwWpUk1 = null;
        [n2.ElementAttribute(TracingId = 320080U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "U5tGgflxFJiNgbMsoe7cu2", Name = "__slot_U5tGgflxFJiNgbMsoe7cu2")]
        public static float __slot_U5tGgflxFJiNgbMsoe7cu2 = 0.5F;
        static NoiseShaper_EUUud5Q7sNpMkAWzSsjils()
        {
        }

        public NoiseShaper_EUUud5Q7sNpMkAWzSsjils(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal NoiseShaper_EUUud5Q7sNpMkAWzSsjils(NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> other): base(other)
        {
            this.__cache_KZa4mQ400ATPEHYOwWpUk1 = other.__cache_KZa4mQ400ATPEHYOwWpUk1;
        }

        protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__cache_KZa4mQ400ATPEHYOwWpUk1", in __cache_KZa4mQ400ATPEHYOwWpUk1));
        }

        internal NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> __WITH__(n9.Manager<n3.ValueTuple<n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<T>, n6.GpuValue<T>, n7.NoiseBasisInflection>, n3.ValueTuple<n6.GpuValue<T>>> __cache_KZa4mQ400ATPEHYOwWpUk1)
        {
            n14.NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_KZa4mQ400ATPEHYOwWpUk1 != this.__cache_KZa4mQ400ATPEHYOwWpUk1 ? new NoiseShaper_EUUud5Q7sNpMkAWzSsjils<T>(this)
                {__cache_KZa4mQ400ATPEHYOwWpUk1 = __cache_KZa4mQ400ATPEHYOwWpUk1} : that_0;
            else
            {
                this.__cache_KZa4mQ400ATPEHYOwWpUk1 = __cache_KZa4mQ400ATPEHYOwWpUk1;
            }

            return that_0;
        }

        [n2.ElementAttribute(DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "OfEXPMMkFkhLHehOQ0i36i", Name = "__OfEXPMMkFkhLHehOQ0i36i")]
        [n3.SerializableAttribute]
        public class __OfEXPMMkFkhLHehOQ0i36i : n2.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n2.CompilationHelper.SafeDispose(this.__p_UFGEhJIVEiLQIsp6fgCuxP);
                n2.CompilationHelper.SafeDispose(this.__p_AkAaV2KCVUJOm4FEYtRigP);
                n2.CompilationHelper.SafeDispose(this.__p_FqtDThc3OUKPNBGgf8dQBx);
                n2.CompilationHelper.SafeDispose(this.__p_DWt9WKPAa6kPlXTfBDPhwe);
                n2.CompilationHelper.SafeDispose(this.__p_SrYAp1oDLt1Mm1Y3DRxI3r);
                n2.CompilationHelper.SafeDispose(this.__p_LhqIdoT4pD9PN4Ng7HZzwo);
                n2.CompilationHelper.SafeDispose(this.__p_F0aAaTbyzqJPAavDUwWlxq);
                return;
            }

            [n2.ElementAttribute(TracingId = 320063U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "UFGEhJIVEiLQIsp6fgCuxP", Name = "Bias", IsManaged = true, IsAutoGenerated = true)]
            public n13.Bias_Jjk7Fh6rwfkOVW9xjDuP30<T> __p_UFGEhJIVEiLQIsp6fgCuxP;
            [n2.ElementAttribute(TracingId = 320070U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "AkAaV2KCVUJOm4FEYtRigP", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<T> __p_AkAaV2KCVUJOm4FEYtRigP;
            [n2.ElementAttribute(TracingId = 320082U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "FqtDThc3OUKPNBGgf8dQBx", Name = "Abs", IsManaged = true, IsAutoGenerated = true)]
            public n13.Abs_HYWPOtC1lkrNB5uGryHr5l<T> __p_FqtDThc3OUKPNBGgf8dQBx;
            [n2.ElementAttribute(TracingId = 320090U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "DWt9WKPAa6kPlXTfBDPhwe", Name = "Sign", IsManaged = true, IsAutoGenerated = true)]
            public n13.Sign_UX4v0iAYvhPMxCdeQTTGha<T> __p_DWt9WKPAa6kPlXTfBDPhwe;
            [n2.ElementAttribute(TracingId = 320096U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SrYAp1oDLt1Mm1Y3DRxI3r", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_SrYAp1oDLt1Mm1Y3DRxI3r;
            [n2.ElementAttribute(TracingId = 320104U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LhqIdoT4pD9PN4Ng7HZzwo", Name = "Inflection", IsManaged = true, IsAutoGenerated = true)]
            public n14.Inflection_RvLt71NM0ixOjnh8J1JqId<T> __p_LhqIdoT4pD9PN4Ng7HZzwo;
            [n2.ElementAttribute(TracingId = 320109U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "F0aAaTbyzqJPAavDUwWlxq", Name = "ScaleAndAdd", IsManaged = true, IsAutoGenerated = true)]
            public n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T> __p_F0aAaTbyzqJPAavDUwWlxq;
            [n2.ElementAttribute(IsAutoGenerated = true)]
            public n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r = default(n15.Spread<n6.GpuValue<T>>);
            [n2.ElementAttribute(TracingId = 320103U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Bnep8yzkGL1NbUQL1LL6y8", Name = "__slot_Bnep8yzkGL1NbUQL1LL6y8")]
            public n7.NoiseBasisInflection __slot_Bnep8yzkGL1NbUQL1LL6y8;
            public __OfEXPMMkFkhLHehOQ0i36i(n2.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __OfEXPMMkFkhLHehOQ0i36i(__OfEXPMMkFkhLHehOQ0i36i other): base(other)
            {
                this.__p_UFGEhJIVEiLQIsp6fgCuxP = other.__p_UFGEhJIVEiLQIsp6fgCuxP;
                this.__p_AkAaV2KCVUJOm4FEYtRigP = other.__p_AkAaV2KCVUJOm4FEYtRigP;
                this.__p_FqtDThc3OUKPNBGgf8dQBx = other.__p_FqtDThc3OUKPNBGgf8dQBx;
                this.__p_DWt9WKPAa6kPlXTfBDPhwe = other.__p_DWt9WKPAa6kPlXTfBDPhwe;
                this.__p_SrYAp1oDLt1Mm1Y3DRxI3r = other.__p_SrYAp1oDLt1Mm1Y3DRxI3r;
                this.__p_LhqIdoT4pD9PN4Ng7HZzwo = other.__p_LhqIdoT4pD9PN4Ng7HZzwo;
                this.__p_F0aAaTbyzqJPAavDUwWlxq = other.__p_F0aAaTbyzqJPAavDUwWlxq;
                this.__pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r = other.__pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r;
                this.__slot_Bnep8yzkGL1NbUQL1LL6y8 = other.__slot_Bnep8yzkGL1NbUQL1LL6y8;
            }

            protected override n2.IVLObject __With__(n17.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n2.CompilationHelper.GetValueOrExisting(values, "__p_UFGEhJIVEiLQIsp6fgCuxP", in __p_UFGEhJIVEiLQIsp6fgCuxP), n2.CompilationHelper.GetValueOrExisting(values, "__p_AkAaV2KCVUJOm4FEYtRigP", in __p_AkAaV2KCVUJOm4FEYtRigP), n2.CompilationHelper.GetValueOrExisting(values, "__p_FqtDThc3OUKPNBGgf8dQBx", in __p_FqtDThc3OUKPNBGgf8dQBx), n2.CompilationHelper.GetValueOrExisting(values, "__p_DWt9WKPAa6kPlXTfBDPhwe", in __p_DWt9WKPAa6kPlXTfBDPhwe), n2.CompilationHelper.GetValueOrExisting(values, "__p_SrYAp1oDLt1Mm1Y3DRxI3r", in __p_SrYAp1oDLt1Mm1Y3DRxI3r), n2.CompilationHelper.GetValueOrExisting(values, "__p_LhqIdoT4pD9PN4Ng7HZzwo", in __p_LhqIdoT4pD9PN4Ng7HZzwo), n2.CompilationHelper.GetValueOrExisting(values, "__p_F0aAaTbyzqJPAavDUwWlxq", in __p_F0aAaTbyzqJPAavDUwWlxq), n2.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r", in __pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r), n2.CompilationHelper.GetValueOrExisting(values, "__slot_Bnep8yzkGL1NbUQL1LL6y8", in __slot_Bnep8yzkGL1NbUQL1LL6y8));
            }

            internal __OfEXPMMkFkhLHehOQ0i36i __WITH__(n13.Bias_Jjk7Fh6rwfkOVW9xjDuP30<T> __p_UFGEhJIVEiLQIsp6fgCuxP, n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<T> __p_AkAaV2KCVUJOm4FEYtRigP, n13.Abs_HYWPOtC1lkrNB5uGryHr5l<T> __p_FqtDThc3OUKPNBGgf8dQBx, n13.Sign_UX4v0iAYvhPMxCdeQTTGha<T> __p_DWt9WKPAa6kPlXTfBDPhwe, n13.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_SrYAp1oDLt1Mm1Y3DRxI3r, n14.Inflection_RvLt71NM0ixOjnh8J1JqId<T> __p_LhqIdoT4pD9PN4Ng7HZzwo, n13.ScaleAndAdd_NPTXxzxy3nUOJMij86GK6Z<T> __p_F0aAaTbyzqJPAavDUwWlxq, n15.Spread<n6.GpuValue<T>> __pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r, n7.NoiseBasisInflection __slot_Bnep8yzkGL1NbUQL1LL6y8)
            {
                __OfEXPMMkFkhLHehOQ0i36i that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_UFGEhJIVEiLQIsp6fgCuxP != this.__p_UFGEhJIVEiLQIsp6fgCuxP || __p_AkAaV2KCVUJOm4FEYtRigP != this.__p_AkAaV2KCVUJOm4FEYtRigP || __p_FqtDThc3OUKPNBGgf8dQBx != this.__p_FqtDThc3OUKPNBGgf8dQBx || __p_DWt9WKPAa6kPlXTfBDPhwe != this.__p_DWt9WKPAa6kPlXTfBDPhwe || __p_SrYAp1oDLt1Mm1Y3DRxI3r != this.__p_SrYAp1oDLt1Mm1Y3DRxI3r || __p_LhqIdoT4pD9PN4Ng7HZzwo != this.__p_LhqIdoT4pD9PN4Ng7HZzwo || __p_F0aAaTbyzqJPAavDUwWlxq != this.__p_F0aAaTbyzqJPAavDUwWlxq || __pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r != this.__pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r || !n17.EqualityComparer<n7.NoiseBasisInflection>.Default.Equals(__slot_Bnep8yzkGL1NbUQL1LL6y8, this.__slot_Bnep8yzkGL1NbUQL1LL6y8) ? new __OfEXPMMkFkhLHehOQ0i36i(this)
                    {__p_UFGEhJIVEiLQIsp6fgCuxP = __p_UFGEhJIVEiLQIsp6fgCuxP, __p_AkAaV2KCVUJOm4FEYtRigP = __p_AkAaV2KCVUJOm4FEYtRigP, __p_FqtDThc3OUKPNBGgf8dQBx = __p_FqtDThc3OUKPNBGgf8dQBx, __p_DWt9WKPAa6kPlXTfBDPhwe = __p_DWt9WKPAa6kPlXTfBDPhwe, __p_SrYAp1oDLt1Mm1Y3DRxI3r = __p_SrYAp1oDLt1Mm1Y3DRxI3r, __p_LhqIdoT4pD9PN4Ng7HZzwo = __p_LhqIdoT4pD9PN4Ng7HZzwo, __p_F0aAaTbyzqJPAavDUwWlxq = __p_F0aAaTbyzqJPAavDUwWlxq, __pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r = __pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r, __slot_Bnep8yzkGL1NbUQL1LL6y8 = __slot_Bnep8yzkGL1NbUQL1LL6y8} : that_0;
                else
                {
                    this.__p_UFGEhJIVEiLQIsp6fgCuxP = __p_UFGEhJIVEiLQIsp6fgCuxP;
                    this.__p_AkAaV2KCVUJOm4FEYtRigP = __p_AkAaV2KCVUJOm4FEYtRigP;
                    this.__p_FqtDThc3OUKPNBGgf8dQBx = __p_FqtDThc3OUKPNBGgf8dQBx;
                    this.__p_DWt9WKPAa6kPlXTfBDPhwe = __p_DWt9WKPAa6kPlXTfBDPhwe;
                    this.__p_SrYAp1oDLt1Mm1Y3DRxI3r = __p_SrYAp1oDLt1Mm1Y3DRxI3r;
                    this.__p_LhqIdoT4pD9PN4Ng7HZzwo = __p_LhqIdoT4pD9PN4Ng7HZzwo;
                    this.__p_F0aAaTbyzqJPAavDUwWlxq = __p_F0aAaTbyzqJPAavDUwWlxq;
                    this.__pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r = __pin_group_Input_In_SrYAp1oDLt1Mm1Y3DRxI3r;
                    this.__slot_Bnep8yzkGL1NbUQL1LL6y8 = __slot_Bnep8yzkGL1NbUQL1LL6y8;
                }

                return that_0;
            }
        }
    }
}

namespace _Fuse_Common_Noise_.Fuse.Common.Noise.Noise__2D_Scalar
{
    [n2.ElementAttribute(TracingId = 316725U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Noise2DScalarID(out string Output_Out)
        {
            string __pad_KlYhRTFTYkVNmC9edPWViY_0 = __slot_KlYhRTFTYkVNmC9edPWViY;
            Output_Out = __pad_KlYhRTFTYkVNmC9edPWViY_0;
            return;
        }

        [n2.ElementAttribute(TracingId = 320491U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "KlYhRTFTYkVNmC9edPWViY", Name = "__slot_KlYhRTFTYkVNmC9edPWViY")]
        public static string __slot_KlYhRTFTYkVNmC9edPWViY = "Noise2DScalar";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Common_Noise_.Fuse.Common.Noise.Noise__2D_Vector
{
    [n2.ElementAttribute(TracingId = 316725U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Noise2DVectorID(out string Output_Out)
        {
            string __pad_DnPUDTwycU1OD7XAsnN8Ar_0 = __slot_DnPUDTwycU1OD7XAsnN8Ar;
            Output_Out = __pad_DnPUDTwycU1OD7XAsnN8Ar_0;
            return;
        }

        [n2.ElementAttribute(TracingId = 320841U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "DnPUDTwycU1OD7XAsnN8Ar", Name = "__slot_DnPUDTwycU1OD7XAsnN8Ar")]
        public static string __slot_DnPUDTwycU1OD7XAsnN8Ar = "Noise2DVector";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Common_Noise_.Fuse.Common.Noise.Noise__3D_Scalar
{
    [n2.ElementAttribute(TracingId = 316725U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Noise3DScalarID(out string Output_Out)
        {
            string __pad_Qqn17ivK4oXP7QjVrU9uG8_0 = __slot_Qqn17ivK4oXP7QjVrU9uG8;
            Output_Out = __pad_Qqn17ivK4oXP7QjVrU9uG8_0;
            return;
        }

        [n2.ElementAttribute(TracingId = 321113U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Qqn17ivK4oXP7QjVrU9uG8", Name = "__slot_Qqn17ivK4oXP7QjVrU9uG8")]
        public static string __slot_Qqn17ivK4oXP7QjVrU9uG8 = "Noise3DScalar";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Common_Noise_.Fuse.Common.Noise.Noise__3D_Vector
{
    [n2.ElementAttribute(TracingId = 316725U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Noise3DVectorID(out string Output_Out)
        {
            string __pad_SSxfw1FouClQM9HoZIUpK1_0 = __slot_SSxfw1FouClQM9HoZIUpK1;
            Output_Out = __pad_SSxfw1FouClQM9HoZIUpK1_0;
            return;
        }

        [n2.ElementAttribute(TracingId = 321288U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SSxfw1FouClQM9HoZIUpK1", Name = "__slot_SSxfw1FouClQM9HoZIUpK1")]
        public static string __slot_SSxfw1FouClQM9HoZIUpK1 = "Noise3DVector";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Common_Noise_.Fuse.Common.Noise.NoiseGradient__3D_Scalar
{
    [n2.ElementAttribute(TracingId = 316725U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Noise3DGradientID(out string Output_Out)
        {
            string __pad_LcplU7Z6JZvOiM1J3CdKAS_0 = __slot_LcplU7Z6JZvOiM1J3CdKAS;
            Output_Out = __pad_LcplU7Z6JZvOiM1J3CdKAS_0;
            return;
        }

        public static void Noise3DGradientGradID(out string Output_Out)
        {
            string __pad_SIGQaAsNxXSPDj2uoeykhy_0 = __slot_SIGQaAsNxXSPDj2uoeykhy;
            Output_Out = __pad_SIGQaAsNxXSPDj2uoeykhy_0;
            return;
        }

        [n2.ElementAttribute(TracingId = 321459U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "LcplU7Z6JZvOiM1J3CdKAS", Name = "__slot_LcplU7Z6JZvOiM1J3CdKAS")]
        public static string __slot_LcplU7Z6JZvOiM1J3CdKAS = "Noise3DGradient";
        [n2.ElementAttribute(TracingId = 321466U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "SIGQaAsNxXSPDj2uoeykhy", Name = "__slot_SIGQaAsNxXSPDj2uoeykhy")]
        public static string __slot_SIGQaAsNxXSPDj2uoeykhy = "Noise3DGradient";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Common_Noise_.Fuse.Common.Noise.NoiseDivergenceFree__3D_Vector
{
    [n2.ElementAttribute(TracingId = 316725U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void NoiseDivergenceFree3DVectorID(out string Output_Out)
        {
            string __pad_U3igobvaZIvO6N8AFGJQfR_0 = __slot_U3igobvaZIvO6N8AFGJQfR;
            Output_Out = __pad_U3igobvaZIvO6N8AFGJQfR_0;
            return;
        }

        [n2.ElementAttribute(TracingId = 321600U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "U3igobvaZIvO6N8AFGJQfR", Name = "__slot_U3igobvaZIvO6N8AFGJQfR")]
        public static string __slot_U3igobvaZIvO6N8AFGJQfR = "NoiseDivergenceFree3DVector";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Common_Noise_.Fuse.Common.Noise.Noise__1D
{
    [n2.ElementAttribute(TracingId = 316725U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Noise1DID(out string Output_Out)
        {
            string __pad_QRxIVcK1sorQYH3gXhrxaz_0 = __slot_QRxIVcK1sorQYH3gXhrxaz;
            Output_Out = __pad_QRxIVcK1sorQYH3gXhrxaz_0;
            return;
        }

        [n2.ElementAttribute(TracingId = 321759U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "QRxIVcK1sorQYH3gXhrxaz", Name = "__slot_QRxIVcK1sorQYH3gXhrxaz")]
        public static string __slot_QRxIVcK1sorQYH3gXhrxaz = "Noise1D";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Common_Noise_.Fuse.Common.Noise.WorleyNoise__1D
{
    [n2.ElementAttribute(TracingId = 316725U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void WorleySmooth1DID(out string Output_Out)
        {
            string __pad_R9dTZvgvjmnNL89FwrMZsy_0 = __slot_R9dTZvgvjmnNL89FwrMZsy;
            Output_Out = __pad_R9dTZvgvjmnNL89FwrMZsy_0;
            return;
        }

        public static void WorleySmooth1DCellID(out string Output_Out)
        {
            string __pad_MpQ4yxY4s7vMAAP00IuuSV_0 = __slot_MpQ4yxY4s7vMAAP00IuuSV;
            Output_Out = __pad_MpQ4yxY4s7vMAAP00IuuSV_0;
            return;
        }

        public static void WorleySmooth1DCellPosID(out string Output_Out)
        {
            string __pad_NO9kPvlyOm4M0V4E9j1Hhf_0 = __slot_NO9kPvlyOm4M0V4E9j1Hhf;
            Output_Out = __pad_NO9kPvlyOm4M0V4E9j1Hhf_0;
            return;
        }

        [n2.ElementAttribute(TracingId = 321968U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "R9dTZvgvjmnNL89FwrMZsy", Name = "__slot_R9dTZvgvjmnNL89FwrMZsy")]
        public static string __slot_R9dTZvgvjmnNL89FwrMZsy = "WorleySmooth1D";
        [n2.ElementAttribute(TracingId = 321981U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "MpQ4yxY4s7vMAAP00IuuSV", Name = "__slot_MpQ4yxY4s7vMAAP00IuuSV")]
        public static string __slot_MpQ4yxY4s7vMAAP00IuuSV = "WorleySmooth1DCell";
        [n2.ElementAttribute(TracingId = 321988U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "NO9kPvlyOm4M0V4E9j1Hhf", Name = "__slot_NO9kPvlyOm4M0V4E9j1Hhf")]
        public static string __slot_NO9kPvlyOm4M0V4E9j1Hhf = "WorleySmooth1DCellPos";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Common_Noise_.Fuse.Common.Noise.WorleyNoise__2D_Scalar
{
    [n2.ElementAttribute(TracingId = 316725U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void WorleySmooth2DID(out string Output_Out)
        {
            string __pad_KfHChFKLrsSMdXTZk1zavO_0 = __slot_KfHChFKLrsSMdXTZk1zavO;
            Output_Out = __pad_KfHChFKLrsSMdXTZk1zavO_0;
            return;
        }

        public static void WorleySmooth2DCellID(out string Output_Out)
        {
            string __pad_Q3LiWUx231vNG56VKGFjFb_0 = __slot_Q3LiWUx231vNG56VKGFjFb;
            Output_Out = __pad_Q3LiWUx231vNG56VKGFjFb_0;
            return;
        }

        public static void WorleySmooth2DCellPosID(out string Output_Out)
        {
            string __pad_QwrIQuoDphAQLlvyVSocz0_0 = __slot_QwrIQuoDphAQLlvyVSocz0;
            Output_Out = __pad_QwrIQuoDphAQLlvyVSocz0_0;
            return;
        }

        [n2.ElementAttribute(TracingId = 322227U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "KfHChFKLrsSMdXTZk1zavO", Name = "__slot_KfHChFKLrsSMdXTZk1zavO")]
        public static string __slot_KfHChFKLrsSMdXTZk1zavO = "WorleySmooth2D";
        [n2.ElementAttribute(TracingId = 322240U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "Q3LiWUx231vNG56VKGFjFb", Name = "__slot_Q3LiWUx231vNG56VKGFjFb")]
        public static string __slot_Q3LiWUx231vNG56VKGFjFb = "WorleySmooth2DCell";
        [n2.ElementAttribute(TracingId = 322247U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "QwrIQuoDphAQLlvyVSocz0", Name = "__slot_QwrIQuoDphAQLlvyVSocz0")]
        public static string __slot_QwrIQuoDphAQLlvyVSocz0 = "WorleySmooth2DCellPos";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Common_Noise_.Fuse.Common.Noise.WorleyNoise__3D_Scalar
{
    [n2.ElementAttribute(TracingId = 316725U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void WorleySmooth3DID(out string Output_Out)
        {
            string __pad_VgXEaNKEvhpMYDB5hNcPqr_0 = __slot_VgXEaNKEvhpMYDB5hNcPqr;
            Output_Out = __pad_VgXEaNKEvhpMYDB5hNcPqr_0;
            return;
        }

        public static void WorleySmooth3DCellID(out string Output_Out)
        {
            string __pad_O6wuTDZuHXdOUFa64Qv47Y_0 = __slot_O6wuTDZuHXdOUFa64Qv47Y;
            Output_Out = __pad_O6wuTDZuHXdOUFa64Qv47Y_0;
            return;
        }

        public static void WorleySmooth3DCellPosID(out string Output_Out)
        {
            string __pad_IJpbcJTuweiMKEzv33SyQO_0 = __slot_IJpbcJTuweiMKEzv33SyQO;
            Output_Out = __pad_IJpbcJTuweiMKEzv33SyQO_0;
            return;
        }

        [n2.ElementAttribute(TracingId = 322485U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "VgXEaNKEvhpMYDB5hNcPqr", Name = "__slot_VgXEaNKEvhpMYDB5hNcPqr")]
        public static string __slot_VgXEaNKEvhpMYDB5hNcPqr = "WorleySmooth3D";
        [n2.ElementAttribute(TracingId = 322498U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "O6wuTDZuHXdOUFa64Qv47Y", Name = "__slot_O6wuTDZuHXdOUFa64Qv47Y")]
        public static string __slot_O6wuTDZuHXdOUFa64Qv47Y = "WorleySmooth3DCell";
        [n2.ElementAttribute(TracingId = 322505U, DocumentId = "THHHRoIOybiP3bK7HRl5JW", PersistentId = "IJpbcJTuweiMKEzv33SyQO", Name = "__slot_IJpbcJTuweiMKEzv33SyQO")]
        public static string __slot_IJpbcJTuweiMKEzv33SyQO = "WorleySmooth3DCellPos";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Common_Noise_
{
    public struct __AdaptiveImplementations__THHHRoIOybiP3bK7HRl5JW : n18.IAdaptiveCreateDefault<n6.GpuValue<float>>, n18.IAdaptiveCreateDefault<n6.GpuValue<n29.Vector2>>, n18.IAdaptiveCreateDefault<n6.GpuValue<n29.Vector3>>
    {
        public void CreateDefault(out n6.GpuValue<float> Output_Out)
        {
            n48._Operations_.CreateDefault_Generic<n6.GpuValue<float>>(Output_Out: out n6.GpuValue<float> Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n6.GpuValue<n29.Vector2> Output_Out)
        {
            n48._Operations_.CreateDefault_Generic<n6.GpuValue<n29.Vector2>>(Output_Out: out n6.GpuValue<n29.Vector2> Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n6.GpuValue<n29.Vector3> Output_Out)
        {
            n48._Operations_.CreateDefault_Generic<n6.GpuValue<n29.Vector3>>(Output_Out: out n6.GpuValue<n29.Vector3> Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}