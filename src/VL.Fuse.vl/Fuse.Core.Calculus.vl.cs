extern alias e3;
extern alias e2;
extern alias e71;
extern alias e4;

using n10 = e2::VL.Lib.Collections;
using n6 = e3::VL.Lib.Primitive.CacheRegion;
using n16 = _CoreLibBasics_.Control;
using n23 = _VL_Collections_.Collections.Dictionary;
using n22 = global::System.Collections.Immutable;
using n25 = _Fuse_Core_Calculus_.Fuse.Core.Calculus.Vector;
using n5 = e71::Fuse;
using n18 = _Fuse_Core_Calculus_.Fuse.Core.Calculus.Differentiation;
using n9 = _Fuse_Core_.Fuse.Core.Function;
using n13 = global::System.Collections.Generic;
using n29 = _Fuse_Core_.Fuse.Core.Split;
using n17 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n15 = e71::Fuse.Core.Calculus;
using n7 = _Fuse_Core_Math_.Fuse.Core.Math;
using n1 = e2::VL.Core;
using n3 = _Fuse_Core_Calculus_.Fuse.Core.Calculus.Integration;
using n14 = _Fuse_Core_.Fuse.Core.Value;
using n2 = global::System;
using n28 = _Fuse_Core_Calculus_;
using n26 = e4::Stride.Core.Mathematics;
using n27 = _Fuse_Core_Math_.Fuse.Core.Math.transform;
using n30 = _Fuse_Core_Calculus_.Fuse.Core.Calculus;
using n21 = e3::VL.Lib.Primitive.Object;
using n4 = e2::VL.Core.CompilerServices;
using n19 = _Fuse_Core_.Fuse.Core.Implementation;
using n20 = _Fuse_Core_.Fuse.Core.Util;
using n24 = _VL_Collections_.Collections.Sequence;
using n12 = global::System.Runtime.CompilerServices;
using n8 = _Fuse_Core_.Fuse.Core.Conversion;
using n11 = _VL_Collections_.Collections.Spread;
using n31 = _CoreLibBasics_.Primitive.Advanced;

