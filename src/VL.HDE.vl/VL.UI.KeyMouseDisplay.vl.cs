extern alias e5;
extern alias e69;
extern alias e3;
extern alias e2;
extern alias e1;
extern alias e4;

using n34 = _VL_UI_KeyMouseDisplay_;
using n26 = _CoreLibBasics_.Control.Advanced;
using n50 = e3::VL.Lib.Animation;
using n11 = e2::VL.Lib.Collections;
using n6 = _VL_Skia_.Graphics.Skia;
using n46 = e3::VL.Lib.Primitive.CacheRegion;
using n58 = _CoreLibBasics_.Animation.FrameBased;
using n39 = _CoreLibBasics_.Control;
using n14 = _VL_Skia_.Graphics.Skia.Layers;
using n52 = _CoreLibBasics_.Animation.IClock.Advanced;
using n47 = _CoreLibBasics_.Primitive.IntPtr.Advanced;
using n31 = e3::VL.Lib.Reactive;
using n42 = _CoreLibBasics_._2D;
using n29 = _VL_Reactive_.Reactive.EventPattern.Advanced;
using n18 = _CoreLibBasics_.Primitive.String;
using n57 = _VL_Reactive_.Reactive.EventPattern2.Advanced;
using n56 = _VL_Skia_.Graphics.Skia.Paint;
using n17 = global::System.Collections.Generic;
using n41 = _CoreLibBasics_._2D.Vector2;
using n8 = global::SkiaSharp;
using n62 = _CoreLibBasics_.Math.Adaptive;
using n38 = _VL_Skia_.Graphics.Skia.Layer.Advanced;
using n60 = _VL_Reactive_.Reactive.Observable.Advanced;
using n61 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n23 = _VL_Skia_.Graphics.Skia.Unwrapped.SKImage.Advanced;
using n25 = _VL_Skia_.Graphics.Skia.IO;
using n49 = _CoreLibBasics_.Animation;
using n48 = e5::VL.UI.Core;
using n44 = e3::VL.Lib.Primitive;
using n7 = e3::VL.Lib.Text;
using n19 = e2::VL.Lib.Runtime;
using n15 = _VL_Skia_.Graphics.Skia.Layers.Text;
using n37 = global::System.Windows.Input;
using n16 = _VL_Skia_.Graphics.Skia.Text;
using n10 = e3::VL.Lib.Mathematics;
using n43 = _VL_Reactive_.Reactive.ForEach_Keep;
using n35 = _VL_Animation_.Animation.Functions;
using n1 = e2::VL.Core;
using n2 = global::System;
using n3 = e4::Stride.Core.Mathematics;
using n54 = _VL_Reactive_.Reactive;
using n36 = _CoreLibBasics_.Color.RGBA;
using n51 = _VL_HDE_.HDE;
using n22 = e2::VL.Lib.IO;
using n20 = e3::VL.Lib.Primitive.Object;
using n5 = e2::VL.Core.CompilerServices;
using n40 = _VL_Skia_.Graphics.Skia.Transform;
using n24 = global::System.Windows.Forms;
using n32 = _VL_Reactive_.Reactive.ForEach;
using n4 = _VL_UI_KeyMouseDisplay_.HDE;
using n33 = _VL_Reactive_.Reactive.HoldLatest;
using n53 = e2::VL.Lib.Animation;
using n21 = _VL_Collections_.Collections.Sequence;
using n12 = global::System.Runtime.CompilerServices;
using n55 = _VL_Animation_.Animation;
using n9 = e1::VL.Skia;
using n13 = _VL_Collections_.Collections.Spread;
using n30 = _CoreLibBasics_.Primitive.ValueTuple__2_Items.Advanced;
using n45 = global::System.Drawing;
using n28 = global::System.Reactive;
using n27 = e69::Gma.System.MouseKeyHook;
using n59 = _CoreLibBasics_.Primitive.Advanced;

