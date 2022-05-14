extern alias e31;
extern alias e2;
extern alias e40;
extern alias e24;
extern alias e5;
extern alias e1;

using n31 = e2::VL.Lib.Primitive;
using n25 = _CoreLibBasics_.Primitive.Object.Advanced;
using n24 = _CoreLibBasics_.Control;
using n17 = e40::VL.Stride.Utils;
using n30 = _VL_Stride_Input_.Stride;
using n14 = e2::VL.Lib.Mathematics;
using n3 = _VL_Stride_Input_.Stride.Input.Experimental;
using n7 = e31::Stride.Input;
using n6 = e2::VL.Lib.Primitive.Object;
using n4 = e5::VL.Core.CompilerServices;
using n23 = global::System.Collections.Generic;
using n10 = _CoreLibBasics_._2D.Vector2;
using n5 = e1::Stride.Core.Mathematics;
using n13 = _CoreLibBasics_.Math.Generic;
using n33 = _CoreLibBasics_.Math.Adaptive;
using n16 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Engine.Entity.Advanced;
using n34 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n19 = e40::VL.Stride.Input;
using n26 = e2::VL.Lib.Primitive.CacheRegion;
using n12 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n27 = e40::VL.Stride;
using n15 = e24::Stride.Engine;
using n1 = e5::VL.Core;
using n28 = e5::VL.Lib.Basics.Resources;
using n2 = global::System;
using n9 = _VL_Stride_Input_.Stride.Input;
using n11 = _VL_Stride_Input_;
using n21 = global::System.Runtime.CompilerServices;
using n22 = _CoreLibBasics_._3D.Plane;
using n8 = e5::VL.Lib.Collections;
using n20 = _VL_Collections_.Collections.Spread;
using n29 = _CoreLibBasics_.System.Resources.Advanced;
using n32 = _CoreLibBasics_.Primitive.Advanced;
using n18 = _CoreLibBasics_._3D.Vector3;

