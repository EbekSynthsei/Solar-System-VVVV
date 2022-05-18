extern alias e5;
extern alias e3;
extern alias e2;
extern alias e4;

using n8 = e2::VL.Lib.Collections;
using n12 = _VL_Skia_.Graphics.Skia;
using n13 = e3::VL.Lib.Primitive.CacheRegion;
using n25 = _HDE_StylesAndSettings_.HDE.Settings.Settings.Internal;
using n27 = global::System.Reactive.Subjects;
using n23 = _CoreLibBasics_.Control;
using n28 = _VL_Reactive_.Reactive.Subjects.BehaviorSubject.Advanced;
using n17 = _VL_Skia_.Graphics.Skia.Text.Paint.Advanced;
using n31 = _CoreLibBasics_.Primitive.Delegates.Delegate__0_MG_1.Advanced;
using n20 = _CoreLibBasics_.Animation.IFrameClock.Advanced;
using n29 = _HDE_StylesAndSettings_.HDE;
using n3 = _HDE_StylesAndSettings_.HDE.Styles;
using n15 = _VL_Skia_.Graphics.Skia.Paint;
using n11 = global::System.Collections.Generic;
using n18 = global::SkiaSharp;
using n33 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n22 = _CoreLibBasics_.Animation;
using n26 = e5::VL.UI.Core;
using n6 = e3::VL.Lib.Primitive;
using n16 = _VL_Skia_.Graphics.Skia.Text;
using n1 = e2::VL.Core;
using n2 = global::System;
using n7 = e4::Stride.Core.Mathematics;
using n24 = e3::VL.Lib.Color;
using n14 = _CoreLibBasics_.Color.RGBA;
using n5 = e3::VL.Lib.Primitive.Object;
using n4 = e2::VL.Core.CompilerServices;
using n19 = e5::VL.Core.Viewer;
using n21 = e2::VL.Lib.Animation;
using n9 = global::System.Runtime.CompilerServices;
using n10 = _VL_Collections_.Collections.Spread;
using n30 = global::System.Drawing;
using n32 = _CoreLibBasics_.Primitive.Advanced;

