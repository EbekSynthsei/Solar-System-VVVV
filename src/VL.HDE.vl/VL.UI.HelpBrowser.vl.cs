extern alias e5;
extern alias e3;
extern alias e2;
extern alias e1;
extern alias e10;
extern alias e4;

using n24 = e2::VL.Lib.Collections;
using n8 = _VL_Skia_.Graphics.Skia;
using n22 = e2::VL.Lib.Primitive;
using n5 = global::System.Reactive.Subjects;
using n36 = _HelpbrowserMPages_.HelpBrowser.Pages.Connect;
using n35 = _HelpbrowserMPages_.HelpBrowser.Pages.Shortcuts;
using n47 = _CoreLibBasics_.Primitive.Object.Advanced;
using n29 = e5::VL.Lib.IO.Notifications;
using n39 = _CoreLibBasics_.Control;
using n32 = _HelpbrowserMLib_.HelpBrowser.Utils;
using n40 = _VL_Skia_.Graphics.Skia.Layers;
using n46 = _VL_UI_HelpBrowser_;
using n12 = e3::VL.Lib.Reactive;
using n11 = _VL_Reactive_.Reactive.Subjects.BehaviorSubject.Advanced;
using n26 = _CoreLibBasics_.Primitive;
using n18 = _HelpbrowserMLib_.HelpBrowser.Paints;
using n41 = _HelpbrowserMLib_.HelpBrowser.Settings;
using n19 = global::System.Collections.Generic;
using n23 = _HelpbrowserMLib_.HelpBrowser;
using n44 = _HelpbrowserMLib_.HelpBrowser.News;
using n25 = _VL_Skia_.Graphics.Skia.Layer.Advanced;
using n48 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n17 = e5::VL.UI.Core;
using n27 = e10::VL.Model;
using n21 = e3::VL.Lib.Primitive;
using n43 = e2::VL.Lib.Runtime;
using n38 = _HelpbrowserMPages_.HelpBrowser.Pages;
using n4 = _VL_UI_HelpBrowser_.HelpBrowser;
using n31 = e3::VL.Lib.Mathematics;
using n1 = e2::VL.Core;
using n2 = global::System;
using n9 = e4::Stride.Core.Mathematics;
using n45 = _System_Reflection_.System.Reflection.IVLFactory.Experimental;
using n16 = _VL_HDE_.HDE;
using n6 = e2::VL.Core.CompilerServices;
using n10 = global::System.Windows.Forms;
using n13 = _VL_Reactive_.Reactive.ForEach;
using n33 = _HelpbrowserMPages_.HelpBrowser.Pages.Learn;
using n20 = _VL_Reactive_.Reactive.HoldLatest;
using n14 = global::System.Runtime.CompilerServices;
using n34 = _HelpbrowserMPages_.HelpBrowser.Pages.Home;
using n30 = _VL_Skia_.Graphics.Skia.Console;
using n28 = e5::VL.Lib.IO;
using n7 = e1::VL.Skia;
using n42 = e10::VL.Lang.PublicAPI;
using n37 = _VL_Collections_.Collections.Spread;
using n3 = global::System.Drawing;
using n15 = global::System.Reactive;