namespace _VL_UI_KeyMouseDisplay_.HDE
{
    [n1.ElementAttribute(TracingId = 92594U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "NCVcptwtgOkMpka9Cw7AMa", Name = "DrawKey_NCVcptwtgOkMpka9Cw7AMa")]
    [n2.SerializableAttribute]
    public class DrawKey_NCVcptwtgOkMpka9Cw7AMa : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa Create(n1.NodeContext Node_Context)
        {
            var instance = new DrawKey_NCVcptwtgOkMpka9Cw7AMa(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa CreateDefault()
        {
            var instance = new DrawKey_NCVcptwtgOkMpka9Cw7AMa(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa Update(n3.Vector2 Position_In, [n5.SerializedDefaultValueAttribute("A", false)] string Text_In, out n9.ILayer Output_Out, out float Width_Out)
        {
            float __pad_N4m6YqI4x97QOTnuxYZaJw_0 = __slot_N4m6YqI4x97QOTnuxYZaJw;
            float __pad_OW9Mbl4c5PIMjr9DHMhL8h_1 = __slot_OW9Mbl4c5PIMjr9DHMhL8h;
            n3.Vector2 __pad_SdEfTSm7LGeOedHcbaswXY_2 = __slot_SdEfTSm7LGeOedHcbaswXY;
            float Y_3 = 0F;
            var Output_4 = new n3.Vector2(x: __pad_N4m6YqI4x97QOTnuxYZaJw_0, y: Y_3);
            n3.Vector2.Add(left: ref Position_In, right: ref Output_4, result: out n3.Vector2 Output_5);
            n6.SkiaPaint_R Input_6 = n6.SkiaPaint_R.CreateDefault();
            n7.FontList Family_Name_7 = __c_H1NGN7wIMvaQF86YNelq4s;
            n8.SKTypefaceStyle Style_8 = __c_LXEHHDmwHSUP2YeEfWdYFU;
            float Size_9 = 0.3F;
            n3.Color4 Color_10 = __c_AcuRzaqYsXePOVazPChWtN;
            float Line_Height_in_em_11 = 1.5F;
            n8.SKTextAlign Horizontal_Alignment_12 = __c_EM21oJYQvAuQaOjyBgFyqi;
            n9.VerticalTextAlignment Vertical_Alignment_13 = __c_T77ICxQL23TNVIestOuUQW;
            bool Show_Helpers_14 = false;
            var State_Output_16 = this.__p_MGT6Ks37KKiN916DwC2FqK.Update(Input_In: Input_6, Family_Name_In: Family_Name_7, Style_In: Style_8, Size_In: Size_9, Color_In: Color_10, Line_Height_in_em_In: Line_Height_in_em_11, Horizontal_Alignment_In: Horizontal_Alignment_12, Vertical_Alignment_In: Vertical_Alignment_13, Show_Helpers_In: Show_Helpers_14, Output_Out: out n6.SkiaPaint_R Output_15);
            n3.Vector2 Size_17 = __c_QPGe2VCUluqOyc54ypAUSb;
            n10.RectangleAnchor Anchor_18 = __c_RYhSfXfJplgNzSw0G4EvVa;
            bool Enabled_19 = true;
            var State_Output_22 = this.__p_JLwdwPyle6vQcHioxnHtNY.Update(Position_In: Output_5, Size_In: Size_17, Anchor_In: Anchor_18, Text_In: Text_In, Paint_In: Output_15, Enabled_In: Enabled_19, Output_Out: out n9.ILayer Output_20, Baseline_Position_Out: out n11.Spread<n3.Vector2> Baseline_Position_21);
            var State_Output_24 = this.__p_FX0qd93OyDmMT13fYOW5Ti.Update(Input_In: Text_In, Paint_In: Output_15, Output_Out: out float Output_23);
            float Input_2_25 = 2F;
            var Output_26 = __pad_N4m6YqI4x97QOTnuxYZaJw_0 * Input_2_25;
            var Output_27 = Output_23 + Output_26;
            var Output_28 = new n3.Vector2(x: Output_27, y: __pad_OW9Mbl4c5PIMjr9DHMhL8h_1);
            n10.RectangleAnchor Anchor_29 = __c_AJNTvWAy1zmOlL817TwZ76;
            n6.SkiaPaint_R Paint_30 = n6.SkiaPaint_R.CreateDefault();
            bool Enabled_31 = true;
            var State_Output_33 = this.__p_HI3CBvgC5xvMjShOzybD3U.Update(Position_In: Position_In, Size_In: Output_28, Radius_In: __pad_SdEfTSm7LGeOedHcbaswXY_2, Anchor_In: Anchor_29, Paint_In: Paint_30, Enabled_In: Enabled_31, Output_Out: out n9.ILayer Output_32);
            bool Debug_34 = false;
            bool Enabled_35 = true;
            var builder_36 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB, 2);
            builder_36.Add(Output_32);
            builder_36.Add(Output_20);
            var __pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB_37 = builder_36.Commit();
            var State_Output_39 = this.__p_LckNV2r5uwON4kGzTCIMvB.Update(Input_In: __pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB_37, Debug_In: Debug_34, Enabled_In: Enabled_35, Output_Out: out n9.ILayer Output_38);
            Output_Out = Output_38;
            Width_Out = Output_27;
            n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa that_40 = this;
            if (this.__GetContext__().IsImmutable)
                that_40 = State_Output_16 != this.__p_MGT6Ks37KKiN916DwC2FqK || State_Output_22 != this.__p_JLwdwPyle6vQcHioxnHtNY || State_Output_24 != this.__p_FX0qd93OyDmMT13fYOW5Ti || State_Output_33 != this.__p_HI3CBvgC5xvMjShOzybD3U || __pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB_37 != this.__pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB || State_Output_39 != this.__p_LckNV2r5uwON4kGzTCIMvB ? new DrawKey_NCVcptwtgOkMpka9Cw7AMa(this)
                {__p_MGT6Ks37KKiN916DwC2FqK = State_Output_16, __p_JLwdwPyle6vQcHioxnHtNY = State_Output_22, __p_FX0qd93OyDmMT13fYOW5Ti = State_Output_24, __p_HI3CBvgC5xvMjShOzybD3U = State_Output_33, __pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB = __pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB_37, __p_LckNV2r5uwON4kGzTCIMvB = State_Output_39} : that_40;
            else
            {
                this.__p_MGT6Ks37KKiN916DwC2FqK = State_Output_16;
                this.__p_JLwdwPyle6vQcHioxnHtNY = State_Output_22;
                this.__p_FX0qd93OyDmMT13fYOW5Ti = State_Output_24;
                this.__p_HI3CBvgC5xvMjShOzybD3U = State_Output_33;
                this.__pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB = __pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB_37;
                this.__p_LckNV2r5uwON4kGzTCIMvB = State_Output_39;
            }

            return that_40;
        }

        public n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "HI3CBvgC5xvMjShOzybD3U", 92597U);
            var Output_1 = n14.RoundRectangle_ORIzah5ECIFPO6Z983qw5x.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "JLwdwPyle6vQcHioxnHtNY", 93377U);
            var Output_3 = n15.Text_IDhaSC7EQyYLRW7vKwiIIb.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "LckNV2r5uwON4kGzTCIMvB", 93411U);
            var Output_5 = n6.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "MGT6Ks37KKiN916DwC2FqK", 93442U);
            var Output_7 = n16.FontAndParagraph_HsZhLZKEOOGP7Xiftx1SLN.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "FX0qd93OyDmMT13fYOW5Ti", 93480U);
            var Output_9 = n16.MeasureText_OA6giYR4LRuN6IVDw73mbZ.Create(Node_Context: Node_Context_8);
            n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa that_10 = this;
            this.__pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB = n13._Operations_.CreateDefault<n9.ILayer>();
            this.__p_HI3CBvgC5xvMjShOzybD3U = Output_1;
            this.__p_JLwdwPyle6vQcHioxnHtNY = Output_3;
            this.__p_LckNV2r5uwON4kGzTCIMvB = Output_5;
            this.__p_MGT6Ks37KKiN916DwC2FqK = Output_7;
            this.__p_FX0qd93OyDmMT13fYOW5Ti = Output_9;
            return that_10;
        }

        public n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa __CreateDefault__()
        {
            n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa that_0 = this;
            this.__pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB = n13._Operations_.CreateDefault<n9.ILayer>();
            this.__p_MGT6Ks37KKiN916DwC2FqK = n16.FontAndParagraph_HsZhLZKEOOGP7Xiftx1SLN.CreateDefault();
            this.__p_JLwdwPyle6vQcHioxnHtNY = n15.Text_IDhaSC7EQyYLRW7vKwiIIb.CreateDefault();
            this.__p_FX0qd93OyDmMT13fYOW5Ti = n16.MeasureText_OA6giYR4LRuN6IVDw73mbZ.CreateDefault();
            this.__p_HI3CBvgC5xvMjShOzybD3U = n14.RoundRectangle_ORIzah5ECIFPO6Z983qw5x.CreateDefault();
            this.__p_LckNV2r5uwON4kGzTCIMvB = n6.Group_TKtMtIW1WMIOfh4AlYkjTy.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_MGT6Ks37KKiN916DwC2FqK);
            n1.CompilationHelper.SafeDispose(this.__p_JLwdwPyle6vQcHioxnHtNY);
            n1.CompilationHelper.SafeDispose(this.__p_FX0qd93OyDmMT13fYOW5Ti);
            n1.CompilationHelper.SafeDispose(this.__p_HI3CBvgC5xvMjShOzybD3U);
            n1.CompilationHelper.SafeDispose(this.__p_LckNV2r5uwON4kGzTCIMvB);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 93476U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "SdEfTSm7LGeOedHcbaswXY", Name = "__slot_SdEfTSm7LGeOedHcbaswXY")]
        public static n3.Vector2 __slot_SdEfTSm7LGeOedHcbaswXY = n1.CompilationHelper.Deserialize<n3.Vector2>("0.09999999, 0.09999999", false, "HdxjuanrTAgOVJrlFMdlRO", "SdEfTSm7LGeOedHcbaswXY");
        [n1.ElementAttribute(TracingId = 99489U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "N4m6YqI4x97QOTnuxYZaJw", Name = "__slot_N4m6YqI4x97QOTnuxYZaJw")]
        public static float __slot_N4m6YqI4x97QOTnuxYZaJw = 0.25F;
        [n1.ElementAttribute(TracingId = 99501U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "OW9Mbl4c5PIMjr9DHMhL8h", Name = "__slot_OW9Mbl4c5PIMjr9DHMhL8h")]
        public static float __slot_OW9Mbl4c5PIMjr9DHMhL8h = 0.65F;
        [n1.ElementAttribute(TracingId = 93442U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "MGT6Ks37KKiN916DwC2FqK", Name = "FontAndParagraph", IsManaged = true, IsAutoGenerated = true)]
        public n16.FontAndParagraph_HsZhLZKEOOGP7Xiftx1SLN __p_MGT6Ks37KKiN916DwC2FqK;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.FontList __c_H1NGN7wIMvaQF86YNelq4s = n1.CompilationHelper.Deserialize<n7.FontList>("Segoe UI Symbol", false, "HdxjuanrTAgOVJrlFMdlRO", "H1NGN7wIMvaQF86YNelq4s");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.SKTypefaceStyle __c_LXEHHDmwHSUP2YeEfWdYFU = n1.CompilationHelper.Deserialize<n8.SKTypefaceStyle>("Bold", false, "HdxjuanrTAgOVJrlFMdlRO", "LXEHHDmwHSUP2YeEfWdYFU");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.Color4 __c_AcuRzaqYsXePOVazPChWtN = n1.CompilationHelper.Deserialize<n3.Color4>("0, 0, 0, 1", false, "HdxjuanrTAgOVJrlFMdlRO", "AcuRzaqYsXePOVazPChWtN");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.SKTextAlign __c_EM21oJYQvAuQaOjyBgFyqi = n1.CompilationHelper.Deserialize<n8.SKTextAlign>("Left", false, "HdxjuanrTAgOVJrlFMdlRO", "EM21oJYQvAuQaOjyBgFyqi");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n9.VerticalTextAlignment __c_T77ICxQL23TNVIestOuUQW = n1.CompilationHelper.Deserialize<n9.VerticalTextAlignment>("Center", false, "HdxjuanrTAgOVJrlFMdlRO", "T77ICxQL23TNVIestOuUQW");
        [n1.ElementAttribute(TracingId = 93377U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "JLwdwPyle6vQcHioxnHtNY", Name = "Text", IsManaged = true, IsAutoGenerated = true)]
        public n15.Text_IDhaSC7EQyYLRW7vKwiIIb __p_JLwdwPyle6vQcHioxnHtNY;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.Vector2 __c_QPGe2VCUluqOyc54ypAUSb = n1.CompilationHelper.Deserialize<n3.Vector2>("0, 1", false, "HdxjuanrTAgOVJrlFMdlRO", "QPGe2VCUluqOyc54ypAUSb");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n10.RectangleAnchor __c_RYhSfXfJplgNzSw0G4EvVa = n1.CompilationHelper.Deserialize<n10.RectangleAnchor>("MiddleLeft", false, "HdxjuanrTAgOVJrlFMdlRO", "RYhSfXfJplgNzSw0G4EvVa");
        [n1.ElementAttribute(TracingId = 93480U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "FX0qd93OyDmMT13fYOW5Ti", Name = "MeasureText", IsManaged = true, IsAutoGenerated = true)]
        public n16.MeasureText_OA6giYR4LRuN6IVDw73mbZ __p_FX0qd93OyDmMT13fYOW5Ti;
        [n1.ElementAttribute(TracingId = 92597U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "HI3CBvgC5xvMjShOzybD3U", Name = "RoundRectangle", IsManaged = true, IsAutoGenerated = true)]
        public n14.RoundRectangle_ORIzah5ECIFPO6Z983qw5x __p_HI3CBvgC5xvMjShOzybD3U;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n10.RectangleAnchor __c_AJNTvWAy1zmOlL817TwZ76 = n1.CompilationHelper.Deserialize<n10.RectangleAnchor>("MiddleLeft", false, "HdxjuanrTAgOVJrlFMdlRO", "AJNTvWAy1zmOlL817TwZ76");
        [n1.ElementAttribute(TracingId = 93411U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "LckNV2r5uwON4kGzTCIMvB", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n6.Group_TKtMtIW1WMIOfh4AlYkjTy __p_LckNV2r5uwON4kGzTCIMvB;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n11.Spread<n9.ILayer> __pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB = default(n11.Spread<n9.ILayer>);
        static DrawKey_NCVcptwtgOkMpka9Cw7AMa()
        {
        }

        public DrawKey_NCVcptwtgOkMpka9Cw7AMa(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DrawKey_NCVcptwtgOkMpka9Cw7AMa(DrawKey_NCVcptwtgOkMpka9Cw7AMa other): base(other)
        {
            this.__p_MGT6Ks37KKiN916DwC2FqK = other.__p_MGT6Ks37KKiN916DwC2FqK;
            this.__p_JLwdwPyle6vQcHioxnHtNY = other.__p_JLwdwPyle6vQcHioxnHtNY;
            this.__p_FX0qd93OyDmMT13fYOW5Ti = other.__p_FX0qd93OyDmMT13fYOW5Ti;
            this.__p_HI3CBvgC5xvMjShOzybD3U = other.__p_HI3CBvgC5xvMjShOzybD3U;
            this.__p_LckNV2r5uwON4kGzTCIMvB = other.__p_LckNV2r5uwON4kGzTCIMvB;
            this.__pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB = other.__pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MGT6Ks37KKiN916DwC2FqK", in __p_MGT6Ks37KKiN916DwC2FqK), n1.CompilationHelper.GetValueOrExisting(values, "__p_JLwdwPyle6vQcHioxnHtNY", in __p_JLwdwPyle6vQcHioxnHtNY), n1.CompilationHelper.GetValueOrExisting(values, "__p_FX0qd93OyDmMT13fYOW5Ti", in __p_FX0qd93OyDmMT13fYOW5Ti), n1.CompilationHelper.GetValueOrExisting(values, "__p_HI3CBvgC5xvMjShOzybD3U", in __p_HI3CBvgC5xvMjShOzybD3U), n1.CompilationHelper.GetValueOrExisting(values, "__p_LckNV2r5uwON4kGzTCIMvB", in __p_LckNV2r5uwON4kGzTCIMvB), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB", in __pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB));
        }

        internal DrawKey_NCVcptwtgOkMpka9Cw7AMa __WITH__(n16.FontAndParagraph_HsZhLZKEOOGP7Xiftx1SLN __p_MGT6Ks37KKiN916DwC2FqK, n15.Text_IDhaSC7EQyYLRW7vKwiIIb __p_JLwdwPyle6vQcHioxnHtNY, n16.MeasureText_OA6giYR4LRuN6IVDw73mbZ __p_FX0qd93OyDmMT13fYOW5Ti, n14.RoundRectangle_ORIzah5ECIFPO6Z983qw5x __p_HI3CBvgC5xvMjShOzybD3U, n6.Group_TKtMtIW1WMIOfh4AlYkjTy __p_LckNV2r5uwON4kGzTCIMvB, n11.Spread<n9.ILayer> __pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB)
        {
            n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_MGT6Ks37KKiN916DwC2FqK != this.__p_MGT6Ks37KKiN916DwC2FqK || __p_JLwdwPyle6vQcHioxnHtNY != this.__p_JLwdwPyle6vQcHioxnHtNY || __p_FX0qd93OyDmMT13fYOW5Ti != this.__p_FX0qd93OyDmMT13fYOW5Ti || __p_HI3CBvgC5xvMjShOzybD3U != this.__p_HI3CBvgC5xvMjShOzybD3U || __p_LckNV2r5uwON4kGzTCIMvB != this.__p_LckNV2r5uwON4kGzTCIMvB || __pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB != this.__pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB ? new DrawKey_NCVcptwtgOkMpka9Cw7AMa(this)
                {__p_MGT6Ks37KKiN916DwC2FqK = __p_MGT6Ks37KKiN916DwC2FqK, __p_JLwdwPyle6vQcHioxnHtNY = __p_JLwdwPyle6vQcHioxnHtNY, __p_FX0qd93OyDmMT13fYOW5Ti = __p_FX0qd93OyDmMT13fYOW5Ti, __p_HI3CBvgC5xvMjShOzybD3U = __p_HI3CBvgC5xvMjShOzybD3U, __p_LckNV2r5uwON4kGzTCIMvB = __p_LckNV2r5uwON4kGzTCIMvB, __pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB = __pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB} : that_0;
            else
            {
                this.__p_MGT6Ks37KKiN916DwC2FqK = __p_MGT6Ks37KKiN916DwC2FqK;
                this.__p_JLwdwPyle6vQcHioxnHtNY = __p_JLwdwPyle6vQcHioxnHtNY;
                this.__p_FX0qd93OyDmMT13fYOW5Ti = __p_FX0qd93OyDmMT13fYOW5Ti;
                this.__p_HI3CBvgC5xvMjShOzybD3U = __p_HI3CBvgC5xvMjShOzybD3U;
                this.__p_LckNV2r5uwON4kGzTCIMvB = __p_LckNV2r5uwON4kGzTCIMvB;
                this.__pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB = __pin_group_Input_In_LckNV2r5uwON4kGzTCIMvB;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 99586U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "DONOgIrpGTxOwISujK9hgd", Name = "DrawKeys_DONOgIrpGTxOwISujK9hgd")]
    [n2.SerializableAttribute]
    public class DrawKeys_DONOgIrpGTxOwISujK9hgd : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.DrawKeys_DONOgIrpGTxOwISujK9hgd Create(n1.NodeContext Node_Context)
        {
            var instance = new DrawKeys_DONOgIrpGTxOwISujK9hgd(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.DrawKeys_DONOgIrpGTxOwISujK9hgd CreateDefault()
        {
            var instance = new DrawKeys_DONOgIrpGTxOwISujK9hgd(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.DrawKeys_DONOgIrpGTxOwISujK9hgd Update(string Keys_In, out n9.ILayer Output_Out, out float Width_Out)
        {
            float __pad_UhZRzNafiGBO33hEush8EV_0 = __slot_UhZRzNafiGBO33hEush8EV;
            float __pad_BDWRd7lgyLsNOZbDAJRC8x_1 = __slot_BDWRd7lgyLsNOZbDAJRC8x;
            string Separator_2 = " + ";
            n2.StringSplitOptions Options_3 = __c_DgSf2L0vwEmLhiSfI2V36K;
            n18._Operations_.Split_String(Input_In: Keys_In, Separator_In: Separator_2, Options_In: Options_3, Output_Out: out n11.Spread<string> Output_4);
            float accumulator_6 = __pad_UhZRzNafiGBO33hEush8EV_0;
            var manager_20 = this.__loop_PmwcoKntDm8PXTM16dmMaH ?? new n19.ImmutableLifetimeManager();
            var iterator_21 = manager_20.GetIterator(__GetContext__());
            var builder_22 = n5.CollectionBuilders.GetBuilder(this.__cp_P37qNzJjs6zN0g2rHkklL4, 16);
            n11.Spread<n9.ILayer> output_23;
            try
            {
                var i_8 = 0;
                foreach (var item_5 in n5.CollectionExtensions.AsSpan(Output_4))
                {
                    var splicer_7 = item_5;
                    var i_local_9 = i_8;
                    __H4TmJ6NhehEQVVm1OEy7lC state_10;
                    if (!iterator_21.MoveNext(out state_10))
                    {
                        iterator_21.Add(state_10 = new __H4TmJ6NhehEQVVm1OEy7lC(__GetContext__(), n1.VLObject.NewIdentity()));
                        n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "T25TuK8cK78NVrQFwRsepF", 99600U);
                        var Output_12 = n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa.Create(Node_Context: Node_Context_11);
                        state_10.__p_T25TuK8cK78NVrQFwRsepF = Output_12;
                    }

                    float Y_13 = 0.5F;
                    var Output_14 = new n3.Vector2(x: accumulator_6, y: Y_13);
                    var State_Output_17 = state_10.__p_T25TuK8cK78NVrQFwRsepF.Update(Position_In: Output_14, Text_In: splicer_7, Output_Out: out n9.ILayer Output_15, Width_Out: out float Width_16);
                    var Output_18 = Width_16 + accumulator_6;
                    var Output_19 = Output_18 + __pad_BDWRd7lgyLsNOZbDAJRC8x_1;
                    if (state_10.__GetContext__().IsImmutable)
                        state_10 = State_Output_17 != state_10.__p_T25TuK8cK78NVrQFwRsepF ? new __H4TmJ6NhehEQVVm1OEy7lC(state_10)
                        {__p_T25TuK8cK78NVrQFwRsepF = State_Output_17} : state_10;
                    else
                    {
                        state_10.__p_T25TuK8cK78NVrQFwRsepF = State_Output_17;
                    }

                    iterator_21.Update(state_10);
                    builder_22.Add(Output_15);
                    accumulator_6 = Output_19;
                    i_8++;
                }
            }
            finally
            {
                manager_20 = iterator_21.Commit();
                output_23 = builder_22.Commit();
            }

            n17.IEnumerable<n9.ILayer> Input_24 = (n17.IEnumerable<n9.ILayer>)output_23;
            bool Debug_25 = false;
            bool Enabled_26 = true;
            var State_Output_28 = this.__p_BpUbfRgU3QNOwJnGtHfFSx.Update(Input_In: Input_24, Debug_In: Debug_25, Enabled_In: Enabled_26, Output_Out: out n9.ILayer Output_27);
            var Output_29 = __pad_UhZRzNafiGBO33hEush8EV_0 - __pad_BDWRd7lgyLsNOZbDAJRC8x_1;
            var Output_30 = accumulator_6 + Output_29;
            Output_Out = Output_27;
            Width_Out = Output_30;
            n4.DrawKeys_DONOgIrpGTxOwISujK9hgd that_31 = this;
            if (this.__GetContext__().IsImmutable)
                that_31 = manager_20 != this.__loop_PmwcoKntDm8PXTM16dmMaH || output_23 != this.__cp_P37qNzJjs6zN0g2rHkklL4 || State_Output_28 != this.__p_BpUbfRgU3QNOwJnGtHfFSx ? new DrawKeys_DONOgIrpGTxOwISujK9hgd(this)
                {__loop_PmwcoKntDm8PXTM16dmMaH = manager_20, __cp_P37qNzJjs6zN0g2rHkklL4 = output_23, __p_BpUbfRgU3QNOwJnGtHfFSx = State_Output_28} : that_31;
            else
            {
                this.__loop_PmwcoKntDm8PXTM16dmMaH = manager_20;
                this.__cp_P37qNzJjs6zN0g2rHkklL4 = output_23;
                this.__p_BpUbfRgU3QNOwJnGtHfFSx = State_Output_28;
            }

            return that_31;
        }

        public n4.DrawKeys_DONOgIrpGTxOwISujK9hgd __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "BpUbfRgU3QNOwJnGtHfFSx", 99668U);
            var Output_1 = n6.Group_Spectral_R3dTESX62CMMHp8R1KPp2g.Create(Node_Context: Node_Context_0);
            n4.DrawKeys_DONOgIrpGTxOwISujK9hgd that_2 = this;
            this.__cp_P37qNzJjs6zN0g2rHkklL4 = n13._Operations_.CreateDefault<n9.ILayer>();
            this.__p_BpUbfRgU3QNOwJnGtHfFSx = Output_1;
            this.__loop_PmwcoKntDm8PXTM16dmMaH = default(n19.ImmutableLifetimeManager);
            return that_2;
        }

        public n4.DrawKeys_DONOgIrpGTxOwISujK9hgd __CreateDefault__()
        {
            n4.DrawKeys_DONOgIrpGTxOwISujK9hgd that_0 = this;
            this.__cp_P37qNzJjs6zN0g2rHkklL4 = n13._Operations_.CreateDefault<n9.ILayer>();
            this.__loop_PmwcoKntDm8PXTM16dmMaH = default(n19.ImmutableLifetimeManager);
            this.__p_BpUbfRgU3QNOwJnGtHfFSx = n6.Group_Spectral_R3dTESX62CMMHp8R1KPp2g.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__loop_PmwcoKntDm8PXTM16dmMaH);
            n1.CompilationHelper.SafeDispose(this.__p_BpUbfRgU3QNOwJnGtHfFSx);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 99682U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "UhZRzNafiGBO33hEush8EV", Name = "__slot_UhZRzNafiGBO33hEush8EV")]
        public static float __slot_UhZRzNafiGBO33hEush8EV = 0.16F;
        [n1.ElementAttribute(TracingId = 99690U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "BDWRd7lgyLsNOZbDAJRC8x", Name = "__slot_BDWRd7lgyLsNOZbDAJRC8x")]
        public static float __slot_BDWRd7lgyLsNOZbDAJRC8x = 0.12F;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n2.StringSplitOptions __c_DgSf2L0vwEmLhiSfI2V36K = n1.CompilationHelper.Deserialize<n2.StringSplitOptions>("RemoveEmptyEntries", false, "HdxjuanrTAgOVJrlFMdlRO", "DgSf2L0vwEmLhiSfI2V36K");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n19.ImmutableLifetimeManager __loop_PmwcoKntDm8PXTM16dmMaH;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n11.Spread<n9.ILayer> __cp_P37qNzJjs6zN0g2rHkklL4;
        [n1.ElementAttribute(TracingId = 99668U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "BpUbfRgU3QNOwJnGtHfFSx", Name = "Group (Spectral)", IsManaged = true, IsAutoGenerated = true)]
        public n6.Group_Spectral_R3dTESX62CMMHp8R1KPp2g __p_BpUbfRgU3QNOwJnGtHfFSx;
        static DrawKeys_DONOgIrpGTxOwISujK9hgd()
        {
        }

        public DrawKeys_DONOgIrpGTxOwISujK9hgd(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DrawKeys_DONOgIrpGTxOwISujK9hgd(DrawKeys_DONOgIrpGTxOwISujK9hgd other): base(other)
        {
            this.__loop_PmwcoKntDm8PXTM16dmMaH = other.__loop_PmwcoKntDm8PXTM16dmMaH;
            this.__cp_P37qNzJjs6zN0g2rHkklL4 = other.__cp_P37qNzJjs6zN0g2rHkklL4;
            this.__p_BpUbfRgU3QNOwJnGtHfFSx = other.__p_BpUbfRgU3QNOwJnGtHfFSx;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__loop_PmwcoKntDm8PXTM16dmMaH", in __loop_PmwcoKntDm8PXTM16dmMaH), n1.CompilationHelper.GetValueOrExisting(values, "__cp_P37qNzJjs6zN0g2rHkklL4", in __cp_P37qNzJjs6zN0g2rHkklL4), n1.CompilationHelper.GetValueOrExisting(values, "__p_BpUbfRgU3QNOwJnGtHfFSx", in __p_BpUbfRgU3QNOwJnGtHfFSx));
        }

        internal DrawKeys_DONOgIrpGTxOwISujK9hgd __WITH__(n19.ImmutableLifetimeManager __loop_PmwcoKntDm8PXTM16dmMaH, n11.Spread<n9.ILayer> __cp_P37qNzJjs6zN0g2rHkklL4, n6.Group_Spectral_R3dTESX62CMMHp8R1KPp2g __p_BpUbfRgU3QNOwJnGtHfFSx)
        {
            n4.DrawKeys_DONOgIrpGTxOwISujK9hgd that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __loop_PmwcoKntDm8PXTM16dmMaH != this.__loop_PmwcoKntDm8PXTM16dmMaH || __cp_P37qNzJjs6zN0g2rHkklL4 != this.__cp_P37qNzJjs6zN0g2rHkklL4 || __p_BpUbfRgU3QNOwJnGtHfFSx != this.__p_BpUbfRgU3QNOwJnGtHfFSx ? new DrawKeys_DONOgIrpGTxOwISujK9hgd(this)
                {__loop_PmwcoKntDm8PXTM16dmMaH = __loop_PmwcoKntDm8PXTM16dmMaH, __cp_P37qNzJjs6zN0g2rHkklL4 = __cp_P37qNzJjs6zN0g2rHkklL4, __p_BpUbfRgU3QNOwJnGtHfFSx = __p_BpUbfRgU3QNOwJnGtHfFSx} : that_0;
            else
            {
                this.__loop_PmwcoKntDm8PXTM16dmMaH = __loop_PmwcoKntDm8PXTM16dmMaH;
                this.__cp_P37qNzJjs6zN0g2rHkklL4 = __cp_P37qNzJjs6zN0g2rHkklL4;
                this.__p_BpUbfRgU3QNOwJnGtHfFSx = __p_BpUbfRgU3QNOwJnGtHfFSx;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "H4TmJ6NhehEQVVm1OEy7lC", Name = "__H4TmJ6NhehEQVVm1OEy7lC")]
        [n2.SerializableAttribute]
        public class __H4TmJ6NhehEQVVm1OEy7lC : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_T25TuK8cK78NVrQFwRsepF);
                return;
            }

            [n1.ElementAttribute(TracingId = 99600U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "T25TuK8cK78NVrQFwRsepF", Name = "DrawKey", IsManaged = true, IsAutoGenerated = true)]
            public n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa __p_T25TuK8cK78NVrQFwRsepF;
            public __H4TmJ6NhehEQVVm1OEy7lC(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __H4TmJ6NhehEQVVm1OEy7lC(__H4TmJ6NhehEQVVm1OEy7lC other): base(other)
            {
                this.__p_T25TuK8cK78NVrQFwRsepF = other.__p_T25TuK8cK78NVrQFwRsepF;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_T25TuK8cK78NVrQFwRsepF", in __p_T25TuK8cK78NVrQFwRsepF));
            }

            internal __H4TmJ6NhehEQVVm1OEy7lC __WITH__(n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa __p_T25TuK8cK78NVrQFwRsepF)
            {
                __H4TmJ6NhehEQVVm1OEy7lC that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_T25TuK8cK78NVrQFwRsepF != this.__p_T25TuK8cK78NVrQFwRsepF ? new __H4TmJ6NhehEQVVm1OEy7lC(this)
                    {__p_T25TuK8cK78NVrQFwRsepF = __p_T25TuK8cK78NVrQFwRsepF} : that_0;
                else
                {
                    this.__p_T25TuK8cK78NVrQFwRsepF = __p_T25TuK8cK78NVrQFwRsepF;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 99806U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "P62WKsOuGkIN5sB0M73gdP", Name = "DrawMouse_P62WKsOuGkIN5sB0M73gdP")]
    [n2.SerializableAttribute]
    public class DrawMouse_P62WKsOuGkIN5sB0M73gdP : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP Create(n1.NodeContext Node_Context)
        {
            var instance = new DrawMouse_P62WKsOuGkIN5sB0M73gdP(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP CreateDefault()
        {
            var instance = new DrawMouse_P62WKsOuGkIN5sB0M73gdP(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP Update(n24.MouseButtons Button_In, float X_Offset_In, out n9.ILayer Output_Out, out float Width_Out)
        {
            n11.Spread<string> __pad_V6t9zm7u2TYP97WHsPI5hd_0 = __slot_V6t9zm7u2TYP97WHsPI5hd;
            float __pad_GqIAFrdHBHYPs3p1W9Xg5L_1 = __slot_GqIAFrdHBHYPs3p1W9Xg5L;
            var Result_2 = n20.ObjectHelpers.ToString(input: Button_In);
            var builder_9 = n5.CollectionBuilders.GetBuilder(this.__cp_POfAtFKs0XBN3OjfFH5nDn, 16);
            n11.Spread<int> output_10;
            try
            {
                var i_5 = 0;
                foreach (var item_3 in n5.CollectionExtensions.AsSpan(__pad_V6t9zm7u2TYP97WHsPI5hd_0))
                {
                    var splicer_4 = item_3;
                    var i_local_6 = i_5;
                    var Result_8 = Result_2 == splicer_4;
                    if (Result_8)
                    {
                        builder_9.Add(i_local_6);
                    }

                    i_5++;
                }
            }
            finally
            {
                output_10 = builder_9.Commit();
            }

            int Default_Value_11 = 0;
            n21._Operations_.FirstOrDefault<n11.Spread<int>, int>(Input_In: output_10, Default_Value_In: Default_Value_11, Output_Out: out n11.Spread<int> Output_12, Result_Out: out int Result_13);
            n22.Path Filename_14 = __c_LwVJQAIvxADPEHuSvYLfcX;
            bool Load_15 = false;
            var State_Output_17 = this.__p_Fks9D5o1CVqPLQaNEHqDxU.Update(Filename_In: Filename_14, Load_In: Load_15, Output_Out: out n8.SKImage Output_16);
            n22.Path Filename_18 = __c_HaHXUMN9fDwOflosx4EQtN;
            bool Load_19 = false;
            var State_Output_21 = this.__p_NBjU23Ocy9TOd7UdfbyZdy.Update(Filename_In: Filename_18, Load_In: Load_19, Output_Out: out n8.SKImage Output_20);
            n22.Path Filename_22 = __c_GiLMAPMV6doQOhmFsKs3oW;
            bool Load_23 = false;
            var State_Output_25 = this.__p_NOOVyrPTMZMONSaqCQvByN.Update(Filename_In: Filename_22, Load_In: Load_23, Output_Out: out n8.SKImage Output_24);
            n22.Path Filename_26 = __c_QHmD3dalL1vNFpHb63kbN8;
            bool Load_27 = false;
            var State_Output_29 = this.__p_CuLaq3Z0gAyLXj90EBHLqi.Update(Filename_In: Filename_26, Load_In: Load_27, Output_Out: out n8.SKImage Output_28);
            n22.Path Filename_30 = __c_So4XiZOLI89NkKAvd8WRoa;
            bool Load_31 = false;
            var State_Output_33 = this.__p_Eq1GL77xMzwLCtgysY815v.Update(Filename_In: Filename_30, Load_In: Load_31, Output_Out: out n8.SKImage Output_32);
            var builder_34 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR, 5);
            builder_34.Add(Output_16);
            builder_34.Add(Output_20);
            builder_34.Add(Output_24);
            builder_34.Add(Output_28);
            builder_34.Add(Output_32);
            var __pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR_35 = builder_34.Commit();
            n13._Operations_.Cons<n8.SKImage>(Input_In: __pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR_35, Result_Out: out n11.Spread<n8.SKImage> Result_36);
            n8.SKImage Default_Value_37 = n23._Operations_.CreateDefault();
            n13._Operations_.GetSlice<n8.SKImage>(Input_In: Result_36, Default_Value_In: Default_Value_37, Index_In: Result_13, Result_Out: out n8.SKImage Result_38);
            var Output_39 = X_Offset_In + __pad_GqIAFrdHBHYPs3p1W9Xg5L_1;
            float Y_40 = 0.5F;
            var Output_41 = new n3.Vector2(x: Output_39, y: Y_40);
            n3.Vector2 Size_42 = __c_BCD51SSnVz4NwatrUgBekF;
            n10.SizeMode Size_Mode_43 = __c_C4TqBmSVj47QMO8H6hg4Zt;
            n10.RectangleAnchor Anchor_44 = __c_JH8Gh7fjIaqQahw1FF3IWG;
            n6.SkiaPaint_R Paint_45 = n6.SkiaPaint_R.CreateDefault();
            bool Enabled_46 = true;
            var State_Output_49 = this.__p_GDNjfixgbcCNSkmsYF6Nhd.Update(Image_In: Result_38, Position_In: Output_41, Size_In: Size_42, Size_Mode_In: Size_Mode_43, Anchor_In: Anchor_44, Paint_In: Paint_45, Enabled_In: Enabled_46, Output_Out: out n9.ILayer Output_47, Actual_Bounds_Out: out n3.RectangleF Actual_Bounds_48);
            var Width_50 = Actual_Bounds_48.Width;
            var Output_51 = Width_50 + __pad_GqIAFrdHBHYPs3p1W9Xg5L_1;
            Output_Out = Output_47;
            Width_Out = Output_51;
            n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP that_52 = this;
            if (this.__GetContext__().IsImmutable)
                that_52 = output_10 != this.__cp_POfAtFKs0XBN3OjfFH5nDn || State_Output_17 != this.__p_Fks9D5o1CVqPLQaNEHqDxU || State_Output_21 != this.__p_NBjU23Ocy9TOd7UdfbyZdy || State_Output_25 != this.__p_NOOVyrPTMZMONSaqCQvByN || State_Output_29 != this.__p_CuLaq3Z0gAyLXj90EBHLqi || State_Output_33 != this.__p_Eq1GL77xMzwLCtgysY815v || __pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR_35 != this.__pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR || State_Output_49 != this.__p_GDNjfixgbcCNSkmsYF6Nhd ? new DrawMouse_P62WKsOuGkIN5sB0M73gdP(this)
                {__cp_POfAtFKs0XBN3OjfFH5nDn = output_10, __p_Fks9D5o1CVqPLQaNEHqDxU = State_Output_17, __p_NBjU23Ocy9TOd7UdfbyZdy = State_Output_21, __p_NOOVyrPTMZMONSaqCQvByN = State_Output_25, __p_CuLaq3Z0gAyLXj90EBHLqi = State_Output_29, __p_Eq1GL77xMzwLCtgysY815v = State_Output_33, __pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR = __pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR_35, __p_GDNjfixgbcCNSkmsYF6Nhd = State_Output_49} : that_52;
            else
            {
                this.__cp_POfAtFKs0XBN3OjfFH5nDn = output_10;
                this.__p_Fks9D5o1CVqPLQaNEHqDxU = State_Output_17;
                this.__p_NBjU23Ocy9TOd7UdfbyZdy = State_Output_21;
                this.__p_NOOVyrPTMZMONSaqCQvByN = State_Output_25;
                this.__p_CuLaq3Z0gAyLXj90EBHLqi = State_Output_29;
                this.__p_Eq1GL77xMzwLCtgysY815v = State_Output_33;
                this.__pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR = __pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR_35;
                this.__p_GDNjfixgbcCNSkmsYF6Nhd = State_Output_49;
            }

            return that_52;
        }

        public n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "GDNjfixgbcCNSkmsYF6Nhd", 99809U);
            var Output_1 = n14.DrawImage_HtRZIc5D5goOJBxUBLUKsQ.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "Fks9D5o1CVqPLQaNEHqDxU", 99831U);
            var Output_3 = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "NBjU23Ocy9TOd7UdfbyZdy", 99898U);
            var Output_5 = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "NOOVyrPTMZMONSaqCQvByN", 99906U);
            var Output_7 = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "CuLaq3Z0gAyLXj90EBHLqi", 101600U);
            var Output_9 = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "Eq1GL77xMzwLCtgysY815v", 101616U);
            var Output_11 = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.Create(Node_Context: Node_Context_10);
            n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP that_12 = this;
            this.__cp_POfAtFKs0XBN3OjfFH5nDn = n13._Operations_.CreateDefault<int>();
            this.__pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR = n13._Operations_.CreateDefault<n8.SKImage>();
            this.__p_GDNjfixgbcCNSkmsYF6Nhd = Output_1;
            this.__p_Fks9D5o1CVqPLQaNEHqDxU = Output_3;
            this.__p_NBjU23Ocy9TOd7UdfbyZdy = Output_5;
            this.__p_NOOVyrPTMZMONSaqCQvByN = Output_7;
            this.__p_CuLaq3Z0gAyLXj90EBHLqi = Output_9;
            this.__p_Eq1GL77xMzwLCtgysY815v = Output_11;
            return that_12;
        }

        public n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP __CreateDefault__()
        {
            n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP that_0 = this;
            this.__cp_POfAtFKs0XBN3OjfFH5nDn = n13._Operations_.CreateDefault<int>();
            this.__pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR = n13._Operations_.CreateDefault<n8.SKImage>();
            this.__p_Fks9D5o1CVqPLQaNEHqDxU = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.CreateDefault();
            this.__p_NBjU23Ocy9TOd7UdfbyZdy = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.CreateDefault();
            this.__p_NOOVyrPTMZMONSaqCQvByN = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.CreateDefault();
            this.__p_CuLaq3Z0gAyLXj90EBHLqi = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.CreateDefault();
            this.__p_Eq1GL77xMzwLCtgysY815v = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.CreateDefault();
            this.__p_GDNjfixgbcCNSkmsYF6Nhd = n14.DrawImage_HtRZIc5D5goOJBxUBLUKsQ.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Fks9D5o1CVqPLQaNEHqDxU);
            n1.CompilationHelper.SafeDispose(this.__p_NBjU23Ocy9TOd7UdfbyZdy);
            n1.CompilationHelper.SafeDispose(this.__p_NOOVyrPTMZMONSaqCQvByN);
            n1.CompilationHelper.SafeDispose(this.__p_CuLaq3Z0gAyLXj90EBHLqi);
            n1.CompilationHelper.SafeDispose(this.__p_Eq1GL77xMzwLCtgysY815v);
            n1.CompilationHelper.SafeDispose(this.__p_GDNjfixgbcCNSkmsYF6Nhd);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 99872U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "GqIAFrdHBHYPs3p1W9Xg5L", Name = "__slot_GqIAFrdHBHYPs3p1W9Xg5L")]
        public static float __slot_GqIAFrdHBHYPs3p1W9Xg5L = 0F;
        [n1.ElementAttribute(TracingId = 99976U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "V6t9zm7u2TYP97WHsPI5hd", Name = "__slot_V6t9zm7u2TYP97WHsPI5hd")]
        public static n11.Spread<string> __slot_V6t9zm7u2TYP97WHsPI5hd = n1.CompilationHelper.Deserialize<n11.Spread<string>>("<Value xmlns=\"property\">\r\n  <Item xmlns=\"\">Left</Item>\r\n  <Item xmlns=\"\">Middle</Item>\r\n  <Item xmlns=\"\">Right</Item>\r\n  <Item xmlns=\"\">XButton1</Item>\r\n  <Item xmlns=\"\">XButton2</Item>\r\n</Value>", true, "HdxjuanrTAgOVJrlFMdlRO", "V6t9zm7u2TYP97WHsPI5hd");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n11.Spread<int> __cp_POfAtFKs0XBN3OjfFH5nDn;
        [n1.ElementAttribute(TracingId = 99831U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "Fks9D5o1CVqPLQaNEHqDxU", Name = "ImageReader", IsManaged = true, IsAutoGenerated = true)]
        public n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_Fks9D5o1CVqPLQaNEHqDxU;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n22.Path __c_LwVJQAIvxADPEHuSvYLfcX = n1.CompilationHelper.Deserialize<n22.Path>("Assets\\KeyMouseDisplay\\left.png", false, "HdxjuanrTAgOVJrlFMdlRO", "LwVJQAIvxADPEHuSvYLfcX");
        [n1.ElementAttribute(TracingId = 99898U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "NBjU23Ocy9TOd7UdfbyZdy", Name = "ImageReader", IsManaged = true, IsAutoGenerated = true)]
        public n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_NBjU23Ocy9TOd7UdfbyZdy;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n22.Path __c_HaHXUMN9fDwOflosx4EQtN = n1.CompilationHelper.Deserialize<n22.Path>("Assets\\KeyMouseDisplay\\middle.png", false, "HdxjuanrTAgOVJrlFMdlRO", "HaHXUMN9fDwOflosx4EQtN");
        [n1.ElementAttribute(TracingId = 99906U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "NOOVyrPTMZMONSaqCQvByN", Name = "ImageReader", IsManaged = true, IsAutoGenerated = true)]
        public n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_NOOVyrPTMZMONSaqCQvByN;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n22.Path __c_GiLMAPMV6doQOhmFsKs3oW = n1.CompilationHelper.Deserialize<n22.Path>("Assets\\KeyMouseDisplay\\right.png", false, "HdxjuanrTAgOVJrlFMdlRO", "GiLMAPMV6doQOhmFsKs3oW");
        [n1.ElementAttribute(TracingId = 101600U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "CuLaq3Z0gAyLXj90EBHLqi", Name = "ImageReader", IsManaged = true, IsAutoGenerated = true)]
        public n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_CuLaq3Z0gAyLXj90EBHLqi;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n22.Path __c_QHmD3dalL1vNFpHb63kbN8 = n1.CompilationHelper.Deserialize<n22.Path>("Assets\\KeyMouseDisplay\\back.png", false, "HdxjuanrTAgOVJrlFMdlRO", "QHmD3dalL1vNFpHb63kbN8");
        [n1.ElementAttribute(TracingId = 101616U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "Eq1GL77xMzwLCtgysY815v", Name = "ImageReader", IsManaged = true, IsAutoGenerated = true)]
        public n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_Eq1GL77xMzwLCtgysY815v;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n22.Path __c_So4XiZOLI89NkKAvd8WRoa = n1.CompilationHelper.Deserialize<n22.Path>("Assets\\KeyMouseDisplay\\forward.png", false, "HdxjuanrTAgOVJrlFMdlRO", "So4XiZOLI89NkKAvd8WRoa");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n11.Spread<n8.SKImage> __pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR = default(n11.Spread<n8.SKImage>);
        [n1.ElementAttribute(TracingId = 99809U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "GDNjfixgbcCNSkmsYF6Nhd", Name = "DrawImage", IsManaged = true, IsAutoGenerated = true)]
        public n14.DrawImage_HtRZIc5D5goOJBxUBLUKsQ __p_GDNjfixgbcCNSkmsYF6Nhd;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.Vector2 __c_BCD51SSnVz4NwatrUgBekF = n1.CompilationHelper.Deserialize<n3.Vector2>("1, 0.8", false, "HdxjuanrTAgOVJrlFMdlRO", "BCD51SSnVz4NwatrUgBekF");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n10.SizeMode __c_C4TqBmSVj47QMO8H6hg4Zt = n1.CompilationHelper.Deserialize<n10.SizeMode>("AutoWidth", false, "HdxjuanrTAgOVJrlFMdlRO", "C4TqBmSVj47QMO8H6hg4Zt");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n10.RectangleAnchor __c_JH8Gh7fjIaqQahw1FF3IWG = n1.CompilationHelper.Deserialize<n10.RectangleAnchor>("MiddleLeft", false, "HdxjuanrTAgOVJrlFMdlRO", "JH8Gh7fjIaqQahw1FF3IWG");
        static DrawMouse_P62WKsOuGkIN5sB0M73gdP()
        {
        }

        public DrawMouse_P62WKsOuGkIN5sB0M73gdP(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DrawMouse_P62WKsOuGkIN5sB0M73gdP(DrawMouse_P62WKsOuGkIN5sB0M73gdP other): base(other)
        {
            this.__cp_POfAtFKs0XBN3OjfFH5nDn = other.__cp_POfAtFKs0XBN3OjfFH5nDn;
            this.__p_Fks9D5o1CVqPLQaNEHqDxU = other.__p_Fks9D5o1CVqPLQaNEHqDxU;
            this.__p_NBjU23Ocy9TOd7UdfbyZdy = other.__p_NBjU23Ocy9TOd7UdfbyZdy;
            this.__p_NOOVyrPTMZMONSaqCQvByN = other.__p_NOOVyrPTMZMONSaqCQvByN;
            this.__p_CuLaq3Z0gAyLXj90EBHLqi = other.__p_CuLaq3Z0gAyLXj90EBHLqi;
            this.__p_Eq1GL77xMzwLCtgysY815v = other.__p_Eq1GL77xMzwLCtgysY815v;
            this.__pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR = other.__pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR;
            this.__p_GDNjfixgbcCNSkmsYF6Nhd = other.__p_GDNjfixgbcCNSkmsYF6Nhd;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_POfAtFKs0XBN3OjfFH5nDn", in __cp_POfAtFKs0XBN3OjfFH5nDn), n1.CompilationHelper.GetValueOrExisting(values, "__p_Fks9D5o1CVqPLQaNEHqDxU", in __p_Fks9D5o1CVqPLQaNEHqDxU), n1.CompilationHelper.GetValueOrExisting(values, "__p_NBjU23Ocy9TOd7UdfbyZdy", in __p_NBjU23Ocy9TOd7UdfbyZdy), n1.CompilationHelper.GetValueOrExisting(values, "__p_NOOVyrPTMZMONSaqCQvByN", in __p_NOOVyrPTMZMONSaqCQvByN), n1.CompilationHelper.GetValueOrExisting(values, "__p_CuLaq3Z0gAyLXj90EBHLqi", in __p_CuLaq3Z0gAyLXj90EBHLqi), n1.CompilationHelper.GetValueOrExisting(values, "__p_Eq1GL77xMzwLCtgysY815v", in __p_Eq1GL77xMzwLCtgysY815v), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR", in __pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR), n1.CompilationHelper.GetValueOrExisting(values, "__p_GDNjfixgbcCNSkmsYF6Nhd", in __p_GDNjfixgbcCNSkmsYF6Nhd));
        }

        internal DrawMouse_P62WKsOuGkIN5sB0M73gdP __WITH__(n11.Spread<int> __cp_POfAtFKs0XBN3OjfFH5nDn, n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_Fks9D5o1CVqPLQaNEHqDxU, n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_NBjU23Ocy9TOd7UdfbyZdy, n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_NOOVyrPTMZMONSaqCQvByN, n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_CuLaq3Z0gAyLXj90EBHLqi, n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_Eq1GL77xMzwLCtgysY815v, n11.Spread<n8.SKImage> __pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR, n14.DrawImage_HtRZIc5D5goOJBxUBLUKsQ __p_GDNjfixgbcCNSkmsYF6Nhd)
        {
            n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cp_POfAtFKs0XBN3OjfFH5nDn != this.__cp_POfAtFKs0XBN3OjfFH5nDn || __p_Fks9D5o1CVqPLQaNEHqDxU != this.__p_Fks9D5o1CVqPLQaNEHqDxU || __p_NBjU23Ocy9TOd7UdfbyZdy != this.__p_NBjU23Ocy9TOd7UdfbyZdy || __p_NOOVyrPTMZMONSaqCQvByN != this.__p_NOOVyrPTMZMONSaqCQvByN || __p_CuLaq3Z0gAyLXj90EBHLqi != this.__p_CuLaq3Z0gAyLXj90EBHLqi || __p_Eq1GL77xMzwLCtgysY815v != this.__p_Eq1GL77xMzwLCtgysY815v || __pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR != this.__pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR || __p_GDNjfixgbcCNSkmsYF6Nhd != this.__p_GDNjfixgbcCNSkmsYF6Nhd ? new DrawMouse_P62WKsOuGkIN5sB0M73gdP(this)
                {__cp_POfAtFKs0XBN3OjfFH5nDn = __cp_POfAtFKs0XBN3OjfFH5nDn, __p_Fks9D5o1CVqPLQaNEHqDxU = __p_Fks9D5o1CVqPLQaNEHqDxU, __p_NBjU23Ocy9TOd7UdfbyZdy = __p_NBjU23Ocy9TOd7UdfbyZdy, __p_NOOVyrPTMZMONSaqCQvByN = __p_NOOVyrPTMZMONSaqCQvByN, __p_CuLaq3Z0gAyLXj90EBHLqi = __p_CuLaq3Z0gAyLXj90EBHLqi, __p_Eq1GL77xMzwLCtgysY815v = __p_Eq1GL77xMzwLCtgysY815v, __pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR = __pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR, __p_GDNjfixgbcCNSkmsYF6Nhd = __p_GDNjfixgbcCNSkmsYF6Nhd} : that_0;
            else
            {
                this.__cp_POfAtFKs0XBN3OjfFH5nDn = __cp_POfAtFKs0XBN3OjfFH5nDn;
                this.__p_Fks9D5o1CVqPLQaNEHqDxU = __p_Fks9D5o1CVqPLQaNEHqDxU;
                this.__p_NBjU23Ocy9TOd7UdfbyZdy = __p_NBjU23Ocy9TOd7UdfbyZdy;
                this.__p_NOOVyrPTMZMONSaqCQvByN = __p_NOOVyrPTMZMONSaqCQvByN;
                this.__p_CuLaq3Z0gAyLXj90EBHLqi = __p_CuLaq3Z0gAyLXj90EBHLqi;
                this.__p_Eq1GL77xMzwLCtgysY815v = __p_Eq1GL77xMzwLCtgysY815v;
                this.__pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR = __pin_group_Input_In_I2xPRk9k3a1QV4SlwGuWiR;
                this.__p_GDNjfixgbcCNSkmsYF6Nhd = __p_GDNjfixgbcCNSkmsYF6Nhd;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 101728U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "BrepNO5Cc7NMY9wQspcYt3", Name = "DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3")]
    [n2.SerializableAttribute]
    public class DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 Create(n1.NodeContext Node_Context)
        {
            var instance = new DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 CreateDefault()
        {
            var instance = new DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 Update(bool Condition_In, float X_Offset_In, out n9.ILayer Output_Out, out float Width_Out)
        {
            float __pad_JyX0FPNkUckMh98eJfcGd2_0 = __slot_JyX0FPNkUckMh98eJfcGd2;
            n22.Path Filename_1 = __c_Trr5IhakJNaLDC4wJpXJwu;
            bool Load_2 = false;
            var State_Output_4 = this.__p_GrFupdLhijEPTHVsMBmuRJ.Update(Filename_In: Filename_1, Load_In: Load_2, Output_Out: out n8.SKImage Output_3);
            n22.Path Filename_5 = __c_KXHCkjrBHQKOv4V3unEwrS;
            bool Load_6 = false;
            var State_Output_8 = this.__p_HUFIXRzdDyyM6N7uuvBZ6D.Update(Filename_In: Filename_5, Load_In: Load_6, Output_Out: out n8.SKImage Output_7);
            n26._Operations_.Switch_Boolean<n8.SKImage>(Condition_In: Condition_In, Input_In: Output_3, Input_2_In: Output_7, Output_Out: out n8.SKImage Output_9);
            var Output_10 = X_Offset_In + __pad_JyX0FPNkUckMh98eJfcGd2_0;
            float Y_11 = 0.5F;
            var Output_12 = new n3.Vector2(x: Output_10, y: Y_11);
            n3.Vector2 Size_13 = __c_OGTrxDRcaunQctL761Rlvk;
            n10.SizeMode Size_Mode_14 = __c_VSGdVBqLvPHMX72Ul9nWzq;
            n10.RectangleAnchor Anchor_15 = __c_EpOjIY0aXINMWrf2kOeE9t;
            n6.SkiaPaint_R Paint_16 = n6.SkiaPaint_R.CreateDefault();
            bool Enabled_17 = true;
            var State_Output_20 = this.__p_PX3EsFZUBIGMot1q6Omgog.Update(Image_In: Output_9, Position_In: Output_12, Size_In: Size_13, Size_Mode_In: Size_Mode_14, Anchor_In: Anchor_15, Paint_In: Paint_16, Enabled_In: Enabled_17, Output_Out: out n9.ILayer Output_18, Actual_Bounds_Out: out n3.RectangleF Actual_Bounds_19);
            var Width_21 = Actual_Bounds_19.Width;
            var Output_22 = Width_21 + __pad_JyX0FPNkUckMh98eJfcGd2_0;
            Output_Out = Output_18;
            Width_Out = Output_22;
            n4.DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = State_Output_4 != this.__p_GrFupdLhijEPTHVsMBmuRJ || State_Output_8 != this.__p_HUFIXRzdDyyM6N7uuvBZ6D || State_Output_20 != this.__p_PX3EsFZUBIGMot1q6Omgog ? new DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3(this)
                {__p_GrFupdLhijEPTHVsMBmuRJ = State_Output_4, __p_HUFIXRzdDyyM6N7uuvBZ6D = State_Output_8, __p_PX3EsFZUBIGMot1q6Omgog = State_Output_20} : that_23;
            else
            {
                this.__p_GrFupdLhijEPTHVsMBmuRJ = State_Output_4;
                this.__p_HUFIXRzdDyyM6N7uuvBZ6D = State_Output_8;
                this.__p_PX3EsFZUBIGMot1q6Omgog = State_Output_20;
            }

            return that_23;
        }

        public n4.DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "PX3EsFZUBIGMot1q6Omgog", 101734U);
            var Output_1 = n14.DrawImage_HtRZIc5D5goOJBxUBLUKsQ.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "GrFupdLhijEPTHVsMBmuRJ", 101765U);
            var Output_3 = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "HUFIXRzdDyyM6N7uuvBZ6D", 101840U);
            var Output_5 = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.Create(Node_Context: Node_Context_4);
            n4.DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 that_6 = this;
            this.__p_PX3EsFZUBIGMot1q6Omgog = Output_1;
            this.__p_GrFupdLhijEPTHVsMBmuRJ = Output_3;
            this.__p_HUFIXRzdDyyM6N7uuvBZ6D = Output_5;
            return that_6;
        }

        public n4.DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 __CreateDefault__()
        {
            n4.DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 that_0 = this;
            this.__p_GrFupdLhijEPTHVsMBmuRJ = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.CreateDefault();
            this.__p_HUFIXRzdDyyM6N7uuvBZ6D = n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1.CreateDefault();
            this.__p_PX3EsFZUBIGMot1q6Omgog = n14.DrawImage_HtRZIc5D5goOJBxUBLUKsQ.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_GrFupdLhijEPTHVsMBmuRJ);
            n1.CompilationHelper.SafeDispose(this.__p_HUFIXRzdDyyM6N7uuvBZ6D);
            n1.CompilationHelper.SafeDispose(this.__p_PX3EsFZUBIGMot1q6Omgog);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 101819U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "JyX0FPNkUckMh98eJfcGd2", Name = "__slot_JyX0FPNkUckMh98eJfcGd2")]
        public static float __slot_JyX0FPNkUckMh98eJfcGd2 = 0.16F;
        [n1.ElementAttribute(TracingId = 101765U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "GrFupdLhijEPTHVsMBmuRJ", Name = "ImageReader", IsManaged = true, IsAutoGenerated = true)]
        public n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_GrFupdLhijEPTHVsMBmuRJ;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n22.Path __c_Trr5IhakJNaLDC4wJpXJwu = n1.CompilationHelper.Deserialize<n22.Path>("Assets\\KeyMouseDisplay\\wheel-down.png", false, "HdxjuanrTAgOVJrlFMdlRO", "Trr5IhakJNaLDC4wJpXJwu");
        [n1.ElementAttribute(TracingId = 101840U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "HUFIXRzdDyyM6N7uuvBZ6D", Name = "ImageReader", IsManaged = true, IsAutoGenerated = true)]
        public n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_HUFIXRzdDyyM6N7uuvBZ6D;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n22.Path __c_KXHCkjrBHQKOv4V3unEwrS = n1.CompilationHelper.Deserialize<n22.Path>("Assets\\KeyMouseDisplay\\wheel-up.png", false, "HdxjuanrTAgOVJrlFMdlRO", "KXHCkjrBHQKOv4V3unEwrS");
        [n1.ElementAttribute(TracingId = 101734U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "PX3EsFZUBIGMot1q6Omgog", Name = "DrawImage", IsManaged = true, IsAutoGenerated = true)]
        public n14.DrawImage_HtRZIc5D5goOJBxUBLUKsQ __p_PX3EsFZUBIGMot1q6Omgog;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.Vector2 __c_OGTrxDRcaunQctL761Rlvk = n1.CompilationHelper.Deserialize<n3.Vector2>("1, 0.8", false, "HdxjuanrTAgOVJrlFMdlRO", "OGTrxDRcaunQctL761Rlvk");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n10.SizeMode __c_VSGdVBqLvPHMX72Ul9nWzq = n1.CompilationHelper.Deserialize<n10.SizeMode>("AutoWidth", false, "HdxjuanrTAgOVJrlFMdlRO", "VSGdVBqLvPHMX72Ul9nWzq");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n10.RectangleAnchor __c_EpOjIY0aXINMWrf2kOeE9t = n1.CompilationHelper.Deserialize<n10.RectangleAnchor>("Center", false, "HdxjuanrTAgOVJrlFMdlRO", "EpOjIY0aXINMWrf2kOeE9t");
        static DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3()
        {
        }

        public DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3(DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 other): base(other)
        {
            this.__p_GrFupdLhijEPTHVsMBmuRJ = other.__p_GrFupdLhijEPTHVsMBmuRJ;
            this.__p_HUFIXRzdDyyM6N7uuvBZ6D = other.__p_HUFIXRzdDyyM6N7uuvBZ6D;
            this.__p_PX3EsFZUBIGMot1q6Omgog = other.__p_PX3EsFZUBIGMot1q6Omgog;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_GrFupdLhijEPTHVsMBmuRJ", in __p_GrFupdLhijEPTHVsMBmuRJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_HUFIXRzdDyyM6N7uuvBZ6D", in __p_HUFIXRzdDyyM6N7uuvBZ6D), n1.CompilationHelper.GetValueOrExisting(values, "__p_PX3EsFZUBIGMot1q6Omgog", in __p_PX3EsFZUBIGMot1q6Omgog));
        }

        internal DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 __WITH__(n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_GrFupdLhijEPTHVsMBmuRJ, n25.ImageReader_UC1s8DxbdtUNPDaHW24IK1 __p_HUFIXRzdDyyM6N7uuvBZ6D, n14.DrawImage_HtRZIc5D5goOJBxUBLUKsQ __p_PX3EsFZUBIGMot1q6Omgog)
        {
            n4.DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_GrFupdLhijEPTHVsMBmuRJ != this.__p_GrFupdLhijEPTHVsMBmuRJ || __p_HUFIXRzdDyyM6N7uuvBZ6D != this.__p_HUFIXRzdDyyM6N7uuvBZ6D || __p_PX3EsFZUBIGMot1q6Omgog != this.__p_PX3EsFZUBIGMot1q6Omgog ? new DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3(this)
                {__p_GrFupdLhijEPTHVsMBmuRJ = __p_GrFupdLhijEPTHVsMBmuRJ, __p_HUFIXRzdDyyM6N7uuvBZ6D = __p_HUFIXRzdDyyM6N7uuvBZ6D, __p_PX3EsFZUBIGMot1q6Omgog = __p_PX3EsFZUBIGMot1q6Omgog} : that_0;
            else
            {
                this.__p_GrFupdLhijEPTHVsMBmuRJ = __p_GrFupdLhijEPTHVsMBmuRJ;
                this.__p_HUFIXRzdDyyM6N7uuvBZ6D = __p_HUFIXRzdDyyM6N7uuvBZ6D;
                this.__p_PX3EsFZUBIGMot1q6Omgog = __p_PX3EsFZUBIGMot1q6Omgog;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 102252U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "UErZtG58Da7NPpgtadFSDC", Name = "KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC")]
    [n2.SerializableAttribute]
    public class KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC Create(n1.NodeContext Node_Context)
        {
            var instance = new KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC CreateDefault()
        {
            var instance = new KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC Update()
        {
            n27.IKeyboardMouseEvents __pad_SlSlmKGg9qIODLUttv8B0r_0 = this.__slot_SlSlmKGg9qIODLUttv8B0r;
            float __pad_KPbqwyhr6YQNgX6BS8ql5L_1 = __slot_KPbqwyhr6YQNgX6BS8ql5L;
            n9.SkiaRenderer __pad_B07EX9PIFedM4JLFEQ6dk6_2 = this.__slot_B07EX9PIFedM4JLFEQ6dk6;
            n27.IMouseEvents Input_3 = (n27.IMouseEvents)__pad_SlSlmKGg9qIODLUttv8B0r_0;
            string Event_Name_4 = "MouseDown";
            var return_5 = n1.EventBridge.FromEventPattern<n24.MouseEventArgs>(target: Input_3, eventName: Event_Name_4);
            bool Reset_6 = false;
            var __fallback___7 = n1.ServiceRegistry.Current;
            n32._Operations_.Update_H<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n3.Vector2, n24.MouseButtons>>(Input_In: this.__p_AQW2dKygsvQNNL39bnlJRj, Messages_In: return_5, Reset_In: Reset_6, Update_In: (n2.Object s_10, n28.EventPattern<n24.MouseEventArgs> Input_1_In_11) =>
            {
                using var __current_8 = __fallback___7.MakeCurrentIfNone();
                var state_9 = n1.CompilationHelper.Restore<__RwpFCWDvt0GOJNACytaIUF>(s_10, __GetContext__());
                n29._Operations_.EventArgs<n2.Object, n24.MouseEventArgs>(Input_In: Input_1_In_11, Event_Args_Out: out n24.MouseEventArgs Event_Args_12);
                var X_13 = Event_Args_12.X;
                var Y_14 = Event_Args_12.Y;
                var Button_15 = Event_Args_12.Button;
                float X_16 = (float)X_13;
                float Y_17 = (float)Y_14;
                var Output_18 = new n3.Vector2(x: X_16, y: Y_17);
                n30._Operations_.ValueTuple_Create<n3.Vector2, n24.MouseButtons>(Item_1_In: Output_18, Item_2_In: Button_15, Output_Out: out n2.ValueTuple<n3.Vector2, n24.MouseButtons> Output_19);
                return n2.Tuple.Create<n2.Object, n2.ValueTuple<n3.Vector2, n24.MouseButtons>>(state_9, Output_19);
            }

            , Create_In: () =>
            {
                using var __current_20 = __fallback___7.MakeCurrentIfNone();
                var state_9 = new __RwpFCWDvt0GOJNACytaIUF(__GetContext__(), n1.VLObject.NewIdentity());
                return state_9;
            }

            , Output_Out: out n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n3.Vector2, n24.MouseButtons>> Output_21, Result_Out: out n2.IObservable<n2.ValueTuple<n3.Vector2, n24.MouseButtons>> Result_22);
            bool Reset_23 = false;
            bool Update_24 = true;
            var Output_25 = this.__p_RDj29p7sIoHOv0tmjhclhR;
            if (Update_24)
            {
                n33._Operations_.Update_H<n2.ValueTuple<n3.Vector2, n24.MouseButtons>>(Input_In: this.__p_RDj29p7sIoHOv0tmjhclhR, Async_Notifications_In: Result_22, Reset_In: Reset_23, Output_Out: out Output_25);
            }

            n33._Operations_.GetData_H<n2.ValueTuple<n3.Vector2, n24.MouseButtons>>(Input_In: Output_25, Output_Out: out n31.HoldLatest<n2.ValueTuple<n3.Vector2, n24.MouseButtons>> Output_26, Value_Out: out n2.ValueTuple<n3.Vector2, n24.MouseButtons> Value_27, On_Data_Out: out bool On_Data_28);
            n30._Operations_.ValueTuple_Split<n3.Vector2, n24.MouseButtons>(Input_In: Value_27, Item_1_Out: out n3.Vector2 Item_1_29, Item_2_Out: out n24.MouseButtons Item_2_30);
            n27.IMouseEvents Input_31 = (n27.IMouseEvents)__pad_SlSlmKGg9qIODLUttv8B0r_0;
            string Event_Name_32 = "MouseMove";
            var return_33 = n1.EventBridge.FromEventPattern<n24.MouseEventArgs>(target: Input_31, eventName: Event_Name_32);
            var Output_34 = this.__p_DnxnjbpngnWPtCxRD42c90;
            if (On_Data_28)
            {
                Output_34 = this.__p_DnxnjbpngnWPtCxRD42c90.Set();
            }

            n27.IMouseEvents Input_35 = (n27.IMouseEvents)__pad_SlSlmKGg9qIODLUttv8B0r_0;
            string Event_Name_36 = "MouseUp";
            var return_37 = n1.EventBridge.FromEventPattern<n24.MouseEventArgs>(target: Input_35, eventName: Event_Name_36);
            bool Reset_38 = false;
            bool Update_39 = true;
            var Output_40 = this.__p_NuQj2EBWvfkOTDYI9PreKS;
            if (Update_39)
            {
                n33._Operations_.Update_H<n28.EventPattern<n24.MouseEventArgs>>(Input_In: this.__p_NuQj2EBWvfkOTDYI9PreKS, Async_Notifications_In: return_37, Reset_In: Reset_38, Output_Out: out Output_40);
            }

            n33._Operations_.GetData_H<n28.EventPattern<n24.MouseEventArgs>>(Input_In: Output_40, Output_Out: out n31.HoldLatest<n28.EventPattern<n24.MouseEventArgs>> Output_41, Value_Out: out n28.EventPattern<n24.MouseEventArgs> Value_42, On_Data_Out: out bool On_Data_43);
            var Output_44 = Output_34;
            if (On_Data_43)
            {
                Output_44 = Output_34.Reset();
            }

            var Output_46 = Output_44.GetState(State_Out: out bool State_45);
            bool Reset_47 = false;
            n32._Operations_.Update_H<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n3.Vector2>(Input_In: this.__p_I0TAHeMNDcUM0a1vVeO5Na, Messages_In: return_33, Reset_In: Reset_47, Update_In: (n2.Object s_50, n28.EventPattern<n24.MouseEventArgs> Input_1_In_51) =>
            {
                using var __current_48 = __fallback___7.MakeCurrentIfNone();
                var state_49 = n1.CompilationHelper.Restore<__S99ZaqXhqarNeLjONRwWdr>(s_50, __GetContext__());
                n29._Operations_.EventArgs<n2.Object, n24.MouseEventArgs>(Input_In: Input_1_In_51, Event_Args_Out: out n24.MouseEventArgs Event_Args_52);
                var X_53 = Event_Args_52.X;
                var Y_54 = Event_Args_52.Y;
                var Button_55 = Event_Args_52.Button;
                float Y_56 = (float)Y_54;
                float X_57 = (float)X_53;
                var Output_58 = new n3.Vector2(x: X_57, y: Y_56);
                return n2.Tuple.Create<n2.Object, n3.Vector2>(state_49, Output_58);
            }

            , Create_In: () =>
            {
                using var __current_59 = __fallback___7.MakeCurrentIfNone();
                var state_49 = new __S99ZaqXhqarNeLjONRwWdr(__GetContext__(), n1.VLObject.NewIdentity());
                return state_49;
            }

            , Output_Out: out n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n3.Vector2> Output_60, Result_Out: out n2.IObservable<n3.Vector2> Result_61);
            bool Reset_62 = false;
            bool Update_63 = true;
            var Output_64 = this.__p_SOFwZ98qYP9MsBGzEhCPag;
            if (Update_63)
            {
                n33._Operations_.Update_H<n3.Vector2>(Input_In: this.__p_SOFwZ98qYP9MsBGzEhCPag, Async_Notifications_In: Result_61, Reset_In: Reset_62, Output_Out: out Output_64);
            }

            n33._Operations_.GetData_H<n3.Vector2>(Input_In: Output_64, Output_Out: out n31.HoldLatest<n3.Vector2> Output_65, Value_Out: out n3.Vector2 Value_66, On_Data_Out: out bool On_Data_67);
            var Output_69 = this.__p_EM5sKFgXyBWORIs9EiAcFU.Update<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Value_In: Value_66, Result_Out: out n3.Vector2 Result_68);
            var Result_70 = n10.Vector2Nodes.Angle(input: ref Result_68);
            var Output_73 = this.__p_VoxRTu6kt38L6dCpqjEQTn.Update(Value_In: Value_66, Result_Out: out bool Result_71, Unchanged_Out: out bool Unchanged_72);
            bool SetValue_74 = true;
            var Output_75 = this.__p_GX1BuZtm1QUPsVdgWGuOr2;
            if (SetValue_74)
            {
                Output_75 = this.__p_GX1BuZtm1QUPsVdgWGuOr2.SetValue(Value_In: Result_70, Sample_In: Result_71);
            }

            var Output_77 = Output_75.GetValue(Value_Out: out float Value_76);
            float Filter_Time_78 = 0.25F;
            bool Cyclic_79 = true;
            bool Jump_80 = false;
            bool Force_New_Func_81 = false;
            var Output_86 = this.__p_OJKkGC54FEoMZYr9RhnnFZ.Update(Goto_Position_In: Value_76, Filter_Time_In: Filter_Time_78, Cyclic_In: Cyclic_79, Jump_In: Jump_80, Force_New_Func_In: Force_New_Func_81, Position_Out: out float Position_82, Velocity_Out: out float Velocity_83, Acceleration_Out: out float Acceleration_84, Function_Out: out n35.OscillatorFunction_C<float> Function_85);
            n6.SkiaPaint_R Input_87 = n6.SkiaPaint_R.CreateDefault();
            n3.Color4 Color_88 = n36._Operations_.CreateDefault();
            float Stroke_Width_89 = 0.07F;
            n8.SKStrokeJoin Join_90 = __c_EFRgRACtCiEPYOF5l8ZmIW;
            n8.SKStrokeCap Cap_91 = __c_AO1ytRuXyuaOfqG6mRxPKG;
            float Miter_92 = 0F;
            var State_Output_94 = this.__p_G1Ygi0PExf1LsZEwApIro9.Update(Input_In: Input_87, Color_In: Color_88, Stroke_Width_In: Stroke_Width_89, Join_In: Join_90, Cap_In: Cap_91, Miter_In: Miter_92, Output_Out: out n6.SkiaPaint_R Output_93);
            var Output_95 = On_Data_67 && State_45;
            var Output_96 = this.__p_BCk78oVnVR2MhwVsV1A5NA;
            if (Output_95)
            {
                Output_96 = this.__p_BCk78oVnVR2MhwVsV1A5NA.Set();
            }

            var Output_97 = Output_96;
            if (On_Data_43)
            {
                Output_97 = Output_96.Reset();
            }

            var Output_99 = Output_97.GetState(State_Out: out bool State_98);
            bool Reset_100 = false;
            n43._Operations_.Update_H<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>>(Input_In: this.__p_VGRRqVB5GveNLDctIS5SJi, Messages_In: return_33, Reset_In: Reset_100, Update_In: (n2.Object s_103, n28.EventPattern<n24.MouseEventArgs> Input_1_In_104) =>
            {
                using var __current_101 = __fallback___7.MakeCurrentIfNone();
                var state_102 = n1.CompilationHelper.Restore<__SbWHLKsj3HTLgVJptxA6Po>(s_103, __GetContext__());
                float __pad_C4fbD5ilQxLK9VpRij25Bt_105 = __slot_C4fbD5ilQxLK9VpRij25Bt;
                string Input_106 = "";
                n4._Operations_.AddModifiers(Input_In: Input_106, Output_Out: out string Output_107);
                var State_Output_110 = state_102.__p_T81cslpP4cqPkoERSEaQxo.Update(Keys_In: Output_107, Output_Out: out n9.ILayer Output_108, Width_Out: out float Width_109);
                n37.Key Key_111 = __c_CgOAZvD5FOFQNxpFLGOVW8;
                var Result_112 = n37.Keyboard.IsKeyDown(key: Key_111);
                int Index_113 = n2.Convert.ToInt32(Result_112);
                n3.Vector2 Position_114 = __c_TMS2htaVUiqNv3m0K1B5h3;
                string Text_115 = "Space";
                var State_Output_118 = state_102.__p_CfipLZzc051LkvpNvivzJC.Update(Position_In: Position_114, Text_In: Text_115, Output_Out: out n9.ILayer Output_116, Width_Out: out float Width_117);
                n9.ILayer Input_119 = n38._Operations_.CreateDefault();
                var builder_120 = n5.CollectionBuilders.GetBuilder(state_102.__pin_group_Input_In_QhdIHN049XlMHqwWfYhEil, 2);
                builder_120.Add(Input_119);
                builder_120.Add(Output_116);
                var __pin_group_Input_In_QhdIHN049XlMHqwWfYhEil_121 = builder_120.Commit();
                n39._Operations_.Switch<n9.ILayer, n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Index_In: Index_113, Input_In: __pin_group_Input_In_QhdIHN049XlMHqwWfYhEil_121, Output_Out: out n9.ILayer Output_122);
                int Index_123 = n2.Convert.ToInt32(Result_112);
                float Input_2_124 = 0.16F;
                var Output_125 = Width_117 + Input_2_124;
                float Input_126 = 0F;
                var builder_127 = n5.CollectionBuilders.GetBuilder(state_102.__pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0, 2);
                builder_127.Add(Input_126);
                builder_127.Add(Output_125);
                var __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0_128 = builder_127.Commit();
                n39._Operations_.Switch<float, n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Index_In: Index_123, Input_In: __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0_128, Output_Out: out float Output_129);
                var Output_130 = Width_109 + Output_129;
                var State_Output_133 = state_102.__p_L8Ubmg86p0fMnzjaRlwTdV.Update(Button_In: Item_2_30, X_Offset_In: Output_130, Output_Out: out n9.ILayer Output_131, Width_Out: out float Width_132);
                bool Debug_134 = false;
                bool Enabled_135 = true;
                var builder_136 = n5.CollectionBuilders.GetBuilder(state_102.__pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws, 3);
                builder_136.Add(Output_108);
                builder_136.Add(Output_122);
                builder_136.Add(Output_131);
                var __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws_137 = builder_136.Commit();
                var State_Output_139 = state_102.__p_Ok8G4Vp67NYLFPn1PyN3ws.Update(Input_In: __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws_137, Debug_In: Debug_134, Enabled_In: Enabled_135, Output_Out: out n9.ILayer Output_138);
                var Output_140 = Output_130 + Width_132;
                var Output_141 = Output_140 + __pad_C4fbD5ilQxLK9VpRij25Bt_105;
                n24.MouseButtons Input_2_142 = __c_ACCuuqiSsPnP5U3HMMB2PL;
                var Result_143 = Item_2_30 != Input_2_142;
                n24.MouseButtons Input_2_144 = __c_ENFfTjsqn3GNNX1SUEG0uD;
                var Result_145 = Item_2_30 != Input_2_144;
                var Output_146 = Result_143 && Result_145;
                float __auto_147;
                n9.ILayer __auto_148;
                var state_149 = n1.CompilationHelper.Restore<__GMBFy5T3Xz5NCqAqLrHW7S>(state_102.__if_C3pLdlv7a8YLrKlremyNwr, __GetContext__());
                if (Output_146)
                {
                    if (state_149 == null)
                    {
                        state_149 = new __GMBFy5T3Xz5NCqAqLrHW7S(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_150 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "NgfWx7xvADdN5XoJrDgymU", 110295U);
                        var Output_151 = n14.Arrow_LkmkJWVjwT1N0iaFX8x0DS.Create(Node_Context: Node_Context_150);
                        state_149.__p_NgfWx7xvADdN5XoJrDgymU = Output_151;
                        n1.NodeContext Node_Context_152 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "LMJLqVqlGN0MIrJnGgpgz5", 110328U);
                        var Output_153 = n40.TransformSRT_Oc7C6Oc4qP6M6mhsHRSy9b.Create(Node_Context: Node_Context_152);
                        state_149.__p_LMJLqVqlGN0MIrJnGgpgz5 = Output_153;
                        n1.NodeContext Node_Context_154 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "DZMkbZHn5jMMcBXPde3kAj", 110381U);
                        n3.Vector2 Initial_Value_155 = n41._Operations_.CreateDefault();
                        var Output_156 = n39.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector2>.Create(Node_Context: Node_Context_154, Initial_Value_In: Initial_Value_155);
                        state_149.__p_DZMkbZHn5jMMcBXPde3kAj = Output_156;
                    }

                    float __pad_KiRAxb4TORmLdkRCqFtfS4_157 = __slot_KiRAxb4TORmLdkRCqFtfS4;
                    float __pad_NBS1UN1PjUxNQc6BRoY33F_158 = __slot_NBS1UN1PjUxNQc6BRoY33F;
                    var Output_159 = Output_141 + __pad_KiRAxb4TORmLdkRCqFtfS4_157;
                    var Output_160 = Output_159 + __pad_NBS1UN1PjUxNQc6BRoY33F_158;
                    __auto_147 = Output_160;
                    float Y_161 = 0.5F;
                    var Output_162 = new n3.Vector2(x: Output_159, y: Y_161);
                    float Radius_163 = 0.3F;
                    n42._Operations_.FromPolar(Angle_In: Position_82, Radius_In: Radius_163, Output_Out: out n3.Vector2 Output_164);
                    bool SetValue_165 = true;
                    var Output_166 = state_149.__p_DZMkbZHn5jMMcBXPde3kAj;
                    if (SetValue_165)
                    {
                        Output_166 = state_149.__p_DZMkbZHn5jMMcBXPde3kAj.SetValue(Value_In: Output_164, Sample_In: State_98);
                    }

                    var Output_168 = Output_166.GetValue(Value_Out: out n3.Vector2 Value_167);
                    n3.Vector2 From_169 = n41._Operations_.CreateDefault();
                    float Tip_Size_170 = 0.12F;
                    float Tip_Widening_171 = 0.09999999F;
                    bool Tail_Enable_172 = false;
                    bool Enabled_173 = true;
                    var State_Output_175 = state_149.__p_NgfWx7xvADdN5XoJrDgymU.Update(From_In: From_169, To_In: Value_167, Tip_Size_In: Tip_Size_170, Tip_Widening_In: Tip_Widening_171, Tail_Enable_In: Tail_Enable_172, Paint_In: Output_93, Enabled_In: Enabled_173, Output_Out: out n14.PathLayer_C Output_174);
                    n9.ILayer Input_176 = (n9.ILayer)Output_174;
                    n3.Vector2 Scaling_177 = __c_TRd8oPVcCbmORS0IKURdmC;
                    float Rotation_178 = 0F;
                    var State_Output_180 = state_149.__p_LMJLqVqlGN0MIrJnGgpgz5.Update(Input_In: Input_176, Scaling_In: Scaling_177, Rotation_In: Rotation_178, Translation_In: Output_162, Output_Out: out n9.ILayer Output_179);
                    __auto_148 = Output_179;
                    if (state_149.__GetContext__().IsImmutable)
                        state_149 = Output_168 != state_149.__p_DZMkbZHn5jMMcBXPde3kAj || State_Output_175 != state_149.__p_NgfWx7xvADdN5XoJrDgymU || State_Output_180 != state_149.__p_LMJLqVqlGN0MIrJnGgpgz5 ? new __GMBFy5T3Xz5NCqAqLrHW7S(state_149)
                        {__p_DZMkbZHn5jMMcBXPde3kAj = Output_168, __p_NgfWx7xvADdN5XoJrDgymU = State_Output_175, __p_LMJLqVqlGN0MIrJnGgpgz5 = State_Output_180} : state_149;
                    else
                    {
                        state_149.__p_DZMkbZHn5jMMcBXPde3kAj = Output_168;
                        state_149.__p_NgfWx7xvADdN5XoJrDgymU = State_Output_175;
                        state_149.__p_LMJLqVqlGN0MIrJnGgpgz5 = State_Output_180;
                    }
                }
                else
                {
                    __auto_147 = Output_141;
                    __auto_148 = n38._Operations_.CreateDefault();
                }

                bool Debug_181 = false;
                bool Enabled_182 = true;
                var builder_183 = n5.CollectionBuilders.GetBuilder(state_102.__pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk, 2);
                builder_183.Add(Output_138);
                builder_183.Add(__auto_148);
                var __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk_184 = builder_183.Commit();
                var State_Output_186 = state_102.__p_Qtj1Viwp36kLNT3WNCFEIk.Update(Input_In: __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk_184, Debug_In: Debug_181, Enabled_In: Enabled_182, Output_Out: out n9.ILayer Output_185);
                n30._Operations_.ValueTuple_Create<n9.ILayer, float>(Item_1_In: Output_185, Item_2_In: __auto_147, Output_Out: out n2.ValueTuple<n9.ILayer, float> Output_187);
                if (state_102.__GetContext__().IsImmutable)
                    state_102 = State_Output_110 != state_102.__p_T81cslpP4cqPkoERSEaQxo || State_Output_118 != state_102.__p_CfipLZzc051LkvpNvivzJC || __pin_group_Input_In_QhdIHN049XlMHqwWfYhEil_121 != state_102.__pin_group_Input_In_QhdIHN049XlMHqwWfYhEil || __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0_128 != state_102.__pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0 || State_Output_133 != state_102.__p_L8Ubmg86p0fMnzjaRlwTdV || __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws_137 != state_102.__pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws || State_Output_139 != state_102.__p_Ok8G4Vp67NYLFPn1PyN3ws || state_149 != state_102.__if_C3pLdlv7a8YLrKlremyNwr || __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk_184 != state_102.__pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk || State_Output_186 != state_102.__p_Qtj1Viwp36kLNT3WNCFEIk ? new __SbWHLKsj3HTLgVJptxA6Po(state_102)
                    {__p_T81cslpP4cqPkoERSEaQxo = State_Output_110, __p_CfipLZzc051LkvpNvivzJC = State_Output_118, __pin_group_Input_In_QhdIHN049XlMHqwWfYhEil = __pin_group_Input_In_QhdIHN049XlMHqwWfYhEil_121, __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0 = __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0_128, __p_L8Ubmg86p0fMnzjaRlwTdV = State_Output_133, __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws = __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws_137, __p_Ok8G4Vp67NYLFPn1PyN3ws = State_Output_139, __if_C3pLdlv7a8YLrKlremyNwr = state_149, __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk = __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk_184, __p_Qtj1Viwp36kLNT3WNCFEIk = State_Output_186} : state_102;
                else
                {
                    state_102.__p_T81cslpP4cqPkoERSEaQxo = State_Output_110;
                    state_102.__p_CfipLZzc051LkvpNvivzJC = State_Output_118;
                    state_102.__pin_group_Input_In_QhdIHN049XlMHqwWfYhEil = __pin_group_Input_In_QhdIHN049XlMHqwWfYhEil_121;
                    state_102.__pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0 = __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0_128;
                    state_102.__p_L8Ubmg86p0fMnzjaRlwTdV = State_Output_133;
                    state_102.__pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws = __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws_137;
                    state_102.__p_Ok8G4Vp67NYLFPn1PyN3ws = State_Output_139;
                    state_102.__if_C3pLdlv7a8YLrKlremyNwr = state_149;
                    state_102.__pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk = __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk_184;
                    state_102.__p_Qtj1Viwp36kLNT3WNCFEIk = State_Output_186;
                }

                return n2.Tuple.Create<n2.Object, n2.ValueTuple<n9.ILayer, float>, bool>(state_102, Output_187, State_45);
            }

            , Create_In: () =>
            {
                using var __current_188 = __fallback___7.MakeCurrentIfNone();
                var state_102 = new __SbWHLKsj3HTLgVJptxA6Po(__GetContext__(), n1.VLObject.NewIdentity())
                {__pin_group_Input_In_QhdIHN049XlMHqwWfYhEil = n13._Operations_.CreateDefault<n9.ILayer>(), __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0 = n13._Operations_.CreateDefault<float>(), __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws = n13._Operations_.CreateDefault<n9.ILayer>(), __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk = n13._Operations_.CreateDefault<n9.ILayer>()};
                n1.NodeContext Node_Context_189 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "T81cslpP4cqPkoERSEaQxo", 110075U);
                var Output_190 = n4.DrawKeys_DONOgIrpGTxOwISujK9hgd.Create(Node_Context: Node_Context_189);
                state_102.__p_T81cslpP4cqPkoERSEaQxo = Output_190;
                n1.NodeContext Node_Context_191 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "L8Ubmg86p0fMnzjaRlwTdV", 110089U);
                var Output_192 = n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP.Create(Node_Context: Node_Context_191);
                state_102.__p_L8Ubmg86p0fMnzjaRlwTdV = Output_192;
                n1.NodeContext Node_Context_193 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "Ok8G4Vp67NYLFPn1PyN3ws", 110098U);
                var Output_194 = n6.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_193);
                state_102.__p_Ok8G4Vp67NYLFPn1PyN3ws = Output_194;
                n1.NodeContext Node_Context_195 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "Qtj1Viwp36kLNT3WNCFEIk", 110113U);
                var Output_196 = n6.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_195);
                state_102.__p_Qtj1Viwp36kLNT3WNCFEIk = Output_196;
                n1.NodeContext Node_Context_197 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "CfipLZzc051LkvpNvivzJC", 110179U);
                var Output_198 = n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa.Create(Node_Context: Node_Context_197);
                state_102.__p_CfipLZzc051LkvpNvivzJC = Output_198;
                return state_102;
            }

            , Output_Out: out n31.ForEachKeep<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> Output_199, Result_Out: out n2.IObservable<n2.ValueTuple<n9.ILayer, float>> Result_200);
            bool __pad_JPB6RP0gC0NN8t89fyqEN1_201 = State_45;
            var Output_202 = this.__p_Ay5Is0ficrTLLUROwrtgII;
            if (On_Data_28)
            {
                Output_202 = this.__p_Ay5Is0ficrTLLUROwrtgII.Set();
            }

            var Output_203 = Output_202;
            if (On_Data_67)
            {
                Output_203 = Output_202.Reset();
            }

            var Output_205 = Output_203.GetState(State_Out: out bool State_204);
            n27.IKeyboardEvents Input_206 = (n27.IKeyboardEvents)__pad_SlSlmKGg9qIODLUttv8B0r_0;
            string Event_Name_207 = "KeyDown";
            var return_208 = n1.EventBridge.FromEventPattern<n24.KeyEventArgs>(target: Input_206, eventName: Event_Name_207);
            bool Reset_209 = false;
            n43._Operations_.Update_H<n2.Object, n28.EventPattern<n24.KeyEventArgs>, n2.ValueTuple<n9.ILayer, float>>(Input_In: this.__p_GrekTHE3gejOt1YdfXKWEv, Messages_In: return_208, Reset_In: Reset_209, Update_In: (n2.Object s_212, n28.EventPattern<n24.KeyEventArgs> Input_1_In_213) =>
            {
                using var __current_210 = __fallback___7.MakeCurrentIfNone();
                var state_211 = n1.CompilationHelper.Restore<__UuUDRmNZsKgPaEZw3U7sBA>(s_212, __GetContext__());
                n11.Spread<n24.Keys> __pad_FWTIzF12D3pP5G57tIP1AL_214 = __slot_FWTIzF12D3pP5G57tIP1AL;
                n11.Spread<n24.Keys> __pad_BEDSGO2FbgnMv6PVEHTYtF_215 = __slot_BEDSGO2FbgnMv6PVEHTYtF;
                n29._Operations_.EventArgs<n2.Object, n24.KeyEventArgs>(Input_In: Input_1_In_213, Event_Args_Out: out n24.KeyEventArgs Event_Args_216);
                var Control_217 = Event_Args_216.Control;
                var Alt_218 = Event_Args_216.Alt;
                var Shift_219 = Event_Args_216.Shift;
                var Key_Value_220 = Event_Args_216.KeyValue;
                var Key_Data_221 = Event_Args_216.KeyData;
                var Key_Code_222 = Event_Args_216.KeyCode;
                n17.IEnumerable<n24.Keys> Input_223 = (n17.IEnumerable<n24.Keys>)__pad_FWTIzF12D3pP5G57tIP1AL_214;
                n21._Operations_.Any_Predicate<n24.Keys>(Input_In: Input_223, Predicate_In: (n24.Keys Arg_In_225) =>
                {
                    using var __current_224 = __fallback___7.MakeCurrentIfNone();
                    var Result_226 = Arg_In_225 == Key_Code_222;
                    return Result_226;
                }

                , Result_Out: out bool Result_227);
                var Output_228 = Control_217 || Alt_218;
                int Input_2_229 = 32;
                var Result_230 = Key_Value_220 >= Input_2_229;
                n17.IEnumerable<n24.Keys> Input_231 = (n17.IEnumerable<n24.Keys>)__pad_BEDSGO2FbgnMv6PVEHTYtF_215;
                n21._Operations_.Any_Predicate<n24.Keys>(Input_In: Input_231, Predicate_In: (n24.Keys Arg_In_233) =>
                {
                    using var __current_232 = __fallback___7.MakeCurrentIfNone();
                    var Result_234 = Arg_In_233 == Key_Code_222;
                    return Result_234;
                }

                , Result_Out: out bool Result_235);
                var Output_236 = !Result_235;
                var Output_237 = Output_228 && Result_230;
                var Output_238 = Output_237 && Output_236;
                var Output_239 = Output_238 || Result_227;
                var Output_240 = !State_45;
                var Output_241 = Output_239 && Output_240;
                n2.ValueTuple<n9.ILayer, float> __auto_242;
                var state_243 = n1.CompilationHelper.Restore<__CuKAY065O80OeRVwaEaw0p>(state_211.__if_GQ6bHKuC6vvMAD2GnvsGX1, __GetContext__());
                if (Output_239)
                {
                    if (state_243 == null)
                    {
                        state_243 = new __CuKAY065O80OeRVwaEaw0p(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_244 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "OpD9q2PWmJINB0Q9awv6Ey", 104855U);
                        var Output_245 = n4.DrawKeys_DONOgIrpGTxOwISujK9hgd.Create(Node_Context: Node_Context_244);
                        state_243.__p_OpD9q2PWmJINB0Q9awv6Ey = Output_245;
                    }

                    var Result_246 = n20.ObjectHelpers.ToString(input: Key_Data_221);
                    string Separator_247 = ", ";
                    n2.StringSplitOptions Options_248 = __c_EtOrts5kZqDOwaL6OHWzyo;
                    n18._Operations_.Split_String(Input_In: Result_246, Separator_In: Separator_247, Options_In: Options_248, Output_Out: out n11.Spread<string> Output_249);
                    n13._Operations_.Reverse<string>(Input_In: Output_249, Output_Out: out n11.Spread<string> Output_250);
                    n17.IEnumerable<string> Values_251 = (n17.IEnumerable<string>)Output_250;
                    string Separator_252 = " + ";
                    var Output_253 = string.Join(separator: Separator_252, values: Values_251);
                    n4._Operations_.ReplaceText(Input_In: Output_253, Output_Out: out string Output_254);
                    var State_Output_257 = state_243.__p_OpD9q2PWmJINB0Q9awv6Ey.Update(Keys_In: Output_254, Output_Out: out n9.ILayer Output_255, Width_Out: out float Width_256);
                    n30._Operations_.ValueTuple_Create<n9.ILayer, float>(Item_1_In: Output_255, Item_2_In: Width_256, Output_Out: out n2.ValueTuple<n9.ILayer, float> Output_258);
                    __auto_242 = Output_258;
                    if (state_243.__GetContext__().IsImmutable)
                        state_243 = State_Output_257 != state_243.__p_OpD9q2PWmJINB0Q9awv6Ey ? new __CuKAY065O80OeRVwaEaw0p(state_243)
                        {__p_OpD9q2PWmJINB0Q9awv6Ey = State_Output_257} : state_243;
                    else
                    {
                        state_243.__p_OpD9q2PWmJINB0Q9awv6Ey = State_Output_257;
                    }
                }
                else
                {
                    __auto_242 = n30._Operations_.CreateDefault<n9.ILayer, float, n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>();
                }

                if (state_211.__GetContext__().IsImmutable)
                    state_211 = state_243 != state_211.__if_GQ6bHKuC6vvMAD2GnvsGX1 ? new __UuUDRmNZsKgPaEZw3U7sBA(state_211)
                    {__if_GQ6bHKuC6vvMAD2GnvsGX1 = state_243} : state_211;
                else
                {
                    state_211.__if_GQ6bHKuC6vvMAD2GnvsGX1 = state_243;
                }

                return n2.Tuple.Create<n2.Object, n2.ValueTuple<n9.ILayer, float>, bool>(state_211, __auto_242, Output_241);
            }

            , Create_In: () =>
            {
                using var __current_259 = __fallback___7.MakeCurrentIfNone();
                var state_211 = new __UuUDRmNZsKgPaEZw3U7sBA(__GetContext__(), n1.VLObject.NewIdentity());
                return state_211;
            }

            , Output_Out: out n31.ForEachKeep<n2.Object, n28.EventPattern<n24.KeyEventArgs>, n2.ValueTuple<n9.ILayer, float>> Output_260, Result_Out: out n2.IObservable<n2.ValueTuple<n9.ILayer, float>> Result_261);
            n27.IMouseEvents Input_262 = (n27.IMouseEvents)__pad_SlSlmKGg9qIODLUttv8B0r_0;
            string Event_Name_263 = "MouseDoubleClick";
            var return_264 = n1.EventBridge.FromEventPattern<n24.MouseEventArgs>(target: Input_262, eventName: Event_Name_263);
            bool Reset_265 = false;
            n32._Operations_.Update_H<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>>(Input_In: this.__p_JXL2eldziffOiEa6vykZ3I, Messages_In: return_264, Reset_In: Reset_265, Update_In: (n2.Object s_268, n28.EventPattern<n24.MouseEventArgs> Input_1_In_269) =>
            {
                using var __current_266 = __fallback___7.MakeCurrentIfNone();
                var state_267 = n1.CompilationHelper.Restore<__BBZkl7iEFqrMygSwdR5mRH>(s_268, __GetContext__());
                float __pad_GHtZAH1DAm3NGKv5RAY3eL_270 = __slot_GHtZAH1DAm3NGKv5RAY3eL;
                float __pad_UcWzglIahdtLRDUbj9jFiL_271 = __slot_UcWzglIahdtLRDUbj9jFiL;
                n29._Operations_.EventArgs<n2.Object, n24.MouseEventArgs>(Input_In: Input_1_In_269, Event_Args_Out: out n24.MouseEventArgs Event_Args_272);
                var Button_273 = Event_Args_272.Button;
                string Input_274 = "";
                n4._Operations_.AddModifiers(Input_In: Input_274, Output_Out: out string Output_275);
                var State_Output_278 = state_267.__p_FxLm7GG39LJNts6M8ILPB8.Update(Keys_In: Output_275, Output_Out: out n9.ILayer Output_276, Width_Out: out float Width_277);
                float Input_2_279 = 0F;
                var Output_280 = Width_277 + Input_2_279;
                var State_Output_283 = state_267.__p_CadzXvZML8KMz54M4bl9rz.Update(Button_In: Button_273, X_Offset_In: Output_280, Output_Out: out n9.ILayer Output_281, Width_Out: out float Width_282);
                var Output_284 = Width_277 + Width_282;
                var Output_285 = Output_284 + __pad_GHtZAH1DAm3NGKv5RAY3eL_270;
                var State_Output_288 = state_267.__p_LtEMtwczbnHLfeCqDtiq1k.Update(Button_In: Button_273, X_Offset_In: Output_285, Output_Out: out n9.ILayer Output_286, Width_Out: out float Width_287);
                bool Debug_289 = false;
                bool Enabled_290 = true;
                var builder_291 = n5.CollectionBuilders.GetBuilder(state_267.__pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi, 3);
                builder_291.Add(Output_276);
                builder_291.Add(Output_281);
                builder_291.Add(Output_286);
                var __pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi_292 = builder_291.Commit();
                var State_Output_294 = state_267.__p_Th8QUGyL87DO3XDEu6cfpi.Update(Input_In: __pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi_292, Debug_In: Debug_289, Enabled_In: Enabled_290, Output_Out: out n9.ILayer Output_293);
                var Output_295 = Output_285 + Width_287;
                var Output_296 = Output_295 + __pad_UcWzglIahdtLRDUbj9jFiL_271;
                n30._Operations_.ValueTuple_Create<n9.ILayer, float>(Item_1_In: Output_293, Item_2_In: Output_296, Output_Out: out n2.ValueTuple<n9.ILayer, float> Output_297);
                n24.MouseButtons __pad_FcXDWwwvaJnLxzEcIy0Dqh_298 = Button_273;
                if (state_267.__GetContext__().IsImmutable)
                    state_267 = State_Output_278 != state_267.__p_FxLm7GG39LJNts6M8ILPB8 || State_Output_283 != state_267.__p_CadzXvZML8KMz54M4bl9rz || State_Output_288 != state_267.__p_LtEMtwczbnHLfeCqDtiq1k || __pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi_292 != state_267.__pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi || State_Output_294 != state_267.__p_Th8QUGyL87DO3XDEu6cfpi || !n17.EqualityComparer<n24.MouseButtons>.Default.Equals(Button_273, state_267.__slot_FcXDWwwvaJnLxzEcIy0Dqh) ? new __BBZkl7iEFqrMygSwdR5mRH(state_267)
                    {__p_FxLm7GG39LJNts6M8ILPB8 = State_Output_278, __p_CadzXvZML8KMz54M4bl9rz = State_Output_283, __p_LtEMtwczbnHLfeCqDtiq1k = State_Output_288, __pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi = __pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi_292, __p_Th8QUGyL87DO3XDEu6cfpi = State_Output_294, __slot_FcXDWwwvaJnLxzEcIy0Dqh = Button_273} : state_267;
                else
                {
                    state_267.__p_FxLm7GG39LJNts6M8ILPB8 = State_Output_278;
                    state_267.__p_CadzXvZML8KMz54M4bl9rz = State_Output_283;
                    state_267.__p_LtEMtwczbnHLfeCqDtiq1k = State_Output_288;
                    state_267.__pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi = __pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi_292;
                    state_267.__p_Th8QUGyL87DO3XDEu6cfpi = State_Output_294;
                    state_267.__slot_FcXDWwwvaJnLxzEcIy0Dqh = Button_273;
                }

                return n2.Tuple.Create<n2.Object, n2.ValueTuple<n9.ILayer, float>>(state_267, Output_297);
            }

            , Create_In: () =>
            {
                using var __current_299 = __fallback___7.MakeCurrentIfNone();
                var state_267 = new __BBZkl7iEFqrMygSwdR5mRH(__GetContext__(), n1.VLObject.NewIdentity())
                {__pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi = n13._Operations_.CreateDefault<n9.ILayer>(), __slot_FcXDWwwvaJnLxzEcIy0Dqh = default(n24.MouseButtons)};
                n1.NodeContext Node_Context_300 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "CadzXvZML8KMz54M4bl9rz", 108713U);
                var Output_301 = n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP.Create(Node_Context: Node_Context_300);
                state_267.__p_CadzXvZML8KMz54M4bl9rz = Output_301;
                n1.NodeContext Node_Context_302 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "Th8QUGyL87DO3XDEu6cfpi", 108740U);
                var Output_303 = n6.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_302);
                state_267.__p_Th8QUGyL87DO3XDEu6cfpi = Output_303;
                n1.NodeContext Node_Context_304 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "LtEMtwczbnHLfeCqDtiq1k", 108760U);
                var Output_305 = n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP.Create(Node_Context: Node_Context_304);
                state_267.__p_LtEMtwczbnHLfeCqDtiq1k = Output_305;
                n1.NodeContext Node_Context_306 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "FxLm7GG39LJNts6M8ILPB8", 108821U);
                var Output_307 = n4.DrawKeys_DONOgIrpGTxOwISujK9hgd.Create(Node_Context: Node_Context_306);
                state_267.__p_FxLm7GG39LJNts6M8ILPB8 = Output_307;
                return state_267;
            }

            , Output_Out: out n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> Output_308, Result_Out: out n2.IObservable<n2.ValueTuple<n9.ILayer, float>> Result_309);
            var Output_312 = this.__p_BjYcVrcps6uLCc4z0BTMWT.Update<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Value_In: Result_261, Value_2_In: Result_309, Result_Out: out n2.IObservable<n2.ValueTuple<n9.ILayer, float>> Result_310, Changed_Out: out bool Changed_311);
            n27.IMouseEvents Input_313 = (n27.IMouseEvents)__pad_SlSlmKGg9qIODLUttv8B0r_0;
            string Event_Name_314 = "MouseClick";
            var return_315 = n1.EventBridge.FromEventPattern<n24.MouseEventArgs>(target: Input_313, eventName: Event_Name_314);
            bool Reset_316 = false;
            n43._Operations_.Update_H<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>>(Input_In: this.__p_L6JwULGAdkdMPHh4U3yr0y, Messages_In: return_315, Reset_In: Reset_316, Update_In: (n2.Object s_319, n28.EventPattern<n24.MouseEventArgs> Input_1_In_320) =>
            {
                using var __current_317 = __fallback___7.MakeCurrentIfNone();
                var state_318 = n1.CompilationHelper.Restore<__VlugX6glk3LMurswztv4uf>(s_319, __GetContext__());
                float __pad_QugIhCBHcYwN3loRb4mzJq_321 = __slot_QugIhCBHcYwN3loRb4mzJq;
                bool __pad_SHirh59hCkgMJ8GsBxlj2C_322 = State_204;
                n29._Operations_.EventArgs<n2.Object, n24.MouseEventArgs>(Input_In: Input_1_In_320, Event_Args_Out: out n24.MouseEventArgs Event_Args_323);
                var Button_324 = Event_Args_323.Button;
                var Result_325 = n20.ObjectHelpers.ToString(input: Button_324);
                string Input_2_326 = "Click";
                var Output_327 = n44.StringExtensions.Plus(input: Result_325, input2: Input_2_326);
                string __pad_HNntx2Kh5PwOcmLAZOtK5e_328 = Output_327;
                string Input_329 = "";
                n4._Operations_.AddModifiers(Input_In: Input_329, Output_Out: out string Output_330);
                var State_Output_333 = state_318.__p_Cp4IQLE7bDbQZfixmZ8RXv.Update(Keys_In: Output_330, Output_Out: out n9.ILayer Output_331, Width_Out: out float Width_332);
                var State_Output_336 = state_318.__p_NF6WVBymvKOPjE463Q3mj2.Update(Button_In: Button_324, X_Offset_In: Width_332, Output_Out: out n9.ILayer Output_334, Width_Out: out float Width_335);
                bool Debug_337 = false;
                bool Enabled_338 = true;
                var builder_339 = n5.CollectionBuilders.GetBuilder(state_318.__pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N, 2);
                builder_339.Add(Output_331);
                builder_339.Add(Output_334);
                var __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N_340 = builder_339.Commit();
                var State_Output_342 = state_318.__p_HwQ1r0wFc2pP2ftGq5HM7N.Update(Input_In: __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N_340, Debug_In: Debug_337, Enabled_In: Enabled_338, Output_Out: out n9.ILayer Output_341);
                var Output_343 = Width_332 + Width_335;
                var Output_344 = Output_343 + __pad_QugIhCBHcYwN3loRb4mzJq_321;
                n30._Operations_.ValueTuple_Create<n9.ILayer, float>(Item_1_In: Output_341, Item_2_In: Output_344, Output_Out: out n2.ValueTuple<n9.ILayer, float> Output_345);
                n24.MouseButtons __pad_Q1FGDRw8Uh0OyiedCCyczk_346 = Button_324;
                if (state_318.__GetContext__().IsImmutable)
                    state_318 = Output_327 != state_318.__slot_HNntx2Kh5PwOcmLAZOtK5e || State_Output_333 != state_318.__p_Cp4IQLE7bDbQZfixmZ8RXv || State_Output_336 != state_318.__p_NF6WVBymvKOPjE463Q3mj2 || __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N_340 != state_318.__pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N || State_Output_342 != state_318.__p_HwQ1r0wFc2pP2ftGq5HM7N || !n17.EqualityComparer<n24.MouseButtons>.Default.Equals(Button_324, state_318.__slot_Q1FGDRw8Uh0OyiedCCyczk) ? new __VlugX6glk3LMurswztv4uf(state_318)
                    {__slot_HNntx2Kh5PwOcmLAZOtK5e = Output_327, __p_Cp4IQLE7bDbQZfixmZ8RXv = State_Output_333, __p_NF6WVBymvKOPjE463Q3mj2 = State_Output_336, __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N = __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N_340, __p_HwQ1r0wFc2pP2ftGq5HM7N = State_Output_342, __slot_Q1FGDRw8Uh0OyiedCCyczk = Button_324} : state_318;
                else
                {
                    state_318.__slot_HNntx2Kh5PwOcmLAZOtK5e = Output_327;
                    state_318.__p_Cp4IQLE7bDbQZfixmZ8RXv = State_Output_333;
                    state_318.__p_NF6WVBymvKOPjE463Q3mj2 = State_Output_336;
                    state_318.__pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N = __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N_340;
                    state_318.__p_HwQ1r0wFc2pP2ftGq5HM7N = State_Output_342;
                    state_318.__slot_Q1FGDRw8Uh0OyiedCCyczk = Button_324;
                }

                return n2.Tuple.Create<n2.Object, n2.ValueTuple<n9.ILayer, float>, bool>(state_318, Output_345, __pad_SHirh59hCkgMJ8GsBxlj2C_322);
            }

            , Create_In: () =>
            {
                using var __current_347 = __fallback___7.MakeCurrentIfNone();
                var state_318 = new __VlugX6glk3LMurswztv4uf(__GetContext__(), n1.VLObject.NewIdentity())
                {__slot_HNntx2Kh5PwOcmLAZOtK5e = "", __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N = n13._Operations_.CreateDefault<n9.ILayer>(), __slot_Q1FGDRw8Uh0OyiedCCyczk = default(n24.MouseButtons)};
                n1.NodeContext Node_Context_348 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "Cp4IQLE7bDbQZfixmZ8RXv", 108353U);
                var Output_349 = n4.DrawKeys_DONOgIrpGTxOwISujK9hgd.Create(Node_Context: Node_Context_348);
                state_318.__p_Cp4IQLE7bDbQZfixmZ8RXv = Output_349;
                n1.NodeContext Node_Context_350 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "NF6WVBymvKOPjE463Q3mj2", 108390U);
                var Output_351 = n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP.Create(Node_Context: Node_Context_350);
                state_318.__p_NF6WVBymvKOPjE463Q3mj2 = Output_351;
                n1.NodeContext Node_Context_352 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "HwQ1r0wFc2pP2ftGq5HM7N", 108436U);
                var Output_353 = n6.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_352);
                state_318.__p_HwQ1r0wFc2pP2ftGq5HM7N = Output_353;
                return state_318;
            }

            , Output_Out: out n31.ForEachKeep<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> Output_354, Result_Out: out n2.IObservable<n2.ValueTuple<n9.ILayer, float>> Result_355);
            var Output_358 = this.__p_RnEbF1Oh3B9L9wK5bhZlBJ.Update<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Value_In: Result_310, Value_2_In: Result_355, Result_Out: out n2.IObservable<n2.ValueTuple<n9.ILayer, float>> Result_356, Changed_Out: out bool Changed_357);
            n27.IMouseEvents Input_359 = (n27.IMouseEvents)__pad_SlSlmKGg9qIODLUttv8B0r_0;
            string Event_Name_360 = "MouseWheel";
            var return_361 = n1.EventBridge.FromEventPattern<n24.MouseEventArgs>(target: Input_359, eventName: Event_Name_360);
            bool Reset_362 = false;
            n32._Operations_.Update_H<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>>(Input_In: this.__p_ABKnYN5Dp64M1rUtsVoMDP, Messages_In: return_361, Reset_In: Reset_362, Update_In: (n2.Object s_365, n28.EventPattern<n24.MouseEventArgs> Input_1_In_366) =>
            {
                using var __current_363 = __fallback___7.MakeCurrentIfNone();
                var state_364 = n1.CompilationHelper.Restore<__RnUdAiXpnytQS6Dh2GiuQc>(s_365, __GetContext__());
                n29._Operations_.EventArgs<n2.Object, n24.MouseEventArgs>(Input_In: Input_1_In_366, Event_Args_Out: out n24.MouseEventArgs Event_Args_367);
                var Delta_368 = Event_Args_367.Delta;
                int Input_2_369 = 0;
                var Result_370 = Delta_368 > Input_2_369;
                string Input_371 = "";
                n4._Operations_.AddModifiers(Input_In: Input_371, Output_Out: out string Output_372);
                var State_Output_375 = state_364.__p_VDFrubCKKTWNgKU88EAGX5.Update(Keys_In: Output_372, Output_Out: out n9.ILayer Output_373, Width_Out: out float Width_374);
                var State_Output_378 = state_364.__p_F1yL4yu6pqjLjWiByNxDSo.Update(Condition_In: Result_370, X_Offset_In: Width_374, Output_Out: out n9.ILayer Output_376, Width_Out: out float Width_377);
                n9.ILayer Input_3_379 = n38._Operations_.CreateDefault();
                bool Debug_380 = false;
                bool Enabled_381 = true;
                var builder_382 = n5.CollectionBuilders.GetBuilder(state_364.__pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU, 3);
                builder_382.Add(Output_373);
                builder_382.Add(Output_376);
                builder_382.Add(Input_3_379);
                var __pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU_383 = builder_382.Commit();
                var State_Output_385 = state_364.__p_FA2iWmhHAwNMixC3fxoReU.Update(Input_In: __pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU_383, Debug_In: Debug_380, Enabled_In: Enabled_381, Output_Out: out n9.ILayer Output_384);
                var Output_386 = Width_374 + Width_377;
                n30._Operations_.ValueTuple_Create<n9.ILayer, float>(Item_1_In: Output_384, Item_2_In: Output_386, Output_Out: out n2.ValueTuple<n9.ILayer, float> Output_387);
                if (state_364.__GetContext__().IsImmutable)
                    state_364 = State_Output_375 != state_364.__p_VDFrubCKKTWNgKU88EAGX5 || State_Output_378 != state_364.__p_F1yL4yu6pqjLjWiByNxDSo || __pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU_383 != state_364.__pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU || State_Output_385 != state_364.__p_FA2iWmhHAwNMixC3fxoReU ? new __RnUdAiXpnytQS6Dh2GiuQc(state_364)
                    {__p_VDFrubCKKTWNgKU88EAGX5 = State_Output_375, __p_F1yL4yu6pqjLjWiByNxDSo = State_Output_378, __pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU = __pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU_383, __p_FA2iWmhHAwNMixC3fxoReU = State_Output_385} : state_364;
                else
                {
                    state_364.__p_VDFrubCKKTWNgKU88EAGX5 = State_Output_375;
                    state_364.__p_F1yL4yu6pqjLjWiByNxDSo = State_Output_378;
                    state_364.__pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU = __pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU_383;
                    state_364.__p_FA2iWmhHAwNMixC3fxoReU = State_Output_385;
                }

                return n2.Tuple.Create<n2.Object, n2.ValueTuple<n9.ILayer, float>>(state_364, Output_387);
            }

            , Create_In: () =>
            {
                using var __current_388 = __fallback___7.MakeCurrentIfNone();
                var state_364 = new __RnUdAiXpnytQS6Dh2GiuQc(__GetContext__(), n1.VLObject.NewIdentity())
                {__pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU = n13._Operations_.CreateDefault<n9.ILayer>()};
                n1.NodeContext Node_Context_389 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "VDFrubCKKTWNgKU88EAGX5", 108994U);
                var Output_390 = n4.DrawKeys_DONOgIrpGTxOwISujK9hgd.Create(Node_Context: Node_Context_389);
                state_364.__p_VDFrubCKKTWNgKU88EAGX5 = Output_390;
                n1.NodeContext Node_Context_391 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "F1yL4yu6pqjLjWiByNxDSo", 109035U);
                var Output_392 = n4.DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3.Create(Node_Context: Node_Context_391);
                state_364.__p_F1yL4yu6pqjLjWiByNxDSo = Output_392;
                n1.NodeContext Node_Context_393 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "FA2iWmhHAwNMixC3fxoReU", 109364U);
                var Output_394 = n6.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_393);
                state_364.__p_FA2iWmhHAwNMixC3fxoReU = Output_394;
                return state_364;
            }

            , Output_Out: out n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> Output_395, Result_Out: out n2.IObservable<n2.ValueTuple<n9.ILayer, float>> Result_396);
            var Output_399 = this.__p_IKnAExjizzjNeQE7o0VZiF.Update<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Value_In: Result_356, Value_2_In: Result_396, Result_Out: out n2.IObservable<n2.ValueTuple<n9.ILayer, float>> Result_397, Changed_Out: out bool Changed_398);
            var Output_402 = this.__p_Vop1QgprklHPb4KtPiKLtl.Update<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Value_In: Result_397, Value_2_In: Result_200, Result_Out: out n2.IObservable<n2.ValueTuple<n9.ILayer, float>> Result_400, Changed_Out: out bool Changed_401);
            bool Reset_403 = false;
            bool Update_404 = true;
            var Output_405 = this.__p_BdqpmsCFAodQXJH61mwCWr;
            if (Update_404)
            {
                n33._Operations_.Update_H<n2.ValueTuple<n9.ILayer, float>>(Input_In: this.__p_BdqpmsCFAodQXJH61mwCWr, Async_Notifications_In: Result_400, Reset_In: Reset_403, Output_Out: out Output_405);
            }

            n33._Operations_.GetData_H<n2.ValueTuple<n9.ILayer, float>>(Input_In: Output_405, Output_Out: out n31.HoldLatest<n2.ValueTuple<n9.ILayer, float>> Output_406, Value_Out: out n2.ValueTuple<n9.ILayer, float> Value_407, On_Data_Out: out bool On_Data_408);
            bool Reset_409 = false;
            bool Update_410 = true;
            var Output_411 = this.__p_OhDArnQcUcsNO69JN5vmmi;
            if (Update_410)
            {
                n33._Operations_.Update_H<n2.ValueTuple<n9.ILayer, float>>(Input_In: this.__p_OhDArnQcUcsNO69JN5vmmi, Async_Notifications_In: Result_261, Reset_In: Reset_409, Output_Out: out Output_411);
            }

            n33._Operations_.GetData_H<n2.ValueTuple<n9.ILayer, float>>(Input_In: Output_411, Output_Out: out n31.HoldLatest<n2.ValueTuple<n9.ILayer, float>> Output_412, Value_Out: out n2.ValueTuple<n9.ILayer, float> Value_413, On_Data_Out: out bool On_Data_414);
            n30._Operations_.ValueTuple_Split<n9.ILayer, float>(Input_In: Value_407, Item_1_Out: out n9.ILayer Item_1_415, Item_2_Out: out float Item_2_416);
            bool Dispose_Cached_Outputs_417 = false;
            var manager_418 = this.__cache_SozMDkLfzfDNUtCf9rkEf7;
            if (manager_418 is null)
            {
                manager_418 = new n46.Manager<n2.ValueTuple, n2.ValueTuple<n45.Rectangle>>(n2.ValueTuple.Create(default(n45.Rectangle)));
            }

            var inputs_419 = n2.ValueTuple.Create();
            var outputs_420 = manager_418.Outputs;
            var Has_Changed_421 = On_Data_408 || manager_418.InputsChanged(inputs_419);
            if (Has_Changed_421)
            {
                if (Dispose_Cached_Outputs_417)
                    manager_418.DisposeOutputs();
                n2.IntPtr Hwnd_423 = n47._Operations_.CreateDefault();
                var Result_424 = n45.Graphics.FromHwnd(hwnd: Hwnd_423);
                var Dpi_X_425 = Result_424.DpiX;
                float Input_2_426 = 96F;
                var Output_427 = (float)Dpi_X_425 / Input_2_426;
                var Output_428 = Output_427 * __pad_KPbqwyhr6YQNgX6BS8ql5L_1;
                var Result_429 = n44.IntegerConversions.ToInt32(input: Output_428);
                float Input_2_430 = (float)Result_429;
                var Output_431 = Item_2_416 * Input_2_430;
                var Result_432 = n44.IntegerConversions.ToInt32(input: Output_431);
                var Position_433 = n24.Cursor.Position;
                var Result_434 = n24.Screen.FromPoint(point: Position_433);
                var Working_Area_435 = Result_434.WorkingArea;
                var Height_436 = Working_Area_435.Height;
                var Top_437 = Working_Area_435.Top;
                var Left_438 = Working_Area_435.Left;
                var Output_439 = Top_437 + Height_436;
                var Output_440 = Output_439 - Result_429;
                var Output_441 = new n45.Rectangle(x: Left_438, y: Output_440, width: Result_432, height: Result_429);
                var Output_442 = n48.DIPHelpers.DIP(pixel: Output_441);
                outputs_420 = n2.ValueTuple.Create(Output_442);
                manager_418 = manager_418.Update(inputs_419, __GetContext__().IsImmutable, Dispose_Cached_Outputs_417, default, outputs_420);
            }
            else
            {
                manager_418.Update(inputs_419, __GetContext__().IsImmutable, Dispose_Cached_Outputs_417);
            }

            var __auto_443 = outputs_420.Item1;
            string Name_444 = "";
            bool Show_Control_Box_445 = false;
            n24.FormBorderStyle Border_Style_446 = __c_L81Yd1cAOC1M9bySoFGABQ;
            n3.Color4 Color_447 = __c_Gzk2Kjzseo1MDcmPGhFXWy;
            n9.CommonSpace Space_448 = __c_TnAZgcfB0KdLuYKopyNLVG;
            bool Show_449 = false;
            var Output_451 = this.__p_PQHgsdD70DGOIOazcN71hQ.Update(Bounds_In: __auto_443, Name_In: Name_444, Show_Control_Box_In: Show_Control_Box_445, Border_Style_In: Border_Style_446, Input_In: Item_1_415, Color_In: Color_447, Space_In: Space_448, Show_In: Show_449, On_Close_Out: out bool On_Close_450);
            float Time_452 = 2F;
            bool Retriggerable_453 = true;
            bool Reset_454 = false;
            var Output_457 = this.__p_EmCIi08GYR3OyiTSfwRBXi.Update(Set_In: On_Data_408, Time_In: Time_452, Retriggerable_In: Retriggerable_453, Reset_In: Reset_454, Value_Out: out bool Value_455, Inverse_Output_Out: out bool Inverse_Output_456);
            var Output_460 = this.__p_VR8cSPg0TUkMZxZDqWBH5o.Update(Value_In: Value_455, Up_Edge_Out: out bool Up_Edge_458, Down_Edge_Out: out bool Down_Edge_459);
            n1.NodeContext Node_Context_461 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "KdTOF2bDX9MMY3f0B8XNgd", 114065U);
            float Attack_Time_462 = 0.1F;
            float Decay_Time_463 = 0F;
            float Sustain_Level_464 = 1F;
            float Slope_465 = 0F;
            float Release_Time_466 = 0.5F;
            float Frame_Rate_467 = 30F;
            n10.TweenerTransition Attack_Curve_468 = n1.CompilationHelper.Deserialize<n10.TweenerTransition>("Expo", false, null, null);
            n10.TweenerMode Attack_Mode_469 = default(n10.TweenerMode);
            n10.TweenerTransition Decay_Curve_470 = n1.CompilationHelper.Deserialize<n10.TweenerTransition>("Expo", false, null, null);
            n10.TweenerMode Decay_Mode_471 = n1.CompilationHelper.Deserialize<n10.TweenerMode>("Out", false, null, null);
            n10.TweenerTransition Releae_Curve_472 = n1.CompilationHelper.Deserialize<n10.TweenerTransition>("Expo", false, null, null);
            n10.TweenerMode Release_Mode_473 = n1.CompilationHelper.Deserialize<n10.TweenerMode>("Out", false, null, null);
            var Output_474 = n49.ADSRSettings_R.Create(Node_Context: Node_Context_461, Attack_Time_In: Attack_Time_462, Decay_Time_In: Decay_Time_463, Sustain_Level_In: Sustain_Level_464, Slope_In: Slope_465, Release_Time_In: Release_Time_466, Frame_Rate_In: Frame_Rate_467, Attack_Curve_In: Attack_Curve_468, Attack_Mode_In: Attack_Mode_469, Decay_Curve_In: Decay_Curve_470, Decay_Mode_In: Decay_Mode_471, Releae_Curve_In: Releae_Curve_472, Release_Mode_In: Release_Mode_473);
            bool SetParams_475 = true;
            var Output_476 = this.__p_ATv4FbuJAkcLU1ZXfMWemK;
            if (SetParams_475)
            {
                Output_476 = this.__p_ATv4FbuJAkcLU1ZXfMWemK.SetParams(Settings_In: Output_474);
            }

            var Output_477 = Output_476;
            if (Up_Edge_458)
            {
                Output_477 = Output_476.Set();
            }

            var Output_478 = Output_477;
            if (Down_Edge_459)
            {
                Output_478 = Output_477.Reset();
            }

            var Output_481 = Output_478.Step(Level_Out: out float Level_479, Stage_Out: out n50.ADSRStage Stage_480);
            double Value_482 = (double)Level_479;
            __pad_B07EX9PIFedM4JLFEQ6dk6_2.Opacity = Value_482;
            float Input_2_483 = 0F;
            var Result_484 = Level_479 > Input_2_483;
            var Output_487 = this.__p_D9Sex4dLjUvL9ekGBR2BZR.Update(Value_In: Result_484, Up_Edge_Out: out bool Up_Edge_485, Down_Edge_Out: out bool Down_Edge_486);
            var Output_488 = __pad_B07EX9PIFedM4JLFEQ6dk6_2;
            if (Up_Edge_485)
            {
                __pad_B07EX9PIFedM4JLFEQ6dk6_2.Show();
            }

            var Output_489 = Output_488;
            if (Down_Edge_486)
            {
                Output_488.Hide();
            }

            bool __pad_R8sCv46RWQ8QPDCmMwHhDQ_490 = On_Data_414;
            n4.KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC that_491 = this;
            if (this.__GetContext__().IsImmutable)
                that_491 = Output_21 != this.__p_AQW2dKygsvQNNL39bnlJRj || Output_26 != this.__p_RDj29p7sIoHOv0tmjhclhR || Output_46 != this.__p_DnxnjbpngnWPtCxRD42c90 || Output_41 != this.__p_NuQj2EBWvfkOTDYI9PreKS || Output_60 != this.__p_I0TAHeMNDcUM0a1vVeO5Na || Output_65 != this.__p_SOFwZ98qYP9MsBGzEhCPag || Output_69 != this.__p_EM5sKFgXyBWORIs9EiAcFU || Output_73 != this.__p_VoxRTu6kt38L6dCpqjEQTn || Output_77 != this.__p_GX1BuZtm1QUPsVdgWGuOr2 || Output_86 != this.__p_OJKkGC54FEoMZYr9RhnnFZ || State_Output_94 != this.__p_G1Ygi0PExf1LsZEwApIro9 || Output_99 != this.__p_BCk78oVnVR2MhwVsV1A5NA || Output_199 != this.__p_VGRRqVB5GveNLDctIS5SJi || State_45 != this.__slot_JPB6RP0gC0NN8t89fyqEN1 || Output_205 != this.__p_Ay5Is0ficrTLLUROwrtgII || Output_260 != this.__p_GrekTHE3gejOt1YdfXKWEv || Output_308 != this.__p_JXL2eldziffOiEa6vykZ3I || Output_312 != this.__p_BjYcVrcps6uLCc4z0BTMWT || Output_354 != this.__p_L6JwULGAdkdMPHh4U3yr0y || Output_358 != this.__p_RnEbF1Oh3B9L9wK5bhZlBJ || Output_395 != this.__p_ABKnYN5Dp64M1rUtsVoMDP || Output_399 != this.__p_IKnAExjizzjNeQE7o0VZiF || Output_402 != this.__p_Vop1QgprklHPb4KtPiKLtl || Output_406 != this.__p_BdqpmsCFAodQXJH61mwCWr || Output_412 != this.__p_OhDArnQcUcsNO69JN5vmmi || manager_418 != this.__cache_SozMDkLfzfDNUtCf9rkEf7 || Output_451 != this.__p_PQHgsdD70DGOIOazcN71hQ || Output_457 != this.__p_EmCIi08GYR3OyiTSfwRBXi || Output_460 != this.__p_VR8cSPg0TUkMZxZDqWBH5o || Output_481 != this.__p_ATv4FbuJAkcLU1ZXfMWemK || Output_487 != this.__p_D9Sex4dLjUvL9ekGBR2BZR || On_Data_414 != this.__slot_R8sCv46RWQ8QPDCmMwHhDQ ? new KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC(this)
                {__p_AQW2dKygsvQNNL39bnlJRj = Output_21, __p_RDj29p7sIoHOv0tmjhclhR = Output_26, __p_DnxnjbpngnWPtCxRD42c90 = Output_46, __p_NuQj2EBWvfkOTDYI9PreKS = Output_41, __p_I0TAHeMNDcUM0a1vVeO5Na = Output_60, __p_SOFwZ98qYP9MsBGzEhCPag = Output_65, __p_EM5sKFgXyBWORIs9EiAcFU = Output_69, __p_VoxRTu6kt38L6dCpqjEQTn = Output_73, __p_GX1BuZtm1QUPsVdgWGuOr2 = Output_77, __p_OJKkGC54FEoMZYr9RhnnFZ = Output_86, __p_G1Ygi0PExf1LsZEwApIro9 = State_Output_94, __p_BCk78oVnVR2MhwVsV1A5NA = Output_99, __p_VGRRqVB5GveNLDctIS5SJi = Output_199, __slot_JPB6RP0gC0NN8t89fyqEN1 = State_45, __p_Ay5Is0ficrTLLUROwrtgII = Output_205, __p_GrekTHE3gejOt1YdfXKWEv = Output_260, __p_JXL2eldziffOiEa6vykZ3I = Output_308, __p_BjYcVrcps6uLCc4z0BTMWT = Output_312, __p_L6JwULGAdkdMPHh4U3yr0y = Output_354, __p_RnEbF1Oh3B9L9wK5bhZlBJ = Output_358, __p_ABKnYN5Dp64M1rUtsVoMDP = Output_395, __p_IKnAExjizzjNeQE7o0VZiF = Output_399, __p_Vop1QgprklHPb4KtPiKLtl = Output_402, __p_BdqpmsCFAodQXJH61mwCWr = Output_406, __p_OhDArnQcUcsNO69JN5vmmi = Output_412, __cache_SozMDkLfzfDNUtCf9rkEf7 = manager_418, __p_PQHgsdD70DGOIOazcN71hQ = Output_451, __p_EmCIi08GYR3OyiTSfwRBXi = Output_457, __p_VR8cSPg0TUkMZxZDqWBH5o = Output_460, __p_ATv4FbuJAkcLU1ZXfMWemK = Output_481, __p_D9Sex4dLjUvL9ekGBR2BZR = Output_487, __slot_R8sCv46RWQ8QPDCmMwHhDQ = On_Data_414} : that_491;
            else
            {
                this.__p_AQW2dKygsvQNNL39bnlJRj = Output_21;
                this.__p_RDj29p7sIoHOv0tmjhclhR = Output_26;
                this.__p_DnxnjbpngnWPtCxRD42c90 = Output_46;
                this.__p_NuQj2EBWvfkOTDYI9PreKS = Output_41;
                this.__p_I0TAHeMNDcUM0a1vVeO5Na = Output_60;
                this.__p_SOFwZ98qYP9MsBGzEhCPag = Output_65;
                this.__p_EM5sKFgXyBWORIs9EiAcFU = Output_69;
                this.__p_VoxRTu6kt38L6dCpqjEQTn = Output_73;
                this.__p_GX1BuZtm1QUPsVdgWGuOr2 = Output_77;
                this.__p_OJKkGC54FEoMZYr9RhnnFZ = Output_86;
                this.__p_G1Ygi0PExf1LsZEwApIro9 = State_Output_94;
                this.__p_BCk78oVnVR2MhwVsV1A5NA = Output_99;
                this.__p_VGRRqVB5GveNLDctIS5SJi = Output_199;
                this.__slot_JPB6RP0gC0NN8t89fyqEN1 = State_45;
                this.__p_Ay5Is0ficrTLLUROwrtgII = Output_205;
                this.__p_GrekTHE3gejOt1YdfXKWEv = Output_260;
                this.__p_JXL2eldziffOiEa6vykZ3I = Output_308;
                this.__p_BjYcVrcps6uLCc4z0BTMWT = Output_312;
                this.__p_L6JwULGAdkdMPHh4U3yr0y = Output_354;
                this.__p_RnEbF1Oh3B9L9wK5bhZlBJ = Output_358;
                this.__p_ABKnYN5Dp64M1rUtsVoMDP = Output_395;
                this.__p_IKnAExjizzjNeQE7o0VZiF = Output_399;
                this.__p_Vop1QgprklHPb4KtPiKLtl = Output_402;
                this.__p_BdqpmsCFAodQXJH61mwCWr = Output_406;
                this.__p_OhDArnQcUcsNO69JN5vmmi = Output_412;
                this.__cache_SozMDkLfzfDNUtCf9rkEf7 = manager_418;
                this.__p_PQHgsdD70DGOIOazcN71hQ = Output_451;
                this.__p_EmCIi08GYR3OyiTSfwRBXi = Output_457;
                this.__p_VR8cSPg0TUkMZxZDqWBH5o = Output_460;
                this.__p_ATv4FbuJAkcLU1ZXfMWemK = Output_481;
                this.__p_D9Sex4dLjUvL9ekGBR2BZR = Output_487;
                this.__slot_R8sCv46RWQ8QPDCmMwHhDQ = On_Data_414;
            }

            return that_491;
        }

        public n4.KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Result_0 = n27.Hook.GlobalEvents();
            n27.IKeyboardMouseEvents __pad_SlSlmKGg9qIODLUttv8B0r_1 = Result_0;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "PQHgsdD70DGOIOazcN71hQ", 122588U);
            var Output_3 = n51.SkiaWindowTopmost_C.Create(Node_Context: Node_Context_2);
            var Output_5 = Output_3.GetForm(Form_Out: out n9.SkiaRenderer Form_4);
            n9.SkiaRenderer __pad_B07EX9PIFedM4JLFEQ6dk6_6 = Form_4;
            bool Value_7 = false;
            Form_4.ShowInTaskbar = Value_7;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "DnxnjbpngnWPtCxRD42c90", 114020U);
            var Output_9 = n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "GrekTHE3gejOt1YdfXKWEv", 102287U);
            n43._Operations_.Create_H<n2.Object, n28.EventPattern<n24.KeyEventArgs>, n2.ValueTuple<n9.ILayer, float>>(Node_Context: Node_Context_10, Output_Out: out n31.ForEachKeep<n2.Object, n28.EventPattern<n24.KeyEventArgs>, n2.ValueTuple<n9.ILayer, float>> Output_11);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "Ay5Is0ficrTLLUROwrtgII", 109503U);
            var Output_13 = n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.Create(Node_Context: Node_Context_12);
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "L6JwULGAdkdMPHh4U3yr0y", 105005U);
            n43._Operations_.Create_H<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>>(Node_Context: Node_Context_14, Output_Out: out n31.ForEachKeep<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> Output_15);
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "BdqpmsCFAodQXJH61mwCWr", 108488U);
            n2.ValueTuple<n9.ILayer, float> Initial_Result_17 = n30._Operations_.CreateDefault<n9.ILayer, float, n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>();
            n33._Operations_.Create_H<n2.ValueTuple<n9.ILayer, float>>(Node_Context: Node_Context_16, Initial_Result_In: Initial_Result_17, Output_Out: out n31.HoldLatest<n2.ValueTuple<n9.ILayer, float>> Output_18);
            n1.NodeContext Node_Context_19 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "EmCIi08GYR3OyiTSfwRBXi", 108518U);
            n53.IClock Clock_20 = n52._Operations_.CreateDefault();
            var Output_21 = n39.MonoFlop_GeOV3KtNF5BPYMkYFPPAst.Create(Node_Context: Node_Context_19, Clock_In: Clock_20);
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "D9Sex4dLjUvL9ekGBR2BZR", 108599U);
            var Output_23 = n39.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_22);
            n1.NodeContext Node_Context_24 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "JXL2eldziffOiEa6vykZ3I", 108618U);
            n32._Operations_.Create_H<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>>(Node_Context: Node_Context_24, Output_Out: out n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> Output_25);
            n1.NodeContext Node_Context_26 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "IKnAExjizzjNeQE7o0VZiF", 108884U);
            var Output_27 = n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>>.Create<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Node_Context: Node_Context_26);
            n1.NodeContext Node_Context_28 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "ABKnYN5Dp64M1rUtsVoMDP", 108907U);
            n32._Operations_.Create_H<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>>(Node_Context: Node_Context_28, Output_Out: out n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> Output_29);
            n1.NodeContext Node_Context_30 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "RnEbF1Oh3B9L9wK5bhZlBJ", 109416U);
            var Output_31 = n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>>.Create<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Node_Context: Node_Context_30);
            n1.NodeContext Node_Context_32 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "RDj29p7sIoHOv0tmjhclhR", 109482U);
            n2.ValueTuple<n3.Vector2, n24.MouseButtons> Initial_Result_33 = n30._Operations_.CreateDefault<n3.Vector2, n24.MouseButtons, n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>();
            n33._Operations_.Create_H<n2.ValueTuple<n3.Vector2, n24.MouseButtons>>(Node_Context: Node_Context_32, Initial_Result_In: Initial_Result_33, Output_Out: out n31.HoldLatest<n2.ValueTuple<n3.Vector2, n24.MouseButtons>> Output_34);
            n1.NodeContext Node_Context_35 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "SOFwZ98qYP9MsBGzEhCPag", 109528U);
            n3.Vector2 Initial_Result_36 = n41._Operations_.CreateDefault();
            n33._Operations_.Create_H<n3.Vector2>(Node_Context: Node_Context_35, Initial_Result_In: Initial_Result_36, Output_Out: out n31.HoldLatest<n3.Vector2> Output_37);
            n1.NodeContext Node_Context_38 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "Vop1QgprklHPb4KtPiKLtl", 109548U);
            var Output_39 = n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>>.Create<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Node_Context: Node_Context_38);
            n1.NodeContext Node_Context_40 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "OJKkGC54FEoMZYr9RhnnFZ", 119850U);
            n53.IClock Clock_41 = n52._Operations_.CreateDefault();
            var Output_42 = n55.Damper_Qhw7aQNplhrMCum2sxpG8z.Create(Node_Context: Node_Context_40, Clock_In: Clock_41);
            n1.NodeContext Node_Context_43 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "GX1BuZtm1QUPsVdgWGuOr2", 119894U);
            float Initial_Value_44 = 0F;
            var Output_45 = n39.SPH_RESwCzqU3iTMc4Ig82Av03<float>.Create(Node_Context: Node_Context_43, Initial_Value_In: Initial_Value_44);
            n1.NodeContext Node_Context_46 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "G1Ygi0PExf1LsZEwApIro9", 122518U);
            var Output_47 = n56.Stroke_ApdGyamrLDXOTiJpdyhyN9.Create(Node_Context: Node_Context_46);
            n1.NodeContext Node_Context_48 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "BCk78oVnVR2MhwVsV1A5NA", 114345U);
            var Output_49 = n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.Create(Node_Context: Node_Context_48);
            n1.NodeContext Node_Context_50 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "VGRRqVB5GveNLDctIS5SJi", 109567U);
            n43._Operations_.Create_H<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>>(Node_Context: Node_Context_50, Output_Out: out n31.ForEachKeep<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> Output_51);
            n1.NodeContext Node_Context_52 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "NuQj2EBWvfkOTDYI9PreKS", 114029U);
            n28.EventPattern<n24.MouseEventArgs> Initial_Result_53 = n57._Operations_.CreateDefault<n24.MouseEventArgs, n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>();
            n33._Operations_.Create_H<n28.EventPattern<n24.MouseEventArgs>>(Node_Context: Node_Context_52, Initial_Result_In: Initial_Result_53, Output_Out: out n31.HoldLatest<n28.EventPattern<n24.MouseEventArgs>> Output_54);
            n1.NodeContext Node_Context_55 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "ATv4FbuJAkcLU1ZXfMWemK", 114039U);
            n53.IClock Clock_56 = n52._Operations_.CreateDefault();
            var Output_57 = n49.ADSR_NLdSdxoGgeXLodhNRpRhvv.Create(Node_Context: Node_Context_55, Clock_In: Clock_56);
            n1.NodeContext Node_Context_58 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "VR8cSPg0TUkMZxZDqWBH5o", 114110U);
            var Output_59 = n39.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_58);
            n1.NodeContext Node_Context_60 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "AQW2dKygsvQNNL39bnlJRj", 114121U);
            n32._Operations_.Create_H<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n3.Vector2, n24.MouseButtons>>(Node_Context: Node_Context_60, Output_Out: out n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n3.Vector2, n24.MouseButtons>> Output_61);
            n1.NodeContext Node_Context_62 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "I0TAHeMNDcUM0a1vVeO5Na", 114235U);
            n32._Operations_.Create_H<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n3.Vector2>(Node_Context: Node_Context_62, Output_Out: out n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n3.Vector2> Output_63);
            n1.NodeContext Node_Context_64 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "EM5sKFgXyBWORIs9EiAcFU", 119820U);
            var Output_65 = n58.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector2>.Create<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Node_Context: Node_Context_64);
            n1.NodeContext Node_Context_66 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "VoxRTu6kt38L6dCpqjEQTn", 119881U);
            bool Changed_On_Create_67 = true;
            var Output_68 = n39.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector2>.Create<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Node_Context: Node_Context_66, Changed_On_Create_In: Changed_On_Create_67);
            n1.NodeContext Node_Context_69 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "BjYcVrcps6uLCc4z0BTMWT", 122479U);
            var Output_70 = n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>>.Create<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Node_Context: Node_Context_69);
            n1.NodeContext Node_Context_71 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "OhDArnQcUcsNO69JN5vmmi", 122560U);
            n2.ValueTuple<n9.ILayer, float> Initial_Result_72 = n30._Operations_.CreateDefault<n9.ILayer, float, n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>();
            n33._Operations_.Create_H<n2.ValueTuple<n9.ILayer, float>>(Node_Context: Node_Context_71, Initial_Result_In: Initial_Result_72, Output_Out: out n31.HoldLatest<n2.ValueTuple<n9.ILayer, float>> Output_73);
            n4.KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC that_74 = this;
            this.__slot_SlSlmKGg9qIODLUttv8B0r = Result_0;
            this.__slot_JPB6RP0gC0NN8t89fyqEN1 = false;
            this.__slot_R8sCv46RWQ8QPDCmMwHhDQ = false;
            this.__slot_B07EX9PIFedM4JLFEQ6dk6 = Form_4;
            this.__p_PQHgsdD70DGOIOazcN71hQ = Output_5;
            this.__p_DnxnjbpngnWPtCxRD42c90 = Output_9;
            this.__p_GrekTHE3gejOt1YdfXKWEv = Output_11;
            this.__p_Ay5Is0ficrTLLUROwrtgII = Output_13;
            this.__p_L6JwULGAdkdMPHh4U3yr0y = Output_15;
            this.__p_BdqpmsCFAodQXJH61mwCWr = Output_18;
            this.__p_EmCIi08GYR3OyiTSfwRBXi = Output_21;
            this.__p_D9Sex4dLjUvL9ekGBR2BZR = Output_23;
            this.__p_JXL2eldziffOiEa6vykZ3I = Output_25;
            this.__p_IKnAExjizzjNeQE7o0VZiF = Output_27;
            this.__p_ABKnYN5Dp64M1rUtsVoMDP = Output_29;
            this.__p_RnEbF1Oh3B9L9wK5bhZlBJ = Output_31;
            this.__p_RDj29p7sIoHOv0tmjhclhR = Output_34;
            this.__p_SOFwZ98qYP9MsBGzEhCPag = Output_37;
            this.__p_Vop1QgprklHPb4KtPiKLtl = Output_39;
            this.__p_OJKkGC54FEoMZYr9RhnnFZ = Output_42;
            this.__p_GX1BuZtm1QUPsVdgWGuOr2 = Output_45;
            this.__p_G1Ygi0PExf1LsZEwApIro9 = Output_47;
            this.__p_BCk78oVnVR2MhwVsV1A5NA = Output_49;
            this.__p_VGRRqVB5GveNLDctIS5SJi = Output_51;
            this.__p_NuQj2EBWvfkOTDYI9PreKS = Output_54;
            this.__p_ATv4FbuJAkcLU1ZXfMWemK = Output_57;
            this.__p_VR8cSPg0TUkMZxZDqWBH5o = Output_59;
            this.__p_AQW2dKygsvQNNL39bnlJRj = Output_61;
            this.__p_I0TAHeMNDcUM0a1vVeO5Na = Output_63;
            this.__p_EM5sKFgXyBWORIs9EiAcFU = Output_65;
            this.__p_VoxRTu6kt38L6dCpqjEQTn = Output_68;
            this.__p_BjYcVrcps6uLCc4z0BTMWT = Output_70;
            this.__p_OhDArnQcUcsNO69JN5vmmi = Output_73;
            this.__cache_SozMDkLfzfDNUtCf9rkEf7 = null;
            return that_74;
        }

        public n4.KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC Dispose_()
        {
            n27.IKeyboardMouseEvents __pad_SlSlmKGg9qIODLUttv8B0r_0 = this.__slot_SlSlmKGg9qIODLUttv8B0r;
            n2.IDisposable Input_1 = (n2.IDisposable)__pad_SlSlmKGg9qIODLUttv8B0r_0;
            ((n2.IDisposable)Input_1).Dispose();
            n1.CompilationHelper.SafeDispose(this.__p_AQW2dKygsvQNNL39bnlJRj);
            n1.CompilationHelper.SafeDispose(this.__p_RDj29p7sIoHOv0tmjhclhR);
            n1.CompilationHelper.SafeDispose(this.__p_DnxnjbpngnWPtCxRD42c90);
            n1.CompilationHelper.SafeDispose(this.__p_NuQj2EBWvfkOTDYI9PreKS);
            n1.CompilationHelper.SafeDispose(this.__p_I0TAHeMNDcUM0a1vVeO5Na);
            n1.CompilationHelper.SafeDispose(this.__p_SOFwZ98qYP9MsBGzEhCPag);
            n1.CompilationHelper.SafeDispose(this.__p_EM5sKFgXyBWORIs9EiAcFU);
            n1.CompilationHelper.SafeDispose(this.__p_VoxRTu6kt38L6dCpqjEQTn);
            n1.CompilationHelper.SafeDispose(this.__p_GX1BuZtm1QUPsVdgWGuOr2);
            n1.CompilationHelper.SafeDispose(this.__p_OJKkGC54FEoMZYr9RhnnFZ);
            n1.CompilationHelper.SafeDispose(this.__p_G1Ygi0PExf1LsZEwApIro9);
            n1.CompilationHelper.SafeDispose(this.__p_BCk78oVnVR2MhwVsV1A5NA);
            n1.CompilationHelper.SafeDispose(this.__p_VGRRqVB5GveNLDctIS5SJi);
            n1.CompilationHelper.SafeDispose(this.__p_Ay5Is0ficrTLLUROwrtgII);
            n1.CompilationHelper.SafeDispose(this.__p_GrekTHE3gejOt1YdfXKWEv);
            n1.CompilationHelper.SafeDispose(this.__p_JXL2eldziffOiEa6vykZ3I);
            n1.CompilationHelper.SafeDispose(this.__p_BjYcVrcps6uLCc4z0BTMWT);
            n1.CompilationHelper.SafeDispose(this.__p_L6JwULGAdkdMPHh4U3yr0y);
            n1.CompilationHelper.SafeDispose(this.__p_RnEbF1Oh3B9L9wK5bhZlBJ);
            n1.CompilationHelper.SafeDispose(this.__p_ABKnYN5Dp64M1rUtsVoMDP);
            n1.CompilationHelper.SafeDispose(this.__p_IKnAExjizzjNeQE7o0VZiF);
            n1.CompilationHelper.SafeDispose(this.__p_Vop1QgprklHPb4KtPiKLtl);
            n1.CompilationHelper.SafeDispose(this.__p_BdqpmsCFAodQXJH61mwCWr);
            n1.CompilationHelper.SafeDispose(this.__p_OhDArnQcUcsNO69JN5vmmi);
            n1.CompilationHelper.SafeDispose(this.__cache_SozMDkLfzfDNUtCf9rkEf7);
            n1.CompilationHelper.SafeDispose(this.__p_PQHgsdD70DGOIOazcN71hQ);
            n1.CompilationHelper.SafeDispose(this.__p_EmCIi08GYR3OyiTSfwRBXi);
            n1.CompilationHelper.SafeDispose(this.__p_VR8cSPg0TUkMZxZDqWBH5o);
            n1.CompilationHelper.SafeDispose(this.__p_ATv4FbuJAkcLU1ZXfMWemK);
            n1.CompilationHelper.SafeDispose(this.__p_D9Sex4dLjUvL9ekGBR2BZR);
            return this;
        }

        public n4.KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC __CreateDefault__()
        {
            n4.KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC that_0 = this;
            this.__slot_SlSlmKGg9qIODLUttv8B0r = default(n27.IKeyboardMouseEvents);
            this.__slot_JPB6RP0gC0NN8t89fyqEN1 = false;
            this.__slot_R8sCv46RWQ8QPDCmMwHhDQ = false;
            this.__slot_B07EX9PIFedM4JLFEQ6dk6 = default(n9.SkiaRenderer);
            this.__p_AQW2dKygsvQNNL39bnlJRj = default(n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n3.Vector2, n24.MouseButtons>>);
            this.__p_RDj29p7sIoHOv0tmjhclhR = default(n31.HoldLatest<n2.ValueTuple<n3.Vector2, n24.MouseButtons>>);
            this.__p_DnxnjbpngnWPtCxRD42c90 = n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.CreateDefault();
            this.__p_NuQj2EBWvfkOTDYI9PreKS = default(n31.HoldLatest<n28.EventPattern<n24.MouseEventArgs>>);
            this.__p_I0TAHeMNDcUM0a1vVeO5Na = default(n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n3.Vector2>);
            this.__p_SOFwZ98qYP9MsBGzEhCPag = default(n31.HoldLatest<n3.Vector2>);
            this.__p_EM5sKFgXyBWORIs9EiAcFU = n58.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector2>.CreateDefault<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>();
            this.__p_VoxRTu6kt38L6dCpqjEQTn = n39.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector2>.CreateDefault<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>();
            this.__p_GX1BuZtm1QUPsVdgWGuOr2 = n39.SPH_RESwCzqU3iTMc4Ig82Av03<float>.CreateDefault();
            this.__p_OJKkGC54FEoMZYr9RhnnFZ = n55.Damper_Qhw7aQNplhrMCum2sxpG8z.CreateDefault();
            this.__p_G1Ygi0PExf1LsZEwApIro9 = n56.Stroke_ApdGyamrLDXOTiJpdyhyN9.CreateDefault();
            this.__p_BCk78oVnVR2MhwVsV1A5NA = n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.CreateDefault();
            this.__p_VGRRqVB5GveNLDctIS5SJi = default(n31.ForEachKeep<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>>);
            this.__p_Ay5Is0ficrTLLUROwrtgII = n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.CreateDefault();
            this.__p_GrekTHE3gejOt1YdfXKWEv = default(n31.ForEachKeep<n2.Object, n28.EventPattern<n24.KeyEventArgs>, n2.ValueTuple<n9.ILayer, float>>);
            this.__p_JXL2eldziffOiEa6vykZ3I = default(n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>>);
            this.__p_BjYcVrcps6uLCc4z0BTMWT = n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>>.CreateDefault<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>();
            this.__p_L6JwULGAdkdMPHh4U3yr0y = default(n31.ForEachKeep<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>>);
            this.__p_RnEbF1Oh3B9L9wK5bhZlBJ = n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>>.CreateDefault<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>();
            this.__p_ABKnYN5Dp64M1rUtsVoMDP = default(n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>>);
            this.__p_IKnAExjizzjNeQE7o0VZiF = n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>>.CreateDefault<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>();
            this.__p_Vop1QgprklHPb4KtPiKLtl = n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>>.CreateDefault<n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>();
            this.__p_BdqpmsCFAodQXJH61mwCWr = default(n31.HoldLatest<n2.ValueTuple<n9.ILayer, float>>);
            this.__p_OhDArnQcUcsNO69JN5vmmi = default(n31.HoldLatest<n2.ValueTuple<n9.ILayer, float>>);
            this.__cache_SozMDkLfzfDNUtCf9rkEf7 = null;
            this.__p_PQHgsdD70DGOIOazcN71hQ = n51.SkiaWindowTopmost_C.CreateDefault();
            this.__p_EmCIi08GYR3OyiTSfwRBXi = n39.MonoFlop_GeOV3KtNF5BPYMkYFPPAst.CreateDefault();
            this.__p_VR8cSPg0TUkMZxZDqWBH5o = n39.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_ATv4FbuJAkcLU1ZXfMWemK = n49.ADSR_NLdSdxoGgeXLodhNRpRhvv.CreateDefault();
            this.__p_D9Sex4dLjUvL9ekGBR2BZR = n39.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 102272U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "SlSlmKGg9qIODLUttv8B0r", Name = "__slot_SlSlmKGg9qIODLUttv8B0r")]
        public n27.IKeyboardMouseEvents __slot_SlSlmKGg9qIODLUttv8B0r;
        [n1.ElementAttribute(TracingId = 114009U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "JPB6RP0gC0NN8t89fyqEN1", Name = "__slot_JPB6RP0gC0NN8t89fyqEN1")]
        public bool __slot_JPB6RP0gC0NN8t89fyqEN1;
        [n1.ElementAttribute(TracingId = 122498U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "KPbqwyhr6YQNgX6BS8ql5L", Name = "__slot_KPbqwyhr6YQNgX6BS8ql5L")]
        public static float __slot_KPbqwyhr6YQNgX6BS8ql5L = 100F;
        [n1.ElementAttribute(TracingId = 122584U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "R8sCv46RWQ8QPDCmMwHhDQ", Name = "__slot_R8sCv46RWQ8QPDCmMwHhDQ")]
        public bool __slot_R8sCv46RWQ8QPDCmMwHhDQ;
        [n1.ElementAttribute(TracingId = 122649U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "B07EX9PIFedM4JLFEQ6dk6", Name = "__slot_B07EX9PIFedM4JLFEQ6dk6")]
        public n9.SkiaRenderer __slot_B07EX9PIFedM4JLFEQ6dk6;
        [n1.ElementAttribute(TracingId = 114121U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "AQW2dKygsvQNNL39bnlJRj", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n3.Vector2, n24.MouseButtons>> __p_AQW2dKygsvQNNL39bnlJRj;
        [n1.ElementAttribute(TracingId = 109482U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "RDj29p7sIoHOv0tmjhclhR", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n31.HoldLatest<n2.ValueTuple<n3.Vector2, n24.MouseButtons>> __p_RDj29p7sIoHOv0tmjhclhR;
        [n1.ElementAttribute(TracingId = 114020U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "DnxnjbpngnWPtCxRD42c90", Name = "FlipFlop", IsManaged = true, IsAutoGenerated = true)]
        public n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_DnxnjbpngnWPtCxRD42c90;
        [n1.ElementAttribute(TracingId = 114029U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "NuQj2EBWvfkOTDYI9PreKS", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n31.HoldLatest<n28.EventPattern<n24.MouseEventArgs>> __p_NuQj2EBWvfkOTDYI9PreKS;
        [n1.ElementAttribute(TracingId = 114235U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "I0TAHeMNDcUM0a1vVeO5Na", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n3.Vector2> __p_I0TAHeMNDcUM0a1vVeO5Na;
        [n1.ElementAttribute(TracingId = 109528U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "SOFwZ98qYP9MsBGzEhCPag", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n31.HoldLatest<n3.Vector2> __p_SOFwZ98qYP9MsBGzEhCPag;
        [n1.ElementAttribute(TracingId = 119820U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "EM5sKFgXyBWORIs9EiAcFU", Name = "FrameDifference", IsManaged = true, IsAutoGenerated = true)]
        public n58.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector2> __p_EM5sKFgXyBWORIs9EiAcFU;
        [n1.ElementAttribute(TracingId = 119881U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "VoxRTu6kt38L6dCpqjEQTn", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n39.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector2> __p_VoxRTu6kt38L6dCpqjEQTn;
        [n1.ElementAttribute(TracingId = 119894U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "GX1BuZtm1QUPsVdgWGuOr2", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
        public n39.SPH_RESwCzqU3iTMc4Ig82Av03<float> __p_GX1BuZtm1QUPsVdgWGuOr2;
        [n1.ElementAttribute(TracingId = 119850U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "OJKkGC54FEoMZYr9RhnnFZ", Name = "Damper", IsManaged = true, IsAutoGenerated = true)]
        public n55.Damper_Qhw7aQNplhrMCum2sxpG8z __p_OJKkGC54FEoMZYr9RhnnFZ;
        [n1.ElementAttribute(TracingId = 122518U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "G1Ygi0PExf1LsZEwApIro9", Name = "Stroke", IsManaged = true, IsAutoGenerated = true)]
        public n56.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_G1Ygi0PExf1LsZEwApIro9;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.SKStrokeJoin __c_EFRgRACtCiEPYOF5l8ZmIW = n1.CompilationHelper.Deserialize<n8.SKStrokeJoin>("Round", false, "HdxjuanrTAgOVJrlFMdlRO", "EFRgRACtCiEPYOF5l8ZmIW");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n8.SKStrokeCap __c_AO1ytRuXyuaOfqG6mRxPKG = n1.CompilationHelper.Deserialize<n8.SKStrokeCap>("Round", false, "HdxjuanrTAgOVJrlFMdlRO", "AO1ytRuXyuaOfqG6mRxPKG");
        [n1.ElementAttribute(TracingId = 114345U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "BCk78oVnVR2MhwVsV1A5NA", Name = "FlipFlop", IsManaged = true, IsAutoGenerated = true)]
        public n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_BCk78oVnVR2MhwVsV1A5NA;
        [n1.ElementAttribute(TracingId = 109567U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "VGRRqVB5GveNLDctIS5SJi", Name = "ForEach (Keep)", IsManaged = true, IsAutoGenerated = true)]
        public n31.ForEachKeep<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> __p_VGRRqVB5GveNLDctIS5SJi;
        [n1.ElementAttribute(TracingId = 110399U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "C4fbD5ilQxLK9VpRij25Bt", Name = "__slot_C4fbD5ilQxLK9VpRij25Bt")]
        public static float __slot_C4fbD5ilQxLK9VpRij25Bt = 0.2F;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n37.Key __c_CgOAZvD5FOFQNxpFLGOVW8 = n1.CompilationHelper.Deserialize<n37.Key>("Space", false, "HdxjuanrTAgOVJrlFMdlRO", "CgOAZvD5FOFQNxpFLGOVW8");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.Vector2 __c_TMS2htaVUiqNv3m0K1B5h3 = n1.CompilationHelper.Deserialize<n3.Vector2>("0.2, 0.5", false, "HdxjuanrTAgOVJrlFMdlRO", "TMS2htaVUiqNv3m0K1B5h3");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n24.MouseButtons __c_ACCuuqiSsPnP5U3HMMB2PL = n1.CompilationHelper.Deserialize<n24.MouseButtons>("XButton1", false, "HdxjuanrTAgOVJrlFMdlRO", "ACCuuqiSsPnP5U3HMMB2PL");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n24.MouseButtons __c_ENFfTjsqn3GNNX1SUEG0uD = n1.CompilationHelper.Deserialize<n24.MouseButtons>("XButton2", false, "HdxjuanrTAgOVJrlFMdlRO", "ENFfTjsqn3GNNX1SUEG0uD");
        [n1.ElementAttribute(TracingId = 110371U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "KiRAxb4TORmLdkRCqFtfS4", Name = "__slot_KiRAxb4TORmLdkRCqFtfS4")]
        public static float __slot_KiRAxb4TORmLdkRCqFtfS4 = 0.25F;
        [n1.ElementAttribute(TracingId = 110377U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "NBS1UN1PjUxNQc6BRoY33F", Name = "__slot_NBS1UN1PjUxNQc6BRoY33F")]
        public static float __slot_NBS1UN1PjUxNQc6BRoY33F = 0.5F;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.Vector2 __c_TRd8oPVcCbmORS0IKURdmC = n1.CompilationHelper.Deserialize<n3.Vector2>("1, 1", false, "HdxjuanrTAgOVJrlFMdlRO", "TRd8oPVcCbmORS0IKURdmC");
        [n1.ElementAttribute(TracingId = 109503U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "Ay5Is0ficrTLLUROwrtgII", Name = "FlipFlop", IsManaged = true, IsAutoGenerated = true)]
        public n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_Ay5Is0ficrTLLUROwrtgII;
        [n1.ElementAttribute(TracingId = 102287U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "GrekTHE3gejOt1YdfXKWEv", Name = "ForEach (Keep)", IsManaged = true, IsAutoGenerated = true)]
        public n31.ForEachKeep<n2.Object, n28.EventPattern<n24.KeyEventArgs>, n2.ValueTuple<n9.ILayer, float>> __p_GrekTHE3gejOt1YdfXKWEv;
        [n1.ElementAttribute(TracingId = 104736U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "FWTIzF12D3pP5G57tIP1AL", Name = "__slot_FWTIzF12D3pP5G57tIP1AL")]
        public static n11.Spread<n24.Keys> __slot_FWTIzF12D3pP5G57tIP1AL = n1.CompilationHelper.Deserialize<n11.Spread<n24.Keys>>("<Value xmlns=\"property\">\r\n  <Item xmlns=\"\">Back</Item>\r\n  <Item xmlns=\"\">Tab</Item>\r\n  <Item xmlns=\"\">Return</Item>\r\n  <Item xmlns=\"\">Escape</Item>\r\n  <Item xmlns=\"\">Space</Item>\r\n  <Item xmlns=\"\">Delete</Item>\r\n  <Item xmlns=\"\">F1</Item>\r\n  <Item xmlns=\"\">F2</Item>\r\n  <Item xmlns=\"\">F3</Item>\r\n  <Item xmlns=\"\">Left</Item>\r\n  <Item xmlns=\"\">Up</Item>\r\n  <Item xmlns=\"\">Right</Item>\r\n  <Item xmlns=\"\">Down</Item>\r\n  <Item xmlns=\"\">F11</Item>\r\n  <Item xmlns=\"\">F5</Item>\r\n  <Item xmlns=\"\">F6</Item>\r\n  <Item xmlns=\"\">F7</Item>\r\n  <Item xmlns=\"\">F8</Item>\r\n</Value>", true, "HdxjuanrTAgOVJrlFMdlRO", "FWTIzF12D3pP5G57tIP1AL");
        [n1.ElementAttribute(TracingId = 104725U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "BEDSGO2FbgnMv6PVEHTYtF", Name = "__slot_BEDSGO2FbgnMv6PVEHTYtF")]
        public static n11.Spread<n24.Keys> __slot_BEDSGO2FbgnMv6PVEHTYtF = n1.CompilationHelper.Deserialize<n11.Spread<n24.Keys>>("<Value xmlns=\"property\">\r\n  <Item xmlns=\"\">LShiftKey</Item>\r\n  <Item xmlns=\"\">RShiftKey</Item>\r\n  <Item xmlns=\"\">LControlKey</Item>\r\n  <Item xmlns=\"\">RControlKey</Item>\r\n  <Item xmlns=\"\">LMenu</Item>\r\n  <Item xmlns=\"\">RMenu</Item>\r\n  <Item xmlns=\"\">Oemcomma</Item>\r\n  <Item xmlns=\"\">OemPeriod</Item>\r\n  <Item xmlns=\"\">OemQuestion</Item>\r\n  <Item xmlns=\"\">Oemtilde</Item>\r\n  <Item xmlns=\"\">Oem1</Item>\r\n  <Item xmlns=\"\">Oem6</Item>\r\n  <Item xmlns=\"\">Oem7</Item>\r\n  <Item xmlns=\"\">OemOpenBrackets</Item>\r\n  <Item xmlns=\"\">OemClear</Item>\r\n  <Item xmlns=\"\">LButton</Item>\r\n  <Item xmlns=\"\">LWin</Item>\r\n  <Item xmlns=\"\">RWin</Item>\r\n</Value>", true, "HdxjuanrTAgOVJrlFMdlRO", "BEDSGO2FbgnMv6PVEHTYtF");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n2.StringSplitOptions __c_EtOrts5kZqDOwaL6OHWzyo = n1.CompilationHelper.Deserialize<n2.StringSplitOptions>("RemoveEmptyEntries", false, "HdxjuanrTAgOVJrlFMdlRO", "EtOrts5kZqDOwaL6OHWzyo");
        [n1.ElementAttribute(TracingId = 108618U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "JXL2eldziffOiEa6vykZ3I", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> __p_JXL2eldziffOiEa6vykZ3I;
        [n1.ElementAttribute(TracingId = 108867U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "GHtZAH1DAm3NGKv5RAY3eL", Name = "__slot_GHtZAH1DAm3NGKv5RAY3eL")]
        public static float __slot_GHtZAH1DAm3NGKv5RAY3eL = 0.08F;
        [n1.ElementAttribute(TracingId = 108873U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "UcWzglIahdtLRDUbj9jFiL", Name = "__slot_UcWzglIahdtLRDUbj9jFiL")]
        public static float __slot_UcWzglIahdtLRDUbj9jFiL = 0.2F;
        [n1.ElementAttribute(TracingId = 122479U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "BjYcVrcps6uLCc4z0BTMWT", Name = "Merge", IsManaged = true, IsAutoGenerated = true)]
        public n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>> __p_BjYcVrcps6uLCc4z0BTMWT;
        [n1.ElementAttribute(TracingId = 105005U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "L6JwULGAdkdMPHh4U3yr0y", Name = "ForEach (Keep)", IsManaged = true, IsAutoGenerated = true)]
        public n31.ForEachKeep<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> __p_L6JwULGAdkdMPHh4U3yr0y;
        [n1.ElementAttribute(TracingId = 108461U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "QugIhCBHcYwN3loRb4mzJq", Name = "__slot_QugIhCBHcYwN3loRb4mzJq")]
        public static float __slot_QugIhCBHcYwN3loRb4mzJq = 0.2F;
        [n1.ElementAttribute(TracingId = 109416U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "RnEbF1Oh3B9L9wK5bhZlBJ", Name = "Merge", IsManaged = true, IsAutoGenerated = true)]
        public n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>> __p_RnEbF1Oh3B9L9wK5bhZlBJ;
        [n1.ElementAttribute(TracingId = 108907U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "ABKnYN5Dp64M1rUtsVoMDP", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> __p_ABKnYN5Dp64M1rUtsVoMDP;
        [n1.ElementAttribute(TracingId = 108884U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "IKnAExjizzjNeQE7o0VZiF", Name = "Merge", IsManaged = true, IsAutoGenerated = true)]
        public n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>> __p_IKnAExjizzjNeQE7o0VZiF;
        [n1.ElementAttribute(TracingId = 109548U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "Vop1QgprklHPb4KtPiKLtl", Name = "Merge", IsManaged = true, IsAutoGenerated = true)]
        public n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>> __p_Vop1QgprklHPb4KtPiKLtl;
        [n1.ElementAttribute(TracingId = 108488U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "BdqpmsCFAodQXJH61mwCWr", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n31.HoldLatest<n2.ValueTuple<n9.ILayer, float>> __p_BdqpmsCFAodQXJH61mwCWr;
        [n1.ElementAttribute(TracingId = 122560U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "OhDArnQcUcsNO69JN5vmmi", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n31.HoldLatest<n2.ValueTuple<n9.ILayer, float>> __p_OhDArnQcUcsNO69JN5vmmi;
        [n1.ElementAttribute(TracingId = 119918U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "SozMDkLfzfDNUtCf9rkEf7", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n46.Manager<n2.ValueTuple, n2.ValueTuple<n45.Rectangle>> __cache_SozMDkLfzfDNUtCf9rkEf7 = null;
        [n1.ElementAttribute(TracingId = 122588U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "PQHgsdD70DGOIOazcN71hQ", Name = "SkiaWindowTopmost", IsManaged = true, IsAutoGenerated = true)]
        public n51.SkiaWindowTopmost_C __p_PQHgsdD70DGOIOazcN71hQ;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n24.FormBorderStyle __c_L81Yd1cAOC1M9bySoFGABQ = n1.CompilationHelper.Deserialize<n24.FormBorderStyle>("None", false, "HdxjuanrTAgOVJrlFMdlRO", "L81Yd1cAOC1M9bySoFGABQ");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.Color4 __c_Gzk2Kjzseo1MDcmPGhFXWy = n1.CompilationHelper.Deserialize<n3.Color4>("0.1, 0.1, 0.1, 1", false, "HdxjuanrTAgOVJrlFMdlRO", "Gzk2Kjzseo1MDcmPGhFXWy");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n9.CommonSpace __c_TnAZgcfB0KdLuYKopyNLVG = n1.CompilationHelper.Deserialize<n9.CommonSpace>("DIPTopLeft", false, "HdxjuanrTAgOVJrlFMdlRO", "TnAZgcfB0KdLuYKopyNLVG");
        [n1.ElementAttribute(TracingId = 108518U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "EmCIi08GYR3OyiTSfwRBXi", Name = "MonoFlop", IsManaged = true, IsAutoGenerated = true)]
        public n39.MonoFlop_GeOV3KtNF5BPYMkYFPPAst __p_EmCIi08GYR3OyiTSfwRBXi;
        [n1.ElementAttribute(TracingId = 114110U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "VR8cSPg0TUkMZxZDqWBH5o", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n39.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_VR8cSPg0TUkMZxZDqWBH5o;
        [n1.ElementAttribute(TracingId = 114039U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "ATv4FbuJAkcLU1ZXfMWemK", Name = "ADSR", IsManaged = true, IsAutoGenerated = true)]
        public n49.ADSR_NLdSdxoGgeXLodhNRpRhvv __p_ATv4FbuJAkcLU1ZXfMWemK;
        [n1.ElementAttribute(TracingId = 108599U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "D9Sex4dLjUvL9ekGBR2BZR", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n39.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_D9Sex4dLjUvL9ekGBR2BZR;
        static KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC()
        {
        }

        public KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC(KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC other): base(other)
        {
            this.__slot_SlSlmKGg9qIODLUttv8B0r = other.__slot_SlSlmKGg9qIODLUttv8B0r;
            this.__slot_JPB6RP0gC0NN8t89fyqEN1 = other.__slot_JPB6RP0gC0NN8t89fyqEN1;
            this.__slot_R8sCv46RWQ8QPDCmMwHhDQ = other.__slot_R8sCv46RWQ8QPDCmMwHhDQ;
            this.__slot_B07EX9PIFedM4JLFEQ6dk6 = other.__slot_B07EX9PIFedM4JLFEQ6dk6;
            this.__p_AQW2dKygsvQNNL39bnlJRj = other.__p_AQW2dKygsvQNNL39bnlJRj;
            this.__p_RDj29p7sIoHOv0tmjhclhR = other.__p_RDj29p7sIoHOv0tmjhclhR;
            this.__p_DnxnjbpngnWPtCxRD42c90 = other.__p_DnxnjbpngnWPtCxRD42c90;
            this.__p_NuQj2EBWvfkOTDYI9PreKS = other.__p_NuQj2EBWvfkOTDYI9PreKS;
            this.__p_I0TAHeMNDcUM0a1vVeO5Na = other.__p_I0TAHeMNDcUM0a1vVeO5Na;
            this.__p_SOFwZ98qYP9MsBGzEhCPag = other.__p_SOFwZ98qYP9MsBGzEhCPag;
            this.__p_EM5sKFgXyBWORIs9EiAcFU = other.__p_EM5sKFgXyBWORIs9EiAcFU;
            this.__p_VoxRTu6kt38L6dCpqjEQTn = other.__p_VoxRTu6kt38L6dCpqjEQTn;
            this.__p_GX1BuZtm1QUPsVdgWGuOr2 = other.__p_GX1BuZtm1QUPsVdgWGuOr2;
            this.__p_OJKkGC54FEoMZYr9RhnnFZ = other.__p_OJKkGC54FEoMZYr9RhnnFZ;
            this.__p_G1Ygi0PExf1LsZEwApIro9 = other.__p_G1Ygi0PExf1LsZEwApIro9;
            this.__p_BCk78oVnVR2MhwVsV1A5NA = other.__p_BCk78oVnVR2MhwVsV1A5NA;
            this.__p_VGRRqVB5GveNLDctIS5SJi = other.__p_VGRRqVB5GveNLDctIS5SJi;
            this.__p_Ay5Is0ficrTLLUROwrtgII = other.__p_Ay5Is0ficrTLLUROwrtgII;
            this.__p_GrekTHE3gejOt1YdfXKWEv = other.__p_GrekTHE3gejOt1YdfXKWEv;
            this.__p_JXL2eldziffOiEa6vykZ3I = other.__p_JXL2eldziffOiEa6vykZ3I;
            this.__p_BjYcVrcps6uLCc4z0BTMWT = other.__p_BjYcVrcps6uLCc4z0BTMWT;
            this.__p_L6JwULGAdkdMPHh4U3yr0y = other.__p_L6JwULGAdkdMPHh4U3yr0y;
            this.__p_RnEbF1Oh3B9L9wK5bhZlBJ = other.__p_RnEbF1Oh3B9L9wK5bhZlBJ;
            this.__p_ABKnYN5Dp64M1rUtsVoMDP = other.__p_ABKnYN5Dp64M1rUtsVoMDP;
            this.__p_IKnAExjizzjNeQE7o0VZiF = other.__p_IKnAExjizzjNeQE7o0VZiF;
            this.__p_Vop1QgprklHPb4KtPiKLtl = other.__p_Vop1QgprklHPb4KtPiKLtl;
            this.__p_BdqpmsCFAodQXJH61mwCWr = other.__p_BdqpmsCFAodQXJH61mwCWr;
            this.__p_OhDArnQcUcsNO69JN5vmmi = other.__p_OhDArnQcUcsNO69JN5vmmi;
            this.__cache_SozMDkLfzfDNUtCf9rkEf7 = other.__cache_SozMDkLfzfDNUtCf9rkEf7;
            this.__p_PQHgsdD70DGOIOazcN71hQ = other.__p_PQHgsdD70DGOIOazcN71hQ;
            this.__p_EmCIi08GYR3OyiTSfwRBXi = other.__p_EmCIi08GYR3OyiTSfwRBXi;
            this.__p_VR8cSPg0TUkMZxZDqWBH5o = other.__p_VR8cSPg0TUkMZxZDqWBH5o;
            this.__p_ATv4FbuJAkcLU1ZXfMWemK = other.__p_ATv4FbuJAkcLU1ZXfMWemK;
            this.__p_D9Sex4dLjUvL9ekGBR2BZR = other.__p_D9Sex4dLjUvL9ekGBR2BZR;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_SlSlmKGg9qIODLUttv8B0r", in __slot_SlSlmKGg9qIODLUttv8B0r), n1.CompilationHelper.GetValueOrExisting(values, "__slot_JPB6RP0gC0NN8t89fyqEN1", in __slot_JPB6RP0gC0NN8t89fyqEN1), n1.CompilationHelper.GetValueOrExisting(values, "__slot_R8sCv46RWQ8QPDCmMwHhDQ", in __slot_R8sCv46RWQ8QPDCmMwHhDQ), n1.CompilationHelper.GetValueOrExisting(values, "__slot_B07EX9PIFedM4JLFEQ6dk6", in __slot_B07EX9PIFedM4JLFEQ6dk6), n1.CompilationHelper.GetValueOrExisting(values, "__p_AQW2dKygsvQNNL39bnlJRj", in __p_AQW2dKygsvQNNL39bnlJRj), n1.CompilationHelper.GetValueOrExisting(values, "__p_RDj29p7sIoHOv0tmjhclhR", in __p_RDj29p7sIoHOv0tmjhclhR), n1.CompilationHelper.GetValueOrExisting(values, "__p_DnxnjbpngnWPtCxRD42c90", in __p_DnxnjbpngnWPtCxRD42c90), n1.CompilationHelper.GetValueOrExisting(values, "__p_NuQj2EBWvfkOTDYI9PreKS", in __p_NuQj2EBWvfkOTDYI9PreKS), n1.CompilationHelper.GetValueOrExisting(values, "__p_I0TAHeMNDcUM0a1vVeO5Na", in __p_I0TAHeMNDcUM0a1vVeO5Na), n1.CompilationHelper.GetValueOrExisting(values, "__p_SOFwZ98qYP9MsBGzEhCPag", in __p_SOFwZ98qYP9MsBGzEhCPag), n1.CompilationHelper.GetValueOrExisting(values, "__p_EM5sKFgXyBWORIs9EiAcFU", in __p_EM5sKFgXyBWORIs9EiAcFU), n1.CompilationHelper.GetValueOrExisting(values, "__p_VoxRTu6kt38L6dCpqjEQTn", in __p_VoxRTu6kt38L6dCpqjEQTn), n1.CompilationHelper.GetValueOrExisting(values, "__p_GX1BuZtm1QUPsVdgWGuOr2", in __p_GX1BuZtm1QUPsVdgWGuOr2), n1.CompilationHelper.GetValueOrExisting(values, "__p_OJKkGC54FEoMZYr9RhnnFZ", in __p_OJKkGC54FEoMZYr9RhnnFZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_G1Ygi0PExf1LsZEwApIro9", in __p_G1Ygi0PExf1LsZEwApIro9), n1.CompilationHelper.GetValueOrExisting(values, "__p_BCk78oVnVR2MhwVsV1A5NA", in __p_BCk78oVnVR2MhwVsV1A5NA), n1.CompilationHelper.GetValueOrExisting(values, "__p_VGRRqVB5GveNLDctIS5SJi", in __p_VGRRqVB5GveNLDctIS5SJi), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ay5Is0ficrTLLUROwrtgII", in __p_Ay5Is0ficrTLLUROwrtgII), n1.CompilationHelper.GetValueOrExisting(values, "__p_GrekTHE3gejOt1YdfXKWEv", in __p_GrekTHE3gejOt1YdfXKWEv), n1.CompilationHelper.GetValueOrExisting(values, "__p_JXL2eldziffOiEa6vykZ3I", in __p_JXL2eldziffOiEa6vykZ3I), n1.CompilationHelper.GetValueOrExisting(values, "__p_BjYcVrcps6uLCc4z0BTMWT", in __p_BjYcVrcps6uLCc4z0BTMWT), n1.CompilationHelper.GetValueOrExisting(values, "__p_L6JwULGAdkdMPHh4U3yr0y", in __p_L6JwULGAdkdMPHh4U3yr0y), n1.CompilationHelper.GetValueOrExisting(values, "__p_RnEbF1Oh3B9L9wK5bhZlBJ", in __p_RnEbF1Oh3B9L9wK5bhZlBJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_ABKnYN5Dp64M1rUtsVoMDP", in __p_ABKnYN5Dp64M1rUtsVoMDP), n1.CompilationHelper.GetValueOrExisting(values, "__p_IKnAExjizzjNeQE7o0VZiF", in __p_IKnAExjizzjNeQE7o0VZiF), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vop1QgprklHPb4KtPiKLtl", in __p_Vop1QgprklHPb4KtPiKLtl), n1.CompilationHelper.GetValueOrExisting(values, "__p_BdqpmsCFAodQXJH61mwCWr", in __p_BdqpmsCFAodQXJH61mwCWr), n1.CompilationHelper.GetValueOrExisting(values, "__p_OhDArnQcUcsNO69JN5vmmi", in __p_OhDArnQcUcsNO69JN5vmmi), n1.CompilationHelper.GetValueOrExisting(values, "__cache_SozMDkLfzfDNUtCf9rkEf7", in __cache_SozMDkLfzfDNUtCf9rkEf7), n1.CompilationHelper.GetValueOrExisting(values, "__p_PQHgsdD70DGOIOazcN71hQ", in __p_PQHgsdD70DGOIOazcN71hQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_EmCIi08GYR3OyiTSfwRBXi", in __p_EmCIi08GYR3OyiTSfwRBXi), n1.CompilationHelper.GetValueOrExisting(values, "__p_VR8cSPg0TUkMZxZDqWBH5o", in __p_VR8cSPg0TUkMZxZDqWBH5o), n1.CompilationHelper.GetValueOrExisting(values, "__p_ATv4FbuJAkcLU1ZXfMWemK", in __p_ATv4FbuJAkcLU1ZXfMWemK), n1.CompilationHelper.GetValueOrExisting(values, "__p_D9Sex4dLjUvL9ekGBR2BZR", in __p_D9Sex4dLjUvL9ekGBR2BZR));
        }

        internal KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC __WITH__(n27.IKeyboardMouseEvents __slot_SlSlmKGg9qIODLUttv8B0r, bool __slot_JPB6RP0gC0NN8t89fyqEN1, bool __slot_R8sCv46RWQ8QPDCmMwHhDQ, n9.SkiaRenderer __slot_B07EX9PIFedM4JLFEQ6dk6, n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n3.Vector2, n24.MouseButtons>> __p_AQW2dKygsvQNNL39bnlJRj, n31.HoldLatest<n2.ValueTuple<n3.Vector2, n24.MouseButtons>> __p_RDj29p7sIoHOv0tmjhclhR, n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_DnxnjbpngnWPtCxRD42c90, n31.HoldLatest<n28.EventPattern<n24.MouseEventArgs>> __p_NuQj2EBWvfkOTDYI9PreKS, n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n3.Vector2> __p_I0TAHeMNDcUM0a1vVeO5Na, n31.HoldLatest<n3.Vector2> __p_SOFwZ98qYP9MsBGzEhCPag, n58.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n3.Vector2> __p_EM5sKFgXyBWORIs9EiAcFU, n39.Changed_A8JGbead2bxNdnPybiEqVS<n3.Vector2> __p_VoxRTu6kt38L6dCpqjEQTn, n39.SPH_RESwCzqU3iTMc4Ig82Av03<float> __p_GX1BuZtm1QUPsVdgWGuOr2, n55.Damper_Qhw7aQNplhrMCum2sxpG8z __p_OJKkGC54FEoMZYr9RhnnFZ, n56.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_G1Ygi0PExf1LsZEwApIro9, n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_BCk78oVnVR2MhwVsV1A5NA, n31.ForEachKeep<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> __p_VGRRqVB5GveNLDctIS5SJi, n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_Ay5Is0ficrTLLUROwrtgII, n31.ForEachKeep<n2.Object, n28.EventPattern<n24.KeyEventArgs>, n2.ValueTuple<n9.ILayer, float>> __p_GrekTHE3gejOt1YdfXKWEv, n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> __p_JXL2eldziffOiEa6vykZ3I, n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>> __p_BjYcVrcps6uLCc4z0BTMWT, n31.ForEachKeep<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> __p_L6JwULGAdkdMPHh4U3yr0y, n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>> __p_RnEbF1Oh3B9L9wK5bhZlBJ, n31.ForEach<n2.Object, n28.EventPattern<n24.MouseEventArgs>, n2.ValueTuple<n9.ILayer, float>> __p_ABKnYN5Dp64M1rUtsVoMDP, n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>> __p_IKnAExjizzjNeQE7o0VZiF, n54.Merge_LnnZZkStd9UPhJSxj0GRf7<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>, n2.ValueTuple<n9.ILayer, float>, n2.IObservable<n2.ValueTuple<n9.ILayer, float>>> __p_Vop1QgprklHPb4KtPiKLtl, n31.HoldLatest<n2.ValueTuple<n9.ILayer, float>> __p_BdqpmsCFAodQXJH61mwCWr, n31.HoldLatest<n2.ValueTuple<n9.ILayer, float>> __p_OhDArnQcUcsNO69JN5vmmi, n46.Manager<n2.ValueTuple, n2.ValueTuple<n45.Rectangle>> __cache_SozMDkLfzfDNUtCf9rkEf7, n51.SkiaWindowTopmost_C __p_PQHgsdD70DGOIOazcN71hQ, n39.MonoFlop_GeOV3KtNF5BPYMkYFPPAst __p_EmCIi08GYR3OyiTSfwRBXi, n39.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_VR8cSPg0TUkMZxZDqWBH5o, n49.ADSR_NLdSdxoGgeXLodhNRpRhvv __p_ATv4FbuJAkcLU1ZXfMWemK, n39.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_D9Sex4dLjUvL9ekGBR2BZR)
        {
            n4.KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = __slot_SlSlmKGg9qIODLUttv8B0r != this.__slot_SlSlmKGg9qIODLUttv8B0r || __slot_JPB6RP0gC0NN8t89fyqEN1 != this.__slot_JPB6RP0gC0NN8t89fyqEN1 || __slot_R8sCv46RWQ8QPDCmMwHhDQ != this.__slot_R8sCv46RWQ8QPDCmMwHhDQ || __slot_B07EX9PIFedM4JLFEQ6dk6 != this.__slot_B07EX9PIFedM4JLFEQ6dk6 || __p_AQW2dKygsvQNNL39bnlJRj != this.__p_AQW2dKygsvQNNL39bnlJRj || __p_RDj29p7sIoHOv0tmjhclhR != this.__p_RDj29p7sIoHOv0tmjhclhR || __p_DnxnjbpngnWPtCxRD42c90 != this.__p_DnxnjbpngnWPtCxRD42c90 || __p_NuQj2EBWvfkOTDYI9PreKS != this.__p_NuQj2EBWvfkOTDYI9PreKS || __p_I0TAHeMNDcUM0a1vVeO5Na != this.__p_I0TAHeMNDcUM0a1vVeO5Na || __p_SOFwZ98qYP9MsBGzEhCPag != this.__p_SOFwZ98qYP9MsBGzEhCPag || __p_EM5sKFgXyBWORIs9EiAcFU != this.__p_EM5sKFgXyBWORIs9EiAcFU || __p_VoxRTu6kt38L6dCpqjEQTn != this.__p_VoxRTu6kt38L6dCpqjEQTn || __p_GX1BuZtm1QUPsVdgWGuOr2 != this.__p_GX1BuZtm1QUPsVdgWGuOr2 || __p_OJKkGC54FEoMZYr9RhnnFZ != this.__p_OJKkGC54FEoMZYr9RhnnFZ || __p_G1Ygi0PExf1LsZEwApIro9 != this.__p_G1Ygi0PExf1LsZEwApIro9 || __p_BCk78oVnVR2MhwVsV1A5NA != this.__p_BCk78oVnVR2MhwVsV1A5NA || __p_VGRRqVB5GveNLDctIS5SJi != this.__p_VGRRqVB5GveNLDctIS5SJi || __p_Ay5Is0ficrTLLUROwrtgII != this.__p_Ay5Is0ficrTLLUROwrtgII || __p_GrekTHE3gejOt1YdfXKWEv != this.__p_GrekTHE3gejOt1YdfXKWEv || __p_JXL2eldziffOiEa6vykZ3I != this.__p_JXL2eldziffOiEa6vykZ3I || __p_BjYcVrcps6uLCc4z0BTMWT != this.__p_BjYcVrcps6uLCc4z0BTMWT || __p_L6JwULGAdkdMPHh4U3yr0y != this.__p_L6JwULGAdkdMPHh4U3yr0y || __p_RnEbF1Oh3B9L9wK5bhZlBJ != this.__p_RnEbF1Oh3B9L9wK5bhZlBJ || __p_ABKnYN5Dp64M1rUtsVoMDP != this.__p_ABKnYN5Dp64M1rUtsVoMDP || __p_IKnAExjizzjNeQE7o0VZiF != this.__p_IKnAExjizzjNeQE7o0VZiF || __p_Vop1QgprklHPb4KtPiKLtl != this.__p_Vop1QgprklHPb4KtPiKLtl || __p_BdqpmsCFAodQXJH61mwCWr != this.__p_BdqpmsCFAodQXJH61mwCWr || __p_OhDArnQcUcsNO69JN5vmmi != this.__p_OhDArnQcUcsNO69JN5vmmi || __cache_SozMDkLfzfDNUtCf9rkEf7 != this.__cache_SozMDkLfzfDNUtCf9rkEf7 || __p_PQHgsdD70DGOIOazcN71hQ != this.__p_PQHgsdD70DGOIOazcN71hQ || __p_EmCIi08GYR3OyiTSfwRBXi != this.__p_EmCIi08GYR3OyiTSfwRBXi || __p_VR8cSPg0TUkMZxZDqWBH5o != this.__p_VR8cSPg0TUkMZxZDqWBH5o || __p_ATv4FbuJAkcLU1ZXfMWemK != this.__p_ATv4FbuJAkcLU1ZXfMWemK || __p_D9Sex4dLjUvL9ekGBR2BZR != this.__p_D9Sex4dLjUvL9ekGBR2BZR ? new KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC(this)
                {__slot_SlSlmKGg9qIODLUttv8B0r = __slot_SlSlmKGg9qIODLUttv8B0r, __slot_JPB6RP0gC0NN8t89fyqEN1 = __slot_JPB6RP0gC0NN8t89fyqEN1, __slot_R8sCv46RWQ8QPDCmMwHhDQ = __slot_R8sCv46RWQ8QPDCmMwHhDQ, __slot_B07EX9PIFedM4JLFEQ6dk6 = __slot_B07EX9PIFedM4JLFEQ6dk6, __p_AQW2dKygsvQNNL39bnlJRj = __p_AQW2dKygsvQNNL39bnlJRj, __p_RDj29p7sIoHOv0tmjhclhR = __p_RDj29p7sIoHOv0tmjhclhR, __p_DnxnjbpngnWPtCxRD42c90 = __p_DnxnjbpngnWPtCxRD42c90, __p_NuQj2EBWvfkOTDYI9PreKS = __p_NuQj2EBWvfkOTDYI9PreKS, __p_I0TAHeMNDcUM0a1vVeO5Na = __p_I0TAHeMNDcUM0a1vVeO5Na, __p_SOFwZ98qYP9MsBGzEhCPag = __p_SOFwZ98qYP9MsBGzEhCPag, __p_EM5sKFgXyBWORIs9EiAcFU = __p_EM5sKFgXyBWORIs9EiAcFU, __p_VoxRTu6kt38L6dCpqjEQTn = __p_VoxRTu6kt38L6dCpqjEQTn, __p_GX1BuZtm1QUPsVdgWGuOr2 = __p_GX1BuZtm1QUPsVdgWGuOr2, __p_OJKkGC54FEoMZYr9RhnnFZ = __p_OJKkGC54FEoMZYr9RhnnFZ, __p_G1Ygi0PExf1LsZEwApIro9 = __p_G1Ygi0PExf1LsZEwApIro9, __p_BCk78oVnVR2MhwVsV1A5NA = __p_BCk78oVnVR2MhwVsV1A5NA, __p_VGRRqVB5GveNLDctIS5SJi = __p_VGRRqVB5GveNLDctIS5SJi, __p_Ay5Is0ficrTLLUROwrtgII = __p_Ay5Is0ficrTLLUROwrtgII, __p_GrekTHE3gejOt1YdfXKWEv = __p_GrekTHE3gejOt1YdfXKWEv, __p_JXL2eldziffOiEa6vykZ3I = __p_JXL2eldziffOiEa6vykZ3I, __p_BjYcVrcps6uLCc4z0BTMWT = __p_BjYcVrcps6uLCc4z0BTMWT, __p_L6JwULGAdkdMPHh4U3yr0y = __p_L6JwULGAdkdMPHh4U3yr0y, __p_RnEbF1Oh3B9L9wK5bhZlBJ = __p_RnEbF1Oh3B9L9wK5bhZlBJ, __p_ABKnYN5Dp64M1rUtsVoMDP = __p_ABKnYN5Dp64M1rUtsVoMDP, __p_IKnAExjizzjNeQE7o0VZiF = __p_IKnAExjizzjNeQE7o0VZiF, __p_Vop1QgprklHPb4KtPiKLtl = __p_Vop1QgprklHPb4KtPiKLtl, __p_BdqpmsCFAodQXJH61mwCWr = __p_BdqpmsCFAodQXJH61mwCWr, __p_OhDArnQcUcsNO69JN5vmmi = __p_OhDArnQcUcsNO69JN5vmmi, __cache_SozMDkLfzfDNUtCf9rkEf7 = __cache_SozMDkLfzfDNUtCf9rkEf7, __p_PQHgsdD70DGOIOazcN71hQ = __p_PQHgsdD70DGOIOazcN71hQ, __p_EmCIi08GYR3OyiTSfwRBXi = __p_EmCIi08GYR3OyiTSfwRBXi, __p_VR8cSPg0TUkMZxZDqWBH5o = __p_VR8cSPg0TUkMZxZDqWBH5o, __p_ATv4FbuJAkcLU1ZXfMWemK = __p_ATv4FbuJAkcLU1ZXfMWemK, __p_D9Sex4dLjUvL9ekGBR2BZR = __p_D9Sex4dLjUvL9ekGBR2BZR} : that_1;
            else
            {
                this.__slot_SlSlmKGg9qIODLUttv8B0r = __slot_SlSlmKGg9qIODLUttv8B0r;
                this.__slot_JPB6RP0gC0NN8t89fyqEN1 = __slot_JPB6RP0gC0NN8t89fyqEN1;
                this.__slot_R8sCv46RWQ8QPDCmMwHhDQ = __slot_R8sCv46RWQ8QPDCmMwHhDQ;
                this.__slot_B07EX9PIFedM4JLFEQ6dk6 = __slot_B07EX9PIFedM4JLFEQ6dk6;
                this.__p_AQW2dKygsvQNNL39bnlJRj = __p_AQW2dKygsvQNNL39bnlJRj;
                this.__p_RDj29p7sIoHOv0tmjhclhR = __p_RDj29p7sIoHOv0tmjhclhR;
                this.__p_DnxnjbpngnWPtCxRD42c90 = __p_DnxnjbpngnWPtCxRD42c90;
                this.__p_NuQj2EBWvfkOTDYI9PreKS = __p_NuQj2EBWvfkOTDYI9PreKS;
                this.__p_I0TAHeMNDcUM0a1vVeO5Na = __p_I0TAHeMNDcUM0a1vVeO5Na;
                this.__p_SOFwZ98qYP9MsBGzEhCPag = __p_SOFwZ98qYP9MsBGzEhCPag;
                this.__p_EM5sKFgXyBWORIs9EiAcFU = __p_EM5sKFgXyBWORIs9EiAcFU;
                this.__p_VoxRTu6kt38L6dCpqjEQTn = __p_VoxRTu6kt38L6dCpqjEQTn;
                this.__p_GX1BuZtm1QUPsVdgWGuOr2 = __p_GX1BuZtm1QUPsVdgWGuOr2;
                this.__p_OJKkGC54FEoMZYr9RhnnFZ = __p_OJKkGC54FEoMZYr9RhnnFZ;
                this.__p_G1Ygi0PExf1LsZEwApIro9 = __p_G1Ygi0PExf1LsZEwApIro9;
                this.__p_BCk78oVnVR2MhwVsV1A5NA = __p_BCk78oVnVR2MhwVsV1A5NA;
                this.__p_VGRRqVB5GveNLDctIS5SJi = __p_VGRRqVB5GveNLDctIS5SJi;
                this.__p_Ay5Is0ficrTLLUROwrtgII = __p_Ay5Is0ficrTLLUROwrtgII;
                this.__p_GrekTHE3gejOt1YdfXKWEv = __p_GrekTHE3gejOt1YdfXKWEv;
                this.__p_JXL2eldziffOiEa6vykZ3I = __p_JXL2eldziffOiEa6vykZ3I;
                this.__p_BjYcVrcps6uLCc4z0BTMWT = __p_BjYcVrcps6uLCc4z0BTMWT;
                this.__p_L6JwULGAdkdMPHh4U3yr0y = __p_L6JwULGAdkdMPHh4U3yr0y;
                this.__p_RnEbF1Oh3B9L9wK5bhZlBJ = __p_RnEbF1Oh3B9L9wK5bhZlBJ;
                this.__p_ABKnYN5Dp64M1rUtsVoMDP = __p_ABKnYN5Dp64M1rUtsVoMDP;
                this.__p_IKnAExjizzjNeQE7o0VZiF = __p_IKnAExjizzjNeQE7o0VZiF;
                this.__p_Vop1QgprklHPb4KtPiKLtl = __p_Vop1QgprklHPb4KtPiKLtl;
                this.__p_BdqpmsCFAodQXJH61mwCWr = __p_BdqpmsCFAodQXJH61mwCWr;
                this.__p_OhDArnQcUcsNO69JN5vmmi = __p_OhDArnQcUcsNO69JN5vmmi;
                this.__cache_SozMDkLfzfDNUtCf9rkEf7 = __cache_SozMDkLfzfDNUtCf9rkEf7;
                this.__p_PQHgsdD70DGOIOazcN71hQ = __p_PQHgsdD70DGOIOazcN71hQ;
                this.__p_EmCIi08GYR3OyiTSfwRBXi = __p_EmCIi08GYR3OyiTSfwRBXi;
                this.__p_VR8cSPg0TUkMZxZDqWBH5o = __p_VR8cSPg0TUkMZxZDqWBH5o;
                this.__p_ATv4FbuJAkcLU1ZXfMWemK = __p_ATv4FbuJAkcLU1ZXfMWemK;
                this.__p_D9Sex4dLjUvL9ekGBR2BZR = __p_D9Sex4dLjUvL9ekGBR2BZR;
            }

            return that_1;
        }

        [n1.ElementAttribute(DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "RwpFCWDvt0GOJNACytaIUF", Name = "__RwpFCWDvt0GOJNACytaIUF")]
        [n2.SerializableAttribute]
        public class __RwpFCWDvt0GOJNACytaIUF : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __RwpFCWDvt0GOJNACytaIUF(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RwpFCWDvt0GOJNACytaIUF(__RwpFCWDvt0GOJNACytaIUF other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __RwpFCWDvt0GOJNACytaIUF __WITH__()
            {
                return this;
            }
        }

        [n1.ElementAttribute(DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "S99ZaqXhqarNeLjONRwWdr", Name = "__S99ZaqXhqarNeLjONRwWdr")]
        [n2.SerializableAttribute]
        public class __S99ZaqXhqarNeLjONRwWdr : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __S99ZaqXhqarNeLjONRwWdr(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __S99ZaqXhqarNeLjONRwWdr(__S99ZaqXhqarNeLjONRwWdr other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __S99ZaqXhqarNeLjONRwWdr __WITH__()
            {
                return this;
            }
        }

        [n1.ElementAttribute(DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "SbWHLKsj3HTLgVJptxA6Po", Name = "__SbWHLKsj3HTLgVJptxA6Po")]
        [n2.SerializableAttribute]
        public class __SbWHLKsj3HTLgVJptxA6Po : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_T81cslpP4cqPkoERSEaQxo);
                n1.CompilationHelper.SafeDispose(this.__p_CfipLZzc051LkvpNvivzJC);
                n1.CompilationHelper.SafeDispose(this.__p_L8Ubmg86p0fMnzjaRlwTdV);
                n1.CompilationHelper.SafeDispose(this.__p_Ok8G4Vp67NYLFPn1PyN3ws);
                n1.CompilationHelper.SafeDispose(this.__if_C3pLdlv7a8YLrKlremyNwr);
                n1.CompilationHelper.SafeDispose(this.__p_Qtj1Viwp36kLNT3WNCFEIk);
                return;
            }

            [n1.ElementAttribute(TracingId = 110075U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "T81cslpP4cqPkoERSEaQxo", Name = "DrawKeys", IsManaged = true, IsAutoGenerated = true)]
            public n4.DrawKeys_DONOgIrpGTxOwISujK9hgd __p_T81cslpP4cqPkoERSEaQxo;
            [n1.ElementAttribute(TracingId = 110179U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "CfipLZzc051LkvpNvivzJC", Name = "DrawKey", IsManaged = true, IsAutoGenerated = true)]
            public n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa __p_CfipLZzc051LkvpNvivzJC;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n9.ILayer> __pin_group_Input_In_QhdIHN049XlMHqwWfYhEil = default(n11.Spread<n9.ILayer>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<float> __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0 = default(n11.Spread<float>);
            [n1.ElementAttribute(TracingId = 110089U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "L8Ubmg86p0fMnzjaRlwTdV", Name = "DrawMouse", IsManaged = true, IsAutoGenerated = true)]
            public n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP __p_L8Ubmg86p0fMnzjaRlwTdV;
            [n1.ElementAttribute(TracingId = 110098U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "Ok8G4Vp67NYLFPn1PyN3ws", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n6.Group_TKtMtIW1WMIOfh4AlYkjTy __p_Ok8G4Vp67NYLFPn1PyN3ws;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n9.ILayer> __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws = default(n11.Spread<n9.ILayer>);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_C3pLdlv7a8YLrKlremyNwr;
            [n1.ElementAttribute(TracingId = 110113U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "Qtj1Viwp36kLNT3WNCFEIk", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n6.Group_TKtMtIW1WMIOfh4AlYkjTy __p_Qtj1Viwp36kLNT3WNCFEIk;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n9.ILayer> __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk = default(n11.Spread<n9.ILayer>);
            public __SbWHLKsj3HTLgVJptxA6Po(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SbWHLKsj3HTLgVJptxA6Po(__SbWHLKsj3HTLgVJptxA6Po other): base(other)
            {
                this.__p_T81cslpP4cqPkoERSEaQxo = other.__p_T81cslpP4cqPkoERSEaQxo;
                this.__p_CfipLZzc051LkvpNvivzJC = other.__p_CfipLZzc051LkvpNvivzJC;
                this.__pin_group_Input_In_QhdIHN049XlMHqwWfYhEil = other.__pin_group_Input_In_QhdIHN049XlMHqwWfYhEil;
                this.__pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0 = other.__pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0;
                this.__p_L8Ubmg86p0fMnzjaRlwTdV = other.__p_L8Ubmg86p0fMnzjaRlwTdV;
                this.__p_Ok8G4Vp67NYLFPn1PyN3ws = other.__p_Ok8G4Vp67NYLFPn1PyN3ws;
                this.__pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws = other.__pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws;
                this.__if_C3pLdlv7a8YLrKlremyNwr = other.__if_C3pLdlv7a8YLrKlremyNwr;
                this.__p_Qtj1Viwp36kLNT3WNCFEIk = other.__p_Qtj1Viwp36kLNT3WNCFEIk;
                this.__pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk = other.__pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_T81cslpP4cqPkoERSEaQxo", in __p_T81cslpP4cqPkoERSEaQxo), n1.CompilationHelper.GetValueOrExisting(values, "__p_CfipLZzc051LkvpNvivzJC", in __p_CfipLZzc051LkvpNvivzJC), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_QhdIHN049XlMHqwWfYhEil", in __pin_group_Input_In_QhdIHN049XlMHqwWfYhEil), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0", in __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0), n1.CompilationHelper.GetValueOrExisting(values, "__p_L8Ubmg86p0fMnzjaRlwTdV", in __p_L8Ubmg86p0fMnzjaRlwTdV), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ok8G4Vp67NYLFPn1PyN3ws", in __p_Ok8G4Vp67NYLFPn1PyN3ws), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws", in __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws), n1.CompilationHelper.GetValueOrExisting(values, "__if_C3pLdlv7a8YLrKlremyNwr", in __if_C3pLdlv7a8YLrKlremyNwr), n1.CompilationHelper.GetValueOrExisting(values, "__p_Qtj1Viwp36kLNT3WNCFEIk", in __p_Qtj1Viwp36kLNT3WNCFEIk), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk", in __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk));
            }

            internal __SbWHLKsj3HTLgVJptxA6Po __WITH__(n4.DrawKeys_DONOgIrpGTxOwISujK9hgd __p_T81cslpP4cqPkoERSEaQxo, n4.DrawKey_NCVcptwtgOkMpka9Cw7AMa __p_CfipLZzc051LkvpNvivzJC, n11.Spread<n9.ILayer> __pin_group_Input_In_QhdIHN049XlMHqwWfYhEil, n11.Spread<float> __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0, n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP __p_L8Ubmg86p0fMnzjaRlwTdV, n6.Group_TKtMtIW1WMIOfh4AlYkjTy __p_Ok8G4Vp67NYLFPn1PyN3ws, n11.Spread<n9.ILayer> __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws, n2.Object __if_C3pLdlv7a8YLrKlremyNwr, n6.Group_TKtMtIW1WMIOfh4AlYkjTy __p_Qtj1Viwp36kLNT3WNCFEIk, n11.Spread<n9.ILayer> __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk)
            {
                __SbWHLKsj3HTLgVJptxA6Po that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_T81cslpP4cqPkoERSEaQxo != this.__p_T81cslpP4cqPkoERSEaQxo || __p_CfipLZzc051LkvpNvivzJC != this.__p_CfipLZzc051LkvpNvivzJC || __pin_group_Input_In_QhdIHN049XlMHqwWfYhEil != this.__pin_group_Input_In_QhdIHN049XlMHqwWfYhEil || __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0 != this.__pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0 || __p_L8Ubmg86p0fMnzjaRlwTdV != this.__p_L8Ubmg86p0fMnzjaRlwTdV || __p_Ok8G4Vp67NYLFPn1PyN3ws != this.__p_Ok8G4Vp67NYLFPn1PyN3ws || __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws != this.__pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws || __if_C3pLdlv7a8YLrKlremyNwr != this.__if_C3pLdlv7a8YLrKlremyNwr || __p_Qtj1Viwp36kLNT3WNCFEIk != this.__p_Qtj1Viwp36kLNT3WNCFEIk || __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk != this.__pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk ? new __SbWHLKsj3HTLgVJptxA6Po(this)
                    {__p_T81cslpP4cqPkoERSEaQxo = __p_T81cslpP4cqPkoERSEaQxo, __p_CfipLZzc051LkvpNvivzJC = __p_CfipLZzc051LkvpNvivzJC, __pin_group_Input_In_QhdIHN049XlMHqwWfYhEil = __pin_group_Input_In_QhdIHN049XlMHqwWfYhEil, __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0 = __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0, __p_L8Ubmg86p0fMnzjaRlwTdV = __p_L8Ubmg86p0fMnzjaRlwTdV, __p_Ok8G4Vp67NYLFPn1PyN3ws = __p_Ok8G4Vp67NYLFPn1PyN3ws, __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws = __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws, __if_C3pLdlv7a8YLrKlremyNwr = __if_C3pLdlv7a8YLrKlremyNwr, __p_Qtj1Viwp36kLNT3WNCFEIk = __p_Qtj1Viwp36kLNT3WNCFEIk, __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk = __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk} : that_0;
                else
                {
                    this.__p_T81cslpP4cqPkoERSEaQxo = __p_T81cslpP4cqPkoERSEaQxo;
                    this.__p_CfipLZzc051LkvpNvivzJC = __p_CfipLZzc051LkvpNvivzJC;
                    this.__pin_group_Input_In_QhdIHN049XlMHqwWfYhEil = __pin_group_Input_In_QhdIHN049XlMHqwWfYhEil;
                    this.__pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0 = __pin_group_Input_In_DT8HBYVV5xZPeprk2JAXY0;
                    this.__p_L8Ubmg86p0fMnzjaRlwTdV = __p_L8Ubmg86p0fMnzjaRlwTdV;
                    this.__p_Ok8G4Vp67NYLFPn1PyN3ws = __p_Ok8G4Vp67NYLFPn1PyN3ws;
                    this.__pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws = __pin_group_Input_In_Ok8G4Vp67NYLFPn1PyN3ws;
                    this.__if_C3pLdlv7a8YLrKlremyNwr = __if_C3pLdlv7a8YLrKlremyNwr;
                    this.__p_Qtj1Viwp36kLNT3WNCFEIk = __p_Qtj1Viwp36kLNT3WNCFEIk;
                    this.__pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk = __pin_group_Input_In_Qtj1Viwp36kLNT3WNCFEIk;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "GMBFy5T3Xz5NCqAqLrHW7S", Name = "__GMBFy5T3Xz5NCqAqLrHW7S")]
        [n2.SerializableAttribute]
        public class __GMBFy5T3Xz5NCqAqLrHW7S : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_NgfWx7xvADdN5XoJrDgymU);
                n1.CompilationHelper.SafeDispose(this.__p_LMJLqVqlGN0MIrJnGgpgz5);
                n1.CompilationHelper.SafeDispose(this.__p_DZMkbZHn5jMMcBXPde3kAj);
                return;
            }

            [n1.ElementAttribute(TracingId = 110295U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "NgfWx7xvADdN5XoJrDgymU", Name = "Arrow", IsManaged = true, IsAutoGenerated = true)]
            public n14.Arrow_LkmkJWVjwT1N0iaFX8x0DS __p_NgfWx7xvADdN5XoJrDgymU;
            [n1.ElementAttribute(TracingId = 110328U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "LMJLqVqlGN0MIrJnGgpgz5", Name = "TransformSRT", IsManaged = true, IsAutoGenerated = true)]
            public n40.TransformSRT_Oc7C6Oc4qP6M6mhsHRSy9b __p_LMJLqVqlGN0MIrJnGgpgz5;
            [n1.ElementAttribute(TracingId = 110381U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "DZMkbZHn5jMMcBXPde3kAj", Name = "S+H", IsManaged = true, IsAutoGenerated = true)]
            public n39.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector2> __p_DZMkbZHn5jMMcBXPde3kAj;
            public __GMBFy5T3Xz5NCqAqLrHW7S(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __GMBFy5T3Xz5NCqAqLrHW7S(__GMBFy5T3Xz5NCqAqLrHW7S other): base(other)
            {
                this.__p_NgfWx7xvADdN5XoJrDgymU = other.__p_NgfWx7xvADdN5XoJrDgymU;
                this.__p_LMJLqVqlGN0MIrJnGgpgz5 = other.__p_LMJLqVqlGN0MIrJnGgpgz5;
                this.__p_DZMkbZHn5jMMcBXPde3kAj = other.__p_DZMkbZHn5jMMcBXPde3kAj;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NgfWx7xvADdN5XoJrDgymU", in __p_NgfWx7xvADdN5XoJrDgymU), n1.CompilationHelper.GetValueOrExisting(values, "__p_LMJLqVqlGN0MIrJnGgpgz5", in __p_LMJLqVqlGN0MIrJnGgpgz5), n1.CompilationHelper.GetValueOrExisting(values, "__p_DZMkbZHn5jMMcBXPde3kAj", in __p_DZMkbZHn5jMMcBXPde3kAj));
            }

            internal __GMBFy5T3Xz5NCqAqLrHW7S __WITH__(n14.Arrow_LkmkJWVjwT1N0iaFX8x0DS __p_NgfWx7xvADdN5XoJrDgymU, n40.TransformSRT_Oc7C6Oc4qP6M6mhsHRSy9b __p_LMJLqVqlGN0MIrJnGgpgz5, n39.SPH_RESwCzqU3iTMc4Ig82Av03<n3.Vector2> __p_DZMkbZHn5jMMcBXPde3kAj)
            {
                __GMBFy5T3Xz5NCqAqLrHW7S that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_NgfWx7xvADdN5XoJrDgymU != this.__p_NgfWx7xvADdN5XoJrDgymU || __p_LMJLqVqlGN0MIrJnGgpgz5 != this.__p_LMJLqVqlGN0MIrJnGgpgz5 || __p_DZMkbZHn5jMMcBXPde3kAj != this.__p_DZMkbZHn5jMMcBXPde3kAj ? new __GMBFy5T3Xz5NCqAqLrHW7S(this)
                    {__p_NgfWx7xvADdN5XoJrDgymU = __p_NgfWx7xvADdN5XoJrDgymU, __p_LMJLqVqlGN0MIrJnGgpgz5 = __p_LMJLqVqlGN0MIrJnGgpgz5, __p_DZMkbZHn5jMMcBXPde3kAj = __p_DZMkbZHn5jMMcBXPde3kAj} : that_0;
                else
                {
                    this.__p_NgfWx7xvADdN5XoJrDgymU = __p_NgfWx7xvADdN5XoJrDgymU;
                    this.__p_LMJLqVqlGN0MIrJnGgpgz5 = __p_LMJLqVqlGN0MIrJnGgpgz5;
                    this.__p_DZMkbZHn5jMMcBXPde3kAj = __p_DZMkbZHn5jMMcBXPde3kAj;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "UuUDRmNZsKgPaEZw3U7sBA", Name = "__UuUDRmNZsKgPaEZw3U7sBA")]
        [n2.SerializableAttribute]
        public class __UuUDRmNZsKgPaEZw3U7sBA : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__if_GQ6bHKuC6vvMAD2GnvsGX1);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_GQ6bHKuC6vvMAD2GnvsGX1;
            public __UuUDRmNZsKgPaEZw3U7sBA(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __UuUDRmNZsKgPaEZw3U7sBA(__UuUDRmNZsKgPaEZw3U7sBA other): base(other)
            {
                this.__if_GQ6bHKuC6vvMAD2GnvsGX1 = other.__if_GQ6bHKuC6vvMAD2GnvsGX1;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_GQ6bHKuC6vvMAD2GnvsGX1", in __if_GQ6bHKuC6vvMAD2GnvsGX1));
            }

            internal __UuUDRmNZsKgPaEZw3U7sBA __WITH__(n2.Object __if_GQ6bHKuC6vvMAD2GnvsGX1)
            {
                __UuUDRmNZsKgPaEZw3U7sBA that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __if_GQ6bHKuC6vvMAD2GnvsGX1 != this.__if_GQ6bHKuC6vvMAD2GnvsGX1 ? new __UuUDRmNZsKgPaEZw3U7sBA(this)
                    {__if_GQ6bHKuC6vvMAD2GnvsGX1 = __if_GQ6bHKuC6vvMAD2GnvsGX1} : that_0;
                else
                {
                    this.__if_GQ6bHKuC6vvMAD2GnvsGX1 = __if_GQ6bHKuC6vvMAD2GnvsGX1;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "CuKAY065O80OeRVwaEaw0p", Name = "__CuKAY065O80OeRVwaEaw0p")]
        [n2.SerializableAttribute]
        public class __CuKAY065O80OeRVwaEaw0p : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_OpD9q2PWmJINB0Q9awv6Ey);
                return;
            }

            [n1.ElementAttribute(TracingId = 104855U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "OpD9q2PWmJINB0Q9awv6Ey", Name = "DrawKeys", IsManaged = true, IsAutoGenerated = true)]
            public n4.DrawKeys_DONOgIrpGTxOwISujK9hgd __p_OpD9q2PWmJINB0Q9awv6Ey;
            public __CuKAY065O80OeRVwaEaw0p(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CuKAY065O80OeRVwaEaw0p(__CuKAY065O80OeRVwaEaw0p other): base(other)
            {
                this.__p_OpD9q2PWmJINB0Q9awv6Ey = other.__p_OpD9q2PWmJINB0Q9awv6Ey;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_OpD9q2PWmJINB0Q9awv6Ey", in __p_OpD9q2PWmJINB0Q9awv6Ey));
            }

            internal __CuKAY065O80OeRVwaEaw0p __WITH__(n4.DrawKeys_DONOgIrpGTxOwISujK9hgd __p_OpD9q2PWmJINB0Q9awv6Ey)
            {
                __CuKAY065O80OeRVwaEaw0p that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_OpD9q2PWmJINB0Q9awv6Ey != this.__p_OpD9q2PWmJINB0Q9awv6Ey ? new __CuKAY065O80OeRVwaEaw0p(this)
                    {__p_OpD9q2PWmJINB0Q9awv6Ey = __p_OpD9q2PWmJINB0Q9awv6Ey} : that_0;
                else
                {
                    this.__p_OpD9q2PWmJINB0Q9awv6Ey = __p_OpD9q2PWmJINB0Q9awv6Ey;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "BBZkl7iEFqrMygSwdR5mRH", Name = "__BBZkl7iEFqrMygSwdR5mRH")]
        [n2.SerializableAttribute]
        public class __BBZkl7iEFqrMygSwdR5mRH : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_FxLm7GG39LJNts6M8ILPB8);
                n1.CompilationHelper.SafeDispose(this.__p_CadzXvZML8KMz54M4bl9rz);
                n1.CompilationHelper.SafeDispose(this.__p_LtEMtwczbnHLfeCqDtiq1k);
                n1.CompilationHelper.SafeDispose(this.__p_Th8QUGyL87DO3XDEu6cfpi);
                return;
            }

            [n1.ElementAttribute(TracingId = 108821U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "FxLm7GG39LJNts6M8ILPB8", Name = "DrawKeys", IsManaged = true, IsAutoGenerated = true)]
            public n4.DrawKeys_DONOgIrpGTxOwISujK9hgd __p_FxLm7GG39LJNts6M8ILPB8;
            [n1.ElementAttribute(TracingId = 108713U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "CadzXvZML8KMz54M4bl9rz", Name = "DrawMouse", IsManaged = true, IsAutoGenerated = true)]
            public n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP __p_CadzXvZML8KMz54M4bl9rz;
            [n1.ElementAttribute(TracingId = 108760U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "LtEMtwczbnHLfeCqDtiq1k", Name = "DrawMouse", IsManaged = true, IsAutoGenerated = true)]
            public n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP __p_LtEMtwczbnHLfeCqDtiq1k;
            [n1.ElementAttribute(TracingId = 108740U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "Th8QUGyL87DO3XDEu6cfpi", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n6.Group_TKtMtIW1WMIOfh4AlYkjTy __p_Th8QUGyL87DO3XDEu6cfpi;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n9.ILayer> __pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi = default(n11.Spread<n9.ILayer>);
            [n1.ElementAttribute(TracingId = 108734U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "FcXDWwwvaJnLxzEcIy0Dqh", Name = "__slot_FcXDWwwvaJnLxzEcIy0Dqh")]
            public n24.MouseButtons __slot_FcXDWwwvaJnLxzEcIy0Dqh;
            public __BBZkl7iEFqrMygSwdR5mRH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BBZkl7iEFqrMygSwdR5mRH(__BBZkl7iEFqrMygSwdR5mRH other): base(other)
            {
                this.__p_FxLm7GG39LJNts6M8ILPB8 = other.__p_FxLm7GG39LJNts6M8ILPB8;
                this.__p_CadzXvZML8KMz54M4bl9rz = other.__p_CadzXvZML8KMz54M4bl9rz;
                this.__p_LtEMtwczbnHLfeCqDtiq1k = other.__p_LtEMtwczbnHLfeCqDtiq1k;
                this.__p_Th8QUGyL87DO3XDEu6cfpi = other.__p_Th8QUGyL87DO3XDEu6cfpi;
                this.__pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi = other.__pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi;
                this.__slot_FcXDWwwvaJnLxzEcIy0Dqh = other.__slot_FcXDWwwvaJnLxzEcIy0Dqh;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FxLm7GG39LJNts6M8ILPB8", in __p_FxLm7GG39LJNts6M8ILPB8), n1.CompilationHelper.GetValueOrExisting(values, "__p_CadzXvZML8KMz54M4bl9rz", in __p_CadzXvZML8KMz54M4bl9rz), n1.CompilationHelper.GetValueOrExisting(values, "__p_LtEMtwczbnHLfeCqDtiq1k", in __p_LtEMtwczbnHLfeCqDtiq1k), n1.CompilationHelper.GetValueOrExisting(values, "__p_Th8QUGyL87DO3XDEu6cfpi", in __p_Th8QUGyL87DO3XDEu6cfpi), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi", in __pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi), n1.CompilationHelper.GetValueOrExisting(values, "__slot_FcXDWwwvaJnLxzEcIy0Dqh", in __slot_FcXDWwwvaJnLxzEcIy0Dqh));
            }

            internal __BBZkl7iEFqrMygSwdR5mRH __WITH__(n4.DrawKeys_DONOgIrpGTxOwISujK9hgd __p_FxLm7GG39LJNts6M8ILPB8, n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP __p_CadzXvZML8KMz54M4bl9rz, n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP __p_LtEMtwczbnHLfeCqDtiq1k, n6.Group_TKtMtIW1WMIOfh4AlYkjTy __p_Th8QUGyL87DO3XDEu6cfpi, n11.Spread<n9.ILayer> __pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi, n24.MouseButtons __slot_FcXDWwwvaJnLxzEcIy0Dqh)
            {
                __BBZkl7iEFqrMygSwdR5mRH that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_FxLm7GG39LJNts6M8ILPB8 != this.__p_FxLm7GG39LJNts6M8ILPB8 || __p_CadzXvZML8KMz54M4bl9rz != this.__p_CadzXvZML8KMz54M4bl9rz || __p_LtEMtwczbnHLfeCqDtiq1k != this.__p_LtEMtwczbnHLfeCqDtiq1k || __p_Th8QUGyL87DO3XDEu6cfpi != this.__p_Th8QUGyL87DO3XDEu6cfpi || __pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi != this.__pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi || !n17.EqualityComparer<n24.MouseButtons>.Default.Equals(__slot_FcXDWwwvaJnLxzEcIy0Dqh, this.__slot_FcXDWwwvaJnLxzEcIy0Dqh) ? new __BBZkl7iEFqrMygSwdR5mRH(this)
                    {__p_FxLm7GG39LJNts6M8ILPB8 = __p_FxLm7GG39LJNts6M8ILPB8, __p_CadzXvZML8KMz54M4bl9rz = __p_CadzXvZML8KMz54M4bl9rz, __p_LtEMtwczbnHLfeCqDtiq1k = __p_LtEMtwczbnHLfeCqDtiq1k, __p_Th8QUGyL87DO3XDEu6cfpi = __p_Th8QUGyL87DO3XDEu6cfpi, __pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi = __pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi, __slot_FcXDWwwvaJnLxzEcIy0Dqh = __slot_FcXDWwwvaJnLxzEcIy0Dqh} : that_0;
                else
                {
                    this.__p_FxLm7GG39LJNts6M8ILPB8 = __p_FxLm7GG39LJNts6M8ILPB8;
                    this.__p_CadzXvZML8KMz54M4bl9rz = __p_CadzXvZML8KMz54M4bl9rz;
                    this.__p_LtEMtwczbnHLfeCqDtiq1k = __p_LtEMtwczbnHLfeCqDtiq1k;
                    this.__p_Th8QUGyL87DO3XDEu6cfpi = __p_Th8QUGyL87DO3XDEu6cfpi;
                    this.__pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi = __pin_group_Input_In_Th8QUGyL87DO3XDEu6cfpi;
                    this.__slot_FcXDWwwvaJnLxzEcIy0Dqh = __slot_FcXDWwwvaJnLxzEcIy0Dqh;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "VlugX6glk3LMurswztv4uf", Name = "__VlugX6glk3LMurswztv4uf")]
        [n2.SerializableAttribute]
        public class __VlugX6glk3LMurswztv4uf : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Cp4IQLE7bDbQZfixmZ8RXv);
                n1.CompilationHelper.SafeDispose(this.__p_NF6WVBymvKOPjE463Q3mj2);
                n1.CompilationHelper.SafeDispose(this.__p_HwQ1r0wFc2pP2ftGq5HM7N);
                return;
            }

            [n1.ElementAttribute(TracingId = 108431U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "HNntx2Kh5PwOcmLAZOtK5e", Name = "__slot_HNntx2Kh5PwOcmLAZOtK5e")]
            public string __slot_HNntx2Kh5PwOcmLAZOtK5e;
            [n1.ElementAttribute(TracingId = 108353U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "Cp4IQLE7bDbQZfixmZ8RXv", Name = "DrawKeys", IsManaged = true, IsAutoGenerated = true)]
            public n4.DrawKeys_DONOgIrpGTxOwISujK9hgd __p_Cp4IQLE7bDbQZfixmZ8RXv;
            [n1.ElementAttribute(TracingId = 108390U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "NF6WVBymvKOPjE463Q3mj2", Name = "DrawMouse", IsManaged = true, IsAutoGenerated = true)]
            public n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP __p_NF6WVBymvKOPjE463Q3mj2;
            [n1.ElementAttribute(TracingId = 108436U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "HwQ1r0wFc2pP2ftGq5HM7N", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n6.Group_TKtMtIW1WMIOfh4AlYkjTy __p_HwQ1r0wFc2pP2ftGq5HM7N;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n9.ILayer> __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N = default(n11.Spread<n9.ILayer>);
            [n1.ElementAttribute(TracingId = 108471U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "Q1FGDRw8Uh0OyiedCCyczk", Name = "__slot_Q1FGDRw8Uh0OyiedCCyczk")]
            public n24.MouseButtons __slot_Q1FGDRw8Uh0OyiedCCyczk;
            public __VlugX6glk3LMurswztv4uf(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __VlugX6glk3LMurswztv4uf(__VlugX6glk3LMurswztv4uf other): base(other)
            {
                this.__slot_HNntx2Kh5PwOcmLAZOtK5e = other.__slot_HNntx2Kh5PwOcmLAZOtK5e;
                this.__p_Cp4IQLE7bDbQZfixmZ8RXv = other.__p_Cp4IQLE7bDbQZfixmZ8RXv;
                this.__p_NF6WVBymvKOPjE463Q3mj2 = other.__p_NF6WVBymvKOPjE463Q3mj2;
                this.__p_HwQ1r0wFc2pP2ftGq5HM7N = other.__p_HwQ1r0wFc2pP2ftGq5HM7N;
                this.__pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N = other.__pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N;
                this.__slot_Q1FGDRw8Uh0OyiedCCyczk = other.__slot_Q1FGDRw8Uh0OyiedCCyczk;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_HNntx2Kh5PwOcmLAZOtK5e", in __slot_HNntx2Kh5PwOcmLAZOtK5e), n1.CompilationHelper.GetValueOrExisting(values, "__p_Cp4IQLE7bDbQZfixmZ8RXv", in __p_Cp4IQLE7bDbQZfixmZ8RXv), n1.CompilationHelper.GetValueOrExisting(values, "__p_NF6WVBymvKOPjE463Q3mj2", in __p_NF6WVBymvKOPjE463Q3mj2), n1.CompilationHelper.GetValueOrExisting(values, "__p_HwQ1r0wFc2pP2ftGq5HM7N", in __p_HwQ1r0wFc2pP2ftGq5HM7N), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N", in __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Q1FGDRw8Uh0OyiedCCyczk", in __slot_Q1FGDRw8Uh0OyiedCCyczk));
            }

            internal __VlugX6glk3LMurswztv4uf __WITH__(string __slot_HNntx2Kh5PwOcmLAZOtK5e, n4.DrawKeys_DONOgIrpGTxOwISujK9hgd __p_Cp4IQLE7bDbQZfixmZ8RXv, n4.DrawMouse_P62WKsOuGkIN5sB0M73gdP __p_NF6WVBymvKOPjE463Q3mj2, n6.Group_TKtMtIW1WMIOfh4AlYkjTy __p_HwQ1r0wFc2pP2ftGq5HM7N, n11.Spread<n9.ILayer> __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N, n24.MouseButtons __slot_Q1FGDRw8Uh0OyiedCCyczk)
            {
                __VlugX6glk3LMurswztv4uf that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __slot_HNntx2Kh5PwOcmLAZOtK5e != this.__slot_HNntx2Kh5PwOcmLAZOtK5e || __p_Cp4IQLE7bDbQZfixmZ8RXv != this.__p_Cp4IQLE7bDbQZfixmZ8RXv || __p_NF6WVBymvKOPjE463Q3mj2 != this.__p_NF6WVBymvKOPjE463Q3mj2 || __p_HwQ1r0wFc2pP2ftGq5HM7N != this.__p_HwQ1r0wFc2pP2ftGq5HM7N || __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N != this.__pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N || !n17.EqualityComparer<n24.MouseButtons>.Default.Equals(__slot_Q1FGDRw8Uh0OyiedCCyczk, this.__slot_Q1FGDRw8Uh0OyiedCCyczk) ? new __VlugX6glk3LMurswztv4uf(this)
                    {__slot_HNntx2Kh5PwOcmLAZOtK5e = __slot_HNntx2Kh5PwOcmLAZOtK5e, __p_Cp4IQLE7bDbQZfixmZ8RXv = __p_Cp4IQLE7bDbQZfixmZ8RXv, __p_NF6WVBymvKOPjE463Q3mj2 = __p_NF6WVBymvKOPjE463Q3mj2, __p_HwQ1r0wFc2pP2ftGq5HM7N = __p_HwQ1r0wFc2pP2ftGq5HM7N, __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N = __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N, __slot_Q1FGDRw8Uh0OyiedCCyczk = __slot_Q1FGDRw8Uh0OyiedCCyczk} : that_0;
                else
                {
                    this.__slot_HNntx2Kh5PwOcmLAZOtK5e = __slot_HNntx2Kh5PwOcmLAZOtK5e;
                    this.__p_Cp4IQLE7bDbQZfixmZ8RXv = __p_Cp4IQLE7bDbQZfixmZ8RXv;
                    this.__p_NF6WVBymvKOPjE463Q3mj2 = __p_NF6WVBymvKOPjE463Q3mj2;
                    this.__p_HwQ1r0wFc2pP2ftGq5HM7N = __p_HwQ1r0wFc2pP2ftGq5HM7N;
                    this.__pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N = __pin_group_Input_In_HwQ1r0wFc2pP2ftGq5HM7N;
                    this.__slot_Q1FGDRw8Uh0OyiedCCyczk = __slot_Q1FGDRw8Uh0OyiedCCyczk;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "RnUdAiXpnytQS6Dh2GiuQc", Name = "__RnUdAiXpnytQS6Dh2GiuQc")]
        [n2.SerializableAttribute]
        public class __RnUdAiXpnytQS6Dh2GiuQc : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_VDFrubCKKTWNgKU88EAGX5);
                n1.CompilationHelper.SafeDispose(this.__p_F1yL4yu6pqjLjWiByNxDSo);
                n1.CompilationHelper.SafeDispose(this.__p_FA2iWmhHAwNMixC3fxoReU);
                return;
            }

            [n1.ElementAttribute(TracingId = 108994U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "VDFrubCKKTWNgKU88EAGX5", Name = "DrawKeys", IsManaged = true, IsAutoGenerated = true)]
            public n4.DrawKeys_DONOgIrpGTxOwISujK9hgd __p_VDFrubCKKTWNgKU88EAGX5;
            [n1.ElementAttribute(TracingId = 109035U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "F1yL4yu6pqjLjWiByNxDSo", Name = "DrawMouseWheel", IsManaged = true, IsAutoGenerated = true)]
            public n4.DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 __p_F1yL4yu6pqjLjWiByNxDSo;
            [n1.ElementAttribute(TracingId = 109364U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "FA2iWmhHAwNMixC3fxoReU", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n6.Group_TKtMtIW1WMIOfh4AlYkjTy __p_FA2iWmhHAwNMixC3fxoReU;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n9.ILayer> __pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU = default(n11.Spread<n9.ILayer>);
            public __RnUdAiXpnytQS6Dh2GiuQc(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RnUdAiXpnytQS6Dh2GiuQc(__RnUdAiXpnytQS6Dh2GiuQc other): base(other)
            {
                this.__p_VDFrubCKKTWNgKU88EAGX5 = other.__p_VDFrubCKKTWNgKU88EAGX5;
                this.__p_F1yL4yu6pqjLjWiByNxDSo = other.__p_F1yL4yu6pqjLjWiByNxDSo;
                this.__p_FA2iWmhHAwNMixC3fxoReU = other.__p_FA2iWmhHAwNMixC3fxoReU;
                this.__pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU = other.__pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VDFrubCKKTWNgKU88EAGX5", in __p_VDFrubCKKTWNgKU88EAGX5), n1.CompilationHelper.GetValueOrExisting(values, "__p_F1yL4yu6pqjLjWiByNxDSo", in __p_F1yL4yu6pqjLjWiByNxDSo), n1.CompilationHelper.GetValueOrExisting(values, "__p_FA2iWmhHAwNMixC3fxoReU", in __p_FA2iWmhHAwNMixC3fxoReU), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU", in __pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU));
            }

            internal __RnUdAiXpnytQS6Dh2GiuQc __WITH__(n4.DrawKeys_DONOgIrpGTxOwISujK9hgd __p_VDFrubCKKTWNgKU88EAGX5, n4.DrawMouseWheel_BrepNO5Cc7NMY9wQspcYt3 __p_F1yL4yu6pqjLjWiByNxDSo, n6.Group_TKtMtIW1WMIOfh4AlYkjTy __p_FA2iWmhHAwNMixC3fxoReU, n11.Spread<n9.ILayer> __pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU)
            {
                __RnUdAiXpnytQS6Dh2GiuQc that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_VDFrubCKKTWNgKU88EAGX5 != this.__p_VDFrubCKKTWNgKU88EAGX5 || __p_F1yL4yu6pqjLjWiByNxDSo != this.__p_F1yL4yu6pqjLjWiByNxDSo || __p_FA2iWmhHAwNMixC3fxoReU != this.__p_FA2iWmhHAwNMixC3fxoReU || __pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU != this.__pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU ? new __RnUdAiXpnytQS6Dh2GiuQc(this)
                    {__p_VDFrubCKKTWNgKU88EAGX5 = __p_VDFrubCKKTWNgKU88EAGX5, __p_F1yL4yu6pqjLjWiByNxDSo = __p_F1yL4yu6pqjLjWiByNxDSo, __p_FA2iWmhHAwNMixC3fxoReU = __p_FA2iWmhHAwNMixC3fxoReU, __pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU = __pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU} : that_0;
                else
                {
                    this.__p_VDFrubCKKTWNgKU88EAGX5 = __p_VDFrubCKKTWNgKU88EAGX5;
                    this.__p_F1yL4yu6pqjLjWiByNxDSo = __p_F1yL4yu6pqjLjWiByNxDSo;
                    this.__p_FA2iWmhHAwNMixC3fxoReU = __p_FA2iWmhHAwNMixC3fxoReU;
                    this.__pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU = __pin_group_Input_In_FA2iWmhHAwNMixC3fxoReU;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 124556U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "DsCLB6EoFC6NEyeO7Mm33J", Name = "KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J")]
    [n2.SerializableAttribute]
    public class KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J Create(n1.NodeContext Node_Context)
        {
            var instance = new KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J CreateDefault()
        {
            var instance = new KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J Update()
        {
            string __pad_G2VEFR9OsIsN6W2QMkoaq7_0 = __slot_G2VEFR9OsIsN6W2QMkoaq7;
            n24.Keys Shortcut_1 = __c_NxeJuXtMCfoMXORbsssnMr;
            bool Visible_2 = true;
            bool Enabled_3 = true;
            var Output_5 = this.__p_VerHuaGBKIWPDUoaIAP0zC.Update(Name_In: __pad_G2VEFR9OsIsN6W2QMkoaq7_0, Shortcut_In: Shortcut_1, Visible_In: Visible_2, Enabled_In: Enabled_3, On_Execute_Out: out n2.IObservable<bool> On_Execute_4);
            bool Reset_6 = false;
            bool Update_7 = true;
            var Output_8 = this.__p_LnlKP2Bu29FOJJ1Aik5e4R;
            if (Update_7)
            {
                n33._Operations_.Update_H<bool>(Input_In: this.__p_LnlKP2Bu29FOJJ1Aik5e4R, Async_Notifications_In: On_Execute_4, Reset_In: Reset_6, Output_Out: out Output_8);
            }

            n33._Operations_.GetData_H<bool>(Input_In: Output_8, Output_Out: out n31.HoldLatest<bool> Output_9, Value_Out: out bool Value_10, On_Data_Out: out bool On_Data_11);
            var Output_12 = this.__p_D2cIHHBtEfnNmapLTi9GsJ;
            if (On_Data_11)
            {
                Output_12 = this.__p_D2cIHHBtEfnNmapLTi9GsJ.Flip();
            }

            var Output_14 = Output_12.GetValue(Value_Out: out bool Value_13);
            int Iteration_Count_15 = n2.Convert.ToInt32(Value_13);
            var manager_23 = this.__loop_DDyzlfmjfsCN58HMKcvLe9 ?? new n19.ImmutableLifetimeManager();
            var iterator_24 = manager_23.GetIterator(__GetContext__());
            try
            {
                for (var i_16 = 0; i_16 < Iteration_Count_15; i_16++)
                {
                    var i_local_17 = i_16;
                    __FxY4Fn8TuUyMDLDPPsChsk state_18;
                    if (!iterator_24.MoveNext(out state_18))
                    {
                        iterator_24.Add(state_18 = new __FxY4Fn8TuUyMDLDPPsChsk(__GetContext__(), n1.VLObject.NewIdentity()));
                        n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "IzP4ir8eWYuNHXCmnLPKKk", 124566U);
                        var Output_20 = n4.KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC.Create(Node_Context: Node_Context_19);
                        state_18.__p_IzP4ir8eWYuNHXCmnLPKKk = Output_20;
                    }

                    bool Update_21 = true;
                    var Output_22 = state_18.__p_IzP4ir8eWYuNHXCmnLPKKk;
                    if (Update_21)
                    {
                        Output_22 = state_18.__p_IzP4ir8eWYuNHXCmnLPKKk.Update();
                    }

                    if (state_18.__GetContext__().IsImmutable)
                        state_18 = Output_22 != state_18.__p_IzP4ir8eWYuNHXCmnLPKKk ? new __FxY4Fn8TuUyMDLDPPsChsk(state_18)
                        {__p_IzP4ir8eWYuNHXCmnLPKKk = Output_22} : state_18;
                    else
                    {
                        state_18.__p_IzP4ir8eWYuNHXCmnLPKKk = Output_22;
                    }

                    iterator_24.Update(state_18);
                }
            }
            finally
            {
                manager_23 = iterator_24.Commit();
            }

            n4.KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = Output_5 != this.__p_VerHuaGBKIWPDUoaIAP0zC || Output_9 != this.__p_LnlKP2Bu29FOJJ1Aik5e4R || Output_14 != this.__p_D2cIHHBtEfnNmapLTi9GsJ || manager_23 != this.__loop_DDyzlfmjfsCN58HMKcvLe9 ? new KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J(this)
                {__p_VerHuaGBKIWPDUoaIAP0zC = Output_5, __p_LnlKP2Bu29FOJJ1Aik5e4R = Output_9, __p_D2cIHHBtEfnNmapLTi9GsJ = Output_14, __loop_DDyzlfmjfsCN58HMKcvLe9 = manager_23} : that_25;
            else
            {
                this.__p_VerHuaGBKIWPDUoaIAP0zC = Output_5;
                this.__p_LnlKP2Bu29FOJJ1Aik5e4R = Output_9;
                this.__p_D2cIHHBtEfnNmapLTi9GsJ = Output_14;
                this.__loop_DDyzlfmjfsCN58HMKcvLe9 = manager_23;
            }

            return that_25;
        }

        public n4.KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "D2cIHHBtEfnNmapLTi9GsJ", 124570U);
            var Output_1 = n39.Toggle_NRtjXBFlZv8LkW1dAEOgnz.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "VerHuaGBKIWPDUoaIAP0zC", 124580U);
            var Output_3 = n51.Command_C.Create(Node_Context_In: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("HdxjuanrTAgOVJrlFMdlRO", "LnlKP2Bu29FOJJ1Aik5e4R", 124592U);
            bool Initial_Result_5 = false;
            n33._Operations_.Create_H<bool>(Node_Context: Node_Context_4, Initial_Result_In: Initial_Result_5, Output_Out: out n31.HoldLatest<bool> Output_6);
            n4.KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J that_7 = this;
            this.__p_D2cIHHBtEfnNmapLTi9GsJ = Output_1;
            this.__p_VerHuaGBKIWPDUoaIAP0zC = Output_3;
            this.__p_LnlKP2Bu29FOJJ1Aik5e4R = Output_6;
            this.__loop_DDyzlfmjfsCN58HMKcvLe9 = default(n19.ImmutableLifetimeManager);
            return that_7;
        }

        public n4.KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J __CreateDefault__()
        {
            n4.KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J that_0 = this;
            this.__p_VerHuaGBKIWPDUoaIAP0zC = n51.Command_C.CreateDefault();
            this.__p_LnlKP2Bu29FOJJ1Aik5e4R = default(n31.HoldLatest<bool>);
            this.__p_D2cIHHBtEfnNmapLTi9GsJ = n39.Toggle_NRtjXBFlZv8LkW1dAEOgnz.CreateDefault();
            this.__loop_DDyzlfmjfsCN58HMKcvLe9 = default(n19.ImmutableLifetimeManager);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_VerHuaGBKIWPDUoaIAP0zC);
            n1.CompilationHelper.SafeDispose(this.__p_LnlKP2Bu29FOJJ1Aik5e4R);
            n1.CompilationHelper.SafeDispose(this.__p_D2cIHHBtEfnNmapLTi9GsJ);
            n1.CompilationHelper.SafeDispose(this.__loop_DDyzlfmjfsCN58HMKcvLe9);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 124568U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "G2VEFR9OsIsN6W2QMkoaq7", Name = "__slot_G2VEFR9OsIsN6W2QMkoaq7")]
        public static string __slot_G2VEFR9OsIsN6W2QMkoaq7 = "Key && Mouse Display";
        [n1.ElementAttribute(TracingId = 124580U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "VerHuaGBKIWPDUoaIAP0zC", Name = "Command", IsManaged = true, IsAutoGenerated = true)]
        public n51.Command_C __p_VerHuaGBKIWPDUoaIAP0zC;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n24.Keys __c_NxeJuXtMCfoMXORbsssnMr = n1.CompilationHelper.Deserialize<n24.Keys>("None", false, "HdxjuanrTAgOVJrlFMdlRO", "NxeJuXtMCfoMXORbsssnMr");
        [n1.ElementAttribute(TracingId = 124592U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "LnlKP2Bu29FOJJ1Aik5e4R", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n31.HoldLatest<bool> __p_LnlKP2Bu29FOJJ1Aik5e4R;
        [n1.ElementAttribute(TracingId = 124570U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "D2cIHHBtEfnNmapLTi9GsJ", Name = "Toggle", IsManaged = true, IsAutoGenerated = true)]
        public n39.Toggle_NRtjXBFlZv8LkW1dAEOgnz __p_D2cIHHBtEfnNmapLTi9GsJ;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n19.ImmutableLifetimeManager __loop_DDyzlfmjfsCN58HMKcvLe9;
        static KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J()
        {
        }

        public KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J(KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J other): base(other)
        {
            this.__p_VerHuaGBKIWPDUoaIAP0zC = other.__p_VerHuaGBKIWPDUoaIAP0zC;
            this.__p_LnlKP2Bu29FOJJ1Aik5e4R = other.__p_LnlKP2Bu29FOJJ1Aik5e4R;
            this.__p_D2cIHHBtEfnNmapLTi9GsJ = other.__p_D2cIHHBtEfnNmapLTi9GsJ;
            this.__loop_DDyzlfmjfsCN58HMKcvLe9 = other.__loop_DDyzlfmjfsCN58HMKcvLe9;
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VerHuaGBKIWPDUoaIAP0zC", in __p_VerHuaGBKIWPDUoaIAP0zC), n1.CompilationHelper.GetValueOrExisting(values, "__p_LnlKP2Bu29FOJJ1Aik5e4R", in __p_LnlKP2Bu29FOJJ1Aik5e4R), n1.CompilationHelper.GetValueOrExisting(values, "__p_D2cIHHBtEfnNmapLTi9GsJ", in __p_D2cIHHBtEfnNmapLTi9GsJ), n1.CompilationHelper.GetValueOrExisting(values, "__loop_DDyzlfmjfsCN58HMKcvLe9", in __loop_DDyzlfmjfsCN58HMKcvLe9));
        }

        internal KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J __WITH__(n51.Command_C __p_VerHuaGBKIWPDUoaIAP0zC, n31.HoldLatest<bool> __p_LnlKP2Bu29FOJJ1Aik5e4R, n39.Toggle_NRtjXBFlZv8LkW1dAEOgnz __p_D2cIHHBtEfnNmapLTi9GsJ, n19.ImmutableLifetimeManager __loop_DDyzlfmjfsCN58HMKcvLe9)
        {
            n4.KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_VerHuaGBKIWPDUoaIAP0zC != this.__p_VerHuaGBKIWPDUoaIAP0zC || __p_LnlKP2Bu29FOJJ1Aik5e4R != this.__p_LnlKP2Bu29FOJJ1Aik5e4R || __p_D2cIHHBtEfnNmapLTi9GsJ != this.__p_D2cIHHBtEfnNmapLTi9GsJ || __loop_DDyzlfmjfsCN58HMKcvLe9 != this.__loop_DDyzlfmjfsCN58HMKcvLe9 ? new KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J(this)
                {__p_VerHuaGBKIWPDUoaIAP0zC = __p_VerHuaGBKIWPDUoaIAP0zC, __p_LnlKP2Bu29FOJJ1Aik5e4R = __p_LnlKP2Bu29FOJJ1Aik5e4R, __p_D2cIHHBtEfnNmapLTi9GsJ = __p_D2cIHHBtEfnNmapLTi9GsJ, __loop_DDyzlfmjfsCN58HMKcvLe9 = __loop_DDyzlfmjfsCN58HMKcvLe9} : that_0;
            else
            {
                this.__p_VerHuaGBKIWPDUoaIAP0zC = __p_VerHuaGBKIWPDUoaIAP0zC;
                this.__p_LnlKP2Bu29FOJJ1Aik5e4R = __p_LnlKP2Bu29FOJJ1Aik5e4R;
                this.__p_D2cIHHBtEfnNmapLTi9GsJ = __p_D2cIHHBtEfnNmapLTi9GsJ;
                this.__loop_DDyzlfmjfsCN58HMKcvLe9 = __loop_DDyzlfmjfsCN58HMKcvLe9;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "FxY4Fn8TuUyMDLDPPsChsk", Name = "__FxY4Fn8TuUyMDLDPPsChsk")]
        [n2.SerializableAttribute]
        public class __FxY4Fn8TuUyMDLDPPsChsk : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_IzP4ir8eWYuNHXCmnLPKKk);
                return;
            }

            [n1.ElementAttribute(TracingId = 124566U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "IzP4ir8eWYuNHXCmnLPKKk", Name = "KeyMouseDisplay", IsManaged = true, IsAutoGenerated = true)]
            public n4.KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC __p_IzP4ir8eWYuNHXCmnLPKKk;
            public __FxY4Fn8TuUyMDLDPPsChsk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __FxY4Fn8TuUyMDLDPPsChsk(__FxY4Fn8TuUyMDLDPPsChsk other): base(other)
            {
                this.__p_IzP4ir8eWYuNHXCmnLPKKk = other.__p_IzP4ir8eWYuNHXCmnLPKKk;
            }

            protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IzP4ir8eWYuNHXCmnLPKKk", in __p_IzP4ir8eWYuNHXCmnLPKKk));
            }

            internal __FxY4Fn8TuUyMDLDPPsChsk __WITH__(n4.KeyMouseDisplay_UErZtG58Da7NPpgtadFSDC __p_IzP4ir8eWYuNHXCmnLPKKk)
            {
                __FxY4Fn8TuUyMDLDPPsChsk that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_IzP4ir8eWYuNHXCmnLPKKk != this.__p_IzP4ir8eWYuNHXCmnLPKKk ? new __FxY4Fn8TuUyMDLDPPsChsk(this)
                    {__p_IzP4ir8eWYuNHXCmnLPKKk = __p_IzP4ir8eWYuNHXCmnLPKKk} : that_0;
                else
                {
                    this.__p_IzP4ir8eWYuNHXCmnLPKKk = __p_IzP4ir8eWYuNHXCmnLPKKk;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 124622U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "O2kjr9kt3EBNmknFhzyLtA", Name = "VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA")]
    [n2.SerializableAttribute]
    public class VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA CreateDefault()
        {
            var instance = new VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA Update()
        {
            return this;
        }

        public n4.VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA __Create__(n1.NodeContext Node_Context)
        {
            n12.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n4.VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA Dispose_()
        {
            return this;
        }

        public n4.VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA __CreateDefault__()
        {
            return this;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        public VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA(VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n17.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_UI_KeyMouseDisplayApplication_O2kjr9kt3EBNmknFhzyLtA __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 92590U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ReplaceText(string Input_In, out string Output_Out)
        {
            n11.Spread<string> __pad_Pi6nfwDdSi1NwqRyFXYmnL_0 = __slot_Pi6nfwDdSi1NwqRyFXYmnL;
            n11.Spread<string> __pad_H8eWdT8UsfdO3azsBdSUxN_1 = __slot_H8eWdT8UsfdO3azsBdSUxN;
            string accumulator_2 = Input_In;
            var enumerator_3 = n5.CollectionExtensions.AsSpan(__pad_Pi6nfwDdSi1NwqRyFXYmnL_0).GetEnumerator();
            var enumerator_5 = n5.CollectionExtensions.AsSpan(__pad_H8eWdT8UsfdO3azsBdSUxN_1).GetEnumerator();
            var i_7 = 0;
            while (enumerator_3.MoveNext() && enumerator_5.MoveNext())
            {
                var splicer_4 = enumerator_3.Current;
                var splicer_6 = enumerator_5.Current;
                var i_local_8 = i_7;
                n18._Operations_.Replace(Input_In: accumulator_2, Old_Value_In: splicer_4, New_Value_In: splicer_6, Output_Out: out string Output_9);
                accumulator_2 = Output_9;
                i_7++;
            }

            Output_Out = accumulator_2;
            return;
        }

        public static void AddModifiers(string Input_In, out string Output_Out)
        {
            n11.Spread<string> __pin_group_Input_In_U5PgpdfLCUsOVmaFH2Jq7p = default(n11.Spread<string>);
            n11.Spread<string> __pin_group_Input_In_AURfUPTTxuqLFORrvNGWuC = default(n11.Spread<string>);
            n11.Spread<string> __pin_group_Input_In_OnL4SAS9ywhPJedRpbECNj = default(n11.Spread<string>);
            n37.Key __pad_DqE3ajhy660MN0evQmuxet_0 = __slot_DqE3ajhy660MN0evQmuxet;
            n37.Key __pad_V4UQvP2tyCrP3Dg0KhODxA_1 = __slot_V4UQvP2tyCrP3Dg0KhODxA;
            n37.Key __pad_Dfb6N4zneKsPLEmDcHMNGx_2 = __slot_Dfb6N4zneKsPLEmDcHMNGx;
            var Result_3 = n37.Keyboard.IsKeyDown(key: __pad_DqE3ajhy660MN0evQmuxet_0);
            int Index_4 = n2.Convert.ToInt32(Result_3);
            string Input_5 = "Shift + ";
            var Output_6 = n44.StringExtensions.Plus(input: Input_5, input2: Input_In);
            var builder_7 = n5.CollectionBuilders.GetBuilder(__pin_group_Input_In_U5PgpdfLCUsOVmaFH2Jq7p, 2);
            builder_7.Add(Input_In);
            builder_7.Add(Output_6);
            var __pin_group_Input_In_U5PgpdfLCUsOVmaFH2Jq7p_8 = builder_7.Commit();
            n39._Operations_.Switch<string, n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Index_In: Index_4, Input_In: __pin_group_Input_In_U5PgpdfLCUsOVmaFH2Jq7p_8, Output_Out: out string Output_9);
            var Result_10 = n37.Keyboard.IsKeyDown(key: __pad_V4UQvP2tyCrP3Dg0KhODxA_1);
            int Index_11 = n2.Convert.ToInt32(Result_10);
            string Input_12 = "Alt + ";
            var Output_13 = n44.StringExtensions.Plus(input: Input_12, input2: Output_9);
            var builder_14 = n5.CollectionBuilders.GetBuilder(__pin_group_Input_In_AURfUPTTxuqLFORrvNGWuC, 2);
            builder_14.Add(Output_9);
            builder_14.Add(Output_13);
            var __pin_group_Input_In_AURfUPTTxuqLFORrvNGWuC_15 = builder_14.Commit();
            n39._Operations_.Switch<string, n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Index_In: Index_11, Input_In: __pin_group_Input_In_AURfUPTTxuqLFORrvNGWuC_15, Output_Out: out string Output_16);
            var Result_17 = n37.Keyboard.IsKeyDown(key: __pad_Dfb6N4zneKsPLEmDcHMNGx_2);
            int Index_18 = n2.Convert.ToInt32(Result_17);
            string Input_19 = "Ctrl + ";
            var Output_20 = n44.StringExtensions.Plus(input: Input_19, input2: Output_16);
            var builder_21 = n5.CollectionBuilders.GetBuilder(__pin_group_Input_In_OnL4SAS9ywhPJedRpbECNj, 2);
            builder_21.Add(Output_16);
            builder_21.Add(Output_20);
            var __pin_group_Input_In_OnL4SAS9ywhPJedRpbECNj_22 = builder_21.Commit();
            n39._Operations_.Switch<string, n34.__AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO>(Index_In: Index_18, Input_In: __pin_group_Input_In_OnL4SAS9ywhPJedRpbECNj_22, Output_Out: out string Output_23);
            Output_Out = Output_23;
            return;
        }

        [n1.ElementAttribute(TracingId = 101996U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "Pi6nfwDdSi1NwqRyFXYmnL", Name = "__slot_Pi6nfwDdSi1NwqRyFXYmnL")]
        public static n11.Spread<string> __slot_Pi6nfwDdSi1NwqRyFXYmnL = n1.CompilationHelper.Deserialize<n11.Spread<string>>("<Value xmlns=\"property\">\r\n  <Item xmlns=\"\">OemBackslash</Item>\r\n  <Item xmlns=\"\">Oem5</Item>\r\n  <Item xmlns=\"\">Oemplus</Item>\r\n  <Item xmlns=\"\">OemMinus</Item>\r\n  <Item xmlns=\"\">Alt + Control</Item>\r\n  <Item xmlns=\"\">OemPeriod</Item>\r\n  <Item xmlns=\"\">Oemcomma</Item>\r\n  <Item xmlns=\"\">Control</Item>\r\n  <Item xmlns=\"\">D0</Item>\r\n  <Item xmlns=\"\">D1</Item>\r\n  <Item xmlns=\"\">D2</Item>\r\n  <Item xmlns=\"\">D3</Item>\r\n  <Item xmlns=\"\">D4</Item>\r\n  <Item xmlns=\"\">D5</Item>\r\n  <Item xmlns=\"\">D6</Item>\r\n  <Item xmlns=\"\">D7</Item>\r\n  <Item xmlns=\"\">D8</Item>\r\n  <Item xmlns=\"\">D9</Item>\r\n  <Item xmlns=\"\">Back</Item>\r\n  <Item xmlns=\"\">Left</Item>\r\n  <Item xmlns=\"\">Up</Item>\r\n  <Item xmlns=\"\">Right</Item>\r\n  <Item xmlns=\"\">Down</Item>\r\n  <Item xmlns=\"\">Shift</Item>\r\n  <Item xmlns=\"\">Tab</Item>\r\n</Value>", true, "HdxjuanrTAgOVJrlFMdlRO", "Pi6nfwDdSi1NwqRyFXYmnL");
        [n1.ElementAttribute(TracingId = 101987U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "H8eWdT8UsfdO3azsBdSUxN", Name = "__slot_H8eWdT8UsfdO3azsBdSUxN")]
        public static n11.Spread<string> __slot_H8eWdT8UsfdO3azsBdSUxN = n1.CompilationHelper.Deserialize<n11.Spread<string>>("<Value xmlns=\"property\">\r\n  <Item xmlns=\"\">&gt;</Item>\r\n  <Item xmlns=\"\">^ (Key below Esc)</Item>\r\n  <Item xmlns=\"\">+</Item>\r\n  <Item xmlns=\"\">-</Item>\r\n  <Item xmlns=\"\">AltGr</Item>\r\n  <Item xmlns=\"\">.</Item>\r\n  <Item xmlns=\"\">,</Item>\r\n  <Item xmlns=\"\">Ctrl</Item>\r\n  <Item xmlns=\"\">0</Item>\r\n  <Item xmlns=\"\">1</Item>\r\n  <Item xmlns=\"\">2</Item>\r\n  <Item xmlns=\"\">3</Item>\r\n  <Item xmlns=\"\">4</Item>\r\n  <Item xmlns=\"\">5</Item>\r\n  <Item xmlns=\"\">6</Item>\r\n  <Item xmlns=\"\">7</Item>\r\n  <Item xmlns=\"\">8</Item>\r\n  <Item xmlns=\"\">9</Item>\r\n  <Item xmlns=\"\">Delete</Item>\r\n  <Item xmlns=\"\">🠤</Item>\r\n  <Item xmlns=\"\">🠥</Item>\r\n  <Item xmlns=\"\">🠦</Item>\r\n  <Item xmlns=\"\">🠧</Item>\r\n  <Item xmlns=\"\"> ⇧ </Item>\r\n  <Item xmlns=\"\">⭾</Item>\r\n</Value>", true, "HdxjuanrTAgOVJrlFMdlRO", "H8eWdT8UsfdO3azsBdSUxN");
        [n1.ElementAttribute(TracingId = 102065U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "DqE3ajhy660MN0evQmuxet", Name = "__slot_DqE3ajhy660MN0evQmuxet")]
        public static n37.Key __slot_DqE3ajhy660MN0evQmuxet = n1.CompilationHelper.Deserialize<n37.Key>("LeftShift", false, "HdxjuanrTAgOVJrlFMdlRO", "DqE3ajhy660MN0evQmuxet");
        [n1.ElementAttribute(TracingId = 102119U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "V4UQvP2tyCrP3Dg0KhODxA", Name = "__slot_V4UQvP2tyCrP3Dg0KhODxA")]
        public static n37.Key __slot_V4UQvP2tyCrP3Dg0KhODxA = n1.CompilationHelper.Deserialize<n37.Key>("LeftAlt", false, "HdxjuanrTAgOVJrlFMdlRO", "V4UQvP2tyCrP3Dg0KhODxA");
        [n1.ElementAttribute(TracingId = 102158U, DocumentId = "HdxjuanrTAgOVJrlFMdlRO", PersistentId = "Dfb6N4zneKsPLEmDcHMNGx", Name = "__slot_Dfb6N4zneKsPLEmDcHMNGx")]
        public static n37.Key __slot_Dfb6N4zneKsPLEmDcHMNGx = n1.CompilationHelper.Deserialize<n37.Key>("LeftCtrl", false, "HdxjuanrTAgOVJrlFMdlRO", "Dfb6N4zneKsPLEmDcHMNGx");
        static _Operations_()
        {
        }
    }
}

namespace _VL_UI_KeyMouseDisplay_
{
    public struct __AdaptiveImplementations__HdxjuanrTAgOVJrlFMdlRO : n61.IAdaptiveCreateDefault<string>, n61.IAdaptiveCreateDefault<n24.KeyEventArgs>, n61.IAdaptiveCreateDefault<float>, n61.IAdaptiveCreateDefault<n9.ILayer>, n61.IAdaptiveCreateDefault<n24.MouseEventArgs>, n61.IAdaptiveCreateDefault<n2.IObservable<n2.ValueTuple<n9.ILayer, float>>>, n61.IAdaptiveCreateDefault<n24.MouseButtons>, n61.IAdaptiveCreateDefault<n3.Vector2>, n62.IAdaptiveOperatorMinus<n3.Vector2>
    {
        public void CreateDefault(out string Output_Out)
        {
            var Empty_0 = n18._Operations_.CreateDefault();
            Output_Out = Empty_0;
            return;
        }

        public void CreateDefault(out n24.KeyEventArgs Output_Out)
        {
            n59._Operations_.CreateDefault_Generic<n24.KeyEventArgs>(Output_Out: out n24.KeyEventArgs Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out float Output_Out)
        {
            n59._Operations_.CreateDefault_Generic<float>(Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n9.ILayer Output_Out)
        {
            var Output_0 = n38._Operations_.CreateDefault();
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n24.MouseEventArgs Output_Out)
        {
            n59._Operations_.CreateDefault_Generic<n24.MouseEventArgs>(Output_Out: out n24.MouseEventArgs Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n2.IObservable<n2.ValueTuple<n9.ILayer, float>> Output_Out)
        {
            var Result_0 = n60._Operations_.CreateDefault<n2.ValueTuple<n9.ILayer, float>>();
            Output_Out = Result_0;
            return;
        }

        public void CreateDefault(out n24.MouseButtons Output_Out)
        {
            n59._Operations_.CreateDefault_Generic<n24.MouseButtons>(Output_Out: out n24.MouseButtons Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n3.Vector2 Output_Out)
        {
            var Zero_0 = n41._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }

        public void OperatorMinus(n3.Vector2 Input_In, n3.Vector2 Input_2_In, out n3.Vector2 Output_Out)
        {
            n3.Vector2.Subtract(left: ref Input_In, right: ref Input_2_In, result: out n3.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}