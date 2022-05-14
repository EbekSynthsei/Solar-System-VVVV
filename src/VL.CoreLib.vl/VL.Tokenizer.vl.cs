extern alias e2;
extern alias e5;

using n6 = _CoreLibBasics_.Control.Advanced;
using n18 = e2::VL.Lib.Collections;
using n17 = e2::VL.Lib.Primitive;
using n24 = _VL_Collections_.Collections;
using n7 = _VL_Collections_.Collections.Builder.SpreadBuilder.Advanced;
using n25 = _CoreLibBasics_.Control;
using n16 = e2::VL.Lib.Text;
using n10 = _VL_Tokenizer_.IO.Advanced;
using n23 = _VL_Tokenizer_;
using n28 = _VL_Reactive_.Reactive.Sampler;
using n30 = _CoreLibBasics_.Primitive.String;
using n19 = _CoreLibBasics_.Primitive;
using n11 = e5::VL.Core.CompilerServices;
using n4 = global::System.Collections.Generic;
using n12 = _VL_Tokenizer_.IO.Tokenizer.Advanced;
using n14 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n20 = _VL_Tokenizer_.IO;
using n22 = _VL_Reactive_.Reactive.ForEach_Keep;
using n21 = e2::VL.Lib.Reactive;
using n1 = e5::VL.Core;
using n26 = _VL_Tokenizer_.IO.Tokenizer_LengthPrefix;
using n9 = global::System;
using n13 = _CoreLibBasics_.Primitive.Delegates.Delegate__1_MG_1.Advanced;
using n8 = _VL_Collections_.Collections.Mutable.MutableArray.Advanced;
using n27 = _VL_Reactive_.Reactive.HoldLatest;
using n5 = _VL_Collections_.Collections.Sequence;
using n15 = global::System.Runtime.CompilerServices;
using n2 = e5::VL.Lib.Collections;
using n3 = _VL_Collections_.Collections.Spread;
using n29 = _CoreLibBasics_.Primitive.Advanced;

namespace _VL_Tokenizer_.IO
{
    [n1.ElementAttribute(TracingId = 258618U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "MzjqKVRPaSGPzFUlLZkwS2", Name = "Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2")]
    [n9.SerializableAttribute]
    public class Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 : n1.VLObject, n9.IDisposable
    {
        [n11.CreateNewAttribute]
        public static n20.Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 Create(n1.NodeContext Node_Context)
        {
            var instance = new Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n11.CreateDefaultAttribute]
        public static n20.Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 CreateDefault()
        {
            var instance = new Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n20.Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 Update(n4.IEnumerable<byte> Data_In, n4.IEnumerable<byte> Postfix_In, bool Reset_In, out n2.Spread<n2.Spread<byte>> Result_Out, out int Buffer_Size_Out, out string Status_Out)
        {
            n5._Operations_.None<byte>(Input_In: Postfix_In, Result_Out: out bool Result_0);
            n4.IEnumerable<byte> Input_2_1 = n5._Operations_.CreateDefault<byte>();
            n6._Operations_.Switch_Boolean<n4.IEnumerable<byte>>(Condition_In: Result_0, Input_In: Data_In, Input_2_In: Input_2_1, Output_Out: out n4.IEnumerable<byte> Output_2);
            n5._Operations_.Count<byte>(Input_In: Postfix_In, Result_Out: out int Result_3);
            var __fallback___4 = n1.ServiceRegistry.Current;
            n9.Func<n2.SpreadBuilder<byte>, n12.Result_C<n2.Spread<byte>>> Functionality_24 = (n2.SpreadBuilder<byte> Arg_In_6) =>
            {
                using var __current_5 = __fallback___4.MakeCurrentIfNone();
                bool __pad_Ca6pOK8eN3tNfbFxIec6NV_7 = __slot_Ca6pOK8eN3tNfbFxIec6NV;
                bool __pad_Gqi4oKPDDTDNb0LOdpqC6d_8 = __slot_Gqi4oKPDDTDNb0LOdpqC6d;
                n4.IEnumerable<byte> Input_9 = (n4.IEnumerable<byte>)Arg_In_6;
                n12._Operations_.Contains(Input_In: Input_9, Separator_In: Postfix_In, Output_Out: out bool Output_10, Position_Out: out int Position_11);
                int Bytes_Count_12;
                n2.Spread<byte> Token_13;
                bool __auto_14;
                bool __auto_15;
                if (Output_10)
                {
                    bool __pad_DQMd85NXLv8Nq1Ozn7nCUm_16 = __slot_DQMd85NXLv8Nq1Ozn7nCUm;
                    bool __pad_Ug2duLQTy3mLpzzEjDjSvM_17 = __slot_Ug2duLQTy3mLpzzEjDjSvM;
                    n7._Operations_.ToSpread<byte>(Input_In: Arg_In_6, Output_Out: out n2.SpreadBuilder<byte> Output_18, Result_Out: out n2.Spread<byte> Result_19);
                    n3._Operations_.Take<byte>(Input_In: Result_19, Count_In: Position_11, Output_Out: out n2.Spread<byte> Output_20);
                    Token_13 = Output_20;
                    var Output_21 = Position_11 + Result_3;
                    Bytes_Count_12 = Output_21;
                    __auto_14 = __pad_DQMd85NXLv8Nq1Ozn7nCUm_16;
                    __auto_15 = __pad_Ug2duLQTy3mLpzzEjDjSvM_17;
                }
                else
                {
                    Bytes_Count_12 = 0;
                    Token_13 = n3._Operations_.CreateDefault<byte>();
                    __auto_14 = false;
                    __auto_15 = __pad_Gqi4oKPDDTDNb0LOdpqC6d_8;
                }

                n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "Lbm6wuCMCmMOZmzXLsGxNk", 258815U);
                var Output_23 = n12.Result_C<n2.Spread<byte>>.Create<n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>(Node_Context: Node_Context_22, Token_In: Token_13, Token_Is_Valid_In: __auto_14, Byte_Count_In: Bytes_Count_12, Collecting_In: __pad_Ca6pOK8eN3tNfbFxIec6NV_7, Needs_More_Input_In: __auto_15);
                return Output_23;
            }

            ;
            var Output_27 = this.__p_OBSchJlm8x0MtOo8NKlcc7.Update<n4.IEnumerable<byte>>(Value_In: Postfix_In, Result_Out: out bool Result_25, Unchanged_Out: out bool Unchanged_26);
            var Output_28 = Reset_In || Result_25;
            var Output_32 = this.__p_GTN3mokc1MtLhNWJzQw4PU.Update<n4.IEnumerable<byte>, n2.Spread<byte>, n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>(Data_In: Output_2, Tokenize_In: Functionality_24, Reset_In: Output_28, Result_Out: out n2.Spread<n2.Spread<byte>> Result_29, Buffer_Size_Out: out int Buffer_Size_30, Status_Out: out string Status_31);
            Result_Out = Result_29;
            Buffer_Size_Out = Buffer_Size_30;
            Status_Out = Status_31;
            n20.Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 that_33 = this;
            if (this.__GetContext__().IsImmutable)
                that_33 = Output_27 != this.__p_OBSchJlm8x0MtOo8NKlcc7 || Output_32 != this.__p_GTN3mokc1MtLhNWJzQw4PU ? new Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2(this)
                {__p_OBSchJlm8x0MtOo8NKlcc7 = Output_27, __p_GTN3mokc1MtLhNWJzQw4PU = Output_32} : that_33;
            else
            {
                this.__p_OBSchJlm8x0MtOo8NKlcc7 = Output_27;
                this.__p_GTN3mokc1MtLhNWJzQw4PU = Output_32;
            }

            return that_33;
        }

