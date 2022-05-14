extern alias e9;
extern alias e2;
extern alias e5;

using n32 = _VL_Typewriter_.Text;
using n14 = _CoreLibBasics_.Control.Advanced;
using n7 = e2::VL.Lib.Primitive;
using n20 = _CoreLibBasics_.Primitive.Object.Advanced;
using n6 = _VL_Collections_.Collections.Builder.SpreadBuilder.Advanced;
using n34 = _CoreLibBasics_.Control;
using n19 = e9::VL.Lib.IO.Notifications;
using n31 = e2::VL.Lib.Text;
using n25 = _VL_Reactive_.Reactive.Sampler;
using n15 = _CoreLibBasics_.Primitive.String;
using n4 = e5::VL.Core.CompilerServices;
using n8 = global::System.Collections.Generic;
using n29 = _CoreLibBasics_.Math.Adaptive;
using n28 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n11 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n23 = _VL_Typewriter_.Text.Controls.Advanced;
using n24 = e2::VL.Lib.Reactive;
using n1 = e5::VL.Core;
using n27 = e9::VL.Lib.IO;
using n26 = e5::VL.Lib.Runtime;
using n2 = global::System;
using n22 = _CoreLibBasics_.Primitive.Delegates.Delegate__1_MG_1.Advanced;
using n16 = _VL_Typewriter_.Text.TextBuilder.ToSelectedPositions.Advanced;
using n21 = e2::VL.Lib.IO;
using n36 = _CoreLibBasics_.Primitive.Char.Advanced;
using n10 = _VL_Typewriter_;
using n9 = _VL_Typewriter_.Text.TextBuilder.Advanced;
using n17 = global::System.Windows.Forms;
using n12 = _VL_Collections_.Collections.Sequence;
using n18 = global::System.Runtime.CompilerServices;
using n30 = _CoreLibBasics_.Text.Encodings;
using n5 = e5::VL.Lib.Collections;
using n33 = _VL_Typewriter_.Text.Internal;
using n13 = _VL_Collections_.Collections.Spread;
using n3 = _VL_Typewriter_.Text.Advanced;
using n35 = _CoreLibBasics_.Primitive.Advanced;

