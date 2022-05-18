extern alias e3;
extern alias e2;

using n3 = e2::VL.Lib.Collections;
using n5 = _VL_Collections_.Collections.Builder.SpreadBuilder.Advanced;
using n2 = global::System.Collections.Generic;
using n7 = _CoreLibBasics_.Math.Adaptive;
using n10 = e3::VL.Lib.Primitive;
using n12 = _VL_Algorithms_.Main;
using n1 = e2::VL.Core;
using n8 = global::System;
using n6 = e2::VL.Core.CompilerServices;
using n9 = _VL_Algorithms_.Math.Experimental;
using n11 = global::System.Runtime.CompilerServices;
using n4 = _VL_Collections_.Collections.Spread;

namespace _VL_Algorithms_.Math
{
    [n1.ElementAttribute(TracingId = 117939U, DocumentId = "FfNIU8JmRhkMDjmmr5sTAB", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ConnectAll<T2, T, AdM>(T2 Input_In, [n6.SerializedDefaultValueAttribute("0.25", false)] float Threshold_In, out n3.Spread<T> From_Out, out n3.Spread<T> To_Out, out n3.Spread<float> Distance_Out, out n3.Spread<int> From_Index_Out, out n3.Spread<int> To_Index_Out)
            where T2 : n2.IEnumerable<T> where AdM : struct, n7.IAdaptiveDistance<T>
        {
            var w_0 = default(AdM);
            int __pad_GDlLSEwQDyjPcSd6EbhHaR_1 = __slot_GDlLSEwQDyjPcSd6EbhHaR;
            n2.IEnumerable<T> Input_2 = (n2.IEnumerable<T>)Input_In;
            n4._Operations_.FromSequence<T>(Input_In: Input_2, Result_Out: out n3.Spread<T> Result_3);
            var Output_4 = n5._Operations_.CreateDefault<T>();
            var Output_5 = n5._Operations_.CreateDefault<T>();
            n4._Operations_.Count<T>(Input_In: Result_3, Count_Out: out int Count_6);
            n3.SpreadBuilder<T> accumulator_8 = Output_4;
            n3.SpreadBuilder<T> accumulator_9 = Output_5;
            n3.SpreadBuilder<float> accumulator_10 = n5._Operations_.CreateDefault<float>();
            n3.SpreadBuilder<int> accumulator_11 = n5._Operations_.CreateDefault<int>();
            n3.SpreadBuilder<int> accumulator_12 = n5._Operations_.CreateDefault<int>();
            var i_14 = 0;
            foreach (var item_7 in n6.CollectionExtensions.AsSpan(Result_3))
            {
                var splicer_13 = item_7;
                var i_local_15 = i_14;
                var Output_16 = Count_6 - i_local_15;
                var Output_17 = Output_16 - __pad_GDlLSEwQDyjPcSd6EbhHaR_1;
                n3.SpreadBuilder<T> accumulator_19 = accumulator_8;
                n3.SpreadBuilder<T> accumulator_20 = accumulator_9;
                n3.SpreadBuilder<float> accumulator_21 = accumulator_10;
                n3.SpreadBuilder<int> accumulator_22 = accumulator_11;
                n3.SpreadBuilder<int> accumulator_23 = accumulator_12;
                for (var i_18 = 0; i_18 < Output_17; i_18++)
                {
                    var i_local_24 = i_18;
                    var Output_25 = i_local_15 + __pad_GDlLSEwQDyjPcSd6EbhHaR_1;
                    var Output_26 = Output_25 + i_local_24;
                    n4._Operations_.GetItem<T>(Input_In: Result_3, Index_In: Output_26, Item_Out: out T Item_27);
                    w_0.Distance(Input_In: splicer_13, Input_2_In: Item_27, Result_Out: out float Result_28);
                    var Result_29 = Result_28 < Threshold_In;
                    n3.SpreadBuilder<T> __auto_30;
                    n3.SpreadBuilder<T> __auto_31;
                    n3.SpreadBuilder<float> __auto_32;
                    n3.SpreadBuilder<int> __auto_33;
                    n3.SpreadBuilder<int> __auto_34;
                    if (Result_29)
                    {
                        n5._Operations_.Add<T>(Input_In: accumulator_19, Item_In: splicer_13, Output_Out: out n3.SpreadBuilder<T> Output_35);
                        __auto_30 = Output_35;
                        n5._Operations_.Add<T>(Input_In: accumulator_20, Item_In: Item_27, Output_Out: out n3.SpreadBuilder<T> Output_36);
                        __auto_31 = Output_36;
                        n5._Operations_.Add<float>(Input_In: accumulator_21, Item_In: Result_28, Output_Out: out n3.SpreadBuilder<float> Output_37);
                        __auto_32 = Output_37;
                        n5._Operations_.Add<int>(Input_In: accumulator_22, Item_In: i_local_15, Output_Out: out n3.SpreadBuilder<int> Output_38);
                        __auto_33 = Output_38;
                        n5._Operations_.Add<int>(Input_In: accumulator_23, Item_In: Output_26, Output_Out: out n3.SpreadBuilder<int> Output_39);
                        __auto_34 = Output_39;
                    }
                    else
                    {
                        __auto_30 = accumulator_19;
                        __auto_31 = accumulator_20;
                        __auto_32 = accumulator_21;
                        __auto_33 = accumulator_22;
                        __auto_34 = accumulator_23;
                    }

                    accumulator_19 = __auto_30;
                    accumulator_20 = __auto_31;
                    accumulator_21 = __auto_32;
                    accumulator_22 = __auto_33;
                    accumulator_23 = __auto_34;
                }

                accumulator_8 = accumulator_19;
                accumulator_9 = accumulator_20;
                accumulator_10 = accumulator_21;
                accumulator_11 = accumulator_22;
                accumulator_12 = accumulator_23;
                i_14++;
            }

            n5._Operations_.ToSpread<T>(Input_In: accumulator_8, Output_Out: out n3.SpreadBuilder<T> Output_40, Result_Out: out n3.Spread<T> Result_41);
            n5._Operations_.ToSpread<T>(Input_In: accumulator_9, Output_Out: out n3.SpreadBuilder<T> Output_42, Result_Out: out n3.Spread<T> Result_43);
            n5._Operations_.ToSpread<float>(Input_In: accumulator_10, Output_Out: out n3.SpreadBuilder<float> Output_44, Result_Out: out n3.Spread<float> Result_45);
            n5._Operations_.ToSpread<int>(Input_In: accumulator_11, Output_Out: out n3.SpreadBuilder<int> Output_46, Result_Out: out n3.Spread<int> Result_47);
            n5._Operations_.ToSpread<int>(Input_In: accumulator_12, Output_Out: out n3.SpreadBuilder<int> Output_48, Result_Out: out n3.Spread<int> Result_49);
            From_Out = Result_41;
            To_Out = Result_43;
            Distance_Out = Result_45;
            From_Index_Out = Result_47;
            To_Index_Out = Result_49;
            return;
        }

        [n1.ElementAttribute(TracingId = 117963U, DocumentId = "FfNIU8JmRhkMDjmmr5sTAB", PersistentId = "GDlLSEwQDyjPcSd6EbhHaR", Name = "__slot_GDlLSEwQDyjPcSd6EbhHaR")]
        public static int __slot_GDlLSEwQDyjPcSd6EbhHaR = 1;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Algorithms_.Math.Experimental
{
    [n1.ElementAttribute(TracingId = 118670U, DocumentId = "FfNIU8JmRhkMDjmmr5sTAB", PersistentId = "S86pZNx4rdnMBTYotv02VI", Name = "ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI")]
    [n8.SerializableAttribute]
    public class ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T> : n1.VLObject, n8.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n9.ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n9.ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T> CreateDefault()
        {
            var instance = new ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n9.ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T> Update<T2, AdM>(T2 Input_In, [n6.SerializedDefaultValueAttribute("0.5", false)] float Treshold_In, out n3.SpreadBuilder<T> Start_Out, out n3.SpreadBuilder<T> End_Out)
            where T2 : n2.IEnumerable<T> where AdM : struct, n7.IAdaptiveDistanceSquared<T>
        {
            var w_0 = default(AdM);
            n3.SpreadBuilder<T> __auto_1 = this.A;
            n3.SpreadBuilder<T> __auto_2 = this.B;
            int __pad_OKVaJvl3Px8MXhG24z8sAD_3 = __slot_OKVaJvl3Px8MXhG24z8sAD;
            n2.IEnumerable<T> Input_4 = (n2.IEnumerable<T>)Input_In;
            n4._Operations_.FromSequence<T>(Input_In: Input_4, Result_Out: out n3.Spread<T> Result_5);
            n5._Operations_.Clear<T>(Input_In: __auto_1, Output_Out: out n3.SpreadBuilder<T> Output_6);
            n5._Operations_.Clear<T>(Input_In: __auto_2, Output_Out: out n3.SpreadBuilder<T> Output_7);
            n4._Operations_.Count<T>(Input_In: Result_5, Count_Out: out int Count_8);
            float Exponent_9 = 2F;
            var Output_10 = n10.Float32Extensions.Pow(input: Treshold_In, exponent: Exponent_9);
            n3.SpreadBuilder<T> accumulator_12 = Output_6;
            n3.SpreadBuilder<T> accumulator_13 = Output_7;
            var i_15 = 0;
            foreach (var item_11 in n6.CollectionExtensions.AsSpan(Result_5))
            {
                var splicer_14 = item_11;
                var i_local_16 = i_15;
                var Output_18 = Count_8 - i_local_16;
                var Output_19 = Output_18 - __pad_OKVaJvl3Px8MXhG24z8sAD_3;
                for (var i_20 = 0; i_20 < Output_19; i_20++)
                {
                    var i_local_21 = i_20;
                    var Output_23 = i_local_16 + __pad_OKVaJvl3Px8MXhG24z8sAD_3;
                    var Output_24 = Output_23 + i_local_21;
                    n4._Operations_.GetItem<T>(Input_In: Result_5, Index_In: Output_24, Item_Out: out T Item_25);
                    w_0.DistanceSquared(Input_In: splicer_14, Input_2_In: Item_25, Result_Out: out float Result_26);
                    var Result_27 = Result_26 < Output_10;
                    if (Result_27)
                    {
                        n5._Operations_.Add<T>(Input_In: Output_6, Item_In: splicer_14, Output_Out: out n3.SpreadBuilder<T> Output_29);
                        n5._Operations_.Add<T>(Input_In: Output_7, Item_In: Item_25, Output_Out: out n3.SpreadBuilder<T> Output_30);
                    }
                }

                i_15++;
            }

            Start_Out = accumulator_12;
            End_Out = accumulator_13;
            return this;
        }

        public n9.ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T> __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n9.ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T> that_0 = this;
            this.A = n5._Operations_.CreateDefault<T>();
            this.B = n5._Operations_.CreateDefault<T>();
            return that_0;
        }

        public n9.ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T> __CreateDefault__()
        {
            n9.ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T> that_0 = this;
            this.A = n5._Operations_.CreateDefault<T>();
            this.B = n5._Operations_.CreateDefault<T>();
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n8.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 118674U, DocumentId = "FfNIU8JmRhkMDjmmr5sTAB", PersistentId = "OKVaJvl3Px8MXhG24z8sAD", Name = "__slot_OKVaJvl3Px8MXhG24z8sAD")]
        public static int __slot_OKVaJvl3Px8MXhG24z8sAD = 1;
        [n1.ElementAttribute(TracingId = 118923U, DocumentId = "FfNIU8JmRhkMDjmmr5sTAB", PersistentId = "FuHrDLK5CzrNumulbUQ1c1", Name = "A")]
        public n3.SpreadBuilder<T> A;
        [n1.ElementAttribute(TracingId = 118928U, DocumentId = "FfNIU8JmRhkMDjmmr5sTAB", PersistentId = "H5V6xwdiDVeOWV9XnyEVgB", Name = "B")]
        public n3.SpreadBuilder<T> B;
        static ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI()
        {
        }

        public ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI(ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T> other): base(other)
        {
            this.A = other.A;
            this.B = other.B;
        }

        protected override n1.IVLObject __With__(n2.IReadOnlyDictionary<string, n8.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "A", in A), n1.CompilationHelper.GetValueOrExisting(values, "B", in B));
        }

