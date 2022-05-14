extern alias e9;
extern alias e2;
extern alias e5;
extern alias e1;

using n10 = _CoreLibBasics_._3D.Matrix;
using n15 = _CoreLibBasics_.Control.Advanced;
using n29 = _CoreLibBasics_.Animation.FrameBased;
using n36 = e2::VL.Lib.Primitive;
using n20 = _VL_Cameras_.Editors._3D.Experimental;
using n16 = _CoreLibBasics_.Control;
using n12 = _VL_Cameras_;
using n19 = global::System.Collections.Immutable;
using n35 = _CoreLibBasics_.Math.Generic.Advanced;
using n26 = _CoreLibBasics_._3D.Transform;
using n14 = e2::VL.Lib.Mathematics;
using n30 = _CoreLibBasics_.Animation.IClock.Advanced;
using n31 = e5::VL.Lib.Animation;
using n4 = e5::VL.Core.CompilerServices;
using n11 = _CoreLibBasics_._2D.Transform;
using n32 = _CoreLibBasics_.Animation.IFrameClock.Advanced;
using n9 = global::System.Collections.Generic;
using n17 = _CoreLibBasics_._2D.Vector2;
using n6 = e1::Stride.Core.Mathematics;
using n37 = _CoreLibBasics_.Math.Adaptive;
using n38 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n33 = _CoreLibBasics_.Animation;
using n13 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n25 = _VL_Skia_.IO.Keyboard;
using n1 = e5::VL.Core;
using n27 = _VL_Cameras_.Editors;
using n22 = _CoreLibBasics_.IO.Mouse.MouseDevice.Advanced;
using n7 = e9::VL.Lib.IO;
using n23 = _CoreLibBasics_.IO.Keyboard.KeyboardDevice.Advanced;
using n2 = global::System;
using n3 = _VL_Cameras_.Editors._2D;
using n18 = global::System.Windows.Forms;
using n5 = _VL_Cameras_.Editors._2D.Advanced;
using n21 = _VL_Cameras_.Editors._3D.Advanced.Experimental;
using n8 = global::System.Runtime.CompilerServices;
using n24 = _VL_Skia_.IO.Mouse;
using n34 = _CoreLibBasics_.Primitive.Advanced;
using n28 = _CoreLibBasics_._3D.Vector3;

namespace _VL_Cameras_.Editors._2D
{
    [n1.ElementAttribute(TracingId = 55064U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "GadqeOmYZGTMzLKYmkE26a", Name = "Camera_Flat_GadqeOmYZGTMzLKYmkE26a")]
    [n2.SerializableAttribute]
    public class Camera_Flat_GadqeOmYZGTMzLKYmkE26a : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Camera_Flat_GadqeOmYZGTMzLKYmkE26a Create(n1.NodeContext Node_Context)
        {
            var instance = new Camera_Flat_GadqeOmYZGTMzLKYmkE26a(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Camera_Flat_GadqeOmYZGTMzLKYmkE26a CreateDefault()
        {
            var instance = new Camera_Flat_GadqeOmYZGTMzLKYmkE26a(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Camera_Flat_GadqeOmYZGTMzLKYmkE26a Update(n6.Vector2 Initial_Translate_In, [n4.SerializedDefaultValueAttribute("1", false)] float Initial_Zoom_In, n7.IMouse Mouse_Device_In, n7.IKeyboard Keyboard_Device_In, [n4.SerializedDefaultValueAttribute("1", false)] float Zoom_Speed_In, float Minimum_Zoom_In, [n4.SerializedDefaultValueAttribute("4", false)] float Maximum_Zoom_In, bool Reset_In, out n5.CameraState_R CameraState2d_Out, out bool Idle_Out)
        {
            bool __pad_VM68IntDTt8O64aQOSFJC8_0 = __slot_VM68IntDTt8O64aQOSFJC8;
            n5.CameraControls_R CameraControls2d_1 = n5.CameraControls_R.CreateDefault();
            var Output_3 = this.__p_E33vmiOhGCbMp3xslC6VxR.Join(CameraControls2d_In: CameraControls2d_1, Mouse_Device_In: Mouse_Device_In, Keyboard_Device_In: Keyboard_Device_In, Zoom_Speed_In: Zoom_Speed_In, Enabled_In: __pad_VM68IntDTt8O64aQOSFJC8_0, Camera_Controls_Out: out n5.CameraControls_R Camera_Controls_2);
            bool Renderer_Hovered_4 = false;
            var Output_6 = this.__p_IPspk1vRq3ALWDApHdrTrp.Update(Initial_Interest_In: Initial_Translate_In, Initial_Zoom_In: Initial_Zoom_In, Minimum_Zoom_In: Minimum_Zoom_In, Maximum_Zoom_In: Maximum_Zoom_In, Camera_Controls_In: Camera_Controls_2, Renderer_Hovered_In: Renderer_Hovered_4, Reset_In: Reset_In, CameraState2d_Out: out n5.CameraState_R CameraState2d_5);
            CameraState2d_Out = CameraState2d_5;
            Idle_Out = __pad_VM68IntDTt8O64aQOSFJC8_0;
            n3.Camera_Flat_GadqeOmYZGTMzLKYmkE26a that_7 = this;
            if (this.__GetContext__().IsImmutable)
                that_7 = Output_3 != this.__p_E33vmiOhGCbMp3xslC6VxR || Output_6 != this.__p_IPspk1vRq3ALWDApHdrTrp ? new Camera_Flat_GadqeOmYZGTMzLKYmkE26a(this)
                {__p_E33vmiOhGCbMp3xslC6VxR = Output_3, __p_IPspk1vRq3ALWDApHdrTrp = Output_6} : that_7;
            else
            {
                this.__p_E33vmiOhGCbMp3xslC6VxR = Output_3;
                this.__p_IPspk1vRq3ALWDApHdrTrp = Output_6;
            }

            return that_7;
        }

        public n3.Camera_Flat_GadqeOmYZGTMzLKYmkE26a __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "IPspk1vRq3ALWDApHdrTrp", 55072U);
            var Output_1 = n5.Camera_LFaaf0fqmTzNy23KpgvNno.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "E33vmiOhGCbMp3xslC6VxR", 55145U);
            var Output_3 = n5.FlatCameraControls_A4gAuKiKvazMyBQuk926iQ.Create(Node_Context: Node_Context_2);
            n3.Camera_Flat_GadqeOmYZGTMzLKYmkE26a that_4 = this;
            this.__p_IPspk1vRq3ALWDApHdrTrp = Output_1;
            this.__p_E33vmiOhGCbMp3xslC6VxR = Output_3;
            return that_4;
        }

        public n3.Camera_Flat_GadqeOmYZGTMzLKYmkE26a __CreateDefault__()
        {
            n3.Camera_Flat_GadqeOmYZGTMzLKYmkE26a that_0 = this;
            this.__p_E33vmiOhGCbMp3xslC6VxR = n5.FlatCameraControls_A4gAuKiKvazMyBQuk926iQ.CreateDefault();
            this.__p_IPspk1vRq3ALWDApHdrTrp = n5.Camera_LFaaf0fqmTzNy23KpgvNno.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_E33vmiOhGCbMp3xslC6VxR);
            n1.CompilationHelper.SafeDispose(this.__p_IPspk1vRq3ALWDApHdrTrp);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 55140U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "VM68IntDTt8O64aQOSFJC8", Name = "__slot_VM68IntDTt8O64aQOSFJC8")]
        public static bool __slot_VM68IntDTt8O64aQOSFJC8 = true;
        [n1.ElementAttribute(TracingId = 55145U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "E33vmiOhGCbMp3xslC6VxR", Name = "FlatCameraControls", IsManaged = true, IsAutoGenerated = true)]
        public n5.FlatCameraControls_A4gAuKiKvazMyBQuk926iQ __p_E33vmiOhGCbMp3xslC6VxR;
        [n1.ElementAttribute(TracingId = 55072U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "IPspk1vRq3ALWDApHdrTrp", Name = "Camera", IsManaged = true, IsAutoGenerated = true)]
        public n5.Camera_LFaaf0fqmTzNy23KpgvNno __p_IPspk1vRq3ALWDApHdrTrp;
        static Camera_Flat_GadqeOmYZGTMzLKYmkE26a()
        {
        }

        public Camera_Flat_GadqeOmYZGTMzLKYmkE26a(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Camera_Flat_GadqeOmYZGTMzLKYmkE26a(Camera_Flat_GadqeOmYZGTMzLKYmkE26a other): base(other)
        {
            this.__p_E33vmiOhGCbMp3xslC6VxR = other.__p_E33vmiOhGCbMp3xslC6VxR;
            this.__p_IPspk1vRq3ALWDApHdrTrp = other.__p_IPspk1vRq3ALWDApHdrTrp;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_E33vmiOhGCbMp3xslC6VxR", in __p_E33vmiOhGCbMp3xslC6VxR), n1.CompilationHelper.GetValueOrExisting(values, "__p_IPspk1vRq3ALWDApHdrTrp", in __p_IPspk1vRq3ALWDApHdrTrp));
        }

        internal Camera_Flat_GadqeOmYZGTMzLKYmkE26a __WITH__(n5.FlatCameraControls_A4gAuKiKvazMyBQuk926iQ __p_E33vmiOhGCbMp3xslC6VxR, n5.Camera_LFaaf0fqmTzNy23KpgvNno __p_IPspk1vRq3ALWDApHdrTrp)
        {
            n3.Camera_Flat_GadqeOmYZGTMzLKYmkE26a that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_E33vmiOhGCbMp3xslC6VxR != this.__p_E33vmiOhGCbMp3xslC6VxR || __p_IPspk1vRq3ALWDApHdrTrp != this.__p_IPspk1vRq3ALWDApHdrTrp ? new Camera_Flat_GadqeOmYZGTMzLKYmkE26a(this)
                {__p_E33vmiOhGCbMp3xslC6VxR = __p_E33vmiOhGCbMp3xslC6VxR, __p_IPspk1vRq3ALWDApHdrTrp = __p_IPspk1vRq3ALWDApHdrTrp} : that_0;
            else
            {
                this.__p_E33vmiOhGCbMp3xslC6VxR = __p_E33vmiOhGCbMp3xslC6VxR;
                this.__p_IPspk1vRq3ALWDApHdrTrp = __p_IPspk1vRq3ALWDApHdrTrp;
            }

            return that_0;
        }
    }
}

