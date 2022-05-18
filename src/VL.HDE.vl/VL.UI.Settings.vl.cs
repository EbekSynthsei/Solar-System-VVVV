extern alias e5;
extern alias e3;
extern alias e2;
extern alias e1;
extern alias e10;
extern alias e4;

using n12 = _VL_Skia_.Graphics.Skia;
using n16 = global::System.Reactive.Subjects;
using n29 = _CoreLibBasics_.Primitive.Object.Advanced;
using n28 = _CoreLibBasics_.Control;
using n9 = _SettingsMPages_.Settings;
using n8 = _VL_UI_Settings_.Settings.SettingsWindow;
using n22 = _VL_UI_Settings_;
using n4 = _VL_UI_Settings_.Settings;
using n14 = e3::VL.Lib.Reactive;
using n17 = _VL_Reactive_.Reactive.Subjects.BehaviorSubject.Advanced;
using n10 = _CoreLibBasics_.Primitive;
using n23 = _VL_Reactive_.Reactive.EventPattern2.Advanced;
using n30 = _HDE_StylesAndSettings_.HDE;
using n24 = global::System.Collections.Generic;
using n34 = _CoreLibBasics_.Math.Adaptive;
using n26 = _VL_Skia_.Graphics.Skia.Layer.Advanced;
using n21 = _VL_Reactive_.Reactive.Observable.Advanced;
using n33 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n31 = e5::VL.UI.Core;
using n32 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n1 = e2::VL.Core;
using n2 = global::System;
using n11 = e4::Stride.Core.Mathematics;
using n27 = _System_Reflection_.System.Reflection.IVLFactory.Experimental;
using n20 = _VL_HDE_.HDE;
using n5 = e2::VL.Core.CompilerServices;
using n3 = global::System.Windows.Forms;
using n18 = _VL_Reactive_.Reactive.ForEach;
using n15 = _VL_Reactive_.Reactive.HoldLatest;
using n19 = global::System.Runtime.CompilerServices;
using n6 = e1::VL.Skia;
using n25 = e10::VL.Lang.PublicAPI;
using n7 = global::System.Drawing;
using n13 = global::System.Reactive;