namespace _Fuse_Core_Calculus_.Fuse.Core.Calculus.Integration
{
    [n1.ElementAttribute(TracingId = 342287U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "UGOff270OGRMGHqpMoRrg8", Name = "Euler_UGOff270OGRMGHqpMoRrg8")]
    [n2.SerializableAttribute]
    public class Euler_UGOff270OGRMGHqpMoRrg8<T> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.Euler_UGOff270OGRMGHqpMoRrg8<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Euler_UGOff270OGRMGHqpMoRrg8<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Euler_UGOff270OGRMGHqpMoRrg8<T> CreateDefault()
        {
            var instance = new Euler_UGOff270OGRMGHqpMoRrg8<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Euler_UGOff270OGRMGHqpMoRrg8<T> Update(n5.GpuValue<T> Function_In, n5.GpuValue<T> Position_In, n5.GpuValue<float> Step_Size_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_VDRurJw1wOtPFApwz2BIyf;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Function_In, Step_Size_In, Position_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__QP4P72MhPUCQJtmrr9DSXb>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __QP4P72MhPUCQJtmrr9DSXb(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs = n11._Operations_.CreateDefault<n5.AbstractGpuValue>(), __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "Tz65UfosA73Lp9Tvs0H7AG", 342335U);
                    var Output_8 = n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_Tz65UfosA73Lp9Tvs0H7AG = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "Q4CAVfcPmc6LanJO5poLVc", 342353U);
                    var Output_10 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_Q4CAVfcPmc6LanJO5poLVc = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "BNhZ43AYVEVM1zTZr5I3kR", 342360U);
                    var Output_12 = n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T>.Create(Node_Context: Node_Context_11);
                    state_6.__p_BNhZ43AYVEVM1zTZr5I3kR = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "HlXIvsNWSruQRd0OYb0yXs", 342374U);
                    var Output_14 = n9.Invoke_C<T>.Create(Node_Context: Node_Context_13);
                    state_6.__p_HlXIvsNWSruQRd0OYb0yXs = Output_14;
                }

                var builder_15 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs, 1);
                builder_15.Add(Position_In);
                var __pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs_16 = builder_15.Commit();
                var State_Output_18 = state_6.__p_HlXIvsNWSruQRd0OYb0yXs.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs_16, Output_Out: out n5.GpuValue<T> Output_17);
                var State_Output_20 = state_6.__p_BNhZ43AYVEVM1zTZr5I3kR.Update(value_In: Step_Size_In, Output_Out: out n5.GpuValue<T> Output_19);
                var builder_21 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc, 2);
                builder_21.Add(Output_17);
                builder_21.Add(Output_19);
                var __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc_22 = builder_21.Commit();
                var State_Output_24 = state_6.__p_Q4CAVfcPmc6LanJO5poLVc.Update(Input_In: __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc_22, Output_Out: out n5.GpuValue<T> Output_23);
                var builder_25 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG, 2);
                builder_25.Add(Output_23);
                builder_25.Add(Position_In);
                var __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG_26 = builder_25.Commit();
                var State_Output_28 = state_6.__p_Tz65UfosA73Lp9Tvs0H7AG.Update(Input_In: __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG_26, Output_Out: out n5.GpuValue<T> Output_27);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = __pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs_16 != state_6.__pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs || State_Output_18 != state_6.__p_HlXIvsNWSruQRd0OYb0yXs || State_Output_20 != state_6.__p_BNhZ43AYVEVM1zTZr5I3kR || __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc_22 != state_6.__pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc || State_Output_24 != state_6.__p_Q4CAVfcPmc6LanJO5poLVc || __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG_26 != state_6.__pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG || State_Output_28 != state_6.__p_Tz65UfosA73Lp9Tvs0H7AG ? new __QP4P72MhPUCQJtmrr9DSXb(state_6)
                    {__pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs = __pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs_16, __p_HlXIvsNWSruQRd0OYb0yXs = State_Output_18, __p_BNhZ43AYVEVM1zTZr5I3kR = State_Output_20, __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc = __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc_22, __p_Q4CAVfcPmc6LanJO5poLVc = State_Output_24, __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG = __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG_26, __p_Tz65UfosA73Lp9Tvs0H7AG = State_Output_28} : state_6;
                else
                {
                    state_6.__pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs = __pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs_16;
                    state_6.__p_HlXIvsNWSruQRd0OYb0yXs = State_Output_18;
                    state_6.__p_BNhZ43AYVEVM1zTZr5I3kR = State_Output_20;
                    state_6.__pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc = __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc_22;
                    state_6.__p_Q4CAVfcPmc6LanJO5poLVc = State_Output_24;
                    state_6.__pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG = __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG_26;
                    state_6.__p_Tz65UfosA73Lp9Tvs0H7AG = State_Output_28;
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
            n3.Euler_UGOff270OGRMGHqpMoRrg8<T> that_30 = this;
            if (this.__GetContext__().IsImmutable)
                that_30 = manager_2 != this.__cache_VDRurJw1wOtPFApwz2BIyf ? new Euler_UGOff270OGRMGHqpMoRrg8<T>(this)
                {__cache_VDRurJw1wOtPFApwz2BIyf = manager_2} : that_30;
            else
            {
                this.__cache_VDRurJw1wOtPFApwz2BIyf = manager_2;
            }

            return that_30;
        }

        public n3.Euler_UGOff270OGRMGHqpMoRrg8<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Euler_UGOff270OGRMGHqpMoRrg8<T> that_0 = this;
            this.__cache_VDRurJw1wOtPFApwz2BIyf = null;
            return that_0;
        }

        public n3.Euler_UGOff270OGRMGHqpMoRrg8<T> __CreateDefault__()
        {
            n3.Euler_UGOff270OGRMGHqpMoRrg8<T> that_0 = this;
            this.__cache_VDRurJw1wOtPFApwz2BIyf = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_VDRurJw1wOtPFApwz2BIyf);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 342293U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "EUbVr1dgVCJM7PoQ93kLc4", Name = "__slot_EUbVr1dgVCJM7PoQ93kLc4")]
        public static string __slot_EUbVr1dgVCJM7PoQ93kLc4 = "#define calcEulerV3(f, p, dT)  ( p += f(p) * dT )  ";
        [n1.ElementAttribute(TracingId = 342309U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "VDRurJw1wOtPFApwz2BIyf", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_VDRurJw1wOtPFApwz2BIyf = null;
        static Euler_UGOff270OGRMGHqpMoRrg8()
        {
        }

        public Euler_UGOff270OGRMGHqpMoRrg8(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Euler_UGOff270OGRMGHqpMoRrg8(Euler_UGOff270OGRMGHqpMoRrg8<T> other): base(other)
        {
            this.__cache_VDRurJw1wOtPFApwz2BIyf = other.__cache_VDRurJw1wOtPFApwz2BIyf;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_VDRurJw1wOtPFApwz2BIyf", in __cache_VDRurJw1wOtPFApwz2BIyf));
        }

        internal Euler_UGOff270OGRMGHqpMoRrg8<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, n5.GpuValue<T>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_VDRurJw1wOtPFApwz2BIyf)
        {
            n3.Euler_UGOff270OGRMGHqpMoRrg8<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_VDRurJw1wOtPFApwz2BIyf != this.__cache_VDRurJw1wOtPFApwz2BIyf ? new Euler_UGOff270OGRMGHqpMoRrg8<T>(this)
                {__cache_VDRurJw1wOtPFApwz2BIyf = __cache_VDRurJw1wOtPFApwz2BIyf} : that_0;
            else
            {
                this.__cache_VDRurJw1wOtPFApwz2BIyf = __cache_VDRurJw1wOtPFApwz2BIyf;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "QP4P72MhPUCQJtmrr9DSXb", Name = "__QP4P72MhPUCQJtmrr9DSXb")]
        [n2.SerializableAttribute]
        public class __QP4P72MhPUCQJtmrr9DSXb : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Tz65UfosA73Lp9Tvs0H7AG);
                n1.CompilationHelper.SafeDispose(this.__p_Q4CAVfcPmc6LanJO5poLVc);
                n1.CompilationHelper.SafeDispose(this.__p_BNhZ43AYVEVM1zTZr5I3kR);
                n1.CompilationHelper.SafeDispose(this.__p_HlXIvsNWSruQRd0OYb0yXs);
                return;
            }

            [n1.ElementAttribute(TracingId = 342335U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Tz65UfosA73Lp9Tvs0H7AG", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_Tz65UfosA73Lp9Tvs0H7AG;
            [n1.ElementAttribute(TracingId = 342353U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Q4CAVfcPmc6LanJO5poLVc", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_Q4CAVfcPmc6LanJO5poLVc;
            [n1.ElementAttribute(TracingId = 342360U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "BNhZ43AYVEVM1zTZr5I3kR", Name = "FromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T> __p_BNhZ43AYVEVM1zTZr5I3kR;
            [n1.ElementAttribute(TracingId = 342374U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "HlXIvsNWSruQRd0OYb0yXs", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n9.Invoke_C<T> __p_HlXIvsNWSruQRd0OYb0yXs;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs = default(n10.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG = default(n10.Spread<n5.GpuValue<T>>);
            public __QP4P72MhPUCQJtmrr9DSXb(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __QP4P72MhPUCQJtmrr9DSXb(__QP4P72MhPUCQJtmrr9DSXb other): base(other)
            {
                this.__p_Tz65UfosA73Lp9Tvs0H7AG = other.__p_Tz65UfosA73Lp9Tvs0H7AG;
                this.__p_Q4CAVfcPmc6LanJO5poLVc = other.__p_Q4CAVfcPmc6LanJO5poLVc;
                this.__p_BNhZ43AYVEVM1zTZr5I3kR = other.__p_BNhZ43AYVEVM1zTZr5I3kR;
                this.__p_HlXIvsNWSruQRd0OYb0yXs = other.__p_HlXIvsNWSruQRd0OYb0yXs;
                this.__pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs = other.__pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs;
                this.__pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc = other.__pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc;
                this.__pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG = other.__pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Tz65UfosA73Lp9Tvs0H7AG", in __p_Tz65UfosA73Lp9Tvs0H7AG), n1.CompilationHelper.GetValueOrExisting(values, "__p_Q4CAVfcPmc6LanJO5poLVc", in __p_Q4CAVfcPmc6LanJO5poLVc), n1.CompilationHelper.GetValueOrExisting(values, "__p_BNhZ43AYVEVM1zTZr5I3kR", in __p_BNhZ43AYVEVM1zTZr5I3kR), n1.CompilationHelper.GetValueOrExisting(values, "__p_HlXIvsNWSruQRd0OYb0yXs", in __p_HlXIvsNWSruQRd0OYb0yXs), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs", in __pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc", in __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG", in __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG));
            }

            internal __QP4P72MhPUCQJtmrr9DSXb __WITH__(n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_Tz65UfosA73Lp9Tvs0H7AG, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_Q4CAVfcPmc6LanJO5poLVc, n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T> __p_BNhZ43AYVEVM1zTZr5I3kR, n9.Invoke_C<T> __p_HlXIvsNWSruQRd0OYb0yXs, n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG)
            {
                __QP4P72MhPUCQJtmrr9DSXb that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Tz65UfosA73Lp9Tvs0H7AG != this.__p_Tz65UfosA73Lp9Tvs0H7AG || __p_Q4CAVfcPmc6LanJO5poLVc != this.__p_Q4CAVfcPmc6LanJO5poLVc || __p_BNhZ43AYVEVM1zTZr5I3kR != this.__p_BNhZ43AYVEVM1zTZr5I3kR || __p_HlXIvsNWSruQRd0OYb0yXs != this.__p_HlXIvsNWSruQRd0OYb0yXs || __pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs != this.__pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs || __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc != this.__pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc || __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG != this.__pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG ? new __QP4P72MhPUCQJtmrr9DSXb(this)
                    {__p_Tz65UfosA73Lp9Tvs0H7AG = __p_Tz65UfosA73Lp9Tvs0H7AG, __p_Q4CAVfcPmc6LanJO5poLVc = __p_Q4CAVfcPmc6LanJO5poLVc, __p_BNhZ43AYVEVM1zTZr5I3kR = __p_BNhZ43AYVEVM1zTZr5I3kR, __p_HlXIvsNWSruQRd0OYb0yXs = __p_HlXIvsNWSruQRd0OYb0yXs, __pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs = __pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs, __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc = __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc, __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG = __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG} : that_0;
                else
                {
                    this.__p_Tz65UfosA73Lp9Tvs0H7AG = __p_Tz65UfosA73Lp9Tvs0H7AG;
                    this.__p_Q4CAVfcPmc6LanJO5poLVc = __p_Q4CAVfcPmc6LanJO5poLVc;
                    this.__p_BNhZ43AYVEVM1zTZr5I3kR = __p_BNhZ43AYVEVM1zTZr5I3kR;
                    this.__p_HlXIvsNWSruQRd0OYb0yXs = __p_HlXIvsNWSruQRd0OYb0yXs;
                    this.__pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs = __pin_group_Parameters_In_HlXIvsNWSruQRd0OYb0yXs;
                    this.__pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc = __pin_group_Input_In_Q4CAVfcPmc6LanJO5poLVc;
                    this.__pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG = __pin_group_Input_In_Tz65UfosA73Lp9Tvs0H7AG;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 342477U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "VaiYU9nx7QuNt33zItr6W2", Name = "RungeKutta2_VaiYU9nx7QuNt33zItr6W2")]
    [n2.SerializableAttribute]
    public class RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> CreateDefault()
        {
            var instance = new RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> Update(n5.GpuValue<T> Function_In, n5.GpuValue<T> Position_In, n5.GpuValue<float> Step_Size_In, out n5.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_U5l6MkPYDz3OVA13H3YI5B;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Function_In, Position_In, Step_Size_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__K43AQ8l2cj9MNV99p30ndm>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __K43AQ8l2cj9MNV99p30ndm(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY = n11._Operations_.CreateDefault<n5.AbstractGpuValue>(), v1 = default(n5.GpuValue<T>), __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm = n11._Operations_.CreateDefault<n5.GpuValue<float>>(), halfDT = default(n5.GpuValue<T>), __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R = n11._Operations_.CreateDefault<n5.AbstractGpuValue>(), v2 = default(n5.GpuValue<T>), __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7 = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "AcZOMERoriQQQVDfuVNB8v", 342528U);
                    var Output_8 = n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_AcZOMERoriQQQVDfuVNB8v = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "U1CZX007VoWPpfHilaI9E7", 342545U);
                    var Output_10 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_U1CZX007VoWPpfHilaI9E7 = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "NOIgGXlXVLXNVRM8UFq0AY", 342560U);
                    var Output_12 = n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T>.Create(Node_Context: Node_Context_11);
                    state_6.__p_NOIgGXlXVLXNVRM8UFq0AY = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "RajwoHi7hqtQJVBvLotjtm", 342575U);
                    var Output_14 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_13);
                    state_6.__p_RajwoHi7hqtQJVBvLotjtm = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "DX2RB2izD8xNgoSwrJtwBR", 342593U);
                    var Output_16 = n14.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float>.Create(Node_Context: Node_Context_15);
                    state_6.__p_DX2RB2izD8xNgoSwrJtwBR = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "FnkTI2n0H4RMZvOgIKWkhY", 342615U);
                    var Output_18 = n9.Invoke_C<T>.Create(Node_Context: Node_Context_17);
                    state_6.__p_FnkTI2n0H4RMZvOgIKWkhY = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "LAJ7uVB1lxVNo9YxbdlRcS", 342635U);
                    var Output_20 = n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_19);
                    state_6.__p_LAJ7uVB1lxVNo9YxbdlRcS = Output_20;
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "PZL4DBYNIvOOlUh1sc2ooo", 342646U);
                    var Output_22 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_21);
                    state_6.__p_PZL4DBYNIvOOlUh1sc2ooo = Output_22;
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "Kl8UMcKKRVgNi5fU9hwO6R", 342659U);
                    var Output_24 = n9.Invoke_C<T>.Create(Node_Context: Node_Context_23);
                    state_6.__p_Kl8UMcKKRVgNi5fU9hwO6R = Output_24;
                    n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "KmJxAGDsMWwOprew5xojDf", 342690U);
                    var Output_26 = n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_25);
                    state_6.__p_KmJxAGDsMWwOprew5xojDf = Output_26;
                }

                float __pad_OaNfWusw81GMDGUPdJP0Pc_27 = __slot_OaNfWusw81GMDGUPdJP0Pc;
                var builder_28 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY, 1);
                builder_28.Add(Position_In);
                var __pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY_29 = builder_28.Commit();
                var State_Output_31 = state_6.__p_FnkTI2n0H4RMZvOgIKWkhY.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY_29, Output_Out: out n5.GpuValue<T> Output_30);
                n5.GpuValue<T> __auto_32 = Output_30;
                var State_Output_34 = state_6.__p_DX2RB2izD8xNgoSwrJtwBR.Update(The_Value_In: __pad_OaNfWusw81GMDGUPdJP0Pc_27, Output_Out: out n5.ConstantValue<float> Output_33);
                var builder_35 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm, 2);
                builder_35.Add(Step_Size_In);
                builder_35.Add(Output_33);
                var __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm_36 = builder_35.Commit();
                var State_Output_38 = state_6.__p_RajwoHi7hqtQJVBvLotjtm.Update(Input_In: __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm_36, Output_Out: out n5.GpuValue<float> Output_37);
                var State_Output_40 = state_6.__p_NOIgGXlXVLXNVRM8UFq0AY.Update(value_In: Output_37, Output_Out: out n5.GpuValue<T> Output_39);
                n5.GpuValue<T> __auto_41 = Output_39;
                var builder_42 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo, 2);
                builder_42.Add(__auto_32);
                builder_42.Add(__auto_41);
                var __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo_43 = builder_42.Commit();
                var State_Output_45 = state_6.__p_PZL4DBYNIvOOlUh1sc2ooo.Update(Input_In: __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo_43, Output_Out: out n5.GpuValue<T> Output_44);
                var builder_46 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS, 2);
                builder_46.Add(Output_44);
                builder_46.Add(Position_In);
                var __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS_47 = builder_46.Commit();
                var State_Output_49 = state_6.__p_LAJ7uVB1lxVNo9YxbdlRcS.Update(Input_In: __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS_47, Output_Out: out n5.GpuValue<T> Output_48);
                var builder_50 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R, 1);
                builder_50.Add(Output_48);
                var __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R_51 = builder_50.Commit();
                var State_Output_53 = state_6.__p_Kl8UMcKKRVgNi5fU9hwO6R.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R_51, Output_Out: out n5.GpuValue<T> Output_52);
                n5.GpuValue<T> __auto_54 = Output_52;
                var builder_55 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_KmJxAGDsMWwOprew5xojDf, 2);
                builder_55.Add(__auto_54);
                builder_55.Add(__auto_32);
                var __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf_56 = builder_55.Commit();
                var State_Output_58 = state_6.__p_KmJxAGDsMWwOprew5xojDf.Update(Input_In: __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf_56, Output_Out: out n5.GpuValue<T> Output_57);
                var builder_59 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_U1CZX007VoWPpfHilaI9E7, 2);
                builder_59.Add(Output_57);
                builder_59.Add(__auto_41);
                var __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7_60 = builder_59.Commit();
                var State_Output_62 = state_6.__p_U1CZX007VoWPpfHilaI9E7.Update(Input_In: __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7_60, Output_Out: out n5.GpuValue<T> Output_61);
                var builder_63 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v, 2);
                builder_63.Add(Output_61);
                builder_63.Add(Position_In);
                var __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v_64 = builder_63.Commit();
                var State_Output_66 = state_6.__p_AcZOMERoriQQQVDfuVNB8v.Update(Input_In: __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v_64, Output_Out: out n5.GpuValue<T> Output_65);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = __pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY_29 != state_6.__pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY || State_Output_31 != state_6.__p_FnkTI2n0H4RMZvOgIKWkhY || Output_30 != state_6.v1 || State_Output_34 != state_6.__p_DX2RB2izD8xNgoSwrJtwBR || __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm_36 != state_6.__pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm || State_Output_38 != state_6.__p_RajwoHi7hqtQJVBvLotjtm || State_Output_40 != state_6.__p_NOIgGXlXVLXNVRM8UFq0AY || Output_39 != state_6.halfDT || __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo_43 != state_6.__pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo || State_Output_45 != state_6.__p_PZL4DBYNIvOOlUh1sc2ooo || __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS_47 != state_6.__pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS || State_Output_49 != state_6.__p_LAJ7uVB1lxVNo9YxbdlRcS || __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R_51 != state_6.__pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R || State_Output_53 != state_6.__p_Kl8UMcKKRVgNi5fU9hwO6R || Output_52 != state_6.v2 || __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf_56 != state_6.__pin_group_Input_In_KmJxAGDsMWwOprew5xojDf || State_Output_58 != state_6.__p_KmJxAGDsMWwOprew5xojDf || __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7_60 != state_6.__pin_group_Input_In_U1CZX007VoWPpfHilaI9E7 || State_Output_62 != state_6.__p_U1CZX007VoWPpfHilaI9E7 || __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v_64 != state_6.__pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v || State_Output_66 != state_6.__p_AcZOMERoriQQQVDfuVNB8v ? new __K43AQ8l2cj9MNV99p30ndm(state_6)
                    {__pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY = __pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY_29, __p_FnkTI2n0H4RMZvOgIKWkhY = State_Output_31, v1 = Output_30, __p_DX2RB2izD8xNgoSwrJtwBR = State_Output_34, __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm = __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm_36, __p_RajwoHi7hqtQJVBvLotjtm = State_Output_38, __p_NOIgGXlXVLXNVRM8UFq0AY = State_Output_40, halfDT = Output_39, __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo = __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo_43, __p_PZL4DBYNIvOOlUh1sc2ooo = State_Output_45, __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS = __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS_47, __p_LAJ7uVB1lxVNo9YxbdlRcS = State_Output_49, __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R = __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R_51, __p_Kl8UMcKKRVgNi5fU9hwO6R = State_Output_53, v2 = Output_52, __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf = __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf_56, __p_KmJxAGDsMWwOprew5xojDf = State_Output_58, __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7 = __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7_60, __p_U1CZX007VoWPpfHilaI9E7 = State_Output_62, __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v = __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v_64, __p_AcZOMERoriQQQVDfuVNB8v = State_Output_66} : state_6;
                else
                {
                    state_6.__pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY = __pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY_29;
                    state_6.__p_FnkTI2n0H4RMZvOgIKWkhY = State_Output_31;
                    state_6.v1 = Output_30;
                    state_6.__p_DX2RB2izD8xNgoSwrJtwBR = State_Output_34;
                    state_6.__pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm = __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm_36;
                    state_6.__p_RajwoHi7hqtQJVBvLotjtm = State_Output_38;
                    state_6.__p_NOIgGXlXVLXNVRM8UFq0AY = State_Output_40;
                    state_6.halfDT = Output_39;
                    state_6.__pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo = __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo_43;
                    state_6.__p_PZL4DBYNIvOOlUh1sc2ooo = State_Output_45;
                    state_6.__pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS = __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS_47;
                    state_6.__p_LAJ7uVB1lxVNo9YxbdlRcS = State_Output_49;
                    state_6.__pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R = __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R_51;
                    state_6.__p_Kl8UMcKKRVgNi5fU9hwO6R = State_Output_53;
                    state_6.v2 = Output_52;
                    state_6.__pin_group_Input_In_KmJxAGDsMWwOprew5xojDf = __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf_56;
                    state_6.__p_KmJxAGDsMWwOprew5xojDf = State_Output_58;
                    state_6.__pin_group_Input_In_U1CZX007VoWPpfHilaI9E7 = __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7_60;
                    state_6.__p_U1CZX007VoWPpfHilaI9E7 = State_Output_62;
                    state_6.__pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v = __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v_64;
                    state_6.__p_AcZOMERoriQQQVDfuVNB8v = State_Output_66;
                }

                outputs_4 = n2.ValueTuple.Create(Output_65);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_67 = outputs_4.Item1;
            Output_Out = __auto_67;
            n3.RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> that_68 = this;
            if (this.__GetContext__().IsImmutable)
                that_68 = manager_2 != this.__cache_U5l6MkPYDz3OVA13H3YI5B ? new RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T>(this)
                {__cache_U5l6MkPYDz3OVA13H3YI5B = manager_2} : that_68;
            else
            {
                this.__cache_U5l6MkPYDz3OVA13H3YI5B = manager_2;
            }

            return that_68;
        }

        public n3.RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> that_0 = this;
            this.__cache_U5l6MkPYDz3OVA13H3YI5B = null;
            return that_0;
        }

        public n3.RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> __CreateDefault__()
        {
            n3.RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> that_0 = this;
            this.__cache_U5l6MkPYDz3OVA13H3YI5B = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_U5l6MkPYDz3OVA13H3YI5B);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 342482U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Ei4cYSEXOwhNFrhWmLUhWn", Name = "__slot_Ei4cYSEXOwhNFrhWmLUhWn")]
        public static string __slot_Ei4cYSEXOwhNFrhWmLUhWn = "#define calcRK2V2(f, p, dT)\t\t\t\t\t\t\t\t\r\n\tfloat halfDT_##f = dT * 0.5;\t\t\t\t\t\t\r\n\tfloat2 v1_##f = f(p);\t\t\t\t\t\t\t\t\r\n\tfloat2 v2_##f = f(p + v1_##f * halfDT_##f);\t\t\t\r\n\tp += (v1_##f + v2_##f)  * halfDT_##f";
        [n1.ElementAttribute(TracingId = 342496U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "U5l6MkPYDz3OVA13H3YI5B", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_U5l6MkPYDz3OVA13H3YI5B = null;
        [n1.ElementAttribute(TracingId = 342608U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "OaNfWusw81GMDGUPdJP0Pc", Name = "__slot_OaNfWusw81GMDGUPdJP0Pc")]
        public static float __slot_OaNfWusw81GMDGUPdJP0Pc = 0.5F;
        static RungeKutta2_VaiYU9nx7QuNt33zItr6W2()
        {
        }

        public RungeKutta2_VaiYU9nx7QuNt33zItr6W2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RungeKutta2_VaiYU9nx7QuNt33zItr6W2(RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> other): base(other)
        {
            this.__cache_U5l6MkPYDz3OVA13H3YI5B = other.__cache_U5l6MkPYDz3OVA13H3YI5B;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_U5l6MkPYDz3OVA13H3YI5B", in __cache_U5l6MkPYDz3OVA13H3YI5B));
        }

        internal RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_U5l6MkPYDz3OVA13H3YI5B)
        {
            n3.RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_U5l6MkPYDz3OVA13H3YI5B != this.__cache_U5l6MkPYDz3OVA13H3YI5B ? new RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T>(this)
                {__cache_U5l6MkPYDz3OVA13H3YI5B = __cache_U5l6MkPYDz3OVA13H3YI5B} : that_0;
            else
            {
                this.__cache_U5l6MkPYDz3OVA13H3YI5B = __cache_U5l6MkPYDz3OVA13H3YI5B;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "K43AQ8l2cj9MNV99p30ndm", Name = "__K43AQ8l2cj9MNV99p30ndm")]
        [n2.SerializableAttribute]
        public class __K43AQ8l2cj9MNV99p30ndm : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_AcZOMERoriQQQVDfuVNB8v);
                n1.CompilationHelper.SafeDispose(this.__p_U1CZX007VoWPpfHilaI9E7);
                n1.CompilationHelper.SafeDispose(this.__p_NOIgGXlXVLXNVRM8UFq0AY);
                n1.CompilationHelper.SafeDispose(this.__p_RajwoHi7hqtQJVBvLotjtm);
                n1.CompilationHelper.SafeDispose(this.__p_DX2RB2izD8xNgoSwrJtwBR);
                n1.CompilationHelper.SafeDispose(this.__p_FnkTI2n0H4RMZvOgIKWkhY);
                n1.CompilationHelper.SafeDispose(this.__p_LAJ7uVB1lxVNo9YxbdlRcS);
                n1.CompilationHelper.SafeDispose(this.__p_PZL4DBYNIvOOlUh1sc2ooo);
                n1.CompilationHelper.SafeDispose(this.__p_Kl8UMcKKRVgNi5fU9hwO6R);
                n1.CompilationHelper.SafeDispose(this.__p_KmJxAGDsMWwOprew5xojDf);
                return;
            }

            [n1.ElementAttribute(TracingId = 342528U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "AcZOMERoriQQQVDfuVNB8v", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_AcZOMERoriQQQVDfuVNB8v;
            [n1.ElementAttribute(TracingId = 342545U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "U1CZX007VoWPpfHilaI9E7", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_U1CZX007VoWPpfHilaI9E7;
            [n1.ElementAttribute(TracingId = 342560U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "NOIgGXlXVLXNVRM8UFq0AY", Name = "FromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T> __p_NOIgGXlXVLXNVRM8UFq0AY;
            [n1.ElementAttribute(TracingId = 342575U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "RajwoHi7hqtQJVBvLotjtm", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_RajwoHi7hqtQJVBvLotjtm;
            [n1.ElementAttribute(TracingId = 342593U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "DX2RB2izD8xNgoSwrJtwBR", Name = "ConstantFromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n14.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_DX2RB2izD8xNgoSwrJtwBR;
            [n1.ElementAttribute(TracingId = 342615U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "FnkTI2n0H4RMZvOgIKWkhY", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n9.Invoke_C<T> __p_FnkTI2n0H4RMZvOgIKWkhY;
            [n1.ElementAttribute(TracingId = 342635U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "LAJ7uVB1lxVNo9YxbdlRcS", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_LAJ7uVB1lxVNo9YxbdlRcS;
            [n1.ElementAttribute(TracingId = 342646U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "PZL4DBYNIvOOlUh1sc2ooo", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_PZL4DBYNIvOOlUh1sc2ooo;
            [n1.ElementAttribute(TracingId = 342659U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Kl8UMcKKRVgNi5fU9hwO6R", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n9.Invoke_C<T> __p_Kl8UMcKKRVgNi5fU9hwO6R;
            [n1.ElementAttribute(TracingId = 342690U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "KmJxAGDsMWwOprew5xojDf", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_KmJxAGDsMWwOprew5xojDf;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY = default(n10.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(TracingId = 342678U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "DZKbCqmXTOoPpzVUs4mI7v", Name = "v1")]
            public n5.GpuValue<T> v1;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm = default(n10.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(TracingId = 342686U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "GkzzBXDY614MFxgqWBDPTJ", Name = "halfDT")]
            public n5.GpuValue<T> halfDT;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R = default(n10.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(TracingId = 342681U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Tmtn9Aj0KcBN4z26AUjU7S", Name = "v2")]
            public n5.GpuValue<T> v2;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7 = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v = default(n10.Spread<n5.GpuValue<T>>);
            public __K43AQ8l2cj9MNV99p30ndm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __K43AQ8l2cj9MNV99p30ndm(__K43AQ8l2cj9MNV99p30ndm other): base(other)
            {
                this.__p_AcZOMERoriQQQVDfuVNB8v = other.__p_AcZOMERoriQQQVDfuVNB8v;
                this.__p_U1CZX007VoWPpfHilaI9E7 = other.__p_U1CZX007VoWPpfHilaI9E7;
                this.__p_NOIgGXlXVLXNVRM8UFq0AY = other.__p_NOIgGXlXVLXNVRM8UFq0AY;
                this.__p_RajwoHi7hqtQJVBvLotjtm = other.__p_RajwoHi7hqtQJVBvLotjtm;
                this.__p_DX2RB2izD8xNgoSwrJtwBR = other.__p_DX2RB2izD8xNgoSwrJtwBR;
                this.__p_FnkTI2n0H4RMZvOgIKWkhY = other.__p_FnkTI2n0H4RMZvOgIKWkhY;
                this.__p_LAJ7uVB1lxVNo9YxbdlRcS = other.__p_LAJ7uVB1lxVNo9YxbdlRcS;
                this.__p_PZL4DBYNIvOOlUh1sc2ooo = other.__p_PZL4DBYNIvOOlUh1sc2ooo;
                this.__p_Kl8UMcKKRVgNi5fU9hwO6R = other.__p_Kl8UMcKKRVgNi5fU9hwO6R;
                this.__p_KmJxAGDsMWwOprew5xojDf = other.__p_KmJxAGDsMWwOprew5xojDf;
                this.__pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY = other.__pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY;
                this.v1 = other.v1;
                this.__pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm = other.__pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm;
                this.halfDT = other.halfDT;
                this.__pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo = other.__pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo;
                this.__pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS = other.__pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS;
                this.__pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R = other.__pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R;
                this.v2 = other.v2;
                this.__pin_group_Input_In_KmJxAGDsMWwOprew5xojDf = other.__pin_group_Input_In_KmJxAGDsMWwOprew5xojDf;
                this.__pin_group_Input_In_U1CZX007VoWPpfHilaI9E7 = other.__pin_group_Input_In_U1CZX007VoWPpfHilaI9E7;
                this.__pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v = other.__pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AcZOMERoriQQQVDfuVNB8v", in __p_AcZOMERoriQQQVDfuVNB8v), n1.CompilationHelper.GetValueOrExisting(values, "__p_U1CZX007VoWPpfHilaI9E7", in __p_U1CZX007VoWPpfHilaI9E7), n1.CompilationHelper.GetValueOrExisting(values, "__p_NOIgGXlXVLXNVRM8UFq0AY", in __p_NOIgGXlXVLXNVRM8UFq0AY), n1.CompilationHelper.GetValueOrExisting(values, "__p_RajwoHi7hqtQJVBvLotjtm", in __p_RajwoHi7hqtQJVBvLotjtm), n1.CompilationHelper.GetValueOrExisting(values, "__p_DX2RB2izD8xNgoSwrJtwBR", in __p_DX2RB2izD8xNgoSwrJtwBR), n1.CompilationHelper.GetValueOrExisting(values, "__p_FnkTI2n0H4RMZvOgIKWkhY", in __p_FnkTI2n0H4RMZvOgIKWkhY), n1.CompilationHelper.GetValueOrExisting(values, "__p_LAJ7uVB1lxVNo9YxbdlRcS", in __p_LAJ7uVB1lxVNo9YxbdlRcS), n1.CompilationHelper.GetValueOrExisting(values, "__p_PZL4DBYNIvOOlUh1sc2ooo", in __p_PZL4DBYNIvOOlUh1sc2ooo), n1.CompilationHelper.GetValueOrExisting(values, "__p_Kl8UMcKKRVgNi5fU9hwO6R", in __p_Kl8UMcKKRVgNi5fU9hwO6R), n1.CompilationHelper.GetValueOrExisting(values, "__p_KmJxAGDsMWwOprew5xojDf", in __p_KmJxAGDsMWwOprew5xojDf), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY", in __pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY), n1.CompilationHelper.GetValueOrExisting(values, "v1", in v1), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm", in __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm), n1.CompilationHelper.GetValueOrExisting(values, "halfDT", in halfDT), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo", in __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS", in __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R", in __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R), n1.CompilationHelper.GetValueOrExisting(values, "v2", in v2), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_KmJxAGDsMWwOprew5xojDf", in __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_U1CZX007VoWPpfHilaI9E7", in __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v", in __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v));
            }

            internal __K43AQ8l2cj9MNV99p30ndm __WITH__(n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_AcZOMERoriQQQVDfuVNB8v, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_U1CZX007VoWPpfHilaI9E7, n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T> __p_NOIgGXlXVLXNVRM8UFq0AY, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_RajwoHi7hqtQJVBvLotjtm, n14.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_DX2RB2izD8xNgoSwrJtwBR, n9.Invoke_C<T> __p_FnkTI2n0H4RMZvOgIKWkhY, n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_LAJ7uVB1lxVNo9YxbdlRcS, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_PZL4DBYNIvOOlUh1sc2ooo, n9.Invoke_C<T> __p_Kl8UMcKKRVgNi5fU9hwO6R, n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_KmJxAGDsMWwOprew5xojDf, n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY, n5.GpuValue<T> v1, n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm, n5.GpuValue<T> halfDT, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS, n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R, n5.GpuValue<T> v2, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v)
            {
                __K43AQ8l2cj9MNV99p30ndm that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_AcZOMERoriQQQVDfuVNB8v != this.__p_AcZOMERoriQQQVDfuVNB8v || __p_U1CZX007VoWPpfHilaI9E7 != this.__p_U1CZX007VoWPpfHilaI9E7 || __p_NOIgGXlXVLXNVRM8UFq0AY != this.__p_NOIgGXlXVLXNVRM8UFq0AY || __p_RajwoHi7hqtQJVBvLotjtm != this.__p_RajwoHi7hqtQJVBvLotjtm || __p_DX2RB2izD8xNgoSwrJtwBR != this.__p_DX2RB2izD8xNgoSwrJtwBR || __p_FnkTI2n0H4RMZvOgIKWkhY != this.__p_FnkTI2n0H4RMZvOgIKWkhY || __p_LAJ7uVB1lxVNo9YxbdlRcS != this.__p_LAJ7uVB1lxVNo9YxbdlRcS || __p_PZL4DBYNIvOOlUh1sc2ooo != this.__p_PZL4DBYNIvOOlUh1sc2ooo || __p_Kl8UMcKKRVgNi5fU9hwO6R != this.__p_Kl8UMcKKRVgNi5fU9hwO6R || __p_KmJxAGDsMWwOprew5xojDf != this.__p_KmJxAGDsMWwOprew5xojDf || __pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY != this.__pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY || v1 != this.v1 || __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm != this.__pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm || halfDT != this.halfDT || __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo != this.__pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo || __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS != this.__pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS || __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R != this.__pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R || v2 != this.v2 || __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf != this.__pin_group_Input_In_KmJxAGDsMWwOprew5xojDf || __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7 != this.__pin_group_Input_In_U1CZX007VoWPpfHilaI9E7 || __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v != this.__pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v ? new __K43AQ8l2cj9MNV99p30ndm(this)
                    {__p_AcZOMERoriQQQVDfuVNB8v = __p_AcZOMERoriQQQVDfuVNB8v, __p_U1CZX007VoWPpfHilaI9E7 = __p_U1CZX007VoWPpfHilaI9E7, __p_NOIgGXlXVLXNVRM8UFq0AY = __p_NOIgGXlXVLXNVRM8UFq0AY, __p_RajwoHi7hqtQJVBvLotjtm = __p_RajwoHi7hqtQJVBvLotjtm, __p_DX2RB2izD8xNgoSwrJtwBR = __p_DX2RB2izD8xNgoSwrJtwBR, __p_FnkTI2n0H4RMZvOgIKWkhY = __p_FnkTI2n0H4RMZvOgIKWkhY, __p_LAJ7uVB1lxVNo9YxbdlRcS = __p_LAJ7uVB1lxVNo9YxbdlRcS, __p_PZL4DBYNIvOOlUh1sc2ooo = __p_PZL4DBYNIvOOlUh1sc2ooo, __p_Kl8UMcKKRVgNi5fU9hwO6R = __p_Kl8UMcKKRVgNi5fU9hwO6R, __p_KmJxAGDsMWwOprew5xojDf = __p_KmJxAGDsMWwOprew5xojDf, __pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY = __pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY, v1 = v1, __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm = __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm, halfDT = halfDT, __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo = __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo, __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS = __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS, __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R = __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R, v2 = v2, __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf = __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf, __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7 = __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7, __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v = __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v} : that_0;
                else
                {
                    this.__p_AcZOMERoriQQQVDfuVNB8v = __p_AcZOMERoriQQQVDfuVNB8v;
                    this.__p_U1CZX007VoWPpfHilaI9E7 = __p_U1CZX007VoWPpfHilaI9E7;
                    this.__p_NOIgGXlXVLXNVRM8UFq0AY = __p_NOIgGXlXVLXNVRM8UFq0AY;
                    this.__p_RajwoHi7hqtQJVBvLotjtm = __p_RajwoHi7hqtQJVBvLotjtm;
                    this.__p_DX2RB2izD8xNgoSwrJtwBR = __p_DX2RB2izD8xNgoSwrJtwBR;
                    this.__p_FnkTI2n0H4RMZvOgIKWkhY = __p_FnkTI2n0H4RMZvOgIKWkhY;
                    this.__p_LAJ7uVB1lxVNo9YxbdlRcS = __p_LAJ7uVB1lxVNo9YxbdlRcS;
                    this.__p_PZL4DBYNIvOOlUh1sc2ooo = __p_PZL4DBYNIvOOlUh1sc2ooo;
                    this.__p_Kl8UMcKKRVgNi5fU9hwO6R = __p_Kl8UMcKKRVgNi5fU9hwO6R;
                    this.__p_KmJxAGDsMWwOprew5xojDf = __p_KmJxAGDsMWwOprew5xojDf;
                    this.__pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY = __pin_group_Parameters_In_FnkTI2n0H4RMZvOgIKWkhY;
                    this.v1 = v1;
                    this.__pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm = __pin_group_Input_In_RajwoHi7hqtQJVBvLotjtm;
                    this.halfDT = halfDT;
                    this.__pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo = __pin_group_Input_In_PZL4DBYNIvOOlUh1sc2ooo;
                    this.__pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS = __pin_group_Input_In_LAJ7uVB1lxVNo9YxbdlRcS;
                    this.__pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R = __pin_group_Parameters_In_Kl8UMcKKRVgNi5fU9hwO6R;
                    this.v2 = v2;
                    this.__pin_group_Input_In_KmJxAGDsMWwOprew5xojDf = __pin_group_Input_In_KmJxAGDsMWwOprew5xojDf;
                    this.__pin_group_Input_In_U1CZX007VoWPpfHilaI9E7 = __pin_group_Input_In_U1CZX007VoWPpfHilaI9E7;
                    this.__pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v = __pin_group_Input_In_AcZOMERoriQQQVDfuVNB8v;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 342808U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "DSAFnRSqCyxNuwkaNaqaDz", Name = "RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz")]
    [n2.SerializableAttribute]
    public class RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> CreateDefault()
        {
            var instance = new RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> Update(n5.GpuValue<T> Function_In, n5.GpuValue<T> Postion_In, n5.GpuValue<float> Step_Size_In, out n5.GpuValue<T> Output_Out)
        {
            bool __pad_BNVBxcGVUlGP5AMMfsu5Yy_0 = __slot_BNVBxcGVUlGP5AMMfsu5Yy;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_E9wImuOMxqaPvScmvambav;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_3 = (Function_In, Postion_In, Step_Size_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = __pad_BNVBxcGVUlGP5AMMfsu5Yy_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__OnH7aoAB0GNOnrgWuqK3rk>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __OnH7aoAB0GNOnrgWuqK3rk(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl = n11._Operations_.CreateDefault<n5.AbstractGpuValue>(), v1 = default(n5.GpuValue<T>), __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl = n11._Operations_.CreateDefault<n5.GpuValue<float>>(), halfDT = default(n5.GpuValue<T>), __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0 = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10 = n11._Operations_.CreateDefault<n5.AbstractGpuValue>(), v2 = default(n5.GpuValue<T>), __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34 = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12 = n11._Operations_.CreateDefault<n5.AbstractGpuValue>(), v3 = default(n5.GpuValue<T>), __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5 = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_JPoTRu2X387OESApBKSPqB = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd = n11._Operations_.CreateDefault<n5.AbstractGpuValue>(), v4 = default(n5.GpuValue<T>), __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "HxeqI6H6XjYM2eyySy2Jnl", 342838U);
                    var Output_8 = n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_7);
                    state_6.__p_HxeqI6H6XjYM2eyySy2Jnl = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "LysutlKts81P4BWcpodpHG", 342863U);
                    var Output_10 = n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T>.Create(Node_Context: Node_Context_9);
                    state_6.__p_LysutlKts81P4BWcpodpHG = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "DlLKeHzD54iLEnCwPrtFnl", 342880U);
                    var Output_12 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_11);
                    state_6.__p_DlLKeHzD54iLEnCwPrtFnl = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "F0dcwtNCRYZO5o1XPHCxZ6", 342900U);
                    var Output_14 = n14.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float>.Create(Node_Context: Node_Context_13);
                    state_6.__p_F0dcwtNCRYZO5o1XPHCxZ6 = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "OeTOsQCdVHHLw7m8QCKyTl", 342916U);
                    var Output_16 = n9.Invoke_C<T>.Create(Node_Context: Node_Context_15);
                    state_6.__p_OeTOsQCdVHHLw7m8QCKyTl = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "HVwroLANvLuPrSeAVbQPUf", 342933U);
                    var Output_18 = n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_17);
                    state_6.__p_HVwroLANvLuPrSeAVbQPUf = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "QkyeNiwJYl0M8e0EAwT6Z0", 342953U);
                    var Output_20 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_19);
                    state_6.__p_QkyeNiwJYl0M8e0EAwT6Z0 = Output_20;
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "BNDGL7QstGdOx5wygNTH10", 342977U);
                    var Output_22 = n9.Invoke_C<T>.Create(Node_Context: Node_Context_21);
                    state_6.__p_BNDGL7QstGdOx5wygNTH10 = Output_22;
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "QjC0Kt6gWWbLTaBa5c2Hyt", 342998U);
                    var Output_24 = n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_23);
                    state_6.__p_QjC0Kt6gWWbLTaBa5c2Hyt = Output_24;
                    n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "PuvZgtiHSyVMMJEihN0Q12", 343026U);
                    var Output_26 = n9.Invoke_C<T>.Create(Node_Context: Node_Context_25);
                    state_6.__p_PuvZgtiHSyVMMJEihN0Q12 = Output_26;
                    n1.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "TlKIgIXiPTOOMkrX94oG34", 343038U);
                    var Output_28 = n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_27);
                    state_6.__p_TlKIgIXiPTOOMkrX94oG34 = Output_28;
                    n1.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "MqPIE7O1KZ4OeaZcfjK4uD", 343059U);
                    var Output_30 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_29);
                    state_6.__p_MqPIE7O1KZ4OeaZcfjK4uD = Output_30;
                    n1.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "S35CuMd3s77LLD5pWUTTjd", 343090U);
                    var Output_32 = n9.Invoke_C<T>.Create(Node_Context: Node_Context_31);
                    state_6.__p_S35CuMd3s77LLD5pWUTTjd = Output_32;
                    n1.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "Hx2yD4C5PtVNk8WOpcxHvc", 343114U);
                    var Output_34 = n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_33);
                    state_6.__p_Hx2yD4C5PtVNk8WOpcxHvc = Output_34;
                    n1.NodeContext Node_Context_35 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "JPoTRu2X387OESApBKSPqB", 343138U);
                    var Output_36 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_35);
                    state_6.__p_JPoTRu2X387OESApBKSPqB = Output_36;
                    n1.NodeContext Node_Context_37 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "Ou5wh0yRU0OO9nNnXpC3Xq", 343160U);
                    var Output_38 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_37);
                    state_6.__p_Ou5wh0yRU0OO9nNnXpC3Xq = Output_38;
                    n1.NodeContext Node_Context_39 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "CctoH99q7kKOfXXOJWW0Y1", 343175U);
                    var Output_40 = n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T>.Create(Node_Context: Node_Context_39);
                    state_6.__p_CctoH99q7kKOfXXOJWW0Y1 = Output_40;
                    n1.NodeContext Node_Context_41 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "CqDYcJDI9viM8e7ObCmVgq", 343188U);
                    var Output_42 = n14.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float>.Create(Node_Context: Node_Context_41);
                    state_6.__p_CqDYcJDI9viM8e7ObCmVgq = Output_42;
                    n1.NodeContext Node_Context_43 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "GO2M0dKfRQbO4ZIVyorEb5", 343206U);
                    var Output_44 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_43);
                    state_6.__p_GO2M0dKfRQbO4ZIVyorEb5 = Output_44;
                    n1.NodeContext Node_Context_45 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "AssFJ8QAApgOAT4nfzjfFB", 343223U);
                    var Output_46 = n7.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<T>.Create(Node_Context: Node_Context_45);
                    state_6.__p_AssFJ8QAApgOAT4nfzjfFB = Output_46;
                    n1.NodeContext Node_Context_47 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "K2mGzUL22l1Owz3uk4KUtU", 343240U);
                    var Output_48 = n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T>.Create(Node_Context: Node_Context_47);
                    state_6.__p_K2mGzUL22l1Owz3uk4KUtU = Output_48;
                    n1.NodeContext Node_Context_49 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "FhGBQZjiNS6L0UWGNqKnYY", 343255U);
                    var Output_50 = n14.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float>.Create(Node_Context: Node_Context_49);
                    state_6.__p_FhGBQZjiNS6L0UWGNqKnYY = Output_50;
                    n1.NodeContext Node_Context_51 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "GatahvM1ph1LJ498dpfu5Y", 343273U);
                    var Output_52 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_51);
                    state_6.__p_GatahvM1ph1LJ498dpfu5Y = Output_52;
                    n1.NodeContext Node_Context_53 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "BsBoOlqNeXqQDdQF6BdPzQ", 343287U);
                    var Output_54 = n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T>.Create(Node_Context: Node_Context_53);
                    state_6.__p_BsBoOlqNeXqQDdQF6BdPzQ = Output_54;
                }

                float __pad_RthdKXyQlxPL68s4K0rebt_55 = __slot_RthdKXyQlxPL68s4K0rebt;
                float __pad_LRF4mziKOAnL4iMeNUD2sE_56 = __slot_LRF4mziKOAnL4iMeNUD2sE;
                float __pad_Sh0Si9fpxMULFSadJHUyRs_57 = __slot_Sh0Si9fpxMULFSadJHUyRs;
                var builder_58 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl, 1);
                builder_58.Add(Postion_In);
                var __pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl_59 = builder_58.Commit();
                var State_Output_61 = state_6.__p_OeTOsQCdVHHLw7m8QCKyTl.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl_59, Output_Out: out n5.GpuValue<T> Output_60);
                n5.GpuValue<T> __auto_62 = Output_60;
                var State_Output_64 = state_6.__p_F0dcwtNCRYZO5o1XPHCxZ6.Update(The_Value_In: __pad_RthdKXyQlxPL68s4K0rebt_55, Output_Out: out n5.ConstantValue<float> Output_63);
                var builder_65 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl, 2);
                builder_65.Add(Step_Size_In);
                builder_65.Add(Output_63);
                var __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl_66 = builder_65.Commit();
                var State_Output_68 = state_6.__p_DlLKeHzD54iLEnCwPrtFnl.Update(Input_In: __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl_66, Output_Out: out n5.GpuValue<float> Output_67);
                var State_Output_70 = state_6.__p_LysutlKts81P4BWcpodpHG.Update(value_In: Output_67, Output_Out: out n5.GpuValue<T> Output_69);
                n5.GpuValue<T> __auto_71 = Output_69;
                var builder_72 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0, 2);
                builder_72.Add(__auto_62);
                builder_72.Add(__auto_71);
                var __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0_73 = builder_72.Commit();
                var State_Output_75 = state_6.__p_QkyeNiwJYl0M8e0EAwT6Z0.Update(Input_In: __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0_73, Output_Out: out n5.GpuValue<T> Output_74);
                var builder_76 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf, 2);
                builder_76.Add(Output_74);
                builder_76.Add(Postion_In);
                var __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf_77 = builder_76.Commit();
                var State_Output_79 = state_6.__p_HVwroLANvLuPrSeAVbQPUf.Update(Input_In: __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf_77, Output_Out: out n5.GpuValue<T> Output_78);
                var builder_80 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10, 1);
                builder_80.Add(Output_78);
                var __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10_81 = builder_80.Commit();
                var State_Output_83 = state_6.__p_BNDGL7QstGdOx5wygNTH10.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10_81, Output_Out: out n5.GpuValue<T> Output_82);
                n5.GpuValue<T> __auto_84 = Output_82;
                var State_Output_86 = state_6.__p_CqDYcJDI9viM8e7ObCmVgq.Update(The_Value_In: __pad_Sh0Si9fpxMULFSadJHUyRs_57, Output_Out: out n5.ConstantValue<float> Output_85);
                var State_Output_88 = state_6.__p_CctoH99q7kKOfXXOJWW0Y1.Update(value_In: Output_85, Output_Out: out n5.GpuValue<T> Output_87);
                var builder_89 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq, 2);
                builder_89.Add(__auto_84);
                builder_89.Add(Output_87);
                var __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq_90 = builder_89.Commit();
                var State_Output_92 = state_6.__p_Ou5wh0yRU0OO9nNnXpC3Xq.Update(Input_In: __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq_90, Output_Out: out n5.GpuValue<T> Output_91);
                var builder_93 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD, 2);
                builder_93.Add(__auto_84);
                builder_93.Add(__auto_71);
                var __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD_94 = builder_93.Commit();
                var State_Output_96 = state_6.__p_MqPIE7O1KZ4OeaZcfjK4uD.Update(Input_In: __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD_94, Output_Out: out n5.GpuValue<T> Output_95);
                var builder_97 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34, 2);
                builder_97.Add(Output_95);
                builder_97.Add(Postion_In);
                var __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34_98 = builder_97.Commit();
                var State_Output_100 = state_6.__p_TlKIgIXiPTOOMkrX94oG34.Update(Input_In: __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34_98, Output_Out: out n5.GpuValue<T> Output_99);
                var builder_101 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12, 1);
                builder_101.Add(Output_99);
                var __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12_102 = builder_101.Commit();
                var State_Output_104 = state_6.__p_PuvZgtiHSyVMMJEihN0Q12.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12_102, Output_Out: out n5.GpuValue<T> Output_103);
                n5.GpuValue<T> __auto_105 = Output_103;
                var builder_106 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5, 2);
                builder_106.Add(__auto_105);
                builder_106.Add(Output_87);
                var __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5_107 = builder_106.Commit();
                var State_Output_109 = state_6.__p_GO2M0dKfRQbO4ZIVyorEb5.Update(Input_In: __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5_107, Output_Out: out n5.GpuValue<T> Output_108);
                var State_Output_111 = state_6.__p_BsBoOlqNeXqQDdQF6BdPzQ.Update(value_In: Step_Size_In, Output_Out: out n5.GpuValue<T> Output_110);
                var builder_112 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_JPoTRu2X387OESApBKSPqB, 2);
                builder_112.Add(__auto_105);
                builder_112.Add(Output_110);
                var __pin_group_Input_In_JPoTRu2X387OESApBKSPqB_113 = builder_112.Commit();
                var State_Output_115 = state_6.__p_JPoTRu2X387OESApBKSPqB.Update(Input_In: __pin_group_Input_In_JPoTRu2X387OESApBKSPqB_113, Output_Out: out n5.GpuValue<T> Output_114);
                var builder_116 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc, 2);
                builder_116.Add(Output_114);
                builder_116.Add(Postion_In);
                var __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc_117 = builder_116.Commit();
                var State_Output_119 = state_6.__p_Hx2yD4C5PtVNk8WOpcxHvc.Update(Input_In: __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc_117, Output_Out: out n5.GpuValue<T> Output_118);
                var builder_120 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd, 1);
                builder_120.Add(Output_118);
                var __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd_121 = builder_120.Commit();
                var State_Output_123 = state_6.__p_S35CuMd3s77LLD5pWUTTjd.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd_121, Output_Out: out n5.GpuValue<T> Output_122);
                n5.GpuValue<T> __auto_124 = Output_122;
                var builder_125 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt, 4);
                builder_125.Add(__auto_62);
                builder_125.Add(Output_91);
                builder_125.Add(Output_108);
                builder_125.Add(__auto_124);
                var __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt_126 = builder_125.Commit();
                var State_Output_128 = state_6.__p_QjC0Kt6gWWbLTaBa5c2Hyt.Update(Input_In: __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt_126, Output_Out: out n5.GpuValue<T> Output_127);
                var State_Output_130 = state_6.__p_FhGBQZjiNS6L0UWGNqKnYY.Update(The_Value_In: __pad_LRF4mziKOAnL4iMeNUD2sE_56, Output_Out: out n5.ConstantValue<float> Output_129);
                var State_Output_132 = state_6.__p_K2mGzUL22l1Owz3uk4KUtU.Update(value_In: Output_129, Output_Out: out n5.GpuValue<T> Output_131);
                var builder_133 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB, 2);
                builder_133.Add(Output_127);
                builder_133.Add(Output_131);
                var __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB_134 = builder_133.Commit();
                var State_Output_136 = state_6.__p_AssFJ8QAApgOAT4nfzjfFB.Update(Input_In: __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB_134, Output_Out: out n5.GpuValue<T> Output_135);
                var builder_137 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y, 2);
                builder_137.Add(Output_135);
                builder_137.Add(Output_110);
                var __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y_138 = builder_137.Commit();
                var State_Output_140 = state_6.__p_GatahvM1ph1LJ498dpfu5Y.Update(Input_In: __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y_138, Output_Out: out n5.GpuValue<T> Output_139);
                var builder_141 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl, 2);
                builder_141.Add(Output_139);
                builder_141.Add(Postion_In);
                var __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl_142 = builder_141.Commit();
                var State_Output_144 = state_6.__p_HxeqI6H6XjYM2eyySy2Jnl.Update(Input_In: __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl_142, Output_Out: out n5.GpuValue<T> Output_143);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = __pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl_59 != state_6.__pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl || State_Output_61 != state_6.__p_OeTOsQCdVHHLw7m8QCKyTl || Output_60 != state_6.v1 || State_Output_64 != state_6.__p_F0dcwtNCRYZO5o1XPHCxZ6 || __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl_66 != state_6.__pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl || State_Output_68 != state_6.__p_DlLKeHzD54iLEnCwPrtFnl || State_Output_70 != state_6.__p_LysutlKts81P4BWcpodpHG || Output_69 != state_6.halfDT || __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0_73 != state_6.__pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0 || State_Output_75 != state_6.__p_QkyeNiwJYl0M8e0EAwT6Z0 || __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf_77 != state_6.__pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf || State_Output_79 != state_6.__p_HVwroLANvLuPrSeAVbQPUf || __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10_81 != state_6.__pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10 || State_Output_83 != state_6.__p_BNDGL7QstGdOx5wygNTH10 || Output_82 != state_6.v2 || State_Output_86 != state_6.__p_CqDYcJDI9viM8e7ObCmVgq || State_Output_88 != state_6.__p_CctoH99q7kKOfXXOJWW0Y1 || __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq_90 != state_6.__pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq || State_Output_92 != state_6.__p_Ou5wh0yRU0OO9nNnXpC3Xq || __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD_94 != state_6.__pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD || State_Output_96 != state_6.__p_MqPIE7O1KZ4OeaZcfjK4uD || __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34_98 != state_6.__pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34 || State_Output_100 != state_6.__p_TlKIgIXiPTOOMkrX94oG34 || __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12_102 != state_6.__pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12 || State_Output_104 != state_6.__p_PuvZgtiHSyVMMJEihN0Q12 || Output_103 != state_6.v3 || __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5_107 != state_6.__pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5 || State_Output_109 != state_6.__p_GO2M0dKfRQbO4ZIVyorEb5 || State_Output_111 != state_6.__p_BsBoOlqNeXqQDdQF6BdPzQ || __pin_group_Input_In_JPoTRu2X387OESApBKSPqB_113 != state_6.__pin_group_Input_In_JPoTRu2X387OESApBKSPqB || State_Output_115 != state_6.__p_JPoTRu2X387OESApBKSPqB || __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc_117 != state_6.__pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc || State_Output_119 != state_6.__p_Hx2yD4C5PtVNk8WOpcxHvc || __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd_121 != state_6.__pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd || State_Output_123 != state_6.__p_S35CuMd3s77LLD5pWUTTjd || Output_122 != state_6.v4 || __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt_126 != state_6.__pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt || State_Output_128 != state_6.__p_QjC0Kt6gWWbLTaBa5c2Hyt || State_Output_130 != state_6.__p_FhGBQZjiNS6L0UWGNqKnYY || State_Output_132 != state_6.__p_K2mGzUL22l1Owz3uk4KUtU || __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB_134 != state_6.__pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB || State_Output_136 != state_6.__p_AssFJ8QAApgOAT4nfzjfFB || __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y_138 != state_6.__pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y || State_Output_140 != state_6.__p_GatahvM1ph1LJ498dpfu5Y || __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl_142 != state_6.__pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl || State_Output_144 != state_6.__p_HxeqI6H6XjYM2eyySy2Jnl ? new __OnH7aoAB0GNOnrgWuqK3rk(state_6)
                    {__pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl = __pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl_59, __p_OeTOsQCdVHHLw7m8QCKyTl = State_Output_61, v1 = Output_60, __p_F0dcwtNCRYZO5o1XPHCxZ6 = State_Output_64, __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl = __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl_66, __p_DlLKeHzD54iLEnCwPrtFnl = State_Output_68, __p_LysutlKts81P4BWcpodpHG = State_Output_70, halfDT = Output_69, __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0 = __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0_73, __p_QkyeNiwJYl0M8e0EAwT6Z0 = State_Output_75, __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf = __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf_77, __p_HVwroLANvLuPrSeAVbQPUf = State_Output_79, __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10 = __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10_81, __p_BNDGL7QstGdOx5wygNTH10 = State_Output_83, v2 = Output_82, __p_CqDYcJDI9viM8e7ObCmVgq = State_Output_86, __p_CctoH99q7kKOfXXOJWW0Y1 = State_Output_88, __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq = __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq_90, __p_Ou5wh0yRU0OO9nNnXpC3Xq = State_Output_92, __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD = __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD_94, __p_MqPIE7O1KZ4OeaZcfjK4uD = State_Output_96, __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34 = __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34_98, __p_TlKIgIXiPTOOMkrX94oG34 = State_Output_100, __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12 = __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12_102, __p_PuvZgtiHSyVMMJEihN0Q12 = State_Output_104, v3 = Output_103, __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5 = __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5_107, __p_GO2M0dKfRQbO4ZIVyorEb5 = State_Output_109, __p_BsBoOlqNeXqQDdQF6BdPzQ = State_Output_111, __pin_group_Input_In_JPoTRu2X387OESApBKSPqB = __pin_group_Input_In_JPoTRu2X387OESApBKSPqB_113, __p_JPoTRu2X387OESApBKSPqB = State_Output_115, __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc = __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc_117, __p_Hx2yD4C5PtVNk8WOpcxHvc = State_Output_119, __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd = __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd_121, __p_S35CuMd3s77LLD5pWUTTjd = State_Output_123, v4 = Output_122, __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt = __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt_126, __p_QjC0Kt6gWWbLTaBa5c2Hyt = State_Output_128, __p_FhGBQZjiNS6L0UWGNqKnYY = State_Output_130, __p_K2mGzUL22l1Owz3uk4KUtU = State_Output_132, __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB = __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB_134, __p_AssFJ8QAApgOAT4nfzjfFB = State_Output_136, __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y = __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y_138, __p_GatahvM1ph1LJ498dpfu5Y = State_Output_140, __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl = __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl_142, __p_HxeqI6H6XjYM2eyySy2Jnl = State_Output_144} : state_6;
                else
                {
                    state_6.__pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl = __pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl_59;
                    state_6.__p_OeTOsQCdVHHLw7m8QCKyTl = State_Output_61;
                    state_6.v1 = Output_60;
                    state_6.__p_F0dcwtNCRYZO5o1XPHCxZ6 = State_Output_64;
                    state_6.__pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl = __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl_66;
                    state_6.__p_DlLKeHzD54iLEnCwPrtFnl = State_Output_68;
                    state_6.__p_LysutlKts81P4BWcpodpHG = State_Output_70;
                    state_6.halfDT = Output_69;
                    state_6.__pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0 = __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0_73;
                    state_6.__p_QkyeNiwJYl0M8e0EAwT6Z0 = State_Output_75;
                    state_6.__pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf = __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf_77;
                    state_6.__p_HVwroLANvLuPrSeAVbQPUf = State_Output_79;
                    state_6.__pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10 = __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10_81;
                    state_6.__p_BNDGL7QstGdOx5wygNTH10 = State_Output_83;
                    state_6.v2 = Output_82;
                    state_6.__p_CqDYcJDI9viM8e7ObCmVgq = State_Output_86;
                    state_6.__p_CctoH99q7kKOfXXOJWW0Y1 = State_Output_88;
                    state_6.__pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq = __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq_90;
                    state_6.__p_Ou5wh0yRU0OO9nNnXpC3Xq = State_Output_92;
                    state_6.__pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD = __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD_94;
                    state_6.__p_MqPIE7O1KZ4OeaZcfjK4uD = State_Output_96;
                    state_6.__pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34 = __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34_98;
                    state_6.__p_TlKIgIXiPTOOMkrX94oG34 = State_Output_100;
                    state_6.__pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12 = __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12_102;
                    state_6.__p_PuvZgtiHSyVMMJEihN0Q12 = State_Output_104;
                    state_6.v3 = Output_103;
                    state_6.__pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5 = __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5_107;
                    state_6.__p_GO2M0dKfRQbO4ZIVyorEb5 = State_Output_109;
                    state_6.__p_BsBoOlqNeXqQDdQF6BdPzQ = State_Output_111;
                    state_6.__pin_group_Input_In_JPoTRu2X387OESApBKSPqB = __pin_group_Input_In_JPoTRu2X387OESApBKSPqB_113;
                    state_6.__p_JPoTRu2X387OESApBKSPqB = State_Output_115;
                    state_6.__pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc = __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc_117;
                    state_6.__p_Hx2yD4C5PtVNk8WOpcxHvc = State_Output_119;
                    state_6.__pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd = __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd_121;
                    state_6.__p_S35CuMd3s77LLD5pWUTTjd = State_Output_123;
                    state_6.v4 = Output_122;
                    state_6.__pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt = __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt_126;
                    state_6.__p_QjC0Kt6gWWbLTaBa5c2Hyt = State_Output_128;
                    state_6.__p_FhGBQZjiNS6L0UWGNqKnYY = State_Output_130;
                    state_6.__p_K2mGzUL22l1Owz3uk4KUtU = State_Output_132;
                    state_6.__pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB = __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB_134;
                    state_6.__p_AssFJ8QAApgOAT4nfzjfFB = State_Output_136;
                    state_6.__pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y = __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y_138;
                    state_6.__p_GatahvM1ph1LJ498dpfu5Y = State_Output_140;
                    state_6.__pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl = __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl_142;
                    state_6.__p_HxeqI6H6XjYM2eyySy2Jnl = State_Output_144;
                }

                outputs_4 = n2.ValueTuple.Create(Output_143);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_145 = outputs_4.Item1;
            Output_Out = __auto_145;
            n3.RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> that_146 = this;
            if (this.__GetContext__().IsImmutable)
                that_146 = manager_2 != this.__cache_E9wImuOMxqaPvScmvambav ? new RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T>(this)
                {__cache_E9wImuOMxqaPvScmvambav = manager_2} : that_146;
            else
            {
                this.__cache_E9wImuOMxqaPvScmvambav = manager_2;
            }

            return that_146;
        }

        public n3.RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> that_0 = this;
            this.__cache_E9wImuOMxqaPvScmvambav = null;
            return that_0;
        }

        public n3.RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> __CreateDefault__()
        {
            n3.RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> that_0 = this;
            this.__cache_E9wImuOMxqaPvScmvambav = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_E9wImuOMxqaPvScmvambav);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 343315U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "NqSh3qD5G45MEjF0Znnf1Q", Name = "__slot_NqSh3qD5G45MEjF0Znnf1Q")]
        public static string __slot_NqSh3qD5G45MEjF0Znnf1Q = "// Runge-Kutta 4\r\n\r\n#define calcRK4V2(f, p, dT)\t\t\t\t\t\t\t\t\r\n\tfloat halfDT= dT * 0.5;\t\t\t\t\t\t\r\n\tfloat2 v1= f(p);\t\t\t\t\t\t\t\t\r\n\tfloat2 v2= f(p + v1* halfDT);\t\t\t\r\n\tfloat2 v3= f(p + v2* halfDT);\t\t\t\r\n\tfloat2 v4= f(p + v3* dT);\t\t\t\t\t\r\n\tp += (v1+ v2*2 + v3*2 + v4)/6 *dT ";
        [n1.ElementAttribute(TracingId = 343322U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "BNVBxcGVUlGP5AMMfsu5Yy", Name = "__slot_BNVBxcGVUlGP5AMMfsu5Yy")]
        public static bool __slot_BNVBxcGVUlGP5AMMfsu5Yy = false;
        [n1.ElementAttribute(TracingId = 342811U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "E9wImuOMxqaPvScmvambav", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_E9wImuOMxqaPvScmvambav = null;
        [n1.ElementAttribute(TracingId = 342912U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "RthdKXyQlxPL68s4K0rebt", Name = "__slot_RthdKXyQlxPL68s4K0rebt")]
        public static float __slot_RthdKXyQlxPL68s4K0rebt = 0.5F;
        [n1.ElementAttribute(TracingId = 343265U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "LRF4mziKOAnL4iMeNUD2sE", Name = "__slot_LRF4mziKOAnL4iMeNUD2sE")]
        public static float __slot_LRF4mziKOAnL4iMeNUD2sE = 6F;
        [n1.ElementAttribute(TracingId = 343201U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Sh0Si9fpxMULFSadJHUyRs", Name = "__slot_Sh0Si9fpxMULFSadJHUyRs")]
        public static float __slot_Sh0Si9fpxMULFSadJHUyRs = 2F;
        static RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz()
        {
        }

        public RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz(RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> other): base(other)
        {
            this.__cache_E9wImuOMxqaPvScmvambav = other.__cache_E9wImuOMxqaPvScmvambav;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_E9wImuOMxqaPvScmvambav", in __cache_E9wImuOMxqaPvScmvambav));
        }

        internal RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_E9wImuOMxqaPvScmvambav)
        {
            n3.RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_E9wImuOMxqaPvScmvambav != this.__cache_E9wImuOMxqaPvScmvambav ? new RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T>(this)
                {__cache_E9wImuOMxqaPvScmvambav = __cache_E9wImuOMxqaPvScmvambav} : that_0;
            else
            {
                this.__cache_E9wImuOMxqaPvScmvambav = __cache_E9wImuOMxqaPvScmvambav;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "OnH7aoAB0GNOnrgWuqK3rk", Name = "__OnH7aoAB0GNOnrgWuqK3rk")]
        [n2.SerializableAttribute]
        public class __OnH7aoAB0GNOnrgWuqK3rk : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_HxeqI6H6XjYM2eyySy2Jnl);
                n1.CompilationHelper.SafeDispose(this.__p_LysutlKts81P4BWcpodpHG);
                n1.CompilationHelper.SafeDispose(this.__p_DlLKeHzD54iLEnCwPrtFnl);
                n1.CompilationHelper.SafeDispose(this.__p_F0dcwtNCRYZO5o1XPHCxZ6);
                n1.CompilationHelper.SafeDispose(this.__p_OeTOsQCdVHHLw7m8QCKyTl);
                n1.CompilationHelper.SafeDispose(this.__p_HVwroLANvLuPrSeAVbQPUf);
                n1.CompilationHelper.SafeDispose(this.__p_QkyeNiwJYl0M8e0EAwT6Z0);
                n1.CompilationHelper.SafeDispose(this.__p_BNDGL7QstGdOx5wygNTH10);
                n1.CompilationHelper.SafeDispose(this.__p_QjC0Kt6gWWbLTaBa5c2Hyt);
                n1.CompilationHelper.SafeDispose(this.__p_PuvZgtiHSyVMMJEihN0Q12);
                n1.CompilationHelper.SafeDispose(this.__p_TlKIgIXiPTOOMkrX94oG34);
                n1.CompilationHelper.SafeDispose(this.__p_MqPIE7O1KZ4OeaZcfjK4uD);
                n1.CompilationHelper.SafeDispose(this.__p_S35CuMd3s77LLD5pWUTTjd);
                n1.CompilationHelper.SafeDispose(this.__p_Hx2yD4C5PtVNk8WOpcxHvc);
                n1.CompilationHelper.SafeDispose(this.__p_JPoTRu2X387OESApBKSPqB);
                n1.CompilationHelper.SafeDispose(this.__p_Ou5wh0yRU0OO9nNnXpC3Xq);
                n1.CompilationHelper.SafeDispose(this.__p_CctoH99q7kKOfXXOJWW0Y1);
                n1.CompilationHelper.SafeDispose(this.__p_CqDYcJDI9viM8e7ObCmVgq);
                n1.CompilationHelper.SafeDispose(this.__p_GO2M0dKfRQbO4ZIVyorEb5);
                n1.CompilationHelper.SafeDispose(this.__p_AssFJ8QAApgOAT4nfzjfFB);
                n1.CompilationHelper.SafeDispose(this.__p_K2mGzUL22l1Owz3uk4KUtU);
                n1.CompilationHelper.SafeDispose(this.__p_FhGBQZjiNS6L0UWGNqKnYY);
                n1.CompilationHelper.SafeDispose(this.__p_GatahvM1ph1LJ498dpfu5Y);
                n1.CompilationHelper.SafeDispose(this.__p_BsBoOlqNeXqQDdQF6BdPzQ);
                return;
            }

            [n1.ElementAttribute(TracingId = 342838U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "HxeqI6H6XjYM2eyySy2Jnl", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_HxeqI6H6XjYM2eyySy2Jnl;
            [n1.ElementAttribute(TracingId = 342863U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "LysutlKts81P4BWcpodpHG", Name = "FromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T> __p_LysutlKts81P4BWcpodpHG;
            [n1.ElementAttribute(TracingId = 342880U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "DlLKeHzD54iLEnCwPrtFnl", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_DlLKeHzD54iLEnCwPrtFnl;
            [n1.ElementAttribute(TracingId = 342900U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "F0dcwtNCRYZO5o1XPHCxZ6", Name = "ConstantFromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n14.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_F0dcwtNCRYZO5o1XPHCxZ6;
            [n1.ElementAttribute(TracingId = 342916U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "OeTOsQCdVHHLw7m8QCKyTl", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n9.Invoke_C<T> __p_OeTOsQCdVHHLw7m8QCKyTl;
            [n1.ElementAttribute(TracingId = 342933U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "HVwroLANvLuPrSeAVbQPUf", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_HVwroLANvLuPrSeAVbQPUf;
            [n1.ElementAttribute(TracingId = 342953U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "QkyeNiwJYl0M8e0EAwT6Z0", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_QkyeNiwJYl0M8e0EAwT6Z0;
            [n1.ElementAttribute(TracingId = 342977U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "BNDGL7QstGdOx5wygNTH10", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n9.Invoke_C<T> __p_BNDGL7QstGdOx5wygNTH10;
            [n1.ElementAttribute(TracingId = 342998U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "QjC0Kt6gWWbLTaBa5c2Hyt", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_QjC0Kt6gWWbLTaBa5c2Hyt;
            [n1.ElementAttribute(TracingId = 343026U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "PuvZgtiHSyVMMJEihN0Q12", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n9.Invoke_C<T> __p_PuvZgtiHSyVMMJEihN0Q12;
            [n1.ElementAttribute(TracingId = 343038U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "TlKIgIXiPTOOMkrX94oG34", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_TlKIgIXiPTOOMkrX94oG34;
            [n1.ElementAttribute(TracingId = 343059U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "MqPIE7O1KZ4OeaZcfjK4uD", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_MqPIE7O1KZ4OeaZcfjK4uD;
            [n1.ElementAttribute(TracingId = 343090U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "S35CuMd3s77LLD5pWUTTjd", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n9.Invoke_C<T> __p_S35CuMd3s77LLD5pWUTTjd;
            [n1.ElementAttribute(TracingId = 343114U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Hx2yD4C5PtVNk8WOpcxHvc", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_Hx2yD4C5PtVNk8WOpcxHvc;
            [n1.ElementAttribute(TracingId = 343138U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "JPoTRu2X387OESApBKSPqB", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_JPoTRu2X387OESApBKSPqB;
            [n1.ElementAttribute(TracingId = 343160U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Ou5wh0yRU0OO9nNnXpC3Xq", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_Ou5wh0yRU0OO9nNnXpC3Xq;
            [n1.ElementAttribute(TracingId = 343175U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "CctoH99q7kKOfXXOJWW0Y1", Name = "FromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T> __p_CctoH99q7kKOfXXOJWW0Y1;
            [n1.ElementAttribute(TracingId = 343188U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "CqDYcJDI9viM8e7ObCmVgq", Name = "ConstantFromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n14.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_CqDYcJDI9viM8e7ObCmVgq;
            [n1.ElementAttribute(TracingId = 343206U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "GO2M0dKfRQbO4ZIVyorEb5", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_GO2M0dKfRQbO4ZIVyorEb5;
            [n1.ElementAttribute(TracingId = 343223U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "AssFJ8QAApgOAT4nfzjfFB", Name = "/", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<T> __p_AssFJ8QAApgOAT4nfzjfFB;
            [n1.ElementAttribute(TracingId = 343240U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "K2mGzUL22l1Owz3uk4KUtU", Name = "FromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T> __p_K2mGzUL22l1Owz3uk4KUtU;
            [n1.ElementAttribute(TracingId = 343255U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "FhGBQZjiNS6L0UWGNqKnYY", Name = "ConstantFromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n14.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_FhGBQZjiNS6L0UWGNqKnYY;
            [n1.ElementAttribute(TracingId = 343273U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "GatahvM1ph1LJ498dpfu5Y", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_GatahvM1ph1LJ498dpfu5Y;
            [n1.ElementAttribute(TracingId = 343287U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "BsBoOlqNeXqQDdQF6BdPzQ", Name = "FromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T> __p_BsBoOlqNeXqQDdQF6BdPzQ;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl = default(n10.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(TracingId = 342991U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "ERvxPUgQ0h6MffhOpBjkIk", Name = "v1")]
            public n5.GpuValue<T> v1;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl = default(n10.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(TracingId = 342997U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "PalOvqPzBBmPQjaRqlf67n", Name = "halfDT")]
            public n5.GpuValue<T> halfDT;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0 = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10 = default(n10.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(TracingId = 342993U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "H3EULFxjo8AQVcs4GibNa2", Name = "v2")]
            public n5.GpuValue<T> v2;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34 = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12 = default(n10.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(TracingId = 343021U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "VD7nsBrjNZJOxpP95cO3R2", Name = "v3")]
            public n5.GpuValue<T> v3;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5 = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_JPoTRu2X387OESApBKSPqB = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd = default(n10.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(TracingId = 343087U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "RzzXAbGqr3WP8sV8zzNwre", Name = "v4")]
            public n5.GpuValue<T> v4;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl = default(n10.Spread<n5.GpuValue<T>>);
            public __OnH7aoAB0GNOnrgWuqK3rk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __OnH7aoAB0GNOnrgWuqK3rk(__OnH7aoAB0GNOnrgWuqK3rk other): base(other)
            {
                this.__p_HxeqI6H6XjYM2eyySy2Jnl = other.__p_HxeqI6H6XjYM2eyySy2Jnl;
                this.__p_LysutlKts81P4BWcpodpHG = other.__p_LysutlKts81P4BWcpodpHG;
                this.__p_DlLKeHzD54iLEnCwPrtFnl = other.__p_DlLKeHzD54iLEnCwPrtFnl;
                this.__p_F0dcwtNCRYZO5o1XPHCxZ6 = other.__p_F0dcwtNCRYZO5o1XPHCxZ6;
                this.__p_OeTOsQCdVHHLw7m8QCKyTl = other.__p_OeTOsQCdVHHLw7m8QCKyTl;
                this.__p_HVwroLANvLuPrSeAVbQPUf = other.__p_HVwroLANvLuPrSeAVbQPUf;
                this.__p_QkyeNiwJYl0M8e0EAwT6Z0 = other.__p_QkyeNiwJYl0M8e0EAwT6Z0;
                this.__p_BNDGL7QstGdOx5wygNTH10 = other.__p_BNDGL7QstGdOx5wygNTH10;
                this.__p_QjC0Kt6gWWbLTaBa5c2Hyt = other.__p_QjC0Kt6gWWbLTaBa5c2Hyt;
                this.__p_PuvZgtiHSyVMMJEihN0Q12 = other.__p_PuvZgtiHSyVMMJEihN0Q12;
                this.__p_TlKIgIXiPTOOMkrX94oG34 = other.__p_TlKIgIXiPTOOMkrX94oG34;
                this.__p_MqPIE7O1KZ4OeaZcfjK4uD = other.__p_MqPIE7O1KZ4OeaZcfjK4uD;
                this.__p_S35CuMd3s77LLD5pWUTTjd = other.__p_S35CuMd3s77LLD5pWUTTjd;
                this.__p_Hx2yD4C5PtVNk8WOpcxHvc = other.__p_Hx2yD4C5PtVNk8WOpcxHvc;
                this.__p_JPoTRu2X387OESApBKSPqB = other.__p_JPoTRu2X387OESApBKSPqB;
                this.__p_Ou5wh0yRU0OO9nNnXpC3Xq = other.__p_Ou5wh0yRU0OO9nNnXpC3Xq;
                this.__p_CctoH99q7kKOfXXOJWW0Y1 = other.__p_CctoH99q7kKOfXXOJWW0Y1;
                this.__p_CqDYcJDI9viM8e7ObCmVgq = other.__p_CqDYcJDI9viM8e7ObCmVgq;
                this.__p_GO2M0dKfRQbO4ZIVyorEb5 = other.__p_GO2M0dKfRQbO4ZIVyorEb5;
                this.__p_AssFJ8QAApgOAT4nfzjfFB = other.__p_AssFJ8QAApgOAT4nfzjfFB;
                this.__p_K2mGzUL22l1Owz3uk4KUtU = other.__p_K2mGzUL22l1Owz3uk4KUtU;
                this.__p_FhGBQZjiNS6L0UWGNqKnYY = other.__p_FhGBQZjiNS6L0UWGNqKnYY;
                this.__p_GatahvM1ph1LJ498dpfu5Y = other.__p_GatahvM1ph1LJ498dpfu5Y;
                this.__p_BsBoOlqNeXqQDdQF6BdPzQ = other.__p_BsBoOlqNeXqQDdQF6BdPzQ;
                this.__pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl = other.__pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl;
                this.v1 = other.v1;
                this.__pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl = other.__pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl;
                this.halfDT = other.halfDT;
                this.__pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0 = other.__pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0;
                this.__pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf = other.__pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf;
                this.__pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10 = other.__pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10;
                this.v2 = other.v2;
                this.__pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq = other.__pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq;
                this.__pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD = other.__pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD;
                this.__pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34 = other.__pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34;
                this.__pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12 = other.__pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12;
                this.v3 = other.v3;
                this.__pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5 = other.__pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5;
                this.__pin_group_Input_In_JPoTRu2X387OESApBKSPqB = other.__pin_group_Input_In_JPoTRu2X387OESApBKSPqB;
                this.__pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc = other.__pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc;
                this.__pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd = other.__pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd;
                this.v4 = other.v4;
                this.__pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt = other.__pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt;
                this.__pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB = other.__pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB;
                this.__pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y = other.__pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y;
                this.__pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl = other.__pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HxeqI6H6XjYM2eyySy2Jnl", in __p_HxeqI6H6XjYM2eyySy2Jnl), n1.CompilationHelper.GetValueOrExisting(values, "__p_LysutlKts81P4BWcpodpHG", in __p_LysutlKts81P4BWcpodpHG), n1.CompilationHelper.GetValueOrExisting(values, "__p_DlLKeHzD54iLEnCwPrtFnl", in __p_DlLKeHzD54iLEnCwPrtFnl), n1.CompilationHelper.GetValueOrExisting(values, "__p_F0dcwtNCRYZO5o1XPHCxZ6", in __p_F0dcwtNCRYZO5o1XPHCxZ6), n1.CompilationHelper.GetValueOrExisting(values, "__p_OeTOsQCdVHHLw7m8QCKyTl", in __p_OeTOsQCdVHHLw7m8QCKyTl), n1.CompilationHelper.GetValueOrExisting(values, "__p_HVwroLANvLuPrSeAVbQPUf", in __p_HVwroLANvLuPrSeAVbQPUf), n1.CompilationHelper.GetValueOrExisting(values, "__p_QkyeNiwJYl0M8e0EAwT6Z0", in __p_QkyeNiwJYl0M8e0EAwT6Z0), n1.CompilationHelper.GetValueOrExisting(values, "__p_BNDGL7QstGdOx5wygNTH10", in __p_BNDGL7QstGdOx5wygNTH10), n1.CompilationHelper.GetValueOrExisting(values, "__p_QjC0Kt6gWWbLTaBa5c2Hyt", in __p_QjC0Kt6gWWbLTaBa5c2Hyt), n1.CompilationHelper.GetValueOrExisting(values, "__p_PuvZgtiHSyVMMJEihN0Q12", in __p_PuvZgtiHSyVMMJEihN0Q12), n1.CompilationHelper.GetValueOrExisting(values, "__p_TlKIgIXiPTOOMkrX94oG34", in __p_TlKIgIXiPTOOMkrX94oG34), n1.CompilationHelper.GetValueOrExisting(values, "__p_MqPIE7O1KZ4OeaZcfjK4uD", in __p_MqPIE7O1KZ4OeaZcfjK4uD), n1.CompilationHelper.GetValueOrExisting(values, "__p_S35CuMd3s77LLD5pWUTTjd", in __p_S35CuMd3s77LLD5pWUTTjd), n1.CompilationHelper.GetValueOrExisting(values, "__p_Hx2yD4C5PtVNk8WOpcxHvc", in __p_Hx2yD4C5PtVNk8WOpcxHvc), n1.CompilationHelper.GetValueOrExisting(values, "__p_JPoTRu2X387OESApBKSPqB", in __p_JPoTRu2X387OESApBKSPqB), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ou5wh0yRU0OO9nNnXpC3Xq", in __p_Ou5wh0yRU0OO9nNnXpC3Xq), n1.CompilationHelper.GetValueOrExisting(values, "__p_CctoH99q7kKOfXXOJWW0Y1", in __p_CctoH99q7kKOfXXOJWW0Y1), n1.CompilationHelper.GetValueOrExisting(values, "__p_CqDYcJDI9viM8e7ObCmVgq", in __p_CqDYcJDI9viM8e7ObCmVgq), n1.CompilationHelper.GetValueOrExisting(values, "__p_GO2M0dKfRQbO4ZIVyorEb5", in __p_GO2M0dKfRQbO4ZIVyorEb5), n1.CompilationHelper.GetValueOrExisting(values, "__p_AssFJ8QAApgOAT4nfzjfFB", in __p_AssFJ8QAApgOAT4nfzjfFB), n1.CompilationHelper.GetValueOrExisting(values, "__p_K2mGzUL22l1Owz3uk4KUtU", in __p_K2mGzUL22l1Owz3uk4KUtU), n1.CompilationHelper.GetValueOrExisting(values, "__p_FhGBQZjiNS6L0UWGNqKnYY", in __p_FhGBQZjiNS6L0UWGNqKnYY), n1.CompilationHelper.GetValueOrExisting(values, "__p_GatahvM1ph1LJ498dpfu5Y", in __p_GatahvM1ph1LJ498dpfu5Y), n1.CompilationHelper.GetValueOrExisting(values, "__p_BsBoOlqNeXqQDdQF6BdPzQ", in __p_BsBoOlqNeXqQDdQF6BdPzQ), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl", in __pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl), n1.CompilationHelper.GetValueOrExisting(values, "v1", in v1), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl", in __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl), n1.CompilationHelper.GetValueOrExisting(values, "halfDT", in halfDT), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0", in __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf", in __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10", in __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10), n1.CompilationHelper.GetValueOrExisting(values, "v2", in v2), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq", in __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD", in __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34", in __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12", in __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12), n1.CompilationHelper.GetValueOrExisting(values, "v3", in v3), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5", in __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_JPoTRu2X387OESApBKSPqB", in __pin_group_Input_In_JPoTRu2X387OESApBKSPqB), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc", in __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd", in __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd), n1.CompilationHelper.GetValueOrExisting(values, "v4", in v4), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt", in __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB", in __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y", in __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl", in __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl));
            }

            internal __OnH7aoAB0GNOnrgWuqK3rk __WITH__(n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_HxeqI6H6XjYM2eyySy2Jnl, n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T> __p_LysutlKts81P4BWcpodpHG, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_DlLKeHzD54iLEnCwPrtFnl, n14.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_F0dcwtNCRYZO5o1XPHCxZ6, n9.Invoke_C<T> __p_OeTOsQCdVHHLw7m8QCKyTl, n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_HVwroLANvLuPrSeAVbQPUf, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_QkyeNiwJYl0M8e0EAwT6Z0, n9.Invoke_C<T> __p_BNDGL7QstGdOx5wygNTH10, n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_QjC0Kt6gWWbLTaBa5c2Hyt, n9.Invoke_C<T> __p_PuvZgtiHSyVMMJEihN0Q12, n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_TlKIgIXiPTOOMkrX94oG34, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_MqPIE7O1KZ4OeaZcfjK4uD, n9.Invoke_C<T> __p_S35CuMd3s77LLD5pWUTTjd, n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_Hx2yD4C5PtVNk8WOpcxHvc, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_JPoTRu2X387OESApBKSPqB, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_Ou5wh0yRU0OO9nNnXpC3Xq, n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T> __p_CctoH99q7kKOfXXOJWW0Y1, n14.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_CqDYcJDI9viM8e7ObCmVgq, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_GO2M0dKfRQbO4ZIVyorEb5, n7.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<T> __p_AssFJ8QAApgOAT4nfzjfFB, n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T> __p_K2mGzUL22l1Owz3uk4KUtU, n14.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<float> __p_FhGBQZjiNS6L0UWGNqKnYY, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_GatahvM1ph1LJ498dpfu5Y, n8.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<T> __p_BsBoOlqNeXqQDdQF6BdPzQ, n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl, n5.GpuValue<T> v1, n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl, n5.GpuValue<T> halfDT, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf, n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10, n5.GpuValue<T> v2, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34, n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12, n5.GpuValue<T> v3, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_JPoTRu2X387OESApBKSPqB, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc, n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd, n5.GpuValue<T> v4, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl)
            {
                __OnH7aoAB0GNOnrgWuqK3rk that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_HxeqI6H6XjYM2eyySy2Jnl != this.__p_HxeqI6H6XjYM2eyySy2Jnl || __p_LysutlKts81P4BWcpodpHG != this.__p_LysutlKts81P4BWcpodpHG || __p_DlLKeHzD54iLEnCwPrtFnl != this.__p_DlLKeHzD54iLEnCwPrtFnl || __p_F0dcwtNCRYZO5o1XPHCxZ6 != this.__p_F0dcwtNCRYZO5o1XPHCxZ6 || __p_OeTOsQCdVHHLw7m8QCKyTl != this.__p_OeTOsQCdVHHLw7m8QCKyTl || __p_HVwroLANvLuPrSeAVbQPUf != this.__p_HVwroLANvLuPrSeAVbQPUf || __p_QkyeNiwJYl0M8e0EAwT6Z0 != this.__p_QkyeNiwJYl0M8e0EAwT6Z0 || __p_BNDGL7QstGdOx5wygNTH10 != this.__p_BNDGL7QstGdOx5wygNTH10 || __p_QjC0Kt6gWWbLTaBa5c2Hyt != this.__p_QjC0Kt6gWWbLTaBa5c2Hyt || __p_PuvZgtiHSyVMMJEihN0Q12 != this.__p_PuvZgtiHSyVMMJEihN0Q12 || __p_TlKIgIXiPTOOMkrX94oG34 != this.__p_TlKIgIXiPTOOMkrX94oG34 || __p_MqPIE7O1KZ4OeaZcfjK4uD != this.__p_MqPIE7O1KZ4OeaZcfjK4uD || __p_S35CuMd3s77LLD5pWUTTjd != this.__p_S35CuMd3s77LLD5pWUTTjd || __p_Hx2yD4C5PtVNk8WOpcxHvc != this.__p_Hx2yD4C5PtVNk8WOpcxHvc || __p_JPoTRu2X387OESApBKSPqB != this.__p_JPoTRu2X387OESApBKSPqB || __p_Ou5wh0yRU0OO9nNnXpC3Xq != this.__p_Ou5wh0yRU0OO9nNnXpC3Xq || __p_CctoH99q7kKOfXXOJWW0Y1 != this.__p_CctoH99q7kKOfXXOJWW0Y1 || __p_CqDYcJDI9viM8e7ObCmVgq != this.__p_CqDYcJDI9viM8e7ObCmVgq || __p_GO2M0dKfRQbO4ZIVyorEb5 != this.__p_GO2M0dKfRQbO4ZIVyorEb5 || __p_AssFJ8QAApgOAT4nfzjfFB != this.__p_AssFJ8QAApgOAT4nfzjfFB || __p_K2mGzUL22l1Owz3uk4KUtU != this.__p_K2mGzUL22l1Owz3uk4KUtU || __p_FhGBQZjiNS6L0UWGNqKnYY != this.__p_FhGBQZjiNS6L0UWGNqKnYY || __p_GatahvM1ph1LJ498dpfu5Y != this.__p_GatahvM1ph1LJ498dpfu5Y || __p_BsBoOlqNeXqQDdQF6BdPzQ != this.__p_BsBoOlqNeXqQDdQF6BdPzQ || __pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl != this.__pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl || v1 != this.v1 || __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl != this.__pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl || halfDT != this.halfDT || __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0 != this.__pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0 || __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf != this.__pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf || __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10 != this.__pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10 || v2 != this.v2 || __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq != this.__pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq || __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD != this.__pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD || __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34 != this.__pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34 || __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12 != this.__pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12 || v3 != this.v3 || __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5 != this.__pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5 || __pin_group_Input_In_JPoTRu2X387OESApBKSPqB != this.__pin_group_Input_In_JPoTRu2X387OESApBKSPqB || __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc != this.__pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc || __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd != this.__pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd || v4 != this.v4 || __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt != this.__pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt || __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB != this.__pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB || __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y != this.__pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y || __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl != this.__pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl ? new __OnH7aoAB0GNOnrgWuqK3rk(this)
                    {__p_HxeqI6H6XjYM2eyySy2Jnl = __p_HxeqI6H6XjYM2eyySy2Jnl, __p_LysutlKts81P4BWcpodpHG = __p_LysutlKts81P4BWcpodpHG, __p_DlLKeHzD54iLEnCwPrtFnl = __p_DlLKeHzD54iLEnCwPrtFnl, __p_F0dcwtNCRYZO5o1XPHCxZ6 = __p_F0dcwtNCRYZO5o1XPHCxZ6, __p_OeTOsQCdVHHLw7m8QCKyTl = __p_OeTOsQCdVHHLw7m8QCKyTl, __p_HVwroLANvLuPrSeAVbQPUf = __p_HVwroLANvLuPrSeAVbQPUf, __p_QkyeNiwJYl0M8e0EAwT6Z0 = __p_QkyeNiwJYl0M8e0EAwT6Z0, __p_BNDGL7QstGdOx5wygNTH10 = __p_BNDGL7QstGdOx5wygNTH10, __p_QjC0Kt6gWWbLTaBa5c2Hyt = __p_QjC0Kt6gWWbLTaBa5c2Hyt, __p_PuvZgtiHSyVMMJEihN0Q12 = __p_PuvZgtiHSyVMMJEihN0Q12, __p_TlKIgIXiPTOOMkrX94oG34 = __p_TlKIgIXiPTOOMkrX94oG34, __p_MqPIE7O1KZ4OeaZcfjK4uD = __p_MqPIE7O1KZ4OeaZcfjK4uD, __p_S35CuMd3s77LLD5pWUTTjd = __p_S35CuMd3s77LLD5pWUTTjd, __p_Hx2yD4C5PtVNk8WOpcxHvc = __p_Hx2yD4C5PtVNk8WOpcxHvc, __p_JPoTRu2X387OESApBKSPqB = __p_JPoTRu2X387OESApBKSPqB, __p_Ou5wh0yRU0OO9nNnXpC3Xq = __p_Ou5wh0yRU0OO9nNnXpC3Xq, __p_CctoH99q7kKOfXXOJWW0Y1 = __p_CctoH99q7kKOfXXOJWW0Y1, __p_CqDYcJDI9viM8e7ObCmVgq = __p_CqDYcJDI9viM8e7ObCmVgq, __p_GO2M0dKfRQbO4ZIVyorEb5 = __p_GO2M0dKfRQbO4ZIVyorEb5, __p_AssFJ8QAApgOAT4nfzjfFB = __p_AssFJ8QAApgOAT4nfzjfFB, __p_K2mGzUL22l1Owz3uk4KUtU = __p_K2mGzUL22l1Owz3uk4KUtU, __p_FhGBQZjiNS6L0UWGNqKnYY = __p_FhGBQZjiNS6L0UWGNqKnYY, __p_GatahvM1ph1LJ498dpfu5Y = __p_GatahvM1ph1LJ498dpfu5Y, __p_BsBoOlqNeXqQDdQF6BdPzQ = __p_BsBoOlqNeXqQDdQF6BdPzQ, __pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl = __pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl, v1 = v1, __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl = __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl, halfDT = halfDT, __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0 = __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0, __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf = __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf, __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10 = __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10, v2 = v2, __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq = __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq, __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD = __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD, __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34 = __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34, __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12 = __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12, v3 = v3, __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5 = __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5, __pin_group_Input_In_JPoTRu2X387OESApBKSPqB = __pin_group_Input_In_JPoTRu2X387OESApBKSPqB, __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc = __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc, __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd = __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd, v4 = v4, __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt = __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt, __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB = __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB, __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y = __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y, __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl = __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl} : that_0;
                else
                {
                    this.__p_HxeqI6H6XjYM2eyySy2Jnl = __p_HxeqI6H6XjYM2eyySy2Jnl;
                    this.__p_LysutlKts81P4BWcpodpHG = __p_LysutlKts81P4BWcpodpHG;
                    this.__p_DlLKeHzD54iLEnCwPrtFnl = __p_DlLKeHzD54iLEnCwPrtFnl;
                    this.__p_F0dcwtNCRYZO5o1XPHCxZ6 = __p_F0dcwtNCRYZO5o1XPHCxZ6;
                    this.__p_OeTOsQCdVHHLw7m8QCKyTl = __p_OeTOsQCdVHHLw7m8QCKyTl;
                    this.__p_HVwroLANvLuPrSeAVbQPUf = __p_HVwroLANvLuPrSeAVbQPUf;
                    this.__p_QkyeNiwJYl0M8e0EAwT6Z0 = __p_QkyeNiwJYl0M8e0EAwT6Z0;
                    this.__p_BNDGL7QstGdOx5wygNTH10 = __p_BNDGL7QstGdOx5wygNTH10;
                    this.__p_QjC0Kt6gWWbLTaBa5c2Hyt = __p_QjC0Kt6gWWbLTaBa5c2Hyt;
                    this.__p_PuvZgtiHSyVMMJEihN0Q12 = __p_PuvZgtiHSyVMMJEihN0Q12;
                    this.__p_TlKIgIXiPTOOMkrX94oG34 = __p_TlKIgIXiPTOOMkrX94oG34;
                    this.__p_MqPIE7O1KZ4OeaZcfjK4uD = __p_MqPIE7O1KZ4OeaZcfjK4uD;
                    this.__p_S35CuMd3s77LLD5pWUTTjd = __p_S35CuMd3s77LLD5pWUTTjd;
                    this.__p_Hx2yD4C5PtVNk8WOpcxHvc = __p_Hx2yD4C5PtVNk8WOpcxHvc;
                    this.__p_JPoTRu2X387OESApBKSPqB = __p_JPoTRu2X387OESApBKSPqB;
                    this.__p_Ou5wh0yRU0OO9nNnXpC3Xq = __p_Ou5wh0yRU0OO9nNnXpC3Xq;
                    this.__p_CctoH99q7kKOfXXOJWW0Y1 = __p_CctoH99q7kKOfXXOJWW0Y1;
                    this.__p_CqDYcJDI9viM8e7ObCmVgq = __p_CqDYcJDI9viM8e7ObCmVgq;
                    this.__p_GO2M0dKfRQbO4ZIVyorEb5 = __p_GO2M0dKfRQbO4ZIVyorEb5;
                    this.__p_AssFJ8QAApgOAT4nfzjfFB = __p_AssFJ8QAApgOAT4nfzjfFB;
                    this.__p_K2mGzUL22l1Owz3uk4KUtU = __p_K2mGzUL22l1Owz3uk4KUtU;
                    this.__p_FhGBQZjiNS6L0UWGNqKnYY = __p_FhGBQZjiNS6L0UWGNqKnYY;
                    this.__p_GatahvM1ph1LJ498dpfu5Y = __p_GatahvM1ph1LJ498dpfu5Y;
                    this.__p_BsBoOlqNeXqQDdQF6BdPzQ = __p_BsBoOlqNeXqQDdQF6BdPzQ;
                    this.__pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl = __pin_group_Parameters_In_OeTOsQCdVHHLw7m8QCKyTl;
                    this.v1 = v1;
                    this.__pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl = __pin_group_Input_In_DlLKeHzD54iLEnCwPrtFnl;
                    this.halfDT = halfDT;
                    this.__pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0 = __pin_group_Input_In_QkyeNiwJYl0M8e0EAwT6Z0;
                    this.__pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf = __pin_group_Input_In_HVwroLANvLuPrSeAVbQPUf;
                    this.__pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10 = __pin_group_Parameters_In_BNDGL7QstGdOx5wygNTH10;
                    this.v2 = v2;
                    this.__pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq = __pin_group_Input_In_Ou5wh0yRU0OO9nNnXpC3Xq;
                    this.__pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD = __pin_group_Input_In_MqPIE7O1KZ4OeaZcfjK4uD;
                    this.__pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34 = __pin_group_Input_In_TlKIgIXiPTOOMkrX94oG34;
                    this.__pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12 = __pin_group_Parameters_In_PuvZgtiHSyVMMJEihN0Q12;
                    this.v3 = v3;
                    this.__pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5 = __pin_group_Input_In_GO2M0dKfRQbO4ZIVyorEb5;
                    this.__pin_group_Input_In_JPoTRu2X387OESApBKSPqB = __pin_group_Input_In_JPoTRu2X387OESApBKSPqB;
                    this.__pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc = __pin_group_Input_In_Hx2yD4C5PtVNk8WOpcxHvc;
                    this.__pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd = __pin_group_Parameters_In_S35CuMd3s77LLD5pWUTTjd;
                    this.v4 = v4;
                    this.__pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt = __pin_group_Input_In_QjC0Kt6gWWbLTaBa5c2Hyt;
                    this.__pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB = __pin_group_Input_In_AssFJ8QAApgOAT4nfzjfFB;
                    this.__pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y = __pin_group_Input_In_GatahvM1ph1LJ498dpfu5Y;
                    this.__pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl = __pin_group_Input_In_HxeqI6H6XjYM2eyySy2Jnl;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 343482U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "NfK3RMSxxfxNKGudKjQNSm", Name = "Integrate_NfK3RMSxxfxNKGudKjQNSm")]
    [n2.SerializableAttribute]
    public class Integrate_NfK3RMSxxfxNKGudKjQNSm<T> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.Integrate_NfK3RMSxxfxNKGudKjQNSm<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Integrate_NfK3RMSxxfxNKGudKjQNSm<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Integrate_NfK3RMSxxfxNKGudKjQNSm<T> CreateDefault()
        {
            var instance = new Integrate_NfK3RMSxxfxNKGudKjQNSm<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Integrate_NfK3RMSxxfxNKGudKjQNSm<T> Update<AdM>(n5.GpuValue<T> Function_In, n5.GpuValue<T> Postion_In, n5.GpuValue<float> Step_Size_In, n15.IntegrationMode Integration_Mode_In, out n5.GpuValue<T> Output_Out)
            where AdM : struct, n17.IAdaptiveCreateDefault<n5.GpuValue<T>>
        {
            var w_0 = default(AdM);
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_NfbClM90YD4OBB1aOPxeB5;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n15.IntegrationMode, n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_4 = (Integration_Mode_In, Function_In, Postion_In, Step_Size_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__FFONeqDQ5tKQAQW7ADguJk>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __FFONeqDQ5tKQAQW7ADguJk(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "RMN278YUhPFPJVQoDtJQEv", 343552U);
                    var Output_9 = n3.Euler_UGOff270OGRMGHqpMoRrg8<T>.Create(Node_Context: Node_Context_8);
                    state_7.__p_RMN278YUhPFPJVQoDtJQEv = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "Rfyj8oEbjgYNv3cbYnfw31", 343578U);
                    var Output_11 = n3.RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T>.Create(Node_Context: Node_Context_10);
                    state_7.__p_Rfyj8oEbjgYNv3cbYnfw31 = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "RMKBeLiy4iCOgUobPJMndo", 343602U);
                    var Output_13 = n3.RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T>.Create(Node_Context: Node_Context_12);
                    state_7.__p_RMKBeLiy4iCOgUobPJMndo = Output_13;
                }

                int Index_14 = (int)Integration_Mode_In;
                var State_Output_16 = state_7.__p_RMN278YUhPFPJVQoDtJQEv.Update(Function_In: Function_In, Position_In: Postion_In, Step_Size_In: Step_Size_In, Output_Out: out n5.GpuValue<T> Output_15);
                var State_Output_18 = state_7.__p_Rfyj8oEbjgYNv3cbYnfw31.Update(Function_In: Function_In, Position_In: Postion_In, Step_Size_In: Step_Size_In, Output_Out: out n5.GpuValue<T> Output_17);
                var State_Output_20 = state_7.__p_RMKBeLiy4iCOgUobPJMndo.Update(Function_In: Function_In, Postion_In: Postion_In, Step_Size_In: Step_Size_In, Output_Out: out n5.GpuValue<T> Output_19);
                var builder_21 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k, 3);
                builder_21.Add(Output_15);
                builder_21.Add(Output_17);
                builder_21.Add(Output_19);
                var __pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k_22 = builder_21.Commit();
                n16._Operations_.Switch<n5.GpuValue<T>, AdM>(Index_In: Index_14, Input_In: __pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k_22, Output_Out: out n5.GpuValue<T> Output_23);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_16 != state_7.__p_RMN278YUhPFPJVQoDtJQEv || State_Output_18 != state_7.__p_Rfyj8oEbjgYNv3cbYnfw31 || State_Output_20 != state_7.__p_RMKBeLiy4iCOgUobPJMndo || __pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k_22 != state_7.__pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k ? new __FFONeqDQ5tKQAQW7ADguJk(state_7)
                    {__p_RMN278YUhPFPJVQoDtJQEv = State_Output_16, __p_Rfyj8oEbjgYNv3cbYnfw31 = State_Output_18, __p_RMKBeLiy4iCOgUobPJMndo = State_Output_20, __pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k = __pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k_22} : state_7;
                else
                {
                    state_7.__p_RMN278YUhPFPJVQoDtJQEv = State_Output_16;
                    state_7.__p_Rfyj8oEbjgYNv3cbYnfw31 = State_Output_18;
                    state_7.__p_RMKBeLiy4iCOgUobPJMndo = State_Output_20;
                    state_7.__pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k = __pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k_22;
                }

                outputs_5 = n2.ValueTuple.Create(Output_23);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_24 = outputs_5.Item1;
            Output_Out = __auto_24;
            n3.Integrate_NfK3RMSxxfxNKGudKjQNSm<T> that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = manager_3 != this.__cache_NfbClM90YD4OBB1aOPxeB5 ? new Integrate_NfK3RMSxxfxNKGudKjQNSm<T>(this)
                {__cache_NfbClM90YD4OBB1aOPxeB5 = manager_3} : that_25;
            else
            {
                this.__cache_NfbClM90YD4OBB1aOPxeB5 = manager_3;
            }

            return that_25;
        }

        public n3.Integrate_NfK3RMSxxfxNKGudKjQNSm<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Integrate_NfK3RMSxxfxNKGudKjQNSm<T> that_0 = this;
            this.__cache_NfbClM90YD4OBB1aOPxeB5 = null;
            return that_0;
        }

        public n3.Integrate_NfK3RMSxxfxNKGudKjQNSm<T> __CreateDefault__()
        {
            n3.Integrate_NfK3RMSxxfxNKGudKjQNSm<T> that_0 = this;
            this.__cache_NfbClM90YD4OBB1aOPxeB5 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_NfbClM90YD4OBB1aOPxeB5);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 343487U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "NfbClM90YD4OBB1aOPxeB5", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n15.IntegrationMode, n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_NfbClM90YD4OBB1aOPxeB5 = null;
        public Integrate_NfK3RMSxxfxNKGudKjQNSm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Integrate_NfK3RMSxxfxNKGudKjQNSm(Integrate_NfK3RMSxxfxNKGudKjQNSm<T> other): base(other)
        {
            this.__cache_NfbClM90YD4OBB1aOPxeB5 = other.__cache_NfbClM90YD4OBB1aOPxeB5;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_NfbClM90YD4OBB1aOPxeB5", in __cache_NfbClM90YD4OBB1aOPxeB5));
        }

        internal Integrate_NfK3RMSxxfxNKGudKjQNSm<T> __WITH__(n6.Manager<n2.ValueTuple<n15.IntegrationMode, n5.GpuValue<T>, n5.GpuValue<T>, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_NfbClM90YD4OBB1aOPxeB5)
        {
            n3.Integrate_NfK3RMSxxfxNKGudKjQNSm<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_NfbClM90YD4OBB1aOPxeB5 != this.__cache_NfbClM90YD4OBB1aOPxeB5 ? new Integrate_NfK3RMSxxfxNKGudKjQNSm<T>(this)
                {__cache_NfbClM90YD4OBB1aOPxeB5 = __cache_NfbClM90YD4OBB1aOPxeB5} : that_0;
            else
            {
                this.__cache_NfbClM90YD4OBB1aOPxeB5 = __cache_NfbClM90YD4OBB1aOPxeB5;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "FFONeqDQ5tKQAQW7ADguJk", Name = "__FFONeqDQ5tKQAQW7ADguJk")]
        [n2.SerializableAttribute]
        public class __FFONeqDQ5tKQAQW7ADguJk : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RMN278YUhPFPJVQoDtJQEv);
                n1.CompilationHelper.SafeDispose(this.__p_Rfyj8oEbjgYNv3cbYnfw31);
                n1.CompilationHelper.SafeDispose(this.__p_RMKBeLiy4iCOgUobPJMndo);
                return;
            }

            [n1.ElementAttribute(TracingId = 343552U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "RMN278YUhPFPJVQoDtJQEv", Name = "Euler", IsManaged = true, IsAutoGenerated = true)]
            public n3.Euler_UGOff270OGRMGHqpMoRrg8<T> __p_RMN278YUhPFPJVQoDtJQEv;
            [n1.ElementAttribute(TracingId = 343578U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Rfyj8oEbjgYNv3cbYnfw31", Name = "RungeKutta2", IsManaged = true, IsAutoGenerated = true)]
            public n3.RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> __p_Rfyj8oEbjgYNv3cbYnfw31;
            [n1.ElementAttribute(TracingId = 343602U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "RMKBeLiy4iCOgUobPJMndo", Name = "RungeKutta4", IsManaged = true, IsAutoGenerated = true)]
            public n3.RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> __p_RMKBeLiy4iCOgUobPJMndo;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k = default(n10.Spread<n5.GpuValue<T>>);
            public __FFONeqDQ5tKQAQW7ADguJk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __FFONeqDQ5tKQAQW7ADguJk(__FFONeqDQ5tKQAQW7ADguJk other): base(other)
            {
                this.__p_RMN278YUhPFPJVQoDtJQEv = other.__p_RMN278YUhPFPJVQoDtJQEv;
                this.__p_Rfyj8oEbjgYNv3cbYnfw31 = other.__p_Rfyj8oEbjgYNv3cbYnfw31;
                this.__p_RMKBeLiy4iCOgUobPJMndo = other.__p_RMKBeLiy4iCOgUobPJMndo;
                this.__pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k = other.__pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RMN278YUhPFPJVQoDtJQEv", in __p_RMN278YUhPFPJVQoDtJQEv), n1.CompilationHelper.GetValueOrExisting(values, "__p_Rfyj8oEbjgYNv3cbYnfw31", in __p_Rfyj8oEbjgYNv3cbYnfw31), n1.CompilationHelper.GetValueOrExisting(values, "__p_RMKBeLiy4iCOgUobPJMndo", in __p_RMKBeLiy4iCOgUobPJMndo), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k", in __pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k));
            }

            internal __FFONeqDQ5tKQAQW7ADguJk __WITH__(n3.Euler_UGOff270OGRMGHqpMoRrg8<T> __p_RMN278YUhPFPJVQoDtJQEv, n3.RungeKutta2_VaiYU9nx7QuNt33zItr6W2<T> __p_Rfyj8oEbjgYNv3cbYnfw31, n3.RungeKutta4_DSAFnRSqCyxNuwkaNaqaDz<T> __p_RMKBeLiy4iCOgUobPJMndo, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k)
            {
                __FFONeqDQ5tKQAQW7ADguJk that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RMN278YUhPFPJVQoDtJQEv != this.__p_RMN278YUhPFPJVQoDtJQEv || __p_Rfyj8oEbjgYNv3cbYnfw31 != this.__p_Rfyj8oEbjgYNv3cbYnfw31 || __p_RMKBeLiy4iCOgUobPJMndo != this.__p_RMKBeLiy4iCOgUobPJMndo || __pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k != this.__pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k ? new __FFONeqDQ5tKQAQW7ADguJk(this)
                    {__p_RMN278YUhPFPJVQoDtJQEv = __p_RMN278YUhPFPJVQoDtJQEv, __p_Rfyj8oEbjgYNv3cbYnfw31 = __p_Rfyj8oEbjgYNv3cbYnfw31, __p_RMKBeLiy4iCOgUobPJMndo = __p_RMKBeLiy4iCOgUobPJMndo, __pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k = __pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k} : that_0;
                else
                {
                    this.__p_RMN278YUhPFPJVQoDtJQEv = __p_RMN278YUhPFPJVQoDtJQEv;
                    this.__p_Rfyj8oEbjgYNv3cbYnfw31 = __p_Rfyj8oEbjgYNv3cbYnfw31;
                    this.__p_RMKBeLiy4iCOgUobPJMndo = __p_RMKBeLiy4iCOgUobPJMndo;
                    this.__pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k = __pin_group_Input_In_O9fqAIu3FEbMYzg5tTtO0k;
                }

                return that_0;
            }
        }
    }
}

namespace _Fuse_Core_Calculus_.Fuse.Core.Calculus.Differentiation
{
    [n1.ElementAttribute(TracingId = 344721U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Gcf1XoiXkEeOwd3lB1bB7W", Name = "CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W")]
    [n2.SerializableAttribute]
    public class CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n18.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n18.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> CreateDefault()
        {
            var instance = new CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n18.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> Update(n5.GpuValue<float> Function_In, n5.GpuValue<T> Position_In, n5.GpuValue<float> Epsilon_In, out n5.GpuValue<T> Output_Out)
        {
            string __pad_AHayQBZlZCZMqW41lOyhfW_0 = __slot_AHayQBZlZCZMqW41lOyhfW;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_Rk1FyObQ0Y0NGsCEfIod5H;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, string, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_4 = (Position_In, Epsilon_In, __pad_AHayQBZlZCZMqW41lOyhfW_0, Function_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__IEhppuLa8ObNKomtEN2FJQ>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __IEhppuLa8ObNKomtEN2FJQ(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx = n11._Operations_.CreateDefault<n5.AbstractGpuValue>(), __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD = n11._Operations_.CreateDefault<n5.IFunctionInvokeNode>(), __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS = n23._Operations_.CreateDefault<string, string>(), __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "Te3MEvRk27ZPZKB7PQsJRU", 344757U);
                    var Output_9 = n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>>.Create(Node_Context: Node_Context_8);
                    state_7.__p_Te3MEvRk27ZPZKB7PQsJRU = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "ICQppyLURvOMfLGMhYC53x", 344829U);
                    var Output_11 = n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_10);
                    state_7.__p_ICQppyLURvOMfLGMhYC53x = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "Mf2ViQNzkWpPOpGFcNJ9wx", 344850U);
                    var Output_13 = n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.Create(Node_Context: Node_Context_12);
                    state_7.__p_Mf2ViQNzkWpPOpGFcNJ9wx = Output_13;
                }

                string __pad_La2d1Tk91LSNDQiLKoWkDG_14 = __slot_La2d1Tk91LSNDQiLKoWkDG;
                string __pad_VvX6ANdWPKaMAQmJPy7AA9_15 = __slot_VvX6ANdWPKaMAQmJPy7AA9;
                float __pad_NYpsVoStZtMODhxQ4Fb8ff_16 = __slot_NYpsVoStZtMODhxQ4Fb8ff;
                var State_Output_18 = state_7.__p_ICQppyLURvOMfLGMhYC53x.Update(GpuValue_In: Epsilon_In, The_Value_In: __pad_NYpsVoStZtMODhxQ4Fb8ff_16, Output_Out: out n5.GpuValue<float> Output_17);
                var builder_19 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx, 1);
                builder_19.Add(Position_In);
                var __pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx_20 = builder_19.Commit();
                var State_Output_22 = state_7.__p_Mf2ViQNzkWpPOpGFcNJ9wx.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx_20, Id_In: __pad_La2d1Tk91LSNDQiLKoWkDG_14, Output_Out: out n5.FunctionInvokeNode<float> Output_21);
                n5.IFunctionInvokeNode Input_23 = (n5.IFunctionInvokeNode)Output_21;
                var builder_24 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD, 1);
                builder_24.Add(Input_23);
                var __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD_25 = builder_24.Commit();
                n11._Operations_.FromValue<n5.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD_25, Result_Out: out n10.Spread<n5.IFunctionInvokeNode> Result_26);
                var Result_27 = n5.TypeHelpers.GetDimension<T>(theValue: Position_In);
                var Result_28 = n21.ObjectHelpers.ToString(input: Result_27);
                var builder_29 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS, 1);
                builder_29.Add("DomainDimension", Result_28);
                var __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS_30 = builder_29.Commit();
                n23._Operations_.Cons<string>(Input_In: __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS_30, Output_Out: out n22.ImmutableDictionary<string, string> Output_31);
                n5.GpuValue<T> Default_Result_32 = default(n5.GpuValue<T>);
                n13.IEnumerable<string> Mixins_33 = n24._Operations_.CreateDefault<string>();
                bool Is_Groupable_34 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_35 = n24._Operations_.CreateDefault<n5.InputModifier>();
                var builder_36 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU, 2);
                builder_36.Add(Position_In);
                builder_36.Add(Output_17);
                var __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU_37 = builder_36.Commit();
                var State_Output_40 = state_7.__p_Te3MEvRk27ZPZKB7PQsJRU.Update(Arguments_In: __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU_37, Function_Name_In: __pad_VvX6ANdWPKaMAQmJPy7AA9_15, Code_Template_In: __pad_AHayQBZlZCZMqW41lOyhfW_0, Default_Result_In: Default_Result_32, Functions_In: Result_26, Mixins_In: Mixins_33, Template_Values_In: Output_31, Is_Groupable_In: Is_Groupable_34, The_Modifiers_In: The_Modifiers_35, Output_Out: out n5.GpuValue<T> Output_38, AdditionalOutputs_Out: out n10.Spread<n5.AbstractGpuValue> AdditionalOutputs_39);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_18 != state_7.__p_ICQppyLURvOMfLGMhYC53x || __pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx_20 != state_7.__pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx || State_Output_22 != state_7.__p_Mf2ViQNzkWpPOpGFcNJ9wx || __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD_25 != state_7.__pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD || __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS_30 != state_7.__pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS || __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU_37 != state_7.__pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU || State_Output_40 != state_7.__p_Te3MEvRk27ZPZKB7PQsJRU ? new __IEhppuLa8ObNKomtEN2FJQ(state_7)
                    {__p_ICQppyLURvOMfLGMhYC53x = State_Output_18, __pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx = __pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx_20, __p_Mf2ViQNzkWpPOpGFcNJ9wx = State_Output_22, __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD = __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD_25, __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS = __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS_30, __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU = __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU_37, __p_Te3MEvRk27ZPZKB7PQsJRU = State_Output_40} : state_7;
                else
                {
                    state_7.__p_ICQppyLURvOMfLGMhYC53x = State_Output_18;
                    state_7.__pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx = __pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx_20;
                    state_7.__p_Mf2ViQNzkWpPOpGFcNJ9wx = State_Output_22;
                    state_7.__pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD = __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD_25;
                    state_7.__pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS = __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS_30;
                    state_7.__pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU = __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU_37;
                    state_7.__p_Te3MEvRk27ZPZKB7PQsJRU = State_Output_40;
                }

                outputs_5 = n2.ValueTuple.Create(Output_38);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_41 = outputs_5.Item1;
            Output_Out = __auto_41;
            n18.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> that_42 = this;
            if (this.__GetContext__().IsImmutable)
                that_42 = manager_3 != this.__cache_Rk1FyObQ0Y0NGsCEfIod5H ? new CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T>(this)
                {__cache_Rk1FyObQ0Y0NGsCEfIod5H = manager_3} : that_42;
            else
            {
                this.__cache_Rk1FyObQ0Y0NGsCEfIod5H = manager_3;
            }

            return that_42;
        }

        public n18.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n18.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> that_0 = this;
            this.__cache_Rk1FyObQ0Y0NGsCEfIod5H = null;
            return that_0;
        }

        public n18.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> __CreateDefault__()
        {
            n18.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> that_0 = this;
            this.__cache_Rk1FyObQ0Y0NGsCEfIod5H = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_Rk1FyObQ0Y0NGsCEfIod5H);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 344874U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "AHayQBZlZCZMqW41lOyhfW", Name = "__slot_AHayQBZlZCZMqW41lOyhfW")]
        public static string __slot_AHayQBZlZCZMqW41lOyhfW = "${resultType} ${signature} (${resultType} p,float e)\r\n{\r\n\r\n    ${resultType} result = 0.;\r\n    ${resultType} offset = 0.;  \r\n\r\n    for(int i = 0; i < ${DomainDimension}; i++)\r\n    {\r\n        ${resultType} offset = .0;\r\n        offset[i] = e;\r\n        result[i] =( ${function}(p + offset) - ${function}(p - offset) ) / (2. * e);\r\n    }\r\n\r\n    return result;\r\n}";
        [n1.ElementAttribute(TracingId = 344880U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "FG0VBy3omlCMzrmoZU7Aag", Name = "__slot_FG0VBy3omlCMzrmoZU7Aag")]
        public static string __slot_FG0VBy3omlCMzrmoZU7Aag = "for a 3D scalar function would do the following:\r\n\r\nfloat3 gradient;\r\ngradient.x = (f(p + float3(e,0,0)) - f(p - float3(e,0,0))) / (2*e) \r\ngradient.y = (f(p + float3(0,e,0)) - f(p - float3(0,e,0))) / (2*e) \r\ngradient.z = (f(p + float3(0,0,e)) - f(p - float3(0,0,e))) / (2*e) ";
        [n1.ElementAttribute(TracingId = 344909U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Pkd2eegFhZlPkjV23HwZX0", Name = "__slot_Pkd2eegFhZlPkjV23HwZX0")]
        public static string __slot_Pkd2eegFhZlPkjV23HwZX0 = "note that the [i] here is actully indexing vector component, not an array!";
        [n1.ElementAttribute(TracingId = 344726U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Rk1FyObQ0Y0NGsCEfIod5H", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, string, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_Rk1FyObQ0Y0NGsCEfIod5H = null;
        [n1.ElementAttribute(TracingId = 344800U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "La2d1Tk91LSNDQiLKoWkDG", Name = "__slot_La2d1Tk91LSNDQiLKoWkDG")]
        public static string __slot_La2d1Tk91LSNDQiLKoWkDG = "function";
        [n1.ElementAttribute(TracingId = 344807U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "VvX6ANdWPKaMAQmJPy7AA9", Name = "__slot_VvX6ANdWPKaMAQmJPy7AA9")]
        public static string __slot_VvX6ANdWPKaMAQmJPy7AA9 = "FunctionGradient";
        [n1.ElementAttribute(TracingId = 344845U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "NYpsVoStZtMODhxQ4Fb8ff", Name = "__slot_NYpsVoStZtMODhxQ4Fb8ff")]
        public static float __slot_NYpsVoStZtMODhxQ4Fb8ff = 0.001F;
        static CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W()
        {
        }

        public CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W(CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> other): base(other)
        {
            this.__cache_Rk1FyObQ0Y0NGsCEfIod5H = other.__cache_Rk1FyObQ0Y0NGsCEfIod5H;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Rk1FyObQ0Y0NGsCEfIod5H", in __cache_Rk1FyObQ0Y0NGsCEfIod5H));
        }

        internal CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, string, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_Rk1FyObQ0Y0NGsCEfIod5H)
        {
            n18.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Rk1FyObQ0Y0NGsCEfIod5H != this.__cache_Rk1FyObQ0Y0NGsCEfIod5H ? new CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T>(this)
                {__cache_Rk1FyObQ0Y0NGsCEfIod5H = __cache_Rk1FyObQ0Y0NGsCEfIod5H} : that_0;
            else
            {
                this.__cache_Rk1FyObQ0Y0NGsCEfIod5H = __cache_Rk1FyObQ0Y0NGsCEfIod5H;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "IEhppuLa8ObNKomtEN2FJQ", Name = "__IEhppuLa8ObNKomtEN2FJQ")]
        [n2.SerializableAttribute]
        public class __IEhppuLa8ObNKomtEN2FJQ : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Te3MEvRk27ZPZKB7PQsJRU);
                n1.CompilationHelper.SafeDispose(this.__p_ICQppyLURvOMfLGMhYC53x);
                n1.CompilationHelper.SafeDispose(this.__p_Mf2ViQNzkWpPOpGFcNJ9wx);
                return;
            }

            [n1.ElementAttribute(TracingId = 344757U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Te3MEvRk27ZPZKB7PQsJRU", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>> __p_Te3MEvRk27ZPZKB7PQsJRU;
            [n1.ElementAttribute(TracingId = 344829U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "ICQppyLURvOMfLGMhYC53x", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_ICQppyLURvOMfLGMhYC53x;
            [n1.ElementAttribute(TracingId = 344850U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Mf2ViQNzkWpPOpGFcNJ9wx", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_Mf2ViQNzkWpPOpGFcNJ9wx;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx = default(n10.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.IFunctionInvokeNode> __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD = default(n10.Spread<n5.IFunctionInvokeNode>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n22.ImmutableDictionary<string, string> __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS = default(n22.ImmutableDictionary<string, string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU = default(n10.Spread<n5.AbstractGpuValue>);
            public __IEhppuLa8ObNKomtEN2FJQ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __IEhppuLa8ObNKomtEN2FJQ(__IEhppuLa8ObNKomtEN2FJQ other): base(other)
            {
                this.__p_Te3MEvRk27ZPZKB7PQsJRU = other.__p_Te3MEvRk27ZPZKB7PQsJRU;
                this.__p_ICQppyLURvOMfLGMhYC53x = other.__p_ICQppyLURvOMfLGMhYC53x;
                this.__p_Mf2ViQNzkWpPOpGFcNJ9wx = other.__p_Mf2ViQNzkWpPOpGFcNJ9wx;
                this.__pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx = other.__pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx;
                this.__pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD = other.__pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD;
                this.__pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS = other.__pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS;
                this.__pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU = other.__pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Te3MEvRk27ZPZKB7PQsJRU", in __p_Te3MEvRk27ZPZKB7PQsJRU), n1.CompilationHelper.GetValueOrExisting(values, "__p_ICQppyLURvOMfLGMhYC53x", in __p_ICQppyLURvOMfLGMhYC53x), n1.CompilationHelper.GetValueOrExisting(values, "__p_Mf2ViQNzkWpPOpGFcNJ9wx", in __p_Mf2ViQNzkWpPOpGFcNJ9wx), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx", in __pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD", in __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS", in __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU", in __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU));
            }

            internal __IEhppuLa8ObNKomtEN2FJQ __WITH__(n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>> __p_Te3MEvRk27ZPZKB7PQsJRU, n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_ICQppyLURvOMfLGMhYC53x, n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_Mf2ViQNzkWpPOpGFcNJ9wx, n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx, n10.Spread<n5.IFunctionInvokeNode> __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD, n22.ImmutableDictionary<string, string> __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU)
            {
                __IEhppuLa8ObNKomtEN2FJQ that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Te3MEvRk27ZPZKB7PQsJRU != this.__p_Te3MEvRk27ZPZKB7PQsJRU || __p_ICQppyLURvOMfLGMhYC53x != this.__p_ICQppyLURvOMfLGMhYC53x || __p_Mf2ViQNzkWpPOpGFcNJ9wx != this.__p_Mf2ViQNzkWpPOpGFcNJ9wx || __pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx != this.__pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx || __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD != this.__pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD || __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS != this.__pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS || __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU != this.__pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU ? new __IEhppuLa8ObNKomtEN2FJQ(this)
                    {__p_Te3MEvRk27ZPZKB7PQsJRU = __p_Te3MEvRk27ZPZKB7PQsJRU, __p_ICQppyLURvOMfLGMhYC53x = __p_ICQppyLURvOMfLGMhYC53x, __p_Mf2ViQNzkWpPOpGFcNJ9wx = __p_Mf2ViQNzkWpPOpGFcNJ9wx, __pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx = __pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx, __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD = __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD, __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS = __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS, __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU = __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU} : that_0;
                else
                {
                    this.__p_Te3MEvRk27ZPZKB7PQsJRU = __p_Te3MEvRk27ZPZKB7PQsJRU;
                    this.__p_ICQppyLURvOMfLGMhYC53x = __p_ICQppyLURvOMfLGMhYC53x;
                    this.__p_Mf2ViQNzkWpPOpGFcNJ9wx = __p_Mf2ViQNzkWpPOpGFcNJ9wx;
                    this.__pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx = __pin_group_Parameters_In_Mf2ViQNzkWpPOpGFcNJ9wx;
                    this.__pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD = __pin_group_Input_In_IU1N3O1Ed6cPisYNDXuoYD;
                    this.__pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS = __pin_group_Input_In_L3jh9ePSYGSNOgllupQIIS;
                    this.__pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU = __pin_group_Arguments_In_Te3MEvRk27ZPZKB7PQsJRU;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 345004U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "V8ZZcLjAhOINWr9UT4pghx", Name = "ForwardDifference_V8ZZcLjAhOINWr9UT4pghx")]
    [n2.SerializableAttribute]
    public class ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n18.ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n18.ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> CreateDefault()
        {
            var instance = new ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n18.ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> Update(n5.GpuValue<float> Function_In, n5.GpuValue<T> Position_In, n5.GpuValue<float> Epsilon_In, out n5.GpuValue<T> Output_Out)
        {
            string __pad_BJWgtiEFUP2LADHERiklb6_0 = __slot_BJWgtiEFUP2LADHERiklb6;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_BnaF9iLrKueOAw6hcPHS2n;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, string, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_4 = (Position_In, Epsilon_In, __pad_BJWgtiEFUP2LADHERiklb6_0, Function_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__M97H733WWP0NBDFPKu2d0p>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __M97H733WWP0NBDFPKu2d0p(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY = n11._Operations_.CreateDefault<n5.AbstractGpuValue>(), __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv = n11._Operations_.CreateDefault<n5.IFunctionInvokeNode>(), __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R = n23._Operations_.CreateDefault<string, string>(), __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "AaU8FF9jgKCLWWsutLmIXr", 345043U);
                    var Output_9 = n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>>.Create(Node_Context: Node_Context_8);
                    state_7.__p_AaU8FF9jgKCLWWsutLmIXr = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "UYvquGC6TciLMviiT8JICo", 345139U);
                    var Output_11 = n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_10);
                    state_7.__p_UYvquGC6TciLMviiT8JICo = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "TBox7yDUOKQOABjqnPG2sY", 345158U);
                    var Output_13 = n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.Create(Node_Context: Node_Context_12);
                    state_7.__p_TBox7yDUOKQOABjqnPG2sY = Output_13;
                }

                string __pad_VggZIwO7PjGNJZRoI6r79c_14 = __slot_VggZIwO7PjGNJZRoI6r79c;
                string __pad_BpWW66Q50Y0ODLXs4Czr63_15 = __slot_BpWW66Q50Y0ODLXs4Czr63;
                float __pad_EKhd6HmGevZL1L3n3MGcvv_16 = __slot_EKhd6HmGevZL1L3n3MGcvv;
                var State_Output_18 = state_7.__p_UYvquGC6TciLMviiT8JICo.Update(GpuValue_In: Epsilon_In, The_Value_In: __pad_EKhd6HmGevZL1L3n3MGcvv_16, Output_Out: out n5.GpuValue<float> Output_17);
                var builder_19 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY, 1);
                builder_19.Add(Position_In);
                var __pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY_20 = builder_19.Commit();
                var State_Output_22 = state_7.__p_TBox7yDUOKQOABjqnPG2sY.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY_20, Id_In: __pad_VggZIwO7PjGNJZRoI6r79c_14, Output_Out: out n5.FunctionInvokeNode<float> Output_21);
                n5.IFunctionInvokeNode Input_23 = (n5.IFunctionInvokeNode)Output_21;
                var builder_24 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv, 1);
                builder_24.Add(Input_23);
                var __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv_25 = builder_24.Commit();
                n11._Operations_.FromValue<n5.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv_25, Result_Out: out n10.Spread<n5.IFunctionInvokeNode> Result_26);
                var Result_27 = n5.TypeHelpers.GetDimension<T>(theValue: Position_In);
                var Result_28 = n21.ObjectHelpers.ToString(input: Result_27);
                var builder_29 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R, 1);
                builder_29.Add("DomainDimension", Result_28);
                var __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R_30 = builder_29.Commit();
                n23._Operations_.Cons<string>(Input_In: __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R_30, Output_Out: out n22.ImmutableDictionary<string, string> Output_31);
                n5.GpuValue<T> Default_Result_32 = default(n5.GpuValue<T>);
                n13.IEnumerable<string> Mixins_33 = n24._Operations_.CreateDefault<string>();
                bool Is_Groupable_34 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_35 = n24._Operations_.CreateDefault<n5.InputModifier>();
                var builder_36 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr, 2);
                builder_36.Add(Position_In);
                builder_36.Add(Output_17);
                var __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr_37 = builder_36.Commit();
                var State_Output_40 = state_7.__p_AaU8FF9jgKCLWWsutLmIXr.Update(Arguments_In: __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr_37, Function_Name_In: __pad_BpWW66Q50Y0ODLXs4Czr63_15, Code_Template_In: __pad_BJWgtiEFUP2LADHERiklb6_0, Default_Result_In: Default_Result_32, Functions_In: Result_26, Mixins_In: Mixins_33, Template_Values_In: Output_31, Is_Groupable_In: Is_Groupable_34, The_Modifiers_In: The_Modifiers_35, Output_Out: out n5.GpuValue<T> Output_38, AdditionalOutputs_Out: out n10.Spread<n5.AbstractGpuValue> AdditionalOutputs_39);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_18 != state_7.__p_UYvquGC6TciLMviiT8JICo || __pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY_20 != state_7.__pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY || State_Output_22 != state_7.__p_TBox7yDUOKQOABjqnPG2sY || __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv_25 != state_7.__pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv || __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R_30 != state_7.__pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R || __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr_37 != state_7.__pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr || State_Output_40 != state_7.__p_AaU8FF9jgKCLWWsutLmIXr ? new __M97H733WWP0NBDFPKu2d0p(state_7)
                    {__p_UYvquGC6TciLMviiT8JICo = State_Output_18, __pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY = __pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY_20, __p_TBox7yDUOKQOABjqnPG2sY = State_Output_22, __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv = __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv_25, __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R = __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R_30, __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr = __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr_37, __p_AaU8FF9jgKCLWWsutLmIXr = State_Output_40} : state_7;
                else
                {
                    state_7.__p_UYvquGC6TciLMviiT8JICo = State_Output_18;
                    state_7.__pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY = __pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY_20;
                    state_7.__p_TBox7yDUOKQOABjqnPG2sY = State_Output_22;
                    state_7.__pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv = __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv_25;
                    state_7.__pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R = __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R_30;
                    state_7.__pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr = __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr_37;
                    state_7.__p_AaU8FF9jgKCLWWsutLmIXr = State_Output_40;
                }

                outputs_5 = n2.ValueTuple.Create(Output_38);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_41 = outputs_5.Item1;
            Output_Out = __auto_41;
            n18.ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> that_42 = this;
            if (this.__GetContext__().IsImmutable)
                that_42 = manager_3 != this.__cache_BnaF9iLrKueOAw6hcPHS2n ? new ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T>(this)
                {__cache_BnaF9iLrKueOAw6hcPHS2n = manager_3} : that_42;
            else
            {
                this.__cache_BnaF9iLrKueOAw6hcPHS2n = manager_3;
            }

            return that_42;
        }

        public n18.ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n18.ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> that_0 = this;
            this.__cache_BnaF9iLrKueOAw6hcPHS2n = null;
            return that_0;
        }

        public n18.ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> __CreateDefault__()
        {
            n18.ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> that_0 = this;
            this.__cache_BnaF9iLrKueOAw6hcPHS2n = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_BnaF9iLrKueOAw6hcPHS2n);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 345188U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "BJWgtiEFUP2LADHERiklb6", Name = "__slot_BJWgtiEFUP2LADHERiklb6")]
        public static string __slot_BJWgtiEFUP2LADHERiklb6 = "${resultType} ${signature} (${resultType} p,float e)\r\n{\r\n\r\n    ${resultType} result = ${function}(p);\r\n    ${resultType} offset = 0.;  \r\n\r\n    for(int i = 0; i < ${DomainDimension}; i++)\r\n    {\r\n        ${resultType} offset = .0;\r\n        offset[i] = e;\r\n        result[i] =( ${function}(p + offset) -  result[i]) /  e;\r\n    }\r\n\r\n    return result;\r\n}";
        [n1.ElementAttribute(TracingId = 345193U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "J0kgxdhIXzfM7BJxVJgA27", Name = "__slot_J0kgxdhIXzfM7BJxVJgA27")]
        public static string __slot_J0kgxdhIXzfM7BJxVJgA27 = "note that the [i] here is actully indexing vector component, not an array!";
        [n1.ElementAttribute(TracingId = 345009U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "BnaF9iLrKueOAw6hcPHS2n", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, string, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_BnaF9iLrKueOAw6hcPHS2n = null;
        [n1.ElementAttribute(TracingId = 345101U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "VggZIwO7PjGNJZRoI6r79c", Name = "__slot_VggZIwO7PjGNJZRoI6r79c")]
        public static string __slot_VggZIwO7PjGNJZRoI6r79c = "function";
        [n1.ElementAttribute(TracingId = 345105U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "BpWW66Q50Y0ODLXs4Czr63", Name = "__slot_BpWW66Q50Y0ODLXs4Czr63")]
        public static string __slot_BpWW66Q50Y0ODLXs4Czr63 = "FD_Gradient";
        [n1.ElementAttribute(TracingId = 345152U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "EKhd6HmGevZL1L3n3MGcvv", Name = "__slot_EKhd6HmGevZL1L3n3MGcvv")]
        public static float __slot_EKhd6HmGevZL1L3n3MGcvv = 0.001F;
        static ForwardDifference_V8ZZcLjAhOINWr9UT4pghx()
        {
        }

        public ForwardDifference_V8ZZcLjAhOINWr9UT4pghx(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ForwardDifference_V8ZZcLjAhOINWr9UT4pghx(ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> other): base(other)
        {
            this.__cache_BnaF9iLrKueOAw6hcPHS2n = other.__cache_BnaF9iLrKueOAw6hcPHS2n;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_BnaF9iLrKueOAw6hcPHS2n", in __cache_BnaF9iLrKueOAw6hcPHS2n));
        }

        internal ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, string, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_BnaF9iLrKueOAw6hcPHS2n)
        {
            n18.ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_BnaF9iLrKueOAw6hcPHS2n != this.__cache_BnaF9iLrKueOAw6hcPHS2n ? new ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T>(this)
                {__cache_BnaF9iLrKueOAw6hcPHS2n = __cache_BnaF9iLrKueOAw6hcPHS2n} : that_0;
            else
            {
                this.__cache_BnaF9iLrKueOAw6hcPHS2n = __cache_BnaF9iLrKueOAw6hcPHS2n;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "M97H733WWP0NBDFPKu2d0p", Name = "__M97H733WWP0NBDFPKu2d0p")]
        [n2.SerializableAttribute]
        public class __M97H733WWP0NBDFPKu2d0p : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_AaU8FF9jgKCLWWsutLmIXr);
                n1.CompilationHelper.SafeDispose(this.__p_UYvquGC6TciLMviiT8JICo);
                n1.CompilationHelper.SafeDispose(this.__p_TBox7yDUOKQOABjqnPG2sY);
                return;
            }

            [n1.ElementAttribute(TracingId = 345043U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "AaU8FF9jgKCLWWsutLmIXr", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>> __p_AaU8FF9jgKCLWWsutLmIXr;
            [n1.ElementAttribute(TracingId = 345139U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "UYvquGC6TciLMviiT8JICo", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_UYvquGC6TciLMviiT8JICo;
            [n1.ElementAttribute(TracingId = 345158U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "TBox7yDUOKQOABjqnPG2sY", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_TBox7yDUOKQOABjqnPG2sY;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY = default(n10.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.IFunctionInvokeNode> __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv = default(n10.Spread<n5.IFunctionInvokeNode>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n22.ImmutableDictionary<string, string> __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R = default(n22.ImmutableDictionary<string, string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr = default(n10.Spread<n5.AbstractGpuValue>);
            public __M97H733WWP0NBDFPKu2d0p(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __M97H733WWP0NBDFPKu2d0p(__M97H733WWP0NBDFPKu2d0p other): base(other)
            {
                this.__p_AaU8FF9jgKCLWWsutLmIXr = other.__p_AaU8FF9jgKCLWWsutLmIXr;
                this.__p_UYvquGC6TciLMviiT8JICo = other.__p_UYvquGC6TciLMviiT8JICo;
                this.__p_TBox7yDUOKQOABjqnPG2sY = other.__p_TBox7yDUOKQOABjqnPG2sY;
                this.__pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY = other.__pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY;
                this.__pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv = other.__pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv;
                this.__pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R = other.__pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R;
                this.__pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr = other.__pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AaU8FF9jgKCLWWsutLmIXr", in __p_AaU8FF9jgKCLWWsutLmIXr), n1.CompilationHelper.GetValueOrExisting(values, "__p_UYvquGC6TciLMviiT8JICo", in __p_UYvquGC6TciLMviiT8JICo), n1.CompilationHelper.GetValueOrExisting(values, "__p_TBox7yDUOKQOABjqnPG2sY", in __p_TBox7yDUOKQOABjqnPG2sY), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY", in __pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv", in __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R", in __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr", in __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr));
            }

            internal __M97H733WWP0NBDFPKu2d0p __WITH__(n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>> __p_AaU8FF9jgKCLWWsutLmIXr, n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_UYvquGC6TciLMviiT8JICo, n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_TBox7yDUOKQOABjqnPG2sY, n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY, n10.Spread<n5.IFunctionInvokeNode> __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv, n22.ImmutableDictionary<string, string> __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr)
            {
                __M97H733WWP0NBDFPKu2d0p that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_AaU8FF9jgKCLWWsutLmIXr != this.__p_AaU8FF9jgKCLWWsutLmIXr || __p_UYvquGC6TciLMviiT8JICo != this.__p_UYvquGC6TciLMviiT8JICo || __p_TBox7yDUOKQOABjqnPG2sY != this.__p_TBox7yDUOKQOABjqnPG2sY || __pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY != this.__pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY || __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv != this.__pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv || __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R != this.__pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R || __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr != this.__pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr ? new __M97H733WWP0NBDFPKu2d0p(this)
                    {__p_AaU8FF9jgKCLWWsutLmIXr = __p_AaU8FF9jgKCLWWsutLmIXr, __p_UYvquGC6TciLMviiT8JICo = __p_UYvquGC6TciLMviiT8JICo, __p_TBox7yDUOKQOABjqnPG2sY = __p_TBox7yDUOKQOABjqnPG2sY, __pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY = __pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY, __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv = __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv, __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R = __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R, __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr = __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr} : that_0;
                else
                {
                    this.__p_AaU8FF9jgKCLWWsutLmIXr = __p_AaU8FF9jgKCLWWsutLmIXr;
                    this.__p_UYvquGC6TciLMviiT8JICo = __p_UYvquGC6TciLMviiT8JICo;
                    this.__p_TBox7yDUOKQOABjqnPG2sY = __p_TBox7yDUOKQOABjqnPG2sY;
                    this.__pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY = __pin_group_Parameters_In_TBox7yDUOKQOABjqnPG2sY;
                    this.__pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv = __pin_group_Input_In_KO5X9ThAoqRPCLESkGHHjv;
                    this.__pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R = __pin_group_Input_In_SqVkIpb1XpSL8HXcbVuN3R;
                    this.__pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr = __pin_group_Arguments_In_AaU8FF9jgKCLWWsutLmIXr;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 345329U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "UqHIUJwy2p3LqhW4mMaM9B", Name = "FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B")]
    [n2.SerializableAttribute]
    public class FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n18.FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n18.FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> CreateDefault()
        {
            var instance = new FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n18.FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> Update(n5.GpuValue<float> Function_In, n5.GpuValue<T> Position_In, n5.GpuValue<float> Epsilon_In, out n5.GpuValue<T> Output_Out)
        {
            string __pad_D17SGsPC7i8L3LCm8E5iVa_0 = __slot_D17SGsPC7i8L3LCm8E5iVa;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_RkvojUk7MKCO09noQZldIG;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, string, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_4 = (Position_In, Epsilon_In, __pad_D17SGsPC7i8L3LCm8E5iVa_0, Function_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__BOGjP5HfEr7MCp8VAvVW7g>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __BOGjP5HfEr7MCp8VAvVW7g(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs = n11._Operations_.CreateDefault<n5.AbstractGpuValue>(), __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi = n11._Operations_.CreateDefault<n5.IFunctionInvokeNode>(), __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9 = n23._Operations_.CreateDefault<string, string>(), __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "FYx4JtvyRlVLwIfCziq3Zl", 345375U);
                    var Output_9 = n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>>.Create(Node_Context: Node_Context_8);
                    state_7.__p_FYx4JtvyRlVLwIfCziq3Zl = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "G2LyQ6QUxaXNd8NxUZwjLt", 345471U);
                    var Output_11 = n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_10);
                    state_7.__p_G2LyQ6QUxaXNd8NxUZwjLt = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "USw8SsEuCF4Ok83gMgWZgs", 345491U);
                    var Output_13 = n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.Create(Node_Context: Node_Context_12);
                    state_7.__p_USw8SsEuCF4Ok83gMgWZgs = Output_13;
                }

                string __pad_JNjfcZtZeOFNsbqNXiI5N9_14 = __slot_JNjfcZtZeOFNsbqNXiI5N9;
                string __pad_CzZLNVRqhgpPcamcbhIWlJ_15 = __slot_CzZLNVRqhgpPcamcbhIWlJ;
                float __pad_RJLAvffSOHlOSHnqw9IuKM_16 = __slot_RJLAvffSOHlOSHnqw9IuKM;
                var State_Output_18 = state_7.__p_G2LyQ6QUxaXNd8NxUZwjLt.Update(GpuValue_In: Epsilon_In, The_Value_In: __pad_RJLAvffSOHlOSHnqw9IuKM_16, Output_Out: out n5.GpuValue<float> Output_17);
                var builder_19 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs, 1);
                builder_19.Add(Position_In);
                var __pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs_20 = builder_19.Commit();
                var State_Output_22 = state_7.__p_USw8SsEuCF4Ok83gMgWZgs.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs_20, Id_In: __pad_JNjfcZtZeOFNsbqNXiI5N9_14, Output_Out: out n5.FunctionInvokeNode<float> Output_21);
                n5.IFunctionInvokeNode Input_23 = (n5.IFunctionInvokeNode)Output_21;
                var builder_24 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi, 1);
                builder_24.Add(Input_23);
                var __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi_25 = builder_24.Commit();
                n11._Operations_.FromValue<n5.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi_25, Result_Out: out n10.Spread<n5.IFunctionInvokeNode> Result_26);
                var Result_27 = n5.TypeHelpers.GetDimension<T>(theValue: Position_In);
                var Result_28 = n21.ObjectHelpers.ToString(input: Result_27);
                var builder_29 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9, 1);
                builder_29.Add("DomainDimension", Result_28);
                var __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9_30 = builder_29.Commit();
                n23._Operations_.Cons<string>(Input_In: __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9_30, Output_Out: out n22.ImmutableDictionary<string, string> Output_31);
                n5.GpuValue<T> Default_Result_32 = default(n5.GpuValue<T>);
                n13.IEnumerable<string> Mixins_33 = n24._Operations_.CreateDefault<string>();
                bool Is_Groupable_34 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_35 = n24._Operations_.CreateDefault<n5.InputModifier>();
                var builder_36 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl, 2);
                builder_36.Add(Position_In);
                builder_36.Add(Output_17);
                var __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl_37 = builder_36.Commit();
                var State_Output_40 = state_7.__p_FYx4JtvyRlVLwIfCziq3Zl.Update(Arguments_In: __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl_37, Function_Name_In: __pad_CzZLNVRqhgpPcamcbhIWlJ_15, Code_Template_In: __pad_D17SGsPC7i8L3LCm8E5iVa_0, Default_Result_In: Default_Result_32, Functions_In: Result_26, Mixins_In: Mixins_33, Template_Values_In: Output_31, Is_Groupable_In: Is_Groupable_34, The_Modifiers_In: The_Modifiers_35, Output_Out: out n5.GpuValue<T> Output_38, AdditionalOutputs_Out: out n10.Spread<n5.AbstractGpuValue> AdditionalOutputs_39);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_18 != state_7.__p_G2LyQ6QUxaXNd8NxUZwjLt || __pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs_20 != state_7.__pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs || State_Output_22 != state_7.__p_USw8SsEuCF4Ok83gMgWZgs || __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi_25 != state_7.__pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi || __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9_30 != state_7.__pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9 || __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl_37 != state_7.__pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl || State_Output_40 != state_7.__p_FYx4JtvyRlVLwIfCziq3Zl ? new __BOGjP5HfEr7MCp8VAvVW7g(state_7)
                    {__p_G2LyQ6QUxaXNd8NxUZwjLt = State_Output_18, __pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs = __pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs_20, __p_USw8SsEuCF4Ok83gMgWZgs = State_Output_22, __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi = __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi_25, __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9 = __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9_30, __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl = __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl_37, __p_FYx4JtvyRlVLwIfCziq3Zl = State_Output_40} : state_7;
                else
                {
                    state_7.__p_G2LyQ6QUxaXNd8NxUZwjLt = State_Output_18;
                    state_7.__pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs = __pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs_20;
                    state_7.__p_USw8SsEuCF4Ok83gMgWZgs = State_Output_22;
                    state_7.__pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi = __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi_25;
                    state_7.__pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9 = __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9_30;
                    state_7.__pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl = __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl_37;
                    state_7.__p_FYx4JtvyRlVLwIfCziq3Zl = State_Output_40;
                }

                outputs_5 = n2.ValueTuple.Create(Output_38);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_41 = outputs_5.Item1;
            Output_Out = __auto_41;
            n18.FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> that_42 = this;
            if (this.__GetContext__().IsImmutable)
                that_42 = manager_3 != this.__cache_RkvojUk7MKCO09noQZldIG ? new FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T>(this)
                {__cache_RkvojUk7MKCO09noQZldIG = manager_3} : that_42;
            else
            {
                this.__cache_RkvojUk7MKCO09noQZldIG = manager_3;
            }

            return that_42;
        }

        public n18.FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n18.FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> that_0 = this;
            this.__cache_RkvojUk7MKCO09noQZldIG = null;
            return that_0;
        }

        public n18.FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> __CreateDefault__()
        {
            n18.FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> that_0 = this;
            this.__cache_RkvojUk7MKCO09noQZldIG = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_RkvojUk7MKCO09noQZldIG);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 345518U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "D17SGsPC7i8L3LCm8E5iVa", Name = "__slot_D17SGsPC7i8L3LCm8E5iVa")]
        public static string __slot_D17SGsPC7i8L3LCm8E5iVa = "${resultType} ${signature} (${resultType} p,float e)\r\n{\r\n\r\n    ${resultType} result = 0.;\r\n    ${resultType} offset = 0.;  \r\n\r\n    for(int i = 0; i < ${DomainDimension}; i++)\r\n    {\r\n        ${resultType} offset = .0;\r\n        offset[i] = e;\r\n        ${resultType} offset2 = offset * 2.;\r\n        // (-F(p + offset2) + 8. * F(p + offset) - 8. * F(p - offset) + F(p - offset2) ) / (12. * e);\r\n        result[i] = (-${function}(p + offset2) + 8. * ${function}(p + offset) - 8. * ${function}(p - offset) + ${function}(p - offset2) ) / (12. * e);\r\n    }\r\n\r\n    return result;\r\n}";
        [n1.ElementAttribute(TracingId = 345525U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "VtU5gVxXW8vNyQVw2AVoXA", Name = "__slot_VtU5gVxXW8vNyQVw2AVoXA")]
        public static string __slot_VtU5gVxXW8vNyQVw2AVoXA = "        // (-F(p + offset2) + 8. * F(p + offset) - 8. * F(p - offset) + F(p - offset2) ) / (12. * e);";
        [n1.ElementAttribute(TracingId = 345537U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "FGJVadkEYitOeoFcpoZm72", Name = "__slot_FGJVadkEYitOeoFcpoZm72")]
        public static string __slot_FGJVadkEYitOeoFcpoZm72 = "note that the [i] here is actully indexing vector component, not an array!";
        [n1.ElementAttribute(TracingId = 345336U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "RkvojUk7MKCO09noQZldIG", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, string, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_RkvojUk7MKCO09noQZldIG = null;
        [n1.ElementAttribute(TracingId = 345442U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "JNjfcZtZeOFNsbqNXiI5N9", Name = "__slot_JNjfcZtZeOFNsbqNXiI5N9")]
        public static string __slot_JNjfcZtZeOFNsbqNXiI5N9 = "function";
        [n1.ElementAttribute(TracingId = 345448U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "CzZLNVRqhgpPcamcbhIWlJ", Name = "__slot_CzZLNVRqhgpPcamcbhIWlJ")]
        public static string __slot_CzZLNVRqhgpPcamcbhIWlJ = "GradientFivePoint";
        [n1.ElementAttribute(TracingId = 345485U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "RJLAvffSOHlOSHnqw9IuKM", Name = "__slot_RJLAvffSOHlOSHnqw9IuKM")]
        public static float __slot_RJLAvffSOHlOSHnqw9IuKM = 0.001F;
        static FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B()
        {
        }

        public FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B(FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> other): base(other)
        {
            this.__cache_RkvojUk7MKCO09noQZldIG = other.__cache_RkvojUk7MKCO09noQZldIG;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_RkvojUk7MKCO09noQZldIG", in __cache_RkvojUk7MKCO09noQZldIG));
        }

        internal FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, string, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_RkvojUk7MKCO09noQZldIG)
        {
            n18.FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_RkvojUk7MKCO09noQZldIG != this.__cache_RkvojUk7MKCO09noQZldIG ? new FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T>(this)
                {__cache_RkvojUk7MKCO09noQZldIG = __cache_RkvojUk7MKCO09noQZldIG} : that_0;
            else
            {
                this.__cache_RkvojUk7MKCO09noQZldIG = __cache_RkvojUk7MKCO09noQZldIG;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "BOGjP5HfEr7MCp8VAvVW7g", Name = "__BOGjP5HfEr7MCp8VAvVW7g")]
        [n2.SerializableAttribute]
        public class __BOGjP5HfEr7MCp8VAvVW7g : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_FYx4JtvyRlVLwIfCziq3Zl);
                n1.CompilationHelper.SafeDispose(this.__p_G2LyQ6QUxaXNd8NxUZwjLt);
                n1.CompilationHelper.SafeDispose(this.__p_USw8SsEuCF4Ok83gMgWZgs);
                return;
            }

            [n1.ElementAttribute(TracingId = 345375U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "FYx4JtvyRlVLwIfCziq3Zl", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>> __p_FYx4JtvyRlVLwIfCziq3Zl;
            [n1.ElementAttribute(TracingId = 345471U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "G2LyQ6QUxaXNd8NxUZwjLt", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_G2LyQ6QUxaXNd8NxUZwjLt;
            [n1.ElementAttribute(TracingId = 345491U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "USw8SsEuCF4Ok83gMgWZgs", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_USw8SsEuCF4Ok83gMgWZgs;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs = default(n10.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.IFunctionInvokeNode> __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi = default(n10.Spread<n5.IFunctionInvokeNode>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n22.ImmutableDictionary<string, string> __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9 = default(n22.ImmutableDictionary<string, string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl = default(n10.Spread<n5.AbstractGpuValue>);
            public __BOGjP5HfEr7MCp8VAvVW7g(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BOGjP5HfEr7MCp8VAvVW7g(__BOGjP5HfEr7MCp8VAvVW7g other): base(other)
            {
                this.__p_FYx4JtvyRlVLwIfCziq3Zl = other.__p_FYx4JtvyRlVLwIfCziq3Zl;
                this.__p_G2LyQ6QUxaXNd8NxUZwjLt = other.__p_G2LyQ6QUxaXNd8NxUZwjLt;
                this.__p_USw8SsEuCF4Ok83gMgWZgs = other.__p_USw8SsEuCF4Ok83gMgWZgs;
                this.__pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs = other.__pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs;
                this.__pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi = other.__pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi;
                this.__pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9 = other.__pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9;
                this.__pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl = other.__pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FYx4JtvyRlVLwIfCziq3Zl", in __p_FYx4JtvyRlVLwIfCziq3Zl), n1.CompilationHelper.GetValueOrExisting(values, "__p_G2LyQ6QUxaXNd8NxUZwjLt", in __p_G2LyQ6QUxaXNd8NxUZwjLt), n1.CompilationHelper.GetValueOrExisting(values, "__p_USw8SsEuCF4Ok83gMgWZgs", in __p_USw8SsEuCF4Ok83gMgWZgs), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs", in __pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi", in __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9", in __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl", in __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl));
            }

            internal __BOGjP5HfEr7MCp8VAvVW7g __WITH__(n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>> __p_FYx4JtvyRlVLwIfCziq3Zl, n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_G2LyQ6QUxaXNd8NxUZwjLt, n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_USw8SsEuCF4Ok83gMgWZgs, n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs, n10.Spread<n5.IFunctionInvokeNode> __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi, n22.ImmutableDictionary<string, string> __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl)
            {
                __BOGjP5HfEr7MCp8VAvVW7g that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_FYx4JtvyRlVLwIfCziq3Zl != this.__p_FYx4JtvyRlVLwIfCziq3Zl || __p_G2LyQ6QUxaXNd8NxUZwjLt != this.__p_G2LyQ6QUxaXNd8NxUZwjLt || __p_USw8SsEuCF4Ok83gMgWZgs != this.__p_USw8SsEuCF4Ok83gMgWZgs || __pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs != this.__pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs || __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi != this.__pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi || __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9 != this.__pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9 || __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl != this.__pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl ? new __BOGjP5HfEr7MCp8VAvVW7g(this)
                    {__p_FYx4JtvyRlVLwIfCziq3Zl = __p_FYx4JtvyRlVLwIfCziq3Zl, __p_G2LyQ6QUxaXNd8NxUZwjLt = __p_G2LyQ6QUxaXNd8NxUZwjLt, __p_USw8SsEuCF4Ok83gMgWZgs = __p_USw8SsEuCF4Ok83gMgWZgs, __pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs = __pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs, __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi = __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi, __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9 = __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9, __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl = __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl} : that_0;
                else
                {
                    this.__p_FYx4JtvyRlVLwIfCziq3Zl = __p_FYx4JtvyRlVLwIfCziq3Zl;
                    this.__p_G2LyQ6QUxaXNd8NxUZwjLt = __p_G2LyQ6QUxaXNd8NxUZwjLt;
                    this.__p_USw8SsEuCF4Ok83gMgWZgs = __p_USw8SsEuCF4Ok83gMgWZgs;
                    this.__pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs = __pin_group_Parameters_In_USw8SsEuCF4Ok83gMgWZgs;
                    this.__pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi = __pin_group_Input_In_CiResvJDY7LL8WvDBuY6Fi;
                    this.__pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9 = __pin_group_Input_In_GCOoyeBSMssPSKrk6EZON9;
                    this.__pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl = __pin_group_Arguments_In_FYx4JtvyRlVLwIfCziq3Zl;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 345928U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "EJ8X6U6YJ9EMNwQhIeY9Zl", Name = "FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl")]
    [n2.SerializableAttribute]
    public class FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> CreateDefault()
        {
            var instance = new FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> Update<AdM>(n5.GpuValue<float> Function_In, n5.GpuValue<T> Position_In, n5.GpuValue<float> Epsilon_In, [n4.SerializedDefaultValueAttribute("CentralDifference", false)] n15.GradientDifferentiationMode Numerical_Differentiation_Mode_In, bool Normalize_In, out n5.GpuValue<T> Output_Out)
            where AdM : struct, n17.IAdaptiveCreateDefault<n5.GpuValue<T>>
        {
            var w_0 = default(AdM);
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_AZ5qemgzR1FNmXsMzSC2L6;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<T>, n5.GpuValue<float>, n15.GradientDifferentiationMode, bool>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_4 = (Function_In, Position_In, Epsilon_In, Numerical_Differentiation_Mode_In, Normalize_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__P8VDn4a6ARbLiQ147zH1z1>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __P8VDn4a6ARbLiQ147zH1z1(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf = n11._Operations_.CreateDefault<n5.GpuValue<T>>(), __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt = n11._Operations_.CreateDefault<n5.GpuValue<T>>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "UP9Aj4mzKOuL80hgQnbe8F", 345982U);
                    var Output_9 = n18.ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T>.Create(Node_Context: Node_Context_8);
                    state_7.__p_UP9Aj4mzKOuL80hgQnbe8F = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "OagbEphRd1PQG1Tt4yTXlP", 345994U);
                    var Output_11 = n18.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T>.Create(Node_Context: Node_Context_10);
                    state_7.__p_OagbEphRd1PQG1Tt4yTXlP = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "PKKiGCwAlSbMBMkqXlJf45", 346012U);
                    var Output_13 = n18.FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T>.Create(Node_Context: Node_Context_12);
                    state_7.__p_PKKiGCwAlSbMBMkqXlJf45 = Output_13;
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "D7SCi9hWpFyPLf7Q9tzisQ", 346027U);
                    var Output_15 = n7.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<T>.Create(Node_Context: Node_Context_14);
                    state_7.__p_D7SCi9hWpFyPLf7Q9tzisQ = Output_15;
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "Gk5rUbWcU7UPWIQD3kwbJq", 346091U);
                    var Output_17 = n9.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T>.Create(Node_Context: Node_Context_16);
                    state_7.__p_Gk5rUbWcU7UPWIQD3kwbJq = Output_17;
                }

                int Index_18 = (int)Numerical_Differentiation_Mode_In;
                int Id_19 = 0;
                var State_Output_21 = state_7.__p_Gk5rUbWcU7UPWIQD3kwbJq.Update(The_Override_In: Position_In, Id_In: Id_19, Output_Out: out n5.GpuValue<T> Output_20);
                var State_Output_23 = state_7.__p_UP9Aj4mzKOuL80hgQnbe8F.Update(Function_In: Function_In, Position_In: Output_20, Epsilon_In: Epsilon_In, Output_Out: out n5.GpuValue<T> Output_22);
                var State_Output_25 = state_7.__p_OagbEphRd1PQG1Tt4yTXlP.Update(Function_In: Function_In, Position_In: Output_20, Epsilon_In: Epsilon_In, Output_Out: out n5.GpuValue<T> Output_24);
                var State_Output_27 = state_7.__p_PKKiGCwAlSbMBMkqXlJf45.Update(Function_In: Function_In, Position_In: Output_20, Epsilon_In: Epsilon_In, Output_Out: out n5.GpuValue<T> Output_26);
                var builder_28 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf, 3);
                builder_28.Add(Output_22);
                builder_28.Add(Output_24);
                builder_28.Add(Output_26);
                var __pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf_29 = builder_28.Commit();
                n16._Operations_.Switch<n5.GpuValue<T>, AdM>(Index_In: Index_18, Input_In: __pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf_29, Output_Out: out n5.GpuValue<T> Output_30);
                int Index_31 = n2.Convert.ToInt32(Normalize_In);
                var State_Output_33 = state_7.__p_D7SCi9hWpFyPLf7Q9tzisQ.Update(Input_In: Output_30, Output_Out: out n5.GpuValue<T> Output_32);
                var builder_34 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt, 2);
                builder_34.Add(Output_30);
                builder_34.Add(Output_32);
                var __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt_35 = builder_34.Commit();
                n16._Operations_.Switch<n5.GpuValue<T>, AdM>(Index_In: Index_31, Input_In: __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt_35, Output_Out: out n5.GpuValue<T> Output_36);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_21 != state_7.__p_Gk5rUbWcU7UPWIQD3kwbJq || State_Output_23 != state_7.__p_UP9Aj4mzKOuL80hgQnbe8F || State_Output_25 != state_7.__p_OagbEphRd1PQG1Tt4yTXlP || State_Output_27 != state_7.__p_PKKiGCwAlSbMBMkqXlJf45 || __pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf_29 != state_7.__pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf || State_Output_33 != state_7.__p_D7SCi9hWpFyPLf7Q9tzisQ || __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt_35 != state_7.__pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt ? new __P8VDn4a6ARbLiQ147zH1z1(state_7)
                    {__p_Gk5rUbWcU7UPWIQD3kwbJq = State_Output_21, __p_UP9Aj4mzKOuL80hgQnbe8F = State_Output_23, __p_OagbEphRd1PQG1Tt4yTXlP = State_Output_25, __p_PKKiGCwAlSbMBMkqXlJf45 = State_Output_27, __pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf = __pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf_29, __p_D7SCi9hWpFyPLf7Q9tzisQ = State_Output_33, __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt = __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt_35} : state_7;
                else
                {
                    state_7.__p_Gk5rUbWcU7UPWIQD3kwbJq = State_Output_21;
                    state_7.__p_UP9Aj4mzKOuL80hgQnbe8F = State_Output_23;
                    state_7.__p_OagbEphRd1PQG1Tt4yTXlP = State_Output_25;
                    state_7.__p_PKKiGCwAlSbMBMkqXlJf45 = State_Output_27;
                    state_7.__pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf = __pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf_29;
                    state_7.__p_D7SCi9hWpFyPLf7Q9tzisQ = State_Output_33;
                    state_7.__pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt = __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt_35;
                }

                outputs_5 = n2.ValueTuple.Create(Output_36);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_37 = outputs_5.Item1;
            Output_Out = __auto_37;
            n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> that_38 = this;
            if (this.__GetContext__().IsImmutable)
                that_38 = manager_3 != this.__cache_AZ5qemgzR1FNmXsMzSC2L6 ? new FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T>(this)
                {__cache_AZ5qemgzR1FNmXsMzSC2L6 = manager_3} : that_38;
            else
            {
                this.__cache_AZ5qemgzR1FNmXsMzSC2L6 = manager_3;
            }

            return that_38;
        }

        public n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> that_0 = this;
            this.__cache_AZ5qemgzR1FNmXsMzSC2L6 = null;
            return that_0;
        }

        public n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> __CreateDefault__()
        {
            n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> that_0 = this;
            this.__cache_AZ5qemgzR1FNmXsMzSC2L6 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_AZ5qemgzR1FNmXsMzSC2L6);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 345934U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "AZ5qemgzR1FNmXsMzSC2L6", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<T>, n5.GpuValue<float>, n15.GradientDifferentiationMode, bool>, n2.ValueTuple<n5.GpuValue<T>>> __cache_AZ5qemgzR1FNmXsMzSC2L6 = null;
        public FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl(FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> other): base(other)
        {
            this.__cache_AZ5qemgzR1FNmXsMzSC2L6 = other.__cache_AZ5qemgzR1FNmXsMzSC2L6;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_AZ5qemgzR1FNmXsMzSC2L6", in __cache_AZ5qemgzR1FNmXsMzSC2L6));
        }

        internal FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<T>, n5.GpuValue<float>, n15.GradientDifferentiationMode, bool>, n2.ValueTuple<n5.GpuValue<T>>> __cache_AZ5qemgzR1FNmXsMzSC2L6)
        {
            n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_AZ5qemgzR1FNmXsMzSC2L6 != this.__cache_AZ5qemgzR1FNmXsMzSC2L6 ? new FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T>(this)
                {__cache_AZ5qemgzR1FNmXsMzSC2L6 = __cache_AZ5qemgzR1FNmXsMzSC2L6} : that_0;
            else
            {
                this.__cache_AZ5qemgzR1FNmXsMzSC2L6 = __cache_AZ5qemgzR1FNmXsMzSC2L6;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "P8VDn4a6ARbLiQ147zH1z1", Name = "__P8VDn4a6ARbLiQ147zH1z1")]
        [n2.SerializableAttribute]
        public class __P8VDn4a6ARbLiQ147zH1z1 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UP9Aj4mzKOuL80hgQnbe8F);
                n1.CompilationHelper.SafeDispose(this.__p_OagbEphRd1PQG1Tt4yTXlP);
                n1.CompilationHelper.SafeDispose(this.__p_PKKiGCwAlSbMBMkqXlJf45);
                n1.CompilationHelper.SafeDispose(this.__p_D7SCi9hWpFyPLf7Q9tzisQ);
                n1.CompilationHelper.SafeDispose(this.__p_Gk5rUbWcU7UPWIQD3kwbJq);
                return;
            }

            [n1.ElementAttribute(TracingId = 345982U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "UP9Aj4mzKOuL80hgQnbe8F", Name = "ForwardDifference", IsManaged = true, IsAutoGenerated = true)]
            public n18.ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> __p_UP9Aj4mzKOuL80hgQnbe8F;
            [n1.ElementAttribute(TracingId = 345994U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "OagbEphRd1PQG1Tt4yTXlP", Name = "CentralDifference", IsManaged = true, IsAutoGenerated = true)]
            public n18.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> __p_OagbEphRd1PQG1Tt4yTXlP;
            [n1.ElementAttribute(TracingId = 346012U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "PKKiGCwAlSbMBMkqXlJf45", Name = "FivePointStencil", IsManaged = true, IsAutoGenerated = true)]
            public n18.FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> __p_PKKiGCwAlSbMBMkqXlJf45;
            [n1.ElementAttribute(TracingId = 346027U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "D7SCi9hWpFyPLf7Q9tzisQ", Name = "Normalize", IsManaged = true, IsAutoGenerated = true)]
            public n7.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<T> __p_D7SCi9hWpFyPLf7Q9tzisQ;
            [n1.ElementAttribute(TracingId = 346091U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Gk5rUbWcU7UPWIQD3kwbJq", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n9.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T> __p_Gk5rUbWcU7UPWIQD3kwbJq;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf = default(n10.Spread<n5.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt = default(n10.Spread<n5.GpuValue<T>>);
            public __P8VDn4a6ARbLiQ147zH1z1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __P8VDn4a6ARbLiQ147zH1z1(__P8VDn4a6ARbLiQ147zH1z1 other): base(other)
            {
                this.__p_UP9Aj4mzKOuL80hgQnbe8F = other.__p_UP9Aj4mzKOuL80hgQnbe8F;
                this.__p_OagbEphRd1PQG1Tt4yTXlP = other.__p_OagbEphRd1PQG1Tt4yTXlP;
                this.__p_PKKiGCwAlSbMBMkqXlJf45 = other.__p_PKKiGCwAlSbMBMkqXlJf45;
                this.__p_D7SCi9hWpFyPLf7Q9tzisQ = other.__p_D7SCi9hWpFyPLf7Q9tzisQ;
                this.__p_Gk5rUbWcU7UPWIQD3kwbJq = other.__p_Gk5rUbWcU7UPWIQD3kwbJq;
                this.__pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf = other.__pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf;
                this.__pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt = other.__pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UP9Aj4mzKOuL80hgQnbe8F", in __p_UP9Aj4mzKOuL80hgQnbe8F), n1.CompilationHelper.GetValueOrExisting(values, "__p_OagbEphRd1PQG1Tt4yTXlP", in __p_OagbEphRd1PQG1Tt4yTXlP), n1.CompilationHelper.GetValueOrExisting(values, "__p_PKKiGCwAlSbMBMkqXlJf45", in __p_PKKiGCwAlSbMBMkqXlJf45), n1.CompilationHelper.GetValueOrExisting(values, "__p_D7SCi9hWpFyPLf7Q9tzisQ", in __p_D7SCi9hWpFyPLf7Q9tzisQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_Gk5rUbWcU7UPWIQD3kwbJq", in __p_Gk5rUbWcU7UPWIQD3kwbJq), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf", in __pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt", in __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt));
            }

            internal __P8VDn4a6ARbLiQ147zH1z1 __WITH__(n18.ForwardDifference_V8ZZcLjAhOINWr9UT4pghx<T> __p_UP9Aj4mzKOuL80hgQnbe8F, n18.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<T> __p_OagbEphRd1PQG1Tt4yTXlP, n18.FivePointStencil_UqHIUJwy2p3LqhW4mMaM9B<T> __p_PKKiGCwAlSbMBMkqXlJf45, n7.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<T> __p_D7SCi9hWpFyPLf7Q9tzisQ, n9.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<T> __p_Gk5rUbWcU7UPWIQD3kwbJq, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf, n10.Spread<n5.GpuValue<T>> __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt)
            {
                __P8VDn4a6ARbLiQ147zH1z1 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_UP9Aj4mzKOuL80hgQnbe8F != this.__p_UP9Aj4mzKOuL80hgQnbe8F || __p_OagbEphRd1PQG1Tt4yTXlP != this.__p_OagbEphRd1PQG1Tt4yTXlP || __p_PKKiGCwAlSbMBMkqXlJf45 != this.__p_PKKiGCwAlSbMBMkqXlJf45 || __p_D7SCi9hWpFyPLf7Q9tzisQ != this.__p_D7SCi9hWpFyPLf7Q9tzisQ || __p_Gk5rUbWcU7UPWIQD3kwbJq != this.__p_Gk5rUbWcU7UPWIQD3kwbJq || __pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf != this.__pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf || __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt != this.__pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt ? new __P8VDn4a6ARbLiQ147zH1z1(this)
                    {__p_UP9Aj4mzKOuL80hgQnbe8F = __p_UP9Aj4mzKOuL80hgQnbe8F, __p_OagbEphRd1PQG1Tt4yTXlP = __p_OagbEphRd1PQG1Tt4yTXlP, __p_PKKiGCwAlSbMBMkqXlJf45 = __p_PKKiGCwAlSbMBMkqXlJf45, __p_D7SCi9hWpFyPLf7Q9tzisQ = __p_D7SCi9hWpFyPLf7Q9tzisQ, __p_Gk5rUbWcU7UPWIQD3kwbJq = __p_Gk5rUbWcU7UPWIQD3kwbJq, __pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf = __pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf, __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt = __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt} : that_0;
                else
                {
                    this.__p_UP9Aj4mzKOuL80hgQnbe8F = __p_UP9Aj4mzKOuL80hgQnbe8F;
                    this.__p_OagbEphRd1PQG1Tt4yTXlP = __p_OagbEphRd1PQG1Tt4yTXlP;
                    this.__p_PKKiGCwAlSbMBMkqXlJf45 = __p_PKKiGCwAlSbMBMkqXlJf45;
                    this.__p_D7SCi9hWpFyPLf7Q9tzisQ = __p_D7SCi9hWpFyPLf7Q9tzisQ;
                    this.__p_Gk5rUbWcU7UPWIQD3kwbJq = __p_Gk5rUbWcU7UPWIQD3kwbJq;
                    this.__pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf = __pin_group_Input_In_LRvqcAUfp3QNi6b7sDrAJf;
                    this.__pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt = __pin_group_Input_In_HPcDLIC0f57LESpiNnCLBt;
                }

                return that_0;
            }
        }
    }
}

namespace _Fuse_Core_Calculus_.Fuse.Core.Calculus.Vector
{
    [n1.ElementAttribute(TracingId = 346606U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "RwpY7CwpNgfPw2hKHAzg1e", Name = "Curl2D_RwpY7CwpNgfPw2hKHAzg1e")]
    [n2.SerializableAttribute]
    public class Curl2D_RwpY7CwpNgfPw2hKHAzg1e : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n25.Curl2D_RwpY7CwpNgfPw2hKHAzg1e Create(n1.NodeContext Node_Context)
        {
            var instance = new Curl2D_RwpY7CwpNgfPw2hKHAzg1e(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n25.Curl2D_RwpY7CwpNgfPw2hKHAzg1e CreateDefault()
        {
            var instance = new Curl2D_RwpY7CwpNgfPw2hKHAzg1e(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.Curl2D_RwpY7CwpNgfPw2hKHAzg1e Update(n5.GpuValue<float> Function_In, n5.GpuValue<n26.Vector2> Position_In, n5.GpuValue<float> Epsilon_In, n15.GradientDifferentiationMode Numerical_Differentiation_Mode_In, bool Normalize_In, out n5.GpuValue<n26.Vector2> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_OLdwUpWDweZPGFYxAVKPl4;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<n26.Vector2>, n5.GpuValue<float>, n15.GradientDifferentiationMode, bool>, n2.ValueTuple<n5.GpuValue<n26.Vector2>>>(n2.ValueTuple.Create(default(n5.GpuValue<n26.Vector2>)));
            }

            var inputs_3 = (Function_In, Position_In, Epsilon_In, Numerical_Differentiation_Mode_In, Normalize_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__S6DpeJYXrMFLyXDcxbWFDo>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __S6DpeJYXrMFLyXDcxbWFDo(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "HwNiMHnzBiRNdHU5N3kDJX", 346633U);
                    var Output_8 = n27.r2d_KlD9gsTHvCZOpnxWlAk1rY.Create(Node_Context: Node_Context_7);
                    state_6.__p_HwNiMHnzBiRNdHU5N3kDJX = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "PWKzphyd2jlL0EBW9mZyl5", 346645U);
                    var Output_10 = n14.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_9);
                    state_6.__p_PWKzphyd2jlL0EBW9mZyl5 = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "V475FW4ouV4MbBL6QZyINZ", 346651U);
                    var Output_12 = n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<n26.Vector2>.Create(Node_Context: Node_Context_11);
                    state_6.__p_V475FW4ouV4MbBL6QZyINZ = Output_12;
                }

                var State_Output_14 = state_6.__p_V475FW4ouV4MbBL6QZyINZ.Update<n28.__AdaptiveImplementations__LdA1ELW7lENLS7wg8ceaPG>(Function_In: Function_In, Position_In: Position_In, Epsilon_In: Epsilon_In, Numerical_Differentiation_Mode_In: Numerical_Differentiation_Mode_In, Normalize_In: Normalize_In, Output_Out: out n5.GpuValue<n26.Vector2> Output_13);
                float Value_15 = 0.25F;
                var Output_17 = state_6.__p_PWKzphyd2jlL0EBW9mZyl5.Update(Value_In: Value_15, GpuValue_Out: out n5.GpuValue<float> GpuValue_16);
                var State_Output_19 = state_6.__p_HwNiMHnzBiRNdHU5N3kDJX.Update(point_In: Output_13, angle_In: GpuValue_16, Output_Out: out n5.GpuValue<n26.Vector2> Output_18);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_14 != state_6.__p_V475FW4ouV4MbBL6QZyINZ || Output_17 != state_6.__p_PWKzphyd2jlL0EBW9mZyl5 || State_Output_19 != state_6.__p_HwNiMHnzBiRNdHU5N3kDJX ? new __S6DpeJYXrMFLyXDcxbWFDo(state_6)
                    {__p_V475FW4ouV4MbBL6QZyINZ = State_Output_14, __p_PWKzphyd2jlL0EBW9mZyl5 = Output_17, __p_HwNiMHnzBiRNdHU5N3kDJX = State_Output_19} : state_6;
                else
                {
                    state_6.__p_V475FW4ouV4MbBL6QZyINZ = State_Output_14;
                    state_6.__p_PWKzphyd2jlL0EBW9mZyl5 = Output_17;
                    state_6.__p_HwNiMHnzBiRNdHU5N3kDJX = State_Output_19;
                }

                outputs_4 = n2.ValueTuple.Create(Output_18);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_20 = outputs_4.Item1;
            Output_Out = __auto_20;
            n25.Curl2D_RwpY7CwpNgfPw2hKHAzg1e that_21 = this;
            if (this.__GetContext__().IsImmutable)
                that_21 = manager_2 != this.__cache_OLdwUpWDweZPGFYxAVKPl4 ? new Curl2D_RwpY7CwpNgfPw2hKHAzg1e(this)
                {__cache_OLdwUpWDweZPGFYxAVKPl4 = manager_2} : that_21;
            else
            {
                this.__cache_OLdwUpWDweZPGFYxAVKPl4 = manager_2;
            }

            return that_21;
        }

        public n25.Curl2D_RwpY7CwpNgfPw2hKHAzg1e __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n25.Curl2D_RwpY7CwpNgfPw2hKHAzg1e that_0 = this;
            this.__cache_OLdwUpWDweZPGFYxAVKPl4 = null;
            return that_0;
        }

        public n25.Curl2D_RwpY7CwpNgfPw2hKHAzg1e __CreateDefault__()
        {
            n25.Curl2D_RwpY7CwpNgfPw2hKHAzg1e that_0 = this;
            this.__cache_OLdwUpWDweZPGFYxAVKPl4 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_OLdwUpWDweZPGFYxAVKPl4);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 346611U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "OLdwUpWDweZPGFYxAVKPl4", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<n26.Vector2>, n5.GpuValue<float>, n15.GradientDifferentiationMode, bool>, n2.ValueTuple<n5.GpuValue<n26.Vector2>>> __cache_OLdwUpWDweZPGFYxAVKPl4 = null;
        public Curl2D_RwpY7CwpNgfPw2hKHAzg1e(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Curl2D_RwpY7CwpNgfPw2hKHAzg1e(Curl2D_RwpY7CwpNgfPw2hKHAzg1e other): base(other)
        {
            this.__cache_OLdwUpWDweZPGFYxAVKPl4 = other.__cache_OLdwUpWDweZPGFYxAVKPl4;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_OLdwUpWDweZPGFYxAVKPl4", in __cache_OLdwUpWDweZPGFYxAVKPl4));
        }

        internal Curl2D_RwpY7CwpNgfPw2hKHAzg1e __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<n26.Vector2>, n5.GpuValue<float>, n15.GradientDifferentiationMode, bool>, n2.ValueTuple<n5.GpuValue<n26.Vector2>>> __cache_OLdwUpWDweZPGFYxAVKPl4)
        {
            n25.Curl2D_RwpY7CwpNgfPw2hKHAzg1e that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_OLdwUpWDweZPGFYxAVKPl4 != this.__cache_OLdwUpWDweZPGFYxAVKPl4 ? new Curl2D_RwpY7CwpNgfPw2hKHAzg1e(this)
                {__cache_OLdwUpWDweZPGFYxAVKPl4 = __cache_OLdwUpWDweZPGFYxAVKPl4} : that_0;
            else
            {
                this.__cache_OLdwUpWDweZPGFYxAVKPl4 = __cache_OLdwUpWDweZPGFYxAVKPl4;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "S6DpeJYXrMFLyXDcxbWFDo", Name = "__S6DpeJYXrMFLyXDcxbWFDo")]
        [n2.SerializableAttribute]
        public class __S6DpeJYXrMFLyXDcxbWFDo : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_HwNiMHnzBiRNdHU5N3kDJX);
                n1.CompilationHelper.SafeDispose(this.__p_PWKzphyd2jlL0EBW9mZyl5);
                n1.CompilationHelper.SafeDispose(this.__p_V475FW4ouV4MbBL6QZyINZ);
                return;
            }

            [n1.ElementAttribute(TracingId = 346633U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "HwNiMHnzBiRNdHU5N3kDJX", Name = "r2d", IsManaged = true, IsAutoGenerated = true)]
            public n27.r2d_KlD9gsTHvCZOpnxWlAk1rY __p_HwNiMHnzBiRNdHU5N3kDJX;
            [n1.ElementAttribute(TracingId = 346645U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "PWKzphyd2jlL0EBW9mZyl5", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n14.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_PWKzphyd2jlL0EBW9mZyl5;
            [n1.ElementAttribute(TracingId = 346651U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "V475FW4ouV4MbBL6QZyINZ", Name = "FunctionGradient", IsManaged = true, IsAutoGenerated = true)]
            public n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<n26.Vector2> __p_V475FW4ouV4MbBL6QZyINZ;
            public __S6DpeJYXrMFLyXDcxbWFDo(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __S6DpeJYXrMFLyXDcxbWFDo(__S6DpeJYXrMFLyXDcxbWFDo other): base(other)
            {
                this.__p_HwNiMHnzBiRNdHU5N3kDJX = other.__p_HwNiMHnzBiRNdHU5N3kDJX;
                this.__p_PWKzphyd2jlL0EBW9mZyl5 = other.__p_PWKzphyd2jlL0EBW9mZyl5;
                this.__p_V475FW4ouV4MbBL6QZyINZ = other.__p_V475FW4ouV4MbBL6QZyINZ;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HwNiMHnzBiRNdHU5N3kDJX", in __p_HwNiMHnzBiRNdHU5N3kDJX), n1.CompilationHelper.GetValueOrExisting(values, "__p_PWKzphyd2jlL0EBW9mZyl5", in __p_PWKzphyd2jlL0EBW9mZyl5), n1.CompilationHelper.GetValueOrExisting(values, "__p_V475FW4ouV4MbBL6QZyINZ", in __p_V475FW4ouV4MbBL6QZyINZ));
            }

            internal __S6DpeJYXrMFLyXDcxbWFDo __WITH__(n27.r2d_KlD9gsTHvCZOpnxWlAk1rY __p_HwNiMHnzBiRNdHU5N3kDJX, n14.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_PWKzphyd2jlL0EBW9mZyl5, n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<n26.Vector2> __p_V475FW4ouV4MbBL6QZyINZ)
            {
                __S6DpeJYXrMFLyXDcxbWFDo that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_HwNiMHnzBiRNdHU5N3kDJX != this.__p_HwNiMHnzBiRNdHU5N3kDJX || __p_PWKzphyd2jlL0EBW9mZyl5 != this.__p_PWKzphyd2jlL0EBW9mZyl5 || __p_V475FW4ouV4MbBL6QZyINZ != this.__p_V475FW4ouV4MbBL6QZyINZ ? new __S6DpeJYXrMFLyXDcxbWFDo(this)
                    {__p_HwNiMHnzBiRNdHU5N3kDJX = __p_HwNiMHnzBiRNdHU5N3kDJX, __p_PWKzphyd2jlL0EBW9mZyl5 = __p_PWKzphyd2jlL0EBW9mZyl5, __p_V475FW4ouV4MbBL6QZyINZ = __p_V475FW4ouV4MbBL6QZyINZ} : that_0;
                else
                {
                    this.__p_HwNiMHnzBiRNdHU5N3kDJX = __p_HwNiMHnzBiRNdHU5N3kDJX;
                    this.__p_PWKzphyd2jlL0EBW9mZyl5 = __p_PWKzphyd2jlL0EBW9mZyl5;
                    this.__p_V475FW4ouV4MbBL6QZyINZ = __p_V475FW4ouV4MbBL6QZyINZ;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 346735U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "LXa4V7AjDONQKipfT23shU", Name = "Curl3D_LXa4V7AjDONQKipfT23shU")]
    [n2.SerializableAttribute]
    public class Curl3D_LXa4V7AjDONQKipfT23shU : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n25.Curl3D_LXa4V7AjDONQKipfT23shU Create(n1.NodeContext Node_Context)
        {
            var instance = new Curl3D_LXa4V7AjDONQKipfT23shU(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n25.Curl3D_LXa4V7AjDONQKipfT23shU CreateDefault()
        {
            var instance = new Curl3D_LXa4V7AjDONQKipfT23shU(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.Curl3D_LXa4V7AjDONQKipfT23shU Update(n5.GpuValue<n26.Vector3> Function_In, n5.GpuValue<n26.Vector3> Position_In, n5.GpuValue<float> Epsilon_In, out n5.GpuValue<n26.Vector3> Output_Out)
        {
            string __pad_LldMkN0k8DXNG6adGfK657_0 = __slot_LldMkN0k8DXNG6adGfK657;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_RgpKziNSehXPjK4nOeGv2x;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<n26.Vector3>, n5.GpuValue<float>, string, n5.GpuValue<n26.Vector3>>, n2.ValueTuple<n5.GpuValue<n26.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n26.Vector3>)));
            }

            var inputs_4 = (Position_In, Epsilon_In, __pad_LldMkN0k8DXNG6adGfK657_0, Function_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__N11wr1aWcDUOFQfx1ATgqV>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __N11wr1aWcDUOFQfx1ATgqV(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt = n11._Operations_.CreateDefault<n5.AbstractGpuValue>(), __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc = n11._Operations_.CreateDefault<n5.IFunctionInvokeNode>(), __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "IPmZ1NVjPG5MWJBKG6zEAv", 346767U);
                    var Output_9 = n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<n26.Vector3, n13.IEnumerable<n5.InputModifier>>.Create(Node_Context: Node_Context_8);
                    state_7.__p_IPmZ1NVjPG5MWJBKG6zEAv = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "ERFBr0ep6lQPoW3s0Idfpp", 346824U);
                    var Output_11 = n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_10);
                    state_7.__p_ERFBr0ep6lQPoW3s0Idfpp = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "GUoJByZoE3YPID01NHgaIY", 346849U);
                    var Output_13 = n9.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n26.Vector3>.Create(Node_Context: Node_Context_12);
                    state_7.__p_GUoJByZoE3YPID01NHgaIY = Output_13;
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "QTxDI2t6v43MZgT61Qejpt", 346870U);
                    var Output_15 = n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<n26.Vector3>.Create(Node_Context: Node_Context_14);
                    state_7.__p_QTxDI2t6v43MZgT61Qejpt = Output_15;
                }

                string __pad_NmFnY9XxJWGPQtvLBlUij3_16 = __slot_NmFnY9XxJWGPQtvLBlUij3;
                string __pad_TYKNBt4Gq6eLSW7a31Gryv_17 = __slot_TYKNBt4Gq6eLSW7a31Gryv;
                float __pad_U590rGsmv96NHeThDtGnQl_18 = __slot_U590rGsmv96NHeThDtGnQl;
                int Id_19 = 0;
                var State_Output_21 = state_7.__p_GUoJByZoE3YPID01NHgaIY.Update(The_Override_In: Position_In, Id_In: Id_19, Output_Out: out n5.GpuValue<n26.Vector3> Output_20);
                var State_Output_23 = state_7.__p_ERFBr0ep6lQPoW3s0Idfpp.Update(GpuValue_In: Epsilon_In, The_Value_In: __pad_U590rGsmv96NHeThDtGnQl_18, Output_Out: out n5.GpuValue<float> Output_22);
                var builder_24 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt, 1);
                builder_24.Add(Output_20);
                var __pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt_25 = builder_24.Commit();
                var State_Output_27 = state_7.__p_QTxDI2t6v43MZgT61Qejpt.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt_25, Id_In: __pad_NmFnY9XxJWGPQtvLBlUij3_16, Output_Out: out n5.FunctionInvokeNode<n26.Vector3> Output_26);
                n5.IFunctionInvokeNode Input_28 = (n5.IFunctionInvokeNode)Output_26;
                var builder_29 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc, 1);
                builder_29.Add(Input_28);
                var __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc_30 = builder_29.Commit();
                n11._Operations_.FromValue<n5.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc_30, Result_Out: out n10.Spread<n5.IFunctionInvokeNode> Result_31);
                n5.GpuValue<n26.Vector3> Default_Result_32 = default(n5.GpuValue<n26.Vector3>);
                n13.IEnumerable<string> Mixins_33 = n24._Operations_.CreateDefault<string>();
                n22.ImmutableDictionary<string, string> Template_Values_34 = n23._Operations_.CreateDefault<string, string>();
                bool Is_Groupable_35 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_36 = n24._Operations_.CreateDefault<n5.InputModifier>();
                var builder_37 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv, 2);
                builder_37.Add(Output_20);
                builder_37.Add(Output_22);
                var __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv_38 = builder_37.Commit();
                var State_Output_41 = state_7.__p_IPmZ1NVjPG5MWJBKG6zEAv.Update(Arguments_In: __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv_38, Function_Name_In: __pad_TYKNBt4Gq6eLSW7a31Gryv_17, Code_Template_In: __pad_LldMkN0k8DXNG6adGfK657_0, Default_Result_In: Default_Result_32, Functions_In: Result_31, Mixins_In: Mixins_33, Template_Values_In: Template_Values_34, Is_Groupable_In: Is_Groupable_35, The_Modifiers_In: The_Modifiers_36, Output_Out: out n5.GpuValue<n26.Vector3> Output_39, AdditionalOutputs_Out: out n10.Spread<n5.AbstractGpuValue> AdditionalOutputs_40);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_21 != state_7.__p_GUoJByZoE3YPID01NHgaIY || State_Output_23 != state_7.__p_ERFBr0ep6lQPoW3s0Idfpp || __pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt_25 != state_7.__pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt || State_Output_27 != state_7.__p_QTxDI2t6v43MZgT61Qejpt || __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc_30 != state_7.__pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc || __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv_38 != state_7.__pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv || State_Output_41 != state_7.__p_IPmZ1NVjPG5MWJBKG6zEAv ? new __N11wr1aWcDUOFQfx1ATgqV(state_7)
                    {__p_GUoJByZoE3YPID01NHgaIY = State_Output_21, __p_ERFBr0ep6lQPoW3s0Idfpp = State_Output_23, __pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt = __pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt_25, __p_QTxDI2t6v43MZgT61Qejpt = State_Output_27, __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc = __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc_30, __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv = __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv_38, __p_IPmZ1NVjPG5MWJBKG6zEAv = State_Output_41} : state_7;
                else
                {
                    state_7.__p_GUoJByZoE3YPID01NHgaIY = State_Output_21;
                    state_7.__p_ERFBr0ep6lQPoW3s0Idfpp = State_Output_23;
                    state_7.__pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt = __pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt_25;
                    state_7.__p_QTxDI2t6v43MZgT61Qejpt = State_Output_27;
                    state_7.__pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc = __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc_30;
                    state_7.__pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv = __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv_38;
                    state_7.__p_IPmZ1NVjPG5MWJBKG6zEAv = State_Output_41;
                }

                outputs_5 = n2.ValueTuple.Create(Output_39);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_42 = outputs_5.Item1;
            Output_Out = __auto_42;
            n25.Curl3D_LXa4V7AjDONQKipfT23shU that_43 = this;
            if (this.__GetContext__().IsImmutable)
                that_43 = manager_3 != this.__cache_RgpKziNSehXPjK4nOeGv2x ? new Curl3D_LXa4V7AjDONQKipfT23shU(this)
                {__cache_RgpKziNSehXPjK4nOeGv2x = manager_3} : that_43;
            else
            {
                this.__cache_RgpKziNSehXPjK4nOeGv2x = manager_3;
            }

            return that_43;
        }

        public n25.Curl3D_LXa4V7AjDONQKipfT23shU __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n25.Curl3D_LXa4V7AjDONQKipfT23shU that_0 = this;
            this.__cache_RgpKziNSehXPjK4nOeGv2x = null;
            return that_0;
        }

        public n25.Curl3D_LXa4V7AjDONQKipfT23shU __CreateDefault__()
        {
            n25.Curl3D_LXa4V7AjDONQKipfT23shU that_0 = this;
            this.__cache_RgpKziNSehXPjK4nOeGv2x = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_RgpKziNSehXPjK4nOeGv2x);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 346903U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "LldMkN0k8DXNG6adGfK657", Name = "__slot_LldMkN0k8DXNG6adGfK657")]
        public static string __slot_LldMkN0k8DXNG6adGfK657 = "// Partial Derivatives in 3D domain\r\n#define calcDx3D_${signature}(f, p, e) ( (f(p + float3(e,0,0)) - f(p - float3(e,0,0))) / (2*e) )\r\n#define calcDy3D_${signature}(f, p, e) ( (f(p + float3(0,e,0)) - f(p - float3(0,e,0))) / (2*e) )\r\n#define calcDz3D_${signature}(f, p, e) ( (f(p + float3(0,0,e)) - f(p - float3(0,0,e))) / (2*e) )\r\n\r\n// Jacobian (gradients) of a 3D vector field as 3x3 matrix\r\n #define calcGradV3_${signature}(f, p, e)(transpose(float3x3(calcDx3D_${signature}(f, p, e), calcDy3D_${signature}(f, p, e), calcDz3D_${signature}(f, p, e))))\r\n\r\n// 3D Curl\r\n#define calcCurlV3_${signature}(f, p, e)  ( (calcGradV3_${signature}(f, p, e)._32_13_21 - calcGradV3_${signature}(f, p, e)._23_31_12) )\r\n\r\n\r\n// Apply\r\nfloat3 ${signature} (float3 p, float e)\r\n{\r\n    return calcCurlV3_${signature}(${function}, p, e);\r\n}";
        [n1.ElementAttribute(TracingId = 346740U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "RgpKziNSehXPjK4nOeGv2x", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<n26.Vector3>, n5.GpuValue<float>, string, n5.GpuValue<n26.Vector3>>, n2.ValueTuple<n5.GpuValue<n26.Vector3>>> __cache_RgpKziNSehXPjK4nOeGv2x = null;
        [n1.ElementAttribute(TracingId = 346812U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "NmFnY9XxJWGPQtvLBlUij3", Name = "__slot_NmFnY9XxJWGPQtvLBlUij3")]
        public static string __slot_NmFnY9XxJWGPQtvLBlUij3 = "function";
        [n1.ElementAttribute(TracingId = 346820U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "TYKNBt4Gq6eLSW7a31Gryv", Name = "__slot_TYKNBt4Gq6eLSW7a31Gryv")]
        public static string __slot_TYKNBt4Gq6eLSW7a31Gryv = "Curl3D";
        [n1.ElementAttribute(TracingId = 346840U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "U590rGsmv96NHeThDtGnQl", Name = "__slot_U590rGsmv96NHeThDtGnQl")]
        public static float __slot_U590rGsmv96NHeThDtGnQl = 0.001F;
        static Curl3D_LXa4V7AjDONQKipfT23shU()
        {
        }

        public Curl3D_LXa4V7AjDONQKipfT23shU(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Curl3D_LXa4V7AjDONQKipfT23shU(Curl3D_LXa4V7AjDONQKipfT23shU other): base(other)
        {
            this.__cache_RgpKziNSehXPjK4nOeGv2x = other.__cache_RgpKziNSehXPjK4nOeGv2x;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_RgpKziNSehXPjK4nOeGv2x", in __cache_RgpKziNSehXPjK4nOeGv2x));
        }

        internal Curl3D_LXa4V7AjDONQKipfT23shU __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<n26.Vector3>, n5.GpuValue<float>, string, n5.GpuValue<n26.Vector3>>, n2.ValueTuple<n5.GpuValue<n26.Vector3>>> __cache_RgpKziNSehXPjK4nOeGv2x)
        {
            n25.Curl3D_LXa4V7AjDONQKipfT23shU that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_RgpKziNSehXPjK4nOeGv2x != this.__cache_RgpKziNSehXPjK4nOeGv2x ? new Curl3D_LXa4V7AjDONQKipfT23shU(this)
                {__cache_RgpKziNSehXPjK4nOeGv2x = __cache_RgpKziNSehXPjK4nOeGv2x} : that_0;
            else
            {
                this.__cache_RgpKziNSehXPjK4nOeGv2x = __cache_RgpKziNSehXPjK4nOeGv2x;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "N11wr1aWcDUOFQfx1ATgqV", Name = "__N11wr1aWcDUOFQfx1ATgqV")]
        [n2.SerializableAttribute]
        public class __N11wr1aWcDUOFQfx1ATgqV : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_IPmZ1NVjPG5MWJBKG6zEAv);
                n1.CompilationHelper.SafeDispose(this.__p_ERFBr0ep6lQPoW3s0Idfpp);
                n1.CompilationHelper.SafeDispose(this.__p_GUoJByZoE3YPID01NHgaIY);
                n1.CompilationHelper.SafeDispose(this.__p_QTxDI2t6v43MZgT61Qejpt);
                return;
            }

            [n1.ElementAttribute(TracingId = 346767U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "IPmZ1NVjPG5MWJBKG6zEAv", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<n26.Vector3, n13.IEnumerable<n5.InputModifier>> __p_IPmZ1NVjPG5MWJBKG6zEAv;
            [n1.ElementAttribute(TracingId = 346824U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "ERFBr0ep6lQPoW3s0Idfpp", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_ERFBr0ep6lQPoW3s0Idfpp;
            [n1.ElementAttribute(TracingId = 346849U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "GUoJByZoE3YPID01NHgaIY", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n9.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n26.Vector3> __p_GUoJByZoE3YPID01NHgaIY;
            [n1.ElementAttribute(TracingId = 346870U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "QTxDI2t6v43MZgT61Qejpt", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<n26.Vector3> __p_QTxDI2t6v43MZgT61Qejpt;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt = default(n10.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.IFunctionInvokeNode> __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc = default(n10.Spread<n5.IFunctionInvokeNode>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv = default(n10.Spread<n5.AbstractGpuValue>);
            public __N11wr1aWcDUOFQfx1ATgqV(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __N11wr1aWcDUOFQfx1ATgqV(__N11wr1aWcDUOFQfx1ATgqV other): base(other)
            {
                this.__p_IPmZ1NVjPG5MWJBKG6zEAv = other.__p_IPmZ1NVjPG5MWJBKG6zEAv;
                this.__p_ERFBr0ep6lQPoW3s0Idfpp = other.__p_ERFBr0ep6lQPoW3s0Idfpp;
                this.__p_GUoJByZoE3YPID01NHgaIY = other.__p_GUoJByZoE3YPID01NHgaIY;
                this.__p_QTxDI2t6v43MZgT61Qejpt = other.__p_QTxDI2t6v43MZgT61Qejpt;
                this.__pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt = other.__pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt;
                this.__pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc = other.__pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc;
                this.__pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv = other.__pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IPmZ1NVjPG5MWJBKG6zEAv", in __p_IPmZ1NVjPG5MWJBKG6zEAv), n1.CompilationHelper.GetValueOrExisting(values, "__p_ERFBr0ep6lQPoW3s0Idfpp", in __p_ERFBr0ep6lQPoW3s0Idfpp), n1.CompilationHelper.GetValueOrExisting(values, "__p_GUoJByZoE3YPID01NHgaIY", in __p_GUoJByZoE3YPID01NHgaIY), n1.CompilationHelper.GetValueOrExisting(values, "__p_QTxDI2t6v43MZgT61Qejpt", in __p_QTxDI2t6v43MZgT61Qejpt), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt", in __pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc", in __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv", in __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv));
            }

            internal __N11wr1aWcDUOFQfx1ATgqV __WITH__(n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<n26.Vector3, n13.IEnumerable<n5.InputModifier>> __p_IPmZ1NVjPG5MWJBKG6zEAv, n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_ERFBr0ep6lQPoW3s0Idfpp, n9.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n26.Vector3> __p_GUoJByZoE3YPID01NHgaIY, n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<n26.Vector3> __p_QTxDI2t6v43MZgT61Qejpt, n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt, n10.Spread<n5.IFunctionInvokeNode> __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv)
            {
                __N11wr1aWcDUOFQfx1ATgqV that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_IPmZ1NVjPG5MWJBKG6zEAv != this.__p_IPmZ1NVjPG5MWJBKG6zEAv || __p_ERFBr0ep6lQPoW3s0Idfpp != this.__p_ERFBr0ep6lQPoW3s0Idfpp || __p_GUoJByZoE3YPID01NHgaIY != this.__p_GUoJByZoE3YPID01NHgaIY || __p_QTxDI2t6v43MZgT61Qejpt != this.__p_QTxDI2t6v43MZgT61Qejpt || __pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt != this.__pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt || __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc != this.__pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc || __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv != this.__pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv ? new __N11wr1aWcDUOFQfx1ATgqV(this)
                    {__p_IPmZ1NVjPG5MWJBKG6zEAv = __p_IPmZ1NVjPG5MWJBKG6zEAv, __p_ERFBr0ep6lQPoW3s0Idfpp = __p_ERFBr0ep6lQPoW3s0Idfpp, __p_GUoJByZoE3YPID01NHgaIY = __p_GUoJByZoE3YPID01NHgaIY, __p_QTxDI2t6v43MZgT61Qejpt = __p_QTxDI2t6v43MZgT61Qejpt, __pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt = __pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt, __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc = __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc, __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv = __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv} : that_0;
                else
                {
                    this.__p_IPmZ1NVjPG5MWJBKG6zEAv = __p_IPmZ1NVjPG5MWJBKG6zEAv;
                    this.__p_ERFBr0ep6lQPoW3s0Idfpp = __p_ERFBr0ep6lQPoW3s0Idfpp;
                    this.__p_GUoJByZoE3YPID01NHgaIY = __p_GUoJByZoE3YPID01NHgaIY;
                    this.__p_QTxDI2t6v43MZgT61Qejpt = __p_QTxDI2t6v43MZgT61Qejpt;
                    this.__pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt = __pin_group_Parameters_In_QTxDI2t6v43MZgT61Qejpt;
                    this.__pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc = __pin_group_Input_In_Fi5VVXG6EsfPsC9U0oVYKc;
                    this.__pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv = __pin_group_Arguments_In_IPmZ1NVjPG5MWJBKG6zEAv;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 347012U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "M8EXQbV0wHCPENC6l13fXO", Name = "PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO")]
    [n2.SerializableAttribute]
    public class PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n25.PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO Create(n1.NodeContext Node_Context)
        {
            var instance = new PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n25.PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO CreateDefault()
        {
            var instance = new PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO Update(n5.GpuValue<n26.Vector2> TDomain_In, n5.GpuValue<n26.Vector2> Direction_In, out n5.GpuValue<float> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_PxaE5fasbViO0FainC2Y2I;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<n26.Vector2>, n5.GpuValue<n26.Vector2>>, n2.ValueTuple<n5.GpuValue<float>>>(n2.ValueTuple.Create(default(n5.GpuValue<float>)));
            }

            var inputs_3 = (TDomain_In, Direction_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__TCTX5jISJcMM6hl84UbGCP>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __TCTX5jISJcMM6hl84UbGCP(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W = n11._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs = n11._Operations_.CreateDefault<n5.GpuValue<float>>(), __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q = n11._Operations_.CreateDefault<n5.GpuValue<float>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "HzHXIwfDfzfQDJpcsn2mff", 347041U);
                    var Output_8 = n29.xMy_split_OlHtbWbJLVYNwNtomhsBtR.Create(Node_Context: Node_Context_7);
                    state_6.__p_HzHXIwfDfzfQDJpcsn2mff = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "QpxE4UdHcLPM7I2JhTUeGl", 347060U);
                    var Output_10 = n29.xMy_split_OlHtbWbJLVYNwNtomhsBtR.Create(Node_Context: Node_Context_9);
                    state_6.__p_QpxE4UdHcLPM7I2JhTUeGl = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "VEntT2C14SWPCsTxZmBW0I", 347068U);
                    var Output_12 = n7.Negate_P5nGfBLszbBL1YRjqmyYHC<float>.Create(Node_Context: Node_Context_11);
                    state_6.__p_VEntT2C14SWPCsTxZmBW0I = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "J4r1WER0osXPQ0MkuoEnjs", 347086U);
                    var Output_14 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_13);
                    state_6.__p_J4r1WER0osXPQ0MkuoEnjs = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "GNqaGvHpMRsM4yHtQUfY8Q", 347103U);
                    var Output_16 = n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float>.Create(Node_Context: Node_Context_15);
                    state_6.__p_GNqaGvHpMRsM4yHtQUfY8Q = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "HasqNHeFaoRMP6CMHLDe6W", 347124U);
                    var Output_18 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_17);
                    state_6.__p_HasqNHeFaoRMP6CMHLDe6W = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "PGwr9Zl6o31Mh0uc0m9KzP", 347143U);
                    var Output_20 = n9.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n26.Vector2>.Create(Node_Context: Node_Context_19);
                    state_6.__p_PGwr9Zl6o31Mh0uc0m9KzP = Output_20;
                }

                int Id_21 = 0;
                var State_Output_23 = state_6.__p_PGwr9Zl6o31Mh0uc0m9KzP.Update(The_Override_In: TDomain_In, Id_In: Id_21, Output_Out: out n5.GpuValue<n26.Vector2> Output_22);
                var Output_26 = state_6.__p_HzHXIwfDfzfQDJpcsn2mff.Update(value_In: Output_22, x_Out: out n5.GpuValue<float> x_24, y_Out: out n5.GpuValue<float> y_25);
                var Output_29 = state_6.__p_QpxE4UdHcLPM7I2JhTUeGl.Update(value_In: Direction_In, x_Out: out n5.GpuValue<float> x_27, y_Out: out n5.GpuValue<float> y_28);
                var builder_30 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W, 2);
                builder_30.Add(x_24);
                builder_30.Add(y_28);
                var __pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W_31 = builder_30.Commit();
                var State_Output_33 = state_6.__p_HasqNHeFaoRMP6CMHLDe6W.Update(Input_In: __pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W_31, Output_Out: out n5.GpuValue<float> Output_32);
                var State_Output_35 = state_6.__p_VEntT2C14SWPCsTxZmBW0I.Update(Input_In: y_25, Output_Out: out n5.GpuValue<float> Output_34);
                var builder_36 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs, 2);
                builder_36.Add(Output_34);
                builder_36.Add(x_27);
                var __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs_37 = builder_36.Commit();
                var State_Output_39 = state_6.__p_J4r1WER0osXPQ0MkuoEnjs.Update(Input_In: __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs_37, Output_Out: out n5.GpuValue<float> Output_38);
                var builder_40 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q, 2);
                builder_40.Add(Output_38);
                builder_40.Add(Output_32);
                var __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q_41 = builder_40.Commit();
                var State_Output_43 = state_6.__p_GNqaGvHpMRsM4yHtQUfY8Q.Update(Input_In: __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q_41, Output_Out: out n5.GpuValue<float> Output_42);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_23 != state_6.__p_PGwr9Zl6o31Mh0uc0m9KzP || Output_26 != state_6.__p_HzHXIwfDfzfQDJpcsn2mff || Output_29 != state_6.__p_QpxE4UdHcLPM7I2JhTUeGl || __pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W_31 != state_6.__pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W || State_Output_33 != state_6.__p_HasqNHeFaoRMP6CMHLDe6W || State_Output_35 != state_6.__p_VEntT2C14SWPCsTxZmBW0I || __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs_37 != state_6.__pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs || State_Output_39 != state_6.__p_J4r1WER0osXPQ0MkuoEnjs || __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q_41 != state_6.__pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q || State_Output_43 != state_6.__p_GNqaGvHpMRsM4yHtQUfY8Q ? new __TCTX5jISJcMM6hl84UbGCP(state_6)
                    {__p_PGwr9Zl6o31Mh0uc0m9KzP = State_Output_23, __p_HzHXIwfDfzfQDJpcsn2mff = Output_26, __p_QpxE4UdHcLPM7I2JhTUeGl = Output_29, __pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W = __pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W_31, __p_HasqNHeFaoRMP6CMHLDe6W = State_Output_33, __p_VEntT2C14SWPCsTxZmBW0I = State_Output_35, __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs = __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs_37, __p_J4r1WER0osXPQ0MkuoEnjs = State_Output_39, __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q = __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q_41, __p_GNqaGvHpMRsM4yHtQUfY8Q = State_Output_43} : state_6;
                else
                {
                    state_6.__p_PGwr9Zl6o31Mh0uc0m9KzP = State_Output_23;
                    state_6.__p_HzHXIwfDfzfQDJpcsn2mff = Output_26;
                    state_6.__p_QpxE4UdHcLPM7I2JhTUeGl = Output_29;
                    state_6.__pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W = __pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W_31;
                    state_6.__p_HasqNHeFaoRMP6CMHLDe6W = State_Output_33;
                    state_6.__p_VEntT2C14SWPCsTxZmBW0I = State_Output_35;
                    state_6.__pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs = __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs_37;
                    state_6.__p_J4r1WER0osXPQ0MkuoEnjs = State_Output_39;
                    state_6.__pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q = __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q_41;
                    state_6.__p_GNqaGvHpMRsM4yHtQUfY8Q = State_Output_43;
                }

                outputs_4 = n2.ValueTuple.Create(Output_42);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_44 = outputs_4.Item1;
            Output_Out = __auto_44;
            n25.PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO that_45 = this;
            if (this.__GetContext__().IsImmutable)
                that_45 = manager_2 != this.__cache_PxaE5fasbViO0FainC2Y2I ? new PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO(this)
                {__cache_PxaE5fasbViO0FainC2Y2I = manager_2} : that_45;
            else
            {
                this.__cache_PxaE5fasbViO0FainC2Y2I = manager_2;
            }

            return that_45;
        }

        public n25.PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n25.PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO that_0 = this;
            this.__cache_PxaE5fasbViO0FainC2Y2I = null;
            return that_0;
        }

        public n25.PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO __CreateDefault__()
        {
            n25.PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO that_0 = this;
            this.__cache_PxaE5fasbViO0FainC2Y2I = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_PxaE5fasbViO0FainC2Y2I);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 347179U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "NkZQ0mQlFElNJL9KJTBgEf", Name = "__slot_NkZQ0mQlFElNJL9KJTBgEf")]
        public static string __slot_NkZQ0mQlFElNJL9KJTBgEf = "// add constant direction to 2D curl potential\r\nfloat preCurlDirection(float2 p, float2 dir) \r\n{\r\n \treturn -p.y * dir.x + p.x * dir.y;\r\n}\r\n";
        [n1.ElementAttribute(TracingId = 347017U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "PxaE5fasbViO0FainC2Y2I", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<n26.Vector2>, n5.GpuValue<n26.Vector2>>, n2.ValueTuple<n5.GpuValue<float>>> __cache_PxaE5fasbViO0FainC2Y2I = null;
        static PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO()
        {
        }

        public PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO(PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO other): base(other)
        {
            this.__cache_PxaE5fasbViO0FainC2Y2I = other.__cache_PxaE5fasbViO0FainC2Y2I;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_PxaE5fasbViO0FainC2Y2I", in __cache_PxaE5fasbViO0FainC2Y2I));
        }

        internal PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<n26.Vector2>, n5.GpuValue<n26.Vector2>>, n2.ValueTuple<n5.GpuValue<float>>> __cache_PxaE5fasbViO0FainC2Y2I)
        {
            n25.PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_PxaE5fasbViO0FainC2Y2I != this.__cache_PxaE5fasbViO0FainC2Y2I ? new PreCur2DlDirection_M8EXQbV0wHCPENC6l13fXO(this)
                {__cache_PxaE5fasbViO0FainC2Y2I = __cache_PxaE5fasbViO0FainC2Y2I} : that_0;
            else
            {
                this.__cache_PxaE5fasbViO0FainC2Y2I = __cache_PxaE5fasbViO0FainC2Y2I;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "TCTX5jISJcMM6hl84UbGCP", Name = "__TCTX5jISJcMM6hl84UbGCP")]
        [n2.SerializableAttribute]
        public class __TCTX5jISJcMM6hl84UbGCP : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_HzHXIwfDfzfQDJpcsn2mff);
                n1.CompilationHelper.SafeDispose(this.__p_QpxE4UdHcLPM7I2JhTUeGl);
                n1.CompilationHelper.SafeDispose(this.__p_VEntT2C14SWPCsTxZmBW0I);
                n1.CompilationHelper.SafeDispose(this.__p_J4r1WER0osXPQ0MkuoEnjs);
                n1.CompilationHelper.SafeDispose(this.__p_GNqaGvHpMRsM4yHtQUfY8Q);
                n1.CompilationHelper.SafeDispose(this.__p_HasqNHeFaoRMP6CMHLDe6W);
                n1.CompilationHelper.SafeDispose(this.__p_PGwr9Zl6o31Mh0uc0m9KzP);
                return;
            }

            [n1.ElementAttribute(TracingId = 347041U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "HzHXIwfDfzfQDJpcsn2mff", Name = "x-y (split)", IsManaged = true, IsAutoGenerated = true)]
            public n29.xMy_split_OlHtbWbJLVYNwNtomhsBtR __p_HzHXIwfDfzfQDJpcsn2mff;
            [n1.ElementAttribute(TracingId = 347060U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "QpxE4UdHcLPM7I2JhTUeGl", Name = "x-y (split)", IsManaged = true, IsAutoGenerated = true)]
            public n29.xMy_split_OlHtbWbJLVYNwNtomhsBtR __p_QpxE4UdHcLPM7I2JhTUeGl;
            [n1.ElementAttribute(TracingId = 347068U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "VEntT2C14SWPCsTxZmBW0I", Name = "Negate", IsManaged = true, IsAutoGenerated = true)]
            public n7.Negate_P5nGfBLszbBL1YRjqmyYHC<float> __p_VEntT2C14SWPCsTxZmBW0I;
            [n1.ElementAttribute(TracingId = 347086U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "J4r1WER0osXPQ0MkuoEnjs", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_J4r1WER0osXPQ0MkuoEnjs;
            [n1.ElementAttribute(TracingId = 347103U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "GNqaGvHpMRsM4yHtQUfY8Q", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_GNqaGvHpMRsM4yHtQUfY8Q;
            [n1.ElementAttribute(TracingId = 347124U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "HasqNHeFaoRMP6CMHLDe6W", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_HasqNHeFaoRMP6CMHLDe6W;
            [n1.ElementAttribute(TracingId = 347143U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "PGwr9Zl6o31Mh0uc0m9KzP", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n9.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n26.Vector2> __p_PGwr9Zl6o31Mh0uc0m9KzP;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W = default(n10.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs = default(n10.Spread<n5.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q = default(n10.Spread<n5.GpuValue<float>>);
            public __TCTX5jISJcMM6hl84UbGCP(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __TCTX5jISJcMM6hl84UbGCP(__TCTX5jISJcMM6hl84UbGCP other): base(other)
            {
                this.__p_HzHXIwfDfzfQDJpcsn2mff = other.__p_HzHXIwfDfzfQDJpcsn2mff;
                this.__p_QpxE4UdHcLPM7I2JhTUeGl = other.__p_QpxE4UdHcLPM7I2JhTUeGl;
                this.__p_VEntT2C14SWPCsTxZmBW0I = other.__p_VEntT2C14SWPCsTxZmBW0I;
                this.__p_J4r1WER0osXPQ0MkuoEnjs = other.__p_J4r1WER0osXPQ0MkuoEnjs;
                this.__p_GNqaGvHpMRsM4yHtQUfY8Q = other.__p_GNqaGvHpMRsM4yHtQUfY8Q;
                this.__p_HasqNHeFaoRMP6CMHLDe6W = other.__p_HasqNHeFaoRMP6CMHLDe6W;
                this.__p_PGwr9Zl6o31Mh0uc0m9KzP = other.__p_PGwr9Zl6o31Mh0uc0m9KzP;
                this.__pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W = other.__pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W;
                this.__pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs = other.__pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs;
                this.__pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q = other.__pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HzHXIwfDfzfQDJpcsn2mff", in __p_HzHXIwfDfzfQDJpcsn2mff), n1.CompilationHelper.GetValueOrExisting(values, "__p_QpxE4UdHcLPM7I2JhTUeGl", in __p_QpxE4UdHcLPM7I2JhTUeGl), n1.CompilationHelper.GetValueOrExisting(values, "__p_VEntT2C14SWPCsTxZmBW0I", in __p_VEntT2C14SWPCsTxZmBW0I), n1.CompilationHelper.GetValueOrExisting(values, "__p_J4r1WER0osXPQ0MkuoEnjs", in __p_J4r1WER0osXPQ0MkuoEnjs), n1.CompilationHelper.GetValueOrExisting(values, "__p_GNqaGvHpMRsM4yHtQUfY8Q", in __p_GNqaGvHpMRsM4yHtQUfY8Q), n1.CompilationHelper.GetValueOrExisting(values, "__p_HasqNHeFaoRMP6CMHLDe6W", in __p_HasqNHeFaoRMP6CMHLDe6W), n1.CompilationHelper.GetValueOrExisting(values, "__p_PGwr9Zl6o31Mh0uc0m9KzP", in __p_PGwr9Zl6o31Mh0uc0m9KzP), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W", in __pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs", in __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q", in __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q));
            }

            internal __TCTX5jISJcMM6hl84UbGCP __WITH__(n29.xMy_split_OlHtbWbJLVYNwNtomhsBtR __p_HzHXIwfDfzfQDJpcsn2mff, n29.xMy_split_OlHtbWbJLVYNwNtomhsBtR __p_QpxE4UdHcLPM7I2JhTUeGl, n7.Negate_P5nGfBLszbBL1YRjqmyYHC<float> __p_VEntT2C14SWPCsTxZmBW0I, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_J4r1WER0osXPQ0MkuoEnjs, n7.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_GNqaGvHpMRsM4yHtQUfY8Q, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_HasqNHeFaoRMP6CMHLDe6W, n9.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n26.Vector2> __p_PGwr9Zl6o31Mh0uc0m9KzP, n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W, n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs, n10.Spread<n5.GpuValue<float>> __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q)
            {
                __TCTX5jISJcMM6hl84UbGCP that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_HzHXIwfDfzfQDJpcsn2mff != this.__p_HzHXIwfDfzfQDJpcsn2mff || __p_QpxE4UdHcLPM7I2JhTUeGl != this.__p_QpxE4UdHcLPM7I2JhTUeGl || __p_VEntT2C14SWPCsTxZmBW0I != this.__p_VEntT2C14SWPCsTxZmBW0I || __p_J4r1WER0osXPQ0MkuoEnjs != this.__p_J4r1WER0osXPQ0MkuoEnjs || __p_GNqaGvHpMRsM4yHtQUfY8Q != this.__p_GNqaGvHpMRsM4yHtQUfY8Q || __p_HasqNHeFaoRMP6CMHLDe6W != this.__p_HasqNHeFaoRMP6CMHLDe6W || __p_PGwr9Zl6o31Mh0uc0m9KzP != this.__p_PGwr9Zl6o31Mh0uc0m9KzP || __pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W != this.__pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W || __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs != this.__pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs || __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q != this.__pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q ? new __TCTX5jISJcMM6hl84UbGCP(this)
                    {__p_HzHXIwfDfzfQDJpcsn2mff = __p_HzHXIwfDfzfQDJpcsn2mff, __p_QpxE4UdHcLPM7I2JhTUeGl = __p_QpxE4UdHcLPM7I2JhTUeGl, __p_VEntT2C14SWPCsTxZmBW0I = __p_VEntT2C14SWPCsTxZmBW0I, __p_J4r1WER0osXPQ0MkuoEnjs = __p_J4r1WER0osXPQ0MkuoEnjs, __p_GNqaGvHpMRsM4yHtQUfY8Q = __p_GNqaGvHpMRsM4yHtQUfY8Q, __p_HasqNHeFaoRMP6CMHLDe6W = __p_HasqNHeFaoRMP6CMHLDe6W, __p_PGwr9Zl6o31Mh0uc0m9KzP = __p_PGwr9Zl6o31Mh0uc0m9KzP, __pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W = __pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W, __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs = __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs, __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q = __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q} : that_0;
                else
                {
                    this.__p_HzHXIwfDfzfQDJpcsn2mff = __p_HzHXIwfDfzfQDJpcsn2mff;
                    this.__p_QpxE4UdHcLPM7I2JhTUeGl = __p_QpxE4UdHcLPM7I2JhTUeGl;
                    this.__p_VEntT2C14SWPCsTxZmBW0I = __p_VEntT2C14SWPCsTxZmBW0I;
                    this.__p_J4r1WER0osXPQ0MkuoEnjs = __p_J4r1WER0osXPQ0MkuoEnjs;
                    this.__p_GNqaGvHpMRsM4yHtQUfY8Q = __p_GNqaGvHpMRsM4yHtQUfY8Q;
                    this.__p_HasqNHeFaoRMP6CMHLDe6W = __p_HasqNHeFaoRMP6CMHLDe6W;
                    this.__p_PGwr9Zl6o31Mh0uc0m9KzP = __p_PGwr9Zl6o31Mh0uc0m9KzP;
                    this.__pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W = __pin_group_Input_In_HasqNHeFaoRMP6CMHLDe6W;
                    this.__pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs = __pin_group_Input_In_J4r1WER0osXPQ0MkuoEnjs;
                    this.__pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q = __pin_group_Input_In_GNqaGvHpMRsM4yHtQUfY8Q;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 347285U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "D0fyWEyN3LQPF9bWZbYf8f", Name = "PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f")]
    [n2.SerializableAttribute]
    public class PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n25.PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f Create(n1.NodeContext Node_Context)
        {
            var instance = new PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n25.PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f CreateDefault()
        {
            var instance = new PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f Update(n5.GpuValue<n26.Vector3> TDomain_In, n5.GpuValue<n26.Vector3> Direction_In, out n5.GpuValue<n26.Vector3> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_RmYsuTKrJXsL7assSRspgq;
            if (manager_2 is null)
            {
                manager_2 = new n6.Manager<n2.ValueTuple<n5.GpuValue<n26.Vector3>, n5.GpuValue<n26.Vector3>>, n2.ValueTuple<n5.GpuValue<n26.Vector3>>>(n2.ValueTuple.Create(default(n5.GpuValue<n26.Vector3>)));
            }

            var inputs_3 = (TDomain_In, Direction_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__Ahn5NpPi69eOBdClLJSgzw>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __Ahn5NpPi69eOBdClLJSgzw(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz = n11._Operations_.CreateDefault<n5.GpuValue<n26.Vector3>>(), __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu = n11._Operations_.CreateDefault<n5.GpuValue<n26.Vector3>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "R9RwBHrbQ9JPovlGkkvtLX", 347316U);
                    var Output_8 = n7.Negate_P5nGfBLszbBL1YRjqmyYHC<n26.Vector3>.Create(Node_Context: Node_Context_7);
                    state_6.__p_R9RwBHrbQ9JPovlGkkvtLX = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "T5zQtK8Y13jMwkwIbrJLk4", 347332U);
                    var Output_10 = n9.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n26.Vector3>.Create(Node_Context: Node_Context_9);
                    state_6.__p_T5zQtK8Y13jMwkwIbrJLk4 = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "EN7oEtuGItsPPGLllUyoV9", 347343U);
                    var Output_12 = n7.Cross_NPx4F770UpZL3ddpapJ5Xw<n26.Vector3>.Create(Node_Context: Node_Context_11);
                    state_6.__p_EN7oEtuGItsPPGLllUyoV9 = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "TKGAlAGTXDkPOmbb1IYkSu", 347354U);
                    var Output_14 = n7.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n26.Vector3>.Create(Node_Context: Node_Context_13);
                    state_6.__p_TKGAlAGTXDkPOmbb1IYkSu = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "L8cInReY3PLLDyg2WGxJ6Y", 347368U);
                    var Output_16 = n7.Dot_VjBgbBbkOkiMLqm9EWGCSn<n26.Vector3>.Create(Node_Context: Node_Context_15);
                    state_6.__p_L8cInReY3PLLDyg2WGxJ6Y = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "AcXp7qG23f0L5RiXW5jRoi", 347391U);
                    var Output_18 = n8.To_Qgkn15Kxt1HLURmAdSAN7m<float, n26.Vector3>.Create(Node_Context: Node_Context_17);
                    state_6.__p_AcXp7qG23f0L5RiXW5jRoi = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "CeJtUlPtbSTQDkgrIdUUDz", 347411U);
                    var Output_20 = n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n26.Vector3>.Create(Node_Context: Node_Context_19);
                    state_6.__p_CeJtUlPtbSTQDkgrIdUUDz = Output_20;
                }

                int Id_21 = 0;
                var State_Output_23 = state_6.__p_T5zQtK8Y13jMwkwIbrJLk4.Update(The_Override_In: TDomain_In, Id_In: Id_21, Output_Out: out n5.GpuValue<n26.Vector3> Output_22);
                var State_Output_25 = state_6.__p_L8cInReY3PLLDyg2WGxJ6Y.Update(Input1_In: Output_22, Input2_In: Direction_In, Output_Out: out n5.GpuValue<float> Output_24);
                n5.GpuValue<n26.Vector3> default_26 = default(n5.GpuValue<n26.Vector3>);
                var State_Output_28 = state_6.__p_AcXp7qG23f0L5RiXW5jRoi.Update(x_In: Output_24, default_In: default_26, Output_Out: out n5.GpuValue<n26.Vector3> Output_27);
                var builder_29 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz, 2);
                builder_29.Add(Output_27);
                builder_29.Add(Direction_In);
                var __pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz_30 = builder_29.Commit();
                var State_Output_32 = state_6.__p_CeJtUlPtbSTQDkgrIdUUDz.Update(Input_In: __pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz_30, Output_Out: out n5.GpuValue<n26.Vector3> Output_31);
                var builder_33 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu, 2);
                builder_33.Add(Output_22);
                builder_33.Add(Output_31);
                var __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu_34 = builder_33.Commit();
                var State_Output_36 = state_6.__p_TKGAlAGTXDkPOmbb1IYkSu.Update(Input_In: __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu_34, Output_Out: out n5.GpuValue<n26.Vector3> Output_35);
                var State_Output_38 = state_6.__p_EN7oEtuGItsPPGLllUyoV9.Update(Input1_In: Output_35, Input2_In: Direction_In, Output_Out: out n5.GpuValue<n26.Vector3> Output_37);
                var State_Output_40 = state_6.__p_R9RwBHrbQ9JPovlGkkvtLX.Update(Input_In: Output_37, Output_Out: out n5.GpuValue<n26.Vector3> Output_39);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_23 != state_6.__p_T5zQtK8Y13jMwkwIbrJLk4 || State_Output_25 != state_6.__p_L8cInReY3PLLDyg2WGxJ6Y || State_Output_28 != state_6.__p_AcXp7qG23f0L5RiXW5jRoi || __pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz_30 != state_6.__pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz || State_Output_32 != state_6.__p_CeJtUlPtbSTQDkgrIdUUDz || __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu_34 != state_6.__pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu || State_Output_36 != state_6.__p_TKGAlAGTXDkPOmbb1IYkSu || State_Output_38 != state_6.__p_EN7oEtuGItsPPGLllUyoV9 || State_Output_40 != state_6.__p_R9RwBHrbQ9JPovlGkkvtLX ? new __Ahn5NpPi69eOBdClLJSgzw(state_6)
                    {__p_T5zQtK8Y13jMwkwIbrJLk4 = State_Output_23, __p_L8cInReY3PLLDyg2WGxJ6Y = State_Output_25, __p_AcXp7qG23f0L5RiXW5jRoi = State_Output_28, __pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz = __pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz_30, __p_CeJtUlPtbSTQDkgrIdUUDz = State_Output_32, __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu = __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu_34, __p_TKGAlAGTXDkPOmbb1IYkSu = State_Output_36, __p_EN7oEtuGItsPPGLllUyoV9 = State_Output_38, __p_R9RwBHrbQ9JPovlGkkvtLX = State_Output_40} : state_6;
                else
                {
                    state_6.__p_T5zQtK8Y13jMwkwIbrJLk4 = State_Output_23;
                    state_6.__p_L8cInReY3PLLDyg2WGxJ6Y = State_Output_25;
                    state_6.__p_AcXp7qG23f0L5RiXW5jRoi = State_Output_28;
                    state_6.__pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz = __pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz_30;
                    state_6.__p_CeJtUlPtbSTQDkgrIdUUDz = State_Output_32;
                    state_6.__pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu = __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu_34;
                    state_6.__p_TKGAlAGTXDkPOmbb1IYkSu = State_Output_36;
                    state_6.__p_EN7oEtuGItsPPGLllUyoV9 = State_Output_38;
                    state_6.__p_R9RwBHrbQ9JPovlGkkvtLX = State_Output_40;
                }

                outputs_4 = n2.ValueTuple.Create(Output_39);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_41 = outputs_4.Item1;
            Output_Out = __auto_41;
            n25.PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f that_42 = this;
            if (this.__GetContext__().IsImmutable)
                that_42 = manager_2 != this.__cache_RmYsuTKrJXsL7assSRspgq ? new PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f(this)
                {__cache_RmYsuTKrJXsL7assSRspgq = manager_2} : that_42;
            else
            {
                this.__cache_RmYsuTKrJXsL7assSRspgq = manager_2;
            }

            return that_42;
        }

        public n25.PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n25.PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f that_0 = this;
            this.__cache_RmYsuTKrJXsL7assSRspgq = null;
            return that_0;
        }

        public n25.PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f __CreateDefault__()
        {
            n25.PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f that_0 = this;
            this.__cache_RmYsuTKrJXsL7assSRspgq = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_RmYsuTKrJXsL7assSRspgq);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 347454U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "TfTooltFQtVNoOu9eE39zu", Name = "__slot_TfTooltFQtVNoOu9eE39zu")]
        public static string __slot_TfTooltFQtVNoOu9eE39zu = "// add constant direction to VF3D curl potential\r\nfloat3 preCurlDirection(float3 p, float3 dir) \r\n{\r\n  \tfloat3 parallel = dot(dir, p) * dir;\r\n \tfloat3 orthogonal = p - parallel;\r\n \treturn -cross(orthogonal, dir); \r\n}";
        [n1.ElementAttribute(TracingId = 347291U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "RmYsuTKrJXsL7assSRspgq", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<n26.Vector3>, n5.GpuValue<n26.Vector3>>, n2.ValueTuple<n5.GpuValue<n26.Vector3>>> __cache_RmYsuTKrJXsL7assSRspgq = null;
        static PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f()
        {
        }

        public PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f(PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f other): base(other)
        {
            this.__cache_RmYsuTKrJXsL7assSRspgq = other.__cache_RmYsuTKrJXsL7assSRspgq;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_RmYsuTKrJXsL7assSRspgq", in __cache_RmYsuTKrJXsL7assSRspgq));
        }

        internal PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<n26.Vector3>, n5.GpuValue<n26.Vector3>>, n2.ValueTuple<n5.GpuValue<n26.Vector3>>> __cache_RmYsuTKrJXsL7assSRspgq)
        {
            n25.PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_RmYsuTKrJXsL7assSRspgq != this.__cache_RmYsuTKrJXsL7assSRspgq ? new PreCurlDirection_D0fyWEyN3LQPF9bWZbYf8f(this)
                {__cache_RmYsuTKrJXsL7assSRspgq = __cache_RmYsuTKrJXsL7assSRspgq} : that_0;
            else
            {
                this.__cache_RmYsuTKrJXsL7assSRspgq = __cache_RmYsuTKrJXsL7assSRspgq;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Ahn5NpPi69eOBdClLJSgzw", Name = "__Ahn5NpPi69eOBdClLJSgzw")]
        [n2.SerializableAttribute]
        public class __Ahn5NpPi69eOBdClLJSgzw : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_R9RwBHrbQ9JPovlGkkvtLX);
                n1.CompilationHelper.SafeDispose(this.__p_T5zQtK8Y13jMwkwIbrJLk4);
                n1.CompilationHelper.SafeDispose(this.__p_EN7oEtuGItsPPGLllUyoV9);
                n1.CompilationHelper.SafeDispose(this.__p_TKGAlAGTXDkPOmbb1IYkSu);
                n1.CompilationHelper.SafeDispose(this.__p_L8cInReY3PLLDyg2WGxJ6Y);
                n1.CompilationHelper.SafeDispose(this.__p_AcXp7qG23f0L5RiXW5jRoi);
                n1.CompilationHelper.SafeDispose(this.__p_CeJtUlPtbSTQDkgrIdUUDz);
                return;
            }

            [n1.ElementAttribute(TracingId = 347316U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "R9RwBHrbQ9JPovlGkkvtLX", Name = "Negate", IsManaged = true, IsAutoGenerated = true)]
            public n7.Negate_P5nGfBLszbBL1YRjqmyYHC<n26.Vector3> __p_R9RwBHrbQ9JPovlGkkvtLX;
            [n1.ElementAttribute(TracingId = 347332U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "T5zQtK8Y13jMwkwIbrJLk4", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n9.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n26.Vector3> __p_T5zQtK8Y13jMwkwIbrJLk4;
            [n1.ElementAttribute(TracingId = 347343U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "EN7oEtuGItsPPGLllUyoV9", Name = "Cross", IsManaged = true, IsAutoGenerated = true)]
            public n7.Cross_NPx4F770UpZL3ddpapJ5Xw<n26.Vector3> __p_EN7oEtuGItsPPGLllUyoV9;
            [n1.ElementAttribute(TracingId = 347354U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "TKGAlAGTXDkPOmbb1IYkSu", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n26.Vector3> __p_TKGAlAGTXDkPOmbb1IYkSu;
            [n1.ElementAttribute(TracingId = 347368U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "L8cInReY3PLLDyg2WGxJ6Y", Name = "Dot", IsManaged = true, IsAutoGenerated = true)]
            public n7.Dot_VjBgbBbkOkiMLqm9EWGCSn<n26.Vector3> __p_L8cInReY3PLLDyg2WGxJ6Y;
            [n1.ElementAttribute(TracingId = 347391U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "AcXp7qG23f0L5RiXW5jRoi", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n8.To_Qgkn15Kxt1HLURmAdSAN7m<float, n26.Vector3> __p_AcXp7qG23f0L5RiXW5jRoi;
            [n1.ElementAttribute(TracingId = 347411U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "CeJtUlPtbSTQDkgrIdUUDz", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n26.Vector3> __p_CeJtUlPtbSTQDkgrIdUUDz;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<n26.Vector3>> __pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz = default(n10.Spread<n5.GpuValue<n26.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.GpuValue<n26.Vector3>> __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu = default(n10.Spread<n5.GpuValue<n26.Vector3>>);
            public __Ahn5NpPi69eOBdClLJSgzw(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Ahn5NpPi69eOBdClLJSgzw(__Ahn5NpPi69eOBdClLJSgzw other): base(other)
            {
                this.__p_R9RwBHrbQ9JPovlGkkvtLX = other.__p_R9RwBHrbQ9JPovlGkkvtLX;
                this.__p_T5zQtK8Y13jMwkwIbrJLk4 = other.__p_T5zQtK8Y13jMwkwIbrJLk4;
                this.__p_EN7oEtuGItsPPGLllUyoV9 = other.__p_EN7oEtuGItsPPGLllUyoV9;
                this.__p_TKGAlAGTXDkPOmbb1IYkSu = other.__p_TKGAlAGTXDkPOmbb1IYkSu;
                this.__p_L8cInReY3PLLDyg2WGxJ6Y = other.__p_L8cInReY3PLLDyg2WGxJ6Y;
                this.__p_AcXp7qG23f0L5RiXW5jRoi = other.__p_AcXp7qG23f0L5RiXW5jRoi;
                this.__p_CeJtUlPtbSTQDkgrIdUUDz = other.__p_CeJtUlPtbSTQDkgrIdUUDz;
                this.__pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz = other.__pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz;
                this.__pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu = other.__pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_R9RwBHrbQ9JPovlGkkvtLX", in __p_R9RwBHrbQ9JPovlGkkvtLX), n1.CompilationHelper.GetValueOrExisting(values, "__p_T5zQtK8Y13jMwkwIbrJLk4", in __p_T5zQtK8Y13jMwkwIbrJLk4), n1.CompilationHelper.GetValueOrExisting(values, "__p_EN7oEtuGItsPPGLllUyoV9", in __p_EN7oEtuGItsPPGLllUyoV9), n1.CompilationHelper.GetValueOrExisting(values, "__p_TKGAlAGTXDkPOmbb1IYkSu", in __p_TKGAlAGTXDkPOmbb1IYkSu), n1.CompilationHelper.GetValueOrExisting(values, "__p_L8cInReY3PLLDyg2WGxJ6Y", in __p_L8cInReY3PLLDyg2WGxJ6Y), n1.CompilationHelper.GetValueOrExisting(values, "__p_AcXp7qG23f0L5RiXW5jRoi", in __p_AcXp7qG23f0L5RiXW5jRoi), n1.CompilationHelper.GetValueOrExisting(values, "__p_CeJtUlPtbSTQDkgrIdUUDz", in __p_CeJtUlPtbSTQDkgrIdUUDz), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz", in __pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu", in __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu));
            }

            internal __Ahn5NpPi69eOBdClLJSgzw __WITH__(n7.Negate_P5nGfBLszbBL1YRjqmyYHC<n26.Vector3> __p_R9RwBHrbQ9JPovlGkkvtLX, n9.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n26.Vector3> __p_T5zQtK8Y13jMwkwIbrJLk4, n7.Cross_NPx4F770UpZL3ddpapJ5Xw<n26.Vector3> __p_EN7oEtuGItsPPGLllUyoV9, n7.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n26.Vector3> __p_TKGAlAGTXDkPOmbb1IYkSu, n7.Dot_VjBgbBbkOkiMLqm9EWGCSn<n26.Vector3> __p_L8cInReY3PLLDyg2WGxJ6Y, n8.To_Qgkn15Kxt1HLURmAdSAN7m<float, n26.Vector3> __p_AcXp7qG23f0L5RiXW5jRoi, n7.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n26.Vector3> __p_CeJtUlPtbSTQDkgrIdUUDz, n10.Spread<n5.GpuValue<n26.Vector3>> __pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz, n10.Spread<n5.GpuValue<n26.Vector3>> __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu)
            {
                __Ahn5NpPi69eOBdClLJSgzw that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_R9RwBHrbQ9JPovlGkkvtLX != this.__p_R9RwBHrbQ9JPovlGkkvtLX || __p_T5zQtK8Y13jMwkwIbrJLk4 != this.__p_T5zQtK8Y13jMwkwIbrJLk4 || __p_EN7oEtuGItsPPGLllUyoV9 != this.__p_EN7oEtuGItsPPGLllUyoV9 || __p_TKGAlAGTXDkPOmbb1IYkSu != this.__p_TKGAlAGTXDkPOmbb1IYkSu || __p_L8cInReY3PLLDyg2WGxJ6Y != this.__p_L8cInReY3PLLDyg2WGxJ6Y || __p_AcXp7qG23f0L5RiXW5jRoi != this.__p_AcXp7qG23f0L5RiXW5jRoi || __p_CeJtUlPtbSTQDkgrIdUUDz != this.__p_CeJtUlPtbSTQDkgrIdUUDz || __pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz != this.__pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz || __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu != this.__pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu ? new __Ahn5NpPi69eOBdClLJSgzw(this)
                    {__p_R9RwBHrbQ9JPovlGkkvtLX = __p_R9RwBHrbQ9JPovlGkkvtLX, __p_T5zQtK8Y13jMwkwIbrJLk4 = __p_T5zQtK8Y13jMwkwIbrJLk4, __p_EN7oEtuGItsPPGLllUyoV9 = __p_EN7oEtuGItsPPGLllUyoV9, __p_TKGAlAGTXDkPOmbb1IYkSu = __p_TKGAlAGTXDkPOmbb1IYkSu, __p_L8cInReY3PLLDyg2WGxJ6Y = __p_L8cInReY3PLLDyg2WGxJ6Y, __p_AcXp7qG23f0L5RiXW5jRoi = __p_AcXp7qG23f0L5RiXW5jRoi, __p_CeJtUlPtbSTQDkgrIdUUDz = __p_CeJtUlPtbSTQDkgrIdUUDz, __pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz = __pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz, __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu = __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu} : that_0;
                else
                {
                    this.__p_R9RwBHrbQ9JPovlGkkvtLX = __p_R9RwBHrbQ9JPovlGkkvtLX;
                    this.__p_T5zQtK8Y13jMwkwIbrJLk4 = __p_T5zQtK8Y13jMwkwIbrJLk4;
                    this.__p_EN7oEtuGItsPPGLllUyoV9 = __p_EN7oEtuGItsPPGLllUyoV9;
                    this.__p_TKGAlAGTXDkPOmbb1IYkSu = __p_TKGAlAGTXDkPOmbb1IYkSu;
                    this.__p_L8cInReY3PLLDyg2WGxJ6Y = __p_L8cInReY3PLLDyg2WGxJ6Y;
                    this.__p_AcXp7qG23f0L5RiXW5jRoi = __p_AcXp7qG23f0L5RiXW5jRoi;
                    this.__p_CeJtUlPtbSTQDkgrIdUUDz = __p_CeJtUlPtbSTQDkgrIdUUDz;
                    this.__pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz = __pin_group_Input_In_CeJtUlPtbSTQDkgrIdUUDz;
                    this.__pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu = __pin_group_Input_In_TKGAlAGTXDkPOmbb1IYkSu;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 347597U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "HcSV7Gctd99N2OaOCzyWEt", Name = "Laplacian_HcSV7Gctd99N2OaOCzyWEt")]
    [n2.SerializableAttribute]
    public class Laplacian_HcSV7Gctd99N2OaOCzyWEt<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n25.Laplacian_HcSV7Gctd99N2OaOCzyWEt<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Laplacian_HcSV7Gctd99N2OaOCzyWEt<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n25.Laplacian_HcSV7Gctd99N2OaOCzyWEt<T> CreateDefault()
        {
            var instance = new Laplacian_HcSV7Gctd99N2OaOCzyWEt<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.Laplacian_HcSV7Gctd99N2OaOCzyWEt<T> Update<AdM>(n5.GpuValue<float> Function_In, n5.GpuValue<T> Position_In, n5.GpuValue<float> Epsilon_In, n15.GradientDifferentiationMode Numerical_Differentiation_Mode_In, out n5.GpuValue<float> Output_Out, out n5.GpuValue<T> Gradient_Out)
            where AdM : struct, n17.IAdaptiveCreateDefault<n5.GpuValue<T>>
        {
            var w_0 = default(AdM);
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_GhpsltpUROPNIUHtzqd5ec;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<T>, n5.GpuValue<float>, n15.GradientDifferentiationMode>, n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<T>>>((default(n5.GpuValue<float>), default(n5.GpuValue<T>)));
            }

            var inputs_4 = (Function_In, Position_In, Epsilon_In, Numerical_Differentiation_Mode_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__JC45RmZQlGwLhT71u2zMLf>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __JC45RmZQlGwLhT71u2zMLf(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "RXvCspJ5kMoOL0EqJMzP45", 347629U);
                    var Output_9 = n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T>.Create(Node_Context: Node_Context_8);
                    state_7.__p_RXvCspJ5kMoOL0EqJMzP45 = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "UOuwgHu1GcLLrLOzL4yzgd", 347645U);
                    var Output_11 = n7.Dot_VjBgbBbkOkiMLqm9EWGCSn<T>.Create(Node_Context: Node_Context_10);
                    state_7.__p_UOuwgHu1GcLLrLOzL4yzgd = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "JQhf9jVSLEKMvkeijwXa4d", 347654U);
                    var Output_13 = n8.To_Qgkn15Kxt1HLURmAdSAN7m<float, T>.Create(Node_Context: Node_Context_12);
                    state_7.__p_JQhf9jVSLEKMvkeijwXa4d = Output_13;
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "VzTug8LXMjfNOMAdSMtLxr", 347667U);
                    var Output_15 = n14.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_14);
                    state_7.__p_VzTug8LXMjfNOMAdSMtLxr = Output_15;
                }

                float __pad_Rb0od6QZt3QPkOU00sG35f_16 = __slot_Rb0od6QZt3QPkOU00sG35f;
                bool Normalize_17 = false;
                var State_Output_19 = state_7.__p_RXvCspJ5kMoOL0EqJMzP45.Update<AdM>(Function_In: Function_In, Position_In: Position_In, Epsilon_In: Epsilon_In, Numerical_Differentiation_Mode_In: Numerical_Differentiation_Mode_In, Normalize_In: Normalize_17, Output_Out: out n5.GpuValue<T> Output_18);
                var Output_21 = state_7.__p_VzTug8LXMjfNOMAdSMtLxr.Update(Value_In: __pad_Rb0od6QZt3QPkOU00sG35f_16, GpuValue_Out: out n5.GpuValue<float> GpuValue_20);
                n5.GpuValue<T> default_22 = default(n5.GpuValue<T>);
                var State_Output_24 = state_7.__p_JQhf9jVSLEKMvkeijwXa4d.Update(x_In: GpuValue_20, default_In: default_22, Output_Out: out n5.GpuValue<T> Output_23);
                var State_Output_26 = state_7.__p_UOuwgHu1GcLLrLOzL4yzgd.Update(Input1_In: Output_18, Input2_In: Output_23, Output_Out: out n5.GpuValue<float> Output_25);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_19 != state_7.__p_RXvCspJ5kMoOL0EqJMzP45 || Output_21 != state_7.__p_VzTug8LXMjfNOMAdSMtLxr || State_Output_24 != state_7.__p_JQhf9jVSLEKMvkeijwXa4d || State_Output_26 != state_7.__p_UOuwgHu1GcLLrLOzL4yzgd ? new __JC45RmZQlGwLhT71u2zMLf(state_7)
                    {__p_RXvCspJ5kMoOL0EqJMzP45 = State_Output_19, __p_VzTug8LXMjfNOMAdSMtLxr = Output_21, __p_JQhf9jVSLEKMvkeijwXa4d = State_Output_24, __p_UOuwgHu1GcLLrLOzL4yzgd = State_Output_26} : state_7;
                else
                {
                    state_7.__p_RXvCspJ5kMoOL0EqJMzP45 = State_Output_19;
                    state_7.__p_VzTug8LXMjfNOMAdSMtLxr = Output_21;
                    state_7.__p_JQhf9jVSLEKMvkeijwXa4d = State_Output_24;
                    state_7.__p_UOuwgHu1GcLLrLOzL4yzgd = State_Output_26;
                }

                outputs_5 = (Output_25, Output_18);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var(__auto_27, __auto_28) = outputs_5;
            Output_Out = __auto_27;
            Gradient_Out = __auto_28;
            n25.Laplacian_HcSV7Gctd99N2OaOCzyWEt<T> that_29 = this;
            if (this.__GetContext__().IsImmutable)
                that_29 = manager_3 != this.__cache_GhpsltpUROPNIUHtzqd5ec ? new Laplacian_HcSV7Gctd99N2OaOCzyWEt<T>(this)
                {__cache_GhpsltpUROPNIUHtzqd5ec = manager_3} : that_29;
            else
            {
                this.__cache_GhpsltpUROPNIUHtzqd5ec = manager_3;
            }

            return that_29;
        }

        public n25.Laplacian_HcSV7Gctd99N2OaOCzyWEt<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n25.Laplacian_HcSV7Gctd99N2OaOCzyWEt<T> that_0 = this;
            this.__cache_GhpsltpUROPNIUHtzqd5ec = null;
            return that_0;
        }

        public n25.Laplacian_HcSV7Gctd99N2OaOCzyWEt<T> __CreateDefault__()
        {
            n25.Laplacian_HcSV7Gctd99N2OaOCzyWEt<T> that_0 = this;
            this.__cache_GhpsltpUROPNIUHtzqd5ec = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_GhpsltpUROPNIUHtzqd5ec);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 347603U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "GhpsltpUROPNIUHtzqd5ec", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<T>, n5.GpuValue<float>, n15.GradientDifferentiationMode>, n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<T>>> __cache_GhpsltpUROPNIUHtzqd5ec = null;
        [n1.ElementAttribute(TracingId = 347677U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Rb0od6QZt3QPkOU00sG35f", Name = "__slot_Rb0od6QZt3QPkOU00sG35f")]
        public static float __slot_Rb0od6QZt3QPkOU00sG35f = 1F;
        static Laplacian_HcSV7Gctd99N2OaOCzyWEt()
        {
        }

        public Laplacian_HcSV7Gctd99N2OaOCzyWEt(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Laplacian_HcSV7Gctd99N2OaOCzyWEt(Laplacian_HcSV7Gctd99N2OaOCzyWEt<T> other): base(other)
        {
            this.__cache_GhpsltpUROPNIUHtzqd5ec = other.__cache_GhpsltpUROPNIUHtzqd5ec;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_GhpsltpUROPNIUHtzqd5ec", in __cache_GhpsltpUROPNIUHtzqd5ec));
        }

        internal Laplacian_HcSV7Gctd99N2OaOCzyWEt<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<T>, n5.GpuValue<float>, n15.GradientDifferentiationMode>, n2.ValueTuple<n5.GpuValue<float>, n5.GpuValue<T>>> __cache_GhpsltpUROPNIUHtzqd5ec)
        {
            n25.Laplacian_HcSV7Gctd99N2OaOCzyWEt<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_GhpsltpUROPNIUHtzqd5ec != this.__cache_GhpsltpUROPNIUHtzqd5ec ? new Laplacian_HcSV7Gctd99N2OaOCzyWEt<T>(this)
                {__cache_GhpsltpUROPNIUHtzqd5ec = __cache_GhpsltpUROPNIUHtzqd5ec} : that_0;
            else
            {
                this.__cache_GhpsltpUROPNIUHtzqd5ec = __cache_GhpsltpUROPNIUHtzqd5ec;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "JC45RmZQlGwLhT71u2zMLf", Name = "__JC45RmZQlGwLhT71u2zMLf")]
        [n2.SerializableAttribute]
        public class __JC45RmZQlGwLhT71u2zMLf : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RXvCspJ5kMoOL0EqJMzP45);
                n1.CompilationHelper.SafeDispose(this.__p_UOuwgHu1GcLLrLOzL4yzgd);
                n1.CompilationHelper.SafeDispose(this.__p_JQhf9jVSLEKMvkeijwXa4d);
                n1.CompilationHelper.SafeDispose(this.__p_VzTug8LXMjfNOMAdSMtLxr);
                return;
            }

            [n1.ElementAttribute(TracingId = 347629U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "RXvCspJ5kMoOL0EqJMzP45", Name = "FunctionGradient", IsManaged = true, IsAutoGenerated = true)]
            public n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> __p_RXvCspJ5kMoOL0EqJMzP45;
            [n1.ElementAttribute(TracingId = 347645U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "UOuwgHu1GcLLrLOzL4yzgd", Name = "Dot", IsManaged = true, IsAutoGenerated = true)]
            public n7.Dot_VjBgbBbkOkiMLqm9EWGCSn<T> __p_UOuwgHu1GcLLrLOzL4yzgd;
            [n1.ElementAttribute(TracingId = 347654U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "JQhf9jVSLEKMvkeijwXa4d", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n8.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_JQhf9jVSLEKMvkeijwXa4d;
            [n1.ElementAttribute(TracingId = 347667U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "VzTug8LXMjfNOMAdSMtLxr", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n14.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_VzTug8LXMjfNOMAdSMtLxr;
            public __JC45RmZQlGwLhT71u2zMLf(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __JC45RmZQlGwLhT71u2zMLf(__JC45RmZQlGwLhT71u2zMLf other): base(other)
            {
                this.__p_RXvCspJ5kMoOL0EqJMzP45 = other.__p_RXvCspJ5kMoOL0EqJMzP45;
                this.__p_UOuwgHu1GcLLrLOzL4yzgd = other.__p_UOuwgHu1GcLLrLOzL4yzgd;
                this.__p_JQhf9jVSLEKMvkeijwXa4d = other.__p_JQhf9jVSLEKMvkeijwXa4d;
                this.__p_VzTug8LXMjfNOMAdSMtLxr = other.__p_VzTug8LXMjfNOMAdSMtLxr;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RXvCspJ5kMoOL0EqJMzP45", in __p_RXvCspJ5kMoOL0EqJMzP45), n1.CompilationHelper.GetValueOrExisting(values, "__p_UOuwgHu1GcLLrLOzL4yzgd", in __p_UOuwgHu1GcLLrLOzL4yzgd), n1.CompilationHelper.GetValueOrExisting(values, "__p_JQhf9jVSLEKMvkeijwXa4d", in __p_JQhf9jVSLEKMvkeijwXa4d), n1.CompilationHelper.GetValueOrExisting(values, "__p_VzTug8LXMjfNOMAdSMtLxr", in __p_VzTug8LXMjfNOMAdSMtLxr));
            }

            internal __JC45RmZQlGwLhT71u2zMLf __WITH__(n18.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<T> __p_RXvCspJ5kMoOL0EqJMzP45, n7.Dot_VjBgbBbkOkiMLqm9EWGCSn<T> __p_UOuwgHu1GcLLrLOzL4yzgd, n8.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_JQhf9jVSLEKMvkeijwXa4d, n14.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_VzTug8LXMjfNOMAdSMtLxr)
            {
                __JC45RmZQlGwLhT71u2zMLf that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RXvCspJ5kMoOL0EqJMzP45 != this.__p_RXvCspJ5kMoOL0EqJMzP45 || __p_UOuwgHu1GcLLrLOzL4yzgd != this.__p_UOuwgHu1GcLLrLOzL4yzgd || __p_JQhf9jVSLEKMvkeijwXa4d != this.__p_JQhf9jVSLEKMvkeijwXa4d || __p_VzTug8LXMjfNOMAdSMtLxr != this.__p_VzTug8LXMjfNOMAdSMtLxr ? new __JC45RmZQlGwLhT71u2zMLf(this)
                    {__p_RXvCspJ5kMoOL0EqJMzP45 = __p_RXvCspJ5kMoOL0EqJMzP45, __p_UOuwgHu1GcLLrLOzL4yzgd = __p_UOuwgHu1GcLLrLOzL4yzgd, __p_JQhf9jVSLEKMvkeijwXa4d = __p_JQhf9jVSLEKMvkeijwXa4d, __p_VzTug8LXMjfNOMAdSMtLxr = __p_VzTug8LXMjfNOMAdSMtLxr} : that_0;
                else
                {
                    this.__p_RXvCspJ5kMoOL0EqJMzP45 = __p_RXvCspJ5kMoOL0EqJMzP45;
                    this.__p_UOuwgHu1GcLLrLOzL4yzgd = __p_UOuwgHu1GcLLrLOzL4yzgd;
                    this.__p_JQhf9jVSLEKMvkeijwXa4d = __p_JQhf9jVSLEKMvkeijwXa4d;
                    this.__p_VzTug8LXMjfNOMAdSMtLxr = __p_VzTug8LXMjfNOMAdSMtLxr;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 347761U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "BYtxFwpFlW6PoOuNXauKES", Name = "Divergence_BYtxFwpFlW6PoOuNXauKES")]
    [n2.SerializableAttribute]
    public class Divergence_BYtxFwpFlW6PoOuNXauKES<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n25.Divergence_BYtxFwpFlW6PoOuNXauKES<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Divergence_BYtxFwpFlW6PoOuNXauKES<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n25.Divergence_BYtxFwpFlW6PoOuNXauKES<T> CreateDefault()
        {
            var instance = new Divergence_BYtxFwpFlW6PoOuNXauKES<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.Divergence_BYtxFwpFlW6PoOuNXauKES<T> Update(n5.GpuValue<float> Function_In, n5.GpuValue<T> Position_In, n5.GpuValue<float> Epsilon_In, out n5.GpuValue<T> Output_Out)
        {
            string __pad_NMh1n3mCJKDMdyekqb0AJ1_0 = __slot_NMh1n3mCJKDMdyekqb0AJ1;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_SnQvmMKXFsqMfeYzDQTcgb;
            if (manager_3 is null)
            {
                manager_3 = new n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, string, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>>(n2.ValueTuple.Create(default(n5.GpuValue<T>)));
            }

            var inputs_4 = (Position_In, Epsilon_In, __pad_NMh1n3mCJKDMdyekqb0AJ1_0, Function_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__FfQQ9gxK8V6LSPFl9NNQNR>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __FfQQ9gxK8V6LSPFl9NNQNR(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2 = n11._Operations_.CreateDefault<n5.AbstractGpuValue>(), __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE = n11._Operations_.CreateDefault<n5.IFunctionInvokeNode>(), __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn = n23._Operations_.CreateDefault<string, string>(), __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO = n11._Operations_.CreateDefault<n5.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "R4S4OdB4jKcObG1N9tZyBO", 347776U);
                    var Output_9 = n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>>.Create(Node_Context: Node_Context_8);
                    state_7.__p_R4S4OdB4jKcObG1N9tZyBO = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "GixvYNXmg0MOkjkBNSqlr4", 347806U);
                    var Output_11 = n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_10);
                    state_7.__p_GixvYNXmg0MOkjkBNSqlr4 = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("LdA1ELW7lENLS7wg8ceaPG", "KcUSPtd3qmuOA4lqIHzpg2", 347835U);
                    var Output_13 = n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.Create(Node_Context: Node_Context_12);
                    state_7.__p_KcUSPtd3qmuOA4lqIHzpg2 = Output_13;
                }

                string __pad_AnyJmymxHjVN2Z9nWcvZLJ_14 = __slot_AnyJmymxHjVN2Z9nWcvZLJ;
                string __pad_F1xt9gTrTirOtnBsoqD4mw_15 = __slot_F1xt9gTrTirOtnBsoqD4mw;
                float __pad_DalGVzzou4zMm5alwchRCv_16 = __slot_DalGVzzou4zMm5alwchRCv;
                var State_Output_18 = state_7.__p_GixvYNXmg0MOkjkBNSqlr4.Update(GpuValue_In: Epsilon_In, The_Value_In: __pad_DalGVzzou4zMm5alwchRCv_16, Output_Out: out n5.GpuValue<float> Output_17);
                var builder_19 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2, 1);
                builder_19.Add(Position_In);
                var __pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2_20 = builder_19.Commit();
                var State_Output_22 = state_7.__p_KcUSPtd3qmuOA4lqIHzpg2.Update(Function_In: Function_In, Parameters_In: __pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2_20, Id_In: __pad_AnyJmymxHjVN2Z9nWcvZLJ_14, Output_Out: out n5.FunctionInvokeNode<float> Output_21);
                n5.IFunctionInvokeNode Input_23 = (n5.IFunctionInvokeNode)Output_21;
                var builder_24 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_ECois0CKILyQcHvYXKlNGE, 1);
                builder_24.Add(Input_23);
                var __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE_25 = builder_24.Commit();
                n11._Operations_.FromValue<n5.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE_25, Result_Out: out n10.Spread<n5.IFunctionInvokeNode> Result_26);
                var Result_27 = n5.TypeHelpers.GetDimension<T>(theValue: Position_In);
                var Result_28 = n21.ObjectHelpers.ToString(input: Result_27);
                var builder_29 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn, 1);
                builder_29.Add("DomainDimension", Result_28);
                var __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn_30 = builder_29.Commit();
                n23._Operations_.Cons<string>(Input_In: __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn_30, Output_Out: out n22.ImmutableDictionary<string, string> Output_31);
                n5.GpuValue<T> Default_Result_32 = default(n5.GpuValue<T>);
                n13.IEnumerable<string> Mixins_33 = n24._Operations_.CreateDefault<string>();
                bool Is_Groupable_34 = false;
                n13.IEnumerable<n5.InputModifier> The_Modifiers_35 = n24._Operations_.CreateDefault<n5.InputModifier>();
                var builder_36 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO, 2);
                builder_36.Add(Position_In);
                builder_36.Add(Output_17);
                var __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO_37 = builder_36.Commit();
                var State_Output_40 = state_7.__p_R4S4OdB4jKcObG1N9tZyBO.Update(Arguments_In: __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO_37, Function_Name_In: __pad_F1xt9gTrTirOtnBsoqD4mw_15, Code_Template_In: __pad_NMh1n3mCJKDMdyekqb0AJ1_0, Default_Result_In: Default_Result_32, Functions_In: Result_26, Mixins_In: Mixins_33, Template_Values_In: Output_31, Is_Groupable_In: Is_Groupable_34, The_Modifiers_In: The_Modifiers_35, Output_Out: out n5.GpuValue<T> Output_38, AdditionalOutputs_Out: out n10.Spread<n5.AbstractGpuValue> AdditionalOutputs_39);
                var AdditionalOutputs_41 = (n5.AbstractGpuValue)AdditionalOutputs_39[0];
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_18 != state_7.__p_GixvYNXmg0MOkjkBNSqlr4 || __pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2_20 != state_7.__pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2 || State_Output_22 != state_7.__p_KcUSPtd3qmuOA4lqIHzpg2 || __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE_25 != state_7.__pin_group_Input_In_ECois0CKILyQcHvYXKlNGE || __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn_30 != state_7.__pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn || __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO_37 != state_7.__pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO || State_Output_40 != state_7.__p_R4S4OdB4jKcObG1N9tZyBO ? new __FfQQ9gxK8V6LSPFl9NNQNR(state_7)
                    {__p_GixvYNXmg0MOkjkBNSqlr4 = State_Output_18, __pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2 = __pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2_20, __p_KcUSPtd3qmuOA4lqIHzpg2 = State_Output_22, __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE = __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE_25, __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn = __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn_30, __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO = __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO_37, __p_R4S4OdB4jKcObG1N9tZyBO = State_Output_40} : state_7;
                else
                {
                    state_7.__p_GixvYNXmg0MOkjkBNSqlr4 = State_Output_18;
                    state_7.__pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2 = __pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2_20;
                    state_7.__p_KcUSPtd3qmuOA4lqIHzpg2 = State_Output_22;
                    state_7.__pin_group_Input_In_ECois0CKILyQcHvYXKlNGE = __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE_25;
                    state_7.__pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn = __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn_30;
                    state_7.__pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO = __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO_37;
                    state_7.__p_R4S4OdB4jKcObG1N9tZyBO = State_Output_40;
                }

                outputs_5 = n2.ValueTuple.Create(Output_38);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_42 = outputs_5.Item1;
            Output_Out = __auto_42;
            n25.Divergence_BYtxFwpFlW6PoOuNXauKES<T> that_43 = this;
            if (this.__GetContext__().IsImmutable)
                that_43 = manager_3 != this.__cache_SnQvmMKXFsqMfeYzDQTcgb ? new Divergence_BYtxFwpFlW6PoOuNXauKES<T>(this)
                {__cache_SnQvmMKXFsqMfeYzDQTcgb = manager_3} : that_43;
            else
            {
                this.__cache_SnQvmMKXFsqMfeYzDQTcgb = manager_3;
            }

            return that_43;
        }

        public n25.Divergence_BYtxFwpFlW6PoOuNXauKES<T> __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n25.Divergence_BYtxFwpFlW6PoOuNXauKES<T> that_0 = this;
            this.__cache_SnQvmMKXFsqMfeYzDQTcgb = null;
            return that_0;
        }

        public n25.Divergence_BYtxFwpFlW6PoOuNXauKES<T> __CreateDefault__()
        {
            n25.Divergence_BYtxFwpFlW6PoOuNXauKES<T> that_0 = this;
            this.__cache_SnQvmMKXFsqMfeYzDQTcgb = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_SnQvmMKXFsqMfeYzDQTcgb);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 347865U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "NMh1n3mCJKDMdyekqb0AJ1", Name = "__slot_NMh1n3mCJKDMdyekqb0AJ1")]
        public static string __slot_NMh1n3mCJKDMdyekqb0AJ1 = "${resultType} ${signature} (${resultType} p,float e)\r\n{\r\n\r\n    ${resultType} result = ${function}(p);\r\n    ${resultType} offset = 0.;  \r\n\r\n    for(int i = 0; i < ${DomainDimension}; i++)\r\n    {\r\n        ${resultType} offset = .0;\r\n        offset[i] = e;\r\n        result[i] =( ${function}(p + offset) -  result[i]) /  e;\r\n    }\r\n\r\n    return result;\r\n}";
        [n1.ElementAttribute(TracingId = 347869U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "TbgC3qUhfAZLRmlceuLeh7", Name = "__slot_TbgC3qUhfAZLRmlceuLeh7")]
        public static string __slot_TbgC3qUhfAZLRmlceuLeh7 = "note that the [i] here is actully indexing vector component, not an array!";
        [n1.ElementAttribute(TracingId = 347764U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "SnQvmMKXFsqMfeYzDQTcgb", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, string, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_SnQvmMKXFsqMfeYzDQTcgb = null;
        [n1.ElementAttribute(TracingId = 347797U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "AnyJmymxHjVN2Z9nWcvZLJ", Name = "__slot_AnyJmymxHjVN2Z9nWcvZLJ")]
        public static string __slot_AnyJmymxHjVN2Z9nWcvZLJ = "function";
        [n1.ElementAttribute(TracingId = 347798U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "F1xt9gTrTirOtnBsoqD4mw", Name = "__slot_F1xt9gTrTirOtnBsoqD4mw")]
        public static string __slot_F1xt9gTrTirOtnBsoqD4mw = "FD_Gradient";
        [n1.ElementAttribute(TracingId = 347812U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "DalGVzzou4zMm5alwchRCv", Name = "__slot_DalGVzzou4zMm5alwchRCv")]
        public static float __slot_DalGVzzou4zMm5alwchRCv = 0.001F;
        static Divergence_BYtxFwpFlW6PoOuNXauKES()
        {
        }

        public Divergence_BYtxFwpFlW6PoOuNXauKES(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Divergence_BYtxFwpFlW6PoOuNXauKES(Divergence_BYtxFwpFlW6PoOuNXauKES<T> other): base(other)
        {
            this.__cache_SnQvmMKXFsqMfeYzDQTcgb = other.__cache_SnQvmMKXFsqMfeYzDQTcgb;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_SnQvmMKXFsqMfeYzDQTcgb", in __cache_SnQvmMKXFsqMfeYzDQTcgb));
        }

        internal Divergence_BYtxFwpFlW6PoOuNXauKES<T> __WITH__(n6.Manager<n2.ValueTuple<n5.GpuValue<T>, n5.GpuValue<float>, string, n5.GpuValue<float>>, n2.ValueTuple<n5.GpuValue<T>>> __cache_SnQvmMKXFsqMfeYzDQTcgb)
        {
            n25.Divergence_BYtxFwpFlW6PoOuNXauKES<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_SnQvmMKXFsqMfeYzDQTcgb != this.__cache_SnQvmMKXFsqMfeYzDQTcgb ? new Divergence_BYtxFwpFlW6PoOuNXauKES<T>(this)
                {__cache_SnQvmMKXFsqMfeYzDQTcgb = __cache_SnQvmMKXFsqMfeYzDQTcgb} : that_0;
            else
            {
                this.__cache_SnQvmMKXFsqMfeYzDQTcgb = __cache_SnQvmMKXFsqMfeYzDQTcgb;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "FfQQ9gxK8V6LSPFl9NNQNR", Name = "__FfQQ9gxK8V6LSPFl9NNQNR")]
        [n2.SerializableAttribute]
        public class __FfQQ9gxK8V6LSPFl9NNQNR : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_R4S4OdB4jKcObG1N9tZyBO);
                n1.CompilationHelper.SafeDispose(this.__p_GixvYNXmg0MOkjkBNSqlr4);
                n1.CompilationHelper.SafeDispose(this.__p_KcUSPtd3qmuOA4lqIHzpg2);
                return;
            }

            [n1.ElementAttribute(TracingId = 347776U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "R4S4OdB4jKcObG1N9tZyBO", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>> __p_R4S4OdB4jKcObG1N9tZyBO;
            [n1.ElementAttribute(TracingId = 347806U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "GixvYNXmg0MOkjkBNSqlr4", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_GixvYNXmg0MOkjkBNSqlr4;
            [n1.ElementAttribute(TracingId = 347835U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "KcUSPtd3qmuOA4lqIHzpg2", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_KcUSPtd3qmuOA4lqIHzpg2;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2 = default(n10.Spread<n5.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.IFunctionInvokeNode> __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE = default(n10.Spread<n5.IFunctionInvokeNode>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n22.ImmutableDictionary<string, string> __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn = default(n22.ImmutableDictionary<string, string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO = default(n10.Spread<n5.AbstractGpuValue>);
            public __FfQQ9gxK8V6LSPFl9NNQNR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __FfQQ9gxK8V6LSPFl9NNQNR(__FfQQ9gxK8V6LSPFl9NNQNR other): base(other)
            {
                this.__p_R4S4OdB4jKcObG1N9tZyBO = other.__p_R4S4OdB4jKcObG1N9tZyBO;
                this.__p_GixvYNXmg0MOkjkBNSqlr4 = other.__p_GixvYNXmg0MOkjkBNSqlr4;
                this.__p_KcUSPtd3qmuOA4lqIHzpg2 = other.__p_KcUSPtd3qmuOA4lqIHzpg2;
                this.__pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2 = other.__pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2;
                this.__pin_group_Input_In_ECois0CKILyQcHvYXKlNGE = other.__pin_group_Input_In_ECois0CKILyQcHvYXKlNGE;
                this.__pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn = other.__pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn;
                this.__pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO = other.__pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_R4S4OdB4jKcObG1N9tZyBO", in __p_R4S4OdB4jKcObG1N9tZyBO), n1.CompilationHelper.GetValueOrExisting(values, "__p_GixvYNXmg0MOkjkBNSqlr4", in __p_GixvYNXmg0MOkjkBNSqlr4), n1.CompilationHelper.GetValueOrExisting(values, "__p_KcUSPtd3qmuOA4lqIHzpg2", in __p_KcUSPtd3qmuOA4lqIHzpg2), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2", in __pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_ECois0CKILyQcHvYXKlNGE", in __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn", in __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO", in __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO));
            }

            internal __FfQQ9gxK8V6LSPFl9NNQNR __WITH__(n19.CustomFunction_SbJY8E2PFscPAropl3Jh79<T, n13.IEnumerable<n5.InputModifier>> __p_R4S4OdB4jKcObG1N9tZyBO, n20.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_GixvYNXmg0MOkjkBNSqlr4, n9.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_KcUSPtd3qmuOA4lqIHzpg2, n10.Spread<n5.AbstractGpuValue> __pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2, n10.Spread<n5.IFunctionInvokeNode> __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE, n22.ImmutableDictionary<string, string> __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn, n10.Spread<n5.AbstractGpuValue> __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO)
            {
                __FfQQ9gxK8V6LSPFl9NNQNR that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_R4S4OdB4jKcObG1N9tZyBO != this.__p_R4S4OdB4jKcObG1N9tZyBO || __p_GixvYNXmg0MOkjkBNSqlr4 != this.__p_GixvYNXmg0MOkjkBNSqlr4 || __p_KcUSPtd3qmuOA4lqIHzpg2 != this.__p_KcUSPtd3qmuOA4lqIHzpg2 || __pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2 != this.__pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2 || __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE != this.__pin_group_Input_In_ECois0CKILyQcHvYXKlNGE || __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn != this.__pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn || __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO != this.__pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO ? new __FfQQ9gxK8V6LSPFl9NNQNR(this)
                    {__p_R4S4OdB4jKcObG1N9tZyBO = __p_R4S4OdB4jKcObG1N9tZyBO, __p_GixvYNXmg0MOkjkBNSqlr4 = __p_GixvYNXmg0MOkjkBNSqlr4, __p_KcUSPtd3qmuOA4lqIHzpg2 = __p_KcUSPtd3qmuOA4lqIHzpg2, __pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2 = __pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2, __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE = __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE, __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn = __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn, __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO = __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO} : that_0;
                else
                {
                    this.__p_R4S4OdB4jKcObG1N9tZyBO = __p_R4S4OdB4jKcObG1N9tZyBO;
                    this.__p_GixvYNXmg0MOkjkBNSqlr4 = __p_GixvYNXmg0MOkjkBNSqlr4;
                    this.__p_KcUSPtd3qmuOA4lqIHzpg2 = __p_KcUSPtd3qmuOA4lqIHzpg2;
                    this.__pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2 = __pin_group_Parameters_In_KcUSPtd3qmuOA4lqIHzpg2;
                    this.__pin_group_Input_In_ECois0CKILyQcHvYXKlNGE = __pin_group_Input_In_ECois0CKILyQcHvYXKlNGE;
                    this.__pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn = __pin_group_Input_In_Mz0FznPhAYqNdmbwqD9Sqn;
                    this.__pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO = __pin_group_Arguments_In_R4S4OdB4jKcObG1N9tZyBO;
                }

                return that_0;
            }
        }
    }
}

namespace _Fuse_Core_Calculus_.Fuse.Core.Calculus
{
    [n1.ElementAttribute(TracingId = 347972U, DocumentId = "LdA1ELW7lENLS7wg8ceaPG", PersistentId = "Irt0YFriJdfL2EJnYYiPxv", Name = "Fuse_Core_CalculusApplication_Irt0YFriJdfL2EJnYYiPxv")]
    [n2.SerializableAttribute]
    public class Fuse_Core_CalculusApplication_Irt0YFriJdfL2EJnYYiPxv : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.Fuse_Core_CalculusApplication_Irt0YFriJdfL2EJnYYiPxv Create(n1.NodeContext Node_Context)
        {
            var instance = new Fuse_Core_CalculusApplication_Irt0YFriJdfL2EJnYYiPxv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.Fuse_Core_CalculusApplication_Irt0YFriJdfL2EJnYYiPxv CreateDefault()
        {
            var instance = new Fuse_Core_CalculusApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.Fuse_Core_CalculusApplication_Irt0YFriJdfL2EJnYYiPxv Update()
        {
            return this;
        }

        public n30.Fuse_Core_CalculusApplication_Irt0YFriJdfL2EJnYYiPxv __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n30.Fuse_Core_CalculusApplication_Irt0YFriJdfL2EJnYYiPxv __CreateDefault__()
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

        public Fuse_Core_CalculusApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Fuse_Core_CalculusApplication_Irt0YFriJdfL2EJnYYiPxv(Fuse_Core_CalculusApplication_Irt0YFriJdfL2EJnYYiPxv other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal Fuse_Core_CalculusApplication_Irt0YFriJdfL2EJnYYiPxv __WITH__()
        {
            return this;
        }
    }
}

namespace _Fuse_Core_Calculus_
{
    public struct __AdaptiveImplementations__LdA1ELW7lENLS7wg8ceaPG : n17.IAdaptiveCreateDefault<n5.GpuValue<n26.Vector2>>
    {
        public void CreateDefault(out n5.GpuValue<n26.Vector2> Output_Out)
        {
            n31._Operations_.CreateDefault_Generic<n5.GpuValue<n26.Vector2>>(Output_Out: out n5.GpuValue<n26.Vector2> Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}