extern alias e3;
extern alias e2;
extern alias e4;

using n60 = _CoreLibBasics_.Primitive.Delegates.Delegate__2_MG_0.Advanced;
using n16 = _VL_Collections_.Collections.IReadOnlyList;
using n37 = _CoreLibBasics_.Primitive.Int3;
using n64 = _CoreLibBasics_.Primitive.Delegates.Delegate__1_MG_0.Advanced;
using n14 = _CoreLibBasics_.Control.Advanced;
using n5 = e2::VL.Lib.Collections;
using n42 = e3::VL.Lib.Primitive.CacheRegion;
using n62 = _VL_Collections_.Collections.Trees.Internal;
using n3 = _VL_Collections_.Collections;
using n58 = global::System.Reactive.Subjects;
using n11 = _VL_Collections_.Collections.Mutable.MutableDictionary.Advanced;
using n59 = _CoreLibBasics_.Primitive.Object.Advanced;
using n24 = _VL_Collections_.Collections.Builder.SpreadBuilder.Advanced;
using n34 = _CoreLibBasics_.Control;
using n21 = global::System.Collections.Immutable;
using n40 = global::System.Collections.ObjectModel;
using n56 = e3::VL.Lib.Collections.TreePatching;
using n29 = _CoreLibBasics_._2D;
using n15 = global::System.Collections;
using n50 = _CoreLibBasics_.Primitive.Delegates.Delegate__0_MG_1.Advanced;
using n30 = _CoreLibBasics_.Math.Ranges.Range;
using n65 = _VL_Collections_.Collections.Trees.Command.Continue;
using n25 = e3::VL.Lib.Collections.Spread;
using n6 = global::System.Collections.Generic;
using n33 = _CoreLibBasics_._2D.Vector2;
using n20 = _VL_Collections_.Collections.Common.KeyValuePair;
using n19 = _CoreLibBasics_.Math.Adaptive;
using n54 = e2::VL.Lib.Basics.Resources;
using n51 = _VL_Collections_.Collections.Common.Advanced;
using n18 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n35 = e3::VL.Lib.Collections.Spread.SpreadGenerators;
using n22 = _VL_Collections_.Collections.Mutable.MutableList.Advanced;
using n32 = _VL_Collections_.Collections.Spread.Advanced;
using n61 = e3::VL.Lib.Collections.Trees;
using n10 = e3::VL.Lib.Primitive;
using n13 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n41 = e2::VL.Lib.Basics.Imaging;
using n27 = e3::VL.Lib.Mathematics;
using n69 = _CoreLibBasics_.IO.Stream.Experimental;
using n48 = _VL_Collections_.Collections.Spread.Internal;
using n1 = e2::VL.Core;
using n47 = _CoreLibBasics_.Primitive.Delegates.Delegate__2_MG_1.Advanced;
using n63 = _VL_Collections_.Collections.Trees.IReadOnlyTree;
using n2 = global::System;
using n36 = _CoreLibBasics_.Primitive.Int2;
using n26 = e4::Stride.Core.Mathematics;
using n17 = _CoreLibBasics_.Primitive.Delegates.Delegate__1_MG_1.Advanced;
using n31 = _CoreLibBasics_._2D.Rectangle;
using n57 = _VL_Collections_.Collections.Trees.Patching.TreeNodeParentManager.Advanced;
using n52 = e3::VL.Lib.IO;
using n4 = e2::VL.Core.CompilerServices;
using n49 = _VL_Collections_.Collections.Spread.ResampleHermite;
using n23 = e3::VL.Lib.Collections;
using n43 = e3::VL.Lib;
using n44 = global::System.Collections.Concurrent;
using n28 = _VL_Collections_.Collections.Mutable.MutableArray.Advanced;
using n45 = e2::VL.Core.CompilerServices.CollectionBuilders;
using n12 = _VL_Collections_;
using n8 = _VL_Collections_.Collections.Sequence;
using n9 = global::System.Runtime.CompilerServices;
using n38 = _CoreLibBasics_.Math;
using n55 = _VL_Collections_.Collections.Trees.Patching.Advanced;
using n39 = global::System.Linq;
using n70 = _VL_Collections_.Collections.Trees.Command;
using n7 = _VL_Collections_.Collections.Spread;
using n46 = _VL_CoreLib_Experimental_.Control.Experimental;
using n68 = _CoreLibBasics_.Primitive.Advanced;
using n67 = _CoreLibBasics_._3D.Vector4;
using n66 = _CoreLibBasics_._3D.Vector3;
using n53 = global::System.IO;

namespace _VL_Collections_.Collections
{
    [n1.ElementAttribute(TracingId = 260685U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "EAvS1XXezCmL7nXpFVvQcX", Name = "SequenceChanged_EAvS1XXezCmL7nXpFVvQcX")]
    [n2.SerializableAttribute]
    public class SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> CreateDefault()
        {
            var instance = new SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> Update<T2>(T2 Value_In, out bool Result_Out, out bool Unchanged_Out)
            where T2 : n6.IEnumerable<T>
        {
            n5.Spread<T> __auto_0 = this.Old;
            n6.IEnumerable<T> Input_1 = (n6.IEnumerable<T>)Value_In;
            n7._Operations_.FromSequence<T>(Input_In: Input_1, Result_Out: out n5.Spread<T> Result_2);
            n5.Spread<T> __auto_3 = Result_2;
            n6.IEnumerable<T> Input_4 = (n6.IEnumerable<T>)Result_2;
            n6.IEnumerable<T> Second_5 = (n6.IEnumerable<T>)__auto_0;
            n8._Operations_.SequenceEqual<T>(Input_In: Input_4, Second_In: Second_5, Result_Out: out bool Result_6);
            var Output_7 = !Result_6;
            Result_Out = Output_7;
            Unchanged_Out = Result_6;
            n3.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> that_8 = this;
            if (this.__GetContext__().IsImmutable)
                that_8 = Result_2 != this.Old ? new SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T>(this)
                {Old = Result_2} : that_8;
            else
            {
                this.Old = Result_2;
            }

            return that_8;
        }

        public n3.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> that_0 = this;
            this.Old = n7._Operations_.CreateDefault<T>();
            return that_0;
        }

        public n3.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> __CreateDefault__()
        {
            n3.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> that_0 = this;
            this.Old = n7._Operations_.CreateDefault<T>();
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

        [n1.ElementAttribute(TracingId = 260687U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "BBzn2bqLt0OP7PKyQQICko", Name = "Old")]
        public n5.Spread<T> Old;
        public SequenceChanged_EAvS1XXezCmL7nXpFVvQcX(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SequenceChanged_EAvS1XXezCmL7nXpFVvQcX(SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> other): base(other)
        {
            this.Old = other.Old;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Old", in Old));
        }

        internal SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> __WITH__(n5.Spread<T> Old)
        {
            n3.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Old != this.Old ? new SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T>(this)
                {Old = Old} : that_0;
            else
            {
                this.Old = Old;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 273535U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "BV2Obs1leaVL5nSQLQYPAJ", Name = "CountOccurance_BV2Obs1leaVL5nSQLQYPAJ")]
    [n2.SerializableAttribute]
    public class CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T> Create(n1.NodeContext Node_Context, n6.EqualityComparer<T> Comparer_In)
        {
            var instance = new CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Comparer_In);
        }

        [n4.CreateDefaultAttribute]
        public static n3.CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T> CreateDefault()
        {
            var instance = new CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T> Update<T2>(T2 Input_In, out n6.IReadOnlyDictionary<T, int> Output_Out)
            where T2 : n6.IEnumerable<T>
        {
            n6.Dictionary<T, int> __auto_0 = this.Dictionary;
            __auto_0.Clear();
            var i_3 = 0;
            foreach (var item_1 in Input_In)
            {
                var splicer_2 = item_1;
                var i_local_4 = i_3;
                var Result_7 = __auto_0.TryGetValue(key: splicer_2, value: out int Value_6);
                var Output_8 = n10.Integer32Extensions.Inc(input: Value_6);
                __auto_0[splicer_2] = Output_8;
                i_3++;
            }

            n6.IReadOnlyDictionary<T, int> Output_Out_9 = (n6.IReadOnlyDictionary<T, int>)__auto_0;
            Output_Out = Output_Out_9;
            return this;
        }

        public n3.CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T> __Create__(n1.NodeContext Node_Context, n6.EqualityComparer<T> Comparer_In)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n6.IEqualityComparer<T> Comparer_0 = (n6.IEqualityComparer<T>)Comparer_In;
            var Output_1 = new n6.Dictionary<T, int>(comparer: Comparer_0);
            n6.Dictionary<T, int> __auto_2 = Output_1;
            n3.CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T> that_3 = this;
            this.Dictionary = Output_1;
            return that_3;
        }

        public n3.CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T> __CreateDefault__()
        {
            n3.CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T> that_0 = this;
            this.Dictionary = n11._Operations_.CreateDefault<T, int>();
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

        [n1.ElementAttribute(TracingId = 273540U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "EJ03L15nYYhQX8P4WGdaSt", Name = "Dictionary")]
        public n6.Dictionary<T, int> Dictionary;
        public CountOccurance_BV2Obs1leaVL5nSQLQYPAJ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CountOccurance_BV2Obs1leaVL5nSQLQYPAJ(CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T> other): base(other)
        {
            this.Dictionary = other.Dictionary;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Dictionary", in Dictionary));
        }

        internal CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T> __WITH__(n6.Dictionary<T, int> Dictionary)
        {
            n3.CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Dictionary != this.Dictionary ? new CountOccurance_BV2Obs1leaVL5nSQLQYPAJ<T>(this)
                {Dictionary = Dictionary} : that_0;
            else
            {
                this.Dictionary = Dictionary;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void SpreadMax([n4.SerializedDefaultValueAttribute("-1", false)] int Accumulator_In, n15.ICollection Input_In, out int Output_Out)
        {
            var Count_0 = Input_In.Count;
            n13._Operations_.Max<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Accumulator_In, Input_2_In: Count_0, Output_Out: out int Output_1);
            int Input_2_2 = 0;
            var Result_3 = Accumulator_In == Input_2_2;
            int Input_2_4 = 0;
            var Result_5 = Count_0 == Input_2_4;
            var Output_6 = Result_3 || Result_5;
            int Input_2_7 = 0;
            n14._Operations_.Switch_Boolean<int>(Condition_In: Output_6, Input_In: Output_1, Input_2_In: Input_2_7, Output_Out: out int Output_8);
            Output_Out = Output_8;
            return;
        }

        public static void BinarySearch_KeySelector<T3, T, T2, AdM>(T3 Input_In, n2.Func<T, T2> Key_Selector_In, T2 Search_Key_In, out T Lower_Value_Out, out T Upper_value_Out, out T2 Lower_Key_Out, out T2 Upper_Key_Out, out int Lower_Index_Out, out int Upper_Index_Out, out bool Success_Out)
            where T3 : n6.IReadOnlyList<T> where AdM : struct, n18.IAdaptiveCreateDefault<T2>, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorLess<T2>, n19.IAdaptiveOperatorGreater<T2>, n19.IAdaptiveOperatorLessThan<T2>, n19.IAdaptiveOperatorGreaterThan<T2>
        {
            var w_0 = default(AdM);
            int __pad_E6ljHABzB4CPyUcxJmddcH_1 = __slot_E6ljHABzB4CPyUcxJmddcH;
            n6.IReadOnlyList<T> Input_2 = (n6.IReadOnlyList<T>)Input_In;
            n6.IReadOnlyList<T> Input_3 = (n6.IReadOnlyList<T>)Input_In;
            n6.IReadOnlyList<T> Input_4 = (n6.IReadOnlyList<T>)Input_In;
            n6.IReadOnlyList<T> Input_5 = (n6.IReadOnlyList<T>)Input_In;
            n16._Operations_.Count<T>(Input_In: Input_5, Output_Out: out n6.IReadOnlyList<T> Output_6, Count_Out: out int Count_7);
            var Output_8 = n10.Integer32Extensions.Dec(input: Count_7);
            int Input_2_9 = 0;
            var Result_10 = Count_7 > Input_2_9;
            w_0.CreateDefault(Output_Out: out T2 Output_11);
            w_0.CreateDefault(Output_Out: out T Output_12);
            bool __auto_13;
            int Upper_14;
            T Value_15;
            T2 Key_16;
            if (Result_10)
            {
                int __pad_ESwmBIYiu5UPNodaCtRpNt_17 = __slot_ESwmBIYiu5UPNodaCtRpNt;
                int Index_18 = 0;
                var Item_19 = Input_3[Index_18];
                n17._Operations_.Invoke<T, T2>(Input_In: Key_Selector_In, Arg_In: Item_19, Result_Out: out T2 Result_20);
                w_0.OperatorLess(Input_In: Search_Key_In, Input_2_In: Result_20, Result_Out: out bool Result_21);
                var Item_22 = Input_4[Output_8];
                n17._Operations_.Invoke<T, T2>(Input_In: Key_Selector_In, Arg_In: Item_22, Result_Out: out T2 Result_23);
                w_0.OperatorGreater(Input_In: Search_Key_In, Input_2_In: Result_23, Result_Out: out bool Result_24);
                var Result_25 = Count_7 < __pad_ESwmBIYiu5UPNodaCtRpNt_17;
                var Output_26 = Result_21 || Result_24;
                var Output_27 = Output_26 || Result_25;
                int __auto_28;
                T2 Key_29;
                T Value_30;
                if (Result_21)
                {
                    __auto_28 = 0;
                    Key_29 = Result_20;
                    Value_30 = Item_19;
                }
                else
                {
                    __auto_28 = Output_8;
                    Key_29 = Result_23;
                    Value_30 = Item_22;
                }

                Upper_14 = __auto_28;
                Key_16 = Key_29;
                Value_15 = Value_30;
                var Output_31 = !Output_27;
                __auto_13 = Output_31;
            }
            else
            {
                __auto_13 = Result_10;
                Upper_14 = Output_8;
                Value_15 = Output_12;
                Key_16 = Output_11;
            }

            int __auto_32;
            int Index_33;
            if (__auto_13)
            {
                int __pad_FU6bV7S3bZDMylgZ1CLmvg_34 = __slot_FU6bV7S3bZDMylgZ1CLmvg;
                int __pad_ExJt0Zvpv3xPLKdRrsohuE_35 = __slot_ExJt0Zvpv3xPLKdRrsohuE;
                var Output_36 = Upper_14 / __pad_FU6bV7S3bZDMylgZ1CLmvg_34;
                Index_33 = Output_36;
                __auto_32 = __pad_ExJt0Zvpv3xPLKdRrsohuE_35;
            }
            else
            {
                __auto_32 = 0;
                Index_33 = Upper_14;
            }

            n6.IReadOnlyList<T> Input_37 = (n6.IReadOnlyList<T>)Input_In;
            int accumulator_39 = __pad_E6ljHABzB4CPyUcxJmddcH_1;
            int accumulator_40 = Index_33;
            int accumulator_41 = Upper_14;
            T accumulator_42 = Value_15;
            T accumulator_43 = Value_15;
            T2 accumulator_44 = Key_16;
            T2 accumulator_45 = Key_16;
            var breakOutput_76 = false;
            for (var i_38 = 0; i_38 < __auto_32; i_38++)
            {
                var i_local_46 = i_38;
                var Item_47 = Input_2[accumulator_40];
                n17._Operations_.Invoke<T, T2>(Input_In: Key_Selector_In, Arg_In: Item_47, Result_Out: out T2 Result_48);
                w_0.OperatorLessThan(Input_In: Result_48, Input_2_In: Search_Key_In, Result_Out: out bool Result_49);
                bool Apply_50 = true;
                var Output_51 = accumulator_40;
                if (Apply_50)
                {
                    var Output_52 = n10.Integer32Extensions.Inc(input: accumulator_40);
                    Output_51 = Output_52;
                }

                var Item_53 = Input_37[Output_51];
                n17._Operations_.Invoke<T, T2>(Input_In: Key_Selector_In, Arg_In: Item_53, Result_Out: out T2 Result_54);
                w_0.OperatorGreaterThan(Input_In: Result_54, Input_2_In: Search_Key_In, Result_Out: out bool Result_55);
                var Output_56 = Result_49 && Result_55;
                var Output_57 = !Result_49;
                var Output_58 = !Output_56;
                int Lower_59;
                int __auto_60;
                int Upper_61;
                if (Output_58)
                {
                    int Lower_62;
                    int __auto_63;
                    int Upper_64;
                    if (Result_49)
                    {
                        int __pad_VLWhdpFAa1hOz2VWE8P6FT_65 = __slot_VLWhdpFAa1hOz2VWE8P6FT;
                        int __pad_Aez7tWh4maaNGo9wIkhJPC_66 = __slot_Aez7tWh4maaNGo9wIkhJPC;
                        var Output_67 = accumulator_40 + accumulator_41;
                        var Output_68 = Output_67 / __pad_VLWhdpFAa1hOz2VWE8P6FT_65;
                        var Output_69 = Output_68 + __pad_Aez7tWh4maaNGo9wIkhJPC_66;
                        __auto_63 = Output_69;
                        Lower_62 = accumulator_40;
                        Upper_64 = accumulator_41;
                    }
                    else
                    {
                        Lower_62 = accumulator_39;
                        __auto_63 = accumulator_40;
                        Upper_64 = accumulator_41;
                    }

                    int Lower_70;
                    int __auto_71;
                    int Upper_72;
                    if (Output_57)
                    {
                        int __pad_Ut33LdMYTimNyyTIzCXbNi_73 = __slot_Ut33LdMYTimNyyTIzCXbNi;
                        var Output_74 = Lower_62 + __auto_63;
                        Lower_70 = Lower_62;
                        var Output_75 = Output_74 / __pad_Ut33LdMYTimNyyTIzCXbNi_73;
                        __auto_71 = Output_75;
                        Upper_72 = __auto_63;
                    }
                    else
                    {
                        Lower_70 = Lower_62;
                        __auto_71 = __auto_63;
                        Upper_72 = Upper_64;
                    }

                    Lower_59 = Lower_70;
                    __auto_60 = __auto_71;
                    Upper_61 = Upper_72;
                }
                else
                {
                    Lower_59 = accumulator_39;
                    __auto_60 = accumulator_40;
                    Upper_61 = accumulator_41;
                }

                accumulator_39 = Lower_59;
                accumulator_40 = __auto_60;
                accumulator_41 = Upper_61;
                accumulator_42 = Item_47;
                accumulator_43 = Item_53;
                accumulator_44 = Result_48;
                accumulator_45 = Result_54;
                if (Output_56)
                {
                    breakOutput_76 = Output_56;
                    break;
                }
            }

            var Output_77 = n10.Integer32Extensions.Inc(input: accumulator_40);
            n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_77, Input_2_In: accumulator_41, Output_Out: out int Output_78);
            Lower_Value_Out = accumulator_42;
            Upper_value_Out = accumulator_43;
            Lower_Key_Out = accumulator_44;
            Upper_Key_Out = accumulator_45;
            Lower_Index_Out = accumulator_40;
            Upper_Index_Out = Output_78;
            Success_Out = breakOutput_76;
            return;
        }

        public static void BinarySearch<T2, T, AdM>(T2 Input_In, T Search_Key_In, out T Lower_Value_Out, out T Upper_value_Out, out int Lower_Index_Out, out int Upper_Index_Out, out bool Success_Out)
            where T2 : n6.IReadOnlyList<T> where AdM : struct, n19.IAdaptiveOperatorGreater<T>, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorGreaterThan<T>, n19.IAdaptiveOperatorLess<T>, n19.IAdaptiveOperatorLessThan<T>
        {
            var w_0 = default(AdM);
            int __pad_LpGRq3iumccLGaANaFDbUv_1 = __slot_LpGRq3iumccLGaANaFDbUv;
            n6.IReadOnlyList<T> Input_2 = (n6.IReadOnlyList<T>)Input_In;
            n6.IReadOnlyList<T> Input_3 = (n6.IReadOnlyList<T>)Input_In;
            n6.IReadOnlyList<T> Input_4 = (n6.IReadOnlyList<T>)Input_In;
            n6.IReadOnlyList<T> Input_5 = (n6.IReadOnlyList<T>)Input_In;
            n16._Operations_.Count<T>(Input_In: Input_5, Output_Out: out n6.IReadOnlyList<T> Output_6, Count_Out: out int Count_7);
            var Output_8 = n10.Integer32Extensions.Dec(input: Count_7);
            int Input_2_9 = 0;
            var Result_10 = Count_7 > Input_2_9;
            w_0.CreateDefault(Output_Out: out T Output_11);
            bool __auto_12;
            int Upper_13;
            T Key_14;
            if (Result_10)
            {
                int __pad_HZXH7m9TzXyNqJL5lBuPJy_15 = __slot_HZXH7m9TzXyNqJL5lBuPJy;
                int Index_16 = 0;
                var Item_17 = Input_3[Index_16];
                w_0.OperatorLess(Input_In: Search_Key_In, Input_2_In: Item_17, Result_Out: out bool Result_18);
                var Item_19 = Input_4[Output_8];
                w_0.OperatorGreater(Input_In: Search_Key_In, Input_2_In: Item_19, Result_Out: out bool Result_20);
                var Result_21 = Count_7 < __pad_HZXH7m9TzXyNqJL5lBuPJy_15;
                var Output_22 = Result_18 || Result_20;
                var Output_23 = Output_22 || Result_21;
                int Upper_24;
                T Key_25;
                if (Result_18)
                {
                    Upper_24 = 0;
                    Key_25 = Item_17;
                }
                else
                {
                    Upper_24 = Output_8;
                    Key_25 = Item_19;
                }

                Upper_13 = Upper_24;
                Key_14 = Key_25;
                var Output_26 = !Output_23;
                __auto_12 = Output_26;
            }
            else
            {
                __auto_12 = Result_10;
                Upper_13 = Output_8;
                Key_14 = Output_11;
            }

            int __auto_27;
            int Index_28;
            if (__auto_12)
            {
                int __pad_U4CcLS7rtkLMCV0sNUF7is_29 = __slot_U4CcLS7rtkLMCV0sNUF7is;
                int __pad_GxQFDF4adKROyQkppkNDLi_30 = __slot_GxQFDF4adKROyQkppkNDLi;
                var Output_31 = Upper_13 / __pad_U4CcLS7rtkLMCV0sNUF7is_29;
                Index_28 = Output_31;
                __auto_27 = __pad_GxQFDF4adKROyQkppkNDLi_30;
            }
            else
            {
                __auto_27 = 0;
                Index_28 = Upper_13;
            }

            n6.IReadOnlyList<T> Input_32 = (n6.IReadOnlyList<T>)Input_In;
            int accumulator_34 = __pad_LpGRq3iumccLGaANaFDbUv_1;
            int accumulator_35 = Index_28;
            int accumulator_36 = Upper_13;
            T accumulator_37 = Key_14;
            T accumulator_38 = Key_14;
            var breakOutput_67 = false;
            for (var i_33 = 0; i_33 < __auto_27; i_33++)
            {
                var i_local_39 = i_33;
                var Item_40 = Input_2[accumulator_35];
                w_0.OperatorLessThan(Input_In: Item_40, Input_2_In: Search_Key_In, Result_Out: out bool Result_41);
                bool Apply_42 = true;
                var Output_43 = accumulator_35;
                if (Apply_42)
                {
                    var Output_44 = n10.Integer32Extensions.Inc(input: accumulator_35);
                    Output_43 = Output_44;
                }

                var Item_45 = Input_32[Output_43];
                w_0.OperatorGreaterThan(Input_In: Item_45, Input_2_In: Search_Key_In, Result_Out: out bool Result_46);
                var Output_47 = Result_41 && Result_46;
                var Output_48 = !Result_41;
                var Output_49 = !Output_47;
                int Lower_50;
                int Index_51;
                int Upper_52;
                if (Output_49)
                {
                    int Lower_53;
                    int Index_54;
                    int Upper_55;
                    if (Result_41)
                    {
                        int __pad_SSnUmueykTPLl0Nw7ZrK8c_56 = __slot_SSnUmueykTPLl0Nw7ZrK8c;
                        int __pad_AgSL25BLxD0O79bG1xpZtQ_57 = __slot_AgSL25BLxD0O79bG1xpZtQ;
                        var Output_58 = accumulator_35 + accumulator_36;
                        var Output_59 = Output_58 / __pad_SSnUmueykTPLl0Nw7ZrK8c_56;
                        var Output_60 = Output_59 + __pad_AgSL25BLxD0O79bG1xpZtQ_57;
                        Index_54 = Output_60;
                        Lower_53 = accumulator_35;
                        Upper_55 = accumulator_36;
                    }
                    else
                    {
                        Lower_53 = accumulator_34;
                        Index_54 = accumulator_35;
                        Upper_55 = accumulator_36;
                    }

                    int Lower_61;
                    int Index_62;
                    int Upper_63;
                    if (Output_48)
                    {
                        int __pad_BdI6NcKudw9PBE65xqdpIe_64 = __slot_BdI6NcKudw9PBE65xqdpIe;
                        var Output_65 = Lower_53 + Index_54;
                        Lower_61 = Lower_53;
                        var Output_66 = Output_65 / __pad_BdI6NcKudw9PBE65xqdpIe_64;
                        Index_62 = Output_66;
                        Upper_63 = Index_54;
                    }
                    else
                    {
                        Lower_61 = Lower_53;
                        Index_62 = Index_54;
                        Upper_63 = Upper_55;
                    }

                    Lower_50 = Lower_61;
                    Index_51 = Index_62;
                    Upper_52 = Upper_63;
                }
                else
                {
                    Lower_50 = accumulator_34;
                    Index_51 = accumulator_35;
                    Upper_52 = accumulator_36;
                }

                accumulator_34 = Lower_50;
                accumulator_35 = Index_51;
                accumulator_36 = Upper_52;
                accumulator_37 = Item_40;
                accumulator_38 = Item_45;
                if (Output_47)
                {
                    breakOutput_67 = Output_47;
                    break;
                }
            }

            var Output_68 = n10.Integer32Extensions.Inc(input: accumulator_35);
            n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_68, Input_2_In: accumulator_36, Output_Out: out int Output_69);
            Lower_Value_Out = accumulator_37;
            Upper_value_Out = accumulator_38;
            Lower_Index_Out = accumulator_35;
            Upper_Index_Out = Output_69;
            Success_Out = breakOutput_67;
            return;
        }

        public static void BinarySearch_KeyValuePair_Lerp<T2, T, AdM>(T2 Input_In, float Search_Key_In, out T Value_Out, out float Position_Out, out T Lower_Value_Out, out T Upper_value_Out, out float Lower_Key_Out, out float Upper_Key_Out, out int Lower_Index_Out, out int Upper_Index_Out, out bool Success_Out)
            where T2 : n6.IReadOnlyList<n6.KeyValuePair<float, T>> where AdM : struct, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorGreater<float>, n19.IAdaptiveOperatorLess<float>, n19.IAdaptiveOperatorLessThan<float>, n19.IAdaptiveLerp<T>, n19.IAdaptiveOperatorGreaterThan<float>, n18.IAdaptiveCreateDefault<float>
        {
            var w_0 = default(AdM);
            float __pad_IxOnmN7NF35MHbsaN6FgRl_1 = __slot_IxOnmN7NF35MHbsaN6FgRl;
            n3._Operations_.BinarySearch_KeyValuePair<T2, float, T, AdM>(Input_In: Input_In, Search_Key_In: Search_Key_In, Lower_Value_Out: out T Lower_Value_2, Upper_value_Out: out T Upper_value_3, Lower_Key_Out: out float Lower_Key_4, Upper_Key_Out: out float Upper_Key_5, Lower_Index_Out: out int Lower_Index_6, Upper_Index_Out: out int Upper_Index_7, Success_Out: out bool Success_8);
            T __auto_9;
            float __auto_10;
            if (Success_8)
            {
                float Output_Minimum_11 = 0F;
                n13._Operations_.Map<float, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Search_Key_In, Input_Minimum_In: Lower_Key_4, Input_Maximum_In: Upper_Key_5, Output_Minimum_In: Output_Minimum_11, Output_Maximum_In: __pad_IxOnmN7NF35MHbsaN6FgRl_1, Output_Out: out float Output_12);
                w_0.Lerp(Input_In: Lower_Value_2, Input_2_In: Upper_value_3, Scalar_In: Output_12, Output_Out: out T Output_13);
                __auto_9 = Output_13;
                __auto_10 = Output_12;
            }
            else
            {
                __auto_9 = Lower_Value_2;
                __auto_10 = 0F;
            }

            Value_Out = __auto_9;
            Position_Out = __auto_10;
            Lower_Value_Out = Lower_Value_2;
            Upper_value_Out = Upper_value_3;
            Lower_Key_Out = Lower_Key_4;
            Upper_Key_Out = Upper_Key_5;
            Lower_Index_Out = Lower_Index_6;
            Upper_Index_Out = Upper_Index_7;
            Success_Out = Success_8;
            return;
        }

        public static void BinarySearch_KeySelector_Lerp<T2, T, AdM>(T2 Input_In, n2.Func<T, float> Key_Selector_In, float Search_Key_In, out T Value_Out, out float Position_Out, out T Lower_Value_Out, out T Upper_value_Out, out float Lower_Key_Out, out float Upper_Key_Out, out int Lower_Index_Out, out int Upper_Index_Out, out bool Success_Out)
            where T2 : n6.IReadOnlyList<T> where AdM : struct, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorGreater<float>, n19.IAdaptiveOperatorLess<float>, n19.IAdaptiveOperatorLessThan<float>, n19.IAdaptiveLerp<T>, n19.IAdaptiveOperatorGreaterThan<float>, n18.IAdaptiveCreateDefault<float>
        {
            var w_0 = default(AdM);
            float __pad_K2uiaZkYaEFQHtCoOEuv40_1 = __slot_K2uiaZkYaEFQHtCoOEuv40;
            n3._Operations_.BinarySearch_KeySelector<T2, T, float, AdM>(Input_In: Input_In, Key_Selector_In: Key_Selector_In, Search_Key_In: Search_Key_In, Lower_Value_Out: out T Lower_Value_2, Upper_value_Out: out T Upper_value_3, Lower_Key_Out: out float Lower_Key_4, Upper_Key_Out: out float Upper_Key_5, Lower_Index_Out: out int Lower_Index_6, Upper_Index_Out: out int Upper_Index_7, Success_Out: out bool Success_8);
            T __auto_9;
            float __auto_10;
            if (Success_8)
            {
                float Output_Minimum_11 = 0F;
                n13._Operations_.Map<float, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Search_Key_In, Input_Minimum_In: Lower_Key_4, Input_Maximum_In: Upper_Key_5, Output_Minimum_In: Output_Minimum_11, Output_Maximum_In: __pad_K2uiaZkYaEFQHtCoOEuv40_1, Output_Out: out float Output_12);
                w_0.Lerp(Input_In: Lower_Value_2, Input_2_In: Upper_value_3, Scalar_In: Output_12, Output_Out: out T Output_13);
                __auto_9 = Output_13;
                __auto_10 = Output_12;
            }
            else
            {
                __auto_9 = Lower_Value_2;
                __auto_10 = 0F;
            }

            Value_Out = __auto_9;
            Position_Out = __auto_10;
            Lower_Value_Out = Lower_Value_2;
            Upper_value_Out = Upper_value_3;
            Lower_Key_Out = Lower_Key_4;
            Upper_Key_Out = Upper_Key_5;
            Lower_Index_Out = Lower_Index_6;
            Upper_Index_Out = Upper_Index_7;
            Success_Out = Success_8;
            return;
        }

        public static void BinarySearch_KeyValuePair<T3, T2, T, AdM>(T3 Input_In, T2 Search_Key_In, out T Lower_Value_Out, out T Upper_value_Out, out T2 Lower_Key_Out, out T2 Upper_Key_Out, out int Lower_Index_Out, out int Upper_Index_Out, out bool Success_Out)
            where T3 : n6.IReadOnlyList<n6.KeyValuePair<T2, T>> where AdM : struct, n18.IAdaptiveCreateDefault<T2>, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorLess<T2>, n19.IAdaptiveOperatorGreater<T2>, n19.IAdaptiveOperatorLessThan<T2>, n19.IAdaptiveOperatorGreaterThan<T2>
        {
            var w_0 = default(AdM);
            int __pad_M1apjjwl88XMkzYjhJBjzk_1 = __slot_M1apjjwl88XMkzYjhJBjzk;
            n6.IReadOnlyList<n6.KeyValuePair<T2, T>> Input_2 = (n6.IReadOnlyList<n6.KeyValuePair<T2, T>>)Input_In;
            n6.IReadOnlyList<n6.KeyValuePair<T2, T>> Input_3 = (n6.IReadOnlyList<n6.KeyValuePair<T2, T>>)Input_In;
            n6.IReadOnlyList<n6.KeyValuePair<T2, T>> Input_4 = (n6.IReadOnlyList<n6.KeyValuePair<T2, T>>)Input_In;
            n6.IReadOnlyList<n6.KeyValuePair<T2, T>> Input_5 = (n6.IReadOnlyList<n6.KeyValuePair<T2, T>>)Input_In;
            n16._Operations_.Count<n6.KeyValuePair<T2, T>>(Input_In: Input_5, Output_Out: out n6.IReadOnlyList<n6.KeyValuePair<T2, T>> Output_6, Count_Out: out int Count_7);
            var Output_8 = n10.Integer32Extensions.Dec(input: Count_7);
            int Input_2_9 = 0;
            var Result_10 = Count_7 > Input_2_9;
            w_0.CreateDefault(Output_Out: out T2 Output_11);
            var Output_12 = n20._Operations_.CreateDefault<T2, T, AdM>();
            bool __auto_13;
            int Upper_14;
            n6.KeyValuePair<T2, T> Value_15;
            T2 Key_16;
            if (Result_10)
            {
                int __pad_SiVEzp5XqZePhsHaLNxM3g_17 = __slot_SiVEzp5XqZePhsHaLNxM3g;
                int Index_18 = 0;
                var Item_19 = Input_3[Index_18];
                var Key_20 = Item_19.Key;
                w_0.OperatorLess(Input_In: Search_Key_In, Input_2_In: Key_20, Result_Out: out bool Result_21);
                var Item_22 = Input_4[Output_8];
                var Key_23 = Item_22.Key;
                w_0.OperatorGreater(Input_In: Search_Key_In, Input_2_In: Key_23, Result_Out: out bool Result_24);
                var Result_25 = Count_7 < __pad_SiVEzp5XqZePhsHaLNxM3g_17;
                var Output_26 = Result_21 || Result_24;
                var Output_27 = Output_26 || Result_25;
                int __auto_28;
                T2 Key_29;
                n6.KeyValuePair<T2, T> Value_30;
                if (Result_21)
                {
                    __auto_28 = 0;
                    Key_29 = Key_20;
                    Value_30 = Item_19;
                }
                else
                {
                    __auto_28 = Output_8;
                    Key_29 = Key_23;
                    Value_30 = Item_22;
                }

                Upper_14 = __auto_28;
                Key_16 = Key_29;
                Value_15 = Value_30;
                var Output_31 = !Output_27;
                __auto_13 = Output_31;
            }
            else
            {
                __auto_13 = Result_10;
                Upper_14 = Output_8;
                Value_15 = Output_12;
                Key_16 = Output_11;
            }

            int __auto_32;
            int Index_33;
            if (__auto_13)
            {
                int __pad_BCN8L2TnkXoL4xg42yuf7d_34 = __slot_BCN8L2TnkXoL4xg42yuf7d;
                int __pad_JdKYfBdhD9KMsisPRu2S9p_35 = __slot_JdKYfBdhD9KMsisPRu2S9p;
                var Output_36 = Upper_14 / __pad_BCN8L2TnkXoL4xg42yuf7d_34;
                Index_33 = Output_36;
                __auto_32 = __pad_JdKYfBdhD9KMsisPRu2S9p_35;
            }
            else
            {
                __auto_32 = 0;
                Index_33 = Upper_14;
            }

            n6.IReadOnlyList<n6.KeyValuePair<T2, T>> Input_37 = (n6.IReadOnlyList<n6.KeyValuePair<T2, T>>)Input_In;
            int accumulator_39 = __pad_M1apjjwl88XMkzYjhJBjzk_1;
            int accumulator_40 = Index_33;
            int accumulator_41 = Upper_14;
            n6.KeyValuePair<T2, T> accumulator_42 = Value_15;
            n6.KeyValuePair<T2, T> accumulator_43 = Value_15;
            T2 accumulator_44 = Key_16;
            T2 accumulator_45 = Key_16;
            var breakOutput_76 = false;
            for (var i_38 = 0; i_38 < __auto_32; i_38++)
            {
                var i_local_46 = i_38;
                var Item_47 = Input_2[accumulator_40];
                var Key_48 = Item_47.Key;
                w_0.OperatorLessThan(Input_In: Key_48, Input_2_In: Search_Key_In, Result_Out: out bool Result_49);
                bool Apply_50 = true;
                var Output_51 = accumulator_40;
                if (Apply_50)
                {
                    var Output_52 = n10.Integer32Extensions.Inc(input: accumulator_40);
                    Output_51 = Output_52;
                }

                var Item_53 = Input_37[Output_51];
                var Key_54 = Item_53.Key;
                w_0.OperatorGreaterThan(Input_In: Key_54, Input_2_In: Search_Key_In, Result_Out: out bool Result_55);
                var Output_56 = Result_49 && Result_55;
                var Output_57 = !Result_49;
                var Output_58 = !Output_56;
                int Lower_59;
                int __auto_60;
                int Upper_61;
                if (Output_58)
                {
                    int Lower_62;
                    int __auto_63;
                    int Upper_64;
                    if (Result_49)
                    {
                        int __pad_HHyaLTZ3pBnNulcjeSgPSA_65 = __slot_HHyaLTZ3pBnNulcjeSgPSA;
                        int __pad_JEBQqxHkKSPPwxtfWYciIo_66 = __slot_JEBQqxHkKSPPwxtfWYciIo;
                        var Output_67 = accumulator_40 + accumulator_41;
                        var Output_68 = Output_67 / __pad_HHyaLTZ3pBnNulcjeSgPSA_65;
                        var Output_69 = Output_68 + __pad_JEBQqxHkKSPPwxtfWYciIo_66;
                        __auto_63 = Output_69;
                        Lower_62 = accumulator_40;
                        Upper_64 = accumulator_41;
                    }
                    else
                    {
                        Lower_62 = accumulator_39;
                        __auto_63 = accumulator_40;
                        Upper_64 = accumulator_41;
                    }

                    int Lower_70;
                    int __auto_71;
                    int Upper_72;
                    if (Output_57)
                    {
                        int __pad_EQkNSQ8sO8rOEbBF5qq5FQ_73 = __slot_EQkNSQ8sO8rOEbBF5qq5FQ;
                        var Output_74 = Lower_62 + __auto_63;
                        Lower_70 = Lower_62;
                        var Output_75 = Output_74 / __pad_EQkNSQ8sO8rOEbBF5qq5FQ_73;
                        __auto_71 = Output_75;
                        Upper_72 = __auto_63;
                    }
                    else
                    {
                        Lower_70 = Lower_62;
                        __auto_71 = __auto_63;
                        Upper_72 = Upper_64;
                    }

                    Lower_59 = Lower_70;
                    __auto_60 = __auto_71;
                    Upper_61 = Upper_72;
                }
                else
                {
                    Lower_59 = accumulator_39;
                    __auto_60 = accumulator_40;
                    Upper_61 = accumulator_41;
                }

                accumulator_39 = Lower_59;
                accumulator_40 = __auto_60;
                accumulator_41 = Upper_61;
                accumulator_42 = Item_47;
                accumulator_43 = Item_53;
                accumulator_44 = Key_48;
                accumulator_45 = Key_54;
                if (Output_56)
                {
                    breakOutput_76 = Output_56;
                    break;
                }
            }

            var Value_77 = accumulator_42.Value;
            var Output_78 = n10.Integer32Extensions.Inc(input: accumulator_40);
            n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_78, Input_2_In: accumulator_41, Output_Out: out int Output_79);
            var Value_80 = accumulator_43.Value;
            Lower_Value_Out = Value_77;
            Upper_value_Out = Value_80;
            Lower_Key_Out = accumulator_44;
            Upper_Key_Out = accumulator_45;
            Lower_Index_Out = accumulator_40;
            Upper_Index_Out = Output_79;
            Success_Out = breakOutput_76;
            return;
        }

        public static void IndexOf_KeySelector<T3, T2, T, AdM>(T3 Input_In, n2.Func<T2, T> Key_Selector_In, T Key_In, out int Index_Out, out bool Success_Out)
            where T3 : n6.IEnumerable<T2> where AdM : struct, n19.IAdaptiveOperatorEquals<T>
        {
            var w_0 = default(AdM);
            var accumulator_7 = 0;
            var breakOutput_8 = false;
            var i_3 = 0;
            foreach (var item_1 in Input_In)
            {
                var splicer_2 = item_1;
                var i_local_4 = i_3;
                n17._Operations_.Invoke<T2, T>(Input_In: Key_Selector_In, Arg_In: splicer_2, Result_Out: out T Result_5);
                w_0.OperatorEquals(Input_In: Result_5, Input_2_In: Key_In, Result_Out: out bool Result_6);
                accumulator_7 = i_local_4;
                if (Result_6)
                {
                    breakOutput_8 = Result_6;
                    break;
                }

                i_3++;
            }

            int Input_9 = -1;
            n14._Operations_.Switch_Boolean<int>(Condition_In: breakOutput_8, Input_In: Input_9, Input_2_In: accumulator_7, Output_Out: out int Output_10);
            Index_Out = Output_10;
            Success_Out = breakOutput_8;
            return;
        }

        public static void Search_KeySelector<T3, T, T2, AdM>(T3 Input_In, T Default_Value_In, n2.Func<T, T2> Key_Selector_In, T2 Key_In, out T Result_Out, out int Index_Out, out bool Success_Out)
            where T3 : n6.IReadOnlyList<T> where AdM : struct, n19.IAdaptiveOperatorEquals<T2>
        {
            var w_0 = default(AdM);
            n3._Operations_.IndexOf_KeySelector<T3, T, T2, AdM>(Input_In: Input_In, Key_Selector_In: Key_Selector_In, Key_In: Key_In, Index_Out: out int Index_1, Success_Out: out bool Success_2);
            n6.IReadOnlyList<T> Input_3 = (n6.IReadOnlyList<T>)Input_In;
            T __auto_4;
            if (Success_2)
            {
                var Item_5 = Input_3[Index_1];
                __auto_4 = Item_5;
            }
            else
            {
                __auto_4 = Default_Value_In;
            }

            Result_Out = __auto_4;
            Index_Out = Index_1;
            Success_Out = Success_2;
            return;
        }

        public static void Search<T2, T, AdM>(T2 Input_In, T Default_Value_In, T Item_In, out T Result_Out, out int Index_Out, out bool Success_Out)
            where T2 : n6.IReadOnlyList<T> where AdM : struct, n19.IAdaptiveOperatorEquals<T>
        {
            var w_0 = default(AdM);
            n6.IReadOnlyList<T> Input_1 = (n6.IReadOnlyList<T>)Input_In;
            var accumulator_7 = 0;
            var breakOutput_8 = false;
            var i_4 = 0;
            foreach (var item_2 in Input_In)
            {
                var splicer_3 = item_2;
                var i_local_5 = i_4;
                w_0.OperatorEquals(Input_In: splicer_3, Input_2_In: Item_In, Result_Out: out bool Result_6);
                accumulator_7 = i_local_5;
                if (Result_6)
                {
                    breakOutput_8 = Result_6;
                    break;
                }

                i_4++;
            }

            int Input_9 = -1;
            n14._Operations_.Switch_Boolean<int>(Condition_In: breakOutput_8, Input_In: Input_9, Input_2_In: accumulator_7, Output_Out: out int Output_10);
            T __auto_11;
            if (breakOutput_8)
            {
                var Item_12 = Input_1[Output_10];
                __auto_11 = Item_12;
            }
            else
            {
                __auto_11 = Default_Value_In;
            }

            Result_Out = __auto_11;
            Index_Out = Output_10;
            Success_Out = breakOutput_8;
            return;
        }

        [n1.ElementAttribute(TracingId = 260896U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "E6ljHABzB4CPyUcxJmddcH", Name = "__slot_E6ljHABzB4CPyUcxJmddcH")]
        public static int __slot_E6ljHABzB4CPyUcxJmddcH = 0;
        [n1.ElementAttribute(TracingId = 261048U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "ESwmBIYiu5UPNodaCtRpNt", Name = "__slot_ESwmBIYiu5UPNodaCtRpNt")]
        public static int __slot_ESwmBIYiu5UPNodaCtRpNt = 2;
        [n1.ElementAttribute(TracingId = 261131U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "FU6bV7S3bZDMylgZ1CLmvg", Name = "__slot_FU6bV7S3bZDMylgZ1CLmvg")]
        public static int __slot_FU6bV7S3bZDMylgZ1CLmvg = 2;
        [n1.ElementAttribute(TracingId = 261132U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "ExJt0Zvpv3xPLKdRrsohuE", Name = "__slot_ExJt0Zvpv3xPLKdRrsohuE")]
        public static int __slot_ExJt0Zvpv3xPLKdRrsohuE = 64;
        [n1.ElementAttribute(TracingId = 260826U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "VLWhdpFAa1hOz2VWE8P6FT", Name = "__slot_VLWhdpFAa1hOz2VWE8P6FT")]
        public static int __slot_VLWhdpFAa1hOz2VWE8P6FT = 2;
        [n1.ElementAttribute(TracingId = 260831U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Aez7tWh4maaNGo9wIkhJPC", Name = "__slot_Aez7tWh4maaNGo9wIkhJPC")]
        public static int __slot_Aez7tWh4maaNGo9wIkhJPC = 0;
        [n1.ElementAttribute(TracingId = 260851U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Ut33LdMYTimNyyTIzCXbNi", Name = "__slot_Ut33LdMYTimNyyTIzCXbNi")]
        public static int __slot_Ut33LdMYTimNyyTIzCXbNi = 2;
        [n1.ElementAttribute(TracingId = 261279U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "LpGRq3iumccLGaANaFDbUv", Name = "__slot_LpGRq3iumccLGaANaFDbUv")]
        public static int __slot_LpGRq3iumccLGaANaFDbUv = 0;
        [n1.ElementAttribute(TracingId = 261407U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "HZXH7m9TzXyNqJL5lBuPJy", Name = "__slot_HZXH7m9TzXyNqJL5lBuPJy")]
        public static int __slot_HZXH7m9TzXyNqJL5lBuPJy = 2;
        [n1.ElementAttribute(TracingId = 261473U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "U4CcLS7rtkLMCV0sNUF7is", Name = "__slot_U4CcLS7rtkLMCV0sNUF7is")]
        public static int __slot_U4CcLS7rtkLMCV0sNUF7is = 2;
        [n1.ElementAttribute(TracingId = 261474U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "GxQFDF4adKROyQkppkNDLi", Name = "__slot_GxQFDF4adKROyQkppkNDLi")]
        public static int __slot_GxQFDF4adKROyQkppkNDLi = 64;
        [n1.ElementAttribute(TracingId = 261219U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "SSnUmueykTPLl0Nw7ZrK8c", Name = "__slot_SSnUmueykTPLl0Nw7ZrK8c")]
        public static int __slot_SSnUmueykTPLl0Nw7ZrK8c = 2;
        [n1.ElementAttribute(TracingId = 261224U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "AgSL25BLxD0O79bG1xpZtQ", Name = "__slot_AgSL25BLxD0O79bG1xpZtQ")]
        public static int __slot_AgSL25BLxD0O79bG1xpZtQ = 0;
        [n1.ElementAttribute(TracingId = 261244U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "BdI6NcKudw9PBE65xqdpIe", Name = "__slot_BdI6NcKudw9PBE65xqdpIe")]
        public static int __slot_BdI6NcKudw9PBE65xqdpIe = 2;
        [n1.ElementAttribute(TracingId = 261540U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "IxOnmN7NF35MHbsaN6FgRl", Name = "__slot_IxOnmN7NF35MHbsaN6FgRl")]
        public static float __slot_IxOnmN7NF35MHbsaN6FgRl = 1F;
        [n1.ElementAttribute(TracingId = 261618U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "K2uiaZkYaEFQHtCoOEuv40", Name = "__slot_K2uiaZkYaEFQHtCoOEuv40")]
        public static float __slot_K2uiaZkYaEFQHtCoOEuv40 = 1F;
        [n1.ElementAttribute(TracingId = 261792U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "M1apjjwl88XMkzYjhJBjzk", Name = "__slot_M1apjjwl88XMkzYjhJBjzk")]
        public static int __slot_M1apjjwl88XMkzYjhJBjzk = 0;
        [n1.ElementAttribute(TracingId = 261946U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "SiVEzp5XqZePhsHaLNxM3g", Name = "__slot_SiVEzp5XqZePhsHaLNxM3g")]
        public static int __slot_SiVEzp5XqZePhsHaLNxM3g = 2;
        [n1.ElementAttribute(TracingId = 262034U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "BCN8L2TnkXoL4xg42yuf7d", Name = "__slot_BCN8L2TnkXoL4xg42yuf7d")]
        public static int __slot_BCN8L2TnkXoL4xg42yuf7d = 2;
        [n1.ElementAttribute(TracingId = 262035U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "JdKYfBdhD9KMsisPRu2S9p", Name = "__slot_JdKYfBdhD9KMsisPRu2S9p")]
        public static int __slot_JdKYfBdhD9KMsisPRu2S9p = 64;
        [n1.ElementAttribute(TracingId = 261724U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "HHyaLTZ3pBnNulcjeSgPSA", Name = "__slot_HHyaLTZ3pBnNulcjeSgPSA")]
        public static int __slot_HHyaLTZ3pBnNulcjeSgPSA = 2;
        [n1.ElementAttribute(TracingId = 261729U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "JEBQqxHkKSPPwxtfWYciIo", Name = "__slot_JEBQqxHkKSPPwxtfWYciIo")]
        public static int __slot_JEBQqxHkKSPPwxtfWYciIo = 0;
        [n1.ElementAttribute(TracingId = 261749U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "EQkNSQ8sO8rOEbBF5qq5FQ", Name = "__slot_EQkNSQ8sO8rOEbBF5qq5FQ")]
        public static int __slot_EQkNSQ8sO8rOEbBF5qq5FQ = 2;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Dictionary
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n21.ImmutableDictionary<T, T2> CreateDefault<T, T2>()
        {
            var Empty_0 = n21.ImmutableDictionary<T, T2>.Empty;
            return Empty_0;
        }

        public static void Create_KeyComparer<T, T2>(n6.IEqualityComparer<T> Key_Comparer_In, out n21.ImmutableDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.Create<T, T2>(keyComparer: Key_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void Create_KeyComparer_ValueComparer<T, T2>(n6.IEqualityComparer<T> Key_Comparer_In, n6.IEqualityComparer<T2> Value_Comparer_In, out n21.ImmutableDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.Create<T, T2>(keyComparer: Key_Comparer_In, valueComparer: Value_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n21.ImmutableDictionary<T2, T> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.ToImmutableDictionary<T, T2>(source: Input_In, keySelector: Key_Selector_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence_ElementSelector<T, T2, T3>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, n2.Func<T, T3> Element_Selector_In, out n21.ImmutableDictionary<T2, T3> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.ToImmutableDictionary<T, T2, T3>(source: Input_In, keySelector: Key_Selector_In, elementSelector: Element_Selector_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence_KeyValuePair<T, T2>(n6.IEnumerable<n6.KeyValuePair<T, T2>> Input_In, out n21.ImmutableDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.ToImmutableDictionary<T, T2>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T, T2>(n1.NodeContext Node_Context, out n21.ImmutableDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.Create<T, T2>();
            Result_Out = Result_0;
            return;
        }

        public static void Contains<T2, T>(n21.IImmutableDictionary<T2, T> Input_In, T2 Key_In, T Value_In, out bool Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.Contains<T2, T>(map: Input_In, key: Key_In, value: Value_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRange<T, T2>(n6.IEnumerable<n6.KeyValuePair<T, T2>> Items_In, out n21.ImmutableDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.CreateRange<T, T2>(items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRange<T, T2>(n6.IEqualityComparer<T> Key_Comparer_In, n6.IEnumerable<n6.KeyValuePair<T, T2>> Items_In, out n21.ImmutableDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.CreateRange<T, T2>(keyComparer: Key_Comparer_In, items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRange<T, T2>(n6.IEqualityComparer<T> Key_Comparer_In, n6.IEqualityComparer<T2> Value_Comparer_In, n6.IEnumerable<n6.KeyValuePair<T, T2>> Items_In, out n21.ImmutableDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.CreateRange<T, T2>(keyComparer: Key_Comparer_In, valueComparer: Value_Comparer_In, items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void GetValueOrDefault<T2, T>(n21.IImmutableDictionary<T2, T> Input_In, T2 Key_In, out T Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.GetValueOrDefault<T2, T>(dictionary: Input_In, key: Key_In);
            Result_Out = Result_0;
            return;
        }

        public static void GetValueOrDefault<T2, T>(n21.IImmutableDictionary<T2, T> Input_In, T2 Key_In, T Default_Value_In, out T Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.GetValueOrDefault<T2, T>(dictionary: Input_In, key: Key_In, defaultValue: Default_Value_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2>(n6.IEnumerable<n6.KeyValuePair<T, T2>> Input_In, n6.IEqualityComparer<T> Key_Comparer_In, out n21.ImmutableDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.ToImmutableDictionary<T, T2>(source: Input_In, keyComparer: Key_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, n6.IEqualityComparer<T2> Key_Comparer_In, out n21.ImmutableDictionary<T2, T> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.ToImmutableDictionary<T, T2>(source: Input_In, keySelector: Key_Selector_In, keyComparer: Key_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2>(n6.IEnumerable<n6.KeyValuePair<T, T2>> Input_In, n6.IEqualityComparer<T> Key_Comparer_In, n6.IEqualityComparer<T2> Value_Comparer_In, out n21.ImmutableDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.ToImmutableDictionary<T, T2>(source: Input_In, keyComparer: Key_Comparer_In, valueComparer: Value_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2, T3>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, n2.Func<T, T3> Element_Selector_In, n6.IEqualityComparer<T2> Key_Comparer_In, out n21.ImmutableDictionary<T2, T3> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.ToImmutableDictionary<T, T2, T3>(source: Input_In, keySelector: Key_Selector_In, elementSelector: Element_Selector_In, keyComparer: Key_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2, T3>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, n2.Func<T, T3> Element_Selector_In, n6.IEqualityComparer<T2> Key_Comparer_In, n6.IEqualityComparer<T3> Value_Comparer_In, out n21.ImmutableDictionary<T2, T3> Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.ToImmutableDictionary<T, T2, T3>(source: Input_In, keySelector: Key_Selector_In, elementSelector: Element_Selector_In, keyComparer: Key_Comparer_In, valueComparer: Value_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void Cons<T>(n21.ImmutableDictionary<string, T> Input_In, out n21.ImmutableDictionary<string, T> Output_Out)
        {
            Output_Out = Input_In;
            return;
        }

        public static void Decons<T>(n21.ImmutableDictionary<string, T> Input_In, out n21.ImmutableDictionary<string, T> Output_Out)
        {
            Output_Out = Input_In;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.HashSet
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n21.ImmutableHashSet<T> CreateDefault<T>()
        {
            var Empty_0 = n21.ImmutableHashSet<T>.Empty;
            return Empty_0;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, out n21.ImmutableHashSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.Create<T>();
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, T[] Items_In, out n21.ImmutableHashSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.Create<T>(items: Items_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, n6.IEqualityComparer<T> Equality_Comparer_In, out n21.ImmutableHashSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.Create<T>(equalityComparer: Equality_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromValue<T>(T Input_In, out n21.ImmutableHashSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.Create<T>(item: Input_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, n6.IEqualityComparer<T> Equality_Comparer_In, T[] Items_In, out n21.ImmutableHashSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.Create<T>(equalityComparer: Equality_Comparer_In, items: Items_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, n6.IEqualityComparer<T> Equality_Comparer_In, T Item_In, out n21.ImmutableHashSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.Create<T>(equalityComparer: Equality_Comparer_In, item: Item_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateBuilder<T>(out n21.ImmutableHashSet<T>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.CreateBuilder<T>();
            Result_Out = Result_0;
            return;
        }

        public static void CreateBuilder<T>(n6.IEqualityComparer<T> Equality_Comparer_In, out n21.ImmutableHashSet<T>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.CreateBuilder<T>(equalityComparer: Equality_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRange<T>(n6.IEnumerable<T> Items_In, out n21.ImmutableHashSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.CreateRange<T>(items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRange<T>(n6.IEqualityComparer<T> Equality_Comparer_In, n6.IEnumerable<T> Items_In, out n21.ImmutableHashSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.CreateRange<T>(equalityComparer: Equality_Comparer_In, items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T>(n6.IEnumerable<T> Input_In, out n21.ImmutableHashSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.ToImmutableHashSet<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T>(n6.IEnumerable<T> Input_In, n6.IEqualityComparer<T> Equality_Comparer_In, out n21.ImmutableHashSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.ToImmutableHashSet<T>(source: Input_In, equalityComparer: Equality_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, T Item_In, out n21.ImmutableHashSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.Create<T>(item: Item_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Interfaces.IDictionary.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n21.ImmutableDictionary<T, T2> CreateDefault<T, T2>()
        {
            var Empty_0 = n21.ImmutableDictionary<T, T2>.Empty;
            return Empty_0;
        }
    }
}

namespace _VL_Collections_.Collections.Interfaces.Sequence_NonGeneric.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n2.Object[] CreateDefault()
        {
            var Result_0 = n2.Array.Empty<n2.Object>();
            n2.Object[] __pad_Hn4KpQuGLp6OpAbyQT97Cn_1 = Result_0;
            return Result_0;
        }
    }
}

namespace _VL_Collections_.Collections.Interfaces.ICollection_NonGeneric.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n5.Spread<n2.Object> CreateDefault()
        {
            n7._Operations_.Empty<n2.Object>(Empty_Out: out n5.Spread<n2.Object> Empty_0);
            return Empty_0;
        }
    }
}

namespace _VL_Collections_.Collections.Interfaces.IMutableList.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.List<T> CreateDefault<T>()
        {
            var Output_0 = n22._Operations_.CreateDefault<T>();
            return Output_0;
        }

        public static void SetSlice<T2, T>(T2 Input_In, T Value_In, int Index_In, out T2 Output_Out)
            where T2 : n6.IList<T>
        {
            var Output_0 = n23.CollectionNodes.SetSlice<T2, T>(input: Input_In, value: Value_In, index: Index_In);
            Output_Out = Output_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Interfaces.IMutableDictionary.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.Dictionary<T, T2> CreateDefault<T, T2>()
        {
            int __pad_PR8tDVT42iqP13w5t9tW6J_0 = __slot_PR8tDVT42iqP13w5t9tW6J;
            var Output_1 = new n6.Dictionary<T, T2>(capacity: __pad_PR8tDVT42iqP13w5t9tW6J_0);
            return Output_1;
        }

        [n1.ElementAttribute(TracingId = 262129U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "PR8tDVT42iqP13w5t9tW6J", Name = "__slot_PR8tDVT42iqP13w5t9tW6J")]
        public static int __slot_PR8tDVT42iqP13w5t9tW6J = 0;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Interfaces.IReadOnlyDictionary.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n21.ImmutableDictionary<T, T2> CreateDefault<T, T2>()
        {
            var Empty_0 = n21.ImmutableDictionary<T, T2>.Empty;
            return Empty_0;
        }
    }
}

namespace _VL_Collections_.Collections.Interfaces.ICollection.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.List<T> CreateDefault<T>()
        {
            int __pad_RxPBFMeiU1OPgnWCH7002p_0 = __slot_RxPBFMeiU1OPgnWCH7002p;
            var Output_1 = new n6.List<T>(capacity: __pad_RxPBFMeiU1OPgnWCH7002p_0);
            return Output_1;
        }

        [n1.ElementAttribute(TracingId = 262152U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "RxPBFMeiU1OPgnWCH7002p", Name = "__slot_RxPBFMeiU1OPgnWCH7002p")]
        public static int __slot_RxPBFMeiU1OPgnWCH7002p = 0;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Interfaces.IReadOnlyCollection.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n5.Spread<T> CreateDefault<T>()
        {
            n7._Operations_.Empty<T>(Empty_Out: out n5.Spread<T> Empty_0);
            return Empty_0;
        }
    }
}

namespace _VL_Collections_.Collections.Builder.SpreadBuilder.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Add<T>(n5.SpreadBuilder<T> Input_In, T Item_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In.Add(item: Item_In);
            Output_Out = Input_In;
            return;
        }

        public static void AddRange<T>(n5.SpreadBuilder<T> Input_In, n6.IEnumerable<T> Items_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In.AddRange(items: Items_In);
            Output_Out = Input_In;
            return;
        }

        public static void AddRange_Array<T>(n5.SpreadBuilder<T> Input_In, T[] Array_In, int Count_In, int Array_Index_In, bool Reverse_Order_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In.AddRangeArray(array: Array_In, count: Count_In, arrayIndex: Array_Index_In, reverseOrder: Reverse_Order_In);
            Output_Out = Input_In;
            return;
        }

        public static void Clear<T>(n5.SpreadBuilder<T> Input_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In.Clear();
            Output_Out = Input_In;
            return;
        }

        public static void Contains<T>(n5.SpreadBuilder<T> Input_In, T Item_In, out n5.SpreadBuilder<T> Output_Out, out bool Result_Out)
        {
            var Result_0 = Input_In.Contains(item: Item_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void CopyTo<T>(n5.SpreadBuilder<T> Input_In, T[] Array_In, int Array_Index_In, out n5.SpreadBuilder<T> Output_Out, out T[] Result_Out)
        {
            var Result_0 = Input_In.CopyToVL(array: Array_In, arrayIndex: Array_Index_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void CopyTo_Count<T>(n5.SpreadBuilder<T> Input_In, T[] Array_In, int Start_Index_In, int Count_In, int Array_Index_In, bool Reverse_Order_In, out n5.SpreadBuilder<T> Output_Out, out T[] Result_Out)
        {
            var Result_0 = Input_In.CopyTo(array: Array_In, startIndex: Start_Index_In, count: Count_In, arrayIndex: Array_Index_In, reverseOrder: Reverse_Order_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void Count<T>(n5.SpreadBuilder<T> Input_In, out n5.SpreadBuilder<T> Output_Out, out int Count_Out)
        {
            var Count_0 = Input_In.Count;
            Output_Out = Input_In;
            Count_Out = Count_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, int Capacity_In, out n5.SpreadBuilder<T> Output_Out)
        {
            var Output_0 = new n5.SpreadBuilder<T>(capacity: Capacity_In);
            Output_Out = Output_0;
            return;
        }

        public static void Create_Array<T>(T[] Array_In, out n5.SpreadBuilder<T> Output_Out)
        {
            var Output_0 = new n5.SpreadBuilder<T>(array: Array_In);
            Output_Out = Output_0;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static n5.SpreadBuilder<T> CreateDefault<T>()
        {
            int Capacity_0 = 0;
            var Output_1 = new n5.SpreadBuilder<T>(capacity: Capacity_0);
            return Output_1;
        }

        public static void Empty<T>(out n5.SpreadBuilder<T> Empty_Out)
        {
            var Empty_0 = n5.SpreadBuilder<T>.Empty;
            Empty_Out = Empty_0;
            return;
        }

        public static void GetItem<T>(n5.SpreadBuilder<T> Input_In, int Index_In, out n5.SpreadBuilder<T> Output_Out, out T Item_Out)
        {
            var Item_0 = Input_In[Index_In];
            Output_Out = Input_In;
            Item_Out = Item_0;
            return;
        }

        public static void IndexOf<T>(n5.SpreadBuilder<T> Input_In, T Item_In, out n5.SpreadBuilder<T> Output_Out, out int Result_Out)
        {
            var Result_0 = Input_In.IndexOf(item: Item_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void Insert<T>(n5.SpreadBuilder<T> Input_In, int Index_In, T Item_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In.Insert(index: Index_In, item: Item_In);
            Output_Out = Input_In;
            return;
        }

        public static void Remove<T>(n5.SpreadBuilder<T> Input_In, T Item_In, out n5.SpreadBuilder<T> Output_Out, out bool Result_Out)
        {
            var Result_0 = Input_In.Remove(item: Item_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void RemoveAt<T>(n5.SpreadBuilder<T> Input_In, int Index_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In.RemoveAt(index: Index_In);
            Output_Out = Input_In;
            return;
        }

        public static void RemoveRange<T>(n5.SpreadBuilder<T> Input_In, int Index_In, int Count_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In.RemoveRange(index: Index_In, count: Count_In);
            Output_Out = Input_In;
            return;
        }

        public static void Repeat<T>(T Element_In, int Count_In, out n5.SpreadBuilder<T> Result_Out)
        {
            n1.NodeContext Node_Context_0 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "RjKd4Dc4PtENtLKhDlt028", 262362U);
            n24._Operations_.Create<T>(Node_Context: Node_Context_0, Capacity_In: Count_In, Output_Out: out n5.SpreadBuilder<T> Output_1);
            n8._Operations_.Repeat<T>(Element_In: Element_In, Count_In: Count_In, Result_Out: out n6.IEnumerable<T> Result_2);
            n24._Operations_.AddRange<T>(Input_In: Output_1, Items_In: Result_2, Output_Out: out n5.SpreadBuilder<T> Output_3);
            Result_Out = Output_3;
            return;
        }

        public static void RepeatRowsCols<T>(T Element_In, int Row_Count_In, int Column_Count_In, out n5.SpreadBuilder<n5.SpreadBuilder<T>> Result_Out)
        {
            n1.NodeContext Node_Context_0 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "H0ZKLS5mjgWN0BJYaJqjmf", 262390U);
            n24._Operations_.Create<n5.SpreadBuilder<T>>(Node_Context: Node_Context_0, Capacity_In: Row_Count_In, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<T>> Output_1);
            n5.SpreadBuilder<n5.SpreadBuilder<T>> accumulator_3 = Output_1;
            for (var i_2 = 0; i_2 < Row_Count_In; i_2++)
            {
                var i_local_4 = i_2;
                n8._Operations_.Repeat<T>(Element_In: Element_In, Count_In: Column_Count_In, Result_Out: out n6.IEnumerable<T> Result_5);
                n1.NodeContext Node_Context_6 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "AB5bvkr3MeUPIvD5VE0pxM", 262403U);
                n24._Operations_.Create<T>(Node_Context: Node_Context_6, Capacity_In: Column_Count_In, Output_Out: out n5.SpreadBuilder<T> Output_7);
                n24._Operations_.AddRange<T>(Input_In: Output_7, Items_In: Result_5, Output_Out: out n5.SpreadBuilder<T> Output_8);
                n24._Operations_.Add<n5.SpreadBuilder<T>>(Input_In: accumulator_3, Item_In: Output_8, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<T>> Output_9);
                accumulator_3 = Output_9;
            }

            Result_Out = accumulator_3;
            return;
        }

        public static void SetCount<T>(n5.SpreadBuilder<T> Input_In, int Value_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In.Count = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void SetItem<T>(n5.SpreadBuilder<T> Input_In, int Index_In, T Value_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In[Index_In] = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void SetRange<T>(n5.SpreadBuilder<T> Input_In, n6.IEnumerable<T> Items_In, int Index_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In.SetRange(items: Items_In, index: Index_In);
            Output_Out = Input_In;
            return;
        }

        public static void SetRange_Array<T>(n5.SpreadBuilder<T> Input_In, T[] Array_In, int Start_Index_In, int Count_In, int Array_Index_In, bool Reverse_Order_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In.SetRangeArray(array: Array_In, startIndex: Start_Index_In, count: Count_In, arrayIndex: Array_Index_In, reverseOrder: Reverse_Order_In);
            Output_Out = Input_In;
            return;
        }

        public static void SetRowCol<T>(n5.SpreadBuilder<n5.SpreadBuilder<T>> Input_In, int Row_In, int Column_In, T Value_In, out n5.SpreadBuilder<n5.SpreadBuilder<T>> Output_Out)
        {
            n24._Operations_.GetItem<n5.SpreadBuilder<T>>(Input_In: Input_In, Index_In: Row_In, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<T>> Output_0, Item_Out: out n5.SpreadBuilder<T> Item_1);
            n24._Operations_.SetItem<T>(Input_In: Item_1, Index_In: Column_In, Value_In: Value_In, Output_Out: out n5.SpreadBuilder<T> Output_2);
            Output_Out = Output_0;
            return;
        }

        public static void Sort<T>(n5.SpreadBuilder<T> Input_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In.Sort();
            Output_Out = Input_In;
            return;
        }

        public static void Sort_Comparer<T>(n5.SpreadBuilder<T> Input_In, n2.Func<T, T, int> Comparer_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In.Sort(comparer: Comparer_In);
            Output_Out = Input_In;
            return;
        }

        public static void ToSpread<T>(n5.SpreadBuilder<T> Input_In, out n5.SpreadBuilder<T> Output_Out, out n5.Spread<T> Result_Out)
        {
            var Result_0 = Input_In.ToSpread();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void FromValue<T>(T Input_In, out n5.SpreadBuilder<T> Result_Out)
        {
            var Result_0 = n25.SpreadGenerators.ToSpreadBuilder<T>(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToSpreadOfSpread<T2, T>(T2 Builders_In, out n5.Spread<n5.Spread<T>> Result_Out)
            where T2 : n6.IEnumerable<n5.SpreadBuilder<T>>
        {
            n5.Spread<n5.Spread<T>> __cp_RkSuLIabUOEN7qkBijnVlx = n7._Operations_.CreateDefault<n5.Spread<T>>();
            var builder_6 = n4.CollectionBuilders.GetBuilder(__cp_RkSuLIabUOEN7qkBijnVlx, 16);
            n5.Spread<n5.Spread<T>> output_7;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in Builders_In)
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    n24._Operations_.ToSpread<T>(Input_In: splicer_1, Output_Out: out n5.SpreadBuilder<T> Output_4, Result_Out: out n5.Spread<T> Result_5);
                    builder_6.Add(Result_5);
                    i_2++;
                }
            }
            finally
            {
                output_7 = builder_6.Commit();
            }

            Result_Out = output_7;
            return;
        }

        public static void ValuesToVectors__2D(n5.SpreadBuilder<n26.Vector2> Input_In, n6.IEnumerable<float> Values_In, out n5.SpreadBuilder<n26.Vector2> Output_Out)
        {
            var Output_0 = n25.ValuesToVectorsNodes.ValuesToVectors2D(builder: Input_In, values: Values_In);
            Output_Out = Output_0;
            return;
        }

        public static void ValuesToVectors__3D(n5.SpreadBuilder<n26.Vector3> Input_In, n6.IEnumerable<float> Values_In, out n5.SpreadBuilder<n26.Vector3> Output_Out)
        {
            var Output_0 = n25.ValuesToVectorsNodes.ValuesToVectors3D(builder: Input_In, values: Values_In);
            Output_Out = Output_0;
            return;
        }

        public static void ValuesToVectors__4D(n5.SpreadBuilder<n26.Vector4> Input_In, n6.IEnumerable<float> Values_In, out n5.SpreadBuilder<n26.Vector4> Output_Out)
        {
            var Output_0 = n25.ValuesToVectorsNodes.ValuesToVectors4D(builder: Input_In, values: Values_In);
            Output_Out = Output_0;
            return;
        }

        public static void VectorsToValues__2D<T>(n5.SpreadBuilder<float> Input_In, T Vectors_In, out n5.SpreadBuilder<float> Output_Out)
            where T : n6.IEnumerable<n26.Vector2>
        {
            n5.SpreadBuilder<float> accumulator_1 = Input_In;
            var i_3 = 0;
            foreach (var item_0 in Vectors_In)
            {
                var splicer_2 = item_0;
                var i_local_4 = i_3;
                n27.Vector2Nodes.Vector(input: ref splicer_2, x: out float X_5, y: out float Y_6);
                n24._Operations_.Add<float>(Input_In: accumulator_1, Item_In: X_5, Output_Out: out n5.SpreadBuilder<float> Output_7);
                n24._Operations_.Add<float>(Input_In: Output_7, Item_In: Y_6, Output_Out: out Output_7);
                accumulator_1 = Output_7;
                i_3++;
            }

            Output_Out = accumulator_1;
            return;
        }

        public static void VectorsToValues__3D<T>(n5.SpreadBuilder<float> Input_In, T Vectors_In, out n5.SpreadBuilder<float> Output_Out)
            where T : n6.IEnumerable<n26.Vector3>
        {
            n5.SpreadBuilder<float> accumulator_1 = Input_In;
            var i_3 = 0;
            foreach (var item_0 in Vectors_In)
            {
                var splicer_2 = item_0;
                var i_local_4 = i_3;
                n27.Vector3Nodes.Vector(input: ref splicer_2, x: out float X_5, y: out float Y_6, z: out float Z_7);
                n24._Operations_.Add<float>(Input_In: accumulator_1, Item_In: X_5, Output_Out: out n5.SpreadBuilder<float> Output_8);
                n24._Operations_.Add<float>(Input_In: Output_8, Item_In: Y_6, Output_Out: out Output_8);
                n24._Operations_.Add<float>(Input_In: Output_8, Item_In: Z_7, Output_Out: out Output_8);
                accumulator_1 = Output_8;
                i_3++;
            }

            Output_Out = accumulator_1;
            return;
        }

        public static void VectorsToValues__4D<T>(n5.SpreadBuilder<float> Input_In, T Vectors_In, out n5.SpreadBuilder<float> Output_Out)
            where T : n6.IEnumerable<n26.Vector4>
        {
            n5.SpreadBuilder<float> accumulator_1 = Input_In;
            var i_3 = 0;
            foreach (var item_0 in Vectors_In)
            {
                var splicer_2 = item_0;
                var i_local_4 = i_3;
                n27.Vector4Nodes.Vector(input: ref splicer_2, x: out float X_5, y: out float Y_6, z: out float Z_7, w: out float W_8);
                n24._Operations_.Add<float>(Input_In: accumulator_1, Item_In: X_5, Output_Out: out n5.SpreadBuilder<float> Output_9);
                n24._Operations_.Add<float>(Input_In: Output_9, Item_In: Y_6, Output_Out: out Output_9);
                n24._Operations_.Add<float>(Input_In: Output_9, Item_In: Z_7, Output_Out: out Output_9);
                n24._Operations_.Add<float>(Input_In: Output_9, Item_In: W_8, Output_Out: out Output_9);
                accumulator_1 = Output_9;
                i_3++;
            }

            Output_Out = accumulator_1;
            return;
        }

        public static void RemoveAll<T>(n5.SpreadBuilder<T> Input_In, n2.Func<T, bool> Match_In, out n5.SpreadBuilder<T> Output_Out)
        {
            Input_In.RemoveAll(match: Match_In);
            Output_Out = Input_In;
            return;
        }

        public static void FromBoolean(bool Value_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            byte __pad_Sa0emTzVdl5LkW93HwpwkR_0 = __slot_Sa0emTzVdl5LkW93HwpwkR;
            int __pad_K7XWcf58Y2DLCRtPFelvlS_1 = __slot_K7XWcf58Y2DLCRtPFelvlS;
            byte __auto_2;
            if (Value_In)
            {
                byte __pad_AnMhT22J3DTMrurTAqRDsm_3 = __slot_AnMhT22J3DTMrurTAqRDsm;
                __auto_2 = __pad_AnMhT22J3DTMrurTAqRDsm_3;
            }
            else
            {
                __auto_2 = __pad_Sa0emTzVdl5LkW93HwpwkR_0;
            }

            n1.NodeContext Node_Context_4 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "Ny4CCAKV4xLMyP9foErqVF", 262866U);
            n24._Operations_.Create<byte>(Node_Context: Node_Context_4, Capacity_In: __pad_K7XWcf58Y2DLCRtPFelvlS_1, Output_Out: out n5.SpreadBuilder<byte> Output_5);
            int Index_6 = 0;
            n24._Operations_.SetItem<byte>(Input_In: Output_5, Index_In: Index_6, Value_In: __auto_2, Output_Out: out n5.SpreadBuilder<byte> Output_7);
            Output_Out = Output_7;
            return;
        }

        public static void FromChar(char Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_PTvkhEC6JdGPAt1drffaxQ_0 = __slot_PTvkhEC6JdGPAt1drffaxQ;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            n1.NodeContext Node_Context_2 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "DRh8V38xSBpLATTpuUUnTV", 262907U);
            n24._Operations_.Create<byte>(Node_Context: Node_Context_2, Capacity_In: __pad_PTvkhEC6JdGPAt1drffaxQ_0, Output_Out: out n5.SpreadBuilder<byte> Output_3);
            var Is_Little_Endian_4 = n2.BitConverter.IsLittleEndian;
            var Result_5 = As_Big_Endian_In == Is_Little_Endian_4;
            int Array_Index_6 = 0;
            n24._Operations_.AddRange_Array<byte>(Input_In: Output_3, Array_In: Result_1, Count_In: __pad_PTvkhEC6JdGPAt1drffaxQ_0, Array_Index_In: Array_Index_6, Reverse_Order_In: Result_5, Output_Out: out n5.SpreadBuilder<byte> Output_7);
            Output_Out = Output_7;
            return;
        }

        public static void FromFloat32(float Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_FD5DmZ0tUeCNqhU3cjKQ8E_0 = __slot_FD5DmZ0tUeCNqhU3cjKQ8E;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            n1.NodeContext Node_Context_2 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "C0KTVrCETz7NgTYLnvCGe9", 262947U);
            n24._Operations_.Create<byte>(Node_Context: Node_Context_2, Capacity_In: __pad_FD5DmZ0tUeCNqhU3cjKQ8E_0, Output_Out: out n5.SpreadBuilder<byte> Output_3);
            var Is_Little_Endian_4 = n2.BitConverter.IsLittleEndian;
            var Result_5 = As_Big_Endian_In == Is_Little_Endian_4;
            int Array_Index_6 = 0;
            n24._Operations_.AddRange_Array<byte>(Input_In: Output_3, Array_In: Result_1, Count_In: __pad_FD5DmZ0tUeCNqhU3cjKQ8E_0, Array_Index_In: Array_Index_6, Reverse_Order_In: Result_5, Output_Out: out n5.SpreadBuilder<byte> Output_7);
            Output_Out = Output_7;
            return;
        }

        public static void FromFloat64(double Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_EBCI5sItoobLNa0A4s4yfT_0 = __slot_EBCI5sItoobLNa0A4s4yfT;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            n1.NodeContext Node_Context_2 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "LcaeRwculVIOdXchk5j2SJ", 262987U);
            n24._Operations_.Create<byte>(Node_Context: Node_Context_2, Capacity_In: __pad_EBCI5sItoobLNa0A4s4yfT_0, Output_Out: out n5.SpreadBuilder<byte> Output_3);
            var Is_Little_Endian_4 = n2.BitConverter.IsLittleEndian;
            var Result_5 = As_Big_Endian_In == Is_Little_Endian_4;
            int Array_Index_6 = 0;
            n24._Operations_.AddRange_Array<byte>(Input_In: Output_3, Array_In: Result_1, Count_In: __pad_EBCI5sItoobLNa0A4s4yfT_0, Array_Index_In: Array_Index_6, Reverse_Order_In: Result_5, Output_Out: out n5.SpreadBuilder<byte> Output_7);
            Output_Out = Output_7;
            return;
        }

        public static void FromInt16(short Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_TMcgEDG0I9CN7EGtKrfGBU_0 = __slot_TMcgEDG0I9CN7EGtKrfGBU;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            n1.NodeContext Node_Context_2 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "SVDMkrdQ2vaMkLQcD3gvZK", 263027U);
            n24._Operations_.Create<byte>(Node_Context: Node_Context_2, Capacity_In: __pad_TMcgEDG0I9CN7EGtKrfGBU_0, Output_Out: out n5.SpreadBuilder<byte> Output_3);
            var Is_Little_Endian_4 = n2.BitConverter.IsLittleEndian;
            var Result_5 = As_Big_Endian_In == Is_Little_Endian_4;
            int Array_Index_6 = 0;
            n24._Operations_.AddRange_Array<byte>(Input_In: Output_3, Array_In: Result_1, Count_In: __pad_TMcgEDG0I9CN7EGtKrfGBU_0, Array_Index_In: Array_Index_6, Reverse_Order_In: Result_5, Output_Out: out n5.SpreadBuilder<byte> Output_7);
            Output_Out = Output_7;
            return;
        }

        public static void FromInt32(int Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_NWV4aNNgfx3MKwH6Zcn2F0_0 = __slot_NWV4aNNgfx3MKwH6Zcn2F0;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            n1.NodeContext Node_Context_2 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "IejU8oIPqz8OdCmZjGLxPd", 263067U);
            n24._Operations_.Create<byte>(Node_Context: Node_Context_2, Capacity_In: __pad_NWV4aNNgfx3MKwH6Zcn2F0_0, Output_Out: out n5.SpreadBuilder<byte> Output_3);
            var Is_Little_Endian_4 = n2.BitConverter.IsLittleEndian;
            var Result_5 = As_Big_Endian_In == Is_Little_Endian_4;
            int Array_Index_6 = 0;
            n24._Operations_.AddRange_Array<byte>(Input_In: Output_3, Array_In: Result_1, Count_In: __pad_NWV4aNNgfx3MKwH6Zcn2F0_0, Array_Index_In: Array_Index_6, Reverse_Order_In: Result_5, Output_Out: out n5.SpreadBuilder<byte> Output_7);
            Output_Out = Output_7;
            return;
        }

        public static void FromInt64(long Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_JavKAQNI849QGzPQA59rFX_0 = __slot_JavKAQNI849QGzPQA59rFX;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            n1.NodeContext Node_Context_2 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "E1Lgah6MzcMNHNExNIO0K3", 263107U);
            n24._Operations_.Create<byte>(Node_Context: Node_Context_2, Capacity_In: __pad_JavKAQNI849QGzPQA59rFX_0, Output_Out: out n5.SpreadBuilder<byte> Output_3);
            var Is_Little_Endian_4 = n2.BitConverter.IsLittleEndian;
            var Result_5 = As_Big_Endian_In == Is_Little_Endian_4;
            int Array_Index_6 = 0;
            n24._Operations_.AddRange_Array<byte>(Input_In: Output_3, Array_In: Result_1, Count_In: __pad_JavKAQNI849QGzPQA59rFX_0, Array_Index_In: Array_Index_6, Reverse_Order_In: Result_5, Output_Out: out n5.SpreadBuilder<byte> Output_7);
            Output_Out = Output_7;
            return;
        }

        public static void FromInt8(sbyte Value_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_VkKAOiqlY6cNMinYuKWlBm_0 = __slot_VkKAOiqlY6cNMinYuKWlBm;
            var Result_1 = n10.IntegerConversions.ToByte(input: Value_In);
            n1.NodeContext Node_Context_2 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "VP7FTXdakzENgKHNHUAJgz", 263131U);
            n24._Operations_.Create<byte>(Node_Context: Node_Context_2, Capacity_In: __pad_VkKAOiqlY6cNMinYuKWlBm_0, Output_Out: out n5.SpreadBuilder<byte> Output_3);
            int Index_4 = 0;
            n24._Operations_.SetItem<byte>(Input_In: Output_3, Index_In: Index_4, Value_In: Result_1, Output_Out: out n5.SpreadBuilder<byte> Output_5);
            Output_Out = Output_5;
            return;
        }

        public static void FromUInt16(ushort Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_QeGnpyqv6oPQJLSWX5jZ7w_0 = __slot_QeGnpyqv6oPQJLSWX5jZ7w;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            n1.NodeContext Node_Context_2 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "PrwAg8CVCNaMWzuikX3I9n", 263172U);
            n24._Operations_.Create<byte>(Node_Context: Node_Context_2, Capacity_In: __pad_QeGnpyqv6oPQJLSWX5jZ7w_0, Output_Out: out n5.SpreadBuilder<byte> Output_3);
            var Is_Little_Endian_4 = n2.BitConverter.IsLittleEndian;
            var Result_5 = As_Big_Endian_In == Is_Little_Endian_4;
            int Array_Index_6 = 0;
            n24._Operations_.AddRange_Array<byte>(Input_In: Output_3, Array_In: Result_1, Count_In: __pad_QeGnpyqv6oPQJLSWX5jZ7w_0, Array_Index_In: Array_Index_6, Reverse_Order_In: Result_5, Output_Out: out n5.SpreadBuilder<byte> Output_7);
            Output_Out = Output_7;
            return;
        }

        public static void FromUInt32(uint Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_A8CajQE8mjROq08djrW5IL_0 = __slot_A8CajQE8mjROq08djrW5IL;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            n1.NodeContext Node_Context_2 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "Jlmmzy3kVAiOjzI2t5vOTW", 263212U);
            n24._Operations_.Create<byte>(Node_Context: Node_Context_2, Capacity_In: __pad_A8CajQE8mjROq08djrW5IL_0, Output_Out: out n5.SpreadBuilder<byte> Output_3);
            var Is_Little_Endian_4 = n2.BitConverter.IsLittleEndian;
            var Result_5 = As_Big_Endian_In == Is_Little_Endian_4;
            int Array_Index_6 = 0;
            n24._Operations_.AddRange_Array<byte>(Input_In: Output_3, Array_In: Result_1, Count_In: __pad_A8CajQE8mjROq08djrW5IL_0, Array_Index_In: Array_Index_6, Reverse_Order_In: Result_5, Output_Out: out n5.SpreadBuilder<byte> Output_7);
            Output_Out = Output_7;
            return;
        }

        public static void FromUInt64(ulong Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_Gui8tjkv3gKPURNclP2duu_0 = __slot_Gui8tjkv3gKPURNclP2duu;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            n1.NodeContext Node_Context_2 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "IZVD3IWJ06aMKJNN6dB09C", 263252U);
            n24._Operations_.Create<byte>(Node_Context: Node_Context_2, Capacity_In: __pad_Gui8tjkv3gKPURNclP2duu_0, Output_Out: out n5.SpreadBuilder<byte> Output_3);
            var Is_Little_Endian_4 = n2.BitConverter.IsLittleEndian;
            var Result_5 = As_Big_Endian_In == Is_Little_Endian_4;
            int Array_Index_6 = 0;
            n24._Operations_.AddRange_Array<byte>(Input_In: Output_3, Array_In: Result_1, Count_In: __pad_Gui8tjkv3gKPURNclP2duu_0, Array_Index_In: Array_Index_6, Reverse_Order_In: Result_5, Output_Out: out n5.SpreadBuilder<byte> Output_7);
            Output_Out = Output_7;
            return;
        }

        public static void SetBoolean([n4.SerializedDefaultValueAttribute("0", false)] n5.SpreadBuilder<byte> Input_In, int Index_In, bool Value_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            byte __pad_Kx3xzQwEqnRQUsXZKYvD2K_0 = __slot_Kx3xzQwEqnRQUsXZKYvD2K;
            byte __auto_1;
            if (Value_In)
            {
                byte __pad_AkPiOfZ9TTeMBILcYVemhP_2 = __slot_AkPiOfZ9TTeMBILcYVemhP;
                __auto_1 = __pad_AkPiOfZ9TTeMBILcYVemhP_2;
            }
            else
            {
                __auto_1 = __pad_Kx3xzQwEqnRQUsXZKYvD2K_0;
            }

            n24._Operations_.SetItem<byte>(Input_In: Input_In, Index_In: Index_In, Value_In: __auto_1, Output_Out: out n5.SpreadBuilder<byte> Output_3);
            Output_Out = Output_3;
            return;
        }

        public static void SetChar([n4.SerializedDefaultValueAttribute("0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, char Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_NPj1aYpnjJ7LjAGRHi0zA5_0 = __slot_NPj1aYpnjJ7LjAGRHi0zA5;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            var Is_Little_Endian_2 = n2.BitConverter.IsLittleEndian;
            var Result_3 = As_Big_Endian_In == Is_Little_Endian_2;
            int Array_Index_4 = 0;
            n24._Operations_.SetRange_Array<byte>(Input_In: Input_In, Array_In: Result_1, Start_Index_In: Start_Index_In, Count_In: __pad_NPj1aYpnjJ7LjAGRHi0zA5_0, Array_Index_In: Array_Index_4, Reverse_Order_In: Result_3, Output_Out: out n5.SpreadBuilder<byte> Output_5);
            Output_Out = Output_5;
            return;
        }

        public static void SetFloat32([n4.SerializedDefaultValueAttribute("0, 0, 0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, float Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_RyG1d3WQflTMWnHUYNmA3D_0 = __slot_RyG1d3WQflTMWnHUYNmA3D;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            var Is_Little_Endian_2 = n2.BitConverter.IsLittleEndian;
            var Result_3 = As_Big_Endian_In == Is_Little_Endian_2;
            int Array_Index_4 = 0;
            n24._Operations_.SetRange_Array<byte>(Input_In: Input_In, Array_In: Result_1, Start_Index_In: Start_Index_In, Count_In: __pad_RyG1d3WQflTMWnHUYNmA3D_0, Array_Index_In: Array_Index_4, Reverse_Order_In: Result_3, Output_Out: out n5.SpreadBuilder<byte> Output_5);
            Output_Out = Output_5;
            return;
        }

        public static void SetFloat64([n4.SerializedDefaultValueAttribute("0, 0, 0, 0, 0, 0, 0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, double Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_TshweuDXVPZPEpReURMdXO_0 = __slot_TshweuDXVPZPEpReURMdXO;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            var Is_Little_Endian_2 = n2.BitConverter.IsLittleEndian;
            var Result_3 = As_Big_Endian_In == Is_Little_Endian_2;
            int Array_Index_4 = 0;
            n24._Operations_.SetRange_Array<byte>(Input_In: Input_In, Array_In: Result_1, Start_Index_In: Start_Index_In, Count_In: __pad_TshweuDXVPZPEpReURMdXO_0, Array_Index_In: Array_Index_4, Reverse_Order_In: Result_3, Output_Out: out n5.SpreadBuilder<byte> Output_5);
            Output_Out = Output_5;
            return;
        }

        public static void SetInt16([n4.SerializedDefaultValueAttribute("0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, short Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_LZdSUOBU1oTPOObNeWjiQF_0 = __slot_LZdSUOBU1oTPOObNeWjiQF;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            var Is_Little_Endian_2 = n2.BitConverter.IsLittleEndian;
            var Result_3 = As_Big_Endian_In == Is_Little_Endian_2;
            int Array_Index_4 = 0;
            n24._Operations_.SetRange_Array<byte>(Input_In: Input_In, Array_In: Result_1, Start_Index_In: Start_Index_In, Count_In: __pad_LZdSUOBU1oTPOObNeWjiQF_0, Array_Index_In: Array_Index_4, Reverse_Order_In: Result_3, Output_Out: out n5.SpreadBuilder<byte> Output_5);
            Output_Out = Output_5;
            return;
        }

        public static void SetInt32([n4.SerializedDefaultValueAttribute("0, 0, 0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, int Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_G1jrlLFTBZaQCSOc3UNFTA_0 = __slot_G1jrlLFTBZaQCSOc3UNFTA;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            var Is_Little_Endian_2 = n2.BitConverter.IsLittleEndian;
            var Result_3 = As_Big_Endian_In == Is_Little_Endian_2;
            int Array_Index_4 = 0;
            n24._Operations_.SetRange_Array<byte>(Input_In: Input_In, Array_In: Result_1, Start_Index_In: Start_Index_In, Count_In: __pad_G1jrlLFTBZaQCSOc3UNFTA_0, Array_Index_In: Array_Index_4, Reverse_Order_In: Result_3, Output_Out: out n5.SpreadBuilder<byte> Output_5);
            Output_Out = Output_5;
            return;
        }

        public static void SetInt64([n4.SerializedDefaultValueAttribute("0, 0, 0, 0, 0, 0, 0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, long Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_H1lRhh1BOEuO78McHrDlFD_0 = __slot_H1lRhh1BOEuO78McHrDlFD;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            var Is_Little_Endian_2 = n2.BitConverter.IsLittleEndian;
            var Result_3 = As_Big_Endian_In == Is_Little_Endian_2;
            int Array_Index_4 = 0;
            n24._Operations_.SetRange_Array<byte>(Input_In: Input_In, Array_In: Result_1, Start_Index_In: Start_Index_In, Count_In: __pad_H1lRhh1BOEuO78McHrDlFD_0, Array_Index_In: Array_Index_4, Reverse_Order_In: Result_3, Output_Out: out n5.SpreadBuilder<byte> Output_5);
            Output_Out = Output_5;
            return;
        }

        public static void SetInt8([n4.SerializedDefaultValueAttribute("0", false)] n5.SpreadBuilder<byte> Input_In, int Index_In, sbyte Value_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            var Result_0 = n10.IntegerConversions.ToByte(input: Value_In);
            n24._Operations_.SetItem<byte>(Input_In: Input_In, Index_In: Index_In, Value_In: Result_0, Output_Out: out n5.SpreadBuilder<byte> Output_1);
            Output_Out = Output_1;
            return;
        }

        public static void SetUInt16([n4.SerializedDefaultValueAttribute("0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, ushort Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_SZRtccbSy3UPLa3zgwcg7x_0 = __slot_SZRtccbSy3UPLa3zgwcg7x;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            var Is_Little_Endian_2 = n2.BitConverter.IsLittleEndian;
            var Result_3 = As_Big_Endian_In == Is_Little_Endian_2;
            int Array_Index_4 = 0;
            n24._Operations_.SetRange_Array<byte>(Input_In: Input_In, Array_In: Result_1, Start_Index_In: Start_Index_In, Count_In: __pad_SZRtccbSy3UPLa3zgwcg7x_0, Array_Index_In: Array_Index_4, Reverse_Order_In: Result_3, Output_Out: out n5.SpreadBuilder<byte> Output_5);
            Output_Out = Output_5;
            return;
        }

        public static void SetUInt32([n4.SerializedDefaultValueAttribute("0, 0, 0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, uint Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_N4gFkXbgoqyOUN5OVRzKXj_0 = __slot_N4gFkXbgoqyOUN5OVRzKXj;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            var Is_Little_Endian_2 = n2.BitConverter.IsLittleEndian;
            var Result_3 = As_Big_Endian_In == Is_Little_Endian_2;
            int Array_Index_4 = 0;
            n24._Operations_.SetRange_Array<byte>(Input_In: Input_In, Array_In: Result_1, Start_Index_In: Start_Index_In, Count_In: __pad_N4gFkXbgoqyOUN5OVRzKXj_0, Array_Index_In: Array_Index_4, Reverse_Order_In: Result_3, Output_Out: out n5.SpreadBuilder<byte> Output_5);
            Output_Out = Output_5;
            return;
        }

        public static void SetUInt64(n5.SpreadBuilder<byte> Input_In, int Start_Index_In, ulong Value_In, bool As_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out)
        {
            int __pad_LRuNj6hhaHjQPU2Jw56yXa_0 = __slot_LRuNj6hhaHjQPU2Jw56yXa;
            var Result_1 = n2.BitConverter.GetBytes(value: Value_In);
            var Is_Little_Endian_2 = n2.BitConverter.IsLittleEndian;
            var Result_3 = As_Big_Endian_In == Is_Little_Endian_2;
            int Array_Index_4 = 0;
            n24._Operations_.SetRange_Array<byte>(Input_In: Input_In, Array_In: Result_1, Start_Index_In: Start_Index_In, Count_In: __pad_LRuNj6hhaHjQPU2Jw56yXa_0, Array_Index_In: Array_Index_4, Reverse_Order_In: Result_3, Output_Out: out n5.SpreadBuilder<byte> Output_5);
            Output_Out = Output_5;
            return;
        }

        public static void ToBoolean([n4.SerializedDefaultValueAttribute("0", false)] n5.SpreadBuilder<byte> Input_In, int Index_In, out n5.SpreadBuilder<byte> Output_Out, out bool Result_Out)
        {
            n24._Operations_.GetItem<byte>(Input_In: Input_In, Index_In: Index_In, Output_Out: out n5.SpreadBuilder<byte> Output_0, Item_Out: out byte Item_1);
            byte Input_2_2 = 0;
            var Result_3 = Item_1 != Input_2_2;
            Output_Out = Output_0;
            Result_Out = Result_3;
            return;
        }

        public static void ToChar([n4.SerializedDefaultValueAttribute("0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out, out char Result_Out)
        {
            int __pad_HqixQ3IRYqhM3MTcTW60ML_0 = __slot_HqixQ3IRYqhM3MTcTW60ML;
            n1.NodeContext Node_Context_1 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "CmWtbcufxsxPzcYlRBw9b9", 263771U);
            n28._Operations_.Create<byte>(Node_Context: Node_Context_1, Length_In: __pad_HqixQ3IRYqhM3MTcTW60ML_0, Result_Out: out byte[] Result_2);
            var Is_Little_Endian_3 = n2.BitConverter.IsLittleEndian;
            var Result_4 = Input_Is_Big_Endian_In == Is_Little_Endian_3;
            int Array_Index_5 = 0;
            n24._Operations_.CopyTo_Count<byte>(Input_In: Input_In, Array_In: Result_2, Start_Index_In: Start_Index_In, Count_In: __pad_HqixQ3IRYqhM3MTcTW60ML_0, Array_Index_In: Array_Index_5, Reverse_Order_In: Result_4, Output_Out: out n5.SpreadBuilder<byte> Output_6, Result_Out: out byte[] Result_7);
            int Start_Index_8 = 0;
            var Result_9 = n2.BitConverter.ToChar(value: Result_7, startIndex: Start_Index_8);
            Output_Out = Output_6;
            Result_Out = Result_9;
            return;
        }

        public static void ToFloat32([n4.SerializedDefaultValueAttribute("0, 0, 0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out, out float Result_Out)
        {
            int __pad_I9h4XkCslkAMGPUuh0b5Gu_0 = __slot_I9h4XkCslkAMGPUuh0b5Gu;
            n1.NodeContext Node_Context_1 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "TAtwTEuGBR8P2R1WOD1fBI", 263822U);
            n28._Operations_.Create<byte>(Node_Context: Node_Context_1, Length_In: __pad_I9h4XkCslkAMGPUuh0b5Gu_0, Result_Out: out byte[] Result_2);
            var Is_Little_Endian_3 = n2.BitConverter.IsLittleEndian;
            var Result_4 = Input_Is_Big_Endian_In == Is_Little_Endian_3;
            int Array_Index_5 = 0;
            n24._Operations_.CopyTo_Count<byte>(Input_In: Input_In, Array_In: Result_2, Start_Index_In: Start_Index_In, Count_In: __pad_I9h4XkCslkAMGPUuh0b5Gu_0, Array_Index_In: Array_Index_5, Reverse_Order_In: Result_4, Output_Out: out n5.SpreadBuilder<byte> Output_6, Result_Out: out byte[] Result_7);
            int Start_Index_8 = 0;
            var Result_9 = n2.BitConverter.ToSingle(value: Result_7, startIndex: Start_Index_8);
            Output_Out = Output_6;
            Result_Out = Result_9;
            return;
        }

        public static void ToFloat64([n4.SerializedDefaultValueAttribute("0, 0, 0, 0, 0, 0, 0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out, out double Result_Out)
        {
            int __pad_CYcu70nVzevNP7IDEOhaps_0 = __slot_CYcu70nVzevNP7IDEOhaps;
            n1.NodeContext Node_Context_1 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "S5MCCmT8N1vNsXT1bXKr9l", 263873U);
            n28._Operations_.Create<byte>(Node_Context: Node_Context_1, Length_In: __pad_CYcu70nVzevNP7IDEOhaps_0, Result_Out: out byte[] Result_2);
            var Is_Little_Endian_3 = n2.BitConverter.IsLittleEndian;
            var Result_4 = Input_Is_Big_Endian_In == Is_Little_Endian_3;
            int Array_Index_5 = 0;
            n24._Operations_.CopyTo_Count<byte>(Input_In: Input_In, Array_In: Result_2, Start_Index_In: Start_Index_In, Count_In: __pad_CYcu70nVzevNP7IDEOhaps_0, Array_Index_In: Array_Index_5, Reverse_Order_In: Result_4, Output_Out: out n5.SpreadBuilder<byte> Output_6, Result_Out: out byte[] Result_7);
            int Start_Index_8 = 0;
            var Result_9 = n2.BitConverter.ToDouble(value: Result_7, startIndex: Start_Index_8);
            Output_Out = Output_6;
            Result_Out = Result_9;
            return;
        }

        public static void ToInt16([n4.SerializedDefaultValueAttribute("0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out, out short Result_Out)
        {
            int __pad_SH2s4Jm0Qm4LOx2167Xi5J_0 = __slot_SH2s4Jm0Qm4LOx2167Xi5J;
            n1.NodeContext Node_Context_1 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "U9Xjt5dt6BYLylMzpx0xPm", 263924U);
            n28._Operations_.Create<byte>(Node_Context: Node_Context_1, Length_In: __pad_SH2s4Jm0Qm4LOx2167Xi5J_0, Result_Out: out byte[] Result_2);
            var Is_Little_Endian_3 = n2.BitConverter.IsLittleEndian;
            var Result_4 = Input_Is_Big_Endian_In == Is_Little_Endian_3;
            int Array_Index_5 = 0;
            n24._Operations_.CopyTo_Count<byte>(Input_In: Input_In, Array_In: Result_2, Start_Index_In: Start_Index_In, Count_In: __pad_SH2s4Jm0Qm4LOx2167Xi5J_0, Array_Index_In: Array_Index_5, Reverse_Order_In: Result_4, Output_Out: out n5.SpreadBuilder<byte> Output_6, Result_Out: out byte[] Result_7);
            int Start_Index_8 = 0;
            var Result_9 = n2.BitConverter.ToInt16(value: Result_7, startIndex: Start_Index_8);
            Output_Out = Output_6;
            Result_Out = Result_9;
            return;
        }

        public static void ToInt32([n4.SerializedDefaultValueAttribute("0, 0, 0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out, out int Result_Out)
        {
            int __pad_SIukfJ8Z2ssPddwx27eBQ2_0 = __slot_SIukfJ8Z2ssPddwx27eBQ2;
            n1.NodeContext Node_Context_1 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "LCvZjCKGodtL7QUpVgmaIQ", 263975U);
            n28._Operations_.Create<byte>(Node_Context: Node_Context_1, Length_In: __pad_SIukfJ8Z2ssPddwx27eBQ2_0, Result_Out: out byte[] Result_2);
            var Is_Little_Endian_3 = n2.BitConverter.IsLittleEndian;
            var Result_4 = Input_Is_Big_Endian_In == Is_Little_Endian_3;
            int Array_Index_5 = 0;
            n24._Operations_.CopyTo_Count<byte>(Input_In: Input_In, Array_In: Result_2, Start_Index_In: Start_Index_In, Count_In: __pad_SIukfJ8Z2ssPddwx27eBQ2_0, Array_Index_In: Array_Index_5, Reverse_Order_In: Result_4, Output_Out: out n5.SpreadBuilder<byte> Output_6, Result_Out: out byte[] Result_7);
            int Start_Index_8 = 0;
            var Result_9 = n2.BitConverter.ToInt32(value: Result_7, startIndex: Start_Index_8);
            Output_Out = Output_6;
            Result_Out = Result_9;
            return;
        }

        public static void ToInt64([n4.SerializedDefaultValueAttribute("0, 0, 0, 0, 0, 0, 0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out, out long Result_Out)
        {
            int __pad_JH0uLgsTQAmQPIk4V77Ezx_0 = __slot_JH0uLgsTQAmQPIk4V77Ezx;
            n1.NodeContext Node_Context_1 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "NgOrhPVSj6OPyLBQ6zTox0", 264026U);
            n28._Operations_.Create<byte>(Node_Context: Node_Context_1, Length_In: __pad_JH0uLgsTQAmQPIk4V77Ezx_0, Result_Out: out byte[] Result_2);
            var Is_Little_Endian_3 = n2.BitConverter.IsLittleEndian;
            var Result_4 = Input_Is_Big_Endian_In == Is_Little_Endian_3;
            int Array_Index_5 = 0;
            n24._Operations_.CopyTo_Count<byte>(Input_In: Input_In, Array_In: Result_2, Start_Index_In: Start_Index_In, Count_In: __pad_JH0uLgsTQAmQPIk4V77Ezx_0, Array_Index_In: Array_Index_5, Reverse_Order_In: Result_4, Output_Out: out n5.SpreadBuilder<byte> Output_6, Result_Out: out byte[] Result_7);
            int Start_Index_8 = 0;
            var Result_9 = n2.BitConverter.ToInt64(value: Result_7, startIndex: Start_Index_8);
            Output_Out = Output_6;
            Result_Out = Result_9;
            return;
        }

        public static void ToInt8([n4.SerializedDefaultValueAttribute("0", false)] n5.SpreadBuilder<byte> Input_In, int Index_In, out n5.SpreadBuilder<byte> Output_Out, out sbyte Result_Out)
        {
            n24._Operations_.GetItem<byte>(Input_In: Input_In, Index_In: Index_In, Output_Out: out n5.SpreadBuilder<byte> Output_0, Item_Out: out byte Item_1);
            var Result_2 = n10.IntegerConversions.ToInt8(input: Item_1);
            Output_Out = Output_0;
            Result_Out = Result_2;
            return;
        }

        public static void ToUInt16([n4.SerializedDefaultValueAttribute("0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out, out ushort Result_Out)
        {
            int __pad_LN7Mz2YVvf3NsEXeneQNlV_0 = __slot_LN7Mz2YVvf3NsEXeneQNlV;
            n1.NodeContext Node_Context_1 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "MvM74sSzxMNLlftvtvqAxA", 264104U);
            n28._Operations_.Create<byte>(Node_Context: Node_Context_1, Length_In: __pad_LN7Mz2YVvf3NsEXeneQNlV_0, Result_Out: out byte[] Result_2);
            var Is_Little_Endian_3 = n2.BitConverter.IsLittleEndian;
            var Result_4 = Input_Is_Big_Endian_In == Is_Little_Endian_3;
            int Array_Index_5 = 0;
            n24._Operations_.CopyTo_Count<byte>(Input_In: Input_In, Array_In: Result_2, Start_Index_In: Start_Index_In, Count_In: __pad_LN7Mz2YVvf3NsEXeneQNlV_0, Array_Index_In: Array_Index_5, Reverse_Order_In: Result_4, Output_Out: out n5.SpreadBuilder<byte> Output_6, Result_Out: out byte[] Result_7);
            int Start_Index_8 = 0;
            var Result_9 = n2.BitConverter.ToUInt16(value: Result_7, startIndex: Start_Index_8);
            Output_Out = Output_6;
            Result_Out = Result_9;
            return;
        }

        public static void ToUInt32([n4.SerializedDefaultValueAttribute("0, 0, 0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out, out uint Result_Out)
        {
            int __pad_Vev5OkLSsEEOGQ59NTEOVs_0 = __slot_Vev5OkLSsEEOGQ59NTEOVs;
            n1.NodeContext Node_Context_1 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "S4SZNj2ci9gP09BxeRqfBR", 264155U);
            n28._Operations_.Create<byte>(Node_Context: Node_Context_1, Length_In: __pad_Vev5OkLSsEEOGQ59NTEOVs_0, Result_Out: out byte[] Result_2);
            var Is_Little_Endian_3 = n2.BitConverter.IsLittleEndian;
            var Result_4 = Input_Is_Big_Endian_In == Is_Little_Endian_3;
            int Array_Index_5 = 0;
            n24._Operations_.CopyTo_Count<byte>(Input_In: Input_In, Array_In: Result_2, Start_Index_In: Start_Index_In, Count_In: __pad_Vev5OkLSsEEOGQ59NTEOVs_0, Array_Index_In: Array_Index_5, Reverse_Order_In: Result_4, Output_Out: out n5.SpreadBuilder<byte> Output_6, Result_Out: out byte[] Result_7);
            int Start_Index_8 = 0;
            var Result_9 = n2.BitConverter.ToUInt32(value: Result_7, startIndex: Start_Index_8);
            Output_Out = Output_6;
            Result_Out = Result_9;
            return;
        }

        public static void ToUInt64([n4.SerializedDefaultValueAttribute("0, 0, 0, 0, 0, 0, 0, 0", false)] n5.SpreadBuilder<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out n5.SpreadBuilder<byte> Output_Out, out ulong Result_Out)
        {
            int __pad_QmMJgjK5tGgPRqD5hkFQGJ_0 = __slot_QmMJgjK5tGgPRqD5hkFQGJ;
            n1.NodeContext Node_Context_1 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "Q51Aal7mnyxNsbskKlhucb", 264206U);
            n28._Operations_.Create<byte>(Node_Context: Node_Context_1, Length_In: __pad_QmMJgjK5tGgPRqD5hkFQGJ_0, Result_Out: out byte[] Result_2);
            var Is_Little_Endian_3 = n2.BitConverter.IsLittleEndian;
            var Result_4 = Input_Is_Big_Endian_In == Is_Little_Endian_3;
            int Array_Index_5 = 0;
            n24._Operations_.CopyTo_Count<byte>(Input_In: Input_In, Array_In: Result_2, Start_Index_In: Start_Index_In, Count_In: __pad_QmMJgjK5tGgPRqD5hkFQGJ_0, Array_Index_In: Array_Index_5, Reverse_Order_In: Result_4, Output_Out: out n5.SpreadBuilder<byte> Output_6, Result_Out: out byte[] Result_7);
            int Start_Index_8 = 0;
            var Result_9 = n2.BitConverter.ToUInt64(value: Result_7, startIndex: Start_Index_8);
            Output_Out = Output_6;
            Result_Out = Result_9;
            return;
        }

        [n1.ElementAttribute(TracingId = 262861U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Sa0emTzVdl5LkW93HwpwkR", Name = "__slot_Sa0emTzVdl5LkW93HwpwkR")]
        public static byte __slot_Sa0emTzVdl5LkW93HwpwkR = 0;
        [n1.ElementAttribute(TracingId = 262869U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "K7XWcf58Y2DLCRtPFelvlS", Name = "__slot_K7XWcf58Y2DLCRtPFelvlS")]
        public static int __slot_K7XWcf58Y2DLCRtPFelvlS = 1;
        [n1.ElementAttribute(TracingId = 262855U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "AnMhT22J3DTMrurTAqRDsm", Name = "__slot_AnMhT22J3DTMrurTAqRDsm")]
        public static byte __slot_AnMhT22J3DTMrurTAqRDsm = 1;
        [n1.ElementAttribute(TracingId = 262903U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "PTvkhEC6JdGPAt1drffaxQ", Name = "__slot_PTvkhEC6JdGPAt1drffaxQ")]
        public static int __slot_PTvkhEC6JdGPAt1drffaxQ = 2;
        [n1.ElementAttribute(TracingId = 262943U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "FD5DmZ0tUeCNqhU3cjKQ8E", Name = "__slot_FD5DmZ0tUeCNqhU3cjKQ8E")]
        public static int __slot_FD5DmZ0tUeCNqhU3cjKQ8E = 4;
        [n1.ElementAttribute(TracingId = 262983U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "EBCI5sItoobLNa0A4s4yfT", Name = "__slot_EBCI5sItoobLNa0A4s4yfT")]
        public static int __slot_EBCI5sItoobLNa0A4s4yfT = 8;
        [n1.ElementAttribute(TracingId = 263023U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "TMcgEDG0I9CN7EGtKrfGBU", Name = "__slot_TMcgEDG0I9CN7EGtKrfGBU")]
        public static int __slot_TMcgEDG0I9CN7EGtKrfGBU = 2;
        [n1.ElementAttribute(TracingId = 263063U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "NWV4aNNgfx3MKwH6Zcn2F0", Name = "__slot_NWV4aNNgfx3MKwH6Zcn2F0")]
        public static int __slot_NWV4aNNgfx3MKwH6Zcn2F0 = 4;
        [n1.ElementAttribute(TracingId = 263103U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "JavKAQNI849QGzPQA59rFX", Name = "__slot_JavKAQNI849QGzPQA59rFX")]
        public static int __slot_JavKAQNI849QGzPQA59rFX = 8;
        [n1.ElementAttribute(TracingId = 263135U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "VkKAOiqlY6cNMinYuKWlBm", Name = "__slot_VkKAOiqlY6cNMinYuKWlBm")]
        public static int __slot_VkKAOiqlY6cNMinYuKWlBm = 1;
        [n1.ElementAttribute(TracingId = 263168U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "QeGnpyqv6oPQJLSWX5jZ7w", Name = "__slot_QeGnpyqv6oPQJLSWX5jZ7w")]
        public static int __slot_QeGnpyqv6oPQJLSWX5jZ7w = 2;
        [n1.ElementAttribute(TracingId = 263208U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "A8CajQE8mjROq08djrW5IL", Name = "__slot_A8CajQE8mjROq08djrW5IL")]
        public static int __slot_A8CajQE8mjROq08djrW5IL = 4;
        [n1.ElementAttribute(TracingId = 263248U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Gui8tjkv3gKPURNclP2duu", Name = "__slot_Gui8tjkv3gKPURNclP2duu")]
        public static int __slot_Gui8tjkv3gKPURNclP2duu = 8;
        [n1.ElementAttribute(TracingId = 263288U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Kx3xzQwEqnRQUsXZKYvD2K", Name = "__slot_Kx3xzQwEqnRQUsXZKYvD2K")]
        public static byte __slot_Kx3xzQwEqnRQUsXZKYvD2K = 0;
        [n1.ElementAttribute(TracingId = 263282U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "AkPiOfZ9TTeMBILcYVemhP", Name = "__slot_AkPiOfZ9TTeMBILcYVemhP")]
        public static byte __slot_AkPiOfZ9TTeMBILcYVemhP = 1;
        [n1.ElementAttribute(TracingId = 263333U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "NPj1aYpnjJ7LjAGRHi0zA5", Name = "__slot_NPj1aYpnjJ7LjAGRHi0zA5")]
        public static int __slot_NPj1aYpnjJ7LjAGRHi0zA5 = 2;
        [n1.ElementAttribute(TracingId = 263377U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "RyG1d3WQflTMWnHUYNmA3D", Name = "__slot_RyG1d3WQflTMWnHUYNmA3D")]
        public static int __slot_RyG1d3WQflTMWnHUYNmA3D = 4;
        [n1.ElementAttribute(TracingId = 263421U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "TshweuDXVPZPEpReURMdXO", Name = "__slot_TshweuDXVPZPEpReURMdXO")]
        public static int __slot_TshweuDXVPZPEpReURMdXO = 8;
        [n1.ElementAttribute(TracingId = 263465U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "LZdSUOBU1oTPOObNeWjiQF", Name = "__slot_LZdSUOBU1oTPOObNeWjiQF")]
        public static int __slot_LZdSUOBU1oTPOObNeWjiQF = 2;
        [n1.ElementAttribute(TracingId = 263509U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "G1jrlLFTBZaQCSOc3UNFTA", Name = "__slot_G1jrlLFTBZaQCSOc3UNFTA")]
        public static int __slot_G1jrlLFTBZaQCSOc3UNFTA = 4;
        [n1.ElementAttribute(TracingId = 263553U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "H1lRhh1BOEuO78McHrDlFD", Name = "__slot_H1lRhh1BOEuO78McHrDlFD")]
        public static int __slot_H1lRhh1BOEuO78McHrDlFD = 8;
        [n1.ElementAttribute(TracingId = 263624U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "SZRtccbSy3UPLa3zgwcg7x", Name = "__slot_SZRtccbSy3UPLa3zgwcg7x")]
        public static int __slot_SZRtccbSy3UPLa3zgwcg7x = 2;
        [n1.ElementAttribute(TracingId = 263668U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "N4gFkXbgoqyOUN5OVRzKXj", Name = "__slot_N4gFkXbgoqyOUN5OVRzKXj")]
        public static int __slot_N4gFkXbgoqyOUN5OVRzKXj = 4;
        [n1.ElementAttribute(TracingId = 263712U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "LRuNj6hhaHjQPU2Jw56yXa", Name = "__slot_LRuNj6hhaHjQPU2Jw56yXa")]
        public static int __slot_LRuNj6hhaHjQPU2Jw56yXa = 8;
        [n1.ElementAttribute(TracingId = 263774U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "HqixQ3IRYqhM3MTcTW60ML", Name = "__slot_HqixQ3IRYqhM3MTcTW60ML")]
        public static int __slot_HqixQ3IRYqhM3MTcTW60ML = 2;
        [n1.ElementAttribute(TracingId = 263825U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "I9h4XkCslkAMGPUuh0b5Gu", Name = "__slot_I9h4XkCslkAMGPUuh0b5Gu")]
        public static int __slot_I9h4XkCslkAMGPUuh0b5Gu = 4;
        [n1.ElementAttribute(TracingId = 263876U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "CYcu70nVzevNP7IDEOhaps", Name = "__slot_CYcu70nVzevNP7IDEOhaps")]
        public static int __slot_CYcu70nVzevNP7IDEOhaps = 8;
        [n1.ElementAttribute(TracingId = 263927U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "SH2s4Jm0Qm4LOx2167Xi5J", Name = "__slot_SH2s4Jm0Qm4LOx2167Xi5J")]
        public static int __slot_SH2s4Jm0Qm4LOx2167Xi5J = 2;
        [n1.ElementAttribute(TracingId = 263978U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "SIukfJ8Z2ssPddwx27eBQ2", Name = "__slot_SIukfJ8Z2ssPddwx27eBQ2")]
        public static int __slot_SIukfJ8Z2ssPddwx27eBQ2 = 4;
        [n1.ElementAttribute(TracingId = 264029U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "JH0uLgsTQAmQPIk4V77Ezx", Name = "__slot_JH0uLgsTQAmQPIk4V77Ezx")]
        public static int __slot_JH0uLgsTQAmQPIk4V77Ezx = 8;
        [n1.ElementAttribute(TracingId = 264107U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "LN7Mz2YVvf3NsEXeneQNlV", Name = "__slot_LN7Mz2YVvf3NsEXeneQNlV")]
        public static int __slot_LN7Mz2YVvf3NsEXeneQNlV = 2;
        [n1.ElementAttribute(TracingId = 264158U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Vev5OkLSsEEOGQ59NTEOVs", Name = "__slot_Vev5OkLSsEEOGQ59NTEOVs")]
        public static int __slot_Vev5OkLSsEEOGQ59NTEOVs = 4;
        [n1.ElementAttribute(TracingId = 264209U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "QmMJgjK5tGgPRqD5hkFQGJ", Name = "__slot_QmMJgjK5tGgPRqD5hkFQGJ")]
        public static int __slot_QmMJgjK5tGgPRqD5hkFQGJ = 8;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Builder.DictionaryBuilder.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n21.ImmutableDictionary<T, T2>.Builder CreateDefault<T, T2>()
        {
            var Result_0 = n21.ImmutableDictionary.CreateBuilder<T, T2>();
            return Result_0;
        }

        [n4.CreateNewAttribute]
        public static void Create<T, T2>(n1.NodeContext Node_Context, out n21.ImmutableDictionary<T, T2>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.CreateBuilder<T, T2>();
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T, T2>(n1.NodeContext Node_Context, n6.IEqualityComparer<T> Key_Comparer_In, out n21.ImmutableDictionary<T, T2>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.CreateBuilder<T, T2>(keyComparer: Key_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T, T2>(n1.NodeContext Node_Context, n6.IEqualityComparer<T> Key_Comparer_In, n6.IEqualityComparer<T2> Value_Comparer_In, out n21.ImmutableDictionary<T, T2>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableDictionary.CreateBuilder<T, T2>(keyComparer: Key_Comparer_In, valueComparer: Value_Comparer_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Builder.HashSetBuilder.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n21.ImmutableHashSet<T>.Builder CreateDefault<T>()
        {
            var Result_0 = n21.ImmutableHashSet.CreateBuilder<T>();
            return Result_0;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, out n21.ImmutableHashSet<T>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.CreateBuilder<T>();
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, n6.IEqualityComparer<T> Equality_Comparer_In, out n21.ImmutableHashSet<T>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableHashSet.CreateBuilder<T>(equalityComparer: Equality_Comparer_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Builder.SortedDictionaryBuilder.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create<T, T2>(n1.NodeContext Node_Context, out n21.ImmutableSortedDictionary<T, T2>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.CreateBuilder<T, T2>();
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T, T2>(n1.NodeContext Node_Context, n6.IComparer<T> Key_Comparer_In, out n21.ImmutableSortedDictionary<T, T2>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.CreateBuilder<T, T2>(keyComparer: Key_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T, T2>(n1.NodeContext Node_Context, n6.IComparer<T> Key_Comparer_In, n6.IEqualityComparer<T2> Value_Comparer_In, out n21.ImmutableSortedDictionary<T, T2>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.CreateBuilder<T, T2>(keyComparer: Key_Comparer_In, valueComparer: Value_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static n21.ImmutableSortedDictionary<T, T2>.Builder CreateDefault<T, T2>()
        {
            var Result_0 = n21.ImmutableSortedDictionary.CreateBuilder<T, T2>();
            return Result_0;
        }
    }
}

namespace _VL_Collections_.Collections.Builder.SortedSetBuilder.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, out n21.ImmutableSortedSet<T>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableSortedSet.CreateBuilder<T>();
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, n6.IComparer<T> Comparer_In, out n21.ImmutableSortedSet<T>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableSortedSet.CreateBuilder<T>(comparer: Comparer_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static n21.ImmutableSortedSet<T>.Builder CreateDefault<T>()
        {
            var Result_0 = n21.ImmutableSortedSet.CreateBuilder<T>();
            return Result_0;
        }
    }
}

namespace _VL_Collections_.Collections.Builder.ArrayBuilder.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n21.ImmutableArray<T>.Builder CreateDefault<T>()
        {
            int __pad_FBy4tiqqBMHOkfOuj9EQnj_0 = __slot_FBy4tiqqBMHOkfOuj9EQnj;
            var Result_1 = n21.ImmutableArray.CreateBuilder<T>(initialCapacity: __pad_FBy4tiqqBMHOkfOuj9EQnj_0);
            return Result_1;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, out n21.ImmutableArray<T>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableArray.CreateBuilder<T>();
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, int Initial_Capacity_In, out n21.ImmutableArray<T>.Builder Result_Out)
        {
            var Result_0 = n21.ImmutableArray.CreateBuilder<T>(initialCapacity: Initial_Capacity_In);
            Result_Out = Result_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 264297U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "FBy4tiqqBMHOkfOuj9EQnj", Name = "__slot_FBy4tiqqBMHOkfOuj9EQnj")]
        public static int __slot_FBy4tiqqBMHOkfOuj9EQnj = 0;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Builder.MutableArrayBuilder.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void AsMemory_H<T>(n5.ArrayBuilder<T> Input_In, out n5.ArrayBuilder<T> Output_Out, out n2.Memory<T> Result_Out)
        {
            var Result_0 = Input_In.AsMemory();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void AsSpan_H<T>(n5.ArrayBuilder<T> Input_In, out n5.ArrayBuilder<T> Output_Out, out n2.Span<T> Result_Out)
        {
            var Result_0 = Input_In.AsSpan();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Spread.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void FromBoolean(bool Value_In, out n5.Spread<byte> Output_Out)
        {
            n5.Spread<byte> __pin_group_Input_In_R6hBCLDAB3cOzFwF1ECJvS = default(n5.Spread<byte>);
            byte __pad_V6fcb3GAgjNP7DjfQwuCho_0 = __slot_V6fcb3GAgjNP7DjfQwuCho;
            byte __auto_1;
            if (Value_In)
            {
                byte __pad_EXd3NFNlRyhLx2wfL3T1qT_2 = __slot_EXd3NFNlRyhLx2wfL3T1qT;
                __auto_1 = __pad_EXd3NFNlRyhLx2wfL3T1qT_2;
            }
            else
            {
                __auto_1 = __pad_V6fcb3GAgjNP7DjfQwuCho_0;
            }

            var builder_3 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_R6hBCLDAB3cOzFwF1ECJvS, 1);
            builder_3.Add(__auto_1);
            var __pin_group_Input_In_R6hBCLDAB3cOzFwF1ECJvS_4 = builder_3.Commit();
            n7._Operations_.Cons<byte>(Input_In: __pin_group_Input_In_R6hBCLDAB3cOzFwF1ECJvS_4, Result_Out: out n5.Spread<byte> Result_5);
            Output_Out = Result_5;
            return;
        }

        public static void FromChar(char Value_In, bool As_Big_Endian_In, out n5.Spread<byte> Output_Out)
        {
            n24._Operations_.FromChar(Value_In: Value_In, As_Big_Endian_In: As_Big_Endian_In, Output_Out: out n5.SpreadBuilder<byte> Output_0);
            n24._Operations_.ToSpread<byte>(Input_In: Output_0, Output_Out: out n5.SpreadBuilder<byte> Output_1, Result_Out: out n5.Spread<byte> Result_2);
            Output_Out = Result_2;
            return;
        }

        public static void FromFloat32(float Value_In, bool As_Big_Endian_In, out n5.Spread<byte> Output_Out)
        {
            n24._Operations_.FromFloat32(Value_In: Value_In, As_Big_Endian_In: As_Big_Endian_In, Output_Out: out n5.SpreadBuilder<byte> Output_0);
            n24._Operations_.ToSpread<byte>(Input_In: Output_0, Output_Out: out n5.SpreadBuilder<byte> Output_1, Result_Out: out n5.Spread<byte> Result_2);
            Output_Out = Result_2;
            return;
        }

        public static void FromFloat64(double Value_In, bool As_Big_Endian_In, out n5.Spread<byte> Output_Out)
        {
            n24._Operations_.FromFloat64(Value_In: Value_In, As_Big_Endian_In: As_Big_Endian_In, Output_Out: out n5.SpreadBuilder<byte> Output_0);
            n24._Operations_.ToSpread<byte>(Input_In: Output_0, Output_Out: out n5.SpreadBuilder<byte> Output_1, Result_Out: out n5.Spread<byte> Result_2);
            Output_Out = Result_2;
            return;
        }

        public static void FromInt16(short Value_In, bool As_Big_Endian_In, out n5.Spread<byte> Output_Out)
        {
            n24._Operations_.FromInt16(Value_In: Value_In, As_Big_Endian_In: As_Big_Endian_In, Output_Out: out n5.SpreadBuilder<byte> Output_0);
            n24._Operations_.ToSpread<byte>(Input_In: Output_0, Output_Out: out n5.SpreadBuilder<byte> Output_1, Result_Out: out n5.Spread<byte> Result_2);
            Output_Out = Result_2;
            return;
        }

        public static void FromInt32(int Value_In, bool As_Big_Endian_In, out n5.Spread<byte> Output_Out)
        {
            n24._Operations_.FromInt32(Value_In: Value_In, As_Big_Endian_In: As_Big_Endian_In, Output_Out: out n5.SpreadBuilder<byte> Output_0);
            n24._Operations_.ToSpread<byte>(Input_In: Output_0, Output_Out: out n5.SpreadBuilder<byte> Output_1, Result_Out: out n5.Spread<byte> Result_2);
            Output_Out = Result_2;
            return;
        }

        public static void FromInt64(long Value_In, bool As_Big_Endian_In, out n5.Spread<byte> Output_Out)
        {
            n24._Operations_.FromInt64(Value_In: Value_In, As_Big_Endian_In: As_Big_Endian_In, Output_Out: out n5.SpreadBuilder<byte> Output_0);
            n24._Operations_.ToSpread<byte>(Input_In: Output_0, Output_Out: out n5.SpreadBuilder<byte> Output_1, Result_Out: out n5.Spread<byte> Result_2);
            Output_Out = Result_2;
            return;
        }

        public static void FromInt8(sbyte Value_In, out n5.Spread<byte> Output_Out)
        {
            n5.Spread<byte> __pin_group_Input_In_AZbiMtRpLUeQE6dm1hL92v = default(n5.Spread<byte>);
            var Result_0 = n10.IntegerConversions.ToByte(input: Value_In);
            var builder_1 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_AZbiMtRpLUeQE6dm1hL92v, 1);
            builder_1.Add(Result_0);
            var __pin_group_Input_In_AZbiMtRpLUeQE6dm1hL92v_2 = builder_1.Commit();
            n7._Operations_.Cons<byte>(Input_In: __pin_group_Input_In_AZbiMtRpLUeQE6dm1hL92v_2, Result_Out: out n5.Spread<byte> Result_3);
            Output_Out = Result_3;
            return;
        }

        public static void FromUInt16(ushort Value_In, bool As_Big_Endian_In, out n5.Spread<byte> Output_Out)
        {
            n24._Operations_.FromUInt16(Value_In: Value_In, As_Big_Endian_In: As_Big_Endian_In, Output_Out: out n5.SpreadBuilder<byte> Output_0);
            n24._Operations_.ToSpread<byte>(Input_In: Output_0, Output_Out: out n5.SpreadBuilder<byte> Output_1, Result_Out: out n5.Spread<byte> Result_2);
            Output_Out = Result_2;
            return;
        }

        public static void FromUInt32(uint Value_In, bool As_Big_Endian_In, out n5.Spread<byte> Output_Out)
        {
            n24._Operations_.FromUInt32(Value_In: Value_In, As_Big_Endian_In: As_Big_Endian_In, Output_Out: out n5.SpreadBuilder<byte> Output_0);
            n24._Operations_.ToSpread<byte>(Input_In: Output_0, Output_Out: out n5.SpreadBuilder<byte> Output_1, Result_Out: out n5.Spread<byte> Result_2);
            Output_Out = Result_2;
            return;
        }

        public static void FromUInt64(ulong Value_In, bool As_Big_Endian_In, out n5.Spread<byte> Output_Out)
        {
            n24._Operations_.FromUInt64(Value_In: Value_In, As_Big_Endian_In: As_Big_Endian_In, Output_Out: out n5.SpreadBuilder<byte> Output_0);
            n24._Operations_.ToSpread<byte>(Input_In: Output_0, Output_Out: out n5.SpreadBuilder<byte> Output_1, Result_Out: out n5.Spread<byte> Result_2);
            Output_Out = Result_2;
            return;
        }

        public static void ToBoolean([n4.SerializedDefaultValueAttribute("0", false)] n5.Spread<byte> Input_In, int Index_In, out bool Result_Out)
        {
            var Result_0 = n10.BinaryUtils.ToBoolean(input: Input_In, index: Index_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToChar([n4.SerializedDefaultValueAttribute("0, 0", false)] n5.Spread<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out char Result_Out)
        {
            var Result_0 = n10.BinaryUtils.ToChar(input: Input_In, startIndex: Start_Index_In, inputIsBigEndian: Input_Is_Big_Endian_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToFloat32([n4.SerializedDefaultValueAttribute("0, 0, 0, 0", false)] n5.Spread<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out float Result_Out)
        {
            var Result_0 = n10.BinaryUtils.ToFloat32(input: Input_In, startIndex: Start_Index_In, inputIsBigEndian: Input_Is_Big_Endian_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToFloat64([n4.SerializedDefaultValueAttribute("0, 0, 0, 0, 0, 0, 0, 0", false)] n5.Spread<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out double Result_Out)
        {
            var Result_0 = n10.BinaryUtils.ToFloat64(input: Input_In, startIndex: Start_Index_In, inputIsBigEndian: Input_Is_Big_Endian_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToInt16([n4.SerializedDefaultValueAttribute("0, 0", false)] n5.Spread<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out short Result_Out)
        {
            var Result_0 = n10.BinaryUtils.ToInt16(input: Input_In, startIndex: Start_Index_In, inputIsBigEndian: Input_Is_Big_Endian_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToInt32([n4.SerializedDefaultValueAttribute("0, 0, 0, 0", false)] n5.Spread<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out int Result_Out)
        {
            var Result_0 = n10.BinaryUtils.ToInt32(input: Input_In, startIndex: Start_Index_In, inputIsBigEndian: Input_Is_Big_Endian_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToInt64([n4.SerializedDefaultValueAttribute("0, 0, 0, 0, 0, 0, 0, 0", false)] n5.Spread<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out long Result_Out)
        {
            var Result_0 = n10.BinaryUtils.ToInt64(input: Input_In, startIndex: Start_Index_In, inputIsBigEndian: Input_Is_Big_Endian_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToInt8([n4.SerializedDefaultValueAttribute("0", false)] n5.Spread<byte> Input_In, int Index_In, out sbyte Result_Out)
        {
            var Result_0 = n10.BinaryUtils.ToInt8(input: Input_In, index: Index_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToUInt16([n4.SerializedDefaultValueAttribute("0, 0", false)] n5.Spread<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out ushort Result_Out)
        {
            var Result_0 = n10.BinaryUtils.ToUInt16(input: Input_In, startIndex: Start_Index_In, inputIsBigEndian: Input_Is_Big_Endian_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToUInt32([n4.SerializedDefaultValueAttribute("0, 0, 0, 0", false)] n5.Spread<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out uint Result_Out)
        {
            var Result_0 = n10.BinaryUtils.ToUInt32(input: Input_In, startIndex: Start_Index_In, inputIsBigEndian: Input_Is_Big_Endian_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToUInt64([n4.SerializedDefaultValueAttribute("0, 0, 0, 0, 0, 0, 0, 0", false)] n5.Spread<byte> Input_In, int Start_Index_In, bool Input_Is_Big_Endian_In, out ulong Result_Out)
        {
            var Result_0 = n10.BinaryUtils.ToUInt64(input: Input_In, startIndex: Start_Index_In, inputIsBigEndian: Input_Is_Big_Endian_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateCircleSpread(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector2 Size_In, [n4.SerializedDefaultValueAttribute("1", false)] float Factor_In, float Phase_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            n5.Spread<n26.Vector2> __cp_LWwNpByhhZDQMsCcAlmAGY = n7._Operations_.CreateDefault<n26.Vector2>();
            float Input_2_0 = (float)Count_In;
            var builder_13 = n4.CollectionBuilders.GetBuilder(__cp_LWwNpByhhZDQMsCcAlmAGY, 16);
            n5.Spread<n26.Vector2> output_14;
            try
            {
                for (var i_1 = 0; i_1 < Count_In; i_1++)
                {
                    var i_local_2 = i_1;
                    float __pad_UpkjHgobUAKOyHL7cpQZco_3 = __slot_UpkjHgobUAKOyHL7cpQZco;
                    float __pad_Ffa2IPVXjY0QXsJkzpIXgO_4 = __slot_Ffa2IPVXjY0QXsJkzpIXgO;
                    float Input_5 = (float)i_local_2;
                    var Output_6 = (float)Input_5 / Input_2_0;
                    var Output_7 = Output_6 * Factor_In;
                    var Output_8 = Output_7 + Phase_In;
                    n29._Operations_.FromPolar(Angle_In: Output_8, Radius_In: __pad_UpkjHgobUAKOyHL7cpQZco_3, Output_Out: out n26.Vector2 Output_9);
                    n27.Vector2Nodes.Scale(input: ref Size_In, scalar: __pad_Ffa2IPVXjY0QXsJkzpIXgO_4, output: out n26.Vector2 Output_10);
                    n27.Vector2Nodes.Multiply(left: ref Output_9, right: ref Output_10, result: out n26.Vector2 Output_11);
                    n26.Vector2.Add(left: ref Output_11, right: ref Center_In, result: out n26.Vector2 Output_12);
                    builder_13.Add(Output_12);
                }
            }
            finally
            {
                output_14 = builder_13.Commit();
            }

            Output_Out = output_14;
            return;
        }

        public static void CreateISpread(int Start_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<int> Output_Out)
        {
            n5.Spread<int> __cp_AxluoaXRXiONn35Ao44fjH = n7._Operations_.CreateDefault<int>();
            var builder_3 = n4.CollectionBuilders.GetBuilder(__cp_AxluoaXRXiONn35Ao44fjH, 16);
            n5.Spread<int> output_4;
            try
            {
                for (var i_0 = 0; i_0 < Count_In; i_0++)
                {
                    var i_local_1 = i_0;
                    var Output_2 = i_local_1 + Start_In;
                    builder_3.Add(Output_2);
                }
            }
            finally
            {
                output_4 = builder_3.Commit();
            }

            Output_Out = output_4;
            return;
        }

        public static void CreateRandomSpread__2D(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector2 Size_In, [n4.SerializedDefaultValueAttribute("0", false)] int Seed_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            n5.Spread<n26.Vector2> __cp_IxwAjLGYvbFLY8prmuMu0m = n7._Operations_.CreateDefault<n26.Vector2>();
            float __pad_BsjicetXGw6QZtVENwUPtf_0 = __slot_BsjicetXGw6QZtVENwUPtf;
            int __pad_Vt6z7ltHiOjLxhzkH5zCDw_1 = __slot_Vt6z7ltHiOjLxhzkH5zCDw;
            var Output_2 = Count_In * __pad_Vt6z7ltHiOjLxhzkH5zCDw_1;
            float Width_3 = 1F;
            var Result_4 = n25.SpreadGenerators.RandomSpread(center: __pad_BsjicetXGw6QZtVENwUPtf_0, width: Width_3, seed: Seed_In, count: Output_2);
            n6.IEnumerable<float> Values_5 = (n6.IEnumerable<float>)Result_4;
            var Result_6 = n25.ValuesToVectorsNodes.ValuesToVectors2D(values: Values_5);
            n13._Operations_.UnitRange<n26.Vector2, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Range_Out: out n27.Range<n26.Vector2> Range_7);
            n30._Operations_.Range_Join_Center_Width<n26.Vector2, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Center_In: Center_In, Width_In: Size_In, Output_Out: out n27.Range<n26.Vector2> Output_8);
            var builder_14 = n4.CollectionBuilders.GetBuilder(__cp_IxwAjLGYvbFLY8prmuMu0m, 16);
            n5.Spread<n26.Vector2> output_15;
            try
            {
                var i_11 = 0;
                foreach (var item_9 in n4.CollectionExtensions.AsSpan(Result_6))
                {
                    var splicer_10 = item_9;
                    var i_local_12 = i_11;
                    n13._Operations_.Map_Range<n26.Vector2, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: splicer_10, From_In: Range_7, To_In: Output_8, Output_Out: out n26.Vector2 Output_13);
                    builder_14.Add(Output_13);
                    i_11++;
                }
            }
            finally
            {
                output_15 = builder_14.Commit();
            }

            Output_Out = output_15;
            return;
        }

        public static void CreateRandomSpread__3D(n26.Vector3 Center_In, [n4.SerializedDefaultValueAttribute("1, 1, 1", false)] n26.Vector3 Size_In, [n4.SerializedDefaultValueAttribute("0", false)] int Seed_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<n26.Vector3> Output_Out)
        {
            n5.Spread<n26.Vector3> __cp_E2SNo8jCk4PPJ8RCZNVCC5 = n7._Operations_.CreateDefault<n26.Vector3>();
            float __pad_LvjpH9ct2vSNxQyXHtFSvV_0 = __slot_LvjpH9ct2vSNxQyXHtFSvV;
            int __pad_C11j5RZ7YS1Ose69sHI8TJ_1 = __slot_C11j5RZ7YS1Ose69sHI8TJ;
            var Output_2 = Count_In * __pad_C11j5RZ7YS1Ose69sHI8TJ_1;
            float Width_3 = 1F;
            var Result_4 = n25.SpreadGenerators.RandomSpread(center: __pad_LvjpH9ct2vSNxQyXHtFSvV_0, width: Width_3, seed: Seed_In, count: Output_2);
            n6.IEnumerable<float> Values_5 = (n6.IEnumerable<float>)Result_4;
            var Result_6 = n25.ValuesToVectorsNodes.ValuesToVectors3D(values: Values_5);
            n13._Operations_.UnitRange<n26.Vector3, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Range_Out: out n27.Range<n26.Vector3> Range_7);
            n30._Operations_.Range_Join_Center_Width<n26.Vector3, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Center_In: Center_In, Width_In: Size_In, Output_Out: out n27.Range<n26.Vector3> Output_8);
            var builder_14 = n4.CollectionBuilders.GetBuilder(__cp_E2SNo8jCk4PPJ8RCZNVCC5, 16);
            n5.Spread<n26.Vector3> output_15;
            try
            {
                var i_11 = 0;
                foreach (var item_9 in n4.CollectionExtensions.AsSpan(Result_6))
                {
                    var splicer_10 = item_9;
                    var i_local_12 = i_11;
                    n13._Operations_.Map_Range<n26.Vector3, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: splicer_10, From_In: Range_7, To_In: Output_8, Output_Out: out n26.Vector3 Output_13);
                    builder_14.Add(Output_13);
                    i_11++;
                }
            }
            finally
            {
                output_15 = builder_14.Commit();
            }

            Output_Out = output_15;
            return;
        }

        public static void CreateRectangleSpread(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector2 Size_In, [n4.SerializedDefaultValueAttribute("1", false)] int Subdivision_Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            n5.Spread<n26.Vector2> __pin_group_Input_In_NZwbpDQCneTNHPC1NENkfH = default(n5.Spread<n26.Vector2>);
            var Result_0 = n27.RectangleNodes.FromCenterSize(center: ref Center_In, size: ref Size_In);
            n31._Operations_.Corners(Input_In: Result_0, Top_Left_Out: out n26.Vector2 Top_Left_1, Top_Right_Out: out n26.Vector2 Top_Right_2, Bottom_Right_Out: out n26.Vector2 Bottom_Right_3, Bottom_Left_Out: out n26.Vector2 Bottom_Left_4);
            var builder_5 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_NZwbpDQCneTNHPC1NENkfH, 5);
            builder_5.Add(Top_Left_1);
            builder_5.Add(Top_Right_2);
            builder_5.Add(Bottom_Right_3);
            builder_5.Add(Bottom_Left_4);
            builder_5.Add(Top_Left_1);
            var __pin_group_Input_In_NZwbpDQCneTNHPC1NENkfH_6 = builder_5.Commit();
            n7._Operations_.Cons<n26.Vector2>(Input_In: __pin_group_Input_In_NZwbpDQCneTNHPC1NENkfH_6, Result_Out: out n5.Spread<n26.Vector2> Result_7);
            var __fallback___8 = n1.ServiceRegistry.Current;
            n7._Operations_.Pairwise<n26.Vector2, n5.Spread<n26.Vector2>>(Input_In: Result_7, Selector_In: (n26.Vector2 Input_1_In_10, n26.Vector2 Input_2_In_11) =>
            {
                using var __current_9 = __fallback___8.MakeCurrentIfNone();
                n5.Spread<n26.Vector2> __cp_ODBzco4Yp7WNNVlkMUHAi3 = n7._Operations_.CreateDefault<n26.Vector2>();
                int __pad_SsZPDsphdOmLZngeIg7x3S_12 = __slot_SsZPDsphdOmLZngeIg7x3S;
                var Output_13 = Subdivision_Count_In + __pad_SsZPDsphdOmLZngeIg7x3S_12;
                float Input_2_14 = (float)Output_13;
                var builder_20 = n4.CollectionBuilders.GetBuilder(__cp_ODBzco4Yp7WNNVlkMUHAi3, 16);
                n5.Spread<n26.Vector2> output_21;
                try
                {
                    for (var i_15 = 0; i_15 < Output_13; i_15++)
                    {
                        var i_local_16 = i_15;
                        float Input_17 = (float)i_local_16;
                        var Output_18 = (float)Input_17 / Input_2_14;
                        var Output_19 = n27.Vector2Nodes.Lerp(input: ref Input_1_In_10, input2: ref Input_2_In_11, scalar: Output_18);
                        builder_20.Add(Output_19);
                    }
                }
                finally
                {
                    output_21 = builder_20.Commit();
                }

                return output_21;
            }

            , Output_Out: out n5.Spread<n5.Spread<n26.Vector2>> Output_22);
            n7._Operations_.Flatten<n5.Spread<n5.Spread<n26.Vector2>>, n26.Vector2>(Input_In: Output_22, Output_Out: out n5.Spread<n26.Vector2> Output_23);
            Output_Out = Output_23;
            return;
        }

        public static void CreateRoundRectSpread(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector2 Size_In, [n4.SerializedDefaultValueAttribute("1", false)] float Corner_Radius_In, [n4.SerializedDefaultValueAttribute("1", false)] int Corner_Resolution_In, [n4.SerializedDefaultValueAttribute("1", false)] int Subdivision_Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            float __pad_VQFLHyY2pcKPWnrveTa16q_0 = __slot_VQFLHyY2pcKPWnrveTa16q;
            int __pad_RPF7fas2W1KMnC7YVrcwy2_1 = __slot_RPF7fas2W1KMnC7YVrcwy2;
            var Result_2 = Corner_Radius_In != __pad_VQFLHyY2pcKPWnrveTa16q_0;
            var Result_3 = Corner_Resolution_In > __pad_RPF7fas2W1KMnC7YVrcwy2_1;
            var Output_4 = Result_2 && Result_3;
            var Output_5 = !Output_4;
            n5.Spread<n26.Vector2> Output_6;
            if (Output_5)
            {
                n32._Operations_.CreateRectangleSpread(Center_In: Center_In, Size_In: Size_In, Subdivision_Count_In: Subdivision_Count_In, Output_Out: out n5.Spread<n26.Vector2> Output_7);
                Output_6 = Output_7;
            }
            else
            {
                Output_6 = n7._Operations_.CreateDefault<n26.Vector2>();
            }

            float Input_8 = (float)Corner_Resolution_In;
            n5.Spread<n26.Vector2> Output_9;
            if (Output_4)
            {
                n5.Spread<n6.IEnumerable<n26.Vector2>> __pin_group_Input_In_Cpcm3G8pCwmQGL5olN4LrZ = default(n5.Spread<n6.IEnumerable<n26.Vector2>>);
                float __pad_UguWUsaH1S3MOXi5scX86v_10 = __slot_UguWUsaH1S3MOXi5scX86v;
                float __pad_P4Y1iqVedbiQSBc6QlzW5i_11 = __slot_P4Y1iqVedbiQSBc6QlzW5i;
                float __pad_VmMJQd2lOUZLJsQo2wKOub_12 = __slot_VmMJQd2lOUZLJsQo2wKOub;
                float __pad_Q2eVvSNGInXQLbdZuYHEQ1_13 = __slot_Q2eVvSNGInXQLbdZuYHEQ1;
                float __pad_FuwHXWnxjaFNCp3AsCgAh3_14 = __slot_FuwHXWnxjaFNCp3AsCgAh3;
                float __pad_Km9khMY5B05NHSQmtLgHje_15 = __slot_Km9khMY5B05NHSQmtLgHje;
                float __pad_VYPZfJ3BmRCNv9XoNcoUtr_16 = __slot_VYPZfJ3BmRCNv9XoNcoUtr;
                float __pad_Qn0UtceVCd9P3qHA1Sut8p_17 = __slot_Qn0UtceVCd9P3qHA1Sut8p;
                float __pad_Iia2GYSrbOwMGMPpcrzJ0E_18 = __slot_Iia2GYSrbOwMGMPpcrzJ0E;
                float __pad_E6Dd7rmjoe1Ph6zSCDZqEg_19 = __slot_E6Dd7rmjoe1Ph6zSCDZqEg;
                float __pad_PRBRtt4aRNSMx8ZAIn2bsv_20 = __slot_PRBRtt4aRNSMx8ZAIn2bsv;
                var Result_21 = n27.RectangleNodes.FromCenterSize(center: ref Center_In, size: ref Size_In);
                n31._Operations_.Corners(Input_In: Result_21, Top_Left_Out: out n26.Vector2 Top_Left_22, Top_Right_Out: out n26.Vector2 Top_Right_23, Bottom_Right_Out: out n26.Vector2 Bottom_Right_24, Bottom_Left_Out: out n26.Vector2 Bottom_Left_25);
                n27.Vector2Nodes.Scale(input: ref Size_In, scalar: Corner_Radius_In, output: out n26.Vector2 Output_26);
                n26.Vector2 Center_27 = n33._Operations_.CreateDefault();
                var Result_28 = n27.RectangleNodes.FromCenterSize(center: ref Center_27, size: ref Output_26);
                n31._Operations_.Corners(Input_In: Result_28, Top_Left_Out: out n26.Vector2 Top_Left_29, Top_Right_Out: out n26.Vector2 Top_Right_30, Bottom_Right_Out: out n26.Vector2 Bottom_Right_31, Bottom_Left_Out: out n26.Vector2 Bottom_Left_32);
                n26.Vector2.Subtract(left: ref Top_Left_22, right: ref Top_Left_29, result: out n26.Vector2 Output_33);
                n26.Vector2.Subtract(left: ref Bottom_Left_25, right: ref Bottom_Left_32, result: out n26.Vector2 Output_34);
                var Output_35 = Input_8 - __pad_VmMJQd2lOUZLJsQo2wKOub_12;
                var Output_36 = (float)__pad_P4Y1iqVedbiQSBc6QlzW5i_11 / Output_35;
                var Output_37 = Output_36 * __pad_PRBRtt4aRNSMx8ZAIn2bsv_20;
                var Output_38 = __pad_UguWUsaH1S3MOXi5scX86v_10 - Output_37;
                var Output_39 = Output_35 + __pad_Q2eVvSNGInXQLbdZuYHEQ1_13;
                var Output_40 = (float)__pad_FuwHXWnxjaFNCp3AsCgAh3_14 / Output_39;
                var Output_41 = Output_40 * __pad_Km9khMY5B05NHSQmtLgHje_15;
                var Output_42 = __pad_VYPZfJ3BmRCNv9XoNcoUtr_16 + Output_41;
                n32._Operations_.CreateCircleSpread(Center_In: Output_34, Size_In: Output_26, Factor_In: Output_38, Phase_In: Output_42, Count_In: Corner_Resolution_In, Output_Out: out n5.Spread<n26.Vector2> Output_43);
                var Output_44 = __pad_Qn0UtceVCd9P3qHA1Sut8p_17 + Output_41;
                n26.Vector2.Subtract(left: ref Bottom_Right_24, right: ref Bottom_Right_31, result: out n26.Vector2 Output_45);
                n32._Operations_.CreateCircleSpread(Center_In: Output_45, Size_In: Output_26, Factor_In: Output_38, Phase_In: Output_44, Count_In: Corner_Resolution_In, Output_Out: out n5.Spread<n26.Vector2> Output_46);
                n6.IEnumerable<n26.Vector2> Input_3_47 = (n6.IEnumerable<n26.Vector2>)Output_46;
                var Output_48 = __pad_Iia2GYSrbOwMGMPpcrzJ0E_18 + Output_41;
                n32._Operations_.CreateCircleSpread(Center_In: Output_33, Size_In: Output_26, Factor_In: Output_38, Phase_In: Output_48, Count_In: Corner_Resolution_In, Output_Out: out n5.Spread<n26.Vector2> Output_49);
                n6.IEnumerable<n26.Vector2> Input_50 = (n6.IEnumerable<n26.Vector2>)Output_49;
                n26.Vector2.Subtract(left: ref Top_Right_23, right: ref Top_Right_30, result: out n26.Vector2 Output_51);
                var Output_52 = __pad_E6Dd7rmjoe1Ph6zSCDZqEg_19 + Output_41;
                n32._Operations_.CreateCircleSpread(Center_In: Output_51, Size_In: Output_26, Factor_In: Output_38, Phase_In: Output_52, Count_In: Corner_Resolution_In, Output_Out: out n5.Spread<n26.Vector2> Output_53);
                n6.IEnumerable<n26.Vector2> Input_2_54 = (n6.IEnumerable<n26.Vector2>)Output_53;
                n6.IEnumerable<n26.Vector2> Input_4_55 = (n6.IEnumerable<n26.Vector2>)Output_43;
                var builder_56 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_Cpcm3G8pCwmQGL5olN4LrZ, 4);
                builder_56.Add(Input_50);
                builder_56.Add(Input_2_54);
                builder_56.Add(Input_3_47);
                builder_56.Add(Input_4_55);
                var __pin_group_Input_In_Cpcm3G8pCwmQGL5olN4LrZ_57 = builder_56.Commit();
                n7._Operations_.Concat<n26.Vector2>(Input_In: __pin_group_Input_In_Cpcm3G8pCwmQGL5olN4LrZ_57, Output_Out: out n5.Spread<n26.Vector2> Output_58);
                Output_9 = Output_58;
            }
            else
            {
                Output_9 = Output_6;
            }

            Output_Out = Output_9;
            return;
        }

        public static void CreateSpiralSpread(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector2 Size_In, [n4.SerializedDefaultValueAttribute("1", false)] float Factor_In, float Phase_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            n5.Spread<n26.Vector2> __cp_BJWOUIXDC5WODn7dSGQ5h2 = n7._Operations_.CreateDefault<n26.Vector2>();
            float Input_2_0 = (float)Count_In;
            var builder_12 = n4.CollectionBuilders.GetBuilder(__cp_BJWOUIXDC5WODn7dSGQ5h2, 16);
            n5.Spread<n26.Vector2> output_13;
            try
            {
                for (var i_1 = 0; i_1 < Count_In; i_1++)
                {
                    var i_local_2 = i_1;
                    float __pad_DrS4cPaQLDoNVbKJWtJ8ez_3 = __slot_DrS4cPaQLDoNVbKJWtJ8ez;
                    float Input_4 = (float)i_local_2;
                    var Output_5 = (float)Input_4 / Input_2_0;
                    var Output_6 = Output_5 * Factor_In;
                    var Output_7 = Output_6 + Phase_In;
                    n29._Operations_.FromPolar(Angle_In: Output_6, Radius_In: Output_7, Output_Out: out n26.Vector2 Output_8);
                    n27.Vector2Nodes.Scale(input: ref Size_In, scalar: __pad_DrS4cPaQLDoNVbKJWtJ8ez_3, output: out n26.Vector2 Output_9);
                    n27.Vector2Nodes.Multiply(left: ref Output_8, right: ref Output_9, result: out n26.Vector2 Output_10);
                    n26.Vector2.Add(left: ref Output_10, right: ref Center_In, result: out n26.Vector2 Output_11);
                    builder_12.Add(Output_11);
                }
            }
            finally
            {
                output_13 = builder_12.Commit();
            }

            Output_Out = output_13;
            return;
        }

        public static void CreateStarSpread(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("0.25", false)] float Radius_1_In, [n4.SerializedDefaultValueAttribute("0.5", false)] float Radius_2_In, float Phase_In, [n4.SerializedDefaultValueAttribute("3", false)] int Spike_Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            n5.Spread<float> __pin_group_Input_In_CxOmAitnFgbOy2mvDm7sKV = default(n5.Spread<float>);
            n5.Spread<n26.Vector2> __cp_UjPlB4Mk3paNKI8vj1sHK1 = n7._Operations_.CreateDefault<n26.Vector2>();
            int __pad_Sl8Hs2zdn4UM727P2pqk8o_0 = __slot_Sl8Hs2zdn4UM727P2pqk8o;
            var Output_1 = Spike_Count_In * __pad_Sl8Hs2zdn4UM727P2pqk8o_0;
            var builder_2 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_CxOmAitnFgbOy2mvDm7sKV, 2);
            builder_2.Add(Radius_1_In);
            builder_2.Add(Radius_2_In);
            var __pin_group_Input_In_CxOmAitnFgbOy2mvDm7sKV_3 = builder_2.Commit();
            n7._Operations_.Cons<float>(Input_In: __pin_group_Input_In_CxOmAitnFgbOy2mvDm7sKV_3, Result_Out: out n5.Spread<float> Result_4);
            float Input_2_5 = (float)Output_1;
            var builder_16 = n4.CollectionBuilders.GetBuilder(__cp_UjPlB4Mk3paNKI8vj1sHK1, 16);
            n5.Spread<n26.Vector2> output_17;
            try
            {
                var Radius_Count_7 = Result_4.Count;
                var __safeGuard_8 = Radius_Count_7 >= Output_1;
                for (var i_6 = 0; i_6 < Output_1; i_6++)
                {
                    var splicer_9 = __safeGuard_8 ? Result_4[i_6] : Radius_Count_7 > 0 ? Result_4[i_6 % Radius_Count_7] : default(float);
                    var i_local_10 = i_6;
                    float Input_11 = (float)i_local_10;
                    var Output_12 = (float)Input_11 / Input_2_5;
                    var Output_13 = Output_12 + Phase_In;
                    n29._Operations_.FromPolar(Angle_In: Output_13, Radius_In: splicer_9, Output_Out: out n26.Vector2 Output_14);
                    n26.Vector2.Add(left: ref Output_14, right: ref Center_In, result: out n26.Vector2 Output_15);
                    builder_16.Add(Output_15);
                }
            }
            finally
            {
                output_17 = builder_16.Commit();
            }

            Output_Out = output_17;
            return;
        }

        public static void CreateRandomSpread([n4.SerializedDefaultValueAttribute("0", false)] float Center_In, [n4.SerializedDefaultValueAttribute("1", false)] float Width_In, [n4.SerializedDefaultValueAttribute("0", false)] int Seed_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<float> Output_Out)
        {
            var Result_0 = n25.SpreadGenerators.RandomSpread(center: Center_In, width: Width_In, seed: Seed_In, count: Count_In);
            Output_Out = Result_0;
            return;
        }

        public static void GetInternalArray<T>(n5.Spread<T> Input_In, out T[] Result_Out)
        {
            var Result_0 = n5.Spread.GetInternalArray<T>(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRandomSpread__4D([n4.SerializedDefaultValueAttribute("0, 0, 0, 0", false)] n26.Vector4 Center_In, [n4.SerializedDefaultValueAttribute("1, 1, 1, 1", false)] n26.Vector4 Size_In, [n4.SerializedDefaultValueAttribute("0", false)] int Seed_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<n26.Vector4> Output_Out)
        {
            n5.Spread<n26.Vector4> __cp_E8a5yvWt3eLN0Fj5CHlOGW = n7._Operations_.CreateDefault<n26.Vector4>();
            float __pad_LnnMyRNgYPRQXuSrP9JI7H_0 = __slot_LnnMyRNgYPRQXuSrP9JI7H;
            int __pad_ObcovdnzbozQBZJ8qjfW3D_1 = __slot_ObcovdnzbozQBZJ8qjfW3D;
            var Output_2 = Count_In * __pad_ObcovdnzbozQBZJ8qjfW3D_1;
            float Width_3 = 1F;
            var Result_4 = n25.SpreadGenerators.RandomSpread(center: __pad_LnnMyRNgYPRQXuSrP9JI7H_0, width: Width_3, seed: Seed_In, count: Output_2);
            n6.IEnumerable<float> Values_5 = (n6.IEnumerable<float>)Result_4;
            var Result_6 = n25.ValuesToVectorsNodes.ValuesToVectors4D(values: Values_5);
            n13._Operations_.UnitRange<n26.Vector4, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Range_Out: out n27.Range<n26.Vector4> Range_7);
            n30._Operations_.Range_Join_Center_Width<n26.Vector4, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Center_In: Center_In, Width_In: Size_In, Output_Out: out n27.Range<n26.Vector4> Output_8);
            var builder_14 = n4.CollectionBuilders.GetBuilder(__cp_E8a5yvWt3eLN0Fj5CHlOGW, 16);
            n5.Spread<n26.Vector4> output_15;
            try
            {
                var i_11 = 0;
                foreach (var item_9 in n4.CollectionExtensions.AsSpan(Result_6))
                {
                    var splicer_10 = item_9;
                    var i_local_12 = i_11;
                    n13._Operations_.Map_Range<n26.Vector4, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: splicer_10, From_In: Range_7, To_In: Output_8, Output_Out: out n26.Vector4 Output_13);
                    builder_14.Add(Output_13);
                    i_11++;
                }
            }
            finally
            {
                output_15 = builder_14.Commit();
            }

            Output_Out = output_15;
            return;
        }

        public static void CreateLinearSpread_Range<T, AdM>(n27.Range<T> Range_In, n35.LinearSpreadAlignment Alignment_In, float Phase_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<T> Output_Out)
            where AdM : struct, n18.IAdaptiveCreateDefault<n5.Spread<T>>, n19.IAdaptiveOperatorMulitply_Scale<T>, n19.IAdaptiveOperatorPlus<T>, n19.IAdaptiveLerp<T>
        {
            var w_0 = default(AdM);
            Range_In.Split(from: out T From_1, to: out T To_2);
            float Input_2_3 = (float)Count_In;
            float Input_2_4 = (float)Count_In;
            float Input_2_5 = (float)Count_In;
            float Input_2_6 = (float)Count_In;
            var __fallback___7 = n1.ServiceRegistry.Current;
            n32._Operations_.LinearSpreadAlignmentSwitch<n5.Spread<T>>(Alignment_In: Alignment_In, Centered_In: () =>
            {
                using var __current_8 = __fallback___7.MakeCurrentIfNone();
                n5.Spread<T> __cp_Ql6j7o0ynXxMuTmgwmXeyy = n7._Operations_.CreateDefault<T>();
                float Input_9 = 0.5F;
                var Output_10 = (float)Input_9 / Input_2_4;
                var Output_11 = Phase_In + Output_10;
                var builder_20 = n4.CollectionBuilders.GetBuilder(__cp_Ql6j7o0ynXxMuTmgwmXeyy, 16);
                n5.Spread<T> output_21;
                try
                {
                    for (var i_12 = 0; i_12 < Count_In; i_12++)
                    {
                        var i_local_13 = i_12;
                        float Input_14 = (float)i_local_13;
                        var Output_15 = (float)Input_14 / Input_2_3;
                        var Output_16 = Output_11 + Output_15;
                        n10.Float32Extensions.FracSawtooth(input: Output_16, wholePart: out int Whole_Part_17, fractionalPart: out float Fractional_Part_18);
                        w_0.Lerp(Input_In: From_1, Input_2_In: To_2, Scalar_In: Fractional_Part_18, Output_Out: out T Output_19);
                        builder_20.Add(Output_19);
                    }
                }
                finally
                {
                    output_21 = builder_20.Commit();
                }

                return output_21;
            }

            , Left_In: () =>
            {
                using var __current_22 = __fallback___7.MakeCurrentIfNone();
                n5.Spread<T> __cp_CuDInzeDK1iPHQV1qnFf38 = n7._Operations_.CreateDefault<T>();
                var builder_31 = n4.CollectionBuilders.GetBuilder(__cp_CuDInzeDK1iPHQV1qnFf38, 16);
                n5.Spread<T> output_32;
                try
                {
                    for (var i_23 = 0; i_23 < Count_In; i_23++)
                    {
                        var i_local_24 = i_23;
                        float Input_25 = (float)i_local_24;
                        var Output_26 = (float)Input_25 / Input_2_5;
                        var Output_27 = Phase_In + Output_26;
                        n10.Float32Extensions.FracSawtooth(input: Output_27, wholePart: out int Whole_Part_28, fractionalPart: out float Fractional_Part_29);
                        w_0.Lerp(Input_In: From_1, Input_2_In: To_2, Scalar_In: Fractional_Part_29, Output_Out: out T Output_30);
                        builder_31.Add(Output_30);
                    }
                }
                finally
                {
                    output_32 = builder_31.Commit();
                }

                return output_32;
            }

            , Right_In: () =>
            {
                using var __current_33 = __fallback___7.MakeCurrentIfNone();
                n5.Spread<T> __cp_GZlM1UCFcEmO9iuljcCMFY = n7._Operations_.CreateDefault<T>();
                var builder_48 = n4.CollectionBuilders.GetBuilder(__cp_GZlM1UCFcEmO9iuljcCMFY, 16);
                n5.Spread<T> output_49;
                try
                {
                    for (var i_34 = 0; i_34 < Count_In; i_34++)
                    {
                        var i_local_35 = i_34;
                        int Input_2_36 = 1;
                        var Output_37 = i_local_35 + Input_2_36;
                        float Input_38 = (float)Output_37;
                        var Output_39 = (float)Input_38 / Input_2_6;
                        var Output_40 = Phase_In + Output_39;
                        float Input_41 = 1F;
                        var Output_42 = Input_41 - Output_40;
                        n10.Float32Extensions.FracSawtooth(input: Output_42, wholePart: out int Whole_Part_43, fractionalPart: out float Fractional_Part_44);
                        float Input_45 = 1F;
                        var Output_46 = Input_45 - Fractional_Part_44;
                        w_0.Lerp(Input_In: From_1, Input_2_In: To_2, Scalar_In: Output_46, Output_Out: out T Output_47);
                        builder_48.Add(Output_47);
                    }
                }
                finally
                {
                    output_49 = builder_48.Commit();
                }

                return output_49;
            }

            , Block_In: () =>
            {
                using var __current_50 = __fallback___7.MakeCurrentIfNone();
                n5.Spread<T> __cp_Gr0JuaXHGA5O0vkaElfKRa = n7._Operations_.CreateDefault<T>();
                n5.Spread<T> __pin_group_Input_In_J3t1d7kzbPyOz1FyyQq244 = default(n5.Spread<T>);
                n5.Spread<n5.Spread<T>> __pin_group_Input_In_Ol9geBFONw2QR2VQUENJnQ = default(n5.Spread<n5.Spread<T>>);
                int Input_2_51 = 1;
                var Result_52 = Count_In == Input_2_51;
                int Index_53 = n2.Convert.ToInt32(Result_52);
                int Input_2_54 = 1;
                var Output_55 = Count_In - Input_2_54;
                float Input_2_56 = (float)Output_55;
                var builder_62 = n4.CollectionBuilders.GetBuilder(__cp_Gr0JuaXHGA5O0vkaElfKRa, 16);
                n5.Spread<T> output_63;
                try
                {
                    for (var i_57 = 0; i_57 < Count_In; i_57++)
                    {
                        var i_local_58 = i_57;
                        float Input_59 = (float)i_local_58;
                        var Output_60 = (float)Input_59 / Input_2_56;
                        w_0.Lerp(Input_In: From_1, Input_2_In: To_2, Scalar_In: Output_60, Output_Out: out T Output_61);
                        builder_62.Add(Output_61);
                    }
                }
                finally
                {
                    output_63 = builder_62.Commit();
                }

                n30._Operations_.GetCenter<T, AdM>(Input_In: Range_In, Center_Out: out T Center_64);
                var builder_65 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_J3t1d7kzbPyOz1FyyQq244, 1);
                builder_65.Add(Center_64);
                var __pin_group_Input_In_J3t1d7kzbPyOz1FyyQq244_66 = builder_65.Commit();
                n7._Operations_.Cons<T>(Input_In: __pin_group_Input_In_J3t1d7kzbPyOz1FyyQq244_66, Result_Out: out n5.Spread<T> Result_67);
                var builder_68 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_Ol9geBFONw2QR2VQUENJnQ, 2);
                builder_68.Add(output_63);
                builder_68.Add(Result_67);
                var __pin_group_Input_In_Ol9geBFONw2QR2VQUENJnQ_69 = builder_68.Commit();
                n34._Operations_.Switch<n5.Spread<T>, AdM>(Index_In: Index_53, Input_In: __pin_group_Input_In_Ol9geBFONw2QR2VQUENJnQ_69, Output_Out: out n5.Spread<T> Output_70);
                return Output_70;
            }

            , Result_Out: out n5.Spread<T> Result_71);
            Output_Out = Result_71;
            return;
        }

        public static void LinearSpreadAlignmentSwitch<T>(n35.LinearSpreadAlignment Alignment_In, n2.Func<T> Centered_In, n2.Func<T> Left_In, n2.Func<T> Right_In, n2.Func<T> Block_In, out T Result_Out)
        {
            var Result_0 = n25.SpreadGenerators.LinearSpreadAlignmentSwitch<T>(alignment: Alignment_In, centered: Centered_In, left: Left_In, right: Right_In, block: Block_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateLinearSpread(float Center_In, [n4.SerializedDefaultValueAttribute("1", false)] float Width_In, n35.LinearSpreadAlignment Alignment_In, float Phase_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<float> Output_Out)
        {
            n30._Operations_.Range_Join_Center_Width<float, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Center_In: Center_In, Width_In: Width_In, Output_Out: out n27.Range<float> Output_0);
            n32._Operations_.CreateLinearSpread_Range<float, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Range_In: Output_0, Alignment_In: Alignment_In, Phase_In: Phase_In, Count_In: Count_In, Output_Out: out n5.Spread<float> Output_1);
            Output_Out = Output_1;
            return;
        }

        public static void CreateGridSpread__2D(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector2 Width_In, n35.LinearSpreadAlignment Alignment_In, n26.Vector2 Phase_In, n5.SpreadBuilder<n26.Vector2> Builder_To_Fill_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Clear_Builder_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Int2 Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            n36._Operations_.Split(Input_In: Count_In, X_Out: out int X_0, Y_Out: out int Y_1);
            var Output_2 = Builder_To_Fill_In;
            if (Clear_Builder_In)
            {
                n24._Operations_.Clear<n26.Vector2>(Input_In: Builder_To_Fill_In, Output_Out: out Output_2);
            }

            n27.Vector2Nodes.Vector(input: ref Center_In, x: out float X_3, y: out float Y_4);
            n27.Vector2Nodes.Vector(input: ref Width_In, x: out float X_5, y: out float Y_6);
            float Input_2_7 = -1F;
            var Output_8 = Y_6 * Input_2_7;
            n27.Vector2Nodes.Vector(input: ref Phase_In, x: out float X_9, y: out float Y_10);
            n32._Operations_.CreateLinearSpread(Center_In: Y_4, Width_In: Output_8, Alignment_In: Alignment_In, Phase_In: Y_10, Count_In: Y_1, Output_Out: out n5.Spread<float> Output_11);
            n5.SpreadBuilder<n26.Vector2> accumulator_13 = Output_2;
            var i_15 = 0;
            foreach (var item_12 in n4.CollectionExtensions.AsSpan(Output_11))
            {
                var splicer_14 = item_12;
                var i_local_16 = i_15;
                n32._Operations_.CreateLinearSpread(Center_In: X_3, Width_In: X_5, Alignment_In: Alignment_In, Phase_In: X_9, Count_In: X_0, Output_Out: out n5.Spread<float> Output_17);
                n5.SpreadBuilder<n26.Vector2> accumulator_19 = accumulator_13;
                var i_21 = 0;
                foreach (var item_18 in n4.CollectionExtensions.AsSpan(Output_17))
                {
                    var splicer_20 = item_18;
                    var i_local_22 = i_21;
                    var Output_23 = new n26.Vector2(x: splicer_20, y: splicer_14);
                    n24._Operations_.Add<n26.Vector2>(Input_In: accumulator_19, Item_In: Output_23, Output_Out: out n5.SpreadBuilder<n26.Vector2> Output_24);
                    accumulator_19 = Output_24;
                    i_21++;
                }

                accumulator_13 = accumulator_19;
                i_15++;
            }

            n24._Operations_.ToSpread<n26.Vector2>(Input_In: accumulator_13, Output_Out: out n5.SpreadBuilder<n26.Vector2> Output_25, Result_Out: out n5.Spread<n26.Vector2> Result_26);
            Output_Out = Result_26;
            return;
        }

        public static void CreateGridSpread__3D(n26.Vector3 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector3 Width_In, n35.LinearSpreadAlignment Alignment_In, n26.Vector3 Phase_In, n5.SpreadBuilder<n26.Vector3> Builder_To_Fill_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Clear_Builder_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Int3 Count_In, out n5.Spread<n26.Vector3> Output_Out)
        {
            n37._Operations_.Split(Input_In: Count_In, X_Out: out int X_0, Y_Out: out int Y_1, Z_Out: out int Z_2);
            var Output_3 = Builder_To_Fill_In;
            if (Clear_Builder_In)
            {
                n24._Operations_.Clear<n26.Vector3>(Input_In: Builder_To_Fill_In, Output_Out: out Output_3);
            }

            n27.Vector3Nodes.Vector(input: ref Center_In, x: out float X_4, y: out float Y_5, z: out float Z_6);
            n27.Vector3Nodes.Vector(input: ref Width_In, x: out float X_7, y: out float Y_8, z: out float Z_9);
            n27.Vector3Nodes.Vector(input: ref Phase_In, x: out float X_10, y: out float Y_11, z: out float Z_12);
            n32._Operations_.CreateLinearSpread(Center_In: Z_6, Width_In: Z_9, Alignment_In: Alignment_In, Phase_In: Z_12, Count_In: Z_2, Output_Out: out n5.Spread<float> Output_13);
            float Input_2_14 = -1F;
            var Output_15 = Y_8 * Input_2_14;
            n5.SpreadBuilder<n26.Vector3> accumulator_17 = Output_3;
            var i_19 = 0;
            foreach (var item_16 in n4.CollectionExtensions.AsSpan(Output_13))
            {
                var splicer_18 = item_16;
                var i_local_20 = i_19;
                n32._Operations_.CreateLinearSpread(Center_In: Y_5, Width_In: Output_15, Alignment_In: Alignment_In, Phase_In: Y_11, Count_In: Y_1, Output_Out: out n5.Spread<float> Output_21);
                n5.SpreadBuilder<n26.Vector3> accumulator_23 = accumulator_17;
                var i_25 = 0;
                foreach (var item_22 in n4.CollectionExtensions.AsSpan(Output_21))
                {
                    var splicer_24 = item_22;
                    var i_local_26 = i_25;
                    n32._Operations_.CreateLinearSpread(Center_In: X_4, Width_In: X_7, Alignment_In: Alignment_In, Phase_In: X_10, Count_In: X_0, Output_Out: out n5.Spread<float> Output_27);
                    var accumulator_34 = n24._Operations_.CreateDefault<n26.Vector3>();
                    var i_30 = 0;
                    foreach (var item_28 in n4.CollectionExtensions.AsSpan(Output_27))
                    {
                        var splicer_29 = item_28;
                        var i_local_31 = i_30;
                        var Output_32 = new n26.Vector3(x: splicer_29, y: splicer_24, z: splicer_18);
                        n24._Operations_.Add<n26.Vector3>(Input_In: accumulator_23, Item_In: Output_32, Output_Out: out n5.SpreadBuilder<n26.Vector3> Output_33);
                        accumulator_34 = Output_33;
                        i_30++;
                    }

                    accumulator_23 = accumulator_34;
                    i_25++;
                }

                accumulator_17 = accumulator_23;
                i_19++;
            }

            n24._Operations_.ToSpread<n26.Vector3>(Input_In: accumulator_17, Output_Out: out n5.SpreadBuilder<n26.Vector3> Output_35, Result_Out: out n5.Spread<n26.Vector3> Result_36);
            Output_Out = Result_36;
            return;
        }

        public static void CreateHexGridSpread__2D(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("0.09999999", false)] float Radius_In, bool Even_Lower_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Int2 Count_In, out n5.Spread<n26.Vector2> Result_Out)
        {
            n5.Spread<n26.Vector2> __cp_VN6iSqSrM56QK34OqRiFuS = n7._Operations_.CreateDefault<n26.Vector2>();
            n5.Spread<n5.Spread<n26.Vector2>> __cp_Ge9y57JijBWLFKuN7I9KjS = n7._Operations_.CreateDefault<n5.Spread<n26.Vector2>>();
            float __pad_SpbPCiT8mjiPXCJgxOXB1r_0 = __slot_SpbPCiT8mjiPXCJgxOXB1r;
            float __pad_UUMnqbj8RAUL5XC7SKP1pr_1 = __slot_UUMnqbj8RAUL5XC7SKP1pr;
            float __pad_Lt91sDNLTWKNow9v6FOMRM_2 = __slot_Lt91sDNLTWKNow9v6FOMRM;
            float __pad_TxVkScgMmQ0L4ENfgNi3wi_3 = __slot_TxVkScgMmQ0L4ENfgNi3wi;
            float __pad_DXTtw6iLsCTMLNEBxQPvWW_4 = __slot_DXTtw6iLsCTMLNEBxQPvWW;
            int __pad_OY7MQab57oJMnTAhOD4GIu_5 = __slot_OY7MQab57oJMnTAhOD4GIu;
            float __pad_NmeWrZHl0S0PzgQ7Bmmnwk_6 = __slot_NmeWrZHl0S0PzgQ7Bmmnwk;
            float __pad_Tt0kJVjlA0KN9rbCcXIAuI_7 = __slot_Tt0kJVjlA0KN9rbCcXIAuI;
            int __pad_Ef1SYc5c6NDP4GqGlmLEVY_8 = __slot_Ef1SYc5c6NDP4GqGlmLEVY;
            int __pad_FyOsc0PylomL7eUQYFhzW4_9 = __slot_FyOsc0PylomL7eUQYFhzW4;
            var Output_10 = (float)__pad_SpbPCiT8mjiPXCJgxOXB1r_0 / __pad_UUMnqbj8RAUL5XC7SKP1pr_1;
            var Output_11 = Output_10 * __pad_TxVkScgMmQ0L4ENfgNi3wi_3;
            var Output_12 = Output_11 * __pad_Lt91sDNLTWKNow9v6FOMRM_2;
            n38._Operations_.SineWave(Phase_In: Output_10, Output_Out: out float Output_13);
            var Output_14 = Radius_In * Output_13;
            var Output_15 = Output_14 * __pad_DXTtw6iLsCTMLNEBxQPvWW_4;
            n29._Operations_.FromPolar(Angle_In: Output_12, Radius_In: Output_15, Output_Out: out n26.Vector2 Output_16);
            n36._Operations_.Split(Input_In: Count_In, X_Out: out int X_17, Y_Out: out int Y_18);
            var Output_19 = X_17 - __pad_OY7MQab57oJMnTAhOD4GIu_5;
            float Input_20 = (float)Output_19;
            var Output_21 = Input_20 * __pad_NmeWrZHl0S0PzgQ7Bmmnwk_6;
            var Output_22 = Output_21 * Radius_In;
            int Input_2_23 = n2.Convert.ToInt32(Even_Lower_In);
            n29._Operations_.FromPolar(Angle_In: Output_11, Radius_In: Output_15, Output_Out: out n26.Vector2 Output_24);
            n14._Operations_.Switch_Boolean<n26.Vector2>(Condition_In: Even_Lower_In, Input_In: Output_16, Input_2_In: Output_24, Output_Out: out n26.Vector2 Output_25);
            n26.Vector2 accumulator_27 = n33._Operations_.CreateDefault();
            var builder_37 = n4.CollectionBuilders.GetBuilder(__cp_VN6iSqSrM56QK34OqRiFuS, 16);
            n5.Spread<n26.Vector2> output_38;
            try
            {
                for (var i_26 = 0; i_26 < X_17; i_26++)
                {
                    var i_local_28 = i_26;
                    int __pad_NBIEHax1Xc2Noavb0SnDFa_29 = __slot_NBIEHax1Xc2Noavb0SnDFa;
                    var Output_30 = i_local_28 + Input_2_23;
                    var Output_31 = Output_30 % __pad_NBIEHax1Xc2Noavb0SnDFa_29;
                    int Input_2_32 = 0;
                    var Result_33 = Output_31 == Input_2_32;
                    n14._Operations_.Switch_Boolean<n26.Vector2>(Condition_In: Result_33, Input_In: Output_24, Input_2_In: Output_16, Output_Out: out n26.Vector2 Output_34);
                    n26.Vector2.Add(left: ref accumulator_27, right: ref Output_34, result: out n26.Vector2 Output_35);
                    n26.Vector2.Subtract(left: ref Output_35, right: ref Output_25, result: out n26.Vector2 Output_36);
                    builder_37.Add(Output_36);
                    accumulator_27 = Output_35;
                }
            }
            finally
            {
                output_38 = builder_37.Commit();
            }

            var Output_39 = Y_18 - __pad_Ef1SYc5c6NDP4GqGlmLEVY_8;
            float Input_40 = (float)Output_39;
            var Output_41 = Output_15 * __pad_Tt0kJVjlA0KN9rbCcXIAuI_7;
            var Output_42 = Input_40 * Output_41;
            var Output_43 = Output_41 * __pad_Tt0kJVjlA0KN9rbCcXIAuI_7;
            var Result_44 = X_17 > __pad_FyOsc0PylomL7eUQYFhzW4_9;
            var Output_45 = Output_42;
            if (Result_44)
            {
                var Output_46 = Output_42 - Output_43;
                Output_45 = Output_46;
            }

            var builder_61 = n4.CollectionBuilders.GetBuilder(__cp_Ge9y57JijBWLFKuN7I9KjS, 16);
            n5.Spread<n5.Spread<n26.Vector2>> output_62;
            try
            {
                for (var i_47 = 0; i_47 < Y_18; i_47++)
                {
                    var i_local_48 = i_47;
                    n5.Spread<n26.Vector2> __cp_CPgolr57tlMMWJ1RGkr0f4 = n7._Operations_.CreateDefault<n26.Vector2>();
                    float Input_49 = (float)i_local_48;
                    var builder_59 = n4.CollectionBuilders.GetBuilder(__cp_CPgolr57tlMMWJ1RGkr0f4, 16);
                    n5.Spread<n26.Vector2> output_60;
                    try
                    {
                        var i_52 = 0;
                        foreach (var item_50 in n4.CollectionExtensions.AsSpan(output_38))
                        {
                            var splicer_51 = item_50;
                            var i_local_53 = i_52;
                            var Output_54 = Input_49 * Output_15;
                            var Output_55 = Output_54 - Output_45;
                            var Output_56 = new n26.Vector2(x: Output_22, y: Output_55);
                            n26.Vector2.Subtract(left: ref splicer_51, right: ref Output_56, result: out n26.Vector2 Output_57);
                            n26.Vector2.Add(left: ref Output_57, right: ref Center_In, result: out n26.Vector2 Output_58);
                            builder_59.Add(Output_58);
                            i_52++;
                        }
                    }
                    finally
                    {
                        output_60 = builder_59.Commit();
                    }

                    builder_61.Add(output_60);
                }
            }
            finally
            {
                output_62 = builder_61.Commit();
            }

            n7._Operations_.Flatten<n5.Spread<n5.Spread<n26.Vector2>>, n26.Vector2>(Input_In: output_62, Output_Out: out n5.Spread<n26.Vector2> Output_63);
            Result_Out = Output_63;
            return;
        }

        [n1.ElementAttribute(TracingId = 264358U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "V6fcb3GAgjNP7DjfQwuCho", Name = "__slot_V6fcb3GAgjNP7DjfQwuCho")]
        public static byte __slot_V6fcb3GAgjNP7DjfQwuCho = 0;
        [n1.ElementAttribute(TracingId = 264352U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "EXd3NFNlRyhLx2wfL3T1qT", Name = "__slot_EXd3NFNlRyhLx2wfL3T1qT")]
        public static byte __slot_EXd3NFNlRyhLx2wfL3T1qT = 1;
        [n1.ElementAttribute(TracingId = 267094U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "UpkjHgobUAKOyHL7cpQZco", Name = "__slot_UpkjHgobUAKOyHL7cpQZco")]
        public static float __slot_UpkjHgobUAKOyHL7cpQZco = 1F;
        [n1.ElementAttribute(TracingId = 267095U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Ffa2IPVXjY0QXsJkzpIXgO", Name = "__slot_Ffa2IPVXjY0QXsJkzpIXgO")]
        public static float __slot_Ffa2IPVXjY0QXsJkzpIXgO = 0.49999994F;
        [n1.ElementAttribute(TracingId = 267258U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "BsjicetXGw6QZtVENwUPtf", Name = "__slot_BsjicetXGw6QZtVENwUPtf")]
        public static float __slot_BsjicetXGw6QZtVENwUPtf = 0.5F;
        [n1.ElementAttribute(TracingId = 267221U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Vt6z7ltHiOjLxhzkH5zCDw", Name = "__slot_Vt6z7ltHiOjLxhzkH5zCDw")]
        public static int __slot_Vt6z7ltHiOjLxhzkH5zCDw = 2;
        [n1.ElementAttribute(TracingId = 267321U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "LvjpH9ct2vSNxQyXHtFSvV", Name = "__slot_LvjpH9ct2vSNxQyXHtFSvV")]
        public static float __slot_LvjpH9ct2vSNxQyXHtFSvV = 0.5F;
        [n1.ElementAttribute(TracingId = 267286U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "C11j5RZ7YS1Ose69sHI8TJ", Name = "__slot_C11j5RZ7YS1Ose69sHI8TJ")]
        public static int __slot_C11j5RZ7YS1Ose69sHI8TJ = 3;
        [n1.ElementAttribute(TracingId = 267348U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "SsZPDsphdOmLZngeIg7x3S", Name = "__slot_SsZPDsphdOmLZngeIg7x3S")]
        public static int __slot_SsZPDsphdOmLZngeIg7x3S = 1;
        [n1.ElementAttribute(TracingId = 267419U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "VQFLHyY2pcKPWnrveTa16q", Name = "__slot_VQFLHyY2pcKPWnrveTa16q")]
        public static float __slot_VQFLHyY2pcKPWnrveTa16q = 0F;
        [n1.ElementAttribute(TracingId = 267420U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "RPF7fas2W1KMnC7YVrcwy2", Name = "__slot_RPF7fas2W1KMnC7YVrcwy2")]
        public static int __slot_RPF7fas2W1KMnC7YVrcwy2 = 1;
        [n1.ElementAttribute(TracingId = 267454U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "UguWUsaH1S3MOXi5scX86v", Name = "__slot_UguWUsaH1S3MOXi5scX86v")]
        public static float __slot_UguWUsaH1S3MOXi5scX86v = 0.25F;
        [n1.ElementAttribute(TracingId = 267453U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "P4Y1iqVedbiQSBc6QlzW5i", Name = "__slot_P4Y1iqVedbiQSBc6QlzW5i")]
        public static float __slot_P4Y1iqVedbiQSBc6QlzW5i = 1F;
        [n1.ElementAttribute(TracingId = 267456U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "VmMJQd2lOUZLJsQo2wKOub", Name = "__slot_VmMJQd2lOUZLJsQo2wKOub")]
        public static float __slot_VmMJQd2lOUZLJsQo2wKOub = 1F;
        [n1.ElementAttribute(TracingId = 267463U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Q2eVvSNGInXQLbdZuYHEQ1", Name = "__slot_Q2eVvSNGInXQLbdZuYHEQ1")]
        public static float __slot_Q2eVvSNGInXQLbdZuYHEQ1 = 0F;
        [n1.ElementAttribute(TracingId = 267462U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "FuwHXWnxjaFNCp3AsCgAh3", Name = "__slot_FuwHXWnxjaFNCp3AsCgAh3")]
        public static float __slot_FuwHXWnxjaFNCp3AsCgAh3 = 1F;
        [n1.ElementAttribute(TracingId = 267461U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Km9khMY5B05NHSQmtLgHje", Name = "__slot_Km9khMY5B05NHSQmtLgHje")]
        public static float __slot_Km9khMY5B05NHSQmtLgHje = 0.125F;
        [n1.ElementAttribute(TracingId = 267455U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "VYPZfJ3BmRCNv9XoNcoUtr", Name = "__slot_VYPZfJ3BmRCNv9XoNcoUtr")]
        public static float __slot_VYPZfJ3BmRCNv9XoNcoUtr = 0.25F;
        [n1.ElementAttribute(TracingId = 267458U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Qn0UtceVCd9P3qHA1Sut8p", Name = "__slot_Qn0UtceVCd9P3qHA1Sut8p")]
        public static float __slot_Qn0UtceVCd9P3qHA1Sut8p = 0F;
        [n1.ElementAttribute(TracingId = 267457U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Iia2GYSrbOwMGMPpcrzJ0E", Name = "__slot_Iia2GYSrbOwMGMPpcrzJ0E")]
        public static float __slot_Iia2GYSrbOwMGMPpcrzJ0E = 0.50000006F;
        [n1.ElementAttribute(TracingId = 267459U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "E6Dd7rmjoe1Ph6zSCDZqEg", Name = "__slot_E6Dd7rmjoe1Ph6zSCDZqEg")]
        public static float __slot_E6Dd7rmjoe1Ph6zSCDZqEg = 0.7499997F;
        [n1.ElementAttribute(TracingId = 267460U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "PRBRtt4aRNSMx8ZAIn2bsv", Name = "__slot_PRBRtt4aRNSMx8ZAIn2bsv")]
        public static float __slot_PRBRtt4aRNSMx8ZAIn2bsv = 0.125F;
        [n1.ElementAttribute(TracingId = 267688U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "DrS4cPaQLDoNVbKJWtJ8ez", Name = "__slot_DrS4cPaQLDoNVbKJWtJ8ez")]
        public static float __slot_DrS4cPaQLDoNVbKJWtJ8ez = 0.49999994F;
        [n1.ElementAttribute(TracingId = 267760U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Sl8Hs2zdn4UM727P2pqk8o", Name = "__slot_Sl8Hs2zdn4UM727P2pqk8o")]
        public static int __slot_Sl8Hs2zdn4UM727P2pqk8o = 2;
        [n1.ElementAttribute(TracingId = 267914U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "LnnMyRNgYPRQXuSrP9JI7H", Name = "__slot_LnnMyRNgYPRQXuSrP9JI7H")]
        public static float __slot_LnnMyRNgYPRQXuSrP9JI7H = 0.5F;
        [n1.ElementAttribute(TracingId = 267879U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "ObcovdnzbozQBZJ8qjfW3D", Name = "__slot_ObcovdnzbozQBZJ8qjfW3D")]
        public static int __slot_ObcovdnzbozQBZJ8qjfW3D = 4;
        [n1.ElementAttribute(TracingId = 268493U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "SpbPCiT8mjiPXCJgxOXB1r", Name = "__slot_SpbPCiT8mjiPXCJgxOXB1r")]
        public static float __slot_SpbPCiT8mjiPXCJgxOXB1r = 1F;
        [n1.ElementAttribute(TracingId = 268494U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "UUMnqbj8RAUL5XC7SKP1pr", Name = "__slot_UUMnqbj8RAUL5XC7SKP1pr")]
        public static float __slot_UUMnqbj8RAUL5XC7SKP1pr = 6F;
        [n1.ElementAttribute(TracingId = 268495U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Lt91sDNLTWKNow9v6FOMRM", Name = "__slot_Lt91sDNLTWKNow9v6FOMRM")]
        public static float __slot_Lt91sDNLTWKNow9v6FOMRM = -1F;
        [n1.ElementAttribute(TracingId = 268496U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "TxVkScgMmQ0L4ENfgNi3wi", Name = "__slot_TxVkScgMmQ0L4ENfgNi3wi")]
        public static float __slot_TxVkScgMmQ0L4ENfgNi3wi = 0.5F;
        [n1.ElementAttribute(TracingId = 268497U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "DXTtw6iLsCTMLNEBxQPvWW", Name = "__slot_DXTtw6iLsCTMLNEBxQPvWW")]
        public static float __slot_DXTtw6iLsCTMLNEBxQPvWW = 2F;
        [n1.ElementAttribute(TracingId = 268498U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "OY7MQab57oJMnTAhOD4GIu", Name = "__slot_OY7MQab57oJMnTAhOD4GIu")]
        public static int __slot_OY7MQab57oJMnTAhOD4GIu = 1;
        [n1.ElementAttribute(TracingId = 268499U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "NmeWrZHl0S0PzgQ7Bmmnwk", Name = "__slot_NmeWrZHl0S0PzgQ7Bmmnwk")]
        public static float __slot_NmeWrZHl0S0PzgQ7Bmmnwk = 0.75F;
        [n1.ElementAttribute(TracingId = 268500U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Tt0kJVjlA0KN9rbCcXIAuI", Name = "__slot_Tt0kJVjlA0KN9rbCcXIAuI")]
        public static float __slot_Tt0kJVjlA0KN9rbCcXIAuI = 0.5F;
        [n1.ElementAttribute(TracingId = 268501U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Ef1SYc5c6NDP4GqGlmLEVY", Name = "__slot_Ef1SYc5c6NDP4GqGlmLEVY")]
        public static int __slot_Ef1SYc5c6NDP4GqGlmLEVY = 1;
        [n1.ElementAttribute(TracingId = 268502U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "FyOsc0PylomL7eUQYFhzW4", Name = "__slot_FyOsc0PylomL7eUQYFhzW4")]
        public static int __slot_FyOsc0PylomL7eUQYFhzW4 = 1;
        [n1.ElementAttribute(TracingId = 268580U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "NBIEHax1Xc2Noavb0SnDFa", Name = "__slot_NBIEHax1Xc2Noavb0SnDFa")]
        public static int __slot_NBIEHax1Xc2Noavb0SnDFa = 2;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Mutable.MutableList.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.List<T> CreateDefault<T>()
        {
            int __pad_H1BVllIKabEOiKJB4o6Fci_0 = __slot_H1BVllIKabEOiKJB4o6Fci;
            var Output_1 = new n6.List<T>(capacity: __pad_H1BVllIKabEOiKJB4o6Fci_0);
            return Output_1;
        }

        [n1.ElementAttribute(TracingId = 264843U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "H1BVllIKabEOiKJB4o6Fci", Name = "__slot_H1BVllIKabEOiKJB4o6Fci")]
        public static int __slot_H1BVllIKabEOiKJB4o6Fci = 0;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Mutable.MutableDictionary.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.Dictionary<T, T2> CreateDefault<T, T2>()
        {
            int __pad_FoPfiyGA2BSLixOTvy4bEe_0 = __slot_FoPfiyGA2BSLixOTvy4bEe;
            var Output_1 = new n6.Dictionary<T, T2>(capacity: __pad_FoPfiyGA2BSLixOTvy4bEe_0);
            return Output_1;
        }

        public static void FromSequence<T, T2>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n6.Dictionary<T2, T> Result_Out)
        {
            var Result_0 = n39.Enumerable.ToDictionary<T, T2>(source: Input_In, keySelector: Key_Selector_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2, T3>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, n2.Func<T, T3> Element_Selector_In, out n6.Dictionary<T2, T3> Result_Out)
        {
            var Result_0 = n39.Enumerable.ToDictionary<T, T2, T3>(source: Input_In, keySelector: Key_Selector_In, elementSelector: Element_Selector_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, n6.IEqualityComparer<T2> Comparer_In, out n6.Dictionary<T2, T> Result_Out)
        {
            var Result_0 = n39.Enumerable.ToDictionary<T, T2>(source: Input_In, keySelector: Key_Selector_In, comparer: Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2, T3>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, n2.Func<T, T3> Element_Selector_In, n6.IEqualityComparer<T2> Comparer_In, out n6.Dictionary<T2, T3> Result_Out)
        {
            var Result_0 = n39.Enumerable.ToDictionary<T, T2, T3>(source: Input_In, keySelector: Key_Selector_In, elementSelector: Element_Selector_In, comparer: Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void Cons<T>(n6.Dictionary<string, T> Input_In, out n6.Dictionary<string, T> Output_Out)
        {
            Output_Out = Input_In;
            return;
        }

        public static void Decons<T>(n6.Dictionary<string, T> Input_In, out n6.Dictionary<string, T> Output_Out)
        {
            Output_Out = Input_In;
            return;
        }

        [n1.ElementAttribute(TracingId = 264859U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "FoPfiyGA2BSLixOTvy4bEe", Name = "__slot_FoPfiyGA2BSLixOTvy4bEe")]
        public static int __slot_FoPfiyGA2BSLixOTvy4bEe = 0;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Mutable.MutableHashSet.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.HashSet<T> CreateDefault<T>()
        {
            var Output_0 = new n6.HashSet<T>();
            return Output_0;
        }
    }
}

namespace _VL_Collections_.Collections.Mutable.MutableQueue.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.Queue<T> CreateDefault<T>()
        {
            int __pad_O9IdPIQuK29PzvdJceEYAb_0 = __slot_O9IdPIQuK29PzvdJceEYAb;
            var Output_1 = new n6.Queue<T>(capacity: __pad_O9IdPIQuK29PzvdJceEYAb_0);
            return Output_1;
        }

        [n1.ElementAttribute(TracingId = 264953U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "O9IdPIQuK29PzvdJceEYAb", Name = "__slot_O9IdPIQuK29PzvdJceEYAb")]
        public static int __slot_O9IdPIQuK29PzvdJceEYAb = 0;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Mutable.MutableStack.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.Stack<T> CreateDefault<T>()
        {
            int __pad_DV57CXsFXh4LP2XRrh0eCL_0 = __slot_DV57CXsFXh4LP2XRrh0eCL;
            var Output_1 = new n6.Stack<T>(capacity: __pad_DV57CXsFXh4LP2XRrh0eCL_0);
            return Output_1;
        }

        [n1.ElementAttribute(TracingId = 264966U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "DV57CXsFXh4LP2XRrh0eCL", Name = "__slot_DV57CXsFXh4LP2XRrh0eCL")]
        public static int __slot_DV57CXsFXh4LP2XRrh0eCL = 0;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Mutable.MutableLinkedList.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.LinkedList<T> CreateDefault<T>()
        {
            var Output_0 = new n6.LinkedList<T>();
            return Output_0;
        }
    }
}

namespace _VL_Collections_.Collections.Mutable.MutableLinkedListNode.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.LinkedListNode<T> CreateDefault<T, AdM>()
            where AdM : struct, n18.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(Output_Out: out T Output_1);
            var Output_2 = new n6.LinkedListNode<T>(value: Output_1);
            return Output_2;
        }
    }
}

namespace _VL_Collections_.Collections.Mutable.MutableObservableCollection.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n40.ObservableCollection<T> CreateDefault<T>()
        {
            var Output_0 = new n40.ObservableCollection<T>();
            return Output_0;
        }

        public static void Count<T>(n40.ObservableCollection<T> Input_In, out n40.ObservableCollection<T> Output_Out, out int Count_Out)
        {
            var Count_0 = Input_In.Count;
            n40.Collection<T> __pad_Taph9mvREoaMPj70KGNM1v_1 = Input_In;
            Output_Out = Input_In;
            Count_Out = Count_0;
            return;
        }

        public static void GetItem<T>(n40.ObservableCollection<T> Input_In, int Index_In, out n40.ObservableCollection<T> Output_Out, out T Item_Out)
        {
            var Item_0 = Input_In[Index_In];
            n40.Collection<T> __pad_D9pBBSuuz4AOkzQgeiYRHi_1 = Input_In;
            Output_Out = Input_In;
            Item_Out = Item_0;
            return;
        }

        public static void SetItem<T>(n40.ObservableCollection<T> Input_In, int Index_In, T Value_In, out n40.ObservableCollection<T> Output_Out)
        {
            Input_In[Index_In] = Value_In;
            n40.Collection<T> __pad_DPUoRCqclpKPAgU0YmHz0C_0 = Input_In;
            Output_Out = Input_In;
            return;
        }

        public static void Add<T>(n40.Collection<T> Input_In, T Item_In, out n40.Collection<T> Output_2_Out)
        {
            Input_In.Add(item: Item_In);
            n40.Collection<T> __pad_TNqvFk3TjnrOlEGMgpajgf_0 = Input_In;
            Output_2_Out = Input_In;
            return;
        }

        public static void Clear<T>(n40.Collection<T> Input_In, out n40.Collection<T> Output_2_Out)
        {
            Input_In.Clear();
            n40.Collection<T> __pad_HqTAm2HahelQMFhaOsptZB_0 = Input_In;
            Output_2_Out = Input_In;
            return;
        }

        public static void Contains<T>(n40.Collection<T> Input_In, T Item_In, out n40.Collection<T> Output_2_Out, out bool Result_Out)
        {
            var Result_0 = Input_In.Contains(item: Item_In);
            n40.Collection<T> __pad_NZT3zZlwB7RPufKHto6OIF_1 = Input_In;
            Output_2_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void CopyTo<T>(n40.Collection<T> Input_In, T[] Array_In, int Index_In, out n40.Collection<T> Output_2_Out)
        {
            Input_In.CopyTo(array: Array_In, index: Index_In);
            n40.Collection<T> __pad_CNt4HvFyYNcMsCC8NbE3Nn_0 = Input_In;
            Output_2_Out = Input_In;
            return;
        }

        public static void IndexOf<T>(n40.Collection<T> Input_In, T Item_In, out n40.Collection<T> Output_2_Out, out int Result_Out)
        {
            var Result_0 = Input_In.IndexOf(item: Item_In);
            n40.Collection<T> __pad_Ea9kwwMsGsoLskwZmHx8mi_1 = Input_In;
            Output_2_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void Insert<T>(n40.Collection<T> Input_In, int Index_In, T Item_In, out n40.Collection<T> Output_2_Out)
        {
            Input_In.Insert(index: Index_In, item: Item_In);
            n40.Collection<T> __pad_UKjsxcZFVYCNsUDn2ZMHUc_0 = Input_In;
            Output_2_Out = Input_In;
            return;
        }

        public static void Remove<T>(n40.Collection<T> Input_In, T Item_In, out n40.Collection<T> Output_2_Out, out bool Result_Out)
        {
            var Result_0 = Input_In.Remove(item: Item_In);
            n40.Collection<T> __pad_VThyHDASPmAQDdPseJyTsh_1 = Input_In;
            Output_2_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void RemoveAt<T>(n40.Collection<T> Input_In, int Index_In, out n40.Collection<T> Output_2_Out)
        {
            Input_In.RemoveAt(index: Index_In);
            n40.Collection<T> __pad_DAujEctKMnjLk08CtdcgIL_0 = Input_In;
            Output_2_Out = Input_In;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Mutable.MutableSortedList.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.SortedList<T, T2> CreateDefault<T, T2>()
        {
            int __pad_PAUmmpKu5DTQcTpKtN6cyd_0 = __slot_PAUmmpKu5DTQcTpKtN6cyd;
            var Output_1 = new n6.SortedList<T, T2>(capacity: __pad_PAUmmpKu5DTQcTpKtN6cyd_0);
            return Output_1;
        }

        [n1.ElementAttribute(TracingId = 265232U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "PAUmmpKu5DTQcTpKtN6cyd", Name = "__slot_PAUmmpKu5DTQcTpKtN6cyd")]
        public static int __slot_PAUmmpKu5DTQcTpKtN6cyd = 0;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Mutable.MutableSortedDictionary.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.SortedDictionary<T, T2> CreateDefault<T, T2>()
        {
            var Output_0 = new n6.SortedDictionary<T, T2>();
            return Output_0;
        }
    }
}

namespace _VL_Collections_.Collections.Mutable.MutableSortedSet.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n6.SortedSet<T> CreateDefault<T>()
        {
            var Output_0 = new n6.SortedSet<T>();
            return Output_0;
        }
    }
}

namespace _VL_Collections_.Collections.Mutable.MutableArray.Advanced
{
    [n1.ElementAttribute(TracingId = 265388U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "E7MMY2y7nApLJNOyBvxTFt", Name = "FromImage_E7MMY2y7nApLJNOyBvxTFt")]
    [n2.SerializableAttribute]
    public class FromImage_E7MMY2y7nApLJNOyBvxTFt : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n28.FromImage_E7MMY2y7nApLJNOyBvxTFt Create(n1.NodeContext Node_Context)
        {
            var instance = new FromImage_E7MMY2y7nApLJNOyBvxTFt(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n28.FromImage_E7MMY2y7nApLJNOyBvxTFt CreateDefault()
        {
            var instance = new FromImage_E7MMY2y7nApLJNOyBvxTFt(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n28.FromImage_E7MMY2y7nApLJNOyBvxTFt Update(n41.IImage Input_In, out byte[] Output_Out)
        {
            var Result_0 = ((n41.IImage)Input_In).GetData();
            byte[] __auto_1;
            var state_2 = n1.CompilationHelper.Restore<__TFwaQxuHBgCOrlfzw77q4s>(this.__using_Do3aaP6I3OENyfZ0YzBEky, __GetContext__());
            using (Result_0)
            {
                if (state_2 == null)
                {
                    state_2 = new __TFwaQxuHBgCOrlfzw77q4s(__GetContext__(), n1.VLObject.NewIdentity());
                }

                var Bytes_3 = Result_0.Bytes;
                var Length_4 = Bytes_3.Length;
                bool Force_5 = false;
                bool Dispose_Cached_Outputs_6 = false;
                var manager_7 = state_2.__cache_AKn0BN23pidONSbdEBDq1u;
                if (manager_7 is null)
                {
                    manager_7 = new n42.Manager<n2.ValueTuple<int>, n2.ValueTuple<byte[]>>(n2.ValueTuple.Create(n28._Operations_.CreateDefault<byte>()));
                }

                var inputs_8 = n2.ValueTuple.Create(Length_4);
                var outputs_9 = manager_7.Outputs;
                var Has_Changed_10 = Force_5 || manager_7.InputsChanged(inputs_8);
                if (Has_Changed_10)
                {
                    if (Dispose_Cached_Outputs_6)
                        manager_7.DisposeOutputs();
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "CyvOTnRKqIMLzNCk1LbioU", 265408U);
                    n28._Operations_.Create<byte>(Node_Context: Node_Context_12, Length_In: Length_4, Result_Out: out byte[] Result_13);
                    outputs_9 = n2.ValueTuple.Create(Result_13);
                    manager_7 = manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6, default, outputs_9);
                }
                else
                {
                    manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6);
                }

                var __auto_14 = outputs_9.Item1;
                var Result_15 = n43.MemoryUtils.AsMemory<byte>(input: __auto_14);
                Bytes_3.CopyTo(destination: Result_15);
                __auto_1 = __auto_14;
                if (state_2.__GetContext__().IsImmutable)
                    state_2 = manager_7 != state_2.__cache_AKn0BN23pidONSbdEBDq1u ? new __TFwaQxuHBgCOrlfzw77q4s(state_2)
                    {__cache_AKn0BN23pidONSbdEBDq1u = manager_7} : state_2;
                else
                {
                    state_2.__cache_AKn0BN23pidONSbdEBDq1u = manager_7;
                }

                __auto_1 = __auto_1;
            }

            Output_Out = __auto_1;
            n28.FromImage_E7MMY2y7nApLJNOyBvxTFt that_16 = this;
            if (this.__GetContext__().IsImmutable)
                that_16 = state_2 != this.__using_Do3aaP6I3OENyfZ0YzBEky ? new FromImage_E7MMY2y7nApLJNOyBvxTFt(this)
                {__using_Do3aaP6I3OENyfZ0YzBEky = state_2} : that_16;
            else
            {
                this.__using_Do3aaP6I3OENyfZ0YzBEky = state_2;
            }

            return that_16;
        }

        public n28.FromImage_E7MMY2y7nApLJNOyBvxTFt __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n28.FromImage_E7MMY2y7nApLJNOyBvxTFt that_0 = this;
            this.__using_Do3aaP6I3OENyfZ0YzBEky = default(n2.Object);
            return that_0;
        }

        public n28.FromImage_E7MMY2y7nApLJNOyBvxTFt __CreateDefault__()
        {
            n28.FromImage_E7MMY2y7nApLJNOyBvxTFt that_0 = this;
            this.__using_Do3aaP6I3OENyfZ0YzBEky = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__using_Do3aaP6I3OENyfZ0YzBEky);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __using_Do3aaP6I3OENyfZ0YzBEky;
        public FromImage_E7MMY2y7nApLJNOyBvxTFt(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FromImage_E7MMY2y7nApLJNOyBvxTFt(FromImage_E7MMY2y7nApLJNOyBvxTFt other): base(other)
        {
            this.__using_Do3aaP6I3OENyfZ0YzBEky = other.__using_Do3aaP6I3OENyfZ0YzBEky;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__using_Do3aaP6I3OENyfZ0YzBEky", in __using_Do3aaP6I3OENyfZ0YzBEky));
        }

        internal FromImage_E7MMY2y7nApLJNOyBvxTFt __WITH__(n2.Object __using_Do3aaP6I3OENyfZ0YzBEky)
        {
            n28.FromImage_E7MMY2y7nApLJNOyBvxTFt that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __using_Do3aaP6I3OENyfZ0YzBEky != this.__using_Do3aaP6I3OENyfZ0YzBEky ? new FromImage_E7MMY2y7nApLJNOyBvxTFt(this)
                {__using_Do3aaP6I3OENyfZ0YzBEky = __using_Do3aaP6I3OENyfZ0YzBEky} : that_0;
            else
            {
                this.__using_Do3aaP6I3OENyfZ0YzBEky = __using_Do3aaP6I3OENyfZ0YzBEky;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "TFwaQxuHBgCOrlfzw77q4s", Name = "__TFwaQxuHBgCOrlfzw77q4s")]
        [n2.SerializableAttribute]
        public class __TFwaQxuHBgCOrlfzw77q4s : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__cache_AKn0BN23pidONSbdEBDq1u);
                return;
            }

            [n1.ElementAttribute(TracingId = 265401U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "AKn0BN23pidONSbdEBDq1u", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n42.Manager<n2.ValueTuple<int>, n2.ValueTuple<byte[]>> __cache_AKn0BN23pidONSbdEBDq1u = null;
            public __TFwaQxuHBgCOrlfzw77q4s(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __TFwaQxuHBgCOrlfzw77q4s(__TFwaQxuHBgCOrlfzw77q4s other): base(other)
            {
                this.__cache_AKn0BN23pidONSbdEBDq1u = other.__cache_AKn0BN23pidONSbdEBDq1u;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_AKn0BN23pidONSbdEBDq1u", in __cache_AKn0BN23pidONSbdEBDq1u));
            }

            internal __TFwaQxuHBgCOrlfzw77q4s __WITH__(n42.Manager<n2.ValueTuple<int>, n2.ValueTuple<byte[]>> __cache_AKn0BN23pidONSbdEBDq1u)
            {
                __TFwaQxuHBgCOrlfzw77q4s that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cache_AKn0BN23pidONSbdEBDq1u != this.__cache_AKn0BN23pidONSbdEBDq1u ? new __TFwaQxuHBgCOrlfzw77q4s(this)
                    {__cache_AKn0BN23pidONSbdEBDq1u = __cache_AKn0BN23pidONSbdEBDq1u} : that_0;
                else
                {
                    this.__cache_AKn0BN23pidONSbdEBDq1u = __cache_AKn0BN23pidONSbdEBDq1u;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 265451U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "C1jOHeGCee4MYa7QQLGZ42", Name = "StoreSequence_C1jOHeGCee4MYa7QQLGZ42")]
    [n2.SerializableAttribute]
    public class StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n28.StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n28.StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T> CreateDefault()
        {
            var instance = new StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n28.StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T> Update<T2>(T2 Input_In, out T[] Output_Out)
            where T2 : n6.IEnumerable<T>
        {
            n5.ArrayBuilder<T> __auto_0 = this.Builder;
            n6.IEnumerable<T> Items_1 = (n6.IEnumerable<T>)Input_In;
            var Result_2 = __auto_0.AsArray(items: Items_1);
            Output_Out = Result_2;
            return this;
        }

        public n28.StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            int Capacity_0 = 0;
            var Output_1 = new n5.ArrayBuilder<T>(capacity: Capacity_0);
            n5.ArrayBuilder<T> __auto_2 = Output_1;
            n28.StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T> that_3 = this;
            this.Builder = Output_1;
            return that_3;
        }

        public n28.StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T> __CreateDefault__()
        {
            n28.StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T> that_0 = this;
            this.Builder = default(n5.ArrayBuilder<T>);
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

        [n1.ElementAttribute(TracingId = 265456U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "PRt9t3BCRAhN2ChHt0WOi2", Name = "Builder")]
        public n5.ArrayBuilder<T> Builder;
        public StoreSequence_C1jOHeGCee4MYa7QQLGZ42(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal StoreSequence_C1jOHeGCee4MYa7QQLGZ42(StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T> other): base(other)
        {
            this.Builder = other.Builder;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Builder", in Builder));
        }

        internal StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T> __WITH__(n5.ArrayBuilder<T> Builder)
        {
            n28.StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = !n6.EqualityComparer<n5.ArrayBuilder<T>>.Default.Equals(Builder, this.Builder) ? new StoreSequence_C1jOHeGCee4MYa7QQLGZ42<T>(this)
                {Builder = Builder} : that_0;
            else
            {
                this.Builder = Builder;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 265479U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "OH4TKYsSUseQU3JpOZF4kZ", Name = "FromValue_OH4TKYsSUseQU3JpOZF4kZ")]
    [n2.SerializableAttribute]
    public class FromValue_OH4TKYsSUseQU3JpOZF4kZ<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n28.FromValue_OH4TKYsSUseQU3JpOZF4kZ<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new FromValue_OH4TKYsSUseQU3JpOZF4kZ<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n28.FromValue_OH4TKYsSUseQU3JpOZF4kZ<T> CreateDefault()
        {
            var instance = new FromValue_OH4TKYsSUseQU3JpOZF4kZ<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n28.FromValue_OH4TKYsSUseQU3JpOZF4kZ<T> Update(T Input_In, bool Force_In, out T[] Output_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_SbLPLSbUEuCPmIUoCn9f3X;
            if (manager_1 is null)
            {
                manager_1 = new n42.Manager<n2.ValueTuple<T>, n2.ValueTuple<T[]>>(n2.ValueTuple.Create(n28._Operations_.CreateDefault<T>()));
            }

            var inputs_2 = n2.ValueTuple.Create(Input_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Force_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                n28._Operations_.ToArray<T>(Input_In: Input_In, Result_Out: out T[] Result_6);
                outputs_3 = n2.ValueTuple.Create(Result_6);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, default, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var __auto_7 = outputs_3.Item1;
            Output_Out = __auto_7;
            n28.FromValue_OH4TKYsSUseQU3JpOZF4kZ<T> that_8 = this;
            if (this.__GetContext__().IsImmutable)
                that_8 = manager_1 != this.__cache_SbLPLSbUEuCPmIUoCn9f3X ? new FromValue_OH4TKYsSUseQU3JpOZF4kZ<T>(this)
                {__cache_SbLPLSbUEuCPmIUoCn9f3X = manager_1} : that_8;
            else
            {
                this.__cache_SbLPLSbUEuCPmIUoCn9f3X = manager_1;
            }

            return that_8;
        }

        public n28.FromValue_OH4TKYsSUseQU3JpOZF4kZ<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n28.FromValue_OH4TKYsSUseQU3JpOZF4kZ<T> that_0 = this;
            this.__cache_SbLPLSbUEuCPmIUoCn9f3X = null;
            return that_0;
        }

        public n28.FromValue_OH4TKYsSUseQU3JpOZF4kZ<T> __CreateDefault__()
        {
            n28.FromValue_OH4TKYsSUseQU3JpOZF4kZ<T> that_0 = this;
            this.__cache_SbLPLSbUEuCPmIUoCn9f3X = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_SbLPLSbUEuCPmIUoCn9f3X);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 265482U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "SbLPLSbUEuCPmIUoCn9f3X", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<T>, n2.ValueTuple<T[]>> __cache_SbLPLSbUEuCPmIUoCn9f3X = null;
        public FromValue_OH4TKYsSUseQU3JpOZF4kZ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FromValue_OH4TKYsSUseQU3JpOZF4kZ(FromValue_OH4TKYsSUseQU3JpOZF4kZ<T> other): base(other)
        {
            this.__cache_SbLPLSbUEuCPmIUoCn9f3X = other.__cache_SbLPLSbUEuCPmIUoCn9f3X;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_SbLPLSbUEuCPmIUoCn9f3X", in __cache_SbLPLSbUEuCPmIUoCn9f3X));
        }

        internal FromValue_OH4TKYsSUseQU3JpOZF4kZ<T> __WITH__(n42.Manager<n2.ValueTuple<T>, n2.ValueTuple<T[]>> __cache_SbLPLSbUEuCPmIUoCn9f3X)
        {
            n28.FromValue_OH4TKYsSUseQU3JpOZF4kZ<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_SbLPLSbUEuCPmIUoCn9f3X != this.__cache_SbLPLSbUEuCPmIUoCn9f3X ? new FromValue_OH4TKYsSUseQU3JpOZF4kZ<T>(this)
                {__cache_SbLPLSbUEuCPmIUoCn9f3X = __cache_SbLPLSbUEuCPmIUoCn9f3X} : that_0;
            else
            {
                this.__cache_SbLPLSbUEuCPmIUoCn9f3X = __cache_SbLPLSbUEuCPmIUoCn9f3X;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, int Length_In, out T[] Result_Out)
        {
            var Result_0 = n23.ArrayNodes.Create<T>(length: Length_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static T[] CreateDefault<T>()
        {
            var Result_0 = n2.Array.Empty<T>();
            return Result_0;
        }

        public static void Empty<T>(out T[] Result_Out)
        {
            var Result_0 = n2.Array.Empty<T>();
            Result_Out = Result_0;
            return;
        }

        public static void GetItem<T>(T[] Input_In, int Index_In, out T[] Output_Out, out T Item_Out)
        {
            var Item_0 = Input_In[Index_In];
            Output_Out = Input_In;
            Item_Out = Item_0;
            return;
        }

        public static void Length<T>(T[] Input_In, out T[] Output_Out, out int Length_Out)
        {
            var Length_0 = Input_In.Length;
            Output_Out = Input_In;
            Length_Out = Length_0;
            return;
        }

        public static void Reverse<T>(T[] Input_In, out T[] Output_Out)
        {
            var Output_0 = n23.ArrayNodes.Reverse<T>(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void ReverseRange<T>(T[] Input_In, int Index_In, int Count_In, out T[] Output_Out)
        {
            var Output_0 = n23.ArrayNodes.ReverseRange<T>(input: Input_In, index: Index_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void SetItem<T>(T[] Input_In, int Index_In, T Value_In, out T[] Output_Out)
        {
            Input_In[Index_In] = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void ToImage<T>(T[] Input_In, int Width_In, int Height_In, n41.PixelFormat Format_In, string Original_Format_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Is_Volatile_In, out n41.IImage Result_Out)
            where T : struct
        {
            var Result_0 = n41.ImageExtensions.ToImage<T>(data: Input_In, width: Width_In, height: Height_In, format: Format_In, originalFormat: Original_Format_In, isVolatile: Is_Volatile_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToArray<T>(T Input_In, out T[] Result_Out)
        {
            int __pad_K4vRZsVSX5ePOexihSBKYY_0 = __slot_K4vRZsVSX5ePOexihSBKYY;
            n1.NodeContext Node_Context_1 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "DG0wVPmhm5pNfxRrddUbHC", 265345U);
            n28._Operations_.Create<T>(Node_Context: Node_Context_1, Length_In: __pad_K4vRZsVSX5ePOexihSBKYY_0, Result_Out: out T[] Result_2);
            int Index_3 = 0;
            n28._Operations_.SetItem<T>(Input_In: Result_2, Index_In: Index_3, Value_In: Input_In, Output_Out: out T[] Output_4);
            Result_Out = Output_4;
            return;
        }

        public static void FromSequence<T>(n6.IEnumerable<T> Input_In, out T[] Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.ToArray<T>(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Cons<T>(T[] Input_In, out T[] Result_Out)
        {
            Result_Out = Input_In;
            return;
        }

        public static void Decons<T>(T[] Input_In, out T[] Result_Out)
        {
            Result_Out = Input_In;
            return;
        }

        [n1.ElementAttribute(TracingId = 265344U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "K4vRZsVSX5ePOexihSBKYY", Name = "__slot_K4vRZsVSX5ePOexihSBKYY")]
        public static int __slot_K4vRZsVSX5ePOexihSBKYY = 1;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Concurrent.ConcurrentDictionary.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n44.ConcurrentDictionary<T, T2> CreateDefault<T, T2>()
        {
            int __pad_O6nluVBJj4LNmXPQmJczwG_0 = __slot_O6nluVBJj4LNmXPQmJczwG;
            int __pad_Q1OOJSNylzhMVXK2c0ZnY2_1 = __slot_Q1OOJSNylzhMVXK2c0ZnY2;
            var Output_2 = new n44.ConcurrentDictionary<T, T2>(concurrencyLevel: __pad_O6nluVBJj4LNmXPQmJczwG_0, capacity: __pad_Q1OOJSNylzhMVXK2c0ZnY2_1);
            return Output_2;
        }

        [n1.ElementAttribute(TracingId = 265539U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "O6nluVBJj4LNmXPQmJczwG", Name = "__slot_O6nluVBJj4LNmXPQmJczwG")]
        public static int __slot_O6nluVBJj4LNmXPQmJczwG = 1;
        [n1.ElementAttribute(TracingId = 265537U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Q1OOJSNylzhMVXK2c0ZnY2", Name = "__slot_Q1OOJSNylzhMVXK2c0ZnY2")]
        public static int __slot_Q1OOJSNylzhMVXK2c0ZnY2 = 0;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Concurrent.ConcurrentQueue.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n44.ConcurrentQueue<T> CreateDefault<T>()
        {
            var Output_0 = new n44.ConcurrentQueue<T>();
            return Output_0;
        }
    }
}

namespace _VL_Collections_.Collections.Concurrent.ConcurrentStack.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n44.ConcurrentStack<T> CreateDefault<T>()
        {
            var Output_0 = new n44.ConcurrentStack<T>();
            return Output_0;
        }
    }
}

namespace _VL_Collections_.Collections.Concurrent.ConcurrentBag.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n44.ConcurrentBag<T> CreateDefault<T>()
        {
            var Output_0 = new n44.ConcurrentBag<T>();
            return Output_0;
        }
    }
}

namespace _VL_Collections_.Collections.Concurrent.BlockingCollection.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n44.BlockingCollection<T> CreateDefault<T>()
        {
            var Output_0 = new n44.BlockingCollection<T>();
            return Output_0;
        }
    }
}

namespace _VL_Collections_.Collections.SortedDictionary.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n21.ImmutableSortedDictionary<T, T2> CreateDefault<T, T2>()
        {
            var Empty_0 = n21.ImmutableSortedDictionary<T, T2>.Empty;
            return Empty_0;
        }

        [n4.CreateNewAttribute]
        public static void Create<T, T2>(n1.NodeContext Node_Context, out n21.ImmutableSortedDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.Create<T, T2>();
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T, T2>(n1.NodeContext Node_Context, n6.IComparer<T> Key_Comparer_In, out n21.ImmutableSortedDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.Create<T, T2>(keyComparer: Key_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T, T2>(n1.NodeContext Node_Context, n6.IComparer<T> Key_Comparer_In, n6.IEqualityComparer<T2> Value_Comparer_In, out n21.ImmutableSortedDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.Create<T, T2>(keyComparer: Key_Comparer_In, valueComparer: Value_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRange<T, T2>(n6.IEnumerable<n6.KeyValuePair<T, T2>> Items_In, out n21.ImmutableSortedDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.CreateRange<T, T2>(items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRange<T, T2>(n6.IComparer<T> Key_Comparer_In, n6.IEnumerable<n6.KeyValuePair<T, T2>> Items_In, out n21.ImmutableSortedDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.CreateRange<T, T2>(keyComparer: Key_Comparer_In, items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRange<T, T2>(n6.IComparer<T> Key_Comparer_In, n6.IEqualityComparer<T2> Value_Comparer_In, n6.IEnumerable<n6.KeyValuePair<T, T2>> Items_In, out n21.ImmutableSortedDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.CreateRange<T, T2>(keyComparer: Key_Comparer_In, valueComparer: Value_Comparer_In, items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2>(n6.IEnumerable<n6.KeyValuePair<T, T2>> Input_In, out n21.ImmutableSortedDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.ToImmutableSortedDictionary<T, T2>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2>(n6.IEnumerable<n6.KeyValuePair<T, T2>> Input_In, n6.IComparer<T> Key_Comparer_In, out n21.ImmutableSortedDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.ToImmutableSortedDictionary<T, T2>(source: Input_In, keyComparer: Key_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2>(n6.IEnumerable<n6.KeyValuePair<T, T2>> Input_In, n6.IComparer<T> Key_Comparer_In, n6.IEqualityComparer<T2> Value_Comparer_In, out n21.ImmutableSortedDictionary<T, T2> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.ToImmutableSortedDictionary<T, T2>(source: Input_In, keyComparer: Key_Comparer_In, valueComparer: Value_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2, T3>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, n2.Func<T, T3> Element_Selector_In, out n21.ImmutableSortedDictionary<T2, T3> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.ToImmutableSortedDictionary<T, T2, T3>(source: Input_In, keySelector: Key_Selector_In, elementSelector: Element_Selector_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2, T3>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, n2.Func<T, T3> Element_Selector_In, n6.IComparer<T2> Key_Comparer_In, out n21.ImmutableSortedDictionary<T2, T3> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.ToImmutableSortedDictionary<T, T2, T3>(source: Input_In, keySelector: Key_Selector_In, elementSelector: Element_Selector_In, keyComparer: Key_Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T, T2, T3>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, n2.Func<T, T3> Element_Selector_In, n6.IComparer<T2> Key_Comparer_In, n6.IEqualityComparer<T3> Value_Comparer_In, out n21.ImmutableSortedDictionary<T2, T3> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedDictionary.ToImmutableSortedDictionary<T, T2, T3>(source: Input_In, keySelector: Key_Selector_In, elementSelector: Element_Selector_In, keyComparer: Key_Comparer_In, valueComparer: Value_Comparer_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.SortedSet.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n21.ImmutableSortedSet<T> CreateDefault<T>()
        {
            var Empty_0 = n21.ImmutableSortedSet<T>.Empty;
            return Empty_0;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, out n21.ImmutableSortedSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedSet.Create<T>();
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, T[] Items_In, out n21.ImmutableSortedSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedSet.Create<T>(items: Items_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, n6.IComparer<T> Comparer_In, out n21.ImmutableSortedSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedSet.Create<T>(comparer: Comparer_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, T Item_In, out n21.ImmutableSortedSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedSet.Create<T>(item: Item_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, n6.IComparer<T> Comparer_In, T[] Items_In, out n21.ImmutableSortedSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedSet.Create<T>(comparer: Comparer_In, items: Items_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, n6.IComparer<T> Comparer_In, T Item_In, out n21.ImmutableSortedSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedSet.Create<T>(comparer: Comparer_In, item: Item_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRange<T>(n6.IEnumerable<T> Items_In, out n21.ImmutableSortedSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedSet.CreateRange<T>(items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRange<T>(n6.IComparer<T> Comparer_In, n6.IEnumerable<T> Items_In, out n21.ImmutableSortedSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedSet.CreateRange<T>(comparer: Comparer_In, items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T>(n6.IEnumerable<T> Input_In, out n21.ImmutableSortedSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedSet.ToImmutableSortedSet<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T>(n6.IEnumerable<T> Input_In, n6.IComparer<T> Comparer_In, out n21.ImmutableSortedSet<T> Result_Out)
        {
            var Result_0 = n21.ImmutableSortedSet.ToImmutableSortedSet<T>(source: Input_In, comparer: Comparer_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Stack.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n21.ImmutableStack<T> CreateDefault<T>()
        {
            var Empty_0 = n21.ImmutableStack<T>.Empty;
            return Empty_0;
        }

        public static void Pop<T>(n21.ImmutableStack<T> Input_In, out n21.ImmutableStack<T> Output_Out, out T Value_Out)
        {
            var Output_1 = Input_In.Pop(value: out T Value_0);
            Output_Out = Output_1;
            Value_Out = Value_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, out n21.ImmutableStack<T> Result_Out)
        {
            var Result_0 = n21.ImmutableStack.Create<T>();
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, T[] Items_In, out n21.ImmutableStack<T> Result_Out)
        {
            var Result_0 = n21.ImmutableStack.Create<T>(items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromValue<T>(T Input_In, out n21.ImmutableStack<T> Result_Out)
        {
            var Result_0 = n21.ImmutableStack.Create<T>(item: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRange<T>(n6.IEnumerable<T> Items_In, out n21.ImmutableStack<T> Result_Out)
        {
            var Result_0 = n21.ImmutableStack.CreateRange<T>(items: Items_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Array.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n21.ImmutableArray<T> CreateDefault<T>()
        {
            var Empty_0 = n21.ImmutableArray<T>.Empty;
            return Empty_0;
        }

        public static void BinarySearch<T>(n21.ImmutableArray<T> Input_In, T Value_In, out int Result_Out)
        {
            var Result_0 = n21.ImmutableArray.BinarySearch<T>(array: Input_In, value: Value_In);
            Result_Out = Result_0;
            return;
        }

        public static void BinarySearch<T>(n21.ImmutableArray<T> Input_In, T Value_In, n6.IComparer<T> Comparer_In, out int Result_Out)
        {
            var Result_0 = n21.ImmutableArray.BinarySearch<T>(array: Input_In, value: Value_In, comparer: Comparer_In);
            Result_Out = Result_0;
            return;
        }

        public static void BinarySearch<T>(n21.ImmutableArray<T> Input_In, int Index_In, int Length_In, T Value_In, out int Result_Out)
        {
            var Result_0 = n21.ImmutableArray.BinarySearch<T>(array: Input_In, index: Index_In, length: Length_In, value: Value_In);
            Result_Out = Result_0;
            return;
        }

        public static void BinarySearch<T>(n21.ImmutableArray<T> Input_In, int Index_In, int Length_In, T Value_In, n6.IComparer<T> Comparer_In, out int Result_Out)
        {
            var Result_0 = n21.ImmutableArray.BinarySearch<T>(array: Input_In, index: Index_In, length: Length_In, value: Value_In, comparer: Comparer_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, out n21.ImmutableArray<T> Result_Out)
        {
            var Result_0 = n21.ImmutableArray.Create<T>();
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, T Item_In, out n21.ImmutableArray<T> Result_Out)
        {
            var Result_0 = n21.ImmutableArray.Create<T>(item: Item_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, T[] Items_In, out n21.ImmutableArray<T> Result_Out)
        {
            var Result_0 = n21.ImmutableArray.Create<T>(items: Items_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, T Item_1_In, T Item_2_In, out n21.ImmutableArray<T> Result_Out)
        {
            var Result_0 = n21.ImmutableArray.Create<T>(item1: Item_1_In, item2: Item_2_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, T Item_1_In, T Item_2_In, T Item_3_In, out n21.ImmutableArray<T> Result_Out)
        {
            var Result_0 = n21.ImmutableArray.Create<T>(item1: Item_1_In, item2: Item_2_In, item3: Item_3_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, T[] Items_In, int Start_In, int Length_In, out n21.ImmutableArray<T> Result_Out)
        {
            var Result_0 = n21.ImmutableArray.Create<T>(items: Items_In, start: Start_In, length: Length_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, n21.ImmutableArray<T> Items_In, int Start_In, int Length_In, out n21.ImmutableArray<T> Output_Out)
        {
            var Output_0 = n21.ImmutableArray.Create<T>(items: Items_In, start: Start_In, length: Length_In);
            Output_Out = Output_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, T Item_1_In, T Item_2_In, T Item_3_In, T Item_4_In, out n21.ImmutableArray<T> Result_Out)
        {
            var Result_0 = n21.ImmutableArray.Create<T>(item1: Item_1_In, item2: Item_2_In, item3: Item_3_In, item4: Item_4_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRange<T>(n6.IEnumerable<T> Items_In, out n21.ImmutableArray<T> Result_Out)
        {
            var Result_0 = n21.ImmutableArray.CreateRange<T>(items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void CreateRange<T, T2>(n21.ImmutableArray<T> Items_In, n2.Func<T, T2> Selector_In, out n21.ImmutableArray<T2> Output_Out)
        {
            var Output_0 = n21.ImmutableArray.CreateRange<T, T2>(items: Items_In, selector: Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void CreateRange<T2, T, T3>(n21.ImmutableArray<T2> Items_In, n2.Func<T2, T, T3> Selector_In, T Arg_In, out n21.ImmutableArray<T3> Output_Out)
        {
            var Output_0 = n21.ImmutableArray.CreateRange<T2, T, T3>(items: Items_In, selector: Selector_In, arg: Arg_In);
            Output_Out = Output_0;
            return;
        }

        public static void CreateRange<T, T2>(n21.ImmutableArray<T> Items_In, int Start_In, int Length_In, n2.Func<T, T2> Selector_In, out n21.ImmutableArray<T2> Output_Out)
        {
            var Output_0 = n21.ImmutableArray.CreateRange<T, T2>(items: Items_In, start: Start_In, length: Length_In, selector: Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void CreateRange<T2, T, T3>(n21.ImmutableArray<T2> Items_In, int Start_In, int Length_In, n2.Func<T2, T, T3> Selector_In, T Arg_In, out n21.ImmutableArray<T3> Output_Out)
        {
            var Output_0 = n21.ImmutableArray.CreateRange<T2, T, T3>(items: Items_In, start: Start_In, length: Length_In, selector: Selector_In, arg: Arg_In);
            Output_Out = Output_0;
            return;
        }

        public static void FromSequence<T>(n6.IEnumerable<T> Input_In, out n21.ImmutableArray<T> Result_Out)
        {
            var Result_0 = n21.ImmutableArray.ToImmutableArray<T>(items: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Cons<T>(n21.ImmutableArray<T> Input_In, out n21.ImmutableArray<T> Result_Out)
        {
            Result_Out = Input_In;
            return;
        }

        public static void Decons<T>(n21.ImmutableArray<T> Input_In, out n21.ImmutableArray<T> Result_Out)
        {
            Result_Out = Input_In;
            return;
        }

        public static void AsMemory_H<T>(n21.ImmutableArray<T> Input_In, out n21.ImmutableArray<T> Output_Out, out n2.ReadOnlyMemory<T> Result_Out)
        {
            var Result_0 = Input_In.AsMemory();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void AsSpan_H<T>(n21.ImmutableArray<T> Input_In, out n21.ImmutableArray<T> Output_Out, out n2.ReadOnlySpan<T> Result_Out)
        {
            var Result_0 = Input_In.AsSpan();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Queue.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, out n21.ImmutableQueue<T> Result_Out)
        {
            var Result_0 = n21.ImmutableQueue.Create<T>();
            Result_Out = Result_0;
            return;
        }

        public static void FromSequence<T>(n6.IEnumerable<T> Items_In, out n21.ImmutableQueue<T> Result_Out)
        {
            var Result_0 = n21.ImmutableQueue.CreateRange<T>(items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromArray<T>(T[] Items_In, out n21.ImmutableQueue<T> Result_Out)
        {
            var Result_0 = n21.ImmutableQueue.Create<T>(items: Items_In);
            Result_Out = Result_0;
            return;
        }

        public static void FromValue<T>(T Input_In, out n21.ImmutableQueue<T> Result_Out)
        {
            var Result_0 = n21.ImmutableQueue.Create<T>(item: Input_In);
            Result_Out = Result_0;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static n21.ImmutableQueue<T> CreateDefault<T>()
        {
            var Empty_0 = n21.ImmutableQueue<T>.Empty;
            return Empty_0;
        }

        public static void Dequeue<T>(n21.ImmutableQueue<T> Input_In, out n21.ImmutableQueue<T> Output_Out, out T Value_Out)
        {
            var Output_1 = Input_In.Dequeue(value: out T Value_0);
            Output_Out = Output_1;
            Value_Out = Value_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.HoldLatestCopy.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create<T>(n1.NodeContext Node_Context, n5.Spread<T> Initial_Result_In, out n23.HoldLatestCopy<T> Output_Out)
        {
            n6.IReadOnlyList<T> Initial_Result_0 = (n6.IReadOnlyList<T>)Initial_Result_In;
            var Output_1 = new n23.HoldLatestCopy<T>(initialResult: Initial_Result_0);
            Output_Out = Output_1;
            return;
        }

        public static void Update<T>(n23.HoldLatestCopy<T> Input_In, n2.IObservable<n6.IReadOnlyList<T>> Async_Notifications_In, [n4.SerializedDefaultValueAttribute("16", false)] int Timeout_In, bool Reset_In, out n23.HoldLatestCopy<T> Output_Out, out n6.IReadOnlyList<T> Result_Out, out int Swap_Count_Out, out int Drop_Count_Out)
        {
            var Result_2 = Input_In.Update(asyncNotifications: Async_Notifications_In, timeout: Timeout_In, reset: Reset_In, swapCount: out int Swap_Count_0, dropCount: out int Drop_Count_1);
            Output_Out = Input_In;
            Result_Out = Result_2;
            Swap_Count_Out = Swap_Count_0;
            Drop_Count_Out = Drop_Count_1;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Spread
{
    [n1.ElementAttribute(TracingId = 268763U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "ML1zJ7dEH6TPqxRQZ2sF3E", Name = "FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E")]
    [n2.SerializableAttribute]
    public class FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T> CreateDefault()
        {
            var instance = new FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T> Update<T2>(T2 Input_In, out n5.Spread<T> Result_Out)
            where T2 : n6.IEnumerable<T>
        {
            n5.Spread<T> __auto_0 = this.Spread;
            var __fallback___1 = n1.ServiceRegistry.Current;
            n46._Operations_.TryCatchFinally_Stateless<n45.SpreadBuilder<T>, n5.Spread<T>>(Try_In: () =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                int __pad_TLmACxlAHrSLIfZ24AIr8F_3 = __slot_TLmACxlAHrSLIfZ24AIr8F;
                var Result_4 = n4.CollectionBuilders.GetBuilder<T>(collection: __auto_0, capacity: __pad_TLmACxlAHrSLIfZ24AIr8F_3);
                n45.SpreadBuilder<T> accumulator_6 = Result_4;
                var i_8 = 0;
                foreach (var item_5 in Input_In)
                {
                    var splicer_7 = item_5;
                    var i_local_9 = i_8;
                    accumulator_6.Add(value: splicer_7);
                    i_8++;
                }

                return accumulator_6;
            }

            , Catch_In: (n2.Exception Input_In_11) =>
            {
                using var __current_10 = __fallback___1.MakeCurrentIfNone();
                return default(n45.SpreadBuilder<T>);
            }

            , Finally_In: (n45.SpreadBuilder<T> Input_In_13) =>
            {
                using var __current_12 = __fallback___1.MakeCurrentIfNone();
                var Result_14 = Input_In_13.Commit();
                return Result_14;
            }

            , Result_Out: out n5.Spread<T> Result_15);
            n5.Spread<T> __auto_16 = Result_15;
            Result_Out = Result_15;
            n7.FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T> that_17 = this;
            if (this.__GetContext__().IsImmutable)
                that_17 = Result_15 != this.Spread ? new FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T>(this)
                {Spread = Result_15} : that_17;
            else
            {
                this.Spread = Result_15;
            }

            return that_17;
        }

        public n7.FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T> that_0 = this;
            this.Spread = n7._Operations_.CreateDefault<T>();
            return that_0;
        }

        public n7.FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T> __CreateDefault__()
        {
            n7.FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T> that_0 = this;
            this.Spread = n7._Operations_.CreateDefault<T>();
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

        [n1.ElementAttribute(TracingId = 268767U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "G2YQvwhDGnILBTrb1eVNbd", Name = "Spread")]
        public n5.Spread<T> Spread;
        [n1.ElementAttribute(TracingId = 268793U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "TLmACxlAHrSLIfZ24AIr8F", Name = "__slot_TLmACxlAHrSLIfZ24AIr8F")]
        public static int __slot_TLmACxlAHrSLIfZ24AIr8F = 32;
        static FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E()
        {
        }

        public FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E(FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T> other): base(other)
        {
            this.Spread = other.Spread;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Spread", in Spread));
        }

        internal FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T> __WITH__(n5.Spread<T> Spread)
        {
            n7.FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Spread != this.Spread ? new FromSequence_Sustain_ML1zJ7dEH6TPqxRQZ2sF3E<T>(this)
                {Spread = Spread} : that_0;
            else
            {
                this.Spread = Spread;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270209U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Dedn0GP3agoLvHtKBtr1rt", Name = "I_Dedn0GP3agoLvHtKBtr1rt")]
    [n2.SerializableAttribute]
    public class I_Dedn0GP3agoLvHtKBtr1rt : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.I_Dedn0GP3agoLvHtKBtr1rt Create(n1.NodeContext Node_Context)
        {
            var instance = new I_Dedn0GP3agoLvHtKBtr1rt(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.I_Dedn0GP3agoLvHtKBtr1rt CreateDefault()
        {
            var instance = new I_Dedn0GP3agoLvHtKBtr1rt(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.I_Dedn0GP3agoLvHtKBtr1rt Update(int Start_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<int> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_OmwSgnKdo9CL3oH54kLpLX;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<int, int>, n2.ValueTuple<n5.Spread<int>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<int>()));
            }

            var inputs_3 = (Start_In, Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                n32._Operations_.CreateISpread(Start_In: Start_In, Count_In: Count_In, Output_Out: out n5.Spread<int> Output_7);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            Output_Out = __auto_8;
            n7.I_Dedn0GP3agoLvHtKBtr1rt that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = manager_2 != this.__cache_OmwSgnKdo9CL3oH54kLpLX ? new I_Dedn0GP3agoLvHtKBtr1rt(this)
                {__cache_OmwSgnKdo9CL3oH54kLpLX = manager_2} : that_9;
            else
            {
                this.__cache_OmwSgnKdo9CL3oH54kLpLX = manager_2;
            }

            return that_9;
        }

        public n7.I_Dedn0GP3agoLvHtKBtr1rt __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.I_Dedn0GP3agoLvHtKBtr1rt that_0 = this;
            this.__cache_OmwSgnKdo9CL3oH54kLpLX = null;
            return that_0;
        }

        public n7.I_Dedn0GP3agoLvHtKBtr1rt __CreateDefault__()
        {
            n7.I_Dedn0GP3agoLvHtKBtr1rt that_0 = this;
            this.__cache_OmwSgnKdo9CL3oH54kLpLX = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_OmwSgnKdo9CL3oH54kLpLX);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 270212U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "OmwSgnKdo9CL3oH54kLpLX", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<int, int>, n2.ValueTuple<n5.Spread<int>>> __cache_OmwSgnKdo9CL3oH54kLpLX = null;
        public I_Dedn0GP3agoLvHtKBtr1rt(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal I_Dedn0GP3agoLvHtKBtr1rt(I_Dedn0GP3agoLvHtKBtr1rt other): base(other)
        {
            this.__cache_OmwSgnKdo9CL3oH54kLpLX = other.__cache_OmwSgnKdo9CL3oH54kLpLX;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_OmwSgnKdo9CL3oH54kLpLX", in __cache_OmwSgnKdo9CL3oH54kLpLX));
        }

        internal I_Dedn0GP3agoLvHtKBtr1rt __WITH__(n42.Manager<n2.ValueTuple<int, int>, n2.ValueTuple<n5.Spread<int>>> __cache_OmwSgnKdo9CL3oH54kLpLX)
        {
            n7.I_Dedn0GP3agoLvHtKBtr1rt that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_OmwSgnKdo9CL3oH54kLpLX != this.__cache_OmwSgnKdo9CL3oH54kLpLX ? new I_Dedn0GP3agoLvHtKBtr1rt(this)
                {__cache_OmwSgnKdo9CL3oH54kLpLX = __cache_OmwSgnKdo9CL3oH54kLpLX} : that_0;
            else
            {
                this.__cache_OmwSgnKdo9CL3oH54kLpLX = __cache_OmwSgnKdo9CL3oH54kLpLX;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270246U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "UXyN8H5ad7xPndIfMqu94V", Name = "LinearSpread_UXyN8H5ad7xPndIfMqu94V")]
    [n2.SerializableAttribute]
    public class LinearSpread_UXyN8H5ad7xPndIfMqu94V : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.LinearSpread_UXyN8H5ad7xPndIfMqu94V Create(n1.NodeContext Node_Context)
        {
            var instance = new LinearSpread_UXyN8H5ad7xPndIfMqu94V(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.LinearSpread_UXyN8H5ad7xPndIfMqu94V CreateDefault()
        {
            var instance = new LinearSpread_UXyN8H5ad7xPndIfMqu94V(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.LinearSpread_UXyN8H5ad7xPndIfMqu94V Update(float Center_In, [n4.SerializedDefaultValueAttribute("1", false)] float Width_In, n35.LinearSpreadAlignment Alignment_In, float Phase_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<float> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_I9DWg2JO7pIMXdzYYo7c1H;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<float, float, n35.LinearSpreadAlignment, float, int>, n2.ValueTuple<n5.Spread<float>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<float>()));
            }

            var inputs_3 = (Center_In, Width_In, Alignment_In, Phase_In, Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                n32._Operations_.CreateLinearSpread(Center_In: Center_In, Width_In: Width_In, Alignment_In: Alignment_In, Phase_In: Phase_In, Count_In: Count_In, Output_Out: out n5.Spread<float> Output_7);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            Output_Out = __auto_8;
            n7.LinearSpread_UXyN8H5ad7xPndIfMqu94V that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = manager_2 != this.__cache_I9DWg2JO7pIMXdzYYo7c1H ? new LinearSpread_UXyN8H5ad7xPndIfMqu94V(this)
                {__cache_I9DWg2JO7pIMXdzYYo7c1H = manager_2} : that_9;
            else
            {
                this.__cache_I9DWg2JO7pIMXdzYYo7c1H = manager_2;
            }

            return that_9;
        }

        public n7.LinearSpread_UXyN8H5ad7xPndIfMqu94V __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.LinearSpread_UXyN8H5ad7xPndIfMqu94V that_0 = this;
            this.__cache_I9DWg2JO7pIMXdzYYo7c1H = null;
            return that_0;
        }

        public n7.LinearSpread_UXyN8H5ad7xPndIfMqu94V __CreateDefault__()
        {
            n7.LinearSpread_UXyN8H5ad7xPndIfMqu94V that_0 = this;
            this.__cache_I9DWg2JO7pIMXdzYYo7c1H = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_I9DWg2JO7pIMXdzYYo7c1H);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 270251U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "I9DWg2JO7pIMXdzYYo7c1H", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<float, float, n35.LinearSpreadAlignment, float, int>, n2.ValueTuple<n5.Spread<float>>> __cache_I9DWg2JO7pIMXdzYYo7c1H = null;
        public LinearSpread_UXyN8H5ad7xPndIfMqu94V(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal LinearSpread_UXyN8H5ad7xPndIfMqu94V(LinearSpread_UXyN8H5ad7xPndIfMqu94V other): base(other)
        {
            this.__cache_I9DWg2JO7pIMXdzYYo7c1H = other.__cache_I9DWg2JO7pIMXdzYYo7c1H;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_I9DWg2JO7pIMXdzYYo7c1H", in __cache_I9DWg2JO7pIMXdzYYo7c1H));
        }

        internal LinearSpread_UXyN8H5ad7xPndIfMqu94V __WITH__(n42.Manager<n2.ValueTuple<float, float, n35.LinearSpreadAlignment, float, int>, n2.ValueTuple<n5.Spread<float>>> __cache_I9DWg2JO7pIMXdzYYo7c1H)
        {
            n7.LinearSpread_UXyN8H5ad7xPndIfMqu94V that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_I9DWg2JO7pIMXdzYYo7c1H != this.__cache_I9DWg2JO7pIMXdzYYo7c1H ? new LinearSpread_UXyN8H5ad7xPndIfMqu94V(this)
                {__cache_I9DWg2JO7pIMXdzYYo7c1H = __cache_I9DWg2JO7pIMXdzYYo7c1H} : that_0;
            else
            {
                this.__cache_I9DWg2JO7pIMXdzYYo7c1H = __cache_I9DWg2JO7pIMXdzYYo7c1H;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270304U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "VtJNkGC54V8Ncx7LSXj8yA", Name = "CircleSpread_VtJNkGC54V8Ncx7LSXj8yA")]
    [n2.SerializableAttribute]
    public class CircleSpread_VtJNkGC54V8Ncx7LSXj8yA : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.CircleSpread_VtJNkGC54V8Ncx7LSXj8yA Create(n1.NodeContext Node_Context)
        {
            var instance = new CircleSpread_VtJNkGC54V8Ncx7LSXj8yA(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.CircleSpread_VtJNkGC54V8Ncx7LSXj8yA CreateDefault()
        {
            var instance = new CircleSpread_VtJNkGC54V8Ncx7LSXj8yA(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.CircleSpread_VtJNkGC54V8Ncx7LSXj8yA Update(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector2 Width_In, [n4.SerializedDefaultValueAttribute("1", false)] float Factor_In, float Phase_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_HrWV8nAJBYjO4rQ8ZFBqNi;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, float, float, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<n26.Vector2>()));
            }

            var inputs_3 = (Center_In, Width_In, Factor_In, Phase_In, Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                n32._Operations_.CreateCircleSpread(Center_In: Center_In, Size_In: Width_In, Factor_In: Factor_In, Phase_In: Phase_In, Count_In: Count_In, Output_Out: out n5.Spread<n26.Vector2> Output_7);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            Output_Out = __auto_8;
            n7.CircleSpread_VtJNkGC54V8Ncx7LSXj8yA that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = manager_2 != this.__cache_HrWV8nAJBYjO4rQ8ZFBqNi ? new CircleSpread_VtJNkGC54V8Ncx7LSXj8yA(this)
                {__cache_HrWV8nAJBYjO4rQ8ZFBqNi = manager_2} : that_9;
            else
            {
                this.__cache_HrWV8nAJBYjO4rQ8ZFBqNi = manager_2;
            }

            return that_9;
        }

        public n7.CircleSpread_VtJNkGC54V8Ncx7LSXj8yA __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.CircleSpread_VtJNkGC54V8Ncx7LSXj8yA that_0 = this;
            this.__cache_HrWV8nAJBYjO4rQ8ZFBqNi = null;
            return that_0;
        }

        public n7.CircleSpread_VtJNkGC54V8Ncx7LSXj8yA __CreateDefault__()
        {
            n7.CircleSpread_VtJNkGC54V8Ncx7LSXj8yA that_0 = this;
            this.__cache_HrWV8nAJBYjO4rQ8ZFBqNi = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_HrWV8nAJBYjO4rQ8ZFBqNi);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 270307U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "HrWV8nAJBYjO4rQ8ZFBqNi", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, float, float, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_HrWV8nAJBYjO4rQ8ZFBqNi = null;
        public CircleSpread_VtJNkGC54V8Ncx7LSXj8yA(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CircleSpread_VtJNkGC54V8Ncx7LSXj8yA(CircleSpread_VtJNkGC54V8Ncx7LSXj8yA other): base(other)
        {
            this.__cache_HrWV8nAJBYjO4rQ8ZFBqNi = other.__cache_HrWV8nAJBYjO4rQ8ZFBqNi;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_HrWV8nAJBYjO4rQ8ZFBqNi", in __cache_HrWV8nAJBYjO4rQ8ZFBqNi));
        }

        internal CircleSpread_VtJNkGC54V8Ncx7LSXj8yA __WITH__(n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, float, float, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_HrWV8nAJBYjO4rQ8ZFBqNi)
        {
            n7.CircleSpread_VtJNkGC54V8Ncx7LSXj8yA that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_HrWV8nAJBYjO4rQ8ZFBqNi != this.__cache_HrWV8nAJBYjO4rQ8ZFBqNi ? new CircleSpread_VtJNkGC54V8Ncx7LSXj8yA(this)
                {__cache_HrWV8nAJBYjO4rQ8ZFBqNi = __cache_HrWV8nAJBYjO4rQ8ZFBqNi} : that_0;
            else
            {
                this.__cache_HrWV8nAJBYjO4rQ8ZFBqNi = __cache_HrWV8nAJBYjO4rQ8ZFBqNi;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270362U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "UNv4cR9YdgkPYF08xpFER9", Name = "RandomSpread_UNv4cR9YdgkPYF08xpFER9")]
    [n2.SerializableAttribute]
    public class RandomSpread_UNv4cR9YdgkPYF08xpFER9 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.RandomSpread_UNv4cR9YdgkPYF08xpFER9 Create(n1.NodeContext Node_Context)
        {
            var instance = new RandomSpread_UNv4cR9YdgkPYF08xpFER9(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.RandomSpread_UNv4cR9YdgkPYF08xpFER9 CreateDefault()
        {
            var instance = new RandomSpread_UNv4cR9YdgkPYF08xpFER9(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.RandomSpread_UNv4cR9YdgkPYF08xpFER9 Update(float Center_In, [n4.SerializedDefaultValueAttribute("1", false)] float Width_In, int Seed_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<float> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_FVDVEtTx2gjOYUDQcyVGoJ;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<float, float, int, int>, n2.ValueTuple<n5.Spread<float>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<float>()));
            }

            var inputs_3 = (Center_In, Width_In, Seed_In, Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var Result_7 = n25.SpreadGenerators.RandomSpread(center: Center_In, width: Width_In, seed: Seed_In, count: Count_In);
                outputs_4 = n2.ValueTuple.Create(Result_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            Output_Out = __auto_8;
            n7.RandomSpread_UNv4cR9YdgkPYF08xpFER9 that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = manager_2 != this.__cache_FVDVEtTx2gjOYUDQcyVGoJ ? new RandomSpread_UNv4cR9YdgkPYF08xpFER9(this)
                {__cache_FVDVEtTx2gjOYUDQcyVGoJ = manager_2} : that_9;
            else
            {
                this.__cache_FVDVEtTx2gjOYUDQcyVGoJ = manager_2;
            }

            return that_9;
        }

        public n7.RandomSpread_UNv4cR9YdgkPYF08xpFER9 __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.RandomSpread_UNv4cR9YdgkPYF08xpFER9 that_0 = this;
            this.__cache_FVDVEtTx2gjOYUDQcyVGoJ = null;
            return that_0;
        }

        public n7.RandomSpread_UNv4cR9YdgkPYF08xpFER9 __CreateDefault__()
        {
            n7.RandomSpread_UNv4cR9YdgkPYF08xpFER9 that_0 = this;
            this.__cache_FVDVEtTx2gjOYUDQcyVGoJ = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_FVDVEtTx2gjOYUDQcyVGoJ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 270365U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "FVDVEtTx2gjOYUDQcyVGoJ", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<float, float, int, int>, n2.ValueTuple<n5.Spread<float>>> __cache_FVDVEtTx2gjOYUDQcyVGoJ = null;
        public RandomSpread_UNv4cR9YdgkPYF08xpFER9(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RandomSpread_UNv4cR9YdgkPYF08xpFER9(RandomSpread_UNv4cR9YdgkPYF08xpFER9 other): base(other)
        {
            this.__cache_FVDVEtTx2gjOYUDQcyVGoJ = other.__cache_FVDVEtTx2gjOYUDQcyVGoJ;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_FVDVEtTx2gjOYUDQcyVGoJ", in __cache_FVDVEtTx2gjOYUDQcyVGoJ));
        }

        internal RandomSpread_UNv4cR9YdgkPYF08xpFER9 __WITH__(n42.Manager<n2.ValueTuple<float, float, int, int>, n2.ValueTuple<n5.Spread<float>>> __cache_FVDVEtTx2gjOYUDQcyVGoJ)
        {
            n7.RandomSpread_UNv4cR9YdgkPYF08xpFER9 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_FVDVEtTx2gjOYUDQcyVGoJ != this.__cache_FVDVEtTx2gjOYUDQcyVGoJ ? new RandomSpread_UNv4cR9YdgkPYF08xpFER9(this)
                {__cache_FVDVEtTx2gjOYUDQcyVGoJ = __cache_FVDVEtTx2gjOYUDQcyVGoJ} : that_0;
            else
            {
                this.__cache_FVDVEtTx2gjOYUDQcyVGoJ = __cache_FVDVEtTx2gjOYUDQcyVGoJ;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270413U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "I9bqxWe8mNLM5M2fLOR7WK", Name = "RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK")]
    [n2.SerializableAttribute]
    public class RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK Create(n1.NodeContext Node_Context)
        {
            var instance = new RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK CreateDefault()
        {
            var instance = new RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK Update(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector2 Size_In, int Seed_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_DNWloS3MLPkPPtPXnV3DVP;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, int, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<n26.Vector2>()));
            }

            var inputs_3 = (Center_In, Size_In, Seed_In, Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                n32._Operations_.CreateRandomSpread__2D(Center_In: Center_In, Size_In: Size_In, Seed_In: Seed_In, Count_In: Count_In, Output_Out: out n5.Spread<n26.Vector2> Output_7);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            Output_Out = __auto_8;
            n7.RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = manager_2 != this.__cache_DNWloS3MLPkPPtPXnV3DVP ? new RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK(this)
                {__cache_DNWloS3MLPkPPtPXnV3DVP = manager_2} : that_9;
            else
            {
                this.__cache_DNWloS3MLPkPPtPXnV3DVP = manager_2;
            }

            return that_9;
        }

        public n7.RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK that_0 = this;
            this.__cache_DNWloS3MLPkPPtPXnV3DVP = null;
            return that_0;
        }

        public n7.RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK __CreateDefault__()
        {
            n7.RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK that_0 = this;
            this.__cache_DNWloS3MLPkPPtPXnV3DVP = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_DNWloS3MLPkPPtPXnV3DVP);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 270416U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "DNWloS3MLPkPPtPXnV3DVP", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, int, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_DNWloS3MLPkPPtPXnV3DVP = null;
        public RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK(RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK other): base(other)
        {
            this.__cache_DNWloS3MLPkPPtPXnV3DVP = other.__cache_DNWloS3MLPkPPtPXnV3DVP;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_DNWloS3MLPkPPtPXnV3DVP", in __cache_DNWloS3MLPkPPtPXnV3DVP));
        }

        internal RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK __WITH__(n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, int, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_DNWloS3MLPkPPtPXnV3DVP)
        {
            n7.RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_DNWloS3MLPkPPtPXnV3DVP != this.__cache_DNWloS3MLPkPPtPXnV3DVP ? new RandomSpread__2d_I9bqxWe8mNLM5M2fLOR7WK(this)
                {__cache_DNWloS3MLPkPPtPXnV3DVP = __cache_DNWloS3MLPkPPtPXnV3DVP} : that_0;
            else
            {
                this.__cache_DNWloS3MLPkPPtPXnV3DVP = __cache_DNWloS3MLPkPPtPXnV3DVP;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270464U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "OfbWI1PyXJBQNOMT64mrLn", Name = "RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn")]
    [n2.SerializableAttribute]
    public class RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn Create(n1.NodeContext Node_Context)
        {
            var instance = new RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn CreateDefault()
        {
            var instance = new RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn Update(n26.Vector3 Center_In, [n4.SerializedDefaultValueAttribute("1, 1, 1", false)] n26.Vector3 Size_In, int Seed_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<n26.Vector3> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_FQJg55cA336OPHpgciiHHr;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<n26.Vector3, n26.Vector3, int, int>, n2.ValueTuple<n5.Spread<n26.Vector3>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<n26.Vector3>()));
            }

            var inputs_3 = (Center_In, Size_In, Seed_In, Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                n32._Operations_.CreateRandomSpread__3D(Center_In: Center_In, Size_In: Size_In, Seed_In: Seed_In, Count_In: Count_In, Output_Out: out n5.Spread<n26.Vector3> Output_7);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            Output_Out = __auto_8;
            n7.RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = manager_2 != this.__cache_FQJg55cA336OPHpgciiHHr ? new RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn(this)
                {__cache_FQJg55cA336OPHpgciiHHr = manager_2} : that_9;
            else
            {
                this.__cache_FQJg55cA336OPHpgciiHHr = manager_2;
            }

            return that_9;
        }

        public n7.RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn that_0 = this;
            this.__cache_FQJg55cA336OPHpgciiHHr = null;
            return that_0;
        }

        public n7.RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn __CreateDefault__()
        {
            n7.RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn that_0 = this;
            this.__cache_FQJg55cA336OPHpgciiHHr = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_FQJg55cA336OPHpgciiHHr);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 270467U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "FQJg55cA336OPHpgciiHHr", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<n26.Vector3, n26.Vector3, int, int>, n2.ValueTuple<n5.Spread<n26.Vector3>>> __cache_FQJg55cA336OPHpgciiHHr = null;
        public RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn(RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn other): base(other)
        {
            this.__cache_FQJg55cA336OPHpgciiHHr = other.__cache_FQJg55cA336OPHpgciiHHr;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_FQJg55cA336OPHpgciiHHr", in __cache_FQJg55cA336OPHpgciiHHr));
        }

        internal RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn __WITH__(n42.Manager<n2.ValueTuple<n26.Vector3, n26.Vector3, int, int>, n2.ValueTuple<n5.Spread<n26.Vector3>>> __cache_FQJg55cA336OPHpgciiHHr)
        {
            n7.RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_FQJg55cA336OPHpgciiHHr != this.__cache_FQJg55cA336OPHpgciiHHr ? new RandomSpread__3d_OfbWI1PyXJBQNOMT64mrLn(this)
                {__cache_FQJg55cA336OPHpgciiHHr = __cache_FQJg55cA336OPHpgciiHHr} : that_0;
            else
            {
                this.__cache_FQJg55cA336OPHpgciiHHr = __cache_FQJg55cA336OPHpgciiHHr;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270515U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "ImHrgx8LdteMTNwaf5kKle", Name = "RectangleSpread_ImHrgx8LdteMTNwaf5kKle")]
    [n2.SerializableAttribute]
    public class RectangleSpread_ImHrgx8LdteMTNwaf5kKle : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.RectangleSpread_ImHrgx8LdteMTNwaf5kKle Create(n1.NodeContext Node_Context)
        {
            var instance = new RectangleSpread_ImHrgx8LdteMTNwaf5kKle(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.RectangleSpread_ImHrgx8LdteMTNwaf5kKle CreateDefault()
        {
            var instance = new RectangleSpread_ImHrgx8LdteMTNwaf5kKle(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.RectangleSpread_ImHrgx8LdteMTNwaf5kKle Update(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector2 Size_In, [n4.SerializedDefaultValueAttribute("1", false)] int Subdivision_Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_QTKoAtSM5BMNse09FOeTeD;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<n26.Vector2>()));
            }

            var inputs_3 = (Center_In, Size_In, Subdivision_Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                n32._Operations_.CreateRectangleSpread(Center_In: Center_In, Size_In: Size_In, Subdivision_Count_In: Subdivision_Count_In, Output_Out: out n5.Spread<n26.Vector2> Output_7);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            Output_Out = __auto_8;
            n7.RectangleSpread_ImHrgx8LdteMTNwaf5kKle that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = manager_2 != this.__cache_QTKoAtSM5BMNse09FOeTeD ? new RectangleSpread_ImHrgx8LdteMTNwaf5kKle(this)
                {__cache_QTKoAtSM5BMNse09FOeTeD = manager_2} : that_9;
            else
            {
                this.__cache_QTKoAtSM5BMNse09FOeTeD = manager_2;
            }

            return that_9;
        }

        public n7.RectangleSpread_ImHrgx8LdteMTNwaf5kKle __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.RectangleSpread_ImHrgx8LdteMTNwaf5kKle that_0 = this;
            this.__cache_QTKoAtSM5BMNse09FOeTeD = null;
            return that_0;
        }

        public n7.RectangleSpread_ImHrgx8LdteMTNwaf5kKle __CreateDefault__()
        {
            n7.RectangleSpread_ImHrgx8LdteMTNwaf5kKle that_0 = this;
            this.__cache_QTKoAtSM5BMNse09FOeTeD = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_QTKoAtSM5BMNse09FOeTeD);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 270518U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "QTKoAtSM5BMNse09FOeTeD", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_QTKoAtSM5BMNse09FOeTeD = null;
        public RectangleSpread_ImHrgx8LdteMTNwaf5kKle(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RectangleSpread_ImHrgx8LdteMTNwaf5kKle(RectangleSpread_ImHrgx8LdteMTNwaf5kKle other): base(other)
        {
            this.__cache_QTKoAtSM5BMNse09FOeTeD = other.__cache_QTKoAtSM5BMNse09FOeTeD;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_QTKoAtSM5BMNse09FOeTeD", in __cache_QTKoAtSM5BMNse09FOeTeD));
        }

        internal RectangleSpread_ImHrgx8LdteMTNwaf5kKle __WITH__(n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_QTKoAtSM5BMNse09FOeTeD)
        {
            n7.RectangleSpread_ImHrgx8LdteMTNwaf5kKle that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_QTKoAtSM5BMNse09FOeTeD != this.__cache_QTKoAtSM5BMNse09FOeTeD ? new RectangleSpread_ImHrgx8LdteMTNwaf5kKle(this)
                {__cache_QTKoAtSM5BMNse09FOeTeD = __cache_QTKoAtSM5BMNse09FOeTeD} : that_0;
            else
            {
                this.__cache_QTKoAtSM5BMNse09FOeTeD = __cache_QTKoAtSM5BMNse09FOeTeD;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270559U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Rmt2XaCR3RxM2abd2aMFQm", Name = "RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm")]
    [n2.SerializableAttribute]
    public class RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm Create(n1.NodeContext Node_Context)
        {
            var instance = new RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm CreateDefault()
        {
            var instance = new RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm Update(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector2 Size_In, [n4.SerializedDefaultValueAttribute("1", false)] float Corner_Radius_In, [n4.SerializedDefaultValueAttribute("1", false)] int Corner_Resolution_In, [n4.SerializedDefaultValueAttribute("1", false)] int Subdivision_Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_BFqanpebIzmOy5mnRxEe3E;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, float, int, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<n26.Vector2>()));
            }

            var inputs_3 = (Center_In, Size_In, Corner_Radius_In, Corner_Resolution_In, Subdivision_Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                n32._Operations_.CreateRoundRectSpread(Center_In: Center_In, Size_In: Size_In, Corner_Radius_In: Corner_Radius_In, Corner_Resolution_In: Corner_Resolution_In, Subdivision_Count_In: Subdivision_Count_In, Output_Out: out n5.Spread<n26.Vector2> Output_7);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            Output_Out = __auto_8;
            n7.RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = manager_2 != this.__cache_BFqanpebIzmOy5mnRxEe3E ? new RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm(this)
                {__cache_BFqanpebIzmOy5mnRxEe3E = manager_2} : that_9;
            else
            {
                this.__cache_BFqanpebIzmOy5mnRxEe3E = manager_2;
            }

            return that_9;
        }

        public n7.RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm that_0 = this;
            this.__cache_BFqanpebIzmOy5mnRxEe3E = null;
            return that_0;
        }

        public n7.RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm __CreateDefault__()
        {
            n7.RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm that_0 = this;
            this.__cache_BFqanpebIzmOy5mnRxEe3E = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_BFqanpebIzmOy5mnRxEe3E);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 270562U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "BFqanpebIzmOy5mnRxEe3E", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, float, int, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_BFqanpebIzmOy5mnRxEe3E = null;
        public RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm(RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm other): base(other)
        {
            this.__cache_BFqanpebIzmOy5mnRxEe3E = other.__cache_BFqanpebIzmOy5mnRxEe3E;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_BFqanpebIzmOy5mnRxEe3E", in __cache_BFqanpebIzmOy5mnRxEe3E));
        }

        internal RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm __WITH__(n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, float, int, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_BFqanpebIzmOy5mnRxEe3E)
        {
            n7.RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_BFqanpebIzmOy5mnRxEe3E != this.__cache_BFqanpebIzmOy5mnRxEe3E ? new RoundRectSpread_Rmt2XaCR3RxM2abd2aMFQm(this)
                {__cache_BFqanpebIzmOy5mnRxEe3E = __cache_BFqanpebIzmOy5mnRxEe3E} : that_0;
            else
            {
                this.__cache_BFqanpebIzmOy5mnRxEe3E = __cache_BFqanpebIzmOy5mnRxEe3E;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270617U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "ITJBOIsA5GyN2o4e0Az4vv", Name = "SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv")]
    [n2.SerializableAttribute]
    public class SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv Create(n1.NodeContext Node_Context)
        {
            var instance = new SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv CreateDefault()
        {
            var instance = new SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv Update(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector2 Size_In, [n4.SerializedDefaultValueAttribute("1", false)] float Factor_In, float Phase_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_IkZeMJ8X7GGNnqlE8wR34R;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, float, float, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<n26.Vector2>()));
            }

            var inputs_3 = (Center_In, Size_In, Factor_In, Phase_In, Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                n32._Operations_.CreateSpiralSpread(Center_In: Center_In, Size_In: Size_In, Factor_In: Factor_In, Phase_In: Phase_In, Count_In: Count_In, Output_Out: out n5.Spread<n26.Vector2> Output_7);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            Output_Out = __auto_8;
            n7.SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = manager_2 != this.__cache_IkZeMJ8X7GGNnqlE8wR34R ? new SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv(this)
                {__cache_IkZeMJ8X7GGNnqlE8wR34R = manager_2} : that_9;
            else
            {
                this.__cache_IkZeMJ8X7GGNnqlE8wR34R = manager_2;
            }

            return that_9;
        }

        public n7.SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv that_0 = this;
            this.__cache_IkZeMJ8X7GGNnqlE8wR34R = null;
            return that_0;
        }

        public n7.SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv __CreateDefault__()
        {
            n7.SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv that_0 = this;
            this.__cache_IkZeMJ8X7GGNnqlE8wR34R = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_IkZeMJ8X7GGNnqlE8wR34R);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 270620U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "IkZeMJ8X7GGNnqlE8wR34R", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, float, float, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_IkZeMJ8X7GGNnqlE8wR34R = null;
        public SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv(SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv other): base(other)
        {
            this.__cache_IkZeMJ8X7GGNnqlE8wR34R = other.__cache_IkZeMJ8X7GGNnqlE8wR34R;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_IkZeMJ8X7GGNnqlE8wR34R", in __cache_IkZeMJ8X7GGNnqlE8wR34R));
        }

        internal SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv __WITH__(n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, float, float, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_IkZeMJ8X7GGNnqlE8wR34R)
        {
            n7.SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_IkZeMJ8X7GGNnqlE8wR34R != this.__cache_IkZeMJ8X7GGNnqlE8wR34R ? new SpiralSpread_ITJBOIsA5GyN2o4e0Az4vv(this)
                {__cache_IkZeMJ8X7GGNnqlE8wR34R = __cache_IkZeMJ8X7GGNnqlE8wR34R} : that_0;
            else
            {
                this.__cache_IkZeMJ8X7GGNnqlE8wR34R = __cache_IkZeMJ8X7GGNnqlE8wR34R;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270675U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "FAIbH9p5d7oOdhJHCXhJTA", Name = "StarSpread_FAIbH9p5d7oOdhJHCXhJTA")]
    [n2.SerializableAttribute]
    public class StarSpread_FAIbH9p5d7oOdhJHCXhJTA : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.StarSpread_FAIbH9p5d7oOdhJHCXhJTA Create(n1.NodeContext Node_Context)
        {
            var instance = new StarSpread_FAIbH9p5d7oOdhJHCXhJTA(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.StarSpread_FAIbH9p5d7oOdhJHCXhJTA CreateDefault()
        {
            var instance = new StarSpread_FAIbH9p5d7oOdhJHCXhJTA(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.StarSpread_FAIbH9p5d7oOdhJHCXhJTA Update(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("0.25", false)] float Radius_1_In, [n4.SerializedDefaultValueAttribute("0.5", false)] float Radius_2_In, float Phase_In, [n4.SerializedDefaultValueAttribute("3", false)] int Spike_Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_TpEDQOjlEitLGXeaMztKhQ;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<n26.Vector2, float, float, float, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<n26.Vector2>()));
            }

            var inputs_3 = (Center_In, Radius_1_In, Radius_2_In, Phase_In, Spike_Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                n32._Operations_.CreateStarSpread(Center_In: Center_In, Radius_1_In: Radius_1_In, Radius_2_In: Radius_2_In, Phase_In: Phase_In, Spike_Count_In: Spike_Count_In, Output_Out: out n5.Spread<n26.Vector2> Output_7);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            Output_Out = __auto_8;
            n7.StarSpread_FAIbH9p5d7oOdhJHCXhJTA that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = manager_2 != this.__cache_TpEDQOjlEitLGXeaMztKhQ ? new StarSpread_FAIbH9p5d7oOdhJHCXhJTA(this)
                {__cache_TpEDQOjlEitLGXeaMztKhQ = manager_2} : that_9;
            else
            {
                this.__cache_TpEDQOjlEitLGXeaMztKhQ = manager_2;
            }

            return that_9;
        }

        public n7.StarSpread_FAIbH9p5d7oOdhJHCXhJTA __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.StarSpread_FAIbH9p5d7oOdhJHCXhJTA that_0 = this;
            this.__cache_TpEDQOjlEitLGXeaMztKhQ = null;
            return that_0;
        }

        public n7.StarSpread_FAIbH9p5d7oOdhJHCXhJTA __CreateDefault__()
        {
            n7.StarSpread_FAIbH9p5d7oOdhJHCXhJTA that_0 = this;
            this.__cache_TpEDQOjlEitLGXeaMztKhQ = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_TpEDQOjlEitLGXeaMztKhQ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 270678U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "TpEDQOjlEitLGXeaMztKhQ", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<n26.Vector2, float, float, float, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_TpEDQOjlEitLGXeaMztKhQ = null;
        public StarSpread_FAIbH9p5d7oOdhJHCXhJTA(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal StarSpread_FAIbH9p5d7oOdhJHCXhJTA(StarSpread_FAIbH9p5d7oOdhJHCXhJTA other): base(other)
        {
            this.__cache_TpEDQOjlEitLGXeaMztKhQ = other.__cache_TpEDQOjlEitLGXeaMztKhQ;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_TpEDQOjlEitLGXeaMztKhQ", in __cache_TpEDQOjlEitLGXeaMztKhQ));
        }

        internal StarSpread_FAIbH9p5d7oOdhJHCXhJTA __WITH__(n42.Manager<n2.ValueTuple<n26.Vector2, float, float, float, int>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_TpEDQOjlEitLGXeaMztKhQ)
        {
            n7.StarSpread_FAIbH9p5d7oOdhJHCXhJTA that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_TpEDQOjlEitLGXeaMztKhQ != this.__cache_TpEDQOjlEitLGXeaMztKhQ ? new StarSpread_FAIbH9p5d7oOdhJHCXhJTA(this)
                {__cache_TpEDQOjlEitLGXeaMztKhQ = __cache_TpEDQOjlEitLGXeaMztKhQ} : that_0;
            else
            {
                this.__cache_TpEDQOjlEitLGXeaMztKhQ = __cache_TpEDQOjlEitLGXeaMztKhQ;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270733U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Dsg6LDbSTKKNmL4xybMFXh", Name = "Queue_Dsg6LDbSTKKNmL4xybMFXh")]
    [n2.SerializableAttribute]
    public class Queue_Dsg6LDbSTKKNmL4xybMFXh<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.Queue_Dsg6LDbSTKKNmL4xybMFXh<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Queue_Dsg6LDbSTKKNmL4xybMFXh<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.Queue_Dsg6LDbSTKKNmL4xybMFXh<T> CreateDefault()
        {
            var instance = new Queue_Dsg6LDbSTKKNmL4xybMFXh<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.Queue_Dsg6LDbSTKKNmL4xybMFXh<T> Update(T Input_In, [n4.SerializedDefaultValueAttribute("-1", false)] int Frame_Count_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Clear_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Insert_In, out n5.Spread<T> Output_Out)
        {
            n5.SpreadBuilder<T> __auto_0 = this.Data;
            int Index_1 = 0;
            var Output_2 = __auto_0;
            if (Insert_In)
            {
                n24._Operations_.Insert<T>(Input_In: __auto_0, Index_In: Index_1, Item_In: Input_In, Output_Out: out Output_2);
            }

            n24._Operations_.Count<T>(Input_In: Output_2, Output_Out: out n5.SpreadBuilder<T> Output_3, Count_Out: out int Count_4);
            int Input_2_5 = 0;
            var Result_6 = Frame_Count_In >= Input_2_5;
            n5.SpreadBuilder<T> __auto_7;
            if (Result_6)
            {
                var Output_9 = Count_4 - Frame_Count_In;
                int Input_2_10 = 0;
                n13._Operations_.Max<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_9, Input_2_In: Input_2_10, Output_Out: out int Output_11);
                n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_11, Input_2_In: Count_4, Output_Out: out int Output_12);
                var Output_13 = Count_4 - Output_12;
                n24._Operations_.RemoveRange<T>(Input_In: Output_3, Index_In: Output_13, Count_In: Output_12, Output_Out: out n5.SpreadBuilder<T> Output_14);
                __auto_7 = Output_14;
            }
            else
            {
                __auto_7 = Output_3;
            }

            var Output_15 = __auto_7;
            if (Clear_In)
            {
                n24._Operations_.Clear<T>(Input_In: __auto_7, Output_Out: out Output_15);
            }

            n24._Operations_.ToSpread<T>(Input_In: Output_15, Output_Out: out n5.SpreadBuilder<T> Output_16, Result_Out: out n5.Spread<T> Result_17);
            Output_Out = Result_17;
            return this;
        }

        public n7.Queue_Dsg6LDbSTKKNmL4xybMFXh<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.Queue_Dsg6LDbSTKKNmL4xybMFXh<T> that_0 = this;
            this.Data = n24._Operations_.CreateDefault<T>();
            return that_0;
        }

        public n7.Queue_Dsg6LDbSTKKNmL4xybMFXh<T> __CreateDefault__()
        {
            n7.Queue_Dsg6LDbSTKKNmL4xybMFXh<T> that_0 = this;
            this.Data = n24._Operations_.CreateDefault<T>();
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

        [n1.ElementAttribute(TracingId = 270743U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "G5GNYT1waQRNsY5F2C5qHW", Name = "Data")]
        public n5.SpreadBuilder<T> Data;
        public Queue_Dsg6LDbSTKKNmL4xybMFXh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Queue_Dsg6LDbSTKKNmL4xybMFXh(Queue_Dsg6LDbSTKKNmL4xybMFXh<T> other): base(other)
        {
            this.Data = other.Data;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Data", in Data));
        }

        internal Queue_Dsg6LDbSTKKNmL4xybMFXh<T> __WITH__(n5.SpreadBuilder<T> Data)
        {
            n7.Queue_Dsg6LDbSTKKNmL4xybMFXh<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Data != this.Data ? new Queue_Dsg6LDbSTKKNmL4xybMFXh<T>(this)
                {Data = Data} : that_0;
            else
            {
                this.Data = Data;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270951U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "QKHJtW5MfCeOm2LyKhYalN", Name = "Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN")]
    [n2.SerializableAttribute]
    public class Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>, n18.IAdaptiveCreateDefault<T>
        {
            var instance = new Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T> CreateDefault<AdM>()
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>, n18.IAdaptiveCreateDefault<T>
        {
            var instance = new Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n7.Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T> Update<T2>(T2 Input_In, out n5.Spread<T> Output_Out, out n5.Spread<int> Indices_Out)
            where T2 : n6.IEnumerable<T>
        {
            n2.Func<T, int, n6.KeyValuePair<T, int>> __pad_U7siay3b3OvQM8GU7e3mJ5_0 = this.__slot_U7siay3b3OvQM8GU7e3mJ5;
            n2.Func<n6.KeyValuePair<T, int>, T> __pad_KP5iYWj7kpuQZyhFySAk1m_1 = this.__slot_KP5iYWj7kpuQZyhFySAk1m;
            n6.IEnumerable<T> Input_2 = (n6.IEnumerable<T>)Input_In;
            n8._Operations_.Select<T, n6.KeyValuePair<T, int>>(Input_In: Input_2, Transformer_In: __pad_U7siay3b3OvQM8GU7e3mJ5_0, Output_Out: out n6.IEnumerable<n6.KeyValuePair<T, int>> Output_3);
            n8._Operations_.OrderBy<n6.KeyValuePair<T, int>, T>(Input_In: Output_3, Key_Selector_In: __pad_KP5iYWj7kpuQZyhFySAk1m_1, Result_Out: out n39.IOrderedEnumerable<n6.KeyValuePair<T, int>> Result_4);
            var builder_12 = n4.CollectionBuilders.GetBuilder(this.__cp_TQzgZZtcOpNMKh0kEZnhj8, 16);
            n5.Spread<T> output_13;
            var builder_14 = n4.CollectionBuilders.GetBuilder(this.__cp_I35RqWsXXGyNOM3ybEi2Lk, 16);
            n5.Spread<int> output_15;
            try
            {
                var i_7 = 0;
                foreach (var item_5 in Result_4)
                {
                    var splicer_6 = item_5;
                    var i_local_8 = i_7;
                    n20._Operations_.Split<T, int>(Input_In: splicer_6, Key_Out: out T Key_10, Value_Out: out int Value_11);
                    builder_12.Add(Key_10);
                    builder_14.Add(Value_11);
                    i_7++;
                }
            }
            finally
            {
                output_13 = builder_12.Commit();
                output_15 = builder_14.Commit();
            }

            Output_Out = output_13;
            Indices_Out = output_15;
            n7.Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T> that_16 = this;
            if (this.__GetContext__().IsImmutable)
                that_16 = output_13 != this.__cp_TQzgZZtcOpNMKh0kEZnhj8 || output_15 != this.__cp_I35RqWsXXGyNOM3ybEi2Lk ? new Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T>(this)
                {__cp_TQzgZZtcOpNMKh0kEZnhj8 = output_13, __cp_I35RqWsXXGyNOM3ybEi2Lk = output_15} : that_16;
            else
            {
                this.__cp_TQzgZZtcOpNMKh0kEZnhj8 = output_13;
                this.__cp_I35RqWsXXGyNOM3ybEi2Lk = output_15;
            }

            return that_16;
        }

        public n7.Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>, n18.IAdaptiveCreateDefault<T>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            var __fallback___1 = n1.ServiceRegistry.Current;
            n2.Func<n6.KeyValuePair<T, int>, T> Functionality_5 = (n6.KeyValuePair<T, int> Arg_In_3) =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                var Key_4 = Arg_In_3.Key;
                return Key_4;
            }

            ;
            n2.Func<n6.KeyValuePair<T, int>, T> __pad_KP5iYWj7kpuQZyhFySAk1m_6 = Functionality_5;
            n2.Func<T, int, n6.KeyValuePair<T, int>> Functionality_11 = (T Arg_1_In_8, int Arg_2_In_9) =>
            {
                using var __current_7 = __fallback___1.MakeCurrentIfNone();
                var Output_10 = new n6.KeyValuePair<T, int>(key: Arg_1_In_8, value: Arg_2_In_9);
                return Output_10;
            }

            ;
            n2.Func<T, int, n6.KeyValuePair<T, int>> __pad_U7siay3b3OvQM8GU7e3mJ5_12 = Functionality_11;
            n7.Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T> that_13 = this;
            this.__slot_KP5iYWj7kpuQZyhFySAk1m = Functionality_5;
            this.__slot_U7siay3b3OvQM8GU7e3mJ5 = Functionality_11;
            this.__cp_TQzgZZtcOpNMKh0kEZnhj8 = n7._Operations_.CreateDefault<T>();
            this.__cp_I35RqWsXXGyNOM3ybEi2Lk = n7._Operations_.CreateDefault<int>();
            return that_13;
        }

        public n7.Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T> __CreateDefault__<AdM>()
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>, n18.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n7.Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T> that_1 = this;
            this.__slot_KP5iYWj7kpuQZyhFySAk1m = n17._Operations_.CreateDefault<n6.KeyValuePair<T, int>, T, AdM>();
            this.__slot_U7siay3b3OvQM8GU7e3mJ5 = n47._Operations_.CreateDefault<T, int, n6.KeyValuePair<T, int>, AdM>();
            this.__cp_TQzgZZtcOpNMKh0kEZnhj8 = n7._Operations_.CreateDefault<T>();
            this.__cp_I35RqWsXXGyNOM3ybEi2Lk = n7._Operations_.CreateDefault<int>();
            return that_1;
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

        [n1.ElementAttribute(TracingId = 270984U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "KP5iYWj7kpuQZyhFySAk1m", Name = "__slot_KP5iYWj7kpuQZyhFySAk1m")]
        public n2.Func<n6.KeyValuePair<T, int>, T> __slot_KP5iYWj7kpuQZyhFySAk1m;
        [n1.ElementAttribute(TracingId = 271002U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "U7siay3b3OvQM8GU7e3mJ5", Name = "__slot_U7siay3b3OvQM8GU7e3mJ5")]
        public n2.Func<T, int, n6.KeyValuePair<T, int>> __slot_U7siay3b3OvQM8GU7e3mJ5;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<T> __cp_TQzgZZtcOpNMKh0kEZnhj8;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<int> __cp_I35RqWsXXGyNOM3ybEi2Lk;
        public Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN(Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T> other): base(other)
        {
            this.__slot_KP5iYWj7kpuQZyhFySAk1m = other.__slot_KP5iYWj7kpuQZyhFySAk1m;
            this.__slot_U7siay3b3OvQM8GU7e3mJ5 = other.__slot_U7siay3b3OvQM8GU7e3mJ5;
            this.__cp_TQzgZZtcOpNMKh0kEZnhj8 = other.__cp_TQzgZZtcOpNMKh0kEZnhj8;
            this.__cp_I35RqWsXXGyNOM3ybEi2Lk = other.__cp_I35RqWsXXGyNOM3ybEi2Lk;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_KP5iYWj7kpuQZyhFySAk1m", in __slot_KP5iYWj7kpuQZyhFySAk1m), n1.CompilationHelper.GetValueOrExisting(values, "__slot_U7siay3b3OvQM8GU7e3mJ5", in __slot_U7siay3b3OvQM8GU7e3mJ5), n1.CompilationHelper.GetValueOrExisting(values, "__cp_TQzgZZtcOpNMKh0kEZnhj8", in __cp_TQzgZZtcOpNMKh0kEZnhj8), n1.CompilationHelper.GetValueOrExisting(values, "__cp_I35RqWsXXGyNOM3ybEi2Lk", in __cp_I35RqWsXXGyNOM3ybEi2Lk));
        }

        internal Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T> __WITH__(n2.Func<n6.KeyValuePair<T, int>, T> __slot_KP5iYWj7kpuQZyhFySAk1m, n2.Func<T, int, n6.KeyValuePair<T, int>> __slot_U7siay3b3OvQM8GU7e3mJ5, n5.Spread<T> __cp_TQzgZZtcOpNMKh0kEZnhj8, n5.Spread<int> __cp_I35RqWsXXGyNOM3ybEi2Lk)
        {
            n7.Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_KP5iYWj7kpuQZyhFySAk1m != this.__slot_KP5iYWj7kpuQZyhFySAk1m || __slot_U7siay3b3OvQM8GU7e3mJ5 != this.__slot_U7siay3b3OvQM8GU7e3mJ5 || __cp_TQzgZZtcOpNMKh0kEZnhj8 != this.__cp_TQzgZZtcOpNMKh0kEZnhj8 || __cp_I35RqWsXXGyNOM3ybEi2Lk != this.__cp_I35RqWsXXGyNOM3ybEi2Lk ? new Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<T>(this)
                {__slot_KP5iYWj7kpuQZyhFySAk1m = __slot_KP5iYWj7kpuQZyhFySAk1m, __slot_U7siay3b3OvQM8GU7e3mJ5 = __slot_U7siay3b3OvQM8GU7e3mJ5, __cp_TQzgZZtcOpNMKh0kEZnhj8 = __cp_TQzgZZtcOpNMKh0kEZnhj8, __cp_I35RqWsXXGyNOM3ybEi2Lk = __cp_I35RqWsXXGyNOM3ybEi2Lk} : that_0;
            else
            {
                this.__slot_KP5iYWj7kpuQZyhFySAk1m = __slot_KP5iYWj7kpuQZyhFySAk1m;
                this.__slot_U7siay3b3OvQM8GU7e3mJ5 = __slot_U7siay3b3OvQM8GU7e3mJ5;
                this.__cp_TQzgZZtcOpNMKh0kEZnhj8 = __cp_TQzgZZtcOpNMKh0kEZnhj8;
                this.__cp_I35RqWsXXGyNOM3ybEi2Lk = __cp_I35RqWsXXGyNOM3ybEi2Lk;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 271036U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "EkN5CW1bEzkOKLlmTrikpv", Name = "SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv")]
    [n2.SerializableAttribute]
    public class SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>, n18.IAdaptiveCreateDefault<T>
        {
            var instance = new SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T> CreateDefault<AdM>()
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>, n18.IAdaptiveCreateDefault<T>
        {
            var instance = new SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n7.SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T> Update<T2>(T2 Input_In, out n5.Spread<T> Output_Out, out n5.Spread<int> Indices_Out)
            where T2 : n6.IEnumerable<T>
        {
            n2.Func<T, int, n6.KeyValuePair<T, int>> __pad_EZNu6IAbhlgMbzZeKEdCNF_0 = this.__slot_EZNu6IAbhlgMbzZeKEdCNF;
            n2.Func<n6.KeyValuePair<T, int>, T> __pad_QDcjzz2xMSCNa6arMulu19_1 = this.__slot_QDcjzz2xMSCNa6arMulu19;
            n6.IEnumerable<T> Input_2 = (n6.IEnumerable<T>)Input_In;
            n8._Operations_.Select<T, n6.KeyValuePair<T, int>>(Input_In: Input_2, Transformer_In: __pad_EZNu6IAbhlgMbzZeKEdCNF_0, Output_Out: out n6.IEnumerable<n6.KeyValuePair<T, int>> Output_3);
            n8._Operations_.OrderByDescending<n6.KeyValuePair<T, int>, T>(Input_In: Output_3, Key_Selector_In: __pad_QDcjzz2xMSCNa6arMulu19_1, Result_Out: out n39.IOrderedEnumerable<n6.KeyValuePair<T, int>> Result_4);
            var builder_12 = n4.CollectionBuilders.GetBuilder(this.__cp_ATPK9A4iDCUMdqQujZnlgK, 16);
            n5.Spread<T> output_13;
            var builder_14 = n4.CollectionBuilders.GetBuilder(this.__cp_UEyPtNTYBoBLXEM2BM7xtc, 16);
            n5.Spread<int> output_15;
            try
            {
                var i_7 = 0;
                foreach (var item_5 in Result_4)
                {
                    var splicer_6 = item_5;
                    var i_local_8 = i_7;
                    n20._Operations_.Split<T, int>(Input_In: splicer_6, Key_Out: out T Key_10, Value_Out: out int Value_11);
                    builder_12.Add(Key_10);
                    builder_14.Add(Value_11);
                    i_7++;
                }
            }
            finally
            {
                output_13 = builder_12.Commit();
                output_15 = builder_14.Commit();
            }

            Output_Out = output_13;
            Indices_Out = output_15;
            n7.SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T> that_16 = this;
            if (this.__GetContext__().IsImmutable)
                that_16 = output_13 != this.__cp_ATPK9A4iDCUMdqQujZnlgK || output_15 != this.__cp_UEyPtNTYBoBLXEM2BM7xtc ? new SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T>(this)
                {__cp_ATPK9A4iDCUMdqQujZnlgK = output_13, __cp_UEyPtNTYBoBLXEM2BM7xtc = output_15} : that_16;
            else
            {
                this.__cp_ATPK9A4iDCUMdqQujZnlgK = output_13;
                this.__cp_UEyPtNTYBoBLXEM2BM7xtc = output_15;
            }

            return that_16;
        }

        public n7.SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>, n18.IAdaptiveCreateDefault<T>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            var __fallback___1 = n1.ServiceRegistry.Current;
            n2.Func<n6.KeyValuePair<T, int>, T> Functionality_5 = (n6.KeyValuePair<T, int> Arg_In_3) =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                var Key_4 = Arg_In_3.Key;
                return Key_4;
            }

            ;
            n2.Func<n6.KeyValuePair<T, int>, T> __pad_QDcjzz2xMSCNa6arMulu19_6 = Functionality_5;
            n2.Func<T, int, n6.KeyValuePair<T, int>> Functionality_11 = (T Arg_1_In_8, int Arg_2_In_9) =>
            {
                using var __current_7 = __fallback___1.MakeCurrentIfNone();
                var Output_10 = new n6.KeyValuePair<T, int>(key: Arg_1_In_8, value: Arg_2_In_9);
                return Output_10;
            }

            ;
            n2.Func<T, int, n6.KeyValuePair<T, int>> __pad_EZNu6IAbhlgMbzZeKEdCNF_12 = Functionality_11;
            n7.SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T> that_13 = this;
            this.__slot_QDcjzz2xMSCNa6arMulu19 = Functionality_5;
            this.__slot_EZNu6IAbhlgMbzZeKEdCNF = Functionality_11;
            this.__cp_ATPK9A4iDCUMdqQujZnlgK = n7._Operations_.CreateDefault<T>();
            this.__cp_UEyPtNTYBoBLXEM2BM7xtc = n7._Operations_.CreateDefault<int>();
            return that_13;
        }

        public n7.SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T> __CreateDefault__<AdM>()
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>, n18.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n7.SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T> that_1 = this;
            this.__slot_QDcjzz2xMSCNa6arMulu19 = n17._Operations_.CreateDefault<n6.KeyValuePair<T, int>, T, AdM>();
            this.__slot_EZNu6IAbhlgMbzZeKEdCNF = n47._Operations_.CreateDefault<T, int, n6.KeyValuePair<T, int>, AdM>();
            this.__cp_ATPK9A4iDCUMdqQujZnlgK = n7._Operations_.CreateDefault<T>();
            this.__cp_UEyPtNTYBoBLXEM2BM7xtc = n7._Operations_.CreateDefault<int>();
            return that_1;
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

        [n1.ElementAttribute(TracingId = 271069U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "QDcjzz2xMSCNa6arMulu19", Name = "__slot_QDcjzz2xMSCNa6arMulu19")]
        public n2.Func<n6.KeyValuePair<T, int>, T> __slot_QDcjzz2xMSCNa6arMulu19;
        [n1.ElementAttribute(TracingId = 271087U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "EZNu6IAbhlgMbzZeKEdCNF", Name = "__slot_EZNu6IAbhlgMbzZeKEdCNF")]
        public n2.Func<T, int, n6.KeyValuePair<T, int>> __slot_EZNu6IAbhlgMbzZeKEdCNF;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<T> __cp_ATPK9A4iDCUMdqQujZnlgK;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<int> __cp_UEyPtNTYBoBLXEM2BM7xtc;
        public SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv(SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T> other): base(other)
        {
            this.__slot_QDcjzz2xMSCNa6arMulu19 = other.__slot_QDcjzz2xMSCNa6arMulu19;
            this.__slot_EZNu6IAbhlgMbzZeKEdCNF = other.__slot_EZNu6IAbhlgMbzZeKEdCNF;
            this.__cp_ATPK9A4iDCUMdqQujZnlgK = other.__cp_ATPK9A4iDCUMdqQujZnlgK;
            this.__cp_UEyPtNTYBoBLXEM2BM7xtc = other.__cp_UEyPtNTYBoBLXEM2BM7xtc;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_QDcjzz2xMSCNa6arMulu19", in __slot_QDcjzz2xMSCNa6arMulu19), n1.CompilationHelper.GetValueOrExisting(values, "__slot_EZNu6IAbhlgMbzZeKEdCNF", in __slot_EZNu6IAbhlgMbzZeKEdCNF), n1.CompilationHelper.GetValueOrExisting(values, "__cp_ATPK9A4iDCUMdqQujZnlgK", in __cp_ATPK9A4iDCUMdqQujZnlgK), n1.CompilationHelper.GetValueOrExisting(values, "__cp_UEyPtNTYBoBLXEM2BM7xtc", in __cp_UEyPtNTYBoBLXEM2BM7xtc));
        }

        internal SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T> __WITH__(n2.Func<n6.KeyValuePair<T, int>, T> __slot_QDcjzz2xMSCNa6arMulu19, n2.Func<T, int, n6.KeyValuePair<T, int>> __slot_EZNu6IAbhlgMbzZeKEdCNF, n5.Spread<T> __cp_ATPK9A4iDCUMdqQujZnlgK, n5.Spread<int> __cp_UEyPtNTYBoBLXEM2BM7xtc)
        {
            n7.SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_QDcjzz2xMSCNa6arMulu19 != this.__slot_QDcjzz2xMSCNa6arMulu19 || __slot_EZNu6IAbhlgMbzZeKEdCNF != this.__slot_EZNu6IAbhlgMbzZeKEdCNF || __cp_ATPK9A4iDCUMdqQujZnlgK != this.__cp_ATPK9A4iDCUMdqQujZnlgK || __cp_UEyPtNTYBoBLXEM2BM7xtc != this.__cp_UEyPtNTYBoBLXEM2BM7xtc ? new SortDescending_FormerIndex_EkN5CW1bEzkOKLlmTrikpv<T>(this)
                {__slot_QDcjzz2xMSCNa6arMulu19 = __slot_QDcjzz2xMSCNa6arMulu19, __slot_EZNu6IAbhlgMbzZeKEdCNF = __slot_EZNu6IAbhlgMbzZeKEdCNF, __cp_ATPK9A4iDCUMdqQujZnlgK = __cp_ATPK9A4iDCUMdqQujZnlgK, __cp_UEyPtNTYBoBLXEM2BM7xtc = __cp_UEyPtNTYBoBLXEM2BM7xtc} : that_0;
            else
            {
                this.__slot_QDcjzz2xMSCNa6arMulu19 = __slot_QDcjzz2xMSCNa6arMulu19;
                this.__slot_EZNu6IAbhlgMbzZeKEdCNF = __slot_EZNu6IAbhlgMbzZeKEdCNF;
                this.__cp_ATPK9A4iDCUMdqQujZnlgK = __cp_ATPK9A4iDCUMdqQujZnlgK;
                this.__cp_UEyPtNTYBoBLXEM2BM7xtc = __cp_UEyPtNTYBoBLXEM2BM7xtc;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 271121U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "SNAab9r0y7NPAcJeyZyvid", Name = "OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid")]
    [n2.SerializableAttribute]
    public class OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>
        {
            var instance = new OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T> CreateDefault<AdM>()
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>
        {
            var instance = new OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n7.OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T> Update<T2, T4>(n2.Func<T, T2> Key_Selector_In, T4 Input_In, out n5.Spread<T> Output_Out, out n5.Spread<int> Indices_Out)
            where T4 : n6.IEnumerable<T>
        {
            n2.Func<T, int, n6.KeyValuePair<T, int>> __pad_UiZPCvswE9YOcgmqJPT811_0 = this.__slot_UiZPCvswE9YOcgmqJPT811;
            n6.IEnumerable<T> Input_1 = (n6.IEnumerable<T>)Input_In;
            n8._Operations_.Select<T, n6.KeyValuePair<T, int>>(Input_In: Input_1, Transformer_In: __pad_UiZPCvswE9YOcgmqJPT811_0, Output_Out: out n6.IEnumerable<n6.KeyValuePair<T, int>> Output_2);
            var __fallback___3 = n1.ServiceRegistry.Current;
            n8._Operations_.OrderBy<n6.KeyValuePair<T, int>, T2>(Input_In: Output_2, Key_Selector_In: (n6.KeyValuePair<T, int> Arg_In_5) =>
            {
                using var __current_4 = __fallback___3.MakeCurrentIfNone();
                var Key_6 = Arg_In_5.Key;
                n17._Operations_.Invoke<T, T2>(Input_In: Key_Selector_In, Arg_In: Key_6, Result_Out: out T2 Result_7);
                return Result_7;
            }

            , Result_Out: out n39.IOrderedEnumerable<n6.KeyValuePair<T, int>> Result_8);
            var builder_16 = n4.CollectionBuilders.GetBuilder(this.__cp_MQ0ZmrG8y3TOIFJ3KCySFH, 16);
            n5.Spread<T> output_17;
            var builder_18 = n4.CollectionBuilders.GetBuilder(this.__cp_IICPHALlv9EQWmetmlTvSz, 16);
            n5.Spread<int> output_19;
            try
            {
                var i_11 = 0;
                foreach (var item_9 in Result_8)
                {
                    var splicer_10 = item_9;
                    var i_local_12 = i_11;
                    n20._Operations_.Split<T, int>(Input_In: splicer_10, Key_Out: out T Key_14, Value_Out: out int Value_15);
                    builder_16.Add(Key_14);
                    builder_18.Add(Value_15);
                    i_11++;
                }
            }
            finally
            {
                output_17 = builder_16.Commit();
                output_19 = builder_18.Commit();
            }

            Output_Out = output_17;
            Indices_Out = output_19;
            n7.OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T> that_20 = this;
            if (this.__GetContext__().IsImmutable)
                that_20 = output_17 != this.__cp_MQ0ZmrG8y3TOIFJ3KCySFH || output_19 != this.__cp_IICPHALlv9EQWmetmlTvSz ? new OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T>(this)
                {__cp_MQ0ZmrG8y3TOIFJ3KCySFH = output_17, __cp_IICPHALlv9EQWmetmlTvSz = output_19} : that_20;
            else
            {
                this.__cp_MQ0ZmrG8y3TOIFJ3KCySFH = output_17;
                this.__cp_IICPHALlv9EQWmetmlTvSz = output_19;
            }

            return that_20;
        }

        public n7.OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T> Key_Selector()
        {
            return this;
        }

        public n7.OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            var __fallback___1 = n1.ServiceRegistry.Current;
            n2.Func<T, int, n6.KeyValuePair<T, int>> Functionality_6 = (T Arg_1_In_3, int Arg_2_In_4) =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                var Output_5 = new n6.KeyValuePair<T, int>(key: Arg_1_In_3, value: Arg_2_In_4);
                return Output_5;
            }

            ;
            n2.Func<T, int, n6.KeyValuePair<T, int>> __pad_UiZPCvswE9YOcgmqJPT811_7 = Functionality_6;
            n7.OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T> that_8 = this;
            this.__slot_UiZPCvswE9YOcgmqJPT811 = Functionality_6;
            this.__cp_MQ0ZmrG8y3TOIFJ3KCySFH = n7._Operations_.CreateDefault<T>();
            this.__cp_IICPHALlv9EQWmetmlTvSz = n7._Operations_.CreateDefault<int>();
            return that_8;
        }

        public n7.OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T> __CreateDefault__<AdM>()
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>
        {
            var w_0 = default(AdM);
            n7.OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T> that_1 = this;
            this.__slot_UiZPCvswE9YOcgmqJPT811 = n47._Operations_.CreateDefault<T, int, n6.KeyValuePair<T, int>, AdM>();
            this.__cp_MQ0ZmrG8y3TOIFJ3KCySFH = n7._Operations_.CreateDefault<T>();
            this.__cp_IICPHALlv9EQWmetmlTvSz = n7._Operations_.CreateDefault<int>();
            return that_1;
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

        [n1.ElementAttribute(TracingId = 271158U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "UiZPCvswE9YOcgmqJPT811", Name = "__slot_UiZPCvswE9YOcgmqJPT811")]
        public n2.Func<T, int, n6.KeyValuePair<T, int>> __slot_UiZPCvswE9YOcgmqJPT811;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<T> __cp_MQ0ZmrG8y3TOIFJ3KCySFH;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<int> __cp_IICPHALlv9EQWmetmlTvSz;
        public OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid(OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T> other): base(other)
        {
            this.__slot_UiZPCvswE9YOcgmqJPT811 = other.__slot_UiZPCvswE9YOcgmqJPT811;
            this.__cp_MQ0ZmrG8y3TOIFJ3KCySFH = other.__cp_MQ0ZmrG8y3TOIFJ3KCySFH;
            this.__cp_IICPHALlv9EQWmetmlTvSz = other.__cp_IICPHALlv9EQWmetmlTvSz;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_UiZPCvswE9YOcgmqJPT811", in __slot_UiZPCvswE9YOcgmqJPT811), n1.CompilationHelper.GetValueOrExisting(values, "__cp_MQ0ZmrG8y3TOIFJ3KCySFH", in __cp_MQ0ZmrG8y3TOIFJ3KCySFH), n1.CompilationHelper.GetValueOrExisting(values, "__cp_IICPHALlv9EQWmetmlTvSz", in __cp_IICPHALlv9EQWmetmlTvSz));
        }

        internal OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T> __WITH__(n2.Func<T, int, n6.KeyValuePair<T, int>> __slot_UiZPCvswE9YOcgmqJPT811, n5.Spread<T> __cp_MQ0ZmrG8y3TOIFJ3KCySFH, n5.Spread<int> __cp_IICPHALlv9EQWmetmlTvSz)
        {
            n7.OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_UiZPCvswE9YOcgmqJPT811 != this.__slot_UiZPCvswE9YOcgmqJPT811 || __cp_MQ0ZmrG8y3TOIFJ3KCySFH != this.__cp_MQ0ZmrG8y3TOIFJ3KCySFH || __cp_IICPHALlv9EQWmetmlTvSz != this.__cp_IICPHALlv9EQWmetmlTvSz ? new OrderBy_FormerIndex_SNAab9r0y7NPAcJeyZyvid<T>(this)
                {__slot_UiZPCvswE9YOcgmqJPT811 = __slot_UiZPCvswE9YOcgmqJPT811, __cp_MQ0ZmrG8y3TOIFJ3KCySFH = __cp_MQ0ZmrG8y3TOIFJ3KCySFH, __cp_IICPHALlv9EQWmetmlTvSz = __cp_IICPHALlv9EQWmetmlTvSz} : that_0;
            else
            {
                this.__slot_UiZPCvswE9YOcgmqJPT811 = __slot_UiZPCvswE9YOcgmqJPT811;
                this.__cp_MQ0ZmrG8y3TOIFJ3KCySFH = __cp_MQ0ZmrG8y3TOIFJ3KCySFH;
                this.__cp_IICPHALlv9EQWmetmlTvSz = __cp_IICPHALlv9EQWmetmlTvSz;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 271212U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "RU0h3y9oSF9Nmb7djv4eij", Name = "OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij")]
    [n2.SerializableAttribute]
    public class OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>
        {
            var instance = new OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T> CreateDefault<AdM>()
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>
        {
            var instance = new OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n7.OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T> Update<T2, T4>(n2.Func<T, T2> Key_Selector_In, T4 Input_In, out n5.Spread<T> Output_Out, out n5.Spread<int> Indices_Out)
            where T4 : n6.IEnumerable<T>
        {
            n2.Func<T, int, n6.KeyValuePair<T, int>> __pad_M2prkoJmOmCPLw8RacKhZu_0 = this.__slot_M2prkoJmOmCPLw8RacKhZu;
            n6.IEnumerable<T> Input_1 = (n6.IEnumerable<T>)Input_In;
            n8._Operations_.Select<T, n6.KeyValuePair<T, int>>(Input_In: Input_1, Transformer_In: __pad_M2prkoJmOmCPLw8RacKhZu_0, Output_Out: out n6.IEnumerable<n6.KeyValuePair<T, int>> Output_2);
            var __fallback___3 = n1.ServiceRegistry.Current;
            n8._Operations_.OrderByDescending<n6.KeyValuePair<T, int>, T2>(Input_In: Output_2, Key_Selector_In: (n6.KeyValuePair<T, int> Arg_In_5) =>
            {
                using var __current_4 = __fallback___3.MakeCurrentIfNone();
                var Key_6 = Arg_In_5.Key;
                n17._Operations_.Invoke<T, T2>(Input_In: Key_Selector_In, Arg_In: Key_6, Result_Out: out T2 Result_7);
                return Result_7;
            }

            , Result_Out: out n39.IOrderedEnumerable<n6.KeyValuePair<T, int>> Result_8);
            var builder_16 = n4.CollectionBuilders.GetBuilder(this.__cp_OyrnaRLxzB7NhsRvSWRr5b, 16);
            n5.Spread<T> output_17;
            var builder_18 = n4.CollectionBuilders.GetBuilder(this.__cp_PdeEqNStY7EQYP7vXbwXWI, 16);
            n5.Spread<int> output_19;
            try
            {
                var i_11 = 0;
                foreach (var item_9 in Result_8)
                {
                    var splicer_10 = item_9;
                    var i_local_12 = i_11;
                    n20._Operations_.Split<T, int>(Input_In: splicer_10, Key_Out: out T Key_14, Value_Out: out int Value_15);
                    builder_16.Add(Key_14);
                    builder_18.Add(Value_15);
                    i_11++;
                }
            }
            finally
            {
                output_17 = builder_16.Commit();
                output_19 = builder_18.Commit();
            }

            Output_Out = output_17;
            Indices_Out = output_19;
            n7.OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T> that_20 = this;
            if (this.__GetContext__().IsImmutable)
                that_20 = output_17 != this.__cp_OyrnaRLxzB7NhsRvSWRr5b || output_19 != this.__cp_PdeEqNStY7EQYP7vXbwXWI ? new OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T>(this)
                {__cp_OyrnaRLxzB7NhsRvSWRr5b = output_17, __cp_PdeEqNStY7EQYP7vXbwXWI = output_19} : that_20;
            else
            {
                this.__cp_OyrnaRLxzB7NhsRvSWRr5b = output_17;
                this.__cp_PdeEqNStY7EQYP7vXbwXWI = output_19;
            }

            return that_20;
        }

        public n7.OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T> Key_Selector()
        {
            return this;
        }

        public n7.OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            var __fallback___1 = n1.ServiceRegistry.Current;
            n2.Func<T, int, n6.KeyValuePair<T, int>> Functionality_6 = (T Arg_1_In_3, int Arg_2_In_4) =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                var Output_5 = new n6.KeyValuePair<T, int>(key: Arg_1_In_3, value: Arg_2_In_4);
                return Output_5;
            }

            ;
            n2.Func<T, int, n6.KeyValuePair<T, int>> __pad_M2prkoJmOmCPLw8RacKhZu_7 = Functionality_6;
            n7.OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T> that_8 = this;
            this.__slot_M2prkoJmOmCPLw8RacKhZu = Functionality_6;
            this.__cp_OyrnaRLxzB7NhsRvSWRr5b = n7._Operations_.CreateDefault<T>();
            this.__cp_PdeEqNStY7EQYP7vXbwXWI = n7._Operations_.CreateDefault<int>();
            return that_8;
        }

        public n7.OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T> __CreateDefault__<AdM>()
            where AdM : struct, n18.IAdaptiveCreateDefault<n6.KeyValuePair<T, int>>
        {
            var w_0 = default(AdM);
            n7.OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T> that_1 = this;
            this.__slot_M2prkoJmOmCPLw8RacKhZu = n47._Operations_.CreateDefault<T, int, n6.KeyValuePair<T, int>, AdM>();
            this.__cp_OyrnaRLxzB7NhsRvSWRr5b = n7._Operations_.CreateDefault<T>();
            this.__cp_PdeEqNStY7EQYP7vXbwXWI = n7._Operations_.CreateDefault<int>();
            return that_1;
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

        [n1.ElementAttribute(TracingId = 271249U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "M2prkoJmOmCPLw8RacKhZu", Name = "__slot_M2prkoJmOmCPLw8RacKhZu")]
        public n2.Func<T, int, n6.KeyValuePair<T, int>> __slot_M2prkoJmOmCPLw8RacKhZu;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<T> __cp_OyrnaRLxzB7NhsRvSWRr5b;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<int> __cp_PdeEqNStY7EQYP7vXbwXWI;
        public OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij(OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T> other): base(other)
        {
            this.__slot_M2prkoJmOmCPLw8RacKhZu = other.__slot_M2prkoJmOmCPLw8RacKhZu;
            this.__cp_OyrnaRLxzB7NhsRvSWRr5b = other.__cp_OyrnaRLxzB7NhsRvSWRr5b;
            this.__cp_PdeEqNStY7EQYP7vXbwXWI = other.__cp_PdeEqNStY7EQYP7vXbwXWI;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_M2prkoJmOmCPLw8RacKhZu", in __slot_M2prkoJmOmCPLw8RacKhZu), n1.CompilationHelper.GetValueOrExisting(values, "__cp_OyrnaRLxzB7NhsRvSWRr5b", in __cp_OyrnaRLxzB7NhsRvSWRr5b), n1.CompilationHelper.GetValueOrExisting(values, "__cp_PdeEqNStY7EQYP7vXbwXWI", in __cp_PdeEqNStY7EQYP7vXbwXWI));
        }

        internal OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T> __WITH__(n2.Func<T, int, n6.KeyValuePair<T, int>> __slot_M2prkoJmOmCPLw8RacKhZu, n5.Spread<T> __cp_OyrnaRLxzB7NhsRvSWRr5b, n5.Spread<int> __cp_PdeEqNStY7EQYP7vXbwXWI)
        {
            n7.OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_M2prkoJmOmCPLw8RacKhZu != this.__slot_M2prkoJmOmCPLw8RacKhZu || __cp_OyrnaRLxzB7NhsRvSWRr5b != this.__cp_OyrnaRLxzB7NhsRvSWRr5b || __cp_PdeEqNStY7EQYP7vXbwXWI != this.__cp_PdeEqNStY7EQYP7vXbwXWI ? new OrderByDescending_FormerIndex_RU0h3y9oSF9Nmb7djv4eij<T>(this)
                {__slot_M2prkoJmOmCPLw8RacKhZu = __slot_M2prkoJmOmCPLw8RacKhZu, __cp_OyrnaRLxzB7NhsRvSWRr5b = __cp_OyrnaRLxzB7NhsRvSWRr5b, __cp_PdeEqNStY7EQYP7vXbwXWI = __cp_PdeEqNStY7EQYP7vXbwXWI} : that_0;
            else
            {
                this.__slot_M2prkoJmOmCPLw8RacKhZu = __slot_M2prkoJmOmCPLw8RacKhZu;
                this.__cp_OyrnaRLxzB7NhsRvSWRr5b = __cp_OyrnaRLxzB7NhsRvSWRr5b;
                this.__cp_PdeEqNStY7EQYP7vXbwXWI = __cp_PdeEqNStY7EQYP7vXbwXWI;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 271303U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "O6Ex8Ha7b3gM1UF4tcByx6", Name = "ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6")]
    [n2.SerializableAttribute]
    public class ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T> : n1.VLObject, n2.IDisposable where T2 : n6.IReadOnlyList<T>
    {
        [n4.CreateNewAttribute]
        public static n7.ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T> Create(n1.NodeContext Node_Context)
        {
            var instance = new ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T> CreateDefault()
        {
            var instance = new ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T> Update<AdM>(T2 Input_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<T> Output_Out, out n5.Spread<float> Interval_Out)
            where AdM : struct, n18.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_GL92Pd5MuiLP4pZxYqrgNk;
            if (manager_3 is null)
            {
                manager_3 = new n42.Manager<n2.ValueTuple<T2, int>, n2.ValueTuple<n5.Spread<T>, n5.Spread<float>>>((n7._Operations_.CreateDefault<T>(), n7._Operations_.CreateDefault<float>()));
            }

            var inputs_4 = (Input_In, Count_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__TxQ97VChGvXNhI5ADsbLY9>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __TxQ97VChGvXNhI5ADsbLY9(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_AeTbyY7if2VLJBlBniDmRR = n7._Operations_.CreateDefault<T>(), __cp_Ckf6km3KR4RNEWhekH8wjp = n7._Operations_.CreateDefault<float>()};
                }

                n6.IReadOnlyList<T> Input_8 = (n6.IReadOnlyList<T>)Input_In;
                n16._Operations_.Count<T>(Input_In: Input_8, Output_Out: out n6.IReadOnlyList<T> Output_9, Count_Out: out int Count_10);
                n6.IReadOnlyList<T> Input_11 = (n6.IReadOnlyList<T>)Input_In;
                float Input_12 = (float)Count_10;
                float Input_2_13 = (float)Count_In;
                var Output_14 = (float)Input_12 / Input_2_13;
                var builder_24 = n4.CollectionBuilders.GetBuilder(state_7.__cp_AeTbyY7if2VLJBlBniDmRR, 16);
                n5.Spread<T> output_25;
                var builder_26 = n4.CollectionBuilders.GetBuilder(state_7.__cp_Ckf6km3KR4RNEWhekH8wjp, 16);
                n5.Spread<float> output_27;
                try
                {
                    for (var i_15 = 0; i_15 < Count_In; i_15++)
                    {
                        var i_local_16 = i_15;
                        float Input_18 = (float)i_local_16;
                        var Output_19 = Input_18 * Output_14;
                        n10.Float32Extensions.Frac(input: Output_19, wholePart: out int Whole_Part_20, fractionalPart: out float Fractional_Part_21);
                        w_0.CreateDefault(Output_Out: out T Output_22);
                        n16._Operations_.GetSlice<T>(Input_In: Input_11, Default_Value_In: Output_22, Index_In: Whole_Part_20, Result_Out: out T Result_23);
                        builder_24.Add(Result_23);
                        builder_26.Add(Output_19);
                    }
                }
                finally
                {
                    output_25 = builder_24.Commit();
                    output_27 = builder_26.Commit();
                }

                if (state_7.__GetContext__().IsImmutable)
                    state_7 = output_25 != state_7.__cp_AeTbyY7if2VLJBlBniDmRR || output_27 != state_7.__cp_Ckf6km3KR4RNEWhekH8wjp ? new __TxQ97VChGvXNhI5ADsbLY9(state_7)
                    {__cp_AeTbyY7if2VLJBlBniDmRR = output_25, __cp_Ckf6km3KR4RNEWhekH8wjp = output_27} : state_7;
                else
                {
                    state_7.__cp_AeTbyY7if2VLJBlBniDmRR = output_25;
                    state_7.__cp_Ckf6km3KR4RNEWhekH8wjp = output_27;
                }

                outputs_5 = (output_25, output_27);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var(__auto_28, __auto_29) = outputs_5;
            Output_Out = __auto_28;
            Interval_Out = __auto_29;
            n7.ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T> that_30 = this;
            if (this.__GetContext__().IsImmutable)
                that_30 = manager_3 != this.__cache_GL92Pd5MuiLP4pZxYqrgNk ? new ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T>(this)
                {__cache_GL92Pd5MuiLP4pZxYqrgNk = manager_3} : that_30;
            else
            {
                this.__cache_GL92Pd5MuiLP4pZxYqrgNk = manager_3;
            }

            return that_30;
        }

        public n7.ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T> that_0 = this;
            this.__cache_GL92Pd5MuiLP4pZxYqrgNk = null;
            return that_0;
        }

        public n7.ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T> __CreateDefault__()
        {
            n7.ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T> that_0 = this;
            this.__cache_GL92Pd5MuiLP4pZxYqrgNk = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_GL92Pd5MuiLP4pZxYqrgNk);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 271309U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "GL92Pd5MuiLP4pZxYqrgNk", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<T2, int>, n2.ValueTuple<n5.Spread<T>, n5.Spread<float>>> __cache_GL92Pd5MuiLP4pZxYqrgNk = null;
        public ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6(ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T> other): base(other)
        {
            this.__cache_GL92Pd5MuiLP4pZxYqrgNk = other.__cache_GL92Pd5MuiLP4pZxYqrgNk;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_GL92Pd5MuiLP4pZxYqrgNk", in __cache_GL92Pd5MuiLP4pZxYqrgNk));
        }

        internal ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T> __WITH__(n42.Manager<n2.ValueTuple<T2, int>, n2.ValueTuple<n5.Spread<T>, n5.Spread<float>>> __cache_GL92Pd5MuiLP4pZxYqrgNk)
        {
            n7.ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_GL92Pd5MuiLP4pZxYqrgNk != this.__cache_GL92Pd5MuiLP4pZxYqrgNk ? new ResamplePoint_O6Ex8Ha7b3gM1UF4tcByx6<T2, T>(this)
                {__cache_GL92Pd5MuiLP4pZxYqrgNk = __cache_GL92Pd5MuiLP4pZxYqrgNk} : that_0;
            else
            {
                this.__cache_GL92Pd5MuiLP4pZxYqrgNk = __cache_GL92Pd5MuiLP4pZxYqrgNk;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "TxQ97VChGvXNhI5ADsbLY9", Name = "__TxQ97VChGvXNhI5ADsbLY9")]
        [n2.SerializableAttribute]
        public class __TxQ97VChGvXNhI5ADsbLY9 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<T> __cp_AeTbyY7if2VLJBlBniDmRR;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<float> __cp_Ckf6km3KR4RNEWhekH8wjp;
            public __TxQ97VChGvXNhI5ADsbLY9(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __TxQ97VChGvXNhI5ADsbLY9(__TxQ97VChGvXNhI5ADsbLY9 other): base(other)
            {
                this.__cp_AeTbyY7if2VLJBlBniDmRR = other.__cp_AeTbyY7if2VLJBlBniDmRR;
                this.__cp_Ckf6km3KR4RNEWhekH8wjp = other.__cp_Ckf6km3KR4RNEWhekH8wjp;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_AeTbyY7if2VLJBlBniDmRR", in __cp_AeTbyY7if2VLJBlBniDmRR), n1.CompilationHelper.GetValueOrExisting(values, "__cp_Ckf6km3KR4RNEWhekH8wjp", in __cp_Ckf6km3KR4RNEWhekH8wjp));
            }

            internal __TxQ97VChGvXNhI5ADsbLY9 __WITH__(n5.Spread<T> __cp_AeTbyY7if2VLJBlBniDmRR, n5.Spread<float> __cp_Ckf6km3KR4RNEWhekH8wjp)
            {
                __TxQ97VChGvXNhI5ADsbLY9 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_AeTbyY7if2VLJBlBniDmRR != this.__cp_AeTbyY7if2VLJBlBniDmRR || __cp_Ckf6km3KR4RNEWhekH8wjp != this.__cp_Ckf6km3KR4RNEWhekH8wjp ? new __TxQ97VChGvXNhI5ADsbLY9(this)
                    {__cp_AeTbyY7if2VLJBlBniDmRR = __cp_AeTbyY7if2VLJBlBniDmRR, __cp_Ckf6km3KR4RNEWhekH8wjp = __cp_Ckf6km3KR4RNEWhekH8wjp} : that_0;
                else
                {
                    this.__cp_AeTbyY7if2VLJBlBniDmRR = __cp_AeTbyY7if2VLJBlBniDmRR;
                    this.__cp_Ckf6km3KR4RNEWhekH8wjp = __cp_Ckf6km3KR4RNEWhekH8wjp;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 271384U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "T6XZTYHFIwEPcS5iC1aCi4", Name = "ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4")]
    [n2.SerializableAttribute]
    public class ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T> : n1.VLObject, n2.IDisposable where T2 : n6.IReadOnlyList<T>
    {
        [n4.CreateNewAttribute]
        public static n7.ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T> Create(n1.NodeContext Node_Context)
        {
            var instance = new ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T> CreateDefault()
        {
            var instance = new ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T> Update<AdM>(T2 Input_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<T> Output_Out, out n5.Spread<float> Interval_Out)
            where AdM : struct, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveLerp<T>
        {
            var w_0 = default(AdM);
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_QXdoT3E2BodLrMIPgXo1Yf;
            if (manager_3 is null)
            {
                manager_3 = new n42.Manager<n2.ValueTuple<T2, int>, n2.ValueTuple<n5.Spread<T>, n5.Spread<float>>>((n7._Operations_.CreateDefault<T>(), n7._Operations_.CreateDefault<float>()));
            }

            var inputs_4 = (Input_In, Count_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__UhwhAOcAC4oM0pfYHW9QSc>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __UhwhAOcAC4oM0pfYHW9QSc(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_BFABj3Y2E53PJZICa9dOtz = n7._Operations_.CreateDefault<T>(), __cp_ER0DERr5KcVQBBaFV15ZE5 = n7._Operations_.CreateDefault<float>()};
                }

                n6.IReadOnlyList<T> Input_8 = (n6.IReadOnlyList<T>)Input_In;
                n16._Operations_.Count<T>(Input_In: Input_8, Output_Out: out n6.IReadOnlyList<T> Output_9, Count_Out: out int Count_10);
                bool Apply_11 = true;
                var Output_12 = Count_10;
                if (Apply_11)
                {
                    var Output_13 = n10.Integer32Extensions.Dec(input: Count_10);
                    Output_12 = Output_13;
                }

                float Input_14 = (float)Output_12;
                bool Apply_15 = true;
                var Output_16 = Count_In;
                if (Apply_15)
                {
                    var Output_17 = n10.Integer32Extensions.Dec(input: Count_In);
                    Output_16 = Output_17;
                }

                float Input_2_18 = (float)Output_16;
                var Output_19 = (float)Input_14 / Input_2_18;
                n6.IReadOnlyList<T> Input_20 = (n6.IReadOnlyList<T>)Input_In;
                n6.IReadOnlyList<T> Input_21 = (n6.IReadOnlyList<T>)Input_In;
                var builder_37 = n4.CollectionBuilders.GetBuilder(state_7.__cp_BFABj3Y2E53PJZICa9dOtz, 16);
                n5.Spread<T> output_38;
                var builder_39 = n4.CollectionBuilders.GetBuilder(state_7.__cp_ER0DERr5KcVQBBaFV15ZE5, 16);
                n5.Spread<float> output_40;
                try
                {
                    for (var i_22 = 0; i_22 < Count_In; i_22++)
                    {
                        var i_local_23 = i_22;
                        float Input_25 = (float)i_local_23;
                        var Output_26 = Input_25 * Output_19;
                        n10.Float32Extensions.Frac(input: Output_26, wholePart: out int Whole_Part_27, fractionalPart: out float Fractional_Part_28);
                        w_0.CreateDefault(Output_Out: out T Output_29);
                        n16._Operations_.GetSlice<T>(Input_In: Input_21, Default_Value_In: Output_29, Index_In: Whole_Part_27, Result_Out: out T Result_30);
                        w_0.CreateDefault(Output_Out: out T Output_31);
                        bool Apply_32 = true;
                        var Output_33 = Whole_Part_27;
                        if (Apply_32)
                        {
                            var Output_34 = n10.Integer32Extensions.Inc(input: Whole_Part_27);
                            Output_33 = Output_34;
                        }

                        n16._Operations_.GetSlice<T>(Input_In: Input_20, Default_Value_In: Output_31, Index_In: Output_33, Result_Out: out T Result_35);
                        w_0.Lerp(Input_In: Result_30, Input_2_In: Result_35, Scalar_In: Fractional_Part_28, Output_Out: out T Output_36);
                        builder_37.Add(Output_36);
                        builder_39.Add(Output_26);
                    }
                }
                finally
                {
                    output_38 = builder_37.Commit();
                    output_40 = builder_39.Commit();
                }

                if (state_7.__GetContext__().IsImmutable)
                    state_7 = output_38 != state_7.__cp_BFABj3Y2E53PJZICa9dOtz || output_40 != state_7.__cp_ER0DERr5KcVQBBaFV15ZE5 ? new __UhwhAOcAC4oM0pfYHW9QSc(state_7)
                    {__cp_BFABj3Y2E53PJZICa9dOtz = output_38, __cp_ER0DERr5KcVQBBaFV15ZE5 = output_40} : state_7;
                else
                {
                    state_7.__cp_BFABj3Y2E53PJZICa9dOtz = output_38;
                    state_7.__cp_ER0DERr5KcVQBBaFV15ZE5 = output_40;
                }

                outputs_5 = (output_38, output_40);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var(__auto_41, __auto_42) = outputs_5;
            Output_Out = __auto_41;
            Interval_Out = __auto_42;
            n7.ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T> that_43 = this;
            if (this.__GetContext__().IsImmutable)
                that_43 = manager_3 != this.__cache_QXdoT3E2BodLrMIPgXo1Yf ? new ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T>(this)
                {__cache_QXdoT3E2BodLrMIPgXo1Yf = manager_3} : that_43;
            else
            {
                this.__cache_QXdoT3E2BodLrMIPgXo1Yf = manager_3;
            }

            return that_43;
        }

        public n7.ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T> that_0 = this;
            this.__cache_QXdoT3E2BodLrMIPgXo1Yf = null;
            return that_0;
        }

        public n7.ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T> __CreateDefault__()
        {
            n7.ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T> that_0 = this;
            this.__cache_QXdoT3E2BodLrMIPgXo1Yf = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_QXdoT3E2BodLrMIPgXo1Yf);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 271391U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "QXdoT3E2BodLrMIPgXo1Yf", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<T2, int>, n2.ValueTuple<n5.Spread<T>, n5.Spread<float>>> __cache_QXdoT3E2BodLrMIPgXo1Yf = null;
        public ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4(ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T> other): base(other)
        {
            this.__cache_QXdoT3E2BodLrMIPgXo1Yf = other.__cache_QXdoT3E2BodLrMIPgXo1Yf;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_QXdoT3E2BodLrMIPgXo1Yf", in __cache_QXdoT3E2BodLrMIPgXo1Yf));
        }

        internal ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T> __WITH__(n42.Manager<n2.ValueTuple<T2, int>, n2.ValueTuple<n5.Spread<T>, n5.Spread<float>>> __cache_QXdoT3E2BodLrMIPgXo1Yf)
        {
            n7.ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_QXdoT3E2BodLrMIPgXo1Yf != this.__cache_QXdoT3E2BodLrMIPgXo1Yf ? new ResampleLinear_T6XZTYHFIwEPcS5iC1aCi4<T2, T>(this)
                {__cache_QXdoT3E2BodLrMIPgXo1Yf = __cache_QXdoT3E2BodLrMIPgXo1Yf} : that_0;
            else
            {
                this.__cache_QXdoT3E2BodLrMIPgXo1Yf = __cache_QXdoT3E2BodLrMIPgXo1Yf;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "UhwhAOcAC4oM0pfYHW9QSc", Name = "__UhwhAOcAC4oM0pfYHW9QSc")]
        [n2.SerializableAttribute]
        public class __UhwhAOcAC4oM0pfYHW9QSc : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<T> __cp_BFABj3Y2E53PJZICa9dOtz;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<float> __cp_ER0DERr5KcVQBBaFV15ZE5;
            public __UhwhAOcAC4oM0pfYHW9QSc(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __UhwhAOcAC4oM0pfYHW9QSc(__UhwhAOcAC4oM0pfYHW9QSc other): base(other)
            {
                this.__cp_BFABj3Y2E53PJZICa9dOtz = other.__cp_BFABj3Y2E53PJZICa9dOtz;
                this.__cp_ER0DERr5KcVQBBaFV15ZE5 = other.__cp_ER0DERr5KcVQBBaFV15ZE5;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_BFABj3Y2E53PJZICa9dOtz", in __cp_BFABj3Y2E53PJZICa9dOtz), n1.CompilationHelper.GetValueOrExisting(values, "__cp_ER0DERr5KcVQBBaFV15ZE5", in __cp_ER0DERr5KcVQBBaFV15ZE5));
            }

            internal __UhwhAOcAC4oM0pfYHW9QSc __WITH__(n5.Spread<T> __cp_BFABj3Y2E53PJZICa9dOtz, n5.Spread<float> __cp_ER0DERr5KcVQBBaFV15ZE5)
            {
                __UhwhAOcAC4oM0pfYHW9QSc that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_BFABj3Y2E53PJZICa9dOtz != this.__cp_BFABj3Y2E53PJZICa9dOtz || __cp_ER0DERr5KcVQBBaFV15ZE5 != this.__cp_ER0DERr5KcVQBBaFV15ZE5 ? new __UhwhAOcAC4oM0pfYHW9QSc(this)
                    {__cp_BFABj3Y2E53PJZICa9dOtz = __cp_BFABj3Y2E53PJZICa9dOtz, __cp_ER0DERr5KcVQBBaFV15ZE5 = __cp_ER0DERr5KcVQBBaFV15ZE5} : that_0;
                else
                {
                    this.__cp_BFABj3Y2E53PJZICa9dOtz = __cp_BFABj3Y2E53PJZICa9dOtz;
                    this.__cp_ER0DERr5KcVQBBaFV15ZE5 = __cp_ER0DERr5KcVQBBaFV15ZE5;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 271495U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "HcOO13xjH07QObifcX5etq", Name = "ResampleRepeat_HcOO13xjH07QObifcX5etq")]
    [n2.SerializableAttribute]
    public class ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T> : n1.VLObject, n2.IDisposable where T2 : n6.IReadOnlyList<T>
    {
        [n4.CreateNewAttribute]
        public static n7.ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T> Create(n1.NodeContext Node_Context)
        {
            var instance = new ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T> CreateDefault()
        {
            var instance = new ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T> Update<AdM>(T2 Input_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<T> Output_Out, out n5.Spread<float> Interval_Out)
            where AdM : struct, n18.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_BW6WMMU5g9RMTy9N3DzNRc;
            if (manager_3 is null)
            {
                manager_3 = new n42.Manager<n2.ValueTuple<int, T2>, n2.ValueTuple<n5.Spread<T>, n5.Spread<float>>>((n7._Operations_.CreateDefault<T>(), n7._Operations_.CreateDefault<float>()));
            }

            var inputs_4 = (Count_In, Input_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__BCQENJh7Mb4LqdULAF1jlm>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __BCQENJh7Mb4LqdULAF1jlm(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_IUfP4UqP7NGLg3c9jZ8MTR = n7._Operations_.CreateDefault<T>(), __cp_BnzpyNjXZc9N26YhK588xc = n7._Operations_.CreateDefault<float>()};
                }

                n6.IReadOnlyList<T> Input_8 = (n6.IReadOnlyList<T>)Input_In;
                n16._Operations_.Count<T>(Input_In: Input_8, Output_Out: out n6.IReadOnlyList<T> Output_9, Count_Out: out int Count_10);
                n6.IReadOnlyList<T> Input_11 = (n6.IReadOnlyList<T>)Input_In;
                int Input_2_12 = 1;
                n13._Operations_.Max<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Count_10, Input_2_In: Input_2_12, Output_Out: out int Output_13);
                var builder_21 = n4.CollectionBuilders.GetBuilder(state_7.__cp_IUfP4UqP7NGLg3c9jZ8MTR, 16);
                n5.Spread<T> output_22;
                var builder_23 = n4.CollectionBuilders.GetBuilder(state_7.__cp_BnzpyNjXZc9N26YhK588xc, 16);
                n5.Spread<float> output_24;
                try
                {
                    for (var i_14 = 0; i_14 < Count_In; i_14++)
                    {
                        var i_local_15 = i_14;
                        var Output_17 = i_local_15 % Output_13;
                        var Result_18 = n10.IntegerConversions.ToFloat32(input: Output_17);
                        w_0.CreateDefault(Output_Out: out T Output_19);
                        n16._Operations_.GetSlice<T>(Input_In: Input_11, Default_Value_In: Output_19, Index_In: Output_17, Result_Out: out T Result_20);
                        builder_21.Add(Result_20);
                        builder_23.Add(Result_18);
                    }
                }
                finally
                {
                    output_22 = builder_21.Commit();
                    output_24 = builder_23.Commit();
                }

                if (state_7.__GetContext__().IsImmutable)
                    state_7 = output_22 != state_7.__cp_IUfP4UqP7NGLg3c9jZ8MTR || output_24 != state_7.__cp_BnzpyNjXZc9N26YhK588xc ? new __BCQENJh7Mb4LqdULAF1jlm(state_7)
                    {__cp_IUfP4UqP7NGLg3c9jZ8MTR = output_22, __cp_BnzpyNjXZc9N26YhK588xc = output_24} : state_7;
                else
                {
                    state_7.__cp_IUfP4UqP7NGLg3c9jZ8MTR = output_22;
                    state_7.__cp_BnzpyNjXZc9N26YhK588xc = output_24;
                }

                outputs_5 = (output_22, output_24);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var(__auto_25, __auto_26) = outputs_5;
            Output_Out = __auto_25;
            Interval_Out = __auto_26;
            n7.ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T> that_27 = this;
            if (this.__GetContext__().IsImmutable)
                that_27 = manager_3 != this.__cache_BW6WMMU5g9RMTy9N3DzNRc ? new ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T>(this)
                {__cache_BW6WMMU5g9RMTy9N3DzNRc = manager_3} : that_27;
            else
            {
                this.__cache_BW6WMMU5g9RMTy9N3DzNRc = manager_3;
            }

            return that_27;
        }

        public n7.ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T> that_0 = this;
            this.__cache_BW6WMMU5g9RMTy9N3DzNRc = null;
            return that_0;
        }

        public n7.ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T> __CreateDefault__()
        {
            n7.ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T> that_0 = this;
            this.__cache_BW6WMMU5g9RMTy9N3DzNRc = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_BW6WMMU5g9RMTy9N3DzNRc);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 271502U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "BW6WMMU5g9RMTy9N3DzNRc", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<int, T2>, n2.ValueTuple<n5.Spread<T>, n5.Spread<float>>> __cache_BW6WMMU5g9RMTy9N3DzNRc = null;
        public ResampleRepeat_HcOO13xjH07QObifcX5etq(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ResampleRepeat_HcOO13xjH07QObifcX5etq(ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T> other): base(other)
        {
            this.__cache_BW6WMMU5g9RMTy9N3DzNRc = other.__cache_BW6WMMU5g9RMTy9N3DzNRc;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_BW6WMMU5g9RMTy9N3DzNRc", in __cache_BW6WMMU5g9RMTy9N3DzNRc));
        }

        internal ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T> __WITH__(n42.Manager<n2.ValueTuple<int, T2>, n2.ValueTuple<n5.Spread<T>, n5.Spread<float>>> __cache_BW6WMMU5g9RMTy9N3DzNRc)
        {
            n7.ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_BW6WMMU5g9RMTy9N3DzNRc != this.__cache_BW6WMMU5g9RMTy9N3DzNRc ? new ResampleRepeat_HcOO13xjH07QObifcX5etq<T2, T>(this)
                {__cache_BW6WMMU5g9RMTy9N3DzNRc = __cache_BW6WMMU5g9RMTy9N3DzNRc} : that_0;
            else
            {
                this.__cache_BW6WMMU5g9RMTy9N3DzNRc = __cache_BW6WMMU5g9RMTy9N3DzNRc;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "BCQENJh7Mb4LqdULAF1jlm", Name = "__BCQENJh7Mb4LqdULAF1jlm")]
        [n2.SerializableAttribute]
        public class __BCQENJh7Mb4LqdULAF1jlm : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<T> __cp_IUfP4UqP7NGLg3c9jZ8MTR;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<float> __cp_BnzpyNjXZc9N26YhK588xc;
            public __BCQENJh7Mb4LqdULAF1jlm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BCQENJh7Mb4LqdULAF1jlm(__BCQENJh7Mb4LqdULAF1jlm other): base(other)
            {
                this.__cp_IUfP4UqP7NGLg3c9jZ8MTR = other.__cp_IUfP4UqP7NGLg3c9jZ8MTR;
                this.__cp_BnzpyNjXZc9N26YhK588xc = other.__cp_BnzpyNjXZc9N26YhK588xc;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_IUfP4UqP7NGLg3c9jZ8MTR", in __cp_IUfP4UqP7NGLg3c9jZ8MTR), n1.CompilationHelper.GetValueOrExisting(values, "__cp_BnzpyNjXZc9N26YhK588xc", in __cp_BnzpyNjXZc9N26YhK588xc));
            }

            internal __BCQENJh7Mb4LqdULAF1jlm __WITH__(n5.Spread<T> __cp_IUfP4UqP7NGLg3c9jZ8MTR, n5.Spread<float> __cp_BnzpyNjXZc9N26YhK588xc)
            {
                __BCQENJh7Mb4LqdULAF1jlm that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_IUfP4UqP7NGLg3c9jZ8MTR != this.__cp_IUfP4UqP7NGLg3c9jZ8MTR || __cp_BnzpyNjXZc9N26YhK588xc != this.__cp_BnzpyNjXZc9N26YhK588xc ? new __BCQENJh7Mb4LqdULAF1jlm(this)
                    {__cp_IUfP4UqP7NGLg3c9jZ8MTR = __cp_IUfP4UqP7NGLg3c9jZ8MTR, __cp_BnzpyNjXZc9N26YhK588xc = __cp_BnzpyNjXZc9N26YhK588xc} : that_0;
                else
                {
                    this.__cp_IUfP4UqP7NGLg3c9jZ8MTR = __cp_IUfP4UqP7NGLg3c9jZ8MTR;
                    this.__cp_BnzpyNjXZc9N26YhK588xc = __cp_BnzpyNjXZc9N26YhK588xc;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 272196U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Oyxv30P5EeJOlRy2CvOyJW", Name = "ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW")]
    [n2.SerializableAttribute]
    public class ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T> : n1.VLObject, n2.IDisposable where T6 : n6.IReadOnlyList<T>
    {
        [n4.CreateNewAttribute]
        public static n7.ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T> Create(n1.NodeContext Node_Context)
        {
            var instance = new ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T> CreateDefault()
        {
            var instance = new ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T> Update<AdM>(T6 Input_In, bool Close_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<T> Output_Out, out n5.Spread<float> Interval_Out)
            where AdM : struct, n19.IAdaptiveOperatorMinus<T>, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorMulitply_Scale<T>, n19.IAdaptiveOperatorPlus<T>, n19.IAdaptiveOperatorDivide_Scale<T>
        {
            var w_0 = default(AdM);
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_OQs6pID1l5bQdHz7VVFLMy;
            if (manager_3 is null)
            {
                manager_3 = new n42.Manager<n2.ValueTuple<T6, int, bool>, n2.ValueTuple<n5.Spread<float>, n5.Spread<T>>>((n7._Operations_.CreateDefault<float>(), n7._Operations_.CreateDefault<T>()));
            }

            var inputs_4 = (Input_In, Count_In, Close_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__UlBozKIls0lL3ItTmIGvst>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __UlBozKIls0lL3ItTmIGvst(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_OY16KNWq1WzPt5atdMgC9n = n7._Operations_.CreateDefault<float>(), __cp_SmvRluIHYwBOJInwXAgnaK = n7._Operations_.CreateDefault<T>()};
                }

                n6.IReadOnlyList<T> Input_8 = (n6.IReadOnlyList<T>)Input_In;
                n16._Operations_.Count<T>(Input_In: Input_8, Output_Out: out n6.IReadOnlyList<T> Output_9, Count_Out: out int Count_10);
                n6.IReadOnlyList<T> Input_11 = (n6.IReadOnlyList<T>)Input_In;
                bool Apply_12 = true;
                var Output_13 = Count_10;
                if (Apply_12)
                {
                    var Output_14 = n10.Integer32Extensions.Dec(input: Count_10);
                    Output_13 = Output_14;
                }

                float Input_15 = (float)Output_13;
                bool Apply_16 = true;
                var Output_17 = Count_In;
                if (Apply_16)
                {
                    var Output_18 = n10.Integer32Extensions.Dec(input: Count_In);
                    Output_17 = Output_18;
                }

                float Input_2_19 = (float)Output_17;
                var Output_20 = (float)Input_15 / Input_2_19;
                var Output_21 = !Close_In;
                n6.IReadOnlyList<T> Input_22 = (n6.IReadOnlyList<T>)Input_In;
                n6.IReadOnlyList<T> Input_23 = (n6.IReadOnlyList<T>)Input_In;
                n6.IReadOnlyList<T> Input_24 = (n6.IReadOnlyList<T>)Input_In;
                var builder_48 = n4.CollectionBuilders.GetBuilder(state_7.__cp_OY16KNWq1WzPt5atdMgC9n, 16);
                n5.Spread<float> output_49;
                var builder_50 = n4.CollectionBuilders.GetBuilder(state_7.__cp_SmvRluIHYwBOJInwXAgnaK, 16);
                n5.Spread<T> output_51;
                try
                {
                    for (var i_25 = 0; i_25 < Count_In; i_25++)
                    {
                        var i_local_26 = i_25;
                        float Input_28 = (float)i_local_26;
                        var Output_29 = Input_28 * Output_20;
                        n10.Float32Extensions.Frac(input: Output_29, wholePart: out int Whole_Part_30, fractionalPart: out float Fractional_Part_31);
                        var Output_32 = n10.Integer32Extensions.Dec(input: Whole_Part_30);
                        int Input_2_33 = 0;
                        var Output_34 = Output_32;
                        if (Output_21)
                        {
                            n13._Operations_.Max<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_32, Input_2_In: Input_2_33, Output_Out: out Output_34);
                        }

                        w_0.CreateDefault(Output_Out: out T Output_35);
                        n16._Operations_.GetSlice<T>(Input_In: Input_11, Default_Value_In: Output_35, Index_In: Output_34, Result_Out: out T Result_36);
                        w_0.CreateDefault(Output_Out: out T Output_37);
                        n16._Operations_.GetSlice<T>(Input_In: Input_22, Default_Value_In: Output_37, Index_In: Whole_Part_30, Result_Out: out T Result_38);
                        w_0.CreateDefault(Output_Out: out T Output_39);
                        var Output_40 = n10.Integer32Extensions.Inc(input: Whole_Part_30);
                        var Output_41 = Output_40;
                        if (Output_21)
                        {
                            n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_40, Input_2_In: Output_13, Output_Out: out Output_41);
                        }

                        n16._Operations_.GetSlice<T>(Input_In: Input_23, Default_Value_In: Output_39, Index_In: Output_41, Result_Out: out T Result_42);
                        w_0.CreateDefault(Output_Out: out T Output_43);
                        var Output_44 = n10.Integer32Extensions.Inc(input: Output_40);
                        var Output_45 = Output_44;
                        if (Output_21)
                        {
                            n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_44, Input_2_In: Output_13, Output_Out: out Output_45);
                        }

                        n16._Operations_.GetSlice<T>(Input_In: Input_24, Default_Value_In: Output_43, Index_In: Output_45, Result_Out: out T Result_46);
                        n48._Operations_.BSplineCubic<T, AdM>(Control_1_In: Result_36, Control_2_In: Result_38, Control_3_In: Result_42, Control_4_In: Result_46, Range_In: Fractional_Part_31, Position_Out: out T Position_47);
                        builder_48.Add(Output_29);
                        builder_50.Add(Position_47);
                    }
                }
                finally
                {
                    output_49 = builder_48.Commit();
                    output_51 = builder_50.Commit();
                }

                if (state_7.__GetContext__().IsImmutable)
                    state_7 = output_49 != state_7.__cp_OY16KNWq1WzPt5atdMgC9n || output_51 != state_7.__cp_SmvRluIHYwBOJInwXAgnaK ? new __UlBozKIls0lL3ItTmIGvst(state_7)
                    {__cp_OY16KNWq1WzPt5atdMgC9n = output_49, __cp_SmvRluIHYwBOJInwXAgnaK = output_51} : state_7;
                else
                {
                    state_7.__cp_OY16KNWq1WzPt5atdMgC9n = output_49;
                    state_7.__cp_SmvRluIHYwBOJInwXAgnaK = output_51;
                }

                outputs_5 = (output_49, output_51);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var(__auto_52, __auto_53) = outputs_5;
            Output_Out = __auto_53;
            Interval_Out = __auto_52;
            n7.ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T> that_54 = this;
            if (this.__GetContext__().IsImmutable)
                that_54 = manager_3 != this.__cache_OQs6pID1l5bQdHz7VVFLMy ? new ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T>(this)
                {__cache_OQs6pID1l5bQdHz7VVFLMy = manager_3} : that_54;
            else
            {
                this.__cache_OQs6pID1l5bQdHz7VVFLMy = manager_3;
            }

            return that_54;
        }

        public n7.ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T> that_0 = this;
            this.__cache_OQs6pID1l5bQdHz7VVFLMy = null;
            return that_0;
        }

        public n7.ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T> __CreateDefault__()
        {
            n7.ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T> that_0 = this;
            this.__cache_OQs6pID1l5bQdHz7VVFLMy = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_OQs6pID1l5bQdHz7VVFLMy);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 272204U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "OQs6pID1l5bQdHz7VVFLMy", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<T6, int, bool>, n2.ValueTuple<n5.Spread<float>, n5.Spread<T>>> __cache_OQs6pID1l5bQdHz7VVFLMy = null;
        public ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW(ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T> other): base(other)
        {
            this.__cache_OQs6pID1l5bQdHz7VVFLMy = other.__cache_OQs6pID1l5bQdHz7VVFLMy;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_OQs6pID1l5bQdHz7VVFLMy", in __cache_OQs6pID1l5bQdHz7VVFLMy));
        }

        internal ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T> __WITH__(n42.Manager<n2.ValueTuple<T6, int, bool>, n2.ValueTuple<n5.Spread<float>, n5.Spread<T>>> __cache_OQs6pID1l5bQdHz7VVFLMy)
        {
            n7.ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_OQs6pID1l5bQdHz7VVFLMy != this.__cache_OQs6pID1l5bQdHz7VVFLMy ? new ResampleBSpline_Oyxv30P5EeJOlRy2CvOyJW<T6, T>(this)
                {__cache_OQs6pID1l5bQdHz7VVFLMy = __cache_OQs6pID1l5bQdHz7VVFLMy} : that_0;
            else
            {
                this.__cache_OQs6pID1l5bQdHz7VVFLMy = __cache_OQs6pID1l5bQdHz7VVFLMy;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "UlBozKIls0lL3ItTmIGvst", Name = "__UlBozKIls0lL3ItTmIGvst")]
        [n2.SerializableAttribute]
        public class __UlBozKIls0lL3ItTmIGvst : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<float> __cp_OY16KNWq1WzPt5atdMgC9n;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<T> __cp_SmvRluIHYwBOJInwXAgnaK;
            public __UlBozKIls0lL3ItTmIGvst(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __UlBozKIls0lL3ItTmIGvst(__UlBozKIls0lL3ItTmIGvst other): base(other)
            {
                this.__cp_OY16KNWq1WzPt5atdMgC9n = other.__cp_OY16KNWq1WzPt5atdMgC9n;
                this.__cp_SmvRluIHYwBOJInwXAgnaK = other.__cp_SmvRluIHYwBOJInwXAgnaK;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_OY16KNWq1WzPt5atdMgC9n", in __cp_OY16KNWq1WzPt5atdMgC9n), n1.CompilationHelper.GetValueOrExisting(values, "__cp_SmvRluIHYwBOJInwXAgnaK", in __cp_SmvRluIHYwBOJInwXAgnaK));
            }

            internal __UlBozKIls0lL3ItTmIGvst __WITH__(n5.Spread<float> __cp_OY16KNWq1WzPt5atdMgC9n, n5.Spread<T> __cp_SmvRluIHYwBOJInwXAgnaK)
            {
                __UlBozKIls0lL3ItTmIGvst that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_OY16KNWq1WzPt5atdMgC9n != this.__cp_OY16KNWq1WzPt5atdMgC9n || __cp_SmvRluIHYwBOJInwXAgnaK != this.__cp_SmvRluIHYwBOJInwXAgnaK ? new __UlBozKIls0lL3ItTmIGvst(this)
                    {__cp_OY16KNWq1WzPt5atdMgC9n = __cp_OY16KNWq1WzPt5atdMgC9n, __cp_SmvRluIHYwBOJInwXAgnaK = __cp_SmvRluIHYwBOJInwXAgnaK} : that_0;
                else
                {
                    this.__cp_OY16KNWq1WzPt5atdMgC9n = __cp_OY16KNWq1WzPt5atdMgC9n;
                    this.__cp_SmvRluIHYwBOJInwXAgnaK = __cp_SmvRluIHYwBOJInwXAgnaK;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 272368U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "FoeSgW0bZ2tMOSGpSQqnoF", Name = "ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF")]
    [n2.SerializableAttribute]
    public class ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T> : n1.VLObject, n2.IDisposable where T2 : n6.IReadOnlyList<T>
    {
        [n4.CreateNewAttribute]
        public static n7.ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T> Create(n1.NodeContext Node_Context)
        {
            var instance = new ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T> CreateDefault()
        {
            var instance = new ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T> Update<AdM>(T2 Input_In, bool Close_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<T> Output_Out, out n5.Spread<T> Tangent_Out, out n5.Spread<float> Interval_Out)
            where AdM : struct, n19.IAdaptiveOperatorMinus<T>, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorMulitply_Scale<T>, n19.IAdaptiveOperatorPlus<T>, n19.IAdaptiveOperatorDivide_Scale<T>
        {
            var w_0 = default(AdM);
            n6.IReadOnlyList<T> Input_1 = (n6.IReadOnlyList<T>)Input_In;
            n6.IReadOnlyList<T> Input_2 = (n6.IReadOnlyList<T>)Input_In;
            n6.IReadOnlyList<T> Input_3 = (n6.IReadOnlyList<T>)Input_In;
            n6.IReadOnlyList<T> Input_4 = (n6.IReadOnlyList<T>)Input_In;
            bool Force_5 = false;
            bool Dispose_Cached_Outputs_6 = false;
            var manager_7 = this.__cache_FxdQDv3AkFrOu4oqr2Au3g;
            if (manager_7 is null)
            {
                manager_7 = new n42.Manager<n2.ValueTuple<T2, int, bool>, n2.ValueTuple<n5.Spread<float>, n5.Spread<T>, n5.Spread<T>>>((n7._Operations_.CreateDefault<float>(), n7._Operations_.CreateDefault<T>(), n7._Operations_.CreateDefault<T>()));
            }

            var inputs_8 = (Input_In, Count_In, Close_In);
            var outputs_9 = manager_7.Outputs;
            var Has_Changed_10 = Force_5 || manager_7.InputsChanged(inputs_8);
            if (Has_Changed_10)
            {
                if (Dispose_Cached_Outputs_6)
                    manager_7.DisposeOutputs();
                var state_11 = n1.CompilationHelper.Restore<__U3HCBkwAG7fNhgmUax5ml3>(manager_7.State, __GetContext__());
                if (state_11 == null)
                {
                    state_11 = new __U3HCBkwAG7fNhgmUax5ml3(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_RFIqlyPUN87PvzCaR4PyQz = n7._Operations_.CreateDefault<float>(), __cp_KJcmMhYG2d2Od2e792NpRO = n7._Operations_.CreateDefault<T>(), __cp_QTUFCdsGWEPO6bCak0OVGd = n7._Operations_.CreateDefault<T>()};
                }

                n6.IReadOnlyList<T> Input_12 = (n6.IReadOnlyList<T>)Input_In;
                n16._Operations_.Count<T>(Input_In: Input_12, Output_Out: out n6.IReadOnlyList<T> Output_13, Count_Out: out int Count_14);
                bool Apply_15 = true;
                var Output_16 = Count_14;
                if (Apply_15)
                {
                    var Output_17 = n10.Integer32Extensions.Dec(input: Count_14);
                    Output_16 = Output_17;
                }

                float Input_18 = (float)Output_16;
                bool Apply_19 = true;
                var Output_20 = Count_In;
                if (Apply_19)
                {
                    var Output_21 = n10.Integer32Extensions.Dec(input: Count_In);
                    Output_20 = Output_21;
                }

                float Input_2_22 = (float)Output_20;
                var Output_23 = (float)Input_18 / Input_2_22;
                var Output_24 = !Close_In;
                var builder_49 = n4.CollectionBuilders.GetBuilder(state_11.__cp_RFIqlyPUN87PvzCaR4PyQz, 16);
                n5.Spread<float> output_50;
                var builder_51 = n4.CollectionBuilders.GetBuilder(state_11.__cp_KJcmMhYG2d2Od2e792NpRO, 16);
                n5.Spread<T> output_52;
                var builder_53 = n4.CollectionBuilders.GetBuilder(state_11.__cp_QTUFCdsGWEPO6bCak0OVGd, 16);
                n5.Spread<T> output_54;
                try
                {
                    for (var i_25 = 0; i_25 < Count_In; i_25++)
                    {
                        var i_local_26 = i_25;
                        float Input_28 = (float)i_local_26;
                        var Output_29 = Input_28 * Output_23;
                        n10.Float32Extensions.Frac(input: Output_29, wholePart: out int Whole_Part_30, fractionalPart: out float Fractional_Part_31);
                        var Output_32 = n10.Integer32Extensions.Dec(input: Whole_Part_30);
                        int Input_2_33 = 0;
                        var Output_34 = Output_32;
                        if (Output_24)
                        {
                            n13._Operations_.Max<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_32, Input_2_In: Input_2_33, Output_Out: out Output_34);
                        }

                        w_0.CreateDefault(Output_Out: out T Output_35);
                        n16._Operations_.GetSlice<T>(Input_In: Input_1, Default_Value_In: Output_35, Index_In: Output_34, Result_Out: out T Result_36);
                        w_0.CreateDefault(Output_Out: out T Output_37);
                        n16._Operations_.GetSlice<T>(Input_In: Input_2, Default_Value_In: Output_37, Index_In: Whole_Part_30, Result_Out: out T Result_38);
                        w_0.CreateDefault(Output_Out: out T Output_39);
                        var Output_40 = n10.Integer32Extensions.Inc(input: Whole_Part_30);
                        var Output_41 = Output_40;
                        if (Output_24)
                        {
                            n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_40, Input_2_In: Output_16, Output_Out: out Output_41);
                        }

                        n16._Operations_.GetSlice<T>(Input_In: Input_3, Default_Value_In: Output_39, Index_In: Output_41, Result_Out: out T Result_42);
                        w_0.CreateDefault(Output_Out: out T Output_43);
                        var Output_44 = n10.Integer32Extensions.Inc(input: Output_40);
                        var Output_45 = Output_44;
                        if (Output_24)
                        {
                            n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_44, Input_2_In: Output_16, Output_Out: out Output_45);
                        }

                        n16._Operations_.GetSlice<T>(Input_In: Input_4, Default_Value_In: Output_43, Index_In: Output_45, Result_Out: out T Result_46);
                        n48._Operations_.BSplineCubic<T, AdM>(Control_1_In: Result_36, Control_2_In: Result_38, Control_3_In: Result_42, Control_4_In: Result_46, Range_In: Fractional_Part_31, Position_Out: out T Position_47, Tangent_Out: out T Tangent_48);
                        builder_49.Add(Output_29);
                        builder_51.Add(Position_47);
                        builder_53.Add(Tangent_48);
                    }
                }
                finally
                {
                    output_50 = builder_49.Commit();
                    output_52 = builder_51.Commit();
                    output_54 = builder_53.Commit();
                }

                if (state_11.__GetContext__().IsImmutable)
                    state_11 = output_50 != state_11.__cp_RFIqlyPUN87PvzCaR4PyQz || output_52 != state_11.__cp_KJcmMhYG2d2Od2e792NpRO || output_54 != state_11.__cp_QTUFCdsGWEPO6bCak0OVGd ? new __U3HCBkwAG7fNhgmUax5ml3(state_11)
                    {__cp_RFIqlyPUN87PvzCaR4PyQz = output_50, __cp_KJcmMhYG2d2Od2e792NpRO = output_52, __cp_QTUFCdsGWEPO6bCak0OVGd = output_54} : state_11;
                else
                {
                    state_11.__cp_RFIqlyPUN87PvzCaR4PyQz = output_50;
                    state_11.__cp_KJcmMhYG2d2Od2e792NpRO = output_52;
                    state_11.__cp_QTUFCdsGWEPO6bCak0OVGd = output_54;
                }

                outputs_9 = (output_50, output_52, output_54);
                manager_7 = manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6, state_11, outputs_9);
            }
            else
            {
                manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6);
            }

            var(__auto_55, __auto_56, __auto_57) = outputs_9;
            Output_Out = __auto_56;
            Tangent_Out = __auto_57;
            Interval_Out = __auto_55;
            n7.ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T> that_58 = this;
            if (this.__GetContext__().IsImmutable)
                that_58 = manager_7 != this.__cache_FxdQDv3AkFrOu4oqr2Au3g ? new ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T>(this)
                {__cache_FxdQDv3AkFrOu4oqr2Au3g = manager_7} : that_58;
            else
            {
                this.__cache_FxdQDv3AkFrOu4oqr2Au3g = manager_7;
            }

            return that_58;
        }

        public n7.ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T> that_0 = this;
            this.__cache_FxdQDv3AkFrOu4oqr2Au3g = null;
            return that_0;
        }

        public n7.ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T> __CreateDefault__()
        {
            n7.ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T> that_0 = this;
            this.__cache_FxdQDv3AkFrOu4oqr2Au3g = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_FxdQDv3AkFrOu4oqr2Au3g);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 272378U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "FxdQDv3AkFrOu4oqr2Au3g", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<T2, int, bool>, n2.ValueTuple<n5.Spread<float>, n5.Spread<T>, n5.Spread<T>>> __cache_FxdQDv3AkFrOu4oqr2Au3g = null;
        public ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF(ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T> other): base(other)
        {
            this.__cache_FxdQDv3AkFrOu4oqr2Au3g = other.__cache_FxdQDv3AkFrOu4oqr2Au3g;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_FxdQDv3AkFrOu4oqr2Au3g", in __cache_FxdQDv3AkFrOu4oqr2Au3g));
        }

        internal ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T> __WITH__(n42.Manager<n2.ValueTuple<T2, int, bool>, n2.ValueTuple<n5.Spread<float>, n5.Spread<T>, n5.Spread<T>>> __cache_FxdQDv3AkFrOu4oqr2Au3g)
        {
            n7.ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_FxdQDv3AkFrOu4oqr2Au3g != this.__cache_FxdQDv3AkFrOu4oqr2Au3g ? new ResampleBSpline_Tangent_FoeSgW0bZ2tMOSGpSQqnoF<T2, T>(this)
                {__cache_FxdQDv3AkFrOu4oqr2Au3g = __cache_FxdQDv3AkFrOu4oqr2Au3g} : that_0;
            else
            {
                this.__cache_FxdQDv3AkFrOu4oqr2Au3g = __cache_FxdQDv3AkFrOu4oqr2Au3g;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "U3HCBkwAG7fNhgmUax5ml3", Name = "__U3HCBkwAG7fNhgmUax5ml3")]
        [n2.SerializableAttribute]
        public class __U3HCBkwAG7fNhgmUax5ml3 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<float> __cp_RFIqlyPUN87PvzCaR4PyQz;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<T> __cp_KJcmMhYG2d2Od2e792NpRO;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<T> __cp_QTUFCdsGWEPO6bCak0OVGd;
            public __U3HCBkwAG7fNhgmUax5ml3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __U3HCBkwAG7fNhgmUax5ml3(__U3HCBkwAG7fNhgmUax5ml3 other): base(other)
            {
                this.__cp_RFIqlyPUN87PvzCaR4PyQz = other.__cp_RFIqlyPUN87PvzCaR4PyQz;
                this.__cp_KJcmMhYG2d2Od2e792NpRO = other.__cp_KJcmMhYG2d2Od2e792NpRO;
                this.__cp_QTUFCdsGWEPO6bCak0OVGd = other.__cp_QTUFCdsGWEPO6bCak0OVGd;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_RFIqlyPUN87PvzCaR4PyQz", in __cp_RFIqlyPUN87PvzCaR4PyQz), n1.CompilationHelper.GetValueOrExisting(values, "__cp_KJcmMhYG2d2Od2e792NpRO", in __cp_KJcmMhYG2d2Od2e792NpRO), n1.CompilationHelper.GetValueOrExisting(values, "__cp_QTUFCdsGWEPO6bCak0OVGd", in __cp_QTUFCdsGWEPO6bCak0OVGd));
            }

            internal __U3HCBkwAG7fNhgmUax5ml3 __WITH__(n5.Spread<float> __cp_RFIqlyPUN87PvzCaR4PyQz, n5.Spread<T> __cp_KJcmMhYG2d2Od2e792NpRO, n5.Spread<T> __cp_QTUFCdsGWEPO6bCak0OVGd)
            {
                __U3HCBkwAG7fNhgmUax5ml3 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_RFIqlyPUN87PvzCaR4PyQz != this.__cp_RFIqlyPUN87PvzCaR4PyQz || __cp_KJcmMhYG2d2Od2e792NpRO != this.__cp_KJcmMhYG2d2Od2e792NpRO || __cp_QTUFCdsGWEPO6bCak0OVGd != this.__cp_QTUFCdsGWEPO6bCak0OVGd ? new __U3HCBkwAG7fNhgmUax5ml3(this)
                    {__cp_RFIqlyPUN87PvzCaR4PyQz = __cp_RFIqlyPUN87PvzCaR4PyQz, __cp_KJcmMhYG2d2Od2e792NpRO = __cp_KJcmMhYG2d2Od2e792NpRO, __cp_QTUFCdsGWEPO6bCak0OVGd = __cp_QTUFCdsGWEPO6bCak0OVGd} : that_0;
                else
                {
                    this.__cp_RFIqlyPUN87PvzCaR4PyQz = __cp_RFIqlyPUN87PvzCaR4PyQz;
                    this.__cp_KJcmMhYG2d2Od2e792NpRO = __cp_KJcmMhYG2d2Od2e792NpRO;
                    this.__cp_QTUFCdsGWEPO6bCak0OVGd = __cp_QTUFCdsGWEPO6bCak0OVGd;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 272547U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "E3rKHEXR5BEOguuIPaowVl", Name = "ResampleHermite_E3rKHEXR5BEOguuIPaowVl")]
    [n2.SerializableAttribute]
    public class ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T> CreateDefault()
        {
            var instance = new ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T> Update<T4, AdM>(T4 Input_In, float Tension_In, float Bias_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<T> Output_Out, out n5.Spread<float> Interval_Out)
            where T4 : n6.IReadOnlyList<T> where AdM : struct, n18.IAdaptiveCreateDefault<T>, n49.IAdaptiveHermite2<T>
        {
            var w_0 = default(AdM);
            var Output_3 = this.__p_KAzmPWNzA6BNrKqHwn1V5E.Update<T4>(Value_In: Input_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            n6.IReadOnlyList<T> Input_4 = (n6.IReadOnlyList<T>)Input_In;
            bool Dispose_Cached_Outputs_5 = false;
            var manager_6 = this.__cache_HJlJUys9sGOLDkqJ6v97d9;
            if (manager_6 is null)
            {
                manager_6 = new n42.Manager<n2.ValueTuple<int, float, float>, n2.ValueTuple<n5.Spread<T>, n5.Spread<float>>>((n7._Operations_.CreateDefault<T>(), n7._Operations_.CreateDefault<float>()));
            }

            var inputs_7 = (Count_In, Tension_In, Bias_In);
            var outputs_8 = manager_6.Outputs;
            var Has_Changed_9 = Result_1 || manager_6.InputsChanged(inputs_7);
            if (Has_Changed_9)
            {
                if (Dispose_Cached_Outputs_5)
                    manager_6.DisposeOutputs();
                var state_10 = n1.CompilationHelper.Restore<__JuS0Xa4hGVkOqHapN7VvjY>(manager_6.State, __GetContext__());
                if (state_10 == null)
                {
                    state_10 = new __JuS0Xa4hGVkOqHapN7VvjY(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_MyC33uenXwfLPJeYgMcJre = n7._Operations_.CreateDefault<T>(), __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj = n7._Operations_.CreateDefault<n6.IEnumerable<T>>(), __cp_TQ8cikDjZ0zOhI9SDd2gbv = n7._Operations_.CreateDefault<T>(), __cp_I8CgYcbGas0OyEbr9rScgH = n7._Operations_.CreateDefault<float>()};
                }

                bool Apply_11 = true;
                var Output_12 = Count_In;
                if (Apply_11)
                {
                    var Output_13 = n10.Integer32Extensions.Dec(input: Count_In);
                    Output_12 = Output_13;
                }

                n16._Operations_.Count<T>(Input_In: Input_4, Output_Out: out n6.IReadOnlyList<T> Output_14, Count_Out: out int Count_15);
                bool Apply_16 = true;
                var Output_17 = Count_15;
                if (Apply_16)
                {
                    var Output_18 = n10.Integer32Extensions.Dec(input: Count_15);
                    Output_17 = Output_18;
                }

                float Input_19 = (float)Output_17;
                float Input_2_20 = (float)Output_12;
                var Output_21 = (float)Input_19 / Input_2_20;
                w_0.CreateDefault(Output_Out: out T Output_22);
                n8._Operations_.LastOrDefault<T4, T>(Input_In: Input_In, Default_Value_In: Output_22, Output_Out: out T4 Output_23, Result_Out: out T Result_24);
                var builder_25 = n4.CollectionBuilders.GetBuilder(state_10.__pin_group_Input_In_MyC33uenXwfLPJeYgMcJre, 1);
                builder_25.Add(Result_24);
                var __pin_group_Input_In_MyC33uenXwfLPJeYgMcJre_26 = builder_25.Commit();
                n7._Operations_.FromValue<T>(Input_In: __pin_group_Input_In_MyC33uenXwfLPJeYgMcJre_26, Result_Out: out n5.Spread<T> Result_27);
                n6.IEnumerable<T> Input_28 = (n6.IEnumerable<T>)Result_27;
                n6.IEnumerable<T> Input_2_29 = (n6.IEnumerable<T>)Output_23;
                n6.IEnumerable<T> Input_30 = (n6.IEnumerable<T>)Output_23;
                int Count_31 = 2;
                n8._Operations_.Take<T>(Input_In: Input_30, Count_In: Count_31, Output_Out: out n6.IEnumerable<T> Output_32);
                var builder_33 = n4.CollectionBuilders.GetBuilder(state_10.__pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj, 3);
                builder_33.Add(Input_28);
                builder_33.Add(Input_2_29);
                builder_33.Add(Output_32);
                var __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj_34 = builder_33.Commit();
                n7._Operations_.Concat<T>(Input_In: __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj_34, Output_Out: out n5.Spread<T> Output_35);
                n6.IReadOnlyList<T> Input_36 = (n6.IReadOnlyList<T>)Output_35;
                n6.IReadOnlyList<T> Input_37 = (n6.IReadOnlyList<T>)Output_35;
                n6.IReadOnlyList<T> Input_38 = (n6.IReadOnlyList<T>)Output_35;
                n6.IReadOnlyList<T> Input_39 = (n6.IReadOnlyList<T>)Output_35;
                var builder_65 = n4.CollectionBuilders.GetBuilder(state_10.__cp_TQ8cikDjZ0zOhI9SDd2gbv, 16);
                n5.Spread<T> output_66;
                var builder_67 = n4.CollectionBuilders.GetBuilder(state_10.__cp_I8CgYcbGas0OyEbr9rScgH, 16);
                n5.Spread<float> output_68;
                try
                {
                    for (var i_40 = 0; i_40 < Output_12; i_40++)
                    {
                        var i_local_41 = i_40;
                        float Input_43 = (float)i_local_41;
                        var Output_44 = Input_43 * Output_21;
                        n10.Float32Extensions.Frac(input: Output_44, wholePart: out int Whole_Part_45, fractionalPart: out float Fractional_Part_46);
                        int Input_2_47 = 1;
                        n13._Operations_.Max<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Whole_Part_45, Input_2_In: Input_2_47, Output_Out: out int Output_48);
                        var Item_49 = Input_36[Output_48];
                        bool Apply_50 = true;
                        var Output_51 = Whole_Part_45;
                        if (Apply_50)
                        {
                            var Output_52 = n10.Integer32Extensions.Inc(input: Whole_Part_45);
                            Output_51 = Output_52;
                        }

                        var Item_53 = Input_37[Output_51];
                        bool Apply_54 = true;
                        var Output_55 = Output_51;
                        if (Apply_54)
                        {
                            var Output_56 = n10.Integer32Extensions.Inc(input: Output_51);
                            Output_55 = Output_56;
                        }

                        n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_55, Input_2_In: Count_15, Output_Out: out int Output_57);
                        var Item_58 = Input_38[Output_57];
                        bool Apply_59 = true;
                        var Output_60 = Output_55;
                        if (Apply_59)
                        {
                            var Output_61 = n10.Integer32Extensions.Inc(input: Output_55);
                            Output_60 = Output_61;
                        }

                        n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_60, Input_2_In: Count_15, Output_Out: out int Output_62);
                        var Item_63 = Input_39[Output_62];
                        w_0.Hermite2(Y_0_In: Item_49, Y_1_In: Item_53, Y_2_In: Item_58, Y_3_In: Item_63, Phase_In: Fractional_Part_46, Tension_In: Tension_In, Bias_In: Bias_In, Output_Out: out T Output_64);
                        builder_65.Add(Output_64);
                        builder_67.Add(Output_44);
                    }
                }
                finally
                {
                    output_66 = builder_65.Commit();
                    output_68 = builder_67.Commit();
                }

                if (state_10.__GetContext__().IsImmutable)
                    state_10 = __pin_group_Input_In_MyC33uenXwfLPJeYgMcJre_26 != state_10.__pin_group_Input_In_MyC33uenXwfLPJeYgMcJre || __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj_34 != state_10.__pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj || output_66 != state_10.__cp_TQ8cikDjZ0zOhI9SDd2gbv || output_68 != state_10.__cp_I8CgYcbGas0OyEbr9rScgH ? new __JuS0Xa4hGVkOqHapN7VvjY(state_10)
                    {__pin_group_Input_In_MyC33uenXwfLPJeYgMcJre = __pin_group_Input_In_MyC33uenXwfLPJeYgMcJre_26, __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj = __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj_34, __cp_TQ8cikDjZ0zOhI9SDd2gbv = output_66, __cp_I8CgYcbGas0OyEbr9rScgH = output_68} : state_10;
                else
                {
                    state_10.__pin_group_Input_In_MyC33uenXwfLPJeYgMcJre = __pin_group_Input_In_MyC33uenXwfLPJeYgMcJre_26;
                    state_10.__pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj = __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj_34;
                    state_10.__cp_TQ8cikDjZ0zOhI9SDd2gbv = output_66;
                    state_10.__cp_I8CgYcbGas0OyEbr9rScgH = output_68;
                }

                outputs_8 = (output_66, output_68);
                manager_6 = manager_6.Update(inputs_7, __GetContext__().IsImmutable, Dispose_Cached_Outputs_5, state_10, outputs_8);
            }
            else
            {
                manager_6.Update(inputs_7, __GetContext__().IsImmutable, Dispose_Cached_Outputs_5);
            }

            var(__auto_69, __auto_70) = outputs_8;
            Output_Out = __auto_69;
            Interval_Out = __auto_70;
            n7.ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T> that_71 = this;
            if (this.__GetContext__().IsImmutable)
                that_71 = Output_3 != this.__p_KAzmPWNzA6BNrKqHwn1V5E || manager_6 != this.__cache_HJlJUys9sGOLDkqJ6v97d9 ? new ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T>(this)
                {__p_KAzmPWNzA6BNrKqHwn1V5E = Output_3, __cache_HJlJUys9sGOLDkqJ6v97d9 = manager_6} : that_71;
            else
            {
                this.__p_KAzmPWNzA6BNrKqHwn1V5E = Output_3;
                this.__cache_HJlJUys9sGOLDkqJ6v97d9 = manager_6;
            }

            return that_71;
        }

        public n7.ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "KAzmPWNzA6BNrKqHwn1V5E", 272946U);
            var Output_1 = n3.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T>.Create(Node_Context: Node_Context_0);
            n7.ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T> that_2 = this;
            this.__p_KAzmPWNzA6BNrKqHwn1V5E = Output_1;
            this.__cache_HJlJUys9sGOLDkqJ6v97d9 = null;
            return that_2;
        }

        public n7.ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T> __CreateDefault__()
        {
            n7.ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T> that_0 = this;
            this.__p_KAzmPWNzA6BNrKqHwn1V5E = n3.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T>.CreateDefault();
            this.__cache_HJlJUys9sGOLDkqJ6v97d9 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_KAzmPWNzA6BNrKqHwn1V5E);
            n1.CompilationHelper.SafeDispose(this.__cache_HJlJUys9sGOLDkqJ6v97d9);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 272946U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "KAzmPWNzA6BNrKqHwn1V5E", Name = "SequenceChanged", IsManaged = true, IsAutoGenerated = true)]
        public n3.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> __p_KAzmPWNzA6BNrKqHwn1V5E;
        [n1.ElementAttribute(TracingId = 272554U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "HJlJUys9sGOLDkqJ6v97d9", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<int, float, float>, n2.ValueTuple<n5.Spread<T>, n5.Spread<float>>> __cache_HJlJUys9sGOLDkqJ6v97d9 = null;
        public ResampleHermite_E3rKHEXR5BEOguuIPaowVl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ResampleHermite_E3rKHEXR5BEOguuIPaowVl(ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T> other): base(other)
        {
            this.__p_KAzmPWNzA6BNrKqHwn1V5E = other.__p_KAzmPWNzA6BNrKqHwn1V5E;
            this.__cache_HJlJUys9sGOLDkqJ6v97d9 = other.__cache_HJlJUys9sGOLDkqJ6v97d9;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_KAzmPWNzA6BNrKqHwn1V5E", in __p_KAzmPWNzA6BNrKqHwn1V5E), n1.CompilationHelper.GetValueOrExisting(values, "__cache_HJlJUys9sGOLDkqJ6v97d9", in __cache_HJlJUys9sGOLDkqJ6v97d9));
        }

        internal ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T> __WITH__(n3.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<T> __p_KAzmPWNzA6BNrKqHwn1V5E, n42.Manager<n2.ValueTuple<int, float, float>, n2.ValueTuple<n5.Spread<T>, n5.Spread<float>>> __cache_HJlJUys9sGOLDkqJ6v97d9)
        {
            n7.ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_KAzmPWNzA6BNrKqHwn1V5E != this.__p_KAzmPWNzA6BNrKqHwn1V5E || __cache_HJlJUys9sGOLDkqJ6v97d9 != this.__cache_HJlJUys9sGOLDkqJ6v97d9 ? new ResampleHermite_E3rKHEXR5BEOguuIPaowVl<T>(this)
                {__p_KAzmPWNzA6BNrKqHwn1V5E = __p_KAzmPWNzA6BNrKqHwn1V5E, __cache_HJlJUys9sGOLDkqJ6v97d9 = __cache_HJlJUys9sGOLDkqJ6v97d9} : that_0;
            else
            {
                this.__p_KAzmPWNzA6BNrKqHwn1V5E = __p_KAzmPWNzA6BNrKqHwn1V5E;
                this.__cache_HJlJUys9sGOLDkqJ6v97d9 = __cache_HJlJUys9sGOLDkqJ6v97d9;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "JuS0Xa4hGVkOqHapN7VvjY", Name = "__JuS0Xa4hGVkOqHapN7VvjY")]
        [n2.SerializableAttribute]
        public class __JuS0Xa4hGVkOqHapN7VvjY : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<T> __pin_group_Input_In_MyC33uenXwfLPJeYgMcJre = default(n5.Spread<T>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n6.IEnumerable<T>> __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj = default(n5.Spread<n6.IEnumerable<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<T> __cp_TQ8cikDjZ0zOhI9SDd2gbv;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<float> __cp_I8CgYcbGas0OyEbr9rScgH;
            public __JuS0Xa4hGVkOqHapN7VvjY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __JuS0Xa4hGVkOqHapN7VvjY(__JuS0Xa4hGVkOqHapN7VvjY other): base(other)
            {
                this.__pin_group_Input_In_MyC33uenXwfLPJeYgMcJre = other.__pin_group_Input_In_MyC33uenXwfLPJeYgMcJre;
                this.__pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj = other.__pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj;
                this.__cp_TQ8cikDjZ0zOhI9SDd2gbv = other.__cp_TQ8cikDjZ0zOhI9SDd2gbv;
                this.__cp_I8CgYcbGas0OyEbr9rScgH = other.__cp_I8CgYcbGas0OyEbr9rScgH;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_MyC33uenXwfLPJeYgMcJre", in __pin_group_Input_In_MyC33uenXwfLPJeYgMcJre), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj", in __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj), n1.CompilationHelper.GetValueOrExisting(values, "__cp_TQ8cikDjZ0zOhI9SDd2gbv", in __cp_TQ8cikDjZ0zOhI9SDd2gbv), n1.CompilationHelper.GetValueOrExisting(values, "__cp_I8CgYcbGas0OyEbr9rScgH", in __cp_I8CgYcbGas0OyEbr9rScgH));
            }

            internal __JuS0Xa4hGVkOqHapN7VvjY __WITH__(n5.Spread<T> __pin_group_Input_In_MyC33uenXwfLPJeYgMcJre, n5.Spread<n6.IEnumerable<T>> __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj, n5.Spread<T> __cp_TQ8cikDjZ0zOhI9SDd2gbv, n5.Spread<float> __cp_I8CgYcbGas0OyEbr9rScgH)
            {
                __JuS0Xa4hGVkOqHapN7VvjY that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __pin_group_Input_In_MyC33uenXwfLPJeYgMcJre != this.__pin_group_Input_In_MyC33uenXwfLPJeYgMcJre || __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj != this.__pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj || __cp_TQ8cikDjZ0zOhI9SDd2gbv != this.__cp_TQ8cikDjZ0zOhI9SDd2gbv || __cp_I8CgYcbGas0OyEbr9rScgH != this.__cp_I8CgYcbGas0OyEbr9rScgH ? new __JuS0Xa4hGVkOqHapN7VvjY(this)
                    {__pin_group_Input_In_MyC33uenXwfLPJeYgMcJre = __pin_group_Input_In_MyC33uenXwfLPJeYgMcJre, __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj = __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj, __cp_TQ8cikDjZ0zOhI9SDd2gbv = __cp_TQ8cikDjZ0zOhI9SDd2gbv, __cp_I8CgYcbGas0OyEbr9rScgH = __cp_I8CgYcbGas0OyEbr9rScgH} : that_0;
                else
                {
                    this.__pin_group_Input_In_MyC33uenXwfLPJeYgMcJre = __pin_group_Input_In_MyC33uenXwfLPJeYgMcJre;
                    this.__pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj = __pin_group_Input_In_UabJdXdOR0mMEocqEm58Cj;
                    this.__cp_TQ8cikDjZ0zOhI9SDd2gbv = __cp_TQ8cikDjZ0zOhI9SDd2gbv;
                    this.__cp_I8CgYcbGas0OyEbr9rScgH = __cp_I8CgYcbGas0OyEbr9rScgH;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 273021U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "UmP6nXJno3hLuovpQ3KDPD", Name = "Randomizer_UmP6nXJno3hLuovpQ3KDPD")]
    [n2.SerializableAttribute]
    public class Randomizer_UmP6nXJno3hLuovpQ3KDPD<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.Randomizer_UmP6nXJno3hLuovpQ3KDPD<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Randomizer_UmP6nXJno3hLuovpQ3KDPD<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.Randomizer_UmP6nXJno3hLuovpQ3KDPD<T> CreateDefault()
        {
            var instance = new Randomizer_UmP6nXJno3hLuovpQ3KDPD<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.Randomizer_UmP6nXJno3hLuovpQ3KDPD<T> Update<T2>(T2 Input_In, int Seed_In, out n5.Spread<T> Output_Out)
            where T2 : n6.IReadOnlyList<T>
        {
            n6.IReadOnlyList<T> Input_0 = (n6.IReadOnlyList<T>)Input_In;
            n6.IEnumerable<T> Input_1 = (n6.IEnumerable<T>)Input_In;
            n8._Operations_.Count<T>(Input_In: Input_1, Result_Out: out int Result_2);
            float Center_3 = 0F;
            float Width_4 = 1F;
            var State_Output_6 = this.__p_DAH0NHgQImTPN4LsiUTQpN.Update(Center_In: Center_3, Width_In: Width_4, Seed_In: Seed_In, Count_In: Result_2, Output_Out: out n5.Spread<float> Output_5);
            var State_Output_9 = this.__p_RIHbllwMqUEPdBZhBwG5ro.Update<n5.Spread<float>>(Input_In: Output_5, Output_Out: out n5.Spread<float> Output_7, Indices_Out: out n5.Spread<int> Indices_8);
            var builder_16 = n4.CollectionBuilders.GetBuilder(this.__cp_SKT7j83eUHFLoeUHYOnIu1, 16);
            n5.Spread<T> output_17;
            try
            {
                var i_12 = 0;
                foreach (var item_10 in n4.CollectionExtensions.AsSpan(Indices_8))
                {
                    var splicer_11 = item_10;
                    var i_local_13 = i_12;
                    var Item_15 = Input_0[splicer_11];
                    builder_16.Add(Item_15);
                    i_12++;
                }
            }
            finally
            {
                output_17 = builder_16.Commit();
            }

            Output_Out = output_17;
            n7.Randomizer_UmP6nXJno3hLuovpQ3KDPD<T> that_18 = this;
            if (this.__GetContext__().IsImmutable)
                that_18 = State_Output_6 != this.__p_DAH0NHgQImTPN4LsiUTQpN || State_Output_9 != this.__p_RIHbllwMqUEPdBZhBwG5ro || output_17 != this.__cp_SKT7j83eUHFLoeUHYOnIu1 ? new Randomizer_UmP6nXJno3hLuovpQ3KDPD<T>(this)
                {__p_DAH0NHgQImTPN4LsiUTQpN = State_Output_6, __p_RIHbllwMqUEPdBZhBwG5ro = State_Output_9, __cp_SKT7j83eUHFLoeUHYOnIu1 = output_17} : that_18;
            else
            {
                this.__p_DAH0NHgQImTPN4LsiUTQpN = State_Output_6;
                this.__p_RIHbllwMqUEPdBZhBwG5ro = State_Output_9;
                this.__cp_SKT7j83eUHFLoeUHYOnIu1 = output_17;
            }

            return that_18;
        }

        public n7.Randomizer_UmP6nXJno3hLuovpQ3KDPD<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "DAH0NHgQImTPN4LsiUTQpN", 273024U);
            var Output_1 = n7.RandomSpread_UNv4cR9YdgkPYF08xpFER9.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "RIHbllwMqUEPdBZhBwG5ro", 273046U);
            var Output_3 = n7.Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<float>.Create<n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Node_Context: Node_Context_2);
            n7.Randomizer_UmP6nXJno3hLuovpQ3KDPD<T> that_4 = this;
            this.__cp_SKT7j83eUHFLoeUHYOnIu1 = n7._Operations_.CreateDefault<T>();
            this.__p_DAH0NHgQImTPN4LsiUTQpN = Output_1;
            this.__p_RIHbllwMqUEPdBZhBwG5ro = Output_3;
            return that_4;
        }

        public n7.Randomizer_UmP6nXJno3hLuovpQ3KDPD<T> __CreateDefault__()
        {
            n7.Randomizer_UmP6nXJno3hLuovpQ3KDPD<T> that_0 = this;
            this.__cp_SKT7j83eUHFLoeUHYOnIu1 = n7._Operations_.CreateDefault<T>();
            this.__p_DAH0NHgQImTPN4LsiUTQpN = n7.RandomSpread_UNv4cR9YdgkPYF08xpFER9.CreateDefault();
            this.__p_RIHbllwMqUEPdBZhBwG5ro = n7.Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<float>.CreateDefault<n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DAH0NHgQImTPN4LsiUTQpN);
            n1.CompilationHelper.SafeDispose(this.__p_RIHbllwMqUEPdBZhBwG5ro);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 273024U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "DAH0NHgQImTPN4LsiUTQpN", Name = "RandomSpread", IsManaged = true, IsAutoGenerated = true)]
        public n7.RandomSpread_UNv4cR9YdgkPYF08xpFER9 __p_DAH0NHgQImTPN4LsiUTQpN;
        [n1.ElementAttribute(TracingId = 273046U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "RIHbllwMqUEPdBZhBwG5ro", Name = "Sort (FormerIndex)", IsManaged = true, IsAutoGenerated = true)]
        public n7.Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<float> __p_RIHbllwMqUEPdBZhBwG5ro;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<T> __cp_SKT7j83eUHFLoeUHYOnIu1;
        public Randomizer_UmP6nXJno3hLuovpQ3KDPD(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Randomizer_UmP6nXJno3hLuovpQ3KDPD(Randomizer_UmP6nXJno3hLuovpQ3KDPD<T> other): base(other)
        {
            this.__p_DAH0NHgQImTPN4LsiUTQpN = other.__p_DAH0NHgQImTPN4LsiUTQpN;
            this.__p_RIHbllwMqUEPdBZhBwG5ro = other.__p_RIHbllwMqUEPdBZhBwG5ro;
            this.__cp_SKT7j83eUHFLoeUHYOnIu1 = other.__cp_SKT7j83eUHFLoeUHYOnIu1;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DAH0NHgQImTPN4LsiUTQpN", in __p_DAH0NHgQImTPN4LsiUTQpN), n1.CompilationHelper.GetValueOrExisting(values, "__p_RIHbllwMqUEPdBZhBwG5ro", in __p_RIHbllwMqUEPdBZhBwG5ro), n1.CompilationHelper.GetValueOrExisting(values, "__cp_SKT7j83eUHFLoeUHYOnIu1", in __cp_SKT7j83eUHFLoeUHYOnIu1));
        }

        internal Randomizer_UmP6nXJno3hLuovpQ3KDPD<T> __WITH__(n7.RandomSpread_UNv4cR9YdgkPYF08xpFER9 __p_DAH0NHgQImTPN4LsiUTQpN, n7.Sort_FormerIndex_QKHJtW5MfCeOm2LyKhYalN<float> __p_RIHbllwMqUEPdBZhBwG5ro, n5.Spread<T> __cp_SKT7j83eUHFLoeUHYOnIu1)
        {
            n7.Randomizer_UmP6nXJno3hLuovpQ3KDPD<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_DAH0NHgQImTPN4LsiUTQpN != this.__p_DAH0NHgQImTPN4LsiUTQpN || __p_RIHbllwMqUEPdBZhBwG5ro != this.__p_RIHbllwMqUEPdBZhBwG5ro || __cp_SKT7j83eUHFLoeUHYOnIu1 != this.__cp_SKT7j83eUHFLoeUHYOnIu1 ? new Randomizer_UmP6nXJno3hLuovpQ3KDPD<T>(this)
                {__p_DAH0NHgQImTPN4LsiUTQpN = __p_DAH0NHgQImTPN4LsiUTQpN, __p_RIHbllwMqUEPdBZhBwG5ro = __p_RIHbllwMqUEPdBZhBwG5ro, __cp_SKT7j83eUHFLoeUHYOnIu1 = __cp_SKT7j83eUHFLoeUHYOnIu1} : that_0;
            else
            {
                this.__p_DAH0NHgQImTPN4LsiUTQpN = __p_DAH0NHgQImTPN4LsiUTQpN;
                this.__p_RIHbllwMqUEPdBZhBwG5ro = __p_RIHbllwMqUEPdBZhBwG5ro;
                this.__cp_SKT7j83eUHFLoeUHYOnIu1 = __cp_SKT7j83eUHFLoeUHYOnIu1;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 273073U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "SDaG6L4r0h2LG9nOVLXBCG", Name = "RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG")]
    [n2.SerializableAttribute]
    public class RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG Create(n1.NodeContext Node_Context)
        {
            var instance = new RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG CreateDefault()
        {
            var instance = new RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG Update([n4.SerializedDefaultValueAttribute("0, 0, 0, 0", false)] n26.Vector4 Center_In, [n4.SerializedDefaultValueAttribute("1, 1, 1, 1", false)] n26.Vector4 Size_In, int Seed_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<n26.Vector4> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_VdeQj9BCJxnNCa04DPF53v;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<n26.Vector4, n26.Vector4, int, int>, n2.ValueTuple<n5.Spread<n26.Vector4>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<n26.Vector4>()));
            }

            var inputs_3 = (Center_In, Size_In, Seed_In, Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                n32._Operations_.CreateRandomSpread__4D(Center_In: Center_In, Size_In: Size_In, Seed_In: Seed_In, Count_In: Count_In, Output_Out: out n5.Spread<n26.Vector4> Output_7);
                outputs_4 = n2.ValueTuple.Create(Output_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            Output_Out = __auto_8;
            n7.RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = manager_2 != this.__cache_VdeQj9BCJxnNCa04DPF53v ? new RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG(this)
                {__cache_VdeQj9BCJxnNCa04DPF53v = manager_2} : that_9;
            else
            {
                this.__cache_VdeQj9BCJxnNCa04DPF53v = manager_2;
            }

            return that_9;
        }

        public n7.RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG that_0 = this;
            this.__cache_VdeQj9BCJxnNCa04DPF53v = null;
            return that_0;
        }

        public n7.RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG __CreateDefault__()
        {
            n7.RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG that_0 = this;
            this.__cache_VdeQj9BCJxnNCa04DPF53v = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_VdeQj9BCJxnNCa04DPF53v);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 273076U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "VdeQj9BCJxnNCa04DPF53v", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<n26.Vector4, n26.Vector4, int, int>, n2.ValueTuple<n5.Spread<n26.Vector4>>> __cache_VdeQj9BCJxnNCa04DPF53v = null;
        public RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG(RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG other): base(other)
        {
            this.__cache_VdeQj9BCJxnNCa04DPF53v = other.__cache_VdeQj9BCJxnNCa04DPF53v;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_VdeQj9BCJxnNCa04DPF53v", in __cache_VdeQj9BCJxnNCa04DPF53v));
        }

        internal RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG __WITH__(n42.Manager<n2.ValueTuple<n26.Vector4, n26.Vector4, int, int>, n2.ValueTuple<n5.Spread<n26.Vector4>>> __cache_VdeQj9BCJxnNCa04DPF53v)
        {
            n7.RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_VdeQj9BCJxnNCa04DPF53v != this.__cache_VdeQj9BCJxnNCa04DPF53v ? new RandomSpread__4d_SDaG6L4r0h2LG9nOVLXBCG(this)
                {__cache_VdeQj9BCJxnNCa04DPF53v = __cache_VdeQj9BCJxnNCa04DPF53v} : that_0;
            else
            {
                this.__cache_VdeQj9BCJxnNCa04DPF53v = __cache_VdeQj9BCJxnNCa04DPF53v;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 273124U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "GaTuHYHNNNgQXveRZUAHXI", Name = "LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI")]
    [n2.SerializableAttribute]
    public class LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T> CreateDefault()
        {
            var instance = new LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T> Update<AdM>(n27.Range<T> Range_In, [n4.SerializedDefaultValueAttribute("Centered", false)] n35.LinearSpreadAlignment Alignment_In, float Phase_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<T> Output_Out)
            where AdM : struct, n18.IAdaptiveCreateDefault<n5.Spread<T>>, n19.IAdaptiveOperatorMulitply_Scale<T>, n19.IAdaptiveOperatorPlus<T>, n19.IAdaptiveLerp<T>
        {
            var w_0 = default(AdM);
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_IAUiijFyDmlOkz4pZydyas;
            if (manager_3 is null)
            {
                manager_3 = new n42.Manager<n2.ValueTuple<n27.Range<T>, n35.LinearSpreadAlignment, float, int>, n2.ValueTuple<n5.Spread<T>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<T>()));
            }

            var inputs_4 = (Range_In, Alignment_In, Phase_In, Count_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                n32._Operations_.CreateLinearSpread_Range<T, AdM>(Range_In: Range_In, Alignment_In: Alignment_In, Phase_In: Phase_In, Count_In: Count_In, Output_Out: out n5.Spread<T> Output_8);
                outputs_5 = n2.ValueTuple.Create(Output_8);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, default, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_9 = outputs_5.Item1;
            Output_Out = __auto_9;
            n7.LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T> that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = manager_3 != this.__cache_IAUiijFyDmlOkz4pZydyas ? new LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T>(this)
                {__cache_IAUiijFyDmlOkz4pZydyas = manager_3} : that_10;
            else
            {
                this.__cache_IAUiijFyDmlOkz4pZydyas = manager_3;
            }

            return that_10;
        }

        public n7.LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T> that_0 = this;
            this.__cache_IAUiijFyDmlOkz4pZydyas = null;
            return that_0;
        }

        public n7.LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T> __CreateDefault__()
        {
            n7.LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T> that_0 = this;
            this.__cache_IAUiijFyDmlOkz4pZydyas = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_IAUiijFyDmlOkz4pZydyas);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 273127U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "IAUiijFyDmlOkz4pZydyas", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<n27.Range<T>, n35.LinearSpreadAlignment, float, int>, n2.ValueTuple<n5.Spread<T>>> __cache_IAUiijFyDmlOkz4pZydyas = null;
        public LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI(LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T> other): base(other)
        {
            this.__cache_IAUiijFyDmlOkz4pZydyas = other.__cache_IAUiijFyDmlOkz4pZydyas;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_IAUiijFyDmlOkz4pZydyas", in __cache_IAUiijFyDmlOkz4pZydyas));
        }

        internal LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T> __WITH__(n42.Manager<n2.ValueTuple<n27.Range<T>, n35.LinearSpreadAlignment, float, int>, n2.ValueTuple<n5.Spread<T>>> __cache_IAUiijFyDmlOkz4pZydyas)
        {
            n7.LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_IAUiijFyDmlOkz4pZydyas != this.__cache_IAUiijFyDmlOkz4pZydyas ? new LinearSpread_Range_GaTuHYHNNNgQXveRZUAHXI<T>(this)
                {__cache_IAUiijFyDmlOkz4pZydyas = __cache_IAUiijFyDmlOkz4pZydyas} : that_0;
            else
            {
                this.__cache_IAUiijFyDmlOkz4pZydyas = __cache_IAUiijFyDmlOkz4pZydyas;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 273175U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Fhj5xydYiRTNdXppJ1Dvg1", Name = "GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1")]
    [n2.SerializableAttribute]
    public class GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1 Create(n1.NodeContext Node_Context)
        {
            var instance = new GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1 CreateDefault()
        {
            var instance = new GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1 Update(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector2 Width_In, n35.LinearSpreadAlignment Alignment_In, n26.Vector2 Phase_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Int2 Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_VLbbaPvvRaaMSrkc3NK88R;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, n35.LinearSpreadAlignment, n26.Vector2, n26.Int2>, n2.ValueTuple<n5.Spread<n26.Vector2>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<n26.Vector2>()));
            }

            var inputs_3 = (Center_In, Width_In, Alignment_In, Phase_In, Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__UTLVrLMi5cJPgJU6DWtRJx>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __UTLVrLMi5cJPgJU6DWtRJx(__GetContext__(), n1.VLObject.NewIdentity())
                    {Builder_To_Fill = n24._Operations_.CreateDefault<n26.Vector2>()};
                }

                n5.SpreadBuilder<n26.Vector2> __auto_7 = state_6.Builder_To_Fill;
                bool Clear_Builder_8 = true;
                n32._Operations_.CreateGridSpread__2D(Center_In: Center_In, Width_In: Width_In, Alignment_In: Alignment_In, Phase_In: Phase_In, Builder_To_Fill_In: __auto_7, Clear_Builder_In: Clear_Builder_8, Count_In: Count_In, Output_Out: out n5.Spread<n26.Vector2> Output_9);
                outputs_4 = n2.ValueTuple.Create(Output_9);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_10 = outputs_4.Item1;
            Output_Out = __auto_10;
            n7.GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1 that_11 = this;
            if (this.__GetContext__().IsImmutable)
                that_11 = manager_2 != this.__cache_VLbbaPvvRaaMSrkc3NK88R ? new GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1(this)
                {__cache_VLbbaPvvRaaMSrkc3NK88R = manager_2} : that_11;
            else
            {
                this.__cache_VLbbaPvvRaaMSrkc3NK88R = manager_2;
            }

            return that_11;
        }

        public n7.GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1 __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1 that_0 = this;
            this.__cache_VLbbaPvvRaaMSrkc3NK88R = null;
            return that_0;
        }

        public n7.GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1 __CreateDefault__()
        {
            n7.GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1 that_0 = this;
            this.__cache_VLbbaPvvRaaMSrkc3NK88R = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_VLbbaPvvRaaMSrkc3NK88R);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 273180U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "VLbbaPvvRaaMSrkc3NK88R", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, n35.LinearSpreadAlignment, n26.Vector2, n26.Int2>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_VLbbaPvvRaaMSrkc3NK88R = null;
        public GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1(GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1 other): base(other)
        {
            this.__cache_VLbbaPvvRaaMSrkc3NK88R = other.__cache_VLbbaPvvRaaMSrkc3NK88R;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_VLbbaPvvRaaMSrkc3NK88R", in __cache_VLbbaPvvRaaMSrkc3NK88R));
        }

        internal GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1 __WITH__(n42.Manager<n2.ValueTuple<n26.Vector2, n26.Vector2, n35.LinearSpreadAlignment, n26.Vector2, n26.Int2>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_VLbbaPvvRaaMSrkc3NK88R)
        {
            n7.GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_VLbbaPvvRaaMSrkc3NK88R != this.__cache_VLbbaPvvRaaMSrkc3NK88R ? new GridSpread__2D_Fhj5xydYiRTNdXppJ1Dvg1(this)
                {__cache_VLbbaPvvRaaMSrkc3NK88R = __cache_VLbbaPvvRaaMSrkc3NK88R} : that_0;
            else
            {
                this.__cache_VLbbaPvvRaaMSrkc3NK88R = __cache_VLbbaPvvRaaMSrkc3NK88R;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "UTLVrLMi5cJPgJU6DWtRJx", Name = "__UTLVrLMi5cJPgJU6DWtRJx")]
        [n2.SerializableAttribute]
        public class __UTLVrLMi5cJPgJU6DWtRJx : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(TracingId = 273203U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "OdLGvGlxm9pQVrZBRDXPk2", Name = "Builder To Fill")]
            public n5.SpreadBuilder<n26.Vector2> Builder_To_Fill;
            public __UTLVrLMi5cJPgJU6DWtRJx(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __UTLVrLMi5cJPgJU6DWtRJx(__UTLVrLMi5cJPgJU6DWtRJx other): base(other)
            {
                this.Builder_To_Fill = other.Builder_To_Fill;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Builder_To_Fill", in Builder_To_Fill));
            }

            internal __UTLVrLMi5cJPgJU6DWtRJx __WITH__(n5.SpreadBuilder<n26.Vector2> Builder_To_Fill)
            {
                __UTLVrLMi5cJPgJU6DWtRJx that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = Builder_To_Fill != this.Builder_To_Fill ? new __UTLVrLMi5cJPgJU6DWtRJx(this)
                    {Builder_To_Fill = Builder_To_Fill} : that_0;
                else
                {
                    this.Builder_To_Fill = Builder_To_Fill;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 273238U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "GbKoBslUVKWLOhuVujVws1", Name = "GridSpread__3D_GbKoBslUVKWLOhuVujVws1")]
    [n2.SerializableAttribute]
    public class GridSpread__3D_GbKoBslUVKWLOhuVujVws1 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.GridSpread__3D_GbKoBslUVKWLOhuVujVws1 Create(n1.NodeContext Node_Context)
        {
            var instance = new GridSpread__3D_GbKoBslUVKWLOhuVujVws1(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.GridSpread__3D_GbKoBslUVKWLOhuVujVws1 CreateDefault()
        {
            var instance = new GridSpread__3D_GbKoBslUVKWLOhuVujVws1(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.GridSpread__3D_GbKoBslUVKWLOhuVujVws1 Update(n26.Vector3 Center_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Vector3 Width_In, n35.LinearSpreadAlignment Alignment_In, n26.Vector3 Phase_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Int3 Count_In, out n5.Spread<n26.Vector3> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_OIyyfHxvlZoNUqzFR10TZz;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<n26.Vector3, n26.Vector3, n35.LinearSpreadAlignment, n26.Vector3, n26.Int3>, n2.ValueTuple<n5.Spread<n26.Vector3>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<n26.Vector3>()));
            }

            var inputs_3 = (Center_In, Width_In, Alignment_In, Phase_In, Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__UT3e6eGHob6MHJFq4By1uf>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __UT3e6eGHob6MHJFq4By1uf(__GetContext__(), n1.VLObject.NewIdentity())
                    {Builder_To_Fill = n24._Operations_.CreateDefault<n26.Vector3>()};
                }

                n5.SpreadBuilder<n26.Vector3> __auto_7 = state_6.Builder_To_Fill;
                bool Clear_Builder_8 = true;
                n32._Operations_.CreateGridSpread__3D(Center_In: Center_In, Width_In: Width_In, Alignment_In: Alignment_In, Phase_In: Phase_In, Builder_To_Fill_In: __auto_7, Clear_Builder_In: Clear_Builder_8, Count_In: Count_In, Output_Out: out n5.Spread<n26.Vector3> Output_9);
                outputs_4 = n2.ValueTuple.Create(Output_9);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_10 = outputs_4.Item1;
            Output_Out = __auto_10;
            n7.GridSpread__3D_GbKoBslUVKWLOhuVujVws1 that_11 = this;
            if (this.__GetContext__().IsImmutable)
                that_11 = manager_2 != this.__cache_OIyyfHxvlZoNUqzFR10TZz ? new GridSpread__3D_GbKoBslUVKWLOhuVujVws1(this)
                {__cache_OIyyfHxvlZoNUqzFR10TZz = manager_2} : that_11;
            else
            {
                this.__cache_OIyyfHxvlZoNUqzFR10TZz = manager_2;
            }

            return that_11;
        }

        public n7.GridSpread__3D_GbKoBslUVKWLOhuVujVws1 __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.GridSpread__3D_GbKoBslUVKWLOhuVujVws1 that_0 = this;
            this.__cache_OIyyfHxvlZoNUqzFR10TZz = null;
            return that_0;
        }

        public n7.GridSpread__3D_GbKoBslUVKWLOhuVujVws1 __CreateDefault__()
        {
            n7.GridSpread__3D_GbKoBslUVKWLOhuVujVws1 that_0 = this;
            this.__cache_OIyyfHxvlZoNUqzFR10TZz = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_OIyyfHxvlZoNUqzFR10TZz);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 273243U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "OIyyfHxvlZoNUqzFR10TZz", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<n26.Vector3, n26.Vector3, n35.LinearSpreadAlignment, n26.Vector3, n26.Int3>, n2.ValueTuple<n5.Spread<n26.Vector3>>> __cache_OIyyfHxvlZoNUqzFR10TZz = null;
        public GridSpread__3D_GbKoBslUVKWLOhuVujVws1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GridSpread__3D_GbKoBslUVKWLOhuVujVws1(GridSpread__3D_GbKoBslUVKWLOhuVujVws1 other): base(other)
        {
            this.__cache_OIyyfHxvlZoNUqzFR10TZz = other.__cache_OIyyfHxvlZoNUqzFR10TZz;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_OIyyfHxvlZoNUqzFR10TZz", in __cache_OIyyfHxvlZoNUqzFR10TZz));
        }

        internal GridSpread__3D_GbKoBslUVKWLOhuVujVws1 __WITH__(n42.Manager<n2.ValueTuple<n26.Vector3, n26.Vector3, n35.LinearSpreadAlignment, n26.Vector3, n26.Int3>, n2.ValueTuple<n5.Spread<n26.Vector3>>> __cache_OIyyfHxvlZoNUqzFR10TZz)
        {
            n7.GridSpread__3D_GbKoBslUVKWLOhuVujVws1 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_OIyyfHxvlZoNUqzFR10TZz != this.__cache_OIyyfHxvlZoNUqzFR10TZz ? new GridSpread__3D_GbKoBslUVKWLOhuVujVws1(this)
                {__cache_OIyyfHxvlZoNUqzFR10TZz = __cache_OIyyfHxvlZoNUqzFR10TZz} : that_0;
            else
            {
                this.__cache_OIyyfHxvlZoNUqzFR10TZz = __cache_OIyyfHxvlZoNUqzFR10TZz;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "UT3e6eGHob6MHJFq4By1uf", Name = "__UT3e6eGHob6MHJFq4By1uf")]
        [n2.SerializableAttribute]
        public class __UT3e6eGHob6MHJFq4By1uf : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(TracingId = 273266U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "LeSMww3zDelMoRgv0IaJt4", Name = "Builder To Fill")]
            public n5.SpreadBuilder<n26.Vector3> Builder_To_Fill;
            public __UT3e6eGHob6MHJFq4By1uf(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __UT3e6eGHob6MHJFq4By1uf(__UT3e6eGHob6MHJFq4By1uf other): base(other)
            {
                this.Builder_To_Fill = other.Builder_To_Fill;
            }

            protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Builder_To_Fill", in Builder_To_Fill));
            }

            internal __UT3e6eGHob6MHJFq4By1uf __WITH__(n5.SpreadBuilder<n26.Vector3> Builder_To_Fill)
            {
                __UT3e6eGHob6MHJFq4By1uf that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = Builder_To_Fill != this.Builder_To_Fill ? new __UT3e6eGHob6MHJFq4By1uf(this)
                    {Builder_To_Fill = Builder_To_Fill} : that_0;
                else
                {
                    this.Builder_To_Fill = Builder_To_Fill;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 273301U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "U4wxvrTtAK2MQs93CKjwhp", Name = "HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp")]
    [n2.SerializableAttribute]
    public class HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n7.HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp Create(n1.NodeContext Node_Context)
        {
            var instance = new HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n7.HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp CreateDefault()
        {
            var instance = new HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp Update(n26.Vector2 Center_In, [n4.SerializedDefaultValueAttribute("0.1", false)] float Radius_In, bool Even_Lower_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n26.Int2 Count_In, out n5.Spread<n26.Vector2> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_HqNwgRzhgsTM11ZGtp5czu;
            if (manager_2 is null)
            {
                manager_2 = new n42.Manager<n2.ValueTuple<n26.Vector2, float, bool, n26.Int2>, n2.ValueTuple<n5.Spread<n26.Vector2>>>(n2.ValueTuple.Create(n7._Operations_.CreateDefault<n26.Vector2>()));
            }

            var inputs_3 = (Center_In, Radius_In, Even_Lower_In, Count_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                n32._Operations_.CreateHexGridSpread__2D(Center_In: Center_In, Radius_In: Radius_In, Even_Lower_In: Even_Lower_In, Count_In: Count_In, Result_Out: out n5.Spread<n26.Vector2> Result_7);
                outputs_4 = n2.ValueTuple.Create(Result_7);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_8 = outputs_4.Item1;
            Output_Out = __auto_8;
            n7.HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = manager_2 != this.__cache_HqNwgRzhgsTM11ZGtp5czu ? new HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp(this)
                {__cache_HqNwgRzhgsTM11ZGtp5czu = manager_2} : that_9;
            else
            {
                this.__cache_HqNwgRzhgsTM11ZGtp5czu = manager_2;
            }

            return that_9;
        }

        public n7.HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n7.HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp that_0 = this;
            this.__cache_HqNwgRzhgsTM11ZGtp5czu = null;
            return that_0;
        }

        public n7.HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp __CreateDefault__()
        {
            n7.HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp that_0 = this;
            this.__cache_HqNwgRzhgsTM11ZGtp5czu = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_HqNwgRzhgsTM11ZGtp5czu);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 273305U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "HqNwgRzhgsTM11ZGtp5czu", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple<n26.Vector2, float, bool, n26.Int2>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_HqNwgRzhgsTM11ZGtp5czu = null;
        public HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp(HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp other): base(other)
        {
            this.__cache_HqNwgRzhgsTM11ZGtp5czu = other.__cache_HqNwgRzhgsTM11ZGtp5czu;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_HqNwgRzhgsTM11ZGtp5czu", in __cache_HqNwgRzhgsTM11ZGtp5czu));
        }

        internal HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp __WITH__(n42.Manager<n2.ValueTuple<n26.Vector2, float, bool, n26.Int2>, n2.ValueTuple<n5.Spread<n26.Vector2>>> __cache_HqNwgRzhgsTM11ZGtp5czu)
        {
            n7.HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_HqNwgRzhgsTM11ZGtp5czu != this.__cache_HqNwgRzhgsTM11ZGtp5czu ? new HexGridSpread__2D_U4wxvrTtAK2MQs93CKjwhp(this)
                {__cache_HqNwgRzhgsTM11ZGtp5czu = __cache_HqNwgRzhgsTM11ZGtp5czu} : that_0;
            else
            {
                this.__cache_HqNwgRzhgsTM11ZGtp5czu = __cache_HqNwgRzhgsTM11ZGtp5czu;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Add<T>(n5.Spread<T> Input_In, T Item_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Add<T>(input: Input_In, item: Item_In);
            Output_Out = Output_0;
            return;
        }

        public static void AddRange<T>(n5.Spread<T> Input_In, n6.IEnumerable<T> Items_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.AddRange<T>(input: Input_In, items: Items_In);
            Output_Out = Output_0;
            return;
        }

        public static void Clear<T>(n5.Spread<T> Input_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Clear<T>(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Concat<T>(n5.Spread<n6.IEnumerable<T>> Input_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Concat<T>(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void FromValue<T>(n5.Spread<T> Input_In, out n5.Spread<T> Result_Out)
        {
            Result_Out = Input_In;
            return;
        }

        public static void Contains<T>(n5.Spread<T> Input_In, T Item_In, out bool Result_Out)
        {
            var Result_0 = n5.Spread.Contains<T>(source: Input_In, item: Item_In);
            Result_Out = Result_0;
            return;
        }

        public static void Count<T>(n5.Spread<T> Input_In, out int Count_Out)
        {
            var Count_0 = Input_In.Count;
            Count_Out = Count_0;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static n5.Spread<T> CreateDefault<T>()
        {
            var Empty_0 = n5.Spread<T>.Empty;
            return Empty_0;
        }

        public static void Distinct<T>(n5.Spread<T> Input_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Distinct<T>(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Empty<T>(out n5.Spread<T> Empty_Out)
        {
            var Empty_0 = n5.Spread<T>.Empty;
            Empty_Out = Empty_0;
            return;
        }

        public static void Except<T>(n5.Spread<T> Input_In, n5.Spread<T> Input_2_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Except<T>(input: Input_In, input2: Input_2_In);
            Output_Out = Output_0;
            return;
        }

        public static void Factorial<T2, T, AdM>(T2 Input_In, out n5.Spread<T> Output_Out)
            where T2 : n6.IEnumerable<T> where AdM : struct, n19.IAdaptiveOne<T>, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorMulitply<T>
        {
            n5.Spread<T> __cp_VytzREvTiZWMS9f4GNlmOo = n7._Operations_.CreateDefault<T>();
            n5.Spread<n6.IEnumerable<T>> __pin_group_Input_In_Oggg1yzpx8UPxw4RTVTO8a = default(n5.Spread<n6.IEnumerable<T>>);
            var w_0 = default(AdM);
            int __pad_NGPaFGGDk9tQUnL7NeGnoW_1 = __slot_NGPaFGGDk9tQUnL7NeGnoW;
            w_0.One(One_Out: out T One_2);
            T accumulator_4 = One_2;
            var builder_9 = n4.CollectionBuilders.GetBuilder(__cp_VytzREvTiZWMS9f4GNlmOo, 16);
            n5.Spread<T> output_10;
            try
            {
                var i_6 = 0;
                foreach (var item_3 in Input_In)
                {
                    var splicer_5 = item_3;
                    var i_local_7 = i_6;
                    w_0.OperatorMulitply(Input_In: splicer_5, Input_2_In: accumulator_4, Output_Out: out T Output_8);
                    builder_9.Add(Output_8);
                    accumulator_4 = Output_8;
                    i_6++;
                }
            }
            finally
            {
                output_10 = builder_9.Commit();
            }

            n6.IEnumerable<T> Input_2_11 = (n6.IEnumerable<T>)output_10;
            w_0.CreateDefault(Output_Out: out T Output_12);
            n7._Operations_.Repeat<T>(Element_In: Output_12, Count_In: __pad_NGPaFGGDk9tQUnL7NeGnoW_1, Result_Out: out n5.Spread<T> Result_13);
            n6.IEnumerable<T> Input_14 = (n6.IEnumerable<T>)Result_13;
            var builder_15 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_Oggg1yzpx8UPxw4RTVTO8a, 2);
            builder_15.Add(Input_14);
            builder_15.Add(Input_2_11);
            var __pin_group_Input_In_Oggg1yzpx8UPxw4RTVTO8a_16 = builder_15.Commit();
            n7._Operations_.Concat<T>(Input_In: __pin_group_Input_In_Oggg1yzpx8UPxw4RTVTO8a_16, Output_Out: out n5.Spread<T> Output_17);
            Output_Out = Output_17;
            return;
        }

        public static void Flatten<T2, T>(T2 Input_In, out n5.Spread<T> Output_Out)
            where T2 : n6.IEnumerable<n6.IEnumerable<T>>
        {
            n6.IEnumerable<n6.IEnumerable<T>> Input_0 = (n6.IEnumerable<n6.IEnumerable<T>>)Input_In;
            var __fallback___1 = n1.ServiceRegistry.Current;
            n8._Operations_.Select_Many<n6.IEnumerable<T>, T>(Input_In: Input_0, Transformer_In: (n6.IEnumerable<T> Arg_1_In_3, int Arg_2_In_4) =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                return Arg_1_In_3;
            }

            , Output_Out: out n6.IEnumerable<T> Output_5);
            n7._Operations_.FromSequence<T>(Input_In: Output_5, Result_Out: out n5.Spread<T> Result_6);
            Output_Out = Result_6;
            return;
        }

        public static void GetItem<T>(n5.Spread<T> Input_In, int Index_In, out T Item_Out)
        {
            var Item_0 = Input_In[Index_In];
            Item_Out = Item_0;
            return;
        }

        public static void GetSlice<T>(n5.Spread<T> Input_In, T Default_Value_In, int Index_In, out T Result_Out)
        {
            var Result_0 = n23.SpreadNodes.GetSlice<T>(input: Input_In, defaultValue: Default_Value_In, index: Index_In);
            Result_Out = Result_0;
            return;
        }

        public static void GetSpread<T>(n5.Spread<T> Input_In, int Index_In, int Count_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.GetSpread<T>(input: Input_In, index: Index_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void IndexOf<T>(n5.Spread<T> Input_In, T Item_In, out int Result_Out)
        {
            var Result_0 = Input_In.IndexOf(item: Item_In);
            Result_Out = Result_0;
            return;
        }

        public static void Insert<T>(n5.Spread<T> Input_In, int Index_In, T Item_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Insert<T>(input: Input_In, index: Index_In, item: Item_In);
            Output_Out = Output_0;
            return;
        }

        public static void InsertSlice<T>(n5.Spread<T> Input_In, int Index_In, T Value_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.InsertSlice<T>(input: Input_In, index: Index_In, value: Value_In);
            Output_Out = Output_0;
            return;
        }

        public static void Integral<T2, T, AdM>(T2 Input_In, out n5.Spread<T> Output_Out)
            where T2 : n6.IEnumerable<T> where AdM : struct, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorPlus<T>
        {
            n5.Spread<T> __cp_PSA5RNpRZ84OqOsKpuetNp = n7._Operations_.CreateDefault<T>();
            n5.Spread<n6.IEnumerable<T>> __pin_group_Input_In_OyfPFQcA0g6L8gYKHCiqPf = default(n5.Spread<n6.IEnumerable<T>>);
            var w_0 = default(AdM);
            int __pad_RuXmzbeByV0O4Cewd5JS6t_1 = __slot_RuXmzbeByV0O4Cewd5JS6t;
            w_0.CreateDefault(Output_Out: out T Output_2);
            T accumulator_4 = Output_2;
            var builder_9 = n4.CollectionBuilders.GetBuilder(__cp_PSA5RNpRZ84OqOsKpuetNp, 16);
            n5.Spread<T> output_10;
            try
            {
                var i_6 = 0;
                foreach (var item_3 in Input_In)
                {
                    var splicer_5 = item_3;
                    var i_local_7 = i_6;
                    w_0.OperatorPlus(Input_In: splicer_5, Input_2_In: accumulator_4, Output_Out: out T Output_8);
                    builder_9.Add(Output_8);
                    accumulator_4 = Output_8;
                    i_6++;
                }
            }
            finally
            {
                output_10 = builder_9.Commit();
            }

            n6.IEnumerable<T> Input_2_11 = (n6.IEnumerable<T>)output_10;
            w_0.CreateDefault(Output_Out: out T Output_12);
            n7._Operations_.Repeat<T>(Element_In: Output_12, Count_In: __pad_RuXmzbeByV0O4Cewd5JS6t_1, Result_Out: out n5.Spread<T> Result_13);
            n6.IEnumerable<T> Input_14 = (n6.IEnumerable<T>)Result_13;
            var builder_15 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_OyfPFQcA0g6L8gYKHCiqPf, 2);
            builder_15.Add(Input_14);
            builder_15.Add(Input_2_11);
            var __pin_group_Input_In_OyfPFQcA0g6L8gYKHCiqPf_16 = builder_15.Commit();
            n7._Operations_.Concat<T>(Input_In: __pin_group_Input_In_OyfPFQcA0g6L8gYKHCiqPf_16, Output_Out: out n5.Spread<T> Output_17);
            Output_Out = Output_17;
            return;
        }

        public static void IsEmpty<T>(n5.Spread<T> Input_In, out bool Is_Empty_Out)
        {
            var Is_Empty_0 = Input_In.IsEmpty;
            Is_Empty_Out = Is_Empty_0;
            return;
        }

        public static void OrderBy<T, T2>(n5.Spread<T> Input_In, bool Descending_In, n2.Func<T, T2> Key_Selector_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.OrderBy<T, T2>(input: Input_In, descending: Descending_In, keySelector: Key_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void Pairwise<T, T2>(n5.Spread<T> Input_In, n2.Func<T, T, T2> Selector_In, out n5.Spread<T2> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Pairwise<T, T2>(input: Input_In, selector: Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void Select_Many<T, T2>(n5.Spread<T> Input_In, n2.Func<T, n6.IEnumerable<T2>> Transformer_In, out n5.Spread<T2> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Project<T, T2>(input: Input_In, transformer: Transformer_In);
            Output_Out = Output_0;
            return;
        }

        public static void RemoveAt<T>(n5.Spread<T> Input_In, int Index_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.RemoveAt<T>(input: Input_In, index: Index_In);
            Output_Out = Output_0;
            return;
        }

        public static void RemoveSliceAt<T>(n5.Spread<T> Input_In, int Index_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.RemoveSliceAt<T>(input: Input_In, index: Index_In);
            Output_Out = Output_0;
            return;
        }

        public static void Repeat<T>(T Element_In, int Count_In, out n5.Spread<T> Result_Out)
        {
            var Result_0 = n25.SpreadGenerators.Repeat<T>(element: Element_In, count: Count_In);
            Result_Out = Result_0;
            return;
        }

        public static void Resize<T>(n5.Spread<T> Input_In, int Size_In, n2.Func<T> Item_Factory_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Resize<T>(input: Input_In, size: Size_In, itemFactory: Item_Factory_In);
            Output_Out = Output_0;
            return;
        }

        public static void Reverse<T>(n5.Spread<T> Input_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Reverse<T>(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Select<T3, T, T2>(T3 Input_In, T2 Alive_Values_In, out n5.Spread<T> Output_Out)
            where T3 : n6.IEnumerable<T> where T2 : n6.IEnumerable<bool>
        {
            var Output_0 = n24._Operations_.CreateDefault<T>();
            n5.SpreadBuilder<T> accumulator_1 = Output_0;
            var enumerator_2 = Input_In.GetEnumerator();
            var enumerator_4 = Alive_Values_In.GetEnumerator();
            try
            {
                var i_6 = 0;
                while (enumerator_2.MoveNext() && enumerator_4.MoveNext())
                {
                    var splicer_3 = enumerator_2.Current;
                    var splicer_5 = enumerator_4.Current;
                    var i_local_7 = i_6;
                    var Output_8 = accumulator_1;
                    if (splicer_5)
                    {
                        n24._Operations_.Add<T>(Input_In: accumulator_1, Item_In: splicer_3, Output_Out: out Output_8);
                    }

                    accumulator_1 = Output_8;
                    i_6++;
                }
            }
            finally
            {
                enumerator_2.Dispose();
                enumerator_4.Dispose();
            }

            n24._Operations_.ToSpread<T>(Input_In: accumulator_1, Output_Out: out n5.SpreadBuilder<T> Output_9, Result_Out: out n5.Spread<T> Result_10);
            Output_Out = Result_10;
            return;
        }

        public static void SetCount<T, AdM>(n5.Spread<T> Input_In, int Count_In, out n5.Spread<T> Output_Out)
            where AdM : struct, n18.IAdaptiveCreateDefault<T>
        {
            n5.Spread<T> __cp_Q8vdfRtBpsPMuRi80mqk2n = n7._Operations_.CreateDefault<T>();
            var w_0 = default(AdM);
            var builder_5 = n4.CollectionBuilders.GetBuilder(__cp_Q8vdfRtBpsPMuRi80mqk2n, 16);
            n5.Spread<T> output_6;
            try
            {
                for (var i_1 = 0; i_1 < Count_In; i_1++)
                {
                    var i_local_2 = i_1;
                    w_0.CreateDefault(Output_Out: out T Output_3);
                    n7._Operations_.GetSlice<T>(Input_In: Input_In, Default_Value_In: Output_3, Index_In: i_local_2, Result_Out: out T Result_4);
                    builder_5.Add(Result_4);
                }
            }
            finally
            {
                output_6 = builder_5.Commit();
            }

            Output_Out = output_6;
            return;
        }

        public static void SetItem<T>(n5.Spread<T> Input_In, int Index_In, T Item_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.SetItem<T>(input: Input_In, index: Index_In, item: Item_In);
            Output_Out = Output_0;
            return;
        }

        public static void SetSlice<T>(n5.Spread<T> Input_In, T Value_In, int Index_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.SetSlice<T>(input: Input_In, value: Value_In, index: Index_In);
            Output_Out = Output_0;
            return;
        }

        public static void Skip<T>(n5.Spread<T> Input_In, int Count_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Skip<T>(input: Input_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void SkipLast<T>(n5.Spread<T> Input_In, int Count_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.SkipLast<T>(input: Input_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void Sort<T>(n5.Spread<T> Input_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Sort<T>(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Sort_Comparer<T>(n5.Spread<T> Input_In, n2.Func<T, T, int> Comparer_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Sort<T>(input: Input_In, comparer: Comparer_In);
            Output_Out = Output_0;
            return;
        }

        public static void SplitAt<T>(n5.Spread<T> Input_In, int Index_In, out n5.Spread<T> Output_Out, out n5.Spread<T> Output_2_Out)
        {
            n23.SpreadNodes.SplitAt<T>(input: Input_In, index: Index_In, output: out n5.Spread<T> Output_0, output2: out n5.Spread<T> Output_2_1);
            Output_Out = Output_0;
            Output_2_Out = Output_2_1;
            return;
        }

        public static void SplitFirst<T>(n5.Spread<T> Input_In, T Default_Value_In, out n5.Spread<T> Output_Out, out T Result_Out)
        {
            n23.SpreadNodes.SplitFirst<T>(input: Input_In, defaultValue: Default_Value_In, output: out n5.Spread<T> Output_0, result: out T Result_1);
            Output_Out = Output_0;
            Result_Out = Result_1;
            return;
        }

        public static void SplitLast<T>(n5.Spread<T> Input_In, T Default_Value_In, out n5.Spread<T> Output_Out, out T Result_Out)
        {
            n23.SpreadNodes.SplitLast<T>(input: Input_In, defaultValue: Default_Value_In, output: out n5.Spread<T> Output_0, result: out T Result_1);
            Output_Out = Output_0;
            Result_Out = Result_1;
            return;
        }

        public static void Take<T>(n5.Spread<T> Input_In, int Count_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Take<T>(input: Input_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void TakeLast<T>(n5.Spread<T> Input_In, int Count_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.TakeLast<T>(input: Input_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void ToBuilder<T>(n5.Spread<T> Input_In, out n5.SpreadBuilder<T> Result_Out)
        {
            var Result_0 = Input_In.ToBuilder();
            Result_Out = Result_0;
            return;
        }

        public static void ToSpreadOfBuilder<T2, T>(T2 Inputs_In, out n5.Spread<n5.SpreadBuilder<T>> Outputs_Out)
            where T2 : n6.IEnumerable<n5.Spread<T>>
        {
            n5.Spread<n5.SpreadBuilder<T>> __cp_P9tBhpih5n7N4eK4kRTkjE = n7._Operations_.CreateDefault<n5.SpreadBuilder<T>>();
            var builder_5 = n4.CollectionBuilders.GetBuilder(__cp_P9tBhpih5n7N4eK4kRTkjE, 16);
            n5.Spread<n5.SpreadBuilder<T>> output_6;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in Inputs_In)
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    n7._Operations_.ToBuilder<T>(Input_In: splicer_1, Result_Out: out n5.SpreadBuilder<T> Result_4);
                    builder_5.Add(Result_4);
                    i_2++;
                }
            }
            finally
            {
                output_6 = builder_5.Commit();
            }

            Outputs_Out = output_6;
            return;
        }

        public static void ToSpreadOfSpread<T2, T>(T2 Inputs_In, out n5.Spread<n5.Spread<T>> Outputs_Out)
            where T2 : n6.IEnumerable<n5.SpreadBuilder<T>>
        {
            n5.Spread<n5.Spread<T>> __cp_QChaUgOzD1iO9cpUgHCVkp = n7._Operations_.CreateDefault<n5.Spread<T>>();
            var builder_6 = n4.CollectionBuilders.GetBuilder(__cp_QChaUgOzD1iO9cpUgHCVkp, 16);
            n5.Spread<n5.Spread<T>> output_7;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in Inputs_In)
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    n24._Operations_.ToSpread<T>(Input_In: splicer_1, Output_Out: out n5.SpreadBuilder<T> Output_4, Result_Out: out n5.Spread<T> Result_5);
                    builder_6.Add(Result_5);
                    i_2++;
                }
            }
            finally
            {
                output_7 = builder_6.Commit();
            }

            Outputs_Out = output_7;
            return;
        }

        public static void Union<T>(n5.Spread<T> Input_In, n5.Spread<T> Input_2_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Union<T>(input: Input_In, input2: Input_2_In);
            Output_Out = Output_0;
            return;
        }

        public static void UnZip<T>(n5.Spread<T> Input_In, out n5.Spread<T> Output_Out, out n5.Spread<T> Output_2_Out)
        {
            n23.SpreadNodes.UnZip<T>(input: Input_In, output: out n5.Spread<T> Output_0, output2: out n5.Spread<T> Output_2_1);
            Output_Out = Output_0;
            Output_2_Out = Output_2_1;
            return;
        }

        public static void ValuesToVectors__2D(n6.IEnumerable<float> Values_In, out n5.Spread<n26.Vector2> Result_Out)
        {
            var Result_0 = n25.ValuesToVectorsNodes.ValuesToVectors2D(values: Values_In);
            Result_Out = Result_0;
            return;
        }

        public static void ValuesToVectors__3D(n6.IEnumerable<float> Values_In, out n5.Spread<n26.Vector3> Result_Out)
        {
            var Result_0 = n25.ValuesToVectorsNodes.ValuesToVectors3D(values: Values_In);
            Result_Out = Result_0;
            return;
        }

        public static void ValuesToVectors__4D(n6.IEnumerable<float> Values_In, out n5.Spread<n26.Vector4> Result_Out)
        {
            var Result_0 = n25.ValuesToVectorsNodes.ValuesToVectors4D(values: Values_In);
            Result_Out = Result_0;
            return;
        }

        public static void VectorsToValues__2D<T>(T Vectors_In, out n5.Spread<float> Output_Out)
            where T : n6.IEnumerable<n26.Vector2>
        {
            n5.SpreadBuilder<float> Input_0 = n24._Operations_.CreateDefault<float>();
            n24._Operations_.VectorsToValues__2D<T>(Input_In: Input_0, Vectors_In: Vectors_In, Output_Out: out n5.SpreadBuilder<float> Output_1);
            n24._Operations_.ToSpread<float>(Input_In: Output_1, Output_Out: out n5.SpreadBuilder<float> Output_2, Result_Out: out n5.Spread<float> Result_3);
            Output_Out = Result_3;
            return;
        }

        public static void VectorsToValues__3D<T>(T Vectors_In, out n5.Spread<float> Output_Out)
            where T : n6.IEnumerable<n26.Vector3>
        {
            n5.SpreadBuilder<float> Input_0 = n24._Operations_.CreateDefault<float>();
            n24._Operations_.VectorsToValues__3D<T>(Input_In: Input_0, Vectors_In: Vectors_In, Output_Out: out n5.SpreadBuilder<float> Output_1);
            n24._Operations_.ToSpread<float>(Input_In: Output_1, Output_Out: out n5.SpreadBuilder<float> Output_2, Result_Out: out n5.Spread<float> Result_3);
            Output_Out = Result_3;
            return;
        }

        public static void VectorsToValues__4D<T>(T Vectors_In, out n5.Spread<float> Output_Out)
            where T : n6.IEnumerable<n26.Vector4>
        {
            n5.SpreadBuilder<float> Input_0 = n24._Operations_.CreateDefault<float>();
            n24._Operations_.VectorsToValues__4D<T>(Input_In: Input_0, Vectors_In: Vectors_In, Output_Out: out n5.SpreadBuilder<float> Output_1);
            n24._Operations_.ToSpread<float>(Input_In: Output_1, Output_Out: out n5.SpreadBuilder<float> Output_2, Result_Out: out n5.Spread<float> Result_3);
            Output_Out = Result_3;
            return;
        }

        public static void Where<T>(n5.Spread<T> Input_In, n2.Func<T, int, bool> Predicate_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Where<T>(input: Input_In, predicate: Predicate_In);
            Output_Out = Output_0;
            return;
        }

        public static void Zip<T>(n5.Spread<T> Input_In, n5.Spread<T> Input_2_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Use_Min_Count_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.Zip<T>(input: Input_In, input2: Input_2_In, useMinCount: Use_Min_Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void ToImage<T>(n5.Spread<T> Input_In, int Width_In, int Height_In, n41.PixelFormat Format_In, bool Is_Premultiplied_Alpha_In, string Original_Format_In, out n41.IImage Result_Out)
            where T : struct
        {
            var Result_0 = n41.ImageExtensions.ToImage<T>(data: Input_In, width: Width_In, height: Height_In, format: Format_In, isPremultipliedAlpha: Is_Premultiplied_Alpha_In, originalFormat: Original_Format_In);
            Result_Out = Result_0;
            return;
        }

        public static void AvoidEmpty<T>(n5.Spread<T> Input_In, n5.Spread<T> Default_Spread_In, out n5.Spread<T> Output_Out, out bool Is_Empty_Out)
        {
            n7._Operations_.Count<T>(Input_In: Input_In, Count_Out: out int Count_0);
            int Input_2_1 = 0;
            var Result_2 = Count_0 <= Input_2_1;
            n5.Spread<T> __auto_3;
            if (Result_2)
            {
                __auto_3 = Default_Spread_In;
            }
            else
            {
                __auto_3 = Input_In;
            }

            Output_Out = __auto_3;
            Is_Empty_Out = Result_2;
            return;
        }

        public static void AvoidEmpty_Element<T>(n5.Spread<T> Input_In, T Default_Element_In, out n5.Spread<T> Output_Out, out bool Is_Empty_Out)
        {
            n7._Operations_.Count<T>(Input_In: Input_In, Count_Out: out int Count_0);
            int Input_2_1 = 0;
            var Result_2 = Count_0 <= Input_2_1;
            n5.Spread<T> __auto_3;
            if (Result_2)
            {
                n5.Spread<T> __pin_group_Input_In_R3nwBzFiJlNPIuij3t1Lab = default(n5.Spread<T>);
                var builder_4 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_R3nwBzFiJlNPIuij3t1Lab, 1);
                builder_4.Add(Default_Element_In);
                var __pin_group_Input_In_R3nwBzFiJlNPIuij3t1Lab_5 = builder_4.Commit();
                n7._Operations_.Cons<T>(Input_In: __pin_group_Input_In_R3nwBzFiJlNPIuij3t1Lab_5, Result_Out: out n5.Spread<T> Result_6);
                __auto_3 = Result_6;
            }
            else
            {
                __auto_3 = Input_In;
            }

            Output_Out = __auto_3;
            Is_Empty_Out = Result_2;
            return;
        }

        public static void AvoidEmpty_ElementCreator<T>(n5.Spread<T> Input_In, n2.Func<T> Default_Element_Creator_In, out n5.Spread<T> Output_Out, out bool Is_Empty_Out)
        {
            n7._Operations_.Count<T>(Input_In: Input_In, Count_Out: out int Count_0);
            int Input_2_1 = 0;
            var Result_2 = Count_0 <= Input_2_1;
            n5.Spread<T> __auto_3;
            if (Result_2)
            {
                n5.Spread<T> __pin_group_Input_In_AH34NQvcwNXMUkoE8vLY8J = default(n5.Spread<T>);
                n50._Operations_.Invoke<T>(Input_In: Default_Element_Creator_In, Result_Out: out T Result_4);
                var builder_5 = n4.CollectionBuilders.GetBuilder(__pin_group_Input_In_AH34NQvcwNXMUkoE8vLY8J, 1);
                builder_5.Add(Result_4);
                var __pin_group_Input_In_AH34NQvcwNXMUkoE8vLY8J_6 = builder_5.Commit();
                n7._Operations_.Cons<T>(Input_In: __pin_group_Input_In_AH34NQvcwNXMUkoE8vLY8J_6, Result_Out: out n5.Spread<T> Result_7);
                __auto_3 = Result_7;
            }
            else
            {
                __auto_3 = Input_In;
            }

            Output_Out = __auto_3;
            Is_Empty_Out = Result_2;
            return;
        }

        public static void AvoidEmpty_Creator<T>(n5.Spread<T> Input_In, n2.Func<n5.Spread<T>> Default_Spread_Creator_In, out n5.Spread<T> Output_Out, out bool Is_Empty_Out)
        {
            n7._Operations_.Count<T>(Input_In: Input_In, Count_Out: out int Count_0);
            int Input_2_1 = 0;
            var Result_2 = Count_0 <= Input_2_1;
            n5.Spread<T> __auto_3;
            if (Result_2)
            {
                n50._Operations_.Invoke<n5.Spread<T>>(Input_In: Default_Spread_Creator_In, Result_Out: out n5.Spread<T> Result_4);
                __auto_3 = Result_4;
            }
            else
            {
                __auto_3 = Input_In;
            }

            Output_Out = __auto_3;
            Is_Empty_Out = Result_2;
            return;
        }

        public static void FromSequence<T>(n6.IEnumerable<T> Input_In, out n5.Spread<T> Result_Out)
        {
            var Result_0 = n5.Spread.ToSpread<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Decons<T>(n5.Spread<T> Input_In, out n5.Spread<T> Result_Out)
        {
            Result_Out = Input_In;
            return;
        }

        public static void Cons<T>(n5.Spread<T> Input_In, out n5.Spread<T> Result_Out)
        {
            Result_Out = Input_In;
            return;
        }

        public static void RemoveAll<T>(n5.Spread<T> Input_In, n2.Func<T, bool> Match_In, out n5.Spread<T> Output_Out)
        {
            var Output_0 = n23.SpreadNodes.RemoveAll<T>(input: Input_In, match: Match_In);
            Output_Out = Output_0;
            return;
        }

        public static void GroupBy_Length<T>(n5.Spread<T> Input_In, [n4.SerializedDefaultValueAttribute("1", false)] int Item_Count_In, out n5.Spread<n5.Spread<T>> Output_Out, out n5.Spread<T> Remainder_Out)
        {
            n5.Spread<n5.Spread<T>> __cp_CG1GGRC4aZVMc2FBpAkznu = n7._Operations_.CreateDefault<n5.Spread<T>>();
            n7._Operations_.Count<T>(Input_In: Input_In, Count_Out: out int Count_0);
            var Output_2 = n2.Math.DivRem(a: Count_0, b: Item_Count_In, result: out int Result_1);
            var builder_7 = n4.CollectionBuilders.GetBuilder(__cp_CG1GGRC4aZVMc2FBpAkznu, 16);
            n5.Spread<n5.Spread<T>> output_8;
            try
            {
                for (var i_3 = 0; i_3 < Output_2; i_3++)
                {
                    var i_local_4 = i_3;
                    var Output_5 = i_local_4 * Item_Count_In;
                    n7._Operations_.GetSpread<T>(Input_In: Input_In, Index_In: Output_5, Count_In: Item_Count_In, Output_Out: out n5.Spread<T> Output_6);
                    builder_7.Add(Output_6);
                }
            }
            finally
            {
                output_8 = builder_7.Commit();
            }

            n7._Operations_.TakeLast<T>(Input_In: Input_In, Count_In: Result_1, Output_Out: out n5.Spread<T> Output_9);
            Output_Out = output_8;
            Remainder_Out = Output_9;
            return;
        }

        public static void GroupBy_Count<T>(n5.Spread<T> Input_In, [n4.SerializedDefaultValueAttribute("1", false)] int Count_In, out n5.Spread<n5.Spread<T>> Output_Out, out n5.Spread<T> Remainder_Out)
        {
            n5.Spread<n5.Spread<T>> __cp_NFveb8IPXTHMlMRHp0DBIl = n7._Operations_.CreateDefault<n5.Spread<T>>();
            n7._Operations_.Count<T>(Input_In: Input_In, Count_Out: out int Count_0);
            var Output_2 = n2.Math.DivRem(a: Count_0, b: Count_In, result: out int Result_1);
            var builder_7 = n4.CollectionBuilders.GetBuilder(__cp_NFveb8IPXTHMlMRHp0DBIl, 16);
            n5.Spread<n5.Spread<T>> output_8;
            try
            {
                for (var i_3 = 0; i_3 < Count_In; i_3++)
                {
                    var i_local_4 = i_3;
                    var Output_5 = i_local_4 * Output_2;
                    n7._Operations_.GetSpread<T>(Input_In: Input_In, Index_In: Output_5, Count_In: Output_2, Output_Out: out n5.Spread<T> Output_6);
                    builder_7.Add(Output_6);
                }
            }
            finally
            {
                output_8 = builder_7.Commit();
            }

            n7._Operations_.TakeLast<T>(Input_In: Input_In, Count_In: Result_1, Output_Out: out n5.Spread<T> Output_9);
            Output_Out = output_8;
            Remainder_Out = Output_9;
            return;
        }

        [n1.ElementAttribute(TracingId = 266344U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "NGPaFGGDk9tQUnL7NeGnoW", Name = "__slot_NGPaFGGDk9tQUnL7NeGnoW")]
        public static int __slot_NGPaFGGDk9tQUnL7NeGnoW = 1;
        [n1.ElementAttribute(TracingId = 266477U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "RuXmzbeByV0O4Cewd5JS6t", Name = "__slot_RuXmzbeByV0O4Cewd5JS6t")]
        public static int __slot_RuXmzbeByV0O4Cewd5JS6t = 1;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Common.KeyValuePair
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Split<T2, T>(n6.KeyValuePair<T2, T> Input_In, out T2 Key_Out, out T Value_Out)
        {
            var Key_0 = Input_In.Key;
            var Value_1 = Input_In.Value;
            Key_Out = Key_0;
            Value_Out = Value_1;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static n6.KeyValuePair<T, T2> CreateDefault<T, T2, AdM>()
            where AdM : struct, n18.IAdaptiveCreateDefault<T2>, n18.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(Output_Out: out T Output_1);
            w_0.CreateDefault(Output_Out: out T2 Output_2);
            var Output_3 = new n6.KeyValuePair<T, T2>(key: Output_1, value: Output_2);
            return Output_3;
        }
    }
}

namespace _VL_Collections_.Collections.Common.Advanced
{
    [n1.ElementAttribute(TracingId = 268965U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "IhQaHLIXJ1hLTpwql9lQg0", Name = "CustomEqualityComparer_C")]
    [n2.SerializableAttribute]
    public class CustomEqualityComparer_C<T> : n1.VLObject, n6.IEqualityComparer<T>, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n51.CustomEqualityComparer_C<T> Create(n1.NodeContext Node_Context, n2.Func<T, T, bool> Equals_In, n2.Func<T, int> HashCode_In)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new CustomEqualityComparer_C<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Equals_In, HashCode_In);
        }

        [n4.CreateDefaultAttribute]
        public static n51.CustomEqualityComparer_C<T> CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new CustomEqualityComparer_C<T>(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n51.CustomEqualityComparer_C<T> Equals_(T X_In, T Y_In, out bool Result_Out)
        {
            n2.Func<T, T, bool> __auto_0 = this.Equals_Delegate;
            n47._Operations_.Invoke<T, T, bool>(Input_In: __auto_0, Arg_1_In: X_In, Arg_2_In: Y_In, Result_Out: out bool Result_1);
            Result_Out = Result_1;
            return this;
        }

        public n51.CustomEqualityComparer_C<T> GetHashCode_(T Obj_In, out int Result_Out)
        {
            n2.Func<T, int> __auto_0 = this.HashCode_Delegate;
            n17._Operations_.Invoke<T, int>(Input_In: __auto_0, Arg_In: Obj_In, Result_Out: out int Result_1);
            Result_Out = Result_1;
            return this;
        }

        public n51.CustomEqualityComparer_C<T> Compare()
        {
            return this;
        }

        public n51.CustomEqualityComparer_C<T> __Create__(n1.NodeContext Node_Context, n2.Func<T, T, bool> Equals_In, n2.Func<T, int> HashCode_In)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Equals_Delegate = n47._Operations_.CreateDefault<T, T, bool, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>();
            this.HashCode_Delegate = n17._Operations_.CreateDefault<T, int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>();
            this.Equals_Delegate = Equals_In;
            n2.Func<T, T, bool> __auto_0 = Equals_In;
            this.HashCode_Delegate = HashCode_In;
            n2.Func<T, int> __auto_1 = HashCode_In;
            return this;
        }

        public n51.CustomEqualityComparer_C<T> __CreateDefault__()
        {
            this.Equals_Delegate = n47._Operations_.CreateDefault<T, T, bool, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>();
            this.HashCode_Delegate = n17._Operations_.CreateDefault<T, int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>();
            return this;
        }

        public void Dispose()
        {
            return;
        }

        bool n6.IEqualityComparer<T>.Equals(T x, T y)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Equals_(x, y, out bool out_Result_Out);
            return out_Result_Out;
        }

        int n6.IEqualityComparer<T>.GetHashCode(T obj)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetHashCode_(obj, out int out_Result_Out);
            return out_Result_Out;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 268974U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "OoOQoc3SOLFPJBkuaqCii3", Name = "Equals Delegate")]
        public n2.Func<T, T, bool> Equals_Delegate;
        [n1.ElementAttribute(TracingId = 268976U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "KLG0uQRh05dO8iJOaTGStg", Name = "HashCode Delegate")]
        public n2.Func<T, int> HashCode_Delegate;
        public CustomEqualityComparer_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CustomEqualityComparer_C(CustomEqualityComparer_C<T> other): base(other)
        {
            this.Equals_Delegate = other.Equals_Delegate;
            this.HashCode_Delegate = other.HashCode_Delegate;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Equals_Delegate", in Equals_Delegate), n1.CompilationHelper.GetValueOrExisting(values, "HashCode_Delegate", in HashCode_Delegate));
        }

        internal CustomEqualityComparer_C<T> __WITH__(n2.Func<T, T, bool> Equals_Delegate, n2.Func<T, int> HashCode_Delegate)
        {
            n51.CustomEqualityComparer_C<T> that_0 = this;
            this.Equals_Delegate = Equals_Delegate;
            this.HashCode_Delegate = HashCode_Delegate;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 269020U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "UukD261h7BQMFmNeUcyYb4", Name = "CustomComparer_C")]
    [n2.SerializableAttribute]
    public class CustomComparer_C<T> : n1.VLObject, n6.IComparer<T>, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n51.CustomComparer_C<T> Create(n1.NodeContext Node_Context, n2.Func<T, T, int> Compare_In)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new CustomComparer_C<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Compare_In);
        }

        [n4.CreateDefaultAttribute]
        public static n51.CustomComparer_C<T> CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new CustomComparer_C<T>(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n51.CustomComparer_C<T> Compare_(T X_In, T Y_In, out int Result_Out)
        {
            n2.Func<T, T, int> __auto_0 = this.Compare_Delegate;
            n47._Operations_.Invoke<T, T, int>(Input_In: __auto_0, Arg_1_In: X_In, Arg_2_In: Y_In, Result_Out: out int Result_1);
            Result_Out = Result_1;
            return this;
        }

        public n51.CustomComparer_C<T> __Create__(n1.NodeContext Node_Context, n2.Func<T, T, int> Compare_In)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Compare_Delegate = n47._Operations_.CreateDefault<T, T, int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>();
            this.Compare_Delegate = Compare_In;
            n2.Func<T, T, int> __auto_0 = Compare_In;
            return this;
        }

        public n51.CustomComparer_C<T> __CreateDefault__()
        {
            this.Compare_Delegate = n47._Operations_.CreateDefault<T, T, int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>();
            return this;
        }

        public void Dispose()
        {
            return;
        }

        int n6.IComparer<T>.Compare(T x, T y)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Compare_(x, y, out int out_Result_Out);
            return out_Result_Out;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 269027U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "IZRhBk1ZEm3NeU8HFAGMYE", Name = "Compare Delegate")]
        public n2.Func<T, T, int> Compare_Delegate;
        public CustomComparer_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CustomComparer_C(CustomComparer_C<T> other): base(other)
        {
            this.Compare_Delegate = other.Compare_Delegate;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Compare_Delegate", in Compare_Delegate));
        }

        internal CustomComparer_C<T> __WITH__(n2.Func<T, T, int> Compare_Delegate)
        {
            n51.CustomComparer_C<T> that_0 = this;
            this.Compare_Delegate = Compare_Delegate;
            return that_0;
        }
    }
}

namespace _VL_Collections_.Collections.Sequence
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void All<T>(n6.IEnumerable<T> Input_In, n2.Func<T, bool> Predicate_In, out bool Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.All<T>(input: Input_In, predicate: Predicate_In);
            Result_Out = Result_0;
            return;
        }

        public static void AND_Spectral(n6.IEnumerable<bool> Input_In, out bool Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.AND(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Any<T>(n6.IEnumerable<T> Input_In, out bool Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.Any<T>(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Any_Predicate<T>(n6.IEnumerable<T> Input_In, n2.Func<T, bool> Predicate_In, out bool Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.Any<T>(input: Input_In, predicate: Predicate_In);
            Result_Out = Result_0;
            return;
        }

        public static void Average<T2, T, AdM>(T2 Input_In, out T Result_Out)
            where T2 : n6.IEnumerable<T> where AdM : struct, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorPlus<T>, n19.IAdaptiveOperatorDivide_Scale<T>
        {
            var w_0 = default(AdM);
            int __pad_AVHKqZ1HxdCMkwblfNESJG_1 = __slot_AVHKqZ1HxdCMkwblfNESJG;
            w_0.CreateDefault(Output_Out: out T Output_2);
            T accumulator_4 = Output_2;
            int accumulator_5 = 0;
            var i_7 = 0;
            foreach (var item_3 in Input_In)
            {
                var splicer_6 = item_3;
                var i_local_8 = i_7;
                w_0.OperatorPlus(Input_In: splicer_6, Input_2_In: accumulator_4, Output_Out: out T Output_9);
                var Output_10 = accumulator_5 + __pad_AVHKqZ1HxdCMkwblfNESJG_1;
                accumulator_4 = Output_9;
                accumulator_5 = Output_10;
                i_7++;
            }

            float Scalar_11 = (float)accumulator_5;
            w_0.OperatorDivide_Scale(Input_In: accumulator_4, Scalar_In: Scalar_11, Output_Out: out T Output_12);
            Result_Out = Output_12;
            return;
        }

        public static void Average_Selector<T3, T2, T, AdM>(T3 Input_In, n2.Func<T2, T> Selector_In, out T Result_Out)
            where T3 : n6.IEnumerable<T2> where AdM : struct, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorPlus<T>, n19.IAdaptiveOperatorDivide_Scale<T>
        {
            var w_0 = default(AdM);
            int __pad_H4xl3WlQWS9MV59AI9Syxx_1 = __slot_H4xl3WlQWS9MV59AI9Syxx;
            w_0.CreateDefault(Output_Out: out T Output_2);
            T accumulator_4 = Output_2;
            int accumulator_5 = 0;
            var i_7 = 0;
            foreach (var item_3 in Input_In)
            {
                var splicer_6 = item_3;
                var i_local_8 = i_7;
                n17._Operations_.Invoke<T2, T>(Input_In: Selector_In, Arg_In: splicer_6, Result_Out: out T Result_9);
                w_0.OperatorPlus(Input_In: Result_9, Input_2_In: accumulator_4, Output_Out: out T Output_10);
                var Output_11 = accumulator_5 + __pad_H4xl3WlQWS9MV59AI9Syxx_1;
                accumulator_4 = Output_10;
                accumulator_5 = Output_11;
                i_7++;
            }

            float Scalar_12 = (float)accumulator_5;
            w_0.OperatorDivide_Scale(Input_In: accumulator_4, Scalar_In: Scalar_12, Output_Out: out T Output_13);
            Result_Out = Output_13;
            return;
        }

        public static void Contains<T2, T, AdM>(T2 Input_In, T Value_In, out bool Result_Out)
            where T2 : n6.IEnumerable<T> where AdM : struct, n19.IAdaptiveOperatorEquals<T>
        {
            var w_0 = default(AdM);
            var breakOutput_6 = false;
            var i_3 = 0;
            foreach (var item_1 in Input_In)
            {
                var splicer_2 = item_1;
                var i_local_4 = i_3;
                w_0.OperatorEquals(Input_In: splicer_2, Input_2_In: Value_In, Result_Out: out bool Result_5);
                if (Result_5)
                {
                    breakOutput_6 = Result_5;
                    break;
                }

                i_3++;
            }

            Result_Out = breakOutput_6;
            return;
        }

        public static void Contains_Selector<T4, T2, T3, T, AdM>(T4 Input_In, T3 Value_In, n2.Func<T3, T> Selector_In, out bool Result_Out)
            where T4 : n6.IEnumerable<T2> where AdM : struct, n19.IAdaptiveOperatorEquals<T>, n18.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n17._Operations_.Invoke<T3, T>(Input_In: Selector_In, Arg_In: Value_In, Result_Out: out T Result_1);
            var accumulator_9 = false;
            var i_4 = 0;
            foreach (var item_2 in Input_In)
            {
                var splicer_3 = item_2;
                var i_local_5 = i_4;
                var Output_6 = n17._Operations_.CreateDefault<T2, T, AdM>();
                n17._Operations_.Invoke<T2, T>(Input_In: Output_6, Arg_In: splicer_3, Result_Out: out T Result_7);
                w_0.OperatorEquals(Input_In: Result_7, Input_2_In: Result_1, Result_Out: out bool Result_8);
                accumulator_9 = Result_8;
                if (Result_8)
                {
                    break;
                }

                i_4++;
            }

            Result_Out = accumulator_9;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static n6.IEnumerable<T> CreateDefault<T>()
        {
            var Result_0 = n23.EnumerableNodes.Empty<T>();
            return Result_0;
        }

        public static void FirstOrDefault<T2, T>(T2 Input_In, T Default_Value_In, out T2 Output_Out, out T Result_Out)
            where T2 : n6.IEnumerable<T>
        {
            var Output_1 = n23.EnumerableNodes.FirstOrDefault<T, T2>(input: Input_In, defaultValue: Default_Value_In, result: out T Result_0);
            Output_Out = Output_1;
            Result_Out = Result_0;
            return;
        }

        public static void FirstOrDefault_Predicate<T2, T>(T2 Input_In, T Default_Value_In, n2.Func<T, bool> Predicate_In, out T2 Output_Out, out T Result_Out)
            where T2 : n6.IEnumerable<T>
        {
            var Output_1 = n23.EnumerableNodes.FirstOrDefault<T, T2>(input: Input_In, defaultValue: Default_Value_In, predicate: Predicate_In, result: out T Result_0);
            Output_Out = Output_1;
            Result_Out = Result_0;
            return;
        }

        public static void GetPairedSpreadsSwapped<T>(n6.IEnumerable<T> Input_In, out n5.Spread<T> Ouput_Out, out n5.Spread<T> Output_2_Out)
        {
            n23.EnumerableNodes.GetPairedSpreadsSwapped<T>(input: Input_In, ouput: out n5.Spread<T> Ouput_0, output2: out n5.Spread<T> Output_2_1);
            Ouput_Out = Ouput_0;
            Output_2_Out = Output_2_1;
            return;
        }

        public static void LastOrDefault<T2, T>(T2 Input_In, T Default_Value_In, out T2 Output_Out, out T Result_Out)
            where T2 : n6.IEnumerable<T>
        {
            var Output_1 = n23.EnumerableNodes.LastOrDefault<T, T2>(input: Input_In, defaultValue: Default_Value_In, result: out T Result_0);
            Output_Out = Output_1;
            Result_Out = Result_0;
            return;
        }

        public static void LastOrDefault_Predicate<T2, T>(T2 Input_In, T Default_Value_In, n2.Func<T, bool> Predicate_In, out T2 Output_Out, out T Result_Out)
            where T2 : n6.IEnumerable<T>
        {
            var Output_1 = n23.EnumerableNodes.LastOrDefault<T, T2>(input: Input_In, defaultValue: Default_Value_In, predicate: Predicate_In, result: out T Result_0);
            Output_Out = Output_1;
            Result_Out = Result_0;
            return;
        }

        public static void Max<T2, T, AdM>(T2 Input_In, out T Result_Out)
            where T2 : n6.IEnumerable<T> where AdM : struct, n19.IAdaptiveOperatorGreater<T>, n18.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(Output_Out: out T Output_1);
            n8._Operations_.FirstOrDefault<T2, T>(Input_In: Input_In, Default_Value_In: Output_1, Output_Out: out T2 Output_2, Result_Out: out T Result_3);
            T accumulator_5 = Result_3;
            var i_7 = 0;
            foreach (var item_4 in Output_2)
            {
                var splicer_6 = item_4;
                var i_local_8 = i_7;
                n13._Operations_.Max<T, AdM>(Input_In: splicer_6, Input_2_In: accumulator_5, Output_Out: out T Output_9);
                accumulator_5 = Output_9;
                i_7++;
            }

            Result_Out = accumulator_5;
            return;
        }

        public static void Max_Selector<T3, T2, T, AdM>(T3 Input_In, n2.Func<T2, T> Selector_In, out T Result_Out)
            where T3 : n6.IEnumerable<T2> where AdM : struct, n19.IAdaptiveOperatorGreater<T>, n18.IAdaptiveCreateDefault<T>
        {
            n5.Spread<T> __cp_EkmSBA3FCLOPHw5VucP6AO = n7._Operations_.CreateDefault<T>();
            var w_0 = default(AdM);
            var builder_6 = n4.CollectionBuilders.GetBuilder(__cp_EkmSBA3FCLOPHw5VucP6AO, 16);
            n5.Spread<T> output_7;
            try
            {
                var i_3 = 0;
                foreach (var item_1 in Input_In)
                {
                    var splicer_2 = item_1;
                    var i_local_4 = i_3;
                    n17._Operations_.Invoke<T2, T>(Input_In: Selector_In, Arg_In: splicer_2, Result_Out: out T Result_5);
                    builder_6.Add(Result_5);
                    i_3++;
                }
            }
            finally
            {
                output_7 = builder_6.Commit();
            }

            w_0.CreateDefault(Output_Out: out T Output_8);
            n8._Operations_.FirstOrDefault<n5.Spread<T>, T>(Input_In: output_7, Default_Value_In: Output_8, Output_Out: out n5.Spread<T> Output_9, Result_Out: out T Result_10);
            T accumulator_12 = Result_10;
            var i_14 = 0;
            foreach (var item_11 in n4.CollectionExtensions.AsSpan(Output_9))
            {
                var splicer_13 = item_11;
                var i_local_15 = i_14;
                n13._Operations_.Max<T, AdM>(Input_In: splicer_13, Input_2_In: accumulator_12, Output_Out: out T Output_16);
                accumulator_12 = Output_16;
                i_14++;
            }

            Result_Out = accumulator_12;
            return;
        }

        public static void Min<T2, T, AdM>(T2 Input_In, out T Result_Out)
            where T2 : n6.IEnumerable<T> where AdM : struct, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorLess<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(Output_Out: out T Output_1);
            n8._Operations_.FirstOrDefault<T2, T>(Input_In: Input_In, Default_Value_In: Output_1, Output_Out: out T2 Output_2, Result_Out: out T Result_3);
            T accumulator_5 = Result_3;
            var i_7 = 0;
            foreach (var item_4 in Output_2)
            {
                var splicer_6 = item_4;
                var i_local_8 = i_7;
                n13._Operations_.Min<T, AdM>(Input_In: splicer_6, Input_2_In: accumulator_5, Output_Out: out T Output_9);
                accumulator_5 = Output_9;
                i_7++;
            }

            Result_Out = accumulator_5;
            return;
        }

        public static void Min_Selector<T3, T2, T, AdM>(T3 Input_In, n2.Func<T2, T> Selector_In, out T Result_Out)
            where T3 : n6.IEnumerable<T2> where AdM : struct, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorLess<T>
        {
            n5.Spread<T> __cp_VxUx5putQIFNVp3qSyYBkp = n7._Operations_.CreateDefault<T>();
            var w_0 = default(AdM);
            var builder_6 = n4.CollectionBuilders.GetBuilder(__cp_VxUx5putQIFNVp3qSyYBkp, 16);
            n5.Spread<T> output_7;
            try
            {
                var i_3 = 0;
                foreach (var item_1 in Input_In)
                {
                    var splicer_2 = item_1;
                    var i_local_4 = i_3;
                    n17._Operations_.Invoke<T2, T>(Input_In: Selector_In, Arg_In: splicer_2, Result_Out: out T Result_5);
                    builder_6.Add(Result_5);
                    i_3++;
                }
            }
            finally
            {
                output_7 = builder_6.Commit();
            }

            w_0.CreateDefault(Output_Out: out T Output_8);
            n8._Operations_.FirstOrDefault<n5.Spread<T>, T>(Input_In: output_7, Default_Value_In: Output_8, Output_Out: out n5.Spread<T> Output_9, Result_Out: out T Result_10);
            T accumulator_12 = Result_10;
            var i_14 = 0;
            foreach (var item_11 in n4.CollectionExtensions.AsSpan(Output_9))
            {
                var splicer_13 = item_11;
                var i_local_15 = i_14;
                n13._Operations_.Min<T, AdM>(Input_In: splicer_13, Input_2_In: accumulator_12, Output_Out: out T Output_16);
                accumulator_12 = Output_16;
                i_14++;
            }

            Result_Out = accumulator_12;
            return;
        }

        public static void None<T>(n6.IEnumerable<T> Input_In, out bool Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.None<T>(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void None_Predicate<T>(n6.IEnumerable<T> Input_In, n2.Func<T, bool> Predicate_In, out bool Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.None<T>(input: Input_In, predicate: Predicate_In);
            Result_Out = Result_0;
            return;
        }

        public static void OR_Spectral(n6.IEnumerable<bool> Input_In, out bool Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.OR(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void RecursiveTree<T, T2>(int Max_Depth_In, T Initial_Element_In, n2.Func<T, int, T2> Create_Children_In, out n5.Spread<T> Result_Out)
            where T2 : n6.IEnumerable<T>
        {
            n1.NodeContext Node_Context_0 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "MsdX2uCw2SuNPKsE52h4Zq", 269545U);
            int Capacity_1 = 0;
            n24._Operations_.Create<T>(Node_Context: Node_Context_0, Capacity_In: Capacity_1, Output_Out: out n5.SpreadBuilder<T> Output_2);
            n24._Operations_.Add<T>(Input_In: Output_2, Item_In: Initial_Element_In, Output_Out: out n5.SpreadBuilder<T> Output_3);
            n5.SpreadBuilder<T> accumulator_5 = Output_3;
            n5.SpreadBuilder<T> accumulator_6 = Output_3;
            for (var i_4 = 0; i_4 < Max_Depth_In; i_4++)
            {
                var i_local_7 = i_4;
                n1.NodeContext Node_Context_8 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "J2M2kM8p87QPnmoXsYrCpR", 269564U);
                int Capacity_9 = 0;
                n24._Operations_.Create<T>(Node_Context: Node_Context_8, Capacity_In: Capacity_9, Output_Out: out n5.SpreadBuilder<T> Output_10);
                n5.SpreadBuilder<T> accumulator_12 = Output_10;
                var i_14 = 0;
                foreach (var item_11 in accumulator_6)
                {
                    var splicer_13 = item_11;
                    var i_local_15 = i_14;
                    n47._Operations_.Invoke<T, int, T2>(Input_In: Create_Children_In, Arg_1_In: splicer_13, Arg_2_In: i_local_7, Result_Out: out T2 Result_16);
                    n6.IEnumerable<T> Items_17 = (n6.IEnumerable<T>)Result_16;
                    n24._Operations_.AddRange<T>(Input_In: accumulator_12, Items_In: Items_17, Output_Out: out n5.SpreadBuilder<T> Output_18);
                    accumulator_12 = Output_18;
                    i_14++;
                }

                n6.IEnumerable<T> Items_19 = (n6.IEnumerable<T>)accumulator_12;
                n24._Operations_.AddRange<T>(Input_In: accumulator_5, Items_In: Items_19, Output_Out: out n5.SpreadBuilder<T> Output_20);
                accumulator_5 = Output_20;
                accumulator_6 = accumulator_12;
            }

            n24._Operations_.ToSpread<T>(Input_In: accumulator_5, Output_Out: out n5.SpreadBuilder<T> Output_21, Result_Out: out n5.Spread<T> Result_22);
            Result_Out = Result_22;
            return;
        }

        public static void SequenceEqual<T>(n6.IEnumerable<T> Input_In, n6.IEnumerable<T> Second_In, out bool Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.SequenceEqual<T>(input: Input_In, second: Second_In);
            Result_Out = Result_0;
            return;
        }

        public static void SplitFirst<T>(n6.IEnumerable<T> Input_In, T Default_Value_In, out n6.IEnumerable<T> Output_Out, out T Result_Out)
        {
            n23.EnumerableNodes.SplitFirst<T>(input: Input_In, defaultValue: Default_Value_In, output: out n6.IEnumerable<T> Output_0, result: out T Result_1);
            Output_Out = Output_0;
            Result_Out = Result_1;
            return;
        }

        public static void SplitLast<T>(n6.IEnumerable<T> Input_In, T Default_Value_In, out n6.IEnumerable<T> Output_Out, out T Result_Out)
        {
            n23.EnumerableNodes.SplitLast<T>(input: Input_In, defaultValue: Default_Value_In, output: out n6.IEnumerable<T> Output_0, result: out T Result_1);
            Output_Out = Output_0;
            Result_Out = Result_1;
            return;
        }

        public static void Sum<T2, T, AdM>(T2 Input_In, out T Result_Out)
            where T2 : n6.IEnumerable<T> where AdM : struct, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorPlus<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(Output_Out: out T Output_1);
            T accumulator_3 = Output_1;
            var i_5 = 0;
            foreach (var item_2 in Input_In)
            {
                var splicer_4 = item_2;
                var i_local_6 = i_5;
                w_0.OperatorPlus(Input_In: splicer_4, Input_2_In: accumulator_3, Output_Out: out T Output_7);
                accumulator_3 = Output_7;
                i_5++;
            }

            Result_Out = accumulator_3;
            return;
        }

        public static void Sum_Selector<T3, T2, T, AdM>(T3 Input_In, n2.Func<T2, T> Selector_In, out T Result_Out)
            where T3 : n6.IEnumerable<T2> where AdM : struct, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorPlus<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(Output_Out: out T Output_1);
            T accumulator_3 = Output_1;
            var i_5 = 0;
            foreach (var item_2 in Input_In)
            {
                var splicer_4 = item_2;
                var i_local_6 = i_5;
                n17._Operations_.Invoke<T2, T>(Input_In: Selector_In, Arg_In: splicer_4, Result_Out: out T Result_7);
                w_0.OperatorPlus(Input_In: Result_7, Input_2_In: accumulator_3, Output_Out: out T Output_8);
                accumulator_3 = Output_8;
                i_5++;
            }

            Result_Out = accumulator_3;
            return;
        }

        public static void ToStream(n6.IEnumerable<byte> Input_In, bool Writeable_In, out n54.IResourceProvider<n53.Stream> Result_Out)
        {
            var Result_0 = n52.StreamUtils.ToStream(input: Input_In, writeable: Writeable_In);
            Result_Out = Result_0;
            return;
        }

        public static void ToString(n6.IEnumerable<char> Input_In, out string Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.ToString(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void GetPairedSpreads<T>(n6.IEnumerable<T> Input_In, out n5.Spread<T> Output_Out, out n5.Spread<T> Output_2_Out)
        {
            n23.EnumerableNodes.GetPairedSpreads<T>(input: Input_In, output: out n5.Spread<T> Output_0, output2: out n5.Spread<T> Output_2_1);
            Output_Out = Output_0;
            Output_2_Out = Output_2_1;
            return;
        }

        public static void ToList<T>(n6.IEnumerable<T> Input_In, out n6.List<T> Result_Out)
        {
            var Result_0 = n39.Enumerable.ToList<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Aggregate<T2, T>(n6.IEnumerable<T2> Input_In, T Seed_In, n2.Func<T, T2, T> Accumulator_In, out T Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.Aggregate<T2, T>(input: Input_In, seed: Seed_In, accumulator: Accumulator_In);
            Result_Out = Result_0;
            return;
        }

        public static void Cast<T>(n15.IEnumerable Input_In, out n6.IEnumerable<T> Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.Cast<T>(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Concat<T>(n6.IEnumerable<T> Input_In, n6.IEnumerable<T> Input_2_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.Concat<T>(input: Input_In, input2: Input_2_In);
            Output_Out = Output_0;
            return;
        }

        public static void Count<T>(n6.IEnumerable<T> Input_In, out int Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.Count<T>(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Count_Predicate<T>(n6.IEnumerable<T> Input_In, n2.Func<T, bool> Predicate_In, out int Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.Count<T>(input: Input_In, predicate: Predicate_In);
            Result_Out = Result_0;
            return;
        }

        public static void DefaultIfEmpty<T>(n6.IEnumerable<T> Input_In, T Default_Value_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.DefaultIfEmpty<T>(input: Input_In, defaultValue: Default_Value_In);
            Output_Out = Output_0;
            return;
        }

        public static void Distinct<T>(n6.IEnumerable<T> Input_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.Distinct<T>(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Distinct_Selector<T, T2>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n39.EnumerableEx.Distinct<T, T2>(source: Input_In, keySelector: Key_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void DistinctUntilChanged<T>(n6.IEnumerable<T> Input_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n39.EnumerableEx.DistinctUntilChanged<T>(source: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void DistinctUntilChanged_Selector<T, T2>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n39.EnumerableEx.DistinctUntilChanged<T, T2>(source: Input_In, keySelector: Key_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void Do<T>(n6.IEnumerable<T> Input_In, n2.Action<T> On_Next_In, n2.Action On_Completed_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n39.EnumerableEx.Do<T>(source: Input_In, onNext: On_Next_In, onCompleted: On_Completed_In);
            Output_Out = Output_0;
            return;
        }

        public static void Empty<T>(out n6.IEnumerable<T> Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.Empty<T>();
            Result_Out = Result_0;
            return;
        }

        public static void Except<T>(n6.IEnumerable<T> Input_In, n6.IEnumerable<T> Input_2_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.Except<T>(input: Input_In, input2: Input_2_In);
            Output_Out = Output_0;
            return;
        }

        public static void Except_Selector<T, T2>(n6.IEnumerable<T> Input_In, n6.IEnumerable<T> Input_2_In, n2.Func<T, T2> Selector_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.ExceptByKey<T, T2>(input: Input_In, input2: Input_2_In, selector: Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void Expand<T>(n6.IEnumerable<T> Input_In, n2.Func<T, n6.IEnumerable<T>> Selector_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n39.EnumerableEx.Expand<T>(source: Input_In, selector: Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void GroupBy<T, T2>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n6.IEnumerable<n39.IGrouping<T2, T>> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.GroupBy<T, T2>(input: Input_In, keySelector: Key_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void Intersect<T>(n6.IEnumerable<T> Input_In, n6.IEnumerable<T> Input_2_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.Intersect<T>(input: Input_In, input2: Input_2_In);
            Output_Out = Output_0;
            return;
        }

        public static void Intersect_Selector<T, T2>(n6.IEnumerable<T> Input_In, n6.IEnumerable<T> Input_2_In, n2.Func<T, T2> Selector_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.IntersectByKey<T, T2>(input: Input_In, input2: Input_2_In, selector: Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void IsEmpty<T>(n6.IEnumerable<T> Input_In, out bool Result_Out)
        {
            var Result_0 = n39.EnumerableEx.IsEmpty<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void MaxBy<T, T2>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n6.IList<T> Result_Out)
        {
            var Result_0 = n39.EnumerableEx.MaxBy<T, T2>(source: Input_In, keySelector: Key_Selector_In);
            Result_Out = Result_0;
            return;
        }

        public static void Memoize<T>(n6.IEnumerable<T> Input_In, out n39.IBuffer<T> Result_Out)
        {
            var Result_0 = n39.EnumerableEx.Memoize<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void MinBy<T, T2>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n6.IList<T> Result_Out)
        {
            var Result_0 = n39.EnumerableEx.MinBy<T, T2>(source: Input_In, keySelector: Key_Selector_In);
            Result_Out = Result_0;
            return;
        }

        public static void OfType<T>(n15.IEnumerable Input_In, out n6.IEnumerable<T> Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.OfType<T>(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void OrderBy<T, T2>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n39.IOrderedEnumerable<T> Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.OrderBy<T, T2>(input: Input_In, keySelector: Key_Selector_In);
            Result_Out = Result_0;
            return;
        }

        public static void OrderByDescending<T, T2>(n6.IEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n39.IOrderedEnumerable<T> Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.OrderByDescending<T, T2>(input: Input_In, keySelector: Key_Selector_In);
            Result_Out = Result_0;
            return;
        }

        public static void Select<T, T2>(n6.IEnumerable<T> Input_In, n2.Func<T, int, T2> Transformer_In, out n6.IEnumerable<T2> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.Project<T, T2>(input: Input_In, transformer: Transformer_In);
            Output_Out = Output_0;
            return;
        }

        public static void Select_Many<T, T2>(n6.IEnumerable<T> Input_In, n2.Func<T, int, n6.IEnumerable<T2>> Transformer_In, out n6.IEnumerable<T2> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.Project<T, T2>(input: Input_In, transformer: Transformer_In);
            Output_Out = Output_0;
            return;
        }

        public static void Publish<T>(n6.IEnumerable<T> Input_In, out n39.IBuffer<T> Result_Out)
        {
            var Result_0 = n39.EnumerableEx.Publish<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Repeat<T>(T Element_In, int Count_In, out n6.IEnumerable<T> Result_Out)
        {
            var Result_0 = n39.EnumerableEx.Repeat<T>(element: Element_In, count: Count_In);
            Result_Out = Result_0;
            return;
        }

        public static void Reverse<T>(n6.IEnumerable<T> Input_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.Reverse<T>(input: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Scan<T2, T>(n6.IEnumerable<T2> Input_In, T Seed_In, n2.Func<T, T2, T> Accumulator_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n39.EnumerableEx.Scan<T2, T>(source: Input_In, seed: Seed_In, accumulator: Accumulator_In);
            Output_Out = Output_0;
            return;
        }

        public static void Share<T>(n6.IEnumerable<T> Input_In, out n39.IBuffer<T> Result_Out)
        {
            var Result_0 = n39.EnumerableEx.Share<T>(source: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Skip<T>(n6.IEnumerable<T> Input_In, int Count_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.Skip<T>(input: Input_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void SkipLast<T>(n6.IEnumerable<T> Input_In, int Count_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n39.EnumerableEx.SkipLast<T>(source: Input_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void SkipWhile<T>(n6.IEnumerable<T> Input_In, n2.Func<T, int, bool> Predicate_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.SkipWhile<T>(input: Input_In, predicate: Predicate_In);
            Output_Out = Output_0;
            return;
        }

        public static void SplitAt<T>(n6.IEnumerable<T> Input_In, int Index_In, out n6.IEnumerable<T> Output_Out, out n6.IEnumerable<T> Output_2_Out)
        {
            n23.EnumerableNodes.SplitAt<T>(input: Input_In, index: Index_In, output: out n6.IEnumerable<T> Output_0, output2: out n6.IEnumerable<T> Output_2_1);
            Output_Out = Output_0;
            Output_2_Out = Output_2_1;
            return;
        }

        public static void Take<T>(n6.IEnumerable<T> Input_In, int Count_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.Take<T>(input: Input_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void TakeLast<T>(n6.IEnumerable<T> Input_In, int Count_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n39.EnumerableEx.TakeLast<T>(source: Input_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void TakeWhile<T>(n6.IEnumerable<T> Input_In, n2.Func<T, int, bool> Predicate_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.TakeWhile<T>(input: Input_In, predicate: Predicate_In);
            Output_Out = Output_0;
            return;
        }

        public static void ThenBy<T, T2>(n39.IOrderedEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n39.IOrderedEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.ThenBy<T, T2>(input: Input_In, keySelector: Key_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void ThenByDescending<T, T2>(n39.IOrderedEnumerable<T> Input_In, n2.Func<T, T2> Key_Selector_In, out n39.IOrderedEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.ThenByDescending<T, T2>(input: Input_In, keySelector: Key_Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void FromValue<T>(T Input_In, out n6.IEnumerable<T> Result_Out)
        {
            var Result_0 = n23.EnumerableNodes.ToSequence<T>(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Union<T>(n6.IEnumerable<T> Input_In, n6.IEnumerable<T> Input_2_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.Union<T>(input: Input_In, input2: Input_2_In);
            Output_Out = Output_0;
            return;
        }

        public static void Union_Selector<T, T2>(n6.IEnumerable<T> Input_In, n6.IEnumerable<T> Input_2_In, n2.Func<T, T2> Selector_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.UnionByKey<T, T2>(input: Input_In, input2: Input_2_In, selector: Selector_In);
            Output_Out = Output_0;
            return;
        }

        public static void UnZip<T>(n6.IEnumerable<T> Input_In, out n6.IEnumerable<T> Output_Out, out n6.IEnumerable<T> Output_2_Out)
        {
            n23.EnumerableNodes.UnZip<T>(input: Input_In, output: out n6.IEnumerable<T> Output_0, output2: out n6.IEnumerable<T> Output_2_1);
            Output_Out = Output_0;
            Output_2_Out = Output_2_1;
            return;
        }

        public static void Where<T>(n6.IEnumerable<T> Input_In, n2.Func<T, int, bool> Predicate_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.Where<T>(input: Input_In, predicate: Predicate_In);
            Output_Out = Output_0;
            return;
        }

        public static void Zip<T>(n6.IEnumerable<T> Input_In, n6.IEnumerable<T> Input_2_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Use_Min_Count_In, out n6.IEnumerable<T> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.ZipIt<T>(input: Input_In, input2: Input_2_In, useMinCount: Use_Min_Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void Zip_LINQ<T, T2, T3>(n6.IEnumerable<T> Input_In, n6.IEnumerable<T2> Input_2_In, n2.Func<T, T2, T3> Result_Selector_In, out n6.IEnumerable<T3> Output_Out)
        {
            var Output_0 = n23.EnumerableNodes.Zip<T, T2, T3>(input: Input_In, input2: Input_2_In, resultSelector: Result_Selector_In);
            Output_Out = Output_0;
            return;
        }

        [n1.ElementAttribute(TracingId = 269107U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "AVHKqZ1HxdCMkwblfNESJG", Name = "__slot_AVHKqZ1HxdCMkwblfNESJG")]
        public static int __slot_AVHKqZ1HxdCMkwblfNESJG = 1;
        [n1.ElementAttribute(TracingId = 269151U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "H4xl3WlQWS9MV59AI9Syxx", Name = "__slot_H4xl3WlQWS9MV59AI9Syxx")]
        public static int __slot_H4xl3WlQWS9MV59AI9Syxx = 1;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Collections_.Collections.Sequence.Grouping
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Key<T, T2>(n39.IGrouping<T, T2> Input_In, out n39.IGrouping<T, T2> Output_Out, out T Key_Out)
        {
            var Key_0 = Input_In.Key;
            Output_Out = Input_In;
            Key_Out = Key_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Spread.Internal
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void BSplineCubic<T, AdM>(T Control_1_In, T Control_2_In, T Control_3_In, T Control_4_In, float Range_In, out T Position_Out, out T Tangent_Out)
            where AdM : struct, n19.IAdaptiveOperatorMinus<T>, n19.IAdaptiveOperatorMulitply_Scale<T>, n19.IAdaptiveOperatorPlus<T>, n19.IAdaptiveOperatorDivide_Scale<T>
        {
            var w_0 = default(AdM);
            float Scalar_1 = 3F;
            w_0.OperatorMulitply_Scale(Input_In: Control_3_In, Scalar_In: Scalar_1, Output_Out: out T Output_2);
            w_0.OperatorMinus(Input_In: Control_4_In, Input_2_In: Output_2, Output_Out: out T Output_3);
            float Scalar_4 = 3F;
            w_0.OperatorMulitply_Scale(Input_In: Control_2_In, Scalar_In: Scalar_4, Output_Out: out T Output_5);
            w_0.OperatorPlus(Input_In: Output_3, Input_2_In: Output_5, Output_Out: out T Output_6);
            w_0.OperatorMinus(Input_In: Output_6, Input_2_In: Control_1_In, Output_Out: out T Output_7);
            float Scalar_8 = 4F;
            w_0.OperatorMulitply_Scale(Input_In: Control_2_In, Scalar_In: Scalar_8, Output_Out: out T Output_9);
            w_0.OperatorPlus(Input_In: Control_3_In, Input_2_In: Output_9, Output_Out: out T Output_10);
            float Scalar_11 = 6F;
            w_0.OperatorMulitply_Scale(Input_In: Control_2_In, Scalar_In: Scalar_11, Output_Out: out T Output_12);
            w_0.OperatorMinus(Input_In: Output_2, Input_2_In: Output_12, Output_Out: out T Output_13);
            float Scalar_14 = 3F;
            w_0.OperatorMulitply_Scale(Input_In: Control_1_In, Scalar_In: Scalar_14, Output_Out: out T Output_15);
            w_0.OperatorPlus(Input_In: Output_13, Input_2_In: Output_15, Output_Out: out T Output_16);
            n10.Float32Extensions.Frac(input: Range_In, wholePart: out int Whole_Part_17, fractionalPart: out float Fractional_Part_18);
            w_0.OperatorMulitply_Scale(Input_In: Output_7, Scalar_In: Fractional_Part_18, Output_Out: out T Output_19);
            w_0.OperatorPlus(Input_In: Output_19, Input_2_In: Output_16, Output_Out: out T Output_20);
            w_0.OperatorMulitply_Scale(Input_In: Output_20, Scalar_In: Fractional_Part_18, Output_Out: out T Output_21);
            float Scalar_22 = 3F;
            w_0.OperatorMulitply_Scale(Input_In: Control_1_In, Scalar_In: Scalar_22, Output_Out: out T Output_23);
            w_0.OperatorMinus(Input_In: Output_2, Input_2_In: Output_23, Output_Out: out T Output_24);
            w_0.OperatorPlus(Input_In: Output_21, Input_2_In: Output_24, Output_Out: out T Output_25);
            w_0.OperatorMulitply_Scale(Input_In: Output_25, Scalar_In: Fractional_Part_18, Output_Out: out T Output_26);
            w_0.OperatorPlus(Input_In: Output_10, Input_2_In: Control_1_In, Output_Out: out T Output_27);
            w_0.OperatorPlus(Input_In: Output_26, Input_2_In: Output_27, Output_Out: out T Output_28);
            float Scalar_29 = 6F;
            w_0.OperatorDivide_Scale(Input_In: Output_28, Scalar_In: Scalar_29, Output_Out: out T Output_30);
            float Scalar_31 = 3F;
            w_0.OperatorMulitply_Scale(Input_In: Output_19, Scalar_In: Scalar_31, Output_Out: out T Output_32);
            w_0.OperatorPlus(Input_In: Output_32, Input_2_In: Output_16, Output_Out: out T Output_33);
            w_0.OperatorMulitply_Scale(Input_In: Output_33, Scalar_In: Fractional_Part_18, Output_Out: out T Output_34);
            w_0.OperatorPlus(Input_In: Output_34, Input_2_In: Output_25, Output_Out: out T Output_35);
            float Scalar_36 = 6F;
            w_0.OperatorDivide_Scale(Input_In: Output_35, Scalar_In: Scalar_36, Output_Out: out T Output_37);
            Position_Out = Output_30;
            Tangent_Out = Output_37;
            return;
        }

        public static void BSplineCubic<T, AdM>(T Control_1_In, T Control_2_In, T Control_3_In, T Control_4_In, float Range_In, out T Position_Out)
            where AdM : struct, n19.IAdaptiveOperatorMinus<T>, n19.IAdaptiveOperatorMulitply_Scale<T>, n19.IAdaptiveOperatorPlus<T>, n19.IAdaptiveOperatorDivide_Scale<T>
        {
            var w_0 = default(AdM);
            float Scalar_1 = 3F;
            w_0.OperatorMulitply_Scale(Input_In: Control_3_In, Scalar_In: Scalar_1, Output_Out: out T Output_2);
            w_0.OperatorMinus(Input_In: Control_4_In, Input_2_In: Output_2, Output_Out: out T Output_3);
            float Scalar_4 = 3F;
            w_0.OperatorMulitply_Scale(Input_In: Control_2_In, Scalar_In: Scalar_4, Output_Out: out T Output_5);
            w_0.OperatorPlus(Input_In: Output_3, Input_2_In: Output_5, Output_Out: out T Output_6);
            w_0.OperatorMinus(Input_In: Output_6, Input_2_In: Control_1_In, Output_Out: out T Output_7);
            float Scalar_8 = 4F;
            w_0.OperatorMulitply_Scale(Input_In: Control_2_In, Scalar_In: Scalar_8, Output_Out: out T Output_9);
            w_0.OperatorPlus(Input_In: Control_3_In, Input_2_In: Output_9, Output_Out: out T Output_10);
            float Scalar_11 = 6F;
            w_0.OperatorMulitply_Scale(Input_In: Control_2_In, Scalar_In: Scalar_11, Output_Out: out T Output_12);
            w_0.OperatorMinus(Input_In: Output_2, Input_2_In: Output_12, Output_Out: out T Output_13);
            float Scalar_14 = 3F;
            w_0.OperatorMulitply_Scale(Input_In: Control_1_In, Scalar_In: Scalar_14, Output_Out: out T Output_15);
            w_0.OperatorPlus(Input_In: Output_13, Input_2_In: Output_15, Output_Out: out T Output_16);
            n10.Float32Extensions.Frac(input: Range_In, wholePart: out int Whole_Part_17, fractionalPart: out float Fractional_Part_18);
            w_0.OperatorMulitply_Scale(Input_In: Output_7, Scalar_In: Fractional_Part_18, Output_Out: out T Output_19);
            w_0.OperatorPlus(Input_In: Output_19, Input_2_In: Output_16, Output_Out: out T Output_20);
            w_0.OperatorMulitply_Scale(Input_In: Output_20, Scalar_In: Fractional_Part_18, Output_Out: out T Output_21);
            float Scalar_22 = 3F;
            w_0.OperatorMulitply_Scale(Input_In: Control_1_In, Scalar_In: Scalar_22, Output_Out: out T Output_23);
            w_0.OperatorMinus(Input_In: Output_2, Input_2_In: Output_23, Output_Out: out T Output_24);
            w_0.OperatorPlus(Input_In: Output_21, Input_2_In: Output_24, Output_Out: out T Output_25);
            w_0.OperatorMulitply_Scale(Input_In: Output_25, Scalar_In: Fractional_Part_18, Output_Out: out T Output_26);
            w_0.OperatorPlus(Input_In: Output_10, Input_2_In: Control_1_In, Output_Out: out T Output_27);
            w_0.OperatorPlus(Input_In: Output_26, Input_2_In: Output_27, Output_Out: out T Output_28);
            float Scalar_29 = 6F;
            w_0.OperatorDivide_Scale(Input_In: Output_28, Scalar_In: Scalar_29, Output_Out: out T Output_30);
            Position_Out = Output_30;
            return;
        }

        public static void BSpline<T, AdM>(n5.Spread<T> Control_Points_In, bool Close_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Normalized_Sampling_Range_In, [n4.SerializedDefaultValueAttribute("1", false)] float Sample_Position_In, out T Output_Out, out T Tangent_Out)
            where AdM : struct, n19.IAdaptiveOperatorMinus<T>, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorMulitply_Scale<T>, n19.IAdaptiveOperatorPlus<T>, n19.IAdaptiveOperatorDivide_Scale<T>
        {
            var w_0 = default(AdM);
            n7._Operations_.Count<T>(Input_In: Control_Points_In, Count_Out: out int Count_1);
            bool Apply_2 = true;
            var Output_3 = Count_1;
            if (Apply_2)
            {
                var Output_4 = n10.Integer32Extensions.Dec(input: Count_1);
                Output_3 = Output_4;
            }

            n7._Operations_.Count<T>(Input_In: Control_Points_In, Count_Out: out int Count_5);
            var Output_6 = n10.Integer32Extensions.Dec(input: Count_5);
            float Input_2_7 = (float)Output_6;
            var Output_8 = Sample_Position_In;
            if (Normalized_Sampling_Range_In)
            {
                var Output_9 = Sample_Position_In * Input_2_7;
                Output_8 = Output_9;
            }

            n10.Float32Extensions.Frac(input: Output_8, wholePart: out int Whole_Part_10, fractionalPart: out float Fractional_Part_11);
            var Output_12 = n10.Integer32Extensions.Inc(input: Whole_Part_10);
            var Output_13 = !Close_In;
            var Output_14 = Output_12;
            if (Output_13)
            {
                n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_12, Input_2_In: Output_3, Output_Out: out Output_14);
            }

            w_0.CreateDefault(Output_Out: out T Output_15);
            var Output_16 = n10.Integer32Extensions.Dec(input: Whole_Part_10);
            int Input_2_17 = 0;
            var Output_18 = Output_16;
            if (Output_13)
            {
                n13._Operations_.Max<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_16, Input_2_In: Input_2_17, Output_Out: out Output_18);
            }

            n7._Operations_.GetSlice<T>(Input_In: Control_Points_In, Default_Value_In: Output_15, Index_In: Output_18, Result_Out: out T Result_19);
            w_0.CreateDefault(Output_Out: out T Output_20);
            n7._Operations_.GetSlice<T>(Input_In: Control_Points_In, Default_Value_In: Output_20, Index_In: Whole_Part_10, Result_Out: out T Result_21);
            w_0.CreateDefault(Output_Out: out T Output_22);
            n7._Operations_.GetSlice<T>(Input_In: Control_Points_In, Default_Value_In: Output_22, Index_In: Output_14, Result_Out: out T Result_23);
            w_0.CreateDefault(Output_Out: out T Output_24);
            var Output_25 = n10.Integer32Extensions.Inc(input: Output_12);
            var Output_26 = Output_25;
            if (Output_13)
            {
                n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_25, Input_2_In: Output_3, Output_Out: out Output_26);
            }

            n7._Operations_.GetSlice<T>(Input_In: Control_Points_In, Default_Value_In: Output_24, Index_In: Output_26, Result_Out: out T Result_27);
            n48._Operations_.BSplineCubic<T, AdM>(Control_1_In: Result_19, Control_2_In: Result_21, Control_3_In: Result_23, Control_4_In: Result_27, Range_In: Fractional_Part_11, Position_Out: out T Position_28, Tangent_Out: out T Tangent_29);
            Output_Out = Position_28;
            Tangent_Out = Tangent_29;
            return;
        }

        public static void BSpline<T, AdM>(n5.Spread<T> Control_Points_In, bool Close_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Normalized_Sampling_Range_In, [n4.SerializedDefaultValueAttribute("1", false)] float Sample_Position_In, out T Output_Out)
            where AdM : struct, n19.IAdaptiveOperatorMinus<T>, n18.IAdaptiveCreateDefault<T>, n19.IAdaptiveOperatorMulitply_Scale<T>, n19.IAdaptiveOperatorPlus<T>, n19.IAdaptiveOperatorDivide_Scale<T>
        {
            var w_0 = default(AdM);
            n7._Operations_.Count<T>(Input_In: Control_Points_In, Count_Out: out int Count_1);
            bool Apply_2 = true;
            var Output_3 = Count_1;
            if (Apply_2)
            {
                var Output_4 = n10.Integer32Extensions.Dec(input: Count_1);
                Output_3 = Output_4;
            }

            n7._Operations_.Count<T>(Input_In: Control_Points_In, Count_Out: out int Count_5);
            var Output_6 = n10.Integer32Extensions.Dec(input: Count_5);
            float Input_2_7 = (float)Output_6;
            var Output_8 = Sample_Position_In;
            if (Normalized_Sampling_Range_In)
            {
                var Output_9 = Sample_Position_In * Input_2_7;
                Output_8 = Output_9;
            }

            n10.Float32Extensions.Frac(input: Output_8, wholePart: out int Whole_Part_10, fractionalPart: out float Fractional_Part_11);
            var Output_12 = n10.Integer32Extensions.Inc(input: Whole_Part_10);
            var Output_13 = !Close_In;
            var Output_14 = Output_12;
            if (Output_13)
            {
                n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_12, Input_2_In: Output_3, Output_Out: out Output_14);
            }

            w_0.CreateDefault(Output_Out: out T Output_15);
            var Output_16 = n10.Integer32Extensions.Dec(input: Whole_Part_10);
            int Input_2_17 = 0;
            var Output_18 = Output_16;
            if (Output_13)
            {
                n13._Operations_.Max<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_16, Input_2_In: Input_2_17, Output_Out: out Output_18);
            }

            n7._Operations_.GetSlice<T>(Input_In: Control_Points_In, Default_Value_In: Output_15, Index_In: Output_18, Result_Out: out T Result_19);
            w_0.CreateDefault(Output_Out: out T Output_20);
            n7._Operations_.GetSlice<T>(Input_In: Control_Points_In, Default_Value_In: Output_20, Index_In: Whole_Part_10, Result_Out: out T Result_21);
            w_0.CreateDefault(Output_Out: out T Output_22);
            n7._Operations_.GetSlice<T>(Input_In: Control_Points_In, Default_Value_In: Output_22, Index_In: Output_14, Result_Out: out T Result_23);
            w_0.CreateDefault(Output_Out: out T Output_24);
            var Output_25 = n10.Integer32Extensions.Inc(input: Output_12);
            var Output_26 = Output_25;
            if (Output_13)
            {
                n13._Operations_.Min<int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>(Input_In: Output_25, Input_2_In: Output_3, Output_Out: out Output_26);
            }

            n7._Operations_.GetSlice<T>(Input_In: Control_Points_In, Default_Value_In: Output_24, Index_In: Output_26, Result_Out: out T Result_27);
            n48._Operations_.BSplineCubic<T, AdM>(Control_1_In: Result_19, Control_2_In: Result_21, Control_3_In: Result_23, Control_4_In: Result_27, Range_In: Fractional_Part_11, Position_Out: out T Position_28);
            Output_Out = Position_28;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Spread.ResampleHermite
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Hermite2(float Y_0_In, float Y_1_In, float Y_2_In, float Y_3_In, float Phase_In, float Tension_In, float Bias_In, out float Output_Out)
        {
            var Output_0 = n23.ResampleNodes.HermiteInterpolate(y0: Y_0_In, y1: Y_1_In, y2: Y_2_In, y3: Y_3_In, phase: Phase_In, tension: Tension_In, bias: Bias_In);
            Output_Out = Output_0;
            return;
        }

        public static void Hermite2(n26.Vector3 Y_0_In, n26.Vector3 Y_1_In, n26.Vector3 Y_2_In, n26.Vector3 Y_3_In, float Phase_In, float Tension_In, float Bias_In, out n26.Vector3 Output_Out)
        {
            n27.Vector3Nodes.Vector(input: ref Y_0_In, x: out float X_0, y: out float Y_1, z: out float Z_2);
            n27.Vector3Nodes.Vector(input: ref Y_1_In, x: out float X_3, y: out float Y_4, z: out float Z_5);
            n27.Vector3Nodes.Vector(input: ref Y_2_In, x: out float X_6, y: out float Y_7, z: out float Z_8);
            n27.Vector3Nodes.Vector(input: ref Y_3_In, x: out float X_9, y: out float Y_10, z: out float Z_11);
            var Output_12 = n23.ResampleNodes.HermiteInterpolate(y0: X_0, y1: X_3, y2: X_6, y3: X_9, phase: Phase_In, tension: Tension_In, bias: Bias_In);
            var Output_13 = n23.ResampleNodes.HermiteInterpolate(y0: Y_1, y1: Y_4, y2: Y_7, y3: Y_10, phase: Phase_In, tension: Tension_In, bias: Bias_In);
            var Output_14 = n23.ResampleNodes.HermiteInterpolate(y0: Z_2, y1: Z_5, y2: Z_8, y3: Z_11, phase: Phase_In, tension: Tension_In, bias: Bias_In);
            var Output_15 = new n26.Vector3(x: Output_12, y: Output_13, z: Output_14);
            Output_Out = Output_15;
            return;
        }

        public static void Hermite2(n26.Vector2 Y_0_In, n26.Vector2 Y_1_In, n26.Vector2 Y_2_In, n26.Vector2 Y_3_In, float Phase_In, float Tension_In, float Bias_In, out n26.Vector2 Output_Out)
        {
            n27.Vector2Nodes.Vector(input: ref Y_0_In, x: out float X_0, y: out float Y_1);
            n27.Vector2Nodes.Vector(input: ref Y_1_In, x: out float X_2, y: out float Y_3);
            n27.Vector2Nodes.Vector(input: ref Y_2_In, x: out float X_4, y: out float Y_5);
            n27.Vector2Nodes.Vector(input: ref Y_3_In, x: out float X_6, y: out float Y_7);
            var Output_8 = n23.ResampleNodes.HermiteInterpolate(y0: X_0, y1: X_2, y2: X_4, y3: X_6, phase: Phase_In, tension: Tension_In, bias: Bias_In);
            var Output_9 = n23.ResampleNodes.HermiteInterpolate(y0: Y_1, y1: Y_3, y2: Y_5, y3: Y_7, phase: Phase_In, tension: Tension_In, bias: Bias_In);
            var Output_10 = new n26.Vector2(x: Output_8, y: Output_9);
            Output_Out = Output_10;
            return;
        }
    }

    public interface IAdaptiveHermite2<T>
    {
        void Hermite2(T Y_0_In, T Y_1_In, T Y_2_In, T Y_3_In, float Phase_In, float Tension_In, float Bias_In, out T Output_Out);
    }
}

namespace _VL_Collections_.Collections.Trees.Patching.Advanced
{
    [n1.ElementAttribute(TracingId = 273685U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "NOf9dxEyKDUPe0guw7xDWw", Name = "TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw")]
    [n2.SerializableAttribute]
    public class TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> : n1.VLObject, n2.IDisposable
    {
        public static n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> Create(n1.NodeContext Node_Context, T2 Node_In, n2.Action<T, T2> Attach_To_New_Parent_In, out n56.TreeNodeParentManager<T, T2> Output_Out)
        {
            var instance = new TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Node_In, Attach_To_New_Parent_In, out Output_Out);
        }

        [n4.CreateDefaultAttribute]
        public static n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> CreateDefault()
        {
            var instance = new TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        [n4.CreateNewAttribute]
        public static n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> Create(n1.NodeContext Node_Context)
        {
            var instance = new TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        public n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> ManyWannaBeParents(out bool Many_Wanna_Be_Parents_Out)
        {
            n57._Operations_.ManyWannaBeParents<T, T2>(Input_In: this.__p_Ur7Sqm5azIJLfGIPnq1NTB, Output_Out: out n56.TreeNodeParentManager<T, T2> Output_0, Many_Wanna_Be_Parents_Out: out bool Many_Wanna_Be_Parents_1);
            Many_Wanna_Be_Parents_Out = Many_Wanna_Be_Parents_1;
            n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_0 != this.__p_Ur7Sqm5azIJLfGIPnq1NTB ? new TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2>(this)
                {__p_Ur7Sqm5azIJLfGIPnq1NTB = Output_0} : that_2;
            else
            {
                this.__p_Ur7Sqm5azIJLfGIPnq1NTB = Output_0;
            }

            return that_2;
        }

        public n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> ToggleWarning(out n58.Subject<bool> Toggle_Warning_Out)
        {
            n57._Operations_.ToggleWarning<T, T2>(Input_In: this.__p_Ur7Sqm5azIJLfGIPnq1NTB, Output_Out: out n56.TreeNodeParentManager<T, T2> Output_0, Toggle_Warning_Out: out n58.Subject<bool> Toggle_Warning_1);
            Toggle_Warning_Out = Toggle_Warning_1;
            n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_0 != this.__p_Ur7Sqm5azIJLfGIPnq1NTB ? new TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2>(this)
                {__p_Ur7Sqm5azIJLfGIPnq1NTB = Output_0} : that_2;
            else
            {
                this.__p_Ur7Sqm5azIJLfGIPnq1NTB = Output_0;
            }

            return that_2;
        }

        public n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> SetAllowMultipleConnectionsToSameParent([n4.SerializedDefaultValueAttribute("True", false)] bool Allow_Multiple_Connections_To_Same_Parent_In)
        {
            bool SetAllowMultipleConnectionsToSameParent_0 = true;
            var Output_1 = this.__p_Ur7Sqm5azIJLfGIPnq1NTB;
            if (SetAllowMultipleConnectionsToSameParent_0)
            {
                n57._Operations_.SetAllowMultipleConnectionsToSameParent<T, T2>(Input_In: this.__p_Ur7Sqm5azIJLfGIPnq1NTB, Allow_Multiple_Connections_To_Same_Parent_In: Allow_Multiple_Connections_To_Same_Parent_In, Output_Out: out Output_1);
            }

            n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_Ur7Sqm5azIJLfGIPnq1NTB ? new TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2>(this)
                {__p_Ur7Sqm5azIJLfGIPnq1NTB = Output_1} : that_2;
            else
            {
                this.__p_Ur7Sqm5azIJLfGIPnq1NTB = Output_1;
            }

            return that_2;
        }

        public n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> __Create__(n1.NodeContext Node_Context, T2 Node_In, n2.Action<T, T2> Attach_To_New_Parent_In, out n56.TreeNodeParentManager<T, T2> Output_Out)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var __fallback___0 = n1.ServiceRegistry.Current;
            n2.Action<T, T2> Functionality_5 = (T parent_In_2, T2 me_In_3) =>
            {
                using var __current_1 = __fallback___0.MakeCurrentIfNone();
                n59._Operations_.NULL<T>(Result_Out: out T Result_4);
                n60._Operations_.Invoke<T, T2>(Input_In: Attach_To_New_Parent_In, Arg_1_In: Result_4, Arg_2_In: me_In_3);
            }

            ;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "Ur7Sqm5azIJLfGIPnq1NTB", 273692U);
            n57._Operations_.Create<T2, T>(Node_Context: Node_Context_6, Node_In: Node_In, Attach_To_New_Parent_In: Attach_To_New_Parent_In, Detach_From_Current_Parent_In: Functionality_5, Output_Out: out n56.TreeNodeParentManager<T, T2> Output_7);
            Output_Out = Output_7;
            n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> that_8 = this;
            this.__p_Ur7Sqm5azIJLfGIPnq1NTB = Output_7;
            return that_8;
        }

        public n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> __CreateDefault__()
        {
            n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> that_0 = this;
            this.__p_Ur7Sqm5azIJLfGIPnq1NTB = default(n56.TreeNodeParentManager<T, T2>);
            return that_0;
        }

        public n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context;
            T2 Node_1 = default(T2);
            n2.Action<T, T2> Attach_To_New_Parent_2 = n60._Operations_.CreateDefault<T, T2>();
            var State_Output_4 = Create(Node_Context: Node_Context_0, Node_In: Node_1, Attach_To_New_Parent_In: Attach_To_New_Parent_2, Output_Out: out n56.TreeNodeParentManager<T, T2> Output_3);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Ur7Sqm5azIJLfGIPnq1NTB);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 273692U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "Ur7Sqm5azIJLfGIPnq1NTB", Name = "TreeNodeParentManager", IsManaged = true, IsAutoGenerated = true)]
        public n56.TreeNodeParentManager<T, T2> __p_Ur7Sqm5azIJLfGIPnq1NTB;
        public TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw(TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> other): base(other)
        {
            this.__p_Ur7Sqm5azIJLfGIPnq1NTB = other.__p_Ur7Sqm5azIJLfGIPnq1NTB;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Ur7Sqm5azIJLfGIPnq1NTB", in __p_Ur7Sqm5azIJLfGIPnq1NTB));
        }

        internal TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> __WITH__(n56.TreeNodeParentManager<T, T2> __p_Ur7Sqm5azIJLfGIPnq1NTB)
        {
            n55.TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Ur7Sqm5azIJLfGIPnq1NTB != this.__p_Ur7Sqm5azIJLfGIPnq1NTB ? new TreeNodeParentManager_SetParent_NOf9dxEyKDUPe0guw7xDWw<T, T2>(this)
                {__p_Ur7Sqm5azIJLfGIPnq1NTB = __p_Ur7Sqm5azIJLfGIPnq1NTB} : that_0;
            else
            {
                this.__p_Ur7Sqm5azIJLfGIPnq1NTB = __p_Ur7Sqm5azIJLfGIPnq1NTB;
            }

            return that_0;
        }
    }
}

namespace _VL_Collections_.Collections.Trees.Patching.TreeNodeChildrenManager.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create<T, T2>(n1.NodeContext Node_Context, T Node_In, bool Children_Ordering_Matters_In, n2.Func<T2, n56.TreeNodeParentManager<T, T2>> Parent_Manager_Provider_In, out n56.TreeNodeChildrenManager<T, T2> Output_Out)
        {
            var Output_0 = new n56.TreeNodeChildrenManager<T, T2>(node: Node_In, childrenOrderingMatters: Children_Ordering_Matters_In, parentManagerProvider: Parent_Manager_Provider_In);
            Output_Out = Output_0;
            return;
        }

        public static void Dispose<T, T2>(n56.TreeNodeChildrenManager<T, T2> Input_In, out n56.TreeNodeChildrenManager<T, T2> Output_Out)
        {
            Input_In.Dispose();
            Output_Out = Input_In;
            return;
        }

        public static void Update<T, T2>(n56.TreeNodeChildrenManager<T, T2> Input_In, n5.Spread<T2> Children_In, out n56.TreeNodeChildrenManager<T, T2> Output_Out)
        {
            Input_In.Update(children: Children_In);
            Output_Out = Input_In;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Trees.Patching.TreeNodeParentManager.Advanced
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create<T, T2>(n1.NodeContext Node_Context, T Node_In, n2.Action<T2, T> Attach_To_New_Parent_In, n2.Action<T2, T> Detach_From_Current_Parent_In, out n56.TreeNodeParentManager<T2, T> Output_Out)
        {
            var Output_0 = new n56.TreeNodeParentManager<T2, T>(node: Node_In, attachToNewParent: Attach_To_New_Parent_In, detachFromCurrentParent: Detach_From_Current_Parent_In);
            Output_Out = Output_0;
            return;
        }

        public static void Dispose<T, T2>(n56.TreeNodeParentManager<T, T2> Input_In, out n56.TreeNodeParentManager<T, T2> Output_Out)
        {
            Input_In.Dispose();
            Output_Out = Input_In;
            return;
        }

        public static void ManyWannaBeParents<T, T2>(n56.TreeNodeParentManager<T, T2> Input_In, out n56.TreeNodeParentManager<T, T2> Output_Out, out bool Many_Wanna_Be_Parents_Out)
        {
            var Many_Wanna_Be_Parents_0 = Input_In.ManyWannaBeParents;
            Output_Out = Input_In;
            Many_Wanna_Be_Parents_Out = Many_Wanna_Be_Parents_0;
            return;
        }

        public static void ToggleWarning<T, T2>(n56.TreeNodeParentManager<T, T2> Input_In, out n56.TreeNodeParentManager<T, T2> Output_Out, out n58.Subject<bool> Toggle_Warning_Out)
        {
            var Toggle_Warning_0 = Input_In.ToggleWarning;
            Output_Out = Input_In;
            Toggle_Warning_Out = Toggle_Warning_0;
            return;
        }

        public static void SetAllowMultipleConnectionsToSameParent<T, T2>(n56.TreeNodeParentManager<T, T2> Input_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Allow_Multiple_Connections_To_Same_Parent_In, out n56.TreeNodeParentManager<T, T2> Output_Out)
        {
            Input_In.AllowMultipleConnectionsToSameParent = Allow_Multiple_Connections_To_Same_Parent_In;
            Output_Out = Input_In;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Trees.Command
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n61.ITraverseCommand CreateDefault_H()
        {
            var Fail_0 = n23.Trees.Fail;
            return Fail_0;
        }

        public static void IsFail(n61.ITraverseCommand Input_In, out bool Result_Out)
        {
            var Result_0 = n23.Trees.IsFail(command: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void TryGetNode<T>(n61.ITraverseCommand Input_In, out T Node_Out, out bool Success_Out)
            where T : n61.IReadOnlyTreeNode
        {
            n23.Trees.TryGetNode<T>(command: Input_In, node: out T Node_0, success: out bool Success_1);
            Node_Out = Node_0;
            Success_Out = Success_1;
            return;
        }

        public static void IsSuccess(n61.ITraverseCommand Input_In, out bool Result_Out)
        {
            var Result_0 = n23.Trees.IsSuccess(command: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void IsStop(n61.ITraverseCommand Input_In, out bool Result_Out)
        {
            var Result_0 = n23.Trees.IsStop(command: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void TryGetMessage<T>(n61.ITraverseCommand Input_In, out T Message_Out, out bool Success_Out)
        {
            n23.Trees.TryGetMessage<T>(command: Input_In, message: out T Message_0, success: out bool Success_1);
            Message_Out = Message_0;
            Success_Out = Success_1;
            return;
        }

        public static void IsGoOn(n61.ITraverseCommand Input_In, out bool Result_Out)
        {
            var Result_0 = n23.Trees.IsGoOn(command: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void IsOneUp(n61.ITraverseCommand Input_In, out bool Result_Out)
        {
            var Result_0 = n23.Trees.IsOneUp(command: Input_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Trees.Command.Continue
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void TraverseNode<T>(T Node_In, out n61.ITraverseCommand Result_Out)
            where T : n61.IReadOnlyTree<T>
        {
            var Result_0 = n23.Trees.TraverseNode<T>(node: Node_In);
            Result_Out = Result_0;
            return;
        }

        public static void TraverseNodeWithMessage<T2, T>(T2 Node_In, T Message_In, out n61.ITraverseCommand Result_Out)
            where T2 : n61.IReadOnlyTree<T2>
        {
            var Result_0 = n23.Trees.TraverseNodeWithMessage<T2, T>(node: Node_In, message: Message_In);
            Result_Out = Result_0;
            return;
        }

        public static void SkipChildrenButContinue(out n61.ITraverseCommand Result_Out)
        {
            var Skip_All_Childs_0 = n23.Trees.SkipAllChilds;
            Result_Out = Skip_All_Childs_0;
            return;
        }

        public static void TraverseChildren(out n61.ITraverseCommand Result_Out)
        {
            var Traverse_All_Childs_0 = n23.Trees.TraverseAllChilds;
            Result_Out = Traverse_All_Childs_0;
            return;
        }

        public static void TraverseChildrenWithMessage<T>(T Message_In, out n61.ITraverseCommand Result_Out)
        {
            var Result_0 = n23.Trees.TraverseAllChildsWithMessage<T>(message: Message_In);
            Result_Out = Result_0;
            return;
        }

        public static void OneUp(out n61.ITraverseCommand Result_Out)
        {
            var One_Up_0 = n23.Trees.OneUp;
            Result_Out = One_Up_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Trees.Command.Stop
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Fail(out n61.ITraverseCommand Result_Out)
        {
            var Fail_0 = n23.Trees.Fail;
            Result_Out = Fail_0;
            return;
        }

        public static void Return(out n61.ITraverseCommand Result_Out)
        {
            var Return_0 = n23.Trees.Return;
            Result_Out = Return_0;
            return;
        }

        public static void FailWithMessage<T>(T Message_In, out n61.ITraverseCommand Result_Out)
        {
            var Result_0 = n23.Trees.FailWithMessage<T>(message: Message_In);
            Result_Out = Result_0;
            return;
        }

        public static void ReturnWithMessage<T>(T Message_In, out n61.ITraverseCommand Result_Out)
        {
            var Result_0 = n23.Trees.ReturnWithMessage<T>(message: Message_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Collections_.Collections.Trees.IReadOnlyTreeNode
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Flatten(n61.IReadOnlyTreeNode Input_In, out n5.Spread<n61.IReadOnlyTreeNode> Result_Out)
        {
            var Result_0 = n61.ReadOnlyTreeNode.Flatten(input: Input_In);
            n7._Operations_.FromSequence<n61.IReadOnlyTreeNode>(Input_In: Result_0, Result_Out: out n5.Spread<n61.IReadOnlyTreeNode> Result_1);
            Result_Out = Result_1;
            return;
        }

        public static void HasChildren(n61.IReadOnlyTreeNode Input_In, out bool Result_Out)
        {
            var Result_0 = n61.ReadOnlyTreeNode.HasChildren(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void Traverse<T>(T Input_In, n2.Func<n61.IReadOnlyTreeNode, n61.ITraverseCommand> Update_In, out T Output_Out, out n61.ITraverseCommand Last_Command_Out)
            where T : n61.IReadOnlyTreeNode
        {
            n61.ReadOnlyTreeNode.Traverse<T>(input: Input_In, update: Update_In, output: out T Output_0, lastCommand: out n61.ITraverseCommand Last_Command_1);
            Output_Out = Output_0;
            Last_Command_Out = Last_Command_1;
            return;
        }

        public static void TraverseBreadthFirst<T>(T Input_In, n2.Func<n61.IReadOnlyTreeNode, n61.ITraverseCommand> Update_In, out T Output_Out)
            where T : n61.IReadOnlyTreeNode
        {
            n61.ReadOnlyTreeNode.TraverseBreadthFirst<T>(input: Input_In, update: Update_In, output: out T Output_0);
            Output_Out = Output_0;
            return;
        }

        public static void TraverseBreadthFirstMessageToChilds<T2, T>(T2 Input_In, T Message_In, n2.Func<n61.IReadOnlyTreeNode, T, n61.ITraverseCommand> Update_In, out T2 Output_Out)
            where T2 : n61.IReadOnlyTreeNode
        {
            n61.ReadOnlyTreeNode.TraverseBreadthFirstMessageToChilds<T2, T>(input: Input_In, message: Message_In, update: Update_In, output: out T2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public static void TraverseMessageToChilds<T2, T>(T2 Input_In, T Message_In, n2.Func<n61.IReadOnlyTreeNode, T, n61.ITraverseCommand> Update_In, out T2 Output_Out, out n61.ITraverseCommand Last_Command_Out)
            where T2 : n61.IReadOnlyTreeNode
        {
            n61.ReadOnlyTreeNode.TraverseMessageToChilds<T2, T>(input: Input_In, message: Message_In, update: Update_In, output: out T2 Output_0, lastCommand: out n61.ITraverseCommand Last_Command_1);
            Output_Out = Output_0;
            Last_Command_Out = Last_Command_1;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static n61.IReadOnlyTreeNode CreateDefault()
        {
            n1.NodeContext Node_Context_0 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "MoZKhPb1zpfOq0WOfkPDZB", 273981U);
            var Output_1 = n62.DummyTreeNode_C.Create(Node_Context: Node_Context_0);
            n61.IReadOnlyTreeNode Output_Out_2 = (n61.IReadOnlyTreeNode)Output_1;
            return Output_Out_2;
        }
    }
}

namespace _VL_Collections_.Collections.Trees.IReadOnlyTree
{
    [n1.ElementAttribute(TracingId = 274050U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "S3fE6WSfWlXNbz9jtATkZH", Name = "BuildUp_S3fE6WSfWlXNbz9jtATkZH")]
    [n2.SerializableAttribute]
    public class BuildUp_S3fE6WSfWlXNbz9jtATkZH<T> : n1.VLObject, n2.IDisposable where T : n61.IReadOnlyTree<T>
    {
        [n4.CreateNewAttribute]
        public static n63.BuildUp_S3fE6WSfWlXNbz9jtATkZH<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n18.IAdaptiveCreateDefault<T>
        {
            var instance = new BuildUp_S3fE6WSfWlXNbz9jtATkZH<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n63.BuildUp_S3fE6WSfWlXNbz9jtATkZH<T> CreateDefault<AdM>()
            where AdM : struct, n18.IAdaptiveCreateDefault<T>
        {
            var instance = new BuildUp_S3fE6WSfWlXNbz9jtATkZH<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n63.BuildUp_S3fE6WSfWlXNbz9jtATkZH<T> Update<AdM>(T Input_In, n2.Action<T> Update_In, [n4.SerializedDefaultValueAttribute("8", false)] int Max_Level_Count_In, bool Trigger_In, out T Output_Out, out bool Success_Out)
            where AdM : struct, n18.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_FwNSZQyz3CgNNmoV3SNnPy;
            if (manager_2 is null)
            {
                w_0.CreateDefault(out T __out_0);
                manager_2 = new n42.Manager<n2.ValueTuple, n2.ValueTuple<T, bool>>((__out_0, false));
            }

            var inputs_3 = n2.ValueTuple.Create();
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Trigger_In || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                int Message_7 = 0;
                var __fallback___8 = n1.ServiceRegistry.Current;
                n63._Operations_.Traverse_MessageToChilds<T, int>(Input_In: Input_In, Message_In: Message_7, Update_In: (T Node_In_10, int Arg_2_In_11) =>
                {
                    using var __current_9 = __fallback___8.MakeCurrentIfNone();
                    n64._Operations_.Invoke<T>(Input_In: Update_In, Arg_In: Node_In_10);
                    var Output_12 = n10.Integer32Extensions.Inc(input: Arg_2_In_11);
                    n65._Operations_.TraverseChildrenWithMessage<int>(Message_In: Output_12, Result_Out: out n61.ITraverseCommand Result_13);
                    var Result_14 = Arg_2_In_11 < Max_Level_Count_In;
                    var Skip_All_Childs_15 = n23.Trees.SkipAllChilds;
                    n14._Operations_.Switch_Boolean<n61.ITraverseCommand>(Condition_In: Result_14, Input_In: Skip_All_Childs_15, Input_2_In: Result_13, Output_Out: out n61.ITraverseCommand Output_16);
                    return Output_16;
                }

                , Output_Out: out T Output_17, Last_Command_Out: out n61.ITraverseCommand Last_Command_18);
                var Result_19 = n23.Trees.IsSuccess(command: Last_Command_18);
                outputs_4 = (Output_17, Result_19);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_20, __auto_21) = outputs_4;
            Output_Out = __auto_20;
            Success_Out = __auto_21;
            n63.BuildUp_S3fE6WSfWlXNbz9jtATkZH<T> that_22 = this;
            if (this.__GetContext__().IsImmutable)
                that_22 = manager_2 != this.__cache_FwNSZQyz3CgNNmoV3SNnPy ? new BuildUp_S3fE6WSfWlXNbz9jtATkZH<T>(this)
                {__cache_FwNSZQyz3CgNNmoV3SNnPy = manager_2} : that_22;
            else
            {
                this.__cache_FwNSZQyz3CgNNmoV3SNnPy = manager_2;
            }

            return that_22;
        }

        public n63.BuildUp_S3fE6WSfWlXNbz9jtATkZH<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n18.IAdaptiveCreateDefault<T>
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n63.BuildUp_S3fE6WSfWlXNbz9jtATkZH<T> that_1 = this;
            this.__cache_FwNSZQyz3CgNNmoV3SNnPy = null;
            return that_1;
        }

        public n63.BuildUp_S3fE6WSfWlXNbz9jtATkZH<T> __CreateDefault__<AdM>()
            where AdM : struct, n18.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n63.BuildUp_S3fE6WSfWlXNbz9jtATkZH<T> that_1 = this;
            this.__cache_FwNSZQyz3CgNNmoV3SNnPy = null;
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_FwNSZQyz3CgNNmoV3SNnPy);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 274058U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "FwNSZQyz3CgNNmoV3SNnPy", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n42.Manager<n2.ValueTuple, n2.ValueTuple<T, bool>> __cache_FwNSZQyz3CgNNmoV3SNnPy = null;
        public BuildUp_S3fE6WSfWlXNbz9jtATkZH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BuildUp_S3fE6WSfWlXNbz9jtATkZH(BuildUp_S3fE6WSfWlXNbz9jtATkZH<T> other): base(other)
        {
            this.__cache_FwNSZQyz3CgNNmoV3SNnPy = other.__cache_FwNSZQyz3CgNNmoV3SNnPy;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_FwNSZQyz3CgNNmoV3SNnPy", in __cache_FwNSZQyz3CgNNmoV3SNnPy));
        }

        internal BuildUp_S3fE6WSfWlXNbz9jtATkZH<T> __WITH__(n42.Manager<n2.ValueTuple, n2.ValueTuple<T, bool>> __cache_FwNSZQyz3CgNNmoV3SNnPy)
        {
            n63.BuildUp_S3fE6WSfWlXNbz9jtATkZH<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_FwNSZQyz3CgNNmoV3SNnPy != this.__cache_FwNSZQyz3CgNNmoV3SNnPy ? new BuildUp_S3fE6WSfWlXNbz9jtATkZH<T>(this)
                {__cache_FwNSZQyz3CgNNmoV3SNnPy = __cache_FwNSZQyz3CgNNmoV3SNnPy} : that_0;
            else
            {
                this.__cache_FwNSZQyz3CgNNmoV3SNnPy = __cache_FwNSZQyz3CgNNmoV3SNnPy;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Flatten<T>(T Input_In, out n5.Spread<T> Result_Out)
            where T : n61.IReadOnlyTree<T>
        {
            var Result_0 = n61.ReadOnlyTree.Flatten<T>(input: Input_In);
            n7._Operations_.FromSequence<T>(Input_In: Result_0, Result_Out: out n5.Spread<T> Result_1);
            Result_Out = Result_1;
            return;
        }

        public static void Traverse<T>(T Input_In, n2.Func<T, n61.ITraverseCommand> Update_In, out T Output_Out, out n61.ITraverseCommand Last_Command_Out)
            where T : n61.IReadOnlyTree<T>
        {
            n61.ReadOnlyTree.Traverse<T>(input: Input_In, update: Update_In, output: out T Output_0, lastCommand: out n61.ITraverseCommand Last_Command_1);
            Output_Out = Output_0;
            Last_Command_Out = Last_Command_1;
            return;
        }

        public static void Traverse_BreadthFirst<T>(T Input_In, n2.Func<T, n61.ITraverseCommand> Update_In, out T Output_Out)
            where T : n61.IReadOnlyTree<T>
        {
            n61.ReadOnlyTree.TraverseBreadthFirst<T>(input: Input_In, update: Update_In, output: out T Output_0);
            Output_Out = Output_0;
            return;
        }

        public static void Traverse_BreadthFirst_MessageToChilds<T2, T>(T2 Input_In, T Message_In, n2.Func<T2, T, n61.ITraverseCommand> Update_In, out T2 Output_Out)
            where T2 : n61.IReadOnlyTree<T2>
        {
            n61.ReadOnlyTree.TraverseBreadthFirstMessageToChilds<T2, T>(input: Input_In, message: Message_In, update: Update_In, output: out T2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public static void Traverse_MessageToChilds<T2, T>(T2 Input_In, T Message_In, n2.Func<T2, T, n61.ITraverseCommand> Update_In, out T2 Output_Out, out n61.ITraverseCommand Last_Command_Out)
            where T2 : n61.IReadOnlyTree<T2>
        {
            n61.ReadOnlyTree.TraverseMessageToChilds<T2, T>(input: Input_In, message: Message_In, update: Update_In, output: out T2 Output_0, lastCommand: out n61.ITraverseCommand Last_Command_1);
            Output_Out = Output_0;
            Last_Command_Out = Last_Command_1;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static n61.IReadOnlyTree<T> CreateDefault<T>()
            where T : n61.IReadOnlyTree<T>
        {
            n1.NodeContext Node_Context_0 = n1.NodeContext.Default.CreateSubContext("CsYvmiCXzFgMbCg5YvFjkW", "AsNcyNJaiVQPGVapuVjKMV", 274145U);
            var Output_1 = n62.DummyTree_C<T>.Create(Node_Context: Node_Context_0);
            n61.IReadOnlyTree<T> Output_Out_2 = (n61.IReadOnlyTree<T>)Output_1;
            return Output_Out_2;
        }
    }
}

namespace _VL_Collections_.Collections.Trees.Internal
{
    [n1.ElementAttribute(TracingId = 274156U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "OwrcsPMTEYiLW28qrcb1i0", Name = "DummyTreeNode_C")]
    [n2.SerializableAttribute]
    public class DummyTreeNode_C : n1.VLObject, n61.IReadOnlyTreeNode, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n62.DummyTreeNode_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new DummyTreeNode_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n62.DummyTreeNode_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new DummyTreeNode_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n62.DummyTreeNode_C Children_(out n6.IReadOnlyList<n61.IReadOnlyTreeNode> Children_Out)
        {
            n6.IReadOnlyList<n61.IReadOnlyTreeNode> __auto_0 = this.Children;
            Children_Out = __auto_0;
            return this;
        }

        public n62.DummyTreeNode_C __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Children = n16._Operations_.CreateDefault<n61.IReadOnlyTreeNode>();
            return this;
        }

        public n62.DummyTreeNode_C __CreateDefault__()
        {
            this.Children = n16._Operations_.CreateDefault<n61.IReadOnlyTreeNode>();
            return this;
        }

        public void Dispose()
        {
            return;
        }

        n6.IReadOnlyList<n61.IReadOnlyTreeNode> n61.IReadOnlyTreeNode.Children
        {
            get
            {
                using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
                var __returnValue__ = Children_(out n6.IReadOnlyList<n61.IReadOnlyTreeNode> out_Children_Out);
                return out_Children_Out;
            }
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 274161U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "PM2u9YfjFliLhOQngpvRVx", Name = "Children")]
        public n6.IReadOnlyList<n61.IReadOnlyTreeNode> Children;
        public DummyTreeNode_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DummyTreeNode_C(DummyTreeNode_C other): base(other)
        {
            this.Children = other.Children;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Children", in Children));
        }

        internal DummyTreeNode_C __WITH__(n6.IReadOnlyList<n61.IReadOnlyTreeNode> Children)
        {
            n62.DummyTreeNode_C that_0 = this;
            this.Children = Children;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 274170U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "AQ6qm5pzx6YOh0mgYBb0g7", Name = "DummyTree_C")]
    [n2.SerializableAttribute]
    public class DummyTree_C<T> : n1.VLObject, n61.IReadOnlyTree<T>, n2.IDisposable where T : n61.IReadOnlyTree<T>
    {
        [n4.CreateNewAttribute]
        public static n62.DummyTree_C<T> Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new DummyTree_C<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n62.DummyTree_C<T> CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new DummyTree_C<T>(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n62.DummyTree_C<T> Children_(out n6.IReadOnlyList<T> Children_Out)
        {
            n6.IReadOnlyList<T> __auto_0 = this.Children;
            Children_Out = __auto_0;
            return this;
        }

        public n62.DummyTree_C<T> __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Children = n16._Operations_.CreateDefault<T>();
            return this;
        }

        public n62.DummyTree_C<T> __CreateDefault__()
        {
            this.Children = n16._Operations_.CreateDefault<T>();
            return this;
        }

        public void Dispose()
        {
            return;
        }

        n6.IReadOnlyList<T> n61.IReadOnlyTree<T>.Children
        {
            get
            {
                using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
                var __returnValue__ = Children_(out n6.IReadOnlyList<T> out_Children_Out);
                return out_Children_Out;
            }
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        n6.IReadOnlyList<n61.IReadOnlyTreeNode> n61.IReadOnlyTreeNode.Children
        {
            get
            {
                using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
                var __returnValue__ = Children_(out n6.IReadOnlyList<T> out_Children_Out);
                return n16._Operations_.CreateDefault<n61.IReadOnlyTreeNode>();
            }
        }

        [n1.ElementAttribute(TracingId = 274175U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "P4FUC67zlijLObZGH6ZvyW", Name = "Children")]
        public n6.IReadOnlyList<T> Children;
        public DummyTree_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DummyTree_C(DummyTree_C<T> other): base(other)
        {
            this.Children = other.Children;
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Children", in Children));
        }

        internal DummyTree_C<T> __WITH__(n6.IReadOnlyList<T> Children)
        {
            n62.DummyTree_C<T> that_0 = this;
            this.Children = Children;
            return that_0;
        }
    }
}

namespace _VL_Collections_.Collections.IReadOnlyList
{
    [n1.ElementAttribute(TracingId = 260345U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n5.Spread<T> CreateDefault<T>()
        {
            n7._Operations_.Empty<T>(Empty_Out: out n5.Spread<T> Empty_0);
            return Empty_0;
        }

        public static void Count<T>(n6.IReadOnlyList<T> Input_In, out n6.IReadOnlyList<T> Output_Out, out int Count_Out)
        {
            n6.IReadOnlyCollection<T> Input_0 = (n6.IReadOnlyCollection<T>)Input_In;
            var Count_1 = Input_0.Count;
            Output_Out = Input_In;
            Count_Out = Count_1;
            return;
        }

        public static void ToImage<T>(n6.IReadOnlyList<T> Input_In, int Width_In, int Height_In, n41.PixelFormat Format_In, string Original_Format_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Is_Volatile_In, out n41.IImage Result_Out)
            where T : struct
        {
            var Result_0 = n41.ImageExtensions.ToImage<T>(data: Input_In, width: Width_In, height: Height_In, format: Format_In, originalFormat: Original_Format_In, isVolatile: Is_Volatile_In);
            Result_Out = Result_0;
            return;
        }

        public static void GetList<T>(n6.IReadOnlyList<T> Input_In, int Index_In, int Count_In, out n6.IReadOnlyList<T> Output_Out)
        {
            var Output_0 = n23.CollectionNodes.GetList<T>(input: Input_In, index: Index_In, count: Count_In);
            Output_Out = Output_0;
            return;
        }

        public static void GetSlice<T>(n6.IReadOnlyList<T> Input_In, T Default_Value_In, int Index_In, out T Result_Out)
        {
            var Result_0 = n23.CollectionNodes.GetSlice<T>(input: Input_In, defaultValue: Default_Value_In, index: Index_In);
            Result_Out = Result_0;
            return;
        }

        public static void Pairwise<T, T2>(n6.IReadOnlyList<T> Input_In, n2.Func<T, T, T2> Selector_In, out n6.IReadOnlyList<T2> Output_Out)
        {
            var Output_0 = n23.CollectionNodes.Pairwise<T, T2>(input: Input_In, selector: Selector_In);
            Output_Out = Output_0;
            return;
        }
    }
}

namespace _VL_Collections_
{
    [n1.ElementAttribute(TracingId = 274265U, DocumentId = "CsYvmiCXzFgMbCg5YvFjkW", PersistentId = "OSaGmia5DZRLHgXGyUAbs3", Name = "VL_CollectionsApplication_OSaGmia5DZRLHgXGyUAbs3")]
    [n2.SerializableAttribute]
    public class VL_CollectionsApplication_OSaGmia5DZRLHgXGyUAbs3 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n12.VL_CollectionsApplication_OSaGmia5DZRLHgXGyUAbs3 Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_CollectionsApplication_OSaGmia5DZRLHgXGyUAbs3(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n12.VL_CollectionsApplication_OSaGmia5DZRLHgXGyUAbs3 CreateDefault()
        {
            var instance = new VL_CollectionsApplication_OSaGmia5DZRLHgXGyUAbs3(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n12.VL_CollectionsApplication_OSaGmia5DZRLHgXGyUAbs3 Update()
        {
            return this;
        }

        public n12.VL_CollectionsApplication_OSaGmia5DZRLHgXGyUAbs3 __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n12.VL_CollectionsApplication_OSaGmia5DZRLHgXGyUAbs3 __CreateDefault__()
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

        public VL_CollectionsApplication_OSaGmia5DZRLHgXGyUAbs3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_CollectionsApplication_OSaGmia5DZRLHgXGyUAbs3(VL_CollectionsApplication_OSaGmia5DZRLHgXGyUAbs3 other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n6.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_CollectionsApplication_OSaGmia5DZRLHgXGyUAbs3 __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Collections_
{
    public struct __AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW : n19.IAdaptiveOperatorGreater<int>, n19.IAdaptiveOperatorLess<int>, n19.IAdaptiveOperatorMinus<float>, n19.IAdaptiveOperatorDivide<float>, n19.IAdaptiveOperatorMulitply<float>, n19.IAdaptiveOperatorPlus<float>, n19.IAdaptiveOperatorMinus<n26.Vector2>, n19.IAdaptiveOperatorDivide<n26.Vector2>, n19.IAdaptiveOperatorMulitply<n26.Vector2>, n19.IAdaptiveOperatorPlus<n26.Vector2>, n19.IAdaptiveOne<n26.Vector2>, n19.IAdaptiveZero<n26.Vector2>, n18.IAdaptiveCreateDefault<n26.Vector2>, n19.IAdaptiveOperatorMulitply_Scale<n26.Vector2>, n19.IAdaptiveOperatorMinus<n26.Vector3>, n19.IAdaptiveOperatorDivide<n26.Vector3>, n19.IAdaptiveOperatorMulitply<n26.Vector3>, n19.IAdaptiveOperatorPlus<n26.Vector3>, n19.IAdaptiveOne<n26.Vector3>, n19.IAdaptiveZero<n26.Vector3>, n18.IAdaptiveCreateDefault<n26.Vector3>, n19.IAdaptiveOperatorMulitply_Scale<n26.Vector3>, n19.IAdaptiveOperatorMinus<n26.Vector4>, n19.IAdaptiveOperatorDivide<n26.Vector4>, n19.IAdaptiveOperatorMulitply<n26.Vector4>, n19.IAdaptiveOperatorPlus<n26.Vector4>, n19.IAdaptiveOne<n26.Vector4>, n19.IAdaptiveZero<n26.Vector4>, n18.IAdaptiveCreateDefault<n26.Vector4>, n19.IAdaptiveOperatorMulitply_Scale<n26.Vector4>, n18.IAdaptiveCreateDefault<n5.Spread<float>>, n19.IAdaptiveOperatorMulitply_Scale<float>, n19.IAdaptiveLerp<float>, n18.IAdaptiveCreateDefault<float>, n18.IAdaptiveCreateDefault<bool>, n18.IAdaptiveCreateDefault<int>, n18.IAdaptiveCreateDefault<n53.Stream>, n18.IAdaptiveCreateDefault<n6.KeyValuePair<float, int>>, n18.IAdaptiveCreateDefault<n61.ITraverseCommand>
    {
        public void OperatorGreater(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In > Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void OperatorLess(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void OperatorMinus(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In - Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = (float)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In * Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In + Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus(n26.Vector2 Input_In, n26.Vector2 Input_2_In, out n26.Vector2 Output_Out)
        {
            n26.Vector2.Subtract(left: ref Input_In, right: ref Input_2_In, result: out n26.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide(n26.Vector2 Input_In, n26.Vector2 Input_2_In, out n26.Vector2 Output_Out)
        {
            var Output_0 = (n26.Vector2)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply(n26.Vector2 Input_In, n26.Vector2 Input_2_In, out n26.Vector2 Output_Out)
        {
            n27.Vector2Nodes.Multiply(left: ref Input_In, right: ref Input_2_In, result: out n26.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(n26.Vector2 Input_In, n26.Vector2 Input_2_In, out n26.Vector2 Output_Out)
        {
            n26.Vector2.Add(left: ref Input_In, right: ref Input_2_In, result: out n26.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void One(out n26.Vector2 One_Out)
        {
            var One_0 = n26.Vector2.One;
            One_Out = One_0;
            return;
        }

        public void Zero(out n26.Vector2 Zero_Out)
        {
            var Zero_0 = n26.Vector2.Zero;
            Zero_Out = Zero_0;
            return;
        }

        public void CreateDefault(out n26.Vector2 Output_Out)
        {
            var Zero_0 = n33._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }

        public void OperatorMulitply_Scale(n26.Vector2 Input_In, float Scalar_In, out n26.Vector2 Output_Out)
        {
            n27.Vector2Nodes.Scale(input: ref Input_In, scalar: Scalar_In, output: out n26.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus(n26.Vector3 Input_In, n26.Vector3 Input_2_In, out n26.Vector3 Output_Out)
        {
            n26.Vector3.Subtract(left: ref Input_In, right: ref Input_2_In, result: out n26.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide(n26.Vector3 Input_In, n26.Vector3 Input_2_In, out n26.Vector3 Output_Out)
        {
            var Output_0 = (n26.Vector3)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply(n26.Vector3 Input_In, n26.Vector3 Input_2_In, out n26.Vector3 Output_Out)
        {
            n27.Vector3Nodes.Multiply(left: ref Input_In, right: ref Input_2_In, result: out n26.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(n26.Vector3 Input_In, n26.Vector3 Input_2_In, out n26.Vector3 Output_Out)
        {
            n26.Vector3.Add(left: ref Input_In, right: ref Input_2_In, result: out n26.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void One(out n26.Vector3 One_Out)
        {
            var One_0 = n26.Vector3.One;
            One_Out = One_0;
            return;
        }

        public void Zero(out n26.Vector3 Zero_Out)
        {
            var Zero_0 = n26.Vector3.Zero;
            Zero_Out = Zero_0;
            return;
        }

        public void CreateDefault(out n26.Vector3 Output_Out)
        {
            var Zero_0 = n66._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }

        public void OperatorMulitply_Scale(n26.Vector3 Input_In, float Scalar_In, out n26.Vector3 Output_Out)
        {
            n27.Vector3Nodes.Scale(input: ref Input_In, scalar: Scalar_In, output: out n26.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus(n26.Vector4 Input_In, n26.Vector4 Input_2_In, out n26.Vector4 Output_Out)
        {
            n26.Vector4.Subtract(left: ref Input_In, right: ref Input_2_In, result: out n26.Vector4 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide(n26.Vector4 Input_In, n26.Vector4 Input_2_In, out n26.Vector4 Output_Out)
        {
            var Output_0 = (n26.Vector4)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply(n26.Vector4 Input_In, n26.Vector4 Input_2_In, out n26.Vector4 Output_Out)
        {
            n27.Vector4Nodes.Multiply(left: ref Input_In, right: ref Input_2_In, result: out n26.Vector4 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(n26.Vector4 Input_In, n26.Vector4 Input_2_In, out n26.Vector4 Output_Out)
        {
            n26.Vector4.Add(left: ref Input_In, right: ref Input_2_In, result: out n26.Vector4 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void One(out n26.Vector4 One_Out)
        {
            var One_0 = n26.Vector4.One;
            One_Out = One_0;
            return;
        }

        public void Zero(out n26.Vector4 Zero_Out)
        {
            var Zero_0 = n26.Vector4.Zero;
            Zero_Out = Zero_0;
            return;
        }

        public void CreateDefault(out n26.Vector4 Output_Out)
        {
            var Unit_W_0 = n67._Operations_.CreateDefault();
            Output_Out = Unit_W_0;
            return;
        }

        public void OperatorMulitply_Scale(n26.Vector4 Input_In, float Scalar_In, out n26.Vector4 Output_Out)
        {
            n27.Vector4Nodes.Scale(input: ref Input_In, scalar: Scalar_In, output: out n26.Vector4 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n5.Spread<float> Output_Out)
        {
            var Empty_0 = n7._Operations_.CreateDefault<float>();
            Output_Out = Empty_0;
            return;
        }

        public void OperatorMulitply_Scale(float Input_In, float Scalar_In, out float Output_Out)
        {
            var Output_0 = n10.Float32Extensions.Scale(input: Input_In, scalar: Scalar_In);
            Output_Out = Output_0;
            return;
        }

        public void Lerp(float Input_In, float Input_2_In, float Scalar_In, out float Output_Out)
        {
            var Output_0 = n10.Float32Extensions.Lerp(input: Input_In, input2: Input_2_In, scalar: Scalar_In);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out float Output_Out)
        {
            n68._Operations_.CreateDefault_Generic<float>(Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out bool Output_Out)
        {
            n68._Operations_.CreateDefault_Generic<bool>(Output_Out: out bool Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out int Output_Out)
        {
            n68._Operations_.CreateDefault_Generic<int>(Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n53.Stream Output_Out)
        {
            var Null_0 = n69._Operations_.CreateDefault();
            Output_Out = Null_0;
            return;
        }

        public void CreateDefault(out n6.KeyValuePair<float, int> Output_Out)
        {
            var Output_0 = n20._Operations_.CreateDefault<float, int, n12.__AdaptiveImplementations__CsYvmiCXzFgMbCg5YvFjkW>();
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n61.ITraverseCommand Output_Out)
        {
            var Output_0 = n70._Operations_.CreateDefault_H();
            Output_Out = Output_0;
            return;
        }
    }
}