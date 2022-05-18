extern alias e3;
extern alias e2;
extern alias e71;
extern alias e4;

using n10 = e2::VL.Lib.Collections;
using n6 = e3::VL.Lib.Primitive.CacheRegion;
using n23 = _CoreLibBasics_.Control;
using n30 = _VL_Collections_.Collections.Dictionary;
using n31 = global::System.Collections.Immutable;
using n5 = e71::Fuse;
using n13 = global::System.Collections.Generic;
using n28 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n21 = e71::Fuse.Core.Color;
using n9 = _Fuse_Core_Math_.Fuse.Core.Math;
using n22 = _Fuse_Core_Color_;
using n25 = _Fuse_Core_.Fuse.Core.Join;
using n20 = e3::VL.Lib.Primitive;
using n27 = e2::VL.Lib.Runtime;
using n17 = _Fuse_Core_Color_.Fuse.Core.Color.Internal;
using n1 = e2::VL.Core;
using n7 = _Fuse_Core_.Fuse.Core.Value;
using n2 = global::System;
using n15 = e4::Stride.Core.Mathematics;
using n24 = e3::VL.Lib.Color;
using n14 = _Fuse_Core_.Fuse.Core.Control;
using n26 = _CoreLibBasics_.Color.RGBA;
using n19 = e3::VL.Lib.Primitive.Object;
using n8 = _Fuse_Core_.Fuse.Core.Swizzle;
using n4 = e2::VL.Core.CompilerServices;
using n3 = _Fuse_Core_Color_.Fuse.Core.Color;
using n16 = _Fuse_Core_.Fuse.Core.Implementation;
using n29 = _Fuse_Core_.Fuse.Core.Util;
using n18 = _VL_Collections_.Collections.Sequence;
using n12 = global::System.Runtime.CompilerServices;
using n11 = _VL_Collections_.Collections.Spread;
using n32 = _CoreLibBasics_.Primitive.Advanced;

namespace _Fuse_Core_Color_.Fuse.Core.Color
{
    [n1.ElementAttribute(TracingId = 331359U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "BkAjVtONmRBQDOSVPJwDgP", Name = "Brightness_BkAjVtONmRBQDOSVPJwDgP")]
    [n2.SerializableAttribute]
    public class Brightness_BkAjVtONmRBQDOSVPJwDgP<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Brightness_BkAjVtONmRBQDOSVPJwDgP<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> CreateDefault()
        {
            var instance = new Brightness_BkAjVtONmRBQDOSVPJwDgP<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> Update(n5.GpuValue<T> Input_In, out n5.GpuValue<float> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_SGeUQyFaCUoMXFmIyczp5e;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<float>>>(n2.ValueTuple.Create(default(n5.GpuValue<float>)));
            }

            var inputs_3 = n2.ValueTuple.Create(Input_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__JGEsKkIjcvIOAmbyV42Qbo>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __JGEsKkIjcvIOAmbyV42Qbo(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u = n11._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m = n11._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK = n11._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh = n11._Operations_.CreateDefault<n5.GpuValue<float>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "MjHZTvQmJECNHIumdi7P4O", 331384U);
                    var Output_8 = n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float>.Create(Node_Context: Node_Context_7);
                    state_6.__p_MjHZTvQmJECNHIumdi7P4O = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Mk0Hm3rDHzbMzTPA9EVOhF", 331402U);
                    var Output_10 = n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float>.Create(Node_Context: Node_Context_9);
                    state_6.__p_Mk0Hm3rDHzbMzTPA9EVOhF = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "PoFgi1Q1KxGNhIns8djieN", 331411U);
                    var Output_12 = n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float>.Create(Node_Context: Node_Context_11);
                    state_6.__p_PoFgi1Q1KxGNhIns8djieN = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "MqbcB5YxG2BPcZzG3MQjJi", 331429U);
                    var Output_14 = n8.x_CThKQPdF8roMfrpnCR01ll<T>.Create(Node_Context: Node_Context_13);
                    state_6.__p_MqbcB5YxG2BPcZzG3MQjJi = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "EIQ2of20F7LLjXxVggUVXE", 331439U);
                    var Output_16 = n8.y_EqOmImsLEfKMwPNqId2m1L<T>.Create(Node_Context: Node_Context_15);
                    state_6.__p_EIQ2of20F7LLjXxVggUVXE = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "G7X6wqdiiA7OrigAmVw1Bx", 331452U);
                    var Output_18 = n8.z_EOvTnjQku9NNwhiVmmQpmT<T>.Create(Node_Context: Node_Context_17);
                    state_6.__p_G7X6wqdiiA7OrigAmVw1Bx = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "KWuQCOAVij1Od5PPpkEMdh", 331462U);
                    var Output_20 = n9.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float>.Create(Node_Context: Node_Context_19);
                    state_6.__p_KWuQCOAVij1Od5PPpkEMdh = Output_20;
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "AOiWYyW3e7aOaJAmDt3KhK", 331471U);
                    var Output_22 = n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_21);
                    state_6.__p_AOiWYyW3e7aOaJAmDt3KhK = Output_22;
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "RfioK8lcwhhMq9w3Iakz9m", 331483U);
                    var Output_24 = n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_23);
                    state_6.__p_RfioK8lcwhhMq9w3Iakz9m = Output_24;
                    n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "AZ3QiiAQtw3NrXntBhGA7u", 331499U);
                    var Output_26 = n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_25);
                    state_6.__p_AZ3QiiAQtw3NrXntBhGA7u = Output_26;
                }

                float __pad_NHPR9t63kbmLoe9IyE1CaQ_27 = __slot_NHPR9t63kbmLoe9IyE1CaQ;
                float __pad_VhOAdZCG7R0NeYAo3YfOG0_28 = __slot_VhOAdZCG7R0NeYAo3YfOG0;
                float __pad_VY28xLSsg6aPC11BP4KZO2_29 = __slot_VY28xLSsg6aPC11BP4KZO2;
                var State_Output_31 = state_6.__p_MjHZTvQmJECNHIumdi7P4O.Update(The_Value_In: __pad_NHPR9t63kbmLoe9IyE1CaQ_27, Output_Out: out n5.ConstantValue<float> Output_30);
                var State_Output_33 = state_6.__p_MqbcB5YxG2BPcZzG3MQjJi.Update(Input_In: Input_In, Output_Out: out n5.GpuValue<float> Output_32);
                var builder_34 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u, 2);
                builder_34.Add(Output_32);
                builder_34.Add(Output_30);
                var __pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u_35 = builder_34.Commit();
                var State_Output_37 = state_6.__p_AZ3QiiAQtw3NrXntBhGA7u.Update(Input_In: __pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u_35, Output_Out: out n5.GpuValue<float> Output_36);
                var State_Output_39 = state_6.__p_EIQ2of20F7LLjXxVggUVXE.Update(Input_In: Input_In, Output_Out: out n5.GpuValue<float> Output_38);
                var State_Output_41 = state_6.__p_Mk0Hm3rDHzbMzTPA9EVOhF.Update(The_Value_In: __pad_VhOAdZCG7R0NeYAo3YfOG0_28, Output_Out: out n5.ConstantValue<float> Output_40);
                var builder_42 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m, 2);
                builder_42.Add(Output_38);
                builder_42.Add(Output_40);
                var __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m_43 = builder_42.Commit();
                var State_Output_45 = state_6.__p_RfioK8lcwhhMq9w3Iakz9m.Update(Input_In: __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m_43, Output_Out: out n5.GpuValue<float> Output_44);
                var State_Output_47 = state_6.__p_G7X6wqdiiA7OrigAmVw1Bx.Update(Input_In: Input_In, Output_Out: out n5.GpuValue<float> Output_46);
                var State_Output_49 = state_6.__p_PoFgi1Q1KxGNhIns8djieN.Update(The_Value_In: __pad_VY28xLSsg6aPC11BP4KZO2_29, Output_Out: out n5.ConstantValue<float> Output_48);
                var builder_50 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK, 2);
                builder_50.Add(Output_46);
                builder_50.Add(Output_48);
                var __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK_51 = builder_50.Commit();
                var State_Output_53 = state_6.__p_AOiWYyW3e7aOaJAmDt3KhK.Update(Input_In: __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK_51, Output_Out: out n5.GpuValue<float> Output_52);
                var builder_54 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh, 3);
                builder_54.Add(Output_36);
                builder_54.Add(Output_44);
                builder_54.Add(Output_52);
                var __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh_55 = builder_54.Commit();
                var State_Output_57 = state_6.__p_KWuQCOAVij1Od5PPpkEMdh.Update(Input_In: __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh_55, Output_Out: out n5.GpuValue<float> Output_56);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_31 != state_6.__p_MjHZTvQmJECNHIumdi7P4O || State_Output_33 != state_6.__p_MqbcB5YxG2BPcZzG3MQjJi || __pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u_35 != state_6.__pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u || State_Output_37 != state_6.__p_AZ3QiiAQtw3NrXntBhGA7u || State_Output_39 != state_6.__p_EIQ2of20F7LLjXxVggUVXE || State_Output_41 != state_6.__p_Mk0Hm3rDHzbMzTPA9EVOhF || __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m_43 != state_6.__pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m || State_Output_45 != state_6.__p_RfioK8lcwhhMq9w3Iakz9m || State_Output_47 != state_6.__p_G7X6wqdiiA7OrigAmVw1Bx || State_Output_49 != state_6.__p_PoFgi1Q1KxGNhIns8djieN || __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK_51 != state_6.__pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK || State_Output_53 != state_6.__p_AOiWYyW3e7aOaJAmDt3KhK || __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh_55 != state_6.__pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh || State_Output_57 != state_6.__p_KWuQCOAVij1Od5PPpkEMdh ? new __JGEsKkIjcvIOAmbyV42Qbo(state_6)
                    {__p_MjHZTvQmJECNHIumdi7P4O = State_Output_31, __p_MqbcB5YxG2BPcZzG3MQjJi = State_Output_33, __pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u = __pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u_35, __p_AZ3QiiAQtw3NrXntBhGA7u = State_Output_37, __p_EIQ2of20F7LLjXxVggUVXE = State_Output_39, __p_Mk0Hm3rDHzbMzTPA9EVOhF = State_Output_41, __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m = __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m_43, __p_RfioK8lcwhhMq9w3Iakz9m = State_Output_45, __p_G7X6wqdiiA7OrigAmVw1Bx = State_Output_47, __p_PoFgi1Q1KxGNhIns8djieN = State_Output_49, __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK = __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK_51, __p_AOiWYyW3e7aOaJAmDt3KhK = State_Output_53, __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh = __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh_55, __p_KWuQCOAVij1Od5PPpkEMdh = State_Output_57} : state_6;
                else
                {
                    state_6.__p_MjHZTvQmJECNHIumdi7P4O = State_Output_31;
                    state_6.__p_MqbcB5YxG2BPcZzG3MQjJi = State_Output_33;
                    state_6.__pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u = __pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u_35;
                    state_6.__p_AZ3QiiAQtw3NrXntBhGA7u = State_Output_37;
                    state_6.__p_EIQ2of20F7LLjXxVggUVXE = State_Output_39;
                    state_6.__p_Mk0Hm3rDHzbMzTPA9EVOhF = State_Output_41;
                    state_6.__pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m = __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m_43;
                    state_6.__p_RfioK8lcwhhMq9w3Iakz9m = State_Output_45;
                    state_6.__p_G7X6wqdiiA7OrigAmVw1Bx = State_Output_47;
                    state_6.__p_PoFgi1Q1KxGNhIns8djieN = State_Output_49;
                    state_6.__pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK = __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK_51;
                    state_6.__p_AOiWYyW3e7aOaJAmDt3KhK = State_Output_53;
                    state_6.__pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh = __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh_55;
                    state_6.__p_KWuQCOAVij1Od5PPpkEMdh = State_Output_57;
                }

                outputs_4 = n2.ValueTuple.Create(Output_56);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_58 = outputs_4.Item1;
            Output_Out = __auto_58;
            n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> that_59 = this;
            if (this.__GetContext__().IsImmutable)
                that_59 = manager_2 != this.__cache_SGeUQyFaCUoMXFmIyczp5e ? new Brightness_BkAjVtONmRBQDOSVPJwDgP<T>(this)
                {__cache_SGeUQyFaCUoMXFmIyczp5e = manager_2} : that_59;
            else
            {
                this.__cache_SGeUQyFaCUoMXFmIyczp5e = manager_2;
            }

            return that_59;
        }

        public n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> that_0 = this;
            this.__cache_SGeUQyFaCUoMXFmIyczp5e = null;
            return that_0;
        }

        public n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> __CreateDefault__()
        {
            n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> that_0 = this;
            this.__cache_SGeUQyFaCUoMXFmIyczp5e = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_SGeUQyFaCUoMXFmIyczp5e);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 331516U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "TJDTJEzWTh6Ogf1lJTnOcQ", Name = "__slot_TJDTJEzWTh6Ogf1lJTnOcQ")]
        public static string __slot_TJDTJEzWTh6Ogf1lJTnOcQ = "l = color.r * 0.3 + color.g * 0.59 + color.b * 0.11";
        [n1.ElementAttribute(TracingId = 331367U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "SGeUQyFaCUoMXFmIyczp5e", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<float>>> __cache_SGeUQyFaCUoMXFmIyczp5e = null;
        [n1.ElementAttribute(TracingId = 331398U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "NHPR9t63kbmLoe9IyE1CaQ", Name = "__slot_NHPR9t63kbmLoe9IyE1CaQ")]
        public static float __slot_NHPR9t63kbmLoe9IyE1CaQ = 0.3F;
        [n1.ElementAttribute(TracingId = 331410U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "VhOAdZCG7R0NeYAo3YfOG0", Name = "__slot_VhOAdZCG7R0NeYAo3YfOG0")]
        public static float __slot_VhOAdZCG7R0NeYAo3YfOG0 = 0.59F;
        [n1.ElementAttribute(TracingId = 331422U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "VY28xLSsg6aPC11BP4KZO2", Name = "__slot_VY28xLSsg6aPC11BP4KZO2")]
        public static float __slot_VY28xLSsg6aPC11BP4KZO2 = 0.11F;
        static Brightness_BkAjVtONmRBQDOSVPJwDgP()
        {
        }

        public Brightness_BkAjVtONmRBQDOSVPJwDgP(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Brightness_BkAjVtONmRBQDOSVPJwDgP(Brightness_BkAjVtONmRBQDOSVPJwDgP<T> other): base(other)
        {
            this.__cache_SGeUQyFaCUoMXFmIyczp5e = other.__cache_SGeUQyFaCUoMXFmIyczp5e;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_SGeUQyFaCUoMXFmIyczp5e", in __cache_SGeUQyFaCUoMXFmIyczp5e));
        }

        internal Brightness_BkAjVtONmRBQDOSVPJwDgP<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<float>>> __cache_SGeUQyFaCUoMXFmIyczp5e)
        {
            n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_SGeUQyFaCUoMXFmIyczp5e != this.__cache_SGeUQyFaCUoMXFmIyczp5e ? new Brightness_BkAjVtONmRBQDOSVPJwDgP<T>(this)
                {__cache_SGeUQyFaCUoMXFmIyczp5e = __cache_SGeUQyFaCUoMXFmIyczp5e} : that_0;
            else
            {
                this.__cache_SGeUQyFaCUoMXFmIyczp5e = __cache_SGeUQyFaCUoMXFmIyczp5e;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "JGEsKkIjcvIOAmbyV42Qbo", Name = "__JGEsKkIjcvIOAmbyV42Qbo")]
        [n2.SerializableAttribute]
        public class __JGEsKkIjcvIOAmbyV42Qbo : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_MjHZTvQmJECNHIumdi7P4O);
                n1.CompilationHelper.SafeDispose(this.__p_Mk0Hm3rDHzbMzTPA9EVOhF);
                n1.CompilationHelper.SafeDispose(this.__p_PoFgi1Q1KxGNhIns8djieN);
                n1.CompilationHelper.SafeDispose(this.__p_MqbcB5YxG2BPcZzG3MQjJi);
                n1.CompilationHelper.SafeDispose(this.__p_EIQ2of20F7LLjXxVggUVXE);
                n1.CompilationHelper.SafeDispose(this.__p_G7X6wqdiiA7OrigAmVw1Bx);
                n1.CompilationHelper.SafeDispose(this.__p_KWuQCOAVij1Od5PPpkEMdh);
                n1.CompilationHelper.SafeDispose(this.__p_AOiWYyW3e7aOaJAmDt3KhK);
                n1.CompilationHelper.SafeDispose(this.__p_RfioK8lcwhhMq9w3Iakz9m);
                n1.CompilationHelper.SafeDispose(this.__p_AZ3QiiAQtw3NrXntBhGA7u);
                return;
            }

            [n1.ElementAttribute(TracingId = 331384U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "MjHZTvQmJECNHIumdi7P4O", Name = "ConstantFromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_MjHZTvQmJECNHIumdi7P4O;
            [n1.ElementAttribute(TracingId = 331402U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Mk0Hm3rDHzbMzTPA9EVOhF", Name = "ConstantFromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_Mk0Hm3rDHzbMzTPA9EVOhF;
            [n1.ElementAttribute(TracingId = 331411U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "PoFgi1Q1KxGNhIns8djieN", Name = "ConstantFromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_PoFgi1Q1KxGNhIns8djieN;
            [n1.ElementAttribute(TracingId = 331429U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "MqbcB5YxG2BPcZzG3MQjJi", Name = "x", IsManaged = true, IsAutoGenerated = true)]
            public n8.x_CThKQPdF8roMfrpnCR01ll<T> __p_MqbcB5YxG2BPcZzG3MQjJi;
            [n1.ElementAttribute(TracingId = 331439U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "EIQ2of20F7LLjXxVggUVXE", Name = "y", IsManaged = true, IsAutoGenerated = true)]
            public n8.y_EqOmImsLEfKMwPNqId2m1L<T> __p_EIQ2of20F7LLjXxVggUVXE;
            [n1.ElementAttribute(TracingId = 331452U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "G7X6wqdiiA7OrigAmVw1Bx", Name = "z", IsManaged = true, IsAutoGenerated = true)]
            public n8.z_EOvTnjQku9NNwhiVmmQpmT<T> __p_G7X6wqdiiA7OrigAmVw1Bx;
            [n1.ElementAttribute(TracingId = 331462U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "KWuQCOAVij1Od5PPpkEMdh", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_KWuQCOAVij1Od5PPpkEMdh;
            [n1.ElementAttribute(TracingId = 331471U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "AOiWYyW3e7aOaJAmDt3KhK", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_AOiWYyW3e7aOaJAmDt3KhK;
            [n1.ElementAttribute(TracingId = 331483U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "RfioK8lcwhhMq9w3Iakz9m", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_RfioK8lcwhhMq9w3Iakz9m;
            [n1.ElementAttribute(TracingId = 331499U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "AZ3QiiAQtw3NrXntBhGA7u", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_AZ3QiiAQtw3NrXntBhGA7u;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u = default(n10.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m = default(n10.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK = default(n10.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh = default(n10.Spread<n5.GpuValue<float>>);
            public __JGEsKkIjcvIOAmbyV42Qbo(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __JGEsKkIjcvIOAmbyV42Qbo(__JGEsKkIjcvIOAmbyV42Qbo other): base(other)
            {
                this.__p_MjHZTvQmJECNHIumdi7P4O = other.__p_MjHZTvQmJECNHIumdi7P4O;
                this.__p_Mk0Hm3rDHzbMzTPA9EVOhF = other.__p_Mk0Hm3rDHzbMzTPA9EVOhF;
                this.__p_PoFgi1Q1KxGNhIns8djieN = other.__p_PoFgi1Q1KxGNhIns8djieN;
                this.__p_MqbcB5YxG2BPcZzG3MQjJi = other.__p_MqbcB5YxG2BPcZzG3MQjJi;
                this.__p_EIQ2of20F7LLjXxVggUVXE = other.__p_EIQ2of20F7LLjXxVggUVXE;
                this.__p_G7X6wqdiiA7OrigAmVw1Bx = other.__p_G7X6wqdiiA7OrigAmVw1Bx;
                this.__p_KWuQCOAVij1Od5PPpkEMdh = other.__p_KWuQCOAVij1Od5PPpkEMdh;
                this.__p_AOiWYyW3e7aOaJAmDt3KhK = other.__p_AOiWYyW3e7aOaJAmDt3KhK;
                this.__p_RfioK8lcwhhMq9w3Iakz9m = other.__p_RfioK8lcwhhMq9w3Iakz9m;
                this.__p_AZ3QiiAQtw3NrXntBhGA7u = other.__p_AZ3QiiAQtw3NrXntBhGA7u;
                this.__pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u = other.__pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u;
                this.__pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m = other.__pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m;
                this.__pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK = other.__pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK;
                this.__pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh = other.__pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MjHZTvQmJECNHIumdi7P4O", in __p_MjHZTvQmJECNHIumdi7P4O), n1.CompilationHelper.GetValueOrExisting(values, "__p_Mk0Hm3rDHzbMzTPA9EVOhF", in __p_Mk0Hm3rDHzbMzTPA9EVOhF), n1.CompilationHelper.GetValueOrExisting(values, "__p_PoFgi1Q1KxGNhIns8djieN", in __p_PoFgi1Q1KxGNhIns8djieN), n1.CompilationHelper.GetValueOrExisting(values, "__p_MqbcB5YxG2BPcZzG3MQjJi", in __p_MqbcB5YxG2BPcZzG3MQjJi), n1.CompilationHelper.GetValueOrExisting(values, "__p_EIQ2of20F7LLjXxVggUVXE", in __p_EIQ2of20F7LLjXxVggUVXE), n1.CompilationHelper.GetValueOrExisting(values, "__p_G7X6wqdiiA7OrigAmVw1Bx", in __p_G7X6wqdiiA7OrigAmVw1Bx), n1.CompilationHelper.GetValueOrExisting(values, "__p_KWuQCOAVij1Od5PPpkEMdh", in __p_KWuQCOAVij1Od5PPpkEMdh), n1.CompilationHelper.GetValueOrExisting(values, "__p_AOiWYyW3e7aOaJAmDt3KhK", in __p_AOiWYyW3e7aOaJAmDt3KhK), n1.CompilationHelper.GetValueOrExisting(values, "__p_RfioK8lcwhhMq9w3Iakz9m", in __p_RfioK8lcwhhMq9w3Iakz9m), n1.CompilationHelper.GetValueOrExisting(values, "__p_AZ3QiiAQtw3NrXntBhGA7u", in __p_AZ3QiiAQtw3NrXntBhGA7u), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u", in __pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m", in __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK", in __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh", in __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh));
            }

            internal __JGEsKkIjcvIOAmbyV42Qbo __WITH__(n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_MjHZTvQmJECNHIumdi7P4O, n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_Mk0Hm3rDHzbMzTPA9EVOhF, n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_PoFgi1Q1KxGNhIns8djieN, n8.x_CThKQPdF8roMfrpnCR01ll<T> __p_MqbcB5YxG2BPcZzG3MQjJi, n8.y_EqOmImsLEfKMwPNqId2m1L<T> __p_EIQ2of20F7LLjXxVggUVXE, n8.z_EOvTnjQku9NNwhiVmmQpmT<T> __p_G7X6wqdiiA7OrigAmVw1Bx, n9.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_KWuQCOAVij1Od5PPpkEMdh, n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_AOiWYyW3e7aOaJAmDt3KhK, n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_RfioK8lcwhhMq9w3Iakz9m, n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_AZ3QiiAQtw3NrXntBhGA7u, n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u, n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m, n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK, n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh)
            {
                __JGEsKkIjcvIOAmbyV42Qbo that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_MjHZTvQmJECNHIumdi7P4O != this.__p_MjHZTvQmJECNHIumdi7P4O || __p_Mk0Hm3rDHzbMzTPA9EVOhF != this.__p_Mk0Hm3rDHzbMzTPA9EVOhF || __p_PoFgi1Q1KxGNhIns8djieN != this.__p_PoFgi1Q1KxGNhIns8djieN || __p_MqbcB5YxG2BPcZzG3MQjJi != this.__p_MqbcB5YxG2BPcZzG3MQjJi || __p_EIQ2of20F7LLjXxVggUVXE != this.__p_EIQ2of20F7LLjXxVggUVXE || __p_G7X6wqdiiA7OrigAmVw1Bx != this.__p_G7X6wqdiiA7OrigAmVw1Bx || __p_KWuQCOAVij1Od5PPpkEMdh != this.__p_KWuQCOAVij1Od5PPpkEMdh || __p_AOiWYyW3e7aOaJAmDt3KhK != this.__p_AOiWYyW3e7aOaJAmDt3KhK || __p_RfioK8lcwhhMq9w3Iakz9m != this.__p_RfioK8lcwhhMq9w3Iakz9m || __p_AZ3QiiAQtw3NrXntBhGA7u != this.__p_AZ3QiiAQtw3NrXntBhGA7u || __pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u != this.__pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u || __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m != this.__pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m || __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK != this.__pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK || __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh != this.__pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh ? new __JGEsKkIjcvIOAmbyV42Qbo(this)
                    {__p_MjHZTvQmJECNHIumdi7P4O = __p_MjHZTvQmJECNHIumdi7P4O, __p_Mk0Hm3rDHzbMzTPA9EVOhF = __p_Mk0Hm3rDHzbMzTPA9EVOhF, __p_PoFgi1Q1KxGNhIns8djieN = __p_PoFgi1Q1KxGNhIns8djieN, __p_MqbcB5YxG2BPcZzG3MQjJi = __p_MqbcB5YxG2BPcZzG3MQjJi, __p_EIQ2of20F7LLjXxVggUVXE = __p_EIQ2of20F7LLjXxVggUVXE, __p_G7X6wqdiiA7OrigAmVw1Bx = __p_G7X6wqdiiA7OrigAmVw1Bx, __p_KWuQCOAVij1Od5PPpkEMdh = __p_KWuQCOAVij1Od5PPpkEMdh, __p_AOiWYyW3e7aOaJAmDt3KhK = __p_AOiWYyW3e7aOaJAmDt3KhK, __p_RfioK8lcwhhMq9w3Iakz9m = __p_RfioK8lcwhhMq9w3Iakz9m, __p_AZ3QiiAQtw3NrXntBhGA7u = __p_AZ3QiiAQtw3NrXntBhGA7u, __pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u = __pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u, __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m = __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m, __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK = __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK, __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh = __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh} : that_0;
                else
                {
                    this.__p_MjHZTvQmJECNHIumdi7P4O = __p_MjHZTvQmJECNHIumdi7P4O;
                    this.__p_Mk0Hm3rDHzbMzTPA9EVOhF = __p_Mk0Hm3rDHzbMzTPA9EVOhF;
                    this.__p_PoFgi1Q1KxGNhIns8djieN = __p_PoFgi1Q1KxGNhIns8djieN;
                    this.__p_MqbcB5YxG2BPcZzG3MQjJi = __p_MqbcB5YxG2BPcZzG3MQjJi;
                    this.__p_EIQ2of20F7LLjXxVggUVXE = __p_EIQ2of20F7LLjXxVggUVXE;
                    this.__p_G7X6wqdiiA7OrigAmVw1Bx = __p_G7X6wqdiiA7OrigAmVw1Bx;
                    this.__p_KWuQCOAVij1Od5PPpkEMdh = __p_KWuQCOAVij1Od5PPpkEMdh;
                    this.__p_AOiWYyW3e7aOaJAmDt3KhK = __p_AOiWYyW3e7aOaJAmDt3KhK;
                    this.__p_RfioK8lcwhhMq9w3Iakz9m = __p_RfioK8lcwhhMq9w3Iakz9m;
                    this.__p_AZ3QiiAQtw3NrXntBhGA7u = __p_AZ3QiiAQtw3NrXntBhGA7u;
                    this.__pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u = __pin_group_Input_In_AZ3QiiAQtw3NrXntBhGA7u;
                    this.__pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m = __pin_group_Input_In_RfioK8lcwhhMq9w3Iakz9m;
                    this.__pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK = __pin_group_Input_In_AOiWYyW3e7aOaJAmDt3KhK;
                    this.__pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh = __pin_group_Input_In_KWuQCOAVij1Od5PPpkEMdh;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 331592U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "SRiplej3RW2Na8vZfQuoGk", Name = "Darker_SRiplej3RW2Na8vZfQuoGk")]
    [n2.SerializableAttribute]
    public class Darker_SRiplej3RW2Na8vZfQuoGk<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Darker_SRiplej3RW2Na8vZfQuoGk<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Darker_SRiplej3RW2Na8vZfQuoGk<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Darker_SRiplej3RW2Na8vZfQuoGk<T> CreateDefault()
        {
            var instance = new Darker_SRiplej3RW2Na8vZfQuoGk<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Darker_SRiplej3RW2Na8vZfQuoGk<T> Update(n5.GpuValue<T> Intput_In, n5.GpuValue<T> Input_2_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_KCvUVm2ONK0LNPVfLMf8kM;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Intput_In, Input_2_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__Appdx6u0WFAOPoSFpWA9t3>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __Appdx6u0WFAOPoSFpWA9t3(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Kps2T6tSk9uQQJXxLd7DOG", 331620U);
                    var Output_8 = n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_Kps2T6tSk9uQQJXxLd7DOG = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Sz3tfkoFYonLMCk6avJZ1h", 331628U);
                    var Output_10 = n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_Sz3tfkoFYonLMCk6avJZ1h = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "EebJGeo16NmMnxyn2dahuz", 331635U);
                    var Output_12 = n14.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float>.Create(Node_Context: Node_Context_11);
                    state_6.__p_EebJGeo16NmMnxyn2dahuz = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "HWc8QDQcPV1PLbwEi2zmbP", 331644U);
                    var Output_14 = n14.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<T>.Create(Node_Context: Node_Context_13);
                    state_6.__p_HWc8QDQcPV1PLbwEi2zmbP = Output_14;
                }

                var State_Output_16 = state_6.__p_Kps2T6tSk9uQQJXxLd7DOG.Update(Input_In: Intput_In, Output_Out: out n5.GpuValue<float> Output_15);
                var State_Output_18 = state_6.__p_Sz3tfkoFYonLMCk6avJZ1h.Update(Input_In: Input_2_In, Output_Out: out n5.GpuValue<float> Output_17);
                var Output_20 = state_6.__p_EebJGeo16NmMnxyn2dahuz.Update(x_In: Output_15, y_In: Output_17, value_Out: out n5.GpuValue<bool> value_19);
                n5.GpuValue<T> The_Default_21 = default(n5.GpuValue<T>);
                var State_Output_23 = state_6.__p_HWc8QDQcPV1PLbwEi2zmbP.Update(In_Check_In: value_19, In_False_In: Input_2_In, In_True_In: Intput_In, The_Default_In: The_Default_21, Output_Out: out n5.GpuValue<T> Output_22);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_16 != state_6.__p_Kps2T6tSk9uQQJXxLd7DOG || State_Output_18 != state_6.__p_Sz3tfkoFYonLMCk6avJZ1h || Output_20 != state_6.__p_EebJGeo16NmMnxyn2dahuz || State_Output_23 != state_6.__p_HWc8QDQcPV1PLbwEi2zmbP ? new __Appdx6u0WFAOPoSFpWA9t3(state_6)
                    {__p_Kps2T6tSk9uQQJXxLd7DOG = State_Output_16, __p_Sz3tfkoFYonLMCk6avJZ1h = State_Output_18, __p_EebJGeo16NmMnxyn2dahuz = Output_20, __p_HWc8QDQcPV1PLbwEi2zmbP = State_Output_23} : state_6;
                else
                {
                    state_6.__p_Kps2T6tSk9uQQJXxLd7DOG = State_Output_16;
                    state_6.__p_Sz3tfkoFYonLMCk6avJZ1h = State_Output_18;
                    state_6.__p_EebJGeo16NmMnxyn2dahuz = Output_20;
                    state_6.__p_HWc8QDQcPV1PLbwEi2zmbP = State_Output_23;
                }

                outputs_4 = n2.ValueTuple.Create(Output_22);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_24 = outputs_4.Item1;
            Output_Out = __auto_24;
            n3.Darker_SRiplej3RW2Na8vZfQuoGk<T> that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = manager_2 != this.__cache_KCvUVm2ONK0LNPVfLMf8kM ? new Darker_SRiplej3RW2Na8vZfQuoGk<T>(this)
                {__cache_KCvUVm2ONK0LNPVfLMf8kM = manager_2} : that_25;
            else
            {
                this.__cache_KCvUVm2ONK0LNPVfLMf8kM = manager_2;
            }

            return that_25;
        }

        public n3.Darker_SRiplej3RW2Na8vZfQuoGk<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Darker_SRiplej3RW2Na8vZfQuoGk<T> that_0 = this;
            this.__cache_KCvUVm2ONK0LNPVfLMf8kM = null;
            return that_0;
        }

        public n3.Darker_SRiplej3RW2Na8vZfQuoGk<T> __CreateDefault__()
        {
            n3.Darker_SRiplej3RW2Na8vZfQuoGk<T> that_0 = this;
            this.__cache_KCvUVm2ONK0LNPVfLMf8kM = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_KCvUVm2ONK0LNPVfLMf8kM);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 331601U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "KCvUVm2ONK0LNPVfLMf8kM", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_KCvUVm2ONK0LNPVfLMf8kM = null;
        public Darker_SRiplej3RW2Na8vZfQuoGk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Darker_SRiplej3RW2Na8vZfQuoGk(Darker_SRiplej3RW2Na8vZfQuoGk<T> other): base(other)
        {
            this.__cache_KCvUVm2ONK0LNPVfLMf8kM = other.__cache_KCvUVm2ONK0LNPVfLMf8kM;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_KCvUVm2ONK0LNPVfLMf8kM", in __cache_KCvUVm2ONK0LNPVfLMf8kM));
        }

        internal Darker_SRiplej3RW2Na8vZfQuoGk<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_KCvUVm2ONK0LNPVfLMf8kM)
        {
            n3.Darker_SRiplej3RW2Na8vZfQuoGk<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_KCvUVm2ONK0LNPVfLMf8kM != this.__cache_KCvUVm2ONK0LNPVfLMf8kM ? new Darker_SRiplej3RW2Na8vZfQuoGk<T>(this)
                {__cache_KCvUVm2ONK0LNPVfLMf8kM = __cache_KCvUVm2ONK0LNPVfLMf8kM} : that_0;
            else
            {
                this.__cache_KCvUVm2ONK0LNPVfLMf8kM = __cache_KCvUVm2ONK0LNPVfLMf8kM;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Appdx6u0WFAOPoSFpWA9t3", Name = "__Appdx6u0WFAOPoSFpWA9t3")]
        [n2.SerializableAttribute]
        public class __Appdx6u0WFAOPoSFpWA9t3 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Kps2T6tSk9uQQJXxLd7DOG);
                n1.CompilationHelper.SafeDispose(this.__p_Sz3tfkoFYonLMCk6avJZ1h);
                n1.CompilationHelper.SafeDispose(this.__p_EebJGeo16NmMnxyn2dahuz);
                n1.CompilationHelper.SafeDispose(this.__p_HWc8QDQcPV1PLbwEi2zmbP);
                return;
            }

            [n1.ElementAttribute(TracingId = 331620U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Kps2T6tSk9uQQJXxLd7DOG", Name = "Brightness", IsManaged = true, IsAutoGenerated = true)]
            public n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> __p_Kps2T6tSk9uQQJXxLd7DOG;
            [n1.ElementAttribute(TracingId = 331628U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Sz3tfkoFYonLMCk6avJZ1h", Name = "Brightness", IsManaged = true, IsAutoGenerated = true)]
            public n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> __p_Sz3tfkoFYonLMCk6avJZ1h;
            [n1.ElementAttribute(TracingId = 331635U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "EebJGeo16NmMnxyn2dahuz", Name = "<", IsManaged = true, IsAutoGenerated = true)]
            public n14.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_EebJGeo16NmMnxyn2dahuz;
            [n1.ElementAttribute(TracingId = 331644U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "HWc8QDQcPV1PLbwEi2zmbP", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
            public n14.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<T> __p_HWc8QDQcPV1PLbwEi2zmbP;
            public __Appdx6u0WFAOPoSFpWA9t3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Appdx6u0WFAOPoSFpWA9t3(__Appdx6u0WFAOPoSFpWA9t3 other): base(other)
            {
                this.__p_Kps2T6tSk9uQQJXxLd7DOG = other.__p_Kps2T6tSk9uQQJXxLd7DOG;
                this.__p_Sz3tfkoFYonLMCk6avJZ1h = other.__p_Sz3tfkoFYonLMCk6avJZ1h;
                this.__p_EebJGeo16NmMnxyn2dahuz = other.__p_EebJGeo16NmMnxyn2dahuz;
                this.__p_HWc8QDQcPV1PLbwEi2zmbP = other.__p_HWc8QDQcPV1PLbwEi2zmbP;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Kps2T6tSk9uQQJXxLd7DOG", in __p_Kps2T6tSk9uQQJXxLd7DOG), n1.CompilationHelper.GetValueOrExisting(values, "__p_Sz3tfkoFYonLMCk6avJZ1h", in __p_Sz3tfkoFYonLMCk6avJZ1h), n1.CompilationHelper.GetValueOrExisting(values, "__p_EebJGeo16NmMnxyn2dahuz", in __p_EebJGeo16NmMnxyn2dahuz), n1.CompilationHelper.GetValueOrExisting(values, "__p_HWc8QDQcPV1PLbwEi2zmbP", in __p_HWc8QDQcPV1PLbwEi2zmbP));
            }

            internal __Appdx6u0WFAOPoSFpWA9t3 __WITH__(n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> __p_Kps2T6tSk9uQQJXxLd7DOG, n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> __p_Sz3tfkoFYonLMCk6avJZ1h, n14.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_EebJGeo16NmMnxyn2dahuz, n14.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<T> __p_HWc8QDQcPV1PLbwEi2zmbP)
            {
                __Appdx6u0WFAOPoSFpWA9t3 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Kps2T6tSk9uQQJXxLd7DOG != this.__p_Kps2T6tSk9uQQJXxLd7DOG || __p_Sz3tfkoFYonLMCk6avJZ1h != this.__p_Sz3tfkoFYonLMCk6avJZ1h || __p_EebJGeo16NmMnxyn2dahuz != this.__p_EebJGeo16NmMnxyn2dahuz || __p_HWc8QDQcPV1PLbwEi2zmbP != this.__p_HWc8QDQcPV1PLbwEi2zmbP ? new __Appdx6u0WFAOPoSFpWA9t3(this)
                    {__p_Kps2T6tSk9uQQJXxLd7DOG = __p_Kps2T6tSk9uQQJXxLd7DOG, __p_Sz3tfkoFYonLMCk6avJZ1h = __p_Sz3tfkoFYonLMCk6avJZ1h, __p_EebJGeo16NmMnxyn2dahuz = __p_EebJGeo16NmMnxyn2dahuz, __p_HWc8QDQcPV1PLbwEi2zmbP = __p_HWc8QDQcPV1PLbwEi2zmbP} : that_0;
                else
                {
                    this.__p_Kps2T6tSk9uQQJXxLd7DOG = __p_Kps2T6tSk9uQQJXxLd7DOG;
                    this.__p_Sz3tfkoFYonLMCk6avJZ1h = __p_Sz3tfkoFYonLMCk6avJZ1h;
                    this.__p_EebJGeo16NmMnxyn2dahuz = __p_EebJGeo16NmMnxyn2dahuz;
                    this.__p_HWc8QDQcPV1PLbwEi2zmbP = __p_HWc8QDQcPV1PLbwEi2zmbP;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 331702U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Fk0ShfevBSYOMAbGY9Djl8", Name = "Lighter_Fk0ShfevBSYOMAbGY9Djl8")]
    [n2.SerializableAttribute]
    public class Lighter_Fk0ShfevBSYOMAbGY9Djl8<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Lighter_Fk0ShfevBSYOMAbGY9Djl8<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Lighter_Fk0ShfevBSYOMAbGY9Djl8<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Lighter_Fk0ShfevBSYOMAbGY9Djl8<T> CreateDefault()
        {
            var instance = new Lighter_Fk0ShfevBSYOMAbGY9Djl8<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Lighter_Fk0ShfevBSYOMAbGY9Djl8<T> Update(n5.GpuValue<T> BaseLayer_In, n5.GpuValue<T> BlendLayer_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_BSGpYmzj6zmMHKHPpeFO4y;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (BaseLayer_In, BlendLayer_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__NdWDj6axLQoNAkgCHZgus2>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __NdWDj6axLQoNAkgCHZgus2(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Obg6ZFsVbAnMXOxxWZBeKL", 331732U);
                    var Output_8 = n14.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float>.Create(Node_Context: Node_Context_7);
                    state_6.__p_Obg6ZFsVbAnMXOxxWZBeKL = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "B7Cw0OPmNhOMUSfpGQFHT3", 331742U);
                    var Output_10 = n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_B7Cw0OPmNhOMUSfpGQFHT3 = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Idg82MW7BXxNsPApUDT8w4", 331748U);
                    var Output_12 = n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T>.Create(Node_Context: Node_Context_11);
                    state_6.__p_Idg82MW7BXxNsPApUDT8w4 = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "VI29SjCFDPGLLcvIqIxOlq", 331757U);
                    var Output_14 = n14.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<T>.Create(Node_Context: Node_Context_13);
                    state_6.__p_VI29SjCFDPGLLcvIqIxOlq = Output_14;
                }

                var State_Output_16 = state_6.__p_B7Cw0OPmNhOMUSfpGQFHT3.Update(Input_In: BaseLayer_In, Output_Out: out n5.GpuValue<float> Output_15);
                var State_Output_18 = state_6.__p_Idg82MW7BXxNsPApUDT8w4.Update(Input_In: BlendLayer_In, Output_Out: out n5.GpuValue<float> Output_17);
                var Output_20 = state_6.__p_Obg6ZFsVbAnMXOxxWZBeKL.Update(x_In: Output_15, y_In: Output_17, value_Out: out n5.GpuValue<bool> value_19);
                n5.GpuValue<T> The_Default_21 = default(n5.GpuValue<T>);
                var State_Output_23 = state_6.__p_VI29SjCFDPGLLcvIqIxOlq.Update(In_Check_In: value_19, In_False_In: BlendLayer_In, In_True_In: BaseLayer_In, The_Default_In: The_Default_21, Output_Out: out n5.GpuValue<T> Output_22);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_16 != state_6.__p_B7Cw0OPmNhOMUSfpGQFHT3 || State_Output_18 != state_6.__p_Idg82MW7BXxNsPApUDT8w4 || Output_20 != state_6.__p_Obg6ZFsVbAnMXOxxWZBeKL || State_Output_23 != state_6.__p_VI29SjCFDPGLLcvIqIxOlq ? new __NdWDj6axLQoNAkgCHZgus2(state_6)
                    {__p_B7Cw0OPmNhOMUSfpGQFHT3 = State_Output_16, __p_Idg82MW7BXxNsPApUDT8w4 = State_Output_18, __p_Obg6ZFsVbAnMXOxxWZBeKL = Output_20, __p_VI29SjCFDPGLLcvIqIxOlq = State_Output_23} : state_6;
                else
                {
                    state_6.__p_B7Cw0OPmNhOMUSfpGQFHT3 = State_Output_16;
                    state_6.__p_Idg82MW7BXxNsPApUDT8w4 = State_Output_18;
                    state_6.__p_Obg6ZFsVbAnMXOxxWZBeKL = Output_20;
                    state_6.__p_VI29SjCFDPGLLcvIqIxOlq = State_Output_23;
                }

                outputs_4 = n2.ValueTuple.Create(Output_22);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_24 = outputs_4.Item1;
            Output_Out = __auto_24;
            n3.Lighter_Fk0ShfevBSYOMAbGY9Djl8<T> that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = manager_2 != this.__cache_BSGpYmzj6zmMHKHPpeFO4y ? new Lighter_Fk0ShfevBSYOMAbGY9Djl8<T>(this)
                {__cache_BSGpYmzj6zmMHKHPpeFO4y = manager_2} : that_25;
            else
            {
                this.__cache_BSGpYmzj6zmMHKHPpeFO4y = manager_2;
            }

            return that_25;
        }

        public n3.Lighter_Fk0ShfevBSYOMAbGY9Djl8<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Lighter_Fk0ShfevBSYOMAbGY9Djl8<T> that_0 = this;
            this.__cache_BSGpYmzj6zmMHKHPpeFO4y = null;
            return that_0;
        }

        public n3.Lighter_Fk0ShfevBSYOMAbGY9Djl8<T> __CreateDefault__()
        {
            n3.Lighter_Fk0ShfevBSYOMAbGY9Djl8<T> that_0 = this;
            this.__cache_BSGpYmzj6zmMHKHPpeFO4y = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_BSGpYmzj6zmMHKHPpeFO4y);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 331713U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "BSGpYmzj6zmMHKHPpeFO4y", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_BSGpYmzj6zmMHKHPpeFO4y = null;
        public Lighter_Fk0ShfevBSYOMAbGY9Djl8(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Lighter_Fk0ShfevBSYOMAbGY9Djl8(Lighter_Fk0ShfevBSYOMAbGY9Djl8<T> other): base(other)
        {
            this.__cache_BSGpYmzj6zmMHKHPpeFO4y = other.__cache_BSGpYmzj6zmMHKHPpeFO4y;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_BSGpYmzj6zmMHKHPpeFO4y", in __cache_BSGpYmzj6zmMHKHPpeFO4y));
        }

        internal Lighter_Fk0ShfevBSYOMAbGY9Djl8<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_BSGpYmzj6zmMHKHPpeFO4y)
        {
            n3.Lighter_Fk0ShfevBSYOMAbGY9Djl8<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_BSGpYmzj6zmMHKHPpeFO4y != this.__cache_BSGpYmzj6zmMHKHPpeFO4y ? new Lighter_Fk0ShfevBSYOMAbGY9Djl8<T>(this)
                {__cache_BSGpYmzj6zmMHKHPpeFO4y = __cache_BSGpYmzj6zmMHKHPpeFO4y} : that_0;
            else
            {
                this.__cache_BSGpYmzj6zmMHKHPpeFO4y = __cache_BSGpYmzj6zmMHKHPpeFO4y;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "NdWDj6axLQoNAkgCHZgus2", Name = "__NdWDj6axLQoNAkgCHZgus2")]
        [n2.SerializableAttribute]
        public class __NdWDj6axLQoNAkgCHZgus2 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Obg6ZFsVbAnMXOxxWZBeKL);
                n1.CompilationHelper.SafeDispose(this.__p_B7Cw0OPmNhOMUSfpGQFHT3);
                n1.CompilationHelper.SafeDispose(this.__p_Idg82MW7BXxNsPApUDT8w4);
                n1.CompilationHelper.SafeDispose(this.__p_VI29SjCFDPGLLcvIqIxOlq);
                return;
            }

            [n1.ElementAttribute(TracingId = 331732U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Obg6ZFsVbAnMXOxxWZBeKL", Name = ">", IsManaged = true, IsAutoGenerated = true)]
            public n14.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_Obg6ZFsVbAnMXOxxWZBeKL;
            [n1.ElementAttribute(TracingId = 331742U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "B7Cw0OPmNhOMUSfpGQFHT3", Name = "Brightness", IsManaged = true, IsAutoGenerated = true)]
            public n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> __p_B7Cw0OPmNhOMUSfpGQFHT3;
            [n1.ElementAttribute(TracingId = 331748U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Idg82MW7BXxNsPApUDT8w4", Name = "Brightness", IsManaged = true, IsAutoGenerated = true)]
            public n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> __p_Idg82MW7BXxNsPApUDT8w4;
            [n1.ElementAttribute(TracingId = 331757U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "VI29SjCFDPGLLcvIqIxOlq", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
            public n14.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<T> __p_VI29SjCFDPGLLcvIqIxOlq;
            public __NdWDj6axLQoNAkgCHZgus2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __NdWDj6axLQoNAkgCHZgus2(__NdWDj6axLQoNAkgCHZgus2 other): base(other)
            {
                this.__p_Obg6ZFsVbAnMXOxxWZBeKL = other.__p_Obg6ZFsVbAnMXOxxWZBeKL;
                this.__p_B7Cw0OPmNhOMUSfpGQFHT3 = other.__p_B7Cw0OPmNhOMUSfpGQFHT3;
                this.__p_Idg82MW7BXxNsPApUDT8w4 = other.__p_Idg82MW7BXxNsPApUDT8w4;
                this.__p_VI29SjCFDPGLLcvIqIxOlq = other.__p_VI29SjCFDPGLLcvIqIxOlq;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Obg6ZFsVbAnMXOxxWZBeKL", in __p_Obg6ZFsVbAnMXOxxWZBeKL), n1.CompilationHelper.GetValueOrExisting(values, "__p_B7Cw0OPmNhOMUSfpGQFHT3", in __p_B7Cw0OPmNhOMUSfpGQFHT3), n1.CompilationHelper.GetValueOrExisting(values, "__p_Idg82MW7BXxNsPApUDT8w4", in __p_Idg82MW7BXxNsPApUDT8w4), n1.CompilationHelper.GetValueOrExisting(values, "__p_VI29SjCFDPGLLcvIqIxOlq", in __p_VI29SjCFDPGLLcvIqIxOlq));
            }

            internal __NdWDj6axLQoNAkgCHZgus2 __WITH__(n14.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_Obg6ZFsVbAnMXOxxWZBeKL, n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> __p_B7Cw0OPmNhOMUSfpGQFHT3, n3.Brightness_BkAjVtONmRBQDOSVPJwDgP<T> __p_Idg82MW7BXxNsPApUDT8w4, n14.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<T> __p_VI29SjCFDPGLLcvIqIxOlq)
            {
                __NdWDj6axLQoNAkgCHZgus2 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Obg6ZFsVbAnMXOxxWZBeKL != this.__p_Obg6ZFsVbAnMXOxxWZBeKL || __p_B7Cw0OPmNhOMUSfpGQFHT3 != this.__p_B7Cw0OPmNhOMUSfpGQFHT3 || __p_Idg82MW7BXxNsPApUDT8w4 != this.__p_Idg82MW7BXxNsPApUDT8w4 || __p_VI29SjCFDPGLLcvIqIxOlq != this.__p_VI29SjCFDPGLLcvIqIxOlq ? new __NdWDj6axLQoNAkgCHZgus2(this)
                    {__p_Obg6ZFsVbAnMXOxxWZBeKL = __p_Obg6ZFsVbAnMXOxxWZBeKL, __p_B7Cw0OPmNhOMUSfpGQFHT3 = __p_B7Cw0OPmNhOMUSfpGQFHT3, __p_Idg82MW7BXxNsPApUDT8w4 = __p_Idg82MW7BXxNsPApUDT8w4, __p_VI29SjCFDPGLLcvIqIxOlq = __p_VI29SjCFDPGLLcvIqIxOlq} : that_0;
                else
                {
                    this.__p_Obg6ZFsVbAnMXOxxWZBeKL = __p_Obg6ZFsVbAnMXOxxWZBeKL;
                    this.__p_B7Cw0OPmNhOMUSfpGQFHT3 = __p_B7Cw0OPmNhOMUSfpGQFHT3;
                    this.__p_Idg82MW7BXxNsPApUDT8w4 = __p_Idg82MW7BXxNsPApUDT8w4;
                    this.__p_VI29SjCFDPGLLcvIqIxOlq = __p_VI29SjCFDPGLLcvIqIxOlq;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 331820U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "K2v0n0Kv1U1NYFaWpSQKZJ", Name = "HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ")]
    [n2.SerializableAttribute]
    public class HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ Create(n1.NodeContext Node_Context)
        {
            var instance = new HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ CreateDefault()
        {
            var instance = new HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ Update(n5.GpuValue<n15.Vector3> HSV_In, out n5.GpuValue<n15.Vector3> RGB_Out)
        {
            string __pad_UgC3U4lWh8aP5zRDwJv3Yu_0 = __slot_UgC3U4lWh8aP5zRDwJv3Yu;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_KWYVp1nVW1wOs0UEwSMqPk;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n15.Vector3>)));
            }

            var inputs_4 = (HSV_In, __pad_UgC3U4lWh8aP5zRDwJv3Yu_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__NuYbETPhgXuQSEnpMvdpcY>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __NuYbETPhgXuQSEnpMvdpcY(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Pl3Pl7mZpCuOyzTAXMFPVj", 331843U);
                    var Output_9 = n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3>.Create(Node_Context: Node_Context_8);
                    state_7.__p_Pl3Pl7mZpCuOyzTAXMFPVj = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "UFoNP8nYAonPbXNlum8HqJ", 331858U);
                    var Output_11 = n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX.Create(Node_Context: Node_Context_10);
                    state_7.__p_UFoNP8nYAonPbXNlum8HqJ = Output_11;
                }

                var Output_13 = state_7.__p_UFoNP8nYAonPbXNlum8HqJ.Update(Singleton_Out: out string Singleton_12);
                n5.GpuValue<n15.Vector3> Default_14 = default(n5.GpuValue<n15.Vector3>);
                bool Is_Groupable_15 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_16 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_17 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj, 1);
                builder_17.Add(HSV_In);
                var __pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj_18 = builder_17.Commit();
                var State_Output_21 = state_7.__p_Pl3Pl7mZpCuOyzTAXMFPVj.Update(Arguments_In: __pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj_18, Function_Name_In: __pad_UgC3U4lWh8aP5zRDwJv3Yu_0, Default_In: Default_14, Mixins_In: Singleton_12, Is_Groupable_In: Is_Groupable_15, The_Modifiers_In: The_Modifiers_16, Output_Out: out n5.GpuValue<n15.Vector3> Output_19, Additional_Outputs_Out: out n10.Spread<n5.AbstractGpuValue> Additional_Outputs_20);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_13 != state_7.__p_UFoNP8nYAonPbXNlum8HqJ || __pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj_18 != state_7.__pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj || State_Output_21 != state_7.__p_Pl3Pl7mZpCuOyzTAXMFPVj ? new __NuYbETPhgXuQSEnpMvdpcY(state_7)
                    {__p_UFoNP8nYAonPbXNlum8HqJ = Output_13, __pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj = __pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj_18, __p_Pl3Pl7mZpCuOyzTAXMFPVj = State_Output_21} : state_7;
                else
                {
                    state_7.__p_UFoNP8nYAonPbXNlum8HqJ = Output_13;
                    state_7.__pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj = __pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj_18;
                    state_7.__p_Pl3Pl7mZpCuOyzTAXMFPVj = State_Output_21;
                }

                outputs_5 = n2.ValueTuple.Create(Output_19);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_22 = outputs_5.Item1;
            RGB_Out = __auto_22;
            n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = manager_3 != this.__cache_KWYVp1nVW1wOs0UEwSMqPk ? new HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ(this)
                {__cache_KWYVp1nVW1wOs0UEwSMqPk = manager_3} : that_23;
            else
            {
                this.__cache_KWYVp1nVW1wOs0UEwSMqPk = manager_3;
            }

            return that_23;
        }

        public n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ that_0 = this;
            this.__cache_KWYVp1nVW1wOs0UEwSMqPk = null;
            return that_0;
        }

        public n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ __CreateDefault__()
        {
            n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ that_0 = this;
            this.__cache_KWYVp1nVW1wOs0UEwSMqPk = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_KWYVp1nVW1wOs0UEwSMqPk);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 331873U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "UgC3U4lWh8aP5zRDwJv3Yu", Name = "__slot_UgC3U4lWh8aP5zRDwJv3Yu")]
        public static string __slot_UgC3U4lWh8aP5zRDwJv3Yu = "HSVtoRGB";
        [n1.ElementAttribute(TracingId = 331825U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "KWYVp1nVW1wOs0UEwSMqPk", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_KWYVp1nVW1wOs0UEwSMqPk = null;
        static HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ()
        {
        }

        public HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ(HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ other): base(other)
        {
            this.__cache_KWYVp1nVW1wOs0UEwSMqPk = other.__cache_KWYVp1nVW1wOs0UEwSMqPk;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_KWYVp1nVW1wOs0UEwSMqPk", in __cache_KWYVp1nVW1wOs0UEwSMqPk));
        }

        internal HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_KWYVp1nVW1wOs0UEwSMqPk)
        {
            n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_KWYVp1nVW1wOs0UEwSMqPk != this.__cache_KWYVp1nVW1wOs0UEwSMqPk ? new HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ(this)
                {__cache_KWYVp1nVW1wOs0UEwSMqPk = __cache_KWYVp1nVW1wOs0UEwSMqPk} : that_0;
            else
            {
                this.__cache_KWYVp1nVW1wOs0UEwSMqPk = __cache_KWYVp1nVW1wOs0UEwSMqPk;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "NuYbETPhgXuQSEnpMvdpcY", Name = "__NuYbETPhgXuQSEnpMvdpcY")]
        [n2.SerializableAttribute]
        public class __NuYbETPhgXuQSEnpMvdpcY : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Pl3Pl7mZpCuOyzTAXMFPVj);
                n1.CompilationHelper.SafeDispose(this.__p_UFoNP8nYAonPbXNlum8HqJ);
                return;
            }

            [n1.ElementAttribute(TracingId = 331843U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Pl3Pl7mZpCuOyzTAXMFPVj", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_Pl3Pl7mZpCuOyzTAXMFPVj;
            [n1.ElementAttribute(TracingId = 331858U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "UFoNP8nYAonPbXNlum8HqJ", Name = "FuseCoreColor (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_UFoNP8nYAonPbXNlum8HqJ;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj = default(n10.Spread<n5.AbstractGpuValue>);
            public __NuYbETPhgXuQSEnpMvdpcY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __NuYbETPhgXuQSEnpMvdpcY(__NuYbETPhgXuQSEnpMvdpcY other): base(other)
            {
                this.__p_Pl3Pl7mZpCuOyzTAXMFPVj = other.__p_Pl3Pl7mZpCuOyzTAXMFPVj;
                this.__p_UFoNP8nYAonPbXNlum8HqJ = other.__p_UFoNP8nYAonPbXNlum8HqJ;
                this.__pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj = other.__pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Pl3Pl7mZpCuOyzTAXMFPVj", in __p_Pl3Pl7mZpCuOyzTAXMFPVj), n1.CompilationHelper.GetValueOrExisting(values, "__p_UFoNP8nYAonPbXNlum8HqJ", in __p_UFoNP8nYAonPbXNlum8HqJ), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj", in __pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj));
            }

            internal __NuYbETPhgXuQSEnpMvdpcY __WITH__(n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_Pl3Pl7mZpCuOyzTAXMFPVj, n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_UFoNP8nYAonPbXNlum8HqJ, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj)
            {
                __NuYbETPhgXuQSEnpMvdpcY that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Pl3Pl7mZpCuOyzTAXMFPVj != this.__p_Pl3Pl7mZpCuOyzTAXMFPVj || __p_UFoNP8nYAonPbXNlum8HqJ != this.__p_UFoNP8nYAonPbXNlum8HqJ || __pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj != this.__pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj ? new __NuYbETPhgXuQSEnpMvdpcY(this)
                    {__p_Pl3Pl7mZpCuOyzTAXMFPVj = __p_Pl3Pl7mZpCuOyzTAXMFPVj, __p_UFoNP8nYAonPbXNlum8HqJ = __p_UFoNP8nYAonPbXNlum8HqJ, __pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj = __pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj} : that_0;
                else
                {
                    this.__p_Pl3Pl7mZpCuOyzTAXMFPVj = __p_Pl3Pl7mZpCuOyzTAXMFPVj;
                    this.__p_UFoNP8nYAonPbXNlum8HqJ = __p_UFoNP8nYAonPbXNlum8HqJ;
                    this.__pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj = __pin_group_Arguments_In_Pl3Pl7mZpCuOyzTAXMFPVj;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 331907U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "AmezpbPYEClL6Kazi5s7Uy", Name = "RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy")]
    [n2.SerializableAttribute]
    public class RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy Create(n1.NodeContext Node_Context)
        {
            var instance = new RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy CreateDefault()
        {
            var instance = new RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy Update(n5.GpuValue<n15.Vector3> RGB_In, out n5.GpuValue<n15.Vector3> HSV_Out)
        {
            string __pad_QFVPACbJ8jxLxBfaonjszW_0 = __slot_QFVPACbJ8jxLxBfaonjszW;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_NtOXJXjpkguOooPU7XIuAA;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n15.Vector3>)));
            }

            var inputs_4 = (RGB_In, __pad_QFVPACbJ8jxLxBfaonjszW_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__LN3MfDOMUliLnWymYmsbzC>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __LN3MfDOMUliLnWymYmsbzC(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7 = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "I08f6WYYqjsMZTywJLEHL7", 331928U);
                    var Output_9 = n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3>.Create(Node_Context: Node_Context_8);
                    state_7.__p_I08f6WYYqjsMZTywJLEHL7 = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "EewO3WfXo7eNK0QmK7aVEI", 331942U);
                    var Output_11 = n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX.Create(Node_Context: Node_Context_10);
                    state_7.__p_EewO3WfXo7eNK0QmK7aVEI = Output_11;
                }

                var Output_13 = state_7.__p_EewO3WfXo7eNK0QmK7aVEI.Update(Singleton_Out: out string Singleton_12);
                n5.GpuValue<n15.Vector3> Default_14 = default(n5.GpuValue<n15.Vector3>);
                bool Is_Groupable_15 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_16 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_17 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7, 1);
                builder_17.Add(RGB_In);
                var __pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7_18 = builder_17.Commit();
                var State_Output_21 = state_7.__p_I08f6WYYqjsMZTywJLEHL7.Update(Arguments_In: __pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7_18, Function_Name_In: __pad_QFVPACbJ8jxLxBfaonjszW_0, Default_In: Default_14, Mixins_In: Singleton_12, Is_Groupable_In: Is_Groupable_15, The_Modifiers_In: The_Modifiers_16, Output_Out: out n5.GpuValue<n15.Vector3> Output_19, Additional_Outputs_Out: out n10.Spread<n5.AbstractGpuValue> Additional_Outputs_20);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_13 != state_7.__p_EewO3WfXo7eNK0QmK7aVEI || __pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7_18 != state_7.__pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7 || State_Output_21 != state_7.__p_I08f6WYYqjsMZTywJLEHL7 ? new __LN3MfDOMUliLnWymYmsbzC(state_7)
                    {__p_EewO3WfXo7eNK0QmK7aVEI = Output_13, __pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7 = __pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7_18, __p_I08f6WYYqjsMZTywJLEHL7 = State_Output_21} : state_7;
                else
                {
                    state_7.__p_EewO3WfXo7eNK0QmK7aVEI = Output_13;
                    state_7.__pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7 = __pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7_18;
                    state_7.__p_I08f6WYYqjsMZTywJLEHL7 = State_Output_21;
                }

                outputs_5 = n2.ValueTuple.Create(Output_19);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_22 = outputs_5.Item1;
            HSV_Out = __auto_22;
            n3.RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = manager_3 != this.__cache_NtOXJXjpkguOooPU7XIuAA ? new RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy(this)
                {__cache_NtOXJXjpkguOooPU7XIuAA = manager_3} : that_23;
            else
            {
                this.__cache_NtOXJXjpkguOooPU7XIuAA = manager_3;
            }

            return that_23;
        }

        public n3.RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy that_0 = this;
            this.__cache_NtOXJXjpkguOooPU7XIuAA = null;
            return that_0;
        }

        public n3.RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy __CreateDefault__()
        {
            n3.RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy that_0 = this;
            this.__cache_NtOXJXjpkguOooPU7XIuAA = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_NtOXJXjpkguOooPU7XIuAA);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 331957U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "QFVPACbJ8jxLxBfaonjszW", Name = "__slot_QFVPACbJ8jxLxBfaonjszW")]
        public static string __slot_QFVPACbJ8jxLxBfaonjszW = "RGBtoHSV";
        [n1.ElementAttribute(TracingId = 331912U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "NtOXJXjpkguOooPU7XIuAA", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_NtOXJXjpkguOooPU7XIuAA = null;
        static RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy()
        {
        }

        public RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy(RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy other): base(other)
        {
            this.__cache_NtOXJXjpkguOooPU7XIuAA = other.__cache_NtOXJXjpkguOooPU7XIuAA;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_NtOXJXjpkguOooPU7XIuAA", in __cache_NtOXJXjpkguOooPU7XIuAA));
        }

        internal RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_NtOXJXjpkguOooPU7XIuAA)
        {
            n3.RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_NtOXJXjpkguOooPU7XIuAA != this.__cache_NtOXJXjpkguOooPU7XIuAA ? new RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy(this)
                {__cache_NtOXJXjpkguOooPU7XIuAA = __cache_NtOXJXjpkguOooPU7XIuAA} : that_0;
            else
            {
                this.__cache_NtOXJXjpkguOooPU7XIuAA = __cache_NtOXJXjpkguOooPU7XIuAA;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "LN3MfDOMUliLnWymYmsbzC", Name = "__LN3MfDOMUliLnWymYmsbzC")]
        [n2.SerializableAttribute]
        public class __LN3MfDOMUliLnWymYmsbzC : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_I08f6WYYqjsMZTywJLEHL7);
                n1.CompilationHelper.SafeDispose(this.__p_EewO3WfXo7eNK0QmK7aVEI);
                return;
            }

            [n1.ElementAttribute(TracingId = 331928U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "I08f6WYYqjsMZTywJLEHL7", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_I08f6WYYqjsMZTywJLEHL7;
            [n1.ElementAttribute(TracingId = 331942U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "EewO3WfXo7eNK0QmK7aVEI", Name = "FuseCoreColor (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_EewO3WfXo7eNK0QmK7aVEI;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7 = default(n10.Spread<n5.AbstractGpuValue>);
            public __LN3MfDOMUliLnWymYmsbzC(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __LN3MfDOMUliLnWymYmsbzC(__LN3MfDOMUliLnWymYmsbzC other): base(other)
            {
                this.__p_I08f6WYYqjsMZTywJLEHL7 = other.__p_I08f6WYYqjsMZTywJLEHL7;
                this.__p_EewO3WfXo7eNK0QmK7aVEI = other.__p_EewO3WfXo7eNK0QmK7aVEI;
                this.__pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7 = other.__pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_I08f6WYYqjsMZTywJLEHL7", in __p_I08f6WYYqjsMZTywJLEHL7), n1.CompilationHelper.GetValueOrExisting(values, "__p_EewO3WfXo7eNK0QmK7aVEI", in __p_EewO3WfXo7eNK0QmK7aVEI), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7", in __pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7));
            }

            internal __LN3MfDOMUliLnWymYmsbzC __WITH__(n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_I08f6WYYqjsMZTywJLEHL7, n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_EewO3WfXo7eNK0QmK7aVEI, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7)
            {
                __LN3MfDOMUliLnWymYmsbzC that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_I08f6WYYqjsMZTywJLEHL7 != this.__p_I08f6WYYqjsMZTywJLEHL7 || __p_EewO3WfXo7eNK0QmK7aVEI != this.__p_EewO3WfXo7eNK0QmK7aVEI || __pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7 != this.__pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7 ? new __LN3MfDOMUliLnWymYmsbzC(this)
                    {__p_I08f6WYYqjsMZTywJLEHL7 = __p_I08f6WYYqjsMZTywJLEHL7, __p_EewO3WfXo7eNK0QmK7aVEI = __p_EewO3WfXo7eNK0QmK7aVEI, __pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7 = __pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7} : that_0;
                else
                {
                    this.__p_I08f6WYYqjsMZTywJLEHL7 = __p_I08f6WYYqjsMZTywJLEHL7;
                    this.__p_EewO3WfXo7eNK0QmK7aVEI = __p_EewO3WfXo7eNK0QmK7aVEI;
                    this.__pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7 = __pin_group_Arguments_In_I08f6WYYqjsMZTywJLEHL7;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 332001U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Bjzdq9vbOfXPbiW6Sklj6R", Name = "HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R")]
    [n2.SerializableAttribute]
    public class HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R Create(n1.NodeContext Node_Context)
        {
            var instance = new HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R CreateDefault()
        {
            var instance = new HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R Update(n5.GpuValue<n15.Vector3> HSL_In, out n5.GpuValue<n15.Vector3> RGB_Out)
        {
            string __pad_IuYJSSM4QVrMKK21SNalq8_0 = __slot_IuYJSSM4QVrMKK21SNalq8;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_BwBNRtA8GYjPGHvBMCSdYO;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n15.Vector3>)));
            }

            var inputs_4 = (HSL_In, __pad_IuYJSSM4QVrMKK21SNalq8_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__L1wM52rr5nhPwX9ZWLxmyI>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __L1wM52rr5nhPwX9ZWLxmyI(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "H5yyajuZC54P4T43qQaiwz", 332021U);
                    var Output_9 = n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3>.Create(Node_Context: Node_Context_8);
                    state_7.__p_H5yyajuZC54P4T43qQaiwz = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "HT8OHQnQp5lQW2qwNDyueI", 332037U);
                    var Output_11 = n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX.Create(Node_Context: Node_Context_10);
                    state_7.__p_HT8OHQnQp5lQW2qwNDyueI = Output_11;
                }

                var Output_13 = state_7.__p_HT8OHQnQp5lQW2qwNDyueI.Update(Singleton_Out: out string Singleton_12);
                n5.GpuValue<n15.Vector3> Default_14 = default(n5.GpuValue<n15.Vector3>);
                bool Is_Groupable_15 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_16 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_17 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz, 1);
                builder_17.Add(HSL_In);
                var __pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz_18 = builder_17.Commit();
                var State_Output_21 = state_7.__p_H5yyajuZC54P4T43qQaiwz.Update(Arguments_In: __pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz_18, Function_Name_In: __pad_IuYJSSM4QVrMKK21SNalq8_0, Default_In: Default_14, Mixins_In: Singleton_12, Is_Groupable_In: Is_Groupable_15, The_Modifiers_In: The_Modifiers_16, Output_Out: out n5.GpuValue<n15.Vector3> Output_19, Additional_Outputs_Out: out n10.Spread<n5.AbstractGpuValue> Additional_Outputs_20);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_13 != state_7.__p_HT8OHQnQp5lQW2qwNDyueI || __pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz_18 != state_7.__pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz || State_Output_21 != state_7.__p_H5yyajuZC54P4T43qQaiwz ? new __L1wM52rr5nhPwX9ZWLxmyI(state_7)
                    {__p_HT8OHQnQp5lQW2qwNDyueI = Output_13, __pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz = __pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz_18, __p_H5yyajuZC54P4T43qQaiwz = State_Output_21} : state_7;
                else
                {
                    state_7.__p_HT8OHQnQp5lQW2qwNDyueI = Output_13;
                    state_7.__pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz = __pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz_18;
                    state_7.__p_H5yyajuZC54P4T43qQaiwz = State_Output_21;
                }

                outputs_5 = n2.ValueTuple.Create(Output_19);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_22 = outputs_5.Item1;
            RGB_Out = __auto_22;
            n3.HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = manager_3 != this.__cache_BwBNRtA8GYjPGHvBMCSdYO ? new HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R(this)
                {__cache_BwBNRtA8GYjPGHvBMCSdYO = manager_3} : that_23;
            else
            {
                this.__cache_BwBNRtA8GYjPGHvBMCSdYO = manager_3;
            }

            return that_23;
        }

        public n3.HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R that_0 = this;
            this.__cache_BwBNRtA8GYjPGHvBMCSdYO = null;
            return that_0;
        }

        public n3.HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R __CreateDefault__()
        {
            n3.HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R that_0 = this;
            this.__cache_BwBNRtA8GYjPGHvBMCSdYO = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_BwBNRtA8GYjPGHvBMCSdYO);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 332050U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "IuYJSSM4QVrMKK21SNalq8", Name = "__slot_IuYJSSM4QVrMKK21SNalq8")]
        public static string __slot_IuYJSSM4QVrMKK21SNalq8 = "HSLtoRGB";
        [n1.ElementAttribute(TracingId = 332005U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "BwBNRtA8GYjPGHvBMCSdYO", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_BwBNRtA8GYjPGHvBMCSdYO = null;
        static HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R()
        {
        }

        public HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R(HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R other): base(other)
        {
            this.__cache_BwBNRtA8GYjPGHvBMCSdYO = other.__cache_BwBNRtA8GYjPGHvBMCSdYO;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_BwBNRtA8GYjPGHvBMCSdYO", in __cache_BwBNRtA8GYjPGHvBMCSdYO));
        }

        internal HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_BwBNRtA8GYjPGHvBMCSdYO)
        {
            n3.HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_BwBNRtA8GYjPGHvBMCSdYO != this.__cache_BwBNRtA8GYjPGHvBMCSdYO ? new HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R(this)
                {__cache_BwBNRtA8GYjPGHvBMCSdYO = __cache_BwBNRtA8GYjPGHvBMCSdYO} : that_0;
            else
            {
                this.__cache_BwBNRtA8GYjPGHvBMCSdYO = __cache_BwBNRtA8GYjPGHvBMCSdYO;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "L1wM52rr5nhPwX9ZWLxmyI", Name = "__L1wM52rr5nhPwX9ZWLxmyI")]
        [n2.SerializableAttribute]
        public class __L1wM52rr5nhPwX9ZWLxmyI : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_H5yyajuZC54P4T43qQaiwz);
                n1.CompilationHelper.SafeDispose(this.__p_HT8OHQnQp5lQW2qwNDyueI);
                return;
            }

            [n1.ElementAttribute(TracingId = 332021U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "H5yyajuZC54P4T43qQaiwz", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_H5yyajuZC54P4T43qQaiwz;
            [n1.ElementAttribute(TracingId = 332037U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "HT8OHQnQp5lQW2qwNDyueI", Name = "FuseCoreColor (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_HT8OHQnQp5lQW2qwNDyueI;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz = default(n10.Spread<n5.AbstractGpuValue>);
            public __L1wM52rr5nhPwX9ZWLxmyI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __L1wM52rr5nhPwX9ZWLxmyI(__L1wM52rr5nhPwX9ZWLxmyI other): base(other)
            {
                this.__p_H5yyajuZC54P4T43qQaiwz = other.__p_H5yyajuZC54P4T43qQaiwz;
                this.__p_HT8OHQnQp5lQW2qwNDyueI = other.__p_HT8OHQnQp5lQW2qwNDyueI;
                this.__pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz = other.__pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_H5yyajuZC54P4T43qQaiwz", in __p_H5yyajuZC54P4T43qQaiwz), n1.CompilationHelper.GetValueOrExisting(values, "__p_HT8OHQnQp5lQW2qwNDyueI", in __p_HT8OHQnQp5lQW2qwNDyueI), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz", in __pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz));
            }

            internal __L1wM52rr5nhPwX9ZWLxmyI __WITH__(n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_H5yyajuZC54P4T43qQaiwz, n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_HT8OHQnQp5lQW2qwNDyueI, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz)
            {
                __L1wM52rr5nhPwX9ZWLxmyI that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_H5yyajuZC54P4T43qQaiwz != this.__p_H5yyajuZC54P4T43qQaiwz || __p_HT8OHQnQp5lQW2qwNDyueI != this.__p_HT8OHQnQp5lQW2qwNDyueI || __pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz != this.__pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz ? new __L1wM52rr5nhPwX9ZWLxmyI(this)
                    {__p_H5yyajuZC54P4T43qQaiwz = __p_H5yyajuZC54P4T43qQaiwz, __p_HT8OHQnQp5lQW2qwNDyueI = __p_HT8OHQnQp5lQW2qwNDyueI, __pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz = __pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz} : that_0;
                else
                {
                    this.__p_H5yyajuZC54P4T43qQaiwz = __p_H5yyajuZC54P4T43qQaiwz;
                    this.__p_HT8OHQnQp5lQW2qwNDyueI = __p_HT8OHQnQp5lQW2qwNDyueI;
                    this.__pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz = __pin_group_Arguments_In_H5yyajuZC54P4T43qQaiwz;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 332082U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "PiPwfC0MBgmMoFNeSxQ4ov", Name = "RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov")]
    [n2.SerializableAttribute]
    public class RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov Create(n1.NodeContext Node_Context)
        {
            var instance = new RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov CreateDefault()
        {
            var instance = new RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov Update(n5.GpuValue<n15.Vector3> RGB_In, out n5.GpuValue<n15.Vector3> HSL_Out)
        {
            string __pad_Inuh2Y3yZtjND1Fzu9T0rZ_0 = __slot_Inuh2Y3yZtjND1Fzu9T0rZ;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_B4t3sRvRdtfNeVUqMkLUOd;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n15.Vector3>)));
            }

            var inputs_4 = (RGB_In, __pad_Inuh2Y3yZtjND1Fzu9T0rZ_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__VIK64vR8Rj7NMQwbCIBQxR>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __VIK64vR8Rj7NMQwbCIBQxR(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "VknTd7mZLyLPDobzFOwoiQ", 332102U);
                    var Output_9 = n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3>.Create(Node_Context: Node_Context_8);
                    state_7.__p_VknTd7mZLyLPDobzFOwoiQ = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "U5ZjleHGVPPOpEQYbO5xNd", 332116U);
                    var Output_11 = n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX.Create(Node_Context: Node_Context_10);
                    state_7.__p_U5ZjleHGVPPOpEQYbO5xNd = Output_11;
                }

                var Output_13 = state_7.__p_U5ZjleHGVPPOpEQYbO5xNd.Update(Singleton_Out: out string Singleton_12);
                n5.GpuValue<n15.Vector3> Default_14 = default(n5.GpuValue<n15.Vector3>);
                bool Is_Groupable_15 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_16 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_17 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ, 1);
                builder_17.Add(RGB_In);
                var __pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ_18 = builder_17.Commit();
                var State_Output_21 = state_7.__p_VknTd7mZLyLPDobzFOwoiQ.Update(Arguments_In: __pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ_18, Function_Name_In: __pad_Inuh2Y3yZtjND1Fzu9T0rZ_0, Default_In: Default_14, Mixins_In: Singleton_12, Is_Groupable_In: Is_Groupable_15, The_Modifiers_In: The_Modifiers_16, Output_Out: out n5.GpuValue<n15.Vector3> Output_19, Additional_Outputs_Out: out n10.Spread<n5.AbstractGpuValue> Additional_Outputs_20);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_13 != state_7.__p_U5ZjleHGVPPOpEQYbO5xNd || __pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ_18 != state_7.__pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ || State_Output_21 != state_7.__p_VknTd7mZLyLPDobzFOwoiQ ? new __VIK64vR8Rj7NMQwbCIBQxR(state_7)
                    {__p_U5ZjleHGVPPOpEQYbO5xNd = Output_13, __pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ = __pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ_18, __p_VknTd7mZLyLPDobzFOwoiQ = State_Output_21} : state_7;
                else
                {
                    state_7.__p_U5ZjleHGVPPOpEQYbO5xNd = Output_13;
                    state_7.__pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ = __pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ_18;
                    state_7.__p_VknTd7mZLyLPDobzFOwoiQ = State_Output_21;
                }

                outputs_5 = n2.ValueTuple.Create(Output_19);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_22 = outputs_5.Item1;
            HSL_Out = __auto_22;
            n3.RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = manager_3 != this.__cache_B4t3sRvRdtfNeVUqMkLUOd ? new RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov(this)
                {__cache_B4t3sRvRdtfNeVUqMkLUOd = manager_3} : that_23;
            else
            {
                this.__cache_B4t3sRvRdtfNeVUqMkLUOd = manager_3;
            }

            return that_23;
        }

        public n3.RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov that_0 = this;
            this.__cache_B4t3sRvRdtfNeVUqMkLUOd = null;
            return that_0;
        }

        public n3.RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov __CreateDefault__()
        {
            n3.RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov that_0 = this;
            this.__cache_B4t3sRvRdtfNeVUqMkLUOd = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_B4t3sRvRdtfNeVUqMkLUOd);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 332130U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Inuh2Y3yZtjND1Fzu9T0rZ", Name = "__slot_Inuh2Y3yZtjND1Fzu9T0rZ")]
        public static string __slot_Inuh2Y3yZtjND1Fzu9T0rZ = "RGBtoHSL";
        [n1.ElementAttribute(TracingId = 332085U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "B4t3sRvRdtfNeVUqMkLUOd", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_B4t3sRvRdtfNeVUqMkLUOd = null;
        static RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov()
        {
        }

        public RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov(RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov other): base(other)
        {
            this.__cache_B4t3sRvRdtfNeVUqMkLUOd = other.__cache_B4t3sRvRdtfNeVUqMkLUOd;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_B4t3sRvRdtfNeVUqMkLUOd", in __cache_B4t3sRvRdtfNeVUqMkLUOd));
        }

        internal RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_B4t3sRvRdtfNeVUqMkLUOd)
        {
            n3.RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_B4t3sRvRdtfNeVUqMkLUOd != this.__cache_B4t3sRvRdtfNeVUqMkLUOd ? new RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov(this)
                {__cache_B4t3sRvRdtfNeVUqMkLUOd = __cache_B4t3sRvRdtfNeVUqMkLUOd} : that_0;
            else
            {
                this.__cache_B4t3sRvRdtfNeVUqMkLUOd = __cache_B4t3sRvRdtfNeVUqMkLUOd;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "VIK64vR8Rj7NMQwbCIBQxR", Name = "__VIK64vR8Rj7NMQwbCIBQxR")]
        [n2.SerializableAttribute]
        public class __VIK64vR8Rj7NMQwbCIBQxR : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_VknTd7mZLyLPDobzFOwoiQ);
                n1.CompilationHelper.SafeDispose(this.__p_U5ZjleHGVPPOpEQYbO5xNd);
                return;
            }

            [n1.ElementAttribute(TracingId = 332102U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "VknTd7mZLyLPDobzFOwoiQ", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_VknTd7mZLyLPDobzFOwoiQ;
            [n1.ElementAttribute(TracingId = 332116U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "U5ZjleHGVPPOpEQYbO5xNd", Name = "FuseCoreColor (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_U5ZjleHGVPPOpEQYbO5xNd;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ = default(n10.Spread<n5.AbstractGpuValue>);
            public __VIK64vR8Rj7NMQwbCIBQxR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __VIK64vR8Rj7NMQwbCIBQxR(__VIK64vR8Rj7NMQwbCIBQxR other): base(other)
            {
                this.__p_VknTd7mZLyLPDobzFOwoiQ = other.__p_VknTd7mZLyLPDobzFOwoiQ;
                this.__p_U5ZjleHGVPPOpEQYbO5xNd = other.__p_U5ZjleHGVPPOpEQYbO5xNd;
                this.__pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ = other.__pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VknTd7mZLyLPDobzFOwoiQ", in __p_VknTd7mZLyLPDobzFOwoiQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_U5ZjleHGVPPOpEQYbO5xNd", in __p_U5ZjleHGVPPOpEQYbO5xNd), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ", in __pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ));
            }

            internal __VIK64vR8Rj7NMQwbCIBQxR __WITH__(n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_VknTd7mZLyLPDobzFOwoiQ, n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_U5ZjleHGVPPOpEQYbO5xNd, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ)
            {
                __VIK64vR8Rj7NMQwbCIBQxR that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_VknTd7mZLyLPDobzFOwoiQ != this.__p_VknTd7mZLyLPDobzFOwoiQ || __p_U5ZjleHGVPPOpEQYbO5xNd != this.__p_U5ZjleHGVPPOpEQYbO5xNd || __pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ != this.__pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ ? new __VIK64vR8Rj7NMQwbCIBQxR(this)
                    {__p_VknTd7mZLyLPDobzFOwoiQ = __p_VknTd7mZLyLPDobzFOwoiQ, __p_U5ZjleHGVPPOpEQYbO5xNd = __p_U5ZjleHGVPPOpEQYbO5xNd, __pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ = __pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ} : that_0;
                else
                {
                    this.__p_VknTd7mZLyLPDobzFOwoiQ = __p_VknTd7mZLyLPDobzFOwoiQ;
                    this.__p_U5ZjleHGVPPOpEQYbO5xNd = __p_U5ZjleHGVPPOpEQYbO5xNd;
                    this.__pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ = __pin_group_Arguments_In_VknTd7mZLyLPDobzFOwoiQ;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 332166U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Q0j51xXC7SFMagRHt3pHOf", Name = "OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf")]
    [n2.SerializableAttribute]
    public class OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf Create(n1.NodeContext Node_Context)
        {
            var instance = new OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf CreateDefault()
        {
            var instance = new OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf Update(n5.GpuValue<n15.Vector3> OKLab_In, out n5.GpuValue<n15.Vector3> RGB_Out)
        {
            string __pad_Bn3x8AnjxTUL9Oq0zMNLGa_0 = __slot_Bn3x8AnjxTUL9Oq0zMNLGa;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_UhfVDUdtE16LFkwgR0t2zQ;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n15.Vector3>)));
            }

            var inputs_4 = (OKLab_In, __pad_Bn3x8AnjxTUL9Oq0zMNLGa_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__OS4cspjVeJ6QUjP8ai7h6P>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __OS4cspjVeJ6QUjP8ai7h6P(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Q5sKDDIqpQ2N0Cu1zoCETd", 332183U);
                    var Output_9 = n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3>.Create(Node_Context: Node_Context_8);
                    state_7.__p_Q5sKDDIqpQ2N0Cu1zoCETd = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "UboF9TrkrTQLgxSJYcn71R", 332196U);
                    var Output_11 = n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX.Create(Node_Context: Node_Context_10);
                    state_7.__p_UboF9TrkrTQLgxSJYcn71R = Output_11;
                }

                var Output_13 = state_7.__p_UboF9TrkrTQLgxSJYcn71R.Update(Singleton_Out: out string Singleton_12);
                n5.GpuValue<n15.Vector3> Default_14 = default(n5.GpuValue<n15.Vector3>);
                bool Is_Groupable_15 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_16 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_17 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd, 1);
                builder_17.Add(OKLab_In);
                var __pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd_18 = builder_17.Commit();
                var State_Output_21 = state_7.__p_Q5sKDDIqpQ2N0Cu1zoCETd.Update(Arguments_In: __pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd_18, Function_Name_In: __pad_Bn3x8AnjxTUL9Oq0zMNLGa_0, Default_In: Default_14, Mixins_In: Singleton_12, Is_Groupable_In: Is_Groupable_15, The_Modifiers_In: The_Modifiers_16, Output_Out: out n5.GpuValue<n15.Vector3> Output_19, Additional_Outputs_Out: out n10.Spread<n5.AbstractGpuValue> Additional_Outputs_20);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_13 != state_7.__p_UboF9TrkrTQLgxSJYcn71R || __pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd_18 != state_7.__pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd || State_Output_21 != state_7.__p_Q5sKDDIqpQ2N0Cu1zoCETd ? new __OS4cspjVeJ6QUjP8ai7h6P(state_7)
                    {__p_UboF9TrkrTQLgxSJYcn71R = Output_13, __pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd = __pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd_18, __p_Q5sKDDIqpQ2N0Cu1zoCETd = State_Output_21} : state_7;
                else
                {
                    state_7.__p_UboF9TrkrTQLgxSJYcn71R = Output_13;
                    state_7.__pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd = __pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd_18;
                    state_7.__p_Q5sKDDIqpQ2N0Cu1zoCETd = State_Output_21;
                }

                outputs_5 = n2.ValueTuple.Create(Output_19);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_22 = outputs_5.Item1;
            RGB_Out = __auto_22;
            n3.OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = manager_3 != this.__cache_UhfVDUdtE16LFkwgR0t2zQ ? new OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf(this)
                {__cache_UhfVDUdtE16LFkwgR0t2zQ = manager_3} : that_23;
            else
            {
                this.__cache_UhfVDUdtE16LFkwgR0t2zQ = manager_3;
            }

            return that_23;
        }

        public n3.OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf that_0 = this;
            this.__cache_UhfVDUdtE16LFkwgR0t2zQ = null;
            return that_0;
        }

        public n3.OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf __CreateDefault__()
        {
            n3.OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf that_0 = this;
            this.__cache_UhfVDUdtE16LFkwgR0t2zQ = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_UhfVDUdtE16LFkwgR0t2zQ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 332212U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Bn3x8AnjxTUL9Oq0zMNLGa", Name = "__slot_Bn3x8AnjxTUL9Oq0zMNLGa")]
        public static string __slot_Bn3x8AnjxTUL9Oq0zMNLGa = "OKLabToRGB";
        [n1.ElementAttribute(TracingId = 332171U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "UhfVDUdtE16LFkwgR0t2zQ", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_UhfVDUdtE16LFkwgR0t2zQ = null;
        static OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf()
        {
        }

        public OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf(OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf other): base(other)
        {
            this.__cache_UhfVDUdtE16LFkwgR0t2zQ = other.__cache_UhfVDUdtE16LFkwgR0t2zQ;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_UhfVDUdtE16LFkwgR0t2zQ", in __cache_UhfVDUdtE16LFkwgR0t2zQ));
        }

        internal OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_UhfVDUdtE16LFkwgR0t2zQ)
        {
            n3.OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_UhfVDUdtE16LFkwgR0t2zQ != this.__cache_UhfVDUdtE16LFkwgR0t2zQ ? new OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf(this)
                {__cache_UhfVDUdtE16LFkwgR0t2zQ = __cache_UhfVDUdtE16LFkwgR0t2zQ} : that_0;
            else
            {
                this.__cache_UhfVDUdtE16LFkwgR0t2zQ = __cache_UhfVDUdtE16LFkwgR0t2zQ;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "OS4cspjVeJ6QUjP8ai7h6P", Name = "__OS4cspjVeJ6QUjP8ai7h6P")]
        [n2.SerializableAttribute]
        public class __OS4cspjVeJ6QUjP8ai7h6P : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Q5sKDDIqpQ2N0Cu1zoCETd);
                n1.CompilationHelper.SafeDispose(this.__p_UboF9TrkrTQLgxSJYcn71R);
                return;
            }

            [n1.ElementAttribute(TracingId = 332183U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Q5sKDDIqpQ2N0Cu1zoCETd", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_Q5sKDDIqpQ2N0Cu1zoCETd;
            [n1.ElementAttribute(TracingId = 332196U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "UboF9TrkrTQLgxSJYcn71R", Name = "FuseCoreColor (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_UboF9TrkrTQLgxSJYcn71R;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd = default(n10.Spread<n5.AbstractGpuValue>);
            public __OS4cspjVeJ6QUjP8ai7h6P(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __OS4cspjVeJ6QUjP8ai7h6P(__OS4cspjVeJ6QUjP8ai7h6P other): base(other)
            {
                this.__p_Q5sKDDIqpQ2N0Cu1zoCETd = other.__p_Q5sKDDIqpQ2N0Cu1zoCETd;
                this.__p_UboF9TrkrTQLgxSJYcn71R = other.__p_UboF9TrkrTQLgxSJYcn71R;
                this.__pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd = other.__pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Q5sKDDIqpQ2N0Cu1zoCETd", in __p_Q5sKDDIqpQ2N0Cu1zoCETd), n1.CompilationHelper.GetValueOrExisting(values, "__p_UboF9TrkrTQLgxSJYcn71R", in __p_UboF9TrkrTQLgxSJYcn71R), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd", in __pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd));
            }

            internal __OS4cspjVeJ6QUjP8ai7h6P __WITH__(n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_Q5sKDDIqpQ2N0Cu1zoCETd, n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_UboF9TrkrTQLgxSJYcn71R, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd)
            {
                __OS4cspjVeJ6QUjP8ai7h6P that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Q5sKDDIqpQ2N0Cu1zoCETd != this.__p_Q5sKDDIqpQ2N0Cu1zoCETd || __p_UboF9TrkrTQLgxSJYcn71R != this.__p_UboF9TrkrTQLgxSJYcn71R || __pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd != this.__pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd ? new __OS4cspjVeJ6QUjP8ai7h6P(this)
                    {__p_Q5sKDDIqpQ2N0Cu1zoCETd = __p_Q5sKDDIqpQ2N0Cu1zoCETd, __p_UboF9TrkrTQLgxSJYcn71R = __p_UboF9TrkrTQLgxSJYcn71R, __pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd = __pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd} : that_0;
                else
                {
                    this.__p_Q5sKDDIqpQ2N0Cu1zoCETd = __p_Q5sKDDIqpQ2N0Cu1zoCETd;
                    this.__p_UboF9TrkrTQLgxSJYcn71R = __p_UboF9TrkrTQLgxSJYcn71R;
                    this.__pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd = __pin_group_Arguments_In_Q5sKDDIqpQ2N0Cu1zoCETd;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 332246U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "At5QcfIO72WQR9DUuiEdNs", Name = "RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs")]
    [n2.SerializableAttribute]
    public class RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs Create(n1.NodeContext Node_Context)
        {
            var instance = new RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs CreateDefault()
        {
            var instance = new RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs Update(n5.GpuValue<n15.Vector3> RGB_In, out n5.GpuValue<n15.Vector3> OKLab_Out)
        {
            string __pad_HPyIaiEe9HOLrhqpTawdfW_0 = __slot_HPyIaiEe9HOLrhqpTawdfW;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_IMhQtuooErTPh3GE9ma5pR;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n15.Vector3>)));
            }

            var inputs_4 = (RGB_In, __pad_HPyIaiEe9HOLrhqpTawdfW_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__QmUJm7WdM94P2ZDDOHCSRi>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __QmUJm7WdM94P2ZDDOHCSRi(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "NHVjexjg13ONLn7IvWgWxu", 332269U);
                    var Output_9 = n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3>.Create(Node_Context: Node_Context_8);
                    state_7.__p_NHVjexjg13ONLn7IvWgWxu = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "GFpXBs3Frx4NoLBzvChmO3", 332285U);
                    var Output_11 = n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX.Create(Node_Context: Node_Context_10);
                    state_7.__p_GFpXBs3Frx4NoLBzvChmO3 = Output_11;
                }

                var Output_13 = state_7.__p_GFpXBs3Frx4NoLBzvChmO3.Update(Singleton_Out: out string Singleton_12);
                n5.GpuValue<n15.Vector3> Default_14 = default(n5.GpuValue<n15.Vector3>);
                bool Is_Groupable_15 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_16 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_17 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu, 1);
                builder_17.Add(RGB_In);
                var __pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu_18 = builder_17.Commit();
                var State_Output_21 = state_7.__p_NHVjexjg13ONLn7IvWgWxu.Update(Arguments_In: __pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu_18, Function_Name_In: __pad_HPyIaiEe9HOLrhqpTawdfW_0, Default_In: Default_14, Mixins_In: Singleton_12, Is_Groupable_In: Is_Groupable_15, The_Modifiers_In: The_Modifiers_16, Output_Out: out n5.GpuValue<n15.Vector3> Output_19, Additional_Outputs_Out: out n10.Spread<n5.AbstractGpuValue> Additional_Outputs_20);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_13 != state_7.__p_GFpXBs3Frx4NoLBzvChmO3 || __pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu_18 != state_7.__pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu || State_Output_21 != state_7.__p_NHVjexjg13ONLn7IvWgWxu ? new __QmUJm7WdM94P2ZDDOHCSRi(state_7)
                    {__p_GFpXBs3Frx4NoLBzvChmO3 = Output_13, __pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu = __pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu_18, __p_NHVjexjg13ONLn7IvWgWxu = State_Output_21} : state_7;
                else
                {
                    state_7.__p_GFpXBs3Frx4NoLBzvChmO3 = Output_13;
                    state_7.__pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu = __pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu_18;
                    state_7.__p_NHVjexjg13ONLn7IvWgWxu = State_Output_21;
                }

                outputs_5 = n2.ValueTuple.Create(Output_19);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_22 = outputs_5.Item1;
            OKLab_Out = __auto_22;
            n3.RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = manager_3 != this.__cache_IMhQtuooErTPh3GE9ma5pR ? new RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs(this)
                {__cache_IMhQtuooErTPh3GE9ma5pR = manager_3} : that_23;
            else
            {
                this.__cache_IMhQtuooErTPh3GE9ma5pR = manager_3;
            }

            return that_23;
        }

        public n3.RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs that_0 = this;
            this.__cache_IMhQtuooErTPh3GE9ma5pR = null;
            return that_0;
        }

        public n3.RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs __CreateDefault__()
        {
            n3.RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs that_0 = this;
            this.__cache_IMhQtuooErTPh3GE9ma5pR = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_IMhQtuooErTPh3GE9ma5pR);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 332297U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "HPyIaiEe9HOLrhqpTawdfW", Name = "__slot_HPyIaiEe9HOLrhqpTawdfW")]
        public static string __slot_HPyIaiEe9HOLrhqpTawdfW = "RGBtoOKLab";
        [n1.ElementAttribute(TracingId = 332251U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "IMhQtuooErTPh3GE9ma5pR", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_IMhQtuooErTPh3GE9ma5pR = null;
        static RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs()
        {
        }

        public RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs(RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs other): base(other)
        {
            this.__cache_IMhQtuooErTPh3GE9ma5pR = other.__cache_IMhQtuooErTPh3GE9ma5pR;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_IMhQtuooErTPh3GE9ma5pR", in __cache_IMhQtuooErTPh3GE9ma5pR));
        }

        internal RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_IMhQtuooErTPh3GE9ma5pR)
        {
            n3.RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_IMhQtuooErTPh3GE9ma5pR != this.__cache_IMhQtuooErTPh3GE9ma5pR ? new RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs(this)
                {__cache_IMhQtuooErTPh3GE9ma5pR = __cache_IMhQtuooErTPh3GE9ma5pR} : that_0;
            else
            {
                this.__cache_IMhQtuooErTPh3GE9ma5pR = __cache_IMhQtuooErTPh3GE9ma5pR;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "QmUJm7WdM94P2ZDDOHCSRi", Name = "__QmUJm7WdM94P2ZDDOHCSRi")]
        [n2.SerializableAttribute]
        public class __QmUJm7WdM94P2ZDDOHCSRi : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_NHVjexjg13ONLn7IvWgWxu);
                n1.CompilationHelper.SafeDispose(this.__p_GFpXBs3Frx4NoLBzvChmO3);
                return;
            }

            [n1.ElementAttribute(TracingId = 332269U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "NHVjexjg13ONLn7IvWgWxu", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_NHVjexjg13ONLn7IvWgWxu;
            [n1.ElementAttribute(TracingId = 332285U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "GFpXBs3Frx4NoLBzvChmO3", Name = "FuseCoreColor (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_GFpXBs3Frx4NoLBzvChmO3;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu = default(n10.Spread<n5.AbstractGpuValue>);
            public __QmUJm7WdM94P2ZDDOHCSRi(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __QmUJm7WdM94P2ZDDOHCSRi(__QmUJm7WdM94P2ZDDOHCSRi other): base(other)
            {
                this.__p_NHVjexjg13ONLn7IvWgWxu = other.__p_NHVjexjg13ONLn7IvWgWxu;
                this.__p_GFpXBs3Frx4NoLBzvChmO3 = other.__p_GFpXBs3Frx4NoLBzvChmO3;
                this.__pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu = other.__pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NHVjexjg13ONLn7IvWgWxu", in __p_NHVjexjg13ONLn7IvWgWxu), n1.CompilationHelper.GetValueOrExisting(values, "__p_GFpXBs3Frx4NoLBzvChmO3", in __p_GFpXBs3Frx4NoLBzvChmO3), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu", in __pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu));
            }

            internal __QmUJm7WdM94P2ZDDOHCSRi __WITH__(n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_NHVjexjg13ONLn7IvWgWxu, n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_GFpXBs3Frx4NoLBzvChmO3, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu)
            {
                __QmUJm7WdM94P2ZDDOHCSRi that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_NHVjexjg13ONLn7IvWgWxu != this.__p_NHVjexjg13ONLn7IvWgWxu || __p_GFpXBs3Frx4NoLBzvChmO3 != this.__p_GFpXBs3Frx4NoLBzvChmO3 || __pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu != this.__pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu ? new __QmUJm7WdM94P2ZDDOHCSRi(this)
                    {__p_NHVjexjg13ONLn7IvWgWxu = __p_NHVjexjg13ONLn7IvWgWxu, __p_GFpXBs3Frx4NoLBzvChmO3 = __p_GFpXBs3Frx4NoLBzvChmO3, __pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu = __pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu} : that_0;
                else
                {
                    this.__p_NHVjexjg13ONLn7IvWgWxu = __p_NHVjexjg13ONLn7IvWgWxu;
                    this.__p_GFpXBs3Frx4NoLBzvChmO3 = __p_GFpXBs3Frx4NoLBzvChmO3;
                    this.__pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu = __pin_group_Arguments_In_NHVjexjg13ONLn7IvWgWxu;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 332338U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "DpVZogM1K76MI4s4jT5rjT", Name = "OKLabMix_DpVZogM1K76MI4s4jT5rjT")]
    [n2.SerializableAttribute]
    public class OKLabMix_DpVZogM1K76MI4s4jT5rjT : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.OKLabMix_DpVZogM1K76MI4s4jT5rjT Create(n1.NodeContext Node_Context)
        {
            var instance = new OKLabMix_DpVZogM1K76MI4s4jT5rjT(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.OKLabMix_DpVZogM1K76MI4s4jT5rjT CreateDefault()
        {
            var instance = new OKLabMix_DpVZogM1K76MI4s4jT5rjT(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.OKLabMix_DpVZogM1K76MI4s4jT5rjT Update(n5.GpuValue<n15.Vector3> RGB_0_In, n5.GpuValue<n15.Vector3> RGB_1_In, n5.GpuValue<float> blend_In, out n5.GpuValue<n15.Vector3> RGB_Out)
        {
            string __pad_TliUcZDJcdOLGb4S6jvoi3_0 = __slot_TliUcZDJcdOLGb4S6jvoi3;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_E4mOGabaRklMJ6xlvveGQI;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector3>, n5.GpuValue<float>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n15.Vector3>)));
            }

            var inputs_4 = (RGB_0_In, RGB_1_In, blend_In, __pad_TliUcZDJcdOLGb4S6jvoi3_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__DOOLyWdELRRLxw8L7WVzDc>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __DOOLyWdELRRLxw8L7WVzDc(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Q5RBOtREG9hNXbMSr7icRx", 332363U);
                    var Output_9 = n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3>.Create(Node_Context: Node_Context_8);
                    state_7.__p_Q5RBOtREG9hNXbMSr7icRx = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "NR8qGVOfQiHPtmzZMDpzqF", 332376U);
                    var Output_11 = n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX.Create(Node_Context: Node_Context_10);
                    state_7.__p_NR8qGVOfQiHPtmzZMDpzqF = Output_11;
                }

                var Output_13 = state_7.__p_NR8qGVOfQiHPtmzZMDpzqF.Update(Singleton_Out: out string Singleton_12);
                n5.GpuValue<n15.Vector3> Default_14 = default(n5.GpuValue<n15.Vector3>);
                bool Is_Groupable_15 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_16 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_17 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx, 3);
                builder_17.Add(RGB_0_In);
                builder_17.Add(RGB_1_In);
                builder_17.Add(blend_In);
                var __pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx_18 = builder_17.Commit();
                var State_Output_21 = state_7.__p_Q5RBOtREG9hNXbMSr7icRx.Update(Arguments_In: __pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx_18, Function_Name_In: __pad_TliUcZDJcdOLGb4S6jvoi3_0, Default_In: Default_14, Mixins_In: Singleton_12, Is_Groupable_In: Is_Groupable_15, The_Modifiers_In: The_Modifiers_16, Output_Out: out n5.GpuValue<n15.Vector3> Output_19, Additional_Outputs_Out: out n10.Spread<n5.AbstractGpuValue> Additional_Outputs_20);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_13 != state_7.__p_NR8qGVOfQiHPtmzZMDpzqF || __pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx_18 != state_7.__pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx || State_Output_21 != state_7.__p_Q5RBOtREG9hNXbMSr7icRx ? new __DOOLyWdELRRLxw8L7WVzDc(state_7)
                    {__p_NR8qGVOfQiHPtmzZMDpzqF = Output_13, __pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx = __pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx_18, __p_Q5RBOtREG9hNXbMSr7icRx = State_Output_21} : state_7;
                else
                {
                    state_7.__p_NR8qGVOfQiHPtmzZMDpzqF = Output_13;
                    state_7.__pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx = __pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx_18;
                    state_7.__p_Q5RBOtREG9hNXbMSr7icRx = State_Output_21;
                }

                outputs_5 = n2.ValueTuple.Create(Output_19);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_22 = outputs_5.Item1;
            RGB_Out = __auto_22;
            n3.OKLabMix_DpVZogM1K76MI4s4jT5rjT that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = manager_3 != this.__cache_E4mOGabaRklMJ6xlvveGQI ? new OKLabMix_DpVZogM1K76MI4s4jT5rjT(this)
                {__cache_E4mOGabaRklMJ6xlvveGQI = manager_3} : that_23;
            else
            {
                this.__cache_E4mOGabaRklMJ6xlvveGQI = manager_3;
            }

            return that_23;
        }

        public n3.OKLabMix_DpVZogM1K76MI4s4jT5rjT __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.OKLabMix_DpVZogM1K76MI4s4jT5rjT that_0 = this;
            this.__cache_E4mOGabaRklMJ6xlvveGQI = null;
            return that_0;
        }

        public n3.OKLabMix_DpVZogM1K76MI4s4jT5rjT __CreateDefault__()
        {
            n3.OKLabMix_DpVZogM1K76MI4s4jT5rjT that_0 = this;
            this.__cache_E4mOGabaRklMJ6xlvveGQI = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_E4mOGabaRklMJ6xlvveGQI);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 332387U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "TliUcZDJcdOLGb4S6jvoi3", Name = "__slot_TliUcZDJcdOLGb4S6jvoi3")]
        public static string __slot_TliUcZDJcdOLGb4S6jvoi3 = "OKLabMix";
        [n1.ElementAttribute(TracingId = 332342U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "E4mOGabaRklMJ6xlvveGQI", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector3>, n5.GpuValue<float>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_E4mOGabaRklMJ6xlvveGQI = null;
        static OKLabMix_DpVZogM1K76MI4s4jT5rjT()
        {
        }

        public OKLabMix_DpVZogM1K76MI4s4jT5rjT(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal OKLabMix_DpVZogM1K76MI4s4jT5rjT(OKLabMix_DpVZogM1K76MI4s4jT5rjT other): base(other)
        {
            this.__cache_E4mOGabaRklMJ6xlvveGQI = other.__cache_E4mOGabaRklMJ6xlvveGQI;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_E4mOGabaRklMJ6xlvveGQI", in __cache_E4mOGabaRklMJ6xlvveGQI));
        }

        internal OKLabMix_DpVZogM1K76MI4s4jT5rjT __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector3>, n5.GpuValue<float>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_E4mOGabaRklMJ6xlvveGQI)
        {
            n3.OKLabMix_DpVZogM1K76MI4s4jT5rjT that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_E4mOGabaRklMJ6xlvveGQI != this.__cache_E4mOGabaRklMJ6xlvveGQI ? new OKLabMix_DpVZogM1K76MI4s4jT5rjT(this)
                {__cache_E4mOGabaRklMJ6xlvveGQI = __cache_E4mOGabaRklMJ6xlvveGQI} : that_0;
            else
            {
                this.__cache_E4mOGabaRklMJ6xlvveGQI = __cache_E4mOGabaRklMJ6xlvveGQI;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "DOOLyWdELRRLxw8L7WVzDc", Name = "__DOOLyWdELRRLxw8L7WVzDc")]
        [n2.SerializableAttribute]
        public class __DOOLyWdELRRLxw8L7WVzDc : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Q5RBOtREG9hNXbMSr7icRx);
                n1.CompilationHelper.SafeDispose(this.__p_NR8qGVOfQiHPtmzZMDpzqF);
                return;
            }

            [n1.ElementAttribute(TracingId = 332363U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Q5RBOtREG9hNXbMSr7icRx", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_Q5RBOtREG9hNXbMSr7icRx;
            [n1.ElementAttribute(TracingId = 332376U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "NR8qGVOfQiHPtmzZMDpzqF", Name = "FuseCoreColor (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_NR8qGVOfQiHPtmzZMDpzqF;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx = default(n10.Spread<n5.AbstractGpuValue>);
            public __DOOLyWdELRRLxw8L7WVzDc(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DOOLyWdELRRLxw8L7WVzDc(__DOOLyWdELRRLxw8L7WVzDc other): base(other)
            {
                this.__p_Q5RBOtREG9hNXbMSr7icRx = other.__p_Q5RBOtREG9hNXbMSr7icRx;
                this.__p_NR8qGVOfQiHPtmzZMDpzqF = other.__p_NR8qGVOfQiHPtmzZMDpzqF;
                this.__pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx = other.__pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Q5RBOtREG9hNXbMSr7icRx", in __p_Q5RBOtREG9hNXbMSr7icRx), n1.CompilationHelper.GetValueOrExisting(values, "__p_NR8qGVOfQiHPtmzZMDpzqF", in __p_NR8qGVOfQiHPtmzZMDpzqF), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx", in __pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx));
            }

            internal __DOOLyWdELRRLxw8L7WVzDc __WITH__(n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_Q5RBOtREG9hNXbMSr7icRx, n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_NR8qGVOfQiHPtmzZMDpzqF, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx)
            {
                __DOOLyWdELRRLxw8L7WVzDc that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Q5RBOtREG9hNXbMSr7icRx != this.__p_Q5RBOtREG9hNXbMSr7icRx || __p_NR8qGVOfQiHPtmzZMDpzqF != this.__p_NR8qGVOfQiHPtmzZMDpzqF || __pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx != this.__pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx ? new __DOOLyWdELRRLxw8L7WVzDc(this)
                    {__p_Q5RBOtREG9hNXbMSr7icRx = __p_Q5RBOtREG9hNXbMSr7icRx, __p_NR8qGVOfQiHPtmzZMDpzqF = __p_NR8qGVOfQiHPtmzZMDpzqF, __pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx = __pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx} : that_0;
                else
                {
                    this.__p_Q5RBOtREG9hNXbMSr7icRx = __p_Q5RBOtREG9hNXbMSr7icRx;
                    this.__p_NR8qGVOfQiHPtmzZMDpzqF = __p_NR8qGVOfQiHPtmzZMDpzqF;
                    this.__pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx = __pin_group_Arguments_In_Q5RBOtREG9hNXbMSr7icRx;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 332443U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "OaeDtV0309OMp1YRnSuD5E", Name = "HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E")]
    [n2.SerializableAttribute]
    public class HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E Create(n1.NodeContext Node_Context)
        {
            var instance = new HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E CreateDefault()
        {
            var instance = new HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E Update(n5.GpuValue<n15.Vector3> HSV_In, out n5.GpuValue<n15.Vector3> RGB_Out)
        {
            string __pad_C0boRX0mFDMPzEpMwfOSG0_0 = __slot_C0boRX0mFDMPzEpMwfOSG0;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_KjGXWX591fqMCXhtQSzvZW;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n15.Vector3>)));
            }

            var inputs_4 = (HSV_In, __pad_C0boRX0mFDMPzEpMwfOSG0_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__Dk1TZ7CBdNyLbjs4BwG0K2>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __Dk1TZ7CBdNyLbjs4BwG0K2(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0 = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "E8s62JentOpOBzevlJMSW0", 332463U);
                    var Output_9 = n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3>.Create(Node_Context: Node_Context_8);
                    state_7.__p_E8s62JentOpOBzevlJMSW0 = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "OHWkdhetc65PGOVepq5hzB", 332477U);
                    var Output_11 = n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX.Create(Node_Context: Node_Context_10);
                    state_7.__p_OHWkdhetc65PGOVepq5hzB = Output_11;
                }

                var Output_13 = state_7.__p_OHWkdhetc65PGOVepq5hzB.Update(Singleton_Out: out string Singleton_12);
                n5.GpuValue<n15.Vector3> Default_14 = default(n5.GpuValue<n15.Vector3>);
                bool Is_Groupable_15 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_16 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_17 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0, 1);
                builder_17.Add(HSV_In);
                var __pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0_18 = builder_17.Commit();
                var State_Output_21 = state_7.__p_E8s62JentOpOBzevlJMSW0.Update(Arguments_In: __pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0_18, Function_Name_In: __pad_C0boRX0mFDMPzEpMwfOSG0_0, Default_In: Default_14, Mixins_In: Singleton_12, Is_Groupable_In: Is_Groupable_15, The_Modifiers_In: The_Modifiers_16, Output_Out: out n5.GpuValue<n15.Vector3> Output_19, Additional_Outputs_Out: out n10.Spread<n5.AbstractGpuValue> Additional_Outputs_20);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_13 != state_7.__p_OHWkdhetc65PGOVepq5hzB || __pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0_18 != state_7.__pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0 || State_Output_21 != state_7.__p_E8s62JentOpOBzevlJMSW0 ? new __Dk1TZ7CBdNyLbjs4BwG0K2(state_7)
                    {__p_OHWkdhetc65PGOVepq5hzB = Output_13, __pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0 = __pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0_18, __p_E8s62JentOpOBzevlJMSW0 = State_Output_21} : state_7;
                else
                {
                    state_7.__p_OHWkdhetc65PGOVepq5hzB = Output_13;
                    state_7.__pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0 = __pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0_18;
                    state_7.__p_E8s62JentOpOBzevlJMSW0 = State_Output_21;
                }

                outputs_5 = n2.ValueTuple.Create(Output_19);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_22 = outputs_5.Item1;
            RGB_Out = __auto_22;
            n3.HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = manager_3 != this.__cache_KjGXWX591fqMCXhtQSzvZW ? new HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E(this)
                {__cache_KjGXWX591fqMCXhtQSzvZW = manager_3} : that_23;
            else
            {
                this.__cache_KjGXWX591fqMCXhtQSzvZW = manager_3;
            }

            return that_23;
        }

        public n3.HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E that_0 = this;
            this.__cache_KjGXWX591fqMCXhtQSzvZW = null;
            return that_0;
        }

        public n3.HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E __CreateDefault__()
        {
            n3.HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E that_0 = this;
            this.__cache_KjGXWX591fqMCXhtQSzvZW = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_KjGXWX591fqMCXhtQSzvZW);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 332491U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "C0boRX0mFDMPzEpMwfOSG0", Name = "__slot_C0boRX0mFDMPzEpMwfOSG0")]
        public static string __slot_C0boRX0mFDMPzEpMwfOSG0 = "HSVtoRGB_smooth";
        [n1.ElementAttribute(TracingId = 332446U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "KjGXWX591fqMCXhtQSzvZW", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_KjGXWX591fqMCXhtQSzvZW = null;
        static HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E()
        {
        }

        public HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E(HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E other): base(other)
        {
            this.__cache_KjGXWX591fqMCXhtQSzvZW = other.__cache_KjGXWX591fqMCXhtQSzvZW;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_KjGXWX591fqMCXhtQSzvZW", in __cache_KjGXWX591fqMCXhtQSzvZW));
        }

        internal HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_KjGXWX591fqMCXhtQSzvZW)
        {
            n3.HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_KjGXWX591fqMCXhtQSzvZW != this.__cache_KjGXWX591fqMCXhtQSzvZW ? new HSVtoRGBSmooth_OaeDtV0309OMp1YRnSuD5E(this)
                {__cache_KjGXWX591fqMCXhtQSzvZW = __cache_KjGXWX591fqMCXhtQSzvZW} : that_0;
            else
            {
                this.__cache_KjGXWX591fqMCXhtQSzvZW = __cache_KjGXWX591fqMCXhtQSzvZW;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Dk1TZ7CBdNyLbjs4BwG0K2", Name = "__Dk1TZ7CBdNyLbjs4BwG0K2")]
        [n2.SerializableAttribute]
        public class __Dk1TZ7CBdNyLbjs4BwG0K2 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_E8s62JentOpOBzevlJMSW0);
                n1.CompilationHelper.SafeDispose(this.__p_OHWkdhetc65PGOVepq5hzB);
                return;
            }

            [n1.ElementAttribute(TracingId = 332463U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "E8s62JentOpOBzevlJMSW0", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_E8s62JentOpOBzevlJMSW0;
            [n1.ElementAttribute(TracingId = 332477U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "OHWkdhetc65PGOVepq5hzB", Name = "FuseCoreColor (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_OHWkdhetc65PGOVepq5hzB;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0 = default(n10.Spread<n5.AbstractGpuValue>);
            public __Dk1TZ7CBdNyLbjs4BwG0K2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Dk1TZ7CBdNyLbjs4BwG0K2(__Dk1TZ7CBdNyLbjs4BwG0K2 other): base(other)
            {
                this.__p_E8s62JentOpOBzevlJMSW0 = other.__p_E8s62JentOpOBzevlJMSW0;
                this.__p_OHWkdhetc65PGOVepq5hzB = other.__p_OHWkdhetc65PGOVepq5hzB;
                this.__pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0 = other.__pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_E8s62JentOpOBzevlJMSW0", in __p_E8s62JentOpOBzevlJMSW0), n1.CompilationHelper.GetValueOrExisting(values, "__p_OHWkdhetc65PGOVepq5hzB", in __p_OHWkdhetc65PGOVepq5hzB), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0", in __pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0));
            }

            internal __Dk1TZ7CBdNyLbjs4BwG0K2 __WITH__(n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_E8s62JentOpOBzevlJMSW0, n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_OHWkdhetc65PGOVepq5hzB, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0)
            {
                __Dk1TZ7CBdNyLbjs4BwG0K2 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_E8s62JentOpOBzevlJMSW0 != this.__p_E8s62JentOpOBzevlJMSW0 || __p_OHWkdhetc65PGOVepq5hzB != this.__p_OHWkdhetc65PGOVepq5hzB || __pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0 != this.__pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0 ? new __Dk1TZ7CBdNyLbjs4BwG0K2(this)
                    {__p_E8s62JentOpOBzevlJMSW0 = __p_E8s62JentOpOBzevlJMSW0, __p_OHWkdhetc65PGOVepq5hzB = __p_OHWkdhetc65PGOVepq5hzB, __pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0 = __pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0} : that_0;
                else
                {
                    this.__p_E8s62JentOpOBzevlJMSW0 = __p_E8s62JentOpOBzevlJMSW0;
                    this.__p_OHWkdhetc65PGOVepq5hzB = __p_OHWkdhetc65PGOVepq5hzB;
                    this.__pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0 = __pin_group_Arguments_In_E8s62JentOpOBzevlJMSW0;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 332527U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "VFPzvWMXkVfOwcPRtHvdqI", Name = "RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI")]
    [n2.SerializableAttribute]
    public class RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T> CreateDefault()
        {
            var instance = new RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T> Update(n5.GpuValue<T> RGB_In, out n5.GpuValue<T> sRGB_Out, out int Output_Out)
        {
            string __pad_CTKypa5XR2fLVXwMYK2Ez8_0 = __slot_CTKypa5XR2fLVXwMYK2Ez8;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_Fc8eQCvk2YQPnRH6eKSg3w;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, string>, n2.ValueTuple<n5.GpuValue<T>, int>>((default(n5.GpuValue<T>), 0));
            }

            var inputs_4 = (RGB_In, __pad_CTKypa5XR2fLVXwMYK2Ez8_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__J5CyIDpqzOxQXl2Ss1HkPB>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __J5CyIDpqzOxQXl2Ss1HkPB(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "JgN8HPapAIcPW4kasHEgcy", 332553U);
                    var Output_9 = n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<T>.Create(Node_Context: Node_Context_8);
                    state_7.__p_JgN8HPapAIcPW4kasHEgcy = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "UvA0leWim9aNXsYckfIxuL", 332584U);
                    var Output_11 = n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX.Create(Node_Context: Node_Context_10);
                    state_7.__p_UvA0leWim9aNXsYckfIxuL = Output_11;
                }

                var Result_12 = n5.TypeHelpers.GetDimension<T>(theValue: RGB_In);
                var Result_13 = n19.ObjectHelpers.ToString(input: Result_12);
                var Output_14 = n20.StringExtensions.Plus(input: __pad_CTKypa5XR2fLVXwMYK2Ez8_0, input2: Result_13);
                var Output_16 = state_7.__p_UvA0leWim9aNXsYckfIxuL.Update(Singleton_Out: out string Singleton_15);
                n5.GpuValue<T> Default_17 = default(n5.GpuValue<T>);
                bool Is_Groupable_18 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_19 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_20 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy, 1);
                builder_20.Add(RGB_In);
                var __pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy_21 = builder_20.Commit();
                var State_Output_24 = state_7.__p_JgN8HPapAIcPW4kasHEgcy.Update(Arguments_In: __pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy_21, Function_Name_In: Output_14, Default_In: Default_17, Mixins_In: Singleton_15, Is_Groupable_In: Is_Groupable_18, The_Modifiers_In: The_Modifiers_19, Output_Out: out n5.GpuValue<T> Output_22, Additional_Outputs_Out: out n10.Spread<n5.AbstractGpuValue> Additional_Outputs_23);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_16 != state_7.__p_UvA0leWim9aNXsYckfIxuL || __pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy_21 != state_7.__pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy || State_Output_24 != state_7.__p_JgN8HPapAIcPW4kasHEgcy ? new __J5CyIDpqzOxQXl2Ss1HkPB(state_7)
                    {__p_UvA0leWim9aNXsYckfIxuL = Output_16, __pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy = __pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy_21, __p_JgN8HPapAIcPW4kasHEgcy = State_Output_24} : state_7;
                else
                {
                    state_7.__p_UvA0leWim9aNXsYckfIxuL = Output_16;
                    state_7.__pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy = __pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy_21;
                    state_7.__p_JgN8HPapAIcPW4kasHEgcy = State_Output_24;
                }

                outputs_5 = (Output_22, Result_12);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var(__auto_25, __auto_26) = outputs_5;
            sRGB_Out = __auto_25;
            Output_Out = __auto_26;
            n3.RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T> that_27 = this;
            if (this.__GetContext__().IsImmutable)
                that_27 = manager_3 != this.__cache_Fc8eQCvk2YQPnRH6eKSg3w ? new RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T>(this)
                {__cache_Fc8eQCvk2YQPnRH6eKSg3w = manager_3} : that_27;
            else
            {
                this.__cache_Fc8eQCvk2YQPnRH6eKSg3w = manager_3;
            }

            return that_27;
        }

        public n3.RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T> that_0 = this;
            this.__cache_Fc8eQCvk2YQPnRH6eKSg3w = null;
            return that_0;
        }

        public n3.RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T> __CreateDefault__()
        {
            n3.RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T> that_0 = this;
            this.__cache_Fc8eQCvk2YQPnRH6eKSg3w = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_Fc8eQCvk2YQPnRH6eKSg3w);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 332601U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "CTKypa5XR2fLVXwMYK2Ez8", Name = "__slot_CTKypa5XR2fLVXwMYK2Ez8")]
        public static string __slot_CTKypa5XR2fLVXwMYK2Ez8 = "LinearToSRGB";
        [n1.ElementAttribute(TracingId = 332532U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Fc8eQCvk2YQPnRH6eKSg3w", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, string>, n2.ValueTuple<n5.GpuValue<T>, int>> __cache_Fc8eQCvk2YQPnRH6eKSg3w = null;
        static RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI()
        {
        }

        public RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI(RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T> other): base(other)
        {
            this.__cache_Fc8eQCvk2YQPnRH6eKSg3w = other.__cache_Fc8eQCvk2YQPnRH6eKSg3w;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Fc8eQCvk2YQPnRH6eKSg3w", in __cache_Fc8eQCvk2YQPnRH6eKSg3w));
        }

        internal RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, string>, n2.ValueTuple<n5.GpuValue<T>, int>> __cache_Fc8eQCvk2YQPnRH6eKSg3w)
        {
            n3.RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Fc8eQCvk2YQPnRH6eKSg3w != this.__cache_Fc8eQCvk2YQPnRH6eKSg3w ? new RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<T>(this)
                {__cache_Fc8eQCvk2YQPnRH6eKSg3w = __cache_Fc8eQCvk2YQPnRH6eKSg3w} : that_0;
            else
            {
                this.__cache_Fc8eQCvk2YQPnRH6eKSg3w = __cache_Fc8eQCvk2YQPnRH6eKSg3w;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "J5CyIDpqzOxQXl2Ss1HkPB", Name = "__J5CyIDpqzOxQXl2Ss1HkPB")]
        [n2.SerializableAttribute]
        public class __J5CyIDpqzOxQXl2Ss1HkPB : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_JgN8HPapAIcPW4kasHEgcy);
                n1.CompilationHelper.SafeDispose(this.__p_UvA0leWim9aNXsYckfIxuL);
                return;
            }

            [n1.ElementAttribute(TracingId = 332553U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "JgN8HPapAIcPW4kasHEgcy", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<T> __p_JgN8HPapAIcPW4kasHEgcy;
            [n1.ElementAttribute(TracingId = 332584U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "UvA0leWim9aNXsYckfIxuL", Name = "FuseCoreColor (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_UvA0leWim9aNXsYckfIxuL;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy = default(n10.Spread<n5.AbstractGpuValue>);
            public __J5CyIDpqzOxQXl2Ss1HkPB(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __J5CyIDpqzOxQXl2Ss1HkPB(__J5CyIDpqzOxQXl2Ss1HkPB other): base(other)
            {
                this.__p_JgN8HPapAIcPW4kasHEgcy = other.__p_JgN8HPapAIcPW4kasHEgcy;
                this.__p_UvA0leWim9aNXsYckfIxuL = other.__p_UvA0leWim9aNXsYckfIxuL;
                this.__pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy = other.__pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JgN8HPapAIcPW4kasHEgcy", in __p_JgN8HPapAIcPW4kasHEgcy), n1.CompilationHelper.GetValueOrExisting(values, "__p_UvA0leWim9aNXsYckfIxuL", in __p_UvA0leWim9aNXsYckfIxuL), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy", in __pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy));
            }

            internal __J5CyIDpqzOxQXl2Ss1HkPB __WITH__(n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<T> __p_JgN8HPapAIcPW4kasHEgcy, n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_UvA0leWim9aNXsYckfIxuL, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy)
            {
                __J5CyIDpqzOxQXl2Ss1HkPB that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_JgN8HPapAIcPW4kasHEgcy != this.__p_JgN8HPapAIcPW4kasHEgcy || __p_UvA0leWim9aNXsYckfIxuL != this.__p_UvA0leWim9aNXsYckfIxuL || __pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy != this.__pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy ? new __J5CyIDpqzOxQXl2Ss1HkPB(this)
                    {__p_JgN8HPapAIcPW4kasHEgcy = __p_JgN8HPapAIcPW4kasHEgcy, __p_UvA0leWim9aNXsYckfIxuL = __p_UvA0leWim9aNXsYckfIxuL, __pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy = __pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy} : that_0;
                else
                {
                    this.__p_JgN8HPapAIcPW4kasHEgcy = __p_JgN8HPapAIcPW4kasHEgcy;
                    this.__p_UvA0leWim9aNXsYckfIxuL = __p_UvA0leWim9aNXsYckfIxuL;
                    this.__pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy = __pin_group_Arguments_In_JgN8HPapAIcPW4kasHEgcy;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 332653U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "ImvAPNRgqi4MyMa115cMZI", Name = "SRGBToRGB_ImvAPNRgqi4MyMa115cMZI")]
    [n2.SerializableAttribute]
    public class SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T> CreateDefault()
        {
            var instance = new SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T> Update(n5.GpuValue<T> sRGB_In, out n5.GpuValue<T> RGB_Out)
        {
            string __pad_BS84SMGa3gVLzcZax2i3TL_0 = __slot_BS84SMGa3gVLzcZax2i3TL;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_FDzG3lnvakQORV4eIgkyyk;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, string>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_4 = (sRGB_In, __pad_BS84SMGa3gVLzcZax2i3TL_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__QQ8tqXl2uTxQGipvfQIeLp>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __QQ8tqXl2uTxQGipvfQIeLp(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "SlqTsv6785bMIglq52DXwP", 332676U);
                    var Output_9 = n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<T>.Create(Node_Context: Node_Context_8);
                    state_7.__p_SlqTsv6785bMIglq52DXwP = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "BSOnnB7qyYrNqxDqZmk1O6", 332708U);
                    var Output_11 = n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX.Create(Node_Context: Node_Context_10);
                    state_7.__p_BSOnnB7qyYrNqxDqZmk1O6 = Output_11;
                }

                var Result_12 = n5.TypeHelpers.GetDimension<T>(theValue: sRGB_In);
                var Result_13 = n19.ObjectHelpers.ToString(input: Result_12);
                var Output_14 = n20.StringExtensions.Plus(input: __pad_BS84SMGa3gVLzcZax2i3TL_0, input2: Result_13);
                var Output_16 = state_7.__p_BSOnnB7qyYrNqxDqZmk1O6.Update(Singleton_Out: out string Singleton_15);
                n5.GpuValue<T> Default_17 = default(n5.GpuValue<T>);
                bool Is_Groupable_18 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_19 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_20 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP, 1);
                builder_20.Add(sRGB_In);
                var __pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP_21 = builder_20.Commit();
                var State_Output_24 = state_7.__p_SlqTsv6785bMIglq52DXwP.Update(Arguments_In: __pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP_21, Function_Name_In: Output_14, Default_In: Default_17, Mixins_In: Singleton_15, Is_Groupable_In: Is_Groupable_18, The_Modifiers_In: The_Modifiers_19, Output_Out: out n5.GpuValue<T> Output_22, Additional_Outputs_Out: out n10.Spread<n5.AbstractGpuValue> Additional_Outputs_23);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_16 != state_7.__p_BSOnnB7qyYrNqxDqZmk1O6 || __pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP_21 != state_7.__pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP || State_Output_24 != state_7.__p_SlqTsv6785bMIglq52DXwP ? new __QQ8tqXl2uTxQGipvfQIeLp(state_7)
                    {__p_BSOnnB7qyYrNqxDqZmk1O6 = Output_16, __pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP = __pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP_21, __p_SlqTsv6785bMIglq52DXwP = State_Output_24} : state_7;
                else
                {
                    state_7.__p_BSOnnB7qyYrNqxDqZmk1O6 = Output_16;
                    state_7.__pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP = __pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP_21;
                    state_7.__p_SlqTsv6785bMIglq52DXwP = State_Output_24;
                }

                outputs_5 = n2.ValueTuple.Create(Output_22);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_25 = outputs_5.Item1;
            RGB_Out = __auto_25;
            n3.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T> that_26 = this;
            if (this.__GetContext__().IsImmutable)
                that_26 = manager_3 != this.__cache_FDzG3lnvakQORV4eIgkyyk ? new SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T>(this)
                {__cache_FDzG3lnvakQORV4eIgkyyk = manager_3} : that_26;
            else
            {
                this.__cache_FDzG3lnvakQORV4eIgkyyk = manager_3;
            }

            return that_26;
        }

        public n3.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T> that_0 = this;
            this.__cache_FDzG3lnvakQORV4eIgkyyk = null;
            return that_0;
        }

        public n3.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T> __CreateDefault__()
        {
            n3.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T> that_0 = this;
            this.__cache_FDzG3lnvakQORV4eIgkyyk = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_FDzG3lnvakQORV4eIgkyyk);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 332723U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "BS84SMGa3gVLzcZax2i3TL", Name = "__slot_BS84SMGa3gVLzcZax2i3TL")]
        public static string __slot_BS84SMGa3gVLzcZax2i3TL = "SRGBToLinear";
        [n1.ElementAttribute(TracingId = 332659U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "FDzG3lnvakQORV4eIgkyyk", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_FDzG3lnvakQORV4eIgkyyk = null;
        static SRGBToRGB_ImvAPNRgqi4MyMa115cMZI()
        {
        }

        public SRGBToRGB_ImvAPNRgqi4MyMa115cMZI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SRGBToRGB_ImvAPNRgqi4MyMa115cMZI(SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T> other): base(other)
        {
            this.__cache_FDzG3lnvakQORV4eIgkyyk = other.__cache_FDzG3lnvakQORV4eIgkyyk;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_FDzG3lnvakQORV4eIgkyyk", in __cache_FDzG3lnvakQORV4eIgkyyk));
        }

        internal SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_FDzG3lnvakQORV4eIgkyyk)
        {
            n3.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_FDzG3lnvakQORV4eIgkyyk != this.__cache_FDzG3lnvakQORV4eIgkyyk ? new SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<T>(this)
                {__cache_FDzG3lnvakQORV4eIgkyyk = __cache_FDzG3lnvakQORV4eIgkyyk} : that_0;
            else
            {
                this.__cache_FDzG3lnvakQORV4eIgkyyk = __cache_FDzG3lnvakQORV4eIgkyyk;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "QQ8tqXl2uTxQGipvfQIeLp", Name = "__QQ8tqXl2uTxQGipvfQIeLp")]
        [n2.SerializableAttribute]
        public class __QQ8tqXl2uTxQGipvfQIeLp : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_SlqTsv6785bMIglq52DXwP);
                n1.CompilationHelper.SafeDispose(this.__p_BSOnnB7qyYrNqxDqZmk1O6);
                return;
            }

            [n1.ElementAttribute(TracingId = 332676U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "SlqTsv6785bMIglq52DXwP", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<T> __p_SlqTsv6785bMIglq52DXwP;
            [n1.ElementAttribute(TracingId = 332708U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "BSOnnB7qyYrNqxDqZmk1O6", Name = "FuseCoreColor (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_BSOnnB7qyYrNqxDqZmk1O6;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP = default(n10.Spread<n5.AbstractGpuValue>);
            public __QQ8tqXl2uTxQGipvfQIeLp(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __QQ8tqXl2uTxQGipvfQIeLp(__QQ8tqXl2uTxQGipvfQIeLp other): base(other)
            {
                this.__p_SlqTsv6785bMIglq52DXwP = other.__p_SlqTsv6785bMIglq52DXwP;
                this.__p_BSOnnB7qyYrNqxDqZmk1O6 = other.__p_BSOnnB7qyYrNqxDqZmk1O6;
                this.__pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP = other.__pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_SlqTsv6785bMIglq52DXwP", in __p_SlqTsv6785bMIglq52DXwP), n1.CompilationHelper.GetValueOrExisting(values, "__p_BSOnnB7qyYrNqxDqZmk1O6", in __p_BSOnnB7qyYrNqxDqZmk1O6), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP", in __pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP));
            }

            internal __QQ8tqXl2uTxQGipvfQIeLp __WITH__(n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<T> __p_SlqTsv6785bMIglq52DXwP, n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_BSOnnB7qyYrNqxDqZmk1O6, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP)
            {
                __QQ8tqXl2uTxQGipvfQIeLp that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_SlqTsv6785bMIglq52DXwP != this.__p_SlqTsv6785bMIglq52DXwP || __p_BSOnnB7qyYrNqxDqZmk1O6 != this.__p_BSOnnB7qyYrNqxDqZmk1O6 || __pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP != this.__pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP ? new __QQ8tqXl2uTxQGipvfQIeLp(this)
                    {__p_SlqTsv6785bMIglq52DXwP = __p_SlqTsv6785bMIglq52DXwP, __p_BSOnnB7qyYrNqxDqZmk1O6 = __p_BSOnnB7qyYrNqxDqZmk1O6, __pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP = __pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP} : that_0;
                else
                {
                    this.__p_SlqTsv6785bMIglq52DXwP = __p_SlqTsv6785bMIglq52DXwP;
                    this.__p_BSOnnB7qyYrNqxDqZmk1O6 = __p_BSOnnB7qyYrNqxDqZmk1O6;
                    this.__pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP = __pin_group_Arguments_In_SlqTsv6785bMIglq52DXwP;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 332770U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "C1YWWguxzwBObImzZZ1Pog", Name = "Palettes_C1YWWguxzwBObImzZZ1Pog")]
    [n2.SerializableAttribute]
    public class Palettes_C1YWWguxzwBObImzZZ1Pog : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Palettes_C1YWWguxzwBObImzZZ1Pog Create(n1.NodeContext Node_Context)
        {
            var instance = new Palettes_C1YWWguxzwBObImzZZ1Pog(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Palettes_C1YWWguxzwBObImzZZ1Pog CreateDefault()
        {
            var instance = new Palettes_C1YWWguxzwBObImzZZ1Pog(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Palettes_C1YWWguxzwBObImzZZ1Pog Update(n5.GpuValue<float> Input_In, n5.GpuValue<n15.Vector3> Offset_In, n5.GpuValue<n15.Vector3> Amplitutde_In, n5.GpuValue<n15.Vector3> Frequency_In, n5.GpuValue<n15.Vector3> Phase_In, out n5.GpuValue<n15.Vector3> RGB_Out)
        {
            string __pad_MpAGHXED5y5LeM8bwOP0eD_0 = __slot_MpAGHXED5y5LeM8bwOP0eD;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_V2eu7QEBSUrN7pQHbP3WmR;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n15.Vector3>)));
            }

            var inputs_4 = (Input_In, Offset_In, Amplitutde_In, Frequency_In, Phase_In, __pad_MpAGHXED5y5LeM8bwOP0eD_0);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__ORSiyhj6iMfMD6mDpCeJK2>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __ORSiyhj6iMfMD6mDpCeJK2(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "SEQekaWZi3YLCgEPrSlF6V", 332798U);
                    var Output_9 = n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3>.Create(Node_Context: Node_Context_8);
                    state_7.__p_SEQekaWZi3YLCgEPrSlF6V = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "BHfXWkQOzvNLnAcxlmMccH", 332820U);
                    var Output_11 = n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX.Create(Node_Context: Node_Context_10);
                    state_7.__p_BHfXWkQOzvNLnAcxlmMccH = Output_11;
                }

                var Output_13 = state_7.__p_BHfXWkQOzvNLnAcxlmMccH.Update(Singleton_Out: out string Singleton_12);
                n5.GpuValue<n15.Vector3> Default_14 = default(n5.GpuValue<n15.Vector3>);
                bool Is_Groupable_15 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_16 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_17 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V, 5);
                builder_17.Add(Input_In);
                builder_17.Add(Offset_In);
                builder_17.Add(Amplitutde_In);
                builder_17.Add(Frequency_In);
                builder_17.Add(Phase_In);
                var __pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V_18 = builder_17.Commit();
                var State_Output_21 = state_7.__p_SEQekaWZi3YLCgEPrSlF6V.Update(Arguments_In: __pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V_18, Function_Name_In: __pad_MpAGHXED5y5LeM8bwOP0eD_0, Default_In: Default_14, Mixins_In: Singleton_12, Is_Groupable_In: Is_Groupable_15, The_Modifiers_In: The_Modifiers_16, Output_Out: out n5.GpuValue<n15.Vector3> Output_19, Additional_Outputs_Out: out n10.Spread<n5.AbstractGpuValue> Additional_Outputs_20);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_13 != state_7.__p_BHfXWkQOzvNLnAcxlmMccH || __pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V_18 != state_7.__pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V || State_Output_21 != state_7.__p_SEQekaWZi3YLCgEPrSlF6V ? new __ORSiyhj6iMfMD6mDpCeJK2(state_7)
                    {__p_BHfXWkQOzvNLnAcxlmMccH = Output_13, __pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V = __pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V_18, __p_SEQekaWZi3YLCgEPrSlF6V = State_Output_21} : state_7;
                else
                {
                    state_7.__p_BHfXWkQOzvNLnAcxlmMccH = Output_13;
                    state_7.__pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V = __pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V_18;
                    state_7.__p_SEQekaWZi3YLCgEPrSlF6V = State_Output_21;
                }

                outputs_5 = n2.ValueTuple.Create(Output_19);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_22 = outputs_5.Item1;
            RGB_Out = __auto_22;
            n3.Palettes_C1YWWguxzwBObImzZZ1Pog that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = manager_3 != this.__cache_V2eu7QEBSUrN7pQHbP3WmR ? new Palettes_C1YWWguxzwBObImzZZ1Pog(this)
                {__cache_V2eu7QEBSUrN7pQHbP3WmR = manager_3} : that_23;
            else
            {
                this.__cache_V2eu7QEBSUrN7pQHbP3WmR = manager_3;
            }

            return that_23;
        }

        public n3.Palettes_C1YWWguxzwBObImzZZ1Pog __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Palettes_C1YWWguxzwBObImzZZ1Pog that_0 = this;
            this.__cache_V2eu7QEBSUrN7pQHbP3WmR = null;
            return that_0;
        }

        public n3.Palettes_C1YWWguxzwBObImzZZ1Pog __CreateDefault__()
        {
            n3.Palettes_C1YWWguxzwBObImzZZ1Pog that_0 = this;
            this.__cache_V2eu7QEBSUrN7pQHbP3WmR = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_V2eu7QEBSUrN7pQHbP3WmR);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 332832U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "MpAGHXED5y5LeM8bwOP0eD", Name = "__slot_MpAGHXED5y5LeM8bwOP0eD")]
        public static string __slot_MpAGHXED5y5LeM8bwOP0eD = "pal";
        [n1.ElementAttribute(TracingId = 332774U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "V2eu7QEBSUrN7pQHbP3WmR", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_V2eu7QEBSUrN7pQHbP3WmR = null;
        static Palettes_C1YWWguxzwBObImzZZ1Pog()
        {
        }

        public Palettes_C1YWWguxzwBObImzZZ1Pog(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Palettes_C1YWWguxzwBObImzZZ1Pog(Palettes_C1YWWguxzwBObImzZZ1Pog other): base(other)
        {
            this.__cache_V2eu7QEBSUrN7pQHbP3WmR = other.__cache_V2eu7QEBSUrN7pQHbP3WmR;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_V2eu7QEBSUrN7pQHbP3WmR", in __cache_V2eu7QEBSUrN7pQHbP3WmR));
        }

        internal Palettes_C1YWWguxzwBObImzZZ1Pog __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector3>, string>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_V2eu7QEBSUrN7pQHbP3WmR)
        {
            n3.Palettes_C1YWWguxzwBObImzZZ1Pog that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_V2eu7QEBSUrN7pQHbP3WmR != this.__cache_V2eu7QEBSUrN7pQHbP3WmR ? new Palettes_C1YWWguxzwBObImzZZ1Pog(this)
                {__cache_V2eu7QEBSUrN7pQHbP3WmR = __cache_V2eu7QEBSUrN7pQHbP3WmR} : that_0;
            else
            {
                this.__cache_V2eu7QEBSUrN7pQHbP3WmR = __cache_V2eu7QEBSUrN7pQHbP3WmR;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "ORSiyhj6iMfMD6mDpCeJK2", Name = "__ORSiyhj6iMfMD6mDpCeJK2")]
        [n2.SerializableAttribute]
        public class __ORSiyhj6iMfMD6mDpCeJK2 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_SEQekaWZi3YLCgEPrSlF6V);
                n1.CompilationHelper.SafeDispose(this.__p_BHfXWkQOzvNLnAcxlmMccH);
                return;
            }

            [n1.ElementAttribute(TracingId = 332798U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "SEQekaWZi3YLCgEPrSlF6V", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_SEQekaWZi3YLCgEPrSlF6V;
            [n1.ElementAttribute(TracingId = 332820U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "BHfXWkQOzvNLnAcxlmMccH", Name = "FuseCoreColor (Mixin)", IsManaged = true, IsAutoGenerated = true)]
            public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_BHfXWkQOzvNLnAcxlmMccH;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V = default(n10.Spread<n5.AbstractGpuValue>);
            public __ORSiyhj6iMfMD6mDpCeJK2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __ORSiyhj6iMfMD6mDpCeJK2(__ORSiyhj6iMfMD6mDpCeJK2 other): base(other)
            {
                this.__p_SEQekaWZi3YLCgEPrSlF6V = other.__p_SEQekaWZi3YLCgEPrSlF6V;
                this.__p_BHfXWkQOzvNLnAcxlmMccH = other.__p_BHfXWkQOzvNLnAcxlmMccH;
                this.__pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V = other.__pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_SEQekaWZi3YLCgEPrSlF6V", in __p_SEQekaWZi3YLCgEPrSlF6V), n1.CompilationHelper.GetValueOrExisting(values, "__p_BHfXWkQOzvNLnAcxlmMccH", in __p_BHfXWkQOzvNLnAcxlmMccH), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V", in __pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V));
            }

            internal __ORSiyhj6iMfMD6mDpCeJK2 __WITH__(n16.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n15.Vector3> __p_SEQekaWZi3YLCgEPrSlF6V, n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __p_BHfXWkQOzvNLnAcxlmMccH, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V)
            {
                __ORSiyhj6iMfMD6mDpCeJK2 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_SEQekaWZi3YLCgEPrSlF6V != this.__p_SEQekaWZi3YLCgEPrSlF6V || __p_BHfXWkQOzvNLnAcxlmMccH != this.__p_BHfXWkQOzvNLnAcxlmMccH || __pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V != this.__pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V ? new __ORSiyhj6iMfMD6mDpCeJK2(this)
                    {__p_SEQekaWZi3YLCgEPrSlF6V = __p_SEQekaWZi3YLCgEPrSlF6V, __p_BHfXWkQOzvNLnAcxlmMccH = __p_BHfXWkQOzvNLnAcxlmMccH, __pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V = __pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V} : that_0;
                else
                {
                    this.__p_SEQekaWZi3YLCgEPrSlF6V = __p_SEQekaWZi3YLCgEPrSlF6V;
                    this.__p_BHfXWkQOzvNLnAcxlmMccH = __p_BHfXWkQOzvNLnAcxlmMccH;
                    this.__pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V = __pin_group_Arguments_In_SEQekaWZi3YLCgEPrSlF6V;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 332917U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "NmI9dmD7YCWNhRfKXZL3Kg", Name = "ToRGB_NmI9dmD7YCWNhRfKXZL3Kg")]
    [n2.SerializableAttribute]
    public class ToRGB_NmI9dmD7YCWNhRfKXZL3Kg : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ToRGB_NmI9dmD7YCWNhRfKXZL3Kg Create(n1.NodeContext Node_Context)
        {
            var instance = new ToRGB_NmI9dmD7YCWNhRfKXZL3Kg(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ToRGB_NmI9dmD7YCWNhRfKXZL3Kg CreateDefault()
        {
            var instance = new ToRGB_NmI9dmD7YCWNhRfKXZL3Kg(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ToRGB_NmI9dmD7YCWNhRfKXZL3Kg Update(n21.ColorSpace ColorSpace_In, n5.GpuValue<n15.Vector3> Color_In, out n5.GpuValue<n15.Vector3> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_MRyBaMigGvtPO24O16RZmN;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n21.ColorSpace, n5.GpuValue<n15.Vector3>>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n15.Vector3>)));
            }

            var inputs_3 = (ColorSpace_In, Color_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__MeRAiFqTFeMMZ0OUE9cHp4>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __MeRAiFqTFeMMZ0OUE9cHp4(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_Ve059I5HTURQJzhfycqX1g = n11._Operations_.CreateDefault<n5.GpuValue<n15.Vector3>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "RpjYamwJEThOaGP6hD5l3C", 332957U);
                    var Output_8 = n3.HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R.Create(Node_Context: Node_Context_7);
                    state_6.__p_RpjYamwJEThOaGP6hD5l3C = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "PTxU9p8Ny96PezFUJ2bd9g", 332965U);
                    var Output_10 = n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ.Create(Node_Context: Node_Context_9);
                    state_6.__p_PTxU9p8Ny96PezFUJ2bd9g = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "JaAHhHgg3WxME3owgYTjch", 332973U);
                    var Output_12 = n3.OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf.Create(Node_Context: Node_Context_11);
                    state_6.__p_JaAHhHgg3WxME3owgYTjch = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "JRS1MWNb7nxMl81emtzzGt", 332978U);
                    var Output_14 = n3.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<n15.Vector3>.Create(Node_Context: Node_Context_13);
                    state_6.__p_JRS1MWNb7nxMl81emtzzGt = Output_14;
                }

                int Index_15 = (int)ColorSpace_In;
                var Output_17 = state_6.__p_RpjYamwJEThOaGP6hD5l3C.Update(HSL_In: Color_In, RGB_Out: out n5.GpuValue<n15.Vector3> RGB_16);
                var Output_19 = state_6.__p_PTxU9p8Ny96PezFUJ2bd9g.Update(HSV_In: Color_In, RGB_Out: out n5.GpuValue<n15.Vector3> RGB_18);
                var Output_21 = state_6.__p_JaAHhHgg3WxME3owgYTjch.Update(OKLab_In: Color_In, RGB_Out: out n5.GpuValue<n15.Vector3> RGB_20);
                var Output_23 = state_6.__p_JRS1MWNb7nxMl81emtzzGt.Update(sRGB_In: Color_In, RGB_Out: out n5.GpuValue<n15.Vector3> RGB_22);
                var builder_24 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Ve059I5HTURQJzhfycqX1g, 5);
                builder_24.Add(Color_In);
                builder_24.Add(RGB_16);
                builder_24.Add(RGB_18);
                builder_24.Add(RGB_20);
                builder_24.Add(RGB_22);
                var __pin_group_Input_In_Ve059I5HTURQJzhfycqX1g_25 = builder_24.Commit();
                n23._Operations_.Switch<n5.GpuValue<n15.Vector3>, n22.__AdaptiveImplementations__NvxFK0tAsVyMwtaYRjadP2>(Index_In: Index_15, Input_In: __pin_group_Input_In_Ve059I5HTURQJzhfycqX1g_25, Output_Out: out n5.GpuValue<n15.Vector3> Output_26);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = Output_17 != state_6.__p_RpjYamwJEThOaGP6hD5l3C || Output_19 != state_6.__p_PTxU9p8Ny96PezFUJ2bd9g || Output_21 != state_6.__p_JaAHhHgg3WxME3owgYTjch || Output_23 != state_6.__p_JRS1MWNb7nxMl81emtzzGt || __pin_group_Input_In_Ve059I5HTURQJzhfycqX1g_25 != state_6.__pin_group_Input_In_Ve059I5HTURQJzhfycqX1g ? new __MeRAiFqTFeMMZ0OUE9cHp4(state_6)
                    {__p_RpjYamwJEThOaGP6hD5l3C = Output_17, __p_PTxU9p8Ny96PezFUJ2bd9g = Output_19, __p_JaAHhHgg3WxME3owgYTjch = Output_21, __p_JRS1MWNb7nxMl81emtzzGt = Output_23, __pin_group_Input_In_Ve059I5HTURQJzhfycqX1g = __pin_group_Input_In_Ve059I5HTURQJzhfycqX1g_25} : state_6;
                else
                {
                    state_6.__p_RpjYamwJEThOaGP6hD5l3C = Output_17;
                    state_6.__p_PTxU9p8Ny96PezFUJ2bd9g = Output_19;
                    state_6.__p_JaAHhHgg3WxME3owgYTjch = Output_21;
                    state_6.__p_JRS1MWNb7nxMl81emtzzGt = Output_23;
                    state_6.__pin_group_Input_In_Ve059I5HTURQJzhfycqX1g = __pin_group_Input_In_Ve059I5HTURQJzhfycqX1g_25;
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
            n3.ToRGB_NmI9dmD7YCWNhRfKXZL3Kg that_28 = this;
            if (this.__GetContext__().IsImmutable)
                that_28 = manager_2 != this.__cache_MRyBaMigGvtPO24O16RZmN ? new ToRGB_NmI9dmD7YCWNhRfKXZL3Kg(this)
                {__cache_MRyBaMigGvtPO24O16RZmN = manager_2} : that_28;
            else
            {
                this.__cache_MRyBaMigGvtPO24O16RZmN = manager_2;
            }

            return that_28;
        }

        public n3.ToRGB_NmI9dmD7YCWNhRfKXZL3Kg __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.ToRGB_NmI9dmD7YCWNhRfKXZL3Kg that_0 = this;
            this.__cache_MRyBaMigGvtPO24O16RZmN = null;
            return that_0;
        }

        public n3.ToRGB_NmI9dmD7YCWNhRfKXZL3Kg __CreateDefault__()
        {
            n3.ToRGB_NmI9dmD7YCWNhRfKXZL3Kg that_0 = this;
            this.__cache_MRyBaMigGvtPO24O16RZmN = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_MRyBaMigGvtPO24O16RZmN);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 332921U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "MRyBaMigGvtPO24O16RZmN", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n21.ColorSpace, n5.GpuValue<n15.Vector3>>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_MRyBaMigGvtPO24O16RZmN = null;
        public ToRGB_NmI9dmD7YCWNhRfKXZL3Kg(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ToRGB_NmI9dmD7YCWNhRfKXZL3Kg(ToRGB_NmI9dmD7YCWNhRfKXZL3Kg other): base(other)
        {
            this.__cache_MRyBaMigGvtPO24O16RZmN = other.__cache_MRyBaMigGvtPO24O16RZmN;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_MRyBaMigGvtPO24O16RZmN", in __cache_MRyBaMigGvtPO24O16RZmN));
        }

        internal ToRGB_NmI9dmD7YCWNhRfKXZL3Kg __WITH__(n6.Manager<n2.ValueTuple<n21.ColorSpace, n5.GpuValue<n15.Vector3>>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_MRyBaMigGvtPO24O16RZmN)
        {
            n3.ToRGB_NmI9dmD7YCWNhRfKXZL3Kg that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_MRyBaMigGvtPO24O16RZmN != this.__cache_MRyBaMigGvtPO24O16RZmN ? new ToRGB_NmI9dmD7YCWNhRfKXZL3Kg(this)
                {__cache_MRyBaMigGvtPO24O16RZmN = __cache_MRyBaMigGvtPO24O16RZmN} : that_0;
            else
            {
                this.__cache_MRyBaMigGvtPO24O16RZmN = __cache_MRyBaMigGvtPO24O16RZmN;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "MeRAiFqTFeMMZ0OUE9cHp4", Name = "__MeRAiFqTFeMMZ0OUE9cHp4")]
        [n2.SerializableAttribute]
        public class __MeRAiFqTFeMMZ0OUE9cHp4 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RpjYamwJEThOaGP6hD5l3C);
                n1.CompilationHelper.SafeDispose(this.__p_PTxU9p8Ny96PezFUJ2bd9g);
                n1.CompilationHelper.SafeDispose(this.__p_JaAHhHgg3WxME3owgYTjch);
                n1.CompilationHelper.SafeDispose(this.__p_JRS1MWNb7nxMl81emtzzGt);
                return;
            }

            [n1.ElementAttribute(TracingId = 332957U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "RpjYamwJEThOaGP6hD5l3C", Name = "HSLtoRGB", IsManaged = true, IsAutoGenerated = true)]
            public n3.HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R __p_RpjYamwJEThOaGP6hD5l3C;
            [n1.ElementAttribute(TracingId = 332965U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "PTxU9p8Ny96PezFUJ2bd9g", Name = "HSVtoRGB", IsManaged = true, IsAutoGenerated = true)]
            public n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ __p_PTxU9p8Ny96PezFUJ2bd9g;
            [n1.ElementAttribute(TracingId = 332973U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "JaAHhHgg3WxME3owgYTjch", Name = "OKLabToRGB", IsManaged = true, IsAutoGenerated = true)]
            public n3.OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf __p_JaAHhHgg3WxME3owgYTjch;
            [n1.ElementAttribute(TracingId = 332978U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "JRS1MWNb7nxMl81emtzzGt", Name = "SRGBToRGB", IsManaged = true, IsAutoGenerated = true)]
            public n3.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<n15.Vector3> __p_JRS1MWNb7nxMl81emtzzGt;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<n15.Vector3>> __pin_group_Input_In_Ve059I5HTURQJzhfycqX1g = default(n10.Spread<n5.GpuValue<n15.Vector3>>);
            public __MeRAiFqTFeMMZ0OUE9cHp4(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MeRAiFqTFeMMZ0OUE9cHp4(__MeRAiFqTFeMMZ0OUE9cHp4 other): base(other)
            {
                this.__p_RpjYamwJEThOaGP6hD5l3C = other.__p_RpjYamwJEThOaGP6hD5l3C;
                this.__p_PTxU9p8Ny96PezFUJ2bd9g = other.__p_PTxU9p8Ny96PezFUJ2bd9g;
                this.__p_JaAHhHgg3WxME3owgYTjch = other.__p_JaAHhHgg3WxME3owgYTjch;
                this.__p_JRS1MWNb7nxMl81emtzzGt = other.__p_JRS1MWNb7nxMl81emtzzGt;
                this.__pin_group_Input_In_Ve059I5HTURQJzhfycqX1g = other.__pin_group_Input_In_Ve059I5HTURQJzhfycqX1g;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RpjYamwJEThOaGP6hD5l3C", in __p_RpjYamwJEThOaGP6hD5l3C), n1.CompilationHelper.GetValueOrExisting(values, "__p_PTxU9p8Ny96PezFUJ2bd9g", in __p_PTxU9p8Ny96PezFUJ2bd9g), n1.CompilationHelper.GetValueOrExisting(values, "__p_JaAHhHgg3WxME3owgYTjch", in __p_JaAHhHgg3WxME3owgYTjch), n1.CompilationHelper.GetValueOrExisting(values, "__p_JRS1MWNb7nxMl81emtzzGt", in __p_JRS1MWNb7nxMl81emtzzGt), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Ve059I5HTURQJzhfycqX1g", in __pin_group_Input_In_Ve059I5HTURQJzhfycqX1g));
            }

            internal __MeRAiFqTFeMMZ0OUE9cHp4 __WITH__(n3.HSLtoRGB_Bjzdq9vbOfXPbiW6Sklj6R __p_RpjYamwJEThOaGP6hD5l3C, n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ __p_PTxU9p8Ny96PezFUJ2bd9g, n3.OKLabToRGB_Q0j51xXC7SFMagRHt3pHOf __p_JaAHhHgg3WxME3owgYTjch, n3.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<n15.Vector3> __p_JRS1MWNb7nxMl81emtzzGt, n10.Spread<n5.GpuValue<n15.Vector3>> __pin_group_Input_In_Ve059I5HTURQJzhfycqX1g)
            {
                __MeRAiFqTFeMMZ0OUE9cHp4 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RpjYamwJEThOaGP6hD5l3C != this.__p_RpjYamwJEThOaGP6hD5l3C || __p_PTxU9p8Ny96PezFUJ2bd9g != this.__p_PTxU9p8Ny96PezFUJ2bd9g || __p_JaAHhHgg3WxME3owgYTjch != this.__p_JaAHhHgg3WxME3owgYTjch || __p_JRS1MWNb7nxMl81emtzzGt != this.__p_JRS1MWNb7nxMl81emtzzGt || __pin_group_Input_In_Ve059I5HTURQJzhfycqX1g != this.__pin_group_Input_In_Ve059I5HTURQJzhfycqX1g ? new __MeRAiFqTFeMMZ0OUE9cHp4(this)
                    {__p_RpjYamwJEThOaGP6hD5l3C = __p_RpjYamwJEThOaGP6hD5l3C, __p_PTxU9p8Ny96PezFUJ2bd9g = __p_PTxU9p8Ny96PezFUJ2bd9g, __p_JaAHhHgg3WxME3owgYTjch = __p_JaAHhHgg3WxME3owgYTjch, __p_JRS1MWNb7nxMl81emtzzGt = __p_JRS1MWNb7nxMl81emtzzGt, __pin_group_Input_In_Ve059I5HTURQJzhfycqX1g = __pin_group_Input_In_Ve059I5HTURQJzhfycqX1g} : that_0;
                else
                {
                    this.__p_RpjYamwJEThOaGP6hD5l3C = __p_RpjYamwJEThOaGP6hD5l3C;
                    this.__p_PTxU9p8Ny96PezFUJ2bd9g = __p_PTxU9p8Ny96PezFUJ2bd9g;
                    this.__p_JaAHhHgg3WxME3owgYTjch = __p_JaAHhHgg3WxME3owgYTjch;
                    this.__p_JRS1MWNb7nxMl81emtzzGt = __p_JRS1MWNb7nxMl81emtzzGt;
                    this.__pin_group_Input_In_Ve059I5HTURQJzhfycqX1g = __pin_group_Input_In_Ve059I5HTURQJzhfycqX1g;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 333044U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "IHTJzC5suJsPEpgWnc1m5S", Name = "FromRGB_IHTJzC5suJsPEpgWnc1m5S")]
    [n2.SerializableAttribute]
    public class FromRGB_IHTJzC5suJsPEpgWnc1m5S : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.FromRGB_IHTJzC5suJsPEpgWnc1m5S Create(n1.NodeContext Node_Context)
        {
            var instance = new FromRGB_IHTJzC5suJsPEpgWnc1m5S(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.FromRGB_IHTJzC5suJsPEpgWnc1m5S CreateDefault()
        {
            var instance = new FromRGB_IHTJzC5suJsPEpgWnc1m5S(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.FromRGB_IHTJzC5suJsPEpgWnc1m5S Update(n21.ColorSpace ColorSpace_In, n5.GpuValue<n15.Vector3> RGB_In, out n5.GpuValue<n15.Vector3> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_GnnhnuncxB5LPsuBFb10xH;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n21.ColorSpace, n5.GpuValue<n15.Vector3>>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n15.Vector3>)));
            }

            var inputs_3 = (ColorSpace_In, RGB_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__BOG3OGdPbRrPcGCj9vi8kU>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __BOG3OGdPbRrPcGCj9vi8kU(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka = n11._Operations_.CreateDefault<n5.GpuValue<n15.Vector3>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "CbfjyrvpcGjOIUCCXUeEen", 333073U);
                    var Output_8 = n3.RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov.Create(Node_Context: Node_Context_7);
                    state_6.__p_CbfjyrvpcGjOIUCCXUeEen = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "FV0iBwQz98fNI0ff4HvsOn", 333078U);
                    var Output_10 = n3.RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy.Create(Node_Context: Node_Context_9);
                    state_6.__p_FV0iBwQz98fNI0ff4HvsOn = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "QOzcwnMhI69LSSeK0HTAYq", 333084U);
                    var Output_12 = n3.RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs.Create(Node_Context: Node_Context_11);
                    state_6.__p_QOzcwnMhI69LSSeK0HTAYq = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Bz5trMlhBJNNSJqBay5lNl", 333093U);
                    var Output_14 = n3.RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<n15.Vector3>.Create(Node_Context: Node_Context_13);
                    state_6.__p_Bz5trMlhBJNNSJqBay5lNl = Output_14;
                }

                int Index_15 = (int)ColorSpace_In;
                var Output_17 = state_6.__p_CbfjyrvpcGjOIUCCXUeEen.Update(RGB_In: RGB_In, HSL_Out: out n5.GpuValue<n15.Vector3> HSL_16);
                var Output_19 = state_6.__p_FV0iBwQz98fNI0ff4HvsOn.Update(RGB_In: RGB_In, HSV_Out: out n5.GpuValue<n15.Vector3> HSV_18);
                var Output_21 = state_6.__p_QOzcwnMhI69LSSeK0HTAYq.Update(RGB_In: RGB_In, OKLab_Out: out n5.GpuValue<n15.Vector3> OKLab_20);
                var State_Output_24 = state_6.__p_Bz5trMlhBJNNSJqBay5lNl.Update(RGB_In: RGB_In, sRGB_Out: out n5.GpuValue<n15.Vector3> sRGB_22, Output_Out: out int Output_23);
                var builder_25 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka, 5);
                builder_25.Add(RGB_In);
                builder_25.Add(HSL_16);
                builder_25.Add(HSV_18);
                builder_25.Add(OKLab_20);
                builder_25.Add(sRGB_22);
                var __pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka_26 = builder_25.Commit();
                n23._Operations_.Switch<n5.GpuValue<n15.Vector3>, n22.__AdaptiveImplementations__NvxFK0tAsVyMwtaYRjadP2>(Index_In: Index_15, Input_In: __pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka_26, Output_Out: out n5.GpuValue<n15.Vector3> Output_27);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = Output_17 != state_6.__p_CbfjyrvpcGjOIUCCXUeEen || Output_19 != state_6.__p_FV0iBwQz98fNI0ff4HvsOn || Output_21 != state_6.__p_QOzcwnMhI69LSSeK0HTAYq || State_Output_24 != state_6.__p_Bz5trMlhBJNNSJqBay5lNl || __pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka_26 != state_6.__pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka ? new __BOG3OGdPbRrPcGCj9vi8kU(state_6)
                    {__p_CbfjyrvpcGjOIUCCXUeEen = Output_17, __p_FV0iBwQz98fNI0ff4HvsOn = Output_19, __p_QOzcwnMhI69LSSeK0HTAYq = Output_21, __p_Bz5trMlhBJNNSJqBay5lNl = State_Output_24, __pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka = __pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka_26} : state_6;
                else
                {
                    state_6.__p_CbfjyrvpcGjOIUCCXUeEen = Output_17;
                    state_6.__p_FV0iBwQz98fNI0ff4HvsOn = Output_19;
                    state_6.__p_QOzcwnMhI69LSSeK0HTAYq = Output_21;
                    state_6.__p_Bz5trMlhBJNNSJqBay5lNl = State_Output_24;
                    state_6.__pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka = __pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka_26;
                }

                outputs_4 = n2.ValueTuple.Create(Output_27);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_28 = outputs_4.Item1;
            Output_Out = __auto_28;
            n3.FromRGB_IHTJzC5suJsPEpgWnc1m5S that_29 = this;
            if (this.__GetContext__().IsImmutable)
                that_29 = manager_2 != this.__cache_GnnhnuncxB5LPsuBFb10xH ? new FromRGB_IHTJzC5suJsPEpgWnc1m5S(this)
                {__cache_GnnhnuncxB5LPsuBFb10xH = manager_2} : that_29;
            else
            {
                this.__cache_GnnhnuncxB5LPsuBFb10xH = manager_2;
            }

            return that_29;
        }

        public n3.FromRGB_IHTJzC5suJsPEpgWnc1m5S __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.FromRGB_IHTJzC5suJsPEpgWnc1m5S that_0 = this;
            this.__cache_GnnhnuncxB5LPsuBFb10xH = null;
            return that_0;
        }

        public n3.FromRGB_IHTJzC5suJsPEpgWnc1m5S __CreateDefault__()
        {
            n3.FromRGB_IHTJzC5suJsPEpgWnc1m5S that_0 = this;
            this.__cache_GnnhnuncxB5LPsuBFb10xH = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_GnnhnuncxB5LPsuBFb10xH);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 333048U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "GnnhnuncxB5LPsuBFb10xH", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n21.ColorSpace, n5.GpuValue<n15.Vector3>>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_GnnhnuncxB5LPsuBFb10xH = null;
        public FromRGB_IHTJzC5suJsPEpgWnc1m5S(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FromRGB_IHTJzC5suJsPEpgWnc1m5S(FromRGB_IHTJzC5suJsPEpgWnc1m5S other): base(other)
        {
            this.__cache_GnnhnuncxB5LPsuBFb10xH = other.__cache_GnnhnuncxB5LPsuBFb10xH;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_GnnhnuncxB5LPsuBFb10xH", in __cache_GnnhnuncxB5LPsuBFb10xH));
        }

        internal FromRGB_IHTJzC5suJsPEpgWnc1m5S __WITH__(n6.Manager<n2.ValueTuple<n21.ColorSpace, n5.GpuValue<n15.Vector3>>, n2.ValueTuple<n5.GpuValue<n15.Vector3>>> __cache_GnnhnuncxB5LPsuBFb10xH)
        {
            n3.FromRGB_IHTJzC5suJsPEpgWnc1m5S that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_GnnhnuncxB5LPsuBFb10xH != this.__cache_GnnhnuncxB5LPsuBFb10xH ? new FromRGB_IHTJzC5suJsPEpgWnc1m5S(this)
                {__cache_GnnhnuncxB5LPsuBFb10xH = __cache_GnnhnuncxB5LPsuBFb10xH} : that_0;
            else
            {
                this.__cache_GnnhnuncxB5LPsuBFb10xH = __cache_GnnhnuncxB5LPsuBFb10xH;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "BOG3OGdPbRrPcGCj9vi8kU", Name = "__BOG3OGdPbRrPcGCj9vi8kU")]
        [n2.SerializableAttribute]
        public class __BOG3OGdPbRrPcGCj9vi8kU : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_CbfjyrvpcGjOIUCCXUeEen);
                n1.CompilationHelper.SafeDispose(this.__p_FV0iBwQz98fNI0ff4HvsOn);
                n1.CompilationHelper.SafeDispose(this.__p_QOzcwnMhI69LSSeK0HTAYq);
                n1.CompilationHelper.SafeDispose(this.__p_Bz5trMlhBJNNSJqBay5lNl);
                return;
            }

            [n1.ElementAttribute(TracingId = 333073U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "CbfjyrvpcGjOIUCCXUeEen", Name = "RGBtoHSL", IsManaged = true, IsAutoGenerated = true)]
            public n3.RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov __p_CbfjyrvpcGjOIUCCXUeEen;
            [n1.ElementAttribute(TracingId = 333078U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "FV0iBwQz98fNI0ff4HvsOn", Name = "RGBtoHSV", IsManaged = true, IsAutoGenerated = true)]
            public n3.RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy __p_FV0iBwQz98fNI0ff4HvsOn;
            [n1.ElementAttribute(TracingId = 333084U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "QOzcwnMhI69LSSeK0HTAYq", Name = "RGBtoOKLab", IsManaged = true, IsAutoGenerated = true)]
            public n3.RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs __p_QOzcwnMhI69LSSeK0HTAYq;
            [n1.ElementAttribute(TracingId = 333093U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Bz5trMlhBJNNSJqBay5lNl", Name = "RGBToSRGB", IsManaged = true, IsAutoGenerated = true)]
            public n3.RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<n15.Vector3> __p_Bz5trMlhBJNNSJqBay5lNl;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<n15.Vector3>> __pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka = default(n10.Spread<n5.GpuValue<n15.Vector3>>);
            public __BOG3OGdPbRrPcGCj9vi8kU(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BOG3OGdPbRrPcGCj9vi8kU(__BOG3OGdPbRrPcGCj9vi8kU other): base(other)
            {
                this.__p_CbfjyrvpcGjOIUCCXUeEen = other.__p_CbfjyrvpcGjOIUCCXUeEen;
                this.__p_FV0iBwQz98fNI0ff4HvsOn = other.__p_FV0iBwQz98fNI0ff4HvsOn;
                this.__p_QOzcwnMhI69LSSeK0HTAYq = other.__p_QOzcwnMhI69LSSeK0HTAYq;
                this.__p_Bz5trMlhBJNNSJqBay5lNl = other.__p_Bz5trMlhBJNNSJqBay5lNl;
                this.__pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka = other.__pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_CbfjyrvpcGjOIUCCXUeEen", in __p_CbfjyrvpcGjOIUCCXUeEen), n1.CompilationHelper.GetValueOrExisting(values, "__p_FV0iBwQz98fNI0ff4HvsOn", in __p_FV0iBwQz98fNI0ff4HvsOn), n1.CompilationHelper.GetValueOrExisting(values, "__p_QOzcwnMhI69LSSeK0HTAYq", in __p_QOzcwnMhI69LSSeK0HTAYq), n1.CompilationHelper.GetValueOrExisting(values, "__p_Bz5trMlhBJNNSJqBay5lNl", in __p_Bz5trMlhBJNNSJqBay5lNl), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka", in __pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka));
            }

            internal __BOG3OGdPbRrPcGCj9vi8kU __WITH__(n3.RGBtoHSL_PiPwfC0MBgmMoFNeSxQ4ov __p_CbfjyrvpcGjOIUCCXUeEen, n3.RGBtoHSV_AmezpbPYEClL6Kazi5s7Uy __p_FV0iBwQz98fNI0ff4HvsOn, n3.RGBtoOKLab_At5QcfIO72WQR9DUuiEdNs __p_QOzcwnMhI69LSSeK0HTAYq, n3.RGBToSRGB_VFPzvWMXkVfOwcPRtHvdqI<n15.Vector3> __p_Bz5trMlhBJNNSJqBay5lNl, n10.Spread<n5.GpuValue<n15.Vector3>> __pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka)
            {
                __BOG3OGdPbRrPcGCj9vi8kU that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_CbfjyrvpcGjOIUCCXUeEen != this.__p_CbfjyrvpcGjOIUCCXUeEen || __p_FV0iBwQz98fNI0ff4HvsOn != this.__p_FV0iBwQz98fNI0ff4HvsOn || __p_QOzcwnMhI69LSSeK0HTAYq != this.__p_QOzcwnMhI69LSSeK0HTAYq || __p_Bz5trMlhBJNNSJqBay5lNl != this.__p_Bz5trMlhBJNNSJqBay5lNl || __pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka != this.__pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka ? new __BOG3OGdPbRrPcGCj9vi8kU(this)
                    {__p_CbfjyrvpcGjOIUCCXUeEen = __p_CbfjyrvpcGjOIUCCXUeEen, __p_FV0iBwQz98fNI0ff4HvsOn = __p_FV0iBwQz98fNI0ff4HvsOn, __p_QOzcwnMhI69LSSeK0HTAYq = __p_QOzcwnMhI69LSSeK0HTAYq, __p_Bz5trMlhBJNNSJqBay5lNl = __p_Bz5trMlhBJNNSJqBay5lNl, __pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka = __pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka} : that_0;
                else
                {
                    this.__p_CbfjyrvpcGjOIUCCXUeEen = __p_CbfjyrvpcGjOIUCCXUeEen;
                    this.__p_FV0iBwQz98fNI0ff4HvsOn = __p_FV0iBwQz98fNI0ff4HvsOn;
                    this.__p_QOzcwnMhI69LSSeK0HTAYq = __p_QOzcwnMhI69LSSeK0HTAYq;
                    this.__p_Bz5trMlhBJNNSJqBay5lNl = __p_Bz5trMlhBJNNSJqBay5lNl;
                    this.__pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka = __pin_group_Input_In_FYSqbZoLwHSOboWXQoy2Ka;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 333155U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "JFmRjc3PnYkNV4gZGl08Gc", Name = "Normal_JFmRjc3PnYkNV4gZGl08Gc")]
    [n2.SerializableAttribute]
    public class Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2> CreateDefault()
        {
            var instance = new Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            n5.GpuValue<T> Default_0 = default(n5.GpuValue<T>);
            var State_Output_2 = this.__p_TbEslfynxh7P2mqq4iVADI.Update(Input1_In: Base_In, Input2_In: Blend_In, Mix_In: Opacity_In, Default_In: Default_0, Output_Out: out n5.GpuValue<T> Output_1);
            Output_Out = Output_1;
            n3.Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2> that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = State_Output_2 != this.__p_TbEslfynxh7P2mqq4iVADI ? new Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2>(this)
                {__p_TbEslfynxh7P2mqq4iVADI = State_Output_2} : that_3;
            else
            {
                this.__p_TbEslfynxh7P2mqq4iVADI = State_Output_2;
            }

            return that_3;
        }

        public n3.Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "TbEslfynxh7P2mqq4iVADI", 333164U);
            var Output_1 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_0);
            n3.Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2> that_2 = this;
            this.__p_TbEslfynxh7P2mqq4iVADI = Output_1;
            return that_2;
        }

        public n3.Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2> __CreateDefault__()
        {
            n3.Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2> that_0 = this;
            this.__p_TbEslfynxh7P2mqq4iVADI = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_TbEslfynxh7P2mqq4iVADI);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 333164U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "TbEslfynxh7P2mqq4iVADI", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
        public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_TbEslfynxh7P2mqq4iVADI;
        public Normal_JFmRjc3PnYkNV4gZGl08Gc(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Normal_JFmRjc3PnYkNV4gZGl08Gc(Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2> other): base(other)
        {
            this.__p_TbEslfynxh7P2mqq4iVADI = other.__p_TbEslfynxh7P2mqq4iVADI;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TbEslfynxh7P2mqq4iVADI", in __p_TbEslfynxh7P2mqq4iVADI));
        }

        internal Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2> __WITH__(n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_TbEslfynxh7P2mqq4iVADI)
        {
            n3.Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_TbEslfynxh7P2mqq4iVADI != this.__p_TbEslfynxh7P2mqq4iVADI ? new Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T2>(this)
                {__p_TbEslfynxh7P2mqq4iVADI = __p_TbEslfynxh7P2mqq4iVADI} : that_0;
            else
            {
                this.__p_TbEslfynxh7P2mqq4iVADI = __p_TbEslfynxh7P2mqq4iVADI;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 333207U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "JkZWIhU7KgdOEKbMmjKIQ0", Name = "ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0")]
    [n2.SerializableAttribute]
    public class ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2> CreateDefault()
        {
            var instance = new ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_SU1tb0PHTrcNm9czR7r6Ib;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Base_In, Blend_In, Opacity_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__U5dkgbw3HqdNc3jLJyRvsI>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __U5dkgbw3HqdNc3jLJyRvsI(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "VVnslZcAV6ENJ8vpYI5ZD6", 333232U);
                    var Output_8 = n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_VVnslZcAV6ENJ8vpYI5ZD6 = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "HiQRREn1LAOOI8w9Q67LSl", 333241U);
                    var Output_10 = n9.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_HiQRREn1LAOOI8w9Q67LSl = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Gz9qHso4bs4Oj0E83Pmeak", 333249U);
                    var Output_12 = n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T>.Create(Node_Context: Node_Context_11);
                    state_6.__p_Gz9qHso4bs4Oj0E83Pmeak = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "IUtAnEOVvhPMhynX2UOFEn", 333258U);
                    var Output_14 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_13);
                    state_6.__p_IUtAnEOVvhPMhynX2UOFEn = Output_14;
                }

                var State_Output_16 = state_6.__p_VVnslZcAV6ENJ8vpYI5ZD6.Update(Input_In: Blend_In, Output_Out: out n5.GpuValue<T> Output_15);
                var builder_17 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl, 2);
                builder_17.Add(Output_15);
                builder_17.Add(Base_In);
                var __pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl_18 = builder_17.Commit();
                var State_Output_20 = state_6.__p_HiQRREn1LAOOI8w9Q67LSl.Update(Input_In: __pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl_18, Output_Out: out n5.GpuValue<T> Output_19);
                var State_Output_22 = state_6.__p_Gz9qHso4bs4Oj0E83Pmeak.Update(Input_In: Output_19, Output_Out: out n5.GpuValue<T> Output_21);
                n5.GpuValue<T> Default_23 = default(n5.GpuValue<T>);
                var State_Output_25 = state_6.__p_IUtAnEOVvhPMhynX2UOFEn.Update(Input1_In: Base_In, Input2_In: Output_21, Mix_In: Opacity_In, Default_In: Default_23, Output_Out: out n5.GpuValue<T> Output_24);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_16 != state_6.__p_VVnslZcAV6ENJ8vpYI5ZD6 || __pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl_18 != state_6.__pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl || State_Output_20 != state_6.__p_HiQRREn1LAOOI8w9Q67LSl || State_Output_22 != state_6.__p_Gz9qHso4bs4Oj0E83Pmeak || State_Output_25 != state_6.__p_IUtAnEOVvhPMhynX2UOFEn ? new __U5dkgbw3HqdNc3jLJyRvsI(state_6)
                    {__p_VVnslZcAV6ENJ8vpYI5ZD6 = State_Output_16, __pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl = __pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl_18, __p_HiQRREn1LAOOI8w9Q67LSl = State_Output_20, __p_Gz9qHso4bs4Oj0E83Pmeak = State_Output_22, __p_IUtAnEOVvhPMhynX2UOFEn = State_Output_25} : state_6;
                else
                {
                    state_6.__p_VVnslZcAV6ENJ8vpYI5ZD6 = State_Output_16;
                    state_6.__pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl = __pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl_18;
                    state_6.__p_HiQRREn1LAOOI8w9Q67LSl = State_Output_20;
                    state_6.__p_Gz9qHso4bs4Oj0E83Pmeak = State_Output_22;
                    state_6.__p_IUtAnEOVvhPMhynX2UOFEn = State_Output_25;
                }

                outputs_4 = n2.ValueTuple.Create(Output_24);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_26 = outputs_4.Item1;
            Output_Out = __auto_26;
            n3.ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2> that_27 = this;
            if (this.__GetContext__().IsImmutable)
                that_27 = manager_2 != this.__cache_SU1tb0PHTrcNm9czR7r6Ib ? new ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2>(this)
                {__cache_SU1tb0PHTrcNm9czR7r6Ib = manager_2} : that_27;
            else
            {
                this.__cache_SU1tb0PHTrcNm9czR7r6Ib = manager_2;
            }

            return that_27;
        }

        public n3.ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2> that_0 = this;
            this.__cache_SU1tb0PHTrcNm9czR7r6Ib = null;
            return that_0;
        }

        public n3.ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2> __CreateDefault__()
        {
            n3.ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2> that_0 = this;
            this.__cache_SU1tb0PHTrcNm9czR7r6Ib = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_SU1tb0PHTrcNm9czR7r6Ib);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 333212U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "SU1tb0PHTrcNm9czR7r6Ib", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_SU1tb0PHTrcNm9czR7r6Ib = null;
        public ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0(ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2> other): base(other)
        {
            this.__cache_SU1tb0PHTrcNm9czR7r6Ib = other.__cache_SU1tb0PHTrcNm9czR7r6Ib;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_SU1tb0PHTrcNm9czR7r6Ib", in __cache_SU1tb0PHTrcNm9czR7r6Ib));
        }

        internal ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_SU1tb0PHTrcNm9czR7r6Ib)
        {
            n3.ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_SU1tb0PHTrcNm9czR7r6Ib != this.__cache_SU1tb0PHTrcNm9czR7r6Ib ? new ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T2>(this)
                {__cache_SU1tb0PHTrcNm9czR7r6Ib = __cache_SU1tb0PHTrcNm9czR7r6Ib} : that_0;
            else
            {
                this.__cache_SU1tb0PHTrcNm9czR7r6Ib = __cache_SU1tb0PHTrcNm9czR7r6Ib;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "U5dkgbw3HqdNc3jLJyRvsI", Name = "__U5dkgbw3HqdNc3jLJyRvsI")]
        [n2.SerializableAttribute]
        public class __U5dkgbw3HqdNc3jLJyRvsI : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_VVnslZcAV6ENJ8vpYI5ZD6);
                n1.CompilationHelper.SafeDispose(this.__p_HiQRREn1LAOOI8w9Q67LSl);
                n1.CompilationHelper.SafeDispose(this.__p_Gz9qHso4bs4Oj0E83Pmeak);
                n1.CompilationHelper.SafeDispose(this.__p_IUtAnEOVvhPMhynX2UOFEn);
                return;
            }

            [n1.ElementAttribute(TracingId = 333232U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "VVnslZcAV6ENJ8vpYI5ZD6", Name = "OneMinus", IsManaged = true, IsAutoGenerated = true)]
            public n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_VVnslZcAV6ENJ8vpYI5ZD6;
            [n1.ElementAttribute(TracingId = 333241U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "HiQRREn1LAOOI8w9Q67LSl", Name = "/", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<T> __p_HiQRREn1LAOOI8w9Q67LSl;
            [n1.ElementAttribute(TracingId = 333249U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Gz9qHso4bs4Oj0E83Pmeak", Name = "OneMinus", IsManaged = true, IsAutoGenerated = true)]
            public n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_Gz9qHso4bs4Oj0E83Pmeak;
            [n1.ElementAttribute(TracingId = 333258U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "IUtAnEOVvhPMhynX2UOFEn", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
            public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_IUtAnEOVvhPMhynX2UOFEn;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl = default(n10.Spread<n5.GpuValue<T>>);
            public __U5dkgbw3HqdNc3jLJyRvsI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __U5dkgbw3HqdNc3jLJyRvsI(__U5dkgbw3HqdNc3jLJyRvsI other): base(other)
            {
                this.__p_VVnslZcAV6ENJ8vpYI5ZD6 = other.__p_VVnslZcAV6ENJ8vpYI5ZD6;
                this.__p_HiQRREn1LAOOI8w9Q67LSl = other.__p_HiQRREn1LAOOI8w9Q67LSl;
                this.__p_Gz9qHso4bs4Oj0E83Pmeak = other.__p_Gz9qHso4bs4Oj0E83Pmeak;
                this.__p_IUtAnEOVvhPMhynX2UOFEn = other.__p_IUtAnEOVvhPMhynX2UOFEn;
                this.__pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl = other.__pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VVnslZcAV6ENJ8vpYI5ZD6", in __p_VVnslZcAV6ENJ8vpYI5ZD6), n1.CompilationHelper.GetValueOrExisting(values, "__p_HiQRREn1LAOOI8w9Q67LSl", in __p_HiQRREn1LAOOI8w9Q67LSl), n1.CompilationHelper.GetValueOrExisting(values, "__p_Gz9qHso4bs4Oj0E83Pmeak", in __p_Gz9qHso4bs4Oj0E83Pmeak), n1.CompilationHelper.GetValueOrExisting(values, "__p_IUtAnEOVvhPMhynX2UOFEn", in __p_IUtAnEOVvhPMhynX2UOFEn), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl", in __pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl));
            }

            internal __U5dkgbw3HqdNc3jLJyRvsI __WITH__(n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_VVnslZcAV6ENJ8vpYI5ZD6, n9.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<T> __p_HiQRREn1LAOOI8w9Q67LSl, n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_Gz9qHso4bs4Oj0E83Pmeak, n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_IUtAnEOVvhPMhynX2UOFEn, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl)
            {
                __U5dkgbw3HqdNc3jLJyRvsI that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_VVnslZcAV6ENJ8vpYI5ZD6 != this.__p_VVnslZcAV6ENJ8vpYI5ZD6 || __p_HiQRREn1LAOOI8w9Q67LSl != this.__p_HiQRREn1LAOOI8w9Q67LSl || __p_Gz9qHso4bs4Oj0E83Pmeak != this.__p_Gz9qHso4bs4Oj0E83Pmeak || __p_IUtAnEOVvhPMhynX2UOFEn != this.__p_IUtAnEOVvhPMhynX2UOFEn || __pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl != this.__pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl ? new __U5dkgbw3HqdNc3jLJyRvsI(this)
                    {__p_VVnslZcAV6ENJ8vpYI5ZD6 = __p_VVnslZcAV6ENJ8vpYI5ZD6, __p_HiQRREn1LAOOI8w9Q67LSl = __p_HiQRREn1LAOOI8w9Q67LSl, __p_Gz9qHso4bs4Oj0E83Pmeak = __p_Gz9qHso4bs4Oj0E83Pmeak, __p_IUtAnEOVvhPMhynX2UOFEn = __p_IUtAnEOVvhPMhynX2UOFEn, __pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl = __pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl} : that_0;
                else
                {
                    this.__p_VVnslZcAV6ENJ8vpYI5ZD6 = __p_VVnslZcAV6ENJ8vpYI5ZD6;
                    this.__p_HiQRREn1LAOOI8w9Q67LSl = __p_HiQRREn1LAOOI8w9Q67LSl;
                    this.__p_Gz9qHso4bs4Oj0E83Pmeak = __p_Gz9qHso4bs4Oj0E83Pmeak;
                    this.__p_IUtAnEOVvhPMhynX2UOFEn = __p_IUtAnEOVvhPMhynX2UOFEn;
                    this.__pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl = __pin_group_Input_In_HiQRREn1LAOOI8w9Q67LSl;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 333313U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "VfUM9dOuuGOMAPnDTrCo6p", Name = "Darken_VfUM9dOuuGOMAPnDTrCo6p")]
    [n2.SerializableAttribute]
    public class Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2> CreateDefault()
        {
            var instance = new Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_DWXxAiaOM8cLY9AWhx8v8K;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Base_In, Blend_In, Opacity_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__PI3HGR01TSuOfIMs1KFjJO>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __PI3HGR01TSuOfIMs1KFjJO(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "DlZTiuKNZ3cO8XWNv8MXH9", 333334U);
                    var Output_8 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_7);
                    state_6.__p_DlZTiuKNZ3cO8XWNv8MXH9 = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "KgIaofmGRfwOVsyaEgWKLO", 333350U);
                    var Output_10 = n9.Min_MgidAgK0NCQN8U4TDR3A7C<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_KgIaofmGRfwOVsyaEgWKLO = Output_10;
                }

                var builder_11 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO, 2);
                builder_11.Add(Base_In);
                builder_11.Add(Blend_In);
                var __pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO_12 = builder_11.Commit();
                var State_Output_14 = state_6.__p_KgIaofmGRfwOVsyaEgWKLO.Update(Input_In: __pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO_12, Output_Out: out n5.GpuValue<T> Output_13);
                n5.GpuValue<T> Default_15 = default(n5.GpuValue<T>);
                var State_Output_17 = state_6.__p_DlZTiuKNZ3cO8XWNv8MXH9.Update(Input1_In: Base_In, Input2_In: Output_13, Mix_In: Opacity_In, Default_In: Default_15, Output_Out: out n5.GpuValue<T> Output_16);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = __pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO_12 != state_6.__pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO || State_Output_14 != state_6.__p_KgIaofmGRfwOVsyaEgWKLO || State_Output_17 != state_6.__p_DlZTiuKNZ3cO8XWNv8MXH9 ? new __PI3HGR01TSuOfIMs1KFjJO(state_6)
                    {__pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO = __pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO_12, __p_KgIaofmGRfwOVsyaEgWKLO = State_Output_14, __p_DlZTiuKNZ3cO8XWNv8MXH9 = State_Output_17} : state_6;
                else
                {
                    state_6.__pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO = __pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO_12;
                    state_6.__p_KgIaofmGRfwOVsyaEgWKLO = State_Output_14;
                    state_6.__p_DlZTiuKNZ3cO8XWNv8MXH9 = State_Output_17;
                }

                outputs_4 = n2.ValueTuple.Create(Output_16);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_18 = outputs_4.Item1;
            Output_Out = __auto_18;
            n3.Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2> that_19 = this;
            if (this.__GetContext__().IsImmutable)
                that_19 = manager_2 != this.__cache_DWXxAiaOM8cLY9AWhx8v8K ? new Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2>(this)
                {__cache_DWXxAiaOM8cLY9AWhx8v8K = manager_2} : that_19;
            else
            {
                this.__cache_DWXxAiaOM8cLY9AWhx8v8K = manager_2;
            }

            return that_19;
        }

        public n3.Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2> that_0 = this;
            this.__cache_DWXxAiaOM8cLY9AWhx8v8K = null;
            return that_0;
        }

        public n3.Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2> __CreateDefault__()
        {
            n3.Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2> that_0 = this;
            this.__cache_DWXxAiaOM8cLY9AWhx8v8K = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_DWXxAiaOM8cLY9AWhx8v8K);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 333316U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "DWXxAiaOM8cLY9AWhx8v8K", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_DWXxAiaOM8cLY9AWhx8v8K = null;
        public Darken_VfUM9dOuuGOMAPnDTrCo6p(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Darken_VfUM9dOuuGOMAPnDTrCo6p(Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2> other): base(other)
        {
            this.__cache_DWXxAiaOM8cLY9AWhx8v8K = other.__cache_DWXxAiaOM8cLY9AWhx8v8K;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_DWXxAiaOM8cLY9AWhx8v8K", in __cache_DWXxAiaOM8cLY9AWhx8v8K));
        }

        internal Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_DWXxAiaOM8cLY9AWhx8v8K)
        {
            n3.Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_DWXxAiaOM8cLY9AWhx8v8K != this.__cache_DWXxAiaOM8cLY9AWhx8v8K ? new Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T2>(this)
                {__cache_DWXxAiaOM8cLY9AWhx8v8K = __cache_DWXxAiaOM8cLY9AWhx8v8K} : that_0;
            else
            {
                this.__cache_DWXxAiaOM8cLY9AWhx8v8K = __cache_DWXxAiaOM8cLY9AWhx8v8K;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "PI3HGR01TSuOfIMs1KFjJO", Name = "__PI3HGR01TSuOfIMs1KFjJO")]
        [n2.SerializableAttribute]
        public class __PI3HGR01TSuOfIMs1KFjJO : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_DlZTiuKNZ3cO8XWNv8MXH9);
                n1.CompilationHelper.SafeDispose(this.__p_KgIaofmGRfwOVsyaEgWKLO);
                return;
            }

            [n1.ElementAttribute(TracingId = 333334U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "DlZTiuKNZ3cO8XWNv8MXH9", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
            public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_DlZTiuKNZ3cO8XWNv8MXH9;
            [n1.ElementAttribute(TracingId = 333350U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "KgIaofmGRfwOVsyaEgWKLO", Name = "Min", IsManaged = true, IsAutoGenerated = true)]
            public n9.Min_MgidAgK0NCQN8U4TDR3A7C<T> __p_KgIaofmGRfwOVsyaEgWKLO;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO = default(n10.Spread<n5.GpuValue<T>>);
            public __PI3HGR01TSuOfIMs1KFjJO(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __PI3HGR01TSuOfIMs1KFjJO(__PI3HGR01TSuOfIMs1KFjJO other): base(other)
            {
                this.__p_DlZTiuKNZ3cO8XWNv8MXH9 = other.__p_DlZTiuKNZ3cO8XWNv8MXH9;
                this.__p_KgIaofmGRfwOVsyaEgWKLO = other.__p_KgIaofmGRfwOVsyaEgWKLO;
                this.__pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO = other.__pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DlZTiuKNZ3cO8XWNv8MXH9", in __p_DlZTiuKNZ3cO8XWNv8MXH9), n1.CompilationHelper.GetValueOrExisting(values, "__p_KgIaofmGRfwOVsyaEgWKLO", in __p_KgIaofmGRfwOVsyaEgWKLO), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO", in __pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO));
            }

            internal __PI3HGR01TSuOfIMs1KFjJO __WITH__(n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_DlZTiuKNZ3cO8XWNv8MXH9, n9.Min_MgidAgK0NCQN8U4TDR3A7C<T> __p_KgIaofmGRfwOVsyaEgWKLO, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO)
            {
                __PI3HGR01TSuOfIMs1KFjJO that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_DlZTiuKNZ3cO8XWNv8MXH9 != this.__p_DlZTiuKNZ3cO8XWNv8MXH9 || __p_KgIaofmGRfwOVsyaEgWKLO != this.__p_KgIaofmGRfwOVsyaEgWKLO || __pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO != this.__pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO ? new __PI3HGR01TSuOfIMs1KFjJO(this)
                    {__p_DlZTiuKNZ3cO8XWNv8MXH9 = __p_DlZTiuKNZ3cO8XWNv8MXH9, __p_KgIaofmGRfwOVsyaEgWKLO = __p_KgIaofmGRfwOVsyaEgWKLO, __pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO = __pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO} : that_0;
                else
                {
                    this.__p_DlZTiuKNZ3cO8XWNv8MXH9 = __p_DlZTiuKNZ3cO8XWNv8MXH9;
                    this.__p_KgIaofmGRfwOVsyaEgWKLO = __p_KgIaofmGRfwOVsyaEgWKLO;
                    this.__pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO = __pin_group_Input_In_KgIaofmGRfwOVsyaEgWKLO;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 333421U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "QibpMhwxUIrL1QBngAPSn2", Name = "Difference_QibpMhwxUIrL1QBngAPSn2")]
    [n2.SerializableAttribute]
    public class Difference_QibpMhwxUIrL1QBngAPSn2<T, T2> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.Difference_QibpMhwxUIrL1QBngAPSn2<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new Difference_QibpMhwxUIrL1QBngAPSn2<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Difference_QibpMhwxUIrL1QBngAPSn2<T, T2> CreateDefault()
        {
            var instance = new Difference_QibpMhwxUIrL1QBngAPSn2<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Difference_QibpMhwxUIrL1QBngAPSn2<T, T2> Update(n5.GpuValue<T> BaseLayer_In, n5.GpuValue<T> BlendLayer_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_PFj2bmHs0SGMQhnGutOKHG;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (BaseLayer_In, BlendLayer_In, Opacity_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__PiQV8Q6QFO3OVJMLOx2kva>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __PiQV8Q6QFO3OVJMLOx2kva(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "UTb77YHdHioMTCvaSYGNwJ", 333448U);
                    var Output_8 = n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_UTb77YHdHioMTCvaSYGNwJ = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "V5h4tUTt5ozOcD3tTNFMjm", 333460U);
                    var Output_10 = n9.Abs_HYWPOtC1lkrNB5uGryHr5l<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_V5h4tUTt5ozOcD3tTNFMjm = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "UDJlLwzw9vFOjdgQWPNRSD", 333466U);
                    var Output_12 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_11);
                    state_6.__p_UDJlLwzw9vFOjdgQWPNRSD = Output_12;
                }

                var builder_13 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ, 2);
                builder_13.Add(BlendLayer_In);
                builder_13.Add(BaseLayer_In);
                var __pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ_14 = builder_13.Commit();
                var State_Output_16 = state_6.__p_UTb77YHdHioMTCvaSYGNwJ.Update(Input_In: __pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ_14, Output_Out: out n5.GpuValue<T> Output_15);
                var Output_18 = state_6.__p_V5h4tUTt5ozOcD3tTNFMjm.Update(Input_In: Output_15, Out_Out: out n5.GpuValue<T> Out_17);
                n5.GpuValue<T> Default_19 = default(n5.GpuValue<T>);
                var State_Output_21 = state_6.__p_UDJlLwzw9vFOjdgQWPNRSD.Update(Input1_In: BaseLayer_In, Input2_In: Out_17, Mix_In: Opacity_In, Default_In: Default_19, Output_Out: out n5.GpuValue<T> Output_20);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = __pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ_14 != state_6.__pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ || State_Output_16 != state_6.__p_UTb77YHdHioMTCvaSYGNwJ || Output_18 != state_6.__p_V5h4tUTt5ozOcD3tTNFMjm || State_Output_21 != state_6.__p_UDJlLwzw9vFOjdgQWPNRSD ? new __PiQV8Q6QFO3OVJMLOx2kva(state_6)
                    {__pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ = __pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ_14, __p_UTb77YHdHioMTCvaSYGNwJ = State_Output_16, __p_V5h4tUTt5ozOcD3tTNFMjm = Output_18, __p_UDJlLwzw9vFOjdgQWPNRSD = State_Output_21} : state_6;
                else
                {
                    state_6.__pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ = __pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ_14;
                    state_6.__p_UTb77YHdHioMTCvaSYGNwJ = State_Output_16;
                    state_6.__p_V5h4tUTt5ozOcD3tTNFMjm = Output_18;
                    state_6.__p_UDJlLwzw9vFOjdgQWPNRSD = State_Output_21;
                }

                outputs_4 = n2.ValueTuple.Create(Output_20);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_22 = outputs_4.Item1;
            Output_Out = __auto_22;
            n3.Difference_QibpMhwxUIrL1QBngAPSn2<T, T2> that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = manager_2 != this.__cache_PFj2bmHs0SGMQhnGutOKHG ? new Difference_QibpMhwxUIrL1QBngAPSn2<T, T2>(this)
                {__cache_PFj2bmHs0SGMQhnGutOKHG = manager_2} : that_23;
            else
            {
                this.__cache_PFj2bmHs0SGMQhnGutOKHG = manager_2;
            }

            return that_23;
        }

        public n3.Difference_QibpMhwxUIrL1QBngAPSn2<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Difference_QibpMhwxUIrL1QBngAPSn2<T, T2> that_0 = this;
            this.__cache_PFj2bmHs0SGMQhnGutOKHG = null;
            return that_0;
        }

        public n3.Difference_QibpMhwxUIrL1QBngAPSn2<T, T2> __CreateDefault__()
        {
            n3.Difference_QibpMhwxUIrL1QBngAPSn2<T, T2> that_0 = this;
            this.__cache_PFj2bmHs0SGMQhnGutOKHG = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_PFj2bmHs0SGMQhnGutOKHG);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 333428U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "PFj2bmHs0SGMQhnGutOKHG", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_PFj2bmHs0SGMQhnGutOKHG = null;
        public Difference_QibpMhwxUIrL1QBngAPSn2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Difference_QibpMhwxUIrL1QBngAPSn2(Difference_QibpMhwxUIrL1QBngAPSn2<T, T2> other): base(other)
        {
            this.__cache_PFj2bmHs0SGMQhnGutOKHG = other.__cache_PFj2bmHs0SGMQhnGutOKHG;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_PFj2bmHs0SGMQhnGutOKHG", in __cache_PFj2bmHs0SGMQhnGutOKHG));
        }

        internal Difference_QibpMhwxUIrL1QBngAPSn2<T, T2> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_PFj2bmHs0SGMQhnGutOKHG)
        {
            n3.Difference_QibpMhwxUIrL1QBngAPSn2<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_PFj2bmHs0SGMQhnGutOKHG != this.__cache_PFj2bmHs0SGMQhnGutOKHG ? new Difference_QibpMhwxUIrL1QBngAPSn2<T, T2>(this)
                {__cache_PFj2bmHs0SGMQhnGutOKHG = __cache_PFj2bmHs0SGMQhnGutOKHG} : that_0;
            else
            {
                this.__cache_PFj2bmHs0SGMQhnGutOKHG = __cache_PFj2bmHs0SGMQhnGutOKHG;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "PiQV8Q6QFO3OVJMLOx2kva", Name = "__PiQV8Q6QFO3OVJMLOx2kva")]
        [n2.SerializableAttribute]
        public class __PiQV8Q6QFO3OVJMLOx2kva : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UTb77YHdHioMTCvaSYGNwJ);
                n1.CompilationHelper.SafeDispose(this.__p_V5h4tUTt5ozOcD3tTNFMjm);
                n1.CompilationHelper.SafeDispose(this.__p_UDJlLwzw9vFOjdgQWPNRSD);
                return;
            }

            [n1.ElementAttribute(TracingId = 333448U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "UTb77YHdHioMTCvaSYGNwJ", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T> __p_UTb77YHdHioMTCvaSYGNwJ;
            [n1.ElementAttribute(TracingId = 333460U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "V5h4tUTt5ozOcD3tTNFMjm", Name = "Abs", IsManaged = true, IsAutoGenerated = true)]
            public n9.Abs_HYWPOtC1lkrNB5uGryHr5l<T> __p_V5h4tUTt5ozOcD3tTNFMjm;
            [n1.ElementAttribute(TracingId = 333466U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "UDJlLwzw9vFOjdgQWPNRSD", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
            public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_UDJlLwzw9vFOjdgQWPNRSD;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ = default(n10.Spread<n5.GpuValue<T>>);
            public __PiQV8Q6QFO3OVJMLOx2kva(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __PiQV8Q6QFO3OVJMLOx2kva(__PiQV8Q6QFO3OVJMLOx2kva other): base(other)
            {
                this.__p_UTb77YHdHioMTCvaSYGNwJ = other.__p_UTb77YHdHioMTCvaSYGNwJ;
                this.__p_V5h4tUTt5ozOcD3tTNFMjm = other.__p_V5h4tUTt5ozOcD3tTNFMjm;
                this.__p_UDJlLwzw9vFOjdgQWPNRSD = other.__p_UDJlLwzw9vFOjdgQWPNRSD;
                this.__pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ = other.__pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UTb77YHdHioMTCvaSYGNwJ", in __p_UTb77YHdHioMTCvaSYGNwJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_V5h4tUTt5ozOcD3tTNFMjm", in __p_V5h4tUTt5ozOcD3tTNFMjm), n1.CompilationHelper.GetValueOrExisting(values, "__p_UDJlLwzw9vFOjdgQWPNRSD", in __p_UDJlLwzw9vFOjdgQWPNRSD), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ", in __pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ));
            }

            internal __PiQV8Q6QFO3OVJMLOx2kva __WITH__(n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T> __p_UTb77YHdHioMTCvaSYGNwJ, n9.Abs_HYWPOtC1lkrNB5uGryHr5l<T> __p_V5h4tUTt5ozOcD3tTNFMjm, n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_UDJlLwzw9vFOjdgQWPNRSD, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ)
            {
                __PiQV8Q6QFO3OVJMLOx2kva that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_UTb77YHdHioMTCvaSYGNwJ != this.__p_UTb77YHdHioMTCvaSYGNwJ || __p_V5h4tUTt5ozOcD3tTNFMjm != this.__p_V5h4tUTt5ozOcD3tTNFMjm || __p_UDJlLwzw9vFOjdgQWPNRSD != this.__p_UDJlLwzw9vFOjdgQWPNRSD || __pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ != this.__pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ ? new __PiQV8Q6QFO3OVJMLOx2kva(this)
                    {__p_UTb77YHdHioMTCvaSYGNwJ = __p_UTb77YHdHioMTCvaSYGNwJ, __p_V5h4tUTt5ozOcD3tTNFMjm = __p_V5h4tUTt5ozOcD3tTNFMjm, __p_UDJlLwzw9vFOjdgQWPNRSD = __p_UDJlLwzw9vFOjdgQWPNRSD, __pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ = __pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ} : that_0;
                else
                {
                    this.__p_UTb77YHdHioMTCvaSYGNwJ = __p_UTb77YHdHioMTCvaSYGNwJ;
                    this.__p_V5h4tUTt5ozOcD3tTNFMjm = __p_V5h4tUTt5ozOcD3tTNFMjm;
                    this.__p_UDJlLwzw9vFOjdgQWPNRSD = __p_UDJlLwzw9vFOjdgQWPNRSD;
                    this.__pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ = __pin_group_Input_In_UTb77YHdHioMTCvaSYGNwJ;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 333529U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "V2pGtZYuxWBQdZxLEyWpss", Name = "Dodge_V2pGtZYuxWBQdZxLEyWpss")]
    [n2.SerializableAttribute]
    public class Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2> CreateDefault()
        {
            var instance = new Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_BT4IlLT6Z0PNRVKIVWQ7ai;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Base_In, Blend_In, Opacity_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__OsMcxDJO5iqOllLE3ZjISR>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __OsMcxDJO5iqOllLE3ZjISR(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "MAtjxwOKrZ9QDxV4p9HND1", 333557U);
                    var Output_8 = n9.Saturate_HJGjOY7U6BSLBVUcDCTES2<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_MAtjxwOKrZ9QDxV4p9HND1 = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "LrwVmM63y6QMMHcI4OwmKV", 333567U);
                    var Output_10 = n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_LrwVmM63y6QMMHcI4OwmKV = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "FiFyJDHFLxULDxKJBat2bX", 333574U);
                    var Output_12 = n9.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<T>.Create(Node_Context: Node_Context_11);
                    state_6.__p_FiFyJDHFLxULDxKJBat2bX = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "CebyYfClTcaNak8wBN4erh", 333586U);
                    var Output_14 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_13);
                    state_6.__p_CebyYfClTcaNak8wBN4erh = Output_14;
                }

                var State_Output_16 = state_6.__p_LrwVmM63y6QMMHcI4OwmKV.Update(Input_In: Blend_In, Output_Out: out n5.GpuValue<T> Output_15);
                var builder_17 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX, 2);
                builder_17.Add(Base_In);
                builder_17.Add(Output_15);
                var __pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX_18 = builder_17.Commit();
                var State_Output_20 = state_6.__p_FiFyJDHFLxULDxKJBat2bX.Update(Input_In: __pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX_18, Output_Out: out n5.GpuValue<T> Output_19);
                var State_Output_22 = state_6.__p_MAtjxwOKrZ9QDxV4p9HND1.Update(Input_In: Output_19, Output_Out: out n5.GpuValue<T> Output_21);
                n5.GpuValue<T> Default_23 = default(n5.GpuValue<T>);
                var State_Output_25 = state_6.__p_CebyYfClTcaNak8wBN4erh.Update(Input1_In: Base_In, Input2_In: Output_21, Mix_In: Opacity_In, Default_In: Default_23, Output_Out: out n5.GpuValue<T> Output_24);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_16 != state_6.__p_LrwVmM63y6QMMHcI4OwmKV || __pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX_18 != state_6.__pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX || State_Output_20 != state_6.__p_FiFyJDHFLxULDxKJBat2bX || State_Output_22 != state_6.__p_MAtjxwOKrZ9QDxV4p9HND1 || State_Output_25 != state_6.__p_CebyYfClTcaNak8wBN4erh ? new __OsMcxDJO5iqOllLE3ZjISR(state_6)
                    {__p_LrwVmM63y6QMMHcI4OwmKV = State_Output_16, __pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX = __pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX_18, __p_FiFyJDHFLxULDxKJBat2bX = State_Output_20, __p_MAtjxwOKrZ9QDxV4p9HND1 = State_Output_22, __p_CebyYfClTcaNak8wBN4erh = State_Output_25} : state_6;
                else
                {
                    state_6.__p_LrwVmM63y6QMMHcI4OwmKV = State_Output_16;
                    state_6.__pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX = __pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX_18;
                    state_6.__p_FiFyJDHFLxULDxKJBat2bX = State_Output_20;
                    state_6.__p_MAtjxwOKrZ9QDxV4p9HND1 = State_Output_22;
                    state_6.__p_CebyYfClTcaNak8wBN4erh = State_Output_25;
                }

                outputs_4 = n2.ValueTuple.Create(Output_24);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_26 = outputs_4.Item1;
            Output_Out = __auto_26;
            n3.Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2> that_27 = this;
            if (this.__GetContext__().IsImmutable)
                that_27 = manager_2 != this.__cache_BT4IlLT6Z0PNRVKIVWQ7ai ? new Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2>(this)
                {__cache_BT4IlLT6Z0PNRVKIVWQ7ai = manager_2} : that_27;
            else
            {
                this.__cache_BT4IlLT6Z0PNRVKIVWQ7ai = manager_2;
            }

            return that_27;
        }

        public n3.Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2> that_0 = this;
            this.__cache_BT4IlLT6Z0PNRVKIVWQ7ai = null;
            return that_0;
        }

        public n3.Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2> __CreateDefault__()
        {
            n3.Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2> that_0 = this;
            this.__cache_BT4IlLT6Z0PNRVKIVWQ7ai = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_BT4IlLT6Z0PNRVKIVWQ7ai);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 333536U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "BT4IlLT6Z0PNRVKIVWQ7ai", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_BT4IlLT6Z0PNRVKIVWQ7ai = null;
        public Dodge_V2pGtZYuxWBQdZxLEyWpss(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Dodge_V2pGtZYuxWBQdZxLEyWpss(Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2> other): base(other)
        {
            this.__cache_BT4IlLT6Z0PNRVKIVWQ7ai = other.__cache_BT4IlLT6Z0PNRVKIVWQ7ai;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_BT4IlLT6Z0PNRVKIVWQ7ai", in __cache_BT4IlLT6Z0PNRVKIVWQ7ai));
        }

        internal Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_BT4IlLT6Z0PNRVKIVWQ7ai)
        {
            n3.Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_BT4IlLT6Z0PNRVKIVWQ7ai != this.__cache_BT4IlLT6Z0PNRVKIVWQ7ai ? new Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T2>(this)
                {__cache_BT4IlLT6Z0PNRVKIVWQ7ai = __cache_BT4IlLT6Z0PNRVKIVWQ7ai} : that_0;
            else
            {
                this.__cache_BT4IlLT6Z0PNRVKIVWQ7ai = __cache_BT4IlLT6Z0PNRVKIVWQ7ai;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "OsMcxDJO5iqOllLE3ZjISR", Name = "__OsMcxDJO5iqOllLE3ZjISR")]
        [n2.SerializableAttribute]
        public class __OsMcxDJO5iqOllLE3ZjISR : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_MAtjxwOKrZ9QDxV4p9HND1);
                n1.CompilationHelper.SafeDispose(this.__p_LrwVmM63y6QMMHcI4OwmKV);
                n1.CompilationHelper.SafeDispose(this.__p_FiFyJDHFLxULDxKJBat2bX);
                n1.CompilationHelper.SafeDispose(this.__p_CebyYfClTcaNak8wBN4erh);
                return;
            }

            [n1.ElementAttribute(TracingId = 333557U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "MAtjxwOKrZ9QDxV4p9HND1", Name = "Saturate", IsManaged = true, IsAutoGenerated = true)]
            public n9.Saturate_HJGjOY7U6BSLBVUcDCTES2<T> __p_MAtjxwOKrZ9QDxV4p9HND1;
            [n1.ElementAttribute(TracingId = 333567U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "LrwVmM63y6QMMHcI4OwmKV", Name = "OneMinus", IsManaged = true, IsAutoGenerated = true)]
            public n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_LrwVmM63y6QMMHcI4OwmKV;
            [n1.ElementAttribute(TracingId = 333574U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "FiFyJDHFLxULDxKJBat2bX", Name = "/", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<T> __p_FiFyJDHFLxULDxKJBat2bX;
            [n1.ElementAttribute(TracingId = 333586U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "CebyYfClTcaNak8wBN4erh", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
            public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_CebyYfClTcaNak8wBN4erh;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX = default(n10.Spread<n5.GpuValue<T>>);
            public __OsMcxDJO5iqOllLE3ZjISR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __OsMcxDJO5iqOllLE3ZjISR(__OsMcxDJO5iqOllLE3ZjISR other): base(other)
            {
                this.__p_MAtjxwOKrZ9QDxV4p9HND1 = other.__p_MAtjxwOKrZ9QDxV4p9HND1;
                this.__p_LrwVmM63y6QMMHcI4OwmKV = other.__p_LrwVmM63y6QMMHcI4OwmKV;
                this.__p_FiFyJDHFLxULDxKJBat2bX = other.__p_FiFyJDHFLxULDxKJBat2bX;
                this.__p_CebyYfClTcaNak8wBN4erh = other.__p_CebyYfClTcaNak8wBN4erh;
                this.__pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX = other.__pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MAtjxwOKrZ9QDxV4p9HND1", in __p_MAtjxwOKrZ9QDxV4p9HND1), n1.CompilationHelper.GetValueOrExisting(values, "__p_LrwVmM63y6QMMHcI4OwmKV", in __p_LrwVmM63y6QMMHcI4OwmKV), n1.CompilationHelper.GetValueOrExisting(values, "__p_FiFyJDHFLxULDxKJBat2bX", in __p_FiFyJDHFLxULDxKJBat2bX), n1.CompilationHelper.GetValueOrExisting(values, "__p_CebyYfClTcaNak8wBN4erh", in __p_CebyYfClTcaNak8wBN4erh), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX", in __pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX));
            }

            internal __OsMcxDJO5iqOllLE3ZjISR __WITH__(n9.Saturate_HJGjOY7U6BSLBVUcDCTES2<T> __p_MAtjxwOKrZ9QDxV4p9HND1, n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_LrwVmM63y6QMMHcI4OwmKV, n9.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<T> __p_FiFyJDHFLxULDxKJBat2bX, n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_CebyYfClTcaNak8wBN4erh, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX)
            {
                __OsMcxDJO5iqOllLE3ZjISR that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_MAtjxwOKrZ9QDxV4p9HND1 != this.__p_MAtjxwOKrZ9QDxV4p9HND1 || __p_LrwVmM63y6QMMHcI4OwmKV != this.__p_LrwVmM63y6QMMHcI4OwmKV || __p_FiFyJDHFLxULDxKJBat2bX != this.__p_FiFyJDHFLxULDxKJBat2bX || __p_CebyYfClTcaNak8wBN4erh != this.__p_CebyYfClTcaNak8wBN4erh || __pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX != this.__pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX ? new __OsMcxDJO5iqOllLE3ZjISR(this)
                    {__p_MAtjxwOKrZ9QDxV4p9HND1 = __p_MAtjxwOKrZ9QDxV4p9HND1, __p_LrwVmM63y6QMMHcI4OwmKV = __p_LrwVmM63y6QMMHcI4OwmKV, __p_FiFyJDHFLxULDxKJBat2bX = __p_FiFyJDHFLxULDxKJBat2bX, __p_CebyYfClTcaNak8wBN4erh = __p_CebyYfClTcaNak8wBN4erh, __pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX = __pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX} : that_0;
                else
                {
                    this.__p_MAtjxwOKrZ9QDxV4p9HND1 = __p_MAtjxwOKrZ9QDxV4p9HND1;
                    this.__p_LrwVmM63y6QMMHcI4OwmKV = __p_LrwVmM63y6QMMHcI4OwmKV;
                    this.__p_FiFyJDHFLxULDxKJBat2bX = __p_FiFyJDHFLxULDxKJBat2bX;
                    this.__p_CebyYfClTcaNak8wBN4erh = __p_CebyYfClTcaNak8wBN4erh;
                    this.__pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX = __pin_group_Input_In_FiFyJDHFLxULDxKJBat2bX;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 333644U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "BrawYghF0rhOkD2ZpPHh8n", Name = "Divide_BrawYghF0rhOkD2ZpPHh8n")]
    [n2.SerializableAttribute]
    public class Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2> CreateDefault()
        {
            var instance = new Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_MrTV3EupyNAPNj2oXH3rf2;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Base_In, Blend_In, Opacity_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__CobIfTJPwUwOMnmghXENSh>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __CobIfTJPwUwOMnmghXENSh(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "VPyrJaxCMz8MGNP9E8gCTT", 333672U);
                    var Output_8 = n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_VPyrJaxCMz8MGNP9E8gCTT = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "G0YOLWIAP8AMvR8vfEyaFh", 333687U);
                    var Output_10 = n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_G0YOLWIAP8AMvR8vfEyaFh = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "H0e3gjJkZWCL6klNgoAK2B", 333694U);
                    var Output_12 = n9.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<T>.Create(Node_Context: Node_Context_11);
                    state_6.__p_H0e3gjJkZWCL6klNgoAK2B = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Ga31qcsikSqNX2prTbdwsc", 333700U);
                    var Output_14 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_13);
                    state_6.__p_Ga31qcsikSqNX2prTbdwsc = Output_14;
                }

                float __pad_Ub2hqEOVzshLTQNcjEGa0S_15 = __slot_Ub2hqEOVzshLTQNcjEGa0S;
                var State_Output_17 = state_6.__p_VPyrJaxCMz8MGNP9E8gCTT.Update(The_Value_In: __pad_Ub2hqEOVzshLTQNcjEGa0S_15, Output_Out: out n5.ConstantValue<T> Output_16);
                var builder_18 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh, 2);
                builder_18.Add(Blend_In);
                builder_18.Add(Output_16);
                var __pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh_19 = builder_18.Commit();
                var State_Output_21 = state_6.__p_G0YOLWIAP8AMvR8vfEyaFh.Update(Input_In: __pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh_19, Output_Out: out n5.GpuValue<T> Output_20);
                var builder_22 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B, 2);
                builder_22.Add(Base_In);
                builder_22.Add(Output_20);
                var __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B_23 = builder_22.Commit();
                var State_Output_25 = state_6.__p_H0e3gjJkZWCL6klNgoAK2B.Update(Input_In: __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B_23, Output_Out: out n5.GpuValue<T> Output_24);
                n5.GpuValue<T> Default_26 = default(n5.GpuValue<T>);
                var State_Output_28 = state_6.__p_Ga31qcsikSqNX2prTbdwsc.Update(Input1_In: Base_In, Input2_In: Output_24, Mix_In: Opacity_In, Default_In: Default_26, Output_Out: out n5.GpuValue<T> Output_27);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_17 != state_6.__p_VPyrJaxCMz8MGNP9E8gCTT || __pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh_19 != state_6.__pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh || State_Output_21 != state_6.__p_G0YOLWIAP8AMvR8vfEyaFh || __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B_23 != state_6.__pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B || State_Output_25 != state_6.__p_H0e3gjJkZWCL6klNgoAK2B || State_Output_28 != state_6.__p_Ga31qcsikSqNX2prTbdwsc ? new __CobIfTJPwUwOMnmghXENSh(state_6)
                    {__p_VPyrJaxCMz8MGNP9E8gCTT = State_Output_17, __pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh = __pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh_19, __p_G0YOLWIAP8AMvR8vfEyaFh = State_Output_21, __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B = __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B_23, __p_H0e3gjJkZWCL6klNgoAK2B = State_Output_25, __p_Ga31qcsikSqNX2prTbdwsc = State_Output_28} : state_6;
                else
                {
                    state_6.__p_VPyrJaxCMz8MGNP9E8gCTT = State_Output_17;
                    state_6.__pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh = __pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh_19;
                    state_6.__p_G0YOLWIAP8AMvR8vfEyaFh = State_Output_21;
                    state_6.__pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B = __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B_23;
                    state_6.__p_H0e3gjJkZWCL6klNgoAK2B = State_Output_25;
                    state_6.__p_Ga31qcsikSqNX2prTbdwsc = State_Output_28;
                }

                outputs_4 = n2.ValueTuple.Create(Output_27);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_29 = outputs_4.Item1;
            Output_Out = __auto_29;
            n3.Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2> that_30 = this;
            if (this.__GetContext__().IsImmutable)
                that_30 = manager_2 != this.__cache_MrTV3EupyNAPNj2oXH3rf2 ? new Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2>(this)
                {__cache_MrTV3EupyNAPNj2oXH3rf2 = manager_2} : that_30;
            else
            {
                this.__cache_MrTV3EupyNAPNj2oXH3rf2 = manager_2;
            }

            return that_30;
        }

        public n3.Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2> that_0 = this;
            this.__cache_MrTV3EupyNAPNj2oXH3rf2 = null;
            return that_0;
        }

        public n3.Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2> __CreateDefault__()
        {
            n3.Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2> that_0 = this;
            this.__cache_MrTV3EupyNAPNj2oXH3rf2 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_MrTV3EupyNAPNj2oXH3rf2);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 333651U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "MrTV3EupyNAPNj2oXH3rf2", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_MrTV3EupyNAPNj2oXH3rf2 = null;
        [n1.ElementAttribute(TracingId = 333681U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Ub2hqEOVzshLTQNcjEGa0S", Name = "__slot_Ub2hqEOVzshLTQNcjEGa0S")]
        public static float __slot_Ub2hqEOVzshLTQNcjEGa0S = 1E-06F;
        static Divide_BrawYghF0rhOkD2ZpPHh8n()
        {
        }

        public Divide_BrawYghF0rhOkD2ZpPHh8n(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Divide_BrawYghF0rhOkD2ZpPHh8n(Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2> other): base(other)
        {
            this.__cache_MrTV3EupyNAPNj2oXH3rf2 = other.__cache_MrTV3EupyNAPNj2oXH3rf2;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_MrTV3EupyNAPNj2oXH3rf2", in __cache_MrTV3EupyNAPNj2oXH3rf2));
        }

        internal Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_MrTV3EupyNAPNj2oXH3rf2)
        {
            n3.Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_MrTV3EupyNAPNj2oXH3rf2 != this.__cache_MrTV3EupyNAPNj2oXH3rf2 ? new Divide_BrawYghF0rhOkD2ZpPHh8n<T, T2>(this)
                {__cache_MrTV3EupyNAPNj2oXH3rf2 = __cache_MrTV3EupyNAPNj2oXH3rf2} : that_0;
            else
            {
                this.__cache_MrTV3EupyNAPNj2oXH3rf2 = __cache_MrTV3EupyNAPNj2oXH3rf2;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "CobIfTJPwUwOMnmghXENSh", Name = "__CobIfTJPwUwOMnmghXENSh")]
        [n2.SerializableAttribute]
        public class __CobIfTJPwUwOMnmghXENSh : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_VPyrJaxCMz8MGNP9E8gCTT);
                n1.CompilationHelper.SafeDispose(this.__p_G0YOLWIAP8AMvR8vfEyaFh);
                n1.CompilationHelper.SafeDispose(this.__p_H0e3gjJkZWCL6klNgoAK2B);
                n1.CompilationHelper.SafeDispose(this.__p_Ga31qcsikSqNX2prTbdwsc);
                return;
            }

            [n1.ElementAttribute(TracingId = 333672U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "VPyrJaxCMz8MGNP9E8gCTT", Name = "ConstantFromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<T> __p_VPyrJaxCMz8MGNP9E8gCTT;
            [n1.ElementAttribute(TracingId = 333687U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "G0YOLWIAP8AMvR8vfEyaFh", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T> __p_G0YOLWIAP8AMvR8vfEyaFh;
            [n1.ElementAttribute(TracingId = 333694U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "H0e3gjJkZWCL6klNgoAK2B", Name = "/", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<T> __p_H0e3gjJkZWCL6klNgoAK2B;
            [n1.ElementAttribute(TracingId = 333700U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Ga31qcsikSqNX2prTbdwsc", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
            public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_Ga31qcsikSqNX2prTbdwsc;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B = default(n10.Spread<n5.GpuValue<T>>);
            public __CobIfTJPwUwOMnmghXENSh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CobIfTJPwUwOMnmghXENSh(__CobIfTJPwUwOMnmghXENSh other): base(other)
            {
                this.__p_VPyrJaxCMz8MGNP9E8gCTT = other.__p_VPyrJaxCMz8MGNP9E8gCTT;
                this.__p_G0YOLWIAP8AMvR8vfEyaFh = other.__p_G0YOLWIAP8AMvR8vfEyaFh;
                this.__p_H0e3gjJkZWCL6klNgoAK2B = other.__p_H0e3gjJkZWCL6klNgoAK2B;
                this.__p_Ga31qcsikSqNX2prTbdwsc = other.__p_Ga31qcsikSqNX2prTbdwsc;
                this.__pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh = other.__pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh;
                this.__pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B = other.__pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VPyrJaxCMz8MGNP9E8gCTT", in __p_VPyrJaxCMz8MGNP9E8gCTT), n1.CompilationHelper.GetValueOrExisting(values, "__p_G0YOLWIAP8AMvR8vfEyaFh", in __p_G0YOLWIAP8AMvR8vfEyaFh), n1.CompilationHelper.GetValueOrExisting(values, "__p_H0e3gjJkZWCL6klNgoAK2B", in __p_H0e3gjJkZWCL6klNgoAK2B), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ga31qcsikSqNX2prTbdwsc", in __p_Ga31qcsikSqNX2prTbdwsc), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh", in __pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B", in __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B));
            }

            internal __CobIfTJPwUwOMnmghXENSh __WITH__(n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<T> __p_VPyrJaxCMz8MGNP9E8gCTT, n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T> __p_G0YOLWIAP8AMvR8vfEyaFh, n9.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<T> __p_H0e3gjJkZWCL6klNgoAK2B, n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_Ga31qcsikSqNX2prTbdwsc, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B)
            {
                __CobIfTJPwUwOMnmghXENSh that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_VPyrJaxCMz8MGNP9E8gCTT != this.__p_VPyrJaxCMz8MGNP9E8gCTT || __p_G0YOLWIAP8AMvR8vfEyaFh != this.__p_G0YOLWIAP8AMvR8vfEyaFh || __p_H0e3gjJkZWCL6klNgoAK2B != this.__p_H0e3gjJkZWCL6klNgoAK2B || __p_Ga31qcsikSqNX2prTbdwsc != this.__p_Ga31qcsikSqNX2prTbdwsc || __pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh != this.__pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh || __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B != this.__pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B ? new __CobIfTJPwUwOMnmghXENSh(this)
                    {__p_VPyrJaxCMz8MGNP9E8gCTT = __p_VPyrJaxCMz8MGNP9E8gCTT, __p_G0YOLWIAP8AMvR8vfEyaFh = __p_G0YOLWIAP8AMvR8vfEyaFh, __p_H0e3gjJkZWCL6klNgoAK2B = __p_H0e3gjJkZWCL6klNgoAK2B, __p_Ga31qcsikSqNX2prTbdwsc = __p_Ga31qcsikSqNX2prTbdwsc, __pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh = __pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh, __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B = __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B} : that_0;
                else
                {
                    this.__p_VPyrJaxCMz8MGNP9E8gCTT = __p_VPyrJaxCMz8MGNP9E8gCTT;
                    this.__p_G0YOLWIAP8AMvR8vfEyaFh = __p_G0YOLWIAP8AMvR8vfEyaFh;
                    this.__p_H0e3gjJkZWCL6klNgoAK2B = __p_H0e3gjJkZWCL6klNgoAK2B;
                    this.__p_Ga31qcsikSqNX2prTbdwsc = __p_Ga31qcsikSqNX2prTbdwsc;
                    this.__pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh = __pin_group_Input_In_G0YOLWIAP8AMvR8vfEyaFh;
                    this.__pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B = __pin_group_Input_In_H0e3gjJkZWCL6klNgoAK2B;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 333769U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "A3RP6VBmL09MZrtpId6bZk", Name = "Exclusion_A3RP6VBmL09MZrtpId6bZk")]
    [n2.SerializableAttribute]
    public class Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2> CreateDefault()
        {
            var instance = new Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2> Update(n5.GpuValue<T> BaseLayer_In, n5.GpuValue<T> BlendLayer_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_Q1ZUrTpaYPsOwpCwLDiXLy;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (BaseLayer_In, BlendLayer_In, Opacity_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__N5Hx0vKC4VpL7EzWb6txFW>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __N5Hx0vKC4VpL7EzWb6txFW(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1 = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "QDLybSR9UmiL1ahUYvaIDL", 333790U);
                    var Output_8 = n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_QDLybSR9UmiL1ahUYvaIDL = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "HUdhlgtvrzpNU9JkZMGWwC", 333800U);
                    var Output_10 = n9.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_HUdhlgtvrzpNU9JkZMGWwC = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "S6UPZfGcieeOsKi69TeJz1", 333806U);
                    var Output_12 = n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T>.Create(Node_Context: Node_Context_11);
                    state_6.__p_S6UPZfGcieeOsKi69TeJz1 = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "E5rxPlo3vVHPfP10NJjiHN", 333817U);
                    var Output_14 = n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_13);
                    state_6.__p_E5rxPlo3vVHPfP10NJjiHN = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Rpez6zsltaWPVuveknpEow", 333825U);
                    var Output_16 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_15);
                    state_6.__p_Rpez6zsltaWPVuveknpEow = Output_16;
                }

                float __pad_JLnAZBK7wTJL66h7AANkTh_17 = __slot_JLnAZBK7wTJL66h7AANkTh;
                var State_Output_19 = state_6.__p_QDLybSR9UmiL1ahUYvaIDL.Update(The_Value_In: __pad_JLnAZBK7wTJL66h7AANkTh_17, Output_Out: out n5.ConstantValue<T> Output_18);
                var builder_20 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN, 3);
                builder_20.Add(BaseLayer_In);
                builder_20.Add(BlendLayer_In);
                builder_20.Add(Output_18);
                var __pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN_21 = builder_20.Commit();
                var State_Output_23 = state_6.__p_E5rxPlo3vVHPfP10NJjiHN.Update(Input_In: __pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN_21, Output_Out: out n5.GpuValue<T> Output_22);
                var builder_24 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC, 2);
                builder_24.Add(BaseLayer_In);
                builder_24.Add(BlendLayer_In);
                var __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC_25 = builder_24.Commit();
                var State_Output_27 = state_6.__p_HUdhlgtvrzpNU9JkZMGWwC.Update(Input_In: __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC_25, Output_Out: out n5.GpuValue<T> Output_26);
                var builder_28 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1, 2);
                builder_28.Add(Output_26);
                builder_28.Add(Output_22);
                var __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1_29 = builder_28.Commit();
                var State_Output_31 = state_6.__p_S6UPZfGcieeOsKi69TeJz1.Update(Input_In: __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1_29, Output_Out: out n5.GpuValue<T> Output_30);
                n5.GpuValue<T> Default_32 = default(n5.GpuValue<T>);
                var State_Output_34 = state_6.__p_Rpez6zsltaWPVuveknpEow.Update(Input1_In: BaseLayer_In, Input2_In: Output_30, Mix_In: Opacity_In, Default_In: Default_32, Output_Out: out n5.GpuValue<T> Output_33);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_19 != state_6.__p_QDLybSR9UmiL1ahUYvaIDL || __pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN_21 != state_6.__pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN || State_Output_23 != state_6.__p_E5rxPlo3vVHPfP10NJjiHN || __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC_25 != state_6.__pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC || State_Output_27 != state_6.__p_HUdhlgtvrzpNU9JkZMGWwC || __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1_29 != state_6.__pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1 || State_Output_31 != state_6.__p_S6UPZfGcieeOsKi69TeJz1 || State_Output_34 != state_6.__p_Rpez6zsltaWPVuveknpEow ? new __N5Hx0vKC4VpL7EzWb6txFW(state_6)
                    {__p_QDLybSR9UmiL1ahUYvaIDL = State_Output_19, __pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN = __pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN_21, __p_E5rxPlo3vVHPfP10NJjiHN = State_Output_23, __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC = __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC_25, __p_HUdhlgtvrzpNU9JkZMGWwC = State_Output_27, __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1 = __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1_29, __p_S6UPZfGcieeOsKi69TeJz1 = State_Output_31, __p_Rpez6zsltaWPVuveknpEow = State_Output_34} : state_6;
                else
                {
                    state_6.__p_QDLybSR9UmiL1ahUYvaIDL = State_Output_19;
                    state_6.__pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN = __pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN_21;
                    state_6.__p_E5rxPlo3vVHPfP10NJjiHN = State_Output_23;
                    state_6.__pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC = __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC_25;
                    state_6.__p_HUdhlgtvrzpNU9JkZMGWwC = State_Output_27;
                    state_6.__pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1 = __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1_29;
                    state_6.__p_S6UPZfGcieeOsKi69TeJz1 = State_Output_31;
                    state_6.__p_Rpez6zsltaWPVuveknpEow = State_Output_34;
                }

                outputs_4 = n2.ValueTuple.Create(Output_33);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_35 = outputs_4.Item1;
            Output_Out = __auto_35;
            n3.Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2> that_36 = this;
            if (this.__GetContext__().IsImmutable)
                that_36 = manager_2 != this.__cache_Q1ZUrTpaYPsOwpCwLDiXLy ? new Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2>(this)
                {__cache_Q1ZUrTpaYPsOwpCwLDiXLy = manager_2} : that_36;
            else
            {
                this.__cache_Q1ZUrTpaYPsOwpCwLDiXLy = manager_2;
            }

            return that_36;
        }

        public n3.Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2> that_0 = this;
            this.__cache_Q1ZUrTpaYPsOwpCwLDiXLy = null;
            return that_0;
        }

        public n3.Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2> __CreateDefault__()
        {
            n3.Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2> that_0 = this;
            this.__cache_Q1ZUrTpaYPsOwpCwLDiXLy = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_Q1ZUrTpaYPsOwpCwLDiXLy);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 333774U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Q1ZUrTpaYPsOwpCwLDiXLy", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_Q1ZUrTpaYPsOwpCwLDiXLy = null;
        [n1.ElementAttribute(TracingId = 333797U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "JLnAZBK7wTJL66h7AANkTh", Name = "__slot_JLnAZBK7wTJL66h7AANkTh")]
        public static float __slot_JLnAZBK7wTJL66h7AANkTh = 2F;
        static Exclusion_A3RP6VBmL09MZrtpId6bZk()
        {
        }

        public Exclusion_A3RP6VBmL09MZrtpId6bZk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Exclusion_A3RP6VBmL09MZrtpId6bZk(Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2> other): base(other)
        {
            this.__cache_Q1ZUrTpaYPsOwpCwLDiXLy = other.__cache_Q1ZUrTpaYPsOwpCwLDiXLy;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Q1ZUrTpaYPsOwpCwLDiXLy", in __cache_Q1ZUrTpaYPsOwpCwLDiXLy));
        }

        internal Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_Q1ZUrTpaYPsOwpCwLDiXLy)
        {
            n3.Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Q1ZUrTpaYPsOwpCwLDiXLy != this.__cache_Q1ZUrTpaYPsOwpCwLDiXLy ? new Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T2>(this)
                {__cache_Q1ZUrTpaYPsOwpCwLDiXLy = __cache_Q1ZUrTpaYPsOwpCwLDiXLy} : that_0;
            else
            {
                this.__cache_Q1ZUrTpaYPsOwpCwLDiXLy = __cache_Q1ZUrTpaYPsOwpCwLDiXLy;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "N5Hx0vKC4VpL7EzWb6txFW", Name = "__N5Hx0vKC4VpL7EzWb6txFW")]
        [n2.SerializableAttribute]
        public class __N5Hx0vKC4VpL7EzWb6txFW : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_QDLybSR9UmiL1ahUYvaIDL);
                n1.CompilationHelper.SafeDispose(this.__p_HUdhlgtvrzpNU9JkZMGWwC);
                n1.CompilationHelper.SafeDispose(this.__p_S6UPZfGcieeOsKi69TeJz1);
                n1.CompilationHelper.SafeDispose(this.__p_E5rxPlo3vVHPfP10NJjiHN);
                n1.CompilationHelper.SafeDispose(this.__p_Rpez6zsltaWPVuveknpEow);
                return;
            }

            [n1.ElementAttribute(TracingId = 333790U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "QDLybSR9UmiL1ahUYvaIDL", Name = "ConstantFromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<T> __p_QDLybSR9UmiL1ahUYvaIDL;
            [n1.ElementAttribute(TracingId = 333800U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "HUdhlgtvrzpNU9JkZMGWwC", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_HUdhlgtvrzpNU9JkZMGWwC;
            [n1.ElementAttribute(TracingId = 333806U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "S6UPZfGcieeOsKi69TeJz1", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T> __p_S6UPZfGcieeOsKi69TeJz1;
            [n1.ElementAttribute(TracingId = 333817U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "E5rxPlo3vVHPfP10NJjiHN", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_E5rxPlo3vVHPfP10NJjiHN;
            [n1.ElementAttribute(TracingId = 333825U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Rpez6zsltaWPVuveknpEow", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
            public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_Rpez6zsltaWPVuveknpEow;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1 = default(n10.Spread<n5.GpuValue<T>>);
            public __N5Hx0vKC4VpL7EzWb6txFW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __N5Hx0vKC4VpL7EzWb6txFW(__N5Hx0vKC4VpL7EzWb6txFW other): base(other)
            {
                this.__p_QDLybSR9UmiL1ahUYvaIDL = other.__p_QDLybSR9UmiL1ahUYvaIDL;
                this.__p_HUdhlgtvrzpNU9JkZMGWwC = other.__p_HUdhlgtvrzpNU9JkZMGWwC;
                this.__p_S6UPZfGcieeOsKi69TeJz1 = other.__p_S6UPZfGcieeOsKi69TeJz1;
                this.__p_E5rxPlo3vVHPfP10NJjiHN = other.__p_E5rxPlo3vVHPfP10NJjiHN;
                this.__p_Rpez6zsltaWPVuveknpEow = other.__p_Rpez6zsltaWPVuveknpEow;
                this.__pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN = other.__pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN;
                this.__pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC = other.__pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC;
                this.__pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1 = other.__pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QDLybSR9UmiL1ahUYvaIDL", in __p_QDLybSR9UmiL1ahUYvaIDL), n1.CompilationHelper.GetValueOrExisting(values, "__p_HUdhlgtvrzpNU9JkZMGWwC", in __p_HUdhlgtvrzpNU9JkZMGWwC), n1.CompilationHelper.GetValueOrExisting(values, "__p_S6UPZfGcieeOsKi69TeJz1", in __p_S6UPZfGcieeOsKi69TeJz1), n1.CompilationHelper.GetValueOrExisting(values, "__p_E5rxPlo3vVHPfP10NJjiHN", in __p_E5rxPlo3vVHPfP10NJjiHN), n1.CompilationHelper.GetValueOrExisting(values, "__p_Rpez6zsltaWPVuveknpEow", in __p_Rpez6zsltaWPVuveknpEow), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN", in __pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC", in __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1", in __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1));
            }

            internal __N5Hx0vKC4VpL7EzWb6txFW __WITH__(n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<T> __p_QDLybSR9UmiL1ahUYvaIDL, n9.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_HUdhlgtvrzpNU9JkZMGWwC, n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T> __p_S6UPZfGcieeOsKi69TeJz1, n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_E5rxPlo3vVHPfP10NJjiHN, n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_Rpez6zsltaWPVuveknpEow, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1)
            {
                __N5Hx0vKC4VpL7EzWb6txFW that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_QDLybSR9UmiL1ahUYvaIDL != this.__p_QDLybSR9UmiL1ahUYvaIDL || __p_HUdhlgtvrzpNU9JkZMGWwC != this.__p_HUdhlgtvrzpNU9JkZMGWwC || __p_S6UPZfGcieeOsKi69TeJz1 != this.__p_S6UPZfGcieeOsKi69TeJz1 || __p_E5rxPlo3vVHPfP10NJjiHN != this.__p_E5rxPlo3vVHPfP10NJjiHN || __p_Rpez6zsltaWPVuveknpEow != this.__p_Rpez6zsltaWPVuveknpEow || __pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN != this.__pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN || __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC != this.__pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC || __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1 != this.__pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1 ? new __N5Hx0vKC4VpL7EzWb6txFW(this)
                    {__p_QDLybSR9UmiL1ahUYvaIDL = __p_QDLybSR9UmiL1ahUYvaIDL, __p_HUdhlgtvrzpNU9JkZMGWwC = __p_HUdhlgtvrzpNU9JkZMGWwC, __p_S6UPZfGcieeOsKi69TeJz1 = __p_S6UPZfGcieeOsKi69TeJz1, __p_E5rxPlo3vVHPfP10NJjiHN = __p_E5rxPlo3vVHPfP10NJjiHN, __p_Rpez6zsltaWPVuveknpEow = __p_Rpez6zsltaWPVuveknpEow, __pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN = __pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN, __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC = __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC, __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1 = __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1} : that_0;
                else
                {
                    this.__p_QDLybSR9UmiL1ahUYvaIDL = __p_QDLybSR9UmiL1ahUYvaIDL;
                    this.__p_HUdhlgtvrzpNU9JkZMGWwC = __p_HUdhlgtvrzpNU9JkZMGWwC;
                    this.__p_S6UPZfGcieeOsKi69TeJz1 = __p_S6UPZfGcieeOsKi69TeJz1;
                    this.__p_E5rxPlo3vVHPfP10NJjiHN = __p_E5rxPlo3vVHPfP10NJjiHN;
                    this.__p_Rpez6zsltaWPVuveknpEow = __p_Rpez6zsltaWPVuveknpEow;
                    this.__pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN = __pin_group_Input_In_E5rxPlo3vVHPfP10NJjiHN;
                    this.__pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC = __pin_group_Input_In_HUdhlgtvrzpNU9JkZMGWwC;
                    this.__pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1 = __pin_group_Input_In_S6UPZfGcieeOsKi69TeJz1;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 333896U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Qxyqn178X1tLHkEj7WLepe", Name = "HardMix_Qxyqn178X1tLHkEj7WLepe")]
    [n2.SerializableAttribute]
    public class HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2> CreateDefault()
        {
            var instance = new HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2> Update(n5.GpuValue<T> BaseLayer_In, n5.GpuValue<T> BlendLayer_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_TcuXnvBc0k1OQiQJVKpI2z;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (BaseLayer_In, BlendLayer_In, Opacity_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__GTC297ywfy0Poe9VhFa6kT>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __GTC297ywfy0Poe9VhFa6kT(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "TRoYSmxwA1bOEKbhPUF6Oe", 333926U);
                    var Output_8 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_7);
                    state_6.__p_TRoYSmxwA1bOEKbhPUF6Oe = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "KVhVVsxB8pmP5cET6EDGrp", 333937U);
                    var Output_10 = n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_KVhVVsxB8pmP5cET6EDGrp = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "RLbWNGGfZtWNQrx55zp3Ea", 333946U);
                    var Output_12 = n9.Step_U70YaSBYOWtQVRAJnYFyfm<T>.Create(Node_Context: Node_Context_11);
                    state_6.__p_RLbWNGGfZtWNQrx55zp3Ea = Output_12;
                }

                var State_Output_14 = state_6.__p_KVhVVsxB8pmP5cET6EDGrp.Update(Input_In: BaseLayer_In, Output_Out: out n5.GpuValue<T> Output_13);
                n5.GpuValue<T> Default_15 = default(n5.GpuValue<T>);
                var State_Output_17 = state_6.__p_RLbWNGGfZtWNQrx55zp3Ea.Update(Input1_In: Output_13, Input2_In: BlendLayer_In, Default_In: Default_15, Output_Out: out n5.GpuValue<T> Output_16);
                n5.GpuValue<T> Default_18 = default(n5.GpuValue<T>);
                var State_Output_20 = state_6.__p_TRoYSmxwA1bOEKbhPUF6Oe.Update(Input1_In: BaseLayer_In, Input2_In: Output_16, Mix_In: Opacity_In, Default_In: Default_18, Output_Out: out n5.GpuValue<T> Output_19);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_14 != state_6.__p_KVhVVsxB8pmP5cET6EDGrp || State_Output_17 != state_6.__p_RLbWNGGfZtWNQrx55zp3Ea || State_Output_20 != state_6.__p_TRoYSmxwA1bOEKbhPUF6Oe ? new __GTC297ywfy0Poe9VhFa6kT(state_6)
                    {__p_KVhVVsxB8pmP5cET6EDGrp = State_Output_14, __p_RLbWNGGfZtWNQrx55zp3Ea = State_Output_17, __p_TRoYSmxwA1bOEKbhPUF6Oe = State_Output_20} : state_6;
                else
                {
                    state_6.__p_KVhVVsxB8pmP5cET6EDGrp = State_Output_14;
                    state_6.__p_RLbWNGGfZtWNQrx55zp3Ea = State_Output_17;
                    state_6.__p_TRoYSmxwA1bOEKbhPUF6Oe = State_Output_20;
                }

                outputs_4 = n2.ValueTuple.Create(Output_19);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_21 = outputs_4.Item1;
            Output_Out = __auto_21;
            n3.HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2> that_22 = this;
            if (this.__GetContext__().IsImmutable)
                that_22 = manager_2 != this.__cache_TcuXnvBc0k1OQiQJVKpI2z ? new HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2>(this)
                {__cache_TcuXnvBc0k1OQiQJVKpI2z = manager_2} : that_22;
            else
            {
                this.__cache_TcuXnvBc0k1OQiQJVKpI2z = manager_2;
            }

            return that_22;
        }

        public n3.HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2> that_0 = this;
            this.__cache_TcuXnvBc0k1OQiQJVKpI2z = null;
            return that_0;
        }

        public n3.HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2> __CreateDefault__()
        {
            n3.HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2> that_0 = this;
            this.__cache_TcuXnvBc0k1OQiQJVKpI2z = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_TcuXnvBc0k1OQiQJVKpI2z);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 333902U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "TcuXnvBc0k1OQiQJVKpI2z", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_TcuXnvBc0k1OQiQJVKpI2z = null;
        public HardMix_Qxyqn178X1tLHkEj7WLepe(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HardMix_Qxyqn178X1tLHkEj7WLepe(HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2> other): base(other)
        {
            this.__cache_TcuXnvBc0k1OQiQJVKpI2z = other.__cache_TcuXnvBc0k1OQiQJVKpI2z;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_TcuXnvBc0k1OQiQJVKpI2z", in __cache_TcuXnvBc0k1OQiQJVKpI2z));
        }

        internal HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_TcuXnvBc0k1OQiQJVKpI2z)
        {
            n3.HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_TcuXnvBc0k1OQiQJVKpI2z != this.__cache_TcuXnvBc0k1OQiQJVKpI2z ? new HardMix_Qxyqn178X1tLHkEj7WLepe<T, T2>(this)
                {__cache_TcuXnvBc0k1OQiQJVKpI2z = __cache_TcuXnvBc0k1OQiQJVKpI2z} : that_0;
            else
            {
                this.__cache_TcuXnvBc0k1OQiQJVKpI2z = __cache_TcuXnvBc0k1OQiQJVKpI2z;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "GTC297ywfy0Poe9VhFa6kT", Name = "__GTC297ywfy0Poe9VhFa6kT")]
        [n2.SerializableAttribute]
        public class __GTC297ywfy0Poe9VhFa6kT : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_TRoYSmxwA1bOEKbhPUF6Oe);
                n1.CompilationHelper.SafeDispose(this.__p_KVhVVsxB8pmP5cET6EDGrp);
                n1.CompilationHelper.SafeDispose(this.__p_RLbWNGGfZtWNQrx55zp3Ea);
                return;
            }

            [n1.ElementAttribute(TracingId = 333926U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "TRoYSmxwA1bOEKbhPUF6Oe", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
            public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_TRoYSmxwA1bOEKbhPUF6Oe;
            [n1.ElementAttribute(TracingId = 333937U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "KVhVVsxB8pmP5cET6EDGrp", Name = "OneMinus", IsManaged = true, IsAutoGenerated = true)]
            public n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_KVhVVsxB8pmP5cET6EDGrp;
            [n1.ElementAttribute(TracingId = 333946U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "RLbWNGGfZtWNQrx55zp3Ea", Name = "Step", IsManaged = true, IsAutoGenerated = true)]
            public n9.Step_U70YaSBYOWtQVRAJnYFyfm<T> __p_RLbWNGGfZtWNQrx55zp3Ea;
            public __GTC297ywfy0Poe9VhFa6kT(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __GTC297ywfy0Poe9VhFa6kT(__GTC297ywfy0Poe9VhFa6kT other): base(other)
            {
                this.__p_TRoYSmxwA1bOEKbhPUF6Oe = other.__p_TRoYSmxwA1bOEKbhPUF6Oe;
                this.__p_KVhVVsxB8pmP5cET6EDGrp = other.__p_KVhVVsxB8pmP5cET6EDGrp;
                this.__p_RLbWNGGfZtWNQrx55zp3Ea = other.__p_RLbWNGGfZtWNQrx55zp3Ea;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TRoYSmxwA1bOEKbhPUF6Oe", in __p_TRoYSmxwA1bOEKbhPUF6Oe), n1.CompilationHelper.GetValueOrExisting(values, "__p_KVhVVsxB8pmP5cET6EDGrp", in __p_KVhVVsxB8pmP5cET6EDGrp), n1.CompilationHelper.GetValueOrExisting(values, "__p_RLbWNGGfZtWNQrx55zp3Ea", in __p_RLbWNGGfZtWNQrx55zp3Ea));
            }

            internal __GTC297ywfy0Poe9VhFa6kT __WITH__(n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_TRoYSmxwA1bOEKbhPUF6Oe, n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_KVhVVsxB8pmP5cET6EDGrp, n9.Step_U70YaSBYOWtQVRAJnYFyfm<T> __p_RLbWNGGfZtWNQrx55zp3Ea)
            {
                __GTC297ywfy0Poe9VhFa6kT that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_TRoYSmxwA1bOEKbhPUF6Oe != this.__p_TRoYSmxwA1bOEKbhPUF6Oe || __p_KVhVVsxB8pmP5cET6EDGrp != this.__p_KVhVVsxB8pmP5cET6EDGrp || __p_RLbWNGGfZtWNQrx55zp3Ea != this.__p_RLbWNGGfZtWNQrx55zp3Ea ? new __GTC297ywfy0Poe9VhFa6kT(this)
                    {__p_TRoYSmxwA1bOEKbhPUF6Oe = __p_TRoYSmxwA1bOEKbhPUF6Oe, __p_KVhVVsxB8pmP5cET6EDGrp = __p_KVhVVsxB8pmP5cET6EDGrp, __p_RLbWNGGfZtWNQrx55zp3Ea = __p_RLbWNGGfZtWNQrx55zp3Ea} : that_0;
                else
                {
                    this.__p_TRoYSmxwA1bOEKbhPUF6Oe = __p_TRoYSmxwA1bOEKbhPUF6Oe;
                    this.__p_KVhVVsxB8pmP5cET6EDGrp = __p_KVhVVsxB8pmP5cET6EDGrp;
                    this.__p_RLbWNGGfZtWNQrx55zp3Ea = __p_RLbWNGGfZtWNQrx55zp3Ea;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 334002U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "LjYudzEB8VtL7ZAw5Obxbi", Name = "Lighten_LjYudzEB8VtL7ZAw5Obxbi")]
    [n2.SerializableAttribute]
    public class Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2> CreateDefault()
        {
            var instance = new Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_HhbUJvOBJgyP7lQ6FsRuuV;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Base_In, Blend_In, Opacity_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__G9C85WQONINQUB76ibq608>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __G9C85WQONINQUB76ibq608(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Vua2A8z3DZ1N6RcZKFNssy", 334021U);
                    var Output_8 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_7);
                    state_6.__p_Vua2A8z3DZ1N6RcZKFNssy = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "RkwG4Y3i1pqNXc5bC0m3QZ", 334031U);
                    var Output_10 = n9.Max_TB7F8FTy59aOJboryPKSGN<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_RkwG4Y3i1pqNXc5bC0m3QZ = Output_10;
                }

                var builder_11 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ, 2);
                builder_11.Add(Base_In);
                builder_11.Add(Blend_In);
                var __pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ_12 = builder_11.Commit();
                var State_Output_14 = state_6.__p_RkwG4Y3i1pqNXc5bC0m3QZ.Update(Input_In: __pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ_12, Output_Out: out n5.GpuValue<T> Output_13);
                n5.GpuValue<T> Default_15 = default(n5.GpuValue<T>);
                var State_Output_17 = state_6.__p_Vua2A8z3DZ1N6RcZKFNssy.Update(Input1_In: Base_In, Input2_In: Output_13, Mix_In: Opacity_In, Default_In: Default_15, Output_Out: out n5.GpuValue<T> Output_16);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = __pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ_12 != state_6.__pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ || State_Output_14 != state_6.__p_RkwG4Y3i1pqNXc5bC0m3QZ || State_Output_17 != state_6.__p_Vua2A8z3DZ1N6RcZKFNssy ? new __G9C85WQONINQUB76ibq608(state_6)
                    {__pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ = __pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ_12, __p_RkwG4Y3i1pqNXc5bC0m3QZ = State_Output_14, __p_Vua2A8z3DZ1N6RcZKFNssy = State_Output_17} : state_6;
                else
                {
                    state_6.__pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ = __pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ_12;
                    state_6.__p_RkwG4Y3i1pqNXc5bC0m3QZ = State_Output_14;
                    state_6.__p_Vua2A8z3DZ1N6RcZKFNssy = State_Output_17;
                }

                outputs_4 = n2.ValueTuple.Create(Output_16);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_18 = outputs_4.Item1;
            Output_Out = __auto_18;
            n3.Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2> that_19 = this;
            if (this.__GetContext__().IsImmutable)
                that_19 = manager_2 != this.__cache_HhbUJvOBJgyP7lQ6FsRuuV ? new Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2>(this)
                {__cache_HhbUJvOBJgyP7lQ6FsRuuV = manager_2} : that_19;
            else
            {
                this.__cache_HhbUJvOBJgyP7lQ6FsRuuV = manager_2;
            }

            return that_19;
        }

        public n3.Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2> that_0 = this;
            this.__cache_HhbUJvOBJgyP7lQ6FsRuuV = null;
            return that_0;
        }

        public n3.Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2> __CreateDefault__()
        {
            n3.Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2> that_0 = this;
            this.__cache_HhbUJvOBJgyP7lQ6FsRuuV = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_HhbUJvOBJgyP7lQ6FsRuuV);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 334006U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "HhbUJvOBJgyP7lQ6FsRuuV", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_HhbUJvOBJgyP7lQ6FsRuuV = null;
        public Lighten_LjYudzEB8VtL7ZAw5Obxbi(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Lighten_LjYudzEB8VtL7ZAw5Obxbi(Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2> other): base(other)
        {
            this.__cache_HhbUJvOBJgyP7lQ6FsRuuV = other.__cache_HhbUJvOBJgyP7lQ6FsRuuV;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_HhbUJvOBJgyP7lQ6FsRuuV", in __cache_HhbUJvOBJgyP7lQ6FsRuuV));
        }

        internal Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_HhbUJvOBJgyP7lQ6FsRuuV)
        {
            n3.Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_HhbUJvOBJgyP7lQ6FsRuuV != this.__cache_HhbUJvOBJgyP7lQ6FsRuuV ? new Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T2>(this)
                {__cache_HhbUJvOBJgyP7lQ6FsRuuV = __cache_HhbUJvOBJgyP7lQ6FsRuuV} : that_0;
            else
            {
                this.__cache_HhbUJvOBJgyP7lQ6FsRuuV = __cache_HhbUJvOBJgyP7lQ6FsRuuV;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "G9C85WQONINQUB76ibq608", Name = "__G9C85WQONINQUB76ibq608")]
        [n2.SerializableAttribute]
        public class __G9C85WQONINQUB76ibq608 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Vua2A8z3DZ1N6RcZKFNssy);
                n1.CompilationHelper.SafeDispose(this.__p_RkwG4Y3i1pqNXc5bC0m3QZ);
                return;
            }

            [n1.ElementAttribute(TracingId = 334021U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Vua2A8z3DZ1N6RcZKFNssy", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
            public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_Vua2A8z3DZ1N6RcZKFNssy;
            [n1.ElementAttribute(TracingId = 334031U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "RkwG4Y3i1pqNXc5bC0m3QZ", Name = "Max", IsManaged = true, IsAutoGenerated = true)]
            public n9.Max_TB7F8FTy59aOJboryPKSGN<T> __p_RkwG4Y3i1pqNXc5bC0m3QZ;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ = default(n10.Spread<n5.GpuValue<T>>);
            public __G9C85WQONINQUB76ibq608(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __G9C85WQONINQUB76ibq608(__G9C85WQONINQUB76ibq608 other): base(other)
            {
                this.__p_Vua2A8z3DZ1N6RcZKFNssy = other.__p_Vua2A8z3DZ1N6RcZKFNssy;
                this.__p_RkwG4Y3i1pqNXc5bC0m3QZ = other.__p_RkwG4Y3i1pqNXc5bC0m3QZ;
                this.__pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ = other.__pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Vua2A8z3DZ1N6RcZKFNssy", in __p_Vua2A8z3DZ1N6RcZKFNssy), n1.CompilationHelper.GetValueOrExisting(values, "__p_RkwG4Y3i1pqNXc5bC0m3QZ", in __p_RkwG4Y3i1pqNXc5bC0m3QZ), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ", in __pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ));
            }

            internal __G9C85WQONINQUB76ibq608 __WITH__(n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_Vua2A8z3DZ1N6RcZKFNssy, n9.Max_TB7F8FTy59aOJboryPKSGN<T> __p_RkwG4Y3i1pqNXc5bC0m3QZ, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ)
            {
                __G9C85WQONINQUB76ibq608 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Vua2A8z3DZ1N6RcZKFNssy != this.__p_Vua2A8z3DZ1N6RcZKFNssy || __p_RkwG4Y3i1pqNXc5bC0m3QZ != this.__p_RkwG4Y3i1pqNXc5bC0m3QZ || __pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ != this.__pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ ? new __G9C85WQONINQUB76ibq608(this)
                    {__p_Vua2A8z3DZ1N6RcZKFNssy = __p_Vua2A8z3DZ1N6RcZKFNssy, __p_RkwG4Y3i1pqNXc5bC0m3QZ = __p_RkwG4Y3i1pqNXc5bC0m3QZ, __pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ = __pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ} : that_0;
                else
                {
                    this.__p_Vua2A8z3DZ1N6RcZKFNssy = __p_Vua2A8z3DZ1N6RcZKFNssy;
                    this.__p_RkwG4Y3i1pqNXc5bC0m3QZ = __p_RkwG4Y3i1pqNXc5bC0m3QZ;
                    this.__pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ = __pin_group_Input_In_RkwG4Y3i1pqNXc5bC0m3QZ;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 334095U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "KXG0klNgEdCLen8IPncMS3", Name = "LinearBurn_KXG0klNgEdCLen8IPncMS3")]
    [n2.SerializableAttribute]
    public class LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2> CreateDefault()
        {
            var instance = new LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_EAwG3NagDSeOgmcSguIduF;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Base_In, Blend_In, Opacity_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__CUujlkwb2taMAeaNjJg6jZ>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __CUujlkwb2taMAeaNjJg6jZ(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7 = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Fc4AICA3GE2LlA7ZjqL59l", 334117U);
                    var Output_8 = n9.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_Fc4AICA3GE2LlA7ZjqL59l = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Ng11E1J2mUcNAQHAQX04y7", 334124U);
                    var Output_10 = n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_Ng11E1J2mUcNAQHAQX04y7 = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "VChY9rJLlXEMm6qg2lyYmt", 334132U);
                    var Output_12 = n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<T>.Create(Node_Context: Node_Context_11);
                    state_6.__p_VChY9rJLlXEMm6qg2lyYmt = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "HUyAMCqBHPrOdnvNoIRVUX", 334142U);
                    var Output_14 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_13);
                    state_6.__p_HUyAMCqBHPrOdnvNoIRVUX = Output_14;
                }

                float __pad_RFk9CE9knazLj84Sqf6iY2_15 = __slot_RFk9CE9knazLj84Sqf6iY2;
                var builder_16 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l, 2);
                builder_16.Add(Base_In);
                builder_16.Add(Blend_In);
                var __pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l_17 = builder_16.Commit();
                var State_Output_19 = state_6.__p_Fc4AICA3GE2LlA7ZjqL59l.Update(Input_In: __pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l_17, Output_Out: out n5.GpuValue<T> Output_18);
                var State_Output_21 = state_6.__p_VChY9rJLlXEMm6qg2lyYmt.Update(The_Value_In: __pad_RFk9CE9knazLj84Sqf6iY2_15, Output_Out: out n5.ConstantValue<T> Output_20);
                var builder_22 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7, 2);
                builder_22.Add(Output_18);
                builder_22.Add(Output_20);
                var __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7_23 = builder_22.Commit();
                var State_Output_25 = state_6.__p_Ng11E1J2mUcNAQHAQX04y7.Update(Input_In: __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7_23, Output_Out: out n5.GpuValue<T> Output_24);
                n5.GpuValue<T> Default_26 = default(n5.GpuValue<T>);
                var State_Output_28 = state_6.__p_HUyAMCqBHPrOdnvNoIRVUX.Update(Input1_In: Base_In, Input2_In: Output_24, Mix_In: Opacity_In, Default_In: Default_26, Output_Out: out n5.GpuValue<T> Output_27);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = __pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l_17 != state_6.__pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l || State_Output_19 != state_6.__p_Fc4AICA3GE2LlA7ZjqL59l || State_Output_21 != state_6.__p_VChY9rJLlXEMm6qg2lyYmt || __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7_23 != state_6.__pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7 || State_Output_25 != state_6.__p_Ng11E1J2mUcNAQHAQX04y7 || State_Output_28 != state_6.__p_HUyAMCqBHPrOdnvNoIRVUX ? new __CUujlkwb2taMAeaNjJg6jZ(state_6)
                    {__pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l = __pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l_17, __p_Fc4AICA3GE2LlA7ZjqL59l = State_Output_19, __p_VChY9rJLlXEMm6qg2lyYmt = State_Output_21, __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7 = __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7_23, __p_Ng11E1J2mUcNAQHAQX04y7 = State_Output_25, __p_HUyAMCqBHPrOdnvNoIRVUX = State_Output_28} : state_6;
                else
                {
                    state_6.__pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l = __pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l_17;
                    state_6.__p_Fc4AICA3GE2LlA7ZjqL59l = State_Output_19;
                    state_6.__p_VChY9rJLlXEMm6qg2lyYmt = State_Output_21;
                    state_6.__pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7 = __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7_23;
                    state_6.__p_Ng11E1J2mUcNAQHAQX04y7 = State_Output_25;
                    state_6.__p_HUyAMCqBHPrOdnvNoIRVUX = State_Output_28;
                }

                outputs_4 = n2.ValueTuple.Create(Output_27);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_29 = outputs_4.Item1;
            Output_Out = __auto_29;
            n3.LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2> that_30 = this;
            if (this.__GetContext__().IsImmutable)
                that_30 = manager_2 != this.__cache_EAwG3NagDSeOgmcSguIduF ? new LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2>(this)
                {__cache_EAwG3NagDSeOgmcSguIduF = manager_2} : that_30;
            else
            {
                this.__cache_EAwG3NagDSeOgmcSguIduF = manager_2;
            }

            return that_30;
        }

        public n3.LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2> that_0 = this;
            this.__cache_EAwG3NagDSeOgmcSguIduF = null;
            return that_0;
        }

        public n3.LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2> __CreateDefault__()
        {
            n3.LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2> that_0 = this;
            this.__cache_EAwG3NagDSeOgmcSguIduF = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_EAwG3NagDSeOgmcSguIduF);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 334099U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "EAwG3NagDSeOgmcSguIduF", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_EAwG3NagDSeOgmcSguIduF = null;
        [n1.ElementAttribute(TracingId = 334139U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "RFk9CE9knazLj84Sqf6iY2", Name = "__slot_RFk9CE9knazLj84Sqf6iY2")]
        public static float __slot_RFk9CE9knazLj84Sqf6iY2 = 1F;
        static LinearBurn_KXG0klNgEdCLen8IPncMS3()
        {
        }

        public LinearBurn_KXG0klNgEdCLen8IPncMS3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal LinearBurn_KXG0klNgEdCLen8IPncMS3(LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2> other): base(other)
        {
            this.__cache_EAwG3NagDSeOgmcSguIduF = other.__cache_EAwG3NagDSeOgmcSguIduF;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_EAwG3NagDSeOgmcSguIduF", in __cache_EAwG3NagDSeOgmcSguIduF));
        }

        internal LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_EAwG3NagDSeOgmcSguIduF)
        {
            n3.LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_EAwG3NagDSeOgmcSguIduF != this.__cache_EAwG3NagDSeOgmcSguIduF ? new LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T2>(this)
                {__cache_EAwG3NagDSeOgmcSguIduF = __cache_EAwG3NagDSeOgmcSguIduF} : that_0;
            else
            {
                this.__cache_EAwG3NagDSeOgmcSguIduF = __cache_EAwG3NagDSeOgmcSguIduF;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "CUujlkwb2taMAeaNjJg6jZ", Name = "__CUujlkwb2taMAeaNjJg6jZ")]
        [n2.SerializableAttribute]
        public class __CUujlkwb2taMAeaNjJg6jZ : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Fc4AICA3GE2LlA7ZjqL59l);
                n1.CompilationHelper.SafeDispose(this.__p_Ng11E1J2mUcNAQHAQX04y7);
                n1.CompilationHelper.SafeDispose(this.__p_VChY9rJLlXEMm6qg2lyYmt);
                n1.CompilationHelper.SafeDispose(this.__p_HUyAMCqBHPrOdnvNoIRVUX);
                return;
            }

            [n1.ElementAttribute(TracingId = 334117U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Fc4AICA3GE2LlA7ZjqL59l", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_Fc4AICA3GE2LlA7ZjqL59l;
            [n1.ElementAttribute(TracingId = 334124U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Ng11E1J2mUcNAQHAQX04y7", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T> __p_Ng11E1J2mUcNAQHAQX04y7;
            [n1.ElementAttribute(TracingId = 334132U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "VChY9rJLlXEMm6qg2lyYmt", Name = "ConstantFromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<T> __p_VChY9rJLlXEMm6qg2lyYmt;
            [n1.ElementAttribute(TracingId = 334142U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "HUyAMCqBHPrOdnvNoIRVUX", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
            public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_HUyAMCqBHPrOdnvNoIRVUX;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7 = default(n10.Spread<n5.GpuValue<T>>);
            public __CUujlkwb2taMAeaNjJg6jZ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CUujlkwb2taMAeaNjJg6jZ(__CUujlkwb2taMAeaNjJg6jZ other): base(other)
            {
                this.__p_Fc4AICA3GE2LlA7ZjqL59l = other.__p_Fc4AICA3GE2LlA7ZjqL59l;
                this.__p_Ng11E1J2mUcNAQHAQX04y7 = other.__p_Ng11E1J2mUcNAQHAQX04y7;
                this.__p_VChY9rJLlXEMm6qg2lyYmt = other.__p_VChY9rJLlXEMm6qg2lyYmt;
                this.__p_HUyAMCqBHPrOdnvNoIRVUX = other.__p_HUyAMCqBHPrOdnvNoIRVUX;
                this.__pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l = other.__pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l;
                this.__pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7 = other.__pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Fc4AICA3GE2LlA7ZjqL59l", in __p_Fc4AICA3GE2LlA7ZjqL59l), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ng11E1J2mUcNAQHAQX04y7", in __p_Ng11E1J2mUcNAQHAQX04y7), n1.CompilationHelper.GetValueOrExisting(values, "__p_VChY9rJLlXEMm6qg2lyYmt", in __p_VChY9rJLlXEMm6qg2lyYmt), n1.CompilationHelper.GetValueOrExisting(values, "__p_HUyAMCqBHPrOdnvNoIRVUX", in __p_HUyAMCqBHPrOdnvNoIRVUX), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l", in __pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7", in __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7));
            }

            internal __CUujlkwb2taMAeaNjJg6jZ __WITH__(n9.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_Fc4AICA3GE2LlA7ZjqL59l, n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T> __p_Ng11E1J2mUcNAQHAQX04y7, n7.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<T> __p_VChY9rJLlXEMm6qg2lyYmt, n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_HUyAMCqBHPrOdnvNoIRVUX, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7)
            {
                __CUujlkwb2taMAeaNjJg6jZ that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Fc4AICA3GE2LlA7ZjqL59l != this.__p_Fc4AICA3GE2LlA7ZjqL59l || __p_Ng11E1J2mUcNAQHAQX04y7 != this.__p_Ng11E1J2mUcNAQHAQX04y7 || __p_VChY9rJLlXEMm6qg2lyYmt != this.__p_VChY9rJLlXEMm6qg2lyYmt || __p_HUyAMCqBHPrOdnvNoIRVUX != this.__p_HUyAMCqBHPrOdnvNoIRVUX || __pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l != this.__pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l || __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7 != this.__pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7 ? new __CUujlkwb2taMAeaNjJg6jZ(this)
                    {__p_Fc4AICA3GE2LlA7ZjqL59l = __p_Fc4AICA3GE2LlA7ZjqL59l, __p_Ng11E1J2mUcNAQHAQX04y7 = __p_Ng11E1J2mUcNAQHAQX04y7, __p_VChY9rJLlXEMm6qg2lyYmt = __p_VChY9rJLlXEMm6qg2lyYmt, __p_HUyAMCqBHPrOdnvNoIRVUX = __p_HUyAMCqBHPrOdnvNoIRVUX, __pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l = __pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l, __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7 = __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7} : that_0;
                else
                {
                    this.__p_Fc4AICA3GE2LlA7ZjqL59l = __p_Fc4AICA3GE2LlA7ZjqL59l;
                    this.__p_Ng11E1J2mUcNAQHAQX04y7 = __p_Ng11E1J2mUcNAQHAQX04y7;
                    this.__p_VChY9rJLlXEMm6qg2lyYmt = __p_VChY9rJLlXEMm6qg2lyYmt;
                    this.__p_HUyAMCqBHPrOdnvNoIRVUX = __p_HUyAMCqBHPrOdnvNoIRVUX;
                    this.__pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l = __pin_group_Input_In_Fc4AICA3GE2LlA7ZjqL59l;
                    this.__pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7 = __pin_group_Input_In_Ng11E1J2mUcNAQHAQX04y7;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 334207U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "CMt7RBKli4ePbCNnsvD5yN", Name = "LinearDodge_CMt7RBKli4ePbCNnsvD5yN")]
    [n2.SerializableAttribute]
    public class LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2> CreateDefault()
        {
            var instance = new LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_MfLaM3bQzAzOMPhJcPJWRl;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Base_In, Blend_In, Opacity_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__GGkHpf1V9T0NbUFrVkAznx>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __GGkHpf1V9T0NbUFrVkAznx(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "RvHTcuJaxAFMgqAoUpw0ln", 334237U);
                    var Output_8 = n9.Saturate_HJGjOY7U6BSLBVUcDCTES2<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_RvHTcuJaxAFMgqAoUpw0ln = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "FpqOqok4VH9OzV73fJgD2t", 334245U);
                    var Output_10 = n9.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_FpqOqok4VH9OzV73fJgD2t = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "CcATo4jbho0OC2vxor0EQs", 334253U);
                    var Output_12 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_11);
                    state_6.__p_CcATo4jbho0OC2vxor0EQs = Output_12;
                }

                var builder_13 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t, 2);
                builder_13.Add(Base_In);
                builder_13.Add(Blend_In);
                var __pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t_14 = builder_13.Commit();
                var State_Output_16 = state_6.__p_FpqOqok4VH9OzV73fJgD2t.Update(Input_In: __pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t_14, Output_Out: out n5.GpuValue<T> Output_15);
                var State_Output_18 = state_6.__p_RvHTcuJaxAFMgqAoUpw0ln.Update(Input_In: Output_15, Output_Out: out n5.GpuValue<T> Output_17);
                n5.GpuValue<T> Default_19 = default(n5.GpuValue<T>);
                var State_Output_21 = state_6.__p_CcATo4jbho0OC2vxor0EQs.Update(Input1_In: Base_In, Input2_In: Output_17, Mix_In: Opacity_In, Default_In: Default_19, Output_Out: out n5.GpuValue<T> Output_20);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = __pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t_14 != state_6.__pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t || State_Output_16 != state_6.__p_FpqOqok4VH9OzV73fJgD2t || State_Output_18 != state_6.__p_RvHTcuJaxAFMgqAoUpw0ln || State_Output_21 != state_6.__p_CcATo4jbho0OC2vxor0EQs ? new __GGkHpf1V9T0NbUFrVkAznx(state_6)
                    {__pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t = __pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t_14, __p_FpqOqok4VH9OzV73fJgD2t = State_Output_16, __p_RvHTcuJaxAFMgqAoUpw0ln = State_Output_18, __p_CcATo4jbho0OC2vxor0EQs = State_Output_21} : state_6;
                else
                {
                    state_6.__pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t = __pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t_14;
                    state_6.__p_FpqOqok4VH9OzV73fJgD2t = State_Output_16;
                    state_6.__p_RvHTcuJaxAFMgqAoUpw0ln = State_Output_18;
                    state_6.__p_CcATo4jbho0OC2vxor0EQs = State_Output_21;
                }

                outputs_4 = n2.ValueTuple.Create(Output_20);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_22 = outputs_4.Item1;
            Output_Out = __auto_22;
            n3.LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2> that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = manager_2 != this.__cache_MfLaM3bQzAzOMPhJcPJWRl ? new LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2>(this)
                {__cache_MfLaM3bQzAzOMPhJcPJWRl = manager_2} : that_23;
            else
            {
                this.__cache_MfLaM3bQzAzOMPhJcPJWRl = manager_2;
            }

            return that_23;
        }

        public n3.LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2> that_0 = this;
            this.__cache_MfLaM3bQzAzOMPhJcPJWRl = null;
            return that_0;
        }

        public n3.LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2> __CreateDefault__()
        {
            n3.LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2> that_0 = this;
            this.__cache_MfLaM3bQzAzOMPhJcPJWRl = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_MfLaM3bQzAzOMPhJcPJWRl);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 334216U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "MfLaM3bQzAzOMPhJcPJWRl", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_MfLaM3bQzAzOMPhJcPJWRl = null;
        public LinearDodge_CMt7RBKli4ePbCNnsvD5yN(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal LinearDodge_CMt7RBKli4ePbCNnsvD5yN(LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2> other): base(other)
        {
            this.__cache_MfLaM3bQzAzOMPhJcPJWRl = other.__cache_MfLaM3bQzAzOMPhJcPJWRl;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_MfLaM3bQzAzOMPhJcPJWRl", in __cache_MfLaM3bQzAzOMPhJcPJWRl));
        }

        internal LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_MfLaM3bQzAzOMPhJcPJWRl)
        {
            n3.LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_MfLaM3bQzAzOMPhJcPJWRl != this.__cache_MfLaM3bQzAzOMPhJcPJWRl ? new LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T2>(this)
                {__cache_MfLaM3bQzAzOMPhJcPJWRl = __cache_MfLaM3bQzAzOMPhJcPJWRl} : that_0;
            else
            {
                this.__cache_MfLaM3bQzAzOMPhJcPJWRl = __cache_MfLaM3bQzAzOMPhJcPJWRl;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "GGkHpf1V9T0NbUFrVkAznx", Name = "__GGkHpf1V9T0NbUFrVkAznx")]
        [n2.SerializableAttribute]
        public class __GGkHpf1V9T0NbUFrVkAznx : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RvHTcuJaxAFMgqAoUpw0ln);
                n1.CompilationHelper.SafeDispose(this.__p_FpqOqok4VH9OzV73fJgD2t);
                n1.CompilationHelper.SafeDispose(this.__p_CcATo4jbho0OC2vxor0EQs);
                return;
            }

            [n1.ElementAttribute(TracingId = 334237U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "RvHTcuJaxAFMgqAoUpw0ln", Name = "Saturate", IsManaged = true, IsAutoGenerated = true)]
            public n9.Saturate_HJGjOY7U6BSLBVUcDCTES2<T> __p_RvHTcuJaxAFMgqAoUpw0ln;
            [n1.ElementAttribute(TracingId = 334245U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "FpqOqok4VH9OzV73fJgD2t", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_FpqOqok4VH9OzV73fJgD2t;
            [n1.ElementAttribute(TracingId = 334253U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "CcATo4jbho0OC2vxor0EQs", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
            public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_CcATo4jbho0OC2vxor0EQs;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t = default(n10.Spread<n5.GpuValue<T>>);
            public __GGkHpf1V9T0NbUFrVkAznx(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __GGkHpf1V9T0NbUFrVkAznx(__GGkHpf1V9T0NbUFrVkAznx other): base(other)
            {
                this.__p_RvHTcuJaxAFMgqAoUpw0ln = other.__p_RvHTcuJaxAFMgqAoUpw0ln;
                this.__p_FpqOqok4VH9OzV73fJgD2t = other.__p_FpqOqok4VH9OzV73fJgD2t;
                this.__p_CcATo4jbho0OC2vxor0EQs = other.__p_CcATo4jbho0OC2vxor0EQs;
                this.__pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t = other.__pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RvHTcuJaxAFMgqAoUpw0ln", in __p_RvHTcuJaxAFMgqAoUpw0ln), n1.CompilationHelper.GetValueOrExisting(values, "__p_FpqOqok4VH9OzV73fJgD2t", in __p_FpqOqok4VH9OzV73fJgD2t), n1.CompilationHelper.GetValueOrExisting(values, "__p_CcATo4jbho0OC2vxor0EQs", in __p_CcATo4jbho0OC2vxor0EQs), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t", in __pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t));
            }

            internal __GGkHpf1V9T0NbUFrVkAznx __WITH__(n9.Saturate_HJGjOY7U6BSLBVUcDCTES2<T> __p_RvHTcuJaxAFMgqAoUpw0ln, n9.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_FpqOqok4VH9OzV73fJgD2t, n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_CcATo4jbho0OC2vxor0EQs, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t)
            {
                __GGkHpf1V9T0NbUFrVkAznx that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RvHTcuJaxAFMgqAoUpw0ln != this.__p_RvHTcuJaxAFMgqAoUpw0ln || __p_FpqOqok4VH9OzV73fJgD2t != this.__p_FpqOqok4VH9OzV73fJgD2t || __p_CcATo4jbho0OC2vxor0EQs != this.__p_CcATo4jbho0OC2vxor0EQs || __pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t != this.__pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t ? new __GGkHpf1V9T0NbUFrVkAznx(this)
                    {__p_RvHTcuJaxAFMgqAoUpw0ln = __p_RvHTcuJaxAFMgqAoUpw0ln, __p_FpqOqok4VH9OzV73fJgD2t = __p_FpqOqok4VH9OzV73fJgD2t, __p_CcATo4jbho0OC2vxor0EQs = __p_CcATo4jbho0OC2vxor0EQs, __pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t = __pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t} : that_0;
                else
                {
                    this.__p_RvHTcuJaxAFMgqAoUpw0ln = __p_RvHTcuJaxAFMgqAoUpw0ln;
                    this.__p_FpqOqok4VH9OzV73fJgD2t = __p_FpqOqok4VH9OzV73fJgD2t;
                    this.__p_CcATo4jbho0OC2vxor0EQs = __p_CcATo4jbho0OC2vxor0EQs;
                    this.__pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t = __pin_group_Input_In_FpqOqok4VH9OzV73fJgD2t;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 334302U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "RJqVLVdRrboNEDNeH6rzKs", Name = "LinearLight_RJqVLVdRrboNEDNeH6rzKs")]
    [n2.SerializableAttribute]
    public class LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new LinearLight_RJqVLVdRrboNEDNeH6rzKs<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> CreateDefault()
        {
            var instance = new LinearLight_RJqVLVdRrboNEDNeH6rzKs<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> Update(n5.GpuValue<T> BaseLayer_In, n5.GpuValue<T> BlendLayer_In, n5.GpuValue<T> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            string __pad_IK58rO8WMMhODac443kUbI_0 = __slot_IK58rO8WMMhODac443kUbI;
            string __pad_CywlncH2UKTPc9bgN7p1uq_1 = __slot_CywlncH2UKTPc9bgN7p1uq;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_DZw3Jx4QgZfMus8hVs9xPU;
            if (manager_4 is null)
            {
                manager_4 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_5 = (BaseLayer_In, BlendLayer_In, Opacity_In, __pad_IK58rO8WMMhODac443kUbI_0, __pad_CywlncH2UKTPc9bgN7p1uq_1);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__BMNLdGiIpTjOp3mDfBlHVy>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __BMNLdGiIpTjOp3mDfBlHVy(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Kk3kZn1b7KdOfnHqZTeP63", 334333U);
                    var Output_10 = n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T>.Create(Node_Context: Node_Context_9);
                    state_8.__p_Kk3kZn1b7KdOfnHqZTeP63 = Output_10;
                }

                var State_Output_12 = state_8.__p_Kk3kZn1b7KdOfnHqZTeP63.Update(Base_In: BaseLayer_In, Blend_In: BlendLayer_In, Opacity_In: Opacity_In, Name_In: __pad_IK58rO8WMMhODac443kUbI_0, The_Code_Template_In: __pad_CywlncH2UKTPc9bgN7p1uq_1, Output_Out: out n5.GpuValue<T> Output_11);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_12 != state_8.__p_Kk3kZn1b7KdOfnHqZTeP63 ? new __BMNLdGiIpTjOp3mDfBlHVy(state_8)
                    {__p_Kk3kZn1b7KdOfnHqZTeP63 = State_Output_12} : state_8;
                else
                {
                    state_8.__p_Kk3kZn1b7KdOfnHqZTeP63 = State_Output_12;
                }

                outputs_6 = n2.ValueTuple.Create(Output_11);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_13 = outputs_6.Item1;
            Output_Out = __auto_13;
            n3.LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = manager_4 != this.__cache_DZw3Jx4QgZfMus8hVs9xPU ? new LinearLight_RJqVLVdRrboNEDNeH6rzKs<T>(this)
                {__cache_DZw3Jx4QgZfMus8hVs9xPU = manager_4} : that_14;
            else
            {
                this.__cache_DZw3Jx4QgZfMus8hVs9xPU = manager_4;
            }

            return that_14;
        }

        public n3.LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> that_0 = this;
            this.__cache_DZw3Jx4QgZfMus8hVs9xPU = null;
            return that_0;
        }

        public n3.LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> __CreateDefault__()
        {
            n3.LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> that_0 = this;
            this.__cache_DZw3Jx4QgZfMus8hVs9xPU = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_DZw3Jx4QgZfMus8hVs9xPU);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 334352U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "CywlncH2UKTPc9bgN7p1uq", Name = "__slot_CywlncH2UKTPc9bgN7p1uq")]
        public static string __slot_CywlncH2UKTPc9bgN7p1uq = "${resultType} ${signature}(${resultType} Base, ${resultType} Blend, ${resultType} Opacity)\r\n{\r\n    ${resultType} Out = Blend < 0.5 ? max(Base + (2 * Blend) - 1, 0) : min(Base + 2 * (Blend - 0.5), 1);\r\n    return lerp(Base, Out, Opacity);\r\n}";
        [n1.ElementAttribute(TracingId = 334355U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "IK58rO8WMMhODac443kUbI", Name = "__slot_IK58rO8WMMhODac443kUbI")]
        public static string __slot_IK58rO8WMMhODac443kUbI = "LinearLight";
        [n1.ElementAttribute(TracingId = 334306U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "DZw3Jx4QgZfMus8hVs9xPU", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_DZw3Jx4QgZfMus8hVs9xPU = null;
        static LinearLight_RJqVLVdRrboNEDNeH6rzKs()
        {
        }

        public LinearLight_RJqVLVdRrboNEDNeH6rzKs(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal LinearLight_RJqVLVdRrboNEDNeH6rzKs(LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> other): base(other)
        {
            this.__cache_DZw3Jx4QgZfMus8hVs9xPU = other.__cache_DZw3Jx4QgZfMus8hVs9xPU;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_DZw3Jx4QgZfMus8hVs9xPU", in __cache_DZw3Jx4QgZfMus8hVs9xPU));
        }

        internal LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_DZw3Jx4QgZfMus8hVs9xPU)
        {
            n3.LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_DZw3Jx4QgZfMus8hVs9xPU != this.__cache_DZw3Jx4QgZfMus8hVs9xPU ? new LinearLight_RJqVLVdRrboNEDNeH6rzKs<T>(this)
                {__cache_DZw3Jx4QgZfMus8hVs9xPU = __cache_DZw3Jx4QgZfMus8hVs9xPU} : that_0;
            else
            {
                this.__cache_DZw3Jx4QgZfMus8hVs9xPU = __cache_DZw3Jx4QgZfMus8hVs9xPU;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "BMNLdGiIpTjOp3mDfBlHVy", Name = "__BMNLdGiIpTjOp3mDfBlHVy")]
        [n2.SerializableAttribute]
        public class __BMNLdGiIpTjOp3mDfBlHVy : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Kk3kZn1b7KdOfnHqZTeP63);
                return;
            }

            [n1.ElementAttribute(TracingId = 334333U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Kk3kZn1b7KdOfnHqZTeP63", Name = "BlendMode", IsManaged = true, IsAutoGenerated = true)]
            public n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __p_Kk3kZn1b7KdOfnHqZTeP63;
            public __BMNLdGiIpTjOp3mDfBlHVy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BMNLdGiIpTjOp3mDfBlHVy(__BMNLdGiIpTjOp3mDfBlHVy other): base(other)
            {
                this.__p_Kk3kZn1b7KdOfnHqZTeP63 = other.__p_Kk3kZn1b7KdOfnHqZTeP63;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Kk3kZn1b7KdOfnHqZTeP63", in __p_Kk3kZn1b7KdOfnHqZTeP63));
            }

            internal __BMNLdGiIpTjOp3mDfBlHVy __WITH__(n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __p_Kk3kZn1b7KdOfnHqZTeP63)
            {
                __BMNLdGiIpTjOp3mDfBlHVy that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Kk3kZn1b7KdOfnHqZTeP63 != this.__p_Kk3kZn1b7KdOfnHqZTeP63 ? new __BMNLdGiIpTjOp3mDfBlHVy(this)
                    {__p_Kk3kZn1b7KdOfnHqZTeP63 = __p_Kk3kZn1b7KdOfnHqZTeP63} : that_0;
                else
                {
                    this.__p_Kk3kZn1b7KdOfnHqZTeP63 = __p_Kk3kZn1b7KdOfnHqZTeP63;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 334413U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "SUVMbEi1o9tM6P0EEqsAPd", Name = "Multipy_SUVMbEi1o9tM6P0EEqsAPd")]
    [n2.SerializableAttribute]
    public class Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2> CreateDefault()
        {
            var instance = new Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_JXzbPkbeIK7LAcXIADAmKK;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Base_In, Blend_In, Opacity_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__M3Yz2a6TSAxLiOCQipWVff>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __M3Yz2a6TSAxLiOCQipWVff(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "JRpSwllcA7wNvCqZuu7RnY", 334435U);
                    var Output_8 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_7);
                    state_6.__p_JRpSwllcA7wNvCqZuu7RnY = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "FT6jpJvb2weMLeSFAroT8F", 334444U);
                    var Output_10 = n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_FT6jpJvb2weMLeSFAroT8F = Output_10;
                }

                var builder_11 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F, 2);
                builder_11.Add(Base_In);
                builder_11.Add(Blend_In);
                var __pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F_12 = builder_11.Commit();
                var State_Output_14 = state_6.__p_FT6jpJvb2weMLeSFAroT8F.Update(Input_In: __pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F_12, Output_Out: out n5.GpuValue<T> Output_13);
                n5.GpuValue<T> Default_15 = default(n5.GpuValue<T>);
                var State_Output_17 = state_6.__p_JRpSwllcA7wNvCqZuu7RnY.Update(Input1_In: Base_In, Input2_In: Output_13, Mix_In: Opacity_In, Default_In: Default_15, Output_Out: out n5.GpuValue<T> Output_16);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = __pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F_12 != state_6.__pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F || State_Output_14 != state_6.__p_FT6jpJvb2weMLeSFAroT8F || State_Output_17 != state_6.__p_JRpSwllcA7wNvCqZuu7RnY ? new __M3Yz2a6TSAxLiOCQipWVff(state_6)
                    {__pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F = __pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F_12, __p_FT6jpJvb2weMLeSFAroT8F = State_Output_14, __p_JRpSwllcA7wNvCqZuu7RnY = State_Output_17} : state_6;
                else
                {
                    state_6.__pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F = __pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F_12;
                    state_6.__p_FT6jpJvb2weMLeSFAroT8F = State_Output_14;
                    state_6.__p_JRpSwllcA7wNvCqZuu7RnY = State_Output_17;
                }

                outputs_4 = n2.ValueTuple.Create(Output_16);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_18 = outputs_4.Item1;
            Output_Out = __auto_18;
            n3.Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2> that_19 = this;
            if (this.__GetContext__().IsImmutable)
                that_19 = manager_2 != this.__cache_JXzbPkbeIK7LAcXIADAmKK ? new Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2>(this)
                {__cache_JXzbPkbeIK7LAcXIADAmKK = manager_2} : that_19;
            else
            {
                this.__cache_JXzbPkbeIK7LAcXIADAmKK = manager_2;
            }

            return that_19;
        }

        public n3.Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2> that_0 = this;
            this.__cache_JXzbPkbeIK7LAcXIADAmKK = null;
            return that_0;
        }

        public n3.Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2> __CreateDefault__()
        {
            n3.Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2> that_0 = this;
            this.__cache_JXzbPkbeIK7LAcXIADAmKK = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_JXzbPkbeIK7LAcXIADAmKK);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 334418U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "JXzbPkbeIK7LAcXIADAmKK", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_JXzbPkbeIK7LAcXIADAmKK = null;
        public Multipy_SUVMbEi1o9tM6P0EEqsAPd(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Multipy_SUVMbEi1o9tM6P0EEqsAPd(Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2> other): base(other)
        {
            this.__cache_JXzbPkbeIK7LAcXIADAmKK = other.__cache_JXzbPkbeIK7LAcXIADAmKK;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_JXzbPkbeIK7LAcXIADAmKK", in __cache_JXzbPkbeIK7LAcXIADAmKK));
        }

        internal Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_JXzbPkbeIK7LAcXIADAmKK)
        {
            n3.Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_JXzbPkbeIK7LAcXIADAmKK != this.__cache_JXzbPkbeIK7LAcXIADAmKK ? new Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T2>(this)
                {__cache_JXzbPkbeIK7LAcXIADAmKK = __cache_JXzbPkbeIK7LAcXIADAmKK} : that_0;
            else
            {
                this.__cache_JXzbPkbeIK7LAcXIADAmKK = __cache_JXzbPkbeIK7LAcXIADAmKK;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "M3Yz2a6TSAxLiOCQipWVff", Name = "__M3Yz2a6TSAxLiOCQipWVff")]
        [n2.SerializableAttribute]
        public class __M3Yz2a6TSAxLiOCQipWVff : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_JRpSwllcA7wNvCqZuu7RnY);
                n1.CompilationHelper.SafeDispose(this.__p_FT6jpJvb2weMLeSFAroT8F);
                return;
            }

            [n1.ElementAttribute(TracingId = 334435U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "JRpSwllcA7wNvCqZuu7RnY", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
            public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_JRpSwllcA7wNvCqZuu7RnY;
            [n1.ElementAttribute(TracingId = 334444U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "FT6jpJvb2weMLeSFAroT8F", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_FT6jpJvb2weMLeSFAroT8F;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F = default(n10.Spread<n5.GpuValue<T>>);
            public __M3Yz2a6TSAxLiOCQipWVff(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __M3Yz2a6TSAxLiOCQipWVff(__M3Yz2a6TSAxLiOCQipWVff other): base(other)
            {
                this.__p_JRpSwllcA7wNvCqZuu7RnY = other.__p_JRpSwllcA7wNvCqZuu7RnY;
                this.__p_FT6jpJvb2weMLeSFAroT8F = other.__p_FT6jpJvb2weMLeSFAroT8F;
                this.__pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F = other.__pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JRpSwllcA7wNvCqZuu7RnY", in __p_JRpSwllcA7wNvCqZuu7RnY), n1.CompilationHelper.GetValueOrExisting(values, "__p_FT6jpJvb2weMLeSFAroT8F", in __p_FT6jpJvb2weMLeSFAroT8F), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F", in __pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F));
            }

            internal __M3Yz2a6TSAxLiOCQipWVff __WITH__(n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_JRpSwllcA7wNvCqZuu7RnY, n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_FT6jpJvb2weMLeSFAroT8F, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F)
            {
                __M3Yz2a6TSAxLiOCQipWVff that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_JRpSwllcA7wNvCqZuu7RnY != this.__p_JRpSwllcA7wNvCqZuu7RnY || __p_FT6jpJvb2weMLeSFAroT8F != this.__p_FT6jpJvb2weMLeSFAroT8F || __pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F != this.__pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F ? new __M3Yz2a6TSAxLiOCQipWVff(this)
                    {__p_JRpSwllcA7wNvCqZuu7RnY = __p_JRpSwllcA7wNvCqZuu7RnY, __p_FT6jpJvb2weMLeSFAroT8F = __p_FT6jpJvb2weMLeSFAroT8F, __pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F = __pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F} : that_0;
                else
                {
                    this.__p_JRpSwllcA7wNvCqZuu7RnY = __p_JRpSwllcA7wNvCqZuu7RnY;
                    this.__p_FT6jpJvb2weMLeSFAroT8F = __p_FT6jpJvb2weMLeSFAroT8F;
                    this.__pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F = __pin_group_Input_In_FT6jpJvb2weMLeSFAroT8F;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 334497U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Ji70D8smvDJLntIvDG10LK", Name = "Overlay_Ji70D8smvDJLntIvDG10LK")]
    [n2.SerializableAttribute]
    public class Overlay_Ji70D8smvDJLntIvDG10LK<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Overlay_Ji70D8smvDJLntIvDG10LK<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Overlay_Ji70D8smvDJLntIvDG10LK<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Overlay_Ji70D8smvDJLntIvDG10LK<T> CreateDefault()
        {
            var instance = new Overlay_Ji70D8smvDJLntIvDG10LK<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Overlay_Ji70D8smvDJLntIvDG10LK<T> Update(n5.GpuValue<T> BaseLayer_In, n5.GpuValue<T> BlendLayer_In, n5.GpuValue<T> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            string __pad_APyKxsfwXsMLQSGV5lHlzB_0 = __slot_APyKxsfwXsMLQSGV5lHlzB;
            string __pad_MyzwQAJeDnoO7sMjIa5bQc_1 = __slot_MyzwQAJeDnoO7sMjIa5bQc;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_Ot4DKfuox40QVMyWvTJey7;
            if (manager_4 is null)
            {
                manager_4 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_5 = (BaseLayer_In, BlendLayer_In, Opacity_In, __pad_APyKxsfwXsMLQSGV5lHlzB_0, __pad_MyzwQAJeDnoO7sMjIa5bQc_1);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__CxIusnnpZ8aLfSQMTMVJ24>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __CxIusnnpZ8aLfSQMTMVJ24(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "TrM3XZwKJ7FM7CXfu68utT", 334530U);
                    var Output_10 = n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T>.Create(Node_Context: Node_Context_9);
                    state_8.__p_TrM3XZwKJ7FM7CXfu68utT = Output_10;
                }

                var State_Output_12 = state_8.__p_TrM3XZwKJ7FM7CXfu68utT.Update(Base_In: BaseLayer_In, Blend_In: BlendLayer_In, Opacity_In: Opacity_In, Name_In: __pad_APyKxsfwXsMLQSGV5lHlzB_0, The_Code_Template_In: __pad_MyzwQAJeDnoO7sMjIa5bQc_1, Output_Out: out n5.GpuValue<T> Output_11);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_12 != state_8.__p_TrM3XZwKJ7FM7CXfu68utT ? new __CxIusnnpZ8aLfSQMTMVJ24(state_8)
                    {__p_TrM3XZwKJ7FM7CXfu68utT = State_Output_12} : state_8;
                else
                {
                    state_8.__p_TrM3XZwKJ7FM7CXfu68utT = State_Output_12;
                }

                outputs_6 = n2.ValueTuple.Create(Output_11);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_13 = outputs_6.Item1;
            Output_Out = __auto_13;
            n3.Overlay_Ji70D8smvDJLntIvDG10LK<T> that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = manager_4 != this.__cache_Ot4DKfuox40QVMyWvTJey7 ? new Overlay_Ji70D8smvDJLntIvDG10LK<T>(this)
                {__cache_Ot4DKfuox40QVMyWvTJey7 = manager_4} : that_14;
            else
            {
                this.__cache_Ot4DKfuox40QVMyWvTJey7 = manager_4;
            }

            return that_14;
        }

        public n3.Overlay_Ji70D8smvDJLntIvDG10LK<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Overlay_Ji70D8smvDJLntIvDG10LK<T> that_0 = this;
            this.__cache_Ot4DKfuox40QVMyWvTJey7 = null;
            return that_0;
        }

        public n3.Overlay_Ji70D8smvDJLntIvDG10LK<T> __CreateDefault__()
        {
            n3.Overlay_Ji70D8smvDJLntIvDG10LK<T> that_0 = this;
            this.__cache_Ot4DKfuox40QVMyWvTJey7 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_Ot4DKfuox40QVMyWvTJey7);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 334543U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "MyzwQAJeDnoO7sMjIa5bQc", Name = "__slot_MyzwQAJeDnoO7sMjIa5bQc")]
        public static string __slot_MyzwQAJeDnoO7sMjIa5bQc = "${resultType} ${signature}(${resultType} Base, ${resultType} Blend, ${resultType} Opacity)\r\n{\r\n    ${resultType} result1 = 1.0 - 2.0 * (1.0 - Base) * (1.0 - Blend);\r\n    ${resultType} result2 = 2.0 * Base * Blend;\r\n    ${resultType} zeroOrOne = step(Base, 0.5);\r\n    ${resultType} Out = result2 * zeroOrOne + (1 - zeroOrOne) * result1;\r\n    return lerp(Base, Out, Opacity);\r\n}";
        [n1.ElementAttribute(TracingId = 334547U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "APyKxsfwXsMLQSGV5lHlzB", Name = "__slot_APyKxsfwXsMLQSGV5lHlzB")]
        public static string __slot_APyKxsfwXsMLQSGV5lHlzB = "Overlay";
        [n1.ElementAttribute(TracingId = 334503U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Ot4DKfuox40QVMyWvTJey7", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_Ot4DKfuox40QVMyWvTJey7 = null;
        static Overlay_Ji70D8smvDJLntIvDG10LK()
        {
        }

        public Overlay_Ji70D8smvDJLntIvDG10LK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Overlay_Ji70D8smvDJLntIvDG10LK(Overlay_Ji70D8smvDJLntIvDG10LK<T> other): base(other)
        {
            this.__cache_Ot4DKfuox40QVMyWvTJey7 = other.__cache_Ot4DKfuox40QVMyWvTJey7;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Ot4DKfuox40QVMyWvTJey7", in __cache_Ot4DKfuox40QVMyWvTJey7));
        }

        internal Overlay_Ji70D8smvDJLntIvDG10LK<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_Ot4DKfuox40QVMyWvTJey7)
        {
            n3.Overlay_Ji70D8smvDJLntIvDG10LK<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Ot4DKfuox40QVMyWvTJey7 != this.__cache_Ot4DKfuox40QVMyWvTJey7 ? new Overlay_Ji70D8smvDJLntIvDG10LK<T>(this)
                {__cache_Ot4DKfuox40QVMyWvTJey7 = __cache_Ot4DKfuox40QVMyWvTJey7} : that_0;
            else
            {
                this.__cache_Ot4DKfuox40QVMyWvTJey7 = __cache_Ot4DKfuox40QVMyWvTJey7;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "CxIusnnpZ8aLfSQMTMVJ24", Name = "__CxIusnnpZ8aLfSQMTMVJ24")]
        [n2.SerializableAttribute]
        public class __CxIusnnpZ8aLfSQMTMVJ24 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_TrM3XZwKJ7FM7CXfu68utT);
                return;
            }

            [n1.ElementAttribute(TracingId = 334530U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "TrM3XZwKJ7FM7CXfu68utT", Name = "BlendMode", IsManaged = true, IsAutoGenerated = true)]
            public n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __p_TrM3XZwKJ7FM7CXfu68utT;
            public __CxIusnnpZ8aLfSQMTMVJ24(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CxIusnnpZ8aLfSQMTMVJ24(__CxIusnnpZ8aLfSQMTMVJ24 other): base(other)
            {
                this.__p_TrM3XZwKJ7FM7CXfu68utT = other.__p_TrM3XZwKJ7FM7CXfu68utT;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TrM3XZwKJ7FM7CXfu68utT", in __p_TrM3XZwKJ7FM7CXfu68utT));
            }

            internal __CxIusnnpZ8aLfSQMTMVJ24 __WITH__(n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __p_TrM3XZwKJ7FM7CXfu68utT)
            {
                __CxIusnnpZ8aLfSQMTMVJ24 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_TrM3XZwKJ7FM7CXfu68utT != this.__p_TrM3XZwKJ7FM7CXfu68utT ? new __CxIusnnpZ8aLfSQMTMVJ24(this)
                    {__p_TrM3XZwKJ7FM7CXfu68utT = __p_TrM3XZwKJ7FM7CXfu68utT} : that_0;
                else
                {
                    this.__p_TrM3XZwKJ7FM7CXfu68utT = __p_TrM3XZwKJ7FM7CXfu68utT;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 334630U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "VitQnX5PEd9PYrvUkOybj6", Name = "PinLight_VitQnX5PEd9PYrvUkOybj6")]
    [n2.SerializableAttribute]
    public class PinLight_VitQnX5PEd9PYrvUkOybj6<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.PinLight_VitQnX5PEd9PYrvUkOybj6<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new PinLight_VitQnX5PEd9PYrvUkOybj6<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.PinLight_VitQnX5PEd9PYrvUkOybj6<T> CreateDefault()
        {
            var instance = new PinLight_VitQnX5PEd9PYrvUkOybj6<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.PinLight_VitQnX5PEd9PYrvUkOybj6<T> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            string __pad_Cobx6iRZn0POm8HvxCkwDR_0 = __slot_Cobx6iRZn0POm8HvxCkwDR;
            string __pad_HvAG09dagvDL0KQS9qau4U_1 = __slot_HvAG09dagvDL0KQS9qau4U;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_PzcGP0R8YrKM03CNDwPiqJ;
            if (manager_4 is null)
            {
                manager_4 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_5 = (Base_In, Blend_In, Opacity_In, __pad_Cobx6iRZn0POm8HvxCkwDR_0, __pad_HvAG09dagvDL0KQS9qau4U_1);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__Ij6aYdgef3PPVNBCnQOt4n>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __Ij6aYdgef3PPVNBCnQOt4n(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "UyqxtnVpvK0LqIyrcxuKZK", 334654U);
                    var Output_10 = n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T>.Create(Node_Context: Node_Context_9);
                    state_8.__p_UyqxtnVpvK0LqIyrcxuKZK = Output_10;
                }

                var State_Output_12 = state_8.__p_UyqxtnVpvK0LqIyrcxuKZK.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Name_In: __pad_Cobx6iRZn0POm8HvxCkwDR_0, The_Code_Template_In: __pad_HvAG09dagvDL0KQS9qau4U_1, Output_Out: out n5.GpuValue<T> Output_11);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_12 != state_8.__p_UyqxtnVpvK0LqIyrcxuKZK ? new __Ij6aYdgef3PPVNBCnQOt4n(state_8)
                    {__p_UyqxtnVpvK0LqIyrcxuKZK = State_Output_12} : state_8;
                else
                {
                    state_8.__p_UyqxtnVpvK0LqIyrcxuKZK = State_Output_12;
                }

                outputs_6 = n2.ValueTuple.Create(Output_11);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_13 = outputs_6.Item1;
            Output_Out = __auto_13;
            n3.PinLight_VitQnX5PEd9PYrvUkOybj6<T> that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = manager_4 != this.__cache_PzcGP0R8YrKM03CNDwPiqJ ? new PinLight_VitQnX5PEd9PYrvUkOybj6<T>(this)
                {__cache_PzcGP0R8YrKM03CNDwPiqJ = manager_4} : that_14;
            else
            {
                this.__cache_PzcGP0R8YrKM03CNDwPiqJ = manager_4;
            }

            return that_14;
        }

        public n3.PinLight_VitQnX5PEd9PYrvUkOybj6<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.PinLight_VitQnX5PEd9PYrvUkOybj6<T> that_0 = this;
            this.__cache_PzcGP0R8YrKM03CNDwPiqJ = null;
            return that_0;
        }

        public n3.PinLight_VitQnX5PEd9PYrvUkOybj6<T> __CreateDefault__()
        {
            n3.PinLight_VitQnX5PEd9PYrvUkOybj6<T> that_0 = this;
            this.__cache_PzcGP0R8YrKM03CNDwPiqJ = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_PzcGP0R8YrKM03CNDwPiqJ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 334670U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "HvAG09dagvDL0KQS9qau4U", Name = "__slot_HvAG09dagvDL0KQS9qau4U")]
        public static string __slot_HvAG09dagvDL0KQS9qau4U = "${resultType} ${signature}(${resultType} Base, ${resultType} Blend, ${resultType} Opacity)\r\n{\r\n    ${resultType} check = step (0.5, Blend);\r\n    ${resultType} result1 = check * max(2.0 * (Base - 0.5), Blend);\r\n    ${resultType} Out = result1 + (1.0 - check) * min(2.0 * Base, Blend);\r\n    return lerp(Base, Out, Opacity);\r\n}";
        [n1.ElementAttribute(TracingId = 334677U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Cobx6iRZn0POm8HvxCkwDR", Name = "__slot_Cobx6iRZn0POm8HvxCkwDR")]
        public static string __slot_Cobx6iRZn0POm8HvxCkwDR = "PinLight";
        [n1.ElementAttribute(TracingId = 334634U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "PzcGP0R8YrKM03CNDwPiqJ", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_PzcGP0R8YrKM03CNDwPiqJ = null;
        static PinLight_VitQnX5PEd9PYrvUkOybj6()
        {
        }

        public PinLight_VitQnX5PEd9PYrvUkOybj6(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PinLight_VitQnX5PEd9PYrvUkOybj6(PinLight_VitQnX5PEd9PYrvUkOybj6<T> other): base(other)
        {
            this.__cache_PzcGP0R8YrKM03CNDwPiqJ = other.__cache_PzcGP0R8YrKM03CNDwPiqJ;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_PzcGP0R8YrKM03CNDwPiqJ", in __cache_PzcGP0R8YrKM03CNDwPiqJ));
        }

        internal PinLight_VitQnX5PEd9PYrvUkOybj6<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_PzcGP0R8YrKM03CNDwPiqJ)
        {
            n3.PinLight_VitQnX5PEd9PYrvUkOybj6<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_PzcGP0R8YrKM03CNDwPiqJ != this.__cache_PzcGP0R8YrKM03CNDwPiqJ ? new PinLight_VitQnX5PEd9PYrvUkOybj6<T>(this)
                {__cache_PzcGP0R8YrKM03CNDwPiqJ = __cache_PzcGP0R8YrKM03CNDwPiqJ} : that_0;
            else
            {
                this.__cache_PzcGP0R8YrKM03CNDwPiqJ = __cache_PzcGP0R8YrKM03CNDwPiqJ;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Ij6aYdgef3PPVNBCnQOt4n", Name = "__Ij6aYdgef3PPVNBCnQOt4n")]
        [n2.SerializableAttribute]
        public class __Ij6aYdgef3PPVNBCnQOt4n : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UyqxtnVpvK0LqIyrcxuKZK);
                return;
            }

            [n1.ElementAttribute(TracingId = 334654U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "UyqxtnVpvK0LqIyrcxuKZK", Name = "BlendMode", IsManaged = true, IsAutoGenerated = true)]
            public n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __p_UyqxtnVpvK0LqIyrcxuKZK;
            public __Ij6aYdgef3PPVNBCnQOt4n(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Ij6aYdgef3PPVNBCnQOt4n(__Ij6aYdgef3PPVNBCnQOt4n other): base(other)
            {
                this.__p_UyqxtnVpvK0LqIyrcxuKZK = other.__p_UyqxtnVpvK0LqIyrcxuKZK;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UyqxtnVpvK0LqIyrcxuKZK", in __p_UyqxtnVpvK0LqIyrcxuKZK));
            }

            internal __Ij6aYdgef3PPVNBCnQOt4n __WITH__(n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __p_UyqxtnVpvK0LqIyrcxuKZK)
            {
                __Ij6aYdgef3PPVNBCnQOt4n that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_UyqxtnVpvK0LqIyrcxuKZK != this.__p_UyqxtnVpvK0LqIyrcxuKZK ? new __Ij6aYdgef3PPVNBCnQOt4n(this)
                    {__p_UyqxtnVpvK0LqIyrcxuKZK = __p_UyqxtnVpvK0LqIyrcxuKZK} : that_0;
                else
                {
                    this.__p_UyqxtnVpvK0LqIyrcxuKZK = __p_UyqxtnVpvK0LqIyrcxuKZK;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 334722U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "UQvzl0XTkXGL7E72KAvxlT", Name = "Screen_UQvzl0XTkXGL7E72KAvxlT")]
    [n2.SerializableAttribute]
    public class Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2> CreateDefault()
        {
            var instance = new Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_OprQS4q7WXZMrW5LWwZZmD;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Base_In, Blend_In, Opacity_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__DQWpioZlPjmMxMC6qgvWJH>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __DQWpioZlPjmMxMC6qgvWJH(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "CBOKw6QX1ixOkaQLITDIEu", 334748U);
                    var Output_8 = n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_CBOKw6QX1ixOkaQLITDIEu = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "VGFpZVkgTz6MPb4UV2IjvY", 334752U);
                    var Output_10 = n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_VGFpZVkgTz6MPb4UV2IjvY = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "JRaNke5IO5xNZoo4eTdBpl", 334759U);
                    var Output_12 = n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_11);
                    state_6.__p_JRaNke5IO5xNZoo4eTdBpl = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "ADTA8vOTKXmNY0c6CFcj2H", 334766U);
                    var Output_14 = n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T>.Create(Node_Context: Node_Context_13);
                    state_6.__p_ADTA8vOTKXmNY0c6CFcj2H = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Uv6qAkAnmWOO7QUvCk7Yv4", 334773U);
                    var Output_16 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_15);
                    state_6.__p_Uv6qAkAnmWOO7QUvCk7Yv4 = Output_16;
                }

                var State_Output_18 = state_6.__p_CBOKw6QX1ixOkaQLITDIEu.Update(Input_In: Base_In, Output_Out: out n5.GpuValue<T> Output_17);
                var State_Output_20 = state_6.__p_VGFpZVkgTz6MPb4UV2IjvY.Update(Input_In: Blend_In, Output_Out: out n5.GpuValue<T> Output_19);
                var builder_21 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl, 2);
                builder_21.Add(Output_17);
                builder_21.Add(Output_19);
                var __pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl_22 = builder_21.Commit();
                var State_Output_24 = state_6.__p_JRaNke5IO5xNZoo4eTdBpl.Update(Input_In: __pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl_22, Output_Out: out n5.GpuValue<T> Output_23);
                var State_Output_26 = state_6.__p_ADTA8vOTKXmNY0c6CFcj2H.Update(Input_In: Output_23, Output_Out: out n5.GpuValue<T> Output_25);
                n5.GpuValue<T> Default_27 = default(n5.GpuValue<T>);
                var State_Output_29 = state_6.__p_Uv6qAkAnmWOO7QUvCk7Yv4.Update(Input1_In: Base_In, Input2_In: Output_25, Mix_In: Opacity_In, Default_In: Default_27, Output_Out: out n5.GpuValue<T> Output_28);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_18 != state_6.__p_CBOKw6QX1ixOkaQLITDIEu || State_Output_20 != state_6.__p_VGFpZVkgTz6MPb4UV2IjvY || __pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl_22 != state_6.__pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl || State_Output_24 != state_6.__p_JRaNke5IO5xNZoo4eTdBpl || State_Output_26 != state_6.__p_ADTA8vOTKXmNY0c6CFcj2H || State_Output_29 != state_6.__p_Uv6qAkAnmWOO7QUvCk7Yv4 ? new __DQWpioZlPjmMxMC6qgvWJH(state_6)
                    {__p_CBOKw6QX1ixOkaQLITDIEu = State_Output_18, __p_VGFpZVkgTz6MPb4UV2IjvY = State_Output_20, __pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl = __pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl_22, __p_JRaNke5IO5xNZoo4eTdBpl = State_Output_24, __p_ADTA8vOTKXmNY0c6CFcj2H = State_Output_26, __p_Uv6qAkAnmWOO7QUvCk7Yv4 = State_Output_29} : state_6;
                else
                {
                    state_6.__p_CBOKw6QX1ixOkaQLITDIEu = State_Output_18;
                    state_6.__p_VGFpZVkgTz6MPb4UV2IjvY = State_Output_20;
                    state_6.__pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl = __pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl_22;
                    state_6.__p_JRaNke5IO5xNZoo4eTdBpl = State_Output_24;
                    state_6.__p_ADTA8vOTKXmNY0c6CFcj2H = State_Output_26;
                    state_6.__p_Uv6qAkAnmWOO7QUvCk7Yv4 = State_Output_29;
                }

                outputs_4 = n2.ValueTuple.Create(Output_28);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_30 = outputs_4.Item1;
            Output_Out = __auto_30;
            n3.Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2> that_31 = this;
            if (this.__GetContext__().IsImmutable)
                that_31 = manager_2 != this.__cache_OprQS4q7WXZMrW5LWwZZmD ? new Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2>(this)
                {__cache_OprQS4q7WXZMrW5LWwZZmD = manager_2} : that_31;
            else
            {
                this.__cache_OprQS4q7WXZMrW5LWwZZmD = manager_2;
            }

            return that_31;
        }

        public n3.Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2> that_0 = this;
            this.__cache_OprQS4q7WXZMrW5LWwZZmD = null;
            return that_0;
        }

        public n3.Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2> __CreateDefault__()
        {
            n3.Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2> that_0 = this;
            this.__cache_OprQS4q7WXZMrW5LWwZZmD = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_OprQS4q7WXZMrW5LWwZZmD);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 334729U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "OprQS4q7WXZMrW5LWwZZmD", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_OprQS4q7WXZMrW5LWwZZmD = null;
        public Screen_UQvzl0XTkXGL7E72KAvxlT(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Screen_UQvzl0XTkXGL7E72KAvxlT(Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2> other): base(other)
        {
            this.__cache_OprQS4q7WXZMrW5LWwZZmD = other.__cache_OprQS4q7WXZMrW5LWwZZmD;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_OprQS4q7WXZMrW5LWwZZmD", in __cache_OprQS4q7WXZMrW5LWwZZmD));
        }

        internal Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_OprQS4q7WXZMrW5LWwZZmD)
        {
            n3.Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_OprQS4q7WXZMrW5LWwZZmD != this.__cache_OprQS4q7WXZMrW5LWwZZmD ? new Screen_UQvzl0XTkXGL7E72KAvxlT<T, T2>(this)
                {__cache_OprQS4q7WXZMrW5LWwZZmD = __cache_OprQS4q7WXZMrW5LWwZZmD} : that_0;
            else
            {
                this.__cache_OprQS4q7WXZMrW5LWwZZmD = __cache_OprQS4q7WXZMrW5LWwZZmD;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "DQWpioZlPjmMxMC6qgvWJH", Name = "__DQWpioZlPjmMxMC6qgvWJH")]
        [n2.SerializableAttribute]
        public class __DQWpioZlPjmMxMC6qgvWJH : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_CBOKw6QX1ixOkaQLITDIEu);
                n1.CompilationHelper.SafeDispose(this.__p_VGFpZVkgTz6MPb4UV2IjvY);
                n1.CompilationHelper.SafeDispose(this.__p_JRaNke5IO5xNZoo4eTdBpl);
                n1.CompilationHelper.SafeDispose(this.__p_ADTA8vOTKXmNY0c6CFcj2H);
                n1.CompilationHelper.SafeDispose(this.__p_Uv6qAkAnmWOO7QUvCk7Yv4);
                return;
            }

            [n1.ElementAttribute(TracingId = 334748U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "CBOKw6QX1ixOkaQLITDIEu", Name = "OneMinus", IsManaged = true, IsAutoGenerated = true)]
            public n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_CBOKw6QX1ixOkaQLITDIEu;
            [n1.ElementAttribute(TracingId = 334752U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "VGFpZVkgTz6MPb4UV2IjvY", Name = "OneMinus", IsManaged = true, IsAutoGenerated = true)]
            public n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_VGFpZVkgTz6MPb4UV2IjvY;
            [n1.ElementAttribute(TracingId = 334759U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "JRaNke5IO5xNZoo4eTdBpl", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_JRaNke5IO5xNZoo4eTdBpl;
            [n1.ElementAttribute(TracingId = 334766U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "ADTA8vOTKXmNY0c6CFcj2H", Name = "OneMinus", IsManaged = true, IsAutoGenerated = true)]
            public n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_ADTA8vOTKXmNY0c6CFcj2H;
            [n1.ElementAttribute(TracingId = 334773U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Uv6qAkAnmWOO7QUvCk7Yv4", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
            public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_Uv6qAkAnmWOO7QUvCk7Yv4;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl = default(n10.Spread<n5.GpuValue<T>>);
            public __DQWpioZlPjmMxMC6qgvWJH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DQWpioZlPjmMxMC6qgvWJH(__DQWpioZlPjmMxMC6qgvWJH other): base(other)
            {
                this.__p_CBOKw6QX1ixOkaQLITDIEu = other.__p_CBOKw6QX1ixOkaQLITDIEu;
                this.__p_VGFpZVkgTz6MPb4UV2IjvY = other.__p_VGFpZVkgTz6MPb4UV2IjvY;
                this.__p_JRaNke5IO5xNZoo4eTdBpl = other.__p_JRaNke5IO5xNZoo4eTdBpl;
                this.__p_ADTA8vOTKXmNY0c6CFcj2H = other.__p_ADTA8vOTKXmNY0c6CFcj2H;
                this.__p_Uv6qAkAnmWOO7QUvCk7Yv4 = other.__p_Uv6qAkAnmWOO7QUvCk7Yv4;
                this.__pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl = other.__pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_CBOKw6QX1ixOkaQLITDIEu", in __p_CBOKw6QX1ixOkaQLITDIEu), n1.CompilationHelper.GetValueOrExisting(values, "__p_VGFpZVkgTz6MPb4UV2IjvY", in __p_VGFpZVkgTz6MPb4UV2IjvY), n1.CompilationHelper.GetValueOrExisting(values, "__p_JRaNke5IO5xNZoo4eTdBpl", in __p_JRaNke5IO5xNZoo4eTdBpl), n1.CompilationHelper.GetValueOrExisting(values, "__p_ADTA8vOTKXmNY0c6CFcj2H", in __p_ADTA8vOTKXmNY0c6CFcj2H), n1.CompilationHelper.GetValueOrExisting(values, "__p_Uv6qAkAnmWOO7QUvCk7Yv4", in __p_Uv6qAkAnmWOO7QUvCk7Yv4), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl", in __pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl));
            }

            internal __DQWpioZlPjmMxMC6qgvWJH __WITH__(n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_CBOKw6QX1ixOkaQLITDIEu, n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_VGFpZVkgTz6MPb4UV2IjvY, n9.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_JRaNke5IO5xNZoo4eTdBpl, n9.OneMinus_TZSID1klGMVLkhX7sgErcR<T> __p_ADTA8vOTKXmNY0c6CFcj2H, n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_Uv6qAkAnmWOO7QUvCk7Yv4, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl)
            {
                __DQWpioZlPjmMxMC6qgvWJH that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_CBOKw6QX1ixOkaQLITDIEu != this.__p_CBOKw6QX1ixOkaQLITDIEu || __p_VGFpZVkgTz6MPb4UV2IjvY != this.__p_VGFpZVkgTz6MPb4UV2IjvY || __p_JRaNke5IO5xNZoo4eTdBpl != this.__p_JRaNke5IO5xNZoo4eTdBpl || __p_ADTA8vOTKXmNY0c6CFcj2H != this.__p_ADTA8vOTKXmNY0c6CFcj2H || __p_Uv6qAkAnmWOO7QUvCk7Yv4 != this.__p_Uv6qAkAnmWOO7QUvCk7Yv4 || __pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl != this.__pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl ? new __DQWpioZlPjmMxMC6qgvWJH(this)
                    {__p_CBOKw6QX1ixOkaQLITDIEu = __p_CBOKw6QX1ixOkaQLITDIEu, __p_VGFpZVkgTz6MPb4UV2IjvY = __p_VGFpZVkgTz6MPb4UV2IjvY, __p_JRaNke5IO5xNZoo4eTdBpl = __p_JRaNke5IO5xNZoo4eTdBpl, __p_ADTA8vOTKXmNY0c6CFcj2H = __p_ADTA8vOTKXmNY0c6CFcj2H, __p_Uv6qAkAnmWOO7QUvCk7Yv4 = __p_Uv6qAkAnmWOO7QUvCk7Yv4, __pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl = __pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl} : that_0;
                else
                {
                    this.__p_CBOKw6QX1ixOkaQLITDIEu = __p_CBOKw6QX1ixOkaQLITDIEu;
                    this.__p_VGFpZVkgTz6MPb4UV2IjvY = __p_VGFpZVkgTz6MPb4UV2IjvY;
                    this.__p_JRaNke5IO5xNZoo4eTdBpl = __p_JRaNke5IO5xNZoo4eTdBpl;
                    this.__p_ADTA8vOTKXmNY0c6CFcj2H = __p_ADTA8vOTKXmNY0c6CFcj2H;
                    this.__p_Uv6qAkAnmWOO7QUvCk7Yv4 = __p_Uv6qAkAnmWOO7QUvCk7Yv4;
                    this.__pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl = __pin_group_Input_In_JRaNke5IO5xNZoo4eTdBpl;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 334825U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "T5zgZZdezrVQFrECFVrN0l", Name = "SoftLight_T5zgZZdezrVQFrECFVrN0l")]
    [n2.SerializableAttribute]
    public class SoftLight_T5zgZZdezrVQFrECFVrN0l<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SoftLight_T5zgZZdezrVQFrECFVrN0l<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new SoftLight_T5zgZZdezrVQFrECFVrN0l<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SoftLight_T5zgZZdezrVQFrECFVrN0l<T> CreateDefault()
        {
            var instance = new SoftLight_T5zgZZdezrVQFrECFVrN0l<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SoftLight_T5zgZZdezrVQFrECFVrN0l<T> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            string __pad_S7menmXLTL9NNxPfMw1YIW_0 = __slot_S7menmXLTL9NNxPfMw1YIW;
            string __pad_FSY2YGz9i6xN3EWQ45jegm_1 = __slot_FSY2YGz9i6xN3EWQ45jegm;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_TjtJlSAPhf3PNcNOeqQFtT;
            if (manager_4 is null)
            {
                manager_4 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_5 = (Base_In, Blend_In, Opacity_In, __pad_S7menmXLTL9NNxPfMw1YIW_0, __pad_FSY2YGz9i6xN3EWQ45jegm_1);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__HWDRJOzBRLtPuQuVldjtvb>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __HWDRJOzBRLtPuQuVldjtvb(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "NYkyERGPYdgPxP7eLkZHcS", 334845U);
                    var Output_10 = n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T>.Create(Node_Context: Node_Context_9);
                    state_8.__p_NYkyERGPYdgPxP7eLkZHcS = Output_10;
                }

                var State_Output_12 = state_8.__p_NYkyERGPYdgPxP7eLkZHcS.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Name_In: __pad_S7menmXLTL9NNxPfMw1YIW_0, The_Code_Template_In: __pad_FSY2YGz9i6xN3EWQ45jegm_1, Output_Out: out n5.GpuValue<T> Output_11);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_12 != state_8.__p_NYkyERGPYdgPxP7eLkZHcS ? new __HWDRJOzBRLtPuQuVldjtvb(state_8)
                    {__p_NYkyERGPYdgPxP7eLkZHcS = State_Output_12} : state_8;
                else
                {
                    state_8.__p_NYkyERGPYdgPxP7eLkZHcS = State_Output_12;
                }

                outputs_6 = n2.ValueTuple.Create(Output_11);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_13 = outputs_6.Item1;
            Output_Out = __auto_13;
            n3.SoftLight_T5zgZZdezrVQFrECFVrN0l<T> that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = manager_4 != this.__cache_TjtJlSAPhf3PNcNOeqQFtT ? new SoftLight_T5zgZZdezrVQFrECFVrN0l<T>(this)
                {__cache_TjtJlSAPhf3PNcNOeqQFtT = manager_4} : that_14;
            else
            {
                this.__cache_TjtJlSAPhf3PNcNOeqQFtT = manager_4;
            }

            return that_14;
        }

        public n3.SoftLight_T5zgZZdezrVQFrECFVrN0l<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.SoftLight_T5zgZZdezrVQFrECFVrN0l<T> that_0 = this;
            this.__cache_TjtJlSAPhf3PNcNOeqQFtT = null;
            return that_0;
        }

        public n3.SoftLight_T5zgZZdezrVQFrECFVrN0l<T> __CreateDefault__()
        {
            n3.SoftLight_T5zgZZdezrVQFrECFVrN0l<T> that_0 = this;
            this.__cache_TjtJlSAPhf3PNcNOeqQFtT = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_TjtJlSAPhf3PNcNOeqQFtT);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 334858U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "FSY2YGz9i6xN3EWQ45jegm", Name = "__slot_FSY2YGz9i6xN3EWQ45jegm")]
        public static string __slot_FSY2YGz9i6xN3EWQ45jegm = "${resultType} ${signature}(${resultType} Base, ${resultType} Blend, ${resultType} Opacity)\r\n{\r\n    ${resultType} result1 = 2.0 * Base * Blend + Base * Base * (1.0 - 2.0 * Blend);\r\n    ${resultType} result2 = sqrt(Base) * (2.0 * Blend - 1.0) + 2.0 * Base * (1.0 - Blend);\r\n    ${resultType} zeroOrOne = step(0.5, Blend);\r\n    ${resultType} Out = result2 * zeroOrOne + (1 - zeroOrOne) * result1;\r\n    return lerp(Base, Out, Opacity);\r\n}";
        [n1.ElementAttribute(TracingId = 334859U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "S7menmXLTL9NNxPfMw1YIW", Name = "__slot_S7menmXLTL9NNxPfMw1YIW")]
        public static string __slot_S7menmXLTL9NNxPfMw1YIW = "SoftLight";
        [n1.ElementAttribute(TracingId = 334828U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "TjtJlSAPhf3PNcNOeqQFtT", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_TjtJlSAPhf3PNcNOeqQFtT = null;
        static SoftLight_T5zgZZdezrVQFrECFVrN0l()
        {
        }

        public SoftLight_T5zgZZdezrVQFrECFVrN0l(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SoftLight_T5zgZZdezrVQFrECFVrN0l(SoftLight_T5zgZZdezrVQFrECFVrN0l<T> other): base(other)
        {
            this.__cache_TjtJlSAPhf3PNcNOeqQFtT = other.__cache_TjtJlSAPhf3PNcNOeqQFtT;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_TjtJlSAPhf3PNcNOeqQFtT", in __cache_TjtJlSAPhf3PNcNOeqQFtT));
        }

        internal SoftLight_T5zgZZdezrVQFrECFVrN0l<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_TjtJlSAPhf3PNcNOeqQFtT)
        {
            n3.SoftLight_T5zgZZdezrVQFrECFVrN0l<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_TjtJlSAPhf3PNcNOeqQFtT != this.__cache_TjtJlSAPhf3PNcNOeqQFtT ? new SoftLight_T5zgZZdezrVQFrECFVrN0l<T>(this)
                {__cache_TjtJlSAPhf3PNcNOeqQFtT = __cache_TjtJlSAPhf3PNcNOeqQFtT} : that_0;
            else
            {
                this.__cache_TjtJlSAPhf3PNcNOeqQFtT = __cache_TjtJlSAPhf3PNcNOeqQFtT;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "HWDRJOzBRLtPuQuVldjtvb", Name = "__HWDRJOzBRLtPuQuVldjtvb")]
        [n2.SerializableAttribute]
        public class __HWDRJOzBRLtPuQuVldjtvb : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_NYkyERGPYdgPxP7eLkZHcS);
                return;
            }

            [n1.ElementAttribute(TracingId = 334845U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "NYkyERGPYdgPxP7eLkZHcS", Name = "BlendMode", IsManaged = true, IsAutoGenerated = true)]
            public n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __p_NYkyERGPYdgPxP7eLkZHcS;
            public __HWDRJOzBRLtPuQuVldjtvb(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __HWDRJOzBRLtPuQuVldjtvb(__HWDRJOzBRLtPuQuVldjtvb other): base(other)
            {
                this.__p_NYkyERGPYdgPxP7eLkZHcS = other.__p_NYkyERGPYdgPxP7eLkZHcS;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NYkyERGPYdgPxP7eLkZHcS", in __p_NYkyERGPYdgPxP7eLkZHcS));
            }

            internal __HWDRJOzBRLtPuQuVldjtvb __WITH__(n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __p_NYkyERGPYdgPxP7eLkZHcS)
            {
                __HWDRJOzBRLtPuQuVldjtvb that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_NYkyERGPYdgPxP7eLkZHcS != this.__p_NYkyERGPYdgPxP7eLkZHcS ? new __HWDRJOzBRLtPuQuVldjtvb(this)
                    {__p_NYkyERGPYdgPxP7eLkZHcS = __p_NYkyERGPYdgPxP7eLkZHcS} : that_0;
                else
                {
                    this.__p_NYkyERGPYdgPxP7eLkZHcS = __p_NYkyERGPYdgPxP7eLkZHcS;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 334907U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "JSohqrkBSVOPulVVpiaUHo", Name = "Subtract_JSohqrkBSVOPulVVpiaUHo")]
    [n2.SerializableAttribute]
    public class Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2> CreateDefault()
        {
            var instance = new Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T2> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_LM2Nbue6TevO2LxG9163eg;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Base_In, Blend_In, Opacity_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__Jhr8qgAqIxVPJcMLRHFuRY>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __Jhr8qgAqIxVPJcMLRHFuRY(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_QKQiBSciOODPBI67a788MM = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "NpOWxtWoVA5OJx38T1tkkq", 334936U);
                    var Output_8 = n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2>.Create(Node_Context: Node_Context_7);
                    state_6.__p_NpOWxtWoVA5OJx38T1tkkq = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "QKQiBSciOODPBI67a788MM", 334941U);
                    var Output_10 = n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_QKQiBSciOODPBI67a788MM = Output_10;
                }

                var builder_11 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_QKQiBSciOODPBI67a788MM, 2);
                builder_11.Add(Base_In);
                builder_11.Add(Blend_In);
                var __pin_group_Input_In_QKQiBSciOODPBI67a788MM_12 = builder_11.Commit();
                var State_Output_14 = state_6.__p_QKQiBSciOODPBI67a788MM.Update(Input_In: __pin_group_Input_In_QKQiBSciOODPBI67a788MM_12, Output_Out: out n5.GpuValue<T> Output_13);
                n5.GpuValue<T> Default_15 = default(n5.GpuValue<T>);
                var State_Output_17 = state_6.__p_NpOWxtWoVA5OJx38T1tkkq.Update(Input1_In: Base_In, Input2_In: Output_13, Mix_In: Opacity_In, Default_In: Default_15, Output_Out: out n5.GpuValue<T> Output_16);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = __pin_group_Input_In_QKQiBSciOODPBI67a788MM_12 != state_6.__pin_group_Input_In_QKQiBSciOODPBI67a788MM || State_Output_14 != state_6.__p_QKQiBSciOODPBI67a788MM || State_Output_17 != state_6.__p_NpOWxtWoVA5OJx38T1tkkq ? new __Jhr8qgAqIxVPJcMLRHFuRY(state_6)
                    {__pin_group_Input_In_QKQiBSciOODPBI67a788MM = __pin_group_Input_In_QKQiBSciOODPBI67a788MM_12, __p_QKQiBSciOODPBI67a788MM = State_Output_14, __p_NpOWxtWoVA5OJx38T1tkkq = State_Output_17} : state_6;
                else
                {
                    state_6.__pin_group_Input_In_QKQiBSciOODPBI67a788MM = __pin_group_Input_In_QKQiBSciOODPBI67a788MM_12;
                    state_6.__p_QKQiBSciOODPBI67a788MM = State_Output_14;
                    state_6.__p_NpOWxtWoVA5OJx38T1tkkq = State_Output_17;
                }

                outputs_4 = n2.ValueTuple.Create(Output_16);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_18 = outputs_4.Item1;
            Output_Out = __auto_18;
            n3.Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2> that_19 = this;
            if (this.__GetContext__().IsImmutable)
                that_19 = manager_2 != this.__cache_LM2Nbue6TevO2LxG9163eg ? new Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2>(this)
                {__cache_LM2Nbue6TevO2LxG9163eg = manager_2} : that_19;
            else
            {
                this.__cache_LM2Nbue6TevO2LxG9163eg = manager_2;
            }

            return that_19;
        }

        public n3.Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2> that_0 = this;
            this.__cache_LM2Nbue6TevO2LxG9163eg = null;
            return that_0;
        }

        public n3.Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2> __CreateDefault__()
        {
            n3.Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2> that_0 = this;
            this.__cache_LM2Nbue6TevO2LxG9163eg = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_LM2Nbue6TevO2LxG9163eg);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 334912U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "LM2Nbue6TevO2LxG9163eg", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_LM2Nbue6TevO2LxG9163eg = null;
        public Subtract_JSohqrkBSVOPulVVpiaUHo(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Subtract_JSohqrkBSVOPulVVpiaUHo(Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2> other): base(other)
        {
            this.__cache_LM2Nbue6TevO2LxG9163eg = other.__cache_LM2Nbue6TevO2LxG9163eg;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_LM2Nbue6TevO2LxG9163eg", in __cache_LM2Nbue6TevO2LxG9163eg));
        }

        internal Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T2>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_LM2Nbue6TevO2LxG9163eg)
        {
            n3.Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_LM2Nbue6TevO2LxG9163eg != this.__cache_LM2Nbue6TevO2LxG9163eg ? new Subtract_JSohqrkBSVOPulVVpiaUHo<T, T2>(this)
                {__cache_LM2Nbue6TevO2LxG9163eg = __cache_LM2Nbue6TevO2LxG9163eg} : that_0;
            else
            {
                this.__cache_LM2Nbue6TevO2LxG9163eg = __cache_LM2Nbue6TevO2LxG9163eg;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Jhr8qgAqIxVPJcMLRHFuRY", Name = "__Jhr8qgAqIxVPJcMLRHFuRY")]
        [n2.SerializableAttribute]
        public class __Jhr8qgAqIxVPJcMLRHFuRY : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_NpOWxtWoVA5OJx38T1tkkq);
                n1.CompilationHelper.SafeDispose(this.__p_QKQiBSciOODPBI67a788MM);
                return;
            }

            [n1.ElementAttribute(TracingId = 334936U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "NpOWxtWoVA5OJx38T1tkkq", Name = "Lerp", IsManaged = true, IsAutoGenerated = true)]
            public n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_NpOWxtWoVA5OJx38T1tkkq;
            [n1.ElementAttribute(TracingId = 334941U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "QKQiBSciOODPBI67a788MM", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T> __p_QKQiBSciOODPBI67a788MM;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_QKQiBSciOODPBI67a788MM = default(n10.Spread<n5.GpuValue<T>>);
            public __Jhr8qgAqIxVPJcMLRHFuRY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Jhr8qgAqIxVPJcMLRHFuRY(__Jhr8qgAqIxVPJcMLRHFuRY other): base(other)
            {
                this.__p_NpOWxtWoVA5OJx38T1tkkq = other.__p_NpOWxtWoVA5OJx38T1tkkq;
                this.__p_QKQiBSciOODPBI67a788MM = other.__p_QKQiBSciOODPBI67a788MM;
                this.__pin_group_Input_In_QKQiBSciOODPBI67a788MM = other.__pin_group_Input_In_QKQiBSciOODPBI67a788MM;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NpOWxtWoVA5OJx38T1tkkq", in __p_NpOWxtWoVA5OJx38T1tkkq), n1.CompilationHelper.GetValueOrExisting(values, "__p_QKQiBSciOODPBI67a788MM", in __p_QKQiBSciOODPBI67a788MM), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_QKQiBSciOODPBI67a788MM", in __pin_group_Input_In_QKQiBSciOODPBI67a788MM));
            }

            internal __Jhr8qgAqIxVPJcMLRHFuRY __WITH__(n9.Lerp_EinkczVHLaTPmuyxothBQd<T, T2> __p_NpOWxtWoVA5OJx38T1tkkq, n9.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<T> __p_QKQiBSciOODPBI67a788MM, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_QKQiBSciOODPBI67a788MM)
            {
                __Jhr8qgAqIxVPJcMLRHFuRY that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_NpOWxtWoVA5OJx38T1tkkq != this.__p_NpOWxtWoVA5OJx38T1tkkq || __p_QKQiBSciOODPBI67a788MM != this.__p_QKQiBSciOODPBI67a788MM || __pin_group_Input_In_QKQiBSciOODPBI67a788MM != this.__pin_group_Input_In_QKQiBSciOODPBI67a788MM ? new __Jhr8qgAqIxVPJcMLRHFuRY(this)
                    {__p_NpOWxtWoVA5OJx38T1tkkq = __p_NpOWxtWoVA5OJx38T1tkkq, __p_QKQiBSciOODPBI67a788MM = __p_QKQiBSciOODPBI67a788MM, __pin_group_Input_In_QKQiBSciOODPBI67a788MM = __pin_group_Input_In_QKQiBSciOODPBI67a788MM} : that_0;
                else
                {
                    this.__p_NpOWxtWoVA5OJx38T1tkkq = __p_NpOWxtWoVA5OJx38T1tkkq;
                    this.__p_QKQiBSciOODPBI67a788MM = __p_QKQiBSciOODPBI67a788MM;
                    this.__pin_group_Input_In_QKQiBSciOODPBI67a788MM = __pin_group_Input_In_QKQiBSciOODPBI67a788MM;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 334988U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "ExblW0y26zQMvVw3hWoSg4", Name = "VividLight_ExblW0y26zQMvVw3hWoSg4")]
    [n2.SerializableAttribute]
    public class VividLight_ExblW0y26zQMvVw3hWoSg4<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.VividLight_ExblW0y26zQMvVw3hWoSg4<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new VividLight_ExblW0y26zQMvVw3hWoSg4<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.VividLight_ExblW0y26zQMvVw3hWoSg4<T> CreateDefault()
        {
            var instance = new VividLight_ExblW0y26zQMvVw3hWoSg4<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VividLight_ExblW0y26zQMvVw3hWoSg4<T> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            string __pad_Q7SlsHP8D38LF2QvVAXgCE_0 = __slot_Q7SlsHP8D38LF2QvVAXgCE;
            string __pad_SpmNu2ztcPzLBQKNRa0nN7_1 = __slot_SpmNu2ztcPzLBQKNRa0nN7;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_KTVLLsVq6TKMBDWze4n2Ko;
            if (manager_4 is null)
            {
                manager_4 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_5 = (Base_In, Blend_In, Opacity_In, __pad_Q7SlsHP8D38LF2QvVAXgCE_0, __pad_SpmNu2ztcPzLBQKNRa0nN7_1);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__D1UHNWW0a2MN1STAdLHN0O>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __D1UHNWW0a2MN1STAdLHN0O(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Oq53M2woBkIOPQopemVjyi", 335015U);
                    var Output_10 = n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T>.Create(Node_Context: Node_Context_9);
                    state_8.__p_Oq53M2woBkIOPQopemVjyi = Output_10;
                }

                var State_Output_12 = state_8.__p_Oq53M2woBkIOPQopemVjyi.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Name_In: __pad_Q7SlsHP8D38LF2QvVAXgCE_0, The_Code_Template_In: __pad_SpmNu2ztcPzLBQKNRa0nN7_1, Output_Out: out n5.GpuValue<T> Output_11);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_12 != state_8.__p_Oq53M2woBkIOPQopemVjyi ? new __D1UHNWW0a2MN1STAdLHN0O(state_8)
                    {__p_Oq53M2woBkIOPQopemVjyi = State_Output_12} : state_8;
                else
                {
                    state_8.__p_Oq53M2woBkIOPQopemVjyi = State_Output_12;
                }

                outputs_6 = n2.ValueTuple.Create(Output_11);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_13 = outputs_6.Item1;
            Output_Out = __auto_13;
            n3.VividLight_ExblW0y26zQMvVw3hWoSg4<T> that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = manager_4 != this.__cache_KTVLLsVq6TKMBDWze4n2Ko ? new VividLight_ExblW0y26zQMvVw3hWoSg4<T>(this)
                {__cache_KTVLLsVq6TKMBDWze4n2Ko = manager_4} : that_14;
            else
            {
                this.__cache_KTVLLsVq6TKMBDWze4n2Ko = manager_4;
            }

            return that_14;
        }

        public n3.VividLight_ExblW0y26zQMvVw3hWoSg4<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.VividLight_ExblW0y26zQMvVw3hWoSg4<T> that_0 = this;
            this.__cache_KTVLLsVq6TKMBDWze4n2Ko = null;
            return that_0;
        }

        public n3.VividLight_ExblW0y26zQMvVw3hWoSg4<T> __CreateDefault__()
        {
            n3.VividLight_ExblW0y26zQMvVw3hWoSg4<T> that_0 = this;
            this.__cache_KTVLLsVq6TKMBDWze4n2Ko = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_KTVLLsVq6TKMBDWze4n2Ko);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 335034U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "SpmNu2ztcPzLBQKNRa0nN7", Name = "__slot_SpmNu2ztcPzLBQKNRa0nN7")]
        public static string __slot_SpmNu2ztcPzLBQKNRa0nN7 = "${resultType} ${signature}(${resultType} Base, ${resultType} Blend, ${resultType} Opacity)\r\n{;\r\n    ${resultType} result1 = 1.0 - (1.0 - Blend) / (2.0 * Base);\r\n    ${resultType} result2 = Blend / (2.0 * (1.0 - Base));\r\n    ${resultType} zeroOrOne = step(0.5, Base);\r\n    ${resultType} Out = result2 * zeroOrOne + (1 - zeroOrOne) * result1;\r\n    return lerp(Base, Out, Opacity);\r\n}";
        [n1.ElementAttribute(TracingId = 335037U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Q7SlsHP8D38LF2QvVAXgCE", Name = "__slot_Q7SlsHP8D38LF2QvVAXgCE")]
        public static string __slot_Q7SlsHP8D38LF2QvVAXgCE = "VividLight";
        [n1.ElementAttribute(TracingId = 334992U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "KTVLLsVq6TKMBDWze4n2Ko", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_KTVLLsVq6TKMBDWze4n2Ko = null;
        static VividLight_ExblW0y26zQMvVw3hWoSg4()
        {
        }

        public VividLight_ExblW0y26zQMvVw3hWoSg4(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VividLight_ExblW0y26zQMvVw3hWoSg4(VividLight_ExblW0y26zQMvVw3hWoSg4<T> other): base(other)
        {
            this.__cache_KTVLLsVq6TKMBDWze4n2Ko = other.__cache_KTVLLsVq6TKMBDWze4n2Ko;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_KTVLLsVq6TKMBDWze4n2Ko", in __cache_KTVLLsVq6TKMBDWze4n2Ko));
        }

        internal VividLight_ExblW0y26zQMvVw3hWoSg4<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_KTVLLsVq6TKMBDWze4n2Ko)
        {
            n3.VividLight_ExblW0y26zQMvVw3hWoSg4<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_KTVLLsVq6TKMBDWze4n2Ko != this.__cache_KTVLLsVq6TKMBDWze4n2Ko ? new VividLight_ExblW0y26zQMvVw3hWoSg4<T>(this)
                {__cache_KTVLLsVq6TKMBDWze4n2Ko = __cache_KTVLLsVq6TKMBDWze4n2Ko} : that_0;
            else
            {
                this.__cache_KTVLLsVq6TKMBDWze4n2Ko = __cache_KTVLLsVq6TKMBDWze4n2Ko;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "D1UHNWW0a2MN1STAdLHN0O", Name = "__D1UHNWW0a2MN1STAdLHN0O")]
        [n2.SerializableAttribute]
        public class __D1UHNWW0a2MN1STAdLHN0O : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Oq53M2woBkIOPQopemVjyi);
                return;
            }

            [n1.ElementAttribute(TracingId = 335015U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Oq53M2woBkIOPQopemVjyi", Name = "BlendMode", IsManaged = true, IsAutoGenerated = true)]
            public n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __p_Oq53M2woBkIOPQopemVjyi;
            public __D1UHNWW0a2MN1STAdLHN0O(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __D1UHNWW0a2MN1STAdLHN0O(__D1UHNWW0a2MN1STAdLHN0O other): base(other)
            {
                this.__p_Oq53M2woBkIOPQopemVjyi = other.__p_Oq53M2woBkIOPQopemVjyi;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Oq53M2woBkIOPQopemVjyi", in __p_Oq53M2woBkIOPQopemVjyi));
            }

            internal __D1UHNWW0a2MN1STAdLHN0O __WITH__(n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __p_Oq53M2woBkIOPQopemVjyi)
            {
                __D1UHNWW0a2MN1STAdLHN0O that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Oq53M2woBkIOPQopemVjyi != this.__p_Oq53M2woBkIOPQopemVjyi ? new __D1UHNWW0a2MN1STAdLHN0O(this)
                    {__p_Oq53M2woBkIOPQopemVjyi = __p_Oq53M2woBkIOPQopemVjyi} : that_0;
                else
                {
                    this.__p_Oq53M2woBkIOPQopemVjyi = __p_Oq53M2woBkIOPQopemVjyi;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 335107U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Jt4xre2iyPMLL7a4kGPMZU", Name = "HardLight_Jt4xre2iyPMLL7a4kGPMZU")]
    [n2.SerializableAttribute]
    public class HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new HardLight_Jt4xre2iyPMLL7a4kGPMZU<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> CreateDefault()
        {
            var instance = new HardLight_Jt4xre2iyPMLL7a4kGPMZU<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T> Opacity_In, out n5.GpuValue<T> Output_Out)
        {
            string __pad_LFnw81PMDRnLwArniv7SRU_0 = __slot_LFnw81PMDRnLwArniv7SRU;
            string __pad_QsROgHGmVTNMVb646BW1dE_1 = __slot_QsROgHGmVTNMVb646BW1dE;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_CRppSrzBoQGOvpbNf8SnvG;
            if (manager_4 is null)
            {
                manager_4 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_5 = (Base_In, Blend_In, Opacity_In, __pad_LFnw81PMDRnLwArniv7SRU_0, __pad_QsROgHGmVTNMVb646BW1dE_1);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__RgBqRaXgtp2OzEMgMQQjbk>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __RgBqRaXgtp2OzEMgMQQjbk(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "MuuxSe3dHaTNxaKguQpBjG", 335133U);
                    var Output_10 = n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T>.Create(Node_Context: Node_Context_9);
                    state_8.__p_MuuxSe3dHaTNxaKguQpBjG = Output_10;
                }

                var State_Output_12 = state_8.__p_MuuxSe3dHaTNxaKguQpBjG.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Name_In: __pad_LFnw81PMDRnLwArniv7SRU_0, The_Code_Template_In: __pad_QsROgHGmVTNMVb646BW1dE_1, Output_Out: out n5.GpuValue<T> Output_11);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_12 != state_8.__p_MuuxSe3dHaTNxaKguQpBjG ? new __RgBqRaXgtp2OzEMgMQQjbk(state_8)
                    {__p_MuuxSe3dHaTNxaKguQpBjG = State_Output_12} : state_8;
                else
                {
                    state_8.__p_MuuxSe3dHaTNxaKguQpBjG = State_Output_12;
                }

                outputs_6 = n2.ValueTuple.Create(Output_11);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_13 = outputs_6.Item1;
            Output_Out = __auto_13;
            n3.HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = manager_4 != this.__cache_CRppSrzBoQGOvpbNf8SnvG ? new HardLight_Jt4xre2iyPMLL7a4kGPMZU<T>(this)
                {__cache_CRppSrzBoQGOvpbNf8SnvG = manager_4} : that_14;
            else
            {
                this.__cache_CRppSrzBoQGOvpbNf8SnvG = manager_4;
            }

            return that_14;
        }

        public n3.HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> that_0 = this;
            this.__cache_CRppSrzBoQGOvpbNf8SnvG = null;
            return that_0;
        }

        public n3.HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> __CreateDefault__()
        {
            n3.HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> that_0 = this;
            this.__cache_CRppSrzBoQGOvpbNf8SnvG = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_CRppSrzBoQGOvpbNf8SnvG);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 335155U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "QsROgHGmVTNMVb646BW1dE", Name = "__slot_QsROgHGmVTNMVb646BW1dE")]
        public static string __slot_QsROgHGmVTNMVb646BW1dE = "${resultType} ${signature}(${resultType} Base, ${resultType} Blend, ${resultType} Opacity)\r\n{\r\n    ${resultType} result1 = 1.0 - 2.0 * (1.0 - Base) * (1.0 - Blend);\r\n    ${resultType} result2 = 2.0 * Base * Blend;\r\n    ${resultType} zeroOrOne = step(Blend, 0.5);\r\n    ${resultType} Out = result2 * zeroOrOne + (1 - zeroOrOne) * result1;\r\n    return lerp(Base, Out, Opacity);\r\n}";
        [n1.ElementAttribute(TracingId = 335157U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "LFnw81PMDRnLwArniv7SRU", Name = "__slot_LFnw81PMDRnLwArniv7SRU")]
        public static string __slot_LFnw81PMDRnLwArniv7SRU = "HardLight";
        [n1.ElementAttribute(TracingId = 335110U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "CRppSrzBoQGOvpbNf8SnvG", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_CRppSrzBoQGOvpbNf8SnvG = null;
        static HardLight_Jt4xre2iyPMLL7a4kGPMZU()
        {
        }

        public HardLight_Jt4xre2iyPMLL7a4kGPMZU(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HardLight_Jt4xre2iyPMLL7a4kGPMZU(HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> other): base(other)
        {
            this.__cache_CRppSrzBoQGOvpbNf8SnvG = other.__cache_CRppSrzBoQGOvpbNf8SnvG;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_CRppSrzBoQGOvpbNf8SnvG", in __cache_CRppSrzBoQGOvpbNf8SnvG));
        }

        internal HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_CRppSrzBoQGOvpbNf8SnvG)
        {
            n3.HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_CRppSrzBoQGOvpbNf8SnvG != this.__cache_CRppSrzBoQGOvpbNf8SnvG ? new HardLight_Jt4xre2iyPMLL7a4kGPMZU<T>(this)
                {__cache_CRppSrzBoQGOvpbNf8SnvG = __cache_CRppSrzBoQGOvpbNf8SnvG} : that_0;
            else
            {
                this.__cache_CRppSrzBoQGOvpbNf8SnvG = __cache_CRppSrzBoQGOvpbNf8SnvG;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "RgBqRaXgtp2OzEMgMQQjbk", Name = "__RgBqRaXgtp2OzEMgMQQjbk")]
        [n2.SerializableAttribute]
        public class __RgBqRaXgtp2OzEMgMQQjbk : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_MuuxSe3dHaTNxaKguQpBjG);
                return;
            }

            [n1.ElementAttribute(TracingId = 335133U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "MuuxSe3dHaTNxaKguQpBjG", Name = "BlendMode", IsManaged = true, IsAutoGenerated = true)]
            public n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __p_MuuxSe3dHaTNxaKguQpBjG;
            public __RgBqRaXgtp2OzEMgMQQjbk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RgBqRaXgtp2OzEMgMQQjbk(__RgBqRaXgtp2OzEMgMQQjbk other): base(other)
            {
                this.__p_MuuxSe3dHaTNxaKguQpBjG = other.__p_MuuxSe3dHaTNxaKguQpBjG;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MuuxSe3dHaTNxaKguQpBjG", in __p_MuuxSe3dHaTNxaKguQpBjG));
            }

            internal __RgBqRaXgtp2OzEMgMQQjbk __WITH__(n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __p_MuuxSe3dHaTNxaKguQpBjG)
            {
                __RgBqRaXgtp2OzEMgMQQjbk that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_MuuxSe3dHaTNxaKguQpBjG != this.__p_MuuxSe3dHaTNxaKguQpBjG ? new __RgBqRaXgtp2OzEMgMQQjbk(this)
                    {__p_MuuxSe3dHaTNxaKguQpBjG = __p_MuuxSe3dHaTNxaKguQpBjG} : that_0;
                else
                {
                    this.__p_MuuxSe3dHaTNxaKguQpBjG = __p_MuuxSe3dHaTNxaKguQpBjG;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 335474U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "CvM0rgqyaZJNCZdtgWsdAB", Name = "GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB")]
    [n2.SerializableAttribute]
    public class GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB Create(n1.NodeContext Node_Context)
        {
            var instance = new GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB CreateDefault()
        {
            var instance = new GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB Update(n15.Color4 Input_In, out n5.GpuValue<n15.Vector4> RGBA_Out, out n5.GpuValue<n15.Vector3> RGB_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_KwmvJ0vlhLNNQ4taoqEPsr;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n15.Color4>, n2.ValueTuple<n5.GpuValue<n15.Vector4>, n5.GpuValue<n15.Vector3>>>((default(n5.GpuValue<n15.Vector4>), default(n5.GpuValue<n15.Vector3>)));
            }

            var inputs_3 = n2.ValueTuple.Create(Input_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__Q3mQTi9jzVnMh1VLRFZOFC>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __Q3mQTi9jzVnMh1VLRFZOFC(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "I1aHmB1hwigPaEtw9VS9b2", 335522U);
                    var Output_8 = n7.GPUIn_C<n15.Vector4>.Create(Node_Context: Node_Context_7);
                    state_6.__p_I1aHmB1hwigPaEtw9VS9b2 = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "I8eFI0g2VGpQKJDNeuOFNI", 335527U);
                    var Output_10 = n8.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_9);
                    state_6.__p_I8eFI0g2VGpQKJDNeuOFNI = Output_10;
                }

                n24.ColorNodes.Split(input: ref Input_In, red: out float Red_11, green: out float Green_12, blue: out float Blue_13, alpha: out float Alpha_14);
                var Output_15 = new n15.Vector4(x: Red_11, y: Green_12, z: Blue_13, w: Alpha_14);
                var State_Output_17 = state_6.__p_I1aHmB1hwigPaEtw9VS9b2.Update(Output_Out: out n5.GpuValue<n15.Vector4> Output_16);
                bool SetValue_18 = true;
                var Output_19 = State_Output_17;
                if (SetValue_18)
                {
                    Output_19 = State_Output_17.SetValue(Input_In: Output_15);
                }

                var State_Output_21 = state_6.__p_I8eFI0g2VGpQKJDNeuOFNI.Update(Input_In: Output_16, Output_Out: out n5.GpuValue<n15.Vector3> Output_20);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = Output_19 != state_6.__p_I1aHmB1hwigPaEtw9VS9b2 || State_Output_21 != state_6.__p_I8eFI0g2VGpQKJDNeuOFNI ? new __Q3mQTi9jzVnMh1VLRFZOFC(state_6)
                    {__p_I1aHmB1hwigPaEtw9VS9b2 = Output_19, __p_I8eFI0g2VGpQKJDNeuOFNI = State_Output_21} : state_6;
                else
                {
                    state_6.__p_I1aHmB1hwigPaEtw9VS9b2 = Output_19;
                    state_6.__p_I8eFI0g2VGpQKJDNeuOFNI = State_Output_21;
                }

                outputs_4 = (Output_16, Output_20);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_22, __auto_23) = outputs_4;
            RGBA_Out = __auto_22;
            RGB_Out = __auto_23;
            n3.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB that_24 = this;
            if (this.__GetContext__().IsImmutable)
                that_24 = manager_2 != this.__cache_KwmvJ0vlhLNNQ4taoqEPsr ? new GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB(this)
                {__cache_KwmvJ0vlhLNNQ4taoqEPsr = manager_2} : that_24;
            else
            {
                this.__cache_KwmvJ0vlhLNNQ4taoqEPsr = manager_2;
            }

            return that_24;
        }

        public n3.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB that_0 = this;
            this.__cache_KwmvJ0vlhLNNQ4taoqEPsr = null;
            return that_0;
        }

        public n3.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB __CreateDefault__()
        {
            n3.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB that_0 = this;
            this.__cache_KwmvJ0vlhLNNQ4taoqEPsr = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_KwmvJ0vlhLNNQ4taoqEPsr);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 335478U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "KwmvJ0vlhLNNQ4taoqEPsr", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n15.Color4>, n2.ValueTuple<n5.GpuValue<n15.Vector4>, n5.GpuValue<n15.Vector3>>> __cache_KwmvJ0vlhLNNQ4taoqEPsr = null;
        public GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB(GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB other): base(other)
        {
            this.__cache_KwmvJ0vlhLNNQ4taoqEPsr = other.__cache_KwmvJ0vlhLNNQ4taoqEPsr;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_KwmvJ0vlhLNNQ4taoqEPsr", in __cache_KwmvJ0vlhLNNQ4taoqEPsr));
        }

        internal GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB __WITH__(n6.Manager<n2.ValueTuple<n15.Color4>, n2.ValueTuple<n5.GpuValue<n15.Vector4>, n5.GpuValue<n15.Vector3>>> __cache_KwmvJ0vlhLNNQ4taoqEPsr)
        {
            n3.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_KwmvJ0vlhLNNQ4taoqEPsr != this.__cache_KwmvJ0vlhLNNQ4taoqEPsr ? new GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB(this)
                {__cache_KwmvJ0vlhLNNQ4taoqEPsr = __cache_KwmvJ0vlhLNNQ4taoqEPsr} : that_0;
            else
            {
                this.__cache_KwmvJ0vlhLNNQ4taoqEPsr = __cache_KwmvJ0vlhLNNQ4taoqEPsr;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Q3mQTi9jzVnMh1VLRFZOFC", Name = "__Q3mQTi9jzVnMh1VLRFZOFC")]
        [n2.SerializableAttribute]
        public class __Q3mQTi9jzVnMh1VLRFZOFC : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_I1aHmB1hwigPaEtw9VS9b2);
                n1.CompilationHelper.SafeDispose(this.__p_I8eFI0g2VGpQKJDNeuOFNI);
                return;
            }

            [n1.ElementAttribute(TracingId = 335522U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "I1aHmB1hwigPaEtw9VS9b2", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
            public n7.GPUIn_C<n15.Vector4> __p_I1aHmB1hwigPaEtw9VS9b2;
            [n1.ElementAttribute(TracingId = 335527U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "I8eFI0g2VGpQKJDNeuOFNI", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
            public n8.xyz_T2WwCF9xAltPhlUuLjVDje __p_I8eFI0g2VGpQKJDNeuOFNI;
            public __Q3mQTi9jzVnMh1VLRFZOFC(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Q3mQTi9jzVnMh1VLRFZOFC(__Q3mQTi9jzVnMh1VLRFZOFC other): base(other)
            {
                this.__p_I1aHmB1hwigPaEtw9VS9b2 = other.__p_I1aHmB1hwigPaEtw9VS9b2;
                this.__p_I8eFI0g2VGpQKJDNeuOFNI = other.__p_I8eFI0g2VGpQKJDNeuOFNI;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_I1aHmB1hwigPaEtw9VS9b2", in __p_I1aHmB1hwigPaEtw9VS9b2), n1.CompilationHelper.GetValueOrExisting(values, "__p_I8eFI0g2VGpQKJDNeuOFNI", in __p_I8eFI0g2VGpQKJDNeuOFNI));
            }

            internal __Q3mQTi9jzVnMh1VLRFZOFC __WITH__(n7.GPUIn_C<n15.Vector4> __p_I1aHmB1hwigPaEtw9VS9b2, n8.xyz_T2WwCF9xAltPhlUuLjVDje __p_I8eFI0g2VGpQKJDNeuOFNI)
            {
                __Q3mQTi9jzVnMh1VLRFZOFC that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_I1aHmB1hwigPaEtw9VS9b2 != this.__p_I1aHmB1hwigPaEtw9VS9b2 || __p_I8eFI0g2VGpQKJDNeuOFNI != this.__p_I8eFI0g2VGpQKJDNeuOFNI ? new __Q3mQTi9jzVnMh1VLRFZOFC(this)
                    {__p_I1aHmB1hwigPaEtw9VS9b2 = __p_I1aHmB1hwigPaEtw9VS9b2, __p_I8eFI0g2VGpQKJDNeuOFNI = __p_I8eFI0g2VGpQKJDNeuOFNI} : that_0;
                else
                {
                    this.__p_I1aHmB1hwigPaEtw9VS9b2 = __p_I1aHmB1hwigPaEtw9VS9b2;
                    this.__p_I8eFI0g2VGpQKJDNeuOFNI = __p_I8eFI0g2VGpQKJDNeuOFNI;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 335602U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "P5Pr2d3DlEBLtERrll2883", Name = "HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883")]
    [n2.SerializableAttribute]
    public class HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883 Create(n1.NodeContext Node_Context)
        {
            var instance = new HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883 CreateDefault()
        {
            var instance = new HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883 Update(n5.GpuValue<float> hue_In, [n4.SerializedDefaultValueAttribute("1", false)] n5.GpuValue<float> saturation_In, [n4.SerializedDefaultValueAttribute("1", false)] n5.GpuValue<float> brightness_In, [n4.SerializedDefaultValueAttribute("1", false)] n5.GpuValue<float> alpha_In, out n5.GpuValue<n15.Vector3> RGB_Out, out n5.GpuValue<n15.Vector4> RGBA_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_Pcri7nZs6eHMuINCzEunz2;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<float>, n5.GpuValue<float>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector4>>>((default(n5.GpuValue<n15.Vector3>), default(n5.GpuValue<n15.Vector4>)));
            }

            var inputs_3 = (hue_In, saturation_In, brightness_In, alpha_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__S5rQ3jedqBGLrAlMVkRHK3>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __S5rQ3jedqBGLrAlMVkRHK3(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "RIRXvPHCQaCO9MujMLGfTV", 335617U);
                    var Output_8 = n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ.Create(Node_Context: Node_Context_7);
                    state_6.__p_RIRXvPHCQaCO9MujMLGfTV = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "T9Q0ttfIyhyLxBgJVc4jk6", 335622U);
                    var Output_10 = n25.xPyPz_join_DXQAa9JpsvIPaXxJNoozEM.Create(Node_Context: Node_Context_9);
                    state_6.__p_T9Q0ttfIyhyLxBgJVc4jk6 = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "SybM1vmCEzxQGx230jW75p", 335629U);
                    var Output_12 = n25.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_11);
                    state_6.__p_SybM1vmCEzxQGx230jW75p = Output_12;
                }

                var State_Output_14 = state_6.__p_T9Q0ttfIyhyLxBgJVc4jk6.Update(x_In: hue_In, y_In: saturation_In, z_In: brightness_In, Output_Out: out n5.GpuValue<n15.Vector3> Output_13);
                var Output_16 = state_6.__p_RIRXvPHCQaCO9MujMLGfTV.Update(HSV_In: Output_13, RGB_Out: out n5.GpuValue<n15.Vector3> RGB_15);
                var State_Output_18 = state_6.__p_SybM1vmCEzxQGx230jW75p.Update(xyz_In: RGB_15, w_In: alpha_In, Output_Out: out n5.GpuValue<n15.Vector4> Output_17);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_14 != state_6.__p_T9Q0ttfIyhyLxBgJVc4jk6 || Output_16 != state_6.__p_RIRXvPHCQaCO9MujMLGfTV || State_Output_18 != state_6.__p_SybM1vmCEzxQGx230jW75p ? new __S5rQ3jedqBGLrAlMVkRHK3(state_6)
                    {__p_T9Q0ttfIyhyLxBgJVc4jk6 = State_Output_14, __p_RIRXvPHCQaCO9MujMLGfTV = Output_16, __p_SybM1vmCEzxQGx230jW75p = State_Output_18} : state_6;
                else
                {
                    state_6.__p_T9Q0ttfIyhyLxBgJVc4jk6 = State_Output_14;
                    state_6.__p_RIRXvPHCQaCO9MujMLGfTV = Output_16;
                    state_6.__p_SybM1vmCEzxQGx230jW75p = State_Output_18;
                }

                outputs_4 = (RGB_15, Output_17);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_19, __auto_20) = outputs_4;
            RGB_Out = __auto_19;
            RGBA_Out = __auto_20;
            n3.HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883 that_21 = this;
            if (this.__GetContext__().IsImmutable)
                that_21 = manager_2 != this.__cache_Pcri7nZs6eHMuINCzEunz2 ? new HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883(this)
                {__cache_Pcri7nZs6eHMuINCzEunz2 = manager_2} : that_21;
            else
            {
                this.__cache_Pcri7nZs6eHMuINCzEunz2 = manager_2;
            }

            return that_21;
        }

        public n3.HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883 __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883 that_0 = this;
            this.__cache_Pcri7nZs6eHMuINCzEunz2 = null;
            return that_0;
        }

        public n3.HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883 __CreateDefault__()
        {
            n3.HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883 that_0 = this;
            this.__cache_Pcri7nZs6eHMuINCzEunz2 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_Pcri7nZs6eHMuINCzEunz2);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 335607U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Pcri7nZs6eHMuINCzEunz2", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<float>, n5.GpuValue<float>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector4>>> __cache_Pcri7nZs6eHMuINCzEunz2 = null;
        public HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883(HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883 other): base(other)
        {
            this.__cache_Pcri7nZs6eHMuINCzEunz2 = other.__cache_Pcri7nZs6eHMuINCzEunz2;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Pcri7nZs6eHMuINCzEunz2", in __cache_Pcri7nZs6eHMuINCzEunz2));
        }

        internal HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883 __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<float>, n5.GpuValue<float>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<n15.Vector3>, n5.GpuValue<n15.Vector4>>> __cache_Pcri7nZs6eHMuINCzEunz2)
        {
            n3.HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Pcri7nZs6eHMuINCzEunz2 != this.__cache_Pcri7nZs6eHMuINCzEunz2 ? new HSVToRGB_Channels_P5Pr2d3DlEBLtERrll2883(this)
                {__cache_Pcri7nZs6eHMuINCzEunz2 = __cache_Pcri7nZs6eHMuINCzEunz2} : that_0;
            else
            {
                this.__cache_Pcri7nZs6eHMuINCzEunz2 = __cache_Pcri7nZs6eHMuINCzEunz2;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "S5rQ3jedqBGLrAlMVkRHK3", Name = "__S5rQ3jedqBGLrAlMVkRHK3")]
        [n2.SerializableAttribute]
        public class __S5rQ3jedqBGLrAlMVkRHK3 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RIRXvPHCQaCO9MujMLGfTV);
                n1.CompilationHelper.SafeDispose(this.__p_T9Q0ttfIyhyLxBgJVc4jk6);
                n1.CompilationHelper.SafeDispose(this.__p_SybM1vmCEzxQGx230jW75p);
                return;
            }

            [n1.ElementAttribute(TracingId = 335617U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "RIRXvPHCQaCO9MujMLGfTV", Name = "HSVtoRGB", IsManaged = true, IsAutoGenerated = true)]
            public n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ __p_RIRXvPHCQaCO9MujMLGfTV;
            [n1.ElementAttribute(TracingId = 335622U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "T9Q0ttfIyhyLxBgJVc4jk6", Name = "x+y+z (join)", IsManaged = true, IsAutoGenerated = true)]
            public n25.xPyPz_join_DXQAa9JpsvIPaXxJNoozEM __p_T9Q0ttfIyhyLxBgJVc4jk6;
            [n1.ElementAttribute(TracingId = 335629U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "SybM1vmCEzxQGx230jW75p", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n25.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_SybM1vmCEzxQGx230jW75p;
            public __S5rQ3jedqBGLrAlMVkRHK3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __S5rQ3jedqBGLrAlMVkRHK3(__S5rQ3jedqBGLrAlMVkRHK3 other): base(other)
            {
                this.__p_RIRXvPHCQaCO9MujMLGfTV = other.__p_RIRXvPHCQaCO9MujMLGfTV;
                this.__p_T9Q0ttfIyhyLxBgJVc4jk6 = other.__p_T9Q0ttfIyhyLxBgJVc4jk6;
                this.__p_SybM1vmCEzxQGx230jW75p = other.__p_SybM1vmCEzxQGx230jW75p;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RIRXvPHCQaCO9MujMLGfTV", in __p_RIRXvPHCQaCO9MujMLGfTV), n1.CompilationHelper.GetValueOrExisting(values, "__p_T9Q0ttfIyhyLxBgJVc4jk6", in __p_T9Q0ttfIyhyLxBgJVc4jk6), n1.CompilationHelper.GetValueOrExisting(values, "__p_SybM1vmCEzxQGx230jW75p", in __p_SybM1vmCEzxQGx230jW75p));
            }

            internal __S5rQ3jedqBGLrAlMVkRHK3 __WITH__(n3.HSVtoRGB_K2v0n0Kv1U1NYFaWpSQKZJ __p_RIRXvPHCQaCO9MujMLGfTV, n25.xPyPz_join_DXQAa9JpsvIPaXxJNoozEM __p_T9Q0ttfIyhyLxBgJVc4jk6, n25.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_SybM1vmCEzxQGx230jW75p)
            {
                __S5rQ3jedqBGLrAlMVkRHK3 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RIRXvPHCQaCO9MujMLGfTV != this.__p_RIRXvPHCQaCO9MujMLGfTV || __p_T9Q0ttfIyhyLxBgJVc4jk6 != this.__p_T9Q0ttfIyhyLxBgJVc4jk6 || __p_SybM1vmCEzxQGx230jW75p != this.__p_SybM1vmCEzxQGx230jW75p ? new __S5rQ3jedqBGLrAlMVkRHK3(this)
                    {__p_RIRXvPHCQaCO9MujMLGfTV = __p_RIRXvPHCQaCO9MujMLGfTV, __p_T9Q0ttfIyhyLxBgJVc4jk6 = __p_T9Q0ttfIyhyLxBgJVc4jk6, __p_SybM1vmCEzxQGx230jW75p = __p_SybM1vmCEzxQGx230jW75p} : that_0;
                else
                {
                    this.__p_RIRXvPHCQaCO9MujMLGfTV = __p_RIRXvPHCQaCO9MujMLGfTV;
                    this.__p_T9Q0ttfIyhyLxBgJVc4jk6 = __p_T9Q0ttfIyhyLxBgJVc4jk6;
                    this.__p_SybM1vmCEzxQGx230jW75p = __p_SybM1vmCEzxQGx230jW75p;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 335718U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "DoTfmLFOXmxO9Gz80n2F7s", Name = "FuseColors_DoTfmLFOXmxO9Gz80n2F7s")]
    [n2.SerializableAttribute]
    public class FuseColors_DoTfmLFOXmxO9Gz80n2F7s : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.FuseColors_DoTfmLFOXmxO9Gz80n2F7s Create(n1.NodeContext Node_Context)
        {
            var instance = new FuseColors_DoTfmLFOXmxO9Gz80n2F7s(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.FuseColors_DoTfmLFOXmxO9Gz80n2F7s CreateDefault()
        {
            var instance = new FuseColors_DoTfmLFOXmxO9Gz80n2F7s(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.FuseColors_DoTfmLFOXmxO9Gz80n2F7s Update(out n10.Spread<n15.Color4> Color_Palette_Out, out n10.Spread<n5.GpuValue<n15.Vector4>> Color_Palette_GPU_Out, out n15.Color4 Black_Out, out n15.Color4 White_Out, out n15.Color4 Tone_Light_Out, out n15.Color4 Tone_Dark_Out, out n15.Color4 Tone_Saturated_Out)
        {
            bool Simulate_0 = false;
            var State_Output_2 = this.__p_KN4t3Fc7z9pMZoQc8kj14u.Update(Simulate_In: Simulate_0, Output_Out: out bool Output_1);
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_BOseez7PwVhLmSw4MUUf9w;
            if (manager_4 is null)
            {
                manager_4 = new n6.Manager<n2.ValueTuple, n2.ValueTuple<n10.Spread<n15.Color4>, n10.Spread<n5.GpuValue<n15.Vector4>>, n15.Color4, n15.Color4, n15.Color4, n15.Color4, n15.Color4>>((n11._Operations_.CreateDefault<n15.Color4>(), n11._Operations_.CreateDefault<n5.GpuValue<n15.Vector4>>(), n26._Operations_.CreateDefault(), n26._Operations_.CreateDefault(), n26._Operations_.CreateDefault(), n26._Operations_.CreateDefault(), n26._Operations_.CreateDefault()));
            }

            var inputs_5 = n2.ValueTuple.Create();
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Output_1 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__DpSVGEs6gaKMaz5SR7bVtp>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __DpSVGEs6gaKMaz5SR7bVtp(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_VvoCdF51yMMOPQ1NuvHpSA = n11._Operations_.CreateDefault<n5.GpuValue<n15.Vector4>>()};
                }

                n10.Spread<n15.Color4> __pad_BW3oTPIVjY2LSCjolQJAoW_9 = __slot_BW3oTPIVjY2LSCjolQJAoW;
                int __pad_E49D0jwyWN6MXEOG60dViX_10 = __slot_E49D0jwyWN6MXEOG60dViX;
                int __pad_Knb7ggrzRFuOlAUFO4vuVU_11 = __slot_Knb7ggrzRFuOlAUFO4vuVU;
                int __pad_O9AtuJRTcCBPW5VtmQDkB9_12 = __slot_O9AtuJRTcCBPW5VtmQDkB9;
                int __pad_TpIVZ1N1XGrMsFqaM6x92M_13 = __slot_TpIVZ1N1XGrMsFqaM6x92M;
                int __pad_V3Bg5bHGR5dPuJLwm8gzrM_14 = __slot_V3Bg5bHGR5dPuJLwm8gzrM;
                var manager_25 = state_8.__loop_DHyvg05RoO2MDi2FiCWotK ?? new n27.ImmutableLifetimeManager();
                var iterator_26 = manager_25.GetIterator(__GetContext__());
                var builder_27 = n4.CollectionBuilders.GetBuilder(state_8.__cp_VvoCdF51yMMOPQ1NuvHpSA, 16);
                n10.Spread<n5.GpuValue<n15.Vector4>> output_28;
                try
                {
                    var i_17 = 0;
                    foreach (var item_15 in n4.CollectionExtensions.AsSpan(__pad_BW3oTPIVjY2LSCjolQJAoW_9))
                    {
                        var splicer_16 = item_15;
                        var i_local_18 = i_17;
                        __DcDTwDLFzHpOmzLQGYLlLz state_19;
                        if (!iterator_26.MoveNext(out state_19))
                        {
                            iterator_26.Add(state_19 = new __DcDTwDLFzHpOmzLQGYLlLz(__GetContext__(), n1.VLObject.NewIdentity()));
                            n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "AnZlzQqM3YdMKcAS3MaK6i", 335743U);
                            var Output_21 = n3.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB.Create(Node_Context: Node_Context_20);
                            state_19.__p_AnZlzQqM3YdMKcAS3MaK6i = Output_21;
                        }

                        var Output_24 = state_19.__p_AnZlzQqM3YdMKcAS3MaK6i.Update(Input_In: splicer_16, RGBA_Out: out n5.GpuValue<n15.Vector4> RGBA_22, RGB_Out: out n5.GpuValue<n15.Vector3> RGB_23);
                        if (state_19.__GetContext__().IsImmutable)
                            state_19 = Output_24 != state_19.__p_AnZlzQqM3YdMKcAS3MaK6i ? new __DcDTwDLFzHpOmzLQGYLlLz(state_19)
                            {__p_AnZlzQqM3YdMKcAS3MaK6i = Output_24} : state_19;
                        else
                        {
                            state_19.__p_AnZlzQqM3YdMKcAS3MaK6i = Output_24;
                        }

                        iterator_26.Update(state_19);
                        builder_27.Add(RGBA_22);
                        i_17++;
                    }
                }
                finally
                {
                    manager_25 = iterator_26.Commit();
                    output_28 = builder_27.Commit();
                }

                n15.Color4 Default_Value_29 = n26._Operations_.CreateDefault();
                n11._Operations_.GetSlice<n15.Color4>(Input_In: __pad_BW3oTPIVjY2LSCjolQJAoW_9, Default_Value_In: Default_Value_29, Index_In: __pad_E49D0jwyWN6MXEOG60dViX_10, Result_Out: out n15.Color4 Result_30);
                n15.Color4 Default_Value_31 = n26._Operations_.CreateDefault();
                n11._Operations_.GetSlice<n15.Color4>(Input_In: __pad_BW3oTPIVjY2LSCjolQJAoW_9, Default_Value_In: Default_Value_31, Index_In: __pad_Knb7ggrzRFuOlAUFO4vuVU_11, Result_Out: out n15.Color4 Result_32);
                n15.Color4 Default_Value_33 = n26._Operations_.CreateDefault();
                n11._Operations_.GetSlice<n15.Color4>(Input_In: __pad_BW3oTPIVjY2LSCjolQJAoW_9, Default_Value_In: Default_Value_33, Index_In: __pad_O9AtuJRTcCBPW5VtmQDkB9_12, Result_Out: out n15.Color4 Result_34);
                n15.Color4 Default_Value_35 = n26._Operations_.CreateDefault();
                n11._Operations_.GetSlice<n15.Color4>(Input_In: __pad_BW3oTPIVjY2LSCjolQJAoW_9, Default_Value_In: Default_Value_35, Index_In: __pad_TpIVZ1N1XGrMsFqaM6x92M_13, Result_Out: out n15.Color4 Result_36);
                n15.Color4 Default_Value_37 = n26._Operations_.CreateDefault();
                n11._Operations_.GetSlice<n15.Color4>(Input_In: __pad_BW3oTPIVjY2LSCjolQJAoW_9, Default_Value_In: Default_Value_37, Index_In: __pad_V3Bg5bHGR5dPuJLwm8gzrM_14, Result_Out: out n15.Color4 Result_38);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = manager_25 != state_8.__loop_DHyvg05RoO2MDi2FiCWotK || output_28 != state_8.__cp_VvoCdF51yMMOPQ1NuvHpSA ? new __DpSVGEs6gaKMaz5SR7bVtp(state_8)
                    {__loop_DHyvg05RoO2MDi2FiCWotK = manager_25, __cp_VvoCdF51yMMOPQ1NuvHpSA = output_28} : state_8;
                else
                {
                    state_8.__loop_DHyvg05RoO2MDi2FiCWotK = manager_25;
                    state_8.__cp_VvoCdF51yMMOPQ1NuvHpSA = output_28;
                }

                outputs_6 = (__pad_BW3oTPIVjY2LSCjolQJAoW_9, output_28, Result_36, Result_38, Result_30, Result_32, Result_34);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var(__auto_39, __auto_40, __auto_41, __auto_42, __auto_43, __auto_44, __auto_45) = outputs_6;
            Color_Palette_Out = __auto_39;
            Color_Palette_GPU_Out = __auto_40;
            Black_Out = __auto_41;
            White_Out = __auto_42;
            Tone_Light_Out = __auto_43;
            Tone_Dark_Out = __auto_44;
            Tone_Saturated_Out = __auto_45;
            n3.FuseColors_DoTfmLFOXmxO9Gz80n2F7s that_46 = this;
            if (this.__GetContext__().IsImmutable)
                that_46 = State_Output_2 != this.__p_KN4t3Fc7z9pMZoQc8kj14u || manager_4 != this.__cache_BOseez7PwVhLmSw4MUUf9w ? new FuseColors_DoTfmLFOXmxO9Gz80n2F7s(this)
                {__p_KN4t3Fc7z9pMZoQc8kj14u = State_Output_2, __cache_BOseez7PwVhLmSw4MUUf9w = manager_4} : that_46;
            else
            {
                this.__p_KN4t3Fc7z9pMZoQc8kj14u = State_Output_2;
                this.__cache_BOseez7PwVhLmSw4MUUf9w = manager_4;
            }

            return that_46;
        }

        public n3.FuseColors_DoTfmLFOXmxO9Gz80n2F7s __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "KN4t3Fc7z9pMZoQc8kj14u", 335874U);
            var Output_1 = n23.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_0);
            n3.FuseColors_DoTfmLFOXmxO9Gz80n2F7s that_2 = this;
            this.__p_KN4t3Fc7z9pMZoQc8kj14u = Output_1;
            this.__cache_BOseez7PwVhLmSw4MUUf9w = null;
            return that_2;
        }

        public n3.FuseColors_DoTfmLFOXmxO9Gz80n2F7s __CreateDefault__()
        {
            n3.FuseColors_DoTfmLFOXmxO9Gz80n2F7s that_0 = this;
            this.__p_KN4t3Fc7z9pMZoQc8kj14u = n23.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__cache_BOseez7PwVhLmSw4MUUf9w = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_KN4t3Fc7z9pMZoQc8kj14u);
            n1.CompilationHelper.SafeDispose(this.__cache_BOseez7PwVhLmSw4MUUf9w);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 335874U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "KN4t3Fc7z9pMZoQc8kj14u", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n23.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_KN4t3Fc7z9pMZoQc8kj14u;
        [n1.ElementAttribute(TracingId = 335721U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "BOseez7PwVhLmSw4MUUf9w", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple, n2.ValueTuple<n10.Spread<n15.Color4>, n10.Spread<n5.GpuValue<n15.Vector4>>, n15.Color4, n15.Color4, n15.Color4, n15.Color4, n15.Color4>> __cache_BOseez7PwVhLmSw4MUUf9w = null;
        [n1.ElementAttribute(TracingId = 335732U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "BW3oTPIVjY2LSCjolQJAoW", Name = "__slot_BW3oTPIVjY2LSCjolQJAoW")]
        public static n10.Spread<n15.Color4> __slot_BW3oTPIVjY2LSCjolQJAoW = n1.CompilationHelper.Deserialize<n10.Spread<n15.Color4>>("<Value xmlns=\"property\">\r\n  <Item xmlns=\"\">0.07999999, 0.07999999, 0.07999999, 1</Item>\r\n  <Item xmlns=\"\">0.97, 0.9409, 0.9409, 1</Item>\r\n  <Item xmlns=\"\">0.6396001, 0.8200002, 0.7875283, 1</Item>\r\n  <Item xmlns=\"\">0.3685002, 0.6700003, 0.6700003, 1</Item>\r\n  <Item xmlns=\"\">0.9200001, 0.3606403, 0.04600042, 1</Item>\r\n</Value>", true, "NvxFK0tAsVyMwtaYRjadP2", "BW3oTPIVjY2LSCjolQJAoW");
        [n1.ElementAttribute(TracingId = 335811U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "E49D0jwyWN6MXEOG60dViX", Name = "__slot_E49D0jwyWN6MXEOG60dViX")]
        public static int __slot_E49D0jwyWN6MXEOG60dViX = 2;
        [n1.ElementAttribute(TracingId = 335809U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Knb7ggrzRFuOlAUFO4vuVU", Name = "__slot_Knb7ggrzRFuOlAUFO4vuVU")]
        public static int __slot_Knb7ggrzRFuOlAUFO4vuVU = 3;
        [n1.ElementAttribute(TracingId = 335806U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "O9AtuJRTcCBPW5VtmQDkB9", Name = "__slot_O9AtuJRTcCBPW5VtmQDkB9")]
        public static int __slot_O9AtuJRTcCBPW5VtmQDkB9 = 4;
        [n1.ElementAttribute(TracingId = 335834U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "TpIVZ1N1XGrMsFqaM6x92M", Name = "__slot_TpIVZ1N1XGrMsFqaM6x92M")]
        public static int __slot_TpIVZ1N1XGrMsFqaM6x92M = 0;
        [n1.ElementAttribute(TracingId = 335833U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "V3Bg5bHGR5dPuJLwm8gzrM", Name = "__slot_V3Bg5bHGR5dPuJLwm8gzrM")]
        public static int __slot_V3Bg5bHGR5dPuJLwm8gzrM = 1;
        static FuseColors_DoTfmLFOXmxO9Gz80n2F7s()
        {
        }

        public FuseColors_DoTfmLFOXmxO9Gz80n2F7s(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FuseColors_DoTfmLFOXmxO9Gz80n2F7s(FuseColors_DoTfmLFOXmxO9Gz80n2F7s other): base(other)
        {
            this.__p_KN4t3Fc7z9pMZoQc8kj14u = other.__p_KN4t3Fc7z9pMZoQc8kj14u;
            this.__cache_BOseez7PwVhLmSw4MUUf9w = other.__cache_BOseez7PwVhLmSw4MUUf9w;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_KN4t3Fc7z9pMZoQc8kj14u", in __p_KN4t3Fc7z9pMZoQc8kj14u), n1.CompilationHelper.GetValueOrExisting(values, "__cache_BOseez7PwVhLmSw4MUUf9w", in __cache_BOseez7PwVhLmSw4MUUf9w));
        }

        internal FuseColors_DoTfmLFOXmxO9Gz80n2F7s __WITH__(n23.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_KN4t3Fc7z9pMZoQc8kj14u, n6.Manager<n2.ValueTuple, n2.ValueTuple<n10.Spread<n15.Color4>, n10.Spread<n5.GpuValue<n15.Vector4>>, n15.Color4, n15.Color4, n15.Color4, n15.Color4, n15.Color4>> __cache_BOseez7PwVhLmSw4MUUf9w)
        {
            n3.FuseColors_DoTfmLFOXmxO9Gz80n2F7s that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_KN4t3Fc7z9pMZoQc8kj14u != this.__p_KN4t3Fc7z9pMZoQc8kj14u || __cache_BOseez7PwVhLmSw4MUUf9w != this.__cache_BOseez7PwVhLmSw4MUUf9w ? new FuseColors_DoTfmLFOXmxO9Gz80n2F7s(this)
                {__p_KN4t3Fc7z9pMZoQc8kj14u = __p_KN4t3Fc7z9pMZoQc8kj14u, __cache_BOseez7PwVhLmSw4MUUf9w = __cache_BOseez7PwVhLmSw4MUUf9w} : that_0;
            else
            {
                this.__p_KN4t3Fc7z9pMZoQc8kj14u = __p_KN4t3Fc7z9pMZoQc8kj14u;
                this.__cache_BOseez7PwVhLmSw4MUUf9w = __cache_BOseez7PwVhLmSw4MUUf9w;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "DpSVGEs6gaKMaz5SR7bVtp", Name = "__DpSVGEs6gaKMaz5SR7bVtp")]
        [n2.SerializableAttribute]
        public class __DpSVGEs6gaKMaz5SR7bVtp : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__loop_DHyvg05RoO2MDi2FiCWotK);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n27.ImmutableLifetimeManager __loop_DHyvg05RoO2MDi2FiCWotK;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<n15.Vector4>> __cp_VvoCdF51yMMOPQ1NuvHpSA;
            public __DpSVGEs6gaKMaz5SR7bVtp(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DpSVGEs6gaKMaz5SR7bVtp(__DpSVGEs6gaKMaz5SR7bVtp other): base(other)
            {
                this.__loop_DHyvg05RoO2MDi2FiCWotK = other.__loop_DHyvg05RoO2MDi2FiCWotK;
                this.__cp_VvoCdF51yMMOPQ1NuvHpSA = other.__cp_VvoCdF51yMMOPQ1NuvHpSA;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__loop_DHyvg05RoO2MDi2FiCWotK", in __loop_DHyvg05RoO2MDi2FiCWotK), n1.CompilationHelper.GetValueOrExisting(values, "__cp_VvoCdF51yMMOPQ1NuvHpSA", in __cp_VvoCdF51yMMOPQ1NuvHpSA));
            }

            internal __DpSVGEs6gaKMaz5SR7bVtp __WITH__(n27.ImmutableLifetimeManager __loop_DHyvg05RoO2MDi2FiCWotK, n10.Spread<n5.GpuValue<n15.Vector4>> __cp_VvoCdF51yMMOPQ1NuvHpSA)
            {
                __DpSVGEs6gaKMaz5SR7bVtp that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __loop_DHyvg05RoO2MDi2FiCWotK != this.__loop_DHyvg05RoO2MDi2FiCWotK || __cp_VvoCdF51yMMOPQ1NuvHpSA != this.__cp_VvoCdF51yMMOPQ1NuvHpSA ? new __DpSVGEs6gaKMaz5SR7bVtp(this)
                    {__loop_DHyvg05RoO2MDi2FiCWotK = __loop_DHyvg05RoO2MDi2FiCWotK, __cp_VvoCdF51yMMOPQ1NuvHpSA = __cp_VvoCdF51yMMOPQ1NuvHpSA} : that_0;
                else
                {
                    this.__loop_DHyvg05RoO2MDi2FiCWotK = __loop_DHyvg05RoO2MDi2FiCWotK;
                    this.__cp_VvoCdF51yMMOPQ1NuvHpSA = __cp_VvoCdF51yMMOPQ1NuvHpSA;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "DcDTwDLFzHpOmzLQGYLlLz", Name = "__DcDTwDLFzHpOmzLQGYLlLz")]
        [n2.SerializableAttribute]
        public class __DcDTwDLFzHpOmzLQGYLlLz : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_AnZlzQqM3YdMKcAS3MaK6i);
                return;
            }

            [n1.ElementAttribute(TracingId = 335743U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "AnZlzQqM3YdMKcAS3MaK6i", Name = "GPUIn (Color)", IsManaged = true, IsAutoGenerated = true)]
            public n3.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB __p_AnZlzQqM3YdMKcAS3MaK6i;
            public __DcDTwDLFzHpOmzLQGYLlLz(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DcDTwDLFzHpOmzLQGYLlLz(__DcDTwDLFzHpOmzLQGYLlLz other): base(other)
            {
                this.__p_AnZlzQqM3YdMKcAS3MaK6i = other.__p_AnZlzQqM3YdMKcAS3MaK6i;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AnZlzQqM3YdMKcAS3MaK6i", in __p_AnZlzQqM3YdMKcAS3MaK6i));
            }

            internal __DcDTwDLFzHpOmzLQGYLlLz __WITH__(n3.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB __p_AnZlzQqM3YdMKcAS3MaK6i)
            {
                __DcDTwDLFzHpOmzLQGYLlLz that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_AnZlzQqM3YdMKcAS3MaK6i != this.__p_AnZlzQqM3YdMKcAS3MaK6i ? new __DcDTwDLFzHpOmzLQGYLlLz(this)
                    {__p_AnZlzQqM3YdMKcAS3MaK6i = __p_AnZlzQqM3YdMKcAS3MaK6i} : that_0;
                else
                {
                    this.__p_AnZlzQqM3YdMKcAS3MaK6i = __p_AnZlzQqM3YdMKcAS3MaK6i;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 335987U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "JemL74uaIw9PfjincTl9az", Name = "Mix_JemL74uaIw9PfjincTl9az")]
    [n2.SerializableAttribute]
    public class Mix_JemL74uaIw9PfjincTl9az<T> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.Mix_JemL74uaIw9PfjincTl9az<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Mix_JemL74uaIw9PfjincTl9az<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Mix_JemL74uaIw9PfjincTl9az<T> CreateDefault()
        {
            var instance = new Mix_JemL74uaIw9PfjincTl9az<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Mix_JemL74uaIw9PfjincTl9az<T> Update<AdM>(n21.BlendMode BlendMode_In, n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T> Opacity_In, out n5.GpuValue<T> Output_Out)
            where AdM : struct, n28.IAdaptiveCreateDefault<n5.GpuValue<T>>
        {
            var w_0 = default(AdM);
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_Rgjbx7XqUe2M1S7Rszq2r4;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n21.BlendMode, n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_4 = (BlendMode_In, Base_In, Blend_In, Opacity_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__NcXGCYtOb5rLOrVqpOu2tc>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __NcXGCYtOb5rLOrVqpOu2tc(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "JJzXgQyXIJYN7zW2CN9ugW", 336058U);
                    var Output_9 = n3.Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T>.Create(Node_Context: Node_Context_8);
                    state_7.__p_JJzXgQyXIJYN7zW2CN9ugW = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "QR95mrKbOTPNd3gXCjnSMU", 336068U);
                    var Output_11 = n3.Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T>.Create(Node_Context: Node_Context_10);
                    state_7.__p_QR95mrKbOTPNd3gXCjnSMU = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "RU5gV4tm5jILNJZbYGxbwH", 336079U);
                    var Output_13 = n3.Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T>.Create(Node_Context: Node_Context_12);
                    state_7.__p_RU5gV4tm5jILNJZbYGxbwH = Output_13;
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "NEdZNvtITa9NHGZgWxFCZ8", 336086U);
                    var Output_15 = n3.ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T>.Create(Node_Context: Node_Context_14);
                    state_7.__p_NEdZNvtITa9NHGZgWxFCZ8 = Output_15;
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "EH28UglzbltNfwALQDksUa", 336096U);
                    var Output_17 = n3.LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T>.Create(Node_Context: Node_Context_16);
                    state_7.__p_EH28UglzbltNfwALQDksUa = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "FSxdzDoYx5RMw6xXMMAnSc", 336105U);
                    var Output_19 = n3.Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T>.Create(Node_Context: Node_Context_18);
                    state_7.__p_FSxdzDoYx5RMw6xXMMAnSc = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "FBgg9CNoCPMP8i0zWULPvo", 336120U);
                    var Output_21 = n3.Screen_UQvzl0XTkXGL7E72KAvxlT<T, T>.Create(Node_Context: Node_Context_20);
                    state_7.__p_FBgg9CNoCPMP8i0zWULPvo = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "QIsO2nDq9YDMrebYYtMZEN", 336131U);
                    var Output_23 = n3.Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T>.Create(Node_Context: Node_Context_22);
                    state_7.__p_QIsO2nDq9YDMrebYYtMZEN = Output_23;
                    n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "SVWBEQXnLaUMRWgc60lRlj", 336144U);
                    var Output_25 = n3.LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T>.Create(Node_Context: Node_Context_24);
                    state_7.__p_SVWBEQXnLaUMRWgc60lRlj = Output_25;
                    n1.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "O0nZjU0O45PPftKK4a2qaf", 336156U);
                    var Output_27 = n3.Overlay_Ji70D8smvDJLntIvDG10LK<T>.Create(Node_Context: Node_Context_26);
                    state_7.__p_O0nZjU0O45PPftKK4a2qaf = Output_27;
                    n1.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "OoEnMlMHVfQQYXz0faTpgD", 336164U);
                    var Output_29 = n3.SoftLight_T5zgZZdezrVQFrECFVrN0l<T>.Create(Node_Context: Node_Context_28);
                    state_7.__p_OoEnMlMHVfQQYXz0faTpgD = Output_29;
                    n1.NodeContext Node_Context_30 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "O83vxHgwhiiOIa6gnOqpVB", 336173U);
                    var Output_31 = n3.HardLight_Jt4xre2iyPMLL7a4kGPMZU<T>.Create(Node_Context: Node_Context_30);
                    state_7.__p_O83vxHgwhiiOIa6gnOqpVB = Output_31;
                    n1.NodeContext Node_Context_32 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "DDYQgRE0wc8PEroQi76f1W", 336179U);
                    var Output_33 = n3.VividLight_ExblW0y26zQMvVw3hWoSg4<T>.Create(Node_Context: Node_Context_32);
                    state_7.__p_DDYQgRE0wc8PEroQi76f1W = Output_33;
                    n1.NodeContext Node_Context_34 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "AasXuVr4IotOwvlDTjeIGm", 336189U);
                    var Output_35 = n3.LinearLight_RJqVLVdRrboNEDNeH6rzKs<T>.Create(Node_Context: Node_Context_34);
                    state_7.__p_AasXuVr4IotOwvlDTjeIGm = Output_35;
                    n1.NodeContext Node_Context_36 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Hu8aQYrJXKVP0r9uwtMOlx", 336198U);
                    var Output_37 = n3.PinLight_VitQnX5PEd9PYrvUkOybj6<T>.Create(Node_Context: Node_Context_36);
                    state_7.__p_Hu8aQYrJXKVP0r9uwtMOlx = Output_37;
                    n1.NodeContext Node_Context_38 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "CSs68OU0ENwPSLIGiyyMMN", 336211U);
                    var Output_39 = n3.HardMix_Qxyqn178X1tLHkEj7WLepe<T, T>.Create(Node_Context: Node_Context_38);
                    state_7.__p_CSs68OU0ENwPSLIGiyyMMN = Output_39;
                    n1.NodeContext Node_Context_40 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "BNlcfzE1d9RMnkKnFsVdzT", 336222U);
                    var Output_41 = n3.Difference_QibpMhwxUIrL1QBngAPSn2<T, T>.Create(Node_Context: Node_Context_40);
                    state_7.__p_BNlcfzE1d9RMnkKnFsVdzT = Output_41;
                    n1.NodeContext Node_Context_42 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "GvQGoAA44uGLxPaUXNBNGH", 336236U);
                    var Output_43 = n3.Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T>.Create(Node_Context: Node_Context_42);
                    state_7.__p_GvQGoAA44uGLxPaUXNBNGH = Output_43;
                    n1.NodeContext Node_Context_44 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "N4QJWzAydPcM9i5xXam82f", 336249U);
                    var Output_45 = n3.Subtract_JSohqrkBSVOPulVVpiaUHo<T, T>.Create(Node_Context: Node_Context_44);
                    state_7.__p_N4QJWzAydPcM9i5xXam82f = Output_45;
                    n1.NodeContext Node_Context_46 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "OCTuxCKeX2uQWfdrRDWRGc", 336258U);
                    var Output_47 = n3.Divide_BrawYghF0rhOkD2ZpPHh8n<T, T>.Create(Node_Context: Node_Context_46);
                    state_7.__p_OCTuxCKeX2uQWfdrRDWRGc = Output_47;
                }

                int Index_48 = (int)BlendMode_In;
                var State_Output_50 = state_7.__p_JJzXgQyXIJYN7zW2CN9ugW.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_49);
                var State_Output_52 = state_7.__p_QR95mrKbOTPNd3gXCjnSMU.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_51);
                var State_Output_54 = state_7.__p_RU5gV4tm5jILNJZbYGxbwH.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_53);
                var State_Output_56 = state_7.__p_NEdZNvtITa9NHGZgWxFCZ8.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_55);
                var State_Output_58 = state_7.__p_EH28UglzbltNfwALQDksUa.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_57);
                var State_Output_60 = state_7.__p_FSxdzDoYx5RMw6xXMMAnSc.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_59);
                var State_Output_62 = state_7.__p_FBgg9CNoCPMP8i0zWULPvo.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_61);
                var State_Output_64 = state_7.__p_QIsO2nDq9YDMrebYYtMZEN.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_63);
                var State_Output_66 = state_7.__p_SVWBEQXnLaUMRWgc60lRlj.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_65);
                var State_Output_68 = state_7.__p_O0nZjU0O45PPftKK4a2qaf.Update(BaseLayer_In: Base_In, BlendLayer_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_67);
                var State_Output_70 = state_7.__p_OoEnMlMHVfQQYXz0faTpgD.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_69);
                var State_Output_72 = state_7.__p_O83vxHgwhiiOIa6gnOqpVB.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_71);
                var State_Output_74 = state_7.__p_DDYQgRE0wc8PEroQi76f1W.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_73);
                var State_Output_76 = state_7.__p_AasXuVr4IotOwvlDTjeIGm.Update(BaseLayer_In: Base_In, BlendLayer_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_75);
                var State_Output_78 = state_7.__p_Hu8aQYrJXKVP0r9uwtMOlx.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_77);
                var State_Output_80 = state_7.__p_CSs68OU0ENwPSLIGiyyMMN.Update(BaseLayer_In: Base_In, BlendLayer_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_79);
                var State_Output_82 = state_7.__p_BNlcfzE1d9RMnkKnFsVdzT.Update(BaseLayer_In: Base_In, BlendLayer_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_81);
                var State_Output_84 = state_7.__p_GvQGoAA44uGLxPaUXNBNGH.Update(BaseLayer_In: Base_In, BlendLayer_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_83);
                var State_Output_86 = state_7.__p_N4QJWzAydPcM9i5xXam82f.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_85);
                var State_Output_88 = state_7.__p_OCTuxCKeX2uQWfdrRDWRGc.Update(Base_In: Base_In, Blend_In: Blend_In, Opacity_In: Opacity_In, Output_Out: out n5.GpuValue<T> Output_87);
                var builder_89 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co, 20);
                builder_89.Add(Output_49);
                builder_89.Add(Output_51);
                builder_89.Add(Output_53);
                builder_89.Add(Output_55);
                builder_89.Add(Output_57);
                builder_89.Add(Output_59);
                builder_89.Add(Output_61);
                builder_89.Add(Output_63);
                builder_89.Add(Output_65);
                builder_89.Add(Output_67);
                builder_89.Add(Output_69);
                builder_89.Add(Output_71);
                builder_89.Add(Output_73);
                builder_89.Add(Output_75);
                builder_89.Add(Output_77);
                builder_89.Add(Output_79);
                builder_89.Add(Output_81);
                builder_89.Add(Output_83);
                builder_89.Add(Output_85);
                builder_89.Add(Output_87);
                var __pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co_90 = builder_89.Commit();
                n23._Operations_.Switch<n5.GpuValue<T>, AdM>(Index_In: Index_48, Input_In: __pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co_90, Output_Out: out n5.GpuValue<T> Output_91);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_50 != state_7.__p_JJzXgQyXIJYN7zW2CN9ugW || State_Output_52 != state_7.__p_QR95mrKbOTPNd3gXCjnSMU || State_Output_54 != state_7.__p_RU5gV4tm5jILNJZbYGxbwH || State_Output_56 != state_7.__p_NEdZNvtITa9NHGZgWxFCZ8 || State_Output_58 != state_7.__p_EH28UglzbltNfwALQDksUa || State_Output_60 != state_7.__p_FSxdzDoYx5RMw6xXMMAnSc || State_Output_62 != state_7.__p_FBgg9CNoCPMP8i0zWULPvo || State_Output_64 != state_7.__p_QIsO2nDq9YDMrebYYtMZEN || State_Output_66 != state_7.__p_SVWBEQXnLaUMRWgc60lRlj || State_Output_68 != state_7.__p_O0nZjU0O45PPftKK4a2qaf || State_Output_70 != state_7.__p_OoEnMlMHVfQQYXz0faTpgD || State_Output_72 != state_7.__p_O83vxHgwhiiOIa6gnOqpVB || State_Output_74 != state_7.__p_DDYQgRE0wc8PEroQi76f1W || State_Output_76 != state_7.__p_AasXuVr4IotOwvlDTjeIGm || State_Output_78 != state_7.__p_Hu8aQYrJXKVP0r9uwtMOlx || State_Output_80 != state_7.__p_CSs68OU0ENwPSLIGiyyMMN || State_Output_82 != state_7.__p_BNlcfzE1d9RMnkKnFsVdzT || State_Output_84 != state_7.__p_GvQGoAA44uGLxPaUXNBNGH || State_Output_86 != state_7.__p_N4QJWzAydPcM9i5xXam82f || State_Output_88 != state_7.__p_OCTuxCKeX2uQWfdrRDWRGc || __pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co_90 != state_7.__pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co ? new __NcXGCYtOb5rLOrVqpOu2tc(state_7)
                    {__p_JJzXgQyXIJYN7zW2CN9ugW = State_Output_50, __p_QR95mrKbOTPNd3gXCjnSMU = State_Output_52, __p_RU5gV4tm5jILNJZbYGxbwH = State_Output_54, __p_NEdZNvtITa9NHGZgWxFCZ8 = State_Output_56, __p_EH28UglzbltNfwALQDksUa = State_Output_58, __p_FSxdzDoYx5RMw6xXMMAnSc = State_Output_60, __p_FBgg9CNoCPMP8i0zWULPvo = State_Output_62, __p_QIsO2nDq9YDMrebYYtMZEN = State_Output_64, __p_SVWBEQXnLaUMRWgc60lRlj = State_Output_66, __p_O0nZjU0O45PPftKK4a2qaf = State_Output_68, __p_OoEnMlMHVfQQYXz0faTpgD = State_Output_70, __p_O83vxHgwhiiOIa6gnOqpVB = State_Output_72, __p_DDYQgRE0wc8PEroQi76f1W = State_Output_74, __p_AasXuVr4IotOwvlDTjeIGm = State_Output_76, __p_Hu8aQYrJXKVP0r9uwtMOlx = State_Output_78, __p_CSs68OU0ENwPSLIGiyyMMN = State_Output_80, __p_BNlcfzE1d9RMnkKnFsVdzT = State_Output_82, __p_GvQGoAA44uGLxPaUXNBNGH = State_Output_84, __p_N4QJWzAydPcM9i5xXam82f = State_Output_86, __p_OCTuxCKeX2uQWfdrRDWRGc = State_Output_88, __pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co = __pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co_90} : state_7;
                else
                {
                    state_7.__p_JJzXgQyXIJYN7zW2CN9ugW = State_Output_50;
                    state_7.__p_QR95mrKbOTPNd3gXCjnSMU = State_Output_52;
                    state_7.__p_RU5gV4tm5jILNJZbYGxbwH = State_Output_54;
                    state_7.__p_NEdZNvtITa9NHGZgWxFCZ8 = State_Output_56;
                    state_7.__p_EH28UglzbltNfwALQDksUa = State_Output_58;
                    state_7.__p_FSxdzDoYx5RMw6xXMMAnSc = State_Output_60;
                    state_7.__p_FBgg9CNoCPMP8i0zWULPvo = State_Output_62;
                    state_7.__p_QIsO2nDq9YDMrebYYtMZEN = State_Output_64;
                    state_7.__p_SVWBEQXnLaUMRWgc60lRlj = State_Output_66;
                    state_7.__p_O0nZjU0O45PPftKK4a2qaf = State_Output_68;
                    state_7.__p_OoEnMlMHVfQQYXz0faTpgD = State_Output_70;
                    state_7.__p_O83vxHgwhiiOIa6gnOqpVB = State_Output_72;
                    state_7.__p_DDYQgRE0wc8PEroQi76f1W = State_Output_74;
                    state_7.__p_AasXuVr4IotOwvlDTjeIGm = State_Output_76;
                    state_7.__p_Hu8aQYrJXKVP0r9uwtMOlx = State_Output_78;
                    state_7.__p_CSs68OU0ENwPSLIGiyyMMN = State_Output_80;
                    state_7.__p_BNlcfzE1d9RMnkKnFsVdzT = State_Output_82;
                    state_7.__p_GvQGoAA44uGLxPaUXNBNGH = State_Output_84;
                    state_7.__p_N4QJWzAydPcM9i5xXam82f = State_Output_86;
                    state_7.__p_OCTuxCKeX2uQWfdrRDWRGc = State_Output_88;
                    state_7.__pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co = __pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co_90;
                }

                outputs_5 = n2.ValueTuple.Create(Output_91);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_92 = outputs_5.Item1;
            Output_Out = __auto_92;
            n3.Mix_JemL74uaIw9PfjincTl9az<T> that_93 = this;
            if (this.__GetContext__().IsImmutable)
                that_93 = manager_3 != this.__cache_Rgjbx7XqUe2M1S7Rszq2r4 ? new Mix_JemL74uaIw9PfjincTl9az<T>(this)
                {__cache_Rgjbx7XqUe2M1S7Rszq2r4 = manager_3} : that_93;
            else
            {
                this.__cache_Rgjbx7XqUe2M1S7Rszq2r4 = manager_3;
            }

            return that_93;
        }

        public n3.Mix_JemL74uaIw9PfjincTl9az<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Mix_JemL74uaIw9PfjincTl9az<T> that_0 = this;
            this.__cache_Rgjbx7XqUe2M1S7Rszq2r4 = null;
            return that_0;
        }

        public n3.Mix_JemL74uaIw9PfjincTl9az<T> __CreateDefault__()
        {
            n3.Mix_JemL74uaIw9PfjincTl9az<T> that_0 = this;
            this.__cache_Rgjbx7XqUe2M1S7Rszq2r4 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_Rgjbx7XqUe2M1S7Rszq2r4);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 335991U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Rgjbx7XqUe2M1S7Rszq2r4", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n21.BlendMode, n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_Rgjbx7XqUe2M1S7Rszq2r4 = null;
        public Mix_JemL74uaIw9PfjincTl9az(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Mix_JemL74uaIw9PfjincTl9az(Mix_JemL74uaIw9PfjincTl9az<T> other): base(other)
        {
            this.__cache_Rgjbx7XqUe2M1S7Rszq2r4 = other.__cache_Rgjbx7XqUe2M1S7Rszq2r4;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Rgjbx7XqUe2M1S7Rszq2r4", in __cache_Rgjbx7XqUe2M1S7Rszq2r4));
        }

        internal Mix_JemL74uaIw9PfjincTl9az<T> __WITH__(n6.Manager<n2.ValueTuple<n21.BlendMode, n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_Rgjbx7XqUe2M1S7Rszq2r4)
        {
            n3.Mix_JemL74uaIw9PfjincTl9az<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Rgjbx7XqUe2M1S7Rszq2r4 != this.__cache_Rgjbx7XqUe2M1S7Rszq2r4 ? new Mix_JemL74uaIw9PfjincTl9az<T>(this)
                {__cache_Rgjbx7XqUe2M1S7Rszq2r4 = __cache_Rgjbx7XqUe2M1S7Rszq2r4} : that_0;
            else
            {
                this.__cache_Rgjbx7XqUe2M1S7Rszq2r4 = __cache_Rgjbx7XqUe2M1S7Rszq2r4;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "NcXGCYtOb5rLOrVqpOu2tc", Name = "__NcXGCYtOb5rLOrVqpOu2tc")]
        [n2.SerializableAttribute]
        public class __NcXGCYtOb5rLOrVqpOu2tc : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_JJzXgQyXIJYN7zW2CN9ugW);
                n1.CompilationHelper.SafeDispose(this.__p_QR95mrKbOTPNd3gXCjnSMU);
                n1.CompilationHelper.SafeDispose(this.__p_RU5gV4tm5jILNJZbYGxbwH);
                n1.CompilationHelper.SafeDispose(this.__p_NEdZNvtITa9NHGZgWxFCZ8);
                n1.CompilationHelper.SafeDispose(this.__p_EH28UglzbltNfwALQDksUa);
                n1.CompilationHelper.SafeDispose(this.__p_FSxdzDoYx5RMw6xXMMAnSc);
                n1.CompilationHelper.SafeDispose(this.__p_FBgg9CNoCPMP8i0zWULPvo);
                n1.CompilationHelper.SafeDispose(this.__p_QIsO2nDq9YDMrebYYtMZEN);
                n1.CompilationHelper.SafeDispose(this.__p_SVWBEQXnLaUMRWgc60lRlj);
                n1.CompilationHelper.SafeDispose(this.__p_O0nZjU0O45PPftKK4a2qaf);
                n1.CompilationHelper.SafeDispose(this.__p_OoEnMlMHVfQQYXz0faTpgD);
                n1.CompilationHelper.SafeDispose(this.__p_O83vxHgwhiiOIa6gnOqpVB);
                n1.CompilationHelper.SafeDispose(this.__p_DDYQgRE0wc8PEroQi76f1W);
                n1.CompilationHelper.SafeDispose(this.__p_AasXuVr4IotOwvlDTjeIGm);
                n1.CompilationHelper.SafeDispose(this.__p_Hu8aQYrJXKVP0r9uwtMOlx);
                n1.CompilationHelper.SafeDispose(this.__p_CSs68OU0ENwPSLIGiyyMMN);
                n1.CompilationHelper.SafeDispose(this.__p_BNlcfzE1d9RMnkKnFsVdzT);
                n1.CompilationHelper.SafeDispose(this.__p_GvQGoAA44uGLxPaUXNBNGH);
                n1.CompilationHelper.SafeDispose(this.__p_N4QJWzAydPcM9i5xXam82f);
                n1.CompilationHelper.SafeDispose(this.__p_OCTuxCKeX2uQWfdrRDWRGc);
                return;
            }

            [n1.ElementAttribute(TracingId = 336058U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "JJzXgQyXIJYN7zW2CN9ugW", Name = "Normal", IsManaged = true, IsAutoGenerated = true)]
            public n3.Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T> __p_JJzXgQyXIJYN7zW2CN9ugW;
            [n1.ElementAttribute(TracingId = 336068U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "QR95mrKbOTPNd3gXCjnSMU", Name = "Darken", IsManaged = true, IsAutoGenerated = true)]
            public n3.Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T> __p_QR95mrKbOTPNd3gXCjnSMU;
            [n1.ElementAttribute(TracingId = 336079U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "RU5gV4tm5jILNJZbYGxbwH", Name = "Multipy", IsManaged = true, IsAutoGenerated = true)]
            public n3.Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T> __p_RU5gV4tm5jILNJZbYGxbwH;
            [n1.ElementAttribute(TracingId = 336086U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "NEdZNvtITa9NHGZgWxFCZ8", Name = "ColorBurn", IsManaged = true, IsAutoGenerated = true)]
            public n3.ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T> __p_NEdZNvtITa9NHGZgWxFCZ8;
            [n1.ElementAttribute(TracingId = 336096U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "EH28UglzbltNfwALQDksUa", Name = "LinearBurn", IsManaged = true, IsAutoGenerated = true)]
            public n3.LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T> __p_EH28UglzbltNfwALQDksUa;
            [n1.ElementAttribute(TracingId = 336105U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "FSxdzDoYx5RMw6xXMMAnSc", Name = "Lighten", IsManaged = true, IsAutoGenerated = true)]
            public n3.Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T> __p_FSxdzDoYx5RMw6xXMMAnSc;
            [n1.ElementAttribute(TracingId = 336120U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "FBgg9CNoCPMP8i0zWULPvo", Name = "Screen", IsManaged = true, IsAutoGenerated = true)]
            public n3.Screen_UQvzl0XTkXGL7E72KAvxlT<T, T> __p_FBgg9CNoCPMP8i0zWULPvo;
            [n1.ElementAttribute(TracingId = 336131U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "QIsO2nDq9YDMrebYYtMZEN", Name = "Dodge", IsManaged = true, IsAutoGenerated = true)]
            public n3.Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T> __p_QIsO2nDq9YDMrebYYtMZEN;
            [n1.ElementAttribute(TracingId = 336144U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "SVWBEQXnLaUMRWgc60lRlj", Name = "LinearDodge", IsManaged = true, IsAutoGenerated = true)]
            public n3.LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T> __p_SVWBEQXnLaUMRWgc60lRlj;
            [n1.ElementAttribute(TracingId = 336156U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "O0nZjU0O45PPftKK4a2qaf", Name = "Overlay", IsManaged = true, IsAutoGenerated = true)]
            public n3.Overlay_Ji70D8smvDJLntIvDG10LK<T> __p_O0nZjU0O45PPftKK4a2qaf;
            [n1.ElementAttribute(TracingId = 336164U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "OoEnMlMHVfQQYXz0faTpgD", Name = "SoftLight", IsManaged = true, IsAutoGenerated = true)]
            public n3.SoftLight_T5zgZZdezrVQFrECFVrN0l<T> __p_OoEnMlMHVfQQYXz0faTpgD;
            [n1.ElementAttribute(TracingId = 336173U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "O83vxHgwhiiOIa6gnOqpVB", Name = "HardLight", IsManaged = true, IsAutoGenerated = true)]
            public n3.HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> __p_O83vxHgwhiiOIa6gnOqpVB;
            [n1.ElementAttribute(TracingId = 336179U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "DDYQgRE0wc8PEroQi76f1W", Name = "VividLight", IsManaged = true, IsAutoGenerated = true)]
            public n3.VividLight_ExblW0y26zQMvVw3hWoSg4<T> __p_DDYQgRE0wc8PEroQi76f1W;
            [n1.ElementAttribute(TracingId = 336189U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "AasXuVr4IotOwvlDTjeIGm", Name = "LinearLight", IsManaged = true, IsAutoGenerated = true)]
            public n3.LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> __p_AasXuVr4IotOwvlDTjeIGm;
            [n1.ElementAttribute(TracingId = 336198U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Hu8aQYrJXKVP0r9uwtMOlx", Name = "PinLight", IsManaged = true, IsAutoGenerated = true)]
            public n3.PinLight_VitQnX5PEd9PYrvUkOybj6<T> __p_Hu8aQYrJXKVP0r9uwtMOlx;
            [n1.ElementAttribute(TracingId = 336211U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "CSs68OU0ENwPSLIGiyyMMN", Name = "HardMix", IsManaged = true, IsAutoGenerated = true)]
            public n3.HardMix_Qxyqn178X1tLHkEj7WLepe<T, T> __p_CSs68OU0ENwPSLIGiyyMMN;
            [n1.ElementAttribute(TracingId = 336222U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "BNlcfzE1d9RMnkKnFsVdzT", Name = "Difference", IsManaged = true, IsAutoGenerated = true)]
            public n3.Difference_QibpMhwxUIrL1QBngAPSn2<T, T> __p_BNlcfzE1d9RMnkKnFsVdzT;
            [n1.ElementAttribute(TracingId = 336236U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "GvQGoAA44uGLxPaUXNBNGH", Name = "Exclusion", IsManaged = true, IsAutoGenerated = true)]
            public n3.Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T> __p_GvQGoAA44uGLxPaUXNBNGH;
            [n1.ElementAttribute(TracingId = 336249U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "N4QJWzAydPcM9i5xXam82f", Name = "Subtract", IsManaged = true, IsAutoGenerated = true)]
            public n3.Subtract_JSohqrkBSVOPulVVpiaUHo<T, T> __p_N4QJWzAydPcM9i5xXam82f;
            [n1.ElementAttribute(TracingId = 336258U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "OCTuxCKeX2uQWfdrRDWRGc", Name = "Divide", IsManaged = true, IsAutoGenerated = true)]
            public n3.Divide_BrawYghF0rhOkD2ZpPHh8n<T, T> __p_OCTuxCKeX2uQWfdrRDWRGc;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co = default(n10.Spread<n5.GpuValue<T>>);
            public __NcXGCYtOb5rLOrVqpOu2tc(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __NcXGCYtOb5rLOrVqpOu2tc(__NcXGCYtOb5rLOrVqpOu2tc other): base(other)
            {
                this.__p_JJzXgQyXIJYN7zW2CN9ugW = other.__p_JJzXgQyXIJYN7zW2CN9ugW;
                this.__p_QR95mrKbOTPNd3gXCjnSMU = other.__p_QR95mrKbOTPNd3gXCjnSMU;
                this.__p_RU5gV4tm5jILNJZbYGxbwH = other.__p_RU5gV4tm5jILNJZbYGxbwH;
                this.__p_NEdZNvtITa9NHGZgWxFCZ8 = other.__p_NEdZNvtITa9NHGZgWxFCZ8;
                this.__p_EH28UglzbltNfwALQDksUa = other.__p_EH28UglzbltNfwALQDksUa;
                this.__p_FSxdzDoYx5RMw6xXMMAnSc = other.__p_FSxdzDoYx5RMw6xXMMAnSc;
                this.__p_FBgg9CNoCPMP8i0zWULPvo = other.__p_FBgg9CNoCPMP8i0zWULPvo;
                this.__p_QIsO2nDq9YDMrebYYtMZEN = other.__p_QIsO2nDq9YDMrebYYtMZEN;
                this.__p_SVWBEQXnLaUMRWgc60lRlj = other.__p_SVWBEQXnLaUMRWgc60lRlj;
                this.__p_O0nZjU0O45PPftKK4a2qaf = other.__p_O0nZjU0O45PPftKK4a2qaf;
                this.__p_OoEnMlMHVfQQYXz0faTpgD = other.__p_OoEnMlMHVfQQYXz0faTpgD;
                this.__p_O83vxHgwhiiOIa6gnOqpVB = other.__p_O83vxHgwhiiOIa6gnOqpVB;
                this.__p_DDYQgRE0wc8PEroQi76f1W = other.__p_DDYQgRE0wc8PEroQi76f1W;
                this.__p_AasXuVr4IotOwvlDTjeIGm = other.__p_AasXuVr4IotOwvlDTjeIGm;
                this.__p_Hu8aQYrJXKVP0r9uwtMOlx = other.__p_Hu8aQYrJXKVP0r9uwtMOlx;
                this.__p_CSs68OU0ENwPSLIGiyyMMN = other.__p_CSs68OU0ENwPSLIGiyyMMN;
                this.__p_BNlcfzE1d9RMnkKnFsVdzT = other.__p_BNlcfzE1d9RMnkKnFsVdzT;
                this.__p_GvQGoAA44uGLxPaUXNBNGH = other.__p_GvQGoAA44uGLxPaUXNBNGH;
                this.__p_N4QJWzAydPcM9i5xXam82f = other.__p_N4QJWzAydPcM9i5xXam82f;
                this.__p_OCTuxCKeX2uQWfdrRDWRGc = other.__p_OCTuxCKeX2uQWfdrRDWRGc;
                this.__pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co = other.__pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JJzXgQyXIJYN7zW2CN9ugW", in __p_JJzXgQyXIJYN7zW2CN9ugW), n1.CompilationHelper.GetValueOrExisting(values, "__p_QR95mrKbOTPNd3gXCjnSMU", in __p_QR95mrKbOTPNd3gXCjnSMU), n1.CompilationHelper.GetValueOrExisting(values, "__p_RU5gV4tm5jILNJZbYGxbwH", in __p_RU5gV4tm5jILNJZbYGxbwH), n1.CompilationHelper.GetValueOrExisting(values, "__p_NEdZNvtITa9NHGZgWxFCZ8", in __p_NEdZNvtITa9NHGZgWxFCZ8), n1.CompilationHelper.GetValueOrExisting(values, "__p_EH28UglzbltNfwALQDksUa", in __p_EH28UglzbltNfwALQDksUa), n1.CompilationHelper.GetValueOrExisting(values, "__p_FSxdzDoYx5RMw6xXMMAnSc", in __p_FSxdzDoYx5RMw6xXMMAnSc), n1.CompilationHelper.GetValueOrExisting(values, "__p_FBgg9CNoCPMP8i0zWULPvo", in __p_FBgg9CNoCPMP8i0zWULPvo), n1.CompilationHelper.GetValueOrExisting(values, "__p_QIsO2nDq9YDMrebYYtMZEN", in __p_QIsO2nDq9YDMrebYYtMZEN), n1.CompilationHelper.GetValueOrExisting(values, "__p_SVWBEQXnLaUMRWgc60lRlj", in __p_SVWBEQXnLaUMRWgc60lRlj), n1.CompilationHelper.GetValueOrExisting(values, "__p_O0nZjU0O45PPftKK4a2qaf", in __p_O0nZjU0O45PPftKK4a2qaf), n1.CompilationHelper.GetValueOrExisting(values, "__p_OoEnMlMHVfQQYXz0faTpgD", in __p_OoEnMlMHVfQQYXz0faTpgD), n1.CompilationHelper.GetValueOrExisting(values, "__p_O83vxHgwhiiOIa6gnOqpVB", in __p_O83vxHgwhiiOIa6gnOqpVB), n1.CompilationHelper.GetValueOrExisting(values, "__p_DDYQgRE0wc8PEroQi76f1W", in __p_DDYQgRE0wc8PEroQi76f1W), n1.CompilationHelper.GetValueOrExisting(values, "__p_AasXuVr4IotOwvlDTjeIGm", in __p_AasXuVr4IotOwvlDTjeIGm), n1.CompilationHelper.GetValueOrExisting(values, "__p_Hu8aQYrJXKVP0r9uwtMOlx", in __p_Hu8aQYrJXKVP0r9uwtMOlx), n1.CompilationHelper.GetValueOrExisting(values, "__p_CSs68OU0ENwPSLIGiyyMMN", in __p_CSs68OU0ENwPSLIGiyyMMN), n1.CompilationHelper.GetValueOrExisting(values, "__p_BNlcfzE1d9RMnkKnFsVdzT", in __p_BNlcfzE1d9RMnkKnFsVdzT), n1.CompilationHelper.GetValueOrExisting(values, "__p_GvQGoAA44uGLxPaUXNBNGH", in __p_GvQGoAA44uGLxPaUXNBNGH), n1.CompilationHelper.GetValueOrExisting(values, "__p_N4QJWzAydPcM9i5xXam82f", in __p_N4QJWzAydPcM9i5xXam82f), n1.CompilationHelper.GetValueOrExisting(values, "__p_OCTuxCKeX2uQWfdrRDWRGc", in __p_OCTuxCKeX2uQWfdrRDWRGc), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co", in __pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co));
            }

            internal __NcXGCYtOb5rLOrVqpOu2tc __WITH__(n3.Normal_JFmRjc3PnYkNV4gZGl08Gc<T, T> __p_JJzXgQyXIJYN7zW2CN9ugW, n3.Darken_VfUM9dOuuGOMAPnDTrCo6p<T, T> __p_QR95mrKbOTPNd3gXCjnSMU, n3.Multipy_SUVMbEi1o9tM6P0EEqsAPd<T, T> __p_RU5gV4tm5jILNJZbYGxbwH, n3.ColorBurn_JkZWIhU7KgdOEKbMmjKIQ0<T, T> __p_NEdZNvtITa9NHGZgWxFCZ8, n3.LinearBurn_KXG0klNgEdCLen8IPncMS3<T, T> __p_EH28UglzbltNfwALQDksUa, n3.Lighten_LjYudzEB8VtL7ZAw5Obxbi<T, T> __p_FSxdzDoYx5RMw6xXMMAnSc, n3.Screen_UQvzl0XTkXGL7E72KAvxlT<T, T> __p_FBgg9CNoCPMP8i0zWULPvo, n3.Dodge_V2pGtZYuxWBQdZxLEyWpss<T, T> __p_QIsO2nDq9YDMrebYYtMZEN, n3.LinearDodge_CMt7RBKli4ePbCNnsvD5yN<T, T> __p_SVWBEQXnLaUMRWgc60lRlj, n3.Overlay_Ji70D8smvDJLntIvDG10LK<T> __p_O0nZjU0O45PPftKK4a2qaf, n3.SoftLight_T5zgZZdezrVQFrECFVrN0l<T> __p_OoEnMlMHVfQQYXz0faTpgD, n3.HardLight_Jt4xre2iyPMLL7a4kGPMZU<T> __p_O83vxHgwhiiOIa6gnOqpVB, n3.VividLight_ExblW0y26zQMvVw3hWoSg4<T> __p_DDYQgRE0wc8PEroQi76f1W, n3.LinearLight_RJqVLVdRrboNEDNeH6rzKs<T> __p_AasXuVr4IotOwvlDTjeIGm, n3.PinLight_VitQnX5PEd9PYrvUkOybj6<T> __p_Hu8aQYrJXKVP0r9uwtMOlx, n3.HardMix_Qxyqn178X1tLHkEj7WLepe<T, T> __p_CSs68OU0ENwPSLIGiyyMMN, n3.Difference_QibpMhwxUIrL1QBngAPSn2<T, T> __p_BNlcfzE1d9RMnkKnFsVdzT, n3.Exclusion_A3RP6VBmL09MZrtpId6bZk<T, T> __p_GvQGoAA44uGLxPaUXNBNGH, n3.Subtract_JSohqrkBSVOPulVVpiaUHo<T, T> __p_N4QJWzAydPcM9i5xXam82f, n3.Divide_BrawYghF0rhOkD2ZpPHh8n<T, T> __p_OCTuxCKeX2uQWfdrRDWRGc, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co)
            {
                __NcXGCYtOb5rLOrVqpOu2tc that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_JJzXgQyXIJYN7zW2CN9ugW != this.__p_JJzXgQyXIJYN7zW2CN9ugW || __p_QR95mrKbOTPNd3gXCjnSMU != this.__p_QR95mrKbOTPNd3gXCjnSMU || __p_RU5gV4tm5jILNJZbYGxbwH != this.__p_RU5gV4tm5jILNJZbYGxbwH || __p_NEdZNvtITa9NHGZgWxFCZ8 != this.__p_NEdZNvtITa9NHGZgWxFCZ8 || __p_EH28UglzbltNfwALQDksUa != this.__p_EH28UglzbltNfwALQDksUa || __p_FSxdzDoYx5RMw6xXMMAnSc != this.__p_FSxdzDoYx5RMw6xXMMAnSc || __p_FBgg9CNoCPMP8i0zWULPvo != this.__p_FBgg9CNoCPMP8i0zWULPvo || __p_QIsO2nDq9YDMrebYYtMZEN != this.__p_QIsO2nDq9YDMrebYYtMZEN || __p_SVWBEQXnLaUMRWgc60lRlj != this.__p_SVWBEQXnLaUMRWgc60lRlj || __p_O0nZjU0O45PPftKK4a2qaf != this.__p_O0nZjU0O45PPftKK4a2qaf || __p_OoEnMlMHVfQQYXz0faTpgD != this.__p_OoEnMlMHVfQQYXz0faTpgD || __p_O83vxHgwhiiOIa6gnOqpVB != this.__p_O83vxHgwhiiOIa6gnOqpVB || __p_DDYQgRE0wc8PEroQi76f1W != this.__p_DDYQgRE0wc8PEroQi76f1W || __p_AasXuVr4IotOwvlDTjeIGm != this.__p_AasXuVr4IotOwvlDTjeIGm || __p_Hu8aQYrJXKVP0r9uwtMOlx != this.__p_Hu8aQYrJXKVP0r9uwtMOlx || __p_CSs68OU0ENwPSLIGiyyMMN != this.__p_CSs68OU0ENwPSLIGiyyMMN || __p_BNlcfzE1d9RMnkKnFsVdzT != this.__p_BNlcfzE1d9RMnkKnFsVdzT || __p_GvQGoAA44uGLxPaUXNBNGH != this.__p_GvQGoAA44uGLxPaUXNBNGH || __p_N4QJWzAydPcM9i5xXam82f != this.__p_N4QJWzAydPcM9i5xXam82f || __p_OCTuxCKeX2uQWfdrRDWRGc != this.__p_OCTuxCKeX2uQWfdrRDWRGc || __pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co != this.__pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co ? new __NcXGCYtOb5rLOrVqpOu2tc(this)
                    {__p_JJzXgQyXIJYN7zW2CN9ugW = __p_JJzXgQyXIJYN7zW2CN9ugW, __p_QR95mrKbOTPNd3gXCjnSMU = __p_QR95mrKbOTPNd3gXCjnSMU, __p_RU5gV4tm5jILNJZbYGxbwH = __p_RU5gV4tm5jILNJZbYGxbwH, __p_NEdZNvtITa9NHGZgWxFCZ8 = __p_NEdZNvtITa9NHGZgWxFCZ8, __p_EH28UglzbltNfwALQDksUa = __p_EH28UglzbltNfwALQDksUa, __p_FSxdzDoYx5RMw6xXMMAnSc = __p_FSxdzDoYx5RMw6xXMMAnSc, __p_FBgg9CNoCPMP8i0zWULPvo = __p_FBgg9CNoCPMP8i0zWULPvo, __p_QIsO2nDq9YDMrebYYtMZEN = __p_QIsO2nDq9YDMrebYYtMZEN, __p_SVWBEQXnLaUMRWgc60lRlj = __p_SVWBEQXnLaUMRWgc60lRlj, __p_O0nZjU0O45PPftKK4a2qaf = __p_O0nZjU0O45PPftKK4a2qaf, __p_OoEnMlMHVfQQYXz0faTpgD = __p_OoEnMlMHVfQQYXz0faTpgD, __p_O83vxHgwhiiOIa6gnOqpVB = __p_O83vxHgwhiiOIa6gnOqpVB, __p_DDYQgRE0wc8PEroQi76f1W = __p_DDYQgRE0wc8PEroQi76f1W, __p_AasXuVr4IotOwvlDTjeIGm = __p_AasXuVr4IotOwvlDTjeIGm, __p_Hu8aQYrJXKVP0r9uwtMOlx = __p_Hu8aQYrJXKVP0r9uwtMOlx, __p_CSs68OU0ENwPSLIGiyyMMN = __p_CSs68OU0ENwPSLIGiyyMMN, __p_BNlcfzE1d9RMnkKnFsVdzT = __p_BNlcfzE1d9RMnkKnFsVdzT, __p_GvQGoAA44uGLxPaUXNBNGH = __p_GvQGoAA44uGLxPaUXNBNGH, __p_N4QJWzAydPcM9i5xXam82f = __p_N4QJWzAydPcM9i5xXam82f, __p_OCTuxCKeX2uQWfdrRDWRGc = __p_OCTuxCKeX2uQWfdrRDWRGc, __pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co = __pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co} : that_0;
                else
                {
                    this.__p_JJzXgQyXIJYN7zW2CN9ugW = __p_JJzXgQyXIJYN7zW2CN9ugW;
                    this.__p_QR95mrKbOTPNd3gXCjnSMU = __p_QR95mrKbOTPNd3gXCjnSMU;
                    this.__p_RU5gV4tm5jILNJZbYGxbwH = __p_RU5gV4tm5jILNJZbYGxbwH;
                    this.__p_NEdZNvtITa9NHGZgWxFCZ8 = __p_NEdZNvtITa9NHGZgWxFCZ8;
                    this.__p_EH28UglzbltNfwALQDksUa = __p_EH28UglzbltNfwALQDksUa;
                    this.__p_FSxdzDoYx5RMw6xXMMAnSc = __p_FSxdzDoYx5RMw6xXMMAnSc;
                    this.__p_FBgg9CNoCPMP8i0zWULPvo = __p_FBgg9CNoCPMP8i0zWULPvo;
                    this.__p_QIsO2nDq9YDMrebYYtMZEN = __p_QIsO2nDq9YDMrebYYtMZEN;
                    this.__p_SVWBEQXnLaUMRWgc60lRlj = __p_SVWBEQXnLaUMRWgc60lRlj;
                    this.__p_O0nZjU0O45PPftKK4a2qaf = __p_O0nZjU0O45PPftKK4a2qaf;
                    this.__p_OoEnMlMHVfQQYXz0faTpgD = __p_OoEnMlMHVfQQYXz0faTpgD;
                    this.__p_O83vxHgwhiiOIa6gnOqpVB = __p_O83vxHgwhiiOIa6gnOqpVB;
                    this.__p_DDYQgRE0wc8PEroQi76f1W = __p_DDYQgRE0wc8PEroQi76f1W;
                    this.__p_AasXuVr4IotOwvlDTjeIGm = __p_AasXuVr4IotOwvlDTjeIGm;
                    this.__p_Hu8aQYrJXKVP0r9uwtMOlx = __p_Hu8aQYrJXKVP0r9uwtMOlx;
                    this.__p_CSs68OU0ENwPSLIGiyyMMN = __p_CSs68OU0ENwPSLIGiyyMMN;
                    this.__p_BNlcfzE1d9RMnkKnFsVdzT = __p_BNlcfzE1d9RMnkKnFsVdzT;
                    this.__p_GvQGoAA44uGLxPaUXNBNGH = __p_GvQGoAA44uGLxPaUXNBNGH;
                    this.__p_N4QJWzAydPcM9i5xXam82f = __p_N4QJWzAydPcM9i5xXam82f;
                    this.__p_OCTuxCKeX2uQWfdrRDWRGc = __p_OCTuxCKeX2uQWfdrRDWRGc;
                    this.__pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co = __pin_group_Input_In_DVnOAJSSgaOOwmFZqqH6Co;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 336577U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Irt0YFriJdfL2EJnYYiPxv", Name = "Fuse_Core_ColorApplication_Irt0YFriJdfL2EJnYYiPxv")]
    [n2.SerializableAttribute]
    public class Fuse_Core_ColorApplication_Irt0YFriJdfL2EJnYYiPxv : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Fuse_Core_ColorApplication_Irt0YFriJdfL2EJnYYiPxv Create(n1.NodeContext Node_Context)
        {
            var instance = new Fuse_Core_ColorApplication_Irt0YFriJdfL2EJnYYiPxv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Fuse_Core_ColorApplication_Irt0YFriJdfL2EJnYYiPxv CreateDefault()
        {
            var instance = new Fuse_Core_ColorApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Fuse_Core_ColorApplication_Irt0YFriJdfL2EJnYYiPxv Update()
        {
            return this;
        }

        public n3.Fuse_Core_ColorApplication_Irt0YFriJdfL2EJnYYiPxv __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.Fuse_Core_ColorApplication_Irt0YFriJdfL2EJnYYiPxv __CreateDefault__()
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

        public Fuse_Core_ColorApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Fuse_Core_ColorApplication_Irt0YFriJdfL2EJnYYiPxv(Fuse_Core_ColorApplication_Irt0YFriJdfL2EJnYYiPxv other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal Fuse_Core_ColorApplication_Irt0YFriJdfL2EJnYYiPxv __WITH__()
        {
            return this;
        }
    }
}

namespace _Fuse_Core_Color_.Fuse.Core.Color.Internal
{
    [n1.ElementAttribute(TracingId = 335230U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "EqZ3kz9zj7VL8O6frLV5UD", Name = "BlendMode_EqZ3kz9zj7VL8O6frLV5UD")]
    [n2.SerializableAttribute]
    public class BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> CreateDefault()
        {
            var instance = new BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> Update(n5.GpuValue<T> Base_In, n5.GpuValue<T> Blend_In, n5.GpuValue<T> Opacity_In, string Name_In, string The_Code_Template_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_PmmDKOfaIoWLWwVotsaaON;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Base_In, Blend_In, Opacity_In, Name_In, The_Code_Template_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__QxRScwFUDjLNXVB8ktKkYl>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __QxRScwFUDjLNXVB8ktKkYl(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "N8iOGX0aakUPeB4wB7xDnj", 335279U);
                    var Output_8 = n16.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>>.Create(Node_Context: Node_Context_7);
                    state_6.__p_N8iOGX0aakUPeB4wB7xDnj = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "KOLAMKFKedGQGRb8MXsXxc", 335299U);
                    var Output_10 = n29.CheckDefault_GpuValue_PdsuywpUtM6PfMHKiPiuYX<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_KOLAMKFKedGQGRb8MXsXxc = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("NvxFK0tAsVyMwtaYRjadP2", "Bg4oMy4pd9RMPfq2tw3sIi", 335311U);
                    var Output_12 = n9.HALF_Ul2Y1lSFl6WN0sQ1DLnAcN<T>.Create(Node_Context: Node_Context_11);
                    state_6.__p_Bg4oMy4pd9RMPfq2tw3sIi = Output_12;
                }

                string __pad_DhNZ4bLy0NNQJzW7QqqgMR_13 = __slot_DhNZ4bLy0NNQJzW7QqqgMR;
                var Output_14 = n20.StringExtensions.Plus(input: __pad_DhNZ4bLy0NNQJzW7QqqgMR_13, input2: Name_In);
                var State_Output_16 = state_6.__p_Bg4oMy4pd9RMPfq2tw3sIi.Update(Output_Out: out n5.GpuValue<T> Output_15);
                var State_Output_18 = state_6.__p_KOLAMKFKedGQGRb8MXsXxc.Update(GpuValue_In: Opacity_In, Default_In: Output_15, Output_Out: out n5.GpuValue<T> Output_17);
                n5.GpuValue<T> Default_Result_19 = default(n5.GpuValue<T>);
                n10.Spread<n5.IFunctionInvokeNode> Functions_20 = n11._Operations_.CreateDefault<n5.IFunctionInvokeNode>();
                n13.IEnumerable<string> Mixins_21 = n18._Operations_.CreateDefault<string>();
                n31.ImmutableDictionary<string, string> Template_Values_22 = n30._Operations_.CreateDefault<string, string>();
                bool Is_Groupable_23 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_24 = n18._Operations_.CreateDefault<n5.InputModifier>();
                var builder_25 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj, 3);
                builder_25.Add(Base_In);
                builder_25.Add(Blend_In);
                builder_25.Add(Output_17);
                var __pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj_26 = builder_25.Commit();
                var State_Output_29 = state_6.__p_N8iOGX0aakUPeB4wB7xDnj.Update(Arguments_In: __pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj_26, Function_Name_In: Output_14, Code_Template_In: The_Code_Template_In, Default_Result_In: Default_Result_19, Functions_In: Functions_20, Mixins_In: Mixins_21, Template_Values_In: Template_Values_22, Is_Groupable_In: Is_Groupable_23, The_Modifiers_In: The_Modifiers_24, Output_Out: out n5.GpuValue<T> Output_27, AdditionalOutputs_Out: out n10.Spread<n5.AbstractGpuValue> AdditionalOutputs_28);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_16 != state_6.__p_Bg4oMy4pd9RMPfq2tw3sIi || State_Output_18 != state_6.__p_KOLAMKFKedGQGRb8MXsXxc || __pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj_26 != state_6.__pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj || State_Output_29 != state_6.__p_N8iOGX0aakUPeB4wB7xDnj ? new __QxRScwFUDjLNXVB8ktKkYl(state_6)
                    {__p_Bg4oMy4pd9RMPfq2tw3sIi = State_Output_16, __p_KOLAMKFKedGQGRb8MXsXxc = State_Output_18, __pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj = __pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj_26, __p_N8iOGX0aakUPeB4wB7xDnj = State_Output_29} : state_6;
                else
                {
                    state_6.__p_Bg4oMy4pd9RMPfq2tw3sIi = State_Output_16;
                    state_6.__p_KOLAMKFKedGQGRb8MXsXxc = State_Output_18;
                    state_6.__pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj = __pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj_26;
                    state_6.__p_N8iOGX0aakUPeB4wB7xDnj = State_Output_29;
                }

                outputs_4 = n2.ValueTuple.Create(Output_27);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_30 = outputs_4.Item1;
            Output_Out = __auto_30;
            n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> that_31 = this;
            if (this.__GetContext__().IsImmutable)
                that_31 = manager_2 != this.__cache_PmmDKOfaIoWLWwVotsaaON ? new BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T>(this)
                {__cache_PmmDKOfaIoWLWwVotsaaON = manager_2} : that_31;
            else
            {
                this.__cache_PmmDKOfaIoWLWwVotsaaON = manager_2;
            }

            return that_31;
        }

        public n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> that_0 = this;
            this.__cache_PmmDKOfaIoWLWwVotsaaON = null;
            return that_0;
        }

        public n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __CreateDefault__()
        {
            n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> that_0 = this;
            this.__cache_PmmDKOfaIoWLWwVotsaaON = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_PmmDKOfaIoWLWwVotsaaON);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 335236U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "PmmDKOfaIoWLWwVotsaaON", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_PmmDKOfaIoWLWwVotsaaON = null;
        [n1.ElementAttribute(TracingId = 335273U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "DhNZ4bLy0NNQJzW7QqqgMR", Name = "__slot_DhNZ4bLy0NNQJzW7QqqgMR")]
        public static string __slot_DhNZ4bLy0NNQJzW7QqqgMR = "BlendMode";
        static BlendMode_EqZ3kz9zj7VL8O6frLV5UD()
        {
        }

        public BlendMode_EqZ3kz9zj7VL8O6frLV5UD(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BlendMode_EqZ3kz9zj7VL8O6frLV5UD(BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> other): base(other)
        {
            this.__cache_PmmDKOfaIoWLWwVotsaaON = other.__cache_PmmDKOfaIoWLWwVotsaaON;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_PmmDKOfaIoWLWwVotsaaON", in __cache_PmmDKOfaIoWLWwVotsaaON));
        }

        internal BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<T>, string, string>, n2.ValueTuple<n5.GpuValue<T>>> __cache_PmmDKOfaIoWLWwVotsaaON)
        {
            n17.BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_PmmDKOfaIoWLWwVotsaaON != this.__cache_PmmDKOfaIoWLWwVotsaaON ? new BlendMode_EqZ3kz9zj7VL8O6frLV5UD<T>(this)
                {__cache_PmmDKOfaIoWLWwVotsaaON = __cache_PmmDKOfaIoWLWwVotsaaON} : that_0;
            else
            {
                this.__cache_PmmDKOfaIoWLWwVotsaaON = __cache_PmmDKOfaIoWLWwVotsaaON;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "QxRScwFUDjLNXVB8ktKkYl", Name = "__QxRScwFUDjLNXVB8ktKkYl")]
        [n2.SerializableAttribute]
        public class __QxRScwFUDjLNXVB8ktKkYl : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_N8iOGX0aakUPeB4wB7xDnj);
                n1.CompilationHelper.SafeDispose(this.__p_KOLAMKFKedGQGRb8MXsXxc);
                n1.CompilationHelper.SafeDispose(this.__p_Bg4oMy4pd9RMPfq2tw3sIi);
                return;
            }

            [n1.ElementAttribute(TracingId = 335279U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "N8iOGX0aakUPeB4wB7xDnj", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n16.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>> __p_N8iOGX0aakUPeB4wB7xDnj;
            [n1.ElementAttribute(TracingId = 335299U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "KOLAMKFKedGQGRb8MXsXxc", Name = "CheckDefault (GpuValue)", IsManaged = true, IsAutoGenerated = true)]
            public n29.CheckDefault_GpuValue_PdsuywpUtM6PfMHKiPiuYX<T> __p_KOLAMKFKedGQGRb8MXsXxc;
            [n1.ElementAttribute(TracingId = 335311U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Bg4oMy4pd9RMPfq2tw3sIi", Name = "HALF", IsManaged = true, IsAutoGenerated = true)]
            public n9.HALF_Ul2Y1lSFl6WN0sQ1DLnAcN<T> __p_Bg4oMy4pd9RMPfq2tw3sIi;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj = default(n10.Spread<n5.AbstractGpuValue>);
            public __QxRScwFUDjLNXVB8ktKkYl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __QxRScwFUDjLNXVB8ktKkYl(__QxRScwFUDjLNXVB8ktKkYl other): base(other)
            {
                this.__p_N8iOGX0aakUPeB4wB7xDnj = other.__p_N8iOGX0aakUPeB4wB7xDnj;
                this.__p_KOLAMKFKedGQGRb8MXsXxc = other.__p_KOLAMKFKedGQGRb8MXsXxc;
                this.__p_Bg4oMy4pd9RMPfq2tw3sIi = other.__p_Bg4oMy4pd9RMPfq2tw3sIi;
                this.__pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj = other.__pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_N8iOGX0aakUPeB4wB7xDnj", in __p_N8iOGX0aakUPeB4wB7xDnj), n1.CompilationHelper.GetValueOrExisting(values, "__p_KOLAMKFKedGQGRb8MXsXxc", in __p_KOLAMKFKedGQGRb8MXsXxc), n1.CompilationHelper.GetValueOrExisting(values, "__p_Bg4oMy4pd9RMPfq2tw3sIi", in __p_Bg4oMy4pd9RMPfq2tw3sIi), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj", in __pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj));
            }

            internal __QxRScwFUDjLNXVB8ktKkYl __WITH__(n16.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>> __p_N8iOGX0aakUPeB4wB7xDnj, n29.CheckDefault_GpuValue_PdsuywpUtM6PfMHKiPiuYX<T> __p_KOLAMKFKedGQGRb8MXsXxc, n9.HALF_Ul2Y1lSFl6WN0sQ1DLnAcN<T> __p_Bg4oMy4pd9RMPfq2tw3sIi, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj)
            {
                __QxRScwFUDjLNXVB8ktKkYl that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_N8iOGX0aakUPeB4wB7xDnj != this.__p_N8iOGX0aakUPeB4wB7xDnj || __p_KOLAMKFKedGQGRb8MXsXxc != this.__p_KOLAMKFKedGQGRb8MXsXxc || __p_Bg4oMy4pd9RMPfq2tw3sIi != this.__p_Bg4oMy4pd9RMPfq2tw3sIi || __pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj != this.__pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj ? new __QxRScwFUDjLNXVB8ktKkYl(this)
                    {__p_N8iOGX0aakUPeB4wB7xDnj = __p_N8iOGX0aakUPeB4wB7xDnj, __p_KOLAMKFKedGQGRb8MXsXxc = __p_KOLAMKFKedGQGRb8MXsXxc, __p_Bg4oMy4pd9RMPfq2tw3sIi = __p_Bg4oMy4pd9RMPfq2tw3sIi, __pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj = __pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj} : that_0;
                else
                {
                    this.__p_N8iOGX0aakUPeB4wB7xDnj = __p_N8iOGX0aakUPeB4wB7xDnj;
                    this.__p_KOLAMKFKedGQGRb8MXsXxc = __p_KOLAMKFKedGQGRb8MXsXxc;
                    this.__p_Bg4oMy4pd9RMPfq2tw3sIi = __p_Bg4oMy4pd9RMPfq2tw3sIi;
                    this.__pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj = __pin_group_Arguments_In_N8iOGX0aakUPeB4wB7xDnj;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 335428U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Ca9W8vdlRRlMfxFR3hVzhX", Name = "FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX")]
    [n2.SerializableAttribute]
    public class FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX Create(n1.NodeContext Node_Context)
        {
            var instance = new FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX CreateDefault()
        {
            var instance = new FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX Update(out string Singleton_Out)
        {
            string __pad_Inej0sGWLWZN8AUVx73ISg_0 = __slot_Inej0sGWLWZN8AUVx73ISg;
            Singleton_Out = __pad_Inej0sGWLWZN8AUVx73ISg_0;
            return this;
        }

        public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n17.FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __CreateDefault__()
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

        [n1.ElementAttribute(TracingId = 335438U, DocumentId = "NvxFK0tAsVyMwtaYRjadP2", PersistentId = "Inej0sGWLWZN8AUVx73ISg", Name = "__slot_Inej0sGWLWZN8AUVx73ISg")]
        public static string __slot_Inej0sGWLWZN8AUVx73ISg = "FuseCoreColor";
        static FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX()
        {
        }

        public FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX(FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal FuseCoreColor_Mixin_Ca9W8vdlRRlMfxFR3hVzhX __WITH__()
        {
            return this;
        }
    }
}

namespace _Fuse_Core_Color_
{
    public struct __AdaptiveImplementations__NvxFK0tAsVyMwtaYRjadP2 : n28.IAdaptiveCreateDefault<n5.GpuValue<n15.Vector3>>
    {
        public void CreateDefault(out n5.GpuValue<n15.Vector3> Output_Out)
        {
            n32._Operations_.CreateDefault_Generic<n5.GpuValue<n15.Vector3>>(Output_Out: out n5.GpuValue<n15.Vector3> Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}