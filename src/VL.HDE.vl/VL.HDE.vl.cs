extern alias e5;
extern alias e3;
extern alias e2;
extern alias e1;
extern alias e10;
extern alias e4;

using n17 = e2::VL.Lib.Collections;
using n26 = _VL_Skia_.Graphics.Skia;
using n7 = e3::VL.Lib.Primitive.CacheRegion;
using n6 = global::System.Reactive.Subjects;
using n28 = _CoreLibBasics_.Control;
using n34 = _VL_HDE_;
using n27 = _VL_Skia_.Graphics.Skia.Layers;
using n10 = _VL_Reactive_.Reactive.Subjects.Subject.Advanced;
using n30 = _VL_UI_Settings_.Settings;
using n18 = e3::VL.Lib.Reactive;
using n24 = _VL_Reactive_.Reactive.EventPattern.Advanced;
using n32 = _HDE_StylesAndSettings_.HDE;
using n13 = global::System.Collections.Generic;
using n38 = _CoreLibBasics_.Math.Adaptive;
using n37 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n33 = e5::VL.UI.Core;
using n35 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n16 = _VL_Skia_.Graphics.Skia.Internal;
using n29 = _VL_UI_HelpBrowser_.HelpBrowser;
using n1 = e2::VL.Core;
using n3 = global::System;
using n20 = e4::Stride.Core.Mathematics;
using n8 = _System_Reflection_.System.Reflection.IVLFactory.Experimental;
using n4 = _VL_HDE_.HDE;
using n5 = e2::VL.Core.CompilerServices;
using n25 = _VL_Skia_.Graphics.Skia.Transform;
using n9 = global::System.Windows.Forms;
using n23 = _VL_Reactive_.Reactive.ForEach;
using n31 = _VL_UI_KeyMouseDisplay_.HDE;
using n19 = _VL_Reactive_.Reactive.HoldLatest;
using n11 = global::System.Runtime.CompilerServices;
using n12 = _System_Reflection_.System.Reflection.NodeContext.Advanced;
using n14 = e1::VL.Skia;
using n2 = e10::VL.Lang.PublicAPI;
using n21 = _VL_Collections_.Collections.Spread;
using n15 = global::System.Drawing;
using n22 = global::System.Reactive;
using n36 = _CoreLibBasics_.Primitive.Advanced;

namespace _VL_HDE_.HDE
{
    [n1.ElementAttribute(TracingId = 21U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "Srrj1iZHCF4QJARri5YLsC", Name = "Command_C")]
    [n3.SerializableAttribute]
    public class Command_C : n1.VLObject, n2.ICommand, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Command_C Create(n1.NodeContext Node_Context_In)
        {
            Node_Context_In = Node_Context_In.WithIsImmutable(false);
            var instance = new Command_C(Node_Context_In, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context_In);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Command_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new Command_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Command_C Update(string Name_In, n9.Keys Shortcut_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Visible_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n3.IObservable<bool> On_Execute_Out)
        {
            n1.NodeContext __pad_SHLS3hicpkMNZTEIZ0Y3BK_0 = this.__slot_SHLS3hicpkMNZTEIZ0Y3BK;
            n6.Subject<bool> __pad_UUV2g3Hxl8hPxD6TD3T30h_1 = this.__slot_UUV2g3Hxl8hPxD6TD3T30h;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = true;
            var manager_4 = this.__cache_MGSVmcsklfQOf7gjPXvf1e;
            if (manager_4 is null)
            {
                manager_4 = new n7.Manager<n3.ValueTuple<string>, n3.ValueTuple<n3.IDisposable>>(n3.ValueTuple.Create(default(n3.IDisposable)));
            }

            var inputs_5 = n3.ValueTuple.Create(Name_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__J16F2PEeKLJMz31PR7Bmw8>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __J16F2PEeKLJMz31PR7Bmw8(__GetContext__(), n1.VLObject.NewIdentity());
                }

                var Factory_9 = __pad_SHLS3hicpkMNZTEIZ0Y3BK_0.Factory;
                n8._Operations_.GetService<n2.ICommandService>(Input_In: Factory_9, Result_Out: out n2.ICommandService Result_10);
                Command_C Instance_11 = this;
                n2.ICommand Command_12 = (n2.ICommand)Instance_11;
                var Result_13 = ((n2.ICommandService)Result_10).RegisterCommand(name: Name_In, command: Command_12);
                outputs_6 = n3.ValueTuple.Create(Result_13);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_14 = outputs_6.Item1;
            this.__cache_MGSVmcsklfQOf7gjPXvf1e = manager_4;
            this.__slot_ObaFPCj66ADNZfJQV2UuZ5 = Shortcut_In;
            n9.Keys __pad_ObaFPCj66ADNZfJQV2UuZ5_15 = Shortcut_In;
            this.__slot_GMzf20uWSNmM3BRCKN2p6J = Visible_In;
            bool __pad_GMzf20uWSNmM3BRCKN2p6J_16 = Visible_In;
            this.__slot_FJIRobk8mRULD9v6X0TfuT = Enabled_In;
            bool __pad_FJIRobk8mRULD9v6X0TfuT_17 = Enabled_In;
            n3.IObservable<bool> On_Execute_Out_18 = (n3.IObservable<bool>)__pad_UUV2g3Hxl8hPxD6TD3T30h_1;
            On_Execute_Out = On_Execute_Out_18;
            return this;
        }

        public n4.Command_C Execute_()
        {
            n6.Subject<bool> __pad_UUV2g3Hxl8hPxD6TD3T30h_0 = this.__slot_UUV2g3Hxl8hPxD6TD3T30h;
            bool __pad_FnSIFUW9iKWM2jkqvovSxR_1 = __slot_FnSIFUW9iKWM2jkqvovSxR;
            n10._Operations_.OnNext<bool>(Input_In: __pad_UUV2g3Hxl8hPxD6TD3T30h_0, Value_In: __pad_FnSIFUW9iKWM2jkqvovSxR_1, Output_Out: out n6.Subject<bool> Output_2);
            return this;
        }

        public n4.Command_C IsVisible_(out bool Is_Visible_Out)
        {
            bool __pad_GMzf20uWSNmM3BRCKN2p6J_0 = this.__slot_GMzf20uWSNmM3BRCKN2p6J;
            Is_Visible_Out = __pad_GMzf20uWSNmM3BRCKN2p6J_0;
            return this;
        }

        public n4.Command_C IsEnabled_(out bool Is_Enabled_Out)
        {
            bool __pad_FJIRobk8mRULD9v6X0TfuT_0 = this.__slot_FJIRobk8mRULD9v6X0TfuT;
            Is_Enabled_Out = __pad_FJIRobk8mRULD9v6X0TfuT_0;
            return this;
        }

        public n4.Command_C Shortcut_(out n9.Keys Shortcut_Out)
        {
            n9.Keys __pad_ObaFPCj66ADNZfJQV2UuZ5_0 = this.__slot_ObaFPCj66ADNZfJQV2UuZ5;
            Shortcut_Out = __pad_ObaFPCj66ADNZfJQV2UuZ5_0;
            return this;
        }