namespace _VL_Stride_Input_.Stride.Input.Experimental
{
    [n1.ElementAttribute(TracingId = 105926U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "NVfomf0AapPPGXo2RcefKg", Name = "SplitMouseDevice_NVfomf0AapPPGXo2RcefKg")]
    [n2.SerializableAttribute]
    public class SplitMouseDevice_NVfomf0AapPPGXo2RcefKg : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SplitMouseDevice_NVfomf0AapPPGXo2RcefKg Create(n1.NodeContext Node_Context)
        {
            var instance = new SplitMouseDevice_NVfomf0AapPPGXo2RcefKg(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SplitMouseDevice_NVfomf0AapPPGXo2RcefKg CreateDefault()
        {
            var instance = new SplitMouseDevice_NVfomf0AapPPGXo2RcefKg(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SplitMouseDevice_NVfomf0AapPPGXo2RcefKg Update(n7.IMouseDevice Input_In, n15.Entity Camera_In, out n5.Vector2 Position_in_World_Out, out n5.Ray Ray_Out, out n5.Vector2 Position_in_Projection_Out, out n5.Vector2 Position_Out, out bool Left_Pressed_Out, out bool Middle_Pressed_Out, out bool Right_Pressed_Out, out bool Extended_1_Pressed_Out, out bool Extended_2_Pressed_Out, out n5.Vector2 Delta_Out, out float Mouse_Wheel_Delta_Out, out n5.Vector2 Surface_Size_Out, out float Surface_Aspect_Ratio_Out, out n8.Spread<n7.InputEvent> Events_Out)
        {
            n5.Plane __pad_FsWX8DkOUxwPKyY0Cg5qfq_0 = this.__slot_FsWX8DkOUxwPKyY0Cg5qfq;
            n6.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            n7.IPointerDevice Input_3 = (n7.IPointerDevice)Input_In;
            n5.Vector2 __auto_4;
            n5.Ray __auto_5;
            n5.Vector2 __auto_6;
            n5.Vector2 __auto_7;
            bool __auto_8;
            bool __auto_9;
            bool __auto_10;
            bool __auto_11;
            bool __auto_12;
            n5.Vector2 __auto_13;
            float __auto_14;
            n5.Vector2 __auto_15;
            float __auto_16;
            n8.Spread<n7.InputEvent> __auto_17;
            var state_18 = n1.CompilationHelper.Restore<__EytyPwxhy4mNiz5cwbHbJN>(this.__if_Poy5VcoUkngO6X37DwqsRv, __GetContext__());
            if (Result_1)
            {
                if (state_18 == null)
                {
                    state_18 = new __EytyPwxhy4mNiz5cwbHbJN(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_IfWsiidGJykMnXhF1xbZH6 = n20._Operations_.CreateDefault<n7.InputEvent>()};
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("HWRqGEFJG2aNE9pYb5Pg0w", "L9oKcFOwokzPfHAUPgKTVj", 105970U);
                    var Output_20 = n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY.Create(Node_Context_In: Node_Context_19);
                    state_18.__p_L9oKcFOwokzPfHAUPgKTVj = Output_20;
                }

                n7.MouseButton __pad_PQYIAZl25UNLedW2sX0USI_21 = __slot_PQYIAZl25UNLedW2sX0USI;
                n7.MouseButton __pad_PUZpoETaYnWLOZRqiBFjG7_22 = __slot_PUZpoETaYnWLOZRqiBFjG7;
                n7.MouseButton __pad_HViVtoX1iJMPy3Ti3tUgxw_23 = __slot_HViVtoX1iJMPy3Ti3tUgxw;
                n7.MouseButton __pad_BbHJGhBilkjM8R7pQm1o1R_24 = __slot_BbHJGhBilkjM8R7pQm1o1R;
                n7.MouseButton __pad_BIgUCnlRGLcMY9WN2Y9uz0_25 = __slot_BIgUCnlRGLcMY9WN2Y9uz0;
                var Position_26 = Input_In.Position;
                __auto_7 = Position_26;
                n5.Vector2 Input_Minimum_27 = n10._Operations_.CreateDefault();
                n5.Vector2 Input_Maximum_28 = __c_I8zaiM9a5WMNIKkI3LzF0D;
                n5.Vector2 Output_Minimum_29 = __c_OZ63URYdgcANRJGljdhYkz;
                n5.Vector2 Output_Maximum_30 = __c_SucGUfpsRTWPWnQSliDgta;
                n12._Operations_.Map<n5.Vector2, n11.__AdaptiveImplementations__HWRqGEFJG2aNE9pYb5Pg0w>(Input_In: Position_26, Input_Minimum_In: Input_Minimum_27, Input_Maximum_In: Input_Maximum_28, Output_Minimum_In: Output_Minimum_29, Output_Maximum_In: Output_Maximum_30, Output_Out: out n5.Vector2 Output_31);
                __auto_6 = Output_31;
                var Surface_Size_32 = Input_3.SurfaceSize;
                var Surface_Aspect_Ratio_33 = Input_3.SurfaceAspectRatio;
                n13._Operations_.OneOver<float, n11.__AdaptiveImplementations__HWRqGEFJG2aNE9pYb5Pg0w>(Input_In: Surface_Aspect_Ratio_33, Output_Out: out float Output_34);
                float Y_35 = 1F;
                var Output_36 = new n5.Vector2(x: Output_34, y: Y_35);
                n14.Vector2Nodes.Multiply(left: ref Output_31, right: ref Output_36, result: out n5.Vector2 Output_37);
                __auto_15 = Surface_Size_32;
                __auto_16 = Surface_Aspect_Ratio_33;
                n6.ObjectHelpers.IsAssigned(x: Camera_In, result: out bool Result_38, notAssigned: out bool Not_Assigned_39);
                n5.Vector2 __auto_40;
                n5.Ray __auto_41;
                if (Result_38)
                {
                    n16._Operations_.GetComponent<n15.CameraComponent>(Input_In: Camera_In, Output_Out: out n15.Entity Output_43, Result_Out: out n15.CameraComponent Result_44);
                    Result_44.Update();
                    var Result_45 = n17.CameraUtils.ScreenToWorldRay(cameraComponent: Result_44, position: Position_26, mouseSurfaceAspect: Output_34);
                    var Result_47 = n5.CollisionHelper.RayIntersectsPlane(ray: ref Result_45, plane: ref __pad_FsWX8DkOUxwPKyY0Cg5qfq_0, point: out n5.Vector3 Point_46);
                    n18._Operations_.XY(Input_In: Point_46, Output_Out: out n5.Vector2 Output_48);
                    __auto_40 = Output_48;
                    __auto_41 = Result_45;
                }
                else
                {
                    __auto_40 = Output_37;
                    __auto_41 = default(n5.Ray);
                }

                __auto_4 = __auto_40;
                __auto_5 = __auto_41;
                var Result_49 = n19.InputNodes.IsButtonDown(input: Input_In, mouseButton: __pad_PQYIAZl25UNLedW2sX0USI_21);
                __auto_8 = Result_49;
                var Delta_50 = Input_In.Delta;
                __auto_13 = Delta_50;
                var State_Output_52 = state_18.__p_L9oKcFOwokzPfHAUPgKTVj.Update(Output_Out: out n7.InputManager Output_51);
                var Events_53 = Output_51.Events;
                var Mouse_Wheel_Delta_54 = Output_51.MouseWheelDelta;
                var builder_62 = n4.CollectionBuilders.GetBuilder(state_18.__cp_IfWsiidGJykMnXhF1xbZH6, 16);
                n8.Spread<n7.InputEvent> output_63;
                try
                {
                    var i_57 = 0;
                    foreach (var item_55 in Events_53)
                    {
                        var splicer_56 = item_55;
                        var i_local_58 = i_57;
                        var Device_60 = splicer_56.Device;
                        var Result_61 = n6.ObjectHelpers.Eq(input: Input_In, input2: Device_60);
                        if (Result_61)
                        {
                            builder_62.Add(splicer_56);
                        }

                        i_57++;
                    }
                }
                finally
                {
                    output_63 = builder_62.Commit();
                }

                __auto_17 = output_63;
                __auto_14 = Mouse_Wheel_Delta_54;
                var Result_64 = n19.InputNodes.IsButtonDown(input: Input_In, mouseButton: __pad_PUZpoETaYnWLOZRqiBFjG7_22);
                __auto_9 = Result_64;
                var Result_65 = n19.InputNodes.IsButtonDown(input: Input_In, mouseButton: __pad_HViVtoX1iJMPy3Ti3tUgxw_23);
                __auto_10 = Result_65;
                var Result_66 = n19.InputNodes.IsButtonDown(input: Input_In, mouseButton: __pad_BbHJGhBilkjM8R7pQm1o1R_24);
                __auto_11 = Result_66;
                var Result_67 = n19.InputNodes.IsButtonDown(input: Input_In, mouseButton: __pad_BIgUCnlRGLcMY9WN2Y9uz0_25);
                __auto_12 = Result_67;
                if (state_18.__GetContext__().IsImmutable)
                    state_18 = State_Output_52 != state_18.__p_L9oKcFOwokzPfHAUPgKTVj || output_63 != state_18.__cp_IfWsiidGJykMnXhF1xbZH6 ? new __EytyPwxhy4mNiz5cwbHbJN(state_18)
                    {__p_L9oKcFOwokzPfHAUPgKTVj = State_Output_52, __cp_IfWsiidGJykMnXhF1xbZH6 = output_63} : state_18;
                else
                {
                    state_18.__p_L9oKcFOwokzPfHAUPgKTVj = State_Output_52;
                    state_18.__cp_IfWsiidGJykMnXhF1xbZH6 = output_63;
                }
            }
            else
            {
                __auto_4 = n10._Operations_.CreateDefault();
                __auto_5 = default(n5.Ray);
                __auto_6 = n10._Operations_.CreateDefault();
                __auto_7 = n10._Operations_.CreateDefault();
                __auto_8 = false;
                __auto_9 = false;
                __auto_10 = false;
                __auto_11 = false;
                __auto_12 = false;
                __auto_13 = n10._Operations_.CreateDefault();
                __auto_14 = 0F;
                __auto_15 = n10._Operations_.CreateDefault();
                __auto_16 = 0F;
                __auto_17 = n20._Operations_.CreateDefault<n7.InputEvent>();
            }

            Position_in_World_Out = __auto_4;
            Ray_Out = __auto_5;
            Position_in_Projection_Out = __auto_6;
            Position_Out = __auto_7;
            Left_Pressed_Out = __auto_8;
            Middle_Pressed_Out = __auto_9;
            Right_Pressed_Out = __auto_10;
            Extended_1_Pressed_Out = __auto_11;
            Extended_2_Pressed_Out = __auto_12;
            Delta_Out = __auto_13;
            Mouse_Wheel_Delta_Out = __auto_14;
            Surface_Size_Out = __auto_15;
            Surface_Aspect_Ratio_Out = __auto_16;
            Events_Out = __auto_17;
            n3.SplitMouseDevice_NVfomf0AapPPGXo2RcefKg that_68 = this;
            if (this.__GetContext__().IsImmutable)
                that_68 = state_18 != this.__if_Poy5VcoUkngO6X37DwqsRv ? new SplitMouseDevice_NVfomf0AapPPGXo2RcefKg(this)
                {__if_Poy5VcoUkngO6X37DwqsRv = state_18} : that_68;
            else
            {
                this.__if_Poy5VcoUkngO6X37DwqsRv = state_18;
            }

            return that_68;
        }

        public n3.SplitMouseDevice_NVfomf0AapPPGXo2RcefKg __Create__(n1.NodeContext Node_Context)
        {
            n21.RuntimeHelpers.EnsureSufficientExecutionStack();
            n5.Vector3 Point_0 = __c_NZ9IVc3QchoMyyP6Vj7RLQ;
            n5.Vector3 Normal_1 = __c_OsZmUlSfaqoPBog68azS0g;
            var Output_2 = new n5.Plane(point: Point_0, normal: Normal_1);
            n5.Plane __pad_FsWX8DkOUxwPKyY0Cg5qfq_3 = Output_2;
            n3.SplitMouseDevice_NVfomf0AapPPGXo2RcefKg that_4 = this;
            this.__slot_FsWX8DkOUxwPKyY0Cg5qfq = Output_2;
            this.__if_Poy5VcoUkngO6X37DwqsRv = default(n2.Object);
            return that_4;
        }

        public n3.SplitMouseDevice_NVfomf0AapPPGXo2RcefKg __CreateDefault__()
        {
            n3.SplitMouseDevice_NVfomf0AapPPGXo2RcefKg that_0 = this;
            this.__slot_FsWX8DkOUxwPKyY0Cg5qfq = n22._Operations_.CreateDefault();
            this.__if_Poy5VcoUkngO6X37DwqsRv = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_Poy5VcoUkngO6X37DwqsRv);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 106211U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "FsWX8DkOUxwPKyY0Cg5qfq", Name = "__slot_FsWX8DkOUxwPKyY0Cg5qfq")]
        public n5.Plane __slot_FsWX8DkOUxwPKyY0Cg5qfq;
        [n1.ElementAttribute(TracingId = 105961U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "PQYIAZl25UNLedW2sX0USI", Name = "__slot_PQYIAZl25UNLedW2sX0USI")]
        public static n7.MouseButton __slot_PQYIAZl25UNLedW2sX0USI = n1.CompilationHelper.Deserialize<n7.MouseButton>("Left", false, "HWRqGEFJG2aNE9pYb5Pg0w", "PQYIAZl25UNLedW2sX0USI");
        [n1.ElementAttribute(TracingId = 105977U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "PUZpoETaYnWLOZRqiBFjG7", Name = "__slot_PUZpoETaYnWLOZRqiBFjG7")]
        public static n7.MouseButton __slot_PUZpoETaYnWLOZRqiBFjG7 = n1.CompilationHelper.Deserialize<n7.MouseButton>("Middle", false, "HWRqGEFJG2aNE9pYb5Pg0w", "PUZpoETaYnWLOZRqiBFjG7");
        [n1.ElementAttribute(TracingId = 105983U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "HViVtoX1iJMPy3Ti3tUgxw", Name = "__slot_HViVtoX1iJMPy3Ti3tUgxw")]
        public static n7.MouseButton __slot_HViVtoX1iJMPy3Ti3tUgxw = n1.CompilationHelper.Deserialize<n7.MouseButton>("Right", false, "HWRqGEFJG2aNE9pYb5Pg0w", "HViVtoX1iJMPy3Ti3tUgxw");
        [n1.ElementAttribute(TracingId = 105989U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "BbHJGhBilkjM8R7pQm1o1R", Name = "__slot_BbHJGhBilkjM8R7pQm1o1R")]
        public static n7.MouseButton __slot_BbHJGhBilkjM8R7pQm1o1R = n1.CompilationHelper.Deserialize<n7.MouseButton>("Extended1", false, "HWRqGEFJG2aNE9pYb5Pg0w", "BbHJGhBilkjM8R7pQm1o1R");
        [n1.ElementAttribute(TracingId = 105995U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "BIgUCnlRGLcMY9WN2Y9uz0", Name = "__slot_BIgUCnlRGLcMY9WN2Y9uz0")]
        public static n7.MouseButton __slot_BIgUCnlRGLcMY9WN2Y9uz0 = n1.CompilationHelper.Deserialize<n7.MouseButton>("Extended2", false, "HWRqGEFJG2aNE9pYb5Pg0w", "BIgUCnlRGLcMY9WN2Y9uz0");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n5.Vector2 __c_I8zaiM9a5WMNIKkI3LzF0D = n1.CompilationHelper.Deserialize<n5.Vector2>("1, 1", false, "HWRqGEFJG2aNE9pYb5Pg0w", "I8zaiM9a5WMNIKkI3LzF0D");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n5.Vector2 __c_OZ63URYdgcANRJGljdhYkz = n1.CompilationHelper.Deserialize<n5.Vector2>("-1, 1", false, "HWRqGEFJG2aNE9pYb5Pg0w", "OZ63URYdgcANRJGljdhYkz");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n5.Vector2 __c_SucGUfpsRTWPWnQSliDgta = n1.CompilationHelper.Deserialize<n5.Vector2>("1, -1", false, "HWRqGEFJG2aNE9pYb5Pg0w", "SucGUfpsRTWPWnQSliDgta");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_Poy5VcoUkngO6X37DwqsRv;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n5.Vector3 __c_NZ9IVc3QchoMyyP6Vj7RLQ = n1.CompilationHelper.Deserialize<n5.Vector3>("0, 0, 0", false, "HWRqGEFJG2aNE9pYb5Pg0w", "NZ9IVc3QchoMyyP6Vj7RLQ");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n5.Vector3 __c_OsZmUlSfaqoPBog68azS0g = n1.CompilationHelper.Deserialize<n5.Vector3>("0, 0, 1", false, "HWRqGEFJG2aNE9pYb5Pg0w", "OsZmUlSfaqoPBog68azS0g");
        static SplitMouseDevice_NVfomf0AapPPGXo2RcefKg()
        {
        }

        public SplitMouseDevice_NVfomf0AapPPGXo2RcefKg(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SplitMouseDevice_NVfomf0AapPPGXo2RcefKg(SplitMouseDevice_NVfomf0AapPPGXo2RcefKg other): base(other)
        {
            this.__slot_FsWX8DkOUxwPKyY0Cg5qfq = other.__slot_FsWX8DkOUxwPKyY0Cg5qfq;
            this.__if_Poy5VcoUkngO6X37DwqsRv = other.__if_Poy5VcoUkngO6X37DwqsRv;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_FsWX8DkOUxwPKyY0Cg5qfq", in __slot_FsWX8DkOUxwPKyY0Cg5qfq), n1.CompilationHelper.GetValueOrExisting(values, "__if_Poy5VcoUkngO6X37DwqsRv", in __if_Poy5VcoUkngO6X37DwqsRv));
        }

        internal SplitMouseDevice_NVfomf0AapPPGXo2RcefKg __WITH__(n5.Plane __slot_FsWX8DkOUxwPKyY0Cg5qfq, n2.Object __if_Poy5VcoUkngO6X37DwqsRv)
        {
            n3.SplitMouseDevice_NVfomf0AapPPGXo2RcefKg that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = !n23.EqualityComparer<n5.Plane>.Default.Equals(__slot_FsWX8DkOUxwPKyY0Cg5qfq, this.__slot_FsWX8DkOUxwPKyY0Cg5qfq) || __if_Poy5VcoUkngO6X37DwqsRv != this.__if_Poy5VcoUkngO6X37DwqsRv ? new SplitMouseDevice_NVfomf0AapPPGXo2RcefKg(this)
                {__slot_FsWX8DkOUxwPKyY0Cg5qfq = __slot_FsWX8DkOUxwPKyY0Cg5qfq, __if_Poy5VcoUkngO6X37DwqsRv = __if_Poy5VcoUkngO6X37DwqsRv} : that_0;
            else
            {
                this.__slot_FsWX8DkOUxwPKyY0Cg5qfq = __slot_FsWX8DkOUxwPKyY0Cg5qfq;
                this.__if_Poy5VcoUkngO6X37DwqsRv = __if_Poy5VcoUkngO6X37DwqsRv;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "EytyPwxhy4mNiz5cwbHbJN", Name = "__EytyPwxhy4mNiz5cwbHbJN")]
        [n2.SerializableAttribute]
        public class __EytyPwxhy4mNiz5cwbHbJN : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_L9oKcFOwokzPfHAUPgKTVj);
                return;
            }