namespace _VL_UI_HelpBrowser_.HelpBrowser
{
    [n1.ElementAttribute(TracingId = 49118U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "LcBtpLS5UyoODipHZhLL4t", Name = "HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t")]
    [n2.SerializableAttribute]
    public class HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t Create(n1.NodeContext Node_Context, n5.BehaviorSubject<bool> Focused_In)
        {
            var instance = new HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context, Focused_In);
        }

        [n6.CreateDefaultAttribute]
        public static n4.HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t CreateDefault()
        {
            var instance = new HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t Update(n7.ILayer Input_In, [n6.SerializedDefaultValueAttribute("False", false)] bool Update_Styles_In, n5.BehaviorSubject<bool> Visibility_In)
        {
            string __pad_RifvKm1Fl66NSzvC7UU6i8_0 = __slot_RifvKm1Fl66NSzvC7UU6i8;
            n3.Rectangle __pad_PTZkPDoLL37O2oAj7njtpd_1 = this.__slot_PTZkPDoLL37O2oAj7njtpd;
            n7.SkiaRenderer __auto_2 = this.Form;
            var Output_13 = this.__p_SXlxz6xU6pHL0igIU5eCcq.Update(Reload_In: Update_Styles_In, Window_Background_Out: out n8.SkiaPaint_R Window_Background_3, Background_Color_Out: out n9.Color4 Background_Color_4, Text_Out: out n8.SkiaPaint_R Text_5, Default_Out: out n9.Color4 Default_6, Hover_Out: out n9.Color4 Hover_7, Active_Out: out n9.Color4 Active_8, Button_Default_Out: out n9.Color4 Button_Default_9, Button_Hover_Out: out n9.Color4 Button_Hover_10, Button_Text_Out: out n8.SkiaPaint_R Button_Text_11, Scroll_Color_Out: out n8.SkiaPaint_R Scroll_Color_12);
            bool Show_Control_Box_14 = true;
            n10.FormBorderStyle Border_Style_15 = __c_RXZgtQptNXWP8hFEKeBj4L;
            n7.CommonSpace Space_16 = __c_A2LQmVODDfNLIzrIHbeZCt;
            bool Show_17 = true;
            var Output_19 = this.__p_NOufyAnTnskQXDtexuxILr.Update(Bounds_In: __pad_PTZkPDoLL37O2oAj7njtpd_1, Name_In: __pad_RifvKm1Fl66NSzvC7UU6i8_0, Show_Control_Box_In: Show_Control_Box_14, Border_Style_In: Border_Style_15, Input_In: Input_In, Color_In: Background_Color_4, Space_In: Space_16, Show_In: Show_17, On_Close_Out: out bool On_Close_18);
            if (On_Close_18)
            {
                bool __pad_CeiU0ynHLI0MX7riD86G26_21 = __slot_CeiU0ynHLI0MX7riD86G26;
                n11._Operations_.OnNext<bool>(Input_In: Visibility_In, Value_In: __pad_CeiU0ynHLI0MX7riD86G26_21, Output_Out: out n5.BehaviorSubject<bool> Output_22);
            }

            n2.IObservable<bool> Messages_23 = (n2.IObservable<bool>)Visibility_In;
            bool Reset_24 = false;
            var __fallback___25 = n1.ServiceRegistry.Current;
            n13._Operations_.Update_H<n2.Object, bool, n10.Control>(Input_In: this.__p_MfYkPicjiv6M0z0adXwHwz, Messages_In: Messages_23, Reset_In: Reset_24, Update_In: (n2.Object s_28, bool Input_1_In_29) =>
            {
                using var __current_26 = __fallback___25.MakeCurrentIfNone();
                var state_27 = n1.CompilationHelper.Restore<__NoFqDcDV5TDOZgC0FGClpy>(s_28, __GetContext__());
                bool __pad_RfqfgkyYnNmPucIADwpqci_30 = __slot_RfqfgkyYnNmPucIADwpqci;
                var Result_31 = Input_1_In_29 == __pad_RfqfgkyYnNmPucIADwpqci_30;
                n10.FormWindowState Value_32 = default(n10.FormWindowState);
                var Output_33 = __auto_2;
                if (Result_31)
                {
                    __auto_2.WindowState = Value_32;
                }

                var Output_34 = Output_33;
                if (Result_31)
                {
                    Output_33.BringToFront();
                }

                return n2.Tuple.Create<n2.Object, n10.Control>(state_27, Output_34);
            }

            , Create_In: () =>
            {
                using var __current_35 = __fallback___25.MakeCurrentIfNone();
                var state_27 = new __NoFqDcDV5TDOZgC0FGClpy(__GetContext__(), n1.VLObject.NewIdentity());
                return state_27;
            }

            , Output_Out: out n12.ForEach<n2.Object, bool, n10.Control> Output_36, Result_Out: out n2.IObservable<n10.Control> Result_37);
            n4.HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t that_38 = this;
            if (this.__GetContext__().IsImmutable)
                that_38 = Output_13 != this.__p_SXlxz6xU6pHL0igIU5eCcq || Output_19 != this.__p_NOufyAnTnskQXDtexuxILr || Output_36 != this.__p_MfYkPicjiv6M0z0adXwHwz ? new HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t(this)
                {__p_SXlxz6xU6pHL0igIU5eCcq = Output_13, __p_NOufyAnTnskQXDtexuxILr = Output_19, __p_MfYkPicjiv6M0z0adXwHwz = Output_36} : that_38;
            else
            {
                this.__p_SXlxz6xU6pHL0igIU5eCcq = Output_13;
                this.__p_NOufyAnTnskQXDtexuxILr = Output_19;
                this.__p_MfYkPicjiv6M0z0adXwHwz = Output_36;
            }

            return that_38;
        }

        public n4.HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t __Create__(n1.NodeContext Node_Context, n5.BehaviorSubject<bool> Focused_In)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Size __pad_IAOakAStYVbMcgY5TRF0gB_0 = __slot_IAOakAStYVbMcgY5TRF0gB;
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "KbbCpXyHwqUN40v8AxHC7S", 52804U);
            n13._Operations_.Create_H<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>>(Node_Context: Node_Context_1, Output_Out: out n12.ForEach<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>> Output_2);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "NOufyAnTnskQXDtexuxILr", 49121U);
            var Output_4 = n16.SkiaWindow_C.Create(Node_Context: Node_Context_3);
            var Output_6 = Output_4.GetForm(Form_Out: out n7.SkiaRenderer Form_5);
            string Event_Name_7 = "Deactivate";
            var return_8 = n1.EventBridge.FromEventPattern(target: Form_5, eventName: Event_Name_7);
            bool Reset_9 = false;
            var __fallback___10 = n1.ServiceRegistry.Current;
            n13._Operations_.Update_H<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>>(Input_In: Output_2, Messages_In: return_8, Reset_In: Reset_9, Update_In: (n2.Object s_12, n15.EventPattern<n2.Object> Input_1_In_13) =>
            {
                using var __current_11 = __fallback___10.MakeCurrentIfNone();
                var state_12 = n1.CompilationHelper.Restore<__Kwn350iMZ9kQHcxwUmP9T3>(s_12, Node_Context);
                bool __pad_HB1faT3cHg4ObWrvCj3GcO_14 = __slot_HB1faT3cHg4ObWrvCj3GcO;
                n11._Operations_.OnNext<bool>(Input_In: Focused_In, Value_In: __pad_HB1faT3cHg4ObWrvCj3GcO_14, Output_Out: out n5.BehaviorSubject<bool> Output_15);
                return n2.Tuple.Create<n2.Object, n5.BehaviorSubject<bool>>(state_12, Output_15);
            }

            , Create_In: () =>
            {
                using var __current_16 = __fallback___10.MakeCurrentIfNone();
                var state_12 = new __Kwn350iMZ9kQHcxwUmP9T3(Node_Context, n1.VLObject.NewIdentity());
                return state_12;
            }

            , Output_Out: out n12.ForEach<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>> Output_17, Result_Out: out n2.IObservable<n5.BehaviorSubject<bool>> Result_18);
            var Output_19 = n17.DIPHelpers.DIPToPixel(pixel: __pad_IAOakAStYVbMcgY5TRF0gB_0);
            Form_5.MinimumSize = Output_19;
            string Event_Name_20 = "Activated";
            var return_21 = n1.EventBridge.FromEventPattern(target: Form_5, eventName: Event_Name_20);
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "Numfhd516NzPrGCOJV24B1", 52852U);
            n13._Operations_.Create_H<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>>(Node_Context: Node_Context_22, Output_Out: out n12.ForEach<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>> Output_23);
            bool Reset_24 = false;
            n13._Operations_.Update_H<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>>(Input_In: Output_23, Messages_In: return_21, Reset_In: Reset_24, Update_In: (n2.Object s_26, n15.EventPattern<n2.Object> Input_1_In_27) =>
            {
                using var __current_25 = __fallback___10.MakeCurrentIfNone();
                var state_27 = n1.CompilationHelper.Restore<__MpDflinBMqFPqkUTtnylSm>(s_26, Node_Context);
                bool __pad_J9fzs1DI8ncMdkljyR2tfq_28 = __slot_J9fzs1DI8ncMdkljyR2tfq;
                n11._Operations_.OnNext<bool>(Input_In: Focused_In, Value_In: __pad_J9fzs1DI8ncMdkljyR2tfq_28, Output_Out: out n5.BehaviorSubject<bool> Output_29);
                return n2.Tuple.Create<n2.Object, n5.BehaviorSubject<bool>>(state_27, Output_29);
            }

            , Create_In: () =>
            {
                using var __current_30 = __fallback___10.MakeCurrentIfNone();
                var state_27 = new __MpDflinBMqFPqkUTtnylSm(Node_Context, n1.VLObject.NewIdentity());
                return state_27;
            }

            , Output_Out: out n12.ForEach<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>> Output_31, Result_Out: out n2.IObservable<n5.BehaviorSubject<bool>> Result_32);
            n7.SkiaRenderer __auto_33 = Form_5;
            int Width_34 = 580;
            n16._Operations_.WindowBounds_EditorHeight(Width_In: Width_34, Output_Out: out n3.Rectangle Output_35);
            n3.Rectangle __pad_PTZkPDoLL37O2oAj7njtpd_36 = Output_35;
            n1.NodeContext Node_Context_37 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "SXlxz6xU6pHL0igIU5eCcq", 52661U);
            var Output_38 = n18.MainPaint_G1g1p6KB37CMdxFrJLrOvQ.Create(Node_Context: Node_Context_37);
            n1.NodeContext Node_Context_39 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "MfYkPicjiv6M0z0adXwHwz", 52732U);
            n13._Operations_.Create_H<n2.Object, bool, n10.Control>(Node_Context: Node_Context_39, Output_Out: out n12.ForEach<n2.Object, bool, n10.Control> Output_40);
            n4.HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t that_41 = this;
            this.__slot_PTZkPDoLL37O2oAj7njtpd = Output_35;
            this.Form = Form_5;
            this.__p_KbbCpXyHwqUN40v8AxHC7S = Output_17;
            this.__p_NOufyAnTnskQXDtexuxILr = Output_6;
            this.__p_Numfhd516NzPrGCOJV24B1 = Output_31;
            this.__p_SXlxz6xU6pHL0igIU5eCcq = Output_38;
            this.__p_MfYkPicjiv6M0z0adXwHwz = Output_40;
            return that_41;
        }

        public n4.HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t __CreateDefault__()
        {
            n4.HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t that_0 = this;
            this.__slot_PTZkPDoLL37O2oAj7njtpd = default(n3.Rectangle);
            this.Form = default(n7.SkiaRenderer);
            this.__p_SXlxz6xU6pHL0igIU5eCcq = n18.MainPaint_G1g1p6KB37CMdxFrJLrOvQ.CreateDefault();
            this.__p_NOufyAnTnskQXDtexuxILr = n16.SkiaWindow_C.CreateDefault();
            this.__p_MfYkPicjiv6M0z0adXwHwz = default(n12.ForEach<n2.Object, bool, n10.Control>);
            this.__p_KbbCpXyHwqUN40v8AxHC7S = default(n12.ForEach<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>>);
            this.__p_Numfhd516NzPrGCOJV24B1 = default(n12.ForEach<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SXlxz6xU6pHL0igIU5eCcq);
            n1.CompilationHelper.SafeDispose(this.__p_NOufyAnTnskQXDtexuxILr);
            n1.CompilationHelper.SafeDispose(this.__p_MfYkPicjiv6M0z0adXwHwz);
            n1.CompilationHelper.SafeDispose(this.__p_KbbCpXyHwqUN40v8AxHC7S);
            n1.CompilationHelper.SafeDispose(this.__p_Numfhd516NzPrGCOJV24B1);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 52632U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "IAOakAStYVbMcgY5TRF0gB", Name = "__slot_IAOakAStYVbMcgY5TRF0gB")]
        public static n3.Size __slot_IAOakAStYVbMcgY5TRF0gB = n1.CompilationHelper.Deserialize<n3.Size>("580, 200", false, "VFVf8GD51Z9PxcEkRZP1RR", "IAOakAStYVbMcgY5TRF0gB");
        [n1.ElementAttribute(TracingId = 52645U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "RifvKm1Fl66NSzvC7UU6i8", Name = "__slot_RifvKm1Fl66NSzvC7UU6i8")]
        public static string __slot_RifvKm1Fl66NSzvC7UU6i8 = "Help Browser";
        [n1.ElementAttribute(TracingId = 52902U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "PTZkPDoLL37O2oAj7njtpd", Name = "__slot_PTZkPDoLL37O2oAj7njtpd")]
        public n3.Rectangle __slot_PTZkPDoLL37O2oAj7njtpd;
        [n1.ElementAttribute(TracingId = 52691U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "ALboqqr8L6BNYuAI6F2g52", Name = "Form")]
        public n7.SkiaRenderer Form;
        [n1.ElementAttribute(TracingId = 52661U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "SXlxz6xU6pHL0igIU5eCcq", Name = "MainPaint", IsManaged = true, IsAutoGenerated = true)]
        public n18.MainPaint_G1g1p6KB37CMdxFrJLrOvQ __p_SXlxz6xU6pHL0igIU5eCcq;
        [n1.ElementAttribute(TracingId = 49121U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "NOufyAnTnskQXDtexuxILr", Name = "SkiaWindow", IsManaged = true, IsAutoGenerated = true)]
        public n16.SkiaWindow_C __p_NOufyAnTnskQXDtexuxILr;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n10.FormBorderStyle __c_RXZgtQptNXWP8hFEKeBj4L = n1.CompilationHelper.Deserialize<n10.FormBorderStyle>("Sizable", false, "VFVf8GD51Z9PxcEkRZP1RR", "RXZgtQptNXWP8hFEKeBj4L");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.CommonSpace __c_A2LQmVODDfNLIzrIHbeZCt = n1.CompilationHelper.Deserialize<n7.CommonSpace>("DIPTopLeft", false, "VFVf8GD51Z9PxcEkRZP1RR", "A2LQmVODDfNLIzrIHbeZCt");
        [n1.ElementAttribute(TracingId = 52720U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "CeiU0ynHLI0MX7riD86G26", Name = "__slot_CeiU0ynHLI0MX7riD86G26")]
        public static bool __slot_CeiU0ynHLI0MX7riD86G26 = false;
        [n1.ElementAttribute(TracingId = 52732U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "MfYkPicjiv6M0z0adXwHwz", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n12.ForEach<n2.Object, bool, n10.Control> __p_MfYkPicjiv6M0z0adXwHwz;
        [n1.ElementAttribute(TracingId = 52777U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "RfqfgkyYnNmPucIADwpqci", Name = "__slot_RfqfgkyYnNmPucIADwpqci")]
        public static bool __slot_RfqfgkyYnNmPucIADwpqci = true;
        [n1.ElementAttribute(TracingId = 52804U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "KbbCpXyHwqUN40v8AxHC7S", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n12.ForEach<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>> __p_KbbCpXyHwqUN40v8AxHC7S;
        [n1.ElementAttribute(TracingId = 52843U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "HB1faT3cHg4ObWrvCj3GcO", Name = "__slot_HB1faT3cHg4ObWrvCj3GcO")]
        public static bool __slot_HB1faT3cHg4ObWrvCj3GcO = false;
        [n1.ElementAttribute(TracingId = 52852U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "Numfhd516NzPrGCOJV24B1", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n12.ForEach<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>> __p_Numfhd516NzPrGCOJV24B1;
        [n1.ElementAttribute(TracingId = 52886U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "J9fzs1DI8ncMdkljyR2tfq", Name = "__slot_J9fzs1DI8ncMdkljyR2tfq")]
        public static bool __slot_J9fzs1DI8ncMdkljyR2tfq = true;
        static HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t()
        {
        }

        public HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t(HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t other): base(other)
        {
            this.__slot_PTZkPDoLL37O2oAj7njtpd = other.__slot_PTZkPDoLL37O2oAj7njtpd;
            this.Form = other.Form;
            this.__p_SXlxz6xU6pHL0igIU5eCcq = other.__p_SXlxz6xU6pHL0igIU5eCcq;
            this.__p_NOufyAnTnskQXDtexuxILr = other.__p_NOufyAnTnskQXDtexuxILr;
            this.__p_MfYkPicjiv6M0z0adXwHwz = other.__p_MfYkPicjiv6M0z0adXwHwz;
            this.__p_KbbCpXyHwqUN40v8AxHC7S = other.__p_KbbCpXyHwqUN40v8AxHC7S;
            this.__p_Numfhd516NzPrGCOJV24B1 = other.__p_Numfhd516NzPrGCOJV24B1;
        }

        protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_PTZkPDoLL37O2oAj7njtpd", in __slot_PTZkPDoLL37O2oAj7njtpd), n1.CompilationHelper.GetValueOrExisting(values, "Form", in Form), n1.CompilationHelper.GetValueOrExisting(values, "__p_SXlxz6xU6pHL0igIU5eCcq", in __p_SXlxz6xU6pHL0igIU5eCcq), n1.CompilationHelper.GetValueOrExisting(values, "__p_NOufyAnTnskQXDtexuxILr", in __p_NOufyAnTnskQXDtexuxILr), n1.CompilationHelper.GetValueOrExisting(values, "__p_MfYkPicjiv6M0z0adXwHwz", in __p_MfYkPicjiv6M0z0adXwHwz), n1.CompilationHelper.GetValueOrExisting(values, "__p_KbbCpXyHwqUN40v8AxHC7S", in __p_KbbCpXyHwqUN40v8AxHC7S), n1.CompilationHelper.GetValueOrExisting(values, "__p_Numfhd516NzPrGCOJV24B1", in __p_Numfhd516NzPrGCOJV24B1));
        }

        internal HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t __WITH__(n3.Rectangle __slot_PTZkPDoLL37O2oAj7njtpd, n7.SkiaRenderer Form, n18.MainPaint_G1g1p6KB37CMdxFrJLrOvQ __p_SXlxz6xU6pHL0igIU5eCcq, n16.SkiaWindow_C __p_NOufyAnTnskQXDtexuxILr, n12.ForEach<n2.Object, bool, n10.Control> __p_MfYkPicjiv6M0z0adXwHwz, n12.ForEach<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>> __p_KbbCpXyHwqUN40v8AxHC7S, n12.ForEach<n2.Object, n15.EventPattern<n2.Object>, n5.BehaviorSubject<bool>> __p_Numfhd516NzPrGCOJV24B1)
        {
            n4.HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = !n19.EqualityComparer<n3.Rectangle>.Default.Equals(__slot_PTZkPDoLL37O2oAj7njtpd, this.__slot_PTZkPDoLL37O2oAj7njtpd) || Form != this.Form || __p_SXlxz6xU6pHL0igIU5eCcq != this.__p_SXlxz6xU6pHL0igIU5eCcq || __p_NOufyAnTnskQXDtexuxILr != this.__p_NOufyAnTnskQXDtexuxILr || __p_MfYkPicjiv6M0z0adXwHwz != this.__p_MfYkPicjiv6M0z0adXwHwz || __p_KbbCpXyHwqUN40v8AxHC7S != this.__p_KbbCpXyHwqUN40v8AxHC7S || __p_Numfhd516NzPrGCOJV24B1 != this.__p_Numfhd516NzPrGCOJV24B1 ? new HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t(this)
                {__slot_PTZkPDoLL37O2oAj7njtpd = __slot_PTZkPDoLL37O2oAj7njtpd, Form = Form, __p_SXlxz6xU6pHL0igIU5eCcq = __p_SXlxz6xU6pHL0igIU5eCcq, __p_NOufyAnTnskQXDtexuxILr = __p_NOufyAnTnskQXDtexuxILr, __p_MfYkPicjiv6M0z0adXwHwz = __p_MfYkPicjiv6M0z0adXwHwz, __p_KbbCpXyHwqUN40v8AxHC7S = __p_KbbCpXyHwqUN40v8AxHC7S, __p_Numfhd516NzPrGCOJV24B1 = __p_Numfhd516NzPrGCOJV24B1} : that_0;
            else
            {
                this.__slot_PTZkPDoLL37O2oAj7njtpd = __slot_PTZkPDoLL37O2oAj7njtpd;
                this.Form = Form;
                this.__p_SXlxz6xU6pHL0igIU5eCcq = __p_SXlxz6xU6pHL0igIU5eCcq;
                this.__p_NOufyAnTnskQXDtexuxILr = __p_NOufyAnTnskQXDtexuxILr;
                this.__p_MfYkPicjiv6M0z0adXwHwz = __p_MfYkPicjiv6M0z0adXwHwz;
                this.__p_KbbCpXyHwqUN40v8AxHC7S = __p_KbbCpXyHwqUN40v8AxHC7S;
                this.__p_Numfhd516NzPrGCOJV24B1 = __p_Numfhd516NzPrGCOJV24B1;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "NoFqDcDV5TDOZgC0FGClpy", Name = "__NoFqDcDV5TDOZgC0FGClpy")]
        [n2.SerializableAttribute]
        public class __NoFqDcDV5TDOZgC0FGClpy : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __NoFqDcDV5TDOZgC0FGClpy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __NoFqDcDV5TDOZgC0FGClpy(__NoFqDcDV5TDOZgC0FGClpy other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __NoFqDcDV5TDOZgC0FGClpy __WITH__()
            {
                return this;
            }
        }

        [n1.ElementAttribute(DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "Kwn350iMZ9kQHcxwUmP9T3", Name = "__Kwn350iMZ9kQHcxwUmP9T3")]
        [n2.SerializableAttribute]
        public class __Kwn350iMZ9kQHcxwUmP9T3 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __Kwn350iMZ9kQHcxwUmP9T3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Kwn350iMZ9kQHcxwUmP9T3(__Kwn350iMZ9kQHcxwUmP9T3 other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __Kwn350iMZ9kQHcxwUmP9T3 __WITH__()
            {
                return this;
            }
        }

        [n1.ElementAttribute(DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "MpDflinBMqFPqkUTtnylSm", Name = "__MpDflinBMqFPqkUTtnylSm")]
        [n2.SerializableAttribute]
        public class __MpDflinBMqFPqkUTtnylSm : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __MpDflinBMqFPqkUTtnylSm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MpDflinBMqFPqkUTtnylSm(__MpDflinBMqFPqkUTtnylSm other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __MpDflinBMqFPqkUTtnylSm __WITH__()
            {
                return this;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 55284U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "VDWmDkmaxTYLnP0S8RHP0r", Name = "HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r")]
    [n2.SerializableAttribute]
    public class HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r Create(n1.NodeContext Node_Context)
        {
            var instance = new HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r CreateDefault()
        {
            var instance = new HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r Update(n5.BehaviorSubject<bool> Visibility_In, n5.BehaviorSubject<n23.ContentData_R> Content_In)
        {
            n5.BehaviorSubject<bool> __auto_0 = this.Focused;
            n5.BehaviorSubject<string> __auto_1 = this.Stylesheet;
            n2.IObservable<string> Async_Notifications_2 = (n2.IObservable<string>)__auto_1;
            bool Reset_3 = false;
            bool Update_4 = true;
            var Output_5 = this.__p_GaJr0N6vPQmNNWhy2G2vOh;
            if (Update_4)
            {
                n20._Operations_.Update_H<string>(Input_In: this.__p_GaJr0N6vPQmNNWhy2G2vOh, Async_Notifications_In: Async_Notifications_2, Reset_In: Reset_3, Output_Out: out Output_5);
            }

            n20._Operations_.GetData_H<string>(Input_In: Output_5, Output_Out: out n12.HoldLatest<string> Output_6, Value_Out: out string Value_7, On_Data_Out: out bool On_Data_8);
            bool Enabled_9 = true;
            n21.ProcessLifespan Lifespan_10 = __c_NIzLQlFGp8jOYuFGmJRo52;
            bool Update_11 = true;
            var customRegion_12 = this.__customRegion_SVd8li36XFSM0qEwmwk6Rt ?? new n22.CustomRegion();
            customRegion_12.newPatchSymbol = 9353461;
            customRegion_12.BeginChanges();
            customRegion_12.AddIncomingLink(typeof(n5.BehaviorSubject<bool>), 0);
            customRegion_12.AddIncomingLink(typeof(n5.BehaviorSubject<n23.ContentData_R>), 1);
            customRegion_12.AddOutput("", typeof(n7.ILayer), 0);
            customRegion_12.SetInputValues();
            customRegion_12.SetIncomingLinkValues(__auto_0, Content_In);
            customRegion_12.EndChanges();
            var __fallback___13 = n1.ServiceRegistry.Current;
            customRegion_12.PatchUpdator = (n2.Object stateInput_16, n19.IReadOnlyList<n2.Object> inputs_17, n19.IReadOnlyList<n2.Object> incomingLinks_18, out n2.Object stateOutput_21, out n24.Spread<n2.Object> outputs_22) =>
            {
                using var __current_14 = __fallback___13.MakeCurrentIfNone();
                var state_15 = n1.CompilationHelper.Restore<__Q14JjcE0pmNPWr6Q7P78k5>(stateInput_16, __GetContext__());
                var link_EXOU10mZKcALGWyulQdl8Y_19 = (n5.BehaviorSubject<bool>)incomingLinks_18[0];
                var link_HfpWvsypRxRMPsGaL1jyEa_20 = (n5.BehaviorSubject<n23.ContentData_R>)incomingLinks_18[1];
                var State_Output_24 = state_15.__p_Hd8ThlHhF8rQcpGJz4KrpA.Update(Focused_In: link_EXOU10mZKcALGWyulQdl8Y_19, Content_In: link_HfpWvsypRxRMPsGaL1jyEa_20, Output_Out: out n7.ILayer Output_23);
                if (state_15.__GetContext__().IsImmutable)
                    state_15 = State_Output_24 != state_15.__p_Hd8ThlHhF8rQcpGJz4KrpA ? new __Q14JjcE0pmNPWr6Q7P78k5(state_15)
                    {__p_Hd8ThlHhF8rQcpGJz4KrpA = State_Output_24} : state_15;
                else
                {
                    state_15.__p_Hd8ThlHhF8rQcpGJz4KrpA = State_Output_24;
                }

                stateOutput_21 = state_15;
                outputs_22 = n6.CollectionExtensions.CreateSpreadOfObjects(Output_23);
            }

            ;
            customRegion_12.PatchCreator = (n19.IReadOnlyList<n2.Object> initialInputs_26, out n2.Object stateOutput_27, out n24.Spread<n2.Object> initialOutputs_28) =>
            {
                using var __current_25 = __fallback___13.MakeCurrentIfNone();
                var state_15 = new __Q14JjcE0pmNPWr6Q7P78k5(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "Hd8ThlHhF8rQcpGJz4KrpA", 55429U);
                var Output_30 = n4.App_Djk5Vm5YngbOC2s9n6XvNy.Create(Node_Context: Node_Context_29);
                state_15.__p_Hd8ThlHhF8rQcpGJz4KrpA = Output_30;
                stateOutput_27 = state_15;
                initialOutputs_28 = n6.CollectionExtensions.CreateSpreadOfObjects(n25._Operations_.CreateDefault());
            }

            ;
            var Output_31 = this.__p_SVd8li36XFSM0qEwmwk6Rt;
            if (Update_11)
            {
                Output_31 = this.__p_SVd8li36XFSM0qEwmwk6Rt.Update(Enabled_In: Enabled_9, Lifespan_In: Lifespan_10, Reset_In: On_Data_8, Region_In: customRegion_12);
            }

            var __auto_32 = (n7.ILayer)customRegion_12.OutputValues[0];
            bool Update_33 = true;
            var Output_34 = this.__p_BdoznGN2fNGPoTCPcj7JVu;
            if (Update_33)
            {
                Output_34 = this.__p_BdoznGN2fNGPoTCPcj7JVu.Update(Input_In: __auto_32, Update_Styles_In: On_Data_8, Visibility_In: Visibility_In);
            }

            n4.HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r that_35 = this;
            if (this.__GetContext__().IsImmutable)
                that_35 = Output_6 != this.__p_GaJr0N6vPQmNNWhy2G2vOh || customRegion_12 != this.__customRegion_SVd8li36XFSM0qEwmwk6Rt || Output_31 != this.__p_SVd8li36XFSM0qEwmwk6Rt || Output_34 != this.__p_BdoznGN2fNGPoTCPcj7JVu ? new HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r(this)
                {__p_GaJr0N6vPQmNNWhy2G2vOh = Output_6, __customRegion_SVd8li36XFSM0qEwmwk6Rt = customRegion_12, __p_SVd8li36XFSM0qEwmwk6Rt = Output_31, __p_BdoznGN2fNGPoTCPcj7JVu = Output_34} : that_35;
            else
            {
                this.__p_GaJr0N6vPQmNNWhy2G2vOh = Output_6;
                this.__customRegion_SVd8li36XFSM0qEwmwk6Rt = customRegion_12;
                this.__p_SVd8li36XFSM0qEwmwk6Rt = Output_31;
                this.__p_BdoznGN2fNGPoTCPcj7JVu = Output_34;
            }

            return that_35;
        }

        public n4.HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            bool __pad_HHQktV6nrz4PaK1aGSpZ53_0 = __slot_HHQktV6nrz4PaK1aGSpZ53;
            var Settings_1 = n17.SettingsManager.Settings;
            var Stylesheet_2 = Settings_1.Stylesheet;
            n5.BehaviorSubject<string> __auto_3 = Stylesheet_2;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "FEJXrFqm6JjNC1STepzxPc", 55378U);
            n11._Operations_.Create<bool>(Node_Context: Node_Context_4, Value_In: __pad_HHQktV6nrz4PaK1aGSpZ53_0, Output_Out: out n5.BehaviorSubject<bool> Output_5);
            n5.BehaviorSubject<bool> __auto_6 = Output_5;
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "GaJr0N6vPQmNNWhy2G2vOh", 55335U);
            string Initial_Result_8 = "";
            n20._Operations_.Create_H<string>(Node_Context: Node_Context_7, Initial_Result_In: Initial_Result_8, Output_Out: out n12.HoldLatest<string> Output_9);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "BdoznGN2fNGPoTCPcj7JVu", 55350U);
            var Output_11 = n4.HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t.Create(Node_Context: Node_Context_10, Focused_In: __auto_6);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "SVd8li36XFSM0qEwmwk6Rt", 55415U);
            var Output_13 = n26.ManageProcess_KbnPKKIL8zRNfOzhFqxVxr.Create(Node_Context_In: Node_Context_12);
            n4.HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r that_14 = this;
            this.Stylesheet = Stylesheet_2;
            this.Focused = Output_5;
            this.__p_GaJr0N6vPQmNNWhy2G2vOh = Output_9;
            this.__p_BdoznGN2fNGPoTCPcj7JVu = Output_11;
            this.__p_SVd8li36XFSM0qEwmwk6Rt = Output_13;
            this.__customRegion_SVd8li36XFSM0qEwmwk6Rt = default(n22.CustomRegion);
            return that_14;
        }

        public n4.HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r __CreateDefault__()
        {
            n4.HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r that_0 = this;
            this.Stylesheet = default(n5.BehaviorSubject<string>);
            this.Focused = default(n5.BehaviorSubject<bool>);
            this.__p_GaJr0N6vPQmNNWhy2G2vOh = default(n12.HoldLatest<string>);
            this.__p_SVd8li36XFSM0qEwmwk6Rt = n26.ManageProcess_KbnPKKIL8zRNfOzhFqxVxr.CreateDefault();
            this.__customRegion_SVd8li36XFSM0qEwmwk6Rt = default(n22.CustomRegion);
            this.__p_BdoznGN2fNGPoTCPcj7JVu = n4.HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_GaJr0N6vPQmNNWhy2G2vOh);
            n1.CompilationHelper.SafeDispose(this.__p_SVd8li36XFSM0qEwmwk6Rt);
            n1.CompilationHelper.SafeDispose(this.__customRegion_SVd8li36XFSM0qEwmwk6Rt);
            n1.CompilationHelper.SafeDispose(this.__p_BdoznGN2fNGPoTCPcj7JVu);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 55397U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "HHQktV6nrz4PaK1aGSpZ53", Name = "__slot_HHQktV6nrz4PaK1aGSpZ53")]
        public static bool __slot_HHQktV6nrz4PaK1aGSpZ53 = true;
        [n1.ElementAttribute(TracingId = 55332U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "N8DXV6tMoLKMECBI49kGgx", Name = "Stylesheet")]
        public n5.BehaviorSubject<string> Stylesheet;
        [n1.ElementAttribute(TracingId = 55374U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "ANucVDYRGeXM3qkNq5OPjK", Name = "Focused")]
        public n5.BehaviorSubject<bool> Focused;
        [n1.ElementAttribute(TracingId = 55335U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "GaJr0N6vPQmNNWhy2G2vOh", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n12.HoldLatest<string> __p_GaJr0N6vPQmNNWhy2G2vOh;
        [n1.ElementAttribute(TracingId = 55415U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "SVd8li36XFSM0qEwmwk6Rt", Name = "ManageProcess", IsManaged = true, IsAutoGenerated = true)]
        public n26.ManageProcess_KbnPKKIL8zRNfOzhFqxVxr __p_SVd8li36XFSM0qEwmwk6Rt;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n21.ProcessLifespan __c_NIzLQlFGp8jOYuFGmJRo52 = n1.CompilationHelper.Deserialize<n21.ProcessLifespan>("Long", false, "VFVf8GD51Z9PxcEkRZP1RR", "NIzLQlFGp8jOYuFGmJRo52");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n22.CustomRegion __customRegion_SVd8li36XFSM0qEwmwk6Rt;
        [n1.ElementAttribute(TracingId = 55350U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "BdoznGN2fNGPoTCPcj7JVu", Name = "HelpBrowserWindow", IsManaged = true, IsAutoGenerated = true)]
        public n4.HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t __p_BdoznGN2fNGPoTCPcj7JVu;
        static HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r()
        {
        }

        public HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r(HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r other): base(other)
        {
            this.Stylesheet = other.Stylesheet;
            this.Focused = other.Focused;
            this.__p_GaJr0N6vPQmNNWhy2G2vOh = other.__p_GaJr0N6vPQmNNWhy2G2vOh;
            this.__p_SVd8li36XFSM0qEwmwk6Rt = other.__p_SVd8li36XFSM0qEwmwk6Rt;
            this.__customRegion_SVd8li36XFSM0qEwmwk6Rt = other.__customRegion_SVd8li36XFSM0qEwmwk6Rt;
            this.__p_BdoznGN2fNGPoTCPcj7JVu = other.__p_BdoznGN2fNGPoTCPcj7JVu;
        }

        protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Stylesheet", in Stylesheet), n1.CompilationHelper.GetValueOrExisting(values, "Focused", in Focused), n1.CompilationHelper.GetValueOrExisting(values, "__p_GaJr0N6vPQmNNWhy2G2vOh", in __p_GaJr0N6vPQmNNWhy2G2vOh), n1.CompilationHelper.GetValueOrExisting(values, "__p_SVd8li36XFSM0qEwmwk6Rt", in __p_SVd8li36XFSM0qEwmwk6Rt), n1.CompilationHelper.GetValueOrExisting(values, "__customRegion_SVd8li36XFSM0qEwmwk6Rt", in __customRegion_SVd8li36XFSM0qEwmwk6Rt), n1.CompilationHelper.GetValueOrExisting(values, "__p_BdoznGN2fNGPoTCPcj7JVu", in __p_BdoznGN2fNGPoTCPcj7JVu));
        }

        internal HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r __WITH__(n5.BehaviorSubject<string> Stylesheet, n5.BehaviorSubject<bool> Focused, n12.HoldLatest<string> __p_GaJr0N6vPQmNNWhy2G2vOh, n26.ManageProcess_KbnPKKIL8zRNfOzhFqxVxr __p_SVd8li36XFSM0qEwmwk6Rt, n22.CustomRegion __customRegion_SVd8li36XFSM0qEwmwk6Rt, n4.HelpBrowserWindow_LcBtpLS5UyoODipHZhLL4t __p_BdoznGN2fNGPoTCPcj7JVu)
        {
            n4.HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Stylesheet != this.Stylesheet || Focused != this.Focused || __p_GaJr0N6vPQmNNWhy2G2vOh != this.__p_GaJr0N6vPQmNNWhy2G2vOh || __p_SVd8li36XFSM0qEwmwk6Rt != this.__p_SVd8li36XFSM0qEwmwk6Rt || __customRegion_SVd8li36XFSM0qEwmwk6Rt != this.__customRegion_SVd8li36XFSM0qEwmwk6Rt || __p_BdoznGN2fNGPoTCPcj7JVu != this.__p_BdoznGN2fNGPoTCPcj7JVu ? new HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r(this)
                {Stylesheet = Stylesheet, Focused = Focused, __p_GaJr0N6vPQmNNWhy2G2vOh = __p_GaJr0N6vPQmNNWhy2G2vOh, __p_SVd8li36XFSM0qEwmwk6Rt = __p_SVd8li36XFSM0qEwmwk6Rt, __customRegion_SVd8li36XFSM0qEwmwk6Rt = __customRegion_SVd8li36XFSM0qEwmwk6Rt, __p_BdoznGN2fNGPoTCPcj7JVu = __p_BdoznGN2fNGPoTCPcj7JVu} : that_0;
            else
            {
                this.Stylesheet = Stylesheet;
                this.Focused = Focused;
                this.__p_GaJr0N6vPQmNNWhy2G2vOh = __p_GaJr0N6vPQmNNWhy2G2vOh;
                this.__p_SVd8li36XFSM0qEwmwk6Rt = __p_SVd8li36XFSM0qEwmwk6Rt;
                this.__customRegion_SVd8li36XFSM0qEwmwk6Rt = __customRegion_SVd8li36XFSM0qEwmwk6Rt;
                this.__p_BdoznGN2fNGPoTCPcj7JVu = __p_BdoznGN2fNGPoTCPcj7JVu;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "Q14JjcE0pmNPWr6Q7P78k5", Name = "__Q14JjcE0pmNPWr6Q7P78k5")]
        [n2.SerializableAttribute]
        public class __Q14JjcE0pmNPWr6Q7P78k5 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Hd8ThlHhF8rQcpGJz4KrpA);
                return;
            }

            [n1.ElementAttribute(TracingId = 55429U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "Hd8ThlHhF8rQcpGJz4KrpA", Name = "App", IsManaged = true, IsAutoGenerated = true)]
            public n4.App_Djk5Vm5YngbOC2s9n6XvNy __p_Hd8ThlHhF8rQcpGJz4KrpA;
            public __Q14JjcE0pmNPWr6Q7P78k5(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Q14JjcE0pmNPWr6Q7P78k5(__Q14JjcE0pmNPWr6Q7P78k5 other): base(other)
            {
                this.__p_Hd8ThlHhF8rQcpGJz4KrpA = other.__p_Hd8ThlHhF8rQcpGJz4KrpA;
            }

            protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Hd8ThlHhF8rQcpGJz4KrpA", in __p_Hd8ThlHhF8rQcpGJz4KrpA));
            }

            internal __Q14JjcE0pmNPWr6Q7P78k5 __WITH__(n4.App_Djk5Vm5YngbOC2s9n6XvNy __p_Hd8ThlHhF8rQcpGJz4KrpA)
            {
                __Q14JjcE0pmNPWr6Q7P78k5 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Hd8ThlHhF8rQcpGJz4KrpA != this.__p_Hd8ThlHhF8rQcpGJz4KrpA ? new __Q14JjcE0pmNPWr6Q7P78k5(this)
                    {__p_Hd8ThlHhF8rQcpGJz4KrpA = __p_Hd8ThlHhF8rQcpGJz4KrpA} : that_0;
                else
                {
                    this.__p_Hd8ThlHhF8rQcpGJz4KrpA = __p_Hd8ThlHhF8rQcpGJz4KrpA;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 55529U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "Djk5Vm5YngbOC2s9n6XvNy", Name = "App_Djk5Vm5YngbOC2s9n6XvNy")]
    [n2.SerializableAttribute]
    public class App_Djk5Vm5YngbOC2s9n6XvNy : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.App_Djk5Vm5YngbOC2s9n6XvNy Create(n1.NodeContext Node_Context)
        {
            var instance = new App_Djk5Vm5YngbOC2s9n6XvNy(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.App_Djk5Vm5YngbOC2s9n6XvNy CreateDefault()
        {
            var instance = new App_Djk5Vm5YngbOC2s9n6XvNy(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.App_Djk5Vm5YngbOC2s9n6XvNy Update(n5.BehaviorSubject<bool> Focused_In, n5.BehaviorSubject<n23.ContentData_R> Content_In, out n7.ILayer Output_Out)
        {
            string __pad_EOgUkxLkUW2QG0bRLV8G3L_0 = __slot_EOgUkxLkUW2QG0bRLV8G3L;
            string __pad_R5IGyPzr4YiLxybIQ2j5ks_1 = __slot_R5IGyPzr4YiLxybIQ2j5ks;
            string __pad_CIYFePRbhvRQTkfsERVj5w_2 = __slot_CIYFePRbhvRQTkfsERVj5w;
            float __pad_MwTpk8MgehRPHO9ylyU3r6_3 = __slot_MwTpk8MgehRPHO9ylyU3r6;
            string __pad_I5deuIIEDFeNJGvh52Mx4E_4 = __slot_I5deuIIEDFeNJGvh52Mx4E;
            n11._Operations_.Value<bool>(Input_In: Focused_In, Output_Out: out n5.BehaviorSubject<bool> Output_5, Value_Out: out bool Value_6);
            var Output_8 = this.__p_UWd46gxIX8SNVAoxQf4M14.Update(State_Out: out n26.Reference_C<n23.BrowserState_R> State_7);
            var State_Output_17 = this.__p_T6lIW1f5IIvN0irgo0GT2A.Update(Input_In: State_7, Output_Out: out n26.Reference_C<n23.BrowserState_R> Output_9, Data_Out: out n23.BrowserState_R Data_10, Main_Menu_Out: out string Main_Menu_11, Submenu_Out: out string Submenu_12, Command_Out: out string Command_13, Node_Out: out n27.Node Node_14, Follow_Mode_Out: out bool Follow_Mode_15, On_Data_Out: out bool On_Data_16);
            var Result_18 = Main_Menu_11 == __pad_I5deuIIEDFeNJGvh52Mx4E_4;
            n30._Operations_.Update_H(Input__this__In: this.__p_Jve9ZDIq0MEM1ycnzNba2E, Output__this__Out: out n7.Console Output__this__19, Output_Out: out n7.ILayer Output_20, Mouse_Out: out n28.IMouse Mouse_21, Keyboard_Out: out n28.IKeyboard Keyboard_22, Touch_Device_Out: out n28.ITouchDevice Touch_Device_23, Notifications_Out: out n2.IObservable<n29.INotification> Notifications_24);
            var Output_29 = this.__p_HfDNUqoLcKFMlqu0azGMGy.Update(Viewport_Bounds_In_World_Space_Out: out n9.RectangleF Viewport_Bounds_In_World_Space_25, Viewport_Size_In_World_Space_Out: out n9.Vector2 Viewport_Size_In_World_Space_26, Viewport_Bounds_In_Pixel_Out: out n9.RectangleF Viewport_Bounds_In_Pixel_27, Client_Area_In_Pixel_Out: out n9.Vector2 Client_Area_In_Pixel_28);
            n31.RectangleNodes.Size(input: ref Viewport_Bounds_In_World_Space_25, size: out n9.Vector2 Size_30);
            n32._Operations_.Bounds(Input_In: Size_30, Output_Out: out n9.RectangleF Output_31);
            n7.ILayer __auto_32;
            var state_33 = n1.CompilationHelper.Restore<__K41RIi1TaQNOZKU32TeisO>(this.__if_MBALUeXgYDAQCFndQMp429, __GetContext__());
            if (Result_18)
            {
                if (state_33 == null)
                {
                    state_33 = new __K41RIi1TaQNOZKU32TeisO(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_34 = __GetContext__().CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "OYQT9ielfKrPwzG9u089ZD", 55605U);
                    var Output_35 = n33.Learn_BP6n29WcdMQOSKiVTjLQNg.Create(Node_Context: Node_Context_34);
                    state_33.__p_OYQT9ielfKrPwzG9u089ZD = Output_35;
                }

                var State_Output_37 = state_33.__p_OYQT9ielfKrPwzG9u089ZD.Update(Mouse_Device_In: Mouse_21, State_In: Output_9, Content_In: Content_In, Bounds_In: Output_31, Cursor_Enable_In: Value_6, Output_Out: out n7.ILayer Output_36);
                __auto_32 = Output_36;
                if (state_33.__GetContext__().IsImmutable)
                    state_33 = State_Output_37 != state_33.__p_OYQT9ielfKrPwzG9u089ZD ? new __K41RIi1TaQNOZKU32TeisO(state_33)
                    {__p_OYQT9ielfKrPwzG9u089ZD = State_Output_37} : state_33;
                else
                {
                    state_33.__p_OYQT9ielfKrPwzG9u089ZD = State_Output_37;
                }
            }
            else
            {
                __auto_32 = n25._Operations_.CreateDefault();
            }

            bool Update_38 = true;
            var Output_39 = this.__p_VDjVoeVLsUKOO0wYUEVWyi;
            if (Update_38)
            {
                Output_39 = this.__p_VDjVoeVLsUKOO0wYUEVWyi.Update(State_In: State_7);
            }

            var State_Output_41 = this.__p_P0XvPKcyEMdOI2aGe25a3j.Update(State_In: State_7, Bounds_In: Viewport_Bounds_In_World_Space_25, Mouse_Device_In: Mouse_21, Output_Out: out n7.ILayer Output_40);
            var Result_42 = Main_Menu_11 == __pad_R5IGyPzr4YiLxybIQ2j5ks_1;
            n7.ILayer __auto_43;
            var state_44 = n1.CompilationHelper.Restore<__IZ2XzPOdfOVMjxFL7loscO>(this.__if_KMWF2Jkh6qaPgB3krF28Ez, __GetContext__());
            if (Result_42)
            {
                if (state_44 == null)
                {
                    state_44 = new __IZ2XzPOdfOVMjxFL7loscO(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_45 = __GetContext__().CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "PFw3g1vQJLwLtkXY0Ycd3X", 58393U);
                    var Output_46 = n34.Home_CMjl8L2Y1bpP5QchjX1A5e.Create(Node_Context: Node_Context_45);
                    state_44.__p_PFw3g1vQJLwLtkXY0Ycd3X = Output_46;
                }

                var State_Output_48 = state_44.__p_PFw3g1vQJLwLtkXY0Ycd3X.Update(Mouse_Device_In: Mouse_21, State_In: State_7, Content_In: Content_In, Bounds_In: Output_31, Output_Out: out n7.ILayer Output_47);
                __auto_43 = Output_47;
                if (state_44.__GetContext__().IsImmutable)
                    state_44 = State_Output_48 != state_44.__p_PFw3g1vQJLwLtkXY0Ycd3X ? new __IZ2XzPOdfOVMjxFL7loscO(state_44)
                    {__p_PFw3g1vQJLwLtkXY0Ycd3X = State_Output_48} : state_44;
                else
                {
                    state_44.__p_PFw3g1vQJLwLtkXY0Ycd3X = State_Output_48;
                }
            }
            else
            {
                __auto_43 = n25._Operations_.CreateDefault();
            }

            var Result_49 = Main_Menu_11 == __pad_CIYFePRbhvRQTkfsERVj5w_2;
            n7.ILayer __auto_50;
            var state_51 = n1.CompilationHelper.Restore<__O7K7SxVczAyQDYVFYmjiG6>(this.__if_VA6ZhAIxiMiNQlRMHltRng, __GetContext__());
            if (Result_49)
            {
                if (state_51 == null)
                {
                    state_51 = new __O7K7SxVczAyQDYVFYmjiG6(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_52 = __GetContext__().CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "TOUMPC9uxfmMuxl4RXr5yr", 58504U);
                    var Output_53 = n35.Shortcuts_PdJQpp3CMfdMFi4KOOjDT6.Create(Node_Context: Node_Context_52);
                    state_51.__p_TOUMPC9uxfmMuxl4RXr5yr = Output_53;
                }

                var Output_55 = state_51.__p_TOUMPC9uxfmMuxl4RXr5yr.Update(Content_In: Content_In, Bounds_In: Output_31, Mouse_Device_In: Mouse_21, Cursor_Enable_In: Value_6, Layer_Out: out n7.ILayer Layer_54);
                __auto_50 = Layer_54;
                if (state_51.__GetContext__().IsImmutable)
                    state_51 = Output_55 != state_51.__p_TOUMPC9uxfmMuxl4RXr5yr ? new __O7K7SxVczAyQDYVFYmjiG6(state_51)
                    {__p_TOUMPC9uxfmMuxl4RXr5yr = Output_55} : state_51;
                else
                {
                    state_51.__p_TOUMPC9uxfmMuxl4RXr5yr = Output_55;
                }
            }
            else
            {
                __auto_50 = n25._Operations_.CreateDefault();
            }

            var Result_56 = Main_Menu_11 == __pad_EOgUkxLkUW2QG0bRLV8G3L_0;
            n7.ILayer __auto_57;
            var state_58 = n1.CompilationHelper.Restore<__JSWi3tst2YgNqIBlQJDi1X>(this.__if_DO3fetG507vPb9RmMzmDJF, __GetContext__());
            if (Result_56)
            {
                if (state_58 == null)
                {
                    state_58 = new __JSWi3tst2YgNqIBlQJDi1X(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_59 = __GetContext__().CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "FxePw6CN9iYLgCZMaA2D2i", 55684U);
                    var Output_60 = n36.Connect_CCzlUvi0Uw2M3o19h8sia7.Create(Node_Context: Node_Context_59);
                    state_58.__p_FxePw6CN9iYLgCZMaA2D2i = Output_60;
                }

                var Output_62 = state_58.__p_FxePw6CN9iYLgCZMaA2D2i.Update(Content_In: Content_In, Bounds_In: Output_31, Mouse_Device_In: Mouse_21, Layer_Out: out n7.ILayer Layer_61);
                __auto_57 = Layer_61;
                if (state_58.__GetContext__().IsImmutable)
                    state_58 = Output_62 != state_58.__p_FxePw6CN9iYLgCZMaA2D2i ? new __JSWi3tst2YgNqIBlQJDi1X(state_58)
                    {__p_FxePw6CN9iYLgCZMaA2D2i = Output_62} : state_58;
                else
                {
                    state_58.__p_FxePw6CN9iYLgCZMaA2D2i = Output_62;
                }
            }
            else
            {
                __auto_57 = n25._Operations_.CreateDefault();
            }

            var State_Output_64 = this.__p_Bi0cJX0I6xaQY8wZ08vwc9.Update(Bounds_In: Viewport_Bounds_In_World_Space_25, Content_In: Content_In, Output_Out: out n7.ILayer Output_63);
            bool Simulate_65 = false;
            var State_Output_67 = this.__p_FW9MLufaknmNn3ulbOcMkK.Update(Simulate_In: Simulate_65, Output_Out: out bool Output_66);
            var Output_68 = this.__p_AJV9w4o2qibMIviXirZhdW;
            if (Output_66)
            {
                Output_68 = this.__p_AJV9w4o2qibMIviXirZhdW.Set();
            }

            var X_69 = Size_30.X;
            var Result_70 = X_69 != __pad_MwTpk8MgehRPHO9ylyU3r6_3;
            var Output_71 = Output_68;
            if (Result_70)
            {
                Output_71 = Output_68.Reset();
            }

            var Output_73 = Output_71.GetState(State_Out: out bool State_72);
            var Output_74 = !State_72;
            bool Debug_75 = false;
            var builder_76 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G, 7);
            builder_76.Add(__auto_43);
            builder_76.Add(__auto_32);
            builder_76.Add(Output_40);
            builder_76.Add(__auto_50);
            builder_76.Add(__auto_57);
            builder_76.Add(Output_63);
            builder_76.Add(Output_20);
            var __pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G_77 = builder_76.Commit();
            var State_Output_79 = this.__p_H1QoPzSvUIAMbadopjMa4G.Update(Input_In: __pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G_77, Debug_In: Debug_75, Enabled_In: Output_74, Output_Out: out n7.ILayer Output_78);
            n7.ILayer Input_2_80 = (n7.ILayer)Output_29;
            bool Debug_81 = false;
            bool Enabled_82 = true;
            var builder_83 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4, 2);
            builder_83.Add(Output_78);
            builder_83.Add(Input_2_80);
            var __pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4_84 = builder_83.Commit();
            var State_Output_86 = this.__p_NNtPvxu7gfePXIhp9xlwl4.Update(Input_In: __pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4_84, Debug_In: Debug_81, Enabled_In: Enabled_82, Output_Out: out n7.ILayer Output_85);
            bool Update_87 = true;
            var Output_88 = this.__p_TbiqOAS500IMrb9LxQMkoe;
            if (Update_87)
            {
                Output_88 = this.__p_TbiqOAS500IMrb9LxQMkoe.Update(State_In: State_7);
            }

            Output_Out = Output_85;
            n4.App_Djk5Vm5YngbOC2s9n6XvNy that_89 = this;
            if (this.__GetContext__().IsImmutable)
                that_89 = Output_8 != this.__p_UWd46gxIX8SNVAoxQf4M14 || State_Output_17 != this.__p_T6lIW1f5IIvN0irgo0GT2A || Output__this__19 != this.__p_Jve9ZDIq0MEM1ycnzNba2E || Output_29 != this.__p_HfDNUqoLcKFMlqu0azGMGy || state_33 != this.__if_MBALUeXgYDAQCFndQMp429 || Output_39 != this.__p_VDjVoeVLsUKOO0wYUEVWyi || State_Output_41 != this.__p_P0XvPKcyEMdOI2aGe25a3j || state_44 != this.__if_KMWF2Jkh6qaPgB3krF28Ez || state_51 != this.__if_VA6ZhAIxiMiNQlRMHltRng || state_58 != this.__if_DO3fetG507vPb9RmMzmDJF || State_Output_64 != this.__p_Bi0cJX0I6xaQY8wZ08vwc9 || State_Output_67 != this.__p_FW9MLufaknmNn3ulbOcMkK || Output_73 != this.__p_AJV9w4o2qibMIviXirZhdW || __pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G_77 != this.__pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G || State_Output_79 != this.__p_H1QoPzSvUIAMbadopjMa4G || __pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4_84 != this.__pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4 || State_Output_86 != this.__p_NNtPvxu7gfePXIhp9xlwl4 || Output_88 != this.__p_TbiqOAS500IMrb9LxQMkoe ? new App_Djk5Vm5YngbOC2s9n6XvNy(this)
                {__p_UWd46gxIX8SNVAoxQf4M14 = Output_8, __p_T6lIW1f5IIvN0irgo0GT2A = State_Output_17, __p_Jve9ZDIq0MEM1ycnzNba2E = Output__this__19, __p_HfDNUqoLcKFMlqu0azGMGy = Output_29, __if_MBALUeXgYDAQCFndQMp429 = state_33, __p_VDjVoeVLsUKOO0wYUEVWyi = Output_39, __p_P0XvPKcyEMdOI2aGe25a3j = State_Output_41, __if_KMWF2Jkh6qaPgB3krF28Ez = state_44, __if_VA6ZhAIxiMiNQlRMHltRng = state_51, __if_DO3fetG507vPb9RmMzmDJF = state_58, __p_Bi0cJX0I6xaQY8wZ08vwc9 = State_Output_64, __p_FW9MLufaknmNn3ulbOcMkK = State_Output_67, __p_AJV9w4o2qibMIviXirZhdW = Output_73, __pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G = __pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G_77, __p_H1QoPzSvUIAMbadopjMa4G = State_Output_79, __pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4 = __pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4_84, __p_NNtPvxu7gfePXIhp9xlwl4 = State_Output_86, __p_TbiqOAS500IMrb9LxQMkoe = Output_88} : that_89;
            else
            {
                this.__p_UWd46gxIX8SNVAoxQf4M14 = Output_8;
                this.__p_T6lIW1f5IIvN0irgo0GT2A = State_Output_17;
                this.__p_Jve9ZDIq0MEM1ycnzNba2E = Output__this__19;
                this.__p_HfDNUqoLcKFMlqu0azGMGy = Output_29;
                this.__if_MBALUeXgYDAQCFndQMp429 = state_33;
                this.__p_VDjVoeVLsUKOO0wYUEVWyi = Output_39;
                this.__p_P0XvPKcyEMdOI2aGe25a3j = State_Output_41;
                this.__if_KMWF2Jkh6qaPgB3krF28Ez = state_44;
                this.__if_VA6ZhAIxiMiNQlRMHltRng = state_51;
                this.__if_DO3fetG507vPb9RmMzmDJF = state_58;
                this.__p_Bi0cJX0I6xaQY8wZ08vwc9 = State_Output_64;
                this.__p_FW9MLufaknmNn3ulbOcMkK = State_Output_67;
                this.__p_AJV9w4o2qibMIviXirZhdW = Output_73;
                this.__pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G = __pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G_77;
                this.__p_H1QoPzSvUIAMbadopjMa4G = State_Output_79;
                this.__pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4 = __pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4_84;
                this.__p_NNtPvxu7gfePXIhp9xlwl4 = State_Output_86;
                this.__p_TbiqOAS500IMrb9LxQMkoe = Output_88;
            }

            return that_89;
        }

        public n4.App_Djk5Vm5YngbOC2s9n6XvNy __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "Jve9ZDIq0MEM1ycnzNba2E", 55535U);
            n30._Operations_.Create_H(Node_Context: Node_Context_0, Output_Out: out n7.Console Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "P0XvPKcyEMdOI2aGe25a3j", 55570U);
            var Output_3 = n38.TopNavi_KQfqHNfgszzQZHt7XaXouQ.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "H1QoPzSvUIAMbadopjMa4G", 55736U);
            var Output_5 = n8.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "AJV9w4o2qibMIviXirZhdW", 55793U);
            var Output_7 = n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "FW9MLufaknmNn3ulbOcMkK", 55812U);
            var Output_9 = n39.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "T6lIW1f5IIvN0irgo0GT2A", 58364U);
            var Output_11 = n23.SplitState_TjBPuJDOl6MM4sVYKaWztS.Create(Node_Context: Node_Context_10);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "Bi0cJX0I6xaQY8wZ08vwc9", 58416U);
            var Output_13 = n23.ContentLoading_JRj0Y4nxdL9NOLoOQAk5M1.Create(Node_Context: Node_Context_12);
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "HfDNUqoLcKFMlqu0azGMGy", 58438U);
            var Output_15 = n40.ClientBounds_C.Create(Node_Context: Node_Context_14);
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "NNtPvxu7gfePXIhp9xlwl4", 58448U);
            var Output_17 = n8.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_16);
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "VDjVoeVLsUKOO0wYUEVWyi", 58518U);
            var Output_19 = n23.GetNode_McAkRhLL6L9MR9WmrFb6XP.Create(Node_Context: Node_Context_18);
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "UWd46gxIX8SNVAoxQf4M14", 58520U);
            var Output_21 = n23.State_MldBwMODVI2MlWDGqek44B.Create(Node_Context: Node_Context_20);
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "TbiqOAS500IMrb9LxQMkoe", 58527U);
            var Output_23 = n41.SettingsManager_FGQlj3QjMLfOkbACjm9oGG.Create(Node_Context: Node_Context_22);
            n4.App_Djk5Vm5YngbOC2s9n6XvNy that_24 = this;
            this.__pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G = n37._Operations_.CreateDefault<n7.ILayer>();
            this.__pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4 = n37._Operations_.CreateDefault<n7.ILayer>();
            this.__p_Jve9ZDIq0MEM1ycnzNba2E = Output_1;
            this.__p_P0XvPKcyEMdOI2aGe25a3j = Output_3;
            this.__p_H1QoPzSvUIAMbadopjMa4G = Output_5;
            this.__p_AJV9w4o2qibMIviXirZhdW = Output_7;
            this.__p_FW9MLufaknmNn3ulbOcMkK = Output_9;
            this.__p_T6lIW1f5IIvN0irgo0GT2A = Output_11;
            this.__p_Bi0cJX0I6xaQY8wZ08vwc9 = Output_13;
            this.__p_HfDNUqoLcKFMlqu0azGMGy = Output_15;
            this.__p_NNtPvxu7gfePXIhp9xlwl4 = Output_17;
            this.__p_VDjVoeVLsUKOO0wYUEVWyi = Output_19;
            this.__p_UWd46gxIX8SNVAoxQf4M14 = Output_21;
            this.__p_TbiqOAS500IMrb9LxQMkoe = Output_23;
            this.__if_MBALUeXgYDAQCFndQMp429 = default(n2.Object);
            this.__if_KMWF2Jkh6qaPgB3krF28Ez = default(n2.Object);
            this.__if_VA6ZhAIxiMiNQlRMHltRng = default(n2.Object);
            this.__if_DO3fetG507vPb9RmMzmDJF = default(n2.Object);
            return that_24;
        }

        public n4.App_Djk5Vm5YngbOC2s9n6XvNy __CreateDefault__()
        {
            n4.App_Djk5Vm5YngbOC2s9n6XvNy that_0 = this;
            this.__pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G = n37._Operations_.CreateDefault<n7.ILayer>();
            this.__pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4 = n37._Operations_.CreateDefault<n7.ILayer>();
            this.__p_UWd46gxIX8SNVAoxQf4M14 = n23.State_MldBwMODVI2MlWDGqek44B.CreateDefault();
            this.__p_T6lIW1f5IIvN0irgo0GT2A = n23.SplitState_TjBPuJDOl6MM4sVYKaWztS.CreateDefault();
            this.__p_Jve9ZDIq0MEM1ycnzNba2E = default(n7.Console);
            this.__p_HfDNUqoLcKFMlqu0azGMGy = n40.ClientBounds_C.CreateDefault();
            this.__if_MBALUeXgYDAQCFndQMp429 = default(n2.Object);
            this.__p_VDjVoeVLsUKOO0wYUEVWyi = n23.GetNode_McAkRhLL6L9MR9WmrFb6XP.CreateDefault();
            this.__p_P0XvPKcyEMdOI2aGe25a3j = n38.TopNavi_KQfqHNfgszzQZHt7XaXouQ.CreateDefault();
            this.__if_KMWF2Jkh6qaPgB3krF28Ez = default(n2.Object);
            this.__if_VA6ZhAIxiMiNQlRMHltRng = default(n2.Object);
            this.__if_DO3fetG507vPb9RmMzmDJF = default(n2.Object);
            this.__p_Bi0cJX0I6xaQY8wZ08vwc9 = n23.ContentLoading_JRj0Y4nxdL9NOLoOQAk5M1.CreateDefault();
            this.__p_FW9MLufaknmNn3ulbOcMkK = n39.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__p_AJV9w4o2qibMIviXirZhdW = n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.CreateDefault();
            this.__p_H1QoPzSvUIAMbadopjMa4G = n8.Group_TKtMtIW1WMIOfh4AlYkjTy.CreateDefault();
            this.__p_NNtPvxu7gfePXIhp9xlwl4 = n8.Group_TKtMtIW1WMIOfh4AlYkjTy.CreateDefault();
            this.__p_TbiqOAS500IMrb9LxQMkoe = n41.SettingsManager_FGQlj3QjMLfOkbACjm9oGG.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_UWd46gxIX8SNVAoxQf4M14);
            n1.CompilationHelper.SafeDispose(this.__p_T6lIW1f5IIvN0irgo0GT2A);
            n1.CompilationHelper.SafeDispose(this.__p_Jve9ZDIq0MEM1ycnzNba2E);
            n1.CompilationHelper.SafeDispose(this.__p_HfDNUqoLcKFMlqu0azGMGy);
            n1.CompilationHelper.SafeDispose(this.__if_MBALUeXgYDAQCFndQMp429);
            n1.CompilationHelper.SafeDispose(this.__p_VDjVoeVLsUKOO0wYUEVWyi);
            n1.CompilationHelper.SafeDispose(this.__p_P0XvPKcyEMdOI2aGe25a3j);
            n1.CompilationHelper.SafeDispose(this.__if_KMWF2Jkh6qaPgB3krF28Ez);
            n1.CompilationHelper.SafeDispose(this.__if_VA6ZhAIxiMiNQlRMHltRng);
            n1.CompilationHelper.SafeDispose(this.__if_DO3fetG507vPb9RmMzmDJF);
            n1.CompilationHelper.SafeDispose(this.__p_Bi0cJX0I6xaQY8wZ08vwc9);
            n1.CompilationHelper.SafeDispose(this.__p_FW9MLufaknmNn3ulbOcMkK);
            n1.CompilationHelper.SafeDispose(this.__p_AJV9w4o2qibMIviXirZhdW);
            n1.CompilationHelper.SafeDispose(this.__p_H1QoPzSvUIAMbadopjMa4G);
            n1.CompilationHelper.SafeDispose(this.__p_NNtPvxu7gfePXIhp9xlwl4);
            n1.CompilationHelper.SafeDispose(this.__p_TbiqOAS500IMrb9LxQMkoe);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 55658U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "I5deuIIEDFeNJGvh52Mx4E", Name = "__slot_I5deuIIEDFeNJGvh52Mx4E")]
        public static string __slot_I5deuIIEDFeNJGvh52Mx4E = "Learn";
        [n1.ElementAttribute(TracingId = 55731U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "EOgUkxLkUW2QG0bRLV8G3L", Name = "__slot_EOgUkxLkUW2QG0bRLV8G3L")]
        public static string __slot_EOgUkxLkUW2QG0bRLV8G3L = "Connect";
        [n1.ElementAttribute(TracingId = 58362U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "MwTpk8MgehRPHO9ylyU3r6", Name = "__slot_MwTpk8MgehRPHO9ylyU3r6")]
        public static float __slot_MwTpk8MgehRPHO9ylyU3r6 = 1F;
        [n1.ElementAttribute(TracingId = 58415U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "R5IGyPzr4YiLxybIQ2j5ks", Name = "__slot_R5IGyPzr4YiLxybIQ2j5ks")]
        public static string __slot_R5IGyPzr4YiLxybIQ2j5ks = "Home";
        [n1.ElementAttribute(TracingId = 58486U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "CIYFePRbhvRQTkfsERVj5w", Name = "__slot_CIYFePRbhvRQTkfsERVj5w")]
        public static string __slot_CIYFePRbhvRQTkfsERVj5w = "Shortcuts";
        [n1.ElementAttribute(TracingId = 58520U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "UWd46gxIX8SNVAoxQf4M14", Name = "State", IsManaged = true, IsAutoGenerated = true)]
        public n23.State_MldBwMODVI2MlWDGqek44B __p_UWd46gxIX8SNVAoxQf4M14;
        [n1.ElementAttribute(TracingId = 58364U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "T6lIW1f5IIvN0irgo0GT2A", Name = "SplitState", IsManaged = true, IsAutoGenerated = true)]
        public n23.SplitState_TjBPuJDOl6MM4sVYKaWztS __p_T6lIW1f5IIvN0irgo0GT2A;
        [n1.ElementAttribute(TracingId = 55535U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "Jve9ZDIq0MEM1ycnzNba2E", Name = "Console", IsManaged = true, IsAutoGenerated = true)]
        public n7.Console __p_Jve9ZDIq0MEM1ycnzNba2E;
        [n1.ElementAttribute(TracingId = 58438U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "HfDNUqoLcKFMlqu0azGMGy", Name = "ClientBounds", IsManaged = true, IsAutoGenerated = true)]
        public n40.ClientBounds_C __p_HfDNUqoLcKFMlqu0azGMGy;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_MBALUeXgYDAQCFndQMp429;
        [n1.ElementAttribute(TracingId = 58518U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "VDjVoeVLsUKOO0wYUEVWyi", Name = "GetNode", IsManaged = true, IsAutoGenerated = true)]
        public n23.GetNode_McAkRhLL6L9MR9WmrFb6XP __p_VDjVoeVLsUKOO0wYUEVWyi;
        [n1.ElementAttribute(TracingId = 55570U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "P0XvPKcyEMdOI2aGe25a3j", Name = "TopNavi", IsManaged = true, IsAutoGenerated = true)]
        public n38.TopNavi_KQfqHNfgszzQZHt7XaXouQ __p_P0XvPKcyEMdOI2aGe25a3j;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_KMWF2Jkh6qaPgB3krF28Ez;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_VA6ZhAIxiMiNQlRMHltRng;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_DO3fetG507vPb9RmMzmDJF;
        [n1.ElementAttribute(TracingId = 58416U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "Bi0cJX0I6xaQY8wZ08vwc9", Name = "ContentLoading", IsManaged = true, IsAutoGenerated = true)]
        public n23.ContentLoading_JRj0Y4nxdL9NOLoOQAk5M1 __p_Bi0cJX0I6xaQY8wZ08vwc9;
        [n1.ElementAttribute(TracingId = 55812U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "FW9MLufaknmNn3ulbOcMkK", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n39.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_FW9MLufaknmNn3ulbOcMkK;
        [n1.ElementAttribute(TracingId = 55793U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "AJV9w4o2qibMIviXirZhdW", Name = "FlipFlop", IsManaged = true, IsAutoGenerated = true)]
        public n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_AJV9w4o2qibMIviXirZhdW;
        [n1.ElementAttribute(TracingId = 55736U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "H1QoPzSvUIAMbadopjMa4G", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n8.Group_TKtMtIW1WMIOfh4AlYkjTy __p_H1QoPzSvUIAMbadopjMa4G;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n24.Spread<n7.ILayer> __pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G = default(n24.Spread<n7.ILayer>);
        [n1.ElementAttribute(TracingId = 58448U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "NNtPvxu7gfePXIhp9xlwl4", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n8.Group_TKtMtIW1WMIOfh4AlYkjTy __p_NNtPvxu7gfePXIhp9xlwl4;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n24.Spread<n7.ILayer> __pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4 = default(n24.Spread<n7.ILayer>);
        [n1.ElementAttribute(TracingId = 58527U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "TbiqOAS500IMrb9LxQMkoe", Name = "SettingsManager", IsManaged = true, IsAutoGenerated = true)]
        public n41.SettingsManager_FGQlj3QjMLfOkbACjm9oGG __p_TbiqOAS500IMrb9LxQMkoe;
        static App_Djk5Vm5YngbOC2s9n6XvNy()
        {
        }

        public App_Djk5Vm5YngbOC2s9n6XvNy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal App_Djk5Vm5YngbOC2s9n6XvNy(App_Djk5Vm5YngbOC2s9n6XvNy other): base(other)
        {
            this.__p_UWd46gxIX8SNVAoxQf4M14 = other.__p_UWd46gxIX8SNVAoxQf4M14;
            this.__p_T6lIW1f5IIvN0irgo0GT2A = other.__p_T6lIW1f5IIvN0irgo0GT2A;
            this.__p_Jve9ZDIq0MEM1ycnzNba2E = other.__p_Jve9ZDIq0MEM1ycnzNba2E;
            this.__p_HfDNUqoLcKFMlqu0azGMGy = other.__p_HfDNUqoLcKFMlqu0azGMGy;
            this.__if_MBALUeXgYDAQCFndQMp429 = other.__if_MBALUeXgYDAQCFndQMp429;
            this.__p_VDjVoeVLsUKOO0wYUEVWyi = other.__p_VDjVoeVLsUKOO0wYUEVWyi;
            this.__p_P0XvPKcyEMdOI2aGe25a3j = other.__p_P0XvPKcyEMdOI2aGe25a3j;
            this.__if_KMWF2Jkh6qaPgB3krF28Ez = other.__if_KMWF2Jkh6qaPgB3krF28Ez;
            this.__if_VA6ZhAIxiMiNQlRMHltRng = other.__if_VA6ZhAIxiMiNQlRMHltRng;
            this.__if_DO3fetG507vPb9RmMzmDJF = other.__if_DO3fetG507vPb9RmMzmDJF;
            this.__p_Bi0cJX0I6xaQY8wZ08vwc9 = other.__p_Bi0cJX0I6xaQY8wZ08vwc9;
            this.__p_FW9MLufaknmNn3ulbOcMkK = other.__p_FW9MLufaknmNn3ulbOcMkK;
            this.__p_AJV9w4o2qibMIviXirZhdW = other.__p_AJV9w4o2qibMIviXirZhdW;
            this.__p_H1QoPzSvUIAMbadopjMa4G = other.__p_H1QoPzSvUIAMbadopjMa4G;
            this.__pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G = other.__pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G;
            this.__p_NNtPvxu7gfePXIhp9xlwl4 = other.__p_NNtPvxu7gfePXIhp9xlwl4;
            this.__pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4 = other.__pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4;
            this.__p_TbiqOAS500IMrb9LxQMkoe = other.__p_TbiqOAS500IMrb9LxQMkoe;
        }

        protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UWd46gxIX8SNVAoxQf4M14", in __p_UWd46gxIX8SNVAoxQf4M14), n1.CompilationHelper.GetValueOrExisting(values, "__p_T6lIW1f5IIvN0irgo0GT2A", in __p_T6lIW1f5IIvN0irgo0GT2A), n1.CompilationHelper.GetValueOrExisting(values, "__p_Jve9ZDIq0MEM1ycnzNba2E", in __p_Jve9ZDIq0MEM1ycnzNba2E), n1.CompilationHelper.GetValueOrExisting(values, "__p_HfDNUqoLcKFMlqu0azGMGy", in __p_HfDNUqoLcKFMlqu0azGMGy), n1.CompilationHelper.GetValueOrExisting(values, "__if_MBALUeXgYDAQCFndQMp429", in __if_MBALUeXgYDAQCFndQMp429), n1.CompilationHelper.GetValueOrExisting(values, "__p_VDjVoeVLsUKOO0wYUEVWyi", in __p_VDjVoeVLsUKOO0wYUEVWyi), n1.CompilationHelper.GetValueOrExisting(values, "__p_P0XvPKcyEMdOI2aGe25a3j", in __p_P0XvPKcyEMdOI2aGe25a3j), n1.CompilationHelper.GetValueOrExisting(values, "__if_KMWF2Jkh6qaPgB3krF28Ez", in __if_KMWF2Jkh6qaPgB3krF28Ez), n1.CompilationHelper.GetValueOrExisting(values, "__if_VA6ZhAIxiMiNQlRMHltRng", in __if_VA6ZhAIxiMiNQlRMHltRng), n1.CompilationHelper.GetValueOrExisting(values, "__if_DO3fetG507vPb9RmMzmDJF", in __if_DO3fetG507vPb9RmMzmDJF), n1.CompilationHelper.GetValueOrExisting(values, "__p_Bi0cJX0I6xaQY8wZ08vwc9", in __p_Bi0cJX0I6xaQY8wZ08vwc9), n1.CompilationHelper.GetValueOrExisting(values, "__p_FW9MLufaknmNn3ulbOcMkK", in __p_FW9MLufaknmNn3ulbOcMkK), n1.CompilationHelper.GetValueOrExisting(values, "__p_AJV9w4o2qibMIviXirZhdW", in __p_AJV9w4o2qibMIviXirZhdW), n1.CompilationHelper.GetValueOrExisting(values, "__p_H1QoPzSvUIAMbadopjMa4G", in __p_H1QoPzSvUIAMbadopjMa4G), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G", in __pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G), n1.CompilationHelper.GetValueOrExisting(values, "__p_NNtPvxu7gfePXIhp9xlwl4", in __p_NNtPvxu7gfePXIhp9xlwl4), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4", in __pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4), n1.CompilationHelper.GetValueOrExisting(values, "__p_TbiqOAS500IMrb9LxQMkoe", in __p_TbiqOAS500IMrb9LxQMkoe));
        }

        internal App_Djk5Vm5YngbOC2s9n6XvNy __WITH__(n23.State_MldBwMODVI2MlWDGqek44B __p_UWd46gxIX8SNVAoxQf4M14, n23.SplitState_TjBPuJDOl6MM4sVYKaWztS __p_T6lIW1f5IIvN0irgo0GT2A, n7.Console __p_Jve9ZDIq0MEM1ycnzNba2E, n40.ClientBounds_C __p_HfDNUqoLcKFMlqu0azGMGy, n2.Object __if_MBALUeXgYDAQCFndQMp429, n23.GetNode_McAkRhLL6L9MR9WmrFb6XP __p_VDjVoeVLsUKOO0wYUEVWyi, n38.TopNavi_KQfqHNfgszzQZHt7XaXouQ __p_P0XvPKcyEMdOI2aGe25a3j, n2.Object __if_KMWF2Jkh6qaPgB3krF28Ez, n2.Object __if_VA6ZhAIxiMiNQlRMHltRng, n2.Object __if_DO3fetG507vPb9RmMzmDJF, n23.ContentLoading_JRj0Y4nxdL9NOLoOQAk5M1 __p_Bi0cJX0I6xaQY8wZ08vwc9, n39.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_FW9MLufaknmNn3ulbOcMkK, n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_AJV9w4o2qibMIviXirZhdW, n8.Group_TKtMtIW1WMIOfh4AlYkjTy __p_H1QoPzSvUIAMbadopjMa4G, n24.Spread<n7.ILayer> __pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G, n8.Group_TKtMtIW1WMIOfh4AlYkjTy __p_NNtPvxu7gfePXIhp9xlwl4, n24.Spread<n7.ILayer> __pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4, n41.SettingsManager_FGQlj3QjMLfOkbACjm9oGG __p_TbiqOAS500IMrb9LxQMkoe)
        {
            n4.App_Djk5Vm5YngbOC2s9n6XvNy that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_UWd46gxIX8SNVAoxQf4M14 != this.__p_UWd46gxIX8SNVAoxQf4M14 || __p_T6lIW1f5IIvN0irgo0GT2A != this.__p_T6lIW1f5IIvN0irgo0GT2A || __p_Jve9ZDIq0MEM1ycnzNba2E != this.__p_Jve9ZDIq0MEM1ycnzNba2E || __p_HfDNUqoLcKFMlqu0azGMGy != this.__p_HfDNUqoLcKFMlqu0azGMGy || __if_MBALUeXgYDAQCFndQMp429 != this.__if_MBALUeXgYDAQCFndQMp429 || __p_VDjVoeVLsUKOO0wYUEVWyi != this.__p_VDjVoeVLsUKOO0wYUEVWyi || __p_P0XvPKcyEMdOI2aGe25a3j != this.__p_P0XvPKcyEMdOI2aGe25a3j || __if_KMWF2Jkh6qaPgB3krF28Ez != this.__if_KMWF2Jkh6qaPgB3krF28Ez || __if_VA6ZhAIxiMiNQlRMHltRng != this.__if_VA6ZhAIxiMiNQlRMHltRng || __if_DO3fetG507vPb9RmMzmDJF != this.__if_DO3fetG507vPb9RmMzmDJF || __p_Bi0cJX0I6xaQY8wZ08vwc9 != this.__p_Bi0cJX0I6xaQY8wZ08vwc9 || __p_FW9MLufaknmNn3ulbOcMkK != this.__p_FW9MLufaknmNn3ulbOcMkK || __p_AJV9w4o2qibMIviXirZhdW != this.__p_AJV9w4o2qibMIviXirZhdW || __p_H1QoPzSvUIAMbadopjMa4G != this.__p_H1QoPzSvUIAMbadopjMa4G || __pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G != this.__pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G || __p_NNtPvxu7gfePXIhp9xlwl4 != this.__p_NNtPvxu7gfePXIhp9xlwl4 || __pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4 != this.__pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4 || __p_TbiqOAS500IMrb9LxQMkoe != this.__p_TbiqOAS500IMrb9LxQMkoe ? new App_Djk5Vm5YngbOC2s9n6XvNy(this)
                {__p_UWd46gxIX8SNVAoxQf4M14 = __p_UWd46gxIX8SNVAoxQf4M14, __p_T6lIW1f5IIvN0irgo0GT2A = __p_T6lIW1f5IIvN0irgo0GT2A, __p_Jve9ZDIq0MEM1ycnzNba2E = __p_Jve9ZDIq0MEM1ycnzNba2E, __p_HfDNUqoLcKFMlqu0azGMGy = __p_HfDNUqoLcKFMlqu0azGMGy, __if_MBALUeXgYDAQCFndQMp429 = __if_MBALUeXgYDAQCFndQMp429, __p_VDjVoeVLsUKOO0wYUEVWyi = __p_VDjVoeVLsUKOO0wYUEVWyi, __p_P0XvPKcyEMdOI2aGe25a3j = __p_P0XvPKcyEMdOI2aGe25a3j, __if_KMWF2Jkh6qaPgB3krF28Ez = __if_KMWF2Jkh6qaPgB3krF28Ez, __if_VA6ZhAIxiMiNQlRMHltRng = __if_VA6ZhAIxiMiNQlRMHltRng, __if_DO3fetG507vPb9RmMzmDJF = __if_DO3fetG507vPb9RmMzmDJF, __p_Bi0cJX0I6xaQY8wZ08vwc9 = __p_Bi0cJX0I6xaQY8wZ08vwc9, __p_FW9MLufaknmNn3ulbOcMkK = __p_FW9MLufaknmNn3ulbOcMkK, __p_AJV9w4o2qibMIviXirZhdW = __p_AJV9w4o2qibMIviXirZhdW, __p_H1QoPzSvUIAMbadopjMa4G = __p_H1QoPzSvUIAMbadopjMa4G, __pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G = __pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G, __p_NNtPvxu7gfePXIhp9xlwl4 = __p_NNtPvxu7gfePXIhp9xlwl4, __pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4 = __pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4, __p_TbiqOAS500IMrb9LxQMkoe = __p_TbiqOAS500IMrb9LxQMkoe} : that_0;
            else
            {
                this.__p_UWd46gxIX8SNVAoxQf4M14 = __p_UWd46gxIX8SNVAoxQf4M14;
                this.__p_T6lIW1f5IIvN0irgo0GT2A = __p_T6lIW1f5IIvN0irgo0GT2A;
                this.__p_Jve9ZDIq0MEM1ycnzNba2E = __p_Jve9ZDIq0MEM1ycnzNba2E;
                this.__p_HfDNUqoLcKFMlqu0azGMGy = __p_HfDNUqoLcKFMlqu0azGMGy;
                this.__if_MBALUeXgYDAQCFndQMp429 = __if_MBALUeXgYDAQCFndQMp429;
                this.__p_VDjVoeVLsUKOO0wYUEVWyi = __p_VDjVoeVLsUKOO0wYUEVWyi;
                this.__p_P0XvPKcyEMdOI2aGe25a3j = __p_P0XvPKcyEMdOI2aGe25a3j;
                this.__if_KMWF2Jkh6qaPgB3krF28Ez = __if_KMWF2Jkh6qaPgB3krF28Ez;
                this.__if_VA6ZhAIxiMiNQlRMHltRng = __if_VA6ZhAIxiMiNQlRMHltRng;
                this.__if_DO3fetG507vPb9RmMzmDJF = __if_DO3fetG507vPb9RmMzmDJF;
                this.__p_Bi0cJX0I6xaQY8wZ08vwc9 = __p_Bi0cJX0I6xaQY8wZ08vwc9;
                this.__p_FW9MLufaknmNn3ulbOcMkK = __p_FW9MLufaknmNn3ulbOcMkK;
                this.__p_AJV9w4o2qibMIviXirZhdW = __p_AJV9w4o2qibMIviXirZhdW;
                this.__p_H1QoPzSvUIAMbadopjMa4G = __p_H1QoPzSvUIAMbadopjMa4G;
                this.__pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G = __pin_group_Input_In_H1QoPzSvUIAMbadopjMa4G;
                this.__p_NNtPvxu7gfePXIhp9xlwl4 = __p_NNtPvxu7gfePXIhp9xlwl4;
                this.__pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4 = __pin_group_Input_In_NNtPvxu7gfePXIhp9xlwl4;
                this.__p_TbiqOAS500IMrb9LxQMkoe = __p_TbiqOAS500IMrb9LxQMkoe;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "K41RIi1TaQNOZKU32TeisO", Name = "__K41RIi1TaQNOZKU32TeisO")]
        [n2.SerializableAttribute]
        public class __K41RIi1TaQNOZKU32TeisO : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_OYQT9ielfKrPwzG9u089ZD);
                return;
            }

            [n1.ElementAttribute(TracingId = 55605U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "OYQT9ielfKrPwzG9u089ZD", Name = "Learn", IsManaged = true, IsAutoGenerated = true)]
            public n33.Learn_BP6n29WcdMQOSKiVTjLQNg __p_OYQT9ielfKrPwzG9u089ZD;
            public __K41RIi1TaQNOZKU32TeisO(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __K41RIi1TaQNOZKU32TeisO(__K41RIi1TaQNOZKU32TeisO other): base(other)
            {
                this.__p_OYQT9ielfKrPwzG9u089ZD = other.__p_OYQT9ielfKrPwzG9u089ZD;
            }

            protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_OYQT9ielfKrPwzG9u089ZD", in __p_OYQT9ielfKrPwzG9u089ZD));
            }

            internal __K41RIi1TaQNOZKU32TeisO __WITH__(n33.Learn_BP6n29WcdMQOSKiVTjLQNg __p_OYQT9ielfKrPwzG9u089ZD)
            {
                __K41RIi1TaQNOZKU32TeisO that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_OYQT9ielfKrPwzG9u089ZD != this.__p_OYQT9ielfKrPwzG9u089ZD ? new __K41RIi1TaQNOZKU32TeisO(this)
                    {__p_OYQT9ielfKrPwzG9u089ZD = __p_OYQT9ielfKrPwzG9u089ZD} : that_0;
                else
                {
                    this.__p_OYQT9ielfKrPwzG9u089ZD = __p_OYQT9ielfKrPwzG9u089ZD;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "IZ2XzPOdfOVMjxFL7loscO", Name = "__IZ2XzPOdfOVMjxFL7loscO")]
        [n2.SerializableAttribute]
        public class __IZ2XzPOdfOVMjxFL7loscO : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_PFw3g1vQJLwLtkXY0Ycd3X);
                return;
            }

            [n1.ElementAttribute(TracingId = 58393U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "PFw3g1vQJLwLtkXY0Ycd3X", Name = "Home", IsManaged = true, IsAutoGenerated = true)]
            public n34.Home_CMjl8L2Y1bpP5QchjX1A5e __p_PFw3g1vQJLwLtkXY0Ycd3X;
            public __IZ2XzPOdfOVMjxFL7loscO(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __IZ2XzPOdfOVMjxFL7loscO(__IZ2XzPOdfOVMjxFL7loscO other): base(other)
            {
                this.__p_PFw3g1vQJLwLtkXY0Ycd3X = other.__p_PFw3g1vQJLwLtkXY0Ycd3X;
            }

            protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_PFw3g1vQJLwLtkXY0Ycd3X", in __p_PFw3g1vQJLwLtkXY0Ycd3X));
            }

            internal __IZ2XzPOdfOVMjxFL7loscO __WITH__(n34.Home_CMjl8L2Y1bpP5QchjX1A5e __p_PFw3g1vQJLwLtkXY0Ycd3X)
            {
                __IZ2XzPOdfOVMjxFL7loscO that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_PFw3g1vQJLwLtkXY0Ycd3X != this.__p_PFw3g1vQJLwLtkXY0Ycd3X ? new __IZ2XzPOdfOVMjxFL7loscO(this)
                    {__p_PFw3g1vQJLwLtkXY0Ycd3X = __p_PFw3g1vQJLwLtkXY0Ycd3X} : that_0;
                else
                {
                    this.__p_PFw3g1vQJLwLtkXY0Ycd3X = __p_PFw3g1vQJLwLtkXY0Ycd3X;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "O7K7SxVczAyQDYVFYmjiG6", Name = "__O7K7SxVczAyQDYVFYmjiG6")]
        [n2.SerializableAttribute]
        public class __O7K7SxVczAyQDYVFYmjiG6 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_TOUMPC9uxfmMuxl4RXr5yr);
                return;
            }

            [n1.ElementAttribute(TracingId = 58504U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "TOUMPC9uxfmMuxl4RXr5yr", Name = "Shortcuts", IsManaged = true, IsAutoGenerated = true)]
            public n35.Shortcuts_PdJQpp3CMfdMFi4KOOjDT6 __p_TOUMPC9uxfmMuxl4RXr5yr;
            public __O7K7SxVczAyQDYVFYmjiG6(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __O7K7SxVczAyQDYVFYmjiG6(__O7K7SxVczAyQDYVFYmjiG6 other): base(other)
            {
                this.__p_TOUMPC9uxfmMuxl4RXr5yr = other.__p_TOUMPC9uxfmMuxl4RXr5yr;
            }

            protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TOUMPC9uxfmMuxl4RXr5yr", in __p_TOUMPC9uxfmMuxl4RXr5yr));
            }

            internal __O7K7SxVczAyQDYVFYmjiG6 __WITH__(n35.Shortcuts_PdJQpp3CMfdMFi4KOOjDT6 __p_TOUMPC9uxfmMuxl4RXr5yr)
            {
                __O7K7SxVczAyQDYVFYmjiG6 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_TOUMPC9uxfmMuxl4RXr5yr != this.__p_TOUMPC9uxfmMuxl4RXr5yr ? new __O7K7SxVczAyQDYVFYmjiG6(this)
                    {__p_TOUMPC9uxfmMuxl4RXr5yr = __p_TOUMPC9uxfmMuxl4RXr5yr} : that_0;
                else
                {
                    this.__p_TOUMPC9uxfmMuxl4RXr5yr = __p_TOUMPC9uxfmMuxl4RXr5yr;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "JSWi3tst2YgNqIBlQJDi1X", Name = "__JSWi3tst2YgNqIBlQJDi1X")]
        [n2.SerializableAttribute]
        public class __JSWi3tst2YgNqIBlQJDi1X : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_FxePw6CN9iYLgCZMaA2D2i);
                return;
            }

            [n1.ElementAttribute(TracingId = 55684U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "FxePw6CN9iYLgCZMaA2D2i", Name = "Connect", IsManaged = true, IsAutoGenerated = true)]
            public n36.Connect_CCzlUvi0Uw2M3o19h8sia7 __p_FxePw6CN9iYLgCZMaA2D2i;
            public __JSWi3tst2YgNqIBlQJDi1X(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __JSWi3tst2YgNqIBlQJDi1X(__JSWi3tst2YgNqIBlQJDi1X other): base(other)
            {
                this.__p_FxePw6CN9iYLgCZMaA2D2i = other.__p_FxePw6CN9iYLgCZMaA2D2i;
            }

            protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FxePw6CN9iYLgCZMaA2D2i", in __p_FxePw6CN9iYLgCZMaA2D2i));
            }

            internal __JSWi3tst2YgNqIBlQJDi1X __WITH__(n36.Connect_CCzlUvi0Uw2M3o19h8sia7 __p_FxePw6CN9iYLgCZMaA2D2i)
            {
                __JSWi3tst2YgNqIBlQJDi1X that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_FxePw6CN9iYLgCZMaA2D2i != this.__p_FxePw6CN9iYLgCZMaA2D2i ? new __JSWi3tst2YgNqIBlQJDi1X(this)
                    {__p_FxePw6CN9iYLgCZMaA2D2i = __p_FxePw6CN9iYLgCZMaA2D2i} : that_0;
                else
                {
                    this.__p_FxePw6CN9iYLgCZMaA2D2i = __p_FxePw6CN9iYLgCZMaA2D2i;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 58642U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "V6dBJBtUyn9LJqhlKO2CfE", Name = "HelpBrowserCommand_C")]
    [n2.SerializableAttribute]
    public class HelpBrowserCommand_C : n1.VLObject, n42.ICommand, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.HelpBrowserCommand_C Create(n1.NodeContext Node_Context_In)
        {
            Node_Context_In = Node_Context_In.WithIsImmutable(false);
            var instance = new HelpBrowserCommand_C(Node_Context_In, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context_In);
        }

        [n6.CreateDefaultAttribute]
        public static n4.HelpBrowserCommand_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new HelpBrowserCommand_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.HelpBrowserCommand_C Update()
        {
            n5.BehaviorSubject<bool> __auto_0 = this.Visibility;
            n5.BehaviorSubject<n23.ContentData_R> __auto_1 = this.Content;
            n11._Operations_.Value<bool>(Input_In: __auto_0, Output_Out: out n5.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            int Iteration_Count_4 = n2.Convert.ToInt32(Value_3);
            var manager_12 = this.__loop_PHYpYhxKCQ4PTkS3oxqSjz ?? new n43.ImmutableLifetimeManager();
            var iterator_13 = manager_12.GetIterator(__GetContext__());
            try
            {
                for (var i_5 = 0; i_5 < Iteration_Count_4; i_5++)
                {
                    var i_local_6 = i_5;
                    __FwxugYwDsPOPauj8nZBxJM state_7;
                    if (!iterator_13.MoveNext(out state_7))
                    {
                        iterator_13.Add(state_7 = new __FwxugYwDsPOPauj8nZBxJM(__GetContext__(), n1.VLObject.NewIdentity()));
                        n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "J9f4JLwjg1jPS0q0Xqf8wn", 58719U);
                        var Output_9 = n4.HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r.Create(Node_Context: Node_Context_8);
                        state_7.__p_J9f4JLwjg1jPS0q0Xqf8wn = Output_9;
                    }

                    bool Update_10 = true;
                    var Output_11 = state_7.__p_J9f4JLwjg1jPS0q0Xqf8wn;
                    if (Update_10)
                    {
                        Output_11 = state_7.__p_J9f4JLwjg1jPS0q0Xqf8wn.Update(Visibility_In: __auto_0, Content_In: __auto_1);
                    }

                    state_7.__p_J9f4JLwjg1jPS0q0Xqf8wn = Output_11;
                    iterator_13.Update(state_7);
                }
            }
            finally
            {
                manager_12 = iterator_13.Commit();
                this.__loop_PHYpYhxKCQ4PTkS3oxqSjz = manager_12;
            }

            var Output_14 = this.__p_NOPkL0Tn4h2QH7JmVMOf4p;
            if (Value_3)
            {
                Output_14 = this.__p_NOPkL0Tn4h2QH7JmVMOf4p.Set();
            }

            this.__p_NOPkL0Tn4h2QH7JmVMOf4p = Output_14;
            var Output_16 = Output_14.GetState(State_Out: out bool State_15);
            this.__p_NOPkL0Tn4h2QH7JmVMOf4p = Output_16;
            bool Clear_Cache_17 = false;
            var Result_18 = n42.Session.InstalledVLPackages(clearCache: Clear_Cache_17);
            var Output_21 = this.__p_Vp1WH1jutXoM7F83hc8eCB.Update(Value_In: Result_18, Result_Out: out bool Result_19, Unchanged_Out: out bool Unchanged_20);
            this.__p_Vp1WH1jutXoM7F83hc8eCB = Output_21;
            var state_22 = n1.CompilationHelper.Restore<__LkmE70ntieuMuLmlMu8XQa>(this.__if_C6gXldGrAx6Mc4AKHE6vlS, __GetContext__());
            if (Result_19)
            {
                if (state_22 == null)
                {
                    state_22 = new __LkmE70ntieuMuLmlMu8XQa(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "BIJahv1fw0zNeai1hHh7FA", 58821U);
                    var Output_24 = n23.PacksAndIndex_LqOcFYQrK6oO1NCgRNTuFb.Create(Node_Context: Node_Context_23);
                    state_22.__p_BIJahv1fw0zNeai1hHh7FA = Output_24;
                }

                bool Update_25 = true;
                var Output_26 = state_22.__p_BIJahv1fw0zNeai1hHh7FA;
                if (Update_25)
                {
                    Output_26 = state_22.__p_BIJahv1fw0zNeai1hHh7FA.Update(Installed_Packs_In: Result_18, Data_In: __auto_1);
                }

                state_22.__p_BIJahv1fw0zNeai1hHh7FA = Output_26;
                this.__if_C6gXldGrAx6Mc4AKHE6vlS = state_22;
            }

            var Output_29 = this.__p_CRkUqitFR2IMzoaHL3z0RA.Update(Value_In: State_15, Up_Edge_Out: out bool Up_Edge_27, Down_Edge_Out: out bool Down_Edge_28);
            this.__p_CRkUqitFR2IMzoaHL3z0RA = Output_29;
            var state_30 = n1.CompilationHelper.Restore<__SPNzvzOWa5GQQVTzqiVdx6>(this.__if_FGHToJxcdyqMx7YmkbBUPc, __GetContext__());
            if (Up_Edge_27)
            {
                if (state_30 == null)
                {
                    state_30 = new __SPNzvzOWa5GQQVTzqiVdx6(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "TO8PBLotLbZQaTuIHSZH3I", 58906U);
                    var Output_32 = n44.NewsLoader_D3D2ICevWkJPm2gsGCtCB7.Create(Node_Context: Node_Context_31);
                    state_30.__p_TO8PBLotLbZQaTuIHSZH3I = Output_32;
                    n1.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "J6e0bSyygbyO4zLvs7IzAl", 58915U);
                    var Output_34 = n23.ContentLoader_BpdYzj8vr9wOIwldW9veMX.Create(Node_Context: Node_Context_33);
                    state_30.__p_J6e0bSyygbyO4zLvs7IzAl = Output_34;
                }

                bool Update_35 = true;
                var Output_36 = state_30.__p_TO8PBLotLbZQaTuIHSZH3I;
                if (Update_35)
                {
                    Output_36 = state_30.__p_TO8PBLotLbZQaTuIHSZH3I.Update(Data_In: __auto_1);
                }

                bool Update_37 = true;
                var Output_38 = state_30.__p_J6e0bSyygbyO4zLvs7IzAl;
                if (Update_37)
                {
                    Output_38 = state_30.__p_J6e0bSyygbyO4zLvs7IzAl.Update(Data_In: __auto_1);
                }

                state_30.__p_TO8PBLotLbZQaTuIHSZH3I = Output_36;
                state_30.__p_J6e0bSyygbyO4zLvs7IzAl = Output_38;
                this.__if_FGHToJxcdyqMx7YmkbBUPc = state_30;
            }

            return this;
        }

        public n4.HelpBrowserCommand_C Execute_()
        {
            bool __pad_Q4wNSI9XdPgPttTneXGSqd_0 = __slot_Q4wNSI9XdPgPttTneXGSqd;
            n5.BehaviorSubject<bool> __auto_1 = this.Visibility;
            n11._Operations_.OnNext<bool>(Input_In: __auto_1, Value_In: __pad_Q4wNSI9XdPgPttTneXGSqd_0, Output_Out: out n5.BehaviorSubject<bool> Output_2);
            return this;
        }

        public n4.HelpBrowserCommand_C IsVisible_(out bool Is_Visible_Out)
        {
            bool __pad_SlAnLz6JrvENpovXKDbrMX_0 = __slot_SlAnLz6JrvENpovXKDbrMX;
            Is_Visible_Out = __pad_SlAnLz6JrvENpovXKDbrMX_0;
            return this;
        }

        public n4.HelpBrowserCommand_C IsEnabled_(out bool Is_Enabled_Out)
        {
            bool __pad_OeQtES0VA7fO58kXLsWse5_0 = __slot_OeQtES0VA7fO58kXLsWse5;
            Is_Enabled_Out = __pad_OeQtES0VA7fO58kXLsWse5_0;
            return this;
        }

        public n4.HelpBrowserCommand_C Shortcut_(out n10.Keys Shortcut_Out)
        {
            n10.Keys __pad_AeqhWhrYp1CM27gbCQBuVY_0 = __slot_AeqhWhrYp1CM27gbCQBuVY;
            Shortcut_Out = __pad_AeqhWhrYp1CM27gbCQBuVY_0;
            return this;
        }

        public n4.HelpBrowserCommand_C __Create__(n1.NodeContext Node_Context_In)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Command_Subscription = default(n2.IDisposable);
            this.Visibility = default(n5.BehaviorSubject<bool>);
            this.Content = default(n5.BehaviorSubject<n23.ContentData_R>);
            string __pad_GIhfFcjmRf7O0C3ZZOLWmF_0 = __slot_GIhfFcjmRf7O0C3ZZOLWmF;
            var Factory_1 = Node_Context_In.Factory;
            n45._Operations_.GetService<n42.ICommandService>(Input_In: Factory_1, Result_Out: out n42.ICommandService Result_2);
            HelpBrowserCommand_C Instance_3 = this;
            n1.NodeContext Node_Context_4 = Node_Context_In.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "CRkUqitFR2IMzoaHL3z0RA", 58867U);
            var Output_5 = n39.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_4);
            this.__p_CRkUqitFR2IMzoaHL3z0RA = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context_In.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "NOPkL0Tn4h2QH7JmVMOf4p", 58881U);
            var Output_7 = n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.Create(Node_Context: Node_Context_6);
            this.__p_NOPkL0Tn4h2QH7JmVMOf4p = Output_7;
            n1.NodeContext Node_Context_8 = Node_Context_In.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "Vp1WH1jutXoM7F83hc8eCB", 58938U);
            bool Changed_On_Create_9 = true;
            var Output_10 = n39.Changed_A8JGbead2bxNdnPybiEqVS<n24.Spread<n42.PackageDescription>>.Create<n46.__AdaptiveImplementations__VFVf8GD51Z9PxcEkRZP1RR>(Node_Context: Node_Context_8, Changed_On_Create_In: Changed_On_Create_9);
            this.__p_Vp1WH1jutXoM7F83hc8eCB = Output_10;
            n42.ICommand Command_11 = (n42.ICommand)Instance_3;
            var Result_12 = ((n42.ICommandService)Result_2).RegisterCommand(name: __pad_GIhfFcjmRf7O0C3ZZOLWmF_0, command: Command_11);
            this.Command_Subscription = Result_12;
            n2.IDisposable __auto_13 = Result_12;
            var Settings_14 = n17.SettingsManager.Settings;
            var Show_Help_On_Startup_15 = Settings_14.ShowHelpOnStartup;
            n11._Operations_.Value<bool>(Input_In: Show_Help_On_Startup_15, Output_Out: out n5.BehaviorSubject<bool> Output_16, Value_Out: out bool Value_17);
            n1.NodeContext Node_Context_18 = Node_Context_In.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "Sni0FyM0WT3Pc6ohLsM3Js", 58797U);
            n11._Operations_.Create<bool>(Node_Context: Node_Context_18, Value_In: Value_17, Output_Out: out n5.BehaviorSubject<bool> Output_19);
            this.Visibility = Output_19;
            n5.BehaviorSubject<bool> __auto_20 = Output_19;
            n1.NodeContext Node_Context_21 = Node_Context_In.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "NIO6Im4RQPsNZylEOAwEWB", 58857U);
            var Output_22 = n23.ContentData_R.Create(Node_Context: Node_Context_21);
            n1.NodeContext Node_Context_23 = Node_Context_In.CreateSubContext("VFVf8GD51Z9PxcEkRZP1RR", "LmWc4p23xg5NSPXP8XVwBg", 58843U);
            n11._Operations_.Create<n23.ContentData_R>(Node_Context: Node_Context_23, Value_In: Output_22, Output_Out: out n5.BehaviorSubject<n23.ContentData_R> Output_24);
            this.Content = Output_24;
            n5.BehaviorSubject<n23.ContentData_R> __auto_25 = Output_24;
            this.__loop_PHYpYhxKCQ4PTkS3oxqSjz = default(n43.ImmutableLifetimeManager);
            this.__if_C6gXldGrAx6Mc4AKHE6vlS = default(n2.Object);
            this.__if_FGHToJxcdyqMx7YmkbBUPc = default(n2.Object);
            this.__p_PFstUvUNqqCLHGqvpk3WKk = n47._Operations_.CreateDefault();
            return this;
        }

        public n4.HelpBrowserCommand_C Dispose_()
        {
            n2.IDisposable __auto_0 = this.Command_Subscription;
            ((n2.IDisposable)__auto_0).Dispose();
            n1.CompilationHelper.SafeDispose(this.__loop_PHYpYhxKCQ4PTkS3oxqSjz);
            n1.CompilationHelper.SafeDispose(this.__p_NOPkL0Tn4h2QH7JmVMOf4p);
            n1.CompilationHelper.SafeDispose(this.__p_Vp1WH1jutXoM7F83hc8eCB);
            n1.CompilationHelper.SafeDispose(this.__if_C6gXldGrAx6Mc4AKHE6vlS);
            n1.CompilationHelper.SafeDispose(this.__p_CRkUqitFR2IMzoaHL3z0RA);
            n1.CompilationHelper.SafeDispose(this.__if_FGHToJxcdyqMx7YmkbBUPc);
            n1.CompilationHelper.SafeDispose(this.__p_PFstUvUNqqCLHGqvpk3WKk);
            return this;
        }

        public n4.HelpBrowserCommand_C __CreateDefault__()
        {
            this.Command_Subscription = default(n2.IDisposable);
            this.Visibility = default(n5.BehaviorSubject<bool>);
            this.Content = default(n5.BehaviorSubject<n23.ContentData_R>);
            this.__loop_PHYpYhxKCQ4PTkS3oxqSjz = default(n43.ImmutableLifetimeManager);
            this.__p_NOPkL0Tn4h2QH7JmVMOf4p = n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.CreateDefault();
            this.__p_Vp1WH1jutXoM7F83hc8eCB = n39.Changed_A8JGbead2bxNdnPybiEqVS<n24.Spread<n42.PackageDescription>>.CreateDefault<n46.__AdaptiveImplementations__VFVf8GD51Z9PxcEkRZP1RR>();
            this.__if_C6gXldGrAx6Mc4AKHE6vlS = default(n2.Object);
            this.__p_CRkUqitFR2IMzoaHL3z0RA = n39.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__if_FGHToJxcdyqMx7YmkbBUPc = default(n2.Object);
            this.__p_PFstUvUNqqCLHGqvpk3WKk = n47._Operations_.CreateDefault();
            return this;
        }

        void n42.ICommand.Execute()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Execute_();
        }

        n10.Keys n42.ICommand.Shortcut
        {
            get
            {
                using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
                var __returnValue__ = Shortcut_(out n10.Keys out_Shortcut_Out);
                return out_Shortcut_Out;
            }
        }

        bool n42.ICommand.IsVisible
        {
            get
            {
                using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
                var __returnValue__ = IsVisible_(out bool out_Is_Visible_Out);
                return out_Is_Visible_Out;
            }
        }

        bool n42.ICommand.IsEnabled
        {
            get
            {
                using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
                var __returnValue__ = IsEnabled_(out bool out_Is_Enabled_Out);
                return out_Is_Enabled_Out;
            }
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 58694U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "OeQtES0VA7fO58kXLsWse5", Name = "__slot_OeQtES0VA7fO58kXLsWse5")]
        public static bool __slot_OeQtES0VA7fO58kXLsWse5 = true;
        [n1.ElementAttribute(TracingId = 58705U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "SlAnLz6JrvENpovXKDbrMX", Name = "__slot_SlAnLz6JrvENpovXKDbrMX")]
        public static bool __slot_SlAnLz6JrvENpovXKDbrMX = true;
        [n1.ElementAttribute(TracingId = 58708U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "AeqhWhrYp1CM27gbCQBuVY", Name = "__slot_AeqhWhrYp1CM27gbCQBuVY")]
        public static n10.Keys __slot_AeqhWhrYp1CM27gbCQBuVY = n1.CompilationHelper.Deserialize<n10.Keys>("F1", false, "VFVf8GD51Z9PxcEkRZP1RR", "AeqhWhrYp1CM27gbCQBuVY");
        [n1.ElementAttribute(TracingId = 58729U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "GIhfFcjmRf7O0C3ZZOLWmF", Name = "__slot_GIhfFcjmRf7O0C3ZZOLWmF")]
        public static string __slot_GIhfFcjmRf7O0C3ZZOLWmF = "Help Browser";
        [n1.ElementAttribute(TracingId = 58742U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "Q4wNSI9XdPgPttTneXGSqd", Name = "__slot_Q4wNSI9XdPgPttTneXGSqd")]
        public static bool __slot_Q4wNSI9XdPgPttTneXGSqd = true;
        [n1.ElementAttribute(TracingId = 58685U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "TZp6nkwHgkHNfgR3bVRTbz", Name = "Command Subscription")]
        public n2.IDisposable Command_Subscription;
        [n1.ElementAttribute(TracingId = 58731U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "PbJIOehnhuOQHPiWPyhcaQ", Name = "Visibility")]
        public n5.BehaviorSubject<bool> Visibility;
        [n1.ElementAttribute(TracingId = 58841U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "TKRBMoDMYW8PQ8Y1AgwrNH", Name = "Content")]
        public n5.BehaviorSubject<n23.ContentData_R> Content;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n43.ImmutableLifetimeManager __loop_PHYpYhxKCQ4PTkS3oxqSjz;
        [n1.ElementAttribute(TracingId = 58881U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "NOPkL0Tn4h2QH7JmVMOf4p", Name = "FlipFlop", IsManaged = true, IsAutoGenerated = true)]
        public n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_NOPkL0Tn4h2QH7JmVMOf4p;
        [n1.ElementAttribute(TracingId = 58938U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "Vp1WH1jutXoM7F83hc8eCB", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n39.Changed_A8JGbead2bxNdnPybiEqVS<n24.Spread<n42.PackageDescription>> __p_Vp1WH1jutXoM7F83hc8eCB;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_C6gXldGrAx6Mc4AKHE6vlS;
        [n1.ElementAttribute(TracingId = 58867U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "CRkUqitFR2IMzoaHL3z0RA", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n39.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CRkUqitFR2IMzoaHL3z0RA;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_FGHToJxcdyqMx7YmkbBUPc;
        [n1.ElementAttribute(TracingId = 58658U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "PFstUvUNqqCLHGqvpk3WKk", Name = "This", IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __p_PFstUvUNqqCLHGqvpk3WKk;
        static HelpBrowserCommand_C()
        {
        }

        public HelpBrowserCommand_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HelpBrowserCommand_C(HelpBrowserCommand_C other): base(other)
        {
            this.Command_Subscription = other.Command_Subscription;
            this.Visibility = other.Visibility;
            this.Content = other.Content;
            this.__loop_PHYpYhxKCQ4PTkS3oxqSjz = other.__loop_PHYpYhxKCQ4PTkS3oxqSjz;
            this.__p_NOPkL0Tn4h2QH7JmVMOf4p = other.__p_NOPkL0Tn4h2QH7JmVMOf4p;
            this.__p_Vp1WH1jutXoM7F83hc8eCB = other.__p_Vp1WH1jutXoM7F83hc8eCB;
            this.__if_C6gXldGrAx6Mc4AKHE6vlS = other.__if_C6gXldGrAx6Mc4AKHE6vlS;
            this.__p_CRkUqitFR2IMzoaHL3z0RA = other.__p_CRkUqitFR2IMzoaHL3z0RA;
            this.__if_FGHToJxcdyqMx7YmkbBUPc = other.__if_FGHToJxcdyqMx7YmkbBUPc;
            this.__p_PFstUvUNqqCLHGqvpk3WKk = other.__p_PFstUvUNqqCLHGqvpk3WKk;
        }

        protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Command_Subscription", in Command_Subscription), n1.CompilationHelper.GetValueOrExisting(values, "Visibility", in Visibility), n1.CompilationHelper.GetValueOrExisting(values, "Content", in Content), n1.CompilationHelper.GetValueOrExisting(values, "__loop_PHYpYhxKCQ4PTkS3oxqSjz", in __loop_PHYpYhxKCQ4PTkS3oxqSjz), n1.CompilationHelper.GetValueOrExisting(values, "__p_NOPkL0Tn4h2QH7JmVMOf4p", in __p_NOPkL0Tn4h2QH7JmVMOf4p), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vp1WH1jutXoM7F83hc8eCB", in __p_Vp1WH1jutXoM7F83hc8eCB), n1.CompilationHelper.GetValueOrExisting(values, "__if_C6gXldGrAx6Mc4AKHE6vlS", in __if_C6gXldGrAx6Mc4AKHE6vlS), n1.CompilationHelper.GetValueOrExisting(values, "__p_CRkUqitFR2IMzoaHL3z0RA", in __p_CRkUqitFR2IMzoaHL3z0RA), n1.CompilationHelper.GetValueOrExisting(values, "__if_FGHToJxcdyqMx7YmkbBUPc", in __if_FGHToJxcdyqMx7YmkbBUPc), n1.CompilationHelper.GetValueOrExisting(values, "__p_PFstUvUNqqCLHGqvpk3WKk", in __p_PFstUvUNqqCLHGqvpk3WKk));
        }

        internal HelpBrowserCommand_C __WITH__(n2.IDisposable Command_Subscription, n5.BehaviorSubject<bool> Visibility, n5.BehaviorSubject<n23.ContentData_R> Content, n43.ImmutableLifetimeManager __loop_PHYpYhxKCQ4PTkS3oxqSjz, n39.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_NOPkL0Tn4h2QH7JmVMOf4p, n39.Changed_A8JGbead2bxNdnPybiEqVS<n24.Spread<n42.PackageDescription>> __p_Vp1WH1jutXoM7F83hc8eCB, n2.Object __if_C6gXldGrAx6Mc4AKHE6vlS, n39.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CRkUqitFR2IMzoaHL3z0RA, n2.Object __if_FGHToJxcdyqMx7YmkbBUPc, n2.Object __p_PFstUvUNqqCLHGqvpk3WKk)
        {
            n4.HelpBrowserCommand_C that_0 = this;
            this.Command_Subscription = Command_Subscription;
            this.Visibility = Visibility;
            this.Content = Content;
            this.__loop_PHYpYhxKCQ4PTkS3oxqSjz = __loop_PHYpYhxKCQ4PTkS3oxqSjz;
            this.__p_NOPkL0Tn4h2QH7JmVMOf4p = __p_NOPkL0Tn4h2QH7JmVMOf4p;
            this.__p_Vp1WH1jutXoM7F83hc8eCB = __p_Vp1WH1jutXoM7F83hc8eCB;
            this.__if_C6gXldGrAx6Mc4AKHE6vlS = __if_C6gXldGrAx6Mc4AKHE6vlS;
            this.__p_CRkUqitFR2IMzoaHL3z0RA = __p_CRkUqitFR2IMzoaHL3z0RA;
            this.__if_FGHToJxcdyqMx7YmkbBUPc = __if_FGHToJxcdyqMx7YmkbBUPc;
            this.__p_PFstUvUNqqCLHGqvpk3WKk = __p_PFstUvUNqqCLHGqvpk3WKk;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "FwxugYwDsPOPauj8nZBxJM", Name = "__FwxugYwDsPOPauj8nZBxJM")]
        [n2.SerializableAttribute]
        public class __FwxugYwDsPOPauj8nZBxJM : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_J9f4JLwjg1jPS0q0Xqf8wn);
                return;
            }

            [n1.ElementAttribute(TracingId = 58719U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "J9f4JLwjg1jPS0q0Xqf8wn", Name = "HelpBrowser", IsManaged = true, IsAutoGenerated = true)]
            public n4.HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r __p_J9f4JLwjg1jPS0q0Xqf8wn;
            public __FwxugYwDsPOPauj8nZBxJM(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __FwxugYwDsPOPauj8nZBxJM(__FwxugYwDsPOPauj8nZBxJM other): base(other)
            {
                this.__p_J9f4JLwjg1jPS0q0Xqf8wn = other.__p_J9f4JLwjg1jPS0q0Xqf8wn;
            }

            protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_J9f4JLwjg1jPS0q0Xqf8wn", in __p_J9f4JLwjg1jPS0q0Xqf8wn));
            }

            internal __FwxugYwDsPOPauj8nZBxJM __WITH__(n4.HelpBrowser_VDWmDkmaxTYLnP0S8RHP0r __p_J9f4JLwjg1jPS0q0Xqf8wn)
            {
                __FwxugYwDsPOPauj8nZBxJM that_0 = this;
                this.__p_J9f4JLwjg1jPS0q0Xqf8wn = __p_J9f4JLwjg1jPS0q0Xqf8wn;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "LkmE70ntieuMuLmlMu8XQa", Name = "__LkmE70ntieuMuLmlMu8XQa")]
        [n2.SerializableAttribute]
        public class __LkmE70ntieuMuLmlMu8XQa : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_BIJahv1fw0zNeai1hHh7FA);
                return;
            }

            [n1.ElementAttribute(TracingId = 58821U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "BIJahv1fw0zNeai1hHh7FA", Name = "PacksAndIndex", IsManaged = true, IsAutoGenerated = true)]
            public n23.PacksAndIndex_LqOcFYQrK6oO1NCgRNTuFb __p_BIJahv1fw0zNeai1hHh7FA;
            public __LkmE70ntieuMuLmlMu8XQa(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __LkmE70ntieuMuLmlMu8XQa(__LkmE70ntieuMuLmlMu8XQa other): base(other)
            {
                this.__p_BIJahv1fw0zNeai1hHh7FA = other.__p_BIJahv1fw0zNeai1hHh7FA;
            }

            protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BIJahv1fw0zNeai1hHh7FA", in __p_BIJahv1fw0zNeai1hHh7FA));
            }

            internal __LkmE70ntieuMuLmlMu8XQa __WITH__(n23.PacksAndIndex_LqOcFYQrK6oO1NCgRNTuFb __p_BIJahv1fw0zNeai1hHh7FA)
            {
                __LkmE70ntieuMuLmlMu8XQa that_0 = this;
                this.__p_BIJahv1fw0zNeai1hHh7FA = __p_BIJahv1fw0zNeai1hHh7FA;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "SPNzvzOWa5GQQVTzqiVdx6", Name = "__SPNzvzOWa5GQQVTzqiVdx6")]
        [n2.SerializableAttribute]
        public class __SPNzvzOWa5GQQVTzqiVdx6 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_TO8PBLotLbZQaTuIHSZH3I);
                n1.CompilationHelper.SafeDispose(this.__p_J6e0bSyygbyO4zLvs7IzAl);
                return;
            }

            [n1.ElementAttribute(TracingId = 58906U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "TO8PBLotLbZQaTuIHSZH3I", Name = "NewsLoader", IsManaged = true, IsAutoGenerated = true)]
            public n44.NewsLoader_D3D2ICevWkJPm2gsGCtCB7 __p_TO8PBLotLbZQaTuIHSZH3I;
            [n1.ElementAttribute(TracingId = 58915U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "J6e0bSyygbyO4zLvs7IzAl", Name = "ContentLoader", IsManaged = true, IsAutoGenerated = true)]
            public n23.ContentLoader_BpdYzj8vr9wOIwldW9veMX __p_J6e0bSyygbyO4zLvs7IzAl;
            public __SPNzvzOWa5GQQVTzqiVdx6(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SPNzvzOWa5GQQVTzqiVdx6(__SPNzvzOWa5GQQVTzqiVdx6 other): base(other)
            {
                this.__p_TO8PBLotLbZQaTuIHSZH3I = other.__p_TO8PBLotLbZQaTuIHSZH3I;
                this.__p_J6e0bSyygbyO4zLvs7IzAl = other.__p_J6e0bSyygbyO4zLvs7IzAl;
            }

            protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TO8PBLotLbZQaTuIHSZH3I", in __p_TO8PBLotLbZQaTuIHSZH3I), n1.CompilationHelper.GetValueOrExisting(values, "__p_J6e0bSyygbyO4zLvs7IzAl", in __p_J6e0bSyygbyO4zLvs7IzAl));
            }

            internal __SPNzvzOWa5GQQVTzqiVdx6 __WITH__(n44.NewsLoader_D3D2ICevWkJPm2gsGCtCB7 __p_TO8PBLotLbZQaTuIHSZH3I, n23.ContentLoader_BpdYzj8vr9wOIwldW9veMX __p_J6e0bSyygbyO4zLvs7IzAl)
            {
                __SPNzvzOWa5GQQVTzqiVdx6 that_0 = this;
                this.__p_TO8PBLotLbZQaTuIHSZH3I = __p_TO8PBLotLbZQaTuIHSZH3I;
                this.__p_J6e0bSyygbyO4zLvs7IzAl = __p_J6e0bSyygbyO4zLvs7IzAl;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 59131U, DocumentId = "VFVf8GD51Z9PxcEkRZP1RR", PersistentId = "Nzs4kwJMSgTMN2so7yYBg0", Name = "VL_UI_HelpBrowserApplication_Nzs4kwJMSgTMN2so7yYBg0")]
    [n2.SerializableAttribute]
    public class VL_UI_HelpBrowserApplication_Nzs4kwJMSgTMN2so7yYBg0 : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.VL_UI_HelpBrowserApplication_Nzs4kwJMSgTMN2so7yYBg0 Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_UI_HelpBrowserApplication_Nzs4kwJMSgTMN2so7yYBg0(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.VL_UI_HelpBrowserApplication_Nzs4kwJMSgTMN2so7yYBg0 CreateDefault()
        {
            var instance = new VL_UI_HelpBrowserApplication_Nzs4kwJMSgTMN2so7yYBg0(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.VL_UI_HelpBrowserApplication_Nzs4kwJMSgTMN2so7yYBg0 Update()
        {
            return this;
        }

        public n4.VL_UI_HelpBrowserApplication_Nzs4kwJMSgTMN2so7yYBg0 __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n4.VL_UI_HelpBrowserApplication_Nzs4kwJMSgTMN2so7yYBg0 __CreateDefault__()
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

        public VL_UI_HelpBrowserApplication_Nzs4kwJMSgTMN2so7yYBg0(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_UI_HelpBrowserApplication_Nzs4kwJMSgTMN2so7yYBg0(VL_UI_HelpBrowserApplication_Nzs4kwJMSgTMN2so7yYBg0 other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n19.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_UI_HelpBrowserApplication_Nzs4kwJMSgTMN2so7yYBg0 __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_UI_HelpBrowser_
{
    public struct __AdaptiveImplementations__VFVf8GD51Z9PxcEkRZP1RR : n48.IAdaptiveCreateDefault<n2.Object>, n48.IAdaptiveCreateDefault<n23.BrowserState_R>, n48.IAdaptiveCreateDefault<n24.Spread<n42.PackageDescription>>
    {
        public void CreateDefault(out n2.Object Output_Out)
        {
            var Output_0 = n47._Operations_.CreateDefault();
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n23.BrowserState_R Output_Out)
        {
            var Output_0 = n23.BrowserState_R.CreateDefault();
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n24.Spread<n42.PackageDescription> Output_Out)
        {
            var Empty_0 = n37._Operations_.CreateDefault<n42.PackageDescription>();
            Output_Out = Empty_0;
            return;
        }
    }
}