        public n4.Command_C __Create__(n1.NodeContext Node_Context_In)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_SHLS3hicpkMNZTEIZ0Y3BK = n12._Operations_.CreateDefault_H();
            this.__slot_UUV2g3Hxl8hPxD6TD3T30h = default(n6.Subject<bool>);
            this.__slot_FJIRobk8mRULD9v6X0TfuT = false;
            this.__slot_GMzf20uWSNmM3BRCKN2p6J = false;
            this.__slot_ObaFPCj66ADNZfJQV2UuZ5 = default(n9.Keys);
            this.__slot_SHLS3hicpkMNZTEIZ0Y3BK = Node_Context_In;
            n1.NodeContext __pad_SHLS3hicpkMNZTEIZ0Y3BK_0 = Node_Context_In;
            n1.NodeContext Node_Context_1 = Node_Context_In.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "EWq0yO3UG8fPVizAxgYHDK", 94U);
            n10._Operations_.Create<bool>(Node_Context: Node_Context_1, Output_Out: out n6.Subject<bool> Output_2);
            this.__slot_UUV2g3Hxl8hPxD6TD3T30h = Output_2;
            n6.Subject<bool> __pad_UUV2g3Hxl8hPxD6TD3T30h_3 = Output_2;
            this.__cache_MGSVmcsklfQOf7gjPXvf1e = null;
            return this;
        }

        public n4.Command_C __CreateDefault__()
        {
            this.__slot_SHLS3hicpkMNZTEIZ0Y3BK = n12._Operations_.CreateDefault_H();
            this.__slot_UUV2g3Hxl8hPxD6TD3T30h = default(n6.Subject<bool>);
            this.__slot_FJIRobk8mRULD9v6X0TfuT = false;
            this.__slot_GMzf20uWSNmM3BRCKN2p6J = false;
            this.__slot_ObaFPCj66ADNZfJQV2UuZ5 = default(n9.Keys);
            this.__cache_MGSVmcsklfQOf7gjPXvf1e = null;
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_MGSVmcsklfQOf7gjPXvf1e);
            return;
        }

        void n2.ICommand.Execute()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Execute_();
        }

        n9.Keys n2.ICommand.Shortcut
        {
            get
            {
                using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
                var __returnValue__ = Shortcut_(out n9.Keys out_Shortcut_Out);
                return out_Shortcut_Out;
            }
        }

        bool n2.ICommand.IsVisible
        {
            get
            {
                using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
                var __returnValue__ = IsVisible_(out bool out_Is_Visible_Out);
                return out_Is_Visible_Out;
            }
        }

        bool n2.ICommand.IsEnabled
        {
            get
            {
                using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
                var __returnValue__ = IsEnabled_(out bool out_Is_Enabled_Out);
                return out_Is_Enabled_Out;
            }
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 43U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "FnSIFUW9iKWM2jkqvovSxR", Name = "__slot_FnSIFUW9iKWM2jkqvovSxR")]
        public static bool __slot_FnSIFUW9iKWM2jkqvovSxR = true;
        [n1.ElementAttribute(TracingId = 93U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "SHLS3hicpkMNZTEIZ0Y3BK", Name = "__slot_SHLS3hicpkMNZTEIZ0Y3BK")]
        public n1.NodeContext __slot_SHLS3hicpkMNZTEIZ0Y3BK;
        [n1.ElementAttribute(TracingId = 96U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "UUV2g3Hxl8hPxD6TD3T30h", Name = "__slot_UUV2g3Hxl8hPxD6TD3T30h")]
        public n6.Subject<bool> __slot_UUV2g3Hxl8hPxD6TD3T30h;
        [n1.ElementAttribute(TracingId = 101U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "FJIRobk8mRULD9v6X0TfuT", Name = "__slot_FJIRobk8mRULD9v6X0TfuT")]
        public bool __slot_FJIRobk8mRULD9v6X0TfuT;
        [n1.ElementAttribute(TracingId = 102U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "GMzf20uWSNmM3BRCKN2p6J", Name = "__slot_GMzf20uWSNmM3BRCKN2p6J")]
        public bool __slot_GMzf20uWSNmM3BRCKN2p6J;
        [n1.ElementAttribute(TracingId = 103U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "ObaFPCj66ADNZfJQV2UuZ5", Name = "__slot_ObaFPCj66ADNZfJQV2UuZ5")]
        public n9.Keys __slot_ObaFPCj66ADNZfJQV2UuZ5;
        [n1.ElementAttribute(TracingId = 53U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "MGSVmcsklfQOf7gjPXvf1e", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n3.ValueTuple<string>, n3.ValueTuple<n3.IDisposable>> __cache_MGSVmcsklfQOf7gjPXvf1e = null;
        static Command_C()
        {
        }

        public Command_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Command_C(Command_C other): base(other)
        {
            this.__slot_SHLS3hicpkMNZTEIZ0Y3BK = other.__slot_SHLS3hicpkMNZTEIZ0Y3BK;
            this.__slot_UUV2g3Hxl8hPxD6TD3T30h = other.__slot_UUV2g3Hxl8hPxD6TD3T30h;
            this.__slot_FJIRobk8mRULD9v6X0TfuT = other.__slot_FJIRobk8mRULD9v6X0TfuT;
            this.__slot_GMzf20uWSNmM3BRCKN2p6J = other.__slot_GMzf20uWSNmM3BRCKN2p6J;
            this.__slot_ObaFPCj66ADNZfJQV2UuZ5 = other.__slot_ObaFPCj66ADNZfJQV2UuZ5;
            this.__cache_MGSVmcsklfQOf7gjPXvf1e = other.__cache_MGSVmcsklfQOf7gjPXvf1e;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_SHLS3hicpkMNZTEIZ0Y3BK", in __slot_SHLS3hicpkMNZTEIZ0Y3BK), n1.CompilationHelper.GetValueOrExisting(values, "__slot_UUV2g3Hxl8hPxD6TD3T30h", in __slot_UUV2g3Hxl8hPxD6TD3T30h), n1.CompilationHelper.GetValueOrExisting(values, "__slot_FJIRobk8mRULD9v6X0TfuT", in __slot_FJIRobk8mRULD9v6X0TfuT), n1.CompilationHelper.GetValueOrExisting(values, "__slot_GMzf20uWSNmM3BRCKN2p6J", in __slot_GMzf20uWSNmM3BRCKN2p6J), n1.CompilationHelper.GetValueOrExisting(values, "__slot_ObaFPCj66ADNZfJQV2UuZ5", in __slot_ObaFPCj66ADNZfJQV2UuZ5), n1.CompilationHelper.GetValueOrExisting(values, "__cache_MGSVmcsklfQOf7gjPXvf1e", in __cache_MGSVmcsklfQOf7gjPXvf1e));
        }

        internal Command_C __WITH__(n1.NodeContext __slot_SHLS3hicpkMNZTEIZ0Y3BK, n6.Subject<bool> __slot_UUV2g3Hxl8hPxD6TD3T30h, bool __slot_FJIRobk8mRULD9v6X0TfuT, bool __slot_GMzf20uWSNmM3BRCKN2p6J, n9.Keys __slot_ObaFPCj66ADNZfJQV2UuZ5, n7.Manager<n3.ValueTuple<string>, n3.ValueTuple<n3.IDisposable>> __cache_MGSVmcsklfQOf7gjPXvf1e)
        {
            n4.Command_C that_0 = this;
            this.__slot_SHLS3hicpkMNZTEIZ0Y3BK = __slot_SHLS3hicpkMNZTEIZ0Y3BK;
            this.__slot_UUV2g3Hxl8hPxD6TD3T30h = __slot_UUV2g3Hxl8hPxD6TD3T30h;
            this.__slot_FJIRobk8mRULD9v6X0TfuT = __slot_FJIRobk8mRULD9v6X0TfuT;
            this.__slot_GMzf20uWSNmM3BRCKN2p6J = __slot_GMzf20uWSNmM3BRCKN2p6J;
            this.__slot_ObaFPCj66ADNZfJQV2UuZ5 = __slot_ObaFPCj66ADNZfJQV2UuZ5;
            this.__cache_MGSVmcsklfQOf7gjPXvf1e = __cache_MGSVmcsklfQOf7gjPXvf1e;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "J16F2PEeKLJMz31PR7Bmw8", Name = "__J16F2PEeKLJMz31PR7Bmw8")]
        [n3.SerializableAttribute]
        public class __J16F2PEeKLJMz31PR7Bmw8 : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_JQwpZDZLqhLOAoM7bdfpGG);
                return;
            }

            [n1.ElementAttribute(TracingId = 83U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "JQwpZDZLqhLOAoM7bdfpGG", Name = "This", IsManaged = true, IsAutoGenerated = true)]
            public n3.Object __p_JQwpZDZLqhLOAoM7bdfpGG;
            public __J16F2PEeKLJMz31PR7Bmw8(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __J16F2PEeKLJMz31PR7Bmw8(__J16F2PEeKLJMz31PR7Bmw8 other): base(other)
            {
                this.__p_JQwpZDZLqhLOAoM7bdfpGG = other.__p_JQwpZDZLqhLOAoM7bdfpGG;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JQwpZDZLqhLOAoM7bdfpGG", in __p_JQwpZDZLqhLOAoM7bdfpGG));
            }

            internal __J16F2PEeKLJMz31PR7Bmw8 __WITH__(n3.Object __p_JQwpZDZLqhLOAoM7bdfpGG)
            {
                __J16F2PEeKLJMz31PR7Bmw8 that_0 = this;
                this.__p_JQwpZDZLqhLOAoM7bdfpGG = __p_JQwpZDZLqhLOAoM7bdfpGG;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 472U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "TAgbIeP3KZTPwYrXRW0THm", Name = "SkiaWindow_C")]
    [n3.SerializableAttribute]
    public class SkiaWindow_C : n1.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.SkiaWindow_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new SkiaWindow_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.SkiaWindow_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new SkiaWindow_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.SkiaWindow_C Update(n15.Rectangle Bounds_In, string Name_In, bool Show_Control_Box_In, [n5.SerializedDefaultValueAttribute("Sizable", false)] n9.FormBorderStyle Border_Style_In, n14.ILayer Input_In, [n5.SerializedDefaultValueAttribute("0, 0, 0, 1", false)] n20.Color4 Color_In, [n5.SerializedDefaultValueAttribute("Normalized", false)] n14.CommonSpace Space_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Show_In, out bool On_Close_Out)
        {
            n14.SkiaRenderer __auto_0 = this.Form;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_TvaRA6zbDn3QANTZlPiiwK;
            if (manager_3 is null)
            {
                manager_3 = new n7.Manager<n3.ValueTuple<n15.Rectangle, string, bool, n9.FormBorderStyle>, n3.ValueTuple>(n3.ValueTuple.Create());
            }

            var inputs_4 = (Bounds_In, Name_In, Show_Control_Box_In, Border_Style_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var Is_Empty_8 = Bounds_In.IsEmpty;
                var Output_9 = !Is_Empty_8;
                var Output_10 = __auto_0;
                if (Output_9)
                {
                    __auto_0.SetSize(boundsInDIP: Bounds_In);
                }

                Output_10.Text = Name_In;
                Output_10.ControlBox = Show_Control_Box_In;
                Output_10.FormBorderStyle = Border_Style_In;
                outputs_5 = n3.ValueTuple.Create();
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, default, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            this.__cache_TvaRA6zbDn3QANTZlPiiwK = manager_3;
            bool Apply_11 = true;
            var State_Output_13 = this.__p_QUsK0cwg6P5L9FxJ0ULpFG.Update(Color_In: Color_In, Apply_In: Apply_11, Output_Out: out n16.RenderingNode_C Output_12);
            this.__p_QUsK0cwg6P5L9FxJ0ULpFG = State_Output_13;
            n14.ILayer Input_14 = (n14.ILayer)Output_12;
            bool Debug_15 = false;
            bool Enabled_16 = true;
            var builder_17 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ, 2);
            builder_17.Add(Input_14);
            builder_17.Add(Input_In);
            var __pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ_18 = builder_17.Commit();
            this.__pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ = __pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ_18;
            var State_Output_20 = this.__p_UJptRkd8MH4MKtYytXb0NQ.Update(Input_In: __pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ_18, Debug_In: Debug_15, Enabled_In: Enabled_16, Output_Out: out n14.ILayer Output_19);
            this.__p_UJptRkd8MH4MKtYytXb0NQ = State_Output_20;
            var State_Output_22 = this.__p_NHCnLpcnBXINxpanDefsSG.Update(Input_In: Output_19, Space_In: Space_In, Output_Out: out n14.ILayer Output_21);
            this.__p_NHCnLpcnBXINxpanDefsSG = State_Output_22;
            var Output_25 = this.__p_Oid7ekkl1HrMT5OG0m8RjA.Update(Value_In: Show_In, Up_Edge_Out: out bool Up_Edge_23, Down_Edge_Out: out bool Down_Edge_24);
            this.__p_Oid7ekkl1HrMT5OG0m8RjA = Output_25;
            var Output_26 = __auto_0;
            if (Up_Edge_23)
            {
                __auto_0.Show();
            }

            var Output_27 = Output_26;
            if (Down_Edge_24)
            {
                Output_26.Hide();
            }

            var Visible_28 = Output_27.Visible;
            if (Visible_28)
            {
                __auto_0.Input = Output_21;
                __auto_0.Update();
            }

            n19._Operations_.GetData_H<int>(Input_In: this.__p_N4r53FVwe3LP9byK4aYXrQ, Output_Out: out n18.HoldLatest<int> Output_30, Value_Out: out int Value_31, On_Data_Out: out bool On_Data_32);
            this.__p_N4r53FVwe3LP9byK4aYXrQ = Output_30;
            On_Close_Out = On_Data_32;
            return this;
        }

        public n4.SkiaWindow_C GetForm(out n14.SkiaRenderer Form_Out)
        {
            n14.SkiaRenderer __auto_0 = this.Form;
            Form_Out = __auto_0;
            return this;
        }

        public n4.SkiaWindow_C __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Form = default(n14.SkiaRenderer);
            this.__pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ = n21._Operations_.CreateDefault<n14.ILayer>();
            bool __pad_DJlCGJ38AWGLWnVuywwTif_0 = __slot_DJlCGJ38AWGLWnVuywwTif;
            var Output_1 = new n14.SkiaRenderer();
            Output_1.VSync = __pad_DJlCGJ38AWGLWnVuywwTif_0;
            this.Form = Output_1;
            n14.SkiaRenderer __auto_2 = Output_1;
            string Event_Name_3 = "FormClosing";
            var return_4 = n1.EventBridge.FromEventPattern<n9.FormClosingEventArgs>(target: __auto_2, eventName: Event_Name_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "NUKExE3szoAMua7QSuxxCL", 576U);
            n23._Operations_.Create_H<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int>(Node_Context: Node_Context_5, Output_Out: out n18.ForEach<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int> Output_6);
            this.__p_NUKExE3szoAMua7QSuxxCL = Output_6;
            bool Reset_7 = false;
            var __fallback___8 = n1.ServiceRegistry.Current;
            n23._Operations_.Update_H<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int>(Input_In: Output_6, Messages_In: return_4, Reset_In: Reset_7, Update_In: (n3.Object s_10, n22.EventPattern<n9.FormClosingEventArgs> Input_1_In_11) =>
            {
                using var __current_9 = __fallback___8.MakeCurrentIfNone();
                var state_10 = n1.CompilationHelper.Restore<__VswOh565zW0PasHigzFzGU>(s_10, Node_Context);
                bool __pad_VJtnP5JP3uONjserF2h5Ko_12 = __slot_VJtnP5JP3uONjserF2h5Ko;
                n24._Operations_.EventArgs<n3.Object, n9.FormClosingEventArgs>(Input_In: Input_1_In_11, Event_Args_Out: out n9.FormClosingEventArgs Event_Args_13);
                Event_Args_13.Cancel = __pad_VJtnP5JP3uONjserF2h5Ko_12;
                return n3.Tuple.Create<n3.Object, int>(state_10, 0);
            }

            , Create_In: () =>
            {
                using var __current_14 = __fallback___8.MakeCurrentIfNone();
                var state_10 = new __VswOh565zW0PasHigzFzGU(Node_Context, n1.VLObject.NewIdentity());
                return state_10;
            }

            , Output_Out: out n18.ForEach<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int> Output_15, Result_Out: out n3.IObservable<int> Result_16);
            this.__p_NUKExE3szoAMua7QSuxxCL = Output_15;
            n1.NodeContext Node_Context_17 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "N4r53FVwe3LP9byK4aYXrQ", 595U);
            int Initial_Result_18 = 0;
            n19._Operations_.Create_H<int>(Node_Context: Node_Context_17, Initial_Result_In: Initial_Result_18, Output_Out: out n18.HoldLatest<int> Output_19);
            this.__p_N4r53FVwe3LP9byK4aYXrQ = Output_19;
            bool Reset_20 = false;
            bool Update_21 = true;
            var Output_22 = Output_19;
            if (Update_21)
            {
                n19._Operations_.Update_H<int>(Input_In: Output_19, Async_Notifications_In: Result_16, Reset_In: Reset_20, Output_Out: out Output_22);
            }

            this.__p_N4r53FVwe3LP9byK4aYXrQ = Output_22;
            n1.NodeContext Node_Context_23 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "NHCnLpcnBXINxpanDefsSG", 501U);
            var Output_24 = n25.WithinCommonSpace_DSW6lVxTq3xLoRd5BCbhOD.Create(Node_Context: Node_Context_23);
            this.__p_NHCnLpcnBXINxpanDefsSG = Output_24;
            n1.NodeContext Node_Context_25 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "UJptRkd8MH4MKtYytXb0NQ", 505U);
            var Output_26 = n26.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_25);
            this.__p_UJptRkd8MH4MKtYytXb0NQ = Output_26;
            n1.NodeContext Node_Context_27 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "QUsK0cwg6P5L9FxJ0ULpFG", 511U);
            var Output_28 = n27.Clear_B7wcEtJT7QrOw9jTRtBtUK.Create(Node_Context: Node_Context_27);
            this.__p_QUsK0cwg6P5L9FxJ0ULpFG = Output_28;
            n1.NodeContext Node_Context_29 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "Oid7ekkl1HrMT5OG0m8RjA", 561U);
            var Output_30 = n28.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_29);
            this.__p_Oid7ekkl1HrMT5OG0m8RjA = Output_30;
            this.__cache_TvaRA6zbDn3QANTZlPiiwK = null;
            return this;
        }

        public n4.SkiaWindow_C Dispose_()
        {
            n14.SkiaRenderer __auto_0 = this.Form;
            n3.IDisposable Input_1 = (n3.IDisposable)__auto_0;
            ((n3.IDisposable)Input_1).Dispose();
            n1.CompilationHelper.SafeDispose(this.__cache_TvaRA6zbDn3QANTZlPiiwK);
            n1.CompilationHelper.SafeDispose(this.__p_QUsK0cwg6P5L9FxJ0ULpFG);
            n1.CompilationHelper.SafeDispose(this.__p_UJptRkd8MH4MKtYytXb0NQ);
            n1.CompilationHelper.SafeDispose(this.__p_NHCnLpcnBXINxpanDefsSG);
            n1.CompilationHelper.SafeDispose(this.__p_Oid7ekkl1HrMT5OG0m8RjA);
            n1.CompilationHelper.SafeDispose(this.__p_N4r53FVwe3LP9byK4aYXrQ);
            n1.CompilationHelper.SafeDispose(this.__p_NUKExE3szoAMua7QSuxxCL);
            return this;
        }

        public n4.SkiaWindow_C __CreateDefault__()
        {
            this.Form = default(n14.SkiaRenderer);
            this.__pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ = n21._Operations_.CreateDefault<n14.ILayer>();
            this.__cache_TvaRA6zbDn3QANTZlPiiwK = null;
            this.__p_QUsK0cwg6P5L9FxJ0ULpFG = n27.Clear_B7wcEtJT7QrOw9jTRtBtUK.CreateDefault();
            this.__p_UJptRkd8MH4MKtYytXb0NQ = n26.Group_TKtMtIW1WMIOfh4AlYkjTy.CreateDefault();
            this.__p_NHCnLpcnBXINxpanDefsSG = n25.WithinCommonSpace_DSW6lVxTq3xLoRd5BCbhOD.CreateDefault();
            this.__p_Oid7ekkl1HrMT5OG0m8RjA = n28.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_N4r53FVwe3LP9byK4aYXrQ = default(n18.HoldLatest<int>);
            this.__p_NUKExE3szoAMua7QSuxxCL = default(n18.ForEach<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int>);
            return this;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 559U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "DJlCGJ38AWGLWnVuywwTif", Name = "__slot_DJlCGJ38AWGLWnVuywwTif")]
        public static bool __slot_DJlCGJ38AWGLWnVuywwTif = false;
        [n1.ElementAttribute(TracingId = 477U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "Nb75SpfGHWzNhzDmMxJgZu", Name = "Form")]
        public n14.SkiaRenderer Form;
        [n1.ElementAttribute(TracingId = 520U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "TvaRA6zbDn3QANTZlPiiwK", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n3.ValueTuple<n15.Rectangle, string, bool, n9.FormBorderStyle>, n3.ValueTuple> __cache_TvaRA6zbDn3QANTZlPiiwK = null;
        [n1.ElementAttribute(TracingId = 511U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "QUsK0cwg6P5L9FxJ0ULpFG", Name = "Clear", IsManaged = true, IsAutoGenerated = true)]
        public n27.Clear_B7wcEtJT7QrOw9jTRtBtUK __p_QUsK0cwg6P5L9FxJ0ULpFG;
        [n1.ElementAttribute(TracingId = 505U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "UJptRkd8MH4MKtYytXb0NQ", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n26.Group_TKtMtIW1WMIOfh4AlYkjTy __p_UJptRkd8MH4MKtYytXb0NQ;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n17.Spread<n14.ILayer> __pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ = default(n17.Spread<n14.ILayer>);
        [n1.ElementAttribute(TracingId = 501U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "NHCnLpcnBXINxpanDefsSG", Name = "WithinCommonSpace", IsManaged = true, IsAutoGenerated = true)]
        public n25.WithinCommonSpace_DSW6lVxTq3xLoRd5BCbhOD __p_NHCnLpcnBXINxpanDefsSG;
        [n1.ElementAttribute(TracingId = 561U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "Oid7ekkl1HrMT5OG0m8RjA", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n28.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Oid7ekkl1HrMT5OG0m8RjA;
        [n1.ElementAttribute(TracingId = 595U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "N4r53FVwe3LP9byK4aYXrQ", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n18.HoldLatest<int> __p_N4r53FVwe3LP9byK4aYXrQ;
        [n1.ElementAttribute(TracingId = 576U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "NUKExE3szoAMua7QSuxxCL", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n18.ForEach<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int> __p_NUKExE3szoAMua7QSuxxCL;
        [n1.ElementAttribute(TracingId = 594U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "VJtnP5JP3uONjserF2h5Ko", Name = "__slot_VJtnP5JP3uONjserF2h5Ko")]
        public static bool __slot_VJtnP5JP3uONjserF2h5Ko = true;
        static SkiaWindow_C()
        {
        }

        public SkiaWindow_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SkiaWindow_C(SkiaWindow_C other): base(other)
        {
            this.Form = other.Form;
            this.__cache_TvaRA6zbDn3QANTZlPiiwK = other.__cache_TvaRA6zbDn3QANTZlPiiwK;
            this.__p_QUsK0cwg6P5L9FxJ0ULpFG = other.__p_QUsK0cwg6P5L9FxJ0ULpFG;
            this.__p_UJptRkd8MH4MKtYytXb0NQ = other.__p_UJptRkd8MH4MKtYytXb0NQ;
            this.__pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ = other.__pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ;
            this.__p_NHCnLpcnBXINxpanDefsSG = other.__p_NHCnLpcnBXINxpanDefsSG;
            this.__p_Oid7ekkl1HrMT5OG0m8RjA = other.__p_Oid7ekkl1HrMT5OG0m8RjA;
            this.__p_N4r53FVwe3LP9byK4aYXrQ = other.__p_N4r53FVwe3LP9byK4aYXrQ;
            this.__p_NUKExE3szoAMua7QSuxxCL = other.__p_NUKExE3szoAMua7QSuxxCL;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Form", in Form), n1.CompilationHelper.GetValueOrExisting(values, "__cache_TvaRA6zbDn3QANTZlPiiwK", in __cache_TvaRA6zbDn3QANTZlPiiwK), n1.CompilationHelper.GetValueOrExisting(values, "__p_QUsK0cwg6P5L9FxJ0ULpFG", in __p_QUsK0cwg6P5L9FxJ0ULpFG), n1.CompilationHelper.GetValueOrExisting(values, "__p_UJptRkd8MH4MKtYytXb0NQ", in __p_UJptRkd8MH4MKtYytXb0NQ), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ", in __pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_NHCnLpcnBXINxpanDefsSG", in __p_NHCnLpcnBXINxpanDefsSG), n1.CompilationHelper.GetValueOrExisting(values, "__p_Oid7ekkl1HrMT5OG0m8RjA", in __p_Oid7ekkl1HrMT5OG0m8RjA), n1.CompilationHelper.GetValueOrExisting(values, "__p_N4r53FVwe3LP9byK4aYXrQ", in __p_N4r53FVwe3LP9byK4aYXrQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_NUKExE3szoAMua7QSuxxCL", in __p_NUKExE3szoAMua7QSuxxCL));
        }

        internal SkiaWindow_C __WITH__(n14.SkiaRenderer Form, n7.Manager<n3.ValueTuple<n15.Rectangle, string, bool, n9.FormBorderStyle>, n3.ValueTuple> __cache_TvaRA6zbDn3QANTZlPiiwK, n27.Clear_B7wcEtJT7QrOw9jTRtBtUK __p_QUsK0cwg6P5L9FxJ0ULpFG, n26.Group_TKtMtIW1WMIOfh4AlYkjTy __p_UJptRkd8MH4MKtYytXb0NQ, n17.Spread<n14.ILayer> __pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ, n25.WithinCommonSpace_DSW6lVxTq3xLoRd5BCbhOD __p_NHCnLpcnBXINxpanDefsSG, n28.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Oid7ekkl1HrMT5OG0m8RjA, n18.HoldLatest<int> __p_N4r53FVwe3LP9byK4aYXrQ, n18.ForEach<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int> __p_NUKExE3szoAMua7QSuxxCL)
        {
            n4.SkiaWindow_C that_0 = this;
            this.Form = Form;
            this.__cache_TvaRA6zbDn3QANTZlPiiwK = __cache_TvaRA6zbDn3QANTZlPiiwK;
            this.__p_QUsK0cwg6P5L9FxJ0ULpFG = __p_QUsK0cwg6P5L9FxJ0ULpFG;
            this.__p_UJptRkd8MH4MKtYytXb0NQ = __p_UJptRkd8MH4MKtYytXb0NQ;
            this.__pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ = __pin_group_Input_In_UJptRkd8MH4MKtYytXb0NQ;
            this.__p_NHCnLpcnBXINxpanDefsSG = __p_NHCnLpcnBXINxpanDefsSG;
            this.__p_Oid7ekkl1HrMT5OG0m8RjA = __p_Oid7ekkl1HrMT5OG0m8RjA;
            this.__p_N4r53FVwe3LP9byK4aYXrQ = __p_N4r53FVwe3LP9byK4aYXrQ;
            this.__p_NUKExE3szoAMua7QSuxxCL = __p_NUKExE3szoAMua7QSuxxCL;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "VswOh565zW0PasHigzFzGU", Name = "__VswOh565zW0PasHigzFzGU")]
        [n3.SerializableAttribute]
        public class __VswOh565zW0PasHigzFzGU : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __VswOh565zW0PasHigzFzGU(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __VswOh565zW0PasHigzFzGU(__VswOh565zW0PasHigzFzGU other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__();
            }

            internal __VswOh565zW0PasHigzFzGU __WITH__()
            {
                return this;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 1060U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "PB8iVjcJ0ZULqcvHbD0HsC", Name = "SkiaWindowTopmost_C")]
    [n3.SerializableAttribute]
    public class SkiaWindowTopmost_C : n1.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.SkiaWindowTopmost_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new SkiaWindowTopmost_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.SkiaWindowTopmost_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new SkiaWindowTopmost_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.SkiaWindowTopmost_C Update(n15.Rectangle Bounds_In, string Name_In, bool Show_Control_Box_In, [n5.SerializedDefaultValueAttribute("Sizable", false)] n9.FormBorderStyle Border_Style_In, n14.ILayer Input_In, [n5.SerializedDefaultValueAttribute("0, 0, 0, 1", false)] n20.Color4 Color_In, [n5.SerializedDefaultValueAttribute("Normalized", false)] n14.CommonSpace Space_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Show_In, out bool On_Close_Out)
        {
            n14.SkiaRenderer __auto_0 = this.Form;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_CXzhZZsL33NLnikxyzivE9;
            if (manager_3 is null)
            {
                manager_3 = new n7.Manager<n3.ValueTuple<n15.Rectangle, string, bool, n9.FormBorderStyle>, n3.ValueTuple>(n3.ValueTuple.Create());
            }

            var inputs_4 = (Bounds_In, Name_In, Show_Control_Box_In, Border_Style_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var Is_Empty_8 = Bounds_In.IsEmpty;
                var Output_9 = !Is_Empty_8;
                var Output_10 = __auto_0;
                if (Output_9)
                {
                    __auto_0.SetSize(boundsInDIP: Bounds_In);
                }

                Output_10.Text = Name_In;
                Output_10.ControlBox = Show_Control_Box_In;
                Output_10.FormBorderStyle = Border_Style_In;
                outputs_5 = n3.ValueTuple.Create();
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, default, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            this.__cache_CXzhZZsL33NLnikxyzivE9 = manager_3;
            bool Apply_11 = true;
            var State_Output_13 = this.__p_ODlLl691cE7PkUxeeCmDiD.Update(Color_In: Color_In, Apply_In: Apply_11, Output_Out: out n16.RenderingNode_C Output_12);
            this.__p_ODlLl691cE7PkUxeeCmDiD = State_Output_13;
            n14.ILayer Input_14 = (n14.ILayer)Output_12;
            bool Debug_15 = false;
            bool Enabled_16 = true;
            var builder_17 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg, 2);
            builder_17.Add(Input_14);
            builder_17.Add(Input_In);
            var __pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg_18 = builder_17.Commit();
            this.__pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg = __pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg_18;
            var State_Output_20 = this.__p_Cc6jVXHOeo6PI2GzpqEbEg.Update(Input_In: __pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg_18, Debug_In: Debug_15, Enabled_In: Enabled_16, Output_Out: out n14.ILayer Output_19);
            this.__p_Cc6jVXHOeo6PI2GzpqEbEg = State_Output_20;
            var State_Output_22 = this.__p_KsDjKHWECUIMdpe4smbfni.Update(Input_In: Output_19, Space_In: Space_In, Output_Out: out n14.ILayer Output_21);
            this.__p_KsDjKHWECUIMdpe4smbfni = State_Output_22;
            var Output_25 = this.__p_PfBHCKJadaKOTah23jIzCK.Update(Value_In: Show_In, Up_Edge_Out: out bool Up_Edge_23, Down_Edge_Out: out bool Down_Edge_24);
            this.__p_PfBHCKJadaKOTah23jIzCK = Output_25;
            var Output_26 = __auto_0;
            if (Up_Edge_23)
            {
                __auto_0.Show();
            }

            var Output_27 = Output_26;
            if (Down_Edge_24)
            {
                Output_26.Hide();
            }

            var Visible_28 = Output_27.Visible;
            if (Visible_28)
            {
                __auto_0.Input = Output_21;
                __auto_0.Update();
            }

            n19._Operations_.GetData_H<int>(Input_In: this.__p_CrRhhmJb6jsP2QlboyZzNj, Output_Out: out n18.HoldLatest<int> Output_30, Value_Out: out int Value_31, On_Data_Out: out bool On_Data_32);
            this.__p_CrRhhmJb6jsP2QlboyZzNj = Output_30;
            On_Close_Out = On_Data_32;
            return this;
        }

        public n4.SkiaWindowTopmost_C GetForm(out n14.SkiaRenderer Form_Out)
        {
            n14.SkiaRenderer __auto_0 = this.Form;
            Form_Out = __auto_0;
            return this;
        }

        public n4.SkiaWindowTopmost_C __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Form = default(n14.SkiaRenderer);
            this.__pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg = n21._Operations_.CreateDefault<n14.ILayer>();
            bool __pad_Lx7bblJ3dWBLlDb0E28x2O_0 = __slot_Lx7bblJ3dWBLlDb0E28x2O;
            var Output_1 = new n14.SkiaRendererTopMost();
            Output_1.VSync = __pad_Lx7bblJ3dWBLlDb0E28x2O_0;
            this.Form = Output_1;
            n14.SkiaRenderer __auto_2 = Output_1;
            string Event_Name_3 = "FormClosing";
            var return_4 = n1.EventBridge.FromEventPattern<n9.FormClosingEventArgs>(target: __auto_2, eventName: Event_Name_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "QrY41Gu8zpSPMjPgw5FLJ8", 1311U);
            n23._Operations_.Create_H<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int>(Node_Context: Node_Context_5, Output_Out: out n18.ForEach<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int> Output_6);
            this.__p_QrY41Gu8zpSPMjPgw5FLJ8 = Output_6;
            bool Reset_7 = false;
            var __fallback___8 = n1.ServiceRegistry.Current;
            n23._Operations_.Update_H<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int>(Input_In: Output_6, Messages_In: return_4, Reset_In: Reset_7, Update_In: (n3.Object s_10, n22.EventPattern<n9.FormClosingEventArgs> Input_1_In_11) =>
            {
                using var __current_9 = __fallback___8.MakeCurrentIfNone();
                var state_10 = n1.CompilationHelper.Restore<__LzYkub0LKEfMelpaJscolp>(s_10, Node_Context);
                bool __pad_Nh0Kohg1O5LPJl0HaMnFHJ_12 = __slot_Nh0Kohg1O5LPJl0HaMnFHJ;
                n24._Operations_.EventArgs<n3.Object, n9.FormClosingEventArgs>(Input_In: Input_1_In_11, Event_Args_Out: out n9.FormClosingEventArgs Event_Args_13);
                Event_Args_13.Cancel = __pad_Nh0Kohg1O5LPJl0HaMnFHJ_12;
                return n3.Tuple.Create<n3.Object, int>(state_10, 0);
            }

            , Create_In: () =>
            {
                using var __current_14 = __fallback___8.MakeCurrentIfNone();
                var state_10 = new __LzYkub0LKEfMelpaJscolp(Node_Context, n1.VLObject.NewIdentity());
                return state_10;
            }

            , Output_Out: out n18.ForEach<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int> Output_15, Result_Out: out n3.IObservable<int> Result_16);
            this.__p_QrY41Gu8zpSPMjPgw5FLJ8 = Output_15;
            n1.NodeContext Node_Context_17 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "CrRhhmJb6jsP2QlboyZzNj", 1353U);
            int Initial_Result_18 = 0;
            n19._Operations_.Create_H<int>(Node_Context: Node_Context_17, Initial_Result_In: Initial_Result_18, Output_Out: out n18.HoldLatest<int> Output_19);
            this.__p_CrRhhmJb6jsP2QlboyZzNj = Output_19;
            bool Reset_20 = false;
            bool Update_21 = true;
            var Output_22 = Output_19;
            if (Update_21)
            {
                n19._Operations_.Update_H<int>(Input_In: Output_19, Async_Notifications_In: Result_16, Reset_In: Reset_20, Output_Out: out Output_22);
            }

            this.__p_CrRhhmJb6jsP2QlboyZzNj = Output_22;
            n1.NodeContext Node_Context_23 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "KsDjKHWECUIMdpe4smbfni", 1117U);
            var Output_24 = n25.WithinCommonSpace_DSW6lVxTq3xLoRd5BCbhOD.Create(Node_Context: Node_Context_23);
            this.__p_KsDjKHWECUIMdpe4smbfni = Output_24;
            n1.NodeContext Node_Context_25 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "Cc6jVXHOeo6PI2GzpqEbEg", 1127U);
            var Output_26 = n26.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_25);
            this.__p_Cc6jVXHOeo6PI2GzpqEbEg = Output_26;
            n1.NodeContext Node_Context_27 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "ODlLl691cE7PkUxeeCmDiD", 1150U);
            var Output_28 = n27.Clear_B7wcEtJT7QrOw9jTRtBtUK.Create(Node_Context: Node_Context_27);
            this.__p_ODlLl691cE7PkUxeeCmDiD = Output_28;
            n1.NodeContext Node_Context_29 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "PfBHCKJadaKOTah23jIzCK", 1276U);
            var Output_30 = n28.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_29);
            this.__p_PfBHCKJadaKOTah23jIzCK = Output_30;
            this.__cache_CXzhZZsL33NLnikxyzivE9 = null;
            return this;
        }

        public n4.SkiaWindowTopmost_C Dispose_()
        {
            n14.SkiaRenderer __auto_0 = this.Form;
            n3.IDisposable Input_1 = (n3.IDisposable)__auto_0;
            ((n3.IDisposable)Input_1).Dispose();
            n1.CompilationHelper.SafeDispose(this.__cache_CXzhZZsL33NLnikxyzivE9);
            n1.CompilationHelper.SafeDispose(this.__p_ODlLl691cE7PkUxeeCmDiD);
            n1.CompilationHelper.SafeDispose(this.__p_Cc6jVXHOeo6PI2GzpqEbEg);
            n1.CompilationHelper.SafeDispose(this.__p_KsDjKHWECUIMdpe4smbfni);
            n1.CompilationHelper.SafeDispose(this.__p_PfBHCKJadaKOTah23jIzCK);
            n1.CompilationHelper.SafeDispose(this.__p_CrRhhmJb6jsP2QlboyZzNj);
            n1.CompilationHelper.SafeDispose(this.__p_QrY41Gu8zpSPMjPgw5FLJ8);
            return this;
        }

        public n4.SkiaWindowTopmost_C __CreateDefault__()
        {
            this.Form = default(n14.SkiaRenderer);
            this.__pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg = n21._Operations_.CreateDefault<n14.ILayer>();
            this.__cache_CXzhZZsL33NLnikxyzivE9 = null;
            this.__p_ODlLl691cE7PkUxeeCmDiD = n27.Clear_B7wcEtJT7QrOw9jTRtBtUK.CreateDefault();
            this.__p_Cc6jVXHOeo6PI2GzpqEbEg = n26.Group_TKtMtIW1WMIOfh4AlYkjTy.CreateDefault();
            this.__p_KsDjKHWECUIMdpe4smbfni = n25.WithinCommonSpace_DSW6lVxTq3xLoRd5BCbhOD.CreateDefault();
            this.__p_PfBHCKJadaKOTah23jIzCK = n28.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_CrRhhmJb6jsP2QlboyZzNj = default(n18.HoldLatest<int>);
            this.__p_QrY41Gu8zpSPMjPgw5FLJ8 = default(n18.ForEach<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int>);
            return this;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 1266U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "Lx7bblJ3dWBLlDb0E28x2O", Name = "__slot_Lx7bblJ3dWBLlDb0E28x2O")]
        public static bool __slot_Lx7bblJ3dWBLlDb0E28x2O = false;
        [n1.ElementAttribute(TracingId = 1068U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "NA2AuYCSVosQIsgzxs4ugs", Name = "Form")]
        public n14.SkiaRenderer Form;
        [n1.ElementAttribute(TracingId = 1164U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "CXzhZZsL33NLnikxyzivE9", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n3.ValueTuple<n15.Rectangle, string, bool, n9.FormBorderStyle>, n3.ValueTuple> __cache_CXzhZZsL33NLnikxyzivE9 = null;
        [n1.ElementAttribute(TracingId = 1150U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "ODlLl691cE7PkUxeeCmDiD", Name = "Clear", IsManaged = true, IsAutoGenerated = true)]
        public n27.Clear_B7wcEtJT7QrOw9jTRtBtUK __p_ODlLl691cE7PkUxeeCmDiD;
        [n1.ElementAttribute(TracingId = 1127U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "Cc6jVXHOeo6PI2GzpqEbEg", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n26.Group_TKtMtIW1WMIOfh4AlYkjTy __p_Cc6jVXHOeo6PI2GzpqEbEg;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n17.Spread<n14.ILayer> __pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg = default(n17.Spread<n14.ILayer>);
        [n1.ElementAttribute(TracingId = 1117U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "KsDjKHWECUIMdpe4smbfni", Name = "WithinCommonSpace", IsManaged = true, IsAutoGenerated = true)]
        public n25.WithinCommonSpace_DSW6lVxTq3xLoRd5BCbhOD __p_KsDjKHWECUIMdpe4smbfni;
        [n1.ElementAttribute(TracingId = 1276U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "PfBHCKJadaKOTah23jIzCK", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n28.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_PfBHCKJadaKOTah23jIzCK;
        [n1.ElementAttribute(TracingId = 1353U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "CrRhhmJb6jsP2QlboyZzNj", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n18.HoldLatest<int> __p_CrRhhmJb6jsP2QlboyZzNj;
        [n1.ElementAttribute(TracingId = 1311U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "QrY41Gu8zpSPMjPgw5FLJ8", Name = "ForEach", IsManaged = true, IsAutoGenerated = true)]
        public n18.ForEach<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int> __p_QrY41Gu8zpSPMjPgw5FLJ8;
        [n1.ElementAttribute(TracingId = 1347U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "Nh0Kohg1O5LPJl0HaMnFHJ", Name = "__slot_Nh0Kohg1O5LPJl0HaMnFHJ")]
        public static bool __slot_Nh0Kohg1O5LPJl0HaMnFHJ = true;
        static SkiaWindowTopmost_C()
        {
        }

        public SkiaWindowTopmost_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SkiaWindowTopmost_C(SkiaWindowTopmost_C other): base(other)
        {
            this.Form = other.Form;
            this.__cache_CXzhZZsL33NLnikxyzivE9 = other.__cache_CXzhZZsL33NLnikxyzivE9;
            this.__p_ODlLl691cE7PkUxeeCmDiD = other.__p_ODlLl691cE7PkUxeeCmDiD;
            this.__p_Cc6jVXHOeo6PI2GzpqEbEg = other.__p_Cc6jVXHOeo6PI2GzpqEbEg;
            this.__pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg = other.__pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg;
            this.__p_KsDjKHWECUIMdpe4smbfni = other.__p_KsDjKHWECUIMdpe4smbfni;
            this.__p_PfBHCKJadaKOTah23jIzCK = other.__p_PfBHCKJadaKOTah23jIzCK;
            this.__p_CrRhhmJb6jsP2QlboyZzNj = other.__p_CrRhhmJb6jsP2QlboyZzNj;
            this.__p_QrY41Gu8zpSPMjPgw5FLJ8 = other.__p_QrY41Gu8zpSPMjPgw5FLJ8;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Form", in Form), n1.CompilationHelper.GetValueOrExisting(values, "__cache_CXzhZZsL33NLnikxyzivE9", in __cache_CXzhZZsL33NLnikxyzivE9), n1.CompilationHelper.GetValueOrExisting(values, "__p_ODlLl691cE7PkUxeeCmDiD", in __p_ODlLl691cE7PkUxeeCmDiD), n1.CompilationHelper.GetValueOrExisting(values, "__p_Cc6jVXHOeo6PI2GzpqEbEg", in __p_Cc6jVXHOeo6PI2GzpqEbEg), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg", in __pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg), n1.CompilationHelper.GetValueOrExisting(values, "__p_KsDjKHWECUIMdpe4smbfni", in __p_KsDjKHWECUIMdpe4smbfni), n1.CompilationHelper.GetValueOrExisting(values, "__p_PfBHCKJadaKOTah23jIzCK", in __p_PfBHCKJadaKOTah23jIzCK), n1.CompilationHelper.GetValueOrExisting(values, "__p_CrRhhmJb6jsP2QlboyZzNj", in __p_CrRhhmJb6jsP2QlboyZzNj), n1.CompilationHelper.GetValueOrExisting(values, "__p_QrY41Gu8zpSPMjPgw5FLJ8", in __p_QrY41Gu8zpSPMjPgw5FLJ8));
        }

        internal SkiaWindowTopmost_C __WITH__(n14.SkiaRenderer Form, n7.Manager<n3.ValueTuple<n15.Rectangle, string, bool, n9.FormBorderStyle>, n3.ValueTuple> __cache_CXzhZZsL33NLnikxyzivE9, n27.Clear_B7wcEtJT7QrOw9jTRtBtUK __p_ODlLl691cE7PkUxeeCmDiD, n26.Group_TKtMtIW1WMIOfh4AlYkjTy __p_Cc6jVXHOeo6PI2GzpqEbEg, n17.Spread<n14.ILayer> __pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg, n25.WithinCommonSpace_DSW6lVxTq3xLoRd5BCbhOD __p_KsDjKHWECUIMdpe4smbfni, n28.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_PfBHCKJadaKOTah23jIzCK, n18.HoldLatest<int> __p_CrRhhmJb6jsP2QlboyZzNj, n18.ForEach<n3.Object, n22.EventPattern<n9.FormClosingEventArgs>, int> __p_QrY41Gu8zpSPMjPgw5FLJ8)
        {
            n4.SkiaWindowTopmost_C that_0 = this;
            this.Form = Form;
            this.__cache_CXzhZZsL33NLnikxyzivE9 = __cache_CXzhZZsL33NLnikxyzivE9;
            this.__p_ODlLl691cE7PkUxeeCmDiD = __p_ODlLl691cE7PkUxeeCmDiD;
            this.__p_Cc6jVXHOeo6PI2GzpqEbEg = __p_Cc6jVXHOeo6PI2GzpqEbEg;
            this.__pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg = __pin_group_Input_In_Cc6jVXHOeo6PI2GzpqEbEg;
            this.__p_KsDjKHWECUIMdpe4smbfni = __p_KsDjKHWECUIMdpe4smbfni;
            this.__p_PfBHCKJadaKOTah23jIzCK = __p_PfBHCKJadaKOTah23jIzCK;
            this.__p_CrRhhmJb6jsP2QlboyZzNj = __p_CrRhhmJb6jsP2QlboyZzNj;
            this.__p_QrY41Gu8zpSPMjPgw5FLJ8 = __p_QrY41Gu8zpSPMjPgw5FLJ8;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "LzYkub0LKEfMelpaJscolp", Name = "__LzYkub0LKEfMelpaJscolp")]
        [n3.SerializableAttribute]
        public class __LzYkub0LKEfMelpaJscolp : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __LzYkub0LKEfMelpaJscolp(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __LzYkub0LKEfMelpaJscolp(__LzYkub0LKEfMelpaJscolp other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__();
            }

            internal __LzYkub0LKEfMelpaJscolp __WITH__()
            {
                return this;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 1452U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "QlaTXIlXgxNPy7nQvwDUCi", Name = "VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi")]
    [n3.SerializableAttribute]
    public class VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi : n1.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi CreateDefault()
        {
            var instance = new VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi Update()
        {
            bool Update_0 = true;
            var Output_1 = this.__p_E64pgREB3PyNWJ3J5f2lOx;
            if (Update_0)
            {
                Output_1 = this.__p_E64pgREB3PyNWJ3J5f2lOx.Update();
            }

            bool Update_2 = true;
            var Output_3 = this.__p_HMwUHeRKzsOO9PAqHdsVOR;
            if (Update_2)
            {
                Output_3 = this.__p_HMwUHeRKzsOO9PAqHdsVOR.Update();
            }

            bool Update_4 = true;
            var Output_5 = this.__p_B3Vpp509s8TLzoYNJvHSKK;
            if (Update_4)
            {
                Output_5 = this.__p_B3Vpp509s8TLzoYNJvHSKK.Update();
            }

            n4.VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi that_6 = this;
            if (this.__GetContext__().IsImmutable)
                that_6 = Output_1 != this.__p_E64pgREB3PyNWJ3J5f2lOx || Output_3 != this.__p_HMwUHeRKzsOO9PAqHdsVOR || Output_5 != this.__p_B3Vpp509s8TLzoYNJvHSKK ? new VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi(this)
                {__p_E64pgREB3PyNWJ3J5f2lOx = Output_1, __p_HMwUHeRKzsOO9PAqHdsVOR = Output_3, __p_B3Vpp509s8TLzoYNJvHSKK = Output_5} : that_6;
            else
            {
                this.__p_E64pgREB3PyNWJ3J5f2lOx = Output_1;
                this.__p_HMwUHeRKzsOO9PAqHdsVOR = Output_3;
                this.__p_B3Vpp509s8TLzoYNJvHSKK = Output_5;
            }

            return that_6;
        }

        public n4.VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "E64pgREB3PyNWJ3J5f2lOx", 1455U);
            var Output_1 = n29.HelpBrowserCommand_C.Create(Node_Context_In: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "HMwUHeRKzsOO9PAqHdsVOR", 1458U);
            var Output_3 = n30.SettingsCommand_C.Create(Node_Context_In: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("E09rriOsHG5LFQGoJXUicu", "B3Vpp509s8TLzoYNJvHSKK", 1461U);
            var Output_5 = n31.KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J.Create(Node_Context: Node_Context_4);
            n4.VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi that_6 = this;
            this.__p_E64pgREB3PyNWJ3J5f2lOx = Output_1;
            this.__p_HMwUHeRKzsOO9PAqHdsVOR = Output_3;
            this.__p_B3Vpp509s8TLzoYNJvHSKK = Output_5;
            return that_6;
        }

        public n4.VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi __CreateDefault__()
        {
            n4.VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi that_0 = this;
            this.__p_E64pgREB3PyNWJ3J5f2lOx = n29.HelpBrowserCommand_C.CreateDefault();
            this.__p_HMwUHeRKzsOO9PAqHdsVOR = n30.SettingsCommand_C.CreateDefault();
            this.__p_B3Vpp509s8TLzoYNJvHSKK = n31.KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_E64pgREB3PyNWJ3J5f2lOx);
            n1.CompilationHelper.SafeDispose(this.__p_HMwUHeRKzsOO9PAqHdsVOR);
            n1.CompilationHelper.SafeDispose(this.__p_B3Vpp509s8TLzoYNJvHSKK);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 1455U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "E64pgREB3PyNWJ3J5f2lOx", Name = "HelpBrowserCommand", IsManaged = true, IsAutoGenerated = true)]
        public n29.HelpBrowserCommand_C __p_E64pgREB3PyNWJ3J5f2lOx;
        [n1.ElementAttribute(TracingId = 1458U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "HMwUHeRKzsOO9PAqHdsVOR", Name = "SettingsCommand", IsManaged = true, IsAutoGenerated = true)]
        public n30.SettingsCommand_C __p_HMwUHeRKzsOO9PAqHdsVOR;
        [n1.ElementAttribute(TracingId = 1461U, DocumentId = "E09rriOsHG5LFQGoJXUicu", PersistentId = "B3Vpp509s8TLzoYNJvHSKK", Name = "KeyMouseDisplayCommand", IsManaged = true, IsAutoGenerated = true)]
        public n31.KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J __p_B3Vpp509s8TLzoYNJvHSKK;
        public VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi(VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi other): base(other)
        {
            this.__p_E64pgREB3PyNWJ3J5f2lOx = other.__p_E64pgREB3PyNWJ3J5f2lOx;
            this.__p_HMwUHeRKzsOO9PAqHdsVOR = other.__p_HMwUHeRKzsOO9PAqHdsVOR;
            this.__p_B3Vpp509s8TLzoYNJvHSKK = other.__p_B3Vpp509s8TLzoYNJvHSKK;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_E64pgREB3PyNWJ3J5f2lOx", in __p_E64pgREB3PyNWJ3J5f2lOx), n1.CompilationHelper.GetValueOrExisting(values, "__p_HMwUHeRKzsOO9PAqHdsVOR", in __p_HMwUHeRKzsOO9PAqHdsVOR), n1.CompilationHelper.GetValueOrExisting(values, "__p_B3Vpp509s8TLzoYNJvHSKK", in __p_B3Vpp509s8TLzoYNJvHSKK));
        }

        internal VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi __WITH__(n29.HelpBrowserCommand_C __p_E64pgREB3PyNWJ3J5f2lOx, n30.SettingsCommand_C __p_HMwUHeRKzsOO9PAqHdsVOR, n31.KeyMouseDisplayCommand_DsCLB6EoFC6NEyeO7Mm33J __p_B3Vpp509s8TLzoYNJvHSKK)
        {
            n4.VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_E64pgREB3PyNWJ3J5f2lOx != this.__p_E64pgREB3PyNWJ3J5f2lOx || __p_HMwUHeRKzsOO9PAqHdsVOR != this.__p_HMwUHeRKzsOO9PAqHdsVOR || __p_B3Vpp509s8TLzoYNJvHSKK != this.__p_B3Vpp509s8TLzoYNJvHSKK ? new VL_HDEApplication_QlaTXIlXgxNPy7nQvwDUCi(this)
                {__p_E64pgREB3PyNWJ3J5f2lOx = __p_E64pgREB3PyNWJ3J5f2lOx, __p_HMwUHeRKzsOO9PAqHdsVOR = __p_HMwUHeRKzsOO9PAqHdsVOR, __p_B3Vpp509s8TLzoYNJvHSKK = __p_B3Vpp509s8TLzoYNJvHSKK} : that_0;
            else
            {
                this.__p_E64pgREB3PyNWJ3J5f2lOx = __p_E64pgREB3PyNWJ3J5f2lOx;
                this.__p_HMwUHeRKzsOO9PAqHdsVOR = __p_HMwUHeRKzsOO9PAqHdsVOR;
                this.__p_B3Vpp509s8TLzoYNJvHSKK = __p_B3Vpp509s8TLzoYNJvHSKK;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 15U, DocumentId = "E09rriOsHG5LFQGoJXUicu", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void WindowBounds_EditorHeight([n5.SerializedDefaultValueAttribute("540", false)] int Width_In, out n15.Rectangle Output_Out)
        {
            n32._Operations_.GetMainWindowBoundsInPixel(Result_Out: out n15.Rectangle Result_0);
            var Output_1 = n33.DIPHelpers.DIP(pixel: Result_0);
            var Height_2 = Output_1.Height;
            n4._Operations_.WindowBounds(Width_In: Width_In, Height_In: Height_2, Output_Out: out n15.Rectangle Output_3);
            Output_Out = Output_3;
            return;
        }

        public static void WindowBounds([n5.SerializedDefaultValueAttribute("540", false)] int Width_In, [n5.SerializedDefaultValueAttribute("540", false)] int Height_In, out n15.Rectangle Output_Out)
        {
            n32._Operations_.GetMainWindowBoundsInPixel(Result_Out: out n15.Rectangle Result_0);
            var Right_1 = Result_0.Right;
            int Input_2_2 = 10;
            var Output_3 = Right_1 + Input_2_2;
            var Left_4 = Result_0.Left;
            var Output_5 = Right_1 + Left_4;
            int Input_2_6 = 2;
            var Output_7 = Output_5 / Input_2_6;
            var Top_8 = Result_0.Top;
            var Bottom_9 = Result_0.Bottom;
            var Output_10 = Top_8 + Bottom_9;
            int Input_2_11 = 2;
            var Output_12 = Output_10 / Input_2_11;
            var Output_13 = new n15.Point(x: Output_7, y: Output_12);
            var Result_14 = n9.Screen.FromPoint(point: Output_13);
            var Bounds_15 = Result_14.Bounds;
            var Right_16 = Bounds_15.Right;
            var Output_17 = n33.DIPHelpers.DIPToPixel(dip: Width_In);
            int Input_3_18 = 4;
            var Output_19 = Right_16 - Output_17;
            var Output_20 = Output_19 - Input_3_18;
            n35._Operations_.Min<int, n34.__AdaptiveImplementations__E09rriOsHG5LFQGoJXUicu>(Input_In: Output_3, Input_2_In: Output_20, Output_Out: out int Output_21);
            Result_0.X = Output_21;
            var Output_22 = n33.DIPHelpers.DIP(pixel: Result_0);
            Output_22.Height = Height_In;
            Output_22.Width = Width_In;
            Output_Out = Output_22;
            return;
        }
    }
}

namespace _VL_HDE_
{
    public struct __AdaptiveImplementations__E09rriOsHG5LFQGoJXUicu : n37.IAdaptiveCreateDefault<n9.FormClosingEventArgs>, n38.IAdaptiveOperatorLess<int>
    {
        public void CreateDefault(out n9.FormClosingEventArgs Output_Out)
        {
            n36._Operations_.CreateDefault_Generic<n9.FormClosingEventArgs>(Output_Out: out n9.FormClosingEventArgs Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorLess(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }
    }
}