            [n1.ElementAttribute(TracingId = 105970U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "L9oKcFOwokzPfHAUPgKTVj", Name = "InputManager", IsManaged = true, IsAutoGenerated = true)]
            public n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY __p_L9oKcFOwokzPfHAUPgKTVj;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n8.Spread<n7.InputEvent> __cp_IfWsiidGJykMnXhF1xbZH6;
            public __EytyPwxhy4mNiz5cwbHbJN(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __EytyPwxhy4mNiz5cwbHbJN(__EytyPwxhy4mNiz5cwbHbJN other): base(other)
            {
                this.__p_L9oKcFOwokzPfHAUPgKTVj = other.__p_L9oKcFOwokzPfHAUPgKTVj;
                this.__cp_IfWsiidGJykMnXhF1xbZH6 = other.__cp_IfWsiidGJykMnXhF1xbZH6;
            }

            protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_L9oKcFOwokzPfHAUPgKTVj", in __p_L9oKcFOwokzPfHAUPgKTVj), n1.CompilationHelper.GetValueOrExisting(values, "__cp_IfWsiidGJykMnXhF1xbZH6", in __cp_IfWsiidGJykMnXhF1xbZH6));
            }

            internal __EytyPwxhy4mNiz5cwbHbJN __WITH__(n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY __p_L9oKcFOwokzPfHAUPgKTVj, n8.Spread<n7.InputEvent> __cp_IfWsiidGJykMnXhF1xbZH6)
            {
                __EytyPwxhy4mNiz5cwbHbJN that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_L9oKcFOwokzPfHAUPgKTVj != this.__p_L9oKcFOwokzPfHAUPgKTVj || __cp_IfWsiidGJykMnXhF1xbZH6 != this.__cp_IfWsiidGJykMnXhF1xbZH6 ? new __EytyPwxhy4mNiz5cwbHbJN(this)
                    {__p_L9oKcFOwokzPfHAUPgKTVj = __p_L9oKcFOwokzPfHAUPgKTVj, __cp_IfWsiidGJykMnXhF1xbZH6 = __cp_IfWsiidGJykMnXhF1xbZH6} : that_0;
                else
                {
                    this.__p_L9oKcFOwokzPfHAUPgKTVj = __p_L9oKcFOwokzPfHAUPgKTVj;
                    this.__cp_IfWsiidGJykMnXhF1xbZH6 = __cp_IfWsiidGJykMnXhF1xbZH6;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 106459U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "C9I4Tf7vqndMjqbnDwNSEh", Name = "SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh")]
    [n2.SerializableAttribute]
    public class SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh Create(n1.NodeContext Node_Context)
        {
            var instance = new SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh CreateDefault()
        {
            var instance = new SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh Update(n7.IPointerDevice Input_In, out n8.Spread<n7.PointerPoint> Pressed_Pointers_Out, out n8.Spread<n7.PointerPoint> Down_Pointers_Out, out n8.Spread<n7.PointerPoint> Released_Pointers_Out, out n5.Vector2 Surface_Size_Out, out float Surface_Aspect_Ratio_Out, out n8.Spread<n7.InputEvent> Events_Out)
        {
            n6.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            n8.Spread<n7.PointerPoint> __auto_2;
            n8.Spread<n7.PointerPoint> __auto_3;
            n8.Spread<n7.PointerPoint> __auto_4;
            n5.Vector2 __auto_5;
            float __auto_6;
            n8.Spread<n7.InputEvent> __auto_7;
            var state_8 = n1.CompilationHelper.Restore<__HoHYgTBfjUwQCw1aOts3t2>(this.__if_UpszIWvSZ0nP9Qo7XgHBxH, __GetContext__());
            if (Result_0)
            {
                if (state_8 == null)
                {
                    state_8 = new __HoHYgTBfjUwQCw1aOts3t2(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_NVVCegN2CTLNMF7owLwF7H = n20._Operations_.CreateDefault<n7.InputEvent>()};
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("HWRqGEFJG2aNE9pYb5Pg0w", "KgsJCSQS0eJLcz4W3iyGSp", 106603U);
                    var Output_10 = n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY.Create(Node_Context_In: Node_Context_9);
                    state_8.__p_KgsJCSQS0eJLcz4W3iyGSp = Output_10;
                }

                var Down_Pointers_11 = Input_In.DownPointers;
                n23.IEnumerable<n7.PointerPoint> Input_12 = (n23.IEnumerable<n7.PointerPoint>)Down_Pointers_11;
                n20._Operations_.FromSequence<n7.PointerPoint>(Input_In: Input_12, Result_Out: out n8.Spread<n7.PointerPoint> Result_13);
                __auto_3 = Result_13;
                var Surface_Size_14 = Input_In.SurfaceSize;
                __auto_5 = Surface_Size_14;
                var Surface_Aspect_Ratio_15 = Input_In.SurfaceAspectRatio;
                __auto_6 = Surface_Aspect_Ratio_15;
                var Pressed_Pointers_16 = Input_In.PressedPointers;
                n23.IEnumerable<n7.PointerPoint> Input_17 = (n23.IEnumerable<n7.PointerPoint>)Pressed_Pointers_16;
                n20._Operations_.FromSequence<n7.PointerPoint>(Input_In: Input_17, Result_Out: out n8.Spread<n7.PointerPoint> Result_18);
                __auto_2 = Result_18;
                var Released_Pointers_19 = Input_In.ReleasedPointers;
                n23.IEnumerable<n7.PointerPoint> Input_20 = (n23.IEnumerable<n7.PointerPoint>)Released_Pointers_19;
                n20._Operations_.FromSequence<n7.PointerPoint>(Input_In: Input_20, Result_Out: out n8.Spread<n7.PointerPoint> Result_21);
                __auto_4 = Result_21;
                var State_Output_23 = state_8.__p_KgsJCSQS0eJLcz4W3iyGSp.Update(Output_Out: out n7.InputManager Output_22);
                var Events_24 = Output_22.Events;
                var builder_32 = n4.CollectionBuilders.GetBuilder(state_8.__cp_NVVCegN2CTLNMF7owLwF7H, 16);
                n8.Spread<n7.InputEvent> output_33;
                try
                {
                    var i_27 = 0;
                    foreach (var item_25 in Events_24)
                    {
                        var splicer_26 = item_25;
                        var i_local_28 = i_27;
                        var Device_30 = splicer_26.Device;
                        var Result_31 = n6.ObjectHelpers.Eq(input: Input_In, input2: Device_30);
                        if (Result_31)
                        {
                            builder_32.Add(splicer_26);
                        }

                        i_27++;
                    }
                }
                finally
                {
                    output_33 = builder_32.Commit();
                }

                __auto_7 = output_33;
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_23 != state_8.__p_KgsJCSQS0eJLcz4W3iyGSp || output_33 != state_8.__cp_NVVCegN2CTLNMF7owLwF7H ? new __HoHYgTBfjUwQCw1aOts3t2(state_8)
                    {__p_KgsJCSQS0eJLcz4W3iyGSp = State_Output_23, __cp_NVVCegN2CTLNMF7owLwF7H = output_33} : state_8;
                else
                {
                    state_8.__p_KgsJCSQS0eJLcz4W3iyGSp = State_Output_23;
                    state_8.__cp_NVVCegN2CTLNMF7owLwF7H = output_33;
                }
            }
            else
            {
                __auto_2 = n20._Operations_.CreateDefault<n7.PointerPoint>();
                __auto_3 = n20._Operations_.CreateDefault<n7.PointerPoint>();
                __auto_4 = n20._Operations_.CreateDefault<n7.PointerPoint>();
                __auto_5 = n10._Operations_.CreateDefault();
                __auto_6 = 0F;
                __auto_7 = n20._Operations_.CreateDefault<n7.InputEvent>();
            }

            Pressed_Pointers_Out = __auto_2;
            Down_Pointers_Out = __auto_3;
            Released_Pointers_Out = __auto_4;
            Surface_Size_Out = __auto_5;
            Surface_Aspect_Ratio_Out = __auto_6;
            Events_Out = __auto_7;
            n3.SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh that_34 = this;
            if (this.__GetContext__().IsImmutable)
                that_34 = state_8 != this.__if_UpszIWvSZ0nP9Qo7XgHBxH ? new SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh(this)
                {__if_UpszIWvSZ0nP9Qo7XgHBxH = state_8} : that_34;
            else
            {
                this.__if_UpszIWvSZ0nP9Qo7XgHBxH = state_8;
            }

            return that_34;
        }

        public n3.SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh __Create__(n1.NodeContext Node_Context)
        {
            n21.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh that_0 = this;
            this.__if_UpszIWvSZ0nP9Qo7XgHBxH = default(n2.Object);
            return that_0;
        }

        public n3.SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh __CreateDefault__()
        {
            n3.SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh that_0 = this;
            this.__if_UpszIWvSZ0nP9Qo7XgHBxH = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_UpszIWvSZ0nP9Qo7XgHBxH);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_UpszIWvSZ0nP9Qo7XgHBxH;
        public SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh(SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh other): base(other)
        {
            this.__if_UpszIWvSZ0nP9Qo7XgHBxH = other.__if_UpszIWvSZ0nP9Qo7XgHBxH;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_UpszIWvSZ0nP9Qo7XgHBxH", in __if_UpszIWvSZ0nP9Qo7XgHBxH));
        }

        internal SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh __WITH__(n2.Object __if_UpszIWvSZ0nP9Qo7XgHBxH)
        {
            n3.SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_UpszIWvSZ0nP9Qo7XgHBxH != this.__if_UpszIWvSZ0nP9Qo7XgHBxH ? new SplitPointerDevice_C9I4Tf7vqndMjqbnDwNSEh(this)
                {__if_UpszIWvSZ0nP9Qo7XgHBxH = __if_UpszIWvSZ0nP9Qo7XgHBxH} : that_0;
            else
            {
                this.__if_UpszIWvSZ0nP9Qo7XgHBxH = __if_UpszIWvSZ0nP9Qo7XgHBxH;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "HoHYgTBfjUwQCw1aOts3t2", Name = "__HoHYgTBfjUwQCw1aOts3t2")]
        [n2.SerializableAttribute]
        public class __HoHYgTBfjUwQCw1aOts3t2 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_KgsJCSQS0eJLcz4W3iyGSp);
                return;
            }