namespace _VL_Cameras_.Editors._2D.Advanced
{
    [n1.ElementAttribute(TracingId = 55266U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "LFaaf0fqmTzNy23KpgvNno", Name = "Camera_LFaaf0fqmTzNy23KpgvNno")]
    [n2.SerializableAttribute]
    public class Camera_LFaaf0fqmTzNy23KpgvNno : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n5.Camera_LFaaf0fqmTzNy23KpgvNno Create(n1.NodeContext Node_Context)
        {
            var instance = new Camera_LFaaf0fqmTzNy23KpgvNno(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n5.Camera_LFaaf0fqmTzNy23KpgvNno CreateDefault()
        {
            var instance = new Camera_LFaaf0fqmTzNy23KpgvNno(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.Camera_LFaaf0fqmTzNy23KpgvNno Update(n6.Vector2 Initial_Interest_In, float Initial_Zoom_In, float Minimum_Zoom_In, [n4.SerializedDefaultValueAttribute("4", false)] float Maximum_Zoom_In, n5.CameraControls_R Camera_Controls_In, bool Renderer_Hovered_In, bool Reset_In, out n5.CameraState_R CameraState2d_Out)
        {
            float __pad_Jd2QwdaQlVZQXrjYj4p4up_0 = __slot_Jd2QwdaQlVZQXrjYj4p4up;
            n6.Matrix __auto_1 = this.Transformation;
            bool __auto_2 = this.Initialize;
            bool __pad_DtJrxuoQdYLLfRw0qNGuOu_3 = __slot_DtJrxuoQdYLLfRw0qNGuOu;
            var Output_4 = new n6.Vector2(x: Initial_Zoom_In, y: Initial_Zoom_In);
            n6.Matrix Input_5 = n10._Operations_.CreateDefault();
            float Rotation_6 = 0F;
            bool Apply_7 = true;
            var Output_8 = Input_5;
            if (Apply_7)
            {
                n11._Operations_.TransformSRT(Input_In: Input_5, Scaling_In: Output_4, Rotation_In: Rotation_6, Translation_In: Initial_Interest_In, Output_Out: out Output_8);
            }

            var Output_14 = Camera_Controls_In.Split(Pan_Delta_Out: out n6.Vector2 Pan_Delta_9, Zoom_Delta_Out: out float Zoom_Delta_10, Zoom_Target_Out: out n6.Vector2 Zoom_Target_11, Reset_Out: out bool Reset_12, Idle_Out: out bool Idle_13);
            bool Apply_15 = true;
            var Output_16 = Reset_12;
            if (Apply_15)
            {
                var Output_17 = Reset_12 || Reset_In;
                Output_16 = Output_17;
            }

            bool Apply_18 = true;
            var Output_19 = __auto_2;
            if (Apply_18)
            {
                var Output_20 = __auto_2 || Output_16;
                Output_19 = Output_20;
            }

            var Output_21 = this.__p_IByC01h1YlrN7WsJsYqvVp;
            if (Output_19)
            {
                Output_21 = this.__p_IByC01h1YlrN7WsJsYqvVp.Flip();
            }

            var Output_24 = this.__p_Tvqyf2zdZbXPDdiuviNIm3.Update(Value_In: Idle_13, Up_Edge_Out: out bool Up_Edge_22, Down_Edge_Out: out bool Down_Edge_23);
            var Output_25 = Output_21;
            if (Down_Edge_23)
            {
                Output_25 = Output_21.Reset();
            }

            var Output_27 = Output_25.GetValue(Value_Out: out bool Value_26);
            n6.Matrix Input_28 = n10._Operations_.CreateDefault();
            bool Apply_29 = true;
            var Output_30 = Input_28;
            if (Apply_29)
            {
                n11._Operations_.Translate(Input_In: Input_28, Translation_In: Pan_Delta_9, Output_Out: out Output_30);
            }

            var Result_34 = __auto_1.Decompose(scale: out n6.Vector3 Scale_31, rotation: out n6.Quaternion Rotation_32, translation: out n6.Vector3 Translation_33);
            var X_35 = Scale_31.X;
            bool Apply_36 = true;
            var Output_37 = Maximum_Zoom_In;
            if (Apply_36)
            {
                var Output_38 = (float)Maximum_Zoom_In / X_35;
                Output_37 = Output_38;
            }

            bool Apply_39 = true;
            var Output_40 = Minimum_Zoom_In;
            if (Apply_39)
            {
                var Output_41 = (float)Minimum_Zoom_In / X_35;
                Output_40 = Output_41;
            }

            bool Apply_42 = true;
            var Output_43 = Zoom_Delta_10;
            if (Apply_42)
            {
                var Output_44 = Zoom_Delta_10 + __pad_Jd2QwdaQlVZQXrjYj4p4up_0;
                Output_43 = Output_44;
            }

            bool Apply_45 = true;
            var Output_46 = Output_40;
            if (Apply_45)
            {
                n13._Operations_.Max<float, n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Input_In: Output_40, Input_2_In: Output_43, Output_Out: out Output_46);
            }

            bool Apply_47 = true;
            var Output_48 = Output_37;
            if (Apply_47)
            {
                n13._Operations_.Min<float, n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Input_In: Output_37, Input_2_In: Output_46, Output_Out: out Output_48);
            }

            var Output_49 = new n6.Vector2(x: Output_48, y: Output_48);
            n6.Matrix Input_50 = n10._Operations_.CreateDefault();
            bool Apply_51 = true;
            var Output_52 = Input_50;
            if (Apply_51)
            {
                n11._Operations_.Scale_Center(Input_In: Input_50, Scaling_In: Output_49, Center_In: Zoom_Target_11, Output_Out: out Output_52);
            }

            bool Apply_53 = true;
            var Output_54 = Output_52;
            if (Apply_53)
            {
                n14.MatrixNodes.Transform(input: ref Output_52, transformation: ref __auto_1, result: out n6.Matrix Output_55);
                Output_54 = Output_55;
            }

            bool Apply_56 = true;
            var Output_57 = Output_30;
            if (Apply_56)
            {
                n14.MatrixNodes.Transform(input: ref Output_30, transformation: ref Output_54, result: out n6.Matrix Output_58);
                Output_57 = Output_58;
            }

            n15._Operations_.Switch_Boolean<n6.Matrix>(Condition_In: Value_26, Input_In: Output_57, Input_2_In: Output_8, Output_Out: out n6.Matrix Output_59);
            bool Apply_60 = true;
            var Output_61 = Output_59;
            if (Apply_60)
            {
                n6.Matrix.Invert(value: ref Output_59, result: out n6.Matrix Output_62);
                Output_61 = Output_62;
            }

            n5.CameraState_R Input_63 = n5.CameraState_R.CreateDefault();
            bool Apply_64 = true;
            var Output_65 = Input_63;
            if (Apply_64)
            {
                Output_65 = Input_63.Join(View_In: Output_59, Inverse_View_In: Output_61, Zoom_In: X_35, Idle_In: Idle_13, Renderer_Hovered_In: Renderer_Hovered_In);
            }

            n6.Matrix __auto_66 = Output_59;
            float __pad_Fk87pqbkHMzLNXPWbRedyG_67 = Output_43;
            bool __auto_68 = __pad_DtJrxuoQdYLLfRw0qNGuOu_3;
            CameraState2d_Out = Output_65;
            n5.Camera_LFaaf0fqmTzNy23KpgvNno that_69 = this;
            if (this.__GetContext__().IsImmutable)
                that_69 = Output_27 != this.__p_IByC01h1YlrN7WsJsYqvVp || Output_24 != this.__p_Tvqyf2zdZbXPDdiuviNIm3 || !n9.EqualityComparer<n6.Matrix>.Default.Equals(Output_59, this.Transformation) || Output_43 != this.__slot_Fk87pqbkHMzLNXPWbRedyG || __pad_DtJrxuoQdYLLfRw0qNGuOu_3 != this.Initialize ? new Camera_LFaaf0fqmTzNy23KpgvNno(this)
                {__p_IByC01h1YlrN7WsJsYqvVp = Output_27, __p_Tvqyf2zdZbXPDdiuviNIm3 = Output_24, Transformation = Output_59, __slot_Fk87pqbkHMzLNXPWbRedyG = Output_43, Initialize = __pad_DtJrxuoQdYLLfRw0qNGuOu_3} : that_69;
            else
            {
                this.__p_IByC01h1YlrN7WsJsYqvVp = Output_27;
                this.__p_Tvqyf2zdZbXPDdiuviNIm3 = Output_24;
                this.Transformation = Output_59;
                this.__slot_Fk87pqbkHMzLNXPWbRedyG = Output_43;
                this.Initialize = __pad_DtJrxuoQdYLLfRw0qNGuOu_3;
            }

            return that_69;
        }

        public n5.Camera_LFaaf0fqmTzNy23KpgvNno __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            bool __pad_MHkCPuD93uAM4ERH5jjH4l_0 = __slot_MHkCPuD93uAM4ERH5jjH4l;
            var Identity_1 = n6.Matrix.Identity;
            n6.Matrix __auto_2 = Identity_1;
            bool __auto_3 = __pad_MHkCPuD93uAM4ERH5jjH4l_0;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "Tvqyf2zdZbXPDdiuviNIm3", 55476U);
            var Output_5 = n16.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "IByC01h1YlrN7WsJsYqvVp", 55485U);
            var Output_7 = n16.Toggle_NRtjXBFlZv8LkW1dAEOgnz.Create(Node_Context: Node_Context_6);
            n5.Camera_LFaaf0fqmTzNy23KpgvNno that_8 = this;
            this.Transformation = Identity_1;
            this.Initialize = __pad_MHkCPuD93uAM4ERH5jjH4l_0;
            this.__slot_Fk87pqbkHMzLNXPWbRedyG = 0F;
            this.__p_Tvqyf2zdZbXPDdiuviNIm3 = Output_5;
            this.__p_IByC01h1YlrN7WsJsYqvVp = Output_7;
            return that_8;
        }

        public n5.Camera_LFaaf0fqmTzNy23KpgvNno __CreateDefault__()
        {
            n5.Camera_LFaaf0fqmTzNy23KpgvNno that_0 = this;
            this.Transformation = n10._Operations_.CreateDefault();
            this.Initialize = false;
            this.__slot_Fk87pqbkHMzLNXPWbRedyG = 0F;
            this.__p_IByC01h1YlrN7WsJsYqvVp = n16.Toggle_NRtjXBFlZv8LkW1dAEOgnz.CreateDefault();
            this.__p_Tvqyf2zdZbXPDdiuviNIm3 = n16.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_IByC01h1YlrN7WsJsYqvVp);
            n1.CompilationHelper.SafeDispose(this.__p_Tvqyf2zdZbXPDdiuviNIm3);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 55268U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "DRaUg3A7NoWMtmpyX4fNGy", Name = "Transformation")]
        public n6.Matrix Transformation;
        [n1.ElementAttribute(TracingId = 55270U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "CiIbjuINqxiPygJu99hoUC", Name = "Initialize")]
        public bool Initialize;
        [n1.ElementAttribute(TracingId = 55273U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Jd2QwdaQlVZQXrjYj4p4up", Name = "__slot_Jd2QwdaQlVZQXrjYj4p4up")]
        public static float __slot_Jd2QwdaQlVZQXrjYj4p4up = 1F;
        [n1.ElementAttribute(TracingId = 55296U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "DtJrxuoQdYLLfRw0qNGuOu", Name = "__slot_DtJrxuoQdYLLfRw0qNGuOu")]
        public static bool __slot_DtJrxuoQdYLLfRw0qNGuOu = false;
        [n1.ElementAttribute(TracingId = 55301U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "MHkCPuD93uAM4ERH5jjH4l", Name = "__slot_MHkCPuD93uAM4ERH5jjH4l")]
        public static bool __slot_MHkCPuD93uAM4ERH5jjH4l = true;
        [n1.ElementAttribute(TracingId = 55535U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Fk87pqbkHMzLNXPWbRedyG", Name = "__slot_Fk87pqbkHMzLNXPWbRedyG")]
        public float __slot_Fk87pqbkHMzLNXPWbRedyG;
        [n1.ElementAttribute(TracingId = 55485U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "IByC01h1YlrN7WsJsYqvVp", Name = "Toggle", IsManaged = true, IsAutoGenerated = true)]
        public n16.Toggle_NRtjXBFlZv8LkW1dAEOgnz __p_IByC01h1YlrN7WsJsYqvVp;
        [n1.ElementAttribute(TracingId = 55476U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Tvqyf2zdZbXPDdiuviNIm3", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n16.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Tvqyf2zdZbXPDdiuviNIm3;
        static Camera_LFaaf0fqmTzNy23KpgvNno()
        {
        }

        public Camera_LFaaf0fqmTzNy23KpgvNno(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Camera_LFaaf0fqmTzNy23KpgvNno(Camera_LFaaf0fqmTzNy23KpgvNno other): base(other)
        {
            this.Transformation = other.Transformation;
            this.Initialize = other.Initialize;
            this.__slot_Fk87pqbkHMzLNXPWbRedyG = other.__slot_Fk87pqbkHMzLNXPWbRedyG;
            this.__p_IByC01h1YlrN7WsJsYqvVp = other.__p_IByC01h1YlrN7WsJsYqvVp;
            this.__p_Tvqyf2zdZbXPDdiuviNIm3 = other.__p_Tvqyf2zdZbXPDdiuviNIm3;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Transformation", in Transformation), n1.CompilationHelper.GetValueOrExisting(values, "Initialize", in Initialize), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Fk87pqbkHMzLNXPWbRedyG", in __slot_Fk87pqbkHMzLNXPWbRedyG), n1.CompilationHelper.GetValueOrExisting(values, "__p_IByC01h1YlrN7WsJsYqvVp", in __p_IByC01h1YlrN7WsJsYqvVp), n1.CompilationHelper.GetValueOrExisting(values, "__p_Tvqyf2zdZbXPDdiuviNIm3", in __p_Tvqyf2zdZbXPDdiuviNIm3));
        }

        internal Camera_LFaaf0fqmTzNy23KpgvNno __WITH__(n6.Matrix Transformation, bool Initialize, float __slot_Fk87pqbkHMzLNXPWbRedyG, n16.Toggle_NRtjXBFlZv8LkW1dAEOgnz __p_IByC01h1YlrN7WsJsYqvVp, n16.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Tvqyf2zdZbXPDdiuviNIm3)
        {
            n5.Camera_LFaaf0fqmTzNy23KpgvNno that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = !n9.EqualityComparer<n6.Matrix>.Default.Equals(Transformation, this.Transformation) || Initialize != this.Initialize || __slot_Fk87pqbkHMzLNXPWbRedyG != this.__slot_Fk87pqbkHMzLNXPWbRedyG || __p_IByC01h1YlrN7WsJsYqvVp != this.__p_IByC01h1YlrN7WsJsYqvVp || __p_Tvqyf2zdZbXPDdiuviNIm3 != this.__p_Tvqyf2zdZbXPDdiuviNIm3 ? new Camera_LFaaf0fqmTzNy23KpgvNno(this)
                {Transformation = Transformation, Initialize = Initialize, __slot_Fk87pqbkHMzLNXPWbRedyG = __slot_Fk87pqbkHMzLNXPWbRedyG, __p_IByC01h1YlrN7WsJsYqvVp = __p_IByC01h1YlrN7WsJsYqvVp, __p_Tvqyf2zdZbXPDdiuviNIm3 = __p_Tvqyf2zdZbXPDdiuviNIm3} : that_0;
            else
            {
                this.Transformation = Transformation;
                this.Initialize = Initialize;
                this.__slot_Fk87pqbkHMzLNXPWbRedyG = __slot_Fk87pqbkHMzLNXPWbRedyG;
                this.__p_IByC01h1YlrN7WsJsYqvVp = __p_IByC01h1YlrN7WsJsYqvVp;
                this.__p_Tvqyf2zdZbXPDdiuviNIm3 = __p_Tvqyf2zdZbXPDdiuviNIm3;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 55639U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "RIFycJh98RsNTwGupKrcVf", Name = "CameraControls_R")]
    [n2.SerializableAttribute]
    public class CameraControls_R : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n5.CameraControls_R Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new CameraControls_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n5.CameraControls_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n5.CameraControls_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new CameraControls_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n5.CameraControls_R __DEFAULT__;
        public n5.CameraControls_R Update()
        {
            return this;
        }

        public n5.CameraControls_R Join(n6.Vector2 Pan_Delta_In, float Zoom_Delta_In, n6.Vector2 Zoom_Target_In, bool Reset_In, bool Idle_In)
        {
            n6.Vector2 __auto_0 = Pan_Delta_In;
            float __auto_1 = Zoom_Delta_In;
            n6.Vector2 __auto_2 = Zoom_Target_In;
            bool __auto_3 = Reset_In;
            bool Apply_4 = true;
            var Output_5 = Idle_In;
            if (Apply_4)
            {
                var Output_6 = !Idle_In;
                Output_5 = Output_6;
            }

            bool __auto_7 = Output_5;
            n5.CameraControls_R that_8 = this;
            that_8 = Pan_Delta_In != this.Pan_Delta || Zoom_Delta_In != this.Zoom_Delta || Zoom_Target_In != this.Zoom_Target || Reset_In != this.Reset || Output_5 != this.Not_Idle ? new CameraControls_R(this)
            {Pan_Delta = Pan_Delta_In, Zoom_Delta = Zoom_Delta_In, Zoom_Target = Zoom_Target_In, Reset = Reset_In, Not_Idle = Output_5} : that_8;
            return that_8;
        }

        public n5.CameraControls_R Split(out n6.Vector2 Pan_Delta_Out, out float Zoom_Delta_Out, out n6.Vector2 Zoom_Target_Out, out bool Reset_Out, out bool Idle_Out)
        {
            n6.Vector2 __auto_0 = this.Pan_Delta;
            float __auto_1 = this.Zoom_Delta;
            n6.Vector2 __auto_2 = this.Zoom_Target;
            bool __auto_3 = this.Reset;
            bool __auto_4 = this.Not_Idle;
            bool Apply_5 = true;
            var Output_6 = __auto_4;
            if (Apply_5)
            {
                var Output_7 = !__auto_4;
                Output_6 = Output_7;
            }

            Pan_Delta_Out = __auto_0;
            Zoom_Delta_Out = __auto_1;
            Zoom_Target_Out = __auto_2;
            Reset_Out = __auto_3;
            Idle_Out = Output_6;
            return this;
        }

        public n5.CameraControls_R Combine(n6.Vector2 Pan_Delta_In, float Zoom_Delta_In, n6.Vector2 Zoom_Target_In, bool Reset_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Idle_In)
        {
            n6.Vector2 __auto_0 = this.Pan_Delta;
            float __auto_1 = this.Zoom_Delta;
            n6.Vector2 __auto_2 = this.Zoom_Target;
            bool __auto_3 = this.Reset;
            bool __auto_4 = this.Not_Idle;
            bool Apply_5 = true;
            var Output_6 = Pan_Delta_In;
            if (Apply_5)
            {
                n6.Vector2.Add(left: ref Pan_Delta_In, right: ref __auto_0, result: out n6.Vector2 Output_7);
                Output_6 = Output_7;
            }

            n6.Vector2 __auto_8 = Output_6;
            bool Apply_9 = true;
            var Output_10 = Zoom_Delta_In;
            if (Apply_9)
            {
                var Output_11 = Zoom_Delta_In + __auto_1;
                Output_10 = Output_11;
            }

            float __auto_12 = Output_10;
            bool Apply_13 = true;
            var Output_14 = Zoom_Target_In;
            if (Apply_13)
            {
                n6.Vector2.Add(left: ref Zoom_Target_In, right: ref __auto_2, result: out n6.Vector2 Output_15);
                Output_14 = Output_15;
            }

            n6.Vector2 __auto_16 = Output_14;
            bool Apply_17 = true;
            var Output_18 = Reset_In;
            if (Apply_17)
            {
                var Output_19 = Reset_In || __auto_3;
                Output_18 = Output_19;
            }

            bool __auto_20 = Output_18;
            bool Apply_21 = true;
            var Output_22 = __auto_4;
            if (Apply_21)
            {
                var Output_23 = !__auto_4;
                Output_22 = Output_23;
            }

            bool Apply_24 = true;
            var Output_25 = Idle_In;
            if (Apply_24)
            {
                var Output_26 = Idle_In && Output_22;
                Output_25 = Output_26;
            }

            bool Apply_27 = true;
            var Output_28 = Output_25;
            if (Apply_27)
            {
                var Output_29 = !Output_25;
                Output_28 = Output_29;
            }

            bool __auto_30 = Output_28;
            n5.CameraControls_R that_31 = this;
            that_31 = Output_6 != this.Pan_Delta || Output_10 != this.Zoom_Delta || Output_14 != this.Zoom_Target || Output_18 != this.Reset || Output_28 != this.Not_Idle ? new CameraControls_R(this)
            {Pan_Delta = Output_6, Zoom_Delta = Output_10, Zoom_Target = Output_14, Reset = Output_18, Not_Idle = Output_28} : that_31;
            return that_31;
        }

        public n5.CameraControls_R __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n5.CameraControls_R that_0 = this;
            this.Pan_Delta = n17._Operations_.CreateDefault();
            this.Zoom_Delta = 0F;
            this.Zoom_Target = n17._Operations_.CreateDefault();
            this.Reset = false;
            this.Not_Idle = false;
            return that_0;
        }

        public n5.CameraControls_R __CreateDefault__()
        {
            n5.CameraControls_R that_0 = this;
            this.Pan_Delta = n17._Operations_.CreateDefault();
            this.Zoom_Delta = 0F;
            this.Zoom_Target = n17._Operations_.CreateDefault();
            this.Reset = false;
            this.Not_Idle = false;
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

        [n1.ElementAttribute(TracingId = 55641U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "TUEMPvsHNwPN81tV6qvE8e", Name = "Pan Delta")]
        public n6.Vector2 Pan_Delta;
        [n1.ElementAttribute(TracingId = 55642U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "HeuzLkrCCHxOUJ2DVsYTD9", Name = "Zoom Delta")]
        public float Zoom_Delta;
        [n1.ElementAttribute(TracingId = 55643U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "G0alAJzcadsOgJQ0fxzWh2", Name = "Zoom Target")]
        public n6.Vector2 Zoom_Target;
        [n1.ElementAttribute(TracingId = 55644U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "TAseukD8Xr3P3b7r0JzyJ2", Name = "Reset")]
        public bool Reset;
        [n1.ElementAttribute(TracingId = 55645U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "P2i7ZvNMXKzOlIJEhDOjZy", Name = "Not Idle")]
        public bool Not_Idle;
        public CameraControls_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CameraControls_R(CameraControls_R other): base(other)
        {
            this.Pan_Delta = other.Pan_Delta;
            this.Zoom_Delta = other.Zoom_Delta;
            this.Zoom_Target = other.Zoom_Target;
            this.Reset = other.Reset;
            this.Not_Idle = other.Not_Idle;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Pan_Delta", in Pan_Delta), n1.CompilationHelper.GetValueOrExisting(values, "Zoom_Delta", in Zoom_Delta), n1.CompilationHelper.GetValueOrExisting(values, "Zoom_Target", in Zoom_Target), n1.CompilationHelper.GetValueOrExisting(values, "Reset", in Reset), n1.CompilationHelper.GetValueOrExisting(values, "Not_Idle", in Not_Idle));
        }

        internal CameraControls_R __WITH__(n6.Vector2 Pan_Delta, float Zoom_Delta, n6.Vector2 Zoom_Target, bool Reset, bool Not_Idle)
        {
            n5.CameraControls_R that_0 = this;
            that_0 = Pan_Delta != this.Pan_Delta || Zoom_Delta != this.Zoom_Delta || Zoom_Target != this.Zoom_Target || Reset != this.Reset || Not_Idle != this.Not_Idle ? new CameraControls_R(this)
            {Pan_Delta = Pan_Delta, Zoom_Delta = Zoom_Delta, Zoom_Target = Zoom_Target, Reset = Reset, Not_Idle = Not_Idle} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 55871U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "LoFN5ZaM9SYOwk6ntuwxnm", Name = "CameraState_R")]
    [n2.SerializableAttribute]
    public class CameraState_R : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n5.CameraState_R Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new CameraState_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n5.CameraState_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n5.CameraState_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new CameraState_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n5.CameraState_R __DEFAULT__;
        public n5.CameraState_R Update()
        {
            return this;
        }

        public n5.CameraState_R Join(n6.Matrix View_In, n6.Matrix Inverse_View_In, float Zoom_In, bool Idle_In, bool Renderer_Hovered_In)
        {
            n6.Matrix __auto_0 = View_In;
            n6.Matrix __auto_1 = Inverse_View_In;
            float __auto_2 = Zoom_In;
            bool Apply_3 = true;
            var Output_4 = Idle_In;
            if (Apply_3)
            {
                var Output_5 = !Idle_In;
                Output_4 = Output_5;
            }

            bool __auto_6 = Output_4;
            bool Apply_7 = true;
            var Output_8 = Renderer_Hovered_In;
            if (Apply_7)
            {
                var Output_9 = !Renderer_Hovered_In;
                Output_8 = Output_9;
            }

            bool __auto_10 = Output_8;
            n5.CameraState_R that_11 = this;
            that_11 = !n9.EqualityComparer<n6.Matrix>.Default.Equals(View_In, this.View) || !n9.EqualityComparer<n6.Matrix>.Default.Equals(Inverse_View_In, this.Inverse_View) || Zoom_In != this.Zoom || Output_4 != this.Not_Idle || Output_8 != this.Renderer_Not_Hovered ? new CameraState_R(this)
            {View = View_In, Inverse_View = Inverse_View_In, Zoom = Zoom_In, Not_Idle = Output_4, Renderer_Not_Hovered = Output_8} : that_11;
            return that_11;
        }

        public n5.CameraState_R Split(out n6.Matrix View_Out, out n6.Matrix Inverse_View_Out, out float Zoom_Out, out bool Idle_Out, out bool Renderer_Hovered_Out)
        {
            n6.Matrix __auto_0 = this.View;
            n6.Matrix __auto_1 = this.Inverse_View;
            float __auto_2 = this.Zoom;
            bool __auto_3 = this.Not_Idle;
            bool __auto_4 = this.Renderer_Not_Hovered;
            bool Apply_5 = true;
            var Output_6 = __auto_3;
            if (Apply_5)
            {
                var Output_7 = !__auto_3;
                Output_6 = Output_7;
            }

            bool Apply_8 = true;
            var Output_9 = __auto_4;
            if (Apply_8)
            {
                var Output_10 = !__auto_4;
                Output_9 = Output_10;
            }

            View_Out = __auto_0;
            Inverse_View_Out = __auto_1;
            Zoom_Out = __auto_2;
            Idle_Out = Output_6;
            Renderer_Hovered_Out = Output_9;
            return this;
        }

        public n5.CameraState_R __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n5.CameraState_R that_0 = this;
            this.View = n10._Operations_.CreateDefault();
            this.Inverse_View = n10._Operations_.CreateDefault();
            this.Zoom = 0F;
            this.Not_Idle = false;
            this.Renderer_Not_Hovered = false;
            return that_0;
        }

        public n5.CameraState_R __CreateDefault__()
        {
            n5.CameraState_R that_0 = this;
            this.View = n10._Operations_.CreateDefault();
            this.Inverse_View = n10._Operations_.CreateDefault();
            this.Zoom = 0F;
            this.Not_Idle = false;
            this.Renderer_Not_Hovered = false;
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

        [n1.ElementAttribute(TracingId = 55875U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "PL4xoskVjAlPxqDzoEYpVG", Name = "View")]
        public n6.Matrix View;
        [n1.ElementAttribute(TracingId = 55876U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "GwbNxZ6GW5ZQRsB2Z98CNt", Name = "Inverse View")]
        public n6.Matrix Inverse_View;
        [n1.ElementAttribute(TracingId = 55879U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "OW9YSbnQ27ZMcipIT0qH45", Name = "Zoom")]
        public float Zoom;
        [n1.ElementAttribute(TracingId = 55881U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "SlIKZ2n3zFHNKcj8k4m4sq", Name = "Not Idle")]
        public bool Not_Idle;
        [n1.ElementAttribute(TracingId = 55919U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "I5LX2NJRGscONimG29ilBK", Name = "Renderer Not Hovered")]
        public bool Renderer_Not_Hovered;
        public CameraState_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CameraState_R(CameraState_R other): base(other)
        {
            this.View = other.View;
            this.Inverse_View = other.Inverse_View;
            this.Zoom = other.Zoom;
            this.Not_Idle = other.Not_Idle;
            this.Renderer_Not_Hovered = other.Renderer_Not_Hovered;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "View", in View), n1.CompilationHelper.GetValueOrExisting(values, "Inverse_View", in Inverse_View), n1.CompilationHelper.GetValueOrExisting(values, "Zoom", in Zoom), n1.CompilationHelper.GetValueOrExisting(values, "Not_Idle", in Not_Idle), n1.CompilationHelper.GetValueOrExisting(values, "Renderer_Not_Hovered", in Renderer_Not_Hovered));
        }

        internal CameraState_R __WITH__(n6.Matrix View, n6.Matrix Inverse_View, float Zoom, bool Not_Idle, bool Renderer_Not_Hovered)
        {
            n5.CameraState_R that_0 = this;
            that_0 = !n9.EqualityComparer<n6.Matrix>.Default.Equals(View, this.View) || !n9.EqualityComparer<n6.Matrix>.Default.Equals(Inverse_View, this.Inverse_View) || Zoom != this.Zoom || Not_Idle != this.Not_Idle || Renderer_Not_Hovered != this.Renderer_Not_Hovered ? new CameraState_R(this)
            {View = View, Inverse_View = Inverse_View, Zoom = Zoom, Not_Idle = Not_Idle, Renderer_Not_Hovered = Renderer_Not_Hovered} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 56003U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "A4gAuKiKvazMyBQuk926iQ", Name = "FlatCameraControls_A4gAuKiKvazMyBQuk926iQ")]
    [n2.SerializableAttribute]
    public class FlatCameraControls_A4gAuKiKvazMyBQuk926iQ : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n5.FlatCameraControls_A4gAuKiKvazMyBQuk926iQ Create(n1.NodeContext Node_Context)
        {
            var instance = new FlatCameraControls_A4gAuKiKvazMyBQuk926iQ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n5.FlatCameraControls_A4gAuKiKvazMyBQuk926iQ CreateDefault()
        {
            var instance = new FlatCameraControls_A4gAuKiKvazMyBQuk926iQ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n5.FlatCameraControls_A4gAuKiKvazMyBQuk926iQ Join(n5.CameraControls_R CameraControls2d_In, n7.IMouse Mouse_Device_In, n7.IKeyboard Keyboard_Device_In, float Zoom_Speed_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n5.CameraControls_R Camera_Controls_Out)
        {
            float __pad_SBsFD0vkXinPb5rsXitmeB_0 = __slot_SBsFD0vkXinPb5rsXitmeB;
            string __pad_P9gb0517Bm2PqZAFq0KdGM_1 = __slot_P9gb0517Bm2PqZAFq0KdGM;
            string __pad_AZ90K44eA6wQTYewMtX6cQ_2 = __slot_AZ90K44eA6wQTYewMtX6cQ;
            float __pad_HF38keQo17wLapVoU9TM3h_3 = __slot_HF38keQo17wLapVoU9TM3h;
            float __pad_Ox8W99D2VcPPS08Aip6Wor_4 = __slot_Ox8W99D2VcPPS08Aip6Wor;
            var Output_15 = this.__p_KtMlSmEl91kNwO2Ppdnleh.Update(Mouse_Device_In: Mouse_Device_In, Position_In_World_Out: out n6.Vector2 Position_In_World_5, Position_In_Projection_Out: out n6.Vector2 Position_In_Projection_6, Position_Out: out n6.Vector2 Position_7, Left_Pressed_Out: out bool Left_Pressed_8, Middle_Pressed_Out: out bool Middle_Pressed_9, Right_Pressed_Out: out bool Right_Pressed_10, Normalized_Position_Out: out n6.Vector2 Normalized_Position_11, WheelDelta_Out: out int WheelDelta_12, Client_Area_Out: out n6.Vector2 Client_Area_13, Sender_Out: out n2.Object Sender_14);
            var Output_17 = this.__p_C2APHgdy3QEN9830kW5hrb.Update<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Value_In: Position_In_World_5, Result_Out: out n6.Vector2 Result_16);
            float Scalar_18 = n2.Convert.ToSingle(Right_Pressed_10);
            bool Apply_19 = true;
            var Output_20 = Result_16;
            if (Apply_19)
            {
                n14.Vector2Nodes.Scale(input: ref Result_16, scalar: Scalar_18, output: out n6.Vector2 Output_21);
                Output_20 = Output_21;
            }

            var Output_23 = this.__p_KuGKS78x6lQNjAr6eRI6U2.Update(Keyboard_Device_In: Keyboard_Device_In, Pressed_Keys_Out: out n19.ImmutableHashSet<n18.Keys> Pressed_Keys_22);
            var Output_25 = this.__p_UwGBk0Vit7KPrWbi4IWtxd.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_P9gb0517Bm2PqZAFq0KdGM_1, Is_Down_Out: out bool Is_Down_24);
            bool Apply_26 = true;
            var Output_27 = Zoom_Speed_In;
            if (Apply_26)
            {
                var Output_28 = (float)Zoom_Speed_In / __pad_Ox8W99D2VcPPS08Aip6Wor_4;
                Output_27 = Output_28;
            }

            n15._Operations_.Switch_Boolean<float>(Condition_In: Is_Down_24, Input_In: Zoom_Speed_In, Input_2_In: Output_27, Output_Out: out float Output_29);
            var Output_31 = this.__p_QvFPIGTyKoTPRfK2UqHepK.Update<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Value_In: WheelDelta_12, Result_Out: out int Result_30);
            float Input_32 = (float)Result_30;
            bool Apply_33 = true;
            var Output_34 = Input_32;
            if (Apply_33)
            {
                var Output_35 = (float)Input_32 / __pad_SBsFD0vkXinPb5rsXitmeB_0;
                Output_34 = Output_35;
            }

            bool Apply_36 = true;
            var Output_37 = Output_29;
            if (Apply_36)
            {
                var Output_38 = Output_29 * Output_34;
                Output_37 = Output_38;
            }

            var Output_40 = this.__p_NsBC97mGrGZNnsqRkdd6qf.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_AZ90K44eA6wQTYewMtX6cQ_2, Is_Down_Out: out bool Is_Down_39);
            bool Reset_41 = false;
            var Output_44 = this.__p_T1C8k1u3XWSNr7UBEpfmz6.Update(Set_In: Is_Down_39, Reset_In: Reset_41, Time_In: __pad_HF38keQo17wLapVoU9TM3h_3, Value_Out: out bool Value_42, Running_Out: out float Running_43);
            var Output_47 = this.__p_VayzprCSIFAN5ieBOg6yTk.Update(Value_In: Value_42, Up_Edge_Out: out bool Up_Edge_45, Down_Edge_Out: out bool Down_Edge_46);
            var Output_50 = this.__p_HI9qYZgSJgRQRBH0NQqpC2.Update(Value_In: WheelDelta_12, Result_Out: out bool Result_48, Unchanged_Out: out bool Unchanged_49);
            var Output_51 = Result_48 || Right_Pressed_10;
            var Output_52 = Output_51 || Is_Down_39;
            bool Apply_53 = true;
            var Output_54 = Output_52;
            if (Apply_53)
            {
                var Output_55 = !Output_52;
                Output_54 = Output_55;
            }

            var Output_56 = CameraControls2d_In;
            if (Enabled_In)
            {
                Output_56 = CameraControls2d_In.Combine(Pan_Delta_In: Output_20, Zoom_Delta_In: Output_37, Zoom_Target_In: Position_In_World_5, Reset_In: Up_Edge_45, Idle_In: Output_54);
            }

            Camera_Controls_Out = Output_56;
            n5.FlatCameraControls_A4gAuKiKvazMyBQuk926iQ that_57 = this;
            if (this.__GetContext__().IsImmutable)
                that_57 = Output_15 != this.__p_KtMlSmEl91kNwO2Ppdnleh || Output_17 != this.__p_C2APHgdy3QEN9830kW5hrb || Output_23 != this.__p_KuGKS78x6lQNjAr6eRI6U2 || Output_25 != this.__p_UwGBk0Vit7KPrWbi4IWtxd || Output_31 != this.__p_QvFPIGTyKoTPRfK2UqHepK || Output_40 != this.__p_NsBC97mGrGZNnsqRkdd6qf || Output_44 != this.__p_T1C8k1u3XWSNr7UBEpfmz6 || Output_47 != this.__p_VayzprCSIFAN5ieBOg6yTk || Output_50 != this.__p_HI9qYZgSJgRQRBH0NQqpC2 ? new FlatCameraControls_A4gAuKiKvazMyBQuk926iQ(this)
                {__p_KtMlSmEl91kNwO2Ppdnleh = Output_15, __p_C2APHgdy3QEN9830kW5hrb = Output_17, __p_KuGKS78x6lQNjAr6eRI6U2 = Output_23, __p_UwGBk0Vit7KPrWbi4IWtxd = Output_25, __p_QvFPIGTyKoTPRfK2UqHepK = Output_31, __p_NsBC97mGrGZNnsqRkdd6qf = Output_40, __p_T1C8k1u3XWSNr7UBEpfmz6 = Output_44, __p_VayzprCSIFAN5ieBOg6yTk = Output_47, __p_HI9qYZgSJgRQRBH0NQqpC2 = Output_50} : that_57;
            else
            {
                this.__p_KtMlSmEl91kNwO2Ppdnleh = Output_15;
                this.__p_C2APHgdy3QEN9830kW5hrb = Output_17;
                this.__p_KuGKS78x6lQNjAr6eRI6U2 = Output_23;
                this.__p_UwGBk0Vit7KPrWbi4IWtxd = Output_25;
                this.__p_QvFPIGTyKoTPRfK2UqHepK = Output_31;
                this.__p_NsBC97mGrGZNnsqRkdd6qf = Output_40;
                this.__p_T1C8k1u3XWSNr7UBEpfmz6 = Output_44;
                this.__p_VayzprCSIFAN5ieBOg6yTk = Output_47;
                this.__p_HI9qYZgSJgRQRBH0NQqpC2 = Output_50;
            }

            return that_57;
        }

        public n5.FlatCameraControls_A4gAuKiKvazMyBQuk926iQ __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "KtMlSmEl91kNwO2Ppdnleh", 56047U);
            var Output_1 = n24.MouseState_BNOhaxXysw1MZBzyJMI18t.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "KuGKS78x6lQNjAr6eRI6U2", 56065U);
            var Output_3 = n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "C2APHgdy3QEN9830kW5hrb", 56069U);
            var Output_5 = n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector2>.Create<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "UwGBk0Vit7KPrWbi4IWtxd", 56074U);
            var Output_7 = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "QvFPIGTyKoTPRfK2UqHepK", 56111U);
            var Output_9 = n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<int>.Create<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "T1C8k1u3XWSNr7UBEpfmz6", 56125U);
            n31.IClock Clock_11 = n30._Operations_.CreateDefault();
            var Output_12 = n16.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H.Create(Node_Context: Node_Context_10, Clock_In: Clock_11);
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "NsBC97mGrGZNnsqRkdd6qf", 56138U);
            var Output_14 = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_13);
            n1.NodeContext Node_Context_15 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "VayzprCSIFAN5ieBOg6yTk", 56146U);
            var Output_16 = n16.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_15);
            n1.NodeContext Node_Context_17 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "HI9qYZgSJgRQRBH0NQqpC2", 56182U);
            bool Changed_On_Create_18 = true;
            var Output_19 = n16.Changed_A8JGbead2bxNdnPybiEqVS<int>.Create<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Node_Context: Node_Context_17, Changed_On_Create_In: Changed_On_Create_18);
            n5.FlatCameraControls_A4gAuKiKvazMyBQuk926iQ that_20 = this;
            this.__p_KtMlSmEl91kNwO2Ppdnleh = Output_1;
            this.__p_KuGKS78x6lQNjAr6eRI6U2 = Output_3;
            this.__p_C2APHgdy3QEN9830kW5hrb = Output_5;
            this.__p_UwGBk0Vit7KPrWbi4IWtxd = Output_7;
            this.__p_QvFPIGTyKoTPRfK2UqHepK = Output_9;
            this.__p_T1C8k1u3XWSNr7UBEpfmz6 = Output_12;
            this.__p_NsBC97mGrGZNnsqRkdd6qf = Output_14;
            this.__p_VayzprCSIFAN5ieBOg6yTk = Output_16;
            this.__p_HI9qYZgSJgRQRBH0NQqpC2 = Output_19;
            return that_20;
        }

        public n5.FlatCameraControls_A4gAuKiKvazMyBQuk926iQ __CreateDefault__()
        {
            n5.FlatCameraControls_A4gAuKiKvazMyBQuk926iQ that_0 = this;
            this.__p_KtMlSmEl91kNwO2Ppdnleh = n24.MouseState_BNOhaxXysw1MZBzyJMI18t.CreateDefault();
            this.__p_C2APHgdy3QEN9830kW5hrb = n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector2>.CreateDefault<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>();
            this.__p_KuGKS78x6lQNjAr6eRI6U2 = n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.CreateDefault();
            this.__p_UwGBk0Vit7KPrWbi4IWtxd = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_QvFPIGTyKoTPRfK2UqHepK = n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<int>.CreateDefault<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>();
            this.__p_NsBC97mGrGZNnsqRkdd6qf = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_T1C8k1u3XWSNr7UBEpfmz6 = n16.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H.CreateDefault();
            this.__p_VayzprCSIFAN5ieBOg6yTk = n16.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_HI9qYZgSJgRQRBH0NQqpC2 = n16.Changed_A8JGbead2bxNdnPybiEqVS<int>.CreateDefault<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_KtMlSmEl91kNwO2Ppdnleh);
            n1.CompilationHelper.SafeDispose(this.__p_C2APHgdy3QEN9830kW5hrb);
            n1.CompilationHelper.SafeDispose(this.__p_KuGKS78x6lQNjAr6eRI6U2);
            n1.CompilationHelper.SafeDispose(this.__p_UwGBk0Vit7KPrWbi4IWtxd);
            n1.CompilationHelper.SafeDispose(this.__p_QvFPIGTyKoTPRfK2UqHepK);
            n1.CompilationHelper.SafeDispose(this.__p_NsBC97mGrGZNnsqRkdd6qf);
            n1.CompilationHelper.SafeDispose(this.__p_T1C8k1u3XWSNr7UBEpfmz6);
            n1.CompilationHelper.SafeDispose(this.__p_VayzprCSIFAN5ieBOg6yTk);
            n1.CompilationHelper.SafeDispose(this.__p_HI9qYZgSJgRQRBH0NQqpC2);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 56032U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "P9gb0517Bm2PqZAFq0KdGM", Name = "__slot_P9gb0517Bm2PqZAFq0KdGM")]
        public static string __slot_P9gb0517Bm2PqZAFq0KdGM = "ShiftKey";
        [n1.ElementAttribute(TracingId = 56037U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Ox8W99D2VcPPS08Aip6Wor", Name = "__slot_Ox8W99D2VcPPS08Aip6Wor")]
        public static float __slot_Ox8W99D2VcPPS08Aip6Wor = 4F;
        [n1.ElementAttribute(TracingId = 56038U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "SBsFD0vkXinPb5rsXitmeB", Name = "__slot_SBsFD0vkXinPb5rsXitmeB")]
        public static float __slot_SBsFD0vkXinPb5rsXitmeB = 10F;
        [n1.ElementAttribute(TracingId = 56040U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "AZ90K44eA6wQTYewMtX6cQ", Name = "__slot_AZ90K44eA6wQTYewMtX6cQ")]
        public static string __slot_AZ90K44eA6wQTYewMtX6cQ = "R";
        [n1.ElementAttribute(TracingId = 56042U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "HF38keQo17wLapVoU9TM3h", Name = "__slot_HF38keQo17wLapVoU9TM3h")]
        public static float __slot_HF38keQo17wLapVoU9TM3h = 0.5F;
        [n1.ElementAttribute(TracingId = 56047U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "KtMlSmEl91kNwO2Ppdnleh", Name = "MouseState", IsManaged = true, IsAutoGenerated = true)]
        public n24.MouseState_BNOhaxXysw1MZBzyJMI18t __p_KtMlSmEl91kNwO2Ppdnleh;
        [n1.ElementAttribute(TracingId = 56069U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "C2APHgdy3QEN9830kW5hrb", Name = "FrameDifference", IsManaged = true, IsAutoGenerated = true)]
        public n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector2> __p_C2APHgdy3QEN9830kW5hrb;
        [n1.ElementAttribute(TracingId = 56065U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "KuGKS78x6lQNjAr6eRI6U2", Name = "KeyboardState", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_KuGKS78x6lQNjAr6eRI6U2;
        [n1.ElementAttribute(TracingId = 56074U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "UwGBk0Vit7KPrWbi4IWtxd", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_UwGBk0Vit7KPrWbi4IWtxd;
        [n1.ElementAttribute(TracingId = 56111U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "QvFPIGTyKoTPRfK2UqHepK", Name = "FrameDifference", IsManaged = true, IsAutoGenerated = true)]
        public n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<int> __p_QvFPIGTyKoTPRfK2UqHepK;
        [n1.ElementAttribute(TracingId = 56138U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "NsBC97mGrGZNnsqRkdd6qf", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_NsBC97mGrGZNnsqRkdd6qf;
        [n1.ElementAttribute(TracingId = 56125U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "T1C8k1u3XWSNr7UBEpfmz6", Name = "TimerFlop", IsManaged = true, IsAutoGenerated = true)]
        public n16.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H __p_T1C8k1u3XWSNr7UBEpfmz6;
        [n1.ElementAttribute(TracingId = 56146U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "VayzprCSIFAN5ieBOg6yTk", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n16.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_VayzprCSIFAN5ieBOg6yTk;
        [n1.ElementAttribute(TracingId = 56182U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "HI9qYZgSJgRQRBH0NQqpC2", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n16.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_HI9qYZgSJgRQRBH0NQqpC2;
        static FlatCameraControls_A4gAuKiKvazMyBQuk926iQ()
        {
        }

        public FlatCameraControls_A4gAuKiKvazMyBQuk926iQ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FlatCameraControls_A4gAuKiKvazMyBQuk926iQ(FlatCameraControls_A4gAuKiKvazMyBQuk926iQ other): base(other)
        {
            this.__p_KtMlSmEl91kNwO2Ppdnleh = other.__p_KtMlSmEl91kNwO2Ppdnleh;
            this.__p_C2APHgdy3QEN9830kW5hrb = other.__p_C2APHgdy3QEN9830kW5hrb;
            this.__p_KuGKS78x6lQNjAr6eRI6U2 = other.__p_KuGKS78x6lQNjAr6eRI6U2;
            this.__p_UwGBk0Vit7KPrWbi4IWtxd = other.__p_UwGBk0Vit7KPrWbi4IWtxd;
            this.__p_QvFPIGTyKoTPRfK2UqHepK = other.__p_QvFPIGTyKoTPRfK2UqHepK;
            this.__p_NsBC97mGrGZNnsqRkdd6qf = other.__p_NsBC97mGrGZNnsqRkdd6qf;
            this.__p_T1C8k1u3XWSNr7UBEpfmz6 = other.__p_T1C8k1u3XWSNr7UBEpfmz6;
            this.__p_VayzprCSIFAN5ieBOg6yTk = other.__p_VayzprCSIFAN5ieBOg6yTk;
            this.__p_HI9qYZgSJgRQRBH0NQqpC2 = other.__p_HI9qYZgSJgRQRBH0NQqpC2;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_KtMlSmEl91kNwO2Ppdnleh", in __p_KtMlSmEl91kNwO2Ppdnleh), n1.CompilationHelper.GetValueOrExisting(values, "__p_C2APHgdy3QEN9830kW5hrb", in __p_C2APHgdy3QEN9830kW5hrb), n1.CompilationHelper.GetValueOrExisting(values, "__p_KuGKS78x6lQNjAr6eRI6U2", in __p_KuGKS78x6lQNjAr6eRI6U2), n1.CompilationHelper.GetValueOrExisting(values, "__p_UwGBk0Vit7KPrWbi4IWtxd", in __p_UwGBk0Vit7KPrWbi4IWtxd), n1.CompilationHelper.GetValueOrExisting(values, "__p_QvFPIGTyKoTPRfK2UqHepK", in __p_QvFPIGTyKoTPRfK2UqHepK), n1.CompilationHelper.GetValueOrExisting(values, "__p_NsBC97mGrGZNnsqRkdd6qf", in __p_NsBC97mGrGZNnsqRkdd6qf), n1.CompilationHelper.GetValueOrExisting(values, "__p_T1C8k1u3XWSNr7UBEpfmz6", in __p_T1C8k1u3XWSNr7UBEpfmz6), n1.CompilationHelper.GetValueOrExisting(values, "__p_VayzprCSIFAN5ieBOg6yTk", in __p_VayzprCSIFAN5ieBOg6yTk), n1.CompilationHelper.GetValueOrExisting(values, "__p_HI9qYZgSJgRQRBH0NQqpC2", in __p_HI9qYZgSJgRQRBH0NQqpC2));
        }

        internal FlatCameraControls_A4gAuKiKvazMyBQuk926iQ __WITH__(n24.MouseState_BNOhaxXysw1MZBzyJMI18t __p_KtMlSmEl91kNwO2Ppdnleh, n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector2> __p_C2APHgdy3QEN9830kW5hrb, n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_KuGKS78x6lQNjAr6eRI6U2, n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_UwGBk0Vit7KPrWbi4IWtxd, n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<int> __p_QvFPIGTyKoTPRfK2UqHepK, n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_NsBC97mGrGZNnsqRkdd6qf, n16.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H __p_T1C8k1u3XWSNr7UBEpfmz6, n16.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_VayzprCSIFAN5ieBOg6yTk, n16.Changed_A8JGbead2bxNdnPybiEqVS<int> __p_HI9qYZgSJgRQRBH0NQqpC2)
        {
            n5.FlatCameraControls_A4gAuKiKvazMyBQuk926iQ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_KtMlSmEl91kNwO2Ppdnleh != this.__p_KtMlSmEl91kNwO2Ppdnleh || __p_C2APHgdy3QEN9830kW5hrb != this.__p_C2APHgdy3QEN9830kW5hrb || __p_KuGKS78x6lQNjAr6eRI6U2 != this.__p_KuGKS78x6lQNjAr6eRI6U2 || __p_UwGBk0Vit7KPrWbi4IWtxd != this.__p_UwGBk0Vit7KPrWbi4IWtxd || __p_QvFPIGTyKoTPRfK2UqHepK != this.__p_QvFPIGTyKoTPRfK2UqHepK || __p_NsBC97mGrGZNnsqRkdd6qf != this.__p_NsBC97mGrGZNnsqRkdd6qf || __p_T1C8k1u3XWSNr7UBEpfmz6 != this.__p_T1C8k1u3XWSNr7UBEpfmz6 || __p_VayzprCSIFAN5ieBOg6yTk != this.__p_VayzprCSIFAN5ieBOg6yTk || __p_HI9qYZgSJgRQRBH0NQqpC2 != this.__p_HI9qYZgSJgRQRBH0NQqpC2 ? new FlatCameraControls_A4gAuKiKvazMyBQuk926iQ(this)
                {__p_KtMlSmEl91kNwO2Ppdnleh = __p_KtMlSmEl91kNwO2Ppdnleh, __p_C2APHgdy3QEN9830kW5hrb = __p_C2APHgdy3QEN9830kW5hrb, __p_KuGKS78x6lQNjAr6eRI6U2 = __p_KuGKS78x6lQNjAr6eRI6U2, __p_UwGBk0Vit7KPrWbi4IWtxd = __p_UwGBk0Vit7KPrWbi4IWtxd, __p_QvFPIGTyKoTPRfK2UqHepK = __p_QvFPIGTyKoTPRfK2UqHepK, __p_NsBC97mGrGZNnsqRkdd6qf = __p_NsBC97mGrGZNnsqRkdd6qf, __p_T1C8k1u3XWSNr7UBEpfmz6 = __p_T1C8k1u3XWSNr7UBEpfmz6, __p_VayzprCSIFAN5ieBOg6yTk = __p_VayzprCSIFAN5ieBOg6yTk, __p_HI9qYZgSJgRQRBH0NQqpC2 = __p_HI9qYZgSJgRQRBH0NQqpC2} : that_0;
            else
            {
                this.__p_KtMlSmEl91kNwO2Ppdnleh = __p_KtMlSmEl91kNwO2Ppdnleh;
                this.__p_C2APHgdy3QEN9830kW5hrb = __p_C2APHgdy3QEN9830kW5hrb;
                this.__p_KuGKS78x6lQNjAr6eRI6U2 = __p_KuGKS78x6lQNjAr6eRI6U2;
                this.__p_UwGBk0Vit7KPrWbi4IWtxd = __p_UwGBk0Vit7KPrWbi4IWtxd;
                this.__p_QvFPIGTyKoTPRfK2UqHepK = __p_QvFPIGTyKoTPRfK2UqHepK;
                this.__p_NsBC97mGrGZNnsqRkdd6qf = __p_NsBC97mGrGZNnsqRkdd6qf;
                this.__p_T1C8k1u3XWSNr7UBEpfmz6 = __p_T1C8k1u3XWSNr7UBEpfmz6;
                this.__p_VayzprCSIFAN5ieBOg6yTk = __p_VayzprCSIFAN5ieBOg6yTk;
                this.__p_HI9qYZgSJgRQRBH0NQqpC2 = __p_HI9qYZgSJgRQRBH0NQqpC2;
            }

            return that_0;
        }
    }
}

namespace _VL_Cameras_.Editors._3D.Experimental
{
    [n1.ElementAttribute(TracingId = 56251U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "E9tsLZ1ZljYQQZibZCjHcV", Name = "Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV")]
    [n2.SerializableAttribute]
    public class Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n20.Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV Create(n1.NodeContext Node_Context)
        {
            var instance = new Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n20.Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV CreateDefault()
        {
            var instance = new Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n20.Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV Update(n6.Vector3 Initial_Interest_In, [n4.SerializedDefaultValueAttribute("1", false)] float Initial_Yaw_In, float Initial_Pitch_In, float Initial_Distance_In, float Initial_FOV_In, [n4.SerializedDefaultValueAttribute("0.01", false)] float Near_Plane_In, [n4.SerializedDefaultValueAttribute("100", false)] float Far_Plane_In, out n21.CameraState_R CameraState3d_Out, out object Idle_Out)
        {
            n21.CameraControls_R Camera_Controls_0 = n21.CameraControls_R.CreateDefault();
            n7.IMouse Mouse_Device_1 = n22._Operations_.CreateDefault();
            n7.IKeyboard Keyboard_Device_2 = n23._Operations_.CreateDefault();
            bool Enabled_3 = true;
            var Output_5 = this.__p_RRfIMfWc7HLQOx8N824uNz.Join(Camera_Controls_In: Camera_Controls_0, Mouse_Device_In: Mouse_Device_1, Keyboard_Device_In: Keyboard_Device_2, Enabled_In: Enabled_3, Camera_Controls_Out: out n21.CameraControls_R Camera_Controls_4);
            bool Renderer_Hovered_6 = false;
            bool Reset_7 = false;
            var Output_9 = this.__p_V0Vz3rloeorNm7XgZwfPn9.Update(Initial_Interest_In: Initial_Interest_In, Initial_Longitude_In: Initial_Yaw_In, Initial_Latitude_In: Initial_Pitch_In, Initial_Distance_In: Initial_Distance_In, Initial_FOV_In: Initial_FOV_In, Near_Plane_In: Near_Plane_In, Far_Plane_In: Far_Plane_In, CameraControls3d_In: Camera_Controls_4, Renderer_Hovered_In: Renderer_Hovered_6, Reset_In: Reset_7, CameraState3d_Out: out n21.CameraState_R CameraState3d_8);
            CameraState3d_Out = CameraState3d_8;
            Idle_Out = default(object);
            n20.Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = Output_5 != this.__p_RRfIMfWc7HLQOx8N824uNz || Output_9 != this.__p_V0Vz3rloeorNm7XgZwfPn9 ? new Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV(this)
                {__p_RRfIMfWc7HLQOx8N824uNz = Output_5, __p_V0Vz3rloeorNm7XgZwfPn9 = Output_9} : that_10;
            else
            {
                this.__p_RRfIMfWc7HLQOx8N824uNz = Output_5;
                this.__p_V0Vz3rloeorNm7XgZwfPn9 = Output_9;
            }

            return that_10;
        }

        public n20.Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "V0Vz3rloeorNm7XgZwfPn9", 56273U);
            var Output_1 = n21.Camera_HKLB3PgmAVIMC1vhgpaagj.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "RRfIMfWc7HLQOx8N824uNz", 56310U);
            var Output_3 = n21.SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W.Create(Node_Context: Node_Context_2);
            n20.Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV that_4 = this;
            this.__p_V0Vz3rloeorNm7XgZwfPn9 = Output_1;
            this.__p_RRfIMfWc7HLQOx8N824uNz = Output_3;
            return that_4;
        }

        public n20.Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV __CreateDefault__()
        {
            n20.Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV that_0 = this;
            this.__p_RRfIMfWc7HLQOx8N824uNz = n21.SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W.CreateDefault();
            this.__p_V0Vz3rloeorNm7XgZwfPn9 = n21.Camera_HKLB3PgmAVIMC1vhgpaagj.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_RRfIMfWc7HLQOx8N824uNz);
            n1.CompilationHelper.SafeDispose(this.__p_V0Vz3rloeorNm7XgZwfPn9);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 56271U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "KIun6koWmegLoz5ftBhVC1", Name = "__slot_KIun6koWmegLoz5ftBhVC1")]
        public static string __slot_KIun6koWmegLoz5ftBhVC1 = "connect mouse and keyboard below";
        [n1.ElementAttribute(TracingId = 56310U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "RRfIMfWc7HLQOx8N824uNz", Name = "SoftimageCameraControls", IsManaged = true, IsAutoGenerated = true)]
        public n21.SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W __p_RRfIMfWc7HLQOx8N824uNz;
        [n1.ElementAttribute(TracingId = 56273U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "V0Vz3rloeorNm7XgZwfPn9", Name = "Camera", IsManaged = true, IsAutoGenerated = true)]
        public n21.Camera_HKLB3PgmAVIMC1vhgpaagj __p_V0Vz3rloeorNm7XgZwfPn9;
        static Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV()
        {
        }

        public Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV(Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV other): base(other)
        {
            this.__p_RRfIMfWc7HLQOx8N824uNz = other.__p_RRfIMfWc7HLQOx8N824uNz;
            this.__p_V0Vz3rloeorNm7XgZwfPn9 = other.__p_V0Vz3rloeorNm7XgZwfPn9;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RRfIMfWc7HLQOx8N824uNz", in __p_RRfIMfWc7HLQOx8N824uNz), n1.CompilationHelper.GetValueOrExisting(values, "__p_V0Vz3rloeorNm7XgZwfPn9", in __p_V0Vz3rloeorNm7XgZwfPn9));
        }

        internal Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV __WITH__(n21.SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W __p_RRfIMfWc7HLQOx8N824uNz, n21.Camera_HKLB3PgmAVIMC1vhgpaagj __p_V0Vz3rloeorNm7XgZwfPn9)
        {
            n20.Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_RRfIMfWc7HLQOx8N824uNz != this.__p_RRfIMfWc7HLQOx8N824uNz || __p_V0Vz3rloeorNm7XgZwfPn9 != this.__p_V0Vz3rloeorNm7XgZwfPn9 ? new Camera_Softimage_E9tsLZ1ZljYQQZibZCjHcV(this)
                {__p_RRfIMfWc7HLQOx8N824uNz = __p_RRfIMfWc7HLQOx8N824uNz, __p_V0Vz3rloeorNm7XgZwfPn9 = __p_V0Vz3rloeorNm7XgZwfPn9} : that_0;
            else
            {
                this.__p_RRfIMfWc7HLQOx8N824uNz = __p_RRfIMfWc7HLQOx8N824uNz;
                this.__p_V0Vz3rloeorNm7XgZwfPn9 = __p_V0Vz3rloeorNm7XgZwfPn9;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 56376U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "SNtf6GIgOyxLiTq5x6Kk4z", Name = "Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z")]
    [n2.SerializableAttribute]
    public class Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n20.Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z Create(n1.NodeContext Node_Context)
        {
            var instance = new Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n20.Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z CreateDefault()
        {
            var instance = new Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n20.Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z Update(n6.Vector3 Initial_Interest_In, [n4.SerializedDefaultValueAttribute("1", false)] float Initial_Yaw_In, float Initial_Pitch_In, [n4.SerializedDefaultValueAttribute("2", false)] float Initial_Distance_In, [n4.SerializedDefaultValueAttribute("0.12", false)] float Initial_FOV_In, n7.IMouse Mouse_In, n7.IKeyboard Keyboard_In, [n4.SerializedDefaultValueAttribute("0.01", false)] float Near_Plane_In, [n4.SerializedDefaultValueAttribute("100", false)] float Far_Plane_In, out n21.CameraState_R CameraState3d_Out, out bool Idle_Out)
        {
            string __pad_T4dvIRbOzoxNrvFNEb4jL5_0 = __slot_T4dvIRbOzoxNrvFNEb4jL5;
            string __pad_SWQ6QmhaoZaMdm3tOGhenG_1 = __slot_SWQ6QmhaoZaMdm3tOGhenG;
            n21.CameraControls_R Camera_Controls_2 = n21.CameraControls_R.CreateDefault();
            float Filter_Time_3 = 0.5F;
            bool Enable_Controls_4 = true;
            var Output_6 = this.__p_UcvgKlIBwhuOu0tQmqBPcN.Join(Camera_Controls_In: Camera_Controls_2, Mouse_Device_In: Mouse_In, Keyboard_Device_In: Keyboard_In, Filter_Time_In: Filter_Time_3, Enable_Controls_In: Enable_Controls_4, Camera_Controls_Out: out n21.CameraControls_R Camera_Controls_5);
            bool Renderer_Hovered_7 = false;
            bool Reset_8 = false;
            var Output_10 = this.__p_Rtq4vxmrYZ4PgIKj1bjyAK.Update(Initial_Interest_In: Initial_Interest_In, Initial_Longitude_In: Initial_Yaw_In, Initial_Latitude_In: Initial_Pitch_In, Initial_Distance_In: Initial_Distance_In, Initial_FOV_In: Initial_FOV_In, Near_Plane_In: Near_Plane_In, Far_Plane_In: Far_Plane_In, CameraControls3d_In: Camera_Controls_5, Renderer_Hovered_In: Renderer_Hovered_7, Reset_In: Reset_8, CameraState3d_Out: out n21.CameraState_R CameraState3d_9);
            var Output_21 = this.__p_Rlr7Owy6U8bNzey9NPg13y.Update(Mouse_Device_In: Mouse_In, Position_In_World_Out: out n6.Vector2 Position_In_World_11, Position_In_Projection_Out: out n6.Vector2 Position_In_Projection_12, Position_Out: out n6.Vector2 Position_13, Left_Pressed_Out: out bool Left_Pressed_14, Middle_Pressed_Out: out bool Middle_Pressed_15, Right_Pressed_Out: out bool Right_Pressed_16, Normalized_Position_Out: out n6.Vector2 Normalized_Position_17, WheelDelta_Out: out int WheelDelta_18, Client_Area_Out: out n6.Vector2 Client_Area_19, Sender_Out: out n2.Object Sender_20);
            var Output_23 = this.__p_AkusTeYJKxELlR7HuYWTA9.Update(Keyboard_Device_In: Keyboard_In, Pressed_Keys_Out: out n19.ImmutableHashSet<n18.Keys> Pressed_Keys_22);
            var Output_25 = this.__p_MML41Xl0MQnMe05vgwn2At.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_T4dvIRbOzoxNrvFNEb4jL5_0, Is_Down_Out: out bool Is_Down_24);
            var Output_27 = this.__p_Nq8PdmyVEXpNNR8ip1Wr7b.Update(Keys_In: Pressed_Keys_22, Key_Name_In: __pad_SWQ6QmhaoZaMdm3tOGhenG_1, Is_Down_Out: out bool Is_Down_26);
            var Output_28 = Left_Pressed_14 || Middle_Pressed_15;
            var Output_29 = Output_28 || Right_Pressed_16;
            var Output_30 = Output_29 || Is_Down_24;
            var Output_31 = Output_30 || Is_Down_26;
            bool Apply_32 = true;
            var Output_33 = Output_31;
            if (Apply_32)
            {
                var Output_34 = !Output_31;
                Output_33 = Output_34;
            }

            CameraState3d_Out = CameraState3d_9;
            Idle_Out = Output_33;
            n20.Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z that_35 = this;
            if (this.__GetContext__().IsImmutable)
                that_35 = Output_6 != this.__p_UcvgKlIBwhuOu0tQmqBPcN || Output_10 != this.__p_Rtq4vxmrYZ4PgIKj1bjyAK || Output_21 != this.__p_Rlr7Owy6U8bNzey9NPg13y || Output_23 != this.__p_AkusTeYJKxELlR7HuYWTA9 || Output_25 != this.__p_MML41Xl0MQnMe05vgwn2At || Output_27 != this.__p_Nq8PdmyVEXpNNR8ip1Wr7b ? new Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z(this)
                {__p_UcvgKlIBwhuOu0tQmqBPcN = Output_6, __p_Rtq4vxmrYZ4PgIKj1bjyAK = Output_10, __p_Rlr7Owy6U8bNzey9NPg13y = Output_21, __p_AkusTeYJKxELlR7HuYWTA9 = Output_23, __p_MML41Xl0MQnMe05vgwn2At = Output_25, __p_Nq8PdmyVEXpNNR8ip1Wr7b = Output_27} : that_35;
            else
            {
                this.__p_UcvgKlIBwhuOu0tQmqBPcN = Output_6;
                this.__p_Rtq4vxmrYZ4PgIKj1bjyAK = Output_10;
                this.__p_Rlr7Owy6U8bNzey9NPg13y = Output_21;
                this.__p_AkusTeYJKxELlR7HuYWTA9 = Output_23;
                this.__p_MML41Xl0MQnMe05vgwn2At = Output_25;
                this.__p_Nq8PdmyVEXpNNR8ip1Wr7b = Output_27;
            }

            return that_35;
        }

        public n20.Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "Rtq4vxmrYZ4PgIKj1bjyAK", 58371U);
            var Output_1 = n21.Camera_HKLB3PgmAVIMC1vhgpaagj.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "Rlr7Owy6U8bNzey9NPg13y", 58383U);
            var Output_3 = n24.MouseState_BNOhaxXysw1MZBzyJMI18t.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "MML41Xl0MQnMe05vgwn2At", 58395U);
            var Output_5 = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "AkusTeYJKxELlR7HuYWTA9", 58399U);
            var Output_7 = n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "Nq8PdmyVEXpNNR8ip1Wr7b", 58402U);
            var Output_9 = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "UcvgKlIBwhuOu0tQmqBPcN", 58431U);
            var Output_11 = n21.OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3.Create(Node_Context: Node_Context_10);
            n20.Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z that_12 = this;
            this.__p_Rtq4vxmrYZ4PgIKj1bjyAK = Output_1;
            this.__p_Rlr7Owy6U8bNzey9NPg13y = Output_3;
            this.__p_MML41Xl0MQnMe05vgwn2At = Output_5;
            this.__p_AkusTeYJKxELlR7HuYWTA9 = Output_7;
            this.__p_Nq8PdmyVEXpNNR8ip1Wr7b = Output_9;
            this.__p_UcvgKlIBwhuOu0tQmqBPcN = Output_11;
            return that_12;
        }

        public n20.Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z __CreateDefault__()
        {
            n20.Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z that_0 = this;
            this.__p_UcvgKlIBwhuOu0tQmqBPcN = n21.OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3.CreateDefault();
            this.__p_Rtq4vxmrYZ4PgIKj1bjyAK = n21.Camera_HKLB3PgmAVIMC1vhgpaagj.CreateDefault();
            this.__p_Rlr7Owy6U8bNzey9NPg13y = n24.MouseState_BNOhaxXysw1MZBzyJMI18t.CreateDefault();
            this.__p_AkusTeYJKxELlR7HuYWTA9 = n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.CreateDefault();
            this.__p_MML41Xl0MQnMe05vgwn2At = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_Nq8PdmyVEXpNNR8ip1Wr7b = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_UcvgKlIBwhuOu0tQmqBPcN);
            n1.CompilationHelper.SafeDispose(this.__p_Rtq4vxmrYZ4PgIKj1bjyAK);
            n1.CompilationHelper.SafeDispose(this.__p_Rlr7Owy6U8bNzey9NPg13y);
            n1.CompilationHelper.SafeDispose(this.__p_AkusTeYJKxELlR7HuYWTA9);
            n1.CompilationHelper.SafeDispose(this.__p_MML41Xl0MQnMe05vgwn2At);
            n1.CompilationHelper.SafeDispose(this.__p_Nq8PdmyVEXpNNR8ip1Wr7b);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 58369U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "T4dvIRbOzoxNrvFNEb4jL5", Name = "__slot_T4dvIRbOzoxNrvFNEb4jL5")]
        public static string __slot_T4dvIRbOzoxNrvFNEb4jL5 = "R";
        [n1.ElementAttribute(TracingId = 58370U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "SWQ6QmhaoZaMdm3tOGhenG", Name = "__slot_SWQ6QmhaoZaMdm3tOGhenG")]
        public static string __slot_SWQ6QmhaoZaMdm3tOGhenG = "ControlKey";
        [n1.ElementAttribute(TracingId = 58431U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "UcvgKlIBwhuOu0tQmqBPcN", Name = "OrbitCameraControls", IsManaged = true, IsAutoGenerated = true)]
        public n21.OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 __p_UcvgKlIBwhuOu0tQmqBPcN;
        [n1.ElementAttribute(TracingId = 58371U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Rtq4vxmrYZ4PgIKj1bjyAK", Name = "Camera", IsManaged = true, IsAutoGenerated = true)]
        public n21.Camera_HKLB3PgmAVIMC1vhgpaagj __p_Rtq4vxmrYZ4PgIKj1bjyAK;
        [n1.ElementAttribute(TracingId = 58383U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Rlr7Owy6U8bNzey9NPg13y", Name = "MouseState", IsManaged = true, IsAutoGenerated = true)]
        public n24.MouseState_BNOhaxXysw1MZBzyJMI18t __p_Rlr7Owy6U8bNzey9NPg13y;
        [n1.ElementAttribute(TracingId = 58399U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "AkusTeYJKxELlR7HuYWTA9", Name = "KeyboardState", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_AkusTeYJKxELlR7HuYWTA9;
        [n1.ElementAttribute(TracingId = 58395U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "MML41Xl0MQnMe05vgwn2At", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_MML41Xl0MQnMe05vgwn2At;
        [n1.ElementAttribute(TracingId = 58402U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Nq8PdmyVEXpNNR8ip1Wr7b", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Nq8PdmyVEXpNNR8ip1Wr7b;
        static Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z()
        {
        }

        public Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z(Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z other): base(other)
        {
            this.__p_UcvgKlIBwhuOu0tQmqBPcN = other.__p_UcvgKlIBwhuOu0tQmqBPcN;
            this.__p_Rtq4vxmrYZ4PgIKj1bjyAK = other.__p_Rtq4vxmrYZ4PgIKj1bjyAK;
            this.__p_Rlr7Owy6U8bNzey9NPg13y = other.__p_Rlr7Owy6U8bNzey9NPg13y;
            this.__p_AkusTeYJKxELlR7HuYWTA9 = other.__p_AkusTeYJKxELlR7HuYWTA9;
            this.__p_MML41Xl0MQnMe05vgwn2At = other.__p_MML41Xl0MQnMe05vgwn2At;
            this.__p_Nq8PdmyVEXpNNR8ip1Wr7b = other.__p_Nq8PdmyVEXpNNR8ip1Wr7b;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UcvgKlIBwhuOu0tQmqBPcN", in __p_UcvgKlIBwhuOu0tQmqBPcN), n1.CompilationHelper.GetValueOrExisting(values, "__p_Rtq4vxmrYZ4PgIKj1bjyAK", in __p_Rtq4vxmrYZ4PgIKj1bjyAK), n1.CompilationHelper.GetValueOrExisting(values, "__p_Rlr7Owy6U8bNzey9NPg13y", in __p_Rlr7Owy6U8bNzey9NPg13y), n1.CompilationHelper.GetValueOrExisting(values, "__p_AkusTeYJKxELlR7HuYWTA9", in __p_AkusTeYJKxELlR7HuYWTA9), n1.CompilationHelper.GetValueOrExisting(values, "__p_MML41Xl0MQnMe05vgwn2At", in __p_MML41Xl0MQnMe05vgwn2At), n1.CompilationHelper.GetValueOrExisting(values, "__p_Nq8PdmyVEXpNNR8ip1Wr7b", in __p_Nq8PdmyVEXpNNR8ip1Wr7b));
        }

        internal Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z __WITH__(n21.OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 __p_UcvgKlIBwhuOu0tQmqBPcN, n21.Camera_HKLB3PgmAVIMC1vhgpaagj __p_Rtq4vxmrYZ4PgIKj1bjyAK, n24.MouseState_BNOhaxXysw1MZBzyJMI18t __p_Rlr7Owy6U8bNzey9NPg13y, n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_AkusTeYJKxELlR7HuYWTA9, n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_MML41Xl0MQnMe05vgwn2At, n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Nq8PdmyVEXpNNR8ip1Wr7b)
        {
            n20.Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_UcvgKlIBwhuOu0tQmqBPcN != this.__p_UcvgKlIBwhuOu0tQmqBPcN || __p_Rtq4vxmrYZ4PgIKj1bjyAK != this.__p_Rtq4vxmrYZ4PgIKj1bjyAK || __p_Rlr7Owy6U8bNzey9NPg13y != this.__p_Rlr7Owy6U8bNzey9NPg13y || __p_AkusTeYJKxELlR7HuYWTA9 != this.__p_AkusTeYJKxELlR7HuYWTA9 || __p_MML41Xl0MQnMe05vgwn2At != this.__p_MML41Xl0MQnMe05vgwn2At || __p_Nq8PdmyVEXpNNR8ip1Wr7b != this.__p_Nq8PdmyVEXpNNR8ip1Wr7b ? new Camera_Orbit_SNtf6GIgOyxLiTq5x6Kk4z(this)
                {__p_UcvgKlIBwhuOu0tQmqBPcN = __p_UcvgKlIBwhuOu0tQmqBPcN, __p_Rtq4vxmrYZ4PgIKj1bjyAK = __p_Rtq4vxmrYZ4PgIKj1bjyAK, __p_Rlr7Owy6U8bNzey9NPg13y = __p_Rlr7Owy6U8bNzey9NPg13y, __p_AkusTeYJKxELlR7HuYWTA9 = __p_AkusTeYJKxELlR7HuYWTA9, __p_MML41Xl0MQnMe05vgwn2At = __p_MML41Xl0MQnMe05vgwn2At, __p_Nq8PdmyVEXpNNR8ip1Wr7b = __p_Nq8PdmyVEXpNNR8ip1Wr7b} : that_0;
            else
            {
                this.__p_UcvgKlIBwhuOu0tQmqBPcN = __p_UcvgKlIBwhuOu0tQmqBPcN;
                this.__p_Rtq4vxmrYZ4PgIKj1bjyAK = __p_Rtq4vxmrYZ4PgIKj1bjyAK;
                this.__p_Rlr7Owy6U8bNzey9NPg13y = __p_Rlr7Owy6U8bNzey9NPg13y;
                this.__p_AkusTeYJKxELlR7HuYWTA9 = __p_AkusTeYJKxELlR7HuYWTA9;
                this.__p_MML41Xl0MQnMe05vgwn2At = __p_MML41Xl0MQnMe05vgwn2At;
                this.__p_Nq8PdmyVEXpNNR8ip1Wr7b = __p_Nq8PdmyVEXpNNR8ip1Wr7b;
            }

            return that_0;
        }
    }
}

namespace _VL_Cameras_.Editors._3D.Advanced.Experimental
{
    [n1.ElementAttribute(TracingId = 58504U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "HKLB3PgmAVIMC1vhgpaagj", Name = "Camera_HKLB3PgmAVIMC1vhgpaagj")]
    [n2.SerializableAttribute]
    public class Camera_HKLB3PgmAVIMC1vhgpaagj : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n21.Camera_HKLB3PgmAVIMC1vhgpaagj Create(n1.NodeContext Node_Context)
        {
            var instance = new Camera_HKLB3PgmAVIMC1vhgpaagj(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n21.Camera_HKLB3PgmAVIMC1vhgpaagj CreateDefault()
        {
            var instance = new Camera_HKLB3PgmAVIMC1vhgpaagj(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n21.Camera_HKLB3PgmAVIMC1vhgpaagj Update(n6.Vector3 Initial_Interest_In, [n4.SerializedDefaultValueAttribute("1", false)] float Initial_Longitude_In, float Initial_Latitude_In, float Initial_Distance_In, float Initial_FOV_In, [n4.SerializedDefaultValueAttribute("0.01", false)] float Near_Plane_In, [n4.SerializedDefaultValueAttribute("100", false)] float Far_Plane_In, n21.CameraControls_R CameraControls3d_In, bool Renderer_Hovered_In, bool Reset_In, out n21.CameraState_R CameraState3d_Out)
        {
            float __auto_0 = this.Distance;
            float __auto_1 = this.Longitude;
            float __pad_E7sSI5WHQxdMo2QuCX3A6J_2 = __slot_E7sSI5WHQxdMo2QuCX3A6J;
            float __auto_3 = this.Latitude;
            float __pad_CXaKQtPvHmiOxb8sxEGeHK_4 = __slot_CXaKQtPvHmiOxb8sxEGeHK;
            float __pad_T847zBB3pdgL2gTa14fuVP_5 = __slot_T847zBB3pdgL2gTa14fuVP;
            float __pad_H4zGKI5CXUQLX57hMqe4tJ_6 = __slot_H4zGKI5CXUQLX57hMqe4tJ;
            float __pad_Ah2HubJVE8kNTuryLTji2d_7 = __slot_Ah2HubJVE8kNTuryLTji2d;
            float __auto_8 = this.FOV;
            int __pad_S6sshKGnDIrL0fj18sjaYE_9 = __slot_S6sshKGnDIrL0fj18sjaYE;
            float __pad_PRva8n2fu5yNXaMyvvGVSW_10 = __slot_PRva8n2fu5yNXaMyvvGVSW;
            float __pad_F6xkoKEp24sLCwCRfqYwGc_11 = __slot_F6xkoKEp24sLCwCRfqYwGc;
            bool __auto_12 = this.Initialize;
            n6.Vector3 __auto_13 = this.Interest;
            bool __pad_Dnp0YxX8fR9OtmME9r82dX_14 = __slot_Dnp0YxX8fR9OtmME9r82dX;
            var Output_22 = CameraControls3d_In.Split(Longitude_Delta_Out: out float Longitude_Delta_15, Latitude_Delta_Out: out float Latitude_Delta_16, FOV_Delta_Out: out float FOV_Delta_17, Interest_Delta_Out: out n6.Vector2 Interest_Delta_18, Distance_Delta_Out: out float Distance_Delta_19, Reset_Out: out bool Reset_20, Idle_Out: out bool Idle_21);
            var Output_23 = __auto_12 || Reset_20;
            var Output_24 = Output_23 || Reset_In;
            var Output_25 = this.__p_JWQsAm25TI1NuwYqpL2jnC;
            if (Output_24)
            {
                Output_25 = this.__p_JWQsAm25TI1NuwYqpL2jnC.Flip();
            }

            var Output_28 = this.__p_Bmkyq23rBOJPVsbfJmWn6G.Update(Value_In: Idle_21, Up_Edge_Out: out bool Up_Edge_26, Down_Edge_Out: out bool Down_Edge_27);
            var Output_29 = Output_25;
            if (Down_Edge_27)
            {
                Output_29 = Output_25.Reset();
            }

            var Output_31 = Output_29.GetValue(Value_Out: out bool Value_30);
            n15._Operations_.Switch_Boolean<n6.Vector3>(Condition_In: Value_30, Input_In: __auto_13, Input_2_In: Initial_Interest_In, Output_Out: out n6.Vector3 Output_32);
            n15._Operations_.Switch_Boolean<float>(Condition_In: Value_30, Input_In: __auto_0, Input_2_In: Initial_Distance_In, Output_Out: out float Output_33);
            var Output_34 = Output_33 + Distance_Delta_19;
            var Output_35 = Initial_Longitude_In * __pad_E7sSI5WHQxdMo2QuCX3A6J_2;
            n15._Operations_.Switch_Boolean<float>(Condition_In: Value_30, Input_In: __auto_1, Input_2_In: Output_35, Output_Out: out float Output_36);
            var Output_37 = Output_36 + Longitude_Delta_15;
            float __auto_38 = Output_37;
            n15._Operations_.Switch_Boolean<float>(Condition_In: Value_30, Input_In: __auto_3, Input_2_In: Initial_Latitude_In, Output_Out: out float Output_39);
            var Output_40 = Latitude_Delta_16 * __pad_CXaKQtPvHmiOxb8sxEGeHK_4;
            var Output_41 = Output_39 + Output_40;
            n13._Operations_.Clamp<float, n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Input_In: Output_41, Minimum_In: __pad_T847zBB3pdgL2gTa14fuVP_5, Maximum_In: __pad_H4zGKI5CXUQLX57hMqe4tJ_6, Output_Out: out float Output_42);
            float Z_43 = 0F;
            var Output_44 = new n6.Vector3(x: Output_42, y: Output_37, z: Z_43);
            float __auto_45 = Output_42;
            n6.Matrix Input_46 = n10._Operations_.CreateDefault();
            n26._Operations_.Rotate(Input_In: Input_46, Rotation_In: Output_44, Output_Out: out n6.Matrix Output_47);
            n6.Matrix.Invert(value: ref Output_47, result: out n6.Matrix Output_48);
            n14.Vector2Nodes.Scale(input: ref Interest_Delta_18, scalar: __pad_Ah2HubJVE8kNTuryLTji2d_7, output: out n6.Vector2 Output_49);
            float Z_50 = 0F;
            var Result_51 = n14.Vector2Nodes.ToVector3(input: ref Output_49, z: Z_50);
            bool Apply_52 = true;
            var Output_53 = Result_51;
            if (Apply_52)
            {
                n14.Vector3Nodes.Scale(input: ref Result_51, scalar: Output_34, output: out n6.Vector3 Output_54);
                Output_53 = Output_54;
            }

            bool Apply_55 = true;
            var Output_56 = Output_53;
            if (Apply_55)
            {
                n6.Vector3.TransformCoordinate(coordinate: ref Output_53, transform: ref Output_47, result: out n6.Vector3 Output_57);
                Output_56 = Output_57;
            }

            n6.Vector3.Add(left: ref Output_32, right: ref Output_56, result: out n6.Vector3 Output_58);
            n14.Vector3Nodes.Scale(input: ref Output_58, scalar: __pad_F6xkoKEp24sLCwCRfqYwGc_11, output: out n6.Vector3 Output_59);
            n6.Matrix.Translation(value: ref Output_59, result: out n6.Matrix Result_60);
            n6.Matrix.Multiply(left: ref Result_60, right: ref Output_48, result: out n6.Matrix Output_61);
            float __auto_62 = Output_34;
            float X_63 = 0F;
            float Y_64 = 0F;
            var Output_65 = new n6.Vector3(x: X_63, y: Y_64, z: Output_34);
            n6.Matrix.Translation(value: ref Output_65, result: out n6.Matrix Result_66);
            n6.Matrix.Multiply(left: ref Output_61, right: ref Result_66, result: out n6.Matrix Output_67);
            n15._Operations_.Switch_Boolean<float>(Condition_In: Value_30, Input_In: __auto_8, Input_2_In: Initial_FOV_In, Output_Out: out float Output_68);
            var Output_69 = Output_68 + FOV_Delta_17;
            n14.MatrixNodes.PerspectiveFOV(FOV: Output_69, aspect: __pad_PRva8n2fu5yNXaMyvvGVSW_10, zNear: Near_Plane_In, zFar: Far_Plane_In, result: out n6.Matrix Result_70);
            n6.Matrix.Multiply(left: ref Output_67, right: ref Result_70, result: out n6.Matrix Output_71);
            float __auto_72 = Output_69;
            n6.Matrix.Invert(value: ref Output_67, result: out n6.Matrix Output_73);
            n6.Vector3 Input_74 = n28._Operations_.CreateDefault();
            n6.Vector3.TransformCoordinate(coordinate: ref Input_74, transform: ref Output_73, result: out n6.Vector3 Output_75);
            bool Four_Rooms_76 = false;
            bool Join_77 = true;
            var Output_78 = this.__p_LGX4Ibp9NTuPBAOaFVGyiC;
            if (Join_77)
            {
                Output_78 = this.__p_LGX4Ibp9NTuPBAOaFVGyiC.Join(View_Projection_In: Output_71, View_In: Output_67, Projection_In: Result_70, Inverse_View_In: Output_73, Position_In: Output_75, Interest_In: Output_58, FOV_In: Output_69, Distance_In: Output_34, Four_Rooms_In: Four_Rooms_76, Active_Viewport_In: __pad_S6sshKGnDIrL0fj18sjaYE_9, Renderer_Hovered_In: Renderer_Hovered_In, Idle_In: Idle_21);
            }

            n6.Vector3 __auto_79 = Output_58;
            bool __auto_80 = __pad_Dnp0YxX8fR9OtmME9r82dX_14;
            CameraState3d_Out = Output_78;
            n21.Camera_HKLB3PgmAVIMC1vhgpaagj that_81 = this;
            if (this.__GetContext__().IsImmutable)
                that_81 = Output_31 != this.__p_JWQsAm25TI1NuwYqpL2jnC || Output_28 != this.__p_Bmkyq23rBOJPVsbfJmWn6G || Output_37 != this.Longitude || Output_42 != this.Latitude || Output_34 != this.Distance || Output_69 != this.FOV || Output_78 != this.__p_LGX4Ibp9NTuPBAOaFVGyiC || Output_58 != this.Interest || __pad_Dnp0YxX8fR9OtmME9r82dX_14 != this.Initialize ? new Camera_HKLB3PgmAVIMC1vhgpaagj(this)
                {__p_JWQsAm25TI1NuwYqpL2jnC = Output_31, __p_Bmkyq23rBOJPVsbfJmWn6G = Output_28, Longitude = Output_37, Latitude = Output_42, Distance = Output_34, FOV = Output_69, __p_LGX4Ibp9NTuPBAOaFVGyiC = Output_78, Interest = Output_58, Initialize = __pad_Dnp0YxX8fR9OtmME9r82dX_14} : that_81;
            else
            {
                this.__p_JWQsAm25TI1NuwYqpL2jnC = Output_31;
                this.__p_Bmkyq23rBOJPVsbfJmWn6G = Output_28;
                this.Longitude = Output_37;
                this.Latitude = Output_42;
                this.Distance = Output_34;
                this.FOV = Output_69;
                this.__p_LGX4Ibp9NTuPBAOaFVGyiC = Output_78;
                this.Interest = Output_58;
                this.Initialize = __pad_Dnp0YxX8fR9OtmME9r82dX_14;
            }

            return that_81;
        }

        public n21.Camera_HKLB3PgmAVIMC1vhgpaagj __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            bool __pad_DG1GIeUrYkJNbBfNEqZAdW_0 = __slot_DG1GIeUrYkJNbBfNEqZAdW;
            bool __auto_1 = __pad_DG1GIeUrYkJNbBfNEqZAdW_0;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "JWQsAm25TI1NuwYqpL2jnC", 59207U);
            var Output_3 = n16.Toggle_NRtjXBFlZv8LkW1dAEOgnz.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "Bmkyq23rBOJPVsbfJmWn6G", 59211U);
            var Output_5 = n16.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "LGX4Ibp9NTuPBAOaFVGyiC", 59279U);
            var Output_7 = n21.CameraState_R.Create(Node_Context: Node_Context_6);
            n21.Camera_HKLB3PgmAVIMC1vhgpaagj that_8 = this;
            this.Latitude = 0F;
            this.Longitude = 0F;
            this.FOV = 0F;
            this.Distance = 0F;
            this.Interest = n28._Operations_.CreateDefault();
            this.Initialize = __pad_DG1GIeUrYkJNbBfNEqZAdW_0;
            this.__p_JWQsAm25TI1NuwYqpL2jnC = Output_3;
            this.__p_Bmkyq23rBOJPVsbfJmWn6G = Output_5;
            this.__p_LGX4Ibp9NTuPBAOaFVGyiC = Output_7;
            return that_8;
        }

        public n21.Camera_HKLB3PgmAVIMC1vhgpaagj __CreateDefault__()
        {
            n21.Camera_HKLB3PgmAVIMC1vhgpaagj that_0 = this;
            this.Latitude = 0F;
            this.Longitude = 0F;
            this.FOV = 0F;
            this.Distance = 0F;
            this.Interest = n28._Operations_.CreateDefault();
            this.Initialize = false;
            this.__p_JWQsAm25TI1NuwYqpL2jnC = n16.Toggle_NRtjXBFlZv8LkW1dAEOgnz.CreateDefault();
            this.__p_Bmkyq23rBOJPVsbfJmWn6G = n16.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_LGX4Ibp9NTuPBAOaFVGyiC = n21.CameraState_R.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_JWQsAm25TI1NuwYqpL2jnC);
            n1.CompilationHelper.SafeDispose(this.__p_Bmkyq23rBOJPVsbfJmWn6G);
            n1.CompilationHelper.SafeDispose(this.__p_LGX4Ibp9NTuPBAOaFVGyiC);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 58506U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Jp6srr5KnAEL7JTbvj39WZ", Name = "Latitude")]
        public float Latitude;
        [n1.ElementAttribute(TracingId = 58508U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "GoPGljsGNXNNStU0jNTBfA", Name = "Longitude")]
        public float Longitude;
        [n1.ElementAttribute(TracingId = 58510U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "TcJgTcZet4pLgUkk01QBMz", Name = "FOV")]
        public float FOV;
        [n1.ElementAttribute(TracingId = 58511U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "ReTE7VgiisEOXN7ctVvPOk", Name = "Distance")]
        public float Distance;
        [n1.ElementAttribute(TracingId = 58513U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Juq7oqAWhE8MDwi0KTKtEX", Name = "Interest")]
        public n6.Vector3 Interest;
        [n1.ElementAttribute(TracingId = 58514U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "DnlvDp0hMDFMl0HdJ0oLPJ", Name = "Initialize")]
        public bool Initialize;
        [n1.ElementAttribute(TracingId = 58592U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "PRva8n2fu5yNXaMyvvGVSW", Name = "__slot_PRva8n2fu5yNXaMyvvGVSW")]
        public static float __slot_PRva8n2fu5yNXaMyvvGVSW = 1F;
        [n1.ElementAttribute(TracingId = 58595U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "DG1GIeUrYkJNbBfNEqZAdW", Name = "__slot_DG1GIeUrYkJNbBfNEqZAdW")]
        public static bool __slot_DG1GIeUrYkJNbBfNEqZAdW = true;
        [n1.ElementAttribute(TracingId = 58598U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Dnp0YxX8fR9OtmME9r82dX", Name = "__slot_Dnp0YxX8fR9OtmME9r82dX")]
        public static bool __slot_Dnp0YxX8fR9OtmME9r82dX = false;
        [n1.ElementAttribute(TracingId = 58602U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "T847zBB3pdgL2gTa14fuVP", Name = "__slot_T847zBB3pdgL2gTa14fuVP")]
        public static float __slot_T847zBB3pdgL2gTa14fuVP = -0.249899909F;
        [n1.ElementAttribute(TracingId = 58604U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "H4zGKI5CXUQLX57hMqe4tJ", Name = "__slot_H4zGKI5CXUQLX57hMqe4tJ")]
        public static float __slot_H4zGKI5CXUQLX57hMqe4tJ = 0.249900028F;
        [n1.ElementAttribute(TracingId = 58610U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "S6sshKGnDIrL0fj18sjaYE", Name = "__slot_S6sshKGnDIrL0fj18sjaYE")]
        public static int __slot_S6sshKGnDIrL0fj18sjaYE = -1;
        [n1.ElementAttribute(TracingId = 58614U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "CXaKQtPvHmiOxb8sxEGeHK", Name = "__slot_CXaKQtPvHmiOxb8sxEGeHK")]
        public static float __slot_CXaKQtPvHmiOxb8sxEGeHK = -1F;
        [n1.ElementAttribute(TracingId = 58617U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "F6xkoKEp24sLCwCRfqYwGc", Name = "__slot_F6xkoKEp24sLCwCRfqYwGc")]
        public static float __slot_F6xkoKEp24sLCwCRfqYwGc = -1F;
        [n1.ElementAttribute(TracingId = 58619U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "E7sSI5WHQxdMo2QuCX3A6J", Name = "__slot_E7sSI5WHQxdMo2QuCX3A6J")]
        public static float __slot_E7sSI5WHQxdMo2QuCX3A6J = -1F;
        [n1.ElementAttribute(TracingId = 58621U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Ah2HubJVE8kNTuryLTji2d", Name = "__slot_Ah2HubJVE8kNTuryLTji2d")]
        public static float __slot_Ah2HubJVE8kNTuryLTji2d = -1F;
        [n1.ElementAttribute(TracingId = 59207U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "JWQsAm25TI1NuwYqpL2jnC", Name = "Toggle", IsManaged = true, IsAutoGenerated = true)]
        public n16.Toggle_NRtjXBFlZv8LkW1dAEOgnz __p_JWQsAm25TI1NuwYqpL2jnC;
        [n1.ElementAttribute(TracingId = 59211U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Bmkyq23rBOJPVsbfJmWn6G", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n16.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Bmkyq23rBOJPVsbfJmWn6G;
        [n1.ElementAttribute(TracingId = 59279U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "LGX4Ibp9NTuPBAOaFVGyiC", Name = "CameraState", IsManaged = true, IsAutoGenerated = true)]
        public n21.CameraState_R __p_LGX4Ibp9NTuPBAOaFVGyiC;
        static Camera_HKLB3PgmAVIMC1vhgpaagj()
        {
        }

        public Camera_HKLB3PgmAVIMC1vhgpaagj(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Camera_HKLB3PgmAVIMC1vhgpaagj(Camera_HKLB3PgmAVIMC1vhgpaagj other): base(other)
        {
            this.Latitude = other.Latitude;
            this.Longitude = other.Longitude;
            this.FOV = other.FOV;
            this.Distance = other.Distance;
            this.Interest = other.Interest;
            this.Initialize = other.Initialize;
            this.__p_JWQsAm25TI1NuwYqpL2jnC = other.__p_JWQsAm25TI1NuwYqpL2jnC;
            this.__p_Bmkyq23rBOJPVsbfJmWn6G = other.__p_Bmkyq23rBOJPVsbfJmWn6G;
            this.__p_LGX4Ibp9NTuPBAOaFVGyiC = other.__p_LGX4Ibp9NTuPBAOaFVGyiC;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Latitude", in Latitude), n1.CompilationHelper.GetValueOrExisting(values, "Longitude", in Longitude), n1.CompilationHelper.GetValueOrExisting(values, "FOV", in FOV), n1.CompilationHelper.GetValueOrExisting(values, "Distance", in Distance), n1.CompilationHelper.GetValueOrExisting(values, "Interest", in Interest), n1.CompilationHelper.GetValueOrExisting(values, "Initialize", in Initialize), n1.CompilationHelper.GetValueOrExisting(values, "__p_JWQsAm25TI1NuwYqpL2jnC", in __p_JWQsAm25TI1NuwYqpL2jnC), n1.CompilationHelper.GetValueOrExisting(values, "__p_Bmkyq23rBOJPVsbfJmWn6G", in __p_Bmkyq23rBOJPVsbfJmWn6G), n1.CompilationHelper.GetValueOrExisting(values, "__p_LGX4Ibp9NTuPBAOaFVGyiC", in __p_LGX4Ibp9NTuPBAOaFVGyiC));
        }

        internal Camera_HKLB3PgmAVIMC1vhgpaagj __WITH__(float Latitude, float Longitude, float FOV, float Distance, n6.Vector3 Interest, bool Initialize, n16.Toggle_NRtjXBFlZv8LkW1dAEOgnz __p_JWQsAm25TI1NuwYqpL2jnC, n16.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Bmkyq23rBOJPVsbfJmWn6G, n21.CameraState_R __p_LGX4Ibp9NTuPBAOaFVGyiC)
        {
            n21.Camera_HKLB3PgmAVIMC1vhgpaagj that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Latitude != this.Latitude || Longitude != this.Longitude || FOV != this.FOV || Distance != this.Distance || Interest != this.Interest || Initialize != this.Initialize || __p_JWQsAm25TI1NuwYqpL2jnC != this.__p_JWQsAm25TI1NuwYqpL2jnC || __p_Bmkyq23rBOJPVsbfJmWn6G != this.__p_Bmkyq23rBOJPVsbfJmWn6G || __p_LGX4Ibp9NTuPBAOaFVGyiC != this.__p_LGX4Ibp9NTuPBAOaFVGyiC ? new Camera_HKLB3PgmAVIMC1vhgpaagj(this)
                {Latitude = Latitude, Longitude = Longitude, FOV = FOV, Distance = Distance, Interest = Interest, Initialize = Initialize, __p_JWQsAm25TI1NuwYqpL2jnC = __p_JWQsAm25TI1NuwYqpL2jnC, __p_Bmkyq23rBOJPVsbfJmWn6G = __p_Bmkyq23rBOJPVsbfJmWn6G, __p_LGX4Ibp9NTuPBAOaFVGyiC = __p_LGX4Ibp9NTuPBAOaFVGyiC} : that_0;
            else
            {
                this.Latitude = Latitude;
                this.Longitude = Longitude;
                this.FOV = FOV;
                this.Distance = Distance;
                this.Interest = Interest;
                this.Initialize = Initialize;
                this.__p_JWQsAm25TI1NuwYqpL2jnC = __p_JWQsAm25TI1NuwYqpL2jnC;
                this.__p_Bmkyq23rBOJPVsbfJmWn6G = __p_Bmkyq23rBOJPVsbfJmWn6G;
                this.__p_LGX4Ibp9NTuPBAOaFVGyiC = __p_LGX4Ibp9NTuPBAOaFVGyiC;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 59378U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "TnZ4T1hma1PPGP2khAxWhw", Name = "CameraControls_R")]
    [n2.SerializableAttribute]
    public class CameraControls_R : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n21.CameraControls_R Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new CameraControls_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n21.CameraControls_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n21.CameraControls_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new CameraControls_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n21.CameraControls_R __DEFAULT__;
        public n21.CameraControls_R Join(float Longitude_Delta_In, float Latitude_Delta_In, float FOV_Delta_In, n6.Vector2 Interest_Delta_In, float Distance_Delta_In, bool Reset_In, bool Idle_In)
        {
            float __auto_0 = Longitude_Delta_In;
            float __auto_1 = Latitude_Delta_In;
            float __auto_2 = FOV_Delta_In;
            n6.Vector2 __auto_3 = Interest_Delta_In;
            float __auto_4 = Distance_Delta_In;
            bool __auto_5 = Reset_In;
            bool Apply_6 = true;
            var Output_7 = Idle_In;
            if (Apply_6)
            {
                var Output_8 = !Idle_In;
                Output_7 = Output_8;
            }

            bool __auto_9 = Output_7;
            n21.CameraControls_R that_10 = this;
            that_10 = Longitude_Delta_In != this.Longitude_Delta || Latitude_Delta_In != this.Latitude_Delta || FOV_Delta_In != this.FOV_Delta || Interest_Delta_In != this.Interest_Delta || Distance_Delta_In != this.Distance_Delta || Reset_In != this.Reset || Output_7 != this.Not_Idle ? new CameraControls_R(this)
            {Longitude_Delta = Longitude_Delta_In, Latitude_Delta = Latitude_Delta_In, FOV_Delta = FOV_Delta_In, Interest_Delta = Interest_Delta_In, Distance_Delta = Distance_Delta_In, Reset = Reset_In, Not_Idle = Output_7} : that_10;
            return that_10;
        }

        public n21.CameraControls_R Split(out float Longitude_Delta_Out, out float Latitude_Delta_Out, out float FOV_Delta_Out, out n6.Vector2 Interest_Delta_Out, out float Distance_Delta_Out, out bool Reset_Out, out bool Idle_Out)
        {
            float __auto_0 = this.Longitude_Delta;
            float __auto_1 = this.Latitude_Delta;
            float __auto_2 = this.FOV_Delta;
            n6.Vector2 __auto_3 = this.Interest_Delta;
            float __auto_4 = this.Distance_Delta;
            bool __auto_5 = this.Reset;
            bool __auto_6 = this.Not_Idle;
            bool Apply_7 = true;
            var Output_8 = __auto_6;
            if (Apply_7)
            {
                var Output_9 = !__auto_6;
                Output_8 = Output_9;
            }

            Longitude_Delta_Out = __auto_0;
            Latitude_Delta_Out = __auto_1;
            FOV_Delta_Out = __auto_2;
            Interest_Delta_Out = __auto_3;
            Distance_Delta_Out = __auto_4;
            Reset_Out = __auto_5;
            Idle_Out = Output_8;
            return this;
        }

        public n21.CameraControls_R Combine(float Longitude_Delta_In, float Latitude_Delta_In, float FOV_Delta_In, n6.Vector2 Interest_Delta_In, float Distance_Delta_In, bool Reset_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Idle_In)
        {
            float __auto_0 = this.Longitude_Delta;
            float __auto_1 = this.Latitude_Delta;
            float __auto_2 = this.FOV_Delta;
            n6.Vector2 __auto_3 = this.Interest_Delta;
            float __auto_4 = this.Distance_Delta;
            bool __auto_5 = this.Reset;
            bool __auto_6 = this.Not_Idle;
            bool Apply_7 = true;
            var Output_8 = Longitude_Delta_In;
            if (Apply_7)
            {
                var Output_9 = Longitude_Delta_In + __auto_0;
                Output_8 = Output_9;
            }

            float __auto_10 = Output_8;
            bool Apply_11 = true;
            var Output_12 = Latitude_Delta_In;
            if (Apply_11)
            {
                var Output_13 = Latitude_Delta_In + __auto_1;
                Output_12 = Output_13;
            }

            float __auto_14 = Output_12;
            bool Apply_15 = true;
            var Output_16 = FOV_Delta_In;
            if (Apply_15)
            {
                var Output_17 = FOV_Delta_In + __auto_2;
                Output_16 = Output_17;
            }

            float __auto_18 = Output_16;
            bool Apply_19 = true;
            var Output_20 = Interest_Delta_In;
            if (Apply_19)
            {
                n6.Vector2.Add(left: ref Interest_Delta_In, right: ref __auto_3, result: out n6.Vector2 Output_21);
                Output_20 = Output_21;
            }

            n6.Vector2 __auto_22 = Output_20;
            bool Apply_23 = true;
            var Output_24 = Distance_Delta_In;
            if (Apply_23)
            {
                var Output_25 = Distance_Delta_In + __auto_4;
                Output_24 = Output_25;
            }

            float __auto_26 = Output_24;
            bool Apply_27 = true;
            var Output_28 = Reset_In;
            if (Apply_27)
            {
                var Output_29 = Reset_In || __auto_5;
                Output_28 = Output_29;
            }

            bool __auto_30 = Output_28;
            bool Apply_31 = true;
            var Output_32 = __auto_6;
            if (Apply_31)
            {
                var Output_33 = !__auto_6;
                Output_32 = Output_33;
            }

            bool Apply_34 = true;
            var Output_35 = Idle_In;
            if (Apply_34)
            {
                var Output_36 = Idle_In && Output_32;
                Output_35 = Output_36;
            }

            bool Apply_37 = true;
            var Output_38 = Output_35;
            if (Apply_37)
            {
                var Output_39 = !Output_35;
                Output_38 = Output_39;
            }

            bool __auto_40 = Output_38;
            n21.CameraControls_R that_41 = this;
            that_41 = Output_8 != this.Longitude_Delta || Output_12 != this.Latitude_Delta || Output_16 != this.FOV_Delta || Output_20 != this.Interest_Delta || Output_24 != this.Distance_Delta || Output_28 != this.Reset || Output_38 != this.Not_Idle ? new CameraControls_R(this)
            {Longitude_Delta = Output_8, Latitude_Delta = Output_12, FOV_Delta = Output_16, Interest_Delta = Output_20, Distance_Delta = Output_24, Reset = Output_28, Not_Idle = Output_38} : that_41;
            return that_41;
        }

        public n21.CameraControls_R __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n21.CameraControls_R that_0 = this;
            this.Longitude_Delta = 0F;
            this.Latitude_Delta = 0F;
            this.FOV_Delta = 0F;
            this.Interest_Delta = n17._Operations_.CreateDefault();
            this.Distance_Delta = 0F;
            this.Reset = false;
            this.Not_Idle = false;
            return that_0;
        }

        public n21.CameraControls_R __CreateDefault__()
        {
            n21.CameraControls_R that_0 = this;
            this.Longitude_Delta = 0F;
            this.Latitude_Delta = 0F;
            this.FOV_Delta = 0F;
            this.Interest_Delta = n17._Operations_.CreateDefault();
            this.Distance_Delta = 0F;
            this.Reset = false;
            this.Not_Idle = false;
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

        [n1.ElementAttribute(TracingId = 59380U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "V8dWdLIU14jMGbNfEAm5Po", Name = "Longitude Delta")]
        public float Longitude_Delta;
        [n1.ElementAttribute(TracingId = 59381U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "GAkbCT5kMpfN2oS6sUcquR", Name = "Latitude Delta")]
        public float Latitude_Delta;
        [n1.ElementAttribute(TracingId = 59382U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "NlSbbxsrGwLPseprPCkgGH", Name = "FOV Delta")]
        public float FOV_Delta;
        [n1.ElementAttribute(TracingId = 59383U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "CcEJHbs2zCVPqWNRWN1Ws4", Name = "Interest Delta")]
        public n6.Vector2 Interest_Delta;
        [n1.ElementAttribute(TracingId = 59384U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "AbMKOT2krA4MLd8gtw0Pb8", Name = "Distance Delta")]
        public float Distance_Delta;
        [n1.ElementAttribute(TracingId = 59385U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Mg8OmJKocZRM6i7uipROtM", Name = "Reset")]
        public bool Reset;
        [n1.ElementAttribute(TracingId = 59386U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "N7XliBYW10wPlqHR78wO5R", Name = "Not Idle")]
        public bool Not_Idle;
        public CameraControls_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CameraControls_R(CameraControls_R other): base(other)
        {
            this.Longitude_Delta = other.Longitude_Delta;
            this.Latitude_Delta = other.Latitude_Delta;
            this.FOV_Delta = other.FOV_Delta;
            this.Interest_Delta = other.Interest_Delta;
            this.Distance_Delta = other.Distance_Delta;
            this.Reset = other.Reset;
            this.Not_Idle = other.Not_Idle;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Longitude_Delta", in Longitude_Delta), n1.CompilationHelper.GetValueOrExisting(values, "Latitude_Delta", in Latitude_Delta), n1.CompilationHelper.GetValueOrExisting(values, "FOV_Delta", in FOV_Delta), n1.CompilationHelper.GetValueOrExisting(values, "Interest_Delta", in Interest_Delta), n1.CompilationHelper.GetValueOrExisting(values, "Distance_Delta", in Distance_Delta), n1.CompilationHelper.GetValueOrExisting(values, "Reset", in Reset), n1.CompilationHelper.GetValueOrExisting(values, "Not_Idle", in Not_Idle));
        }

        internal CameraControls_R __WITH__(float Longitude_Delta, float Latitude_Delta, float FOV_Delta, n6.Vector2 Interest_Delta, float Distance_Delta, bool Reset, bool Not_Idle)
        {
            n21.CameraControls_R that_0 = this;
            that_0 = Longitude_Delta != this.Longitude_Delta || Latitude_Delta != this.Latitude_Delta || FOV_Delta != this.FOV_Delta || Interest_Delta != this.Interest_Delta || Distance_Delta != this.Distance_Delta || Reset != this.Reset || Not_Idle != this.Not_Idle ? new CameraControls_R(this)
            {Longitude_Delta = Longitude_Delta, Latitude_Delta = Latitude_Delta, FOV_Delta = FOV_Delta, Interest_Delta = Interest_Delta, Distance_Delta = Distance_Delta, Reset = Reset, Not_Idle = Not_Idle} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 59578U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "JpFO6ISBkdXLIiLSpG6ZsD", Name = "CameraState_R")]
    [n2.SerializableAttribute]
    public class CameraState_R : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n21.CameraState_R Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(true);
            var instance = new CameraState_R(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n21.CameraState_R CreateDefault()
        {
            return __DEFAULT__ ?? (__DEFAULT__ = __COMPUTE__());
            n21.CameraState_R __COMPUTE__()
            {
                var context = n1.NodeContext.Default.WithIsImmutable(true);
                var instance = new CameraState_R(context, n1.VLObject.NewIdentity());
                return instance.__CreateDefault__();
            }
        }

        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n21.CameraState_R __DEFAULT__;
        public n21.CameraState_R Join(n6.Matrix View_Projection_In, n6.Matrix View_In, n6.Matrix Projection_In, n6.Matrix Inverse_View_In, n6.Vector3 Position_In, n6.Vector3 Interest_In, float FOV_In, float Distance_In, bool Four_Rooms_In, int Active_Viewport_In, bool Renderer_Hovered_In, bool Idle_In)
        {
            n6.Matrix __auto_0 = View_Projection_In;
            n6.Matrix __auto_1 = View_In;
            n6.Matrix __auto_2 = Projection_In;
            n6.Matrix __auto_3 = Inverse_View_In;
            n6.Vector3 __auto_4 = Position_In;
            n6.Vector3 __auto_5 = Interest_In;
            float __auto_6 = FOV_In;
            float __auto_7 = Distance_In;
            bool __auto_8 = Four_Rooms_In;
            int __auto_9 = Active_Viewport_In;
            bool Apply_10 = true;
            var Output_11 = Renderer_Hovered_In;
            if (Apply_10)
            {
                var Output_12 = !Renderer_Hovered_In;
                Output_11 = Output_12;
            }

            bool __auto_13 = Output_11;
            bool Apply_14 = true;
            var Output_15 = Idle_In;
            if (Apply_14)
            {
                var Output_16 = !Idle_In;
                Output_15 = Output_16;
            }

            bool __auto_17 = Output_15;
            n21.CameraState_R that_18 = this;
            that_18 = !n9.EqualityComparer<n6.Matrix>.Default.Equals(View_Projection_In, this.View_Projection) || !n9.EqualityComparer<n6.Matrix>.Default.Equals(View_In, this.View) || !n9.EqualityComparer<n6.Matrix>.Default.Equals(Projection_In, this.Projection) || !n9.EqualityComparer<n6.Matrix>.Default.Equals(Inverse_View_In, this.Inverse_View) || Position_In != this.Position || Interest_In != this.Interest || FOV_In != this.FOV || Distance_In != this.Distance || Four_Rooms_In != this.Four_Rooms || Active_Viewport_In != this.Active_Viewport || Output_11 != this.Renderer_Not_Hovered || Output_15 != this.Not_Idle ? new CameraState_R(this)
            {View_Projection = View_Projection_In, View = View_In, Projection = Projection_In, Inverse_View = Inverse_View_In, Position = Position_In, Interest = Interest_In, FOV = FOV_In, Distance = Distance_In, Four_Rooms = Four_Rooms_In, Active_Viewport = Active_Viewport_In, Renderer_Not_Hovered = Output_11, Not_Idle = Output_15} : that_18;
            return that_18;
        }

        public n21.CameraState_R Split(out n6.Matrix View_Projection_Out, out n6.Matrix View_Out, out n6.Matrix Projection_Out, out n6.Matrix Inverse_View_Out, out n6.Vector3 Position_Out, out n6.Vector3 Interest_Out, out float FOV_Out, out float Distance_Out, out bool Four_Rooms_Out, out int Active_Viewport_Out, out bool Renderer_Hovered_Out, out bool Idle_Out)
        {
            n6.Matrix __auto_0 = this.View_Projection;
            n6.Matrix __auto_1 = this.View;
            n6.Matrix __auto_2 = this.Projection;
            n6.Matrix __auto_3 = this.Inverse_View;
            n6.Vector3 __auto_4 = this.Position;
            n6.Vector3 __auto_5 = this.Interest;
            float __auto_6 = this.FOV;
            float __auto_7 = this.Distance;
            bool __auto_8 = this.Four_Rooms;
            int __auto_9 = this.Active_Viewport;
            bool __auto_10 = this.Renderer_Not_Hovered;
            bool __auto_11 = this.Not_Idle;
            bool Apply_12 = true;
            var Output_13 = __auto_10;
            if (Apply_12)
            {
                var Output_14 = !__auto_10;
                Output_13 = Output_14;
            }

            bool Apply_15 = true;
            var Output_16 = __auto_11;
            if (Apply_15)
            {
                var Output_17 = !__auto_11;
                Output_16 = Output_17;
            }

            View_Projection_Out = __auto_0;
            View_Out = __auto_1;
            Projection_Out = __auto_2;
            Inverse_View_Out = __auto_3;
            Position_Out = __auto_4;
            Interest_Out = __auto_5;
            FOV_Out = __auto_6;
            Distance_Out = __auto_7;
            Four_Rooms_Out = __auto_8;
            Active_Viewport_Out = __auto_9;
            Renderer_Hovered_Out = Output_13;
            Idle_Out = Output_16;
            return this;
        }

        public n21.CameraState_R __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n21.CameraState_R that_0 = this;
            this.View_Projection = n10._Operations_.CreateDefault();
            this.View = n10._Operations_.CreateDefault();
            this.Projection = n10._Operations_.CreateDefault();
            this.Inverse_View = n10._Operations_.CreateDefault();
            this.Position = n28._Operations_.CreateDefault();
            this.Interest = n28._Operations_.CreateDefault();
            this.FOV = 0F;
            this.Distance = 0F;
            this.Four_Rooms = false;
            this.Active_Viewport = 0;
            this.Not_Idle = false;
            this.Renderer_Not_Hovered = false;
            return that_0;
        }

        public n21.CameraState_R __CreateDefault__()
        {
            n21.CameraState_R that_0 = this;
            this.View_Projection = n10._Operations_.CreateDefault();
            this.View = n10._Operations_.CreateDefault();
            this.Projection = n10._Operations_.CreateDefault();
            this.Inverse_View = n10._Operations_.CreateDefault();
            this.Position = n28._Operations_.CreateDefault();
            this.Interest = n28._Operations_.CreateDefault();
            this.FOV = 0F;
            this.Distance = 0F;
            this.Four_Rooms = false;
            this.Active_Viewport = 0;
            this.Not_Idle = false;
            this.Renderer_Not_Hovered = false;
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

        [n1.ElementAttribute(TracingId = 59580U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Nm6OHPCPkNIMwE9nDDocHi", Name = "View Projection")]
        public n6.Matrix View_Projection;
        [n1.ElementAttribute(TracingId = 59581U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "AVxAB1yfdY8PjXx8F2IGFC", Name = "View")]
        public n6.Matrix View;
        [n1.ElementAttribute(TracingId = 59582U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "SvSK9yzQvcQLfucLFVSsFz", Name = "Projection")]
        public n6.Matrix Projection;
        [n1.ElementAttribute(TracingId = 59583U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "KgC067wusxKOf7tWlTbp4B", Name = "Inverse View")]
        public n6.Matrix Inverse_View;
        [n1.ElementAttribute(TracingId = 59584U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "JdDvD63r1mgP1ROXsLr7xm", Name = "Position")]
        public n6.Vector3 Position;
        [n1.ElementAttribute(TracingId = 59585U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Jys9BFf2HLfMLD3T4hch56", Name = "Interest")]
        public n6.Vector3 Interest;
        [n1.ElementAttribute(TracingId = 59586U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "PWrLaLqG6NnNWNFIW0OPHn", Name = "FOV")]
        public float FOV;
        [n1.ElementAttribute(TracingId = 59587U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "TZ9Ou6JZGhqNuYi7xeNIef", Name = "Distance")]
        public float Distance;
        [n1.ElementAttribute(TracingId = 59588U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "CzniDgoJ0zrPnfcQ4Wq0B9", Name = "Four Rooms")]
        public bool Four_Rooms;
        [n1.ElementAttribute(TracingId = 59589U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "HR4Q79v2Oj2OW9a4gyXuCZ", Name = "Active Viewport")]
        public int Active_Viewport;
        [n1.ElementAttribute(TracingId = 59590U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "HRkgbuEMdtPPoym6gCWyzy", Name = "Not Idle")]
        public bool Not_Idle;
        [n1.ElementAttribute(TracingId = 59661U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "LJdASOKAod9LkkZo3raU66", Name = "Renderer Not Hovered")]
        public bool Renderer_Not_Hovered;
        public CameraState_R(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CameraState_R(CameraState_R other): base(other)
        {
            this.View_Projection = other.View_Projection;
            this.View = other.View;
            this.Projection = other.Projection;
            this.Inverse_View = other.Inverse_View;
            this.Position = other.Position;
            this.Interest = other.Interest;
            this.FOV = other.FOV;
            this.Distance = other.Distance;
            this.Four_Rooms = other.Four_Rooms;
            this.Active_Viewport = other.Active_Viewport;
            this.Not_Idle = other.Not_Idle;
            this.Renderer_Not_Hovered = other.Renderer_Not_Hovered;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "View_Projection", in View_Projection), n1.CompilationHelper.GetValueOrExisting(values, "View", in View), n1.CompilationHelper.GetValueOrExisting(values, "Projection", in Projection), n1.CompilationHelper.GetValueOrExisting(values, "Inverse_View", in Inverse_View), n1.CompilationHelper.GetValueOrExisting(values, "Position", in Position), n1.CompilationHelper.GetValueOrExisting(values, "Interest", in Interest), n1.CompilationHelper.GetValueOrExisting(values, "FOV", in FOV), n1.CompilationHelper.GetValueOrExisting(values, "Distance", in Distance), n1.CompilationHelper.GetValueOrExisting(values, "Four_Rooms", in Four_Rooms), n1.CompilationHelper.GetValueOrExisting(values, "Active_Viewport", in Active_Viewport), n1.CompilationHelper.GetValueOrExisting(values, "Not_Idle", in Not_Idle), n1.CompilationHelper.GetValueOrExisting(values, "Renderer_Not_Hovered", in Renderer_Not_Hovered));
        }

        internal CameraState_R __WITH__(n6.Matrix View_Projection, n6.Matrix View, n6.Matrix Projection, n6.Matrix Inverse_View, n6.Vector3 Position, n6.Vector3 Interest, float FOV, float Distance, bool Four_Rooms, int Active_Viewport, bool Not_Idle, bool Renderer_Not_Hovered)
        {
            n21.CameraState_R that_0 = this;
            that_0 = !n9.EqualityComparer<n6.Matrix>.Default.Equals(View_Projection, this.View_Projection) || !n9.EqualityComparer<n6.Matrix>.Default.Equals(View, this.View) || !n9.EqualityComparer<n6.Matrix>.Default.Equals(Projection, this.Projection) || !n9.EqualityComparer<n6.Matrix>.Default.Equals(Inverse_View, this.Inverse_View) || Position != this.Position || Interest != this.Interest || FOV != this.FOV || Distance != this.Distance || Four_Rooms != this.Four_Rooms || Active_Viewport != this.Active_Viewport || Not_Idle != this.Not_Idle || Renderer_Not_Hovered != this.Renderer_Not_Hovered ? new CameraState_R(this)
            {View_Projection = View_Projection, View = View, Projection = Projection, Inverse_View = Inverse_View, Position = Position, Interest = Interest, FOV = FOV, Distance = Distance, Four_Rooms = Four_Rooms, Active_Viewport = Active_Viewport, Not_Idle = Not_Idle, Renderer_Not_Hovered = Renderer_Not_Hovered} : that_0;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 59728U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "FBxS20I0dg6Nl63P2ejQR3", Name = "OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3")]
    [n2.SerializableAttribute]
    public class OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n21.OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 Create(n1.NodeContext Node_Context)
        {
            var instance = new OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n21.OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 CreateDefault()
        {
            var instance = new OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n21.OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 Join(n21.CameraControls_R Camera_Controls_In, n7.IMouse Mouse_Device_In, n7.IKeyboard Keyboard_Device_In, [n4.SerializedDefaultValueAttribute("0.5", false)] float Filter_Time_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enable_Controls_In, out n21.CameraControls_R Camera_Controls_Out)
        {
            float __pad_U4TmoDSLiWAPnaR56rMqWL_0 = __slot_U4TmoDSLiWAPnaR56rMqWL;
            float __pad_Mj0D14pCRTuMy18vhCNcYy_1 = __slot_Mj0D14pCRTuMy18vhCNcYy;
            float __pad_SwUywVIV7t2LH7Pj6Bdwv8_2 = __slot_SwUywVIV7t2LH7Pj6Bdwv8;
            float __pad_FyJ4msG0ps1LSifruJaJBI_3 = __slot_FyJ4msG0ps1LSifruJaJBI;
            string __pad_SsaADLCPsW7OwvLHd0r0ct_4 = __slot_SsaADLCPsW7OwvLHd0r0ct;
            string __pad_JSmLjEZpIlvMvC5ix3pUqL_5 = __slot_JSmLjEZpIlvMvC5ix3pUqL;
            float __pad_O9wa43EqDhpOSn3Oy4Ydtq_6 = __slot_O9wa43EqDhpOSn3Oy4Ydtq;
            var Output_17 = this.__p_ATMlydFu917MUljuR3XEAl.Update(Mouse_Device_In: Mouse_Device_In, Position_In_World_Out: out n6.Vector2 Position_In_World_7, Position_In_Projection_Out: out n6.Vector2 Position_In_Projection_8, Position_Out: out n6.Vector2 Position_9, Left_Pressed_Out: out bool Left_Pressed_10, Middle_Pressed_Out: out bool Middle_Pressed_11, Right_Pressed_Out: out bool Right_Pressed_12, Normalized_Position_Out: out n6.Vector2 Normalized_Position_13, WheelDelta_Out: out int WheelDelta_14, Client_Area_Out: out n6.Vector2 Client_Area_15, Sender_Out: out n2.Object Sender_16);
            var Output_19 = this.__p_TyRkRvr8t7gObGTn74orhh.Update<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Value_In: Position_In_Projection_8, Result_Out: out n6.Vector2 Result_18);
            n14.Vector2Nodes.Vector(input: ref Result_18, x: out float X_20, y: out float Y_21);
            float Input_2_22 = n2.Convert.ToSingle(Left_Pressed_10);
            var Output_23 = X_20 * Input_2_22;
            var Output_24 = Output_23 * __pad_SwUywVIV7t2LH7Pj6Bdwv8_2;
            n14.TweenerTransition Transition_25 = __c_GNXHCwKtzmKMeG7C18sdul;
            n14.TweenerMode Mode_26 = __c_Vp6AaSg11w9MwTYK8o6NYj;
            var Output_29 = this.__p_POo8Rr6hiVyO7crqq7ZKnu.Update<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Goto_Position_In: Output_24, Filter_Time_In: Filter_Time_In, Transition_In: Transition_25, Mode_In: Mode_26, Position_Out: out float Position_27, Progress_Out: out float Progress_28);
            float Input_2_30 = n2.Convert.ToSingle(Left_Pressed_10);
            var Output_31 = Y_21 * Input_2_30;
            var Output_32 = Output_31 * __pad_SwUywVIV7t2LH7Pj6Bdwv8_2;
            n14.TweenerTransition Transition_33 = __c_FIkjtzVXOtsOgMWO7CV95c;
            n14.TweenerMode Mode_34 = __c_Dsd3vy0YyAEMLrOmdzidfq;
            var Output_37 = this.__p_DcfTaJYXy5FL6eWvdem4Qs.Update<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Goto_Position_In: Output_32, Filter_Time_In: Filter_Time_In, Transition_In: Transition_33, Mode_In: Mode_34, Position_Out: out float Position_35, Progress_Out: out float Progress_36);
            var Output_39 = this.__p_LsGSigw0PVVM0T35oaZzgO.Update<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Value_In: WheelDelta_14, Result_Out: out int Result_38);
            float Input_40 = (float)Result_38;
            var Output_42 = this.__p_UQOerRAkmh3OHUjhll3ckm.Update(Keyboard_Device_In: Keyboard_Device_In, Pressed_Keys_Out: out n19.ImmutableHashSet<n18.Keys> Pressed_Keys_41);
            var Output_44 = this.__p_QuUj5N5Nlm3Mw3S9NClxmG.Update(Keys_In: Pressed_Keys_41, Key_Name_In: __pad_SsaADLCPsW7OwvLHd0r0ct_4, Is_Down_Out: out bool Is_Down_43);
            float Input_3_45 = n2.Convert.ToSingle(Is_Down_43);
            var Output_46 = Input_40 * __pad_FyJ4msG0ps1LSifruJaJBI_3;
            var Output_47 = Output_46 * Input_3_45;
            n14.TweenerTransition Transition_48 = __c_Oq9j9OCouLNMAPqBBzMJkP;
            n14.TweenerMode Mode_49 = __c_LVTlwlDok1UOsCsSMzk0Vb;
            var Output_52 = this.__p_A0MNNAUYuFVNyR9vTGNSiB.Update<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Goto_Position_In: Output_47, Filter_Time_In: Filter_Time_In, Transition_In: Transition_48, Mode_In: Mode_49, Position_Out: out float Position_50, Progress_Out: out float Progress_51);
            float Scalar_53 = n2.Convert.ToSingle(Middle_Pressed_11);
            n14.Vector2Nodes.Scale(input: ref Result_18, scalar: Scalar_53, output: out n6.Vector2 Output_54);
            n14.Vector2Nodes.Scale(input: ref Output_54, scalar: __pad_U4TmoDSLiWAPnaR56rMqWL_0, output: out n6.Vector2 Output_55);
            n14.TweenerTransition Transition_56 = __c_Oi0IyKw0cVcOEUJ4gBclzh;
            n14.TweenerMode Mode_57 = __c_Lg9Tyt1VaPyNIfwzXCvz14;
            var Output_60 = this.__p_TEbOE3hfcbRNYbrCMYW3Of.Update<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Goto_Position_In: Output_55, Filter_Time_In: Filter_Time_In, Transition_In: Transition_56, Mode_In: Mode_57, Position_Out: out n6.Vector2 Position_58, Progress_Out: out float Progress_59);
            float Input_2_61 = n2.Convert.ToSingle(Right_Pressed_12);
            var Output_62 = Y_21 * Input_2_61;
            var Output_63 = Output_62 * __pad_Mj0D14pCRTuMy18vhCNcYy_1;
            n14.TweenerTransition Transition_64 = __c_GrGL7VIiWHvN59KZHtbuax;
            n14.TweenerMode Mode_65 = __c_TXuGxQxN6alLGDloSyRNre;
            var Output_68 = this.__p_DfifmDyccYrLgrP64KFTpP.Update<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Goto_Position_In: Output_63, Filter_Time_In: Filter_Time_In, Transition_In: Transition_64, Mode_In: Mode_65, Position_Out: out float Position_66, Progress_Out: out float Progress_67);
            var Output_70 = this.__p_PsaAfzXD84KO93iaIihy7y.Update(Keys_In: Pressed_Keys_41, Key_Name_In: __pad_JSmLjEZpIlvMvC5ix3pUqL_5, Is_Down_Out: out bool Is_Down_69);
            bool Reset_71 = false;
            var Output_74 = this.__p_KVV2iJErwuVPVmTmLUPGTE.Update(Set_In: Is_Down_69, Reset_In: Reset_71, Time_In: __pad_O9wa43EqDhpOSn3Oy4Ydtq_6, Value_Out: out bool Value_72, Running_Out: out float Running_73);
            var Output_77 = this.__p_JnkgbH4fHoTQYTAn2zhIC3.Update(Value_In: Value_72, Up_Edge_Out: out bool Up_Edge_75, Down_Edge_Out: out bool Down_Edge_76);
            var Output_78 = Left_Pressed_10 || Middle_Pressed_11;
            var Output_79 = Output_78 || Right_Pressed_12;
            var Output_80 = Output_79 || Is_Down_69;
            var Output_81 = Output_80 || Is_Down_43;
            var Output_82 = !Output_81;
            var Output_83 = Camera_Controls_In;
            if (Enable_Controls_In)
            {
                Output_83 = Camera_Controls_In.Combine(Longitude_Delta_In: Position_27, Latitude_Delta_In: Position_35, FOV_Delta_In: Position_50, Interest_Delta_In: Position_58, Distance_Delta_In: Position_66, Reset_In: Up_Edge_75, Idle_In: Output_82);
            }

            var Output_84 = Output_29;
            if (Up_Edge_75)
            {
                Output_84 = Output_29.Reset();
            }

            var Output_85 = Output_60;
            if (Up_Edge_75)
            {
                Output_85 = Output_60.Reset();
            }

            var Output_86 = Output_37;
            if (Up_Edge_75)
            {
                Output_86 = Output_37.Reset();
            }

            var Output_87 = Output_68;
            if (Up_Edge_75)
            {
                Output_87 = Output_68.Reset();
            }

            var Output_88 = Output_52;
            if (Up_Edge_75)
            {
                Output_88 = Output_52.Reset();
            }

            Camera_Controls_Out = Output_83;
            n21.OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 that_89 = this;
            if (this.__GetContext__().IsImmutable)
                that_89 = Output_17 != this.__p_ATMlydFu917MUljuR3XEAl || Output_19 != this.__p_TyRkRvr8t7gObGTn74orhh || Output_84 != this.__p_POo8Rr6hiVyO7crqq7ZKnu || Output_86 != this.__p_DcfTaJYXy5FL6eWvdem4Qs || Output_39 != this.__p_LsGSigw0PVVM0T35oaZzgO || Output_42 != this.__p_UQOerRAkmh3OHUjhll3ckm || Output_44 != this.__p_QuUj5N5Nlm3Mw3S9NClxmG || Output_88 != this.__p_A0MNNAUYuFVNyR9vTGNSiB || Output_85 != this.__p_TEbOE3hfcbRNYbrCMYW3Of || Output_87 != this.__p_DfifmDyccYrLgrP64KFTpP || Output_70 != this.__p_PsaAfzXD84KO93iaIihy7y || Output_74 != this.__p_KVV2iJErwuVPVmTmLUPGTE || Output_77 != this.__p_JnkgbH4fHoTQYTAn2zhIC3 ? new OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3(this)
                {__p_ATMlydFu917MUljuR3XEAl = Output_17, __p_TyRkRvr8t7gObGTn74orhh = Output_19, __p_POo8Rr6hiVyO7crqq7ZKnu = Output_84, __p_DcfTaJYXy5FL6eWvdem4Qs = Output_86, __p_LsGSigw0PVVM0T35oaZzgO = Output_39, __p_UQOerRAkmh3OHUjhll3ckm = Output_42, __p_QuUj5N5Nlm3Mw3S9NClxmG = Output_44, __p_A0MNNAUYuFVNyR9vTGNSiB = Output_88, __p_TEbOE3hfcbRNYbrCMYW3Of = Output_85, __p_DfifmDyccYrLgrP64KFTpP = Output_87, __p_PsaAfzXD84KO93iaIihy7y = Output_70, __p_KVV2iJErwuVPVmTmLUPGTE = Output_74, __p_JnkgbH4fHoTQYTAn2zhIC3 = Output_77} : that_89;
            else
            {
                this.__p_ATMlydFu917MUljuR3XEAl = Output_17;
                this.__p_TyRkRvr8t7gObGTn74orhh = Output_19;
                this.__p_POo8Rr6hiVyO7crqq7ZKnu = Output_84;
                this.__p_DcfTaJYXy5FL6eWvdem4Qs = Output_86;
                this.__p_LsGSigw0PVVM0T35oaZzgO = Output_39;
                this.__p_UQOerRAkmh3OHUjhll3ckm = Output_42;
                this.__p_QuUj5N5Nlm3Mw3S9NClxmG = Output_44;
                this.__p_A0MNNAUYuFVNyR9vTGNSiB = Output_88;
                this.__p_TEbOE3hfcbRNYbrCMYW3Of = Output_85;
                this.__p_DfifmDyccYrLgrP64KFTpP = Output_87;
                this.__p_PsaAfzXD84KO93iaIihy7y = Output_70;
                this.__p_KVV2iJErwuVPVmTmLUPGTE = Output_74;
                this.__p_JnkgbH4fHoTQYTAn2zhIC3 = Output_77;
            }

            return that_89;
        }

        public n21.OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "QuUj5N5Nlm3Mw3S9NClxmG", 59778U);
            var Output_1 = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "JnkgbH4fHoTQYTAn2zhIC3", 60520U);
            var Output_3 = n16.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "TyRkRvr8t7gObGTn74orhh", 60529U);
            var Output_5 = n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector2>.Create<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "KVV2iJErwuVPVmTmLUPGTE", 60544U);
            n31.IClock Clock_7 = n30._Operations_.CreateDefault();
            var Output_8 = n16.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H.Create(Node_Context: Node_Context_6, Clock_In: Clock_7);
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "LsGSigw0PVVM0T35oaZzgO", 60558U);
            var Output_10 = n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<int>.Create<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Node_Context: Node_Context_9);
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "PsaAfzXD84KO93iaIihy7y", 60568U);
            var Output_12 = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_11);
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "UQOerRAkmh3OHUjhll3ckm", 60597U);
            var Output_14 = n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.Create(Node_Context: Node_Context_13);
            n1.NodeContext Node_Context_15 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "ATMlydFu917MUljuR3XEAl", 60607U);
            var Output_16 = n24.MouseState_BNOhaxXysw1MZBzyJMI18t.Create(Node_Context: Node_Context_15);
            n1.NodeContext Node_Context_17 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "POo8Rr6hiVyO7crqq7ZKnu", 60645U);
            float Initial_Position_18 = 0F;
            n31.IFrameClock Clock_19 = n32._Operations_.CreateDefault();
            var Output_20 = n33.Filter_APkUExWKTIiNJbZIcf8Uew<float>.Create<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Node_Context: Node_Context_17, Initial_Position_In: Initial_Position_18, Clock_In: Clock_19);
            n1.NodeContext Node_Context_21 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "DcfTaJYXy5FL6eWvdem4Qs", 60659U);
            float Initial_Position_22 = 0F;
            n31.IFrameClock Clock_23 = n32._Operations_.CreateDefault();
            var Output_24 = n33.Filter_APkUExWKTIiNJbZIcf8Uew<float>.Create<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Node_Context: Node_Context_21, Initial_Position_In: Initial_Position_22, Clock_In: Clock_23);
            n1.NodeContext Node_Context_25 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "A0MNNAUYuFVNyR9vTGNSiB", 60677U);
            float Initial_Position_26 = 0F;
            n31.IFrameClock Clock_27 = n32._Operations_.CreateDefault();
            var Output_28 = n33.Filter_APkUExWKTIiNJbZIcf8Uew<float>.Create<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Node_Context: Node_Context_25, Initial_Position_In: Initial_Position_26, Clock_In: Clock_27);
            n1.NodeContext Node_Context_29 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "DfifmDyccYrLgrP64KFTpP", 60696U);
            float Initial_Position_30 = 0F;
            n31.IFrameClock Clock_31 = n32._Operations_.CreateDefault();
            var Output_32 = n33.Filter_APkUExWKTIiNJbZIcf8Uew<float>.Create<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Node_Context: Node_Context_29, Initial_Position_In: Initial_Position_30, Clock_In: Clock_31);
            n1.NodeContext Node_Context_33 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "TEbOE3hfcbRNYbrCMYW3Of", 60715U);
            n6.Vector2 Initial_Position_34 = n17._Operations_.CreateDefault();
            n31.IFrameClock Clock_35 = n32._Operations_.CreateDefault();
            var Output_36 = n33.Filter_APkUExWKTIiNJbZIcf8Uew<n6.Vector2>.Create<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Node_Context: Node_Context_33, Initial_Position_In: Initial_Position_34, Clock_In: Clock_35);
            n21.OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 that_37 = this;
            this.__p_QuUj5N5Nlm3Mw3S9NClxmG = Output_1;
            this.__p_JnkgbH4fHoTQYTAn2zhIC3 = Output_3;
            this.__p_TyRkRvr8t7gObGTn74orhh = Output_5;
            this.__p_KVV2iJErwuVPVmTmLUPGTE = Output_8;
            this.__p_LsGSigw0PVVM0T35oaZzgO = Output_10;
            this.__p_PsaAfzXD84KO93iaIihy7y = Output_12;
            this.__p_UQOerRAkmh3OHUjhll3ckm = Output_14;
            this.__p_ATMlydFu917MUljuR3XEAl = Output_16;
            this.__p_POo8Rr6hiVyO7crqq7ZKnu = Output_20;
            this.__p_DcfTaJYXy5FL6eWvdem4Qs = Output_24;
            this.__p_A0MNNAUYuFVNyR9vTGNSiB = Output_28;
            this.__p_DfifmDyccYrLgrP64KFTpP = Output_32;
            this.__p_TEbOE3hfcbRNYbrCMYW3Of = Output_36;
            return that_37;
        }

        public n21.OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 __CreateDefault__()
        {
            n21.OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 that_0 = this;
            this.__p_ATMlydFu917MUljuR3XEAl = n24.MouseState_BNOhaxXysw1MZBzyJMI18t.CreateDefault();
            this.__p_TyRkRvr8t7gObGTn74orhh = n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector2>.CreateDefault<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>();
            this.__p_POo8Rr6hiVyO7crqq7ZKnu = n33.Filter_APkUExWKTIiNJbZIcf8Uew<float>.CreateDefault<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>();
            this.__p_DcfTaJYXy5FL6eWvdem4Qs = n33.Filter_APkUExWKTIiNJbZIcf8Uew<float>.CreateDefault<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>();
            this.__p_LsGSigw0PVVM0T35oaZzgO = n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<int>.CreateDefault<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>();
            this.__p_UQOerRAkmh3OHUjhll3ckm = n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.CreateDefault();
            this.__p_QuUj5N5Nlm3Mw3S9NClxmG = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_A0MNNAUYuFVNyR9vTGNSiB = n33.Filter_APkUExWKTIiNJbZIcf8Uew<float>.CreateDefault<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>();
            this.__p_TEbOE3hfcbRNYbrCMYW3Of = n33.Filter_APkUExWKTIiNJbZIcf8Uew<n6.Vector2>.CreateDefault<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>();
            this.__p_DfifmDyccYrLgrP64KFTpP = n33.Filter_APkUExWKTIiNJbZIcf8Uew<float>.CreateDefault<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>();
            this.__p_PsaAfzXD84KO93iaIihy7y = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_KVV2iJErwuVPVmTmLUPGTE = n16.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H.CreateDefault();
            this.__p_JnkgbH4fHoTQYTAn2zhIC3 = n16.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_ATMlydFu917MUljuR3XEAl);
            n1.CompilationHelper.SafeDispose(this.__p_TyRkRvr8t7gObGTn74orhh);
            n1.CompilationHelper.SafeDispose(this.__p_POo8Rr6hiVyO7crqq7ZKnu);
            n1.CompilationHelper.SafeDispose(this.__p_DcfTaJYXy5FL6eWvdem4Qs);
            n1.CompilationHelper.SafeDispose(this.__p_LsGSigw0PVVM0T35oaZzgO);
            n1.CompilationHelper.SafeDispose(this.__p_UQOerRAkmh3OHUjhll3ckm);
            n1.CompilationHelper.SafeDispose(this.__p_QuUj5N5Nlm3Mw3S9NClxmG);
            n1.CompilationHelper.SafeDispose(this.__p_A0MNNAUYuFVNyR9vTGNSiB);
            n1.CompilationHelper.SafeDispose(this.__p_TEbOE3hfcbRNYbrCMYW3Of);
            n1.CompilationHelper.SafeDispose(this.__p_DfifmDyccYrLgrP64KFTpP);
            n1.CompilationHelper.SafeDispose(this.__p_PsaAfzXD84KO93iaIihy7y);
            n1.CompilationHelper.SafeDispose(this.__p_KVV2iJErwuVPVmTmLUPGTE);
            n1.CompilationHelper.SafeDispose(this.__p_JnkgbH4fHoTQYTAn2zhIC3);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 59752U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "FyJ4msG0ps1LSifruJaJBI", Name = "__slot_FyJ4msG0ps1LSifruJaJBI")]
        public static float __slot_FyJ4msG0ps1LSifruJaJBI = 0.015F;
        [n1.ElementAttribute(TracingId = 59753U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "SsaADLCPsW7OwvLHd0r0ct", Name = "__slot_SsaADLCPsW7OwvLHd0r0ct")]
        public static string __slot_SsaADLCPsW7OwvLHd0r0ct = "ControlKey";
        [n1.ElementAttribute(TracingId = 59754U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "O9wa43EqDhpOSn3Oy4Ydtq", Name = "__slot_O9wa43EqDhpOSn3Oy4Ydtq")]
        public static float __slot_O9wa43EqDhpOSn3Oy4Ydtq = 0.5F;
        [n1.ElementAttribute(TracingId = 59755U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "JSmLjEZpIlvMvC5ix3pUqL", Name = "__slot_JSmLjEZpIlvMvC5ix3pUqL")]
        public static string __slot_JSmLjEZpIlvMvC5ix3pUqL = "R";
        [n1.ElementAttribute(TracingId = 60632U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Mj0D14pCRTuMy18vhCNcYy", Name = "__slot_Mj0D14pCRTuMy18vhCNcYy")]
        public static float __slot_Mj0D14pCRTuMy18vhCNcYy = 1.6F;
        [n1.ElementAttribute(TracingId = 60633U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "SwUywVIV7t2LH7Pj6Bdwv8", Name = "__slot_SwUywVIV7t2LH7Pj6Bdwv8")]
        public static float __slot_SwUywVIV7t2LH7Pj6Bdwv8 = 0.25F;
        [n1.ElementAttribute(TracingId = 60636U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "U4TmoDSLiWAPnaR56rMqWL", Name = "__slot_U4TmoDSLiWAPnaR56rMqWL")]
        public static float __slot_U4TmoDSLiWAPnaR56rMqWL = 1F;
        [n1.ElementAttribute(TracingId = 60638U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "DPkH5LjwjPRNaYPlCPOFKM", Name = "__slot_DPkH5LjwjPRNaYPlCPOFKM")]
        public static string __slot_DPkH5LjwjPRNaYPlCPOFKM = "SPEEDS";
        [n1.ElementAttribute(TracingId = 60607U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "ATMlydFu917MUljuR3XEAl", Name = "MouseState", IsManaged = true, IsAutoGenerated = true)]
        public n24.MouseState_BNOhaxXysw1MZBzyJMI18t __p_ATMlydFu917MUljuR3XEAl;
        [n1.ElementAttribute(TracingId = 60529U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "TyRkRvr8t7gObGTn74orhh", Name = "FrameDifference", IsManaged = true, IsAutoGenerated = true)]
        public n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector2> __p_TyRkRvr8t7gObGTn74orhh;
        [n1.ElementAttribute(TracingId = 60645U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "POo8Rr6hiVyO7crqq7ZKnu", Name = "Filter", IsManaged = true, IsAutoGenerated = true)]
        public n33.Filter_APkUExWKTIiNJbZIcf8Uew<float> __p_POo8Rr6hiVyO7crqq7ZKnu;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n14.TweenerTransition __c_GNXHCwKtzmKMeG7C18sdul = n1.CompilationHelper.Deserialize<n14.TweenerTransition>("Expo", false, "USVpn2wMsrSLK5oj1XAsi5", "GNXHCwKtzmKMeG7C18sdul");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n14.TweenerMode __c_Vp6AaSg11w9MwTYK8o6NYj = n1.CompilationHelper.Deserialize<n14.TweenerMode>("Out", false, "USVpn2wMsrSLK5oj1XAsi5", "Vp6AaSg11w9MwTYK8o6NYj");
        [n1.ElementAttribute(TracingId = 60659U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "DcfTaJYXy5FL6eWvdem4Qs", Name = "Filter", IsManaged = true, IsAutoGenerated = true)]
        public n33.Filter_APkUExWKTIiNJbZIcf8Uew<float> __p_DcfTaJYXy5FL6eWvdem4Qs;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n14.TweenerTransition __c_FIkjtzVXOtsOgMWO7CV95c = n1.CompilationHelper.Deserialize<n14.TweenerTransition>("Expo", false, "USVpn2wMsrSLK5oj1XAsi5", "FIkjtzVXOtsOgMWO7CV95c");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n14.TweenerMode __c_Dsd3vy0YyAEMLrOmdzidfq = n1.CompilationHelper.Deserialize<n14.TweenerMode>("Out", false, "USVpn2wMsrSLK5oj1XAsi5", "Dsd3vy0YyAEMLrOmdzidfq");
        [n1.ElementAttribute(TracingId = 60558U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "LsGSigw0PVVM0T35oaZzgO", Name = "FrameDifference", IsManaged = true, IsAutoGenerated = true)]
        public n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<int> __p_LsGSigw0PVVM0T35oaZzgO;
        [n1.ElementAttribute(TracingId = 60597U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "UQOerRAkmh3OHUjhll3ckm", Name = "KeyboardState", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_UQOerRAkmh3OHUjhll3ckm;
        [n1.ElementAttribute(TracingId = 59778U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "QuUj5N5Nlm3Mw3S9NClxmG", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_QuUj5N5Nlm3Mw3S9NClxmG;
        [n1.ElementAttribute(TracingId = 60677U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "A0MNNAUYuFVNyR9vTGNSiB", Name = "Filter", IsManaged = true, IsAutoGenerated = true)]
        public n33.Filter_APkUExWKTIiNJbZIcf8Uew<float> __p_A0MNNAUYuFVNyR9vTGNSiB;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n14.TweenerTransition __c_Oq9j9OCouLNMAPqBBzMJkP = n1.CompilationHelper.Deserialize<n14.TweenerTransition>("Expo", false, "USVpn2wMsrSLK5oj1XAsi5", "Oq9j9OCouLNMAPqBBzMJkP");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n14.TweenerMode __c_LVTlwlDok1UOsCsSMzk0Vb = n1.CompilationHelper.Deserialize<n14.TweenerMode>("Out", false, "USVpn2wMsrSLK5oj1XAsi5", "LVTlwlDok1UOsCsSMzk0Vb");
        [n1.ElementAttribute(TracingId = 60715U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "TEbOE3hfcbRNYbrCMYW3Of", Name = "Filter", IsManaged = true, IsAutoGenerated = true)]
        public n33.Filter_APkUExWKTIiNJbZIcf8Uew<n6.Vector2> __p_TEbOE3hfcbRNYbrCMYW3Of;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n14.TweenerTransition __c_Oi0IyKw0cVcOEUJ4gBclzh = n1.CompilationHelper.Deserialize<n14.TweenerTransition>("Expo", false, "USVpn2wMsrSLK5oj1XAsi5", "Oi0IyKw0cVcOEUJ4gBclzh");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n14.TweenerMode __c_Lg9Tyt1VaPyNIfwzXCvz14 = n1.CompilationHelper.Deserialize<n14.TweenerMode>("Out", false, "USVpn2wMsrSLK5oj1XAsi5", "Lg9Tyt1VaPyNIfwzXCvz14");
        [n1.ElementAttribute(TracingId = 60696U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "DfifmDyccYrLgrP64KFTpP", Name = "Filter", IsManaged = true, IsAutoGenerated = true)]
        public n33.Filter_APkUExWKTIiNJbZIcf8Uew<float> __p_DfifmDyccYrLgrP64KFTpP;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n14.TweenerTransition __c_GrGL7VIiWHvN59KZHtbuax = n1.CompilationHelper.Deserialize<n14.TweenerTransition>("Expo", false, "USVpn2wMsrSLK5oj1XAsi5", "GrGL7VIiWHvN59KZHtbuax");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n14.TweenerMode __c_TXuGxQxN6alLGDloSyRNre = n1.CompilationHelper.Deserialize<n14.TweenerMode>("Out", false, "USVpn2wMsrSLK5oj1XAsi5", "TXuGxQxN6alLGDloSyRNre");
        [n1.ElementAttribute(TracingId = 60568U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "PsaAfzXD84KO93iaIihy7y", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_PsaAfzXD84KO93iaIihy7y;
        [n1.ElementAttribute(TracingId = 60544U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "KVV2iJErwuVPVmTmLUPGTE", Name = "TimerFlop", IsManaged = true, IsAutoGenerated = true)]
        public n16.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H __p_KVV2iJErwuVPVmTmLUPGTE;
        [n1.ElementAttribute(TracingId = 60520U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "JnkgbH4fHoTQYTAn2zhIC3", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n16.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_JnkgbH4fHoTQYTAn2zhIC3;
        static OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3()
        {
        }

        public OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3(OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 other): base(other)
        {
            this.__p_ATMlydFu917MUljuR3XEAl = other.__p_ATMlydFu917MUljuR3XEAl;
            this.__p_TyRkRvr8t7gObGTn74orhh = other.__p_TyRkRvr8t7gObGTn74orhh;
            this.__p_POo8Rr6hiVyO7crqq7ZKnu = other.__p_POo8Rr6hiVyO7crqq7ZKnu;
            this.__p_DcfTaJYXy5FL6eWvdem4Qs = other.__p_DcfTaJYXy5FL6eWvdem4Qs;
            this.__p_LsGSigw0PVVM0T35oaZzgO = other.__p_LsGSigw0PVVM0T35oaZzgO;
            this.__p_UQOerRAkmh3OHUjhll3ckm = other.__p_UQOerRAkmh3OHUjhll3ckm;
            this.__p_QuUj5N5Nlm3Mw3S9NClxmG = other.__p_QuUj5N5Nlm3Mw3S9NClxmG;
            this.__p_A0MNNAUYuFVNyR9vTGNSiB = other.__p_A0MNNAUYuFVNyR9vTGNSiB;
            this.__p_TEbOE3hfcbRNYbrCMYW3Of = other.__p_TEbOE3hfcbRNYbrCMYW3Of;
            this.__p_DfifmDyccYrLgrP64KFTpP = other.__p_DfifmDyccYrLgrP64KFTpP;
            this.__p_PsaAfzXD84KO93iaIihy7y = other.__p_PsaAfzXD84KO93iaIihy7y;
            this.__p_KVV2iJErwuVPVmTmLUPGTE = other.__p_KVV2iJErwuVPVmTmLUPGTE;
            this.__p_JnkgbH4fHoTQYTAn2zhIC3 = other.__p_JnkgbH4fHoTQYTAn2zhIC3;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_ATMlydFu917MUljuR3XEAl", in __p_ATMlydFu917MUljuR3XEAl), n1.CompilationHelper.GetValueOrExisting(values, "__p_TyRkRvr8t7gObGTn74orhh", in __p_TyRkRvr8t7gObGTn74orhh), n1.CompilationHelper.GetValueOrExisting(values, "__p_POo8Rr6hiVyO7crqq7ZKnu", in __p_POo8Rr6hiVyO7crqq7ZKnu), n1.CompilationHelper.GetValueOrExisting(values, "__p_DcfTaJYXy5FL6eWvdem4Qs", in __p_DcfTaJYXy5FL6eWvdem4Qs), n1.CompilationHelper.GetValueOrExisting(values, "__p_LsGSigw0PVVM0T35oaZzgO", in __p_LsGSigw0PVVM0T35oaZzgO), n1.CompilationHelper.GetValueOrExisting(values, "__p_UQOerRAkmh3OHUjhll3ckm", in __p_UQOerRAkmh3OHUjhll3ckm), n1.CompilationHelper.GetValueOrExisting(values, "__p_QuUj5N5Nlm3Mw3S9NClxmG", in __p_QuUj5N5Nlm3Mw3S9NClxmG), n1.CompilationHelper.GetValueOrExisting(values, "__p_A0MNNAUYuFVNyR9vTGNSiB", in __p_A0MNNAUYuFVNyR9vTGNSiB), n1.CompilationHelper.GetValueOrExisting(values, "__p_TEbOE3hfcbRNYbrCMYW3Of", in __p_TEbOE3hfcbRNYbrCMYW3Of), n1.CompilationHelper.GetValueOrExisting(values, "__p_DfifmDyccYrLgrP64KFTpP", in __p_DfifmDyccYrLgrP64KFTpP), n1.CompilationHelper.GetValueOrExisting(values, "__p_PsaAfzXD84KO93iaIihy7y", in __p_PsaAfzXD84KO93iaIihy7y), n1.CompilationHelper.GetValueOrExisting(values, "__p_KVV2iJErwuVPVmTmLUPGTE", in __p_KVV2iJErwuVPVmTmLUPGTE), n1.CompilationHelper.GetValueOrExisting(values, "__p_JnkgbH4fHoTQYTAn2zhIC3", in __p_JnkgbH4fHoTQYTAn2zhIC3));
        }

        internal OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 __WITH__(n24.MouseState_BNOhaxXysw1MZBzyJMI18t __p_ATMlydFu917MUljuR3XEAl, n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector2> __p_TyRkRvr8t7gObGTn74orhh, n33.Filter_APkUExWKTIiNJbZIcf8Uew<float> __p_POo8Rr6hiVyO7crqq7ZKnu, n33.Filter_APkUExWKTIiNJbZIcf8Uew<float> __p_DcfTaJYXy5FL6eWvdem4Qs, n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<int> __p_LsGSigw0PVVM0T35oaZzgO, n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_UQOerRAkmh3OHUjhll3ckm, n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_QuUj5N5Nlm3Mw3S9NClxmG, n33.Filter_APkUExWKTIiNJbZIcf8Uew<float> __p_A0MNNAUYuFVNyR9vTGNSiB, n33.Filter_APkUExWKTIiNJbZIcf8Uew<n6.Vector2> __p_TEbOE3hfcbRNYbrCMYW3Of, n33.Filter_APkUExWKTIiNJbZIcf8Uew<float> __p_DfifmDyccYrLgrP64KFTpP, n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_PsaAfzXD84KO93iaIihy7y, n16.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H __p_KVV2iJErwuVPVmTmLUPGTE, n16.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_JnkgbH4fHoTQYTAn2zhIC3)
        {
            n21.OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_ATMlydFu917MUljuR3XEAl != this.__p_ATMlydFu917MUljuR3XEAl || __p_TyRkRvr8t7gObGTn74orhh != this.__p_TyRkRvr8t7gObGTn74orhh || __p_POo8Rr6hiVyO7crqq7ZKnu != this.__p_POo8Rr6hiVyO7crqq7ZKnu || __p_DcfTaJYXy5FL6eWvdem4Qs != this.__p_DcfTaJYXy5FL6eWvdem4Qs || __p_LsGSigw0PVVM0T35oaZzgO != this.__p_LsGSigw0PVVM0T35oaZzgO || __p_UQOerRAkmh3OHUjhll3ckm != this.__p_UQOerRAkmh3OHUjhll3ckm || __p_QuUj5N5Nlm3Mw3S9NClxmG != this.__p_QuUj5N5Nlm3Mw3S9NClxmG || __p_A0MNNAUYuFVNyR9vTGNSiB != this.__p_A0MNNAUYuFVNyR9vTGNSiB || __p_TEbOE3hfcbRNYbrCMYW3Of != this.__p_TEbOE3hfcbRNYbrCMYW3Of || __p_DfifmDyccYrLgrP64KFTpP != this.__p_DfifmDyccYrLgrP64KFTpP || __p_PsaAfzXD84KO93iaIihy7y != this.__p_PsaAfzXD84KO93iaIihy7y || __p_KVV2iJErwuVPVmTmLUPGTE != this.__p_KVV2iJErwuVPVmTmLUPGTE || __p_JnkgbH4fHoTQYTAn2zhIC3 != this.__p_JnkgbH4fHoTQYTAn2zhIC3 ? new OrbitCameraControls_FBxS20I0dg6Nl63P2ejQR3(this)
                {__p_ATMlydFu917MUljuR3XEAl = __p_ATMlydFu917MUljuR3XEAl, __p_TyRkRvr8t7gObGTn74orhh = __p_TyRkRvr8t7gObGTn74orhh, __p_POo8Rr6hiVyO7crqq7ZKnu = __p_POo8Rr6hiVyO7crqq7ZKnu, __p_DcfTaJYXy5FL6eWvdem4Qs = __p_DcfTaJYXy5FL6eWvdem4Qs, __p_LsGSigw0PVVM0T35oaZzgO = __p_LsGSigw0PVVM0T35oaZzgO, __p_UQOerRAkmh3OHUjhll3ckm = __p_UQOerRAkmh3OHUjhll3ckm, __p_QuUj5N5Nlm3Mw3S9NClxmG = __p_QuUj5N5Nlm3Mw3S9NClxmG, __p_A0MNNAUYuFVNyR9vTGNSiB = __p_A0MNNAUYuFVNyR9vTGNSiB, __p_TEbOE3hfcbRNYbrCMYW3Of = __p_TEbOE3hfcbRNYbrCMYW3Of, __p_DfifmDyccYrLgrP64KFTpP = __p_DfifmDyccYrLgrP64KFTpP, __p_PsaAfzXD84KO93iaIihy7y = __p_PsaAfzXD84KO93iaIihy7y, __p_KVV2iJErwuVPVmTmLUPGTE = __p_KVV2iJErwuVPVmTmLUPGTE, __p_JnkgbH4fHoTQYTAn2zhIC3 = __p_JnkgbH4fHoTQYTAn2zhIC3} : that_0;
            else
            {
                this.__p_ATMlydFu917MUljuR3XEAl = __p_ATMlydFu917MUljuR3XEAl;
                this.__p_TyRkRvr8t7gObGTn74orhh = __p_TyRkRvr8t7gObGTn74orhh;
                this.__p_POo8Rr6hiVyO7crqq7ZKnu = __p_POo8Rr6hiVyO7crqq7ZKnu;
                this.__p_DcfTaJYXy5FL6eWvdem4Qs = __p_DcfTaJYXy5FL6eWvdem4Qs;
                this.__p_LsGSigw0PVVM0T35oaZzgO = __p_LsGSigw0PVVM0T35oaZzgO;
                this.__p_UQOerRAkmh3OHUjhll3ckm = __p_UQOerRAkmh3OHUjhll3ckm;
                this.__p_QuUj5N5Nlm3Mw3S9NClxmG = __p_QuUj5N5Nlm3Mw3S9NClxmG;
                this.__p_A0MNNAUYuFVNyR9vTGNSiB = __p_A0MNNAUYuFVNyR9vTGNSiB;
                this.__p_TEbOE3hfcbRNYbrCMYW3Of = __p_TEbOE3hfcbRNYbrCMYW3Of;
                this.__p_DfifmDyccYrLgrP64KFTpP = __p_DfifmDyccYrLgrP64KFTpP;
                this.__p_PsaAfzXD84KO93iaIihy7y = __p_PsaAfzXD84KO93iaIihy7y;
                this.__p_KVV2iJErwuVPVmTmLUPGTE = __p_KVV2iJErwuVPVmTmLUPGTE;
                this.__p_JnkgbH4fHoTQYTAn2zhIC3 = __p_JnkgbH4fHoTQYTAn2zhIC3;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 60847U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "AUeBaqjRxtyMQXqPbXlu4W", Name = "SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W")]
    [n2.SerializableAttribute]
    public class SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n21.SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W Create(n1.NodeContext Node_Context)
        {
            var instance = new SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n21.SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W CreateDefault()
        {
            var instance = new SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n21.SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W Join(n21.CameraControls_R Camera_Controls_In, n7.IMouse Mouse_Device_In, n7.IKeyboard Keyboard_Device_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n21.CameraControls_R Camera_Controls_Out)
        {
            string __pad_RTzx2ElnplUPWNiDyP0CMU_0 = __slot_RTzx2ElnplUPWNiDyP0CMU;
            string __pad_FmKMu7TH567QTYRBFUEtRT_1 = __slot_FmKMu7TH567QTYRBFUEtRT;
            float __pad_Uo6alaXXQutNMobmQV8DoX_2 = __slot_Uo6alaXXQutNMobmQV8DoX;
            string __pad_H5AozzvWbNSPyJRnGZaInv_3 = __slot_H5AozzvWbNSPyJRnGZaInv;
            float __pad_KAjrwoFFM7nQbJntaOJ0x9_4 = __slot_KAjrwoFFM7nQbJntaOJ0x9;
            float __pad_H5DBl3pAsqDPBDdGS63JdA_5 = __slot_H5DBl3pAsqDPBDdGS63JdA;
            string __pad_T7jqm3OjsmAPwREcoMH9Gh_6 = __slot_T7jqm3OjsmAPwREcoMH9Gh;
            float __pad_EAORjq9eEqsQcsSUBsjerc_7 = __slot_EAORjq9eEqsQcsSUBsjerc;
            float __pad_VVAXyGMXjeyLxT90LKyX0W_8 = __slot_VVAXyGMXjeyLxT90LKyX0W;
            float __pad_CoiyDgGcnJ7PV3MCn2hXvx_9 = __slot_CoiyDgGcnJ7PV3MCn2hXvx;
            var Output_20 = this.__p_ASXJHLEPWRkMgPkSUS4grL.Update(Mouse_Device_In: Mouse_Device_In, Position_In_World_Out: out n6.Vector2 Position_In_World_10, Position_In_Projection_Out: out n6.Vector2 Position_In_Projection_11, Position_Out: out n6.Vector2 Position_12, Left_Pressed_Out: out bool Left_Pressed_13, Middle_Pressed_Out: out bool Middle_Pressed_14, Right_Pressed_Out: out bool Right_Pressed_15, Normalized_Position_Out: out n6.Vector2 Normalized_Position_16, WheelDelta_Out: out int WheelDelta_17, Client_Area_Out: out n6.Vector2 Client_Area_18, Sender_Out: out n2.Object Sender_19);
            var Output_22 = this.__p_SUKyGjU8gVuLGxFjQbnqd7.Update<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Value_In: Position_In_Projection_11, Result_Out: out n6.Vector2 Result_21);
            n14.Vector2Nodes.Vector(input: ref Result_21, x: out float X_23, y: out float Y_24);
            var Output_26 = this.__p_O1gE9Sji7qTLrgAHqYDZOQ.Update(Keyboard_Device_In: Keyboard_Device_In, Pressed_Keys_Out: out n19.ImmutableHashSet<n18.Keys> Pressed_Keys_25);
            var Output_28 = this.__p_FeA0D0YTPs4L9Q7PF6Y0mB.Update(Keys_In: Pressed_Keys_25, Key_Name_In: __pad_T7jqm3OjsmAPwREcoMH9Gh_6, Is_Down_Out: out bool Is_Down_27);
            var Output_29 = Left_Pressed_13 && Is_Down_27;
            float Input_2_30 = n2.Convert.ToSingle(Output_29);
            var Output_31 = X_23 * Input_2_30;
            var Output_32 = Output_31 * __pad_EAORjq9eEqsQcsSUBsjerc_7;
            float __pad_U6FKNhjT9nuQKPvhnBxV9v_33 = Y_24;
            float Input_2_34 = n2.Convert.ToSingle(Output_29);
            var Output_35 = __pad_U6FKNhjT9nuQKPvhnBxV9v_33 * Input_2_34;
            var Output_36 = Output_35 * __pad_EAORjq9eEqsQcsSUBsjerc_7;
            var Output_38 = this.__p_LxX3YZTgoQ6NU3iiHBG1jC.Update(Keys_In: Pressed_Keys_25, Key_Name_In: __pad_H5AozzvWbNSPyJRnGZaInv_3, Is_Down_Out: out bool Is_Down_37);
            var Output_39 = Right_Pressed_15 && Is_Down_37;
            float Input_2_40 = n2.Convert.ToSingle(Output_39);
            var Output_41 = __pad_U6FKNhjT9nuQKPvhnBxV9v_33 * Input_2_40;
            var Output_42 = Output_41 * __pad_VVAXyGMXjeyLxT90LKyX0W_8;
            var Output_43 = Left_Pressed_13 && Is_Down_37;
            float Scalar_44 = n2.Convert.ToSingle(Output_43);
            n14.Vector2Nodes.Scale(input: ref Result_21, scalar: Scalar_44, output: out n6.Vector2 Output_45);
            n14.Vector2Nodes.Scale(input: ref Output_45, scalar: __pad_CoiyDgGcnJ7PV3MCn2hXvx_9, output: out n6.Vector2 Output_46);
            var Output_48 = this.__p_Cabk3E3DIGZMNQFZ39qrUA.Update(Keys_In: Pressed_Keys_25, Key_Name_In: __pad_RTzx2ElnplUPWNiDyP0CMU_0, Is_Down_Out: out bool Is_Down_47);
            var Output_49 = Left_Pressed_13 && Is_Down_47;
            float Input_3_50 = n2.Convert.ToSingle(Output_49);
            var Output_51 = __pad_U6FKNhjT9nuQKPvhnBxV9v_33 * __pad_H5DBl3pAsqDPBDdGS63JdA_5;
            var Output_52 = Output_51 * Input_3_50;
            var Output_53 = Right_Pressed_15 && Is_Down_47;
            float Input_3_54 = n2.Convert.ToSingle(Output_53);
            var Output_55 = __pad_U6FKNhjT9nuQKPvhnBxV9v_33 * __pad_KAjrwoFFM7nQbJntaOJ0x9_4;
            var Output_56 = Output_55 * Input_3_54;
            var Output_57 = Output_52 + Output_56;
            var Output_59 = this.__p_JW3BvWmk3n0P1I8Wnc75sY.Update(Keys_In: Pressed_Keys_25, Key_Name_In: __pad_FmKMu7TH567QTYRBFUEtRT_1, Is_Down_Out: out bool Is_Down_58);
            bool Reset_60 = false;
            var Output_63 = this.__p_MQbkHGkQUqQOQFME8ECTXr.Update(Set_In: Is_Down_58, Reset_In: Reset_60, Time_In: __pad_Uo6alaXXQutNMobmQV8DoX_2, Value_Out: out bool Value_61, Running_Out: out float Running_62);
            var Output_66 = this.__p_Aioj0yNEt4YNNL8NIh1yMC.Update(Value_In: Value_61, Up_Edge_Out: out bool Up_Edge_64, Down_Edge_Out: out bool Down_Edge_65);
            var Output_67 = Left_Pressed_13 || Right_Pressed_15;
            var Output_68 = Is_Down_27 || Is_Down_37;
            var Output_69 = Output_68 || Is_Down_47;
            var Output_70 = Output_67 && Output_69;
            var Output_71 = this.__p_DHzRhFZ6C7YOjiwk9pqpnZ;
            if (Output_70)
            {
                Output_71 = this.__p_DHzRhFZ6C7YOjiwk9pqpnZ.Set();
            }

            var Output_72 = !Output_67;
            var Output_73 = !Output_69;
            var Output_74 = Output_72 && Output_73;
            var Output_75 = Output_71;
            if (Output_74)
            {
                Output_75 = Output_71.Reset();
            }

            var Output_77 = Output_75.GetState(State_Out: out bool State_76);
            var Output_78 = Is_Down_58 || State_76;
            var Output_79 = !Output_78;
            var Output_80 = Camera_Controls_In;
            if (Enabled_In)
            {
                Output_80 = Camera_Controls_In.Combine(Longitude_Delta_In: Output_32, Latitude_Delta_In: Output_36, FOV_Delta_In: Output_42, Interest_Delta_In: Output_46, Distance_Delta_In: Output_57, Reset_In: Up_Edge_64, Idle_In: Output_79);
            }

            Camera_Controls_Out = Output_80;
            n21.SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W that_81 = this;
            if (this.__GetContext__().IsImmutable)
                that_81 = Output_20 != this.__p_ASXJHLEPWRkMgPkSUS4grL || Output_22 != this.__p_SUKyGjU8gVuLGxFjQbnqd7 || Output_26 != this.__p_O1gE9Sji7qTLrgAHqYDZOQ || Output_28 != this.__p_FeA0D0YTPs4L9Q7PF6Y0mB || Y_24 != this.__slot_U6FKNhjT9nuQKPvhnBxV9v || Output_38 != this.__p_LxX3YZTgoQ6NU3iiHBG1jC || Output_48 != this.__p_Cabk3E3DIGZMNQFZ39qrUA || Output_59 != this.__p_JW3BvWmk3n0P1I8Wnc75sY || Output_63 != this.__p_MQbkHGkQUqQOQFME8ECTXr || Output_66 != this.__p_Aioj0yNEt4YNNL8NIh1yMC || Output_77 != this.__p_DHzRhFZ6C7YOjiwk9pqpnZ ? new SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W(this)
                {__p_ASXJHLEPWRkMgPkSUS4grL = Output_20, __p_SUKyGjU8gVuLGxFjQbnqd7 = Output_22, __p_O1gE9Sji7qTLrgAHqYDZOQ = Output_26, __p_FeA0D0YTPs4L9Q7PF6Y0mB = Output_28, __slot_U6FKNhjT9nuQKPvhnBxV9v = Y_24, __p_LxX3YZTgoQ6NU3iiHBG1jC = Output_38, __p_Cabk3E3DIGZMNQFZ39qrUA = Output_48, __p_JW3BvWmk3n0P1I8Wnc75sY = Output_59, __p_MQbkHGkQUqQOQFME8ECTXr = Output_63, __p_Aioj0yNEt4YNNL8NIh1yMC = Output_66, __p_DHzRhFZ6C7YOjiwk9pqpnZ = Output_77} : that_81;
            else
            {
                this.__p_ASXJHLEPWRkMgPkSUS4grL = Output_20;
                this.__p_SUKyGjU8gVuLGxFjQbnqd7 = Output_22;
                this.__p_O1gE9Sji7qTLrgAHqYDZOQ = Output_26;
                this.__p_FeA0D0YTPs4L9Q7PF6Y0mB = Output_28;
                this.__slot_U6FKNhjT9nuQKPvhnBxV9v = Y_24;
                this.__p_LxX3YZTgoQ6NU3iiHBG1jC = Output_38;
                this.__p_Cabk3E3DIGZMNQFZ39qrUA = Output_48;
                this.__p_JW3BvWmk3n0P1I8Wnc75sY = Output_59;
                this.__p_MQbkHGkQUqQOQFME8ECTXr = Output_63;
                this.__p_Aioj0yNEt4YNNL8NIh1yMC = Output_66;
                this.__p_DHzRhFZ6C7YOjiwk9pqpnZ = Output_77;
            }

            return that_81;
        }

        public n21.SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "ASXJHLEPWRkMgPkSUS4grL", 60925U);
            var Output_1 = n24.MouseState_BNOhaxXysw1MZBzyJMI18t.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "O1gE9Sji7qTLrgAHqYDZOQ", 60951U);
            var Output_3 = n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "JW3BvWmk3n0P1I8Wnc75sY", 60970U);
            var Output_5 = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "LxX3YZTgoQ6NU3iiHBG1jC", 60979U);
            var Output_7 = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "FeA0D0YTPs4L9Q7PF6Y0mB", 60987U);
            var Output_9 = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "Cabk3E3DIGZMNQFZ39qrUA", 60994U);
            var Output_11 = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.Create(Node_Context: Node_Context_10);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "SUKyGjU8gVuLGxFjQbnqd7", 61013U);
            var Output_13 = n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector2>.Create<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Node_Context: Node_Context_12);
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "MQbkHGkQUqQOQFME8ECTXr", 61019U);
            n31.IClock Clock_15 = n30._Operations_.CreateDefault();
            var Output_16 = n16.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H.Create(Node_Context: Node_Context_14, Clock_In: Clock_15);
            n1.NodeContext Node_Context_17 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "Aioj0yNEt4YNNL8NIh1yMC", 61085U);
            var Output_18 = n16.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_17);
            n1.NodeContext Node_Context_19 = Node_Context.CreateSubContext("USVpn2wMsrSLK5oj1XAsi5", "DHzRhFZ6C7YOjiwk9pqpnZ", 61135U);
            var Output_20 = n16.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.Create(Node_Context: Node_Context_19);
            n21.SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W that_21 = this;
            this.__slot_U6FKNhjT9nuQKPvhnBxV9v = 0F;
            this.__p_ASXJHLEPWRkMgPkSUS4grL = Output_1;
            this.__p_O1gE9Sji7qTLrgAHqYDZOQ = Output_3;
            this.__p_JW3BvWmk3n0P1I8Wnc75sY = Output_5;
            this.__p_LxX3YZTgoQ6NU3iiHBG1jC = Output_7;
            this.__p_FeA0D0YTPs4L9Q7PF6Y0mB = Output_9;
            this.__p_Cabk3E3DIGZMNQFZ39qrUA = Output_11;
            this.__p_SUKyGjU8gVuLGxFjQbnqd7 = Output_13;
            this.__p_MQbkHGkQUqQOQFME8ECTXr = Output_16;
            this.__p_Aioj0yNEt4YNNL8NIh1yMC = Output_18;
            this.__p_DHzRhFZ6C7YOjiwk9pqpnZ = Output_20;
            return that_21;
        }

        public n21.SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W __CreateDefault__()
        {
            n21.SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W that_0 = this;
            this.__slot_U6FKNhjT9nuQKPvhnBxV9v = 0F;
            this.__p_ASXJHLEPWRkMgPkSUS4grL = n24.MouseState_BNOhaxXysw1MZBzyJMI18t.CreateDefault();
            this.__p_SUKyGjU8gVuLGxFjQbnqd7 = n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector2>.CreateDefault<n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>();
            this.__p_O1gE9Sji7qTLrgAHqYDZOQ = n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ.CreateDefault();
            this.__p_FeA0D0YTPs4L9Q7PF6Y0mB = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_LxX3YZTgoQ6NU3iiHBG1jC = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_Cabk3E3DIGZMNQFZ39qrUA = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_JW3BvWmk3n0P1I8Wnc75sY = n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv.CreateDefault();
            this.__p_MQbkHGkQUqQOQFME8ECTXr = n16.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H.CreateDefault();
            this.__p_Aioj0yNEt4YNNL8NIh1yMC = n16.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_DHzRhFZ6C7YOjiwk9pqpnZ = n16.FlipFlop_CJjTkCTbntqL2s5d9CL0vC.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_ASXJHLEPWRkMgPkSUS4grL);
            n1.CompilationHelper.SafeDispose(this.__p_SUKyGjU8gVuLGxFjQbnqd7);
            n1.CompilationHelper.SafeDispose(this.__p_O1gE9Sji7qTLrgAHqYDZOQ);
            n1.CompilationHelper.SafeDispose(this.__p_FeA0D0YTPs4L9Q7PF6Y0mB);
            n1.CompilationHelper.SafeDispose(this.__p_LxX3YZTgoQ6NU3iiHBG1jC);
            n1.CompilationHelper.SafeDispose(this.__p_Cabk3E3DIGZMNQFZ39qrUA);
            n1.CompilationHelper.SafeDispose(this.__p_JW3BvWmk3n0P1I8Wnc75sY);
            n1.CompilationHelper.SafeDispose(this.__p_MQbkHGkQUqQOQFME8ECTXr);
            n1.CompilationHelper.SafeDispose(this.__p_Aioj0yNEt4YNNL8NIh1yMC);
            n1.CompilationHelper.SafeDispose(this.__p_DHzRhFZ6C7YOjiwk9pqpnZ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 60896U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "FmKMu7TH567QTYRBFUEtRT", Name = "__slot_FmKMu7TH567QTYRBFUEtRT")]
        public static string __slot_FmKMu7TH567QTYRBFUEtRT = "R";
        [n1.ElementAttribute(TracingId = 60898U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "H5AozzvWbNSPyJRnGZaInv", Name = "__slot_H5AozzvWbNSPyJRnGZaInv")]
        public static string __slot_H5AozzvWbNSPyJRnGZaInv = "Z";
        [n1.ElementAttribute(TracingId = 60902U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "T7jqm3OjsmAPwREcoMH9Gh", Name = "__slot_T7jqm3OjsmAPwREcoMH9Gh")]
        public static string __slot_T7jqm3OjsmAPwREcoMH9Gh = "O";
        [n1.ElementAttribute(TracingId = 60905U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "RTzx2ElnplUPWNiDyP0CMU", Name = "__slot_RTzx2ElnplUPWNiDyP0CMU")]
        public static string __slot_RTzx2ElnplUPWNiDyP0CMU = "P";
        [n1.ElementAttribute(TracingId = 60908U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Uo6alaXXQutNMobmQV8DoX", Name = "__slot_Uo6alaXXQutNMobmQV8DoX")]
        public static float __slot_Uo6alaXXQutNMobmQV8DoX = 0.5F;
        [n1.ElementAttribute(TracingId = 60911U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "H5DBl3pAsqDPBDdGS63JdA", Name = "__slot_H5DBl3pAsqDPBDdGS63JdA")]
        public static float __slot_H5DBl3pAsqDPBDdGS63JdA = 1F;
        [n1.ElementAttribute(TracingId = 60915U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "KAjrwoFFM7nQbJntaOJ0x9", Name = "__slot_KAjrwoFFM7nQbJntaOJ0x9")]
        public static float __slot_KAjrwoFFM7nQbJntaOJ0x9 = 5F;
        [n1.ElementAttribute(TracingId = 61234U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "EAORjq9eEqsQcsSUBsjerc", Name = "__slot_EAORjq9eEqsQcsSUBsjerc")]
        public static float __slot_EAORjq9eEqsQcsSUBsjerc = 0.25F;
        [n1.ElementAttribute(TracingId = 61238U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "VVAXyGMXjeyLxT90LKyX0W", Name = "__slot_VVAXyGMXjeyLxT90LKyX0W")]
        public static float __slot_VVAXyGMXjeyLxT90LKyX0W = 0.01F;
        [n1.ElementAttribute(TracingId = 61239U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "U6FKNhjT9nuQKPvhnBxV9v", Name = "__slot_U6FKNhjT9nuQKPvhnBxV9v")]
        public float __slot_U6FKNhjT9nuQKPvhnBxV9v;
        [n1.ElementAttribute(TracingId = 61242U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "CoiyDgGcnJ7PV3MCn2hXvx", Name = "__slot_CoiyDgGcnJ7PV3MCn2hXvx")]
        public static float __slot_CoiyDgGcnJ7PV3MCn2hXvx = 1F;
        [n1.ElementAttribute(TracingId = 61244U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "GoVN7pE5txhMxsrVzvGlcl", Name = "__slot_GoVN7pE5txhMxsrVzvGlcl")]
        public static string __slot_GoVN7pE5txhMxsrVzvGlcl = "SPEEDS";
        [n1.ElementAttribute(TracingId = 60925U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "ASXJHLEPWRkMgPkSUS4grL", Name = "MouseState", IsManaged = true, IsAutoGenerated = true)]
        public n24.MouseState_BNOhaxXysw1MZBzyJMI18t __p_ASXJHLEPWRkMgPkSUS4grL;
        [n1.ElementAttribute(TracingId = 61013U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "SUKyGjU8gVuLGxFjQbnqd7", Name = "FrameDifference", IsManaged = true, IsAutoGenerated = true)]
        public n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector2> __p_SUKyGjU8gVuLGxFjQbnqd7;
        [n1.ElementAttribute(TracingId = 60951U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "O1gE9Sji7qTLrgAHqYDZOQ", Name = "KeyboardState", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_O1gE9Sji7qTLrgAHqYDZOQ;
        [n1.ElementAttribute(TracingId = 60987U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "FeA0D0YTPs4L9Q7PF6Y0mB", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_FeA0D0YTPs4L9Q7PF6Y0mB;
        [n1.ElementAttribute(TracingId = 60979U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "LxX3YZTgoQ6NU3iiHBG1jC", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_LxX3YZTgoQ6NU3iiHBG1jC;
        [n1.ElementAttribute(TracingId = 60994U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Cabk3E3DIGZMNQFZ39qrUA", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Cabk3E3DIGZMNQFZ39qrUA;
        [n1.ElementAttribute(TracingId = 60970U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "JW3BvWmk3n0P1I8Wnc75sY", Name = "KeyMatch", IsManaged = true, IsAutoGenerated = true)]
        public n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_JW3BvWmk3n0P1I8Wnc75sY;
        [n1.ElementAttribute(TracingId = 61019U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "MQbkHGkQUqQOQFME8ECTXr", Name = "TimerFlop", IsManaged = true, IsAutoGenerated = true)]
        public n16.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H __p_MQbkHGkQUqQOQFME8ECTXr;
        [n1.ElementAttribute(TracingId = 61085U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "Aioj0yNEt4YNNL8NIh1yMC", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n16.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Aioj0yNEt4YNNL8NIh1yMC;
        [n1.ElementAttribute(TracingId = 61135U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "DHzRhFZ6C7YOjiwk9pqpnZ", Name = "FlipFlop", IsManaged = true, IsAutoGenerated = true)]
        public n16.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_DHzRhFZ6C7YOjiwk9pqpnZ;
        static SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W()
        {
        }

        public SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W(SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W other): base(other)
        {
            this.__slot_U6FKNhjT9nuQKPvhnBxV9v = other.__slot_U6FKNhjT9nuQKPvhnBxV9v;
            this.__p_ASXJHLEPWRkMgPkSUS4grL = other.__p_ASXJHLEPWRkMgPkSUS4grL;
            this.__p_SUKyGjU8gVuLGxFjQbnqd7 = other.__p_SUKyGjU8gVuLGxFjQbnqd7;
            this.__p_O1gE9Sji7qTLrgAHqYDZOQ = other.__p_O1gE9Sji7qTLrgAHqYDZOQ;
            this.__p_FeA0D0YTPs4L9Q7PF6Y0mB = other.__p_FeA0D0YTPs4L9Q7PF6Y0mB;
            this.__p_LxX3YZTgoQ6NU3iiHBG1jC = other.__p_LxX3YZTgoQ6NU3iiHBG1jC;
            this.__p_Cabk3E3DIGZMNQFZ39qrUA = other.__p_Cabk3E3DIGZMNQFZ39qrUA;
            this.__p_JW3BvWmk3n0P1I8Wnc75sY = other.__p_JW3BvWmk3n0P1I8Wnc75sY;
            this.__p_MQbkHGkQUqQOQFME8ECTXr = other.__p_MQbkHGkQUqQOQFME8ECTXr;
            this.__p_Aioj0yNEt4YNNL8NIh1yMC = other.__p_Aioj0yNEt4YNNL8NIh1yMC;
            this.__p_DHzRhFZ6C7YOjiwk9pqpnZ = other.__p_DHzRhFZ6C7YOjiwk9pqpnZ;
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_U6FKNhjT9nuQKPvhnBxV9v", in __slot_U6FKNhjT9nuQKPvhnBxV9v), n1.CompilationHelper.GetValueOrExisting(values, "__p_ASXJHLEPWRkMgPkSUS4grL", in __p_ASXJHLEPWRkMgPkSUS4grL), n1.CompilationHelper.GetValueOrExisting(values, "__p_SUKyGjU8gVuLGxFjQbnqd7", in __p_SUKyGjU8gVuLGxFjQbnqd7), n1.CompilationHelper.GetValueOrExisting(values, "__p_O1gE9Sji7qTLrgAHqYDZOQ", in __p_O1gE9Sji7qTLrgAHqYDZOQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_FeA0D0YTPs4L9Q7PF6Y0mB", in __p_FeA0D0YTPs4L9Q7PF6Y0mB), n1.CompilationHelper.GetValueOrExisting(values, "__p_LxX3YZTgoQ6NU3iiHBG1jC", in __p_LxX3YZTgoQ6NU3iiHBG1jC), n1.CompilationHelper.GetValueOrExisting(values, "__p_Cabk3E3DIGZMNQFZ39qrUA", in __p_Cabk3E3DIGZMNQFZ39qrUA), n1.CompilationHelper.GetValueOrExisting(values, "__p_JW3BvWmk3n0P1I8Wnc75sY", in __p_JW3BvWmk3n0P1I8Wnc75sY), n1.CompilationHelper.GetValueOrExisting(values, "__p_MQbkHGkQUqQOQFME8ECTXr", in __p_MQbkHGkQUqQOQFME8ECTXr), n1.CompilationHelper.GetValueOrExisting(values, "__p_Aioj0yNEt4YNNL8NIh1yMC", in __p_Aioj0yNEt4YNNL8NIh1yMC), n1.CompilationHelper.GetValueOrExisting(values, "__p_DHzRhFZ6C7YOjiwk9pqpnZ", in __p_DHzRhFZ6C7YOjiwk9pqpnZ));
        }

        internal SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W __WITH__(float __slot_U6FKNhjT9nuQKPvhnBxV9v, n24.MouseState_BNOhaxXysw1MZBzyJMI18t __p_ASXJHLEPWRkMgPkSUS4grL, n29.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector2> __p_SUKyGjU8gVuLGxFjQbnqd7, n25.KeyboardState_FWRYiZyypwZPvLPUVDhSgJ __p_O1gE9Sji7qTLrgAHqYDZOQ, n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_FeA0D0YTPs4L9Q7PF6Y0mB, n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_LxX3YZTgoQ6NU3iiHBG1jC, n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_Cabk3E3DIGZMNQFZ39qrUA, n25.KeyMatch_Pj2Pg6KELmnQZbr7B4gLzv __p_JW3BvWmk3n0P1I8Wnc75sY, n16.TimerFlop_FdX7N0Rk7AuQXGSKZzxW0H __p_MQbkHGkQUqQOQFME8ECTXr, n16.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_Aioj0yNEt4YNNL8NIh1yMC, n16.FlipFlop_CJjTkCTbntqL2s5d9CL0vC __p_DHzRhFZ6C7YOjiwk9pqpnZ)
        {
            n21.SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_U6FKNhjT9nuQKPvhnBxV9v != this.__slot_U6FKNhjT9nuQKPvhnBxV9v || __p_ASXJHLEPWRkMgPkSUS4grL != this.__p_ASXJHLEPWRkMgPkSUS4grL || __p_SUKyGjU8gVuLGxFjQbnqd7 != this.__p_SUKyGjU8gVuLGxFjQbnqd7 || __p_O1gE9Sji7qTLrgAHqYDZOQ != this.__p_O1gE9Sji7qTLrgAHqYDZOQ || __p_FeA0D0YTPs4L9Q7PF6Y0mB != this.__p_FeA0D0YTPs4L9Q7PF6Y0mB || __p_LxX3YZTgoQ6NU3iiHBG1jC != this.__p_LxX3YZTgoQ6NU3iiHBG1jC || __p_Cabk3E3DIGZMNQFZ39qrUA != this.__p_Cabk3E3DIGZMNQFZ39qrUA || __p_JW3BvWmk3n0P1I8Wnc75sY != this.__p_JW3BvWmk3n0P1I8Wnc75sY || __p_MQbkHGkQUqQOQFME8ECTXr != this.__p_MQbkHGkQUqQOQFME8ECTXr || __p_Aioj0yNEt4YNNL8NIh1yMC != this.__p_Aioj0yNEt4YNNL8NIh1yMC || __p_DHzRhFZ6C7YOjiwk9pqpnZ != this.__p_DHzRhFZ6C7YOjiwk9pqpnZ ? new SoftimageCameraControls_AUeBaqjRxtyMQXqPbXlu4W(this)
                {__slot_U6FKNhjT9nuQKPvhnBxV9v = __slot_U6FKNhjT9nuQKPvhnBxV9v, __p_ASXJHLEPWRkMgPkSUS4grL = __p_ASXJHLEPWRkMgPkSUS4grL, __p_SUKyGjU8gVuLGxFjQbnqd7 = __p_SUKyGjU8gVuLGxFjQbnqd7, __p_O1gE9Sji7qTLrgAHqYDZOQ = __p_O1gE9Sji7qTLrgAHqYDZOQ, __p_FeA0D0YTPs4L9Q7PF6Y0mB = __p_FeA0D0YTPs4L9Q7PF6Y0mB, __p_LxX3YZTgoQ6NU3iiHBG1jC = __p_LxX3YZTgoQ6NU3iiHBG1jC, __p_Cabk3E3DIGZMNQFZ39qrUA = __p_Cabk3E3DIGZMNQFZ39qrUA, __p_JW3BvWmk3n0P1I8Wnc75sY = __p_JW3BvWmk3n0P1I8Wnc75sY, __p_MQbkHGkQUqQOQFME8ECTXr = __p_MQbkHGkQUqQOQFME8ECTXr, __p_Aioj0yNEt4YNNL8NIh1yMC = __p_Aioj0yNEt4YNNL8NIh1yMC, __p_DHzRhFZ6C7YOjiwk9pqpnZ = __p_DHzRhFZ6C7YOjiwk9pqpnZ} : that_0;
            else
            {
                this.__slot_U6FKNhjT9nuQKPvhnBxV9v = __slot_U6FKNhjT9nuQKPvhnBxV9v;
                this.__p_ASXJHLEPWRkMgPkSUS4grL = __p_ASXJHLEPWRkMgPkSUS4grL;
                this.__p_SUKyGjU8gVuLGxFjQbnqd7 = __p_SUKyGjU8gVuLGxFjQbnqd7;
                this.__p_O1gE9Sji7qTLrgAHqYDZOQ = __p_O1gE9Sji7qTLrgAHqYDZOQ;
                this.__p_FeA0D0YTPs4L9Q7PF6Y0mB = __p_FeA0D0YTPs4L9Q7PF6Y0mB;
                this.__p_LxX3YZTgoQ6NU3iiHBG1jC = __p_LxX3YZTgoQ6NU3iiHBG1jC;
                this.__p_Cabk3E3DIGZMNQFZ39qrUA = __p_Cabk3E3DIGZMNQFZ39qrUA;
                this.__p_JW3BvWmk3n0P1I8Wnc75sY = __p_JW3BvWmk3n0P1I8Wnc75sY;
                this.__p_MQbkHGkQUqQOQFME8ECTXr = __p_MQbkHGkQUqQOQFME8ECTXr;
                this.__p_Aioj0yNEt4YNNL8NIh1yMC = __p_Aioj0yNEt4YNNL8NIh1yMC;
                this.__p_DHzRhFZ6C7YOjiwk9pqpnZ = __p_DHzRhFZ6C7YOjiwk9pqpnZ;
            }

            return that_0;
        }
    }
}

namespace _VL_Cameras_.Editors
{
    [n1.ElementAttribute(TracingId = 61350U, DocumentId = "USVpn2wMsrSLK5oj1XAsi5", PersistentId = "KufR6HoJJ0tMFJWFmyb2N5", Name = "VL_CamerasApplication_KufR6HoJJ0tMFJWFmyb2N5")]
    [n2.SerializableAttribute]
    public class VL_CamerasApplication_KufR6HoJJ0tMFJWFmyb2N5 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n27.VL_CamerasApplication_KufR6HoJJ0tMFJWFmyb2N5 Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_CamerasApplication_KufR6HoJJ0tMFJWFmyb2N5(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n27.VL_CamerasApplication_KufR6HoJJ0tMFJWFmyb2N5 CreateDefault()
        {
            var instance = new VL_CamerasApplication_KufR6HoJJ0tMFJWFmyb2N5(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n27.VL_CamerasApplication_KufR6HoJJ0tMFJWFmyb2N5 Update()
        {
            return this;
        }

        public n27.VL_CamerasApplication_KufR6HoJJ0tMFJWFmyb2N5 __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n27.VL_CamerasApplication_KufR6HoJJ0tMFJWFmyb2N5 __CreateDefault__()
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

        public VL_CamerasApplication_KufR6HoJJ0tMFJWFmyb2N5(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_CamerasApplication_KufR6HoJJ0tMFJWFmyb2N5(VL_CamerasApplication_KufR6HoJJ0tMFJWFmyb2N5 other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n9.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_CamerasApplication_KufR6HoJJ0tMFJWFmyb2N5 __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Cameras_
{
    public struct __AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5 : n37.IAdaptiveOperatorGreater<float>, n37.IAdaptiveOperatorLess<float>, n38.IAdaptiveCreateDefault<n6.Vector2>, n37.IAdaptiveOperatorMinus<n6.Vector2>, n38.IAdaptiveCreateDefault<int>, n37.IAdaptiveOperatorMinus<int>, n37.IAdaptiveMax<float>, n37.IAdaptiveMin<float>, n38.IAdaptiveCreateDefault<float>, n37.IAdaptiveAvoidNaN<float>, n37.IAdaptiveIsNaN<float>, n37.IAdaptiveNE<float>, n37.IAdaptiveLerp<float>, n37.IAdaptiveAvoidNaN<n6.Vector2>, n37.IAdaptiveNE<n6.Vector2>, n37.IAdaptiveLerp<n6.Vector2>
    {
        public void OperatorGreater(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In > Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void OperatorLess(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void CreateDefault(out n6.Vector2 Output_Out)
        {
            var Zero_0 = n17._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }

        public void OperatorMinus(n6.Vector2 Input_In, n6.Vector2 Input_2_In, out n6.Vector2 Output_Out)
        {
            n6.Vector2.Subtract(left: ref Input_In, right: ref Input_2_In, result: out n6.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out int Output_Out)
        {
            n34._Operations_.CreateDefault_Generic<int>(Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus(int Input_In, int Input_2_In, out int Output_Out)
        {
            var Output_0 = Input_In - Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void Max(float Input_In, float Input_2_In, out float Output_Out)
        {
            n13._Operations_.Max<float, n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Min(float Input_In, float Input_2_In, out float Output_Out)
        {
            n13._Operations_.Min<float, n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out float Output_Out)
        {
            n34._Operations_.CreateDefault_Generic<float>(Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void AvoidNaN(float Input_In, float Default_In, out float Output_Out)
        {
            n35._Operations_.AvoidNaN<float, n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Input_In: Input_In, Default_In: Default_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void IsNaN(float Input_In, out bool Result_Out)
        {
            n35._Operations_.IsNaN<float, n12.__AdaptiveImplementations__USVpn2wMsrSLK5oj1XAsi5>(Input_In: Input_In, Result_Out: out bool Result_0);
            Result_Out = Result_0;
            return;
        }

        public void NE(float Input_In, float Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In != Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void Lerp(float Input_In, float Input_2_In, float Scalar_In, out float Output_Out)
        {
            var Output_0 = n36.Float32Extensions.Lerp(input: Input_In, input2: Input_2_In, scalar: Scalar_In);
            Output_Out = Output_0;
            return;
        }

        public void AvoidNaN(n6.Vector2 Input_In, n6.Vector2 Default_In, out n6.Vector2 Output_Out)
        {
            n17._Operations_.AvoidNaN(Input_In: Input_In, Default_In: Default_In, Output_Out: out n6.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void NE(n6.Vector2 Input_In, n6.Vector2 Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In != Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void Lerp(n6.Vector2 Input_In, n6.Vector2 Input_2_In, float Scalar_In, out n6.Vector2 Output_Out)
        {
            var Output_0 = n14.Vector2Nodes.Lerp(input: ref Input_In, input2: ref Input_2_In, scalar: Scalar_In);
            Output_Out = Output_0;
            return;
        }
    }
}