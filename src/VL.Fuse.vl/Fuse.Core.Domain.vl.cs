extern alias e24;
extern alias e3;
extern alias e2;
extern alias e71;
extern alias e4;

using n50 = _Fuse_Core_Domain_.Fuse.Core.Domain._3D.DomainRepeat;
using n51 = _Fuse_Core_Domain_.Fuse.Core.Domain._3D.WorldSpace;
using n11 = e2::VL.Lib.Collections;
using n52 = _Fuse_Core_Domain_.Fuse.Core.Domain.FunctionHelpers;
using n7 = e3::VL.Lib.Primitive.CacheRegion;
using n36 = _CoreLibBasics_.Primitive.Object.Advanced;
using n32 = _Fuse_Core_Domain_.Fuse.Core.Domain._2D.WorldToTri;
using n13 = _CoreLibBasics_.Control;
using n16 = _VL_Collections_.Collections.Dictionary;
using n15 = global::System.Collections.Immutable;
using n31 = _Fuse_Core_Domain_.Fuse.Core.Domain._2D.HexToWorld;
using n5 = e71::Fuse;
using n39 = _Fuse_Core_.Fuse.Core.DrawShader;
using n46 = _Fuse_Core_Domain_.Fuse.Core.Domain._3D;
using n35 = _Fuse_Core_Domain_.Fuse.Core.Domain._2D.DomainRepeat;
using n25 = _VL_Stride_Engine_.Stride.Models.Experimental;
using n45 = _CoreLibBasics_.Primitive.String;
using n21 = _Fuse_Core_.Fuse.Core.Function;
using n8 = global::System.Collections.Generic;
using n49 = _Fuse_Core_.Fuse.Core.Split;
using n54 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n34 = e71::Fuse.Core.Domain;
using n38 = _Fuse_Core_Domain_.Fuse.Core.Domain._2D.UVToScreen;
using n20 = _Fuse_Core_Math_.Fuse.Core.Math;
using n41 = _Fuse_Core_.Fuse.Core.Join;
using n44 = e3::VL.Lib.Primitive;
using n27 = e24::Stride.Engine;
using n37 = _Fuse_Core_Domain_.Fuse.Core.Domain._2D.ScreenToUV;
using n28 = _Fuse_Core_Domain_.Fuse.Core.Domain._2D;
using n3 = _Fuse_Core_Domain_.Fuse.Core.Domain;
using n33 = _Fuse_Core_Domain_.Fuse.Core.Domain._2D.TriToWorld;
using n6 = e71::Fuse.math;
using n48 = e71::Fuse.Core.Base;
using n1 = e2::VL.Core;
using n12 = _Fuse_Core_Domain_;
using n24 = _Fuse_Core_.Fuse.Core.Value;
using n2 = global::System;
using n22 = e4::Stride.Core.Mathematics;
using n23 = _Fuse_Core_Math_.Fuse.Core.Math.transform;
using n47 = _Fuse_Core_.Fuse.Core.Control;
using n14 = e3::VL.Lib.Primitive.Object;
using n29 = _Fuse_Core_Domain_.Fuse.Core.Domain.Internal;
using n40 = _Fuse_Core_.Fuse.Core.Swizzle;
using n4 = e2::VL.Core.CompilerServices;
using n30 = _Fuse_Core_Domain_.Fuse.Core.Domain._2D.WorldToHex;
using n43 = _Fuse_Core_Domain_.Fuse.Core.Domain._2D.PolarToCartesian;
using n26 = _VL_Stride_Engine_.Stride;
using n9 = _Fuse_Core_.Fuse.Core.Implementation;
using n10 = _Fuse_Core_.Fuse.Core.Util;
using n18 = _VL_Collections_.Collections.Sequence;
using n19 = global::System.Runtime.CompilerServices;
using n42 = _Fuse_Core_.Fuse.Core.Conversion;
using n17 = _VL_Collections_.Collections.Spread;
using n53 = _CoreLibBasics_.Primitive.Advanced;

namespace _Fuse_Core_Domain_.Fuse.Core.Domain
{
    [n1.ElementAttribute(TracingId = 343074U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "UQq752M7mXvPeGKxenzyF4", Name = "DistanceMetrics_UQq752M7mXvPeGKxenzyF4")]
    [n2.SerializableAttribute]
    public class DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> CreateDefault()
        {
            var instance = new DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> Update(n5.GpuValue<T> Input_In, n5.GpuValue<T> Input_2_In, n6.DistanceMetricsSelector Metric_In, n5.GpuValue<float> Minkowski_Power_In, out n5.GpuValue<float> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_EmPGSIwgieAMj97jKdmEp7;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n6.DistanceMetricsSelector, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<float>>>(n2.ValueTuple.Create(default(n5.GpuValue<float>)));
            }

            var inputs_3 = (Input_In, Input_2_In, Metric_In, Minkowski_Power_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__IeSmvYiYUP2OknFeiEnByM>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __IeSmvYiYUP2OknFeiEnByM(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW = n17._Operations_.CreateDefault<string>(), __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ = n16._Operations_.CreateDefault<string, string>(), __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL = n17._Operations_.CreateDefault<n5.AbstractGpuValue>(), __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl = n17._Operations_.CreateDefault<n5.AbstractGpuValue>(), __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR = n17._Operations_.CreateDefault<n5.GpuValue<float>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "NFm2yHDfRZWPi15UFthUdL", 343130U);
                    var Output_8 = n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n8.IEnumerable<n5.InputModifier>>.Create(Node_Context: Node_Context_7);
                    state_6.__p_NFm2yHDfRZWPi15UFthUdL = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "K69rI8ulmYiLgvFj0q7bSl", 343465U);
                    var Output_10 = n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n8.IEnumerable<n5.InputModifier>>.Create(Node_Context: Node_Context_9);
                    state_6.__p_K69rI8ulmYiLgvFj0q7bSl = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "DhTWPlCfhOSOewlPVInsqG", 343612U);
                    var Output_12 = n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_11);
                    state_6.__p_DhTWPlCfhOSOewlPVInsqG = Output_12;
                }

                float __pad_Az1TsCljCkUL8Cp1blHPFw_13 = __slot_Az1TsCljCkUL8Cp1blHPFw;
                string __pad_MNhPAs90Kk7Mwix3N78Vhm_14 = __slot_MNhPAs90Kk7Mwix3N78Vhm;
                string __pad_Mafw4DzCskdNCbR7uj4rDR_15 = __slot_Mafw4DzCskdNCbR7uj4rDR;
                int __pad_Fpbf0OLrbDRORSkGWUxsQN_16 = __slot_Fpbf0OLrbDRORSkGWUxsQN;
                string __pad_Cl1AaGyMBDQMq06r4Hw04j_17 = __slot_Cl1AaGyMBDQMq06r4Hw04j;
                string __pad_Oe9JJwySLYAPea90xImM0A_18 = __slot_Oe9JJwySLYAPea90xImM0A;
                string __pad_C6LmfAyeLhrPDI5zTl5pGP_19 = __slot_C6LmfAyeLhrPDI5zTl5pGP;
                string __pad_TVW9fMUkngTOM45Pg07eh9_20 = __slot_TVW9fMUkngTOM45Pg07eh9;
                string __pad_FBIyvCCprudO86OMhgT44S_21 = __slot_FBIyvCCprudO86OMhgT44S;
                string __pad_HNuVd0XmRa5MigCJ1Mcpxm_22 = __slot_HNuVd0XmRa5MigCJ1Mcpxm;
                string __pad_Jz4nwZAE9pkPWQSExXl65L_23 = __slot_Jz4nwZAE9pkPWQSExXl65L;
                int Index_24 = (int)Metric_In;
                string Input_8_25 = "";
                var builder_26 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW, 8);
                builder_26.Add(__pad_Cl1AaGyMBDQMq06r4Hw04j_17);
                builder_26.Add(__pad_Oe9JJwySLYAPea90xImM0A_18);
                builder_26.Add(__pad_C6LmfAyeLhrPDI5zTl5pGP_19);
                builder_26.Add(__pad_TVW9fMUkngTOM45Pg07eh9_20);
                builder_26.Add(__pad_FBIyvCCprudO86OMhgT44S_21);
                builder_26.Add(__pad_HNuVd0XmRa5MigCJ1Mcpxm_22);
                builder_26.Add(__pad_Jz4nwZAE9pkPWQSExXl65L_23);
                builder_26.Add(Input_8_25);
                var __pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW_27 = builder_26.Commit();
                n13._Operations_.Switch<string, n12.__AdaptiveImplementations__MzilLTk6yNROg5SWTCtzZM>(Index_In: Index_24, Input_In: __pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW_27, Output_Out: out string Output_28);
                var Result_29 = n5.TypeHelpers.GetDimension<T>(theValue: Input_In);
                var Result_30 = n14.ObjectHelpers.ToString(input: Result_29);
                var builder_31 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ, 1);
                builder_31.Add("Domain", Result_30);
                var __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ_32 = builder_31.Commit();
                n16._Operations_.Cons<string>(Input_In: __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ_32, Output_Out: out n15.ImmutableDictionary<string, string> Output_33);
                n5.GpuValue<float> Default_Result_34 = default(n5.GpuValue<float>);
                n11.Spread<n5.IFunctionInvokeNode> Functions_35 = n17._Operations_.CreateDefault<n5.IFunctionInvokeNode>();
                n8.IEnumerable<string> Mixins_36 = n18._Operations_.CreateDefault<string>();
                bool Is_Groupable_37 = false;
                n8.IEnumerable<n5.InputModifier> The_Modifiers_38 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_39 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL, 2);
                builder_39.Add(Input_In);
                builder_39.Add(Input_2_In);
                var __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL_40 = builder_39.Commit();
                var State_Output_43 = state_6.__p_NFm2yHDfRZWPi15UFthUdL.Update(Arguments_In: __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL_40, Function_Name_In: __pad_Mafw4DzCskdNCbR7uj4rDR_15, Code_Template_In: Output_28, Default_Result_In: Default_Result_34, Functions_In: Functions_35, Mixins_In: Mixins_36, Template_Values_In: Output_33, Is_Groupable_In: Is_Groupable_37, The_Modifiers_In: The_Modifiers_38, Output_Out: out n5.GpuValue<float> Output_41, AdditionalOutputs_Out: out n11.Spread<n5.AbstractGpuValue> AdditionalOutputs_42);
                var State_Output_45 = state_6.__p_DhTWPlCfhOSOewlPVInsqG.Update(GpuValue_In: Minkowski_Power_In, The_Value_In: __pad_Az1TsCljCkUL8Cp1blHPFw_13, Output_Out: out n5.GpuValue<float> Output_44);
                n5.GpuValue<float> Default_Result_46 = default(n5.GpuValue<float>);
                n11.Spread<n5.IFunctionInvokeNode> Functions_47 = n17._Operations_.CreateDefault<n5.IFunctionInvokeNode>();
                n8.IEnumerable<string> Mixins_48 = n18._Operations_.CreateDefault<string>();
                bool Is_Groupable_49 = false;
                n8.IEnumerable<n5.InputModifier> The_Modifiers_50 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_51 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl, 3);
                builder_51.Add(Input_In);
                builder_51.Add(Input_2_In);
                builder_51.Add(Output_44);
                var __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl_52 = builder_51.Commit();
                var State_Output_55 = state_6.__p_K69rI8ulmYiLgvFj0q7bSl.Update(Arguments_In: __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl_52, Function_Name_In: __pad_Mafw4DzCskdNCbR7uj4rDR_15, Code_Template_In: __pad_MNhPAs90Kk7Mwix3N78Vhm_14, Default_Result_In: Default_Result_46, Functions_In: Functions_47, Mixins_In: Mixins_48, Template_Values_In: Output_33, Is_Groupable_In: Is_Groupable_49, The_Modifiers_In: The_Modifiers_50, Output_Out: out n5.GpuValue<float> Output_53, AdditionalOutputs_Out: out n11.Spread<n5.AbstractGpuValue> AdditionalOutputs_54);
                var AdditionalOutputs_56 = (n5.AbstractGpuValue)AdditionalOutputs_54[0];
                int Input_57 = (int)Metric_In;
                var Result_58 = Input_57 == __pad_Fpbf0OLrbDRORSkGWUxsQN_16;
                bool __pad_BUqd6hpvKuBMExvJWcQSJq_59 = Result_58;
                int Index_60 = n2.Convert.ToInt32(__pad_BUqd6hpvKuBMExvJWcQSJq_59);
                var builder_61 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_PriaxeBN4yrON53uK0KzdR, 2);
                builder_61.Add(Output_41);
                builder_61.Add(Output_53);
                var __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR_62 = builder_61.Commit();
                n13._Operations_.Switch<n5.GpuValue<float>, n12.__AdaptiveImplementations__MzilLTk6yNROg5SWTCtzZM>(Index_In: Index_60, Input_In: __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR_62, Output_Out: out n5.GpuValue<float> Output_63);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = __pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW_27 != state_6.__pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW || __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ_32 != state_6.__pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ || __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL_40 != state_6.__pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL || State_Output_43 != state_6.__p_NFm2yHDfRZWPi15UFthUdL || State_Output_45 != state_6.__p_DhTWPlCfhOSOewlPVInsqG || __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl_52 != state_6.__pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl || State_Output_55 != state_6.__p_K69rI8ulmYiLgvFj0q7bSl || Result_58 != state_6.__slot_BUqd6hpvKuBMExvJWcQSJq || __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR_62 != state_6.__pin_group_Input_In_PriaxeBN4yrON53uK0KzdR ? new __IeSmvYiYUP2OknFeiEnByM(state_6)
                    {__pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW = __pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW_27, __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ = __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ_32, __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL = __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL_40, __p_NFm2yHDfRZWPi15UFthUdL = State_Output_43, __p_DhTWPlCfhOSOewlPVInsqG = State_Output_45, __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl = __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl_52, __p_K69rI8ulmYiLgvFj0q7bSl = State_Output_55, __slot_BUqd6hpvKuBMExvJWcQSJq = Result_58, __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR = __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR_62} : state_6;
                else
                {
                    state_6.__pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW = __pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW_27;
                    state_6.__pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ = __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ_32;
                    state_6.__pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL = __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL_40;
                    state_6.__p_NFm2yHDfRZWPi15UFthUdL = State_Output_43;
                    state_6.__p_DhTWPlCfhOSOewlPVInsqG = State_Output_45;
                    state_6.__pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl = __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl_52;
                    state_6.__p_K69rI8ulmYiLgvFj0q7bSl = State_Output_55;
                    state_6.__slot_BUqd6hpvKuBMExvJWcQSJq = Result_58;
                    state_6.__pin_group_Input_In_PriaxeBN4yrON53uK0KzdR = __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR_62;
                }

                outputs_4 = n2.ValueTuple.Create(Output_63);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_64 = outputs_4.Item1;
            Output_Out = __auto_64;
            n3.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> that_65 = this;
            if (this.__GetContext__().IsImmutable)
                that_65 = manager_2 != this.__cache_EmPGSIwgieAMj97jKdmEp7 ? new DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T>(this)
                {__cache_EmPGSIwgieAMj97jKdmEp7 = manager_2} : that_65;
            else
            {
                this.__cache_EmPGSIwgieAMj97jKdmEp7 = manager_2;
            }

            return that_65;
        }

        public n3.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> that_0 = this;
            this.__cache_EmPGSIwgieAMj97jKdmEp7 = null;
            return that_0;
        }

        public n3.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> __CreateDefault__()
        {
            n3.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> that_0 = this;
            this.__cache_EmPGSIwgieAMj97jKdmEp7 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_EmPGSIwgieAMj97jKdmEp7);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 343665U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "KIn7UfmRLTNLgoLClmYSMl", Name = "__slot_KIn7UfmRLTNLgoLClmYSMl")]
        public static string __slot_KIn7UfmRLTNLgoLClmYSMl = "Domain agnostic distance functions.  These should also hould work with dims > 4, although might need to adapt to use a structured buffer type in that case";
        [n1.ElementAttribute(TracingId = 343682U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "ErgtF355eVNOtOe84npZGg", Name = "__slot_ErgtF355eVNOtOe84npZGg")]
        public static string __slot_ErgtF355eVNOtOe84npZGg = "Nice multipurpose distance metric, but requires an extra power parameter";
        [n1.ElementAttribute(TracingId = 343082U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "EmPGSIwgieAMj97jKdmEp7", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n6.DistanceMetricsSelector, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<float>>> __cache_EmPGSIwgieAMj97jKdmEp7 = null;
        [n1.ElementAttribute(TracingId = 343625U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Az1TsCljCkUL8Cp1blHPFw", Name = "__slot_Az1TsCljCkUL8Cp1blHPFw")]
        public static float __slot_Az1TsCljCkUL8Cp1blHPFw = 1F;
        [n1.ElementAttribute(TracingId = 343605U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "MNhPAs90Kk7Mwix3N78Vhm", Name = "__slot_MNhPAs90Kk7Mwix3N78Vhm")]
        public static string __slot_MNhPAs90Kk7Mwix3N78Vhm = "// Minkowski\r\nfloat ${signature} (float${Domain} a, float${Domain} b, float power = .7)\r\n{\r\n\tfloat result = 0.;\r\n\tfor(int i = 0; i < ${Domain}; i++)\r\n    {\t\r\n\t \tresult += pow(abs(a[i] - b[i]), power);\r\n\t}\r\n\treturn pow(result, 1.0/power);  \r\n}";
        [n1.ElementAttribute(TracingId = 343190U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Mafw4DzCskdNCbR7uj4rDR", Name = "__slot_Mafw4DzCskdNCbR7uj4rDR")]
        public static string __slot_Mafw4DzCskdNCbR7uj4rDR = "DistanceMetric";
        [n1.ElementAttribute(TracingId = 343279U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Fpbf0OLrbDRORSkGWUxsQN", Name = "__slot_Fpbf0OLrbDRORSkGWUxsQN")]
        public static int __slot_Fpbf0OLrbDRORSkGWUxsQN = 7;
        [n1.ElementAttribute(TracingId = 343534U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Cl1AaGyMBDQMq06r4Hw04j", Name = "__slot_Cl1AaGyMBDQMq06r4Hw04j")]
        public static string __slot_Cl1AaGyMBDQMq06r4Hw04j = "// Euclidean\r\nfloat ${signature} (float${Domain} a, float${Domain} b)\r\n{\r\n\treturn distance(a, b);\r\n\t/*\r\n    float result = 0.;\r\n    for(int i = 0; i < ${Domain}; i++)\r\n    {\r\n \t\tresult += ((a[i] - b[i]) * (a[i] - b[i]));\r\n    }\r\n    return sqrt(result);\r\n    */\r\n}";
        [n1.ElementAttribute(TracingId = 343560U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Oe9JJwySLYAPea90xImM0A", Name = "__slot_Oe9JJwySLYAPea90xImM0A")]
        public static string __slot_Oe9JJwySLYAPea90xImM0A = "// EuclideanSquared\r\nfloat ${signature} (float${Domain} a, float${Domain} b)\r\n{\r\n    float result = 0.;\r\n    for(int i = 0; i < ${Domain}; i++)\r\n    {\r\n \t\tresult += ((a[i] - b[i]) * (a[i] - b[i]));\r\n    }\r\n    return result;\r\n}";
        [n1.ElementAttribute(TracingId = 343546U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "C6LmfAyeLhrPDI5zTl5pGP", Name = "__slot_C6LmfAyeLhrPDI5zTl5pGP")]
        public static string __slot_C6LmfAyeLhrPDI5zTl5pGP = "// Chebyshev\r\nfloat ${signature} (float${Domain} a, float${Domain} b)\r\n{\r\n    float maxComponent = abs(a[0] - b[0]);\r\n    for(int i = 1; i < ${Domain}; i++)\r\n    {\r\n \t\tfloat next = abs(a[i] - b[i]);\r\n \t\tmaxComponent = max(maxComponent, next);\r\n    }\r\n    return maxComponent;\r\n}";
        [n1.ElementAttribute(TracingId = 343580U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "TVW9fMUkngTOM45Pg07eh9", Name = "__slot_TVW9fMUkngTOM45Pg07eh9")]
        public static string __slot_TVW9fMUkngTOM45Pg07eh9 = "// Manhattan\r\nfloat ${signature} (float${Domain} a, float${Domain} b)\r\n{\r\n    float result = 0.;\r\n    for(int i = 0; i < ${Domain}; i++)\r\n    {\r\n \t\tresult += abs(a[i] - b[i]);\r\n    }\r\n    return result;\r\n}";
        [n1.ElementAttribute(TracingId = 343590U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "FBIyvCCprudO86OMhgT44S", Name = "__slot_FBIyvCCprudO86OMhgT44S")]
        public static string __slot_FBIyvCCprudO86OMhgT44S = "// Canberra\r\nfloat ${signature} (float${Domain} a, float${Domain} b)\r\n{\r\n    float result = 0.;\r\n    for(int i = 0; i < ${Domain}; i++)\r\n    {\r\n \t\tresult += abs(a[i] - b[i]) / (abs(a[i]) + abs(b[i]));\r\n    }\r\n    return result;\r\n}\r\n";
        [n1.ElementAttribute(TracingId = 343598U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "HNuVd0XmRa5MigCJ1Mcpxm", Name = "__slot_HNuVd0XmRa5MigCJ1Mcpxm")]
        public static string __slot_HNuVd0XmRa5MigCJ1Mcpxm = "// CosineSimilarity\r\nfloat ${signature} (float${Domain} a, float${Domain} b)\r\n{\r\n    float dotProduct = 0;\r\n    float magnitudeOne = 0;\r\n    float magnitudeTwo = 0;\r\n    for(int i = 0; i < ${Domain}; i++)\r\n    {\r\n\t    dotProduct += (a[i] * b[i]);\r\n        magnitudeOne += (a[i] * a[i]);\r\n        magnitudeTwo += (b[i] * b[i]);\r\n    }\r\n    return max(0, 1 - (dotProduct / sqrt(magnitudeOne * magnitudeTwo)));\r\n}";
        [n1.ElementAttribute(TracingId = 343569U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Jz4nwZAE9pkPWQSExXl65L", Name = "__slot_Jz4nwZAE9pkPWQSExXl65L")]
        public static string __slot_Jz4nwZAE9pkPWQSExXl65L = "// PearsonCorrelation\r\nfloat ${signature} (float${Domain} a, float${Domain} b)\r\n{\r\n\tfloat meanOne = 0.;\r\n\tfloat meanTwo = 0.;\r\n\tfor(int i = 0; i < ${Domain}; i++)\r\n    {\r\n        meanOne += a[i];\r\n        meanTwo += b[i];\r\n    }\r\n    meanOne /= ${Domain};\r\n    meanTwo /= ${Domain};\r\n    \r\n    float covariance = 0;\r\n    float standardDeviationOne = 0;\r\n    float standardDeviationTwo = 0;\r\n    for(int i = 0; i < ${Domain}; i++)\r\n    {\r\n        covariance += ((a[i] - meanOne) * (b[i] - meanTwo));\r\n        standardDeviationOne += ((a[i] - meanOne) * (a[i] - meanOne));\r\n        standardDeviationTwo += ((b[i] - meanTwo) * (b[i] - meanTwo));\r\n    }\r\n    return max(0, 1 - (covariance / sqrt(standardDeviationOne * standardDeviationTwo)));\r\n}";
        static DistanceMetrics_UQq752M7mXvPeGKxenzyF4()
        {
        }

        public DistanceMetrics_UQq752M7mXvPeGKxenzyF4(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DistanceMetrics_UQq752M7mXvPeGKxenzyF4(DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> other): base(other)
        {
            this.__cache_EmPGSIwgieAMj97jKdmEp7 = other.__cache_EmPGSIwgieAMj97jKdmEp7;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_EmPGSIwgieAMj97jKdmEp7", in __cache_EmPGSIwgieAMj97jKdmEp7));
        }

        internal DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n6.DistanceMetricsSelector, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<float>>> __cache_EmPGSIwgieAMj97jKdmEp7)
        {
            n3.DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_EmPGSIwgieAMj97jKdmEp7 != this.__cache_EmPGSIwgieAMj97jKdmEp7 ? new DistanceMetrics_UQq752M7mXvPeGKxenzyF4<T>(this)
                {__cache_EmPGSIwgieAMj97jKdmEp7 = __cache_EmPGSIwgieAMj97jKdmEp7} : that_0;
            else
            {
                this.__cache_EmPGSIwgieAMj97jKdmEp7 = __cache_EmPGSIwgieAMj97jKdmEp7;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "IeSmvYiYUP2OknFeiEnByM", Name = "__IeSmvYiYUP2OknFeiEnByM")]
        [n2.SerializableAttribute]
        public class __IeSmvYiYUP2OknFeiEnByM : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_NFm2yHDfRZWPi15UFthUdL);
                n1.CompilationHelper.SafeDispose(this.__p_K69rI8ulmYiLgvFj0q7bSl);
                n1.CompilationHelper.SafeDispose(this.__p_DhTWPlCfhOSOewlPVInsqG);
                return;
            }

            [n1.ElementAttribute(TracingId = 343130U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "NFm2yHDfRZWPi15UFthUdL", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n8.IEnumerable<n5.InputModifier>> __p_NFm2yHDfRZWPi15UFthUdL;
            [n1.ElementAttribute(TracingId = 343465U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "K69rI8ulmYiLgvFj0q7bSl", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n8.IEnumerable<n5.InputModifier>> __p_K69rI8ulmYiLgvFj0q7bSl;
            [n1.ElementAttribute(TracingId = 343612U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "DhTWPlCfhOSOewlPVInsqG", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_DhTWPlCfhOSOewlPVInsqG;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<string> __pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW = default(n11.Spread<string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n15.ImmutableDictionary<string, string> __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ = default(n15.ImmutableDictionary<string, string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL = default(n11.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl = default(n11.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(TracingId = 343283U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "BUqd6hpvKuBMExvJWcQSJq", Name = "__slot_BUqd6hpvKuBMExvJWcQSJq")]
            public bool __slot_BUqd6hpvKuBMExvJWcQSJq;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR = default(n11.Spread<n5.GpuValue<float>>);
            public __IeSmvYiYUP2OknFeiEnByM(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __IeSmvYiYUP2OknFeiEnByM(__IeSmvYiYUP2OknFeiEnByM other): base(other)
            {
                this.__p_NFm2yHDfRZWPi15UFthUdL = other.__p_NFm2yHDfRZWPi15UFthUdL;
                this.__p_K69rI8ulmYiLgvFj0q7bSl = other.__p_K69rI8ulmYiLgvFj0q7bSl;
                this.__p_DhTWPlCfhOSOewlPVInsqG = other.__p_DhTWPlCfhOSOewlPVInsqG;
                this.__pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW = other.__pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW;
                this.__pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ = other.__pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ;
                this.__pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL = other.__pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL;
                this.__pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl = other.__pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl;
                this.__slot_BUqd6hpvKuBMExvJWcQSJq = other.__slot_BUqd6hpvKuBMExvJWcQSJq;
                this.__pin_group_Input_In_PriaxeBN4yrON53uK0KzdR = other.__pin_group_Input_In_PriaxeBN4yrON53uK0KzdR;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NFm2yHDfRZWPi15UFthUdL", in __p_NFm2yHDfRZWPi15UFthUdL), n1.CompilationHelper.GetValueOrExisting(values, "__p_K69rI8ulmYiLgvFj0q7bSl", in __p_K69rI8ulmYiLgvFj0q7bSl), n1.CompilationHelper.GetValueOrExisting(values, "__p_DhTWPlCfhOSOewlPVInsqG", in __p_DhTWPlCfhOSOewlPVInsqG), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW", in __pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ", in __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL", in __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl", in __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl), n1.CompilationHelper.GetValueOrExisting(values, "__slot_BUqd6hpvKuBMExvJWcQSJq", in __slot_BUqd6hpvKuBMExvJWcQSJq), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_PriaxeBN4yrON53uK0KzdR", in __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR));
            }

            internal __IeSmvYiYUP2OknFeiEnByM __WITH__(n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n8.IEnumerable<n5.InputModifier>> __p_NFm2yHDfRZWPi15UFthUdL, n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n8.IEnumerable<n5.InputModifier>> __p_K69rI8ulmYiLgvFj0q7bSl, n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_DhTWPlCfhOSOewlPVInsqG, n11.Spread<string> __pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW, n15.ImmutableDictionary<string, string> __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ, n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL, n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl, bool __slot_BUqd6hpvKuBMExvJWcQSJq, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR)
            {
                __IeSmvYiYUP2OknFeiEnByM that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_NFm2yHDfRZWPi15UFthUdL != this.__p_NFm2yHDfRZWPi15UFthUdL || __p_K69rI8ulmYiLgvFj0q7bSl != this.__p_K69rI8ulmYiLgvFj0q7bSl || __p_DhTWPlCfhOSOewlPVInsqG != this.__p_DhTWPlCfhOSOewlPVInsqG || __pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW != this.__pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW || __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ != this.__pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ || __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL != this.__pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL || __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl != this.__pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl || __slot_BUqd6hpvKuBMExvJWcQSJq != this.__slot_BUqd6hpvKuBMExvJWcQSJq || __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR != this.__pin_group_Input_In_PriaxeBN4yrON53uK0KzdR ? new __IeSmvYiYUP2OknFeiEnByM(this)
                    {__p_NFm2yHDfRZWPi15UFthUdL = __p_NFm2yHDfRZWPi15UFthUdL, __p_K69rI8ulmYiLgvFj0q7bSl = __p_K69rI8ulmYiLgvFj0q7bSl, __p_DhTWPlCfhOSOewlPVInsqG = __p_DhTWPlCfhOSOewlPVInsqG, __pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW = __pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW, __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ = __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ, __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL = __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL, __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl = __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl, __slot_BUqd6hpvKuBMExvJWcQSJq = __slot_BUqd6hpvKuBMExvJWcQSJq, __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR = __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR} : that_0;
                else
                {
                    this.__p_NFm2yHDfRZWPi15UFthUdL = __p_NFm2yHDfRZWPi15UFthUdL;
                    this.__p_K69rI8ulmYiLgvFj0q7bSl = __p_K69rI8ulmYiLgvFj0q7bSl;
                    this.__p_DhTWPlCfhOSOewlPVInsqG = __p_DhTWPlCfhOSOewlPVInsqG;
                    this.__pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW = __pin_group_Input_In_EAYwUeJ3vm6O4CcMIO0MFW;
                    this.__pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ = __pin_group_Input_In_U5kg9lilM3uOD8TJZAlrbZ;
                    this.__pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL = __pin_group_Arguments_In_NFm2yHDfRZWPi15UFthUdL;
                    this.__pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl = __pin_group_Arguments_In_K69rI8ulmYiLgvFj0q7bSl;
                    this.__slot_BUqd6hpvKuBMExvJWcQSJq = __slot_BUqd6hpvKuBMExvJWcQSJq;
                    this.__pin_group_Input_In_PriaxeBN4yrON53uK0KzdR = __pin_group_Input_In_PriaxeBN4yrON53uK0KzdR;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 353992U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Sp9cvZOHeSnMhksxfbEtWt", Name = "DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt")]
    [n2.SerializableAttribute]
    public class DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T> CreateDefault()
        {
            var instance = new DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T> Update(n5.GpuValue<T> TDomain_In, n5.GpuValue<T> Distortion_Function_In, n5.GpuValue<T> Strength_In, out n5.GpuValue<T> Output_Out, out n5.GpuValue<T> Distortion_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_SEpXNPtV9eFMgtmrvrNVK8;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>>>((default(n5.GpuValue<T>), default(n5.GpuValue<T>)));
            }

            var inputs_3 = (TDomain_In, Distortion_Function_In, Strength_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__MrSOZ9ZKWhMM2KxZCa0xWm>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __MrSOZ9ZKWhMM2KxZCa0xWm(__GetContext__(), n1.VLObject.NewIdentity())
                    {__slot_Af6JTa96FyXOnlXbiGH2BM = default(n5.GpuValue<T>), __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro = n17._Operations_.CreateDefault<n5.AbstractGpuValue>(), __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo = n17._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2 = n17._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "EUvROn4QMIHOGiNhMQWfC2", 354008U);
                    var Output_8 = n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_EUvROn4QMIHOGiNhMQWfC2 = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "A9BLZt7MF9DPZBYhLXEwcL", 354012U);
                    var Output_10 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_A9BLZt7MF9DPZBYhLXEwcL = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "BWp3w1Elr0JL105qDXh0Ro", 354016U);
                    var Output_12 = n21.Invoke_C<T>.Create(Node_Context: Node_Context_11);
                    state_6.__p_BWp3w1Elr0JL105qDXh0Ro = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "UUmSw4VijKWOu49aIW7iKo", 354023U);
                    var Output_14 = n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_13);
                    state_6.__p_UUmSw4VijKWOu49aIW7iKo = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "OfhyyZPikzbLpUKrSby1dx", 354029U);
                    var Output_16 = n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<T>.Create(Node_Context: Node_Context_15);
                    state_6.__p_OfhyyZPikzbLpUKrSby1dx = Output_16;
                }

                int Id_17 = 0;
                var State_Output_19 = state_6.__p_A9BLZt7MF9DPZBYhLXEwcL.Update(The_Override_In: TDomain_In, Id_In: Id_17, Output_Out: out n5.GpuValue<T> Output_18);
                n5.GpuValue<T> __pad_Af6JTa96FyXOnlXbiGH2BM_20 = Output_18;
                var builder_21 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro, 1);
                builder_21.Add(__pad_Af6JTa96FyXOnlXbiGH2BM_20);
                var __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro_22 = builder_21.Commit();
                var State_Output_24 = state_6.__p_BWp3w1Elr0JL105qDXh0Ro.Update(Function_In: Distortion_Function_In, Parameters_In: __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro_22, Output_Out: out n5.GpuValue<T> Output_23);
                float The_Value_25 = 1F;
                var State_Output_27 = state_6.__p_OfhyyZPikzbLpUKrSby1dx.Update(GpuValue_In: Strength_In, The_Value_In: The_Value_25, Output_Out: out n5.GpuValue<T> Output_26);
                var builder_28 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo, 2);
                builder_28.Add(Output_23);
                builder_28.Add(Output_26);
                var __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo_29 = builder_28.Commit();
                var State_Output_31 = state_6.__p_UUmSw4VijKWOu49aIW7iKo.Update(Input_In: __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo_29, Output_Out: out n5.GpuValue<T> Output_30);
                var builder_32 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2, 2);
                builder_32.Add(__pad_Af6JTa96FyXOnlXbiGH2BM_20);
                builder_32.Add(Output_30);
                var __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2_33 = builder_32.Commit();
                var State_Output_35 = state_6.__p_EUvROn4QMIHOGiNhMQWfC2.Update(Input_In: __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2_33, Output_Out: out n5.GpuValue<T> Output_34);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_19 != state_6.__p_A9BLZt7MF9DPZBYhLXEwcL || Output_18 != state_6.__slot_Af6JTa96FyXOnlXbiGH2BM || __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro_22 != state_6.__pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro || State_Output_24 != state_6.__p_BWp3w1Elr0JL105qDXh0Ro || State_Output_27 != state_6.__p_OfhyyZPikzbLpUKrSby1dx || __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo_29 != state_6.__pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo || State_Output_31 != state_6.__p_UUmSw4VijKWOu49aIW7iKo || __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2_33 != state_6.__pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2 || State_Output_35 != state_6.__p_EUvROn4QMIHOGiNhMQWfC2 ? new __MrSOZ9ZKWhMM2KxZCa0xWm(state_6)
                    {__p_A9BLZt7MF9DPZBYhLXEwcL = State_Output_19, __slot_Af6JTa96FyXOnlXbiGH2BM = Output_18, __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro = __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro_22, __p_BWp3w1Elr0JL105qDXh0Ro = State_Output_24, __p_OfhyyZPikzbLpUKrSby1dx = State_Output_27, __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo = __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo_29, __p_UUmSw4VijKWOu49aIW7iKo = State_Output_31, __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2 = __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2_33, __p_EUvROn4QMIHOGiNhMQWfC2 = State_Output_35} : state_6;
                else
                {
                    state_6.__p_A9BLZt7MF9DPZBYhLXEwcL = State_Output_19;
                    state_6.__slot_Af6JTa96FyXOnlXbiGH2BM = Output_18;
                    state_6.__pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro = __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro_22;
                    state_6.__p_BWp3w1Elr0JL105qDXh0Ro = State_Output_24;
                    state_6.__p_OfhyyZPikzbLpUKrSby1dx = State_Output_27;
                    state_6.__pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo = __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo_29;
                    state_6.__p_UUmSw4VijKWOu49aIW7iKo = State_Output_31;
                    state_6.__pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2 = __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2_33;
                    state_6.__p_EUvROn4QMIHOGiNhMQWfC2 = State_Output_35;
                }

                outputs_4 = (Output_34, Output_30);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_36, __auto_37) = outputs_4;
            Output_Out = __auto_36;
            Distortion_Out = __auto_37;
            n3.DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T> that_38 = this;
            if (this.__GetContext__().IsImmutable)
                that_38 = manager_2 != this.__cache_SEpXNPtV9eFMgtmrvrNVK8 ? new DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T>(this)
                {__cache_SEpXNPtV9eFMgtmrvrNVK8 = manager_2} : that_38;
            else
            {
                this.__cache_SEpXNPtV9eFMgtmrvrNVK8 = manager_2;
            }

            return that_38;
        }

        public n3.DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T> __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T> that_0 = this;
            this.__cache_SEpXNPtV9eFMgtmrvrNVK8 = null;
            return that_0;
        }

        public n3.DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T> __CreateDefault__()
        {
            n3.DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T> that_0 = this;
            this.__cache_SEpXNPtV9eFMgtmrvrNVK8 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_SEpXNPtV9eFMgtmrvrNVK8);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 353995U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "SEpXNPtV9eFMgtmrvrNVK8", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>>> __cache_SEpXNPtV9eFMgtmrvrNVK8 = null;
        public DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt(DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T> other): base(other)
        {
            this.__cache_SEpXNPtV9eFMgtmrvrNVK8 = other.__cache_SEpXNPtV9eFMgtmrvrNVK8;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_SEpXNPtV9eFMgtmrvrNVK8", in __cache_SEpXNPtV9eFMgtmrvrNVK8));
        }

        internal DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T> __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>>> __cache_SEpXNPtV9eFMgtmrvrNVK8)
        {
            n3.DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_SEpXNPtV9eFMgtmrvrNVK8 != this.__cache_SEpXNPtV9eFMgtmrvrNVK8 ? new DomainDistortion_Sp9cvZOHeSnMhksxfbEtWt<T>(this)
                {__cache_SEpXNPtV9eFMgtmrvrNVK8 = __cache_SEpXNPtV9eFMgtmrvrNVK8} : that_0;
            else
            {
                this.__cache_SEpXNPtV9eFMgtmrvrNVK8 = __cache_SEpXNPtV9eFMgtmrvrNVK8;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "MrSOZ9ZKWhMM2KxZCa0xWm", Name = "__MrSOZ9ZKWhMM2KxZCa0xWm")]
        [n2.SerializableAttribute]
        public class __MrSOZ9ZKWhMM2KxZCa0xWm : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_EUvROn4QMIHOGiNhMQWfC2);
                n1.CompilationHelper.SafeDispose(this.__p_A9BLZt7MF9DPZBYhLXEwcL);
                n1.CompilationHelper.SafeDispose(this.__p_BWp3w1Elr0JL105qDXh0Ro);
                n1.CompilationHelper.SafeDispose(this.__p_UUmSw4VijKWOu49aIW7iKo);
                n1.CompilationHelper.SafeDispose(this.__p_OfhyyZPikzbLpUKrSby1dx);
                return;
            }

            [n1.ElementAttribute(TracingId = 354008U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "EUvROn4QMIHOGiNhMQWfC2", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_EUvROn4QMIHOGiNhMQWfC2;
            [n1.ElementAttribute(TracingId = 354012U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "A9BLZt7MF9DPZBYhLXEwcL", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T> __p_A9BLZt7MF9DPZBYhLXEwcL;
            [n1.ElementAttribute(TracingId = 354016U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "BWp3w1Elr0JL105qDXh0Ro", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n21.Invoke_C<T> __p_BWp3w1Elr0JL105qDXh0Ro;
            [n1.ElementAttribute(TracingId = 354023U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "UUmSw4VijKWOu49aIW7iKo", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_UUmSw4VijKWOu49aIW7iKo;
            [n1.ElementAttribute(TracingId = 354029U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "OfhyyZPikzbLpUKrSby1dx", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<T> __p_OfhyyZPikzbLpUKrSby1dx;
            [n1.ElementAttribute(TracingId = 354007U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Af6JTa96FyXOnlXbiGH2BM", Name = "__slot_Af6JTa96FyXOnlXbiGH2BM")]
            public n5.GpuValue<T> __slot_Af6JTa96FyXOnlXbiGH2BM;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro = default(n11.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<T>> __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo = default(n11.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<T>> __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2 = default(n11.Spread<n5.GpuValue<T>>);
            public __MrSOZ9ZKWhMM2KxZCa0xWm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MrSOZ9ZKWhMM2KxZCa0xWm(__MrSOZ9ZKWhMM2KxZCa0xWm other): base(other)
            {
                this.__p_EUvROn4QMIHOGiNhMQWfC2 = other.__p_EUvROn4QMIHOGiNhMQWfC2;
                this.__p_A9BLZt7MF9DPZBYhLXEwcL = other.__p_A9BLZt7MF9DPZBYhLXEwcL;
                this.__p_BWp3w1Elr0JL105qDXh0Ro = other.__p_BWp3w1Elr0JL105qDXh0Ro;
                this.__p_UUmSw4VijKWOu49aIW7iKo = other.__p_UUmSw4VijKWOu49aIW7iKo;
                this.__p_OfhyyZPikzbLpUKrSby1dx = other.__p_OfhyyZPikzbLpUKrSby1dx;
                this.__slot_Af6JTa96FyXOnlXbiGH2BM = other.__slot_Af6JTa96FyXOnlXbiGH2BM;
                this.__pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro = other.__pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro;
                this.__pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo = other.__pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo;
                this.__pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2 = other.__pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_EUvROn4QMIHOGiNhMQWfC2", in __p_EUvROn4QMIHOGiNhMQWfC2), n1.CompilationHelper.GetValueOrExisting(values, "__p_A9BLZt7MF9DPZBYhLXEwcL", in __p_A9BLZt7MF9DPZBYhLXEwcL), n1.CompilationHelper.GetValueOrExisting(values, "__p_BWp3w1Elr0JL105qDXh0Ro", in __p_BWp3w1Elr0JL105qDXh0Ro), n1.CompilationHelper.GetValueOrExisting(values, "__p_UUmSw4VijKWOu49aIW7iKo", in __p_UUmSw4VijKWOu49aIW7iKo), n1.CompilationHelper.GetValueOrExisting(values, "__p_OfhyyZPikzbLpUKrSby1dx", in __p_OfhyyZPikzbLpUKrSby1dx), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Af6JTa96FyXOnlXbiGH2BM", in __slot_Af6JTa96FyXOnlXbiGH2BM), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro", in __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo", in __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2", in __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2));
            }

            internal __MrSOZ9ZKWhMM2KxZCa0xWm __WITH__(n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_EUvROn4QMIHOGiNhMQWfC2, n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T> __p_A9BLZt7MF9DPZBYhLXEwcL, n21.Invoke_C<T> __p_BWp3w1Elr0JL105qDXh0Ro, n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_UUmSw4VijKWOu49aIW7iKo, n10.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<T> __p_OfhyyZPikzbLpUKrSby1dx, n5.GpuValue<T> __slot_Af6JTa96FyXOnlXbiGH2BM, n11.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro, n11.Spread<n5.GpuValue<T>> __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo, n11.Spread<n5.GpuValue<T>> __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2)
            {
                __MrSOZ9ZKWhMM2KxZCa0xWm that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_EUvROn4QMIHOGiNhMQWfC2 != this.__p_EUvROn4QMIHOGiNhMQWfC2 || __p_A9BLZt7MF9DPZBYhLXEwcL != this.__p_A9BLZt7MF9DPZBYhLXEwcL || __p_BWp3w1Elr0JL105qDXh0Ro != this.__p_BWp3w1Elr0JL105qDXh0Ro || __p_UUmSw4VijKWOu49aIW7iKo != this.__p_UUmSw4VijKWOu49aIW7iKo || __p_OfhyyZPikzbLpUKrSby1dx != this.__p_OfhyyZPikzbLpUKrSby1dx || __slot_Af6JTa96FyXOnlXbiGH2BM != this.__slot_Af6JTa96FyXOnlXbiGH2BM || __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro != this.__pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro || __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo != this.__pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo || __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2 != this.__pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2 ? new __MrSOZ9ZKWhMM2KxZCa0xWm(this)
                    {__p_EUvROn4QMIHOGiNhMQWfC2 = __p_EUvROn4QMIHOGiNhMQWfC2, __p_A9BLZt7MF9DPZBYhLXEwcL = __p_A9BLZt7MF9DPZBYhLXEwcL, __p_BWp3w1Elr0JL105qDXh0Ro = __p_BWp3w1Elr0JL105qDXh0Ro, __p_UUmSw4VijKWOu49aIW7iKo = __p_UUmSw4VijKWOu49aIW7iKo, __p_OfhyyZPikzbLpUKrSby1dx = __p_OfhyyZPikzbLpUKrSby1dx, __slot_Af6JTa96FyXOnlXbiGH2BM = __slot_Af6JTa96FyXOnlXbiGH2BM, __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro = __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro, __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo = __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo, __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2 = __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2} : that_0;
                else
                {
                    this.__p_EUvROn4QMIHOGiNhMQWfC2 = __p_EUvROn4QMIHOGiNhMQWfC2;
                    this.__p_A9BLZt7MF9DPZBYhLXEwcL = __p_A9BLZt7MF9DPZBYhLXEwcL;
                    this.__p_BWp3w1Elr0JL105qDXh0Ro = __p_BWp3w1Elr0JL105qDXh0Ro;
                    this.__p_UUmSw4VijKWOu49aIW7iKo = __p_UUmSw4VijKWOu49aIW7iKo;
                    this.__p_OfhyyZPikzbLpUKrSby1dx = __p_OfhyyZPikzbLpUKrSby1dx;
                    this.__slot_Af6JTa96FyXOnlXbiGH2BM = __slot_Af6JTa96FyXOnlXbiGH2BM;
                    this.__pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro = __pin_group_Parameters_In_BWp3w1Elr0JL105qDXh0Ro;
                    this.__pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo = __pin_group_Input_In_UUmSw4VijKWOu49aIW7iKo;
                    this.__pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2 = __pin_group_Input_In_EUvROn4QMIHOGiNhMQWfC2;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 354967U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "QrFiM976RTjO0T5TIgTzKu", Name = "ToBoxSpace_QrFiM976RTjO0T5TIgTzKu")]
    [n2.SerializableAttribute]
    public class ToBoxSpace_QrFiM976RTjO0T5TIgTzKu : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ToBoxSpace_QrFiM976RTjO0T5TIgTzKu Create(n1.NodeContext Node_Context)
        {
            var instance = new ToBoxSpace_QrFiM976RTjO0T5TIgTzKu(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ToBoxSpace_QrFiM976RTjO0T5TIgTzKu CreateDefault()
        {
            var instance = new ToBoxSpace_QrFiM976RTjO0T5TIgTzKu(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ToBoxSpace_QrFiM976RTjO0T5TIgTzKu Update(n5.GpuValue<n22.Vector3> Sampling_Position_In, n22.Matrix Box_Transformation_In, bool Flip_Y_Coord_In, n22.Color4 Helper_Frame_Color_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Helper_Enabled_In, out n5.GpuValue<n22.Vector3> Local_Coordinates_Out, out n5.GpuValue<n22.Vector3> UVW_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_VnlVnb6arpAO5lvPyIBaNR;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<bool, n5.GpuValue<n22.Vector3>, n22.Matrix>, n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<n22.Vector3>>>((default(n5.GpuValue<n22.Vector3>), default(n5.GpuValue<n22.Vector3>)));
            }

            var inputs_3 = (Flip_Y_Coord_In, Sampling_Position_In, Box_Transformation_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__IoD3tAvHvlWNhT9xbPONAf>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __IoD3tAvHvlWNhT9xbPONAf(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U = n17._Operations_.CreateDefault<n5.GpuValue<n22.Vector3>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "OopDz1wEJ4MO6wxg5zyWwa", 355024U);
                    var Output_8 = n23.Transform_Position_LKcWfuVut0bQKh3TzuaW0w.Create(Node_Context: Node_Context_7);
                    state_6.__p_OopDz1wEJ4MO6wxg5zyWwa = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "F5hAH5RxiOuLokCAaDyI4U", 355041U);
                    var Output_10 = n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n22.Vector3>.Create(Node_Context: Node_Context_9);
                    state_6.__p_F5hAH5RxiOuLokCAaDyI4U = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "NoGGiFiqRu1L7xpWOmg0WU", 355066U);
                    var Output_12 = n20.HALF_Ul2Y1lSFl6WN0sQ1DLnAcN<n22.Vector3>.Create(Node_Context: Node_Context_11);
                    state_6.__p_NoGGiFiqRu1L7xpWOmg0WU = Output_12;
                }

                n22.Matrix.Invert(value: ref Box_Transformation_In, result: out n22.Matrix Output_13);
                n5.GpuValue<n22.Matrix> Input_14 = state_6.__monadBuilder_NvQYBr3waAPOn5egwIcMa3.Return(Output_13);
                var Output_16 = state_6.__p_OopDz1wEJ4MO6wxg5zyWwa.Update(xyz_In: Sampling_Position_In, Input_In: Input_14, xyz_Out: out n5.GpuValue<n22.Vector3> xyz_15);
                n5.GpuValue<n22.Vector3> __auto_17;
                var state_18 = n1.CompilationHelper.Restore<__NxWDecMQhxiO0vdRHQAg84>(state_6.__if_SFuBAkgxdaNLmOxm0YFWYD, __GetContext__());
                if (Flip_Y_Coord_In)
                {
                    if (state_18 == null)
                    {
                        state_18 = new __NxWDecMQhxiO0vdRHQAg84(__GetContext__(), n1.VLObject.NewIdentity())
                        {__pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm = n17._Operations_.CreateDefault<n5.GpuValue<n22.Vector3>>()};
                        n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "TwFPw2SOwIsNXodQdtNWQm", 355081U);
                        var Output_20 = n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n22.Vector3>.Create(Node_Context: Node_Context_19);
                        state_18.__p_TwFPw2SOwIsNXodQdtNWQm = Output_20;
                        n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Qfpn9kjLOYtPm1RuAnQMpa", 355108U);
                        var Output_22 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n22.Vector3>.Create(Node_Context: Node_Context_21);
                        state_18.__p_Qfpn9kjLOYtPm1RuAnQMpa = Output_22;
                    }

                    n22.Vector3 __pad_J3oSXCmZ2WGPAn0N1GtiOw_23 = __slot_J3oSXCmZ2WGPAn0N1GtiOw;
                    var Output_25 = state_18.__p_Qfpn9kjLOYtPm1RuAnQMpa.Update(Value_In: __pad_J3oSXCmZ2WGPAn0N1GtiOw_23, GpuValue_Out: out n5.GpuValue<n22.Vector3> GpuValue_24);
                    var builder_26 = n4.CollectionBuilders.GetBuilder(state_18.__pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm, 2);
                    builder_26.Add(xyz_15);
                    builder_26.Add(GpuValue_24);
                    var __pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm_27 = builder_26.Commit();
                    var State_Output_29 = state_18.__p_TwFPw2SOwIsNXodQdtNWQm.Update(Input_In: __pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm_27, Output_Out: out n5.GpuValue<n22.Vector3> Output_28);
                    __auto_17 = Output_28;
                    if (state_18.__GetContext__().IsImmutable)
                        state_18 = Output_25 != state_18.__p_Qfpn9kjLOYtPm1RuAnQMpa || __pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm_27 != state_18.__pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm || State_Output_29 != state_18.__p_TwFPw2SOwIsNXodQdtNWQm ? new __NxWDecMQhxiO0vdRHQAg84(state_18)
                        {__p_Qfpn9kjLOYtPm1RuAnQMpa = Output_25, __pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm = __pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm_27, __p_TwFPw2SOwIsNXodQdtNWQm = State_Output_29} : state_18;
                    else
                    {
                        state_18.__p_Qfpn9kjLOYtPm1RuAnQMpa = Output_25;
                        state_18.__pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm = __pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm_27;
                        state_18.__p_TwFPw2SOwIsNXodQdtNWQm = State_Output_29;
                    }
                }
                else
                {
                    __auto_17 = xyz_15;
                }

                var State_Output_31 = state_6.__p_NoGGiFiqRu1L7xpWOmg0WU.Update(Output_Out: out n5.GpuValue<n22.Vector3> Output_30);
                var builder_32 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U, 2);
                builder_32.Add(__auto_17);
                builder_32.Add(Output_30);
                var __pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U_33 = builder_32.Commit();
                var State_Output_35 = state_6.__p_F5hAH5RxiOuLokCAaDyI4U.Update(Input_In: __pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U_33, Output_Out: out n5.GpuValue<n22.Vector3> Output_34);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = Output_16 != state_6.__p_OopDz1wEJ4MO6wxg5zyWwa || state_18 != state_6.__if_SFuBAkgxdaNLmOxm0YFWYD || State_Output_31 != state_6.__p_NoGGiFiqRu1L7xpWOmg0WU || __pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U_33 != state_6.__pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U || State_Output_35 != state_6.__p_F5hAH5RxiOuLokCAaDyI4U ? new __IoD3tAvHvlWNhT9xbPONAf(state_6)
                    {__p_OopDz1wEJ4MO6wxg5zyWwa = Output_16, __if_SFuBAkgxdaNLmOxm0YFWYD = state_18, __p_NoGGiFiqRu1L7xpWOmg0WU = State_Output_31, __pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U = __pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U_33, __p_F5hAH5RxiOuLokCAaDyI4U = State_Output_35} : state_6;
                else
                {
                    state_6.__p_OopDz1wEJ4MO6wxg5zyWwa = Output_16;
                    state_6.__if_SFuBAkgxdaNLmOxm0YFWYD = state_18;
                    state_6.__p_NoGGiFiqRu1L7xpWOmg0WU = State_Output_31;
                    state_6.__pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U = __pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U_33;
                    state_6.__p_F5hAH5RxiOuLokCAaDyI4U = State_Output_35;
                }

                outputs_4 = (__auto_17, Output_34);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_36, __auto_37) = outputs_4;
            bool Force_38 = false;
            bool Dispose_Cached_Outputs_39 = false;
            var manager_40 = this.__cache_NHArrRm2DFzOLBj3YfTERD;
            if (manager_40 is null)
            {
                manager_40 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n22.Matrix, n22.Color4, bool>, n2.ValueTuple>(n2.ValueTuple.Create());
            }

            var inputs_41 = (__auto_36, Box_Transformation_In, Helper_Frame_Color_In, Helper_Enabled_In);
            var outputs_42 = manager_40.Outputs;
            var Has_Changed_43 = Force_38 || manager_40.InputsChanged(inputs_41);
            if (Has_Changed_43)
            {
                if (Dispose_Cached_Outputs_39)
                    manager_40.DisposeOutputs();
                var state_44 = n1.CompilationHelper.Restore<__HO907v8v5VpLJOAkzyqmHY>(manager_40.State, __GetContext__());
                if (state_44 == null)
                {
                    state_44 = new __HO907v8v5VpLJOAkzyqmHY(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF = n17._Operations_.CreateDefault<n27.Entity>()};
                    n1.NodeContext Node_Context_45 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "BZoYx81VeiwNtqb7RvTp3W", 355219U);
                    var Output_46 = n10.SetHelper_UGmgQrN7WeaQQX157aMEvr.Create(Node_Context: Node_Context_45);
                    state_44.__p_BZoYx81VeiwNtqb7RvTp3W = Output_46;
                    n1.NodeContext Node_Context_47 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "IaRQS7c4ab6PXtyUTYKpe3", 355242U);
                    var Output_48 = n25.BoxFrame_MdfNJXLlOjzMB5Tg5Xcmlc.Create(Node_Context: Node_Context_47);
                    state_44.__p_IaRQS7c4ab6PXtyUTYKpe3 = Output_48;
                    n1.NodeContext Node_Context_49 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "TSxqR1Lp53IORLqmGdjhYF", 355291U);
                    var Output_50 = n26.Group_TqwCZl6Gra4OmgvUg1POgm.Create(Node_Context: Node_Context_49);
                    state_44.__p_TSxqR1Lp53IORLqmGdjhYF = Output_50;
                    n1.NodeContext Node_Context_51 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "HB77kUurV7kPk9iBD10B6b", 355330U);
                    var Output_52 = n10.SetHelper_UGmgQrN7WeaQQX157aMEvr.Create(Node_Context: Node_Context_51);
                    state_44.__p_HB77kUurV7kPk9iBD10B6b = Output_52;
                }

                bool Update_53 = true;
                var Output_54 = state_44.__p_BZoYx81VeiwNtqb7RvTp3W;
                if (Update_53)
                {
                    Output_54 = state_44.__p_BZoYx81VeiwNtqb7RvTp3W.Update(Input_In: __auto_36);
                }

                bool Draw_Shadow_55 = false;
                var State_Output_57 = state_44.__p_IaRQS7c4ab6PXtyUTYKpe3.Update(Transformation_In: Box_Transformation_In, Color_In: Helper_Frame_Color_In, Draw_Shadow_In: Draw_Shadow_55, Enabled_In: Helper_Enabled_In, Output_Out: out n27.Entity Output_56);
                n27.Entity Child_58 = default(n27.Entity);
                bool SetChildren_59 = true;
                var builder_60 = n4.CollectionBuilders.GetBuilder(state_44.__pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF, 2);
                builder_60.Add(Child_58);
                builder_60.Add(Output_56);
                var __pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF_61 = builder_60.Commit();
                var Output_62 = state_44.__p_TSxqR1Lp53IORLqmGdjhYF;
                if (SetChildren_59)
                {
                    Output_62 = state_44.__p_TSxqR1Lp53IORLqmGdjhYF.SetChildren(Child_In: __pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF_61);
                }

                var State_Output_64 = Output_62.Update(Output_Out: out n27.Entity Output_63);
                bool SetEntity_65 = true;
                var Output_66 = Output_54;
                if (SetEntity_65)
                {
                    Output_66 = Output_54.SetEntity(Entity_In: Output_63);
                }

                bool SetEnabled_67 = true;
                var Output_68 = Output_66;
                if (SetEnabled_67)
                {
                    Output_68 = Output_66.SetEnabled(Enabled_In: Helper_Enabled_In);
                }

                bool Update_69 = true;
                var Output_70 = state_44.__p_HB77kUurV7kPk9iBD10B6b;
                if (Update_69)
                {
                    Output_70 = state_44.__p_HB77kUurV7kPk9iBD10B6b.Update(Input_In: __auto_37);
                }

                bool SetEntity_71 = true;
                var Output_72 = Output_70;
                if (SetEntity_71)
                {
                    Output_72 = Output_70.SetEntity(Entity_In: Output_63);
                }

                bool SetEnabled_73 = true;
                var Output_74 = Output_72;
                if (SetEnabled_73)
                {
                    Output_74 = Output_72.SetEnabled(Enabled_In: Helper_Enabled_In);
                }

                if (state_44.__GetContext__().IsImmutable)
                    state_44 = Output_68 != state_44.__p_BZoYx81VeiwNtqb7RvTp3W || State_Output_57 != state_44.__p_IaRQS7c4ab6PXtyUTYKpe3 || __pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF_61 != state_44.__pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF || State_Output_64 != state_44.__p_TSxqR1Lp53IORLqmGdjhYF || Output_74 != state_44.__p_HB77kUurV7kPk9iBD10B6b ? new __HO907v8v5VpLJOAkzyqmHY(state_44)
                    {__p_BZoYx81VeiwNtqb7RvTp3W = Output_68, __p_IaRQS7c4ab6PXtyUTYKpe3 = State_Output_57, __pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF = __pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF_61, __p_TSxqR1Lp53IORLqmGdjhYF = State_Output_64, __p_HB77kUurV7kPk9iBD10B6b = Output_74} : state_44;
                else
                {
                    state_44.__p_BZoYx81VeiwNtqb7RvTp3W = Output_68;
                    state_44.__p_IaRQS7c4ab6PXtyUTYKpe3 = State_Output_57;
                    state_44.__pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF = __pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF_61;
                    state_44.__p_TSxqR1Lp53IORLqmGdjhYF = State_Output_64;
                    state_44.__p_HB77kUurV7kPk9iBD10B6b = Output_74;
                }

                outputs_42 = n2.ValueTuple.Create();
                manager_40 = manager_40.Update(inputs_41, __GetContext__().IsImmutable, Dispose_Cached_Outputs_39, state_44, outputs_42);
            }
            else
            {
                manager_40.Update(inputs_41, __GetContext__().IsImmutable, Dispose_Cached_Outputs_39);
            }

            Local_Coordinates_Out = __auto_36;
            UVW_Out = __auto_37;
            n3.ToBoxSpace_QrFiM976RTjO0T5TIgTzKu that_75 = this;
            if (this.__GetContext__().IsImmutable)
                that_75 = manager_2 != this.__cache_VnlVnb6arpAO5lvPyIBaNR || manager_40 != this.__cache_NHArrRm2DFzOLBj3YfTERD ? new ToBoxSpace_QrFiM976RTjO0T5TIgTzKu(this)
                {__cache_VnlVnb6arpAO5lvPyIBaNR = manager_2, __cache_NHArrRm2DFzOLBj3YfTERD = manager_40} : that_75;
            else
            {
                this.__cache_VnlVnb6arpAO5lvPyIBaNR = manager_2;
                this.__cache_NHArrRm2DFzOLBj3YfTERD = manager_40;
            }

            return that_75;
        }

        public n3.ToBoxSpace_QrFiM976RTjO0T5TIgTzKu __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.ToBoxSpace_QrFiM976RTjO0T5TIgTzKu that_0 = this;
            this.__cache_VnlVnb6arpAO5lvPyIBaNR = null;
            this.__cache_NHArrRm2DFzOLBj3YfTERD = null;
            return that_0;
        }

        public n3.ToBoxSpace_QrFiM976RTjO0T5TIgTzKu __CreateDefault__()
        {
            n3.ToBoxSpace_QrFiM976RTjO0T5TIgTzKu that_0 = this;
            this.__cache_VnlVnb6arpAO5lvPyIBaNR = null;
            this.__cache_NHArrRm2DFzOLBj3YfTERD = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_VnlVnb6arpAO5lvPyIBaNR);
            n1.CompilationHelper.SafeDispose(this.__cache_NHArrRm2DFzOLBj3YfTERD);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 354982U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "VnlVnb6arpAO5lvPyIBaNR", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<bool, n5.GpuValue<n22.Vector3>, n22.Matrix>, n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<n22.Vector3>>> __cache_VnlVnb6arpAO5lvPyIBaNR = null;
        [n1.ElementAttribute(TracingId = 355096U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "J3oSXCmZ2WGPAn0N1GtiOw", Name = "__slot_J3oSXCmZ2WGPAn0N1GtiOw")]
        public static n22.Vector3 __slot_J3oSXCmZ2WGPAn0N1GtiOw = n1.CompilationHelper.Deserialize<n22.Vector3>("1, -1, 1", false, "MzilLTk6yNROg5SWTCtzZM", "J3oSXCmZ2WGPAn0N1GtiOw");
        [n1.ElementAttribute(TracingId = 355166U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "NHArrRm2DFzOLBj3YfTERD", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n22.Matrix, n22.Color4, bool>, n2.ValueTuple> __cache_NHArrRm2DFzOLBj3YfTERD = null;
        static ToBoxSpace_QrFiM976RTjO0T5TIgTzKu()
        {
        }

        public ToBoxSpace_QrFiM976RTjO0T5TIgTzKu(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ToBoxSpace_QrFiM976RTjO0T5TIgTzKu(ToBoxSpace_QrFiM976RTjO0T5TIgTzKu other): base(other)
        {
            this.__cache_VnlVnb6arpAO5lvPyIBaNR = other.__cache_VnlVnb6arpAO5lvPyIBaNR;
            this.__cache_NHArrRm2DFzOLBj3YfTERD = other.__cache_NHArrRm2DFzOLBj3YfTERD;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_VnlVnb6arpAO5lvPyIBaNR", in __cache_VnlVnb6arpAO5lvPyIBaNR), n1.CompilationHelper.GetValueOrExisting(values, "__cache_NHArrRm2DFzOLBj3YfTERD", in __cache_NHArrRm2DFzOLBj3YfTERD));
        }

        internal ToBoxSpace_QrFiM976RTjO0T5TIgTzKu __WITH__(n7.Manager<n2.ValueTuple<bool, n5.GpuValue<n22.Vector3>, n22.Matrix>, n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<n22.Vector3>>> __cache_VnlVnb6arpAO5lvPyIBaNR, n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n22.Matrix, n22.Color4, bool>, n2.ValueTuple> __cache_NHArrRm2DFzOLBj3YfTERD)
        {
            n3.ToBoxSpace_QrFiM976RTjO0T5TIgTzKu that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_VnlVnb6arpAO5lvPyIBaNR != this.__cache_VnlVnb6arpAO5lvPyIBaNR || __cache_NHArrRm2DFzOLBj3YfTERD != this.__cache_NHArrRm2DFzOLBj3YfTERD ? new ToBoxSpace_QrFiM976RTjO0T5TIgTzKu(this)
                {__cache_VnlVnb6arpAO5lvPyIBaNR = __cache_VnlVnb6arpAO5lvPyIBaNR, __cache_NHArrRm2DFzOLBj3YfTERD = __cache_NHArrRm2DFzOLBj3YfTERD} : that_0;
            else
            {
                this.__cache_VnlVnb6arpAO5lvPyIBaNR = __cache_VnlVnb6arpAO5lvPyIBaNR;
                this.__cache_NHArrRm2DFzOLBj3YfTERD = __cache_NHArrRm2DFzOLBj3YfTERD;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "IoD3tAvHvlWNhT9xbPONAf", Name = "__IoD3tAvHvlWNhT9xbPONAf")]
        [n2.SerializableAttribute]
        public class __IoD3tAvHvlWNhT9xbPONAf : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_OopDz1wEJ4MO6wxg5zyWwa);
                n1.CompilationHelper.SafeDispose(this.__p_F5hAH5RxiOuLokCAaDyI4U);
                n1.CompilationHelper.SafeDispose(this.__p_NoGGiFiqRu1L7xpWOmg0WU);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_NvQYBr3waAPOn5egwIcMa3);
                n1.CompilationHelper.SafeDispose(this.__if_SFuBAkgxdaNLmOxm0YFWYD);
                return;
            }

            [n1.ElementAttribute(TracingId = 355024U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "OopDz1wEJ4MO6wxg5zyWwa", Name = "Transform (Position)", IsManaged = true, IsAutoGenerated = true)]
            public n23.Transform_Position_LKcWfuVut0bQKh3TzuaW0w __p_OopDz1wEJ4MO6wxg5zyWwa;
            [n1.ElementAttribute(TracingId = 355041U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "F5hAH5RxiOuLokCAaDyI4U", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n22.Vector3> __p_F5hAH5RxiOuLokCAaDyI4U;
            [n1.ElementAttribute(TracingId = 355066U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "NoGGiFiqRu1L7xpWOmg0WU", Name = "HALF", IsManaged = true, IsAutoGenerated = true)]
            public n20.HALF_Ul2Y1lSFl6WN0sQ1DLnAcN<n22.Vector3> __p_NoGGiFiqRu1L7xpWOmg0WU;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<n22.Matrix, n5.GpuValue<n22.Matrix>> __monadBuilder_NvQYBr3waAPOn5egwIcMa3 = n5.GpuValueMonadicFactory<n22.Matrix>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_SFuBAkgxdaNLmOxm0YFWYD;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<n22.Vector3>> __pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U = default(n11.Spread<n5.GpuValue<n22.Vector3>>);
            public __IoD3tAvHvlWNhT9xbPONAf(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __IoD3tAvHvlWNhT9xbPONAf(__IoD3tAvHvlWNhT9xbPONAf other): base(other)
            {
                this.__p_OopDz1wEJ4MO6wxg5zyWwa = other.__p_OopDz1wEJ4MO6wxg5zyWwa;
                this.__p_F5hAH5RxiOuLokCAaDyI4U = other.__p_F5hAH5RxiOuLokCAaDyI4U;
                this.__p_NoGGiFiqRu1L7xpWOmg0WU = other.__p_NoGGiFiqRu1L7xpWOmg0WU;
                this.__monadBuilder_NvQYBr3waAPOn5egwIcMa3 = other.__monadBuilder_NvQYBr3waAPOn5egwIcMa3;
                this.__if_SFuBAkgxdaNLmOxm0YFWYD = other.__if_SFuBAkgxdaNLmOxm0YFWYD;
                this.__pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U = other.__pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_OopDz1wEJ4MO6wxg5zyWwa", in __p_OopDz1wEJ4MO6wxg5zyWwa), n1.CompilationHelper.GetValueOrExisting(values, "__p_F5hAH5RxiOuLokCAaDyI4U", in __p_F5hAH5RxiOuLokCAaDyI4U), n1.CompilationHelper.GetValueOrExisting(values, "__p_NoGGiFiqRu1L7xpWOmg0WU", in __p_NoGGiFiqRu1L7xpWOmg0WU), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_NvQYBr3waAPOn5egwIcMa3", in __monadBuilder_NvQYBr3waAPOn5egwIcMa3), n1.CompilationHelper.GetValueOrExisting(values, "__if_SFuBAkgxdaNLmOxm0YFWYD", in __if_SFuBAkgxdaNLmOxm0YFWYD), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U", in __pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U));
            }

            internal __IoD3tAvHvlWNhT9xbPONAf __WITH__(n23.Transform_Position_LKcWfuVut0bQKh3TzuaW0w __p_OopDz1wEJ4MO6wxg5zyWwa, n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n22.Vector3> __p_F5hAH5RxiOuLokCAaDyI4U, n20.HALF_Ul2Y1lSFl6WN0sQ1DLnAcN<n22.Vector3> __p_NoGGiFiqRu1L7xpWOmg0WU, n1.IMonadBuilder<n22.Matrix, n5.GpuValue<n22.Matrix>> __monadBuilder_NvQYBr3waAPOn5egwIcMa3, n2.Object __if_SFuBAkgxdaNLmOxm0YFWYD, n11.Spread<n5.GpuValue<n22.Vector3>> __pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U)
            {
                __IoD3tAvHvlWNhT9xbPONAf that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_OopDz1wEJ4MO6wxg5zyWwa != this.__p_OopDz1wEJ4MO6wxg5zyWwa || __p_F5hAH5RxiOuLokCAaDyI4U != this.__p_F5hAH5RxiOuLokCAaDyI4U || __p_NoGGiFiqRu1L7xpWOmg0WU != this.__p_NoGGiFiqRu1L7xpWOmg0WU || __monadBuilder_NvQYBr3waAPOn5egwIcMa3 != this.__monadBuilder_NvQYBr3waAPOn5egwIcMa3 || __if_SFuBAkgxdaNLmOxm0YFWYD != this.__if_SFuBAkgxdaNLmOxm0YFWYD || __pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U != this.__pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U ? new __IoD3tAvHvlWNhT9xbPONAf(this)
                    {__p_OopDz1wEJ4MO6wxg5zyWwa = __p_OopDz1wEJ4MO6wxg5zyWwa, __p_F5hAH5RxiOuLokCAaDyI4U = __p_F5hAH5RxiOuLokCAaDyI4U, __p_NoGGiFiqRu1L7xpWOmg0WU = __p_NoGGiFiqRu1L7xpWOmg0WU, __monadBuilder_NvQYBr3waAPOn5egwIcMa3 = __monadBuilder_NvQYBr3waAPOn5egwIcMa3, __if_SFuBAkgxdaNLmOxm0YFWYD = __if_SFuBAkgxdaNLmOxm0YFWYD, __pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U = __pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U} : that_0;
                else
                {
                    this.__p_OopDz1wEJ4MO6wxg5zyWwa = __p_OopDz1wEJ4MO6wxg5zyWwa;
                    this.__p_F5hAH5RxiOuLokCAaDyI4U = __p_F5hAH5RxiOuLokCAaDyI4U;
                    this.__p_NoGGiFiqRu1L7xpWOmg0WU = __p_NoGGiFiqRu1L7xpWOmg0WU;
                    this.__monadBuilder_NvQYBr3waAPOn5egwIcMa3 = __monadBuilder_NvQYBr3waAPOn5egwIcMa3;
                    this.__if_SFuBAkgxdaNLmOxm0YFWYD = __if_SFuBAkgxdaNLmOxm0YFWYD;
                    this.__pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U = __pin_group_Input_In_F5hAH5RxiOuLokCAaDyI4U;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "NxWDecMQhxiO0vdRHQAg84", Name = "__NxWDecMQhxiO0vdRHQAg84")]
        [n2.SerializableAttribute]
        public class __NxWDecMQhxiO0vdRHQAg84 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_TwFPw2SOwIsNXodQdtNWQm);
                n1.CompilationHelper.SafeDispose(this.__p_Qfpn9kjLOYtPm1RuAnQMpa);
                return;
            }

            [n1.ElementAttribute(TracingId = 355081U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "TwFPw2SOwIsNXodQdtNWQm", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n22.Vector3> __p_TwFPw2SOwIsNXodQdtNWQm;
            [n1.ElementAttribute(TracingId = 355108U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Qfpn9kjLOYtPm1RuAnQMpa", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n22.Vector3> __p_Qfpn9kjLOYtPm1RuAnQMpa;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<n22.Vector3>> __pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm = default(n11.Spread<n5.GpuValue<n22.Vector3>>);
            public __NxWDecMQhxiO0vdRHQAg84(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __NxWDecMQhxiO0vdRHQAg84(__NxWDecMQhxiO0vdRHQAg84 other): base(other)
            {
                this.__p_TwFPw2SOwIsNXodQdtNWQm = other.__p_TwFPw2SOwIsNXodQdtNWQm;
                this.__p_Qfpn9kjLOYtPm1RuAnQMpa = other.__p_Qfpn9kjLOYtPm1RuAnQMpa;
                this.__pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm = other.__pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TwFPw2SOwIsNXodQdtNWQm", in __p_TwFPw2SOwIsNXodQdtNWQm), n1.CompilationHelper.GetValueOrExisting(values, "__p_Qfpn9kjLOYtPm1RuAnQMpa", in __p_Qfpn9kjLOYtPm1RuAnQMpa), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm", in __pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm));
            }

            internal __NxWDecMQhxiO0vdRHQAg84 __WITH__(n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n22.Vector3> __p_TwFPw2SOwIsNXodQdtNWQm, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n22.Vector3> __p_Qfpn9kjLOYtPm1RuAnQMpa, n11.Spread<n5.GpuValue<n22.Vector3>> __pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm)
            {
                __NxWDecMQhxiO0vdRHQAg84 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_TwFPw2SOwIsNXodQdtNWQm != this.__p_TwFPw2SOwIsNXodQdtNWQm || __p_Qfpn9kjLOYtPm1RuAnQMpa != this.__p_Qfpn9kjLOYtPm1RuAnQMpa || __pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm != this.__pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm ? new __NxWDecMQhxiO0vdRHQAg84(this)
                    {__p_TwFPw2SOwIsNXodQdtNWQm = __p_TwFPw2SOwIsNXodQdtNWQm, __p_Qfpn9kjLOYtPm1RuAnQMpa = __p_Qfpn9kjLOYtPm1RuAnQMpa, __pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm = __pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm} : that_0;
                else
                {
                    this.__p_TwFPw2SOwIsNXodQdtNWQm = __p_TwFPw2SOwIsNXodQdtNWQm;
                    this.__p_Qfpn9kjLOYtPm1RuAnQMpa = __p_Qfpn9kjLOYtPm1RuAnQMpa;
                    this.__pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm = __pin_group_Input_In_TwFPw2SOwIsNXodQdtNWQm;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "HO907v8v5VpLJOAkzyqmHY", Name = "__HO907v8v5VpLJOAkzyqmHY")]
        [n2.SerializableAttribute]
        public class __HO907v8v5VpLJOAkzyqmHY : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_BZoYx81VeiwNtqb7RvTp3W);
                n1.CompilationHelper.SafeDispose(this.__p_IaRQS7c4ab6PXtyUTYKpe3);
                n1.CompilationHelper.SafeDispose(this.__p_TSxqR1Lp53IORLqmGdjhYF);
                n1.CompilationHelper.SafeDispose(this.__p_HB77kUurV7kPk9iBD10B6b);
                return;
            }

            [n1.ElementAttribute(TracingId = 355219U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "BZoYx81VeiwNtqb7RvTp3W", Name = "SetHelper", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetHelper_UGmgQrN7WeaQQX157aMEvr __p_BZoYx81VeiwNtqb7RvTp3W;
            [n1.ElementAttribute(TracingId = 355242U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "IaRQS7c4ab6PXtyUTYKpe3", Name = "BoxFrame", IsManaged = true, IsAutoGenerated = true)]
            public n25.BoxFrame_MdfNJXLlOjzMB5Tg5Xcmlc __p_IaRQS7c4ab6PXtyUTYKpe3;
            [n1.ElementAttribute(TracingId = 355291U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "TSxqR1Lp53IORLqmGdjhYF", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n26.Group_TqwCZl6Gra4OmgvUg1POgm __p_TSxqR1Lp53IORLqmGdjhYF;
            [n1.ElementAttribute(TracingId = 355330U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "HB77kUurV7kPk9iBD10B6b", Name = "SetHelper", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetHelper_UGmgQrN7WeaQQX157aMEvr __p_HB77kUurV7kPk9iBD10B6b;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n27.Entity> __pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF = default(n11.Spread<n27.Entity>);
            public __HO907v8v5VpLJOAkzyqmHY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __HO907v8v5VpLJOAkzyqmHY(__HO907v8v5VpLJOAkzyqmHY other): base(other)
            {
                this.__p_BZoYx81VeiwNtqb7RvTp3W = other.__p_BZoYx81VeiwNtqb7RvTp3W;
                this.__p_IaRQS7c4ab6PXtyUTYKpe3 = other.__p_IaRQS7c4ab6PXtyUTYKpe3;
                this.__p_TSxqR1Lp53IORLqmGdjhYF = other.__p_TSxqR1Lp53IORLqmGdjhYF;
                this.__p_HB77kUurV7kPk9iBD10B6b = other.__p_HB77kUurV7kPk9iBD10B6b;
                this.__pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF = other.__pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BZoYx81VeiwNtqb7RvTp3W", in __p_BZoYx81VeiwNtqb7RvTp3W), n1.CompilationHelper.GetValueOrExisting(values, "__p_IaRQS7c4ab6PXtyUTYKpe3", in __p_IaRQS7c4ab6PXtyUTYKpe3), n1.CompilationHelper.GetValueOrExisting(values, "__p_TSxqR1Lp53IORLqmGdjhYF", in __p_TSxqR1Lp53IORLqmGdjhYF), n1.CompilationHelper.GetValueOrExisting(values, "__p_HB77kUurV7kPk9iBD10B6b", in __p_HB77kUurV7kPk9iBD10B6b), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF", in __pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF));
            }

            internal __HO907v8v5VpLJOAkzyqmHY __WITH__(n10.SetHelper_UGmgQrN7WeaQQX157aMEvr __p_BZoYx81VeiwNtqb7RvTp3W, n25.BoxFrame_MdfNJXLlOjzMB5Tg5Xcmlc __p_IaRQS7c4ab6PXtyUTYKpe3, n26.Group_TqwCZl6Gra4OmgvUg1POgm __p_TSxqR1Lp53IORLqmGdjhYF, n10.SetHelper_UGmgQrN7WeaQQX157aMEvr __p_HB77kUurV7kPk9iBD10B6b, n11.Spread<n27.Entity> __pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF)
            {
                __HO907v8v5VpLJOAkzyqmHY that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_BZoYx81VeiwNtqb7RvTp3W != this.__p_BZoYx81VeiwNtqb7RvTp3W || __p_IaRQS7c4ab6PXtyUTYKpe3 != this.__p_IaRQS7c4ab6PXtyUTYKpe3 || __p_TSxqR1Lp53IORLqmGdjhYF != this.__p_TSxqR1Lp53IORLqmGdjhYF || __p_HB77kUurV7kPk9iBD10B6b != this.__p_HB77kUurV7kPk9iBD10B6b || __pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF != this.__pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF ? new __HO907v8v5VpLJOAkzyqmHY(this)
                    {__p_BZoYx81VeiwNtqb7RvTp3W = __p_BZoYx81VeiwNtqb7RvTp3W, __p_IaRQS7c4ab6PXtyUTYKpe3 = __p_IaRQS7c4ab6PXtyUTYKpe3, __p_TSxqR1Lp53IORLqmGdjhYF = __p_TSxqR1Lp53IORLqmGdjhYF, __p_HB77kUurV7kPk9iBD10B6b = __p_HB77kUurV7kPk9iBD10B6b, __pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF = __pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF} : that_0;
                else
                {
                    this.__p_BZoYx81VeiwNtqb7RvTp3W = __p_BZoYx81VeiwNtqb7RvTp3W;
                    this.__p_IaRQS7c4ab6PXtyUTYKpe3 = __p_IaRQS7c4ab6PXtyUTYKpe3;
                    this.__p_TSxqR1Lp53IORLqmGdjhYF = __p_TSxqR1Lp53IORLqmGdjhYF;
                    this.__p_HB77kUurV7kPk9iBD10B6b = __p_HB77kUurV7kPk9iBD10B6b;
                    this.__pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF = __pin_group_Child_In_TSxqR1Lp53IORLqmGdjhYF;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 355563U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Irt0YFriJdfL2EJnYYiPxv", Name = "Fuse_Core_DomainApplication_Irt0YFriJdfL2EJnYYiPxv")]
    [n2.SerializableAttribute]
    public class Fuse_Core_DomainApplication_Irt0YFriJdfL2EJnYYiPxv : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Fuse_Core_DomainApplication_Irt0YFriJdfL2EJnYYiPxv Create(n1.NodeContext Node_Context)
        {
            var instance = new Fuse_Core_DomainApplication_Irt0YFriJdfL2EJnYYiPxv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Fuse_Core_DomainApplication_Irt0YFriJdfL2EJnYYiPxv CreateDefault()
        {
            var instance = new Fuse_Core_DomainApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Fuse_Core_DomainApplication_Irt0YFriJdfL2EJnYYiPxv Update()
        {
            return this;
        }

        public n3.Fuse_Core_DomainApplication_Irt0YFriJdfL2EJnYYiPxv __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.Fuse_Core_DomainApplication_Irt0YFriJdfL2EJnYYiPxv __CreateDefault__()
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

        public Fuse_Core_DomainApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Fuse_Core_DomainApplication_Irt0YFriJdfL2EJnYYiPxv(Fuse_Core_DomainApplication_Irt0YFriJdfL2EJnYYiPxv other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal Fuse_Core_DomainApplication_Irt0YFriJdfL2EJnYYiPxv __WITH__()
        {
            return this;
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain._2D
{
    [n1.ElementAttribute(TracingId = 343824U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "BUjBC8DKrmOOYYQBjNe3hP", Name = "WorldToHex_BUjBC8DKrmOOYYQBjNe3hP")]
    [n2.SerializableAttribute]
    public class WorldToHex_BUjBC8DKrmOOYYQBjNe3hP : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n28.WorldToHex_BUjBC8DKrmOOYYQBjNe3hP Create(n1.NodeContext Node_Context)
        {
            var instance = new WorldToHex_BUjBC8DKrmOOYYQBjNe3hP(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n28.WorldToHex_BUjBC8DKrmOOYYQBjNe3hP CreateDefault()
        {
            var instance = new WorldToHex_BUjBC8DKrmOOYYQBjNe3hP(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n28.WorldToHex_BUjBC8DKrmOOYYQBjNe3hP Update(n5.GpuValue<n22.Vector2> Input_In, out n5.GpuValue<n22.Vector2> Output_Out)
        {
            string __pad_KoDceBK2K02ObIjaw3kTTP_0 = __slot_KoDceBK2K02ObIjaw3kTTP;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_OwpoTaVDTd3MgS0M5p10el;
            if (manager_3 is null)
            {
                manager_3 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>>(n2.ValueTuple.Create(default(n5.GpuValue<n22.Vector2>)));
            }

            var inputs_4 = (Input_In, __pad_KoDceBK2K02ObIjaw3kTTP_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__UDRnYJRvyrcLZoAeQ9P9bb>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __UDRnYJRvyrcLZoAeQ9P9bb(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD = n17._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "CWW6aW32ztbQS9bCowaDKD", 343850U);
                    var Output_9 = n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2>.Create(Node_Context: Node_Context_8);
                    state_7.__p_CWW6aW32ztbQS9bCowaDKD = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "QNZ5tBmDe5ZM4BaFCfNEC4", 343876U);
                    var Output_11 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.Create(Node_Context: Node_Context_10);
                    state_7.__p_QNZ5tBmDe5ZM4BaFCfNEC4 = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Q3fWzXp9azBNKUyhvB38Fr", 343882U);
                    var Output_13 = n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v.Create(Node_Context: Node_Context_12);
                    state_7.__p_Q3fWzXp9azBNKUyhvB38Fr = Output_13;
                    n30._Operations_.WorldToHex2DID(Output_Out: out string Output_14);
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Ve6aAYdzsmrMFKTHZ9ppKl", 343888U);
                    var Output_16 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_15, ID_In: Output_14);
                    state_7.__p_Ve6aAYdzsmrMFKTHZ9ppKl = Output_16;
                }

                int Id_17 = 0;
                var State_Output_19 = state_7.__p_QNZ5tBmDe5ZM4BaFCfNEC4.Update(The_Override_In: Input_In, Id_In: Id_17, Output_Out: out n5.GpuValue<n22.Vector2> Output_18);
                var Output_21 = state_7.__p_Q3fWzXp9azBNKUyhvB38Fr.Update(Singleton_Out: out string Singleton_20);
                n5.GpuValue<n22.Vector2> Default_22 = default(n5.GpuValue<n22.Vector2>);
                bool Is_Groupable_23 = false;
                n8.IEnumerable<n5.InputModifier> The_Modifiers_24 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_25 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD, 1);
                builder_25.Add(Output_18);
                var __pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD_26 = builder_25.Commit();
                var State_Output_29 = state_7.__p_CWW6aW32ztbQS9bCowaDKD.Update(Arguments_In: __pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD_26, Function_Name_In: __pad_KoDceBK2K02ObIjaw3kTTP_0, Default_In: Default_22, Mixins_In: Singleton_20, Is_Groupable_In: Is_Groupable_23, The_Modifiers_In: The_Modifiers_24, Output_Out: out n5.GpuValue<n22.Vector2> Output_27, Additional_Outputs_Out: out n11.Spread<n5.AbstractGpuValue> Additional_Outputs_28);
                bool Update_30 = true;
                var Output_31 = state_7.__p_Ve6aAYdzsmrMFKTHZ9ppKl;
                if (Update_30)
                {
                    Output_31 = state_7.__p_Ve6aAYdzsmrMFKTHZ9ppKl.Update(Input_In: Output_27);
                }

                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_19 != state_7.__p_QNZ5tBmDe5ZM4BaFCfNEC4 || Output_21 != state_7.__p_Q3fWzXp9azBNKUyhvB38Fr || __pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD_26 != state_7.__pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD || State_Output_29 != state_7.__p_CWW6aW32ztbQS9bCowaDKD || Output_31 != state_7.__p_Ve6aAYdzsmrMFKTHZ9ppKl ? new __UDRnYJRvyrcLZoAeQ9P9bb(state_7)
                    {__p_QNZ5tBmDe5ZM4BaFCfNEC4 = State_Output_19, __p_Q3fWzXp9azBNKUyhvB38Fr = Output_21, __pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD = __pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD_26, __p_CWW6aW32ztbQS9bCowaDKD = State_Output_29, __p_Ve6aAYdzsmrMFKTHZ9ppKl = Output_31} : state_7;
                else
                {
                    state_7.__p_QNZ5tBmDe5ZM4BaFCfNEC4 = State_Output_19;
                    state_7.__p_Q3fWzXp9azBNKUyhvB38Fr = Output_21;
                    state_7.__pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD = __pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD_26;
                    state_7.__p_CWW6aW32ztbQS9bCowaDKD = State_Output_29;
                    state_7.__p_Ve6aAYdzsmrMFKTHZ9ppKl = Output_31;
                }

                outputs_5 = n2.ValueTuple.Create(Output_27);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_32 = outputs_5.Item1;
            Output_Out = __auto_32;
            n28.WorldToHex_BUjBC8DKrmOOYYQBjNe3hP that_33 = this;
            if (this.__GetContext__().IsImmutable)
                that_33 = manager_3 != this.__cache_OwpoTaVDTd3MgS0M5p10el ? new WorldToHex_BUjBC8DKrmOOYYQBjNe3hP(this)
                {__cache_OwpoTaVDTd3MgS0M5p10el = manager_3} : that_33;
            else
            {
                this.__cache_OwpoTaVDTd3MgS0M5p10el = manager_3;
            }

            return that_33;
        }

        public n28.WorldToHex_BUjBC8DKrmOOYYQBjNe3hP __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n28.WorldToHex_BUjBC8DKrmOOYYQBjNe3hP that_0 = this;
            this.__cache_OwpoTaVDTd3MgS0M5p10el = null;
            return that_0;
        }

        public n28.WorldToHex_BUjBC8DKrmOOYYQBjNe3hP __CreateDefault__()
        {
            n28.WorldToHex_BUjBC8DKrmOOYYQBjNe3hP that_0 = this;
            this.__cache_OwpoTaVDTd3MgS0M5p10el = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_OwpoTaVDTd3MgS0M5p10el);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 343923U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "KoDceBK2K02ObIjaw3kTTP", Name = "__slot_KoDceBK2K02ObIjaw3kTTP")]
        public static string __slot_KoDceBK2K02ObIjaw3kTTP = "worldToHex";
        [n1.ElementAttribute(TracingId = 343829U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "OwpoTaVDTd3MgS0M5p10el", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_OwpoTaVDTd3MgS0M5p10el = null;
        static WorldToHex_BUjBC8DKrmOOYYQBjNe3hP()
        {
        }

        public WorldToHex_BUjBC8DKrmOOYYQBjNe3hP(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal WorldToHex_BUjBC8DKrmOOYYQBjNe3hP(WorldToHex_BUjBC8DKrmOOYYQBjNe3hP other): base(other)
        {
            this.__cache_OwpoTaVDTd3MgS0M5p10el = other.__cache_OwpoTaVDTd3MgS0M5p10el;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_OwpoTaVDTd3MgS0M5p10el", in __cache_OwpoTaVDTd3MgS0M5p10el));
        }

        internal WorldToHex_BUjBC8DKrmOOYYQBjNe3hP __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_OwpoTaVDTd3MgS0M5p10el)
        {
            n28.WorldToHex_BUjBC8DKrmOOYYQBjNe3hP that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_OwpoTaVDTd3MgS0M5p10el != this.__cache_OwpoTaVDTd3MgS0M5p10el ? new WorldToHex_BUjBC8DKrmOOYYQBjNe3hP(this)
                {__cache_OwpoTaVDTd3MgS0M5p10el = __cache_OwpoTaVDTd3MgS0M5p10el} : that_0;
            else
            {
                this.__cache_OwpoTaVDTd3MgS0M5p10el = __cache_OwpoTaVDTd3MgS0M5p10el;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "UDRnYJRvyrcLZoAeQ9P9bb", Name = "__UDRnYJRvyrcLZoAeQ9P9bb")]
        [n2.SerializableAttribute]
        public class __UDRnYJRvyrcLZoAeQ9P9bb : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_CWW6aW32ztbQS9bCowaDKD);
                n1.CompilationHelper.SafeDispose(this.__p_QNZ5tBmDe5ZM4BaFCfNEC4);
                n1.CompilationHelper.SafeDispose(this.__p_Q3fWzXp9azBNKUyhvB38Fr);
                n1.CompilationHelper.SafeDispose(this.__p_Ve6aAYdzsmrMFKTHZ9ppKl);
                return;
            }

            [n1.ElementAttribute(TracingId = 343850U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "CWW6aW32ztbQS9bCowaDKD", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2> __p_CWW6aW32ztbQS9bCowaDKD;
            [n1.ElementAttribute(TracingId = 343876U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "QNZ5tBmDe5ZM4BaFCfNEC4", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_QNZ5tBmDe5ZM4BaFCfNEC4;
            [n1.ElementAttribute(TracingId = 343882U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Q3fWzXp9azBNKUyhvB38Fr", Name = "FuseCoreDomain (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_Q3fWzXp9azBNKUyhvB38Fr;
            [n1.ElementAttribute(TracingId = 343888U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Ve6aAYdzsmrMFKTHZ9ppKl", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Ve6aAYdzsmrMFKTHZ9ppKl;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD = default(n11.Spread<n5.AbstractGpuValue>);
            public __UDRnYJRvyrcLZoAeQ9P9bb(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __UDRnYJRvyrcLZoAeQ9P9bb(__UDRnYJRvyrcLZoAeQ9P9bb other): base(other)
            {
                this.__p_CWW6aW32ztbQS9bCowaDKD = other.__p_CWW6aW32ztbQS9bCowaDKD;
                this.__p_QNZ5tBmDe5ZM4BaFCfNEC4 = other.__p_QNZ5tBmDe5ZM4BaFCfNEC4;
                this.__p_Q3fWzXp9azBNKUyhvB38Fr = other.__p_Q3fWzXp9azBNKUyhvB38Fr;
                this.__p_Ve6aAYdzsmrMFKTHZ9ppKl = other.__p_Ve6aAYdzsmrMFKTHZ9ppKl;
                this.__pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD = other.__pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_CWW6aW32ztbQS9bCowaDKD", in __p_CWW6aW32ztbQS9bCowaDKD), n1.CompilationHelper.GetValueOrExisting(values, "__p_QNZ5tBmDe5ZM4BaFCfNEC4", in __p_QNZ5tBmDe5ZM4BaFCfNEC4), n1.CompilationHelper.GetValueOrExisting(values, "__p_Q3fWzXp9azBNKUyhvB38Fr", in __p_Q3fWzXp9azBNKUyhvB38Fr), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ve6aAYdzsmrMFKTHZ9ppKl", in __p_Ve6aAYdzsmrMFKTHZ9ppKl), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD", in __pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD));
            }

            internal __UDRnYJRvyrcLZoAeQ9P9bb __WITH__(n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2> __p_CWW6aW32ztbQS9bCowaDKD, n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_QNZ5tBmDe5ZM4BaFCfNEC4, n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_Q3fWzXp9azBNKUyhvB38Fr, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Ve6aAYdzsmrMFKTHZ9ppKl, n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD)
            {
                __UDRnYJRvyrcLZoAeQ9P9bb that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_CWW6aW32ztbQS9bCowaDKD != this.__p_CWW6aW32ztbQS9bCowaDKD || __p_QNZ5tBmDe5ZM4BaFCfNEC4 != this.__p_QNZ5tBmDe5ZM4BaFCfNEC4 || __p_Q3fWzXp9azBNKUyhvB38Fr != this.__p_Q3fWzXp9azBNKUyhvB38Fr || __p_Ve6aAYdzsmrMFKTHZ9ppKl != this.__p_Ve6aAYdzsmrMFKTHZ9ppKl || __pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD != this.__pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD ? new __UDRnYJRvyrcLZoAeQ9P9bb(this)
                    {__p_CWW6aW32ztbQS9bCowaDKD = __p_CWW6aW32ztbQS9bCowaDKD, __p_QNZ5tBmDe5ZM4BaFCfNEC4 = __p_QNZ5tBmDe5ZM4BaFCfNEC4, __p_Q3fWzXp9azBNKUyhvB38Fr = __p_Q3fWzXp9azBNKUyhvB38Fr, __p_Ve6aAYdzsmrMFKTHZ9ppKl = __p_Ve6aAYdzsmrMFKTHZ9ppKl, __pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD = __pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD} : that_0;
                else
                {
                    this.__p_CWW6aW32ztbQS9bCowaDKD = __p_CWW6aW32ztbQS9bCowaDKD;
                    this.__p_QNZ5tBmDe5ZM4BaFCfNEC4 = __p_QNZ5tBmDe5ZM4BaFCfNEC4;
                    this.__p_Q3fWzXp9azBNKUyhvB38Fr = __p_Q3fWzXp9azBNKUyhvB38Fr;
                    this.__p_Ve6aAYdzsmrMFKTHZ9ppKl = __p_Ve6aAYdzsmrMFKTHZ9ppKl;
                    this.__pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD = __pin_group_Arguments_In_CWW6aW32ztbQS9bCowaDKD;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 344012U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "JfnuCDbTOHoMEmBnoC73RY", Name = "HexToWorld_JfnuCDbTOHoMEmBnoC73RY")]
    [n2.SerializableAttribute]
    public class HexToWorld_JfnuCDbTOHoMEmBnoC73RY : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n28.HexToWorld_JfnuCDbTOHoMEmBnoC73RY Create(n1.NodeContext Node_Context)
        {
            var instance = new HexToWorld_JfnuCDbTOHoMEmBnoC73RY(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n28.HexToWorld_JfnuCDbTOHoMEmBnoC73RY CreateDefault()
        {
            var instance = new HexToWorld_JfnuCDbTOHoMEmBnoC73RY(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n28.HexToWorld_JfnuCDbTOHoMEmBnoC73RY Update(n5.GpuValue<n22.Vector2> Input_In, out n5.GpuValue<n22.Vector2> Output_Out)
        {
            string __pad_KuzG2QFmM7mPGIpNfAoPVF_0 = __slot_KuzG2QFmM7mPGIpNfAoPVF;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_SgljqBOD5f4OXzOWZjNZw2;
            if (manager_3 is null)
            {
                manager_3 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>>(n2.ValueTuple.Create(default(n5.GpuValue<n22.Vector2>)));
            }

            var inputs_4 = (Input_In, __pad_KuzG2QFmM7mPGIpNfAoPVF_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__F2MgqfQRkfaLGLBPsOrrpE>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __F2MgqfQRkfaLGLBPsOrrpE(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3 = n17._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "DsNsSCALhs0PeuM3gUY2A3", 344048U);
                    var Output_9 = n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2>.Create(Node_Context: Node_Context_8);
                    state_7.__p_DsNsSCALhs0PeuM3gUY2A3 = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "I1iN88GwKd8O9V4AxVUbco", 344059U);
                    var Output_11 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.Create(Node_Context: Node_Context_10);
                    state_7.__p_I1iN88GwKd8O9V4AxVUbco = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "EUGCbBsby1eOOm5nG0TPtK", 344068U);
                    var Output_13 = n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v.Create(Node_Context: Node_Context_12);
                    state_7.__p_EUGCbBsby1eOOm5nG0TPtK = Output_13;
                    n31._Operations_.HexToWorld2DID(Output_Out: out string Output_14);
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "CHDaP9EfeSJLntriHqO7SQ", 344074U);
                    var Output_16 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_15, ID_In: Output_14);
                    state_7.__p_CHDaP9EfeSJLntriHqO7SQ = Output_16;
                }

                int Id_17 = 0;
                var State_Output_19 = state_7.__p_I1iN88GwKd8O9V4AxVUbco.Update(The_Override_In: Input_In, Id_In: Id_17, Output_Out: out n5.GpuValue<n22.Vector2> Output_18);
                var Output_21 = state_7.__p_EUGCbBsby1eOOm5nG0TPtK.Update(Singleton_Out: out string Singleton_20);
                n5.GpuValue<n22.Vector2> Default_22 = default(n5.GpuValue<n22.Vector2>);
                bool Is_Groupable_23 = false;
                n8.IEnumerable<n5.InputModifier> The_Modifiers_24 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_25 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3, 1);
                builder_25.Add(Output_18);
                var __pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3_26 = builder_25.Commit();
                var State_Output_29 = state_7.__p_DsNsSCALhs0PeuM3gUY2A3.Update(Arguments_In: __pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3_26, Function_Name_In: __pad_KuzG2QFmM7mPGIpNfAoPVF_0, Default_In: Default_22, Mixins_In: Singleton_20, Is_Groupable_In: Is_Groupable_23, The_Modifiers_In: The_Modifiers_24, Output_Out: out n5.GpuValue<n22.Vector2> Output_27, Additional_Outputs_Out: out n11.Spread<n5.AbstractGpuValue> Additional_Outputs_28);
                bool Update_30 = true;
                var Output_31 = state_7.__p_CHDaP9EfeSJLntriHqO7SQ;
                if (Update_30)
                {
                    Output_31 = state_7.__p_CHDaP9EfeSJLntriHqO7SQ.Update(Input_In: Output_27);
                }

                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_19 != state_7.__p_I1iN88GwKd8O9V4AxVUbco || Output_21 != state_7.__p_EUGCbBsby1eOOm5nG0TPtK || __pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3_26 != state_7.__pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3 || State_Output_29 != state_7.__p_DsNsSCALhs0PeuM3gUY2A3 || Output_31 != state_7.__p_CHDaP9EfeSJLntriHqO7SQ ? new __F2MgqfQRkfaLGLBPsOrrpE(state_7)
                    {__p_I1iN88GwKd8O9V4AxVUbco = State_Output_19, __p_EUGCbBsby1eOOm5nG0TPtK = Output_21, __pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3 = __pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3_26, __p_DsNsSCALhs0PeuM3gUY2A3 = State_Output_29, __p_CHDaP9EfeSJLntriHqO7SQ = Output_31} : state_7;
                else
                {
                    state_7.__p_I1iN88GwKd8O9V4AxVUbco = State_Output_19;
                    state_7.__p_EUGCbBsby1eOOm5nG0TPtK = Output_21;
                    state_7.__pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3 = __pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3_26;
                    state_7.__p_DsNsSCALhs0PeuM3gUY2A3 = State_Output_29;
                    state_7.__p_CHDaP9EfeSJLntriHqO7SQ = Output_31;
                }

                outputs_5 = n2.ValueTuple.Create(Output_27);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_32 = outputs_5.Item1;
            Output_Out = __auto_32;
            n28.HexToWorld_JfnuCDbTOHoMEmBnoC73RY that_33 = this;
            if (this.__GetContext__().IsImmutable)
                that_33 = manager_3 != this.__cache_SgljqBOD5f4OXzOWZjNZw2 ? new HexToWorld_JfnuCDbTOHoMEmBnoC73RY(this)
                {__cache_SgljqBOD5f4OXzOWZjNZw2 = manager_3} : that_33;
            else
            {
                this.__cache_SgljqBOD5f4OXzOWZjNZw2 = manager_3;
            }

            return that_33;
        }

        public n28.HexToWorld_JfnuCDbTOHoMEmBnoC73RY __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n28.HexToWorld_JfnuCDbTOHoMEmBnoC73RY that_0 = this;
            this.__cache_SgljqBOD5f4OXzOWZjNZw2 = null;
            return that_0;
        }

        public n28.HexToWorld_JfnuCDbTOHoMEmBnoC73RY __CreateDefault__()
        {
            n28.HexToWorld_JfnuCDbTOHoMEmBnoC73RY that_0 = this;
            this.__cache_SgljqBOD5f4OXzOWZjNZw2 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_SgljqBOD5f4OXzOWZjNZw2);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 344085U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "KuzG2QFmM7mPGIpNfAoPVF", Name = "__slot_KuzG2QFmM7mPGIpNfAoPVF")]
        public static string __slot_KuzG2QFmM7mPGIpNfAoPVF = "hexToWorld";
        [n1.ElementAttribute(TracingId = 344021U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "SgljqBOD5f4OXzOWZjNZw2", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_SgljqBOD5f4OXzOWZjNZw2 = null;
        static HexToWorld_JfnuCDbTOHoMEmBnoC73RY()
        {
        }

        public HexToWorld_JfnuCDbTOHoMEmBnoC73RY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HexToWorld_JfnuCDbTOHoMEmBnoC73RY(HexToWorld_JfnuCDbTOHoMEmBnoC73RY other): base(other)
        {
            this.__cache_SgljqBOD5f4OXzOWZjNZw2 = other.__cache_SgljqBOD5f4OXzOWZjNZw2;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_SgljqBOD5f4OXzOWZjNZw2", in __cache_SgljqBOD5f4OXzOWZjNZw2));
        }

        internal HexToWorld_JfnuCDbTOHoMEmBnoC73RY __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_SgljqBOD5f4OXzOWZjNZw2)
        {
            n28.HexToWorld_JfnuCDbTOHoMEmBnoC73RY that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_SgljqBOD5f4OXzOWZjNZw2 != this.__cache_SgljqBOD5f4OXzOWZjNZw2 ? new HexToWorld_JfnuCDbTOHoMEmBnoC73RY(this)
                {__cache_SgljqBOD5f4OXzOWZjNZw2 = __cache_SgljqBOD5f4OXzOWZjNZw2} : that_0;
            else
            {
                this.__cache_SgljqBOD5f4OXzOWZjNZw2 = __cache_SgljqBOD5f4OXzOWZjNZw2;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "F2MgqfQRkfaLGLBPsOrrpE", Name = "__F2MgqfQRkfaLGLBPsOrrpE")]
        [n2.SerializableAttribute]
        public class __F2MgqfQRkfaLGLBPsOrrpE : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_DsNsSCALhs0PeuM3gUY2A3);
                n1.CompilationHelper.SafeDispose(this.__p_I1iN88GwKd8O9V4AxVUbco);
                n1.CompilationHelper.SafeDispose(this.__p_EUGCbBsby1eOOm5nG0TPtK);
                n1.CompilationHelper.SafeDispose(this.__p_CHDaP9EfeSJLntriHqO7SQ);
                return;
            }

            [n1.ElementAttribute(TracingId = 344048U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "DsNsSCALhs0PeuM3gUY2A3", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2> __p_DsNsSCALhs0PeuM3gUY2A3;
            [n1.ElementAttribute(TracingId = 344059U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "I1iN88GwKd8O9V4AxVUbco", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_I1iN88GwKd8O9V4AxVUbco;
            [n1.ElementAttribute(TracingId = 344068U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "EUGCbBsby1eOOm5nG0TPtK", Name = "FuseCoreDomain (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_EUGCbBsby1eOOm5nG0TPtK;
            [n1.ElementAttribute(TracingId = 344074U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "CHDaP9EfeSJLntriHqO7SQ", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_CHDaP9EfeSJLntriHqO7SQ;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3 = default(n11.Spread<n5.AbstractGpuValue>);
            public __F2MgqfQRkfaLGLBPsOrrpE(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __F2MgqfQRkfaLGLBPsOrrpE(__F2MgqfQRkfaLGLBPsOrrpE other): base(other)
            {
                this.__p_DsNsSCALhs0PeuM3gUY2A3 = other.__p_DsNsSCALhs0PeuM3gUY2A3;
                this.__p_I1iN88GwKd8O9V4AxVUbco = other.__p_I1iN88GwKd8O9V4AxVUbco;
                this.__p_EUGCbBsby1eOOm5nG0TPtK = other.__p_EUGCbBsby1eOOm5nG0TPtK;
                this.__p_CHDaP9EfeSJLntriHqO7SQ = other.__p_CHDaP9EfeSJLntriHqO7SQ;
                this.__pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3 = other.__pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DsNsSCALhs0PeuM3gUY2A3", in __p_DsNsSCALhs0PeuM3gUY2A3), n1.CompilationHelper.GetValueOrExisting(values, "__p_I1iN88GwKd8O9V4AxVUbco", in __p_I1iN88GwKd8O9V4AxVUbco), n1.CompilationHelper.GetValueOrExisting(values, "__p_EUGCbBsby1eOOm5nG0TPtK", in __p_EUGCbBsby1eOOm5nG0TPtK), n1.CompilationHelper.GetValueOrExisting(values, "__p_CHDaP9EfeSJLntriHqO7SQ", in __p_CHDaP9EfeSJLntriHqO7SQ), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3", in __pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3));
            }

            internal __F2MgqfQRkfaLGLBPsOrrpE __WITH__(n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2> __p_DsNsSCALhs0PeuM3gUY2A3, n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_I1iN88GwKd8O9V4AxVUbco, n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_EUGCbBsby1eOOm5nG0TPtK, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_CHDaP9EfeSJLntriHqO7SQ, n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3)
            {
                __F2MgqfQRkfaLGLBPsOrrpE that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_DsNsSCALhs0PeuM3gUY2A3 != this.__p_DsNsSCALhs0PeuM3gUY2A3 || __p_I1iN88GwKd8O9V4AxVUbco != this.__p_I1iN88GwKd8O9V4AxVUbco || __p_EUGCbBsby1eOOm5nG0TPtK != this.__p_EUGCbBsby1eOOm5nG0TPtK || __p_CHDaP9EfeSJLntriHqO7SQ != this.__p_CHDaP9EfeSJLntriHqO7SQ || __pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3 != this.__pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3 ? new __F2MgqfQRkfaLGLBPsOrrpE(this)
                    {__p_DsNsSCALhs0PeuM3gUY2A3 = __p_DsNsSCALhs0PeuM3gUY2A3, __p_I1iN88GwKd8O9V4AxVUbco = __p_I1iN88GwKd8O9V4AxVUbco, __p_EUGCbBsby1eOOm5nG0TPtK = __p_EUGCbBsby1eOOm5nG0TPtK, __p_CHDaP9EfeSJLntriHqO7SQ = __p_CHDaP9EfeSJLntriHqO7SQ, __pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3 = __pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3} : that_0;
                else
                {
                    this.__p_DsNsSCALhs0PeuM3gUY2A3 = __p_DsNsSCALhs0PeuM3gUY2A3;
                    this.__p_I1iN88GwKd8O9V4AxVUbco = __p_I1iN88GwKd8O9V4AxVUbco;
                    this.__p_EUGCbBsby1eOOm5nG0TPtK = __p_EUGCbBsby1eOOm5nG0TPtK;
                    this.__p_CHDaP9EfeSJLntriHqO7SQ = __p_CHDaP9EfeSJLntriHqO7SQ;
                    this.__pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3 = __pin_group_Arguments_In_DsNsSCALhs0PeuM3gUY2A3;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 344143U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "EpGDXXbZeW3PpGqpdinRhb", Name = "WorldToTri_EpGDXXbZeW3PpGqpdinRhb")]
    [n2.SerializableAttribute]
    public class WorldToTri_EpGDXXbZeW3PpGqpdinRhb : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n28.WorldToTri_EpGDXXbZeW3PpGqpdinRhb Create(n1.NodeContext Node_Context)
        {
            var instance = new WorldToTri_EpGDXXbZeW3PpGqpdinRhb(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n28.WorldToTri_EpGDXXbZeW3PpGqpdinRhb CreateDefault()
        {
            var instance = new WorldToTri_EpGDXXbZeW3PpGqpdinRhb(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n28.WorldToTri_EpGDXXbZeW3PpGqpdinRhb Update(n5.GpuValue<n22.Vector2> Input_In, out n5.GpuValue<n22.Vector2> Output_Out)
        {
            string __pad_TLzZ719YP7QL2BQWH7mTHh_0 = __slot_TLzZ719YP7QL2BQWH7mTHh;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_BzJb0PYEA69PKFk2wJe6M8;
            if (manager_3 is null)
            {
                manager_3 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>>(n2.ValueTuple.Create(default(n5.GpuValue<n22.Vector2>)));
            }

            var inputs_4 = (Input_In, __pad_TLzZ719YP7QL2BQWH7mTHh_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__MpESc0AlXOrQMI9SeA0718>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __MpESc0AlXOrQMI9SeA0718(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X = n17._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Vacy912PwhILMXDsDDXy7X", 344168U);
                    var Output_9 = n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2>.Create(Node_Context: Node_Context_8);
                    state_7.__p_Vacy912PwhILMXDsDDXy7X = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "LUG0O37PSVRLWSK2TZ0EOj", 344188U);
                    var Output_11 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.Create(Node_Context: Node_Context_10);
                    state_7.__p_LUG0O37PSVRLWSK2TZ0EOj = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "FbAjWKCftn1NbGphOaSFRI", 344192U);
                    var Output_13 = n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v.Create(Node_Context: Node_Context_12);
                    state_7.__p_FbAjWKCftn1NbGphOaSFRI = Output_13;
                    n32._Operations_.WorldToTri2DID(Output_Out: out string Output_14);
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "KEE65xoMfzqM9DxVdWwjfE", 344201U);
                    var Output_16 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_15, ID_In: Output_14);
                    state_7.__p_KEE65xoMfzqM9DxVdWwjfE = Output_16;
                }

                int Id_17 = 0;
                var State_Output_19 = state_7.__p_LUG0O37PSVRLWSK2TZ0EOj.Update(The_Override_In: Input_In, Id_In: Id_17, Output_Out: out n5.GpuValue<n22.Vector2> Output_18);
                var Output_21 = state_7.__p_FbAjWKCftn1NbGphOaSFRI.Update(Singleton_Out: out string Singleton_20);
                n5.GpuValue<n22.Vector2> Default_22 = default(n5.GpuValue<n22.Vector2>);
                bool Is_Groupable_23 = false;
                n8.IEnumerable<n5.InputModifier> The_Modifiers_24 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_25 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X, 1);
                builder_25.Add(Output_18);
                var __pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X_26 = builder_25.Commit();
                var State_Output_29 = state_7.__p_Vacy912PwhILMXDsDDXy7X.Update(Arguments_In: __pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X_26, Function_Name_In: __pad_TLzZ719YP7QL2BQWH7mTHh_0, Default_In: Default_22, Mixins_In: Singleton_20, Is_Groupable_In: Is_Groupable_23, The_Modifiers_In: The_Modifiers_24, Output_Out: out n5.GpuValue<n22.Vector2> Output_27, Additional_Outputs_Out: out n11.Spread<n5.AbstractGpuValue> Additional_Outputs_28);
                bool Update_30 = true;
                var Output_31 = state_7.__p_KEE65xoMfzqM9DxVdWwjfE;
                if (Update_30)
                {
                    Output_31 = state_7.__p_KEE65xoMfzqM9DxVdWwjfE.Update(Input_In: Output_27);
                }

                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_19 != state_7.__p_LUG0O37PSVRLWSK2TZ0EOj || Output_21 != state_7.__p_FbAjWKCftn1NbGphOaSFRI || __pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X_26 != state_7.__pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X || State_Output_29 != state_7.__p_Vacy912PwhILMXDsDDXy7X || Output_31 != state_7.__p_KEE65xoMfzqM9DxVdWwjfE ? new __MpESc0AlXOrQMI9SeA0718(state_7)
                    {__p_LUG0O37PSVRLWSK2TZ0EOj = State_Output_19, __p_FbAjWKCftn1NbGphOaSFRI = Output_21, __pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X = __pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X_26, __p_Vacy912PwhILMXDsDDXy7X = State_Output_29, __p_KEE65xoMfzqM9DxVdWwjfE = Output_31} : state_7;
                else
                {
                    state_7.__p_LUG0O37PSVRLWSK2TZ0EOj = State_Output_19;
                    state_7.__p_FbAjWKCftn1NbGphOaSFRI = Output_21;
                    state_7.__pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X = __pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X_26;
                    state_7.__p_Vacy912PwhILMXDsDDXy7X = State_Output_29;
                    state_7.__p_KEE65xoMfzqM9DxVdWwjfE = Output_31;
                }

                outputs_5 = n2.ValueTuple.Create(Output_27);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_32 = outputs_5.Item1;
            Output_Out = __auto_32;
            n28.WorldToTri_EpGDXXbZeW3PpGqpdinRhb that_33 = this;
            if (this.__GetContext__().IsImmutable)
                that_33 = manager_3 != this.__cache_BzJb0PYEA69PKFk2wJe6M8 ? new WorldToTri_EpGDXXbZeW3PpGqpdinRhb(this)
                {__cache_BzJb0PYEA69PKFk2wJe6M8 = manager_3} : that_33;
            else
            {
                this.__cache_BzJb0PYEA69PKFk2wJe6M8 = manager_3;
            }

            return that_33;
        }

        public n28.WorldToTri_EpGDXXbZeW3PpGqpdinRhb __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n28.WorldToTri_EpGDXXbZeW3PpGqpdinRhb that_0 = this;
            this.__cache_BzJb0PYEA69PKFk2wJe6M8 = null;
            return that_0;
        }

        public n28.WorldToTri_EpGDXXbZeW3PpGqpdinRhb __CreateDefault__()
        {
            n28.WorldToTri_EpGDXXbZeW3PpGqpdinRhb that_0 = this;
            this.__cache_BzJb0PYEA69PKFk2wJe6M8 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_BzJb0PYEA69PKFk2wJe6M8);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 344220U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "TLzZ719YP7QL2BQWH7mTHh", Name = "__slot_TLzZ719YP7QL2BQWH7mTHh")]
        public static string __slot_TLzZ719YP7QL2BQWH7mTHh = "worldToTri";
        [n1.ElementAttribute(TracingId = 344148U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "BzJb0PYEA69PKFk2wJe6M8", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_BzJb0PYEA69PKFk2wJe6M8 = null;
        static WorldToTri_EpGDXXbZeW3PpGqpdinRhb()
        {
        }

        public WorldToTri_EpGDXXbZeW3PpGqpdinRhb(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal WorldToTri_EpGDXXbZeW3PpGqpdinRhb(WorldToTri_EpGDXXbZeW3PpGqpdinRhb other): base(other)
        {
            this.__cache_BzJb0PYEA69PKFk2wJe6M8 = other.__cache_BzJb0PYEA69PKFk2wJe6M8;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_BzJb0PYEA69PKFk2wJe6M8", in __cache_BzJb0PYEA69PKFk2wJe6M8));
        }

        internal WorldToTri_EpGDXXbZeW3PpGqpdinRhb __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_BzJb0PYEA69PKFk2wJe6M8)
        {
            n28.WorldToTri_EpGDXXbZeW3PpGqpdinRhb that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_BzJb0PYEA69PKFk2wJe6M8 != this.__cache_BzJb0PYEA69PKFk2wJe6M8 ? new WorldToTri_EpGDXXbZeW3PpGqpdinRhb(this)
                {__cache_BzJb0PYEA69PKFk2wJe6M8 = __cache_BzJb0PYEA69PKFk2wJe6M8} : that_0;
            else
            {
                this.__cache_BzJb0PYEA69PKFk2wJe6M8 = __cache_BzJb0PYEA69PKFk2wJe6M8;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "MpESc0AlXOrQMI9SeA0718", Name = "__MpESc0AlXOrQMI9SeA0718")]
        [n2.SerializableAttribute]
        public class __MpESc0AlXOrQMI9SeA0718 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Vacy912PwhILMXDsDDXy7X);
                n1.CompilationHelper.SafeDispose(this.__p_LUG0O37PSVRLWSK2TZ0EOj);
                n1.CompilationHelper.SafeDispose(this.__p_FbAjWKCftn1NbGphOaSFRI);
                n1.CompilationHelper.SafeDispose(this.__p_KEE65xoMfzqM9DxVdWwjfE);
                return;
            }

            [n1.ElementAttribute(TracingId = 344168U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Vacy912PwhILMXDsDDXy7X", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2> __p_Vacy912PwhILMXDsDDXy7X;
            [n1.ElementAttribute(TracingId = 344188U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "LUG0O37PSVRLWSK2TZ0EOj", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_LUG0O37PSVRLWSK2TZ0EOj;
            [n1.ElementAttribute(TracingId = 344192U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "FbAjWKCftn1NbGphOaSFRI", Name = "FuseCoreDomain (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_FbAjWKCftn1NbGphOaSFRI;
            [n1.ElementAttribute(TracingId = 344201U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "KEE65xoMfzqM9DxVdWwjfE", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_KEE65xoMfzqM9DxVdWwjfE;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X = default(n11.Spread<n5.AbstractGpuValue>);
            public __MpESc0AlXOrQMI9SeA0718(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MpESc0AlXOrQMI9SeA0718(__MpESc0AlXOrQMI9SeA0718 other): base(other)
            {
                this.__p_Vacy912PwhILMXDsDDXy7X = other.__p_Vacy912PwhILMXDsDDXy7X;
                this.__p_LUG0O37PSVRLWSK2TZ0EOj = other.__p_LUG0O37PSVRLWSK2TZ0EOj;
                this.__p_FbAjWKCftn1NbGphOaSFRI = other.__p_FbAjWKCftn1NbGphOaSFRI;
                this.__p_KEE65xoMfzqM9DxVdWwjfE = other.__p_KEE65xoMfzqM9DxVdWwjfE;
                this.__pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X = other.__pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Vacy912PwhILMXDsDDXy7X", in __p_Vacy912PwhILMXDsDDXy7X), n1.CompilationHelper.GetValueOrExisting(values, "__p_LUG0O37PSVRLWSK2TZ0EOj", in __p_LUG0O37PSVRLWSK2TZ0EOj), n1.CompilationHelper.GetValueOrExisting(values, "__p_FbAjWKCftn1NbGphOaSFRI", in __p_FbAjWKCftn1NbGphOaSFRI), n1.CompilationHelper.GetValueOrExisting(values, "__p_KEE65xoMfzqM9DxVdWwjfE", in __p_KEE65xoMfzqM9DxVdWwjfE), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X", in __pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X));
            }

            internal __MpESc0AlXOrQMI9SeA0718 __WITH__(n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2> __p_Vacy912PwhILMXDsDDXy7X, n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_LUG0O37PSVRLWSK2TZ0EOj, n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_FbAjWKCftn1NbGphOaSFRI, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_KEE65xoMfzqM9DxVdWwjfE, n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X)
            {
                __MpESc0AlXOrQMI9SeA0718 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Vacy912PwhILMXDsDDXy7X != this.__p_Vacy912PwhILMXDsDDXy7X || __p_LUG0O37PSVRLWSK2TZ0EOj != this.__p_LUG0O37PSVRLWSK2TZ0EOj || __p_FbAjWKCftn1NbGphOaSFRI != this.__p_FbAjWKCftn1NbGphOaSFRI || __p_KEE65xoMfzqM9DxVdWwjfE != this.__p_KEE65xoMfzqM9DxVdWwjfE || __pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X != this.__pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X ? new __MpESc0AlXOrQMI9SeA0718(this)
                    {__p_Vacy912PwhILMXDsDDXy7X = __p_Vacy912PwhILMXDsDDXy7X, __p_LUG0O37PSVRLWSK2TZ0EOj = __p_LUG0O37PSVRLWSK2TZ0EOj, __p_FbAjWKCftn1NbGphOaSFRI = __p_FbAjWKCftn1NbGphOaSFRI, __p_KEE65xoMfzqM9DxVdWwjfE = __p_KEE65xoMfzqM9DxVdWwjfE, __pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X = __pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X} : that_0;
                else
                {
                    this.__p_Vacy912PwhILMXDsDDXy7X = __p_Vacy912PwhILMXDsDDXy7X;
                    this.__p_LUG0O37PSVRLWSK2TZ0EOj = __p_LUG0O37PSVRLWSK2TZ0EOj;
                    this.__p_FbAjWKCftn1NbGphOaSFRI = __p_FbAjWKCftn1NbGphOaSFRI;
                    this.__p_KEE65xoMfzqM9DxVdWwjfE = __p_KEE65xoMfzqM9DxVdWwjfE;
                    this.__pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X = __pin_group_Arguments_In_Vacy912PwhILMXDsDDXy7X;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 344286U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "S2g04dafI2LOWWkG4DFiIR", Name = "TriToWorld_S2g04dafI2LOWWkG4DFiIR")]
    [n2.SerializableAttribute]
    public class TriToWorld_S2g04dafI2LOWWkG4DFiIR : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n28.TriToWorld_S2g04dafI2LOWWkG4DFiIR Create(n1.NodeContext Node_Context)
        {
            var instance = new TriToWorld_S2g04dafI2LOWWkG4DFiIR(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n28.TriToWorld_S2g04dafI2LOWWkG4DFiIR CreateDefault()
        {
            var instance = new TriToWorld_S2g04dafI2LOWWkG4DFiIR(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n28.TriToWorld_S2g04dafI2LOWWkG4DFiIR Update(n5.GpuValue<n22.Vector2> Input_In, out n5.GpuValue<n22.Vector2> Output_Out)
        {
            string __pad_VamO5j4VRqiN5hSPsWrzm4_0 = __slot_VamO5j4VRqiN5hSPsWrzm4;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_CAJorD6hKqDN04v5ELhMX9;
            if (manager_3 is null)
            {
                manager_3 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>>(n2.ValueTuple.Create(default(n5.GpuValue<n22.Vector2>)));
            }

            var inputs_4 = (Input_In, __pad_VamO5j4VRqiN5hSPsWrzm4_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__V3IYri1J4YRPZf7uwEpbuh>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __V3IYri1J4YRPZf7uwEpbuh(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd = n17._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "UcdVJkCZWBWNmP2Vcoxjcd", 344315U);
                    var Output_9 = n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2>.Create(Node_Context: Node_Context_8);
                    state_7.__p_UcdVJkCZWBWNmP2Vcoxjcd = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "OGk9nNGTYGTODzTOp2RP76", 344339U);
                    var Output_11 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.Create(Node_Context: Node_Context_10);
                    state_7.__p_OGk9nNGTYGTODzTOp2RP76 = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "H5JhziYlX8SO5wdTjsy9kw", 344355U);
                    var Output_13 = n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v.Create(Node_Context: Node_Context_12);
                    state_7.__p_H5JhziYlX8SO5wdTjsy9kw = Output_13;
                    n33._Operations_.TriToWorld2DID(Output_Out: out string Output_14);
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "EdfNHLnXnU1O61AsUnavMP", 344371U);
                    var Output_16 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_15, ID_In: Output_14);
                    state_7.__p_EdfNHLnXnU1O61AsUnavMP = Output_16;
                }

                int Id_17 = 0;
                var State_Output_19 = state_7.__p_OGk9nNGTYGTODzTOp2RP76.Update(The_Override_In: Input_In, Id_In: Id_17, Output_Out: out n5.GpuValue<n22.Vector2> Output_18);
                var Output_21 = state_7.__p_H5JhziYlX8SO5wdTjsy9kw.Update(Singleton_Out: out string Singleton_20);
                n5.GpuValue<n22.Vector2> Default_22 = default(n5.GpuValue<n22.Vector2>);
                bool Is_Groupable_23 = false;
                n8.IEnumerable<n5.InputModifier> The_Modifiers_24 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_25 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd, 1);
                builder_25.Add(Output_18);
                var __pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd_26 = builder_25.Commit();
                var State_Output_29 = state_7.__p_UcdVJkCZWBWNmP2Vcoxjcd.Update(Arguments_In: __pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd_26, Function_Name_In: __pad_VamO5j4VRqiN5hSPsWrzm4_0, Default_In: Default_22, Mixins_In: Singleton_20, Is_Groupable_In: Is_Groupable_23, The_Modifiers_In: The_Modifiers_24, Output_Out: out n5.GpuValue<n22.Vector2> Output_27, Additional_Outputs_Out: out n11.Spread<n5.AbstractGpuValue> Additional_Outputs_28);
                bool Update_30 = true;
                var Output_31 = state_7.__p_EdfNHLnXnU1O61AsUnavMP;
                if (Update_30)
                {
                    Output_31 = state_7.__p_EdfNHLnXnU1O61AsUnavMP.Update(Input_In: Output_27);
                }

                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_19 != state_7.__p_OGk9nNGTYGTODzTOp2RP76 || Output_21 != state_7.__p_H5JhziYlX8SO5wdTjsy9kw || __pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd_26 != state_7.__pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd || State_Output_29 != state_7.__p_UcdVJkCZWBWNmP2Vcoxjcd || Output_31 != state_7.__p_EdfNHLnXnU1O61AsUnavMP ? new __V3IYri1J4YRPZf7uwEpbuh(state_7)
                    {__p_OGk9nNGTYGTODzTOp2RP76 = State_Output_19, __p_H5JhziYlX8SO5wdTjsy9kw = Output_21, __pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd = __pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd_26, __p_UcdVJkCZWBWNmP2Vcoxjcd = State_Output_29, __p_EdfNHLnXnU1O61AsUnavMP = Output_31} : state_7;
                else
                {
                    state_7.__p_OGk9nNGTYGTODzTOp2RP76 = State_Output_19;
                    state_7.__p_H5JhziYlX8SO5wdTjsy9kw = Output_21;
                    state_7.__pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd = __pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd_26;
                    state_7.__p_UcdVJkCZWBWNmP2Vcoxjcd = State_Output_29;
                    state_7.__p_EdfNHLnXnU1O61AsUnavMP = Output_31;
                }

                outputs_5 = n2.ValueTuple.Create(Output_27);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_32 = outputs_5.Item1;
            Output_Out = __auto_32;
            n28.TriToWorld_S2g04dafI2LOWWkG4DFiIR that_33 = this;
            if (this.__GetContext__().IsImmutable)
                that_33 = manager_3 != this.__cache_CAJorD6hKqDN04v5ELhMX9 ? new TriToWorld_S2g04dafI2LOWWkG4DFiIR(this)
                {__cache_CAJorD6hKqDN04v5ELhMX9 = manager_3} : that_33;
            else
            {
                this.__cache_CAJorD6hKqDN04v5ELhMX9 = manager_3;
            }

            return that_33;
        }

        public n28.TriToWorld_S2g04dafI2LOWWkG4DFiIR __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n28.TriToWorld_S2g04dafI2LOWWkG4DFiIR that_0 = this;
            this.__cache_CAJorD6hKqDN04v5ELhMX9 = null;
            return that_0;
        }

        public n28.TriToWorld_S2g04dafI2LOWWkG4DFiIR __CreateDefault__()
        {
            n28.TriToWorld_S2g04dafI2LOWWkG4DFiIR that_0 = this;
            this.__cache_CAJorD6hKqDN04v5ELhMX9 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_CAJorD6hKqDN04v5ELhMX9);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 344413U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "VamO5j4VRqiN5hSPsWrzm4", Name = "__slot_VamO5j4VRqiN5hSPsWrzm4")]
        public static string __slot_VamO5j4VRqiN5hSPsWrzm4 = "TriToWorld";
        [n1.ElementAttribute(TracingId = 344290U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "CAJorD6hKqDN04v5ELhMX9", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_CAJorD6hKqDN04v5ELhMX9 = null;
        static TriToWorld_S2g04dafI2LOWWkG4DFiIR()
        {
        }

        public TriToWorld_S2g04dafI2LOWWkG4DFiIR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TriToWorld_S2g04dafI2LOWWkG4DFiIR(TriToWorld_S2g04dafI2LOWWkG4DFiIR other): base(other)
        {
            this.__cache_CAJorD6hKqDN04v5ELhMX9 = other.__cache_CAJorD6hKqDN04v5ELhMX9;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_CAJorD6hKqDN04v5ELhMX9", in __cache_CAJorD6hKqDN04v5ELhMX9));
        }

        internal TriToWorld_S2g04dafI2LOWWkG4DFiIR __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_CAJorD6hKqDN04v5ELhMX9)
        {
            n28.TriToWorld_S2g04dafI2LOWWkG4DFiIR that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_CAJorD6hKqDN04v5ELhMX9 != this.__cache_CAJorD6hKqDN04v5ELhMX9 ? new TriToWorld_S2g04dafI2LOWWkG4DFiIR(this)
                {__cache_CAJorD6hKqDN04v5ELhMX9 = __cache_CAJorD6hKqDN04v5ELhMX9} : that_0;
            else
            {
                this.__cache_CAJorD6hKqDN04v5ELhMX9 = __cache_CAJorD6hKqDN04v5ELhMX9;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "V3IYri1J4YRPZf7uwEpbuh", Name = "__V3IYri1J4YRPZf7uwEpbuh")]
        [n2.SerializableAttribute]
        public class __V3IYri1J4YRPZf7uwEpbuh : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UcdVJkCZWBWNmP2Vcoxjcd);
                n1.CompilationHelper.SafeDispose(this.__p_OGk9nNGTYGTODzTOp2RP76);
                n1.CompilationHelper.SafeDispose(this.__p_H5JhziYlX8SO5wdTjsy9kw);
                n1.CompilationHelper.SafeDispose(this.__p_EdfNHLnXnU1O61AsUnavMP);
                return;
            }

            [n1.ElementAttribute(TracingId = 344315U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "UcdVJkCZWBWNmP2Vcoxjcd", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2> __p_UcdVJkCZWBWNmP2Vcoxjcd;
            [n1.ElementAttribute(TracingId = 344339U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "OGk9nNGTYGTODzTOp2RP76", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_OGk9nNGTYGTODzTOp2RP76;
            [n1.ElementAttribute(TracingId = 344355U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "H5JhziYlX8SO5wdTjsy9kw", Name = "FuseCoreDomain (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_H5JhziYlX8SO5wdTjsy9kw;
            [n1.ElementAttribute(TracingId = 344371U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "EdfNHLnXnU1O61AsUnavMP", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_EdfNHLnXnU1O61AsUnavMP;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd = default(n11.Spread<n5.AbstractGpuValue>);
            public __V3IYri1J4YRPZf7uwEpbuh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __V3IYri1J4YRPZf7uwEpbuh(__V3IYri1J4YRPZf7uwEpbuh other): base(other)
            {
                this.__p_UcdVJkCZWBWNmP2Vcoxjcd = other.__p_UcdVJkCZWBWNmP2Vcoxjcd;
                this.__p_OGk9nNGTYGTODzTOp2RP76 = other.__p_OGk9nNGTYGTODzTOp2RP76;
                this.__p_H5JhziYlX8SO5wdTjsy9kw = other.__p_H5JhziYlX8SO5wdTjsy9kw;
                this.__p_EdfNHLnXnU1O61AsUnavMP = other.__p_EdfNHLnXnU1O61AsUnavMP;
                this.__pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd = other.__pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UcdVJkCZWBWNmP2Vcoxjcd", in __p_UcdVJkCZWBWNmP2Vcoxjcd), n1.CompilationHelper.GetValueOrExisting(values, "__p_OGk9nNGTYGTODzTOp2RP76", in __p_OGk9nNGTYGTODzTOp2RP76), n1.CompilationHelper.GetValueOrExisting(values, "__p_H5JhziYlX8SO5wdTjsy9kw", in __p_H5JhziYlX8SO5wdTjsy9kw), n1.CompilationHelper.GetValueOrExisting(values, "__p_EdfNHLnXnU1O61AsUnavMP", in __p_EdfNHLnXnU1O61AsUnavMP), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd", in __pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd));
            }

            internal __V3IYri1J4YRPZf7uwEpbuh __WITH__(n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2> __p_UcdVJkCZWBWNmP2Vcoxjcd, n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_OGk9nNGTYGTODzTOp2RP76, n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_H5JhziYlX8SO5wdTjsy9kw, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_EdfNHLnXnU1O61AsUnavMP, n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd)
            {
                __V3IYri1J4YRPZf7uwEpbuh that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_UcdVJkCZWBWNmP2Vcoxjcd != this.__p_UcdVJkCZWBWNmP2Vcoxjcd || __p_OGk9nNGTYGTODzTOp2RP76 != this.__p_OGk9nNGTYGTODzTOp2RP76 || __p_H5JhziYlX8SO5wdTjsy9kw != this.__p_H5JhziYlX8SO5wdTjsy9kw || __p_EdfNHLnXnU1O61AsUnavMP != this.__p_EdfNHLnXnU1O61AsUnavMP || __pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd != this.__pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd ? new __V3IYri1J4YRPZf7uwEpbuh(this)
                    {__p_UcdVJkCZWBWNmP2Vcoxjcd = __p_UcdVJkCZWBWNmP2Vcoxjcd, __p_OGk9nNGTYGTODzTOp2RP76 = __p_OGk9nNGTYGTODzTOp2RP76, __p_H5JhziYlX8SO5wdTjsy9kw = __p_H5JhziYlX8SO5wdTjsy9kw, __p_EdfNHLnXnU1O61AsUnavMP = __p_EdfNHLnXnU1O61AsUnavMP, __pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd = __pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd} : that_0;
                else
                {
                    this.__p_UcdVJkCZWBWNmP2Vcoxjcd = __p_UcdVJkCZWBWNmP2Vcoxjcd;
                    this.__p_OGk9nNGTYGTODzTOp2RP76 = __p_OGk9nNGTYGTODzTOp2RP76;
                    this.__p_H5JhziYlX8SO5wdTjsy9kw = __p_H5JhziYlX8SO5wdTjsy9kw;
                    this.__p_EdfNHLnXnU1O61AsUnavMP = __p_EdfNHLnXnU1O61AsUnavMP;
                    this.__pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd = __pin_group_Arguments_In_UcdVJkCZWBWNmP2Vcoxjcd;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 344563U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "BuCdIzxmdLrLbuWLZUdKVD", Name = "DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD")]
    [n2.SerializableAttribute]
    public class DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n28.DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD Create(n1.NodeContext Node_Context)
        {
            var instance = new DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n28.DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD CreateDefault()
        {
            var instance = new DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n28.DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD Update(n5.GpuValue<n22.Vector2> TDomain_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n5.GpuValue<n22.Vector2> Size_In, n34.DomainRepeat2D Op_In, out n5.GpuValue<n22.Vector2> Output_Out, out n5.GpuValue<n22.Vector2> Cell_Out)
        {
            string __pad_LIGEH9FUEOGOA4pzeFnKqc_0 = __slot_LIGEH9FUEOGOA4pzeFnKqc;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_CpNWGmtETOuP0Yac2kRAJi;
            if (manager_3 is null)
            {
                manager_3 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string, n5.GpuValue<n22.Vector2>, n34.DomainRepeat2D>, n2.ValueTuple<n5.GpuValue<n22.Vector2>, n5.GpuValue<n22.Vector2>>>((default(n5.GpuValue<n22.Vector2>), default(n5.GpuValue<n22.Vector2>)));
            }

            var inputs_4 = (TDomain_In, __pad_LIGEH9FUEOGOA4pzeFnKqc_0, Size_In, Op_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__V8mLHcuIiqzOloO9apUIy1>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __V8mLHcuIiqzOloO9apUIy1(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf = n17._Operations_.CreateDefault<string>(), __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf = n17._Operations_.CreateDefault<n5.InputModifier>(), __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN = n17._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "I977qM4UvVQMwgkJ5MuVQN", 344605U);
                    var Output_9 = n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<n22.Vector2, n11.Spread<n5.InputModifier>>.Create(Node_Context: Node_Context_8);
                    state_7.__p_I977qM4UvVQMwgkJ5MuVQN = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "KRkcjnIvRMwMHMZL78eyL4", 344670U);
                    var Output_11 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.Create(Node_Context: Node_Context_10);
                    state_7.__p_KRkcjnIvRMwMHMZL78eyL4 = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "RqRXLbTuaiKL5uzmtfIvwz", 344705U);
                    var Output_13 = n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v.Create(Node_Context: Node_Context_12);
                    state_7.__p_RqRXLbTuaiKL5uzmtfIvwz = Output_13;
                    n35._Operations_.DomainRepeat2DID(Output_Out: out string Output_14);
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "MAdevikGC0QOAfAHTptvOw", 344711U);
                    var Output_16 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_15, ID_In: Output_14);
                    state_7.__p_MAdevikGC0QOAfAHTptvOw = Output_16;
                    n35._Operations_.DomainRepeatCell2DID(Output_Out: out string Output_17);
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Chq2oPOWLcAODxJ8XeZIqZ", 344716U);
                    var Output_19 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_18, ID_In: Output_17);
                    state_7.__p_Chq2oPOWLcAODxJ8XeZIqZ = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "OkYN0HGElsoONjaha3pCao", 344794U);
                    var Output_21 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n22.Vector2>.Create(Node_Context: Node_Context_20);
                    state_7.__p_OkYN0HGElsoONjaha3pCao = Output_21;
                }

                string __pad_JBqOEpHJBh3P20YXbK4SZV_22 = __slot_JBqOEpHJBh3P20YXbK4SZV;
                n5.InputModifier __pad_GoaBLtSFDsCLiUhAMgbkL1_23 = __slot_GoaBLtSFDsCLiUhAMgbkL1;
                n5.InputModifier __pad_PvmE1Ike99DLBh5jejhqmp_24 = __slot_PvmE1Ike99DLBh5jejhqmp;
                n5.InputModifier __pad_PMNW36ZlvPCP23I8OwitN0_25 = __slot_PMNW36ZlvPCP23I8OwitN0;
                n22.Vector2 __pad_HnXQbi1O65xO1ANrO4toCI_26 = __slot_HnXQbi1O65xO1ANrO4toCI;
                int Id_27 = 0;
                var State_Output_29 = state_7.__p_KRkcjnIvRMwMHMZL78eyL4.Update(The_Override_In: TDomain_In, Id_In: Id_27, Output_Out: out n5.GpuValue<n22.Vector2> Output_28);
                var Output_31 = state_7.__p_OkYN0HGElsoONjaha3pCao.Update(Value_In: __pad_HnXQbi1O65xO1ANrO4toCI_26, GpuValue_Out: out n5.GpuValue<n22.Vector2> GpuValue_30);
                var Output_33 = state_7.__p_RqRXLbTuaiKL5uzmtfIvwz.Update(Singleton_Out: out string Singleton_32);
                var builder_34 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf, 1);
                builder_34.Add(Singleton_32);
                var __pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf_35 = builder_34.Commit();
                n17._Operations_.FromValue<string>(Input_In: __pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf_35, Result_Out: out n11.Spread<string> Result_36);
                n8.IEnumerable<string> Mixins_37 = (n8.IEnumerable<string>)Result_36;
                int Op_38 = (int)Op_In;
                n35._Operations_.TemplateValues(Op_In: Op_38, Output_Out: out n15.ImmutableDictionary<string, string> Output_39);
                var builder_40 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf, 3);
                builder_40.Add(__pad_GoaBLtSFDsCLiUhAMgbkL1_23);
                builder_40.Add(__pad_PvmE1Ike99DLBh5jejhqmp_24);
                builder_40.Add(__pad_PMNW36ZlvPCP23I8OwitN0_25);
                var __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf_41 = builder_40.Commit();
                n17._Operations_.Cons<n5.InputModifier>(Input_In: __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf_41, Result_Out: out n11.Spread<n5.InputModifier> Result_42);
                n5.GpuValue<n22.Vector2> Default_Result_43 = default(n5.GpuValue<n22.Vector2>);
                n11.Spread<n5.IFunctionInvokeNode> Functions_44 = n17._Operations_.CreateDefault<n5.IFunctionInvokeNode>();
                bool Is_Groupable_45 = false;
                var builder_46 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN, 3);
                builder_46.Add(Output_28);
                builder_46.Add(Size_In);
                builder_46.Add(GpuValue_30);
                var __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN_47 = builder_46.Commit();
                var State_Output_50 = state_7.__p_I977qM4UvVQMwgkJ5MuVQN.Update(Arguments_In: __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN_47, Function_Name_In: __pad_JBqOEpHJBh3P20YXbK4SZV_22, Code_Template_In: __pad_LIGEH9FUEOGOA4pzeFnKqc_0, Default_Result_In: Default_Result_43, Functions_In: Functions_44, Mixins_In: Mixins_37, Template_Values_In: Output_39, Is_Groupable_In: Is_Groupable_45, The_Modifiers_In: Result_42, Output_Out: out n5.GpuValue<n22.Vector2> Output_48, AdditionalOutputs_Out: out n11.Spread<n5.AbstractGpuValue> AdditionalOutputs_49);
                var AdditionalOutputs_51 = (n5.AbstractGpuValue)AdditionalOutputs_49[0];
                bool Update_52 = true;
                var Output_53 = state_7.__p_MAdevikGC0QOAfAHTptvOw;
                if (Update_52)
                {
                    Output_53 = state_7.__p_MAdevikGC0QOAfAHTptvOw.Update(Input_In: Output_48);
                }

                n5.GpuValue<n22.Vector2> Default_54 = default(n5.GpuValue<n22.Vector2>);
                n36._Operations_.CastAs<n5.GpuValue<n22.Vector2>>(Input_In: AdditionalOutputs_51, Default_In: Default_54, Result_Out: out n5.GpuValue<n22.Vector2> Result_55, Success_Out: out bool Success_56);
                bool Update_57 = true;
                var Output_58 = state_7.__p_Chq2oPOWLcAODxJ8XeZIqZ;
                if (Update_57)
                {
                    Output_58 = state_7.__p_Chq2oPOWLcAODxJ8XeZIqZ.Update(Input_In: AdditionalOutputs_51);
                }

                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_29 != state_7.__p_KRkcjnIvRMwMHMZL78eyL4 || Output_31 != state_7.__p_OkYN0HGElsoONjaha3pCao || Output_33 != state_7.__p_RqRXLbTuaiKL5uzmtfIvwz || __pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf_35 != state_7.__pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf || __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf_41 != state_7.__pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf || __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN_47 != state_7.__pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN || State_Output_50 != state_7.__p_I977qM4UvVQMwgkJ5MuVQN || Output_53 != state_7.__p_MAdevikGC0QOAfAHTptvOw || Output_58 != state_7.__p_Chq2oPOWLcAODxJ8XeZIqZ ? new __V8mLHcuIiqzOloO9apUIy1(state_7)
                    {__p_KRkcjnIvRMwMHMZL78eyL4 = State_Output_29, __p_OkYN0HGElsoONjaha3pCao = Output_31, __p_RqRXLbTuaiKL5uzmtfIvwz = Output_33, __pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf = __pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf_35, __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf = __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf_41, __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN = __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN_47, __p_I977qM4UvVQMwgkJ5MuVQN = State_Output_50, __p_MAdevikGC0QOAfAHTptvOw = Output_53, __p_Chq2oPOWLcAODxJ8XeZIqZ = Output_58} : state_7;
                else
                {
                    state_7.__p_KRkcjnIvRMwMHMZL78eyL4 = State_Output_29;
                    state_7.__p_OkYN0HGElsoONjaha3pCao = Output_31;
                    state_7.__p_RqRXLbTuaiKL5uzmtfIvwz = Output_33;
                    state_7.__pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf = __pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf_35;
                    state_7.__pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf = __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf_41;
                    state_7.__pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN = __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN_47;
                    state_7.__p_I977qM4UvVQMwgkJ5MuVQN = State_Output_50;
                    state_7.__p_MAdevikGC0QOAfAHTptvOw = Output_53;
                    state_7.__p_Chq2oPOWLcAODxJ8XeZIqZ = Output_58;
                }

                outputs_5 = (Output_48, Result_55);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var(__auto_59, __auto_60) = outputs_5;
            Output_Out = __auto_59;
            Cell_Out = __auto_60;
            n28.DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD that_61 = this;
            if (this.__GetContext__().IsImmutable)
                that_61 = manager_3 != this.__cache_CpNWGmtETOuP0Yac2kRAJi ? new DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD(this)
                {__cache_CpNWGmtETOuP0Yac2kRAJi = manager_3} : that_61;
            else
            {
                this.__cache_CpNWGmtETOuP0Yac2kRAJi = manager_3;
            }

            return that_61;
        }

        public n28.DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n28.DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD that_0 = this;
            this.__cache_CpNWGmtETOuP0Yac2kRAJi = null;
            return that_0;
        }

        public n28.DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD __CreateDefault__()
        {
            n28.DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD that_0 = this;
            this.__cache_CpNWGmtETOuP0Yac2kRAJi = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_CpNWGmtETOuP0Yac2kRAJi);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 344831U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "LIGEH9FUEOGOA4pzeFnKqc", Name = "__slot_LIGEH9FUEOGOA4pzeFnKqc")]
        public static string __slot_LIGEH9FUEOGOA4pzeFnKqc = "float2 ${signature}(float2 p, float2 size, out float2 cell) \r\n{\r\n\tcell = 0.;\r\n\tcell.${SWIZZLE} = ${OP}(p.${SWIZZLE}, size);\r\n\treturn p;\r\n}";
        [n1.ElementAttribute(TracingId = 344569U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "CpNWGmtETOuP0Yac2kRAJi", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string, n5.GpuValue<n22.Vector2>, n34.DomainRepeat2D>, n2.ValueTuple<n5.GpuValue<n22.Vector2>, n5.GpuValue<n22.Vector2>>> __cache_CpNWGmtETOuP0Yac2kRAJi = null;
        [n1.ElementAttribute(TracingId = 344707U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "JBqOEpHJBh3P20YXbK4SZV", Name = "__slot_JBqOEpHJBh3P20YXbK4SZV")]
        public static string __slot_JBqOEpHJBh3P20YXbK4SZV = "DomainRepeat2D";
        [n1.ElementAttribute(TracingId = 344765U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "GoaBLtSFDsCLiUhAMgbkL1", Name = "__slot_GoaBLtSFDsCLiUhAMgbkL1")]
        public static n5.InputModifier __slot_GoaBLtSFDsCLiUhAMgbkL1 = n1.CompilationHelper.Deserialize<n5.InputModifier>("In", false, "MzilLTk6yNROg5SWTCtzZM", "GoaBLtSFDsCLiUhAMgbkL1");
        [n1.ElementAttribute(TracingId = 344770U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "PvmE1Ike99DLBh5jejhqmp", Name = "__slot_PvmE1Ike99DLBh5jejhqmp")]
        public static n5.InputModifier __slot_PvmE1Ike99DLBh5jejhqmp = n1.CompilationHelper.Deserialize<n5.InputModifier>("In", false, "MzilLTk6yNROg5SWTCtzZM", "PvmE1Ike99DLBh5jejhqmp");
        [n1.ElementAttribute(TracingId = 344777U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "PMNW36ZlvPCP23I8OwitN0", Name = "__slot_PMNW36ZlvPCP23I8OwitN0")]
        public static n5.InputModifier __slot_PMNW36ZlvPCP23I8OwitN0 = n1.CompilationHelper.Deserialize<n5.InputModifier>("Out", false, "MzilLTk6yNROg5SWTCtzZM", "PMNW36ZlvPCP23I8OwitN0");
        [n1.ElementAttribute(TracingId = 344708U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "HnXQbi1O65xO1ANrO4toCI", Name = "__slot_HnXQbi1O65xO1ANrO4toCI")]
        public static n22.Vector2 __slot_HnXQbi1O65xO1ANrO4toCI = n1.CompilationHelper.Deserialize<n22.Vector2>("0, 0", false, "MzilLTk6yNROg5SWTCtzZM", "HnXQbi1O65xO1ANrO4toCI");
        static DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD()
        {
        }

        public DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD(DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD other): base(other)
        {
            this.__cache_CpNWGmtETOuP0Yac2kRAJi = other.__cache_CpNWGmtETOuP0Yac2kRAJi;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_CpNWGmtETOuP0Yac2kRAJi", in __cache_CpNWGmtETOuP0Yac2kRAJi));
        }

        internal DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string, n5.GpuValue<n22.Vector2>, n34.DomainRepeat2D>, n2.ValueTuple<n5.GpuValue<n22.Vector2>, n5.GpuValue<n22.Vector2>>> __cache_CpNWGmtETOuP0Yac2kRAJi)
        {
            n28.DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_CpNWGmtETOuP0Yac2kRAJi != this.__cache_CpNWGmtETOuP0Yac2kRAJi ? new DomainRepeat_BuCdIzxmdLrLbuWLZUdKVD(this)
                {__cache_CpNWGmtETOuP0Yac2kRAJi = __cache_CpNWGmtETOuP0Yac2kRAJi} : that_0;
            else
            {
                this.__cache_CpNWGmtETOuP0Yac2kRAJi = __cache_CpNWGmtETOuP0Yac2kRAJi;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "V8mLHcuIiqzOloO9apUIy1", Name = "__V8mLHcuIiqzOloO9apUIy1")]
        [n2.SerializableAttribute]
        public class __V8mLHcuIiqzOloO9apUIy1 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_I977qM4UvVQMwgkJ5MuVQN);
                n1.CompilationHelper.SafeDispose(this.__p_KRkcjnIvRMwMHMZL78eyL4);
                n1.CompilationHelper.SafeDispose(this.__p_RqRXLbTuaiKL5uzmtfIvwz);
                n1.CompilationHelper.SafeDispose(this.__p_MAdevikGC0QOAfAHTptvOw);
                n1.CompilationHelper.SafeDispose(this.__p_Chq2oPOWLcAODxJ8XeZIqZ);
                n1.CompilationHelper.SafeDispose(this.__p_OkYN0HGElsoONjaha3pCao);
                return;
            }

            [n1.ElementAttribute(TracingId = 344605U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "I977qM4UvVQMwgkJ5MuVQN", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<n22.Vector2, n11.Spread<n5.InputModifier>> __p_I977qM4UvVQMwgkJ5MuVQN;
            [n1.ElementAttribute(TracingId = 344670U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "KRkcjnIvRMwMHMZL78eyL4", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_KRkcjnIvRMwMHMZL78eyL4;
            [n1.ElementAttribute(TracingId = 344705U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "RqRXLbTuaiKL5uzmtfIvwz", Name = "FuseCoreDomain (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_RqRXLbTuaiKL5uzmtfIvwz;
            [n1.ElementAttribute(TracingId = 344711U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "MAdevikGC0QOAfAHTptvOw", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_MAdevikGC0QOAfAHTptvOw;
            [n1.ElementAttribute(TracingId = 344716U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Chq2oPOWLcAODxJ8XeZIqZ", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Chq2oPOWLcAODxJ8XeZIqZ;
            [n1.ElementAttribute(TracingId = 344794U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "OkYN0HGElsoONjaha3pCao", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n22.Vector2> __p_OkYN0HGElsoONjaha3pCao;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<string> __pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf = default(n11.Spread<string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.InputModifier> __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf = default(n11.Spread<n5.InputModifier>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN = default(n11.Spread<n5.AbstractGpuValue>);
            public __V8mLHcuIiqzOloO9apUIy1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __V8mLHcuIiqzOloO9apUIy1(__V8mLHcuIiqzOloO9apUIy1 other): base(other)
            {
                this.__p_I977qM4UvVQMwgkJ5MuVQN = other.__p_I977qM4UvVQMwgkJ5MuVQN;
                this.__p_KRkcjnIvRMwMHMZL78eyL4 = other.__p_KRkcjnIvRMwMHMZL78eyL4;
                this.__p_RqRXLbTuaiKL5uzmtfIvwz = other.__p_RqRXLbTuaiKL5uzmtfIvwz;
                this.__p_MAdevikGC0QOAfAHTptvOw = other.__p_MAdevikGC0QOAfAHTptvOw;
                this.__p_Chq2oPOWLcAODxJ8XeZIqZ = other.__p_Chq2oPOWLcAODxJ8XeZIqZ;
                this.__p_OkYN0HGElsoONjaha3pCao = other.__p_OkYN0HGElsoONjaha3pCao;
                this.__pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf = other.__pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf;
                this.__pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf = other.__pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf;
                this.__pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN = other.__pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_I977qM4UvVQMwgkJ5MuVQN", in __p_I977qM4UvVQMwgkJ5MuVQN), n1.CompilationHelper.GetValueOrExisting(values, "__p_KRkcjnIvRMwMHMZL78eyL4", in __p_KRkcjnIvRMwMHMZL78eyL4), n1.CompilationHelper.GetValueOrExisting(values, "__p_RqRXLbTuaiKL5uzmtfIvwz", in __p_RqRXLbTuaiKL5uzmtfIvwz), n1.CompilationHelper.GetValueOrExisting(values, "__p_MAdevikGC0QOAfAHTptvOw", in __p_MAdevikGC0QOAfAHTptvOw), n1.CompilationHelper.GetValueOrExisting(values, "__p_Chq2oPOWLcAODxJ8XeZIqZ", in __p_Chq2oPOWLcAODxJ8XeZIqZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_OkYN0HGElsoONjaha3pCao", in __p_OkYN0HGElsoONjaha3pCao), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf", in __pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf", in __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN", in __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN));
            }

            internal __V8mLHcuIiqzOloO9apUIy1 __WITH__(n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<n22.Vector2, n11.Spread<n5.InputModifier>> __p_I977qM4UvVQMwgkJ5MuVQN, n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_KRkcjnIvRMwMHMZL78eyL4, n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_RqRXLbTuaiKL5uzmtfIvwz, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_MAdevikGC0QOAfAHTptvOw, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Chq2oPOWLcAODxJ8XeZIqZ, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n22.Vector2> __p_OkYN0HGElsoONjaha3pCao, n11.Spread<string> __pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf, n11.Spread<n5.InputModifier> __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf, n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN)
            {
                __V8mLHcuIiqzOloO9apUIy1 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_I977qM4UvVQMwgkJ5MuVQN != this.__p_I977qM4UvVQMwgkJ5MuVQN || __p_KRkcjnIvRMwMHMZL78eyL4 != this.__p_KRkcjnIvRMwMHMZL78eyL4 || __p_RqRXLbTuaiKL5uzmtfIvwz != this.__p_RqRXLbTuaiKL5uzmtfIvwz || __p_MAdevikGC0QOAfAHTptvOw != this.__p_MAdevikGC0QOAfAHTptvOw || __p_Chq2oPOWLcAODxJ8XeZIqZ != this.__p_Chq2oPOWLcAODxJ8XeZIqZ || __p_OkYN0HGElsoONjaha3pCao != this.__p_OkYN0HGElsoONjaha3pCao || __pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf != this.__pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf || __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf != this.__pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf || __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN != this.__pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN ? new __V8mLHcuIiqzOloO9apUIy1(this)
                    {__p_I977qM4UvVQMwgkJ5MuVQN = __p_I977qM4UvVQMwgkJ5MuVQN, __p_KRkcjnIvRMwMHMZL78eyL4 = __p_KRkcjnIvRMwMHMZL78eyL4, __p_RqRXLbTuaiKL5uzmtfIvwz = __p_RqRXLbTuaiKL5uzmtfIvwz, __p_MAdevikGC0QOAfAHTptvOw = __p_MAdevikGC0QOAfAHTptvOw, __p_Chq2oPOWLcAODxJ8XeZIqZ = __p_Chq2oPOWLcAODxJ8XeZIqZ, __p_OkYN0HGElsoONjaha3pCao = __p_OkYN0HGElsoONjaha3pCao, __pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf = __pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf, __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf = __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf, __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN = __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN} : that_0;
                else
                {
                    this.__p_I977qM4UvVQMwgkJ5MuVQN = __p_I977qM4UvVQMwgkJ5MuVQN;
                    this.__p_KRkcjnIvRMwMHMZL78eyL4 = __p_KRkcjnIvRMwMHMZL78eyL4;
                    this.__p_RqRXLbTuaiKL5uzmtfIvwz = __p_RqRXLbTuaiKL5uzmtfIvwz;
                    this.__p_MAdevikGC0QOAfAHTptvOw = __p_MAdevikGC0QOAfAHTptvOw;
                    this.__p_Chq2oPOWLcAODxJ8XeZIqZ = __p_Chq2oPOWLcAODxJ8XeZIqZ;
                    this.__p_OkYN0HGElsoONjaha3pCao = __p_OkYN0HGElsoONjaha3pCao;
                    this.__pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf = __pin_group_Input_In_CgNY21AelkHMVj5cJ5QyPf;
                    this.__pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf = __pin_group_Input_In_URdXs7n5jQaNXnKjhqgGPf;
                    this.__pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN = __pin_group_Arguments_In_I977qM4UvVQMwgkJ5MuVQN;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 345144U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "FhkZEav80yPL8iAoNiRyaL", Name = "ScreenToUV_FhkZEav80yPL8iAoNiRyaL")]
    [n2.SerializableAttribute]
    public class ScreenToUV_FhkZEav80yPL8iAoNiRyaL : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n28.ScreenToUV_FhkZEav80yPL8iAoNiRyaL Create(n1.NodeContext Node_Context)
        {
            var instance = new ScreenToUV_FhkZEav80yPL8iAoNiRyaL(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n28.ScreenToUV_FhkZEav80yPL8iAoNiRyaL CreateDefault()
        {
            var instance = new ScreenToUV_FhkZEav80yPL8iAoNiRyaL(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n28.ScreenToUV_FhkZEav80yPL8iAoNiRyaL Update(n5.GpuValue<n22.Vector2> Input_In, out n5.GpuValue<n22.Vector2> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_RSKQHsItH9IOQsSjU6dUPE;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>>(n2.ValueTuple.Create(default(n5.GpuValue<n22.Vector2>)));
            }

            var inputs_3 = n2.ValueTuple.Create(Input_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__H13yGwAbwooOCoQlJvkrcL>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __H13yGwAbwooOCoQlJvkrcL(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc = n17._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "EAJTBtThDg4NYXVitxzUuc", 345167U);
                    var Output_8 = n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2>.Create(Node_Context: Node_Context_7);
                    state_6.__p_EAJTBtThDg4NYXVitxzUuc = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "SoDw6lZi5UoLYvGFVlmeQ7", 345182U);
                    var Output_10 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.Create(Node_Context: Node_Context_9);
                    state_6.__p_SoDw6lZi5UoLYvGFVlmeQ7 = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Lwv9UnKX1tDOasHCGVpTK9", 345192U);
                    var Output_12 = n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v.Create(Node_Context: Node_Context_11);
                    state_6.__p_Lwv9UnKX1tDOasHCGVpTK9 = Output_12;
                    n37._Operations_.ScreenToUV2DID(Output_Out: out string Output_13);
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Kf4PLrspVjiPxzpyMrZUxU", 345198U);
                    var Output_15 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_14, ID_In: Output_13);
                    state_6.__p_Kf4PLrspVjiPxzpyMrZUxU = Output_15;
                }

                string __pad_Qpxxf4rQ59vQNsJlrfpVDl_16 = __slot_Qpxxf4rQ59vQNsJlrfpVDl;
                int Id_17 = 0;
                var State_Output_19 = state_6.__p_SoDw6lZi5UoLYvGFVlmeQ7.Update(The_Override_In: Input_In, Id_In: Id_17, Output_Out: out n5.GpuValue<n22.Vector2> Output_18);
                var Output_21 = state_6.__p_Lwv9UnKX1tDOasHCGVpTK9.Update(Singleton_Out: out string Singleton_20);
                n5.GpuValue<n22.Vector2> Default_22 = default(n5.GpuValue<n22.Vector2>);
                bool Is_Groupable_23 = false;
                n8.IEnumerable<n5.InputModifier> The_Modifiers_24 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_25 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc, 1);
                builder_25.Add(Output_18);
                var __pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc_26 = builder_25.Commit();
                var State_Output_29 = state_6.__p_EAJTBtThDg4NYXVitxzUuc.Update(Arguments_In: __pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc_26, Function_Name_In: __pad_Qpxxf4rQ59vQNsJlrfpVDl_16, Default_In: Default_22, Mixins_In: Singleton_20, Is_Groupable_In: Is_Groupable_23, The_Modifiers_In: The_Modifiers_24, Output_Out: out n5.GpuValue<n22.Vector2> Output_27, Additional_Outputs_Out: out n11.Spread<n5.AbstractGpuValue> Additional_Outputs_28);
                bool Update_30 = true;
                var Output_31 = state_6.__p_Kf4PLrspVjiPxzpyMrZUxU;
                if (Update_30)
                {
                    Output_31 = state_6.__p_Kf4PLrspVjiPxzpyMrZUxU.Update(Input_In: Output_27);
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_19 != state_6.__p_SoDw6lZi5UoLYvGFVlmeQ7 || Output_21 != state_6.__p_Lwv9UnKX1tDOasHCGVpTK9 || __pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc_26 != state_6.__pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc || State_Output_29 != state_6.__p_EAJTBtThDg4NYXVitxzUuc || Output_31 != state_6.__p_Kf4PLrspVjiPxzpyMrZUxU ? new __H13yGwAbwooOCoQlJvkrcL(state_6)
                    {__p_SoDw6lZi5UoLYvGFVlmeQ7 = State_Output_19, __p_Lwv9UnKX1tDOasHCGVpTK9 = Output_21, __pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc = __pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc_26, __p_EAJTBtThDg4NYXVitxzUuc = State_Output_29, __p_Kf4PLrspVjiPxzpyMrZUxU = Output_31} : state_6;
                else
                {
                    state_6.__p_SoDw6lZi5UoLYvGFVlmeQ7 = State_Output_19;
                    state_6.__p_Lwv9UnKX1tDOasHCGVpTK9 = Output_21;
                    state_6.__pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc = __pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc_26;
                    state_6.__p_EAJTBtThDg4NYXVitxzUuc = State_Output_29;
                    state_6.__p_Kf4PLrspVjiPxzpyMrZUxU = Output_31;
                }

                outputs_4 = n2.ValueTuple.Create(Output_27);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_32 = outputs_4.Item1;
            Output_Out = __auto_32;
            n28.ScreenToUV_FhkZEav80yPL8iAoNiRyaL that_33 = this;
            if (this.__GetContext__().IsImmutable)
                that_33 = manager_2 != this.__cache_RSKQHsItH9IOQsSjU6dUPE ? new ScreenToUV_FhkZEav80yPL8iAoNiRyaL(this)
                {__cache_RSKQHsItH9IOQsSjU6dUPE = manager_2} : that_33;
            else
            {
                this.__cache_RSKQHsItH9IOQsSjU6dUPE = manager_2;
            }

            return that_33;
        }

        public n28.ScreenToUV_FhkZEav80yPL8iAoNiRyaL __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n28.ScreenToUV_FhkZEav80yPL8iAoNiRyaL that_0 = this;
            this.__cache_RSKQHsItH9IOQsSjU6dUPE = null;
            return that_0;
        }

        public n28.ScreenToUV_FhkZEav80yPL8iAoNiRyaL __CreateDefault__()
        {
            n28.ScreenToUV_FhkZEav80yPL8iAoNiRyaL that_0 = this;
            this.__cache_RSKQHsItH9IOQsSjU6dUPE = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_RSKQHsItH9IOQsSjU6dUPE);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 345148U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "RSKQHsItH9IOQsSjU6dUPE", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_RSKQHsItH9IOQsSjU6dUPE = null;
        [n1.ElementAttribute(TracingId = 345221U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Qpxxf4rQ59vQNsJlrfpVDl", Name = "__slot_Qpxxf4rQ59vQNsJlrfpVDl")]
        public static string __slot_Qpxxf4rQ59vQNsJlrfpVDl = "screenToUV";
        static ScreenToUV_FhkZEav80yPL8iAoNiRyaL()
        {
        }

        public ScreenToUV_FhkZEav80yPL8iAoNiRyaL(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ScreenToUV_FhkZEav80yPL8iAoNiRyaL(ScreenToUV_FhkZEav80yPL8iAoNiRyaL other): base(other)
        {
            this.__cache_RSKQHsItH9IOQsSjU6dUPE = other.__cache_RSKQHsItH9IOQsSjU6dUPE;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_RSKQHsItH9IOQsSjU6dUPE", in __cache_RSKQHsItH9IOQsSjU6dUPE));
        }

        internal ScreenToUV_FhkZEav80yPL8iAoNiRyaL __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_RSKQHsItH9IOQsSjU6dUPE)
        {
            n28.ScreenToUV_FhkZEav80yPL8iAoNiRyaL that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_RSKQHsItH9IOQsSjU6dUPE != this.__cache_RSKQHsItH9IOQsSjU6dUPE ? new ScreenToUV_FhkZEav80yPL8iAoNiRyaL(this)
                {__cache_RSKQHsItH9IOQsSjU6dUPE = __cache_RSKQHsItH9IOQsSjU6dUPE} : that_0;
            else
            {
                this.__cache_RSKQHsItH9IOQsSjU6dUPE = __cache_RSKQHsItH9IOQsSjU6dUPE;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "H13yGwAbwooOCoQlJvkrcL", Name = "__H13yGwAbwooOCoQlJvkrcL")]
        [n2.SerializableAttribute]
        public class __H13yGwAbwooOCoQlJvkrcL : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_EAJTBtThDg4NYXVitxzUuc);
                n1.CompilationHelper.SafeDispose(this.__p_SoDw6lZi5UoLYvGFVlmeQ7);
                n1.CompilationHelper.SafeDispose(this.__p_Lwv9UnKX1tDOasHCGVpTK9);
                n1.CompilationHelper.SafeDispose(this.__p_Kf4PLrspVjiPxzpyMrZUxU);
                return;
            }

            [n1.ElementAttribute(TracingId = 345167U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "EAJTBtThDg4NYXVitxzUuc", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2> __p_EAJTBtThDg4NYXVitxzUuc;
            [n1.ElementAttribute(TracingId = 345182U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "SoDw6lZi5UoLYvGFVlmeQ7", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_SoDw6lZi5UoLYvGFVlmeQ7;
            [n1.ElementAttribute(TracingId = 345192U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Lwv9UnKX1tDOasHCGVpTK9", Name = "FuseCoreDomain (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_Lwv9UnKX1tDOasHCGVpTK9;
            [n1.ElementAttribute(TracingId = 345198U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Kf4PLrspVjiPxzpyMrZUxU", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Kf4PLrspVjiPxzpyMrZUxU;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc = default(n11.Spread<n5.AbstractGpuValue>);
            public __H13yGwAbwooOCoQlJvkrcL(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __H13yGwAbwooOCoQlJvkrcL(__H13yGwAbwooOCoQlJvkrcL other): base(other)
            {
                this.__p_EAJTBtThDg4NYXVitxzUuc = other.__p_EAJTBtThDg4NYXVitxzUuc;
                this.__p_SoDw6lZi5UoLYvGFVlmeQ7 = other.__p_SoDw6lZi5UoLYvGFVlmeQ7;
                this.__p_Lwv9UnKX1tDOasHCGVpTK9 = other.__p_Lwv9UnKX1tDOasHCGVpTK9;
                this.__p_Kf4PLrspVjiPxzpyMrZUxU = other.__p_Kf4PLrspVjiPxzpyMrZUxU;
                this.__pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc = other.__pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_EAJTBtThDg4NYXVitxzUuc", in __p_EAJTBtThDg4NYXVitxzUuc), n1.CompilationHelper.GetValueOrExisting(values, "__p_SoDw6lZi5UoLYvGFVlmeQ7", in __p_SoDw6lZi5UoLYvGFVlmeQ7), n1.CompilationHelper.GetValueOrExisting(values, "__p_Lwv9UnKX1tDOasHCGVpTK9", in __p_Lwv9UnKX1tDOasHCGVpTK9), n1.CompilationHelper.GetValueOrExisting(values, "__p_Kf4PLrspVjiPxzpyMrZUxU", in __p_Kf4PLrspVjiPxzpyMrZUxU), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc", in __pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc));
            }

            internal __H13yGwAbwooOCoQlJvkrcL __WITH__(n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2> __p_EAJTBtThDg4NYXVitxzUuc, n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_SoDw6lZi5UoLYvGFVlmeQ7, n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_Lwv9UnKX1tDOasHCGVpTK9, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Kf4PLrspVjiPxzpyMrZUxU, n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc)
            {
                __H13yGwAbwooOCoQlJvkrcL that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_EAJTBtThDg4NYXVitxzUuc != this.__p_EAJTBtThDg4NYXVitxzUuc || __p_SoDw6lZi5UoLYvGFVlmeQ7 != this.__p_SoDw6lZi5UoLYvGFVlmeQ7 || __p_Lwv9UnKX1tDOasHCGVpTK9 != this.__p_Lwv9UnKX1tDOasHCGVpTK9 || __p_Kf4PLrspVjiPxzpyMrZUxU != this.__p_Kf4PLrspVjiPxzpyMrZUxU || __pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc != this.__pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc ? new __H13yGwAbwooOCoQlJvkrcL(this)
                    {__p_EAJTBtThDg4NYXVitxzUuc = __p_EAJTBtThDg4NYXVitxzUuc, __p_SoDw6lZi5UoLYvGFVlmeQ7 = __p_SoDw6lZi5UoLYvGFVlmeQ7, __p_Lwv9UnKX1tDOasHCGVpTK9 = __p_Lwv9UnKX1tDOasHCGVpTK9, __p_Kf4PLrspVjiPxzpyMrZUxU = __p_Kf4PLrspVjiPxzpyMrZUxU, __pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc = __pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc} : that_0;
                else
                {
                    this.__p_EAJTBtThDg4NYXVitxzUuc = __p_EAJTBtThDg4NYXVitxzUuc;
                    this.__p_SoDw6lZi5UoLYvGFVlmeQ7 = __p_SoDw6lZi5UoLYvGFVlmeQ7;
                    this.__p_Lwv9UnKX1tDOasHCGVpTK9 = __p_Lwv9UnKX1tDOasHCGVpTK9;
                    this.__p_Kf4PLrspVjiPxzpyMrZUxU = __p_Kf4PLrspVjiPxzpyMrZUxU;
                    this.__pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc = __pin_group_Arguments_In_EAJTBtThDg4NYXVitxzUuc;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 345626U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "KgjgRSn8shELYZ6kqgXk4b", Name = "UVToScreen_KgjgRSn8shELYZ6kqgXk4b")]
    [n2.SerializableAttribute]
    public class UVToScreen_KgjgRSn8shELYZ6kqgXk4b : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n28.UVToScreen_KgjgRSn8shELYZ6kqgXk4b Create(n1.NodeContext Node_Context)
        {
            var instance = new UVToScreen_KgjgRSn8shELYZ6kqgXk4b(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n28.UVToScreen_KgjgRSn8shELYZ6kqgXk4b CreateDefault()
        {
            var instance = new UVToScreen_KgjgRSn8shELYZ6kqgXk4b(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n28.UVToScreen_KgjgRSn8shELYZ6kqgXk4b Update(n5.GpuValue<n22.Vector2> Input_In, out n5.GpuValue<n22.Vector2> Output_Out)
        {
            string __pad_FcW5dBP6i99MeFQroTCrsw_0 = __slot_FcW5dBP6i99MeFQroTCrsw;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_O8U137dTNpHLqUEGchAxdP;
            if (manager_3 is null)
            {
                manager_3 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>>(n2.ValueTuple.Create(default(n5.GpuValue<n22.Vector2>)));
            }

            var inputs_4 = (Input_In, __pad_FcW5dBP6i99MeFQroTCrsw_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__EhoeeX5eoacNeDfZpC2gDG>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __EhoeeX5eoacNeDfZpC2gDG(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a = n17._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "JbhiByB62mBPaeJq1PRm6a", 345645U);
                    var Output_9 = n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2>.Create(Node_Context: Node_Context_8);
                    state_7.__p_JbhiByB62mBPaeJq1PRm6a = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "SHZlTlQ6I3NLFjQdSxZ9bW", 345658U);
                    var Output_11 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.Create(Node_Context: Node_Context_10);
                    state_7.__p_SHZlTlQ6I3NLFjQdSxZ9bW = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "UEpJ2VhpjfTPGRq34r5jtr", 345663U);
                    var Output_13 = n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v.Create(Node_Context: Node_Context_12);
                    state_7.__p_UEpJ2VhpjfTPGRq34r5jtr = Output_13;
                    n38._Operations_.UVToScreen2DID(Output_Out: out string Output_14);
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "QwE3yqEm6rfQNYoNayNpZG", 345666U);
                    var Output_16 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_15, ID_In: Output_14);
                    state_7.__p_QwE3yqEm6rfQNYoNayNpZG = Output_16;
                }

                int Id_17 = 0;
                var State_Output_19 = state_7.__p_SHZlTlQ6I3NLFjQdSxZ9bW.Update(The_Override_In: Input_In, Id_In: Id_17, Output_Out: out n5.GpuValue<n22.Vector2> Output_18);
                var Output_21 = state_7.__p_UEpJ2VhpjfTPGRq34r5jtr.Update(Singleton_Out: out string Singleton_20);
                n5.GpuValue<n22.Vector2> Default_22 = default(n5.GpuValue<n22.Vector2>);
                bool Is_Groupable_23 = false;
                n8.IEnumerable<n5.InputModifier> The_Modifiers_24 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_25 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a, 1);
                builder_25.Add(Output_18);
                var __pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a_26 = builder_25.Commit();
                var State_Output_29 = state_7.__p_JbhiByB62mBPaeJq1PRm6a.Update(Arguments_In: __pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a_26, Function_Name_In: __pad_FcW5dBP6i99MeFQroTCrsw_0, Default_In: Default_22, Mixins_In: Singleton_20, Is_Groupable_In: Is_Groupable_23, The_Modifiers_In: The_Modifiers_24, Output_Out: out n5.GpuValue<n22.Vector2> Output_27, Additional_Outputs_Out: out n11.Spread<n5.AbstractGpuValue> Additional_Outputs_28);
                bool Update_30 = true;
                var Output_31 = state_7.__p_QwE3yqEm6rfQNYoNayNpZG;
                if (Update_30)
                {
                    Output_31 = state_7.__p_QwE3yqEm6rfQNYoNayNpZG.Update(Input_In: Output_27);
                }

                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_19 != state_7.__p_SHZlTlQ6I3NLFjQdSxZ9bW || Output_21 != state_7.__p_UEpJ2VhpjfTPGRq34r5jtr || __pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a_26 != state_7.__pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a || State_Output_29 != state_7.__p_JbhiByB62mBPaeJq1PRm6a || Output_31 != state_7.__p_QwE3yqEm6rfQNYoNayNpZG ? new __EhoeeX5eoacNeDfZpC2gDG(state_7)
                    {__p_SHZlTlQ6I3NLFjQdSxZ9bW = State_Output_19, __p_UEpJ2VhpjfTPGRq34r5jtr = Output_21, __pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a = __pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a_26, __p_JbhiByB62mBPaeJq1PRm6a = State_Output_29, __p_QwE3yqEm6rfQNYoNayNpZG = Output_31} : state_7;
                else
                {
                    state_7.__p_SHZlTlQ6I3NLFjQdSxZ9bW = State_Output_19;
                    state_7.__p_UEpJ2VhpjfTPGRq34r5jtr = Output_21;
                    state_7.__pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a = __pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a_26;
                    state_7.__p_JbhiByB62mBPaeJq1PRm6a = State_Output_29;
                    state_7.__p_QwE3yqEm6rfQNYoNayNpZG = Output_31;
                }

                outputs_5 = n2.ValueTuple.Create(Output_27);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_32 = outputs_5.Item1;
            Output_Out = __auto_32;
            n28.UVToScreen_KgjgRSn8shELYZ6kqgXk4b that_33 = this;
            if (this.__GetContext__().IsImmutable)
                that_33 = manager_3 != this.__cache_O8U137dTNpHLqUEGchAxdP ? new UVToScreen_KgjgRSn8shELYZ6kqgXk4b(this)
                {__cache_O8U137dTNpHLqUEGchAxdP = manager_3} : that_33;
            else
            {
                this.__cache_O8U137dTNpHLqUEGchAxdP = manager_3;
            }

            return that_33;
        }

        public n28.UVToScreen_KgjgRSn8shELYZ6kqgXk4b __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n28.UVToScreen_KgjgRSn8shELYZ6kqgXk4b that_0 = this;
            this.__cache_O8U137dTNpHLqUEGchAxdP = null;
            return that_0;
        }

        public n28.UVToScreen_KgjgRSn8shELYZ6kqgXk4b __CreateDefault__()
        {
            n28.UVToScreen_KgjgRSn8shELYZ6kqgXk4b that_0 = this;
            this.__cache_O8U137dTNpHLqUEGchAxdP = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_O8U137dTNpHLqUEGchAxdP);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 345684U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "FcW5dBP6i99MeFQroTCrsw", Name = "__slot_FcW5dBP6i99MeFQroTCrsw")]
        public static string __slot_FcW5dBP6i99MeFQroTCrsw = "UVToScreen";
        [n1.ElementAttribute(TracingId = 345630U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "O8U137dTNpHLqUEGchAxdP", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_O8U137dTNpHLqUEGchAxdP = null;
        static UVToScreen_KgjgRSn8shELYZ6kqgXk4b()
        {
        }

        public UVToScreen_KgjgRSn8shELYZ6kqgXk4b(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal UVToScreen_KgjgRSn8shELYZ6kqgXk4b(UVToScreen_KgjgRSn8shELYZ6kqgXk4b other): base(other)
        {
            this.__cache_O8U137dTNpHLqUEGchAxdP = other.__cache_O8U137dTNpHLqUEGchAxdP;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_O8U137dTNpHLqUEGchAxdP", in __cache_O8U137dTNpHLqUEGchAxdP));
        }

        internal UVToScreen_KgjgRSn8shELYZ6kqgXk4b __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, string>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_O8U137dTNpHLqUEGchAxdP)
        {
            n28.UVToScreen_KgjgRSn8shELYZ6kqgXk4b that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_O8U137dTNpHLqUEGchAxdP != this.__cache_O8U137dTNpHLqUEGchAxdP ? new UVToScreen_KgjgRSn8shELYZ6kqgXk4b(this)
                {__cache_O8U137dTNpHLqUEGchAxdP = __cache_O8U137dTNpHLqUEGchAxdP} : that_0;
            else
            {
                this.__cache_O8U137dTNpHLqUEGchAxdP = __cache_O8U137dTNpHLqUEGchAxdP;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "EhoeeX5eoacNeDfZpC2gDG", Name = "__EhoeeX5eoacNeDfZpC2gDG")]
        [n2.SerializableAttribute]
        public class __EhoeeX5eoacNeDfZpC2gDG : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_JbhiByB62mBPaeJq1PRm6a);
                n1.CompilationHelper.SafeDispose(this.__p_SHZlTlQ6I3NLFjQdSxZ9bW);
                n1.CompilationHelper.SafeDispose(this.__p_UEpJ2VhpjfTPGRq34r5jtr);
                n1.CompilationHelper.SafeDispose(this.__p_QwE3yqEm6rfQNYoNayNpZG);
                return;
            }

            [n1.ElementAttribute(TracingId = 345645U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "JbhiByB62mBPaeJq1PRm6a", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2> __p_JbhiByB62mBPaeJq1PRm6a;
            [n1.ElementAttribute(TracingId = 345658U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "SHZlTlQ6I3NLFjQdSxZ9bW", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_SHZlTlQ6I3NLFjQdSxZ9bW;
            [n1.ElementAttribute(TracingId = 345663U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "UEpJ2VhpjfTPGRq34r5jtr", Name = "FuseCoreDomain (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_UEpJ2VhpjfTPGRq34r5jtr;
            [n1.ElementAttribute(TracingId = 345666U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "QwE3yqEm6rfQNYoNayNpZG", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_QwE3yqEm6rfQNYoNayNpZG;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a = default(n11.Spread<n5.AbstractGpuValue>);
            public __EhoeeX5eoacNeDfZpC2gDG(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __EhoeeX5eoacNeDfZpC2gDG(__EhoeeX5eoacNeDfZpC2gDG other): base(other)
            {
                this.__p_JbhiByB62mBPaeJq1PRm6a = other.__p_JbhiByB62mBPaeJq1PRm6a;
                this.__p_SHZlTlQ6I3NLFjQdSxZ9bW = other.__p_SHZlTlQ6I3NLFjQdSxZ9bW;
                this.__p_UEpJ2VhpjfTPGRq34r5jtr = other.__p_UEpJ2VhpjfTPGRq34r5jtr;
                this.__p_QwE3yqEm6rfQNYoNayNpZG = other.__p_QwE3yqEm6rfQNYoNayNpZG;
                this.__pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a = other.__pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JbhiByB62mBPaeJq1PRm6a", in __p_JbhiByB62mBPaeJq1PRm6a), n1.CompilationHelper.GetValueOrExisting(values, "__p_SHZlTlQ6I3NLFjQdSxZ9bW", in __p_SHZlTlQ6I3NLFjQdSxZ9bW), n1.CompilationHelper.GetValueOrExisting(values, "__p_UEpJ2VhpjfTPGRq34r5jtr", in __p_UEpJ2VhpjfTPGRq34r5jtr), n1.CompilationHelper.GetValueOrExisting(values, "__p_QwE3yqEm6rfQNYoNayNpZG", in __p_QwE3yqEm6rfQNYoNayNpZG), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a", in __pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a));
            }

            internal __EhoeeX5eoacNeDfZpC2gDG __WITH__(n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector2> __p_JbhiByB62mBPaeJq1PRm6a, n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_SHZlTlQ6I3NLFjQdSxZ9bW, n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_UEpJ2VhpjfTPGRq34r5jtr, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_QwE3yqEm6rfQNYoNayNpZG, n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a)
            {
                __EhoeeX5eoacNeDfZpC2gDG that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_JbhiByB62mBPaeJq1PRm6a != this.__p_JbhiByB62mBPaeJq1PRm6a || __p_SHZlTlQ6I3NLFjQdSxZ9bW != this.__p_SHZlTlQ6I3NLFjQdSxZ9bW || __p_UEpJ2VhpjfTPGRq34r5jtr != this.__p_UEpJ2VhpjfTPGRq34r5jtr || __p_QwE3yqEm6rfQNYoNayNpZG != this.__p_QwE3yqEm6rfQNYoNayNpZG || __pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a != this.__pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a ? new __EhoeeX5eoacNeDfZpC2gDG(this)
                    {__p_JbhiByB62mBPaeJq1PRm6a = __p_JbhiByB62mBPaeJq1PRm6a, __p_SHZlTlQ6I3NLFjQdSxZ9bW = __p_SHZlTlQ6I3NLFjQdSxZ9bW, __p_UEpJ2VhpjfTPGRq34r5jtr = __p_UEpJ2VhpjfTPGRq34r5jtr, __p_QwE3yqEm6rfQNYoNayNpZG = __p_QwE3yqEm6rfQNYoNayNpZG, __pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a = __pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a} : that_0;
                else
                {
                    this.__p_JbhiByB62mBPaeJq1PRm6a = __p_JbhiByB62mBPaeJq1PRm6a;
                    this.__p_SHZlTlQ6I3NLFjQdSxZ9bW = __p_SHZlTlQ6I3NLFjQdSxZ9bW;
                    this.__p_UEpJ2VhpjfTPGRq34r5jtr = __p_UEpJ2VhpjfTPGRq34r5jtr;
                    this.__p_QwE3yqEm6rfQNYoNayNpZG = __p_QwE3yqEm6rfQNYoNayNpZG;
                    this.__pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a = __pin_group_Arguments_In_JbhiByB62mBPaeJq1PRm6a;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 345739U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "TTfuBbKAgyvPaTVshEyQ40", Name = "UVSpace_TTfuBbKAgyvPaTVshEyQ40")]
    [n2.SerializableAttribute]
    public class UVSpace_TTfuBbKAgyvPaTVshEyQ40 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n28.UVSpace_TTfuBbKAgyvPaTVshEyQ40 Create(n1.NodeContext Node_Context)
        {
            var instance = new UVSpace_TTfuBbKAgyvPaTVshEyQ40(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n28.UVSpace_TTfuBbKAgyvPaTVshEyQ40 CreateDefault()
        {
            var instance = new UVSpace_TTfuBbKAgyvPaTVshEyQ40(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n28.UVSpace_TTfuBbKAgyvPaTVshEyQ40 Update([n4.SerializedDefaultValueAttribute("True", false)] bool Map_To_Screen_Coords_In, out n5.GpuValue<n22.Vector2> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_AZM09CnsesSPMQsxCvQTAq;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<bool>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>>(n2.ValueTuple.Create(default(n5.GpuValue<n22.Vector2>)));
            }

            var inputs_3 = n2.ValueTuple.Create(Map_To_Screen_Coords_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__RhF3cnJkRQRNIm9ePsL9g8>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __RhF3cnJkRQRNIm9ePsL9g8(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO = n17._Operations_.CreateDefault<n5.GpuValue<n22.Vector2>>(), __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu = n17._Operations_.CreateDefault<n5.GpuValue<n22.Vector2>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "RTRII0PFTXbM9oOpYcHUyj", 345756U);
                    var Output_8 = n39.TexCoord_NBzyEKjQS4CMgKHVXlVn1r.Create(Node_Context: Node_Context_7);
                    state_6.__p_RTRII0PFTXbM9oOpYcHUyj = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "EN5t1EqDn1VQXsfaXQV8XO", 345803U);
                    var Output_10 = n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n22.Vector2>.Create(Node_Context: Node_Context_9);
                    state_6.__p_EN5t1EqDn1VQXsfaXQV8XO = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "J0ieLGqJk7YMEnUx0rlg28", 345819U);
                    var Output_12 = n28.UVToScreen_KgjgRSn8shELYZ6kqgXk4b.Create(Node_Context: Node_Context_11);
                    state_6.__p_J0ieLGqJk7YMEnUx0rlg28 = Output_12;
                }

                var State_Output_14 = state_6.__p_RTRII0PFTXbM9oOpYcHUyj.Update(Output_Out: out n5.GpuValue<n22.Vector2> Output_13);
                n5.GpuValue<n22.Vector2> Input_2_15 = default(n5.GpuValue<n22.Vector2>);
                var builder_16 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO, 2);
                builder_16.Add(Output_13);
                builder_16.Add(Input_2_15);
                var __pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO_17 = builder_16.Commit();
                var State_Output_19 = state_6.__p_EN5t1EqDn1VQXsfaXQV8XO.Update(Input_In: __pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO_17, Output_Out: out n5.GpuValue<n22.Vector2> Output_18);
                bool __pad_NcPGB1WGoT5LMshPum1ymx_20 = Map_To_Screen_Coords_In;
                int Index_21 = n2.Convert.ToInt32(__pad_NcPGB1WGoT5LMshPum1ymx_20);
                var State_Output_23 = state_6.__p_J0ieLGqJk7YMEnUx0rlg28.Update(Input_In: Output_13, Output_Out: out n5.GpuValue<n22.Vector2> Output_22);
                var builder_24 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu, 2);
                builder_24.Add(Output_18);
                builder_24.Add(Output_22);
                var __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu_25 = builder_24.Commit();
                n13._Operations_.Switch<n5.GpuValue<n22.Vector2>, n12.__AdaptiveImplementations__MzilLTk6yNROg5SWTCtzZM>(Index_In: Index_21, Input_In: __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu_25, Output_Out: out n5.GpuValue<n22.Vector2> Output_26);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_14 != state_6.__p_RTRII0PFTXbM9oOpYcHUyj || __pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO_17 != state_6.__pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO || State_Output_19 != state_6.__p_EN5t1EqDn1VQXsfaXQV8XO || Map_To_Screen_Coords_In != state_6.__slot_NcPGB1WGoT5LMshPum1ymx || State_Output_23 != state_6.__p_J0ieLGqJk7YMEnUx0rlg28 || __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu_25 != state_6.__pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu ? new __RhF3cnJkRQRNIm9ePsL9g8(state_6)
                    {__p_RTRII0PFTXbM9oOpYcHUyj = State_Output_14, __pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO = __pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO_17, __p_EN5t1EqDn1VQXsfaXQV8XO = State_Output_19, __slot_NcPGB1WGoT5LMshPum1ymx = Map_To_Screen_Coords_In, __p_J0ieLGqJk7YMEnUx0rlg28 = State_Output_23, __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu = __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu_25} : state_6;
                else
                {
                    state_6.__p_RTRII0PFTXbM9oOpYcHUyj = State_Output_14;
                    state_6.__pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO = __pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO_17;
                    state_6.__p_EN5t1EqDn1VQXsfaXQV8XO = State_Output_19;
                    state_6.__slot_NcPGB1WGoT5LMshPum1ymx = Map_To_Screen_Coords_In;
                    state_6.__p_J0ieLGqJk7YMEnUx0rlg28 = State_Output_23;
                    state_6.__pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu = __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu_25;
                }

                outputs_4 = n2.ValueTuple.Create(Output_26);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_27 = outputs_4.Item1;
            Output_Out = __auto_27;
            n28.UVSpace_TTfuBbKAgyvPaTVshEyQ40 that_28 = this;
            if (this.__GetContext__().IsImmutable)
                that_28 = manager_2 != this.__cache_AZM09CnsesSPMQsxCvQTAq ? new UVSpace_TTfuBbKAgyvPaTVshEyQ40(this)
                {__cache_AZM09CnsesSPMQsxCvQTAq = manager_2} : that_28;
            else
            {
                this.__cache_AZM09CnsesSPMQsxCvQTAq = manager_2;
            }

            return that_28;
        }

        public n28.UVSpace_TTfuBbKAgyvPaTVshEyQ40 __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n28.UVSpace_TTfuBbKAgyvPaTVshEyQ40 that_0 = this;
            this.__cache_AZM09CnsesSPMQsxCvQTAq = null;
            return that_0;
        }

        public n28.UVSpace_TTfuBbKAgyvPaTVshEyQ40 __CreateDefault__()
        {
            n28.UVSpace_TTfuBbKAgyvPaTVshEyQ40 that_0 = this;
            this.__cache_AZM09CnsesSPMQsxCvQTAq = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_AZM09CnsesSPMQsxCvQTAq);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 345747U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "AZM09CnsesSPMQsxCvQTAq", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<bool>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_AZM09CnsesSPMQsxCvQTAq = null;
        public UVSpace_TTfuBbKAgyvPaTVshEyQ40(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal UVSpace_TTfuBbKAgyvPaTVshEyQ40(UVSpace_TTfuBbKAgyvPaTVshEyQ40 other): base(other)
        {
            this.__cache_AZM09CnsesSPMQsxCvQTAq = other.__cache_AZM09CnsesSPMQsxCvQTAq;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_AZM09CnsesSPMQsxCvQTAq", in __cache_AZM09CnsesSPMQsxCvQTAq));
        }

        internal UVSpace_TTfuBbKAgyvPaTVshEyQ40 __WITH__(n7.Manager<n2.ValueTuple<bool>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_AZM09CnsesSPMQsxCvQTAq)
        {
            n28.UVSpace_TTfuBbKAgyvPaTVshEyQ40 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_AZM09CnsesSPMQsxCvQTAq != this.__cache_AZM09CnsesSPMQsxCvQTAq ? new UVSpace_TTfuBbKAgyvPaTVshEyQ40(this)
                {__cache_AZM09CnsesSPMQsxCvQTAq = __cache_AZM09CnsesSPMQsxCvQTAq} : that_0;
            else
            {
                this.__cache_AZM09CnsesSPMQsxCvQTAq = __cache_AZM09CnsesSPMQsxCvQTAq;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "RhF3cnJkRQRNIm9ePsL9g8", Name = "__RhF3cnJkRQRNIm9ePsL9g8")]
        [n2.SerializableAttribute]
        public class __RhF3cnJkRQRNIm9ePsL9g8 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RTRII0PFTXbM9oOpYcHUyj);
                n1.CompilationHelper.SafeDispose(this.__p_EN5t1EqDn1VQXsfaXQV8XO);
                n1.CompilationHelper.SafeDispose(this.__p_J0ieLGqJk7YMEnUx0rlg28);
                return;
            }

            [n1.ElementAttribute(TracingId = 345756U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "RTRII0PFTXbM9oOpYcHUyj", Name = "TexCoord", IsManaged = true, IsAutoGenerated = true)]
            public n39.TexCoord_NBzyEKjQS4CMgKHVXlVn1r __p_RTRII0PFTXbM9oOpYcHUyj;
            [n1.ElementAttribute(TracingId = 345803U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "EN5t1EqDn1VQXsfaXQV8XO", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n22.Vector2> __p_EN5t1EqDn1VQXsfaXQV8XO;
            [n1.ElementAttribute(TracingId = 345819U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "J0ieLGqJk7YMEnUx0rlg28", Name = "UVToScreen", IsManaged = true, IsAutoGenerated = true)]
            public n28.UVToScreen_KgjgRSn8shELYZ6kqgXk4b __p_J0ieLGqJk7YMEnUx0rlg28;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<n22.Vector2>> __pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO = default(n11.Spread<n5.GpuValue<n22.Vector2>>);
            [n1.ElementAttribute(TracingId = 345785U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "NcPGB1WGoT5LMshPum1ymx", Name = "__slot_NcPGB1WGoT5LMshPum1ymx")]
            public bool __slot_NcPGB1WGoT5LMshPum1ymx;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<n22.Vector2>> __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu = default(n11.Spread<n5.GpuValue<n22.Vector2>>);
            public __RhF3cnJkRQRNIm9ePsL9g8(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RhF3cnJkRQRNIm9ePsL9g8(__RhF3cnJkRQRNIm9ePsL9g8 other): base(other)
            {
                this.__p_RTRII0PFTXbM9oOpYcHUyj = other.__p_RTRII0PFTXbM9oOpYcHUyj;
                this.__p_EN5t1EqDn1VQXsfaXQV8XO = other.__p_EN5t1EqDn1VQXsfaXQV8XO;
                this.__p_J0ieLGqJk7YMEnUx0rlg28 = other.__p_J0ieLGqJk7YMEnUx0rlg28;
                this.__pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO = other.__pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO;
                this.__slot_NcPGB1WGoT5LMshPum1ymx = other.__slot_NcPGB1WGoT5LMshPum1ymx;
                this.__pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu = other.__pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RTRII0PFTXbM9oOpYcHUyj", in __p_RTRII0PFTXbM9oOpYcHUyj), n1.CompilationHelper.GetValueOrExisting(values, "__p_EN5t1EqDn1VQXsfaXQV8XO", in __p_EN5t1EqDn1VQXsfaXQV8XO), n1.CompilationHelper.GetValueOrExisting(values, "__p_J0ieLGqJk7YMEnUx0rlg28", in __p_J0ieLGqJk7YMEnUx0rlg28), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO", in __pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO), n1.CompilationHelper.GetValueOrExisting(values, "__slot_NcPGB1WGoT5LMshPum1ymx", in __slot_NcPGB1WGoT5LMshPum1ymx), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu", in __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu));
            }

            internal __RhF3cnJkRQRNIm9ePsL9g8 __WITH__(n39.TexCoord_NBzyEKjQS4CMgKHVXlVn1r __p_RTRII0PFTXbM9oOpYcHUyj, n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n22.Vector2> __p_EN5t1EqDn1VQXsfaXQV8XO, n28.UVToScreen_KgjgRSn8shELYZ6kqgXk4b __p_J0ieLGqJk7YMEnUx0rlg28, n11.Spread<n5.GpuValue<n22.Vector2>> __pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO, bool __slot_NcPGB1WGoT5LMshPum1ymx, n11.Spread<n5.GpuValue<n22.Vector2>> __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu)
            {
                __RhF3cnJkRQRNIm9ePsL9g8 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RTRII0PFTXbM9oOpYcHUyj != this.__p_RTRII0PFTXbM9oOpYcHUyj || __p_EN5t1EqDn1VQXsfaXQV8XO != this.__p_EN5t1EqDn1VQXsfaXQV8XO || __p_J0ieLGqJk7YMEnUx0rlg28 != this.__p_J0ieLGqJk7YMEnUx0rlg28 || __pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO != this.__pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO || __slot_NcPGB1WGoT5LMshPum1ymx != this.__slot_NcPGB1WGoT5LMshPum1ymx || __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu != this.__pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu ? new __RhF3cnJkRQRNIm9ePsL9g8(this)
                    {__p_RTRII0PFTXbM9oOpYcHUyj = __p_RTRII0PFTXbM9oOpYcHUyj, __p_EN5t1EqDn1VQXsfaXQV8XO = __p_EN5t1EqDn1VQXsfaXQV8XO, __p_J0ieLGqJk7YMEnUx0rlg28 = __p_J0ieLGqJk7YMEnUx0rlg28, __pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO = __pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO, __slot_NcPGB1WGoT5LMshPum1ymx = __slot_NcPGB1WGoT5LMshPum1ymx, __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu = __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu} : that_0;
                else
                {
                    this.__p_RTRII0PFTXbM9oOpYcHUyj = __p_RTRII0PFTXbM9oOpYcHUyj;
                    this.__p_EN5t1EqDn1VQXsfaXQV8XO = __p_EN5t1EqDn1VQXsfaXQV8XO;
                    this.__p_J0ieLGqJk7YMEnUx0rlg28 = __p_J0ieLGqJk7YMEnUx0rlg28;
                    this.__pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO = __pin_group_Input_In_EN5t1EqDn1VQXsfaXQV8XO;
                    this.__slot_NcPGB1WGoT5LMshPum1ymx = __slot_NcPGB1WGoT5LMshPum1ymx;
                    this.__pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu = __pin_group_Input_In_VAIHPdmO2LuLe1e5grfkUu;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 345879U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "S9diHx3Mq5hL4QLN00YxR3", Name = "PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3")]
    [n2.SerializableAttribute]
    public class PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n28.PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3 Create(n1.NodeContext Node_Context)
        {
            var instance = new PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n28.PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3 CreateDefault()
        {
            var instance = new PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n28.PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3 Update(n5.GpuValue<n22.Vector2> Input_In, [n4.SerializedDefaultValueAttribute("0.5, 0.5", false)] n5.GpuValue<n22.Vector2> Center_In, [n4.SerializedDefaultValueAttribute("1", false)] n5.GpuValue<float> Radial_Scale_In, [n4.SerializedDefaultValueAttribute("1", false)] n5.GpuValue<float> Length_Scale_In, out n5.GpuValue<n22.Vector2> Output__Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_JRGVs68BAJcNOdG0dGeqSX;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, n5.GpuValue<float>, n5.GpuValue<float>, n5.GpuValue<n22.Vector2>>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>>(n2.ValueTuple.Create(default(n5.GpuValue<n22.Vector2>)));
            }

            var inputs_3 = (Input_In, Length_Scale_In, Radial_Scale_In, Center_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__K5qZfH2Qg32P45HPQtBXSI>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __K5qZfH2Qg32P45HPQtBXSI(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm = n17._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51 = n17._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8 = n17._Operations_.CreateDefault<n5.GpuValue<n22.Vector2>>(), __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I = n17._Operations_.CreateDefault<n5.GpuValue<n22.Vector2>>(), __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn = n17._Operations_.CreateDefault<n5.GpuValue<n22.Vector2>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "AgaNM22eZPLNFyVCJmFe5a", 345913U);
                    var Output_8 = n20.Sin_OoRLZzhj5pXPZhoIUwHbgs<float>.Create(Node_Context: Node_Context_7);
                    state_6.__p_AgaNM22eZPLNFyVCJmFe5a = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "JIDbuAk34P4QUvz4kGoWfg", 345922U);
                    var Output_10 = n20.Cos_LOLusaGElj4Lrxu7Y8O7nk<float>.Create(Node_Context: Node_Context_9);
                    state_6.__p_JIDbuAk34P4QUvz4kGoWfg = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "KD19XgGkdifQNVnfvLbQDw", 345933U);
                    var Output_12 = n40.y_EqOmImsLEfKMwPNqId2m1L<n22.Vector2>.Create(Node_Context: Node_Context_11);
                    state_6.__p_KD19XgGkdifQNVnfvLbQDw = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "UJZjRlJogJrNWgX7Qa9g51", 345951U);
                    var Output_14 = n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_13);
                    state_6.__p_UJZjRlJogJrNWgX7Qa9g51 = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "NkY6dmd26LZN6JPb7Ehjcr", 345964U);
                    var Output_16 = n20.TWO_PI_CD2xtJr8wQ0PlBSQnIljMI<float>.Create(Node_Context: Node_Context_15);
                    state_6.__p_NkY6dmd26LZN6JPb7Ehjcr = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "GSPGfyiDAHGLZcaGHb650e", 345974U);
                    var Output_18 = n40.x_CThKQPdF8roMfrpnCR01ll<n22.Vector2>.Create(Node_Context: Node_Context_17);
                    state_6.__p_GSPGfyiDAHGLZcaGHb650e = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "NCzfB6htQDnOl4jM0UcYUx", 345981U);
                    var Output_20 = n41.xPy_join_JIONWu6byjBM6yvKcs4o8k.Create(Node_Context: Node_Context_19);
                    state_6.__p_NCzfB6htQDnOl4jM0UcYUx = Output_20;
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "FUy0Huk6WOfLrp6vzDDGs8", 345992U);
                    var Output_22 = n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n22.Vector2>.Create(Node_Context: Node_Context_21);
                    state_6.__p_FUy0Huk6WOfLrp6vzDDGs8 = Output_22;
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "N5ffrDonp3nQFswasH3URD", 346007U);
                    var Output_24 = n42.To_Qgkn15Kxt1HLURmAdSAN7m<float, n22.Vector2>.Create(Node_Context: Node_Context_23);
                    state_6.__p_N5ffrDonp3nQFswasH3URD = Output_24;
                    n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Jfs2m45Jfc7LXXBG4nXyBn", 346023U);
                    var Output_26 = n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n22.Vector2>.Create(Node_Context: Node_Context_25);
                    state_6.__p_Jfs2m45Jfc7LXXBG4nXyBn = Output_26;
                    n1.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "SF1lAJkMnBnOpjPdcWrO5I", 346032U);
                    var Output_28 = n20.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n22.Vector2>.Create(Node_Context: Node_Context_27);
                    state_6.__p_SF1lAJkMnBnOpjPdcWrO5I = Output_28;
                    n1.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "VFtZIjpOweCOmi8gPBAeNG", 346052U);
                    var Output_30 = n42.To_Qgkn15Kxt1HLURmAdSAN7m<float, n22.Vector2>.Create(Node_Context: Node_Context_29);
                    state_6.__p_VFtZIjpOweCOmi8gPBAeNG = Output_30;
                    n1.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "UnemOeB8pXmNLT2omuTfkm", 346060U);
                    var Output_32 = n20.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<float>.Create(Node_Context: Node_Context_31);
                    state_6.__p_UnemOeB8pXmNLT2omuTfkm = Output_32;
                    n43._Operations_.PolarToCartesian2DID(Output_Out: out string Output_33);
                    n1.NodeContext Node_Context_34 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "LPaQ42lFjWGOoFO9nkKxiS", 346068U);
                    var Output_35 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_34, ID_In: Output_33);
                    state_6.__p_LPaQ42lFjWGOoFO9nkKxiS = Output_35;
                }

                n22.Vector2 __pad_A66l9xyzlCTNdqz7OyL3l4_36 = __slot_A66l9xyzlCTNdqz7OyL3l4;
                var State_Output_38 = state_6.__p_KD19XgGkdifQNVnfvLbQDw.Update(Input_In: Input_In, Output_Out: out n5.GpuValue<float> Output_37);
                var builder_39 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm, 2);
                builder_39.Add(Output_37);
                builder_39.Add(Length_Scale_In);
                var __pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm_40 = builder_39.Commit();
                var State_Output_42 = state_6.__p_UnemOeB8pXmNLT2omuTfkm.Update(Input_In: __pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm_40, Output_Out: out n5.GpuValue<float> Output_41);
                var State_Output_44 = state_6.__p_NkY6dmd26LZN6JPb7Ehjcr.Update(Output_Out: out n5.GpuValue<float> Output_43);
                var builder_45 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51, 2);
                builder_45.Add(Output_41);
                builder_45.Add(Output_43);
                var __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51_46 = builder_45.Commit();
                var State_Output_48 = state_6.__p_UJZjRlJogJrNWgX7Qa9g51.Update(Input_In: __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51_46, Output_Out: out n5.GpuValue<float> Output_47);
                var State_Output_50 = state_6.__p_AgaNM22eZPLNFyVCJmFe5a.Update(Input_In: Output_47, Output_Out: out n5.GpuValue<float> Output_49);
                var State_Output_52 = state_6.__p_GSPGfyiDAHGLZcaGHb650e.Update(Input_In: Input_In, Output_Out: out n5.GpuValue<float> Output_51);
                n5.GpuValue<n22.Vector2> default_53 = default(n5.GpuValue<n22.Vector2>);
                var State_Output_55 = state_6.__p_N5ffrDonp3nQFswasH3URD.Update(x_In: Output_51, default_In: default_53, Output_Out: out n5.GpuValue<n22.Vector2> Output_54);
                var State_Output_57 = state_6.__p_JIDbuAk34P4QUvz4kGoWfg.Update(Input_In: Output_47, Output_Out: out n5.GpuValue<float> Output_56);
                var State_Output_59 = state_6.__p_NCzfB6htQDnOl4jM0UcYUx.Update(x_In: Output_49, y_In: Output_56, Output_Out: out n5.GpuValue<n22.Vector2> Output_58);
                var builder_60 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8, 2);
                builder_60.Add(Output_58);
                builder_60.Add(Output_54);
                var __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8_61 = builder_60.Commit();
                var State_Output_63 = state_6.__p_FUy0Huk6WOfLrp6vzDDGs8.Update(Input_In: __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8_61, Output_Out: out n5.GpuValue<n22.Vector2> Output_62);
                n5.GpuValue<n22.Vector2> default_64 = default(n5.GpuValue<n22.Vector2>);
                var State_Output_66 = state_6.__p_VFtZIjpOweCOmi8gPBAeNG.Update(x_In: Radial_Scale_In, default_In: default_64, Output_Out: out n5.GpuValue<n22.Vector2> Output_65);
                n5.GpuValue<n22.Vector2> Input_3_67 = state_6.__monadBuilder_NEBvdPllkwTNm1gMqvnUnb.Return(__pad_A66l9xyzlCTNdqz7OyL3l4_36);
                var builder_68 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I, 3);
                builder_68.Add(Output_62);
                builder_68.Add(Output_65);
                builder_68.Add(Input_3_67);
                var __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I_69 = builder_68.Commit();
                var State_Output_71 = state_6.__p_SF1lAJkMnBnOpjPdcWrO5I.Update(Input_In: __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I_69, Output_Out: out n5.GpuValue<n22.Vector2> Output_70);
                var builder_72 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn, 2);
                builder_72.Add(Output_70);
                builder_72.Add(Center_In);
                var __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn_73 = builder_72.Commit();
                var State_Output_75 = state_6.__p_Jfs2m45Jfc7LXXBG4nXyBn.Update(Input_In: __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn_73, Output_Out: out n5.GpuValue<n22.Vector2> Output_74);
                bool Update_76 = true;
                var Output_77 = state_6.__p_LPaQ42lFjWGOoFO9nkKxiS;
                if (Update_76)
                {
                    Output_77 = state_6.__p_LPaQ42lFjWGOoFO9nkKxiS.Update(Input_In: Output_74);
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_38 != state_6.__p_KD19XgGkdifQNVnfvLbQDw || __pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm_40 != state_6.__pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm || State_Output_42 != state_6.__p_UnemOeB8pXmNLT2omuTfkm || State_Output_44 != state_6.__p_NkY6dmd26LZN6JPb7Ehjcr || __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51_46 != state_6.__pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51 || State_Output_48 != state_6.__p_UJZjRlJogJrNWgX7Qa9g51 || State_Output_50 != state_6.__p_AgaNM22eZPLNFyVCJmFe5a || State_Output_52 != state_6.__p_GSPGfyiDAHGLZcaGHb650e || State_Output_55 != state_6.__p_N5ffrDonp3nQFswasH3URD || State_Output_57 != state_6.__p_JIDbuAk34P4QUvz4kGoWfg || State_Output_59 != state_6.__p_NCzfB6htQDnOl4jM0UcYUx || __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8_61 != state_6.__pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8 || State_Output_63 != state_6.__p_FUy0Huk6WOfLrp6vzDDGs8 || State_Output_66 != state_6.__p_VFtZIjpOweCOmi8gPBAeNG || __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I_69 != state_6.__pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I || State_Output_71 != state_6.__p_SF1lAJkMnBnOpjPdcWrO5I || __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn_73 != state_6.__pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn || State_Output_75 != state_6.__p_Jfs2m45Jfc7LXXBG4nXyBn || Output_77 != state_6.__p_LPaQ42lFjWGOoFO9nkKxiS ? new __K5qZfH2Qg32P45HPQtBXSI(state_6)
                    {__p_KD19XgGkdifQNVnfvLbQDw = State_Output_38, __pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm = __pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm_40, __p_UnemOeB8pXmNLT2omuTfkm = State_Output_42, __p_NkY6dmd26LZN6JPb7Ehjcr = State_Output_44, __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51 = __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51_46, __p_UJZjRlJogJrNWgX7Qa9g51 = State_Output_48, __p_AgaNM22eZPLNFyVCJmFe5a = State_Output_50, __p_GSPGfyiDAHGLZcaGHb650e = State_Output_52, __p_N5ffrDonp3nQFswasH3URD = State_Output_55, __p_JIDbuAk34P4QUvz4kGoWfg = State_Output_57, __p_NCzfB6htQDnOl4jM0UcYUx = State_Output_59, __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8 = __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8_61, __p_FUy0Huk6WOfLrp6vzDDGs8 = State_Output_63, __p_VFtZIjpOweCOmi8gPBAeNG = State_Output_66, __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I = __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I_69, __p_SF1lAJkMnBnOpjPdcWrO5I = State_Output_71, __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn = __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn_73, __p_Jfs2m45Jfc7LXXBG4nXyBn = State_Output_75, __p_LPaQ42lFjWGOoFO9nkKxiS = Output_77} : state_6;
                else
                {
                    state_6.__p_KD19XgGkdifQNVnfvLbQDw = State_Output_38;
                    state_6.__pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm = __pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm_40;
                    state_6.__p_UnemOeB8pXmNLT2omuTfkm = State_Output_42;
                    state_6.__p_NkY6dmd26LZN6JPb7Ehjcr = State_Output_44;
                    state_6.__pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51 = __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51_46;
                    state_6.__p_UJZjRlJogJrNWgX7Qa9g51 = State_Output_48;
                    state_6.__p_AgaNM22eZPLNFyVCJmFe5a = State_Output_50;
                    state_6.__p_GSPGfyiDAHGLZcaGHb650e = State_Output_52;
                    state_6.__p_N5ffrDonp3nQFswasH3URD = State_Output_55;
                    state_6.__p_JIDbuAk34P4QUvz4kGoWfg = State_Output_57;
                    state_6.__p_NCzfB6htQDnOl4jM0UcYUx = State_Output_59;
                    state_6.__pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8 = __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8_61;
                    state_6.__p_FUy0Huk6WOfLrp6vzDDGs8 = State_Output_63;
                    state_6.__p_VFtZIjpOweCOmi8gPBAeNG = State_Output_66;
                    state_6.__pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I = __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I_69;
                    state_6.__p_SF1lAJkMnBnOpjPdcWrO5I = State_Output_71;
                    state_6.__pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn = __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn_73;
                    state_6.__p_Jfs2m45Jfc7LXXBG4nXyBn = State_Output_75;
                    state_6.__p_LPaQ42lFjWGOoFO9nkKxiS = Output_77;
                }

                outputs_4 = n2.ValueTuple.Create(Output_74);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_78 = outputs_4.Item1;
            Output__Out = __auto_78;
            n28.PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3 that_79 = this;
            if (this.__GetContext__().IsImmutable)
                that_79 = manager_2 != this.__cache_JRGVs68BAJcNOdG0dGeqSX ? new PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3(this)
                {__cache_JRGVs68BAJcNOdG0dGeqSX = manager_2} : that_79;
            else
            {
                this.__cache_JRGVs68BAJcNOdG0dGeqSX = manager_2;
            }

            return that_79;
        }

        public n28.PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3 __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n28.PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3 that_0 = this;
            this.__cache_JRGVs68BAJcNOdG0dGeqSX = null;
            return that_0;
        }

        public n28.PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3 __CreateDefault__()
        {
            n28.PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3 that_0 = this;
            this.__cache_JRGVs68BAJcNOdG0dGeqSX = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_JRGVs68BAJcNOdG0dGeqSX);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 345896U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "JRGVs68BAJcNOdG0dGeqSX", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, n5.GpuValue<float>, n5.GpuValue<float>, n5.GpuValue<n22.Vector2>>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_JRGVs68BAJcNOdG0dGeqSX = null;
        [n1.ElementAttribute(TracingId = 346047U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "A66l9xyzlCTNdqz7OyL3l4", Name = "__slot_A66l9xyzlCTNdqz7OyL3l4")]
        public static n22.Vector2 __slot_A66l9xyzlCTNdqz7OyL3l4 = n1.CompilationHelper.Deserialize<n22.Vector2>("2, 2", false, "MzilLTk6yNROg5SWTCtzZM", "A66l9xyzlCTNdqz7OyL3l4");
        static PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3()
        {
        }

        public PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3(PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3 other): base(other)
        {
            this.__cache_JRGVs68BAJcNOdG0dGeqSX = other.__cache_JRGVs68BAJcNOdG0dGeqSX;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_JRGVs68BAJcNOdG0dGeqSX", in __cache_JRGVs68BAJcNOdG0dGeqSX));
        }

        internal PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3 __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector2>, n5.GpuValue<float>, n5.GpuValue<float>, n5.GpuValue<n22.Vector2>>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_JRGVs68BAJcNOdG0dGeqSX)
        {
            n28.PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_JRGVs68BAJcNOdG0dGeqSX != this.__cache_JRGVs68BAJcNOdG0dGeqSX ? new PolarToCartesian_S9diHx3Mq5hL4QLN00YxR3(this)
                {__cache_JRGVs68BAJcNOdG0dGeqSX = __cache_JRGVs68BAJcNOdG0dGeqSX} : that_0;
            else
            {
                this.__cache_JRGVs68BAJcNOdG0dGeqSX = __cache_JRGVs68BAJcNOdG0dGeqSX;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "K5qZfH2Qg32P45HPQtBXSI", Name = "__K5qZfH2Qg32P45HPQtBXSI")]
        [n2.SerializableAttribute]
        public class __K5qZfH2Qg32P45HPQtBXSI : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_AgaNM22eZPLNFyVCJmFe5a);
                n1.CompilationHelper.SafeDispose(this.__p_JIDbuAk34P4QUvz4kGoWfg);
                n1.CompilationHelper.SafeDispose(this.__p_KD19XgGkdifQNVnfvLbQDw);
                n1.CompilationHelper.SafeDispose(this.__p_UJZjRlJogJrNWgX7Qa9g51);
                n1.CompilationHelper.SafeDispose(this.__p_NkY6dmd26LZN6JPb7Ehjcr);
                n1.CompilationHelper.SafeDispose(this.__p_GSPGfyiDAHGLZcaGHb650e);
                n1.CompilationHelper.SafeDispose(this.__p_NCzfB6htQDnOl4jM0UcYUx);
                n1.CompilationHelper.SafeDispose(this.__p_FUy0Huk6WOfLrp6vzDDGs8);
                n1.CompilationHelper.SafeDispose(this.__p_N5ffrDonp3nQFswasH3URD);
                n1.CompilationHelper.SafeDispose(this.__p_Jfs2m45Jfc7LXXBG4nXyBn);
                n1.CompilationHelper.SafeDispose(this.__p_SF1lAJkMnBnOpjPdcWrO5I);
                n1.CompilationHelper.SafeDispose(this.__p_VFtZIjpOweCOmi8gPBAeNG);
                n1.CompilationHelper.SafeDispose(this.__p_UnemOeB8pXmNLT2omuTfkm);
                n1.CompilationHelper.SafeDispose(this.__p_LPaQ42lFjWGOoFO9nkKxiS);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_NEBvdPllkwTNm1gMqvnUnb);
                return;
            }

            [n1.ElementAttribute(TracingId = 345913U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "AgaNM22eZPLNFyVCJmFe5a", Name = "Sin", IsManaged = true, IsAutoGenerated = true)]
            public n20.Sin_OoRLZzhj5pXPZhoIUwHbgs<float> __p_AgaNM22eZPLNFyVCJmFe5a;
            [n1.ElementAttribute(TracingId = 345922U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "JIDbuAk34P4QUvz4kGoWfg", Name = "Cos", IsManaged = true, IsAutoGenerated = true)]
            public n20.Cos_LOLusaGElj4Lrxu7Y8O7nk<float> __p_JIDbuAk34P4QUvz4kGoWfg;
            [n1.ElementAttribute(TracingId = 345933U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "KD19XgGkdifQNVnfvLbQDw", Name = "y", IsManaged = true, IsAutoGenerated = true)]
            public n40.y_EqOmImsLEfKMwPNqId2m1L<n22.Vector2> __p_KD19XgGkdifQNVnfvLbQDw;
            [n1.ElementAttribute(TracingId = 345951U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "UJZjRlJogJrNWgX7Qa9g51", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_UJZjRlJogJrNWgX7Qa9g51;
            [n1.ElementAttribute(TracingId = 345964U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "NkY6dmd26LZN6JPb7Ehjcr", Name = "TWO_PI", IsManaged = true, IsAutoGenerated = true)]
            public n20.TWO_PI_CD2xtJr8wQ0PlBSQnIljMI<float> __p_NkY6dmd26LZN6JPb7Ehjcr;
            [n1.ElementAttribute(TracingId = 345974U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "GSPGfyiDAHGLZcaGHb650e", Name = "x", IsManaged = true, IsAutoGenerated = true)]
            public n40.x_CThKQPdF8roMfrpnCR01ll<n22.Vector2> __p_GSPGfyiDAHGLZcaGHb650e;
            [n1.ElementAttribute(TracingId = 345981U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "NCzfB6htQDnOl4jM0UcYUx", Name = "x+y (join)", IsManaged = true, IsAutoGenerated = true)]
            public n41.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_NCzfB6htQDnOl4jM0UcYUx;
            [n1.ElementAttribute(TracingId = 345992U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "FUy0Huk6WOfLrp6vzDDGs8", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n22.Vector2> __p_FUy0Huk6WOfLrp6vzDDGs8;
            [n1.ElementAttribute(TracingId = 346007U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "N5ffrDonp3nQFswasH3URD", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n42.To_Qgkn15Kxt1HLURmAdSAN7m<float, n22.Vector2> __p_N5ffrDonp3nQFswasH3URD;
            [n1.ElementAttribute(TracingId = 346023U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Jfs2m45Jfc7LXXBG4nXyBn", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n22.Vector2> __p_Jfs2m45Jfc7LXXBG4nXyBn;
            [n1.ElementAttribute(TracingId = 346032U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "SF1lAJkMnBnOpjPdcWrO5I", Name = "/", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n22.Vector2> __p_SF1lAJkMnBnOpjPdcWrO5I;
            [n1.ElementAttribute(TracingId = 346052U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "VFtZIjpOweCOmi8gPBAeNG", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n42.To_Qgkn15Kxt1HLURmAdSAN7m<float, n22.Vector2> __p_VFtZIjpOweCOmi8gPBAeNG;
            [n1.ElementAttribute(TracingId = 346060U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "UnemOeB8pXmNLT2omuTfkm", Name = "/", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<float> __p_UnemOeB8pXmNLT2omuTfkm;
            [n1.ElementAttribute(TracingId = 346068U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "LPaQ42lFjWGOoFO9nkKxiS", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_LPaQ42lFjWGOoFO9nkKxiS;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm = default(n11.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51 = default(n11.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<n22.Vector2>> __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8 = default(n11.Spread<n5.GpuValue<n22.Vector2>>);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<n22.Vector2, n5.GpuValue<n22.Vector2>> __monadBuilder_NEBvdPllkwTNm1gMqvnUnb = n5.GpuValueMonadicFactory<n22.Vector2>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<n22.Vector2>> __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I = default(n11.Spread<n5.GpuValue<n22.Vector2>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<n22.Vector2>> __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn = default(n11.Spread<n5.GpuValue<n22.Vector2>>);
            public __K5qZfH2Qg32P45HPQtBXSI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __K5qZfH2Qg32P45HPQtBXSI(__K5qZfH2Qg32P45HPQtBXSI other): base(other)
            {
                this.__p_AgaNM22eZPLNFyVCJmFe5a = other.__p_AgaNM22eZPLNFyVCJmFe5a;
                this.__p_JIDbuAk34P4QUvz4kGoWfg = other.__p_JIDbuAk34P4QUvz4kGoWfg;
                this.__p_KD19XgGkdifQNVnfvLbQDw = other.__p_KD19XgGkdifQNVnfvLbQDw;
                this.__p_UJZjRlJogJrNWgX7Qa9g51 = other.__p_UJZjRlJogJrNWgX7Qa9g51;
                this.__p_NkY6dmd26LZN6JPb7Ehjcr = other.__p_NkY6dmd26LZN6JPb7Ehjcr;
                this.__p_GSPGfyiDAHGLZcaGHb650e = other.__p_GSPGfyiDAHGLZcaGHb650e;
                this.__p_NCzfB6htQDnOl4jM0UcYUx = other.__p_NCzfB6htQDnOl4jM0UcYUx;
                this.__p_FUy0Huk6WOfLrp6vzDDGs8 = other.__p_FUy0Huk6WOfLrp6vzDDGs8;
                this.__p_N5ffrDonp3nQFswasH3URD = other.__p_N5ffrDonp3nQFswasH3URD;
                this.__p_Jfs2m45Jfc7LXXBG4nXyBn = other.__p_Jfs2m45Jfc7LXXBG4nXyBn;
                this.__p_SF1lAJkMnBnOpjPdcWrO5I = other.__p_SF1lAJkMnBnOpjPdcWrO5I;
                this.__p_VFtZIjpOweCOmi8gPBAeNG = other.__p_VFtZIjpOweCOmi8gPBAeNG;
                this.__p_UnemOeB8pXmNLT2omuTfkm = other.__p_UnemOeB8pXmNLT2omuTfkm;
                this.__p_LPaQ42lFjWGOoFO9nkKxiS = other.__p_LPaQ42lFjWGOoFO9nkKxiS;
                this.__pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm = other.__pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm;
                this.__pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51 = other.__pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51;
                this.__pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8 = other.__pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8;
                this.__monadBuilder_NEBvdPllkwTNm1gMqvnUnb = other.__monadBuilder_NEBvdPllkwTNm1gMqvnUnb;
                this.__pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I = other.__pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I;
                this.__pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn = other.__pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AgaNM22eZPLNFyVCJmFe5a", in __p_AgaNM22eZPLNFyVCJmFe5a), n1.CompilationHelper.GetValueOrExisting(values, "__p_JIDbuAk34P4QUvz4kGoWfg", in __p_JIDbuAk34P4QUvz4kGoWfg), n1.CompilationHelper.GetValueOrExisting(values, "__p_KD19XgGkdifQNVnfvLbQDw", in __p_KD19XgGkdifQNVnfvLbQDw), n1.CompilationHelper.GetValueOrExisting(values, "__p_UJZjRlJogJrNWgX7Qa9g51", in __p_UJZjRlJogJrNWgX7Qa9g51), n1.CompilationHelper.GetValueOrExisting(values, "__p_NkY6dmd26LZN6JPb7Ehjcr", in __p_NkY6dmd26LZN6JPb7Ehjcr), n1.CompilationHelper.GetValueOrExisting(values, "__p_GSPGfyiDAHGLZcaGHb650e", in __p_GSPGfyiDAHGLZcaGHb650e), n1.CompilationHelper.GetValueOrExisting(values, "__p_NCzfB6htQDnOl4jM0UcYUx", in __p_NCzfB6htQDnOl4jM0UcYUx), n1.CompilationHelper.GetValueOrExisting(values, "__p_FUy0Huk6WOfLrp6vzDDGs8", in __p_FUy0Huk6WOfLrp6vzDDGs8), n1.CompilationHelper.GetValueOrExisting(values, "__p_N5ffrDonp3nQFswasH3URD", in __p_N5ffrDonp3nQFswasH3URD), n1.CompilationHelper.GetValueOrExisting(values, "__p_Jfs2m45Jfc7LXXBG4nXyBn", in __p_Jfs2m45Jfc7LXXBG4nXyBn), n1.CompilationHelper.GetValueOrExisting(values, "__p_SF1lAJkMnBnOpjPdcWrO5I", in __p_SF1lAJkMnBnOpjPdcWrO5I), n1.CompilationHelper.GetValueOrExisting(values, "__p_VFtZIjpOweCOmi8gPBAeNG", in __p_VFtZIjpOweCOmi8gPBAeNG), n1.CompilationHelper.GetValueOrExisting(values, "__p_UnemOeB8pXmNLT2omuTfkm", in __p_UnemOeB8pXmNLT2omuTfkm), n1.CompilationHelper.GetValueOrExisting(values, "__p_LPaQ42lFjWGOoFO9nkKxiS", in __p_LPaQ42lFjWGOoFO9nkKxiS), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm", in __pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51", in __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8", in __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_NEBvdPllkwTNm1gMqvnUnb", in __monadBuilder_NEBvdPllkwTNm1gMqvnUnb), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I", in __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn", in __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn));
            }

            internal __K5qZfH2Qg32P45HPQtBXSI __WITH__(n20.Sin_OoRLZzhj5pXPZhoIUwHbgs<float> __p_AgaNM22eZPLNFyVCJmFe5a, n20.Cos_LOLusaGElj4Lrxu7Y8O7nk<float> __p_JIDbuAk34P4QUvz4kGoWfg, n40.y_EqOmImsLEfKMwPNqId2m1L<n22.Vector2> __p_KD19XgGkdifQNVnfvLbQDw, n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_UJZjRlJogJrNWgX7Qa9g51, n20.TWO_PI_CD2xtJr8wQ0PlBSQnIljMI<float> __p_NkY6dmd26LZN6JPb7Ehjcr, n40.x_CThKQPdF8roMfrpnCR01ll<n22.Vector2> __p_GSPGfyiDAHGLZcaGHb650e, n41.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_NCzfB6htQDnOl4jM0UcYUx, n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n22.Vector2> __p_FUy0Huk6WOfLrp6vzDDGs8, n42.To_Qgkn15Kxt1HLURmAdSAN7m<float, n22.Vector2> __p_N5ffrDonp3nQFswasH3URD, n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n22.Vector2> __p_Jfs2m45Jfc7LXXBG4nXyBn, n20.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n22.Vector2> __p_SF1lAJkMnBnOpjPdcWrO5I, n42.To_Qgkn15Kxt1HLURmAdSAN7m<float, n22.Vector2> __p_VFtZIjpOweCOmi8gPBAeNG, n20.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<float> __p_UnemOeB8pXmNLT2omuTfkm, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_LPaQ42lFjWGOoFO9nkKxiS, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51, n11.Spread<n5.GpuValue<n22.Vector2>> __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8, n1.IMonadBuilder<n22.Vector2, n5.GpuValue<n22.Vector2>> __monadBuilder_NEBvdPllkwTNm1gMqvnUnb, n11.Spread<n5.GpuValue<n22.Vector2>> __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I, n11.Spread<n5.GpuValue<n22.Vector2>> __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn)
            {
                __K5qZfH2Qg32P45HPQtBXSI that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_AgaNM22eZPLNFyVCJmFe5a != this.__p_AgaNM22eZPLNFyVCJmFe5a || __p_JIDbuAk34P4QUvz4kGoWfg != this.__p_JIDbuAk34P4QUvz4kGoWfg || __p_KD19XgGkdifQNVnfvLbQDw != this.__p_KD19XgGkdifQNVnfvLbQDw || __p_UJZjRlJogJrNWgX7Qa9g51 != this.__p_UJZjRlJogJrNWgX7Qa9g51 || __p_NkY6dmd26LZN6JPb7Ehjcr != this.__p_NkY6dmd26LZN6JPb7Ehjcr || __p_GSPGfyiDAHGLZcaGHb650e != this.__p_GSPGfyiDAHGLZcaGHb650e || __p_NCzfB6htQDnOl4jM0UcYUx != this.__p_NCzfB6htQDnOl4jM0UcYUx || __p_FUy0Huk6WOfLrp6vzDDGs8 != this.__p_FUy0Huk6WOfLrp6vzDDGs8 || __p_N5ffrDonp3nQFswasH3URD != this.__p_N5ffrDonp3nQFswasH3URD || __p_Jfs2m45Jfc7LXXBG4nXyBn != this.__p_Jfs2m45Jfc7LXXBG4nXyBn || __p_SF1lAJkMnBnOpjPdcWrO5I != this.__p_SF1lAJkMnBnOpjPdcWrO5I || __p_VFtZIjpOweCOmi8gPBAeNG != this.__p_VFtZIjpOweCOmi8gPBAeNG || __p_UnemOeB8pXmNLT2omuTfkm != this.__p_UnemOeB8pXmNLT2omuTfkm || __p_LPaQ42lFjWGOoFO9nkKxiS != this.__p_LPaQ42lFjWGOoFO9nkKxiS || __pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm != this.__pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm || __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51 != this.__pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51 || __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8 != this.__pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8 || __monadBuilder_NEBvdPllkwTNm1gMqvnUnb != this.__monadBuilder_NEBvdPllkwTNm1gMqvnUnb || __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I != this.__pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I || __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn != this.__pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn ? new __K5qZfH2Qg32P45HPQtBXSI(this)
                    {__p_AgaNM22eZPLNFyVCJmFe5a = __p_AgaNM22eZPLNFyVCJmFe5a, __p_JIDbuAk34P4QUvz4kGoWfg = __p_JIDbuAk34P4QUvz4kGoWfg, __p_KD19XgGkdifQNVnfvLbQDw = __p_KD19XgGkdifQNVnfvLbQDw, __p_UJZjRlJogJrNWgX7Qa9g51 = __p_UJZjRlJogJrNWgX7Qa9g51, __p_NkY6dmd26LZN6JPb7Ehjcr = __p_NkY6dmd26LZN6JPb7Ehjcr, __p_GSPGfyiDAHGLZcaGHb650e = __p_GSPGfyiDAHGLZcaGHb650e, __p_NCzfB6htQDnOl4jM0UcYUx = __p_NCzfB6htQDnOl4jM0UcYUx, __p_FUy0Huk6WOfLrp6vzDDGs8 = __p_FUy0Huk6WOfLrp6vzDDGs8, __p_N5ffrDonp3nQFswasH3URD = __p_N5ffrDonp3nQFswasH3URD, __p_Jfs2m45Jfc7LXXBG4nXyBn = __p_Jfs2m45Jfc7LXXBG4nXyBn, __p_SF1lAJkMnBnOpjPdcWrO5I = __p_SF1lAJkMnBnOpjPdcWrO5I, __p_VFtZIjpOweCOmi8gPBAeNG = __p_VFtZIjpOweCOmi8gPBAeNG, __p_UnemOeB8pXmNLT2omuTfkm = __p_UnemOeB8pXmNLT2omuTfkm, __p_LPaQ42lFjWGOoFO9nkKxiS = __p_LPaQ42lFjWGOoFO9nkKxiS, __pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm = __pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm, __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51 = __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51, __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8 = __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8, __monadBuilder_NEBvdPllkwTNm1gMqvnUnb = __monadBuilder_NEBvdPllkwTNm1gMqvnUnb, __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I = __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I, __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn = __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn} : that_0;
                else
                {
                    this.__p_AgaNM22eZPLNFyVCJmFe5a = __p_AgaNM22eZPLNFyVCJmFe5a;
                    this.__p_JIDbuAk34P4QUvz4kGoWfg = __p_JIDbuAk34P4QUvz4kGoWfg;
                    this.__p_KD19XgGkdifQNVnfvLbQDw = __p_KD19XgGkdifQNVnfvLbQDw;
                    this.__p_UJZjRlJogJrNWgX7Qa9g51 = __p_UJZjRlJogJrNWgX7Qa9g51;
                    this.__p_NkY6dmd26LZN6JPb7Ehjcr = __p_NkY6dmd26LZN6JPb7Ehjcr;
                    this.__p_GSPGfyiDAHGLZcaGHb650e = __p_GSPGfyiDAHGLZcaGHb650e;
                    this.__p_NCzfB6htQDnOl4jM0UcYUx = __p_NCzfB6htQDnOl4jM0UcYUx;
                    this.__p_FUy0Huk6WOfLrp6vzDDGs8 = __p_FUy0Huk6WOfLrp6vzDDGs8;
                    this.__p_N5ffrDonp3nQFswasH3URD = __p_N5ffrDonp3nQFswasH3URD;
                    this.__p_Jfs2m45Jfc7LXXBG4nXyBn = __p_Jfs2m45Jfc7LXXBG4nXyBn;
                    this.__p_SF1lAJkMnBnOpjPdcWrO5I = __p_SF1lAJkMnBnOpjPdcWrO5I;
                    this.__p_VFtZIjpOweCOmi8gPBAeNG = __p_VFtZIjpOweCOmi8gPBAeNG;
                    this.__p_UnemOeB8pXmNLT2omuTfkm = __p_UnemOeB8pXmNLT2omuTfkm;
                    this.__p_LPaQ42lFjWGOoFO9nkKxiS = __p_LPaQ42lFjWGOoFO9nkKxiS;
                    this.__pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm = __pin_group_Input_In_UnemOeB8pXmNLT2omuTfkm;
                    this.__pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51 = __pin_group_Input_In_UJZjRlJogJrNWgX7Qa9g51;
                    this.__pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8 = __pin_group_Input_In_FUy0Huk6WOfLrp6vzDDGs8;
                    this.__monadBuilder_NEBvdPllkwTNm1gMqvnUnb = __monadBuilder_NEBvdPllkwTNm1gMqvnUnb;
                    this.__pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I = __pin_group_Input_In_SF1lAJkMnBnOpjPdcWrO5I;
                    this.__pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn = __pin_group_Input_In_Jfs2m45Jfc7LXXBG4nXyBn;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 346261U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "OlqDSUtCYr5NcVUyqQtCVH", Name = "CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH")]
    [n2.SerializableAttribute]
    public class CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n28.CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH Create(n1.NodeContext Node_Context)
        {
            var instance = new CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n28.CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH CreateDefault()
        {
            var instance = new CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n28.CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH Update(n5.GpuValue<n22.Vector2> Input_In, [n4.SerializedDefaultValueAttribute("0.5, 0.5", false)] n5.GpuValue<n22.Vector2> Center_In, [n4.SerializedDefaultValueAttribute("1", false)] n5.GpuValue<float> Radial_Scale_In, [n4.SerializedDefaultValueAttribute("1", false)] n5.GpuValue<float> Length_Scale_In, out n5.GpuValue<n22.Vector2> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_K1WZCTvWgL4Ly97vzSGSHj;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<n22.Vector2>, n5.GpuValue<n22.Vector2>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>>(n2.ValueTuple.Create(default(n5.GpuValue<n22.Vector2>)));
            }

            var inputs_3 = (Radial_Scale_In, Input_In, Center_In, Length_Scale_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__IX8qb0NdzN1LjZtV8cENWK>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __IX8qb0NdzN1LjZtV8cENWK(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_Av01RutcMExMJlE3MMzEam = n17._Operations_.CreateDefault<n5.GpuValue<n22.Vector2>>(), __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU = n17._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D = n17._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD = n17._Operations_.CreateDefault<n5.GpuValue<float>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Av01RutcMExMJlE3MMzEam", 346315U);
                    var Output_8 = n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n22.Vector2>.Create(Node_Context: Node_Context_7);
                    state_6.__p_Av01RutcMExMJlE3MMzEam = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Ud0ncSx119DNq5EDzSTLgN", 346332U);
                    var Output_10 = n20.Length_P0UB6WKESd0PjWRm8eD1d4<n22.Vector2>.Create(Node_Context: Node_Context_9);
                    state_6.__p_Ud0ncSx119DNq5EDzSTLgN = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "K8KnOXZwU5AOOOPcOVCZtU", 346352U);
                    var Output_12 = n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_11);
                    state_6.__p_K8KnOXZwU5AOOOPcOVCZtU = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "E3XU0wQxnmAMEHmFfWr0fH", 346378U);
                    var Output_14 = n20.Atan2_GuLg9Ro6ddFQccAYPgzvXF<float>.Create(Node_Context: Node_Context_13);
                    state_6.__p_E3XU0wQxnmAMEHmFfWr0fH = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "NfnepcbF2M6Od7hyqQ34FL", 346388U);
                    var Output_16 = n40.x_CThKQPdF8roMfrpnCR01ll<n22.Vector2>.Create(Node_Context: Node_Context_15);
                    state_6.__p_NfnepcbF2M6Od7hyqQ34FL = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "T4RwiJxM5aPOtQAa3Gh6mM", 346405U);
                    var Output_18 = n40.y_EqOmImsLEfKMwPNqId2m1L<n22.Vector2>.Create(Node_Context: Node_Context_17);
                    state_6.__p_T4RwiJxM5aPOtQAa3Gh6mM = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "ABYuWlLsE12MqEFFFdRb6D", 346431U);
                    var Output_20 = n20.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<float>.Create(Node_Context: Node_Context_19);
                    state_6.__p_ABYuWlLsE12MqEFFFdRb6D = Output_20;
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "AC1xfMIMAWRP5vOFJFnah8", 346445U);
                    var Output_22 = n20.TWO_PI_CD2xtJr8wQ0PlBSQnIljMI<float>.Create(Node_Context: Node_Context_21);
                    state_6.__p_AC1xfMIMAWRP5vOFJFnah8 = Output_22;
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "ILrPbtDctjiMF6HG8OYLi1", 346455U);
                    var Output_24 = n41.xPy_join_JIONWu6byjBM6yvKcs4o8k.Create(Node_Context: Node_Context_23);
                    state_6.__p_ILrPbtDctjiMF6HG8OYLi1 = Output_24;
                    n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "IIJA0C6XbdsO9Mi7QCS3RD", 346465U);
                    var Output_26 = n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_25);
                    state_6.__p_IIJA0C6XbdsO9Mi7QCS3RD = Output_26;
                    n37._Operations_.ScreenToUV2DID(Output_Out: out string Output_27);
                    n1.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "P5FYLn4XYFMOQITj6ViPjS", 346474U);
                    var Output_29 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_28, ID_In: Output_27);
                    state_6.__p_P5FYLn4XYFMOQITj6ViPjS = Output_29;
                }

                float __pad_Bf5CmCJgKWDNmdbt1xSzck_30 = __slot_Bf5CmCJgKWDNmdbt1xSzck;
                var builder_31 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Av01RutcMExMJlE3MMzEam, 2);
                builder_31.Add(Input_In);
                builder_31.Add(Center_In);
                var __pin_group_Input_In_Av01RutcMExMJlE3MMzEam_32 = builder_31.Commit();
                var State_Output_34 = state_6.__p_Av01RutcMExMJlE3MMzEam.Update(Input_In: __pin_group_Input_In_Av01RutcMExMJlE3MMzEam_32, Output_Out: out n5.GpuValue<n22.Vector2> Output_33);
                var State_Output_36 = state_6.__p_Ud0ncSx119DNq5EDzSTLgN.Update(Input_In: Output_33, Output_Out: out n5.GpuValue<float> Output_35);
                n5.GpuValue<float> Input_2_37 = state_6.__monadBuilder_BzTtfVhpmykLAPcAEvFrkf.Return(__pad_Bf5CmCJgKWDNmdbt1xSzck_30);
                var builder_38 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU, 3);
                builder_38.Add(Output_35);
                builder_38.Add(Input_2_37);
                builder_38.Add(Radial_Scale_In);
                var __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU_39 = builder_38.Commit();
                var State_Output_41 = state_6.__p_K8KnOXZwU5AOOOPcOVCZtU.Update(Input_In: __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU_39, Output_Out: out n5.GpuValue<float> Output_40);
                var State_Output_43 = state_6.__p_NfnepcbF2M6Od7hyqQ34FL.Update(Input_In: Output_33, Output_Out: out n5.GpuValue<float> Output_42);
                var State_Output_45 = state_6.__p_T4RwiJxM5aPOtQAa3Gh6mM.Update(Input_In: Output_33, Output_Out: out n5.GpuValue<float> Output_44);
                var State_Output_47 = state_6.__p_E3XU0wQxnmAMEHmFfWr0fH.Update(Input1_In: Output_42, Input2_In: Output_44, Output_Out: out n5.GpuValue<float> Output_46);
                var State_Output_49 = state_6.__p_AC1xfMIMAWRP5vOFJFnah8.Update(Output_Out: out n5.GpuValue<float> Output_48);
                var builder_50 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D, 2);
                builder_50.Add(Output_46);
                builder_50.Add(Output_48);
                var __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D_51 = builder_50.Commit();
                var State_Output_53 = state_6.__p_ABYuWlLsE12MqEFFFdRb6D.Update(Input_In: __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D_51, Output_Out: out n5.GpuValue<float> Output_52);
                var builder_54 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD, 2);
                builder_54.Add(Output_52);
                builder_54.Add(Length_Scale_In);
                var __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD_55 = builder_54.Commit();
                var State_Output_57 = state_6.__p_IIJA0C6XbdsO9Mi7QCS3RD.Update(Input_In: __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD_55, Output_Out: out n5.GpuValue<float> Output_56);
                var State_Output_59 = state_6.__p_ILrPbtDctjiMF6HG8OYLi1.Update(x_In: Output_40, y_In: Output_56, Output_Out: out n5.GpuValue<n22.Vector2> Output_58);
                bool Update_60 = true;
                var Output_61 = state_6.__p_P5FYLn4XYFMOQITj6ViPjS;
                if (Update_60)
                {
                    Output_61 = state_6.__p_P5FYLn4XYFMOQITj6ViPjS.Update(Input_In: Output_58);
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = __pin_group_Input_In_Av01RutcMExMJlE3MMzEam_32 != state_6.__pin_group_Input_In_Av01RutcMExMJlE3MMzEam || State_Output_34 != state_6.__p_Av01RutcMExMJlE3MMzEam || State_Output_36 != state_6.__p_Ud0ncSx119DNq5EDzSTLgN || __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU_39 != state_6.__pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU || State_Output_41 != state_6.__p_K8KnOXZwU5AOOOPcOVCZtU || State_Output_43 != state_6.__p_NfnepcbF2M6Od7hyqQ34FL || State_Output_45 != state_6.__p_T4RwiJxM5aPOtQAa3Gh6mM || State_Output_47 != state_6.__p_E3XU0wQxnmAMEHmFfWr0fH || State_Output_49 != state_6.__p_AC1xfMIMAWRP5vOFJFnah8 || __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D_51 != state_6.__pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D || State_Output_53 != state_6.__p_ABYuWlLsE12MqEFFFdRb6D || __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD_55 != state_6.__pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD || State_Output_57 != state_6.__p_IIJA0C6XbdsO9Mi7QCS3RD || State_Output_59 != state_6.__p_ILrPbtDctjiMF6HG8OYLi1 || Output_61 != state_6.__p_P5FYLn4XYFMOQITj6ViPjS ? new __IX8qb0NdzN1LjZtV8cENWK(state_6)
                    {__pin_group_Input_In_Av01RutcMExMJlE3MMzEam = __pin_group_Input_In_Av01RutcMExMJlE3MMzEam_32, __p_Av01RutcMExMJlE3MMzEam = State_Output_34, __p_Ud0ncSx119DNq5EDzSTLgN = State_Output_36, __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU = __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU_39, __p_K8KnOXZwU5AOOOPcOVCZtU = State_Output_41, __p_NfnepcbF2M6Od7hyqQ34FL = State_Output_43, __p_T4RwiJxM5aPOtQAa3Gh6mM = State_Output_45, __p_E3XU0wQxnmAMEHmFfWr0fH = State_Output_47, __p_AC1xfMIMAWRP5vOFJFnah8 = State_Output_49, __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D = __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D_51, __p_ABYuWlLsE12MqEFFFdRb6D = State_Output_53, __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD = __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD_55, __p_IIJA0C6XbdsO9Mi7QCS3RD = State_Output_57, __p_ILrPbtDctjiMF6HG8OYLi1 = State_Output_59, __p_P5FYLn4XYFMOQITj6ViPjS = Output_61} : state_6;
                else
                {
                    state_6.__pin_group_Input_In_Av01RutcMExMJlE3MMzEam = __pin_group_Input_In_Av01RutcMExMJlE3MMzEam_32;
                    state_6.__p_Av01RutcMExMJlE3MMzEam = State_Output_34;
                    state_6.__p_Ud0ncSx119DNq5EDzSTLgN = State_Output_36;
                    state_6.__pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU = __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU_39;
                    state_6.__p_K8KnOXZwU5AOOOPcOVCZtU = State_Output_41;
                    state_6.__p_NfnepcbF2M6Od7hyqQ34FL = State_Output_43;
                    state_6.__p_T4RwiJxM5aPOtQAa3Gh6mM = State_Output_45;
                    state_6.__p_E3XU0wQxnmAMEHmFfWr0fH = State_Output_47;
                    state_6.__p_AC1xfMIMAWRP5vOFJFnah8 = State_Output_49;
                    state_6.__pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D = __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D_51;
                    state_6.__p_ABYuWlLsE12MqEFFFdRb6D = State_Output_53;
                    state_6.__pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD = __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD_55;
                    state_6.__p_IIJA0C6XbdsO9Mi7QCS3RD = State_Output_57;
                    state_6.__p_ILrPbtDctjiMF6HG8OYLi1 = State_Output_59;
                    state_6.__p_P5FYLn4XYFMOQITj6ViPjS = Output_61;
                }

                outputs_4 = n2.ValueTuple.Create(Output_58);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_62 = outputs_4.Item1;
            Output_Out = __auto_62;
            n28.CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH that_63 = this;
            if (this.__GetContext__().IsImmutable)
                that_63 = manager_2 != this.__cache_K1WZCTvWgL4Ly97vzSGSHj ? new CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH(this)
                {__cache_K1WZCTvWgL4Ly97vzSGSHj = manager_2} : that_63;
            else
            {
                this.__cache_K1WZCTvWgL4Ly97vzSGSHj = manager_2;
            }

            return that_63;
        }

        public n28.CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n28.CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH that_0 = this;
            this.__cache_K1WZCTvWgL4Ly97vzSGSHj = null;
            return that_0;
        }

        public n28.CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH __CreateDefault__()
        {
            n28.CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH that_0 = this;
            this.__cache_K1WZCTvWgL4Ly97vzSGSHj = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_K1WZCTvWgL4Ly97vzSGSHj);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 346294U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "K1WZCTvWgL4Ly97vzSGSHj", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<n22.Vector2>, n5.GpuValue<n22.Vector2>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_K1WZCTvWgL4Ly97vzSGSHj = null;
        [n1.ElementAttribute(TracingId = 346371U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Bf5CmCJgKWDNmdbt1xSzck", Name = "__slot_Bf5CmCJgKWDNmdbt1xSzck")]
        public static float __slot_Bf5CmCJgKWDNmdbt1xSzck = 2F;
        static CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH()
        {
        }

        public CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH(CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH other): base(other)
        {
            this.__cache_K1WZCTvWgL4Ly97vzSGSHj = other.__cache_K1WZCTvWgL4Ly97vzSGSHj;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_K1WZCTvWgL4Ly97vzSGSHj", in __cache_K1WZCTvWgL4Ly97vzSGSHj));
        }

        internal CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<n22.Vector2>, n5.GpuValue<n22.Vector2>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<n22.Vector2>>> __cache_K1WZCTvWgL4Ly97vzSGSHj)
        {
            n28.CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_K1WZCTvWgL4Ly97vzSGSHj != this.__cache_K1WZCTvWgL4Ly97vzSGSHj ? new CartesianToPolar_OlqDSUtCYr5NcVUyqQtCVH(this)
                {__cache_K1WZCTvWgL4Ly97vzSGSHj = __cache_K1WZCTvWgL4Ly97vzSGSHj} : that_0;
            else
            {
                this.__cache_K1WZCTvWgL4Ly97vzSGSHj = __cache_K1WZCTvWgL4Ly97vzSGSHj;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "IX8qb0NdzN1LjZtV8cENWK", Name = "__IX8qb0NdzN1LjZtV8cENWK")]
        [n2.SerializableAttribute]
        public class __IX8qb0NdzN1LjZtV8cENWK : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Av01RutcMExMJlE3MMzEam);
                n1.CompilationHelper.SafeDispose(this.__p_Ud0ncSx119DNq5EDzSTLgN);
                n1.CompilationHelper.SafeDispose(this.__p_K8KnOXZwU5AOOOPcOVCZtU);
                n1.CompilationHelper.SafeDispose(this.__p_E3XU0wQxnmAMEHmFfWr0fH);
                n1.CompilationHelper.SafeDispose(this.__p_NfnepcbF2M6Od7hyqQ34FL);
                n1.CompilationHelper.SafeDispose(this.__p_T4RwiJxM5aPOtQAa3Gh6mM);
                n1.CompilationHelper.SafeDispose(this.__p_ABYuWlLsE12MqEFFFdRb6D);
                n1.CompilationHelper.SafeDispose(this.__p_AC1xfMIMAWRP5vOFJFnah8);
                n1.CompilationHelper.SafeDispose(this.__p_ILrPbtDctjiMF6HG8OYLi1);
                n1.CompilationHelper.SafeDispose(this.__p_IIJA0C6XbdsO9Mi7QCS3RD);
                n1.CompilationHelper.SafeDispose(this.__p_P5FYLn4XYFMOQITj6ViPjS);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_BzTtfVhpmykLAPcAEvFrkf);
                return;
            }

            [n1.ElementAttribute(TracingId = 346315U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Av01RutcMExMJlE3MMzEam", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n22.Vector2> __p_Av01RutcMExMJlE3MMzEam;
            [n1.ElementAttribute(TracingId = 346332U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Ud0ncSx119DNq5EDzSTLgN", Name = "Length", IsManaged = true, IsAutoGenerated = true)]
            public n20.Length_P0UB6WKESd0PjWRm8eD1d4<n22.Vector2> __p_Ud0ncSx119DNq5EDzSTLgN;
            [n1.ElementAttribute(TracingId = 346352U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "K8KnOXZwU5AOOOPcOVCZtU", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_K8KnOXZwU5AOOOPcOVCZtU;
            [n1.ElementAttribute(TracingId = 346378U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "E3XU0wQxnmAMEHmFfWr0fH", Name = "Atan2", IsManaged = true, IsAutoGenerated = true)]
            public n20.Atan2_GuLg9Ro6ddFQccAYPgzvXF<float> __p_E3XU0wQxnmAMEHmFfWr0fH;
            [n1.ElementAttribute(TracingId = 346388U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "NfnepcbF2M6Od7hyqQ34FL", Name = "x", IsManaged = true, IsAutoGenerated = true)]
            public n40.x_CThKQPdF8roMfrpnCR01ll<n22.Vector2> __p_NfnepcbF2M6Od7hyqQ34FL;
            [n1.ElementAttribute(TracingId = 346405U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "T4RwiJxM5aPOtQAa3Gh6mM", Name = "y", IsManaged = true, IsAutoGenerated = true)]
            public n40.y_EqOmImsLEfKMwPNqId2m1L<n22.Vector2> __p_T4RwiJxM5aPOtQAa3Gh6mM;
            [n1.ElementAttribute(TracingId = 346431U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "ABYuWlLsE12MqEFFFdRb6D", Name = "/", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<float> __p_ABYuWlLsE12MqEFFFdRb6D;
            [n1.ElementAttribute(TracingId = 346445U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "AC1xfMIMAWRP5vOFJFnah8", Name = "TWO_PI", IsManaged = true, IsAutoGenerated = true)]
            public n20.TWO_PI_CD2xtJr8wQ0PlBSQnIljMI<float> __p_AC1xfMIMAWRP5vOFJFnah8;
            [n1.ElementAttribute(TracingId = 346455U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "ILrPbtDctjiMF6HG8OYLi1", Name = "x+y (join)", IsManaged = true, IsAutoGenerated = true)]
            public n41.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_ILrPbtDctjiMF6HG8OYLi1;
            [n1.ElementAttribute(TracingId = 346465U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "IIJA0C6XbdsO9Mi7QCS3RD", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_IIJA0C6XbdsO9Mi7QCS3RD;
            [n1.ElementAttribute(TracingId = 346474U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "P5FYLn4XYFMOQITj6ViPjS", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_P5FYLn4XYFMOQITj6ViPjS;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<n22.Vector2>> __pin_group_Input_In_Av01RutcMExMJlE3MMzEam = default(n11.Spread<n5.GpuValue<n22.Vector2>>);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<float, n5.GpuValue<float>> __monadBuilder_BzTtfVhpmykLAPcAEvFrkf = n5.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU = default(n11.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D = default(n11.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD = default(n11.Spread<n5.GpuValue<float>>);
            public __IX8qb0NdzN1LjZtV8cENWK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __IX8qb0NdzN1LjZtV8cENWK(__IX8qb0NdzN1LjZtV8cENWK other): base(other)
            {
                this.__p_Av01RutcMExMJlE3MMzEam = other.__p_Av01RutcMExMJlE3MMzEam;
                this.__p_Ud0ncSx119DNq5EDzSTLgN = other.__p_Ud0ncSx119DNq5EDzSTLgN;
                this.__p_K8KnOXZwU5AOOOPcOVCZtU = other.__p_K8KnOXZwU5AOOOPcOVCZtU;
                this.__p_E3XU0wQxnmAMEHmFfWr0fH = other.__p_E3XU0wQxnmAMEHmFfWr0fH;
                this.__p_NfnepcbF2M6Od7hyqQ34FL = other.__p_NfnepcbF2M6Od7hyqQ34FL;
                this.__p_T4RwiJxM5aPOtQAa3Gh6mM = other.__p_T4RwiJxM5aPOtQAa3Gh6mM;
                this.__p_ABYuWlLsE12MqEFFFdRb6D = other.__p_ABYuWlLsE12MqEFFFdRb6D;
                this.__p_AC1xfMIMAWRP5vOFJFnah8 = other.__p_AC1xfMIMAWRP5vOFJFnah8;
                this.__p_ILrPbtDctjiMF6HG8OYLi1 = other.__p_ILrPbtDctjiMF6HG8OYLi1;
                this.__p_IIJA0C6XbdsO9Mi7QCS3RD = other.__p_IIJA0C6XbdsO9Mi7QCS3RD;
                this.__p_P5FYLn4XYFMOQITj6ViPjS = other.__p_P5FYLn4XYFMOQITj6ViPjS;
                this.__pin_group_Input_In_Av01RutcMExMJlE3MMzEam = other.__pin_group_Input_In_Av01RutcMExMJlE3MMzEam;
                this.__monadBuilder_BzTtfVhpmykLAPcAEvFrkf = other.__monadBuilder_BzTtfVhpmykLAPcAEvFrkf;
                this.__pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU = other.__pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU;
                this.__pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D = other.__pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D;
                this.__pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD = other.__pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Av01RutcMExMJlE3MMzEam", in __p_Av01RutcMExMJlE3MMzEam), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ud0ncSx119DNq5EDzSTLgN", in __p_Ud0ncSx119DNq5EDzSTLgN), n1.CompilationHelper.GetValueOrExisting(values, "__p_K8KnOXZwU5AOOOPcOVCZtU", in __p_K8KnOXZwU5AOOOPcOVCZtU), n1.CompilationHelper.GetValueOrExisting(values, "__p_E3XU0wQxnmAMEHmFfWr0fH", in __p_E3XU0wQxnmAMEHmFfWr0fH), n1.CompilationHelper.GetValueOrExisting(values, "__p_NfnepcbF2M6Od7hyqQ34FL", in __p_NfnepcbF2M6Od7hyqQ34FL), n1.CompilationHelper.GetValueOrExisting(values, "__p_T4RwiJxM5aPOtQAa3Gh6mM", in __p_T4RwiJxM5aPOtQAa3Gh6mM), n1.CompilationHelper.GetValueOrExisting(values, "__p_ABYuWlLsE12MqEFFFdRb6D", in __p_ABYuWlLsE12MqEFFFdRb6D), n1.CompilationHelper.GetValueOrExisting(values, "__p_AC1xfMIMAWRP5vOFJFnah8", in __p_AC1xfMIMAWRP5vOFJFnah8), n1.CompilationHelper.GetValueOrExisting(values, "__p_ILrPbtDctjiMF6HG8OYLi1", in __p_ILrPbtDctjiMF6HG8OYLi1), n1.CompilationHelper.GetValueOrExisting(values, "__p_IIJA0C6XbdsO9Mi7QCS3RD", in __p_IIJA0C6XbdsO9Mi7QCS3RD), n1.CompilationHelper.GetValueOrExisting(values, "__p_P5FYLn4XYFMOQITj6ViPjS", in __p_P5FYLn4XYFMOQITj6ViPjS), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Av01RutcMExMJlE3MMzEam", in __pin_group_Input_In_Av01RutcMExMJlE3MMzEam), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_BzTtfVhpmykLAPcAEvFrkf", in __monadBuilder_BzTtfVhpmykLAPcAEvFrkf), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU", in __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D", in __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD", in __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD));
            }

            internal __IX8qb0NdzN1LjZtV8cENWK __WITH__(n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n22.Vector2> __p_Av01RutcMExMJlE3MMzEam, n20.Length_P0UB6WKESd0PjWRm8eD1d4<n22.Vector2> __p_Ud0ncSx119DNq5EDzSTLgN, n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_K8KnOXZwU5AOOOPcOVCZtU, n20.Atan2_GuLg9Ro6ddFQccAYPgzvXF<float> __p_E3XU0wQxnmAMEHmFfWr0fH, n40.x_CThKQPdF8roMfrpnCR01ll<n22.Vector2> __p_NfnepcbF2M6Od7hyqQ34FL, n40.y_EqOmImsLEfKMwPNqId2m1L<n22.Vector2> __p_T4RwiJxM5aPOtQAa3Gh6mM, n20.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<float> __p_ABYuWlLsE12MqEFFFdRb6D, n20.TWO_PI_CD2xtJr8wQ0PlBSQnIljMI<float> __p_AC1xfMIMAWRP5vOFJFnah8, n41.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_ILrPbtDctjiMF6HG8OYLi1, n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_IIJA0C6XbdsO9Mi7QCS3RD, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_P5FYLn4XYFMOQITj6ViPjS, n11.Spread<n5.GpuValue<n22.Vector2>> __pin_group_Input_In_Av01RutcMExMJlE3MMzEam, n1.IMonadBuilder<float, n5.GpuValue<float>> __monadBuilder_BzTtfVhpmykLAPcAEvFrkf, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD)
            {
                __IX8qb0NdzN1LjZtV8cENWK that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Av01RutcMExMJlE3MMzEam != this.__p_Av01RutcMExMJlE3MMzEam || __p_Ud0ncSx119DNq5EDzSTLgN != this.__p_Ud0ncSx119DNq5EDzSTLgN || __p_K8KnOXZwU5AOOOPcOVCZtU != this.__p_K8KnOXZwU5AOOOPcOVCZtU || __p_E3XU0wQxnmAMEHmFfWr0fH != this.__p_E3XU0wQxnmAMEHmFfWr0fH || __p_NfnepcbF2M6Od7hyqQ34FL != this.__p_NfnepcbF2M6Od7hyqQ34FL || __p_T4RwiJxM5aPOtQAa3Gh6mM != this.__p_T4RwiJxM5aPOtQAa3Gh6mM || __p_ABYuWlLsE12MqEFFFdRb6D != this.__p_ABYuWlLsE12MqEFFFdRb6D || __p_AC1xfMIMAWRP5vOFJFnah8 != this.__p_AC1xfMIMAWRP5vOFJFnah8 || __p_ILrPbtDctjiMF6HG8OYLi1 != this.__p_ILrPbtDctjiMF6HG8OYLi1 || __p_IIJA0C6XbdsO9Mi7QCS3RD != this.__p_IIJA0C6XbdsO9Mi7QCS3RD || __p_P5FYLn4XYFMOQITj6ViPjS != this.__p_P5FYLn4XYFMOQITj6ViPjS || __pin_group_Input_In_Av01RutcMExMJlE3MMzEam != this.__pin_group_Input_In_Av01RutcMExMJlE3MMzEam || __monadBuilder_BzTtfVhpmykLAPcAEvFrkf != this.__monadBuilder_BzTtfVhpmykLAPcAEvFrkf || __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU != this.__pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU || __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D != this.__pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D || __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD != this.__pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD ? new __IX8qb0NdzN1LjZtV8cENWK(this)
                    {__p_Av01RutcMExMJlE3MMzEam = __p_Av01RutcMExMJlE3MMzEam, __p_Ud0ncSx119DNq5EDzSTLgN = __p_Ud0ncSx119DNq5EDzSTLgN, __p_K8KnOXZwU5AOOOPcOVCZtU = __p_K8KnOXZwU5AOOOPcOVCZtU, __p_E3XU0wQxnmAMEHmFfWr0fH = __p_E3XU0wQxnmAMEHmFfWr0fH, __p_NfnepcbF2M6Od7hyqQ34FL = __p_NfnepcbF2M6Od7hyqQ34FL, __p_T4RwiJxM5aPOtQAa3Gh6mM = __p_T4RwiJxM5aPOtQAa3Gh6mM, __p_ABYuWlLsE12MqEFFFdRb6D = __p_ABYuWlLsE12MqEFFFdRb6D, __p_AC1xfMIMAWRP5vOFJFnah8 = __p_AC1xfMIMAWRP5vOFJFnah8, __p_ILrPbtDctjiMF6HG8OYLi1 = __p_ILrPbtDctjiMF6HG8OYLi1, __p_IIJA0C6XbdsO9Mi7QCS3RD = __p_IIJA0C6XbdsO9Mi7QCS3RD, __p_P5FYLn4XYFMOQITj6ViPjS = __p_P5FYLn4XYFMOQITj6ViPjS, __pin_group_Input_In_Av01RutcMExMJlE3MMzEam = __pin_group_Input_In_Av01RutcMExMJlE3MMzEam, __monadBuilder_BzTtfVhpmykLAPcAEvFrkf = __monadBuilder_BzTtfVhpmykLAPcAEvFrkf, __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU = __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU, __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D = __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D, __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD = __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD} : that_0;
                else
                {
                    this.__p_Av01RutcMExMJlE3MMzEam = __p_Av01RutcMExMJlE3MMzEam;
                    this.__p_Ud0ncSx119DNq5EDzSTLgN = __p_Ud0ncSx119DNq5EDzSTLgN;
                    this.__p_K8KnOXZwU5AOOOPcOVCZtU = __p_K8KnOXZwU5AOOOPcOVCZtU;
                    this.__p_E3XU0wQxnmAMEHmFfWr0fH = __p_E3XU0wQxnmAMEHmFfWr0fH;
                    this.__p_NfnepcbF2M6Od7hyqQ34FL = __p_NfnepcbF2M6Od7hyqQ34FL;
                    this.__p_T4RwiJxM5aPOtQAa3Gh6mM = __p_T4RwiJxM5aPOtQAa3Gh6mM;
                    this.__p_ABYuWlLsE12MqEFFFdRb6D = __p_ABYuWlLsE12MqEFFFdRb6D;
                    this.__p_AC1xfMIMAWRP5vOFJFnah8 = __p_AC1xfMIMAWRP5vOFJFnah8;
                    this.__p_ILrPbtDctjiMF6HG8OYLi1 = __p_ILrPbtDctjiMF6HG8OYLi1;
                    this.__p_IIJA0C6XbdsO9Mi7QCS3RD = __p_IIJA0C6XbdsO9Mi7QCS3RD;
                    this.__p_P5FYLn4XYFMOQITj6ViPjS = __p_P5FYLn4XYFMOQITj6ViPjS;
                    this.__pin_group_Input_In_Av01RutcMExMJlE3MMzEam = __pin_group_Input_In_Av01RutcMExMJlE3MMzEam;
                    this.__monadBuilder_BzTtfVhpmykLAPcAEvFrkf = __monadBuilder_BzTtfVhpmykLAPcAEvFrkf;
                    this.__pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU = __pin_group_Input_In_K8KnOXZwU5AOOOPcOVCZtU;
                    this.__pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D = __pin_group_Input_In_ABYuWlLsE12MqEFFFdRb6D;
                    this.__pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD = __pin_group_Input_In_IIJA0C6XbdsO9Mi7QCS3RD;
                }

                return that_0;
            }
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain._2D.WorldToHex
{
    [n1.ElementAttribute(TracingId = 343058U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void WorldToHex2DID(out string Output_Out)
        {
            string __pad_Ix3ZczpLO8oNaWCRQ4cTQR_0 = __slot_Ix3ZczpLO8oNaWCRQ4cTQR;
            Output_Out = __pad_Ix3ZczpLO8oNaWCRQ4cTQR_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 343931U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Ix3ZczpLO8oNaWCRQ4cTQR", Name = "__slot_Ix3ZczpLO8oNaWCRQ4cTQR")]
        public static string __slot_Ix3ZczpLO8oNaWCRQ4cTQR = "WorldToHex2D";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain._2D.HexToWorld
{
    [n1.ElementAttribute(TracingId = 343058U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void HexToWorld2DID(out string Output_Out)
        {
            string __pad_AJjJs1kiKhQLXRh5E7acTj_0 = __slot_AJjJs1kiKhQLXRh5E7acTj;
            Output_Out = __pad_AJjJs1kiKhQLXRh5E7acTj_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 344093U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "AJjJs1kiKhQLXRh5E7acTj", Name = "__slot_AJjJs1kiKhQLXRh5E7acTj")]
        public static string __slot_AJjJs1kiKhQLXRh5E7acTj = "HexToWorld2D";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain._2D.WorldToTri
{
    [n1.ElementAttribute(TracingId = 343058U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void WorldToTri2DID(out string Output_Out)
        {
            string __pad_LDEN1YRoPvYPUp9TUSo1rS_0 = __slot_LDEN1YRoPvYPUp9TUSo1rS;
            Output_Out = __pad_LDEN1YRoPvYPUp9TUSo1rS_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 344228U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "LDEN1YRoPvYPUp9TUSo1rS", Name = "__slot_LDEN1YRoPvYPUp9TUSo1rS")]
        public static string __slot_LDEN1YRoPvYPUp9TUSo1rS = "WorldToTri2D";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain._2D.TriToWorld
{
    [n1.ElementAttribute(TracingId = 343058U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void TriToWorld2DID(out string Output_Out)
        {
            string __pad_JsX1kqDpen3MVgTL9ITC53_0 = __slot_JsX1kqDpen3MVgTL9ITC53;
            Output_Out = __pad_JsX1kqDpen3MVgTL9ITC53_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 344423U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "JsX1kqDpen3MVgTL9ITC53", Name = "__slot_JsX1kqDpen3MVgTL9ITC53")]
        public static string __slot_JsX1kqDpen3MVgTL9ITC53 = "TriToWorld2D";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain._2D.DomainRepeat
{
    [n1.ElementAttribute(TracingId = 343058U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void DomainRepeat2DID(out string Output_Out)
        {
            string __pad_F71TRmMxmWrLzg8Bj2cbaH_0 = __slot_F71TRmMxmWrLzg8Bj2cbaH;
            Output_Out = __pad_F71TRmMxmWrLzg8Bj2cbaH_0;
            return;
        }

        public static void DomainRepeatCell2DID(out string Output_Out)
        {
            string __pad_F3ONVQEqeZXOhOvftDfgjz_0 = __slot_F3ONVQEqeZXOhOvftDfgjz;
            Output_Out = __pad_F3ONVQEqeZXOhOvftDfgjz_0;
            return;
        }

        public static void TemplateValues(int Op_In, out n15.ImmutableDictionary<string, string> Output_Out)
        {
            n15.ImmutableDictionary<string, string> __pin_group_Input_In_UkYrRUDnLgdL6EZf76JnNP = default(n15.ImmutableDictionary<string, string>);
            string __pad_POY2rCJcoGHPKiYSKFZo8w_0 = __slot_POY2rCJcoGHPKiYSKFZo8w;
            string __pad_G1IWdeGoLWnLTkaFXlrrvg_1 = __slot_G1IWdeGoLWnLTkaFXlrrvg;
            var New_Line_2 = n44.StringExtensions.NewLine;
            n2.StringSplitOptions Options_3 = default(n2.StringSplitOptions);
            n45._Operations_.Split_String(Input_In: __pad_POY2rCJcoGHPKiYSKFZo8w_0, Separator_In: New_Line_2, Options_In: Options_3, Output_Out: out n11.Spread<string> Output_4);
            string Default_Value_5 = "";
            n17._Operations_.GetSlice<string>(Input_In: Output_4, Default_Value_In: Default_Value_5, Index_In: Op_In, Result_Out: out string Result_6);
            var New_Line_7 = n44.StringExtensions.NewLine;
            n2.StringSplitOptions Options_8 = default(n2.StringSplitOptions);
            n45._Operations_.Split_String(Input_In: __pad_G1IWdeGoLWnLTkaFXlrrvg_1, Separator_In: New_Line_7, Options_In: Options_8, Output_Out: out n11.Spread<string> Output_9);
            string Default_Value_10 = "";
            n17._Operations_.GetSlice<string>(Input_In: Output_9, Default_Value_In: Default_Value_10, Index_In: Op_In, Result_Out: out string Result_11);
            var builder_12 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_UkYrRUDnLgdL6EZf76JnNP, 2);
            builder_12.Add("OP", Result_6);
            builder_12.Add("SWIZZLE", Result_11);
            var __pin_group_Input_In_UkYrRUDnLgdL6EZf76JnNP_13 = builder_12.Commit();
            n16._Operations_.Cons<string>(Input_In: __pin_group_Input_In_UkYrRUDnLgdL6EZf76JnNP_13, Output_Out: out n15.ImmutableDictionary<string, string> Output_14);
            Output_Out = Output_14;
            return;
        }

        [n1.ElementAttribute(TracingId = 344844U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "F71TRmMxmWrLzg8Bj2cbaH", Name = "__slot_F71TRmMxmWrLzg8Bj2cbaH")]
        public static string __slot_F71TRmMxmWrLzg8Bj2cbaH = "DomainRepeat2D";
        [n1.ElementAttribute(TracingId = 344863U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "F3ONVQEqeZXOhOvftDfgjz", Name = "__slot_F3ONVQEqeZXOhOvftDfgjz")]
        public static string __slot_F3ONVQEqeZXOhOvftDfgjz = "DomainRepeatCell2D";
        [n1.ElementAttribute(TracingId = 344890U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "POY2rCJcoGHPKiYSKFZo8w", Name = "__slot_POY2rCJcoGHPKiYSKFZo8w")]
        public static string __slot_POY2rCJcoGHPKiYSKFZo8w = "pMod2\r\npModMirror2\r\npModGrid2\r\npMod1\r\npModMirror1\r\npMod1\r\npModMirror1\r\npModPolar";
        [n1.ElementAttribute(TracingId = 344935U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "G1IWdeGoLWnLTkaFXlrrvg", Name = "__slot_G1IWdeGoLWnLTkaFXlrrvg")]
        public static string __slot_G1IWdeGoLWnLTkaFXlrrvg = "xy\r\nxy\r\nxy\r\nx\r\nx\r\ny\r\ny\r\nxy";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain._2D.ScreenToUV
{
    [n1.ElementAttribute(TracingId = 343058U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ScreenToUV2DID(out string Output_Out)
        {
            string __pad_C7EPWUXF4bOLDAzBQfbTA9_0 = __slot_C7EPWUXF4bOLDAzBQfbTA9;
            Output_Out = __pad_C7EPWUXF4bOLDAzBQfbTA9_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 345254U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "C7EPWUXF4bOLDAzBQfbTA9", Name = "__slot_C7EPWUXF4bOLDAzBQfbTA9")]
        public static string __slot_C7EPWUXF4bOLDAzBQfbTA9 = "ScreenToUV2D";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain._2D.UVToScreen
{
    [n1.ElementAttribute(TracingId = 343058U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void UVToScreen2DID(out string Output_Out)
        {
            string __pad_J0M8Dkf1eNkQNBDnOnjX3l_0 = __slot_J0M8Dkf1eNkQNBDnOnjX3l;
            Output_Out = __pad_J0M8Dkf1eNkQNBDnOnjX3l_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 345689U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "J0M8Dkf1eNkQNBDnOnjX3l", Name = "__slot_J0M8Dkf1eNkQNBDnOnjX3l")]
        public static string __slot_J0M8Dkf1eNkQNBDnOnjX3l = "UVToScreen2D";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain._2D.PolarToCartesian
{
    [n1.ElementAttribute(TracingId = 343058U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void PolarToCartesian2DID(out string Output_Out)
        {
            string __pad_SA16vvaEtuIM9CFhIV3qM4_0 = __slot_SA16vvaEtuIM9CFhIV3qM4;
            Output_Out = __pad_SA16vvaEtuIM9CFhIV3qM4_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 345884U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "SA16vvaEtuIM9CFhIV3qM4", Name = "__slot_SA16vvaEtuIM9CFhIV3qM4")]
        public static string __slot_SA16vvaEtuIM9CFhIV3qM4 = "PolarToCartesian2D";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain._2D.CartesianToPolar
{
    [n1.ElementAttribute(TracingId = 343058U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CartesianToPolar2DID(out string Output_Out)
        {
            string __pad_PPZctlSVA2XNqbkxPr5Ez8_0 = __slot_PPZctlSVA2XNqbkxPr5Ez8;
            Output_Out = __pad_PPZctlSVA2XNqbkxPr5Ez8_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 346270U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "PPZctlSVA2XNqbkxPr5Ez8", Name = "__slot_PPZctlSVA2XNqbkxPr5Ez8")]
        public static string __slot_PPZctlSVA2XNqbkxPr5Ez8 = "CartesianToPolar2D";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain._3D
{
    [n1.ElementAttribute(TracingId = 346954U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "SOgHRzXRbS9MsO0IeYZ2jA", Name = "DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA")]
    [n2.SerializableAttribute]
    public class DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n46.DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA Create(n1.NodeContext Node_Context)
        {
            var instance = new DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n46.DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA CreateDefault()
        {
            var instance = new DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n46.DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA Update(n5.GpuValue<n22.Vector3> TDomain_In, n5.GpuValue<n22.Vector3> Plane_Normal_In, n5.GpuValue<float> Plane_Offset_In, out n5.GpuValue<n22.Vector3> Output_Out, out n5.GpuValue<float> Sign_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_LXcQZ5ADakbPKnlUihU1MU;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<n22.Vector3>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<float>>>((default(n5.GpuValue<n22.Vector3>), default(n5.GpuValue<float>)));
            }

            var inputs_3 = (TDomain_In, Plane_Normal_In, Plane_Offset_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__B7H80SoUU3CNYTPHHsNHlO>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __B7H80SoUU3CNYTPHHsNHlO(__GetContext__(), n1.VLObject.NewIdentity())
                    {__slot_CixzrXud4ZAQSB2ZIxPFZo = default(n5.GpuValue<n22.Vector3>), __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs = n17._Operations_.CreateDefault<n5.GpuValue<float>>(), __slot_Dj0SCwglVK1LzUujkssfYb = default(n5.GpuValue<float>), __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc = n17._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK = n17._Operations_.CreateDefault<n5.GpuValue<n22.Vector3>>(), __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY = n17._Operations_.CreateDefault<n5.GpuValue<n22.Vector3>>()};
                    string __pad_ReKDHyreHmwLXMFTHFs1Pr_7 = __slot_ReKDHyreHmwLXMFTHFs1Pr;
                    string __pad_L4xHyCUgVD9N8mPnzF0Rmv_8 = __slot_L4xHyCUgVD9N8mPnzF0Rmv;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "MGG1bIpusJCMrqpL1bGtGn", 347008U);
                    var Output_10 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3>.Create(Node_Context: Node_Context_9);
                    state_6.__p_MGG1bIpusJCMrqpL1bGtGn = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "MjnR5g0F04ONGD1aB7vnMB", 347021U);
                    var Output_12 = n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float>.Create(Node_Context: Node_Context_11);
                    state_6.__p_MjnR5g0F04ONGD1aB7vnMB = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "H5kpOOioxzQPcMa7R7AR4c", 347055U);
                    var Output_14 = n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<n22.Vector3>.Create(Node_Context: Node_Context_13);
                    state_6.__p_H5kpOOioxzQPcMa7R7AR4c = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "IJpNEM8Fs99NBOgn6rITDS", 347069U);
                    var Output_16 = n47.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n22.Vector3>.Create(Node_Context: Node_Context_15);
                    state_6.__p_IJpNEM8Fs99NBOgn6rITDS = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "FwMFcjYvtegM1IFQoryTmL", 347093U);
                    var Output_18 = n20.Dot_VjBgbBbkOkiMLqm9EWGCSn<n22.Vector3>.Create(Node_Context: Node_Context_17);
                    state_6.__p_FwMFcjYvtegM1IFQoryTmL = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Vh0J1xEzK1GLvjvCAKC4fs", 347120U);
                    var Output_20 = n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float>.Create(Node_Context: Node_Context_19);
                    state_6.__p_Vh0J1xEzK1GLvjvCAKC4fs = Output_20;
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Uqr8Hp02P5TLDigp2BqWTh", 347139U);
                    var Output_22 = n47.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float>.Create(Node_Context: Node_Context_21);
                    state_6.__p_Uqr8Hp02P5TLDigp2BqWTh = Output_22;
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "KmUvFbmFfE6LFTGjtXblbL", 347156U);
                    var Output_24 = n20.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float>.Create(Node_Context: Node_Context_23);
                    state_6.__p_KmUvFbmFfE6LFTGjtXblbL = Output_24;
                    n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Kuj6meVoaY9NbgBbpEPGUK", 347169U);
                    var Output_26 = n20.Sign_UX4v0iAYvhPMxCdeQTTGha<float>.Create(Node_Context: Node_Context_25);
                    state_6.__p_Kuj6meVoaY9NbgBbpEPGUK = Output_26;
                    n1.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "BF7M9eF7lDBPoISB9mNzqY", 347184U);
                    var Output_28 = n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n22.Vector3>.Create(Node_Context: Node_Context_27);
                    state_6.__p_BF7M9eF7lDBPoISB9mNzqY = Output_28;
                    n1.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "M8jihm6go8GNpPG7SnNvUc", 347198U);
                    var Output_30 = n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_29);
                    state_6.__p_M8jihm6go8GNpPG7SnNvUc = Output_30;
                    n1.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "PoCG4W3mxtZMfPHcxAIwSb", 347223U);
                    var Output_32 = n42.To_Qgkn15Kxt1HLURmAdSAN7m<float, n22.Vector3>.Create(Node_Context: Node_Context_31);
                    state_6.__p_PoCG4W3mxtZMfPHcxAIwSb = Output_32;
                    n1.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "VrEWeCYbdtIL3I2pHLnCIA", 347238U);
                    var Output_34 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_33);
                    state_6.__p_VrEWeCYbdtIL3I2pHLnCIA = Output_34;
                    n1.NodeContext Node_Context_35 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "J1ztUiLLVR2O1esJTE7SxK", 347264U);
                    var Output_36 = n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n22.Vector3>.Create(Node_Context: Node_Context_35);
                    state_6.__p_J1ztUiLLVR2O1esJTE7SxK = Output_36;
                    n1.NodeContext Node_Context_37 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "ECjUEt2j7j5MunxszCFYm0", 347317U);
                    var Output_38 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_37, ID_In: __pad_ReKDHyreHmwLXMFTHFs1Pr_7);
                    state_6.__p_ECjUEt2j7j5MunxszCFYm0 = Output_38;
                    n1.NodeContext Node_Context_39 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "I6HkMnsZkrvPDlrpydASpQ", 347333U);
                    var Output_40 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_39, ID_In: __pad_L4xHyCUgVD9N8mPnzF0Rmv_8);
                    state_6.__p_I6HkMnsZkrvPDlrpydASpQ = Output_40;
                }

                float __pad_BS1IQX5Bv1PPz1jgu8KClo_41 = __slot_BS1IQX5Bv1PPz1jgu8KClo;
                n22.Vector3 __pad_FbBOrSjDQGDLvdK9ZyO0xx_42 = __slot_FbBOrSjDQGDLvdK9ZyO0xx;
                float __pad_OhqSQCXlaxBP4SB9gZlswm_43 = __slot_OhqSQCXlaxBP4SB9gZlswm;
                int Id_44 = 0;
                var State_Output_46 = state_6.__p_MGG1bIpusJCMrqpL1bGtGn.Update(The_Override_In: TDomain_In, Id_In: Id_44, Output_Out: out n5.GpuValue<n22.Vector3> Output_45);
                n5.GpuValue<n22.Vector3> __pad_CixzrXud4ZAQSB2ZIxPFZo_47 = Output_45;
                var State_Output_49 = state_6.__p_MjnR5g0F04ONGD1aB7vnMB.Update(GpuValue_In: Plane_Offset_In, The_Value_In: __pad_BS1IQX5Bv1PPz1jgu8KClo_41, Output_Out: out n5.GpuValue<float> Output_48);
                var State_Output_51 = state_6.__p_H5kpOOioxzQPcMa7R7AR4c.Update(GpuValue_In: Plane_Normal_In, The_Value_In: __pad_FbBOrSjDQGDLvdK9ZyO0xx_42, Output_Out: out n5.GpuValue<n22.Vector3> Output_50);
                var State_Output_53 = state_6.__p_FwMFcjYvtegM1IFQoryTmL.Update(Input1_In: __pad_CixzrXud4ZAQSB2ZIxPFZo_47, Input2_In: Output_50, Output_Out: out n5.GpuValue<float> Output_52);
                var builder_54 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs, 2);
                builder_54.Add(Output_52);
                builder_54.Add(Output_48);
                var __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs_55 = builder_54.Commit();
                var State_Output_57 = state_6.__p_Vh0J1xEzK1GLvjvCAKC4fs.Update(Input_In: __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs_55, Output_Out: out n5.GpuValue<float> Output_56);
                n5.GpuValue<float> __pad_Dj0SCwglVK1LzUujkssfYb_58 = Output_56;
                var Output_60 = state_6.__p_VrEWeCYbdtIL3I2pHLnCIA.Update(Value_In: __pad_OhqSQCXlaxBP4SB9gZlswm_43, GpuValue_Out: out n5.GpuValue<float> GpuValue_59);
                var builder_61 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc, 2);
                builder_61.Add(__pad_Dj0SCwglVK1LzUujkssfYb_58);
                builder_61.Add(GpuValue_59);
                var __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc_62 = builder_61.Commit();
                var State_Output_64 = state_6.__p_M8jihm6go8GNpPG7SnNvUc.Update(Input_In: __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc_62, Output_Out: out n5.GpuValue<float> Output_63);
                n5.GpuValue<n22.Vector3> default_65 = default(n5.GpuValue<n22.Vector3>);
                var State_Output_67 = state_6.__p_PoCG4W3mxtZMfPHcxAIwSb.Update(x_In: Output_63, default_In: default_65, Output_Out: out n5.GpuValue<n22.Vector3> Output_66);
                var builder_68 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK, 2);
                builder_68.Add(Output_66);
                builder_68.Add(Output_50);
                var __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK_69 = builder_68.Commit();
                var State_Output_71 = state_6.__p_J1ztUiLLVR2O1esJTE7SxK.Update(Input_In: __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK_69, Output_Out: out n5.GpuValue<n22.Vector3> Output_70);
                var builder_72 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY, 2);
                builder_72.Add(__pad_CixzrXud4ZAQSB2ZIxPFZo_47);
                builder_72.Add(Output_70);
                var __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY_73 = builder_72.Commit();
                var State_Output_75 = state_6.__p_BF7M9eF7lDBPoISB9mNzqY.Update(Input_In: __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY_73, Output_Out: out n5.GpuValue<n22.Vector3> Output_74);
                var State_Output_77 = state_6.__p_KmUvFbmFfE6LFTGjtXblbL.Update(Output_Out: out n5.GpuValue<float> Output_76);
                var Output_79 = state_6.__p_Uqr8Hp02P5TLDigp2BqWTh.Update(x_In: __pad_Dj0SCwglVK1LzUujkssfYb_58, y_In: Output_76, value_Out: out n5.GpuValue<bool> value_78);
                n5.GpuValue<n22.Vector3> The_Default_80 = default(n5.GpuValue<n22.Vector3>);
                var State_Output_82 = state_6.__p_IJpNEM8Fs99NBOgn6rITDS.Update(In_Check_In: value_78, In_False_In: __pad_CixzrXud4ZAQSB2ZIxPFZo_47, In_True_In: Output_74, The_Default_In: The_Default_80, Output_Out: out n5.GpuValue<n22.Vector3> Output_81);
                bool Update_83 = true;
                var Output_84 = state_6.__p_ECjUEt2j7j5MunxszCFYm0;
                if (Update_83)
                {
                    Output_84 = state_6.__p_ECjUEt2j7j5MunxszCFYm0.Update(Input_In: Output_81);
                }

                var Output_86 = state_6.__p_Kuj6meVoaY9NbgBbpEPGUK.Update(Input_In: __pad_Dj0SCwglVK1LzUujkssfYb_58, Out_Out: out n5.GpuValue<float> Out_85);
                bool Update_87 = true;
                var Output_88 = state_6.__p_I6HkMnsZkrvPDlrpydASpQ;
                if (Update_87)
                {
                    Output_88 = state_6.__p_I6HkMnsZkrvPDlrpydASpQ.Update(Input_In: Out_85);
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_46 != state_6.__p_MGG1bIpusJCMrqpL1bGtGn || Output_45 != state_6.__slot_CixzrXud4ZAQSB2ZIxPFZo || State_Output_49 != state_6.__p_MjnR5g0F04ONGD1aB7vnMB || State_Output_51 != state_6.__p_H5kpOOioxzQPcMa7R7AR4c || State_Output_53 != state_6.__p_FwMFcjYvtegM1IFQoryTmL || __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs_55 != state_6.__pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs || State_Output_57 != state_6.__p_Vh0J1xEzK1GLvjvCAKC4fs || Output_56 != state_6.__slot_Dj0SCwglVK1LzUujkssfYb || Output_60 != state_6.__p_VrEWeCYbdtIL3I2pHLnCIA || __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc_62 != state_6.__pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc || State_Output_64 != state_6.__p_M8jihm6go8GNpPG7SnNvUc || State_Output_67 != state_6.__p_PoCG4W3mxtZMfPHcxAIwSb || __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK_69 != state_6.__pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK || State_Output_71 != state_6.__p_J1ztUiLLVR2O1esJTE7SxK || __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY_73 != state_6.__pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY || State_Output_75 != state_6.__p_BF7M9eF7lDBPoISB9mNzqY || State_Output_77 != state_6.__p_KmUvFbmFfE6LFTGjtXblbL || Output_79 != state_6.__p_Uqr8Hp02P5TLDigp2BqWTh || State_Output_82 != state_6.__p_IJpNEM8Fs99NBOgn6rITDS || Output_84 != state_6.__p_ECjUEt2j7j5MunxszCFYm0 || Output_86 != state_6.__p_Kuj6meVoaY9NbgBbpEPGUK || Output_88 != state_6.__p_I6HkMnsZkrvPDlrpydASpQ ? new __B7H80SoUU3CNYTPHHsNHlO(state_6)
                    {__p_MGG1bIpusJCMrqpL1bGtGn = State_Output_46, __slot_CixzrXud4ZAQSB2ZIxPFZo = Output_45, __p_MjnR5g0F04ONGD1aB7vnMB = State_Output_49, __p_H5kpOOioxzQPcMa7R7AR4c = State_Output_51, __p_FwMFcjYvtegM1IFQoryTmL = State_Output_53, __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs = __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs_55, __p_Vh0J1xEzK1GLvjvCAKC4fs = State_Output_57, __slot_Dj0SCwglVK1LzUujkssfYb = Output_56, __p_VrEWeCYbdtIL3I2pHLnCIA = Output_60, __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc = __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc_62, __p_M8jihm6go8GNpPG7SnNvUc = State_Output_64, __p_PoCG4W3mxtZMfPHcxAIwSb = State_Output_67, __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK = __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK_69, __p_J1ztUiLLVR2O1esJTE7SxK = State_Output_71, __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY = __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY_73, __p_BF7M9eF7lDBPoISB9mNzqY = State_Output_75, __p_KmUvFbmFfE6LFTGjtXblbL = State_Output_77, __p_Uqr8Hp02P5TLDigp2BqWTh = Output_79, __p_IJpNEM8Fs99NBOgn6rITDS = State_Output_82, __p_ECjUEt2j7j5MunxszCFYm0 = Output_84, __p_Kuj6meVoaY9NbgBbpEPGUK = Output_86, __p_I6HkMnsZkrvPDlrpydASpQ = Output_88} : state_6;
                else
                {
                    state_6.__p_MGG1bIpusJCMrqpL1bGtGn = State_Output_46;
                    state_6.__slot_CixzrXud4ZAQSB2ZIxPFZo = Output_45;
                    state_6.__p_MjnR5g0F04ONGD1aB7vnMB = State_Output_49;
                    state_6.__p_H5kpOOioxzQPcMa7R7AR4c = State_Output_51;
                    state_6.__p_FwMFcjYvtegM1IFQoryTmL = State_Output_53;
                    state_6.__pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs = __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs_55;
                    state_6.__p_Vh0J1xEzK1GLvjvCAKC4fs = State_Output_57;
                    state_6.__slot_Dj0SCwglVK1LzUujkssfYb = Output_56;
                    state_6.__p_VrEWeCYbdtIL3I2pHLnCIA = Output_60;
                    state_6.__pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc = __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc_62;
                    state_6.__p_M8jihm6go8GNpPG7SnNvUc = State_Output_64;
                    state_6.__p_PoCG4W3mxtZMfPHcxAIwSb = State_Output_67;
                    state_6.__pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK = __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK_69;
                    state_6.__p_J1ztUiLLVR2O1esJTE7SxK = State_Output_71;
                    state_6.__pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY = __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY_73;
                    state_6.__p_BF7M9eF7lDBPoISB9mNzqY = State_Output_75;
                    state_6.__p_KmUvFbmFfE6LFTGjtXblbL = State_Output_77;
                    state_6.__p_Uqr8Hp02P5TLDigp2BqWTh = Output_79;
                    state_6.__p_IJpNEM8Fs99NBOgn6rITDS = State_Output_82;
                    state_6.__p_ECjUEt2j7j5MunxszCFYm0 = Output_84;
                    state_6.__p_Kuj6meVoaY9NbgBbpEPGUK = Output_86;
                    state_6.__p_I6HkMnsZkrvPDlrpydASpQ = Output_88;
                }

                outputs_4 = (Output_81, Out_85);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_89, __auto_90) = outputs_4;
            Output_Out = __auto_89;
            Sign_Out = __auto_90;
            n46.DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA that_91 = this;
            if (this.__GetContext__().IsImmutable)
                that_91 = manager_2 != this.__cache_LXcQZ5ADakbPKnlUihU1MU ? new DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA(this)
                {__cache_LXcQZ5ADakbPKnlUihU1MU = manager_2} : that_91;
            else
            {
                this.__cache_LXcQZ5ADakbPKnlUihU1MU = manager_2;
            }

            return that_91;
        }

        public n46.DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n46.DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA that_0 = this;
            this.__cache_LXcQZ5ADakbPKnlUihU1MU = null;
            return that_0;
        }

        public n46.DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA __CreateDefault__()
        {
            n46.DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA that_0 = this;
            this.__cache_LXcQZ5ADakbPKnlUihU1MU = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_LXcQZ5ADakbPKnlUihU1MU);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 347366U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "FuIzdNqD90QQPy1yZerynf", Name = "__slot_FuIzdNqD90QQPy1yZerynf")]
        public static string __slot_FuIzdNqD90QQPy1yZerynf = "\tfloat pReflect(inout float3 p, float3 planeNormal, float offset) \r\n\t{\r\n\t\tfloat t = dot(p, planeNormal)+offset;\r\n\t\tif (t < 0) {\r\n\t\t\tp = p - (2*t)*planeNormal;\r\n\t\t}\r\n\t\treturn sgn(t);\r\n\t}";
        [n1.ElementAttribute(TracingId = 346960U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "LXcQZ5ADakbPKnlUihU1MU", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<n22.Vector3>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<float>>> __cache_LXcQZ5ADakbPKnlUihU1MU = null;
        [n1.ElementAttribute(TracingId = 347328U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "ReKDHyreHmwLXMFTHFs1Pr", Name = "__slot_ReKDHyreHmwLXMFTHFs1Pr")]
        public static string __slot_ReKDHyreHmwLXMFTHFs1Pr = "DomainReflect3D";
        [n1.ElementAttribute(TracingId = 347342U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "L4xHyCUgVD9N8mPnzF0Rmv", Name = "__slot_L4xHyCUgVD9N8mPnzF0Rmv")]
        public static string __slot_L4xHyCUgVD9N8mPnzF0Rmv = "DomainReflectSign3D";
        [n1.ElementAttribute(TracingId = 347045U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "BS1IQX5Bv1PPz1jgu8KClo", Name = "__slot_BS1IQX5Bv1PPz1jgu8KClo")]
        public static float __slot_BS1IQX5Bv1PPz1jgu8KClo = 0F;
        [n1.ElementAttribute(TracingId = 347065U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "FbBOrSjDQGDLvdK9ZyO0xx", Name = "__slot_FbBOrSjDQGDLvdK9ZyO0xx")]
        public static n22.Vector3 __slot_FbBOrSjDQGDLvdK9ZyO0xx = n1.CompilationHelper.Deserialize<n22.Vector3>("1, 0, 0", false, "MzilLTk6yNROg5SWTCtzZM", "FbBOrSjDQGDLvdK9ZyO0xx");
        [n1.ElementAttribute(TracingId = 347280U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "OhqSQCXlaxBP4SB9gZlswm", Name = "__slot_OhqSQCXlaxBP4SB9gZlswm")]
        public static float __slot_OhqSQCXlaxBP4SB9gZlswm = 2F;
        static DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA()
        {
        }

        public DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA(DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA other): base(other)
        {
            this.__cache_LXcQZ5ADakbPKnlUihU1MU = other.__cache_LXcQZ5ADakbPKnlUihU1MU;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_LXcQZ5ADakbPKnlUihU1MU", in __cache_LXcQZ5ADakbPKnlUihU1MU));
        }

        internal DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<n22.Vector3>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<float>>> __cache_LXcQZ5ADakbPKnlUihU1MU)
        {
            n46.DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_LXcQZ5ADakbPKnlUihU1MU != this.__cache_LXcQZ5ADakbPKnlUihU1MU ? new DomainReflect_SOgHRzXRbS9MsO0IeYZ2jA(this)
                {__cache_LXcQZ5ADakbPKnlUihU1MU = __cache_LXcQZ5ADakbPKnlUihU1MU} : that_0;
            else
            {
                this.__cache_LXcQZ5ADakbPKnlUihU1MU = __cache_LXcQZ5ADakbPKnlUihU1MU;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "B7H80SoUU3CNYTPHHsNHlO", Name = "__B7H80SoUU3CNYTPHHsNHlO")]
        [n2.SerializableAttribute]
        public class __B7H80SoUU3CNYTPHHsNHlO : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_MGG1bIpusJCMrqpL1bGtGn);
                n1.CompilationHelper.SafeDispose(this.__p_MjnR5g0F04ONGD1aB7vnMB);
                n1.CompilationHelper.SafeDispose(this.__p_H5kpOOioxzQPcMa7R7AR4c);
                n1.CompilationHelper.SafeDispose(this.__p_IJpNEM8Fs99NBOgn6rITDS);
                n1.CompilationHelper.SafeDispose(this.__p_FwMFcjYvtegM1IFQoryTmL);
                n1.CompilationHelper.SafeDispose(this.__p_Vh0J1xEzK1GLvjvCAKC4fs);
                n1.CompilationHelper.SafeDispose(this.__p_Uqr8Hp02P5TLDigp2BqWTh);
                n1.CompilationHelper.SafeDispose(this.__p_KmUvFbmFfE6LFTGjtXblbL);
                n1.CompilationHelper.SafeDispose(this.__p_Kuj6meVoaY9NbgBbpEPGUK);
                n1.CompilationHelper.SafeDispose(this.__p_BF7M9eF7lDBPoISB9mNzqY);
                n1.CompilationHelper.SafeDispose(this.__p_M8jihm6go8GNpPG7SnNvUc);
                n1.CompilationHelper.SafeDispose(this.__p_PoCG4W3mxtZMfPHcxAIwSb);
                n1.CompilationHelper.SafeDispose(this.__p_VrEWeCYbdtIL3I2pHLnCIA);
                n1.CompilationHelper.SafeDispose(this.__p_J1ztUiLLVR2O1esJTE7SxK);
                n1.CompilationHelper.SafeDispose(this.__p_ECjUEt2j7j5MunxszCFYm0);
                n1.CompilationHelper.SafeDispose(this.__p_I6HkMnsZkrvPDlrpydASpQ);
                return;
            }

            [n1.ElementAttribute(TracingId = 347008U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "MGG1bIpusJCMrqpL1bGtGn", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_MGG1bIpusJCMrqpL1bGtGn;
            [n1.ElementAttribute(TracingId = 347021U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "MjnR5g0F04ONGD1aB7vnMB", Name = "CheckDefault", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_MjnR5g0F04ONGD1aB7vnMB;
            [n1.ElementAttribute(TracingId = 347055U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "H5kpOOioxzQPcMa7R7AR4c", Name = "CheckDefault", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<n22.Vector3> __p_H5kpOOioxzQPcMa7R7AR4c;
            [n1.ElementAttribute(TracingId = 347069U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "IJpNEM8Fs99NBOgn6rITDS", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
            public n47.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n22.Vector3> __p_IJpNEM8Fs99NBOgn6rITDS;
            [n1.ElementAttribute(TracingId = 347093U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "FwMFcjYvtegM1IFQoryTmL", Name = "Dot", IsManaged = true, IsAutoGenerated = true)]
            public n20.Dot_VjBgbBbkOkiMLqm9EWGCSn<n22.Vector3> __p_FwMFcjYvtegM1IFQoryTmL;
            [n1.ElementAttribute(TracingId = 347120U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Vh0J1xEzK1GLvjvCAKC4fs", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_Vh0J1xEzK1GLvjvCAKC4fs;
            [n1.ElementAttribute(TracingId = 347139U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Uqr8Hp02P5TLDigp2BqWTh", Name = "<", IsManaged = true, IsAutoGenerated = true)]
            public n47.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_Uqr8Hp02P5TLDigp2BqWTh;
            [n1.ElementAttribute(TracingId = 347156U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "KmUvFbmFfE6LFTGjtXblbL", Name = "ZERO", IsManaged = true, IsAutoGenerated = true)]
            public n20.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float> __p_KmUvFbmFfE6LFTGjtXblbL;
            [n1.ElementAttribute(TracingId = 347169U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Kuj6meVoaY9NbgBbpEPGUK", Name = "Sign", IsManaged = true, IsAutoGenerated = true)]
            public n20.Sign_UX4v0iAYvhPMxCdeQTTGha<float> __p_Kuj6meVoaY9NbgBbpEPGUK;
            [n1.ElementAttribute(TracingId = 347184U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "BF7M9eF7lDBPoISB9mNzqY", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n22.Vector3> __p_BF7M9eF7lDBPoISB9mNzqY;
            [n1.ElementAttribute(TracingId = 347198U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "M8jihm6go8GNpPG7SnNvUc", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_M8jihm6go8GNpPG7SnNvUc;
            [n1.ElementAttribute(TracingId = 347223U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "PoCG4W3mxtZMfPHcxAIwSb", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n42.To_Qgkn15Kxt1HLURmAdSAN7m<float, n22.Vector3> __p_PoCG4W3mxtZMfPHcxAIwSb;
            [n1.ElementAttribute(TracingId = 347238U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "VrEWeCYbdtIL3I2pHLnCIA", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_VrEWeCYbdtIL3I2pHLnCIA;
            [n1.ElementAttribute(TracingId = 347264U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "J1ztUiLLVR2O1esJTE7SxK", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n22.Vector3> __p_J1ztUiLLVR2O1esJTE7SxK;
            [n1.ElementAttribute(TracingId = 347317U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "ECjUEt2j7j5MunxszCFYm0", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_ECjUEt2j7j5MunxszCFYm0;
            [n1.ElementAttribute(TracingId = 347333U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "I6HkMnsZkrvPDlrpydASpQ", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_I6HkMnsZkrvPDlrpydASpQ;
            [n1.ElementAttribute(TracingId = 347003U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "CixzrXud4ZAQSB2ZIxPFZo", Name = "__slot_CixzrXud4ZAQSB2ZIxPFZo")]
            public n5.GpuValue<n22.Vector3> __slot_CixzrXud4ZAQSB2ZIxPFZo;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs = default(n11.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(TracingId = 347116U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Dj0SCwglVK1LzUujkssfYb", Name = "__slot_Dj0SCwglVK1LzUujkssfYb")]
            public n5.GpuValue<float> __slot_Dj0SCwglVK1LzUujkssfYb;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc = default(n11.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<n22.Vector3>> __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK = default(n11.Spread<n5.GpuValue<n22.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<n22.Vector3>> __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY = default(n11.Spread<n5.GpuValue<n22.Vector3>>);
            public __B7H80SoUU3CNYTPHHsNHlO(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __B7H80SoUU3CNYTPHHsNHlO(__B7H80SoUU3CNYTPHHsNHlO other): base(other)
            {
                this.__p_MGG1bIpusJCMrqpL1bGtGn = other.__p_MGG1bIpusJCMrqpL1bGtGn;
                this.__p_MjnR5g0F04ONGD1aB7vnMB = other.__p_MjnR5g0F04ONGD1aB7vnMB;
                this.__p_H5kpOOioxzQPcMa7R7AR4c = other.__p_H5kpOOioxzQPcMa7R7AR4c;
                this.__p_IJpNEM8Fs99NBOgn6rITDS = other.__p_IJpNEM8Fs99NBOgn6rITDS;
                this.__p_FwMFcjYvtegM1IFQoryTmL = other.__p_FwMFcjYvtegM1IFQoryTmL;
                this.__p_Vh0J1xEzK1GLvjvCAKC4fs = other.__p_Vh0J1xEzK1GLvjvCAKC4fs;
                this.__p_Uqr8Hp02P5TLDigp2BqWTh = other.__p_Uqr8Hp02P5TLDigp2BqWTh;
                this.__p_KmUvFbmFfE6LFTGjtXblbL = other.__p_KmUvFbmFfE6LFTGjtXblbL;
                this.__p_Kuj6meVoaY9NbgBbpEPGUK = other.__p_Kuj6meVoaY9NbgBbpEPGUK;
                this.__p_BF7M9eF7lDBPoISB9mNzqY = other.__p_BF7M9eF7lDBPoISB9mNzqY;
                this.__p_M8jihm6go8GNpPG7SnNvUc = other.__p_M8jihm6go8GNpPG7SnNvUc;
                this.__p_PoCG4W3mxtZMfPHcxAIwSb = other.__p_PoCG4W3mxtZMfPHcxAIwSb;
                this.__p_VrEWeCYbdtIL3I2pHLnCIA = other.__p_VrEWeCYbdtIL3I2pHLnCIA;
                this.__p_J1ztUiLLVR2O1esJTE7SxK = other.__p_J1ztUiLLVR2O1esJTE7SxK;
                this.__p_ECjUEt2j7j5MunxszCFYm0 = other.__p_ECjUEt2j7j5MunxszCFYm0;
                this.__p_I6HkMnsZkrvPDlrpydASpQ = other.__p_I6HkMnsZkrvPDlrpydASpQ;
                this.__slot_CixzrXud4ZAQSB2ZIxPFZo = other.__slot_CixzrXud4ZAQSB2ZIxPFZo;
                this.__pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs = other.__pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs;
                this.__slot_Dj0SCwglVK1LzUujkssfYb = other.__slot_Dj0SCwglVK1LzUujkssfYb;
                this.__pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc = other.__pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc;
                this.__pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK = other.__pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK;
                this.__pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY = other.__pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MGG1bIpusJCMrqpL1bGtGn", in __p_MGG1bIpusJCMrqpL1bGtGn), n1.CompilationHelper.GetValueOrExisting(values, "__p_MjnR5g0F04ONGD1aB7vnMB", in __p_MjnR5g0F04ONGD1aB7vnMB), n1.CompilationHelper.GetValueOrExisting(values, "__p_H5kpOOioxzQPcMa7R7AR4c", in __p_H5kpOOioxzQPcMa7R7AR4c), n1.CompilationHelper.GetValueOrExisting(values, "__p_IJpNEM8Fs99NBOgn6rITDS", in __p_IJpNEM8Fs99NBOgn6rITDS), n1.CompilationHelper.GetValueOrExisting(values, "__p_FwMFcjYvtegM1IFQoryTmL", in __p_FwMFcjYvtegM1IFQoryTmL), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vh0J1xEzK1GLvjvCAKC4fs", in __p_Vh0J1xEzK1GLvjvCAKC4fs), n1.CompilationHelper.GetValueOrExisting(values, "__p_Uqr8Hp02P5TLDigp2BqWTh", in __p_Uqr8Hp02P5TLDigp2BqWTh), n1.CompilationHelper.GetValueOrExisting(values, "__p_KmUvFbmFfE6LFTGjtXblbL", in __p_KmUvFbmFfE6LFTGjtXblbL), n1.CompilationHelper.GetValueOrExisting(values, "__p_Kuj6meVoaY9NbgBbpEPGUK", in __p_Kuj6meVoaY9NbgBbpEPGUK), n1.CompilationHelper.GetValueOrExisting(values, "__p_BF7M9eF7lDBPoISB9mNzqY", in __p_BF7M9eF7lDBPoISB9mNzqY), n1.CompilationHelper.GetValueOrExisting(values, "__p_M8jihm6go8GNpPG7SnNvUc", in __p_M8jihm6go8GNpPG7SnNvUc), n1.CompilationHelper.GetValueOrExisting(values, "__p_PoCG4W3mxtZMfPHcxAIwSb", in __p_PoCG4W3mxtZMfPHcxAIwSb), n1.CompilationHelper.GetValueOrExisting(values, "__p_VrEWeCYbdtIL3I2pHLnCIA", in __p_VrEWeCYbdtIL3I2pHLnCIA), n1.CompilationHelper.GetValueOrExisting(values, "__p_J1ztUiLLVR2O1esJTE7SxK", in __p_J1ztUiLLVR2O1esJTE7SxK), n1.CompilationHelper.GetValueOrExisting(values, "__p_ECjUEt2j7j5MunxszCFYm0", in __p_ECjUEt2j7j5MunxszCFYm0), n1.CompilationHelper.GetValueOrExisting(values, "__p_I6HkMnsZkrvPDlrpydASpQ", in __p_I6HkMnsZkrvPDlrpydASpQ), n1.CompilationHelper.GetValueOrExisting(values, "__slot_CixzrXud4ZAQSB2ZIxPFZo", in __slot_CixzrXud4ZAQSB2ZIxPFZo), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs", in __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Dj0SCwglVK1LzUujkssfYb", in __slot_Dj0SCwglVK1LzUujkssfYb), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc", in __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK", in __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY", in __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY));
            }

            internal __B7H80SoUU3CNYTPHHsNHlO __WITH__(n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_MGG1bIpusJCMrqpL1bGtGn, n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_MjnR5g0F04ONGD1aB7vnMB, n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<n22.Vector3> __p_H5kpOOioxzQPcMa7R7AR4c, n47.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n22.Vector3> __p_IJpNEM8Fs99NBOgn6rITDS, n20.Dot_VjBgbBbkOkiMLqm9EWGCSn<n22.Vector3> __p_FwMFcjYvtegM1IFQoryTmL, n20.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_Vh0J1xEzK1GLvjvCAKC4fs, n47.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_Uqr8Hp02P5TLDigp2BqWTh, n20.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float> __p_KmUvFbmFfE6LFTGjtXblbL, n20.Sign_UX4v0iAYvhPMxCdeQTTGha<float> __p_Kuj6meVoaY9NbgBbpEPGUK, n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n22.Vector3> __p_BF7M9eF7lDBPoISB9mNzqY, n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_M8jihm6go8GNpPG7SnNvUc, n42.To_Qgkn15Kxt1HLURmAdSAN7m<float, n22.Vector3> __p_PoCG4W3mxtZMfPHcxAIwSb, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_VrEWeCYbdtIL3I2pHLnCIA, n20.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n22.Vector3> __p_J1ztUiLLVR2O1esJTE7SxK, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_ECjUEt2j7j5MunxszCFYm0, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_I6HkMnsZkrvPDlrpydASpQ, n5.GpuValue<n22.Vector3> __slot_CixzrXud4ZAQSB2ZIxPFZo, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs, n5.GpuValue<float> __slot_Dj0SCwglVK1LzUujkssfYb, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc, n11.Spread<n5.GpuValue<n22.Vector3>> __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK, n11.Spread<n5.GpuValue<n22.Vector3>> __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY)
            {
                __B7H80SoUU3CNYTPHHsNHlO that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_MGG1bIpusJCMrqpL1bGtGn != this.__p_MGG1bIpusJCMrqpL1bGtGn || __p_MjnR5g0F04ONGD1aB7vnMB != this.__p_MjnR5g0F04ONGD1aB7vnMB || __p_H5kpOOioxzQPcMa7R7AR4c != this.__p_H5kpOOioxzQPcMa7R7AR4c || __p_IJpNEM8Fs99NBOgn6rITDS != this.__p_IJpNEM8Fs99NBOgn6rITDS || __p_FwMFcjYvtegM1IFQoryTmL != this.__p_FwMFcjYvtegM1IFQoryTmL || __p_Vh0J1xEzK1GLvjvCAKC4fs != this.__p_Vh0J1xEzK1GLvjvCAKC4fs || __p_Uqr8Hp02P5TLDigp2BqWTh != this.__p_Uqr8Hp02P5TLDigp2BqWTh || __p_KmUvFbmFfE6LFTGjtXblbL != this.__p_KmUvFbmFfE6LFTGjtXblbL || __p_Kuj6meVoaY9NbgBbpEPGUK != this.__p_Kuj6meVoaY9NbgBbpEPGUK || __p_BF7M9eF7lDBPoISB9mNzqY != this.__p_BF7M9eF7lDBPoISB9mNzqY || __p_M8jihm6go8GNpPG7SnNvUc != this.__p_M8jihm6go8GNpPG7SnNvUc || __p_PoCG4W3mxtZMfPHcxAIwSb != this.__p_PoCG4W3mxtZMfPHcxAIwSb || __p_VrEWeCYbdtIL3I2pHLnCIA != this.__p_VrEWeCYbdtIL3I2pHLnCIA || __p_J1ztUiLLVR2O1esJTE7SxK != this.__p_J1ztUiLLVR2O1esJTE7SxK || __p_ECjUEt2j7j5MunxszCFYm0 != this.__p_ECjUEt2j7j5MunxszCFYm0 || __p_I6HkMnsZkrvPDlrpydASpQ != this.__p_I6HkMnsZkrvPDlrpydASpQ || __slot_CixzrXud4ZAQSB2ZIxPFZo != this.__slot_CixzrXud4ZAQSB2ZIxPFZo || __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs != this.__pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs || __slot_Dj0SCwglVK1LzUujkssfYb != this.__slot_Dj0SCwglVK1LzUujkssfYb || __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc != this.__pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc || __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK != this.__pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK || __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY != this.__pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY ? new __B7H80SoUU3CNYTPHHsNHlO(this)
                    {__p_MGG1bIpusJCMrqpL1bGtGn = __p_MGG1bIpusJCMrqpL1bGtGn, __p_MjnR5g0F04ONGD1aB7vnMB = __p_MjnR5g0F04ONGD1aB7vnMB, __p_H5kpOOioxzQPcMa7R7AR4c = __p_H5kpOOioxzQPcMa7R7AR4c, __p_IJpNEM8Fs99NBOgn6rITDS = __p_IJpNEM8Fs99NBOgn6rITDS, __p_FwMFcjYvtegM1IFQoryTmL = __p_FwMFcjYvtegM1IFQoryTmL, __p_Vh0J1xEzK1GLvjvCAKC4fs = __p_Vh0J1xEzK1GLvjvCAKC4fs, __p_Uqr8Hp02P5TLDigp2BqWTh = __p_Uqr8Hp02P5TLDigp2BqWTh, __p_KmUvFbmFfE6LFTGjtXblbL = __p_KmUvFbmFfE6LFTGjtXblbL, __p_Kuj6meVoaY9NbgBbpEPGUK = __p_Kuj6meVoaY9NbgBbpEPGUK, __p_BF7M9eF7lDBPoISB9mNzqY = __p_BF7M9eF7lDBPoISB9mNzqY, __p_M8jihm6go8GNpPG7SnNvUc = __p_M8jihm6go8GNpPG7SnNvUc, __p_PoCG4W3mxtZMfPHcxAIwSb = __p_PoCG4W3mxtZMfPHcxAIwSb, __p_VrEWeCYbdtIL3I2pHLnCIA = __p_VrEWeCYbdtIL3I2pHLnCIA, __p_J1ztUiLLVR2O1esJTE7SxK = __p_J1ztUiLLVR2O1esJTE7SxK, __p_ECjUEt2j7j5MunxszCFYm0 = __p_ECjUEt2j7j5MunxszCFYm0, __p_I6HkMnsZkrvPDlrpydASpQ = __p_I6HkMnsZkrvPDlrpydASpQ, __slot_CixzrXud4ZAQSB2ZIxPFZo = __slot_CixzrXud4ZAQSB2ZIxPFZo, __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs = __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs, __slot_Dj0SCwglVK1LzUujkssfYb = __slot_Dj0SCwglVK1LzUujkssfYb, __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc = __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc, __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK = __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK, __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY = __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY} : that_0;
                else
                {
                    this.__p_MGG1bIpusJCMrqpL1bGtGn = __p_MGG1bIpusJCMrqpL1bGtGn;
                    this.__p_MjnR5g0F04ONGD1aB7vnMB = __p_MjnR5g0F04ONGD1aB7vnMB;
                    this.__p_H5kpOOioxzQPcMa7R7AR4c = __p_H5kpOOioxzQPcMa7R7AR4c;
                    this.__p_IJpNEM8Fs99NBOgn6rITDS = __p_IJpNEM8Fs99NBOgn6rITDS;
                    this.__p_FwMFcjYvtegM1IFQoryTmL = __p_FwMFcjYvtegM1IFQoryTmL;
                    this.__p_Vh0J1xEzK1GLvjvCAKC4fs = __p_Vh0J1xEzK1GLvjvCAKC4fs;
                    this.__p_Uqr8Hp02P5TLDigp2BqWTh = __p_Uqr8Hp02P5TLDigp2BqWTh;
                    this.__p_KmUvFbmFfE6LFTGjtXblbL = __p_KmUvFbmFfE6LFTGjtXblbL;
                    this.__p_Kuj6meVoaY9NbgBbpEPGUK = __p_Kuj6meVoaY9NbgBbpEPGUK;
                    this.__p_BF7M9eF7lDBPoISB9mNzqY = __p_BF7M9eF7lDBPoISB9mNzqY;
                    this.__p_M8jihm6go8GNpPG7SnNvUc = __p_M8jihm6go8GNpPG7SnNvUc;
                    this.__p_PoCG4W3mxtZMfPHcxAIwSb = __p_PoCG4W3mxtZMfPHcxAIwSb;
                    this.__p_VrEWeCYbdtIL3I2pHLnCIA = __p_VrEWeCYbdtIL3I2pHLnCIA;
                    this.__p_J1ztUiLLVR2O1esJTE7SxK = __p_J1ztUiLLVR2O1esJTE7SxK;
                    this.__p_ECjUEt2j7j5MunxszCFYm0 = __p_ECjUEt2j7j5MunxszCFYm0;
                    this.__p_I6HkMnsZkrvPDlrpydASpQ = __p_I6HkMnsZkrvPDlrpydASpQ;
                    this.__slot_CixzrXud4ZAQSB2ZIxPFZo = __slot_CixzrXud4ZAQSB2ZIxPFZo;
                    this.__pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs = __pin_group_Input_In_Vh0J1xEzK1GLvjvCAKC4fs;
                    this.__slot_Dj0SCwglVK1LzUujkssfYb = __slot_Dj0SCwglVK1LzUujkssfYb;
                    this.__pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc = __pin_group_Input_In_M8jihm6go8GNpPG7SnNvUc;
                    this.__pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK = __pin_group_Input_In_J1ztUiLLVR2O1esJTE7SxK;
                    this.__pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY = __pin_group_Input_In_BF7M9eF7lDBPoISB9mNzqY;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 347564U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "IwCI2IWcZUQLfSNRL5TFZ5", Name = "DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5")]
    [n2.SerializableAttribute]
    public class DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n46.DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5 Create(n1.NodeContext Node_Context)
        {
            var instance = new DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n46.DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5 CreateDefault()
        {
            var instance = new DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n46.DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5 Update(n5.GpuValue<n22.Vector3> TDomain_In, n5.GpuValue<float> Offset_In, n48.PickOneXYZ Axis_In, out n5.GpuValue<n22.Vector3> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_GbBMoLElQVzLhsdarN2IFI;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<float>, n48.PickOneXYZ>, n2.ValueTuple<n5.GpuValue<n22.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n22.Vector3>)));
            }

            var inputs_3 = (TDomain_In, Offset_In, Axis_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__A4bbzsZizZpOUXQub9iBEZ>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __A4bbzsZizZpOUXQub9iBEZ(__GetContext__(), n1.VLObject.NewIdentity())
                    {__slot_KyG4GAvazUKMCAoH36cpw5 = default(n5.GpuValue<n22.Vector3>), __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi = n17._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK = n17._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF = n17._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd = n17._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv = n17._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6 = n17._Operations_.CreateDefault<n5.GpuValue<float>>()};
                    string __pad_K7NEQvIAH8KLcd8REnByw7_7 = __slot_K7NEQvIAH8KLcd8REnByw7;
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "RPVJ2gC7BxdMl03EhjEfqM", 347923U);
                    var Output_9 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3>.Create(Node_Context: Node_Context_8);
                    state_6.__p_RPVJ2gC7BxdMl03EhjEfqM = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "HK63HTYEyuWOO7bvtHphiy", 347930U);
                    var Output_11 = n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float>.Create(Node_Context: Node_Context_10);
                    state_6.__p_HK63HTYEyuWOO7bvtHphiy = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "CUVdAastZaHOofdQcxE0Yn", 347948U);
                    var Output_13 = n49.xMyMz_split_HhwKvU63boDLFOLEO95pTD.Create(Node_Context: Node_Context_12);
                    state_6.__p_CUVdAastZaHOofdQcxE0Yn = Output_13;
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "AKmGbiEcX6DQCKMhtQlnKJ", 347955U);
                    var Output_15 = n20.Abs_HYWPOtC1lkrNB5uGryHr5l<float>.Create(Node_Context: Node_Context_14);
                    state_6.__p_AKmGbiEcX6DQCKMhtQlnKJ = Output_15;
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Nc0r7aMhB8HOfkWWG2F0Gi", 348001U);
                    var Output_17 = n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float>.Create(Node_Context: Node_Context_16);
                    state_6.__p_Nc0r7aMhB8HOfkWWG2F0Gi = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "PWwbCDQGFPlQVnSY5ytnlo", 348033U);
                    var Output_19 = n20.Abs_HYWPOtC1lkrNB5uGryHr5l<float>.Create(Node_Context: Node_Context_18);
                    state_6.__p_PWwbCDQGFPlQVnSY5ytnlo = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "PGAnvCTZP0JLAdzNxRwIDK", 348047U);
                    var Output_21 = n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float>.Create(Node_Context: Node_Context_20);
                    state_6.__p_PGAnvCTZP0JLAdzNxRwIDK = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Ma8QstQ9AgSOiZfXg2eH61", 348128U);
                    var Output_23 = n20.Abs_HYWPOtC1lkrNB5uGryHr5l<float>.Create(Node_Context: Node_Context_22);
                    state_6.__p_Ma8QstQ9AgSOiZfXg2eH61 = Output_23;
                    n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Sx6p8g82gVcPJG4DUHeSjv", 348142U);
                    var Output_25 = n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float>.Create(Node_Context: Node_Context_24);
                    state_6.__p_Sx6p8g82gVcPJG4DUHeSjv = Output_25;
                    n1.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "LSxzfmANmGrK94IsLskzNo", 348153U);
                    var Output_27 = n41.xPyPz_join_DXQAa9JpsvIPaXxJNoozEM.Create(Node_Context: Node_Context_26);
                    state_6.__p_LSxzfmANmGrK94IsLskzNo = Output_27;
                    n1.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "KcIeQ7qjbf5QIIJPW3wjqI", 348176U);
                    var Output_29 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_28, ID_In: __pad_K7NEQvIAH8KLcd8REnByw7_7);
                    state_6.__p_KcIeQ7qjbf5QIIJPW3wjqI = Output_29;
                }

                float __pad_ORJKhvzrnOJNRX1vgI1skz_30 = __slot_ORJKhvzrnOJNRX1vgI1skz;
                int Id_31 = 0;
                var State_Output_33 = state_6.__p_RPVJ2gC7BxdMl03EhjEfqM.Update(The_Override_In: TDomain_In, Id_In: Id_31, Output_Out: out n5.GpuValue<n22.Vector3> Output_32);
                n5.GpuValue<n22.Vector3> __pad_KyG4GAvazUKMCAoH36cpw5_34 = Output_32;
                var State_Output_36 = state_6.__p_HK63HTYEyuWOO7bvtHphiy.Update(GpuValue_In: Offset_In, The_Value_In: __pad_ORJKhvzrnOJNRX1vgI1skz_30, Output_Out: out n5.GpuValue<float> Output_35);
                var Output_40 = state_6.__p_CUVdAastZaHOofdQcxE0Yn.Update(value_In: __pad_KyG4GAvazUKMCAoH36cpw5_34, x_Out: out n5.GpuValue<float> x_37, y_Out: out n5.GpuValue<float> y_38, z_Out: out n5.GpuValue<float> z_39);
                var Output_42 = state_6.__p_AKmGbiEcX6DQCKMhtQlnKJ.Update(Input_In: x_37, Out_Out: out n5.GpuValue<float> Out_41);
                var builder_43 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi, 2);
                builder_43.Add(Out_41);
                builder_43.Add(Output_35);
                var __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi_44 = builder_43.Commit();
                var State_Output_46 = state_6.__p_Nc0r7aMhB8HOfkWWG2F0Gi.Update(Input_In: __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi_44, Output_Out: out n5.GpuValue<float> Output_45);
                var Output_48 = state_6.__p_PWwbCDQGFPlQVnSY5ytnlo.Update(Input_In: y_38, Out_Out: out n5.GpuValue<float> Out_47);
                var builder_49 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK, 2);
                builder_49.Add(Out_47);
                builder_49.Add(Output_35);
                var __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK_50 = builder_49.Commit();
                var State_Output_52 = state_6.__p_PGAnvCTZP0JLAdzNxRwIDK.Update(Input_In: __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK_50, Output_Out: out n5.GpuValue<float> Output_51);
                int __pad_TvbnD4XUAqNMYyhr1TY9ko_53 = (int)Axis_In;
                int Input_54 = 1;
                var Result_55 = Input_54 == __pad_TvbnD4XUAqNMYyhr1TY9ko_53;
                int Index_56 = n2.Convert.ToInt32(Result_55);
                var builder_57 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF, 2);
                builder_57.Add(y_38);
                builder_57.Add(Output_51);
                var __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF_58 = builder_57.Commit();
                n13._Operations_.Switch<n5.GpuValue<float>, n12.__AdaptiveImplementations__MzilLTk6yNROg5SWTCtzZM>(Index_In: Index_56, Input_In: __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF_58, Output_Out: out n5.GpuValue<float> Output_59);
                int Input_60 = 0;
                var Result_61 = Input_60 == __pad_TvbnD4XUAqNMYyhr1TY9ko_53;
                int Index_62 = n2.Convert.ToInt32(Result_61);
                var builder_63 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_KxEy3McZBxmNQPD3568ynd, 2);
                builder_63.Add(x_37);
                builder_63.Add(Output_45);
                var __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd_64 = builder_63.Commit();
                n13._Operations_.Switch<n5.GpuValue<float>, n12.__AdaptiveImplementations__MzilLTk6yNROg5SWTCtzZM>(Index_In: Index_62, Input_In: __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd_64, Output_Out: out n5.GpuValue<float> Output_65);
                int Input_66 = 2;
                var Result_67 = Input_66 == __pad_TvbnD4XUAqNMYyhr1TY9ko_53;
                int Index_68 = n2.Convert.ToInt32(Result_67);
                var Output_70 = state_6.__p_Ma8QstQ9AgSOiZfXg2eH61.Update(Input_In: z_39, Out_Out: out n5.GpuValue<float> Out_69);
                var builder_71 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv, 2);
                builder_71.Add(Out_69);
                builder_71.Add(Output_35);
                var __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv_72 = builder_71.Commit();
                var State_Output_74 = state_6.__p_Sx6p8g82gVcPJG4DUHeSjv.Update(Input_In: __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv_72, Output_Out: out n5.GpuValue<float> Output_73);
                var builder_75 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6, 2);
                builder_75.Add(z_39);
                builder_75.Add(Output_73);
                var __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6_76 = builder_75.Commit();
                n13._Operations_.Switch<n5.GpuValue<float>, n12.__AdaptiveImplementations__MzilLTk6yNROg5SWTCtzZM>(Index_In: Index_68, Input_In: __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6_76, Output_Out: out n5.GpuValue<float> Output_77);
                var State_Output_79 = state_6.__p_LSxzfmANmGrK94IsLskzNo.Update(x_In: Output_65, y_In: Output_59, z_In: Output_77, Output_Out: out n5.GpuValue<n22.Vector3> Output_78);
                bool Update_80 = true;
                var Output_81 = state_6.__p_KcIeQ7qjbf5QIIJPW3wjqI;
                if (Update_80)
                {
                    Output_81 = state_6.__p_KcIeQ7qjbf5QIIJPW3wjqI.Update(Input_In: Output_78);
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_33 != state_6.__p_RPVJ2gC7BxdMl03EhjEfqM || Output_32 != state_6.__slot_KyG4GAvazUKMCAoH36cpw5 || State_Output_36 != state_6.__p_HK63HTYEyuWOO7bvtHphiy || Output_40 != state_6.__p_CUVdAastZaHOofdQcxE0Yn || Output_42 != state_6.__p_AKmGbiEcX6DQCKMhtQlnKJ || __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi_44 != state_6.__pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi || State_Output_46 != state_6.__p_Nc0r7aMhB8HOfkWWG2F0Gi || Output_48 != state_6.__p_PWwbCDQGFPlQVnSY5ytnlo || __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK_50 != state_6.__pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK || State_Output_52 != state_6.__p_PGAnvCTZP0JLAdzNxRwIDK || (int)Axis_In != state_6.__slot_TvbnD4XUAqNMYyhr1TY9ko || __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF_58 != state_6.__pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF || __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd_64 != state_6.__pin_group_Input_In_KxEy3McZBxmNQPD3568ynd || Output_70 != state_6.__p_Ma8QstQ9AgSOiZfXg2eH61 || __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv_72 != state_6.__pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv || State_Output_74 != state_6.__p_Sx6p8g82gVcPJG4DUHeSjv || __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6_76 != state_6.__pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6 || State_Output_79 != state_6.__p_LSxzfmANmGrK94IsLskzNo || Output_81 != state_6.__p_KcIeQ7qjbf5QIIJPW3wjqI ? new __A4bbzsZizZpOUXQub9iBEZ(state_6)
                    {__p_RPVJ2gC7BxdMl03EhjEfqM = State_Output_33, __slot_KyG4GAvazUKMCAoH36cpw5 = Output_32, __p_HK63HTYEyuWOO7bvtHphiy = State_Output_36, __p_CUVdAastZaHOofdQcxE0Yn = Output_40, __p_AKmGbiEcX6DQCKMhtQlnKJ = Output_42, __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi = __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi_44, __p_Nc0r7aMhB8HOfkWWG2F0Gi = State_Output_46, __p_PWwbCDQGFPlQVnSY5ytnlo = Output_48, __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK = __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK_50, __p_PGAnvCTZP0JLAdzNxRwIDK = State_Output_52, __slot_TvbnD4XUAqNMYyhr1TY9ko = (int)Axis_In, __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF = __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF_58, __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd = __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd_64, __p_Ma8QstQ9AgSOiZfXg2eH61 = Output_70, __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv = __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv_72, __p_Sx6p8g82gVcPJG4DUHeSjv = State_Output_74, __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6 = __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6_76, __p_LSxzfmANmGrK94IsLskzNo = State_Output_79, __p_KcIeQ7qjbf5QIIJPW3wjqI = Output_81} : state_6;
                else
                {
                    state_6.__p_RPVJ2gC7BxdMl03EhjEfqM = State_Output_33;
                    state_6.__slot_KyG4GAvazUKMCAoH36cpw5 = Output_32;
                    state_6.__p_HK63HTYEyuWOO7bvtHphiy = State_Output_36;
                    state_6.__p_CUVdAastZaHOofdQcxE0Yn = Output_40;
                    state_6.__p_AKmGbiEcX6DQCKMhtQlnKJ = Output_42;
                    state_6.__pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi = __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi_44;
                    state_6.__p_Nc0r7aMhB8HOfkWWG2F0Gi = State_Output_46;
                    state_6.__p_PWwbCDQGFPlQVnSY5ytnlo = Output_48;
                    state_6.__pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK = __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK_50;
                    state_6.__p_PGAnvCTZP0JLAdzNxRwIDK = State_Output_52;
                    state_6.__slot_TvbnD4XUAqNMYyhr1TY9ko = (int)Axis_In;
                    state_6.__pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF = __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF_58;
                    state_6.__pin_group_Input_In_KxEy3McZBxmNQPD3568ynd = __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd_64;
                    state_6.__p_Ma8QstQ9AgSOiZfXg2eH61 = Output_70;
                    state_6.__pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv = __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv_72;
                    state_6.__p_Sx6p8g82gVcPJG4DUHeSjv = State_Output_74;
                    state_6.__pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6 = __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6_76;
                    state_6.__p_LSxzfmANmGrK94IsLskzNo = State_Output_79;
                    state_6.__p_KcIeQ7qjbf5QIIJPW3wjqI = Output_81;
                }

                outputs_4 = n2.ValueTuple.Create(Output_78);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_82 = outputs_4.Item1;
            Output_Out = __auto_82;
            n46.DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5 that_83 = this;
            if (this.__GetContext__().IsImmutable)
                that_83 = manager_2 != this.__cache_GbBMoLElQVzLhsdarN2IFI ? new DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5(this)
                {__cache_GbBMoLElQVzLhsdarN2IFI = manager_2} : that_83;
            else
            {
                this.__cache_GbBMoLElQVzLhsdarN2IFI = manager_2;
            }

            return that_83;
        }

        public n46.DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5 __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n46.DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5 that_0 = this;
            this.__cache_GbBMoLElQVzLhsdarN2IFI = null;
            return that_0;
        }

        public n46.DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5 __CreateDefault__()
        {
            n46.DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5 that_0 = this;
            this.__cache_GbBMoLElQVzLhsdarN2IFI = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_GbBMoLElQVzLhsdarN2IFI);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 348203U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "PdiuPSHVcz6LNjTkIfQBva", Name = "__slot_PdiuPSHVcz6LNjTkIfQBva")]
        public static string __slot_PdiuPSHVcz6LNjTkIfQBva = "\t// Mirror at an axis-aligned plane which is at a specified distance <dist> from the origin.\r\n\tfloat pMirror (inout float p, float dist) \r\n\t{\r\n\t\tfloat s = sgn(p);\r\n\t\tp = abs(p)-dist;\r\n\t\treturn s;\r\n\t}";
        [n1.ElementAttribute(TracingId = 347571U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "GbBMoLElQVzLhsdarN2IFI", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<float>, n48.PickOneXYZ>, n2.ValueTuple<n5.GpuValue<n22.Vector3>>> __cache_GbBMoLElQVzLhsdarN2IFI = null;
        [n1.ElementAttribute(TracingId = 348181U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "K7NEQvIAH8KLcd8REnByw7", Name = "__slot_K7NEQvIAH8KLcd8REnByw7")]
        public static string __slot_K7NEQvIAH8KLcd8REnByw7 = "DomainMirror3D";
        [n1.ElementAttribute(TracingId = 347938U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "ORJKhvzrnOJNRX1vgI1skz", Name = "__slot_ORJKhvzrnOJNRX1vgI1skz")]
        public static float __slot_ORJKhvzrnOJNRX1vgI1skz = 0F;
        static DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5()
        {
        }

        public DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5(DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5 other): base(other)
        {
            this.__cache_GbBMoLElQVzLhsdarN2IFI = other.__cache_GbBMoLElQVzLhsdarN2IFI;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_GbBMoLElQVzLhsdarN2IFI", in __cache_GbBMoLElQVzLhsdarN2IFI));
        }

        internal DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5 __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<float>, n48.PickOneXYZ>, n2.ValueTuple<n5.GpuValue<n22.Vector3>>> __cache_GbBMoLElQVzLhsdarN2IFI)
        {
            n46.DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_GbBMoLElQVzLhsdarN2IFI != this.__cache_GbBMoLElQVzLhsdarN2IFI ? new DomainMirror_IwCI2IWcZUQLfSNRL5TFZ5(this)
                {__cache_GbBMoLElQVzLhsdarN2IFI = __cache_GbBMoLElQVzLhsdarN2IFI} : that_0;
            else
            {
                this.__cache_GbBMoLElQVzLhsdarN2IFI = __cache_GbBMoLElQVzLhsdarN2IFI;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "A4bbzsZizZpOUXQub9iBEZ", Name = "__A4bbzsZizZpOUXQub9iBEZ")]
        [n2.SerializableAttribute]
        public class __A4bbzsZizZpOUXQub9iBEZ : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RPVJ2gC7BxdMl03EhjEfqM);
                n1.CompilationHelper.SafeDispose(this.__p_HK63HTYEyuWOO7bvtHphiy);
                n1.CompilationHelper.SafeDispose(this.__p_CUVdAastZaHOofdQcxE0Yn);
                n1.CompilationHelper.SafeDispose(this.__p_AKmGbiEcX6DQCKMhtQlnKJ);
                n1.CompilationHelper.SafeDispose(this.__p_Nc0r7aMhB8HOfkWWG2F0Gi);
                n1.CompilationHelper.SafeDispose(this.__p_PWwbCDQGFPlQVnSY5ytnlo);
                n1.CompilationHelper.SafeDispose(this.__p_PGAnvCTZP0JLAdzNxRwIDK);
                n1.CompilationHelper.SafeDispose(this.__p_Ma8QstQ9AgSOiZfXg2eH61);
                n1.CompilationHelper.SafeDispose(this.__p_Sx6p8g82gVcPJG4DUHeSjv);
                n1.CompilationHelper.SafeDispose(this.__p_LSxzfmANmGrK94IsLskzNo);
                n1.CompilationHelper.SafeDispose(this.__p_KcIeQ7qjbf5QIIJPW3wjqI);
                return;
            }

            [n1.ElementAttribute(TracingId = 347923U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "RPVJ2gC7BxdMl03EhjEfqM", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_RPVJ2gC7BxdMl03EhjEfqM;
            [n1.ElementAttribute(TracingId = 347930U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "HK63HTYEyuWOO7bvtHphiy", Name = "CheckDefault", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_HK63HTYEyuWOO7bvtHphiy;
            [n1.ElementAttribute(TracingId = 347948U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "CUVdAastZaHOofdQcxE0Yn", Name = "x-y-z (split)", IsManaged = true, IsAutoGenerated = true)]
            public n49.xMyMz_split_HhwKvU63boDLFOLEO95pTD __p_CUVdAastZaHOofdQcxE0Yn;
            [n1.ElementAttribute(TracingId = 347955U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "AKmGbiEcX6DQCKMhtQlnKJ", Name = "Abs", IsManaged = true, IsAutoGenerated = true)]
            public n20.Abs_HYWPOtC1lkrNB5uGryHr5l<float> __p_AKmGbiEcX6DQCKMhtQlnKJ;
            [n1.ElementAttribute(TracingId = 348001U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Nc0r7aMhB8HOfkWWG2F0Gi", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float> __p_Nc0r7aMhB8HOfkWWG2F0Gi;
            [n1.ElementAttribute(TracingId = 348033U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "PWwbCDQGFPlQVnSY5ytnlo", Name = "Abs", IsManaged = true, IsAutoGenerated = true)]
            public n20.Abs_HYWPOtC1lkrNB5uGryHr5l<float> __p_PWwbCDQGFPlQVnSY5ytnlo;
            [n1.ElementAttribute(TracingId = 348047U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "PGAnvCTZP0JLAdzNxRwIDK", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float> __p_PGAnvCTZP0JLAdzNxRwIDK;
            [n1.ElementAttribute(TracingId = 348128U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Ma8QstQ9AgSOiZfXg2eH61", Name = "Abs", IsManaged = true, IsAutoGenerated = true)]
            public n20.Abs_HYWPOtC1lkrNB5uGryHr5l<float> __p_Ma8QstQ9AgSOiZfXg2eH61;
            [n1.ElementAttribute(TracingId = 348142U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Sx6p8g82gVcPJG4DUHeSjv", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float> __p_Sx6p8g82gVcPJG4DUHeSjv;
            [n1.ElementAttribute(TracingId = 348153U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "LSxzfmANmGrK94IsLskzNo", Name = "x+y+z (join)", IsManaged = true, IsAutoGenerated = true)]
            public n41.xPyPz_join_DXQAa9JpsvIPaXxJNoozEM __p_LSxzfmANmGrK94IsLskzNo;
            [n1.ElementAttribute(TracingId = 348176U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "KcIeQ7qjbf5QIIJPW3wjqI", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_KcIeQ7qjbf5QIIJPW3wjqI;
            [n1.ElementAttribute(TracingId = 347910U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "KyG4GAvazUKMCAoH36cpw5", Name = "__slot_KyG4GAvazUKMCAoH36cpw5")]
            public n5.GpuValue<n22.Vector3> __slot_KyG4GAvazUKMCAoH36cpw5;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi = default(n11.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK = default(n11.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(TracingId = 347943U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "TvbnD4XUAqNMYyhr1TY9ko", Name = "__slot_TvbnD4XUAqNMYyhr1TY9ko")]
            public int __slot_TvbnD4XUAqNMYyhr1TY9ko;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF = default(n11.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd = default(n11.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv = default(n11.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6 = default(n11.Spread<n5.GpuValue<float>>);
            public __A4bbzsZizZpOUXQub9iBEZ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __A4bbzsZizZpOUXQub9iBEZ(__A4bbzsZizZpOUXQub9iBEZ other): base(other)
            {
                this.__p_RPVJ2gC7BxdMl03EhjEfqM = other.__p_RPVJ2gC7BxdMl03EhjEfqM;
                this.__p_HK63HTYEyuWOO7bvtHphiy = other.__p_HK63HTYEyuWOO7bvtHphiy;
                this.__p_CUVdAastZaHOofdQcxE0Yn = other.__p_CUVdAastZaHOofdQcxE0Yn;
                this.__p_AKmGbiEcX6DQCKMhtQlnKJ = other.__p_AKmGbiEcX6DQCKMhtQlnKJ;
                this.__p_Nc0r7aMhB8HOfkWWG2F0Gi = other.__p_Nc0r7aMhB8HOfkWWG2F0Gi;
                this.__p_PWwbCDQGFPlQVnSY5ytnlo = other.__p_PWwbCDQGFPlQVnSY5ytnlo;
                this.__p_PGAnvCTZP0JLAdzNxRwIDK = other.__p_PGAnvCTZP0JLAdzNxRwIDK;
                this.__p_Ma8QstQ9AgSOiZfXg2eH61 = other.__p_Ma8QstQ9AgSOiZfXg2eH61;
                this.__p_Sx6p8g82gVcPJG4DUHeSjv = other.__p_Sx6p8g82gVcPJG4DUHeSjv;
                this.__p_LSxzfmANmGrK94IsLskzNo = other.__p_LSxzfmANmGrK94IsLskzNo;
                this.__p_KcIeQ7qjbf5QIIJPW3wjqI = other.__p_KcIeQ7qjbf5QIIJPW3wjqI;
                this.__slot_KyG4GAvazUKMCAoH36cpw5 = other.__slot_KyG4GAvazUKMCAoH36cpw5;
                this.__pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi = other.__pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi;
                this.__pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK = other.__pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK;
                this.__slot_TvbnD4XUAqNMYyhr1TY9ko = other.__slot_TvbnD4XUAqNMYyhr1TY9ko;
                this.__pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF = other.__pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF;
                this.__pin_group_Input_In_KxEy3McZBxmNQPD3568ynd = other.__pin_group_Input_In_KxEy3McZBxmNQPD3568ynd;
                this.__pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv = other.__pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv;
                this.__pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6 = other.__pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RPVJ2gC7BxdMl03EhjEfqM", in __p_RPVJ2gC7BxdMl03EhjEfqM), n1.CompilationHelper.GetValueOrExisting(values, "__p_HK63HTYEyuWOO7bvtHphiy", in __p_HK63HTYEyuWOO7bvtHphiy), n1.CompilationHelper.GetValueOrExisting(values, "__p_CUVdAastZaHOofdQcxE0Yn", in __p_CUVdAastZaHOofdQcxE0Yn), n1.CompilationHelper.GetValueOrExisting(values, "__p_AKmGbiEcX6DQCKMhtQlnKJ", in __p_AKmGbiEcX6DQCKMhtQlnKJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_Nc0r7aMhB8HOfkWWG2F0Gi", in __p_Nc0r7aMhB8HOfkWWG2F0Gi), n1.CompilationHelper.GetValueOrExisting(values, "__p_PWwbCDQGFPlQVnSY5ytnlo", in __p_PWwbCDQGFPlQVnSY5ytnlo), n1.CompilationHelper.GetValueOrExisting(values, "__p_PGAnvCTZP0JLAdzNxRwIDK", in __p_PGAnvCTZP0JLAdzNxRwIDK), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ma8QstQ9AgSOiZfXg2eH61", in __p_Ma8QstQ9AgSOiZfXg2eH61), n1.CompilationHelper.GetValueOrExisting(values, "__p_Sx6p8g82gVcPJG4DUHeSjv", in __p_Sx6p8g82gVcPJG4DUHeSjv), n1.CompilationHelper.GetValueOrExisting(values, "__p_LSxzfmANmGrK94IsLskzNo", in __p_LSxzfmANmGrK94IsLskzNo), n1.CompilationHelper.GetValueOrExisting(values, "__p_KcIeQ7qjbf5QIIJPW3wjqI", in __p_KcIeQ7qjbf5QIIJPW3wjqI), n1.CompilationHelper.GetValueOrExisting(values, "__slot_KyG4GAvazUKMCAoH36cpw5", in __slot_KyG4GAvazUKMCAoH36cpw5), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi", in __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK", in __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK), n1.CompilationHelper.GetValueOrExisting(values, "__slot_TvbnD4XUAqNMYyhr1TY9ko", in __slot_TvbnD4XUAqNMYyhr1TY9ko), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF", in __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_KxEy3McZBxmNQPD3568ynd", in __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv", in __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6", in __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6));
            }

            internal __A4bbzsZizZpOUXQub9iBEZ __WITH__(n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_RPVJ2gC7BxdMl03EhjEfqM, n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_HK63HTYEyuWOO7bvtHphiy, n49.xMyMz_split_HhwKvU63boDLFOLEO95pTD __p_CUVdAastZaHOofdQcxE0Yn, n20.Abs_HYWPOtC1lkrNB5uGryHr5l<float> __p_AKmGbiEcX6DQCKMhtQlnKJ, n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float> __p_Nc0r7aMhB8HOfkWWG2F0Gi, n20.Abs_HYWPOtC1lkrNB5uGryHr5l<float> __p_PWwbCDQGFPlQVnSY5ytnlo, n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float> __p_PGAnvCTZP0JLAdzNxRwIDK, n20.Abs_HYWPOtC1lkrNB5uGryHr5l<float> __p_Ma8QstQ9AgSOiZfXg2eH61, n20.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float> __p_Sx6p8g82gVcPJG4DUHeSjv, n41.xPyPz_join_DXQAa9JpsvIPaXxJNoozEM __p_LSxzfmANmGrK94IsLskzNo, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_KcIeQ7qjbf5QIIJPW3wjqI, n5.GpuValue<n22.Vector3> __slot_KyG4GAvazUKMCAoH36cpw5, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK, int __slot_TvbnD4XUAqNMYyhr1TY9ko, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv, n11.Spread<n5.GpuValue<float>> __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6)
            {
                __A4bbzsZizZpOUXQub9iBEZ that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RPVJ2gC7BxdMl03EhjEfqM != this.__p_RPVJ2gC7BxdMl03EhjEfqM || __p_HK63HTYEyuWOO7bvtHphiy != this.__p_HK63HTYEyuWOO7bvtHphiy || __p_CUVdAastZaHOofdQcxE0Yn != this.__p_CUVdAastZaHOofdQcxE0Yn || __p_AKmGbiEcX6DQCKMhtQlnKJ != this.__p_AKmGbiEcX6DQCKMhtQlnKJ || __p_Nc0r7aMhB8HOfkWWG2F0Gi != this.__p_Nc0r7aMhB8HOfkWWG2F0Gi || __p_PWwbCDQGFPlQVnSY5ytnlo != this.__p_PWwbCDQGFPlQVnSY5ytnlo || __p_PGAnvCTZP0JLAdzNxRwIDK != this.__p_PGAnvCTZP0JLAdzNxRwIDK || __p_Ma8QstQ9AgSOiZfXg2eH61 != this.__p_Ma8QstQ9AgSOiZfXg2eH61 || __p_Sx6p8g82gVcPJG4DUHeSjv != this.__p_Sx6p8g82gVcPJG4DUHeSjv || __p_LSxzfmANmGrK94IsLskzNo != this.__p_LSxzfmANmGrK94IsLskzNo || __p_KcIeQ7qjbf5QIIJPW3wjqI != this.__p_KcIeQ7qjbf5QIIJPW3wjqI || __slot_KyG4GAvazUKMCAoH36cpw5 != this.__slot_KyG4GAvazUKMCAoH36cpw5 || __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi != this.__pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi || __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK != this.__pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK || __slot_TvbnD4XUAqNMYyhr1TY9ko != this.__slot_TvbnD4XUAqNMYyhr1TY9ko || __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF != this.__pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF || __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd != this.__pin_group_Input_In_KxEy3McZBxmNQPD3568ynd || __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv != this.__pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv || __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6 != this.__pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6 ? new __A4bbzsZizZpOUXQub9iBEZ(this)
                    {__p_RPVJ2gC7BxdMl03EhjEfqM = __p_RPVJ2gC7BxdMl03EhjEfqM, __p_HK63HTYEyuWOO7bvtHphiy = __p_HK63HTYEyuWOO7bvtHphiy, __p_CUVdAastZaHOofdQcxE0Yn = __p_CUVdAastZaHOofdQcxE0Yn, __p_AKmGbiEcX6DQCKMhtQlnKJ = __p_AKmGbiEcX6DQCKMhtQlnKJ, __p_Nc0r7aMhB8HOfkWWG2F0Gi = __p_Nc0r7aMhB8HOfkWWG2F0Gi, __p_PWwbCDQGFPlQVnSY5ytnlo = __p_PWwbCDQGFPlQVnSY5ytnlo, __p_PGAnvCTZP0JLAdzNxRwIDK = __p_PGAnvCTZP0JLAdzNxRwIDK, __p_Ma8QstQ9AgSOiZfXg2eH61 = __p_Ma8QstQ9AgSOiZfXg2eH61, __p_Sx6p8g82gVcPJG4DUHeSjv = __p_Sx6p8g82gVcPJG4DUHeSjv, __p_LSxzfmANmGrK94IsLskzNo = __p_LSxzfmANmGrK94IsLskzNo, __p_KcIeQ7qjbf5QIIJPW3wjqI = __p_KcIeQ7qjbf5QIIJPW3wjqI, __slot_KyG4GAvazUKMCAoH36cpw5 = __slot_KyG4GAvazUKMCAoH36cpw5, __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi = __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi, __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK = __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK, __slot_TvbnD4XUAqNMYyhr1TY9ko = __slot_TvbnD4XUAqNMYyhr1TY9ko, __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF = __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF, __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd = __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd, __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv = __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv, __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6 = __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6} : that_0;
                else
                {
                    this.__p_RPVJ2gC7BxdMl03EhjEfqM = __p_RPVJ2gC7BxdMl03EhjEfqM;
                    this.__p_HK63HTYEyuWOO7bvtHphiy = __p_HK63HTYEyuWOO7bvtHphiy;
                    this.__p_CUVdAastZaHOofdQcxE0Yn = __p_CUVdAastZaHOofdQcxE0Yn;
                    this.__p_AKmGbiEcX6DQCKMhtQlnKJ = __p_AKmGbiEcX6DQCKMhtQlnKJ;
                    this.__p_Nc0r7aMhB8HOfkWWG2F0Gi = __p_Nc0r7aMhB8HOfkWWG2F0Gi;
                    this.__p_PWwbCDQGFPlQVnSY5ytnlo = __p_PWwbCDQGFPlQVnSY5ytnlo;
                    this.__p_PGAnvCTZP0JLAdzNxRwIDK = __p_PGAnvCTZP0JLAdzNxRwIDK;
                    this.__p_Ma8QstQ9AgSOiZfXg2eH61 = __p_Ma8QstQ9AgSOiZfXg2eH61;
                    this.__p_Sx6p8g82gVcPJG4DUHeSjv = __p_Sx6p8g82gVcPJG4DUHeSjv;
                    this.__p_LSxzfmANmGrK94IsLskzNo = __p_LSxzfmANmGrK94IsLskzNo;
                    this.__p_KcIeQ7qjbf5QIIJPW3wjqI = __p_KcIeQ7qjbf5QIIJPW3wjqI;
                    this.__slot_KyG4GAvazUKMCAoH36cpw5 = __slot_KyG4GAvazUKMCAoH36cpw5;
                    this.__pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi = __pin_group_Input_In_Nc0r7aMhB8HOfkWWG2F0Gi;
                    this.__pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK = __pin_group_Input_In_PGAnvCTZP0JLAdzNxRwIDK;
                    this.__slot_TvbnD4XUAqNMYyhr1TY9ko = __slot_TvbnD4XUAqNMYyhr1TY9ko;
                    this.__pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF = __pin_group_Input_In_BRyZiOMDDy4Lz2R2VXbAjF;
                    this.__pin_group_Input_In_KxEy3McZBxmNQPD3568ynd = __pin_group_Input_In_KxEy3McZBxmNQPD3568ynd;
                    this.__pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv = __pin_group_Input_In_Sx6p8g82gVcPJG4DUHeSjv;
                    this.__pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6 = __pin_group_Input_In_NWLjxoImi4gPSTASkRmYk6;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 349427U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "QXIcYJlYSKqPVu3OkQ9YeW", Name = "DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW")]
    [n2.SerializableAttribute]
    public class DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n46.DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW Create(n1.NodeContext Node_Context)
        {
            var instance = new DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n46.DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW CreateDefault()
        {
            var instance = new DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n46.DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW Update(n5.GpuValue<n22.Vector3> TDomain_In, n5.GpuValue<n22.Matrix> Transform_In, [n4.SerializedDefaultValueAttribute("True", false)] bool W_In, out n5.GpuValue<n22.Vector3> Domain_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_Dto5uZzfFQ1QFwkdZbPoEf;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<n22.Matrix>, bool>, n2.ValueTuple<n5.GpuValue<n22.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n22.Vector3>)));
            }

            var inputs_3 = (TDomain_In, Transform_In, W_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__H2LGW9Xt3jGMMWq0R87Wev>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __H2LGW9Xt3jGMMWq0R87Wev(__GetContext__(), n1.VLObject.NewIdentity())
                    {__slot_EOmCjvkgMpLPCZoq5TnoWj = default(n5.GpuValue<n22.Vector3>), __slot_Ptti416h9iYMze7XyL24kA = default(n5.GpuValue<n22.Vector4>)};
                    string __pad_KHGKCvcylUFQaakPaAQnIA_7 = __slot_KHGKCvcylUFQaakPaAQnIA;
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "NBIoIq6BdCEPR9N1JfTtct", 349481U);
                    var Output_9 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3>.Create(Node_Context: Node_Context_8);
                    state_6.__p_NBIoIq6BdCEPR9N1JfTtct = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "OXas1f5psD3NwKiXYAtZBG", 349495U);
                    var Output_11 = n20.Mul_B0P7ghpqXJiLy15iE7sIid<n22.Vector4, n22.Matrix, n22.Vector4>.Create(Node_Context: Node_Context_10);
                    state_6.__p_OXas1f5psD3NwKiXYAtZBG = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "OSdHq9wfPbdMh24wXmVUJZ", 349511U);
                    var Output_13 = n40.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_12);
                    state_6.__p_OSdHq9wfPbdMh24wXmVUJZ = Output_13;
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "MqJ3crxuTBFO5TmVGn8XFR", 349565U);
                    var Output_15 = n41.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_14);
                    state_6.__p_MqJ3crxuTBFO5TmVGn8XFR = Output_15;
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "JBafjic6173PRwDX3QVadT", 349593U);
                    var Output_17 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_16);
                    state_6.__p_JBafjic6173PRwDX3QVadT = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "HmLxjhhea0JQKMK6qScCkA", 349609U);
                    var Output_19 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_18, ID_In: __pad_KHGKCvcylUFQaakPaAQnIA_7);
                    state_6.__p_HmLxjhhea0JQKMK6qScCkA = Output_19;
                }

                int Id_20 = 0;
                var State_Output_22 = state_6.__p_NBIoIq6BdCEPR9N1JfTtct.Update(The_Override_In: TDomain_In, Id_In: Id_20, Output_Out: out n5.GpuValue<n22.Vector3> Output_21);
                n5.GpuValue<n22.Vector3> __pad_EOmCjvkgMpLPCZoq5TnoWj_23 = Output_21;
                bool __pad_IOickkv7MGNN8lqec4GexV_24 = W_In;
                float Value_25 = n2.Convert.ToSingle(__pad_IOickkv7MGNN8lqec4GexV_24);
                var Output_27 = state_6.__p_JBafjic6173PRwDX3QVadT.Update(Value_In: Value_25, GpuValue_Out: out n5.GpuValue<float> GpuValue_26);
                var State_Output_29 = state_6.__p_MqJ3crxuTBFO5TmVGn8XFR.Update(xyz_In: __pad_EOmCjvkgMpLPCZoq5TnoWj_23, w_In: GpuValue_26, Output_Out: out n5.GpuValue<n22.Vector4> Output_28);
                var State_Output_31 = state_6.__p_OXas1f5psD3NwKiXYAtZBG.Update(Input1_In: Output_28, Input2_In: Transform_In, Output_Out: out n5.GpuValue<n22.Vector4> Output_30);
                n5.GpuValue<n22.Vector4> __pad_Ptti416h9iYMze7XyL24kA_32 = Output_30;
                var State_Output_34 = state_6.__p_OSdHq9wfPbdMh24wXmVUJZ.Update(Input_In: __pad_Ptti416h9iYMze7XyL24kA_32, Output_Out: out n5.GpuValue<n22.Vector3> Output_33);
                bool Update_35 = true;
                var Output_36 = state_6.__p_HmLxjhhea0JQKMK6qScCkA;
                if (Update_35)
                {
                    Output_36 = state_6.__p_HmLxjhhea0JQKMK6qScCkA.Update(Input_In: Output_33);
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_22 != state_6.__p_NBIoIq6BdCEPR9N1JfTtct || Output_21 != state_6.__slot_EOmCjvkgMpLPCZoq5TnoWj || W_In != state_6.__slot_IOickkv7MGNN8lqec4GexV || Output_27 != state_6.__p_JBafjic6173PRwDX3QVadT || State_Output_29 != state_6.__p_MqJ3crxuTBFO5TmVGn8XFR || State_Output_31 != state_6.__p_OXas1f5psD3NwKiXYAtZBG || Output_30 != state_6.__slot_Ptti416h9iYMze7XyL24kA || State_Output_34 != state_6.__p_OSdHq9wfPbdMh24wXmVUJZ || Output_36 != state_6.__p_HmLxjhhea0JQKMK6qScCkA ? new __H2LGW9Xt3jGMMWq0R87Wev(state_6)
                    {__p_NBIoIq6BdCEPR9N1JfTtct = State_Output_22, __slot_EOmCjvkgMpLPCZoq5TnoWj = Output_21, __slot_IOickkv7MGNN8lqec4GexV = W_In, __p_JBafjic6173PRwDX3QVadT = Output_27, __p_MqJ3crxuTBFO5TmVGn8XFR = State_Output_29, __p_OXas1f5psD3NwKiXYAtZBG = State_Output_31, __slot_Ptti416h9iYMze7XyL24kA = Output_30, __p_OSdHq9wfPbdMh24wXmVUJZ = State_Output_34, __p_HmLxjhhea0JQKMK6qScCkA = Output_36} : state_6;
                else
                {
                    state_6.__p_NBIoIq6BdCEPR9N1JfTtct = State_Output_22;
                    state_6.__slot_EOmCjvkgMpLPCZoq5TnoWj = Output_21;
                    state_6.__slot_IOickkv7MGNN8lqec4GexV = W_In;
                    state_6.__p_JBafjic6173PRwDX3QVadT = Output_27;
                    state_6.__p_MqJ3crxuTBFO5TmVGn8XFR = State_Output_29;
                    state_6.__p_OXas1f5psD3NwKiXYAtZBG = State_Output_31;
                    state_6.__slot_Ptti416h9iYMze7XyL24kA = Output_30;
                    state_6.__p_OSdHq9wfPbdMh24wXmVUJZ = State_Output_34;
                    state_6.__p_HmLxjhhea0JQKMK6qScCkA = Output_36;
                }

                outputs_4 = n2.ValueTuple.Create(Output_33);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_37 = outputs_4.Item1;
            Domain_Out = __auto_37;
            n46.DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW that_38 = this;
            if (this.__GetContext__().IsImmutable)
                that_38 = manager_2 != this.__cache_Dto5uZzfFQ1QFwkdZbPoEf ? new DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW(this)
                {__cache_Dto5uZzfFQ1QFwkdZbPoEf = manager_2} : that_38;
            else
            {
                this.__cache_Dto5uZzfFQ1QFwkdZbPoEf = manager_2;
            }

            return that_38;
        }

        public n46.DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n46.DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW that_0 = this;
            this.__cache_Dto5uZzfFQ1QFwkdZbPoEf = null;
            return that_0;
        }

        public n46.DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW __CreateDefault__()
        {
            n46.DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW that_0 = this;
            this.__cache_Dto5uZzfFQ1QFwkdZbPoEf = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_Dto5uZzfFQ1QFwkdZbPoEf);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 349434U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Dto5uZzfFQ1QFwkdZbPoEf", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<n22.Matrix>, bool>, n2.ValueTuple<n5.GpuValue<n22.Vector3>>> __cache_Dto5uZzfFQ1QFwkdZbPoEf = null;
        [n1.ElementAttribute(TracingId = 349621U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "KHGKCvcylUFQaakPaAQnIA", Name = "__slot_KHGKCvcylUFQaakPaAQnIA")]
        public static string __slot_KHGKCvcylUFQaakPaAQnIA = "DomainTransform3D";
        static DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW()
        {
        }

        public DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW(DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW other): base(other)
        {
            this.__cache_Dto5uZzfFQ1QFwkdZbPoEf = other.__cache_Dto5uZzfFQ1QFwkdZbPoEf;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Dto5uZzfFQ1QFwkdZbPoEf", in __cache_Dto5uZzfFQ1QFwkdZbPoEf));
        }

        internal DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<n22.Matrix>, bool>, n2.ValueTuple<n5.GpuValue<n22.Vector3>>> __cache_Dto5uZzfFQ1QFwkdZbPoEf)
        {
            n46.DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Dto5uZzfFQ1QFwkdZbPoEf != this.__cache_Dto5uZzfFQ1QFwkdZbPoEf ? new DomainTransform_QXIcYJlYSKqPVu3OkQ9YeW(this)
                {__cache_Dto5uZzfFQ1QFwkdZbPoEf = __cache_Dto5uZzfFQ1QFwkdZbPoEf} : that_0;
            else
            {
                this.__cache_Dto5uZzfFQ1QFwkdZbPoEf = __cache_Dto5uZzfFQ1QFwkdZbPoEf;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "H2LGW9Xt3jGMMWq0R87Wev", Name = "__H2LGW9Xt3jGMMWq0R87Wev")]
        [n2.SerializableAttribute]
        public class __H2LGW9Xt3jGMMWq0R87Wev : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_NBIoIq6BdCEPR9N1JfTtct);
                n1.CompilationHelper.SafeDispose(this.__p_OXas1f5psD3NwKiXYAtZBG);
                n1.CompilationHelper.SafeDispose(this.__p_OSdHq9wfPbdMh24wXmVUJZ);
                n1.CompilationHelper.SafeDispose(this.__p_MqJ3crxuTBFO5TmVGn8XFR);
                n1.CompilationHelper.SafeDispose(this.__p_JBafjic6173PRwDX3QVadT);
                n1.CompilationHelper.SafeDispose(this.__p_HmLxjhhea0JQKMK6qScCkA);
                return;
            }

            [n1.ElementAttribute(TracingId = 349481U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "NBIoIq6BdCEPR9N1JfTtct", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_NBIoIq6BdCEPR9N1JfTtct;
            [n1.ElementAttribute(TracingId = 349495U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "OXas1f5psD3NwKiXYAtZBG", Name = "Mul", IsManaged = true, IsAutoGenerated = true)]
            public n20.Mul_B0P7ghpqXJiLy15iE7sIid<n22.Vector4, n22.Matrix, n22.Vector4> __p_OXas1f5psD3NwKiXYAtZBG;
            [n1.ElementAttribute(TracingId = 349511U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "OSdHq9wfPbdMh24wXmVUJZ", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
            public n40.xyz_T2WwCF9xAltPhlUuLjVDje __p_OSdHq9wfPbdMh24wXmVUJZ;
            [n1.ElementAttribute(TracingId = 349565U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "MqJ3crxuTBFO5TmVGn8XFR", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n41.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_MqJ3crxuTBFO5TmVGn8XFR;
            [n1.ElementAttribute(TracingId = 349593U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "JBafjic6173PRwDX3QVadT", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_JBafjic6173PRwDX3QVadT;
            [n1.ElementAttribute(TracingId = 349609U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "HmLxjhhea0JQKMK6qScCkA", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_HmLxjhhea0JQKMK6qScCkA;
            [n1.ElementAttribute(TracingId = 349470U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "EOmCjvkgMpLPCZoq5TnoWj", Name = "__slot_EOmCjvkgMpLPCZoq5TnoWj")]
            public n5.GpuValue<n22.Vector3> __slot_EOmCjvkgMpLPCZoq5TnoWj;
            [n1.ElementAttribute(TracingId = 349523U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "IOickkv7MGNN8lqec4GexV", Name = "__slot_IOickkv7MGNN8lqec4GexV")]
            public bool __slot_IOickkv7MGNN8lqec4GexV;
            [n1.ElementAttribute(TracingId = 349582U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Ptti416h9iYMze7XyL24kA", Name = "__slot_Ptti416h9iYMze7XyL24kA")]
            public n5.GpuValue<n22.Vector4> __slot_Ptti416h9iYMze7XyL24kA;
            public __H2LGW9Xt3jGMMWq0R87Wev(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __H2LGW9Xt3jGMMWq0R87Wev(__H2LGW9Xt3jGMMWq0R87Wev other): base(other)
            {
                this.__p_NBIoIq6BdCEPR9N1JfTtct = other.__p_NBIoIq6BdCEPR9N1JfTtct;
                this.__p_OXas1f5psD3NwKiXYAtZBG = other.__p_OXas1f5psD3NwKiXYAtZBG;
                this.__p_OSdHq9wfPbdMh24wXmVUJZ = other.__p_OSdHq9wfPbdMh24wXmVUJZ;
                this.__p_MqJ3crxuTBFO5TmVGn8XFR = other.__p_MqJ3crxuTBFO5TmVGn8XFR;
                this.__p_JBafjic6173PRwDX3QVadT = other.__p_JBafjic6173PRwDX3QVadT;
                this.__p_HmLxjhhea0JQKMK6qScCkA = other.__p_HmLxjhhea0JQKMK6qScCkA;
                this.__slot_EOmCjvkgMpLPCZoq5TnoWj = other.__slot_EOmCjvkgMpLPCZoq5TnoWj;
                this.__slot_IOickkv7MGNN8lqec4GexV = other.__slot_IOickkv7MGNN8lqec4GexV;
                this.__slot_Ptti416h9iYMze7XyL24kA = other.__slot_Ptti416h9iYMze7XyL24kA;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NBIoIq6BdCEPR9N1JfTtct", in __p_NBIoIq6BdCEPR9N1JfTtct), n1.CompilationHelper.GetValueOrExisting(values, "__p_OXas1f5psD3NwKiXYAtZBG", in __p_OXas1f5psD3NwKiXYAtZBG), n1.CompilationHelper.GetValueOrExisting(values, "__p_OSdHq9wfPbdMh24wXmVUJZ", in __p_OSdHq9wfPbdMh24wXmVUJZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_MqJ3crxuTBFO5TmVGn8XFR", in __p_MqJ3crxuTBFO5TmVGn8XFR), n1.CompilationHelper.GetValueOrExisting(values, "__p_JBafjic6173PRwDX3QVadT", in __p_JBafjic6173PRwDX3QVadT), n1.CompilationHelper.GetValueOrExisting(values, "__p_HmLxjhhea0JQKMK6qScCkA", in __p_HmLxjhhea0JQKMK6qScCkA), n1.CompilationHelper.GetValueOrExisting(values, "__slot_EOmCjvkgMpLPCZoq5TnoWj", in __slot_EOmCjvkgMpLPCZoq5TnoWj), n1.CompilationHelper.GetValueOrExisting(values, "__slot_IOickkv7MGNN8lqec4GexV", in __slot_IOickkv7MGNN8lqec4GexV), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Ptti416h9iYMze7XyL24kA", in __slot_Ptti416h9iYMze7XyL24kA));
            }

            internal __H2LGW9Xt3jGMMWq0R87Wev __WITH__(n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_NBIoIq6BdCEPR9N1JfTtct, n20.Mul_B0P7ghpqXJiLy15iE7sIid<n22.Vector4, n22.Matrix, n22.Vector4> __p_OXas1f5psD3NwKiXYAtZBG, n40.xyz_T2WwCF9xAltPhlUuLjVDje __p_OSdHq9wfPbdMh24wXmVUJZ, n41.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_MqJ3crxuTBFO5TmVGn8XFR, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_JBafjic6173PRwDX3QVadT, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_HmLxjhhea0JQKMK6qScCkA, n5.GpuValue<n22.Vector3> __slot_EOmCjvkgMpLPCZoq5TnoWj, bool __slot_IOickkv7MGNN8lqec4GexV, n5.GpuValue<n22.Vector4> __slot_Ptti416h9iYMze7XyL24kA)
            {
                __H2LGW9Xt3jGMMWq0R87Wev that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_NBIoIq6BdCEPR9N1JfTtct != this.__p_NBIoIq6BdCEPR9N1JfTtct || __p_OXas1f5psD3NwKiXYAtZBG != this.__p_OXas1f5psD3NwKiXYAtZBG || __p_OSdHq9wfPbdMh24wXmVUJZ != this.__p_OSdHq9wfPbdMh24wXmVUJZ || __p_MqJ3crxuTBFO5TmVGn8XFR != this.__p_MqJ3crxuTBFO5TmVGn8XFR || __p_JBafjic6173PRwDX3QVadT != this.__p_JBafjic6173PRwDX3QVadT || __p_HmLxjhhea0JQKMK6qScCkA != this.__p_HmLxjhhea0JQKMK6qScCkA || __slot_EOmCjvkgMpLPCZoq5TnoWj != this.__slot_EOmCjvkgMpLPCZoq5TnoWj || __slot_IOickkv7MGNN8lqec4GexV != this.__slot_IOickkv7MGNN8lqec4GexV || __slot_Ptti416h9iYMze7XyL24kA != this.__slot_Ptti416h9iYMze7XyL24kA ? new __H2LGW9Xt3jGMMWq0R87Wev(this)
                    {__p_NBIoIq6BdCEPR9N1JfTtct = __p_NBIoIq6BdCEPR9N1JfTtct, __p_OXas1f5psD3NwKiXYAtZBG = __p_OXas1f5psD3NwKiXYAtZBG, __p_OSdHq9wfPbdMh24wXmVUJZ = __p_OSdHq9wfPbdMh24wXmVUJZ, __p_MqJ3crxuTBFO5TmVGn8XFR = __p_MqJ3crxuTBFO5TmVGn8XFR, __p_JBafjic6173PRwDX3QVadT = __p_JBafjic6173PRwDX3QVadT, __p_HmLxjhhea0JQKMK6qScCkA = __p_HmLxjhhea0JQKMK6qScCkA, __slot_EOmCjvkgMpLPCZoq5TnoWj = __slot_EOmCjvkgMpLPCZoq5TnoWj, __slot_IOickkv7MGNN8lqec4GexV = __slot_IOickkv7MGNN8lqec4GexV, __slot_Ptti416h9iYMze7XyL24kA = __slot_Ptti416h9iYMze7XyL24kA} : that_0;
                else
                {
                    this.__p_NBIoIq6BdCEPR9N1JfTtct = __p_NBIoIq6BdCEPR9N1JfTtct;
                    this.__p_OXas1f5psD3NwKiXYAtZBG = __p_OXas1f5psD3NwKiXYAtZBG;
                    this.__p_OSdHq9wfPbdMh24wXmVUJZ = __p_OSdHq9wfPbdMh24wXmVUJZ;
                    this.__p_MqJ3crxuTBFO5TmVGn8XFR = __p_MqJ3crxuTBFO5TmVGn8XFR;
                    this.__p_JBafjic6173PRwDX3QVadT = __p_JBafjic6173PRwDX3QVadT;
                    this.__p_HmLxjhhea0JQKMK6qScCkA = __p_HmLxjhhea0JQKMK6qScCkA;
                    this.__slot_EOmCjvkgMpLPCZoq5TnoWj = __slot_EOmCjvkgMpLPCZoq5TnoWj;
                    this.__slot_IOickkv7MGNN8lqec4GexV = __slot_IOickkv7MGNN8lqec4GexV;
                    this.__slot_Ptti416h9iYMze7XyL24kA = __slot_Ptti416h9iYMze7XyL24kA;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 349775U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "PHOQFis3nTDNrTa5NfGFxd", Name = "DomainTwist_PHOQFis3nTDNrTa5NfGFxd")]
    [n2.SerializableAttribute]
    public class DomainTwist_PHOQFis3nTDNrTa5NfGFxd : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n46.DomainTwist_PHOQFis3nTDNrTa5NfGFxd Create(n1.NodeContext Node_Context)
        {
            var instance = new DomainTwist_PHOQFis3nTDNrTa5NfGFxd(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n46.DomainTwist_PHOQFis3nTDNrTa5NfGFxd CreateDefault()
        {
            var instance = new DomainTwist_PHOQFis3nTDNrTa5NfGFxd(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n46.DomainTwist_PHOQFis3nTDNrTa5NfGFxd Update(n5.GpuValue<n22.Vector3> TDomain_In, n5.GpuValue<float> Strength_In, out n5.GpuValue<n22.Vector3> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_FRGP0w3SdnBQUq8KmHnLYn;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<n22.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n22.Vector3>)));
            }

            var inputs_3 = (TDomain_In, Strength_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__GG0N5oSwuZaQP2FVxGAJTY>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __GG0N5oSwuZaQP2FVxGAJTY(__GetContext__(), n1.VLObject.NewIdentity())
                    {__slot_EiBphNeijwlMMg5YG00IxU = default(n5.GpuValue<n22.Vector3>), __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt = n17._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    string __pad_IraRwRcWhWCLDgtsx5s4RD_7 = __slot_IraRwRcWhWCLDgtsx5s4RD;
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "J2PCa6pKzctMXqPrAfqQFF", 349835U);
                    var Output_9 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3>.Create(Node_Context: Node_Context_8);
                    state_6.__p_J2PCa6pKzctMXqPrAfqQFF = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "LFC38MmCKYEMk92ZwzuI64", 349850U);
                    var Output_11 = n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float>.Create(Node_Context: Node_Context_10);
                    state_6.__p_LFC38MmCKYEMk92ZwzuI64 = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "BlVe8iek7YQPBCwAUYyrjt", 349882U);
                    var Output_13 = n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector3>.Create(Node_Context: Node_Context_12);
                    state_6.__p_BlVe8iek7YQPBCwAUYyrjt = Output_13;
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Pyl8z8g11LqN86OIJ0A082", 349913U);
                    var Output_15 = n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v.Create(Node_Context: Node_Context_14);
                    state_6.__p_Pyl8z8g11LqN86OIJ0A082 = Output_15;
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "PLFCTM0rgjsQHlK0hnK85A", 349928U);
                    var Output_17 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_16, ID_In: __pad_IraRwRcWhWCLDgtsx5s4RD_7);
                    state_6.__p_PLFCTM0rgjsQHlK0hnK85A = Output_17;
                }

                float __pad_SJcDfyXVetiNdxjAGMJ3EX_18 = __slot_SJcDfyXVetiNdxjAGMJ3EX;
                string __pad_Dn0AZfxoiS4NnwJaXI9Mci_19 = __slot_Dn0AZfxoiS4NnwJaXI9Mci;
                int Id_20 = 0;
                var State_Output_22 = state_6.__p_J2PCa6pKzctMXqPrAfqQFF.Update(The_Override_In: TDomain_In, Id_In: Id_20, Output_Out: out n5.GpuValue<n22.Vector3> Output_21);
                n5.GpuValue<n22.Vector3> __pad_EiBphNeijwlMMg5YG00IxU_23 = Output_21;
                var State_Output_25 = state_6.__p_LFC38MmCKYEMk92ZwzuI64.Update(GpuValue_In: Strength_In, The_Value_In: __pad_SJcDfyXVetiNdxjAGMJ3EX_18, Output_Out: out n5.GpuValue<float> Output_24);
                var Output_27 = state_6.__p_Pyl8z8g11LqN86OIJ0A082.Update(Singleton_Out: out string Singleton_26);
                n5.GpuValue<n22.Vector3> Default_28 = default(n5.GpuValue<n22.Vector3>);
                bool Is_Groupable_29 = false;
                n8.IEnumerable<n5.InputModifier> The_Modifiers_30 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_31 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt, 2);
                builder_31.Add(__pad_EiBphNeijwlMMg5YG00IxU_23);
                builder_31.Add(Output_24);
                var __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt_32 = builder_31.Commit();
                var State_Output_35 = state_6.__p_BlVe8iek7YQPBCwAUYyrjt.Update(Arguments_In: __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt_32, Function_Name_In: __pad_Dn0AZfxoiS4NnwJaXI9Mci_19, Default_In: Default_28, Mixins_In: Singleton_26, Is_Groupable_In: Is_Groupable_29, The_Modifiers_In: The_Modifiers_30, Output_Out: out n5.GpuValue<n22.Vector3> Output_33, Additional_Outputs_Out: out n11.Spread<n5.AbstractGpuValue> Additional_Outputs_34);
                bool Update_36 = true;
                var Output_37 = state_6.__p_PLFCTM0rgjsQHlK0hnK85A;
                if (Update_36)
                {
                    Output_37 = state_6.__p_PLFCTM0rgjsQHlK0hnK85A.Update(Input_In: Output_33);
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_22 != state_6.__p_J2PCa6pKzctMXqPrAfqQFF || Output_21 != state_6.__slot_EiBphNeijwlMMg5YG00IxU || State_Output_25 != state_6.__p_LFC38MmCKYEMk92ZwzuI64 || Output_27 != state_6.__p_Pyl8z8g11LqN86OIJ0A082 || __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt_32 != state_6.__pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt || State_Output_35 != state_6.__p_BlVe8iek7YQPBCwAUYyrjt || Output_37 != state_6.__p_PLFCTM0rgjsQHlK0hnK85A ? new __GG0N5oSwuZaQP2FVxGAJTY(state_6)
                    {__p_J2PCa6pKzctMXqPrAfqQFF = State_Output_22, __slot_EiBphNeijwlMMg5YG00IxU = Output_21, __p_LFC38MmCKYEMk92ZwzuI64 = State_Output_25, __p_Pyl8z8g11LqN86OIJ0A082 = Output_27, __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt = __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt_32, __p_BlVe8iek7YQPBCwAUYyrjt = State_Output_35, __p_PLFCTM0rgjsQHlK0hnK85A = Output_37} : state_6;
                else
                {
                    state_6.__p_J2PCa6pKzctMXqPrAfqQFF = State_Output_22;
                    state_6.__slot_EiBphNeijwlMMg5YG00IxU = Output_21;
                    state_6.__p_LFC38MmCKYEMk92ZwzuI64 = State_Output_25;
                    state_6.__p_Pyl8z8g11LqN86OIJ0A082 = Output_27;
                    state_6.__pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt = __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt_32;
                    state_6.__p_BlVe8iek7YQPBCwAUYyrjt = State_Output_35;
                    state_6.__p_PLFCTM0rgjsQHlK0hnK85A = Output_37;
                }

                outputs_4 = n2.ValueTuple.Create(Output_33);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_38 = outputs_4.Item1;
            Output_Out = __auto_38;
            n46.DomainTwist_PHOQFis3nTDNrTa5NfGFxd that_39 = this;
            if (this.__GetContext__().IsImmutable)
                that_39 = manager_2 != this.__cache_FRGP0w3SdnBQUq8KmHnLYn ? new DomainTwist_PHOQFis3nTDNrTa5NfGFxd(this)
                {__cache_FRGP0w3SdnBQUq8KmHnLYn = manager_2} : that_39;
            else
            {
                this.__cache_FRGP0w3SdnBQUq8KmHnLYn = manager_2;
            }

            return that_39;
        }

        public n46.DomainTwist_PHOQFis3nTDNrTa5NfGFxd __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n46.DomainTwist_PHOQFis3nTDNrTa5NfGFxd that_0 = this;
            this.__cache_FRGP0w3SdnBQUq8KmHnLYn = null;
            return that_0;
        }

        public n46.DomainTwist_PHOQFis3nTDNrTa5NfGFxd __CreateDefault__()
        {
            n46.DomainTwist_PHOQFis3nTDNrTa5NfGFxd that_0 = this;
            this.__cache_FRGP0w3SdnBQUq8KmHnLYn = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_FRGP0w3SdnBQUq8KmHnLYn);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 349782U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "FRGP0w3SdnBQUq8KmHnLYn", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<n22.Vector3>>> __cache_FRGP0w3SdnBQUq8KmHnLYn = null;
        [n1.ElementAttribute(TracingId = 349939U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "IraRwRcWhWCLDgtsx5s4RD", Name = "__slot_IraRwRcWhWCLDgtsx5s4RD")]
        public static string __slot_IraRwRcWhWCLDgtsx5s4RD = "DomainTwist3D";
        [n1.ElementAttribute(TracingId = 349874U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "SJcDfyXVetiNdxjAGMJ3EX", Name = "__slot_SJcDfyXVetiNdxjAGMJ3EX")]
        public static float __slot_SJcDfyXVetiNdxjAGMJ3EX = 1F;
        [n1.ElementAttribute(TracingId = 349920U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Dn0AZfxoiS4NnwJaXI9Mci", Name = "__slot_Dn0AZfxoiS4NnwJaXI9Mci")]
        public static string __slot_Dn0AZfxoiS4NnwJaXI9Mci = "pTwist";
        static DomainTwist_PHOQFis3nTDNrTa5NfGFxd()
        {
        }

        public DomainTwist_PHOQFis3nTDNrTa5NfGFxd(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DomainTwist_PHOQFis3nTDNrTa5NfGFxd(DomainTwist_PHOQFis3nTDNrTa5NfGFxd other): base(other)
        {
            this.__cache_FRGP0w3SdnBQUq8KmHnLYn = other.__cache_FRGP0w3SdnBQUq8KmHnLYn;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_FRGP0w3SdnBQUq8KmHnLYn", in __cache_FRGP0w3SdnBQUq8KmHnLYn));
        }

        internal DomainTwist_PHOQFis3nTDNrTa5NfGFxd __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<n22.Vector3>>> __cache_FRGP0w3SdnBQUq8KmHnLYn)
        {
            n46.DomainTwist_PHOQFis3nTDNrTa5NfGFxd that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_FRGP0w3SdnBQUq8KmHnLYn != this.__cache_FRGP0w3SdnBQUq8KmHnLYn ? new DomainTwist_PHOQFis3nTDNrTa5NfGFxd(this)
                {__cache_FRGP0w3SdnBQUq8KmHnLYn = __cache_FRGP0w3SdnBQUq8KmHnLYn} : that_0;
            else
            {
                this.__cache_FRGP0w3SdnBQUq8KmHnLYn = __cache_FRGP0w3SdnBQUq8KmHnLYn;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "GG0N5oSwuZaQP2FVxGAJTY", Name = "__GG0N5oSwuZaQP2FVxGAJTY")]
        [n2.SerializableAttribute]
        public class __GG0N5oSwuZaQP2FVxGAJTY : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_J2PCa6pKzctMXqPrAfqQFF);
                n1.CompilationHelper.SafeDispose(this.__p_LFC38MmCKYEMk92ZwzuI64);
                n1.CompilationHelper.SafeDispose(this.__p_BlVe8iek7YQPBCwAUYyrjt);
                n1.CompilationHelper.SafeDispose(this.__p_Pyl8z8g11LqN86OIJ0A082);
                n1.CompilationHelper.SafeDispose(this.__p_PLFCTM0rgjsQHlK0hnK85A);
                return;
            }

            [n1.ElementAttribute(TracingId = 349835U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "J2PCa6pKzctMXqPrAfqQFF", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_J2PCa6pKzctMXqPrAfqQFF;
            [n1.ElementAttribute(TracingId = 349850U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "LFC38MmCKYEMk92ZwzuI64", Name = "CheckDefault", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_LFC38MmCKYEMk92ZwzuI64;
            [n1.ElementAttribute(TracingId = 349882U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "BlVe8iek7YQPBCwAUYyrjt", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector3> __p_BlVe8iek7YQPBCwAUYyrjt;
            [n1.ElementAttribute(TracingId = 349913U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Pyl8z8g11LqN86OIJ0A082", Name = "FuseCoreDomain (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_Pyl8z8g11LqN86OIJ0A082;
            [n1.ElementAttribute(TracingId = 349928U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "PLFCTM0rgjsQHlK0hnK85A", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_PLFCTM0rgjsQHlK0hnK85A;
            [n1.ElementAttribute(TracingId = 349822U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "EiBphNeijwlMMg5YG00IxU", Name = "__slot_EiBphNeijwlMMg5YG00IxU")]
            public n5.GpuValue<n22.Vector3> __slot_EiBphNeijwlMMg5YG00IxU;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt = default(n11.Spread<n5.AbstractGpuValue>);
            public __GG0N5oSwuZaQP2FVxGAJTY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __GG0N5oSwuZaQP2FVxGAJTY(__GG0N5oSwuZaQP2FVxGAJTY other): base(other)
            {
                this.__p_J2PCa6pKzctMXqPrAfqQFF = other.__p_J2PCa6pKzctMXqPrAfqQFF;
                this.__p_LFC38MmCKYEMk92ZwzuI64 = other.__p_LFC38MmCKYEMk92ZwzuI64;
                this.__p_BlVe8iek7YQPBCwAUYyrjt = other.__p_BlVe8iek7YQPBCwAUYyrjt;
                this.__p_Pyl8z8g11LqN86OIJ0A082 = other.__p_Pyl8z8g11LqN86OIJ0A082;
                this.__p_PLFCTM0rgjsQHlK0hnK85A = other.__p_PLFCTM0rgjsQHlK0hnK85A;
                this.__slot_EiBphNeijwlMMg5YG00IxU = other.__slot_EiBphNeijwlMMg5YG00IxU;
                this.__pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt = other.__pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_J2PCa6pKzctMXqPrAfqQFF", in __p_J2PCa6pKzctMXqPrAfqQFF), n1.CompilationHelper.GetValueOrExisting(values, "__p_LFC38MmCKYEMk92ZwzuI64", in __p_LFC38MmCKYEMk92ZwzuI64), n1.CompilationHelper.GetValueOrExisting(values, "__p_BlVe8iek7YQPBCwAUYyrjt", in __p_BlVe8iek7YQPBCwAUYyrjt), n1.CompilationHelper.GetValueOrExisting(values, "__p_Pyl8z8g11LqN86OIJ0A082", in __p_Pyl8z8g11LqN86OIJ0A082), n1.CompilationHelper.GetValueOrExisting(values, "__p_PLFCTM0rgjsQHlK0hnK85A", in __p_PLFCTM0rgjsQHlK0hnK85A), n1.CompilationHelper.GetValueOrExisting(values, "__slot_EiBphNeijwlMMg5YG00IxU", in __slot_EiBphNeijwlMMg5YG00IxU), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt", in __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt));
            }

            internal __GG0N5oSwuZaQP2FVxGAJTY __WITH__(n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_J2PCa6pKzctMXqPrAfqQFF, n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_LFC38MmCKYEMk92ZwzuI64, n9.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n22.Vector3> __p_BlVe8iek7YQPBCwAUYyrjt, n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_Pyl8z8g11LqN86OIJ0A082, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_PLFCTM0rgjsQHlK0hnK85A, n5.GpuValue<n22.Vector3> __slot_EiBphNeijwlMMg5YG00IxU, n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt)
            {
                __GG0N5oSwuZaQP2FVxGAJTY that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_J2PCa6pKzctMXqPrAfqQFF != this.__p_J2PCa6pKzctMXqPrAfqQFF || __p_LFC38MmCKYEMk92ZwzuI64 != this.__p_LFC38MmCKYEMk92ZwzuI64 || __p_BlVe8iek7YQPBCwAUYyrjt != this.__p_BlVe8iek7YQPBCwAUYyrjt || __p_Pyl8z8g11LqN86OIJ0A082 != this.__p_Pyl8z8g11LqN86OIJ0A082 || __p_PLFCTM0rgjsQHlK0hnK85A != this.__p_PLFCTM0rgjsQHlK0hnK85A || __slot_EiBphNeijwlMMg5YG00IxU != this.__slot_EiBphNeijwlMMg5YG00IxU || __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt != this.__pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt ? new __GG0N5oSwuZaQP2FVxGAJTY(this)
                    {__p_J2PCa6pKzctMXqPrAfqQFF = __p_J2PCa6pKzctMXqPrAfqQFF, __p_LFC38MmCKYEMk92ZwzuI64 = __p_LFC38MmCKYEMk92ZwzuI64, __p_BlVe8iek7YQPBCwAUYyrjt = __p_BlVe8iek7YQPBCwAUYyrjt, __p_Pyl8z8g11LqN86OIJ0A082 = __p_Pyl8z8g11LqN86OIJ0A082, __p_PLFCTM0rgjsQHlK0hnK85A = __p_PLFCTM0rgjsQHlK0hnK85A, __slot_EiBphNeijwlMMg5YG00IxU = __slot_EiBphNeijwlMMg5YG00IxU, __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt = __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt} : that_0;
                else
                {
                    this.__p_J2PCa6pKzctMXqPrAfqQFF = __p_J2PCa6pKzctMXqPrAfqQFF;
                    this.__p_LFC38MmCKYEMk92ZwzuI64 = __p_LFC38MmCKYEMk92ZwzuI64;
                    this.__p_BlVe8iek7YQPBCwAUYyrjt = __p_BlVe8iek7YQPBCwAUYyrjt;
                    this.__p_Pyl8z8g11LqN86OIJ0A082 = __p_Pyl8z8g11LqN86OIJ0A082;
                    this.__p_PLFCTM0rgjsQHlK0hnK85A = __p_PLFCTM0rgjsQHlK0hnK85A;
                    this.__slot_EiBphNeijwlMMg5YG00IxU = __slot_EiBphNeijwlMMg5YG00IxU;
                    this.__pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt = __pin_group_Arguments_In_BlVe8iek7YQPBCwAUYyrjt;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 350051U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "QutS9qyjAyiLvnKNz9Q7Jl", Name = "DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl")]
    [n2.SerializableAttribute]
    public class DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n46.DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl Create(n1.NodeContext Node_Context)
        {
            var instance = new DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n46.DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl CreateDefault()
        {
            var instance = new DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n46.DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl Update(n5.GpuValue<n22.Vector3> TDomain_In, [n4.SerializedDefaultValueAttribute("1, 1, 1", false)] n5.GpuValue<n22.Vector3> Size_In, n34.DomainRepeat3D Op_In, out n5.GpuValue<n22.Vector3> Output_Out, out n5.GpuValue<n22.Vector3> Cell_Out)
        {
            string __pad_VZc6zuZlquZMTjvoA9CbG1_0 = __slot_VZc6zuZlquZMTjvoA9CbG1;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_DXq6xIaZwWWQdz0fGFpI1R;
            if (manager_3 is null)
            {
                manager_3 = new n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, string, n5.GpuValue<n22.Vector3>, n34.DomainRepeat3D>, n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<n22.Vector3>>>((default(n5.GpuValue<n22.Vector3>), default(n5.GpuValue<n22.Vector3>)));
            }

            var inputs_4 = (TDomain_In, __pad_VZc6zuZlquZMTjvoA9CbG1_0, Size_In, Op_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__KJqT1kY103OLazfwxC8c2a>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __KJqT1kY103OLazfwxC8c2a(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs = n17._Operations_.CreateDefault<string>(), __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5 = n17._Operations_.CreateDefault<n5.InputModifier>(), __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ = n17._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "B2hAR6Jp06hP65hQ5WzqsQ", 350101U);
                    var Output_9 = n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<n22.Vector3, n11.Spread<n5.InputModifier>>.Create(Node_Context: Node_Context_8);
                    state_7.__p_B2hAR6Jp06hP65hQ5WzqsQ = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "SPNePtTSzf6NNkUkU3E1SG", 350164U);
                    var Output_11 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3>.Create(Node_Context: Node_Context_10);
                    state_7.__p_SPNePtTSzf6NNkUkU3E1SG = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "GTat4svMi2bNTWqbEEsc0E", 350332U);
                    var Output_13 = n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v.Create(Node_Context: Node_Context_12);
                    state_7.__p_GTat4svMi2bNTWqbEEsc0E = Output_13;
                    n50._Operations_.DomainRepeat3DID(Output_Out: out string Output_14);
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Dw1FVLE6u86MyEfd7o04Rp", 350383U);
                    var Output_16 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_15, ID_In: Output_14);
                    state_7.__p_Dw1FVLE6u86MyEfd7o04Rp = Output_16;
                    n50._Operations_.DomainRepeatCell3DID(Output_Out: out string Output_17);
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Oir28lyttnNO4gpx6BfHbW", 350397U);
                    var Output_19 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_18, ID_In: Output_17);
                    state_7.__p_Oir28lyttnNO4gpx6BfHbW = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "G2WHVT2X6eMPIa8imuWD6x", 350431U);
                    var Output_21 = n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n22.Vector3>.Create(Node_Context: Node_Context_20);
                    state_7.__p_G2WHVT2X6eMPIa8imuWD6x = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "CVf5AnzHUNzMWdnRU7jcgE", 350451U);
                    var Output_23 = n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<n22.Vector3>.Create(Node_Context: Node_Context_22);
                    state_7.__p_CVf5AnzHUNzMWdnRU7jcgE = Output_23;
                }

                string __pad_ODPVMPvqgfCNoRFPoRUnoA_24 = __slot_ODPVMPvqgfCNoRFPoRUnoA;
                n22.Vector3 __pad_PKYzmLSsPoALLIdKJ2SWOk_25 = __slot_PKYzmLSsPoALLIdKJ2SWOk;
                n22.Vector3 __pad_Llg5Ni9bTWtOqOKq9W3sqH_26 = __slot_Llg5Ni9bTWtOqOKq9W3sqH;
                n5.InputModifier __pad_GB5mn5DD7fgQKe2fmcGnG8_27 = __slot_GB5mn5DD7fgQKe2fmcGnG8;
                n5.InputModifier __pad_USAA0chTGJHPuoRu2sakoq_28 = __slot_USAA0chTGJHPuoRu2sakoq;
                n5.InputModifier __pad_KAojoB1C0HpM9I93CeQ3tI_29 = __slot_KAojoB1C0HpM9I93CeQ3tI;
                int Id_30 = 0;
                var State_Output_32 = state_7.__p_SPNePtTSzf6NNkUkU3E1SG.Update(The_Override_In: TDomain_In, Id_In: Id_30, Output_Out: out n5.GpuValue<n22.Vector3> Output_31);
                var State_Output_34 = state_7.__p_CVf5AnzHUNzMWdnRU7jcgE.Update(GpuValue_In: Size_In, The_Value_In: __pad_Llg5Ni9bTWtOqOKq9W3sqH_26, Output_Out: out n5.GpuValue<n22.Vector3> Output_33);
                var Output_36 = state_7.__p_G2WHVT2X6eMPIa8imuWD6x.Update(Value_In: __pad_PKYzmLSsPoALLIdKJ2SWOk_25, GpuValue_Out: out n5.GpuValue<n22.Vector3> GpuValue_35);
                var Output_38 = state_7.__p_GTat4svMi2bNTWqbEEsc0E.Update(Singleton_Out: out string Singleton_37);
                var builder_39 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs, 1);
                builder_39.Add(Singleton_37);
                var __pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs_40 = builder_39.Commit();
                n17._Operations_.FromValue<string>(Input_In: __pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs_40, Result_Out: out n11.Spread<string> Result_41);
                n8.IEnumerable<string> Mixins_42 = (n8.IEnumerable<string>)Result_41;
                int Operation_43 = (int)Op_In;
                n50._Operations_.TemplateValues(Operation_In: Operation_43, Output_Out: out n15.ImmutableDictionary<string, string> Output_44);
                var builder_45 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5, 3);
                builder_45.Add(__pad_GB5mn5DD7fgQKe2fmcGnG8_27);
                builder_45.Add(__pad_USAA0chTGJHPuoRu2sakoq_28);
                builder_45.Add(__pad_KAojoB1C0HpM9I93CeQ3tI_29);
                var __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5_46 = builder_45.Commit();
                n17._Operations_.Cons<n5.InputModifier>(Input_In: __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5_46, Result_Out: out n11.Spread<n5.InputModifier> Result_47);
                n5.GpuValue<n22.Vector3> Default_Result_48 = default(n5.GpuValue<n22.Vector3>);
                n11.Spread<n5.IFunctionInvokeNode> Functions_49 = n17._Operations_.CreateDefault<n5.IFunctionInvokeNode>();
                bool Is_Groupable_50 = false;
                var builder_51 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ, 3);
                builder_51.Add(Output_31);
                builder_51.Add(Output_33);
                builder_51.Add(GpuValue_35);
                var __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ_52 = builder_51.Commit();
                var State_Output_55 = state_7.__p_B2hAR6Jp06hP65hQ5WzqsQ.Update(Arguments_In: __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ_52, Function_Name_In: __pad_ODPVMPvqgfCNoRFPoRUnoA_24, Code_Template_In: __pad_VZc6zuZlquZMTjvoA9CbG1_0, Default_Result_In: Default_Result_48, Functions_In: Functions_49, Mixins_In: Mixins_42, Template_Values_In: Output_44, Is_Groupable_In: Is_Groupable_50, The_Modifiers_In: Result_47, Output_Out: out n5.GpuValue<n22.Vector3> Output_53, AdditionalOutputs_Out: out n11.Spread<n5.AbstractGpuValue> AdditionalOutputs_54);
                var AdditionalOutputs_56 = (n5.AbstractGpuValue)AdditionalOutputs_54[0];
                bool Update_57 = true;
                var Output_58 = state_7.__p_Dw1FVLE6u86MyEfd7o04Rp;
                if (Update_57)
                {
                    Output_58 = state_7.__p_Dw1FVLE6u86MyEfd7o04Rp.Update(Input_In: Output_53);
                }

                n5.GpuValue<n22.Vector3> Default_59 = default(n5.GpuValue<n22.Vector3>);
                n36._Operations_.CastAs<n5.GpuValue<n22.Vector3>>(Input_In: AdditionalOutputs_56, Default_In: Default_59, Result_Out: out n5.GpuValue<n22.Vector3> Result_60, Success_Out: out bool Success_61);
                bool Update_62 = true;
                var Output_63 = state_7.__p_Oir28lyttnNO4gpx6BfHbW;
                if (Update_62)
                {
                    Output_63 = state_7.__p_Oir28lyttnNO4gpx6BfHbW.Update(Input_In: AdditionalOutputs_56);
                }

                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_32 != state_7.__p_SPNePtTSzf6NNkUkU3E1SG || State_Output_34 != state_7.__p_CVf5AnzHUNzMWdnRU7jcgE || Output_36 != state_7.__p_G2WHVT2X6eMPIa8imuWD6x || Output_38 != state_7.__p_GTat4svMi2bNTWqbEEsc0E || __pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs_40 != state_7.__pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs || __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5_46 != state_7.__pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5 || __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ_52 != state_7.__pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ || State_Output_55 != state_7.__p_B2hAR6Jp06hP65hQ5WzqsQ || Output_58 != state_7.__p_Dw1FVLE6u86MyEfd7o04Rp || Output_63 != state_7.__p_Oir28lyttnNO4gpx6BfHbW ? new __KJqT1kY103OLazfwxC8c2a(state_7)
                    {__p_SPNePtTSzf6NNkUkU3E1SG = State_Output_32, __p_CVf5AnzHUNzMWdnRU7jcgE = State_Output_34, __p_G2WHVT2X6eMPIa8imuWD6x = Output_36, __p_GTat4svMi2bNTWqbEEsc0E = Output_38, __pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs = __pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs_40, __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5 = __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5_46, __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ = __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ_52, __p_B2hAR6Jp06hP65hQ5WzqsQ = State_Output_55, __p_Dw1FVLE6u86MyEfd7o04Rp = Output_58, __p_Oir28lyttnNO4gpx6BfHbW = Output_63} : state_7;
                else
                {
                    state_7.__p_SPNePtTSzf6NNkUkU3E1SG = State_Output_32;
                    state_7.__p_CVf5AnzHUNzMWdnRU7jcgE = State_Output_34;
                    state_7.__p_G2WHVT2X6eMPIa8imuWD6x = Output_36;
                    state_7.__p_GTat4svMi2bNTWqbEEsc0E = Output_38;
                    state_7.__pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs = __pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs_40;
                    state_7.__pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5 = __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5_46;
                    state_7.__pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ = __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ_52;
                    state_7.__p_B2hAR6Jp06hP65hQ5WzqsQ = State_Output_55;
                    state_7.__p_Dw1FVLE6u86MyEfd7o04Rp = Output_58;
                    state_7.__p_Oir28lyttnNO4gpx6BfHbW = Output_63;
                }

                outputs_5 = (Output_53, Result_60);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var(__auto_64, __auto_65) = outputs_5;
            Output_Out = __auto_64;
            Cell_Out = __auto_65;
            n46.DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl that_66 = this;
            if (this.__GetContext__().IsImmutable)
                that_66 = manager_3 != this.__cache_DXq6xIaZwWWQdz0fGFpI1R ? new DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl(this)
                {__cache_DXq6xIaZwWWQdz0fGFpI1R = manager_3} : that_66;
            else
            {
                this.__cache_DXq6xIaZwWWQdz0fGFpI1R = manager_3;
            }

            return that_66;
        }

        public n46.DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n46.DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl that_0 = this;
            this.__cache_DXq6xIaZwWWQdz0fGFpI1R = null;
            return that_0;
        }

        public n46.DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl __CreateDefault__()
        {
            n46.DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl that_0 = this;
            this.__cache_DXq6xIaZwWWQdz0fGFpI1R = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_DXq6xIaZwWWQdz0fGFpI1R);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 350594U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "VZc6zuZlquZMTjvoA9CbG1", Name = "__slot_VZc6zuZlquZMTjvoA9CbG1")]
        public static string __slot_VZc6zuZlquZMTjvoA9CbG1 = "float3 ${signature}(float3 p, float3 size, out float3 cell) \r\n{\r\n\tcell = 0.;\r\n\tcell.${SWIZZLE} = ${OP}(p.${SWIZZLE}, size);\r\n\treturn p;\r\n}";
        [n1.ElementAttribute(TracingId = 350822U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "HtAUdPujkz9PYPCwFdTkcG", Name = "__slot_HtAUdPujkz9PYPCwFdTkcG")]
        public static string __slot_HtAUdPujkz9PYPCwFdTkcG = "Wrap X\r\nWrap Y\r\nWrap Z\r\nMirror X\r\nMirror Y\r\nMirror Z\r\nWrap XY\r\nWrap XZ\r\nWrap YZ\r\nMirror XY\r\nMirror XZ\r\nMirror YZ\r\nWrap XYZ\r\nPolar XY\r\nPolar XZ\r\nPolar YZ";
        [n1.ElementAttribute(TracingId = 350054U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "DXq6xIaZwWWQdz0fGFpI1R", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, string, n5.GpuValue<n22.Vector3>, n34.DomainRepeat3D>, n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<n22.Vector3>>> __cache_DXq6xIaZwWWQdz0fGFpI1R = null;
        [n1.ElementAttribute(TracingId = 350362U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "ODPVMPvqgfCNoRFPoRUnoA", Name = "__slot_ODPVMPvqgfCNoRFPoRUnoA")]
        public static string __slot_ODPVMPvqgfCNoRFPoRUnoA = "DomainRepeat3D";
        [n1.ElementAttribute(TracingId = 350374U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "PKYzmLSsPoALLIdKJ2SWOk", Name = "__slot_PKYzmLSsPoALLIdKJ2SWOk")]
        public static n22.Vector3 __slot_PKYzmLSsPoALLIdKJ2SWOk = n1.CompilationHelper.Deserialize<n22.Vector3>("0, 0, 0", false, "MzilLTk6yNROg5SWTCtzZM", "PKYzmLSsPoALLIdKJ2SWOk");
        [n1.ElementAttribute(TracingId = 350471U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Llg5Ni9bTWtOqOKq9W3sqH", Name = "__slot_Llg5Ni9bTWtOqOKq9W3sqH")]
        public static n22.Vector3 __slot_Llg5Ni9bTWtOqOKq9W3sqH = n1.CompilationHelper.Deserialize<n22.Vector3>("1, 1, 1", false, "MzilLTk6yNROg5SWTCtzZM", "Llg5Ni9bTWtOqOKq9W3sqH");
        [n1.ElementAttribute(TracingId = 350496U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "GB5mn5DD7fgQKe2fmcGnG8", Name = "__slot_GB5mn5DD7fgQKe2fmcGnG8")]
        public static n5.InputModifier __slot_GB5mn5DD7fgQKe2fmcGnG8 = n1.CompilationHelper.Deserialize<n5.InputModifier>("In", false, "MzilLTk6yNROg5SWTCtzZM", "GB5mn5DD7fgQKe2fmcGnG8");
        [n1.ElementAttribute(TracingId = 350499U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "USAA0chTGJHPuoRu2sakoq", Name = "__slot_USAA0chTGJHPuoRu2sakoq")]
        public static n5.InputModifier __slot_USAA0chTGJHPuoRu2sakoq = n1.CompilationHelper.Deserialize<n5.InputModifier>("In", false, "MzilLTk6yNROg5SWTCtzZM", "USAA0chTGJHPuoRu2sakoq");
        [n1.ElementAttribute(TracingId = 350502U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "KAojoB1C0HpM9I93CeQ3tI", Name = "__slot_KAojoB1C0HpM9I93CeQ3tI")]
        public static n5.InputModifier __slot_KAojoB1C0HpM9I93CeQ3tI = n1.CompilationHelper.Deserialize<n5.InputModifier>("Out", false, "MzilLTk6yNROg5SWTCtzZM", "KAojoB1C0HpM9I93CeQ3tI");
        static DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl()
        {
        }

        public DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl(DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl other): base(other)
        {
            this.__cache_DXq6xIaZwWWQdz0fGFpI1R = other.__cache_DXq6xIaZwWWQdz0fGFpI1R;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_DXq6xIaZwWWQdz0fGFpI1R", in __cache_DXq6xIaZwWWQdz0fGFpI1R));
        }

        internal DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl __WITH__(n7.Manager<n2.ValueTuple<n5.GpuValue<n22.Vector3>, string, n5.GpuValue<n22.Vector3>, n34.DomainRepeat3D>, n2.ValueTuple<n5.GpuValue<n22.Vector3>, n5.GpuValue<n22.Vector3>>> __cache_DXq6xIaZwWWQdz0fGFpI1R)
        {
            n46.DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_DXq6xIaZwWWQdz0fGFpI1R != this.__cache_DXq6xIaZwWWQdz0fGFpI1R ? new DomainRepeat_QutS9qyjAyiLvnKNz9Q7Jl(this)
                {__cache_DXq6xIaZwWWQdz0fGFpI1R = __cache_DXq6xIaZwWWQdz0fGFpI1R} : that_0;
            else
            {
                this.__cache_DXq6xIaZwWWQdz0fGFpI1R = __cache_DXq6xIaZwWWQdz0fGFpI1R;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "KJqT1kY103OLazfwxC8c2a", Name = "__KJqT1kY103OLazfwxC8c2a")]
        [n2.SerializableAttribute]
        public class __KJqT1kY103OLazfwxC8c2a : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_B2hAR6Jp06hP65hQ5WzqsQ);
                n1.CompilationHelper.SafeDispose(this.__p_SPNePtTSzf6NNkUkU3E1SG);
                n1.CompilationHelper.SafeDispose(this.__p_GTat4svMi2bNTWqbEEsc0E);
                n1.CompilationHelper.SafeDispose(this.__p_Dw1FVLE6u86MyEfd7o04Rp);
                n1.CompilationHelper.SafeDispose(this.__p_Oir28lyttnNO4gpx6BfHbW);
                n1.CompilationHelper.SafeDispose(this.__p_G2WHVT2X6eMPIa8imuWD6x);
                n1.CompilationHelper.SafeDispose(this.__p_CVf5AnzHUNzMWdnRU7jcgE);
                return;
            }

            [n1.ElementAttribute(TracingId = 350101U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "B2hAR6Jp06hP65hQ5WzqsQ", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<n22.Vector3, n11.Spread<n5.InputModifier>> __p_B2hAR6Jp06hP65hQ5WzqsQ;
            [n1.ElementAttribute(TracingId = 350164U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "SPNePtTSzf6NNkUkU3E1SG", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_SPNePtTSzf6NNkUkU3E1SG;
            [n1.ElementAttribute(TracingId = 350332U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "GTat4svMi2bNTWqbEEsc0E", Name = "FuseCoreDomain (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_GTat4svMi2bNTWqbEEsc0E;
            [n1.ElementAttribute(TracingId = 350383U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Dw1FVLE6u86MyEfd7o04Rp", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Dw1FVLE6u86MyEfd7o04Rp;
            [n1.ElementAttribute(TracingId = 350397U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Oir28lyttnNO4gpx6BfHbW", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
            public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Oir28lyttnNO4gpx6BfHbW;
            [n1.ElementAttribute(TracingId = 350431U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "G2WHVT2X6eMPIa8imuWD6x", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n22.Vector3> __p_G2WHVT2X6eMPIa8imuWD6x;
            [n1.ElementAttribute(TracingId = 350451U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "CVf5AnzHUNzMWdnRU7jcgE", Name = "CheckDefault", IsManaged = true, IsAutoGenerated = true)]
            public n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<n22.Vector3> __p_CVf5AnzHUNzMWdnRU7jcgE;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<string> __pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs = default(n11.Spread<string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.InputModifier> __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5 = default(n11.Spread<n5.InputModifier>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ = default(n11.Spread<n5.AbstractGpuValue>);
            public __KJqT1kY103OLazfwxC8c2a(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __KJqT1kY103OLazfwxC8c2a(__KJqT1kY103OLazfwxC8c2a other): base(other)
            {
                this.__p_B2hAR6Jp06hP65hQ5WzqsQ = other.__p_B2hAR6Jp06hP65hQ5WzqsQ;
                this.__p_SPNePtTSzf6NNkUkU3E1SG = other.__p_SPNePtTSzf6NNkUkU3E1SG;
                this.__p_GTat4svMi2bNTWqbEEsc0E = other.__p_GTat4svMi2bNTWqbEEsc0E;
                this.__p_Dw1FVLE6u86MyEfd7o04Rp = other.__p_Dw1FVLE6u86MyEfd7o04Rp;
                this.__p_Oir28lyttnNO4gpx6BfHbW = other.__p_Oir28lyttnNO4gpx6BfHbW;
                this.__p_G2WHVT2X6eMPIa8imuWD6x = other.__p_G2WHVT2X6eMPIa8imuWD6x;
                this.__p_CVf5AnzHUNzMWdnRU7jcgE = other.__p_CVf5AnzHUNzMWdnRU7jcgE;
                this.__pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs = other.__pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs;
                this.__pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5 = other.__pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5;
                this.__pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ = other.__pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_B2hAR6Jp06hP65hQ5WzqsQ", in __p_B2hAR6Jp06hP65hQ5WzqsQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_SPNePtTSzf6NNkUkU3E1SG", in __p_SPNePtTSzf6NNkUkU3E1SG), n1.CompilationHelper.GetValueOrExisting(values, "__p_GTat4svMi2bNTWqbEEsc0E", in __p_GTat4svMi2bNTWqbEEsc0E), n1.CompilationHelper.GetValueOrExisting(values, "__p_Dw1FVLE6u86MyEfd7o04Rp", in __p_Dw1FVLE6u86MyEfd7o04Rp), n1.CompilationHelper.GetValueOrExisting(values, "__p_Oir28lyttnNO4gpx6BfHbW", in __p_Oir28lyttnNO4gpx6BfHbW), n1.CompilationHelper.GetValueOrExisting(values, "__p_G2WHVT2X6eMPIa8imuWD6x", in __p_G2WHVT2X6eMPIa8imuWD6x), n1.CompilationHelper.GetValueOrExisting(values, "__p_CVf5AnzHUNzMWdnRU7jcgE", in __p_CVf5AnzHUNzMWdnRU7jcgE), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs", in __pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5", in __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ", in __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ));
            }

            internal __KJqT1kY103OLazfwxC8c2a __WITH__(n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<n22.Vector3, n11.Spread<n5.InputModifier>> __p_B2hAR6Jp06hP65hQ5WzqsQ, n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_SPNePtTSzf6NNkUkU3E1SG, n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __p_GTat4svMi2bNTWqbEEsc0E, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Dw1FVLE6u86MyEfd7o04Rp, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_Oir28lyttnNO4gpx6BfHbW, n24.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n22.Vector3> __p_G2WHVT2X6eMPIa8imuWD6x, n10.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<n22.Vector3> __p_CVf5AnzHUNzMWdnRU7jcgE, n11.Spread<string> __pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs, n11.Spread<n5.InputModifier> __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5, n11.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ)
            {
                __KJqT1kY103OLazfwxC8c2a that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_B2hAR6Jp06hP65hQ5WzqsQ != this.__p_B2hAR6Jp06hP65hQ5WzqsQ || __p_SPNePtTSzf6NNkUkU3E1SG != this.__p_SPNePtTSzf6NNkUkU3E1SG || __p_GTat4svMi2bNTWqbEEsc0E != this.__p_GTat4svMi2bNTWqbEEsc0E || __p_Dw1FVLE6u86MyEfd7o04Rp != this.__p_Dw1FVLE6u86MyEfd7o04Rp || __p_Oir28lyttnNO4gpx6BfHbW != this.__p_Oir28lyttnNO4gpx6BfHbW || __p_G2WHVT2X6eMPIa8imuWD6x != this.__p_G2WHVT2X6eMPIa8imuWD6x || __p_CVf5AnzHUNzMWdnRU7jcgE != this.__p_CVf5AnzHUNzMWdnRU7jcgE || __pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs != this.__pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs || __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5 != this.__pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5 || __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ != this.__pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ ? new __KJqT1kY103OLazfwxC8c2a(this)
                    {__p_B2hAR6Jp06hP65hQ5WzqsQ = __p_B2hAR6Jp06hP65hQ5WzqsQ, __p_SPNePtTSzf6NNkUkU3E1SG = __p_SPNePtTSzf6NNkUkU3E1SG, __p_GTat4svMi2bNTWqbEEsc0E = __p_GTat4svMi2bNTWqbEEsc0E, __p_Dw1FVLE6u86MyEfd7o04Rp = __p_Dw1FVLE6u86MyEfd7o04Rp, __p_Oir28lyttnNO4gpx6BfHbW = __p_Oir28lyttnNO4gpx6BfHbW, __p_G2WHVT2X6eMPIa8imuWD6x = __p_G2WHVT2X6eMPIa8imuWD6x, __p_CVf5AnzHUNzMWdnRU7jcgE = __p_CVf5AnzHUNzMWdnRU7jcgE, __pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs = __pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs, __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5 = __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5, __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ = __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ} : that_0;
                else
                {
                    this.__p_B2hAR6Jp06hP65hQ5WzqsQ = __p_B2hAR6Jp06hP65hQ5WzqsQ;
                    this.__p_SPNePtTSzf6NNkUkU3E1SG = __p_SPNePtTSzf6NNkUkU3E1SG;
                    this.__p_GTat4svMi2bNTWqbEEsc0E = __p_GTat4svMi2bNTWqbEEsc0E;
                    this.__p_Dw1FVLE6u86MyEfd7o04Rp = __p_Dw1FVLE6u86MyEfd7o04Rp;
                    this.__p_Oir28lyttnNO4gpx6BfHbW = __p_Oir28lyttnNO4gpx6BfHbW;
                    this.__p_G2WHVT2X6eMPIa8imuWD6x = __p_G2WHVT2X6eMPIa8imuWD6x;
                    this.__p_CVf5AnzHUNzMWdnRU7jcgE = __p_CVf5AnzHUNzMWdnRU7jcgE;
                    this.__pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs = __pin_group_Input_In_LLGH7Qq7Uk9Mu7OHrYwDGs;
                    this.__pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5 = __pin_group_Input_In_DvoJ23LwP4sMUmIvdy0ZA5;
                    this.__pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ = __pin_group_Arguments_In_B2hAR6Jp06hP65hQ5WzqsQ;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 351060U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "S5JC2Is0kARL8u9oNy9ycE", Name = "WorldSpace_S5JC2Is0kARL8u9oNy9ycE")]
    [n2.SerializableAttribute]
    public class WorldSpace_S5JC2Is0kARL8u9oNy9ycE : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n46.WorldSpace_S5JC2Is0kARL8u9oNy9ycE Create(n1.NodeContext Node_Context)
        {
            var instance = new WorldSpace_S5JC2Is0kARL8u9oNy9ycE(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n46.WorldSpace_S5JC2Is0kARL8u9oNy9ycE CreateDefault()
        {
            var instance = new WorldSpace_S5JC2Is0kARL8u9oNy9ycE(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n46.WorldSpace_S5JC2Is0kARL8u9oNy9ycE Update(out n5.GpuValue<n22.Vector3> xyz_Out)
        {
            var State_Output_1 = this.__p_HyAad23mfhGOoLgWlkL5gF.Update(Output_Out: out n5.GpuValue<n22.Vector4> Output_0);
            var State_Output_3 = this.__p_H2cdibVAo0gMzvIrm0SByv.Update(Input_In: Output_0, Output_Out: out n5.GpuValue<n22.Vector3> Output_2);
            bool Update_4 = true;
            var Output_5 = this.__p_BB8SuOPq4lYLJwXlcHVaUG;
            if (Update_4)
            {
                Output_5 = this.__p_BB8SuOPq4lYLJwXlcHVaUG.Update(Input_In: Output_2);
            }

            xyz_Out = Output_2;
            n46.WorldSpace_S5JC2Is0kARL8u9oNy9ycE that_6 = this;
            if (this.__GetContext__().IsImmutable)
                that_6 = State_Output_1 != this.__p_HyAad23mfhGOoLgWlkL5gF || State_Output_3 != this.__p_H2cdibVAo0gMzvIrm0SByv || Output_5 != this.__p_BB8SuOPq4lYLJwXlcHVaUG ? new WorldSpace_S5JC2Is0kARL8u9oNy9ycE(this)
                {__p_HyAad23mfhGOoLgWlkL5gF = State_Output_1, __p_H2cdibVAo0gMzvIrm0SByv = State_Output_3, __p_BB8SuOPq4lYLJwXlcHVaUG = Output_5} : that_6;
            else
            {
                this.__p_HyAad23mfhGOoLgWlkL5gF = State_Output_1;
                this.__p_H2cdibVAo0gMzvIrm0SByv = State_Output_3;
                this.__p_BB8SuOPq4lYLJwXlcHVaUG = Output_5;
            }

            return that_6;
        }

        public n46.WorldSpace_S5JC2Is0kARL8u9oNy9ycE __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "HyAad23mfhGOoLgWlkL5gF", 351102U);
            var Output_1 = n39.PositionWS_EqNTwQZFoLOQdVEmvtk795.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "H2cdibVAo0gMzvIrm0SByv", 351113U);
            var Output_3 = n40.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_2);
            n51._Operations_.WorldSpace3DID(Output_Out: out string Output_4);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "BB8SuOPq4lYLJwXlcHVaUG", 351133U);
            var Output_6 = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.Create(Node_Context: Node_Context_5, ID_In: Output_4);
            n46.WorldSpace_S5JC2Is0kARL8u9oNy9ycE that_7 = this;
            this.__p_HyAad23mfhGOoLgWlkL5gF = Output_1;
            this.__p_H2cdibVAo0gMzvIrm0SByv = Output_3;
            this.__p_BB8SuOPq4lYLJwXlcHVaUG = Output_6;
            return that_7;
        }

        public n46.WorldSpace_S5JC2Is0kARL8u9oNy9ycE __CreateDefault__()
        {
            n46.WorldSpace_S5JC2Is0kARL8u9oNy9ycE that_0 = this;
            this.__p_HyAad23mfhGOoLgWlkL5gF = n39.PositionWS_EqNTwQZFoLOQdVEmvtk795.CreateDefault();
            this.__p_H2cdibVAo0gMzvIrm0SByv = n40.xyz_T2WwCF9xAltPhlUuLjVDje.CreateDefault();
            this.__p_BB8SuOPq4lYLJwXlcHVaUG = n10.SetNodeID_Na7x9tH05WePNdH51KMS76.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_HyAad23mfhGOoLgWlkL5gF);
            n1.CompilationHelper.SafeDispose(this.__p_H2cdibVAo0gMzvIrm0SByv);
            n1.CompilationHelper.SafeDispose(this.__p_BB8SuOPq4lYLJwXlcHVaUG);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 351102U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "HyAad23mfhGOoLgWlkL5gF", Name = "PositionWS", IsManaged = true, IsAutoGenerated = true)]
        public n39.PositionWS_EqNTwQZFoLOQdVEmvtk795 __p_HyAad23mfhGOoLgWlkL5gF;
        [n1.ElementAttribute(TracingId = 351113U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "H2cdibVAo0gMzvIrm0SByv", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
        public n40.xyz_T2WwCF9xAltPhlUuLjVDje __p_H2cdibVAo0gMzvIrm0SByv;
        [n1.ElementAttribute(TracingId = 351133U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "BB8SuOPq4lYLJwXlcHVaUG", Name = "SetNodeID", IsManaged = true, IsAutoGenerated = true)]
        public n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_BB8SuOPq4lYLJwXlcHVaUG;
        public WorldSpace_S5JC2Is0kARL8u9oNy9ycE(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal WorldSpace_S5JC2Is0kARL8u9oNy9ycE(WorldSpace_S5JC2Is0kARL8u9oNy9ycE other): base(other)
        {
            this.__p_HyAad23mfhGOoLgWlkL5gF = other.__p_HyAad23mfhGOoLgWlkL5gF;
            this.__p_H2cdibVAo0gMzvIrm0SByv = other.__p_H2cdibVAo0gMzvIrm0SByv;
            this.__p_BB8SuOPq4lYLJwXlcHVaUG = other.__p_BB8SuOPq4lYLJwXlcHVaUG;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HyAad23mfhGOoLgWlkL5gF", in __p_HyAad23mfhGOoLgWlkL5gF), n1.CompilationHelper.GetValueOrExisting(values, "__p_H2cdibVAo0gMzvIrm0SByv", in __p_H2cdibVAo0gMzvIrm0SByv), n1.CompilationHelper.GetValueOrExisting(values, "__p_BB8SuOPq4lYLJwXlcHVaUG", in __p_BB8SuOPq4lYLJwXlcHVaUG));
        }

        internal WorldSpace_S5JC2Is0kARL8u9oNy9ycE __WITH__(n39.PositionWS_EqNTwQZFoLOQdVEmvtk795 __p_HyAad23mfhGOoLgWlkL5gF, n40.xyz_T2WwCF9xAltPhlUuLjVDje __p_H2cdibVAo0gMzvIrm0SByv, n10.SetNodeID_Na7x9tH05WePNdH51KMS76 __p_BB8SuOPq4lYLJwXlcHVaUG)
        {
            n46.WorldSpace_S5JC2Is0kARL8u9oNy9ycE that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_HyAad23mfhGOoLgWlkL5gF != this.__p_HyAad23mfhGOoLgWlkL5gF || __p_H2cdibVAo0gMzvIrm0SByv != this.__p_H2cdibVAo0gMzvIrm0SByv || __p_BB8SuOPq4lYLJwXlcHVaUG != this.__p_BB8SuOPq4lYLJwXlcHVaUG ? new WorldSpace_S5JC2Is0kARL8u9oNy9ycE(this)
                {__p_HyAad23mfhGOoLgWlkL5gF = __p_HyAad23mfhGOoLgWlkL5gF, __p_H2cdibVAo0gMzvIrm0SByv = __p_H2cdibVAo0gMzvIrm0SByv, __p_BB8SuOPq4lYLJwXlcHVaUG = __p_BB8SuOPq4lYLJwXlcHVaUG} : that_0;
            else
            {
                this.__p_HyAad23mfhGOoLgWlkL5gF = __p_HyAad23mfhGOoLgWlkL5gF;
                this.__p_H2cdibVAo0gMzvIrm0SByv = __p_H2cdibVAo0gMzvIrm0SByv;
                this.__p_BB8SuOPq4lYLJwXlcHVaUG = __p_BB8SuOPq4lYLJwXlcHVaUG;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 351189U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "NCx5qB8BfNHL45pJRN9LFg", Name = "ObjectSpace_NCx5qB8BfNHL45pJRN9LFg")]
    [n2.SerializableAttribute]
    public class ObjectSpace_NCx5qB8BfNHL45pJRN9LFg : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n46.ObjectSpace_NCx5qB8BfNHL45pJRN9LFg Create(n1.NodeContext Node_Context)
        {
            var instance = new ObjectSpace_NCx5qB8BfNHL45pJRN9LFg(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n46.ObjectSpace_NCx5qB8BfNHL45pJRN9LFg CreateDefault()
        {
            var instance = new ObjectSpace_NCx5qB8BfNHL45pJRN9LFg(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n46.ObjectSpace_NCx5qB8BfNHL45pJRN9LFg Update(out n5.GpuValue<n22.Vector3> xyz_Out)
        {
            var State_Output_1 = this.__p_VRMCgeoOXS7P1A86LHLbAl.Update(Output_Out: out n5.GpuValue<n22.Vector4> Output_0);
            var State_Output_3 = this.__p_MNHhrvUuyFcPGvYNkDTd4f.Update(Input_In: Output_0, Output_Out: out n5.GpuValue<n22.Vector3> Output_2);
            xyz_Out = Output_2;
            n46.ObjectSpace_NCx5qB8BfNHL45pJRN9LFg that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = State_Output_1 != this.__p_VRMCgeoOXS7P1A86LHLbAl || State_Output_3 != this.__p_MNHhrvUuyFcPGvYNkDTd4f ? new ObjectSpace_NCx5qB8BfNHL45pJRN9LFg(this)
                {__p_VRMCgeoOXS7P1A86LHLbAl = State_Output_1, __p_MNHhrvUuyFcPGvYNkDTd4f = State_Output_3} : that_4;
            else
            {
                this.__p_VRMCgeoOXS7P1A86LHLbAl = State_Output_1;
                this.__p_MNHhrvUuyFcPGvYNkDTd4f = State_Output_3;
            }

            return that_4;
        }

        public n46.ObjectSpace_NCx5qB8BfNHL45pJRN9LFg __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "VRMCgeoOXS7P1A86LHLbAl", 351195U);
            var Output_1 = n39.Position_PeLDdeSku4ANhU5oe5SfPy.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "MNHhrvUuyFcPGvYNkDTd4f", 351205U);
            var Output_3 = n40.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_2);
            n46.ObjectSpace_NCx5qB8BfNHL45pJRN9LFg that_4 = this;
            this.__p_VRMCgeoOXS7P1A86LHLbAl = Output_1;
            this.__p_MNHhrvUuyFcPGvYNkDTd4f = Output_3;
            return that_4;
        }

        public n46.ObjectSpace_NCx5qB8BfNHL45pJRN9LFg __CreateDefault__()
        {
            n46.ObjectSpace_NCx5qB8BfNHL45pJRN9LFg that_0 = this;
            this.__p_VRMCgeoOXS7P1A86LHLbAl = n39.Position_PeLDdeSku4ANhU5oe5SfPy.CreateDefault();
            this.__p_MNHhrvUuyFcPGvYNkDTd4f = n40.xyz_T2WwCF9xAltPhlUuLjVDje.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_VRMCgeoOXS7P1A86LHLbAl);
            n1.CompilationHelper.SafeDispose(this.__p_MNHhrvUuyFcPGvYNkDTd4f);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 351195U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "VRMCgeoOXS7P1A86LHLbAl", Name = "Position", IsManaged = true, IsAutoGenerated = true)]
        public n39.Position_PeLDdeSku4ANhU5oe5SfPy __p_VRMCgeoOXS7P1A86LHLbAl;
        [n1.ElementAttribute(TracingId = 351205U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "MNHhrvUuyFcPGvYNkDTd4f", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
        public n40.xyz_T2WwCF9xAltPhlUuLjVDje __p_MNHhrvUuyFcPGvYNkDTd4f;
        public ObjectSpace_NCx5qB8BfNHL45pJRN9LFg(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ObjectSpace_NCx5qB8BfNHL45pJRN9LFg(ObjectSpace_NCx5qB8BfNHL45pJRN9LFg other): base(other)
        {
            this.__p_VRMCgeoOXS7P1A86LHLbAl = other.__p_VRMCgeoOXS7P1A86LHLbAl;
            this.__p_MNHhrvUuyFcPGvYNkDTd4f = other.__p_MNHhrvUuyFcPGvYNkDTd4f;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VRMCgeoOXS7P1A86LHLbAl", in __p_VRMCgeoOXS7P1A86LHLbAl), n1.CompilationHelper.GetValueOrExisting(values, "__p_MNHhrvUuyFcPGvYNkDTd4f", in __p_MNHhrvUuyFcPGvYNkDTd4f));
        }

        internal ObjectSpace_NCx5qB8BfNHL45pJRN9LFg __WITH__(n39.Position_PeLDdeSku4ANhU5oe5SfPy __p_VRMCgeoOXS7P1A86LHLbAl, n40.xyz_T2WwCF9xAltPhlUuLjVDje __p_MNHhrvUuyFcPGvYNkDTd4f)
        {
            n46.ObjectSpace_NCx5qB8BfNHL45pJRN9LFg that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_VRMCgeoOXS7P1A86LHLbAl != this.__p_VRMCgeoOXS7P1A86LHLbAl || __p_MNHhrvUuyFcPGvYNkDTd4f != this.__p_MNHhrvUuyFcPGvYNkDTd4f ? new ObjectSpace_NCx5qB8BfNHL45pJRN9LFg(this)
                {__p_VRMCgeoOXS7P1A86LHLbAl = __p_VRMCgeoOXS7P1A86LHLbAl, __p_MNHhrvUuyFcPGvYNkDTd4f = __p_MNHhrvUuyFcPGvYNkDTd4f} : that_0;
            else
            {
                this.__p_VRMCgeoOXS7P1A86LHLbAl = __p_VRMCgeoOXS7P1A86LHLbAl;
                this.__p_MNHhrvUuyFcPGvYNkDTd4f = __p_MNHhrvUuyFcPGvYNkDTd4f;
            }

            return that_0;
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain._3D.DomainRepeat
{
    [n1.ElementAttribute(TracingId = 343058U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void TemplateValues(int Operation_In, out n15.ImmutableDictionary<string, string> Output_Out)
        {
            n15.ImmutableDictionary<string, string> __pin_group_Input_In_RSmqzrbE9q0LKHXDD9Tocp = default(n15.ImmutableDictionary<string, string>);
            string __pad_CoUIOmkYnzQLwrAJOiJbJf_0 = __slot_CoUIOmkYnzQLwrAJOiJbJf;
            string __pad_Vh8I9GDX0GFO9wuR1nFdxI_1 = __slot_Vh8I9GDX0GFO9wuR1nFdxI;
            var New_Line_2 = n44.StringExtensions.NewLine;
            n2.StringSplitOptions Options_3 = default(n2.StringSplitOptions);
            n45._Operations_.Split_String(Input_In: __pad_CoUIOmkYnzQLwrAJOiJbJf_0, Separator_In: New_Line_2, Options_In: Options_3, Output_Out: out n11.Spread<string> Output_4);
            string Default_Value_5 = "";
            n17._Operations_.GetSlice<string>(Input_In: Output_4, Default_Value_In: Default_Value_5, Index_In: Operation_In, Result_Out: out string Result_6);
            var New_Line_7 = n44.StringExtensions.NewLine;
            n2.StringSplitOptions Options_8 = default(n2.StringSplitOptions);
            n45._Operations_.Split_String(Input_In: __pad_Vh8I9GDX0GFO9wuR1nFdxI_1, Separator_In: New_Line_7, Options_In: Options_8, Output_Out: out n11.Spread<string> Output_9);
            string Default_Value_10 = "";
            n17._Operations_.GetSlice<string>(Input_In: Output_9, Default_Value_In: Default_Value_10, Index_In: Operation_In, Result_Out: out string Result_11);
            var builder_12 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_RSmqzrbE9q0LKHXDD9Tocp, 2);
            builder_12.Add("OP", Result_6);
            builder_12.Add("SWIZZLE", Result_11);
            var __pin_group_Input_In_RSmqzrbE9q0LKHXDD9Tocp_13 = builder_12.Commit();
            n16._Operations_.Cons<string>(Input_In: __pin_group_Input_In_RSmqzrbE9q0LKHXDD9Tocp_13, Output_Out: out n15.ImmutableDictionary<string, string> Output_14);
            Output_Out = Output_14;
            return;
        }

        public static void DomainRepeat3DID(out string Output_Out)
        {
            string __pad_DyBTLw4OJojLKkAzFoDkK1_0 = __slot_DyBTLw4OJojLKkAzFoDkK1;
            Output_Out = __pad_DyBTLw4OJojLKkAzFoDkK1_0;
            return;
        }

        public static void DomainRepeatCell3DID(out string Output_Out)
        {
            string __pad_Qe6MLPSVwl6L8BiceItF82_0 = __slot_Qe6MLPSVwl6L8BiceItF82;
            Output_Out = __pad_Qe6MLPSVwl6L8BiceItF82_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 350625U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "CoUIOmkYnzQLwrAJOiJbJf", Name = "__slot_CoUIOmkYnzQLwrAJOiJbJf")]
        public static string __slot_CoUIOmkYnzQLwrAJOiJbJf = "pMod1\r\npMod1\r\npMod1\r\npModMirror1\r\npModMirror1\r\npModMirror1\r\npMod2\r\npMod2\r\npMod2\r\npModMirror2\r\npModMirror2\r\npModMirror2\r\npMod3\r\npModPolar\r\npModPolar\r\npModPolar";
        [n1.ElementAttribute(TracingId = 350707U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Vh8I9GDX0GFO9wuR1nFdxI", Name = "__slot_Vh8I9GDX0GFO9wuR1nFdxI")]
        public static string __slot_Vh8I9GDX0GFO9wuR1nFdxI = "x\r\ny\r\nz\r\nx\r\ny\r\nz\r\nxy\r\nxz\r\nyz\r\nxy\r\nxz\r\nyz\r\nxyz\r\nxy\r\nxz\r\nyz";
        [n1.ElementAttribute(TracingId = 350835U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "DyBTLw4OJojLKkAzFoDkK1", Name = "__slot_DyBTLw4OJojLKkAzFoDkK1")]
        public static string __slot_DyBTLw4OJojLKkAzFoDkK1 = "DomainRepeat3D";
        [n1.ElementAttribute(TracingId = 350881U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Qe6MLPSVwl6L8BiceItF82", Name = "__slot_Qe6MLPSVwl6L8BiceItF82")]
        public static string __slot_Qe6MLPSVwl6L8BiceItF82 = "DomainRepeatCell3D";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain._3D.WorldSpace
{
    [n1.ElementAttribute(TracingId = 343058U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void WorldSpace3DID(out string Output_Out)
        {
            string __pad_LQVTKAV269BLpKklNW3alc_0 = __slot_LQVTKAV269BLpKklNW3alc;
            Output_Out = __pad_LQVTKAV269BLpKklNW3alc_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 351068U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "LQVTKAV269BLpKklNW3alc", Name = "__slot_LQVTKAV269BLpKklNW3alc")]
        public static string __slot_LQVTKAV269BLpKklNW3alc = "WorldSpace3D";
        static _Operations_()
        {
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain.Internal
{
    [n1.ElementAttribute(TracingId = 351254U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "PzDrbJt6BRIL37Z3WzLD4v", Name = "FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v")]
    [n2.SerializableAttribute]
    public class FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v Create(n1.NodeContext Node_Context)
        {
            var instance = new FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v CreateDefault()
        {
            var instance = new FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v Update(out string Singleton_Out)
        {
            string __pad_OtSju4Gr63NOR9zQgLnQal_0 = __slot_OtSju4Gr63NOR9zQgLnQal;
            Singleton_Out = __pad_OtSju4Gr63NOR9zQgLnQal_0;
            return this;
        }

        public n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n29.FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __CreateDefault__()
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

        [n1.ElementAttribute(TracingId = 351267U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "OtSju4Gr63NOR9zQgLnQal", Name = "__slot_OtSju4Gr63NOR9zQgLnQal")]
        public static string __slot_OtSju4Gr63NOR9zQgLnQal = "FuseCoreDomain";
        static FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v()
        {
        }

        public FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v(FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal FuseCoreDomain_Mixin_PzDrbJt6BRIL37Z3WzLD4v __WITH__()
        {
            return this;
        }
    }
}

namespace _Fuse_Core_Domain_.Fuse.Core.Domain.FunctionHelpers
{
    [n1.ElementAttribute(TracingId = 354128U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "BlBa5MPryNIOJxYuSZVWjl", Name = "FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl")]
    [n2.SerializableAttribute]
    public class FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n52.FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl Create(n1.NodeContext Node_Context)
        {
            var instance = new FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n52.FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl CreateDefault()
        {
            var instance = new FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n52.FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl Update(n5.GpuValue<n22.Vector2> The_Override_In, out n5.GpuValue<n22.Vector2> Output_Out)
        {
            int Id_0 = 0;
            var State_Output_2 = this.__p_EL6csMyvxijNYgyLPMUnB0.Update(The_Override_In: The_Override_In, Id_In: Id_0, Output_Out: out n5.GpuValue<n22.Vector2> Output_1);
            Output_Out = Output_1;
            n52.FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = State_Output_2 != this.__p_EL6csMyvxijNYgyLPMUnB0 ? new FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl(this)
                {__p_EL6csMyvxijNYgyLPMUnB0 = State_Output_2} : that_3;
            else
            {
                this.__p_EL6csMyvxijNYgyLPMUnB0 = State_Output_2;
            }

            return that_3;
        }

        public n52.FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "EL6csMyvxijNYgyLPMUnB0", 354133U);
            var Output_1 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.Create(Node_Context: Node_Context_0);
            n52.FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl that_2 = this;
            this.__p_EL6csMyvxijNYgyLPMUnB0 = Output_1;
            return that_2;
        }

        public n52.FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl __CreateDefault__()
        {
            n52.FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl that_0 = this;
            this.__p_EL6csMyvxijNYgyLPMUnB0 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_EL6csMyvxijNYgyLPMUnB0);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 354133U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "EL6csMyvxijNYgyLPMUnB0", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
        public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_EL6csMyvxijNYgyLPMUnB0;
        public FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl(FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl other): base(other)
        {
            this.__p_EL6csMyvxijNYgyLPMUnB0 = other.__p_EL6csMyvxijNYgyLPMUnB0;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_EL6csMyvxijNYgyLPMUnB0", in __p_EL6csMyvxijNYgyLPMUnB0));
        }

        internal FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl __WITH__(n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_EL6csMyvxijNYgyLPMUnB0)
        {
            n52.FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_EL6csMyvxijNYgyLPMUnB0 != this.__p_EL6csMyvxijNYgyLPMUnB0 ? new FunctionParameter__2D_Scalar_Function_BlBa5MPryNIOJxYuSZVWjl(this)
                {__p_EL6csMyvxijNYgyLPMUnB0 = __p_EL6csMyvxijNYgyLPMUnB0} : that_0;
            else
            {
                this.__p_EL6csMyvxijNYgyLPMUnB0 = __p_EL6csMyvxijNYgyLPMUnB0;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 354192U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "G18D97qO6PrMqbF4193M3s", Name = "Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s")]
    [n2.SerializableAttribute]
    public class Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n52.Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s Create(n1.NodeContext Node_Context)
        {
            var instance = new Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n52.Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s CreateDefault()
        {
            var instance = new Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n52.Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s Update(n5.GpuValue<float> Function_In, [n4.SerializedDefaultValueAttribute("Float2_To_Float_Function", false)] string Id_In, out n5.FunctionInvokeNode<float> Output_Out)
        {
            n5.GpuValue<n22.Vector2> Input_0 = default(n5.GpuValue<n22.Vector2>);
            n42._Operations_.TypeVector2(Input_In: Input_0, Output_Out: out n5.GpuValue<n22.Vector2> Output_1);
            int Id_2 = 0;
            var State_Output_4 = this.__p_CksbWontpfXN44nT0SftNP.Update(The_Override_In: Output_1, Id_In: Id_2, Output_Out: out n5.GpuValue<n22.Vector2> Output_3);
            var builder_5 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8, 1);
            builder_5.Add(Output_3);
            var __pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8_6 = builder_5.Commit();
            var State_Output_8 = this.__p_OnmhCOziBH3Ple0KGka2a8.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8_6, Id_In: Id_In, Output_Out: out n5.FunctionInvokeNode<float> Output_7);
            Output_Out = Output_7;
            n52.Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = State_Output_4 != this.__p_CksbWontpfXN44nT0SftNP || __pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8_6 != this.__pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8 || State_Output_8 != this.__p_OnmhCOziBH3Ple0KGka2a8 ? new Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s(this)
                {__p_CksbWontpfXN44nT0SftNP = State_Output_4, __pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8 = __pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8_6, __p_OnmhCOziBH3Ple0KGka2a8 = State_Output_8} : that_9;
            else
            {
                this.__p_CksbWontpfXN44nT0SftNP = State_Output_4;
                this.__pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8 = __pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8_6;
                this.__p_OnmhCOziBH3Ple0KGka2a8 = State_Output_8;
            }

            return that_9;
        }

        public n52.Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "OnmhCOziBH3Ple0KGka2a8", 354200U);
            var Output_1 = n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "CksbWontpfXN44nT0SftNP", 354239U);
            var Output_3 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.Create(Node_Context: Node_Context_2);
            n52.Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s that_4 = this;
            this.__pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8 = n17._Operations_.CreateDefault<n5.AbstractGpuValue>();
            this.__p_OnmhCOziBH3Ple0KGka2a8 = Output_1;
            this.__p_CksbWontpfXN44nT0SftNP = Output_3;
            return that_4;
        }

        public n52.Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s __CreateDefault__()
        {
            n52.Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s that_0 = this;
            this.__pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8 = n17._Operations_.CreateDefault<n5.AbstractGpuValue>();
            this.__p_CksbWontpfXN44nT0SftNP = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.CreateDefault();
            this.__p_OnmhCOziBH3Ple0KGka2a8 = n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_CksbWontpfXN44nT0SftNP);
            n1.CompilationHelper.SafeDispose(this.__p_OnmhCOziBH3Ple0KGka2a8);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 354239U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "CksbWontpfXN44nT0SftNP", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
        public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_CksbWontpfXN44nT0SftNP;
        [n1.ElementAttribute(TracingId = 354200U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "OnmhCOziBH3Ple0KGka2a8", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
        public n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_OnmhCOziBH3Ple0KGka2a8;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n11.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8 = default(n11.Spread<n5.AbstractGpuValue>);
        public Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s(Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s other): base(other)
        {
            this.__p_CksbWontpfXN44nT0SftNP = other.__p_CksbWontpfXN44nT0SftNP;
            this.__p_OnmhCOziBH3Ple0KGka2a8 = other.__p_OnmhCOziBH3Ple0KGka2a8;
            this.__pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8 = other.__pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_CksbWontpfXN44nT0SftNP", in __p_CksbWontpfXN44nT0SftNP), n1.CompilationHelper.GetValueOrExisting(values, "__p_OnmhCOziBH3Ple0KGka2a8", in __p_OnmhCOziBH3Ple0KGka2a8), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8", in __pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8));
        }

        internal Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s __WITH__(n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_CksbWontpfXN44nT0SftNP, n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_OnmhCOziBH3Ple0KGka2a8, n11.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8)
        {
            n52.Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_CksbWontpfXN44nT0SftNP != this.__p_CksbWontpfXN44nT0SftNP || __p_OnmhCOziBH3Ple0KGka2a8 != this.__p_OnmhCOziBH3Ple0KGka2a8 || __pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8 != this.__pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8 ? new Function__2D_Scalar_Function_G18D97qO6PrMqbF4193M3s(this)
                {__p_CksbWontpfXN44nT0SftNP = __p_CksbWontpfXN44nT0SftNP, __p_OnmhCOziBH3Ple0KGka2a8 = __p_OnmhCOziBH3Ple0KGka2a8, __pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8 = __pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8} : that_0;
            else
            {
                this.__p_CksbWontpfXN44nT0SftNP = __p_CksbWontpfXN44nT0SftNP;
                this.__p_OnmhCOziBH3Ple0KGka2a8 = __p_OnmhCOziBH3Ple0KGka2a8;
                this.__pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8 = __pin_group_Parameters_In_OnmhCOziBH3Ple0KGka2a8;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 354308U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "EJCCggs8qPZQF4KutYpYq5", Name = "FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5")]
    [n2.SerializableAttribute]
    public class FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n52.FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5 Create(n1.NodeContext Node_Context)
        {
            var instance = new FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n52.FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5 CreateDefault()
        {
            var instance = new FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n52.FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5 Update(n5.GpuValue<n22.Vector3> The_Override_In, out n5.GpuValue<n22.Vector3> Output_Out)
        {
            int Id_0 = 0;
            var State_Output_2 = this.__p_NIasutTvMjCPXb2teXZtUY.Update(The_Override_In: The_Override_In, Id_In: Id_0, Output_Out: out n5.GpuValue<n22.Vector3> Output_1);
            Output_Out = Output_1;
            n52.FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5 that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = State_Output_2 != this.__p_NIasutTvMjCPXb2teXZtUY ? new FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5(this)
                {__p_NIasutTvMjCPXb2teXZtUY = State_Output_2} : that_3;
            else
            {
                this.__p_NIasutTvMjCPXb2teXZtUY = State_Output_2;
            }

            return that_3;
        }

        public n52.FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5 __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "NIasutTvMjCPXb2teXZtUY", 354312U);
            var Output_1 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3>.Create(Node_Context: Node_Context_0);
            n52.FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5 that_2 = this;
            this.__p_NIasutTvMjCPXb2teXZtUY = Output_1;
            return that_2;
        }

        public n52.FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5 __CreateDefault__()
        {
            n52.FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5 that_0 = this;
            this.__p_NIasutTvMjCPXb2teXZtUY = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_NIasutTvMjCPXb2teXZtUY);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 354312U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "NIasutTvMjCPXb2teXZtUY", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
        public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_NIasutTvMjCPXb2teXZtUY;
        public FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5(FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5 other): base(other)
        {
            this.__p_NIasutTvMjCPXb2teXZtUY = other.__p_NIasutTvMjCPXb2teXZtUY;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NIasutTvMjCPXb2teXZtUY", in __p_NIasutTvMjCPXb2teXZtUY));
        }

        internal FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5 __WITH__(n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_NIasutTvMjCPXb2teXZtUY)
        {
            n52.FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_NIasutTvMjCPXb2teXZtUY != this.__p_NIasutTvMjCPXb2teXZtUY ? new FunctionParameter__3D_Scalar_Function_EJCCggs8qPZQF4KutYpYq5(this)
                {__p_NIasutTvMjCPXb2teXZtUY = __p_NIasutTvMjCPXb2teXZtUY} : that_0;
            else
            {
                this.__p_NIasutTvMjCPXb2teXZtUY = __p_NIasutTvMjCPXb2teXZtUY;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 354388U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "COBeFmGmDCLLaeQqSpS75X", Name = "Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X")]
    [n2.SerializableAttribute]
    public class Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n52.Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X Create(n1.NodeContext Node_Context)
        {
            var instance = new Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n52.Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X CreateDefault()
        {
            var instance = new Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n52.Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X Update(n5.GpuValue<float> Function_In, [n4.SerializedDefaultValueAttribute("Float3_To_Float_Function", false)] string Id_In, out n5.FunctionInvokeNode<float> Output_Out)
        {
            n5.GpuValue<n22.Vector3> Input_0 = default(n5.GpuValue<n22.Vector3>);
            n42._Operations_.TypeVector3(Input_In: Input_0, Output_Out: out n5.GpuValue<n22.Vector3> Output_1);
            int Id_2 = 0;
            var State_Output_4 = this.__p_FZBOieuij2VNAk4Jx8R3bD.Update(The_Override_In: Output_1, Id_In: Id_2, Output_Out: out n5.GpuValue<n22.Vector3> Output_3);
            var builder_5 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9, 1);
            builder_5.Add(Output_3);
            var __pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9_6 = builder_5.Commit();
            var State_Output_8 = this.__p_NDogBf56L5uO6rPodSiaU9.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9_6, Id_In: Id_In, Output_Out: out n5.FunctionInvokeNode<float> Output_7);
            Output_Out = Output_7;
            n52.Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = State_Output_4 != this.__p_FZBOieuij2VNAk4Jx8R3bD || __pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9_6 != this.__pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9 || State_Output_8 != this.__p_NDogBf56L5uO6rPodSiaU9 ? new Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X(this)
                {__p_FZBOieuij2VNAk4Jx8R3bD = State_Output_4, __pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9 = __pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9_6, __p_NDogBf56L5uO6rPodSiaU9 = State_Output_8} : that_9;
            else
            {
                this.__p_FZBOieuij2VNAk4Jx8R3bD = State_Output_4;
                this.__pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9 = __pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9_6;
                this.__p_NDogBf56L5uO6rPodSiaU9 = State_Output_8;
            }

            return that_9;
        }

        public n52.Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "NDogBf56L5uO6rPodSiaU9", 354391U);
            var Output_1 = n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "FZBOieuij2VNAk4Jx8R3bD", 354425U);
            var Output_3 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3>.Create(Node_Context: Node_Context_2);
            n52.Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X that_4 = this;
            this.__pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9 = n17._Operations_.CreateDefault<n5.AbstractGpuValue>();
            this.__p_NDogBf56L5uO6rPodSiaU9 = Output_1;
            this.__p_FZBOieuij2VNAk4Jx8R3bD = Output_3;
            return that_4;
        }

        public n52.Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X __CreateDefault__()
        {
            n52.Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X that_0 = this;
            this.__pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9 = n17._Operations_.CreateDefault<n5.AbstractGpuValue>();
            this.__p_FZBOieuij2VNAk4Jx8R3bD = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3>.CreateDefault();
            this.__p_NDogBf56L5uO6rPodSiaU9 = n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_FZBOieuij2VNAk4Jx8R3bD);
            n1.CompilationHelper.SafeDispose(this.__p_NDogBf56L5uO6rPodSiaU9);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 354425U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "FZBOieuij2VNAk4Jx8R3bD", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
        public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_FZBOieuij2VNAk4Jx8R3bD;
        [n1.ElementAttribute(TracingId = 354391U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "NDogBf56L5uO6rPodSiaU9", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
        public n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_NDogBf56L5uO6rPodSiaU9;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n11.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9 = default(n11.Spread<n5.AbstractGpuValue>);
        public Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X(Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X other): base(other)
        {
            this.__p_FZBOieuij2VNAk4Jx8R3bD = other.__p_FZBOieuij2VNAk4Jx8R3bD;
            this.__p_NDogBf56L5uO6rPodSiaU9 = other.__p_NDogBf56L5uO6rPodSiaU9;
            this.__pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9 = other.__pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FZBOieuij2VNAk4Jx8R3bD", in __p_FZBOieuij2VNAk4Jx8R3bD), n1.CompilationHelper.GetValueOrExisting(values, "__p_NDogBf56L5uO6rPodSiaU9", in __p_NDogBf56L5uO6rPodSiaU9), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9", in __pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9));
        }

        internal Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X __WITH__(n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_FZBOieuij2VNAk4Jx8R3bD, n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_NDogBf56L5uO6rPodSiaU9, n11.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9)
        {
            n52.Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_FZBOieuij2VNAk4Jx8R3bD != this.__p_FZBOieuij2VNAk4Jx8R3bD || __p_NDogBf56L5uO6rPodSiaU9 != this.__p_NDogBf56L5uO6rPodSiaU9 || __pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9 != this.__pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9 ? new Function__3D_Scalar_Function_COBeFmGmDCLLaeQqSpS75X(this)
                {__p_FZBOieuij2VNAk4Jx8R3bD = __p_FZBOieuij2VNAk4Jx8R3bD, __p_NDogBf56L5uO6rPodSiaU9 = __p_NDogBf56L5uO6rPodSiaU9, __pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9 = __pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9} : that_0;
            else
            {
                this.__p_FZBOieuij2VNAk4Jx8R3bD = __p_FZBOieuij2VNAk4Jx8R3bD;
                this.__p_NDogBf56L5uO6rPodSiaU9 = __p_NDogBf56L5uO6rPodSiaU9;
                this.__pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9 = __pin_group_Parameters_In_NDogBf56L5uO6rPodSiaU9;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 354525U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "TaGUbOHtQlGLRcEreHHASg", Name = "FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg")]
    [n2.SerializableAttribute]
    public class FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n52.FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg Create(n1.NodeContext Node_Context)
        {
            var instance = new FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n52.FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg CreateDefault()
        {
            var instance = new FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n52.FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg Update(n5.GpuValue<n22.Vector2> The_Override_In, out n5.GpuValue<n22.Vector2> Output_Out)
        {
            int Id_0 = 0;
            var State_Output_2 = this.__p_Fn8weJLnEFuL4rcW3Y1QuJ.Update(The_Override_In: The_Override_In, Id_In: Id_0, Output_Out: out n5.GpuValue<n22.Vector2> Output_1);
            Output_Out = Output_1;
            n52.FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = State_Output_2 != this.__p_Fn8weJLnEFuL4rcW3Y1QuJ ? new FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg(this)
                {__p_Fn8weJLnEFuL4rcW3Y1QuJ = State_Output_2} : that_3;
            else
            {
                this.__p_Fn8weJLnEFuL4rcW3Y1QuJ = State_Output_2;
            }

            return that_3;
        }

        public n52.FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Fn8weJLnEFuL4rcW3Y1QuJ", 354530U);
            var Output_1 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.Create(Node_Context: Node_Context_0);
            n52.FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg that_2 = this;
            this.__p_Fn8weJLnEFuL4rcW3Y1QuJ = Output_1;
            return that_2;
        }

        public n52.FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg __CreateDefault__()
        {
            n52.FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg that_0 = this;
            this.__p_Fn8weJLnEFuL4rcW3Y1QuJ = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Fn8weJLnEFuL4rcW3Y1QuJ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 354530U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Fn8weJLnEFuL4rcW3Y1QuJ", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
        public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_Fn8weJLnEFuL4rcW3Y1QuJ;
        public FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg(FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg other): base(other)
        {
            this.__p_Fn8weJLnEFuL4rcW3Y1QuJ = other.__p_Fn8weJLnEFuL4rcW3Y1QuJ;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Fn8weJLnEFuL4rcW3Y1QuJ", in __p_Fn8weJLnEFuL4rcW3Y1QuJ));
        }

        internal FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg __WITH__(n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_Fn8weJLnEFuL4rcW3Y1QuJ)
        {
            n52.FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Fn8weJLnEFuL4rcW3Y1QuJ != this.__p_Fn8weJLnEFuL4rcW3Y1QuJ ? new FunctionParameter__2D_Vector_Function_TaGUbOHtQlGLRcEreHHASg(this)
                {__p_Fn8weJLnEFuL4rcW3Y1QuJ = __p_Fn8weJLnEFuL4rcW3Y1QuJ} : that_0;
            else
            {
                this.__p_Fn8weJLnEFuL4rcW3Y1QuJ = __p_Fn8weJLnEFuL4rcW3Y1QuJ;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 354598U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "LYpmOyjyUhSNRTp3F2Zoxk", Name = "Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk")]
    [n2.SerializableAttribute]
    public class Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n52.Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk Create(n1.NodeContext Node_Context)
        {
            var instance = new Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n52.Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk CreateDefault()
        {
            var instance = new Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n52.Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk Update(n5.GpuValue<n22.Vector2> Function_In, [n4.SerializedDefaultValueAttribute("Float2_To_Float2_Function", false)] string Id_In, out n5.FunctionInvokeNode<n22.Vector2> Output_Out)
        {
            n5.GpuValue<n22.Vector2> Input_0 = default(n5.GpuValue<n22.Vector2>);
            n42._Operations_.TypeVector2(Input_In: Input_0, Output_Out: out n5.GpuValue<n22.Vector2> Output_1);
            int Id_2 = 0;
            var State_Output_4 = this.__p_PFSb02iEJm1Ny0BHJgn3ze.Update(The_Override_In: Output_1, Id_In: Id_2, Output_Out: out n5.GpuValue<n22.Vector2> Output_3);
            var builder_5 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J, 1);
            builder_5.Add(Output_3);
            var __pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J_6 = builder_5.Commit();
            var State_Output_8 = this.__p_Qvc3vTFSBClPVAsB9k510J.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J_6, Id_In: Id_In, Output_Out: out n5.FunctionInvokeNode<n22.Vector2> Output_7);
            Output_Out = Output_7;
            n52.Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = State_Output_4 != this.__p_PFSb02iEJm1Ny0BHJgn3ze || __pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J_6 != this.__pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J || State_Output_8 != this.__p_Qvc3vTFSBClPVAsB9k510J ? new Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk(this)
                {__p_PFSb02iEJm1Ny0BHJgn3ze = State_Output_4, __pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J = __pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J_6, __p_Qvc3vTFSBClPVAsB9k510J = State_Output_8} : that_9;
            else
            {
                this.__p_PFSb02iEJm1Ny0BHJgn3ze = State_Output_4;
                this.__pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J = __pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J_6;
                this.__p_Qvc3vTFSBClPVAsB9k510J = State_Output_8;
            }

            return that_9;
        }

        public n52.Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "Qvc3vTFSBClPVAsB9k510J", 354603U);
            var Output_1 = n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<n22.Vector2>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "PFSb02iEJm1Ny0BHJgn3ze", 354633U);
            var Output_3 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.Create(Node_Context: Node_Context_2);
            n52.Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk that_4 = this;
            this.__pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J = n17._Operations_.CreateDefault<n5.AbstractGpuValue>();
            this.__p_Qvc3vTFSBClPVAsB9k510J = Output_1;
            this.__p_PFSb02iEJm1Ny0BHJgn3ze = Output_3;
            return that_4;
        }

        public n52.Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk __CreateDefault__()
        {
            n52.Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk that_0 = this;
            this.__pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J = n17._Operations_.CreateDefault<n5.AbstractGpuValue>();
            this.__p_PFSb02iEJm1Ny0BHJgn3ze = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2>.CreateDefault();
            this.__p_Qvc3vTFSBClPVAsB9k510J = n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<n22.Vector2>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_PFSb02iEJm1Ny0BHJgn3ze);
            n1.CompilationHelper.SafeDispose(this.__p_Qvc3vTFSBClPVAsB9k510J);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 354633U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "PFSb02iEJm1Ny0BHJgn3ze", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
        public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_PFSb02iEJm1Ny0BHJgn3ze;
        [n1.ElementAttribute(TracingId = 354603U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "Qvc3vTFSBClPVAsB9k510J", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
        public n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<n22.Vector2> __p_Qvc3vTFSBClPVAsB9k510J;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n11.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J = default(n11.Spread<n5.AbstractGpuValue>);
        public Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk(Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk other): base(other)
        {
            this.__p_PFSb02iEJm1Ny0BHJgn3ze = other.__p_PFSb02iEJm1Ny0BHJgn3ze;
            this.__p_Qvc3vTFSBClPVAsB9k510J = other.__p_Qvc3vTFSBClPVAsB9k510J;
            this.__pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J = other.__pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_PFSb02iEJm1Ny0BHJgn3ze", in __p_PFSb02iEJm1Ny0BHJgn3ze), n1.CompilationHelper.GetValueOrExisting(values, "__p_Qvc3vTFSBClPVAsB9k510J", in __p_Qvc3vTFSBClPVAsB9k510J), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J", in __pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J));
        }

        internal Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk __WITH__(n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector2> __p_PFSb02iEJm1Ny0BHJgn3ze, n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<n22.Vector2> __p_Qvc3vTFSBClPVAsB9k510J, n11.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J)
        {
            n52.Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_PFSb02iEJm1Ny0BHJgn3ze != this.__p_PFSb02iEJm1Ny0BHJgn3ze || __p_Qvc3vTFSBClPVAsB9k510J != this.__p_Qvc3vTFSBClPVAsB9k510J || __pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J != this.__pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J ? new Function__2D_Vector_Function_LYpmOyjyUhSNRTp3F2Zoxk(this)
                {__p_PFSb02iEJm1Ny0BHJgn3ze = __p_PFSb02iEJm1Ny0BHJgn3ze, __p_Qvc3vTFSBClPVAsB9k510J = __p_Qvc3vTFSBClPVAsB9k510J, __pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J = __pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J} : that_0;
            else
            {
                this.__p_PFSb02iEJm1Ny0BHJgn3ze = __p_PFSb02iEJm1Ny0BHJgn3ze;
                this.__p_Qvc3vTFSBClPVAsB9k510J = __p_Qvc3vTFSBClPVAsB9k510J;
                this.__pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J = __pin_group_Parameters_In_Qvc3vTFSBClPVAsB9k510J;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 354717U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "JYq8UCcq2ZsPYR2sKjojVy", Name = "FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy")]
    [n2.SerializableAttribute]
    public class FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n52.FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy Create(n1.NodeContext Node_Context)
        {
            var instance = new FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n52.FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy CreateDefault()
        {
            var instance = new FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n52.FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy Update(n5.GpuValue<n22.Vector3> The_Override_In, out n5.GpuValue<n22.Vector3> Output_Out)
        {
            int Id_0 = 0;
            var State_Output_2 = this.__p_QtSlmTiCF75LF08ITkSjs5.Update(The_Override_In: The_Override_In, Id_In: Id_0, Output_Out: out n5.GpuValue<n22.Vector3> Output_1);
            Output_Out = Output_1;
            n52.FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = State_Output_2 != this.__p_QtSlmTiCF75LF08ITkSjs5 ? new FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy(this)
                {__p_QtSlmTiCF75LF08ITkSjs5 = State_Output_2} : that_3;
            else
            {
                this.__p_QtSlmTiCF75LF08ITkSjs5 = State_Output_2;
            }

            return that_3;
        }

        public n52.FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "QtSlmTiCF75LF08ITkSjs5", 354725U);
            var Output_1 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3>.Create(Node_Context: Node_Context_0);
            n52.FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy that_2 = this;
            this.__p_QtSlmTiCF75LF08ITkSjs5 = Output_1;
            return that_2;
        }

        public n52.FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy __CreateDefault__()
        {
            n52.FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy that_0 = this;
            this.__p_QtSlmTiCF75LF08ITkSjs5 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_QtSlmTiCF75LF08ITkSjs5);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 354725U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "QtSlmTiCF75LF08ITkSjs5", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
        public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_QtSlmTiCF75LF08ITkSjs5;
        public FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy(FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy other): base(other)
        {
            this.__p_QtSlmTiCF75LF08ITkSjs5 = other.__p_QtSlmTiCF75LF08ITkSjs5;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QtSlmTiCF75LF08ITkSjs5", in __p_QtSlmTiCF75LF08ITkSjs5));
        }

        internal FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy __WITH__(n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_QtSlmTiCF75LF08ITkSjs5)
        {
            n52.FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_QtSlmTiCF75LF08ITkSjs5 != this.__p_QtSlmTiCF75LF08ITkSjs5 ? new FunctionParameter__3D_Vector_Function_JYq8UCcq2ZsPYR2sKjojVy(this)
                {__p_QtSlmTiCF75LF08ITkSjs5 = __p_QtSlmTiCF75LF08ITkSjs5} : that_0;
            else
            {
                this.__p_QtSlmTiCF75LF08ITkSjs5 = __p_QtSlmTiCF75LF08ITkSjs5;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 354824U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "HZXyLpLnmO5MVRUehP0SSG", Name = "Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG")]
    [n2.SerializableAttribute]
    public class Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n52.Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG Create(n1.NodeContext Node_Context)
        {
            var instance = new Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n52.Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG CreateDefault()
        {
            var instance = new Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n52.Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG Update(n5.GpuValue<n22.Vector3> Function_In, [n4.SerializedDefaultValueAttribute("Float3_To_Float3_Function", false)] string Id_In, out n5.FunctionInvokeNode<n22.Vector3> Output_Out)
        {
            n5.GpuValue<n22.Vector3> Input_0 = default(n5.GpuValue<n22.Vector3>);
            n42._Operations_.TypeVector3(Input_In: Input_0, Output_Out: out n5.GpuValue<n22.Vector3> Output_1);
            int Id_2 = 0;
            var State_Output_4 = this.__p_SPbRxcGJhq9PKC7N6eNh1m.Update(The_Override_In: Output_1, Id_In: Id_2, Output_Out: out n5.GpuValue<n22.Vector3> Output_3);
            var builder_5 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes, 1);
            builder_5.Add(Output_3);
            var __pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes_6 = builder_5.Commit();
            var State_Output_8 = this.__p_US2OwyLkL9JMZVXKCouoes.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes_6, Id_In: Id_In, Output_Out: out n5.FunctionInvokeNode<n22.Vector3> Output_7);
            Output_Out = Output_7;
            n52.Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = State_Output_4 != this.__p_SPbRxcGJhq9PKC7N6eNh1m || __pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes_6 != this.__pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes || State_Output_8 != this.__p_US2OwyLkL9JMZVXKCouoes ? new Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG(this)
                {__p_SPbRxcGJhq9PKC7N6eNh1m = State_Output_4, __pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes = __pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes_6, __p_US2OwyLkL9JMZVXKCouoes = State_Output_8} : that_9;
            else
            {
                this.__p_SPbRxcGJhq9PKC7N6eNh1m = State_Output_4;
                this.__pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes = __pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes_6;
                this.__p_US2OwyLkL9JMZVXKCouoes = State_Output_8;
            }

            return that_9;
        }

        public n52.Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "US2OwyLkL9JMZVXKCouoes", 354828U);
            var Output_1 = n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<n22.Vector3>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("MzilLTk6yNROg5SWTCtzZM", "SPbRxcGJhq9PKC7N6eNh1m", 354880U);
            var Output_3 = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3>.Create(Node_Context: Node_Context_2);
            n52.Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG that_4 = this;
            this.__pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes = n17._Operations_.CreateDefault<n5.AbstractGpuValue>();
            this.__p_US2OwyLkL9JMZVXKCouoes = Output_1;
            this.__p_SPbRxcGJhq9PKC7N6eNh1m = Output_3;
            return that_4;
        }

        public n52.Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG __CreateDefault__()
        {
            n52.Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG that_0 = this;
            this.__pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes = n17._Operations_.CreateDefault<n5.AbstractGpuValue>();
            this.__p_SPbRxcGJhq9PKC7N6eNh1m = n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3>.CreateDefault();
            this.__p_US2OwyLkL9JMZVXKCouoes = n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<n22.Vector3>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SPbRxcGJhq9PKC7N6eNh1m);
            n1.CompilationHelper.SafeDispose(this.__p_US2OwyLkL9JMZVXKCouoes);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 354880U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "SPbRxcGJhq9PKC7N6eNh1m", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
        public n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_SPbRxcGJhq9PKC7N6eNh1m;
        [n1.ElementAttribute(TracingId = 354828U, DocumentId = "MzilLTk6yNROg5SWTCtzZM", PersistentId = "US2OwyLkL9JMZVXKCouoes", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
        public n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<n22.Vector3> __p_US2OwyLkL9JMZVXKCouoes;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n11.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes = default(n11.Spread<n5.AbstractGpuValue>);
        public Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG(Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG other): base(other)
        {
            this.__p_SPbRxcGJhq9PKC7N6eNh1m = other.__p_SPbRxcGJhq9PKC7N6eNh1m;
            this.__p_US2OwyLkL9JMZVXKCouoes = other.__p_US2OwyLkL9JMZVXKCouoes;
            this.__pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes = other.__pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_SPbRxcGJhq9PKC7N6eNh1m", in __p_SPbRxcGJhq9PKC7N6eNh1m), n1.CompilationHelper.GetValueOrExisting(values, "__p_US2OwyLkL9JMZVXKCouoes", in __p_US2OwyLkL9JMZVXKCouoes), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes", in __pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes));
        }

        internal Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG __WITH__(n21.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n22.Vector3> __p_SPbRxcGJhq9PKC7N6eNh1m, n21.Function_IubJYJ2Zy72PGqdBGy0rgZ<n22.Vector3> __p_US2OwyLkL9JMZVXKCouoes, n11.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes)
        {
            n52.Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_SPbRxcGJhq9PKC7N6eNh1m != this.__p_SPbRxcGJhq9PKC7N6eNh1m || __p_US2OwyLkL9JMZVXKCouoes != this.__p_US2OwyLkL9JMZVXKCouoes || __pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes != this.__pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes ? new Function__3D_Vector_Function_HZXyLpLnmO5MVRUehP0SSG(this)
                {__p_SPbRxcGJhq9PKC7N6eNh1m = __p_SPbRxcGJhq9PKC7N6eNh1m, __p_US2OwyLkL9JMZVXKCouoes = __p_US2OwyLkL9JMZVXKCouoes, __pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes = __pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes} : that_0;
            else
            {
                this.__p_SPbRxcGJhq9PKC7N6eNh1m = __p_SPbRxcGJhq9PKC7N6eNh1m;
                this.__p_US2OwyLkL9JMZVXKCouoes = __p_US2OwyLkL9JMZVXKCouoes;
                this.__pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes = __pin_group_Parameters_In_US2OwyLkL9JMZVXKCouoes;
            }

            return that_0;
        }
    }
}

namespace _Fuse_Core_Domain_
{
    public struct __AdaptiveImplementations__MzilLTk6yNROg5SWTCtzZM : n54.IAdaptiveCreateDefault<string>, n54.IAdaptiveCreateDefault<n5.GpuValue<float>>, n54.IAdaptiveCreateDefault<n5.GpuValue<n22.Vector2>>
    {
        public void CreateDefault(out string Output_Out)
        {
            var Empty_0 = n45._Operations_.CreateDefault();
            Output_Out = Empty_0;
            return;
        }

        public void CreateDefault(out n5.GpuValue<float> Output_Out)
        {
            n53._Operations_.CreateDefault_Generic<n5.GpuValue<float>>(Output_Out: out n5.GpuValue<float> Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n5.GpuValue<n22.Vector2> Output_Out)
        {
            n53._Operations_.CreateDefault_Generic<n5.GpuValue<n22.Vector2>>(Output_Out: out n5.GpuValue<n22.Vector2> Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}