            [n1.ElementAttribute(TracingId = 106603U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "KgsJCSQS0eJLcz4W3iyGSp", Name = "InputManager", IsManaged = true, IsAutoGenerated = true)]
            public n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY __p_KgsJCSQS0eJLcz4W3iyGSp;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n8.Spread<n7.InputEvent> __cp_NVVCegN2CTLNMF7owLwF7H;
            public __HoHYgTBfjUwQCw1aOts3t2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __HoHYgTBfjUwQCw1aOts3t2(__HoHYgTBfjUwQCw1aOts3t2 other): base(other)
            {
                this.__p_KgsJCSQS0eJLcz4W3iyGSp = other.__p_KgsJCSQS0eJLcz4W3iyGSp;
                this.__cp_NVVCegN2CTLNMF7owLwF7H = other.__cp_NVVCegN2CTLNMF7owLwF7H;
            }

            protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_KgsJCSQS0eJLcz4W3iyGSp", in __p_KgsJCSQS0eJLcz4W3iyGSp), n1.CompilationHelper.GetValueOrExisting(values, "__cp_NVVCegN2CTLNMF7owLwF7H", in __cp_NVVCegN2CTLNMF7owLwF7H));
            }

            internal __HoHYgTBfjUwQCw1aOts3t2 __WITH__(n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY __p_KgsJCSQS0eJLcz4W3iyGSp, n8.Spread<n7.InputEvent> __cp_NVVCegN2CTLNMF7owLwF7H)
            {
                __HoHYgTBfjUwQCw1aOts3t2 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_KgsJCSQS0eJLcz4W3iyGSp != this.__p_KgsJCSQS0eJLcz4W3iyGSp || __cp_NVVCegN2CTLNMF7owLwF7H != this.__cp_NVVCegN2CTLNMF7owLwF7H ? new __HoHYgTBfjUwQCw1aOts3t2(this)
                    {__p_KgsJCSQS0eJLcz4W3iyGSp = __p_KgsJCSQS0eJLcz4W3iyGSp, __cp_NVVCegN2CTLNMF7owLwF7H = __cp_NVVCegN2CTLNMF7owLwF7H} : that_0;
                else
                {
                    this.__p_KgsJCSQS0eJLcz4W3iyGSp = __p_KgsJCSQS0eJLcz4W3iyGSp;
                    this.__cp_NVVCegN2CTLNMF7owLwF7H = __cp_NVVCegN2CTLNMF7owLwF7H;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 106778U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "GosMewfqmjVMGGYfpPxHZ9", Name = "SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9")]
    [n2.SerializableAttribute]
    public class SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9 Create(n1.NodeContext Node_Context)
        {
            var instance = new SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9 CreateDefault()
        {
            var instance = new SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9 Update<T>(T Input_In, out bool Shift_Out, out bool Alt_Out, out bool Ctrl_Out, out n8.Spread<n7.InputEvent> Events_Out)
            where T : n7.IKeyboardDevice
        {
            n6.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            n7.IKeyboardDevice Input_2 = (n7.IKeyboardDevice)Input_In;
            n7.IKeyboardDevice Input_3 = (n7.IKeyboardDevice)Input_In;
            n7.IKeyboardDevice Input_4 = (n7.IKeyboardDevice)Input_In;
            n7.IKeyboardDevice Input_5 = (n7.IKeyboardDevice)Input_In;
            n7.IKeyboardDevice Input_6 = (n7.IKeyboardDevice)Input_In;
            n7.IKeyboardDevice Input_7 = (n7.IKeyboardDevice)Input_In;
            bool __auto_8;
            bool __auto_9;
            bool __auto_10;
            n8.Spread<n7.InputEvent> __auto_11;
            var state_12 = n1.CompilationHelper.Restore<__Dxm2MuJVTLjNmZzxdoUlep>(this.__if_Il94o2h6xYwQJOibMKkdQK, __GetContext__());
            if (Result_0)
            {
                if (state_12 == null)
                {
                    state_12 = new __Dxm2MuJVTLjNmZzxdoUlep(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_IUSWfIBGWiQNwxUNiWz5qH = n20._Operations_.CreateDefault<n7.InputEvent>()};
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("HWRqGEFJG2aNE9pYb5Pg0w", "TyYdd7RL621OIZxEtDAU4t", 106804U);
                    var Output_14 = n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY.Create(Node_Context_In: Node_Context_13);
                    state_12.__p_TyYdd7RL621OIZxEtDAU4t = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("HWRqGEFJG2aNE9pYb5Pg0w", "KJZpmULMuoVN50ieSwpdLR", 106981U);
                    var Output_16 = n24.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_15);
                    state_12.__p_KJZpmULMuoVN50ieSwpdLR = Output_16;
                }

                n7.Keys __pad_MkgAKIMLjPuOW6EwONFtz6_17 = __slot_MkgAKIMLjPuOW6EwONFtz6;
                n7.Keys __pad_NwBArZ0CxLJLgDFLLYa8Fr_18 = __slot_NwBArZ0CxLJLgDFLLYa8Fr;
                n7.Keys __pad_KcxN43IqQA9NM0wR2u3b8i_19 = __slot_KcxN43IqQA9NM0wR2u3b8i;
                n7.Keys __pad_JaXqDRkwKXqPfCQs5uAfWz_20 = __slot_JaXqDRkwKXqPfCQs5uAfWz;
                n7.Keys __pad_B2IF9k3B9sJNrvk8lUpZXJ_21 = __slot_B2IF9k3B9sJNrvk8lUpZXJ;
                n7.Keys __pad_DozINgyn4Z1MVFmRoc9uih_22 = __slot_DozINgyn4Z1MVFmRoc9uih;
                var State_Output_24 = state_12.__p_TyYdd7RL621OIZxEtDAU4t.Update(Output_Out: out n7.InputManager Output_23);
                var Events_25 = Output_23.Events;
                var builder_33 = n4.CollectionBuilders.GetBuilder(state_12.__cp_IUSWfIBGWiQNwxUNiWz5qH, 16);
                n8.Spread<n7.InputEvent> output_34;
                try
                {
                    var i_28 = 0;
                    foreach (var item_26 in Events_25)
                    {
                        var splicer_27 = item_26;
                        var i_local_29 = i_28;
                        var Device_31 = splicer_27.Device;
                        var Result_32 = n6.ObjectHelpers.Eq(input: Input_In, input2: Device_31);
                        if (Result_32)
                        {
                            builder_33.Add(splicer_27);
                        }

                        i_28++;
                    }
                }
                finally
                {
                    output_34 = builder_33.Commit();
                }

                __auto_11 = output_34;
                var Result_35 = n19.InputNodes.IsKeyDown(input: Input_2, key: __pad_MkgAKIMLjPuOW6EwONFtz6_17);
                var Result_36 = n19.InputNodes.IsKeyDown(input: Input_3, key: __pad_NwBArZ0CxLJLgDFLLYa8Fr_18);
                var Output_37 = Result_35 || Result_36;
                __auto_8 = Output_37;
                var Result_38 = n19.InputNodes.IsKeyDown(input: Input_4, key: __pad_KcxN43IqQA9NM0wR2u3b8i_19);
                var Result_39 = n19.InputNodes.IsKeyDown(input: Input_5, key: __pad_JaXqDRkwKXqPfCQs5uAfWz_20);
                var Output_40 = Result_38 || Result_39;
                __auto_9 = Output_40;
                var Result_41 = n19.InputNodes.IsKeyDown(input: Input_6, key: __pad_B2IF9k3B9sJNrvk8lUpZXJ_21);
                var Result_42 = n19.InputNodes.IsKeyDown(input: Input_7, key: __pad_DozINgyn4Z1MVFmRoc9uih_22);
                var Output_43 = Result_41 || Result_42;
                __auto_10 = Output_43;
                n7.ITextInputDevice Default_44 = default(n7.ITextInputDevice);
                n25._Operations_.CastAs<n7.ITextInputDevice>(Input_In: Input_In, Default_In: Default_44, Result_Out: out n7.ITextInputDevice Result_45, Success_Out: out bool Success_46);
                var Output_49 = state_12.__p_KJZpmULMuoVN50ieSwpdLR.Update(Value_In: Success_46, Up_Edge_Out: out bool Up_Edge_47, Down_Edge_Out: out bool Down_Edge_48);
                var Output_50 = Result_45;
                if (Up_Edge_47)
                {
                    ((n7.ITextInputDevice)Result_45).EnabledTextInput();
                }

                if (state_12.__GetContext__().IsImmutable)
                    state_12 = State_Output_24 != state_12.__p_TyYdd7RL621OIZxEtDAU4t || output_34 != state_12.__cp_IUSWfIBGWiQNwxUNiWz5qH || Output_49 != state_12.__p_KJZpmULMuoVN50ieSwpdLR ? new __Dxm2MuJVTLjNmZzxdoUlep(state_12)
                    {__p_TyYdd7RL621OIZxEtDAU4t = State_Output_24, __cp_IUSWfIBGWiQNwxUNiWz5qH = output_34, __p_KJZpmULMuoVN50ieSwpdLR = Output_49} : state_12;
                else
                {
                    state_12.__p_TyYdd7RL621OIZxEtDAU4t = State_Output_24;
                    state_12.__cp_IUSWfIBGWiQNwxUNiWz5qH = output_34;
                    state_12.__p_KJZpmULMuoVN50ieSwpdLR = Output_49;
                }
            }
            else
            {
                __auto_8 = false;
                __auto_9 = false;
                __auto_10 = false;
                __auto_11 = n20._Operations_.CreateDefault<n7.InputEvent>();
            }

            Shift_Out = __auto_8;
            Alt_Out = __auto_9;
            Ctrl_Out = __auto_10;
            Events_Out = __auto_11;
            n3.SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9 that_51 = this;
            if (this.__GetContext__().IsImmutable)
                that_51 = state_12 != this.__if_Il94o2h6xYwQJOibMKkdQK ? new SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9(this)
                {__if_Il94o2h6xYwQJOibMKkdQK = state_12} : that_51;
            else
            {
                this.__if_Il94o2h6xYwQJOibMKkdQK = state_12;
            }

            return that_51;
        }