        internal ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T> __WITH__(n3.SpreadBuilder<T> A, n3.SpreadBuilder<T> B)
        {
            n9.ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = A != this.A || B != this.B ? new ConnectAll_AllocationFree_S86pZNx4rdnMBTYotv02VI<T>(this)
                {A = A, B = B} : that_0;
            else
            {
                this.A = A;
                this.B = B;
            }

            return that_0;
        }
    }
}

namespace _VL_Algorithms_.Main
{
    [n1.ElementAttribute(TracingId = 119099U, DocumentId = "FfNIU8JmRhkMDjmmr5sTAB", PersistentId = "BL9ZqWydKsDLZ6fC9smPgh", Name = "VL_AlgorithmsApplication_BL9ZqWydKsDLZ6fC9smPgh")]
    [n8.SerializableAttribute]
    public class VL_AlgorithmsApplication_BL9ZqWydKsDLZ6fC9smPgh : n1.VLObject, n8.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n12.VL_AlgorithmsApplication_BL9ZqWydKsDLZ6fC9smPgh Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_AlgorithmsApplication_BL9ZqWydKsDLZ6fC9smPgh(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n12.VL_AlgorithmsApplication_BL9ZqWydKsDLZ6fC9smPgh CreateDefault()
        {
            var instance = new VL_AlgorithmsApplication_BL9ZqWydKsDLZ6fC9smPgh(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n12.VL_AlgorithmsApplication_BL9ZqWydKsDLZ6fC9smPgh Update()
        {
            return this;
        }

        public n12.VL_AlgorithmsApplication_BL9ZqWydKsDLZ6fC9smPgh __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n12.VL_AlgorithmsApplication_BL9ZqWydKsDLZ6fC9smPgh __CreateDefault__()
        {
            return this;
        }

        public void Dispose()
        {
            return;
        }

        void n8.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        public VL_AlgorithmsApplication_BL9ZqWydKsDLZ6fC9smPgh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_AlgorithmsApplication_BL9ZqWydKsDLZ6fC9smPgh(VL_AlgorithmsApplication_BL9ZqWydKsDLZ6fC9smPgh other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n2.IReadOnlyDictionary<string, n8.Object> values)
        {
            return __WITH__();
        }

        internal VL_AlgorithmsApplication_BL9ZqWydKsDLZ6fC9smPgh __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Algorithms_
{
    public struct __AdaptiveImplementations__FfNIU8JmRhkMDjmmr5sTAB
    {
    }
}