namespace _VL_UI_Settings_.Settings
{
    [n1.ElementAttribute(TracingId = 225703U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "Uqj2PKmIHzzNX74bighMqp", Name = "SettingsWindow_Uqj2PKmIHzzNX74bighMqp")]
    [n2.SerializableAttribute]
    public class SettingsWindow_Uqj2PKmIHzzNX74bighMqp : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.SettingsWindow_Uqj2PKmIHzzNX74bighMqp Create(n1.NodeContext Node_Context)
        {
            var instance = new SettingsWindow_Uqj2PKmIHzzNX74bighMqp(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.SettingsWindow_Uqj2PKmIHzzNX74bighMqp CreateDefault()
        {
            var instance = new SettingsWindow_Uqj2PKmIHzzNX74bighMqp(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.SettingsWindow_Uqj2PKmIHzzNX74bighMqp Update(n6.ILayer Input_In, n16.BehaviorSubject<bool> IsVisible_In)
        {
            string __pad_Rkyek8HRqRTNkdye2KiOXz_0 = __slot_Rkyek8HRqRTNkdye2KiOXz;
            n6.SkiaRenderer __pad_CrnT1H3wIBfQBD1oHCGVys_1 = this.__slot_CrnT1H3wIBfQBD1oHCGVys;
            n8._Operations_.ComputeStartupBounds(Output_Out: out n7.Rectangle Output_2);
            var Output_5 = this.__p_DxXING5BaYLNIqAOVzu3Af.Update(Value_Out: out n10.Reference_C<n9.StylesCore_R> Value_3, Data_Out: out n9.StylesCore_R Data_4);
            var State_Output_8 = Data_4.Background(Output_Out: out n11.Color4 Output_6, Scroll_Out: out n12.SkiaPaint_R Scroll_7);
            bool Show_Control_Box_9 = false;
            n3.FormBorderStyle Border_Style_10 = __c_LrZ5BvZ89TxLri3GcBOxEa;
            n6.CommonSpace Space_11 = __c_EcugNciaH6UNaXO1BTytmz;
            bool Show_12 = false;
            var Output_14 = this.__p_H8cVzdQvxBhO1aTG8b6uN9.Update(Bounds_In: Output_2, Name_In: __pad_Rkyek8HRqRTNkdye2KiOXz_0, Show_Control_Box_In: Show_Control_Box_9, Border_Style_In: Border_Style_10, Input_In: Input_In, Color_In: Output_6, Space_In: Space_11, Show_In: Show_12, On_Close_Out: out bool On_Close_13);
            n15._Operations_.GetData_H<n13.EventPattern<n2.Object>>(Input_In: this.__p_MCcl8WH1XabMcSar1F7nTa, Output_Out: out n14.HoldLatest<n13.EventPattern<n2.Object>> Output_15, Value_Out: out n13.EventPattern<n2.Object> Value_16, On_Data_Out: out bool On_Data_17);
            if (On_Data_17)
            {
                bool __pad_FHorxqI9cwcNAIjFRGeBuk_19 = __slot_FHorxqI9cwcNAIjFRGeBuk;
                n17._Operations_.OnNext<bool>(Input_In: IsVisible_In, Value_In: __pad_FHorxqI9cwcNAIjFRGeBuk_19, Output_Out: out n16.BehaviorSubject<bool> Output_20);
            }

            n2.IObservable<bool> Messages_21 = (n2.IObservable<bool>)IsVisible_In;
            bool Reset_22 = false;
            var __fallback___23 = n1.ServiceRegistry.Current;
            n18._Operations_.Update_H<n2.Object, bool, bool>(Input_In: this.__p_QuXXZbwWp9zMIgrdYKX38a, Messages_In: Messages_21, Reset_In: Reset_22, Update_In: (n2.Object s_26, bool Input_1_In_27) =>
            {
                using var __current_24 = __fallback___23.MakeCurrentIfNone();
                var state_25 = n1.CompilationHelper.Restore<__Ta22tE592tlMfrPPvplHEd>(s_26, __GetContext__());
                bool __pad_J8faKhGMD5JNHM2bKbdVSO_28 = __slot_J8faKhGMD5JNHM2bKbdVSO;
                bool __pad_EQqPDYUe8gFOqj51MINDkT_29 = __slot_EQqPDYUe8gFOqj51MINDkT;
                var Result_30 = Input_1_In_27 == __pad_J8faKhGMD5JNHM2bKbdVSO_28;
                var Output_31 = !Result_30;
                var Output_32 = __pad_CrnT1H3wIBfQBD1oHCGVys_1;
                if (Output_31)
                {
                    __pad_CrnT1H3wIBfQBD1oHCGVys_1.Hide();
                }

                var Output_33 = __pad_CrnT1H3wIBfQBD1oHCGVys_1;
                if (Result_30)
                {
                    __pad_CrnT1H3wIBfQBD1oHCGVys_1.Show();
                }

                return n2.Tuple.Create<n2.Object, bool>(state_25, __pad_EQqPDYUe8gFOqj51MINDkT_29);
            }

            , Create_In: () =>
            {
                using var __current_34 = __fallback___23.MakeCurrentIfNone();
                var state_25 = new __Ta22tE592tlMfrPPvplHEd(__GetContext__(), n1.VLObject.NewIdentity());
                return state_25;
            }

            , Output_Out: out n14.ForEach<n2.Object, bool, bool> Output_35, Result_Out: out n2.IObservable<bool> Result_36);
            n4.SettingsWindow_Uqj2PKmIHzzNX74bighMqp that_37 = this;
            if (this.__GetContext__().IsImmutable)
                that_37 = Output_5 != this.__p_DxXING5BaYLNIqAOVzu3Af || Output_14 != this.__p_H8cVzdQvxBhO1aTG8b6uN9 || Output_15 != this.__p_MCcl8WH1XabMcSar1F7nTa || Output_35 != this.__p_QuXXZbwWp9zMIgrdYKX38a ? new SettingsWindow_Uqj2PKmIHzzNX74bighMqp(this)
                {__p_DxXING5BaYLNIqAOVzu3Af = Output_5, __p_H8cVzdQvxBhO1aTG8b6uN9 = Output_14, __p_MCcl8WH1XabMcSar1F7nTa = Output_15, __p_QuXXZbwWp9zMIgrdYKX38a = Output_35} : that_37;
            else
            {
                this.__p_DxXING5BaYLNIqAOVzu3Af = Output_5;
                this.__p_H8cVzdQvxBhO1aTG8b6uN9 = Output_14;
                this.__p_MCcl8WH1XabMcSar1F7nTa = Output_15;
                this.__p_QuXXZbwWp9zMIgrdYKX38a = Output_35;
            }

            return that_37;
        }

        public n4.SettingsWindow_Uqj2PKmIHzzNX74bighMqp __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            bool __pad_HiBimane9rvOM32ZYNFc0w_0 = __slot_HiBimane9rvOM32ZYNFc0w;
            int __pad_L7yRLpJv5VcNNebZL8JK1q_1 = __slot_L7yRLpJv5VcNNebZL8JK1q;
            double __pad_G4OKg8zHaWZPY64W8WKxoF_2 = __slot_G4OKg8zHaWZPY64W8WKxoF;
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("Dq1mnwSRcGNMR6cVP3iQ2z", "H8cVzdQvxBhO1aTG8b6uN9", 226099U);
            var Output_4 = n20.SkiaWindow_C.Create(Node_Context: Node_Context_3);
            var Output_6 = Output_4.GetForm(Form_Out: out n6.SkiaRenderer Form_5);
            n6.SkiaRenderer __pad_CrnT1H3wIBfQBD1oHCGVys_7 = Form_5;
            Form_5.ShowInTaskbar = __pad_HiBimane9rvOM32ZYNFc0w_0;
            string Event_Name_8 = "Deactivate";
            var return_9 = n1.EventBridge.FromEventPattern(target: Form_5, eventName: Event_Name_8);
            n21._Operations_.Skip<n13.EventPattern<n2.Object>>(Input_In: return_9, Count_In: __pad_L7yRLpJv5VcNNebZL8JK1q_1, Output_Out: out n2.IObservable<n13.EventPattern<n2.Object>> Output_10);
            var Result_11 = n2.TimeSpan.FromSeconds(value: __pad_G4OKg8zHaWZPY64W8WKxoF_2);
            n21._Operations_.Delay<n13.EventPattern<n2.Object>>(Input_In: Output_10, Due_Time_In: Result_11, Output_Out: out n2.IObservable<n13.EventPattern<n2.Object>> Output_12);
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("Dq1mnwSRcGNMR6cVP3iQ2z", "MCcl8WH1XabMcSar1F7nTa", 226061U);
            n13.EventPattern<n2.Object> Initial_Result_14 = n23._Operations_.CreateDefault<n2.Object, n22.__AdaptiveImplementations__Dq1mnwSRcGNMR6cVP3iQ2z>();
            n15._Operations_.Create_H<n13.EventPattern<n2.Object>>(Node_Context: Node_Context_13, Initial_Result_In: Initial_Result_14, Output_Out: out n14.HoldLatest<n13.EventPattern<n2.Object>> Output_15);
            bool Reset_16 = false;
            bool Update_17 = true;
            var Output_18 = Output_15;
            if (Update_17)
            {
                n15._Operations_.Update_H<n13.EventPattern<n2.Object>>(Input_In: Output_15, Async_Notifications_In: Output_12, Reset_In: Reset_16, Output_Out: out Output_18);
            }

            n1.NodeContext Node_Context_19 = Node_Context.CreateSubContext("Dq1mnwSRcGNMR6cVP3iQ2z", "DxXING5BaYLNIqAOVzu3Af", 225932U);
            var Output_20 = n9.Styles_MwK5vq4wmHBPu78Ian8V5w.Create(Node_Context: Node_Context_19);
            n1.NodeContext Node_Context_21 = Node_Context.CreateSubContext("Dq1mnwSRcGNMR6cVP3iQ2z", "QuXXZbwWp9zMIgrdYKX38a", 225965U);
            n18._Operations_.Create_H<n2.Object, bool, bool>(Node_Context: Node_Context_21, Output_Out: out n14.ForEach<n2.Object, bool, bool> Output_22);
            n4.SettingsWindow_Uqj2PKmIHzzNX74bighMqp that_23 = this;
            this.__slot_CrnT1H3wIBfQBD1oHCGVys = Form_5;
            this.__p_H8cVzdQvxBhO1aTG8b6uN9 = Output_6;
            this.__p_MCcl8WH1XabMcSar1F7nTa = Output_18;
            this.__p_DxXING5BaYLNIqAOVzu3Af = Output_20;
            this.__p_QuXXZbwWp9zMIgrdYKX38a = Output_22;
            return that_23;
        }

        public n4.SettingsWindow_Uqj2PKmIHzzNX74bighMqp __CreateDefault__()
        {
            n4.SettingsWindow_Uqj2PKmIHzzNX74bighMqp that_0 = this;
            this.__slot_CrnT1H3wIBfQBD1oHCGVys = default(n6.SkiaRenderer);
            this.__p_DxXING5BaYLNIqAOVzu3Af = n9.Styles_MwK5vq4wmHBPu78Ian8V5w.CreateDefault();
            this.__p_H8cVzdQvxBhO1aTG8b6uN9 = n20.SkiaWindow_C.CreateDefault();
            this.__p_MCcl8WH1XabMcSar1F7nTa = default(n14.HoldLatest<n13.EventPattern<n2.Object>>);
            this.__p_QuXXZbwWp9zMIgrdYKX38a = default(n14.ForEach<n2.Object, bool, bool>);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DxXING5BaYLNIqAOVzu3Af);
            n1.CompilationHelper.SafeDispose(this.__p_H8cVzdQvxBhO1aTG8b6uN9);
            n1.CompilationHelper.SafeDispose(this.__p_MCcl8WH1XabMcSar1F7nTa);
            n1.CompilationHelper.SafeDispose(this.__p_QuXXZbwWp9zMIgrdYKX38a);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 225948U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "Rkyek8HRqRTNkdye2KiOXz", Name = "__slot_Rkyek8HRqRTNkdye2KiOXz")]
        public static string __slot_Rkyek8HRqRTNkdye2KiOXz = "Settings";
        [n1.ElementAttribute(TracingId = 225956U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "FWiAUZh5TDVNQ4ojGvwiXl", Name = "__slot_FWiAUZh5TDVNQ4ojGvwiXl")]
        public static string __slot_FWiAUZh5TDVNQ4ojGvwiXl = "< deactivating the settings window should hide it\r\n\r\nif we do this immediately, then toggling to show/hide the settings via the button would not work\r\n\r\ntherefore we delay hiding the window on deactivate";
        [n1.ElementAttribute(TracingId = 226051U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "G4OKg8zHaWZPY64W8WKxoF", Name = "__slot_G4OKg8zHaWZPY64W8WKxoF")]
        public static double __slot_G4OKg8zHaWZPY64W8WKxoF = 0.1;
        [n1.ElementAttribute(TracingId = 226096U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "CrnT1H3wIBfQBD1oHCGVys", Name = "__slot_CrnT1H3wIBfQBD1oHCGVys")]
        public n6.SkiaRenderer __slot_CrnT1H3wIBfQBD1oHCGVys;
        [n1.ElementAttribute(TracingId = 226097U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "VdUqKa4XbsmN09QusUE4nN", Name = "__slot_VdUqKa4XbsmN09QusUE4nN")]
        public static n3.FormBorderStyle __slot_VdUqKa4XbsmN09QusUE4nN = n1.CompilationHelper.Deserialize<n3.FormBorderStyle>("None", false, "Dq1mnwSRcGNMR6cVP3iQ2z", "VdUqKa4XbsmN09QusUE4nN");
        [n1.ElementAttribute(TracingId = 226132U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "HiBimane9rvOM32ZYNFc0w", Name = "__slot_HiBimane9rvOM32ZYNFc0w")]
        public static bool __slot_HiBimane9rvOM32ZYNFc0w = false;
        [n1.ElementAttribute(TracingId = 226141U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "L7yRLpJv5VcNNebZL8JK1q", Name = "__slot_L7yRLpJv5VcNNebZL8JK1q")]
        public static int __slot_L7yRLpJv5VcNNebZL8JK1q = 1;
        [n1.ElementAttribute(TracingId = 225932U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "DxXING5BaYLNIqAOVzu3Af", Name = "Styles", IsManaged = true, IsAutoGenerated = true)]
        public n9.Styles_MwK5vq4wmHBPu78Ian8V5w __p_DxXING5BaYLNIqAOVzu3Af;
        [n1.ElementAttribute(TracingId = 226099U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "H8cVzdQvxBhO1aTG8b6uN9", Name = "SkiaWindow", IsManaged = true, IsAutoGenerated = true)]
        public n20.SkiaWindow_C __p_H8cVzdQvxBhO1aTG8b6uN9;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.FormBorderStyle __c_LrZ5BvZ89TxLri3GcBOxEa = n1.CompilationHelper.Deserialize<n3.FormBorderStyle>("None", false, "Dq1mnwSRcGNMR6cVP3iQ2z", "LrZ5BvZ89TxLri3GcBOxEa");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.CommonSpace __c_EcugNciaH6UNaXO1BTytmz = n1.CompilationHelper.Deserialize<n6.CommonSpace>("DIPTopLeft", false, "Dq1mnwSRcGNMR6cVP3iQ2z", "EcugNciaH6UNaXO1BTytmz");
        [n1.ElementAttribute(TracingId = 226061U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "MCcl8WH1XabMcSar1F7nTa", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n14.HoldLatest<n13.EventPattern<n2.Object>> __p_MCcl8WH1XabMcSar1F7nTa;
        [n1.ElementAttribute(TracingId = 226089U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "FHorxqI9cwcNAIjFRGeBuk", Name = "__slot_FHorxqI9cwcNAIjFRGeBuk")]
        public static bool __slot_FHorxqI9cwcNAIjFRGeBuk = false;
        [n1.ElementAttribute(TracingId = 225965U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "QuXXZbwWp9zMIgrdYKX38a", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n14.ForEach<n2.Object, bool, bool> __p_QuXXZbwWp9zMIgrdYKX38a;
        [n1.ElementAttribute(TracingId = 225999U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "J8faKhGMD5JNHM2bKbdVSO", Name = "__slot_J8faKhGMD5JNHM2bKbdVSO")]
        public static bool __slot_J8faKhGMD5JNHM2bKbdVSO = true;
        [n1.ElementAttribute(TracingId = 226003U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "EQqPDYUe8gFOqj51MINDkT", Name = "__slot_EQqPDYUe8gFOqj51MINDkT")]
        public static bool __slot_EQqPDYUe8gFOqj51MINDkT = true;
        static SettingsWindow_Uqj2PKmIHzzNX74bighMqp()
        {
        }

        public SettingsWindow_Uqj2PKmIHzzNX74bighMqp(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SettingsWindow_Uqj2PKmIHzzNX74bighMqp(SettingsWindow_Uqj2PKmIHzzNX74bighMqp other): base(other)
        {
            this.__slot_CrnT1H3wIBfQBD1oHCGVys = other.__slot_CrnT1H3wIBfQBD1oHCGVys;
            this.__p_DxXING5BaYLNIqAOVzu3Af = other.__p_DxXING5BaYLNIqAOVzu3Af;
            this.__p_H8cVzdQvxBhO1aTG8b6uN9 = other.__p_H8cVzdQvxBhO1aTG8b6uN9;
            this.__p_MCcl8WH1XabMcSar1F7nTa = other.__p_MCcl8WH1XabMcSar1F7nTa;
            this.__p_QuXXZbwWp9zMIgrdYKX38a = other.__p_QuXXZbwWp9zMIgrdYKX38a;
        }

        protected override n1.IVLObject __With__(n24.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_CrnT1H3wIBfQBD1oHCGVys", in __slot_CrnT1H3wIBfQBD1oHCGVys), n1.CompilationHelper.GetValueOrExisting(values, "__p_DxXING5BaYLNIqAOVzu3Af", in __p_DxXING5BaYLNIqAOVzu3Af), n1.CompilationHelper.GetValueOrExisting(values, "__p_H8cVzdQvxBhO1aTG8b6uN9", in __p_H8cVzdQvxBhO1aTG8b6uN9), n1.CompilationHelper.GetValueOrExisting(values, "__p_MCcl8WH1XabMcSar1F7nTa", in __p_MCcl8WH1XabMcSar1F7nTa), n1.CompilationHelper.GetValueOrExisting(values, "__p_QuXXZbwWp9zMIgrdYKX38a", in __p_QuXXZbwWp9zMIgrdYKX38a));
        }

        internal SettingsWindow_Uqj2PKmIHzzNX74bighMqp __WITH__(n6.SkiaRenderer __slot_CrnT1H3wIBfQBD1oHCGVys, n9.Styles_MwK5vq4wmHBPu78Ian8V5w __p_DxXING5BaYLNIqAOVzu3Af, n20.SkiaWindow_C __p_H8cVzdQvxBhO1aTG8b6uN9, n14.HoldLatest<n13.EventPattern<n2.Object>> __p_MCcl8WH1XabMcSar1F7nTa, n14.ForEach<n2.Object, bool, bool> __p_QuXXZbwWp9zMIgrdYKX38a)
        {
            n4.SettingsWindow_Uqj2PKmIHzzNX74bighMqp that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_CrnT1H3wIBfQBD1oHCGVys != this.__slot_CrnT1H3wIBfQBD1oHCGVys || __p_DxXING5BaYLNIqAOVzu3Af != this.__p_DxXING5BaYLNIqAOVzu3Af || __p_H8cVzdQvxBhO1aTG8b6uN9 != this.__p_H8cVzdQvxBhO1aTG8b6uN9 || __p_MCcl8WH1XabMcSar1F7nTa != this.__p_MCcl8WH1XabMcSar1F7nTa || __p_QuXXZbwWp9zMIgrdYKX38a != this.__p_QuXXZbwWp9zMIgrdYKX38a ? new SettingsWindow_Uqj2PKmIHzzNX74bighMqp(this)
                {__slot_CrnT1H3wIBfQBD1oHCGVys = __slot_CrnT1H3wIBfQBD1oHCGVys, __p_DxXING5BaYLNIqAOVzu3Af = __p_DxXING5BaYLNIqAOVzu3Af, __p_H8cVzdQvxBhO1aTG8b6uN9 = __p_H8cVzdQvxBhO1aTG8b6uN9, __p_MCcl8WH1XabMcSar1F7nTa = __p_MCcl8WH1XabMcSar1F7nTa, __p_QuXXZbwWp9zMIgrdYKX38a = __p_QuXXZbwWp9zMIgrdYKX38a} : that_0;
            else
            {
                this.__slot_CrnT1H3wIBfQBD1oHCGVys = __slot_CrnT1H3wIBfQBD1oHCGVys;
                this.__p_DxXING5BaYLNIqAOVzu3Af = __p_DxXING5BaYLNIqAOVzu3Af;
                this.__p_H8cVzdQvxBhO1aTG8b6uN9 = __p_H8cVzdQvxBhO1aTG8b6uN9;
                this.__p_MCcl8WH1XabMcSar1F7nTa = __p_MCcl8WH1XabMcSar1F7nTa;
                this.__p_QuXXZbwWp9zMIgrdYKX38a = __p_QuXXZbwWp9zMIgrdYKX38a;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "Ta22tE592tlMfrPPvplHEd", Name = "__Ta22tE592tlMfrPPvplHEd")]
        [n2.SerializableAttribute]
        public class __Ta22tE592tlMfrPPvplHEd : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __Ta22tE592tlMfrPPvplHEd(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Ta22tE592tlMfrPPvplHEd(__Ta22tE592tlMfrPPvplHEd other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n24.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __Ta22tE592tlMfrPPvplHEd __WITH__()
            {
                return this;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 226207U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "RTn5p47tHArPtpx68LsMXw", Name = "Settings_RTn5p47tHArPtpx68LsMXw")]
    [n2.SerializableAttribute]
    public class Settings_RTn5p47tHArPtpx68LsMXw : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Settings_RTn5p47tHArPtpx68LsMXw Create(n1.NodeContext Node_Context)
        {
            var instance = new Settings_RTn5p47tHArPtpx68LsMXw(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Settings_RTn5p47tHArPtpx68LsMXw CreateDefault()
        {
            var instance = new Settings_RTn5p47tHArPtpx68LsMXw(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Settings_RTn5p47tHArPtpx68LsMXw Update(bool Reset_In, out n6.ILayer Output_Out)
        {
            var State_Output_1 = this.__p_AQ8yaKupysFNX3oDLSDrqP.Update(Reset_In: Reset_In, Output_Out: out n6.ILayer Output_0);
            Output_Out = Output_0;
            n4.Settings_RTn5p47tHArPtpx68LsMXw that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = State_Output_1 != this.__p_AQ8yaKupysFNX3oDLSDrqP ? new Settings_RTn5p47tHArPtpx68LsMXw(this)
                {__p_AQ8yaKupysFNX3oDLSDrqP = State_Output_1} : that_2;
            else
            {
                this.__p_AQ8yaKupysFNX3oDLSDrqP = State_Output_1;
            }

            return that_2;
        }

        public n4.Settings_RTn5p47tHArPtpx68LsMXw __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Dq1mnwSRcGNMR6cVP3iQ2z", "AQ8yaKupysFNX3oDLSDrqP", 226212U);
            var Output_1 = n9.App_O4ZbbHI2Hc4M9PhZbvPCj6.Create(Node_Context: Node_Context_0);
            n4.Settings_RTn5p47tHArPtpx68LsMXw that_2 = this;
            this.__p_AQ8yaKupysFNX3oDLSDrqP = Output_1;
            return that_2;
        }

        public n4.Settings_RTn5p47tHArPtpx68LsMXw __CreateDefault__()
        {
            n4.Settings_RTn5p47tHArPtpx68LsMXw that_0 = this;
            this.__p_AQ8yaKupysFNX3oDLSDrqP = n9.App_O4ZbbHI2Hc4M9PhZbvPCj6.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_AQ8yaKupysFNX3oDLSDrqP);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 226212U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "AQ8yaKupysFNX3oDLSDrqP", Name = "App", IsManaged = true, IsAutoGenerated = true)]
        public n9.App_O4ZbbHI2Hc4M9PhZbvPCj6 __p_AQ8yaKupysFNX3oDLSDrqP;
        public Settings_RTn5p47tHArPtpx68LsMXw(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Settings_RTn5p47tHArPtpx68LsMXw(Settings_RTn5p47tHArPtpx68LsMXw other): base(other)
        {
            this.__p_AQ8yaKupysFNX3oDLSDrqP = other.__p_AQ8yaKupysFNX3oDLSDrqP;
        }

        protected override n1.IVLObject __With__(n24.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AQ8yaKupysFNX3oDLSDrqP", in __p_AQ8yaKupysFNX3oDLSDrqP));
        }

        internal Settings_RTn5p47tHArPtpx68LsMXw __WITH__(n9.App_O4ZbbHI2Hc4M9PhZbvPCj6 __p_AQ8yaKupysFNX3oDLSDrqP)
        {
            n4.Settings_RTn5p47tHArPtpx68LsMXw that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_AQ8yaKupysFNX3oDLSDrqP != this.__p_AQ8yaKupysFNX3oDLSDrqP ? new Settings_RTn5p47tHArPtpx68LsMXw(this)
                {__p_AQ8yaKupysFNX3oDLSDrqP = __p_AQ8yaKupysFNX3oDLSDrqP} : that_0;
            else
            {
                this.__p_AQ8yaKupysFNX3oDLSDrqP = __p_AQ8yaKupysFNX3oDLSDrqP;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 226257U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "Rby9DMS98zBMSBRN8dcQPy", Name = "SettingsCommand_C")]
    [n2.SerializableAttribute]
    public class SettingsCommand_C : n1.VLObject, n25.ICommand, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.SettingsCommand_C Create(n1.NodeContext Node_Context_In)
        {
            Node_Context_In = Node_Context_In.WithIsImmutable(false);
            var instance = new SettingsCommand_C(Node_Context_In, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context_In);
        }

        [n5.CreateDefaultAttribute]
        public static n4.SettingsCommand_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new SettingsCommand_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.SettingsCommand_C Update()
        {
            n16.BehaviorSubject<bool> __auto_0 = this.IsVisible;
            bool __auto_1 = this.First_Time;
            n17._Operations_.Value<bool>(Input_In: __auto_0, Output_Out: out n16.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            var Output_6 = this.__p_OmJvupJgLn0P0IanQGzmm8.Update(Value_In: Value_3, Up_Edge_Out: out bool Up_Edge_4, Down_Edge_Out: out bool Down_Edge_5);
            this.__p_OmJvupJgLn0P0IanQGzmm8 = Output_6;
            n6.ILayer __auto_7;
            var state_8 = n1.CompilationHelper.Restore<__LE5BmgtD6XRQFWDZmjAInF>(this.__if_C67FZykKludPo75IE3j6Cy, __GetContext__());
            if (Value_3)
            {
                if (state_8 == null)
                {
                    state_8 = new __LE5BmgtD6XRQFWDZmjAInF(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("Dq1mnwSRcGNMR6cVP3iQ2z", "AHfCok918G3MSrDVpfaXpq", 226384U);
                    var Output_10 = n4.Settings_RTn5p47tHArPtpx68LsMXw.Create(Node_Context: Node_Context_9);
                    state_8.__p_AHfCok918G3MSrDVpfaXpq = Output_10;
                }

                var State_Output_12 = state_8.__p_AHfCok918G3MSrDVpfaXpq.Update(Reset_In: Up_Edge_4, Output_Out: out n6.ILayer Output_11);
                __auto_7 = Output_11;
                state_8.__p_AHfCok918G3MSrDVpfaXpq = State_Output_12;
                this.__if_C67FZykKludPo75IE3j6Cy = state_8;
            }
            else
            {
                __auto_7 = n26._Operations_.CreateDefault();
            }

            var state_13 = n1.CompilationHelper.Restore<__L05u7NlN0OHNMNeYaiZQVm>(this.__if_FWDDKeOoDN9NOuzjXBeWyV, __GetContext__());
            if (__auto_1)
            {
                if (state_13 == null)
                {
                    state_13 = new __L05u7NlN0OHNMNeYaiZQVm(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("Dq1mnwSRcGNMR6cVP3iQ2z", "FXeqJq7OlvSMeAnX4pKcx5", 226413U);
                    var Output_15 = n4.SettingsWindow_Uqj2PKmIHzzNX74bighMqp.Create(Node_Context: Node_Context_14);
                    state_13.__p_FXeqJq7OlvSMeAnX4pKcx5 = Output_15;
                }

                bool Update_16 = true;
                var Output_17 = state_13.__p_FXeqJq7OlvSMeAnX4pKcx5;
                if (Update_16)
                {
                    Output_17 = state_13.__p_FXeqJq7OlvSMeAnX4pKcx5.Update(Input_In: __auto_7, IsVisible_In: __auto_0);
                }

                state_13.__p_FXeqJq7OlvSMeAnX4pKcx5 = Output_17;
                this.__if_FWDDKeOoDN9NOuzjXBeWyV = state_13;
            }

            return this;
        }

        public n4.SettingsCommand_C Execute_()
        {
            n16.BehaviorSubject<bool> __auto_0 = this.IsVisible;
            bool __pad_N3ehyQE6X3kPDkQClmxlqI_1 = __slot_N3ehyQE6X3kPDkQClmxlqI;
            n17._Operations_.Value<bool>(Input_In: __auto_0, Output_Out: out n16.BehaviorSubject<bool> Output_2, Value_Out: out bool Value_3);
            var Output_4 = !Value_3;
            n17._Operations_.OnNext<bool>(Input_In: __auto_0, Value_In: Output_4, Output_Out: out n16.BehaviorSubject<bool> Output_5);
            this.First_Time = __pad_N3ehyQE6X3kPDkQClmxlqI_1;
            bool __auto_6 = __pad_N3ehyQE6X3kPDkQClmxlqI_1;
            return this;
        }

        public n4.SettingsCommand_C IsVisible_(out bool Is_Visible_Out)
        {
            bool __pad_RDOnduS4VCUQXmG1lIRAa0_0 = __slot_RDOnduS4VCUQXmG1lIRAa0;
            Is_Visible_Out = __pad_RDOnduS4VCUQXmG1lIRAa0_0;
            return this;
        }

        public n4.SettingsCommand_C IsEnabled_(out bool Is_Enabled_Out)
        {
            bool __pad_NVtdUuHpvCkN44Bu1UlNzI_0 = __slot_NVtdUuHpvCkN44Bu1UlNzI;
            Is_Enabled_Out = __pad_NVtdUuHpvCkN44Bu1UlNzI_0;
            return this;
        }

        public n4.SettingsCommand_C Shortcut_(out n3.Keys Shortcut_Out)
        {
            Shortcut_Out = default(n3.Keys);
            return this;
        }

        public n4.SettingsCommand_C __Create__(n1.NodeContext Node_Context_In)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Command_Subscription = default(n2.IDisposable);
            this.IsVisible = default(n16.BehaviorSubject<bool>);
            this.First_Time = false;
            string __pad_I6Ucox7i0IAM6TWxSlcSfq_0 = __slot_I6Ucox7i0IAM6TWxSlcSfq;
            bool __pad_Lr3jY3mblrlOtL9RfMAWKh_1 = __slot_Lr3jY3mblrlOtL9RfMAWKh;
            var Factory_2 = Node_Context_In.Factory;
            n27._Operations_.GetService<n25.ICommandService>(Input_In: Factory_2, Result_Out: out n25.ICommandService Result_3);
            SettingsCommand_C Instance_4 = this;
            n1.NodeContext Node_Context_5 = Node_Context_In.CreateSubContext("Dq1mnwSRcGNMR6cVP3iQ2z", "OmJvupJgLn0P0IanQGzmm8", 226351U);
            var Output_6 = n28.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_5);
            this.__p_OmJvupJgLn0P0IanQGzmm8 = Output_6;
            n25.ICommand Command_7 = (n25.ICommand)Instance_4;
            var Result_8 = ((n25.ICommandService)Result_3).RegisterCommand(name: __pad_I6Ucox7i0IAM6TWxSlcSfq_0, command: Command_7);
            this.Command_Subscription = Result_8;
            n2.IDisposable __auto_9 = Result_8;
            n1.NodeContext Node_Context_10 = Node_Context_In.CreateSubContext("Dq1mnwSRcGNMR6cVP3iQ2z", "VKhVQT9L4spPBta9fhlR7C", 226320U);
            n17._Operations_.Create<bool>(Node_Context: Node_Context_10, Value_In: __pad_Lr3jY3mblrlOtL9RfMAWKh_1, Output_Out: out n16.BehaviorSubject<bool> Output_11);
            this.IsVisible = Output_11;
            n16.BehaviorSubject<bool> __auto_12 = Output_11;
            this.__if_C67FZykKludPo75IE3j6Cy = default(n2.Object);
            this.__if_FWDDKeOoDN9NOuzjXBeWyV = default(n2.Object);
            this.__p_GKfNt8mN9VMPx6ptGU6zEk = n29._Operations_.CreateDefault();
            return this;
        }

        public n4.SettingsCommand_C Dispose_()
        {
            n2.IDisposable __auto_0 = this.Command_Subscription;
            ((n2.IDisposable)__auto_0).Dispose();
            n1.CompilationHelper.SafeDispose(this.__p_OmJvupJgLn0P0IanQGzmm8);
            n1.CompilationHelper.SafeDispose(this.__if_C67FZykKludPo75IE3j6Cy);
            n1.CompilationHelper.SafeDispose(this.__if_FWDDKeOoDN9NOuzjXBeWyV);
            n1.CompilationHelper.SafeDispose(this.__p_GKfNt8mN9VMPx6ptGU6zEk);
            return this;
        }

        public n4.SettingsCommand_C __CreateDefault__()
        {
            this.Command_Subscription = default(n2.IDisposable);
            this.IsVisible = default(n16.BehaviorSubject<bool>);
            this.First_Time = false;
            this.__p_OmJvupJgLn0P0IanQGzmm8 = n28.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__if_C67FZykKludPo75IE3j6Cy = default(n2.Object);
            this.__if_FWDDKeOoDN9NOuzjXBeWyV = default(n2.Object);
            this.__p_GKfNt8mN9VMPx6ptGU6zEk = n29._Operations_.CreateDefault();
            return this;
        }

        void n25.ICommand.Execute()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Execute_();
        }

        n3.Keys n25.ICommand.Shortcut
        {
            get
            {
                using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
                var __returnValue__ = Shortcut_(out n3.Keys out_Shortcut_Out);
                return out_Shortcut_Out;
            }
        }

        bool n25.ICommand.IsVisible
        {
            get
            {
                using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
                var __returnValue__ = IsVisible_(out bool out_Is_Visible_Out);
                return out_Is_Visible_Out;
            }
        }

        bool n25.ICommand.IsEnabled
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

        [n1.ElementAttribute(TracingId = 226305U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "NVtdUuHpvCkN44Bu1UlNzI", Name = "__slot_NVtdUuHpvCkN44Bu1UlNzI")]
        public static bool __slot_NVtdUuHpvCkN44Bu1UlNzI = true;
        [n1.ElementAttribute(TracingId = 226309U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "RDOnduS4VCUQXmG1lIRAa0", Name = "__slot_RDOnduS4VCUQXmG1lIRAa0")]
        public static bool __slot_RDOnduS4VCUQXmG1lIRAa0 = false;
        [n1.ElementAttribute(TracingId = 226312U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "I6Ucox7i0IAM6TWxSlcSfq", Name = "__slot_I6Ucox7i0IAM6TWxSlcSfq")]
        public static string __slot_I6Ucox7i0IAM6TWxSlcSfq = "Settings";
        [n1.ElementAttribute(TracingId = 226327U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "Lr3jY3mblrlOtL9RfMAWKh", Name = "__slot_Lr3jY3mblrlOtL9RfMAWKh")]
        public static bool __slot_Lr3jY3mblrlOtL9RfMAWKh = false;
        [n1.ElementAttribute(TracingId = 226405U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "N3ehyQE6X3kPDkQClmxlqI", Name = "__slot_N3ehyQE6X3kPDkQClmxlqI")]
        public static bool __slot_N3ehyQE6X3kPDkQClmxlqI = true;
        [n1.ElementAttribute(TracingId = 226297U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "P58ZBvdx4h8LEURz4CxVZa", Name = "Command Subscription")]
        public n2.IDisposable Command_Subscription;
        [n1.ElementAttribute(TracingId = 226318U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "OVZbbDF1ZzJO5qQftGwrQA", Name = "IsVisible")]
        public n16.BehaviorSubject<bool> IsVisible;
        [n1.ElementAttribute(TracingId = 226402U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "Q0WLWK6y5v2P73ENv3vLnd", Name = "First Time")]
        public bool First_Time;
        [n1.ElementAttribute(TracingId = 226351U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "OmJvupJgLn0P0IanQGzmm8", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n28.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_OmJvupJgLn0P0IanQGzmm8;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_C67FZykKludPo75IE3j6Cy;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_FWDDKeOoDN9NOuzjXBeWyV;
        [n1.ElementAttribute(TracingId = 226272U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "GKfNt8mN9VMPx6ptGU6zEk", Name = "This", IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __p_GKfNt8mN9VMPx6ptGU6zEk;
        static SettingsCommand_C()
        {
        }

        public SettingsCommand_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SettingsCommand_C(SettingsCommand_C other): base(other)
        {
            this.Command_Subscription = other.Command_Subscription;
            this.IsVisible = other.IsVisible;
            this.First_Time = other.First_Time;
            this.__p_OmJvupJgLn0P0IanQGzmm8 = other.__p_OmJvupJgLn0P0IanQGzmm8;
            this.__if_C67FZykKludPo75IE3j6Cy = other.__if_C67FZykKludPo75IE3j6Cy;
            this.__if_FWDDKeOoDN9NOuzjXBeWyV = other.__if_FWDDKeOoDN9NOuzjXBeWyV;
            this.__p_GKfNt8mN9VMPx6ptGU6zEk = other.__p_GKfNt8mN9VMPx6ptGU6zEk;
        }

        protected override n1.IVLObject __With__(n24.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Command_Subscription", in Command_Subscription), n1.CompilationHelper.GetValueOrExisting(values, "IsVisible", in IsVisible), n1.CompilationHelper.GetValueOrExisting(values, "First_Time", in First_Time), n1.CompilationHelper.GetValueOrExisting(values, "__p_OmJvupJgLn0P0IanQGzmm8", in __p_OmJvupJgLn0P0IanQGzmm8), n1.CompilationHelper.GetValueOrExisting(values, "__if_C67FZykKludPo75IE3j6Cy", in __if_C67FZykKludPo75IE3j6Cy), n1.CompilationHelper.GetValueOrExisting(values, "__if_FWDDKeOoDN9NOuzjXBeWyV", in __if_FWDDKeOoDN9NOuzjXBeWyV), n1.CompilationHelper.GetValueOrExisting(values, "__p_GKfNt8mN9VMPx6ptGU6zEk", in __p_GKfNt8mN9VMPx6ptGU6zEk));
        }

        internal SettingsCommand_C __WITH__(n2.IDisposable Command_Subscription, n16.BehaviorSubject<bool> IsVisible, bool First_Time, n28.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_OmJvupJgLn0P0IanQGzmm8, n2.Object __if_C67FZykKludPo75IE3j6Cy, n2.Object __if_FWDDKeOoDN9NOuzjXBeWyV, n2.Object __p_GKfNt8mN9VMPx6ptGU6zEk)
        {
            n4.SettingsCommand_C that_0 = this;
            this.Command_Subscription = Command_Subscription;
            this.IsVisible = IsVisible;
            this.First_Time = First_Time;
            this.__p_OmJvupJgLn0P0IanQGzmm8 = __p_OmJvupJgLn0P0IanQGzmm8;
            this.__if_C67FZykKludPo75IE3j6Cy = __if_C67FZykKludPo75IE3j6Cy;
            this.__if_FWDDKeOoDN9NOuzjXBeWyV = __if_FWDDKeOoDN9NOuzjXBeWyV;
            this.__p_GKfNt8mN9VMPx6ptGU6zEk = __p_GKfNt8mN9VMPx6ptGU6zEk;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "LE5BmgtD6XRQFWDZmjAInF", Name = "__LE5BmgtD6XRQFWDZmjAInF")]
        [n2.SerializableAttribute]
        public class __LE5BmgtD6XRQFWDZmjAInF : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_AHfCok918G3MSrDVpfaXpq);
                return;
            }

            [n1.ElementAttribute(TracingId = 226384U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "AHfCok918G3MSrDVpfaXpq", Name = "Settings", IsManaged = true, IsAutoGenerated = true)]
            public n4.Settings_RTn5p47tHArPtpx68LsMXw __p_AHfCok918G3MSrDVpfaXpq;
            public __LE5BmgtD6XRQFWDZmjAInF(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __LE5BmgtD6XRQFWDZmjAInF(__LE5BmgtD6XRQFWDZmjAInF other): base(other)
            {
                this.__p_AHfCok918G3MSrDVpfaXpq = other.__p_AHfCok918G3MSrDVpfaXpq;
            }

            protected override n1.IVLObject __With__(n24.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AHfCok918G3MSrDVpfaXpq", in __p_AHfCok918G3MSrDVpfaXpq));
            }

            internal __LE5BmgtD6XRQFWDZmjAInF __WITH__(n4.Settings_RTn5p47tHArPtpx68LsMXw __p_AHfCok918G3MSrDVpfaXpq)
            {
                __LE5BmgtD6XRQFWDZmjAInF that_0 = this;
                this.__p_AHfCok918G3MSrDVpfaXpq = __p_AHfCok918G3MSrDVpfaXpq;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "L05u7NlN0OHNMNeYaiZQVm", Name = "__L05u7NlN0OHNMNeYaiZQVm")]
        [n2.SerializableAttribute]
        public class __L05u7NlN0OHNMNeYaiZQVm : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_FXeqJq7OlvSMeAnX4pKcx5);
                return;
            }

            [n1.ElementAttribute(TracingId = 226413U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "FXeqJq7OlvSMeAnX4pKcx5", Name = "SettingsWindow", IsManaged = true, IsAutoGenerated = true)]
            public n4.SettingsWindow_Uqj2PKmIHzzNX74bighMqp __p_FXeqJq7OlvSMeAnX4pKcx5;
            public __L05u7NlN0OHNMNeYaiZQVm(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __L05u7NlN0OHNMNeYaiZQVm(__L05u7NlN0OHNMNeYaiZQVm other): base(other)
            {
                this.__p_FXeqJq7OlvSMeAnX4pKcx5 = other.__p_FXeqJq7OlvSMeAnX4pKcx5;
            }

            protected override n1.IVLObject __With__(n24.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FXeqJq7OlvSMeAnX4pKcx5", in __p_FXeqJq7OlvSMeAnX4pKcx5));
            }

            internal __L05u7NlN0OHNMNeYaiZQVm __WITH__(n4.SettingsWindow_Uqj2PKmIHzzNX74bighMqp __p_FXeqJq7OlvSMeAnX4pKcx5)
            {
                __L05u7NlN0OHNMNeYaiZQVm that_0 = this;
                this.__p_FXeqJq7OlvSMeAnX4pKcx5 = __p_FXeqJq7OlvSMeAnX4pKcx5;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 226508U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "AzaEBudqk4hM6i3bwuE7Xy", Name = "VL_UI_SettingsApplication_AzaEBudqk4hM6i3bwuE7Xy")]
    [n2.SerializableAttribute]
    public class VL_UI_SettingsApplication_AzaEBudqk4hM6i3bwuE7Xy : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.VL_UI_SettingsApplication_AzaEBudqk4hM6i3bwuE7Xy Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_UI_SettingsApplication_AzaEBudqk4hM6i3bwuE7Xy(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.VL_UI_SettingsApplication_AzaEBudqk4hM6i3bwuE7Xy CreateDefault()
        {
            var instance = new VL_UI_SettingsApplication_AzaEBudqk4hM6i3bwuE7Xy(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.VL_UI_SettingsApplication_AzaEBudqk4hM6i3bwuE7Xy Update()
        {
            return this;
        }

        public n4.VL_UI_SettingsApplication_AzaEBudqk4hM6i3bwuE7Xy __Create__(n1.NodeContext Node_Context)
        {
            n19.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n4.VL_UI_SettingsApplication_AzaEBudqk4hM6i3bwuE7Xy __CreateDefault__()
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

        public VL_UI_SettingsApplication_AzaEBudqk4hM6i3bwuE7Xy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_UI_SettingsApplication_AzaEBudqk4hM6i3bwuE7Xy(VL_UI_SettingsApplication_AzaEBudqk4hM6i3bwuE7Xy other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n24.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_UI_SettingsApplication_AzaEBudqk4hM6i3bwuE7Xy __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_UI_Settings_.Settings.SettingsWindow
{
    [n1.ElementAttribute(TracingId = 225695U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ComputeStartupBounds(out n7.Rectangle Output_Out)
        {
            int __pad_TLKUysmCVG0QJ6PNpMPQlh_0 = __slot_TLKUysmCVG0QJ6PNpMPQlh;
            int __pad_J3r9AcyIUU8NZdJukGQcwi_1 = __slot_J3r9AcyIUU8NZdJukGQcwi;
            int __pad_BuEy8J2z3HYLGYYcay6dvu_2 = __slot_BuEy8J2z3HYLGYYcay6dvu;
            int __pad_VijzR59e6w6NNDSVIskwLx_3 = __slot_VijzR59e6w6NNDSVIskwLx;
            int __pad_BgbYv6qmAJrNC8124oBP1m_4 = __slot_BgbYv6qmAJrNC8124oBP1m;
            n30._Operations_.GetMainWindowBoundsInPixel(Result_Out: out n7.Rectangle Result_5);
            var Output_6 = n31.DIPHelpers.DIP(pixel: Result_5);
            var Right_7 = Output_6.Right;
            var Top_8 = Output_6.Top;
            var Output_9 = Right_7 - __pad_TLKUysmCVG0QJ6PNpMPQlh_0;
            var Output_10 = Output_9 - __pad_J3r9AcyIUU8NZdJukGQcwi_1;
            Output_6.X = Output_10;
            var Output_11 = Top_8 + __pad_BuEy8J2z3HYLGYYcay6dvu_2;
            Output_6.Y = Output_11;
            var Height_12 = Output_6.Height;
            var Virtual_Screen_13 = n3.SystemInformation.VirtualScreen;
            var Height_14 = Virtual_Screen_13.Height;
            var Output_15 = n31.DIPHelpers.DIP(pixel: Height_14);
            n32._Operations_.Clamp<int, n22.__AdaptiveImplementations__Dq1mnwSRcGNMR6cVP3iQ2z>(Input_In: Height_12, Minimum_In: __pad_VijzR59e6w6NNDSVIskwLx_3, Maximum_In: Output_15, Output_Out: out int Output_16);
            var Output_17 = Output_16 - __pad_BgbYv6qmAJrNC8124oBP1m_4;
            Output_6.Height = Output_17;
            Output_6.Width = __pad_TLKUysmCVG0QJ6PNpMPQlh_0;
            Output_Out = Output_6;
            return;
        }

        [n1.ElementAttribute(TracingId = 225792U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "TLKUysmCVG0QJ6PNpMPQlh", Name = "__slot_TLKUysmCVG0QJ6PNpMPQlh")]
        public static int __slot_TLKUysmCVG0QJ6PNpMPQlh = 350;
        [n1.ElementAttribute(TracingId = 225849U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "J3r9AcyIUU8NZdJukGQcwi", Name = "__slot_J3r9AcyIUU8NZdJukGQcwi")]
        public static int __slot_J3r9AcyIUU8NZdJukGQcwi = 15;
        [n1.ElementAttribute(TracingId = 225830U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "BuEy8J2z3HYLGYYcay6dvu", Name = "__slot_BuEy8J2z3HYLGYYcay6dvu")]
        public static int __slot_BuEy8J2z3HYLGYYcay6dvu = 40;
        [n1.ElementAttribute(TracingId = 225871U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "VijzR59e6w6NNDSVIskwLx", Name = "__slot_VijzR59e6w6NNDSVIskwLx")]
        public static int __slot_VijzR59e6w6NNDSVIskwLx = 550;
        [n1.ElementAttribute(TracingId = 225895U, DocumentId = "Dq1mnwSRcGNMR6cVP3iQ2z", PersistentId = "BgbYv6qmAJrNC8124oBP1m", Name = "__slot_BgbYv6qmAJrNC8124oBP1m")]
        public static int __slot_BgbYv6qmAJrNC8124oBP1m = 65;
        static _Operations_()
        {
        }
    }
}

namespace _VL_UI_Settings_
{
    public struct __AdaptiveImplementations__Dq1mnwSRcGNMR6cVP3iQ2z : n33.IAdaptiveCreateDefault<n9.StylesCore_R>, n33.IAdaptiveCreateDefault<n2.Object>, n34.IAdaptiveMin<int>, n34.IAdaptiveOperatorLess<int>, n34.IAdaptiveMax<int>, n34.IAdaptiveOperatorGreater<int>
    {
        public void CreateDefault(out n9.StylesCore_R Output_Out)
        {
            var Output_0 = n9.StylesCore_R.CreateDefault();
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n2.Object Output_Out)
        {
            var Output_0 = n29._Operations_.CreateDefault();
            Output_Out = Output_0;
            return;
        }

        public void Min(int Input_In, int Input_2_In, out int Output_Out)
        {
            n32._Operations_.Min<int, n22.__AdaptiveImplementations__Dq1mnwSRcGNMR6cVP3iQ2z>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorLess(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void Max(int Input_In, int Input_2_In, out int Output_Out)
        {
            n32._Operations_.Max<int, n22.__AdaptiveImplementations__Dq1mnwSRcGNMR6cVP3iQ2z>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorGreater(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In > Input_2_In;
            Result_Out = Result_0;
            return;
        }
    }
}