        public n3.SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9 __Create__(n1.NodeContext Node_Context)
        {
            n21.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9 that_0 = this;
            this.__if_Il94o2h6xYwQJOibMKkdQK = default(n2.Object);
            return that_0;
        }

        public n3.SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9 __CreateDefault__()
        {
            n3.SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9 that_0 = this;
            this.__if_Il94o2h6xYwQJOibMKkdQK = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_Il94o2h6xYwQJOibMKkdQK);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 106856U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "MkgAKIMLjPuOW6EwONFtz6", Name = "__slot_MkgAKIMLjPuOW6EwONFtz6")]
        public static n7.Keys __slot_MkgAKIMLjPuOW6EwONFtz6 = n1.CompilationHelper.Deserialize<n7.Keys>("LeftShift", false, "HWRqGEFJG2aNE9pYb5Pg0w", "MkgAKIMLjPuOW6EwONFtz6");
        [n1.ElementAttribute(TracingId = 106870U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "NwBArZ0CxLJLgDFLLYa8Fr", Name = "__slot_NwBArZ0CxLJLgDFLLYa8Fr")]
        public static n7.Keys __slot_NwBArZ0CxLJLgDFLLYa8Fr = n1.CompilationHelper.Deserialize<n7.Keys>("RightShift", false, "HWRqGEFJG2aNE9pYb5Pg0w", "NwBArZ0CxLJLgDFLLYa8Fr");
        [n1.ElementAttribute(TracingId = 106899U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "KcxN43IqQA9NM0wR2u3b8i", Name = "__slot_KcxN43IqQA9NM0wR2u3b8i")]
        public static n7.Keys __slot_KcxN43IqQA9NM0wR2u3b8i = n1.CompilationHelper.Deserialize<n7.Keys>("LeftAlt", false, "HWRqGEFJG2aNE9pYb5Pg0w", "KcxN43IqQA9NM0wR2u3b8i");
        [n1.ElementAttribute(TracingId = 106919U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "JaXqDRkwKXqPfCQs5uAfWz", Name = "__slot_JaXqDRkwKXqPfCQs5uAfWz")]
        public static n7.Keys __slot_JaXqDRkwKXqPfCQs5uAfWz = n1.CompilationHelper.Deserialize<n7.Keys>("RightAlt", false, "HWRqGEFJG2aNE9pYb5Pg0w", "JaXqDRkwKXqPfCQs5uAfWz");
        [n1.ElementAttribute(TracingId = 106946U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "B2IF9k3B9sJNrvk8lUpZXJ", Name = "__slot_B2IF9k3B9sJNrvk8lUpZXJ")]
        public static n7.Keys __slot_B2IF9k3B9sJNrvk8lUpZXJ = n1.CompilationHelper.Deserialize<n7.Keys>("LeftCtrl", false, "HWRqGEFJG2aNE9pYb5Pg0w", "B2IF9k3B9sJNrvk8lUpZXJ");
        [n1.ElementAttribute(TracingId = 106958U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "DozINgyn4Z1MVFmRoc9uih", Name = "__slot_DozINgyn4Z1MVFmRoc9uih")]
        public static n7.Keys __slot_DozINgyn4Z1MVFmRoc9uih = n1.CompilationHelper.Deserialize<n7.Keys>("RightCtrl", false, "HWRqGEFJG2aNE9pYb5Pg0w", "DozINgyn4Z1MVFmRoc9uih");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_Il94o2h6xYwQJOibMKkdQK;
        static SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9()
        {
        }

        public SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9(SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9 other): base(other)
        {
            this.__if_Il94o2h6xYwQJOibMKkdQK = other.__if_Il94o2h6xYwQJOibMKkdQK;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_Il94o2h6xYwQJOibMKkdQK", in __if_Il94o2h6xYwQJOibMKkdQK));
        }

        internal SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9 __WITH__(n2.Object __if_Il94o2h6xYwQJOibMKkdQK)
        {
            n3.SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_Il94o2h6xYwQJOibMKkdQK != this.__if_Il94o2h6xYwQJOibMKkdQK ? new SplitKeyboardDevice_GosMewfqmjVMGGYfpPxHZ9(this)
                {__if_Il94o2h6xYwQJOibMKkdQK = __if_Il94o2h6xYwQJOibMKkdQK} : that_0;
            else
            {
                this.__if_Il94o2h6xYwQJOibMKkdQK = __if_Il94o2h6xYwQJOibMKkdQK;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "Dxm2MuJVTLjNmZzxdoUlep", Name = "__Dxm2MuJVTLjNmZzxdoUlep")]
        [n2.SerializableAttribute]
        public class __Dxm2MuJVTLjNmZzxdoUlep : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_TyYdd7RL621OIZxEtDAU4t);
                n1.CompilationHelper.SafeDispose(this.__p_KJZpmULMuoVN50ieSwpdLR);
                return;
            }

            [n1.ElementAttribute(TracingId = 106804U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "TyYdd7RL621OIZxEtDAU4t", Name = "InputManager", IsManaged = true, IsAutoGenerated = true)]
            public n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY __p_TyYdd7RL621OIZxEtDAU4t;
            [n1.ElementAttribute(TracingId = 106981U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "KJZpmULMuoVN50ieSwpdLR", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
            public n24.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_KJZpmULMuoVN50ieSwpdLR;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n8.Spread<n7.InputEvent> __cp_IUSWfIBGWiQNwxUNiWz5qH;
            public __Dxm2MuJVTLjNmZzxdoUlep(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Dxm2MuJVTLjNmZzxdoUlep(__Dxm2MuJVTLjNmZzxdoUlep other): base(other)
            {
                this.__p_TyYdd7RL621OIZxEtDAU4t = other.__p_TyYdd7RL621OIZxEtDAU4t;
                this.__p_KJZpmULMuoVN50ieSwpdLR = other.__p_KJZpmULMuoVN50ieSwpdLR;
                this.__cp_IUSWfIBGWiQNwxUNiWz5qH = other.__cp_IUSWfIBGWiQNwxUNiWz5qH;
            }

            protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TyYdd7RL621OIZxEtDAU4t", in __p_TyYdd7RL621OIZxEtDAU4t), n1.CompilationHelper.GetValueOrExisting(values, "__p_KJZpmULMuoVN50ieSwpdLR", in __p_KJZpmULMuoVN50ieSwpdLR), n1.CompilationHelper.GetValueOrExisting(values, "__cp_IUSWfIBGWiQNwxUNiWz5qH", in __cp_IUSWfIBGWiQNwxUNiWz5qH));
            }

            internal __Dxm2MuJVTLjNmZzxdoUlep __WITH__(n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY __p_TyYdd7RL621OIZxEtDAU4t, n24.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_KJZpmULMuoVN50ieSwpdLR, n8.Spread<n7.InputEvent> __cp_IUSWfIBGWiQNwxUNiWz5qH)
            {
                __Dxm2MuJVTLjNmZzxdoUlep that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_TyYdd7RL621OIZxEtDAU4t != this.__p_TyYdd7RL621OIZxEtDAU4t || __p_KJZpmULMuoVN50ieSwpdLR != this.__p_KJZpmULMuoVN50ieSwpdLR || __cp_IUSWfIBGWiQNwxUNiWz5qH != this.__cp_IUSWfIBGWiQNwxUNiWz5qH ? new __Dxm2MuJVTLjNmZzxdoUlep(this)
                    {__p_TyYdd7RL621OIZxEtDAU4t = __p_TyYdd7RL621OIZxEtDAU4t, __p_KJZpmULMuoVN50ieSwpdLR = __p_KJZpmULMuoVN50ieSwpdLR, __cp_IUSWfIBGWiQNwxUNiWz5qH = __cp_IUSWfIBGWiQNwxUNiWz5qH} : that_0;
                else
                {
                    this.__p_TyYdd7RL621OIZxEtDAU4t = __p_TyYdd7RL621OIZxEtDAU4t;
                    this.__p_KJZpmULMuoVN50ieSwpdLR = __p_KJZpmULMuoVN50ieSwpdLR;
                    this.__cp_IUSWfIBGWiQNwxUNiWz5qH = __cp_IUSWfIBGWiQNwxUNiWz5qH;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 107117U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "MufeYmyN8J2MXc7TXSZ9Wd", Name = "GetDevices_MufeYmyN8J2MXc7TXSZ9Wd")]
    [n2.SerializableAttribute]
    public class GetDevices_MufeYmyN8J2MXc7TXSZ9Wd : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.GetDevices_MufeYmyN8J2MXc7TXSZ9Wd Create(n1.NodeContext Node_Context)
        {
            var instance = new GetDevices_MufeYmyN8J2MXc7TXSZ9Wd(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.GetDevices_MufeYmyN8J2MXc7TXSZ9Wd CreateDefault()
        {
            var instance = new GetDevices_MufeYmyN8J2MXc7TXSZ9Wd(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.GetDevices_MufeYmyN8J2MXc7TXSZ9Wd Update(n7.IInputSource Input_In, out n7.IMouseDevice Mouse_Device_Out, out n7.IKeyboardDevice Keyboard_Device_Out, out n7.IPointerDevice Pointer_Device_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_OHma8CbuSUoLWkAmXFPJR5;
            if (manager_2 is null)
            {
                manager_2 = new n26.Manager<n2.ValueTuple<n7.IInputSource>, n2.ValueTuple<n7.IMouseDevice, n7.IKeyboardDevice, n7.IPointerDevice>>((default(n7.IMouseDevice), default(n7.IKeyboardDevice), default(n7.IPointerDevice)));
            }

            var inputs_3 = n2.ValueTuple.Create(Input_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var Output_10 = n19.InputExtensions.GetDevices(inputSource: Input_In, mouseDevice: out n7.IMouseDevice Mouse_Device_7, keyboardDevice: out n7.IKeyboardDevice Keyboard_Device_8, pointerDevice: out n7.IPointerDevice Pointer_Device_9);
                outputs_4 = (Mouse_Device_7, Keyboard_Device_8, Pointer_Device_9);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_11, __auto_12, __auto_13) = outputs_4;
            Mouse_Device_Out = __auto_11;
            Keyboard_Device_Out = __auto_12;
            Pointer_Device_Out = __auto_13;
            n3.GetDevices_MufeYmyN8J2MXc7TXSZ9Wd that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = manager_2 != this.__cache_OHma8CbuSUoLWkAmXFPJR5 ? new GetDevices_MufeYmyN8J2MXc7TXSZ9Wd(this)
                {__cache_OHma8CbuSUoLWkAmXFPJR5 = manager_2} : that_14;
            else
            {
                this.__cache_OHma8CbuSUoLWkAmXFPJR5 = manager_2;
            }

            return that_14;
        }

        public n3.GetDevices_MufeYmyN8J2MXc7TXSZ9Wd __Create__(n1.NodeContext Node_Context)
        {
            n21.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.GetDevices_MufeYmyN8J2MXc7TXSZ9Wd that_0 = this;
            this.__cache_OHma8CbuSUoLWkAmXFPJR5 = null;
            return that_0;
        }

        public n3.GetDevices_MufeYmyN8J2MXc7TXSZ9Wd __CreateDefault__()
        {
            n3.GetDevices_MufeYmyN8J2MXc7TXSZ9Wd that_0 = this;
            this.__cache_OHma8CbuSUoLWkAmXFPJR5 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_OHma8CbuSUoLWkAmXFPJR5);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 107120U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "OHma8CbuSUoLWkAmXFPJR5", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n26.Manager<n2.ValueTuple<n7.IInputSource>, n2.ValueTuple<n7.IMouseDevice, n7.IKeyboardDevice, n7.IPointerDevice>> __cache_OHma8CbuSUoLWkAmXFPJR5 = null;
        public GetDevices_MufeYmyN8J2MXc7TXSZ9Wd(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GetDevices_MufeYmyN8J2MXc7TXSZ9Wd(GetDevices_MufeYmyN8J2MXc7TXSZ9Wd other): base(other)
        {
            this.__cache_OHma8CbuSUoLWkAmXFPJR5 = other.__cache_OHma8CbuSUoLWkAmXFPJR5;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_OHma8CbuSUoLWkAmXFPJR5", in __cache_OHma8CbuSUoLWkAmXFPJR5));
        }

        internal GetDevices_MufeYmyN8J2MXc7TXSZ9Wd __WITH__(n26.Manager<n2.ValueTuple<n7.IInputSource>, n2.ValueTuple<n7.IMouseDevice, n7.IKeyboardDevice, n7.IPointerDevice>> __cache_OHma8CbuSUoLWkAmXFPJR5)
        {
            n3.GetDevices_MufeYmyN8J2MXc7TXSZ9Wd that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_OHma8CbuSUoLWkAmXFPJR5 != this.__cache_OHma8CbuSUoLWkAmXFPJR5 ? new GetDevices_MufeYmyN8J2MXc7TXSZ9Wd(this)
                {__cache_OHma8CbuSUoLWkAmXFPJR5 = __cache_OHma8CbuSUoLWkAmXFPJR5} : that_0;
            else
            {
                this.__cache_OHma8CbuSUoLWkAmXFPJR5 = __cache_OHma8CbuSUoLWkAmXFPJR5;
            }

            return that_0;
        }
    }
}

namespace _VL_Stride_Input_.Stride.Input
{
    [n1.ElementAttribute(TracingId = 107195U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "IWmuveU8U4IMQpEBd6QWqE", Name = "KeyPressed_IWmuveU8U4IMQpEBd6QWqE")]
    [n2.SerializableAttribute]
    public class KeyPressed_IWmuveU8U4IMQpEBd6QWqE : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n9.KeyPressed_IWmuveU8U4IMQpEBd6QWqE Create(n1.NodeContext Node_Context)
        {
            var instance = new KeyPressed_IWmuveU8U4IMQpEBd6QWqE(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n9.KeyPressed_IWmuveU8U4IMQpEBd6QWqE CreateDefault()
        {
            var instance = new KeyPressed_IWmuveU8U4IMQpEBd6QWqE(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n9.KeyPressed_IWmuveU8U4IMQpEBd6QWqE Update(n7.IKeyboardDevice Keyboard_Device_In, n7.Keys Key_In, out bool Result_Out)
        {
            var Result_0 = n19.InputNodes.IsKeyDown(input: Keyboard_Device_In, key: Key_In);
            Result_Out = Result_0;
            return this;
        }

        public n9.KeyPressed_IWmuveU8U4IMQpEBd6QWqE __Create__(n1.NodeContext Node_Context)
        {
            n21.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n9.KeyPressed_IWmuveU8U4IMQpEBd6QWqE __CreateDefault__()
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

        public KeyPressed_IWmuveU8U4IMQpEBd6QWqE(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal KeyPressed_IWmuveU8U4IMQpEBd6QWqE(KeyPressed_IWmuveU8U4IMQpEBd6QWqE other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal KeyPressed_IWmuveU8U4IMQpEBd6QWqE __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 107241U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "OmYnj7TSQvtQcPyOpDWlmU", Name = "KeyBang_OmYnj7TSQvtQcPyOpDWlmU")]
    [n2.SerializableAttribute]
    public class KeyBang_OmYnj7TSQvtQcPyOpDWlmU : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n9.KeyBang_OmYnj7TSQvtQcPyOpDWlmU Create(n1.NodeContext Node_Context)
        {
            var instance = new KeyBang_OmYnj7TSQvtQcPyOpDWlmU(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n9.KeyBang_OmYnj7TSQvtQcPyOpDWlmU CreateDefault()
        {
            var instance = new KeyBang_OmYnj7TSQvtQcPyOpDWlmU(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n9.KeyBang_OmYnj7TSQvtQcPyOpDWlmU Update(n7.IKeyboardDevice Keyboard_Device_In, n7.Keys Key_In, out bool Result_Out)
        {
            var Result_0 = n19.InputNodes.IsKeyPressed(input: Keyboard_Device_In, key: Key_In);
            Result_Out = Result_0;
            return this;
        }

        public n9.KeyBang_OmYnj7TSQvtQcPyOpDWlmU __Create__(n1.NodeContext Node_Context)
        {
            n21.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n9.KeyBang_OmYnj7TSQvtQcPyOpDWlmU __CreateDefault__()
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

        public KeyBang_OmYnj7TSQvtQcPyOpDWlmU(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal KeyBang_OmYnj7TSQvtQcPyOpDWlmU(KeyBang_OmYnj7TSQvtQcPyOpDWlmU other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal KeyBang_OmYnj7TSQvtQcPyOpDWlmU __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 107290U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "PfPeAb7UbqCLenbJvauz2a", Name = "KeyToggle_PfPeAb7UbqCLenbJvauz2a")]
    [n2.SerializableAttribute]
    public class KeyToggle_PfPeAb7UbqCLenbJvauz2a : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n9.KeyToggle_PfPeAb7UbqCLenbJvauz2a Create(n1.NodeContext Node_Context)
        {
            var instance = new KeyToggle_PfPeAb7UbqCLenbJvauz2a(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n9.KeyToggle_PfPeAb7UbqCLenbJvauz2a CreateDefault()
        {
            var instance = new KeyToggle_PfPeAb7UbqCLenbJvauz2a(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n9.KeyToggle_PfPeAb7UbqCLenbJvauz2a Update(n7.IKeyboardDevice Keyboard_Device_In, n7.Keys Key_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Reset_Toggle_In, out bool Result_Out)
        {
            var Result_0 = n19.InputNodes.IsKeyDown(input: Keyboard_Device_In, key: Key_In);
            var Output_3 = this.__p_VqujafEWVqZLDxyofafIGe.Update(Value_In: Result_0, Up_Edge_Out: out bool Up_Edge_1, Down_Edge_Out: out bool Down_Edge_2);
            var Output_4 = this.__p_DsL9kikSDaEMDkQ69LqJ8W;
            if (Up_Edge_1)
            {
                Output_4 = this.__p_DsL9kikSDaEMDkQ69LqJ8W.Flip();
            }

            var Output_5 = Output_4;
            if (Reset_Toggle_In)
            {
                Output_5 = Output_4.Reset();
            }

            var Output_7 = Output_5.GetValue(Value_Out: out bool Value_6);
            Result_Out = Value_6;
            n9.KeyToggle_PfPeAb7UbqCLenbJvauz2a that_8 = this;
            if (this.__GetContext__().IsImmutable)
                that_8 = Output_3 != this.__p_VqujafEWVqZLDxyofafIGe || Output_7 != this.__p_DsL9kikSDaEMDkQ69LqJ8W ? new KeyToggle_PfPeAb7UbqCLenbJvauz2a(this)
                {__p_VqujafEWVqZLDxyofafIGe = Output_3, __p_DsL9kikSDaEMDkQ69LqJ8W = Output_7} : that_8;
            else
            {
                this.__p_VqujafEWVqZLDxyofafIGe = Output_3;
                this.__p_DsL9kikSDaEMDkQ69LqJ8W = Output_7;
            }

            return that_8;
        }

        public n9.KeyToggle_PfPeAb7UbqCLenbJvauz2a __Create__(n1.NodeContext Node_Context)
        {
            n21.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("HWRqGEFJG2aNE9pYb5Pg0w", "DsL9kikSDaEMDkQ69LqJ8W", 107310U);
            var Output_1 = n24.Toggle_NRtjXBFlZv8LkW1dAEOgnz.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("HWRqGEFJG2aNE9pYb5Pg0w", "VqujafEWVqZLDxyofafIGe", 107317U);
            var Output_3 = n24.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_2);
            n9.KeyToggle_PfPeAb7UbqCLenbJvauz2a that_4 = this;
            this.__p_DsL9kikSDaEMDkQ69LqJ8W = Output_1;
            this.__p_VqujafEWVqZLDxyofafIGe = Output_3;
            return that_4;
        }

        public n9.KeyToggle_PfPeAb7UbqCLenbJvauz2a __CreateDefault__()
        {
            n9.KeyToggle_PfPeAb7UbqCLenbJvauz2a that_0 = this;
            this.__p_VqujafEWVqZLDxyofafIGe = n24.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_DsL9kikSDaEMDkQ69LqJ8W = n24.Toggle_NRtjXBFlZv8LkW1dAEOgnz.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_VqujafEWVqZLDxyofafIGe);
            n1.CompilationHelper.SafeDispose(this.__p_DsL9kikSDaEMDkQ69LqJ8W);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 107317U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "VqujafEWVqZLDxyofafIGe", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n24.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_VqujafEWVqZLDxyofafIGe;
        [n1.ElementAttribute(TracingId = 107310U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "DsL9kikSDaEMDkQ69LqJ8W", Name = "Toggle", IsManaged = true, IsAutoGenerated = true)]
        public n24.Toggle_NRtjXBFlZv8LkW1dAEOgnz __p_DsL9kikSDaEMDkQ69LqJ8W;
        public KeyToggle_PfPeAb7UbqCLenbJvauz2a(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal KeyToggle_PfPeAb7UbqCLenbJvauz2a(KeyToggle_PfPeAb7UbqCLenbJvauz2a other): base(other)
        {
            this.__p_VqujafEWVqZLDxyofafIGe = other.__p_VqujafEWVqZLDxyofafIGe;
            this.__p_DsL9kikSDaEMDkQ69LqJ8W = other.__p_DsL9kikSDaEMDkQ69LqJ8W;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VqujafEWVqZLDxyofafIGe", in __p_VqujafEWVqZLDxyofafIGe), n1.CompilationHelper.GetValueOrExisting(values, "__p_DsL9kikSDaEMDkQ69LqJ8W", in __p_DsL9kikSDaEMDkQ69LqJ8W));
        }

        internal KeyToggle_PfPeAb7UbqCLenbJvauz2a __WITH__(n24.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_VqujafEWVqZLDxyofafIGe, n24.Toggle_NRtjXBFlZv8LkW1dAEOgnz __p_DsL9kikSDaEMDkQ69LqJ8W)
        {
            n9.KeyToggle_PfPeAb7UbqCLenbJvauz2a that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_VqujafEWVqZLDxyofafIGe != this.__p_VqujafEWVqZLDxyofafIGe || __p_DsL9kikSDaEMDkQ69LqJ8W != this.__p_DsL9kikSDaEMDkQ69LqJ8W ? new KeyToggle_PfPeAb7UbqCLenbJvauz2a(this)
                {__p_VqujafEWVqZLDxyofafIGe = __p_VqujafEWVqZLDxyofafIGe, __p_DsL9kikSDaEMDkQ69LqJ8W = __p_DsL9kikSDaEMDkQ69LqJ8W} : that_0;
            else
            {
                this.__p_VqujafEWVqZLDxyofafIGe = __p_VqujafEWVqZLDxyofafIGe;
                this.__p_DsL9kikSDaEMDkQ69LqJ8W = __p_DsL9kikSDaEMDkQ69LqJ8W;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 107353U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "Kjh3JSc0Ar8NuzCAA1cRfY", Name = "InputManager_Kjh3JSc0Ar8NuzCAA1cRfY")]
    [n2.SerializableAttribute]
    public class InputManager_Kjh3JSc0Ar8NuzCAA1cRfY : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY Create(n1.NodeContext Node_Context_In)
        {
            var instance = new InputManager_Kjh3JSc0Ar8NuzCAA1cRfY(Node_Context_In, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context_In);
        }

        [n4.CreateDefaultAttribute]
        public static n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY CreateDefault()
        {
            var instance = new InputManager_Kjh3JSc0Ar8NuzCAA1cRfY(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY Update(out n7.InputManager Output_Out)
        {
            var Output_1 = this.__p_AqVutD2yB4BP60NcDHINMn.GetResource(Resource_Out: out n7.InputManager Resource_0);
            Output_Out = Resource_0;
            n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_AqVutD2yB4BP60NcDHINMn ? new InputManager_Kjh3JSc0Ar8NuzCAA1cRfY(this)
                {__p_AqVutD2yB4BP60NcDHINMn = Output_1} : that_2;
            else
            {
                this.__p_AqVutD2yB4BP60NcDHINMn = Output_1;
            }

            return that_2;
        }

        public n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY __Create__(n1.NodeContext Node_Context_In)
        {
            n21.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Result_0 = n27.Resources.GetInputManagerProvider(nodeContext: Node_Context_In);
            n1.NodeContext Node_Context_1 = Node_Context_In.CreateSubContext("HWRqGEFJG2aNE9pYb5Pg0w", "AqVutD2yB4BP60NcDHINMn", 107356U);
            var Output_2 = n29.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n28.IResourceProvider<n7.InputManager>, n7.InputManager>.Create(Node_Context: Node_Context_1);
            bool Update_3 = true;
            var Output_4 = Output_2;
            if (Update_3)
            {
                Output_4 = Output_2.Update(Input_In: Result_0);
            }

            n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY that_5 = this;
            this.__p_AqVutD2yB4BP60NcDHINMn = Output_4;
            return that_5;
        }

        public n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY __CreateDefault__()
        {
            n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY that_0 = this;
            this.__p_AqVutD2yB4BP60NcDHINMn = n29.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n28.IResourceProvider<n7.InputManager>, n7.InputManager>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_AqVutD2yB4BP60NcDHINMn);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 107356U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "AqVutD2yB4BP60NcDHINMn", Name = "Using (Process)", IsManaged = true, IsAutoGenerated = true)]
        public n29.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n28.IResourceProvider<n7.InputManager>, n7.InputManager> __p_AqVutD2yB4BP60NcDHINMn;
        public InputManager_Kjh3JSc0Ar8NuzCAA1cRfY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal InputManager_Kjh3JSc0Ar8NuzCAA1cRfY(InputManager_Kjh3JSc0Ar8NuzCAA1cRfY other): base(other)
        {
            this.__p_AqVutD2yB4BP60NcDHINMn = other.__p_AqVutD2yB4BP60NcDHINMn;
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_AqVutD2yB4BP60NcDHINMn", in __p_AqVutD2yB4BP60NcDHINMn));
        }

        internal InputManager_Kjh3JSc0Ar8NuzCAA1cRfY __WITH__(n29.Using_Process_MCPOIRh2AQkOT4VzsU5rcr<n28.IResourceProvider<n7.InputManager>, n7.InputManager> __p_AqVutD2yB4BP60NcDHINMn)
        {
            n9.InputManager_Kjh3JSc0Ar8NuzCAA1cRfY that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_AqVutD2yB4BP60NcDHINMn != this.__p_AqVutD2yB4BP60NcDHINMn ? new InputManager_Kjh3JSc0Ar8NuzCAA1cRfY(this)
                {__p_AqVutD2yB4BP60NcDHINMn = __p_AqVutD2yB4BP60NcDHINMn} : that_0;
            else
            {
                this.__p_AqVutD2yB4BP60NcDHINMn = __p_AqVutD2yB4BP60NcDHINMn;
            }

            return that_0;
        }
    }
}

namespace _VL_Stride_Input_.Stride
{
    [n1.ElementAttribute(TracingId = 107376U, DocumentId = "HWRqGEFJG2aNE9pYb5Pg0w", PersistentId = "BSneHN3QLQkPrrLFzrpYh2", Name = "VL_Stride_InputApplication_BSneHN3QLQkPrrLFzrpYh2")]
    [n2.SerializableAttribute]
    public class VL_Stride_InputApplication_BSneHN3QLQkPrrLFzrpYh2 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n30.VL_Stride_InputApplication_BSneHN3QLQkPrrLFzrpYh2 Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_Stride_InputApplication_BSneHN3QLQkPrrLFzrpYh2(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n30.VL_Stride_InputApplication_BSneHN3QLQkPrrLFzrpYh2 CreateDefault()
        {
            var instance = new VL_Stride_InputApplication_BSneHN3QLQkPrrLFzrpYh2(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n30.VL_Stride_InputApplication_BSneHN3QLQkPrrLFzrpYh2 Update()
        {
            return this;
        }

        public n30.VL_Stride_InputApplication_BSneHN3QLQkPrrLFzrpYh2 __Create__(n1.NodeContext Node_Context)
        {
            n21.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n30.VL_Stride_InputApplication_BSneHN3QLQkPrrLFzrpYh2 __CreateDefault__()
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

        public VL_Stride_InputApplication_BSneHN3QLQkPrrLFzrpYh2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_Stride_InputApplication_BSneHN3QLQkPrrLFzrpYh2(VL_Stride_InputApplication_BSneHN3QLQkPrrLFzrpYh2 other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n23.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_Stride_InputApplication_BSneHN3QLQkPrrLFzrpYh2 __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Stride_Input_
{
    public struct __AdaptiveImplementations__HWRqGEFJG2aNE9pYb5Pg0w : n33.IAdaptiveOperatorMulitply<n5.Vector2>, n33.IAdaptiveOperatorDivide<n5.Vector2>, n33.IAdaptiveOperatorPlus<n5.Vector2>, n33.IAdaptiveOperatorMinus<n5.Vector2>, n33.IAdaptiveOne<float>, n33.IAdaptiveOperatorDivide<float>, n34.IAdaptiveCreateDefault<n7.InputManager>
    {
        public void OperatorMulitply(n5.Vector2 Input_In, n5.Vector2 Input_2_In, out n5.Vector2 Output_Out)
        {
            n14.Vector2Nodes.Multiply(left: ref Input_In, right: ref Input_2_In, result: out n5.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide(n5.Vector2 Input_In, n5.Vector2 Input_2_In, out n5.Vector2 Output_Out)
        {
            var Output_0 = (n5.Vector2)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(n5.Vector2 Input_In, n5.Vector2 Input_2_In, out n5.Vector2 Output_Out)
        {
            n5.Vector2.Add(left: ref Input_In, right: ref Input_2_In, result: out n5.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus(n5.Vector2 Input_In, n5.Vector2 Input_2_In, out n5.Vector2 Output_Out)
        {
            n5.Vector2.Subtract(left: ref Input_In, right: ref Input_2_In, result: out n5.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void One(out float One_Out)
        {
            var One_0 = n31.Float32Extensions.One;
            One_Out = One_0;
            return;
        }

        public void OperatorDivide(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = (float)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n7.InputManager Output_Out)
        {
            n32._Operations_.CreateDefault_Generic<n7.InputManager>(Output_Out: out n7.InputManager Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}