namespace _VL_Typewriter_.Text.Advanced
{
    [n1.ElementAttribute(TracingId = 228428U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "LVl8IgT3K0KMhZbgk6IIJf", Name = "TextBuilder_C")]
    [n2.SerializableAttribute]
    public class TextBuilder_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.TextBuilder_C Create(n1.NodeContext Node_Context, string Initial_Text_In)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new TextBuilder_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Initial_Text_In);
        }

        [n4.CreateDefaultAttribute]
        public static n3.TextBuilder_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new TextBuilder_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.TextBuilder_C CapsToggle()
        {
            return this;
        }

        public n3.TextBuilder_C EraseByDelete()
        {
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_0 = this.Text;
            int __auto_1 = this.Line;
            int __auto_2 = this.Cursor;
            n6._Operations_.Count<n5.SpreadBuilder<string>>(Input_In: __auto_0, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_3, Count_Out: out int Count_4);
            n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: Output_3, Index_In: __auto_1, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_5, Item_Out: out n5.SpreadBuilder<string> Item_6);
            n6._Operations_.Count<string>(Input_In: Item_6, Output_Out: out n5.SpreadBuilder<string> Output_7, Count_Out: out int Count_8);
            var Result_9 = Count_8 > __auto_2;
            var Output_10 = Output_7;
            if (Result_9)
            {
                n6._Operations_.RemoveAt<string>(Input_In: Output_7, Index_In: __auto_2, Output_Out: out Output_10);
            }

            var Output_11 = n7.Integer32Extensions.Dec(input: Count_4);
            var Result_12 = Output_11 > __auto_1;
            var Result_13 = Count_8 == __auto_2;
            var Output_14 = Result_12 && Result_13;
            n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_15;
            if (Output_14)
            {
                var Output_17 = n7.Integer32Extensions.Inc(input: __auto_1);
                n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: Output_5, Index_In: Output_17, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_18, Item_Out: out n5.SpreadBuilder<string> Item_19);
                n6._Operations_.RemoveAt<n5.SpreadBuilder<string>>(Input_In: Output_18, Index_In: Output_17, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_20);
                n8.IEnumerable<string> Items_21 = (n8.IEnumerable<string>)Item_19;
                n6._Operations_.AddRange<string>(Input_In: Output_10, Items_In: Items_21, Output_Out: out n5.SpreadBuilder<string> Output_22);
                Output_15 = Output_20;
            }
            else
            {
                Output_15 = n6._Operations_.CreateDefault<n5.SpreadBuilder<string>>();
            }

            return this;
        }

        public n3.TextBuilder_C Split(out string Text_Out, out int Length_Out, out int Position_Out, out int Cursor_Out, out int Line_Out, out string Selected_Text_Out, out n9.Selection_R<int> Selection_Out, out n5.SpreadBuilder<n5.SpreadBuilder<string>> Text_Raw_Out)
        {
            string __auto_0 = this.Joined_Text;
            int __auto_1 = this.Length;
            int __auto_2 = this.Position;
            int __auto_3 = this.Cursor;
            int __auto_4 = this.Line;
            string __auto_5 = this.Selected_Text;
            n9.Selection_R<int> __auto_6 = this.Selection;
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_7 = this.Text;
            Text_Out = __auto_0;
            Length_Out = __auto_1;
            Position_Out = __auto_2;
            Cursor_Out = __auto_3;
            Line_Out = __auto_4;
            Selected_Text_Out = __auto_5;
            Selection_Out = __auto_6;
            Text_Raw_Out = __auto_7;
            return this;
        }

        public n3.TextBuilder_C InsertChar(string Item_In)
        {
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_0 = this.Text;
            int __auto_1 = this.Line;
            int __auto_2 = this.Cursor;
            n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: __auto_0, Index_In: __auto_1, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_3, Item_Out: out n5.SpreadBuilder<string> Item_4);
            n6._Operations_.Insert<string>(Input_In: Item_4, Index_In: __auto_2, Item_In: Item_In, Output_Out: out n5.SpreadBuilder<string> Output_5);
            n6._Operations_.Count<string>(Input_In: Output_5, Output_Out: out n5.SpreadBuilder<string> Output_6, Count_Out: out int Count_7);
            var Output_8 = n7.Integer32Extensions.Inc(input: __auto_2);
            n11._Operations_.Min<int, n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Input_In: Count_7, Input_2_In: Output_8, Output_Out: out int Output_9);
            this.Cursor = Output_9;
            int __auto_10 = Output_9;
            return this;
        }

        public n3.TextBuilder_C EraseByBack()
        {
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_0 = this.Text;
            int __auto_1 = this.Line;
            int __auto_2 = this.Cursor;
            int __pad_KGPMnqcU445OayAgKEfzXg_3 = __slot_KGPMnqcU445OayAgKEfzXg;
            n6._Operations_.Count<n5.SpreadBuilder<string>>(Input_In: __auto_0, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_4, Count_Out: out int Count_5);
            n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: Output_4, Index_In: __auto_1, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_6, Item_Out: out n5.SpreadBuilder<string> Item_7);
            n6._Operations_.Count<string>(Input_In: Item_7, Output_Out: out n5.SpreadBuilder<string> Output_8, Count_Out: out int Count_9);
            int Input_2_10 = 0;
            var Result_11 = __auto_1 > Input_2_10;
            int Input_12 = 0;
            var Result_13 = Input_12 == __auto_2;
            var Output_14 = Result_11 && Result_13;
            var Output_15 = __auto_2 - __pad_KGPMnqcU445OayAgKEfzXg_3;
            int Input_16 = 0;
            n11._Operations_.Max<int, n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Input_In: Input_16, Input_2_In: Output_15, Output_Out: out int Output_17);
            n11._Operations_.Min<int, n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Input_In: Count_9, Input_2_In: Output_17, Output_Out: out int Output_18);
            var Result_19 = Output_18 == Output_15;
            var Output_20 = Output_8;
            if (Result_19)
            {
                n6._Operations_.RemoveAt<string>(Input_In: Output_8, Index_In: Output_18, Output_Out: out Output_20);
            }

            n8.IEnumerable<string> Items_21 = (n8.IEnumerable<string>)Output_20;
            int Cursor_22;
            int Line_23;
            if (Output_14)
            {
                var Output_25 = n7.Integer32Extensions.Dec(input: __auto_1);
                n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: Output_6, Index_In: Output_25, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_26, Item_Out: out n5.SpreadBuilder<string> Item_27);
                n6._Operations_.RemoveAt<n5.SpreadBuilder<string>>(Input_In: Output_26, Index_In: __auto_1, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_28);
                Line_23 = Output_25;
                n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: Output_28, Index_In: Output_25, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_29, Item_Out: out n5.SpreadBuilder<string> Item_30);
                n8.IEnumerable<string> Input_31 = (n8.IEnumerable<string>)Item_30;
                n12._Operations_.Count<string>(Input_In: Input_31, Result_Out: out int Result_32);
                Cursor_22 = Result_32;
                n6._Operations_.AddRange<string>(Input_In: Item_27, Items_In: Items_21, Output_Out: out n5.SpreadBuilder<string> Output_33);
            }
            else
            {
                Cursor_22 = Output_18;
                Line_23 = __auto_1;
            }

            this.Cursor = Cursor_22;
            int __auto_34 = Cursor_22;
            this.Line = Line_23;
            int __auto_35 = Line_23;
            return this;
        }

        public n3.TextBuilder_C InserTab()
        {
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_0 = this.Text;
            int __auto_1 = this.Line;
            int __auto_2 = this.Cursor;
            int __pad_RBIi6cYtEdcN5xSsZuJF9G_3 = __slot_RBIi6cYtEdcN5xSsZuJF9G;
            n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: __auto_0, Index_In: __auto_1, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_4, Item_Out: out n5.SpreadBuilder<string> Item_5);
            var Result_6 = n7.IntegerConversions.ToChar(input: __pad_RBIi6cYtEdcN5xSsZuJF9G_3);
            var Result_7 = char.ToString(c: Result_6);
            n6._Operations_.Insert<string>(Input_In: Item_5, Index_In: __auto_2, Item_In: Result_7, Output_Out: out n5.SpreadBuilder<string> Output_8);
            var Output_9 = n7.Integer32Extensions.Inc(input: __auto_2);
            this.Cursor = Output_9;
            int __auto_10 = Output_9;
            return this;
        }

        public n3.TextBuilder_C InsertNewLine()
        {
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_0 = this.Text;
            int __auto_1 = this.Line;
            int __auto_2 = this.Cursor;
            int __pad_Hh1eUOy1LSLNKW8ixcnrM8_3 = __slot_Hh1eUOy1LSLNKW8ixcnrM8;
            n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: __auto_0, Index_In: __auto_1, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_4, Item_Out: out n5.SpreadBuilder<string> Item_5);
            n6._Operations_.ToSpread<string>(Input_In: Item_5, Output_Out: out n5.SpreadBuilder<string> Output_6, Result_Out: out n5.Spread<string> Result_7);
            n13._Operations_.SplitAt<string>(Input_In: Result_7, Index_In: __auto_2, Output_Out: out n5.Spread<string> Output_8, Output_2_Out: out n5.Spread<string> Output_2_9);
            n13._Operations_.ToBuilder<string>(Input_In: Output_8, Result_Out: out n5.SpreadBuilder<string> Result_10);
            n6._Operations_.SetItem<n5.SpreadBuilder<string>>(Input_In: Output_4, Index_In: __auto_1, Value_In: Result_10, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_11);
            n13._Operations_.ToBuilder<string>(Input_In: Output_2_9, Result_Out: out n5.SpreadBuilder<string> Result_12);
            var Output_13 = n7.Integer32Extensions.Inc(input: __auto_1);
            n6._Operations_.Insert<n5.SpreadBuilder<string>>(Input_In: Output_11, Index_In: Output_13, Item_In: Result_12, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_14);
            this.Line = Output_13;
            int __auto_15 = Output_13;
            this.Cursor = __pad_Hh1eUOy1LSLNKW8ixcnrM8_3;
            int __auto_16 = __pad_Hh1eUOy1LSLNKW8ixcnrM8_3;
            return this;
        }

        public n3.TextBuilder_C MoveCursor([n4.SerializedDefaultValueAttribute("True", false)] bool Left_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Right_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Up_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Down_In, bool Home_In, bool End_In, bool PageUp_In, bool PageDown_In)
        {
            int __auto_0 = this.Cursor;
            int __auto_1 = this.Line;
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_2 = this.Text;
            var Output_3 = __auto_0;
            if (Right_In)
            {
                var Output_4 = n7.Integer32Extensions.Inc(input: __auto_0);
                Output_3 = Output_4;
            }

            var Output_5 = Output_3;
            if (Left_In)
            {
                var Output_6 = n7.Integer32Extensions.Dec(input: Output_3);
                Output_5 = Output_6;
            }

            n6._Operations_.Count<n5.SpreadBuilder<string>>(Input_In: __auto_2, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_7, Count_Out: out int Count_8);
            var Output_9 = __auto_1;
            if (Down_In)
            {
                var Output_10 = n7.Integer32Extensions.Inc(input: __auto_1);
                Output_9 = Output_10;
            }

            var Output_11 = Output_9;
            if (Up_In)
            {
                var Output_12 = n7.Integer32Extensions.Dec(input: Output_9);
                Output_11 = Output_12;
            }

            int Input_2_13 = 0;
            n14._Operations_.Switch_Boolean<int>(Condition_In: PageUp_In, Input_In: Output_11, Input_2_In: Input_2_13, Output_Out: out int Output_14);
            var Output_15 = n7.Integer32Extensions.Dec(input: Count_8);
            n14._Operations_.Switch_Boolean<int>(Condition_In: PageDown_In, Input_In: Output_14, Input_2_In: Output_15, Output_Out: out int Output_16);
            int Input_2_17 = 0;
            var Result_18 = __auto_0 == Input_2_17;
            int Input_2_19 = 0;
            var Result_20 = __auto_1 != Input_2_19;
            var Output_21 = Left_In && Result_18;
            var Output_22 = Output_21 && Result_20;
            var Output_23 = Output_16;
            if (Output_22)
            {
                var Output_24 = n7.Integer32Extensions.Dec(input: Output_16);
                Output_23 = Output_24;
            }

            int Minimum_25 = 0;
            n11._Operations_.Clamp<int, n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Input_In: Output_23, Minimum_In: Minimum_25, Maximum_In: Output_15, Output_Out: out int Output_26);
            n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: Output_7, Index_In: Output_26, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_27, Item_Out: out n5.SpreadBuilder<string> Item_28);
            n6._Operations_.Count<string>(Input_In: Item_28, Output_Out: out n5.SpreadBuilder<string> Output_29, Count_Out: out int Count_30);
            var Output_31 = n7.Integer32Extensions.Inc(input: Count_30);
            var Result_32 = Output_5 == Output_31;
            var Result_33 = Output_15 != Output_26;
            var Output_34 = Result_32 && Right_In;
            var Output_35 = Output_34 && Result_33;
            int Input_2_36 = 0;
            var Result_37 = __auto_1 == Input_2_36;
            var Output_38 = Result_37 && Up_In;
            var Output_39 = Output_38 || Output_35;
            var Output_40 = Output_39 || Home_In;
            int Input_2_41 = 0;
            n14._Operations_.Switch_Boolean<int>(Condition_In: Output_40, Input_In: Output_5, Input_2_In: Input_2_41, Output_Out: out int Output_42);
            var Result_43 = Output_23 > Output_15;
            var Output_44 = Output_22 || Result_43;
            var Output_45 = Output_44 || End_In;
            n14._Operations_.Switch_Boolean<int>(Condition_In: Output_45, Input_In: Output_42, Input_2_In: Count_30, Output_Out: out int Output_46);
            int Minimum_47 = 0;
            n11._Operations_.Clamp<int, n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Input_In: Output_46, Minimum_In: Minimum_47, Maximum_In: Count_30, Output_Out: out int Output_48);
            this.Cursor = Output_48;
            int __auto_49 = Output_48;
            var Output_50 = Output_26;
            if (Output_35)
            {
                var Output_51 = n7.Integer32Extensions.Inc(input: Output_26);
                Output_50 = Output_51;
            }

            this.Line = Output_50;
            int __auto_52 = Output_50;
            return this;
        }

        public n3.TextBuilder_C MoveCursorByWord(bool Left_In, bool Right_In)
        {
            int __auto_0 = this.Line;
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_1 = this.Text;
            int __auto_2 = this.Cursor;
            int __auto_3;
            int __auto_4;
            if (Left_In)
            {
                int __pad_SLGCbPp18KpMEhjf3bf2Pm_6 = __slot_SLGCbPp18KpMEhjf3bf2Pm;
                n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: __auto_1, Index_In: __auto_0, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_7, Item_Out: out n5.SpreadBuilder<string> Item_8);
                n8.IEnumerable<string> Values_9 = (n8.IEnumerable<string>)Item_8;
                string Separator_10 = "";
                var Output_11 = string.Join(separator: Separator_10, values: Values_9);
                int Input_2_12 = 0;
                var Result_13 = __auto_0 > Input_2_12;
                int Input_2_14 = 0;
                var Result_15 = __auto_2 == Input_2_14;
                var Output_16 = Result_13 && Result_15;
                int accumulator_18 = __auto_2;
                for (var i_17 = 0; i_17 < __auto_2; i_17++)
                {
                    var i_local_19 = i_17;
                    var Output_21 = n7.Integer32Extensions.Dec(input: accumulator_18);
                    var Result_22 = char.IsWhiteSpace(s: Output_11, index: Output_21);
                    var Output_23 = !Result_22;
                    accumulator_18 = Output_21;
                    if (Output_23)
                    {
                        break;
                    }
                }

                int accumulator_25 = accumulator_18;
                for (var i_24 = 0; i_24 < accumulator_18; i_24++)
                {
                    var i_local_26 = i_24;
                    var Output_28 = n7.Integer32Extensions.Dec(input: accumulator_25);
                    var Result_29 = char.IsWhiteSpace(s: Output_11, index: Output_28);
                    accumulator_25 = Output_28;
                    if (Result_29)
                    {
                        break;
                    }
                }

                var Result_30 = accumulator_25 != __pad_SLGCbPp18KpMEhjf3bf2Pm_6;
                var Output_31 = accumulator_25;
                if (Result_30)
                {
                    var Output_32 = n7.Integer32Extensions.Inc(input: accumulator_25);
                    Output_31 = Output_32;
                }

                int __auto_33;
                int __auto_34;
                if (Output_16)
                {
                    var Output_36 = n7.Integer32Extensions.Dec(input: __auto_0);
                    n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: __auto_1, Index_In: Output_36, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_37, Item_Out: out n5.SpreadBuilder<string> Item_38);
                    __auto_33 = Output_36;
                    n8.IEnumerable<string> Input_39 = (n8.IEnumerable<string>)Item_38;
                    n12._Operations_.Count<string>(Input_In: Input_39, Result_Out: out int Result_40);
                    __auto_34 = Result_40;
                }
                else
                {
                    __auto_33 = __auto_0;
                    __auto_34 = Output_31;
                }

                __auto_3 = __auto_33;
                __auto_4 = __auto_34;
            }
            else
            {
                __auto_3 = __auto_0;
                __auto_4 = __auto_2;
            }

            int __auto_41;
            int __auto_42;
            if (Right_In)
            {
                n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: __auto_1, Index_In: __auto_3, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_44, Item_Out: out n5.SpreadBuilder<string> Item_45);
                n8.IEnumerable<string> Values_46 = (n8.IEnumerable<string>)Item_45;
                string Separator_47 = "";
                var Output_48 = string.Join(separator: Separator_47, values: Values_46);
                n8.IEnumerable<n5.SpreadBuilder<string>> Input_49 = (n8.IEnumerable<n5.SpreadBuilder<string>>)Output_44;
                n12._Operations_.Count<n5.SpreadBuilder<string>>(Input_In: Input_49, Result_Out: out int Result_50);
                var Output_51 = n7.Integer32Extensions.Dec(input: Result_50);
                var Result_52 = __auto_3 < Output_51;
                n8.IEnumerable<string> Input_53 = (n8.IEnumerable<string>)Item_45;
                n12._Operations_.Count<string>(Input_In: Input_53, Result_Out: out int Result_54);
                var Result_55 = __auto_4 == Result_54;
                var Output_56 = Result_52 && Result_55;
                var Length_57 = Output_48.Length;
                var Output_58 = Length_57 - __auto_4;
                int accumulator_60 = __auto_4;
                for (var i_59 = 0; i_59 < Output_58; i_59++)
                {
                    var i_local_61 = i_59;
                    var Result_63 = char.IsWhiteSpace(s: Output_48, index: accumulator_60);
                    var Output_64 = n7.Integer32Extensions.Inc(input: accumulator_60);
                    accumulator_60 = Output_64;
                    if (Result_63)
                    {
                        break;
                    }
                }

                var Output_65 = Length_57 - accumulator_60;
                int accumulator_67 = accumulator_60;
                for (var i_66 = 0; i_66 < Output_65; i_66++)
                {
                    var i_local_68 = i_66;
                    var Result_70 = char.IsWhiteSpace(s: Output_48, index: accumulator_67);
                    var Output_71 = !Result_70;
                    var Output_72 = n7.Integer32Extensions.Inc(input: accumulator_67);
                    accumulator_67 = Output_72;
                    if (Output_71)
                    {
                        break;
                    }
                }

                var Result_73 = accumulator_67 != Length_57;
                var Output_74 = accumulator_67;
                if (Result_73)
                {
                    var Output_75 = n7.Integer32Extensions.Dec(input: accumulator_67);
                    Output_74 = Output_75;
                }

                int __auto_76;
                int __auto_77;
                if (Output_56)
                {
                    int __pad_BS0cFAnayPDLpET2UjmSYV_79 = __slot_BS0cFAnayPDLpET2UjmSYV;
                    var Output_80 = n7.Integer32Extensions.Inc(input: __auto_3);
                    __auto_76 = Output_80;
                    __auto_77 = __pad_BS0cFAnayPDLpET2UjmSYV_79;
                }
                else
                {
                    __auto_76 = __auto_3;
                    __auto_77 = Output_74;
                }

                __auto_41 = __auto_76;
                __auto_42 = __auto_77;
            }
            else
            {
                __auto_41 = __auto_3;
                __auto_42 = __auto_4;
            }

            this.Line = __auto_41;
            int __auto_81 = __auto_41;
            this.Cursor = __auto_42;
            int __auto_82 = __auto_42;
            return this;
        }

        public n3.TextBuilder_C Update()
        {
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_0 = this.Text;
            int __auto_1 = this.Line;
            int __auto_2 = this.Cursor;
            n9.Selection_R<int> __auto_3 = this.Selection;
            var New_Line_4 = n7.StringExtensions.NewLine;
            int accumulator_6 = 0;
            int accumulator_7 = 0;
            var builder_26 = n4.CollectionBuilders.GetBuilder(this.__cp_PnBqqvlD2CXPzG4xIWC3D4, 16);
            n5.Spread<string> output_27;
            try
            {
                var i_9 = 0;
                foreach (var item_5 in __auto_0)
                {
                    var splicer_8 = item_5;
                    var i_local_10 = i_9;
                    var Result_12 = i_local_10 < __auto_1;
                    int Input_2_13 = n2.Convert.ToInt32(Result_12);
                    n6._Operations_.Count<string>(Input_In: splicer_8, Output_Out: out n5.SpreadBuilder<string> Output_14, Count_Out: out int Count_15);
                    var Output_16 = Count_15 * Input_2_13;
                    n8.IEnumerable<string> Values_17 = (n8.IEnumerable<string>)Output_14;
                    string Separator_18 = "";
                    var Output_19 = string.Join(separator: Separator_18, values: Values_17);
                    var Output_20 = Count_15 + accumulator_6;
                    var Result_21 = i_local_10 == __auto_1;
                    int Input_22 = n2.Convert.ToInt32(Result_21);
                    var Output_23 = Input_22 * __auto_2;
                    var Output_24 = Output_23 + accumulator_7;
                    var Output_25 = Output_16 + Output_24;
                    builder_26.Add(Output_19);
                    accumulator_6 = Output_20;
                    accumulator_7 = Output_25;
                    i_9++;
                }
            }
            finally
            {
                output_27 = builder_26.Commit();
                this.__cp_PnBqqvlD2CXPzG4xIWC3D4 = output_27;
            }

            n8.IEnumerable<string> Values_28 = (n8.IEnumerable<string>)output_27;
            var Output_29 = string.Join(separator: New_Line_4, values: Values_28);
            this.Length = accumulator_6;
            int __auto_30 = accumulator_6;
            this.Position = accumulator_7;
            int __auto_31 = accumulator_7;
            var State_Output_33 = this.__p_Se10orrR98LMXQTic4vUbf.Update<string>(Text_In: output_27, Text_Raw_In: __auto_0, Selection_In: __auto_3, Output_Out: out string Output_32);
            this.__p_Se10orrR98LMXQTic4vUbf = State_Output_33;
            this.Selected_Text = Output_32;
            string __auto_34 = Output_32;
            this.Joined_Text = Output_29;
            string __auto_35 = Output_29;
            return this;
        }

        public n3.TextBuilder_C Paste(string Text_In)
        {
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_0 = this.Text;
            int __auto_1 = this.Line;
            int __auto_2 = this.Cursor;
            bool Remove_Empty_Lines_3 = false;
            n15._Operations_.SplitToLines(Input_In: Text_In, Remove_Empty_Lines_In: Remove_Empty_Lines_3, Output_Out: out n5.Spread<string> Output_4);
            n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: __auto_0, Index_In: __auto_1, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_5, Item_Out: out n5.SpreadBuilder<string> Item_6);
            n8.IEnumerable<string> Input_7 = (n8.IEnumerable<string>)Item_6;
            n12._Operations_.SplitAt<string>(Input_In: Input_7, Index_In: __auto_2, Output_Out: out n8.IEnumerable<string> Output_8, Output_2_Out: out n8.IEnumerable<string> Output_2_9);
            bool Condition_10 = false;
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_11;
            n8.IEnumerable<string> __auto_12;
            if (Condition_10)
            {
                __auto_11 = Output_5;
                __auto_12 = Output_8;
            }
            else
            {
                __auto_11 = Output_5;
                __auto_12 = Output_8;
            }

            n5.SpreadBuilder<string> Input_14 = n6._Operations_.CreateDefault<string>();
            n6._Operations_.AddRange<string>(Input_In: Input_14, Items_In: __auto_12, Output_Out: out n5.SpreadBuilder<string> Output_15);
            n6._Operations_.SetItem<n5.SpreadBuilder<string>>(Input_In: __auto_11, Index_In: __auto_1, Value_In: Output_15, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_16);
            n13._Operations_.Count<string>(Input_In: Output_4, Count_Out: out int Count_17);
            var Output_18 = n7.Integer32Extensions.Dec(input: Count_17);
            n5.SpreadBuilder<n5.SpreadBuilder<string>> accumulator_20 = Output_16;
            int accumulator_21 = __auto_2;
            int accumulator_22 = __auto_1;
            var i_24 = 0;
            foreach (var item_19 in n4.CollectionExtensions.AsSpan(Output_4))
            {
                var splicer_23 = item_19;
                var i_local_25 = i_24;
                var Result_27 = i_local_25 < Output_18;
                int Input_2_28 = 0;
                var Result_29 = Output_18 > Input_2_28;
                var Output_30 = Result_27 && Result_29;
                n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: accumulator_20, Index_In: accumulator_22, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_31, Item_Out: out n5.SpreadBuilder<string> Item_32);
                var Output_33 = accumulator_22;
                if (Output_30)
                {
                    var Output_34 = n7.Integer32Extensions.Inc(input: accumulator_22);
                    Output_33 = Output_34;
                }

                n5.SpreadBuilder<string> Item_35 = n6._Operations_.CreateDefault<string>();
                var Output_36 = Output_31;
                if (Output_30)
                {
                    n6._Operations_.Insert<n5.SpreadBuilder<string>>(Input_In: Output_31, Index_In: Output_33, Item_In: Item_35, Output_Out: out Output_36);
                }

                int Count_37 = 1;
                n15._Operations_.Split_Count(Input_In: splicer_23, Count_In: Count_37, Substrings_Out: out n5.Spread<string> Substrings_38);
                n5.SpreadBuilder<string> accumulator_40 = Item_32;
                int accumulator_41 = accumulator_21;
                var i_43 = 0;
                foreach (var item_39 in n4.CollectionExtensions.AsSpan(Substrings_38))
                {
                    var splicer_42 = item_39;
                    var i_local_44 = i_43;
                    n6._Operations_.Insert<string>(Input_In: accumulator_40, Index_In: accumulator_41, Item_In: splicer_42, Output_Out: out n5.SpreadBuilder<string> Output_46);
                    var Output_47 = n7.Integer32Extensions.Inc(input: accumulator_41);
                    accumulator_40 = Output_46;
                    accumulator_41 = Output_47;
                    i_43++;
                }

                int Input_2_48 = 0;
                n14._Operations_.Switch_Boolean<int>(Condition_In: Output_30, Input_In: accumulator_41, Input_2_In: Input_2_48, Output_Out: out int Output_49);
                accumulator_20 = Output_36;
                accumulator_21 = Output_49;
                accumulator_22 = Output_33;
                i_24++;
            }

            n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: accumulator_20, Index_In: accumulator_22, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_50, Item_Out: out n5.SpreadBuilder<string> Item_51);
            this.Line = accumulator_22;
            int __auto_52 = accumulator_22;
            n6._Operations_.AddRange<string>(Input_In: Item_51, Items_In: Output_2_9, Output_Out: out n5.SpreadBuilder<string> Output_53);
            this.Cursor = accumulator_21;
            int __auto_54 = accumulator_21;
            return this;
        }

        public n3.TextBuilder_C MoveSelection(int Position_From_In, int Line_From_In, bool Select_All_In, bool Reset_In)
        {
            n9.Selection_R<int> __auto_0 = this.Selection;
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_1 = this.Text;
            int __auto_2 = this.Line;
            int __auto_3 = this.Cursor;
            var State_Output_5 = __auto_0.IsStarted(Output_Out: out bool Output_4);
            var Output_6 = !Output_4;
            n9.Selection_R<int> __auto_7;
            if (Output_6)
            {
                n9.Selection_R<int> Input_9 = n9.Selection_R<int>.CreateDefault<n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>();
                var Output_10 = Input_9.Start(Line_From_In: Line_From_In, Line_To_In: __auto_2, Position_From_In: Position_From_In, Position_To_In: __auto_3);
                __auto_7 = Output_10;
            }
            else
            {
                __auto_7 = __auto_0;
            }

            this.__slot_EIeJNYbKjnpLGVj2t6LSWu = Output_4;
            bool __pad_EIeJNYbKjnpLGVj2t6LSWu_11 = Output_4;
            var State_Output_13 = __auto_0.IsStarted(Output_Out: out bool Output_12);
            n9.Selection_R<int> __auto_14;
            if (Output_12)
            {
                var Output_16 = __auto_7.To(Line_To_In: __auto_2, Position_To_In: __auto_3);
                __auto_14 = Output_16;
            }
            else
            {
                __auto_14 = __auto_7;
            }

            n8.IEnumerable<n5.SpreadBuilder<string>> Input_17 = (n8.IEnumerable<n5.SpreadBuilder<string>>)__auto_1;
            n9.Selection_R<int> __auto_18;
            if (Select_All_In)
            {
                n12._Operations_.Count<n5.SpreadBuilder<string>>(Input_In: Input_17, Result_Out: out int Result_20);
                var Output_21 = n7.Integer32Extensions.Dec(input: Result_20);
                n5.SpreadBuilder<string> Default_Value_22 = n6._Operations_.CreateDefault<string>();
                n12._Operations_.LastOrDefault<n5.SpreadBuilder<n5.SpreadBuilder<string>>, n5.SpreadBuilder<string>>(Input_In: __auto_1, Default_Value_In: Default_Value_22, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_23, Result_Out: out n5.SpreadBuilder<string> Result_24);
                n8.IEnumerable<string> Input_25 = (n8.IEnumerable<string>)Result_24;
                n12._Operations_.Count<string>(Input_In: Input_25, Result_Out: out int Result_26);
                int Line_From_27 = 0;
                int Position_From_28 = 0;
                var Output_29 = __auto_14.Start(Line_From_In: Line_From_27, Line_To_In: Output_21, Position_From_In: Position_From_28, Position_To_In: Result_26);
                __auto_18 = Output_29;
            }
            else
            {
                __auto_18 = __auto_14;
            }

            n9.Selection_R<int> __auto_30;
            if (Reset_In)
            {
                n1.NodeContext Node_Context_32 = __GetContext__().CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "PmJtMVigewyMhVOIzYiPNq", 229842U);
                var Output_33 = n9.Selection_R<int>.Create<n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Node_Context: Node_Context_32);
                __auto_30 = Output_33;
            }
            else
            {
                __auto_30 = __auto_18;
            }

            this.Selection = __auto_30;
            n9.Selection_R<int> __auto_34 = __auto_30;
            return this;
        }

        public n3.TextBuilder_C EraseSelected()
        {
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_0 = this.Text;
            n9.Selection_R<int> __auto_1 = this.Selection;
            var Output_5 = this.__p_OZcrP6sx7ZVN6StphoSAyi.Update(Text_In: __auto_0, Selection_In: __auto_1, Text_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Text_2, Line_Out: out int Line_3, Cursor_Out: out int Cursor_4);
            this.__p_OZcrP6sx7ZVN6StphoSAyi = Output_5;
            this.Text = Text_2;
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_6 = Text_2;
            this.Line = Line_3;
            int __auto_7 = Line_3;
            this.Cursor = Cursor_4;
            int __auto_8 = Cursor_4;
            n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "S4cMPZsx7KWP8t57CLSUAU", 230874U);
            var Output_10 = n9.Selection_R<int>.Create<n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Node_Context: Node_Context_9);
            this.Selection = Output_10;
            n9.Selection_R<int> __auto_11 = Output_10;
            return this;
        }

        public n3.TextBuilder_C Copy()
        {
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_0 = this.Text;
            n9.Selection_R<int> __auto_1 = this.Selection;
            var State_Output_3 = this.__p_P87ElqUS6j8PL8M5cyLZ0y.Update<string>(Text_In: __auto_0, Selection_In: __auto_1, Output_Out: out n5.Spread<n16.SelectedPosition_R> Output_2);
            this.__p_P87ElqUS6j8PL8M5cyLZ0y = State_Output_3;
            string accumulator_5 = "";
            var i_7 = 0;
            foreach (var item_4 in n4.CollectionExtensions.AsSpan(Output_2))
            {
                var splicer_6 = item_4;
                var i_local_8 = i_7;
                int Input_2_10 = 0;
                var Result_11 = i_local_8 > Input_2_10;
                var New_Line_12 = n7.StringExtensions.NewLine;
                string Input_13 = "";
                n14._Operations_.Switch_Boolean<string>(Condition_In: Result_11, Input_In: Input_13, Input_2_In: New_Line_12, Output_Out: out string Output_14);
                var Output_18 = splicer_6.Split(Line_Out: out int Line_15, Position_From_Out: out int Position_From_16, Position_Count_Out: out int Position_Count_17);
                n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: __auto_0, Index_In: Line_15, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_19, Item_Out: out n5.SpreadBuilder<string> Item_20);
                n8.IEnumerable<string> Values_21 = (n8.IEnumerable<string>)Item_20;
                string Separator_22 = "";
                var Output_23 = string.Join(separator: Separator_22, values: Values_21);
                var Output_24 = Output_23.Substring(startIndex: Position_From_16, length: Position_Count_17);
                var Output_25 = string.Concat(str0: accumulator_5, str1: Output_14);
                var Output_26 = string.Concat(str0: Output_25, str1: Output_24);
                accumulator_5 = Output_26;
                i_7++;
            }

            var Result_27 = string.IsNullOrEmpty(value: accumulator_5);
            var Output_28 = !Result_27;
            if (Output_28)
            {
                n17.Clipboard.SetText(text: accumulator_5);
            }

            return this;
        }

        public n3.TextBuilder_C GetSelection(out n9.Selection_R<int> Selection_Out)
        {
            n9.Selection_R<int> __auto_0 = this.Selection;
            Selection_Out = __auto_0;
            return this;
        }

        public n3.TextBuilder_C StartSelection()
        {
            return this;
        }

        public n3.TextBuilder_C GetPrevious()
        {
            return this;
        }

        public n3.TextBuilder_C SavePreviousPosition()
        {
            return this;
        }

        public n3.TextBuilder_C GetCursorAndLine(out int Cursor_Out, out int Line_Out)
        {
            int __auto_0 = this.Cursor;
            int __auto_1 = this.Line;
            Cursor_Out = __auto_0;
            Line_Out = __auto_1;
            return this;
        }

        public n3.TextBuilder_C Length_(out int Length_Out)
        {
            int __auto_0 = this.Length;
            Length_Out = __auto_0;
            return this;
        }

        public n3.TextBuilder_C __Create__(n1.NodeContext Node_Context, string Initial_Text_In)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Text = n6._Operations_.CreateDefault<n5.SpreadBuilder<string>>();
            this.Cursor = 0;
            this.Line = 0;
            this.__slot_EIeJNYbKjnpLGVj2t6LSWu = false;
            this.Selection = n9.Selection_R<int>.CreateDefault<n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>();
            this.Joined_Text = "";
            this.Selected_Text = "";
            this.Length = 0;
            this.Position = 0;
            this.__cp_PnBqqvlD2CXPzG4xIWC3D4 = n13._Operations_.CreateDefault<string>();
            bool Remove_Empty_Lines_0 = false;
            n15._Operations_.SplitToLines(Input_In: Initial_Text_In, Remove_Empty_Lines_In: Remove_Empty_Lines_0, Output_Out: out n5.Spread<string> Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "SH4LjwZdUMpQSIv3rTrzrv", 228446U);
            int Capacity_3 = 0;
            n6._Operations_.Create<n5.SpreadBuilder<string>>(Node_Context: Node_Context_2, Capacity_In: Capacity_3, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_4);
            n5.SpreadBuilder<n5.SpreadBuilder<string>> accumulator_6 = Output_4;
            var i_8 = 0;
            foreach (var item_5 in n4.CollectionExtensions.AsSpan(Output_1))
            {
                var splicer_7 = item_5;
                var i_local_9 = i_8;
                n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "B3rFp58RVZGPy6dlWi2CzJ", 230108U);
                int Capacity_12 = 0;
                n6._Operations_.Create<string>(Node_Context: Node_Context_11, Capacity_In: Capacity_12, Output_Out: out n5.SpreadBuilder<string> Output_13);
                n8.IEnumerable<char> Input_14 = (n8.IEnumerable<char>)splicer_7;
                var __fallback___15 = n1.ServiceRegistry.Current;
                n12._Operations_.Select<char, string>(Input_In: Input_14, Transformer_In: (char Source_In_17, int Index_In_18) =>
                {
                    using var __current_16 = __fallback___15.MakeCurrentIfNone();
                    var Result_19 = char.ToString(c: Source_In_17);
                    return Result_19;
                }

                , Output_Out: out n8.IEnumerable<string> Output_20);
                n6._Operations_.AddRange<string>(Input_In: Output_13, Items_In: Output_20, Output_Out: out n5.SpreadBuilder<string> Output_21);
                n6._Operations_.Add<n5.SpreadBuilder<string>>(Input_In: accumulator_6, Item_In: Output_21, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_22);
                accumulator_6 = Output_22;
                i_8++;
            }

            this.Text = accumulator_6;
            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_23 = accumulator_6;
            string Default_Value_24 = "";
            n12._Operations_.LastOrDefault<n5.Spread<string>, string>(Input_In: Output_1, Default_Value_In: Default_Value_24, Output_Out: out n5.Spread<string> Output_25, Result_Out: out string Result_26);
            n13._Operations_.Count<string>(Input_In: Output_25, Count_Out: out int Count_27);
            var Output_28 = n7.Integer32Extensions.Dec(input: Count_27);
            this.Line = Output_28;
            int __auto_29 = Output_28;
            var Length_30 = Result_26.Length;
            this.Cursor = Length_30;
            int __auto_31 = Length_30;
            n1.NodeContext Node_Context_32 = Node_Context.CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "OZcrP6sx7ZVN6StphoSAyi", 230086U);
            var Output_33 = n9.RemoveSelected_MAdKROpcMMCMUeZTTqHRN4.Create(Node_Context: Node_Context_32);
            this.__p_OZcrP6sx7ZVN6StphoSAyi = Output_33;
            n1.NodeContext Node_Context_34 = Node_Context.CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "P87ElqUS6j8PL8M5cyLZ0y", 230925U);
            var Output_35 = n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6.Create(Node_Context: Node_Context_34);
            this.__p_P87ElqUS6j8PL8M5cyLZ0y = Output_35;
            n1.NodeContext Node_Context_36 = Node_Context.CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "Se10orrR98LMXQTic4vUbf", 231219U);
            var Output_37 = n9.GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa.Create(Node_Context: Node_Context_36);
            this.__p_Se10orrR98LMXQTic4vUbf = Output_37;
            return this;
        }

        public n3.TextBuilder_C __CreateDefault__()
        {
            this.Text = n6._Operations_.CreateDefault<n5.SpreadBuilder<string>>();
            this.Cursor = 0;
            this.Line = 0;
            this.__slot_EIeJNYbKjnpLGVj2t6LSWu = false;
            this.Selection = n9.Selection_R<int>.CreateDefault<n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>();
            this.Joined_Text = "";
            this.Selected_Text = "";
            this.Length = 0;
            this.Position = 0;
            this.__cp_PnBqqvlD2CXPzG4xIWC3D4 = n13._Operations_.CreateDefault<string>();
            this.__p_Se10orrR98LMXQTic4vUbf = n9.GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa.CreateDefault();
            this.__p_OZcrP6sx7ZVN6StphoSAyi = n9.RemoveSelected_MAdKROpcMMCMUeZTTqHRN4.CreateDefault();
            this.__p_P87ElqUS6j8PL8M5cyLZ0y = n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Se10orrR98LMXQTic4vUbf);
            n1.CompilationHelper.SafeDispose(this.__p_OZcrP6sx7ZVN6StphoSAyi);
            n1.CompilationHelper.SafeDispose(this.__p_P87ElqUS6j8PL8M5cyLZ0y);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 228432U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "NjnOQdM1ZzSNDDi7mJq4RR", Name = "Text")]
        public n5.SpreadBuilder<n5.SpreadBuilder<string>> Text;
        [n1.ElementAttribute(TracingId = 228434U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Q5BSwZBZhXQQE9T5vNXFYs", Name = "Cursor")]
        public int Cursor;
        [n1.ElementAttribute(TracingId = 228437U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "HtqRpQYQfhKLmMZQnaVtUr", Name = "Line")]
        public int Line;
        [n1.ElementAttribute(TracingId = 228587U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "RBIi6cYtEdcN5xSsZuJF9G", Name = "__slot_RBIi6cYtEdcN5xSsZuJF9G")]
        public static int __slot_RBIi6cYtEdcN5xSsZuJF9G = 9;
        [n1.ElementAttribute(TracingId = 230181U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "IGgQqdfNxM0O2klAeLf8nm", Name = "__slot_IGgQqdfNxM0O2klAeLf8nm")]
        public static string __slot_IGgQqdfNxM0O2klAeLf8nm = "//Remove one char";
        [n1.ElementAttribute(TracingId = 230182U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "U4nmTwXs5bIOuspv7L74E6", Name = "__slot_U4nmTwXs5bIOuspv7L74E6")]
        public static string __slot_U4nmTwXs5bIOuspv7L74E6 = "//Remove one line, jump to the end\r\nof the previous one.\r\nTake the rest of the line and add to another one.";
        [n1.ElementAttribute(TracingId = 230593U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "KGPMnqcU445OayAgKEfzXg", Name = "__slot_KGPMnqcU445OayAgKEfzXg")]
        public static int __slot_KGPMnqcU445OayAgKEfzXg = 1;
        [n1.ElementAttribute(TracingId = 230641U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Hh1eUOy1LSLNKW8ixcnrM8", Name = "__slot_Hh1eUOy1LSLNKW8ixcnrM8")]
        public static int __slot_Hh1eUOy1LSLNKW8ixcnrM8 = 0;
        [n1.ElementAttribute(TracingId = 231255U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "EIeJNYbKjnpLGVj2t6LSWu", Name = "__slot_EIeJNYbKjnpLGVj2t6LSWu")]
        public bool __slot_EIeJNYbKjnpLGVj2t6LSWu;
        [n1.ElementAttribute(TracingId = 229821U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "M8t5MYYwkh7OEakQNW5nUe", Name = "Selection")]
        public n9.Selection_R<int> Selection;
        [n1.ElementAttribute(TracingId = 231225U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Nz3eqNGHARaNaMyhtycKcQ", Name = "Joined Text")]
        public string Joined_Text;
        [n1.ElementAttribute(TracingId = 231227U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "MsL1FiyizH9LrLoQDWMcAJ", Name = "Selected Text")]
        public string Selected_Text;
        [n1.ElementAttribute(TracingId = 231229U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "KxMzjQDQobvMvuCOfvlTaA", Name = "Length")]
        public int Length;
        [n1.ElementAttribute(TracingId = 231231U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "LAlGtXjdVaGNWwg7IjelbS", Name = "Position")]
        public int Position;
        [n1.ElementAttribute(TracingId = 229778U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "SLGCbPp18KpMEhjf3bf2Pm", Name = "__slot_SLGCbPp18KpMEhjf3bf2Pm")]
        public static int __slot_SLGCbPp18KpMEhjf3bf2Pm = 0;
        [n1.ElementAttribute(TracingId = 229608U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "BS0cFAnayPDLpET2UjmSYV", Name = "__slot_BS0cFAnayPDLpET2UjmSYV")]
        public static int __slot_BS0cFAnayPDLpET2UjmSYV = 0;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<string> __cp_PnBqqvlD2CXPzG4xIWC3D4;
        [n1.ElementAttribute(TracingId = 231219U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Se10orrR98LMXQTic4vUbf", Name = "GetSelectedText", IsManaged = true, IsAutoGenerated = true)]
        public n9.GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa __p_Se10orrR98LMXQTic4vUbf;
        [n1.ElementAttribute(TracingId = 230086U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "OZcrP6sx7ZVN6StphoSAyi", Name = "RemoveSelected", IsManaged = true, IsAutoGenerated = true)]
        public n9.RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 __p_OZcrP6sx7ZVN6StphoSAyi;
        [n1.ElementAttribute(TracingId = 230925U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "P87ElqUS6j8PL8M5cyLZ0y", Name = "ToSelectedPositions", IsManaged = true, IsAutoGenerated = true)]
        public n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 __p_P87ElqUS6j8PL8M5cyLZ0y;
        static TextBuilder_C()
        {
        }

        public TextBuilder_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TextBuilder_C(TextBuilder_C other): base(other)
        {
            this.Text = other.Text;
            this.Cursor = other.Cursor;
            this.Line = other.Line;
            this.__slot_EIeJNYbKjnpLGVj2t6LSWu = other.__slot_EIeJNYbKjnpLGVj2t6LSWu;
            this.Selection = other.Selection;
            this.Joined_Text = other.Joined_Text;
            this.Selected_Text = other.Selected_Text;
            this.Length = other.Length;
            this.Position = other.Position;
            this.__cp_PnBqqvlD2CXPzG4xIWC3D4 = other.__cp_PnBqqvlD2CXPzG4xIWC3D4;
            this.__p_Se10orrR98LMXQTic4vUbf = other.__p_Se10orrR98LMXQTic4vUbf;
            this.__p_OZcrP6sx7ZVN6StphoSAyi = other.__p_OZcrP6sx7ZVN6StphoSAyi;
            this.__p_P87ElqUS6j8PL8M5cyLZ0y = other.__p_P87ElqUS6j8PL8M5cyLZ0y;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Text", in Text), n1.CompilationHelper.GetValueOrExisting(values, "Cursor", in Cursor), n1.CompilationHelper.GetValueOrExisting(values, "Line", in Line), n1.CompilationHelper.GetValueOrExisting(values, "__slot_EIeJNYbKjnpLGVj2t6LSWu", in __slot_EIeJNYbKjnpLGVj2t6LSWu), n1.CompilationHelper.GetValueOrExisting(values, "Selection", in Selection), n1.CompilationHelper.GetValueOrExisting(values, "Joined_Text", in Joined_Text), n1.CompilationHelper.GetValueOrExisting(values, "Selected_Text", in Selected_Text), n1.CompilationHelper.GetValueOrExisting(values, "Length", in Length), n1.CompilationHelper.GetValueOrExisting(values, "Position", in Position), n1.CompilationHelper.GetValueOrExisting(values, "__cp_PnBqqvlD2CXPzG4xIWC3D4", in __cp_PnBqqvlD2CXPzG4xIWC3D4), n1.CompilationHelper.GetValueOrExisting(values, "__p_Se10orrR98LMXQTic4vUbf", in __p_Se10orrR98LMXQTic4vUbf), n1.CompilationHelper.GetValueOrExisting(values, "__p_OZcrP6sx7ZVN6StphoSAyi", in __p_OZcrP6sx7ZVN6StphoSAyi), n1.CompilationHelper.GetValueOrExisting(values, "__p_P87ElqUS6j8PL8M5cyLZ0y", in __p_P87ElqUS6j8PL8M5cyLZ0y));
        }

        internal TextBuilder_C __WITH__(n5.SpreadBuilder<n5.SpreadBuilder<string>> Text, int Cursor, int Line, bool __slot_EIeJNYbKjnpLGVj2t6LSWu, n9.Selection_R<int> Selection, string Joined_Text, string Selected_Text, int Length, int Position, n5.Spread<string> __cp_PnBqqvlD2CXPzG4xIWC3D4, n9.GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa __p_Se10orrR98LMXQTic4vUbf, n9.RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 __p_OZcrP6sx7ZVN6StphoSAyi, n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 __p_P87ElqUS6j8PL8M5cyLZ0y)
        {
            n3.TextBuilder_C that_0 = this;
            this.Text = Text;
            this.Cursor = Cursor;
            this.Line = Line;
            this.__slot_EIeJNYbKjnpLGVj2t6LSWu = __slot_EIeJNYbKjnpLGVj2t6LSWu;
            this.Selection = Selection;
            this.Joined_Text = Joined_Text;
            this.Selected_Text = Selected_Text;
            this.Length = Length;
            this.Position = Position;
            this.__cp_PnBqqvlD2CXPzG4xIWC3D4 = __cp_PnBqqvlD2CXPzG4xIWC3D4;
            this.__p_Se10orrR98LMXQTic4vUbf = __p_Se10orrR98LMXQTic4vUbf;
            this.__p_OZcrP6sx7ZVN6StphoSAyi = __p_OZcrP6sx7ZVN6StphoSAyi;
            this.__p_P87ElqUS6j8PL8M5cyLZ0y = __p_P87ElqUS6j8PL8M5cyLZ0y;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 231764U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "BqQrMv16JtaMvZEPs5NWoK", Name = "Controls_BqQrMv16JtaMvZEPs5NWoK")]
    [n2.SerializableAttribute]
    public class Controls_BqQrMv16JtaMvZEPs5NWoK : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Controls_BqQrMv16JtaMvZEPs5NWoK Create(n1.NodeContext Node_Context)
        {
            var instance = new Controls_BqQrMv16JtaMvZEPs5NWoK(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Controls_BqQrMv16JtaMvZEPs5NWoK CreateDefault()
        {
            var instance = new Controls_BqQrMv16JtaMvZEPs5NWoK(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Controls_BqQrMv16JtaMvZEPs5NWoK Update(n19.KeyNotification Key_Notification_In, n2.Func<char, char> Char_Filter_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Enable_Char_Filter_In, out n5.Spread<n3.ControlData_R> Output_Out)
        {
            string __pad_NlEcTPHhC92Nm2t6TcxFif_0 = __slot_NlEcTPHhC92Nm2t6TcxFif;
            string __pad_JNWqlUYHPYtQA7yqNR7hk2_1 = __slot_JNWqlUYHPYtQA7yqNR7hk2;
            string __pad_IANGgJXtWY6OeARYUYUxyS_2 = __slot_IANGgJXtWY6OeARYUYUxyS;
            string __pad_Vy1BcPG5iWuOvYlhGoNObL_3 = __slot_Vy1BcPG5iWuOvYlhGoNObL;
            string __pad_D18k8VMqR2ZQPicleT1RQr_4 = __slot_D18k8VMqR2ZQPicleT1RQr;
            string __pad_HAbwgc2qxYhLL1f3dwBWqn_5 = __slot_HAbwgc2qxYhLL1f3dwBWqn;
            string __pad_NsLh7RwNyHQMHqHc2u3Dad_6 = __slot_NsLh7RwNyHQMHqHc2u3Dad;
            bool __auto_7 = this.DeletePressed;
            bool __auto_8 = this.BackPressed;
            string __pad_HMfkM5gLKv2QM2Q4UIhth1_9 = __slot_HMfkM5gLKv2QM2Q4UIhth1;
            string __pad_MKiyZL8hNGFMNcHUDt6OQs_10 = __slot_MKiyZL8hNGFMNcHUDt6OQs;
            string __pad_BfeI4CpgNPeQNeCW4cPR2o_11 = __slot_BfeI4CpgNPeQNeCW4cPR2o;
            string __pad_V5IGweUCSvwPNzsZGQaGIl_12 = __slot_V5IGweUCSvwPNzsZGQaGIl;
            string __pad_OMXjoaGKXfeMdBh2qJGGDv_13 = __slot_OMXjoaGKXfeMdBh2qJGGDv;
            string __pad_A0U1TnERPcqL484IEHzDTx_14 = __slot_A0U1TnERPcqL484IEHzDTx;
            string __pad_J1U940oU6a7OJbIbn7hjfq_15 = __slot_J1U940oU6a7OJbIbn7hjfq;
            string __pad_B898R29esRbQMbcVeFJdTF_16 = __slot_B898R29esRbQMbcVeFJdTF;
            string __pad_KoTCgnsIHSwNjDFNtA6LXA_17 = __slot_KoTCgnsIHSwNjDFNtA6LXA;
            string __pad_NdNR1iaFEFQNGj9Uihlgx8_18 = __slot_NdNR1iaFEFQNGj9Uihlgx8;
            string __pad_M2VJz1QAguKL8rZAqiZZoS_19 = __slot_M2VJz1QAguKL8rZAqiZZoS;
            string __pad_N80766Tu55aOVhBuwvDicT_20 = __slot_N80766Tu55aOVhBuwvDicT;
            string __pad_LWWKVaJLf4KOnS2LOatfAL_21 = __slot_LWWKVaJLf4KOnS2LOatfAL;
            string __pad_SgpTH541R18MS98Q2hSrl2_22 = __slot_SgpTH541R18MS98Q2hSrl2;
            string __pad_SbpwgK21iqbOyeHWgenI0o_23 = __slot_SbpwgK21iqbOyeHWgenI0o;
            string __pad_KNPiw4EZkJYL8NfBvJ901p_24 = __slot_KNPiw4EZkJYL8NfBvJ901p;
            string __pad_TJIr0a7MnpqMu1qgkVt7Yk_25 = __slot_TJIr0a7MnpqMu1qgkVt7Yk;
            string __pad_DfLLk1YbptuQUtsB99qT3z_26 = __slot_DfLLk1YbptuQUtsB99qT3z;
            string __pad_O2NMS7Kh14lN4q6P8pWDIK_27 = __slot_O2NMS7Kh14lN4q6P8pWDIK;
            string __pad_IM9PTvZAH2tO3ifdexONSe_28 = __slot_IM9PTvZAH2tO3ifdexONSe;
            var Is_Key_Up_29 = Key_Notification_In.IsKeyUp;
            var Is_Key_Down_30 = Key_Notification_In.IsKeyDown;
            var Output_31 = Is_Key_Down_30 || Is_Key_Up_29;
            string Output_32;
            if (Is_Key_Down_30)
            {
                n19.KeyCodeNotification Default_34 = default(n19.KeyCodeNotification);
                n20._Operations_.CastAs<n19.KeyCodeNotification>(Input_In: Key_Notification_In, Default_In: Default_34, Result_Out: out n19.KeyCodeNotification Result_35, Success_Out: out bool Success_36);
                var Key_Code_37 = Result_35.KeyCode;
                var Result_38 = n21.KeyboardNodes.ToKeyName(keyCode: Key_Code_37);
                Output_32 = Result_38;
            }
            else
            {
                Output_32 = "";
            }

            string __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 = Output_32;
            var Result_40 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_NlEcTPHhC92Nm2t6TcxFif_0;
            var Output_41 = Is_Key_Down_30 && Result_40;
            var Result_42 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_JNWqlUYHPYtQA7yqNR7hk2_1;
            var Output_43 = Is_Key_Down_30 && Result_42;
            var Is_Key_Press_44 = Key_Notification_In.IsKeyPress;
            char Output_45;
            bool __auto_46;
            if (Is_Key_Press_44)
            {
                bool __pad_GGLmXeR4S0fOGPZxpZidlL_48 = __slot_GGLmXeR4S0fOGPZxpZidlL;
                n19.KeyPressNotification Default_49 = default(n19.KeyPressNotification);
                n20._Operations_.CastAs<n19.KeyPressNotification>(Input_In: Key_Notification_In, Default_In: Default_49, Result_Out: out n19.KeyPressNotification Result_50, Success_Out: out bool Success_51);
                var Key_Char_52 = Result_50.KeyChar;
                char __auto_53;
                bool __auto_54;
                if (Enable_Char_Filter_In)
                {
                    byte __pad_JMsohk5V9LCMf7ewUen4N2_56 = __slot_JMsohk5V9LCMf7ewUen4N2;
                    n22._Operations_.Invoke<char, char>(Input_In: Char_Filter_In, Arg_In: Key_Char_52, Result_Out: out char Result_57);
                    __auto_53 = Result_57;
                    var Result_58 = n7.IntegerConversions.ToByte(input: Result_57);
                    var Result_59 = Result_58 != __pad_JMsohk5V9LCMf7ewUen4N2_56;
                    __auto_54 = Result_59;
                }
                else
                {
                    __auto_53 = Key_Char_52;
                    __auto_54 = __pad_GGLmXeR4S0fOGPZxpZidlL_48;
                }

                Output_45 = __auto_53;
                __auto_46 = __auto_54;
            }
            else
            {
                Output_45 = '\0';
                __auto_46 = false;
            }

            var Result_60 = char.IsControl(c: Output_45);
            var Result_61 = char.ToString(c: Output_45);
            var Empty_62 = string.Empty;
            n14._Operations_.Switch_Boolean<string>(Condition_In: Result_60, Input_In: Result_61, Input_2_In: Empty_62, Output_Out: out string Output_63);
            n3.ControlData_R Input_64 = n3.ControlData_R.CreateDefault();
            var Output_65 = Input_64.SetInsert(Insert_Tab_In: Output_43, Insert_NewLine_In: Output_41, Char_to_Insert_In: Output_63);
            var Output_66 = Output_43 || Output_41;
            var Output_67 = Output_66 || __auto_46;
            var Result_68 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_IANGgJXtWY6OeARYUYUxyS_2;
            var Ctrl_Key_69 = Key_Notification_In.CtrlKey;
            var Output_70 = Result_68 && Ctrl_Key_69;
            string __auto_71;
            if (Output_70)
            {
                n17.TextDataFormat __pad_EnPPXVwxGZPN5gk7BCOCM2_73 = __slot_EnPPXVwxGZPN5gk7BCOCM2;
                var Result_74 = n17.Clipboard.GetText(format: __pad_EnPPXVwxGZPN5gk7BCOCM2_73);
                string __auto_75;
                if (Enable_Char_Filter_In)
                {
                    n23._Operations_.TransformText(Input_In: Result_74, Delegate_In: Char_Filter_In, Result_Out: out string Result_77);
                    __auto_75 = Result_77;
                }
                else
                {
                    __auto_75 = Result_74;
                }

                __auto_71 = __auto_75;
            }
            else
            {
                __auto_71 = "";
            }

            var Result_78 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_Vy1BcPG5iWuOvYlhGoNObL_3;
            var Output_79 = Result_78 && Ctrl_Key_69;
            var Result_80 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_D18k8VMqR2ZQPicleT1RQr_4;
            var Output_81 = Result_80 && Ctrl_Key_69;
            var Output_82 = Output_79 || Output_81;
            var Output_83 = Output_70 || Output_81;
            n3.ControlData_R Input_84 = n3.ControlData_R.CreateDefault();
            bool Erase_Char_Back_85 = false;
            bool Erase_Char_Delete_86 = false;
            var Output_87 = Input_84.SetErase(Erase_Char_Back_In: Erase_Char_Back_85, Erase_Char_Delete_In: Erase_Char_Delete_86, Erase_Selection_In: Output_83);
            string Output_88;
            if (Output_31)
            {
                n19.KeyCodeNotification Default_90 = default(n19.KeyCodeNotification);
                n20._Operations_.CastAs<n19.KeyCodeNotification>(Input_In: Key_Notification_In, Default_In: Default_90, Result_Out: out n19.KeyCodeNotification Result_91, Success_Out: out bool Success_92);
                var Key_Code_93 = Result_91.KeyCode;
                var Result_94 = n21.KeyboardNodes.ToKeyName(keyCode: Key_Code_93);
                Output_88 = Result_94;
            }
            else
            {
                Output_88 = "";
            }

            var Result_95 = Output_88 == __pad_HAbwgc2qxYhLL1f3dwBWqn_5;
            var Output_96 = Output_31 && Result_95;
            var Output_97 = Is_Key_Down_30 && Result_95;
            n14._Operations_.Switch_Boolean<bool>(Condition_In: Output_96, Input_In: __auto_8, Input_2_In: Output_97, Output_Out: out bool Output_98);
            var Result_99 = Output_88 == __pad_NsLh7RwNyHQMHqHc2u3Dad_6;
            var Output_100 = Output_31 && Result_99;
            var Output_101 = Is_Key_Down_30 && Result_99;
            n14._Operations_.Switch_Boolean<bool>(Condition_In: Output_100, Input_In: __auto_7, Input_2_In: Output_101, Output_Out: out bool Output_102);
            n3.ControlData_R Input_103 = n3.ControlData_R.CreateDefault();
            bool Erase_Selection_104 = false;
            var Output_105 = Input_103.SetErase(Erase_Char_Back_In: Output_98, Erase_Char_Delete_In: Output_102, Erase_Selection_In: Erase_Selection_104);
            var Output_106 = Output_98 || Output_102;
            n5.Spread<n3.ControlData_R> Input_107 = n13._Operations_.CreateDefault<n3.ControlData_R>();
            var Output_108 = Input_107;
            if (Output_106)
            {
                n13._Operations_.Add<n3.ControlData_R>(Input_In: Input_107, Item_In: Output_105, Output_Out: out Output_108);
            }

            var Output_109 = Output_108;
            if (Output_67)
            {
                n13._Operations_.Add<n3.ControlData_R>(Input_In: Output_108, Item_In: Output_65, Output_Out: out Output_109);
            }

            var Ctrl_Key_110 = Key_Notification_In.CtrlKey;
            var Output_111 = !Ctrl_Key_110;
            string Input_112 = "";
            n14._Operations_.Switch_Boolean<string>(Condition_In: Output_111, Input_In: Input_112, Input_2_In: __pad_TsH9R4bYO7PQMOHTvaP8Ey_39, Output_Out: out string Output_113);
            var Result_114 = Output_113 == __pad_IM9PTvZAH2tO3ifdexONSe_28;
            var Result_115 = Output_113 == __pad_SgpTH541R18MS98Q2hSrl2_22;
            var Result_116 = Output_113 == __pad_SbpwgK21iqbOyeHWgenI0o_23;
            var Result_117 = Output_113 == __pad_LWWKVaJLf4KOnS2LOatfAL_21;
            var Result_118 = Output_113 == __pad_KNPiw4EZkJYL8NfBvJ901p_24;
            var Result_119 = Output_113 == __pad_TJIr0a7MnpqMu1qgkVt7Yk_25;
            var Result_120 = Output_113 == __pad_DfLLk1YbptuQUtsB99qT3z_26;
            var Result_121 = Output_113 == __pad_O2NMS7Kh14lN4q6P8pWDIK_27;
            n3.ControlData_R Input_122 = n3.ControlData_R.CreateDefault();
            var Output_123 = Input_122.SetMoveCursor(Left_In: Result_114, Right_In: Result_115, Up_In: Result_116, Down_In: Result_117, Home_In: Result_118, End_In: Result_119, PageUp_In: Result_120, PageDown_In: Result_121);
            var Output_124 = Result_114 || Result_115;
            var Output_125 = Output_124 || Result_116;
            var Output_126 = Output_125 || Result_117;
            var Output_127 = Output_126 || Result_118;
            var Output_128 = Output_127 || Result_119;
            var Output_129 = Output_128 || Result_120;
            var Output_130 = Output_129 || Result_121;
            var Output_131 = Output_109;
            if (Output_130)
            {
                n13._Operations_.Add<n3.ControlData_R>(Input_In: Output_109, Item_In: Output_123, Output_Out: out Output_131);
            }

            var Result_132 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_HMfkM5gLKv2QM2Q4UIhth1_9;
            var Output_133 = Result_132 && Ctrl_Key_110;
            var Result_134 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_MKiyZL8hNGFMNcHUDt6OQs_10;
            var Result_135 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_BfeI4CpgNPeQNeCW4cPR2o_11;
            var Result_136 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_V5IGweUCSvwPNzsZGQaGIl_12;
            var Result_137 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_OMXjoaGKXfeMdBh2qJGGDv_13;
            var Result_138 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_A0U1TnERPcqL484IEHzDTx_14;
            var Result_139 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_J1U940oU6a7OJbIbn7hjfq_15;
            var Result_140 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_B898R29esRbQMbcVeFJdTF_16;
            var Result_141 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_KoTCgnsIHSwNjDFNtA6LXA_17;
            var Result_142 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_NdNR1iaFEFQNGj9Uihlgx8_18;
            var Output_143 = Result_135 || Result_136;
            var Output_144 = Output_143 || Result_137;
            var Output_145 = Output_144 || Result_138;
            var Output_146 = Output_145 || Result_139;
            var Output_147 = Output_146 || Result_140;
            var Output_148 = Output_147 || Result_141;
            var Output_149 = Output_148 || Result_142;
            var Shift_Key_150 = Key_Notification_In.ShiftKey;
            var Output_151 = !Shift_Key_150;
            var Output_152 = Output_149 && Output_151;
            var Output_153 = Result_134 || Output_152;
            var Output_154 = Shift_Key_150 && Output_149;
            n3.ControlData_R Input_155 = n3.ControlData_R.CreateDefault();
            var Output_156 = Input_155.SetSelection(Select_All_In: Output_133, Reset_Selection_In: Output_153, Selection_Moved_In: Output_154);
            bool Input_157 = false;
            var Output_158 = Input_157 || Output_154;
            var Output_159 = Output_158 || Output_133;
            var Output_160 = Output_159 || Output_153;
            var Output_161 = Output_131;
            if (Output_160)
            {
                n13._Operations_.Add<n3.ControlData_R>(Input_In: Output_131, Item_In: Output_156, Output_Out: out Output_161);
            }

            n3.ControlData_R Input_162 = n3.ControlData_R.CreateDefault();
            bool Paste_163 = false;
            string Text_to_Paste_164 = "";
            var Output_165 = Input_162.SetClipboard(Copy_In: Output_82, Paste_In: Paste_163, Text_to_Paste_In: Text_to_Paste_164);
            var Output_166 = Output_161;
            if (Output_82)
            {
                n13._Operations_.Add<n3.ControlData_R>(Input_In: Output_161, Item_In: Output_165, Output_Out: out Output_166);
            }

            var Output_167 = Output_166;
            if (Output_83)
            {
                n13._Operations_.Add<n3.ControlData_R>(Input_In: Output_166, Item_In: Output_87, Output_Out: out Output_167);
            }

            bool __auto_168 = Output_102;
            bool __auto_169 = Output_98;
            var Result_170 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_M2VJz1QAguKL8rZAqiZZoS_19;
            var Output_171 = Result_170 && Ctrl_Key_69;
            var Result_172 = __pad_TsH9R4bYO7PQMOHTvaP8Ey_39 == __pad_N80766Tu55aOVhBuwvDicT_20;
            var Output_173 = Result_172 && Ctrl_Key_69;
            var Output_174 = Output_171 || Output_173;
            var Output_175 = Shift_Key_150 && Output_174;
            n3.ControlData_R Input_176 = n3.ControlData_R.CreateDefault();
            var Output_177 = Input_176.SetMoveCursorByWord(Move_Left_by_Word_In: Output_171, Move_Right_by_Word_In: Output_173);
            n3.ControlData_R Input_178 = n3.ControlData_R.CreateDefault();
            bool Copy_179 = false;
            var Output_180 = Input_178.SetClipboard(Copy_In: Copy_179, Paste_In: Output_70, Text_to_Paste_In: __auto_71);
            var Output_181 = Output_167;
            if (Output_70)
            {
                n13._Operations_.Add<n3.ControlData_R>(Input_In: Output_167, Item_In: Output_180, Output_Out: out Output_181);
            }

            var Output_182 = Output_181;
            if (Output_174)
            {
                n13._Operations_.Add<n3.ControlData_R>(Input_In: Output_181, Item_In: Output_177, Output_Out: out Output_182);
            }

            n3.ControlData_R Input_183 = n3.ControlData_R.CreateDefault();
            bool Select_All_184 = false;
            bool Reset_Selection_185 = false;
            var Output_186 = Input_183.SetSelection(Select_All_In: Select_All_184, Reset_Selection_In: Reset_Selection_185, Selection_Moved_In: Output_175);
            var Output_187 = Output_182;
            if (Output_175)
            {
                n13._Operations_.Add<n3.ControlData_R>(Input_In: Output_182, Item_In: Output_186, Output_Out: out Output_187);
            }

            Output_Out = Output_187;
            n3.Controls_BqQrMv16JtaMvZEPs5NWoK that_188 = this;
            if (this.__GetContext__().IsImmutable)
                that_188 = Output_32 != this.__slot_TsH9R4bYO7PQMOHTvaP8Ey || Output_102 != this.DeletePressed || Output_98 != this.BackPressed ? new Controls_BqQrMv16JtaMvZEPs5NWoK(this)
                {__slot_TsH9R4bYO7PQMOHTvaP8Ey = Output_32, DeletePressed = Output_102, BackPressed = Output_98} : that_188;
            else
            {
                this.__slot_TsH9R4bYO7PQMOHTvaP8Ey = Output_32;
                this.DeletePressed = Output_102;
                this.BackPressed = Output_98;
            }

            return that_188;
        }

        public n3.Controls_BqQrMv16JtaMvZEPs5NWoK __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Controls_BqQrMv16JtaMvZEPs5NWoK that_0 = this;
            this.__slot_TsH9R4bYO7PQMOHTvaP8Ey = "";
            this.BackPressed = false;
            this.DeletePressed = false;
            return that_0;
        }

        public n3.Controls_BqQrMv16JtaMvZEPs5NWoK __CreateDefault__()
        {
            n3.Controls_BqQrMv16JtaMvZEPs5NWoK that_0 = this;
            this.__slot_TsH9R4bYO7PQMOHTvaP8Ey = "";
            this.BackPressed = false;
            this.DeletePressed = false;
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

        [n1.ElementAttribute(TracingId = 231768U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "HAbwgc2qxYhLL1f3dwBWqn", Name = "__slot_HAbwgc2qxYhLL1f3dwBWqn")]
        public static string __slot_HAbwgc2qxYhLL1f3dwBWqn = "Back";
        [n1.ElementAttribute(TracingId = 231769U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "NsLh7RwNyHQMHqHc2u3Dad", Name = "__slot_NsLh7RwNyHQMHqHc2u3Dad")]
        public static string __slot_NsLh7RwNyHQMHqHc2u3Dad = "Delete";
        [n1.ElementAttribute(TracingId = 231835U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "JNWqlUYHPYtQA7yqNR7hk2", Name = "__slot_JNWqlUYHPYtQA7yqNR7hk2")]
        public static string __slot_JNWqlUYHPYtQA7yqNR7hk2 = "Tab";
        [n1.ElementAttribute(TracingId = 231844U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "NlEcTPHhC92Nm2t6TcxFif", Name = "__slot_NlEcTPHhC92Nm2t6TcxFif")]
        public static string __slot_NlEcTPHhC92Nm2t6TcxFif = "Return";
        [n1.ElementAttribute(TracingId = 231860U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "IM9PTvZAH2tO3ifdexONSe", Name = "__slot_IM9PTvZAH2tO3ifdexONSe")]
        public static string __slot_IM9PTvZAH2tO3ifdexONSe = "Left";
        [n1.ElementAttribute(TracingId = 231865U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "SgpTH541R18MS98Q2hSrl2", Name = "__slot_SgpTH541R18MS98Q2hSrl2")]
        public static string __slot_SgpTH541R18MS98Q2hSrl2 = "Right";
        [n1.ElementAttribute(TracingId = 231870U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "SbpwgK21iqbOyeHWgenI0o", Name = "__slot_SbpwgK21iqbOyeHWgenI0o")]
        public static string __slot_SbpwgK21iqbOyeHWgenI0o = "Up";
        [n1.ElementAttribute(TracingId = 231875U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "LWWKVaJLf4KOnS2LOatfAL", Name = "__slot_LWWKVaJLf4KOnS2LOatfAL")]
        public static string __slot_LWWKVaJLf4KOnS2LOatfAL = "Down";
        [n1.ElementAttribute(TracingId = 231902U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "MKiyZL8hNGFMNcHUDt6OQs", Name = "__slot_MKiyZL8hNGFMNcHUDt6OQs")]
        public static string __slot_MKiyZL8hNGFMNcHUDt6OQs = "Escape";
        [n1.ElementAttribute(TracingId = 231903U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "BfeI4CpgNPeQNeCW4cPR2o", Name = "__slot_BfeI4CpgNPeQNeCW4cPR2o")]
        public static string __slot_BfeI4CpgNPeQNeCW4cPR2o = "Left";
        [n1.ElementAttribute(TracingId = 231904U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "V5IGweUCSvwPNzsZGQaGIl", Name = "__slot_V5IGweUCSvwPNzsZGQaGIl")]
        public static string __slot_V5IGweUCSvwPNzsZGQaGIl = "Right";
        [n1.ElementAttribute(TracingId = 231927U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "HMfkM5gLKv2QM2Q4UIhth1", Name = "__slot_HMfkM5gLKv2QM2Q4UIhth1")]
        public static string __slot_HMfkM5gLKv2QM2Q4UIhth1 = "A";
        [n1.ElementAttribute(TracingId = 231947U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Vy1BcPG5iWuOvYlhGoNObL", Name = "__slot_Vy1BcPG5iWuOvYlhGoNObL")]
        public static string __slot_Vy1BcPG5iWuOvYlhGoNObL = "C";
        [n1.ElementAttribute(TracingId = 231963U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "IANGgJXtWY6OeARYUYUxyS", Name = "__slot_IANGgJXtWY6OeARYUYUxyS")]
        public static string __slot_IANGgJXtWY6OeARYUYUxyS = "V";
        [n1.ElementAttribute(TracingId = 231972U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "M2VJz1QAguKL8rZAqiZZoS", Name = "__slot_M2VJz1QAguKL8rZAqiZZoS")]
        public static string __slot_M2VJz1QAguKL8rZAqiZZoS = "Left";
        [n1.ElementAttribute(TracingId = 231973U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "N80766Tu55aOVhBuwvDicT", Name = "__slot_N80766Tu55aOVhBuwvDicT")]
        public static string __slot_N80766Tu55aOVhBuwvDicT = "Right";
        [n1.ElementAttribute(TracingId = 231994U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "OMXjoaGKXfeMdBh2qJGGDv", Name = "__slot_OMXjoaGKXfeMdBh2qJGGDv")]
        public static string __slot_OMXjoaGKXfeMdBh2qJGGDv = "Up";
        [n1.ElementAttribute(TracingId = 231999U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "A0U1TnERPcqL484IEHzDTx", Name = "__slot_A0U1TnERPcqL484IEHzDTx")]
        public static string __slot_A0U1TnERPcqL484IEHzDTx = "Down";
        [n1.ElementAttribute(TracingId = 232011U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "D18k8VMqR2ZQPicleT1RQr", Name = "__slot_D18k8VMqR2ZQPicleT1RQr")]
        public static string __slot_D18k8VMqR2ZQPicleT1RQr = "X";
        [n1.ElementAttribute(TracingId = 232160U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "TsH9R4bYO7PQMOHTvaP8Ey", Name = "__slot_TsH9R4bYO7PQMOHTvaP8Ey")]
        public string __slot_TsH9R4bYO7PQMOHTvaP8Ey;
        [n1.ElementAttribute(TracingId = 232166U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "KNPiw4EZkJYL8NfBvJ901p", Name = "__slot_KNPiw4EZkJYL8NfBvJ901p")]
        public static string __slot_KNPiw4EZkJYL8NfBvJ901p = "Home";
        [n1.ElementAttribute(TracingId = 232171U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "TJIr0a7MnpqMu1qgkVt7Yk", Name = "__slot_TJIr0a7MnpqMu1qgkVt7Yk")]
        public static string __slot_TJIr0a7MnpqMu1qgkVt7Yk = "End";
        [n1.ElementAttribute(TracingId = 232176U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "J1U940oU6a7OJbIbn7hjfq", Name = "__slot_J1U940oU6a7OJbIbn7hjfq")]
        public static string __slot_J1U940oU6a7OJbIbn7hjfq = "Home";
        [n1.ElementAttribute(TracingId = 232181U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "B898R29esRbQMbcVeFJdTF", Name = "__slot_B898R29esRbQMbcVeFJdTF")]
        public static string __slot_B898R29esRbQMbcVeFJdTF = "End";
        [n1.ElementAttribute(TracingId = 232186U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "KoTCgnsIHSwNjDFNtA6LXA", Name = "__slot_KoTCgnsIHSwNjDFNtA6LXA")]
        public static string __slot_KoTCgnsIHSwNjDFNtA6LXA = "PageUp";
        [n1.ElementAttribute(TracingId = 232191U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "NdNR1iaFEFQNGj9Uihlgx8", Name = "__slot_NdNR1iaFEFQNGj9Uihlgx8")]
        public static string __slot_NdNR1iaFEFQNGj9Uihlgx8 = "Next";
        [n1.ElementAttribute(TracingId = 232196U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "DfLLk1YbptuQUtsB99qT3z", Name = "__slot_DfLLk1YbptuQUtsB99qT3z")]
        public static string __slot_DfLLk1YbptuQUtsB99qT3z = "PageUp";
        [n1.ElementAttribute(TracingId = 232201U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "O2NMS7Kh14lN4q6P8pWDIK", Name = "__slot_O2NMS7Kh14lN4q6P8pWDIK")]
        public static string __slot_O2NMS7Kh14lN4q6P8pWDIK = "Next";
        [n1.ElementAttribute(TracingId = 231771U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "NYkPhx9dXq1OF1enkrppIS", Name = "BackPressed")]
        public bool BackPressed;
        [n1.ElementAttribute(TracingId = 231774U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "N4AeHlrIcVzNsl2buGh8F7", Name = "DeletePressed")]
        public bool DeletePressed;
        [n1.ElementAttribute(TracingId = 232251U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "GGLmXeR4S0fOGPZxpZidlL", Name = "__slot_GGLmXeR4S0fOGPZxpZidlL")]
        public static bool __slot_GGLmXeR4S0fOGPZxpZidlL = true;
        [n1.ElementAttribute(TracingId = 232243U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "JMsohk5V9LCMf7ewUen4N2", Name = "__slot_JMsohk5V9LCMf7ewUen4N2")]
        public static byte __slot_JMsohk5V9LCMf7ewUen4N2 = 0;
        [n1.ElementAttribute(TracingId = 232313U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "EnPPXVwxGZPN5gk7BCOCM2", Name = "__slot_EnPPXVwxGZPN5gk7BCOCM2")]
        public static n17.TextDataFormat __slot_EnPPXVwxGZPN5gk7BCOCM2 = n1.CompilationHelper.Deserialize<n17.TextDataFormat>("UnicodeText", false, "AjFNjMAblDQMnPebi4p4Dw", "EnPPXVwxGZPN5gk7BCOCM2");
        static Controls_BqQrMv16JtaMvZEPs5NWoK()
        {
        }

        public Controls_BqQrMv16JtaMvZEPs5NWoK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Controls_BqQrMv16JtaMvZEPs5NWoK(Controls_BqQrMv16JtaMvZEPs5NWoK other): base(other)
        {
            this.__slot_TsH9R4bYO7PQMOHTvaP8Ey = other.__slot_TsH9R4bYO7PQMOHTvaP8Ey;
            this.BackPressed = other.BackPressed;
            this.DeletePressed = other.DeletePressed;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_TsH9R4bYO7PQMOHTvaP8Ey", in __slot_TsH9R4bYO7PQMOHTvaP8Ey), n1.CompilationHelper.GetValueOrExisting(values, "BackPressed", in BackPressed), n1.CompilationHelper.GetValueOrExisting(values, "DeletePressed", in DeletePressed));
        }

        internal Controls_BqQrMv16JtaMvZEPs5NWoK __WITH__(string __slot_TsH9R4bYO7PQMOHTvaP8Ey, bool BackPressed, bool DeletePressed)
        {
            n3.Controls_BqQrMv16JtaMvZEPs5NWoK that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_TsH9R4bYO7PQMOHTvaP8Ey != this.__slot_TsH9R4bYO7PQMOHTvaP8Ey || BackPressed != this.BackPressed || DeletePressed != this.DeletePressed ? new Controls_BqQrMv16JtaMvZEPs5NWoK(this)
                {__slot_TsH9R4bYO7PQMOHTvaP8Ey = __slot_TsH9R4bYO7PQMOHTvaP8Ey, BackPressed = BackPressed, DeletePressed = DeletePressed} : that_0;
            else
            {
                this.__slot_TsH9R4bYO7PQMOHTvaP8Ey = __slot_TsH9R4bYO7PQMOHTvaP8Ey;
                this.BackPressed = BackPressed;
                this.DeletePressed = DeletePressed;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 232584U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Cb2h9Zq5Hj9NUpyPY1xBds", Name = "ControlData_R")]
    [n2.SerializableAttribute]
    public class ControlData_R : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ControlData_R Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new ControlData_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ControlData_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n3.ControlData_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new ControlData_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.ControlData_R __DEFAULT__;
        public n3.ControlData_R Split()
        {
            return this;
        }

        public n3.ControlData_R MoveCursor(out bool Left_Out, out bool Right_Out, out bool Up_Out, out bool IsMoved_Out, out bool Down_Out, out bool Home_Out, out bool End_Out, out bool PageUp_Out, out bool PageDown_Out)
        {
            bool __auto_0 = this.Left;
            bool __auto_1 = this.Right;
            bool __auto_2 = this.Up;
            bool __auto_3 = this.Down;
            bool __auto_4 = this.Home;
            bool __auto_5 = this.End;
            bool __auto_6 = this.PageUp;
            bool __auto_7 = this.PageDown;
            var Output_8 = __auto_0 || __auto_1;
            var Output_9 = Output_8 || __auto_2;
            var Output_10 = Output_9 || __auto_3;
            var Output_11 = Output_10 || __auto_4;
            var Output_12 = Output_11 || __auto_5;
            var Output_13 = Output_12 || __auto_6;
            var Output_14 = Output_13 || __auto_7;
            Left_Out = __auto_0;
            Right_Out = __auto_1;
            Up_Out = __auto_2;
            IsMoved_Out = Output_14;
            Down_Out = __auto_3;
            Home_Out = __auto_4;
            End_Out = __auto_5;
            PageUp_Out = __auto_6;
            PageDown_Out = __auto_7;
            return this;
        }

        public n3.ControlData_R MoveCursorByWord(out bool Left_Out, out bool Right_Out, out bool IsMoved_Out)
        {
            bool __auto_0 = this.Move_Left_by_Word;
            bool __auto_1 = this.Move_Right_by_Word;
            var Output_2 = __auto_0 || __auto_1;
            Left_Out = __auto_0;
            Right_Out = __auto_1;
            IsMoved_Out = Output_2;
            return this;
        }

        public n3.ControlData_R Erase(out bool Erase_Char_Back_Out, out bool Erase_Char_Delete_Out, out bool Erase_Selection_Out)
        {
            bool __auto_0 = this.Erase_Char_Back;
            bool __auto_1 = this.Erase_Char_Delete;
            bool __auto_2 = this.Erase_Selection;
            Erase_Char_Back_Out = __auto_0;
            Erase_Char_Delete_Out = __auto_1;
            Erase_Selection_Out = __auto_2;
            return this;
        }

        public n3.ControlData_R Insert(out bool Insert_Tab_Out, out bool Insert_NewLine_Out, out string Char_to_Insert_Out, out bool Insert_Char_Out)
        {
            bool __auto_0 = this.Insert_Tab;
            bool __auto_1 = this.Insert_NewLine;
            string __auto_2 = this.Char_to_Insert;
            var Result_3 = string.IsNullOrEmpty(value: __auto_2);
            var Output_4 = !Result_3;
            Insert_Tab_Out = __auto_0;
            Insert_NewLine_Out = __auto_1;
            Char_to_Insert_Out = __auto_2;
            Insert_Char_Out = Output_4;
            return this;
        }

        public n3.ControlData_R Clipboard(out bool Copy_Out, out bool Paste_Out, out string Text_to_Paste_Out)
        {
            bool __auto_0 = this.Copy;
            bool __auto_1 = this.Paste;
            string __auto_2 = this.Text_to_Paste;
            Copy_Out = __auto_0;
            Paste_Out = __auto_1;
            Text_to_Paste_Out = __auto_2;
            return this;
        }

        public n3.ControlData_R Selection(out bool Select_All_Out, out bool Reset_Selection_Out, out bool Selection_Moved_Out)
        {
            bool __auto_0 = this.Select_All;
            bool __auto_1 = this.Reset_Selection;
            bool __auto_2 = this.Selection_Moved;
            var Output_3 = __auto_0 || __auto_1;
            var Output_4 = Output_3 || __auto_2;
            Select_All_Out = __auto_0;
            Reset_Selection_Out = __auto_1;
            Selection_Moved_Out = Output_4;
            return this;
        }

        public n3.ControlData_R SetErase(bool Erase_Char_Back_In, bool Erase_Char_Delete_In, bool Erase_Selection_In)
        {
            bool __auto_0 = Erase_Char_Back_In;
            bool __auto_1 = Erase_Char_Delete_In;
            bool __auto_2 = Erase_Selection_In;
            n3.ControlData_R that_3 = this;
            that_3 = Erase_Char_Back_In != this.Erase_Char_Back || Erase_Char_Delete_In != this.Erase_Char_Delete || Erase_Selection_In != this.Erase_Selection ? new ControlData_R(this)
            {Erase_Char_Back = Erase_Char_Back_In, Erase_Char_Delete = Erase_Char_Delete_In, Erase_Selection = Erase_Selection_In} : that_3;
            return that_3;
        }

        public n3.ControlData_R SetInsert(bool Insert_Tab_In, bool Insert_NewLine_In, string Char_to_Insert_In)
        {
            bool __auto_0 = Insert_Tab_In;
            bool __auto_1 = Insert_NewLine_In;
            string __auto_2 = Char_to_Insert_In;
            n3.ControlData_R that_3 = this;
            that_3 = Insert_Tab_In != this.Insert_Tab || Insert_NewLine_In != this.Insert_NewLine || Char_to_Insert_In != this.Char_to_Insert ? new ControlData_R(this)
            {Insert_Tab = Insert_Tab_In, Insert_NewLine = Insert_NewLine_In, Char_to_Insert = Char_to_Insert_In} : that_3;
            return that_3;
        }

        public n3.ControlData_R SetMoveCursor(bool Left_In, bool Right_In, bool Up_In, bool Down_In, bool Home_In, bool End_In, bool PageUp_In, bool PageDown_In)
        {
            bool __auto_0 = Left_In;
            bool __auto_1 = Right_In;
            bool __auto_2 = Up_In;
            bool __auto_3 = Down_In;
            bool __auto_4 = Home_In;
            bool __auto_5 = End_In;
            bool __auto_6 = PageUp_In;
            bool __auto_7 = PageDown_In;
            n3.ControlData_R that_8 = this;
            that_8 = Left_In != this.Left || Right_In != this.Right || Up_In != this.Up || Down_In != this.Down || Home_In != this.Home || End_In != this.End || PageUp_In != this.PageUp || PageDown_In != this.PageDown ? new ControlData_R(this)
            {Left = Left_In, Right = Right_In, Up = Up_In, Down = Down_In, Home = Home_In, End = End_In, PageUp = PageUp_In, PageDown = PageDown_In} : that_8;
            return that_8;
        }

        public n3.ControlData_R SetSelection(bool Select_All_In, bool Reset_Selection_In, bool Selection_Moved_In)
        {
            bool __auto_0 = Select_All_In;
            bool __auto_1 = Reset_Selection_In;
            bool __auto_2 = Selection_Moved_In;
            n3.ControlData_R that_3 = this;
            that_3 = Select_All_In != this.Select_All || Reset_Selection_In != this.Reset_Selection || Selection_Moved_In != this.Selection_Moved ? new ControlData_R(this)
            {Select_All = Select_All_In, Reset_Selection = Reset_Selection_In, Selection_Moved = Selection_Moved_In} : that_3;
            return that_3;
        }

        public n3.ControlData_R SetClipboard(bool Copy_In, bool Paste_In, string Text_to_Paste_In)
        {
            bool __auto_0 = Copy_In;
            bool __auto_1 = Paste_In;
            string __auto_2 = Text_to_Paste_In;
            n3.ControlData_R that_3 = this;
            that_3 = Copy_In != this.Copy || Paste_In != this.Paste || Text_to_Paste_In != this.Text_to_Paste ? new ControlData_R(this)
            {Copy = Copy_In, Paste = Paste_In, Text_to_Paste = Text_to_Paste_In} : that_3;
            return that_3;
        }

        public n3.ControlData_R SetMoveCursorByWord(bool Move_Left_by_Word_In, bool Move_Right_by_Word_In)
        {
            bool __auto_0 = Move_Left_by_Word_In;
            bool __auto_1 = Move_Right_by_Word_In;
            n3.ControlData_R that_2 = this;
            that_2 = Move_Left_by_Word_In != this.Move_Left_by_Word || Move_Right_by_Word_In != this.Move_Right_by_Word ? new ControlData_R(this)
            {Move_Left_by_Word = Move_Left_by_Word_In, Move_Right_by_Word = Move_Right_by_Word_In} : that_2;
            return that_2;
        }

        public n3.ControlData_R __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.ControlData_R that_0 = this;
            this.Erase_Char_Back = false;
            this.Erase_Char_Delete = false;
            this.Erase_Selection = false;
            this.Insert_Tab = false;
            this.Insert_NewLine = false;
            this.Left = false;
            this.Right = false;
            this.Up = false;
            this.Down = false;
            this.Char_to_Insert = "";
            this.Select_All = false;
            this.Reset_Selection = false;
            this.Copy = false;
            this.Paste = false;
            this.Move_Left_by_Word = false;
            this.Move_Right_by_Word = false;
            this.Selection_Moved = false;
            this.Home = false;
            this.End = false;
            this.PageUp = false;
            this.PageDown = false;
            this.Text_to_Paste = "";
            return that_0;
        }

        public n3.ControlData_R __CreateDefault__()
        {
            n3.ControlData_R that_0 = this;
            this.Erase_Char_Back = false;
            this.Erase_Char_Delete = false;
            this.Erase_Selection = false;
            this.Insert_Tab = false;
            this.Insert_NewLine = false;
            this.Left = false;
            this.Right = false;
            this.Up = false;
            this.Down = false;
            this.Char_to_Insert = "";
            this.Select_All = false;
            this.Reset_Selection = false;
            this.Copy = false;
            this.Paste = false;
            this.Move_Left_by_Word = false;
            this.Move_Right_by_Word = false;
            this.Selection_Moved = false;
            this.Home = false;
            this.End = false;
            this.PageUp = false;
            this.PageDown = false;
            this.Text_to_Paste = "";
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

        [n1.ElementAttribute(TracingId = 232590U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "N7ugjqKixi6NeBlVkySqzs", Name = "Erase Char Back")]
        public bool Erase_Char_Back;
        [n1.ElementAttribute(TracingId = 232588U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Vl1xRQ6BhOCL9y5OgWRT3x", Name = "Erase Char Delete")]
        public bool Erase_Char_Delete;
        [n1.ElementAttribute(TracingId = 232592U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "BHZ56gD2lJNPjJo8jZc8Lx", Name = "Erase Selection")]
        public bool Erase_Selection;
        [n1.ElementAttribute(TracingId = 232594U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "TBPlkxvXfyQO7IEpzLJa0x", Name = "Insert Tab")]
        public bool Insert_Tab;
        [n1.ElementAttribute(TracingId = 232596U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Eyso17QW0mWNFdF7o6Xrbz", Name = "Insert NewLine")]
        public bool Insert_NewLine;
        [n1.ElementAttribute(TracingId = 232598U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "MKBAA7cHbsRPh8Eas8otl4", Name = "Left")]
        public bool Left;
        [n1.ElementAttribute(TracingId = 232600U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "OW6hc2sB6H1LIUsDj19S9B", Name = "Right")]
        public bool Right;
        [n1.ElementAttribute(TracingId = 232602U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "E51uslCLFMoO0xknWZpFyo", Name = "Up")]
        public bool Up;
        [n1.ElementAttribute(TracingId = 232604U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Eq9S7QJfAH5NZIzcz8mbMN", Name = "Down")]
        public bool Down;
        [n1.ElementAttribute(TracingId = 232606U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "EpuUDPhGjlDPlguquS0W7S", Name = "Char to Insert")]
        public string Char_to_Insert;
        [n1.ElementAttribute(TracingId = 232608U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "LarPYJmKRjWNKYEYv2EGrX", Name = "Select All")]
        public bool Select_All;
        [n1.ElementAttribute(TracingId = 232610U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Dj7sEco6X4qPYbqHecg8dY", Name = "Reset Selection")]
        public bool Reset_Selection;
        [n1.ElementAttribute(TracingId = 232612U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "MdnBwl23YFpQHf0dTfuAfJ", Name = "Copy")]
        public bool Copy;
        [n1.ElementAttribute(TracingId = 232614U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "V7PU9gZwwA1OYrQiw91xSG", Name = "Paste")]
        public bool Paste;
        [n1.ElementAttribute(TracingId = 232616U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "OXIpSljdhhhNqblCzdOpVJ", Name = "Move Left by Word")]
        public bool Move_Left_by_Word;
        [n1.ElementAttribute(TracingId = 232618U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "CfULueJMNwJLyQPLdKGcc6", Name = "Move Right by Word")]
        public bool Move_Right_by_Word;
        [n1.ElementAttribute(TracingId = 232681U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "QNSSqYXR02DNd4TxBmxUfq", Name = "Selection Moved")]
        public bool Selection_Moved;
        [n1.ElementAttribute(TracingId = 232684U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "RyXKEP3GQsHOTf1J574uXm", Name = "Home")]
        public bool Home;
        [n1.ElementAttribute(TracingId = 232688U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "IZ7VwZdQDfKQDPtB6OFqq9", Name = "End")]
        public bool End;
        [n1.ElementAttribute(TracingId = 232692U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "GwdjTZmWXpmQQgK8SuWdUN", Name = "PageUp")]
        public bool PageUp;
        [n1.ElementAttribute(TracingId = 232695U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Kuta3UT16KyP7Pp4vQcmxc", Name = "PageDown")]
        public bool PageDown;
        [n1.ElementAttribute(TracingId = 232700U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "JaH9T8ijLBcPloR7v81vEJ", Name = "Text to Paste")]
        public string Text_to_Paste;
        public ControlData_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ControlData_R(ControlData_R other): base(other)
        {
            this.Erase_Char_Back = other.Erase_Char_Back;
            this.Erase_Char_Delete = other.Erase_Char_Delete;
            this.Erase_Selection = other.Erase_Selection;
            this.Insert_Tab = other.Insert_Tab;
            this.Insert_NewLine = other.Insert_NewLine;
            this.Left = other.Left;
            this.Right = other.Right;
            this.Up = other.Up;
            this.Down = other.Down;
            this.Char_to_Insert = other.Char_to_Insert;
            this.Select_All = other.Select_All;
            this.Reset_Selection = other.Reset_Selection;
            this.Copy = other.Copy;
            this.Paste = other.Paste;
            this.Move_Left_by_Word = other.Move_Left_by_Word;
            this.Move_Right_by_Word = other.Move_Right_by_Word;
            this.Selection_Moved = other.Selection_Moved;
            this.Home = other.Home;
            this.End = other.End;
            this.PageUp = other.PageUp;
            this.PageDown = other.PageDown;
            this.Text_to_Paste = other.Text_to_Paste;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Erase_Char_Back", in Erase_Char_Back), n1.CompilationHelper.GetValueOrExisting(values, "Erase_Char_Delete", in Erase_Char_Delete), n1.CompilationHelper.GetValueOrExisting(values, "Erase_Selection", in Erase_Selection), n1.CompilationHelper.GetValueOrExisting(values, "Insert_Tab", in Insert_Tab), n1.CompilationHelper.GetValueOrExisting(values, "Insert_NewLine", in Insert_NewLine), n1.CompilationHelper.GetValueOrExisting(values, "Left", in Left), n1.CompilationHelper.GetValueOrExisting(values, "Right", in Right), n1.CompilationHelper.GetValueOrExisting(values, "Up", in Up), n1.CompilationHelper.GetValueOrExisting(values, "Down", in Down), n1.CompilationHelper.GetValueOrExisting(values, "Char_to_Insert", in Char_to_Insert), n1.CompilationHelper.GetValueOrExisting(values, "Select_All", in Select_All), n1.CompilationHelper.GetValueOrExisting(values, "Reset_Selection", in Reset_Selection), n1.CompilationHelper.GetValueOrExisting(values, "Copy", in Copy), n1.CompilationHelper.GetValueOrExisting(values, "Paste", in Paste), n1.CompilationHelper.GetValueOrExisting(values, "Move_Left_by_Word", in Move_Left_by_Word), n1.CompilationHelper.GetValueOrExisting(values, "Move_Right_by_Word", in Move_Right_by_Word), n1.CompilationHelper.GetValueOrExisting(values, "Selection_Moved", in Selection_Moved), n1.CompilationHelper.GetValueOrExisting(values, "Home", in Home), n1.CompilationHelper.GetValueOrExisting(values, "End", in End), n1.CompilationHelper.GetValueOrExisting(values, "PageUp", in PageUp), n1.CompilationHelper.GetValueOrExisting(values, "PageDown", in PageDown), n1.CompilationHelper.GetValueOrExisting(values, "Text_to_Paste", in Text_to_Paste));
        }

        internal ControlData_R __WITH__(bool Erase_Char_Back, bool Erase_Char_Delete, bool Erase_Selection, bool Insert_Tab, bool Insert_NewLine, bool Left, bool Right, bool Up, bool Down, string Char_to_Insert, bool Select_All, bool Reset_Selection, bool Copy, bool Paste, bool Move_Left_by_Word, bool Move_Right_by_Word, bool Selection_Moved, bool Home, bool End, bool PageUp, bool PageDown, string Text_to_Paste)
        {
            n3.ControlData_R that_0 = this;
            that_0 = Erase_Char_Back != this.Erase_Char_Back || Erase_Char_Delete != this.Erase_Char_Delete || Erase_Selection != this.Erase_Selection || Insert_Tab != this.Insert_Tab || Insert_NewLine != this.Insert_NewLine || Left != this.Left || Right != this.Right || Up != this.Up || Down != this.Down || Char_to_Insert != this.Char_to_Insert || Select_All != this.Select_All || Reset_Selection != this.Reset_Selection || Copy != this.Copy || Paste != this.Paste || Move_Left_by_Word != this.Move_Left_by_Word || Move_Right_by_Word != this.Move_Right_by_Word || Selection_Moved != this.Selection_Moved || Home != this.Home || End != this.End || PageUp != this.PageUp || PageDown != this.PageDown || Text_to_Paste != this.Text_to_Paste ? new ControlData_R(this)
            {Erase_Char_Back = Erase_Char_Back, Erase_Char_Delete = Erase_Char_Delete, Erase_Selection = Erase_Selection, Insert_Tab = Insert_Tab, Insert_NewLine = Insert_NewLine, Left = Left, Right = Right, Up = Up, Down = Down, Char_to_Insert = Char_to_Insert, Select_All = Select_All, Reset_Selection = Reset_Selection, Copy = Copy, Paste = Paste, Move_Left_by_Word = Move_Left_by_Word, Move_Right_by_Word = Move_Right_by_Word, Selection_Moved = Selection_Moved, Home = Home, End = End, PageUp = PageUp, PageDown = PageDown, Text_to_Paste = Text_to_Paste} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 232888U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "TeYZprWSsFsNNwnnc5FBn0", Name = "TypewriterInput_TeYZprWSsFsNNwnnc5FBn0")]
    [n2.SerializableAttribute]
    public class TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 Create(n1.NodeContext Node_Context)
        {
            var instance = new TypewriterInput_TeYZprWSsFsNNwnnc5FBn0(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 CreateDefault()
        {
            var instance = new TypewriterInput_TeYZprWSsFsNNwnnc5FBn0(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 Update(n27.IKeyboard Input_In, n2.Func<char, char> Char_Filter_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Enable_Char_Filter_In, out n5.Spread<n3.ControlData_R> Output_Out)
        {
            var Notifications_0 = Input_In.Notifications;
            n25._Operations_.Sample_H<n19.KeyNotification>(Input_In: this.__p_HnAwHXKU1KoPoadYNaImxR, Async_Notifications_In: Notifications_0, Output_Out: out n24.Sampler<n19.KeyNotification> Output_1, Notifications_Out: out n5.Spread<n19.KeyNotification> Notifications_2, On_Data_Out: out bool On_Data_3);
            var manager_13 = this.__loop_MoRAg3sEErRNM0ueKBKgc4 ?? new n26.ImmutableLifetimeManager();
            var iterator_14 = manager_13.GetIterator(__GetContext__());
            var builder_15 = n4.CollectionBuilders.GetBuilder(this.__cp_IQZS3y1Sy2vMQLHarkRUHk, 16);
            n5.Spread<n5.Spread<n3.ControlData_R>> output_16;
            try
            {
                var i_6 = 0;
                foreach (var item_4 in n4.CollectionExtensions.AsSpan(Notifications_2))
                {
                    var splicer_5 = item_4;
                    var i_local_7 = i_6;
                    __SQ2BMvjbnf2Nzl0pMtfAkr state_8;
                    if (!iterator_14.MoveNext(out state_8))
                    {
                        iterator_14.Add(state_8 = new __SQ2BMvjbnf2Nzl0pMtfAkr(__GetContext__(), n1.VLObject.NewIdentity()));
                        n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "UlTItgp6JAkOs5DPWW9PgC", 232908U);
                        var Output_10 = n3.Controls_BqQrMv16JtaMvZEPs5NWoK.Create(Node_Context: Node_Context_9);
                        state_8.__p_UlTItgp6JAkOs5DPWW9PgC = Output_10;
                    }

                    var State_Output_12 = state_8.__p_UlTItgp6JAkOs5DPWW9PgC.Update(Key_Notification_In: splicer_5, Char_Filter_In: Char_Filter_In, Enable_Char_Filter_In: Enable_Char_Filter_In, Output_Out: out n5.Spread<n3.ControlData_R> Output_11);
                    if (state_8.__GetContext__().IsImmutable)
                        state_8 = State_Output_12 != state_8.__p_UlTItgp6JAkOs5DPWW9PgC ? new __SQ2BMvjbnf2Nzl0pMtfAkr(state_8)
                        {__p_UlTItgp6JAkOs5DPWW9PgC = State_Output_12} : state_8;
                    else
                    {
                        state_8.__p_UlTItgp6JAkOs5DPWW9PgC = State_Output_12;
                    }

                    iterator_14.Update(state_8);
                    builder_15.Add(Output_11);
                    i_6++;
                }
            }
            finally
            {
                manager_13 = iterator_14.Commit();
                output_16 = builder_15.Commit();
            }

            n13._Operations_.Flatten<n5.Spread<n5.Spread<n3.ControlData_R>>, n3.ControlData_R>(Input_In: output_16, Output_Out: out n5.Spread<n3.ControlData_R> Output_17);
            Output_Out = Output_17;
            n3.TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 that_18 = this;
            if (this.__GetContext__().IsImmutable)
                that_18 = Output_1 != this.__p_HnAwHXKU1KoPoadYNaImxR || manager_13 != this.__loop_MoRAg3sEErRNM0ueKBKgc4 || output_16 != this.__cp_IQZS3y1Sy2vMQLHarkRUHk ? new TypewriterInput_TeYZprWSsFsNNwnnc5FBn0(this)
                {__p_HnAwHXKU1KoPoadYNaImxR = Output_1, __loop_MoRAg3sEErRNM0ueKBKgc4 = manager_13, __cp_IQZS3y1Sy2vMQLHarkRUHk = output_16} : that_18;
            else
            {
                this.__p_HnAwHXKU1KoPoadYNaImxR = Output_1;
                this.__loop_MoRAg3sEErRNM0ueKBKgc4 = manager_13;
                this.__cp_IQZS3y1Sy2vMQLHarkRUHk = output_16;
            }

            return that_18;
        }

        public n3.TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Default_0 = n25._Operations_.CreateDefault_H<n19.KeyNotification>();
            n3.TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 that_1 = this;
            this.__cp_IQZS3y1Sy2vMQLHarkRUHk = n13._Operations_.CreateDefault<n5.Spread<n3.ControlData_R>>();
            this.__p_HnAwHXKU1KoPoadYNaImxR = Default_0;
            this.__loop_MoRAg3sEErRNM0ueKBKgc4 = default(n26.ImmutableLifetimeManager);
            return that_1;
        }

        public n3.TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 __CreateDefault__()
        {
            n3.TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 that_0 = this;
            this.__cp_IQZS3y1Sy2vMQLHarkRUHk = n13._Operations_.CreateDefault<n5.Spread<n3.ControlData_R>>();
            this.__p_HnAwHXKU1KoPoadYNaImxR = n25._Operations_.CreateDefault_H<n19.KeyNotification>();
            this.__loop_MoRAg3sEErRNM0ueKBKgc4 = default(n26.ImmutableLifetimeManager);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_HnAwHXKU1KoPoadYNaImxR);
            n1.CompilationHelper.SafeDispose(this.__loop_MoRAg3sEErRNM0ueKBKgc4);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 232894U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "HnAwHXKU1KoPoadYNaImxR", Name = "Sampler", IsManaged = true, IsAutoGenerated = true)]
        public n24.Sampler<n19.KeyNotification> __p_HnAwHXKU1KoPoadYNaImxR;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n26.ImmutableLifetimeManager __loop_MoRAg3sEErRNM0ueKBKgc4;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<n5.Spread<n3.ControlData_R>> __cp_IQZS3y1Sy2vMQLHarkRUHk;
        public TypewriterInput_TeYZprWSsFsNNwnnc5FBn0(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TypewriterInput_TeYZprWSsFsNNwnnc5FBn0(TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 other): base(other)
        {
            this.__p_HnAwHXKU1KoPoadYNaImxR = other.__p_HnAwHXKU1KoPoadYNaImxR;
            this.__loop_MoRAg3sEErRNM0ueKBKgc4 = other.__loop_MoRAg3sEErRNM0ueKBKgc4;
            this.__cp_IQZS3y1Sy2vMQLHarkRUHk = other.__cp_IQZS3y1Sy2vMQLHarkRUHk;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HnAwHXKU1KoPoadYNaImxR", in __p_HnAwHXKU1KoPoadYNaImxR), n1.CompilationHelper.GetValueOrExisting(values, "__loop_MoRAg3sEErRNM0ueKBKgc4", in __loop_MoRAg3sEErRNM0ueKBKgc4), n1.CompilationHelper.GetValueOrExisting(values, "__cp_IQZS3y1Sy2vMQLHarkRUHk", in __cp_IQZS3y1Sy2vMQLHarkRUHk));
        }

        internal TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 __WITH__(n24.Sampler<n19.KeyNotification> __p_HnAwHXKU1KoPoadYNaImxR, n26.ImmutableLifetimeManager __loop_MoRAg3sEErRNM0ueKBKgc4, n5.Spread<n5.Spread<n3.ControlData_R>> __cp_IQZS3y1Sy2vMQLHarkRUHk)
        {
            n3.TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_HnAwHXKU1KoPoadYNaImxR != this.__p_HnAwHXKU1KoPoadYNaImxR || __loop_MoRAg3sEErRNM0ueKBKgc4 != this.__loop_MoRAg3sEErRNM0ueKBKgc4 || __cp_IQZS3y1Sy2vMQLHarkRUHk != this.__cp_IQZS3y1Sy2vMQLHarkRUHk ? new TypewriterInput_TeYZprWSsFsNNwnnc5FBn0(this)
                {__p_HnAwHXKU1KoPoadYNaImxR = __p_HnAwHXKU1KoPoadYNaImxR, __loop_MoRAg3sEErRNM0ueKBKgc4 = __loop_MoRAg3sEErRNM0ueKBKgc4, __cp_IQZS3y1Sy2vMQLHarkRUHk = __cp_IQZS3y1Sy2vMQLHarkRUHk} : that_0;
            else
            {
                this.__p_HnAwHXKU1KoPoadYNaImxR = __p_HnAwHXKU1KoPoadYNaImxR;
                this.__loop_MoRAg3sEErRNM0ueKBKgc4 = __loop_MoRAg3sEErRNM0ueKBKgc4;
                this.__cp_IQZS3y1Sy2vMQLHarkRUHk = __cp_IQZS3y1Sy2vMQLHarkRUHk;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "SQ2BMvjbnf2Nzl0pMtfAkr", Name = "__SQ2BMvjbnf2Nzl0pMtfAkr")]
        [n2.SerializableAttribute]
        public class __SQ2BMvjbnf2Nzl0pMtfAkr : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UlTItgp6JAkOs5DPWW9PgC);
                return;
            }

            [n1.ElementAttribute(TracingId = 232908U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "UlTItgp6JAkOs5DPWW9PgC", Name = "Controls", IsManaged = true, IsAutoGenerated = true)]
            public n3.Controls_BqQrMv16JtaMvZEPs5NWoK __p_UlTItgp6JAkOs5DPWW9PgC;
            public __SQ2BMvjbnf2Nzl0pMtfAkr(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SQ2BMvjbnf2Nzl0pMtfAkr(__SQ2BMvjbnf2Nzl0pMtfAkr other): base(other)
            {
                this.__p_UlTItgp6JAkOs5DPWW9PgC = other.__p_UlTItgp6JAkOs5DPWW9PgC;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UlTItgp6JAkOs5DPWW9PgC", in __p_UlTItgp6JAkOs5DPWW9PgC));
            }

            internal __SQ2BMvjbnf2Nzl0pMtfAkr __WITH__(n3.Controls_BqQrMv16JtaMvZEPs5NWoK __p_UlTItgp6JAkOs5DPWW9PgC)
            {
                __SQ2BMvjbnf2Nzl0pMtfAkr that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_UlTItgp6JAkOs5DPWW9PgC != this.__p_UlTItgp6JAkOs5DPWW9PgC ? new __SQ2BMvjbnf2Nzl0pMtfAkr(this)
                    {__p_UlTItgp6JAkOs5DPWW9PgC = __p_UlTItgp6JAkOs5DPWW9PgC} : that_0;
                else
                {
                    this.__p_UlTItgp6JAkOs5DPWW9PgC = __p_UlTItgp6JAkOs5DPWW9PgC;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Typewriter_.Text.TextBuilder.Advanced
{
    [n1.ElementAttribute(TracingId = 229847U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "PU8PxHSX06dLYExBYFrAii", Name = "Selection_R")]
    [n2.SerializableAttribute]
    public class Selection_R<T> : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n9.Selection_R<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n28.IAdaptiveCreateDefault<T>
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new Selection_R<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n9.Selection_R<T> CreateDefault<AdM>()
            where AdM : struct, n28.IAdaptiveCreateDefault<T>
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n9.Selection_R<T> __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new Selection_R<T>(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__<AdM>();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n9.Selection_R<T> __DEFAULT__;
        public n9.Selection_R<T> Split<AdM>(out int Line_From_Out, out int Line_Count_Out, out int Line_To_Out, out T Position_From_Out, out T Position_To_Out, out string Text_Out)
            where AdM : struct, n29.IAdaptiveOperatorLess<T>
        {
            var w_0 = default(AdM);
            int __auto_1 = this.Line_To;
            int __auto_2 = this.Line_From;
            T __auto_3 = this.Position_To;
            T __auto_4 = this.Position_From;
            string __auto_5 = this.Text;
            var Result_6 = __auto_1 < __auto_2;
            int __auto_7;
            int __auto_8;
            if (Result_6)
            {
                __auto_7 = __auto_1;
                __auto_8 = __auto_2;
            }
            else
            {
                __auto_7 = __auto_2;
                __auto_8 = __auto_1;
            }

            var Output_10 = __auto_8 - __auto_7;
            var Result_11 = __auto_2 == __auto_1;
            w_0.OperatorLess(Input_In: __auto_3, Input_2_In: __auto_4, Result_Out: out bool Result_12);
            var Output_13 = Result_11 && Result_12;
            var Output_14 = Result_6 || Output_13;
            T __auto_15;
            T __auto_16;
            if (Output_14)
            {
                __auto_15 = __auto_3;
                __auto_16 = __auto_4;
            }
            else
            {
                __auto_15 = __auto_4;
                __auto_16 = __auto_3;
            }

            var Output_18 = n7.Integer32Extensions.Inc(input: Output_10);
            Line_From_Out = __auto_7;
            Line_Count_Out = Output_18;
            Line_To_Out = __auto_8;
            Position_From_Out = __auto_15;
            Position_To_Out = __auto_16;
            Text_Out = __auto_5;
            return this;
        }

        public n9.Selection_R<T> To(int Line_To_In, T Position_To_In)
        {
            int __auto_0 = Line_To_In;
            T __auto_1 = Position_To_In;
            n9.Selection_R<T> that_2 = this;
            that_2 = Line_To_In != this.Line_To || !n8.EqualityComparer<T>.Default.Equals(Position_To_In, this.Position_To) ? new Selection_R<T>(this)
            {Line_To = Line_To_In, Position_To = Position_To_In} : that_2;
            return that_2;
        }

        public n9.Selection_R<T> Start(int Line_From_In, int Line_To_In, T Position_From_In, T Position_To_In)
        {
            bool __pad_BRGpAdeVCI0N5L4ggL2XlB_0 = __slot_BRGpAdeVCI0N5L4ggL2XlB;
            int __auto_1 = Line_From_In;
            int __auto_2 = Line_To_In;
            T __auto_3 = Position_From_In;
            T __auto_4 = Position_To_In;
            bool __auto_5 = __pad_BRGpAdeVCI0N5L4ggL2XlB_0;
            n9.Selection_R<T> that_6 = this;
            that_6 = Line_From_In != this.Line_From || Line_To_In != this.Line_To || !n8.EqualityComparer<T>.Default.Equals(Position_From_In, this.Position_From) || !n8.EqualityComparer<T>.Default.Equals(Position_To_In, this.Position_To) || __pad_BRGpAdeVCI0N5L4ggL2XlB_0 != this.Started ? new Selection_R<T>(this)
            {Line_From = Line_From_In, Line_To = Line_To_In, Position_From = Position_From_In, Position_To = Position_To_In, Started = __pad_BRGpAdeVCI0N5L4ggL2XlB_0} : that_6;
            return that_6;
        }

        public n9.Selection_R<T> IsStarted(out bool Output_Out)
        {
            bool __auto_0 = this.Started;
            Output_Out = __auto_0;
            return this;
        }

        public n9.Selection_R<T> IsEmpty<AdM>(out bool Output_Out)
            where AdM : struct, n29.IAdaptiveOperatorEquals<T>, n28.IAdaptiveCreateDefault<T>, n29.IAdaptiveOperatorMinus<T>
        {
            var w_0 = default(AdM);
            int __auto_1 = this.Line_To;
            int __auto_2 = this.Line_From;
            T __auto_3 = this.Position_To;
            T __auto_4 = this.Position_From;
            var Output_5 = __auto_1 - __auto_2;
            int Input_2_6 = 0;
            var Result_7 = Output_5 == Input_2_6;
            w_0.OperatorMinus(Input_In: __auto_3, Input_2_In: __auto_4, Output_Out: out T Output_8);
            w_0.CreateDefault(Output_Out: out T Output_9);
            w_0.OperatorEquals(Input_In: Output_8, Input_2_In: Output_9, Result_Out: out bool Result_10);
            var Output_11 = Result_7 && Result_10;
            Output_Out = Output_11;
            return this;
        }

        public n9.Selection_R<T> SetText(string Text_In)
        {
            string __auto_0 = Text_In;
            n9.Selection_R<T> that_1 = this;
            that_1 = Text_In != this.Text ? new Selection_R<T>(this)
            {Text = Text_In} : that_1;
            return that_1;
        }

        public n9.Selection_R<T> GetText(out string Text_Out)
        {
            string __auto_0 = this.Text;
            Text_Out = __auto_0;
            return this;
        }

        public n9.Selection_R<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n28.IAdaptiveCreateDefault<T>
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_0);
            w_0.CreateDefault(out T __out_1);
            bool __pad_Iw6DkHTU2BFPiOhPQcSNFj_1 = __slot_Iw6DkHTU2BFPiOhPQcSNFj;
            bool __auto_2 = __pad_Iw6DkHTU2BFPiOhPQcSNFj_1;
            n9.Selection_R<T> that_3 = this;
            this.Line_From = 0;
            this.Line_To = 0;
            this.Position_To = __out_0;
            this.Position_From = __out_1;
            this.Started = __pad_Iw6DkHTU2BFPiOhPQcSNFj_1;
            this.Text = "";
            return that_3;
        }

        public n9.Selection_R<T> __CreateDefault__<AdM>()
            where AdM : struct, n28.IAdaptiveCreateDefault<T>
        {
            var w_0 = default(AdM);
            w_0.CreateDefault(out T __out_2);
            w_0.CreateDefault(out T __out_3);
            n9.Selection_R<T> that_1 = this;
            this.Line_From = 0;
            this.Line_To = 0;
            this.Position_To = __out_2;
            this.Position_From = __out_3;
            this.Started = false;
            this.Text = "";
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

        [n1.ElementAttribute(TracingId = 229901U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Iw6DkHTU2BFPiOhPQcSNFj", Name = "__slot_Iw6DkHTU2BFPiOhPQcSNFj")]
        public static bool __slot_Iw6DkHTU2BFPiOhPQcSNFj = false;
        [n1.ElementAttribute(TracingId = 229902U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "BRGpAdeVCI0N5L4ggL2XlB", Name = "__slot_BRGpAdeVCI0N5L4ggL2XlB")]
        public static bool __slot_BRGpAdeVCI0N5L4ggL2XlB = true;
        [n1.ElementAttribute(TracingId = 229851U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "V4sZxn4fYGGL0KgwXxargD", Name = "Line From")]
        public int Line_From;
        [n1.ElementAttribute(TracingId = 229853U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "U3LrKHG1URBNahB7zHAALg", Name = "Line To")]
        public int Line_To;
        [n1.ElementAttribute(TracingId = 229857U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "IgaOFJ9v45iNFlXa7mpXIj", Name = "Position To")]
        public T Position_To;
        [n1.ElementAttribute(TracingId = 229855U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Hbsz6fyiqixOH4QseyHzEH", Name = "Position From")]
        public T Position_From;
        [n1.ElementAttribute(TracingId = 229900U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Ufy5wYOa788NEd0TGL47Fa", Name = "Started")]
        public bool Started;
        [n1.ElementAttribute(TracingId = 229947U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "G5TGYKgRDpXMbNrEjXKkTE", Name = "Text")]
        public string Text;
        static Selection_R()
        {
        }

        public Selection_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Selection_R(Selection_R<T> other): base(other)
        {
            this.Line_From = other.Line_From;
            this.Line_To = other.Line_To;
            this.Position_To = other.Position_To;
            this.Position_From = other.Position_From;
            this.Started = other.Started;
            this.Text = other.Text;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Line_From", in Line_From), n1.CompilationHelper.GetValueOrExisting(values, "Line_To", in Line_To), n1.CompilationHelper.GetValueOrExisting(values, "Position_To", in Position_To), n1.CompilationHelper.GetValueOrExisting(values, "Position_From", in Position_From), n1.CompilationHelper.GetValueOrExisting(values, "Started", in Started), n1.CompilationHelper.GetValueOrExisting(values, "Text", in Text));
        }

        internal Selection_R<T> __WITH__(int Line_From, int Line_To, T Position_To, T Position_From, bool Started, string Text)
        {
            n9.Selection_R<T> that_0 = this;
            that_0 = Line_From != this.Line_From || Line_To != this.Line_To || !n8.EqualityComparer<T>.Default.Equals(Position_To, this.Position_To) || !n8.EqualityComparer<T>.Default.Equals(Position_From, this.Position_From) || Started != this.Started || Text != this.Text ? new Selection_R<T>(this)
            {Line_From = Line_From, Line_To = Line_To, Position_To = Position_To, Position_From = Position_From, Started = Started, Text = Text} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 230186U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "MAdKROpcMMCMUeZTTqHRN4", Name = "RemoveSelected_MAdKROpcMMCMUeZTTqHRN4")]
    [n2.SerializableAttribute]
    public class RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n9.RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 Create(n1.NodeContext Node_Context)
        {
            var instance = new RemoveSelected_MAdKROpcMMCMUeZTTqHRN4(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n9.RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 CreateDefault()
        {
            var instance = new RemoveSelected_MAdKROpcMMCMUeZTTqHRN4(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n9.RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 Update(n5.SpreadBuilder<n5.SpreadBuilder<string>> Text_In, n9.Selection_R<int> Selection_In, out n5.SpreadBuilder<n5.SpreadBuilder<string>> Text_Out, out int Line_Out, out int Cursor_Out)
        {
            int __pad_EgN8ljSsSehPDXckwyCXR7_0 = __slot_EgN8ljSsSehPDXckwyCXR7;
            var State_Output_2 = this.__p_OA8QXsKkIJ9P0EMtbIY0Wy.Update<string>(Text_In: Text_In, Selection_In: Selection_In, Output_Out: out n5.Spread<n16.SelectedPosition_R> Output_1);
            var Output_9 = Selection_In.Split<n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Line_From_Out: out int Line_From_3, Line_Count_Out: out int Line_Count_4, Line_To_Out: out int Line_To_5, Position_From_Out: out int Position_From_6, Position_To_Out: out int Position_To_7, Text_Out: out string Text_8);
            var Result_10 = Line_Count_4 > __pad_EgN8ljSsSehPDXckwyCXR7_0;
            n5.SpreadBuilder<n5.SpreadBuilder<string>> accumulator_12 = Text_In;
            n5.SpreadBuilder<int> accumulator_13 = n6._Operations_.CreateDefault<int>();
            var i_15 = 0;
            foreach (var item_11 in n4.CollectionExtensions.AsSpan(Output_1))
            {
                var splicer_14 = item_11;
                var i_local_16 = i_15;
                var Output_21 = splicer_14.Split(Line_Out: out int Line_18, Position_From_Out: out int Position_From_19, Position_Count_Out: out int Position_Count_20);
                n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: accumulator_12, Index_In: Line_18, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_22, Item_Out: out n5.SpreadBuilder<string> Item_23);
                n6._Operations_.RemoveRange<string>(Input_In: Item_23, Index_In: Position_From_19, Count_In: Position_Count_20, Output_Out: out n5.SpreadBuilder<string> Output_24);
                n8.IEnumerable<string> Input_25 = (n8.IEnumerable<string>)Output_24;
                n12._Operations_.IsEmpty<string>(Input_In: Input_25, Result_Out: out bool Result_26);
                var Result_27 = Line_18 != Line_From_3;
                var Output_28 = Result_26 && Result_27;
                var Output_29 = accumulator_13;
                if (Output_28)
                {
                    n6._Operations_.Add<int>(Input_In: accumulator_13, Item_In: Line_18, Output_Out: out Output_29);
                }

                accumulator_12 = Output_22;
                accumulator_13 = Output_29;
                i_15++;
            }

            n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_30;
            if (Result_10)
            {
                n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: accumulator_12, Index_In: Line_To_5, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_32, Item_Out: out n5.SpreadBuilder<string> Item_33);
                n8.IEnumerable<string> Input_34 = (n8.IEnumerable<string>)Item_33;
                n12._Operations_.Any<string>(Input_In: Input_34, Result_Out: out bool Result_35);
                n8.IEnumerable<string> Items_36 = (n8.IEnumerable<string>)Item_33;
                n5.SpreadBuilder<n5.SpreadBuilder<string>> __auto_37;
                if (Result_35)
                {
                    n6._Operations_.GetItem<n5.SpreadBuilder<string>>(Input_In: Output_32, Index_In: Line_From_3, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_39, Item_Out: out n5.SpreadBuilder<string> Item_40);
                    n6._Operations_.AddRange<string>(Input_In: Item_40, Items_In: Items_36, Output_Out: out n5.SpreadBuilder<string> Output_41);
                    n6._Operations_.RemoveAt<n5.SpreadBuilder<string>>(Input_In: Output_39, Index_In: Line_To_5, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_42);
                    __auto_37 = Output_42;
                }
                else
                {
                    __auto_37 = Output_32;
                }

                __auto_30 = __auto_37;
            }
            else
            {
                __auto_30 = accumulator_12;
            }

            n5.SpreadBuilder<n5.SpreadBuilder<string>> accumulator_44 = __auto_30;
            var i_46 = 0;
            foreach (var item_43 in accumulator_13)
            {
                var splicer_45 = item_43;
                var i_local_47 = i_46;
                var Output_49 = splicer_45 - i_local_47;
                n6._Operations_.RemoveAt<n5.SpreadBuilder<string>>(Input_In: accumulator_44, Index_In: Output_49, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Output_50);
                accumulator_44 = Output_50;
                i_46++;
            }

            Text_Out = accumulator_44;
            Line_Out = Line_From_3;
            Cursor_Out = Position_From_6;
            n9.RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 that_51 = this;
            if (this.__GetContext__().IsImmutable)
                that_51 = State_Output_2 != this.__p_OA8QXsKkIJ9P0EMtbIY0Wy ? new RemoveSelected_MAdKROpcMMCMUeZTTqHRN4(this)
                {__p_OA8QXsKkIJ9P0EMtbIY0Wy = State_Output_2} : that_51;
            else
            {
                this.__p_OA8QXsKkIJ9P0EMtbIY0Wy = State_Output_2;
            }

            return that_51;
        }

        public n9.RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "OA8QXsKkIJ9P0EMtbIY0Wy", 230193U);
            var Output_1 = n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6.Create(Node_Context: Node_Context_0);
            n9.RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 that_2 = this;
            this.__p_OA8QXsKkIJ9P0EMtbIY0Wy = Output_1;
            return that_2;
        }

        public n9.RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 __CreateDefault__()
        {
            n9.RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 that_0 = this;
            this.__p_OA8QXsKkIJ9P0EMtbIY0Wy = n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_OA8QXsKkIJ9P0EMtbIY0Wy);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 230288U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "EgN8ljSsSehPDXckwyCXR7", Name = "__slot_EgN8ljSsSehPDXckwyCXR7")]
        public static int __slot_EgN8ljSsSehPDXckwyCXR7 = 1;
        [n1.ElementAttribute(TracingId = 230193U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "OA8QXsKkIJ9P0EMtbIY0Wy", Name = "ToSelectedPositions", IsManaged = true, IsAutoGenerated = true)]
        public n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 __p_OA8QXsKkIJ9P0EMtbIY0Wy;
        static RemoveSelected_MAdKROpcMMCMUeZTTqHRN4()
        {
        }

        public RemoveSelected_MAdKROpcMMCMUeZTTqHRN4(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RemoveSelected_MAdKROpcMMCMUeZTTqHRN4(RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 other): base(other)
        {
            this.__p_OA8QXsKkIJ9P0EMtbIY0Wy = other.__p_OA8QXsKkIJ9P0EMtbIY0Wy;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_OA8QXsKkIJ9P0EMtbIY0Wy", in __p_OA8QXsKkIJ9P0EMtbIY0Wy));
        }

        internal RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 __WITH__(n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 __p_OA8QXsKkIJ9P0EMtbIY0Wy)
        {
            n9.RemoveSelected_MAdKROpcMMCMUeZTTqHRN4 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_OA8QXsKkIJ9P0EMtbIY0Wy != this.__p_OA8QXsKkIJ9P0EMtbIY0Wy ? new RemoveSelected_MAdKROpcMMCMUeZTTqHRN4(this)
                {__p_OA8QXsKkIJ9P0EMtbIY0Wy = __p_OA8QXsKkIJ9P0EMtbIY0Wy} : that_0;
            else
            {
                this.__p_OA8QXsKkIJ9P0EMtbIY0Wy = __p_OA8QXsKkIJ9P0EMtbIY0Wy;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 230378U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "JgRboguKCyYPJs9wQyayn6", Name = "ToSelectedPositions_JgRboguKCyYPJs9wQyayn6")]
    [n2.SerializableAttribute]
    public class ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 Create(n1.NodeContext Node_Context)
        {
            var instance = new ToSelectedPositions_JgRboguKCyYPJs9wQyayn6(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 CreateDefault()
        {
            var instance = new ToSelectedPositions_JgRboguKCyYPJs9wQyayn6(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 Update<T>(n5.SpreadBuilder<n5.SpreadBuilder<T>> Text_In, n9.Selection_R<int> Selection_In, out n5.Spread<n16.SelectedPosition_R> Output_Out)
        {
            var Output_6 = Selection_In.Split<n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Line_From_Out: out int Line_From_0, Line_Count_Out: out int Line_Count_1, Line_To_Out: out int Line_To_2, Position_From_Out: out int Position_From_3, Position_To_Out: out int Position_To_4, Text_Out: out string Text_5);
            var State_Output_8 = this.__p_Qg7jJ90qAVlOkoqTGcPFWm.Update(Start_In: Line_From_0, Count_In: Line_Count_1, Output_Out: out n5.Spread<int> Output_7);
            var builder_30 = n4.CollectionBuilders.GetBuilder(this.__cp_DwrEaiyXzDdNMpYJulMpfS, 16);
            n5.Spread<n16.SelectedPosition_R> output_31;
            try
            {
                var i_11 = 0;
                foreach (var item_9 in n4.CollectionExtensions.AsSpan(Output_7))
                {
                    var splicer_10 = item_9;
                    var i_local_12 = i_11;
                    var Result_14 = Line_From_0 == splicer_10;
                    n6._Operations_.GetItem<n5.SpreadBuilder<T>>(Input_In: Text_In, Index_In: splicer_10, Output_Out: out n5.SpreadBuilder<n5.SpreadBuilder<T>> Output_15, Item_Out: out n5.SpreadBuilder<T> Item_16);
                    n6._Operations_.Count<T>(Input_In: Item_16, Output_Out: out n5.SpreadBuilder<T> Output_17, Count_Out: out int Count_18);
                    var Output_19 = Count_18 - Position_From_3;
                    n14._Operations_.Switch_Boolean<int>(Condition_In: Result_14, Input_In: Count_18, Input_2_In: Output_19, Output_Out: out int Output_20);
                    int Input_21 = 0;
                    n14._Operations_.Switch_Boolean<int>(Condition_In: Result_14, Input_In: Input_21, Input_2_In: Position_From_3, Output_Out: out int Output_22);
                    var Result_23 = Line_To_2 == splicer_10;
                    var Result_24 = Line_From_0 != Line_To_2;
                    var Output_25 = Position_To_4 - Position_From_3;
                    n14._Operations_.Switch_Boolean<int>(Condition_In: Result_24, Input_In: Output_25, Input_2_In: Position_To_4, Output_Out: out int Output_26);
                    n14._Operations_.Switch_Boolean<int>(Condition_In: Result_23, Input_In: Output_20, Input_2_In: Output_26, Output_Out: out int Output_27);
                    n1.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "FvtyR7pJxebNYRuB7oLg3N", 230461U);
                    var Output_29 = n16.SelectedPosition_R.Create(Node_Context: Node_Context_28, Line_In: splicer_10, Position_From_In: Output_22, Position_Count_In: Output_27);
                    builder_30.Add(Output_29);
                    i_11++;
                }
            }
            finally
            {
                output_31 = builder_30.Commit();
            }

            Output_Out = output_31;
            n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 that_32 = this;
            if (this.__GetContext__().IsImmutable)
                that_32 = State_Output_8 != this.__p_Qg7jJ90qAVlOkoqTGcPFWm || output_31 != this.__cp_DwrEaiyXzDdNMpYJulMpfS ? new ToSelectedPositions_JgRboguKCyYPJs9wQyayn6(this)
                {__p_Qg7jJ90qAVlOkoqTGcPFWm = State_Output_8, __cp_DwrEaiyXzDdNMpYJulMpfS = output_31} : that_32;
            else
            {
                this.__p_Qg7jJ90qAVlOkoqTGcPFWm = State_Output_8;
                this.__cp_DwrEaiyXzDdNMpYJulMpfS = output_31;
            }

            return that_32;
        }

        public n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "Qg7jJ90qAVlOkoqTGcPFWm", 230502U);
            var Output_1 = n13.I_Dedn0GP3agoLvHtKBtr1rt.Create(Node_Context: Node_Context_0);
            n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 that_2 = this;
            this.__cp_DwrEaiyXzDdNMpYJulMpfS = n13._Operations_.CreateDefault<n16.SelectedPosition_R>();
            this.__p_Qg7jJ90qAVlOkoqTGcPFWm = Output_1;
            return that_2;
        }

        public n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 __CreateDefault__()
        {
            n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 that_0 = this;
            this.__cp_DwrEaiyXzDdNMpYJulMpfS = n13._Operations_.CreateDefault<n16.SelectedPosition_R>();
            this.__p_Qg7jJ90qAVlOkoqTGcPFWm = n13.I_Dedn0GP3agoLvHtKBtr1rt.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Qg7jJ90qAVlOkoqTGcPFWm);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 230502U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Qg7jJ90qAVlOkoqTGcPFWm", Name = "I", IsManaged = true, IsAutoGenerated = true)]
        public n13.I_Dedn0GP3agoLvHtKBtr1rt __p_Qg7jJ90qAVlOkoqTGcPFWm;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<n16.SelectedPosition_R> __cp_DwrEaiyXzDdNMpYJulMpfS;
        public ToSelectedPositions_JgRboguKCyYPJs9wQyayn6(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ToSelectedPositions_JgRboguKCyYPJs9wQyayn6(ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 other): base(other)
        {
            this.__p_Qg7jJ90qAVlOkoqTGcPFWm = other.__p_Qg7jJ90qAVlOkoqTGcPFWm;
            this.__cp_DwrEaiyXzDdNMpYJulMpfS = other.__cp_DwrEaiyXzDdNMpYJulMpfS;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Qg7jJ90qAVlOkoqTGcPFWm", in __p_Qg7jJ90qAVlOkoqTGcPFWm), n1.CompilationHelper.GetValueOrExisting(values, "__cp_DwrEaiyXzDdNMpYJulMpfS", in __cp_DwrEaiyXzDdNMpYJulMpfS));
        }

        internal ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 __WITH__(n13.I_Dedn0GP3agoLvHtKBtr1rt __p_Qg7jJ90qAVlOkoqTGcPFWm, n5.Spread<n16.SelectedPosition_R> __cp_DwrEaiyXzDdNMpYJulMpfS)
        {
            n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Qg7jJ90qAVlOkoqTGcPFWm != this.__p_Qg7jJ90qAVlOkoqTGcPFWm || __cp_DwrEaiyXzDdNMpYJulMpfS != this.__cp_DwrEaiyXzDdNMpYJulMpfS ? new ToSelectedPositions_JgRboguKCyYPJs9wQyayn6(this)
                {__p_Qg7jJ90qAVlOkoqTGcPFWm = __p_Qg7jJ90qAVlOkoqTGcPFWm, __cp_DwrEaiyXzDdNMpYJulMpfS = __cp_DwrEaiyXzDdNMpYJulMpfS} : that_0;
            else
            {
                this.__p_Qg7jJ90qAVlOkoqTGcPFWm = __p_Qg7jJ90qAVlOkoqTGcPFWm;
                this.__cp_DwrEaiyXzDdNMpYJulMpfS = __cp_DwrEaiyXzDdNMpYJulMpfS;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 231135U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "ED6gc1ZFYhcPshOq9VwaBa", Name = "GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa")]
    [n2.SerializableAttribute]
    public class GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n9.GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa Create(n1.NodeContext Node_Context)
        {
            var instance = new GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n9.GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa CreateDefault()
        {
            var instance = new GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n9.GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa Update<T>(n5.Spread<string> Text_In, n5.SpreadBuilder<n5.SpreadBuilder<T>> Text_Raw_In, n9.Selection_R<int> Selection_In, out string Output_Out)
        {
            var State_Output_1 = Selection_In.IsEmpty<n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Output_Out: out bool Output_0);
            var Output_2 = !Output_0;
            string __auto_3;
            var state_4 = n1.CompilationHelper.Restore<__OIgfAp1HMGoN9poqA4sYp1>(this.__if_B3i0dMeic24NHGWX5Kpfxu, __GetContext__());
            if (Output_2)
            {
                if (state_4 == null)
                {
                    state_4 = new __OIgfAp1HMGoN9poqA4sYp1(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_PvDj1SEYDZzNmNW2aqT6WM = n13._Operations_.CreateDefault<string>()};
                    n1.NodeContext Node_Context_5 = __GetContext__().CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "NrIIHrpisf3OSxz4gc8ZYN", 231148U);
                    var Output_6 = n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6.Create(Node_Context: Node_Context_5);
                    state_4.__p_NrIIHrpisf3OSxz4gc8ZYN = Output_6;
                }

                var State_Output_8 = state_4.__p_NrIIHrpisf3OSxz4gc8ZYN.Update<T>(Text_In: Text_Raw_In, Selection_In: Selection_In, Output_Out: out n5.Spread<n16.SelectedPosition_R> Output_7);
                var builder_21 = n4.CollectionBuilders.GetBuilder(state_4.__cp_PvDj1SEYDZzNmNW2aqT6WM, 16);
                n5.Spread<string> output_22;
                try
                {
                    var i_11 = 0;
                    foreach (var item_9 in n4.CollectionExtensions.AsSpan(Output_7))
                    {
                        var splicer_10 = item_9;
                        var i_local_12 = i_11;
                        var Output_17 = splicer_10.Split(Line_Out: out int Line_14, Position_From_Out: out int Position_From_15, Position_Count_Out: out int Position_Count_16);
                        string Default_Value_18 = "";
                        n13._Operations_.GetSlice<string>(Input_In: Text_In, Default_Value_In: Default_Value_18, Index_In: Line_14, Result_Out: out string Result_19);
                        var Output_20 = Result_19.Substring(startIndex: Position_From_15, length: Position_Count_16);
                        builder_21.Add(Output_20);
                        i_11++;
                    }
                }
                finally
                {
                    output_22 = builder_21.Commit();
                }

                n8.IEnumerable<string> Values_23 = (n8.IEnumerable<string>)output_22;
                var New_Line_24 = n7.StringExtensions.NewLine;
                var Output_25 = string.Join(separator: New_Line_24, values: Values_23);
                __auto_3 = Output_25;
                if (state_4.__GetContext__().IsImmutable)
                    state_4 = State_Output_8 != state_4.__p_NrIIHrpisf3OSxz4gc8ZYN || output_22 != state_4.__cp_PvDj1SEYDZzNmNW2aqT6WM ? new __OIgfAp1HMGoN9poqA4sYp1(state_4)
                    {__p_NrIIHrpisf3OSxz4gc8ZYN = State_Output_8, __cp_PvDj1SEYDZzNmNW2aqT6WM = output_22} : state_4;
                else
                {
                    state_4.__p_NrIIHrpisf3OSxz4gc8ZYN = State_Output_8;
                    state_4.__cp_PvDj1SEYDZzNmNW2aqT6WM = output_22;
                }
            }
            else
            {
                __auto_3 = "";
            }

            Output_Out = __auto_3;
            n9.GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa that_26 = this;
            if (this.__GetContext__().IsImmutable)
                that_26 = state_4 != this.__if_B3i0dMeic24NHGWX5Kpfxu ? new GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa(this)
                {__if_B3i0dMeic24NHGWX5Kpfxu = state_4} : that_26;
            else
            {
                this.__if_B3i0dMeic24NHGWX5Kpfxu = state_4;
            }

            return that_26;
        }

        public n9.GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n9.GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa that_0 = this;
            this.__if_B3i0dMeic24NHGWX5Kpfxu = default(n2.Object);
            return that_0;
        }

        public n9.GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa __CreateDefault__()
        {
            n9.GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa that_0 = this;
            this.__if_B3i0dMeic24NHGWX5Kpfxu = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_B3i0dMeic24NHGWX5Kpfxu);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_B3i0dMeic24NHGWX5Kpfxu;
        public GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa(GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa other): base(other)
        {
            this.__if_B3i0dMeic24NHGWX5Kpfxu = other.__if_B3i0dMeic24NHGWX5Kpfxu;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_B3i0dMeic24NHGWX5Kpfxu", in __if_B3i0dMeic24NHGWX5Kpfxu));
        }

        internal GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa __WITH__(n2.Object __if_B3i0dMeic24NHGWX5Kpfxu)
        {
            n9.GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_B3i0dMeic24NHGWX5Kpfxu != this.__if_B3i0dMeic24NHGWX5Kpfxu ? new GetSelectedText_ED6gc1ZFYhcPshOq9VwaBa(this)
                {__if_B3i0dMeic24NHGWX5Kpfxu = __if_B3i0dMeic24NHGWX5Kpfxu} : that_0;
            else
            {
                this.__if_B3i0dMeic24NHGWX5Kpfxu = __if_B3i0dMeic24NHGWX5Kpfxu;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "OIgfAp1HMGoN9poqA4sYp1", Name = "__OIgfAp1HMGoN9poqA4sYp1")]
        [n2.SerializableAttribute]
        public class __OIgfAp1HMGoN9poqA4sYp1 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_NrIIHrpisf3OSxz4gc8ZYN);
                return;
            }

            [n1.ElementAttribute(TracingId = 231148U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "NrIIHrpisf3OSxz4gc8ZYN", Name = "ToSelectedPositions", IsManaged = true, IsAutoGenerated = true)]
            public n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 __p_NrIIHrpisf3OSxz4gc8ZYN;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<string> __cp_PvDj1SEYDZzNmNW2aqT6WM;
            public __OIgfAp1HMGoN9poqA4sYp1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __OIgfAp1HMGoN9poqA4sYp1(__OIgfAp1HMGoN9poqA4sYp1 other): base(other)
            {
                this.__p_NrIIHrpisf3OSxz4gc8ZYN = other.__p_NrIIHrpisf3OSxz4gc8ZYN;
                this.__cp_PvDj1SEYDZzNmNW2aqT6WM = other.__cp_PvDj1SEYDZzNmNW2aqT6WM;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NrIIHrpisf3OSxz4gc8ZYN", in __p_NrIIHrpisf3OSxz4gc8ZYN), n1.CompilationHelper.GetValueOrExisting(values, "__cp_PvDj1SEYDZzNmNW2aqT6WM", in __cp_PvDj1SEYDZzNmNW2aqT6WM));
            }

            internal __OIgfAp1HMGoN9poqA4sYp1 __WITH__(n9.ToSelectedPositions_JgRboguKCyYPJs9wQyayn6 __p_NrIIHrpisf3OSxz4gc8ZYN, n5.Spread<string> __cp_PvDj1SEYDZzNmNW2aqT6WM)
            {
                __OIgfAp1HMGoN9poqA4sYp1 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_NrIIHrpisf3OSxz4gc8ZYN != this.__p_NrIIHrpisf3OSxz4gc8ZYN || __cp_PvDj1SEYDZzNmNW2aqT6WM != this.__cp_PvDj1SEYDZzNmNW2aqT6WM ? new __OIgfAp1HMGoN9poqA4sYp1(this)
                    {__p_NrIIHrpisf3OSxz4gc8ZYN = __p_NrIIHrpisf3OSxz4gc8ZYN, __cp_PvDj1SEYDZzNmNW2aqT6WM = __cp_PvDj1SEYDZzNmNW2aqT6WM} : that_0;
                else
                {
                    this.__p_NrIIHrpisf3OSxz4gc8ZYN = __p_NrIIHrpisf3OSxz4gc8ZYN;
                    this.__cp_PvDj1SEYDZzNmNW2aqT6WM = __cp_PvDj1SEYDZzNmNW2aqT6WM;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Typewriter_.Text.TextBuilder.ToSelectedPositions.Advanced
{
    [n1.ElementAttribute(TracingId = 230381U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "P7BNoiYEsQZMW2RZ7BG0uc", Name = "SelectedPosition_R")]
    [n2.SerializableAttribute]
    public class SelectedPosition_R : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n16.SelectedPosition_R Create(n1.NodeContext Node_Context, int Line_In, int Position_From_In, int Position_Count_In)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new SelectedPosition_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Line_In, Position_From_In, Position_Count_In);
        }

        [n4.CreateDefaultAttribute]
        public static n16.SelectedPosition_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n16.SelectedPosition_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new SelectedPosition_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n16.SelectedPosition_R __DEFAULT__;
        public n16.SelectedPosition_R Split(out int Line_Out, out int Position_From_Out, out int Position_Count_Out)
        {
            int __auto_0 = this.Line;
            int __auto_1 = this.Position_From;
            int __auto_2 = this.Position_Count;
            Line_Out = __auto_0;
            Position_From_Out = __auto_1;
            Position_Count_Out = __auto_2;
            return this;
        }

        public n16.SelectedPosition_R __Create__(n1.NodeContext Node_Context, int Line_In, int Position_From_In, int Position_Count_In)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            int __auto_0 = Line_In;
            int __auto_1 = Position_From_In;
            int __auto_2 = Position_Count_In;
            n16.SelectedPosition_R that_3 = this;
            this.Line = Line_In;
            this.Position_From = Position_From_In;
            this.Position_Count = Position_Count_In;
            return that_3;
        }

        public n16.SelectedPosition_R __CreateDefault__()
        {
            n16.SelectedPosition_R that_0 = this;
            this.Line = 0;
            this.Position_From = 0;
            this.Position_Count = 0;
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

        [n1.ElementAttribute(TracingId = 230385U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "HUp7DjpeV3fMjAxY8dXLVe", Name = "Line")]
        public int Line;
        [n1.ElementAttribute(TracingId = 230387U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "SA54sU0dh9tPpI0VMuL43Q", Name = "Position From")]
        public int Position_From;
        [n1.ElementAttribute(TracingId = 230389U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "MPQQhyTNL7KLGVtXSay6LX", Name = "Position Count")]
        public int Position_Count;
        public SelectedPosition_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SelectedPosition_R(SelectedPosition_R other): base(other)
        {
            this.Line = other.Line;
            this.Position_From = other.Position_From;
            this.Position_Count = other.Position_Count;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Line", in Line), n1.CompilationHelper.GetValueOrExisting(values, "Position_From", in Position_From), n1.CompilationHelper.GetValueOrExisting(values, "Position_Count", in Position_Count));
        }

        internal SelectedPosition_R __WITH__(int Line, int Position_From, int Position_Count)
        {
            n16.SelectedPosition_R that_0 = this;
            that_0 = Line != this.Line || Position_From != this.Position_From || Position_Count != this.Position_Count ? new SelectedPosition_R(this)
            {Line = Line, Position_From = Position_From, Position_Count = Position_Count} : that_0;
            return that_0;
        }
    }
}

namespace _VL_Typewriter_.Text.Controls.Advanced
{
    [n1.ElementAttribute(TracingId = 228422U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void TransformText(string Input_In, n2.Func<char, char> Delegate_In, out string Result_Out)
        {
            n5.Spread<byte> __cp_EUaBgtbtn30QA365eYBW8l = n13._Operations_.CreateDefault<byte>();
            var builder_8 = n4.CollectionBuilders.GetBuilder(__cp_EUaBgtbtn30QA365eYBW8l, 16);
            n5.Spread<byte> output_9;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in Input_In)
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    byte __pad_IOWXWuIIRraNMsU5hpwxty_4 = __slot_IOWXWuIIRraNMsU5hpwxty;
                    n22._Operations_.Invoke<char, char>(Input_In: Delegate_In, Arg_In: splicer_1, Result_Out: out char Result_5);
                    var Result_6 = n7.IntegerConversions.ToByte(input: Result_5);
                    var Result_7 = Result_6 != __pad_IOWXWuIIRraNMsU5hpwxty_4;
                    if (Result_7)
                    {
                        builder_8.Add(Result_6);
                    }

                    i_2++;
                }
            }
            finally
            {
                output_9 = builder_8.Commit();
            }

            n8.IEnumerable<byte> Input_10 = (n8.IEnumerable<byte>)output_9;
            n31.Encodings Encoding_11 = n30._Operations_.CreateDefault();
            var Result_12 = n7.StringExtensions.FromBytes(input: Input_10, encoding: Encoding_11);
            Result_Out = Result_12;
            return;
        }

        [n1.ElementAttribute(TracingId = 232278U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "IOWXWuIIRraNMsU5hpwxty", Name = "__slot_IOWXWuIIRraNMsU5hpwxty")]
        public static byte __slot_IOWXWuIIRraNMsU5hpwxty = 0;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Typewriter_.Text
{
    [n1.ElementAttribute(TracingId = 232940U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "NUPCosTPNomM4zQ9iUdmPs", Name = "TypeWriter_NUPCosTPNomM4zQ9iUdmPs")]
    [n2.SerializableAttribute]
    public class TypeWriter_NUPCosTPNomM4zQ9iUdmPs : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n32.TypeWriter_NUPCosTPNomM4zQ9iUdmPs Create(n1.NodeContext Node_Context)
        {
            var instance = new TypeWriter_NUPCosTPNomM4zQ9iUdmPs(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n32.TypeWriter_NUPCosTPNomM4zQ9iUdmPs CreateDefault()
        {
            var instance = new TypeWriter_NUPCosTPNomM4zQ9iUdmPs(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n32.TypeWriter_NUPCosTPNomM4zQ9iUdmPs Update(n27.IKeyboard Input_Device_In, string Initial_Text_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Multiline_In, [n4.SerializedDefaultValueAttribute("-1", false)] int Max_Length_In, n2.Func<char, char> Char_Filter_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Enable_Char_Filter_In, bool Reset_In, out n3.TextBuilder_C State_Out, out string Text_Out, out int Length_Out, out int Position_Out, out int Cursor_Out, out int Line_Out, out string Selected_Text_Out, out n9.Selection_R<int> Selection_Out, out n5.SpreadBuilder<n5.SpreadBuilder<string>> Text_Raw_Out)
        {
            var State_Output_1 = this.__p_HoFsRRlNRcwLJ3t1Ypwm5w.Update(Input_In: Input_Device_In, Char_Filter_In: Char_Filter_In, Enable_Char_Filter_In: Enable_Char_Filter_In, Output_Out: out n5.Spread<n3.ControlData_R> Output_0);
            n8.IEnumerable<n3.ControlData_R> Controls_Data_2 = (n8.IEnumerable<n3.ControlData_R>)Output_0;
            var State_Output_4 = this.__p_AkDnxh4Si2gMcygFXpDo0D.Update(Simulate_In: Reset_In, Output_Out: out bool Output_3);
            var Output_6 = this.__p_Tlwc0jHyP8DMXDOdbMM2km.Update(Controls_Data_In: Controls_Data_2, Initial_Text_In: Initial_Text_In, Multiline_In: Multiline_In, Reset_In: Output_3, Max_Length_In: Max_Length_In, State_Out: out n3.TextBuilder_C State_5);
            var Output_15 = State_5.Split(Text_Out: out string Text_7, Length_Out: out int Length_8, Position_Out: out int Position_9, Cursor_Out: out int Cursor_10, Line_Out: out int Line_11, Selected_Text_Out: out string Selected_Text_12, Selection_Out: out n9.Selection_R<int> Selection_13, Text_Raw_Out: out n5.SpreadBuilder<n5.SpreadBuilder<string>> Text_Raw_14);
            State_Out = State_5;
            Text_Out = Text_7;
            Length_Out = Length_8;
            Position_Out = Position_9;
            Cursor_Out = Cursor_10;
            Line_Out = Line_11;
            Selected_Text_Out = Selected_Text_12;
            Selection_Out = Selection_13;
            Text_Raw_Out = Text_Raw_14;
            n32.TypeWriter_NUPCosTPNomM4zQ9iUdmPs that_16 = this;
            if (this.__GetContext__().IsImmutable)
                that_16 = State_Output_1 != this.__p_HoFsRRlNRcwLJ3t1Ypwm5w || State_Output_4 != this.__p_AkDnxh4Si2gMcygFXpDo0D || Output_6 != this.__p_Tlwc0jHyP8DMXDOdbMM2km ? new TypeWriter_NUPCosTPNomM4zQ9iUdmPs(this)
                {__p_HoFsRRlNRcwLJ3t1Ypwm5w = State_Output_1, __p_AkDnxh4Si2gMcygFXpDo0D = State_Output_4, __p_Tlwc0jHyP8DMXDOdbMM2km = Output_6} : that_16;
            else
            {
                this.__p_HoFsRRlNRcwLJ3t1Ypwm5w = State_Output_1;
                this.__p_AkDnxh4Si2gMcygFXpDo0D = State_Output_4;
                this.__p_Tlwc0jHyP8DMXDOdbMM2km = Output_6;
            }

            return that_16;
        }

        public n32.TypeWriter_NUPCosTPNomM4zQ9iUdmPs __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "Tlwc0jHyP8DMXDOdbMM2km", 232950U);
            var Output_1 = n33.TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "HoFsRRlNRcwLJ3t1Ypwm5w", 232959U);
            var Output_3 = n3.TypewriterInput_TeYZprWSsFsNNwnnc5FBn0.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "AkDnxh4Si2gMcygFXpDo0D", 232993U);
            var Output_5 = n34.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_4);
            n32.TypeWriter_NUPCosTPNomM4zQ9iUdmPs that_6 = this;
            this.__p_Tlwc0jHyP8DMXDOdbMM2km = Output_1;
            this.__p_HoFsRRlNRcwLJ3t1Ypwm5w = Output_3;
            this.__p_AkDnxh4Si2gMcygFXpDo0D = Output_5;
            return that_6;
        }

        public n32.TypeWriter_NUPCosTPNomM4zQ9iUdmPs __CreateDefault__()
        {
            n32.TypeWriter_NUPCosTPNomM4zQ9iUdmPs that_0 = this;
            this.__p_HoFsRRlNRcwLJ3t1Ypwm5w = n3.TypewriterInput_TeYZprWSsFsNNwnnc5FBn0.CreateDefault();
            this.__p_AkDnxh4Si2gMcygFXpDo0D = n34.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__p_Tlwc0jHyP8DMXDOdbMM2km = n33.TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_HoFsRRlNRcwLJ3t1Ypwm5w);
            n1.CompilationHelper.SafeDispose(this.__p_AkDnxh4Si2gMcygFXpDo0D);
            n1.CompilationHelper.SafeDispose(this.__p_Tlwc0jHyP8DMXDOdbMM2km);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 232959U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "HoFsRRlNRcwLJ3t1Ypwm5w", Name = "TypewriterInput", IsManaged = true, IsAutoGenerated = true)]
        public n3.TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 __p_HoFsRRlNRcwLJ3t1Ypwm5w;
        [n1.ElementAttribute(TracingId = 232993U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "AkDnxh4Si2gMcygFXpDo0D", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n34.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_AkDnxh4Si2gMcygFXpDo0D;
        [n1.ElementAttribute(TracingId = 232950U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Tlwc0jHyP8DMXDOdbMM2km", Name = "TypewriterProcess", IsManaged = true, IsAutoGenerated = true)]
        public n33.TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ __p_Tlwc0jHyP8DMXDOdbMM2km;
        public TypeWriter_NUPCosTPNomM4zQ9iUdmPs(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TypeWriter_NUPCosTPNomM4zQ9iUdmPs(TypeWriter_NUPCosTPNomM4zQ9iUdmPs other): base(other)
        {
            this.__p_HoFsRRlNRcwLJ3t1Ypwm5w = other.__p_HoFsRRlNRcwLJ3t1Ypwm5w;
            this.__p_AkDnxh4Si2gMcygFXpDo0D = other.__p_AkDnxh4Si2gMcygFXpDo0D;
            this.__p_Tlwc0jHyP8DMXDOdbMM2km = other.__p_Tlwc0jHyP8DMXDOdbMM2km;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HoFsRRlNRcwLJ3t1Ypwm5w", in __p_HoFsRRlNRcwLJ3t1Ypwm5w), n1.CompilationHelper.GetValueOrExisting(values, "__p_AkDnxh4Si2gMcygFXpDo0D", in __p_AkDnxh4Si2gMcygFXpDo0D), n1.CompilationHelper.GetValueOrExisting(values, "__p_Tlwc0jHyP8DMXDOdbMM2km", in __p_Tlwc0jHyP8DMXDOdbMM2km));
        }

        internal TypeWriter_NUPCosTPNomM4zQ9iUdmPs __WITH__(n3.TypewriterInput_TeYZprWSsFsNNwnnc5FBn0 __p_HoFsRRlNRcwLJ3t1Ypwm5w, n34.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_AkDnxh4Si2gMcygFXpDo0D, n33.TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ __p_Tlwc0jHyP8DMXDOdbMM2km)
        {
            n32.TypeWriter_NUPCosTPNomM4zQ9iUdmPs that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_HoFsRRlNRcwLJ3t1Ypwm5w != this.__p_HoFsRRlNRcwLJ3t1Ypwm5w || __p_AkDnxh4Si2gMcygFXpDo0D != this.__p_AkDnxh4Si2gMcygFXpDo0D || __p_Tlwc0jHyP8DMXDOdbMM2km != this.__p_Tlwc0jHyP8DMXDOdbMM2km ? new TypeWriter_NUPCosTPNomM4zQ9iUdmPs(this)
                {__p_HoFsRRlNRcwLJ3t1Ypwm5w = __p_HoFsRRlNRcwLJ3t1Ypwm5w, __p_AkDnxh4Si2gMcygFXpDo0D = __p_AkDnxh4Si2gMcygFXpDo0D, __p_Tlwc0jHyP8DMXDOdbMM2km = __p_Tlwc0jHyP8DMXDOdbMM2km} : that_0;
            else
            {
                this.__p_HoFsRRlNRcwLJ3t1Ypwm5w = __p_HoFsRRlNRcwLJ3t1Ypwm5w;
                this.__p_AkDnxh4Si2gMcygFXpDo0D = __p_AkDnxh4Si2gMcygFXpDo0D;
                this.__p_Tlwc0jHyP8DMXDOdbMM2km = __p_Tlwc0jHyP8DMXDOdbMM2km;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 234566U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "C5NWx13lVlRMSdwa07OS4Q", Name = "VL_TypewriterApplication_C5NWx13lVlRMSdwa07OS4Q")]
    [n2.SerializableAttribute]
    public class VL_TypewriterApplication_C5NWx13lVlRMSdwa07OS4Q : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n32.VL_TypewriterApplication_C5NWx13lVlRMSdwa07OS4Q Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_TypewriterApplication_C5NWx13lVlRMSdwa07OS4Q(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n32.VL_TypewriterApplication_C5NWx13lVlRMSdwa07OS4Q CreateDefault()
        {
            var instance = new VL_TypewriterApplication_C5NWx13lVlRMSdwa07OS4Q(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n32.VL_TypewriterApplication_C5NWx13lVlRMSdwa07OS4Q Update()
        {
            return this;
        }

        public n32.VL_TypewriterApplication_C5NWx13lVlRMSdwa07OS4Q __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n32.VL_TypewriterApplication_C5NWx13lVlRMSdwa07OS4Q __CreateDefault__()
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

        public VL_TypewriterApplication_C5NWx13lVlRMSdwa07OS4Q(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_TypewriterApplication_C5NWx13lVlRMSdwa07OS4Q(VL_TypewriterApplication_C5NWx13lVlRMSdwa07OS4Q other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_TypewriterApplication_C5NWx13lVlRMSdwa07OS4Q __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Typewriter_.Text.Internal
{
    [n1.ElementAttribute(TracingId = 233107U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "GYAqFQ9hd9EOTuTLaXCEBZ", Name = "TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ")]
    [n2.SerializableAttribute]
    public class TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n33.TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ Create(n1.NodeContext Node_Context)
        {
            var instance = new TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n33.TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ CreateDefault()
        {
            var instance = new TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n33.TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ Update(n8.IEnumerable<n3.ControlData_R> Controls_Data_In, string Initial_Text_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Multiline_In, bool Reset_In, [n4.SerializedDefaultValueAttribute("-1", false)] int Max_Length_In, out n3.TextBuilder_C State_Out)
        {
            n3.TextBuilder_C __auto_0 = this.State;
            n3.TextBuilder_C __auto_1;
            n8.IEnumerable<n3.ControlData_R> __auto_2;
            if (Reset_In)
            {
                n1.NodeContext Node_Context_4 = __GetContext__().CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "KmTGz3QxVfePmFQ8mI7SSP", 234062U);
                var Output_5 = n3.TextBuilder_C.Create(Node_Context: Node_Context_4, Initial_Text_In: Initial_Text_In);
                __auto_1 = Output_5;
                n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "UlL6lsfj1YOQQEQxywiGaW", 234074U);
                var Output_7 = n3.ControlData_R.Create(Node_Context: Node_Context_6);
                n12._Operations_.FromValue<n3.ControlData_R>(Input_In: Output_7, Result_Out: out n8.IEnumerable<n3.ControlData_R> Result_8);
                __auto_2 = Result_8;
            }
            else
            {
                __auto_1 = __auto_0;
                __auto_2 = Controls_Data_In;
            }

            var Output_11 = __auto_1.GetCursorAndLine(Cursor_Out: out int Cursor_9, Line_Out: out int Line_10);
            n3.TextBuilder_C accumulator_13 = Output_11;
            var manager_88 = this.__loop_N9E16rlzrRlP7mrB195Kvc ?? new n26.ImmutableLifetimeManager();
            var iterator_89 = manager_88.GetIterator(__GetContext__());
            try
            {
                var i_15 = 0;
                foreach (var item_12 in __auto_2)
                {
                    var splicer_14 = item_12;
                    var i_local_16 = i_15;
                    __OstY7TiCG4rO6QgNjFdLKv state_17;
                    if (!iterator_89.MoveNext(out state_17))
                    {
                        iterator_89.Add(state_17 = new __OstY7TiCG4rO6QgNjFdLKv(__GetContext__(), n1.VLObject.NewIdentity()));
                        n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "R8sEGlwxQC0OhfT6muSImf", 233224U);
                        var Output_19 = n33.SelectionCheck_SLztM1n9wIpM9Rs29VzPkd.Create(Node_Context: Node_Context_18);
                        state_17.__p_R8sEGlwxQC0OhfT6muSImf = Output_19;
                    }

                    bool __pad_Dv3oUOcJXZsP2GZGSE1pai_20 = __slot_Dv3oUOcJXZsP2GZGSE1pai;
                    var Output_30 = splicer_14.MoveCursor(Left_Out: out bool Left_21, Right_Out: out bool Right_22, Up_Out: out bool Up_23, IsMoved_Out: out bool IsMoved_24, Down_Out: out bool Down_25, Home_Out: out bool Home_26, End_Out: out bool End_27, PageUp_Out: out bool PageUp_28, PageDown_Out: out bool PageDown_29);
                    var Output_31 = accumulator_13;
                    if (IsMoved_24)
                    {
                        Output_31 = accumulator_13.MoveCursor(Left_In: Left_21, Right_In: Right_22, Up_In: Up_23, Down_In: Down_25, Home_In: Home_26, End_In: End_27, PageUp_In: PageUp_28, PageDown_In: PageDown_29);
                    }

                    var Output_35 = splicer_14.MoveCursorByWord(Left_Out: out bool Left_32, Right_Out: out bool Right_33, IsMoved_Out: out bool IsMoved_34);
                    var Output_36 = Output_31;
                    if (IsMoved_34)
                    {
                        Output_36 = Output_31.MoveCursorByWord(Left_In: Left_32, Right_In: Right_33);
                    }

                    var Output_40 = state_17.__p_R8sEGlwxQC0OhfT6muSImf.Update(Text_In: accumulator_13, Input_In: splicer_14, Erase_Char_Back_Out: out bool Erase_Char_Back_37, Erase_Char_Delete_Out: out bool Erase_Char_Delete_38, Erase_Selection_Out: out bool Erase_Selection_39);
                    var Output_41 = Output_36;
                    if (Erase_Char_Back_37)
                    {
                        Output_41 = Output_36.EraseByBack();
                    }

                    var Output_42 = Output_41;
                    if (Erase_Char_Delete_38)
                    {
                        Output_42 = Output_41.EraseByDelete();
                    }

                    var Output_46 = splicer_14.Selection(Select_All_Out: out bool Select_All_43, Reset_Selection_Out: out bool Reset_Selection_44, Selection_Moved_Out: out bool Selection_Moved_45);
                    var Output_47 = Output_42;
                    if (Selection_Moved_45)
                    {
                        Output_47 = Output_42.MoveSelection(Position_From_In: Cursor_9, Line_From_In: Line_10, Select_All_In: Select_All_43, Reset_In: Reset_Selection_44);
                    }

                    var Output_48 = Output_47;
                    if (Erase_Selection_39)
                    {
                        Output_48 = Output_47.EraseSelected();
                    }

                    var Output_52 = splicer_14.Clipboard(Copy_Out: out bool Copy_49, Paste_Out: out bool Paste_50, Text_to_Paste_Out: out string Text_to_Paste_51);
                    var Output_53 = Output_48;
                    if (Copy_49)
                    {
                        Output_53 = Output_48.Copy();
                    }

                    int Input_2_54 = 0;
                    var Result_55 = Max_Length_In >= Input_2_54;
                    int __auto_56;
                    bool __auto_57;
                    if (Result_55)
                    {
                        var Output_60 = accumulator_13.Length_(Length_Out: out int Length_59);
                        var Result_61 = Length_59 < Max_Length_In;
                        __auto_57 = Result_61;
                        __auto_56 = Length_59;
                    }
                    else
                    {
                        __auto_56 = 0;
                        __auto_57 = __pad_Dv3oUOcJXZsP2GZGSE1pai_20;
                    }

                    n3.TextBuilder_C __auto_62;
                    if (Paste_50)
                    {
                        string __auto_64;
                        if (Result_55)
                        {
                            var Length_66 = Text_to_Paste_51.Length;
                            var Output_67 = Max_Length_In - __auto_56;
                            int Input_2_68 = 0;
                            n11._Operations_.Max<int, n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Input_In: Output_67, Input_2_In: Input_2_68, Output_Out: out int Output_69);
                            var Result_70 = Length_66 > Output_69;
                            int Start_Index_71 = 0;
                            var Output_72 = Text_to_Paste_51;
                            if (Result_70)
                            {
                                var Output_73 = Text_to_Paste_51.Substring(startIndex: Start_Index_71, length: Output_69);
                                Output_72 = Output_73;
                            }

                            __auto_64 = Output_72;
                        }
                        else
                        {
                            __auto_64 = Text_to_Paste_51;
                        }

                        var Output_74 = Output_53;
                        if (Paste_50)
                        {
                            Output_74 = Output_53.Paste(Text_In: __auto_64);
                        }

                        __auto_62 = Output_74;
                    }
                    else
                    {
                        __auto_62 = Output_53;
                    }

                    n3.TextBuilder_C __auto_75;
                    if (__auto_57)
                    {
                        var Output_81 = splicer_14.Insert(Insert_Tab_Out: out bool Insert_Tab_77, Insert_NewLine_Out: out bool Insert_NewLine_78, Char_to_Insert_Out: out string Char_to_Insert_79, Insert_Char_Out: out bool Insert_Char_80);
                        var Output_82 = __auto_62;
                        if (Insert_Tab_77)
                        {
                            Output_82 = __auto_62.InserTab();
                        }

                        var Output_83 = Insert_NewLine_78 && Multiline_In;
                        var Output_84 = Output_82;
                        if (Output_83)
                        {
                            Output_84 = Output_82.InsertNewLine();
                        }

                        var Output_85 = Output_84;
                        if (Insert_Char_80)
                        {
                            Output_85 = Output_84.InsertChar(Item_In: Char_to_Insert_79);
                        }

                        __auto_75 = Output_85;
                    }
                    else
                    {
                        __auto_75 = __auto_62;
                    }

                    var Output_86 = __auto_75.Update();
                    bool __pad_NnvmCKcmTZeP6chNOPxpsV_87 = Selection_Moved_45;
                    if (state_17.__GetContext__().IsImmutable)
                        state_17 = Output_40 != state_17.__p_R8sEGlwxQC0OhfT6muSImf || Selection_Moved_45 != state_17.__slot_NnvmCKcmTZeP6chNOPxpsV ? new __OstY7TiCG4rO6QgNjFdLKv(state_17)
                        {__p_R8sEGlwxQC0OhfT6muSImf = Output_40, __slot_NnvmCKcmTZeP6chNOPxpsV = Selection_Moved_45} : state_17;
                    else
                    {
                        state_17.__p_R8sEGlwxQC0OhfT6muSImf = Output_40;
                        state_17.__slot_NnvmCKcmTZeP6chNOPxpsV = Selection_Moved_45;
                    }

                    iterator_89.Update(state_17);
                    accumulator_13 = Output_86;
                    i_15++;
                }
            }
            finally
            {
                manager_88 = iterator_89.Commit();
            }

            n3.TextBuilder_C __auto_90 = accumulator_13;
            State_Out = accumulator_13;
            n33.TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ that_91 = this;
            if (this.__GetContext__().IsImmutable)
                that_91 = manager_88 != this.__loop_N9E16rlzrRlP7mrB195Kvc || accumulator_13 != this.State ? new TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ(this)
                {__loop_N9E16rlzrRlP7mrB195Kvc = manager_88, State = accumulator_13} : that_91;
            else
            {
                this.__loop_N9E16rlzrRlP7mrB195Kvc = manager_88;
                this.State = accumulator_13;
            }

            return that_91;
        }

        public n33.TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n33.TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ that_0 = this;
            this.State = n3.TextBuilder_C.CreateDefault();
            this.__loop_N9E16rlzrRlP7mrB195Kvc = default(n26.ImmutableLifetimeManager);
            return that_0;
        }

        public n33.TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ __CreateDefault__()
        {
            n33.TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ that_0 = this;
            this.State = n3.TextBuilder_C.CreateDefault();
            this.__loop_N9E16rlzrRlP7mrB195Kvc = default(n26.ImmutableLifetimeManager);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__loop_N9E16rlzrRlP7mrB195Kvc);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 234094U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "ESI6LKEeaQ1Qai4nmFU4Td", Name = "State")]
        public n3.TextBuilder_C State;
        [n1.ElementAttribute(TracingId = 233493U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "Dv3oUOcJXZsP2GZGSE1pai", Name = "__slot_Dv3oUOcJXZsP2GZGSE1pai")]
        public static bool __slot_Dv3oUOcJXZsP2GZGSE1pai = true;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n26.ImmutableLifetimeManager __loop_N9E16rlzrRlP7mrB195Kvc;
        static TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ()
        {
        }

        public TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ(TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ other): base(other)
        {
            this.State = other.State;
            this.__loop_N9E16rlzrRlP7mrB195Kvc = other.__loop_N9E16rlzrRlP7mrB195Kvc;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "State", in State), n1.CompilationHelper.GetValueOrExisting(values, "__loop_N9E16rlzrRlP7mrB195Kvc", in __loop_N9E16rlzrRlP7mrB195Kvc));
        }

        internal TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ __WITH__(n3.TextBuilder_C State, n26.ImmutableLifetimeManager __loop_N9E16rlzrRlP7mrB195Kvc)
        {
            n33.TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = State != this.State || __loop_N9E16rlzrRlP7mrB195Kvc != this.__loop_N9E16rlzrRlP7mrB195Kvc ? new TypewriterProcess_GYAqFQ9hd9EOTuTLaXCEBZ(this)
                {State = State, __loop_N9E16rlzrRlP7mrB195Kvc = __loop_N9E16rlzrRlP7mrB195Kvc} : that_0;
            else
            {
                this.State = State;
                this.__loop_N9E16rlzrRlP7mrB195Kvc = __loop_N9E16rlzrRlP7mrB195Kvc;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "OstY7TiCG4rO6QgNjFdLKv", Name = "__OstY7TiCG4rO6QgNjFdLKv")]
        [n2.SerializableAttribute]
        public class __OstY7TiCG4rO6QgNjFdLKv : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_R8sEGlwxQC0OhfT6muSImf);
                return;
            }

            [n1.ElementAttribute(TracingId = 233224U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "R8sEGlwxQC0OhfT6muSImf", Name = "SelectionCheck", IsManaged = true, IsAutoGenerated = true)]
            public n33.SelectionCheck_SLztM1n9wIpM9Rs29VzPkd __p_R8sEGlwxQC0OhfT6muSImf;
            [n1.ElementAttribute(TracingId = 233297U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "NnvmCKcmTZeP6chNOPxpsV", Name = "__slot_NnvmCKcmTZeP6chNOPxpsV")]
            public bool __slot_NnvmCKcmTZeP6chNOPxpsV;
            public __OstY7TiCG4rO6QgNjFdLKv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __OstY7TiCG4rO6QgNjFdLKv(__OstY7TiCG4rO6QgNjFdLKv other): base(other)
            {
                this.__p_R8sEGlwxQC0OhfT6muSImf = other.__p_R8sEGlwxQC0OhfT6muSImf;
                this.__slot_NnvmCKcmTZeP6chNOPxpsV = other.__slot_NnvmCKcmTZeP6chNOPxpsV;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_R8sEGlwxQC0OhfT6muSImf", in __p_R8sEGlwxQC0OhfT6muSImf), n1.CompilationHelper.GetValueOrExisting(values, "__slot_NnvmCKcmTZeP6chNOPxpsV", in __slot_NnvmCKcmTZeP6chNOPxpsV));
            }

            internal __OstY7TiCG4rO6QgNjFdLKv __WITH__(n33.SelectionCheck_SLztM1n9wIpM9Rs29VzPkd __p_R8sEGlwxQC0OhfT6muSImf, bool __slot_NnvmCKcmTZeP6chNOPxpsV)
            {
                __OstY7TiCG4rO6QgNjFdLKv that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_R8sEGlwxQC0OhfT6muSImf != this.__p_R8sEGlwxQC0OhfT6muSImf || __slot_NnvmCKcmTZeP6chNOPxpsV != this.__slot_NnvmCKcmTZeP6chNOPxpsV ? new __OstY7TiCG4rO6QgNjFdLKv(this)
                    {__p_R8sEGlwxQC0OhfT6muSImf = __p_R8sEGlwxQC0OhfT6muSImf, __slot_NnvmCKcmTZeP6chNOPxpsV = __slot_NnvmCKcmTZeP6chNOPxpsV} : that_0;
                else
                {
                    this.__p_R8sEGlwxQC0OhfT6muSImf = __p_R8sEGlwxQC0OhfT6muSImf;
                    this.__slot_NnvmCKcmTZeP6chNOPxpsV = __slot_NnvmCKcmTZeP6chNOPxpsV;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 234296U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "SLztM1n9wIpM9Rs29VzPkd", Name = "SelectionCheck_SLztM1n9wIpM9Rs29VzPkd")]
    [n2.SerializableAttribute]
    public class SelectionCheck_SLztM1n9wIpM9Rs29VzPkd : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n33.SelectionCheck_SLztM1n9wIpM9Rs29VzPkd Create(n1.NodeContext Node_Context)
        {
            var instance = new SelectionCheck_SLztM1n9wIpM9Rs29VzPkd(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n33.SelectionCheck_SLztM1n9wIpM9Rs29VzPkd CreateDefault()
        {
            var instance = new SelectionCheck_SLztM1n9wIpM9Rs29VzPkd(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n33.SelectionCheck_SLztM1n9wIpM9Rs29VzPkd Update(n3.TextBuilder_C Text_In, n3.ControlData_R Input_In, out bool Erase_Char_Back_Out, out bool Erase_Char_Delete_Out, out bool Erase_Selection_Out)
        {
            var Output_1 = Text_In.GetSelection(Selection_Out: out n9.Selection_R<int> Selection_0);
            var State_Output_3 = Selection_0.IsEmpty<n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Output_Out: out bool Output_2);
            var Output_4 = !Output_2;
            var Output_8 = Input_In.Erase(Erase_Char_Back_Out: out bool Erase_Char_Back_5, Erase_Char_Delete_Out: out bool Erase_Char_Delete_6, Erase_Selection_Out: out bool Erase_Selection_7);
            var Output_9 = Erase_Char_Back_5 || Erase_Char_Delete_6;
            var Output_10 = Output_9 || Erase_Selection_7;
            var Output_15 = Input_In.Insert(Insert_Tab_Out: out bool Insert_Tab_11, Insert_NewLine_Out: out bool Insert_NewLine_12, Char_to_Insert_Out: out string Char_to_Insert_13, Insert_Char_Out: out bool Insert_Char_14);
            var Output_16 = Output_10 || Insert_Tab_11;
            var Output_17 = Output_16 || Insert_NewLine_12;
            var Output_18 = Output_17 || Insert_Char_14;
            var Output_19 = Output_4 && Output_18;
            var Output_20 = Output_2 && Erase_Char_Delete_6;
            var Output_21 = Output_2 && Erase_Char_Back_5;
            var Output_24 = this.__p_M2GqZFNgSW9PYCXLn8Vfjc.Update(Value_In: Output_19, Up_Edge_Out: out bool Up_Edge_22, Down_Edge_Out: out bool Down_Edge_23);
            Erase_Char_Back_Out = Output_21;
            Erase_Char_Delete_Out = Output_20;
            Erase_Selection_Out = Up_Edge_22;
            n33.SelectionCheck_SLztM1n9wIpM9Rs29VzPkd that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = Output_24 != this.__p_M2GqZFNgSW9PYCXLn8Vfjc ? new SelectionCheck_SLztM1n9wIpM9Rs29VzPkd(this)
                {__p_M2GqZFNgSW9PYCXLn8Vfjc = Output_24} : that_25;
            else
            {
                this.__p_M2GqZFNgSW9PYCXLn8Vfjc = Output_24;
            }

            return that_25;
        }

        public n33.SelectionCheck_SLztM1n9wIpM9Rs29VzPkd __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("AjFNjMAblDQMnPebi4p4Dw", "M2GqZFNgSW9PYCXLn8Vfjc", 234349U);
            var Output_1 = n34.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_0);
            n33.SelectionCheck_SLztM1n9wIpM9Rs29VzPkd that_2 = this;
            this.__p_M2GqZFNgSW9PYCXLn8Vfjc = Output_1;
            return that_2;
        }

        public n33.SelectionCheck_SLztM1n9wIpM9Rs29VzPkd __CreateDefault__()
        {
            n33.SelectionCheck_SLztM1n9wIpM9Rs29VzPkd that_0 = this;
            this.__p_M2GqZFNgSW9PYCXLn8Vfjc = n34.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_M2GqZFNgSW9PYCXLn8Vfjc);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 234349U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "M2GqZFNgSW9PYCXLn8Vfjc", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n34.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_M2GqZFNgSW9PYCXLn8Vfjc;
        public SelectionCheck_SLztM1n9wIpM9Rs29VzPkd(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SelectionCheck_SLztM1n9wIpM9Rs29VzPkd(SelectionCheck_SLztM1n9wIpM9Rs29VzPkd other): base(other)
        {
            this.__p_M2GqZFNgSW9PYCXLn8Vfjc = other.__p_M2GqZFNgSW9PYCXLn8Vfjc;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_M2GqZFNgSW9PYCXLn8Vfjc", in __p_M2GqZFNgSW9PYCXLn8Vfjc));
        }

        internal SelectionCheck_SLztM1n9wIpM9Rs29VzPkd __WITH__(n34.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_M2GqZFNgSW9PYCXLn8Vfjc)
        {
            n33.SelectionCheck_SLztM1n9wIpM9Rs29VzPkd that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_M2GqZFNgSW9PYCXLn8Vfjc != this.__p_M2GqZFNgSW9PYCXLn8Vfjc ? new SelectionCheck_SLztM1n9wIpM9Rs29VzPkd(this)
                {__p_M2GqZFNgSW9PYCXLn8Vfjc = __p_M2GqZFNgSW9PYCXLn8Vfjc} : that_0;
            else
            {
                this.__p_M2GqZFNgSW9PYCXLn8Vfjc = __p_M2GqZFNgSW9PYCXLn8Vfjc;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 234477U, DocumentId = "AjFNjMAblDQMnPebi4p4Dw", PersistentId = "KBntfbkJR2aPOdltQG8FmW", Name = "SelectionChange_KBntfbkJR2aPOdltQG8FmW")]
    [n2.SerializableAttribute]
    public class SelectionChange_KBntfbkJR2aPOdltQG8FmW : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n33.SelectionChange_KBntfbkJR2aPOdltQG8FmW Create(n1.NodeContext Node_Context)
        {
            var instance = new SelectionChange_KBntfbkJR2aPOdltQG8FmW(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n33.SelectionChange_KBntfbkJR2aPOdltQG8FmW CreateDefault()
        {
            var instance = new SelectionChange_KBntfbkJR2aPOdltQG8FmW(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n33.SelectionChange_KBntfbkJR2aPOdltQG8FmW Update(n3.TextBuilder_C Text_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Selection_Change_In, out bool Selection_Start_Out, out bool Selection_Change_Out)
        {
            var Output_1 = Text_In.GetSelection(Selection_Out: out n9.Selection_R<int> Selection_0);
            var State_Output_3 = Selection_0.IsStarted(Output_Out: out bool Output_2);
            var Output_4 = Output_2 && Selection_Change_In;
            var State_Output_6 = Selection_0.IsStarted(Output_Out: out bool Output_5);
            var Output_7 = !Output_5;
            var Output_8 = Output_7 && Selection_Change_In;
            Selection_Start_Out = Output_8;
            Selection_Change_Out = Output_4;
            return this;
        }

        public n33.SelectionChange_KBntfbkJR2aPOdltQG8FmW __Create__(n1.NodeContext Node_Context)
        {
            n18.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n33.SelectionChange_KBntfbkJR2aPOdltQG8FmW __CreateDefault__()
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

        public SelectionChange_KBntfbkJR2aPOdltQG8FmW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SelectionChange_KBntfbkJR2aPOdltQG8FmW(SelectionChange_KBntfbkJR2aPOdltQG8FmW other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal SelectionChange_KBntfbkJR2aPOdltQG8FmW __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Typewriter_
{
    public struct __AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw : n29.IAdaptiveOperatorLess<int>, n28.IAdaptiveCreateDefault<int>, n29.IAdaptiveOperatorGreater<int>, n29.IAdaptiveMax<int>, n29.IAdaptiveMin<int>, n29.IAdaptiveOperatorEquals<int>, n29.IAdaptiveOperatorMinus<int>, n28.IAdaptiveCreateDefault<char>
    {
        public void OperatorLess(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void CreateDefault(out int Output_Out)
        {
            n35._Operations_.CreateDefault_Generic<int>(Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorGreater(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In > Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void Max(int Input_In, int Input_2_In, out int Output_Out)
        {
            n11._Operations_.Max<int, n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Min(int Input_In, int Input_2_In, out int Output_Out)
        {
            n11._Operations_.Min<int, n10.__AdaptiveImplementations__AjFNjMAblDQMnPebi4p4Dw>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorEquals(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In == Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void OperatorMinus(int Input_In, int Input_2_In, out int Output_Out)
        {
            var Output_0 = Input_In - Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out char Output_Out)
        {
            var Output_0 = n36._Operations_.CreateDefault();
            Output_Out = Output_0;
            return;
        }
    }
}