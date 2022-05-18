extern alias e3;
extern alias e2;
extern alias e16;
extern alias e10;
extern alias e4;

using n17 = _HDE_ElementViewers_.HDE.ElementViewers.NodeInfoViewer;
using n55 = global::System.Windows;
using n8 = _CoreLibBasics_.Control.Advanced;
using n12 = e2::VL.Lib.Collections;
using n10 = _VL_Skia_.Graphics.Skia;
using n32 = e3::VL.Lib.Primitive.CacheRegion;
using n23 = global::System.Reactive.Subjects;
using n34 = _CoreLibBasics_.Primitive.Object.Advanced;
using n14 = _VL_Collections_.Collections.Builder.SpreadBuilder.Advanced;
using n37 = _CoreLibBasics_.Control;
using n3 = e16::VL.UI;
using n50 = _CoreLibBasics_.Math.Generic.Advanced;
using n35 = global::System.Globalization;
using n40 = _HDE_ElementViewers_.HDE.ElementViewers.LiveNodeViewer;
using n48 = e10::VL.Lang;
using n46 = e16::VL.UI.Core;
using n59 = _CoreLibBasics_.Animation.IClock.Advanced;
using n42 = e3::VL.Lib.Reactive;
using n56 = _VL_Reactive_.Reactive.Subjects.BehaviorSubject.Advanced;
using n30 = _VL_Skia_.Graphics.Skia.Text.Paint.Advanced;
using n41 = _CoreLibBasics_.Primitive.Tuple__2_Items.Advanced;
using n49 = _CoreLibBasics_.Primitive.String;
using n29 = _CoreLibBasics_.Primitive.Nullable.Advanced;
using n9 = _HDE_StylesAndSettings_.HDE.Styles;
using n28 = _VL_Skia_.Graphics.Skia.Paint;
using n15 = global::System.Collections.Generic;
using n18 = _CoreLibBasics_._2D.Vector2;
using n25 = global::SkiaSharp;
using n67 = _CoreLibBasics_.Math.Adaptive;
using n31 = _HDE_WidgetsAndViewers_.HDE.Viewers;
using n39 = _VL_Reactive_.Reactive.Observable.Advanced;
using n66 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n61 = _CoreLibBasics_.Animation;
using n57 = _HDE_WidgetsAndViewers_.HDE;
using n33 = e10::VL.Model;
using n58 = global::NuGet;
using n7 = e3::VL.Lib.Primitive;
using n53 = e2::VL.Lib.Runtime;
using n36 = _HDE_ElementViewers_;
using n52 = global::System.Windows.Input;
using n62 = _VL_Lang_.VL.LiveValueNotification;
using n47 = _VL_Skia_.Graphics.Skia.Text;
using n1 = e2::VL.Core;
using n5 = _HDE_ElementViewers_.HDE.ElementViewers;
using n4 = global::System;
using n11 = e4::Stride.Core.Mathematics;
using n45 = e3::VL.Lib.Color;
using n16 = _HDE_WidgetsAndViewers_.HDE.TooltipWidgets;
using n24 = _HDE_StylesAndSettings_.HDE.Settings;
using n22 = e3::VL.Lib.Primitive.Object;
using n26 = e3::VL.Lib.IO;
using n38 = e10::VL.Lang.Symbols;
using n6 = e2::VL.Core.CompilerServices;
using n54 = e3::VL.Lib.Collections;
using n20 = _HDE_WidgetsAndViewers_.HDE.Viewers.Experimental;
using n43 = _VL_Reactive_.Reactive.ForEach;
using n44 = _VL_Reactive_.Reactive.HoldLatest;
using n27 = _HDE_WidgetsAndViewers_.HDE.TooltipWidgets.IWidget;
using n60 = e2::VL.Lib.Animation;
using n21 = _VL_Collections_.Collections.Sequence;
using n19 = global::System.Runtime.CompilerServices;
using n64 = _System_Reflection_.System.Reflection.NodeContext.Advanced;
using n51 = global::System.Linq;
using n2 = e10::VL.Lang.PublicAPI;
using n13 = _VL_Collections_.Collections.Spread;
using n63 = _System_Reflection_.System.Reflection.IVLObject.Experimental;
using n65 = _CoreLibBasics_.Primitive.Advanced;

namespace _HDE_ElementViewers_.HDE.ElementViewers
{
    [n1.ElementAttribute(TracingId = 20372U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Aew1GDLMYczO4lOdJyHkcF", Name = "DataHubInfoViewer_C")]
    [n4.SerializableAttribute]
    public class DataHubInfoViewer_C : n1.VLObject, n3.IValueViewer<n2.IDataHubInfo>, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.DataHubInfoViewer_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new DataHubInfoViewer_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.DataHubInfoViewer_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new DataHubInfoViewer_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.DataHubInfoViewer_C Update_(n2.IDataHubInfo Value_In, n3.ViewerContext Context_In, out n3.IWidget Widget_Out)
        {
            var Compiletime_Type_0 = Value_In.CompiletimeType;
            n2.IElementInfo Info_1 = (n2.IElementInfo)Value_In;
            var Name_2 = Value_In.Name;
            var Result_3 = string.IsNullOrWhiteSpace(value: Name_2);
            var Output_4 = !Result_3;
            bool __auto_5;
            if (Output_4)
            {
                string Value_7 = "__pad_";
                n4.StringComparison Comparison_Type_8 = default(n4.StringComparison);
                var Result_9 = Name_2.StartsWith(value: Value_7, comparisonType: Comparison_Type_8);
                var Output_10 = !Result_9;
                __auto_5 = Output_10;
            }
            else
            {
                __auto_5 = false;
            }

            var Output_11 = Output_4 && __auto_5;
            string Input_2_12 = ": ";
            var Output_13 = n7.StringExtensions.Plus(input: Name_2, input2: Input_2_12);
            string Input_14 = "";
            n8._Operations_.Switch_Boolean<string>(Condition_In: Output_11, Input_In: Input_14, Input_2_In: Output_13, Output_Out: out string Output_15);
            var State_Output_25 = this.__p_AEtFnXiK7uBLxpX5joLNmP.Update(Output_Out: out n9.TooltipPaints_C Output_16, Background_Out: out n10.SkiaPaint_R Background_17, Hint_Out: out n11.Color4 Hint_18, Warning_Out: out n11.Color4 Warning_19, Error_Out: out n11.Color4 Error_20, Runtime_Error_Out: out n11.Color4 Runtime_Error_21, Font1_Out: out n10.SkiaPaint_R Font1_22, Font2_Out: out n10.SkiaPaint_R Font2_23, Font3_Out: out n10.SkiaPaint_R Font3_24);
            this.__p_AEtFnXiK7uBLxpX5joLNmP = State_Output_25;
            bool Update_26 = true;
            var Output_27 = this.__p_HP74di2zEvMPpS1AFJB0ar;
            if (Update_26)
            {
                Output_27 = this.__p_HP74di2zEvMPpS1AFJB0ar.Update(Value_In: Output_15, Paint_In: Font1_22);
            }

            this.__p_HP74di2zEvMPpS1AFJB0ar = Output_27;
            n3.IWidget Input_28 = (n3.IWidget)Output_27;
            var Result_29 = Context_In.RenderTypeAsString(typeSymbol: Compiletime_Type_0);
            bool Update_30 = true;
            var Output_31 = this.__p_BGfuXjp8bwsL8gPzs4gLlf;
            if (Update_30)
            {
                Output_31 = this.__p_BGfuXjp8bwsL8gPzs4gLlf.Update(Value_In: Result_29, Paint_In: Font2_23);
            }

            this.__p_BGfuXjp8bwsL8gPzs4gLlf = Output_31;
            n3.IWidget Input_2_32 = (n3.IWidget)Output_31;
            var builder_33 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl, 2);
            builder_33.Add(Input_28);
            builder_33.Add(Input_2_32);
            var __pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl_34 = builder_33.Commit();
            this.__pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl = __pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl_34;
            n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl_34, Result_Out: out n12.Spread<n3.IWidget> Result_35);
            var State_Output_37 = this.__p_RBzc7eWtS1vLMwj1v7QUmd.Update(Input_In: Result_35, Info_In: Info_1, Paint_In: Font3_24, Output_Out: out n12.Spread<n3.IWidget> Output_36);
            this.__p_RBzc7eWtS1vLMwj1v7QUmd = State_Output_37;
            n1.IInfo Input_38 = (n1.IInfo)Value_In;
            var Summary_39 = Input_38.Summary;
            var Result_40 = string.IsNullOrWhiteSpace(value: Summary_39);
            var Output_41 = !Result_40;
            n1.NodeContext Node_Context_42 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "GZLPmp0fcTYNpZySEevDFl", 20505U);
            int Capacity_43 = 0;
            n14._Operations_.Create<n3.IWidget>(Node_Context: Node_Context_42, Capacity_In: Capacity_43, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_44);
            n15.IEnumerable<n3.IWidget> Widgets_45 = (n15.IEnumerable<n3.IWidget>)Output_36;
            bool Update_46 = true;
            var Output_47 = this.__p_FScLlfW1eiBQIp1NH7m32W;
            if (Update_46)
            {
                Output_47 = this.__p_FScLlfW1eiBQIp1NH7m32W.Update(Widgets_In: Widgets_45);
            }

            this.__p_FScLlfW1eiBQIp1NH7m32W = Output_47;
            n3.IWidget Item_48 = (n3.IWidget)Output_47;
            n14._Operations_.Add<n3.IWidget>(Input_In: Output_44, Item_In: Item_48, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_49);
            n12.SpreadBuilder<n3.IWidget> __auto_50;
            var state_51 = n1.CompilationHelper.Restore<__InMHYbFMxvQNAVBFZc5lsu>(this.__if_UcWJhQAiAjWPv6OqZFYUL3, __GetContext__());
            if (Output_41)
            {
                if (state_51 == null)
                {
                    state_51 = new __InMHYbFMxvQNAVBFZc5lsu(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_52 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "NRMofYSqwQbPE1bGQR8Rer", 20808U);
                    var Output_53 = n16.TextWidget_MultiLine_R.Create(Node_Context: Node_Context_52);
                    state_51.__p_NRMofYSqwQbPE1bGQR8Rer = Output_53;
                    n1.NodeContext Node_Context_54 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "GXQ9rCyPTBbQPKt8usOHlm", 20846U);
                    var Output_55 = n16.PanelWidget_R.Create(Node_Context: Node_Context_54);
                    state_51.__p_GXQ9rCyPTBbQPKt8usOHlm = Output_55;
                }

                n11.Vector2 __pad_EY8NTmndtzwL6tfYNWhFvY_56 = __slot_EY8NTmndtzwL6tfYNWhFvY;
                n17._Operations_.EnforceEndDot(Input_In: Summary_39, Output_Out: out string Output_57);
                int Count_58 = 10;
                bool Break_at_Words_59 = true;
                bool Update_60 = true;
                var Output_61 = state_51.__p_NRMofYSqwQbPE1bGQR8Rer;
                if (Update_60)
                {
                    Output_61 = state_51.__p_NRMofYSqwQbPE1bGQR8Rer.Update(Value_In: Output_57, Count_In: Count_58, Break_at_Words_In: Break_at_Words_59, Paint_In: Font1_22);
                }

                n3.IWidget Widget_62 = (n3.IWidget)Output_61;
                n11.Vector2 Margin_63 = n18._Operations_.CreateDefault();
                bool Background_Enabled_64 = false;
                n10.SkiaPaint_R Stroke_Paint_65 = n10.SkiaPaint_R.CreateDefault();
                bool Stroke_Enabled_66 = false;
                bool Clip_Enabled_67 = false;
                bool Update_68 = true;
                var Output_69 = state_51.__p_GXQ9rCyPTBbQPKt8usOHlm;
                if (Update_68)
                {
                    Output_69 = state_51.__p_GXQ9rCyPTBbQPKt8usOHlm.Update(Widget_In: Widget_62, Margin_In: Margin_63, Padding_In: __pad_EY8NTmndtzwL6tfYNWhFvY_56, Background_Paint_In: Background_17, Background_Enabled_In: Background_Enabled_64, Stroke_Paint_In: Stroke_Paint_65, Stroke_Enabled_In: Stroke_Enabled_66, Clip_Enabled_In: Clip_Enabled_67);
                }

                n3.IWidget Item_70 = (n3.IWidget)Output_69;
                n14._Operations_.Add<n3.IWidget>(Input_In: Output_49, Item_In: Item_70, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_71);
                __auto_50 = Output_71;
                state_51.__p_NRMofYSqwQbPE1bGQR8Rer = Output_61;
                state_51.__p_GXQ9rCyPTBbQPKt8usOHlm = Output_69;
                this.__if_UcWJhQAiAjWPv6OqZFYUL3 = state_51;
            }
            else
            {
                __auto_50 = Output_49;
            }

            n2.IElementInfo Input_72 = (n2.IElementInfo)Value_In;
            var Compiler_Messages_73 = Input_72.CompilerMessages;
            var Is_Unused_74 = Input_72.IsUnused;
            string Nodename_75 = "";
            n4.Nullable<n1.UniqueId> OwnerElementID_76 = default(n4.Nullable<n1.UniqueId>);
            var Output_78 = this.__p_MW9vK7QXIVlO3fAvlwYpB6.Update(Nodename_In: Nodename_75, Message_In: Compiler_Messages_73, OwnerElementID_In: OwnerElementID_76, Widgets_Out: out n12.Spread<n3.IWidget> Widgets_77);
            this.__p_MW9vK7QXIVlO3fAvlwYpB6 = Output_78;
            n15.IEnumerable<n3.IWidget> Items_79 = (n15.IEnumerable<n3.IWidget>)Widgets_77;
            n14._Operations_.AddRange<n3.IWidget>(Input_In: __auto_50, Items_In: Items_79, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_80);
            n15.IEnumerable<n3.IWidget> Widgets_81 = (n15.IEnumerable<n3.IWidget>)Output_80;
            bool KeepOriginalWidth_82 = false;
            bool Update_83 = true;
            var Output_84 = this.__p_UpmFu7qJFRWOGaGODgMQSL;
            if (Update_83)
            {
                Output_84 = this.__p_UpmFu7qJFRWOGaGODgMQSL.Update(Widgets_In: Widgets_81, KeepOriginalWidth_In: KeepOriginalWidth_82);
            }

            this.__p_UpmFu7qJFRWOGaGODgMQSL = Output_84;
            n3.IWidget Widget_Out_85 = (n3.IWidget)Output_84;
            Widget_Out = Widget_Out_85;
            return this;
        }

        public n5.DataHubInfoViewer_C __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl = n13._Operations_.CreateDefault<n3.IWidget>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "FScLlfW1eiBQIp1NH7m32W", 20453U);
            var Output_1 = n16.Row_R.Create(Node_Context: Node_Context_0);
            this.__p_FScLlfW1eiBQIp1NH7m32W = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "HP74di2zEvMPpS1AFJB0ar", 20478U);
            var Output_3 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_2);
            this.__p_HP74di2zEvMPpS1AFJB0ar = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "BGfuXjp8bwsL8gPzs4gLlf", 20495U);
            var Output_5 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_4);
            this.__p_BGfuXjp8bwsL8gPzs4gLlf = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "UpmFu7qJFRWOGaGODgMQSL", 20539U);
            var Output_7 = n16.Column_R.Create(Node_Context: Node_Context_6);
            this.__p_UpmFu7qJFRWOGaGODgMQSL = Output_7;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "MW9vK7QXIVlO3fAvlwYpB6", 20553U);
            bool IsRuntime_9 = false;
            var Output_10 = n5.MessageWidgets_C.Create(Node_Context: Node_Context_8, IsRuntime_In: IsRuntime_9);
            this.__p_MW9vK7QXIVlO3fAvlwYpB6 = Output_10;
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "RBzc7eWtS1vLMwj1v7QUmd", 20589U);
            var Output_12 = n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX.Create(Node_Context: Node_Context_11);
            this.__p_RBzc7eWtS1vLMwj1v7QUmd = Output_12;
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "AEtFnXiK7uBLxpX5joLNmP", 20604U);
            var Output_14 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_13);
            this.__p_AEtFnXiK7uBLxpX5joLNmP = Output_14;
            this.__if_UcWJhQAiAjWPv6OqZFYUL3 = default(n4.Object);
            return this;
        }

        public n5.DataHubInfoViewer_C __CreateDefault__()
        {
            this.__pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__p_AEtFnXiK7uBLxpX5joLNmP = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__p_HP74di2zEvMPpS1AFJB0ar = n16.TextWidget_SingleLine_R.CreateDefault();
            this.__p_BGfuXjp8bwsL8gPzs4gLlf = n16.TextWidget_SingleLine_R.CreateDefault();
            this.__p_RBzc7eWtS1vLMwj1v7QUmd = n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX.CreateDefault();
            this.__p_FScLlfW1eiBQIp1NH7m32W = n16.Row_R.CreateDefault();
            this.__if_UcWJhQAiAjWPv6OqZFYUL3 = default(n4.Object);
            this.__p_MW9vK7QXIVlO3fAvlwYpB6 = n5.MessageWidgets_C.CreateDefault();
            this.__p_UpmFu7qJFRWOGaGODgMQSL = n16.Column_R.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_AEtFnXiK7uBLxpX5joLNmP);
            n1.CompilationHelper.SafeDispose(this.__p_HP74di2zEvMPpS1AFJB0ar);
            n1.CompilationHelper.SafeDispose(this.__p_BGfuXjp8bwsL8gPzs4gLlf);
            n1.CompilationHelper.SafeDispose(this.__p_RBzc7eWtS1vLMwj1v7QUmd);
            n1.CompilationHelper.SafeDispose(this.__p_FScLlfW1eiBQIp1NH7m32W);
            n1.CompilationHelper.SafeDispose(this.__if_UcWJhQAiAjWPv6OqZFYUL3);
            n1.CompilationHelper.SafeDispose(this.__p_MW9vK7QXIVlO3fAvlwYpB6);
            n1.CompilationHelper.SafeDispose(this.__p_UpmFu7qJFRWOGaGODgMQSL);
            return;
        }

        void n3.IValueViewer<n2.IDataHubInfo>.Update(n2.IDataHubInfo value, n3.ViewerContext context, out n3.IWidget widget)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(value, context, out widget);
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 20604U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "AEtFnXiK7uBLxpX5joLNmP", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_AEtFnXiK7uBLxpX5joLNmP;
        [n1.ElementAttribute(TracingId = 20478U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "HP74di2zEvMPpS1AFJB0ar", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
        public n16.TextWidget_SingleLine_R __p_HP74di2zEvMPpS1AFJB0ar;
        [n1.ElementAttribute(TracingId = 20495U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "BGfuXjp8bwsL8gPzs4gLlf", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
        public n16.TextWidget_SingleLine_R __p_BGfuXjp8bwsL8gPzs4gLlf;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n3.IWidget> __pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl = default(n12.Spread<n3.IWidget>);
        [n1.ElementAttribute(TracingId = 20589U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "RBzc7eWtS1vLMwj1v7QUmd", Name = "AppendIDWidget", IsManaged = true, IsAutoGenerated = true)]
        public n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX __p_RBzc7eWtS1vLMwj1v7QUmd;
        [n1.ElementAttribute(TracingId = 20453U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "FScLlfW1eiBQIp1NH7m32W", Name = "Row", IsManaged = true, IsAutoGenerated = true)]
        public n16.Row_R __p_FScLlfW1eiBQIp1NH7m32W;
        [n1.ElementAttribute(TracingId = 20838U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "EY8NTmndtzwL6tfYNWhFvY", Name = "__slot_EY8NTmndtzwL6tfYNWhFvY")]
        public static n11.Vector2 __slot_EY8NTmndtzwL6tfYNWhFvY = n1.CompilationHelper.Deserialize<n11.Vector2>("0.06, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "EY8NTmndtzwL6tfYNWhFvY");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_UcWJhQAiAjWPv6OqZFYUL3;
        [n1.ElementAttribute(TracingId = 20553U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "MW9vK7QXIVlO3fAvlwYpB6", Name = "MessageWidgets", IsManaged = true, IsAutoGenerated = true)]
        public n5.MessageWidgets_C __p_MW9vK7QXIVlO3fAvlwYpB6;
        [n1.ElementAttribute(TracingId = 20539U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "UpmFu7qJFRWOGaGODgMQSL", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
        public n16.Column_R __p_UpmFu7qJFRWOGaGODgMQSL;
        static DataHubInfoViewer_C()
        {
        }

        public DataHubInfoViewer_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DataHubInfoViewer_C(DataHubInfoViewer_C other): base(other)
        {
            this.__p_AEtFnXiK7uBLxpX5joLNmP = other.__p_AEtFnXiK7uBLxpX5joLNmP;
            this.__p_HP74di2zEvMPpS1AFJB0ar = other.__p_HP74di2zEvMPpS1AFJB0ar;
            this.__p_BGfuXjp8bwsL8gPzs4gLlf = other.__p_BGfuXjp8bwsL8gPzs4gLlf;
            this.__pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl = other.__pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl;
            this.__p_RBzc7eWtS1vLMwj1v7QUmd = other.__p_RBzc7eWtS1vLMwj1v7QUmd;
            this.__p_FScLlfW1eiBQIp1NH7m32W = other.__p_FScLlfW1eiBQIp1NH7m32W;
            this.__if_UcWJhQAiAjWPv6OqZFYUL3 = other.__if_UcWJhQAiAjWPv6OqZFYUL3;
            this.__p_MW9vK7QXIVlO3fAvlwYpB6 = other.__p_MW9vK7QXIVlO3fAvlwYpB6;
            this.__p_UpmFu7qJFRWOGaGODgMQSL = other.__p_UpmFu7qJFRWOGaGODgMQSL;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AEtFnXiK7uBLxpX5joLNmP", in __p_AEtFnXiK7uBLxpX5joLNmP), n1.CompilationHelper.GetValueOrExisting(values, "__p_HP74di2zEvMPpS1AFJB0ar", in __p_HP74di2zEvMPpS1AFJB0ar), n1.CompilationHelper.GetValueOrExisting(values, "__p_BGfuXjp8bwsL8gPzs4gLlf", in __p_BGfuXjp8bwsL8gPzs4gLlf), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl", in __pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl), n1.CompilationHelper.GetValueOrExisting(values, "__p_RBzc7eWtS1vLMwj1v7QUmd", in __p_RBzc7eWtS1vLMwj1v7QUmd), n1.CompilationHelper.GetValueOrExisting(values, "__p_FScLlfW1eiBQIp1NH7m32W", in __p_FScLlfW1eiBQIp1NH7m32W), n1.CompilationHelper.GetValueOrExisting(values, "__if_UcWJhQAiAjWPv6OqZFYUL3", in __if_UcWJhQAiAjWPv6OqZFYUL3), n1.CompilationHelper.GetValueOrExisting(values, "__p_MW9vK7QXIVlO3fAvlwYpB6", in __p_MW9vK7QXIVlO3fAvlwYpB6), n1.CompilationHelper.GetValueOrExisting(values, "__p_UpmFu7qJFRWOGaGODgMQSL", in __p_UpmFu7qJFRWOGaGODgMQSL));
        }

        internal DataHubInfoViewer_C __WITH__(n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_AEtFnXiK7uBLxpX5joLNmP, n16.TextWidget_SingleLine_R __p_HP74di2zEvMPpS1AFJB0ar, n16.TextWidget_SingleLine_R __p_BGfuXjp8bwsL8gPzs4gLlf, n12.Spread<n3.IWidget> __pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl, n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX __p_RBzc7eWtS1vLMwj1v7QUmd, n16.Row_R __p_FScLlfW1eiBQIp1NH7m32W, n4.Object __if_UcWJhQAiAjWPv6OqZFYUL3, n5.MessageWidgets_C __p_MW9vK7QXIVlO3fAvlwYpB6, n16.Column_R __p_UpmFu7qJFRWOGaGODgMQSL)
        {
            n5.DataHubInfoViewer_C that_0 = this;
            this.__p_AEtFnXiK7uBLxpX5joLNmP = __p_AEtFnXiK7uBLxpX5joLNmP;
            this.__p_HP74di2zEvMPpS1AFJB0ar = __p_HP74di2zEvMPpS1AFJB0ar;
            this.__p_BGfuXjp8bwsL8gPzs4gLlf = __p_BGfuXjp8bwsL8gPzs4gLlf;
            this.__pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl = __pin_group_Input_In_IBqN4auxUBlLxdQJZBc9dl;
            this.__p_RBzc7eWtS1vLMwj1v7QUmd = __p_RBzc7eWtS1vLMwj1v7QUmd;
            this.__p_FScLlfW1eiBQIp1NH7m32W = __p_FScLlfW1eiBQIp1NH7m32W;
            this.__if_UcWJhQAiAjWPv6OqZFYUL3 = __if_UcWJhQAiAjWPv6OqZFYUL3;
            this.__p_MW9vK7QXIVlO3fAvlwYpB6 = __p_MW9vK7QXIVlO3fAvlwYpB6;
            this.__p_UpmFu7qJFRWOGaGODgMQSL = __p_UpmFu7qJFRWOGaGODgMQSL;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "InMHYbFMxvQNAVBFZc5lsu", Name = "__InMHYbFMxvQNAVBFZc5lsu")]
        [n4.SerializableAttribute]
        public class __InMHYbFMxvQNAVBFZc5lsu : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_NRMofYSqwQbPE1bGQR8Rer);
                n1.CompilationHelper.SafeDispose(this.__p_GXQ9rCyPTBbQPKt8usOHlm);
                return;
            }

            [n1.ElementAttribute(TracingId = 20808U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "NRMofYSqwQbPE1bGQR8Rer", Name = "TextWidget (MultiLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_MultiLine_R __p_NRMofYSqwQbPE1bGQR8Rer;
            [n1.ElementAttribute(TracingId = 20846U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "GXQ9rCyPTBbQPKt8usOHlm", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.PanelWidget_R __p_GXQ9rCyPTBbQPKt8usOHlm;
            public __InMHYbFMxvQNAVBFZc5lsu(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __InMHYbFMxvQNAVBFZc5lsu(__InMHYbFMxvQNAVBFZc5lsu other): base(other)
            {
                this.__p_NRMofYSqwQbPE1bGQR8Rer = other.__p_NRMofYSqwQbPE1bGQR8Rer;
                this.__p_GXQ9rCyPTBbQPKt8usOHlm = other.__p_GXQ9rCyPTBbQPKt8usOHlm;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NRMofYSqwQbPE1bGQR8Rer", in __p_NRMofYSqwQbPE1bGQR8Rer), n1.CompilationHelper.GetValueOrExisting(values, "__p_GXQ9rCyPTBbQPKt8usOHlm", in __p_GXQ9rCyPTBbQPKt8usOHlm));
            }

            internal __InMHYbFMxvQNAVBFZc5lsu __WITH__(n16.TextWidget_MultiLine_R __p_NRMofYSqwQbPE1bGQR8Rer, n16.PanelWidget_R __p_GXQ9rCyPTBbQPKt8usOHlm)
            {
                __InMHYbFMxvQNAVBFZc5lsu that_0 = this;
                this.__p_NRMofYSqwQbPE1bGQR8Rer = __p_NRMofYSqwQbPE1bGQR8Rer;
                this.__p_GXQ9rCyPTBbQPKt8usOHlm = __p_GXQ9rCyPTBbQPKt8usOHlm;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 21123U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "LDg7V976WMIN1JCMMEkTgn", Name = "NodeInfoViewer_C")]
    [n4.SerializableAttribute]
    public class NodeInfoViewer_C : n1.VLObject, n3.IValueViewer<n2.INodeInfo>, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.NodeInfoViewer_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new NodeInfoViewer_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.NodeInfoViewer_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new NodeInfoViewer_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.NodeInfoViewer_C SetValue()
        {
            return this;
        }

        public n5.NodeInfoViewer_C Update_(n2.INodeInfo Value_In, n3.ViewerContext Context_In, out n3.IWidget Widget_Out)
        {
            n11.Vector2 __pad_Q60umDXpUfxOENEys3s0D2_0 = __slot_Q60umDXpUfxOENEys3s0D2;
            n11.Vector2 __pad_Jcvg65DOKAHM6r2Ts1UBLe_1 = __slot_Jcvg65DOKAHM6r2Ts1UBLe;
            n11.Vector2 __pad_FvWxOA253DhPvoGp2qlc7R_2 = __slot_FvWxOA253DhPvoGp2qlc7R;
            var Name_3 = Value_In.Name;
            var Category_4 = Value_In.Category;
            string Input_5 = "";
            string Input_2_6 = " [";
            string Input_4_7 = "]";
            var Output_8 = n7.StringExtensions.Plus(input: Input_5, input2: Input_2_6);
            var Output_9 = n7.StringExtensions.Plus(input: Output_8, input2: Category_4);
            var Output_10 = n7.StringExtensions.Plus(input: Output_9, input2: Input_4_7);
            var State_Output_20 = this.__p_H6XaZMsJWLQMPEBflplfuU.Update(Output_Out: out n9.TooltipPaints_C Output_11, Background_Out: out n10.SkiaPaint_R Background_12, Hint_Out: out n11.Color4 Hint_13, Warning_Out: out n11.Color4 Warning_14, Error_Out: out n11.Color4 Error_15, Runtime_Error_Out: out n11.Color4 Runtime_Error_16, Font1_Out: out n10.SkiaPaint_R Font1_17, Font2_Out: out n10.SkiaPaint_R Font2_18, Font3_Out: out n10.SkiaPaint_R Font3_19);
            this.__p_H6XaZMsJWLQMPEBflplfuU = State_Output_20;
            bool Update_21 = true;
            var Output_22 = this.__p_Qjs4RNIsmD9PVEuz6IXZgZ;
            if (Update_21)
            {
                Output_22 = this.__p_Qjs4RNIsmD9PVEuz6IXZgZ.Update(Value_In: Output_10, Paint_In: Font2_18);
            }

            this.__p_Qjs4RNIsmD9PVEuz6IXZgZ = Output_22;
            n2.IElementInfo Input_23 = (n2.IElementInfo)Value_In;
            var Tags_24 = Input_23.Tags;
            n21._Operations_.Any<string>(Input_In: Tags_24, Result_Out: out bool Result_25);
            var Result_26 = n22.ObjectHelpers.ToString(input: Name_3);
            bool Update_27 = true;
            var Output_28 = this.__p_Lc0utCdokyQL3XYlz3FRyM;
            if (Update_27)
            {
                Output_28 = this.__p_Lc0utCdokyQL3XYlz3FRyM.Update(Value_In: Result_26, Paint_In: Font1_17);
            }

            this.__p_Lc0utCdokyQL3XYlz3FRyM = Output_28;
            n3.IWidget Input_29 = (n3.IWidget)Output_28;
            n3.IWidget Input_2_30 = (n3.IWidget)Output_22;
            n11.Vector2 Default_Size_31 = __c_BvIxclZ3XE0MbHNIGl9sFd;
            bool Update_32 = true;
            var Output_33 = this.__p_ABeS9tqoIyJNJeQZQHzZdq;
            if (Update_32)
            {
                Output_33 = this.__p_ABeS9tqoIyJNJeQZQHzZdq.Update(Default_Size_In: Default_Size_31);
            }

            this.__p_ABeS9tqoIyJNJeQZQHzZdq = Output_33;
            n3.IWidget Input_3_34 = (n3.IWidget)Output_33;
            var Smells_35 = Value_In.Smells;
            var State_Output_37 = this.__p_BLSwC3vu8VbNbphVMXvqwu.Update(Input_In: Smells_35, Text_Paint_In: Font3_19, Output_Out: out n16.Row_R Output_36);
            this.__p_BLSwC3vu8VbNbphVMXvqwu = State_Output_37;
            n3.IWidget Input_4_38 = (n3.IWidget)Output_36;
            var builder_39 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4, 4);
            builder_39.Add(Input_29);
            builder_39.Add(Input_2_30);
            builder_39.Add(Input_3_34);
            builder_39.Add(Input_4_38);
            var __pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4_40 = builder_39.Commit();
            this.__pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4 = __pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4_40;
            n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4_40, Result_Out: out n12.Spread<n3.IWidget> Result_41);
            n2.IElementInfo Info_42 = (n2.IElementInfo)Value_In;
            var State_Output_44 = this.__p_JIvQerZQAAfQUUGe0NpMpd.Update(Input_In: Result_41, Info_In: Info_42, Paint_In: Font3_19, Output_Out: out n12.Spread<n3.IWidget> Output_43);
            this.__p_JIvQerZQAAfQUUGe0NpMpd = State_Output_44;
            n15.IEnumerable<n3.IWidget> Widgets_45 = (n15.IEnumerable<n3.IWidget>)Output_43;
            bool Update_46 = true;
            var Output_47 = this.__p_IVnO8kS9eM2OgWA99HSipn;
            if (Update_46)
            {
                Output_47 = this.__p_IVnO8kS9eM2OgWA99HSipn.Update(Widgets_In: Widgets_45);
            }

            this.__p_IVnO8kS9eM2OgWA99HSipn = Output_47;
            n3.IWidget Item_48 = (n3.IWidget)Output_47;
            n12.SpreadBuilder<n3.IWidget> Input_49 = n14._Operations_.CreateDefault<n3.IWidget>();
            n14._Operations_.Add<n3.IWidget>(Input_In: Input_49, Item_In: Item_48, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_50);
            var Symbol_Source_51 = Value_In.SymbolSource;
            var Result_52 = string.IsNullOrWhiteSpace(value: Symbol_Source_51);
            var Output_53 = !Result_52;
            n24._Operations_.TooltipShowSymbolSource(Value_Out: out bool Value_54, Tooltip_Show_Symbol_Source_Out: out n23.BehaviorSubject<bool> Tooltip_Show_Symbol_Source_55);
            var Output_56 = Output_53 && Value_54;
            n10.SkiaPaint_R Input_57 = n10.SkiaPaint_R.CreateDefault();
            n11.Color4 Color_58 = __c_SoJ5Lgz2RmTOTnMNKJDCg1;
            n25.SKShader Shader_59 = default(n25.SKShader);
            var State_Output_61 = this.__p_EavrKfgPEjbL69JsJ9P3Hb.Update(Input_In: Input_57, Color_In: Color_58, Shader_In: Shader_59, Output_Out: out n10.SkiaPaint_R Output_60);
            this.__p_EavrKfgPEjbL69JsJ9P3Hb = State_Output_61;
            n12.SpreadBuilder<n3.IWidget> __auto_62;
            var state_63 = n1.CompilationHelper.Restore<__QQvrK5ZybEHOmMJqTd7Pk5>(this.__if_VC5CZrJHm7pPPICAB1idyo, __GetContext__());
            if (Output_56)
            {
                if (state_63 == null)
                {
                    state_63 = new __QQvrK5ZybEHOmMJqTd7Pk5(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_64 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "F3QG7gu41OqNg7wpup3KTq", 26153U);
                    var Output_65 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_64);
                    state_63.__p_F3QG7gu41OqNg7wpup3KTq = Output_65;
                    n1.NodeContext Node_Context_66 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "FsGxaORJDh7O1wZn4eSq0F", 26211U);
                    var Output_67 = n16.PanelWidget_R.Create(Node_Context: Node_Context_66);
                    state_63.__p_FsGxaORJDh7O1wZn4eSq0F = Output_67;
                }

                var Result_68 = n26.PathExtension.ToPath(input: Symbol_Source_51);
                Result_68.Filename(directory: out string Directory_69, filename: out string Filename_70, extension: out string Extension_71);
                string Input_2_72 = ".";
                string Input_4_73 = "  ";
                var Output_74 = n7.StringExtensions.Plus(input: Filename_70, input2: Input_2_72);
                var Output_75 = n7.StringExtensions.Plus(input: Output_74, input2: Extension_71);
                var Output_76 = n7.StringExtensions.Plus(input: Output_75, input2: Input_4_73);
                var Output_77 = n7.StringExtensions.Plus(input: Output_76, input2: Directory_69);
                bool Update_78 = true;
                var Output_79 = state_63.__p_F3QG7gu41OqNg7wpup3KTq;
                if (Update_78)
                {
                    Output_79 = state_63.__p_F3QG7gu41OqNg7wpup3KTq.Update(Value_In: Output_77, Paint_In: Font3_19);
                }

                n3.IWidget Widget_80 = (n3.IWidget)Output_79;
                n11.Vector2 Padding_81 = n18._Operations_.CreateDefault();
                bool Background_Enabled_82 = false;
                n10.SkiaPaint_R Stroke_Paint_83 = n10.SkiaPaint_R.CreateDefault();
                bool Stroke_Enabled_84 = false;
                bool Clip_Enabled_85 = false;
                bool Update_86 = true;
                var Output_87 = state_63.__p_FsGxaORJDh7O1wZn4eSq0F;
                if (Update_86)
                {
                    Output_87 = state_63.__p_FsGxaORJDh7O1wZn4eSq0F.Update(Widget_In: Widget_80, Margin_In: __pad_Q60umDXpUfxOENEys3s0D2_0, Padding_In: Padding_81, Background_Paint_In: Output_60, Background_Enabled_In: Background_Enabled_82, Stroke_Paint_In: Stroke_Paint_83, Stroke_Enabled_In: Stroke_Enabled_84, Clip_Enabled_In: Clip_Enabled_85);
                }

                n3.IWidget Item_88 = (n3.IWidget)Output_87;
                n14._Operations_.Add<n3.IWidget>(Input_In: Output_50, Item_In: Item_88, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_89);
                __auto_62 = Output_89;
                state_63.__p_F3QG7gu41OqNg7wpup3KTq = Output_79;
                state_63.__p_FsGxaORJDh7O1wZn4eSq0F = Output_87;
                this.__if_VC5CZrJHm7pPPICAB1idyo = state_63;
            }
            else
            {
                __auto_62 = Output_50;
            }

            n12.SpreadBuilder<n3.IWidget> __auto_90;
            var state_91 = n1.CompilationHelper.Restore<__VxE0Gg4qlg9L9SerI9UHNv>(this.__if_EfdwnXl8e3xLKxkAeipTD2, __GetContext__());
            if (Result_25)
            {
                if (state_91 == null)
                {
                    state_91 = new __VxE0Gg4qlg9L9SerI9UHNv(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_92 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "DfIpaJLGsAwPm2GZMNhiXb", 26506U);
                    var Output_93 = n16.TagsWidget_LZd5EZDzlf3MVOiP5H1oSY.Create(Node_Context: Node_Context_92);
                    state_91.__p_DfIpaJLGsAwPm2GZMNhiXb = Output_93;
                    n1.NodeContext Node_Context_94 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Oe0EmXWDexQOeT4oOIIn0b", 26535U);
                    var Output_95 = n16.PanelWidget_R.Create(Node_Context: Node_Context_94);
                    state_91.__p_Oe0EmXWDexQOeT4oOIIn0b = Output_95;
                    n1.NodeContext Node_Context_96 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "GLNR0o1bWYkOtYCDinH76L", 26559U);
                    var Output_97 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_96);
                    state_91.__p_GLNR0o1bWYkOtYCDinH76L = Output_97;
                }

                var State_Output_99 = state_91.__p_DfIpaJLGsAwPm2GZMNhiXb.Update(Input_In: Tags_24, Text_Paint_In: Font3_19, Output_Out: out n16.Row_R Output_98);
                n3.IWidget Widget_100 = (n3.IWidget)Output_98;
                n11.Vector2 Padding_101 = n18._Operations_.CreateDefault();
                bool Background_Enabled_102 = false;
                n10.SkiaPaint_R Stroke_Paint_103 = n10.SkiaPaint_R.CreateDefault();
                bool Stroke_Enabled_104 = false;
                bool Clip_Enabled_105 = false;
                bool Update_106 = true;
                var Output_107 = state_91.__p_Oe0EmXWDexQOeT4oOIIn0b;
                if (Update_106)
                {
                    Output_107 = state_91.__p_Oe0EmXWDexQOeT4oOIIn0b.Update(Widget_In: Widget_100, Margin_In: __pad_FvWxOA253DhPvoGp2qlc7R_2, Padding_In: Padding_101, Background_Paint_In: Background_12, Background_Enabled_In: Background_Enabled_102, Stroke_Paint_In: Stroke_Paint_103, Stroke_Enabled_In: Stroke_Enabled_104, Clip_Enabled_In: Clip_Enabled_105);
                }

                n11.Vector2 Default_Size_108 = __c_HwrK8NRp7uIP3HNmTcfB3x;
                bool Update_109 = true;
                var Output_110 = state_91.__p_GLNR0o1bWYkOtYCDinH76L;
                if (Update_109)
                {
                    Output_110 = state_91.__p_GLNR0o1bWYkOtYCDinH76L.Update(Default_Size_In: Default_Size_108);
                }

                n3.IWidget Item_111 = (n3.IWidget)Output_110;
                n14._Operations_.Add<n3.IWidget>(Input_In: __auto_62, Item_In: Item_111, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_112);
                n3.IWidget Item_113 = (n3.IWidget)Output_107;
                n14._Operations_.Add<n3.IWidget>(Input_In: Output_112, Item_In: Item_113, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_114);
                __auto_90 = Output_114;
                state_91.__p_DfIpaJLGsAwPm2GZMNhiXb = State_Output_99;
                state_91.__p_Oe0EmXWDexQOeT4oOIIn0b = Output_107;
                state_91.__p_GLNR0o1bWYkOtYCDinH76L = Output_110;
                this.__if_EfdwnXl8e3xLKxkAeipTD2 = state_91;
            }
            else
            {
                __auto_90 = __auto_62;
            }

            var Moments_115 = Input_23.Moments;
            var __fallback___116 = n1.ServiceRegistry.Current;
            n21._Operations_.Where<n2.IMomentInfo>(Input_In: Moments_115, Predicate_In: (n2.IMomentInfo Arg_1_In_118, int Arg_2_In_119) =>
            {
                using var __current_117 = __fallback___116.MakeCurrentIfNone();
                string __pad_Dlc4Fm0SFIbLeZVIIHJ9QD_120 = __slot_Dlc4Fm0SFIbLeZVIIHJ9QD;
                string __pad_Uir4i3omxrvNNr2yuhwAci_121 = __slot_Uir4i3omxrvNNr2yuhwAci;
                var Moment_122 = Arg_1_In_118.Moment;
                var Result_123 = Moment_122 != __pad_Dlc4Fm0SFIbLeZVIIHJ9QD_120;
                var Result_124 = Moment_122 != __pad_Uir4i3omxrvNNr2yuhwAci_121;
                string Input_2_125 = "";
                var Result_126 = Moment_122 != Input_2_125;
                var Output_127 = Result_123 && Result_124;
                var Output_128 = Output_127 && Result_126;
                return Output_128;
            }

            , Output_Out: out n15.IEnumerable<n2.IMomentInfo> Output_129);
            n21._Operations_.Any<n2.IMomentInfo>(Input_In: Output_129, Result_Out: out bool Result_130);
            n24._Operations_.TooltipShowOperation(Value_Out: out bool Value_131, Tooltip_Show_Operation_Out: out n23.BehaviorSubject<bool> Tooltip_Show_Operation_132);
            var Output_133 = Result_130 && Value_131;
            n1.IInfo Input_134 = (n1.IInfo)Value_In;
            var Summary_135 = Input_134.Summary;
            var Remarks_136 = Input_134.Remarks;
            n24._Operations_.TooltipShowDocumentation(Value_Out: out bool Value_137, Tooltip_Show_Documentation_Out: out n23.BehaviorSubject<bool> Tooltip_Show_Documentation_138);
            n12.SpreadBuilder<n3.IWidget> __auto_139;
            var state_140 = n1.CompilationHelper.Restore<__RSzt6znSZaSNKcAscCy7mN>(this.__if_SI5YDM2khNeN0to0OL15pD, __GetContext__());
            if (Value_137)
            {
                if (state_140 == null)
                {
                    state_140 = new __RSzt6znSZaSNKcAscCy7mN(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_141 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "UOFWBM0NplaOM45Wak0G7u", 21477U);
                    var Output_142 = n16.Column_R.Create(Node_Context: Node_Context_141);
                    state_140.__p_UOFWBM0NplaOM45Wak0G7u = Output_142;
                }

                var Result_143 = string.IsNullOrWhiteSpace(value: Remarks_136);
                var Output_144 = !Result_143;
                var Result_145 = string.IsNullOrWhiteSpace(value: Summary_135);
                var Output_146 = !Result_145;
                var Output_147 = Output_144 || Output_146;
                n12.SpreadBuilder<n3.IWidget> __auto_148;
                var state_149 = n1.CompilationHelper.Restore<__MrN54NLCmuLON7Dzzy8SLe>(state_140.__if_HGN4baIDnHSOx5P2I7HcHC, __GetContext__());
                if (Output_146)
                {
                    if (state_149 == null)
                    {
                        state_149 = new __MrN54NLCmuLON7Dzzy8SLe(__GetContext__(), n1.VLObject.NewIdentity())
                        {__slot_VySH4V5B55uPHgbCcTyGSq = n27._Operations_.CreateDefault()};
                        n1.NodeContext Node_Context_150 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "GlPJZgMsum4PTvBkXPY0rl", 21572U);
                        var Output_151 = n16.TextWidget_MultiLine_R.Create(Node_Context: Node_Context_150);
                        state_149.__p_GlPJZgMsum4PTvBkXPY0rl = Output_151;
                        n1.NodeContext Node_Context_152 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "QbypjEbwk4zOd0VPBHgVWm", 22438U);
                        var Output_153 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_152);
                        state_149.__p_QbypjEbwk4zOd0VPBHgVWm = Output_153;
                    }

                    n17._Operations_.EnforceEndDot(Input_In: Summary_135, Output_Out: out string Output_154);
                    int Count_155 = 10;
                    bool Break_at_Words_156 = true;
                    bool Update_157 = true;
                    var Output_158 = state_149.__p_GlPJZgMsum4PTvBkXPY0rl;
                    if (Update_157)
                    {
                        Output_158 = state_149.__p_GlPJZgMsum4PTvBkXPY0rl.Update(Value_In: Output_154, Count_In: Count_155, Break_at_Words_In: Break_at_Words_156, Paint_In: Font1_17);
                    }

                    n11.Vector2 Default_Size_159 = __c_UrLrRcP62IgQIntnwv9lx4;
                    bool Update_160 = true;
                    var Output_161 = state_149.__p_QbypjEbwk4zOd0VPBHgVWm;
                    if (Update_160)
                    {
                        Output_161 = state_149.__p_QbypjEbwk4zOd0VPBHgVWm.Update(Default_Size_In: Default_Size_159);
                    }

                    n3.IWidget __pad_VySH4V5B55uPHgbCcTyGSq_162 = (n3.IWidget)Output_161;
                    n12.SpreadBuilder<n3.IWidget> Input_163 = n14._Operations_.CreateDefault<n3.IWidget>();
                    n14._Operations_.Add<n3.IWidget>(Input_In: Input_163, Item_In: __pad_VySH4V5B55uPHgbCcTyGSq_162, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_164);
                    n3.IWidget Item_165 = (n3.IWidget)Output_158;
                    n14._Operations_.Add<n3.IWidget>(Input_In: Output_164, Item_In: Item_165, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_166);
                    __auto_148 = Output_166;
                    state_149.__p_GlPJZgMsum4PTvBkXPY0rl = Output_158;
                    state_149.__p_QbypjEbwk4zOd0VPBHgVWm = Output_161;
                    state_149.__slot_VySH4V5B55uPHgbCcTyGSq = (n3.IWidget)Output_161;
                }
                else
                {
                    __auto_148 = n14._Operations_.CreateDefault<n3.IWidget>();
                }

                n12.SpreadBuilder<n3.IWidget> __auto_167;
                var state_168 = n1.CompilationHelper.Restore<__Vm8aCUhulhQPmZI9pRAsqk>(state_140.__if_Cjuv1IsRr0OP2hMC7gHVvo, __GetContext__());
                if (Output_144)
                {
                    if (state_168 == null)
                    {
                        state_168 = new __Vm8aCUhulhQPmZI9pRAsqk(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_169 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "N5A1lIm8G5jLMTamGJWfPr", 21364U);
                        var Output_170 = n16.TextWidget_MultiLine_R.Create(Node_Context: Node_Context_169);
                        state_168.__p_N5A1lIm8G5jLMTamGJWfPr = Output_170;
                        n1.NodeContext Node_Context_171 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "B1Y6ekSSuMZPQUyoMXkFqE", 21442U);
                        var Output_172 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_171);
                        state_168.__p_B1Y6ekSSuMZPQUyoMXkFqE = Output_172;
                    }

                    n17._Operations_.EnforceEndDot(Input_In: Remarks_136, Output_Out: out string Output_173);
                    int Count_174 = 10;
                    bool Break_at_Words_175 = true;
                    bool Update_176 = true;
                    var Output_177 = state_168.__p_N5A1lIm8G5jLMTamGJWfPr;
                    if (Update_176)
                    {
                        Output_177 = state_168.__p_N5A1lIm8G5jLMTamGJWfPr.Update(Value_In: Output_173, Count_In: Count_174, Break_at_Words_In: Break_at_Words_175, Paint_In: Font1_17);
                    }

                    n11.Vector2 Default_Size_178 = __c_HAgVaOyEA51QIMYTWrOD0X;
                    bool Update_179 = true;
                    var Output_180 = state_168.__p_B1Y6ekSSuMZPQUyoMXkFqE;
                    if (Update_179)
                    {
                        Output_180 = state_168.__p_B1Y6ekSSuMZPQUyoMXkFqE.Update(Default_Size_In: Default_Size_178);
                    }

                    n3.IWidget Item_181 = (n3.IWidget)Output_180;
                    n14._Operations_.Add<n3.IWidget>(Input_In: __auto_148, Item_In: Item_181, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_182);
                    n3.IWidget Item_183 = (n3.IWidget)Output_177;
                    n14._Operations_.Add<n3.IWidget>(Input_In: Output_182, Item_In: Item_183, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_184);
                    __auto_167 = Output_184;
                    state_168.__p_N5A1lIm8G5jLMTamGJWfPr = Output_177;
                    state_168.__p_B1Y6ekSSuMZPQUyoMXkFqE = Output_180;
                }
                else
                {
                    __auto_167 = __auto_148;
                }

                n15.IEnumerable<n3.IWidget> Widgets_185 = (n15.IEnumerable<n3.IWidget>)__auto_167;
                bool KeepOriginalWidth_186 = false;
                bool Update_187 = true;
                var Output_188 = state_140.__p_UOFWBM0NplaOM45Wak0G7u;
                if (Update_187)
                {
                    Output_188 = state_140.__p_UOFWBM0NplaOM45Wak0G7u.Update(Widgets_In: Widgets_185, KeepOriginalWidth_In: KeepOriginalWidth_186);
                }

                n3.IWidget __auto_189 = (n3.IWidget)Output_188;
                n3.IWidget __auto_190;
                var state_191 = n1.CompilationHelper.Restore<__Kh1Cn9qLOXbNI5zO5u2gZm>(state_140.__if_Q2xGOmnGYMDN0SjUrGiYQ3, __GetContext__());
                if (Output_147)
                {
                    if (state_191 == null)
                    {
                        state_191 = new __Kh1Cn9qLOXbNI5zO5u2gZm(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_192 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "GJfmgwr8Vp7QCmtKRtQIaZ", 22484U);
                        var Output_193 = n16.PanelWidget_R.Create(Node_Context: Node_Context_192);
                        state_191.__p_GJfmgwr8Vp7QCmtKRtQIaZ = Output_193;
                    }

                    n11.Vector2 Padding_194 = n18._Operations_.CreateDefault();
                    bool Background_Enabled_195 = false;
                    n10.SkiaPaint_R Stroke_Paint_196 = n10.SkiaPaint_R.CreateDefault();
                    bool Stroke_Enabled_197 = false;
                    bool Clip_Enabled_198 = false;
                    bool Update_199 = true;
                    var Output_200 = state_191.__p_GJfmgwr8Vp7QCmtKRtQIaZ;
                    if (Update_199)
                    {
                        Output_200 = state_191.__p_GJfmgwr8Vp7QCmtKRtQIaZ.Update(Widget_In: __auto_189, Margin_In: __pad_Jcvg65DOKAHM6r2Ts1UBLe_1, Padding_In: Padding_194, Background_Paint_In: Output_60, Background_Enabled_In: Background_Enabled_195, Stroke_Paint_In: Stroke_Paint_196, Stroke_Enabled_In: Stroke_Enabled_197, Clip_Enabled_In: Clip_Enabled_198);
                    }

                    __auto_190 = (n3.IWidget)Output_200;
                    state_191.__p_GJfmgwr8Vp7QCmtKRtQIaZ = Output_200;
                }
                else
                {
                    __auto_190 = __auto_189;
                }

                n14._Operations_.Add<n3.IWidget>(Input_In: __auto_90, Item_In: __auto_190, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_201);
                __auto_139 = Output_201;
                state_140.__if_HGN4baIDnHSOx5P2I7HcHC = state_149;
                state_140.__if_Cjuv1IsRr0OP2hMC7gHVvo = state_168;
                state_140.__p_UOFWBM0NplaOM45Wak0G7u = Output_188;
                state_140.__if_Q2xGOmnGYMDN0SjUrGiYQ3 = state_191;
                this.__if_SI5YDM2khNeN0to0OL15pD = state_140;
            }
            else
            {
                __auto_139 = __auto_90;
            }

            n12.SpreadBuilder<n3.IWidget> __auto_202;
            var state_203 = n1.CompilationHelper.Restore<__QtTNd7DI02MOJIfQDNjBCG>(this.__if_Fj7bHEkh2zgMddFFLGwnqJ, __GetContext__());
            if (Output_133)
            {
                if (state_203 == null)
                {
                    state_203 = new __QtTNd7DI02MOJIfQDNjBCG(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_204 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "VXpel2l0fTHNZjFMNNUWGA", 26309U);
                    var Output_205 = n5.MomentsWidget_C.Create(Node_Context: Node_Context_204);
                    state_203.__p_VXpel2l0fTHNZjFMNNUWGA = Output_205;
                    n1.NodeContext Node_Context_206 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "GyMkUVkHdadLzqC3AS5UBP", 26332U);
                    var Output_207 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_206);
                    state_203.__p_GyMkUVkHdadLzqC3AS5UBP = Output_207;
                    n1.NodeContext Node_Context_208 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "RrmDODjPMkENIon3pDdDw9", 26347U);
                    var Output_209 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_208);
                    state_203.__p_RrmDODjPMkENIon3pDdDw9 = Output_209;
                }

                var State_Output_211 = state_203.__p_VXpel2l0fTHNZjFMNNUWGA.Update(Input_In: Output_129, Text_Paint_In: Font1_17, Output_Out: out n16.Row_R Output_210);
                n3.IWidget Item_212 = (n3.IWidget)Output_210;
                n11.Vector2 Default_Size_213 = __c_R2HdD1giz1SLbPFJVvmZid;
                bool Update_214 = true;
                var Output_215 = state_203.__p_GyMkUVkHdadLzqC3AS5UBP;
                if (Update_214)
                {
                    Output_215 = state_203.__p_GyMkUVkHdadLzqC3AS5UBP.Update(Default_Size_In: Default_Size_213);
                }

                n3.IWidget Item_216 = (n3.IWidget)Output_215;
                n14._Operations_.Add<n3.IWidget>(Input_In: __auto_139, Item_In: Item_216, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_217);
                n14._Operations_.Add<n3.IWidget>(Input_In: Output_217, Item_In: Item_212, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_218);
                n11.Vector2 Default_Size_219 = __c_RfUmEGbVFo8P3FMgD6vyzC;
                bool Update_220 = true;
                var Output_221 = state_203.__p_RrmDODjPMkENIon3pDdDw9;
                if (Update_220)
                {
                    Output_221 = state_203.__p_RrmDODjPMkENIon3pDdDw9.Update(Default_Size_In: Default_Size_219);
                }

                n3.IWidget Item_222 = (n3.IWidget)Output_221;
                n14._Operations_.Add<n3.IWidget>(Input_In: Output_218, Item_In: Item_222, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_223);
                __auto_202 = Output_223;
                state_203.__p_VXpel2l0fTHNZjFMNNUWGA = State_Output_211;
                state_203.__p_GyMkUVkHdadLzqC3AS5UBP = Output_215;
                state_203.__p_RrmDODjPMkENIon3pDdDw9 = Output_221;
                this.__if_Fj7bHEkh2zgMddFFLGwnqJ = state_203;
            }
            else
            {
                __auto_202 = __auto_139;
            }

            n15.IEnumerable<n3.IWidget> Input_224 = (n15.IEnumerable<n3.IWidget>)__auto_202;
            string Input_2_225 = " ";
            var Output_226 = n7.StringExtensions.Plus(input: Result_26, input2: Input_2_225);
            var Output_227 = n7.StringExtensions.Plus(input: Output_226, input2: Output_10);
            string __auto_228;
            if (Output_53)
            {
                var New_Line_230 = n7.StringExtensions.NewLine;
                var Output_231 = n7.StringExtensions.Plus(input: Output_227, input2: New_Line_230);
                var Output_232 = n7.StringExtensions.Plus(input: Output_231, input2: Symbol_Source_51);
                __auto_228 = Output_232;
            }
            else
            {
                __auto_228 = Output_227;
            }

            n2.IElementInfo Input_233 = (n2.IElementInfo)Value_In;
            var Compiler_Messages_234 = Input_233.CompilerMessages;
            n4.Nullable<n1.UniqueId> OwnerElementID_235 = default(n4.Nullable<n1.UniqueId>);
            var Output_237 = this.__p_N9MhqSPzwrILHKOXHulzfi.Update(Nodename_In: __auto_228, Message_In: Compiler_Messages_234, OwnerElementID_In: OwnerElementID_235, Widgets_Out: out n12.Spread<n3.IWidget> Widgets_236);
            this.__p_N9MhqSPzwrILHKOXHulzfi = Output_237;
            n15.IEnumerable<n3.IWidget> Input_2_238 = (n15.IEnumerable<n3.IWidget>)Widgets_236;
            n21._Operations_.Concat<n3.IWidget>(Input_In: Input_224, Input_2_In: Input_2_238, Output_Out: out n15.IEnumerable<n3.IWidget> Output_239);
            bool KeepOriginalWidth_240 = false;
            bool Update_241 = true;
            var Output_242 = this.__p_KkUM4xHMiwrL3JpE5rV5PS;
            if (Update_241)
            {
                Output_242 = this.__p_KkUM4xHMiwrL3JpE5rV5PS.Update(Widgets_In: Output_239, KeepOriginalWidth_In: KeepOriginalWidth_240);
            }

            this.__p_KkUM4xHMiwrL3JpE5rV5PS = Output_242;
            n3.IWidget Widget_Out_243 = (n3.IWidget)Output_242;
            Widget_Out = Widget_Out_243;
            return this;
        }

        public n5.NodeInfoViewer_C SetObject()
        {
            return this;
        }

        public n5.NodeInfoViewer_C __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4 = n13._Operations_.CreateDefault<n3.IWidget>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "KkUM4xHMiwrL3JpE5rV5PS", 21157U);
            var Output_1 = n16.Column_R.Create(Node_Context: Node_Context_0);
            this.__p_KkUM4xHMiwrL3JpE5rV5PS = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Lc0utCdokyQL3XYlz3FRyM", 21186U);
            var Output_3 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_2);
            this.__p_Lc0utCdokyQL3XYlz3FRyM = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "JIvQerZQAAfQUUGe0NpMpd", 21233U);
            var Output_5 = n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX.Create(Node_Context: Node_Context_4);
            this.__p_JIvQerZQAAfQUUGe0NpMpd = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "IVnO8kS9eM2OgWA99HSipn", 21242U);
            var Output_7 = n16.Row_R.Create(Node_Context: Node_Context_6);
            this.__p_IVnO8kS9eM2OgWA99HSipn = Output_7;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "N9MhqSPzwrILHKOXHulzfi", 21273U);
            bool IsRuntime_9 = false;
            var Output_10 = n5.MessageWidgets_C.Create(Node_Context: Node_Context_8, IsRuntime_In: IsRuntime_9);
            this.__p_N9MhqSPzwrILHKOXHulzfi = Output_10;
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Qjs4RNIsmD9PVEuz6IXZgZ", 26038U);
            var Output_12 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_11);
            this.__p_Qjs4RNIsmD9PVEuz6IXZgZ = Output_12;
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "EavrKfgPEjbL69JsJ9P3Hb", 26097U);
            var Output_14 = n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC.Create(Node_Context: Node_Context_13);
            this.__p_EavrKfgPEjbL69JsJ9P3Hb = Output_14;
            n1.NodeContext Node_Context_15 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "BLSwC3vu8VbNbphVMXvqwu", 26251U);
            var Output_16 = n16.TagsWidget_LZd5EZDzlf3MVOiP5H1oSY.Create(Node_Context: Node_Context_15);
            this.__p_BLSwC3vu8VbNbphVMXvqwu = Output_16;
            n1.NodeContext Node_Context_17 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "ABeS9tqoIyJNJeQZQHzZdq", 26261U);
            var Output_18 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_17);
            this.__p_ABeS9tqoIyJNJeQZQHzZdq = Output_18;
            n1.NodeContext Node_Context_19 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "H6XaZMsJWLQMPEBflplfuU", 26362U);
            var Output_20 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_19);
            this.__p_H6XaZMsJWLQMPEBflplfuU = Output_20;
            this.__if_VC5CZrJHm7pPPICAB1idyo = default(n4.Object);
            this.__if_EfdwnXl8e3xLKxkAeipTD2 = default(n4.Object);
            this.__if_SI5YDM2khNeN0to0OL15pD = default(n4.Object);
            this.__if_Fj7bHEkh2zgMddFFLGwnqJ = default(n4.Object);
            return this;
        }

        public n5.NodeInfoViewer_C __CreateDefault__()
        {
            this.__pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4 = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__p_H6XaZMsJWLQMPEBflplfuU = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__p_Qjs4RNIsmD9PVEuz6IXZgZ = n16.TextWidget_SingleLine_R.CreateDefault();
            this.__p_Lc0utCdokyQL3XYlz3FRyM = n16.TextWidget_SingleLine_R.CreateDefault();
            this.__p_ABeS9tqoIyJNJeQZQHzZdq = n16.EmptyWidget_R.CreateDefault();
            this.__p_BLSwC3vu8VbNbphVMXvqwu = n16.TagsWidget_LZd5EZDzlf3MVOiP5H1oSY.CreateDefault();
            this.__p_JIvQerZQAAfQUUGe0NpMpd = n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX.CreateDefault();
            this.__p_IVnO8kS9eM2OgWA99HSipn = n16.Row_R.CreateDefault();
            this.__p_EavrKfgPEjbL69JsJ9P3Hb = n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC.CreateDefault();
            this.__if_VC5CZrJHm7pPPICAB1idyo = default(n4.Object);
            this.__if_EfdwnXl8e3xLKxkAeipTD2 = default(n4.Object);
            this.__if_SI5YDM2khNeN0to0OL15pD = default(n4.Object);
            this.__if_Fj7bHEkh2zgMddFFLGwnqJ = default(n4.Object);
            this.__p_N9MhqSPzwrILHKOXHulzfi = n5.MessageWidgets_C.CreateDefault();
            this.__p_KkUM4xHMiwrL3JpE5rV5PS = n16.Column_R.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_H6XaZMsJWLQMPEBflplfuU);
            n1.CompilationHelper.SafeDispose(this.__p_Qjs4RNIsmD9PVEuz6IXZgZ);
            n1.CompilationHelper.SafeDispose(this.__p_Lc0utCdokyQL3XYlz3FRyM);
            n1.CompilationHelper.SafeDispose(this.__p_ABeS9tqoIyJNJeQZQHzZdq);
            n1.CompilationHelper.SafeDispose(this.__p_BLSwC3vu8VbNbphVMXvqwu);
            n1.CompilationHelper.SafeDispose(this.__p_JIvQerZQAAfQUUGe0NpMpd);
            n1.CompilationHelper.SafeDispose(this.__p_IVnO8kS9eM2OgWA99HSipn);
            n1.CompilationHelper.SafeDispose(this.__p_EavrKfgPEjbL69JsJ9P3Hb);
            n1.CompilationHelper.SafeDispose(this.__if_VC5CZrJHm7pPPICAB1idyo);
            n1.CompilationHelper.SafeDispose(this.__if_EfdwnXl8e3xLKxkAeipTD2);
            n1.CompilationHelper.SafeDispose(this.__if_SI5YDM2khNeN0to0OL15pD);
            n1.CompilationHelper.SafeDispose(this.__if_Fj7bHEkh2zgMddFFLGwnqJ);
            n1.CompilationHelper.SafeDispose(this.__p_N9MhqSPzwrILHKOXHulzfi);
            n1.CompilationHelper.SafeDispose(this.__p_KkUM4xHMiwrL3JpE5rV5PS);
            return;
        }

        void n3.IValueViewer<n2.INodeInfo>.Update(n2.INodeInfo value, n3.ViewerContext context, out n3.IWidget widget)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(value, context, out widget);
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 26010U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Jj68ip3pJOxMv9GQG9mbVI", Name = "__slot_Jj68ip3pJOxMv9GQG9mbVI")]
        public static string __slot_Jj68ip3pJOxMv9GQG9mbVI = "<< currently not working for nodes";
        [n1.ElementAttribute(TracingId = 26092U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Jcvg65DOKAHM6r2Ts1UBLe", Name = "__slot_Jcvg65DOKAHM6r2Ts1UBLe")]
        public static n11.Vector2 __slot_Jcvg65DOKAHM6r2Ts1UBLe = n1.CompilationHelper.Deserialize<n11.Vector2>("0.11, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "Jcvg65DOKAHM6r2Ts1UBLe");
        [n1.ElementAttribute(TracingId = 26233U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Q60umDXpUfxOENEys3s0D2", Name = "__slot_Q60umDXpUfxOENEys3s0D2")]
        public static n11.Vector2 __slot_Q60umDXpUfxOENEys3s0D2 = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.02", false, "QsvwBVssT9xLO3Td5ph2Z9", "Q60umDXpUfxOENEys3s0D2");
        [n1.ElementAttribute(TracingId = 26577U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "FvWxOA253DhPvoGp2qlc7R", Name = "__slot_FvWxOA253DhPvoGp2qlc7R")]
        public static n11.Vector2 __slot_FvWxOA253DhPvoGp2qlc7R = n1.CompilationHelper.Deserialize<n11.Vector2>("0.11, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "FvWxOA253DhPvoGp2qlc7R");
        [n1.ElementAttribute(TracingId = 26362U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "H6XaZMsJWLQMPEBflplfuU", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_H6XaZMsJWLQMPEBflplfuU;
        [n1.ElementAttribute(TracingId = 26038U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Qjs4RNIsmD9PVEuz6IXZgZ", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
        public n16.TextWidget_SingleLine_R __p_Qjs4RNIsmD9PVEuz6IXZgZ;
        [n1.ElementAttribute(TracingId = 21186U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Lc0utCdokyQL3XYlz3FRyM", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
        public n16.TextWidget_SingleLine_R __p_Lc0utCdokyQL3XYlz3FRyM;
        [n1.ElementAttribute(TracingId = 26261U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "ABeS9tqoIyJNJeQZQHzZdq", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.EmptyWidget_R __p_ABeS9tqoIyJNJeQZQHzZdq;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_BvIxclZ3XE0MbHNIGl9sFd = n1.CompilationHelper.Deserialize<n11.Vector2>("0.06, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "BvIxclZ3XE0MbHNIGl9sFd");
        [n1.ElementAttribute(TracingId = 26251U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "BLSwC3vu8VbNbphVMXvqwu", Name = "TagsWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.TagsWidget_LZd5EZDzlf3MVOiP5H1oSY __p_BLSwC3vu8VbNbphVMXvqwu;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n3.IWidget> __pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4 = default(n12.Spread<n3.IWidget>);
        [n1.ElementAttribute(TracingId = 21233U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "JIvQerZQAAfQUUGe0NpMpd", Name = "AppendIDWidget", IsManaged = true, IsAutoGenerated = true)]
        public n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX __p_JIvQerZQAAfQUUGe0NpMpd;
        [n1.ElementAttribute(TracingId = 21242U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "IVnO8kS9eM2OgWA99HSipn", Name = "Row", IsManaged = true, IsAutoGenerated = true)]
        public n16.Row_R __p_IVnO8kS9eM2OgWA99HSipn;
        [n1.ElementAttribute(TracingId = 26097U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "EavrKfgPEjbL69JsJ9P3Hb", Name = "Fill", IsManaged = true, IsAutoGenerated = true)]
        public n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_EavrKfgPEjbL69JsJ9P3Hb;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Color4 __c_SoJ5Lgz2RmTOTnMNKJDCg1 = n1.CompilationHelper.Deserialize<n11.Color4>("0.435666, 0.69, 0.02069998, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "SoJ5Lgz2RmTOTnMNKJDCg1");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_VC5CZrJHm7pPPICAB1idyo;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_HwrK8NRp7uIP3HNmTcfB3x = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.05", false, "QsvwBVssT9xLO3Td5ph2Z9", "HwrK8NRp7uIP3HNmTcfB3x");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_EfdwnXl8e3xLKxkAeipTD2;
        [n1.ElementAttribute(TracingId = 26443U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Dlc4Fm0SFIbLeZVIIHJ9QD", Name = "__slot_Dlc4Fm0SFIbLeZVIIHJ9QD")]
        public static string __slot_Dlc4Fm0SFIbLeZVIIHJ9QD = "Create";
        [n1.ElementAttribute(TracingId = 26465U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Uir4i3omxrvNNr2yuhwAci", Name = "__slot_Uir4i3omxrvNNr2yuhwAci")]
        public static string __slot_Uir4i3omxrvNNr2yuhwAci = "Update";
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_UrLrRcP62IgQIntnwv9lx4 = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.02", false, "QsvwBVssT9xLO3Td5ph2Z9", "UrLrRcP62IgQIntnwv9lx4");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_HAgVaOyEA51QIMYTWrOD0X = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.02", false, "QsvwBVssT9xLO3Td5ph2Z9", "HAgVaOyEA51QIMYTWrOD0X");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_SI5YDM2khNeN0to0OL15pD;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_R2HdD1giz1SLbPFJVvmZid = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.05", false, "QsvwBVssT9xLO3Td5ph2Z9", "R2HdD1giz1SLbPFJVvmZid");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_RfUmEGbVFo8P3FMgD6vyzC = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.02", false, "QsvwBVssT9xLO3Td5ph2Z9", "RfUmEGbVFo8P3FMgD6vyzC");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_Fj7bHEkh2zgMddFFLGwnqJ;
        [n1.ElementAttribute(TracingId = 21273U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "N9MhqSPzwrILHKOXHulzfi", Name = "MessageWidgets", IsManaged = true, IsAutoGenerated = true)]
        public n5.MessageWidgets_C __p_N9MhqSPzwrILHKOXHulzfi;
        [n1.ElementAttribute(TracingId = 21157U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "KkUM4xHMiwrL3JpE5rV5PS", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
        public n16.Column_R __p_KkUM4xHMiwrL3JpE5rV5PS;
        static NodeInfoViewer_C()
        {
        }

        public NodeInfoViewer_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal NodeInfoViewer_C(NodeInfoViewer_C other): base(other)
        {
            this.__p_H6XaZMsJWLQMPEBflplfuU = other.__p_H6XaZMsJWLQMPEBflplfuU;
            this.__p_Qjs4RNIsmD9PVEuz6IXZgZ = other.__p_Qjs4RNIsmD9PVEuz6IXZgZ;
            this.__p_Lc0utCdokyQL3XYlz3FRyM = other.__p_Lc0utCdokyQL3XYlz3FRyM;
            this.__p_ABeS9tqoIyJNJeQZQHzZdq = other.__p_ABeS9tqoIyJNJeQZQHzZdq;
            this.__p_BLSwC3vu8VbNbphVMXvqwu = other.__p_BLSwC3vu8VbNbphVMXvqwu;
            this.__pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4 = other.__pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4;
            this.__p_JIvQerZQAAfQUUGe0NpMpd = other.__p_JIvQerZQAAfQUUGe0NpMpd;
            this.__p_IVnO8kS9eM2OgWA99HSipn = other.__p_IVnO8kS9eM2OgWA99HSipn;
            this.__p_EavrKfgPEjbL69JsJ9P3Hb = other.__p_EavrKfgPEjbL69JsJ9P3Hb;
            this.__if_VC5CZrJHm7pPPICAB1idyo = other.__if_VC5CZrJHm7pPPICAB1idyo;
            this.__if_EfdwnXl8e3xLKxkAeipTD2 = other.__if_EfdwnXl8e3xLKxkAeipTD2;
            this.__if_SI5YDM2khNeN0to0OL15pD = other.__if_SI5YDM2khNeN0to0OL15pD;
            this.__if_Fj7bHEkh2zgMddFFLGwnqJ = other.__if_Fj7bHEkh2zgMddFFLGwnqJ;
            this.__p_N9MhqSPzwrILHKOXHulzfi = other.__p_N9MhqSPzwrILHKOXHulzfi;
            this.__p_KkUM4xHMiwrL3JpE5rV5PS = other.__p_KkUM4xHMiwrL3JpE5rV5PS;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_H6XaZMsJWLQMPEBflplfuU", in __p_H6XaZMsJWLQMPEBflplfuU), n1.CompilationHelper.GetValueOrExisting(values, "__p_Qjs4RNIsmD9PVEuz6IXZgZ", in __p_Qjs4RNIsmD9PVEuz6IXZgZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_Lc0utCdokyQL3XYlz3FRyM", in __p_Lc0utCdokyQL3XYlz3FRyM), n1.CompilationHelper.GetValueOrExisting(values, "__p_ABeS9tqoIyJNJeQZQHzZdq", in __p_ABeS9tqoIyJNJeQZQHzZdq), n1.CompilationHelper.GetValueOrExisting(values, "__p_BLSwC3vu8VbNbphVMXvqwu", in __p_BLSwC3vu8VbNbphVMXvqwu), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4", in __pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4), n1.CompilationHelper.GetValueOrExisting(values, "__p_JIvQerZQAAfQUUGe0NpMpd", in __p_JIvQerZQAAfQUUGe0NpMpd), n1.CompilationHelper.GetValueOrExisting(values, "__p_IVnO8kS9eM2OgWA99HSipn", in __p_IVnO8kS9eM2OgWA99HSipn), n1.CompilationHelper.GetValueOrExisting(values, "__p_EavrKfgPEjbL69JsJ9P3Hb", in __p_EavrKfgPEjbL69JsJ9P3Hb), n1.CompilationHelper.GetValueOrExisting(values, "__if_VC5CZrJHm7pPPICAB1idyo", in __if_VC5CZrJHm7pPPICAB1idyo), n1.CompilationHelper.GetValueOrExisting(values, "__if_EfdwnXl8e3xLKxkAeipTD2", in __if_EfdwnXl8e3xLKxkAeipTD2), n1.CompilationHelper.GetValueOrExisting(values, "__if_SI5YDM2khNeN0to0OL15pD", in __if_SI5YDM2khNeN0to0OL15pD), n1.CompilationHelper.GetValueOrExisting(values, "__if_Fj7bHEkh2zgMddFFLGwnqJ", in __if_Fj7bHEkh2zgMddFFLGwnqJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_N9MhqSPzwrILHKOXHulzfi", in __p_N9MhqSPzwrILHKOXHulzfi), n1.CompilationHelper.GetValueOrExisting(values, "__p_KkUM4xHMiwrL3JpE5rV5PS", in __p_KkUM4xHMiwrL3JpE5rV5PS));
        }

        internal NodeInfoViewer_C __WITH__(n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_H6XaZMsJWLQMPEBflplfuU, n16.TextWidget_SingleLine_R __p_Qjs4RNIsmD9PVEuz6IXZgZ, n16.TextWidget_SingleLine_R __p_Lc0utCdokyQL3XYlz3FRyM, n16.EmptyWidget_R __p_ABeS9tqoIyJNJeQZQHzZdq, n16.TagsWidget_LZd5EZDzlf3MVOiP5H1oSY __p_BLSwC3vu8VbNbphVMXvqwu, n12.Spread<n3.IWidget> __pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4, n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX __p_JIvQerZQAAfQUUGe0NpMpd, n16.Row_R __p_IVnO8kS9eM2OgWA99HSipn, n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_EavrKfgPEjbL69JsJ9P3Hb, n4.Object __if_VC5CZrJHm7pPPICAB1idyo, n4.Object __if_EfdwnXl8e3xLKxkAeipTD2, n4.Object __if_SI5YDM2khNeN0to0OL15pD, n4.Object __if_Fj7bHEkh2zgMddFFLGwnqJ, n5.MessageWidgets_C __p_N9MhqSPzwrILHKOXHulzfi, n16.Column_R __p_KkUM4xHMiwrL3JpE5rV5PS)
        {
            n5.NodeInfoViewer_C that_0 = this;
            this.__p_H6XaZMsJWLQMPEBflplfuU = __p_H6XaZMsJWLQMPEBflplfuU;
            this.__p_Qjs4RNIsmD9PVEuz6IXZgZ = __p_Qjs4RNIsmD9PVEuz6IXZgZ;
            this.__p_Lc0utCdokyQL3XYlz3FRyM = __p_Lc0utCdokyQL3XYlz3FRyM;
            this.__p_ABeS9tqoIyJNJeQZQHzZdq = __p_ABeS9tqoIyJNJeQZQHzZdq;
            this.__p_BLSwC3vu8VbNbphVMXvqwu = __p_BLSwC3vu8VbNbphVMXvqwu;
            this.__pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4 = __pin_group_Input_In_GxgqWsdctwLLjw8pdKlzR4;
            this.__p_JIvQerZQAAfQUUGe0NpMpd = __p_JIvQerZQAAfQUUGe0NpMpd;
            this.__p_IVnO8kS9eM2OgWA99HSipn = __p_IVnO8kS9eM2OgWA99HSipn;
            this.__p_EavrKfgPEjbL69JsJ9P3Hb = __p_EavrKfgPEjbL69JsJ9P3Hb;
            this.__if_VC5CZrJHm7pPPICAB1idyo = __if_VC5CZrJHm7pPPICAB1idyo;
            this.__if_EfdwnXl8e3xLKxkAeipTD2 = __if_EfdwnXl8e3xLKxkAeipTD2;
            this.__if_SI5YDM2khNeN0to0OL15pD = __if_SI5YDM2khNeN0to0OL15pD;
            this.__if_Fj7bHEkh2zgMddFFLGwnqJ = __if_Fj7bHEkh2zgMddFFLGwnqJ;
            this.__p_N9MhqSPzwrILHKOXHulzfi = __p_N9MhqSPzwrILHKOXHulzfi;
            this.__p_KkUM4xHMiwrL3JpE5rV5PS = __p_KkUM4xHMiwrL3JpE5rV5PS;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "QQvrK5ZybEHOmMJqTd7Pk5", Name = "__QQvrK5ZybEHOmMJqTd7Pk5")]
        [n4.SerializableAttribute]
        public class __QQvrK5ZybEHOmMJqTd7Pk5 : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_F3QG7gu41OqNg7wpup3KTq);
                n1.CompilationHelper.SafeDispose(this.__p_FsGxaORJDh7O1wZn4eSq0F);
                return;
            }

            [n1.ElementAttribute(TracingId = 26153U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "F3QG7gu41OqNg7wpup3KTq", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_SingleLine_R __p_F3QG7gu41OqNg7wpup3KTq;
            [n1.ElementAttribute(TracingId = 26211U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "FsGxaORJDh7O1wZn4eSq0F", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.PanelWidget_R __p_FsGxaORJDh7O1wZn4eSq0F;
            public __QQvrK5ZybEHOmMJqTd7Pk5(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __QQvrK5ZybEHOmMJqTd7Pk5(__QQvrK5ZybEHOmMJqTd7Pk5 other): base(other)
            {
                this.__p_F3QG7gu41OqNg7wpup3KTq = other.__p_F3QG7gu41OqNg7wpup3KTq;
                this.__p_FsGxaORJDh7O1wZn4eSq0F = other.__p_FsGxaORJDh7O1wZn4eSq0F;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_F3QG7gu41OqNg7wpup3KTq", in __p_F3QG7gu41OqNg7wpup3KTq), n1.CompilationHelper.GetValueOrExisting(values, "__p_FsGxaORJDh7O1wZn4eSq0F", in __p_FsGxaORJDh7O1wZn4eSq0F));
            }

            internal __QQvrK5ZybEHOmMJqTd7Pk5 __WITH__(n16.TextWidget_SingleLine_R __p_F3QG7gu41OqNg7wpup3KTq, n16.PanelWidget_R __p_FsGxaORJDh7O1wZn4eSq0F)
            {
                __QQvrK5ZybEHOmMJqTd7Pk5 that_0 = this;
                this.__p_F3QG7gu41OqNg7wpup3KTq = __p_F3QG7gu41OqNg7wpup3KTq;
                this.__p_FsGxaORJDh7O1wZn4eSq0F = __p_FsGxaORJDh7O1wZn4eSq0F;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VxE0Gg4qlg9L9SerI9UHNv", Name = "__VxE0Gg4qlg9L9SerI9UHNv")]
        [n4.SerializableAttribute]
        public class __VxE0Gg4qlg9L9SerI9UHNv : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_DfIpaJLGsAwPm2GZMNhiXb);
                n1.CompilationHelper.SafeDispose(this.__p_Oe0EmXWDexQOeT4oOIIn0b);
                n1.CompilationHelper.SafeDispose(this.__p_GLNR0o1bWYkOtYCDinH76L);
                return;
            }

            [n1.ElementAttribute(TracingId = 26506U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "DfIpaJLGsAwPm2GZMNhiXb", Name = "TagsWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.TagsWidget_LZd5EZDzlf3MVOiP5H1oSY __p_DfIpaJLGsAwPm2GZMNhiXb;
            [n1.ElementAttribute(TracingId = 26535U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Oe0EmXWDexQOeT4oOIIn0b", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.PanelWidget_R __p_Oe0EmXWDexQOeT4oOIIn0b;
            [n1.ElementAttribute(TracingId = 26559U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "GLNR0o1bWYkOtYCDinH76L", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_GLNR0o1bWYkOtYCDinH76L;
            public __VxE0Gg4qlg9L9SerI9UHNv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __VxE0Gg4qlg9L9SerI9UHNv(__VxE0Gg4qlg9L9SerI9UHNv other): base(other)
            {
                this.__p_DfIpaJLGsAwPm2GZMNhiXb = other.__p_DfIpaJLGsAwPm2GZMNhiXb;
                this.__p_Oe0EmXWDexQOeT4oOIIn0b = other.__p_Oe0EmXWDexQOeT4oOIIn0b;
                this.__p_GLNR0o1bWYkOtYCDinH76L = other.__p_GLNR0o1bWYkOtYCDinH76L;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DfIpaJLGsAwPm2GZMNhiXb", in __p_DfIpaJLGsAwPm2GZMNhiXb), n1.CompilationHelper.GetValueOrExisting(values, "__p_Oe0EmXWDexQOeT4oOIIn0b", in __p_Oe0EmXWDexQOeT4oOIIn0b), n1.CompilationHelper.GetValueOrExisting(values, "__p_GLNR0o1bWYkOtYCDinH76L", in __p_GLNR0o1bWYkOtYCDinH76L));
            }

            internal __VxE0Gg4qlg9L9SerI9UHNv __WITH__(n16.TagsWidget_LZd5EZDzlf3MVOiP5H1oSY __p_DfIpaJLGsAwPm2GZMNhiXb, n16.PanelWidget_R __p_Oe0EmXWDexQOeT4oOIIn0b, n16.EmptyWidget_R __p_GLNR0o1bWYkOtYCDinH76L)
            {
                __VxE0Gg4qlg9L9SerI9UHNv that_0 = this;
                this.__p_DfIpaJLGsAwPm2GZMNhiXb = __p_DfIpaJLGsAwPm2GZMNhiXb;
                this.__p_Oe0EmXWDexQOeT4oOIIn0b = __p_Oe0EmXWDexQOeT4oOIIn0b;
                this.__p_GLNR0o1bWYkOtYCDinH76L = __p_GLNR0o1bWYkOtYCDinH76L;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "RSzt6znSZaSNKcAscCy7mN", Name = "__RSzt6znSZaSNKcAscCy7mN")]
        [n4.SerializableAttribute]
        public class __RSzt6znSZaSNKcAscCy7mN : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UOFWBM0NplaOM45Wak0G7u);
                n1.CompilationHelper.SafeDispose(this.__if_HGN4baIDnHSOx5P2I7HcHC);
                n1.CompilationHelper.SafeDispose(this.__if_Cjuv1IsRr0OP2hMC7gHVvo);
                n1.CompilationHelper.SafeDispose(this.__if_Q2xGOmnGYMDN0SjUrGiYQ3);
                return;
            }

            [n1.ElementAttribute(TracingId = 21477U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "UOFWBM0NplaOM45Wak0G7u", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
            public n16.Column_R __p_UOFWBM0NplaOM45Wak0G7u;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n4.Object __if_HGN4baIDnHSOx5P2I7HcHC;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n4.Object __if_Cjuv1IsRr0OP2hMC7gHVvo;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n4.Object __if_Q2xGOmnGYMDN0SjUrGiYQ3;
            public __RSzt6znSZaSNKcAscCy7mN(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RSzt6znSZaSNKcAscCy7mN(__RSzt6znSZaSNKcAscCy7mN other): base(other)
            {
                this.__p_UOFWBM0NplaOM45Wak0G7u = other.__p_UOFWBM0NplaOM45Wak0G7u;
                this.__if_HGN4baIDnHSOx5P2I7HcHC = other.__if_HGN4baIDnHSOx5P2I7HcHC;
                this.__if_Cjuv1IsRr0OP2hMC7gHVvo = other.__if_Cjuv1IsRr0OP2hMC7gHVvo;
                this.__if_Q2xGOmnGYMDN0SjUrGiYQ3 = other.__if_Q2xGOmnGYMDN0SjUrGiYQ3;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UOFWBM0NplaOM45Wak0G7u", in __p_UOFWBM0NplaOM45Wak0G7u), n1.CompilationHelper.GetValueOrExisting(values, "__if_HGN4baIDnHSOx5P2I7HcHC", in __if_HGN4baIDnHSOx5P2I7HcHC), n1.CompilationHelper.GetValueOrExisting(values, "__if_Cjuv1IsRr0OP2hMC7gHVvo", in __if_Cjuv1IsRr0OP2hMC7gHVvo), n1.CompilationHelper.GetValueOrExisting(values, "__if_Q2xGOmnGYMDN0SjUrGiYQ3", in __if_Q2xGOmnGYMDN0SjUrGiYQ3));
            }

            internal __RSzt6znSZaSNKcAscCy7mN __WITH__(n16.Column_R __p_UOFWBM0NplaOM45Wak0G7u, n4.Object __if_HGN4baIDnHSOx5P2I7HcHC, n4.Object __if_Cjuv1IsRr0OP2hMC7gHVvo, n4.Object __if_Q2xGOmnGYMDN0SjUrGiYQ3)
            {
                __RSzt6znSZaSNKcAscCy7mN that_0 = this;
                this.__p_UOFWBM0NplaOM45Wak0G7u = __p_UOFWBM0NplaOM45Wak0G7u;
                this.__if_HGN4baIDnHSOx5P2I7HcHC = __if_HGN4baIDnHSOx5P2I7HcHC;
                this.__if_Cjuv1IsRr0OP2hMC7gHVvo = __if_Cjuv1IsRr0OP2hMC7gHVvo;
                this.__if_Q2xGOmnGYMDN0SjUrGiYQ3 = __if_Q2xGOmnGYMDN0SjUrGiYQ3;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "MrN54NLCmuLON7Dzzy8SLe", Name = "__MrN54NLCmuLON7Dzzy8SLe")]
        [n4.SerializableAttribute]
        public class __MrN54NLCmuLON7Dzzy8SLe : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_GlPJZgMsum4PTvBkXPY0rl);
                n1.CompilationHelper.SafeDispose(this.__p_QbypjEbwk4zOd0VPBHgVWm);
                return;
            }

            [n1.ElementAttribute(TracingId = 21572U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "GlPJZgMsum4PTvBkXPY0rl", Name = "TextWidget (MultiLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_MultiLine_R __p_GlPJZgMsum4PTvBkXPY0rl;
            [n1.ElementAttribute(TracingId = 22438U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "QbypjEbwk4zOd0VPBHgVWm", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_QbypjEbwk4zOd0VPBHgVWm;
            [n1.ElementAttribute(TracingId = 22448U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VySH4V5B55uPHgbCcTyGSq", Name = "__slot_VySH4V5B55uPHgbCcTyGSq")]
            public n3.IWidget __slot_VySH4V5B55uPHgbCcTyGSq;
            public __MrN54NLCmuLON7Dzzy8SLe(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MrN54NLCmuLON7Dzzy8SLe(__MrN54NLCmuLON7Dzzy8SLe other): base(other)
            {
                this.__p_GlPJZgMsum4PTvBkXPY0rl = other.__p_GlPJZgMsum4PTvBkXPY0rl;
                this.__p_QbypjEbwk4zOd0VPBHgVWm = other.__p_QbypjEbwk4zOd0VPBHgVWm;
                this.__slot_VySH4V5B55uPHgbCcTyGSq = other.__slot_VySH4V5B55uPHgbCcTyGSq;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_GlPJZgMsum4PTvBkXPY0rl", in __p_GlPJZgMsum4PTvBkXPY0rl), n1.CompilationHelper.GetValueOrExisting(values, "__p_QbypjEbwk4zOd0VPBHgVWm", in __p_QbypjEbwk4zOd0VPBHgVWm), n1.CompilationHelper.GetValueOrExisting(values, "__slot_VySH4V5B55uPHgbCcTyGSq", in __slot_VySH4V5B55uPHgbCcTyGSq));
            }

            internal __MrN54NLCmuLON7Dzzy8SLe __WITH__(n16.TextWidget_MultiLine_R __p_GlPJZgMsum4PTvBkXPY0rl, n16.EmptyWidget_R __p_QbypjEbwk4zOd0VPBHgVWm, n3.IWidget __slot_VySH4V5B55uPHgbCcTyGSq)
            {
                __MrN54NLCmuLON7Dzzy8SLe that_0 = this;
                this.__p_GlPJZgMsum4PTvBkXPY0rl = __p_GlPJZgMsum4PTvBkXPY0rl;
                this.__p_QbypjEbwk4zOd0VPBHgVWm = __p_QbypjEbwk4zOd0VPBHgVWm;
                this.__slot_VySH4V5B55uPHgbCcTyGSq = __slot_VySH4V5B55uPHgbCcTyGSq;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Vm8aCUhulhQPmZI9pRAsqk", Name = "__Vm8aCUhulhQPmZI9pRAsqk")]
        [n4.SerializableAttribute]
        public class __Vm8aCUhulhQPmZI9pRAsqk : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_N5A1lIm8G5jLMTamGJWfPr);
                n1.CompilationHelper.SafeDispose(this.__p_B1Y6ekSSuMZPQUyoMXkFqE);
                return;
            }

            [n1.ElementAttribute(TracingId = 21364U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "N5A1lIm8G5jLMTamGJWfPr", Name = "TextWidget (MultiLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_MultiLine_R __p_N5A1lIm8G5jLMTamGJWfPr;
            [n1.ElementAttribute(TracingId = 21442U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "B1Y6ekSSuMZPQUyoMXkFqE", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_B1Y6ekSSuMZPQUyoMXkFqE;
            public __Vm8aCUhulhQPmZI9pRAsqk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Vm8aCUhulhQPmZI9pRAsqk(__Vm8aCUhulhQPmZI9pRAsqk other): base(other)
            {
                this.__p_N5A1lIm8G5jLMTamGJWfPr = other.__p_N5A1lIm8G5jLMTamGJWfPr;
                this.__p_B1Y6ekSSuMZPQUyoMXkFqE = other.__p_B1Y6ekSSuMZPQUyoMXkFqE;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_N5A1lIm8G5jLMTamGJWfPr", in __p_N5A1lIm8G5jLMTamGJWfPr), n1.CompilationHelper.GetValueOrExisting(values, "__p_B1Y6ekSSuMZPQUyoMXkFqE", in __p_B1Y6ekSSuMZPQUyoMXkFqE));
            }

            internal __Vm8aCUhulhQPmZI9pRAsqk __WITH__(n16.TextWidget_MultiLine_R __p_N5A1lIm8G5jLMTamGJWfPr, n16.EmptyWidget_R __p_B1Y6ekSSuMZPQUyoMXkFqE)
            {
                __Vm8aCUhulhQPmZI9pRAsqk that_0 = this;
                this.__p_N5A1lIm8G5jLMTamGJWfPr = __p_N5A1lIm8G5jLMTamGJWfPr;
                this.__p_B1Y6ekSSuMZPQUyoMXkFqE = __p_B1Y6ekSSuMZPQUyoMXkFqE;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Kh1Cn9qLOXbNI5zO5u2gZm", Name = "__Kh1Cn9qLOXbNI5zO5u2gZm")]
        [n4.SerializableAttribute]
        public class __Kh1Cn9qLOXbNI5zO5u2gZm : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_GJfmgwr8Vp7QCmtKRtQIaZ);
                return;
            }

            [n1.ElementAttribute(TracingId = 22484U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "GJfmgwr8Vp7QCmtKRtQIaZ", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.PanelWidget_R __p_GJfmgwr8Vp7QCmtKRtQIaZ;
            public __Kh1Cn9qLOXbNI5zO5u2gZm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Kh1Cn9qLOXbNI5zO5u2gZm(__Kh1Cn9qLOXbNI5zO5u2gZm other): base(other)
            {
                this.__p_GJfmgwr8Vp7QCmtKRtQIaZ = other.__p_GJfmgwr8Vp7QCmtKRtQIaZ;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_GJfmgwr8Vp7QCmtKRtQIaZ", in __p_GJfmgwr8Vp7QCmtKRtQIaZ));
            }

            internal __Kh1Cn9qLOXbNI5zO5u2gZm __WITH__(n16.PanelWidget_R __p_GJfmgwr8Vp7QCmtKRtQIaZ)
            {
                __Kh1Cn9qLOXbNI5zO5u2gZm that_0 = this;
                this.__p_GJfmgwr8Vp7QCmtKRtQIaZ = __p_GJfmgwr8Vp7QCmtKRtQIaZ;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "QtTNd7DI02MOJIfQDNjBCG", Name = "__QtTNd7DI02MOJIfQDNjBCG")]
        [n4.SerializableAttribute]
        public class __QtTNd7DI02MOJIfQDNjBCG : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_VXpel2l0fTHNZjFMNNUWGA);
                n1.CompilationHelper.SafeDispose(this.__p_GyMkUVkHdadLzqC3AS5UBP);
                n1.CompilationHelper.SafeDispose(this.__p_RrmDODjPMkENIon3pDdDw9);
                return;
            }

            [n1.ElementAttribute(TracingId = 26309U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VXpel2l0fTHNZjFMNNUWGA", Name = "MomentsWidget", IsManaged = true, IsAutoGenerated = true)]
            public n5.MomentsWidget_C __p_VXpel2l0fTHNZjFMNNUWGA;
            [n1.ElementAttribute(TracingId = 26332U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "GyMkUVkHdadLzqC3AS5UBP", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_GyMkUVkHdadLzqC3AS5UBP;
            [n1.ElementAttribute(TracingId = 26347U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "RrmDODjPMkENIon3pDdDw9", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_RrmDODjPMkENIon3pDdDw9;
            public __QtTNd7DI02MOJIfQDNjBCG(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __QtTNd7DI02MOJIfQDNjBCG(__QtTNd7DI02MOJIfQDNjBCG other): base(other)
            {
                this.__p_VXpel2l0fTHNZjFMNNUWGA = other.__p_VXpel2l0fTHNZjFMNNUWGA;
                this.__p_GyMkUVkHdadLzqC3AS5UBP = other.__p_GyMkUVkHdadLzqC3AS5UBP;
                this.__p_RrmDODjPMkENIon3pDdDw9 = other.__p_RrmDODjPMkENIon3pDdDw9;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VXpel2l0fTHNZjFMNNUWGA", in __p_VXpel2l0fTHNZjFMNNUWGA), n1.CompilationHelper.GetValueOrExisting(values, "__p_GyMkUVkHdadLzqC3AS5UBP", in __p_GyMkUVkHdadLzqC3AS5UBP), n1.CompilationHelper.GetValueOrExisting(values, "__p_RrmDODjPMkENIon3pDdDw9", in __p_RrmDODjPMkENIon3pDdDw9));
            }

            internal __QtTNd7DI02MOJIfQDNjBCG __WITH__(n5.MomentsWidget_C __p_VXpel2l0fTHNZjFMNNUWGA, n16.EmptyWidget_R __p_GyMkUVkHdadLzqC3AS5UBP, n16.EmptyWidget_R __p_RrmDODjPMkENIon3pDdDw9)
            {
                __QtTNd7DI02MOJIfQDNjBCG that_0 = this;
                this.__p_VXpel2l0fTHNZjFMNNUWGA = __p_VXpel2l0fTHNZjFMNNUWGA;
                this.__p_GyMkUVkHdadLzqC3AS5UBP = __p_GyMkUVkHdadLzqC3AS5UBP;
                this.__p_RrmDODjPMkENIon3pDdDw9 = __p_RrmDODjPMkENIon3pDdDw9;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 33086U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "JEP7dJaqIRWNQyn2m7UCDX", Name = "AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX")]
    [n4.SerializableAttribute]
    public class AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX : n1.VLObject, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX Create(n1.NodeContext Node_Context)
        {
            var instance = new AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX CreateDefault()
        {
            var instance = new AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX Update(n12.Spread<n3.IWidget> Input_In, n2.IElementInfo Info_In, n10.SkiaPaint_R Paint_In, out n12.Spread<n3.IWidget> Output_Out)
        {
            bool __pad_QMuy0BxqDbWOhoyawjZG1o_0 = __slot_QMuy0BxqDbWOhoyawjZG1o;
            var Element_ID_1 = Info_In.ElementID;
            n29._Operations_.HasValue<uint>(Input_In: Element_ID_1, Output_Out: out n4.Nullable<uint> Output_2, Has_Value_Out: out bool Has_Value_3);
            n24._Operations_.TooltipShowLocalID(Value_Out: out bool Value_4, Tooltip_Show_Local_ID_Out: out n23.BehaviorSubject<bool> Tooltip_Show_Local_ID_5);
            var Output_6 = Has_Value_3 && Value_4;
            n12.Spread<n3.IWidget> __auto_7;
            var state_8 = n1.CompilationHelper.Restore<__Sm45DzAGEjJMjWaWffbShJ>(this.__if_Q0CVz1ZSamENVYdnn0Pm92, __GetContext__());
            if (Output_6)
            {
                if (state_8 == null)
                {
                    state_8 = new __Sm45DzAGEjJMjWaWffbShJ(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Sd3SeOar1KDQFEfoTNYJQB", 33169U);
                    var Output_10 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_9);
                    state_8.__p_Sd3SeOar1KDQFEfoTNYJQB = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "IDIF2YcWtzwNw33Kfu1fXp", 33234U);
                    var Output_12 = n16.Flexible_R.Create(Node_Context: Node_Context_11);
                    state_8.__p_IDIF2YcWtzwNw33Kfu1fXp = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "JuldwmFKidBP7GsIxSQWk4", 33271U);
                    var Output_14 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_13);
                    state_8.__p_JuldwmFKidBP7GsIxSQWk4 = Output_14;
                }

                n11.Vector2 __pad_ItF94xxuu8PNvQIOrS1T50_15 = __slot_ItF94xxuu8PNvQIOrS1T50;
                bool Update_16 = true;
                var Output_17 = state_8.__p_JuldwmFKidBP7GsIxSQWk4;
                if (Update_16)
                {
                    Output_17 = state_8.__p_JuldwmFKidBP7GsIxSQWk4.Update(Default_Size_In: __pad_ItF94xxuu8PNvQIOrS1T50_15);
                }

                n3.IWidget Widget_18 = (n3.IWidget)Output_17;
                float Flex_19 = 1F;
                bool Update_20 = true;
                var Output_21 = state_8.__p_IDIF2YcWtzwNw33Kfu1fXp;
                if (Update_20)
                {
                    Output_21 = state_8.__p_IDIF2YcWtzwNw33Kfu1fXp.Update(Widget_In: Widget_18, Flex_In: Flex_19, Fill_In: __pad_QMuy0BxqDbWOhoyawjZG1o_0);
                }

                n3.IWidget Item_22 = (n3.IWidget)Output_21;
                n13._Operations_.Add<n3.IWidget>(Input_In: Input_In, Item_In: Item_22, Output_Out: out n12.Spread<n3.IWidget> Output_23);
                n29._Operations_.Value<uint>(Input_In: Element_ID_1, Output_Out: out n4.Nullable<uint> Output_24, Value_Out: out uint Value_25);
                var Result_26 = n22.ObjectHelpers.ToString(input: Value_25);
                string Input_27 = "#";
                string Input_3_28 = " ";
                var Output_29 = n7.StringExtensions.Plus(input: Input_27, input2: Result_26);
                var Output_30 = n7.StringExtensions.Plus(input: Output_29, input2: Input_3_28);
                bool Update_31 = true;
                var Output_32 = state_8.__p_Sd3SeOar1KDQFEfoTNYJQB;
                if (Update_31)
                {
                    Output_32 = state_8.__p_Sd3SeOar1KDQFEfoTNYJQB.Update(Value_In: Output_30, Paint_In: Paint_In);
                }

                n3.IWidget Item_33 = (n3.IWidget)Output_32;
                n13._Operations_.Add<n3.IWidget>(Input_In: Output_23, Item_In: Item_33, Output_Out: out n12.Spread<n3.IWidget> Output_34);
                __auto_7 = Output_34;
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = Output_17 != state_8.__p_JuldwmFKidBP7GsIxSQWk4 || Output_21 != state_8.__p_IDIF2YcWtzwNw33Kfu1fXp || Output_32 != state_8.__p_Sd3SeOar1KDQFEfoTNYJQB ? new __Sm45DzAGEjJMjWaWffbShJ(state_8)
                    {__p_JuldwmFKidBP7GsIxSQWk4 = Output_17, __p_IDIF2YcWtzwNw33Kfu1fXp = Output_21, __p_Sd3SeOar1KDQFEfoTNYJQB = Output_32} : state_8;
                else
                {
                    state_8.__p_JuldwmFKidBP7GsIxSQWk4 = Output_17;
                    state_8.__p_IDIF2YcWtzwNw33Kfu1fXp = Output_21;
                    state_8.__p_Sd3SeOar1KDQFEfoTNYJQB = Output_32;
                }
            }
            else
            {
                __auto_7 = Input_In;
            }

            Output_Out = __auto_7;
            n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX that_35 = this;
            if (this.__GetContext__().IsImmutable)
                that_35 = state_8 != this.__if_Q0CVz1ZSamENVYdnn0Pm92 ? new AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX(this)
                {__if_Q0CVz1ZSamENVYdnn0Pm92 = state_8} : that_35;
            else
            {
                this.__if_Q0CVz1ZSamENVYdnn0Pm92 = state_8;
            }

            return that_35;
        }

        public n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX that_0 = this;
            this.__if_Q0CVz1ZSamENVYdnn0Pm92 = default(n4.Object);
            return that_0;
        }

        public n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX __CreateDefault__()
        {
            n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX that_0 = this;
            this.__if_Q0CVz1ZSamENVYdnn0Pm92 = default(n4.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_Q0CVz1ZSamENVYdnn0Pm92);
            return;
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 33316U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "QMuy0BxqDbWOhoyawjZG1o", Name = "__slot_QMuy0BxqDbWOhoyawjZG1o")]
        public static bool __slot_QMuy0BxqDbWOhoyawjZG1o = false;
        [n1.ElementAttribute(TracingId = 33288U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "ItF94xxuu8PNvQIOrS1T50", Name = "__slot_ItF94xxuu8PNvQIOrS1T50")]
        public static n11.Vector2 __slot_ItF94xxuu8PNvQIOrS1T50 = n1.CompilationHelper.Deserialize<n11.Vector2>("0.09999999, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "ItF94xxuu8PNvQIOrS1T50");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_Q0CVz1ZSamENVYdnn0Pm92;
        static AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX()
        {
        }

        public AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX(AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX other): base(other)
        {
            this.__if_Q0CVz1ZSamENVYdnn0Pm92 = other.__if_Q0CVz1ZSamENVYdnn0Pm92;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_Q0CVz1ZSamENVYdnn0Pm92", in __if_Q0CVz1ZSamENVYdnn0Pm92));
        }

        internal AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX __WITH__(n4.Object __if_Q0CVz1ZSamENVYdnn0Pm92)
        {
            n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_Q0CVz1ZSamENVYdnn0Pm92 != this.__if_Q0CVz1ZSamENVYdnn0Pm92 ? new AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX(this)
                {__if_Q0CVz1ZSamENVYdnn0Pm92 = __if_Q0CVz1ZSamENVYdnn0Pm92} : that_0;
            else
            {
                this.__if_Q0CVz1ZSamENVYdnn0Pm92 = __if_Q0CVz1ZSamENVYdnn0Pm92;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Sm45DzAGEjJMjWaWffbShJ", Name = "__Sm45DzAGEjJMjWaWffbShJ")]
        [n4.SerializableAttribute]
        public class __Sm45DzAGEjJMjWaWffbShJ : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Sd3SeOar1KDQFEfoTNYJQB);
                n1.CompilationHelper.SafeDispose(this.__p_IDIF2YcWtzwNw33Kfu1fXp);
                n1.CompilationHelper.SafeDispose(this.__p_JuldwmFKidBP7GsIxSQWk4);
                return;
            }

            [n1.ElementAttribute(TracingId = 33169U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Sd3SeOar1KDQFEfoTNYJQB", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_SingleLine_R __p_Sd3SeOar1KDQFEfoTNYJQB;
            [n1.ElementAttribute(TracingId = 33234U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "IDIF2YcWtzwNw33Kfu1fXp", Name = "Flexible", IsManaged = true, IsAutoGenerated = true)]
            public n16.Flexible_R __p_IDIF2YcWtzwNw33Kfu1fXp;
            [n1.ElementAttribute(TracingId = 33271U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "JuldwmFKidBP7GsIxSQWk4", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_JuldwmFKidBP7GsIxSQWk4;
            public __Sm45DzAGEjJMjWaWffbShJ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Sm45DzAGEjJMjWaWffbShJ(__Sm45DzAGEjJMjWaWffbShJ other): base(other)
            {
                this.__p_Sd3SeOar1KDQFEfoTNYJQB = other.__p_Sd3SeOar1KDQFEfoTNYJQB;
                this.__p_IDIF2YcWtzwNw33Kfu1fXp = other.__p_IDIF2YcWtzwNw33Kfu1fXp;
                this.__p_JuldwmFKidBP7GsIxSQWk4 = other.__p_JuldwmFKidBP7GsIxSQWk4;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Sd3SeOar1KDQFEfoTNYJQB", in __p_Sd3SeOar1KDQFEfoTNYJQB), n1.CompilationHelper.GetValueOrExisting(values, "__p_IDIF2YcWtzwNw33Kfu1fXp", in __p_IDIF2YcWtzwNw33Kfu1fXp), n1.CompilationHelper.GetValueOrExisting(values, "__p_JuldwmFKidBP7GsIxSQWk4", in __p_JuldwmFKidBP7GsIxSQWk4));
            }

            internal __Sm45DzAGEjJMjWaWffbShJ __WITH__(n16.TextWidget_SingleLine_R __p_Sd3SeOar1KDQFEfoTNYJQB, n16.Flexible_R __p_IDIF2YcWtzwNw33Kfu1fXp, n16.EmptyWidget_R __p_JuldwmFKidBP7GsIxSQWk4)
            {
                __Sm45DzAGEjJMjWaWffbShJ that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Sd3SeOar1KDQFEfoTNYJQB != this.__p_Sd3SeOar1KDQFEfoTNYJQB || __p_IDIF2YcWtzwNw33Kfu1fXp != this.__p_IDIF2YcWtzwNw33Kfu1fXp || __p_JuldwmFKidBP7GsIxSQWk4 != this.__p_JuldwmFKidBP7GsIxSQWk4 ? new __Sm45DzAGEjJMjWaWffbShJ(this)
                    {__p_Sd3SeOar1KDQFEfoTNYJQB = __p_Sd3SeOar1KDQFEfoTNYJQB, __p_IDIF2YcWtzwNw33Kfu1fXp = __p_IDIF2YcWtzwNw33Kfu1fXp, __p_JuldwmFKidBP7GsIxSQWk4 = __p_JuldwmFKidBP7GsIxSQWk4} : that_0;
                else
                {
                    this.__p_Sd3SeOar1KDQFEfoTNYJQB = __p_Sd3SeOar1KDQFEfoTNYJQB;
                    this.__p_IDIF2YcWtzwNw33Kfu1fXp = __p_IDIF2YcWtzwNw33Kfu1fXp;
                    this.__p_JuldwmFKidBP7GsIxSQWk4 = __p_JuldwmFKidBP7GsIxSQWk4;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 33462U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PFoPzCraE28PiK8FomiGd8", Name = "AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8")]
    [n4.SerializableAttribute]
    public class AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8 : n1.VLObject, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8 Create(n1.NodeContext Node_Context)
        {
            var instance = new AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8 CreateDefault()
        {
            var instance = new AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8 Update(n2.IElementInfo Info_In, n12.SpreadBuilder<n3.IWidget> Input_In, n10.SkiaPaint_R Paint_In, out n12.SpreadBuilder<n3.IWidget> Output_Out)
        {
            var Is_Unused_0 = Info_In.IsUnused;
            n12.SpreadBuilder<n3.IWidget> __auto_1;
            var state_2 = n1.CompilationHelper.Restore<__LeRtbIT7eRSP9feNwYY62C>(this.__if_GaZEF5zRGu8NmPANTxrYke, __GetContext__());
            if (Is_Unused_0)
            {
                if (state_2 == null)
                {
                    state_2 = new __LeRtbIT7eRSP9feNwYY62C(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_3 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "P244JGJjUxjQVqYxHR2GhJ", 35441U);
                    var Output_4 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_3);
                    state_2.__p_P244JGJjUxjQVqYxHR2GhJ = Output_4;
                    n1.NodeContext Node_Context_5 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "FkHNEOV0NbXMtFg6d047at", 35453U);
                    var Output_6 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_5);
                    state_2.__p_FkHNEOV0NbXMtFg6d047at = Output_6;
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "L6upNFLuz6NP7qX99xZbiK", 35460U);
                    var Output_8 = n30.SetTypefaceStyle_MoGKeiO9W0hMONCpTgYUkq.Create(Node_Context: Node_Context_7);
                    state_2.__p_L6upNFLuz6NP7qX99xZbiK = Output_8;
                }

                n11.Vector2 Default_Size_9 = __c_IvcfmlFLpyrLKFd3jbN5bb;
                bool Update_10 = true;
                var Output_11 = state_2.__p_P244JGJjUxjQVqYxHR2GhJ;
                if (Update_10)
                {
                    Output_11 = state_2.__p_P244JGJjUxjQVqYxHR2GhJ.Update(Default_Size_In: Default_Size_9);
                }

                n3.IWidget Item_12 = (n3.IWidget)Output_11;
                n14._Operations_.Add<n3.IWidget>(Input_In: Input_In, Item_In: Item_12, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_13);
                n25.SKTypefaceStyle Style_14 = __c_HGkLka7ogQ0MXtdTR3S0YL;
                var State_Output_16 = state_2.__p_L6upNFLuz6NP7qX99xZbiK.Update(Input_In: Paint_In, Style_In: Style_14, Output_Out: out n10.SkiaPaint_R Output_15);
                string Value_17 = "Not in use";
                bool Update_18 = true;
                var Output_19 = state_2.__p_FkHNEOV0NbXMtFg6d047at;
                if (Update_18)
                {
                    Output_19 = state_2.__p_FkHNEOV0NbXMtFg6d047at.Update(Value_In: Value_17, Paint_In: Output_15);
                }

                n3.IWidget Item_20 = (n3.IWidget)Output_19;
                n14._Operations_.Add<n3.IWidget>(Input_In: Output_13, Item_In: Item_20, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_21);
                __auto_1 = Output_21;
                if (state_2.__GetContext__().IsImmutable)
                    state_2 = Output_11 != state_2.__p_P244JGJjUxjQVqYxHR2GhJ || State_Output_16 != state_2.__p_L6upNFLuz6NP7qX99xZbiK || Output_19 != state_2.__p_FkHNEOV0NbXMtFg6d047at ? new __LeRtbIT7eRSP9feNwYY62C(state_2)
                    {__p_P244JGJjUxjQVqYxHR2GhJ = Output_11, __p_L6upNFLuz6NP7qX99xZbiK = State_Output_16, __p_FkHNEOV0NbXMtFg6d047at = Output_19} : state_2;
                else
                {
                    state_2.__p_P244JGJjUxjQVqYxHR2GhJ = Output_11;
                    state_2.__p_L6upNFLuz6NP7qX99xZbiK = State_Output_16;
                    state_2.__p_FkHNEOV0NbXMtFg6d047at = Output_19;
                }
            }
            else
            {
                __auto_1 = Input_In;
            }

            Output_Out = __auto_1;
            n5.AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8 that_22 = this;
            if (this.__GetContext__().IsImmutable)
                that_22 = state_2 != this.__if_GaZEF5zRGu8NmPANTxrYke ? new AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8(this)
                {__if_GaZEF5zRGu8NmPANTxrYke = state_2} : that_22;
            else
            {
                this.__if_GaZEF5zRGu8NmPANTxrYke = state_2;
            }

            return that_22;
        }

        public n5.AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8 __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n5.AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8 that_0 = this;
            this.__if_GaZEF5zRGu8NmPANTxrYke = default(n4.Object);
            return that_0;
        }

        public n5.AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8 __CreateDefault__()
        {
            n5.AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8 that_0 = this;
            this.__if_GaZEF5zRGu8NmPANTxrYke = default(n4.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_GaZEF5zRGu8NmPANTxrYke);
            return;
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_IvcfmlFLpyrLKFd3jbN5bb = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.08", false, "QsvwBVssT9xLO3Td5ph2Z9", "IvcfmlFLpyrLKFd3jbN5bb");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n25.SKTypefaceStyle __c_HGkLka7ogQ0MXtdTR3S0YL = n1.CompilationHelper.Deserialize<n25.SKTypefaceStyle>("Italic", false, "QsvwBVssT9xLO3Td5ph2Z9", "HGkLka7ogQ0MXtdTR3S0YL");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_GaZEF5zRGu8NmPANTxrYke;
        static AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8()
        {
        }

        public AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8(AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8 other): base(other)
        {
            this.__if_GaZEF5zRGu8NmPANTxrYke = other.__if_GaZEF5zRGu8NmPANTxrYke;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_GaZEF5zRGu8NmPANTxrYke", in __if_GaZEF5zRGu8NmPANTxrYke));
        }

        internal AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8 __WITH__(n4.Object __if_GaZEF5zRGu8NmPANTxrYke)
        {
            n5.AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_GaZEF5zRGu8NmPANTxrYke != this.__if_GaZEF5zRGu8NmPANTxrYke ? new AddIsUnusedInfo_PFoPzCraE28PiK8FomiGd8(this)
                {__if_GaZEF5zRGu8NmPANTxrYke = __if_GaZEF5zRGu8NmPANTxrYke} : that_0;
            else
            {
                this.__if_GaZEF5zRGu8NmPANTxrYke = __if_GaZEF5zRGu8NmPANTxrYke;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "LeRtbIT7eRSP9feNwYY62C", Name = "__LeRtbIT7eRSP9feNwYY62C")]
        [n4.SerializableAttribute]
        public class __LeRtbIT7eRSP9feNwYY62C : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_P244JGJjUxjQVqYxHR2GhJ);
                n1.CompilationHelper.SafeDispose(this.__p_FkHNEOV0NbXMtFg6d047at);
                n1.CompilationHelper.SafeDispose(this.__p_L6upNFLuz6NP7qX99xZbiK);
                return;
            }

            [n1.ElementAttribute(TracingId = 35441U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "P244JGJjUxjQVqYxHR2GhJ", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_P244JGJjUxjQVqYxHR2GhJ;
            [n1.ElementAttribute(TracingId = 35453U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "FkHNEOV0NbXMtFg6d047at", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_SingleLine_R __p_FkHNEOV0NbXMtFg6d047at;
            [n1.ElementAttribute(TracingId = 35460U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "L6upNFLuz6NP7qX99xZbiK", Name = "SetTypefaceStyle", IsManaged = true, IsAutoGenerated = true)]
            public n30.SetTypefaceStyle_MoGKeiO9W0hMONCpTgYUkq __p_L6upNFLuz6NP7qX99xZbiK;
            public __LeRtbIT7eRSP9feNwYY62C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __LeRtbIT7eRSP9feNwYY62C(__LeRtbIT7eRSP9feNwYY62C other): base(other)
            {
                this.__p_P244JGJjUxjQVqYxHR2GhJ = other.__p_P244JGJjUxjQVqYxHR2GhJ;
                this.__p_FkHNEOV0NbXMtFg6d047at = other.__p_FkHNEOV0NbXMtFg6d047at;
                this.__p_L6upNFLuz6NP7qX99xZbiK = other.__p_L6upNFLuz6NP7qX99xZbiK;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_P244JGJjUxjQVqYxHR2GhJ", in __p_P244JGJjUxjQVqYxHR2GhJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_FkHNEOV0NbXMtFg6d047at", in __p_FkHNEOV0NbXMtFg6d047at), n1.CompilationHelper.GetValueOrExisting(values, "__p_L6upNFLuz6NP7qX99xZbiK", in __p_L6upNFLuz6NP7qX99xZbiK));
            }

            internal __LeRtbIT7eRSP9feNwYY62C __WITH__(n16.EmptyWidget_R __p_P244JGJjUxjQVqYxHR2GhJ, n16.TextWidget_SingleLine_R __p_FkHNEOV0NbXMtFg6d047at, n30.SetTypefaceStyle_MoGKeiO9W0hMONCpTgYUkq __p_L6upNFLuz6NP7qX99xZbiK)
            {
                __LeRtbIT7eRSP9feNwYY62C that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_P244JGJjUxjQVqYxHR2GhJ != this.__p_P244JGJjUxjQVqYxHR2GhJ || __p_FkHNEOV0NbXMtFg6d047at != this.__p_FkHNEOV0NbXMtFg6d047at || __p_L6upNFLuz6NP7qX99xZbiK != this.__p_L6upNFLuz6NP7qX99xZbiK ? new __LeRtbIT7eRSP9feNwYY62C(this)
                    {__p_P244JGJjUxjQVqYxHR2GhJ = __p_P244JGJjUxjQVqYxHR2GhJ, __p_FkHNEOV0NbXMtFg6d047at = __p_FkHNEOV0NbXMtFg6d047at, __p_L6upNFLuz6NP7qX99xZbiK = __p_L6upNFLuz6NP7qX99xZbiK} : that_0;
                else
                {
                    this.__p_P244JGJjUxjQVqYxHR2GhJ = __p_P244JGJjUxjQVqYxHR2GhJ;
                    this.__p_FkHNEOV0NbXMtFg6d047at = __p_FkHNEOV0NbXMtFg6d047at;
                    this.__p_L6upNFLuz6NP7qX99xZbiK = __p_L6upNFLuz6NP7qX99xZbiK;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 35530U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VHIZZ44Tpg3PXT5lwkLmiq", Name = "LiveDataHubViewer_C")]
    [n4.SerializableAttribute]
    public class LiveDataHubViewer_C : n1.VLObject, n3.IElementViewer<n2.ILiveDataHub>, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.LiveDataHubViewer_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new LiveDataHubViewer_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.LiveDataHubViewer_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new LiveDataHubViewer_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.LiveDataHubViewer_C Update_(n2.ILiveDataHub Value_In, n3.ViewerContext Context_In, out n3.IWidgetView Widget_Out)
        {
            n11.Vector2 __pad_HiD2FKaMKLxMxQ1zFVcSmB_0 = __slot_HiD2FKaMKLxMxQ1zFVcSmB;
            var Is_Tooltip_1 = Context_In.IsTooltip;
            var State_Output_11 = this.__p_AMNVepzQgyhQPGDFMPwmu2.Update(Output_Out: out n9.TooltipPaints_C Output_2, Background_Out: out n10.SkiaPaint_R Background_3, Hint_Out: out n11.Color4 Hint_4, Warning_Out: out n11.Color4 Warning_5, Error_Out: out n11.Color4 Error_6, Runtime_Error_Out: out n11.Color4 Runtime_Error_7, Font1_Out: out n10.SkiaPaint_R Font1_8, Font2_Out: out n10.SkiaPaint_R Font2_9, Font3_Out: out n10.SkiaPaint_R Font3_10);
            this.__p_AMNVepzQgyhQPGDFMPwmu2 = State_Output_11;
            n2.ILiveElement Input_12 = (n2.ILiveElement)Value_In;
            n16.Column_R __auto_13;
            var state_14 = n1.CompilationHelper.Restore<__Ii7hl6xBa7KOz2ey4g4h5M>(this.__if_PaP446R0a8vPEob2gc32hP, __GetContext__());
            if (Is_Tooltip_1)
            {
                if (state_14 == null)
                {
                    state_14 = new __Ii7hl6xBa7KOz2ey4g4h5M(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "PV6fDDpR0zuMUh74zJOY00", 35648U);
                    var Output_16 = n31.AdaptiveViewer_C.Create(Node_Context_In: Node_Context_15);
                    state_14.__p_PV6fDDpR0zuMUh74zJOY00 = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "HTab1WJrG1gMLtMAtToglC", 35666U);
                    var Output_18 = n16.Column_R.Create(Node_Context: Node_Context_17);
                    state_14.__p_HTab1WJrG1gMLtMAtToglC = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "H0ymPdTEW0kMj2IRokvIQp", 41121U);
                    var Output_20 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_19);
                    state_14.__p_H0ymPdTEW0kMj2IRokvIQp = Output_20;
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "UbFnJ9mrMH6M71FiCEdPkI", 42972U);
                    var Output_22 = n28.SetAlpha_GGYejxVIB0CO3kgS6iMxJ7.Create(Node_Context: Node_Context_21);
                    state_14.__p_UbFnJ9mrMH6M71FiCEdPkI = Output_22;
                }

                float __pad_CT2cNdbU7ftLkqcVMR1Oy2_23 = __slot_CT2cNdbU7ftLkqcVMR1Oy2;
                float __pad_DuEZ6nJsDICM3B58WJIrup_24 = __slot_DuEZ6nJsDICM3B58WJIrup;
                bool Force_25 = false;
                bool Dispose_Cached_Outputs_26 = false;
                var manager_27 = state_14.__cache_LCuy44vGErLL9TQgnBsIVz;
                if (manager_27 is null)
                {
                    manager_27 = new n32.Manager<n4.ValueTuple<n2.ILiveDataHub>, n4.ValueTuple<n2.IDataHubInfo>>(n4.ValueTuple.Create(default(n2.IDataHubInfo)));
                }

                var inputs_28 = n4.ValueTuple.Create(Value_In);
                var outputs_29 = manager_27.Outputs;
                var Has_Changed_30 = Force_25 || manager_27.InputsChanged(inputs_28);
                if (Has_Changed_30)
                {
                    if (Dispose_Cached_Outputs_26)
                        manager_27.DisposeOutputs();
                    var Element_32 = Value_In.Element;
                    n33.DataHub Default_33 = default(n33.DataHub);
                    n34._Operations_.CastAs<n33.DataHub>(Input_In: Element_32, Default_In: Default_33, Result_Out: out n33.DataHub Result_34, Success_Out: out bool Success_35);
                    var Part_36 = Value_In.Part;
                    var Result_37 = n2.ElementHelpers.ComputeElementInfo(hub: Result_34, elementPart: Part_36);
                    outputs_29 = n4.ValueTuple.Create(Result_37);
                    manager_27 = manager_27.Update(inputs_28, __GetContext__().IsImmutable, Dispose_Cached_Outputs_26, default, outputs_29);
                }
                else
                {
                    manager_27.Update(inputs_28, __GetContext__().IsImmutable, Dispose_Cached_Outputs_26);
                }

                var __auto_38 = outputs_29.Item1;
                var Output_39 = Context_In.FromDataHubInfo(dataHubInfo: __auto_38);
                bool Recreate_40 = false;
                var Output_42 = state_14.__p_PV6fDDpR0zuMUh74zJOY00.Update(Value_In: __auto_38, Recreate_In: Recreate_40, Context_In: Output_39, Widget_Out: out n16.LayoutBuilder_R Widget_41);
                var Has_Constant_Value_43 = __auto_38.HasConstantValue;
                n2.IElementInfo Input_44 = (n2.IElementInfo)__auto_38;
                var Is_Unused_45 = Input_44.IsUnused;
                var Output_46 = !Is_Unused_45;
                var Output_47 = Has_Constant_Value_43 && Output_46;
                n11.Vector2 Default_Size_48 = n18._Operations_.CreateDefault();
                bool Update_49 = true;
                var Output_50 = state_14.__p_H0ymPdTEW0kMj2IRokvIQp;
                if (Update_49)
                {
                    Output_50 = state_14.__p_H0ymPdTEW0kMj2IRokvIQp.Update(Default_Size_In: Default_Size_48);
                }

                n3.IWidget __auto_51 = (n3.IWidget)Output_50;
                n3.IWidget __auto_52;
                var state_53 = n1.CompilationHelper.Restore<__NqmXK3XL56cPXn0pyBVgs5>(state_14.__if_N3WNcOBCFBvQI6uYYyFO0K, __GetContext__());
                if (Output_47)
                {
                    if (state_53 == null)
                    {
                        state_53 = new __NqmXK3XL56cPXn0pyBVgs5(__GetContext__(), n1.VLObject.NewIdentity())
                        {__pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya = n13._Operations_.CreateDefault<n3.IWidget>()};
                        n1.NodeContext Node_Context_54 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "VAK0WqBujDkMmenAxOuTor", 40640U);
                        var Output_55 = n31.AdaptiveViewer_C.Create(Node_Context_In: Node_Context_54);
                        state_53.__p_VAK0WqBujDkMmenAxOuTor = Output_55;
                        n1.NodeContext Node_Context_56 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "JHDDgL6jcJHLH5Al2B4CVq", 40666U);
                        var Output_57 = n16.Row_R.Create(Node_Context: Node_Context_56);
                        state_53.__p_JHDDgL6jcJHLH5Al2B4CVq = Output_57;
                        n1.NodeContext Node_Context_58 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "P2FecuOAqrcON5KcIX1KYj", 40673U);
                        var Output_59 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_58);
                        state_53.__p_P2FecuOAqrcON5KcIX1KYj = Output_59;
                        n1.NodeContext Node_Context_60 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Fx2cHbSws0HO9tEFWinwBy", 40690U);
                        var Output_61 = n16.PanelWidget_R.Create(Node_Context: Node_Context_60);
                        state_53.__p_Fx2cHbSws0HO9tEFWinwBy = Output_61;
                    }

                    var Value_62 = __auto_38.Value;
                    bool Recreate_63 = false;
                    var Output_65 = state_53.__p_VAK0WqBujDkMmenAxOuTor.Update(Value_In: Value_62, Recreate_In: Recreate_63, Context_In: Output_39, Widget_Out: out n16.LayoutBuilder_R Widget_64);
                    n3.IWidget Input_2_66 = (n3.IWidget)Widget_64;
                    string Value_67 = "const: ";
                    bool Update_68 = true;
                    var Output_69 = state_53.__p_P2FecuOAqrcON5KcIX1KYj;
                    if (Update_68)
                    {
                        Output_69 = state_53.__p_P2FecuOAqrcON5KcIX1KYj.Update(Value_In: Value_67, Paint_In: Font3_10);
                    }

                    n3.IWidget Input_70 = (n3.IWidget)Output_69;
                    var builder_71 = n6.CollectionBuilders.GetBuilder(state_53.__pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya, 2);
                    builder_71.Add(Input_70);
                    builder_71.Add(Input_2_66);
                    var __pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya_72 = builder_71.Commit();
                    n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya_72, Result_Out: out n12.Spread<n3.IWidget> Result_73);
                    n15.IEnumerable<n3.IWidget> Widgets_74 = (n15.IEnumerable<n3.IWidget>)Result_73;
                    bool Update_75 = true;
                    var Output_76 = state_53.__p_JHDDgL6jcJHLH5Al2B4CVq;
                    if (Update_75)
                    {
                        Output_76 = state_53.__p_JHDDgL6jcJHLH5Al2B4CVq.Update(Widgets_In: Widgets_74);
                    }

                    n3.IWidget Widget_77 = (n3.IWidget)Widget_64;
                    n11.Vector2 Margin_78 = __c_DhdVwuHCjTIPqTFxshbtG9;
                    n11.Vector2 Padding_79 = __c_NSTGQ7sVIBtNUOG9Uj4QV7;
                    n10.SkiaPaint_R Background_Paint_80 = n10.SkiaPaint_R.CreateDefault();
                    bool Background_Enabled_81 = false;
                    n10.SkiaPaint_R Stroke_Paint_82 = n10.SkiaPaint_R.CreateDefault();
                    bool Stroke_Enabled_83 = false;
                    bool Clip_Enabled_84 = false;
                    bool Update_85 = true;
                    var Output_86 = state_53.__p_Fx2cHbSws0HO9tEFWinwBy;
                    if (Update_85)
                    {
                        Output_86 = state_53.__p_Fx2cHbSws0HO9tEFWinwBy.Update(Widget_In: Widget_77, Margin_In: Margin_78, Padding_In: Padding_79, Background_Paint_In: Background_Paint_80, Background_Enabled_In: Background_Enabled_81, Stroke_Paint_In: Stroke_Paint_82, Stroke_Enabled_In: Stroke_Enabled_83, Clip_Enabled_In: Clip_Enabled_84);
                    }

                    __auto_52 = (n3.IWidget)Output_86;
                    state_53.__p_VAK0WqBujDkMmenAxOuTor = Output_65;
                    state_53.__p_P2FecuOAqrcON5KcIX1KYj = Output_69;
                    state_53.__pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya = __pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya_72;
                    state_53.__p_JHDDgL6jcJHLH5Al2B4CVq = Output_76;
                    state_53.__p_Fx2cHbSws0HO9tEFWinwBy = Output_86;
                }
                else
                {
                    __auto_52 = __auto_51;
                }

                var Has_Default_Value_87 = __auto_38.HasDefaultValue;
                n1.NodeContext Node_Context_88 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "IADbG8MBhrcP8dtI7IS0kG", 35801U);
                int Capacity_89 = 0;
                n14._Operations_.Create<n3.IWidget>(Node_Context: Node_Context_88, Capacity_In: Capacity_89, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_90);
                n3.IWidget Item_91 = (n3.IWidget)Widget_41;
                n14._Operations_.Add<n3.IWidget>(Input_In: Output_90, Item_In: Item_91, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_92);
                var Output_93 = !Has_Constant_Value_43;
                var Output_94 = Output_93 && Output_46;
                n3.IWidget __auto_95;
                var state_96 = n1.CompilationHelper.Restore<__RJibQ5gmLk2OvfU1audn5l>(state_14.__if_SSO8t2qgqawOYYaYw00cNM, __GetContext__());
                if (Output_94)
                {
                    if (state_96 == null)
                    {
                        state_96 = new __RJibQ5gmLk2OvfU1audn5l(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_97 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Rt4MiLyHCmDObZEIAofESz", 41093U);
                        var Output_98 = n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1.Create(Node_Context: Node_Context_97);
                        state_96.__p_Rt4MiLyHCmDObZEIAofESz = Output_98;
                    }

                    var Data_Stream_99 = Input_12.DataStream;
                    var State_Output_101 = state_96.__p_Rt4MiLyHCmDObZEIAofESz.Update(Context_In: Output_39, Messages_In: Data_Stream_99, Hub_In: Input_12, Output_Out: out n16.PanelWidget_R Output_100);
                    __auto_95 = (n3.IWidget)Output_100;
                    state_96.__p_Rt4MiLyHCmDObZEIAofESz = State_Output_101;
                }
                else
                {
                    __auto_95 = __auto_52;
                }

                n14._Operations_.Add<n3.IWidget>(Input_In: Output_92, Item_In: __auto_95, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_102);
                var State_Output_104 = state_14.__p_UbFnJ9mrMH6M71FiCEdPkI.Update(Input_In: Font2_9, Value_In: __pad_DuEZ6nJsDICM3B58WJIrup_24, Output_Out: out n10.SkiaPaint_R Output_103);
                n12.SpreadBuilder<n3.IWidget> __auto_105;
                var state_106 = n1.CompilationHelper.Restore<__Poq926B04A2LvP9kg0zPBQ>(state_14.__if_LEqMF9t7z5aPaUVnUZB5oT, __GetContext__());
                if (Has_Default_Value_87)
                {
                    if (state_106 == null)
                    {
                        state_106 = new __Poq926B04A2LvP9kg0zPBQ(__GetContext__(), n1.VLObject.NewIdentity())
                        {__pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW = n13._Operations_.CreateDefault<n3.IWidget>(), __pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7 = n13._Operations_.CreateDefault<n3.IWidget>()};
                        n1.NodeContext Node_Context_107 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "VZL6rdptE9uL112CJv6zuz", 41322U);
                        var Output_108 = n16.ObjectWidget_CbtpXDkbGclPBN5iQL4gfm.Create(Node_Context: Node_Context_107);
                        state_106.__p_VZL6rdptE9uL112CJv6zuz = Output_108;
                        n1.NodeContext Node_Context_109 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "BIL5HcefRWMPNcfW8YD998", 41348U);
                        var Output_110 = n16.Row_R.Create(Node_Context: Node_Context_109);
                        state_106.__p_BIL5HcefRWMPNcfW8YD998 = Output_110;
                        n1.NodeContext Node_Context_111 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "O15YF0uB64wLatX6yjsFu3", 41357U);
                        var Output_112 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_111);
                        state_106.__p_O15YF0uB64wLatX6yjsFu3 = Output_112;
                        n1.NodeContext Node_Context_113 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "JChZAe4R8jiPyy64P9yTs5", 41365U);
                        var Output_114 = n31.AdaptiveViewer_C.Create(Node_Context_In: Node_Context_113);
                        state_106.__p_JChZAe4R8jiPyy64P9yTs5 = Output_114;
                        n1.NodeContext Node_Context_115 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "FfMqpR1YdApLNkAEPCwIdH", 41607U);
                        var Output_116 = n16.FixedWidthWidget_R.Create(Node_Context: Node_Context_115);
                        state_106.__p_FfMqpR1YdApLNkAEPCwIdH = Output_116;
                        n1.NodeContext Node_Context_117 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "FSkdsO01u2qOh224bUjZmB", 41625U);
                        var Output_118 = n16.PanelWidget_R.Create(Node_Context: Node_Context_117);
                        state_106.__p_FSkdsO01u2qOh224bUjZmB = Output_118;
                        n1.NodeContext Node_Context_119 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "AVOKp5jM37vLMZXtcgl00p", 41647U);
                        var Output_120 = n16.FixedHeightWidget_R.Create(Node_Context: Node_Context_119);
                        state_106.__p_AVOKp5jM37vLMZXtcgl00p = Output_120;
                        n1.NodeContext Node_Context_121 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "GZeDrDtzqrdOOmgaodQraL", 41676U);
                        var Output_122 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_121);
                        state_106.__p_GZeDrDtzqrdOOmgaodQraL = Output_122;
                    }

                    var Value_123 = __auto_38.Value;
                    n35.CultureInfo Culture_124 = default(n35.CultureInfo);
                    var Output_127 = state_106.__p_VZL6rdptE9uL112CJv6zuz.Update(Value_In: Value_123, Paint_In: Font2_9, Culture_In: Culture_124, Widget_Out: out n16.TextWidget_SingleLine_R Widget_125, Valid_Out: out bool Valid_126);
                    int Index_128 = n4.Convert.ToInt32(Valid_126);
                    n11.Vector2 Default_Size_129 = n18._Operations_.CreateDefault();
                    bool Update_130 = true;
                    var Output_131 = state_106.__p_GZeDrDtzqrdOOmgaodQraL;
                    if (Update_130)
                    {
                        Output_131 = state_106.__p_GZeDrDtzqrdOOmgaodQraL.Update(Default_Size_In: Default_Size_129);
                    }

                    n3.IWidget Input_132 = (n3.IWidget)Output_131;
                    string Value_133 = "Default: ";
                    bool Update_134 = true;
                    var Output_135 = state_106.__p_O15YF0uB64wLatX6yjsFu3;
                    if (Update_134)
                    {
                        Output_135 = state_106.__p_O15YF0uB64wLatX6yjsFu3.Update(Value_In: Value_133, Paint_In: Font2_9);
                    }

                    n3.IWidget Input_136 = (n3.IWidget)Output_135;
                    n3.IWidget Widget_137 = (n3.IWidget)Widget_125;
                    n11.Vector2 Margin_138 = n18._Operations_.CreateDefault();
                    n11.Vector2 Padding_139 = __c_CIGAIVqQfurOslXSKi8RuV;
                    n10.SkiaPaint_R Background_Paint_140 = n10.SkiaPaint_R.CreateDefault();
                    bool Background_Enabled_141 = false;
                    bool Stroke_Enabled_142 = true;
                    bool Clip_Enabled_143 = false;
                    bool Update_144 = true;
                    var Output_145 = state_106.__p_FSkdsO01u2qOh224bUjZmB;
                    if (Update_144)
                    {
                        Output_145 = state_106.__p_FSkdsO01u2qOh224bUjZmB.Update(Widget_In: Widget_137, Margin_In: Margin_138, Padding_In: Padding_139, Background_Paint_In: Background_Paint_140, Background_Enabled_In: Background_Enabled_141, Stroke_Paint_In: Output_103, Stroke_Enabled_In: Stroke_Enabled_142, Clip_Enabled_In: Clip_Enabled_143);
                    }

                    n3.IWidget Input_2_146 = (n3.IWidget)Output_145;
                    var builder_147 = n6.CollectionBuilders.GetBuilder(state_106.__pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW, 2);
                    builder_147.Add(Input_136);
                    builder_147.Add(Input_2_146);
                    var __pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW_148 = builder_147.Commit();
                    n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW_148, Result_Out: out n12.Spread<n3.IWidget> Result_149);
                    n15.IEnumerable<n3.IWidget> Widgets_150 = (n15.IEnumerable<n3.IWidget>)Result_149;
                    bool Update_151 = true;
                    var Output_152 = state_106.__p_BIL5HcefRWMPNcfW8YD998;
                    if (Update_151)
                    {
                        Output_152 = state_106.__p_BIL5HcefRWMPNcfW8YD998.Update(Widgets_In: Widgets_150);
                    }

                    n3.IWidget Input_2_153 = (n3.IWidget)Output_152;
                    var builder_154 = n6.CollectionBuilders.GetBuilder(state_106.__pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7, 2);
                    builder_154.Add(Input_132);
                    builder_154.Add(Input_2_153);
                    var __pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7_155 = builder_154.Commit();
                    n37._Operations_.Switch<n3.IWidget, n36.__AdaptiveImplementations__QsvwBVssT9xLO3Td5ph2Z9>(Index_In: Index_128, Input_In: __pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7_155, Output_Out: out n3.IWidget Output_156);
                    n14._Operations_.Add<n3.IWidget>(Input_In: Output_102, Item_In: Output_156, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_157);
                    __auto_105 = Output_157;
                    bool Recreate_158 = false;
                    var Output_160 = state_106.__p_JChZAe4R8jiPyy64P9yTs5.Update(Value_In: Value_123, Recreate_In: Recreate_158, Context_In: Context_In, Widget_Out: out n16.LayoutBuilder_R Widget_159);
                    n3.IWidget Widget_161 = (n3.IWidget)Widget_159;
                    bool Update_162 = true;
                    var Output_163 = state_106.__p_AVOKp5jM37vLMZXtcgl00p;
                    if (Update_162)
                    {
                        Output_163 = state_106.__p_AVOKp5jM37vLMZXtcgl00p.Update(Widget_In: Widget_161, Y_In: __pad_CT2cNdbU7ftLkqcVMR1Oy2_23);
                    }

                    n3.IWidget Widget_164 = (n3.IWidget)Output_135;
                    float X_165 = 0.15F;
                    bool Update_166 = true;
                    var Output_167 = state_106.__p_FfMqpR1YdApLNkAEPCwIdH;
                    if (Update_166)
                    {
                        Output_167 = state_106.__p_FfMqpR1YdApLNkAEPCwIdH.Update(Widget_In: Widget_164, X_In: X_165);
                    }

                    state_106.__p_VZL6rdptE9uL112CJv6zuz = Output_127;
                    state_106.__p_GZeDrDtzqrdOOmgaodQraL = Output_131;
                    state_106.__p_O15YF0uB64wLatX6yjsFu3 = Output_135;
                    state_106.__p_FSkdsO01u2qOh224bUjZmB = Output_145;
                    state_106.__pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW = __pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW_148;
                    state_106.__p_BIL5HcefRWMPNcfW8YD998 = Output_152;
                    state_106.__pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7 = __pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7_155;
                    state_106.__p_JChZAe4R8jiPyy64P9yTs5 = Output_160;
                    state_106.__p_AVOKp5jM37vLMZXtcgl00p = Output_163;
                    state_106.__p_FfMqpR1YdApLNkAEPCwIdH = Output_167;
                }
                else
                {
                    __auto_105 = Output_102;
                }

                n24._Operations_.TooltipShowOperation(Value_Out: out bool Value_168, Tooltip_Show_Operation_Out: out n23.BehaviorSubject<bool> Tooltip_Show_Operation_169);
                var Compiletime_Type_170 = __auto_38.CompiletimeType;
                n2.IElementInfo Input_171 = (n2.IElementInfo)__auto_38;
                var Moments_172 = Input_171.Moments;
                n21._Operations_.Any<n2.IMomentInfo>(Input_In: Moments_172, Result_Out: out bool Result_173);
                var Output_174 = Value_168 && Result_173;
                n12.SpreadBuilder<n3.IWidget> __auto_175;
                var state_176 = n1.CompilationHelper.Restore<__DWln1IDHnQbPuoXi9tRflV>(state_14.__if_Cx9KxQSC8thOpuFnBkECMj, __GetContext__());
                if (Output_174)
                {
                    if (state_176 == null)
                    {
                        state_176 = new __DWln1IDHnQbPuoXi9tRflV(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_177 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Ac3zBPffzGuO2FxAtw8ft3", 35700U);
                        var Output_178 = n5.MomentsWidget_C.Create(Node_Context: Node_Context_177);
                        state_176.__p_Ac3zBPffzGuO2FxAtw8ft3 = Output_178;
                        n1.NodeContext Node_Context_179 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Kh0U2TdtjA1PHHOGF5P4yw", 35725U);
                        var Output_180 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_179);
                        state_176.__p_Kh0U2TdtjA1PHHOGF5P4yw = Output_180;
                        n1.NodeContext Node_Context_181 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "NbwZrQFTQtmO8mtAIbDjLr", 35760U);
                        var Output_182 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_181);
                        state_176.__p_NbwZrQFTQtmO8mtAIbDjLr = Output_182;
                    }

                    var State_Output_184 = state_176.__p_Ac3zBPffzGuO2FxAtw8ft3.Update(Input_In: Moments_172, Text_Paint_In: Font1_8, Output_Out: out n16.Row_R Output_183);
                    n3.IWidget Item_185 = (n3.IWidget)Output_183;
                    n11.Vector2 Default_Size_186 = __c_ODWnDp9D7OYOTE13uwl3fn;
                    bool Update_187 = true;
                    var Output_188 = state_176.__p_Kh0U2TdtjA1PHHOGF5P4yw;
                    if (Update_187)
                    {
                        Output_188 = state_176.__p_Kh0U2TdtjA1PHHOGF5P4yw.Update(Default_Size_In: Default_Size_186);
                    }

                    n3.IWidget Item_189 = (n3.IWidget)Output_188;
                    n14._Operations_.Add<n3.IWidget>(Input_In: __auto_105, Item_In: Item_189, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_190);
                    n14._Operations_.Add<n3.IWidget>(Input_In: Output_190, Item_In: Item_185, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_191);
                    n11.Vector2 Default_Size_192 = __c_Tmx43J13fnfMNNBdxMSs6A;
                    bool Update_193 = true;
                    var Output_194 = state_176.__p_NbwZrQFTQtmO8mtAIbDjLr;
                    if (Update_193)
                    {
                        Output_194 = state_176.__p_NbwZrQFTQtmO8mtAIbDjLr.Update(Default_Size_In: Default_Size_192);
                    }

                    n3.IWidget Item_195 = (n3.IWidget)Output_194;
                    n14._Operations_.Add<n3.IWidget>(Input_In: Output_191, Item_In: Item_195, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_196);
                    __auto_175 = Output_196;
                    state_176.__p_Ac3zBPffzGuO2FxAtw8ft3 = State_Output_184;
                    state_176.__p_Kh0U2TdtjA1PHHOGF5P4yw = Output_188;
                    state_176.__p_NbwZrQFTQtmO8mtAIbDjLr = Output_194;
                }
                else
                {
                    __auto_175 = __auto_105;
                }

                n15.IEnumerable<n3.IWidget> Widgets_197 = (n15.IEnumerable<n3.IWidget>)__auto_175;
                bool KeepOriginalWidth_198 = false;
                bool Update_199 = true;
                var Output_200 = state_14.__p_HTab1WJrG1gMLtMAtToglC;
                if (Update_199)
                {
                    Output_200 = state_14.__p_HTab1WJrG1gMLtMAtToglC.Update(Widgets_In: Widgets_197, KeepOriginalWidth_In: KeepOriginalWidth_198);
                }

                var Name_201 = __auto_38.Name;
                __auto_13 = Output_200;
                state_14.__cache_LCuy44vGErLL9TQgnBsIVz = manager_27;
                state_14.__p_PV6fDDpR0zuMUh74zJOY00 = Output_42;
                state_14.__p_H0ymPdTEW0kMj2IRokvIQp = Output_50;
                state_14.__if_N3WNcOBCFBvQI6uYYyFO0K = state_53;
                state_14.__if_SSO8t2qgqawOYYaYw00cNM = state_96;
                state_14.__p_UbFnJ9mrMH6M71FiCEdPkI = State_Output_104;
                state_14.__if_LEqMF9t7z5aPaUVnUZB5oT = state_106;
                state_14.__if_Cx9KxQSC8thOpuFnBkECMj = state_176;
                state_14.__p_HTab1WJrG1gMLtMAtToglC = Output_200;
                this.__if_PaP446R0a8vPEob2gc32hP = state_14;
            }
            else
            {
                __auto_13 = n16.Column_R.CreateDefault();
            }

            var Output_202 = !Is_Tooltip_1;
            n3.IWidget __auto_203 = (n3.IWidget)__auto_13;
            n2.ILiveElement Input_204 = (n2.ILiveElement)Value_In;
            n3.IWidget __auto_205;
            var state_206 = n1.CompilationHelper.Restore<__ONr6csuLfDLPUhMwNjHYfk>(this.__if_UcNAKn7ezhdLQXAA1osLvT, __GetContext__());
            if (Output_202)
            {
                if (state_206 == null)
                {
                    state_206 = new __ONr6csuLfDLPUhMwNjHYfk(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_207 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "MrWsEcSC7ohMdPALmlFs8S", 43128U);
                    var Output_208 = n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1.Create(Node_Context: Node_Context_207);
                    state_206.__p_MrWsEcSC7ohMdPALmlFs8S = Output_208;
                }

                var Data_Stream_209 = Input_204.DataStream;
                var State_Output_211 = state_206.__p_MrWsEcSC7ohMdPALmlFs8S.Update(Context_In: Context_In, Messages_In: Data_Stream_209, Hub_In: Input_204, Output_Out: out n16.PanelWidget_R Output_210);
                __auto_205 = (n3.IWidget)Output_210;
                state_206.__p_MrWsEcSC7ohMdPALmlFs8S = State_Output_211;
                this.__if_UcNAKn7ezhdLQXAA1osLvT = state_206;
            }
            else
            {
                __auto_205 = __auto_203;
            }

            n11.Vector2 Margin_212 = n18._Operations_.CreateDefault();
            bool Background_Enabled_213 = true;
            n10.SkiaPaint_R Stroke_Paint_214 = n10.SkiaPaint_R.CreateDefault();
            bool Stroke_Enabled_215 = false;
            bool Clip_Enabled_216 = false;
            bool Update_217 = true;
            var Output_218 = this.__p_HnkEJB8h3fXPpv3yMvepWN;
            if (Update_217)
            {
                Output_218 = this.__p_HnkEJB8h3fXPpv3yMvepWN.Update(Widget_In: __auto_205, Margin_In: Margin_212, Padding_In: __pad_HiD2FKaMKLxMxQ1zFVcSmB_0, Background_Paint_In: Background_3, Background_Enabled_In: Background_Enabled_213, Stroke_Paint_In: Stroke_Paint_214, Stroke_Enabled_In: Stroke_Enabled_215, Clip_Enabled_In: Clip_Enabled_216);
            }

            this.__p_HnkEJB8h3fXPpv3yMvepWN = Output_218;
            var Compile_Time_Type_219 = Context_In.CompileTimeType;
            n3.IWidget Input_220 = (n3.IWidget)Output_218;
            var State_Output_222 = this.__p_GNyGs1psQnEQSzQZofbVFn.Update(Input_In: Input_220, Output_Out: out n3.IWidgetView Output_221);
            this.__p_GNyGs1psQnEQSzQZofbVFn = State_Output_222;
            Widget_Out = Output_221;
            return this;
        }

        public n5.LiveDataHubViewer_C __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "AMNVepzQgyhQPGDFMPwmu2", 35540U);
            var Output_1 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_0);
            this.__p_AMNVepzQgyhQPGDFMPwmu2 = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "HnkEJB8h3fXPpv3yMvepWN", 35566U);
            var Output_3 = n16.PanelWidget_R.Create(Node_Context: Node_Context_2);
            this.__p_HnkEJB8h3fXPpv3yMvepWN = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "GNyGs1psQnEQSzQZofbVFn", 35605U);
            var Output_5 = n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F.Create(Node_Context: Node_Context_4);
            this.__p_GNyGs1psQnEQSzQZofbVFn = Output_5;
            this.__if_PaP446R0a8vPEob2gc32hP = default(n4.Object);
            this.__if_UcNAKn7ezhdLQXAA1osLvT = default(n4.Object);
            return this;
        }

        public n5.LiveDataHubViewer_C __CreateDefault__()
        {
            this.__p_AMNVepzQgyhQPGDFMPwmu2 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__if_PaP446R0a8vPEob2gc32hP = default(n4.Object);
            this.__if_UcNAKn7ezhdLQXAA1osLvT = default(n4.Object);
            this.__p_HnkEJB8h3fXPpv3yMvepWN = n16.PanelWidget_R.CreateDefault();
            this.__p_GNyGs1psQnEQSzQZofbVFn = n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_AMNVepzQgyhQPGDFMPwmu2);
            n1.CompilationHelper.SafeDispose(this.__if_PaP446R0a8vPEob2gc32hP);
            n1.CompilationHelper.SafeDispose(this.__if_UcNAKn7ezhdLQXAA1osLvT);
            n1.CompilationHelper.SafeDispose(this.__p_HnkEJB8h3fXPpv3yMvepWN);
            n1.CompilationHelper.SafeDispose(this.__p_GNyGs1psQnEQSzQZofbVFn);
            return;
        }

        void n3.IElementViewer<n2.ILiveDataHub>.Update(n2.ILiveDataHub value, n3.ViewerContext context, out n3.IWidgetView widget)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(value, context, out widget);
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 35538U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "HiD2FKaMKLxMxQ1zFVcSmB", Name = "__slot_HiD2FKaMKLxMxQ1zFVcSmB")]
        public static n11.Vector2 __slot_HiD2FKaMKLxMxQ1zFVcSmB = n1.CompilationHelper.Deserialize<n11.Vector2>("0.06, 0.04", false, "QsvwBVssT9xLO3Td5ph2Z9", "HiD2FKaMKLxMxQ1zFVcSmB");
        [n1.ElementAttribute(TracingId = 35540U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "AMNVepzQgyhQPGDFMPwmu2", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_AMNVepzQgyhQPGDFMPwmu2;
        [n1.ElementAttribute(TracingId = 42997U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "CT2cNdbU7ftLkqcVMR1Oy2", Name = "__slot_CT2cNdbU7ftLkqcVMR1Oy2")]
        public static float __slot_CT2cNdbU7ftLkqcVMR1Oy2 = 0.14F;
        [n1.ElementAttribute(TracingId = 42991U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "DuEZ6nJsDICM3B58WJIrup", Name = "__slot_DuEZ6nJsDICM3B58WJIrup")]
        public static float __slot_DuEZ6nJsDICM3B58WJIrup = 0F;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_DhdVwuHCjTIPqTFxshbtG9 = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.02", false, "QsvwBVssT9xLO3Td5ph2Z9", "DhdVwuHCjTIPqTFxshbtG9");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_NSTGQ7sVIBtNUOG9Uj4QV7 = n1.CompilationHelper.Deserialize<n11.Vector2>("0.14, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "NSTGQ7sVIBtNUOG9Uj4QV7");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_CIGAIVqQfurOslXSKi8RuV = n1.CompilationHelper.Deserialize<n11.Vector2>("0.04, 0.03", false, "QsvwBVssT9xLO3Td5ph2Z9", "CIGAIVqQfurOslXSKi8RuV");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_ODWnDp9D7OYOTE13uwl3fn = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.05", false, "QsvwBVssT9xLO3Td5ph2Z9", "ODWnDp9D7OYOTE13uwl3fn");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_Tmx43J13fnfMNNBdxMSs6A = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.02", false, "QsvwBVssT9xLO3Td5ph2Z9", "Tmx43J13fnfMNNBdxMSs6A");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_PaP446R0a8vPEob2gc32hP;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_UcNAKn7ezhdLQXAA1osLvT;
        [n1.ElementAttribute(TracingId = 35566U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "HnkEJB8h3fXPpv3yMvepWN", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.PanelWidget_R __p_HnkEJB8h3fXPpv3yMvepWN;
        [n1.ElementAttribute(TracingId = 35605U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "GNyGs1psQnEQSzQZofbVFn", Name = "ToWidgetView", IsManaged = true, IsAutoGenerated = true)]
        public n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F __p_GNyGs1psQnEQSzQZofbVFn;
        static LiveDataHubViewer_C()
        {
        }

        public LiveDataHubViewer_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal LiveDataHubViewer_C(LiveDataHubViewer_C other): base(other)
        {
            this.__p_AMNVepzQgyhQPGDFMPwmu2 = other.__p_AMNVepzQgyhQPGDFMPwmu2;
            this.__if_PaP446R0a8vPEob2gc32hP = other.__if_PaP446R0a8vPEob2gc32hP;
            this.__if_UcNAKn7ezhdLQXAA1osLvT = other.__if_UcNAKn7ezhdLQXAA1osLvT;
            this.__p_HnkEJB8h3fXPpv3yMvepWN = other.__p_HnkEJB8h3fXPpv3yMvepWN;
            this.__p_GNyGs1psQnEQSzQZofbVFn = other.__p_GNyGs1psQnEQSzQZofbVFn;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AMNVepzQgyhQPGDFMPwmu2", in __p_AMNVepzQgyhQPGDFMPwmu2), n1.CompilationHelper.GetValueOrExisting(values, "__if_PaP446R0a8vPEob2gc32hP", in __if_PaP446R0a8vPEob2gc32hP), n1.CompilationHelper.GetValueOrExisting(values, "__if_UcNAKn7ezhdLQXAA1osLvT", in __if_UcNAKn7ezhdLQXAA1osLvT), n1.CompilationHelper.GetValueOrExisting(values, "__p_HnkEJB8h3fXPpv3yMvepWN", in __p_HnkEJB8h3fXPpv3yMvepWN), n1.CompilationHelper.GetValueOrExisting(values, "__p_GNyGs1psQnEQSzQZofbVFn", in __p_GNyGs1psQnEQSzQZofbVFn));
        }

        internal LiveDataHubViewer_C __WITH__(n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_AMNVepzQgyhQPGDFMPwmu2, n4.Object __if_PaP446R0a8vPEob2gc32hP, n4.Object __if_UcNAKn7ezhdLQXAA1osLvT, n16.PanelWidget_R __p_HnkEJB8h3fXPpv3yMvepWN, n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F __p_GNyGs1psQnEQSzQZofbVFn)
        {
            n5.LiveDataHubViewer_C that_0 = this;
            this.__p_AMNVepzQgyhQPGDFMPwmu2 = __p_AMNVepzQgyhQPGDFMPwmu2;
            this.__if_PaP446R0a8vPEob2gc32hP = __if_PaP446R0a8vPEob2gc32hP;
            this.__if_UcNAKn7ezhdLQXAA1osLvT = __if_UcNAKn7ezhdLQXAA1osLvT;
            this.__p_HnkEJB8h3fXPpv3yMvepWN = __p_HnkEJB8h3fXPpv3yMvepWN;
            this.__p_GNyGs1psQnEQSzQZofbVFn = __p_GNyGs1psQnEQSzQZofbVFn;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Ii7hl6xBa7KOz2ey4g4h5M", Name = "__Ii7hl6xBa7KOz2ey4g4h5M")]
        [n4.SerializableAttribute]
        public class __Ii7hl6xBa7KOz2ey4g4h5M : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_PV6fDDpR0zuMUh74zJOY00);
                n1.CompilationHelper.SafeDispose(this.__p_HTab1WJrG1gMLtMAtToglC);
                n1.CompilationHelper.SafeDispose(this.__p_H0ymPdTEW0kMj2IRokvIQp);
                n1.CompilationHelper.SafeDispose(this.__p_UbFnJ9mrMH6M71FiCEdPkI);
                n1.CompilationHelper.SafeDispose(this.__cache_LCuy44vGErLL9TQgnBsIVz);
                n1.CompilationHelper.SafeDispose(this.__if_N3WNcOBCFBvQI6uYYyFO0K);
                n1.CompilationHelper.SafeDispose(this.__if_SSO8t2qgqawOYYaYw00cNM);
                n1.CompilationHelper.SafeDispose(this.__if_LEqMF9t7z5aPaUVnUZB5oT);
                n1.CompilationHelper.SafeDispose(this.__if_Cx9KxQSC8thOpuFnBkECMj);
                return;
            }

            [n1.ElementAttribute(TracingId = 35648U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PV6fDDpR0zuMUh74zJOY00", Name = "AdaptiveViewer", IsManaged = true, IsAutoGenerated = true)]
            public n31.AdaptiveViewer_C __p_PV6fDDpR0zuMUh74zJOY00;
            [n1.ElementAttribute(TracingId = 35666U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "HTab1WJrG1gMLtMAtToglC", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
            public n16.Column_R __p_HTab1WJrG1gMLtMAtToglC;
            [n1.ElementAttribute(TracingId = 41121U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "H0ymPdTEW0kMj2IRokvIQp", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_H0ymPdTEW0kMj2IRokvIQp;
            [n1.ElementAttribute(TracingId = 42972U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "UbFnJ9mrMH6M71FiCEdPkI", Name = "SetAlpha", IsManaged = true, IsAutoGenerated = true)]
            public n28.SetAlpha_GGYejxVIB0CO3kgS6iMxJ7 __p_UbFnJ9mrMH6M71FiCEdPkI;
            [n1.ElementAttribute(TracingId = 41709U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "LCuy44vGErLL9TQgnBsIVz", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n32.Manager<n4.ValueTuple<n2.ILiveDataHub>, n4.ValueTuple<n2.IDataHubInfo>> __cache_LCuy44vGErLL9TQgnBsIVz = null;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n4.Object __if_N3WNcOBCFBvQI6uYYyFO0K;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n4.Object __if_SSO8t2qgqawOYYaYw00cNM;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n4.Object __if_LEqMF9t7z5aPaUVnUZB5oT;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n4.Object __if_Cx9KxQSC8thOpuFnBkECMj;
            public __Ii7hl6xBa7KOz2ey4g4h5M(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Ii7hl6xBa7KOz2ey4g4h5M(__Ii7hl6xBa7KOz2ey4g4h5M other): base(other)
            {
                this.__p_PV6fDDpR0zuMUh74zJOY00 = other.__p_PV6fDDpR0zuMUh74zJOY00;
                this.__p_HTab1WJrG1gMLtMAtToglC = other.__p_HTab1WJrG1gMLtMAtToglC;
                this.__p_H0ymPdTEW0kMj2IRokvIQp = other.__p_H0ymPdTEW0kMj2IRokvIQp;
                this.__p_UbFnJ9mrMH6M71FiCEdPkI = other.__p_UbFnJ9mrMH6M71FiCEdPkI;
                this.__cache_LCuy44vGErLL9TQgnBsIVz = other.__cache_LCuy44vGErLL9TQgnBsIVz;
                this.__if_N3WNcOBCFBvQI6uYYyFO0K = other.__if_N3WNcOBCFBvQI6uYYyFO0K;
                this.__if_SSO8t2qgqawOYYaYw00cNM = other.__if_SSO8t2qgqawOYYaYw00cNM;
                this.__if_LEqMF9t7z5aPaUVnUZB5oT = other.__if_LEqMF9t7z5aPaUVnUZB5oT;
                this.__if_Cx9KxQSC8thOpuFnBkECMj = other.__if_Cx9KxQSC8thOpuFnBkECMj;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_PV6fDDpR0zuMUh74zJOY00", in __p_PV6fDDpR0zuMUh74zJOY00), n1.CompilationHelper.GetValueOrExisting(values, "__p_HTab1WJrG1gMLtMAtToglC", in __p_HTab1WJrG1gMLtMAtToglC), n1.CompilationHelper.GetValueOrExisting(values, "__p_H0ymPdTEW0kMj2IRokvIQp", in __p_H0ymPdTEW0kMj2IRokvIQp), n1.CompilationHelper.GetValueOrExisting(values, "__p_UbFnJ9mrMH6M71FiCEdPkI", in __p_UbFnJ9mrMH6M71FiCEdPkI), n1.CompilationHelper.GetValueOrExisting(values, "__cache_LCuy44vGErLL9TQgnBsIVz", in __cache_LCuy44vGErLL9TQgnBsIVz), n1.CompilationHelper.GetValueOrExisting(values, "__if_N3WNcOBCFBvQI6uYYyFO0K", in __if_N3WNcOBCFBvQI6uYYyFO0K), n1.CompilationHelper.GetValueOrExisting(values, "__if_SSO8t2qgqawOYYaYw00cNM", in __if_SSO8t2qgqawOYYaYw00cNM), n1.CompilationHelper.GetValueOrExisting(values, "__if_LEqMF9t7z5aPaUVnUZB5oT", in __if_LEqMF9t7z5aPaUVnUZB5oT), n1.CompilationHelper.GetValueOrExisting(values, "__if_Cx9KxQSC8thOpuFnBkECMj", in __if_Cx9KxQSC8thOpuFnBkECMj));
            }

            internal __Ii7hl6xBa7KOz2ey4g4h5M __WITH__(n31.AdaptiveViewer_C __p_PV6fDDpR0zuMUh74zJOY00, n16.Column_R __p_HTab1WJrG1gMLtMAtToglC, n16.EmptyWidget_R __p_H0ymPdTEW0kMj2IRokvIQp, n28.SetAlpha_GGYejxVIB0CO3kgS6iMxJ7 __p_UbFnJ9mrMH6M71FiCEdPkI, n32.Manager<n4.ValueTuple<n2.ILiveDataHub>, n4.ValueTuple<n2.IDataHubInfo>> __cache_LCuy44vGErLL9TQgnBsIVz, n4.Object __if_N3WNcOBCFBvQI6uYYyFO0K, n4.Object __if_SSO8t2qgqawOYYaYw00cNM, n4.Object __if_LEqMF9t7z5aPaUVnUZB5oT, n4.Object __if_Cx9KxQSC8thOpuFnBkECMj)
            {
                __Ii7hl6xBa7KOz2ey4g4h5M that_0 = this;
                this.__p_PV6fDDpR0zuMUh74zJOY00 = __p_PV6fDDpR0zuMUh74zJOY00;
                this.__p_HTab1WJrG1gMLtMAtToglC = __p_HTab1WJrG1gMLtMAtToglC;
                this.__p_H0ymPdTEW0kMj2IRokvIQp = __p_H0ymPdTEW0kMj2IRokvIQp;
                this.__p_UbFnJ9mrMH6M71FiCEdPkI = __p_UbFnJ9mrMH6M71FiCEdPkI;
                this.__cache_LCuy44vGErLL9TQgnBsIVz = __cache_LCuy44vGErLL9TQgnBsIVz;
                this.__if_N3WNcOBCFBvQI6uYYyFO0K = __if_N3WNcOBCFBvQI6uYYyFO0K;
                this.__if_SSO8t2qgqawOYYaYw00cNM = __if_SSO8t2qgqawOYYaYw00cNM;
                this.__if_LEqMF9t7z5aPaUVnUZB5oT = __if_LEqMF9t7z5aPaUVnUZB5oT;
                this.__if_Cx9KxQSC8thOpuFnBkECMj = __if_Cx9KxQSC8thOpuFnBkECMj;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "NqmXK3XL56cPXn0pyBVgs5", Name = "__NqmXK3XL56cPXn0pyBVgs5")]
        [n4.SerializableAttribute]
        public class __NqmXK3XL56cPXn0pyBVgs5 : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_VAK0WqBujDkMmenAxOuTor);
                n1.CompilationHelper.SafeDispose(this.__p_JHDDgL6jcJHLH5Al2B4CVq);
                n1.CompilationHelper.SafeDispose(this.__p_P2FecuOAqrcON5KcIX1KYj);
                n1.CompilationHelper.SafeDispose(this.__p_Fx2cHbSws0HO9tEFWinwBy);
                return;
            }

            [n1.ElementAttribute(TracingId = 40640U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VAK0WqBujDkMmenAxOuTor", Name = "AdaptiveViewer", IsManaged = true, IsAutoGenerated = true)]
            public n31.AdaptiveViewer_C __p_VAK0WqBujDkMmenAxOuTor;
            [n1.ElementAttribute(TracingId = 40666U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "JHDDgL6jcJHLH5Al2B4CVq", Name = "Row", IsManaged = true, IsAutoGenerated = true)]
            public n16.Row_R __p_JHDDgL6jcJHLH5Al2B4CVq;
            [n1.ElementAttribute(TracingId = 40673U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "P2FecuOAqrcON5KcIX1KYj", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_SingleLine_R __p_P2FecuOAqrcON5KcIX1KYj;
            [n1.ElementAttribute(TracingId = 40690U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Fx2cHbSws0HO9tEFWinwBy", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.PanelWidget_R __p_Fx2cHbSws0HO9tEFWinwBy;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n3.IWidget> __pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya = default(n12.Spread<n3.IWidget>);
            public __NqmXK3XL56cPXn0pyBVgs5(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __NqmXK3XL56cPXn0pyBVgs5(__NqmXK3XL56cPXn0pyBVgs5 other): base(other)
            {
                this.__p_VAK0WqBujDkMmenAxOuTor = other.__p_VAK0WqBujDkMmenAxOuTor;
                this.__p_JHDDgL6jcJHLH5Al2B4CVq = other.__p_JHDDgL6jcJHLH5Al2B4CVq;
                this.__p_P2FecuOAqrcON5KcIX1KYj = other.__p_P2FecuOAqrcON5KcIX1KYj;
                this.__p_Fx2cHbSws0HO9tEFWinwBy = other.__p_Fx2cHbSws0HO9tEFWinwBy;
                this.__pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya = other.__pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VAK0WqBujDkMmenAxOuTor", in __p_VAK0WqBujDkMmenAxOuTor), n1.CompilationHelper.GetValueOrExisting(values, "__p_JHDDgL6jcJHLH5Al2B4CVq", in __p_JHDDgL6jcJHLH5Al2B4CVq), n1.CompilationHelper.GetValueOrExisting(values, "__p_P2FecuOAqrcON5KcIX1KYj", in __p_P2FecuOAqrcON5KcIX1KYj), n1.CompilationHelper.GetValueOrExisting(values, "__p_Fx2cHbSws0HO9tEFWinwBy", in __p_Fx2cHbSws0HO9tEFWinwBy), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya", in __pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya));
            }

            internal __NqmXK3XL56cPXn0pyBVgs5 __WITH__(n31.AdaptiveViewer_C __p_VAK0WqBujDkMmenAxOuTor, n16.Row_R __p_JHDDgL6jcJHLH5Al2B4CVq, n16.TextWidget_SingleLine_R __p_P2FecuOAqrcON5KcIX1KYj, n16.PanelWidget_R __p_Fx2cHbSws0HO9tEFWinwBy, n12.Spread<n3.IWidget> __pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya)
            {
                __NqmXK3XL56cPXn0pyBVgs5 that_0 = this;
                this.__p_VAK0WqBujDkMmenAxOuTor = __p_VAK0WqBujDkMmenAxOuTor;
                this.__p_JHDDgL6jcJHLH5Al2B4CVq = __p_JHDDgL6jcJHLH5Al2B4CVq;
                this.__p_P2FecuOAqrcON5KcIX1KYj = __p_P2FecuOAqrcON5KcIX1KYj;
                this.__p_Fx2cHbSws0HO9tEFWinwBy = __p_Fx2cHbSws0HO9tEFWinwBy;
                this.__pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya = __pin_group_Input_In_Ik0i1b9SDlePcDuY7er1Ya;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "RJibQ5gmLk2OvfU1audn5l", Name = "__RJibQ5gmLk2OvfU1audn5l")]
        [n4.SerializableAttribute]
        public class __RJibQ5gmLk2OvfU1audn5l : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Rt4MiLyHCmDObZEIAofESz);
                return;
            }

            [n1.ElementAttribute(TracingId = 41093U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Rt4MiLyHCmDObZEIAofESz", Name = "AddLiveValue", IsManaged = true, IsAutoGenerated = true)]
            public n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 __p_Rt4MiLyHCmDObZEIAofESz;
            public __RJibQ5gmLk2OvfU1audn5l(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RJibQ5gmLk2OvfU1audn5l(__RJibQ5gmLk2OvfU1audn5l other): base(other)
            {
                this.__p_Rt4MiLyHCmDObZEIAofESz = other.__p_Rt4MiLyHCmDObZEIAofESz;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Rt4MiLyHCmDObZEIAofESz", in __p_Rt4MiLyHCmDObZEIAofESz));
            }

            internal __RJibQ5gmLk2OvfU1audn5l __WITH__(n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 __p_Rt4MiLyHCmDObZEIAofESz)
            {
                __RJibQ5gmLk2OvfU1audn5l that_0 = this;
                this.__p_Rt4MiLyHCmDObZEIAofESz = __p_Rt4MiLyHCmDObZEIAofESz;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Poq926B04A2LvP9kg0zPBQ", Name = "__Poq926B04A2LvP9kg0zPBQ")]
        [n4.SerializableAttribute]
        public class __Poq926B04A2LvP9kg0zPBQ : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_VZL6rdptE9uL112CJv6zuz);
                n1.CompilationHelper.SafeDispose(this.__p_BIL5HcefRWMPNcfW8YD998);
                n1.CompilationHelper.SafeDispose(this.__p_O15YF0uB64wLatX6yjsFu3);
                n1.CompilationHelper.SafeDispose(this.__p_JChZAe4R8jiPyy64P9yTs5);
                n1.CompilationHelper.SafeDispose(this.__p_FfMqpR1YdApLNkAEPCwIdH);
                n1.CompilationHelper.SafeDispose(this.__p_FSkdsO01u2qOh224bUjZmB);
                n1.CompilationHelper.SafeDispose(this.__p_AVOKp5jM37vLMZXtcgl00p);
                n1.CompilationHelper.SafeDispose(this.__p_GZeDrDtzqrdOOmgaodQraL);
                return;
            }

            [n1.ElementAttribute(TracingId = 41322U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VZL6rdptE9uL112CJv6zuz", Name = "ObjectWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.ObjectWidget_CbtpXDkbGclPBN5iQL4gfm __p_VZL6rdptE9uL112CJv6zuz;
            [n1.ElementAttribute(TracingId = 41348U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "BIL5HcefRWMPNcfW8YD998", Name = "Row", IsManaged = true, IsAutoGenerated = true)]
            public n16.Row_R __p_BIL5HcefRWMPNcfW8YD998;
            [n1.ElementAttribute(TracingId = 41357U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "O15YF0uB64wLatX6yjsFu3", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_SingleLine_R __p_O15YF0uB64wLatX6yjsFu3;
            [n1.ElementAttribute(TracingId = 41365U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "JChZAe4R8jiPyy64P9yTs5", Name = "AdaptiveViewer", IsManaged = true, IsAutoGenerated = true)]
            public n31.AdaptiveViewer_C __p_JChZAe4R8jiPyy64P9yTs5;
            [n1.ElementAttribute(TracingId = 41607U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "FfMqpR1YdApLNkAEPCwIdH", Name = "FixedWidthWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.FixedWidthWidget_R __p_FfMqpR1YdApLNkAEPCwIdH;
            [n1.ElementAttribute(TracingId = 41625U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "FSkdsO01u2qOh224bUjZmB", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.PanelWidget_R __p_FSkdsO01u2qOh224bUjZmB;
            [n1.ElementAttribute(TracingId = 41647U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "AVOKp5jM37vLMZXtcgl00p", Name = "FixedHeightWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.FixedHeightWidget_R __p_AVOKp5jM37vLMZXtcgl00p;
            [n1.ElementAttribute(TracingId = 41676U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "GZeDrDtzqrdOOmgaodQraL", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_GZeDrDtzqrdOOmgaodQraL;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n3.IWidget> __pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW = default(n12.Spread<n3.IWidget>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n3.IWidget> __pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7 = default(n12.Spread<n3.IWidget>);
            public __Poq926B04A2LvP9kg0zPBQ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Poq926B04A2LvP9kg0zPBQ(__Poq926B04A2LvP9kg0zPBQ other): base(other)
            {
                this.__p_VZL6rdptE9uL112CJv6zuz = other.__p_VZL6rdptE9uL112CJv6zuz;
                this.__p_BIL5HcefRWMPNcfW8YD998 = other.__p_BIL5HcefRWMPNcfW8YD998;
                this.__p_O15YF0uB64wLatX6yjsFu3 = other.__p_O15YF0uB64wLatX6yjsFu3;
                this.__p_JChZAe4R8jiPyy64P9yTs5 = other.__p_JChZAe4R8jiPyy64P9yTs5;
                this.__p_FfMqpR1YdApLNkAEPCwIdH = other.__p_FfMqpR1YdApLNkAEPCwIdH;
                this.__p_FSkdsO01u2qOh224bUjZmB = other.__p_FSkdsO01u2qOh224bUjZmB;
                this.__p_AVOKp5jM37vLMZXtcgl00p = other.__p_AVOKp5jM37vLMZXtcgl00p;
                this.__p_GZeDrDtzqrdOOmgaodQraL = other.__p_GZeDrDtzqrdOOmgaodQraL;
                this.__pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW = other.__pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW;
                this.__pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7 = other.__pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VZL6rdptE9uL112CJv6zuz", in __p_VZL6rdptE9uL112CJv6zuz), n1.CompilationHelper.GetValueOrExisting(values, "__p_BIL5HcefRWMPNcfW8YD998", in __p_BIL5HcefRWMPNcfW8YD998), n1.CompilationHelper.GetValueOrExisting(values, "__p_O15YF0uB64wLatX6yjsFu3", in __p_O15YF0uB64wLatX6yjsFu3), n1.CompilationHelper.GetValueOrExisting(values, "__p_JChZAe4R8jiPyy64P9yTs5", in __p_JChZAe4R8jiPyy64P9yTs5), n1.CompilationHelper.GetValueOrExisting(values, "__p_FfMqpR1YdApLNkAEPCwIdH", in __p_FfMqpR1YdApLNkAEPCwIdH), n1.CompilationHelper.GetValueOrExisting(values, "__p_FSkdsO01u2qOh224bUjZmB", in __p_FSkdsO01u2qOh224bUjZmB), n1.CompilationHelper.GetValueOrExisting(values, "__p_AVOKp5jM37vLMZXtcgl00p", in __p_AVOKp5jM37vLMZXtcgl00p), n1.CompilationHelper.GetValueOrExisting(values, "__p_GZeDrDtzqrdOOmgaodQraL", in __p_GZeDrDtzqrdOOmgaodQraL), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW", in __pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7", in __pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7));
            }

            internal __Poq926B04A2LvP9kg0zPBQ __WITH__(n16.ObjectWidget_CbtpXDkbGclPBN5iQL4gfm __p_VZL6rdptE9uL112CJv6zuz, n16.Row_R __p_BIL5HcefRWMPNcfW8YD998, n16.TextWidget_SingleLine_R __p_O15YF0uB64wLatX6yjsFu3, n31.AdaptiveViewer_C __p_JChZAe4R8jiPyy64P9yTs5, n16.FixedWidthWidget_R __p_FfMqpR1YdApLNkAEPCwIdH, n16.PanelWidget_R __p_FSkdsO01u2qOh224bUjZmB, n16.FixedHeightWidget_R __p_AVOKp5jM37vLMZXtcgl00p, n16.EmptyWidget_R __p_GZeDrDtzqrdOOmgaodQraL, n12.Spread<n3.IWidget> __pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW, n12.Spread<n3.IWidget> __pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7)
            {
                __Poq926B04A2LvP9kg0zPBQ that_0 = this;
                this.__p_VZL6rdptE9uL112CJv6zuz = __p_VZL6rdptE9uL112CJv6zuz;
                this.__p_BIL5HcefRWMPNcfW8YD998 = __p_BIL5HcefRWMPNcfW8YD998;
                this.__p_O15YF0uB64wLatX6yjsFu3 = __p_O15YF0uB64wLatX6yjsFu3;
                this.__p_JChZAe4R8jiPyy64P9yTs5 = __p_JChZAe4R8jiPyy64P9yTs5;
                this.__p_FfMqpR1YdApLNkAEPCwIdH = __p_FfMqpR1YdApLNkAEPCwIdH;
                this.__p_FSkdsO01u2qOh224bUjZmB = __p_FSkdsO01u2qOh224bUjZmB;
                this.__p_AVOKp5jM37vLMZXtcgl00p = __p_AVOKp5jM37vLMZXtcgl00p;
                this.__p_GZeDrDtzqrdOOmgaodQraL = __p_GZeDrDtzqrdOOmgaodQraL;
                this.__pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW = __pin_group_Input_In_Mz2JVo4H2ODPbKDVIvqytW;
                this.__pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7 = __pin_group_Input_In_Kb4MvSivI99LBy0ckhY5Q7;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "DWln1IDHnQbPuoXi9tRflV", Name = "__DWln1IDHnQbPuoXi9tRflV")]
        [n4.SerializableAttribute]
        public class __DWln1IDHnQbPuoXi9tRflV : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Ac3zBPffzGuO2FxAtw8ft3);
                n1.CompilationHelper.SafeDispose(this.__p_Kh0U2TdtjA1PHHOGF5P4yw);
                n1.CompilationHelper.SafeDispose(this.__p_NbwZrQFTQtmO8mtAIbDjLr);
                return;
            }

            [n1.ElementAttribute(TracingId = 35700U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Ac3zBPffzGuO2FxAtw8ft3", Name = "MomentsWidget", IsManaged = true, IsAutoGenerated = true)]
            public n5.MomentsWidget_C __p_Ac3zBPffzGuO2FxAtw8ft3;
            [n1.ElementAttribute(TracingId = 35725U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Kh0U2TdtjA1PHHOGF5P4yw", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_Kh0U2TdtjA1PHHOGF5P4yw;
            [n1.ElementAttribute(TracingId = 35760U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "NbwZrQFTQtmO8mtAIbDjLr", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_NbwZrQFTQtmO8mtAIbDjLr;
            public __DWln1IDHnQbPuoXi9tRflV(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DWln1IDHnQbPuoXi9tRflV(__DWln1IDHnQbPuoXi9tRflV other): base(other)
            {
                this.__p_Ac3zBPffzGuO2FxAtw8ft3 = other.__p_Ac3zBPffzGuO2FxAtw8ft3;
                this.__p_Kh0U2TdtjA1PHHOGF5P4yw = other.__p_Kh0U2TdtjA1PHHOGF5P4yw;
                this.__p_NbwZrQFTQtmO8mtAIbDjLr = other.__p_NbwZrQFTQtmO8mtAIbDjLr;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Ac3zBPffzGuO2FxAtw8ft3", in __p_Ac3zBPffzGuO2FxAtw8ft3), n1.CompilationHelper.GetValueOrExisting(values, "__p_Kh0U2TdtjA1PHHOGF5P4yw", in __p_Kh0U2TdtjA1PHHOGF5P4yw), n1.CompilationHelper.GetValueOrExisting(values, "__p_NbwZrQFTQtmO8mtAIbDjLr", in __p_NbwZrQFTQtmO8mtAIbDjLr));
            }

            internal __DWln1IDHnQbPuoXi9tRflV __WITH__(n5.MomentsWidget_C __p_Ac3zBPffzGuO2FxAtw8ft3, n16.EmptyWidget_R __p_Kh0U2TdtjA1PHHOGF5P4yw, n16.EmptyWidget_R __p_NbwZrQFTQtmO8mtAIbDjLr)
            {
                __DWln1IDHnQbPuoXi9tRflV that_0 = this;
                this.__p_Ac3zBPffzGuO2FxAtw8ft3 = __p_Ac3zBPffzGuO2FxAtw8ft3;
                this.__p_Kh0U2TdtjA1PHHOGF5P4yw = __p_Kh0U2TdtjA1PHHOGF5P4yw;
                this.__p_NbwZrQFTQtmO8mtAIbDjLr = __p_NbwZrQFTQtmO8mtAIbDjLr;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "ONr6csuLfDLPUhMwNjHYfk", Name = "__ONr6csuLfDLPUhMwNjHYfk")]
        [n4.SerializableAttribute]
        public class __ONr6csuLfDLPUhMwNjHYfk : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_MrWsEcSC7ohMdPALmlFs8S);
                return;
            }

            [n1.ElementAttribute(TracingId = 43128U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "MrWsEcSC7ohMdPALmlFs8S", Name = "AddLiveValue", IsManaged = true, IsAutoGenerated = true)]
            public n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 __p_MrWsEcSC7ohMdPALmlFs8S;
            public __ONr6csuLfDLPUhMwNjHYfk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __ONr6csuLfDLPUhMwNjHYfk(__ONr6csuLfDLPUhMwNjHYfk other): base(other)
            {
                this.__p_MrWsEcSC7ohMdPALmlFs8S = other.__p_MrWsEcSC7ohMdPALmlFs8S;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MrWsEcSC7ohMdPALmlFs8S", in __p_MrWsEcSC7ohMdPALmlFs8S));
            }

            internal __ONr6csuLfDLPUhMwNjHYfk __WITH__(n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 __p_MrWsEcSC7ohMdPALmlFs8S)
            {
                __ONr6csuLfDLPUhMwNjHYfk that_0 = this;
                this.__p_MrWsEcSC7ohMdPALmlFs8S = __p_MrWsEcSC7ohMdPALmlFs8S;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 46145U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "FMMVTILpnMjLKTPT4LzvBk", Name = "LiveNodeViewer_C")]
    [n4.SerializableAttribute]
    public class LiveNodeViewer_C : n1.VLObject, n3.IElementViewer<n2.ILiveNodeApplication>, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.LiveNodeViewer_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new LiveNodeViewer_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.LiveNodeViewer_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new LiveNodeViewer_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.LiveNodeViewer_C Update_(n2.ILiveNodeApplication Value_In, n3.ViewerContext Context_In, out n3.IWidgetView Widget_Out)
        {
            n11.Vector2 __pad_AdCtTk1gA6tLNtMjTRRxvU_0 = __slot_AdCtTk1gA6tLNtMjTRRxvU;
            var Element_1 = Value_In.Element;
            n2.ILiveElement Input_2 = (n2.ILiveElement)Value_In;
            var Data_Stream_3 = Input_2.DataStream;
            var Is_Application_4 = Value_In.IsApplication;
            n33.Node Default_5 = default(n33.Node);
            n34._Operations_.CastAs<n33.Node>(Input_In: Element_1, Default_In: Default_5, Result_Out: out n33.Node Result_6, Success_Out: out bool Success_7);
            var Result_8 = n2.ElementHelpers.ComputeElementInfo(node: Result_6);
            n2.IElementInfo Input_9 = (n2.IElementInfo)Result_8;
            var Is_Unused_10 = Input_9.IsUnused;
            var Output_11 = !Is_Unused_10;
            var Output_12 = Output_11 && Is_Application_4;
            bool Recreate_13 = false;
            var Output_15 = this.__p_QZ5TLrHbhmQQU8YfmpsQSP.Update(Value_In: Result_8, Recreate_In: Recreate_13, Context_In: Context_In, Widget_Out: out n16.LayoutBuilder_R Widget_14);
            this.__p_QZ5TLrHbhmQQU8YfmpsQSP = Output_15;
            n24._Operations_.TooltipShowTimings(Value_Out: out bool Value_16, Tooltip_Show_Timings_Out: out n23.BehaviorSubject<bool> Tooltip_Show_Timings_17);
            var Timing_Stream_18 = Value_In.TimingStream;
            n4.IObservable<n15.IEnumerable<n38.TimingData>> Input_19 = n39._Operations_.CreateDefault<n15.IEnumerable<n38.TimingData>>();
            n8._Operations_.Switch_Boolean<n4.IObservable<n15.IEnumerable<n38.TimingData>>>(Condition_In: Value_16, Input_In: Input_19, Input_2_In: Timing_Stream_18, Output_Out: out n4.IObservable<n15.IEnumerable<n38.TimingData>> Output_20);
            n24._Operations_.TooltipShowAdvancedTimings(Value_Out: out bool Value_21, Tooltip_Show_Advanced_Timings_Out: out n23.BehaviorSubject<bool> Tooltip_Show_Advanced_Timings_22);
            bool Reset_23 = false;
            var __fallback___24 = n1.ServiceRegistry.Current;
            n43._Operations_.Update_H<n4.Object, n15.IEnumerable<n38.TimingData>, n4.Tuple<n3.IWidget, bool>>(Input_In: this.__p_RmqdD3vkSDUNcOwD9k6cc8, Messages_In: Output_20, Reset_In: Reset_23, Update_In: (n4.Object s_27, n15.IEnumerable<n38.TimingData> Timings_In_28) =>
            {
                using var __current_25 = __fallback___24.MakeCurrentIfNone();
                var state_26 = n1.CompilationHelper.Restore<__COmgNu2k4nwPOhtTwjzkBn>(s_27, __GetContext__());
                var Output_30 = state_26.__p_A26qitF7hWdQUxQhCJcgKx.Update_(Value_In: Timings_In_28, Context_In: Context_In, Widget_Out: out n3.IWidget Widget_29);
                var Output_32 = state_26.__p_JZZcJ0HDRD2QE5IhQgiGBI.Update_(Value_In: Timings_In_28, Context_In: Context_In, Widget_Out: out n3.IWidget Widget_31);
                n8._Operations_.Switch_Boolean<n3.IWidget>(Condition_In: Value_21, Input_In: Widget_29, Input_2_In: Widget_31, Output_Out: out n3.IWidget Output_33);
                n11.Vector2 Default_Size_34 = n18._Operations_.CreateDefault();
                bool Update_35 = true;
                var Output_36 = state_26.__p_OU5pKRiqK3kQG7BbB6VNFE;
                if (Update_35)
                {
                    Output_36 = state_26.__p_OU5pKRiqK3kQG7BbB6VNFE.Update(Default_Size_In: Default_Size_34);
                }

                n3.IWidget Input_37 = (n3.IWidget)Output_36;
                var builder_38 = n6.CollectionBuilders.GetBuilder(state_26.__pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz, 2);
                builder_38.Add(Input_37);
                builder_38.Add(Output_33);
                var __pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz_39 = builder_38.Commit();
                n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz_39, Result_Out: out n12.Spread<n3.IWidget> Result_40);
                n15.IEnumerable<n3.IWidget> Widgets_41 = (n15.IEnumerable<n3.IWidget>)Result_40;
                bool KeepOriginalWidth_42 = false;
                bool Update_43 = true;
                var Output_44 = state_26.__p_R1N1PcWWkNiLRDIGoykL7F;
                if (Update_43)
                {
                    Output_44 = state_26.__p_R1N1PcWWkNiLRDIGoykL7F.Update(Widgets_In: Widgets_41, KeepOriginalWidth_In: KeepOriginalWidth_42);
                }

                n40._Operations_.GotCalled(Timings_In: Timings_In_28, Output_Out: out bool Output_45);
                n3.IWidget Item_1_46 = (n3.IWidget)Output_44;
                n41._Operations_.Join<n3.IWidget, bool>(Item_1_In: Item_1_46, Item_2_In: Output_45, Output_Out: out n4.Tuple<n3.IWidget, bool> Output_47);
                state_26.__p_A26qitF7hWdQUxQhCJcgKx = Output_30;
                state_26.__p_JZZcJ0HDRD2QE5IhQgiGBI = Output_32;
                state_26.__p_OU5pKRiqK3kQG7BbB6VNFE = Output_36;
                state_26.__pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz = __pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz_39;
                state_26.__p_R1N1PcWWkNiLRDIGoykL7F = Output_44;
                return n4.Tuple.Create<n4.Object, n4.Tuple<n3.IWidget, bool>>(state_26, Output_47);
            }

            , Create_In: () =>
            {
                using var __current_48 = __fallback___24.MakeCurrentIfNone();
                var state_26 = new __COmgNu2k4nwPOhtTwjzkBn(__GetContext__(), n1.VLObject.NewIdentity())
                {__pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz = n13._Operations_.CreateDefault<n3.IWidget>()};
                n1.NodeContext Node_Context_49 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "OU5pKRiqK3kQG7BbB6VNFE", 46380U);
                var Output_50 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_49);
                state_26.__p_OU5pKRiqK3kQG7BbB6VNFE = Output_50;
                n1.NodeContext Node_Context_51 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "R1N1PcWWkNiLRDIGoykL7F", 46400U);
                var Output_52 = n16.Column_R.Create(Node_Context: Node_Context_51);
                state_26.__p_R1N1PcWWkNiLRDIGoykL7F = Output_52;
                n1.NodeContext Node_Context_53 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "A26qitF7hWdQUxQhCJcgKx", 46410U);
                var Output_54 = n5.SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9.Create(Node_Context: Node_Context_53);
                state_26.__p_A26qitF7hWdQUxQhCJcgKx = Output_54;
                n1.NodeContext Node_Context_55 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "JZZcJ0HDRD2QE5IhQgiGBI", 46435U);
                var Output_56 = n5.AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx.Create(Node_Context: Node_Context_55);
                state_26.__p_JZZcJ0HDRD2QE5IhQgiGBI = Output_56;
                return state_26;
            }

            , Output_Out: out n42.ForEach<n4.Object, n15.IEnumerable<n38.TimingData>, n4.Tuple<n3.IWidget, bool>> Output_57, Result_Out: out n4.IObservable<n4.Tuple<n3.IWidget, bool>> Result_58);
            this.__p_RmqdD3vkSDUNcOwD9k6cc8 = Output_57;
            var Output_61 = this.__p_Rz9kYK5e2VAOGQbVfFPY9M.Update(Value_In: Value_In, Result_Out: out bool Result_59, Unchanged_Out: out bool Unchanged_60);
            this.__p_Rz9kYK5e2VAOGQbVfFPY9M = Output_61;
            bool Update_62 = true;
            var Output_63 = this.__p_HKtFgMrJwErOz0bbiTBdS4;
            if (Update_62)
            {
                n44._Operations_.Update_H<n4.Tuple<n3.IWidget, bool>>(Input_In: this.__p_HKtFgMrJwErOz0bbiTBdS4, Async_Notifications_In: Result_58, Reset_In: Result_59, Output_Out: out Output_63);
            }

            this.__p_HKtFgMrJwErOz0bbiTBdS4 = Output_63;
            n44._Operations_.GetData_H<n4.Tuple<n3.IWidget, bool>>(Input_In: Output_63, Output_Out: out n42.HoldLatest<n4.Tuple<n3.IWidget, bool>> Output_64, Value_Out: out n4.Tuple<n3.IWidget, bool> Value_65, On_Data_Out: out bool On_Data_66);
            this.__p_HKtFgMrJwErOz0bbiTBdS4 = Output_64;
            n3.IWidget Input_67 = (n3.IWidget)Widget_14;
            n11.Vector2 Default_Size_68 = __c_ACHFbdRyfbhNQvWZJWf0Ls;
            bool Update_69 = true;
            var Output_70 = this.__p_NbLWKdUT2kpQRwcqGFZh9V;
            if (Update_69)
            {
                Output_70 = this.__p_NbLWKdUT2kpQRwcqGFZh9V.Update(Default_Size_In: Default_Size_68);
            }

            this.__p_NbLWKdUT2kpQRwcqGFZh9V = Output_70;
            n21._Operations_.FromValue<n16.EmptyWidget_R>(Input_In: Output_70, Result_Out: out n15.IEnumerable<n16.EmptyWidget_R> Result_71);
            n15.IEnumerable<n3.IWidget> Input_72 = (n15.IEnumerable<n3.IWidget>)Result_71;
            var Messages_73 = Value_In.Messages;
            string Nodename_74 = "";
            n4.Nullable<n1.UniqueId> OwnerElementID_75 = default(n4.Nullable<n1.UniqueId>);
            var Output_77 = this.__p_VnjipDTutYpLU5eXPAWXpJ.Update(Nodename_In: Nodename_74, Message_In: Messages_73, OwnerElementID_In: OwnerElementID_75, Widgets_Out: out n12.Spread<n3.IWidget> Widgets_76);
            this.__p_VnjipDTutYpLU5eXPAWXpJ = Output_77;
            n15.IEnumerable<n3.IWidget> Input_2_78 = (n15.IEnumerable<n3.IWidget>)Widgets_76;
            var builder_79 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL, 2);
            builder_79.Add(Input_72);
            builder_79.Add(Input_2_78);
            var __pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL_80 = builder_79.Commit();
            this.__pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL = __pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL_80;
            n13._Operations_.Concat<n3.IWidget>(Input_In: __pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL_80, Output_Out: out n12.Spread<n3.IWidget> Output_81);
            n15.IEnumerable<n3.IWidget> Widgets_82 = (n15.IEnumerable<n3.IWidget>)Output_81;
            bool KeepOriginalWidth_83 = false;
            bool Update_84 = true;
            var Output_85 = this.__p_IJgGBLwZf4gNsZKflC4DS0;
            if (Update_84)
            {
                Output_85 = this.__p_IJgGBLwZf4gNsZKflC4DS0.Update(Widgets_In: Widgets_82, KeepOriginalWidth_In: KeepOriginalWidth_83);
            }

            this.__p_IJgGBLwZf4gNsZKflC4DS0 = Output_85;
            n3.IWidget Input_2_86 = (n3.IWidget)Output_85;
            n2.ILiveElement Element_87 = (n2.ILiveElement)Value_In;
            int Index_88 = n4.Convert.ToInt32(Output_12);
            n41._Operations_.Split<n3.IWidget, bool>(Input_In: Value_65, Item_1_Out: out n3.IWidget Item_1_89, Item_2_Out: out bool Item_2_90);
            bool Input_91 = true;
            var builder_92 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2, 2);
            builder_92.Add(Input_91);
            builder_92.Add(Item_2_90);
            var __pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2_93 = builder_92.Commit();
            this.__pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2 = __pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2_93;
            n37._Operations_.Switch<bool, n36.__AdaptiveImplementations__QsvwBVssT9xLO3Td5ph2Z9>(Index_In: Index_88, Input_In: __pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2_93, Output_Out: out bool Output_94);
            var Output_96 = this.__p_PS7Zwd9TKc5MYCfDD5CbZT.Update(Element_In: Element_87, On_Data_In: Output_94, Result_Out: out bool Result_95);
            this.__p_PS7Zwd9TKc5MYCfDD5CbZT = Output_96;
            int Index_97 = n4.Convert.ToInt32(Result_95);
            bool SetValue_98 = true;
            var Output_99 = this.__p_JCPtvRO7I96LvnAppQ0xUn;
            if (SetValue_98)
            {
                Output_99 = this.__p_JCPtvRO7I96LvnAppQ0xUn.SetValue(Value_In: Item_1_89, Sample_In: Item_2_90);
            }

            this.__p_JCPtvRO7I96LvnAppQ0xUn = Output_99;
            var Output_101 = Output_99.GetValue(Value_Out: out n3.IWidget Value_100);
            this.__p_JCPtvRO7I96LvnAppQ0xUn = Output_101;
            n2.ILiveElement Element_102 = (n2.ILiveElement)Value_In;
            var State_Output_104 = this.__p_OOEYbgRTOT8MFL4J5kQvTh.Update(Element_In: Element_102, Output_Out: out n16.TextWidget_SingleLine_R Output_103);
            this.__p_OOEYbgRTOT8MFL4J5kQvTh = State_Output_104;
            n3.IWidget Input_2_105 = (n3.IWidget)Output_103;
            var builder_106 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky, 2);
            builder_106.Add(Value_100);
            builder_106.Add(Input_2_105);
            var __pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky_107 = builder_106.Commit();
            this.__pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky = __pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky_107;
            n37._Operations_.Switch<n3.IWidget, n36.__AdaptiveImplementations__QsvwBVssT9xLO3Td5ph2Z9>(Index_In: Index_97, Input_In: __pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky_107, Output_Out: out n3.IWidget Output_108);
            var builder_109 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF, 3);
            builder_109.Add(Input_67);
            builder_109.Add(Input_2_86);
            builder_109.Add(Output_108);
            var __pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF_110 = builder_109.Commit();
            this.__pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF = __pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF_110;
            n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF_110, Result_Out: out n12.Spread<n3.IWidget> Result_111);
            this.__slot_VPqkWxen8iQOJOQPvyeRWU = Item_2_90;
            bool __pad_VPqkWxen8iQOJOQPvyeRWU_112 = Item_2_90;
            n15.IEnumerable<n3.IWidget> Widgets_113 = (n15.IEnumerable<n3.IWidget>)Result_111;
            bool KeepOriginalWidth_114 = false;
            bool Update_115 = true;
            var Output_116 = this.__p_ThxWGOXGSMdOGSDpC6uHhd;
            if (Update_115)
            {
                Output_116 = this.__p_ThxWGOXGSMdOGSDpC6uHhd.Update(Widgets_In: Widgets_113, KeepOriginalWidth_In: KeepOriginalWidth_114);
            }

            this.__p_ThxWGOXGSMdOGSDpC6uHhd = Output_116;
            n3.IWidget Widget_117 = (n3.IWidget)Output_116;
            var State_Output_127 = this.__p_KucWUQ47YiCOpbcZoYF6Al.Update(Output_Out: out n9.TooltipPaints_C Output_118, Background_Out: out n10.SkiaPaint_R Background_119, Hint_Out: out n11.Color4 Hint_120, Warning_Out: out n11.Color4 Warning_121, Error_Out: out n11.Color4 Error_122, Runtime_Error_Out: out n11.Color4 Runtime_Error_123, Font1_Out: out n10.SkiaPaint_R Font1_124, Font2_Out: out n10.SkiaPaint_R Font2_125, Font3_Out: out n10.SkiaPaint_R Font3_126);
            this.__p_KucWUQ47YiCOpbcZoYF6Al = State_Output_127;
            n11.Vector2 Margin_128 = n18._Operations_.CreateDefault();
            bool Background_Enabled_129 = true;
            n10.SkiaPaint_R Stroke_Paint_130 = n10.SkiaPaint_R.CreateDefault();
            bool Stroke_Enabled_131 = false;
            bool Clip_Enabled_132 = false;
            bool Update_133 = true;
            var Output_134 = this.__p_SHbWfK0BZNJPuAgdy16G9h;
            if (Update_133)
            {
                Output_134 = this.__p_SHbWfK0BZNJPuAgdy16G9h.Update(Widget_In: Widget_117, Margin_In: Margin_128, Padding_In: __pad_AdCtTk1gA6tLNtMjTRRxvU_0, Background_Paint_In: Background_119, Background_Enabled_In: Background_Enabled_129, Stroke_Paint_In: Stroke_Paint_130, Stroke_Enabled_In: Stroke_Enabled_131, Clip_Enabled_In: Clip_Enabled_132);
            }

            this.__p_SHbWfK0BZNJPuAgdy16G9h = Output_134;
            n3.IWidget Input_135 = (n3.IWidget)Output_134;
            var State_Output_137 = this.__p_QX6Rs5WrthnMvRYFv0FOpq.Update(Input_In: Input_135, Output_Out: out n3.IWidgetView Output_136);
            this.__p_QX6Rs5WrthnMvRYFv0FOpq = State_Output_137;
            n11.Vector2 Default_Size_138 = n18._Operations_.CreateDefault();
            bool Update_139 = true;
            var Output_140 = this.__p_BTxZJjKtxMJOg3nvGHlgT9;
            if (Update_139)
            {
                Output_140 = this.__p_BTxZJjKtxMJOg3nvGHlgT9.Update(Default_Size_In: Default_Size_138);
            }

            this.__p_BTxZJjKtxMJOg3nvGHlgT9 = Output_140;
            Widget_Out = Output_136;
            return this;
        }

        public n5.LiveNodeViewer_C __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_VPqkWxen8iQOJOQPvyeRWU = false;
            this.__pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL = n13._Operations_.CreateDefault<n15.IEnumerable<n3.IWidget>>();
            this.__pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2 = n13._Operations_.CreateDefault<bool>();
            this.__pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF = n13._Operations_.CreateDefault<n3.IWidget>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "QZ5TLrHbhmQQU8YfmpsQSP", 46186U);
            var Output_1 = n31.AdaptiveViewer_C.Create(Node_Context_In: Node_Context_0);
            this.__p_QZ5TLrHbhmQQU8YfmpsQSP = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "KucWUQ47YiCOpbcZoYF6Al", 46297U);
            var Output_3 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_2);
            this.__p_KucWUQ47YiCOpbcZoYF6Al = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "ThxWGOXGSMdOGSDpC6uHhd", 46343U);
            var Output_5 = n16.Column_R.Create(Node_Context: Node_Context_4);
            this.__p_ThxWGOXGSMdOGSDpC6uHhd = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "RmqdD3vkSDUNcOwD9k6cc8", 46356U);
            n43._Operations_.Create_H<n4.Object, n15.IEnumerable<n38.TimingData>, n4.Tuple<n3.IWidget, bool>>(Node_Context: Node_Context_6, Output_Out: out n42.ForEach<n4.Object, n15.IEnumerable<n38.TimingData>, n4.Tuple<n3.IWidget, bool>> Output_7);
            this.__p_RmqdD3vkSDUNcOwD9k6cc8 = Output_7;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "BTxZJjKtxMJOg3nvGHlgT9", 46504U);
            var Output_9 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_8);
            this.__p_BTxZJjKtxMJOg3nvGHlgT9 = Output_9;
            n3.IWidget Item_1_10 = (n3.IWidget)Output_9;
            bool Item_2_11 = false;
            n41._Operations_.Join<n3.IWidget, bool>(Item_1_In: Item_1_10, Item_2_In: Item_2_11, Output_Out: out n4.Tuple<n3.IWidget, bool> Output_12);
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "HKtFgMrJwErOz0bbiTBdS4", 46487U);
            n44._Operations_.Create_H<n4.Tuple<n3.IWidget, bool>>(Node_Context: Node_Context_13, Initial_Result_In: Output_12, Output_Out: out n42.HoldLatest<n4.Tuple<n3.IWidget, bool>> Output_14);
            this.__p_HKtFgMrJwErOz0bbiTBdS4 = Output_14;
            n1.NodeContext Node_Context_15 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Rz9kYK5e2VAOGQbVfFPY9M", 46515U);
            bool Changed_On_Create_16 = true;
            var Output_17 = n37.Changed_A8JGbead2bxNdnPybiEqVS<n2.ILiveNodeApplication>.Create<n36.__AdaptiveImplementations__QsvwBVssT9xLO3Td5ph2Z9>(Node_Context: Node_Context_15, Changed_On_Create_In: Changed_On_Create_16);
            this.__p_Rz9kYK5e2VAOGQbVfFPY9M = Output_17;
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "SHbWfK0BZNJPuAgdy16G9h", 46527U);
            var Output_19 = n16.PanelWidget_R.Create(Node_Context: Node_Context_18);
            this.__p_SHbWfK0BZNJPuAgdy16G9h = Output_19;
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "VnjipDTutYpLU5eXPAWXpJ", 46598U);
            bool IsRuntime_21 = true;
            var Output_22 = n5.MessageWidgets_C.Create(Node_Context: Node_Context_20, IsRuntime_In: IsRuntime_21);
            this.__p_VnjipDTutYpLU5eXPAWXpJ = Output_22;
            n1.NodeContext Node_Context_23 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "IJgGBLwZf4gNsZKflC4DS0", 46626U);
            var Output_24 = n16.Column_R.Create(Node_Context: Node_Context_23);
            this.__p_IJgGBLwZf4gNsZKflC4DS0 = Output_24;
            n1.NodeContext Node_Context_25 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "NbLWKdUT2kpQRwcqGFZh9V", 46643U);
            var Output_26 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_25);
            this.__p_NbLWKdUT2kpQRwcqGFZh9V = Output_26;
            n1.NodeContext Node_Context_27 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "QX6Rs5WrthnMvRYFv0FOpq", 46681U);
            var Output_28 = n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F.Create(Node_Context: Node_Context_27);
            this.__p_QX6Rs5WrthnMvRYFv0FOpq = Output_28;
            n1.NodeContext Node_Context_29 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "PS7Zwd9TKc5MYCfDD5CbZT", 46689U);
            var Output_30 = n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L.Create(Node_Context: Node_Context_29);
            this.__p_PS7Zwd9TKc5MYCfDD5CbZT = Output_30;
            n1.NodeContext Node_Context_31 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "OOEYbgRTOT8MFL4J5kQvTh", 46696U);
            var Output_32 = n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k.Create(Node_Context: Node_Context_31);
            this.__p_OOEYbgRTOT8MFL4J5kQvTh = Output_32;
            n3.IWidget Initial_Value_33 = (n3.IWidget)Output_9;
            n1.NodeContext Node_Context_34 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "JCPtvRO7I96LvnAppQ0xUn", 48019U);
            var Output_35 = n37.SPH_RESwCzqU3iTMc4Ig82Av03<n3.IWidget>.Create(Node_Context: Node_Context_34, Initial_Value_In: Initial_Value_33);
            this.__p_JCPtvRO7I96LvnAppQ0xUn = Output_35;
            return this;
        }

        public n5.LiveNodeViewer_C __CreateDefault__()
        {
            this.__slot_VPqkWxen8iQOJOQPvyeRWU = false;
            this.__pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL = n13._Operations_.CreateDefault<n15.IEnumerable<n3.IWidget>>();
            this.__pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2 = n13._Operations_.CreateDefault<bool>();
            this.__pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__p_QZ5TLrHbhmQQU8YfmpsQSP = n31.AdaptiveViewer_C.CreateDefault();
            this.__p_RmqdD3vkSDUNcOwD9k6cc8 = default(n42.ForEach<n4.Object, n15.IEnumerable<n38.TimingData>, n4.Tuple<n3.IWidget, bool>>);
            this.__p_Rz9kYK5e2VAOGQbVfFPY9M = n37.Changed_A8JGbead2bxNdnPybiEqVS<n2.ILiveNodeApplication>.CreateDefault<n36.__AdaptiveImplementations__QsvwBVssT9xLO3Td5ph2Z9>();
            this.__p_HKtFgMrJwErOz0bbiTBdS4 = default(n42.HoldLatest<n4.Tuple<n3.IWidget, bool>>);
            this.__p_NbLWKdUT2kpQRwcqGFZh9V = n16.EmptyWidget_R.CreateDefault();
            this.__p_VnjipDTutYpLU5eXPAWXpJ = n5.MessageWidgets_C.CreateDefault();
            this.__p_IJgGBLwZf4gNsZKflC4DS0 = n16.Column_R.CreateDefault();
            this.__p_PS7Zwd9TKc5MYCfDD5CbZT = n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L.CreateDefault();
            this.__p_JCPtvRO7I96LvnAppQ0xUn = n37.SPH_RESwCzqU3iTMc4Ig82Av03<n3.IWidget>.CreateDefault();
            this.__p_OOEYbgRTOT8MFL4J5kQvTh = n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k.CreateDefault();
            this.__p_ThxWGOXGSMdOGSDpC6uHhd = n16.Column_R.CreateDefault();
            this.__p_KucWUQ47YiCOpbcZoYF6Al = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__p_SHbWfK0BZNJPuAgdy16G9h = n16.PanelWidget_R.CreateDefault();
            this.__p_QX6Rs5WrthnMvRYFv0FOpq = n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F.CreateDefault();
            this.__p_BTxZJjKtxMJOg3nvGHlgT9 = n16.EmptyWidget_R.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_QZ5TLrHbhmQQU8YfmpsQSP);
            n1.CompilationHelper.SafeDispose(this.__p_RmqdD3vkSDUNcOwD9k6cc8);
            n1.CompilationHelper.SafeDispose(this.__p_Rz9kYK5e2VAOGQbVfFPY9M);
            n1.CompilationHelper.SafeDispose(this.__p_HKtFgMrJwErOz0bbiTBdS4);
            n1.CompilationHelper.SafeDispose(this.__p_NbLWKdUT2kpQRwcqGFZh9V);
            n1.CompilationHelper.SafeDispose(this.__p_VnjipDTutYpLU5eXPAWXpJ);
            n1.CompilationHelper.SafeDispose(this.__p_IJgGBLwZf4gNsZKflC4DS0);
            n1.CompilationHelper.SafeDispose(this.__p_PS7Zwd9TKc5MYCfDD5CbZT);
            n1.CompilationHelper.SafeDispose(this.__p_JCPtvRO7I96LvnAppQ0xUn);
            n1.CompilationHelper.SafeDispose(this.__p_OOEYbgRTOT8MFL4J5kQvTh);
            n1.CompilationHelper.SafeDispose(this.__p_ThxWGOXGSMdOGSDpC6uHhd);
            n1.CompilationHelper.SafeDispose(this.__p_KucWUQ47YiCOpbcZoYF6Al);
            n1.CompilationHelper.SafeDispose(this.__p_SHbWfK0BZNJPuAgdy16G9h);
            n1.CompilationHelper.SafeDispose(this.__p_QX6Rs5WrthnMvRYFv0FOpq);
            n1.CompilationHelper.SafeDispose(this.__p_BTxZJjKtxMJOg3nvGHlgT9);
            return;
        }

        void n3.IElementViewer<n2.ILiveNodeApplication>.Update(n2.ILiveNodeApplication value, n3.ViewerContext context, out n3.IWidgetView widget)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(value, context, out widget);
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 46211U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "AdCtTk1gA6tLNtMjTRRxvU", Name = "__slot_AdCtTk1gA6tLNtMjTRRxvU")]
        public static n11.Vector2 __slot_AdCtTk1gA6tLNtMjTRRxvU = n1.CompilationHelper.Deserialize<n11.Vector2>("0.06, 0.04", false, "QsvwBVssT9xLO3Td5ph2Z9", "AdCtTk1gA6tLNtMjTRRxvU");
        [n1.ElementAttribute(TracingId = 48000U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VPqkWxen8iQOJOQPvyeRWU", Name = "__slot_VPqkWxen8iQOJOQPvyeRWU")]
        public bool __slot_VPqkWxen8iQOJOQPvyeRWU;
        [n1.ElementAttribute(TracingId = 46186U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "QZ5TLrHbhmQQU8YfmpsQSP", Name = "AdaptiveViewer", IsManaged = true, IsAutoGenerated = true)]
        public n31.AdaptiveViewer_C __p_QZ5TLrHbhmQQU8YfmpsQSP;
        [n1.ElementAttribute(TracingId = 46356U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "RmqdD3vkSDUNcOwD9k6cc8", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n42.ForEach<n4.Object, n15.IEnumerable<n38.TimingData>, n4.Tuple<n3.IWidget, bool>> __p_RmqdD3vkSDUNcOwD9k6cc8;
        [n1.ElementAttribute(TracingId = 46515U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Rz9kYK5e2VAOGQbVfFPY9M", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n37.Changed_A8JGbead2bxNdnPybiEqVS<n2.ILiveNodeApplication> __p_Rz9kYK5e2VAOGQbVfFPY9M;
        [n1.ElementAttribute(TracingId = 46487U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "HKtFgMrJwErOz0bbiTBdS4", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n42.HoldLatest<n4.Tuple<n3.IWidget, bool>> __p_HKtFgMrJwErOz0bbiTBdS4;
        [n1.ElementAttribute(TracingId = 46643U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "NbLWKdUT2kpQRwcqGFZh9V", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.EmptyWidget_R __p_NbLWKdUT2kpQRwcqGFZh9V;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_ACHFbdRyfbhNQvWZJWf0Ls = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.05", false, "QsvwBVssT9xLO3Td5ph2Z9", "ACHFbdRyfbhNQvWZJWf0Ls");
        [n1.ElementAttribute(TracingId = 46598U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VnjipDTutYpLU5eXPAWXpJ", Name = "MessageWidgets", IsManaged = true, IsAutoGenerated = true)]
        public n5.MessageWidgets_C __p_VnjipDTutYpLU5eXPAWXpJ;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n15.IEnumerable<n3.IWidget>> __pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL = default(n12.Spread<n15.IEnumerable<n3.IWidget>>);
        [n1.ElementAttribute(TracingId = 46626U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "IJgGBLwZf4gNsZKflC4DS0", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
        public n16.Column_R __p_IJgGBLwZf4gNsZKflC4DS0;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<bool> __pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2 = default(n12.Spread<bool>);
        [n1.ElementAttribute(TracingId = 46689U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PS7Zwd9TKc5MYCfDD5CbZT", Name = "AddInstanceInspectionInfosQuestionmark", IsManaged = true, IsAutoGenerated = true)]
        public n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L __p_PS7Zwd9TKc5MYCfDD5CbZT;
        [n1.ElementAttribute(TracingId = 48019U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "JCPtvRO7I96LvnAppQ0xUn", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n37.SPH_RESwCzqU3iTMc4Ig82Av03<n3.IWidget> __p_JCPtvRO7I96LvnAppQ0xUn;
        [n1.ElementAttribute(TracingId = 46696U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "OOEYbgRTOT8MFL4J5kQvTh", Name = "AddInstanceInspectionInfos", IsManaged = true, IsAutoGenerated = true)]
        public n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k __p_OOEYbgRTOT8MFL4J5kQvTh;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n3.IWidget> __pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky = default(n12.Spread<n3.IWidget>);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n3.IWidget> __pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF = default(n12.Spread<n3.IWidget>);
        [n1.ElementAttribute(TracingId = 46343U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "ThxWGOXGSMdOGSDpC6uHhd", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
        public n16.Column_R __p_ThxWGOXGSMdOGSDpC6uHhd;
        [n1.ElementAttribute(TracingId = 46297U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "KucWUQ47YiCOpbcZoYF6Al", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_KucWUQ47YiCOpbcZoYF6Al;
        [n1.ElementAttribute(TracingId = 46527U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "SHbWfK0BZNJPuAgdy16G9h", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.PanelWidget_R __p_SHbWfK0BZNJPuAgdy16G9h;
        [n1.ElementAttribute(TracingId = 46681U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "QX6Rs5WrthnMvRYFv0FOpq", Name = "ToWidgetView", IsManaged = true, IsAutoGenerated = true)]
        public n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F __p_QX6Rs5WrthnMvRYFv0FOpq;
        [n1.ElementAttribute(TracingId = 46504U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "BTxZJjKtxMJOg3nvGHlgT9", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.EmptyWidget_R __p_BTxZJjKtxMJOg3nvGHlgT9;
        static LiveNodeViewer_C()
        {
        }

        public LiveNodeViewer_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal LiveNodeViewer_C(LiveNodeViewer_C other): base(other)
        {
            this.__slot_VPqkWxen8iQOJOQPvyeRWU = other.__slot_VPqkWxen8iQOJOQPvyeRWU;
            this.__p_QZ5TLrHbhmQQU8YfmpsQSP = other.__p_QZ5TLrHbhmQQU8YfmpsQSP;
            this.__p_RmqdD3vkSDUNcOwD9k6cc8 = other.__p_RmqdD3vkSDUNcOwD9k6cc8;
            this.__p_Rz9kYK5e2VAOGQbVfFPY9M = other.__p_Rz9kYK5e2VAOGQbVfFPY9M;
            this.__p_HKtFgMrJwErOz0bbiTBdS4 = other.__p_HKtFgMrJwErOz0bbiTBdS4;
            this.__p_NbLWKdUT2kpQRwcqGFZh9V = other.__p_NbLWKdUT2kpQRwcqGFZh9V;
            this.__p_VnjipDTutYpLU5eXPAWXpJ = other.__p_VnjipDTutYpLU5eXPAWXpJ;
            this.__pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL = other.__pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL;
            this.__p_IJgGBLwZf4gNsZKflC4DS0 = other.__p_IJgGBLwZf4gNsZKflC4DS0;
            this.__pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2 = other.__pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2;
            this.__p_PS7Zwd9TKc5MYCfDD5CbZT = other.__p_PS7Zwd9TKc5MYCfDD5CbZT;
            this.__p_JCPtvRO7I96LvnAppQ0xUn = other.__p_JCPtvRO7I96LvnAppQ0xUn;
            this.__p_OOEYbgRTOT8MFL4J5kQvTh = other.__p_OOEYbgRTOT8MFL4J5kQvTh;
            this.__pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky = other.__pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky;
            this.__pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF = other.__pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF;
            this.__p_ThxWGOXGSMdOGSDpC6uHhd = other.__p_ThxWGOXGSMdOGSDpC6uHhd;
            this.__p_KucWUQ47YiCOpbcZoYF6Al = other.__p_KucWUQ47YiCOpbcZoYF6Al;
            this.__p_SHbWfK0BZNJPuAgdy16G9h = other.__p_SHbWfK0BZNJPuAgdy16G9h;
            this.__p_QX6Rs5WrthnMvRYFv0FOpq = other.__p_QX6Rs5WrthnMvRYFv0FOpq;
            this.__p_BTxZJjKtxMJOg3nvGHlgT9 = other.__p_BTxZJjKtxMJOg3nvGHlgT9;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_VPqkWxen8iQOJOQPvyeRWU", in __slot_VPqkWxen8iQOJOQPvyeRWU), n1.CompilationHelper.GetValueOrExisting(values, "__p_QZ5TLrHbhmQQU8YfmpsQSP", in __p_QZ5TLrHbhmQQU8YfmpsQSP), n1.CompilationHelper.GetValueOrExisting(values, "__p_RmqdD3vkSDUNcOwD9k6cc8", in __p_RmqdD3vkSDUNcOwD9k6cc8), n1.CompilationHelper.GetValueOrExisting(values, "__p_Rz9kYK5e2VAOGQbVfFPY9M", in __p_Rz9kYK5e2VAOGQbVfFPY9M), n1.CompilationHelper.GetValueOrExisting(values, "__p_HKtFgMrJwErOz0bbiTBdS4", in __p_HKtFgMrJwErOz0bbiTBdS4), n1.CompilationHelper.GetValueOrExisting(values, "__p_NbLWKdUT2kpQRwcqGFZh9V", in __p_NbLWKdUT2kpQRwcqGFZh9V), n1.CompilationHelper.GetValueOrExisting(values, "__p_VnjipDTutYpLU5eXPAWXpJ", in __p_VnjipDTutYpLU5eXPAWXpJ), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL", in __pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL), n1.CompilationHelper.GetValueOrExisting(values, "__p_IJgGBLwZf4gNsZKflC4DS0", in __p_IJgGBLwZf4gNsZKflC4DS0), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2", in __pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2), n1.CompilationHelper.GetValueOrExisting(values, "__p_PS7Zwd9TKc5MYCfDD5CbZT", in __p_PS7Zwd9TKc5MYCfDD5CbZT), n1.CompilationHelper.GetValueOrExisting(values, "__p_JCPtvRO7I96LvnAppQ0xUn", in __p_JCPtvRO7I96LvnAppQ0xUn), n1.CompilationHelper.GetValueOrExisting(values, "__p_OOEYbgRTOT8MFL4J5kQvTh", in __p_OOEYbgRTOT8MFL4J5kQvTh), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky", in __pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF", in __pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF), n1.CompilationHelper.GetValueOrExisting(values, "__p_ThxWGOXGSMdOGSDpC6uHhd", in __p_ThxWGOXGSMdOGSDpC6uHhd), n1.CompilationHelper.GetValueOrExisting(values, "__p_KucWUQ47YiCOpbcZoYF6Al", in __p_KucWUQ47YiCOpbcZoYF6Al), n1.CompilationHelper.GetValueOrExisting(values, "__p_SHbWfK0BZNJPuAgdy16G9h", in __p_SHbWfK0BZNJPuAgdy16G9h), n1.CompilationHelper.GetValueOrExisting(values, "__p_QX6Rs5WrthnMvRYFv0FOpq", in __p_QX6Rs5WrthnMvRYFv0FOpq), n1.CompilationHelper.GetValueOrExisting(values, "__p_BTxZJjKtxMJOg3nvGHlgT9", in __p_BTxZJjKtxMJOg3nvGHlgT9));
        }

        internal LiveNodeViewer_C __WITH__(bool __slot_VPqkWxen8iQOJOQPvyeRWU, n31.AdaptiveViewer_C __p_QZ5TLrHbhmQQU8YfmpsQSP, n42.ForEach<n4.Object, n15.IEnumerable<n38.TimingData>, n4.Tuple<n3.IWidget, bool>> __p_RmqdD3vkSDUNcOwD9k6cc8, n37.Changed_A8JGbead2bxNdnPybiEqVS<n2.ILiveNodeApplication> __p_Rz9kYK5e2VAOGQbVfFPY9M, n42.HoldLatest<n4.Tuple<n3.IWidget, bool>> __p_HKtFgMrJwErOz0bbiTBdS4, n16.EmptyWidget_R __p_NbLWKdUT2kpQRwcqGFZh9V, n5.MessageWidgets_C __p_VnjipDTutYpLU5eXPAWXpJ, n12.Spread<n15.IEnumerable<n3.IWidget>> __pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL, n16.Column_R __p_IJgGBLwZf4gNsZKflC4DS0, n12.Spread<bool> __pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2, n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L __p_PS7Zwd9TKc5MYCfDD5CbZT, n37.SPH_RESwCzqU3iTMc4Ig82Av03<n3.IWidget> __p_JCPtvRO7I96LvnAppQ0xUn, n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k __p_OOEYbgRTOT8MFL4J5kQvTh, n12.Spread<n3.IWidget> __pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky, n12.Spread<n3.IWidget> __pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF, n16.Column_R __p_ThxWGOXGSMdOGSDpC6uHhd, n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_KucWUQ47YiCOpbcZoYF6Al, n16.PanelWidget_R __p_SHbWfK0BZNJPuAgdy16G9h, n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F __p_QX6Rs5WrthnMvRYFv0FOpq, n16.EmptyWidget_R __p_BTxZJjKtxMJOg3nvGHlgT9)
        {
            n5.LiveNodeViewer_C that_0 = this;
            this.__slot_VPqkWxen8iQOJOQPvyeRWU = __slot_VPqkWxen8iQOJOQPvyeRWU;
            this.__p_QZ5TLrHbhmQQU8YfmpsQSP = __p_QZ5TLrHbhmQQU8YfmpsQSP;
            this.__p_RmqdD3vkSDUNcOwD9k6cc8 = __p_RmqdD3vkSDUNcOwD9k6cc8;
            this.__p_Rz9kYK5e2VAOGQbVfFPY9M = __p_Rz9kYK5e2VAOGQbVfFPY9M;
            this.__p_HKtFgMrJwErOz0bbiTBdS4 = __p_HKtFgMrJwErOz0bbiTBdS4;
            this.__p_NbLWKdUT2kpQRwcqGFZh9V = __p_NbLWKdUT2kpQRwcqGFZh9V;
            this.__p_VnjipDTutYpLU5eXPAWXpJ = __p_VnjipDTutYpLU5eXPAWXpJ;
            this.__pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL = __pin_group_Input_In_CaQeFMzgXQWPGRmmwsCNsL;
            this.__p_IJgGBLwZf4gNsZKflC4DS0 = __p_IJgGBLwZf4gNsZKflC4DS0;
            this.__pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2 = __pin_group_Input_In_Ig3kyBCL5mCPsoO9g1e7S2;
            this.__p_PS7Zwd9TKc5MYCfDD5CbZT = __p_PS7Zwd9TKc5MYCfDD5CbZT;
            this.__p_JCPtvRO7I96LvnAppQ0xUn = __p_JCPtvRO7I96LvnAppQ0xUn;
            this.__p_OOEYbgRTOT8MFL4J5kQvTh = __p_OOEYbgRTOT8MFL4J5kQvTh;
            this.__pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky = __pin_group_Input_In_VaOZs2wl980NsZjtCjJ5Ky;
            this.__pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF = __pin_group_Input_In_UDkj2WrLJa9M3l2jJG8wZF;
            this.__p_ThxWGOXGSMdOGSDpC6uHhd = __p_ThxWGOXGSMdOGSDpC6uHhd;
            this.__p_KucWUQ47YiCOpbcZoYF6Al = __p_KucWUQ47YiCOpbcZoYF6Al;
            this.__p_SHbWfK0BZNJPuAgdy16G9h = __p_SHbWfK0BZNJPuAgdy16G9h;
            this.__p_QX6Rs5WrthnMvRYFv0FOpq = __p_QX6Rs5WrthnMvRYFv0FOpq;
            this.__p_BTxZJjKtxMJOg3nvGHlgT9 = __p_BTxZJjKtxMJOg3nvGHlgT9;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "COmgNu2k4nwPOhtTwjzkBn", Name = "__COmgNu2k4nwPOhtTwjzkBn")]
        [n4.SerializableAttribute]
        public class __COmgNu2k4nwPOhtTwjzkBn : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_A26qitF7hWdQUxQhCJcgKx);
                n1.CompilationHelper.SafeDispose(this.__p_JZZcJ0HDRD2QE5IhQgiGBI);
                n1.CompilationHelper.SafeDispose(this.__p_OU5pKRiqK3kQG7BbB6VNFE);
                n1.CompilationHelper.SafeDispose(this.__p_R1N1PcWWkNiLRDIGoykL7F);
                return;
            }

            [n1.ElementAttribute(TracingId = 46410U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "A26qitF7hWdQUxQhCJcgKx", Name = "SimpleTimingsWidget", IsManaged = true, IsAutoGenerated = true)]
            public n5.SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 __p_A26qitF7hWdQUxQhCJcgKx;
            [n1.ElementAttribute(TracingId = 46435U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "JZZcJ0HDRD2QE5IhQgiGBI", Name = "AdvancedTimingsWidget", IsManaged = true, IsAutoGenerated = true)]
            public n5.AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx __p_JZZcJ0HDRD2QE5IhQgiGBI;
            [n1.ElementAttribute(TracingId = 46380U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "OU5pKRiqK3kQG7BbB6VNFE", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_OU5pKRiqK3kQG7BbB6VNFE;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n3.IWidget> __pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz = default(n12.Spread<n3.IWidget>);
            [n1.ElementAttribute(TracingId = 46400U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "R1N1PcWWkNiLRDIGoykL7F", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
            public n16.Column_R __p_R1N1PcWWkNiLRDIGoykL7F;
            public __COmgNu2k4nwPOhtTwjzkBn(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __COmgNu2k4nwPOhtTwjzkBn(__COmgNu2k4nwPOhtTwjzkBn other): base(other)
            {
                this.__p_A26qitF7hWdQUxQhCJcgKx = other.__p_A26qitF7hWdQUxQhCJcgKx;
                this.__p_JZZcJ0HDRD2QE5IhQgiGBI = other.__p_JZZcJ0HDRD2QE5IhQgiGBI;
                this.__p_OU5pKRiqK3kQG7BbB6VNFE = other.__p_OU5pKRiqK3kQG7BbB6VNFE;
                this.__pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz = other.__pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz;
                this.__p_R1N1PcWWkNiLRDIGoykL7F = other.__p_R1N1PcWWkNiLRDIGoykL7F;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_A26qitF7hWdQUxQhCJcgKx", in __p_A26qitF7hWdQUxQhCJcgKx), n1.CompilationHelper.GetValueOrExisting(values, "__p_JZZcJ0HDRD2QE5IhQgiGBI", in __p_JZZcJ0HDRD2QE5IhQgiGBI), n1.CompilationHelper.GetValueOrExisting(values, "__p_OU5pKRiqK3kQG7BbB6VNFE", in __p_OU5pKRiqK3kQG7BbB6VNFE), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz", in __pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz), n1.CompilationHelper.GetValueOrExisting(values, "__p_R1N1PcWWkNiLRDIGoykL7F", in __p_R1N1PcWWkNiLRDIGoykL7F));
            }

            internal __COmgNu2k4nwPOhtTwjzkBn __WITH__(n5.SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 __p_A26qitF7hWdQUxQhCJcgKx, n5.AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx __p_JZZcJ0HDRD2QE5IhQgiGBI, n16.EmptyWidget_R __p_OU5pKRiqK3kQG7BbB6VNFE, n12.Spread<n3.IWidget> __pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz, n16.Column_R __p_R1N1PcWWkNiLRDIGoykL7F)
            {
                __COmgNu2k4nwPOhtTwjzkBn that_0 = this;
                this.__p_A26qitF7hWdQUxQhCJcgKx = __p_A26qitF7hWdQUxQhCJcgKx;
                this.__p_JZZcJ0HDRD2QE5IhQgiGBI = __p_JZZcJ0HDRD2QE5IhQgiGBI;
                this.__p_OU5pKRiqK3kQG7BbB6VNFE = __p_OU5pKRiqK3kQG7BbB6VNFE;
                this.__pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz = __pin_group_Input_In_JJzdSl9jqCJLpY8RGciLJz;
                this.__p_R1N1PcWWkNiLRDIGoykL7F = __p_R1N1PcWWkNiLRDIGoykL7F;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 53661U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Bn5S7A5D4yMMiynUDmbJ6z", Name = "LiveLinkViewer_C")]
    [n4.SerializableAttribute]
    public class LiveLinkViewer_C : n1.VLObject, n3.IElementViewer<n2.ILiveLink>, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.LiveLinkViewer_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new LiveLinkViewer_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.LiveLinkViewer_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new LiveLinkViewer_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.LiveLinkViewer_C Update_(n2.ILiveLink Value_In, n3.ViewerContext Context_In, out n3.IWidgetView Widget_Out)
        {
            n11.Vector2 __pad_LScQTJ4WBcSOxWeVFZXS7e_0 = __slot_LScQTJ4WBcSOxWeVFZXS7e;
            var Element_1 = Value_In.Element;
            var Source_2 = Value_In.Source;
            var Element_3 = Source_2.Element;
            n33.DataHub Default_4 = default(n33.DataHub);
            n34._Operations_.CastAs<n33.DataHub>(Input_In: Element_3, Default_In: Default_4, Result_Out: out n33.DataHub Result_5, Success_Out: out bool Success_6);
            var Part_7 = Source_2.Part;
            var Result_8 = n2.ElementHelpers.ComputeElementInfo(hub: Result_5, elementPart: Part_7);
            var Compiletime_Type_9 = Result_8.CompiletimeType;
            n2.IElementInfo Input_10 = (n2.IElementInfo)Result_8;
            var Is_Unused_11 = Input_10.IsUnused;
            var Output_12 = !Is_Unused_11;
            var Result_13 = Context_In.RenderTypeAsString(typeSymbol: Compiletime_Type_9);
            var State_Output_23 = this.__p_NOWIC6i6WzCNMV15tKpPwz.Update(Output_Out: out n9.TooltipPaints_C Output_14, Background_Out: out n10.SkiaPaint_R Background_15, Hint_Out: out n11.Color4 Hint_16, Warning_Out: out n11.Color4 Warning_17, Error_Out: out n11.Color4 Error_18, Runtime_Error_Out: out n11.Color4 Runtime_Error_19, Font1_Out: out n10.SkiaPaint_R Font1_20, Font2_Out: out n10.SkiaPaint_R Font2_21, Font3_Out: out n10.SkiaPaint_R Font3_22);
            this.__p_NOWIC6i6WzCNMV15tKpPwz = State_Output_23;
            var Output_25 = Font1_20.Color_(Color_Out: out n11.Color4 Color_24);
            float Scalar_26 = 0.7F;
            n45.ColorNodes.Scale(input: ref Color_24, scalar: Scalar_26, output: out n11.Color4 Output_27);
            var State_Output_29 = this.__p_MwV8ksoRazKLn3RNJQjs2K.Update(Input_In: Font1_20, Value_In: Output_27, Output_Out: out n10.SkiaPaint_R Output_28);
            this.__p_MwV8ksoRazKLn3RNJQjs2K = State_Output_29;
            bool Update_30 = true;
            var Output_31 = this.__p_ET4SkTrk5dmQceh68b2ARs;
            if (Update_30)
            {
                Output_31 = this.__p_ET4SkTrk5dmQceh68b2ARs.Update(Value_In: Result_13, Paint_In: Output_28);
            }

            this.__p_ET4SkTrk5dmQceh68b2ARs = Output_31;
            n3.IWidget Input_32 = (n3.IWidget)Output_31;
            var builder_33 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh, 1);
            builder_33.Add(Input_32);
            var __pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh_34 = builder_33.Commit();
            this.__pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh = __pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh_34;
            n13._Operations_.FromValue<n3.IWidget>(Input_In: __pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh_34, Result_Out: out n12.Spread<n3.IWidget> Result_35);
            n33.Link Default_36 = default(n33.Link);
            n34._Operations_.CastAs<n33.Link>(Input_In: Element_1, Default_In: Default_36, Result_Out: out n33.Link Result_37, Success_Out: out bool Success_38);
            var Result_39 = n2.ElementHelpers.ComputeElementInfo(link: Result_37);
            n2.IElementInfo Info_40 = (n2.IElementInfo)Result_39;
            float Scalar_41 = 0.6F;
            n45.ColorNodes.Scale(input: ref Output_27, scalar: Scalar_41, output: out n11.Color4 Output_42);
            var State_Output_44 = this.__p_SLGGfXY2LSLPuucsnyLs7j.Update(Input_In: Font1_20, Value_In: Output_42, Output_Out: out n10.SkiaPaint_R Output_43);
            this.__p_SLGGfXY2LSLPuucsnyLs7j = State_Output_44;
            var State_Output_46 = this.__p_J46h566qgpLMexXcfSLZfD.Update(Input_In: Result_35, Info_In: Info_40, Paint_In: Output_43, Output_Out: out n12.Spread<n3.IWidget> Output_45);
            this.__p_J46h566qgpLMexXcfSLZfD = State_Output_46;
            n15.IEnumerable<n3.IWidget> Widgets_47 = (n15.IEnumerable<n3.IWidget>)Output_45;
            bool Update_48 = true;
            var Output_49 = this.__p_EASaxcDlXRHLtrcvQrOUJD;
            if (Update_48)
            {
                Output_49 = this.__p_EASaxcDlXRHLtrcvQrOUJD.Update(Widgets_In: Widgets_47);
            }

            this.__p_EASaxcDlXRHLtrcvQrOUJD = Output_49;
            n3.IWidget Item_50 = (n3.IWidget)Output_49;
            n12.SpreadBuilder<n3.IWidget> Input_51 = n14._Operations_.CreateDefault<n3.IWidget>();
            n14._Operations_.Add<n3.IWidget>(Input_In: Input_51, Item_In: Item_50, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_52);
            n2.ILiveElement Input_53 = (n2.ILiveElement)Source_2;
            var Data_Stream_54 = Input_53.DataStream;
            n12.SpreadBuilder<n3.IWidget> __auto_55;
            var state_56 = n1.CompilationHelper.Restore<__NYACBRG4QJZPUK8hQkDbpz>(this.__if_L5P2qm9oa8JMyCw4YwQG4d, __GetContext__());
            if (Output_12)
            {
                if (state_56 == null)
                {
                    state_56 = new __NYACBRG4QJZPUK8hQkDbpz(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_57 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Eb87OcKOjAPNkqSXoo7IUs", 55781U);
                    var Output_58 = n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1.Create(Node_Context: Node_Context_57);
                    state_56.__p_Eb87OcKOjAPNkqSXoo7IUs = Output_58;
                }

                var State_Output_60 = state_56.__p_Eb87OcKOjAPNkqSXoo7IUs.Update(Context_In: Context_In, Messages_In: Data_Stream_54, Hub_In: Input_53, Output_Out: out n16.PanelWidget_R Output_59);
                n3.IWidget Item_61 = (n3.IWidget)Output_59;
                n14._Operations_.Add<n3.IWidget>(Input_In: Output_52, Item_In: Item_61, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_62);
                __auto_55 = Output_62;
                state_56.__p_Eb87OcKOjAPNkqSXoo7IUs = State_Output_60;
                this.__if_L5P2qm9oa8JMyCw4YwQG4d = state_56;
            }
            else
            {
                __auto_55 = Output_52;
            }

            n24._Operations_.TooltipShowOperation(Value_Out: out bool Value_63, Tooltip_Show_Operation_Out: out n23.BehaviorSubject<bool> Tooltip_Show_Operation_64);
            n2.IElementInfo Input_65 = (n2.IElementInfo)Result_39;
            var Moments_66 = Input_65.Moments;
            n21._Operations_.Any<n2.IMomentInfo>(Input_In: Moments_66, Result_Out: out bool Result_67);
            var Output_68 = Value_63 && Result_67;
            n12.SpreadBuilder<n3.IWidget> __auto_69;
            var state_70 = n1.CompilationHelper.Restore<__MLqL1B5gqJ9PRGKMpfvpqg>(this.__if_Q6TtnatWCREQRH8u84t7yw, __GetContext__());
            if (Output_68)
            {
                if (state_70 == null)
                {
                    state_70 = new __MLqL1B5gqJ9PRGKMpfvpqg(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_71 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "PVenNq0iFCIMPpY8vzF9KO", 55438U);
                    var Output_72 = n5.MomentsWidget_C.Create(Node_Context: Node_Context_71);
                    state_70.__p_PVenNq0iFCIMPpY8vzF9KO = Output_72;
                    n1.NodeContext Node_Context_73 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Ct7lKYjFrS5MOKWDD5Yvl2", 55465U);
                    var Output_74 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_73);
                    state_70.__p_Ct7lKYjFrS5MOKWDD5Yvl2 = Output_74;
                    n1.NodeContext Node_Context_75 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "G0YdFzyNCp8LQ6ThKHuMGL", 55505U);
                    var Output_76 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_75);
                    state_70.__p_G0YdFzyNCp8LQ6ThKHuMGL = Output_76;
                }

                var State_Output_78 = state_70.__p_PVenNq0iFCIMPpY8vzF9KO.Update(Input_In: Moments_66, Text_Paint_In: Font1_20, Output_Out: out n16.Row_R Output_77);
                n3.IWidget Item_79 = (n3.IWidget)Output_77;
                n11.Vector2 Default_Size_80 = __c_E3FtErKSHc7NLE9bQL3OS7;
                bool Update_81 = true;
                var Output_82 = state_70.__p_Ct7lKYjFrS5MOKWDD5Yvl2;
                if (Update_81)
                {
                    Output_82 = state_70.__p_Ct7lKYjFrS5MOKWDD5Yvl2.Update(Default_Size_In: Default_Size_80);
                }

                n3.IWidget Item_83 = (n3.IWidget)Output_82;
                n14._Operations_.Add<n3.IWidget>(Input_In: __auto_55, Item_In: Item_83, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_84);
                n14._Operations_.Add<n3.IWidget>(Input_In: Output_84, Item_In: Item_79, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_85);
                n11.Vector2 Default_Size_86 = __c_ONZFBbeG3WAOQUPJ1KJAJI;
                bool Update_87 = true;
                var Output_88 = state_70.__p_G0YdFzyNCp8LQ6ThKHuMGL;
                if (Update_87)
                {
                    Output_88 = state_70.__p_G0YdFzyNCp8LQ6ThKHuMGL.Update(Default_Size_In: Default_Size_86);
                }

                n3.IWidget Item_89 = (n3.IWidget)Output_88;
                n14._Operations_.Add<n3.IWidget>(Input_In: Output_85, Item_In: Item_89, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_90);
                __auto_69 = Output_90;
                state_70.__p_PVenNq0iFCIMPpY8vzF9KO = State_Output_78;
                state_70.__p_Ct7lKYjFrS5MOKWDD5Yvl2 = Output_82;
                state_70.__p_G0YdFzyNCp8LQ6ThKHuMGL = Output_88;
                this.__if_Q6TtnatWCREQRH8u84t7yw = state_70;
            }
            else
            {
                __auto_69 = __auto_55;
            }

            bool Recreate_91 = false;
            var Output_93 = this.__p_GeDiLoqzWEwPqehzrKbpKf.Update(Value_In: Result_39, Recreate_In: Recreate_91, Context_In: Context_In, Widget_Out: out n16.LayoutBuilder_R Widget_92);
            this.__p_GeDiLoqzWEwPqehzrKbpKf = Output_93;
            n3.IWidget Item_94 = (n3.IWidget)Widget_92;
            n14._Operations_.Add<n3.IWidget>(Input_In: __auto_69, Item_In: Item_94, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_95);
            n15.IEnumerable<n3.IWidget> Widgets_96 = (n15.IEnumerable<n3.IWidget>)Output_95;
            bool KeepOriginalWidth_97 = false;
            bool Update_98 = true;
            var Output_99 = this.__p_UTs0yJvVcAoMhZKoLatffN;
            if (Update_98)
            {
                Output_99 = this.__p_UTs0yJvVcAoMhZKoLatffN.Update(Widgets_In: Widgets_96, KeepOriginalWidth_In: KeepOriginalWidth_97);
            }

            this.__p_UTs0yJvVcAoMhZKoLatffN = Output_99;
            n3.IWidget Widget_100 = (n3.IWidget)Output_99;
            var State_Output_110 = this.__p_LIzxHVMdb7XPqtY4IPSYdd.Update(Output_Out: out n9.TooltipPaints_C Output_101, Background_Out: out n10.SkiaPaint_R Background_102, Hint_Out: out n11.Color4 Hint_103, Warning_Out: out n11.Color4 Warning_104, Error_Out: out n11.Color4 Error_105, Runtime_Error_Out: out n11.Color4 Runtime_Error_106, Font1_Out: out n10.SkiaPaint_R Font1_107, Font2_Out: out n10.SkiaPaint_R Font2_108, Font3_Out: out n10.SkiaPaint_R Font3_109);
            this.__p_LIzxHVMdb7XPqtY4IPSYdd = State_Output_110;
            n11.Vector2 Margin_111 = n18._Operations_.CreateDefault();
            bool Background_Enabled_112 = true;
            n10.SkiaPaint_R Stroke_Paint_113 = n10.SkiaPaint_R.CreateDefault();
            bool Stroke_Enabled_114 = false;
            bool Clip_Enabled_115 = false;
            bool Update_116 = true;
            var Output_117 = this.__p_P7FVdtJUojkPpMR16eH3Od;
            if (Update_116)
            {
                Output_117 = this.__p_P7FVdtJUojkPpMR16eH3Od.Update(Widget_In: Widget_100, Margin_In: Margin_111, Padding_In: __pad_LScQTJ4WBcSOxWeVFZXS7e_0, Background_Paint_In: Background_102, Background_Enabled_In: Background_Enabled_112, Stroke_Paint_In: Stroke_Paint_113, Stroke_Enabled_In: Stroke_Enabled_114, Clip_Enabled_In: Clip_Enabled_115);
            }

            this.__p_P7FVdtJUojkPpMR16eH3Od = Output_117;
            n3.IWidget Input_118 = (n3.IWidget)Output_117;
            var State_Output_120 = this.__p_DXaaqexAG7OOCCh1VgKhNz.Update(Input_In: Input_118, Output_Out: out n3.IWidgetView Output_119);
            this.__p_DXaaqexAG7OOCCh1VgKhNz = State_Output_120;
            Widget_Out = Output_119;
            return this;
        }

        public n5.LiveLinkViewer_C __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh = n13._Operations_.CreateDefault<n3.IWidget>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "GeDiLoqzWEwPqehzrKbpKf", 53693U);
            var Output_1 = n31.AdaptiveViewer_C.Create(Node_Context_In: Node_Context_0);
            this.__p_GeDiLoqzWEwPqehzrKbpKf = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "MwV8ksoRazKLn3RNJQjs2K", 53844U);
            var Output_3 = n28.SetColor_ErmwE010oOSLqOYWImAOgN.Create(Node_Context: Node_Context_2);
            this.__p_MwV8ksoRazKLn3RNJQjs2K = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "J46h566qgpLMexXcfSLZfD", 53877U);
            var Output_5 = n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX.Create(Node_Context: Node_Context_4);
            this.__p_J46h566qgpLMexXcfSLZfD = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "NOWIC6i6WzCNMV15tKpPwz", 53896U);
            var Output_7 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_6);
            this.__p_NOWIC6i6WzCNMV15tKpPwz = Output_7;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "SLGGfXY2LSLPuucsnyLs7j", 55273U);
            var Output_9 = n28.SetColor_ErmwE010oOSLqOYWImAOgN.Create(Node_Context: Node_Context_8);
            this.__p_SLGGfXY2LSLPuucsnyLs7j = Output_9;
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "ET4SkTrk5dmQceh68b2ARs", 55302U);
            var Output_11 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_10);
            this.__p_ET4SkTrk5dmQceh68b2ARs = Output_11;
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "EASaxcDlXRHLtrcvQrOUJD", 55342U);
            var Output_13 = n16.Row_R.Create(Node_Context: Node_Context_12);
            this.__p_EASaxcDlXRHLtrcvQrOUJD = Output_13;
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "UTs0yJvVcAoMhZKoLatffN", 55388U);
            var Output_15 = n16.Column_R.Create(Node_Context: Node_Context_14);
            this.__p_UTs0yJvVcAoMhZKoLatffN = Output_15;
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "LIzxHVMdb7XPqtY4IPSYdd", 55609U);
            var Output_17 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_16);
            this.__p_LIzxHVMdb7XPqtY4IPSYdd = Output_17;
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "P7FVdtJUojkPpMR16eH3Od", 55643U);
            var Output_19 = n16.PanelWidget_R.Create(Node_Context: Node_Context_18);
            this.__p_P7FVdtJUojkPpMR16eH3Od = Output_19;
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "DXaaqexAG7OOCCh1VgKhNz", 55706U);
            var Output_21 = n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F.Create(Node_Context: Node_Context_20);
            this.__p_DXaaqexAG7OOCCh1VgKhNz = Output_21;
            this.__if_L5P2qm9oa8JMyCw4YwQG4d = default(n4.Object);
            this.__if_Q6TtnatWCREQRH8u84t7yw = default(n4.Object);
            return this;
        }

        public n5.LiveLinkViewer_C __CreateDefault__()
        {
            this.__pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__p_NOWIC6i6WzCNMV15tKpPwz = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__p_MwV8ksoRazKLn3RNJQjs2K = n28.SetColor_ErmwE010oOSLqOYWImAOgN.CreateDefault();
            this.__p_ET4SkTrk5dmQceh68b2ARs = n16.TextWidget_SingleLine_R.CreateDefault();
            this.__p_SLGGfXY2LSLPuucsnyLs7j = n28.SetColor_ErmwE010oOSLqOYWImAOgN.CreateDefault();
            this.__p_J46h566qgpLMexXcfSLZfD = n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX.CreateDefault();
            this.__p_EASaxcDlXRHLtrcvQrOUJD = n16.Row_R.CreateDefault();
            this.__if_L5P2qm9oa8JMyCw4YwQG4d = default(n4.Object);
            this.__if_Q6TtnatWCREQRH8u84t7yw = default(n4.Object);
            this.__p_GeDiLoqzWEwPqehzrKbpKf = n31.AdaptiveViewer_C.CreateDefault();
            this.__p_UTs0yJvVcAoMhZKoLatffN = n16.Column_R.CreateDefault();
            this.__p_LIzxHVMdb7XPqtY4IPSYdd = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__p_P7FVdtJUojkPpMR16eH3Od = n16.PanelWidget_R.CreateDefault();
            this.__p_DXaaqexAG7OOCCh1VgKhNz = n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_NOWIC6i6WzCNMV15tKpPwz);
            n1.CompilationHelper.SafeDispose(this.__p_MwV8ksoRazKLn3RNJQjs2K);
            n1.CompilationHelper.SafeDispose(this.__p_ET4SkTrk5dmQceh68b2ARs);
            n1.CompilationHelper.SafeDispose(this.__p_SLGGfXY2LSLPuucsnyLs7j);
            n1.CompilationHelper.SafeDispose(this.__p_J46h566qgpLMexXcfSLZfD);
            n1.CompilationHelper.SafeDispose(this.__p_EASaxcDlXRHLtrcvQrOUJD);
            n1.CompilationHelper.SafeDispose(this.__if_L5P2qm9oa8JMyCw4YwQG4d);
            n1.CompilationHelper.SafeDispose(this.__if_Q6TtnatWCREQRH8u84t7yw);
            n1.CompilationHelper.SafeDispose(this.__p_GeDiLoqzWEwPqehzrKbpKf);
            n1.CompilationHelper.SafeDispose(this.__p_UTs0yJvVcAoMhZKoLatffN);
            n1.CompilationHelper.SafeDispose(this.__p_LIzxHVMdb7XPqtY4IPSYdd);
            n1.CompilationHelper.SafeDispose(this.__p_P7FVdtJUojkPpMR16eH3Od);
            n1.CompilationHelper.SafeDispose(this.__p_DXaaqexAG7OOCCh1VgKhNz);
            return;
        }

        void n3.IElementViewer<n2.ILiveLink>.Update(n2.ILiveLink value, n3.ViewerContext context, out n3.IWidgetView widget)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(value, context, out widget);
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 53841U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "LScQTJ4WBcSOxWeVFZXS7e", Name = "__slot_LScQTJ4WBcSOxWeVFZXS7e")]
        public static n11.Vector2 __slot_LScQTJ4WBcSOxWeVFZXS7e = n1.CompilationHelper.Deserialize<n11.Vector2>("0.06, 0.04", false, "QsvwBVssT9xLO3Td5ph2Z9", "LScQTJ4WBcSOxWeVFZXS7e");
        [n1.ElementAttribute(TracingId = 53896U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "NOWIC6i6WzCNMV15tKpPwz", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_NOWIC6i6WzCNMV15tKpPwz;
        [n1.ElementAttribute(TracingId = 53844U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "MwV8ksoRazKLn3RNJQjs2K", Name = "SetColor", IsManaged = true, IsAutoGenerated = true)]
        public n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_MwV8ksoRazKLn3RNJQjs2K;
        [n1.ElementAttribute(TracingId = 55302U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "ET4SkTrk5dmQceh68b2ARs", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
        public n16.TextWidget_SingleLine_R __p_ET4SkTrk5dmQceh68b2ARs;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n3.IWidget> __pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh = default(n12.Spread<n3.IWidget>);
        [n1.ElementAttribute(TracingId = 55273U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "SLGGfXY2LSLPuucsnyLs7j", Name = "SetColor", IsManaged = true, IsAutoGenerated = true)]
        public n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_SLGGfXY2LSLPuucsnyLs7j;
        [n1.ElementAttribute(TracingId = 53877U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "J46h566qgpLMexXcfSLZfD", Name = "AppendIDWidget", IsManaged = true, IsAutoGenerated = true)]
        public n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX __p_J46h566qgpLMexXcfSLZfD;
        [n1.ElementAttribute(TracingId = 55342U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "EASaxcDlXRHLtrcvQrOUJD", Name = "Row", IsManaged = true, IsAutoGenerated = true)]
        public n16.Row_R __p_EASaxcDlXRHLtrcvQrOUJD;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_L5P2qm9oa8JMyCw4YwQG4d;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_E3FtErKSHc7NLE9bQL3OS7 = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.05", false, "QsvwBVssT9xLO3Td5ph2Z9", "E3FtErKSHc7NLE9bQL3OS7");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_ONZFBbeG3WAOQUPJ1KJAJI = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.02", false, "QsvwBVssT9xLO3Td5ph2Z9", "ONZFBbeG3WAOQUPJ1KJAJI");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_Q6TtnatWCREQRH8u84t7yw;
        [n1.ElementAttribute(TracingId = 53693U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "GeDiLoqzWEwPqehzrKbpKf", Name = "AdaptiveViewer", IsManaged = true, IsAutoGenerated = true)]
        public n31.AdaptiveViewer_C __p_GeDiLoqzWEwPqehzrKbpKf;
        [n1.ElementAttribute(TracingId = 55388U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "UTs0yJvVcAoMhZKoLatffN", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
        public n16.Column_R __p_UTs0yJvVcAoMhZKoLatffN;
        [n1.ElementAttribute(TracingId = 55609U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "LIzxHVMdb7XPqtY4IPSYdd", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_LIzxHVMdb7XPqtY4IPSYdd;
        [n1.ElementAttribute(TracingId = 55643U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "P7FVdtJUojkPpMR16eH3Od", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.PanelWidget_R __p_P7FVdtJUojkPpMR16eH3Od;
        [n1.ElementAttribute(TracingId = 55706U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "DXaaqexAG7OOCCh1VgKhNz", Name = "ToWidgetView", IsManaged = true, IsAutoGenerated = true)]
        public n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F __p_DXaaqexAG7OOCCh1VgKhNz;
        static LiveLinkViewer_C()
        {
        }

        public LiveLinkViewer_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal LiveLinkViewer_C(LiveLinkViewer_C other): base(other)
        {
            this.__p_NOWIC6i6WzCNMV15tKpPwz = other.__p_NOWIC6i6WzCNMV15tKpPwz;
            this.__p_MwV8ksoRazKLn3RNJQjs2K = other.__p_MwV8ksoRazKLn3RNJQjs2K;
            this.__p_ET4SkTrk5dmQceh68b2ARs = other.__p_ET4SkTrk5dmQceh68b2ARs;
            this.__pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh = other.__pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh;
            this.__p_SLGGfXY2LSLPuucsnyLs7j = other.__p_SLGGfXY2LSLPuucsnyLs7j;
            this.__p_J46h566qgpLMexXcfSLZfD = other.__p_J46h566qgpLMexXcfSLZfD;
            this.__p_EASaxcDlXRHLtrcvQrOUJD = other.__p_EASaxcDlXRHLtrcvQrOUJD;
            this.__if_L5P2qm9oa8JMyCw4YwQG4d = other.__if_L5P2qm9oa8JMyCw4YwQG4d;
            this.__if_Q6TtnatWCREQRH8u84t7yw = other.__if_Q6TtnatWCREQRH8u84t7yw;
            this.__p_GeDiLoqzWEwPqehzrKbpKf = other.__p_GeDiLoqzWEwPqehzrKbpKf;
            this.__p_UTs0yJvVcAoMhZKoLatffN = other.__p_UTs0yJvVcAoMhZKoLatffN;
            this.__p_LIzxHVMdb7XPqtY4IPSYdd = other.__p_LIzxHVMdb7XPqtY4IPSYdd;
            this.__p_P7FVdtJUojkPpMR16eH3Od = other.__p_P7FVdtJUojkPpMR16eH3Od;
            this.__p_DXaaqexAG7OOCCh1VgKhNz = other.__p_DXaaqexAG7OOCCh1VgKhNz;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NOWIC6i6WzCNMV15tKpPwz", in __p_NOWIC6i6WzCNMV15tKpPwz), n1.CompilationHelper.GetValueOrExisting(values, "__p_MwV8ksoRazKLn3RNJQjs2K", in __p_MwV8ksoRazKLn3RNJQjs2K), n1.CompilationHelper.GetValueOrExisting(values, "__p_ET4SkTrk5dmQceh68b2ARs", in __p_ET4SkTrk5dmQceh68b2ARs), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh", in __pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh), n1.CompilationHelper.GetValueOrExisting(values, "__p_SLGGfXY2LSLPuucsnyLs7j", in __p_SLGGfXY2LSLPuucsnyLs7j), n1.CompilationHelper.GetValueOrExisting(values, "__p_J46h566qgpLMexXcfSLZfD", in __p_J46h566qgpLMexXcfSLZfD), n1.CompilationHelper.GetValueOrExisting(values, "__p_EASaxcDlXRHLtrcvQrOUJD", in __p_EASaxcDlXRHLtrcvQrOUJD), n1.CompilationHelper.GetValueOrExisting(values, "__if_L5P2qm9oa8JMyCw4YwQG4d", in __if_L5P2qm9oa8JMyCw4YwQG4d), n1.CompilationHelper.GetValueOrExisting(values, "__if_Q6TtnatWCREQRH8u84t7yw", in __if_Q6TtnatWCREQRH8u84t7yw), n1.CompilationHelper.GetValueOrExisting(values, "__p_GeDiLoqzWEwPqehzrKbpKf", in __p_GeDiLoqzWEwPqehzrKbpKf), n1.CompilationHelper.GetValueOrExisting(values, "__p_UTs0yJvVcAoMhZKoLatffN", in __p_UTs0yJvVcAoMhZKoLatffN), n1.CompilationHelper.GetValueOrExisting(values, "__p_LIzxHVMdb7XPqtY4IPSYdd", in __p_LIzxHVMdb7XPqtY4IPSYdd), n1.CompilationHelper.GetValueOrExisting(values, "__p_P7FVdtJUojkPpMR16eH3Od", in __p_P7FVdtJUojkPpMR16eH3Od), n1.CompilationHelper.GetValueOrExisting(values, "__p_DXaaqexAG7OOCCh1VgKhNz", in __p_DXaaqexAG7OOCCh1VgKhNz));
        }

        internal LiveLinkViewer_C __WITH__(n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_NOWIC6i6WzCNMV15tKpPwz, n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_MwV8ksoRazKLn3RNJQjs2K, n16.TextWidget_SingleLine_R __p_ET4SkTrk5dmQceh68b2ARs, n12.Spread<n3.IWidget> __pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh, n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_SLGGfXY2LSLPuucsnyLs7j, n5.AppendIDWidget_JEP7dJaqIRWNQyn2m7UCDX __p_J46h566qgpLMexXcfSLZfD, n16.Row_R __p_EASaxcDlXRHLtrcvQrOUJD, n4.Object __if_L5P2qm9oa8JMyCw4YwQG4d, n4.Object __if_Q6TtnatWCREQRH8u84t7yw, n31.AdaptiveViewer_C __p_GeDiLoqzWEwPqehzrKbpKf, n16.Column_R __p_UTs0yJvVcAoMhZKoLatffN, n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_LIzxHVMdb7XPqtY4IPSYdd, n16.PanelWidget_R __p_P7FVdtJUojkPpMR16eH3Od, n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F __p_DXaaqexAG7OOCCh1VgKhNz)
        {
            n5.LiveLinkViewer_C that_0 = this;
            this.__p_NOWIC6i6WzCNMV15tKpPwz = __p_NOWIC6i6WzCNMV15tKpPwz;
            this.__p_MwV8ksoRazKLn3RNJQjs2K = __p_MwV8ksoRazKLn3RNJQjs2K;
            this.__p_ET4SkTrk5dmQceh68b2ARs = __p_ET4SkTrk5dmQceh68b2ARs;
            this.__pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh = __pin_group_Input_In_Tz772Selw2BN7QQ8rt48Zh;
            this.__p_SLGGfXY2LSLPuucsnyLs7j = __p_SLGGfXY2LSLPuucsnyLs7j;
            this.__p_J46h566qgpLMexXcfSLZfD = __p_J46h566qgpLMexXcfSLZfD;
            this.__p_EASaxcDlXRHLtrcvQrOUJD = __p_EASaxcDlXRHLtrcvQrOUJD;
            this.__if_L5P2qm9oa8JMyCw4YwQG4d = __if_L5P2qm9oa8JMyCw4YwQG4d;
            this.__if_Q6TtnatWCREQRH8u84t7yw = __if_Q6TtnatWCREQRH8u84t7yw;
            this.__p_GeDiLoqzWEwPqehzrKbpKf = __p_GeDiLoqzWEwPqehzrKbpKf;
            this.__p_UTs0yJvVcAoMhZKoLatffN = __p_UTs0yJvVcAoMhZKoLatffN;
            this.__p_LIzxHVMdb7XPqtY4IPSYdd = __p_LIzxHVMdb7XPqtY4IPSYdd;
            this.__p_P7FVdtJUojkPpMR16eH3Od = __p_P7FVdtJUojkPpMR16eH3Od;
            this.__p_DXaaqexAG7OOCCh1VgKhNz = __p_DXaaqexAG7OOCCh1VgKhNz;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "NYACBRG4QJZPUK8hQkDbpz", Name = "__NYACBRG4QJZPUK8hQkDbpz")]
        [n4.SerializableAttribute]
        public class __NYACBRG4QJZPUK8hQkDbpz : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Eb87OcKOjAPNkqSXoo7IUs);
                return;
            }

            [n1.ElementAttribute(TracingId = 55781U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Eb87OcKOjAPNkqSXoo7IUs", Name = "AddLiveValue", IsManaged = true, IsAutoGenerated = true)]
            public n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 __p_Eb87OcKOjAPNkqSXoo7IUs;
            public __NYACBRG4QJZPUK8hQkDbpz(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __NYACBRG4QJZPUK8hQkDbpz(__NYACBRG4QJZPUK8hQkDbpz other): base(other)
            {
                this.__p_Eb87OcKOjAPNkqSXoo7IUs = other.__p_Eb87OcKOjAPNkqSXoo7IUs;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Eb87OcKOjAPNkqSXoo7IUs", in __p_Eb87OcKOjAPNkqSXoo7IUs));
            }

            internal __NYACBRG4QJZPUK8hQkDbpz __WITH__(n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 __p_Eb87OcKOjAPNkqSXoo7IUs)
            {
                __NYACBRG4QJZPUK8hQkDbpz that_0 = this;
                this.__p_Eb87OcKOjAPNkqSXoo7IUs = __p_Eb87OcKOjAPNkqSXoo7IUs;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "MLqL1B5gqJ9PRGKMpfvpqg", Name = "__MLqL1B5gqJ9PRGKMpfvpqg")]
        [n4.SerializableAttribute]
        public class __MLqL1B5gqJ9PRGKMpfvpqg : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_PVenNq0iFCIMPpY8vzF9KO);
                n1.CompilationHelper.SafeDispose(this.__p_Ct7lKYjFrS5MOKWDD5Yvl2);
                n1.CompilationHelper.SafeDispose(this.__p_G0YdFzyNCp8LQ6ThKHuMGL);
                return;
            }

            [n1.ElementAttribute(TracingId = 55438U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PVenNq0iFCIMPpY8vzF9KO", Name = "MomentsWidget", IsManaged = true, IsAutoGenerated = true)]
            public n5.MomentsWidget_C __p_PVenNq0iFCIMPpY8vzF9KO;
            [n1.ElementAttribute(TracingId = 55465U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Ct7lKYjFrS5MOKWDD5Yvl2", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_Ct7lKYjFrS5MOKWDD5Yvl2;
            [n1.ElementAttribute(TracingId = 55505U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "G0YdFzyNCp8LQ6ThKHuMGL", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_G0YdFzyNCp8LQ6ThKHuMGL;
            public __MLqL1B5gqJ9PRGKMpfvpqg(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MLqL1B5gqJ9PRGKMpfvpqg(__MLqL1B5gqJ9PRGKMpfvpqg other): base(other)
            {
                this.__p_PVenNq0iFCIMPpY8vzF9KO = other.__p_PVenNq0iFCIMPpY8vzF9KO;
                this.__p_Ct7lKYjFrS5MOKWDD5Yvl2 = other.__p_Ct7lKYjFrS5MOKWDD5Yvl2;
                this.__p_G0YdFzyNCp8LQ6ThKHuMGL = other.__p_G0YdFzyNCp8LQ6ThKHuMGL;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_PVenNq0iFCIMPpY8vzF9KO", in __p_PVenNq0iFCIMPpY8vzF9KO), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ct7lKYjFrS5MOKWDD5Yvl2", in __p_Ct7lKYjFrS5MOKWDD5Yvl2), n1.CompilationHelper.GetValueOrExisting(values, "__p_G0YdFzyNCp8LQ6ThKHuMGL", in __p_G0YdFzyNCp8LQ6ThKHuMGL));
            }

            internal __MLqL1B5gqJ9PRGKMpfvpqg __WITH__(n5.MomentsWidget_C __p_PVenNq0iFCIMPpY8vzF9KO, n16.EmptyWidget_R __p_Ct7lKYjFrS5MOKWDD5Yvl2, n16.EmptyWidget_R __p_G0YdFzyNCp8LQ6ThKHuMGL)
            {
                __MLqL1B5gqJ9PRGKMpfvpqg that_0 = this;
                this.__p_PVenNq0iFCIMPpY8vzF9KO = __p_PVenNq0iFCIMPpY8vzF9KO;
                this.__p_Ct7lKYjFrS5MOKWDD5Yvl2 = __p_Ct7lKYjFrS5MOKWDD5Yvl2;
                this.__p_G0YdFzyNCp8LQ6ThKHuMGL = __p_G0YdFzyNCp8LQ6ThKHuMGL;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 56117U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "CnkdVk8pDfBLJ8PhGObD7u", Name = "LinkInfoViewer_C")]
    [n4.SerializableAttribute]
    public class LinkInfoViewer_C : n1.VLObject, n3.IValueViewer<n2.ILinkInfo>, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.LinkInfoViewer_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new LinkInfoViewer_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.LinkInfoViewer_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new LinkInfoViewer_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.LinkInfoViewer_C Update_(n2.ILinkInfo Value_In, n3.ViewerContext Context_In, out n3.IWidget Widget_Out)
        {
            n2.IElementInfo Input_0 = (n2.IElementInfo)Value_In;
            var Compiler_Messages_1 = Input_0.CompilerMessages;
            string Nodename_2 = "";
            n4.Nullable<n1.UniqueId> OwnerElementID_3 = default(n4.Nullable<n1.UniqueId>);
            var Output_5 = this.__p_IfH3vcIT4kJOoBViuExxVy.Update(Nodename_In: Nodename_2, Message_In: Compiler_Messages_1, OwnerElementID_In: OwnerElementID_3, Widgets_Out: out n12.Spread<n3.IWidget> Widgets_4);
            this.__p_IfH3vcIT4kJOoBViuExxVy = Output_5;
            n15.IEnumerable<n3.IWidget> Items_6 = (n15.IEnumerable<n3.IWidget>)Widgets_4;
            n12.SpreadBuilder<n3.IWidget> Input_7 = n14._Operations_.CreateDefault<n3.IWidget>();
            n14._Operations_.AddRange<n3.IWidget>(Input_In: Input_7, Items_In: Items_6, Output_Out: out n12.SpreadBuilder<n3.IWidget> Output_8);
            n15.IEnumerable<n3.IWidget> Widgets_9 = (n15.IEnumerable<n3.IWidget>)Output_8;
            bool KeepOriginalWidth_10 = false;
            bool Update_11 = true;
            var Output_12 = this.__p_ExiVyg9n5YDMJIHDGA73wF;
            if (Update_11)
            {
                Output_12 = this.__p_ExiVyg9n5YDMJIHDGA73wF.Update(Widgets_In: Widgets_9, KeepOriginalWidth_In: KeepOriginalWidth_10);
            }

            this.__p_ExiVyg9n5YDMJIHDGA73wF = Output_12;
            n3.IWidget Widget_Out_13 = (n3.IWidget)Output_12;
            Widget_Out = Widget_Out_13;
            return this;
        }

        public n5.LinkInfoViewer_C __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "IfH3vcIT4kJOoBViuExxVy", 56131U);
            bool IsRuntime_1 = false;
            var Output_2 = n5.MessageWidgets_C.Create(Node_Context: Node_Context_0, IsRuntime_In: IsRuntime_1);
            this.__p_IfH3vcIT4kJOoBViuExxVy = Output_2;
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "ExiVyg9n5YDMJIHDGA73wF", 56189U);
            var Output_4 = n16.Column_R.Create(Node_Context: Node_Context_3);
            this.__p_ExiVyg9n5YDMJIHDGA73wF = Output_4;
            return this;
        }

        public n5.LinkInfoViewer_C __CreateDefault__()
        {
            this.__p_IfH3vcIT4kJOoBViuExxVy = n5.MessageWidgets_C.CreateDefault();
            this.__p_ExiVyg9n5YDMJIHDGA73wF = n16.Column_R.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_IfH3vcIT4kJOoBViuExxVy);
            n1.CompilationHelper.SafeDispose(this.__p_ExiVyg9n5YDMJIHDGA73wF);
            return;
        }

        void n3.IValueViewer<n2.ILinkInfo>.Update(n2.ILinkInfo value, n3.ViewerContext context, out n3.IWidget widget)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(value, context, out widget);
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 56131U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "IfH3vcIT4kJOoBViuExxVy", Name = "MessageWidgets", IsManaged = true, IsAutoGenerated = true)]
        public n5.MessageWidgets_C __p_IfH3vcIT4kJOoBViuExxVy;
        [n1.ElementAttribute(TracingId = 56189U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "ExiVyg9n5YDMJIHDGA73wF", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
        public n16.Column_R __p_ExiVyg9n5YDMJIHDGA73wF;
        public LinkInfoViewer_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal LinkInfoViewer_C(LinkInfoViewer_C other): base(other)
        {
            this.__p_IfH3vcIT4kJOoBViuExxVy = other.__p_IfH3vcIT4kJOoBViuExxVy;
            this.__p_ExiVyg9n5YDMJIHDGA73wF = other.__p_ExiVyg9n5YDMJIHDGA73wF;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IfH3vcIT4kJOoBViuExxVy", in __p_IfH3vcIT4kJOoBViuExxVy), n1.CompilationHelper.GetValueOrExisting(values, "__p_ExiVyg9n5YDMJIHDGA73wF", in __p_ExiVyg9n5YDMJIHDGA73wF));
        }

        internal LinkInfoViewer_C __WITH__(n5.MessageWidgets_C __p_IfH3vcIT4kJOoBViuExxVy, n16.Column_R __p_ExiVyg9n5YDMJIHDGA73wF)
        {
            n5.LinkInfoViewer_C that_0 = this;
            this.__p_IfH3vcIT4kJOoBViuExxVy = __p_IfH3vcIT4kJOoBViuExxVy;
            this.__p_ExiVyg9n5YDMJIHDGA73wF = __p_ExiVyg9n5YDMJIHDGA73wF;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 56268U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "SUh2roYV746MovLgyBAezs", Name = "TooltipInfoViewer_C")]
    [n4.SerializableAttribute]
    public class TooltipInfoViewer_C : n1.VLObject, n3.IElementViewer<n46.ITooltipInfo>, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.TooltipInfoViewer_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new TooltipInfoViewer_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.TooltipInfoViewer_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new TooltipInfoViewer_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.TooltipInfoViewer_C Update_(n46.ITooltipInfo Value_In, n3.ViewerContext Context_In, out n3.IWidgetView Widget_Out)
        {
            n11.Vector2 __pad_IV4eL4vOXsFO96ibvV58un_0 = __slot_IV4eL4vOXsFO96ibvV58un;
            var Tip_1 = Value_In.Tip;
            var Help_Url_2 = Value_In.HelpUrl;
            var Result_3 = string.IsNullOrWhiteSpace(value: Help_Url_2);
            var Output_4 = !Result_3;
            var State_Output_14 = this.__p_S8HNGHEUIecPedCsNyOxpZ.Update(Output_Out: out n9.TooltipPaints_C Output_5, Background_Out: out n10.SkiaPaint_R Background_6, Hint_Out: out n11.Color4 Hint_7, Warning_Out: out n11.Color4 Warning_8, Error_Out: out n11.Color4 Error_9, Runtime_Error_Out: out n11.Color4 Runtime_Error_10, Font1_Out: out n10.SkiaPaint_R Font1_11, Font2_Out: out n10.SkiaPaint_R Font2_12, Font3_Out: out n10.SkiaPaint_R Font3_13);
            this.__p_S8HNGHEUIecPedCsNyOxpZ = State_Output_14;
            float Line_Height_15 = 0.14F;
            var State_Output_17 = this.__p_Bcj5VOjCWLoQP4l6Vle911.Update(Input_In: Font1_11, Line_Height_In: Line_Height_15, Output_Out: out n10.SkiaPaint_R Output_16);
            this.__p_Bcj5VOjCWLoQP4l6Vle911 = State_Output_17;
            int Count_18 = 10;
            bool Break_at_Words_19 = true;
            bool Update_20 = true;
            var Output_21 = this.__p_IBKhzXnPZWyNPxLGLLDJqw;
            if (Update_20)
            {
                Output_21 = this.__p_IBKhzXnPZWyNPxLGLLDJqw.Update(Value_In: Tip_1, Count_In: Count_18, Break_at_Words_In: Break_at_Words_19, Paint_In: Output_16);
            }

            this.__p_IBKhzXnPZWyNPxLGLLDJqw = Output_21;
            n3.IWidget __auto_22 = (n3.IWidget)Output_21;
            n3.IWidget __auto_23;
            var state_24 = n1.CompilationHelper.Restore<__TQCrIsdbuv1PDqlI8cLzX1>(this.__if_PMXn9tPIQA4M2rWC80YXMu, __GetContext__());
            if (Output_4)
            {
                if (state_24 == null)
                {
                    state_24 = new __TQCrIsdbuv1PDqlI8cLzX1(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8 = n13._Operations_.CreateDefault<n3.IWidget>()};
                    n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "HWTJbmumE97M2xWkVE36tg", 60284U);
                    var Output_26 = n16.TextWidget_MultiLine_R.Create(Node_Context: Node_Context_25);
                    state_24.__p_HWTJbmumE97M2xWkVE36tg = Output_26;
                    n1.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "MUJIgeOny4JNfxwzrFZ6UZ", 60309U);
                    var Output_28 = n16.Row_R.Create(Node_Context: Node_Context_27);
                    state_24.__p_MUJIgeOny4JNfxwzrFZ6UZ = Output_28;
                }

                string Value_29 = "  Press [F1] for online help";
                int Count_30 = 10;
                bool Break_at_Words_31 = true;
                bool Update_32 = true;
                var Output_33 = state_24.__p_HWTJbmumE97M2xWkVE36tg;
                if (Update_32)
                {
                    Output_33 = state_24.__p_HWTJbmumE97M2xWkVE36tg.Update(Value_In: Value_29, Count_In: Count_30, Break_at_Words_In: Break_at_Words_31, Paint_In: Font2_12);
                }

                n3.IWidget Input_2_34 = (n3.IWidget)Output_33;
                var builder_35 = n6.CollectionBuilders.GetBuilder(state_24.__pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8, 2);
                builder_35.Add(__auto_22);
                builder_35.Add(Input_2_34);
                var __pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8_36 = builder_35.Commit();
                n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8_36, Result_Out: out n12.Spread<n3.IWidget> Result_37);
                n15.IEnumerable<n3.IWidget> Widgets_38 = (n15.IEnumerable<n3.IWidget>)Result_37;
                bool Update_39 = true;
                var Output_40 = state_24.__p_MUJIgeOny4JNfxwzrFZ6UZ;
                if (Update_39)
                {
                    Output_40 = state_24.__p_MUJIgeOny4JNfxwzrFZ6UZ.Update(Widgets_In: Widgets_38);
                }

                __auto_23 = (n3.IWidget)Output_40;
                state_24.__p_HWTJbmumE97M2xWkVE36tg = Output_33;
                state_24.__pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8 = __pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8_36;
                state_24.__p_MUJIgeOny4JNfxwzrFZ6UZ = Output_40;
                this.__if_PMXn9tPIQA4M2rWC80YXMu = state_24;
            }
            else
            {
                __auto_23 = __auto_22;
            }

            n11.Vector2 Margin_41 = n18._Operations_.CreateDefault();
            bool Background_Enabled_42 = true;
            n10.SkiaPaint_R Stroke_Paint_43 = n10.SkiaPaint_R.CreateDefault();
            bool Stroke_Enabled_44 = false;
            bool Clip_Enabled_45 = false;
            bool Update_46 = true;
            var Output_47 = this.__p_BjBlchZlNNkOsjuTHBgbnZ;
            if (Update_46)
            {
                Output_47 = this.__p_BjBlchZlNNkOsjuTHBgbnZ.Update(Widget_In: __auto_23, Margin_In: Margin_41, Padding_In: __pad_IV4eL4vOXsFO96ibvV58un_0, Background_Paint_In: Background_6, Background_Enabled_In: Background_Enabled_42, Stroke_Paint_In: Stroke_Paint_43, Stroke_Enabled_In: Stroke_Enabled_44, Clip_Enabled_In: Clip_Enabled_45);
            }

            this.__p_BjBlchZlNNkOsjuTHBgbnZ = Output_47;
            n3.IWidget Input_48 = (n3.IWidget)Output_47;
            var State_Output_50 = this.__p_TxfHCiDmXI7LRwQzpw4pbF.Update(Input_In: Input_48, Output_Out: out n3.IWidgetView Output_49);
            this.__p_TxfHCiDmXI7LRwQzpw4pbF = State_Output_50;
            Widget_Out = Output_49;
            return this;
        }

        public n5.TooltipInfoViewer_C __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "S8HNGHEUIecPedCsNyOxpZ", 56275U);
            var Output_1 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_0);
            this.__p_S8HNGHEUIecPedCsNyOxpZ = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "IBKhzXnPZWyNPxLGLLDJqw", 56315U);
            var Output_3 = n16.TextWidget_MultiLine_R.Create(Node_Context: Node_Context_2);
            this.__p_IBKhzXnPZWyNPxLGLLDJqw = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "BjBlchZlNNkOsjuTHBgbnZ", 60216U);
            var Output_5 = n16.PanelWidget_R.Create(Node_Context: Node_Context_4);
            this.__p_BjBlchZlNNkOsjuTHBgbnZ = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "TxfHCiDmXI7LRwQzpw4pbF", 60320U);
            var Output_7 = n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F.Create(Node_Context: Node_Context_6);
            this.__p_TxfHCiDmXI7LRwQzpw4pbF = Output_7;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Bcj5VOjCWLoQP4l6Vle911", 60329U);
            var Output_9 = n47.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a.Create(Node_Context: Node_Context_8);
            this.__p_Bcj5VOjCWLoQP4l6Vle911 = Output_9;
            this.__if_PMXn9tPIQA4M2rWC80YXMu = default(n4.Object);
            return this;
        }

        public n5.TooltipInfoViewer_C __CreateDefault__()
        {
            this.__p_S8HNGHEUIecPedCsNyOxpZ = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__p_Bcj5VOjCWLoQP4l6Vle911 = n47.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a.CreateDefault();
            this.__p_IBKhzXnPZWyNPxLGLLDJqw = n16.TextWidget_MultiLine_R.CreateDefault();
            this.__if_PMXn9tPIQA4M2rWC80YXMu = default(n4.Object);
            this.__p_BjBlchZlNNkOsjuTHBgbnZ = n16.PanelWidget_R.CreateDefault();
            this.__p_TxfHCiDmXI7LRwQzpw4pbF = n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_S8HNGHEUIecPedCsNyOxpZ);
            n1.CompilationHelper.SafeDispose(this.__p_Bcj5VOjCWLoQP4l6Vle911);
            n1.CompilationHelper.SafeDispose(this.__p_IBKhzXnPZWyNPxLGLLDJqw);
            n1.CompilationHelper.SafeDispose(this.__if_PMXn9tPIQA4M2rWC80YXMu);
            n1.CompilationHelper.SafeDispose(this.__p_BjBlchZlNNkOsjuTHBgbnZ);
            n1.CompilationHelper.SafeDispose(this.__p_TxfHCiDmXI7LRwQzpw4pbF);
            return;
        }

        void n3.IElementViewer<n46.ITooltipInfo>.Update(n46.ITooltipInfo value, n3.ViewerContext context, out n3.IWidgetView widget)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(value, context, out widget);
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 60237U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "IV4eL4vOXsFO96ibvV58un", Name = "__slot_IV4eL4vOXsFO96ibvV58un")]
        public static n11.Vector2 __slot_IV4eL4vOXsFO96ibvV58un = n1.CompilationHelper.Deserialize<n11.Vector2>("0.06, 0.04", false, "QsvwBVssT9xLO3Td5ph2Z9", "IV4eL4vOXsFO96ibvV58un");
        [n1.ElementAttribute(TracingId = 56275U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "S8HNGHEUIecPedCsNyOxpZ", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_S8HNGHEUIecPedCsNyOxpZ;
        [n1.ElementAttribute(TracingId = 60329U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Bcj5VOjCWLoQP4l6Vle911", Name = "SetLineHeight", IsManaged = true, IsAutoGenerated = true)]
        public n47.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a __p_Bcj5VOjCWLoQP4l6Vle911;
        [n1.ElementAttribute(TracingId = 56315U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "IBKhzXnPZWyNPxLGLLDJqw", Name = "TextWidget (MultiLine)", IsManaged = true, IsAutoGenerated = true)]
        public n16.TextWidget_MultiLine_R __p_IBKhzXnPZWyNPxLGLLDJqw;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_PMXn9tPIQA4M2rWC80YXMu;
        [n1.ElementAttribute(TracingId = 60216U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "BjBlchZlNNkOsjuTHBgbnZ", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.PanelWidget_R __p_BjBlchZlNNkOsjuTHBgbnZ;
        [n1.ElementAttribute(TracingId = 60320U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "TxfHCiDmXI7LRwQzpw4pbF", Name = "ToWidgetView", IsManaged = true, IsAutoGenerated = true)]
        public n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F __p_TxfHCiDmXI7LRwQzpw4pbF;
        static TooltipInfoViewer_C()
        {
        }

        public TooltipInfoViewer_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TooltipInfoViewer_C(TooltipInfoViewer_C other): base(other)
        {
            this.__p_S8HNGHEUIecPedCsNyOxpZ = other.__p_S8HNGHEUIecPedCsNyOxpZ;
            this.__p_Bcj5VOjCWLoQP4l6Vle911 = other.__p_Bcj5VOjCWLoQP4l6Vle911;
            this.__p_IBKhzXnPZWyNPxLGLLDJqw = other.__p_IBKhzXnPZWyNPxLGLLDJqw;
            this.__if_PMXn9tPIQA4M2rWC80YXMu = other.__if_PMXn9tPIQA4M2rWC80YXMu;
            this.__p_BjBlchZlNNkOsjuTHBgbnZ = other.__p_BjBlchZlNNkOsjuTHBgbnZ;
            this.__p_TxfHCiDmXI7LRwQzpw4pbF = other.__p_TxfHCiDmXI7LRwQzpw4pbF;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_S8HNGHEUIecPedCsNyOxpZ", in __p_S8HNGHEUIecPedCsNyOxpZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_Bcj5VOjCWLoQP4l6Vle911", in __p_Bcj5VOjCWLoQP4l6Vle911), n1.CompilationHelper.GetValueOrExisting(values, "__p_IBKhzXnPZWyNPxLGLLDJqw", in __p_IBKhzXnPZWyNPxLGLLDJqw), n1.CompilationHelper.GetValueOrExisting(values, "__if_PMXn9tPIQA4M2rWC80YXMu", in __if_PMXn9tPIQA4M2rWC80YXMu), n1.CompilationHelper.GetValueOrExisting(values, "__p_BjBlchZlNNkOsjuTHBgbnZ", in __p_BjBlchZlNNkOsjuTHBgbnZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_TxfHCiDmXI7LRwQzpw4pbF", in __p_TxfHCiDmXI7LRwQzpw4pbF));
        }

        internal TooltipInfoViewer_C __WITH__(n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_S8HNGHEUIecPedCsNyOxpZ, n47.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a __p_Bcj5VOjCWLoQP4l6Vle911, n16.TextWidget_MultiLine_R __p_IBKhzXnPZWyNPxLGLLDJqw, n4.Object __if_PMXn9tPIQA4M2rWC80YXMu, n16.PanelWidget_R __p_BjBlchZlNNkOsjuTHBgbnZ, n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F __p_TxfHCiDmXI7LRwQzpw4pbF)
        {
            n5.TooltipInfoViewer_C that_0 = this;
            this.__p_S8HNGHEUIecPedCsNyOxpZ = __p_S8HNGHEUIecPedCsNyOxpZ;
            this.__p_Bcj5VOjCWLoQP4l6Vle911 = __p_Bcj5VOjCWLoQP4l6Vle911;
            this.__p_IBKhzXnPZWyNPxLGLLDJqw = __p_IBKhzXnPZWyNPxLGLLDJqw;
            this.__if_PMXn9tPIQA4M2rWC80YXMu = __if_PMXn9tPIQA4M2rWC80YXMu;
            this.__p_BjBlchZlNNkOsjuTHBgbnZ = __p_BjBlchZlNNkOsjuTHBgbnZ;
            this.__p_TxfHCiDmXI7LRwQzpw4pbF = __p_TxfHCiDmXI7LRwQzpw4pbF;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "TQCrIsdbuv1PDqlI8cLzX1", Name = "__TQCrIsdbuv1PDqlI8cLzX1")]
        [n4.SerializableAttribute]
        public class __TQCrIsdbuv1PDqlI8cLzX1 : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_HWTJbmumE97M2xWkVE36tg);
                n1.CompilationHelper.SafeDispose(this.__p_MUJIgeOny4JNfxwzrFZ6UZ);
                return;
            }

            [n1.ElementAttribute(TracingId = 60284U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "HWTJbmumE97M2xWkVE36tg", Name = "TextWidget (MultiLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_MultiLine_R __p_HWTJbmumE97M2xWkVE36tg;
            [n1.ElementAttribute(TracingId = 60309U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "MUJIgeOny4JNfxwzrFZ6UZ", Name = "Row", IsManaged = true, IsAutoGenerated = true)]
            public n16.Row_R __p_MUJIgeOny4JNfxwzrFZ6UZ;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n3.IWidget> __pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8 = default(n12.Spread<n3.IWidget>);
            public __TQCrIsdbuv1PDqlI8cLzX1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __TQCrIsdbuv1PDqlI8cLzX1(__TQCrIsdbuv1PDqlI8cLzX1 other): base(other)
            {
                this.__p_HWTJbmumE97M2xWkVE36tg = other.__p_HWTJbmumE97M2xWkVE36tg;
                this.__p_MUJIgeOny4JNfxwzrFZ6UZ = other.__p_MUJIgeOny4JNfxwzrFZ6UZ;
                this.__pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8 = other.__pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HWTJbmumE97M2xWkVE36tg", in __p_HWTJbmumE97M2xWkVE36tg), n1.CompilationHelper.GetValueOrExisting(values, "__p_MUJIgeOny4JNfxwzrFZ6UZ", in __p_MUJIgeOny4JNfxwzrFZ6UZ), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8", in __pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8));
            }

            internal __TQCrIsdbuv1PDqlI8cLzX1 __WITH__(n16.TextWidget_MultiLine_R __p_HWTJbmumE97M2xWkVE36tg, n16.Row_R __p_MUJIgeOny4JNfxwzrFZ6UZ, n12.Spread<n3.IWidget> __pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8)
            {
                __TQCrIsdbuv1PDqlI8cLzX1 that_0 = this;
                this.__p_HWTJbmumE97M2xWkVE36tg = __p_HWTJbmumE97M2xWkVE36tg;
                this.__p_MUJIgeOny4JNfxwzrFZ6UZ = __p_MUJIgeOny4JNfxwzrFZ6UZ;
                this.__pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8 = __pin_group_Input_In_TfKx59OIXNDNOZKkvHPDH8;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 60393U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PmHBXYYleRYMTuy1V3TaIh", Name = "MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh")]
    [n4.SerializableAttribute]
    public class MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh : n1.VLObject, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh Create(n1.NodeContext Node_Context)
        {
            var instance = new MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh CreateDefault()
        {
            var instance = new MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh Update(string Header_In, n10.SkiaPaint_R Paint_In, string Value_In, out n16.Column_R Output_Out)
        {
            var Result_0 = string.IsNullOrWhiteSpace(value: Value_In);
            var Output_1 = !Result_0;
            n11.Color4 Value_2 = __c_RWSY60PZna9OBSAgDHdVQH;
            var State_Output_4 = this.__p_VwvPDx4Hgy8QF6RsEd2t5r.Update(Input_In: Paint_In, Value_In: Value_2, Output_Out: out n10.SkiaPaint_R Output_3);
            n25.SKTypefaceStyle Style_5 = __c_QisWAPRM8OpQL4p5iKwsv8;
            var State_Output_7 = this.__p_QZSevbXfF7VOHYeVF2Wzn9.Update(Input_In: Paint_In, Style_In: Style_5, Output_Out: out n10.SkiaPaint_R Output_6);
            n12.Spread<n3.IWidget> __auto_8;
            var state_9 = n1.CompilationHelper.Restore<__DZ8IFc1iD2qOdu1Q47NThK>(this.__if_QzNSe5WZKNFOgJHS2Y3WP7, __GetContext__());
            if (Output_1)
            {
                if (state_9 == null)
                {
                    state_9 = new __DZ8IFc1iD2qOdu1Q47NThK(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_ADWLQABhdmRPauCivXWiCr = n13._Operations_.CreateDefault<n3.IWidget>()};
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "UKKFydXucWmQYbck36cM3i", 60449U);
                    var Output_11 = n16.TextWidget_MultiLine_R.Create(Node_Context: Node_Context_10);
                    state_9.__p_UKKFydXucWmQYbck36cM3i = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "VaKJGDzG3X1NvNJc7R0kAa", 60465U);
                    var Output_13 = n16.TextWidget_MultiLine_R.Create(Node_Context: Node_Context_12);
                    state_9.__p_VaKJGDzG3X1NvNJc7R0kAa = Output_13;
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "NUIen097piqLW3ZJt31Obo", 60478U);
                    var Output_15 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_14);
                    state_9.__p_NUIen097piqLW3ZJt31Obo = Output_15;
                }

                n11.Vector2 __pad_PUbQAf2xtPANmD7OIOZVUz_16 = __slot_PUbQAf2xtPANmD7OIOZVUz;
                int Count_17 = 10;
                bool Break_at_Words_18 = true;
                bool Update_19 = true;
                var Output_20 = state_9.__p_UKKFydXucWmQYbck36cM3i;
                if (Update_19)
                {
                    Output_20 = state_9.__p_UKKFydXucWmQYbck36cM3i.Update(Value_In: Header_In, Count_In: Count_17, Break_at_Words_In: Break_at_Words_18, Paint_In: Output_6);
                }

                int Count_21 = 10;
                bool Break_at_Words_22 = true;
                bool Update_23 = true;
                var Output_24 = state_9.__p_VaKJGDzG3X1NvNJc7R0kAa;
                if (Update_23)
                {
                    Output_24 = state_9.__p_VaKJGDzG3X1NvNJc7R0kAa.Update(Value_In: Value_In, Count_In: Count_21, Break_at_Words_In: Break_at_Words_22, Paint_In: Output_3);
                }

                bool Update_25 = true;
                var Output_26 = state_9.__p_NUIen097piqLW3ZJt31Obo;
                if (Update_25)
                {
                    Output_26 = state_9.__p_NUIen097piqLW3ZJt31Obo.Update(Default_Size_In: __pad_PUbQAf2xtPANmD7OIOZVUz_16);
                }

                n3.IWidget Input_27 = (n3.IWidget)Output_26;
                n3.IWidget Input_2_28 = (n3.IWidget)Output_20;
                n3.IWidget Input_3_29 = (n3.IWidget)Output_24;
                var builder_30 = n6.CollectionBuilders.GetBuilder(state_9.__pin_group_Input_In_ADWLQABhdmRPauCivXWiCr, 3);
                builder_30.Add(Input_27);
                builder_30.Add(Input_2_28);
                builder_30.Add(Input_3_29);
                var __pin_group_Input_In_ADWLQABhdmRPauCivXWiCr_31 = builder_30.Commit();
                n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_ADWLQABhdmRPauCivXWiCr_31, Result_Out: out n12.Spread<n3.IWidget> Result_32);
                __auto_8 = Result_32;
                if (state_9.__GetContext__().IsImmutable)
                    state_9 = Output_20 != state_9.__p_UKKFydXucWmQYbck36cM3i || Output_24 != state_9.__p_VaKJGDzG3X1NvNJc7R0kAa || Output_26 != state_9.__p_NUIen097piqLW3ZJt31Obo || __pin_group_Input_In_ADWLQABhdmRPauCivXWiCr_31 != state_9.__pin_group_Input_In_ADWLQABhdmRPauCivXWiCr ? new __DZ8IFc1iD2qOdu1Q47NThK(state_9)
                    {__p_UKKFydXucWmQYbck36cM3i = Output_20, __p_VaKJGDzG3X1NvNJc7R0kAa = Output_24, __p_NUIen097piqLW3ZJt31Obo = Output_26, __pin_group_Input_In_ADWLQABhdmRPauCivXWiCr = __pin_group_Input_In_ADWLQABhdmRPauCivXWiCr_31} : state_9;
                else
                {
                    state_9.__p_UKKFydXucWmQYbck36cM3i = Output_20;
                    state_9.__p_VaKJGDzG3X1NvNJc7R0kAa = Output_24;
                    state_9.__p_NUIen097piqLW3ZJt31Obo = Output_26;
                    state_9.__pin_group_Input_In_ADWLQABhdmRPauCivXWiCr = __pin_group_Input_In_ADWLQABhdmRPauCivXWiCr_31;
                }
            }
            else
            {
                __auto_8 = n13._Operations_.CreateDefault<n3.IWidget>();
            }

            n15.IEnumerable<n3.IWidget> Widgets_33 = (n15.IEnumerable<n3.IWidget>)__auto_8;
            bool KeepOriginalWidth_34 = false;
            bool Update_35 = true;
            var Output_36 = this.__p_MMhlB8fXZF0NDysRkqPvvT;
            if (Update_35)
            {
                Output_36 = this.__p_MMhlB8fXZF0NDysRkqPvvT.Update(Widgets_In: Widgets_33, KeepOriginalWidth_In: KeepOriginalWidth_34);
            }

            Output_Out = Output_36;
            n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh that_37 = this;
            if (this.__GetContext__().IsImmutable)
                that_37 = State_Output_4 != this.__p_VwvPDx4Hgy8QF6RsEd2t5r || State_Output_7 != this.__p_QZSevbXfF7VOHYeVF2Wzn9 || state_9 != this.__if_QzNSe5WZKNFOgJHS2Y3WP7 || Output_36 != this.__p_MMhlB8fXZF0NDysRkqPvvT ? new MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh(this)
                {__p_VwvPDx4Hgy8QF6RsEd2t5r = State_Output_4, __p_QZSevbXfF7VOHYeVF2Wzn9 = State_Output_7, __if_QzNSe5WZKNFOgJHS2Y3WP7 = state_9, __p_MMhlB8fXZF0NDysRkqPvvT = Output_36} : that_37;
            else
            {
                this.__p_VwvPDx4Hgy8QF6RsEd2t5r = State_Output_4;
                this.__p_QZSevbXfF7VOHYeVF2Wzn9 = State_Output_7;
                this.__if_QzNSe5WZKNFOgJHS2Y3WP7 = state_9;
                this.__p_MMhlB8fXZF0NDysRkqPvvT = Output_36;
            }

            return that_37;
        }

        public n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "MMhlB8fXZF0NDysRkqPvvT", 60402U);
            var Output_1 = n16.Column_R.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "VwvPDx4Hgy8QF6RsEd2t5r", 60416U);
            var Output_3 = n28.SetColor_ErmwE010oOSLqOYWImAOgN.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "QZSevbXfF7VOHYeVF2Wzn9", 60430U);
            var Output_5 = n30.SetTypefaceStyle_MoGKeiO9W0hMONCpTgYUkq.Create(Node_Context: Node_Context_4);
            n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh that_6 = this;
            this.__p_MMhlB8fXZF0NDysRkqPvvT = Output_1;
            this.__p_VwvPDx4Hgy8QF6RsEd2t5r = Output_3;
            this.__p_QZSevbXfF7VOHYeVF2Wzn9 = Output_5;
            this.__if_QzNSe5WZKNFOgJHS2Y3WP7 = default(n4.Object);
            return that_6;
        }

        public n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh __CreateDefault__()
        {
            n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh that_0 = this;
            this.__p_VwvPDx4Hgy8QF6RsEd2t5r = n28.SetColor_ErmwE010oOSLqOYWImAOgN.CreateDefault();
            this.__p_QZSevbXfF7VOHYeVF2Wzn9 = n30.SetTypefaceStyle_MoGKeiO9W0hMONCpTgYUkq.CreateDefault();
            this.__if_QzNSe5WZKNFOgJHS2Y3WP7 = default(n4.Object);
            this.__p_MMhlB8fXZF0NDysRkqPvvT = n16.Column_R.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_VwvPDx4Hgy8QF6RsEd2t5r);
            n1.CompilationHelper.SafeDispose(this.__p_QZSevbXfF7VOHYeVF2Wzn9);
            n1.CompilationHelper.SafeDispose(this.__if_QzNSe5WZKNFOgJHS2Y3WP7);
            n1.CompilationHelper.SafeDispose(this.__p_MMhlB8fXZF0NDysRkqPvvT);
            return;
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 60416U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VwvPDx4Hgy8QF6RsEd2t5r", Name = "SetColor", IsManaged = true, IsAutoGenerated = true)]
        public n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_VwvPDx4Hgy8QF6RsEd2t5r;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Color4 __c_RWSY60PZna9OBSAgDHdVQH = n1.CompilationHelper.Deserialize<n11.Color4>("0.5600001, 0.5600001, 0.5600001, 1", false, "QsvwBVssT9xLO3Td5ph2Z9", "RWSY60PZna9OBSAgDHdVQH");
        [n1.ElementAttribute(TracingId = 60430U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "QZSevbXfF7VOHYeVF2Wzn9", Name = "SetTypefaceStyle", IsManaged = true, IsAutoGenerated = true)]
        public n30.SetTypefaceStyle_MoGKeiO9W0hMONCpTgYUkq __p_QZSevbXfF7VOHYeVF2Wzn9;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n25.SKTypefaceStyle __c_QisWAPRM8OpQL4p5iKwsv8 = n1.CompilationHelper.Deserialize<n25.SKTypefaceStyle>("Bold", false, "QsvwBVssT9xLO3Td5ph2Z9", "QisWAPRM8OpQL4p5iKwsv8");
        [n1.ElementAttribute(TracingId = 62840U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PUbQAf2xtPANmD7OIOZVUz", Name = "__slot_PUbQAf2xtPANmD7OIOZVUz")]
        public static n11.Vector2 __slot_PUbQAf2xtPANmD7OIOZVUz = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.05", false, "QsvwBVssT9xLO3Td5ph2Z9", "PUbQAf2xtPANmD7OIOZVUz");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_QzNSe5WZKNFOgJHS2Y3WP7;
        [n1.ElementAttribute(TracingId = 60402U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "MMhlB8fXZF0NDysRkqPvvT", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
        public n16.Column_R __p_MMhlB8fXZF0NDysRkqPvvT;
        static MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh()
        {
        }

        public MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh(MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh other): base(other)
        {
            this.__p_VwvPDx4Hgy8QF6RsEd2t5r = other.__p_VwvPDx4Hgy8QF6RsEd2t5r;
            this.__p_QZSevbXfF7VOHYeVF2Wzn9 = other.__p_QZSevbXfF7VOHYeVF2Wzn9;
            this.__if_QzNSe5WZKNFOgJHS2Y3WP7 = other.__if_QzNSe5WZKNFOgJHS2Y3WP7;
            this.__p_MMhlB8fXZF0NDysRkqPvvT = other.__p_MMhlB8fXZF0NDysRkqPvvT;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VwvPDx4Hgy8QF6RsEd2t5r", in __p_VwvPDx4Hgy8QF6RsEd2t5r), n1.CompilationHelper.GetValueOrExisting(values, "__p_QZSevbXfF7VOHYeVF2Wzn9", in __p_QZSevbXfF7VOHYeVF2Wzn9), n1.CompilationHelper.GetValueOrExisting(values, "__if_QzNSe5WZKNFOgJHS2Y3WP7", in __if_QzNSe5WZKNFOgJHS2Y3WP7), n1.CompilationHelper.GetValueOrExisting(values, "__p_MMhlB8fXZF0NDysRkqPvvT", in __p_MMhlB8fXZF0NDysRkqPvvT));
        }

        internal MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh __WITH__(n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_VwvPDx4Hgy8QF6RsEd2t5r, n30.SetTypefaceStyle_MoGKeiO9W0hMONCpTgYUkq __p_QZSevbXfF7VOHYeVF2Wzn9, n4.Object __if_QzNSe5WZKNFOgJHS2Y3WP7, n16.Column_R __p_MMhlB8fXZF0NDysRkqPvvT)
        {
            n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_VwvPDx4Hgy8QF6RsEd2t5r != this.__p_VwvPDx4Hgy8QF6RsEd2t5r || __p_QZSevbXfF7VOHYeVF2Wzn9 != this.__p_QZSevbXfF7VOHYeVF2Wzn9 || __if_QzNSe5WZKNFOgJHS2Y3WP7 != this.__if_QzNSe5WZKNFOgJHS2Y3WP7 || __p_MMhlB8fXZF0NDysRkqPvvT != this.__p_MMhlB8fXZF0NDysRkqPvvT ? new MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh(this)
                {__p_VwvPDx4Hgy8QF6RsEd2t5r = __p_VwvPDx4Hgy8QF6RsEd2t5r, __p_QZSevbXfF7VOHYeVF2Wzn9 = __p_QZSevbXfF7VOHYeVF2Wzn9, __if_QzNSe5WZKNFOgJHS2Y3WP7 = __if_QzNSe5WZKNFOgJHS2Y3WP7, __p_MMhlB8fXZF0NDysRkqPvvT = __p_MMhlB8fXZF0NDysRkqPvvT} : that_0;
            else
            {
                this.__p_VwvPDx4Hgy8QF6RsEd2t5r = __p_VwvPDx4Hgy8QF6RsEd2t5r;
                this.__p_QZSevbXfF7VOHYeVF2Wzn9 = __p_QZSevbXfF7VOHYeVF2Wzn9;
                this.__if_QzNSe5WZKNFOgJHS2Y3WP7 = __if_QzNSe5WZKNFOgJHS2Y3WP7;
                this.__p_MMhlB8fXZF0NDysRkqPvvT = __p_MMhlB8fXZF0NDysRkqPvvT;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "DZ8IFc1iD2qOdu1Q47NThK", Name = "__DZ8IFc1iD2qOdu1Q47NThK")]
        [n4.SerializableAttribute]
        public class __DZ8IFc1iD2qOdu1Q47NThK : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UKKFydXucWmQYbck36cM3i);
                n1.CompilationHelper.SafeDispose(this.__p_VaKJGDzG3X1NvNJc7R0kAa);
                n1.CompilationHelper.SafeDispose(this.__p_NUIen097piqLW3ZJt31Obo);
                return;
            }

            [n1.ElementAttribute(TracingId = 60449U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "UKKFydXucWmQYbck36cM3i", Name = "TextWidget (MultiLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_MultiLine_R __p_UKKFydXucWmQYbck36cM3i;
            [n1.ElementAttribute(TracingId = 60465U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VaKJGDzG3X1NvNJc7R0kAa", Name = "TextWidget (MultiLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_MultiLine_R __p_VaKJGDzG3X1NvNJc7R0kAa;
            [n1.ElementAttribute(TracingId = 60478U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "NUIen097piqLW3ZJt31Obo", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_NUIen097piqLW3ZJt31Obo;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n3.IWidget> __pin_group_Input_In_ADWLQABhdmRPauCivXWiCr = default(n12.Spread<n3.IWidget>);
            public __DZ8IFc1iD2qOdu1Q47NThK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DZ8IFc1iD2qOdu1Q47NThK(__DZ8IFc1iD2qOdu1Q47NThK other): base(other)
            {
                this.__p_UKKFydXucWmQYbck36cM3i = other.__p_UKKFydXucWmQYbck36cM3i;
                this.__p_VaKJGDzG3X1NvNJc7R0kAa = other.__p_VaKJGDzG3X1NvNJc7R0kAa;
                this.__p_NUIen097piqLW3ZJt31Obo = other.__p_NUIen097piqLW3ZJt31Obo;
                this.__pin_group_Input_In_ADWLQABhdmRPauCivXWiCr = other.__pin_group_Input_In_ADWLQABhdmRPauCivXWiCr;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UKKFydXucWmQYbck36cM3i", in __p_UKKFydXucWmQYbck36cM3i), n1.CompilationHelper.GetValueOrExisting(values, "__p_VaKJGDzG3X1NvNJc7R0kAa", in __p_VaKJGDzG3X1NvNJc7R0kAa), n1.CompilationHelper.GetValueOrExisting(values, "__p_NUIen097piqLW3ZJt31Obo", in __p_NUIen097piqLW3ZJt31Obo), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_ADWLQABhdmRPauCivXWiCr", in __pin_group_Input_In_ADWLQABhdmRPauCivXWiCr));
            }

            internal __DZ8IFc1iD2qOdu1Q47NThK __WITH__(n16.TextWidget_MultiLine_R __p_UKKFydXucWmQYbck36cM3i, n16.TextWidget_MultiLine_R __p_VaKJGDzG3X1NvNJc7R0kAa, n16.EmptyWidget_R __p_NUIen097piqLW3ZJt31Obo, n12.Spread<n3.IWidget> __pin_group_Input_In_ADWLQABhdmRPauCivXWiCr)
            {
                __DZ8IFc1iD2qOdu1Q47NThK that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_UKKFydXucWmQYbck36cM3i != this.__p_UKKFydXucWmQYbck36cM3i || __p_VaKJGDzG3X1NvNJc7R0kAa != this.__p_VaKJGDzG3X1NvNJc7R0kAa || __p_NUIen097piqLW3ZJt31Obo != this.__p_NUIen097piqLW3ZJt31Obo || __pin_group_Input_In_ADWLQABhdmRPauCivXWiCr != this.__pin_group_Input_In_ADWLQABhdmRPauCivXWiCr ? new __DZ8IFc1iD2qOdu1Q47NThK(this)
                    {__p_UKKFydXucWmQYbck36cM3i = __p_UKKFydXucWmQYbck36cM3i, __p_VaKJGDzG3X1NvNJc7R0kAa = __p_VaKJGDzG3X1NvNJc7R0kAa, __p_NUIen097piqLW3ZJt31Obo = __p_NUIen097piqLW3ZJt31Obo, __pin_group_Input_In_ADWLQABhdmRPauCivXWiCr = __pin_group_Input_In_ADWLQABhdmRPauCivXWiCr} : that_0;
                else
                {
                    this.__p_UKKFydXucWmQYbck36cM3i = __p_UKKFydXucWmQYbck36cM3i;
                    this.__p_VaKJGDzG3X1NvNJc7R0kAa = __p_VaKJGDzG3X1NvNJc7R0kAa;
                    this.__p_NUIen097piqLW3ZJt31Obo = __p_NUIen097piqLW3ZJt31Obo;
                    this.__pin_group_Input_In_ADWLQABhdmRPauCivXWiCr = __pin_group_Input_In_ADWLQABhdmRPauCivXWiCr;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 62908U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "AU5cVmuifavLBiwW9m3siu", Name = "MessageWidget_C")]
    [n4.SerializableAttribute]
    public class MessageWidget_C : n1.VLObject, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.MessageWidget_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new MessageWidget_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.MessageWidget_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new MessageWidget_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.MessageWidget_C Update(n48.Message Message_In, n10.SkiaPaint_R DefaultPaint_In, n4.Nullable<n1.UniqueId> OwnerElementID_In, n10.SkiaPaint_R ErrorPaint_In, n10.SkiaPaint_R WarningPaint_In, n10.SkiaPaint_R HintPaint_In, bool Show_More_Infos_In, out n3.IWidget Output_Out, out bool Has_More_Info_Out)
        {
            string __pad_RHD7zEQrZjFM4rMzavjewd_0 = __slot_RHD7zEQrZjFM4rMzavjewd;
            string __pad_MGduZeE1Y05LGPRmzutEbp_1 = __slot_MGduZeE1Y05LGPRmzutEbp;
            string __pad_L2Dcv9Cs1ngM2AHY7CXqJW_2 = __slot_L2Dcv9Cs1ngM2AHY7CXqJW;
            var What_3 = Message_In.What;
            var Location_4 = Message_In.Location;
            var Severity_5 = Message_In.Severity;
            n48.MessageSeverity Input_2_6 = __c_MOfUiGfXOU7PwvZv9lJeSZ;
            var Result_7 = Severity_5 == Input_2_6;
            n48.MessageSeverity Input_2_8 = __c_Ikisuj8Xp3vPoYxoxjVeb0;
            var Result_9 = Severity_5 == Input_2_8;
            n48.MessageSeverity Input_2_10 = __c_JqgSR7kRDCuL7Q9yKt9GrN;
            var Result_11 = Severity_5 == Input_2_10;
            var Output_12 = Result_9 || Result_7;
            var Output_13 = Output_12 || Result_11;
            bool Remove_Empty_Lines_14 = false;
            n49._Operations_.SplitToLines(Input_In: What_3, Remove_Empty_Lines_In: Remove_Empty_Lines_14, Output_Out: out n12.Spread<string> Output_15);
            string Default_Value_16 = "";
            n13._Operations_.SplitFirst<string>(Input_In: Output_15, Default_Value_In: Default_Value_16, Output_Out: out n12.Spread<string> Output_17, Result_Out: out string Result_18);
            n15.IEnumerable<string> Input_19 = (n15.IEnumerable<string>)Output_17;
            n21._Operations_.Any<string>(Input_In: Input_19, Result_Out: out bool Result_20);
            this.__slot_OavIbqdEUX2P4FCZgKpRHy = OwnerElementID_In;
            n4.Nullable<n1.UniqueId> __pad_OavIbqdEUX2P4FCZgKpRHy_21 = OwnerElementID_In;
            n29._Operations_.HasValue<n1.UniqueId>(Input_In: __pad_OavIbqdEUX2P4FCZgKpRHy_21, Output_Out: out n4.Nullable<n1.UniqueId> Output_22, Has_Value_Out: out bool Has_Value_23);
            string __auto_24;
            if (Has_Value_23)
            {
                string __pad_IQ77gcbiMF8MreYinTeEso_26 = __slot_IQ77gcbiMF8MreYinTeEso;
                n29._Operations_.Value<n1.UniqueId>(Input_In: Output_22, Output_Out: out n4.Nullable<n1.UniqueId> Output_27, Value_Out: out n1.UniqueId Value_28);
                n50._Operations_.NE<n1.UniqueId, n36.__AdaptiveImplementations__QsvwBVssT9xLO3Td5ph2Z9>(Input_In: Location_4, Input_2_In: Value_28, Result_Out: out bool Result_29);
                string __auto_30;
                if (Result_29)
                {
                    var Result_32 = n22.ObjectHelpers.ToString(input: Location_4);
                    string Input_4_33 = ")";
                    var Output_34 = n7.StringExtensions.Plus(input: Result_18, input2: __pad_IQ77gcbiMF8MreYinTeEso_26);
                    var Output_35 = n7.StringExtensions.Plus(input: Output_34, input2: Result_32);
                    var Output_36 = n7.StringExtensions.Plus(input: Output_35, input2: Input_4_33);
                    __auto_30 = Output_36;
                }
                else
                {
                    __auto_30 = Result_18;
                }

                __auto_24 = __auto_30;
            }
            else
            {
                __auto_24 = Result_18;
            }

            int Count_37 = 10;
            bool Break_at_Words_38 = true;
            bool Update_39 = true;
            var Output_40 = this.__p_Hz9qEHw7KohLGLnrvYtERb;
            if (Update_39)
            {
                Output_40 = this.__p_Hz9qEHw7KohLGLnrvYtERb.Update(Value_In: __auto_24, Count_In: Count_37, Break_at_Words_In: Break_at_Words_38, Paint_In: DefaultPaint_In);
            }

            this.__p_Hz9qEHw7KohLGLnrvYtERb = Output_40;
            n3.IWidget Input_41 = (n3.IWidget)Output_40;
            n3.IWidget Input_42 = (n3.IWidget)Output_40;
            this.__slot_LDdFHO54lzMLYjeyqVrnLp = DefaultPaint_In;
            n10.SkiaPaint_R __pad_LDdFHO54lzMLYjeyqVrnLp_43 = DefaultPaint_In;
            var Why_44 = Message_In.Why;
            var State_Output_46 = this.__p_MrzQVGxtx3ENUj7pGuvK8U.Update(Header_In: __pad_MGduZeE1Y05LGPRmzutEbp_1, Paint_In: __pad_LDdFHO54lzMLYjeyqVrnLp_43, Value_In: Why_44, Output_Out: out n16.Column_R Output_45);
            this.__p_MrzQVGxtx3ENUj7pGuvK8U = State_Output_46;
            n3.IWidget Input_2_47 = (n3.IWidget)Output_45;
            var How_48 = Message_In.How;
            var State_Output_50 = this.__p_VIjCyNiRshpLoXfnYp0HPe.Update(Header_In: __pad_L2Dcv9Cs1ngM2AHY7CXqJW_2, Paint_In: __pad_LDdFHO54lzMLYjeyqVrnLp_43, Value_In: How_48, Output_Out: out n16.Column_R Output_49);
            this.__p_VIjCyNiRshpLoXfnYp0HPe = State_Output_50;
            n3.IWidget Input_3_51 = (n3.IWidget)Output_49;
            var Ignore_52 = Message_In.Ignore;
            var State_Output_54 = this.__p_VcJNHeiPEImOsWziBElDmh.Update(Header_In: __pad_RHD7zEQrZjFM4rMzavjewd_0, Paint_In: __pad_LDdFHO54lzMLYjeyqVrnLp_43, Value_In: Ignore_52, Output_Out: out n16.Column_R Output_53);
            this.__p_VcJNHeiPEImOsWziBElDmh = State_Output_54;
            n3.IWidget Input_4_55 = (n3.IWidget)Output_53;
            var builder_56 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe, 4);
            builder_56.Add(Input_42);
            builder_56.Add(Input_2_47);
            builder_56.Add(Input_3_51);
            builder_56.Add(Input_4_55);
            var __pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe_57 = builder_56.Commit();
            this.__pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe = __pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe_57;
            n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe_57, Result_Out: out n12.Spread<n3.IWidget> Result_58);
            n15.IEnumerable<n3.IWidget> Widgets_59 = (n15.IEnumerable<n3.IWidget>)Result_58;
            bool KeepOriginalWidth_60 = false;
            bool Update_61 = true;
            var Output_62 = this.__p_RJxN5xgo71tNsVDqyylW5I;
            if (Update_61)
            {
                Output_62 = this.__p_RJxN5xgo71tNsVDqyylW5I.Update(Widgets_In: Widgets_59, KeepOriginalWidth_In: KeepOriginalWidth_60);
            }

            this.__p_RJxN5xgo71tNsVDqyylW5I = Output_62;
            n3.IWidget Input_2_63 = (n3.IWidget)Output_62;
            n8._Operations_.Switch_Boolean<n3.IWidget>(Condition_In: Show_More_Infos_In, Input_In: Input_41, Input_2_In: Input_2_63, Output_Out: out n3.IWidget Output_64);
            n15.IEnumerable<string> Values_65 = (n15.IEnumerable<string>)Output_17;
            n3.IWidget __auto_66;
            var state_67 = n1.CompilationHelper.Restore<__MyiFdBAr6lmOiXb10WASPe>(this.__if_O3l9AlurLPNL5P9Uz7I5Qw, __GetContext__());
            if (Result_20)
            {
                if (state_67 == null)
                {
                    state_67 = new __MyiFdBAr6lmOiXb10WASPe(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm = n13._Operations_.CreateDefault<n3.IWidget>()};
                    n1.NodeContext Node_Context_68 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "DGyxTjsV5m9OWo6zZh8JZS", 65157U);
                    var Output_69 = n16.Column_R.Create(Node_Context: Node_Context_68);
                    state_67.__p_DGyxTjsV5m9OWo6zZh8JZS = Output_69;
                    n1.NodeContext Node_Context_70 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "JtHwLVOLF8EP5VfXcJqRW3", 65204U);
                    var Output_71 = n28.SetColor_ErmwE010oOSLqOYWImAOgN.Create(Node_Context: Node_Context_70);
                    state_67.__p_JtHwLVOLF8EP5VfXcJqRW3 = Output_71;
                    n1.NodeContext Node_Context_72 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "VrPEi6R4SSMNeVqyK9YDVq", 65251U);
                    var Output_73 = n30.SetTextSize_HQIhACPRghoPRLMQ6s0ddX.Create(Node_Context: Node_Context_72);
                    state_67.__p_VrPEi6R4SSMNeVqyK9YDVq = Output_73;
                    n1.NodeContext Node_Context_74 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "PUJ1hubY0KcPwvk37n8Sg0", 65269U);
                    var Output_75 = n16.TextWidget_MultiLine_R.Create(Node_Context: Node_Context_74);
                    state_67.__p_PUJ1hubY0KcPwvk37n8Sg0 = Output_75;
                    n1.NodeContext Node_Context_76 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "It7KV3perKzNBJ5HiaK5DL", 65289U);
                    var Output_77 = n47.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a.Create(Node_Context: Node_Context_76);
                    state_67.__p_It7KV3perKzNBJ5HiaK5DL = Output_77;
                }

                float __pad_CsNy3syNMyJLwkrgPNF4Zv_78 = __slot_CsNy3syNMyJLwkrgPNF4Zv;
                var New_Line_79 = n7.StringExtensions.NewLine;
                var Output_80 = string.Join(separator: New_Line_79, values: Values_65);
                var Output_82 = __pad_LDdFHO54lzMLYjeyqVrnLp_43.Color_(Color_Out: out n11.Color4 Color_81);
                float Scalar_83 = 0.6F;
                n45.ColorNodes.Scale(input: ref Color_81, scalar: Scalar_83, output: out n11.Color4 Output_84);
                var State_Output_86 = state_67.__p_JtHwLVOLF8EP5VfXcJqRW3.Update(Input_In: __pad_LDdFHO54lzMLYjeyqVrnLp_43, Value_In: Output_84, Output_Out: out n10.SkiaPaint_R Output_85);
                var State_Output_88 = state_67.__p_VrPEi6R4SSMNeVqyK9YDVq.Update(Input_In: Output_85, Value_In: __pad_CsNy3syNMyJLwkrgPNF4Zv_78, Output_Out: out n10.SkiaPaint_R Output_87);
                float Line_Height_89 = 0.12F;
                var State_Output_91 = state_67.__p_It7KV3perKzNBJ5HiaK5DL.Update(Input_In: Output_87, Line_Height_In: Line_Height_89, Output_Out: out n10.SkiaPaint_R Output_90);
                int Count_92 = 99;
                bool Break_at_Words_93 = true;
                bool Update_94 = true;
                var Output_95 = state_67.__p_PUJ1hubY0KcPwvk37n8Sg0;
                if (Update_94)
                {
                    Output_95 = state_67.__p_PUJ1hubY0KcPwvk37n8Sg0.Update(Value_In: Output_80, Count_In: Count_92, Break_at_Words_In: Break_at_Words_93, Paint_In: Output_90);
                }

                n3.IWidget Input_2_96 = (n3.IWidget)Output_95;
                var builder_97 = n6.CollectionBuilders.GetBuilder(state_67.__pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm, 2);
                builder_97.Add(Output_64);
                builder_97.Add(Input_2_96);
                var __pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm_98 = builder_97.Commit();
                n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm_98, Result_Out: out n12.Spread<n3.IWidget> Result_99);
                n15.IEnumerable<n3.IWidget> Widgets_100 = (n15.IEnumerable<n3.IWidget>)Result_99;
                bool KeepOriginalWidth_101 = false;
                bool Update_102 = true;
                var Output_103 = state_67.__p_DGyxTjsV5m9OWo6zZh8JZS;
                if (Update_102)
                {
                    Output_103 = state_67.__p_DGyxTjsV5m9OWo6zZh8JZS.Update(Widgets_In: Widgets_100, KeepOriginalWidth_In: KeepOriginalWidth_101);
                }

                __auto_66 = (n3.IWidget)Output_103;
                state_67.__p_JtHwLVOLF8EP5VfXcJqRW3 = State_Output_86;
                state_67.__p_VrPEi6R4SSMNeVqyK9YDVq = State_Output_88;
                state_67.__p_It7KV3perKzNBJ5HiaK5DL = State_Output_91;
                state_67.__p_PUJ1hubY0KcPwvk37n8Sg0 = Output_95;
                state_67.__pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm = __pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm_98;
                state_67.__p_DGyxTjsV5m9OWo6zZh8JZS = Output_103;
                this.__if_O3l9AlurLPNL5P9Uz7I5Qw = state_67;
            }
            else
            {
                __auto_66 = Output_64;
            }

            this.__slot_VSw0Aw5G6xhNfaJwxhbY3P = ErrorPaint_In;
            n10.SkiaPaint_R __pad_VSw0Aw5G6xhNfaJwxhbY3P_104 = ErrorPaint_In;
            this.__slot_R0Z9UErr1IuMrNsV75w1R8 = WarningPaint_In;
            n10.SkiaPaint_R __pad_R0Z9UErr1IuMrNsV75w1R8_105 = WarningPaint_In;
            this.__slot_Ll8zQ9NjGChOCOjRtj0uTE = HintPaint_In;
            n10.SkiaPaint_R __pad_Ll8zQ9NjGChOCOjRtj0uTE_106 = HintPaint_In;
            n3.IWidget Widget_107;
            var state_108 = n1.CompilationHelper.Restore<__Js2uscqwjhWNnJ5tsyBZp5>(this.__if_Qw911s2CqplNW2M5Z6t05a, __GetContext__());
            if (Output_13)
            {
                if (state_108 == null)
                {
                    state_108 = new __Js2uscqwjhWNnJ5tsyBZp5(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_109 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Im1IsibJ1iTNfWt7eA063y", 63107U);
                    var Output_110 = n16.Row_R.Create(Node_Context: Node_Context_109);
                    state_108.__p_Im1IsibJ1iTNfWt7eA063y = Output_110;
                    n1.NodeContext Node_Context_111 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "O9hXDctf79ELyii0UEZcOC", 63118U);
                    var Output_112 = n16.PanelWidget_R.Create(Node_Context: Node_Context_111);
                    state_108.__p_O9hXDctf79ELyii0UEZcOC = Output_112;
                    n1.NodeContext Node_Context_113 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Il8EwKa8nE0LgMqNO3kbpF", 63159U);
                    var Output_114 = n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC.Create(Node_Context: Node_Context_113);
                    state_108.__p_Il8EwKa8nE0LgMqNO3kbpF = Output_114;
                }

                n8._Operations_.Switch_Boolean<n10.SkiaPaint_R>(Condition_In: Result_9, Input_In: __pad_LDdFHO54lzMLYjeyqVrnLp_43, Input_2_In: __pad_VSw0Aw5G6xhNfaJwxhbY3P_104, Output_Out: out n10.SkiaPaint_R Output_115);
                n8._Operations_.Switch_Boolean<n10.SkiaPaint_R>(Condition_In: Result_7, Input_In: Output_115, Input_2_In: __pad_R0Z9UErr1IuMrNsV75w1R8_105, Output_Out: out n10.SkiaPaint_R Output_116);
                n8._Operations_.Switch_Boolean<n10.SkiaPaint_R>(Condition_In: Result_11, Input_In: Output_116, Input_2_In: __pad_Ll8zQ9NjGChOCOjRtj0uTE_106, Output_Out: out n10.SkiaPaint_R Output_117);
                n10.SkiaPaint_R Input_118 = n10.SkiaPaint_R.CreateDefault();
                n11.Color4 Color_119 = __c_RGVTrHbiaUKLW9fXflds3L;
                n25.SKShader Shader_120 = default(n25.SKShader);
                var State_Output_122 = state_108.__p_Il8EwKa8nE0LgMqNO3kbpF.Update(Input_In: Input_118, Color_In: Color_119, Shader_In: Shader_120, Output_Out: out n10.SkiaPaint_R Output_121);
                n11.Vector2 Margin_123 = __c_ORheLJmgcknOHlx4lxt1gn;
                n11.Vector2 Padding_124 = __c_HxvdzxS5qI6Nnw8foiezfr;
                bool Background_Enabled_125 = false;
                bool Stroke_Enabled_126 = true;
                bool Clip_Enabled_127 = false;
                bool Update_128 = true;
                var Output_129 = state_108.__p_O9hXDctf79ELyii0UEZcOC;
                if (Update_128)
                {
                    Output_129 = state_108.__p_O9hXDctf79ELyii0UEZcOC.Update(Widget_In: __auto_66, Margin_In: Margin_123, Padding_In: Padding_124, Background_Paint_In: Output_121, Background_Enabled_In: Background_Enabled_125, Stroke_Paint_In: Output_117, Stroke_Enabled_In: Stroke_Enabled_126, Clip_Enabled_In: Clip_Enabled_127);
                }

                n21._Operations_.FromValue<n16.PanelWidget_R>(Input_In: Output_129, Result_Out: out n15.IEnumerable<n16.PanelWidget_R> Result_130);
                n15.IEnumerable<n3.IWidget> Widgets_131 = (n15.IEnumerable<n3.IWidget>)Result_130;
                bool Update_132 = true;
                var Output_133 = state_108.__p_Im1IsibJ1iTNfWt7eA063y;
                if (Update_132)
                {
                    Output_133 = state_108.__p_Im1IsibJ1iTNfWt7eA063y.Update(Widgets_In: Widgets_131);
                }

                Widget_107 = (n3.IWidget)Output_133;
                state_108.__p_Il8EwKa8nE0LgMqNO3kbpF = State_Output_122;
                state_108.__p_O9hXDctf79ELyii0UEZcOC = Output_129;
                state_108.__p_Im1IsibJ1iTNfWt7eA063y = Output_133;
                this.__if_Qw911s2CqplNW2M5Z6t05a = state_108;
            }
            else
            {
                Widget_107 = __auto_66;
            }

            var builder_134 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA, 3);
            builder_134.Add(Why_44);
            builder_134.Add(How_48);
            builder_134.Add(Ignore_52);
            var __pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA_135 = builder_134.Commit();
            this.__pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA = __pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA_135;
            n13._Operations_.Cons<string>(Input_In: __pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA_135, Result_Out: out n12.Spread<string> Result_136);
            n15.IEnumerable<string> Input_137 = (n15.IEnumerable<string>)Result_136;
            var __fallback___138 = n1.ServiceRegistry.Current;
            n21._Operations_.Any_Predicate<string>(Input_In: Input_137, Predicate_In: (string Arg_In_140) =>
            {
                using var __current_139 = __fallback___138.MakeCurrentIfNone();
                var Result_141 = string.IsNullOrWhiteSpace(value: Arg_In_140);
                var Output_142 = !Result_141;
                return Output_142;
            }

            , Result_Out: out bool Result_143);
            Output_Out = Widget_107;
            Has_More_Info_Out = Result_143;
            return this;
        }

        public n5.MessageWidget_C __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_LDdFHO54lzMLYjeyqVrnLp = n10.SkiaPaint_R.CreateDefault();
            this.__slot_R0Z9UErr1IuMrNsV75w1R8 = n10.SkiaPaint_R.CreateDefault();
            this.__slot_VSw0Aw5G6xhNfaJwxhbY3P = n10.SkiaPaint_R.CreateDefault();
            this.__slot_OavIbqdEUX2P4FCZgKpRHy = default(n4.Nullable<n1.UniqueId>);
            this.__slot_Ll8zQ9NjGChOCOjRtj0uTE = n10.SkiaPaint_R.CreateDefault();
            this.__pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA = n13._Operations_.CreateDefault<string>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Hz9qEHw7KohLGLnrvYtERb", 63050U);
            var Output_1 = n16.TextWidget_MultiLine_R.Create(Node_Context: Node_Context_0);
            this.__p_Hz9qEHw7KohLGLnrvYtERb = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "RJxN5xgo71tNsVDqyylW5I", 66158U);
            var Output_3 = n16.Column_R.Create(Node_Context: Node_Context_2);
            this.__p_RJxN5xgo71tNsVDqyylW5I = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "MrzQVGxtx3ENUj7pGuvK8U", 66181U);
            var Output_5 = n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh.Create(Node_Context: Node_Context_4);
            this.__p_MrzQVGxtx3ENUj7pGuvK8U = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "VIjCyNiRshpLoXfnYp0HPe", 66207U);
            var Output_7 = n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh.Create(Node_Context: Node_Context_6);
            this.__p_VIjCyNiRshpLoXfnYp0HPe = Output_7;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "VcJNHeiPEImOsWziBElDmh", 66235U);
            var Output_9 = n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh.Create(Node_Context: Node_Context_8);
            this.__p_VcJNHeiPEImOsWziBElDmh = Output_9;
            this.__if_O3l9AlurLPNL5P9Uz7I5Qw = default(n4.Object);
            this.__if_Qw911s2CqplNW2M5Z6t05a = default(n4.Object);
            return this;
        }

        public n5.MessageWidget_C __CreateDefault__()
        {
            this.__slot_LDdFHO54lzMLYjeyqVrnLp = n10.SkiaPaint_R.CreateDefault();
            this.__slot_R0Z9UErr1IuMrNsV75w1R8 = n10.SkiaPaint_R.CreateDefault();
            this.__slot_VSw0Aw5G6xhNfaJwxhbY3P = n10.SkiaPaint_R.CreateDefault();
            this.__slot_OavIbqdEUX2P4FCZgKpRHy = default(n4.Nullable<n1.UniqueId>);
            this.__slot_Ll8zQ9NjGChOCOjRtj0uTE = n10.SkiaPaint_R.CreateDefault();
            this.__pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA = n13._Operations_.CreateDefault<string>();
            this.__p_Hz9qEHw7KohLGLnrvYtERb = n16.TextWidget_MultiLine_R.CreateDefault();
            this.__p_MrzQVGxtx3ENUj7pGuvK8U = n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh.CreateDefault();
            this.__p_VIjCyNiRshpLoXfnYp0HPe = n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh.CreateDefault();
            this.__p_VcJNHeiPEImOsWziBElDmh = n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh.CreateDefault();
            this.__p_RJxN5xgo71tNsVDqyylW5I = n16.Column_R.CreateDefault();
            this.__if_O3l9AlurLPNL5P9Uz7I5Qw = default(n4.Object);
            this.__if_Qw911s2CqplNW2M5Z6t05a = default(n4.Object);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Hz9qEHw7KohLGLnrvYtERb);
            n1.CompilationHelper.SafeDispose(this.__p_MrzQVGxtx3ENUj7pGuvK8U);
            n1.CompilationHelper.SafeDispose(this.__p_VIjCyNiRshpLoXfnYp0HPe);
            n1.CompilationHelper.SafeDispose(this.__p_VcJNHeiPEImOsWziBElDmh);
            n1.CompilationHelper.SafeDispose(this.__p_RJxN5xgo71tNsVDqyylW5I);
            n1.CompilationHelper.SafeDispose(this.__if_O3l9AlurLPNL5P9Uz7I5Qw);
            n1.CompilationHelper.SafeDispose(this.__if_Qw911s2CqplNW2M5Z6t05a);
            return;
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 62943U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "LDdFHO54lzMLYjeyqVrnLp", Name = "__slot_LDdFHO54lzMLYjeyqVrnLp")]
        public n10.SkiaPaint_R __slot_LDdFHO54lzMLYjeyqVrnLp;
        [n1.ElementAttribute(TracingId = 62944U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "R0Z9UErr1IuMrNsV75w1R8", Name = "__slot_R0Z9UErr1IuMrNsV75w1R8")]
        public n10.SkiaPaint_R __slot_R0Z9UErr1IuMrNsV75w1R8;
        [n1.ElementAttribute(TracingId = 62945U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VSw0Aw5G6xhNfaJwxhbY3P", Name = "__slot_VSw0Aw5G6xhNfaJwxhbY3P")]
        public n10.SkiaPaint_R __slot_VSw0Aw5G6xhNfaJwxhbY3P;
        [n1.ElementAttribute(TracingId = 62961U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "OavIbqdEUX2P4FCZgKpRHy", Name = "__slot_OavIbqdEUX2P4FCZgKpRHy")]
        public n4.Nullable<n1.UniqueId> __slot_OavIbqdEUX2P4FCZgKpRHy;
        [n1.ElementAttribute(TracingId = 65388U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Ll8zQ9NjGChOCOjRtj0uTE", Name = "__slot_Ll8zQ9NjGChOCOjRtj0uTE")]
        public n10.SkiaPaint_R __slot_Ll8zQ9NjGChOCOjRtj0uTE;
        [n1.ElementAttribute(TracingId = 65428U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "MGduZeE1Y05LGPRmzutEbp", Name = "__slot_MGduZeE1Y05LGPRmzutEbp")]
        public static string __slot_MGduZeE1Y05LGPRmzutEbp = "Why is this a problem?";
        [n1.ElementAttribute(TracingId = 66201U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "L2Dcv9Cs1ngM2AHY7CXqJW", Name = "__slot_L2Dcv9Cs1ngM2AHY7CXqJW")]
        public static string __slot_L2Dcv9Cs1ngM2AHY7CXqJW = "How can you deal with this?";
        [n1.ElementAttribute(TracingId = 66231U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "RHD7zEQrZjFM4rMzavjewd", Name = "__slot_RHD7zEQrZjFM4rMzavjewd")]
        public static string __slot_RHD7zEQrZjFM4rMzavjewd = "When can you ignore this warning?";
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n48.MessageSeverity __c_MOfUiGfXOU7PwvZv9lJeSZ = n1.CompilationHelper.Deserialize<n48.MessageSeverity>("Warning", false, "QsvwBVssT9xLO3Td5ph2Z9", "MOfUiGfXOU7PwvZv9lJeSZ");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n48.MessageSeverity __c_Ikisuj8Xp3vPoYxoxjVeb0 = n1.CompilationHelper.Deserialize<n48.MessageSeverity>("Error", false, "QsvwBVssT9xLO3Td5ph2Z9", "Ikisuj8Xp3vPoYxoxjVeb0");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n48.MessageSeverity __c_JqgSR7kRDCuL7Q9yKt9GrN = n1.CompilationHelper.Deserialize<n48.MessageSeverity>("Info", false, "QsvwBVssT9xLO3Td5ph2Z9", "JqgSR7kRDCuL7Q9yKt9GrN");
        [n1.ElementAttribute(TracingId = 63043U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "IQ77gcbiMF8MreYinTeEso", Name = "__slot_IQ77gcbiMF8MreYinTeEso")]
        public static string __slot_IQ77gcbiMF8MreYinTeEso = " (Location: ";
        [n1.ElementAttribute(TracingId = 63050U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Hz9qEHw7KohLGLnrvYtERb", Name = "TextWidget (MultiLine)", IsManaged = true, IsAutoGenerated = true)]
        public n16.TextWidget_MultiLine_R __p_Hz9qEHw7KohLGLnrvYtERb;
        [n1.ElementAttribute(TracingId = 66181U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "MrzQVGxtx3ENUj7pGuvK8U", Name = "MessagePartWidget", IsManaged = true, IsAutoGenerated = true)]
        public n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh __p_MrzQVGxtx3ENUj7pGuvK8U;
        [n1.ElementAttribute(TracingId = 66207U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VIjCyNiRshpLoXfnYp0HPe", Name = "MessagePartWidget", IsManaged = true, IsAutoGenerated = true)]
        public n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh __p_VIjCyNiRshpLoXfnYp0HPe;
        [n1.ElementAttribute(TracingId = 66235U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VcJNHeiPEImOsWziBElDmh", Name = "MessagePartWidget", IsManaged = true, IsAutoGenerated = true)]
        public n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh __p_VcJNHeiPEImOsWziBElDmh;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n3.IWidget> __pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe = default(n12.Spread<n3.IWidget>);
        [n1.ElementAttribute(TracingId = 66158U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "RJxN5xgo71tNsVDqyylW5I", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
        public n16.Column_R __p_RJxN5xgo71tNsVDqyylW5I;
        [n1.ElementAttribute(TracingId = 65266U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "CsNy3syNMyJLwkrgPNF4Zv", Name = "__slot_CsNy3syNMyJLwkrgPNF4Zv")]
        public static float __slot_CsNy3syNMyJLwkrgPNF4Zv = 0.08F;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_O3l9AlurLPNL5P9Uz7I5Qw;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Color4 __c_RGVTrHbiaUKLW9fXflds3L = n1.CompilationHelper.Deserialize<n11.Color4>("1, 0.3900002, 0.3900002, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "RGVTrHbiaUKLW9fXflds3L");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_ORheLJmgcknOHlx4lxt1gn = n1.CompilationHelper.Deserialize<n11.Vector2>("0.01, 0.05", false, "QsvwBVssT9xLO3Td5ph2Z9", "ORheLJmgcknOHlx4lxt1gn");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_HxvdzxS5qI6Nnw8foiezfr = n1.CompilationHelper.Deserialize<n11.Vector2>("0.05, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "HxvdzxS5qI6Nnw8foiezfr");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_Qw911s2CqplNW2M5Z6t05a;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<string> __pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA = default(n12.Spread<string>);
        static MessageWidget_C()
        {
        }

        public MessageWidget_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal MessageWidget_C(MessageWidget_C other): base(other)
        {
            this.__slot_LDdFHO54lzMLYjeyqVrnLp = other.__slot_LDdFHO54lzMLYjeyqVrnLp;
            this.__slot_R0Z9UErr1IuMrNsV75w1R8 = other.__slot_R0Z9UErr1IuMrNsV75w1R8;
            this.__slot_VSw0Aw5G6xhNfaJwxhbY3P = other.__slot_VSw0Aw5G6xhNfaJwxhbY3P;
            this.__slot_OavIbqdEUX2P4FCZgKpRHy = other.__slot_OavIbqdEUX2P4FCZgKpRHy;
            this.__slot_Ll8zQ9NjGChOCOjRtj0uTE = other.__slot_Ll8zQ9NjGChOCOjRtj0uTE;
            this.__p_Hz9qEHw7KohLGLnrvYtERb = other.__p_Hz9qEHw7KohLGLnrvYtERb;
            this.__p_MrzQVGxtx3ENUj7pGuvK8U = other.__p_MrzQVGxtx3ENUj7pGuvK8U;
            this.__p_VIjCyNiRshpLoXfnYp0HPe = other.__p_VIjCyNiRshpLoXfnYp0HPe;
            this.__p_VcJNHeiPEImOsWziBElDmh = other.__p_VcJNHeiPEImOsWziBElDmh;
            this.__pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe = other.__pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe;
            this.__p_RJxN5xgo71tNsVDqyylW5I = other.__p_RJxN5xgo71tNsVDqyylW5I;
            this.__if_O3l9AlurLPNL5P9Uz7I5Qw = other.__if_O3l9AlurLPNL5P9Uz7I5Qw;
            this.__if_Qw911s2CqplNW2M5Z6t05a = other.__if_Qw911s2CqplNW2M5Z6t05a;
            this.__pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA = other.__pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_LDdFHO54lzMLYjeyqVrnLp", in __slot_LDdFHO54lzMLYjeyqVrnLp), n1.CompilationHelper.GetValueOrExisting(values, "__slot_R0Z9UErr1IuMrNsV75w1R8", in __slot_R0Z9UErr1IuMrNsV75w1R8), n1.CompilationHelper.GetValueOrExisting(values, "__slot_VSw0Aw5G6xhNfaJwxhbY3P", in __slot_VSw0Aw5G6xhNfaJwxhbY3P), n1.CompilationHelper.GetValueOrExisting(values, "__slot_OavIbqdEUX2P4FCZgKpRHy", in __slot_OavIbqdEUX2P4FCZgKpRHy), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Ll8zQ9NjGChOCOjRtj0uTE", in __slot_Ll8zQ9NjGChOCOjRtj0uTE), n1.CompilationHelper.GetValueOrExisting(values, "__p_Hz9qEHw7KohLGLnrvYtERb", in __p_Hz9qEHw7KohLGLnrvYtERb), n1.CompilationHelper.GetValueOrExisting(values, "__p_MrzQVGxtx3ENUj7pGuvK8U", in __p_MrzQVGxtx3ENUj7pGuvK8U), n1.CompilationHelper.GetValueOrExisting(values, "__p_VIjCyNiRshpLoXfnYp0HPe", in __p_VIjCyNiRshpLoXfnYp0HPe), n1.CompilationHelper.GetValueOrExisting(values, "__p_VcJNHeiPEImOsWziBElDmh", in __p_VcJNHeiPEImOsWziBElDmh), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe", in __pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe), n1.CompilationHelper.GetValueOrExisting(values, "__p_RJxN5xgo71tNsVDqyylW5I", in __p_RJxN5xgo71tNsVDqyylW5I), n1.CompilationHelper.GetValueOrExisting(values, "__if_O3l9AlurLPNL5P9Uz7I5Qw", in __if_O3l9AlurLPNL5P9Uz7I5Qw), n1.CompilationHelper.GetValueOrExisting(values, "__if_Qw911s2CqplNW2M5Z6t05a", in __if_Qw911s2CqplNW2M5Z6t05a), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA", in __pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA));
        }

        internal MessageWidget_C __WITH__(n10.SkiaPaint_R __slot_LDdFHO54lzMLYjeyqVrnLp, n10.SkiaPaint_R __slot_R0Z9UErr1IuMrNsV75w1R8, n10.SkiaPaint_R __slot_VSw0Aw5G6xhNfaJwxhbY3P, n4.Nullable<n1.UniqueId> __slot_OavIbqdEUX2P4FCZgKpRHy, n10.SkiaPaint_R __slot_Ll8zQ9NjGChOCOjRtj0uTE, n16.TextWidget_MultiLine_R __p_Hz9qEHw7KohLGLnrvYtERb, n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh __p_MrzQVGxtx3ENUj7pGuvK8U, n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh __p_VIjCyNiRshpLoXfnYp0HPe, n5.MessagePartWidget_PmHBXYYleRYMTuy1V3TaIh __p_VcJNHeiPEImOsWziBElDmh, n12.Spread<n3.IWidget> __pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe, n16.Column_R __p_RJxN5xgo71tNsVDqyylW5I, n4.Object __if_O3l9AlurLPNL5P9Uz7I5Qw, n4.Object __if_Qw911s2CqplNW2M5Z6t05a, n12.Spread<string> __pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA)
        {
            n5.MessageWidget_C that_0 = this;
            this.__slot_LDdFHO54lzMLYjeyqVrnLp = __slot_LDdFHO54lzMLYjeyqVrnLp;
            this.__slot_R0Z9UErr1IuMrNsV75w1R8 = __slot_R0Z9UErr1IuMrNsV75w1R8;
            this.__slot_VSw0Aw5G6xhNfaJwxhbY3P = __slot_VSw0Aw5G6xhNfaJwxhbY3P;
            this.__slot_OavIbqdEUX2P4FCZgKpRHy = __slot_OavIbqdEUX2P4FCZgKpRHy;
            this.__slot_Ll8zQ9NjGChOCOjRtj0uTE = __slot_Ll8zQ9NjGChOCOjRtj0uTE;
            this.__p_Hz9qEHw7KohLGLnrvYtERb = __p_Hz9qEHw7KohLGLnrvYtERb;
            this.__p_MrzQVGxtx3ENUj7pGuvK8U = __p_MrzQVGxtx3ENUj7pGuvK8U;
            this.__p_VIjCyNiRshpLoXfnYp0HPe = __p_VIjCyNiRshpLoXfnYp0HPe;
            this.__p_VcJNHeiPEImOsWziBElDmh = __p_VcJNHeiPEImOsWziBElDmh;
            this.__pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe = __pin_group_Input_In_PabJBIt2MFHPtxpdAilbZe;
            this.__p_RJxN5xgo71tNsVDqyylW5I = __p_RJxN5xgo71tNsVDqyylW5I;
            this.__if_O3l9AlurLPNL5P9Uz7I5Qw = __if_O3l9AlurLPNL5P9Uz7I5Qw;
            this.__if_Qw911s2CqplNW2M5Z6t05a = __if_Qw911s2CqplNW2M5Z6t05a;
            this.__pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA = __pin_group_Input_In_GKkMfBkzZCYQTHk7L7J5SA;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "MyiFdBAr6lmOiXb10WASPe", Name = "__MyiFdBAr6lmOiXb10WASPe")]
        [n4.SerializableAttribute]
        public class __MyiFdBAr6lmOiXb10WASPe : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_DGyxTjsV5m9OWo6zZh8JZS);
                n1.CompilationHelper.SafeDispose(this.__p_JtHwLVOLF8EP5VfXcJqRW3);
                n1.CompilationHelper.SafeDispose(this.__p_VrPEi6R4SSMNeVqyK9YDVq);
                n1.CompilationHelper.SafeDispose(this.__p_PUJ1hubY0KcPwvk37n8Sg0);
                n1.CompilationHelper.SafeDispose(this.__p_It7KV3perKzNBJ5HiaK5DL);
                return;
            }

            [n1.ElementAttribute(TracingId = 65157U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "DGyxTjsV5m9OWo6zZh8JZS", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
            public n16.Column_R __p_DGyxTjsV5m9OWo6zZh8JZS;
            [n1.ElementAttribute(TracingId = 65204U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "JtHwLVOLF8EP5VfXcJqRW3", Name = "SetColor", IsManaged = true, IsAutoGenerated = true)]
            public n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_JtHwLVOLF8EP5VfXcJqRW3;
            [n1.ElementAttribute(TracingId = 65251U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VrPEi6R4SSMNeVqyK9YDVq", Name = "SetTextSize", IsManaged = true, IsAutoGenerated = true)]
            public n30.SetTextSize_HQIhACPRghoPRLMQ6s0ddX __p_VrPEi6R4SSMNeVqyK9YDVq;
            [n1.ElementAttribute(TracingId = 65269U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PUJ1hubY0KcPwvk37n8Sg0", Name = "TextWidget (MultiLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_MultiLine_R __p_PUJ1hubY0KcPwvk37n8Sg0;
            [n1.ElementAttribute(TracingId = 65289U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "It7KV3perKzNBJ5HiaK5DL", Name = "SetLineHeight", IsManaged = true, IsAutoGenerated = true)]
            public n47.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a __p_It7KV3perKzNBJ5HiaK5DL;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n3.IWidget> __pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm = default(n12.Spread<n3.IWidget>);
            public __MyiFdBAr6lmOiXb10WASPe(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MyiFdBAr6lmOiXb10WASPe(__MyiFdBAr6lmOiXb10WASPe other): base(other)
            {
                this.__p_DGyxTjsV5m9OWo6zZh8JZS = other.__p_DGyxTjsV5m9OWo6zZh8JZS;
                this.__p_JtHwLVOLF8EP5VfXcJqRW3 = other.__p_JtHwLVOLF8EP5VfXcJqRW3;
                this.__p_VrPEi6R4SSMNeVqyK9YDVq = other.__p_VrPEi6R4SSMNeVqyK9YDVq;
                this.__p_PUJ1hubY0KcPwvk37n8Sg0 = other.__p_PUJ1hubY0KcPwvk37n8Sg0;
                this.__p_It7KV3perKzNBJ5HiaK5DL = other.__p_It7KV3perKzNBJ5HiaK5DL;
                this.__pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm = other.__pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DGyxTjsV5m9OWo6zZh8JZS", in __p_DGyxTjsV5m9OWo6zZh8JZS), n1.CompilationHelper.GetValueOrExisting(values, "__p_JtHwLVOLF8EP5VfXcJqRW3", in __p_JtHwLVOLF8EP5VfXcJqRW3), n1.CompilationHelper.GetValueOrExisting(values, "__p_VrPEi6R4SSMNeVqyK9YDVq", in __p_VrPEi6R4SSMNeVqyK9YDVq), n1.CompilationHelper.GetValueOrExisting(values, "__p_PUJ1hubY0KcPwvk37n8Sg0", in __p_PUJ1hubY0KcPwvk37n8Sg0), n1.CompilationHelper.GetValueOrExisting(values, "__p_It7KV3perKzNBJ5HiaK5DL", in __p_It7KV3perKzNBJ5HiaK5DL), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm", in __pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm));
            }

            internal __MyiFdBAr6lmOiXb10WASPe __WITH__(n16.Column_R __p_DGyxTjsV5m9OWo6zZh8JZS, n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_JtHwLVOLF8EP5VfXcJqRW3, n30.SetTextSize_HQIhACPRghoPRLMQ6s0ddX __p_VrPEi6R4SSMNeVqyK9YDVq, n16.TextWidget_MultiLine_R __p_PUJ1hubY0KcPwvk37n8Sg0, n47.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a __p_It7KV3perKzNBJ5HiaK5DL, n12.Spread<n3.IWidget> __pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm)
            {
                __MyiFdBAr6lmOiXb10WASPe that_0 = this;
                this.__p_DGyxTjsV5m9OWo6zZh8JZS = __p_DGyxTjsV5m9OWo6zZh8JZS;
                this.__p_JtHwLVOLF8EP5VfXcJqRW3 = __p_JtHwLVOLF8EP5VfXcJqRW3;
                this.__p_VrPEi6R4SSMNeVqyK9YDVq = __p_VrPEi6R4SSMNeVqyK9YDVq;
                this.__p_PUJ1hubY0KcPwvk37n8Sg0 = __p_PUJ1hubY0KcPwvk37n8Sg0;
                this.__p_It7KV3perKzNBJ5HiaK5DL = __p_It7KV3perKzNBJ5HiaK5DL;
                this.__pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm = __pin_group_Input_In_VPkck8oJ84QOuCjJbppGAm;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Js2uscqwjhWNnJ5tsyBZp5", Name = "__Js2uscqwjhWNnJ5tsyBZp5")]
        [n4.SerializableAttribute]
        public class __Js2uscqwjhWNnJ5tsyBZp5 : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Im1IsibJ1iTNfWt7eA063y);
                n1.CompilationHelper.SafeDispose(this.__p_O9hXDctf79ELyii0UEZcOC);
                n1.CompilationHelper.SafeDispose(this.__p_Il8EwKa8nE0LgMqNO3kbpF);
                return;
            }

            [n1.ElementAttribute(TracingId = 63107U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Im1IsibJ1iTNfWt7eA063y", Name = "Row", IsManaged = true, IsAutoGenerated = true)]
            public n16.Row_R __p_Im1IsibJ1iTNfWt7eA063y;
            [n1.ElementAttribute(TracingId = 63118U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "O9hXDctf79ELyii0UEZcOC", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.PanelWidget_R __p_O9hXDctf79ELyii0UEZcOC;
            [n1.ElementAttribute(TracingId = 63159U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Il8EwKa8nE0LgMqNO3kbpF", Name = "Fill", IsManaged = true, IsAutoGenerated = true)]
            public n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_Il8EwKa8nE0LgMqNO3kbpF;
            public __Js2uscqwjhWNnJ5tsyBZp5(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Js2uscqwjhWNnJ5tsyBZp5(__Js2uscqwjhWNnJ5tsyBZp5 other): base(other)
            {
                this.__p_Im1IsibJ1iTNfWt7eA063y = other.__p_Im1IsibJ1iTNfWt7eA063y;
                this.__p_O9hXDctf79ELyii0UEZcOC = other.__p_O9hXDctf79ELyii0UEZcOC;
                this.__p_Il8EwKa8nE0LgMqNO3kbpF = other.__p_Il8EwKa8nE0LgMqNO3kbpF;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Im1IsibJ1iTNfWt7eA063y", in __p_Im1IsibJ1iTNfWt7eA063y), n1.CompilationHelper.GetValueOrExisting(values, "__p_O9hXDctf79ELyii0UEZcOC", in __p_O9hXDctf79ELyii0UEZcOC), n1.CompilationHelper.GetValueOrExisting(values, "__p_Il8EwKa8nE0LgMqNO3kbpF", in __p_Il8EwKa8nE0LgMqNO3kbpF));
            }

            internal __Js2uscqwjhWNnJ5tsyBZp5 __WITH__(n16.Row_R __p_Im1IsibJ1iTNfWt7eA063y, n16.PanelWidget_R __p_O9hXDctf79ELyii0UEZcOC, n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_Il8EwKa8nE0LgMqNO3kbpF)
            {
                __Js2uscqwjhWNnJ5tsyBZp5 that_0 = this;
                this.__p_Im1IsibJ1iTNfWt7eA063y = __p_Im1IsibJ1iTNfWt7eA063y;
                this.__p_O9hXDctf79ELyii0UEZcOC = __p_O9hXDctf79ELyii0UEZcOC;
                this.__p_Il8EwKa8nE0LgMqNO3kbpF = __p_Il8EwKa8nE0LgMqNO3kbpF;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 66736U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "O4iB5zGdXpgL3iFyMrBnhT", Name = "MessageWidgets_C")]
    [n4.SerializableAttribute]
    public class MessageWidgets_C : n1.VLObject, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.MessageWidgets_C Create(n1.NodeContext Node_Context, bool IsRuntime_In)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new MessageWidgets_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, IsRuntime_In);
        }

        [n6.CreateDefaultAttribute]
        public static n5.MessageWidgets_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new MessageWidgets_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.MessageWidgets_C Update(string Nodename_In, n15.IEnumerable<n48.Message> Message_In, n4.Nullable<n1.UniqueId> OwnerElementID_In, out n12.Spread<n3.IWidget> Widgets_Out)
        {
            n10.SkiaPaint_R __auto_0 = this.DefaultPaint;
            n10.SkiaPaint_R __auto_1 = this.WarningPaint;
            n10.SkiaPaint_R __auto_2 = this.ErrorPaint;
            n10.SkiaPaint_R __auto_3 = this.HintPaint;
            bool __auto_4 = this.InfoShowing;
            n23.BehaviorSubject<bool> __pad_LKnyQJnQCrENfrABmUIAbl_5 = this.__slot_LKnyQJnQCrENfrABmUIAbl;
            string __pad_HDRtbsath07MRQ8S0z8bue_6 = __slot_HDRtbsath07MRQ8S0z8bue;
            string __pad_I6Mmh1xsjSTNoB5p3VFwLY_7 = __slot_I6Mmh1xsjSTNoB5p3VFwLY;
            var New_Line_8 = n7.StringExtensions.NewLine;
            var __fallback___9 = n1.ServiceRegistry.Current;
            n21._Operations_.Distinct_Selector<n48.Message, string>(Input_In: Message_In, Key_Selector_In: (n48.Message Arg_In_11) =>
            {
                using var __current_10 = __fallback___9.MakeCurrentIfNone();
                var What_12 = Arg_In_11.What;
                bool Remove_Empty_Lines_13 = false;
                n49._Operations_.SplitToLines(Input_In: What_12, Remove_Empty_Lines_In: Remove_Empty_Lines_13, Output_Out: out n12.Spread<string> Output_14);
                string Default_Value_15 = "";
                n21._Operations_.FirstOrDefault<n12.Spread<string>, string>(Input_In: Output_14, Default_Value_In: Default_Value_15, Output_Out: out n12.Spread<string> Output_16, Result_Out: out string Result_17);
                return Result_17;
            }

            , Output_Out: out n15.IEnumerable<n48.Message> Output_18);
            n21._Operations_.OrderByDescending<n48.Message, int>(Input_In: Output_18, Key_Selector_In: (n48.Message Arg_In_20) =>
            {
                using var __current_19 = __fallback___9.MakeCurrentIfNone();
                var Severity_21 = Arg_In_20.Severity;
                int Result_Out_22 = (int)Severity_21;
                return Result_Out_22;
            }

            , Result_Out: out n51.IOrderedEnumerable<n48.Message> Result_23);
            n52.Key Key_24 = __c_Pz8LwdZ8w91PrkDTorghIh;
            var Result_25 = n52.Keyboard.IsKeyDown(key: Key_24);
            var Output_28 = this.__p_GMMraF1hfdZLKFaxtDtuxV.Update(Value_In: Result_25, Up_Edge_Out: out bool Up_Edge_26, Down_Edge_Out: out bool Down_Edge_27);
            this.__p_GMMraF1hfdZLKFaxtDtuxV = Output_28;
            var Output_29 = !__auto_4;
            n8._Operations_.Switch_Boolean<bool>(Condition_In: Up_Edge_26, Input_In: __auto_4, Input_2_In: Output_29, Output_Out: out bool Output_30);
            this.InfoShowing = Output_30;
            bool __auto_31 = Output_30;
            var manager_43 = this.__loop_AC5fTFusxJvOAfPcKO3LVO ?? new n53.ImmutableLifetimeManager();
            var iterator_44 = manager_43.GetIterator(__GetContext__());
            var builder_45 = n6.CollectionBuilders.GetBuilder(this.__cp_JKPvTOLmPAKN7oP1P0Gzre, 16);
            n12.Spread<string> output_46;
            var builder_47 = n6.CollectionBuilders.GetBuilder(this.__cp_VzQvXB8x6U0Oiq84x1LfmI, 16);
            n12.Spread<n3.IWidget> output_48;
            var builder_49 = n6.CollectionBuilders.GetBuilder(this.__cp_VUU4q92RD3zP8UD3miOgWN, 16);
            n12.Spread<bool> output_50;
            try
            {
                var i_34 = 0;
                foreach (var item_32 in Result_23)
                {
                    var splicer_33 = item_32;
                    var i_local_35 = i_34;
                    __DSDaLeExbdYPcYUzh5LbYA state_36;
                    if (!iterator_44.MoveNext(out state_36))
                    {
                        iterator_44.Add(state_36 = new __DSDaLeExbdYPcYUzh5LbYA(__GetContext__(), n1.VLObject.NewIdentity()));
                        n1.NodeContext Node_Context_37 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "VIuHVZGsTedMwdXjsUO7yj", 66760U);
                        var Output_38 = n5.MessageWidget_C.Create(Node_Context: Node_Context_37);
                        state_36.__p_VIuHVZGsTedMwdXjsUO7yj = Output_38;
                    }

                    var State_Output_41 = state_36.__p_VIuHVZGsTedMwdXjsUO7yj.Update(Message_In: splicer_33, DefaultPaint_In: __auto_0, OwnerElementID_In: OwnerElementID_In, ErrorPaint_In: __auto_2, WarningPaint_In: __auto_1, HintPaint_In: __auto_3, Show_More_Infos_In: __auto_31, Output_Out: out n3.IWidget Output_39, Has_More_Info_Out: out bool Has_More_Info_40);
                    var Result_42 = splicer_33.ToString();
                    state_36.__p_VIuHVZGsTedMwdXjsUO7yj = State_Output_41;
                    iterator_44.Update(state_36);
                    builder_45.Add(Result_42);
                    builder_47.Add(Output_39);
                    builder_49.Add(Has_More_Info_40);
                    i_34++;
                }
            }
            finally
            {
                manager_43 = iterator_44.Commit();
                this.__loop_AC5fTFusxJvOAfPcKO3LVO = manager_43;
                output_46 = builder_45.Commit();
                this.__cp_JKPvTOLmPAKN7oP1P0Gzre = output_46;
                output_48 = builder_47.Commit();
                this.__cp_VzQvXB8x6U0Oiq84x1LfmI = output_48;
                output_50 = builder_49.Commit();
                this.__cp_VUU4q92RD3zP8UD3miOgWN = output_50;
            }

            n15.IEnumerable<string> Values_51 = (n15.IEnumerable<string>)output_46;
            var Output_52 = string.Join(separator: New_Line_8, values: Values_51);
            var Output_53 = n7.StringExtensions.Plus(input: Nodename_In, input2: New_Line_8);
            var Output_54 = n7.StringExtensions.Plus(input: Output_53, input2: Output_52);
            n8._Operations_.Switch_Boolean<string>(Condition_In: __auto_31, Input_In: __pad_HDRtbsath07MRQ8S0z8bue_6, Input_2_In: __pad_I6Mmh1xsjSTNoB5p3VFwLY_7, Output_Out: out string Output_55);
            var State_Output_65 = this.__p_NXsp1QFhUUcNl76pz9aqKw.Update(Output_Out: out n9.TooltipPaints_C Output_56, Background_Out: out n10.SkiaPaint_R Background_57, Hint_Out: out n11.Color4 Hint_58, Warning_Out: out n11.Color4 Warning_59, Error_Out: out n11.Color4 Error_60, Runtime_Error_Out: out n11.Color4 Runtime_Error_61, Font1_Out: out n10.SkiaPaint_R Font1_62, Font2_Out: out n10.SkiaPaint_R Font2_63, Font3_Out: out n10.SkiaPaint_R Font3_64);
            this.__p_NXsp1QFhUUcNl76pz9aqKw = State_Output_65;
            bool Update_66 = true;
            var Output_67 = this.__p_Sb0Q98OLVCsLcvE7su4LWD;
            if (Update_66)
            {
                Output_67 = this.__p_Sb0Q98OLVCsLcvE7su4LWD.Update(Value_In: Output_55, Paint_In: Font2_63);
            }

            this.__p_Sb0Q98OLVCsLcvE7su4LWD = Output_67;
            this.__slot_IQtG4yo5d7SL7CRrA6geB7 = (n3.IWidget)Output_67;
            n3.IWidget __pad_IQtG4yo5d7SL7CRrA6geB7_68 = (n3.IWidget)Output_67;
            n15.IEnumerable<bool> Input_69 = (n15.IEnumerable<bool>)output_50;
            var Result_70 = n54.EnumerableNodes.OR(input: Input_69);
            var Output_71 = output_48;
            if (Result_70)
            {
                n13._Operations_.Add<n3.IWidget>(Input_In: output_48, Item_In: __pad_IQtG4yo5d7SL7CRrA6geB7_68, Output_Out: out Output_71);
            }

            n52.Key Key_72 = __c_KekC9pjsyjcN074Q0tYz2d;
            var Result_73 = n52.Keyboard.IsKeyDown(key: Key_72);
            n52.Key Key_74 = __c_IuMg3iwpK1MPKBMyfzs2L4;
            var Result_75 = n52.Keyboard.IsKeyDown(key: Key_74);
            n52.Key Key_76 = __c_BUrFN125oIHO5jByT0rPWw;
            var Result_77 = n52.Keyboard.IsKeyDown(key: Key_76);
            var Output_78 = Result_73 && Result_75;
            var Output_79 = Output_78 && Result_77;
            var Output_82 = this.__p_D1ufVlMH09LNUkC2O9Dnar.Update(Value_In: Output_79, Up_Edge_Out: out bool Up_Edge_80, Down_Edge_Out: out bool Down_Edge_81);
            this.__p_D1ufVlMH09LNUkC2O9Dnar = Output_82;
            if (Up_Edge_80)
            {
                n55.Clipboard.SetText(text: Output_54);
            }

            if (Up_Edge_26)
            {
                n56._Operations_.OnNext<bool>(Input_In: __pad_LKnyQJnQCrENfrABmUIAbl_5, Value_In: __auto_31, Output_Out: out n23.BehaviorSubject<bool> Output_84);
            }

            Widgets_Out = Output_71;
            return this;
        }

        public n5.MessageWidgets_C __Create__(n1.NodeContext Node_Context, bool IsRuntime_In)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_IQtG4yo5d7SL7CRrA6geB7 = n27._Operations_.CreateDefault();
            this.__slot_LKnyQJnQCrENfrABmUIAbl = default(n23.BehaviorSubject<bool>);
            this.DefaultPaint = n10.SkiaPaint_R.CreateDefault();
            this.WarningPaint = n10.SkiaPaint_R.CreateDefault();
            this.ErrorPaint = n10.SkiaPaint_R.CreateDefault();
            this.HintPaint = n10.SkiaPaint_R.CreateDefault();
            this.InfoShowing = false;
            this.__cp_JKPvTOLmPAKN7oP1P0Gzre = n13._Operations_.CreateDefault<string>();
            this.__cp_VzQvXB8x6U0Oiq84x1LfmI = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__cp_VUU4q92RD3zP8UD3miOgWN = n13._Operations_.CreateDefault<bool>();
            float __pad_Af84DHUixSRQM7It4tji15_0 = __slot_Af84DHUixSRQM7It4tji15;
            float __pad_PVxzeR8jgZ5LyCqLksAR25_1 = __slot_PVxzeR8jgZ5LyCqLksAR25;
            float __pad_POe7mRgfsPOOGS1cop1n4P_2 = __slot_POe7mRgfsPOOGS1cop1n4P;
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "GlljiC1f6FROhTSMrrFlK3", 70158U);
            var Output_4 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_3);
            this.__p_GlljiC1f6FROhTSMrrFlK3 = Output_4;
            var State_Output_14 = Output_4.Update(Output_Out: out n9.TooltipPaints_C Output_5, Background_Out: out n10.SkiaPaint_R Background_6, Hint_Out: out n11.Color4 Hint_7, Warning_Out: out n11.Color4 Warning_8, Error_Out: out n11.Color4 Error_9, Runtime_Error_Out: out n11.Color4 Runtime_Error_10, Font1_Out: out n10.SkiaPaint_R Font1_11, Font2_Out: out n10.SkiaPaint_R Font2_12, Font3_Out: out n10.SkiaPaint_R Font3_13);
            this.__p_GlljiC1f6FROhTSMrrFlK3 = State_Output_14;
            n8._Operations_.Switch_Boolean<n11.Color4>(Condition_In: IsRuntime_In, Input_In: Error_9, Input_2_In: Runtime_Error_10, Output_Out: out n11.Color4 Output_15);
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "HiBYrXjWDL4Owt6plnEBWp", 70198U);
            var Output_17 = n28.SetColor_ErmwE010oOSLqOYWImAOgN.Create(Node_Context: Node_Context_16);
            this.__p_HiBYrXjWDL4Owt6plnEBWp = Output_17;
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "DQLYzk1Ji7tLYlXSupN9nH", 70177U);
            var Output_19 = n47.SetTextSize_QI38Jjk5kaVN53dJij0KIZ.Create(Node_Context: Node_Context_18);
            this.__p_DQLYzk1Ji7tLYlXSupN9nH = Output_19;
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "DDOdCCsuvGFNPodNodUc0w", 70921U);
            var Output_21 = n28.SetStrokeWidth_KnQo797H9sWM7zw8vskJYm.Create(Node_Context: Node_Context_20);
            this.__p_DDOdCCsuvGFNPodNodUc0w = Output_21;
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "JBuUaTi5euyLFjxeVaeaoR", 70185U);
            var Output_23 = n47.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a.Create(Node_Context: Node_Context_22);
            this.__p_JBuUaTi5euyLFjxeVaeaoR = Output_23;
            var State_Output_25 = Output_23.Update(Input_In: Font1_11, Line_Height_In: __pad_PVxzeR8jgZ5LyCqLksAR25_1, Output_Out: out n10.SkiaPaint_R Output_24);
            this.__p_JBuUaTi5euyLFjxeVaeaoR = State_Output_25;
            var State_Output_27 = Output_21.Update(Input_In: Output_24, Value_In: __pad_POe7mRgfsPOOGS1cop1n4P_2, Output_Out: out n10.SkiaPaint_R Output_26);
            this.__p_DDOdCCsuvGFNPodNodUc0w = State_Output_27;
            var State_Output_29 = Output_19.Update(Input_In: Output_26, Value_In: __pad_Af84DHUixSRQM7It4tji15_0, Output_Out: out n10.SkiaPaint_R Output_28);
            this.__p_DQLYzk1Ji7tLYlXSupN9nH = State_Output_29;
            var State_Output_31 = Output_17.Update(Input_In: Output_28, Value_In: Hint_7, Output_Out: out n10.SkiaPaint_R Output_30);
            this.__p_HiBYrXjWDL4Owt6plnEBWp = State_Output_31;
            n1.NodeContext Node_Context_32 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "U2Z4pyLKAHxPOZbjTkX4nL", 70068U);
            var Output_33 = n28.SetColor_ErmwE010oOSLqOYWImAOgN.Create(Node_Context: Node_Context_32);
            this.__p_U2Z4pyLKAHxPOZbjTkX4nL = Output_33;
            var State_Output_35 = Output_33.Update(Input_In: Output_28, Value_In: Warning_8, Output_Out: out n10.SkiaPaint_R Output_34);
            this.__p_U2Z4pyLKAHxPOZbjTkX4nL = State_Output_35;
            this.WarningPaint = Output_34;
            n10.SkiaPaint_R __auto_36 = Output_34;
            n1.NodeContext Node_Context_37 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "QayGacHhfSOPGTaelONhLT", 70076U);
            var Output_38 = n28.SetColor_ErmwE010oOSLqOYWImAOgN.Create(Node_Context: Node_Context_37);
            this.__p_QayGacHhfSOPGTaelONhLT = Output_38;
            var State_Output_40 = Output_38.Update(Input_In: Output_28, Value_In: Output_15, Output_Out: out n10.SkiaPaint_R Output_39);
            this.__p_QayGacHhfSOPGTaelONhLT = State_Output_40;
            this.ErrorPaint = Output_39;
            n10.SkiaPaint_R __auto_41 = Output_39;
            this.DefaultPaint = Output_28;
            n10.SkiaPaint_R __auto_42 = Output_28;
            this.HintPaint = Output_30;
            n10.SkiaPaint_R __auto_43 = Output_30;
            n24._Operations_.TooltipShowMoreInfo(Value_Out: out bool Value_44, Tooltip_Show_More_Info_Out: out n23.BehaviorSubject<bool> Tooltip_Show_More_Info_45);
            this.InfoShowing = Value_44;
            bool __auto_46 = Value_44;
            this.__slot_LKnyQJnQCrENfrABmUIAbl = Tooltip_Show_More_Info_45;
            n23.BehaviorSubject<bool> __pad_LKnyQJnQCrENfrABmUIAbl_47 = Tooltip_Show_More_Info_45;
            n1.NodeContext Node_Context_48 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "GMMraF1hfdZLKFaxtDtuxV", 70274U);
            var Output_49 = n37.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_48);
            this.__p_GMMraF1hfdZLKFaxtDtuxV = Output_49;
            n1.NodeContext Node_Context_50 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Sb0Q98OLVCsLcvE7su4LWD", 70281U);
            var Output_51 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_50);
            this.__p_Sb0Q98OLVCsLcvE7su4LWD = Output_51;
            n1.NodeContext Node_Context_52 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "NXsp1QFhUUcNl76pz9aqKw", 70290U);
            var Output_53 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_52);
            this.__p_NXsp1QFhUUcNl76pz9aqKw = Output_53;
            n1.NodeContext Node_Context_54 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "D1ufVlMH09LNUkC2O9Dnar", 70409U);
            var Output_55 = n37.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_54);
            this.__p_D1ufVlMH09LNUkC2O9Dnar = Output_55;
            this.__loop_AC5fTFusxJvOAfPcKO3LVO = default(n53.ImmutableLifetimeManager);
            return this;
        }

        public n5.MessageWidgets_C __CreateDefault__()
        {
            this.__slot_IQtG4yo5d7SL7CRrA6geB7 = n27._Operations_.CreateDefault();
            this.__slot_LKnyQJnQCrENfrABmUIAbl = default(n23.BehaviorSubject<bool>);
            this.DefaultPaint = n10.SkiaPaint_R.CreateDefault();
            this.WarningPaint = n10.SkiaPaint_R.CreateDefault();
            this.ErrorPaint = n10.SkiaPaint_R.CreateDefault();
            this.HintPaint = n10.SkiaPaint_R.CreateDefault();
            this.InfoShowing = false;
            this.__cp_JKPvTOLmPAKN7oP1P0Gzre = n13._Operations_.CreateDefault<string>();
            this.__cp_VzQvXB8x6U0Oiq84x1LfmI = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__cp_VUU4q92RD3zP8UD3miOgWN = n13._Operations_.CreateDefault<bool>();
            this.__p_GMMraF1hfdZLKFaxtDtuxV = n37.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__loop_AC5fTFusxJvOAfPcKO3LVO = default(n53.ImmutableLifetimeManager);
            this.__p_NXsp1QFhUUcNl76pz9aqKw = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__p_Sb0Q98OLVCsLcvE7su4LWD = n16.TextWidget_SingleLine_R.CreateDefault();
            this.__p_D1ufVlMH09LNUkC2O9Dnar = n37.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_GlljiC1f6FROhTSMrrFlK3 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__p_HiBYrXjWDL4Owt6plnEBWp = n28.SetColor_ErmwE010oOSLqOYWImAOgN.CreateDefault();
            this.__p_DQLYzk1Ji7tLYlXSupN9nH = n47.SetTextSize_QI38Jjk5kaVN53dJij0KIZ.CreateDefault();
            this.__p_DDOdCCsuvGFNPodNodUc0w = n28.SetStrokeWidth_KnQo797H9sWM7zw8vskJYm.CreateDefault();
            this.__p_JBuUaTi5euyLFjxeVaeaoR = n47.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a.CreateDefault();
            this.__p_U2Z4pyLKAHxPOZbjTkX4nL = n28.SetColor_ErmwE010oOSLqOYWImAOgN.CreateDefault();
            this.__p_QayGacHhfSOPGTaelONhLT = n28.SetColor_ErmwE010oOSLqOYWImAOgN.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_GMMraF1hfdZLKFaxtDtuxV);
            n1.CompilationHelper.SafeDispose(this.__loop_AC5fTFusxJvOAfPcKO3LVO);
            n1.CompilationHelper.SafeDispose(this.__p_NXsp1QFhUUcNl76pz9aqKw);
            n1.CompilationHelper.SafeDispose(this.__p_Sb0Q98OLVCsLcvE7su4LWD);
            n1.CompilationHelper.SafeDispose(this.__p_D1ufVlMH09LNUkC2O9Dnar);
            n1.CompilationHelper.SafeDispose(this.__p_GlljiC1f6FROhTSMrrFlK3);
            n1.CompilationHelper.SafeDispose(this.__p_HiBYrXjWDL4Owt6plnEBWp);
            n1.CompilationHelper.SafeDispose(this.__p_DQLYzk1Ji7tLYlXSupN9nH);
            n1.CompilationHelper.SafeDispose(this.__p_DDOdCCsuvGFNPodNodUc0w);
            n1.CompilationHelper.SafeDispose(this.__p_JBuUaTi5euyLFjxeVaeaoR);
            n1.CompilationHelper.SafeDispose(this.__p_U2Z4pyLKAHxPOZbjTkX4nL);
            n1.CompilationHelper.SafeDispose(this.__p_QayGacHhfSOPGTaelONhLT);
            return;
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 70105U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Af84DHUixSRQM7It4tji15", Name = "__slot_Af84DHUixSRQM7It4tji15")]
        public static float __slot_Af84DHUixSRQM7It4tji15 = 0.09999999F;
        [n1.ElementAttribute(TracingId = 70197U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PVxzeR8jgZ5LyCqLksAR25", Name = "__slot_PVxzeR8jgZ5LyCqLksAR25")]
        public static float __slot_PVxzeR8jgZ5LyCqLksAR25 = 0.18F;
        [n1.ElementAttribute(TracingId = 70327U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "HDRtbsath07MRQ8S0z8bue", Name = "__slot_HDRtbsath07MRQ8S0z8bue")]
        public static string __slot_HDRtbsath07MRQ8S0z8bue = "Press [Space] to learn more!";
        [n1.ElementAttribute(TracingId = 70329U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "I6Mmh1xsjSTNoB5p3VFwLY", Name = "__slot_I6Mmh1xsjSTNoB5p3VFwLY")]
        public static string __slot_I6Mmh1xsjSTNoB5p3VFwLY = "Press [Space] to show less!";
        [n1.ElementAttribute(TracingId = 70346U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "IQtG4yo5d7SL7CRrA6geB7", Name = "__slot_IQtG4yo5d7SL7CRrA6geB7")]
        public n3.IWidget __slot_IQtG4yo5d7SL7CRrA6geB7;
        [n1.ElementAttribute(TracingId = 70933U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "POe7mRgfsPOOGS1cop1n4P", Name = "__slot_POe7mRgfsPOOGS1cop1n4P")]
        public static float __slot_POe7mRgfsPOOGS1cop1n4P = 0.005F;
        [n1.ElementAttribute(TracingId = 70937U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "LKnyQJnQCrENfrABmUIAbl", Name = "__slot_LKnyQJnQCrENfrABmUIAbl")]
        public n23.BehaviorSubject<bool> __slot_LKnyQJnQCrENfrABmUIAbl;
        [n1.ElementAttribute(TracingId = 70061U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "GwA4BJAKuPgLSesdcE5LBz", Name = "DefaultPaint")]
        public n10.SkiaPaint_R DefaultPaint;
        [n1.ElementAttribute(TracingId = 70064U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "GXJDjmWYJEIOg94WlOoVuy", Name = "WarningPaint")]
        public n10.SkiaPaint_R WarningPaint;
        [n1.ElementAttribute(TracingId = 70067U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "UCUJGut4eSrQaRV8d7FBMP", Name = "ErrorPaint")]
        public n10.SkiaPaint_R ErrorPaint;
        [n1.ElementAttribute(TracingId = 70211U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "NZl5SfQp9WvPqpLVcYNpyc", Name = "HintPaint")]
        public n10.SkiaPaint_R HintPaint;
        [n1.ElementAttribute(TracingId = 70359U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PCrWwdxZNrILdph5nm5HeL", Name = "InfoShowing")]
        public bool InfoShowing;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n52.Key __c_Pz8LwdZ8w91PrkDTorghIh = n1.CompilationHelper.Deserialize<n52.Key>("Space", false, "QsvwBVssT9xLO3Td5ph2Z9", "Pz8LwdZ8w91PrkDTorghIh");
        [n1.ElementAttribute(TracingId = 70274U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "GMMraF1hfdZLKFaxtDtuxV", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n37.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_GMMraF1hfdZLKFaxtDtuxV;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n53.ImmutableLifetimeManager __loop_AC5fTFusxJvOAfPcKO3LVO;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<string> __cp_JKPvTOLmPAKN7oP1P0Gzre;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n3.IWidget> __cp_VzQvXB8x6U0Oiq84x1LfmI;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<bool> __cp_VUU4q92RD3zP8UD3miOgWN;
        [n1.ElementAttribute(TracingId = 70290U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "NXsp1QFhUUcNl76pz9aqKw", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_NXsp1QFhUUcNl76pz9aqKw;
        [n1.ElementAttribute(TracingId = 70281U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Sb0Q98OLVCsLcvE7su4LWD", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
        public n16.TextWidget_SingleLine_R __p_Sb0Q98OLVCsLcvE7su4LWD;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n52.Key __c_KekC9pjsyjcN074Q0tYz2d = n1.CompilationHelper.Deserialize<n52.Key>("LeftCtrl", false, "QsvwBVssT9xLO3Td5ph2Z9", "KekC9pjsyjcN074Q0tYz2d");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n52.Key __c_IuMg3iwpK1MPKBMyfzs2L4 = n1.CompilationHelper.Deserialize<n52.Key>("LeftShift", false, "QsvwBVssT9xLO3Td5ph2Z9", "IuMg3iwpK1MPKBMyfzs2L4");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n52.Key __c_BUrFN125oIHO5jByT0rPWw = n1.CompilationHelper.Deserialize<n52.Key>("C", false, "QsvwBVssT9xLO3Td5ph2Z9", "BUrFN125oIHO5jByT0rPWw");
        [n1.ElementAttribute(TracingId = 70409U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "D1ufVlMH09LNUkC2O9Dnar", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n37.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_D1ufVlMH09LNUkC2O9Dnar;
        [n1.ElementAttribute(TracingId = 70158U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "GlljiC1f6FROhTSMrrFlK3", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_GlljiC1f6FROhTSMrrFlK3;
        [n1.ElementAttribute(TracingId = 70198U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "HiBYrXjWDL4Owt6plnEBWp", Name = "SetColor", IsManaged = true, IsAutoGenerated = true)]
        public n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_HiBYrXjWDL4Owt6plnEBWp;
        [n1.ElementAttribute(TracingId = 70177U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "DQLYzk1Ji7tLYlXSupN9nH", Name = "SetTextSize", IsManaged = true, IsAutoGenerated = true)]
        public n47.SetTextSize_QI38Jjk5kaVN53dJij0KIZ __p_DQLYzk1Ji7tLYlXSupN9nH;
        [n1.ElementAttribute(TracingId = 70921U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "DDOdCCsuvGFNPodNodUc0w", Name = "SetStrokeWidth", IsManaged = true, IsAutoGenerated = true)]
        public n28.SetStrokeWidth_KnQo797H9sWM7zw8vskJYm __p_DDOdCCsuvGFNPodNodUc0w;
        [n1.ElementAttribute(TracingId = 70185U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "JBuUaTi5euyLFjxeVaeaoR", Name = "SetLineHeight", IsManaged = true, IsAutoGenerated = true)]
        public n47.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a __p_JBuUaTi5euyLFjxeVaeaoR;
        [n1.ElementAttribute(TracingId = 70068U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "U2Z4pyLKAHxPOZbjTkX4nL", Name = "SetColor", IsManaged = true, IsAutoGenerated = true)]
        public n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_U2Z4pyLKAHxPOZbjTkX4nL;
        [n1.ElementAttribute(TracingId = 70076U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "QayGacHhfSOPGTaelONhLT", Name = "SetColor", IsManaged = true, IsAutoGenerated = true)]
        public n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_QayGacHhfSOPGTaelONhLT;
        static MessageWidgets_C()
        {
        }

        public MessageWidgets_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal MessageWidgets_C(MessageWidgets_C other): base(other)
        {
            this.__slot_IQtG4yo5d7SL7CRrA6geB7 = other.__slot_IQtG4yo5d7SL7CRrA6geB7;
            this.__slot_LKnyQJnQCrENfrABmUIAbl = other.__slot_LKnyQJnQCrENfrABmUIAbl;
            this.DefaultPaint = other.DefaultPaint;
            this.WarningPaint = other.WarningPaint;
            this.ErrorPaint = other.ErrorPaint;
            this.HintPaint = other.HintPaint;
            this.InfoShowing = other.InfoShowing;
            this.__p_GMMraF1hfdZLKFaxtDtuxV = other.__p_GMMraF1hfdZLKFaxtDtuxV;
            this.__loop_AC5fTFusxJvOAfPcKO3LVO = other.__loop_AC5fTFusxJvOAfPcKO3LVO;
            this.__cp_JKPvTOLmPAKN7oP1P0Gzre = other.__cp_JKPvTOLmPAKN7oP1P0Gzre;
            this.__cp_VzQvXB8x6U0Oiq84x1LfmI = other.__cp_VzQvXB8x6U0Oiq84x1LfmI;
            this.__cp_VUU4q92RD3zP8UD3miOgWN = other.__cp_VUU4q92RD3zP8UD3miOgWN;
            this.__p_NXsp1QFhUUcNl76pz9aqKw = other.__p_NXsp1QFhUUcNl76pz9aqKw;
            this.__p_Sb0Q98OLVCsLcvE7su4LWD = other.__p_Sb0Q98OLVCsLcvE7su4LWD;
            this.__p_D1ufVlMH09LNUkC2O9Dnar = other.__p_D1ufVlMH09LNUkC2O9Dnar;
            this.__p_GlljiC1f6FROhTSMrrFlK3 = other.__p_GlljiC1f6FROhTSMrrFlK3;
            this.__p_HiBYrXjWDL4Owt6plnEBWp = other.__p_HiBYrXjWDL4Owt6plnEBWp;
            this.__p_DQLYzk1Ji7tLYlXSupN9nH = other.__p_DQLYzk1Ji7tLYlXSupN9nH;
            this.__p_DDOdCCsuvGFNPodNodUc0w = other.__p_DDOdCCsuvGFNPodNodUc0w;
            this.__p_JBuUaTi5euyLFjxeVaeaoR = other.__p_JBuUaTi5euyLFjxeVaeaoR;
            this.__p_U2Z4pyLKAHxPOZbjTkX4nL = other.__p_U2Z4pyLKAHxPOZbjTkX4nL;
            this.__p_QayGacHhfSOPGTaelONhLT = other.__p_QayGacHhfSOPGTaelONhLT;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_IQtG4yo5d7SL7CRrA6geB7", in __slot_IQtG4yo5d7SL7CRrA6geB7), n1.CompilationHelper.GetValueOrExisting(values, "__slot_LKnyQJnQCrENfrABmUIAbl", in __slot_LKnyQJnQCrENfrABmUIAbl), n1.CompilationHelper.GetValueOrExisting(values, "DefaultPaint", in DefaultPaint), n1.CompilationHelper.GetValueOrExisting(values, "WarningPaint", in WarningPaint), n1.CompilationHelper.GetValueOrExisting(values, "ErrorPaint", in ErrorPaint), n1.CompilationHelper.GetValueOrExisting(values, "HintPaint", in HintPaint), n1.CompilationHelper.GetValueOrExisting(values, "InfoShowing", in InfoShowing), n1.CompilationHelper.GetValueOrExisting(values, "__p_GMMraF1hfdZLKFaxtDtuxV", in __p_GMMraF1hfdZLKFaxtDtuxV), n1.CompilationHelper.GetValueOrExisting(values, "__loop_AC5fTFusxJvOAfPcKO3LVO", in __loop_AC5fTFusxJvOAfPcKO3LVO), n1.CompilationHelper.GetValueOrExisting(values, "__cp_JKPvTOLmPAKN7oP1P0Gzre", in __cp_JKPvTOLmPAKN7oP1P0Gzre), n1.CompilationHelper.GetValueOrExisting(values, "__cp_VzQvXB8x6U0Oiq84x1LfmI", in __cp_VzQvXB8x6U0Oiq84x1LfmI), n1.CompilationHelper.GetValueOrExisting(values, "__cp_VUU4q92RD3zP8UD3miOgWN", in __cp_VUU4q92RD3zP8UD3miOgWN), n1.CompilationHelper.GetValueOrExisting(values, "__p_NXsp1QFhUUcNl76pz9aqKw", in __p_NXsp1QFhUUcNl76pz9aqKw), n1.CompilationHelper.GetValueOrExisting(values, "__p_Sb0Q98OLVCsLcvE7su4LWD", in __p_Sb0Q98OLVCsLcvE7su4LWD), n1.CompilationHelper.GetValueOrExisting(values, "__p_D1ufVlMH09LNUkC2O9Dnar", in __p_D1ufVlMH09LNUkC2O9Dnar), n1.CompilationHelper.GetValueOrExisting(values, "__p_GlljiC1f6FROhTSMrrFlK3", in __p_GlljiC1f6FROhTSMrrFlK3), n1.CompilationHelper.GetValueOrExisting(values, "__p_HiBYrXjWDL4Owt6plnEBWp", in __p_HiBYrXjWDL4Owt6plnEBWp), n1.CompilationHelper.GetValueOrExisting(values, "__p_DQLYzk1Ji7tLYlXSupN9nH", in __p_DQLYzk1Ji7tLYlXSupN9nH), n1.CompilationHelper.GetValueOrExisting(values, "__p_DDOdCCsuvGFNPodNodUc0w", in __p_DDOdCCsuvGFNPodNodUc0w), n1.CompilationHelper.GetValueOrExisting(values, "__p_JBuUaTi5euyLFjxeVaeaoR", in __p_JBuUaTi5euyLFjxeVaeaoR), n1.CompilationHelper.GetValueOrExisting(values, "__p_U2Z4pyLKAHxPOZbjTkX4nL", in __p_U2Z4pyLKAHxPOZbjTkX4nL), n1.CompilationHelper.GetValueOrExisting(values, "__p_QayGacHhfSOPGTaelONhLT", in __p_QayGacHhfSOPGTaelONhLT));
        }

        internal MessageWidgets_C __WITH__(n3.IWidget __slot_IQtG4yo5d7SL7CRrA6geB7, n23.BehaviorSubject<bool> __slot_LKnyQJnQCrENfrABmUIAbl, n10.SkiaPaint_R DefaultPaint, n10.SkiaPaint_R WarningPaint, n10.SkiaPaint_R ErrorPaint, n10.SkiaPaint_R HintPaint, bool InfoShowing, n37.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_GMMraF1hfdZLKFaxtDtuxV, n53.ImmutableLifetimeManager __loop_AC5fTFusxJvOAfPcKO3LVO, n12.Spread<string> __cp_JKPvTOLmPAKN7oP1P0Gzre, n12.Spread<n3.IWidget> __cp_VzQvXB8x6U0Oiq84x1LfmI, n12.Spread<bool> __cp_VUU4q92RD3zP8UD3miOgWN, n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_NXsp1QFhUUcNl76pz9aqKw, n16.TextWidget_SingleLine_R __p_Sb0Q98OLVCsLcvE7su4LWD, n37.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_D1ufVlMH09LNUkC2O9Dnar, n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_GlljiC1f6FROhTSMrrFlK3, n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_HiBYrXjWDL4Owt6plnEBWp, n47.SetTextSize_QI38Jjk5kaVN53dJij0KIZ __p_DQLYzk1Ji7tLYlXSupN9nH, n28.SetStrokeWidth_KnQo797H9sWM7zw8vskJYm __p_DDOdCCsuvGFNPodNodUc0w, n47.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a __p_JBuUaTi5euyLFjxeVaeaoR, n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_U2Z4pyLKAHxPOZbjTkX4nL, n28.SetColor_ErmwE010oOSLqOYWImAOgN __p_QayGacHhfSOPGTaelONhLT)
        {
            n5.MessageWidgets_C that_0 = this;
            this.__slot_IQtG4yo5d7SL7CRrA6geB7 = __slot_IQtG4yo5d7SL7CRrA6geB7;
            this.__slot_LKnyQJnQCrENfrABmUIAbl = __slot_LKnyQJnQCrENfrABmUIAbl;
            this.DefaultPaint = DefaultPaint;
            this.WarningPaint = WarningPaint;
            this.ErrorPaint = ErrorPaint;
            this.HintPaint = HintPaint;
            this.InfoShowing = InfoShowing;
            this.__p_GMMraF1hfdZLKFaxtDtuxV = __p_GMMraF1hfdZLKFaxtDtuxV;
            this.__loop_AC5fTFusxJvOAfPcKO3LVO = __loop_AC5fTFusxJvOAfPcKO3LVO;
            this.__cp_JKPvTOLmPAKN7oP1P0Gzre = __cp_JKPvTOLmPAKN7oP1P0Gzre;
            this.__cp_VzQvXB8x6U0Oiq84x1LfmI = __cp_VzQvXB8x6U0Oiq84x1LfmI;
            this.__cp_VUU4q92RD3zP8UD3miOgWN = __cp_VUU4q92RD3zP8UD3miOgWN;
            this.__p_NXsp1QFhUUcNl76pz9aqKw = __p_NXsp1QFhUUcNl76pz9aqKw;
            this.__p_Sb0Q98OLVCsLcvE7su4LWD = __p_Sb0Q98OLVCsLcvE7su4LWD;
            this.__p_D1ufVlMH09LNUkC2O9Dnar = __p_D1ufVlMH09LNUkC2O9Dnar;
            this.__p_GlljiC1f6FROhTSMrrFlK3 = __p_GlljiC1f6FROhTSMrrFlK3;
            this.__p_HiBYrXjWDL4Owt6plnEBWp = __p_HiBYrXjWDL4Owt6plnEBWp;
            this.__p_DQLYzk1Ji7tLYlXSupN9nH = __p_DQLYzk1Ji7tLYlXSupN9nH;
            this.__p_DDOdCCsuvGFNPodNodUc0w = __p_DDOdCCsuvGFNPodNodUc0w;
            this.__p_JBuUaTi5euyLFjxeVaeaoR = __p_JBuUaTi5euyLFjxeVaeaoR;
            this.__p_U2Z4pyLKAHxPOZbjTkX4nL = __p_U2Z4pyLKAHxPOZbjTkX4nL;
            this.__p_QayGacHhfSOPGTaelONhLT = __p_QayGacHhfSOPGTaelONhLT;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "DSDaLeExbdYPcYUzh5LbYA", Name = "__DSDaLeExbdYPcYUzh5LbYA")]
        [n4.SerializableAttribute]
        public class __DSDaLeExbdYPcYUzh5LbYA : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_VIuHVZGsTedMwdXjsUO7yj);
                return;
            }

            [n1.ElementAttribute(TracingId = 66760U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VIuHVZGsTedMwdXjsUO7yj", Name = "MessageWidget", IsManaged = true, IsAutoGenerated = true)]
            public n5.MessageWidget_C __p_VIuHVZGsTedMwdXjsUO7yj;
            public __DSDaLeExbdYPcYUzh5LbYA(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DSDaLeExbdYPcYUzh5LbYA(__DSDaLeExbdYPcYUzh5LbYA other): base(other)
            {
                this.__p_VIuHVZGsTedMwdXjsUO7yj = other.__p_VIuHVZGsTedMwdXjsUO7yj;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VIuHVZGsTedMwdXjsUO7yj", in __p_VIuHVZGsTedMwdXjsUO7yj));
            }

            internal __DSDaLeExbdYPcYUzh5LbYA __WITH__(n5.MessageWidget_C __p_VIuHVZGsTedMwdXjsUO7yj)
            {
                __DSDaLeExbdYPcYUzh5LbYA that_0 = this;
                this.__p_VIuHVZGsTedMwdXjsUO7yj = __p_VIuHVZGsTedMwdXjsUO7yj;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 71123U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "FkZBDvRokOiQKGYGzfWEnG", Name = "TooltipWrapperViewer_C")]
    [n4.SerializableAttribute]
    public class TooltipWrapperViewer_C : n1.VLObject, n3.IElementViewer<n46.TooltipWrapper>, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.TooltipWrapperViewer_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new TooltipWrapperViewer_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.TooltipWrapperViewer_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new TooltipWrapperViewer_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.TooltipWrapperViewer_C Update_(n46.TooltipWrapper Value_In, n3.ViewerContext Context_In, out n3.IWidgetView Widget_Out)
        {
            n11.Vector2 __pad_HY6SPFClU1EPcU1Fm5gsW6_0 = __slot_HY6SPFClU1EPcU1Fm5gsW6;
            var Object_1 = Value_In.Object;
            bool Recreate_2 = false;
            var Output_4 = this.__p_EN5LWgk0flzORyEj7G4cVT.Update(Value_In: Object_1, Recreate_In: Recreate_2, Context_In: Context_In, Widget_Out: out n16.LayoutBuilder_R Widget_3);
            this.__p_EN5LWgk0flzORyEj7G4cVT = Output_4;
            n3.IWidget Widget_5 = (n3.IWidget)Widget_3;
            var State_Output_15 = this.__p_NUI5lma1VtOP3qlC6ffYri.Update(Output_Out: out n9.TooltipPaints_C Output_6, Background_Out: out n10.SkiaPaint_R Background_7, Hint_Out: out n11.Color4 Hint_8, Warning_Out: out n11.Color4 Warning_9, Error_Out: out n11.Color4 Error_10, Runtime_Error_Out: out n11.Color4 Runtime_Error_11, Font1_Out: out n10.SkiaPaint_R Font1_12, Font2_Out: out n10.SkiaPaint_R Font2_13, Font3_Out: out n10.SkiaPaint_R Font3_14);
            this.__p_NUI5lma1VtOP3qlC6ffYri = State_Output_15;
            n11.Vector2 Margin_16 = n18._Operations_.CreateDefault();
            bool Background_Enabled_17 = true;
            n10.SkiaPaint_R Stroke_Paint_18 = n10.SkiaPaint_R.CreateDefault();
            bool Stroke_Enabled_19 = false;
            bool Clip_Enabled_20 = false;
            bool Update_21 = true;
            var Output_22 = this.__p_EIZoQa1rMJqLC3R5RjDxqa;
            if (Update_21)
            {
                Output_22 = this.__p_EIZoQa1rMJqLC3R5RjDxqa.Update(Widget_In: Widget_5, Margin_In: Margin_16, Padding_In: __pad_HY6SPFClU1EPcU1Fm5gsW6_0, Background_Paint_In: Background_7, Background_Enabled_In: Background_Enabled_17, Stroke_Paint_In: Stroke_Paint_18, Stroke_Enabled_In: Stroke_Enabled_19, Clip_Enabled_In: Clip_Enabled_20);
            }

            this.__p_EIZoQa1rMJqLC3R5RjDxqa = Output_22;
            n3.IWidget Input_23 = (n3.IWidget)Output_22;
            var State_Output_25 = this.__p_ANqztpyVfC5OHcR1hG7Ah1.Update(Input_In: Input_23, Output_Out: out n3.IWidgetView Output_24);
            this.__p_ANqztpyVfC5OHcR1hG7Ah1 = State_Output_25;
            Widget_Out = Output_24;
            return this;
        }

        public n5.TooltipWrapperViewer_C __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "NUI5lma1VtOP3qlC6ffYri", 71132U);
            var Output_1 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_0);
            this.__p_NUI5lma1VtOP3qlC6ffYri = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "EIZoQa1rMJqLC3R5RjDxqa", 71166U);
            var Output_3 = n16.PanelWidget_R.Create(Node_Context: Node_Context_2);
            this.__p_EIZoQa1rMJqLC3R5RjDxqa = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "EN5LWgk0flzORyEj7G4cVT", 71229U);
            var Output_5 = n31.AdaptiveViewer_C.Create(Node_Context_In: Node_Context_4);
            this.__p_EN5LWgk0flzORyEj7G4cVT = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "ANqztpyVfC5OHcR1hG7Ah1", 71247U);
            var Output_7 = n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F.Create(Node_Context: Node_Context_6);
            this.__p_ANqztpyVfC5OHcR1hG7Ah1 = Output_7;
            return this;
        }

        public n5.TooltipWrapperViewer_C __CreateDefault__()
        {
            this.__p_EN5LWgk0flzORyEj7G4cVT = n31.AdaptiveViewer_C.CreateDefault();
            this.__p_NUI5lma1VtOP3qlC6ffYri = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__p_EIZoQa1rMJqLC3R5RjDxqa = n16.PanelWidget_R.CreateDefault();
            this.__p_ANqztpyVfC5OHcR1hG7Ah1 = n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_EN5LWgk0flzORyEj7G4cVT);
            n1.CompilationHelper.SafeDispose(this.__p_NUI5lma1VtOP3qlC6ffYri);
            n1.CompilationHelper.SafeDispose(this.__p_EIZoQa1rMJqLC3R5RjDxqa);
            n1.CompilationHelper.SafeDispose(this.__p_ANqztpyVfC5OHcR1hG7Ah1);
            return;
        }

        void n3.IElementViewer<n46.TooltipWrapper>.Update(n46.TooltipWrapper value, n3.ViewerContext context, out n3.IWidgetView widget)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(value, context, out widget);
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 71209U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "HY6SPFClU1EPcU1Fm5gsW6", Name = "__slot_HY6SPFClU1EPcU1Fm5gsW6")]
        public static n11.Vector2 __slot_HY6SPFClU1EPcU1Fm5gsW6 = n1.CompilationHelper.Deserialize<n11.Vector2>("0.06, 0.04", false, "QsvwBVssT9xLO3Td5ph2Z9", "HY6SPFClU1EPcU1Fm5gsW6");
        [n1.ElementAttribute(TracingId = 71229U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "EN5LWgk0flzORyEj7G4cVT", Name = "AdaptiveViewer", IsManaged = true, IsAutoGenerated = true)]
        public n31.AdaptiveViewer_C __p_EN5LWgk0flzORyEj7G4cVT;
        [n1.ElementAttribute(TracingId = 71132U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "NUI5lma1VtOP3qlC6ffYri", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_NUI5lma1VtOP3qlC6ffYri;
        [n1.ElementAttribute(TracingId = 71166U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "EIZoQa1rMJqLC3R5RjDxqa", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.PanelWidget_R __p_EIZoQa1rMJqLC3R5RjDxqa;
        [n1.ElementAttribute(TracingId = 71247U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "ANqztpyVfC5OHcR1hG7Ah1", Name = "ToWidgetView", IsManaged = true, IsAutoGenerated = true)]
        public n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F __p_ANqztpyVfC5OHcR1hG7Ah1;
        static TooltipWrapperViewer_C()
        {
        }

        public TooltipWrapperViewer_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TooltipWrapperViewer_C(TooltipWrapperViewer_C other): base(other)
        {
            this.__p_EN5LWgk0flzORyEj7G4cVT = other.__p_EN5LWgk0flzORyEj7G4cVT;
            this.__p_NUI5lma1VtOP3qlC6ffYri = other.__p_NUI5lma1VtOP3qlC6ffYri;
            this.__p_EIZoQa1rMJqLC3R5RjDxqa = other.__p_EIZoQa1rMJqLC3R5RjDxqa;
            this.__p_ANqztpyVfC5OHcR1hG7Ah1 = other.__p_ANqztpyVfC5OHcR1hG7Ah1;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_EN5LWgk0flzORyEj7G4cVT", in __p_EN5LWgk0flzORyEj7G4cVT), n1.CompilationHelper.GetValueOrExisting(values, "__p_NUI5lma1VtOP3qlC6ffYri", in __p_NUI5lma1VtOP3qlC6ffYri), n1.CompilationHelper.GetValueOrExisting(values, "__p_EIZoQa1rMJqLC3R5RjDxqa", in __p_EIZoQa1rMJqLC3R5RjDxqa), n1.CompilationHelper.GetValueOrExisting(values, "__p_ANqztpyVfC5OHcR1hG7Ah1", in __p_ANqztpyVfC5OHcR1hG7Ah1));
        }

        internal TooltipWrapperViewer_C __WITH__(n31.AdaptiveViewer_C __p_EN5LWgk0flzORyEj7G4cVT, n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_NUI5lma1VtOP3qlC6ffYri, n16.PanelWidget_R __p_EIZoQa1rMJqLC3R5RjDxqa, n16.ToWidgetView_T4QNWp1WJsCLjuX2hSPg2F __p_ANqztpyVfC5OHcR1hG7Ah1)
        {
            n5.TooltipWrapperViewer_C that_0 = this;
            this.__p_EN5LWgk0flzORyEj7G4cVT = __p_EN5LWgk0flzORyEj7G4cVT;
            this.__p_NUI5lma1VtOP3qlC6ffYri = __p_NUI5lma1VtOP3qlC6ffYri;
            this.__p_EIZoQa1rMJqLC3R5RjDxqa = __p_EIZoQa1rMJqLC3R5RjDxqa;
            this.__p_ANqztpyVfC5OHcR1hG7Ah1 = __p_ANqztpyVfC5OHcR1hG7Ah1;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 72917U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "FzU2BzUDdwtQC3m96qN1Q9", Name = "SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9")]
    [n4.SerializableAttribute]
    public class SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 : n1.VLObject, n3.IValueViewer<n15.IEnumerable<n38.TimingData>>, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 Create(n1.NodeContext Node_Context)
        {
            var instance = new SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 CreateDefault()
        {
            var instance = new SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 Update_(n15.IEnumerable<n38.TimingData> Value_In, n3.ViewerContext Context_In, out n3.IWidget Widget_Out)
        {
            var __fallback___0 = n1.ServiceRegistry.Current;
            n21._Operations_.Sum_Selector<n15.IEnumerable<n38.TimingData>, n38.TimingData, double, n36.__AdaptiveImplementations__QsvwBVssT9xLO3Td5ph2Z9>(Input_In: Value_In, Selector_In: (n38.TimingData Arg_In_2) =>
            {
                using var __current_1 = __fallback___0.MakeCurrentIfNone();
                var Interval_3 = Arg_In_2.Interval;
                var Total_Milliseconds_4 = Interval_3.TotalMilliseconds;
                double Input_2_5 = 1000;
                var Output_6 = Total_Milliseconds_4 * Input_2_5;
                return Output_6;
            }

            , Result_Out: out double Result_7);
            string Format_8 = "0.0 µs";
            n57._Operations_.ToString_Invariant(Input_In: Result_7, Format_In: Format_8, Result_Out: out string Result_9);
            var State_Output_19 = this.__p_UhrbhWPymBPPNb3YJ136qb.Update(Output_Out: out n9.TooltipPaints_C Output_10, Background_Out: out n10.SkiaPaint_R Background_11, Hint_Out: out n11.Color4 Hint_12, Warning_Out: out n11.Color4 Warning_13, Error_Out: out n11.Color4 Error_14, Runtime_Error_Out: out n11.Color4 Runtime_Error_15, Font1_Out: out n10.SkiaPaint_R Font1_16, Font2_Out: out n10.SkiaPaint_R Font2_17, Font3_Out: out n10.SkiaPaint_R Font3_18);
            bool Update_20 = true;
            var Output_21 = this.__p_MNWb8RM6V8YQBBbLMztCos;
            if (Update_20)
            {
                Output_21 = this.__p_MNWb8RM6V8YQBBbLMztCos.Update(Value_In: Result_9, Paint_In: Font2_17);
            }

            n3.IWidget Widget_Out_22 = (n3.IWidget)Output_21;
            Widget_Out = Widget_Out_22;
            n5.SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = State_Output_19 != this.__p_UhrbhWPymBPPNb3YJ136qb || Output_21 != this.__p_MNWb8RM6V8YQBBbLMztCos ? new SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9(this)
                {__p_UhrbhWPymBPPNb3YJ136qb = State_Output_19, __p_MNWb8RM6V8YQBBbLMztCos = Output_21} : that_23;
            else
            {
                this.__p_UhrbhWPymBPPNb3YJ136qb = State_Output_19;
                this.__p_MNWb8RM6V8YQBBbLMztCos = Output_21;
            }

            return that_23;
        }

        public n5.SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "UhrbhWPymBPPNb3YJ136qb", 72930U);
            var Output_1 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "MNWb8RM6V8YQBBbLMztCos", 73055U);
            var Output_3 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_2);
            n5.SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 that_4 = this;
            this.__p_UhrbhWPymBPPNb3YJ136qb = Output_1;
            this.__p_MNWb8RM6V8YQBBbLMztCos = Output_3;
            return that_4;
        }

        public n5.SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 __CreateDefault__()
        {
            n5.SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 that_0 = this;
            this.__p_UhrbhWPymBPPNb3YJ136qb = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__p_MNWb8RM6V8YQBBbLMztCos = n16.TextWidget_SingleLine_R.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_UhrbhWPymBPPNb3YJ136qb);
            n1.CompilationHelper.SafeDispose(this.__p_MNWb8RM6V8YQBBbLMztCos);
            return;
        }

        void n3.IValueViewer<n15.IEnumerable<n38.TimingData>>.Update(n15.IEnumerable<n38.TimingData> value, n3.ViewerContext context, out n3.IWidget widget)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(value, context, out widget);
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 72930U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "UhrbhWPymBPPNb3YJ136qb", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_UhrbhWPymBPPNb3YJ136qb;
        [n1.ElementAttribute(TracingId = 73055U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "MNWb8RM6V8YQBBbLMztCos", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
        public n16.TextWidget_SingleLine_R __p_MNWb8RM6V8YQBBbLMztCos;
        public SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9(SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 other): base(other)
        {
            this.__p_UhrbhWPymBPPNb3YJ136qb = other.__p_UhrbhWPymBPPNb3YJ136qb;
            this.__p_MNWb8RM6V8YQBBbLMztCos = other.__p_MNWb8RM6V8YQBBbLMztCos;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UhrbhWPymBPPNb3YJ136qb", in __p_UhrbhWPymBPPNb3YJ136qb), n1.CompilationHelper.GetValueOrExisting(values, "__p_MNWb8RM6V8YQBBbLMztCos", in __p_MNWb8RM6V8YQBBbLMztCos));
        }

        internal SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 __WITH__(n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_UhrbhWPymBPPNb3YJ136qb, n16.TextWidget_SingleLine_R __p_MNWb8RM6V8YQBBbLMztCos)
        {
            n5.SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_UhrbhWPymBPPNb3YJ136qb != this.__p_UhrbhWPymBPPNb3YJ136qb || __p_MNWb8RM6V8YQBBbLMztCos != this.__p_MNWb8RM6V8YQBBbLMztCos ? new SimpleTimingsWidget_FzU2BzUDdwtQC3m96qN1Q9(this)
                {__p_UhrbhWPymBPPNb3YJ136qb = __p_UhrbhWPymBPPNb3YJ136qb, __p_MNWb8RM6V8YQBBbLMztCos = __p_MNWb8RM6V8YQBBbLMztCos} : that_0;
            else
            {
                this.__p_UhrbhWPymBPPNb3YJ136qb = __p_UhrbhWPymBPPNb3YJ136qb;
                this.__p_MNWb8RM6V8YQBBbLMztCos = __p_MNWb8RM6V8YQBBbLMztCos;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 73135U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "QEms2MBNQN1ODFCzsDeffx", Name = "AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx")]
    [n4.SerializableAttribute]
    public class AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx : n1.VLObject, n3.IValueViewer<n15.IEnumerable<n38.TimingData>>, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx Create(n1.NodeContext Node_Context)
        {
            var instance = new AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx CreateDefault()
        {
            var instance = new AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx Update_(n15.IEnumerable<n38.TimingData> Value_In, n3.ViewerContext Context_In, out n3.IWidget Widget_Out)
        {
            var State_Output_9 = this.__p_Qiuh4hlbtHQN5n3927hwvM.Update(Output_Out: out n9.TooltipPaints_C Output_0, Background_Out: out n10.SkiaPaint_R Background_1, Hint_Out: out n11.Color4 Hint_2, Warning_Out: out n11.Color4 Warning_3, Error_Out: out n11.Color4 Error_4, Runtime_Error_Out: out n11.Color4 Runtime_Error_5, Font1_Out: out n10.SkiaPaint_R Font1_6, Font2_Out: out n10.SkiaPaint_R Font2_7, Font3_Out: out n10.SkiaPaint_R Font3_8);
            n21._Operations_.Count<n38.TimingData>(Input_In: Value_In, Result_Out: out int Result_10);
            int Input_2_11 = 1;
            var Result_12 = Result_10 > Input_2_11;
            var manager_79 = this.__loop_AZaIUEIW9UqM8lCe6XzdYY ?? new n53.ImmutableLifetimeManager();
            var iterator_80 = manager_79.GetIterator(__GetContext__());
            var builder_81 = n6.CollectionBuilders.GetBuilder(this.__cp_MzMQIZGpsv8NSRnrXORzxg, 16);
            n12.Spread<n16.Row_R> output_82;
            try
            {
                var i_15 = 0;
                foreach (var item_13 in Value_In)
                {
                    var splicer_14 = item_13;
                    var i_local_16 = i_15;
                    __PidfzcjR7IJMmIYvyAcMLZ state_17;
                    if (!iterator_80.MoveNext(out state_17))
                    {
                        iterator_80.Add(state_17 = new __PidfzcjR7IJMmIYvyAcMLZ(__GetContext__(), n1.VLObject.NewIdentity())
                        {__pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js = n13._Operations_.CreateDefault<n3.IWidget>()});
                        n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Rlpx9cgVCwJLNxqXsxoGlS", 73179U);
                        var Output_19 = n16.Row_R.Create(Node_Context: Node_Context_18);
                        state_17.__p_Rlpx9cgVCwJLNxqXsxoGlS = Output_19;
                        n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "AwJfbzTjUIQLXP0NCNzHK1", 73208U);
                        var Output_21 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_20);
                        state_17.__p_AwJfbzTjUIQLXP0NCNzHK1 = Output_21;
                        n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "SGX5DUR0uODPKq6aYpz2Wg", 73229U);
                        var Output_23 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_22);
                        state_17.__p_SGX5DUR0uODPKq6aYpz2Wg = Output_23;
                        n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "PfeY3gVKKFuM8p1eXjKJ6X", 73419U);
                        var Output_25 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_24);
                        state_17.__p_PfeY3gVKKFuM8p1eXjKJ6X = Output_25;
                        n1.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "ImwJkZcpzwHQB1mghTXEqK", 73441U);
                        var Output_27 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_26);
                        state_17.__p_ImwJkZcpzwHQB1mghTXEqK = Output_27;
                    }

                    n11.Vector2 Default_Size_28 = n18._Operations_.CreateDefault();
                    bool Update_29 = true;
                    var Output_30 = state_17.__p_ImwJkZcpzwHQB1mghTXEqK;
                    if (Update_29)
                    {
                        Output_30 = state_17.__p_ImwJkZcpzwHQB1mghTXEqK.Update(Default_Size_In: Default_Size_28);
                    }

                    n3.IWidget Input_31 = (n3.IWidget)Output_30;
                    var Fragment_32 = splicer_14.Fragment;
                    string Input_2_33 = ": ";
                    var Output_34 = n7.StringExtensions.Plus(input: Fragment_32, input2: Input_2_33);
                    bool Update_35 = true;
                    var Output_36 = state_17.__p_AwJfbzTjUIQLXP0NCNzHK1;
                    if (Update_35)
                    {
                        Output_36 = state_17.__p_AwJfbzTjUIQLXP0NCNzHK1.Update(Value_In: Output_34, Paint_In: Font1_6);
                    }

                    n3.IWidget Input_2_37 = (n3.IWidget)Output_36;
                    n8._Operations_.Switch_Boolean<n3.IWidget>(Condition_In: Result_12, Input_In: Input_31, Input_2_In: Input_2_37, Output_Out: out n3.IWidget Output_38);
                    var Interval_39 = splicer_14.Interval;
                    var Total_Milliseconds_40 = Interval_39.TotalMilliseconds;
                    double Input_2_41 = 1000;
                    var Output_42 = Total_Milliseconds_40 * Input_2_41;
                    string Format_43 = "0.0 µs";
                    n57._Operations_.ToString_Invariant(Input_In: Output_42, Format_In: Format_43, Result_Out: out string Result_44);
                    bool Update_45 = true;
                    var Output_46 = state_17.__p_SGX5DUR0uODPKq6aYpz2Wg;
                    if (Update_45)
                    {
                        Output_46 = state_17.__p_SGX5DUR0uODPKq6aYpz2Wg.Update(Value_In: Result_44, Paint_In: Font2_7);
                    }

                    n3.IWidget Input_2_47 = (n3.IWidget)Output_46;
                    var Count_48 = splicer_14.Count;
                    int Input_2_49 = 1;
                    var Result_50 = Count_48 > Input_2_49;
                    n11.Vector2 Default_Size_51 = n18._Operations_.CreateDefault();
                    bool Update_52 = true;
                    var Output_53 = state_17.__p_PfeY3gVKKFuM8p1eXjKJ6X;
                    if (Update_52)
                    {
                        Output_53 = state_17.__p_PfeY3gVKKFuM8p1eXjKJ6X.Update(Default_Size_In: Default_Size_51);
                    }

                    n3.IWidget __auto_54 = (n3.IWidget)Output_53;
                    double Input_2_55 = (double)Count_48;
                    n3.IWidget __auto_56;
                    var state_57 = n1.CompilationHelper.Restore<__DSEovdnqpSCN3nvogEGVQ7>(state_17.__if_Gg1eWlIC0E2PMo5I60VXxY, __GetContext__());
                    if (Result_50)
                    {
                        if (state_57 == null)
                        {
                            state_57 = new __DSEovdnqpSCN3nvogEGVQ7(__GetContext__(), n1.VLObject.NewIdentity());
                            n1.NodeContext Node_Context_58 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "AnrufmRiVQXM7Gd118d8wc", 73351U);
                            var Output_59 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_58);
                            state_57.__p_AnrufmRiVQXM7Gd118d8wc = Output_59;
                        }

                        var Result_60 = n22.ObjectHelpers.ToString(input: Count_48);
                        var Output_61 = (double)Output_42 / Input_2_55;
                        string Format_62 = "0.0 µs";
                        n57._Operations_.ToString_Invariant(Input_In: Output_61, Format_In: Format_62, Result_Out: out string Result_63);
                        string Input_64 = " (";
                        string Input_3_65 = " calls, ";
                        string Input_5_66 = ")";
                        var Output_67 = n7.StringExtensions.Plus(input: Input_64, input2: Result_60);
                        var Output_68 = n7.StringExtensions.Plus(input: Output_67, input2: Input_3_65);
                        var Output_69 = n7.StringExtensions.Plus(input: Output_68, input2: Result_63);
                        var Output_70 = n7.StringExtensions.Plus(input: Output_69, input2: Input_5_66);
                        bool Update_71 = true;
                        var Output_72 = state_57.__p_AnrufmRiVQXM7Gd118d8wc;
                        if (Update_71)
                        {
                            Output_72 = state_57.__p_AnrufmRiVQXM7Gd118d8wc.Update(Value_In: Output_70, Paint_In: Font2_7);
                        }

                        __auto_56 = (n3.IWidget)Output_72;
                        if (state_57.__GetContext__().IsImmutable)
                            state_57 = Output_72 != state_57.__p_AnrufmRiVQXM7Gd118d8wc ? new __DSEovdnqpSCN3nvogEGVQ7(state_57)
                            {__p_AnrufmRiVQXM7Gd118d8wc = Output_72} : state_57;
                        else
                        {
                            state_57.__p_AnrufmRiVQXM7Gd118d8wc = Output_72;
                        }
                    }
                    else
                    {
                        __auto_56 = __auto_54;
                    }

                    var builder_73 = n6.CollectionBuilders.GetBuilder(state_17.__pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js, 3);
                    builder_73.Add(Output_38);
                    builder_73.Add(Input_2_47);
                    builder_73.Add(__auto_56);
                    var __pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js_74 = builder_73.Commit();
                    n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js_74, Result_Out: out n12.Spread<n3.IWidget> Result_75);
                    n15.IEnumerable<n3.IWidget> Widgets_76 = (n15.IEnumerable<n3.IWidget>)Result_75;
                    bool Update_77 = true;
                    var Output_78 = state_17.__p_Rlpx9cgVCwJLNxqXsxoGlS;
                    if (Update_77)
                    {
                        Output_78 = state_17.__p_Rlpx9cgVCwJLNxqXsxoGlS.Update(Widgets_In: Widgets_76);
                    }

                    if (state_17.__GetContext__().IsImmutable)
                        state_17 = Output_30 != state_17.__p_ImwJkZcpzwHQB1mghTXEqK || Output_36 != state_17.__p_AwJfbzTjUIQLXP0NCNzHK1 || Output_46 != state_17.__p_SGX5DUR0uODPKq6aYpz2Wg || Output_53 != state_17.__p_PfeY3gVKKFuM8p1eXjKJ6X || state_57 != state_17.__if_Gg1eWlIC0E2PMo5I60VXxY || __pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js_74 != state_17.__pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js || Output_78 != state_17.__p_Rlpx9cgVCwJLNxqXsxoGlS ? new __PidfzcjR7IJMmIYvyAcMLZ(state_17)
                        {__p_ImwJkZcpzwHQB1mghTXEqK = Output_30, __p_AwJfbzTjUIQLXP0NCNzHK1 = Output_36, __p_SGX5DUR0uODPKq6aYpz2Wg = Output_46, __p_PfeY3gVKKFuM8p1eXjKJ6X = Output_53, __if_Gg1eWlIC0E2PMo5I60VXxY = state_57, __pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js = __pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js_74, __p_Rlpx9cgVCwJLNxqXsxoGlS = Output_78} : state_17;
                    else
                    {
                        state_17.__p_ImwJkZcpzwHQB1mghTXEqK = Output_30;
                        state_17.__p_AwJfbzTjUIQLXP0NCNzHK1 = Output_36;
                        state_17.__p_SGX5DUR0uODPKq6aYpz2Wg = Output_46;
                        state_17.__p_PfeY3gVKKFuM8p1eXjKJ6X = Output_53;
                        state_17.__if_Gg1eWlIC0E2PMo5I60VXxY = state_57;
                        state_17.__pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js = __pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js_74;
                        state_17.__p_Rlpx9cgVCwJLNxqXsxoGlS = Output_78;
                    }

                    iterator_80.Update(state_17);
                    builder_81.Add(Output_78);
                    i_15++;
                }
            }
            finally
            {
                manager_79 = iterator_80.Commit();
                output_82 = builder_81.Commit();
            }

            n15.IEnumerable<n3.IWidget> Widgets_83 = (n15.IEnumerable<n3.IWidget>)output_82;
            bool KeepOriginalWidth_84 = false;
            bool Update_85 = true;
            var Output_86 = this.__p_IZnbhWMymvkMw8w0dz6UzS;
            if (Update_85)
            {
                Output_86 = this.__p_IZnbhWMymvkMw8w0dz6UzS.Update(Widgets_In: Widgets_83, KeepOriginalWidth_In: KeepOriginalWidth_84);
            }

            n3.IWidget Widget_Out_87 = (n3.IWidget)Output_86;
            Widget_Out = Widget_Out_87;
            n5.AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx that_88 = this;
            if (this.__GetContext__().IsImmutable)
                that_88 = State_Output_9 != this.__p_Qiuh4hlbtHQN5n3927hwvM || manager_79 != this.__loop_AZaIUEIW9UqM8lCe6XzdYY || output_82 != this.__cp_MzMQIZGpsv8NSRnrXORzxg || Output_86 != this.__p_IZnbhWMymvkMw8w0dz6UzS ? new AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx(this)
                {__p_Qiuh4hlbtHQN5n3927hwvM = State_Output_9, __loop_AZaIUEIW9UqM8lCe6XzdYY = manager_79, __cp_MzMQIZGpsv8NSRnrXORzxg = output_82, __p_IZnbhWMymvkMw8w0dz6UzS = Output_86} : that_88;
            else
            {
                this.__p_Qiuh4hlbtHQN5n3927hwvM = State_Output_9;
                this.__loop_AZaIUEIW9UqM8lCe6XzdYY = manager_79;
                this.__cp_MzMQIZGpsv8NSRnrXORzxg = output_82;
                this.__p_IZnbhWMymvkMw8w0dz6UzS = Output_86;
            }

            return that_88;
        }

        public n5.AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "IZnbhWMymvkMw8w0dz6UzS", 73145U);
            var Output_1 = n16.Column_R.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Qiuh4hlbtHQN5n3927hwvM", 73452U);
            var Output_3 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_2);
            n5.AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx that_4 = this;
            this.__cp_MzMQIZGpsv8NSRnrXORzxg = n13._Operations_.CreateDefault<n16.Row_R>();
            this.__p_IZnbhWMymvkMw8w0dz6UzS = Output_1;
            this.__p_Qiuh4hlbtHQN5n3927hwvM = Output_3;
            this.__loop_AZaIUEIW9UqM8lCe6XzdYY = default(n53.ImmutableLifetimeManager);
            return that_4;
        }

        public n5.AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx __CreateDefault__()
        {
            n5.AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx that_0 = this;
            this.__cp_MzMQIZGpsv8NSRnrXORzxg = n13._Operations_.CreateDefault<n16.Row_R>();
            this.__p_Qiuh4hlbtHQN5n3927hwvM = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__loop_AZaIUEIW9UqM8lCe6XzdYY = default(n53.ImmutableLifetimeManager);
            this.__p_IZnbhWMymvkMw8w0dz6UzS = n16.Column_R.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Qiuh4hlbtHQN5n3927hwvM);
            n1.CompilationHelper.SafeDispose(this.__loop_AZaIUEIW9UqM8lCe6XzdYY);
            n1.CompilationHelper.SafeDispose(this.__p_IZnbhWMymvkMw8w0dz6UzS);
            return;
        }

        void n3.IValueViewer<n15.IEnumerable<n38.TimingData>>.Update(n15.IEnumerable<n38.TimingData> value, n3.ViewerContext context, out n3.IWidget widget)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(value, context, out widget);
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 73452U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Qiuh4hlbtHQN5n3927hwvM", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_Qiuh4hlbtHQN5n3927hwvM;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n53.ImmutableLifetimeManager __loop_AZaIUEIW9UqM8lCe6XzdYY;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n16.Row_R> __cp_MzMQIZGpsv8NSRnrXORzxg;
        [n1.ElementAttribute(TracingId = 73145U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "IZnbhWMymvkMw8w0dz6UzS", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
        public n16.Column_R __p_IZnbhWMymvkMw8w0dz6UzS;
        public AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx(AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx other): base(other)
        {
            this.__p_Qiuh4hlbtHQN5n3927hwvM = other.__p_Qiuh4hlbtHQN5n3927hwvM;
            this.__loop_AZaIUEIW9UqM8lCe6XzdYY = other.__loop_AZaIUEIW9UqM8lCe6XzdYY;
            this.__cp_MzMQIZGpsv8NSRnrXORzxg = other.__cp_MzMQIZGpsv8NSRnrXORzxg;
            this.__p_IZnbhWMymvkMw8w0dz6UzS = other.__p_IZnbhWMymvkMw8w0dz6UzS;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Qiuh4hlbtHQN5n3927hwvM", in __p_Qiuh4hlbtHQN5n3927hwvM), n1.CompilationHelper.GetValueOrExisting(values, "__loop_AZaIUEIW9UqM8lCe6XzdYY", in __loop_AZaIUEIW9UqM8lCe6XzdYY), n1.CompilationHelper.GetValueOrExisting(values, "__cp_MzMQIZGpsv8NSRnrXORzxg", in __cp_MzMQIZGpsv8NSRnrXORzxg), n1.CompilationHelper.GetValueOrExisting(values, "__p_IZnbhWMymvkMw8w0dz6UzS", in __p_IZnbhWMymvkMw8w0dz6UzS));
        }

        internal AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx __WITH__(n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_Qiuh4hlbtHQN5n3927hwvM, n53.ImmutableLifetimeManager __loop_AZaIUEIW9UqM8lCe6XzdYY, n12.Spread<n16.Row_R> __cp_MzMQIZGpsv8NSRnrXORzxg, n16.Column_R __p_IZnbhWMymvkMw8w0dz6UzS)
        {
            n5.AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Qiuh4hlbtHQN5n3927hwvM != this.__p_Qiuh4hlbtHQN5n3927hwvM || __loop_AZaIUEIW9UqM8lCe6XzdYY != this.__loop_AZaIUEIW9UqM8lCe6XzdYY || __cp_MzMQIZGpsv8NSRnrXORzxg != this.__cp_MzMQIZGpsv8NSRnrXORzxg || __p_IZnbhWMymvkMw8w0dz6UzS != this.__p_IZnbhWMymvkMw8w0dz6UzS ? new AdvancedTimingsWidget_QEms2MBNQN1ODFCzsDeffx(this)
                {__p_Qiuh4hlbtHQN5n3927hwvM = __p_Qiuh4hlbtHQN5n3927hwvM, __loop_AZaIUEIW9UqM8lCe6XzdYY = __loop_AZaIUEIW9UqM8lCe6XzdYY, __cp_MzMQIZGpsv8NSRnrXORzxg = __cp_MzMQIZGpsv8NSRnrXORzxg, __p_IZnbhWMymvkMw8w0dz6UzS = __p_IZnbhWMymvkMw8w0dz6UzS} : that_0;
            else
            {
                this.__p_Qiuh4hlbtHQN5n3927hwvM = __p_Qiuh4hlbtHQN5n3927hwvM;
                this.__loop_AZaIUEIW9UqM8lCe6XzdYY = __loop_AZaIUEIW9UqM8lCe6XzdYY;
                this.__cp_MzMQIZGpsv8NSRnrXORzxg = __cp_MzMQIZGpsv8NSRnrXORzxg;
                this.__p_IZnbhWMymvkMw8w0dz6UzS = __p_IZnbhWMymvkMw8w0dz6UzS;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PidfzcjR7IJMmIYvyAcMLZ", Name = "__PidfzcjR7IJMmIYvyAcMLZ")]
        [n4.SerializableAttribute]
        public class __PidfzcjR7IJMmIYvyAcMLZ : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Rlpx9cgVCwJLNxqXsxoGlS);
                n1.CompilationHelper.SafeDispose(this.__p_AwJfbzTjUIQLXP0NCNzHK1);
                n1.CompilationHelper.SafeDispose(this.__p_SGX5DUR0uODPKq6aYpz2Wg);
                n1.CompilationHelper.SafeDispose(this.__p_PfeY3gVKKFuM8p1eXjKJ6X);
                n1.CompilationHelper.SafeDispose(this.__p_ImwJkZcpzwHQB1mghTXEqK);
                n1.CompilationHelper.SafeDispose(this.__if_Gg1eWlIC0E2PMo5I60VXxY);
                return;
            }

            [n1.ElementAttribute(TracingId = 73179U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Rlpx9cgVCwJLNxqXsxoGlS", Name = "Row", IsManaged = true, IsAutoGenerated = true)]
            public n16.Row_R __p_Rlpx9cgVCwJLNxqXsxoGlS;
            [n1.ElementAttribute(TracingId = 73208U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "AwJfbzTjUIQLXP0NCNzHK1", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_SingleLine_R __p_AwJfbzTjUIQLXP0NCNzHK1;
            [n1.ElementAttribute(TracingId = 73229U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "SGX5DUR0uODPKq6aYpz2Wg", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_SingleLine_R __p_SGX5DUR0uODPKq6aYpz2Wg;
            [n1.ElementAttribute(TracingId = 73419U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PfeY3gVKKFuM8p1eXjKJ6X", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_PfeY3gVKKFuM8p1eXjKJ6X;
            [n1.ElementAttribute(TracingId = 73441U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "ImwJkZcpzwHQB1mghTXEqK", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_ImwJkZcpzwHQB1mghTXEqK;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n4.Object __if_Gg1eWlIC0E2PMo5I60VXxY;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n3.IWidget> __pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js = default(n12.Spread<n3.IWidget>);
            public __PidfzcjR7IJMmIYvyAcMLZ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __PidfzcjR7IJMmIYvyAcMLZ(__PidfzcjR7IJMmIYvyAcMLZ other): base(other)
            {
                this.__p_Rlpx9cgVCwJLNxqXsxoGlS = other.__p_Rlpx9cgVCwJLNxqXsxoGlS;
                this.__p_AwJfbzTjUIQLXP0NCNzHK1 = other.__p_AwJfbzTjUIQLXP0NCNzHK1;
                this.__p_SGX5DUR0uODPKq6aYpz2Wg = other.__p_SGX5DUR0uODPKq6aYpz2Wg;
                this.__p_PfeY3gVKKFuM8p1eXjKJ6X = other.__p_PfeY3gVKKFuM8p1eXjKJ6X;
                this.__p_ImwJkZcpzwHQB1mghTXEqK = other.__p_ImwJkZcpzwHQB1mghTXEqK;
                this.__if_Gg1eWlIC0E2PMo5I60VXxY = other.__if_Gg1eWlIC0E2PMo5I60VXxY;
                this.__pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js = other.__pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Rlpx9cgVCwJLNxqXsxoGlS", in __p_Rlpx9cgVCwJLNxqXsxoGlS), n1.CompilationHelper.GetValueOrExisting(values, "__p_AwJfbzTjUIQLXP0NCNzHK1", in __p_AwJfbzTjUIQLXP0NCNzHK1), n1.CompilationHelper.GetValueOrExisting(values, "__p_SGX5DUR0uODPKq6aYpz2Wg", in __p_SGX5DUR0uODPKq6aYpz2Wg), n1.CompilationHelper.GetValueOrExisting(values, "__p_PfeY3gVKKFuM8p1eXjKJ6X", in __p_PfeY3gVKKFuM8p1eXjKJ6X), n1.CompilationHelper.GetValueOrExisting(values, "__p_ImwJkZcpzwHQB1mghTXEqK", in __p_ImwJkZcpzwHQB1mghTXEqK), n1.CompilationHelper.GetValueOrExisting(values, "__if_Gg1eWlIC0E2PMo5I60VXxY", in __if_Gg1eWlIC0E2PMo5I60VXxY), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js", in __pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js));
            }

            internal __PidfzcjR7IJMmIYvyAcMLZ __WITH__(n16.Row_R __p_Rlpx9cgVCwJLNxqXsxoGlS, n16.TextWidget_SingleLine_R __p_AwJfbzTjUIQLXP0NCNzHK1, n16.TextWidget_SingleLine_R __p_SGX5DUR0uODPKq6aYpz2Wg, n16.EmptyWidget_R __p_PfeY3gVKKFuM8p1eXjKJ6X, n16.EmptyWidget_R __p_ImwJkZcpzwHQB1mghTXEqK, n4.Object __if_Gg1eWlIC0E2PMo5I60VXxY, n12.Spread<n3.IWidget> __pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js)
            {
                __PidfzcjR7IJMmIYvyAcMLZ that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Rlpx9cgVCwJLNxqXsxoGlS != this.__p_Rlpx9cgVCwJLNxqXsxoGlS || __p_AwJfbzTjUIQLXP0NCNzHK1 != this.__p_AwJfbzTjUIQLXP0NCNzHK1 || __p_SGX5DUR0uODPKq6aYpz2Wg != this.__p_SGX5DUR0uODPKq6aYpz2Wg || __p_PfeY3gVKKFuM8p1eXjKJ6X != this.__p_PfeY3gVKKFuM8p1eXjKJ6X || __p_ImwJkZcpzwHQB1mghTXEqK != this.__p_ImwJkZcpzwHQB1mghTXEqK || __if_Gg1eWlIC0E2PMo5I60VXxY != this.__if_Gg1eWlIC0E2PMo5I60VXxY || __pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js != this.__pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js ? new __PidfzcjR7IJMmIYvyAcMLZ(this)
                    {__p_Rlpx9cgVCwJLNxqXsxoGlS = __p_Rlpx9cgVCwJLNxqXsxoGlS, __p_AwJfbzTjUIQLXP0NCNzHK1 = __p_AwJfbzTjUIQLXP0NCNzHK1, __p_SGX5DUR0uODPKq6aYpz2Wg = __p_SGX5DUR0uODPKq6aYpz2Wg, __p_PfeY3gVKKFuM8p1eXjKJ6X = __p_PfeY3gVKKFuM8p1eXjKJ6X, __p_ImwJkZcpzwHQB1mghTXEqK = __p_ImwJkZcpzwHQB1mghTXEqK, __if_Gg1eWlIC0E2PMo5I60VXxY = __if_Gg1eWlIC0E2PMo5I60VXxY, __pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js = __pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js} : that_0;
                else
                {
                    this.__p_Rlpx9cgVCwJLNxqXsxoGlS = __p_Rlpx9cgVCwJLNxqXsxoGlS;
                    this.__p_AwJfbzTjUIQLXP0NCNzHK1 = __p_AwJfbzTjUIQLXP0NCNzHK1;
                    this.__p_SGX5DUR0uODPKq6aYpz2Wg = __p_SGX5DUR0uODPKq6aYpz2Wg;
                    this.__p_PfeY3gVKKFuM8p1eXjKJ6X = __p_PfeY3gVKKFuM8p1eXjKJ6X;
                    this.__p_ImwJkZcpzwHQB1mghTXEqK = __p_ImwJkZcpzwHQB1mghTXEqK;
                    this.__if_Gg1eWlIC0E2PMo5I60VXxY = __if_Gg1eWlIC0E2PMo5I60VXxY;
                    this.__pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js = __pin_group_Input_In_DyKiXtmSmTlNSBhRGlU7Js;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "DSEovdnqpSCN3nvogEGVQ7", Name = "__DSEovdnqpSCN3nvogEGVQ7")]
        [n4.SerializableAttribute]
        public class __DSEovdnqpSCN3nvogEGVQ7 : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_AnrufmRiVQXM7Gd118d8wc);
                return;
            }

            [n1.ElementAttribute(TracingId = 73351U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "AnrufmRiVQXM7Gd118d8wc", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_SingleLine_R __p_AnrufmRiVQXM7Gd118d8wc;
            public __DSEovdnqpSCN3nvogEGVQ7(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DSEovdnqpSCN3nvogEGVQ7(__DSEovdnqpSCN3nvogEGVQ7 other): base(other)
            {
                this.__p_AnrufmRiVQXM7Gd118d8wc = other.__p_AnrufmRiVQXM7Gd118d8wc;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AnrufmRiVQXM7Gd118d8wc", in __p_AnrufmRiVQXM7Gd118d8wc));
            }

            internal __DSEovdnqpSCN3nvogEGVQ7 __WITH__(n16.TextWidget_SingleLine_R __p_AnrufmRiVQXM7Gd118d8wc)
            {
                __DSEovdnqpSCN3nvogEGVQ7 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_AnrufmRiVQXM7Gd118d8wc != this.__p_AnrufmRiVQXM7Gd118d8wc ? new __DSEovdnqpSCN3nvogEGVQ7(this)
                    {__p_AnrufmRiVQXM7Gd118d8wc = __p_AnrufmRiVQXM7Gd118d8wc} : that_0;
                else
                {
                    this.__p_AnrufmRiVQXM7Gd118d8wc = __p_AnrufmRiVQXM7Gd118d8wc;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 73593U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "T2pZliYhxjLLH9SSx3fFRu", Name = "PackageViewer_C")]
    [n4.SerializableAttribute]
    public class PackageViewer_C : n1.VLObject, n3.IValueViewer<n58.IPackageMetadata>, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.PackageViewer_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new PackageViewer_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.PackageViewer_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new PackageViewer_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.PackageViewer_C Update_(n58.IPackageMetadata Value_In, n3.ViewerContext Context_In, out n3.IWidget Widget_Out)
        {
            n11.Vector2 __pad_D6Ty7iS4s8oOMMe3RQGWOm_0 = __slot_D6Ty7iS4s8oOMMe3RQGWOm;
            n11.Vector2 __pad_Ri2vLTucGRwO1nZK3PbYkG_1 = __slot_Ri2vLTucGRwO1nZK3PbYkG;
            n58.IPackageName Input_2 = (n58.IPackageName)Value_In;
            var Id_3 = Input_2.Id;
            var Version_4 = Input_2.Version;
            n22.ObjectHelpers.IsAssigned(x: Version_4, result: out bool Result_5, notAssigned: out bool Not_Assigned_6);
            var State_Output_16 = this.__p_INAd2nXdaZoLqp5GURWj5o.Update(Output_Out: out n9.TooltipPaints_C Output_7, Background_Out: out n10.SkiaPaint_R Background_8, Hint_Out: out n11.Color4 Hint_9, Warning_Out: out n11.Color4 Warning_10, Error_Out: out n11.Color4 Error_11, Runtime_Error_Out: out n11.Color4 Runtime_Error_12, Font1_Out: out n10.SkiaPaint_R Font1_13, Font2_Out: out n10.SkiaPaint_R Font2_14, Font3_Out: out n10.SkiaPaint_R Font3_15);
            this.__p_INAd2nXdaZoLqp5GURWj5o = State_Output_16;
            n16.TextWidget_SingleLine_R __auto_17;
            var state_18 = n1.CompilationHelper.Restore<__ECwT6vK8iHoLTwN7XTxB3f>(this.__if_JL2kt2Lma9ZNq2Kck7ETDm, __GetContext__());
            if (Result_5)
            {
                if (state_18 == null)
                {
                    state_18 = new __ECwT6vK8iHoLTwN7XTxB3f(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "UxzndAoJpPNLQI471SykWQ", 74025U);
                    var Output_20 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_19);
                    state_18.__p_UxzndAoJpPNLQI471SykWQ = Output_20;
                }

                var Result_21 = Version_4.ToString();
                bool Update_22 = true;
                var Output_23 = state_18.__p_UxzndAoJpPNLQI471SykWQ;
                if (Update_22)
                {
                    Output_23 = state_18.__p_UxzndAoJpPNLQI471SykWQ.Update(Value_In: Result_21, Paint_In: Font2_14);
                }

                __auto_17 = Output_23;
                state_18.__p_UxzndAoJpPNLQI471SykWQ = Output_23;
                this.__if_JL2kt2Lma9ZNq2Kck7ETDm = state_18;
            }
            else
            {
                __auto_17 = n16.TextWidget_SingleLine_R.CreateDefault();
            }

            n3.IWidget Input_3_24 = (n3.IWidget)__auto_17;
            n22.ObjectHelpers.IsAssigned(x: Id_3, result: out bool Result_25, notAssigned: out bool Not_Assigned_26);
            n16.TextWidget_SingleLine_R __auto_27;
            var state_28 = n1.CompilationHelper.Restore<__PlWRRSohM2PPTW2Al1HbFl>(this.__if_UAjYCQFHyggOWKUCcvVfjD, __GetContext__());
            if (Result_25)
            {
                if (state_28 == null)
                {
                    state_28 = new __PlWRRSohM2PPTW2Al1HbFl(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "BtseZitztN2P6d3TaY4DIN", 74082U);
                    var Output_30 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_29);
                    state_28.__p_BtseZitztN2P6d3TaY4DIN = Output_30;
                }

                bool Update_31 = true;
                var Output_32 = state_28.__p_BtseZitztN2P6d3TaY4DIN;
                if (Update_31)
                {
                    Output_32 = state_28.__p_BtseZitztN2P6d3TaY4DIN.Update(Value_In: Id_3, Paint_In: Font1_13);
                }

                __auto_27 = Output_32;
                state_28.__p_BtseZitztN2P6d3TaY4DIN = Output_32;
                this.__if_UAjYCQFHyggOWKUCcvVfjD = state_28;
            }
            else
            {
                __auto_27 = n16.TextWidget_SingleLine_R.CreateDefault();
            }

            n3.IWidget Input_33 = (n3.IWidget)__auto_27;
            n11.Vector2 Default_Size_34 = __c_P1DdTwmjlyLP7xblcKVi7B;
            bool Update_35 = true;
            var Output_36 = this.__p_IDG7yGJqLTJN4U0ML6tlAD;
            if (Update_35)
            {
                Output_36 = this.__p_IDG7yGJqLTJN4U0ML6tlAD.Update(Default_Size_In: Default_Size_34);
            }

            this.__p_IDG7yGJqLTJN4U0ML6tlAD = Output_36;
            n3.IWidget Input_2_37 = (n3.IWidget)Output_36;
            var builder_38 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ, 3);
            builder_38.Add(Input_33);
            builder_38.Add(Input_2_37);
            builder_38.Add(Input_3_24);
            var __pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ_39 = builder_38.Commit();
            this.__pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ = __pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ_39;
            n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ_39, Result_Out: out n12.Spread<n3.IWidget> Result_40);
            n15.IEnumerable<n3.IWidget> Widgets_41 = (n15.IEnumerable<n3.IWidget>)Result_40;
            bool Update_42 = true;
            var Output_43 = this.__p_RH9UKG907SIPuonFfiC6df;
            if (Update_42)
            {
                Output_43 = this.__p_RH9UKG907SIPuonFfiC6df.Update(Widgets_In: Widgets_41);
            }

            this.__p_RH9UKG907SIPuonFfiC6df = Output_43;
            n3.IWidget Input_44 = (n3.IWidget)Output_43;
            var Tags_45 = Value_In.Tags;
            var Result_46 = string.IsNullOrWhiteSpace(value: Tags_45);
            var Output_47 = !Result_46;
            n12.Spread<n3.IWidget> __auto_48;
            var state_49 = n1.CompilationHelper.Restore<__C1SeDyuLwWzOnP962FUGBm>(this.__if_Mex0gQB4Z8FOqroqJEFrn3, __GetContext__());
            if (Output_47)
            {
                if (state_49 == null)
                {
                    state_49 = new __C1SeDyuLwWzOnP962FUGBm(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_IIGdCUHtBPcQNlfHcJ0889 = n13._Operations_.CreateDefault<string>()};
                }

                n12.Spread<string> __pad_VvcBLJoTb5BMdwREDRhDBb_50 = __slot_VvcBLJoTb5BMdwREDRhDBb;
                string Separator_51 = ",";
                n4.StringSplitOptions Options_52 = __c_SrTu4xHRcUxMkIFv0UdqMq;
                n49._Operations_.Split_String(Input_In: Tags_45, Separator_In: Separator_51, Options_In: Options_52, Output_Out: out n12.Spread<string> Output_53);
                var builder_61 = n6.CollectionBuilders.GetBuilder(state_49.__cp_IIGdCUHtBPcQNlfHcJ0889, 16);
                n12.Spread<string> output_62;
                try
                {
                    var i_56 = 0;
                    foreach (var item_54 in n6.CollectionExtensions.AsSpan(Output_53))
                    {
                        var splicer_55 = item_54;
                        var i_local_57 = i_56;
                        var Output_59 = splicer_55.Trim();
                        var Output_60 = Output_59.ToLowerInvariant();
                        builder_61.Add(Output_60);
                        i_56++;
                    }
                }
                finally
                {
                    output_62 = builder_61.Commit();
                }

                n15.IEnumerable<string> Input_63 = (n15.IEnumerable<string>)output_62;
                n15.IEnumerable<string> Input_2_64 = (n15.IEnumerable<string>)__pad_VvcBLJoTb5BMdwREDRhDBb_50;
                n21._Operations_.Except<string>(Input_In: Input_63, Input_2_In: Input_2_64, Output_Out: out n15.IEnumerable<string> Output_65);
                n21._Operations_.Any<string>(Input_In: Output_65, Result_Out: out bool Result_66);
                n12.Spread<n3.IWidget> __auto_67;
                var state_68 = n1.CompilationHelper.Restore<__R2UDl8YZeoiLAW2IiNDjwg>(state_49.__if_LXn4I8DLxNANDJD3wvJNWU, __GetContext__());
                if (Result_66)
                {
                    if (state_68 == null)
                    {
                        state_68 = new __R2UDl8YZeoiLAW2IiNDjwg(__GetContext__(), n1.VLObject.NewIdentity())
                        {__pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A = n13._Operations_.CreateDefault<n3.IWidget>()};
                        n1.NodeContext Node_Context_69 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "UZycYNl2nn2O182nxBn2OM", 79855U);
                        var Output_70 = n16.TagsWidget_LZd5EZDzlf3MVOiP5H1oSY.Create(Node_Context: Node_Context_69);
                        state_68.__p_UZycYNl2nn2O182nxBn2OM = Output_70;
                        n1.NodeContext Node_Context_71 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "EciLj45XifkOYp4bzQCyIR", 79886U);
                        var Output_72 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_71);
                        state_68.__p_EciLj45XifkOYp4bzQCyIR = Output_72;
                    }

                    var State_Output_74 = state_68.__p_UZycYNl2nn2O182nxBn2OM.Update(Input_In: Output_65, Text_Paint_In: Font2_14, Output_Out: out n16.Row_R Output_73);
                    n3.IWidget Input_2_75 = (n3.IWidget)Output_73;
                    n11.Vector2 Default_Size_76 = __c_Pgo3xjjeklhPUqyOpg9d0E;
                    bool Update_77 = true;
                    var Output_78 = state_68.__p_EciLj45XifkOYp4bzQCyIR;
                    if (Update_77)
                    {
                        Output_78 = state_68.__p_EciLj45XifkOYp4bzQCyIR.Update(Default_Size_In: Default_Size_76);
                    }

                    n3.IWidget Input_79 = (n3.IWidget)Output_78;
                    var builder_80 = n6.CollectionBuilders.GetBuilder(state_68.__pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A, 2);
                    builder_80.Add(Input_79);
                    builder_80.Add(Input_2_75);
                    var __pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A_81 = builder_80.Commit();
                    n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A_81, Result_Out: out n12.Spread<n3.IWidget> Result_82);
                    __auto_67 = Result_82;
                    state_68.__p_UZycYNl2nn2O182nxBn2OM = State_Output_74;
                    state_68.__p_EciLj45XifkOYp4bzQCyIR = Output_78;
                    state_68.__pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A = __pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A_81;
                }
                else
                {
                    __auto_67 = n13._Operations_.CreateDefault<n3.IWidget>();
                }

                __auto_48 = __auto_67;
                state_49.__cp_IIGdCUHtBPcQNlfHcJ0889 = output_62;
                state_49.__if_LXn4I8DLxNANDJD3wvJNWU = state_68;
                this.__if_Mex0gQB4Z8FOqroqJEFrn3 = state_49;
            }
            else
            {
                __auto_48 = n13._Operations_.CreateDefault<n3.IWidget>();
            }

            var Description_83 = Value_In.Description;
            var Result_84 = string.IsNullOrWhiteSpace(value: Description_83);
            var Output_85 = !Result_84;
            n12.Spread<n3.IWidget> __auto_86;
            var state_87 = n1.CompilationHelper.Restore<__OhdVJyDJLfvMxAaCtwL6nx>(this.__if_PUv85Fpww9WQTVF8n4GAbG, __GetContext__());
            if (Output_85)
            {
                if (state_87 == null)
                {
                    state_87 = new __OhdVJyDJLfvMxAaCtwL6nx(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_88 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "DrcUbrnEm51OZtQIMMW9Bq", 74165U);
                    var Output_89 = n16.TextWidget_MultiLine_R.Create(Node_Context: Node_Context_88);
                    state_87.__p_DrcUbrnEm51OZtQIMMW9Bq = Output_89;
                    n1.NodeContext Node_Context_90 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "UZXiiSJbjLWLGLW9YXjEGy", 78150U);
                    var Output_91 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_90);
                    state_87.__p_UZXiiSJbjLWLGLW9YXjEGy = Output_91;
                }

                n17._Operations_.EnforceEndDot(Input_In: Description_83, Output_Out: out string Output_92);
                int Count_93 = 10;
                bool Break_at_Words_94 = true;
                bool Update_95 = true;
                var Output_96 = state_87.__p_DrcUbrnEm51OZtQIMMW9Bq;
                if (Update_95)
                {
                    Output_96 = state_87.__p_DrcUbrnEm51OZtQIMMW9Bq.Update(Value_In: Output_92, Count_In: Count_93, Break_at_Words_In: Break_at_Words_94, Paint_In: Font1_13);
                }

                n11.Vector2 Default_Size_97 = __c_O2mnIDL3qOjPwgiNon9L0R;
                bool Update_98 = true;
                var Output_99 = state_87.__p_UZXiiSJbjLWLGLW9YXjEGy;
                if (Update_98)
                {
                    Output_99 = state_87.__p_UZXiiSJbjLWLGLW9YXjEGy.Update(Default_Size_In: Default_Size_97);
                }

                n3.IWidget Item_100 = (n3.IWidget)Output_99;
                n3.IWidget Item_2_101 = (n3.IWidget)Output_96;
                n13._Operations_.Add<n3.IWidget>(Input_In: __auto_48, Item_In: Item_100, Output_Out: out n12.Spread<n3.IWidget> Output_102);
                n13._Operations_.Add<n3.IWidget>(Input_In: Output_102, Item_In: Item_2_101, Output_Out: out Output_102);
                __auto_86 = Output_102;
                state_87.__p_DrcUbrnEm51OZtQIMMW9Bq = Output_96;
                state_87.__p_UZXiiSJbjLWLGLW9YXjEGy = Output_99;
                this.__if_PUv85Fpww9WQTVF8n4GAbG = state_87;
            }
            else
            {
                __auto_86 = __auto_48;
            }

            n15.IEnumerable<n3.IWidget> Widgets_103 = (n15.IEnumerable<n3.IWidget>)__auto_86;
            bool KeepOriginalWidth_104 = false;
            bool Update_105 = true;
            var Output_106 = this.__p_J1ilzQrNoI2Mwij7E3SHwH;
            if (Update_105)
            {
                Output_106 = this.__p_J1ilzQrNoI2Mwij7E3SHwH.Update(Widgets_In: Widgets_103, KeepOriginalWidth_In: KeepOriginalWidth_104);
            }

            this.__p_J1ilzQrNoI2Mwij7E3SHwH = Output_106;
            n3.IWidget Widget_107 = (n3.IWidget)Output_106;
            n11.Vector2 Padding_108 = n18._Operations_.CreateDefault();
            bool Background_Enabled_109 = false;
            n10.SkiaPaint_R Stroke_Paint_110 = n10.SkiaPaint_R.CreateDefault();
            bool Stroke_Enabled_111 = false;
            bool Clip_Enabled_112 = false;
            bool Update_113 = true;
            var Output_114 = this.__p_Q0fsl778MBsOGHLSdy2Sah;
            if (Update_113)
            {
                Output_114 = this.__p_Q0fsl778MBsOGHLSdy2Sah.Update(Widget_In: Widget_107, Margin_In: __pad_Ri2vLTucGRwO1nZK3PbYkG_1, Padding_In: Padding_108, Background_Paint_In: Background_8, Background_Enabled_In: Background_Enabled_109, Stroke_Paint_In: Stroke_Paint_110, Stroke_Enabled_In: Stroke_Enabled_111, Clip_Enabled_In: Clip_Enabled_112);
            }

            this.__p_Q0fsl778MBsOGHLSdy2Sah = Output_114;
            n3.IWidget Input_2_115 = (n3.IWidget)Output_114;
            var Authors_116 = Value_In.Authors;
            n21._Operations_.Any<string>(Input_In: Authors_116, Result_Out: out bool Result_117);
            n11.Vector2 Default_Size_118 = n18._Operations_.CreateDefault();
            bool Update_119 = true;
            var Output_120 = this.__p_LwRIcpQdHdvPlfsKgYyZJ4;
            if (Update_119)
            {
                Output_120 = this.__p_LwRIcpQdHdvPlfsKgYyZJ4.Update(Default_Size_In: Default_Size_118);
            }

            this.__p_LwRIcpQdHdvPlfsKgYyZJ4 = Output_120;
            n3.IWidget __auto_121 = (n3.IWidget)Output_120;
            n3.IWidget __auto_122;
            var state_123 = n1.CompilationHelper.Restore<__V4HZpdyFqrjMKzclW6WTNY>(this.__if_QinCtRFlL9ROyclLc8kzVZ, __GetContext__());
            if (Result_117)
            {
                if (state_123 == null)
                {
                    state_123 = new __V4HZpdyFqrjMKzclW6WTNY(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF = n13._Operations_.CreateDefault<n16.TextWidget_SingleLine_R>(), __pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn = n13._Operations_.CreateDefault<n3.IWidget>()};
                    n1.NodeContext Node_Context_124 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "OiSMduuaG4MPnSzuEjUxAC", 78259U);
                    var Output_125 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_124);
                    state_123.__p_OiSMduuaG4MPnSzuEjUxAC = Output_125;
                    n1.NodeContext Node_Context_126 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "KF7B0UprExnOS5PLxHDaRc", 78287U);
                    var Output_127 = n16.Row_R.Create(Node_Context: Node_Context_126);
                    state_123.__p_KF7B0UprExnOS5PLxHDaRc = Output_127;
                    n1.NodeContext Node_Context_128 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "HDF5XwtCaHuM0GYPRmCnBe", 78297U);
                    var Output_129 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_128);
                    state_123.__p_HDF5XwtCaHuM0GYPRmCnBe = Output_129;
                    n1.NodeContext Node_Context_130 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "IUkaeJQ8RWqLPZtElLGm1a", 78308U);
                    var Output_131 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_130);
                    state_123.__p_IUkaeJQ8RWqLPZtElLGm1a = Output_131;
                    n1.NodeContext Node_Context_132 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "UK6mScLyqe8N5iJKNdQwS3", 78329U);
                    var Output_133 = n16.Column_R.Create(Node_Context: Node_Context_132);
                    state_123.__p_UK6mScLyqe8N5iJKNdQwS3 = Output_133;
                }

                string Separator_134 = ", ";
                var Output_135 = string.Join(separator: Separator_134, values: Authors_116);
                bool Update_136 = true;
                var Output_137 = state_123.__p_HDF5XwtCaHuM0GYPRmCnBe;
                if (Update_136)
                {
                    Output_137 = state_123.__p_HDF5XwtCaHuM0GYPRmCnBe.Update(Value_In: Output_135, Paint_In: Font2_14);
                }

                string Value_138 = "Authors: ";
                bool Update_139 = true;
                var Output_140 = state_123.__p_OiSMduuaG4MPnSzuEjUxAC;
                if (Update_139)
                {
                    Output_140 = state_123.__p_OiSMduuaG4MPnSzuEjUxAC.Update(Value_In: Value_138, Paint_In: Font1_13);
                }

                var builder_141 = n6.CollectionBuilders.GetBuilder(state_123.__pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF, 2);
                builder_141.Add(Output_140);
                builder_141.Add(Output_137);
                var __pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF_142 = builder_141.Commit();
                n13._Operations_.Cons<n16.TextWidget_SingleLine_R>(Input_In: __pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF_142, Result_Out: out n12.Spread<n16.TextWidget_SingleLine_R> Result_143);
                n15.IEnumerable<n3.IWidget> Widgets_144 = (n15.IEnumerable<n3.IWidget>)Result_143;
                bool Update_145 = true;
                var Output_146 = state_123.__p_KF7B0UprExnOS5PLxHDaRc;
                if (Update_145)
                {
                    Output_146 = state_123.__p_KF7B0UprExnOS5PLxHDaRc.Update(Widgets_In: Widgets_144);
                }

                n11.Vector2 Default_Size_147 = __c_TsikaP6GCAqNS4t89vMxjM;
                bool Update_148 = true;
                var Output_149 = state_123.__p_IUkaeJQ8RWqLPZtElLGm1a;
                if (Update_148)
                {
                    Output_149 = state_123.__p_IUkaeJQ8RWqLPZtElLGm1a.Update(Default_Size_In: Default_Size_147);
                }

                n3.IWidget Input_150 = (n3.IWidget)Output_149;
                n3.IWidget Input_2_151 = (n3.IWidget)Output_146;
                var builder_152 = n6.CollectionBuilders.GetBuilder(state_123.__pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn, 2);
                builder_152.Add(Input_150);
                builder_152.Add(Input_2_151);
                var __pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn_153 = builder_152.Commit();
                n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn_153, Result_Out: out n12.Spread<n3.IWidget> Result_154);
                n15.IEnumerable<n3.IWidget> Widgets_155 = (n15.IEnumerable<n3.IWidget>)Result_154;
                bool KeepOriginalWidth_156 = false;
                bool Update_157 = true;
                var Output_158 = state_123.__p_UK6mScLyqe8N5iJKNdQwS3;
                if (Update_157)
                {
                    Output_158 = state_123.__p_UK6mScLyqe8N5iJKNdQwS3.Update(Widgets_In: Widgets_155, KeepOriginalWidth_In: KeepOriginalWidth_156);
                }

                __auto_122 = (n3.IWidget)Output_158;
                state_123.__p_HDF5XwtCaHuM0GYPRmCnBe = Output_137;
                state_123.__p_OiSMduuaG4MPnSzuEjUxAC = Output_140;
                state_123.__pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF = __pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF_142;
                state_123.__p_KF7B0UprExnOS5PLxHDaRc = Output_146;
                state_123.__p_IUkaeJQ8RWqLPZtElLGm1a = Output_149;
                state_123.__pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn = __pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn_153;
                state_123.__p_UK6mScLyqe8N5iJKNdQwS3 = Output_158;
                this.__if_QinCtRFlL9ROyclLc8kzVZ = state_123;
            }
            else
            {
                __auto_122 = __auto_121;
            }

            var builder_159 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS, 3);
            builder_159.Add(Input_44);
            builder_159.Add(Input_2_115);
            builder_159.Add(__auto_122);
            var __pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS_160 = builder_159.Commit();
            this.__pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS = __pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS_160;
            n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS_160, Result_Out: out n12.Spread<n3.IWidget> Result_161);
            n15.IEnumerable<n3.IWidget> Widgets_162 = (n15.IEnumerable<n3.IWidget>)Result_161;
            bool KeepOriginalWidth_163 = false;
            bool Update_164 = true;
            var Output_165 = this.__p_CyKjalXKKnrNh1FZQ8mTrG;
            if (Update_164)
            {
                Output_165 = this.__p_CyKjalXKKnrNh1FZQ8mTrG.Update(Widgets_In: Widgets_162, KeepOriginalWidth_In: KeepOriginalWidth_163);
            }

            this.__p_CyKjalXKKnrNh1FZQ8mTrG = Output_165;
            n3.IWidget Widget_166 = (n3.IWidget)Output_165;
            n11.Vector2 Margin_167 = n18._Operations_.CreateDefault();
            bool Background_Enabled_168 = false;
            n10.SkiaPaint_R Stroke_Paint_169 = n10.SkiaPaint_R.CreateDefault();
            bool Stroke_Enabled_170 = false;
            bool Clip_Enabled_171 = false;
            bool Update_172 = true;
            var Output_173 = this.__p_VG6sjouzojpOZkukhP1L1s;
            if (Update_172)
            {
                Output_173 = this.__p_VG6sjouzojpOZkukhP1L1s.Update(Widget_In: Widget_166, Margin_In: Margin_167, Padding_In: __pad_D6Ty7iS4s8oOMMe3RQGWOm_0, Background_Paint_In: Background_8, Background_Enabled_In: Background_Enabled_168, Stroke_Paint_In: Stroke_Paint_169, Stroke_Enabled_In: Stroke_Enabled_170, Clip_Enabled_In: Clip_Enabled_171);
            }

            this.__p_VG6sjouzojpOZkukhP1L1s = Output_173;
            n3.IWidget Widget_Out_174 = (n3.IWidget)Output_173;
            Widget_Out = Widget_Out_174;
            return this;
        }

        public n5.PackageViewer_C __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS = n13._Operations_.CreateDefault<n3.IWidget>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "INAd2nXdaZoLqp5GURWj5o", 73600U);
            var Output_1 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_0);
            this.__p_INAd2nXdaZoLqp5GURWj5o = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "VG6sjouzojpOZkukhP1L1s", 73621U);
            var Output_3 = n16.PanelWidget_R.Create(Node_Context: Node_Context_2);
            this.__p_VG6sjouzojpOZkukhP1L1s = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "CyKjalXKKnrNh1FZQ8mTrG", 73820U);
            var Output_5 = n16.Column_R.Create(Node_Context: Node_Context_4);
            this.__p_CyKjalXKKnrNh1FZQ8mTrG = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "RH9UKG907SIPuonFfiC6df", 73908U);
            var Output_7 = n16.Row_R.Create(Node_Context: Node_Context_6);
            this.__p_RH9UKG907SIPuonFfiC6df = Output_7;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "IDG7yGJqLTJN4U0ML6tlAD", 73925U);
            var Output_9 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_8);
            this.__p_IDG7yGJqLTJN4U0ML6tlAD = Output_9;
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "J1ilzQrNoI2Mwij7E3SHwH", 78174U);
            var Output_11 = n16.Column_R.Create(Node_Context: Node_Context_10);
            this.__p_J1ilzQrNoI2Mwij7E3SHwH = Output_11;
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Q0fsl778MBsOGHLSdy2Sah", 78181U);
            var Output_13 = n16.PanelWidget_R.Create(Node_Context: Node_Context_12);
            this.__p_Q0fsl778MBsOGHLSdy2Sah = Output_13;
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "LwRIcpQdHdvPlfsKgYyZJ4", 78223U);
            var Output_15 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_14);
            this.__p_LwRIcpQdHdvPlfsKgYyZJ4 = Output_15;
            this.__if_JL2kt2Lma9ZNq2Kck7ETDm = default(n4.Object);
            this.__if_UAjYCQFHyggOWKUCcvVfjD = default(n4.Object);
            this.__if_Mex0gQB4Z8FOqroqJEFrn3 = default(n4.Object);
            this.__if_PUv85Fpww9WQTVF8n4GAbG = default(n4.Object);
            this.__if_QinCtRFlL9ROyclLc8kzVZ = default(n4.Object);
            return this;
        }

        public n5.PackageViewer_C __CreateDefault__()
        {
            this.__pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__p_INAd2nXdaZoLqp5GURWj5o = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__if_JL2kt2Lma9ZNq2Kck7ETDm = default(n4.Object);
            this.__if_UAjYCQFHyggOWKUCcvVfjD = default(n4.Object);
            this.__p_IDG7yGJqLTJN4U0ML6tlAD = n16.EmptyWidget_R.CreateDefault();
            this.__p_RH9UKG907SIPuonFfiC6df = n16.Row_R.CreateDefault();
            this.__if_Mex0gQB4Z8FOqroqJEFrn3 = default(n4.Object);
            this.__if_PUv85Fpww9WQTVF8n4GAbG = default(n4.Object);
            this.__p_J1ilzQrNoI2Mwij7E3SHwH = n16.Column_R.CreateDefault();
            this.__p_Q0fsl778MBsOGHLSdy2Sah = n16.PanelWidget_R.CreateDefault();
            this.__p_LwRIcpQdHdvPlfsKgYyZJ4 = n16.EmptyWidget_R.CreateDefault();
            this.__if_QinCtRFlL9ROyclLc8kzVZ = default(n4.Object);
            this.__p_CyKjalXKKnrNh1FZQ8mTrG = n16.Column_R.CreateDefault();
            this.__p_VG6sjouzojpOZkukhP1L1s = n16.PanelWidget_R.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_INAd2nXdaZoLqp5GURWj5o);
            n1.CompilationHelper.SafeDispose(this.__if_JL2kt2Lma9ZNq2Kck7ETDm);
            n1.CompilationHelper.SafeDispose(this.__if_UAjYCQFHyggOWKUCcvVfjD);
            n1.CompilationHelper.SafeDispose(this.__p_IDG7yGJqLTJN4U0ML6tlAD);
            n1.CompilationHelper.SafeDispose(this.__p_RH9UKG907SIPuonFfiC6df);
            n1.CompilationHelper.SafeDispose(this.__if_Mex0gQB4Z8FOqroqJEFrn3);
            n1.CompilationHelper.SafeDispose(this.__if_PUv85Fpww9WQTVF8n4GAbG);
            n1.CompilationHelper.SafeDispose(this.__p_J1ilzQrNoI2Mwij7E3SHwH);
            n1.CompilationHelper.SafeDispose(this.__p_Q0fsl778MBsOGHLSdy2Sah);
            n1.CompilationHelper.SafeDispose(this.__p_LwRIcpQdHdvPlfsKgYyZJ4);
            n1.CompilationHelper.SafeDispose(this.__if_QinCtRFlL9ROyclLc8kzVZ);
            n1.CompilationHelper.SafeDispose(this.__p_CyKjalXKKnrNh1FZQ8mTrG);
            n1.CompilationHelper.SafeDispose(this.__p_VG6sjouzojpOZkukhP1L1s);
            return;
        }

        void n3.IValueViewer<n58.IPackageMetadata>.Update(n58.IPackageMetadata value, n3.ViewerContext context, out n3.IWidget widget)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(value, context, out widget);
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 73784U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "D6Ty7iS4s8oOMMe3RQGWOm", Name = "__slot_D6Ty7iS4s8oOMMe3RQGWOm")]
        public static n11.Vector2 __slot_D6Ty7iS4s8oOMMe3RQGWOm = n1.CompilationHelper.Deserialize<n11.Vector2>("0.06, 0.04", false, "QsvwBVssT9xLO3Td5ph2Z9", "D6Ty7iS4s8oOMMe3RQGWOm");
        [n1.ElementAttribute(TracingId = 78205U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Ri2vLTucGRwO1nZK3PbYkG", Name = "__slot_Ri2vLTucGRwO1nZK3PbYkG")]
        public static n11.Vector2 __slot_Ri2vLTucGRwO1nZK3PbYkG = n1.CompilationHelper.Deserialize<n11.Vector2>("0.11, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "Ri2vLTucGRwO1nZK3PbYkG");
        [n1.ElementAttribute(TracingId = 73600U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "INAd2nXdaZoLqp5GURWj5o", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_INAd2nXdaZoLqp5GURWj5o;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_JL2kt2Lma9ZNq2Kck7ETDm;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_UAjYCQFHyggOWKUCcvVfjD;
        [n1.ElementAttribute(TracingId = 73925U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "IDG7yGJqLTJN4U0ML6tlAD", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.EmptyWidget_R __p_IDG7yGJqLTJN4U0ML6tlAD;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_P1DdTwmjlyLP7xblcKVi7B = n1.CompilationHelper.Deserialize<n11.Vector2>("0.07, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "P1DdTwmjlyLP7xblcKVi7B");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n3.IWidget> __pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ = default(n12.Spread<n3.IWidget>);
        [n1.ElementAttribute(TracingId = 73908U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "RH9UKG907SIPuonFfiC6df", Name = "Row", IsManaged = true, IsAutoGenerated = true)]
        public n16.Row_R __p_RH9UKG907SIPuonFfiC6df;
        [n1.ElementAttribute(TracingId = 78503U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VvcBLJoTb5BMdwREDRhDBb", Name = "__slot_VvcBLJoTb5BMdwREDRhDBb")]
        public static n12.Spread<string> __slot_VvcBLJoTb5BMdwREDRhDBb = n1.CompilationHelper.Deserialize<n12.Spread<string>>("<Value xmlns=\"property\">\r\n  <Item xmlns=\"\">vl</Item>\r\n  <Item xmlns=\"\">vvvv</Item>\r\n</Value>", true, "QsvwBVssT9xLO3Td5ph2Z9", "VvcBLJoTb5BMdwREDRhDBb");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n4.StringSplitOptions __c_SrTu4xHRcUxMkIFv0UdqMq = n1.CompilationHelper.Deserialize<n4.StringSplitOptions>("RemoveEmptyEntries", false, "QsvwBVssT9xLO3Td5ph2Z9", "SrTu4xHRcUxMkIFv0UdqMq");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_Pgo3xjjeklhPUqyOpg9d0E = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.02", false, "QsvwBVssT9xLO3Td5ph2Z9", "Pgo3xjjeklhPUqyOpg9d0E");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_Mex0gQB4Z8FOqroqJEFrn3;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_O2mnIDL3qOjPwgiNon9L0R = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.05", false, "QsvwBVssT9xLO3Td5ph2Z9", "O2mnIDL3qOjPwgiNon9L0R");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_PUv85Fpww9WQTVF8n4GAbG;
        [n1.ElementAttribute(TracingId = 78174U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "J1ilzQrNoI2Mwij7E3SHwH", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
        public n16.Column_R __p_J1ilzQrNoI2Mwij7E3SHwH;
        [n1.ElementAttribute(TracingId = 78181U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Q0fsl778MBsOGHLSdy2Sah", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.PanelWidget_R __p_Q0fsl778MBsOGHLSdy2Sah;
        [n1.ElementAttribute(TracingId = 78223U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "LwRIcpQdHdvPlfsKgYyZJ4", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.EmptyWidget_R __p_LwRIcpQdHdvPlfsKgYyZJ4;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_TsikaP6GCAqNS4t89vMxjM = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.05", false, "QsvwBVssT9xLO3Td5ph2Z9", "TsikaP6GCAqNS4t89vMxjM");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n4.Object __if_QinCtRFlL9ROyclLc8kzVZ;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n3.IWidget> __pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS = default(n12.Spread<n3.IWidget>);
        [n1.ElementAttribute(TracingId = 73820U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "CyKjalXKKnrNh1FZQ8mTrG", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
        public n16.Column_R __p_CyKjalXKKnrNh1FZQ8mTrG;
        [n1.ElementAttribute(TracingId = 73621U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "VG6sjouzojpOZkukhP1L1s", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.PanelWidget_R __p_VG6sjouzojpOZkukhP1L1s;
        static PackageViewer_C()
        {
        }

        public PackageViewer_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PackageViewer_C(PackageViewer_C other): base(other)
        {
            this.__p_INAd2nXdaZoLqp5GURWj5o = other.__p_INAd2nXdaZoLqp5GURWj5o;
            this.__if_JL2kt2Lma9ZNq2Kck7ETDm = other.__if_JL2kt2Lma9ZNq2Kck7ETDm;
            this.__if_UAjYCQFHyggOWKUCcvVfjD = other.__if_UAjYCQFHyggOWKUCcvVfjD;
            this.__p_IDG7yGJqLTJN4U0ML6tlAD = other.__p_IDG7yGJqLTJN4U0ML6tlAD;
            this.__pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ = other.__pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ;
            this.__p_RH9UKG907SIPuonFfiC6df = other.__p_RH9UKG907SIPuonFfiC6df;
            this.__if_Mex0gQB4Z8FOqroqJEFrn3 = other.__if_Mex0gQB4Z8FOqroqJEFrn3;
            this.__if_PUv85Fpww9WQTVF8n4GAbG = other.__if_PUv85Fpww9WQTVF8n4GAbG;
            this.__p_J1ilzQrNoI2Mwij7E3SHwH = other.__p_J1ilzQrNoI2Mwij7E3SHwH;
            this.__p_Q0fsl778MBsOGHLSdy2Sah = other.__p_Q0fsl778MBsOGHLSdy2Sah;
            this.__p_LwRIcpQdHdvPlfsKgYyZJ4 = other.__p_LwRIcpQdHdvPlfsKgYyZJ4;
            this.__if_QinCtRFlL9ROyclLc8kzVZ = other.__if_QinCtRFlL9ROyclLc8kzVZ;
            this.__pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS = other.__pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS;
            this.__p_CyKjalXKKnrNh1FZQ8mTrG = other.__p_CyKjalXKKnrNh1FZQ8mTrG;
            this.__p_VG6sjouzojpOZkukhP1L1s = other.__p_VG6sjouzojpOZkukhP1L1s;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_INAd2nXdaZoLqp5GURWj5o", in __p_INAd2nXdaZoLqp5GURWj5o), n1.CompilationHelper.GetValueOrExisting(values, "__if_JL2kt2Lma9ZNq2Kck7ETDm", in __if_JL2kt2Lma9ZNq2Kck7ETDm), n1.CompilationHelper.GetValueOrExisting(values, "__if_UAjYCQFHyggOWKUCcvVfjD", in __if_UAjYCQFHyggOWKUCcvVfjD), n1.CompilationHelper.GetValueOrExisting(values, "__p_IDG7yGJqLTJN4U0ML6tlAD", in __p_IDG7yGJqLTJN4U0ML6tlAD), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ", in __pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_RH9UKG907SIPuonFfiC6df", in __p_RH9UKG907SIPuonFfiC6df), n1.CompilationHelper.GetValueOrExisting(values, "__if_Mex0gQB4Z8FOqroqJEFrn3", in __if_Mex0gQB4Z8FOqroqJEFrn3), n1.CompilationHelper.GetValueOrExisting(values, "__if_PUv85Fpww9WQTVF8n4GAbG", in __if_PUv85Fpww9WQTVF8n4GAbG), n1.CompilationHelper.GetValueOrExisting(values, "__p_J1ilzQrNoI2Mwij7E3SHwH", in __p_J1ilzQrNoI2Mwij7E3SHwH), n1.CompilationHelper.GetValueOrExisting(values, "__p_Q0fsl778MBsOGHLSdy2Sah", in __p_Q0fsl778MBsOGHLSdy2Sah), n1.CompilationHelper.GetValueOrExisting(values, "__p_LwRIcpQdHdvPlfsKgYyZJ4", in __p_LwRIcpQdHdvPlfsKgYyZJ4), n1.CompilationHelper.GetValueOrExisting(values, "__if_QinCtRFlL9ROyclLc8kzVZ", in __if_QinCtRFlL9ROyclLc8kzVZ), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS", in __pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS), n1.CompilationHelper.GetValueOrExisting(values, "__p_CyKjalXKKnrNh1FZQ8mTrG", in __p_CyKjalXKKnrNh1FZQ8mTrG), n1.CompilationHelper.GetValueOrExisting(values, "__p_VG6sjouzojpOZkukhP1L1s", in __p_VG6sjouzojpOZkukhP1L1s));
        }

        internal PackageViewer_C __WITH__(n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_INAd2nXdaZoLqp5GURWj5o, n4.Object __if_JL2kt2Lma9ZNq2Kck7ETDm, n4.Object __if_UAjYCQFHyggOWKUCcvVfjD, n16.EmptyWidget_R __p_IDG7yGJqLTJN4U0ML6tlAD, n12.Spread<n3.IWidget> __pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ, n16.Row_R __p_RH9UKG907SIPuonFfiC6df, n4.Object __if_Mex0gQB4Z8FOqroqJEFrn3, n4.Object __if_PUv85Fpww9WQTVF8n4GAbG, n16.Column_R __p_J1ilzQrNoI2Mwij7E3SHwH, n16.PanelWidget_R __p_Q0fsl778MBsOGHLSdy2Sah, n16.EmptyWidget_R __p_LwRIcpQdHdvPlfsKgYyZJ4, n4.Object __if_QinCtRFlL9ROyclLc8kzVZ, n12.Spread<n3.IWidget> __pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS, n16.Column_R __p_CyKjalXKKnrNh1FZQ8mTrG, n16.PanelWidget_R __p_VG6sjouzojpOZkukhP1L1s)
        {
            n5.PackageViewer_C that_0 = this;
            this.__p_INAd2nXdaZoLqp5GURWj5o = __p_INAd2nXdaZoLqp5GURWj5o;
            this.__if_JL2kt2Lma9ZNq2Kck7ETDm = __if_JL2kt2Lma9ZNq2Kck7ETDm;
            this.__if_UAjYCQFHyggOWKUCcvVfjD = __if_UAjYCQFHyggOWKUCcvVfjD;
            this.__p_IDG7yGJqLTJN4U0ML6tlAD = __p_IDG7yGJqLTJN4U0ML6tlAD;
            this.__pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ = __pin_group_Input_In_HH09VdYiEbdPpJJI2wL5OZ;
            this.__p_RH9UKG907SIPuonFfiC6df = __p_RH9UKG907SIPuonFfiC6df;
            this.__if_Mex0gQB4Z8FOqroqJEFrn3 = __if_Mex0gQB4Z8FOqroqJEFrn3;
            this.__if_PUv85Fpww9WQTVF8n4GAbG = __if_PUv85Fpww9WQTVF8n4GAbG;
            this.__p_J1ilzQrNoI2Mwij7E3SHwH = __p_J1ilzQrNoI2Mwij7E3SHwH;
            this.__p_Q0fsl778MBsOGHLSdy2Sah = __p_Q0fsl778MBsOGHLSdy2Sah;
            this.__p_LwRIcpQdHdvPlfsKgYyZJ4 = __p_LwRIcpQdHdvPlfsKgYyZJ4;
            this.__if_QinCtRFlL9ROyclLc8kzVZ = __if_QinCtRFlL9ROyclLc8kzVZ;
            this.__pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS = __pin_group_Input_In_L3JGzFaMlaIQTEijR5wLTS;
            this.__p_CyKjalXKKnrNh1FZQ8mTrG = __p_CyKjalXKKnrNh1FZQ8mTrG;
            this.__p_VG6sjouzojpOZkukhP1L1s = __p_VG6sjouzojpOZkukhP1L1s;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "ECwT6vK8iHoLTwN7XTxB3f", Name = "__ECwT6vK8iHoLTwN7XTxB3f")]
        [n4.SerializableAttribute]
        public class __ECwT6vK8iHoLTwN7XTxB3f : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UxzndAoJpPNLQI471SykWQ);
                return;
            }

            [n1.ElementAttribute(TracingId = 74025U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "UxzndAoJpPNLQI471SykWQ", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_SingleLine_R __p_UxzndAoJpPNLQI471SykWQ;
            public __ECwT6vK8iHoLTwN7XTxB3f(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __ECwT6vK8iHoLTwN7XTxB3f(__ECwT6vK8iHoLTwN7XTxB3f other): base(other)
            {
                this.__p_UxzndAoJpPNLQI471SykWQ = other.__p_UxzndAoJpPNLQI471SykWQ;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UxzndAoJpPNLQI471SykWQ", in __p_UxzndAoJpPNLQI471SykWQ));
            }

            internal __ECwT6vK8iHoLTwN7XTxB3f __WITH__(n16.TextWidget_SingleLine_R __p_UxzndAoJpPNLQI471SykWQ)
            {
                __ECwT6vK8iHoLTwN7XTxB3f that_0 = this;
                this.__p_UxzndAoJpPNLQI471SykWQ = __p_UxzndAoJpPNLQI471SykWQ;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PlWRRSohM2PPTW2Al1HbFl", Name = "__PlWRRSohM2PPTW2Al1HbFl")]
        [n4.SerializableAttribute]
        public class __PlWRRSohM2PPTW2Al1HbFl : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_BtseZitztN2P6d3TaY4DIN);
                return;
            }

            [n1.ElementAttribute(TracingId = 74082U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "BtseZitztN2P6d3TaY4DIN", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_SingleLine_R __p_BtseZitztN2P6d3TaY4DIN;
            public __PlWRRSohM2PPTW2Al1HbFl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __PlWRRSohM2PPTW2Al1HbFl(__PlWRRSohM2PPTW2Al1HbFl other): base(other)
            {
                this.__p_BtseZitztN2P6d3TaY4DIN = other.__p_BtseZitztN2P6d3TaY4DIN;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BtseZitztN2P6d3TaY4DIN", in __p_BtseZitztN2P6d3TaY4DIN));
            }

            internal __PlWRRSohM2PPTW2Al1HbFl __WITH__(n16.TextWidget_SingleLine_R __p_BtseZitztN2P6d3TaY4DIN)
            {
                __PlWRRSohM2PPTW2Al1HbFl that_0 = this;
                this.__p_BtseZitztN2P6d3TaY4DIN = __p_BtseZitztN2P6d3TaY4DIN;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "C1SeDyuLwWzOnP962FUGBm", Name = "__C1SeDyuLwWzOnP962FUGBm")]
        [n4.SerializableAttribute]
        public class __C1SeDyuLwWzOnP962FUGBm : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__if_LXn4I8DLxNANDJD3wvJNWU);
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<string> __cp_IIGdCUHtBPcQNlfHcJ0889;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n4.Object __if_LXn4I8DLxNANDJD3wvJNWU;
            public __C1SeDyuLwWzOnP962FUGBm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __C1SeDyuLwWzOnP962FUGBm(__C1SeDyuLwWzOnP962FUGBm other): base(other)
            {
                this.__cp_IIGdCUHtBPcQNlfHcJ0889 = other.__cp_IIGdCUHtBPcQNlfHcJ0889;
                this.__if_LXn4I8DLxNANDJD3wvJNWU = other.__if_LXn4I8DLxNANDJD3wvJNWU;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_IIGdCUHtBPcQNlfHcJ0889", in __cp_IIGdCUHtBPcQNlfHcJ0889), n1.CompilationHelper.GetValueOrExisting(values, "__if_LXn4I8DLxNANDJD3wvJNWU", in __if_LXn4I8DLxNANDJD3wvJNWU));
            }

            internal __C1SeDyuLwWzOnP962FUGBm __WITH__(n12.Spread<string> __cp_IIGdCUHtBPcQNlfHcJ0889, n4.Object __if_LXn4I8DLxNANDJD3wvJNWU)
            {
                __C1SeDyuLwWzOnP962FUGBm that_0 = this;
                this.__cp_IIGdCUHtBPcQNlfHcJ0889 = __cp_IIGdCUHtBPcQNlfHcJ0889;
                this.__if_LXn4I8DLxNANDJD3wvJNWU = __if_LXn4I8DLxNANDJD3wvJNWU;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "R2UDl8YZeoiLAW2IiNDjwg", Name = "__R2UDl8YZeoiLAW2IiNDjwg")]
        [n4.SerializableAttribute]
        public class __R2UDl8YZeoiLAW2IiNDjwg : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UZycYNl2nn2O182nxBn2OM);
                n1.CompilationHelper.SafeDispose(this.__p_EciLj45XifkOYp4bzQCyIR);
                return;
            }

            [n1.ElementAttribute(TracingId = 79855U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "UZycYNl2nn2O182nxBn2OM", Name = "TagsWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.TagsWidget_LZd5EZDzlf3MVOiP5H1oSY __p_UZycYNl2nn2O182nxBn2OM;
            [n1.ElementAttribute(TracingId = 79886U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "EciLj45XifkOYp4bzQCyIR", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_EciLj45XifkOYp4bzQCyIR;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n3.IWidget> __pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A = default(n12.Spread<n3.IWidget>);
            public __R2UDl8YZeoiLAW2IiNDjwg(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __R2UDl8YZeoiLAW2IiNDjwg(__R2UDl8YZeoiLAW2IiNDjwg other): base(other)
            {
                this.__p_UZycYNl2nn2O182nxBn2OM = other.__p_UZycYNl2nn2O182nxBn2OM;
                this.__p_EciLj45XifkOYp4bzQCyIR = other.__p_EciLj45XifkOYp4bzQCyIR;
                this.__pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A = other.__pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UZycYNl2nn2O182nxBn2OM", in __p_UZycYNl2nn2O182nxBn2OM), n1.CompilationHelper.GetValueOrExisting(values, "__p_EciLj45XifkOYp4bzQCyIR", in __p_EciLj45XifkOYp4bzQCyIR), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A", in __pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A));
            }

            internal __R2UDl8YZeoiLAW2IiNDjwg __WITH__(n16.TagsWidget_LZd5EZDzlf3MVOiP5H1oSY __p_UZycYNl2nn2O182nxBn2OM, n16.EmptyWidget_R __p_EciLj45XifkOYp4bzQCyIR, n12.Spread<n3.IWidget> __pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A)
            {
                __R2UDl8YZeoiLAW2IiNDjwg that_0 = this;
                this.__p_UZycYNl2nn2O182nxBn2OM = __p_UZycYNl2nn2O182nxBn2OM;
                this.__p_EciLj45XifkOYp4bzQCyIR = __p_EciLj45XifkOYp4bzQCyIR;
                this.__pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A = __pin_group_Input_In_C7NdyqbPRMfMVrUakWwM3A;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "OhdVJyDJLfvMxAaCtwL6nx", Name = "__OhdVJyDJLfvMxAaCtwL6nx")]
        [n4.SerializableAttribute]
        public class __OhdVJyDJLfvMxAaCtwL6nx : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_DrcUbrnEm51OZtQIMMW9Bq);
                n1.CompilationHelper.SafeDispose(this.__p_UZXiiSJbjLWLGLW9YXjEGy);
                return;
            }

            [n1.ElementAttribute(TracingId = 74165U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "DrcUbrnEm51OZtQIMMW9Bq", Name = "TextWidget (MultiLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_MultiLine_R __p_DrcUbrnEm51OZtQIMMW9Bq;
            [n1.ElementAttribute(TracingId = 78150U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "UZXiiSJbjLWLGLW9YXjEGy", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_UZXiiSJbjLWLGLW9YXjEGy;
            public __OhdVJyDJLfvMxAaCtwL6nx(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __OhdVJyDJLfvMxAaCtwL6nx(__OhdVJyDJLfvMxAaCtwL6nx other): base(other)
            {
                this.__p_DrcUbrnEm51OZtQIMMW9Bq = other.__p_DrcUbrnEm51OZtQIMMW9Bq;
                this.__p_UZXiiSJbjLWLGLW9YXjEGy = other.__p_UZXiiSJbjLWLGLW9YXjEGy;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DrcUbrnEm51OZtQIMMW9Bq", in __p_DrcUbrnEm51OZtQIMMW9Bq), n1.CompilationHelper.GetValueOrExisting(values, "__p_UZXiiSJbjLWLGLW9YXjEGy", in __p_UZXiiSJbjLWLGLW9YXjEGy));
            }

            internal __OhdVJyDJLfvMxAaCtwL6nx __WITH__(n16.TextWidget_MultiLine_R __p_DrcUbrnEm51OZtQIMMW9Bq, n16.EmptyWidget_R __p_UZXiiSJbjLWLGLW9YXjEGy)
            {
                __OhdVJyDJLfvMxAaCtwL6nx that_0 = this;
                this.__p_DrcUbrnEm51OZtQIMMW9Bq = __p_DrcUbrnEm51OZtQIMMW9Bq;
                this.__p_UZXiiSJbjLWLGLW9YXjEGy = __p_UZXiiSJbjLWLGLW9YXjEGy;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "V4HZpdyFqrjMKzclW6WTNY", Name = "__V4HZpdyFqrjMKzclW6WTNY")]
        [n4.SerializableAttribute]
        public class __V4HZpdyFqrjMKzclW6WTNY : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_OiSMduuaG4MPnSzuEjUxAC);
                n1.CompilationHelper.SafeDispose(this.__p_KF7B0UprExnOS5PLxHDaRc);
                n1.CompilationHelper.SafeDispose(this.__p_HDF5XwtCaHuM0GYPRmCnBe);
                n1.CompilationHelper.SafeDispose(this.__p_IUkaeJQ8RWqLPZtElLGm1a);
                n1.CompilationHelper.SafeDispose(this.__p_UK6mScLyqe8N5iJKNdQwS3);
                return;
            }

            [n1.ElementAttribute(TracingId = 78259U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "OiSMduuaG4MPnSzuEjUxAC", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_SingleLine_R __p_OiSMduuaG4MPnSzuEjUxAC;
            [n1.ElementAttribute(TracingId = 78287U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "KF7B0UprExnOS5PLxHDaRc", Name = "Row", IsManaged = true, IsAutoGenerated = true)]
            public n16.Row_R __p_KF7B0UprExnOS5PLxHDaRc;
            [n1.ElementAttribute(TracingId = 78297U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "HDF5XwtCaHuM0GYPRmCnBe", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_SingleLine_R __p_HDF5XwtCaHuM0GYPRmCnBe;
            [n1.ElementAttribute(TracingId = 78308U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "IUkaeJQ8RWqLPZtElLGm1a", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_IUkaeJQ8RWqLPZtElLGm1a;
            [n1.ElementAttribute(TracingId = 78329U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "UK6mScLyqe8N5iJKNdQwS3", Name = "Column", IsManaged = true, IsAutoGenerated = true)]
            public n16.Column_R __p_UK6mScLyqe8N5iJKNdQwS3;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n16.TextWidget_SingleLine_R> __pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF = default(n12.Spread<n16.TextWidget_SingleLine_R>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n3.IWidget> __pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn = default(n12.Spread<n3.IWidget>);
            public __V4HZpdyFqrjMKzclW6WTNY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __V4HZpdyFqrjMKzclW6WTNY(__V4HZpdyFqrjMKzclW6WTNY other): base(other)
            {
                this.__p_OiSMduuaG4MPnSzuEjUxAC = other.__p_OiSMduuaG4MPnSzuEjUxAC;
                this.__p_KF7B0UprExnOS5PLxHDaRc = other.__p_KF7B0UprExnOS5PLxHDaRc;
                this.__p_HDF5XwtCaHuM0GYPRmCnBe = other.__p_HDF5XwtCaHuM0GYPRmCnBe;
                this.__p_IUkaeJQ8RWqLPZtElLGm1a = other.__p_IUkaeJQ8RWqLPZtElLGm1a;
                this.__p_UK6mScLyqe8N5iJKNdQwS3 = other.__p_UK6mScLyqe8N5iJKNdQwS3;
                this.__pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF = other.__pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF;
                this.__pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn = other.__pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_OiSMduuaG4MPnSzuEjUxAC", in __p_OiSMduuaG4MPnSzuEjUxAC), n1.CompilationHelper.GetValueOrExisting(values, "__p_KF7B0UprExnOS5PLxHDaRc", in __p_KF7B0UprExnOS5PLxHDaRc), n1.CompilationHelper.GetValueOrExisting(values, "__p_HDF5XwtCaHuM0GYPRmCnBe", in __p_HDF5XwtCaHuM0GYPRmCnBe), n1.CompilationHelper.GetValueOrExisting(values, "__p_IUkaeJQ8RWqLPZtElLGm1a", in __p_IUkaeJQ8RWqLPZtElLGm1a), n1.CompilationHelper.GetValueOrExisting(values, "__p_UK6mScLyqe8N5iJKNdQwS3", in __p_UK6mScLyqe8N5iJKNdQwS3), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF", in __pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn", in __pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn));
            }

            internal __V4HZpdyFqrjMKzclW6WTNY __WITH__(n16.TextWidget_SingleLine_R __p_OiSMduuaG4MPnSzuEjUxAC, n16.Row_R __p_KF7B0UprExnOS5PLxHDaRc, n16.TextWidget_SingleLine_R __p_HDF5XwtCaHuM0GYPRmCnBe, n16.EmptyWidget_R __p_IUkaeJQ8RWqLPZtElLGm1a, n16.Column_R __p_UK6mScLyqe8N5iJKNdQwS3, n12.Spread<n16.TextWidget_SingleLine_R> __pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF, n12.Spread<n3.IWidget> __pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn)
            {
                __V4HZpdyFqrjMKzclW6WTNY that_0 = this;
                this.__p_OiSMduuaG4MPnSzuEjUxAC = __p_OiSMduuaG4MPnSzuEjUxAC;
                this.__p_KF7B0UprExnOS5PLxHDaRc = __p_KF7B0UprExnOS5PLxHDaRc;
                this.__p_HDF5XwtCaHuM0GYPRmCnBe = __p_HDF5XwtCaHuM0GYPRmCnBe;
                this.__p_IUkaeJQ8RWqLPZtElLGm1a = __p_IUkaeJQ8RWqLPZtElLGm1a;
                this.__p_UK6mScLyqe8N5iJKNdQwS3 = __p_UK6mScLyqe8N5iJKNdQwS3;
                this.__pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF = __pin_group_Input_In_FAHjk9PezbSNR4ewTTFdtF;
                this.__pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn = __pin_group_Input_In_UryrqwGPQVJL11D9zsUGhn;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 80215U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Eb4SaOH6VbQM75dYgtULzP", Name = "MomentsWidget_C")]
    [n4.SerializableAttribute]
    public class MomentsWidget_C : n1.VLObject, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.MomentsWidget_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new MomentsWidget_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.MomentsWidget_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new MomentsWidget_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.MomentsWidget_C Update(n15.IEnumerable<n2.IMomentInfo> Input_In, n10.SkiaPaint_R Text_Paint_In, out n16.Row_R Output_Out)
        {
            var manager_39 = this.__loop_A56wGFKyur7QPVglJMQ04i ?? new n53.ImmutableLifetimeManager();
            var iterator_40 = manager_39.GetIterator(__GetContext__());
            var builder_41 = n6.CollectionBuilders.GetBuilder(this.__cp_CzkK8kUlj2MOu2jCJQdB2b, 16);
            n12.Spread<n12.Spread<n3.IWidget>> output_42;
            try
            {
                var i_2 = 0;
                foreach (var item_0 in Input_In)
                {
                    var splicer_1 = item_0;
                    var i_local_3 = i_2;
                    __AZmnIkSibDQMH2GD4FD81r state_4;
                    if (!iterator_40.MoveNext(out state_4))
                    {
                        iterator_40.Add(state_4 = new __AZmnIkSibDQMH2GD4FD81r(__GetContext__(), n1.VLObject.NewIdentity())
                        {__pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW = n13._Operations_.CreateDefault<n3.IWidget>()});
                        n1.NodeContext Node_Context_5 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "RbPrrux0BeSOpFd3TREolJ", 80241U);
                        var Output_6 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_5);
                        state_4.__p_RbPrrux0BeSOpFd3TREolJ = Output_6;
                        n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "LqB4bzsjySaO9JcbgtuhBg", 80259U);
                        var Output_8 = n16.PanelWidget_R.Create(Node_Context: Node_Context_7);
                        state_4.__p_LqB4bzsjySaO9JcbgtuhBg = Output_8;
                        n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Ij5Hx1LknpMMWy0T2XEouz", 80324U);
                        var Output_10 = n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC.Create(Node_Context: Node_Context_9);
                        state_4.__p_Ij5Hx1LknpMMWy0T2XEouz = Output_10;
                        n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "HOJdOgoMxFrPVSh4YSY1I5", 80340U);
                        var Output_12 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_11);
                        state_4.__p_HOJdOgoMxFrPVSh4YSY1I5 = Output_12;
                    }

                    var Moment_13 = splicer_1.Moment;
                    bool Update_14 = true;
                    var Output_15 = state_4.__p_RbPrrux0BeSOpFd3TREolJ;
                    if (Update_14)
                    {
                        Output_15 = state_4.__p_RbPrrux0BeSOpFd3TREolJ.Update(Value_In: Moment_13, Paint_In: Text_Paint_In);
                    }

                    var Tint_16 = splicer_1.Tint;
                    n9._Operations_.GetFillColor(Style_Selector_In: Tint_16, Result_Out: out n11.Color4 Result_17);
                    n10.SkiaPaint_R Input_18 = n10.SkiaPaint_R.CreateDefault();
                    n25.SKShader Shader_19 = default(n25.SKShader);
                    var State_Output_21 = state_4.__p_Ij5Hx1LknpMMWy0T2XEouz.Update(Input_In: Input_18, Color_In: Result_17, Shader_In: Shader_19, Output_Out: out n10.SkiaPaint_R Output_20);
                    n3.IWidget Widget_22 = (n3.IWidget)Output_15;
                    n11.Vector2 Margin_23 = __c_F7OmaFCIRulOKkvvt1i9O3;
                    n11.Vector2 Padding_24 = __c_RMrqlMBxfzsO61iHwuEesC;
                    bool Background_Enabled_25 = true;
                    n10.SkiaPaint_R Stroke_Paint_26 = n10.SkiaPaint_R.CreateDefault();
                    bool Stroke_Enabled_27 = false;
                    bool Clip_Enabled_28 = false;
                    bool Update_29 = true;
                    var Output_30 = state_4.__p_LqB4bzsjySaO9JcbgtuhBg;
                    if (Update_29)
                    {
                        Output_30 = state_4.__p_LqB4bzsjySaO9JcbgtuhBg.Update(Widget_In: Widget_22, Margin_In: Margin_23, Padding_In: Padding_24, Background_Paint_In: Output_20, Background_Enabled_In: Background_Enabled_25, Stroke_Paint_In: Stroke_Paint_26, Stroke_Enabled_In: Stroke_Enabled_27, Clip_Enabled_In: Clip_Enabled_28);
                    }

                    n11.Vector2 Default_Size_31 = __c_LZeNSkgrtWQLAEK5Gi6paW;
                    bool Update_32 = true;
                    var Output_33 = state_4.__p_HOJdOgoMxFrPVSh4YSY1I5;
                    if (Update_32)
                    {
                        Output_33 = state_4.__p_HOJdOgoMxFrPVSh4YSY1I5.Update(Default_Size_In: Default_Size_31);
                    }

                    n3.IWidget Input_34 = (n3.IWidget)Output_33;
                    n3.IWidget Input_2_35 = (n3.IWidget)Output_30;
                    var builder_36 = n6.CollectionBuilders.GetBuilder(state_4.__pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW, 2);
                    builder_36.Add(Input_34);
                    builder_36.Add(Input_2_35);
                    var __pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW_37 = builder_36.Commit();
                    n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW_37, Result_Out: out n12.Spread<n3.IWidget> Result_38);
                    state_4.__p_RbPrrux0BeSOpFd3TREolJ = Output_15;
                    state_4.__p_Ij5Hx1LknpMMWy0T2XEouz = State_Output_21;
                    state_4.__p_LqB4bzsjySaO9JcbgtuhBg = Output_30;
                    state_4.__p_HOJdOgoMxFrPVSh4YSY1I5 = Output_33;
                    state_4.__pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW = __pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW_37;
                    iterator_40.Update(state_4);
                    builder_41.Add(Result_38);
                    i_2++;
                }
            }
            finally
            {
                manager_39 = iterator_40.Commit();
                this.__loop_A56wGFKyur7QPVglJMQ04i = manager_39;
                output_42 = builder_41.Commit();
                this.__cp_CzkK8kUlj2MOu2jCJQdB2b = output_42;
            }

            n13._Operations_.Flatten<n12.Spread<n12.Spread<n3.IWidget>>, n3.IWidget>(Input_In: output_42, Output_Out: out n12.Spread<n3.IWidget> Output_43);
            int Count_44 = 1;
            n13._Operations_.Skip<n3.IWidget>(Input_In: Output_43, Count_In: Count_44, Output_Out: out n12.Spread<n3.IWidget> Output_45);
            n15.IEnumerable<n3.IWidget> Widgets_46 = (n15.IEnumerable<n3.IWidget>)Output_45;
            bool Update_47 = true;
            var Output_48 = this.__p_HMP9haIlhcpOluwEMSh8OX;
            if (Update_47)
            {
                Output_48 = this.__p_HMP9haIlhcpOluwEMSh8OX.Update(Widgets_In: Widgets_46);
            }

            this.__p_HMP9haIlhcpOluwEMSh8OX = Output_48;
            Output_Out = Output_48;
            return this;
        }

        public n5.MomentsWidget_C __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__cp_CzkK8kUlj2MOu2jCJQdB2b = n13._Operations_.CreateDefault<n12.Spread<n3.IWidget>>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "HMP9haIlhcpOluwEMSh8OX", 80410U);
            var Output_1 = n16.Row_R.Create(Node_Context: Node_Context_0);
            this.__p_HMP9haIlhcpOluwEMSh8OX = Output_1;
            this.__loop_A56wGFKyur7QPVglJMQ04i = default(n53.ImmutableLifetimeManager);
            return this;
        }

        public n5.MomentsWidget_C __CreateDefault__()
        {
            this.__cp_CzkK8kUlj2MOu2jCJQdB2b = n13._Operations_.CreateDefault<n12.Spread<n3.IWidget>>();
            this.__loop_A56wGFKyur7QPVglJMQ04i = default(n53.ImmutableLifetimeManager);
            this.__p_HMP9haIlhcpOluwEMSh8OX = n16.Row_R.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__loop_A56wGFKyur7QPVglJMQ04i);
            n1.CompilationHelper.SafeDispose(this.__p_HMP9haIlhcpOluwEMSh8OX);
            return;
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_F7OmaFCIRulOKkvvt1i9O3 = n1.CompilationHelper.Deserialize<n11.Vector2>("0.01, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "F7OmaFCIRulOKkvvt1i9O3");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_RMrqlMBxfzsO61iHwuEesC = n1.CompilationHelper.Deserialize<n11.Vector2>("0.02, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "RMrqlMBxfzsO61iHwuEesC");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_LZeNSkgrtWQLAEK5Gi6paW = n1.CompilationHelper.Deserialize<n11.Vector2>("0.05, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "LZeNSkgrtWQLAEK5Gi6paW");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n53.ImmutableLifetimeManager __loop_A56wGFKyur7QPVglJMQ04i;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n12.Spread<n3.IWidget>> __cp_CzkK8kUlj2MOu2jCJQdB2b;
        [n1.ElementAttribute(TracingId = 80410U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "HMP9haIlhcpOluwEMSh8OX", Name = "Row", IsManaged = true, IsAutoGenerated = true)]
        public n16.Row_R __p_HMP9haIlhcpOluwEMSh8OX;
        static MomentsWidget_C()
        {
        }

        public MomentsWidget_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal MomentsWidget_C(MomentsWidget_C other): base(other)
        {
            this.__loop_A56wGFKyur7QPVglJMQ04i = other.__loop_A56wGFKyur7QPVglJMQ04i;
            this.__cp_CzkK8kUlj2MOu2jCJQdB2b = other.__cp_CzkK8kUlj2MOu2jCJQdB2b;
            this.__p_HMP9haIlhcpOluwEMSh8OX = other.__p_HMP9haIlhcpOluwEMSh8OX;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__loop_A56wGFKyur7QPVglJMQ04i", in __loop_A56wGFKyur7QPVglJMQ04i), n1.CompilationHelper.GetValueOrExisting(values, "__cp_CzkK8kUlj2MOu2jCJQdB2b", in __cp_CzkK8kUlj2MOu2jCJQdB2b), n1.CompilationHelper.GetValueOrExisting(values, "__p_HMP9haIlhcpOluwEMSh8OX", in __p_HMP9haIlhcpOluwEMSh8OX));
        }

        internal MomentsWidget_C __WITH__(n53.ImmutableLifetimeManager __loop_A56wGFKyur7QPVglJMQ04i, n12.Spread<n12.Spread<n3.IWidget>> __cp_CzkK8kUlj2MOu2jCJQdB2b, n16.Row_R __p_HMP9haIlhcpOluwEMSh8OX)
        {
            n5.MomentsWidget_C that_0 = this;
            this.__loop_A56wGFKyur7QPVglJMQ04i = __loop_A56wGFKyur7QPVglJMQ04i;
            this.__cp_CzkK8kUlj2MOu2jCJQdB2b = __cp_CzkK8kUlj2MOu2jCJQdB2b;
            this.__p_HMP9haIlhcpOluwEMSh8OX = __p_HMP9haIlhcpOluwEMSh8OX;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "AZmnIkSibDQMH2GD4FD81r", Name = "__AZmnIkSibDQMH2GD4FD81r")]
        [n4.SerializableAttribute]
        public class __AZmnIkSibDQMH2GD4FD81r : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RbPrrux0BeSOpFd3TREolJ);
                n1.CompilationHelper.SafeDispose(this.__p_LqB4bzsjySaO9JcbgtuhBg);
                n1.CompilationHelper.SafeDispose(this.__p_Ij5Hx1LknpMMWy0T2XEouz);
                n1.CompilationHelper.SafeDispose(this.__p_HOJdOgoMxFrPVSh4YSY1I5);
                return;
            }

            [n1.ElementAttribute(TracingId = 80241U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "RbPrrux0BeSOpFd3TREolJ", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
            public n16.TextWidget_SingleLine_R __p_RbPrrux0BeSOpFd3TREolJ;
            [n1.ElementAttribute(TracingId = 80259U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "LqB4bzsjySaO9JcbgtuhBg", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.PanelWidget_R __p_LqB4bzsjySaO9JcbgtuhBg;
            [n1.ElementAttribute(TracingId = 80324U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Ij5Hx1LknpMMWy0T2XEouz", Name = "Fill", IsManaged = true, IsAutoGenerated = true)]
            public n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_Ij5Hx1LknpMMWy0T2XEouz;
            [n1.ElementAttribute(TracingId = 80340U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "HOJdOgoMxFrPVSh4YSY1I5", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
            public n16.EmptyWidget_R __p_HOJdOgoMxFrPVSh4YSY1I5;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n3.IWidget> __pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW = default(n12.Spread<n3.IWidget>);
            public __AZmnIkSibDQMH2GD4FD81r(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __AZmnIkSibDQMH2GD4FD81r(__AZmnIkSibDQMH2GD4FD81r other): base(other)
            {
                this.__p_RbPrrux0BeSOpFd3TREolJ = other.__p_RbPrrux0BeSOpFd3TREolJ;
                this.__p_LqB4bzsjySaO9JcbgtuhBg = other.__p_LqB4bzsjySaO9JcbgtuhBg;
                this.__p_Ij5Hx1LknpMMWy0T2XEouz = other.__p_Ij5Hx1LknpMMWy0T2XEouz;
                this.__p_HOJdOgoMxFrPVSh4YSY1I5 = other.__p_HOJdOgoMxFrPVSh4YSY1I5;
                this.__pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW = other.__pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RbPrrux0BeSOpFd3TREolJ", in __p_RbPrrux0BeSOpFd3TREolJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_LqB4bzsjySaO9JcbgtuhBg", in __p_LqB4bzsjySaO9JcbgtuhBg), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ij5Hx1LknpMMWy0T2XEouz", in __p_Ij5Hx1LknpMMWy0T2XEouz), n1.CompilationHelper.GetValueOrExisting(values, "__p_HOJdOgoMxFrPVSh4YSY1I5", in __p_HOJdOgoMxFrPVSh4YSY1I5), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW", in __pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW));
            }

            internal __AZmnIkSibDQMH2GD4FD81r __WITH__(n16.TextWidget_SingleLine_R __p_RbPrrux0BeSOpFd3TREolJ, n16.PanelWidget_R __p_LqB4bzsjySaO9JcbgtuhBg, n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_Ij5Hx1LknpMMWy0T2XEouz, n16.EmptyWidget_R __p_HOJdOgoMxFrPVSh4YSY1I5, n12.Spread<n3.IWidget> __pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW)
            {
                __AZmnIkSibDQMH2GD4FD81r that_0 = this;
                this.__p_RbPrrux0BeSOpFd3TREolJ = __p_RbPrrux0BeSOpFd3TREolJ;
                this.__p_LqB4bzsjySaO9JcbgtuhBg = __p_LqB4bzsjySaO9JcbgtuhBg;
                this.__p_Ij5Hx1LknpMMWy0T2XEouz = __p_Ij5Hx1LknpMMWy0T2XEouz;
                this.__p_HOJdOgoMxFrPVSh4YSY1I5 = __p_HOJdOgoMxFrPVSh4YSY1I5;
                this.__pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW = __pin_group_Input_In_NZd0j2YIlKFLl3jquGiEPW;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 80520U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "L1QOUlCkuZlP8km0QOzx9L", Name = "AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L")]
    [n4.SerializableAttribute]
    public class AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L : n1.VLObject, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L Create(n1.NodeContext Node_Context)
        {
            var instance = new AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L CreateDefault()
        {
            var instance = new AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L Update(n2.ILiveElement Element_In, bool On_Data_In, out bool Result_Out)
        {
            float __pad_LNGQiwrjQMCMzqAlt0CIaV_0 = __slot_LNGQiwrjQMCMzqAlt0CIaV;
            n52.Key Key_1 = __c_KtgHoWbuAqYLvKwRbn0KXZ;
            var Result_2 = n52.Keyboard.IsKeyDown(key: Key_1);
            var Output_5 = this.__p_N1RhfA5s31pMLDqEBcruwK.Update(Value_In: Result_2, Up_Edge_Out: out bool Up_Edge_3, Down_Edge_Out: out bool Down_Edge_4);
            var Output_6 = Element_In;
            if (Up_Edge_3)
            {
                ((n2.ILiveElement)Element_In).DetachFromInstance();
            }

            var Output_7 = !On_Data_In;
            var Output_9 = this.__p_TowmTitmxaQMGVDn0igr8h.Update(Enabled_In: Output_7, Reset_In: On_Data_In, Time_Out: out float Time_8);
            var Result_10 = Time_8 > __pad_LNGQiwrjQMCMzqAlt0CIaV_0;
            float __pad_IK1aRxpIUvsLUkwoLyNaqt_11 = Time_8;
            Result_Out = Result_10;
            n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = Output_5 != this.__p_N1RhfA5s31pMLDqEBcruwK || Output_9 != this.__p_TowmTitmxaQMGVDn0igr8h || Time_8 != this.__slot_IK1aRxpIUvsLUkwoLyNaqt ? new AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L(this)
                {__p_N1RhfA5s31pMLDqEBcruwK = Output_5, __p_TowmTitmxaQMGVDn0igr8h = Output_9, __slot_IK1aRxpIUvsLUkwoLyNaqt = Time_8} : that_12;
            else
            {
                this.__p_N1RhfA5s31pMLDqEBcruwK = Output_5;
                this.__p_TowmTitmxaQMGVDn0igr8h = Output_9;
                this.__slot_IK1aRxpIUvsLUkwoLyNaqt = Time_8;
            }

            return that_12;
        }

        public n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "TowmTitmxaQMGVDn0igr8h", 80525U);
            n60.IClock Clock_1 = n59._Operations_.CreateDefault();
            n60.Time Time_2 = n1.CompilationHelper.Deserialize<n60.Time>("0", false, null, null);
            var Output_3 = n61.Stopwatch_Oy2h30sR8ODMEFMvzPCidW.Create(Node_Context: Node_Context_0, Clock_In: Clock_1, Time_In: Time_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "N1RhfA5s31pMLDqEBcruwK", 80569U);
            var Output_5 = n37.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_4);
            n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L that_6 = this;
            this.__slot_IK1aRxpIUvsLUkwoLyNaqt = 0F;
            this.__p_TowmTitmxaQMGVDn0igr8h = Output_3;
            this.__p_N1RhfA5s31pMLDqEBcruwK = Output_5;
            return that_6;
        }

        public n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L __CreateDefault__()
        {
            n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L that_0 = this;
            this.__slot_IK1aRxpIUvsLUkwoLyNaqt = 0F;
            this.__p_N1RhfA5s31pMLDqEBcruwK = n37.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_TowmTitmxaQMGVDn0igr8h = n61.Stopwatch_Oy2h30sR8ODMEFMvzPCidW.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_N1RhfA5s31pMLDqEBcruwK);
            n1.CompilationHelper.SafeDispose(this.__p_TowmTitmxaQMGVDn0igr8h);
            return;
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 80556U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "IK1aRxpIUvsLUkwoLyNaqt", Name = "__slot_IK1aRxpIUvsLUkwoLyNaqt")]
        public float __slot_IK1aRxpIUvsLUkwoLyNaqt;
        [n1.ElementAttribute(TracingId = 80606U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "LNGQiwrjQMCMzqAlt0CIaV", Name = "__slot_LNGQiwrjQMCMzqAlt0CIaV")]
        public static float __slot_LNGQiwrjQMCMzqAlt0CIaV = 2F;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n52.Key __c_KtgHoWbuAqYLvKwRbn0KXZ = n1.CompilationHelper.Deserialize<n52.Key>("Tab", false, "QsvwBVssT9xLO3Td5ph2Z9", "KtgHoWbuAqYLvKwRbn0KXZ");
        [n1.ElementAttribute(TracingId = 80569U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "N1RhfA5s31pMLDqEBcruwK", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n37.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_N1RhfA5s31pMLDqEBcruwK;
        [n1.ElementAttribute(TracingId = 80525U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "TowmTitmxaQMGVDn0igr8h", Name = "Stopwatch", IsManaged = true, IsAutoGenerated = true)]
        public n61.Stopwatch_Oy2h30sR8ODMEFMvzPCidW __p_TowmTitmxaQMGVDn0igr8h;
        static AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L()
        {
        }

        public AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L(AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L other): base(other)
        {
            this.__slot_IK1aRxpIUvsLUkwoLyNaqt = other.__slot_IK1aRxpIUvsLUkwoLyNaqt;
            this.__p_N1RhfA5s31pMLDqEBcruwK = other.__p_N1RhfA5s31pMLDqEBcruwK;
            this.__p_TowmTitmxaQMGVDn0igr8h = other.__p_TowmTitmxaQMGVDn0igr8h;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_IK1aRxpIUvsLUkwoLyNaqt", in __slot_IK1aRxpIUvsLUkwoLyNaqt), n1.CompilationHelper.GetValueOrExisting(values, "__p_N1RhfA5s31pMLDqEBcruwK", in __p_N1RhfA5s31pMLDqEBcruwK), n1.CompilationHelper.GetValueOrExisting(values, "__p_TowmTitmxaQMGVDn0igr8h", in __p_TowmTitmxaQMGVDn0igr8h));
        }

        internal AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L __WITH__(float __slot_IK1aRxpIUvsLUkwoLyNaqt, n37.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_N1RhfA5s31pMLDqEBcruwK, n61.Stopwatch_Oy2h30sR8ODMEFMvzPCidW __p_TowmTitmxaQMGVDn0igr8h)
        {
            n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_IK1aRxpIUvsLUkwoLyNaqt != this.__slot_IK1aRxpIUvsLUkwoLyNaqt || __p_N1RhfA5s31pMLDqEBcruwK != this.__p_N1RhfA5s31pMLDqEBcruwK || __p_TowmTitmxaQMGVDn0igr8h != this.__p_TowmTitmxaQMGVDn0igr8h ? new AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L(this)
                {__slot_IK1aRxpIUvsLUkwoLyNaqt = __slot_IK1aRxpIUvsLUkwoLyNaqt, __p_N1RhfA5s31pMLDqEBcruwK = __p_N1RhfA5s31pMLDqEBcruwK, __p_TowmTitmxaQMGVDn0igr8h = __p_TowmTitmxaQMGVDn0igr8h} : that_0;
            else
            {
                this.__slot_IK1aRxpIUvsLUkwoLyNaqt = __slot_IK1aRxpIUvsLUkwoLyNaqt;
                this.__p_N1RhfA5s31pMLDqEBcruwK = __p_N1RhfA5s31pMLDqEBcruwK;
                this.__p_TowmTitmxaQMGVDn0igr8h = __p_TowmTitmxaQMGVDn0igr8h;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 80662U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "K0Fe7XojpBfMMlqWacmr3k", Name = "AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k")]
    [n4.SerializableAttribute]
    public class AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k : n1.VLObject, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k Create(n1.NodeContext Node_Context)
        {
            var instance = new AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k CreateDefault()
        {
            var instance = new AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k Update(n2.ILiveElement Element_In, out n16.TextWidget_SingleLine_R Output_Out)
        {
            string __pad_M0NohGcCLD2PgAFiCCR6H9_0 = __slot_M0NohGcCLD2PgAFiCCR6H9;
            string __pad_A02nxuyQx5YOAG3Gqj2Q12_1 = __slot_A02nxuyQx5YOAG3Gqj2Q12;
            var Is_Attached_2 = Element_In.IsAttached;
            n8._Operations_.Switch_Boolean<string>(Condition_In: Is_Attached_2, Input_In: __pad_M0NohGcCLD2PgAFiCCR6H9_0, Input_2_In: __pad_A02nxuyQx5YOAG3Gqj2Q12_1, Output_Out: out string Output_3);
            var State_Output_13 = this.__p_TTUNchEQ8uOPIoXm2sTv6n.Update(Output_Out: out n9.TooltipPaints_C Output_4, Background_Out: out n10.SkiaPaint_R Background_5, Hint_Out: out n11.Color4 Hint_6, Warning_Out: out n11.Color4 Warning_7, Error_Out: out n11.Color4 Error_8, Runtime_Error_Out: out n11.Color4 Runtime_Error_9, Font1_Out: out n10.SkiaPaint_R Font1_10, Font2_Out: out n10.SkiaPaint_R Font2_11, Font3_Out: out n10.SkiaPaint_R Font3_12);
            bool Update_14 = true;
            var Output_15 = this.__p_EtBXFJZXHG4LSNx03wiMPJ;
            if (Update_14)
            {
                Output_15 = this.__p_EtBXFJZXHG4LSNx03wiMPJ.Update(Value_In: Output_3, Paint_In: Font2_11);
            }

            Output_Out = Output_15;
            n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k that_16 = this;
            if (this.__GetContext__().IsImmutable)
                that_16 = State_Output_13 != this.__p_TTUNchEQ8uOPIoXm2sTv6n || Output_15 != this.__p_EtBXFJZXHG4LSNx03wiMPJ ? new AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k(this)
                {__p_TTUNchEQ8uOPIoXm2sTv6n = State_Output_13, __p_EtBXFJZXHG4LSNx03wiMPJ = Output_15} : that_16;
            else
            {
                this.__p_TTUNchEQ8uOPIoXm2sTv6n = State_Output_13;
                this.__p_EtBXFJZXHG4LSNx03wiMPJ = Output_15;
            }

            return that_16;
        }

        public n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "EtBXFJZXHG4LSNx03wiMPJ", 80666U);
            var Output_1 = n16.TextWidget_SingleLine_R.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "TTUNchEQ8uOPIoXm2sTv6n", 84604U);
            var Output_3 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_2);
            n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k that_4 = this;
            this.__p_EtBXFJZXHG4LSNx03wiMPJ = Output_1;
            this.__p_TTUNchEQ8uOPIoXm2sTv6n = Output_3;
            return that_4;
        }

        public n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k __CreateDefault__()
        {
            n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k that_0 = this;
            this.__p_TTUNchEQ8uOPIoXm2sTv6n = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__p_EtBXFJZXHG4LSNx03wiMPJ = n16.TextWidget_SingleLine_R.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_TTUNchEQ8uOPIoXm2sTv6n);
            n1.CompilationHelper.SafeDispose(this.__p_EtBXFJZXHG4LSNx03wiMPJ);
            return;
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 84625U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "A02nxuyQx5YOAG3Gqj2Q12", Name = "__slot_A02nxuyQx5YOAG3Gqj2Q12")]
        public static string __slot_A02nxuyQx5YOAG3Gqj2Q12 = "No data observed. Press [Tab] to detach from this instance.";
        [n1.ElementAttribute(TracingId = 84652U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "M0NohGcCLD2PgAFiCCR6H9", Name = "__slot_M0NohGcCLD2PgAFiCCR6H9")]
        public static string __slot_M0NohGcCLD2PgAFiCCR6H9 = "No data observed.";
        [n1.ElementAttribute(TracingId = 84604U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "TTUNchEQ8uOPIoXm2sTv6n", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_TTUNchEQ8uOPIoXm2sTv6n;
        [n1.ElementAttribute(TracingId = 80666U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "EtBXFJZXHG4LSNx03wiMPJ", Name = "TextWidget (SingleLine)", IsManaged = true, IsAutoGenerated = true)]
        public n16.TextWidget_SingleLine_R __p_EtBXFJZXHG4LSNx03wiMPJ;
        static AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k()
        {
        }

        public AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k(AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k other): base(other)
        {
            this.__p_TTUNchEQ8uOPIoXm2sTv6n = other.__p_TTUNchEQ8uOPIoXm2sTv6n;
            this.__p_EtBXFJZXHG4LSNx03wiMPJ = other.__p_EtBXFJZXHG4LSNx03wiMPJ;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TTUNchEQ8uOPIoXm2sTv6n", in __p_TTUNchEQ8uOPIoXm2sTv6n), n1.CompilationHelper.GetValueOrExisting(values, "__p_EtBXFJZXHG4LSNx03wiMPJ", in __p_EtBXFJZXHG4LSNx03wiMPJ));
        }

        internal AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k __WITH__(n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_TTUNchEQ8uOPIoXm2sTv6n, n16.TextWidget_SingleLine_R __p_EtBXFJZXHG4LSNx03wiMPJ)
        {
            n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_TTUNchEQ8uOPIoXm2sTv6n != this.__p_TTUNchEQ8uOPIoXm2sTv6n || __p_EtBXFJZXHG4LSNx03wiMPJ != this.__p_EtBXFJZXHG4LSNx03wiMPJ ? new AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k(this)
                {__p_TTUNchEQ8uOPIoXm2sTv6n = __p_TTUNchEQ8uOPIoXm2sTv6n, __p_EtBXFJZXHG4LSNx03wiMPJ = __p_EtBXFJZXHG4LSNx03wiMPJ} : that_0;
            else
            {
                this.__p_TTUNchEQ8uOPIoXm2sTv6n = __p_TTUNchEQ8uOPIoXm2sTv6n;
                this.__p_EtBXFJZXHG4LSNx03wiMPJ = __p_EtBXFJZXHG4LSNx03wiMPJ;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 84722U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PKvKxZVF3NCPTGg78sBLx1", Name = "AddLiveValue_PKvKxZVF3NCPTGg78sBLx1")]
    [n4.SerializableAttribute]
    public class AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 : n1.VLObject, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 Create(n1.NodeContext Node_Context)
        {
            var instance = new AddLiveValue_PKvKxZVF3NCPTGg78sBLx1(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 CreateDefault()
        {
            var instance = new AddLiveValue_PKvKxZVF3NCPTGg78sBLx1(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 Update(n3.ViewerContext Context_In, n4.IObservable<n38.LiveValueNotification> Messages_In, n2.ILiveElement Hub_In, out n16.PanelWidget_R Output_Out)
        {
            bool Reset_0 = false;
            var __fallback___1 = n1.ServiceRegistry.Current;
            n43._Operations_.Update_H<n4.Object, n38.LiveValueNotification, n4.Tuple<n3.IWidget, bool>>(Input_In: this.__p_SmfCQBl952FMO5G53TfZzb, Messages_In: Messages_In, Reset_In: Reset_0, Update_In: (n4.Object s_4, n38.LiveValueNotification Input_1_In_5) =>
            {
                using var __current_2 = __fallback___1.MakeCurrentIfNone();
                var state_3 = n1.CompilationHelper.Restore<__EWGhterieE7QNFjFz9Ivw0>(s_4, __GetContext__());
                var Value_6 = Input_1_In_5.Value;
                var Output_9 = state_3.__p_K9wulf3rF0mNrfnWXrpq6R.Update(Value_In: Value_6, Result_Out: out bool Result_7, Unchanged_Out: out bool Unchanged_8);
                n62._Operations_.Split(Input_In: Input_1_In_5, Value_Out: out n4.Object Value_10, Source_Out: out n38.PatchNotification Source_11);
                var Instance_12 = Source_11.Instance;
                n22.ObjectHelpers.IsAssigned(x: Instance_12, result: out bool Result_13, notAssigned: out bool Not_Assigned_14);
                n1.NodeContext __auto_15;
                if (Result_13)
                {
                    n63._Operations_.Context(Input_In: Instance_12, Context_Out: out n1.NodeContext Context_17);
                    __auto_15 = Context_17;
                }
                else
                {
                    __auto_15 = n64._Operations_.CreateDefault_H();
                }

                var Output_18 = Context_In.ContextForLiveValue(nodeContext: __auto_15);
                bool Recreate_19 = false;
                var Output_21 = state_3.__p_M7riJIuMGBsMYzWwQ84lUo.Update(Value_In: Value_10, Recreate_In: Recreate_19, Context_In: Output_18, Widget_Out: out n16.LayoutBuilder_R Widget_20);
                n3.IWidget Item_1_22 = (n3.IWidget)Widget_20;
                n41._Operations_.Join<n3.IWidget, bool>(Item_1_In: Item_1_22, Item_2_In: Result_7, Output_Out: out n4.Tuple<n3.IWidget, bool> Output_23);
                if (state_3.__GetContext__().IsImmutable)
                    state_3 = Output_9 != state_3.__p_K9wulf3rF0mNrfnWXrpq6R || Output_21 != state_3.__p_M7riJIuMGBsMYzWwQ84lUo ? new __EWGhterieE7QNFjFz9Ivw0(state_3)
                    {__p_K9wulf3rF0mNrfnWXrpq6R = Output_9, __p_M7riJIuMGBsMYzWwQ84lUo = Output_21} : state_3;
                else
                {
                    state_3.__p_K9wulf3rF0mNrfnWXrpq6R = Output_9;
                    state_3.__p_M7riJIuMGBsMYzWwQ84lUo = Output_21;
                }

                return n4.Tuple.Create<n4.Object, n4.Tuple<n3.IWidget, bool>>(state_3, Output_23);
            }

            , Create_In: () =>
            {
                using var __current_24 = __fallback___1.MakeCurrentIfNone();
                var state_3 = new __EWGhterieE7QNFjFz9Ivw0(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "M7riJIuMGBsMYzWwQ84lUo", 84763U);
                var Output_26 = n31.AdaptiveViewer_C.Create(Node_Context_In: Node_Context_25);
                state_3.__p_M7riJIuMGBsMYzWwQ84lUo = Output_26;
                n1.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "K9wulf3rF0mNrfnWXrpq6R", 84815U);
                bool Changed_On_Create_28 = false;
                var Output_29 = n37.Changed_A8JGbead2bxNdnPybiEqVS<n4.Object>.Create<n36.__AdaptiveImplementations__QsvwBVssT9xLO3Td5ph2Z9>(Node_Context: Node_Context_27, Changed_On_Create_In: Changed_On_Create_28);
                state_3.__p_K9wulf3rF0mNrfnWXrpq6R = Output_29;
                return state_3;
            }

            , Output_Out: out n42.ForEach<n4.Object, n38.LiveValueNotification, n4.Tuple<n3.IWidget, bool>> Output_30, Result_Out: out n4.IObservable<n4.Tuple<n3.IWidget, bool>> Result_31);
            bool Reset_32 = false;
            bool Update_33 = true;
            var Output_34 = this.__p_IAwNPWnZ224QYLMrtLrsoC;
            if (Update_33)
            {
                n44._Operations_.Update_H<n4.Tuple<n3.IWidget, bool>>(Input_In: this.__p_IAwNPWnZ224QYLMrtLrsoC, Async_Notifications_In: Result_31, Reset_In: Reset_32, Output_Out: out Output_34);
            }

            n44._Operations_.GetData_H<n4.Tuple<n3.IWidget, bool>>(Input_In: Output_34, Output_Out: out n42.HoldLatest<n4.Tuple<n3.IWidget, bool>> Output_35, Value_Out: out n4.Tuple<n3.IWidget, bool> Value_36, On_Data_Out: out bool On_Data_37);
            var Is_Tooltip_38 = Context_In.IsTooltip;
            int Index_39 = n4.Convert.ToInt32(Is_Tooltip_38);
            n41._Operations_.Split<n3.IWidget, bool>(Input_In: Value_36, Item_1_Out: out n3.IWidget Item_1_40, Item_2_Out: out bool Item_2_41);
            var State_Output_51 = this.__p_UMgqkdgqXcPLjpNqH4XMrS.Update(Output_Out: out n9.TooltipPaints_C Output_42, Background_Out: out n10.SkiaPaint_R Background_43, Hint_Out: out n11.Color4 Hint_44, Warning_Out: out n11.Color4 Warning_45, Error_Out: out n11.Color4 Error_46, Runtime_Error_Out: out n11.Color4 Runtime_Error_47, Font1_Out: out n10.SkiaPaint_R Font1_48, Font2_Out: out n10.SkiaPaint_R Font2_49, Font3_Out: out n10.SkiaPaint_R Font3_50);
            bool Update_52 = true;
            var Output_53 = this.__p_KlK9peiCkClQFhyrzMupqI;
            if (Update_52)
            {
                Output_53 = this.__p_KlK9peiCkClQFhyrzMupqI.Update(Bang_In: On_Data_37, Paint_In: Font2_49, Clock_Paint_In: Background_43, Changed_In: Item_2_41);
            }

            n3.IWidget Widget_54 = (n3.IWidget)Output_53;
            float X_55 = 0.15F;
            bool Update_56 = true;
            var Output_57 = this.__p_GqTGLmZD4UZNccHoKUVQK6;
            if (Update_56)
            {
                Output_57 = this.__p_GqTGLmZD4UZNccHoKUVQK6.Update(Widget_In: Widget_54, X_In: X_55);
            }

            n3.IWidget Input_58 = (n3.IWidget)Output_57;
            n11.Vector2 Default_Size_59 = __c_OfegTunUyCyMe90WwITzpt;
            bool Update_60 = true;
            var Output_61 = this.__p_TYkuFvlePJZPMCWkt5PxhC;
            if (Update_60)
            {
                Output_61 = this.__p_TYkuFvlePJZPMCWkt5PxhC.Update(Default_Size_In: Default_Size_59);
            }

            n3.IWidget Input_2_62 = (n3.IWidget)Output_61;
            var builder_63 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD, 3);
            builder_63.Add(Input_58);
            builder_63.Add(Input_2_62);
            builder_63.Add(Item_1_40);
            var __pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD_64 = builder_63.Commit();
            n13._Operations_.Cons<n3.IWidget>(Input_In: __pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD_64, Result_Out: out n12.Spread<n3.IWidget> Result_65);
            n15.IEnumerable<n3.IWidget> Widgets_66 = (n15.IEnumerable<n3.IWidget>)Result_65;
            bool Update_67 = true;
            var Output_68 = this.__p_Mpis4Phbny0OqyboZ9zVrD;
            if (Update_67)
            {
                Output_68 = this.__p_Mpis4Phbny0OqyboZ9zVrD.Update(Widgets_In: Widgets_66);
            }

            n3.IWidget Input_2_69 = (n3.IWidget)Output_68;
            var builder_70 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G, 2);
            builder_70.Add(Item_1_40);
            builder_70.Add(Input_2_69);
            var __pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G_71 = builder_70.Commit();
            n37._Operations_.Switch<n3.IWidget, n36.__AdaptiveImplementations__QsvwBVssT9xLO3Td5ph2Z9>(Index_In: Index_39, Input_In: __pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G_71, Output_Out: out n3.IWidget Output_72);
            var Output_74 = this.__p_HLVMDTs3QS9O5ShVLEcnp5.Update(Element_In: Hub_In, On_Data_In: On_Data_37, Result_Out: out bool Result_73);
            var State_Output_76 = this.__p_Db5JHpQ21tWQHb6CXNJdS1.Update(Element_In: Hub_In, Output_Out: out n16.TextWidget_SingleLine_R Output_75);
            n3.IWidget Input_2_77 = (n3.IWidget)Output_75;
            int Index_78 = n4.Convert.ToInt32(Result_73);
            n3.IWidget Input_79 = (n3.IWidget)Output_68;
            var builder_80 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln, 2);
            builder_80.Add(Input_79);
            builder_80.Add(Input_2_77);
            var __pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln_81 = builder_80.Commit();
            n37._Operations_.Switch<n3.IWidget, n36.__AdaptiveImplementations__QsvwBVssT9xLO3Td5ph2Z9>(Index_In: Index_78, Input_In: __pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln_81, Output_Out: out n3.IWidget Output_82);
            n10.SkiaPaint_R Input_83 = n10.SkiaPaint_R.CreateDefault();
            n11.Color4 Color_84 = __c_Scqo2a3zvrMLXJGOiOlMck;
            n25.SKShader Shader_85 = default(n25.SKShader);
            var State_Output_87 = this.__p_JvAHJuPj0wBMVmOGXPNkOY.Update(Input_In: Input_83, Color_In: Color_84, Shader_In: Shader_85, Output_Out: out n10.SkiaPaint_R Output_86);
            n10.SkiaPaint_R Input_88 = n10.SkiaPaint_R.CreateDefault();
            n11.Color4 Color_89 = __c_O6n79G2AlR5OqzM5rB7cBz;
            float Stroke_Width_90 = 0.01F;
            n25.SKStrokeJoin Join_91 = __c_QTuGyprueJCQNQO3vLssuW;
            n25.SKStrokeCap Cap_92 = __c_CxBNvbAyLoUMmWS0SH4zoG;
            float Miter_93 = 0F;
            var State_Output_95 = this.__p_QJ3K6yFtP9cPYKVIKSZp2E.Update(Input_In: Input_88, Color_In: Color_89, Stroke_Width_In: Stroke_Width_90, Join_In: Join_91, Cap_In: Cap_92, Miter_In: Miter_93, Output_Out: out n10.SkiaPaint_R Output_94);
            n11.Vector2 Margin_96 = __c_Phej9AD3nvZPHW2kZoOY2f;
            n11.Vector2 Padding_97 = n18._Operations_.CreateDefault();
            bool Background_Enabled_98 = false;
            bool Stroke_Enabled_99 = false;
            bool Clip_Enabled_100 = false;
            bool Update_101 = true;
            var Output_102 = this.__p_BXhpwBZEBKILInbiPQGSYi;
            if (Update_101)
            {
                Output_102 = this.__p_BXhpwBZEBKILInbiPQGSYi.Update(Widget_In: Output_72, Margin_In: Margin_96, Padding_In: Padding_97, Background_Paint_In: Output_86, Background_Enabled_In: Background_Enabled_98, Stroke_Paint_In: Output_94, Stroke_Enabled_In: Stroke_Enabled_99, Clip_Enabled_In: Clip_Enabled_100);
            }

            n11.Vector2 Default_Size_103 = n18._Operations_.CreateDefault();
            bool Update_104 = true;
            var Output_105 = this.__p_JfvdaUKHecgOEoToFJwivV;
            if (Update_104)
            {
                Output_105 = this.__p_JfvdaUKHecgOEoToFJwivV.Update(Default_Size_In: Default_Size_103);
            }

            Output_Out = Output_102;
            n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 that_106 = this;
            if (this.__GetContext__().IsImmutable)
                that_106 = Output_30 != this.__p_SmfCQBl952FMO5G53TfZzb || Output_35 != this.__p_IAwNPWnZ224QYLMrtLrsoC || State_Output_51 != this.__p_UMgqkdgqXcPLjpNqH4XMrS || Output_53 != this.__p_KlK9peiCkClQFhyrzMupqI || Output_57 != this.__p_GqTGLmZD4UZNccHoKUVQK6 || Output_61 != this.__p_TYkuFvlePJZPMCWkt5PxhC || __pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD_64 != this.__pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD || Output_68 != this.__p_Mpis4Phbny0OqyboZ9zVrD || __pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G_71 != this.__pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G || Output_74 != this.__p_HLVMDTs3QS9O5ShVLEcnp5 || State_Output_76 != this.__p_Db5JHpQ21tWQHb6CXNJdS1 || __pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln_81 != this.__pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln || State_Output_87 != this.__p_JvAHJuPj0wBMVmOGXPNkOY || State_Output_95 != this.__p_QJ3K6yFtP9cPYKVIKSZp2E || Output_102 != this.__p_BXhpwBZEBKILInbiPQGSYi || Output_105 != this.__p_JfvdaUKHecgOEoToFJwivV ? new AddLiveValue_PKvKxZVF3NCPTGg78sBLx1(this)
                {__p_SmfCQBl952FMO5G53TfZzb = Output_30, __p_IAwNPWnZ224QYLMrtLrsoC = Output_35, __p_UMgqkdgqXcPLjpNqH4XMrS = State_Output_51, __p_KlK9peiCkClQFhyrzMupqI = Output_53, __p_GqTGLmZD4UZNccHoKUVQK6 = Output_57, __p_TYkuFvlePJZPMCWkt5PxhC = Output_61, __pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD = __pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD_64, __p_Mpis4Phbny0OqyboZ9zVrD = Output_68, __pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G = __pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G_71, __p_HLVMDTs3QS9O5ShVLEcnp5 = Output_74, __p_Db5JHpQ21tWQHb6CXNJdS1 = State_Output_76, __pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln = __pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln_81, __p_JvAHJuPj0wBMVmOGXPNkOY = State_Output_87, __p_QJ3K6yFtP9cPYKVIKSZp2E = State_Output_95, __p_BXhpwBZEBKILInbiPQGSYi = Output_102, __p_JfvdaUKHecgOEoToFJwivV = Output_105} : that_106;
            else
            {
                this.__p_SmfCQBl952FMO5G53TfZzb = Output_30;
                this.__p_IAwNPWnZ224QYLMrtLrsoC = Output_35;
                this.__p_UMgqkdgqXcPLjpNqH4XMrS = State_Output_51;
                this.__p_KlK9peiCkClQFhyrzMupqI = Output_53;
                this.__p_GqTGLmZD4UZNccHoKUVQK6 = Output_57;
                this.__p_TYkuFvlePJZPMCWkt5PxhC = Output_61;
                this.__pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD = __pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD_64;
                this.__p_Mpis4Phbny0OqyboZ9zVrD = Output_68;
                this.__pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G = __pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G_71;
                this.__p_HLVMDTs3QS9O5ShVLEcnp5 = Output_74;
                this.__p_Db5JHpQ21tWQHb6CXNJdS1 = State_Output_76;
                this.__pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln = __pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln_81;
                this.__p_JvAHJuPj0wBMVmOGXPNkOY = State_Output_87;
                this.__p_QJ3K6yFtP9cPYKVIKSZp2E = State_Output_95;
                this.__p_BXhpwBZEBKILInbiPQGSYi = Output_102;
                this.__p_JfvdaUKHecgOEoToFJwivV = Output_105;
            }

            return that_106;
        }

        public n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            bool __pad_FxwGVbQwITxL2VFCYi07Ij_0 = __slot_FxwGVbQwITxL2VFCYi07Ij;
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "SmfCQBl952FMO5G53TfZzb", 84727U);
            n43._Operations_.Create_H<n4.Object, n38.LiveValueNotification, n4.Tuple<n3.IWidget, bool>>(Node_Context: Node_Context_1, Output_Out: out n42.ForEach<n4.Object, n38.LiveValueNotification, n4.Tuple<n3.IWidget, bool>> Output_2);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "JfvdaUKHecgOEoToFJwivV", 85089U);
            var Output_4 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_3);
            n3.IWidget Item_1_5 = (n3.IWidget)Output_4;
            n41._Operations_.Join<n3.IWidget, bool>(Item_1_In: Item_1_5, Item_2_In: __pad_FxwGVbQwITxL2VFCYi07Ij_0, Output_Out: out n4.Tuple<n3.IWidget, bool> Output_6);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "IAwNPWnZ224QYLMrtLrsoC", 84984U);
            n44._Operations_.Create_H<n4.Tuple<n3.IWidget, bool>>(Node_Context: Node_Context_7, Initial_Result_In: Output_6, Output_Out: out n42.HoldLatest<n4.Tuple<n3.IWidget, bool>> Output_8);
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "KlK9peiCkClQFhyrzMupqI", 85005U);
            var Output_10 = n16.DataBangWidget_R.Create(Node_Context: Node_Context_9);
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Mpis4Phbny0OqyboZ9zVrD", 85023U);
            var Output_12 = n16.Row_R.Create(Node_Context: Node_Context_11);
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "GqTGLmZD4UZNccHoKUVQK6", 85056U);
            var Output_14 = n16.FixedWidthWidget_R.Create(Node_Context: Node_Context_13);
            n1.NodeContext Node_Context_15 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "TYkuFvlePJZPMCWkt5PxhC", 85075U);
            var Output_16 = n16.EmptyWidget_R.Create(Node_Context: Node_Context_15);
            n1.NodeContext Node_Context_17 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "HLVMDTs3QS9O5ShVLEcnp5", 89045U);
            var Output_18 = n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L.Create(Node_Context: Node_Context_17);
            n1.NodeContext Node_Context_19 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Db5JHpQ21tWQHb6CXNJdS1", 89058U);
            var Output_20 = n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k.Create(Node_Context: Node_Context_19);
            n1.NodeContext Node_Context_21 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "BXhpwBZEBKILInbiPQGSYi", 89096U);
            var Output_22 = n16.PanelWidget_R.Create(Node_Context: Node_Context_21);
            n1.NodeContext Node_Context_23 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "QJ3K6yFtP9cPYKVIKSZp2E", 89144U);
            var Output_24 = n28.Stroke_ApdGyamrLDXOTiJpdyhyN9.Create(Node_Context: Node_Context_23);
            n1.NodeContext Node_Context_25 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "JvAHJuPj0wBMVmOGXPNkOY", 89180U);
            var Output_26 = n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC.Create(Node_Context: Node_Context_25);
            n1.NodeContext Node_Context_27 = Node_Context.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "UMgqkdgqXcPLjpNqH4XMrS", 89211U);
            var Output_28 = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.Create(Node_Context: Node_Context_27);
            n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 that_29 = this;
            this.__pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__p_SmfCQBl952FMO5G53TfZzb = Output_2;
            this.__p_JfvdaUKHecgOEoToFJwivV = Output_4;
            this.__p_IAwNPWnZ224QYLMrtLrsoC = Output_8;
            this.__p_KlK9peiCkClQFhyrzMupqI = Output_10;
            this.__p_Mpis4Phbny0OqyboZ9zVrD = Output_12;
            this.__p_GqTGLmZD4UZNccHoKUVQK6 = Output_14;
            this.__p_TYkuFvlePJZPMCWkt5PxhC = Output_16;
            this.__p_HLVMDTs3QS9O5ShVLEcnp5 = Output_18;
            this.__p_Db5JHpQ21tWQHb6CXNJdS1 = Output_20;
            this.__p_BXhpwBZEBKILInbiPQGSYi = Output_22;
            this.__p_QJ3K6yFtP9cPYKVIKSZp2E = Output_24;
            this.__p_JvAHJuPj0wBMVmOGXPNkOY = Output_26;
            this.__p_UMgqkdgqXcPLjpNqH4XMrS = Output_28;
            return that_29;
        }

        public n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 __CreateDefault__()
        {
            n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 that_0 = this;
            this.__pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln = n13._Operations_.CreateDefault<n3.IWidget>();
            this.__p_SmfCQBl952FMO5G53TfZzb = default(n42.ForEach<n4.Object, n38.LiveValueNotification, n4.Tuple<n3.IWidget, bool>>);
            this.__p_IAwNPWnZ224QYLMrtLrsoC = default(n42.HoldLatest<n4.Tuple<n3.IWidget, bool>>);
            this.__p_UMgqkdgqXcPLjpNqH4XMrS = n20.TooltipPaint_TImA22camxgQXeGF6KlL9E.CreateDefault();
            this.__p_KlK9peiCkClQFhyrzMupqI = n16.DataBangWidget_R.CreateDefault();
            this.__p_GqTGLmZD4UZNccHoKUVQK6 = n16.FixedWidthWidget_R.CreateDefault();
            this.__p_TYkuFvlePJZPMCWkt5PxhC = n16.EmptyWidget_R.CreateDefault();
            this.__p_Mpis4Phbny0OqyboZ9zVrD = n16.Row_R.CreateDefault();
            this.__p_HLVMDTs3QS9O5ShVLEcnp5 = n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L.CreateDefault();
            this.__p_Db5JHpQ21tWQHb6CXNJdS1 = n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k.CreateDefault();
            this.__p_JvAHJuPj0wBMVmOGXPNkOY = n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC.CreateDefault();
            this.__p_QJ3K6yFtP9cPYKVIKSZp2E = n28.Stroke_ApdGyamrLDXOTiJpdyhyN9.CreateDefault();
            this.__p_BXhpwBZEBKILInbiPQGSYi = n16.PanelWidget_R.CreateDefault();
            this.__p_JfvdaUKHecgOEoToFJwivV = n16.EmptyWidget_R.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SmfCQBl952FMO5G53TfZzb);
            n1.CompilationHelper.SafeDispose(this.__p_IAwNPWnZ224QYLMrtLrsoC);
            n1.CompilationHelper.SafeDispose(this.__p_UMgqkdgqXcPLjpNqH4XMrS);
            n1.CompilationHelper.SafeDispose(this.__p_KlK9peiCkClQFhyrzMupqI);
            n1.CompilationHelper.SafeDispose(this.__p_GqTGLmZD4UZNccHoKUVQK6);
            n1.CompilationHelper.SafeDispose(this.__p_TYkuFvlePJZPMCWkt5PxhC);
            n1.CompilationHelper.SafeDispose(this.__p_Mpis4Phbny0OqyboZ9zVrD);
            n1.CompilationHelper.SafeDispose(this.__p_HLVMDTs3QS9O5ShVLEcnp5);
            n1.CompilationHelper.SafeDispose(this.__p_Db5JHpQ21tWQHb6CXNJdS1);
            n1.CompilationHelper.SafeDispose(this.__p_JvAHJuPj0wBMVmOGXPNkOY);
            n1.CompilationHelper.SafeDispose(this.__p_QJ3K6yFtP9cPYKVIKSZp2E);
            n1.CompilationHelper.SafeDispose(this.__p_BXhpwBZEBKILInbiPQGSYi);
            n1.CompilationHelper.SafeDispose(this.__p_JfvdaUKHecgOEoToFJwivV);
            return;
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 89039U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "FxwGVbQwITxL2VFCYi07Ij", Name = "__slot_FxwGVbQwITxL2VFCYi07Ij")]
        public static bool __slot_FxwGVbQwITxL2VFCYi07Ij = false;
        [n1.ElementAttribute(TracingId = 84727U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "SmfCQBl952FMO5G53TfZzb", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n42.ForEach<n4.Object, n38.LiveValueNotification, n4.Tuple<n3.IWidget, bool>> __p_SmfCQBl952FMO5G53TfZzb;
        [n1.ElementAttribute(TracingId = 84984U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "IAwNPWnZ224QYLMrtLrsoC", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n42.HoldLatest<n4.Tuple<n3.IWidget, bool>> __p_IAwNPWnZ224QYLMrtLrsoC;
        [n1.ElementAttribute(TracingId = 89211U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "UMgqkdgqXcPLjpNqH4XMrS", Name = "TooltipPaint", IsManaged = true, IsAutoGenerated = true)]
        public n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_UMgqkdgqXcPLjpNqH4XMrS;
        [n1.ElementAttribute(TracingId = 85005U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "KlK9peiCkClQFhyrzMupqI", Name = "DataBangWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.DataBangWidget_R __p_KlK9peiCkClQFhyrzMupqI;
        [n1.ElementAttribute(TracingId = 85056U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "GqTGLmZD4UZNccHoKUVQK6", Name = "FixedWidthWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.FixedWidthWidget_R __p_GqTGLmZD4UZNccHoKUVQK6;
        [n1.ElementAttribute(TracingId = 85075U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "TYkuFvlePJZPMCWkt5PxhC", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.EmptyWidget_R __p_TYkuFvlePJZPMCWkt5PxhC;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_OfegTunUyCyMe90WwITzpt = n1.CompilationHelper.Deserialize<n11.Vector2>("0.05, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "OfegTunUyCyMe90WwITzpt");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n3.IWidget> __pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD = default(n12.Spread<n3.IWidget>);
        [n1.ElementAttribute(TracingId = 85023U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Mpis4Phbny0OqyboZ9zVrD", Name = "Row", IsManaged = true, IsAutoGenerated = true)]
        public n16.Row_R __p_Mpis4Phbny0OqyboZ9zVrD;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n3.IWidget> __pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G = default(n12.Spread<n3.IWidget>);
        [n1.ElementAttribute(TracingId = 89045U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "HLVMDTs3QS9O5ShVLEcnp5", Name = "AddInstanceInspectionInfosQuestionmark", IsManaged = true, IsAutoGenerated = true)]
        public n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L __p_HLVMDTs3QS9O5ShVLEcnp5;
        [n1.ElementAttribute(TracingId = 89058U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Db5JHpQ21tWQHb6CXNJdS1", Name = "AddInstanceInspectionInfos", IsManaged = true, IsAutoGenerated = true)]
        public n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k __p_Db5JHpQ21tWQHb6CXNJdS1;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n3.IWidget> __pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln = default(n12.Spread<n3.IWidget>);
        [n1.ElementAttribute(TracingId = 89180U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "JvAHJuPj0wBMVmOGXPNkOY", Name = "Fill", IsManaged = true, IsAutoGenerated = true)]
        public n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_JvAHJuPj0wBMVmOGXPNkOY;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Color4 __c_Scqo2a3zvrMLXJGOiOlMck = n1.CompilationHelper.Deserialize<n11.Color4>("0, 0, 0, 0", false, "QsvwBVssT9xLO3Td5ph2Z9", "Scqo2a3zvrMLXJGOiOlMck");
        [n1.ElementAttribute(TracingId = 89144U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "QJ3K6yFtP9cPYKVIKSZp2E", Name = "Stroke", IsManaged = true, IsAutoGenerated = true)]
        public n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_QJ3K6yFtP9cPYKVIKSZp2E;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Color4 __c_O6n79G2AlR5OqzM5rB7cBz = n1.CompilationHelper.Deserialize<n11.Color4>("0, 0, 0, 0.21", false, "QsvwBVssT9xLO3Td5ph2Z9", "O6n79G2AlR5OqzM5rB7cBz");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n25.SKStrokeJoin __c_QTuGyprueJCQNQO3vLssuW = n1.CompilationHelper.Deserialize<n25.SKStrokeJoin>("Miter", false, "QsvwBVssT9xLO3Td5ph2Z9", "QTuGyprueJCQNQO3vLssuW");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n25.SKStrokeCap __c_CxBNvbAyLoUMmWS0SH4zoG = n1.CompilationHelper.Deserialize<n25.SKStrokeCap>("Butt", false, "QsvwBVssT9xLO3Td5ph2Z9", "CxBNvbAyLoUMmWS0SH4zoG");
        [n1.ElementAttribute(TracingId = 89096U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "BXhpwBZEBKILInbiPQGSYi", Name = "PanelWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.PanelWidget_R __p_BXhpwBZEBKILInbiPQGSYi;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n11.Vector2 __c_Phej9AD3nvZPHW2kZoOY2f = n1.CompilationHelper.Deserialize<n11.Vector2>("0, 0.02", false, "QsvwBVssT9xLO3Td5ph2Z9", "Phej9AD3nvZPHW2kZoOY2f");
        [n1.ElementAttribute(TracingId = 85089U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "JfvdaUKHecgOEoToFJwivV", Name = "EmptyWidget", IsManaged = true, IsAutoGenerated = true)]
        public n16.EmptyWidget_R __p_JfvdaUKHecgOEoToFJwivV;
        static AddLiveValue_PKvKxZVF3NCPTGg78sBLx1()
        {
        }

        public AddLiveValue_PKvKxZVF3NCPTGg78sBLx1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AddLiveValue_PKvKxZVF3NCPTGg78sBLx1(AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 other): base(other)
        {
            this.__p_SmfCQBl952FMO5G53TfZzb = other.__p_SmfCQBl952FMO5G53TfZzb;
            this.__p_IAwNPWnZ224QYLMrtLrsoC = other.__p_IAwNPWnZ224QYLMrtLrsoC;
            this.__p_UMgqkdgqXcPLjpNqH4XMrS = other.__p_UMgqkdgqXcPLjpNqH4XMrS;
            this.__p_KlK9peiCkClQFhyrzMupqI = other.__p_KlK9peiCkClQFhyrzMupqI;
            this.__p_GqTGLmZD4UZNccHoKUVQK6 = other.__p_GqTGLmZD4UZNccHoKUVQK6;
            this.__p_TYkuFvlePJZPMCWkt5PxhC = other.__p_TYkuFvlePJZPMCWkt5PxhC;
            this.__pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD = other.__pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD;
            this.__p_Mpis4Phbny0OqyboZ9zVrD = other.__p_Mpis4Phbny0OqyboZ9zVrD;
            this.__pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G = other.__pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G;
            this.__p_HLVMDTs3QS9O5ShVLEcnp5 = other.__p_HLVMDTs3QS9O5ShVLEcnp5;
            this.__p_Db5JHpQ21tWQHb6CXNJdS1 = other.__p_Db5JHpQ21tWQHb6CXNJdS1;
            this.__pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln = other.__pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln;
            this.__p_JvAHJuPj0wBMVmOGXPNkOY = other.__p_JvAHJuPj0wBMVmOGXPNkOY;
            this.__p_QJ3K6yFtP9cPYKVIKSZp2E = other.__p_QJ3K6yFtP9cPYKVIKSZp2E;
            this.__p_BXhpwBZEBKILInbiPQGSYi = other.__p_BXhpwBZEBKILInbiPQGSYi;
            this.__p_JfvdaUKHecgOEoToFJwivV = other.__p_JfvdaUKHecgOEoToFJwivV;
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_SmfCQBl952FMO5G53TfZzb", in __p_SmfCQBl952FMO5G53TfZzb), n1.CompilationHelper.GetValueOrExisting(values, "__p_IAwNPWnZ224QYLMrtLrsoC", in __p_IAwNPWnZ224QYLMrtLrsoC), n1.CompilationHelper.GetValueOrExisting(values, "__p_UMgqkdgqXcPLjpNqH4XMrS", in __p_UMgqkdgqXcPLjpNqH4XMrS), n1.CompilationHelper.GetValueOrExisting(values, "__p_KlK9peiCkClQFhyrzMupqI", in __p_KlK9peiCkClQFhyrzMupqI), n1.CompilationHelper.GetValueOrExisting(values, "__p_GqTGLmZD4UZNccHoKUVQK6", in __p_GqTGLmZD4UZNccHoKUVQK6), n1.CompilationHelper.GetValueOrExisting(values, "__p_TYkuFvlePJZPMCWkt5PxhC", in __p_TYkuFvlePJZPMCWkt5PxhC), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD", in __pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD), n1.CompilationHelper.GetValueOrExisting(values, "__p_Mpis4Phbny0OqyboZ9zVrD", in __p_Mpis4Phbny0OqyboZ9zVrD), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G", in __pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G), n1.CompilationHelper.GetValueOrExisting(values, "__p_HLVMDTs3QS9O5ShVLEcnp5", in __p_HLVMDTs3QS9O5ShVLEcnp5), n1.CompilationHelper.GetValueOrExisting(values, "__p_Db5JHpQ21tWQHb6CXNJdS1", in __p_Db5JHpQ21tWQHb6CXNJdS1), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln", in __pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln), n1.CompilationHelper.GetValueOrExisting(values, "__p_JvAHJuPj0wBMVmOGXPNkOY", in __p_JvAHJuPj0wBMVmOGXPNkOY), n1.CompilationHelper.GetValueOrExisting(values, "__p_QJ3K6yFtP9cPYKVIKSZp2E", in __p_QJ3K6yFtP9cPYKVIKSZp2E), n1.CompilationHelper.GetValueOrExisting(values, "__p_BXhpwBZEBKILInbiPQGSYi", in __p_BXhpwBZEBKILInbiPQGSYi), n1.CompilationHelper.GetValueOrExisting(values, "__p_JfvdaUKHecgOEoToFJwivV", in __p_JfvdaUKHecgOEoToFJwivV));
        }

        internal AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 __WITH__(n42.ForEach<n4.Object, n38.LiveValueNotification, n4.Tuple<n3.IWidget, bool>> __p_SmfCQBl952FMO5G53TfZzb, n42.HoldLatest<n4.Tuple<n3.IWidget, bool>> __p_IAwNPWnZ224QYLMrtLrsoC, n20.TooltipPaint_TImA22camxgQXeGF6KlL9E __p_UMgqkdgqXcPLjpNqH4XMrS, n16.DataBangWidget_R __p_KlK9peiCkClQFhyrzMupqI, n16.FixedWidthWidget_R __p_GqTGLmZD4UZNccHoKUVQK6, n16.EmptyWidget_R __p_TYkuFvlePJZPMCWkt5PxhC, n12.Spread<n3.IWidget> __pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD, n16.Row_R __p_Mpis4Phbny0OqyboZ9zVrD, n12.Spread<n3.IWidget> __pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G, n5.AddInstanceInspectionInfosQuestionmark_L1QOUlCkuZlP8km0QOzx9L __p_HLVMDTs3QS9O5ShVLEcnp5, n5.AddInstanceInspectionInfos_K0Fe7XojpBfMMlqWacmr3k __p_Db5JHpQ21tWQHb6CXNJdS1, n12.Spread<n3.IWidget> __pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln, n28.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_JvAHJuPj0wBMVmOGXPNkOY, n28.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_QJ3K6yFtP9cPYKVIKSZp2E, n16.PanelWidget_R __p_BXhpwBZEBKILInbiPQGSYi, n16.EmptyWidget_R __p_JfvdaUKHecgOEoToFJwivV)
        {
            n5.AddLiveValue_PKvKxZVF3NCPTGg78sBLx1 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_SmfCQBl952FMO5G53TfZzb != this.__p_SmfCQBl952FMO5G53TfZzb || __p_IAwNPWnZ224QYLMrtLrsoC != this.__p_IAwNPWnZ224QYLMrtLrsoC || __p_UMgqkdgqXcPLjpNqH4XMrS != this.__p_UMgqkdgqXcPLjpNqH4XMrS || __p_KlK9peiCkClQFhyrzMupqI != this.__p_KlK9peiCkClQFhyrzMupqI || __p_GqTGLmZD4UZNccHoKUVQK6 != this.__p_GqTGLmZD4UZNccHoKUVQK6 || __p_TYkuFvlePJZPMCWkt5PxhC != this.__p_TYkuFvlePJZPMCWkt5PxhC || __pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD != this.__pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD || __p_Mpis4Phbny0OqyboZ9zVrD != this.__p_Mpis4Phbny0OqyboZ9zVrD || __pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G != this.__pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G || __p_HLVMDTs3QS9O5ShVLEcnp5 != this.__p_HLVMDTs3QS9O5ShVLEcnp5 || __p_Db5JHpQ21tWQHb6CXNJdS1 != this.__p_Db5JHpQ21tWQHb6CXNJdS1 || __pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln != this.__pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln || __p_JvAHJuPj0wBMVmOGXPNkOY != this.__p_JvAHJuPj0wBMVmOGXPNkOY || __p_QJ3K6yFtP9cPYKVIKSZp2E != this.__p_QJ3K6yFtP9cPYKVIKSZp2E || __p_BXhpwBZEBKILInbiPQGSYi != this.__p_BXhpwBZEBKILInbiPQGSYi || __p_JfvdaUKHecgOEoToFJwivV != this.__p_JfvdaUKHecgOEoToFJwivV ? new AddLiveValue_PKvKxZVF3NCPTGg78sBLx1(this)
                {__p_SmfCQBl952FMO5G53TfZzb = __p_SmfCQBl952FMO5G53TfZzb, __p_IAwNPWnZ224QYLMrtLrsoC = __p_IAwNPWnZ224QYLMrtLrsoC, __p_UMgqkdgqXcPLjpNqH4XMrS = __p_UMgqkdgqXcPLjpNqH4XMrS, __p_KlK9peiCkClQFhyrzMupqI = __p_KlK9peiCkClQFhyrzMupqI, __p_GqTGLmZD4UZNccHoKUVQK6 = __p_GqTGLmZD4UZNccHoKUVQK6, __p_TYkuFvlePJZPMCWkt5PxhC = __p_TYkuFvlePJZPMCWkt5PxhC, __pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD = __pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD, __p_Mpis4Phbny0OqyboZ9zVrD = __p_Mpis4Phbny0OqyboZ9zVrD, __pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G = __pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G, __p_HLVMDTs3QS9O5ShVLEcnp5 = __p_HLVMDTs3QS9O5ShVLEcnp5, __p_Db5JHpQ21tWQHb6CXNJdS1 = __p_Db5JHpQ21tWQHb6CXNJdS1, __pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln = __pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln, __p_JvAHJuPj0wBMVmOGXPNkOY = __p_JvAHJuPj0wBMVmOGXPNkOY, __p_QJ3K6yFtP9cPYKVIKSZp2E = __p_QJ3K6yFtP9cPYKVIKSZp2E, __p_BXhpwBZEBKILInbiPQGSYi = __p_BXhpwBZEBKILInbiPQGSYi, __p_JfvdaUKHecgOEoToFJwivV = __p_JfvdaUKHecgOEoToFJwivV} : that_0;
            else
            {
                this.__p_SmfCQBl952FMO5G53TfZzb = __p_SmfCQBl952FMO5G53TfZzb;
                this.__p_IAwNPWnZ224QYLMrtLrsoC = __p_IAwNPWnZ224QYLMrtLrsoC;
                this.__p_UMgqkdgqXcPLjpNqH4XMrS = __p_UMgqkdgqXcPLjpNqH4XMrS;
                this.__p_KlK9peiCkClQFhyrzMupqI = __p_KlK9peiCkClQFhyrzMupqI;
                this.__p_GqTGLmZD4UZNccHoKUVQK6 = __p_GqTGLmZD4UZNccHoKUVQK6;
                this.__p_TYkuFvlePJZPMCWkt5PxhC = __p_TYkuFvlePJZPMCWkt5PxhC;
                this.__pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD = __pin_group_Input_In_Rv0v9dkmUTxOM9qRyxgXZD;
                this.__p_Mpis4Phbny0OqyboZ9zVrD = __p_Mpis4Phbny0OqyboZ9zVrD;
                this.__pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G = __pin_group_Input_In_F1fMpXzmAUVNkgFdVyDl2G;
                this.__p_HLVMDTs3QS9O5ShVLEcnp5 = __p_HLVMDTs3QS9O5ShVLEcnp5;
                this.__p_Db5JHpQ21tWQHb6CXNJdS1 = __p_Db5JHpQ21tWQHb6CXNJdS1;
                this.__pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln = __pin_group_Input_In_OegoqgDhj6EQQHr5Xasoln;
                this.__p_JvAHJuPj0wBMVmOGXPNkOY = __p_JvAHJuPj0wBMVmOGXPNkOY;
                this.__p_QJ3K6yFtP9cPYKVIKSZp2E = __p_QJ3K6yFtP9cPYKVIKSZp2E;
                this.__p_BXhpwBZEBKILInbiPQGSYi = __p_BXhpwBZEBKILInbiPQGSYi;
                this.__p_JfvdaUKHecgOEoToFJwivV = __p_JfvdaUKHecgOEoToFJwivV;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "EWGhterieE7QNFjFz9Ivw0", Name = "__EWGhterieE7QNFjFz9Ivw0")]
        [n4.SerializableAttribute]
        public class __EWGhterieE7QNFjFz9Ivw0 : n1.VLObject, n4.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_K9wulf3rF0mNrfnWXrpq6R);
                n1.CompilationHelper.SafeDispose(this.__p_M7riJIuMGBsMYzWwQ84lUo);
                return;
            }

            [n1.ElementAttribute(TracingId = 84815U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "K9wulf3rF0mNrfnWXrpq6R", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
            public n37.Changed_A8JGbead2bxNdnPybiEqVS<n4.Object> __p_K9wulf3rF0mNrfnWXrpq6R;
            [n1.ElementAttribute(TracingId = 84763U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "M7riJIuMGBsMYzWwQ84lUo", Name = "AdaptiveViewer", IsManaged = true, IsAutoGenerated = true)]
            public n31.AdaptiveViewer_C __p_M7riJIuMGBsMYzWwQ84lUo;
            public __EWGhterieE7QNFjFz9Ivw0(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __EWGhterieE7QNFjFz9Ivw0(__EWGhterieE7QNFjFz9Ivw0 other): base(other)
            {
                this.__p_K9wulf3rF0mNrfnWXrpq6R = other.__p_K9wulf3rF0mNrfnWXrpq6R;
                this.__p_M7riJIuMGBsMYzWwQ84lUo = other.__p_M7riJIuMGBsMYzWwQ84lUo;
            }

            protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_K9wulf3rF0mNrfnWXrpq6R", in __p_K9wulf3rF0mNrfnWXrpq6R), n1.CompilationHelper.GetValueOrExisting(values, "__p_M7riJIuMGBsMYzWwQ84lUo", in __p_M7riJIuMGBsMYzWwQ84lUo));
            }

            internal __EWGhterieE7QNFjFz9Ivw0 __WITH__(n37.Changed_A8JGbead2bxNdnPybiEqVS<n4.Object> __p_K9wulf3rF0mNrfnWXrpq6R, n31.AdaptiveViewer_C __p_M7riJIuMGBsMYzWwQ84lUo)
            {
                __EWGhterieE7QNFjFz9Ivw0 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_K9wulf3rF0mNrfnWXrpq6R != this.__p_K9wulf3rF0mNrfnWXrpq6R || __p_M7riJIuMGBsMYzWwQ84lUo != this.__p_M7riJIuMGBsMYzWwQ84lUo ? new __EWGhterieE7QNFjFz9Ivw0(this)
                    {__p_K9wulf3rF0mNrfnWXrpq6R = __p_K9wulf3rF0mNrfnWXrpq6R, __p_M7riJIuMGBsMYzWwQ84lUo = __p_M7riJIuMGBsMYzWwQ84lUo} : that_0;
                else
                {
                    this.__p_K9wulf3rF0mNrfnWXrpq6R = __p_K9wulf3rF0mNrfnWXrpq6R;
                    this.__p_M7riJIuMGBsMYzWwQ84lUo = __p_M7riJIuMGBsMYzWwQ84lUo;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 89435U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "PkJoxKG5lpmQWWA9pK4RmE", Name = "HDE_ElementViewersApplication_PkJoxKG5lpmQWWA9pK4RmE")]
    [n4.SerializableAttribute]
    public class HDE_ElementViewersApplication_PkJoxKG5lpmQWWA9pK4RmE : n1.VLObject, n4.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n5.HDE_ElementViewersApplication_PkJoxKG5lpmQWWA9pK4RmE Create(n1.NodeContext Node_Context)
        {
            var instance = new HDE_ElementViewersApplication_PkJoxKG5lpmQWWA9pK4RmE(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n5.HDE_ElementViewersApplication_PkJoxKG5lpmQWWA9pK4RmE CreateDefault()
        {
            var instance = new HDE_ElementViewersApplication_PkJoxKG5lpmQWWA9pK4RmE(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.HDE_ElementViewersApplication_PkJoxKG5lpmQWWA9pK4RmE Update()
        {
            return this;
        }

        public n5.HDE_ElementViewersApplication_PkJoxKG5lpmQWWA9pK4RmE __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n5.HDE_ElementViewersApplication_PkJoxKG5lpmQWWA9pK4RmE __CreateDefault__()
        {
            return this;
        }

        public void Dispose()
        {
            return;
        }

        void n4.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        public HDE_ElementViewersApplication_PkJoxKG5lpmQWWA9pK4RmE(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HDE_ElementViewersApplication_PkJoxKG5lpmQWWA9pK4RmE(HDE_ElementViewersApplication_PkJoxKG5lpmQWWA9pK4RmE other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n15.IReadOnlyDictionary<string, n4.Object> values)
        {
            return __WITH__();
        }

        internal HDE_ElementViewersApplication_PkJoxKG5lpmQWWA9pK4RmE __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 20363U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void RegisterServices_H(n1.IVLFactory Factory_In)
        {
            var __fallback___0 = n1.ServiceRegistry.Current;
            n4.Func<n5.LiveNodeViewer_C> Create_4 = () =>
            {
                using var __current_1 = __fallback___0.MakeCurrentIfNone();
                n1.NodeContext Node_Context_2 = n1.NodeContext.Default.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "PPRtMdwAqscMyxZOCHAMqu", 48336U);
                var Output_3 = n5.LiveNodeViewer_C.Create(Node_Context: Node_Context_2);
                return Output_3;
            }

            ;
            var Output_5 = n3.ViewerFactoryHelpers.RegisterElementViewer<n2.ILiveNodeApplication>(factory: Factory_In, create: Create_4);
            n4.Func<n5.NodeInfoViewer_C> Create_9 = () =>
            {
                using var __current_6 = __fallback___0.MakeCurrentIfNone();
                n1.NodeContext Node_Context_7 = n1.NodeContext.Default.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "HXPV2pJCxEkNr5wILfiGsv", 48276U);
                var Output_8 = n5.NodeInfoViewer_C.Create(Node_Context: Node_Context_7);
                return Output_8;
            }

            ;
            n31._Operations_.RegisterViewer<n2.INodeInfo>(Input_In: Output_5, Create_In: Create_9, Output_Out: out n1.IVLFactory Output_10);
            n4.Func<n5.LiveDataHubViewer_C> Create_14 = () =>
            {
                using var __current_11 = __fallback___0.MakeCurrentIfNone();
                n1.NodeContext Node_Context_12 = n1.NodeContext.Default.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Hp6P4kcoWBrOGwJ4nZ5Cl5", 48313U);
                var Output_13 = n5.LiveDataHubViewer_C.Create(Node_Context: Node_Context_12);
                return Output_13;
            }

            ;
            var Output_15 = n3.ViewerFactoryHelpers.RegisterElementViewer<n2.ILiveDataHub>(factory: Factory_In, create: Create_14);
            n4.Func<n5.DataHubInfoViewer_C> Create_19 = () =>
            {
                using var __current_16 = __fallback___0.MakeCurrentIfNone();
                n1.NodeContext Node_Context_17 = n1.NodeContext.Default.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "VPgWNu0XMpgPjcERBhxfjN", 48236U);
                var Output_18 = n5.DataHubInfoViewer_C.Create(Node_Context: Node_Context_17);
                return Output_18;
            }

            ;
            n31._Operations_.RegisterViewer<n2.IDataHubInfo>(Input_In: Output_15, Create_In: Create_19, Output_Out: out n1.IVLFactory Output_20);
            n4.Func<n5.LiveLinkViewer_C> Create_24 = () =>
            {
                using var __current_21 = __fallback___0.MakeCurrentIfNone();
                n1.NodeContext Node_Context_22 = n1.NodeContext.Default.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "Lhl7W29BsnWMHYImtYtiwJ", 53500U);
                var Output_23 = n5.LiveLinkViewer_C.Create(Node_Context: Node_Context_22);
                return Output_23;
            }

            ;
            var Output_25 = n3.ViewerFactoryHelpers.RegisterElementViewer<n2.ILiveLink>(factory: Factory_In, create: Create_24);
            n4.Func<n5.LinkInfoViewer_C> Create_29 = () =>
            {
                using var __current_26 = __fallback___0.MakeCurrentIfNone();
                n1.NodeContext Node_Context_27 = n1.NodeContext.Default.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "MiH1YvLrZgmQFPwzHhhU9v", 53477U);
                var Output_28 = n5.LinkInfoViewer_C.Create(Node_Context: Node_Context_27);
                return Output_28;
            }

            ;
            n31._Operations_.RegisterViewer<n2.ILinkInfo>(Input_In: Output_25, Create_In: Create_29, Output_Out: out n1.IVLFactory Output_30);
            n4.Func<n5.TooltipInfoViewer_C> Create_34 = () =>
            {
                using var __current_31 = __fallback___0.MakeCurrentIfNone();
                n1.NodeContext Node_Context_32 = n1.NodeContext.Default.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "V0n4eMjJ7e2LUlFM30qaty", 53548U);
                var Output_33 = n5.TooltipInfoViewer_C.Create(Node_Context: Node_Context_32);
                return Output_33;
            }

            ;
            var Output_35 = n3.ViewerFactoryHelpers.RegisterElementViewer<n46.ITooltipInfo>(factory: Factory_In, create: Create_34);
            n4.Func<n5.TooltipWrapperViewer_C> Create_39 = () =>
            {
                using var __current_36 = __fallback___0.MakeCurrentIfNone();
                n1.NodeContext Node_Context_37 = n1.NodeContext.Default.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "NXvFNg6BqNhQBUgKsHoql0", 53594U);
                var Output_38 = n5.TooltipWrapperViewer_C.Create(Node_Context: Node_Context_37);
                return Output_38;
            }

            ;
            var Output_40 = n3.ViewerFactoryHelpers.RegisterElementViewer<n46.TooltipWrapper>(factory: Output_35, create: Create_39);
            n4.Func<n5.PackageViewer_C> Create_44 = () =>
            {
                using var __current_41 = __fallback___0.MakeCurrentIfNone();
                n1.NodeContext Node_Context_42 = n1.NodeContext.Default.CreateSubContext("QsvwBVssT9xLO3Td5ph2Z9", "PINycdNl2zGPRc3lsIvlNZ", 53631U);
                var Output_43 = n5.PackageViewer_C.Create(Node_Context: Node_Context_42);
                return Output_43;
            }

            ;
            n31._Operations_.RegisterViewer<n58.IPackageMetadata>(Input_In: Output_40, Create_In: Create_44, Output_Out: out n1.IVLFactory Output_45);
            return;
        }
    }
}

namespace _HDE_ElementViewers_.HDE.ElementViewers.NodeInfoViewer
{
    [n1.ElementAttribute(TracingId = 20363U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void EnforceEndDot(string Input_In, out string Output_Out)
        {
            char __pad_Cn32sNOm3qxOy4KqOMgKeN_0 = __slot_Cn32sNOm3qxOy4KqOMgKeN;
            string __pad_KHPJK17krLFPsUJUJb5z5L_1 = __slot_KHPJK17krLFPsUJUJb5z5L;
            n49._Operations_.TrimEnd_Char(Input_In: Input_In, Trim_Char_In: __pad_Cn32sNOm3qxOy4KqOMgKeN_0, Output_Out: out string Output_2);
            var Output_3 = n7.StringExtensions.Plus(input: Output_2, input2: __pad_KHPJK17krLFPsUJUJb5z5L_1);
            Output_Out = Output_3;
            return;
        }

        [n1.ElementAttribute(TracingId = 26080U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "Cn32sNOm3qxOy4KqOMgKeN", Name = "__slot_Cn32sNOm3qxOy4KqOMgKeN")]
        public static char __slot_Cn32sNOm3qxOy4KqOMgKeN = '.';
        [n1.ElementAttribute(TracingId = 26066U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", PersistentId = "KHPJK17krLFPsUJUJb5z5L", Name = "__slot_KHPJK17krLFPsUJUJb5z5L")]
        public static string __slot_KHPJK17krLFPsUJUJb5z5L = ".";
        static _Operations_()
        {
        }
    }
}

namespace _HDE_ElementViewers_.HDE.ElementViewers.LiveNodeViewer
{
    [n1.ElementAttribute(TracingId = 20363U, DocumentId = "QsvwBVssT9xLO3Td5ph2Z9", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void GotCalled(n15.IEnumerable<n38.TimingData> Timings_In, out bool Output_Out)
        {
            int accumulator_1 = 0;
            var i_3 = 0;
            foreach (var item_0 in Timings_In)
            {
                var splicer_2 = item_0;
                var i_local_4 = i_3;
                var Count_5 = splicer_2.Count;
                var Output_6 = Count_5 + accumulator_1;
                accumulator_1 = Output_6;
                i_3++;
            }

            int Input_2_7 = 0;
            var Result_8 = accumulator_1 > Input_2_7;
            Output_Out = Result_8;
            return;
        }
    }
}

namespace _HDE_ElementViewers_
{
    public struct __AdaptiveImplementations__QsvwBVssT9xLO3Td5ph2Z9 : n66.IAdaptiveCreateDefault<n3.IWidget>, n66.IAdaptiveCreateDefault<bool>, n66.IAdaptiveCreateDefault<n2.ILiveNodeApplication>, n67.IAdaptiveOperatorEquals<n1.UniqueId>, n66.IAdaptiveCreateDefault<double>, n67.IAdaptiveOperatorPlus<double>, n66.IAdaptiveCreateDefault<n4.Object>
    {
        public void CreateDefault(out n3.IWidget Output_Out)
        {
            var Widget_0 = n27._Operations_.CreateDefault();
            Output_Out = Widget_0;
            return;
        }

        public void CreateDefault(out bool Output_Out)
        {
            n65._Operations_.CreateDefault_Generic<bool>(Output_Out: out bool Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n2.ILiveNodeApplication Output_Out)
        {
            n65._Operations_.CreateDefault_Generic<n2.ILiveNodeApplication>(Output_Out: out n2.ILiveNodeApplication Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorEquals(n1.UniqueId Input_In, n1.UniqueId Input_2_In, out bool Result_Out)
        {
            var Result_0 = n22.ObjectHelpers.Eq(input: Input_In, input2: Input_2_In);
            Result_Out = Result_0;
            return;
        }

        public void CreateDefault(out double Output_Out)
        {
            n65._Operations_.CreateDefault_Generic<double>(Output_Out: out double Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(double Input_In, double Input_2_In, out double Output_Out)
        {
            var Output_0 = Input_In + Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n4.Object Output_Out)
        {
            var Output_0 = n34._Operations_.CreateDefault();
            Output_Out = Output_0;
            return;
        }
    }
}