        public n20.Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 __Create__(n1.NodeContext Node_Context)
        {
            n15.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "OBSchJlm8x0MtOo8NKlcc7", 258633U);
            var Output_1 = n24.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<byte>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "GTN3mokc1MtLhNWJzQw4PU", 258657U);
            var Output_3 = n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte>.Create(Node_Context: Node_Context_2);
            n20.Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 that_4 = this;
            this.__p_OBSchJlm8x0MtOo8NKlcc7 = Output_1;
            this.__p_GTN3mokc1MtLhNWJzQw4PU = Output_3;
            return that_4;
        }

        public n20.Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 __CreateDefault__()
        {
            n20.Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 that_0 = this;
            this.__p_OBSchJlm8x0MtOo8NKlcc7 = n24.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<byte>.CreateDefault();
            this.__p_GTN3mokc1MtLhNWJzQw4PU = n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_OBSchJlm8x0MtOo8NKlcc7);
            n1.CompilationHelper.SafeDispose(this.__p_GTN3mokc1MtLhNWJzQw4PU);
            return;
        }

        void n9.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 258837U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "Ca6pOK8eN3tNfbFxIec6NV", Name = "__slot_Ca6pOK8eN3tNfbFxIec6NV")]
        public static bool __slot_Ca6pOK8eN3tNfbFxIec6NV = true;
        [n1.ElementAttribute(TracingId = 258842U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "Gqi4oKPDDTDNb0LOdpqC6d", Name = "__slot_Gqi4oKPDDTDNb0LOdpqC6d")]
        public static bool __slot_Gqi4oKPDDTDNb0LOdpqC6d = true;
        [n1.ElementAttribute(TracingId = 258788U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "DQMd85NXLv8Nq1Ozn7nCUm", Name = "__slot_DQMd85NXLv8Nq1Ozn7nCUm")]
        public static bool __slot_DQMd85NXLv8Nq1Ozn7nCUm = true;
        [n1.ElementAttribute(TracingId = 258796U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "Ug2duLQTy3mLpzzEjDjSvM", Name = "__slot_Ug2duLQTy3mLpzzEjDjSvM")]
        public static bool __slot_Ug2duLQTy3mLpzzEjDjSvM = false;
        [n1.ElementAttribute(TracingId = 258633U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "OBSchJlm8x0MtOo8NKlcc7", Name = "SequenceChanged", IsManaged = true, IsAutoGenerated = true)]
        public n24.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<byte> __p_OBSchJlm8x0MtOo8NKlcc7;
        [n1.ElementAttribute(TracingId = 258657U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "GTN3mokc1MtLhNWJzQw4PU", Name = "Tokenizer", IsManaged = true, IsAutoGenerated = true)]
        public n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte> __p_GTN3mokc1MtLhNWJzQw4PU;
        static Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2()
        {
        }

        public Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2(Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 other): base(other)
        {
            this.__p_OBSchJlm8x0MtOo8NKlcc7 = other.__p_OBSchJlm8x0MtOo8NKlcc7;
            this.__p_GTN3mokc1MtLhNWJzQw4PU = other.__p_GTN3mokc1MtLhNWJzQw4PU;
        }

        protected override n1.IVLObject __With__(n4.IReadOnlyDictionary<string, n9.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_OBSchJlm8x0MtOo8NKlcc7", in __p_OBSchJlm8x0MtOo8NKlcc7), n1.CompilationHelper.GetValueOrExisting(values, "__p_GTN3mokc1MtLhNWJzQw4PU", in __p_GTN3mokc1MtLhNWJzQw4PU));
        }

        internal Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 __WITH__(n24.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<byte> __p_OBSchJlm8x0MtOo8NKlcc7, n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte> __p_GTN3mokc1MtLhNWJzQw4PU)
        {
            n20.Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_OBSchJlm8x0MtOo8NKlcc7 != this.__p_OBSchJlm8x0MtOo8NKlcc7 || __p_GTN3mokc1MtLhNWJzQw4PU != this.__p_GTN3mokc1MtLhNWJzQw4PU ? new Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2(this)
                {__p_OBSchJlm8x0MtOo8NKlcc7 = __p_OBSchJlm8x0MtOo8NKlcc7, __p_GTN3mokc1MtLhNWJzQw4PU = __p_GTN3mokc1MtLhNWJzQw4PU} : that_0;
            else
            {
                this.__p_OBSchJlm8x0MtOo8NKlcc7 = __p_OBSchJlm8x0MtOo8NKlcc7;
                this.__p_GTN3mokc1MtLhNWJzQw4PU = __p_GTN3mokc1MtLhNWJzQw4PU;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 259002U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "S9LmNU1FHynOjIAYRsBjPm", Name = "Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm")]
    [n9.SerializableAttribute]
    public class Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm : n1.VLObject, n9.IDisposable
    {
        [n11.CreateNewAttribute]
        public static n20.Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm Create(n1.NodeContext Node_Context)
        {
            var instance = new Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n11.CreateDefaultAttribute]
        public static n20.Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm CreateDefault()
        {
            var instance = new Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n20.Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm Update(n4.IEnumerable<byte> Data_In, n4.IEnumerable<byte> Prefix_In, n4.IEnumerable<byte> Postfix_In, bool Reset_In, out n2.Spread<n2.Spread<byte>> Result_Out, out int Buffer_Size_Out, out string Status_Out)
        {
            n5._Operations_.None<byte>(Input_In: Prefix_In, Result_Out: out bool Result_0);
            n5._Operations_.None<byte>(Input_In: Postfix_In, Result_Out: out bool Result_1);
            var Output_2 = Result_0 || Result_1;
            n4.IEnumerable<byte> Input_2_3 = n5._Operations_.CreateDefault<byte>();
            n6._Operations_.Switch_Boolean<n4.IEnumerable<byte>>(Condition_In: Output_2, Input_In: Data_In, Input_2_In: Input_2_3, Output_Out: out n4.IEnumerable<byte> Output_4);
            n5._Operations_.Count<byte>(Input_In: Prefix_In, Result_Out: out int Result_5);
            n5._Operations_.Count<byte>(Input_In: Postfix_In, Result_Out: out int Result_6);
            var __fallback___7 = n1.ServiceRegistry.Current;
            n9.Func<n2.SpreadBuilder<byte>, n12.Result_C<n2.Spread<byte>>> Functionality_38 = (n2.SpreadBuilder<byte> Arg_In_9) =>
            {
                using var __current_8 = __fallback___7.MakeCurrentIfNone();
                n4.IEnumerable<byte> Input_10 = (n4.IEnumerable<byte>)Arg_In_9;
                n12._Operations_.StartsWith(Input_In: Input_10, Separator_In: Prefix_In, Result_Out: out bool Result_11);
                bool Collecting_12;
                int Bytes_Count_13;
                n2.Spread<byte> Token_14;
                bool Token_Is_Valid_15;
                bool Needs_more_16;
                if (Result_11)
                {
                    bool __pad_FFf4IKta8KwL1gPpYkYYrA_17 = __slot_FFf4IKta8KwL1gPpYkYYrA;
                    bool __pad_CSftaLmfcspMk984q1aZ0J_18 = __slot_CSftaLmfcspMk984q1aZ0J;
                    n4.IEnumerable<byte> Input_19 = (n4.IEnumerable<byte>)Arg_In_9;
                    n12._Operations_.Contains(Input_In: Input_19, Separator_In: Postfix_In, Output_Out: out bool Output_20, Position_Out: out int Position_21);
                    bool Collecting_22;
                    int Bytes_Count_23;
                    n2.Spread<byte> Token_24;
                    bool Token_Is_Valid_25;
                    bool Needs_More_Input_26;
                    if (Output_20)
                    {
                        bool __pad_K9f4el9CIztMZpe2QB52Du_27 = __slot_K9f4el9CIztMZpe2QB52Du;
                        bool __pad_UmvMzIcot3ALBSUfSoUMK1_28 = __slot_UmvMzIcot3ALBSUfSoUMK1;
                        bool __pad_ATCki2Qs3U5LJDRIogSd9V_29 = __slot_ATCki2Qs3U5LJDRIogSd9V;
                        n7._Operations_.ToSpread<byte>(Input_In: Arg_In_9, Output_Out: out n2.SpreadBuilder<byte> Output_30, Result_Out: out n2.Spread<byte> Result_31);
                        n3._Operations_.Skip<byte>(Input_In: Result_31, Count_In: Result_5, Output_Out: out n2.Spread<byte> Output_32);
                        var Output_33 = Position_21 - Result_5;
                        n3._Operations_.Take<byte>(Input_In: Output_32, Count_In: Output_33, Output_Out: out n2.Spread<byte> Output_34);
                        Token_24 = Output_34;
                        var Output_35 = Position_21 + Result_6;
                        Bytes_Count_23 = Output_35;
                        Collecting_22 = __pad_K9f4el9CIztMZpe2QB52Du_27;
                        Token_Is_Valid_25 = __pad_UmvMzIcot3ALBSUfSoUMK1_28;
                        Needs_More_Input_26 = __pad_ATCki2Qs3U5LJDRIogSd9V_29;
                    }
                    else
                    {
                        Collecting_22 = __pad_FFf4IKta8KwL1gPpYkYYrA_17;
                        Bytes_Count_23 = 0;
                        Token_24 = n3._Operations_.CreateDefault<byte>();
                        Token_Is_Valid_25 = false;
                        Needs_More_Input_26 = __pad_CSftaLmfcspMk984q1aZ0J_18;
                    }

                    Collecting_12 = Collecting_22;
                    Bytes_Count_13 = Bytes_Count_23;
                    Token_14 = Token_24;
                    Token_Is_Valid_15 = Token_Is_Valid_25;
                    Needs_more_16 = Needs_More_Input_26;
                }
                else
                {
                    Collecting_12 = false;
                    Bytes_Count_13 = 0;
                    Token_14 = n3._Operations_.CreateDefault<byte>();
                    Token_Is_Valid_15 = false;
                    Needs_more_16 = false;
                }

                n1.NodeContext Node_Context_36 = __GetContext__().CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "NUjvLHQZ2HfPRxG1LVCGVW", 259726U);
                var Output_37 = n12.Result_C<n2.Spread<byte>>.Create<n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>(Node_Context: Node_Context_36, Token_In: Token_14, Token_Is_Valid_In: Token_Is_Valid_15, Byte_Count_In: Bytes_Count_13, Collecting_In: Collecting_12, Needs_More_Input_In: Needs_more_16);
                return Output_37;
            }

            ;
            var Output_41 = this.__p_IK3caZbYuuYLCrjs68tO2Q.Update<n4.IEnumerable<byte>>(Value_In: Prefix_In, Result_Out: out bool Result_39, Unchanged_Out: out bool Unchanged_40);
            var Output_44 = this.__p_MM7TIwcoPY0MPCDklkhscm.Update<n4.IEnumerable<byte>>(Value_In: Postfix_In, Result_Out: out bool Result_42, Unchanged_Out: out bool Unchanged_43);
            var Output_45 = Reset_In || Result_39;
            var Output_46 = Output_45 || Result_42;
            var Output_50 = this.__p_JMobZNyuS2dLGCvlJxI2lB.Update<n4.IEnumerable<byte>, n2.Spread<byte>, n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>(Data_In: Output_4, Tokenize_In: Functionality_38, Reset_In: Output_46, Result_Out: out n2.Spread<n2.Spread<byte>> Result_47, Buffer_Size_Out: out int Buffer_Size_48, Status_Out: out string Status_49);
            Result_Out = Result_47;
            Buffer_Size_Out = Buffer_Size_48;
            Status_Out = Status_49;
            n20.Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm that_51 = this;
            if (this.__GetContext__().IsImmutable)
                that_51 = Output_41 != this.__p_IK3caZbYuuYLCrjs68tO2Q || Output_44 != this.__p_MM7TIwcoPY0MPCDklkhscm || Output_50 != this.__p_JMobZNyuS2dLGCvlJxI2lB ? new Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm(this)
                {__p_IK3caZbYuuYLCrjs68tO2Q = Output_41, __p_MM7TIwcoPY0MPCDklkhscm = Output_44, __p_JMobZNyuS2dLGCvlJxI2lB = Output_50} : that_51;
            else
            {
                this.__p_IK3caZbYuuYLCrjs68tO2Q = Output_41;
                this.__p_MM7TIwcoPY0MPCDklkhscm = Output_44;
                this.__p_JMobZNyuS2dLGCvlJxI2lB = Output_50;
            }

            return that_51;
        }

        public n20.Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm __Create__(n1.NodeContext Node_Context)
        {
            n15.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "IK3caZbYuuYLCrjs68tO2Q", 259047U);
            var Output_1 = n24.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<byte>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "MM7TIwcoPY0MPCDklkhscm", 259064U);
            var Output_3 = n24.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<byte>.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "JMobZNyuS2dLGCvlJxI2lB", 259080U);
            var Output_5 = n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte>.Create(Node_Context: Node_Context_4);
            n20.Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm that_6 = this;
            this.__p_IK3caZbYuuYLCrjs68tO2Q = Output_1;
            this.__p_MM7TIwcoPY0MPCDklkhscm = Output_3;
            this.__p_JMobZNyuS2dLGCvlJxI2lB = Output_5;
            return that_6;
        }

        public n20.Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm __CreateDefault__()
        {
            n20.Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm that_0 = this;
            this.__p_IK3caZbYuuYLCrjs68tO2Q = n24.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<byte>.CreateDefault();
            this.__p_MM7TIwcoPY0MPCDklkhscm = n24.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<byte>.CreateDefault();
            this.__p_JMobZNyuS2dLGCvlJxI2lB = n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_IK3caZbYuuYLCrjs68tO2Q);
            n1.CompilationHelper.SafeDispose(this.__p_MM7TIwcoPY0MPCDklkhscm);
            n1.CompilationHelper.SafeDispose(this.__p_JMobZNyuS2dLGCvlJxI2lB);
            return;
        }

        void n9.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 259711U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "FFf4IKta8KwL1gPpYkYYrA", Name = "__slot_FFf4IKta8KwL1gPpYkYYrA")]
        public static bool __slot_FFf4IKta8KwL1gPpYkYYrA = true;
        [n1.ElementAttribute(TracingId = 259702U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "CSftaLmfcspMk984q1aZ0J", Name = "__slot_CSftaLmfcspMk984q1aZ0J")]
        public static bool __slot_CSftaLmfcspMk984q1aZ0J = true;
        [n1.ElementAttribute(TracingId = 259668U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "K9f4el9CIztMZpe2QB52Du", Name = "__slot_K9f4el9CIztMZpe2QB52Du")]
        public static bool __slot_K9f4el9CIztMZpe2QB52Du = true;
        [n1.ElementAttribute(TracingId = 259239U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "UmvMzIcot3ALBSUfSoUMK1", Name = "__slot_UmvMzIcot3ALBSUfSoUMK1")]
        public static bool __slot_UmvMzIcot3ALBSUfSoUMK1 = true;
        [n1.ElementAttribute(TracingId = 259666U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "ATCki2Qs3U5LJDRIogSd9V", Name = "__slot_ATCki2Qs3U5LJDRIogSd9V")]
        public static bool __slot_ATCki2Qs3U5LJDRIogSd9V = false;
        [n1.ElementAttribute(TracingId = 259047U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "IK3caZbYuuYLCrjs68tO2Q", Name = "SequenceChanged", IsManaged = true, IsAutoGenerated = true)]
        public n24.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<byte> __p_IK3caZbYuuYLCrjs68tO2Q;
        [n1.ElementAttribute(TracingId = 259064U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "MM7TIwcoPY0MPCDklkhscm", Name = "SequenceChanged", IsManaged = true, IsAutoGenerated = true)]
        public n24.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<byte> __p_MM7TIwcoPY0MPCDklkhscm;
        [n1.ElementAttribute(TracingId = 259080U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "JMobZNyuS2dLGCvlJxI2lB", Name = "Tokenizer", IsManaged = true, IsAutoGenerated = true)]
        public n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte> __p_JMobZNyuS2dLGCvlJxI2lB;
        static Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm()
        {
        }

        public Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm(Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm other): base(other)
        {
            this.__p_IK3caZbYuuYLCrjs68tO2Q = other.__p_IK3caZbYuuYLCrjs68tO2Q;
            this.__p_MM7TIwcoPY0MPCDklkhscm = other.__p_MM7TIwcoPY0MPCDklkhscm;
            this.__p_JMobZNyuS2dLGCvlJxI2lB = other.__p_JMobZNyuS2dLGCvlJxI2lB;
        }

        protected override n1.IVLObject __With__(n4.IReadOnlyDictionary<string, n9.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IK3caZbYuuYLCrjs68tO2Q", in __p_IK3caZbYuuYLCrjs68tO2Q), n1.CompilationHelper.GetValueOrExisting(values, "__p_MM7TIwcoPY0MPCDklkhscm", in __p_MM7TIwcoPY0MPCDklkhscm), n1.CompilationHelper.GetValueOrExisting(values, "__p_JMobZNyuS2dLGCvlJxI2lB", in __p_JMobZNyuS2dLGCvlJxI2lB));
        }

        internal Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm __WITH__(n24.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<byte> __p_IK3caZbYuuYLCrjs68tO2Q, n24.SequenceChanged_EAvS1XXezCmL7nXpFVvQcX<byte> __p_MM7TIwcoPY0MPCDklkhscm, n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte> __p_JMobZNyuS2dLGCvlJxI2lB)
        {
            n20.Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_IK3caZbYuuYLCrjs68tO2Q != this.__p_IK3caZbYuuYLCrjs68tO2Q || __p_MM7TIwcoPY0MPCDklkhscm != this.__p_MM7TIwcoPY0MPCDklkhscm || __p_JMobZNyuS2dLGCvlJxI2lB != this.__p_JMobZNyuS2dLGCvlJxI2lB ? new Tokenizer_Frame_S9LmNU1FHynOjIAYRsBjPm(this)
                {__p_IK3caZbYuuYLCrjs68tO2Q = __p_IK3caZbYuuYLCrjs68tO2Q, __p_MM7TIwcoPY0MPCDklkhscm = __p_MM7TIwcoPY0MPCDklkhscm, __p_JMobZNyuS2dLGCvlJxI2lB = __p_JMobZNyuS2dLGCvlJxI2lB} : that_0;
            else
            {
                this.__p_IK3caZbYuuYLCrjs68tO2Q = __p_IK3caZbYuuYLCrjs68tO2Q;
                this.__p_MM7TIwcoPY0MPCDklkhscm = __p_MM7TIwcoPY0MPCDklkhscm;
                this.__p_JMobZNyuS2dLGCvlJxI2lB = __p_JMobZNyuS2dLGCvlJxI2lB;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 260034U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "LKYxaM9jcO4OJnzPQrhoC3", Name = "Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3")]
    [n9.SerializableAttribute]
    public class Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3 : n1.VLObject, n9.IDisposable
    {
        [n11.CreateNewAttribute]
        public static n20.Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3 Create(n1.NodeContext Node_Context)
        {
            var instance = new Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n11.CreateDefaultAttribute]
        public static n20.Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3 CreateDefault()
        {
            var instance = new Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n20.Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3 Update(n4.IEnumerable<byte> Data_In, int Length_In, bool Reset_In, out n2.Spread<n2.Spread<byte>> Result_Out, out int Buffer_Size_Out, out string Status_Out)
        {
            var __fallback___0 = n1.ServiceRegistry.Current;
            n9.Func<n2.SpreadBuilder<byte>, n12.Result_C<n2.Spread<byte>>> Functionality_22 = (n2.SpreadBuilder<byte> Arg_In_2) =>
            {
                using var __current_1 = __fallback___0.MakeCurrentIfNone();
                int __pad_L8QTkXlJGW3Ofkhmgu2mij_3 = __slot_L8QTkXlJGW3Ofkhmgu2mij;
                n7._Operations_.Count<byte>(Input_In: Arg_In_2, Output_Out: out n2.SpreadBuilder<byte> Output_4, Count_Out: out int Count_5);
                var Result_6 = Count_5 >= Length_In;
                int Byte_Count_7;
                n2.Spread<byte> Token_8;
                bool __auto_9;
                if (Result_6)
                {
                    bool __pad_MnnD588K8PMPR8ntAXv38c_10 = __slot_MnnD588K8PMPR8ntAXv38c;
                    n7._Operations_.ToSpread<byte>(Input_In: Output_4, Output_Out: out n2.SpreadBuilder<byte> Output_11, Result_Out: out n2.Spread<byte> Result_12);
                    n3._Operations_.Take<byte>(Input_In: Result_12, Count_In: Length_In, Output_Out: out n2.Spread<byte> Output_13);
                    Token_8 = Output_13;
                    __auto_9 = __pad_MnnD588K8PMPR8ntAXv38c_10;
                    Byte_Count_7 = Length_In;
                }
                else
                {
                    Byte_Count_7 = 0;
                    Token_8 = n3._Operations_.CreateDefault<byte>();
                    __auto_9 = false;
                }

                var Output_14 = Count_5 - Byte_Count_7;
                int Input_2_15 = 0;
                var Result_16 = Output_14 > Input_2_15;
                var Result_17 = Output_14 < Length_In;
                var Result_18 = Length_In == __pad_L8QTkXlJGW3Ofkhmgu2mij_3;
                var Output_19 = Result_17 || Result_18;
                n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "Bov2rd2LyJxMGYsJw8lRoV", 269094U);
                var Output_21 = n12.Result_C<n2.Spread<byte>>.Create<n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>(Node_Context: Node_Context_20, Token_In: Token_8, Token_Is_Valid_In: __auto_9, Byte_Count_In: Byte_Count_7, Collecting_In: Result_16, Needs_More_Input_In: Output_19);
                return Output_21;
            }

            ;
            var Output_25 = this.__p_VhJljWoW7EYLeDdux7B85v.Update(Value_In: Length_In, Result_Out: out bool Result_23, Unchanged_Out: out bool Unchanged_24);
            var Output_26 = Reset_In || Result_23;
            var Output_30 = this.__p_DrCmvVcoIriMm4yTLD6WW1.Update<n4.IEnumerable<byte>, n2.Spread<byte>, n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>(Data_In: Data_In, Tokenize_In: Functionality_22, Reset_In: Output_26, Result_Out: out n2.Spread<n2.Spread<byte>> Result_27, Buffer_Size_Out: out int Buffer_Size_28, Status_Out: out string Status_29);
            Result_Out = Result_27;
            Buffer_Size_Out = Buffer_Size_28;
            Status_Out = Status_29;
            n20.Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3 that_31 = this;
            if (this.__GetContext__().IsImmutable)
                that_31 = Output_25 != this.__p_VhJljWoW7EYLeDdux7B85v || Output_30 != this.__p_DrCmvVcoIriMm4yTLD6WW1 ? new Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3(this)
                {__p_VhJljWoW7EYLeDdux7B85v = Output_25, __p_DrCmvVcoIriMm4yTLD6WW1 = Output_30} : that_31;
            else
            {
                this.__p_VhJljWoW7EYLeDdux7B85v = Output_25;
                this.__p_DrCmvVcoIriMm4yTLD6WW1 = Output_30;
            }

            return that_31;
        }

        public n20.Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3 __Create__(n1.NodeContext Node_Context)
        {
            n15.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "VhJljWoW7EYLeDdux7B85v", 260059U);
            bool Changed_On_Create_1 = true;
            var Output_2 = n25.Changed_A8JGbead2bxNdnPybiEqVS<int>.Create<n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>(Node_Context: Node_Context_0, Changed_On_Create_In: Changed_On_Create_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "DrCmvVcoIriMm4yTLD6WW1", 260069U);
            var Output_4 = n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte>.Create(Node_Context: Node_Context_3);
            n20.Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3 that_5 = this;
            this.__p_VhJljWoW7EYLeDdux7B85v = Output_2;
            this.__p_DrCmvVcoIriMm4yTLD6WW1 = Output_4;
            return that_5;
        }

        public n20.Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3 __CreateDefault__()
        {
            n20.Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3 that_0 = this;
            this.__p_VhJljWoW7EYLeDdux7B85v = n25.Changed_A8JGbead2bxNdnPybiEqVS<int>.CreateDefault<n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>();
            this.__p_DrCmvVcoIriMm4yTLD6WW1 = n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_VhJljWoW7EYLeDdux7B85v);
            n1.CompilationHelper.SafeDispose(this.__p_DrCmvVcoIriMm4yTLD6WW1);
            return;
        }

        void n9.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 269121U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "L8QTkXlJGW3Ofkhmgu2mij", Name = "__slot_L8QTkXlJGW3Ofkhmgu2mij")]
        public static int __slot_L8QTkXlJGW3Ofkhmgu2mij = 0;
        [n1.ElementAttribute(TracingId = 269087U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "MnnD588K8PMPR8ntAXv38c", Name = "__slot_MnnD588K8PMPR8ntAXv38c")]
        public static bool __slot_MnnD588K8PMPR8ntAXv38c = true;
        [n1.ElementAttribute(TracingId = 260059U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "VhJljWoW7EYLeDdux7B85v", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n25.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_VhJljWoW7EYLeDdux7B85v;
        [n1.ElementAttribute(TracingId = 260069U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "DrCmvVcoIriMm4yTLD6WW1", Name = "Tokenizer", IsManaged = true, IsAutoGenerated = true)]
        public n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte> __p_DrCmvVcoIriMm4yTLD6WW1;
        static Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3()
        {
        }

        public Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3(Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3 other): base(other)
        {
            this.__p_VhJljWoW7EYLeDdux7B85v = other.__p_VhJljWoW7EYLeDdux7B85v;
            this.__p_DrCmvVcoIriMm4yTLD6WW1 = other.__p_DrCmvVcoIriMm4yTLD6WW1;
        }

        protected override n1.IVLObject __With__(n4.IReadOnlyDictionary<string, n9.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VhJljWoW7EYLeDdux7B85v", in __p_VhJljWoW7EYLeDdux7B85v), n1.CompilationHelper.GetValueOrExisting(values, "__p_DrCmvVcoIriMm4yTLD6WW1", in __p_DrCmvVcoIriMm4yTLD6WW1));
        }

        internal Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3 __WITH__(n25.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_VhJljWoW7EYLeDdux7B85v, n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte> __p_DrCmvVcoIriMm4yTLD6WW1)
        {
            n20.Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_VhJljWoW7EYLeDdux7B85v != this.__p_VhJljWoW7EYLeDdux7B85v || __p_DrCmvVcoIriMm4yTLD6WW1 != this.__p_DrCmvVcoIriMm4yTLD6WW1 ? new Tokenizer_FixedLength_LKYxaM9jcO4OJnzPQrhoC3(this)
                {__p_VhJljWoW7EYLeDdux7B85v = __p_VhJljWoW7EYLeDdux7B85v, __p_DrCmvVcoIriMm4yTLD6WW1 = __p_DrCmvVcoIriMm4yTLD6WW1} : that_0;
            else
            {
                this.__p_VhJljWoW7EYLeDdux7B85v = __p_VhJljWoW7EYLeDdux7B85v;
                this.__p_DrCmvVcoIriMm4yTLD6WW1 = __p_DrCmvVcoIriMm4yTLD6WW1;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 269180U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "EHaocYFxIJ1PQgRGnuwmo9", Name = "Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9")]
    [n9.SerializableAttribute]
    public class Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9 : n1.VLObject, n9.IDisposable
    {
        [n11.CreateNewAttribute]
        public static n20.Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9 Create(n1.NodeContext Node_Context)
        {
            var instance = new Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n11.CreateDefaultAttribute]
        public static n20.Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9 CreateDefault()
        {
            var instance = new Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n20.Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9 Update(n4.IEnumerable<byte> Data_In, [n11.SerializedDefaultValueAttribute("1", false)] int Length_Byte_Count_In, bool Length_Big_Endian_In, bool Reset_In, out n2.Spread<n2.Spread<byte>> Result_Out, out int Buffer_Size_Out, out string Status_Out)
        {
            int __pad_VKoAdhofGrlQPWpj8Wug49_0 = Length_Byte_Count_In;
            var __fallback___1 = n1.ServiceRegistry.Current;
            n9.Func<n2.SpreadBuilder<byte>, n12.Result_C<n2.Spread<byte>>> Functionality_26 = (n2.SpreadBuilder<byte> Arg_In_3) =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                bool __pad_NZvabjSAVWjMwaWJWpvqOB_4 = __slot_NZvabjSAVWjMwaWJWpvqOB;
                n7._Operations_.Count<byte>(Input_In: Arg_In_3, Output_Out: out n2.SpreadBuilder<byte> Output_5, Count_Out: out int Count_6);
                var Result_7 = Count_6 >= __pad_VKoAdhofGrlQPWpj8Wug49_0;
                n2.SpreadBuilder<byte> __auto_8;
                int __auto_9;
                if (Result_7)
                {
                    n7._Operations_.ToSpread<byte>(Input_In: Output_5, Output_Out: out n2.SpreadBuilder<byte> Output_10, Result_Out: out n2.Spread<byte> Result_11);
                    __auto_8 = Output_10;
                    n3._Operations_.Take<byte>(Input_In: Result_11, Count_In: __pad_VKoAdhofGrlQPWpj8Wug49_0, Output_Out: out n2.Spread<byte> Output_12);
                    n26._Operations_.ParseLength<n2.Spread<byte>>(Input_In: Output_12, Big_Endian_In: Length_Big_Endian_In, Output_Out: out int Output_13);
                    __auto_9 = Output_13;
                }
                else
                {
                    __auto_8 = Output_5;
                    __auto_9 = 0;
                }

                var Output_14 = __pad_VKoAdhofGrlQPWpj8Wug49_0 + __auto_9;
                var Result_15 = Count_6 >= Output_14;
                int Bytes_Count_16;
                n2.Spread<byte> Token_17;
                bool __auto_18;
                if (Result_15)
                {
                    bool __pad_SvcUGKYRI1WNJ8W2YW0swV_19 = __slot_SvcUGKYRI1WNJ8W2YW0swV;
                    n7._Operations_.ToSpread<byte>(Input_In: __auto_8, Output_Out: out n2.SpreadBuilder<byte> Output_20, Result_Out: out n2.Spread<byte> Result_21);
                    n3._Operations_.GetSpread<byte>(Input_In: Result_21, Index_In: __pad_VKoAdhofGrlQPWpj8Wug49_0, Count_In: __auto_9, Output_Out: out n2.Spread<byte> Output_22);
                    Token_17 = Output_22;
                    __auto_18 = __pad_SvcUGKYRI1WNJ8W2YW0swV_19;
                    Bytes_Count_16 = Output_14;
                }
                else
                {
                    Bytes_Count_16 = 0;
                    Token_17 = n3._Operations_.CreateDefault<byte>();
                    __auto_18 = false;
                }

                var Output_23 = !Result_15;
                n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "KeFmRpG2tsaQVdahGzoCb0", 269371U);
                var Output_25 = n12.Result_C<n2.Spread<byte>>.Create<n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>(Node_Context: Node_Context_24, Token_In: Token_17, Token_Is_Valid_In: __auto_18, Byte_Count_In: Bytes_Count_16, Collecting_In: __pad_NZvabjSAVWjMwaWJWpvqOB_4, Needs_More_Input_In: Output_23);
                return Output_25;
            }

            ;
            var Output_29 = this.__p_UtfLHPT1DiZPhAxHMF5x2o.Update(Value_In: Length_Byte_Count_In, Result_Out: out bool Result_27, Unchanged_Out: out bool Unchanged_28);
            var Output_32 = this.__p_DRnW9mpMqo5QKyF1VfMalH.Update(Value_In: Length_Big_Endian_In, Result_Out: out bool Result_30, Unchanged_Out: out bool Unchanged_31);
            var Output_33 = Reset_In || Result_27;
            var Output_34 = Output_33 || Result_30;
            var Output_38 = this.__p_QToxDETazWCQMRywQuDQmD.Update<n4.IEnumerable<byte>, n2.Spread<byte>, n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>(Data_In: Data_In, Tokenize_In: Functionality_26, Reset_In: Output_34, Result_Out: out n2.Spread<n2.Spread<byte>> Result_35, Buffer_Size_Out: out int Buffer_Size_36, Status_Out: out string Status_37);
            Result_Out = Result_35;
            Buffer_Size_Out = Buffer_Size_36;
            Status_Out = Status_37;
            n20.Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9 that_39 = this;
            if (this.__GetContext__().IsImmutable)
                that_39 = Length_Byte_Count_In != this.__slot_VKoAdhofGrlQPWpj8Wug49 || Output_29 != this.__p_UtfLHPT1DiZPhAxHMF5x2o || Output_32 != this.__p_DRnW9mpMqo5QKyF1VfMalH || Output_38 != this.__p_QToxDETazWCQMRywQuDQmD ? new Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9(this)
                {__slot_VKoAdhofGrlQPWpj8Wug49 = Length_Byte_Count_In, __p_UtfLHPT1DiZPhAxHMF5x2o = Output_29, __p_DRnW9mpMqo5QKyF1VfMalH = Output_32, __p_QToxDETazWCQMRywQuDQmD = Output_38} : that_39;
            else
            {
                this.__slot_VKoAdhofGrlQPWpj8Wug49 = Length_Byte_Count_In;
                this.__p_UtfLHPT1DiZPhAxHMF5x2o = Output_29;
                this.__p_DRnW9mpMqo5QKyF1VfMalH = Output_32;
                this.__p_QToxDETazWCQMRywQuDQmD = Output_38;
            }

            return that_39;
        }

        public n20.Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9 __Create__(n1.NodeContext Node_Context)
        {
            n15.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "UtfLHPT1DiZPhAxHMF5x2o", 269251U);
            bool Changed_On_Create_1 = true;
            var Output_2 = n25.Changed_A8JGbead2bxNdnPybiEqVS<int>.Create<n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>(Node_Context: Node_Context_0, Changed_On_Create_In: Changed_On_Create_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "DRnW9mpMqo5QKyF1VfMalH", 269255U);
            bool Changed_On_Create_4 = true;
            var Output_5 = n25.Changed_A8JGbead2bxNdnPybiEqVS<bool>.Create<n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>(Node_Context: Node_Context_3, Changed_On_Create_In: Changed_On_Create_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "QToxDETazWCQMRywQuDQmD", 269382U);
            var Output_7 = n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte>.Create(Node_Context: Node_Context_6);
            n20.Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9 that_8 = this;
            this.__slot_VKoAdhofGrlQPWpj8Wug49 = 0;
            this.__p_UtfLHPT1DiZPhAxHMF5x2o = Output_2;
            this.__p_DRnW9mpMqo5QKyF1VfMalH = Output_5;
            this.__p_QToxDETazWCQMRywQuDQmD = Output_7;
            return that_8;
        }

        public n20.Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9 __CreateDefault__()
        {
            n20.Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9 that_0 = this;
            this.__slot_VKoAdhofGrlQPWpj8Wug49 = 0;
            this.__p_UtfLHPT1DiZPhAxHMF5x2o = n25.Changed_A8JGbead2bxNdnPybiEqVS<int>.CreateDefault<n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>();
            this.__p_DRnW9mpMqo5QKyF1VfMalH = n25.Changed_A8JGbead2bxNdnPybiEqVS<bool>.CreateDefault<n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>();
            this.__p_QToxDETazWCQMRywQuDQmD = n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_UtfLHPT1DiZPhAxHMF5x2o);
            n1.CompilationHelper.SafeDispose(this.__p_DRnW9mpMqo5QKyF1VfMalH);
            n1.CompilationHelper.SafeDispose(this.__p_QToxDETazWCQMRywQuDQmD);
            return;
        }

        void n9.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 269389U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "VKoAdhofGrlQPWpj8Wug49", Name = "__slot_VKoAdhofGrlQPWpj8Wug49")]
        public int __slot_VKoAdhofGrlQPWpj8Wug49;
        [n1.ElementAttribute(TracingId = 269378U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "NZvabjSAVWjMwaWJWpvqOB", Name = "__slot_NZvabjSAVWjMwaWJWpvqOB")]
        public static bool __slot_NZvabjSAVWjMwaWJWpvqOB = true;
        [n1.ElementAttribute(TracingId = 269356U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "SvcUGKYRI1WNJ8W2YW0swV", Name = "__slot_SvcUGKYRI1WNJ8W2YW0swV")]
        public static bool __slot_SvcUGKYRI1WNJ8W2YW0swV = true;
        [n1.ElementAttribute(TracingId = 269251U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "UtfLHPT1DiZPhAxHMF5x2o", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n25.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_UtfLHPT1DiZPhAxHMF5x2o;
        [n1.ElementAttribute(TracingId = 269255U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "DRnW9mpMqo5QKyF1VfMalH", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n25.Changed_A8JGbead2bxNdnPybiEqVS<bool> __p_DRnW9mpMqo5QKyF1VfMalH;
        [n1.ElementAttribute(TracingId = 269382U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "QToxDETazWCQMRywQuDQmD", Name = "Tokenizer", IsManaged = true, IsAutoGenerated = true)]
        public n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte> __p_QToxDETazWCQMRywQuDQmD;
        static Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9()
        {
        }

        public Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9(Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9 other): base(other)
        {
            this.__slot_VKoAdhofGrlQPWpj8Wug49 = other.__slot_VKoAdhofGrlQPWpj8Wug49;
            this.__p_UtfLHPT1DiZPhAxHMF5x2o = other.__p_UtfLHPT1DiZPhAxHMF5x2o;
            this.__p_DRnW9mpMqo5QKyF1VfMalH = other.__p_DRnW9mpMqo5QKyF1VfMalH;
            this.__p_QToxDETazWCQMRywQuDQmD = other.__p_QToxDETazWCQMRywQuDQmD;
        }

        protected override n1.IVLObject __With__(n4.IReadOnlyDictionary<string, n9.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_VKoAdhofGrlQPWpj8Wug49", in __slot_VKoAdhofGrlQPWpj8Wug49), n1.CompilationHelper.GetValueOrExisting(values, "__p_UtfLHPT1DiZPhAxHMF5x2o", in __p_UtfLHPT1DiZPhAxHMF5x2o), n1.CompilationHelper.GetValueOrExisting(values, "__p_DRnW9mpMqo5QKyF1VfMalH", in __p_DRnW9mpMqo5QKyF1VfMalH), n1.CompilationHelper.GetValueOrExisting(values, "__p_QToxDETazWCQMRywQuDQmD", in __p_QToxDETazWCQMRywQuDQmD));
        }

        internal Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9 __WITH__(int __slot_VKoAdhofGrlQPWpj8Wug49, n25.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_UtfLHPT1DiZPhAxHMF5x2o, n25.Changed_A8JGbead2bxNdnPybiEqVS<bool> __p_DRnW9mpMqo5QKyF1VfMalH, n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<byte> __p_QToxDETazWCQMRywQuDQmD)
        {
            n20.Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_VKoAdhofGrlQPWpj8Wug49 != this.__slot_VKoAdhofGrlQPWpj8Wug49 || __p_UtfLHPT1DiZPhAxHMF5x2o != this.__p_UtfLHPT1DiZPhAxHMF5x2o || __p_DRnW9mpMqo5QKyF1VfMalH != this.__p_DRnW9mpMqo5QKyF1VfMalH || __p_QToxDETazWCQMRywQuDQmD != this.__p_QToxDETazWCQMRywQuDQmD ? new Tokenizer_LengthPrefix_EHaocYFxIJ1PQgRGnuwmo9(this)
                {__slot_VKoAdhofGrlQPWpj8Wug49 = __slot_VKoAdhofGrlQPWpj8Wug49, __p_UtfLHPT1DiZPhAxHMF5x2o = __p_UtfLHPT1DiZPhAxHMF5x2o, __p_DRnW9mpMqo5QKyF1VfMalH = __p_DRnW9mpMqo5QKyF1VfMalH, __p_QToxDETazWCQMRywQuDQmD = __p_QToxDETazWCQMRywQuDQmD} : that_0;
            else
            {
                this.__slot_VKoAdhofGrlQPWpj8Wug49 = __slot_VKoAdhofGrlQPWpj8Wug49;
                this.__p_UtfLHPT1DiZPhAxHMF5x2o = __p_UtfLHPT1DiZPhAxHMF5x2o;
                this.__p_DRnW9mpMqo5QKyF1VfMalH = __p_DRnW9mpMqo5QKyF1VfMalH;
                this.__p_QToxDETazWCQMRywQuDQmD = __p_QToxDETazWCQMRywQuDQmD;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 269986U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "EZxYNMIvTZjLQujOZS3v4o", Name = "Enqueue_EZxYNMIvTZjLQujOZS3v4o")]
    [n9.SerializableAttribute]
    public class Enqueue_EZxYNMIvTZjLQujOZS3v4o<T> : n1.VLObject, n9.IDisposable
    {
        [n11.CreateNewAttribute]
        public static n20.Enqueue_EZxYNMIvTZjLQujOZS3v4o<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Enqueue_EZxYNMIvTZjLQujOZS3v4o<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n11.CreateDefaultAttribute]
        public static n20.Enqueue_EZxYNMIvTZjLQujOZS3v4o<T> CreateDefault()
        {
            var instance = new Enqueue_EZxYNMIvTZjLQujOZS3v4o<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n20.Enqueue_EZxYNMIvTZjLQujOZS3v4o<T> Update<T2, AdM>(T2 Data_In, bool Reset_In, out T Result_Out, out int Queue_Length_Out)
            where T2 : n4.IEnumerable<T> where AdM : struct, n14.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            n2.Spread<T> __auto_1 = this.Buffer;
            n4.IEnumerable<T> Input_2_2 = (n4.IEnumerable<T>)Data_In;
            n2.Spread<T> __auto_3;
            if (Reset_In)
            {
                n3._Operations_.Clear<T>(Input_In: __auto_1, Output_Out: out n2.Spread<T> Output_5);
                __auto_3 = Output_5;
            }
            else
            {
                __auto_3 = __auto_1;
            }

            n4.IEnumerable<T> Input_6 = (n4.IEnumerable<T>)__auto_3;
            var builder_7 = n11.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM, 2);
            builder_7.Add(Input_6);
            builder_7.Add(Input_2_2);
            var __pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM_8 = builder_7.Commit();
            n3._Operations_.Concat<T>(Input_In: __pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM_8, Output_Out: out n2.Spread<T> Output_9);
            w_0.CreateDefault(Output_Out: out T Output_10);
            n3._Operations_.SplitFirst<T>(Input_In: Output_9, Default_Value_In: Output_10, Output_Out: out n2.Spread<T> Output_11, Result_Out: out T Result_12);
            n2.Spread<T> __auto_13 = Output_11;
            n3._Operations_.Count<T>(Input_In: __auto_13, Count_Out: out int Count_14);
            Result_Out = Result_12;
            Queue_Length_Out = Count_14;
            n20.Enqueue_EZxYNMIvTZjLQujOZS3v4o<T> that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = __pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM_8 != this.__pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM || Output_11 != this.Buffer ? new Enqueue_EZxYNMIvTZjLQujOZS3v4o<T>(this)
                {__pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM = __pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM_8, Buffer = Output_11} : that_15;
            else
            {
                this.__pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM = __pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM_8;
                this.Buffer = Output_11;
            }

            return that_15;
        }

        public n20.Enqueue_EZxYNMIvTZjLQujOZS3v4o<T> __Create__(n1.NodeContext Node_Context)
        {
            n15.RuntimeHelpers.EnsureSufficientExecutionStack();
            n20.Enqueue_EZxYNMIvTZjLQujOZS3v4o<T> that_0 = this;
            this.Buffer = n3._Operations_.CreateDefault<T>();
            this.__pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM = n3._Operations_.CreateDefault<n4.IEnumerable<T>>();
            return that_0;
        }

        public n20.Enqueue_EZxYNMIvTZjLQujOZS3v4o<T> __CreateDefault__()
        {
            n20.Enqueue_EZxYNMIvTZjLQujOZS3v4o<T> that_0 = this;
            this.Buffer = n3._Operations_.CreateDefault<T>();
            this.__pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM = n3._Operations_.CreateDefault<n4.IEnumerable<T>>();
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n9.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 269990U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "UTlXIU4lrd9NE7lSZf42oO", Name = "Buffer")]
        public n2.Spread<T> Buffer;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n2.Spread<n4.IEnumerable<T>> __pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM = default(n2.Spread<n4.IEnumerable<T>>);
        public Enqueue_EZxYNMIvTZjLQujOZS3v4o(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Enqueue_EZxYNMIvTZjLQujOZS3v4o(Enqueue_EZxYNMIvTZjLQujOZS3v4o<T> other): base(other)
        {
            this.Buffer = other.Buffer;
            this.__pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM = other.__pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM;
        }

        protected override n1.IVLObject __With__(n4.IReadOnlyDictionary<string, n9.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Buffer", in Buffer), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM", in __pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM));
        }

        internal Enqueue_EZxYNMIvTZjLQujOZS3v4o<T> __WITH__(n2.Spread<T> Buffer, n2.Spread<n4.IEnumerable<T>> __pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM)
        {
            n20.Enqueue_EZxYNMIvTZjLQujOZS3v4o<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Buffer != this.Buffer || __pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM != this.__pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM ? new Enqueue_EZxYNMIvTZjLQujOZS3v4o<T>(this)
                {Buffer = Buffer, __pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM = __pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM} : that_0;
            else
            {
                this.Buffer = Buffer;
                this.__pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM = __pin_group_Input_In_FByco4Tb6pXLPIcFKvDTFM;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270132U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "MUuluuolPeyOdm6FjkdYAE", Name = "StringReceiver_MUuluuolPeyOdm6FjkdYAE")]
    [n9.SerializableAttribute]
    public class StringReceiver_MUuluuolPeyOdm6FjkdYAE<T> : n1.VLObject, n9.IDisposable
    {
        [n11.CreateNewAttribute]
        public static n20.StringReceiver_MUuluuolPeyOdm6FjkdYAE<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new StringReceiver_MUuluuolPeyOdm6FjkdYAE<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n11.CreateDefaultAttribute]
        public static n20.StringReceiver_MUuluuolPeyOdm6FjkdYAE<T> CreateDefault()
        {
            var instance = new StringReceiver_MUuluuolPeyOdm6FjkdYAE<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n20.StringReceiver_MUuluuolPeyOdm6FjkdYAE<T> Update<AdM>(n9.IObservable<T> Input_In, [n11.SerializedDefaultValueAttribute("\r\n", false)] string Terminator_In, n16.Encodings Encoding_In, [n11.SerializedDefaultValueAttribute("False", false)] bool Reset_In, out string Result_Out, out bool On_Data_Out, out int Buffer_Size_Out)
            where AdM : struct, n20.IAdaptiveAsBytes<T>
        {
            var w_0 = default(AdM);
            var State_Output_3 = this.__p_RWtztGnIIQVNarlQGskMD9.Update<AdM>(Input_In: Input_In, Terminator_In: Terminator_In, Encoding_In: Encoding_In, Reset_In: Reset_In, Output_Out: out n9.IObservable<n2.Spread<string>> Output_1, Buffer_Size_Out: out int Buffer_Size_2);
            bool Update_4 = true;
            var Output_5 = this.__p_FYJQXxJ4T76P57Z2mEMEK7;
            if (Update_4)
            {
                n27._Operations_.Update_H<n2.Spread<string>>(Input_In: this.__p_FYJQXxJ4T76P57Z2mEMEK7, Async_Notifications_In: Output_1, Reset_In: Reset_In, Output_Out: out Output_5);
            }

            n27._Operations_.GetData_H<n2.Spread<string>>(Input_In: Output_5, Output_Out: out n21.HoldLatest<n2.Spread<string>> Output_6, Value_Out: out n2.Spread<string> Value_7, On_Data_Out: out bool On_Data_8);
            string Default_Value_9 = "";
            n5._Operations_.LastOrDefault<n2.Spread<string>, string>(Input_In: Value_7, Default_Value_In: Default_Value_9, Output_Out: out n2.Spread<string> Output_10, Result_Out: out string Result_11);
            Result_Out = Result_11;
            On_Data_Out = On_Data_8;
            Buffer_Size_Out = Buffer_Size_2;
            n20.StringReceiver_MUuluuolPeyOdm6FjkdYAE<T> that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = State_Output_3 != this.__p_RWtztGnIIQVNarlQGskMD9 || Output_6 != this.__p_FYJQXxJ4T76P57Z2mEMEK7 ? new StringReceiver_MUuluuolPeyOdm6FjkdYAE<T>(this)
                {__p_RWtztGnIIQVNarlQGskMD9 = State_Output_3, __p_FYJQXxJ4T76P57Z2mEMEK7 = Output_6} : that_12;
            else
            {
                this.__p_RWtztGnIIQVNarlQGskMD9 = State_Output_3;
                this.__p_FYJQXxJ4T76P57Z2mEMEK7 = Output_6;
            }

            return that_12;
        }

        public n20.StringReceiver_MUuluuolPeyOdm6FjkdYAE<T> __Create__(n1.NodeContext Node_Context)
        {
            n15.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "RWtztGnIIQVNarlQGskMD9", 270135U);
            var Output_1 = n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "FYJQXxJ4T76P57Z2mEMEK7", 270142U);
            n2.Spread<string> Initial_Result_3 = n3._Operations_.CreateDefault<string>();
            n27._Operations_.Create_H<n2.Spread<string>>(Node_Context: Node_Context_2, Initial_Result_In: Initial_Result_3, Output_Out: out n21.HoldLatest<n2.Spread<string>> Output_4);
            n20.StringReceiver_MUuluuolPeyOdm6FjkdYAE<T> that_5 = this;
            this.__p_RWtztGnIIQVNarlQGskMD9 = Output_1;
            this.__p_FYJQXxJ4T76P57Z2mEMEK7 = Output_4;
            return that_5;
        }

        public n20.StringReceiver_MUuluuolPeyOdm6FjkdYAE<T> __CreateDefault__()
        {
            n20.StringReceiver_MUuluuolPeyOdm6FjkdYAE<T> that_0 = this;
            this.__p_RWtztGnIIQVNarlQGskMD9 = n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T>.CreateDefault();
            this.__p_FYJQXxJ4T76P57Z2mEMEK7 = default(n21.HoldLatest<n2.Spread<string>>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_RWtztGnIIQVNarlQGskMD9);
            n1.CompilationHelper.SafeDispose(this.__p_FYJQXxJ4T76P57Z2mEMEK7);
            return;
        }

        void n9.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 270135U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "RWtztGnIIQVNarlQGskMD9", Name = "StringReceiver (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> __p_RWtztGnIIQVNarlQGskMD9;
        [n1.ElementAttribute(TracingId = 270142U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "FYJQXxJ4T76P57Z2mEMEK7", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n21.HoldLatest<n2.Spread<string>> __p_FYJQXxJ4T76P57Z2mEMEK7;
        public StringReceiver_MUuluuolPeyOdm6FjkdYAE(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal StringReceiver_MUuluuolPeyOdm6FjkdYAE(StringReceiver_MUuluuolPeyOdm6FjkdYAE<T> other): base(other)
        {
            this.__p_RWtztGnIIQVNarlQGskMD9 = other.__p_RWtztGnIIQVNarlQGskMD9;
            this.__p_FYJQXxJ4T76P57Z2mEMEK7 = other.__p_FYJQXxJ4T76P57Z2mEMEK7;
        }

        protected override n1.IVLObject __With__(n4.IReadOnlyDictionary<string, n9.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RWtztGnIIQVNarlQGskMD9", in __p_RWtztGnIIQVNarlQGskMD9), n1.CompilationHelper.GetValueOrExisting(values, "__p_FYJQXxJ4T76P57Z2mEMEK7", in __p_FYJQXxJ4T76P57Z2mEMEK7));
        }

        internal StringReceiver_MUuluuolPeyOdm6FjkdYAE<T> __WITH__(n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> __p_RWtztGnIIQVNarlQGskMD9, n21.HoldLatest<n2.Spread<string>> __p_FYJQXxJ4T76P57Z2mEMEK7)
        {
            n20.StringReceiver_MUuluuolPeyOdm6FjkdYAE<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_RWtztGnIIQVNarlQGskMD9 != this.__p_RWtztGnIIQVNarlQGskMD9 || __p_FYJQXxJ4T76P57Z2mEMEK7 != this.__p_FYJQXxJ4T76P57Z2mEMEK7 ? new StringReceiver_MUuluuolPeyOdm6FjkdYAE<T>(this)
                {__p_RWtztGnIIQVNarlQGskMD9 = __p_RWtztGnIIQVNarlQGskMD9, __p_FYJQXxJ4T76P57Z2mEMEK7 = __p_FYJQXxJ4T76P57Z2mEMEK7} : that_0;
            else
            {
                this.__p_RWtztGnIIQVNarlQGskMD9 = __p_RWtztGnIIQVNarlQGskMD9;
                this.__p_FYJQXxJ4T76P57Z2mEMEK7 = __p_FYJQXxJ4T76P57Z2mEMEK7;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270176U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "JcOJy40j2RiN1B2Un1x7qv", Name = "StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv")]
    [n9.SerializableAttribute]
    public class StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T> : n1.VLObject, n9.IDisposable
    {
        [n11.CreateNewAttribute]
        public static n20.StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n11.CreateDefaultAttribute]
        public static n20.StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T> CreateDefault()
        {
            var instance = new StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n20.StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T> Update<AdM>(n9.IObservable<T> Input_In, [n11.SerializedDefaultValueAttribute("\r\n", false)] string Terminator_In, n16.Encodings Encoding_In, [n11.SerializedDefaultValueAttribute("False", false)] bool Clear_Queue_In, out string Result_Out, out int Queue_Length_Out, out int Buffer_Size_Out)
            where AdM : struct, n20.IAdaptiveAsBytes<T>
        {
            var w_0 = default(AdM);
            var State_Output_3 = this.__p_Nu7bi7Wzp2gPqGBLmduU8K.Update<AdM>(Input_In: Input_In, Terminator_In: Terminator_In, Encoding_In: Encoding_In, Reset_In: Clear_Queue_In, Output_Out: out n9.IObservable<n2.Spread<string>> Output_1, Buffer_Size_Out: out int Buffer_Size_2);
            n28._Operations_.Sample_H<n2.Spread<string>>(Input_In: this.__p_LkdK2rynqGoO9LEYlbMMbb, Async_Notifications_In: Output_1, Output_Out: out n21.Sampler<n2.Spread<string>> Output_4, Notifications_Out: out n2.Spread<n2.Spread<string>> Notifications_5, On_Data_Out: out bool On_Data_6);
            n3._Operations_.Flatten<n2.Spread<n2.Spread<string>>, string>(Input_In: Notifications_5, Output_Out: out n2.Spread<string> Output_7);
            var Output_10 = this.__p_Fu3DSIgXEk2NwKsJHRdGDs.Update<n2.Spread<string>, n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>(Data_In: Output_7, Reset_In: Clear_Queue_In, Result_Out: out string Result_8, Queue_Length_Out: out int Queue_Length_9);
            Result_Out = Result_8;
            Queue_Length_Out = Queue_Length_9;
            Buffer_Size_Out = Buffer_Size_2;
            n20.StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T> that_11 = this;
            if (this.__GetContext__().IsImmutable)
                that_11 = State_Output_3 != this.__p_Nu7bi7Wzp2gPqGBLmduU8K || Output_4 != this.__p_LkdK2rynqGoO9LEYlbMMbb || Output_10 != this.__p_Fu3DSIgXEk2NwKsJHRdGDs ? new StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T>(this)
                {__p_Nu7bi7Wzp2gPqGBLmduU8K = State_Output_3, __p_LkdK2rynqGoO9LEYlbMMbb = Output_4, __p_Fu3DSIgXEk2NwKsJHRdGDs = Output_10} : that_11;
            else
            {
                this.__p_Nu7bi7Wzp2gPqGBLmduU8K = State_Output_3;
                this.__p_LkdK2rynqGoO9LEYlbMMbb = Output_4;
                this.__p_Fu3DSIgXEk2NwKsJHRdGDs = Output_10;
            }

            return that_11;
        }

        public n20.StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T> __Create__(n1.NodeContext Node_Context)
        {
            n15.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "Nu7bi7Wzp2gPqGBLmduU8K", 270179U);
            var Output_1 = n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "Fu3DSIgXEk2NwKsJHRdGDs", 270187U);
            var Output_3 = n20.Enqueue_EZxYNMIvTZjLQujOZS3v4o<string>.Create(Node_Context: Node_Context_2);
            var Default_4 = n28._Operations_.CreateDefault_H<n2.Spread<string>>();
            n20.StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T> that_5 = this;
            this.__p_Nu7bi7Wzp2gPqGBLmduU8K = Output_1;
            this.__p_Fu3DSIgXEk2NwKsJHRdGDs = Output_3;
            this.__p_LkdK2rynqGoO9LEYlbMMbb = Default_4;
            return that_5;
        }

        public n20.StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T> __CreateDefault__()
        {
            n20.StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T> that_0 = this;
            this.__p_Nu7bi7Wzp2gPqGBLmduU8K = n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T>.CreateDefault();
            this.__p_LkdK2rynqGoO9LEYlbMMbb = n28._Operations_.CreateDefault_H<n2.Spread<string>>();
            this.__p_Fu3DSIgXEk2NwKsJHRdGDs = n20.Enqueue_EZxYNMIvTZjLQujOZS3v4o<string>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Nu7bi7Wzp2gPqGBLmduU8K);
            n1.CompilationHelper.SafeDispose(this.__p_LkdK2rynqGoO9LEYlbMMbb);
            n1.CompilationHelper.SafeDispose(this.__p_Fu3DSIgXEk2NwKsJHRdGDs);
            return;
        }

        void n9.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 270179U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "Nu7bi7Wzp2gPqGBLmduU8K", Name = "StringReceiver (Reactive)", IsManaged = true, IsAutoGenerated = true)]
        public n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> __p_Nu7bi7Wzp2gPqGBLmduU8K;
        [n1.ElementAttribute(TracingId = 270192U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "LkdK2rynqGoO9LEYlbMMbb", Name = "Sampler", IsManaged = true, IsAutoGenerated = true)]
        public n21.Sampler<n2.Spread<string>> __p_LkdK2rynqGoO9LEYlbMMbb;
        [n1.ElementAttribute(TracingId = 270187U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "Fu3DSIgXEk2NwKsJHRdGDs", Name = "Enqueue", IsManaged = true, IsAutoGenerated = true)]
        public n20.Enqueue_EZxYNMIvTZjLQujOZS3v4o<string> __p_Fu3DSIgXEk2NwKsJHRdGDs;
        public StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv(StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T> other): base(other)
        {
            this.__p_Nu7bi7Wzp2gPqGBLmduU8K = other.__p_Nu7bi7Wzp2gPqGBLmduU8K;
            this.__p_LkdK2rynqGoO9LEYlbMMbb = other.__p_LkdK2rynqGoO9LEYlbMMbb;
            this.__p_Fu3DSIgXEk2NwKsJHRdGDs = other.__p_Fu3DSIgXEk2NwKsJHRdGDs;
        }

        protected override n1.IVLObject __With__(n4.IReadOnlyDictionary<string, n9.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Nu7bi7Wzp2gPqGBLmduU8K", in __p_Nu7bi7Wzp2gPqGBLmduU8K), n1.CompilationHelper.GetValueOrExisting(values, "__p_LkdK2rynqGoO9LEYlbMMbb", in __p_LkdK2rynqGoO9LEYlbMMbb), n1.CompilationHelper.GetValueOrExisting(values, "__p_Fu3DSIgXEk2NwKsJHRdGDs", in __p_Fu3DSIgXEk2NwKsJHRdGDs));
        }

        internal StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T> __WITH__(n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> __p_Nu7bi7Wzp2gPqGBLmduU8K, n21.Sampler<n2.Spread<string>> __p_LkdK2rynqGoO9LEYlbMMbb, n20.Enqueue_EZxYNMIvTZjLQujOZS3v4o<string> __p_Fu3DSIgXEk2NwKsJHRdGDs)
        {
            n20.StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Nu7bi7Wzp2gPqGBLmduU8K != this.__p_Nu7bi7Wzp2gPqGBLmduU8K || __p_LkdK2rynqGoO9LEYlbMMbb != this.__p_LkdK2rynqGoO9LEYlbMMbb || __p_Fu3DSIgXEk2NwKsJHRdGDs != this.__p_Fu3DSIgXEk2NwKsJHRdGDs ? new StringReceiver_Queued_JcOJy40j2RiN1B2Un1x7qv<T>(this)
                {__p_Nu7bi7Wzp2gPqGBLmduU8K = __p_Nu7bi7Wzp2gPqGBLmduU8K, __p_LkdK2rynqGoO9LEYlbMMbb = __p_LkdK2rynqGoO9LEYlbMMbb, __p_Fu3DSIgXEk2NwKsJHRdGDs = __p_Fu3DSIgXEk2NwKsJHRdGDs} : that_0;
            else
            {
                this.__p_Nu7bi7Wzp2gPqGBLmduU8K = __p_Nu7bi7Wzp2gPqGBLmduU8K;
                this.__p_LkdK2rynqGoO9LEYlbMMbb = __p_LkdK2rynqGoO9LEYlbMMbb;
                this.__p_Fu3DSIgXEk2NwKsJHRdGDs = __p_Fu3DSIgXEk2NwKsJHRdGDs;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 270240U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "VTgVOTHzRGRPosSUvDhb02", Name = "VL_TokenizerApplication_VTgVOTHzRGRPosSUvDhb02")]
    [n9.SerializableAttribute]
    public class VL_TokenizerApplication_VTgVOTHzRGRPosSUvDhb02 : n1.VLObject, n9.IDisposable
    {
        [n11.CreateNewAttribute]
        public static n20.VL_TokenizerApplication_VTgVOTHzRGRPosSUvDhb02 Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_TokenizerApplication_VTgVOTHzRGRPosSUvDhb02(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n11.CreateDefaultAttribute]
        public static n20.VL_TokenizerApplication_VTgVOTHzRGRPosSUvDhb02 CreateDefault()
        {
            var instance = new VL_TokenizerApplication_VTgVOTHzRGRPosSUvDhb02(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n20.VL_TokenizerApplication_VTgVOTHzRGRPosSUvDhb02 Update()
        {
            return this;
        }

        public n20.VL_TokenizerApplication_VTgVOTHzRGRPosSUvDhb02 __Create__(n1.NodeContext Node_Context)
        {
            n15.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n20.VL_TokenizerApplication_VTgVOTHzRGRPosSUvDhb02 __CreateDefault__()
        {
            return this;
        }

        public void Dispose()
        {
            return;
        }

        void n9.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        public VL_TokenizerApplication_VTgVOTHzRGRPosSUvDhb02(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_TokenizerApplication_VTgVOTHzRGRPosSUvDhb02(VL_TokenizerApplication_VTgVOTHzRGRPosSUvDhb02 other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n4.IReadOnlyDictionary<string, n9.Object> values)
        {
            return __WITH__();
        }

        internal VL_TokenizerApplication_VTgVOTHzRGRPosSUvDhb02 __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 258613U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void AsBytes_Fallback(n4.IReadOnlyList<byte> Input_In, out n4.IReadOnlyList<byte> Output_Out)
        {
            Output_Out = Input_In;
            return;
        }
    }

    public interface IAdaptiveAsBytes<T>
    {
        void AsBytes(T Input_In, out n4.IReadOnlyList<byte> Output_Out);
    }
}

namespace _VL_Tokenizer_.IO.Tokenizer_LengthPrefix
{
    [n1.ElementAttribute(TracingId = 258613U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ParseLength<T>(T Input_In, bool Big_Endian_In, out int Output_Out)
            where T : n4.IEnumerable<byte>
        {
            byte __pad_PuaXtUL4FMdLiUvHvPuoxw_0 = __slot_PuaXtUL4FMdLiUvHvPuoxw;
            int __pad_HEYNmP7lL3kOOMiyY7HAe6_1 = __slot_HEYNmP7lL3kOOMiyY7HAe6;
            string __pad_V3B7bmHwVStMWnSqV2bVvT_2 = __slot_V3B7bmHwVStMWnSqV2bVvT;
            n3._Operations_.Repeat<byte>(Element_In: __pad_PuaXtUL4FMdLiUvHvPuoxw_0, Count_In: __pad_HEYNmP7lL3kOOMiyY7HAe6_1, Result_Out: out n2.Spread<byte> Result_3);
            n3._Operations_.ToBuilder<byte>(Input_In: Result_3, Result_Out: out n2.SpreadBuilder<byte> Result_4);
            n4.IEnumerable<byte> Input_5 = (n4.IEnumerable<byte>)Input_In;
            n5._Operations_.Take<byte>(Input_In: Input_5, Count_In: __pad_HEYNmP7lL3kOOMiyY7HAe6_1, Output_Out: out n4.IEnumerable<byte> Output_6);
            n5._Operations_.Reverse<byte>(Input_In: Output_6, Output_Out: out n4.IEnumerable<byte> Output_7);
            n6._Operations_.Switch_Boolean<n4.IEnumerable<byte>>(Condition_In: Big_Endian_In, Input_In: Output_6, Input_2_In: Output_7, Output_Out: out n4.IEnumerable<byte> Output_8);
            int Index_9 = 0;
            n7._Operations_.SetRange<byte>(Input_In: Result_4, Items_In: Output_8, Index_In: Index_9, Output_Out: out n2.SpreadBuilder<byte> Output_10);
            n4.IEnumerable<byte> Input_11 = (n4.IEnumerable<byte>)Output_10;
            n8._Operations_.FromSequence<byte>(Input_In: Input_11, Result_Out: out byte[] Result_12);
            int Start_Index_13 = 0;
            var Result_14 = n9.BitConverter.ToInt32(value: Result_12, startIndex: Start_Index_13);
            Output_Out = Result_14;
            return;
        }

        [n1.ElementAttribute(TracingId = 269193U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "PuaXtUL4FMdLiUvHvPuoxw", Name = "__slot_PuaXtUL4FMdLiUvHvPuoxw")]
        public static byte __slot_PuaXtUL4FMdLiUvHvPuoxw = 0;
        [n1.ElementAttribute(TracingId = 269202U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "HEYNmP7lL3kOOMiyY7HAe6", Name = "__slot_HEYNmP7lL3kOOMiyY7HAe6")]
        public static int __slot_HEYNmP7lL3kOOMiyY7HAe6 = 4;
        [n1.ElementAttribute(TracingId = 269244U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "V3B7bmHwVStMWnSqV2bVvT", Name = "__slot_V3B7bmHwVStMWnSqV2bVvT")]
        public static string __slot_V3B7bmHwVStMWnSqV2bVvT = "< this is will obviously break if the length specified in 4 bytes is bigger than Int32.MaxValue.";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Tokenizer_.IO.Advanced
{
    [n1.ElementAttribute(TracingId = 269463U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "MRphnhx21MGPjqWD1DrR3L", Name = "Tokenizer_MRphnhx21MGPjqWD1DrR3L")]
    [n9.SerializableAttribute]
    public class Tokenizer_MRphnhx21MGPjqWD1DrR3L<T> : n1.VLObject, n9.IDisposable
    {
        [n11.CreateNewAttribute]
        public static n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new Tokenizer_MRphnhx21MGPjqWD1DrR3L<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n11.CreateDefaultAttribute]
        public static n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<T> CreateDefault()
        {
            var instance = new Tokenizer_MRphnhx21MGPjqWD1DrR3L<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<T> Update<T3, T2, AdM>(T3 Data_In, n9.Func<n2.SpreadBuilder<T>, n12.Result_C<T2>> Tokenize_In, [n11.SerializedDefaultValueAttribute("True", false)] bool Reset_In, out n2.Spread<T2> Result_Out, out int Buffer_Size_Out, out string Status_Out)
            where T3 : n4.IEnumerable<T> where AdM : struct, n14.IAdaptiveCreateDefault<n12.Result_C<T2>>
        {
            var w_0 = default(AdM);
            n2.SpreadBuilder<T> __auto_1 = this.Incoming;
            int __pad_P4RRQ2qGNoxMr2NR3vKLJp_2 = __slot_P4RRQ2qGNoxMr2NR3vKLJp;
            int __pad_UN4u3HwcIl1NcXzLHeuIbf_3 = __slot_UN4u3HwcIl1NcXzLHeuIbf;
            int __pad_RQ2RpFhMR2hOXLs7Dcu3k1_4 = __slot_RQ2RpFhMR2hOXLs7Dcu3k1;
            n2.Spread<string> __pad_LlQA8S01ObnO6GWZmdKhb4_5 = this.__slot_LlQA8S01ObnO6GWZmdKhb4;
            n4.IEnumerable<T> Items_6 = (n4.IEnumerable<T>)Data_In;
            var Output_7 = __auto_1;
            if (Reset_In)
            {
                n7._Operations_.Clear<T>(Input_In: __auto_1, Output_Out: out Output_7);
            }

            n7._Operations_.AddRange<T>(Input_In: Output_7, Items_In: Items_6, Output_Out: out n2.SpreadBuilder<T> Output_8);
            var Output_9 = n7._Operations_.CreateDefault<T2>();
            n2.SpreadBuilder<T> accumulator_11 = Output_8;
            n2.SpreadBuilder<T2> accumulator_12 = Output_9;
            var accumulator_36 = false;
            var breakOutput_37 = false;
            for (var i_10 = 0; i_10 < __pad_P4RRQ2qGNoxMr2NR3vKLJp_2; i_10++)
            {
                var i_local_13 = i_10;
                n4.IEnumerable<T> Input_15 = (n4.IEnumerable<T>)accumulator_11;
                n5._Operations_.IsEmpty<T>(Input_In: Input_15, Result_Out: out bool Result_16);
                var Output_17 = n13._Operations_.CreateDefault<n2.SpreadBuilder<T>, n12.Result_C<T2>, AdM>();
                n6._Operations_.Switch_Boolean<n9.Func<n2.SpreadBuilder<T>, n12.Result_C<T2>>>(Condition_In: Result_16, Input_In: Tokenize_In, Input_2_In: Output_17, Output_Out: out n9.Func<n2.SpreadBuilder<T>, n12.Result_C<T2>> Output_18);
                n13._Operations_.Invoke<n2.SpreadBuilder<T>, n12.Result_C<T2>>(Input_In: Output_18, Arg_In: accumulator_11, Result_Out: out n12.Result_C<T2> Result_19);
                var Output_25 = Result_19.Split(Token_Out: out T2 Token_20, Token_Is_Valid_Out: out bool Token_Is_Valid_21, Byte_Count_Out: out int Byte_Count_22, Collecting_Out: out bool Collecting_23, Needs_More_Input_Out: out bool Needs_More_Input_24);
                var Output_26 = Result_16 || Needs_More_Input_24;
                int Index_27 = 0;
                n7._Operations_.RemoveRange<T>(Input_In: accumulator_11, Index_In: Index_27, Count_In: Byte_Count_22, Output_Out: out n2.SpreadBuilder<T> Output_28);
                n4.IEnumerable<T> Input_29 = (n4.IEnumerable<T>)Output_28;
                n5._Operations_.Any<T>(Input_In: Input_29, Result_Out: out bool Result_30);
                var Output_31 = !Collecting_23;
                var Output_32 = Result_30 && Output_31;
                int Index_33 = 0;
                var Output_34 = Output_28;
                if (Output_32)
                {
                    n7._Operations_.RemoveAt<T>(Input_In: Output_28, Index_In: Index_33, Output_Out: out Output_34);
                }

                var Output_35 = accumulator_12;
                if (Token_Is_Valid_21)
                {
                    n7._Operations_.Add<T2>(Input_In: accumulator_12, Item_In: Token_20, Output_Out: out Output_35);
                }

                accumulator_11 = Output_34;
                accumulator_36 = Collecting_23;
                accumulator_12 = Output_35;
                if (Output_26)
                {
                    breakOutput_37 = Output_26;
                    break;
                }
            }

            var Output_38 = !breakOutput_37;
            var Output_39 = Output_38 && accumulator_36;
            var Output_40 = !accumulator_36;
            int Input_41 = n9.Convert.ToInt32(Output_40);
            var Output_42 = Input_41 * __pad_UN4u3HwcIl1NcXzLHeuIbf_3;
            int Input_43 = n9.Convert.ToInt32(Output_39);
            var Output_44 = Input_43 * __pad_RQ2RpFhMR2hOXLs7Dcu3k1_4;
            var Output_45 = Output_42 + Output_44;
            var Output_46 = accumulator_11;
            if (Output_40)
            {
                n7._Operations_.Clear<T>(Input_In: accumulator_11, Output_Out: out Output_46);
            }

            n4.IEnumerable<T> Input_47 = (n4.IEnumerable<T>)Output_46;
            n5._Operations_.IsEmpty<T>(Input_In: Input_47, Result_Out: out bool Result_48);
            int Input_2_49 = 0;
            n6._Operations_.Switch_Boolean<int>(Condition_In: Result_48, Input_In: Output_45, Input_2_In: Input_2_49, Output_Out: out int Output_50);
            n2.SpreadBuilder<T> __auto_51 = Output_46;
            string Default_Value_52 = "";
            n3._Operations_.GetSlice<string>(Input_In: __pad_LlQA8S01ObnO6GWZmdKhb4_5, Default_Value_In: Default_Value_52, Index_In: Output_50, Result_Out: out string Result_53);
            n7._Operations_.ToSpread<T2>(Input_In: accumulator_12, Output_Out: out n2.SpreadBuilder<T2> Output_54, Result_Out: out n2.Spread<T2> Result_55);
            n7._Operations_.Count<T>(Input_In: __auto_51, Output_Out: out n2.SpreadBuilder<T> Output_56, Count_Out: out int Count_57);
            Result_Out = Result_55;
            Buffer_Size_Out = Count_57;
            Status_Out = Result_53;
            n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<T> that_58 = this;
            if (this.__GetContext__().IsImmutable)
                that_58 = Output_46 != this.Incoming ? new Tokenizer_MRphnhx21MGPjqWD1DrR3L<T>(this)
                {Incoming = Output_46} : that_58;
            else
            {
                this.Incoming = Output_46;
            }

            return that_58;
        }

        public n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<T> __Create__(n1.NodeContext Node_Context)
        {
            n15.RuntimeHelpers.EnsureSufficientExecutionStack();
            string __pad_DpKvnVTWOtMNrrtBnfhqZa_0 = __slot_DpKvnVTWOtMNrrtBnfhqZa;
            string __pad_J3iYctwFFhDLuSjeBQc2SM_1 = __slot_J3iYctwFFhDLuSjeBQc2SM;
            string __pad_LTHT5Wd7e9UN4JfQfy9CaG_2 = __slot_LTHT5Wd7e9UN4JfQfy9CaG;
            var builder_3 = n11.CollectionBuilders.GetBuilder(n3._Operations_.CreateDefault<string>(), 3);
            builder_3.Add(__pad_DpKvnVTWOtMNrrtBnfhqZa_0);
            builder_3.Add(__pad_J3iYctwFFhDLuSjeBQc2SM_1);
            builder_3.Add(__pad_LTHT5Wd7e9UN4JfQfy9CaG_2);
            var __pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS_4 = builder_3.Commit();
            n3._Operations_.Cons<string>(Input_In: __pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS_4, Result_Out: out n2.Spread<string> Result_5);
            n2.Spread<string> __pad_LlQA8S01ObnO6GWZmdKhb4_6 = Result_5;
            n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<T> that_7 = this;
            this.__slot_LlQA8S01ObnO6GWZmdKhb4 = Result_5;
            this.Incoming = n7._Operations_.CreateDefault<T>();
            this.__pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS = __pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS_4;
            return that_7;
        }

        public n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<T> __CreateDefault__()
        {
            n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<T> that_0 = this;
            this.__slot_LlQA8S01ObnO6GWZmdKhb4 = n3._Operations_.CreateDefault<string>();
            this.Incoming = n7._Operations_.CreateDefault<T>();
            this.__pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS = n3._Operations_.CreateDefault<string>();
            return that_0;
        }

        public void Dispose()
        {
            return;
        }

        void n9.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 269558U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "OokPInQCnM1PzxpUUHPcMF", Name = "__slot_OokPInQCnM1PzxpUUHPcMF")]
        public static string __slot_OokPInQCnM1PzxpUUHPcMF = "errors:\r\n1) no tokenizer is collecting: Invalid Input\r\n2) a tokenizer is collecting but the while-loop overflowed: Buffer Overflow\r\n\r\n";
        [n1.ElementAttribute(TracingId = 269559U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "DpKvnVTWOtMNrrtBnfhqZa", Name = "__slot_DpKvnVTWOtMNrrtBnfhqZa")]
        public static string __slot_DpKvnVTWOtMNrrtBnfhqZa = "OK";
        [n1.ElementAttribute(TracingId = 269560U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "J3iYctwFFhDLuSjeBQc2SM", Name = "__slot_J3iYctwFFhDLuSjeBQc2SM")]
        public static string __slot_J3iYctwFFhDLuSjeBQc2SM = "Error: Invalid input";
        [n1.ElementAttribute(TracingId = 269561U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "LTHT5Wd7e9UN4JfQfy9CaG", Name = "__slot_LTHT5Wd7e9UN4JfQfy9CaG")]
        public static string __slot_LTHT5Wd7e9UN4JfQfy9CaG = "Error: Buffer overflow";
        [n1.ElementAttribute(TracingId = 269572U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "LlQA8S01ObnO6GWZmdKhb4", Name = "__slot_LlQA8S01ObnO6GWZmdKhb4")]
        public n2.Spread<string> __slot_LlQA8S01ObnO6GWZmdKhb4;
        [n1.ElementAttribute(TracingId = 269587U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "UN4u3HwcIl1NcXzLHeuIbf", Name = "__slot_UN4u3HwcIl1NcXzLHeuIbf")]
        public static int __slot_UN4u3HwcIl1NcXzLHeuIbf = 1;
        [n1.ElementAttribute(TracingId = 269592U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "RQ2RpFhMR2hOXLs7Dcu3k1", Name = "__slot_RQ2RpFhMR2hOXLs7Dcu3k1")]
        public static int __slot_RQ2RpFhMR2hOXLs7Dcu3k1 = 2;
        [n1.ElementAttribute(TracingId = 269597U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "UywjGmhsc1OLQYOfeC0qv9", Name = "__slot_UywjGmhsc1OLQYOfeC0qv9")]
        public static string __slot_UywjGmhsc1OLQYOfeC0qv9 = "reasons to break the loop:\r\n- buffer is empty\r\n- a tokenizer is collecting but waiting for more input";
        [n1.ElementAttribute(TracingId = 269805U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "P4RRQ2qGNoxMr2NR3vKLJp", Name = "__slot_P4RRQ2qGNoxMr2NR3vKLJp")]
        public static int __slot_P4RRQ2qGNoxMr2NR3vKLJp = 9999;
        [n1.ElementAttribute(TracingId = 269477U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "GnxGPy0kB8cNRRxun7dbq8", Name = "Incoming")]
        public n2.SpreadBuilder<T> Incoming;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n2.Spread<string> __pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS = default(n2.Spread<string>);
        static Tokenizer_MRphnhx21MGPjqWD1DrR3L()
        {
        }

        public Tokenizer_MRphnhx21MGPjqWD1DrR3L(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Tokenizer_MRphnhx21MGPjqWD1DrR3L(Tokenizer_MRphnhx21MGPjqWD1DrR3L<T> other): base(other)
        {
            this.__slot_LlQA8S01ObnO6GWZmdKhb4 = other.__slot_LlQA8S01ObnO6GWZmdKhb4;
            this.Incoming = other.Incoming;
            this.__pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS = other.__pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS;
        }

        protected override n1.IVLObject __With__(n4.IReadOnlyDictionary<string, n9.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_LlQA8S01ObnO6GWZmdKhb4", in __slot_LlQA8S01ObnO6GWZmdKhb4), n1.CompilationHelper.GetValueOrExisting(values, "Incoming", in Incoming), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS", in __pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS));
        }

        internal Tokenizer_MRphnhx21MGPjqWD1DrR3L<T> __WITH__(n2.Spread<string> __slot_LlQA8S01ObnO6GWZmdKhb4, n2.SpreadBuilder<T> Incoming, n2.Spread<string> __pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS)
        {
            n10.Tokenizer_MRphnhx21MGPjqWD1DrR3L<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_LlQA8S01ObnO6GWZmdKhb4 != this.__slot_LlQA8S01ObnO6GWZmdKhb4 || Incoming != this.Incoming || __pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS != this.__pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS ? new Tokenizer_MRphnhx21MGPjqWD1DrR3L<T>(this)
                {__slot_LlQA8S01ObnO6GWZmdKhb4 = __slot_LlQA8S01ObnO6GWZmdKhb4, Incoming = Incoming, __pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS = __pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS} : that_0;
            else
            {
                this.__slot_LlQA8S01ObnO6GWZmdKhb4 = __slot_LlQA8S01ObnO6GWZmdKhb4;
                this.Incoming = Incoming;
                this.__pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS = __pin_group_Input_In_VeVGDjoceTxPr8qkoFENKS;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 269883U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "E1Sn9LsqDvCOKGivxF00mS", Name = "StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS")]
    [n9.SerializableAttribute]
    public class StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> : n1.VLObject, n9.IDisposable
    {
        [n11.CreateNewAttribute]
        public static n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n11.CreateDefaultAttribute]
        public static n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> CreateDefault()
        {
            var instance = new StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> Update<AdM>(n9.IObservable<T> Input_In, [n11.SerializedDefaultValueAttribute("\r\n", false)] string Terminator_In, n16.Encodings Encoding_In, [n11.SerializedDefaultValueAttribute("False", false)] bool Reset_In, out n9.IObservable<n2.Spread<string>> Output_Out, out int Buffer_Size_Out)
            where AdM : struct, n20.IAdaptiveAsBytes<T>
        {
            var w_0 = default(AdM);
            n19.Reference_C<int> __pad_GyVUWZBljnFPEcVCMn9ZpL_1 = this.__slot_GyVUWZBljnFPEcVCMn9ZpL;
            var Result_2 = n17.StringExtensions.ToBytes(input: Terminator_In, encoding: Encoding_In);
            n4.IEnumerable<byte> Postfix_3 = (n4.IEnumerable<byte>)Result_2;
            var __fallback___4 = n1.ServiceRegistry.Current;
            n22._Operations_.Update_H<n9.Object, T, n2.Spread<string>>(Input_In: this.__p_PvogK2RLxAQPKe6XXPLq3x, Messages_In: Input_In, Reset_In: Reset_In, Update_In: (n9.Object s_7, T Input_1_In_8) =>
            {
                using var __current_5 = __fallback___4.MakeCurrentIfNone();
                var state_6 = n1.CompilationHelper.Restore<__DdA8muAriaIP9CEFgH2JTd>(s_7, __GetContext__());
                w_0.AsBytes(Input_In: Input_1_In_8, Output_Out: out n4.IReadOnlyList<byte> Output_9);
                n4.IEnumerable<byte> Data_10 = (n4.IEnumerable<byte>)Output_9;
                bool Reset_11 = false;
                var Output_15 = state_6.__p_RIYycZiwcmhQavsuuOSwPa.Update(Data_In: Data_10, Postfix_In: Postfix_3, Reset_In: Reset_11, Result_Out: out n2.Spread<n2.Spread<byte>> Result_12, Buffer_Size_Out: out int Buffer_Size_13, Status_Out: out string Status_14);
                var builder_23 = n11.CollectionBuilders.GetBuilder(state_6.__cp_SVnjqvPxkZcMTzPRQYCUc4, 16);
                n2.Spread<string> output_24;
                try
                {
                    var i_18 = 0;
                    foreach (var item_16 in n11.CollectionExtensions.AsSpan(Result_12))
                    {
                        var splicer_17 = item_16;
                        var i_local_19 = i_18;
                        n4.IEnumerable<byte> Input_21 = (n4.IEnumerable<byte>)splicer_17;
                        var Result_22 = n17.StringExtensions.FromBytes(input: Input_21, encoding: Encoding_In);
                        builder_23.Add(Result_22);
                        i_18++;
                    }
                }
                finally
                {
                    output_24 = builder_23.Commit();
                }

                n4.IEnumerable<n2.Spread<byte>> Input_25 = (n4.IEnumerable<n2.Spread<byte>>)Result_12;
                n5._Operations_.Any<n2.Spread<byte>>(Input_In: Input_25, Result_Out: out bool Result_26);
                var Output_27 = __pad_GyVUWZBljnFPEcVCMn9ZpL_1.SetData(Data_In: Buffer_Size_13);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = Output_15 != state_6.__p_RIYycZiwcmhQavsuuOSwPa || output_24 != state_6.__cp_SVnjqvPxkZcMTzPRQYCUc4 ? new __DdA8muAriaIP9CEFgH2JTd(state_6)
                    {__p_RIYycZiwcmhQavsuuOSwPa = Output_15, __cp_SVnjqvPxkZcMTzPRQYCUc4 = output_24} : state_6;
                else
                {
                    state_6.__p_RIYycZiwcmhQavsuuOSwPa = Output_15;
                    state_6.__cp_SVnjqvPxkZcMTzPRQYCUc4 = output_24;
                }

                return n9.Tuple.Create<n9.Object, n2.Spread<string>, bool>(state_6, output_24, Result_26);
            }

            , Create_In: () =>
            {
                using var __current_28 = __fallback___4.MakeCurrentIfNone();
                var state_6 = new __DdA8muAriaIP9CEFgH2JTd(__GetContext__(), n1.VLObject.NewIdentity())
                {__cp_SVnjqvPxkZcMTzPRQYCUc4 = n3._Operations_.CreateDefault<string>()};
                n1.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "RIYycZiwcmhQavsuuOSwPa", 269907U);
                var Output_30 = n20.Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2.Create(Node_Context: Node_Context_29);
                state_6.__p_RIYycZiwcmhQavsuuOSwPa = Output_30;
                return state_6;
            }

            , Output_Out: out n21.ForEachKeep<n9.Object, T, n2.Spread<string>> Output_31, Result_Out: out n9.IObservable<n2.Spread<string>> Result_32);
            var Output_34 = __pad_GyVUWZBljnFPEcVCMn9ZpL_1.Data_(Data_Out: out int Data_33);
            Output_Out = Result_32;
            Buffer_Size_Out = Data_33;
            n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> that_35 = this;
            if (this.__GetContext__().IsImmutable)
                that_35 = Output_31 != this.__p_PvogK2RLxAQPKe6XXPLq3x ? new StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T>(this)
                {__p_PvogK2RLxAQPKe6XXPLq3x = Output_31} : that_35;
            else
            {
                this.__p_PvogK2RLxAQPKe6XXPLq3x = Output_31;
            }

            return that_35;
        }

        public n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> __Create__(n1.NodeContext Node_Context)
        {
            n15.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "A78gH36umTIQMw64CA43UE", 269937U);
            int Data_1 = 0;
            var Output_2 = n19.Reference_C<int>.Create<n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>(Node_Context: Node_Context_0, Data_In: Data_1);
            n19.Reference_C<int> __pad_GyVUWZBljnFPEcVCMn9ZpL_3 = Output_2;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "PvogK2RLxAQPKe6XXPLq3x", 269894U);
            n22._Operations_.Create_H<n9.Object, T, n2.Spread<string>>(Node_Context: Node_Context_4, Output_Out: out n21.ForEachKeep<n9.Object, T, n2.Spread<string>> Output_5);
            n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> that_6 = this;
            this.__slot_GyVUWZBljnFPEcVCMn9ZpL = Output_2;
            this.__p_PvogK2RLxAQPKe6XXPLq3x = Output_5;
            return that_6;
        }

        public n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> __CreateDefault__()
        {
            n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> that_0 = this;
            this.__slot_GyVUWZBljnFPEcVCMn9ZpL = n19.Reference_C<int>.CreateDefault<n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>();
            this.__p_PvogK2RLxAQPKe6XXPLq3x = default(n21.ForEachKeep<n9.Object, T, n2.Spread<string>>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_PvogK2RLxAQPKe6XXPLq3x);
            return;
        }

        void n9.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 269945U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "GyVUWZBljnFPEcVCMn9ZpL", Name = "__slot_GyVUWZBljnFPEcVCMn9ZpL")]
        public n19.Reference_C<int> __slot_GyVUWZBljnFPEcVCMn9ZpL;
        [n1.ElementAttribute(TracingId = 269894U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "PvogK2RLxAQPKe6XXPLq3x", Name = "ForEach (Keep)", IsManaged = true, IsAutoGenerated = true)]
        public n21.ForEachKeep<n9.Object, T, n2.Spread<string>> __p_PvogK2RLxAQPKe6XXPLq3x;
        public StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS(StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> other): base(other)
        {
            this.__slot_GyVUWZBljnFPEcVCMn9ZpL = other.__slot_GyVUWZBljnFPEcVCMn9ZpL;
            this.__p_PvogK2RLxAQPKe6XXPLq3x = other.__p_PvogK2RLxAQPKe6XXPLq3x;
        }

        protected override n1.IVLObject __With__(n4.IReadOnlyDictionary<string, n9.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_GyVUWZBljnFPEcVCMn9ZpL", in __slot_GyVUWZBljnFPEcVCMn9ZpL), n1.CompilationHelper.GetValueOrExisting(values, "__p_PvogK2RLxAQPKe6XXPLq3x", in __p_PvogK2RLxAQPKe6XXPLq3x));
        }

        internal StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> __WITH__(n19.Reference_C<int> __slot_GyVUWZBljnFPEcVCMn9ZpL, n21.ForEachKeep<n9.Object, T, n2.Spread<string>> __p_PvogK2RLxAQPKe6XXPLq3x)
        {
            n10.StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_GyVUWZBljnFPEcVCMn9ZpL != this.__slot_GyVUWZBljnFPEcVCMn9ZpL || __p_PvogK2RLxAQPKe6XXPLq3x != this.__p_PvogK2RLxAQPKe6XXPLq3x ? new StringReceiver_Reactive_E1Sn9LsqDvCOKGivxF00mS<T>(this)
                {__slot_GyVUWZBljnFPEcVCMn9ZpL = __slot_GyVUWZBljnFPEcVCMn9ZpL, __p_PvogK2RLxAQPKe6XXPLq3x = __p_PvogK2RLxAQPKe6XXPLq3x} : that_0;
            else
            {
                this.__slot_GyVUWZBljnFPEcVCMn9ZpL = __slot_GyVUWZBljnFPEcVCMn9ZpL;
                this.__p_PvogK2RLxAQPKe6XXPLq3x = __p_PvogK2RLxAQPKe6XXPLq3x;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "DdA8muAriaIP9CEFgH2JTd", Name = "__DdA8muAriaIP9CEFgH2JTd")]
        [n9.SerializableAttribute]
        public class __DdA8muAriaIP9CEFgH2JTd : n1.VLObject, n9.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RIYycZiwcmhQavsuuOSwPa);
                return;
            }

            [n1.ElementAttribute(TracingId = 269907U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "RIYycZiwcmhQavsuuOSwPa", Name = "Tokenizer (Postfix)", IsManaged = true, IsAutoGenerated = true)]
            public n20.Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 __p_RIYycZiwcmhQavsuuOSwPa;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n2.Spread<string> __cp_SVnjqvPxkZcMTzPRQYCUc4;
            public __DdA8muAriaIP9CEFgH2JTd(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DdA8muAriaIP9CEFgH2JTd(__DdA8muAriaIP9CEFgH2JTd other): base(other)
            {
                this.__p_RIYycZiwcmhQavsuuOSwPa = other.__p_RIYycZiwcmhQavsuuOSwPa;
                this.__cp_SVnjqvPxkZcMTzPRQYCUc4 = other.__cp_SVnjqvPxkZcMTzPRQYCUc4;
            }

            protected override n1.IVLObject __With__(n4.IReadOnlyDictionary<string, n9.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RIYycZiwcmhQavsuuOSwPa", in __p_RIYycZiwcmhQavsuuOSwPa), n1.CompilationHelper.GetValueOrExisting(values, "__cp_SVnjqvPxkZcMTzPRQYCUc4", in __cp_SVnjqvPxkZcMTzPRQYCUc4));
            }

            internal __DdA8muAriaIP9CEFgH2JTd __WITH__(n20.Tokenizer_Postfix_MzjqKVRPaSGPzFUlLZkwS2 __p_RIYycZiwcmhQavsuuOSwPa, n2.Spread<string> __cp_SVnjqvPxkZcMTzPRQYCUc4)
            {
                __DdA8muAriaIP9CEFgH2JTd that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RIYycZiwcmhQavsuuOSwPa != this.__p_RIYycZiwcmhQavsuuOSwPa || __cp_SVnjqvPxkZcMTzPRQYCUc4 != this.__cp_SVnjqvPxkZcMTzPRQYCUc4 ? new __DdA8muAriaIP9CEFgH2JTd(this)
                    {__p_RIYycZiwcmhQavsuuOSwPa = __p_RIYycZiwcmhQavsuuOSwPa, __cp_SVnjqvPxkZcMTzPRQYCUc4 = __cp_SVnjqvPxkZcMTzPRQYCUc4} : that_0;
                else
                {
                    this.__p_RIYycZiwcmhQavsuuOSwPa = __p_RIYycZiwcmhQavsuuOSwPa;
                    this.__cp_SVnjqvPxkZcMTzPRQYCUc4 = __cp_SVnjqvPxkZcMTzPRQYCUc4;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Tokenizer_.IO.Tokenizer.Advanced
{
    [n1.ElementAttribute(TracingId = 269606U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "KGcPfUrFK5QP5YtIqjmjTK", Name = "Result_C")]
    [n9.SerializableAttribute]
    public class Result_C<T> : n1.VLObject, n9.IDisposable
    {
        [n11.CreateNewAttribute]
        public static n12.Result_C<T> Create<AdM>(n1.NodeContext Node_Context, T Token_In, bool Token_Is_Valid_In, int Byte_Count_In, bool Collecting_In, bool Needs_More_Input_In)
            where AdM : struct, n14.IAdaptiveCreateDefault<T>
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new Result_C<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context, Token_In, Token_Is_Valid_In, Byte_Count_In, Collecting_In, Needs_More_Input_In);
        }

        [n11.CreateDefaultAttribute]
        public static n12.Result_C<T> CreateDefault<AdM>()
            where AdM : struct, n14.IAdaptiveCreateDefault<T>
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new Result_C<T>(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n12.Result_C<T> Update()
        {
            return this;
        }

        public n12.Result_C<T> Split(out T Token_Out, out bool Token_Is_Valid_Out, out int Byte_Count_Out, out bool Collecting_Out, out bool Needs_More_Input_Out)
        {
            T __auto_0 = this.Token;
            bool __auto_1 = this.TokenIsValid;
            int __auto_2 = this.ByteCount;
            bool __auto_3 = this.KeepCollecting;
            bool __auto_4 = this.NeedsMoreInput;
            Token_Out = __auto_0;
            Token_Is_Valid_Out = __auto_1;
            Byte_Count_Out = __auto_2;
            Collecting_Out = __auto_3;
            Needs_More_Input_Out = __auto_4;
            return this;
        }

        public n12.Result_C<T> __Create__<AdM>(n1.NodeContext Node_Context, T Token_In, bool Token_Is_Valid_In, int Byte_Count_In, bool Collecting_In, bool Needs_More_Input_In)
            where AdM : struct, n14.IAdaptiveCreateDefault<T>
        {
            n15.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            this.ByteCount = 0;
            w_0.CreateDefault(out T __out_0);
            this.Token = __out_0;
            this.KeepCollecting = false;
            this.TokenIsValid = false;
            this.NeedsMoreInput = false;
            this.Token = Token_In;
            T __auto_1 = Token_In;
            this.TokenIsValid = Token_Is_Valid_In;
            bool __auto_2 = Token_Is_Valid_In;
            this.ByteCount = Byte_Count_In;
            int __auto_3 = Byte_Count_In;
            this.KeepCollecting = Collecting_In;
            bool __auto_4 = Collecting_In;
            this.NeedsMoreInput = Needs_More_Input_In;
            bool __auto_5 = Needs_More_Input_In;
            return this;
        }

        public n12.Result_C<T> __CreateDefault__<AdM>()
            where AdM : struct, n14.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            this.ByteCount = 0;
            w_0.CreateDefault(out T __out_1);
            this.Token = __out_1;
            this.KeepCollecting = false;
            this.TokenIsValid = false;
            this.NeedsMoreInput = false;
            return this;
        }

        public void Dispose()
        {
            return;
        }

        void n9.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 269629U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "GBmwNoW1VYvOlCdS5iOdr1", Name = "__slot_GBmwNoW1VYvOlCdS5iOdr1")]
        public static string __slot_GBmwNoW1VYvOlCdS5iOdr1 = "rest of data that is available fits the tokenizer";
        [n1.ElementAttribute(TracingId = 269630U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "UuhX6cylV3uQZgEHvwkqTr", Name = "__slot_UuhX6cylV3uQZgEHvwkqTr")]
        public static string __slot_UuhX6cylV3uQZgEHvwkqTr = "collecting but currently available bytes are not enough";
        [n1.ElementAttribute(TracingId = 269610U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "UywF3DfM69sMnIrVVsU7sN", Name = "ByteCount")]
        public int ByteCount;
        [n1.ElementAttribute(TracingId = 269612U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "RGlfjFUODDRPgEehgUD1N6", Name = "Token")]
        public T Token;
        [n1.ElementAttribute(TracingId = 269614U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "Bw10YTxpTS5OqWIJiTFsKB", Name = "KeepCollecting")]
        public bool KeepCollecting;
        [n1.ElementAttribute(TracingId = 269622U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "EsGzc16UjcMOmeMbv24IzI", Name = "TokenIsValid")]
        public bool TokenIsValid;
        [n1.ElementAttribute(TracingId = 269626U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "F7qgvFNmxHYMtJT0q31vuZ", Name = "NeedsMoreInput")]
        public bool NeedsMoreInput;
        static Result_C()
        {
        }

        public Result_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Result_C(Result_C<T> other): base(other)
        {
            this.ByteCount = other.ByteCount;
            this.Token = other.Token;
            this.KeepCollecting = other.KeepCollecting;
            this.TokenIsValid = other.TokenIsValid;
            this.NeedsMoreInput = other.NeedsMoreInput;
        }

        protected override n1.IVLObject __With__(n4.IReadOnlyDictionary<string, n9.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "ByteCount", in ByteCount), n1.CompilationHelper.GetValueOrExisting(values, "Token", in Token), n1.CompilationHelper.GetValueOrExisting(values, "KeepCollecting", in KeepCollecting), n1.CompilationHelper.GetValueOrExisting(values, "TokenIsValid", in TokenIsValid), n1.CompilationHelper.GetValueOrExisting(values, "NeedsMoreInput", in NeedsMoreInput));
        }

        internal Result_C<T> __WITH__(int ByteCount, T Token, bool KeepCollecting, bool TokenIsValid, bool NeedsMoreInput)
        {
            n12.Result_C<T> that_0 = this;
            this.ByteCount = ByteCount;
            this.Token = Token;
            this.KeepCollecting = KeepCollecting;
            this.TokenIsValid = TokenIsValid;
            this.NeedsMoreInput = NeedsMoreInput;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 258613U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Group_Spectral<T3, T, T2, AdM>(T3 Tokenizers_In, out n9.Func<T, n12.Result_C<T2>> Tokenize_Out)
            where T3 : n4.IEnumerable<n9.Func<T, n12.Result_C<T2>>> where AdM : struct, n14.IAdaptiveCreateDefault<T2>
        {
            var w_0 = default(AdM);
            var __fallback___1 = n1.ServiceRegistry.Current;
            n9.Func<T, n12.Result_C<T2>> Functionality_23 = (T Arg_In_3) =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                w_0.CreateDefault(Output_Out: out T2 Output_4);
                n1.NodeContext Node_Context_5 = n1.NodeContext.Default.CreateSubContext("GwtzrCcDa6uL2tyjBJ0NTO", "AY3GScyAW9FPUZoQLMLlFV", 269704U);
                bool Token_Is_Valid_6 = false;
                int Byte_Count_7 = 0;
                bool Collecting_8 = true;
                bool Needs_More_Input_9 = true;
                var Output_10 = n12.Result_C<T2>.Create<AdM>(Node_Context: Node_Context_5, Token_In: Output_4, Token_Is_Valid_In: Token_Is_Valid_6, Byte_Count_In: Byte_Count_7, Collecting_In: Collecting_8, Needs_More_Input_In: Needs_More_Input_9);
                n12.Result_C<T2> accumulator_12 = Output_10;
                var i_14 = 0;
                foreach (var item_11 in Tokenizers_In)
                {
                    var splicer_13 = item_11;
                    var i_local_15 = i_14;
                    n13._Operations_.Invoke<T, n12.Result_C<T2>>(Input_In: splicer_13, Arg_In: Arg_In_3, Result_Out: out n12.Result_C<T2> Result_16);
                    var Output_22 = Result_16.Split(Token_Out: out T2 Token_17, Token_Is_Valid_Out: out bool Token_Is_Valid_18, Byte_Count_Out: out int Byte_Count_19, Collecting_Out: out bool Collecting_20, Needs_More_Input_Out: out bool Needs_More_Input_21);
                    accumulator_12 = Output_22;
                    if (Collecting_20)
                    {
                        break;
                    }

                    i_14++;
                }

                return accumulator_12;
            }

            ;
            Tokenize_Out = Functionality_23;
            return;
        }

        public static void Contains(n4.IEnumerable<byte> Input_In, n4.IEnumerable<byte> Separator_In, out bool Output_Out, out int Position_Out)
        {
            n16.Encodings __pad_FUpIxuHY2qYL1hKu0IRWz9_0 = __slot_FUpIxuHY2qYL1hKu0IRWz9;
            var Result_1 = n17.StringExtensions.FromBytes(input: Input_In, encoding: __pad_FUpIxuHY2qYL1hKu0IRWz9_0);
            var Result_2 = n17.StringExtensions.FromBytes(input: Separator_In, encoding: __pad_FUpIxuHY2qYL1hKu0IRWz9_0);
            n9.StringComparison Comparison_Type_3 = default(n9.StringComparison);
            var Result_4 = Result_1.IndexOf(value: Result_2, comparisonType: Comparison_Type_3);
            int Input_2_5 = -1;
            var Result_6 = Result_4 > Input_2_5;
            Output_Out = Result_6;
            Position_Out = Result_4;
            return;
        }

        public static void StartsWith(n4.IEnumerable<byte> Input_In, n4.IEnumerable<byte> Separator_In, out bool Result_Out)
        {
            n2.Spread<bool> __cp_UcyyPjG1ZHbLGdFSl53CSq = n3._Operations_.CreateDefault<bool>();
            var enumerator_0 = Separator_In.GetEnumerator();
            var enumerator_2 = Input_In.GetEnumerator();
            var builder_7 = n11.CollectionBuilders.GetBuilder(__cp_UcyyPjG1ZHbLGdFSl53CSq, 16);
            n2.Spread<bool> output_8;
            try
            {
                var i_4 = 0;
                while (enumerator_0.MoveNext() && enumerator_2.MoveNext())
                {
                    var splicer_1 = enumerator_0.Current;
                    var splicer_3 = enumerator_2.Current;
                    var i_local_5 = i_4;
                    var Result_6 = splicer_1 == splicer_3;
                    builder_7.Add(Result_6);
                    i_4++;
                }
            }
            finally
            {
                enumerator_0.Dispose();
                enumerator_2.Dispose();
                output_8 = builder_7.Commit();
            }

            n4.IEnumerable<bool> Input_9 = (n4.IEnumerable<bool>)output_8;
            var Result_10 = n18.EnumerableNodes.AND(input: Input_9);
            Result_Out = Result_10;
            return;
        }

        [n1.ElementAttribute(TracingId = 269768U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", PersistentId = "FUpIxuHY2qYL1hKu0IRWz9", Name = "__slot_FUpIxuHY2qYL1hKu0IRWz9")]
        public static n16.Encodings __slot_FUpIxuHY2qYL1hKu0IRWz9 = n1.CompilationHelper.Deserialize<n16.Encodings>("SystemDefault", false, "GwtzrCcDa6uL2tyjBJ0NTO", "FUpIxuHY2qYL1hKu0IRWz9");
        static _Operations_()
        {
        }
    }
}