namespace _HDE_StylesAndSettings_.HDE.Styles
{
    [n1.ElementAttribute(TracingId = 23152U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "P4DHtxn6lB8LBClzcqIvRr", Name = "OperationColors_P4DHtxn6lB8LBClzcqIvRr")]
    [n2.SerializableAttribute]
    public class OperationColors_P4DHtxn6lB8LBClzcqIvRr : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.OperationColors_P4DHtxn6lB8LBClzcqIvRr Create(n1.NodeContext Node_Context)
        {
            var instance = new OperationColors_P4DHtxn6lB8LBClzcqIvRr(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.OperationColors_P4DHtxn6lB8LBClzcqIvRr CreateDefault()
        {
            var instance = new OperationColors_P4DHtxn6lB8LBClzcqIvRr(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.OperationColors_P4DHtxn6lB8LBClzcqIvRr Update(out n8.Spread<n7.Color4> Output_Out)
        {
            int __pad_P7MOwBnqD6oMtn073FPt6m_0 = __slot_P7MOwBnqD6oMtn073FPt6m;
            var builder_8 = n4.CollectionBuilders.GetBuilder(this.__cp_ThEWcKhQExIQPewIJvlSK0, 16);
            n8.Spread<n7.Color4> output_9;
            try
            {
                for (var i_1 = 0; i_1 < __pad_P7MOwBnqD6oMtn073FPt6m_0; i_1++)
                {
                    var i_local_2 = i_1;
                    string __pad_NMfl5jKCkDMM4Xva0HUKCj_4 = __slot_NMfl5jKCkDMM4Xva0HUKCj;
                    var Result_5 = n5.ObjectHelpers.ToString(input: i_local_2);
                    var Output_6 = n6.StringExtensions.Plus(input: __pad_NMfl5jKCkDMM4Xva0HUKCj_4, input2: Result_5);
                    n3._Operations_.GetFillColor(Style_Selector_In: Output_6, Result_Out: out n7.Color4 Result_7);
                    builder_8.Add(Result_7);
                }
            }
            finally
            {
                output_9 = builder_8.Commit();
            }

            Output_Out = output_9;
            n3.OperationColors_P4DHtxn6lB8LBClzcqIvRr that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = output_9 != this.__cp_ThEWcKhQExIQPewIJvlSK0 ? new OperationColors_P4DHtxn6lB8LBClzcqIvRr(this)
                {__cp_ThEWcKhQExIQPewIJvlSK0 = output_9} : that_10;
            else
            {
                this.__cp_ThEWcKhQExIQPewIJvlSK0 = output_9;
            }

            return that_10;
        }

        public n3.OperationColors_P4DHtxn6lB8LBClzcqIvRr __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.OperationColors_P4DHtxn6lB8LBClzcqIvRr that_0 = this;
            this.__cp_ThEWcKhQExIQPewIJvlSK0 = n10._Operations_.CreateDefault<n7.Color4>();
            return that_0;
        }

        public n3.OperationColors_P4DHtxn6lB8LBClzcqIvRr __CreateDefault__()
        {
            n3.OperationColors_P4DHtxn6lB8LBClzcqIvRr that_0 = this;
            this.__cp_ThEWcKhQExIQPewIJvlSK0 = n10._Operations_.CreateDefault<n7.Color4>();
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

        [n1.ElementAttribute(TracingId = 23242U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "P7MOwBnqD6oMtn073FPt6m", Name = "__slot_P7MOwBnqD6oMtn073FPt6m")]
        public static int __slot_P7MOwBnqD6oMtn073FPt6m = 9;
        [n1.ElementAttribute(TracingId = 23195U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "NMfl5jKCkDMM4Xva0HUKCj", Name = "__slot_NMfl5jKCkDMM4Xva0HUKCj")]
        public static string __slot_NMfl5jKCkDMM4Xva0HUKCj = ".operation";
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n8.Spread<n7.Color4> __cp_ThEWcKhQExIQPewIJvlSK0;
        static OperationColors_P4DHtxn6lB8LBClzcqIvRr()
        {
        }

        public OperationColors_P4DHtxn6lB8LBClzcqIvRr(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal OperationColors_P4DHtxn6lB8LBClzcqIvRr(OperationColors_P4DHtxn6lB8LBClzcqIvRr other): base(other)
        {
            this.__cp_ThEWcKhQExIQPewIJvlSK0 = other.__cp_ThEWcKhQExIQPewIJvlSK0;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_ThEWcKhQExIQPewIJvlSK0", in __cp_ThEWcKhQExIQPewIJvlSK0));
        }

        internal OperationColors_P4DHtxn6lB8LBClzcqIvRr __WITH__(n8.Spread<n7.Color4> __cp_ThEWcKhQExIQPewIJvlSK0)
        {
            n3.OperationColors_P4DHtxn6lB8LBClzcqIvRr that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cp_ThEWcKhQExIQPewIJvlSK0 != this.__cp_ThEWcKhQExIQPewIJvlSK0 ? new OperationColors_P4DHtxn6lB8LBClzcqIvRr(this)
                {__cp_ThEWcKhQExIQPewIJvlSK0 = __cp_ThEWcKhQExIQPewIJvlSK0} : that_0;
            else
            {
                this.__cp_ThEWcKhQExIQPewIJvlSK0 = __cp_ThEWcKhQExIQPewIJvlSK0;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 23309U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "UN2FljHf3rqPNLBg8cXJWy", Name = "TooltipPaints_C")]
    [n2.SerializableAttribute]
    public class TooltipPaints_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.TooltipPaints_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new TooltipPaints_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.TooltipPaints_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new TooltipPaints_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.TooltipPaints_C Update(out n12.SkiaPaint_R Background_Out, out n7.Color4 Hint_Out, out n7.Color4 Warning_Out, out n7.Color4 Error_Out, out n7.Color4 Runtime_Error_Out, out n12.SkiaPaint_R Font1_Out, out n12.SkiaPaint_R Font2_Out, out n12.SkiaPaint_R Font3_Out)
        {
            float Period_0 = 10F;
            bool Pause_1 = false;
            bool Update_2 = true;
            var Output_3 = this.__p_Vt1HPx7wSoFMaNBufGp9sN;
            if (Update_2)
            {
                Output_3 = this.__p_Vt1HPx7wSoFMaNBufGp9sN.Update(Period_In: Period_0, Pause_In: Pause_1);
            }

            this.__p_Vt1HPx7wSoFMaNBufGp9sN = Output_3;
            var Output_7 = Output_3.GetValues(Phase_Out: out float Phase_4, On_New_Cycle_Out: out bool On_New_Cycle_5, Cycles_Out: out int Cycles_6);
            this.__p_Vt1HPx7wSoFMaNBufGp9sN = Output_7;
            var State_Output_9 = this.__p_CpQf4MIBohsQd91Le2eQ7r.Update(Simulate_In: On_New_Cycle_5, Output_Out: out bool Output_8);
            this.__p_CpQf4MIBohsQd91Le2eQ7r = State_Output_9;
            bool Dispose_Cached_Outputs_10 = false;
            var manager_11 = this.__cache_ShRQ7nHfiSGNCy1ivsFfJK;
            if (manager_11 is null)
            {
                manager_11 = new n13.Manager<n2.ValueTuple, n2.ValueTuple<n12.SkiaPaint_R, n7.Color4, n7.Color4, n7.Color4, n7.Color4, n12.SkiaPaint_R, n12.SkiaPaint_R, n2.ValueTuple<n12.SkiaPaint_R>>>((n12.SkiaPaint_R.CreateDefault(), n14._Operations_.CreateDefault(), n14._Operations_.CreateDefault(), n14._Operations_.CreateDefault(), n14._Operations_.CreateDefault(), n12.SkiaPaint_R.CreateDefault(), n12.SkiaPaint_R.CreateDefault(), n12.SkiaPaint_R.CreateDefault()));
            }

            var inputs_12 = n2.ValueTuple.Create();
            var outputs_13 = manager_11.Outputs;
            var Has_Changed_14 = Output_8 || manager_11.InputsChanged(inputs_12);
            if (Has_Changed_14)
            {
                if (Dispose_Cached_Outputs_10)
                    manager_11.DisposeOutputs();
                var state_15 = n1.CompilationHelper.Restore<__T6kmwL6GK12OQvwS3FI1bL>(manager_11.State, __GetContext__());
                if (state_15 == null)
                {
                    state_15 = new __T6kmwL6GK12OQvwS3FI1bL(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("QJQ0tnl56B9MNMEaY2eCRr", "TPfsFKK414HPsOOTdwZ7mP", 23365U);
                    var Output_17 = n15.Fill_UsNlhFP5Z8VOaaHSrZXiyC.Create(Node_Context: Node_Context_16);
                    state_15.__p_TPfsFKK414HPsOOTdwZ7mP = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("QJQ0tnl56B9MNMEaY2eCRr", "Q0GuxFRZGucMqvlP6sYy1x", 23525U);
                    var Output_19 = n16.Typeface_FromName_Q6b2DSnKxo3MAnm9n9ZKZo.Create(Node_Context: Node_Context_18);
                    state_15.__p_Q0GuxFRZGucMqvlP6sYy1x = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("QJQ0tnl56B9MNMEaY2eCRr", "Itd2CDL0ZsTPgwluYLvO8B", 23537U);
                    var Output_21 = n17.SetTypeface_Rj1JUzAL7GeMWPR8C8o16P.Create(Node_Context: Node_Context_20);
                    state_15.__p_Itd2CDL0ZsTPgwluYLvO8B = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("QJQ0tnl56B9MNMEaY2eCRr", "LsrQbLdISplMbjImkjIXc4", 23547U);
                    var Output_23 = n16.SetTextSize_QI38Jjk5kaVN53dJij0KIZ.Create(Node_Context: Node_Context_22);
                    state_15.__p_LsrQbLdISplMbjImkjIXc4 = Output_23;
                    n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("QJQ0tnl56B9MNMEaY2eCRr", "SEYm6IGf2fLOhy243td4WE", 23558U);
                    var Output_25 = n15.SetColor_ErmwE010oOSLqOYWImAOgN.Create(Node_Context: Node_Context_24);
                    state_15.__p_SEYm6IGf2fLOhy243td4WE = Output_25;
                    n1.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("QJQ0tnl56B9MNMEaY2eCRr", "HNk2biYsSJsL759Kjk6RTb", 23578U);
                    var Output_27 = n16.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a.Create(Node_Context: Node_Context_26);
                    state_15.__p_HNk2biYsSJsL759Kjk6RTb = Output_27;
                    n1.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("QJQ0tnl56B9MNMEaY2eCRr", "I9EfedXlnhFQT3j9KFMY9a", 23610U);
                    var Output_29 = n15.SetColor_ErmwE010oOSLqOYWImAOgN.Create(Node_Context: Node_Context_28);
                    state_15.__p_I9EfedXlnhFQT3j9KFMY9a = Output_29;
                    n1.NodeContext Node_Context_30 = __GetContext__().CreateSubContext("QJQ0tnl56B9MNMEaY2eCRr", "NYCHZqlaJyGMLgbWF3WMMZ", 23650U);
                    var Output_31 = n15.SetColor_ErmwE010oOSLqOYWImAOgN.Create(Node_Context: Node_Context_30);
                    state_15.__p_NYCHZqlaJyGMLgbWF3WMMZ = Output_31;
                }

                string __pad_L7UD52OvizCPxLEnkMFmr4_32 = __slot_L7UD52OvizCPxLEnkMFmr4;
                string __pad_Bl8l359kaplMLnUH53wFqx_33 = __slot_Bl8l359kaplMLnUH53wFqx;
                float __pad_PwVC85QEVuLLaGhFQe2Mih_34 = __slot_PwVC85QEVuLLaGhFQe2Mih;
                string __pad_F6RpbYkZNefMF7H9JbYFpS_35 = __slot_F6RpbYkZNefMF7H9JbYFpS;
                string __pad_AP7NZg87W23N3K03Vl3Wyt_36 = __slot_AP7NZg87W23N3K03Vl3Wyt;
                string __pad_LvPY3yxMAZCLnc7DuN50nw_37 = __slot_LvPY3yxMAZCLnc7DuN50nw;
                string __pad_MwEt4pszXzDOPmSQSRUiiA_38 = __slot_MwEt4pszXzDOPmSQSRUiiA;
                string __pad_LGa5JY39hrZOBOls88mvsw_39 = __slot_LGa5JY39hrZOBOls88mvsw;
                string __pad_P9q0HlL6Mx1MLGWFOI3w3i_40 = __slot_P9q0HlL6Mx1MLGWFOI3w3i;
                n3._Operations_.GetFillColor(Style_Selector_In: __pad_L7UD52OvizCPxLEnkMFmr4_32, Result_Out: out n7.Color4 Result_41);
                n12.SkiaPaint_R Input_42 = n12.SkiaPaint_R.CreateDefault();
                n18.SKShader Shader_43 = default(n18.SKShader);
                var State_Output_45 = state_15.__p_TPfsFKK414HPsOOTdwZ7mP.Update(Input_In: Input_42, Color_In: Result_41, Shader_In: Shader_43, Output_Out: out n12.SkiaPaint_R Output_44);
                n3._Operations_.GetFillColor(Style_Selector_In: __pad_Bl8l359kaplMLnUH53wFqx_33, Result_Out: out n7.Color4 Result_46);
                var Result_47 = n19.Styles.Catalog(styleSelector: __pad_Bl8l359kaplMLnUH53wFqx_33);
                var Font_48 = Result_47.Font;
                var Name_49 = Font_48.Name;
                var Size_50 = Font_48.Size;
                float Scalar_51 = 0.01F;
                var Output_52 = n6.Float32Extensions.Scale(input: Size_50, scalar: Scalar_51);
                n12.SkiaPaint_R Input_53 = n12.SkiaPaint_R.CreateDefault();
                var State_Output_55 = state_15.__p_LsrQbLdISplMbjImkjIXc4.Update(Input_In: Input_53, Value_In: Output_52, Output_Out: out n12.SkiaPaint_R Output_54);
                n18.SKTypefaceStyle Style_56 = default(n18.SKTypefaceStyle);
                var Output_58 = state_15.__p_Q0GuxFRZGucMqvlP6sYy1x.Update(FamilyName_In: Name_49, Style_In: Style_56, Typeface_Out: out n18.SKTypeface Typeface_57);
                var State_Output_60 = state_15.__p_Itd2CDL0ZsTPgwluYLvO8B.Update(Input_In: Output_54, Value_In: Typeface_57, Output_Out: out n12.SkiaPaint_R Output_59);
                var State_Output_62 = state_15.__p_HNk2biYsSJsL759Kjk6RTb.Update(Input_In: Output_59, Line_Height_In: __pad_PwVC85QEVuLLaGhFQe2Mih_34, Output_Out: out n12.SkiaPaint_R Output_61);
                var State_Output_64 = state_15.__p_SEYm6IGf2fLOhy243td4WE.Update(Input_In: Output_61, Value_In: Result_46, Output_Out: out n12.SkiaPaint_R Output_63);
                n3._Operations_.GetFillColor(Style_Selector_In: __pad_F6RpbYkZNefMF7H9JbYFpS_35, Result_Out: out n7.Color4 Result_65);
                var State_Output_67 = state_15.__p_I9EfedXlnhFQT3j9KFMY9a.Update(Input_In: Output_61, Value_In: Result_65, Output_Out: out n12.SkiaPaint_R Output_66);
                n3._Operations_.GetFillColor(Style_Selector_In: __pad_AP7NZg87W23N3K03Vl3Wyt_36, Result_Out: out n7.Color4 Result_68);
                var State_Output_70 = state_15.__p_NYCHZqlaJyGMLgbWF3WMMZ.Update(Input_In: Output_61, Value_In: Result_68, Output_Out: out n12.SkiaPaint_R Output_69);
                n3._Operations_.GetStrokeColor(Style_Selector_In: __pad_LvPY3yxMAZCLnc7DuN50nw_37, Result_Out: out n7.Color4 Result_71);
                n3._Operations_.GetStrokeColor(Style_Selector_In: __pad_MwEt4pszXzDOPmSQSRUiiA_38, Result_Out: out n7.Color4 Result_72);
                n3._Operations_.GetStrokeColor(Style_Selector_In: __pad_LGa5JY39hrZOBOls88mvsw_39, Result_Out: out n7.Color4 Result_73);
                n3._Operations_.GetStrokeColor(Style_Selector_In: __pad_P9q0HlL6Mx1MLGWFOI3w3i_40, Result_Out: out n7.Color4 Result_74);
                state_15.__p_TPfsFKK414HPsOOTdwZ7mP = State_Output_45;
                state_15.__p_LsrQbLdISplMbjImkjIXc4 = State_Output_55;
                state_15.__p_Q0GuxFRZGucMqvlP6sYy1x = Output_58;
                state_15.__p_Itd2CDL0ZsTPgwluYLvO8B = State_Output_60;
                state_15.__p_HNk2biYsSJsL759Kjk6RTb = State_Output_62;
                state_15.__p_SEYm6IGf2fLOhy243td4WE = State_Output_64;
                state_15.__p_I9EfedXlnhFQT3j9KFMY9a = State_Output_67;
                state_15.__p_NYCHZqlaJyGMLgbWF3WMMZ = State_Output_70;
                outputs_13 = (Output_44, Result_71, Result_72, Result_73, Result_74, Output_63, Output_66, Output_69);
                manager_11 = manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10, state_15, outputs_13);
            }
            else
            {
                manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10);
            }

            var(__auto_75, __auto_76, __auto_77, __auto_78, __auto_79, __auto_80, __auto_81, __auto_82) = outputs_13;
            this.__cache_ShRQ7nHfiSGNCy1ivsFfJK = manager_11;
            Background_Out = __auto_75;
            Hint_Out = __auto_76;
            Warning_Out = __auto_77;
            Error_Out = __auto_78;
            Runtime_Error_Out = __auto_79;
            Font1_Out = __auto_80;
            Font2_Out = __auto_81;
            Font3_Out = __auto_82;
            return this;
        }

        public n3.TooltipPaints_C __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("QJQ0tnl56B9MNMEaY2eCRr", "Vt1HPx7wSoFMaNBufGp9sN", 23758U);
            n21.IFrameClock Clock_1 = n20._Operations_.CreateDefault();
            var Output_2 = n22.LFO_F48sA9CC7kzM1Y1LIpWRrD.Create(Node_Context: Node_Context_0, Clock_In: Clock_1);
            this.__p_Vt1HPx7wSoFMaNBufGp9sN = Output_2;
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("QJQ0tnl56B9MNMEaY2eCRr", "CpQf4MIBohsQd91Le2eQ7r", 23770U);
            var Output_4 = n23.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_3);
            this.__p_CpQf4MIBohsQd91Le2eQ7r = Output_4;
            this.__cache_ShRQ7nHfiSGNCy1ivsFfJK = null;
            return this;
        }

        public n3.TooltipPaints_C __CreateDefault__()
        {
            this.__p_Vt1HPx7wSoFMaNBufGp9sN = n22.LFO_F48sA9CC7kzM1Y1LIpWRrD.CreateDefault();
            this.__p_CpQf4MIBohsQd91Le2eQ7r = n23.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__cache_ShRQ7nHfiSGNCy1ivsFfJK = null;
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Vt1HPx7wSoFMaNBufGp9sN);
            n1.CompilationHelper.SafeDispose(this.__p_CpQf4MIBohsQd91Le2eQ7r);
            n1.CompilationHelper.SafeDispose(this.__cache_ShRQ7nHfiSGNCy1ivsFfJK);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 23758U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "Vt1HPx7wSoFMaNBufGp9sN", Name = "LFO", IsManaged = true, IsAutoGenerated = true)]
        public n22.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_Vt1HPx7wSoFMaNBufGp9sN;
        [n1.ElementAttribute(TracingId = 23770U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "CpQf4MIBohsQd91Le2eQ7r", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n23.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_CpQf4MIBohsQd91Le2eQ7r;
        [n1.ElementAttribute(TracingId = 23344U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "ShRQ7nHfiSGNCy1ivsFfJK", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple, n2.ValueTuple<n12.SkiaPaint_R, n7.Color4, n7.Color4, n7.Color4, n7.Color4, n12.SkiaPaint_R, n12.SkiaPaint_R, n2.ValueTuple<n12.SkiaPaint_R>>> __cache_ShRQ7nHfiSGNCy1ivsFfJK = null;
        [n1.ElementAttribute(TracingId = 23410U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "L7UD52OvizCPxLEnkMFmr4", Name = "__slot_L7UD52OvizCPxLEnkMFmr4")]
        public static string __slot_L7UD52OvizCPxLEnkMFmr4 = "control";
        [n1.ElementAttribute(TracingId = 23428U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "Bl8l359kaplMLnUH53wFqx", Name = "__slot_Bl8l359kaplMLnUH53wFqx")]
        public static string __slot_Bl8l359kaplMLnUH53wFqx = ".tooltip-font";
        [n1.ElementAttribute(TracingId = 23592U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "PwVC85QEVuLLaGhFQe2Mih", Name = "__slot_PwVC85QEVuLLaGhFQe2Mih")]
        public static float __slot_PwVC85QEVuLLaGhFQe2Mih = 0.12F;
        [n1.ElementAttribute(TracingId = 23605U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "F6RpbYkZNefMF7H9JbYFpS", Name = "__slot_F6RpbYkZNefMF7H9JbYFpS")]
        public static string __slot_F6RpbYkZNefMF7H9JbYFpS = ".tooltip-level2-font";
        [n1.ElementAttribute(TracingId = 23645U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "AP7NZg87W23N3K03Vl3Wyt", Name = "__slot_AP7NZg87W23N3K03Vl3Wyt")]
        public static string __slot_AP7NZg87W23N3K03Vl3Wyt = ".tooltip-level3-font";
        [n1.ElementAttribute(TracingId = 23676U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "LvPY3yxMAZCLnc7DuN50nw", Name = "__slot_LvPY3yxMAZCLnc7DuN50nw")]
        public static string __slot_LvPY3yxMAZCLnc7DuN50nw = ".hint";
        [n1.ElementAttribute(TracingId = 23693U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "MwEt4pszXzDOPmSQSRUiiA", Name = "__slot_MwEt4pszXzDOPmSQSRUiiA")]
        public static string __slot_MwEt4pszXzDOPmSQSRUiiA = ".warning";
        [n1.ElementAttribute(TracingId = 23702U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "LGa5JY39hrZOBOls88mvsw", Name = "__slot_LGa5JY39hrZOBOls88mvsw")]
        public static string __slot_LGa5JY39hrZOBOls88mvsw = ".error";
        [n1.ElementAttribute(TracingId = 23710U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "P9q0HlL6Mx1MLGWFOI3w3i", Name = "__slot_P9q0HlL6Mx1MLGWFOI3w3i")]
        public static string __slot_P9q0HlL6Mx1MLGWFOI3w3i = ".runtimeerror";
        static TooltipPaints_C()
        {
        }

        public TooltipPaints_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TooltipPaints_C(TooltipPaints_C other): base(other)
        {
            this.__p_Vt1HPx7wSoFMaNBufGp9sN = other.__p_Vt1HPx7wSoFMaNBufGp9sN;
            this.__p_CpQf4MIBohsQd91Le2eQ7r = other.__p_CpQf4MIBohsQd91Le2eQ7r;
            this.__cache_ShRQ7nHfiSGNCy1ivsFfJK = other.__cache_ShRQ7nHfiSGNCy1ivsFfJK;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Vt1HPx7wSoFMaNBufGp9sN", in __p_Vt1HPx7wSoFMaNBufGp9sN), n1.CompilationHelper.GetValueOrExisting(values, "__p_CpQf4MIBohsQd91Le2eQ7r", in __p_CpQf4MIBohsQd91Le2eQ7r), n1.CompilationHelper.GetValueOrExisting(values, "__cache_ShRQ7nHfiSGNCy1ivsFfJK", in __cache_ShRQ7nHfiSGNCy1ivsFfJK));
        }

        internal TooltipPaints_C __WITH__(n22.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_Vt1HPx7wSoFMaNBufGp9sN, n23.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_CpQf4MIBohsQd91Le2eQ7r, n13.Manager<n2.ValueTuple, n2.ValueTuple<n12.SkiaPaint_R, n7.Color4, n7.Color4, n7.Color4, n7.Color4, n12.SkiaPaint_R, n12.SkiaPaint_R, n2.ValueTuple<n12.SkiaPaint_R>>> __cache_ShRQ7nHfiSGNCy1ivsFfJK)
        {
            n3.TooltipPaints_C that_0 = this;
            this.__p_Vt1HPx7wSoFMaNBufGp9sN = __p_Vt1HPx7wSoFMaNBufGp9sN;
            this.__p_CpQf4MIBohsQd91Le2eQ7r = __p_CpQf4MIBohsQd91Le2eQ7r;
            this.__cache_ShRQ7nHfiSGNCy1ivsFfJK = __cache_ShRQ7nHfiSGNCy1ivsFfJK;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "T6kmwL6GK12OQvwS3FI1bL", Name = "__T6kmwL6GK12OQvwS3FI1bL")]
        [n2.SerializableAttribute]
        public class __T6kmwL6GK12OQvwS3FI1bL : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_TPfsFKK414HPsOOTdwZ7mP);
                n1.CompilationHelper.SafeDispose(this.__p_Q0GuxFRZGucMqvlP6sYy1x);
                n1.CompilationHelper.SafeDispose(this.__p_Itd2CDL0ZsTPgwluYLvO8B);
                n1.CompilationHelper.SafeDispose(this.__p_LsrQbLdISplMbjImkjIXc4);
                n1.CompilationHelper.SafeDispose(this.__p_SEYm6IGf2fLOhy243td4WE);
                n1.CompilationHelper.SafeDispose(this.__p_HNk2biYsSJsL759Kjk6RTb);
                n1.CompilationHelper.SafeDispose(this.__p_I9EfedXlnhFQT3j9KFMY9a);
                n1.CompilationHelper.SafeDispose(this.__p_NYCHZqlaJyGMLgbWF3WMMZ);
                return;
            }

            [n1.ElementAttribute(TracingId = 23365U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "TPfsFKK414HPsOOTdwZ7mP", Name = "Fill", IsManaged = true, IsAutoGenerated = true)]
            public n15.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_TPfsFKK414HPsOOTdwZ7mP;
            [n1.ElementAttribute(TracingId = 23525U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "Q0GuxFRZGucMqvlP6sYy1x", Name = "Typeface (FromName)", IsManaged = true, IsAutoGenerated = true)]
            public n16.Typeface_FromName_Q6b2DSnKxo3MAnm9n9ZKZo __p_Q0GuxFRZGucMqvlP6sYy1x;
            [n1.ElementAttribute(TracingId = 23537U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "Itd2CDL0ZsTPgwluYLvO8B", Name = "SetTypeface", IsManaged = true, IsAutoGenerated = true)]
            public n17.SetTypeface_Rj1JUzAL7GeMWPR8C8o16P __p_Itd2CDL0ZsTPgwluYLvO8B;
            [n1.ElementAttribute(TracingId = 23547U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "LsrQbLdISplMbjImkjIXc4", Name = "SetTextSize", IsManaged = true, IsAutoGenerated = true)]
            public n16.SetTextSize_QI38Jjk5kaVN53dJij0KIZ __p_LsrQbLdISplMbjImkjIXc4;
            [n1.ElementAttribute(TracingId = 23558U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "SEYm6IGf2fLOhy243td4WE", Name = "SetColor", IsManaged = true, IsAutoGenerated = true)]
            public n15.SetColor_ErmwE010oOSLqOYWImAOgN __p_SEYm6IGf2fLOhy243td4WE;
            [n1.ElementAttribute(TracingId = 23578U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "HNk2biYsSJsL759Kjk6RTb", Name = "SetLineHeight", IsManaged = true, IsAutoGenerated = true)]
            public n16.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a __p_HNk2biYsSJsL759Kjk6RTb;
            [n1.ElementAttribute(TracingId = 23610U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "I9EfedXlnhFQT3j9KFMY9a", Name = "SetColor", IsManaged = true, IsAutoGenerated = true)]
            public n15.SetColor_ErmwE010oOSLqOYWImAOgN __p_I9EfedXlnhFQT3j9KFMY9a;
            [n1.ElementAttribute(TracingId = 23650U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "NYCHZqlaJyGMLgbWF3WMMZ", Name = "SetColor", IsManaged = true, IsAutoGenerated = true)]
            public n15.SetColor_ErmwE010oOSLqOYWImAOgN __p_NYCHZqlaJyGMLgbWF3WMMZ;
            public __T6kmwL6GK12OQvwS3FI1bL(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __T6kmwL6GK12OQvwS3FI1bL(__T6kmwL6GK12OQvwS3FI1bL other): base(other)
            {
                this.__p_TPfsFKK414HPsOOTdwZ7mP = other.__p_TPfsFKK414HPsOOTdwZ7mP;
                this.__p_Q0GuxFRZGucMqvlP6sYy1x = other.__p_Q0GuxFRZGucMqvlP6sYy1x;
                this.__p_Itd2CDL0ZsTPgwluYLvO8B = other.__p_Itd2CDL0ZsTPgwluYLvO8B;
                this.__p_LsrQbLdISplMbjImkjIXc4 = other.__p_LsrQbLdISplMbjImkjIXc4;
                this.__p_SEYm6IGf2fLOhy243td4WE = other.__p_SEYm6IGf2fLOhy243td4WE;
                this.__p_HNk2biYsSJsL759Kjk6RTb = other.__p_HNk2biYsSJsL759Kjk6RTb;
                this.__p_I9EfedXlnhFQT3j9KFMY9a = other.__p_I9EfedXlnhFQT3j9KFMY9a;
                this.__p_NYCHZqlaJyGMLgbWF3WMMZ = other.__p_NYCHZqlaJyGMLgbWF3WMMZ;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TPfsFKK414HPsOOTdwZ7mP", in __p_TPfsFKK414HPsOOTdwZ7mP), n1.CompilationHelper.GetValueOrExisting(values, "__p_Q0GuxFRZGucMqvlP6sYy1x", in __p_Q0GuxFRZGucMqvlP6sYy1x), n1.CompilationHelper.GetValueOrExisting(values, "__p_Itd2CDL0ZsTPgwluYLvO8B", in __p_Itd2CDL0ZsTPgwluYLvO8B), n1.CompilationHelper.GetValueOrExisting(values, "__p_LsrQbLdISplMbjImkjIXc4", in __p_LsrQbLdISplMbjImkjIXc4), n1.CompilationHelper.GetValueOrExisting(values, "__p_SEYm6IGf2fLOhy243td4WE", in __p_SEYm6IGf2fLOhy243td4WE), n1.CompilationHelper.GetValueOrExisting(values, "__p_HNk2biYsSJsL759Kjk6RTb", in __p_HNk2biYsSJsL759Kjk6RTb), n1.CompilationHelper.GetValueOrExisting(values, "__p_I9EfedXlnhFQT3j9KFMY9a", in __p_I9EfedXlnhFQT3j9KFMY9a), n1.CompilationHelper.GetValueOrExisting(values, "__p_NYCHZqlaJyGMLgbWF3WMMZ", in __p_NYCHZqlaJyGMLgbWF3WMMZ));
            }

            internal __T6kmwL6GK12OQvwS3FI1bL __WITH__(n15.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_TPfsFKK414HPsOOTdwZ7mP, n16.Typeface_FromName_Q6b2DSnKxo3MAnm9n9ZKZo __p_Q0GuxFRZGucMqvlP6sYy1x, n17.SetTypeface_Rj1JUzAL7GeMWPR8C8o16P __p_Itd2CDL0ZsTPgwluYLvO8B, n16.SetTextSize_QI38Jjk5kaVN53dJij0KIZ __p_LsrQbLdISplMbjImkjIXc4, n15.SetColor_ErmwE010oOSLqOYWImAOgN __p_SEYm6IGf2fLOhy243td4WE, n16.SetLineHeight_VysdpZ99mE2QX4Oq15dX6a __p_HNk2biYsSJsL759Kjk6RTb, n15.SetColor_ErmwE010oOSLqOYWImAOgN __p_I9EfedXlnhFQT3j9KFMY9a, n15.SetColor_ErmwE010oOSLqOYWImAOgN __p_NYCHZqlaJyGMLgbWF3WMMZ)
            {
                __T6kmwL6GK12OQvwS3FI1bL that_0 = this;
                this.__p_TPfsFKK414HPsOOTdwZ7mP = __p_TPfsFKK414HPsOOTdwZ7mP;
                this.__p_Q0GuxFRZGucMqvlP6sYy1x = __p_Q0GuxFRZGucMqvlP6sYy1x;
                this.__p_Itd2CDL0ZsTPgwluYLvO8B = __p_Itd2CDL0ZsTPgwluYLvO8B;
                this.__p_LsrQbLdISplMbjImkjIXc4 = __p_LsrQbLdISplMbjImkjIXc4;
                this.__p_SEYm6IGf2fLOhy243td4WE = __p_SEYm6IGf2fLOhy243td4WE;
                this.__p_HNk2biYsSJsL759Kjk6RTb = __p_HNk2biYsSJsL759Kjk6RTb;
                this.__p_I9EfedXlnhFQT3j9KFMY9a = __p_I9EfedXlnhFQT3j9KFMY9a;
                this.__p_NYCHZqlaJyGMLgbWF3WMMZ = __p_NYCHZqlaJyGMLgbWF3WMMZ;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 21606U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void GetFillColor(string Style_Selector_In, out n7.Color4 Result_Out)
        {
            float __pad_C8Fa8oJupazPK7QSK249Su_0 = __slot_C8Fa8oJupazPK7QSK249Su;
            var Result_1 = n19.Styles.Catalog(styleSelector: Style_Selector_In);
            var Fill_2 = Result_1.Fill;
            var Color_3 = Fill_2.Color;
            var R_4 = Color_3.R;
            var G_5 = Color_3.G;
            var B_6 = Color_3.B;
            var A_7 = Color_3.A;
            float Input_8 = (float)A_7;
            var Output_9 = (float)Input_8 / __pad_C8Fa8oJupazPK7QSK249Su_0;
            float Input_10 = (float)R_4;
            var Output_11 = (float)Input_10 / __pad_C8Fa8oJupazPK7QSK249Su_0;
            float Input_12 = (float)G_5;
            var Output_13 = (float)Input_12 / __pad_C8Fa8oJupazPK7QSK249Su_0;
            float Input_14 = (float)B_6;
            var Output_15 = (float)Input_14 / __pad_C8Fa8oJupazPK7QSK249Su_0;
            var Result_16 = n24.ColorNodes.Join(red: Output_11, green: Output_13, blue: Output_15, alpha: Output_9);
            Result_Out = Result_16;
            return;
        }

        public static void GetStrokeColor(string Style_Selector_In, out n7.Color4 Result_Out)
        {
            float __pad_AOLs3p9KjfZMNCHhcDCTQn_0 = __slot_AOLs3p9KjfZMNCHhcDCTQn;
            var Result_1 = n19.Styles.Catalog(styleSelector: Style_Selector_In);
            var Stroke_2 = Result_1.Stroke;
            var Color_3 = Stroke_2.Color;
            var R_4 = Color_3.R;
            var G_5 = Color_3.G;
            var B_6 = Color_3.B;
            var A_7 = Color_3.A;
            float Input_8 = (float)A_7;
            var Output_9 = (float)Input_8 / __pad_AOLs3p9KjfZMNCHhcDCTQn_0;
            float Input_10 = (float)R_4;
            var Output_11 = (float)Input_10 / __pad_AOLs3p9KjfZMNCHhcDCTQn_0;
            float Input_12 = (float)G_5;
            var Output_13 = (float)Input_12 / __pad_AOLs3p9KjfZMNCHhcDCTQn_0;
            float Input_14 = (float)B_6;
            var Output_15 = (float)Input_14 / __pad_AOLs3p9KjfZMNCHhcDCTQn_0;
            var Result_16 = n24.ColorNodes.Join(red: Output_11, green: Output_13, blue: Output_15, alpha: Output_9);
            Result_Out = Result_16;
            return;
        }

        [n1.ElementAttribute(TracingId = 22666U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "C8Fa8oJupazPK7QSK249Su", Name = "__slot_C8Fa8oJupazPK7QSK249Su")]
        public static float __slot_C8Fa8oJupazPK7QSK249Su = 255F;
        [n1.ElementAttribute(TracingId = 22984U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "AOLs3p9KjfZMNCHhcDCTQn", Name = "__slot_AOLs3p9KjfZMNCHhcDCTQn")]
        public static float __slot_AOLs3p9KjfZMNCHhcDCTQn = 255F;
        static _Operations_()
        {
        }
    }
}

namespace _HDE_StylesAndSettings_.HDE.Settings
{
    [n1.ElementAttribute(TracingId = 21606U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void TooltipClassic(out bool Value_Out, out n27.BehaviorSubject<bool> Tooltip_Classic_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var Tooltip_Classic_1 = Input_0.TooltipClassic;
            n28._Operations_.Value<bool>(Input_In: Tooltip_Classic_1, Output_Out: out n27.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            Value_Out = Value_3;
            Tooltip_Classic_Out = Tooltip_Classic_1;
            return;
        }

        public static void TooltipScaling(out int Value_Out, out n27.BehaviorSubject<int> Tooltip_Scaling_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var Tooltip_Scaling_1 = Input_0.TooltipScaling;
            n28._Operations_.Value<int>(Input_In: Tooltip_Scaling_1, Output_Out: out n27.BehaviorSubject<int> Output_2, Value_Out: out int Value_3);
            Value_Out = Value_3;
            Tooltip_Scaling_Out = Tooltip_Scaling_1;
            return;
        }

        public static void TooltipShowAdvancedTimings(out bool Value_Out, out n27.BehaviorSubject<bool> Tooltip_Show_Advanced_Timings_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var Tooltip_Show_Advanced_Timings_1 = Input_0.TooltipShowAdvancedTimings;
            n28._Operations_.Value<bool>(Input_In: Tooltip_Show_Advanced_Timings_1, Output_Out: out n27.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            Value_Out = Value_3;
            Tooltip_Show_Advanced_Timings_Out = Tooltip_Show_Advanced_Timings_1;
            return;
        }

        public static void TooltipShowDocumentation(out bool Value_Out, out n27.BehaviorSubject<bool> Tooltip_Show_Documentation_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var Tooltip_Show_Documentation_1 = Input_0.TooltipShowDocumentation;
            n28._Operations_.Value<bool>(Input_In: Tooltip_Show_Documentation_1, Output_Out: out n27.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            Value_Out = Value_3;
            Tooltip_Show_Documentation_Out = Tooltip_Show_Documentation_1;
            return;
        }

        public static void TooltipShowLocalID(out bool Value_Out, out n27.BehaviorSubject<bool> Tooltip_Show_Local_ID_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var Tooltip_Show_Local_ID_1 = Input_0.TooltipShowLocalID;
            n28._Operations_.Value<bool>(Input_In: Tooltip_Show_Local_ID_1, Output_Out: out n27.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            Value_Out = Value_3;
            Tooltip_Show_Local_ID_Out = Tooltip_Show_Local_ID_1;
            return;
        }

        public static void TooltipShowMoreInfo(out bool Value_Out, out n27.BehaviorSubject<bool> Tooltip_Show_More_Info_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var Tooltip_Show_More_Info_1 = Input_0.TooltipShowMoreInfo;
            n28._Operations_.Value<bool>(Input_In: Tooltip_Show_More_Info_1, Output_Out: out n27.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            Value_Out = Value_3;
            Tooltip_Show_More_Info_Out = Tooltip_Show_More_Info_1;
            return;
        }

        public static void TooltipShowObjects(out bool Value_Out, out n27.BehaviorSubject<bool> Tooltip_Show_Objects_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var Tooltip_Show_Objects_1 = Input_0.TooltipShowObjects;
            n28._Operations_.Value<bool>(Input_In: Tooltip_Show_Objects_1, Output_Out: out n27.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            Value_Out = Value_3;
            Tooltip_Show_Objects_Out = Tooltip_Show_Objects_1;
            return;
        }

        public static void TooltipShowOperation(out bool Value_Out, out n27.BehaviorSubject<bool> Tooltip_Show_Operation_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var Tooltip_Show_Operation_1 = Input_0.TooltipShowOperation;
            n28._Operations_.Value<bool>(Input_In: Tooltip_Show_Operation_1, Output_Out: out n27.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            Value_Out = Value_3;
            Tooltip_Show_Operation_Out = Tooltip_Show_Operation_1;
            return;
        }

        public static void TooltipShowSymbolSource(out bool Value_Out, out n27.BehaviorSubject<bool> Tooltip_Show_Symbol_Source_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var Tooltip_Show_Symbol_Source_1 = Input_0.TooltipShowSymbolSource;
            n28._Operations_.Value<bool>(Input_In: Tooltip_Show_Symbol_Source_1, Output_Out: out n27.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            Value_Out = Value_3;
            Tooltip_Show_Symbol_Source_Out = Tooltip_Show_Symbol_Source_1;
            return;
        }

        public static void TooltipShowTimings(out bool Value_Out, out n27.BehaviorSubject<bool> Tooltip_Show_Timings_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var Tooltip_Show_Timings_1 = Input_0.TooltipShowTimings;
            n28._Operations_.Value<bool>(Input_In: Tooltip_Show_Timings_1, Output_Out: out n27.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            Value_Out = Value_3;
            Tooltip_Show_Timings_Out = Tooltip_Show_Timings_1;
            return;
        }

        public static void TooltipStdDelayInMilliSeconds(out int Value_Out, out n27.BehaviorSubject<int> Tooltip_Std_Delay_In_Milli_Seconds_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var Tooltip_Std_Delay_In_Milli_Seconds_1 = Input_0.TooltipStdDelayInMilliSeconds;
            n28._Operations_.Value<int>(Input_In: Tooltip_Std_Delay_In_Milli_Seconds_1, Output_Out: out n27.BehaviorSubject<int> Output_2, Value_Out: out int Value_3);
            Value_Out = Value_3;
            Tooltip_Std_Delay_In_Milli_Seconds_Out = Tooltip_Std_Delay_In_Milli_Seconds_1;
            return;
        }

        public static void ShowHelpOnStartup(out bool Value_Out, out n27.BehaviorSubject<bool> Show_Help_On_Startup_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var Show_Help_On_Startup_1 = Input_0.ShowHelpOnStartup;
            n28._Operations_.Value<bool>(Input_In: Show_Help_On_Startup_1, Output_Out: out n27.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            Value_Out = Value_3;
            Show_Help_On_Startup_Out = Show_Help_On_Startup_1;
            return;
        }

        public static void NewDocumentIfNoneLoaded(out bool Value_Out, out n27.BehaviorSubject<bool> New_Document_If_None_Loaded_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var New_Document_If_None_Loaded_1 = Input_0.NewDocumentIfNoneLoaded;
            n28._Operations_.Value<bool>(Input_In: New_Document_If_None_Loaded_1, Output_Out: out n27.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            Value_Out = Value_3;
            New_Document_If_None_Loaded_Out = New_Document_If_None_Loaded_1;
            return;
        }

        public static void NodeShowWarningIfExperimental(out bool Value_Out, out n27.BehaviorSubject<bool> Node_Show_Warning_If_Experimental_Out)
        {
            n26.Settings Input_0 = n25._Operations_.CreateDefault();
            var Node_Show_Warning_If_Experimental_1 = Input_0.NodeShowWarningIfExperimental;
            n28._Operations_.Value<bool>(Input_In: Node_Show_Warning_If_Experimental_1, Output_Out: out n27.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            Value_Out = Value_3;
            Node_Show_Warning_If_Experimental_Out = Node_Show_Warning_If_Experimental_1;
            return;
        }
    }
}

namespace _HDE_StylesAndSettings_.HDE.Settings.Settings.Internal
{
    [n1.ElementAttribute(TracingId = 21606U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n26.Settings CreateDefault()
        {
            var Settings_0 = n26.SettingsManager.Settings;
            return Settings_0;
        }
    }
}

namespace _HDE_StylesAndSettings_.HDE
{
    [n1.ElementAttribute(TracingId = 25953U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", PersistentId = "TFoypXDu1uzLATplKGEKq5", Name = "HDE_StylesAndSettingsApplication_TFoypXDu1uzLATplKGEKq5")]
    [n2.SerializableAttribute]
    public class HDE_StylesAndSettingsApplication_TFoypXDu1uzLATplKGEKq5 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n29.HDE_StylesAndSettingsApplication_TFoypXDu1uzLATplKGEKq5 Create(n1.NodeContext Node_Context)
        {
            var instance = new HDE_StylesAndSettingsApplication_TFoypXDu1uzLATplKGEKq5(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n29.HDE_StylesAndSettingsApplication_TFoypXDu1uzLATplKGEKq5 CreateDefault()
        {
            var instance = new HDE_StylesAndSettingsApplication_TFoypXDu1uzLATplKGEKq5(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n29.HDE_StylesAndSettingsApplication_TFoypXDu1uzLATplKGEKq5 Update()
        {
            return this;
        }

        public n29.HDE_StylesAndSettingsApplication_TFoypXDu1uzLATplKGEKq5 __Create__(n1.NodeContext Node_Context)
        {
            n9.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n29.HDE_StylesAndSettingsApplication_TFoypXDu1uzLATplKGEKq5 __CreateDefault__()
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

        public HDE_StylesAndSettingsApplication_TFoypXDu1uzLATplKGEKq5(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HDE_StylesAndSettingsApplication_TFoypXDu1uzLATplKGEKq5(HDE_StylesAndSettingsApplication_TFoypXDu1uzLATplKGEKq5 other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal HDE_StylesAndSettingsApplication_TFoypXDu1uzLATplKGEKq5 __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 21606U, DocumentId = "QJQ0tnl56B9MNMEaY2eCRr", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void GetMainWindowBoundsInPixel(out n30.Rectangle Result_Out)
        {
            var Get_Main_Window_Bounds_0 = n26.WindowLayout.GetMainWindowBounds;
            n31._Operations_.Invoke<n30.Rectangle>(Input_In: Get_Main_Window_Bounds_0, Result_Out: out n30.Rectangle Result_1);
            Result_Out = Result_1;
            return;
        }
    }
}

namespace _HDE_StylesAndSettings_
{
    public struct __AdaptiveImplementations__QJQ0tnl56B9MNMEaY2eCRr : n33.IAdaptiveCreateDefault<n30.Rectangle>
    {
        public void CreateDefault(out n30.Rectangle Output_Out)
        {
            n32._Operations_.CreateDefault_Generic<n30.Rectangle>(Output_Out: out n30.Rectangle Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}