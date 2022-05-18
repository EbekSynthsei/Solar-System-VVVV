extern alias e3;
extern alias e2;
extern alias e17;
extern alias e4;

using n17 = e3::VL.Lib.Primitive.CacheRegion;
using n18 = _CoreLibBasics_.Primitive.Object.Advanced;
using n11 = _VL_CoreLib_Windows_.System.Windows.Advanced;
using n19 = _CoreLibBasics_.Control;
using n4 = _VL_CoreLib_Windows_;
using n14 = global::System.Collections.Generic;
using n16 = e3::VL.Lib.Primitive;
using n13 = e3::VL.Lib.Mathematics;
using n1 = e2::VL.Core;
using n2 = global::System;
using n15 = e4::Stride.Core.Mathematics;
using n12 = _CoreLibBasics_._2D.RectangleAnchor;
using n9 = e3::VL.Lib.Primitive.Object;
using n5 = e2::VL.Core.CompilerServices;
using n6 = _VL_CoreLib_Windows_.System.Windows;
using n10 = global::System.Windows.Forms;
using n3 = e17::VL.CoreLib.Windows.DllImport;
using n7 = global::System.Runtime.CompilerServices;
using n8 = global::System.Drawing;

namespace _VL_CoreLib_Windows_.System.Windows
{
    [n1.ElementAttribute(TracingId = 43831U, DocumentId = "HylXxkKPeF0O6LWz4fSQKo", PersistentId = "TXbwxGLVQe9QXZeFcq3TYX", Name = "WindowState_TXbwxGLVQe9QXZeFcq3TYX")]
    [n2.SerializableAttribute]
    public class WindowState_TXbwxGLVQe9QXZeFcq3TYX : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n6.WindowState_TXbwxGLVQe9QXZeFcq3TYX Create(n1.NodeContext Node_Context)
        {
            var instance = new WindowState_TXbwxGLVQe9QXZeFcq3TYX(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n6.WindowState_TXbwxGLVQe9QXZeFcq3TYX CreateDefault()
        {
            var instance = new WindowState_TXbwxGLVQe9QXZeFcq3TYX(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n6.WindowState_TXbwxGLVQe9QXZeFcq3TYX Update(n10.Form Input_In, out n10.Form Output_Out, out string Caption_Out, out n10.FormBorderStyle Border_Style_Out, out bool Control_Box_Out, out n10.FormWindowState State_Out, out bool Visible_Out)
        {
            n9.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            n10.FormWindowState Window_State_2;
            bool Visible_3;
            string Text_4;
            n10.FormBorderStyle Form_Border_Style_5;
            bool Control_Box_6;
            if (Result_0)
            {
                var Form_Border_Style_8 = Input_In.FormBorderStyle;
                var Window_State_9 = Input_In.WindowState;
                var Control_Box_10 = Input_In.ControlBox;
                var Text_11 = Input_In.Text;
                var Visible_12 = Input_In.Visible;
                Form_Border_Style_5 = Form_Border_Style_8;
                Window_State_2 = Window_State_9;
                Control_Box_6 = Control_Box_10;
                Text_4 = Text_11;
                Visible_3 = Visible_12;
            }
            else
            {
                Window_State_2 = default(n10.FormWindowState);
                Visible_3 = false;
                Text_4 = "";
                Form_Border_Style_5 = default(n10.FormBorderStyle);
                Control_Box_6 = false;
            }

            Output_Out = Input_In;
            Caption_Out = Text_4;
            Border_Style_Out = Form_Border_Style_5;
            Control_Box_Out = Control_Box_6;
            State_Out = Window_State_2;
            Visible_Out = Visible_3;
            return this;
        }

        public n6.WindowState_TXbwxGLVQe9QXZeFcq3TYX __Create__(n1.NodeContext Node_Context)
        {
            n7.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n6.WindowState_TXbwxGLVQe9QXZeFcq3TYX __CreateDefault__()
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

        public WindowState_TXbwxGLVQe9QXZeFcq3TYX(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal WindowState_TXbwxGLVQe9QXZeFcq3TYX(WindowState_TXbwxGLVQe9QXZeFcq3TYX other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal WindowState_TXbwxGLVQe9QXZeFcq3TYX __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 44100U, DocumentId = "HylXxkKPeF0O6LWz4fSQKo", PersistentId = "NN7pI7FI1mWOUtJE7erhXK", Name = "SetWindowState_NN7pI7FI1mWOUtJE7erhXK")]
    [n2.SerializableAttribute]
    public class SetWindowState_NN7pI7FI1mWOUtJE7erhXK : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n6.SetWindowState_NN7pI7FI1mWOUtJE7erhXK Create(n1.NodeContext Node_Context)
        {
            var instance = new SetWindowState_NN7pI7FI1mWOUtJE7erhXK(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n6.SetWindowState_NN7pI7FI1mWOUtJE7erhXK CreateDefault()
        {
            var instance = new SetWindowState_NN7pI7FI1mWOUtJE7erhXK(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n6.SetWindowState_NN7pI7FI1mWOUtJE7erhXK Update(n10.Form Input_In, [n5.SerializedDefaultValueAttribute("Renderer", false)] string Caption_In, [n5.SerializedDefaultValueAttribute("Sizable", false)] n10.FormBorderStyle Border_Style_In, bool Control_Box_In, n10.FormWindowState State_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Visible_In, out n10.Form Output_Out)
        {
            n9.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            var state_2 = n1.CompilationHelper.Restore<__A8EanqGospJPRBsIHo2xEA>(this.__if_U4BHa2hVrMQPvSivNO2QG9, __GetContext__());
            if (Result_0)
            {
                if (state_2 == null)
                {
                    state_2 = new __A8EanqGospJPRBsIHo2xEA(__GetContext__(), n1.VLObject.NewIdentity());
                }

                bool Force_3 = false;
                bool Dispose_Cached_Outputs_4 = false;
                var manager_5 = state_2.__cache_NwM3PMsm02aOKCLsQvEwEJ;
                if (manager_5 is null)
                {
                    manager_5 = new n17.Manager<n2.ValueTuple<n10.Form, n10.FormBorderStyle>, n2.ValueTuple<n10.Form>>(n2.ValueTuple.Create(default(n10.Form)));
                }

                var inputs_6 = (Input_In, Border_Style_In);
                var outputs_7 = manager_5.Outputs;
                var Has_Changed_8 = Force_3 || manager_5.InputsChanged(inputs_6);
                if (Has_Changed_8)
                {
                    if (Dispose_Cached_Outputs_4)
                        manager_5.DisposeOutputs();
                    Input_In.FormBorderStyle = Border_Style_In;
                    outputs_7 = n2.ValueTuple.Create(Input_In);
                    manager_5 = manager_5.Update(inputs_6, __GetContext__().IsImmutable, Dispose_Cached_Outputs_4, default, outputs_7);
                }
                else
                {
                    manager_5.Update(inputs_6, __GetContext__().IsImmutable, Dispose_Cached_Outputs_4);
                }

                var __auto_10 = outputs_7.Item1;
                bool Force_11 = false;
                bool Dispose_Cached_Outputs_12 = false;
                var manager_13 = state_2.__cache_UVUrx2fND4qMrFHmOBXWsp;
                if (manager_13 is null)
                {
                    manager_13 = new n17.Manager<n2.ValueTuple<n10.Form, n10.FormWindowState>, n2.ValueTuple<n10.Form>>(n2.ValueTuple.Create(default(n10.Form)));
                }

                var inputs_14 = (__auto_10, State_In);
                var outputs_15 = manager_13.Outputs;
                var Has_Changed_16 = Force_11 || manager_13.InputsChanged(inputs_14);
                if (Has_Changed_16)
                {
                    if (Dispose_Cached_Outputs_12)
                        manager_13.DisposeOutputs();
                    __auto_10.WindowState = State_In;
                    outputs_15 = n2.ValueTuple.Create(__auto_10);
                    manager_13 = manager_13.Update(inputs_14, __GetContext__().IsImmutable, Dispose_Cached_Outputs_12, default, outputs_15);
                }
                else
                {
                    manager_13.Update(inputs_14, __GetContext__().IsImmutable, Dispose_Cached_Outputs_12);
                }

                var __auto_18 = outputs_15.Item1;
                bool Force_19 = false;
                bool Dispose_Cached_Outputs_20 = false;
                var manager_21 = state_2.__cache_TgUrDTKfx95PscGIJ8kC3t;
                if (manager_21 is null)
                {
                    manager_21 = new n17.Manager<n2.ValueTuple<n10.Form, string>, n2.ValueTuple<n10.Form>>(n2.ValueTuple.Create(default(n10.Form)));
                }

                var inputs_22 = (__auto_18, Caption_In);
                var outputs_23 = manager_21.Outputs;
                var Has_Changed_24 = Force_19 || manager_21.InputsChanged(inputs_22);
                if (Has_Changed_24)
                {
                    if (Dispose_Cached_Outputs_20)
                        manager_21.DisposeOutputs();
                    __auto_18.Text = Caption_In;
                    outputs_23 = n2.ValueTuple.Create(__auto_18);
                    manager_21 = manager_21.Update(inputs_22, __GetContext__().IsImmutable, Dispose_Cached_Outputs_20, default, outputs_23);
                }
                else
                {
                    manager_21.Update(inputs_22, __GetContext__().IsImmutable, Dispose_Cached_Outputs_20);
                }

                var __auto_26 = outputs_23.Item1;
                bool Force_27 = false;
                bool Dispose_Cached_Outputs_28 = false;
                var manager_29 = state_2.__cache_S8BFEpBiJDPMUH0PxpKDJr;
                if (manager_29 is null)
                {
                    manager_29 = new n17.Manager<n2.ValueTuple<n10.Form, bool>, n2.ValueTuple<n10.Form>>(n2.ValueTuple.Create(default(n10.Form)));
                }

                var inputs_30 = (__auto_26, Control_Box_In);
                var outputs_31 = manager_29.Outputs;
                var Has_Changed_32 = Force_27 || manager_29.InputsChanged(inputs_30);
                if (Has_Changed_32)
                {
                    if (Dispose_Cached_Outputs_28)
                        manager_29.DisposeOutputs();
                    __auto_26.ControlBox = Control_Box_In;
                    outputs_31 = n2.ValueTuple.Create(__auto_26);
                    manager_29 = manager_29.Update(inputs_30, __GetContext__().IsImmutable, Dispose_Cached_Outputs_28, default, outputs_31);
                }
                else
                {
                    manager_29.Update(inputs_30, __GetContext__().IsImmutable, Dispose_Cached_Outputs_28);
                }

                var __auto_34 = outputs_31.Item1;
                bool Force_35 = false;
                bool Dispose_Cached_Outputs_36 = false;
                var manager_37 = state_2.__cache_RE1AmFIB3pkLGDXOovnywU;
                if (manager_37 is null)
                {
                    manager_37 = new n17.Manager<n2.ValueTuple<n10.Form, bool>, n2.ValueTuple>(n2.ValueTuple.Create());
                }

                var inputs_38 = (__auto_34, Visible_In);
                var outputs_39 = manager_37.Outputs;
                var Has_Changed_40 = Force_35 || manager_37.InputsChanged(inputs_38);
                if (Has_Changed_40)
                {
                    if (Dispose_Cached_Outputs_36)
                        manager_37.DisposeOutputs();
                    __auto_34.Visible = Visible_In;
                    outputs_39 = n2.ValueTuple.Create();
                    manager_37 = manager_37.Update(inputs_38, __GetContext__().IsImmutable, Dispose_Cached_Outputs_36, default, outputs_39);
                }
                else
                {
                    manager_37.Update(inputs_38, __GetContext__().IsImmutable, Dispose_Cached_Outputs_36);
                }

                if (state_2.__GetContext__().IsImmutable)
                    state_2 = manager_5 != state_2.__cache_NwM3PMsm02aOKCLsQvEwEJ || manager_13 != state_2.__cache_UVUrx2fND4qMrFHmOBXWsp || manager_21 != state_2.__cache_TgUrDTKfx95PscGIJ8kC3t || manager_29 != state_2.__cache_S8BFEpBiJDPMUH0PxpKDJr || manager_37 != state_2.__cache_RE1AmFIB3pkLGDXOovnywU ? new __A8EanqGospJPRBsIHo2xEA(state_2)
                    {__cache_NwM3PMsm02aOKCLsQvEwEJ = manager_5, __cache_UVUrx2fND4qMrFHmOBXWsp = manager_13, __cache_TgUrDTKfx95PscGIJ8kC3t = manager_21, __cache_S8BFEpBiJDPMUH0PxpKDJr = manager_29, __cache_RE1AmFIB3pkLGDXOovnywU = manager_37} : state_2;
                else
                {
                    state_2.__cache_NwM3PMsm02aOKCLsQvEwEJ = manager_5;
                    state_2.__cache_UVUrx2fND4qMrFHmOBXWsp = manager_13;
                    state_2.__cache_TgUrDTKfx95PscGIJ8kC3t = manager_21;
                    state_2.__cache_S8BFEpBiJDPMUH0PxpKDJr = manager_29;
                    state_2.__cache_RE1AmFIB3pkLGDXOovnywU = manager_37;
                }
            }

            Output_Out = Input_In;
            n6.SetWindowState_NN7pI7FI1mWOUtJE7erhXK that_42 = this;
            if (this.__GetContext__().IsImmutable)
                that_42 = state_2 != this.__if_U4BHa2hVrMQPvSivNO2QG9 ? new SetWindowState_NN7pI7FI1mWOUtJE7erhXK(this)
                {__if_U4BHa2hVrMQPvSivNO2QG9 = state_2} : that_42;
            else
            {
                this.__if_U4BHa2hVrMQPvSivNO2QG9 = state_2;
            }

            return that_42;
        }

        public n6.SetWindowState_NN7pI7FI1mWOUtJE7erhXK __Create__(n1.NodeContext Node_Context)
        {
            n7.RuntimeHelpers.EnsureSufficientExecutionStack();
            n6.SetWindowState_NN7pI7FI1mWOUtJE7erhXK that_0 = this;
            this.__if_U4BHa2hVrMQPvSivNO2QG9 = default(n2.Object);
            return that_0;
        }

        public n6.SetWindowState_NN7pI7FI1mWOUtJE7erhXK __CreateDefault__()
        {
            n6.SetWindowState_NN7pI7FI1mWOUtJE7erhXK that_0 = this;
            this.__if_U4BHa2hVrMQPvSivNO2QG9 = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_U4BHa2hVrMQPvSivNO2QG9);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_U4BHa2hVrMQPvSivNO2QG9;
        public SetWindowState_NN7pI7FI1mWOUtJE7erhXK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SetWindowState_NN7pI7FI1mWOUtJE7erhXK(SetWindowState_NN7pI7FI1mWOUtJE7erhXK other): base(other)
        {
            this.__if_U4BHa2hVrMQPvSivNO2QG9 = other.__if_U4BHa2hVrMQPvSivNO2QG9;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_U4BHa2hVrMQPvSivNO2QG9", in __if_U4BHa2hVrMQPvSivNO2QG9));
        }

        internal SetWindowState_NN7pI7FI1mWOUtJE7erhXK __WITH__(n2.Object __if_U4BHa2hVrMQPvSivNO2QG9)
        {
            n6.SetWindowState_NN7pI7FI1mWOUtJE7erhXK that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_U4BHa2hVrMQPvSivNO2QG9 != this.__if_U4BHa2hVrMQPvSivNO2QG9 ? new SetWindowState_NN7pI7FI1mWOUtJE7erhXK(this)
                {__if_U4BHa2hVrMQPvSivNO2QG9 = __if_U4BHa2hVrMQPvSivNO2QG9} : that_0;
            else
            {
                this.__if_U4BHa2hVrMQPvSivNO2QG9 = __if_U4BHa2hVrMQPvSivNO2QG9;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "HylXxkKPeF0O6LWz4fSQKo", PersistentId = "A8EanqGospJPRBsIHo2xEA", Name = "__A8EanqGospJPRBsIHo2xEA")]
        [n2.SerializableAttribute]
        public class __A8EanqGospJPRBsIHo2xEA : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__cache_NwM3PMsm02aOKCLsQvEwEJ);
                n1.CompilationHelper.SafeDispose(this.__cache_UVUrx2fND4qMrFHmOBXWsp);
                n1.CompilationHelper.SafeDispose(this.__cache_TgUrDTKfx95PscGIJ8kC3t);
                n1.CompilationHelper.SafeDispose(this.__cache_S8BFEpBiJDPMUH0PxpKDJr);
                n1.CompilationHelper.SafeDispose(this.__cache_RE1AmFIB3pkLGDXOovnywU);
                return;
            }

            [n1.ElementAttribute(TracingId = 44130U, DocumentId = "HylXxkKPeF0O6LWz4fSQKo", PersistentId = "NwM3PMsm02aOKCLsQvEwEJ", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n17.Manager<n2.ValueTuple<n10.Form, n10.FormBorderStyle>, n2.ValueTuple<n10.Form>> __cache_NwM3PMsm02aOKCLsQvEwEJ = null;
            [n1.ElementAttribute(TracingId = 44188U, DocumentId = "HylXxkKPeF0O6LWz4fSQKo", PersistentId = "UVUrx2fND4qMrFHmOBXWsp", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n17.Manager<n2.ValueTuple<n10.Form, n10.FormWindowState>, n2.ValueTuple<n10.Form>> __cache_UVUrx2fND4qMrFHmOBXWsp = null;
            [n1.ElementAttribute(TracingId = 44248U, DocumentId = "HylXxkKPeF0O6LWz4fSQKo", PersistentId = "TgUrDTKfx95PscGIJ8kC3t", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n17.Manager<n2.ValueTuple<n10.Form, string>, n2.ValueTuple<n10.Form>> __cache_TgUrDTKfx95PscGIJ8kC3t = null;
            [n1.ElementAttribute(TracingId = 44337U, DocumentId = "HylXxkKPeF0O6LWz4fSQKo", PersistentId = "S8BFEpBiJDPMUH0PxpKDJr", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n17.Manager<n2.ValueTuple<n10.Form, bool>, n2.ValueTuple<n10.Form>> __cache_S8BFEpBiJDPMUH0PxpKDJr = null;
            [n1.ElementAttribute(TracingId = 44303U, DocumentId = "HylXxkKPeF0O6LWz4fSQKo", PersistentId = "RE1AmFIB3pkLGDXOovnywU", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n17.Manager<n2.ValueTuple<n10.Form, bool>, n2.ValueTuple> __cache_RE1AmFIB3pkLGDXOovnywU = null;
            public __A8EanqGospJPRBsIHo2xEA(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __A8EanqGospJPRBsIHo2xEA(__A8EanqGospJPRBsIHo2xEA other): base(other)
            {
                this.__cache_NwM3PMsm02aOKCLsQvEwEJ = other.__cache_NwM3PMsm02aOKCLsQvEwEJ;
                this.__cache_UVUrx2fND4qMrFHmOBXWsp = other.__cache_UVUrx2fND4qMrFHmOBXWsp;
                this.__cache_TgUrDTKfx95PscGIJ8kC3t = other.__cache_TgUrDTKfx95PscGIJ8kC3t;
                this.__cache_S8BFEpBiJDPMUH0PxpKDJr = other.__cache_S8BFEpBiJDPMUH0PxpKDJr;
                this.__cache_RE1AmFIB3pkLGDXOovnywU = other.__cache_RE1AmFIB3pkLGDXOovnywU;
            }

            protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_NwM3PMsm02aOKCLsQvEwEJ", in __cache_NwM3PMsm02aOKCLsQvEwEJ), n1.CompilationHelper.GetValueOrExisting(values, "__cache_UVUrx2fND4qMrFHmOBXWsp", in __cache_UVUrx2fND4qMrFHmOBXWsp), n1.CompilationHelper.GetValueOrExisting(values, "__cache_TgUrDTKfx95PscGIJ8kC3t", in __cache_TgUrDTKfx95PscGIJ8kC3t), n1.CompilationHelper.GetValueOrExisting(values, "__cache_S8BFEpBiJDPMUH0PxpKDJr", in __cache_S8BFEpBiJDPMUH0PxpKDJr), n1.CompilationHelper.GetValueOrExisting(values, "__cache_RE1AmFIB3pkLGDXOovnywU", in __cache_RE1AmFIB3pkLGDXOovnywU));
            }

            internal __A8EanqGospJPRBsIHo2xEA __WITH__(n17.Manager<n2.ValueTuple<n10.Form, n10.FormBorderStyle>, n2.ValueTuple<n10.Form>> __cache_NwM3PMsm02aOKCLsQvEwEJ, n17.Manager<n2.ValueTuple<n10.Form, n10.FormWindowState>, n2.ValueTuple<n10.Form>> __cache_UVUrx2fND4qMrFHmOBXWsp, n17.Manager<n2.ValueTuple<n10.Form, string>, n2.ValueTuple<n10.Form>> __cache_TgUrDTKfx95PscGIJ8kC3t, n17.Manager<n2.ValueTuple<n10.Form, bool>, n2.ValueTuple<n10.Form>> __cache_S8BFEpBiJDPMUH0PxpKDJr, n17.Manager<n2.ValueTuple<n10.Form, bool>, n2.ValueTuple> __cache_RE1AmFIB3pkLGDXOovnywU)
            {
                __A8EanqGospJPRBsIHo2xEA that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cache_NwM3PMsm02aOKCLsQvEwEJ != this.__cache_NwM3PMsm02aOKCLsQvEwEJ || __cache_UVUrx2fND4qMrFHmOBXWsp != this.__cache_UVUrx2fND4qMrFHmOBXWsp || __cache_TgUrDTKfx95PscGIJ8kC3t != this.__cache_TgUrDTKfx95PscGIJ8kC3t || __cache_S8BFEpBiJDPMUH0PxpKDJr != this.__cache_S8BFEpBiJDPMUH0PxpKDJr || __cache_RE1AmFIB3pkLGDXOovnywU != this.__cache_RE1AmFIB3pkLGDXOovnywU ? new __A8EanqGospJPRBsIHo2xEA(this)
                    {__cache_NwM3PMsm02aOKCLsQvEwEJ = __cache_NwM3PMsm02aOKCLsQvEwEJ, __cache_UVUrx2fND4qMrFHmOBXWsp = __cache_UVUrx2fND4qMrFHmOBXWsp, __cache_TgUrDTKfx95PscGIJ8kC3t = __cache_TgUrDTKfx95PscGIJ8kC3t, __cache_S8BFEpBiJDPMUH0PxpKDJr = __cache_S8BFEpBiJDPMUH0PxpKDJr, __cache_RE1AmFIB3pkLGDXOovnywU = __cache_RE1AmFIB3pkLGDXOovnywU} : that_0;
                else
                {
                    this.__cache_NwM3PMsm02aOKCLsQvEwEJ = __cache_NwM3PMsm02aOKCLsQvEwEJ;
                    this.__cache_UVUrx2fND4qMrFHmOBXWsp = __cache_UVUrx2fND4qMrFHmOBXWsp;
                    this.__cache_TgUrDTKfx95PscGIJ8kC3t = __cache_TgUrDTKfx95PscGIJ8kC3t;
                    this.__cache_S8BFEpBiJDPMUH0PxpKDJr = __cache_S8BFEpBiJDPMUH0PxpKDJr;
                    this.__cache_RE1AmFIB3pkLGDXOovnywU = __cache_RE1AmFIB3pkLGDXOovnywU;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 44516U, DocumentId = "HylXxkKPeF0O6LWz4fSQKo", PersistentId = "AMQAfEPV6P2OO4P09IyY5H", Name = "SetWindowMode_AMQAfEPV6P2OO4P09IyY5H")]
    [n2.SerializableAttribute]
    public class SetWindowMode_AMQAfEPV6P2OO4P09IyY5H : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n6.SetWindowMode_AMQAfEPV6P2OO4P09IyY5H Create(n1.NodeContext Node_Context)
        {
            var instance = new SetWindowMode_AMQAfEPV6P2OO4P09IyY5H(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n6.SetWindowMode_AMQAfEPV6P2OO4P09IyY5H CreateDefault()
        {
            var instance = new SetWindowMode_AMQAfEPV6P2OO4P09IyY5H(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n6.SetWindowMode_AMQAfEPV6P2OO4P09IyY5H Update(n10.Form Input_In, [n5.SerializedDefaultValueAttribute("False", false)] bool Hide_In, [n5.SerializedDefaultValueAttribute("False", false)] bool Windowed_In, [n5.SerializedDefaultValueAttribute("False", false)] bool Fullscreen_In, out n10.Form Output_Out)
        {
            n9.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            var Output_4 = this.__p_CLzuQlGLmqZPpM8nyXNQsd.Update(Value_In: Hide_In, Up_Edge_Out: out bool Up_Edge_2, Down_Edge_Out: out bool Down_Edge_3);
            var Output_5 = Result_0 && Up_Edge_2;
            if (Output_5)
            {
                bool Value_7 = false;
                Input_In.Visible = Value_7;
            }

            var Output_10 = this.__p_EQ3KXZ8RHaPMwIccSqKhg1.Update(Value_In: Fullscreen_In, Up_Edge_Out: out bool Up_Edge_8, Down_Edge_Out: out bool Down_Edge_9);
            var Output_11 = Result_0 && Up_Edge_8;
            if (Output_11)
            {
                Input_In.SuspendLayout();
                bool Value_13 = true;
                Input_In.Visible = Value_13;
                n10.Form Default_14 = default(n10.Form);
                n18._Operations_.CastAs<n10.Form>(Input_In: Input_In, Default_In: Default_14, Result_Out: out n10.Form Result_15, Success_Out: out bool Success_16);
                n10.FormWindowState Value_17 = __c_BRqtHdK6OO1PGywAzkrDoz;
                Result_15.WindowState = Value_17;
                n10.FormBorderStyle Value_18 = default(n10.FormBorderStyle);
                Result_15.FormBorderStyle = Value_18;
                Result_15.ResumeLayout();
            }

            var Output_21 = this.__p_P3ibP9sQZc8O3fDal6XLX1.Update(Value_In: Windowed_In, Up_Edge_Out: out bool Up_Edge_19, Down_Edge_Out: out bool Down_Edge_20);
            var Output_22 = Result_0 && Up_Edge_19;
            if (Output_22)
            {
                Input_In.SuspendLayout();
                bool Value_24 = true;
                Input_In.Visible = Value_24;
                n10.Form Default_25 = default(n10.Form);
                n18._Operations_.CastAs<n10.Form>(Input_In: Input_In, Default_In: Default_25, Result_Out: out n10.Form Result_26, Success_Out: out bool Success_27);
                n10.FormBorderStyle Value_28 = __c_Jv48TpAjIjmMWqpiP3uYQ5;
                Result_26.FormBorderStyle = Value_28;
                n10.FormWindowState Value_29 = default(n10.FormWindowState);
                Result_26.WindowState = Value_29;
                Result_26.ResumeLayout();
            }

            bool Apply_30 = false;
            var Output_31 = Input_In;
            if (Apply_30)
            {
                Input_In.Activate();
            }

            Output_Out = Input_In;
            n6.SetWindowMode_AMQAfEPV6P2OO4P09IyY5H that_32 = this;
            if (this.__GetContext__().IsImmutable)
                that_32 = Output_4 != this.__p_CLzuQlGLmqZPpM8nyXNQsd || Output_10 != this.__p_EQ3KXZ8RHaPMwIccSqKhg1 || Output_21 != this.__p_P3ibP9sQZc8O3fDal6XLX1 ? new SetWindowMode_AMQAfEPV6P2OO4P09IyY5H(this)
                {__p_CLzuQlGLmqZPpM8nyXNQsd = Output_4, __p_EQ3KXZ8RHaPMwIccSqKhg1 = Output_10, __p_P3ibP9sQZc8O3fDal6XLX1 = Output_21} : that_32;
            else
            {
                this.__p_CLzuQlGLmqZPpM8nyXNQsd = Output_4;
                this.__p_EQ3KXZ8RHaPMwIccSqKhg1 = Output_10;
                this.__p_P3ibP9sQZc8O3fDal6XLX1 = Output_21;
            }

            return that_32;
        }

        public n6.SetWindowMode_AMQAfEPV6P2OO4P09IyY5H __Create__(n1.NodeContext Node_Context)
        {
            n7.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("HylXxkKPeF0O6LWz4fSQKo", "CLzuQlGLmqZPpM8nyXNQsd", 44570U);
            var Output_1 = n19.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("HylXxkKPeF0O6LWz4fSQKo", "EQ3KXZ8RHaPMwIccSqKhg1", 44697U);
            var Output_3 = n19.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("HylXxkKPeF0O6LWz4fSQKo", "P3ibP9sQZc8O3fDal6XLX1", 44789U);
            var Output_5 = n19.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_4);
            n6.SetWindowMode_AMQAfEPV6P2OO4P09IyY5H that_6 = this;
            this.__p_CLzuQlGLmqZPpM8nyXNQsd = Output_1;
            this.__p_EQ3KXZ8RHaPMwIccSqKhg1 = Output_3;
            this.__p_P3ibP9sQZc8O3fDal6XLX1 = Output_5;
            return that_6;
        }

        public n6.SetWindowMode_AMQAfEPV6P2OO4P09IyY5H __CreateDefault__()
        {
            n6.SetWindowMode_AMQAfEPV6P2OO4P09IyY5H that_0 = this;
            this.__p_CLzuQlGLmqZPpM8nyXNQsd = n19.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_EQ3KXZ8RHaPMwIccSqKhg1 = n19.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_P3ibP9sQZc8O3fDal6XLX1 = n19.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_CLzuQlGLmqZPpM8nyXNQsd);
            n1.CompilationHelper.SafeDispose(this.__p_EQ3KXZ8RHaPMwIccSqKhg1);
            n1.CompilationHelper.SafeDispose(this.__p_P3ibP9sQZc8O3fDal6XLX1);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 44570U, DocumentId = "HylXxkKPeF0O6LWz4fSQKo", PersistentId = "CLzuQlGLmqZPpM8nyXNQsd", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n19.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CLzuQlGLmqZPpM8nyXNQsd;
        [n1.ElementAttribute(TracingId = 44697U, DocumentId = "HylXxkKPeF0O6LWz4fSQKo", PersistentId = "EQ3KXZ8RHaPMwIccSqKhg1", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n19.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_EQ3KXZ8RHaPMwIccSqKhg1;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n10.FormWindowState __c_BRqtHdK6OO1PGywAzkrDoz = n1.CompilationHelper.Deserialize<n10.FormWindowState>("Maximized", false, "HylXxkKPeF0O6LWz4fSQKo", "BRqtHdK6OO1PGywAzkrDoz");
        [n1.ElementAttribute(TracingId = 44789U, DocumentId = "HylXxkKPeF0O6LWz4fSQKo", PersistentId = "P3ibP9sQZc8O3fDal6XLX1", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n19.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_P3ibP9sQZc8O3fDal6XLX1;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n10.FormBorderStyle __c_Jv48TpAjIjmMWqpiP3uYQ5 = n1.CompilationHelper.Deserialize<n10.FormBorderStyle>("SizableToolWindow", false, "HylXxkKPeF0O6LWz4fSQKo", "Jv48TpAjIjmMWqpiP3uYQ5");
        static SetWindowMode_AMQAfEPV6P2OO4P09IyY5H()
        {
        }

        public SetWindowMode_AMQAfEPV6P2OO4P09IyY5H(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SetWindowMode_AMQAfEPV6P2OO4P09IyY5H(SetWindowMode_AMQAfEPV6P2OO4P09IyY5H other): base(other)
        {
            this.__p_CLzuQlGLmqZPpM8nyXNQsd = other.__p_CLzuQlGLmqZPpM8nyXNQsd;
            this.__p_EQ3KXZ8RHaPMwIccSqKhg1 = other.__p_EQ3KXZ8RHaPMwIccSqKhg1;
            this.__p_P3ibP9sQZc8O3fDal6XLX1 = other.__p_P3ibP9sQZc8O3fDal6XLX1;
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_CLzuQlGLmqZPpM8nyXNQsd", in __p_CLzuQlGLmqZPpM8nyXNQsd), n1.CompilationHelper.GetValueOrExisting(values, "__p_EQ3KXZ8RHaPMwIccSqKhg1", in __p_EQ3KXZ8RHaPMwIccSqKhg1), n1.CompilationHelper.GetValueOrExisting(values, "__p_P3ibP9sQZc8O3fDal6XLX1", in __p_P3ibP9sQZc8O3fDal6XLX1));
        }

        internal SetWindowMode_AMQAfEPV6P2OO4P09IyY5H __WITH__(n19.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CLzuQlGLmqZPpM8nyXNQsd, n19.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_EQ3KXZ8RHaPMwIccSqKhg1, n19.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_P3ibP9sQZc8O3fDal6XLX1)
        {
            n6.SetWindowMode_AMQAfEPV6P2OO4P09IyY5H that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_CLzuQlGLmqZPpM8nyXNQsd != this.__p_CLzuQlGLmqZPpM8nyXNQsd || __p_EQ3KXZ8RHaPMwIccSqKhg1 != this.__p_EQ3KXZ8RHaPMwIccSqKhg1 || __p_P3ibP9sQZc8O3fDal6XLX1 != this.__p_P3ibP9sQZc8O3fDal6XLX1 ? new SetWindowMode_AMQAfEPV6P2OO4P09IyY5H(this)
                {__p_CLzuQlGLmqZPpM8nyXNQsd = __p_CLzuQlGLmqZPpM8nyXNQsd, __p_EQ3KXZ8RHaPMwIccSqKhg1 = __p_EQ3KXZ8RHaPMwIccSqKhg1, __p_P3ibP9sQZc8O3fDal6XLX1 = __p_P3ibP9sQZc8O3fDal6XLX1} : that_0;
            else
            {
                this.__p_CLzuQlGLmqZPpM8nyXNQsd = __p_CLzuQlGLmqZPpM8nyXNQsd;
                this.__p_EQ3KXZ8RHaPMwIccSqKhg1 = __p_EQ3KXZ8RHaPMwIccSqKhg1;
                this.__p_P3ibP9sQZc8O3fDal6XLX1 = __p_P3ibP9sQZc8O3fDal6XLX1;
            }

            return that_0;
        }
    }
}

namespace _VL_CoreLib_Windows_.System.Windows.Advanced
{
    [n1.ElementAttribute(TracingId = 43824U, DocumentId = "HylXxkKPeF0O6LWz4fSQKo", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void FindWindow(string Class_Name_In, string Window_Title_In, out n2.IntPtr Result_Out)
        {
            var Result_0 = n3.User32.FindWindow(lpClassName: Class_Name_In, lpWindowName: Window_Title_In);
            Result_Out = Result_0;
            return;
        }

        public static void Rectangle_Split(n8.Rectangle Input_In, out int Left_Out, out int Top_Out, out int Width_Out, out int Height_Out)
        {
            var Left_0 = Input_In.Left;
            var Top_1 = Input_In.Top;
            var Width_2 = Input_In.Width;
            var Height_3 = Input_In.Height;
            Left_Out = Left_0;
            Top_Out = Top_1;
            Width_Out = Width_2;
            Height_Out = Height_3;
            return;
        }

        public static void FromWinFormsRectangle(n8.Rectangle Input_In, out n15.RectangleF Output_Out)
        {
            n11._Operations_.Rectangle_Split(Input_In: Input_In, Left_Out: out int Left_0, Top_Out: out int Top_1, Width_Out: out int Width_2, Height_Out: out int Height_3);
            float Position_X_4 = (float)Left_0;
            float Position_Y_5 = (float)Top_1;
            float Width_6 = (float)Width_2;
            float Height_7 = (float)Height_3;
            n13.RectangleAnchor Anchor_8 = n12._Operations_.CreateDefault();
            n13.RectangleNodes.JoinComponentwise(positionX: Position_X_4, positionY: Position_Y_5, width: Width_6, height: Height_7, anchor: Anchor_8, output: out n15.RectangleF Output_9);
            Output_Out = Output_9;
            return;
        }

        public static void ToWinFormsRectangle(n15.RectangleF Input_In, out n8.Rectangle Output_Out)
        {
            n13.RectangleAnchor Anchor_0 = n12._Operations_.CreateDefault();
            n13.RectangleNodes.Split(input: ref Input_In, anchor: Anchor_0, position: out n15.Vector2 Position_1, size: out n15.Vector2 Size_2);
            n13.Vector2Nodes.Vector(input: ref Position_1, x: out float X_3, y: out float Y_4);
            var Result_5 = n16.Float32Extensions.Round(input: X_3);
            var Result_6 = n16.Float32Extensions.Round(input: Y_4);
            n13.Vector2Nodes.Vector(input: ref Size_2, x: out float X_7, y: out float Y_8);
            var Result_9 = n16.Float32Extensions.Round(input: X_7);
            var Result_10 = n16.Float32Extensions.Round(input: Y_8);
            var Output_11 = new n8.Rectangle(x: Result_5, y: Result_6, width: Result_9, height: Result_10);
            Output_Out = Output_11;
            return;
        }
    }
}

namespace _VL_CoreLib_Windows_
{
    [n1.ElementAttribute(TracingId = 48467U, DocumentId = "HylXxkKPeF0O6LWz4fSQKo", PersistentId = "V0lbEGih4KhP8dFotKJ54C", Name = "VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C")]
    [n2.SerializableAttribute]
    public class VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C CreateDefault()
        {
            var instance = new VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C Update()
        {
            return this;
        }

        public n4.VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C __Create__(n1.NodeContext Node_Context)
        {
            n7.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n4.VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C __CreateDefault__()
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

        public VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C(VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_CoreLib_WindowsApplication_V0lbEGih4KhP8dFotKJ54C __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_CoreLib_Windows_
{
    public struct __AdaptiveImplementations__HylXxkKPeF0O6LWz4fSQKo
    {
    }
}