namespace _VL_Tokenizer_.IO.Tokenizer
{
    [n1.ElementAttribute(TracingId = 258613U, DocumentId = "GwtzrCcDa6uL2tyjBJ0NTO", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void PostfixBytes(n4.IEnumerable<byte> Input_In, n4.IEnumerable<byte> Postfix_In, out n2.Spread<byte> Result_Out)
        {
            n2.Spread<n4.IEnumerable<byte>> __pin_group_Input_In_I3b9FG1LJdrMJSZNecQdoE = default(n2.Spread<n4.IEnumerable<byte>>);
            var builder_0 = n11.CollectionBuilders.GetBuilder(__pin_group_Input_In_I3b9FG1LJdrMJSZNecQdoE, 2);
            builder_0.Add(Input_In);
            builder_0.Add(Postfix_In);
            var __pin_group_Input_In_I3b9FG1LJdrMJSZNecQdoE_1 = builder_0.Commit();
            n3._Operations_.Concat<byte>(Input_In: __pin_group_Input_In_I3b9FG1LJdrMJSZNecQdoE_1, Output_Out: out n2.Spread<byte> Output_2);
            Result_Out = Output_2;
            return;
        }

        public static void FrameBytes(n4.IEnumerable<byte> Input_In, n4.IEnumerable<byte> Prefix_In, n4.IEnumerable<byte> Postfix_In, out n2.Spread<byte> Result_Out)
        {
            n2.Spread<n4.IEnumerable<byte>> __pin_group_Input_In_QJP5YvW8UP6MFa4NdISfvk = default(n2.Spread<n4.IEnumerable<byte>>);
            var builder_0 = n11.CollectionBuilders.GetBuilder(__pin_group_Input_In_QJP5YvW8UP6MFa4NdISfvk, 3);
            builder_0.Add(Prefix_In);
            builder_0.Add(Input_In);
            builder_0.Add(Postfix_In);
            var __pin_group_Input_In_QJP5YvW8UP6MFa4NdISfvk_1 = builder_0.Commit();
            n3._Operations_.Concat<byte>(Input_In: __pin_group_Input_In_QJP5YvW8UP6MFa4NdISfvk_1, Output_Out: out n2.Spread<byte> Output_2);
            Result_Out = Output_2;
            return;
        }

        public static void PrefixLength(n4.IEnumerable<byte> Input_In, bool Big_Endian_In, [n11.SerializedDefaultValueAttribute("1", false)] int Byte_Count_In, out n2.Spread<byte> Result_Out)
        {
            n2.Spread<n4.IEnumerable<byte>> __pin_group_Input_In_JHYXBDHnp12PITpPTgBdp9 = default(n2.Spread<n4.IEnumerable<byte>>);
            n5._Operations_.Count<byte>(Input_In: Input_In, Result_Out: out int Result_0);
            var Result_1 = n9.BitConverter.GetBytes(value: Result_0);
            n4.IEnumerable<byte> Input_2 = (n4.IEnumerable<byte>)Result_1;
            n5._Operations_.Take<byte>(Input_In: Input_2, Count_In: Byte_Count_In, Output_Out: out n4.IEnumerable<byte> Output_3);
            n5._Operations_.Reverse<byte>(Input_In: Output_3, Output_Out: out n4.IEnumerable<byte> Output_4);
            n6._Operations_.Switch_Boolean<n4.IEnumerable<byte>>(Condition_In: Big_Endian_In, Input_In: Output_3, Input_2_In: Output_4, Output_Out: out n4.IEnumerable<byte> Output_5);
            var builder_6 = n11.CollectionBuilders.GetBuilder(__pin_group_Input_In_JHYXBDHnp12PITpPTgBdp9, 2);
            builder_6.Add(Output_5);
            builder_6.Add(Input_In);
            var __pin_group_Input_In_JHYXBDHnp12PITpPTgBdp9_7 = builder_6.Commit();
            n3._Operations_.Concat<byte>(Input_In: __pin_group_Input_In_JHYXBDHnp12PITpPTgBdp9_7, Output_Out: out n2.Spread<byte> Output_8);
            Result_Out = Output_8;
            return;
        }
    }
}

namespace _VL_Tokenizer_
{
    public struct __AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO : n14.IAdaptiveCreateDefault<n12.Result_C<n2.Spread<byte>>>, n14.IAdaptiveCreateDefault<n2.Spread<byte>>, n14.IAdaptiveCreateDefault<int>, n14.IAdaptiveCreateDefault<bool>, n14.IAdaptiveCreateDefault<string>
    {
        public void CreateDefault(out n12.Result_C<n2.Spread<byte>> Output_Out)
        {
            var Output_0 = n12.Result_C<n2.Spread<byte>>.CreateDefault<n23.__AdaptiveImplementations__GwtzrCcDa6uL2tyjBJ0NTO>();
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n2.Spread<byte> Output_Out)
        {
            var Empty_0 = n3._Operations_.CreateDefault<byte>();
            Output_Out = Empty_0;
            return;
        }

        public void CreateDefault(out int Output_Out)
        {
            n29._Operations_.CreateDefault_Generic<int>(Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out bool Output_Out)
        {
            n29._Operations_.CreateDefault_Generic<bool>(Output_Out: out bool Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out string Output_Out)
        {
            var Empty_0 = n30._Operations_.CreateDefault();
            Output_Out = Empty_0;
            return;
        }
    }
}