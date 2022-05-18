extern alias e22;
extern alias e24;
extern alias e31;
extern alias e26;
extern alias e3;
extern alias e2;
extern alias e71;
extern alias e29;
extern alias e4;

using n4 = _Fuse_Fluid3D_.Fuse.Fluid3D;
using n30 = _VL_Collections_.Collections.Builder.DictionaryBuilder.Advanced;
using n38 = _VL_Stride_Rendering_.Stride.Rendering;
using n3 = e26::Stride.Graphics;
using n9 = _CoreLibBasics_._3D.Matrix;
using n95 = _VL_Stride_Graphics_.Stride.Utils.Advanced;
using n39 = _CoreLibBasics_.Control.Advanced;
using n12 = e2::VL.Lib.Collections;
using n13 = e3::VL.Lib.Primitive.CacheRegion;
using n36 = _CoreLibBasics_.Animation.FrameBased;
using n71 = e2::VL.Lib.Primitive;
using n16 = global::System.Reactive.Subjects;
using n26 = _CoreLibBasics_.Primitive.Object.Advanced;
using n25 = _VL_Collections_.Collections.Builder.SpreadBuilder.Advanced;
using n49 = _CoreLibBasics_.Control;
using n93 = _VL_Collections_.Collections.Dictionary;
using n18 = global::System.Collections.Immutable;
using n28 = e71::Fuse;
using n10 = _CoreLibBasics_._3D.Transform;
using n99 = _System_Memory_.System.Advanced.Adaptive;
using n17 = _VL_Reactive_.Reactive.Subjects.Subject.Advanced;
using n46 = _VL_Stride_Games_.Stride.Utils;
using n51 = _VL_Stride_Rendering_.Stride.Textures.Advanced;
using n31 = _Fuse_Fluid3D_;
using n19 = e3::VL.Lib.Reactive;
using n78 = _Fuse_Common_Compute_.Fuse.Common.Compute.Texture;
using n48 = _VL_Stride_Engine_.Stride.Models.Experimental;
using n21 = global::System.Collections;
using n67 = _VL_Stride_Rendering_ShaderFX_.Stride.Materials;
using n42 = e31::VL.Stride.Graphics;
using n11 = _Fuse_Fluid3D_.Fuse.Fluid3D.Component;
using n41 = _CoreLibBasics_._2D.Transform;
using n91 = _Fuse_Common_Compute_.Fuse.Common.Compute.Random;
using n64 = _CoreLibBasics_.Math.Ranges.Range;
using n80 = _Fuse_Core_.Fuse.Core.Function;
using n22 = global::System.Collections.Generic;
using n40 = _CoreLibBasics_._2D.Vector2;
using n45 = _Fuse_Fluid3D_.Fuse.Fluid3D.VolumeRaymarching;
using n24 = _VL_Collections_.Collections.Common.KeyValuePair;
using n83 = _Fuse_Core_.Fuse.Core.Split;
using n98 = _CoreLibBasics_.Math.Adaptive;
using n62 = _Fuse_Core_.Fuse.Core.Texture;
using n44 = _VL_Stride_Engine_.Stride.Rendering;
using n97 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n54 = e71::Fuse.compute;
using n37 = _VL_Stride_Rendering_.Stride.Rendering.Group_Spectral.Internal;
using n75 = _Fuse_Core_Math_.Fuse.Core.Math;
using n63 = _Fuse_Fluid3D_.Fuse.Fluid3D.VolumeRaymarching.GetScreenCoverageQuad;
using n77 = _Fuse_Core_.Fuse.Core.Join;
using n92 = e3::VL.Lib.Primitive;
using n73 = _Fuse_Raymarching_.Fuse.Raymarching;
using n34 = e2::VL.Lib.Runtime;
using n65 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n74 = _Fuse_Core_.Fuse.Core.Region;
using n43 = e24::Stride.Engine;
using n8 = e3::VL.Lib.Mathematics;
using n55 = _Fuse_Core_.Fuse.Core.StrideIntegration;
using n66 = _VL_Stride_Engine_.Stride.Models;
using n1 = e2::VL.Core;
using n35 = e31::VL.Stride.Rendering;
using n27 = e22::Stride.Graphics;
using n57 = _Fuse_Core_.Fuse.Core.Value;
using n2 = global::System;
using n6 = e4::Stride.Core.Mathematics;
using n89 = _Fuse_Particles_.Fuse.Particles.Attribute;
using n59 = _Fuse_Core_.Fuse.Core.Control;
using n50 = _CoreLibBasics_.Color.RGBA;
using n70 = _VL_Stride_Graphics_.Stride.Buffers;
using n61 = _VL_Stride_Graphics_.Stride.Textures;
using n15 = e3::VL.Lib.Primitive.Object;
using n76 = _Fuse_Core_.Fuse.Core.Swizzle;
using n88 = _Fuse_Particles_.Fuse.Particles.Drawer;
using n5 = e2::VL.Core.CompilerServices;
using n87 = _Fuse_Particles_.Fuse.Particles.Emitter;
using n86 = _Fuse_Particles_.Fuse.Particles.Integration;
using n58 = _Fuse_Fluid3D_.Fuse.Fluid3D.Component.Utils;
using n96 = e3::VL.Lib;
using n72 = _Fuse_Common_Compute_.Fuse.Common.Compute.Topology;
using n68 = _VL_Stride_Rendering_.Stride.Models.Meshes.Advanced;
using n60 = _Fuse_Core_.Fuse.Core.ComputeShader.FixedType;
using n52 = _VL_Collections_.Collections.Mutable.MutableArray.Advanced;
using n20 = _VL_Reactive_.Reactive.HoldLatest;
using n84 = _Fuse_Common_Compute_.Fuse.Common.Compute.Draw.Internal;
using n47 = _VL_Stride_Engine_.Stride;
using n81 = _Fuse_Fluid3D_.Fuse.Fluid3D.Component.AugmentedTexture2DVectorField_Fluid3D.Internal;
using n33 = e29::Stride.Rendering;
using n79 = _Fuse_Core_.Fuse.Core.Util;
using n23 = _VL_Collections_.Collections.Sequence;
using n29 = global::System.Runtime.CompilerServices;
using n82 = _Fuse_Core_.Fuse.Core.Conversion;
using n85 = _Fuse_Common_Compute_.Fuse.Common.Compute;
using n53 = global::System.Linq;
using n90 = _Fuse_Particles_.Fuse.Particles.Operation;
using n14 = _VL_Collections_.Collections.Spread;
using n32 = e31::VL.Stride.Rendering.ComputeEffect;
using n56 = _Fuse_Core_.Fuse.Core.ComputeShader;
using n94 = _CoreLibBasics_.Primitive.Advanced;
using n69 = _CoreLibBasics_._3D.Vector4;
using n7 = _CoreLibBasics_._3D.Vector3;

namespace _Fuse_Fluid3D_.Fuse.Fluid3D
{
    [n1.ElementAttribute(TracingId = 339783U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RBW2Rt3bx7APQrzUyrfqy0", Name = "FluidContext_C")]
    [n2.SerializableAttribute]
    public class FluidContext_C : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.FluidContext_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new FluidContext_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.FluidContext_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new FluidContext_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.FluidContext_C Configure([n5.SerializedDefaultValueAttribute("128, 128, 128", false)] n6.Int3 Resolution_In, n6.Matrix Transform_In, [n5.SerializedDefaultValueAttribute("1", false)] float Fluid_TimeStep_In, [n5.SerializedDefaultValueAttribute("1", false)] float Velocity_Modulate_In, [n5.SerializedDefaultValueAttribute("6", false)] int Jacobi_Iterations_In, [n5.SerializedDefaultValueAttribute("0.0899999961", false)] float Vorticity_Strength_In, n12.Spread<n11.IFluidComponent_I> Components_In)
        {
            int __pad_RUKSxa5OovmNiMAHqqS88o_0 = __slot_RUKSxa5OovmNiMAHqqS88o;
            this.Resolution = Resolution_In;
            n6.Int3 __auto_1 = Resolution_In;
            var Output_2 = n6.Int3.Divide(value: Resolution_In, scale: __pad_RUKSxa5OovmNiMAHqqS88o_0);
            this.Thread_Group_Count = Output_2;
            n6.Int3 __auto_3 = Output_2;
            var Result_4 = (n6.Vector3)Resolution_In;
            var Result_8 = Transform_In.Decompose(scale: out n6.Vector3 Scale_5, rotation: out n6.Quaternion Rotation_6, translation: out n6.Vector3 Translation_7);
            var Output_9 = (n6.Vector3)Scale_5 / Result_4;
            var Output_10 = (n6.Vector3)Translation_7 / Output_9;
            n7._Operations_.Floor_Float(Input_In: Output_10, Output_Out: out n6.Vector3 Output_11);
            n8.Vector3Nodes.Multiply(left: ref Output_9, right: ref Output_11, result: out n6.Vector3 Output_12);
            this.Grid_Position = Output_11;
            n6.Vector3 __auto_13 = Output_11;
            n6.Matrix Input_14 = n9._Operations_.CreateDefault();
            n6.Vector3 Rotation_15 = n7._Operations_.CreateDefault();
            n10._Operations_.TransformSRT(Input_In: Input_14, Scaling_In: Scale_5, Rotation_In: Rotation_15, Translation_In: Output_12, Output_Out: out n6.Matrix Output_16);
            n6.Matrix.Invert(value: ref Output_16, result: out n6.Matrix Output_17);
            this.Transform_Inverse = Output_17;
            n6.Matrix __auto_18 = Output_17;
            this.Transform = Output_16;
            n6.Matrix __auto_19 = Output_16;
            n6.Vector3 Input_20 = __c_FiMMZGo5QcPNYnYFSocTFa;
            var Output_21 = (n6.Vector3)Input_20 / Scale_5;
            this.Scale_Inverse = Output_21;
            n6.Vector3 __auto_22 = Output_21;
            this.Scale = Scale_5;
            n6.Vector3 __auto_23 = Scale_5;
            this.Fluid_TimeStep = Fluid_TimeStep_In;
            float __auto_24 = Fluid_TimeStep_In;
            this.Velocity_Modulate = Velocity_Modulate_In;
            float __auto_25 = Velocity_Modulate_In;
            this.Jacobi_Iterations = Jacobi_Iterations_In;
            int __auto_26 = Jacobi_Iterations_In;
            this.Vorticity_Strength = Vorticity_Strength_In;
            float __auto_27 = Vorticity_Strength_In;
            FluidContext_C Instance_28 = this;
            bool Force_29 = false;
            bool Dispose_Cached_Outputs_30 = false;
            var manager_31 = this.__cache_NogMnWzCgK6OZUdqEDbVzx;
            if (manager_31 is null)
            {
                manager_31 = new n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>>(n2.ValueTuple.Create(n14._Operations_.CreateDefault<n11.IFluidComponent_I>()));
            }

            var inputs_32 = n2.ValueTuple.Create(Components_In);
            var outputs_33 = manager_31.Outputs;
            var Has_Changed_34 = Force_29 || manager_31.InputsChanged(inputs_32);
            if (Has_Changed_34)
            {
                if (Dispose_Cached_Outputs_30)
                    manager_31.DisposeOutputs();
                var __fallback___36 = n1.ServiceRegistry.Current;
                n14._Operations_.Where<n11.IFluidComponent_I>(Input_In: Components_In, Predicate_In: (n11.IFluidComponent_I Input_1_In_38, int Input_2_In_39) =>
                {
                    using var __current_37 = __fallback___36.MakeCurrentIfNone();
                    n15.ObjectHelpers.IsAssigned(x: Input_1_In_38, result: out bool Result_40, notAssigned: out bool Not_Assigned_41);
                    var Output_42 = Input_1_In_38;
                    if (Result_40)
                    {
                        Output_42 = ((n11.IFluidComponent_I)Input_1_In_38).SetContext(Context_In: Instance_28);
                    }

                    return Result_40;
                }

                , Output_Out: out n12.Spread<n11.IFluidComponent_I> Output_43);
                outputs_33 = n2.ValueTuple.Create(Output_43);
                manager_31 = manager_31.Update(inputs_32, __GetContext__().IsImmutable, Dispose_Cached_Outputs_30, default, outputs_33);
            }
            else
            {
                manager_31.Update(inputs_32, __GetContext__().IsImmutable, Dispose_Cached_Outputs_30);
            }

            var __auto_44 = outputs_33.Item1;
            this.__cache_NogMnWzCgK6OZUdqEDbVzx = manager_31;
            var Output_45 = new n6.Int3(x: __pad_RUKSxa5OovmNiMAHqqS88o_0, y: __pad_RUKSxa5OovmNiMAHqqS88o_0, z: __pad_RUKSxa5OovmNiMAHqqS88o_0);
            this.Thread_Group_Size = Output_45;
            n6.Int3 __auto_46 = Output_45;
            this.Components = __auto_44;
            n12.Spread<n11.IFluidComponent_I> __auto_47 = __auto_44;
            return this;
        }

        public n4.FluidContext_C GetResetStream(out n16.Subject<bool> Reset_Stream_Out)
        {
            n16.Subject<bool> __auto_0 = this.Reset_Stream;
            Reset_Stream_Out = __auto_0;
            return this;
        }

        public n4.FluidContext_C Reset()
        {
            n16.Subject<bool> __auto_0 = this.Reset_Stream;
            bool Value_1 = false;
            n17._Operations_.OnNext<bool>(Input_In: __auto_0, Value_In: Value_1, Output_Out: out n16.Subject<bool> Output_2);
            return this;
        }

        public n4.FluidContext_C GetResolution(out n6.Int3 Resolution_Out)
        {
            n6.Int3 __auto_0 = this.Resolution;
            Resolution_Out = __auto_0;
            return this;
        }

        public n4.FluidContext_C GetDispatch(out n6.Int3 Thread_Group_Count_Out, out n6.Int3 Thread_Group_Size_Out)
        {
            n6.Int3 __auto_0 = this.Thread_Group_Count;
            n6.Int3 __auto_1 = this.Thread_Group_Size;
            Thread_Group_Count_Out = __auto_0;
            Thread_Group_Size_Out = __auto_1;
            return this;
        }

        public n4.FluidContext_C GetJacobiIterations(out int Jacobi_Iterations_Out)
        {
            int __auto_0 = this.Jacobi_Iterations;
            Jacobi_Iterations_Out = __auto_0;
            return this;
        }

        public n4.FluidContext_C Update()
        {
            n3.PixelFormat __pad_IrIuNPlaYdGLYMoRvh7iKw_0 = __slot_IrIuNPlaYdGLYMoRvh7iKw;
            n6.Int3 __auto_1 = this.Resolution;
            n6.Int3 __auto_2 = this.Resolution;
            n3.PixelFormat __pad_KcUEsCJ52ggQUmTJ5rGHYa_3 = __slot_KcUEsCJ52ggQUmTJ5rGHYa;
            n12.Spread<n11.IFluidComponent_I> __auto_4 = this.Components;
            n18.ImmutableDictionary<string, n4.ISimulationTexture_I>.Builder __auto_5 = this.Textures;
            n12.SpreadBuilder<n4.TextureAdvector_C> __auto_6 = this.Texture_Advectors;
            n6.Int3 __auto_7 = this.Resolution;
            n6.Int3 __auto_8 = this.Resolution;
            n3.PixelFormat __pad_ST1NyIdUeXNONQdWV2CSkn_9 = __slot_ST1NyIdUeXNONQdWV2CSkn;
            n6.Int3 __auto_10 = this.Resolution;
            n3.PixelFormat __pad_C7rb9TLz11kNnB39I2gZm4_11 = __slot_C7rb9TLz11kNnB39I2gZm4;
            n6.Int3 __auto_12 = this.Resolution;
            n3.PixelFormat __pad_BHEgR3clRESLzqm8lRVwdA_13 = __slot_BHEgR3clRESLzqm8lRVwdA;
            n6.Int3 __auto_14 = this.Resolution;
            n3.PixelFormat __pad_TdVFeMgJlayLhJA5DCamBT_15 = __slot_TdVFeMgJlayLhJA5DCamBT;
            string __pad_AmYyVhT0KewPz7Q4zlFydH_16 = __slot_AmYyVhT0KewPz7Q4zlFydH;
            string __pad_HokiLup2NqJNQNrf5VrlSW_17 = __slot_HokiLup2NqJNQNrf5VrlSW;
            string __pad_Ciaqn7IAdUdN1rNfV6TXNb_18 = __slot_Ciaqn7IAdUdN1rNfV6TXNb;
            float __auto_19 = this.Velocity_Modulate;
            n20._Operations_.GetData_H<bool>(Input_In: this.__p_AuwmDIrW6K3NaglPoxwFRA, Output_Out: out n19.HoldLatest<bool> Output_20, Value_Out: out bool Value_21, On_Data_Out: out bool On_Data_22);
            this.__p_AuwmDIrW6K3NaglPoxwFRA = Output_20;
            bool Update_23 = true;
            var Output_24 = this.__p_VUheMA8TPHrLfSv0ExM3Tw;
            if (Update_23)
            {
                Output_24 = this.__p_VUheMA8TPHrLfSv0ExM3Tw.Update(Size_In: __auto_1, Format_In: __pad_IrIuNPlaYdGLYMoRvh7iKw_0, Recreate_In: On_Data_22);
            }

            this.__p_VUheMA8TPHrLfSv0ExM3Tw = Output_24;
            bool Update_25 = true;
            var Output_26 = this.__p_SA6Ke7VfrRILuYxPLEHlyr;
            if (Update_25)
            {
                Output_26 = this.__p_SA6Ke7VfrRILuYxPLEHlyr.Update(Size_In: __auto_2, Format_In: __pad_KcUEsCJ52ggQUmTJ5rGHYa_3, Recreate_In: On_Data_22);
            }

            this.__p_SA6Ke7VfrRILuYxPLEHlyr = Output_26;
            n4.ISimulationTexture_I Value_27 = (n4.ISimulationTexture_I)Output_26;
            bool Update_28 = true;
            var Output_29 = this.__p_VHtUnBpG3BuPi9cyoI9UKn;
            if (Update_28)
            {
                Output_29 = this.__p_VHtUnBpG3BuPi9cyoI9UKn.Update(Size_In: __auto_8, Format_In: __pad_ST1NyIdUeXNONQdWV2CSkn_9, Recreate_In: On_Data_22);
            }

            this.__p_VHtUnBpG3BuPi9cyoI9UKn = Output_29;
            n4.ISimulationTexture_I Value_30 = (n4.ISimulationTexture_I)Output_29;
            bool Update_31 = true;
            var Output_32 = this.__p_AhVq8QtEYyVLCTIwMxsQrk;
            if (Update_31)
            {
                Output_32 = this.__p_AhVq8QtEYyVLCTIwMxsQrk.Update(Size_In: __auto_10, Format_In: __pad_C7rb9TLz11kNnB39I2gZm4_11, Recreate_In: On_Data_22);
            }

            this.__p_AhVq8QtEYyVLCTIwMxsQrk = Output_32;
            n4.ISimulationTexture_I Value_33 = (n4.ISimulationTexture_I)Output_32;
            bool Update_34 = true;
            var Output_35 = this.__p_RTqQN4GTHyIOzHV2FuCood;
            if (Update_34)
            {
                Output_35 = this.__p_RTqQN4GTHyIOzHV2FuCood.Update(Size_In: __auto_12, Format_In: __pad_BHEgR3clRESLzqm8lRVwdA_13, Recreate_In: On_Data_22);
            }

            this.__p_RTqQN4GTHyIOzHV2FuCood = Output_35;
            n4.ISimulationTexture_I Value_36 = (n4.ISimulationTexture_I)Output_35;
            bool Update_37 = true;
            var Output_38 = this.__p_ARPX7rr18m6P0OghJVlUQY;
            if (Update_37)
            {
                Output_38 = this.__p_ARPX7rr18m6P0OghJVlUQY.Update(Size_In: __auto_14, Format_In: __pad_TdVFeMgJlayLhJA5DCamBT_15, Recreate_In: On_Data_22);
            }

            this.__p_ARPX7rr18m6P0OghJVlUQY = Output_38;
            n4.ISimulationTexture_I Value_39 = (n4.ISimulationTexture_I)Output_38;
            float Forward_40 = 1F;
            bool Enabled_41 = true;
            bool Update_42 = true;
            var Output_43 = this.__p_Ur0k3L387WRO8bHEV7sTop;
            if (Update_42)
            {
                Output_43 = this.__p_Ur0k3L387WRO8bHEV7sTop.Update(Name_In: __pad_AmYyVhT0KewPz7Q4zlFydH_16, VectorField_Texture_Id_In: __pad_HokiLup2NqJNQNrf5VrlSW_17, Target_Texture_Id_In: __pad_Ciaqn7IAdUdN1rNfV6TXNb_18, Modulate_In: __auto_19, Forward_In: Forward_40, Enabled_In: Enabled_41);
            }

            this.__p_Ur0k3L387WRO8bHEV7sTop = Output_43;
            bool Dispose_Cached_Outputs_44 = false;
            var manager_45 = this.__cache_GXJZqiDhtoAOHoWyRiZn7B;
            if (manager_45 is null)
            {
                manager_45 = new n13.Manager<n2.ValueTuple<n4.PingPongTexture3D_Fluid_C, n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple>(n2.ValueTuple.Create());
            }

            var inputs_46 = (Output_24, __auto_4);
            var outputs_47 = manager_45.Outputs;
            var Has_Changed_48 = On_Data_22 || manager_45.InputsChanged(inputs_46);
            if (Has_Changed_48)
            {
                if (Dispose_Cached_Outputs_44)
                    manager_45.DisposeOutputs();
                string __pad_MK9vRx3X1lfMZVFF2h5Ba6_50 = __slot_MK9vRx3X1lfMZVFF2h5Ba6;
                string __pad_IwV1Kndha93N3kzV79Wb8K_51 = __slot_IwV1Kndha93N3kzV79Wb8K;
                string __pad_V7e4npfn4ZGLsJmMJOq0VQ_52 = __slot_V7e4npfn4ZGLsJmMJOq0VQ;
                string __pad_Ug6rXv9cEUTMv4bU6BKSao_53 = __slot_Ug6rXv9cEUTMv4bU6BKSao;
                string __pad_V7iyStUqqYAOrYqOPGSnxo_54 = __slot_V7iyStUqqYAOrYqOPGSnxo;
                string __pad_GrIm1qqEimOLVADk4APXHJ_55 = __slot_GrIm1qqEimOLVADk4APXHJ;
                __auto_5.Clear();
                n4.ISimulationTexture_I Value_56 = (n4.ISimulationTexture_I)Output_24;
                __auto_5[__pad_MK9vRx3X1lfMZVFF2h5Ba6_50] = Value_56;
                __auto_5[__pad_IwV1Kndha93N3kzV79Wb8K_51] = Value_27;
                __auto_5[__pad_V7e4npfn4ZGLsJmMJOq0VQ_52] = Value_30;
                __auto_5[__pad_Ug6rXv9cEUTMv4bU6BKSao_53] = Value_33;
                __auto_5[__pad_V7iyStUqqYAOrYqOPGSnxo_54] = Value_36;
                __auto_5[__pad_GrIm1qqEimOLVADk4APXHJ_55] = Value_39;
                n21.IEnumerable Input_57 = (n21.IEnumerable)__auto_4;
                n23._Operations_.OfType<n11.ITextureProvider_I>(Input_In: Input_57, Result_Out: out n22.IEnumerable<n11.ITextureProvider_I> Result_58);
                n18.ImmutableDictionary<string, n4.ISimulationTexture_I>.Builder accumulator_60 = __auto_5;
                var i_62 = 0;
                foreach (var item_59 in Result_58)
                {
                    var splicer_61 = item_59;
                    var i_local_63 = i_62;
                    bool Recreate_65 = false;
                    var Output_66 = ((n11.ITextureProvider_I)splicer_61).SetTextureSettings(Size_In: __auto_7, Recreate_In: Recreate_65);
                    var Output_68 = ((n11.ITextureProvider_I)Output_66).GetTextures(Textures_Out: out n18.ImmutableDictionary<string, n4.ISimulationTexture_I> Textures_67);
                    n18.ImmutableDictionary<string, n4.ISimulationTexture_I>.Builder accumulator_70 = accumulator_60;
                    var i_72 = 0;
                    foreach (var item_69 in Textures_67)
                    {
                        var splicer_71 = item_69;
                        var i_local_73 = i_72;
                        n24._Operations_.Split<string, n4.ISimulationTexture_I>(Input_In: splicer_71, Key_Out: out string Key_75, Value_Out: out n4.ISimulationTexture_I Value_76);
                        accumulator_70[Key_75] = Value_76;
                        i_72++;
                    }

                    accumulator_60 = accumulator_70;
                    i_62++;
                }

                n21.IEnumerable Input_77 = (n21.IEnumerable)__auto_4;
                n23._Operations_.OfType<n11.ITextureAdvectorProvider_I>(Input_In: Input_77, Result_Out: out n22.IEnumerable<n11.ITextureAdvectorProvider_I> Result_78);
                n25._Operations_.Clear<n4.TextureAdvector_C>(Input_In: __auto_6, Output_Out: out n12.SpreadBuilder<n4.TextureAdvector_C> Output_79);
                n25._Operations_.Add<n4.TextureAdvector_C>(Input_In: Output_79, Item_In: Output_43, Output_Out: out n12.SpreadBuilder<n4.TextureAdvector_C> Output_80);
                n12.SpreadBuilder<n4.TextureAdvector_C> accumulator_82 = Output_80;
                var i_84 = 0;
                foreach (var item_81 in Result_78)
                {
                    var splicer_83 = item_81;
                    var i_local_85 = i_84;
                    var Output_88 = ((n11.ITextureAdvectorProvider_I)splicer_83).GetTextureAdvectors(Texture_Advectors_Out: out n12.Spread<n4.TextureAdvector_C> Texture_Advectors_87);
                    n12.SpreadBuilder<n4.TextureAdvector_C> accumulator_90 = accumulator_82;
                    var i_92 = 0;
                    foreach (var item_89 in n5.CollectionExtensions.AsSpan(Texture_Advectors_87))
                    {
                        var splicer_91 = item_89;
                        var i_local_93 = i_92;
                        n25._Operations_.Add<n4.TextureAdvector_C>(Input_In: accumulator_90, Item_In: splicer_91, Output_Out: out n12.SpreadBuilder<n4.TextureAdvector_C> Output_95);
                        accumulator_90 = Output_95;
                        i_92++;
                    }

                    accumulator_82 = accumulator_90;
                    i_84++;
                }

                outputs_47 = n2.ValueTuple.Create();
                manager_45 = manager_45.Update(inputs_46, __GetContext__().IsImmutable, Dispose_Cached_Outputs_44, default, outputs_47);
            }
            else
            {
                manager_45.Update(inputs_46, __GetContext__().IsImmutable, Dispose_Cached_Outputs_44);
            }

            this.__cache_GXJZqiDhtoAOHoWyRiZn7B = manager_45;
            return this;
        }

        public n4.FluidContext_C GetVorticityStrength(out float Vorticity_Strength_Out)
        {
            float __auto_0 = this.Vorticity_Strength;
            Vorticity_Strength_Out = __auto_0;
            return this;
        }

        public n4.FluidContext_C GetFluidTimeStep(out float Fluid_TimeStep_Out)
        {
            float __auto_0 = this.Fluid_TimeStep;
            Fluid_TimeStep_Out = __auto_0;
            return this;
        }

        public n4.FluidContext_C SetResolution([n5.SerializedDefaultValueAttribute("96, 96, 96", false)] n6.Int3 Resolution_In)
        {
            this.Resolution = Resolution_In;
            n6.Int3 __auto_0 = Resolution_In;
            return this;
        }

        public n4.FluidContext_C GetTransform(out n6.Matrix Transform_Out, out n6.Matrix Transform_Inverse_Out)
        {
            n6.Matrix __auto_0 = this.Transform;
            n6.Matrix __auto_1 = this.Transform_Inverse;
            Transform_Out = __auto_0;
            Transform_Inverse_Out = __auto_1;
            return this;
        }

        public n4.FluidContext_C GetScale(out n6.Vector3 Scale_Out, out n6.Vector3 Scale_Inverse_Out)
        {
            n6.Vector3 __auto_0 = this.Scale;
            n6.Vector3 __auto_1 = this.Scale_Inverse;
            Scale_Out = __auto_0;
            Scale_Inverse_Out = __auto_1;
            return this;
        }

        public n4.FluidContext_C GetResolutionVector(out n6.Vector3 Resolution_Out)
        {
            n6.Int3 __auto_0 = this.Resolution;
            var Result_1 = (n6.Vector3)__auto_0;
            Resolution_Out = Result_1;
            return this;
        }

        public n4.FluidContext_C GetGridPosition(out n6.Vector3 Grid_Position_Out)
        {
            n6.Vector3 __auto_0 = this.Grid_Position;
            Grid_Position_Out = __auto_0;
            return this;
        }

        public n4.FluidContext_C GetComponents(out n12.Spread<n11.IFluidComponent_I> Components_Out)
        {
            n12.Spread<n11.IFluidComponent_I> __auto_0 = this.Components;
            Components_Out = __auto_0;
            return this;
        }

        public n4.FluidContext_C SwapPingPongTextureWithName(string Texture_Name_In, out bool Found_Out)
        {
            n18.ImmutableDictionary<string, n4.ISimulationTexture_I>.Builder __auto_0 = this.Textures;
            var Result_2 = __auto_0.TryGetValue(key: Texture_Name_In, value: out n4.ISimulationTexture_I Value_1);
            n4.PingPongTexture3D_Fluid_C Default_3 = n4.PingPongTexture3D_Fluid_C.CreateDefault();
            n26._Operations_.CastAs<n4.PingPongTexture3D_Fluid_C>(Input_In: Value_1, Default_In: Default_3, Result_Out: out n4.PingPongTexture3D_Fluid_C Result_4, Success_Out: out bool Success_5);
            var Output_6 = Result_2 && Success_5;
            var Output_7 = Result_4;
            if (Output_6)
            {
                Output_7 = Result_4.SwapTexture();
            }

            Found_Out = Result_2;
            return this;
        }

        public n4.FluidContext_C GetTextureWithName(string Texture_Name_In, out n27.Texture Texture_Read_Out, out n28.GpuValue<n27.Texture> Texture_Read_Graph_Out, out n27.Texture Texture_ReadWrite_Out, out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_Out, out bool Found_Out)
        {
            n18.ImmutableDictionary<string, n4.ISimulationTexture_I>.Builder __auto_0 = this.Textures;
            var Result_2 = __auto_0.TryGetValue(key: Texture_Name_In, value: out n4.ISimulationTexture_I Value_1);
            n27.Texture __auto_3;
            n28.GpuValue<n27.Texture> __auto_4;
            n27.Texture __auto_5;
            n28.GpuValue<n27.Texture> __auto_6;
            if (Result_2)
            {
                var Output_12 = ((n4.ISimulationTexture_I)Value_1).GetTexture(Texture_Read_Out: out n27.Texture Texture_Read_8, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_9, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_10, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_11);
                __auto_3 = Texture_Read_8;
                __auto_4 = Texture_Read_Graph_9;
                __auto_5 = Texture_ReadWrite_10;
                __auto_6 = Texture_ReadWrite_Graph_11;
            }
            else
            {
                __auto_3 = default(n27.Texture);
                __auto_4 = default(n28.GpuValue<n27.Texture>);
                __auto_5 = default(n27.Texture);
                __auto_6 = default(n28.GpuValue<n27.Texture>);
            }

            Texture_Read_Out = __auto_3;
            Texture_Read_Graph_Out = __auto_4;
            Texture_ReadWrite_Out = __auto_5;
            Texture_ReadWrite_Graph_Out = __auto_6;
            Found_Out = Result_2;
            return this;
        }

        public n4.FluidContext_C GetTextureAdvectors(out n12.Spread<n4.TextureAdvector_C> Texture_Advectors_Out)
        {
            n12.SpreadBuilder<n4.TextureAdvector_C> __auto_0 = this.Texture_Advectors;
            n25._Operations_.ToSpread<n4.TextureAdvector_C>(Input_In: __auto_0, Output_Out: out n12.SpreadBuilder<n4.TextureAdvector_C> Output_1, Result_Out: out n12.Spread<n4.TextureAdvector_C> Result_2);
            Texture_Advectors_Out = Result_2;
            return this;
        }

        public n4.FluidContext_C __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Reset_Stream = default(n16.Subject<bool>);
            this.Fluid_TimeStep = 0F;
            this.Vorticity_Strength = 0F;
            this.Resolution = default(n6.Int3);
            this.Thread_Group_Count = default(n6.Int3);
            this.Thread_Group_Size = default(n6.Int3);
            this.Jacobi_Iterations = 0;
            this.Grid_Position = n7._Operations_.CreateDefault();
            this.Scale = n7._Operations_.CreateDefault();
            this.Transform = n9._Operations_.CreateDefault();
            this.Transform_Inverse = n9._Operations_.CreateDefault();
            this.Scale_Inverse = n7._Operations_.CreateDefault();
            this.Velocity_Modulate = 0F;
            this.Components = n14._Operations_.CreateDefault<n11.IFluidComponent_I>();
            this.Textures = n30._Operations_.CreateDefault<string, n4.ISimulationTexture_I>();
            this.Texture_Advectors = n25._Operations_.CreateDefault<n4.TextureAdvector_C>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "InYyW3eexk9OuG28MqdL36", 339873U);
            n17._Operations_.Create<bool>(Node_Context: Node_Context_0, Output_Out: out n16.Subject<bool> Output_1);
            this.Reset_Stream = Output_1;
            n16.Subject<bool> __auto_2 = Output_1;
            n2.IObservable<bool> Async_Notifications_3 = (n2.IObservable<bool>)__auto_2;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "AuwmDIrW6K3NaglPoxwFRA", 339858U);
            bool Initial_Result_5 = false;
            n20._Operations_.Create_H<bool>(Node_Context: Node_Context_4, Initial_Result_In: Initial_Result_5, Output_Out: out n19.HoldLatest<bool> Output_6);
            this.__p_AuwmDIrW6K3NaglPoxwFRA = Output_6;
            bool Reset_7 = false;
            bool Update_8 = true;
            var Output_9 = Output_6;
            if (Update_8)
            {
                n20._Operations_.Update_H<bool>(Input_In: Output_6, Async_Notifications_In: Async_Notifications_3, Reset_In: Reset_7, Output_Out: out Output_9);
            }

            this.__p_AuwmDIrW6K3NaglPoxwFRA = Output_9;
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "VUheMA8TPHrLfSv0ExM3Tw", 340314U);
            var Output_11 = n4.PingPongTexture3D_Fluid_C.Create(Node_Context: Node_Context_10);
            this.__p_VUheMA8TPHrLfSv0ExM3Tw = Output_11;
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "SA6Ke7VfrRILuYxPLEHlyr", 340366U);
            var Output_13 = n4.PingPongTexture3D_Fluid_C.Create(Node_Context: Node_Context_12);
            this.__p_SA6Ke7VfrRILuYxPLEHlyr = Output_13;
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "VHtUnBpG3BuPi9cyoI9UKn", 340819U);
            var Output_15 = n4.Texture3D_Fluid_C.Create(Node_Context: Node_Context_14);
            this.__p_VHtUnBpG3BuPi9cyoI9UKn = Output_15;
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "AhVq8QtEYyVLCTIwMxsQrk", 340864U);
            var Output_17 = n4.Texture3D_Fluid_C.Create(Node_Context: Node_Context_16);
            this.__p_AhVq8QtEYyVLCTIwMxsQrk = Output_17;
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "RTqQN4GTHyIOzHV2FuCood", 340875U);
            var Output_19 = n4.Texture3D_Fluid_C.Create(Node_Context: Node_Context_18);
            this.__p_RTqQN4GTHyIOzHV2FuCood = Output_19;
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "ARPX7rr18m6P0OghJVlUQY", 340885U);
            var Output_21 = n4.Texture3D_Fluid_C.Create(Node_Context: Node_Context_20);
            this.__p_ARPX7rr18m6P0OghJVlUQY = Output_21;
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Ur0k3L387WRO8bHEV7sTop", 340975U);
            var Output_23 = n4.TextureAdvector_C.Create(Node_Context: Node_Context_22);
            this.__p_Ur0k3L387WRO8bHEV7sTop = Output_23;
            this.__p_SZoqZUhrMClO2KCqiWOko3 = n26._Operations_.CreateDefault();
            this.__cache_NogMnWzCgK6OZUdqEDbVzx = null;
            this.__cache_GXJZqiDhtoAOHoWyRiZn7B = null;
            return this;
        }

        public n4.FluidContext_C __CreateDefault__()
        {
            this.Reset_Stream = default(n16.Subject<bool>);
            this.Fluid_TimeStep = 0F;
            this.Vorticity_Strength = 0F;
            this.Resolution = default(n6.Int3);
            this.Thread_Group_Count = default(n6.Int3);
            this.Thread_Group_Size = default(n6.Int3);
            this.Jacobi_Iterations = 0;
            this.Grid_Position = n7._Operations_.CreateDefault();
            this.Scale = n7._Operations_.CreateDefault();
            this.Transform = n9._Operations_.CreateDefault();
            this.Transform_Inverse = n9._Operations_.CreateDefault();
            this.Scale_Inverse = n7._Operations_.CreateDefault();
            this.Velocity_Modulate = 0F;
            this.Components = n14._Operations_.CreateDefault<n11.IFluidComponent_I>();
            this.Textures = n30._Operations_.CreateDefault<string, n4.ISimulationTexture_I>();
            this.Texture_Advectors = n25._Operations_.CreateDefault<n4.TextureAdvector_C>();
            this.__p_SZoqZUhrMClO2KCqiWOko3 = n26._Operations_.CreateDefault();
            this.__cache_NogMnWzCgK6OZUdqEDbVzx = null;
            this.__p_AuwmDIrW6K3NaglPoxwFRA = default(n19.HoldLatest<bool>);
            this.__p_VUheMA8TPHrLfSv0ExM3Tw = n4.PingPongTexture3D_Fluid_C.CreateDefault();
            this.__p_SA6Ke7VfrRILuYxPLEHlyr = n4.PingPongTexture3D_Fluid_C.CreateDefault();
            this.__p_VHtUnBpG3BuPi9cyoI9UKn = n4.Texture3D_Fluid_C.CreateDefault();
            this.__p_AhVq8QtEYyVLCTIwMxsQrk = n4.Texture3D_Fluid_C.CreateDefault();
            this.__p_RTqQN4GTHyIOzHV2FuCood = n4.Texture3D_Fluid_C.CreateDefault();
            this.__p_ARPX7rr18m6P0OghJVlUQY = n4.Texture3D_Fluid_C.CreateDefault();
            this.__p_Ur0k3L387WRO8bHEV7sTop = n4.TextureAdvector_C.CreateDefault();
            this.__cache_GXJZqiDhtoAOHoWyRiZn7B = null;
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SZoqZUhrMClO2KCqiWOko3);
            n1.CompilationHelper.SafeDispose(this.__cache_NogMnWzCgK6OZUdqEDbVzx);
            n1.CompilationHelper.SafeDispose(this.__p_AuwmDIrW6K3NaglPoxwFRA);
            n1.CompilationHelper.SafeDispose(this.__p_VUheMA8TPHrLfSv0ExM3Tw);
            n1.CompilationHelper.SafeDispose(this.__p_SA6Ke7VfrRILuYxPLEHlyr);
            n1.CompilationHelper.SafeDispose(this.__p_VHtUnBpG3BuPi9cyoI9UKn);
            n1.CompilationHelper.SafeDispose(this.__p_AhVq8QtEYyVLCTIwMxsQrk);
            n1.CompilationHelper.SafeDispose(this.__p_RTqQN4GTHyIOzHV2FuCood);
            n1.CompilationHelper.SafeDispose(this.__p_ARPX7rr18m6P0OghJVlUQY);
            n1.CompilationHelper.SafeDispose(this.__p_Ur0k3L387WRO8bHEV7sTop);
            n1.CompilationHelper.SafeDispose(this.__cache_GXJZqiDhtoAOHoWyRiZn7B);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 339793U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KcUEsCJ52ggQUmTJ5rGHYa", Name = "__slot_KcUEsCJ52ggQUmTJ5rGHYa")]
        public static n3.PixelFormat __slot_KcUEsCJ52ggQUmTJ5rGHYa = n1.CompilationHelper.Deserialize<n3.PixelFormat>("R16_Float", false, "KeWf79wIWCVN4a6TzD33r2", "KcUEsCJ52ggQUmTJ5rGHYa");
        [n1.ElementAttribute(TracingId = 339803U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ST1NyIdUeXNONQdWV2CSkn", Name = "__slot_ST1NyIdUeXNONQdWV2CSkn")]
        public static n3.PixelFormat __slot_ST1NyIdUeXNONQdWV2CSkn = n1.CompilationHelper.Deserialize<n3.PixelFormat>("R16G16B16A16_Float", false, "KeWf79wIWCVN4a6TzD33r2", "ST1NyIdUeXNONQdWV2CSkn");
        [n1.ElementAttribute(TracingId = 339812U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "C7rb9TLz11kNnB39I2gZm4", Name = "__slot_C7rb9TLz11kNnB39I2gZm4")]
        public static n3.PixelFormat __slot_C7rb9TLz11kNnB39I2gZm4 = n1.CompilationHelper.Deserialize<n3.PixelFormat>("R16_Float", false, "KeWf79wIWCVN4a6TzD33r2", "C7rb9TLz11kNnB39I2gZm4");
        [n1.ElementAttribute(TracingId = 339819U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BHEgR3clRESLzqm8lRVwdA", Name = "__slot_BHEgR3clRESLzqm8lRVwdA")]
        public static n3.PixelFormat __slot_BHEgR3clRESLzqm8lRVwdA = n1.CompilationHelper.Deserialize<n3.PixelFormat>("R8_UNorm", false, "KeWf79wIWCVN4a6TzD33r2", "BHEgR3clRESLzqm8lRVwdA");
        [n1.ElementAttribute(TracingId = 339827U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TdVFeMgJlayLhJA5DCamBT", Name = "__slot_TdVFeMgJlayLhJA5DCamBT")]
        public static n3.PixelFormat __slot_TdVFeMgJlayLhJA5DCamBT = n1.CompilationHelper.Deserialize<n3.PixelFormat>("R16G16B16A16_Float", false, "KeWf79wIWCVN4a6TzD33r2", "TdVFeMgJlayLhJA5DCamBT");
        [n1.ElementAttribute(TracingId = 339909U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RUKSxa5OovmNiMAHqqS88o", Name = "__slot_RUKSxa5OovmNiMAHqqS88o")]
        public static int __slot_RUKSxa5OovmNiMAHqqS88o = 8;
        [n1.ElementAttribute(TracingId = 340357U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IrIuNPlaYdGLYMoRvh7iKw", Name = "__slot_IrIuNPlaYdGLYMoRvh7iKw")]
        public static n3.PixelFormat __slot_IrIuNPlaYdGLYMoRvh7iKw = n1.CompilationHelper.Deserialize<n3.PixelFormat>("R16G16B16A16_Float", false, "KeWf79wIWCVN4a6TzD33r2", "IrIuNPlaYdGLYMoRvh7iKw");
        [n1.ElementAttribute(TracingId = 340898U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "I5hcSCjKiTKLtE6CHlzBst", Name = "__slot_I5hcSCjKiTKLtE6CHlzBst")]
        public static string __slot_I5hcSCjKiTKLtE6CHlzBst = "Vorticity Texture";
        [n1.ElementAttribute(TracingId = 340916U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MlsXjVO6RqiM2Gl74VKB18", Name = "__slot_MlsXjVO6RqiM2Gl74VKB18")]
        public static string __slot_MlsXjVO6RqiM2Gl74VKB18 = "Divergence Texture";
        [n1.ElementAttribute(TracingId = 340926U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "B4AWfqLVZibNGSkaDtjGul", Name = "__slot_B4AWfqLVZibNGSkaDtjGul")]
        public static string __slot_B4AWfqLVZibNGSkaDtjGul = "Obstacles Gradient Texture";
        [n1.ElementAttribute(TracingId = 340931U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Tz0kIhd8FaXM6rB1jyUcH6", Name = "__slot_Tz0kIhd8FaXM6rB1jyUcH6")]
        public static string __slot_Tz0kIhd8FaXM6rB1jyUcH6 = "Obstacles Velocity Texture";
        [n1.ElementAttribute(TracingId = 340935U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IMstF0TnIo7LT8NttKKfVr", Name = "__slot_IMstF0TnIo7LT8NttKKfVr")]
        public static string __slot_IMstF0TnIo7LT8NttKKfVr = "Pressure Texture";
        [n1.ElementAttribute(TracingId = 340937U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "U6IN1Gr9yDELSAepICFZUF", Name = "__slot_U6IN1Gr9yDELSAepICFZUF")]
        public static string __slot_U6IN1Gr9yDELSAepICFZUF = "Velocity Texture";
        [n1.ElementAttribute(TracingId = 340972U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "AmYyVhT0KewPz7Q4zlFydH", Name = "__slot_AmYyVhT0KewPz7Q4zlFydH")]
        public static string __slot_AmYyVhT0KewPz7Q4zlFydH = "VelocityAdvector";
        [n1.ElementAttribute(TracingId = 340988U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "HokiLup2NqJNQNrf5VrlSW", Name = "__slot_HokiLup2NqJNQNrf5VrlSW")]
        public static string __slot_HokiLup2NqJNQNrf5VrlSW = "Velocity";
        [n1.ElementAttribute(TracingId = 340989U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Ciaqn7IAdUdN1rNfV6TXNb", Name = "__slot_Ciaqn7IAdUdN1rNfV6TXNb")]
        public static string __slot_Ciaqn7IAdUdN1rNfV6TXNb = "Velocity";
        [n1.ElementAttribute(TracingId = 339835U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "HIsTsmxKM0BOkdwvGvTLn2", Name = "Reset Stream")]
        public n16.Subject<bool> Reset_Stream;
        [n1.ElementAttribute(TracingId = 339888U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DL4rHYw1hl5LDSHhUVEdil", Name = "Fluid TimeStep")]
        public float Fluid_TimeStep;
        [n1.ElementAttribute(TracingId = 339897U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VVmGDtoeSZ7LRSnA9bsByn", Name = "Vorticity Strength")]
        public float Vorticity_Strength;
        [n1.ElementAttribute(TracingId = 339904U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TY7aug38SH5Ld0BCxzT4uA", Name = "Resolution")]
        public n6.Int3 Resolution;
        [n1.ElementAttribute(TracingId = 339931U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QLoS6tThhLXNKJJouvnnNu", Name = "Thread Group Count")]
        public n6.Int3 Thread_Group_Count;
        [n1.ElementAttribute(TracingId = 339933U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CbLrKl2ObS3OOBGmOQTdRM", Name = "Thread Group Size")]
        public n6.Int3 Thread_Group_Size;
        [n1.ElementAttribute(TracingId = 339944U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VAFifMjDhBuMxN5cHElx5l", Name = "Jacobi Iterations")]
        public int Jacobi_Iterations;
        [n1.ElementAttribute(TracingId = 340178U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "AM4yJFOAluKPW5dG6GW7GR", Name = "Grid Position")]
        public n6.Vector3 Grid_Position;
        [n1.ElementAttribute(TracingId = 339960U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Ou7ssrvMoB4NwNWc8AFe6q", Name = "Scale")]
        public n6.Vector3 Scale;
        [n1.ElementAttribute(TracingId = 339964U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Rx2kGEeHQ3NOt2s2cHRHrQ", Name = "Transform")]
        public n6.Matrix Transform;
        [n1.ElementAttribute(TracingId = 339972U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UUhVuXl54PYL0ctBVNh0kB", Name = "Transform Inverse")]
        public n6.Matrix Transform_Inverse;
        [n1.ElementAttribute(TracingId = 339976U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IhnGzAqhrFMPt9hfo92jIT", Name = "Scale Inverse")]
        public n6.Vector3 Scale_Inverse;
        [n1.ElementAttribute(TracingId = 340185U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "PIpsARya9p8OPktdIPau2L", Name = "Velocity Modulate")]
        public float Velocity_Modulate;
        [n1.ElementAttribute(TracingId = 340208U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CAwvbXssr5MNEQblEOj1NG", Name = "Components")]
        public n12.Spread<n11.IFluidComponent_I> Components;
        [n1.ElementAttribute(TracingId = 340383U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VTKsGmmQtxcLbawi1BEck5", Name = "Textures")]
        public n18.ImmutableDictionary<string, n4.ISimulationTexture_I>.Builder Textures;
        [n1.ElementAttribute(TracingId = 340947U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "B9pHzR9RSniMQ01Gy0iiEA", Name = "Texture Advectors")]
        public n12.SpreadBuilder<n4.TextureAdvector_C> Texture_Advectors;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.Vector3 __c_FiMMZGo5QcPNYnYFSocTFa = n1.CompilationHelper.Deserialize<n6.Vector3>("1, 1, 1", false, "KeWf79wIWCVN4a6TzD33r2", "FiMMZGo5QcPNYnYFSocTFa");
        [n1.ElementAttribute(TracingId = 340968U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SZoqZUhrMClO2KCqiWOko3", Name = "This", IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __p_SZoqZUhrMClO2KCqiWOko3;
        [n1.ElementAttribute(TracingId = 340211U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NogMnWzCgK6OZUdqEDbVzx", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>> __cache_NogMnWzCgK6OZUdqEDbVzx = null;
        [n1.ElementAttribute(TracingId = 339858U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "AuwmDIrW6K3NaglPoxwFRA", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n19.HoldLatest<bool> __p_AuwmDIrW6K3NaglPoxwFRA;
        [n1.ElementAttribute(TracingId = 340314U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VUheMA8TPHrLfSv0ExM3Tw", Name = "PingPongTexture3D (Fluid)", IsManaged = true, IsAutoGenerated = true)]
        public n4.PingPongTexture3D_Fluid_C __p_VUheMA8TPHrLfSv0ExM3Tw;
        [n1.ElementAttribute(TracingId = 340366U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SA6Ke7VfrRILuYxPLEHlyr", Name = "PingPongTexture3D (Fluid)", IsManaged = true, IsAutoGenerated = true)]
        public n4.PingPongTexture3D_Fluid_C __p_SA6Ke7VfrRILuYxPLEHlyr;
        [n1.ElementAttribute(TracingId = 340819U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VHtUnBpG3BuPi9cyoI9UKn", Name = "Texture3D (Fluid)", IsManaged = true, IsAutoGenerated = true)]
        public n4.Texture3D_Fluid_C __p_VHtUnBpG3BuPi9cyoI9UKn;
        [n1.ElementAttribute(TracingId = 340864U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "AhVq8QtEYyVLCTIwMxsQrk", Name = "Texture3D (Fluid)", IsManaged = true, IsAutoGenerated = true)]
        public n4.Texture3D_Fluid_C __p_AhVq8QtEYyVLCTIwMxsQrk;
        [n1.ElementAttribute(TracingId = 340875U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RTqQN4GTHyIOzHV2FuCood", Name = "Texture3D (Fluid)", IsManaged = true, IsAutoGenerated = true)]
        public n4.Texture3D_Fluid_C __p_RTqQN4GTHyIOzHV2FuCood;
        [n1.ElementAttribute(TracingId = 340885U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ARPX7rr18m6P0OghJVlUQY", Name = "Texture3D (Fluid)", IsManaged = true, IsAutoGenerated = true)]
        public n4.Texture3D_Fluid_C __p_ARPX7rr18m6P0OghJVlUQY;
        [n1.ElementAttribute(TracingId = 340975U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Ur0k3L387WRO8bHEV7sTop", Name = "TextureAdvector", IsManaged = true, IsAutoGenerated = true)]
        public n4.TextureAdvector_C __p_Ur0k3L387WRO8bHEV7sTop;
        [n1.ElementAttribute(TracingId = 340385U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GXJZqiDhtoAOHoWyRiZn7B", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<n4.PingPongTexture3D_Fluid_C, n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple> __cache_GXJZqiDhtoAOHoWyRiZn7B = null;
        [n1.ElementAttribute(TracingId = 340440U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MK9vRx3X1lfMZVFF2h5Ba6", Name = "__slot_MK9vRx3X1lfMZVFF2h5Ba6")]
        public static string __slot_MK9vRx3X1lfMZVFF2h5Ba6 = "Velocity";
        [n1.ElementAttribute(TracingId = 340479U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IwV1Kndha93N3kzV79Wb8K", Name = "__slot_IwV1Kndha93N3kzV79Wb8K")]
        public static string __slot_IwV1Kndha93N3kzV79Wb8K = "Pressure";
        [n1.ElementAttribute(TracingId = 340502U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "V7e4npfn4ZGLsJmMJOq0VQ", Name = "__slot_V7e4npfn4ZGLsJmMJOq0VQ")]
        public static string __slot_V7e4npfn4ZGLsJmMJOq0VQ = "Vorticity";
        [n1.ElementAttribute(TracingId = 340518U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Ug6rXv9cEUTMv4bU6BKSao", Name = "__slot_Ug6rXv9cEUTMv4bU6BKSao")]
        public static string __slot_Ug6rXv9cEUTMv4bU6BKSao = "Divergence";
        [n1.ElementAttribute(TracingId = 340539U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "V7iyStUqqYAOrYqOPGSnxo", Name = "__slot_V7iyStUqqYAOrYqOPGSnxo")]
        public static string __slot_V7iyStUqqYAOrYqOPGSnxo = "ObstaclesGradient";
        [n1.ElementAttribute(TracingId = 340551U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GrIm1qqEimOLVADk4APXHJ", Name = "__slot_GrIm1qqEimOLVADk4APXHJ")]
        public static string __slot_GrIm1qqEimOLVADk4APXHJ = "ObstaclesVelocity";
        static FluidContext_C()
        {
        }

        public FluidContext_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FluidContext_C(FluidContext_C other): base(other)
        {
            this.Reset_Stream = other.Reset_Stream;
            this.Fluid_TimeStep = other.Fluid_TimeStep;
            this.Vorticity_Strength = other.Vorticity_Strength;
            this.Resolution = other.Resolution;
            this.Thread_Group_Count = other.Thread_Group_Count;
            this.Thread_Group_Size = other.Thread_Group_Size;
            this.Jacobi_Iterations = other.Jacobi_Iterations;
            this.Grid_Position = other.Grid_Position;
            this.Scale = other.Scale;
            this.Transform = other.Transform;
            this.Transform_Inverse = other.Transform_Inverse;
            this.Scale_Inverse = other.Scale_Inverse;
            this.Velocity_Modulate = other.Velocity_Modulate;
            this.Components = other.Components;
            this.Textures = other.Textures;
            this.Texture_Advectors = other.Texture_Advectors;
            this.__p_SZoqZUhrMClO2KCqiWOko3 = other.__p_SZoqZUhrMClO2KCqiWOko3;
            this.__cache_NogMnWzCgK6OZUdqEDbVzx = other.__cache_NogMnWzCgK6OZUdqEDbVzx;
            this.__p_AuwmDIrW6K3NaglPoxwFRA = other.__p_AuwmDIrW6K3NaglPoxwFRA;
            this.__p_VUheMA8TPHrLfSv0ExM3Tw = other.__p_VUheMA8TPHrLfSv0ExM3Tw;
            this.__p_SA6Ke7VfrRILuYxPLEHlyr = other.__p_SA6Ke7VfrRILuYxPLEHlyr;
            this.__p_VHtUnBpG3BuPi9cyoI9UKn = other.__p_VHtUnBpG3BuPi9cyoI9UKn;
            this.__p_AhVq8QtEYyVLCTIwMxsQrk = other.__p_AhVq8QtEYyVLCTIwMxsQrk;
            this.__p_RTqQN4GTHyIOzHV2FuCood = other.__p_RTqQN4GTHyIOzHV2FuCood;
            this.__p_ARPX7rr18m6P0OghJVlUQY = other.__p_ARPX7rr18m6P0OghJVlUQY;
            this.__p_Ur0k3L387WRO8bHEV7sTop = other.__p_Ur0k3L387WRO8bHEV7sTop;
            this.__cache_GXJZqiDhtoAOHoWyRiZn7B = other.__cache_GXJZqiDhtoAOHoWyRiZn7B;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Reset_Stream", in Reset_Stream), n1.CompilationHelper.GetValueOrExisting(values, "Fluid_TimeStep", in Fluid_TimeStep), n1.CompilationHelper.GetValueOrExisting(values, "Vorticity_Strength", in Vorticity_Strength), n1.CompilationHelper.GetValueOrExisting(values, "Resolution", in Resolution), n1.CompilationHelper.GetValueOrExisting(values, "Thread_Group_Count", in Thread_Group_Count), n1.CompilationHelper.GetValueOrExisting(values, "Thread_Group_Size", in Thread_Group_Size), n1.CompilationHelper.GetValueOrExisting(values, "Jacobi_Iterations", in Jacobi_Iterations), n1.CompilationHelper.GetValueOrExisting(values, "Grid_Position", in Grid_Position), n1.CompilationHelper.GetValueOrExisting(values, "Scale", in Scale), n1.CompilationHelper.GetValueOrExisting(values, "Transform", in Transform), n1.CompilationHelper.GetValueOrExisting(values, "Transform_Inverse", in Transform_Inverse), n1.CompilationHelper.GetValueOrExisting(values, "Scale_Inverse", in Scale_Inverse), n1.CompilationHelper.GetValueOrExisting(values, "Velocity_Modulate", in Velocity_Modulate), n1.CompilationHelper.GetValueOrExisting(values, "Components", in Components), n1.CompilationHelper.GetValueOrExisting(values, "Textures", in Textures), n1.CompilationHelper.GetValueOrExisting(values, "Texture_Advectors", in Texture_Advectors), n1.CompilationHelper.GetValueOrExisting(values, "__p_SZoqZUhrMClO2KCqiWOko3", in __p_SZoqZUhrMClO2KCqiWOko3), n1.CompilationHelper.GetValueOrExisting(values, "__cache_NogMnWzCgK6OZUdqEDbVzx", in __cache_NogMnWzCgK6OZUdqEDbVzx), n1.CompilationHelper.GetValueOrExisting(values, "__p_AuwmDIrW6K3NaglPoxwFRA", in __p_AuwmDIrW6K3NaglPoxwFRA), n1.CompilationHelper.GetValueOrExisting(values, "__p_VUheMA8TPHrLfSv0ExM3Tw", in __p_VUheMA8TPHrLfSv0ExM3Tw), n1.CompilationHelper.GetValueOrExisting(values, "__p_SA6Ke7VfrRILuYxPLEHlyr", in __p_SA6Ke7VfrRILuYxPLEHlyr), n1.CompilationHelper.GetValueOrExisting(values, "__p_VHtUnBpG3BuPi9cyoI9UKn", in __p_VHtUnBpG3BuPi9cyoI9UKn), n1.CompilationHelper.GetValueOrExisting(values, "__p_AhVq8QtEYyVLCTIwMxsQrk", in __p_AhVq8QtEYyVLCTIwMxsQrk), n1.CompilationHelper.GetValueOrExisting(values, "__p_RTqQN4GTHyIOzHV2FuCood", in __p_RTqQN4GTHyIOzHV2FuCood), n1.CompilationHelper.GetValueOrExisting(values, "__p_ARPX7rr18m6P0OghJVlUQY", in __p_ARPX7rr18m6P0OghJVlUQY), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ur0k3L387WRO8bHEV7sTop", in __p_Ur0k3L387WRO8bHEV7sTop), n1.CompilationHelper.GetValueOrExisting(values, "__cache_GXJZqiDhtoAOHoWyRiZn7B", in __cache_GXJZqiDhtoAOHoWyRiZn7B));
        }

        internal FluidContext_C __WITH__(n16.Subject<bool> Reset_Stream, float Fluid_TimeStep, float Vorticity_Strength, n6.Int3 Resolution, n6.Int3 Thread_Group_Count, n6.Int3 Thread_Group_Size, int Jacobi_Iterations, n6.Vector3 Grid_Position, n6.Vector3 Scale, n6.Matrix Transform, n6.Matrix Transform_Inverse, n6.Vector3 Scale_Inverse, float Velocity_Modulate, n12.Spread<n11.IFluidComponent_I> Components, n18.ImmutableDictionary<string, n4.ISimulationTexture_I>.Builder Textures, n12.SpreadBuilder<n4.TextureAdvector_C> Texture_Advectors, n2.Object __p_SZoqZUhrMClO2KCqiWOko3, n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>> __cache_NogMnWzCgK6OZUdqEDbVzx, n19.HoldLatest<bool> __p_AuwmDIrW6K3NaglPoxwFRA, n4.PingPongTexture3D_Fluid_C __p_VUheMA8TPHrLfSv0ExM3Tw, n4.PingPongTexture3D_Fluid_C __p_SA6Ke7VfrRILuYxPLEHlyr, n4.Texture3D_Fluid_C __p_VHtUnBpG3BuPi9cyoI9UKn, n4.Texture3D_Fluid_C __p_AhVq8QtEYyVLCTIwMxsQrk, n4.Texture3D_Fluid_C __p_RTqQN4GTHyIOzHV2FuCood, n4.Texture3D_Fluid_C __p_ARPX7rr18m6P0OghJVlUQY, n4.TextureAdvector_C __p_Ur0k3L387WRO8bHEV7sTop, n13.Manager<n2.ValueTuple<n4.PingPongTexture3D_Fluid_C, n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple> __cache_GXJZqiDhtoAOHoWyRiZn7B)
        {
            n4.FluidContext_C that_0 = this;
            this.Reset_Stream = Reset_Stream;
            this.Fluid_TimeStep = Fluid_TimeStep;
            this.Vorticity_Strength = Vorticity_Strength;
            this.Resolution = Resolution;
            this.Thread_Group_Count = Thread_Group_Count;
            this.Thread_Group_Size = Thread_Group_Size;
            this.Jacobi_Iterations = Jacobi_Iterations;
            this.Grid_Position = Grid_Position;
            this.Scale = Scale;
            this.Transform = Transform;
            this.Transform_Inverse = Transform_Inverse;
            this.Scale_Inverse = Scale_Inverse;
            this.Velocity_Modulate = Velocity_Modulate;
            this.Components = Components;
            this.Textures = Textures;
            this.Texture_Advectors = Texture_Advectors;
            this.__p_SZoqZUhrMClO2KCqiWOko3 = __p_SZoqZUhrMClO2KCqiWOko3;
            this.__cache_NogMnWzCgK6OZUdqEDbVzx = __cache_NogMnWzCgK6OZUdqEDbVzx;
            this.__p_AuwmDIrW6K3NaglPoxwFRA = __p_AuwmDIrW6K3NaglPoxwFRA;
            this.__p_VUheMA8TPHrLfSv0ExM3Tw = __p_VUheMA8TPHrLfSv0ExM3Tw;
            this.__p_SA6Ke7VfrRILuYxPLEHlyr = __p_SA6Ke7VfrRILuYxPLEHlyr;
            this.__p_VHtUnBpG3BuPi9cyoI9UKn = __p_VHtUnBpG3BuPi9cyoI9UKn;
            this.__p_AhVq8QtEYyVLCTIwMxsQrk = __p_AhVq8QtEYyVLCTIwMxsQrk;
            this.__p_RTqQN4GTHyIOzHV2FuCood = __p_RTqQN4GTHyIOzHV2FuCood;
            this.__p_ARPX7rr18m6P0OghJVlUQY = __p_ARPX7rr18m6P0OghJVlUQY;
            this.__p_Ur0k3L387WRO8bHEV7sTop = __p_Ur0k3L387WRO8bHEV7sTop;
            this.__cache_GXJZqiDhtoAOHoWyRiZn7B = __cache_GXJZqiDhtoAOHoWyRiZn7B;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 341430U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MbnxuqwYLx3Lt60BnWYJoT", Name = "AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT")]
    [n2.SerializableAttribute]
    public class AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT Create(n1.NodeContext Node_Context)
        {
            var instance = new AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT CreateDefault()
        {
            var instance = new AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT Update(n4.FluidContext_C Context_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n35.GraphicsRendererGroup Layer_Out)
        {
            float __pad_M6L8ShX8kPqNoxxdh5ENvz_0 = __slot_M6L8ShX8kPqNoxxdh5ENvz;
            int __pad_IkbxpGHkNcCMxd6IMNmNEc_1 = __slot_IkbxpGHkNcCMxd6IMNmNEc;
            var Output_4 = Context_In.GetDispatch(Thread_Group_Count_Out: out n6.Int3 Thread_Group_Count_2, Thread_Group_Size_Out: out n6.Int3 Thread_Group_Size_3);
            var Output_6 = Context_In.GetTextureAdvectors(Texture_Advectors_Out: out n12.Spread<n4.TextureAdvector_C> Texture_Advectors_5);
            var Output_8 = Context_In.GetResolutionVector(Resolution_Out: out n6.Vector3 Resolution_7);
            var Output_10 = Output_8.GetFluidTimeStep(Fluid_TimeStep_Out: out float Fluid_TimeStep_9);
            var Output_12 = Context_In.GetGridPosition(Grid_Position_Out: out n6.Vector3 Grid_Position_11);
            var Output_14 = this.__p_BdEHEE2jB97QX4BFM6vJgJ.Update<n31.__AdaptiveImplementations__KeWf79wIWCVN4a6TzD33r2>(Value_In: Grid_Position_11, Result_Out: out n6.Vector3 Result_13);
            var manager_48 = this.__loop_IqE3po7CZCEQMfnibn1Wu3 ?? new n34.ImmutableLifetimeManager();
            var iterator_49 = manager_48.GetIterator(__GetContext__());
            var builder_50 = n5.CollectionBuilders.GetBuilder(this.__cp_LfHVnQ6kBOfQCYsNTXeVf2, 16);
            n12.Spread<n33.IGraphicsRendererBase> output_51;
            try
            {
                var i_17 = 0;
                foreach (var item_15 in n5.CollectionExtensions.AsSpan(Texture_Advectors_5))
                {
                    var splicer_16 = item_15;
                    var i_local_18 = i_17;
                    __MQ9k4Zm0jM2MQueweTOdCo state_19;
                    if (!iterator_49.MoveNext(out state_19))
                    {
                        iterator_49.Add(state_19 = new __MQ9k4Zm0jM2MQueweTOdCo(__GetContext__(), n1.VLObject.NewIdentity()));
                        var node_20 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "DirectDispatcher", "Stride.Rendering.Advanced");
                        state_19.__p_Ha5qdtRkbJjLyV4tXaitgD = node_20;
                        var node_21 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Fluid3DAdvectTextureShader (Internal)", "Stride.Rendering.ComputeShaders");
                        state_19.__p_DNrPjF6eo7PNM9JLWGLCio = node_21;
                    }

                    var Output_28 = splicer_16.Split(Name_Out: out string Name_22, VectorField_Texture_Id_Out: out string VectorField_Texture_Id_23, Target_Texture_Id_Out: out string Target_Texture_Id_24, Modulate_Out: out float Modulate_25, Forward_Out: out float Forward_26, Enabled_Out: out bool Enabled_27);
                    var Output_34 = Output_6.GetTextureWithName(Texture_Name_In: VectorField_Texture_Id_23, Texture_Read_Out: out n27.Texture Texture_Read_29, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_30, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_31, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_32, Found_Out: out bool Found_33);
                    var Output_40 = Output_34.GetTextureWithName(Texture_Name_In: Target_Texture_Id_24, Texture_Read_Out: out n27.Texture Texture_Read_35, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_36, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_37, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_38, Found_Out: out bool Found_39);
                    var Output_41 = Enabled_In && Enabled_27;
                    n1.CompilationHelper.WritePin(state_19.__p_Ha5qdtRkbJjLyV4tXaitgD.Inputs[0], ref Thread_Group_Count_2);
                    n1.CompilationHelper.ReadPin(state_19.__p_Ha5qdtRkbJjLyV4tXaitgD.Outputs[0], out n32.IComputeEffectDispatcher out_42);
                    n1.CompilationHelper.WritePin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Inputs[0], ref out_42);
                    n1.CompilationHelper.WritePin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Inputs[1], ref Thread_Group_Size_3);
                    n1.CompilationHelper.WritePin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Inputs[3], ref Texture_Read_29);
                    n1.CompilationHelper.WritePin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Inputs[4], ref Texture_Read_35);
                    n1.CompilationHelper.WritePin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Inputs[5], ref Texture_ReadWrite_37);
                    n1.CompilationHelper.WritePin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Inputs[6], ref Resolution_7);
                    n1.CompilationHelper.WritePin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Inputs[7], ref Fluid_TimeStep_9);
                    n1.CompilationHelper.WritePin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Inputs[8], ref Modulate_25);
                    n1.CompilationHelper.WritePin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Inputs[9], ref Forward_26);
                    n1.CompilationHelper.WritePin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Inputs[10], ref Result_13);
                    n1.CompilationHelper.WritePin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Inputs[11], ref __pad_IkbxpGHkNcCMxd6IMNmNEc_1);
                    n1.CompilationHelper.WritePin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Inputs[12], ref __pad_M6L8ShX8kPqNoxxdh5ENvz_0);
                    n1.CompilationHelper.WritePin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Inputs[13], ref Output_41);
                    n1.CompilationHelper.ReadPin(state_19.__p_DNrPjF6eo7PNM9JLWGLCio.Outputs[0], out n33.IGraphicsRendererBase out_43);
                    n33.IGraphicsRendererBase __auto_44;
                    if (Output_41)
                    {
                        var Output_47 = Output_40.SwapPingPongTextureWithName(Texture_Name_In: Target_Texture_Id_24, Found_Out: out bool Found_46);
                        __auto_44 = out_43;
                    }
                    else
                    {
                        __auto_44 = out_43;
                    }

                    if (state_19.__GetContext__().IsImmutable)
                        state_19 = state_19.__p_Ha5qdtRkbJjLyV4tXaitgD != state_19.__p_Ha5qdtRkbJjLyV4tXaitgD || state_19.__p_DNrPjF6eo7PNM9JLWGLCio != state_19.__p_DNrPjF6eo7PNM9JLWGLCio ? new __MQ9k4Zm0jM2MQueweTOdCo(state_19)
                        {__p_Ha5qdtRkbJjLyV4tXaitgD = state_19.__p_Ha5qdtRkbJjLyV4tXaitgD, __p_DNrPjF6eo7PNM9JLWGLCio = state_19.__p_DNrPjF6eo7PNM9JLWGLCio} : state_19;
                    else
                    {
                        state_19.__p_Ha5qdtRkbJjLyV4tXaitgD = state_19.__p_Ha5qdtRkbJjLyV4tXaitgD;
                        state_19.__p_DNrPjF6eo7PNM9JLWGLCio = state_19.__p_DNrPjF6eo7PNM9JLWGLCio;
                    }

                    iterator_49.Update(state_19);
                    builder_50.Add(__auto_44);
                    i_17++;
                }
            }
            finally
            {
                manager_48 = iterator_49.Commit();
                output_51 = builder_50.Commit();
            }

            bool Update_52 = true;
            var Output_53 = this.__p_DJrmM3fygeFPOR712zOiyy;
            if (Update_52)
            {
                n35.GraphicsRendererGroup Input__this__54 = this.__p_DJrmM3fygeFPOR712zOiyy;
                Input__this__54.Update(input: output_51);
                Output_53 = Input__this__54;
            }

            Layer_Out = Output_53;
            n4.AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT that_55 = this;
            if (this.__GetContext__().IsImmutable)
                that_55 = Output_14 != this.__p_BdEHEE2jB97QX4BFM6vJgJ || manager_48 != this.__loop_IqE3po7CZCEQMfnibn1Wu3 || output_51 != this.__cp_LfHVnQ6kBOfQCYsNTXeVf2 || Output_53 != this.__p_DJrmM3fygeFPOR712zOiyy ? new AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT(this)
                {__p_BdEHEE2jB97QX4BFM6vJgJ = Output_14, __loop_IqE3po7CZCEQMfnibn1Wu3 = manager_48, __cp_LfHVnQ6kBOfQCYsNTXeVf2 = output_51, __p_DJrmM3fygeFPOR712zOiyy = Output_53} : that_55;
            else
            {
                this.__p_BdEHEE2jB97QX4BFM6vJgJ = Output_14;
                this.__loop_IqE3po7CZCEQMfnibn1Wu3 = manager_48;
                this.__cp_LfHVnQ6kBOfQCYsNTXeVf2 = output_51;
                this.__p_DJrmM3fygeFPOR712zOiyy = Output_53;
            }

            return that_55;
        }

        public n4.AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "BdEHEE2jB97QX4BFM6vJgJ", 341489U);
            var Output_1 = n36.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector3>.Create<n31.__AdaptiveImplementations__KeWf79wIWCVN4a6TzD33r2>(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "DJrmM3fygeFPOR712zOiyy", 341642U);
            n37._Operations_.Create(Node_Context: Node_Context_2, Output_Out: out n35.GraphicsRendererGroup Output_3);
            n4.AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT that_4 = this;
            this.__cp_LfHVnQ6kBOfQCYsNTXeVf2 = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__p_BdEHEE2jB97QX4BFM6vJgJ = Output_1;
            this.__p_DJrmM3fygeFPOR712zOiyy = Output_3;
            this.__loop_IqE3po7CZCEQMfnibn1Wu3 = default(n34.ImmutableLifetimeManager);
            return that_4;
        }

        public n4.AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT __CreateDefault__()
        {
            n4.AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT that_0 = this;
            this.__cp_LfHVnQ6kBOfQCYsNTXeVf2 = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__p_BdEHEE2jB97QX4BFM6vJgJ = n36.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector3>.CreateDefault<n31.__AdaptiveImplementations__KeWf79wIWCVN4a6TzD33r2>();
            this.__loop_IqE3po7CZCEQMfnibn1Wu3 = default(n34.ImmutableLifetimeManager);
            this.__p_DJrmM3fygeFPOR712zOiyy = default(n35.GraphicsRendererGroup);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_BdEHEE2jB97QX4BFM6vJgJ);
            n1.CompilationHelper.SafeDispose(this.__loop_IqE3po7CZCEQMfnibn1Wu3);
            n1.CompilationHelper.SafeDispose(this.__p_DJrmM3fygeFPOR712zOiyy);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 341478U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IkbxpGHkNcCMxd6IMNmNEc", Name = "__slot_IkbxpGHkNcCMxd6IMNmNEc")]
        public static int __slot_IkbxpGHkNcCMxd6IMNmNEc = 5;
        [n1.ElementAttribute(TracingId = 341479U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "M6L8ShX8kPqNoxxdh5ENvz", Name = "__slot_M6L8ShX8kPqNoxxdh5ENvz")]
        public static float __slot_M6L8ShX8kPqNoxxdh5ENvz = 1F;
        [n1.ElementAttribute(TracingId = 341489U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BdEHEE2jB97QX4BFM6vJgJ", Name = "FrameDifference", IsManaged = true, IsAutoGenerated = true)]
        public n36.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector3> __p_BdEHEE2jB97QX4BFM6vJgJ;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n34.ImmutableLifetimeManager __loop_IqE3po7CZCEQMfnibn1Wu3;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n33.IGraphicsRendererBase> __cp_LfHVnQ6kBOfQCYsNTXeVf2;
        [n1.ElementAttribute(TracingId = 341642U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DJrmM3fygeFPOR712zOiyy", Name = "Group (Spectral)", IsManaged = true, IsAutoGenerated = true)]
        public n35.GraphicsRendererGroup __p_DJrmM3fygeFPOR712zOiyy;
        static AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT()
        {
        }

        public AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT(AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT other): base(other)
        {
            this.__p_BdEHEE2jB97QX4BFM6vJgJ = other.__p_BdEHEE2jB97QX4BFM6vJgJ;
            this.__loop_IqE3po7CZCEQMfnibn1Wu3 = other.__loop_IqE3po7CZCEQMfnibn1Wu3;
            this.__cp_LfHVnQ6kBOfQCYsNTXeVf2 = other.__cp_LfHVnQ6kBOfQCYsNTXeVf2;
            this.__p_DJrmM3fygeFPOR712zOiyy = other.__p_DJrmM3fygeFPOR712zOiyy;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BdEHEE2jB97QX4BFM6vJgJ", in __p_BdEHEE2jB97QX4BFM6vJgJ), n1.CompilationHelper.GetValueOrExisting(values, "__loop_IqE3po7CZCEQMfnibn1Wu3", in __loop_IqE3po7CZCEQMfnibn1Wu3), n1.CompilationHelper.GetValueOrExisting(values, "__cp_LfHVnQ6kBOfQCYsNTXeVf2", in __cp_LfHVnQ6kBOfQCYsNTXeVf2), n1.CompilationHelper.GetValueOrExisting(values, "__p_DJrmM3fygeFPOR712zOiyy", in __p_DJrmM3fygeFPOR712zOiyy));
        }

        internal AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT __WITH__(n36.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector3> __p_BdEHEE2jB97QX4BFM6vJgJ, n34.ImmutableLifetimeManager __loop_IqE3po7CZCEQMfnibn1Wu3, n12.Spread<n33.IGraphicsRendererBase> __cp_LfHVnQ6kBOfQCYsNTXeVf2, n35.GraphicsRendererGroup __p_DJrmM3fygeFPOR712zOiyy)
        {
            n4.AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_BdEHEE2jB97QX4BFM6vJgJ != this.__p_BdEHEE2jB97QX4BFM6vJgJ || __loop_IqE3po7CZCEQMfnibn1Wu3 != this.__loop_IqE3po7CZCEQMfnibn1Wu3 || __cp_LfHVnQ6kBOfQCYsNTXeVf2 != this.__cp_LfHVnQ6kBOfQCYsNTXeVf2 || __p_DJrmM3fygeFPOR712zOiyy != this.__p_DJrmM3fygeFPOR712zOiyy ? new AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT(this)
                {__p_BdEHEE2jB97QX4BFM6vJgJ = __p_BdEHEE2jB97QX4BFM6vJgJ, __loop_IqE3po7CZCEQMfnibn1Wu3 = __loop_IqE3po7CZCEQMfnibn1Wu3, __cp_LfHVnQ6kBOfQCYsNTXeVf2 = __cp_LfHVnQ6kBOfQCYsNTXeVf2, __p_DJrmM3fygeFPOR712zOiyy = __p_DJrmM3fygeFPOR712zOiyy} : that_0;
            else
            {
                this.__p_BdEHEE2jB97QX4BFM6vJgJ = __p_BdEHEE2jB97QX4BFM6vJgJ;
                this.__loop_IqE3po7CZCEQMfnibn1Wu3 = __loop_IqE3po7CZCEQMfnibn1Wu3;
                this.__cp_LfHVnQ6kBOfQCYsNTXeVf2 = __cp_LfHVnQ6kBOfQCYsNTXeVf2;
                this.__p_DJrmM3fygeFPOR712zOiyy = __p_DJrmM3fygeFPOR712zOiyy;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MQ9k4Zm0jM2MQueweTOdCo", Name = "__MQ9k4Zm0jM2MQueweTOdCo")]
        [n2.SerializableAttribute]
        public class __MQ9k4Zm0jM2MQueweTOdCo : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Ha5qdtRkbJjLyV4tXaitgD);
                n1.CompilationHelper.SafeDispose(this.__p_DNrPjF6eo7PNM9JLWGLCio);
                return;
            }

            [n1.ElementAttribute(TracingId = 341546U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Ha5qdtRkbJjLyV4tXaitgD", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
            public n1.IVLNode __p_Ha5qdtRkbJjLyV4tXaitgD;
            [n1.ElementAttribute(TracingId = 341551U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DNrPjF6eo7PNM9JLWGLCio", Name = "Fluid3DAdvectTextureShader", IsManaged = true, IsAutoGenerated = true, NodeName = "Fluid3DAdvectTextureShader (Internal)", NodeCategory = "Stride.Rendering.ComputeShaders")]
            public n1.IVLNode __p_DNrPjF6eo7PNM9JLWGLCio;
            public __MQ9k4Zm0jM2MQueweTOdCo(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MQ9k4Zm0jM2MQueweTOdCo(__MQ9k4Zm0jM2MQueweTOdCo other): base(other)
            {
                this.__p_Ha5qdtRkbJjLyV4tXaitgD = other.__p_Ha5qdtRkbJjLyV4tXaitgD;
                this.__p_DNrPjF6eo7PNM9JLWGLCio = other.__p_DNrPjF6eo7PNM9JLWGLCio;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Ha5qdtRkbJjLyV4tXaitgD", in __p_Ha5qdtRkbJjLyV4tXaitgD), n1.CompilationHelper.GetValueOrExisting(values, "__p_DNrPjF6eo7PNM9JLWGLCio", in __p_DNrPjF6eo7PNM9JLWGLCio));
            }

            internal __MQ9k4Zm0jM2MQueweTOdCo __WITH__(n1.IVLNode __p_Ha5qdtRkbJjLyV4tXaitgD, n1.IVLNode __p_DNrPjF6eo7PNM9JLWGLCio)
            {
                __MQ9k4Zm0jM2MQueweTOdCo that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Ha5qdtRkbJjLyV4tXaitgD != this.__p_Ha5qdtRkbJjLyV4tXaitgD || __p_DNrPjF6eo7PNM9JLWGLCio != this.__p_DNrPjF6eo7PNM9JLWGLCio ? new __MQ9k4Zm0jM2MQueweTOdCo(this)
                    {__p_Ha5qdtRkbJjLyV4tXaitgD = __p_Ha5qdtRkbJjLyV4tXaitgD, __p_DNrPjF6eo7PNM9JLWGLCio = __p_DNrPjF6eo7PNM9JLWGLCio} : that_0;
                else
                {
                    this.__p_Ha5qdtRkbJjLyV4tXaitgD = __p_Ha5qdtRkbJjLyV4tXaitgD;
                    this.__p_DNrPjF6eo7PNM9JLWGLCio = __p_DNrPjF6eo7PNM9JLWGLCio;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 341735U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QB31UUFJVMJOy4MkIkqs7r", Name = "VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r")]
    [n2.SerializableAttribute]
    public class VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r Create(n1.NodeContext Node_Context)
        {
            var instance = new VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r CreateDefault()
        {
            var instance = new VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r Update(n4.FluidContext_C Context_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n35.GraphicsRendererGroup Layer_Out)
        {
            var Output_1 = this.__p_LX8EuK8Itw0NkOUUl35Yme.Update(Context_In: Context_In, Enabled_In: Enabled_In, Layer_Out: out n33.IGraphicsRendererBase Layer_0);
            var Output_3 = this.__p_URMvKT5CawZMec6OLHZ34h.Update(Context_In: Context_In, Enabled_In: Enabled_In, Layer_Out: out n33.IGraphicsRendererBase Layer_2);
            var builder_4 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW, 2);
            builder_4.Add(Layer_0);
            builder_4.Add(Layer_2);
            var __pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW_5 = builder_4.Commit();
            var State_Output_7 = this.__p_MHeln6YbBGkQclEJu2iLlW.Update(Input_In: __pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW_5, Output_Out: out n35.GraphicsRendererGroup Output_6);
            Layer_Out = Output_6;
            n4.VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r that_8 = this;
            if (this.__GetContext__().IsImmutable)
                that_8 = Output_1 != this.__p_LX8EuK8Itw0NkOUUl35Yme || Output_3 != this.__p_URMvKT5CawZMec6OLHZ34h || __pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW_5 != this.__pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW || State_Output_7 != this.__p_MHeln6YbBGkQclEJu2iLlW ? new VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r(this)
                {__p_LX8EuK8Itw0NkOUUl35Yme = Output_1, __p_URMvKT5CawZMec6OLHZ34h = Output_3, __pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW = __pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW_5, __p_MHeln6YbBGkQclEJu2iLlW = State_Output_7} : that_8;
            else
            {
                this.__p_LX8EuK8Itw0NkOUUl35Yme = Output_1;
                this.__p_URMvKT5CawZMec6OLHZ34h = Output_3;
                this.__pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW = __pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW_5;
                this.__p_MHeln6YbBGkQclEJu2iLlW = State_Output_7;
            }

            return that_8;
        }

        public n4.VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "LX8EuK8Itw0NkOUUl35Yme", 341738U);
            var Output_1 = n4.Vorticity_Ppp0N64qyqpO7EOUO2XF7C.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "URMvKT5CawZMec6OLHZ34h", 341748U);
            var Output_3 = n4.Confinement_FdYIJnpqQivNiWakJ20DmS.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "MHeln6YbBGkQclEJu2iLlW", 341755U);
            var Output_5 = n38.Group_JjpUJ7D6yd9L6tZwkMXdAR.Create(Node_Context: Node_Context_4);
            n4.VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r that_6 = this;
            this.__pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__p_LX8EuK8Itw0NkOUUl35Yme = Output_1;
            this.__p_URMvKT5CawZMec6OLHZ34h = Output_3;
            this.__p_MHeln6YbBGkQclEJu2iLlW = Output_5;
            return that_6;
        }

        public n4.VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r __CreateDefault__()
        {
            n4.VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r that_0 = this;
            this.__pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__p_LX8EuK8Itw0NkOUUl35Yme = n4.Vorticity_Ppp0N64qyqpO7EOUO2XF7C.CreateDefault();
            this.__p_URMvKT5CawZMec6OLHZ34h = n4.Confinement_FdYIJnpqQivNiWakJ20DmS.CreateDefault();
            this.__p_MHeln6YbBGkQclEJu2iLlW = n38.Group_JjpUJ7D6yd9L6tZwkMXdAR.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_LX8EuK8Itw0NkOUUl35Yme);
            n1.CompilationHelper.SafeDispose(this.__p_URMvKT5CawZMec6OLHZ34h);
            n1.CompilationHelper.SafeDispose(this.__p_MHeln6YbBGkQclEJu2iLlW);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 341738U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LX8EuK8Itw0NkOUUl35Yme", Name = "Vorticity", IsManaged = true, IsAutoGenerated = true)]
        public n4.Vorticity_Ppp0N64qyqpO7EOUO2XF7C __p_LX8EuK8Itw0NkOUUl35Yme;
        [n1.ElementAttribute(TracingId = 341748U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "URMvKT5CawZMec6OLHZ34h", Name = "Confinement", IsManaged = true, IsAutoGenerated = true)]
        public n4.Confinement_FdYIJnpqQivNiWakJ20DmS __p_URMvKT5CawZMec6OLHZ34h;
        [n1.ElementAttribute(TracingId = 341755U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MHeln6YbBGkQclEJu2iLlW", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n38.Group_JjpUJ7D6yd9L6tZwkMXdAR __p_MHeln6YbBGkQclEJu2iLlW;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n33.IGraphicsRendererBase> __pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW = default(n12.Spread<n33.IGraphicsRendererBase>);
        public VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r(VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r other): base(other)
        {
            this.__p_LX8EuK8Itw0NkOUUl35Yme = other.__p_LX8EuK8Itw0NkOUUl35Yme;
            this.__p_URMvKT5CawZMec6OLHZ34h = other.__p_URMvKT5CawZMec6OLHZ34h;
            this.__p_MHeln6YbBGkQclEJu2iLlW = other.__p_MHeln6YbBGkQclEJu2iLlW;
            this.__pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW = other.__pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LX8EuK8Itw0NkOUUl35Yme", in __p_LX8EuK8Itw0NkOUUl35Yme), n1.CompilationHelper.GetValueOrExisting(values, "__p_URMvKT5CawZMec6OLHZ34h", in __p_URMvKT5CawZMec6OLHZ34h), n1.CompilationHelper.GetValueOrExisting(values, "__p_MHeln6YbBGkQclEJu2iLlW", in __p_MHeln6YbBGkQclEJu2iLlW), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW", in __pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW));
        }

        internal VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r __WITH__(n4.Vorticity_Ppp0N64qyqpO7EOUO2XF7C __p_LX8EuK8Itw0NkOUUl35Yme, n4.Confinement_FdYIJnpqQivNiWakJ20DmS __p_URMvKT5CawZMec6OLHZ34h, n38.Group_JjpUJ7D6yd9L6tZwkMXdAR __p_MHeln6YbBGkQclEJu2iLlW, n12.Spread<n33.IGraphicsRendererBase> __pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW)
        {
            n4.VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_LX8EuK8Itw0NkOUUl35Yme != this.__p_LX8EuK8Itw0NkOUUl35Yme || __p_URMvKT5CawZMec6OLHZ34h != this.__p_URMvKT5CawZMec6OLHZ34h || __p_MHeln6YbBGkQclEJu2iLlW != this.__p_MHeln6YbBGkQclEJu2iLlW || __pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW != this.__pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW ? new VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r(this)
                {__p_LX8EuK8Itw0NkOUUl35Yme = __p_LX8EuK8Itw0NkOUUl35Yme, __p_URMvKT5CawZMec6OLHZ34h = __p_URMvKT5CawZMec6OLHZ34h, __p_MHeln6YbBGkQclEJu2iLlW = __p_MHeln6YbBGkQclEJu2iLlW, __pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW = __pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW} : that_0;
            else
            {
                this.__p_LX8EuK8Itw0NkOUUl35Yme = __p_LX8EuK8Itw0NkOUUl35Yme;
                this.__p_URMvKT5CawZMec6OLHZ34h = __p_URMvKT5CawZMec6OLHZ34h;
                this.__p_MHeln6YbBGkQclEJu2iLlW = __p_MHeln6YbBGkQclEJu2iLlW;
                this.__pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW = __pin_group_Input_In_MHeln6YbBGkQclEJu2iLlW;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 341809U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Ppp0N64qyqpO7EOUO2XF7C", Name = "Vorticity_Ppp0N64qyqpO7EOUO2XF7C")]
    [n2.SerializableAttribute]
    public class Vorticity_Ppp0N64qyqpO7EOUO2XF7C : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Vorticity_Ppp0N64qyqpO7EOUO2XF7C Create(n1.NodeContext Node_Context)
        {
            var instance = new Vorticity_Ppp0N64qyqpO7EOUO2XF7C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Vorticity_Ppp0N64qyqpO7EOUO2XF7C CreateDefault()
        {
            var instance = new Vorticity_Ppp0N64qyqpO7EOUO2XF7C(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Vorticity_Ppp0N64qyqpO7EOUO2XF7C Update(n4.FluidContext_C Context_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n33.IGraphicsRendererBase Layer_Out)
        {
            string __pad_Dzk79n8TyB9LRzDhbqGDia_0 = __slot_Dzk79n8TyB9LRzDhbqGDia;
            string __pad_NryVa9TWWdQLySCbMSubQ5_1 = __slot_NryVa9TWWdQLySCbMSubQ5;
            var Output_7 = Context_In.GetTextureWithName(Texture_Name_In: __pad_Dzk79n8TyB9LRzDhbqGDia_0, Texture_Read_Out: out n27.Texture Texture_Read_2, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_3, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_4, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_5, Found_Out: out bool Found_6);
            var Output_13 = Output_7.GetTextureWithName(Texture_Name_In: __pad_NryVa9TWWdQLySCbMSubQ5_1, Texture_Read_Out: out n27.Texture Texture_Read_8, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_9, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_10, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_11, Found_Out: out bool Found_12);
            var Output_16 = Context_In.GetDispatch(Thread_Group_Count_Out: out n6.Int3 Thread_Group_Count_14, Thread_Group_Size_Out: out n6.Int3 Thread_Group_Size_15);
            n1.CompilationHelper.WritePin(this.__p_RnpH01UExObLCKoKYGE5Zl.Inputs[0], ref Thread_Group_Count_14);
            n1.CompilationHelper.ReadPin(this.__p_RnpH01UExObLCKoKYGE5Zl.Outputs[0], out n32.IComputeEffectDispatcher out_17);
            n1.CompilationHelper.WritePin(this.__p_LgiM9HnmIOqMAdZvR5TRE6.Inputs[0], ref out_17);
            n1.CompilationHelper.WritePin(this.__p_LgiM9HnmIOqMAdZvR5TRE6.Inputs[1], ref Thread_Group_Size_15);
            n1.CompilationHelper.WritePin(this.__p_LgiM9HnmIOqMAdZvR5TRE6.Inputs[2], ref Texture_Read_8);
            n1.CompilationHelper.WritePin(this.__p_LgiM9HnmIOqMAdZvR5TRE6.Inputs[3], ref Texture_ReadWrite_4);
            var Output_19 = Context_In.GetResolutionVector(Resolution_Out: out n6.Vector3 Resolution_18);
            n1.CompilationHelper.WritePin(this.__p_LgiM9HnmIOqMAdZvR5TRE6.Inputs[4], ref Resolution_18);
            var Output_21 = Output_19.GetFluidTimeStep(Fluid_TimeStep_Out: out float Fluid_TimeStep_20);
            n1.CompilationHelper.WritePin(this.__p_LgiM9HnmIOqMAdZvR5TRE6.Inputs[5], ref Fluid_TimeStep_20);
            n1.CompilationHelper.WritePin(this.__p_LgiM9HnmIOqMAdZvR5TRE6.Inputs[6], ref Enabled_In);
            n1.CompilationHelper.ReadPin(this.__p_LgiM9HnmIOqMAdZvR5TRE6.Outputs[0], out n33.IGraphicsRendererBase out_22);
            Layer_Out = out_22;
            n4.Vorticity_Ppp0N64qyqpO7EOUO2XF7C that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = this.__p_RnpH01UExObLCKoKYGE5Zl != this.__p_RnpH01UExObLCKoKYGE5Zl || this.__p_LgiM9HnmIOqMAdZvR5TRE6 != this.__p_LgiM9HnmIOqMAdZvR5TRE6 ? new Vorticity_Ppp0N64qyqpO7EOUO2XF7C(this)
                {__p_RnpH01UExObLCKoKYGE5Zl = this.__p_RnpH01UExObLCKoKYGE5Zl, __p_LgiM9HnmIOqMAdZvR5TRE6 = this.__p_LgiM9HnmIOqMAdZvR5TRE6} : that_23;
            else
            {
                this.__p_RnpH01UExObLCKoKYGE5Zl = this.__p_RnpH01UExObLCKoKYGE5Zl;
                this.__p_LgiM9HnmIOqMAdZvR5TRE6 = this.__p_LgiM9HnmIOqMAdZvR5TRE6;
            }

            return that_23;
        }

        public n4.Vorticity_Ppp0N64qyqpO7EOUO2XF7C __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "Fluid3DVorticityShader (Internal)", "Stride.Rendering.ComputeShaders");
            var node_1 = n1.CompilationHelper.CreateNodeById(Node_Context, "DirectDispatcher", "Stride.Rendering.Advanced");
            n4.Vorticity_Ppp0N64qyqpO7EOUO2XF7C that_2 = this;
            this.__p_LgiM9HnmIOqMAdZvR5TRE6 = node_0;
            this.__p_RnpH01UExObLCKoKYGE5Zl = node_1;
            return that_2;
        }

        public n4.Vorticity_Ppp0N64qyqpO7EOUO2XF7C __CreateDefault__()
        {
            n4.Vorticity_Ppp0N64qyqpO7EOUO2XF7C that_0 = this;
            this.__p_RnpH01UExObLCKoKYGE5Zl = default(n1.IVLNode);
            this.__p_LgiM9HnmIOqMAdZvR5TRE6 = default(n1.IVLNode);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_RnpH01UExObLCKoKYGE5Zl);
            n1.CompilationHelper.SafeDispose(this.__p_LgiM9HnmIOqMAdZvR5TRE6);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 341889U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NryVa9TWWdQLySCbMSubQ5", Name = "__slot_NryVa9TWWdQLySCbMSubQ5")]
        public static string __slot_NryVa9TWWdQLySCbMSubQ5 = "Velocity";
        [n1.ElementAttribute(TracingId = 341907U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Dzk79n8TyB9LRzDhbqGDia", Name = "__slot_Dzk79n8TyB9LRzDhbqGDia")]
        public static string __slot_Dzk79n8TyB9LRzDhbqGDia = "Vorticity";
        [n1.ElementAttribute(TracingId = 341843U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RnpH01UExObLCKoKYGE5Zl", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
        public n1.IVLNode __p_RnpH01UExObLCKoKYGE5Zl;
        [n1.ElementAttribute(TracingId = 341829U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LgiM9HnmIOqMAdZvR5TRE6", Name = "Fluid3DVorticityShader", IsManaged = true, IsAutoGenerated = true, NodeName = "Fluid3DVorticityShader (Internal)", NodeCategory = "Stride.Rendering.ComputeShaders")]
        public n1.IVLNode __p_LgiM9HnmIOqMAdZvR5TRE6;
        static Vorticity_Ppp0N64qyqpO7EOUO2XF7C()
        {
        }

        public Vorticity_Ppp0N64qyqpO7EOUO2XF7C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Vorticity_Ppp0N64qyqpO7EOUO2XF7C(Vorticity_Ppp0N64qyqpO7EOUO2XF7C other): base(other)
        {
            this.__p_RnpH01UExObLCKoKYGE5Zl = other.__p_RnpH01UExObLCKoKYGE5Zl;
            this.__p_LgiM9HnmIOqMAdZvR5TRE6 = other.__p_LgiM9HnmIOqMAdZvR5TRE6;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RnpH01UExObLCKoKYGE5Zl", in __p_RnpH01UExObLCKoKYGE5Zl), n1.CompilationHelper.GetValueOrExisting(values, "__p_LgiM9HnmIOqMAdZvR5TRE6", in __p_LgiM9HnmIOqMAdZvR5TRE6));
        }

        internal Vorticity_Ppp0N64qyqpO7EOUO2XF7C __WITH__(n1.IVLNode __p_RnpH01UExObLCKoKYGE5Zl, n1.IVLNode __p_LgiM9HnmIOqMAdZvR5TRE6)
        {
            n4.Vorticity_Ppp0N64qyqpO7EOUO2XF7C that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_RnpH01UExObLCKoKYGE5Zl != this.__p_RnpH01UExObLCKoKYGE5Zl || __p_LgiM9HnmIOqMAdZvR5TRE6 != this.__p_LgiM9HnmIOqMAdZvR5TRE6 ? new Vorticity_Ppp0N64qyqpO7EOUO2XF7C(this)
                {__p_RnpH01UExObLCKoKYGE5Zl = __p_RnpH01UExObLCKoKYGE5Zl, __p_LgiM9HnmIOqMAdZvR5TRE6 = __p_LgiM9HnmIOqMAdZvR5TRE6} : that_0;
            else
            {
                this.__p_RnpH01UExObLCKoKYGE5Zl = __p_RnpH01UExObLCKoKYGE5Zl;
                this.__p_LgiM9HnmIOqMAdZvR5TRE6 = __p_LgiM9HnmIOqMAdZvR5TRE6;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 341967U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FdYIJnpqQivNiWakJ20DmS", Name = "Confinement_FdYIJnpqQivNiWakJ20DmS")]
    [n2.SerializableAttribute]
    public class Confinement_FdYIJnpqQivNiWakJ20DmS : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Confinement_FdYIJnpqQivNiWakJ20DmS Create(n1.NodeContext Node_Context)
        {
            var instance = new Confinement_FdYIJnpqQivNiWakJ20DmS(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Confinement_FdYIJnpqQivNiWakJ20DmS CreateDefault()
        {
            var instance = new Confinement_FdYIJnpqQivNiWakJ20DmS(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Confinement_FdYIJnpqQivNiWakJ20DmS Update(n4.FluidContext_C Context_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n33.IGraphicsRendererBase Layer_Out)
        {
            string __pad_T58PfhPMu1HMRN0VAgeqbr_0 = __slot_T58PfhPMu1HMRN0VAgeqbr;
            string __pad_OaWtr8hkGnJPvFXCdz3rfj_1 = __slot_OaWtr8hkGnJPvFXCdz3rfj;
            var Output_7 = Context_In.GetTextureWithName(Texture_Name_In: __pad_T58PfhPMu1HMRN0VAgeqbr_0, Texture_Read_Out: out n27.Texture Texture_Read_2, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_3, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_4, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_5, Found_Out: out bool Found_6);
            var Output_13 = Output_7.GetTextureWithName(Texture_Name_In: __pad_OaWtr8hkGnJPvFXCdz3rfj_1, Texture_Read_Out: out n27.Texture Texture_Read_8, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_9, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_10, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_11, Found_Out: out bool Found_12);
            var Output_16 = Context_In.GetDispatch(Thread_Group_Count_Out: out n6.Int3 Thread_Group_Count_14, Thread_Group_Size_Out: out n6.Int3 Thread_Group_Size_15);
            n1.CompilationHelper.WritePin(this.__p_APdSZ3tej7rNNmGvfK40Cj.Inputs[0], ref Thread_Group_Count_14);
            n1.CompilationHelper.ReadPin(this.__p_APdSZ3tej7rNNmGvfK40Cj.Outputs[0], out n32.IComputeEffectDispatcher out_17);
            n1.CompilationHelper.WritePin(this.__p_VASwDvTyeNjLGiCbpY4AsY.Inputs[0], ref out_17);
            n1.CompilationHelper.WritePin(this.__p_VASwDvTyeNjLGiCbpY4AsY.Inputs[1], ref Thread_Group_Size_15);
            n1.CompilationHelper.WritePin(this.__p_VASwDvTyeNjLGiCbpY4AsY.Inputs[2], ref Texture_Read_2);
            n1.CompilationHelper.WritePin(this.__p_VASwDvTyeNjLGiCbpY4AsY.Inputs[3], ref Texture_Read_8);
            n1.CompilationHelper.WritePin(this.__p_VASwDvTyeNjLGiCbpY4AsY.Inputs[4], ref Texture_ReadWrite_10);
            var Output_19 = Context_In.GetResolutionVector(Resolution_Out: out n6.Vector3 Resolution_18);
            n1.CompilationHelper.WritePin(this.__p_VASwDvTyeNjLGiCbpY4AsY.Inputs[5], ref Resolution_18);
            var Output_21 = Output_19.GetFluidTimeStep(Fluid_TimeStep_Out: out float Fluid_TimeStep_20);
            n1.CompilationHelper.WritePin(this.__p_VASwDvTyeNjLGiCbpY4AsY.Inputs[6], ref Fluid_TimeStep_20);
            var Output_23 = Context_In.GetVorticityStrength(Vorticity_Strength_Out: out float Vorticity_Strength_22);
            n1.CompilationHelper.WritePin(this.__p_VASwDvTyeNjLGiCbpY4AsY.Inputs[7], ref Vorticity_Strength_22);
            n1.CompilationHelper.WritePin(this.__p_VASwDvTyeNjLGiCbpY4AsY.Inputs[8], ref Enabled_In);
            n1.CompilationHelper.ReadPin(this.__p_VASwDvTyeNjLGiCbpY4AsY.Outputs[0], out n33.IGraphicsRendererBase out_24);
            n33.IGraphicsRendererBase __auto_25;
            if (Enabled_In)
            {
                string __pad_JWwkZDoSU6WPQj8CvncYSk_27 = __slot_JWwkZDoSU6WPQj8CvncYSk;
                var Output_29 = Output_13.SwapPingPongTextureWithName(Texture_Name_In: __pad_JWwkZDoSU6WPQj8CvncYSk_27, Found_Out: out bool Found_28);
                __auto_25 = out_24;
            }
            else
            {
                __auto_25 = out_24;
            }

            Layer_Out = __auto_25;
            n4.Confinement_FdYIJnpqQivNiWakJ20DmS that_30 = this;
            if (this.__GetContext__().IsImmutable)
                that_30 = this.__p_APdSZ3tej7rNNmGvfK40Cj != this.__p_APdSZ3tej7rNNmGvfK40Cj || this.__p_VASwDvTyeNjLGiCbpY4AsY != this.__p_VASwDvTyeNjLGiCbpY4AsY ? new Confinement_FdYIJnpqQivNiWakJ20DmS(this)
                {__p_APdSZ3tej7rNNmGvfK40Cj = this.__p_APdSZ3tej7rNNmGvfK40Cj, __p_VASwDvTyeNjLGiCbpY4AsY = this.__p_VASwDvTyeNjLGiCbpY4AsY} : that_30;
            else
            {
                this.__p_APdSZ3tej7rNNmGvfK40Cj = this.__p_APdSZ3tej7rNNmGvfK40Cj;
                this.__p_VASwDvTyeNjLGiCbpY4AsY = this.__p_VASwDvTyeNjLGiCbpY4AsY;
            }

            return that_30;
        }

        public n4.Confinement_FdYIJnpqQivNiWakJ20DmS __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "Fluid3DConfinementShader (Internal)", "Stride.Rendering.ComputeShaders");
            var node_1 = n1.CompilationHelper.CreateNodeById(Node_Context, "DirectDispatcher", "Stride.Rendering.Advanced");
            n4.Confinement_FdYIJnpqQivNiWakJ20DmS that_2 = this;
            this.__p_VASwDvTyeNjLGiCbpY4AsY = node_0;
            this.__p_APdSZ3tej7rNNmGvfK40Cj = node_1;
            return that_2;
        }

        public n4.Confinement_FdYIJnpqQivNiWakJ20DmS __CreateDefault__()
        {
            n4.Confinement_FdYIJnpqQivNiWakJ20DmS that_0 = this;
            this.__p_APdSZ3tej7rNNmGvfK40Cj = default(n1.IVLNode);
            this.__p_VASwDvTyeNjLGiCbpY4AsY = default(n1.IVLNode);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_APdSZ3tej7rNNmGvfK40Cj);
            n1.CompilationHelper.SafeDispose(this.__p_VASwDvTyeNjLGiCbpY4AsY);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 342127U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OaWtr8hkGnJPvFXCdz3rfj", Name = "__slot_OaWtr8hkGnJPvFXCdz3rfj")]
        public static string __slot_OaWtr8hkGnJPvFXCdz3rfj = "Velocity";
        [n1.ElementAttribute(TracingId = 342137U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "T58PfhPMu1HMRN0VAgeqbr", Name = "__slot_T58PfhPMu1HMRN0VAgeqbr")]
        public static string __slot_T58PfhPMu1HMRN0VAgeqbr = "Vorticity";
        [n1.ElementAttribute(TracingId = 342053U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "APdSZ3tej7rNNmGvfK40Cj", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
        public n1.IVLNode __p_APdSZ3tej7rNNmGvfK40Cj;
        [n1.ElementAttribute(TracingId = 341995U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VASwDvTyeNjLGiCbpY4AsY", Name = "Fluid3DConfinementShader", IsManaged = true, IsAutoGenerated = true, NodeName = "Fluid3DConfinementShader (Internal)", NodeCategory = "Stride.Rendering.ComputeShaders")]
        public n1.IVLNode __p_VASwDvTyeNjLGiCbpY4AsY;
        [n1.ElementAttribute(TracingId = 342103U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JWwkZDoSU6WPQj8CvncYSk", Name = "__slot_JWwkZDoSU6WPQj8CvncYSk")]
        public static string __slot_JWwkZDoSU6WPQj8CvncYSk = "Velocity";
        static Confinement_FdYIJnpqQivNiWakJ20DmS()
        {
        }

        public Confinement_FdYIJnpqQivNiWakJ20DmS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Confinement_FdYIJnpqQivNiWakJ20DmS(Confinement_FdYIJnpqQivNiWakJ20DmS other): base(other)
        {
            this.__p_APdSZ3tej7rNNmGvfK40Cj = other.__p_APdSZ3tej7rNNmGvfK40Cj;
            this.__p_VASwDvTyeNjLGiCbpY4AsY = other.__p_VASwDvTyeNjLGiCbpY4AsY;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_APdSZ3tej7rNNmGvfK40Cj", in __p_APdSZ3tej7rNNmGvfK40Cj), n1.CompilationHelper.GetValueOrExisting(values, "__p_VASwDvTyeNjLGiCbpY4AsY", in __p_VASwDvTyeNjLGiCbpY4AsY));
        }

        internal Confinement_FdYIJnpqQivNiWakJ20DmS __WITH__(n1.IVLNode __p_APdSZ3tej7rNNmGvfK40Cj, n1.IVLNode __p_VASwDvTyeNjLGiCbpY4AsY)
        {
            n4.Confinement_FdYIJnpqQivNiWakJ20DmS that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_APdSZ3tej7rNNmGvfK40Cj != this.__p_APdSZ3tej7rNNmGvfK40Cj || __p_VASwDvTyeNjLGiCbpY4AsY != this.__p_VASwDvTyeNjLGiCbpY4AsY ? new Confinement_FdYIJnpqQivNiWakJ20DmS(this)
                {__p_APdSZ3tej7rNNmGvfK40Cj = __p_APdSZ3tej7rNNmGvfK40Cj, __p_VASwDvTyeNjLGiCbpY4AsY = __p_VASwDvTyeNjLGiCbpY4AsY} : that_0;
            else
            {
                this.__p_APdSZ3tej7rNNmGvfK40Cj = __p_APdSZ3tej7rNNmGvfK40Cj;
                this.__p_VASwDvTyeNjLGiCbpY4AsY = __p_VASwDvTyeNjLGiCbpY4AsY;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 342213U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EGgR9DLctWTP2kSQmrfFPR", Name = "ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR")]
    [n2.SerializableAttribute]
    public class ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR Create(n1.NodeContext Node_Context)
        {
            var instance = new ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR CreateDefault()
        {
            var instance = new ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR Update(n4.FluidContext_C Context_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n33.IGraphicsRendererBase Layer_Out)
        {
            string __pad_RkT642IyZTcLQeQZPSPj20_0 = __slot_RkT642IyZTcLQeQZPSPj20;
            string __pad_MaTu6vOFhzKN1lDR15b3U2_1 = __slot_MaTu6vOFhzKN1lDR15b3U2;
            string __pad_O4LvVtEshoMMNJKzUUxqlY_2 = __slot_O4LvVtEshoMMNJKzUUxqlY;
            string __pad_R5qlexJ9R70OtEgMK94gFZ_3 = __slot_R5qlexJ9R70OtEgMK94gFZ;
            var Output_9 = Context_In.GetTextureWithName(Texture_Name_In: __pad_RkT642IyZTcLQeQZPSPj20_0, Texture_Read_Out: out n27.Texture Texture_Read_4, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_5, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_6, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_7, Found_Out: out bool Found_8);
            var Output_15 = Output_9.GetTextureWithName(Texture_Name_In: __pad_MaTu6vOFhzKN1lDR15b3U2_1, Texture_Read_Out: out n27.Texture Texture_Read_10, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_11, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_12, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_13, Found_Out: out bool Found_14);
            var Output_21 = Output_15.GetTextureWithName(Texture_Name_In: __pad_O4LvVtEshoMMNJKzUUxqlY_2, Texture_Read_Out: out n27.Texture Texture_Read_16, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_17, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_18, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_19, Found_Out: out bool Found_20);
            var Output_27 = Output_21.GetTextureWithName(Texture_Name_In: __pad_R5qlexJ9R70OtEgMK94gFZ_3, Texture_Read_Out: out n27.Texture Texture_Read_22, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_23, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_24, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_25, Found_Out: out bool Found_26);
            var Output_30 = Context_In.GetDispatch(Thread_Group_Count_Out: out n6.Int3 Thread_Group_Count_28, Thread_Group_Size_Out: out n6.Int3 Thread_Group_Size_29);
            n1.CompilationHelper.WritePin(this.__p_Dr6Jr8swrfcLcxgXcgf9RM.Inputs[0], ref Thread_Group_Count_28);
            n1.CompilationHelper.ReadPin(this.__p_Dr6Jr8swrfcLcxgXcgf9RM.Outputs[0], out n32.IComputeEffectDispatcher out_31);
            n1.CompilationHelper.WritePin(this.__p_EhSBtIPwa8mLCqLAaXVqwi.Inputs[0], ref out_31);
            n1.CompilationHelper.WritePin(this.__p_EhSBtIPwa8mLCqLAaXVqwi.Inputs[1], ref Thread_Group_Size_29);
            n1.CompilationHelper.WritePin(this.__p_EhSBtIPwa8mLCqLAaXVqwi.Inputs[2], ref Texture_Read_22);
            n1.CompilationHelper.WritePin(this.__p_EhSBtIPwa8mLCqLAaXVqwi.Inputs[3], ref Texture_Read_16);
            n1.CompilationHelper.WritePin(this.__p_EhSBtIPwa8mLCqLAaXVqwi.Inputs[4], ref Texture_Read_10);
            n1.CompilationHelper.WritePin(this.__p_EhSBtIPwa8mLCqLAaXVqwi.Inputs[5], ref Texture_ReadWrite_6);
            var Output_33 = Context_In.GetResolutionVector(Resolution_Out: out n6.Vector3 Resolution_32);
            n1.CompilationHelper.WritePin(this.__p_EhSBtIPwa8mLCqLAaXVqwi.Inputs[6], ref Resolution_32);
            var Output_35 = Output_33.GetFluidTimeStep(Fluid_TimeStep_Out: out float Fluid_TimeStep_34);
            n1.CompilationHelper.WritePin(this.__p_EhSBtIPwa8mLCqLAaXVqwi.Inputs[7], ref Fluid_TimeStep_34);
            n1.CompilationHelper.WritePin(this.__p_EhSBtIPwa8mLCqLAaXVqwi.Inputs[8], ref Enabled_In);
            n1.CompilationHelper.ReadPin(this.__p_EhSBtIPwa8mLCqLAaXVqwi.Outputs[0], out n33.IGraphicsRendererBase out_36);
            Layer_Out = out_36;
            n4.ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR that_37 = this;
            if (this.__GetContext__().IsImmutable)
                that_37 = this.__p_Dr6Jr8swrfcLcxgXcgf9RM != this.__p_Dr6Jr8swrfcLcxgXcgf9RM || this.__p_EhSBtIPwa8mLCqLAaXVqwi != this.__p_EhSBtIPwa8mLCqLAaXVqwi ? new ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR(this)
                {__p_Dr6Jr8swrfcLcxgXcgf9RM = this.__p_Dr6Jr8swrfcLcxgXcgf9RM, __p_EhSBtIPwa8mLCqLAaXVqwi = this.__p_EhSBtIPwa8mLCqLAaXVqwi} : that_37;
            else
            {
                this.__p_Dr6Jr8swrfcLcxgXcgf9RM = this.__p_Dr6Jr8swrfcLcxgXcgf9RM;
                this.__p_EhSBtIPwa8mLCqLAaXVqwi = this.__p_EhSBtIPwa8mLCqLAaXVqwi;
            }

            return that_37;
        }

        public n4.ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "Fluid3DComputeVelocityDivergenceShader (Internal)", "Stride.Rendering.ComputeShaders");
            var node_1 = n1.CompilationHelper.CreateNodeById(Node_Context, "DirectDispatcher", "Stride.Rendering.Advanced");
            n4.ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR that_2 = this;
            this.__p_EhSBtIPwa8mLCqLAaXVqwi = node_0;
            this.__p_Dr6Jr8swrfcLcxgXcgf9RM = node_1;
            return that_2;
        }

        public n4.ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR __CreateDefault__()
        {
            n4.ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR that_0 = this;
            this.__p_Dr6Jr8swrfcLcxgXcgf9RM = default(n1.IVLNode);
            this.__p_EhSBtIPwa8mLCqLAaXVqwi = default(n1.IVLNode);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Dr6Jr8swrfcLcxgXcgf9RM);
            n1.CompilationHelper.SafeDispose(this.__p_EhSBtIPwa8mLCqLAaXVqwi);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 342333U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "R5qlexJ9R70OtEgMK94gFZ", Name = "__slot_R5qlexJ9R70OtEgMK94gFZ")]
        public static string __slot_R5qlexJ9R70OtEgMK94gFZ = "Velocity";
        [n1.ElementAttribute(TracingId = 342359U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RkT642IyZTcLQeQZPSPj20", Name = "__slot_RkT642IyZTcLQeQZPSPj20")]
        public static string __slot_RkT642IyZTcLQeQZPSPj20 = "Divergence";
        [n1.ElementAttribute(TracingId = 342387U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MaTu6vOFhzKN1lDR15b3U2", Name = "__slot_MaTu6vOFhzKN1lDR15b3U2")]
        public static string __slot_MaTu6vOFhzKN1lDR15b3U2 = "ObstaclesVelocity";
        [n1.ElementAttribute(TracingId = 342418U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "O4LvVtEshoMMNJKzUUxqlY", Name = "__slot_O4LvVtEshoMMNJKzUUxqlY")]
        public static string __slot_O4LvVtEshoMMNJKzUUxqlY = "ObstaclesGradient";
        [n1.ElementAttribute(TracingId = 342265U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Dr6Jr8swrfcLcxgXcgf9RM", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
        public n1.IVLNode __p_Dr6Jr8swrfcLcxgXcgf9RM;
        [n1.ElementAttribute(TracingId = 342235U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EhSBtIPwa8mLCqLAaXVqwi", Name = "Fluid3DComputeVelocityDivergenceShader", IsManaged = true, IsAutoGenerated = true, NodeName = "Fluid3DComputeVelocityDivergenceShader (Internal)", NodeCategory = "Stride.Rendering.ComputeShaders")]
        public n1.IVLNode __p_EhSBtIPwa8mLCqLAaXVqwi;
        static ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR()
        {
        }

        public ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR(ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR other): base(other)
        {
            this.__p_Dr6Jr8swrfcLcxgXcgf9RM = other.__p_Dr6Jr8swrfcLcxgXcgf9RM;
            this.__p_EhSBtIPwa8mLCqLAaXVqwi = other.__p_EhSBtIPwa8mLCqLAaXVqwi;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Dr6Jr8swrfcLcxgXcgf9RM", in __p_Dr6Jr8swrfcLcxgXcgf9RM), n1.CompilationHelper.GetValueOrExisting(values, "__p_EhSBtIPwa8mLCqLAaXVqwi", in __p_EhSBtIPwa8mLCqLAaXVqwi));
        }

        internal ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR __WITH__(n1.IVLNode __p_Dr6Jr8swrfcLcxgXcgf9RM, n1.IVLNode __p_EhSBtIPwa8mLCqLAaXVqwi)
        {
            n4.ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Dr6Jr8swrfcLcxgXcgf9RM != this.__p_Dr6Jr8swrfcLcxgXcgf9RM || __p_EhSBtIPwa8mLCqLAaXVqwi != this.__p_EhSBtIPwa8mLCqLAaXVqwi ? new ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR(this)
                {__p_Dr6Jr8swrfcLcxgXcgf9RM = __p_Dr6Jr8swrfcLcxgXcgf9RM, __p_EhSBtIPwa8mLCqLAaXVqwi = __p_EhSBtIPwa8mLCqLAaXVqwi} : that_0;
            else
            {
                this.__p_Dr6Jr8swrfcLcxgXcgf9RM = __p_Dr6Jr8swrfcLcxgXcgf9RM;
                this.__p_EhSBtIPwa8mLCqLAaXVqwi = __p_EhSBtIPwa8mLCqLAaXVqwi;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 342499U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DCf8AjjoTvONfK9Qflg1kn", Name = "Solver_DCf8AjjoTvONfK9Qflg1kn")]
    [n2.SerializableAttribute]
    public class Solver_DCf8AjjoTvONfK9Qflg1kn : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Solver_DCf8AjjoTvONfK9Qflg1kn Create(n1.NodeContext Node_Context)
        {
            var instance = new Solver_DCf8AjjoTvONfK9Qflg1kn(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Solver_DCf8AjjoTvONfK9Qflg1kn CreateDefault()
        {
            var instance = new Solver_DCf8AjjoTvONfK9Qflg1kn(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Solver_DCf8AjjoTvONfK9Qflg1kn Update(n4.FluidContext_C Context_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n35.GraphicsRendererGroup Layer_Out)
        {
            var Output_1 = this.__p_F4oVqkgMdXfNxM5KmZ8PGk.Update(Context_In: Context_In, Enabled_In: Enabled_In, Layer_Out: out n33.IGraphicsRendererBase Layer_0);
            var Output_3 = this.__p_AthNUWKY9C2PNsdzL3gT65.Update(Context_In: Context_In, Enabled_In: Enabled_In, Layer_Out: out n33.IGraphicsRendererBase Layer_2);
            var Output_5 = this.__p_HVcGDRo0uMuPs7YWOtCvyc.Update(Context_In: Context_In, Enabled_In: Enabled_In, Layer_Out: out n35.GraphicsRendererGroup Layer_4);
            n33.IGraphicsRendererBase Input_2_6 = (n33.IGraphicsRendererBase)Layer_4;
            var builder_7 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0, 3);
            builder_7.Add(Layer_0);
            builder_7.Add(Input_2_6);
            builder_7.Add(Layer_2);
            var __pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0_8 = builder_7.Commit();
            n14._Operations_.Cons<n33.IGraphicsRendererBase>(Input_In: __pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0_8, Result_Out: out n12.Spread<n33.IGraphicsRendererBase> Result_9);
            bool Update_10 = true;
            var Output_11 = this.__p_QFfBEd9eDWuPbNsKHiNIzB;
            if (Update_10)
            {
                n35.GraphicsRendererGroup Input__this__12 = this.__p_QFfBEd9eDWuPbNsKHiNIzB;
                Input__this__12.Update(input: Result_9);
                Output_11 = Input__this__12;
            }

            Layer_Out = Output_11;
            n4.Solver_DCf8AjjoTvONfK9Qflg1kn that_13 = this;
            if (this.__GetContext__().IsImmutable)
                that_13 = Output_1 != this.__p_F4oVqkgMdXfNxM5KmZ8PGk || Output_3 != this.__p_AthNUWKY9C2PNsdzL3gT65 || Output_5 != this.__p_HVcGDRo0uMuPs7YWOtCvyc || __pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0_8 != this.__pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0 || Output_11 != this.__p_QFfBEd9eDWuPbNsKHiNIzB ? new Solver_DCf8AjjoTvONfK9Qflg1kn(this)
                {__p_F4oVqkgMdXfNxM5KmZ8PGk = Output_1, __p_AthNUWKY9C2PNsdzL3gT65 = Output_3, __p_HVcGDRo0uMuPs7YWOtCvyc = Output_5, __pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0 = __pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0_8, __p_QFfBEd9eDWuPbNsKHiNIzB = Output_11} : that_13;
            else
            {
                this.__p_F4oVqkgMdXfNxM5KmZ8PGk = Output_1;
                this.__p_AthNUWKY9C2PNsdzL3gT65 = Output_3;
                this.__p_HVcGDRo0uMuPs7YWOtCvyc = Output_5;
                this.__pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0 = __pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0_8;
                this.__p_QFfBEd9eDWuPbNsKHiNIzB = Output_11;
            }

            return that_13;
        }

        public n4.Solver_DCf8AjjoTvONfK9Qflg1kn __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "QFfBEd9eDWuPbNsKHiNIzB", 342518U);
            n37._Operations_.Create(Node_Context: Node_Context_0, Output_Out: out n35.GraphicsRendererGroup Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "F4oVqkgMdXfNxM5KmZ8PGk", 342532U);
            var Output_3 = n4.ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "HVcGDRo0uMuPs7YWOtCvyc", 342542U);
            var Output_5 = n4.ComputePressure_PKuggOQZFoROUYZK0IglqE.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "AthNUWKY9C2PNsdzL3gT65", 342554U);
            var Output_7 = n4.ProjectVelocity_LT01GLQcDnMMGGdprrdi46.Create(Node_Context: Node_Context_6);
            n4.Solver_DCf8AjjoTvONfK9Qflg1kn that_8 = this;
            this.__pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0 = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__p_QFfBEd9eDWuPbNsKHiNIzB = Output_1;
            this.__p_F4oVqkgMdXfNxM5KmZ8PGk = Output_3;
            this.__p_HVcGDRo0uMuPs7YWOtCvyc = Output_5;
            this.__p_AthNUWKY9C2PNsdzL3gT65 = Output_7;
            return that_8;
        }

        public n4.Solver_DCf8AjjoTvONfK9Qflg1kn __CreateDefault__()
        {
            n4.Solver_DCf8AjjoTvONfK9Qflg1kn that_0 = this;
            this.__pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0 = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__p_F4oVqkgMdXfNxM5KmZ8PGk = n4.ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR.CreateDefault();
            this.__p_AthNUWKY9C2PNsdzL3gT65 = n4.ProjectVelocity_LT01GLQcDnMMGGdprrdi46.CreateDefault();
            this.__p_HVcGDRo0uMuPs7YWOtCvyc = n4.ComputePressure_PKuggOQZFoROUYZK0IglqE.CreateDefault();
            this.__p_QFfBEd9eDWuPbNsKHiNIzB = default(n35.GraphicsRendererGroup);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_F4oVqkgMdXfNxM5KmZ8PGk);
            n1.CompilationHelper.SafeDispose(this.__p_AthNUWKY9C2PNsdzL3gT65);
            n1.CompilationHelper.SafeDispose(this.__p_HVcGDRo0uMuPs7YWOtCvyc);
            n1.CompilationHelper.SafeDispose(this.__p_QFfBEd9eDWuPbNsKHiNIzB);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 342532U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "F4oVqkgMdXfNxM5KmZ8PGk", Name = "ComputeVelocityDivergence", IsManaged = true, IsAutoGenerated = true)]
        public n4.ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR __p_F4oVqkgMdXfNxM5KmZ8PGk;
        [n1.ElementAttribute(TracingId = 342554U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "AthNUWKY9C2PNsdzL3gT65", Name = "ProjectVelocity", IsManaged = true, IsAutoGenerated = true)]
        public n4.ProjectVelocity_LT01GLQcDnMMGGdprrdi46 __p_AthNUWKY9C2PNsdzL3gT65;
        [n1.ElementAttribute(TracingId = 342542U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "HVcGDRo0uMuPs7YWOtCvyc", Name = "ComputePressure", IsManaged = true, IsAutoGenerated = true)]
        public n4.ComputePressure_PKuggOQZFoROUYZK0IglqE __p_HVcGDRo0uMuPs7YWOtCvyc;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n33.IGraphicsRendererBase> __pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0 = default(n12.Spread<n33.IGraphicsRendererBase>);
        [n1.ElementAttribute(TracingId = 342518U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QFfBEd9eDWuPbNsKHiNIzB", Name = "Group (Spectral)", IsManaged = true, IsAutoGenerated = true)]
        public n35.GraphicsRendererGroup __p_QFfBEd9eDWuPbNsKHiNIzB;
        public Solver_DCf8AjjoTvONfK9Qflg1kn(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Solver_DCf8AjjoTvONfK9Qflg1kn(Solver_DCf8AjjoTvONfK9Qflg1kn other): base(other)
        {
            this.__p_F4oVqkgMdXfNxM5KmZ8PGk = other.__p_F4oVqkgMdXfNxM5KmZ8PGk;
            this.__p_AthNUWKY9C2PNsdzL3gT65 = other.__p_AthNUWKY9C2PNsdzL3gT65;
            this.__p_HVcGDRo0uMuPs7YWOtCvyc = other.__p_HVcGDRo0uMuPs7YWOtCvyc;
            this.__pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0 = other.__pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0;
            this.__p_QFfBEd9eDWuPbNsKHiNIzB = other.__p_QFfBEd9eDWuPbNsKHiNIzB;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_F4oVqkgMdXfNxM5KmZ8PGk", in __p_F4oVqkgMdXfNxM5KmZ8PGk), n1.CompilationHelper.GetValueOrExisting(values, "__p_AthNUWKY9C2PNsdzL3gT65", in __p_AthNUWKY9C2PNsdzL3gT65), n1.CompilationHelper.GetValueOrExisting(values, "__p_HVcGDRo0uMuPs7YWOtCvyc", in __p_HVcGDRo0uMuPs7YWOtCvyc), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0", in __pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0), n1.CompilationHelper.GetValueOrExisting(values, "__p_QFfBEd9eDWuPbNsKHiNIzB", in __p_QFfBEd9eDWuPbNsKHiNIzB));
        }

        internal Solver_DCf8AjjoTvONfK9Qflg1kn __WITH__(n4.ComputeVelocityDivergence_EGgR9DLctWTP2kSQmrfFPR __p_F4oVqkgMdXfNxM5KmZ8PGk, n4.ProjectVelocity_LT01GLQcDnMMGGdprrdi46 __p_AthNUWKY9C2PNsdzL3gT65, n4.ComputePressure_PKuggOQZFoROUYZK0IglqE __p_HVcGDRo0uMuPs7YWOtCvyc, n12.Spread<n33.IGraphicsRendererBase> __pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0, n35.GraphicsRendererGroup __p_QFfBEd9eDWuPbNsKHiNIzB)
        {
            n4.Solver_DCf8AjjoTvONfK9Qflg1kn that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_F4oVqkgMdXfNxM5KmZ8PGk != this.__p_F4oVqkgMdXfNxM5KmZ8PGk || __p_AthNUWKY9C2PNsdzL3gT65 != this.__p_AthNUWKY9C2PNsdzL3gT65 || __p_HVcGDRo0uMuPs7YWOtCvyc != this.__p_HVcGDRo0uMuPs7YWOtCvyc || __pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0 != this.__pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0 || __p_QFfBEd9eDWuPbNsKHiNIzB != this.__p_QFfBEd9eDWuPbNsKHiNIzB ? new Solver_DCf8AjjoTvONfK9Qflg1kn(this)
                {__p_F4oVqkgMdXfNxM5KmZ8PGk = __p_F4oVqkgMdXfNxM5KmZ8PGk, __p_AthNUWKY9C2PNsdzL3gT65 = __p_AthNUWKY9C2PNsdzL3gT65, __p_HVcGDRo0uMuPs7YWOtCvyc = __p_HVcGDRo0uMuPs7YWOtCvyc, __pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0 = __pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0, __p_QFfBEd9eDWuPbNsKHiNIzB = __p_QFfBEd9eDWuPbNsKHiNIzB} : that_0;
            else
            {
                this.__p_F4oVqkgMdXfNxM5KmZ8PGk = __p_F4oVqkgMdXfNxM5KmZ8PGk;
                this.__p_AthNUWKY9C2PNsdzL3gT65 = __p_AthNUWKY9C2PNsdzL3gT65;
                this.__p_HVcGDRo0uMuPs7YWOtCvyc = __p_HVcGDRo0uMuPs7YWOtCvyc;
                this.__pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0 = __pin_group_Input_In_F7DxU9SWTTSNeRhQSY2Hy0;
                this.__p_QFfBEd9eDWuPbNsKHiNIzB = __p_QFfBEd9eDWuPbNsKHiNIzB;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 342640U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "PKuggOQZFoROUYZK0IglqE", Name = "ComputePressure_PKuggOQZFoROUYZK0IglqE")]
    [n2.SerializableAttribute]
    public class ComputePressure_PKuggOQZFoROUYZK0IglqE : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.ComputePressure_PKuggOQZFoROUYZK0IglqE Create(n1.NodeContext Node_Context)
        {
            var instance = new ComputePressure_PKuggOQZFoROUYZK0IglqE(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.ComputePressure_PKuggOQZFoROUYZK0IglqE CreateDefault()
        {
            var instance = new ComputePressure_PKuggOQZFoROUYZK0IglqE(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.ComputePressure_PKuggOQZFoROUYZK0IglqE Update(n4.FluidContext_C Context_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n35.GraphicsRendererGroup Layer_Out)
        {
            string __pad_BquBhFECtiPO2FOnUMFsHM_0 = __slot_BquBhFECtiPO2FOnUMFsHM;
            string __pad_CnzgprRIiQsMKzuwO0rxHH_1 = __slot_CnzgprRIiQsMKzuwO0rxHH;
            var Output_7 = Context_In.GetTextureWithName(Texture_Name_In: __pad_BquBhFECtiPO2FOnUMFsHM_0, Texture_Read_Out: out n27.Texture Texture_Read_2, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_3, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_4, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_5, Found_Out: out bool Found_6);
            var Output_13 = Output_7.GetTextureWithName(Texture_Name_In: __pad_CnzgprRIiQsMKzuwO0rxHH_1, Texture_Read_Out: out n27.Texture Texture_Read_8, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_9, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_10, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_11, Found_Out: out bool Found_12);
            var Output_15 = Context_In.GetJacobiIterations(Jacobi_Iterations_Out: out int Jacobi_Iterations_14);
            int __pad_AdoC4n0UIzNPCUknBDluxh_16 = Jacobi_Iterations_14;
            var Output_19 = Context_In.GetDispatch(Thread_Group_Count_Out: out n6.Int3 Thread_Group_Count_17, Thread_Group_Size_Out: out n6.Int3 Thread_Group_Size_18);
            var Output_21 = Context_In.GetFluidTimeStep(Fluid_TimeStep_Out: out float Fluid_TimeStep_20);
            var Output_23 = Output_21.GetResolutionVector(Resolution_Out: out n6.Vector3 Resolution_22);
            var Output_25 = Context_In.GetGridPosition(Grid_Position_Out: out n6.Vector3 Grid_Position_24);
            var Output_27 = this.__p_SWIkU7KhfjULxifMNAgsQ0.Update<n31.__AdaptiveImplementations__KeWf79wIWCVN4a6TzD33r2>(Value_In: Grid_Position_24, Result_Out: out n6.Vector3 Result_26);
            var manager_51 = this.__loop_KBLlBmibYnwMuRxL6LtNQT ?? new n34.ImmutableLifetimeManager();
            var iterator_52 = manager_51.GetIterator(__GetContext__());
            var builder_53 = n5.CollectionBuilders.GetBuilder(this.__cp_QSdwLAFdRswM1JjxZvGPwg, 16);
            n12.Spread<n33.IGraphicsRendererBase> output_54;
            try
            {
                for (var i_28 = 0; i_28 < __pad_AdoC4n0UIzNPCUknBDluxh_16; i_28++)
                {
                    var i_local_29 = i_28;
                    __CpqWChKRop6PR2c7fryPMM state_30;
                    if (!iterator_52.MoveNext(out state_30))
                    {
                        iterator_52.Add(state_30 = new __CpqWChKRop6PR2c7fryPMM(__GetContext__(), n1.VLObject.NewIdentity()));
                        var node_31 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "DirectDispatcher", "Stride.Rendering.Advanced");
                        state_30.__p_OzXEj1HCbaKLHNzuSe0K5k = node_31;
                        var node_32 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Fluid3DComputePressureShader (Internal)", "Stride.Rendering.ComputeShaders");
                        state_30.__p_NLpMK3ykoxsQFpmpFKju6h = node_32;
                    }

                    string __pad_QmQ6lW8Sp1fOGT4917fisG_33 = __slot_QmQ6lW8Sp1fOGT4917fisG;
                    int Input_2_34 = 0;
                    var Result_35 = i_local_29 == Input_2_34;
                    n6.Vector3 Input_36 = n7._Operations_.CreateDefault();
                    n39._Operations_.Switch_Boolean<n6.Vector3>(Condition_In: Result_35, Input_In: Input_36, Input_2_In: Result_26, Output_Out: out n6.Vector3 Output_37);
                    n1.CompilationHelper.WritePin(state_30.__p_OzXEj1HCbaKLHNzuSe0K5k.Inputs[0], ref Thread_Group_Count_17);
                    n1.CompilationHelper.ReadPin(state_30.__p_OzXEj1HCbaKLHNzuSe0K5k.Outputs[0], out n32.IComputeEffectDispatcher out_38);
                    n1.CompilationHelper.WritePin(state_30.__p_NLpMK3ykoxsQFpmpFKju6h.Inputs[0], ref out_38);
                    n1.CompilationHelper.WritePin(state_30.__p_NLpMK3ykoxsQFpmpFKju6h.Inputs[1], ref Thread_Group_Size_18);
                    n1.CompilationHelper.WritePin(state_30.__p_NLpMK3ykoxsQFpmpFKju6h.Inputs[2], ref Texture_Read_8);
                    n1.CompilationHelper.WritePin(state_30.__p_NLpMK3ykoxsQFpmpFKju6h.Inputs[3], ref Texture_Read_2);
                    var Output_44 = Output_13.GetTextureWithName(Texture_Name_In: __pad_QmQ6lW8Sp1fOGT4917fisG_33, Texture_Read_Out: out n27.Texture Texture_Read_39, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_40, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_41, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_42, Found_Out: out bool Found_43);
                    n1.CompilationHelper.WritePin(state_30.__p_NLpMK3ykoxsQFpmpFKju6h.Inputs[4], ref Texture_Read_39);
                    n1.CompilationHelper.WritePin(state_30.__p_NLpMK3ykoxsQFpmpFKju6h.Inputs[5], ref Texture_ReadWrite_41);
                    n1.CompilationHelper.WritePin(state_30.__p_NLpMK3ykoxsQFpmpFKju6h.Inputs[6], ref Resolution_22);
                    n1.CompilationHelper.WritePin(state_30.__p_NLpMK3ykoxsQFpmpFKju6h.Inputs[7], ref Fluid_TimeStep_20);
                    n1.CompilationHelper.WritePin(state_30.__p_NLpMK3ykoxsQFpmpFKju6h.Inputs[8], ref Output_37);
                    n1.CompilationHelper.WritePin(state_30.__p_NLpMK3ykoxsQFpmpFKju6h.Inputs[9], ref Enabled_In);
                    n1.CompilationHelper.ReadPin(state_30.__p_NLpMK3ykoxsQFpmpFKju6h.Outputs[0], out n33.IGraphicsRendererBase out_45);
                    n33.IGraphicsRendererBase __auto_46;
                    if (Enabled_In)
                    {
                        string __pad_KpI3avTfQbsPdyEdZXwCtk_48 = __slot_KpI3avTfQbsPdyEdZXwCtk;
                        var Output_50 = Output_44.SwapPingPongTextureWithName(Texture_Name_In: __pad_KpI3avTfQbsPdyEdZXwCtk_48, Found_Out: out bool Found_49);
                        __auto_46 = out_45;
                    }
                    else
                    {
                        __auto_46 = out_45;
                    }

                    if (state_30.__GetContext__().IsImmutable)
                        state_30 = state_30.__p_OzXEj1HCbaKLHNzuSe0K5k != state_30.__p_OzXEj1HCbaKLHNzuSe0K5k || state_30.__p_NLpMK3ykoxsQFpmpFKju6h != state_30.__p_NLpMK3ykoxsQFpmpFKju6h ? new __CpqWChKRop6PR2c7fryPMM(state_30)
                        {__p_OzXEj1HCbaKLHNzuSe0K5k = state_30.__p_OzXEj1HCbaKLHNzuSe0K5k, __p_NLpMK3ykoxsQFpmpFKju6h = state_30.__p_NLpMK3ykoxsQFpmpFKju6h} : state_30;
                    else
                    {
                        state_30.__p_OzXEj1HCbaKLHNzuSe0K5k = state_30.__p_OzXEj1HCbaKLHNzuSe0K5k;
                        state_30.__p_NLpMK3ykoxsQFpmpFKju6h = state_30.__p_NLpMK3ykoxsQFpmpFKju6h;
                    }

                    iterator_52.Update(state_30);
                    builder_53.Add(__auto_46);
                }
            }
            finally
            {
                manager_51 = iterator_52.Commit();
                output_54 = builder_53.Commit();
            }

            bool Update_55 = true;
            var Output_56 = this.__p_TSAucCmLd55OJID9OCIrzQ;
            if (Update_55)
            {
                n35.GraphicsRendererGroup Input__this__57 = this.__p_TSAucCmLd55OJID9OCIrzQ;
                Input__this__57.Update(input: output_54);
                Output_56 = Input__this__57;
            }

            Layer_Out = Output_56;
            n4.ComputePressure_PKuggOQZFoROUYZK0IglqE that_58 = this;
            if (this.__GetContext__().IsImmutable)
                that_58 = Jacobi_Iterations_14 != this.__slot_AdoC4n0UIzNPCUknBDluxh || Output_27 != this.__p_SWIkU7KhfjULxifMNAgsQ0 || manager_51 != this.__loop_KBLlBmibYnwMuRxL6LtNQT || output_54 != this.__cp_QSdwLAFdRswM1JjxZvGPwg || Output_56 != this.__p_TSAucCmLd55OJID9OCIrzQ ? new ComputePressure_PKuggOQZFoROUYZK0IglqE(this)
                {__slot_AdoC4n0UIzNPCUknBDluxh = Jacobi_Iterations_14, __p_SWIkU7KhfjULxifMNAgsQ0 = Output_27, __loop_KBLlBmibYnwMuRxL6LtNQT = manager_51, __cp_QSdwLAFdRswM1JjxZvGPwg = output_54, __p_TSAucCmLd55OJID9OCIrzQ = Output_56} : that_58;
            else
            {
                this.__slot_AdoC4n0UIzNPCUknBDluxh = Jacobi_Iterations_14;
                this.__p_SWIkU7KhfjULxifMNAgsQ0 = Output_27;
                this.__loop_KBLlBmibYnwMuRxL6LtNQT = manager_51;
                this.__cp_QSdwLAFdRswM1JjxZvGPwg = output_54;
                this.__p_TSAucCmLd55OJID9OCIrzQ = Output_56;
            }

            return that_58;
        }

        public n4.ComputePressure_PKuggOQZFoROUYZK0IglqE __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "TSAucCmLd55OJID9OCIrzQ", 342920U);
            n37._Operations_.Create(Node_Context: Node_Context_0, Output_Out: out n35.GraphicsRendererGroup Output_1);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "SWIkU7KhfjULxifMNAgsQ0", 342951U);
            var Output_3 = n36.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector3>.Create<n31.__AdaptiveImplementations__KeWf79wIWCVN4a6TzD33r2>(Node_Context: Node_Context_2);
            n4.ComputePressure_PKuggOQZFoROUYZK0IglqE that_4 = this;
            this.__slot_AdoC4n0UIzNPCUknBDluxh = 0;
            this.__cp_QSdwLAFdRswM1JjxZvGPwg = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__p_TSAucCmLd55OJID9OCIrzQ = Output_1;
            this.__p_SWIkU7KhfjULxifMNAgsQ0 = Output_3;
            this.__loop_KBLlBmibYnwMuRxL6LtNQT = default(n34.ImmutableLifetimeManager);
            return that_4;
        }

        public n4.ComputePressure_PKuggOQZFoROUYZK0IglqE __CreateDefault__()
        {
            n4.ComputePressure_PKuggOQZFoROUYZK0IglqE that_0 = this;
            this.__slot_AdoC4n0UIzNPCUknBDluxh = 0;
            this.__cp_QSdwLAFdRswM1JjxZvGPwg = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__p_SWIkU7KhfjULxifMNAgsQ0 = n36.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector3>.CreateDefault<n31.__AdaptiveImplementations__KeWf79wIWCVN4a6TzD33r2>();
            this.__loop_KBLlBmibYnwMuRxL6LtNQT = default(n34.ImmutableLifetimeManager);
            this.__p_TSAucCmLd55OJID9OCIrzQ = default(n35.GraphicsRendererGroup);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SWIkU7KhfjULxifMNAgsQ0);
            n1.CompilationHelper.SafeDispose(this.__loop_KBLlBmibYnwMuRxL6LtNQT);
            n1.CompilationHelper.SafeDispose(this.__p_TSAucCmLd55OJID9OCIrzQ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 342645U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "AdoC4n0UIzNPCUknBDluxh", Name = "__slot_AdoC4n0UIzNPCUknBDluxh")]
        public int __slot_AdoC4n0UIzNPCUknBDluxh;
        [n1.ElementAttribute(TracingId = 342995U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BquBhFECtiPO2FOnUMFsHM", Name = "__slot_BquBhFECtiPO2FOnUMFsHM")]
        public static string __slot_BquBhFECtiPO2FOnUMFsHM = "Divergence";
        [n1.ElementAttribute(TracingId = 343025U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CnzgprRIiQsMKzuwO0rxHH", Name = "__slot_CnzgprRIiQsMKzuwO0rxHH")]
        public static string __slot_CnzgprRIiQsMKzuwO0rxHH = "ObstaclesGradient";
        [n1.ElementAttribute(TracingId = 342951U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SWIkU7KhfjULxifMNAgsQ0", Name = "FrameDifference", IsManaged = true, IsAutoGenerated = true)]
        public n36.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector3> __p_SWIkU7KhfjULxifMNAgsQ0;
        [n1.ElementAttribute(TracingId = 342907U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QmQ6lW8Sp1fOGT4917fisG", Name = "__slot_QmQ6lW8Sp1fOGT4917fisG")]
        public static string __slot_QmQ6lW8Sp1fOGT4917fisG = "Pressure";
        [n1.ElementAttribute(TracingId = 342857U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KpI3avTfQbsPdyEdZXwCtk", Name = "__slot_KpI3avTfQbsPdyEdZXwCtk")]
        public static string __slot_KpI3avTfQbsPdyEdZXwCtk = "Pressure";
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n34.ImmutableLifetimeManager __loop_KBLlBmibYnwMuRxL6LtNQT;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n33.IGraphicsRendererBase> __cp_QSdwLAFdRswM1JjxZvGPwg;
        [n1.ElementAttribute(TracingId = 342920U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TSAucCmLd55OJID9OCIrzQ", Name = "Group (Spectral)", IsManaged = true, IsAutoGenerated = true)]
        public n35.GraphicsRendererGroup __p_TSAucCmLd55OJID9OCIrzQ;
        static ComputePressure_PKuggOQZFoROUYZK0IglqE()
        {
        }

        public ComputePressure_PKuggOQZFoROUYZK0IglqE(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ComputePressure_PKuggOQZFoROUYZK0IglqE(ComputePressure_PKuggOQZFoROUYZK0IglqE other): base(other)
        {
            this.__slot_AdoC4n0UIzNPCUknBDluxh = other.__slot_AdoC4n0UIzNPCUknBDluxh;
            this.__p_SWIkU7KhfjULxifMNAgsQ0 = other.__p_SWIkU7KhfjULxifMNAgsQ0;
            this.__loop_KBLlBmibYnwMuRxL6LtNQT = other.__loop_KBLlBmibYnwMuRxL6LtNQT;
            this.__cp_QSdwLAFdRswM1JjxZvGPwg = other.__cp_QSdwLAFdRswM1JjxZvGPwg;
            this.__p_TSAucCmLd55OJID9OCIrzQ = other.__p_TSAucCmLd55OJID9OCIrzQ;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_AdoC4n0UIzNPCUknBDluxh", in __slot_AdoC4n0UIzNPCUknBDluxh), n1.CompilationHelper.GetValueOrExisting(values, "__p_SWIkU7KhfjULxifMNAgsQ0", in __p_SWIkU7KhfjULxifMNAgsQ0), n1.CompilationHelper.GetValueOrExisting(values, "__loop_KBLlBmibYnwMuRxL6LtNQT", in __loop_KBLlBmibYnwMuRxL6LtNQT), n1.CompilationHelper.GetValueOrExisting(values, "__cp_QSdwLAFdRswM1JjxZvGPwg", in __cp_QSdwLAFdRswM1JjxZvGPwg), n1.CompilationHelper.GetValueOrExisting(values, "__p_TSAucCmLd55OJID9OCIrzQ", in __p_TSAucCmLd55OJID9OCIrzQ));
        }

        internal ComputePressure_PKuggOQZFoROUYZK0IglqE __WITH__(int __slot_AdoC4n0UIzNPCUknBDluxh, n36.FrameDifference_UGiMzXJ8Pe3NmV2nXH2LpH<n6.Vector3> __p_SWIkU7KhfjULxifMNAgsQ0, n34.ImmutableLifetimeManager __loop_KBLlBmibYnwMuRxL6LtNQT, n12.Spread<n33.IGraphicsRendererBase> __cp_QSdwLAFdRswM1JjxZvGPwg, n35.GraphicsRendererGroup __p_TSAucCmLd55OJID9OCIrzQ)
        {
            n4.ComputePressure_PKuggOQZFoROUYZK0IglqE that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_AdoC4n0UIzNPCUknBDluxh != this.__slot_AdoC4n0UIzNPCUknBDluxh || __p_SWIkU7KhfjULxifMNAgsQ0 != this.__p_SWIkU7KhfjULxifMNAgsQ0 || __loop_KBLlBmibYnwMuRxL6LtNQT != this.__loop_KBLlBmibYnwMuRxL6LtNQT || __cp_QSdwLAFdRswM1JjxZvGPwg != this.__cp_QSdwLAFdRswM1JjxZvGPwg || __p_TSAucCmLd55OJID9OCIrzQ != this.__p_TSAucCmLd55OJID9OCIrzQ ? new ComputePressure_PKuggOQZFoROUYZK0IglqE(this)
                {__slot_AdoC4n0UIzNPCUknBDluxh = __slot_AdoC4n0UIzNPCUknBDluxh, __p_SWIkU7KhfjULxifMNAgsQ0 = __p_SWIkU7KhfjULxifMNAgsQ0, __loop_KBLlBmibYnwMuRxL6LtNQT = __loop_KBLlBmibYnwMuRxL6LtNQT, __cp_QSdwLAFdRswM1JjxZvGPwg = __cp_QSdwLAFdRswM1JjxZvGPwg, __p_TSAucCmLd55OJID9OCIrzQ = __p_TSAucCmLd55OJID9OCIrzQ} : that_0;
            else
            {
                this.__slot_AdoC4n0UIzNPCUknBDluxh = __slot_AdoC4n0UIzNPCUknBDluxh;
                this.__p_SWIkU7KhfjULxifMNAgsQ0 = __p_SWIkU7KhfjULxifMNAgsQ0;
                this.__loop_KBLlBmibYnwMuRxL6LtNQT = __loop_KBLlBmibYnwMuRxL6LtNQT;
                this.__cp_QSdwLAFdRswM1JjxZvGPwg = __cp_QSdwLAFdRswM1JjxZvGPwg;
                this.__p_TSAucCmLd55OJID9OCIrzQ = __p_TSAucCmLd55OJID9OCIrzQ;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CpqWChKRop6PR2c7fryPMM", Name = "__CpqWChKRop6PR2c7fryPMM")]
        [n2.SerializableAttribute]
        public class __CpqWChKRop6PR2c7fryPMM : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_OzXEj1HCbaKLHNzuSe0K5k);
                n1.CompilationHelper.SafeDispose(this.__p_NLpMK3ykoxsQFpmpFKju6h);
                return;
            }

            [n1.ElementAttribute(TracingId = 342734U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OzXEj1HCbaKLHNzuSe0K5k", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
            public n1.IVLNode __p_OzXEj1HCbaKLHNzuSe0K5k;
            [n1.ElementAttribute(TracingId = 342748U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NLpMK3ykoxsQFpmpFKju6h", Name = "Fluid3DComputePressureShader", IsManaged = true, IsAutoGenerated = true, NodeName = "Fluid3DComputePressureShader (Internal)", NodeCategory = "Stride.Rendering.ComputeShaders")]
            public n1.IVLNode __p_NLpMK3ykoxsQFpmpFKju6h;
            public __CpqWChKRop6PR2c7fryPMM(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CpqWChKRop6PR2c7fryPMM(__CpqWChKRop6PR2c7fryPMM other): base(other)
            {
                this.__p_OzXEj1HCbaKLHNzuSe0K5k = other.__p_OzXEj1HCbaKLHNzuSe0K5k;
                this.__p_NLpMK3ykoxsQFpmpFKju6h = other.__p_NLpMK3ykoxsQFpmpFKju6h;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_OzXEj1HCbaKLHNzuSe0K5k", in __p_OzXEj1HCbaKLHNzuSe0K5k), n1.CompilationHelper.GetValueOrExisting(values, "__p_NLpMK3ykoxsQFpmpFKju6h", in __p_NLpMK3ykoxsQFpmpFKju6h));
            }

            internal __CpqWChKRop6PR2c7fryPMM __WITH__(n1.IVLNode __p_OzXEj1HCbaKLHNzuSe0K5k, n1.IVLNode __p_NLpMK3ykoxsQFpmpFKju6h)
            {
                __CpqWChKRop6PR2c7fryPMM that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_OzXEj1HCbaKLHNzuSe0K5k != this.__p_OzXEj1HCbaKLHNzuSe0K5k || __p_NLpMK3ykoxsQFpmpFKju6h != this.__p_NLpMK3ykoxsQFpmpFKju6h ? new __CpqWChKRop6PR2c7fryPMM(this)
                    {__p_OzXEj1HCbaKLHNzuSe0K5k = __p_OzXEj1HCbaKLHNzuSe0K5k, __p_NLpMK3ykoxsQFpmpFKju6h = __p_NLpMK3ykoxsQFpmpFKju6h} : that_0;
                else
                {
                    this.__p_OzXEj1HCbaKLHNzuSe0K5k = __p_OzXEj1HCbaKLHNzuSe0K5k;
                    this.__p_NLpMK3ykoxsQFpmpFKju6h = __p_NLpMK3ykoxsQFpmpFKju6h;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 343173U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LT01GLQcDnMMGGdprrdi46", Name = "ProjectVelocity_LT01GLQcDnMMGGdprrdi46")]
    [n2.SerializableAttribute]
    public class ProjectVelocity_LT01GLQcDnMMGGdprrdi46 : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.ProjectVelocity_LT01GLQcDnMMGGdprrdi46 Create(n1.NodeContext Node_Context)
        {
            var instance = new ProjectVelocity_LT01GLQcDnMMGGdprrdi46(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.ProjectVelocity_LT01GLQcDnMMGGdprrdi46 CreateDefault()
        {
            var instance = new ProjectVelocity_LT01GLQcDnMMGGdprrdi46(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.ProjectVelocity_LT01GLQcDnMMGGdprrdi46 Update(n4.FluidContext_C Context_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n33.IGraphicsRendererBase Layer_Out)
        {
            string __pad_TVcJCoQaraiPgHNVsrdPX3_0 = __slot_TVcJCoQaraiPgHNVsrdPX3;
            string __pad_IDJo4BBbSguLmrIWwexGkG_1 = __slot_IDJo4BBbSguLmrIWwexGkG;
            string __pad_G7x25x6tiWWMLBXSnvBRZp_2 = __slot_G7x25x6tiWWMLBXSnvBRZp;
            string __pad_IFABU3coFQ0Nj1yTECSNfE_3 = __slot_IFABU3coFQ0Nj1yTECSNfE;
            float __pad_KvlwcXYO42oPygnKA5kztr_4 = __slot_KvlwcXYO42oPygnKA5kztr;
            var Output_10 = Context_In.GetTextureWithName(Texture_Name_In: __pad_TVcJCoQaraiPgHNVsrdPX3_0, Texture_Read_Out: out n27.Texture Texture_Read_5, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_6, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_7, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_8, Found_Out: out bool Found_9);
            var Output_16 = Output_10.GetTextureWithName(Texture_Name_In: __pad_IDJo4BBbSguLmrIWwexGkG_1, Texture_Read_Out: out n27.Texture Texture_Read_11, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_12, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_13, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_14, Found_Out: out bool Found_15);
            var Output_22 = Output_16.GetTextureWithName(Texture_Name_In: __pad_G7x25x6tiWWMLBXSnvBRZp_2, Texture_Read_Out: out n27.Texture Texture_Read_17, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_18, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_19, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_20, Found_Out: out bool Found_21);
            var Output_28 = Output_22.GetTextureWithName(Texture_Name_In: __pad_IFABU3coFQ0Nj1yTECSNfE_3, Texture_Read_Out: out n27.Texture Texture_Read_23, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_24, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_25, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_26, Found_Out: out bool Found_27);
            var Output_31 = Context_In.GetDispatch(Thread_Group_Count_Out: out n6.Int3 Thread_Group_Count_29, Thread_Group_Size_Out: out n6.Int3 Thread_Group_Size_30);
            n1.CompilationHelper.WritePin(this.__p_CfQ5htGSDNjPakayrxu8Fx.Inputs[0], ref Thread_Group_Count_29);
            n1.CompilationHelper.ReadPin(this.__p_CfQ5htGSDNjPakayrxu8Fx.Outputs[0], out n32.IComputeEffectDispatcher out_32);
            n1.CompilationHelper.WritePin(this.__p_NezinVE14C0LRLMv10erRP.Inputs[0], ref out_32);
            n1.CompilationHelper.WritePin(this.__p_NezinVE14C0LRLMv10erRP.Inputs[1], ref Thread_Group_Size_30);
            n1.CompilationHelper.WritePin(this.__p_NezinVE14C0LRLMv10erRP.Inputs[2], ref Texture_Read_23);
            n1.CompilationHelper.WritePin(this.__p_NezinVE14C0LRLMv10erRP.Inputs[3], ref Texture_Read_17);
            n1.CompilationHelper.WritePin(this.__p_NezinVE14C0LRLMv10erRP.Inputs[4], ref Texture_Read_11);
            n1.CompilationHelper.WritePin(this.__p_NezinVE14C0LRLMv10erRP.Inputs[5], ref Texture_Read_5);
            n1.CompilationHelper.WritePin(this.__p_NezinVE14C0LRLMv10erRP.Inputs[6], ref Texture_ReadWrite_7);
            var Output_34 = Context_In.GetFluidTimeStep(Fluid_TimeStep_Out: out float Fluid_TimeStep_33);
            var Output_36 = Output_34.GetResolutionVector(Resolution_Out: out n6.Vector3 Resolution_35);
            n1.CompilationHelper.WritePin(this.__p_NezinVE14C0LRLMv10erRP.Inputs[7], ref Resolution_35);
            n1.CompilationHelper.WritePin(this.__p_NezinVE14C0LRLMv10erRP.Inputs[8], ref Fluid_TimeStep_33);
            n1.CompilationHelper.WritePin(this.__p_NezinVE14C0LRLMv10erRP.Inputs[9], ref __pad_KvlwcXYO42oPygnKA5kztr_4);
            n1.CompilationHelper.WritePin(this.__p_NezinVE14C0LRLMv10erRP.Inputs[10], ref Enabled_In);
            n1.CompilationHelper.ReadPin(this.__p_NezinVE14C0LRLMv10erRP.Outputs[0], out n33.IGraphicsRendererBase out_37);
            n33.IGraphicsRendererBase __auto_38;
            if (Enabled_In)
            {
                string __pad_F2NHDn3683IQUZWmKCBvEz_40 = __slot_F2NHDn3683IQUZWmKCBvEz;
                var Output_42 = Output_28.SwapPingPongTextureWithName(Texture_Name_In: __pad_F2NHDn3683IQUZWmKCBvEz_40, Found_Out: out bool Found_41);
                __auto_38 = out_37;
            }
            else
            {
                __auto_38 = out_37;
            }

            Layer_Out = __auto_38;
            n4.ProjectVelocity_LT01GLQcDnMMGGdprrdi46 that_43 = this;
            if (this.__GetContext__().IsImmutable)
                that_43 = this.__p_CfQ5htGSDNjPakayrxu8Fx != this.__p_CfQ5htGSDNjPakayrxu8Fx || this.__p_NezinVE14C0LRLMv10erRP != this.__p_NezinVE14C0LRLMv10erRP ? new ProjectVelocity_LT01GLQcDnMMGGdprrdi46(this)
                {__p_CfQ5htGSDNjPakayrxu8Fx = this.__p_CfQ5htGSDNjPakayrxu8Fx, __p_NezinVE14C0LRLMv10erRP = this.__p_NezinVE14C0LRLMv10erRP} : that_43;
            else
            {
                this.__p_CfQ5htGSDNjPakayrxu8Fx = this.__p_CfQ5htGSDNjPakayrxu8Fx;
                this.__p_NezinVE14C0LRLMv10erRP = this.__p_NezinVE14C0LRLMv10erRP;
            }

            return that_43;
        }

        public n4.ProjectVelocity_LT01GLQcDnMMGGdprrdi46 __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "Fluid3DProjectVelocityShader (Internal)", "Stride.Rendering.ComputeShaders");
            var node_1 = n1.CompilationHelper.CreateNodeById(Node_Context, "DirectDispatcher", "Stride.Rendering.Advanced");
            n4.ProjectVelocity_LT01GLQcDnMMGGdprrdi46 that_2 = this;
            this.__p_NezinVE14C0LRLMv10erRP = node_0;
            this.__p_CfQ5htGSDNjPakayrxu8Fx = node_1;
            return that_2;
        }

        public n4.ProjectVelocity_LT01GLQcDnMMGGdprrdi46 __CreateDefault__()
        {
            n4.ProjectVelocity_LT01GLQcDnMMGGdprrdi46 that_0 = this;
            this.__p_CfQ5htGSDNjPakayrxu8Fx = default(n1.IVLNode);
            this.__p_NezinVE14C0LRLMv10erRP = default(n1.IVLNode);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_CfQ5htGSDNjPakayrxu8Fx);
            n1.CompilationHelper.SafeDispose(this.__p_NezinVE14C0LRLMv10erRP);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 343325U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KvlwcXYO42oPygnKA5kztr", Name = "__slot_KvlwcXYO42oPygnKA5kztr")]
        public static float __slot_KvlwcXYO42oPygnKA5kztr = 1F;
        [n1.ElementAttribute(TracingId = 343374U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TVcJCoQaraiPgHNVsrdPX3", Name = "__slot_TVcJCoQaraiPgHNVsrdPX3")]
        public static string __slot_TVcJCoQaraiPgHNVsrdPX3 = "Velocity";
        [n1.ElementAttribute(TracingId = 343418U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IDJo4BBbSguLmrIWwexGkG", Name = "__slot_IDJo4BBbSguLmrIWwexGkG")]
        public static string __slot_IDJo4BBbSguLmrIWwexGkG = "Pressure";
        [n1.ElementAttribute(TracingId = 343439U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "G7x25x6tiWWMLBXSnvBRZp", Name = "__slot_G7x25x6tiWWMLBXSnvBRZp")]
        public static string __slot_G7x25x6tiWWMLBXSnvBRZp = "ObstaclesVelocity";
        [n1.ElementAttribute(TracingId = 343471U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IFABU3coFQ0Nj1yTECSNfE", Name = "__slot_IFABU3coFQ0Nj1yTECSNfE")]
        public static string __slot_IFABU3coFQ0Nj1yTECSNfE = "ObstaclesGradient";
        [n1.ElementAttribute(TracingId = 343246U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CfQ5htGSDNjPakayrxu8Fx", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
        public n1.IVLNode __p_CfQ5htGSDNjPakayrxu8Fx;
        [n1.ElementAttribute(TracingId = 343202U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NezinVE14C0LRLMv10erRP", Name = "Fluid3DProjectVelocityShader", IsManaged = true, IsAutoGenerated = true, NodeName = "Fluid3DProjectVelocityShader (Internal)", NodeCategory = "Stride.Rendering.ComputeShaders")]
        public n1.IVLNode __p_NezinVE14C0LRLMv10erRP;
        [n1.ElementAttribute(TracingId = 343319U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "F2NHDn3683IQUZWmKCBvEz", Name = "__slot_F2NHDn3683IQUZWmKCBvEz")]
        public static string __slot_F2NHDn3683IQUZWmKCBvEz = "Velocity";
        static ProjectVelocity_LT01GLQcDnMMGGdprrdi46()
        {
        }

        public ProjectVelocity_LT01GLQcDnMMGGdprrdi46(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ProjectVelocity_LT01GLQcDnMMGGdprrdi46(ProjectVelocity_LT01GLQcDnMMGGdprrdi46 other): base(other)
        {
            this.__p_CfQ5htGSDNjPakayrxu8Fx = other.__p_CfQ5htGSDNjPakayrxu8Fx;
            this.__p_NezinVE14C0LRLMv10erRP = other.__p_NezinVE14C0LRLMv10erRP;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_CfQ5htGSDNjPakayrxu8Fx", in __p_CfQ5htGSDNjPakayrxu8Fx), n1.CompilationHelper.GetValueOrExisting(values, "__p_NezinVE14C0LRLMv10erRP", in __p_NezinVE14C0LRLMv10erRP));
        }

        internal ProjectVelocity_LT01GLQcDnMMGGdprrdi46 __WITH__(n1.IVLNode __p_CfQ5htGSDNjPakayrxu8Fx, n1.IVLNode __p_NezinVE14C0LRLMv10erRP)
        {
            n4.ProjectVelocity_LT01GLQcDnMMGGdprrdi46 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_CfQ5htGSDNjPakayrxu8Fx != this.__p_CfQ5htGSDNjPakayrxu8Fx || __p_NezinVE14C0LRLMv10erRP != this.__p_NezinVE14C0LRLMv10erRP ? new ProjectVelocity_LT01GLQcDnMMGGdprrdi46(this)
                {__p_CfQ5htGSDNjPakayrxu8Fx = __p_CfQ5htGSDNjPakayrxu8Fx, __p_NezinVE14C0LRLMv10erRP = __p_NezinVE14C0LRLMv10erRP} : that_0;
            else
            {
                this.__p_CfQ5htGSDNjPakayrxu8Fx = __p_CfQ5htGSDNjPakayrxu8Fx;
                this.__p_NezinVE14C0LRLMv10erRP = __p_NezinVE14C0LRLMv10erRP;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 343611U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FtOG5ccNP9vNdxa3fpN81u", Name = "VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u")]
    [n2.SerializableAttribute]
    public class VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u Create(n1.NodeContext Node_Context)
        {
            var instance = new VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u CreateDefault()
        {
            var instance = new VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u Update(n27.Texture Volume_Texture_In, n6.Matrix Volume_Transformation_In, [n5.SerializedDefaultValueAttribute("0, 0, 0, 0", false)] n6.Color4 Color_In, [n5.SerializedDefaultValueAttribute("140", false)] uint Max_Steps_In, [n5.SerializedDefaultValueAttribute("0.08", false)] float Step_Size_In, [n5.SerializedDefaultValueAttribute("0.4", false)] float Opacity_In, [n5.SerializedDefaultValueAttribute("0.17", false)] float Offset_Z_In, [n5.SerializedDefaultValueAttribute("1", false)] float Gamma_In, n6.Matrix View_Projection_In, out n43.Entity Entity_Out)
        {
            n6.Vector2 __pad_DaGgXptnirbLCVp9dpmgV2_0 = __slot_DaGgXptnirbLCVp9dpmgV2;
            bool __pad_Rp6MOpc2jmdOvydGlZqzJC_1 = __slot_Rp6MOpc2jmdOvydGlZqzJC;
            bool __pad_SCjemnP79O9MIRjAVYZZeR_2 = __slot_SCjemnP79O9MIRjAVYZZeR;
            n1.CompilationHelper.WritePin(this.__p_SUEAjf6VeD4NbuOK3E7M3W.Inputs[1], ref Volume_Texture_In);
            n1.CompilationHelper.WritePin(this.__p_SUEAjf6VeD4NbuOK3E7M3W.Inputs[2], ref Color_In);
            n6.Matrix.Invert(value: ref Volume_Transformation_In, result: out n6.Matrix Output_3);
            n1.CompilationHelper.WritePin(this.__p_SUEAjf6VeD4NbuOK3E7M3W.Inputs[3], ref Output_3);
            n1.CompilationHelper.WritePin(this.__p_SUEAjf6VeD4NbuOK3E7M3W.Inputs[4], ref Max_Steps_In);
            n1.CompilationHelper.WritePin(this.__p_SUEAjf6VeD4NbuOK3E7M3W.Inputs[5], ref Step_Size_In);
            n1.CompilationHelper.WritePin(this.__p_SUEAjf6VeD4NbuOK3E7M3W.Inputs[6], ref Opacity_In);
            n1.CompilationHelper.WritePin(this.__p_SUEAjf6VeD4NbuOK3E7M3W.Inputs[7], ref Offset_Z_In);
            n1.CompilationHelper.WritePin(this.__p_SUEAjf6VeD4NbuOK3E7M3W.Inputs[8], ref Gamma_In);
            n6.Matrix Input_4 = n9._Operations_.CreateDefault();
            n6.Vector2 Translation_5 = n40._Operations_.CreateDefault();
            n41._Operations_.Translate(Input_In: Input_4, Translation_In: Translation_5, Output_Out: out n6.Matrix Output_6);
            n41._Operations_.Scale(Input_In: Output_6, Scaling_In: __pad_DaGgXptnirbLCVp9dpmgV2_0, Output_Out: out n6.Matrix Output_7);
            n1.CompilationHelper.WritePin(this.__p_SUEAjf6VeD4NbuOK3E7M3W.Inputs[9], ref Output_7);
            n1.CompilationHelper.ReadPin(this.__p_SUEAjf6VeD4NbuOK3E7M3W.Outputs[0], out n35.IEffect out_8);
            var Output_11 = this.__p_KdEeLmEhSgIN1OSM6vt49s.Update(Volume_Transformation_In: Volume_Transformation_In, View_Projection_In: View_Projection_In, Center_Out: out n6.Vector2 Center_9, Width_Out: out n6.Vector2 Width_10);
            bool SetEffect_12 = true;
            var Output_13 = this.__p_UU3u2MqDZecOSiWogi0D90;
            if (SetEffect_12)
            {
                Output_13 = this.__p_UU3u2MqDZecOSiWogi0D90.SetEffect(Effect_Instance_In: out_8);
            }

            var Alpha_Blend_14 = n42.BlendStateDescriptions.AlphaBlend;
            bool SetBlendState_15 = true;
            var Output_16 = Output_13;
            if (SetBlendState_15)
            {
                Output_16 = Output_13.SetBlendState(Blend_State_In: Alpha_Blend_14);
            }

            n1.CompilationHelper.WritePin(this.__p_ImWllwz2oeiMCFfK5jWpCO.Inputs[0], ref __pad_Rp6MOpc2jmdOvydGlZqzJC_1);
            n1.CompilationHelper.WritePin(this.__p_ImWllwz2oeiMCFfK5jWpCO.Inputs[1], ref __pad_SCjemnP79O9MIRjAVYZZeR_2);
            n1.CompilationHelper.ReadPin(this.__p_ImWllwz2oeiMCFfK5jWpCO.Outputs[0], out n27.DepthStencilStateDescription out_17);
            bool SetDepthStencilState_18 = true;
            var Output_19 = Output_16;
            if (SetDepthStencilState_18)
            {
                Output_19 = Output_16.SetDepthStencilState(Depth_Stencil_State_In: out_17);
            }

            n1.CompilationHelper.ReadPin(this.__p_PoCTgu0PSevQLqkKXy6tfI.Outputs[0], out n33.Mesh out_20);
            int Instance_Count_21 = 1;
            string Profiling_Name_22 = "Mesh Renderer";
            bool Update_23 = true;
            var Output_24 = Output_19;
            if (Update_23)
            {
                Output_24 = Output_19.Update(Mesh_In: out_20, Instance_Count_In: Instance_Count_21, Profiling_Name_In: Profiling_Name_22);
            }

            n33.IGraphicsRendererBase Input_25 = (n33.IGraphicsRendererBase)Output_24;
            n35.DrawerRenderStage Render_Stage_26 = __c_CqWpQjUpdXrN1SoNxqvlbU;
            bool Single_Call_Per_Frame_27 = false;
            bool SetupRendering_28 = true;
            var Output_29 = this.__p_Pm3Gz4JZAHUQNj4yvsEc9y;
            if (SetupRendering_28)
            {
                Output_29 = this.__p_Pm3Gz4JZAHUQNj4yvsEc9y.SetupRendering(Input_In: Input_25, Render_Stage_In: Render_Stage_26, Single_Call_Per_Frame_In: Single_Call_Per_Frame_27);
            }

            var State_Output_31 = Output_29.Update(Output_Out: out n43.Entity Output_30);
            Entity_Out = Output_30;
            n4.VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u that_32 = this;
            if (this.__GetContext__().IsImmutable)
                that_32 = this.__p_SUEAjf6VeD4NbuOK3E7M3W != this.__p_SUEAjf6VeD4NbuOK3E7M3W || Output_11 != this.__p_KdEeLmEhSgIN1OSM6vt49s || Output_24 != this.__p_UU3u2MqDZecOSiWogi0D90 || this.__p_ImWllwz2oeiMCFfK5jWpCO != this.__p_ImWllwz2oeiMCFfK5jWpCO || this.__p_PoCTgu0PSevQLqkKXy6tfI != this.__p_PoCTgu0PSevQLqkKXy6tfI || State_Output_31 != this.__p_Pm3Gz4JZAHUQNj4yvsEc9y ? new VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u(this)
                {__p_SUEAjf6VeD4NbuOK3E7M3W = this.__p_SUEAjf6VeD4NbuOK3E7M3W, __p_KdEeLmEhSgIN1OSM6vt49s = Output_11, __p_UU3u2MqDZecOSiWogi0D90 = Output_24, __p_ImWllwz2oeiMCFfK5jWpCO = this.__p_ImWllwz2oeiMCFfK5jWpCO, __p_PoCTgu0PSevQLqkKXy6tfI = this.__p_PoCTgu0PSevQLqkKXy6tfI, __p_Pm3Gz4JZAHUQNj4yvsEc9y = State_Output_31} : that_32;
            else
            {
                this.__p_SUEAjf6VeD4NbuOK3E7M3W = this.__p_SUEAjf6VeD4NbuOK3E7M3W;
                this.__p_KdEeLmEhSgIN1OSM6vt49s = Output_11;
                this.__p_UU3u2MqDZecOSiWogi0D90 = Output_24;
                this.__p_ImWllwz2oeiMCFfK5jWpCO = this.__p_ImWllwz2oeiMCFfK5jWpCO;
                this.__p_PoCTgu0PSevQLqkKXy6tfI = this.__p_PoCTgu0PSevQLqkKXy6tfI;
                this.__p_Pm3Gz4JZAHUQNj4yvsEc9y = State_Output_31;
            }

            return that_32;
        }

        public n4.VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Pm3Gz4JZAHUQNj4yvsEc9y", 343675U);
            var Output_1 = n44.RenderEntity_HYRtmvUkSb6PheJUi3kp3r.Create(Node_Context: Node_Context_0);
            var node_2 = n1.CompilationHelper.CreateNodeById(Node_Context, "DepthStencilStateDescription", "Stride.Graphics.Advanced");
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "UU3u2MqDZecOSiWogi0D90", 343783U);
            var Output_4 = n38.MeshRenderer_C.Create(Node_Context: Node_Context_3);
            var node_5 = n1.CompilationHelper.CreateNodeById(Node_Context, "PlaneMesh", "Stride.Models.Meshes");
            var node_6 = n1.CompilationHelper.CreateNodeById(Node_Context, "Fluid3DRaymarcherShader", "Stride.Rendering.DrawShaders");
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "KdEeLmEhSgIN1OSM6vt49s", 344581U);
            var Output_8 = n45.GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY.Create(Node_Context: Node_Context_7);
            n4.VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u that_9 = this;
            this.__p_Pm3Gz4JZAHUQNj4yvsEc9y = Output_1;
            this.__p_ImWllwz2oeiMCFfK5jWpCO = node_2;
            this.__p_UU3u2MqDZecOSiWogi0D90 = Output_4;
            this.__p_PoCTgu0PSevQLqkKXy6tfI = node_5;
            this.__p_SUEAjf6VeD4NbuOK3E7M3W = node_6;
            this.__p_KdEeLmEhSgIN1OSM6vt49s = Output_8;
            return that_9;
        }

        public n4.VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u __CreateDefault__()
        {
            n4.VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u that_0 = this;
            this.__p_SUEAjf6VeD4NbuOK3E7M3W = default(n1.IVLNode);
            this.__p_KdEeLmEhSgIN1OSM6vt49s = n45.GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY.CreateDefault();
            this.__p_UU3u2MqDZecOSiWogi0D90 = n38.MeshRenderer_C.CreateDefault();
            this.__p_ImWllwz2oeiMCFfK5jWpCO = default(n1.IVLNode);
            this.__p_PoCTgu0PSevQLqkKXy6tfI = default(n1.IVLNode);
            this.__p_Pm3Gz4JZAHUQNj4yvsEc9y = n44.RenderEntity_HYRtmvUkSb6PheJUi3kp3r.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SUEAjf6VeD4NbuOK3E7M3W);
            n1.CompilationHelper.SafeDispose(this.__p_KdEeLmEhSgIN1OSM6vt49s);
            n1.CompilationHelper.SafeDispose(this.__p_UU3u2MqDZecOSiWogi0D90);
            n1.CompilationHelper.SafeDispose(this.__p_ImWllwz2oeiMCFfK5jWpCO);
            n1.CompilationHelper.SafeDispose(this.__p_PoCTgu0PSevQLqkKXy6tfI);
            n1.CompilationHelper.SafeDispose(this.__p_Pm3Gz4JZAHUQNj4yvsEc9y);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 343644U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DaGgXptnirbLCVp9dpmgV2", Name = "__slot_DaGgXptnirbLCVp9dpmgV2")]
        public static n6.Vector2 __slot_DaGgXptnirbLCVp9dpmgV2 = n1.CompilationHelper.Deserialize<n6.Vector2>("1.97, 1.95", false, "KeWf79wIWCVN4a6TzD33r2", "DaGgXptnirbLCVp9dpmgV2");
        [n1.ElementAttribute(TracingId = 343706U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Rp6MOpc2jmdOvydGlZqzJC", Name = "__slot_Rp6MOpc2jmdOvydGlZqzJC")]
        public static bool __slot_Rp6MOpc2jmdOvydGlZqzJC = false;
        [n1.ElementAttribute(TracingId = 343769U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SCjemnP79O9MIRjAVYZZeR", Name = "__slot_SCjemnP79O9MIRjAVYZZeR")]
        public static bool __slot_SCjemnP79O9MIRjAVYZZeR = false;
        [n1.ElementAttribute(TracingId = 343839U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SUEAjf6VeD4NbuOK3E7M3W", Name = "Fluid3DRaymarcherShader", IsManaged = true, IsAutoGenerated = true, NodeName = "Fluid3DRaymarcherShader", NodeCategory = "Stride.Rendering.DrawShaders")]
        public n1.IVLNode __p_SUEAjf6VeD4NbuOK3E7M3W;
        [n1.ElementAttribute(TracingId = 344581U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KdEeLmEhSgIN1OSM6vt49s", Name = "GetScreenCoverageQuad", IsManaged = true, IsAutoGenerated = true)]
        public n45.GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY __p_KdEeLmEhSgIN1OSM6vt49s;
        [n1.ElementAttribute(TracingId = 343783U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UU3u2MqDZecOSiWogi0D90", Name = "MeshRenderer", IsManaged = true, IsAutoGenerated = true)]
        public n38.MeshRenderer_C __p_UU3u2MqDZecOSiWogi0D90;
        [n1.ElementAttribute(TracingId = 343725U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ImWllwz2oeiMCFfK5jWpCO", Name = "DepthStencilStateDescription", IsManaged = true, IsAutoGenerated = true, NodeName = "DepthStencilStateDescription", NodeCategory = "Stride.Graphics.Advanced")]
        public n1.IVLNode __p_ImWllwz2oeiMCFfK5jWpCO;
        [n1.ElementAttribute(TracingId = 343810U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "PoCTgu0PSevQLqkKXy6tfI", Name = "PlaneMesh", IsManaged = true, IsAutoGenerated = true, NodeName = "PlaneMesh", NodeCategory = "Stride.Models.Meshes")]
        public n1.IVLNode __p_PoCTgu0PSevQLqkKXy6tfI;
        [n1.ElementAttribute(TracingId = 343675U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Pm3Gz4JZAHUQNj4yvsEc9y", Name = "RenderEntity", IsManaged = true, IsAutoGenerated = true)]
        public n44.RenderEntity_HYRtmvUkSb6PheJUi3kp3r __p_Pm3Gz4JZAHUQNj4yvsEc9y;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n35.DrawerRenderStage __c_CqWpQjUpdXrN1SoNxqvlbU = n1.CompilationHelper.Deserialize<n35.DrawerRenderStage>("Opaque", false, "KeWf79wIWCVN4a6TzD33r2", "CqWpQjUpdXrN1SoNxqvlbU");
        static VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u()
        {
        }

        public VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u(VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u other): base(other)
        {
            this.__p_SUEAjf6VeD4NbuOK3E7M3W = other.__p_SUEAjf6VeD4NbuOK3E7M3W;
            this.__p_KdEeLmEhSgIN1OSM6vt49s = other.__p_KdEeLmEhSgIN1OSM6vt49s;
            this.__p_UU3u2MqDZecOSiWogi0D90 = other.__p_UU3u2MqDZecOSiWogi0D90;
            this.__p_ImWllwz2oeiMCFfK5jWpCO = other.__p_ImWllwz2oeiMCFfK5jWpCO;
            this.__p_PoCTgu0PSevQLqkKXy6tfI = other.__p_PoCTgu0PSevQLqkKXy6tfI;
            this.__p_Pm3Gz4JZAHUQNj4yvsEc9y = other.__p_Pm3Gz4JZAHUQNj4yvsEc9y;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_SUEAjf6VeD4NbuOK3E7M3W", in __p_SUEAjf6VeD4NbuOK3E7M3W), n1.CompilationHelper.GetValueOrExisting(values, "__p_KdEeLmEhSgIN1OSM6vt49s", in __p_KdEeLmEhSgIN1OSM6vt49s), n1.CompilationHelper.GetValueOrExisting(values, "__p_UU3u2MqDZecOSiWogi0D90", in __p_UU3u2MqDZecOSiWogi0D90), n1.CompilationHelper.GetValueOrExisting(values, "__p_ImWllwz2oeiMCFfK5jWpCO", in __p_ImWllwz2oeiMCFfK5jWpCO), n1.CompilationHelper.GetValueOrExisting(values, "__p_PoCTgu0PSevQLqkKXy6tfI", in __p_PoCTgu0PSevQLqkKXy6tfI), n1.CompilationHelper.GetValueOrExisting(values, "__p_Pm3Gz4JZAHUQNj4yvsEc9y", in __p_Pm3Gz4JZAHUQNj4yvsEc9y));
        }

        internal VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u __WITH__(n1.IVLNode __p_SUEAjf6VeD4NbuOK3E7M3W, n45.GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY __p_KdEeLmEhSgIN1OSM6vt49s, n38.MeshRenderer_C __p_UU3u2MqDZecOSiWogi0D90, n1.IVLNode __p_ImWllwz2oeiMCFfK5jWpCO, n1.IVLNode __p_PoCTgu0PSevQLqkKXy6tfI, n44.RenderEntity_HYRtmvUkSb6PheJUi3kp3r __p_Pm3Gz4JZAHUQNj4yvsEc9y)
        {
            n4.VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_SUEAjf6VeD4NbuOK3E7M3W != this.__p_SUEAjf6VeD4NbuOK3E7M3W || __p_KdEeLmEhSgIN1OSM6vt49s != this.__p_KdEeLmEhSgIN1OSM6vt49s || __p_UU3u2MqDZecOSiWogi0D90 != this.__p_UU3u2MqDZecOSiWogi0D90 || __p_ImWllwz2oeiMCFfK5jWpCO != this.__p_ImWllwz2oeiMCFfK5jWpCO || __p_PoCTgu0PSevQLqkKXy6tfI != this.__p_PoCTgu0PSevQLqkKXy6tfI || __p_Pm3Gz4JZAHUQNj4yvsEc9y != this.__p_Pm3Gz4JZAHUQNj4yvsEc9y ? new VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u(this)
                {__p_SUEAjf6VeD4NbuOK3E7M3W = __p_SUEAjf6VeD4NbuOK3E7M3W, __p_KdEeLmEhSgIN1OSM6vt49s = __p_KdEeLmEhSgIN1OSM6vt49s, __p_UU3u2MqDZecOSiWogi0D90 = __p_UU3u2MqDZecOSiWogi0D90, __p_ImWllwz2oeiMCFfK5jWpCO = __p_ImWllwz2oeiMCFfK5jWpCO, __p_PoCTgu0PSevQLqkKXy6tfI = __p_PoCTgu0PSevQLqkKXy6tfI, __p_Pm3Gz4JZAHUQNj4yvsEc9y = __p_Pm3Gz4JZAHUQNj4yvsEc9y} : that_0;
            else
            {
                this.__p_SUEAjf6VeD4NbuOK3E7M3W = __p_SUEAjf6VeD4NbuOK3E7M3W;
                this.__p_KdEeLmEhSgIN1OSM6vt49s = __p_KdEeLmEhSgIN1OSM6vt49s;
                this.__p_UU3u2MqDZecOSiWogi0D90 = __p_UU3u2MqDZecOSiWogi0D90;
                this.__p_ImWllwz2oeiMCFfK5jWpCO = __p_ImWllwz2oeiMCFfK5jWpCO;
                this.__p_PoCTgu0PSevQLqkKXy6tfI = __p_PoCTgu0PSevQLqkKXy6tfI;
                this.__p_Pm3Gz4JZAHUQNj4yvsEc9y = __p_Pm3Gz4JZAHUQNj4yvsEc9y;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 344722U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JpxxW5bjXm4NABtE3B6DIu", Name = "Fluid3D_JpxxW5bjXm4NABtE3B6DIu")]
    [n2.SerializableAttribute]
    public class Fluid3D_JpxxW5bjXm4NABtE3B6DIu : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu Create(n1.NodeContext Node_Context)
        {
            var instance = new Fluid3D_JpxxW5bjXm4NABtE3B6DIu(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu CreateDefault()
        {
            var instance = new Fluid3D_JpxxW5bjXm4NABtE3B6DIu(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu Update([n5.SerializedDefaultValueAttribute("True", false)] bool Simulation_Enabled_In, bool External_Renderer_Enabled_In, string Debug_Custom_Texture_Name_In, out n35.GraphicsRendererGroup Renderer_Out)
        {
            bool __pad_Qe9j6HYM5RKOWwohkYWFik_0 = this.__slot_Qe9j6HYM5RKOWwohkYWFik;
            bool __pad_JDC9Mei1mB1NAzeJwarMnG_1 = this.__slot_JDC9Mei1mB1NAzeJwarMnG;
            int __pad_JASdfoNDgYGLN109BlZnlW_2 = this.__slot_JASdfoNDgYGLN109BlZnlW;
            bool __pad_Ogw7HMepbGTQH57K8vAuM5_3 = __slot_Ogw7HMepbGTQH57K8vAuM5;
            var Output_4 = this.__p_HNHFRvsPyNzLYX2LbRLjOJ;
            n35.GraphicsRendererGroup __auto_5;
            var state_6 = n1.CompilationHelper.Restore<__FVZRU9kqSJFPHWnzdmZbT4>(this.__if_IicLuRXSntDNTPsDJpv5er, __GetContext__());
            if (Simulation_Enabled_In)
            {
                if (state_6 == null)
                {
                    state_6 = new __FVZRU9kqSJFPHWnzdmZbT4(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "MgzzVlamgE6Oo22YxGoF9x", 345569U);
                    var Output_8 = n4.AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT.Create(Node_Context: Node_Context_7);
                    state_6.__p_MgzzVlamgE6Oo22YxGoF9x = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "GpHjZfXpAVpNk4PCCqDCVs", 345590U);
                    var Output_10 = n4.VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r.Create(Node_Context: Node_Context_9);
                    state_6.__p_GpHjZfXpAVpNk4PCCqDCVs = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "NTDTsltZBWPNrdWcx4baeA", 345616U);
                    var Output_12 = n38.Group_JjpUJ7D6yd9L6tZwkMXdAR.Create(Node_Context: Node_Context_11);
                    state_6.__p_NTDTsltZBWPNrdWcx4baeA = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "F5aNRgYusgAPlbHwHwfOzu", 345629U);
                    var Output_14 = n4.Solver_DCf8AjjoTvONfK9Qflg1kn.Create(Node_Context: Node_Context_13);
                    state_6.__p_F5aNRgYusgAPlbHwHwfOzu = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "MOP3jjVX71KPHU1tHTqwBV", 345650U);
                    var Output_16 = n4.PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U.Create(Node_Context: Node_Context_15);
                    state_6.__p_MOP3jjVX71KPHU1tHTqwBV = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "CYTnPMC0SsaOdxwpnuv5Iq", 345656U);
                    var Output_18 = n4.PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw.Create(Node_Context: Node_Context_17);
                    state_6.__p_CYTnPMC0SsaOdxwpnuv5Iq = Output_18;
                }

                bool __pad_RvVK9V9NsbCOAeroQVPJyL_19 = __slot_RvVK9V9NsbCOAeroQVPJyL;
                bool __pad_Q0M3Qlxdi0ZLpAhV8jkhQS_20 = __slot_Q0M3Qlxdi0ZLpAhV8jkhQS;
                bool __pad_OEzhJinhdQNOn1rEzsGxDz_21 = __slot_OEzhJinhdQNOn1rEzsGxDz;
                var Output_23 = state_6.__p_MgzzVlamgE6Oo22YxGoF9x.Update(Context_In: Output_4, Enabled_In: __pad_RvVK9V9NsbCOAeroQVPJyL_19, Layer_Out: out n35.GraphicsRendererGroup Layer_22);
                n33.IGraphicsRendererBase Input_2_24 = (n33.IGraphicsRendererBase)Layer_22;
                var Output_26 = state_6.__p_MOP3jjVX71KPHU1tHTqwBV.Update(Context_In: Output_4, Dispatcher_Out: out n35.GraphicsRendererGroup Dispatcher_25);
                n33.IGraphicsRendererBase Input_27 = (n33.IGraphicsRendererBase)Dispatcher_25;
                var Output_29 = state_6.__p_GpHjZfXpAVpNk4PCCqDCVs.Update(Context_In: Output_4, Enabled_In: __pad_Q0M3Qlxdi0ZLpAhV8jkhQS_20, Layer_Out: out n35.GraphicsRendererGroup Layer_28);
                n33.IGraphicsRendererBase Input_3_30 = (n33.IGraphicsRendererBase)Layer_28;
                var Output_32 = state_6.__p_CYTnPMC0SsaOdxwpnuv5Iq.Update(Context_In: Output_4, Dispatcher_Out: out n35.GraphicsRendererGroup Dispatcher_31);
                n33.IGraphicsRendererBase Input_4_33 = (n33.IGraphicsRendererBase)Dispatcher_31;
                var Output_35 = state_6.__p_F5aNRgYusgAPlbHwHwfOzu.Update(Context_In: Output_4, Enabled_In: __pad_OEzhJinhdQNOn1rEzsGxDz_21, Layer_Out: out n35.GraphicsRendererGroup Layer_34);
                n33.IGraphicsRendererBase Input_5_36 = (n33.IGraphicsRendererBase)Layer_34;
                var builder_37 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA, 5);
                builder_37.Add(Input_27);
                builder_37.Add(Input_2_24);
                builder_37.Add(Input_3_30);
                builder_37.Add(Input_4_33);
                builder_37.Add(Input_5_36);
                var __pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA_38 = builder_37.Commit();
                var State_Output_40 = state_6.__p_NTDTsltZBWPNrdWcx4baeA.Update(Input_In: __pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA_38, Output_Out: out n35.GraphicsRendererGroup Output_39);
                __auto_5 = Output_39;
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = Output_23 != state_6.__p_MgzzVlamgE6Oo22YxGoF9x || Output_26 != state_6.__p_MOP3jjVX71KPHU1tHTqwBV || Output_29 != state_6.__p_GpHjZfXpAVpNk4PCCqDCVs || Output_32 != state_6.__p_CYTnPMC0SsaOdxwpnuv5Iq || Output_35 != state_6.__p_F5aNRgYusgAPlbHwHwfOzu || __pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA_38 != state_6.__pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA || State_Output_40 != state_6.__p_NTDTsltZBWPNrdWcx4baeA ? new __FVZRU9kqSJFPHWnzdmZbT4(state_6)
                    {__p_MgzzVlamgE6Oo22YxGoF9x = Output_23, __p_MOP3jjVX71KPHU1tHTqwBV = Output_26, __p_GpHjZfXpAVpNk4PCCqDCVs = Output_29, __p_CYTnPMC0SsaOdxwpnuv5Iq = Output_32, __p_F5aNRgYusgAPlbHwHwfOzu = Output_35, __pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA = __pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA_38, __p_NTDTsltZBWPNrdWcx4baeA = State_Output_40} : state_6;
                else
                {
                    state_6.__p_MgzzVlamgE6Oo22YxGoF9x = Output_23;
                    state_6.__p_MOP3jjVX71KPHU1tHTqwBV = Output_26;
                    state_6.__p_GpHjZfXpAVpNk4PCCqDCVs = Output_29;
                    state_6.__p_CYTnPMC0SsaOdxwpnuv5Iq = Output_32;
                    state_6.__p_F5aNRgYusgAPlbHwHwfOzu = Output_35;
                    state_6.__pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA = __pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA_38;
                    state_6.__p_NTDTsltZBWPNrdWcx4baeA = State_Output_40;
                }
            }
            else
            {
                __auto_5 = default(n35.GraphicsRendererGroup);
            }

            var Output_41 = !External_Renderer_Enabled_In;
            n35.GraphicsRendererGroup __auto_42;
            var state_43 = n1.CompilationHelper.Restore<__QJEOFBmQOlaLO47ayHDNbb>(this.__if_E3sU9817JxQNGL9Rnwr96b, __GetContext__());
            if (Output_41)
            {
                if (state_43 == null)
                {
                    state_43 = new __QJEOFBmQOlaLO47ayHDNbb(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_44 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "J0GeFGSo5xpLTdd3qWeLf3", 345520U);
                    var Output_45 = n46.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D.Create(Node_Context: Node_Context_44);
                    state_43.__p_J0GeFGSo5xpLTdd3qWeLf3 = Output_45;
                }

                n33.IGraphicsRendererBase Renderer_46 = (n33.IGraphicsRendererBase)__auto_5;
                bool Schedule_47 = true;
                var Output_48 = state_43.__p_J0GeFGSo5xpLTdd3qWeLf3;
                if (Schedule_47)
                {
                    Output_48 = state_43.__p_J0GeFGSo5xpLTdd3qWeLf3.Schedule(Renderer_In: Renderer_46);
                }

                if (state_43.__GetContext__().IsImmutable)
                    state_43 = Output_48 != state_43.__p_J0GeFGSo5xpLTdd3qWeLf3 ? new __QJEOFBmQOlaLO47ayHDNbb(state_43)
                    {__p_J0GeFGSo5xpLTdd3qWeLf3 = Output_48} : state_43;
                else
                {
                    state_43.__p_J0GeFGSo5xpLTdd3qWeLf3 = Output_48;
                }

                __auto_42 = default(n35.GraphicsRendererGroup);
            }
            else
            {
                __auto_42 = __auto_5;
            }

            n4.FluidContext_C __pad_N5lV8VbYN22ONW7cyoNNA2_49 = Output_4;
            n43.Entity __auto_50;
            var state_51 = n1.CompilationHelper.Restore<__JAx4oNg4O3WN9zwhzJAqrg>(this.__if_DjQf6yD1TPVLBVYRYQdvaB, __GetContext__());
            if (__pad_Qe9j6HYM5RKOWwohkYWFik_0)
            {
                if (state_51 == null)
                {
                    state_51 = new __JAx4oNg4O3WN9zwhzJAqrg(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_KXnnvchQMwtQBL008mXBs3 = n14._Operations_.CreateDefault<n43.Entity>(), __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF = n14._Operations_.CreateDefault<n43.Entity>()};
                    n1.NodeContext Node_Context_52 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "EWa7df88gc6MtaHul2kBpF", 345347U);
                    var Output_53 = n47.Group_TqwCZl6Gra4OmgvUg1POgm.Create(Node_Context: Node_Context_52);
                    state_51.__p_EWa7df88gc6MtaHul2kBpF = Output_53;
                    n1.NodeContext Node_Context_54 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Aif8g8ORZEOOasW3jL3wGB", 345401U);
                    var Output_55 = n48.BoxFrame_MdfNJXLlOjzMB5Tg5Xcmlc.Create(Node_Context: Node_Context_54);
                    state_51.__p_Aif8g8ORZEOOasW3jL3wGB = Output_55;
                    n1.NodeContext Node_Context_56 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "O0HcLisNyfqPuz9xcd8obB", 345489U);
                    var Output_57 = n47.Group_Spectral_OrFKGqkce2jOmqneI85BeX.Create(Node_Context: Node_Context_56);
                    state_51.__p_O0HcLisNyfqPuz9xcd8obB = Output_57;
                }

                n43.Entity __auto_58;
                var state_59 = n1.CompilationHelper.Restore<__QWvjqfcDcVAMM9FnfYF9sl>(state_51.__if_T6b499dYGSkNcFnIoK6YS6, __GetContext__());
                if (__pad_JDC9Mei1mB1NAzeJwarMnG_1)
                {
                    if (state_59 == null)
                    {
                        state_59 = new __QWvjqfcDcVAMM9FnfYF9sl(__GetContext__(), n1.VLObject.NewIdentity())
                        {__pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle = n14._Operations_.CreateDefault<n27.Texture>()};
                        n1.NodeContext Node_Context_60 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "RC2lolDp84ANTjQLenzzU5", 345068U);
                        var Output_61 = n4.VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u.Create(Node_Context: Node_Context_60);
                        state_59.__p_RC2lolDp84ANTjQLenzzU5 = Output_61;
                    }

                    string __pad_RRPcTlKZxGRPfOXDUMWBMC_62 = __slot_RRPcTlKZxGRPfOXDUMWBMC;
                    string __pad_PjFv8KB2NWbNkfZsZdtpK6_63 = __slot_PjFv8KB2NWbNkfZsZdtpK6;
                    string __pad_GRbRe1JklQDL3x4aMPSqBQ_64 = __slot_GRbRe1JklQDL3x4aMPSqBQ;
                    string __pad_Hfi2siLiriHMn1eqD3YK5p_65 = __slot_Hfi2siLiriHMn1eqD3YK5p;
                    string __pad_NPth3QpmRq8MLrcwMMuFcE_66 = __slot_NPth3QpmRq8MLrcwMMuFcE;
                    var Output_72 = __pad_N5lV8VbYN22ONW7cyoNNA2_49.GetTextureWithName(Texture_Name_In: __pad_RRPcTlKZxGRPfOXDUMWBMC_62, Texture_Read_Out: out n27.Texture Texture_Read_67, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_68, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_69, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_70, Found_Out: out bool Found_71);
                    var Output_78 = Output_72.GetTextureWithName(Texture_Name_In: __pad_PjFv8KB2NWbNkfZsZdtpK6_63, Texture_Read_Out: out n27.Texture Texture_Read_73, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_74, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_75, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_76, Found_Out: out bool Found_77);
                    var Output_84 = Output_78.GetTextureWithName(Texture_Name_In: __pad_GRbRe1JklQDL3x4aMPSqBQ_64, Texture_Read_Out: out n27.Texture Texture_Read_79, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_80, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_81, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_82, Found_Out: out bool Found_83);
                    var Output_90 = Output_84.GetTextureWithName(Texture_Name_In: __pad_Hfi2siLiriHMn1eqD3YK5p_65, Texture_Read_Out: out n27.Texture Texture_Read_85, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_86, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_87, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_88, Found_Out: out bool Found_89);
                    var Output_96 = Output_90.GetTextureWithName(Texture_Name_In: __pad_NPth3QpmRq8MLrcwMMuFcE_66, Texture_Read_Out: out n27.Texture Texture_Read_91, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_92, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_93, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_94, Found_Out: out bool Found_95);
                    var Output_102 = Output_96.GetTextureWithName(Texture_Name_In: Debug_Custom_Texture_Name_In, Texture_Read_Out: out n27.Texture Texture_Read_97, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_98, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_99, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_100, Found_Out: out bool Found_101);
                    var builder_103 = n5.CollectionBuilders.GetBuilder(state_59.__pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle, 6);
                    builder_103.Add(Texture_Read_67);
                    builder_103.Add(Texture_Read_73);
                    builder_103.Add(Texture_Read_79);
                    builder_103.Add(Texture_Read_85);
                    builder_103.Add(Texture_Read_91);
                    builder_103.Add(Texture_Read_97);
                    var __pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle_104 = builder_103.Commit();
                    n49._Operations_.Switch<n27.Texture, n31.__AdaptiveImplementations__KeWf79wIWCVN4a6TzD33r2>(Index_In: __pad_JASdfoNDgYGLN109BlZnlW_2, Input_In: __pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle_104, Output_Out: out n27.Texture Output_105);
                    var Output_108 = __pad_N5lV8VbYN22ONW7cyoNNA2_49.GetTransform(Transform_Out: out n6.Matrix Transform_106, Transform_Inverse_Out: out n6.Matrix Transform_Inverse_107);
                    n6.Color4 Color_109 = __c_J1wmA2VVa5wPhFioUSGQ6r;
                    uint Max_Steps_110 = 140U;
                    float Step_Size_111 = 0.08F;
                    float Opacity_112 = 0.4F;
                    float Offset_Z_113 = 0.17F;
                    float Gamma_114 = 1F;
                    n6.Matrix View_Projection_115 = n9._Operations_.CreateDefault();
                    var Output_117 = state_59.__p_RC2lolDp84ANTjQLenzzU5.Update(Volume_Texture_In: Output_105, Volume_Transformation_In: Transform_106, Color_In: Color_109, Max_Steps_In: Max_Steps_110, Step_Size_In: Step_Size_111, Opacity_In: Opacity_112, Offset_Z_In: Offset_Z_113, Gamma_In: Gamma_114, View_Projection_In: View_Projection_115, Entity_Out: out n43.Entity Entity_116);
                    __auto_58 = Entity_116;
                    if (state_59.__GetContext__().IsImmutable)
                        state_59 = __pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle_104 != state_59.__pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle || Output_117 != state_59.__p_RC2lolDp84ANTjQLenzzU5 ? new __QWvjqfcDcVAMM9FnfYF9sl(state_59)
                        {__pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle = __pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle_104, __p_RC2lolDp84ANTjQLenzzU5 = Output_117} : state_59;
                    else
                    {
                        state_59.__pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle = __pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle_104;
                        state_59.__p_RC2lolDp84ANTjQLenzzU5 = Output_117;
                    }
                }
                else
                {
                    __auto_58 = default(n43.Entity);
                }

                var Output_119 = __pad_N5lV8VbYN22ONW7cyoNNA2_49.GetComponents(Components_Out: out n12.Spread<n11.IFluidComponent_I> Components_118);
                var builder_131 = n5.CollectionBuilders.GetBuilder(state_51.__cp_KXnnvchQMwtQBL008mXBs3, 16);
                n12.Spread<n43.Entity> output_132;
                try
                {
                    var i_122 = 0;
                    foreach (var item_120 in n5.CollectionExtensions.AsSpan(Components_118))
                    {
                        var splicer_121 = item_120;
                        var i_local_123 = i_122;
                        var Output_126 = ((n11.IFluidComponent_I)splicer_121).GetHelperEnabled(Helper_Enabled_Out: out bool Helper_Enabled_125);
                        n43.Entity __auto_127;
                        if (Helper_Enabled_125)
                        {
                            var Output_130 = ((n11.IFluidComponent_I)Output_126).GetHelperEntity(Helper_Entity_Out: out n43.Entity Helper_Entity_129);
                            __auto_127 = Helper_Entity_129;
                        }
                        else
                        {
                            __auto_127 = default(n43.Entity);
                        }

                        builder_131.Add(__auto_127);
                        i_122++;
                    }
                }
                finally
                {
                    output_132 = builder_131.Commit();
                }

                bool SetEntities_133 = true;
                var Output_134 = state_51.__p_O0HcLisNyfqPuz9xcd8obB;
                if (SetEntities_133)
                {
                    Output_134 = state_51.__p_O0HcLisNyfqPuz9xcd8obB.SetEntities(Children_In: output_132);
                }

                var State_Output_136 = Output_134.Update(Output_Out: out n43.Entity Output_135);
                var Output_139 = __pad_N5lV8VbYN22ONW7cyoNNA2_49.GetTransform(Transform_Out: out n6.Matrix Transform_137, Transform_Inverse_Out: out n6.Matrix Transform_Inverse_138);
                n6.Color4 Color_140 = n50._Operations_.CreateDefault();
                bool Draw_Shadow_141 = false;
                bool Enabled_142 = true;
                var State_Output_144 = state_51.__p_Aif8g8ORZEOOasW3jL3wGB.Update(Transformation_In: Transform_137, Color_In: Color_140, Draw_Shadow_In: Draw_Shadow_141, Enabled_In: Enabled_142, Output_Out: out n43.Entity Output_143);
                bool SetChildren_145 = true;
                var builder_146 = n5.CollectionBuilders.GetBuilder(state_51.__pin_group_Child_In_EWa7df88gc6MtaHul2kBpF, 3);
                builder_146.Add(Output_135);
                builder_146.Add(Output_143);
                builder_146.Add(__auto_58);
                var __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF_147 = builder_146.Commit();
                var Output_148 = state_51.__p_EWa7df88gc6MtaHul2kBpF;
                if (SetChildren_145)
                {
                    Output_148 = state_51.__p_EWa7df88gc6MtaHul2kBpF.SetChildren(Child_In: __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF_147);
                }

                var State_Output_150 = Output_148.Update(Output_Out: out n43.Entity Output_149);
                __auto_50 = Output_149;
                if (state_51.__GetContext__().IsImmutable)
                    state_51 = state_59 != state_51.__if_T6b499dYGSkNcFnIoK6YS6 || output_132 != state_51.__cp_KXnnvchQMwtQBL008mXBs3 || State_Output_136 != state_51.__p_O0HcLisNyfqPuz9xcd8obB || State_Output_144 != state_51.__p_Aif8g8ORZEOOasW3jL3wGB || __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF_147 != state_51.__pin_group_Child_In_EWa7df88gc6MtaHul2kBpF || State_Output_150 != state_51.__p_EWa7df88gc6MtaHul2kBpF ? new __JAx4oNg4O3WN9zwhzJAqrg(state_51)
                    {__if_T6b499dYGSkNcFnIoK6YS6 = state_59, __cp_KXnnvchQMwtQBL008mXBs3 = output_132, __p_O0HcLisNyfqPuz9xcd8obB = State_Output_136, __p_Aif8g8ORZEOOasW3jL3wGB = State_Output_144, __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF = __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF_147, __p_EWa7df88gc6MtaHul2kBpF = State_Output_150} : state_51;
                else
                {
                    state_51.__if_T6b499dYGSkNcFnIoK6YS6 = state_59;
                    state_51.__cp_KXnnvchQMwtQBL008mXBs3 = output_132;
                    state_51.__p_O0HcLisNyfqPuz9xcd8obB = State_Output_136;
                    state_51.__p_Aif8g8ORZEOOasW3jL3wGB = State_Output_144;
                    state_51.__pin_group_Child_In_EWa7df88gc6MtaHul2kBpF = __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF_147;
                    state_51.__p_EWa7df88gc6MtaHul2kBpF = State_Output_150;
                }
            }
            else
            {
                __auto_50 = default(n43.Entity);
            }

            n43.Entity __pad_HZC5IQcCTkbPxQJC07YpbS_151 = __auto_50;
            var state_152 = n1.CompilationHelper.Restore<__PpZf0vjJoZTNX05qD0GjGd>(this.__if_Dy0WZT1IfP2L5hJKTO9Eib, __GetContext__());
            if (__pad_Ogw7HMepbGTQH57K8vAuM5_3)
            {
                if (state_152 == null)
                {
                    state_152 = new __PpZf0vjJoZTNX05qD0GjGd(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_153 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "QQG5W1ZzkipMlUUB5GQ0U0", 344815U);
                    var Output_154 = n51.ReadBackTexture_GQP3tvG4YN6Nq4eGbxf7kT<float>.Create(Node_Context: Node_Context_153);
                    state_152.__p_QQG5W1ZzkipMlUUB5GQ0U0 = Output_154;
                }

                int __pad_NehE0DZopHCNqjpcMBntkj_155 = __slot_NehE0DZopHCNqjpcMBntkj;
                string __pad_CbbscHH8LetLx77CYafM9M_156 = __slot_CbbscHH8LetLx77CYafM9M;
                int Input_2_157 = 4;
                var Output_158 = __pad_NehE0DZopHCNqjpcMBntkj_155 * Input_2_157;
                int Input_2_159 = 0;
                var Output_160 = Output_158 + Input_2_159;
                var Output_166 = Output_4.GetTextureWithName(Texture_Name_In: __pad_CbbscHH8LetLx77CYafM9M_156, Texture_Read_Out: out n27.Texture Texture_Read_161, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_162, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_163, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_164, Found_Out: out bool Found_165);
                int Frame_Delay_167 = 3;
                bool Auto_Draw_168 = true;
                var State_Output_174 = state_152.__p_QQG5W1ZzkipMlUUB5GQ0U0.Update(Input_In: Texture_Read_161, Frame_Delay_In: Frame_Delay_167, Auto_Draw_In: Auto_Draw_168, Output_Out: out float[] Output_169, Result_Available_Out: out bool Result_Available_170, Is_Blocking_Out: out bool Is_Blocking_171, Readback_Time_Out: out float Readback_Time_172, Renderer_Out: out n33.IGraphicsRendererBase Renderer_173);
                var state_175 = n1.CompilationHelper.Restore<__CHV7i3ra23WPztv8DooaRk>(state_152.__if_FDxRpVumrgLQaK1eRq4PnY, __GetContext__());
                if (Result_Available_170)
                {
                    if (state_175 == null)
                    {
                        state_175 = new __CHV7i3ra23WPztv8DooaRk(__GetContext__(), n1.VLObject.NewIdentity());
                    }

                    n52._Operations_.GetItem<float>(Input_In: Output_169, Index_In: Output_160, Output_Out: out float[] Output_176, Item_Out: out float Item_177);
                    float __pad_ECYJsGU7dPFMCUGS9xL58z_178 = Item_177;
                    if (state_175.__GetContext__().IsImmutable)
                        state_175 = Item_177 != state_175.__slot_ECYJsGU7dPFMCUGS9xL58z ? new __CHV7i3ra23WPztv8DooaRk(state_175)
                        {__slot_ECYJsGU7dPFMCUGS9xL58z = Item_177} : state_175;
                    else
                    {
                        state_175.__slot_ECYJsGU7dPFMCUGS9xL58z = Item_177;
                    }
                }

                if (state_152.__GetContext__().IsImmutable)
                    state_152 = State_Output_174 != state_152.__p_QQG5W1ZzkipMlUUB5GQ0U0 || state_175 != state_152.__if_FDxRpVumrgLQaK1eRq4PnY ? new __PpZf0vjJoZTNX05qD0GjGd(state_152)
                    {__p_QQG5W1ZzkipMlUUB5GQ0U0 = State_Output_174, __if_FDxRpVumrgLQaK1eRq4PnY = state_175} : state_152;
                else
                {
                    state_152.__p_QQG5W1ZzkipMlUUB5GQ0U0 = State_Output_174;
                    state_152.__if_FDxRpVumrgLQaK1eRq4PnY = state_175;
                }
            }

            Renderer_Out = __auto_42;
            n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu that_179 = this;
            if (this.__GetContext__().IsImmutable)
                that_179 = state_6 != this.__if_IicLuRXSntDNTPsDJpv5er || state_43 != this.__if_E3sU9817JxQNGL9Rnwr96b || Output_4 != this.__slot_N5lV8VbYN22ONW7cyoNNA2 || state_51 != this.__if_DjQf6yD1TPVLBVYRYQdvaB || __auto_50 != this.__slot_HZC5IQcCTkbPxQJC07YpbS || state_152 != this.__if_Dy0WZT1IfP2L5hJKTO9Eib ? new Fluid3D_JpxxW5bjXm4NABtE3B6DIu(this)
                {__if_IicLuRXSntDNTPsDJpv5er = state_6, __if_E3sU9817JxQNGL9Rnwr96b = state_43, __slot_N5lV8VbYN22ONW7cyoNNA2 = Output_4, __if_DjQf6yD1TPVLBVYRYQdvaB = state_51, __slot_HZC5IQcCTkbPxQJC07YpbS = __auto_50, __if_Dy0WZT1IfP2L5hJKTO9Eib = state_152} : that_179;
            else
            {
                this.__if_IicLuRXSntDNTPsDJpv5er = state_6;
                this.__if_E3sU9817JxQNGL9Rnwr96b = state_43;
                this.__slot_N5lV8VbYN22ONW7cyoNNA2 = Output_4;
                this.__if_DjQf6yD1TPVLBVYRYQdvaB = state_51;
                this.__slot_HZC5IQcCTkbPxQJC07YpbS = __auto_50;
                this.__if_Dy0WZT1IfP2L5hJKTO9Eib = state_152;
            }

            return that_179;
        }

        public n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu GetContext(out n4.FluidContext_C Fluid_Context_Out)
        {
            var Output_0 = this.__p_HNHFRvsPyNzLYX2LbRLjOJ;
            Fluid_Context_Out = Output_0;
            return this;
        }

        public n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu Configure(n6.Matrix Transform_In, [n5.SerializedDefaultValueAttribute("128, 128, 128", false)] n6.Int3 Resolution_In, [n5.SerializedDefaultValueAttribute("1", false)] float Fluid_TimeStep_In, [n5.SerializedDefaultValueAttribute("1", false)] float Velocity_Mult_In, [n5.SerializedDefaultValueAttribute("6", false)] int Jacobi_Iterations_In, [n5.SerializedDefaultValueAttribute("0.06", false)] float Vorticity_Strength_In, n12.Spread<n11.IFluidComponent_I> Components_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Volume_Raymarching_Helper_Enabled_In, int Raymarching_Fluid_Texture_Index_In, bool Helper_Enabled_In)
        {
            bool __pad_MVT7R0sgYxNOVQIwMOcaYS_0 = __slot_MVT7R0sgYxNOVQIwMOcaYS;
            bool Configure_1 = true;
            var Output_2 = this.__p_HNHFRvsPyNzLYX2LbRLjOJ;
            if (Configure_1)
            {
                Output_2 = this.__p_HNHFRvsPyNzLYX2LbRLjOJ.Configure(Resolution_In: Resolution_In, Transform_In: Transform_In, Fluid_TimeStep_In: Fluid_TimeStep_In, Velocity_Modulate_In: Velocity_Mult_In, Jacobi_Iterations_In: Jacobi_Iterations_In, Vorticity_Strength_In: Vorticity_Strength_In, Components_In: Components_In);
            }

            var Output_3 = Output_2;
            if (__pad_MVT7R0sgYxNOVQIwMOcaYS_0)
            {
                Output_3 = Output_2.Update();
            }

            bool __pad_JDC9Mei1mB1NAzeJwarMnG_4 = Volume_Raymarching_Helper_Enabled_In;
            int __pad_JASdfoNDgYGLN109BlZnlW_5 = Raymarching_Fluid_Texture_Index_In;
            bool __pad_Qe9j6HYM5RKOWwohkYWFik_6 = Helper_Enabled_In;
            n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu that_7 = this;
            if (this.__GetContext__().IsImmutable)
                that_7 = Output_3 != this.__p_HNHFRvsPyNzLYX2LbRLjOJ || Volume_Raymarching_Helper_Enabled_In != this.__slot_JDC9Mei1mB1NAzeJwarMnG || Raymarching_Fluid_Texture_Index_In != this.__slot_JASdfoNDgYGLN109BlZnlW || Helper_Enabled_In != this.__slot_Qe9j6HYM5RKOWwohkYWFik ? new Fluid3D_JpxxW5bjXm4NABtE3B6DIu(this)
                {__p_HNHFRvsPyNzLYX2LbRLjOJ = Output_3, __slot_JDC9Mei1mB1NAzeJwarMnG = Volume_Raymarching_Helper_Enabled_In, __slot_JASdfoNDgYGLN109BlZnlW = Raymarching_Fluid_Texture_Index_In, __slot_Qe9j6HYM5RKOWwohkYWFik = Helper_Enabled_In} : that_7;
            else
            {
                this.__p_HNHFRvsPyNzLYX2LbRLjOJ = Output_3;
                this.__slot_JDC9Mei1mB1NAzeJwarMnG = Volume_Raymarching_Helper_Enabled_In;
                this.__slot_JASdfoNDgYGLN109BlZnlW = Raymarching_Fluid_Texture_Index_In;
                this.__slot_Qe9j6HYM5RKOWwohkYWFik = Helper_Enabled_In;
            }

            return that_7;
        }

        public n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu Reset()
        {
            bool __pad_VK1jHcWMjQVMscR2AkSHlM_0 = __slot_VK1jHcWMjQVMscR2AkSHlM;
            var Output_1 = this.__p_HNHFRvsPyNzLYX2LbRLjOJ;
            if (__pad_VK1jHcWMjQVMscR2AkSHlM_0)
            {
                Output_1 = this.__p_HNHFRvsPyNzLYX2LbRLjOJ.Reset();
            }

            n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_HNHFRvsPyNzLYX2LbRLjOJ ? new Fluid3D_JpxxW5bjXm4NABtE3B6DIu(this)
                {__p_HNHFRvsPyNzLYX2LbRLjOJ = Output_1} : that_2;
            else
            {
                this.__p_HNHFRvsPyNzLYX2LbRLjOJ = Output_1;
            }

            return that_2;
        }

        public n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu GetVelocityTexture(out n27.Texture Velocity_Texture_Out)
        {
            string __pad_LqksPSCXP6fM5j2Ihu7XmL_0 = __slot_LqksPSCXP6fM5j2Ihu7XmL;
            var Output_1 = this.__p_HNHFRvsPyNzLYX2LbRLjOJ;
            var Output_7 = Output_1.GetTextureWithName(Texture_Name_In: __pad_LqksPSCXP6fM5j2Ihu7XmL_0, Texture_Read_Out: out n27.Texture Texture_Read_2, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_3, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_4, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_5, Found_Out: out bool Found_6);
            Velocity_Texture_Out = Texture_Read_2;
            return this;
        }

        public n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu GetPressureTexture(out n27.Texture Pressure_Texture_Out)
        {
            string __pad_TRulIHmk0OzPe74UZgsBsU_0 = __slot_TRulIHmk0OzPe74UZgsBsU;
            var Output_1 = this.__p_HNHFRvsPyNzLYX2LbRLjOJ;
            var Output_7 = Output_1.GetTextureWithName(Texture_Name_In: __pad_TRulIHmk0OzPe74UZgsBsU_0, Texture_Read_Out: out n27.Texture Texture_Read_2, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_3, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_4, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_5, Found_Out: out bool Found_6);
            Pressure_Texture_Out = Texture_Read_2;
            return this;
        }

        public n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu GetObstaclesGradientTexture(out n27.Texture Obstacles_Gradient_Texture_Out)
        {
            string __pad_CTRLPnTVDNvLcCLNiv4HGq_0 = __slot_CTRLPnTVDNvLcCLNiv4HGq;
            var Output_1 = this.__p_HNHFRvsPyNzLYX2LbRLjOJ;
            var Output_7 = Output_1.GetTextureWithName(Texture_Name_In: __pad_CTRLPnTVDNvLcCLNiv4HGq_0, Texture_Read_Out: out n27.Texture Texture_Read_2, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_3, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_4, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_5, Found_Out: out bool Found_6);
            Obstacles_Gradient_Texture_Out = Texture_Read_2;
            return this;
        }

        public n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu GetVorticityTexture(out n27.Texture Vorticity_Texture_Out)
        {
            string __pad_OVi1QiFhaBhOSNTtIDtvoQ_0 = __slot_OVi1QiFhaBhOSNTtIDtvoQ;
            var Output_1 = this.__p_HNHFRvsPyNzLYX2LbRLjOJ;
            var Output_7 = Output_1.GetTextureWithName(Texture_Name_In: __pad_OVi1QiFhaBhOSNTtIDtvoQ_0, Texture_Read_Out: out n27.Texture Texture_Read_2, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_3, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_4, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_5, Found_Out: out bool Found_6);
            Vorticity_Texture_Out = Texture_Read_2;
            return this;
        }

        public n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu GetDivergenceTexture(out n27.Texture Divergence_Texture_Out)
        {
            string __pad_HbsHWW4QYbYPofJfCzwnZu_0 = __slot_HbsHWW4QYbYPofJfCzwnZu;
            var Output_1 = this.__p_HNHFRvsPyNzLYX2LbRLjOJ;
            var Output_7 = Output_1.GetTextureWithName(Texture_Name_In: __pad_HbsHWW4QYbYPofJfCzwnZu_0, Texture_Read_Out: out n27.Texture Texture_Read_2, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_3, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_4, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_5, Found_Out: out bool Found_6);
            Divergence_Texture_Out = Texture_Read_2;
            return this;
        }

        public n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu GetObstaclesVelocityTexture(out n27.Texture Obstacles_Velocity_Texture_Out)
        {
            string __pad_RmoA79qG7DTOnINBfrzbik_0 = __slot_RmoA79qG7DTOnINBfrzbik;
            var Output_1 = this.__p_HNHFRvsPyNzLYX2LbRLjOJ;
            var Output_7 = Output_1.GetTextureWithName(Texture_Name_In: __pad_RmoA79qG7DTOnINBfrzbik_0, Texture_Read_Out: out n27.Texture Texture_Read_2, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_3, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_4, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_5, Found_Out: out bool Found_6);
            Obstacles_Velocity_Texture_Out = Texture_Read_2;
            return this;
        }

        public n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu GetHelperEntity(out n43.Entity Helper_Entity_Out)
        {
            n43.Entity __pad_HZC5IQcCTkbPxQJC07YpbS_0 = this.__slot_HZC5IQcCTkbPxQJC07YpbS;
            Helper_Entity_Out = __pad_HZC5IQcCTkbPxQJC07YpbS_0;
            return this;
        }

        public n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "HNHFRvsPyNzLYX2LbRLjOJ", 344730U);
            var Output_1 = n4.FluidContext_C.Create(Node_Context: Node_Context_0);
            n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu that_2 = this;
            this.__slot_N5lV8VbYN22ONW7cyoNNA2 = n4.FluidContext_C.CreateDefault();
            this.__slot_JDC9Mei1mB1NAzeJwarMnG = false;
            this.__slot_JASdfoNDgYGLN109BlZnlW = 0;
            this.__slot_Qe9j6HYM5RKOWwohkYWFik = false;
            this.__slot_HZC5IQcCTkbPxQJC07YpbS = default(n43.Entity);
            this.__p_HNHFRvsPyNzLYX2LbRLjOJ = Output_1;
            this.__if_IicLuRXSntDNTPsDJpv5er = default(n2.Object);
            this.__if_E3sU9817JxQNGL9Rnwr96b = default(n2.Object);
            this.__if_DjQf6yD1TPVLBVYRYQdvaB = default(n2.Object);
            this.__if_Dy0WZT1IfP2L5hJKTO9Eib = default(n2.Object);
            return that_2;
        }

        public n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu __CreateDefault__()
        {
            n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu that_0 = this;
            this.__slot_N5lV8VbYN22ONW7cyoNNA2 = n4.FluidContext_C.CreateDefault();
            this.__slot_JDC9Mei1mB1NAzeJwarMnG = false;
            this.__slot_JASdfoNDgYGLN109BlZnlW = 0;
            this.__slot_Qe9j6HYM5RKOWwohkYWFik = false;
            this.__slot_HZC5IQcCTkbPxQJC07YpbS = default(n43.Entity);
            this.__p_HNHFRvsPyNzLYX2LbRLjOJ = n4.FluidContext_C.CreateDefault();
            this.__if_IicLuRXSntDNTPsDJpv5er = default(n2.Object);
            this.__if_E3sU9817JxQNGL9Rnwr96b = default(n2.Object);
            this.__if_DjQf6yD1TPVLBVYRYQdvaB = default(n2.Object);
            this.__if_Dy0WZT1IfP2L5hJKTO9Eib = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_HNHFRvsPyNzLYX2LbRLjOJ);
            n1.CompilationHelper.SafeDispose(this.__if_IicLuRXSntDNTPsDJpv5er);
            n1.CompilationHelper.SafeDispose(this.__if_E3sU9817JxQNGL9Rnwr96b);
            n1.CompilationHelper.SafeDispose(this.__if_DjQf6yD1TPVLBVYRYQdvaB);
            n1.CompilationHelper.SafeDispose(this.__if_Dy0WZT1IfP2L5hJKTO9Eib);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 344891U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Ogw7HMepbGTQH57K8vAuM5", Name = "__slot_Ogw7HMepbGTQH57K8vAuM5")]
        public static bool __slot_Ogw7HMepbGTQH57K8vAuM5 = false;
        [n1.ElementAttribute(TracingId = 344901U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "N5lV8VbYN22ONW7cyoNNA2", Name = "__slot_N5lV8VbYN22ONW7cyoNNA2")]
        public n4.FluidContext_C __slot_N5lV8VbYN22ONW7cyoNNA2;
        [n1.ElementAttribute(TracingId = 344905U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VK1jHcWMjQVMscR2AkSHlM", Name = "__slot_VK1jHcWMjQVMscR2AkSHlM")]
        public static bool __slot_VK1jHcWMjQVMscR2AkSHlM = true;
        [n1.ElementAttribute(TracingId = 344913U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MVT7R0sgYxNOVQIwMOcaYS", Name = "__slot_MVT7R0sgYxNOVQIwMOcaYS")]
        public static bool __slot_MVT7R0sgYxNOVQIwMOcaYS = true;
        [n1.ElementAttribute(TracingId = 345003U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JDC9Mei1mB1NAzeJwarMnG", Name = "__slot_JDC9Mei1mB1NAzeJwarMnG")]
        public bool __slot_JDC9Mei1mB1NAzeJwarMnG;
        [n1.ElementAttribute(TracingId = 345019U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JASdfoNDgYGLN109BlZnlW", Name = "__slot_JASdfoNDgYGLN109BlZnlW")]
        public int __slot_JASdfoNDgYGLN109BlZnlW;
        [n1.ElementAttribute(TracingId = 345020U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Qe9j6HYM5RKOWwohkYWFik", Name = "__slot_Qe9j6HYM5RKOWwohkYWFik")]
        public bool __slot_Qe9j6HYM5RKOWwohkYWFik;
        [n1.ElementAttribute(TracingId = 345506U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "HZC5IQcCTkbPxQJC07YpbS", Name = "__slot_HZC5IQcCTkbPxQJC07YpbS")]
        public n43.Entity __slot_HZC5IQcCTkbPxQJC07YpbS;
        [n1.ElementAttribute(TracingId = 345670U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LqksPSCXP6fM5j2Ihu7XmL", Name = "__slot_LqksPSCXP6fM5j2Ihu7XmL")]
        public static string __slot_LqksPSCXP6fM5j2Ihu7XmL = "Velocity";
        [n1.ElementAttribute(TracingId = 345671U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TRulIHmk0OzPe74UZgsBsU", Name = "__slot_TRulIHmk0OzPe74UZgsBsU")]
        public static string __slot_TRulIHmk0OzPe74UZgsBsU = "Pressure";
        [n1.ElementAttribute(TracingId = 345688U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OVi1QiFhaBhOSNTtIDtvoQ", Name = "__slot_OVi1QiFhaBhOSNTtIDtvoQ")]
        public static string __slot_OVi1QiFhaBhOSNTtIDtvoQ = "Vorticity";
        [n1.ElementAttribute(TracingId = 345706U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "HbsHWW4QYbYPofJfCzwnZu", Name = "__slot_HbsHWW4QYbYPofJfCzwnZu")]
        public static string __slot_HbsHWW4QYbYPofJfCzwnZu = "Divergence";
        [n1.ElementAttribute(TracingId = 345728U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CTRLPnTVDNvLcCLNiv4HGq", Name = "__slot_CTRLPnTVDNvLcCLNiv4HGq")]
        public static string __slot_CTRLPnTVDNvLcCLNiv4HGq = "ObstaclesGradient";
        [n1.ElementAttribute(TracingId = 345754U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RmoA79qG7DTOnINBfrzbik", Name = "__slot_RmoA79qG7DTOnINBfrzbik")]
        public static string __slot_RmoA79qG7DTOnINBfrzbik = "ObstaclesVelocity";
        [n1.ElementAttribute(TracingId = 344730U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "HNHFRvsPyNzLYX2LbRLjOJ", Name = "FluidContext", IsManaged = true, IsAutoGenerated = true)]
        public n4.FluidContext_C __p_HNHFRvsPyNzLYX2LbRLjOJ;
        [n1.ElementAttribute(TracingId = 345638U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RvVK9V9NsbCOAeroQVPJyL", Name = "__slot_RvVK9V9NsbCOAeroQVPJyL")]
        public static bool __slot_RvVK9V9NsbCOAeroQVPJyL = true;
        [n1.ElementAttribute(TracingId = 345641U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Q0M3Qlxdi0ZLpAhV8jkhQS", Name = "__slot_Q0M3Qlxdi0ZLpAhV8jkhQS")]
        public static bool __slot_Q0M3Qlxdi0ZLpAhV8jkhQS = true;
        [n1.ElementAttribute(TracingId = 345647U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OEzhJinhdQNOn1rEzsGxDz", Name = "__slot_OEzhJinhdQNOn1rEzsGxDz")]
        public static bool __slot_OEzhJinhdQNOn1rEzsGxDz = true;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_IicLuRXSntDNTPsDJpv5er;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_E3sU9817JxQNGL9Rnwr96b;
        [n1.ElementAttribute(TracingId = 345150U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RRPcTlKZxGRPfOXDUMWBMC", Name = "__slot_RRPcTlKZxGRPfOXDUMWBMC")]
        public static string __slot_RRPcTlKZxGRPfOXDUMWBMC = "Velocity";
        [n1.ElementAttribute(TracingId = 345184U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "PjFv8KB2NWbNkfZsZdtpK6", Name = "__slot_PjFv8KB2NWbNkfZsZdtpK6")]
        public static string __slot_PjFv8KB2NWbNkfZsZdtpK6 = "Pressure";
        [n1.ElementAttribute(TracingId = 345215U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GRbRe1JklQDL3x4aMPSqBQ", Name = "__slot_GRbRe1JklQDL3x4aMPSqBQ")]
        public static string __slot_GRbRe1JklQDL3x4aMPSqBQ = "ObstaclesGradient";
        [n1.ElementAttribute(TracingId = 345262U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Hfi2siLiriHMn1eqD3YK5p", Name = "__slot_Hfi2siLiriHMn1eqD3YK5p")]
        public static string __slot_Hfi2siLiriHMn1eqD3YK5p = "ObstaclesVelocity";
        [n1.ElementAttribute(TracingId = 345291U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NPth3QpmRq8MLrcwMMuFcE", Name = "__slot_NPth3QpmRq8MLrcwMMuFcE")]
        public static string __slot_NPth3QpmRq8MLrcwMMuFcE = "Vorticity";
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.Color4 __c_J1wmA2VVa5wPhFioUSGQ6r = n1.CompilationHelper.Deserialize<n6.Color4>("0, 0, 0, 0", false, "KeWf79wIWCVN4a6TzD33r2", "J1wmA2VVa5wPhFioUSGQ6r");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_DjQf6yD1TPVLBVYRYQdvaB;
        [n1.ElementAttribute(TracingId = 344784U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NehE0DZopHCNqjpcMBntkj", Name = "__slot_NehE0DZopHCNqjpcMBntkj")]
        public static int __slot_NehE0DZopHCNqjpcMBntkj = 847;
        [n1.ElementAttribute(TracingId = 344889U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CbbscHH8LetLx77CYafM9M", Name = "__slot_CbbscHH8LetLx77CYafM9M")]
        public static string __slot_CbbscHH8LetLx77CYafM9M = "Velocity";
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_Dy0WZT1IfP2L5hJKTO9Eib;
        static Fluid3D_JpxxW5bjXm4NABtE3B6DIu()
        {
        }

        public Fluid3D_JpxxW5bjXm4NABtE3B6DIu(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Fluid3D_JpxxW5bjXm4NABtE3B6DIu(Fluid3D_JpxxW5bjXm4NABtE3B6DIu other): base(other)
        {
            this.__slot_N5lV8VbYN22ONW7cyoNNA2 = other.__slot_N5lV8VbYN22ONW7cyoNNA2;
            this.__slot_JDC9Mei1mB1NAzeJwarMnG = other.__slot_JDC9Mei1mB1NAzeJwarMnG;
            this.__slot_JASdfoNDgYGLN109BlZnlW = other.__slot_JASdfoNDgYGLN109BlZnlW;
            this.__slot_Qe9j6HYM5RKOWwohkYWFik = other.__slot_Qe9j6HYM5RKOWwohkYWFik;
            this.__slot_HZC5IQcCTkbPxQJC07YpbS = other.__slot_HZC5IQcCTkbPxQJC07YpbS;
            this.__p_HNHFRvsPyNzLYX2LbRLjOJ = other.__p_HNHFRvsPyNzLYX2LbRLjOJ;
            this.__if_IicLuRXSntDNTPsDJpv5er = other.__if_IicLuRXSntDNTPsDJpv5er;
            this.__if_E3sU9817JxQNGL9Rnwr96b = other.__if_E3sU9817JxQNGL9Rnwr96b;
            this.__if_DjQf6yD1TPVLBVYRYQdvaB = other.__if_DjQf6yD1TPVLBVYRYQdvaB;
            this.__if_Dy0WZT1IfP2L5hJKTO9Eib = other.__if_Dy0WZT1IfP2L5hJKTO9Eib;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_N5lV8VbYN22ONW7cyoNNA2", in __slot_N5lV8VbYN22ONW7cyoNNA2), n1.CompilationHelper.GetValueOrExisting(values, "__slot_JDC9Mei1mB1NAzeJwarMnG", in __slot_JDC9Mei1mB1NAzeJwarMnG), n1.CompilationHelper.GetValueOrExisting(values, "__slot_JASdfoNDgYGLN109BlZnlW", in __slot_JASdfoNDgYGLN109BlZnlW), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Qe9j6HYM5RKOWwohkYWFik", in __slot_Qe9j6HYM5RKOWwohkYWFik), n1.CompilationHelper.GetValueOrExisting(values, "__slot_HZC5IQcCTkbPxQJC07YpbS", in __slot_HZC5IQcCTkbPxQJC07YpbS), n1.CompilationHelper.GetValueOrExisting(values, "__p_HNHFRvsPyNzLYX2LbRLjOJ", in __p_HNHFRvsPyNzLYX2LbRLjOJ), n1.CompilationHelper.GetValueOrExisting(values, "__if_IicLuRXSntDNTPsDJpv5er", in __if_IicLuRXSntDNTPsDJpv5er), n1.CompilationHelper.GetValueOrExisting(values, "__if_E3sU9817JxQNGL9Rnwr96b", in __if_E3sU9817JxQNGL9Rnwr96b), n1.CompilationHelper.GetValueOrExisting(values, "__if_DjQf6yD1TPVLBVYRYQdvaB", in __if_DjQf6yD1TPVLBVYRYQdvaB), n1.CompilationHelper.GetValueOrExisting(values, "__if_Dy0WZT1IfP2L5hJKTO9Eib", in __if_Dy0WZT1IfP2L5hJKTO9Eib));
        }

        internal Fluid3D_JpxxW5bjXm4NABtE3B6DIu __WITH__(n4.FluidContext_C __slot_N5lV8VbYN22ONW7cyoNNA2, bool __slot_JDC9Mei1mB1NAzeJwarMnG, int __slot_JASdfoNDgYGLN109BlZnlW, bool __slot_Qe9j6HYM5RKOWwohkYWFik, n43.Entity __slot_HZC5IQcCTkbPxQJC07YpbS, n4.FluidContext_C __p_HNHFRvsPyNzLYX2LbRLjOJ, n2.Object __if_IicLuRXSntDNTPsDJpv5er, n2.Object __if_E3sU9817JxQNGL9Rnwr96b, n2.Object __if_DjQf6yD1TPVLBVYRYQdvaB, n2.Object __if_Dy0WZT1IfP2L5hJKTO9Eib)
        {
            n4.Fluid3D_JpxxW5bjXm4NABtE3B6DIu that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_N5lV8VbYN22ONW7cyoNNA2 != this.__slot_N5lV8VbYN22ONW7cyoNNA2 || __slot_JDC9Mei1mB1NAzeJwarMnG != this.__slot_JDC9Mei1mB1NAzeJwarMnG || __slot_JASdfoNDgYGLN109BlZnlW != this.__slot_JASdfoNDgYGLN109BlZnlW || __slot_Qe9j6HYM5RKOWwohkYWFik != this.__slot_Qe9j6HYM5RKOWwohkYWFik || __slot_HZC5IQcCTkbPxQJC07YpbS != this.__slot_HZC5IQcCTkbPxQJC07YpbS || __p_HNHFRvsPyNzLYX2LbRLjOJ != this.__p_HNHFRvsPyNzLYX2LbRLjOJ || __if_IicLuRXSntDNTPsDJpv5er != this.__if_IicLuRXSntDNTPsDJpv5er || __if_E3sU9817JxQNGL9Rnwr96b != this.__if_E3sU9817JxQNGL9Rnwr96b || __if_DjQf6yD1TPVLBVYRYQdvaB != this.__if_DjQf6yD1TPVLBVYRYQdvaB || __if_Dy0WZT1IfP2L5hJKTO9Eib != this.__if_Dy0WZT1IfP2L5hJKTO9Eib ? new Fluid3D_JpxxW5bjXm4NABtE3B6DIu(this)
                {__slot_N5lV8VbYN22ONW7cyoNNA2 = __slot_N5lV8VbYN22ONW7cyoNNA2, __slot_JDC9Mei1mB1NAzeJwarMnG = __slot_JDC9Mei1mB1NAzeJwarMnG, __slot_JASdfoNDgYGLN109BlZnlW = __slot_JASdfoNDgYGLN109BlZnlW, __slot_Qe9j6HYM5RKOWwohkYWFik = __slot_Qe9j6HYM5RKOWwohkYWFik, __slot_HZC5IQcCTkbPxQJC07YpbS = __slot_HZC5IQcCTkbPxQJC07YpbS, __p_HNHFRvsPyNzLYX2LbRLjOJ = __p_HNHFRvsPyNzLYX2LbRLjOJ, __if_IicLuRXSntDNTPsDJpv5er = __if_IicLuRXSntDNTPsDJpv5er, __if_E3sU9817JxQNGL9Rnwr96b = __if_E3sU9817JxQNGL9Rnwr96b, __if_DjQf6yD1TPVLBVYRYQdvaB = __if_DjQf6yD1TPVLBVYRYQdvaB, __if_Dy0WZT1IfP2L5hJKTO9Eib = __if_Dy0WZT1IfP2L5hJKTO9Eib} : that_0;
            else
            {
                this.__slot_N5lV8VbYN22ONW7cyoNNA2 = __slot_N5lV8VbYN22ONW7cyoNNA2;
                this.__slot_JDC9Mei1mB1NAzeJwarMnG = __slot_JDC9Mei1mB1NAzeJwarMnG;
                this.__slot_JASdfoNDgYGLN109BlZnlW = __slot_JASdfoNDgYGLN109BlZnlW;
                this.__slot_Qe9j6HYM5RKOWwohkYWFik = __slot_Qe9j6HYM5RKOWwohkYWFik;
                this.__slot_HZC5IQcCTkbPxQJC07YpbS = __slot_HZC5IQcCTkbPxQJC07YpbS;
                this.__p_HNHFRvsPyNzLYX2LbRLjOJ = __p_HNHFRvsPyNzLYX2LbRLjOJ;
                this.__if_IicLuRXSntDNTPsDJpv5er = __if_IicLuRXSntDNTPsDJpv5er;
                this.__if_E3sU9817JxQNGL9Rnwr96b = __if_E3sU9817JxQNGL9Rnwr96b;
                this.__if_DjQf6yD1TPVLBVYRYQdvaB = __if_DjQf6yD1TPVLBVYRYQdvaB;
                this.__if_Dy0WZT1IfP2L5hJKTO9Eib = __if_Dy0WZT1IfP2L5hJKTO9Eib;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FVZRU9kqSJFPHWnzdmZbT4", Name = "__FVZRU9kqSJFPHWnzdmZbT4")]
        [n2.SerializableAttribute]
        public class __FVZRU9kqSJFPHWnzdmZbT4 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_MgzzVlamgE6Oo22YxGoF9x);
                n1.CompilationHelper.SafeDispose(this.__p_GpHjZfXpAVpNk4PCCqDCVs);
                n1.CompilationHelper.SafeDispose(this.__p_NTDTsltZBWPNrdWcx4baeA);
                n1.CompilationHelper.SafeDispose(this.__p_F5aNRgYusgAPlbHwHwfOzu);
                n1.CompilationHelper.SafeDispose(this.__p_MOP3jjVX71KPHU1tHTqwBV);
                n1.CompilationHelper.SafeDispose(this.__p_CYTnPMC0SsaOdxwpnuv5Iq);
                return;
            }

            [n1.ElementAttribute(TracingId = 345569U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MgzzVlamgE6Oo22YxGoF9x", Name = "AdvectTextures", IsManaged = true, IsAutoGenerated = true)]
            public n4.AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT __p_MgzzVlamgE6Oo22YxGoF9x;
            [n1.ElementAttribute(TracingId = 345590U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GpHjZfXpAVpNk4PCCqDCVs", Name = "VorticityConfinement", IsManaged = true, IsAutoGenerated = true)]
            public n4.VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r __p_GpHjZfXpAVpNk4PCCqDCVs;
            [n1.ElementAttribute(TracingId = 345616U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NTDTsltZBWPNrdWcx4baeA", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n38.Group_JjpUJ7D6yd9L6tZwkMXdAR __p_NTDTsltZBWPNrdWcx4baeA;
            [n1.ElementAttribute(TracingId = 345629U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "F5aNRgYusgAPlbHwHwfOzu", Name = "Solver", IsManaged = true, IsAutoGenerated = true)]
            public n4.Solver_DCf8AjjoTvONfK9Qflg1kn __p_F5aNRgYusgAPlbHwHwfOzu;
            [n1.ElementAttribute(TracingId = 345650U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MOP3jjVX71KPHU1tHTqwBV", Name = "PreTexAdvectionComponentsProcessor", IsManaged = true, IsAutoGenerated = true)]
            public n4.PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U __p_MOP3jjVX71KPHU1tHTqwBV;
            [n1.ElementAttribute(TracingId = 345656U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CYTnPMC0SsaOdxwpnuv5Iq", Name = "PostTexAdvectionComponentsProcessor", IsManaged = true, IsAutoGenerated = true)]
            public n4.PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw __p_CYTnPMC0SsaOdxwpnuv5Iq;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n33.IGraphicsRendererBase> __pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA = default(n12.Spread<n33.IGraphicsRendererBase>);
            public __FVZRU9kqSJFPHWnzdmZbT4(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __FVZRU9kqSJFPHWnzdmZbT4(__FVZRU9kqSJFPHWnzdmZbT4 other): base(other)
            {
                this.__p_MgzzVlamgE6Oo22YxGoF9x = other.__p_MgzzVlamgE6Oo22YxGoF9x;
                this.__p_GpHjZfXpAVpNk4PCCqDCVs = other.__p_GpHjZfXpAVpNk4PCCqDCVs;
                this.__p_NTDTsltZBWPNrdWcx4baeA = other.__p_NTDTsltZBWPNrdWcx4baeA;
                this.__p_F5aNRgYusgAPlbHwHwfOzu = other.__p_F5aNRgYusgAPlbHwHwfOzu;
                this.__p_MOP3jjVX71KPHU1tHTqwBV = other.__p_MOP3jjVX71KPHU1tHTqwBV;
                this.__p_CYTnPMC0SsaOdxwpnuv5Iq = other.__p_CYTnPMC0SsaOdxwpnuv5Iq;
                this.__pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA = other.__pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MgzzVlamgE6Oo22YxGoF9x", in __p_MgzzVlamgE6Oo22YxGoF9x), n1.CompilationHelper.GetValueOrExisting(values, "__p_GpHjZfXpAVpNk4PCCqDCVs", in __p_GpHjZfXpAVpNk4PCCqDCVs), n1.CompilationHelper.GetValueOrExisting(values, "__p_NTDTsltZBWPNrdWcx4baeA", in __p_NTDTsltZBWPNrdWcx4baeA), n1.CompilationHelper.GetValueOrExisting(values, "__p_F5aNRgYusgAPlbHwHwfOzu", in __p_F5aNRgYusgAPlbHwHwfOzu), n1.CompilationHelper.GetValueOrExisting(values, "__p_MOP3jjVX71KPHU1tHTqwBV", in __p_MOP3jjVX71KPHU1tHTqwBV), n1.CompilationHelper.GetValueOrExisting(values, "__p_CYTnPMC0SsaOdxwpnuv5Iq", in __p_CYTnPMC0SsaOdxwpnuv5Iq), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA", in __pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA));
            }

            internal __FVZRU9kqSJFPHWnzdmZbT4 __WITH__(n4.AdvectTextures_MbnxuqwYLx3Lt60BnWYJoT __p_MgzzVlamgE6Oo22YxGoF9x, n4.VorticityConfinement_QB31UUFJVMJOy4MkIkqs7r __p_GpHjZfXpAVpNk4PCCqDCVs, n38.Group_JjpUJ7D6yd9L6tZwkMXdAR __p_NTDTsltZBWPNrdWcx4baeA, n4.Solver_DCf8AjjoTvONfK9Qflg1kn __p_F5aNRgYusgAPlbHwHwfOzu, n4.PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U __p_MOP3jjVX71KPHU1tHTqwBV, n4.PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw __p_CYTnPMC0SsaOdxwpnuv5Iq, n12.Spread<n33.IGraphicsRendererBase> __pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA)
            {
                __FVZRU9kqSJFPHWnzdmZbT4 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_MgzzVlamgE6Oo22YxGoF9x != this.__p_MgzzVlamgE6Oo22YxGoF9x || __p_GpHjZfXpAVpNk4PCCqDCVs != this.__p_GpHjZfXpAVpNk4PCCqDCVs || __p_NTDTsltZBWPNrdWcx4baeA != this.__p_NTDTsltZBWPNrdWcx4baeA || __p_F5aNRgYusgAPlbHwHwfOzu != this.__p_F5aNRgYusgAPlbHwHwfOzu || __p_MOP3jjVX71KPHU1tHTqwBV != this.__p_MOP3jjVX71KPHU1tHTqwBV || __p_CYTnPMC0SsaOdxwpnuv5Iq != this.__p_CYTnPMC0SsaOdxwpnuv5Iq || __pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA != this.__pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA ? new __FVZRU9kqSJFPHWnzdmZbT4(this)
                    {__p_MgzzVlamgE6Oo22YxGoF9x = __p_MgzzVlamgE6Oo22YxGoF9x, __p_GpHjZfXpAVpNk4PCCqDCVs = __p_GpHjZfXpAVpNk4PCCqDCVs, __p_NTDTsltZBWPNrdWcx4baeA = __p_NTDTsltZBWPNrdWcx4baeA, __p_F5aNRgYusgAPlbHwHwfOzu = __p_F5aNRgYusgAPlbHwHwfOzu, __p_MOP3jjVX71KPHU1tHTqwBV = __p_MOP3jjVX71KPHU1tHTqwBV, __p_CYTnPMC0SsaOdxwpnuv5Iq = __p_CYTnPMC0SsaOdxwpnuv5Iq, __pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA = __pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA} : that_0;
                else
                {
                    this.__p_MgzzVlamgE6Oo22YxGoF9x = __p_MgzzVlamgE6Oo22YxGoF9x;
                    this.__p_GpHjZfXpAVpNk4PCCqDCVs = __p_GpHjZfXpAVpNk4PCCqDCVs;
                    this.__p_NTDTsltZBWPNrdWcx4baeA = __p_NTDTsltZBWPNrdWcx4baeA;
                    this.__p_F5aNRgYusgAPlbHwHwfOzu = __p_F5aNRgYusgAPlbHwHwfOzu;
                    this.__p_MOP3jjVX71KPHU1tHTqwBV = __p_MOP3jjVX71KPHU1tHTqwBV;
                    this.__p_CYTnPMC0SsaOdxwpnuv5Iq = __p_CYTnPMC0SsaOdxwpnuv5Iq;
                    this.__pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA = __pin_group_Input_In_NTDTsltZBWPNrdWcx4baeA;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QJEOFBmQOlaLO47ayHDNbb", Name = "__QJEOFBmQOlaLO47ayHDNbb")]
        [n2.SerializableAttribute]
        public class __QJEOFBmQOlaLO47ayHDNbb : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_J0GeFGSo5xpLTdd3qWeLf3);
                return;
            }

            [n1.ElementAttribute(TracingId = 345520U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "J0GeFGSo5xpLTdd3qWeLf3", Name = "RendererScheduler", IsManaged = true, IsAutoGenerated = true)]
            public n46.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D __p_J0GeFGSo5xpLTdd3qWeLf3;
            public __QJEOFBmQOlaLO47ayHDNbb(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __QJEOFBmQOlaLO47ayHDNbb(__QJEOFBmQOlaLO47ayHDNbb other): base(other)
            {
                this.__p_J0GeFGSo5xpLTdd3qWeLf3 = other.__p_J0GeFGSo5xpLTdd3qWeLf3;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_J0GeFGSo5xpLTdd3qWeLf3", in __p_J0GeFGSo5xpLTdd3qWeLf3));
            }

            internal __QJEOFBmQOlaLO47ayHDNbb __WITH__(n46.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D __p_J0GeFGSo5xpLTdd3qWeLf3)
            {
                __QJEOFBmQOlaLO47ayHDNbb that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_J0GeFGSo5xpLTdd3qWeLf3 != this.__p_J0GeFGSo5xpLTdd3qWeLf3 ? new __QJEOFBmQOlaLO47ayHDNbb(this)
                    {__p_J0GeFGSo5xpLTdd3qWeLf3 = __p_J0GeFGSo5xpLTdd3qWeLf3} : that_0;
                else
                {
                    this.__p_J0GeFGSo5xpLTdd3qWeLf3 = __p_J0GeFGSo5xpLTdd3qWeLf3;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JAx4oNg4O3WN9zwhzJAqrg", Name = "__JAx4oNg4O3WN9zwhzJAqrg")]
        [n2.SerializableAttribute]
        public class __JAx4oNg4O3WN9zwhzJAqrg : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_EWa7df88gc6MtaHul2kBpF);
                n1.CompilationHelper.SafeDispose(this.__p_Aif8g8ORZEOOasW3jL3wGB);
                n1.CompilationHelper.SafeDispose(this.__p_O0HcLisNyfqPuz9xcd8obB);
                n1.CompilationHelper.SafeDispose(this.__if_T6b499dYGSkNcFnIoK6YS6);
                return;
            }

            [n1.ElementAttribute(TracingId = 345347U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EWa7df88gc6MtaHul2kBpF", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n47.Group_TqwCZl6Gra4OmgvUg1POgm __p_EWa7df88gc6MtaHul2kBpF;
            [n1.ElementAttribute(TracingId = 345401U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Aif8g8ORZEOOasW3jL3wGB", Name = "BoxFrame", IsManaged = true, IsAutoGenerated = true)]
            public n48.BoxFrame_MdfNJXLlOjzMB5Tg5Xcmlc __p_Aif8g8ORZEOOasW3jL3wGB;
            [n1.ElementAttribute(TracingId = 345489U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "O0HcLisNyfqPuz9xcd8obB", Name = "Group (Spectral)", IsManaged = true, IsAutoGenerated = true)]
            public n47.Group_Spectral_OrFKGqkce2jOmqneI85BeX __p_O0HcLisNyfqPuz9xcd8obB;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_T6b499dYGSkNcFnIoK6YS6;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n43.Entity> __cp_KXnnvchQMwtQBL008mXBs3;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n43.Entity> __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF = default(n12.Spread<n43.Entity>);
            public __JAx4oNg4O3WN9zwhzJAqrg(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __JAx4oNg4O3WN9zwhzJAqrg(__JAx4oNg4O3WN9zwhzJAqrg other): base(other)
            {
                this.__p_EWa7df88gc6MtaHul2kBpF = other.__p_EWa7df88gc6MtaHul2kBpF;
                this.__p_Aif8g8ORZEOOasW3jL3wGB = other.__p_Aif8g8ORZEOOasW3jL3wGB;
                this.__p_O0HcLisNyfqPuz9xcd8obB = other.__p_O0HcLisNyfqPuz9xcd8obB;
                this.__if_T6b499dYGSkNcFnIoK6YS6 = other.__if_T6b499dYGSkNcFnIoK6YS6;
                this.__cp_KXnnvchQMwtQBL008mXBs3 = other.__cp_KXnnvchQMwtQBL008mXBs3;
                this.__pin_group_Child_In_EWa7df88gc6MtaHul2kBpF = other.__pin_group_Child_In_EWa7df88gc6MtaHul2kBpF;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_EWa7df88gc6MtaHul2kBpF", in __p_EWa7df88gc6MtaHul2kBpF), n1.CompilationHelper.GetValueOrExisting(values, "__p_Aif8g8ORZEOOasW3jL3wGB", in __p_Aif8g8ORZEOOasW3jL3wGB), n1.CompilationHelper.GetValueOrExisting(values, "__p_O0HcLisNyfqPuz9xcd8obB", in __p_O0HcLisNyfqPuz9xcd8obB), n1.CompilationHelper.GetValueOrExisting(values, "__if_T6b499dYGSkNcFnIoK6YS6", in __if_T6b499dYGSkNcFnIoK6YS6), n1.CompilationHelper.GetValueOrExisting(values, "__cp_KXnnvchQMwtQBL008mXBs3", in __cp_KXnnvchQMwtQBL008mXBs3), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_EWa7df88gc6MtaHul2kBpF", in __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF));
            }

            internal __JAx4oNg4O3WN9zwhzJAqrg __WITH__(n47.Group_TqwCZl6Gra4OmgvUg1POgm __p_EWa7df88gc6MtaHul2kBpF, n48.BoxFrame_MdfNJXLlOjzMB5Tg5Xcmlc __p_Aif8g8ORZEOOasW3jL3wGB, n47.Group_Spectral_OrFKGqkce2jOmqneI85BeX __p_O0HcLisNyfqPuz9xcd8obB, n2.Object __if_T6b499dYGSkNcFnIoK6YS6, n12.Spread<n43.Entity> __cp_KXnnvchQMwtQBL008mXBs3, n12.Spread<n43.Entity> __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF)
            {
                __JAx4oNg4O3WN9zwhzJAqrg that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_EWa7df88gc6MtaHul2kBpF != this.__p_EWa7df88gc6MtaHul2kBpF || __p_Aif8g8ORZEOOasW3jL3wGB != this.__p_Aif8g8ORZEOOasW3jL3wGB || __p_O0HcLisNyfqPuz9xcd8obB != this.__p_O0HcLisNyfqPuz9xcd8obB || __if_T6b499dYGSkNcFnIoK6YS6 != this.__if_T6b499dYGSkNcFnIoK6YS6 || __cp_KXnnvchQMwtQBL008mXBs3 != this.__cp_KXnnvchQMwtQBL008mXBs3 || __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF != this.__pin_group_Child_In_EWa7df88gc6MtaHul2kBpF ? new __JAx4oNg4O3WN9zwhzJAqrg(this)
                    {__p_EWa7df88gc6MtaHul2kBpF = __p_EWa7df88gc6MtaHul2kBpF, __p_Aif8g8ORZEOOasW3jL3wGB = __p_Aif8g8ORZEOOasW3jL3wGB, __p_O0HcLisNyfqPuz9xcd8obB = __p_O0HcLisNyfqPuz9xcd8obB, __if_T6b499dYGSkNcFnIoK6YS6 = __if_T6b499dYGSkNcFnIoK6YS6, __cp_KXnnvchQMwtQBL008mXBs3 = __cp_KXnnvchQMwtQBL008mXBs3, __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF = __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF} : that_0;
                else
                {
                    this.__p_EWa7df88gc6MtaHul2kBpF = __p_EWa7df88gc6MtaHul2kBpF;
                    this.__p_Aif8g8ORZEOOasW3jL3wGB = __p_Aif8g8ORZEOOasW3jL3wGB;
                    this.__p_O0HcLisNyfqPuz9xcd8obB = __p_O0HcLisNyfqPuz9xcd8obB;
                    this.__if_T6b499dYGSkNcFnIoK6YS6 = __if_T6b499dYGSkNcFnIoK6YS6;
                    this.__cp_KXnnvchQMwtQBL008mXBs3 = __cp_KXnnvchQMwtQBL008mXBs3;
                    this.__pin_group_Child_In_EWa7df88gc6MtaHul2kBpF = __pin_group_Child_In_EWa7df88gc6MtaHul2kBpF;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QWvjqfcDcVAMM9FnfYF9sl", Name = "__QWvjqfcDcVAMM9FnfYF9sl")]
        [n2.SerializableAttribute]
        public class __QWvjqfcDcVAMM9FnfYF9sl : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RC2lolDp84ANTjQLenzzU5);
                return;
            }

            [n1.ElementAttribute(TracingId = 345068U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RC2lolDp84ANTjQLenzzU5", Name = "VolumeRaymarching", IsManaged = true, IsAutoGenerated = true)]
            public n4.VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u __p_RC2lolDp84ANTjQLenzzU5;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n27.Texture> __pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle = default(n12.Spread<n27.Texture>);
            public __QWvjqfcDcVAMM9FnfYF9sl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __QWvjqfcDcVAMM9FnfYF9sl(__QWvjqfcDcVAMM9FnfYF9sl other): base(other)
            {
                this.__p_RC2lolDp84ANTjQLenzzU5 = other.__p_RC2lolDp84ANTjQLenzzU5;
                this.__pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle = other.__pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RC2lolDp84ANTjQLenzzU5", in __p_RC2lolDp84ANTjQLenzzU5), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle", in __pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle));
            }

            internal __QWvjqfcDcVAMM9FnfYF9sl __WITH__(n4.VolumeRaymarching_FtOG5ccNP9vNdxa3fpN81u __p_RC2lolDp84ANTjQLenzzU5, n12.Spread<n27.Texture> __pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle)
            {
                __QWvjqfcDcVAMM9FnfYF9sl that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RC2lolDp84ANTjQLenzzU5 != this.__p_RC2lolDp84ANTjQLenzzU5 || __pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle != this.__pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle ? new __QWvjqfcDcVAMM9FnfYF9sl(this)
                    {__p_RC2lolDp84ANTjQLenzzU5 = __p_RC2lolDp84ANTjQLenzzU5, __pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle = __pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle} : that_0;
                else
                {
                    this.__p_RC2lolDp84ANTjQLenzzU5 = __p_RC2lolDp84ANTjQLenzzU5;
                    this.__pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle = __pin_group_Input_In_L2o7UlPQi7rNRpkUIueFle;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "PpZf0vjJoZTNX05qD0GjGd", Name = "__PpZf0vjJoZTNX05qD0GjGd")]
        [n2.SerializableAttribute]
        public class __PpZf0vjJoZTNX05qD0GjGd : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_QQG5W1ZzkipMlUUB5GQ0U0);
                n1.CompilationHelper.SafeDispose(this.__if_FDxRpVumrgLQaK1eRq4PnY);
                return;
            }

            [n1.ElementAttribute(TracingId = 344815U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QQG5W1ZzkipMlUUB5GQ0U0", Name = "ReadBackTexture", IsManaged = true, IsAutoGenerated = true)]
            public n51.ReadBackTexture_GQP3tvG4YN6Nq4eGbxf7kT<float> __p_QQG5W1ZzkipMlUUB5GQ0U0;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_FDxRpVumrgLQaK1eRq4PnY;
            public __PpZf0vjJoZTNX05qD0GjGd(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __PpZf0vjJoZTNX05qD0GjGd(__PpZf0vjJoZTNX05qD0GjGd other): base(other)
            {
                this.__p_QQG5W1ZzkipMlUUB5GQ0U0 = other.__p_QQG5W1ZzkipMlUUB5GQ0U0;
                this.__if_FDxRpVumrgLQaK1eRq4PnY = other.__if_FDxRpVumrgLQaK1eRq4PnY;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QQG5W1ZzkipMlUUB5GQ0U0", in __p_QQG5W1ZzkipMlUUB5GQ0U0), n1.CompilationHelper.GetValueOrExisting(values, "__if_FDxRpVumrgLQaK1eRq4PnY", in __if_FDxRpVumrgLQaK1eRq4PnY));
            }

            internal __PpZf0vjJoZTNX05qD0GjGd __WITH__(n51.ReadBackTexture_GQP3tvG4YN6Nq4eGbxf7kT<float> __p_QQG5W1ZzkipMlUUB5GQ0U0, n2.Object __if_FDxRpVumrgLQaK1eRq4PnY)
            {
                __PpZf0vjJoZTNX05qD0GjGd that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_QQG5W1ZzkipMlUUB5GQ0U0 != this.__p_QQG5W1ZzkipMlUUB5GQ0U0 || __if_FDxRpVumrgLQaK1eRq4PnY != this.__if_FDxRpVumrgLQaK1eRq4PnY ? new __PpZf0vjJoZTNX05qD0GjGd(this)
                    {__p_QQG5W1ZzkipMlUUB5GQ0U0 = __p_QQG5W1ZzkipMlUUB5GQ0U0, __if_FDxRpVumrgLQaK1eRq4PnY = __if_FDxRpVumrgLQaK1eRq4PnY} : that_0;
                else
                {
                    this.__p_QQG5W1ZzkipMlUUB5GQ0U0 = __p_QQG5W1ZzkipMlUUB5GQ0U0;
                    this.__if_FDxRpVumrgLQaK1eRq4PnY = __if_FDxRpVumrgLQaK1eRq4PnY;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CHV7i3ra23WPztv8DooaRk", Name = "__CHV7i3ra23WPztv8DooaRk")]
        [n2.SerializableAttribute]
        public class __CHV7i3ra23WPztv8DooaRk : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(TracingId = 344860U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ECYJsGU7dPFMCUGS9xL58z", Name = "__slot_ECYJsGU7dPFMCUGS9xL58z")]
            public float __slot_ECYJsGU7dPFMCUGS9xL58z;
            public __CHV7i3ra23WPztv8DooaRk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CHV7i3ra23WPztv8DooaRk(__CHV7i3ra23WPztv8DooaRk other): base(other)
            {
                this.__slot_ECYJsGU7dPFMCUGS9xL58z = other.__slot_ECYJsGU7dPFMCUGS9xL58z;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_ECYJsGU7dPFMCUGS9xL58z", in __slot_ECYJsGU7dPFMCUGS9xL58z));
            }

            internal __CHV7i3ra23WPztv8DooaRk __WITH__(float __slot_ECYJsGU7dPFMCUGS9xL58z)
            {
                __CHV7i3ra23WPztv8DooaRk that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __slot_ECYJsGU7dPFMCUGS9xL58z != this.__slot_ECYJsGU7dPFMCUGS9xL58z ? new __CHV7i3ra23WPztv8DooaRk(this)
                    {__slot_ECYJsGU7dPFMCUGS9xL58z = __slot_ECYJsGU7dPFMCUGS9xL58z} : that_0;
                else
                {
                    this.__slot_ECYJsGU7dPFMCUGS9xL58z = __slot_ECYJsGU7dPFMCUGS9xL58z;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 346372U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DSmG7BduRxiNtFndZfaM9U", Name = "PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U")]
    [n2.SerializableAttribute]
    public class PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U Create(n1.NodeContext Node_Context)
        {
            var instance = new PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U CreateDefault()
        {
            var instance = new PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U Update(n4.FluidContext_C Context_In, out n35.GraphicsRendererGroup Dispatcher_Out)
        {
            var Output_1 = Context_In.GetComponents(Components_Out: out n12.Spread<n11.IFluidComponent_I> Components_0);
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_ShxWaPrL072LSOdZiLueB4;
            if (manager_4 is null)
            {
                manager_4 = new n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n53.IOrderedEnumerable<n11.IPreTexAdvectComputeGraphProvider_I>>>(n2.ValueTuple.Create(default(n53.IOrderedEnumerable<n11.IPreTexAdvectComputeGraphProvider_I>)));
            }

            var inputs_5 = n2.ValueTuple.Create(Components_0);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                n21.IEnumerable Input_9 = (n21.IEnumerable)Components_0;
                n23._Operations_.OfType<n11.IPreTexAdvectComputeGraphProvider_I>(Input_In: Input_9, Result_Out: out n22.IEnumerable<n11.IPreTexAdvectComputeGraphProvider_I> Result_10);
                var __fallback___11 = n1.ServiceRegistry.Current;
                n23._Operations_.OrderBy<n11.IPreTexAdvectComputeGraphProvider_I, float>(Input_In: Result_10, Key_Selector_In: (n11.IPreTexAdvectComputeGraphProvider_I Input_In_13) =>
                {
                    using var __current_12 = __fallback___11.MakeCurrentIfNone();
                    var Output_15 = ((n11.IPreTexAdvectComputeGraphProvider_I)Input_In_13).GetPriority(Priority_Out: out float Priority_14);
                    return Priority_14;
                }

                , Result_Out: out n53.IOrderedEnumerable<n11.IPreTexAdvectComputeGraphProvider_I> Result_16);
                outputs_6 = n2.ValueTuple.Create(Result_16);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, default, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_17 = outputs_6.Item1;
            var Output_19 = Context_In.GetComponents(Components_Out: out n12.Spread<n11.IFluidComponent_I> Components_18);
            bool Force_20 = false;
            bool Dispose_Cached_Outputs_21 = false;
            var manager_22 = this.__cache_GTR37ITSyTCPEpnlBr7JVO;
            if (manager_22 is null)
            {
                manager_22 = new n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n53.IOrderedEnumerable<n11.IPreTexAdvectComputeStageProvider_I>>>(n2.ValueTuple.Create(default(n53.IOrderedEnumerable<n11.IPreTexAdvectComputeStageProvider_I>)));
            }

            var inputs_23 = n2.ValueTuple.Create(Components_18);
            var outputs_24 = manager_22.Outputs;
            var Has_Changed_25 = Force_20 || manager_22.InputsChanged(inputs_23);
            if (Has_Changed_25)
            {
                if (Dispose_Cached_Outputs_21)
                    manager_22.DisposeOutputs();
                n21.IEnumerable Input_27 = (n21.IEnumerable)Components_18;
                n23._Operations_.OfType<n11.IPreTexAdvectComputeStageProvider_I>(Input_In: Input_27, Result_Out: out n22.IEnumerable<n11.IPreTexAdvectComputeStageProvider_I> Result_28);
                var __fallback___29 = n1.ServiceRegistry.Current;
                n23._Operations_.OrderBy<n11.IPreTexAdvectComputeStageProvider_I, float>(Input_In: Result_28, Key_Selector_In: (n11.IPreTexAdvectComputeStageProvider_I Input_In_31) =>
                {
                    using var __current_30 = __fallback___29.MakeCurrentIfNone();
                    var Output_33 = ((n11.IPreTexAdvectComputeStageProvider_I)Input_In_31).GetPriority(Priority_Out: out float Priority_32);
                    return Priority_32;
                }

                , Result_Out: out n53.IOrderedEnumerable<n11.IPreTexAdvectComputeStageProvider_I> Result_34);
                outputs_24 = n2.ValueTuple.Create(Result_34);
                manager_22 = manager_22.Update(inputs_23, __GetContext__().IsImmutable, Dispose_Cached_Outputs_21, default, outputs_24);
            }
            else
            {
                manager_22.Update(inputs_23, __GetContext__().IsImmutable, Dispose_Cached_Outputs_21);
            }

            var __auto_35 = outputs_24.Item1;
            var Output_38 = Context_In.GetDispatch(Thread_Group_Count_Out: out n6.Int3 Thread_Group_Count_36, Thread_Group_Size_Out: out n6.Int3 Thread_Group_Size_37);
            n1.CompilationHelper.WritePin(this.__p_IwBjXvGGCsMMU3tKBaX2ta.Inputs[0], ref Thread_Group_Count_36);
            n1.CompilationHelper.ReadPin(this.__p_IwBjXvGGCsMMU3tKBaX2ta.Outputs[0], out n32.IComputeEffectDispatcher out_39);
            var Output_41 = this.__p_LtYf3AnKztwM7lgy87kYnN.Update(Context_In: Context_In, Graph_Out: out n28.GpuValue<n54.GpuVoid> Graph_40);
            var builder_49 = n5.CollectionBuilders.GetBuilder(this.__cp_VniVMlhGBOjQdDFaXjhj5r, 16);
            n12.Spread<n28.GpuValue<n54.GpuVoid>> output_50;
            try
            {
                var i_44 = 0;
                foreach (var item_42 in __auto_17)
                {
                    var splicer_43 = item_42;
                    var i_local_45 = i_44;
                    var Output_48 = ((n11.IPreTexAdvectComputeGraphProvider_I)splicer_43).Update(Graph_Out: out n28.GpuValue<n54.GpuVoid> Graph_47);
                    builder_49.Add(Graph_47);
                    i_44++;
                }
            }
            finally
            {
                output_50 = builder_49.Commit();
            }

            bool Enabled_51 = true;
            var State_Output_53 = this.__p_QJf72bmyTCTLIudhRVmVRk.Update(Input_In: output_50, Enabled_In: Enabled_51, Output_Out: out n28.GpuValue<n54.GpuVoid> Output_52);
            bool Enabled_54 = true;
            var builder_55 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_F8yBocws3gLM24t48EmM4Y, 2);
            builder_55.Add(Graph_40);
            builder_55.Add(Output_52);
            var __pin_group_Input_In_F8yBocws3gLM24t48EmM4Y_56 = builder_55.Commit();
            var State_Output_58 = this.__p_F8yBocws3gLM24t48EmM4Y.Update(Input_In: __pin_group_Input_In_F8yBocws3gLM24t48EmM4Y_56, Enabled_In: Enabled_54, Output_Out: out n28.GpuValue<n54.GpuVoid> Output_57);
            bool Enabled_59 = true;
            var Output_63 = this.__p_Rm38VF44RnrQPxrHETPZAr.Update(Dispatcher_In: out_39, Thread_Group_Size_In: Thread_Group_Size_37, GpuValue_In: Output_57, Enabled_In: Enabled_59, Dispatcher_Out: out n32.VLComputeEffectShader Dispatcher_60, Last_Error_Out: out string Last_Error_61, Shader_Code_Out: out string Shader_Code_62);
            n33.IGraphicsRendererBase Input_64 = (n33.IGraphicsRendererBase)Dispatcher_60;
            var builder_72 = n5.CollectionBuilders.GetBuilder(this.__cp_FwpcKXzjlMXOJTxY8TU3s3, 16);
            n12.Spread<n33.IGraphicsRendererBase> output_73;
            try
            {
                var i_67 = 0;
                foreach (var item_65 in __auto_35)
                {
                    var splicer_66 = item_65;
                    var i_local_68 = i_67;
                    var Output_71 = ((n11.IPreTexAdvectComputeStageProvider_I)splicer_66).Update(Compute_Stage_Out: out n33.IGraphicsRendererBase Compute_Stage_70);
                    builder_72.Add(Compute_Stage_70);
                    i_67++;
                }
            }
            finally
            {
                output_73 = builder_72.Commit();
            }

            bool Update_74 = true;
            var Output_75 = this.__p_QFq91oXVy93OciNOaxKwy4;
            if (Update_74)
            {
                n35.GraphicsRendererGroup Input__this__76 = this.__p_QFq91oXVy93OciNOaxKwy4;
                Input__this__76.Update(input: output_73);
                Output_75 = Input__this__76;
            }

            n33.IGraphicsRendererBase Input_2_77 = (n33.IGraphicsRendererBase)Output_75;
            var builder_78 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T, 2);
            builder_78.Add(Input_64);
            builder_78.Add(Input_2_77);
            var __pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T_79 = builder_78.Commit();
            var State_Output_81 = this.__p_OgzHyo3BMoGMyHFj3fcc5T.Update(Input_In: __pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T_79, Output_Out: out n35.GraphicsRendererGroup Output_80);
            Dispatcher_Out = Output_80;
            n4.PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U that_82 = this;
            if (this.__GetContext__().IsImmutable)
                that_82 = manager_4 != this.__cache_ShxWaPrL072LSOdZiLueB4 || manager_22 != this.__cache_GTR37ITSyTCPEpnlBr7JVO || this.__p_IwBjXvGGCsMMU3tKBaX2ta != this.__p_IwBjXvGGCsMMU3tKBaX2ta || Output_41 != this.__p_LtYf3AnKztwM7lgy87kYnN || output_50 != this.__cp_VniVMlhGBOjQdDFaXjhj5r || State_Output_53 != this.__p_QJf72bmyTCTLIudhRVmVRk || __pin_group_Input_In_F8yBocws3gLM24t48EmM4Y_56 != this.__pin_group_Input_In_F8yBocws3gLM24t48EmM4Y || State_Output_58 != this.__p_F8yBocws3gLM24t48EmM4Y || Output_63 != this.__p_Rm38VF44RnrQPxrHETPZAr || output_73 != this.__cp_FwpcKXzjlMXOJTxY8TU3s3 || Output_75 != this.__p_QFq91oXVy93OciNOaxKwy4 || __pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T_79 != this.__pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T || State_Output_81 != this.__p_OgzHyo3BMoGMyHFj3fcc5T ? new PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U(this)
                {__cache_ShxWaPrL072LSOdZiLueB4 = manager_4, __cache_GTR37ITSyTCPEpnlBr7JVO = manager_22, __p_IwBjXvGGCsMMU3tKBaX2ta = this.__p_IwBjXvGGCsMMU3tKBaX2ta, __p_LtYf3AnKztwM7lgy87kYnN = Output_41, __cp_VniVMlhGBOjQdDFaXjhj5r = output_50, __p_QJf72bmyTCTLIudhRVmVRk = State_Output_53, __pin_group_Input_In_F8yBocws3gLM24t48EmM4Y = __pin_group_Input_In_F8yBocws3gLM24t48EmM4Y_56, __p_F8yBocws3gLM24t48EmM4Y = State_Output_58, __p_Rm38VF44RnrQPxrHETPZAr = Output_63, __cp_FwpcKXzjlMXOJTxY8TU3s3 = output_73, __p_QFq91oXVy93OciNOaxKwy4 = Output_75, __pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T = __pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T_79, __p_OgzHyo3BMoGMyHFj3fcc5T = State_Output_81} : that_82;
            else
            {
                this.__cache_ShxWaPrL072LSOdZiLueB4 = manager_4;
                this.__cache_GTR37ITSyTCPEpnlBr7JVO = manager_22;
                this.__p_IwBjXvGGCsMMU3tKBaX2ta = this.__p_IwBjXvGGCsMMU3tKBaX2ta;
                this.__p_LtYf3AnKztwM7lgy87kYnN = Output_41;
                this.__cp_VniVMlhGBOjQdDFaXjhj5r = output_50;
                this.__p_QJf72bmyTCTLIudhRVmVRk = State_Output_53;
                this.__pin_group_Input_In_F8yBocws3gLM24t48EmM4Y = __pin_group_Input_In_F8yBocws3gLM24t48EmM4Y_56;
                this.__p_F8yBocws3gLM24t48EmM4Y = State_Output_58;
                this.__p_Rm38VF44RnrQPxrHETPZAr = Output_63;
                this.__cp_FwpcKXzjlMXOJTxY8TU3s3 = output_73;
                this.__p_QFq91oXVy93OciNOaxKwy4 = Output_75;
                this.__pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T = __pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T_79;
                this.__p_OgzHyo3BMoGMyHFj3fcc5T = State_Output_81;
            }

            return that_82;
        }

        public n4.PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "LtYf3AnKztwM7lgy87kYnN", 346395U);
            var Output_1 = n4.BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Rm38VF44RnrQPxrHETPZAr", 346411U);
            var Output_3 = n55.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "F8yBocws3gLM24t48EmM4Y", 346446U);
            var Output_5 = n56.Group_GpuVoid_PRMY4HYRXTzM4hzmICywZJ.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "OgzHyo3BMoGMyHFj3fcc5T", 346458U);
            var Output_7 = n38.Group_JjpUJ7D6yd9L6tZwkMXdAR.Create(Node_Context: Node_Context_6);
            var node_8 = n1.CompilationHelper.CreateNodeById(Node_Context, "DirectDispatcher", "Stride.Rendering.Advanced");
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "QJf72bmyTCTLIudhRVmVRk", 346982U);
            var Output_10 = n56.Group_GpuVoid___Spectral_OniBIg3gb9nMspROrxur1f.Create(Node_Context: Node_Context_9);
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "QFq91oXVy93OciNOaxKwy4", 347006U);
            n37._Operations_.Create(Node_Context: Node_Context_11, Output_Out: out n35.GraphicsRendererGroup Output_12);
            n4.PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U that_13 = this;
            this.__cp_VniVMlhGBOjQdDFaXjhj5r = n14._Operations_.CreateDefault<n28.GpuValue<n54.GpuVoid>>();
            this.__pin_group_Input_In_F8yBocws3gLM24t48EmM4Y = n14._Operations_.CreateDefault<n28.GpuValue<n54.GpuVoid>>();
            this.__cp_FwpcKXzjlMXOJTxY8TU3s3 = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__p_LtYf3AnKztwM7lgy87kYnN = Output_1;
            this.__p_Rm38VF44RnrQPxrHETPZAr = Output_3;
            this.__p_F8yBocws3gLM24t48EmM4Y = Output_5;
            this.__p_OgzHyo3BMoGMyHFj3fcc5T = Output_7;
            this.__p_IwBjXvGGCsMMU3tKBaX2ta = node_8;
            this.__p_QJf72bmyTCTLIudhRVmVRk = Output_10;
            this.__p_QFq91oXVy93OciNOaxKwy4 = Output_12;
            this.__cache_ShxWaPrL072LSOdZiLueB4 = null;
            this.__cache_GTR37ITSyTCPEpnlBr7JVO = null;
            return that_13;
        }

        public n4.PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U __CreateDefault__()
        {
            n4.PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U that_0 = this;
            this.__cp_VniVMlhGBOjQdDFaXjhj5r = n14._Operations_.CreateDefault<n28.GpuValue<n54.GpuVoid>>();
            this.__pin_group_Input_In_F8yBocws3gLM24t48EmM4Y = n14._Operations_.CreateDefault<n28.GpuValue<n54.GpuVoid>>();
            this.__cp_FwpcKXzjlMXOJTxY8TU3s3 = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__cache_ShxWaPrL072LSOdZiLueB4 = null;
            this.__cache_GTR37ITSyTCPEpnlBr7JVO = null;
            this.__p_IwBjXvGGCsMMU3tKBaX2ta = default(n1.IVLNode);
            this.__p_LtYf3AnKztwM7lgy87kYnN = n4.BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt.CreateDefault();
            this.__p_QJf72bmyTCTLIudhRVmVRk = n56.Group_GpuVoid___Spectral_OniBIg3gb9nMspROrxur1f.CreateDefault();
            this.__p_F8yBocws3gLM24t48EmM4Y = n56.Group_GpuVoid_PRMY4HYRXTzM4hzmICywZJ.CreateDefault();
            this.__p_Rm38VF44RnrQPxrHETPZAr = n55.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2.CreateDefault();
            this.__p_QFq91oXVy93OciNOaxKwy4 = default(n35.GraphicsRendererGroup);
            this.__p_OgzHyo3BMoGMyHFj3fcc5T = n38.Group_JjpUJ7D6yd9L6tZwkMXdAR.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_ShxWaPrL072LSOdZiLueB4);
            n1.CompilationHelper.SafeDispose(this.__cache_GTR37ITSyTCPEpnlBr7JVO);
            n1.CompilationHelper.SafeDispose(this.__p_IwBjXvGGCsMMU3tKBaX2ta);
            n1.CompilationHelper.SafeDispose(this.__p_LtYf3AnKztwM7lgy87kYnN);
            n1.CompilationHelper.SafeDispose(this.__p_QJf72bmyTCTLIudhRVmVRk);
            n1.CompilationHelper.SafeDispose(this.__p_F8yBocws3gLM24t48EmM4Y);
            n1.CompilationHelper.SafeDispose(this.__p_Rm38VF44RnrQPxrHETPZAr);
            n1.CompilationHelper.SafeDispose(this.__p_QFq91oXVy93OciNOaxKwy4);
            n1.CompilationHelper.SafeDispose(this.__p_OgzHyo3BMoGMyHFj3fcc5T);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 346480U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ShxWaPrL072LSOdZiLueB4", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n53.IOrderedEnumerable<n11.IPreTexAdvectComputeGraphProvider_I>>> __cache_ShxWaPrL072LSOdZiLueB4 = null;
        [n1.ElementAttribute(TracingId = 346557U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GTR37ITSyTCPEpnlBr7JVO", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n53.IOrderedEnumerable<n11.IPreTexAdvectComputeStageProvider_I>>> __cache_GTR37ITSyTCPEpnlBr7JVO = null;
        [n1.ElementAttribute(TracingId = 346920U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IwBjXvGGCsMMU3tKBaX2ta", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
        public n1.IVLNode __p_IwBjXvGGCsMMU3tKBaX2ta;
        [n1.ElementAttribute(TracingId = 346395U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LtYf3AnKztwM7lgy87kYnN", Name = "BoxBorderObstacle", IsManaged = true, IsAutoGenerated = true)]
        public n4.BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt __p_LtYf3AnKztwM7lgy87kYnN;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n28.GpuValue<n54.GpuVoid>> __cp_VniVMlhGBOjQdDFaXjhj5r;
        [n1.ElementAttribute(TracingId = 346982U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QJf72bmyTCTLIudhRVmVRk", Name = "Group (GpuVoid) (Spectral)", IsManaged = true, IsAutoGenerated = true)]
        public n56.Group_GpuVoid___Spectral_OniBIg3gb9nMspROrxur1f __p_QJf72bmyTCTLIudhRVmVRk;
        [n1.ElementAttribute(TracingId = 346446U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "F8yBocws3gLM24t48EmM4Y", Name = "Group (GpuVoid)", IsManaged = true, IsAutoGenerated = true)]
        public n56.Group_GpuVoid_PRMY4HYRXTzM4hzmICywZJ __p_F8yBocws3gLM24t48EmM4Y;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n28.GpuValue<n54.GpuVoid>> __pin_group_Input_In_F8yBocws3gLM24t48EmM4Y = default(n12.Spread<n28.GpuValue<n54.GpuVoid>>);
        [n1.ElementAttribute(TracingId = 346411U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Rm38VF44RnrQPxrHETPZAr", Name = "ComputeShaderGraph", IsManaged = true, IsAutoGenerated = true)]
        public n55.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2 __p_Rm38VF44RnrQPxrHETPZAr;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n33.IGraphicsRendererBase> __cp_FwpcKXzjlMXOJTxY8TU3s3;
        [n1.ElementAttribute(TracingId = 347006U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QFq91oXVy93OciNOaxKwy4", Name = "Group (Spectral)", IsManaged = true, IsAutoGenerated = true)]
        public n35.GraphicsRendererGroup __p_QFq91oXVy93OciNOaxKwy4;
        [n1.ElementAttribute(TracingId = 346458U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OgzHyo3BMoGMyHFj3fcc5T", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n38.Group_JjpUJ7D6yd9L6tZwkMXdAR __p_OgzHyo3BMoGMyHFj3fcc5T;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n33.IGraphicsRendererBase> __pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T = default(n12.Spread<n33.IGraphicsRendererBase>);
        public PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U(PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U other): base(other)
        {
            this.__cache_ShxWaPrL072LSOdZiLueB4 = other.__cache_ShxWaPrL072LSOdZiLueB4;
            this.__cache_GTR37ITSyTCPEpnlBr7JVO = other.__cache_GTR37ITSyTCPEpnlBr7JVO;
            this.__p_IwBjXvGGCsMMU3tKBaX2ta = other.__p_IwBjXvGGCsMMU3tKBaX2ta;
            this.__p_LtYf3AnKztwM7lgy87kYnN = other.__p_LtYf3AnKztwM7lgy87kYnN;
            this.__cp_VniVMlhGBOjQdDFaXjhj5r = other.__cp_VniVMlhGBOjQdDFaXjhj5r;
            this.__p_QJf72bmyTCTLIudhRVmVRk = other.__p_QJf72bmyTCTLIudhRVmVRk;
            this.__p_F8yBocws3gLM24t48EmM4Y = other.__p_F8yBocws3gLM24t48EmM4Y;
            this.__pin_group_Input_In_F8yBocws3gLM24t48EmM4Y = other.__pin_group_Input_In_F8yBocws3gLM24t48EmM4Y;
            this.__p_Rm38VF44RnrQPxrHETPZAr = other.__p_Rm38VF44RnrQPxrHETPZAr;
            this.__cp_FwpcKXzjlMXOJTxY8TU3s3 = other.__cp_FwpcKXzjlMXOJTxY8TU3s3;
            this.__p_QFq91oXVy93OciNOaxKwy4 = other.__p_QFq91oXVy93OciNOaxKwy4;
            this.__p_OgzHyo3BMoGMyHFj3fcc5T = other.__p_OgzHyo3BMoGMyHFj3fcc5T;
            this.__pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T = other.__pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_ShxWaPrL072LSOdZiLueB4", in __cache_ShxWaPrL072LSOdZiLueB4), n1.CompilationHelper.GetValueOrExisting(values, "__cache_GTR37ITSyTCPEpnlBr7JVO", in __cache_GTR37ITSyTCPEpnlBr7JVO), n1.CompilationHelper.GetValueOrExisting(values, "__p_IwBjXvGGCsMMU3tKBaX2ta", in __p_IwBjXvGGCsMMU3tKBaX2ta), n1.CompilationHelper.GetValueOrExisting(values, "__p_LtYf3AnKztwM7lgy87kYnN", in __p_LtYf3AnKztwM7lgy87kYnN), n1.CompilationHelper.GetValueOrExisting(values, "__cp_VniVMlhGBOjQdDFaXjhj5r", in __cp_VniVMlhGBOjQdDFaXjhj5r), n1.CompilationHelper.GetValueOrExisting(values, "__p_QJf72bmyTCTLIudhRVmVRk", in __p_QJf72bmyTCTLIudhRVmVRk), n1.CompilationHelper.GetValueOrExisting(values, "__p_F8yBocws3gLM24t48EmM4Y", in __p_F8yBocws3gLM24t48EmM4Y), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_F8yBocws3gLM24t48EmM4Y", in __pin_group_Input_In_F8yBocws3gLM24t48EmM4Y), n1.CompilationHelper.GetValueOrExisting(values, "__p_Rm38VF44RnrQPxrHETPZAr", in __p_Rm38VF44RnrQPxrHETPZAr), n1.CompilationHelper.GetValueOrExisting(values, "__cp_FwpcKXzjlMXOJTxY8TU3s3", in __cp_FwpcKXzjlMXOJTxY8TU3s3), n1.CompilationHelper.GetValueOrExisting(values, "__p_QFq91oXVy93OciNOaxKwy4", in __p_QFq91oXVy93OciNOaxKwy4), n1.CompilationHelper.GetValueOrExisting(values, "__p_OgzHyo3BMoGMyHFj3fcc5T", in __p_OgzHyo3BMoGMyHFj3fcc5T), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T", in __pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T));
        }

        internal PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U __WITH__(n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n53.IOrderedEnumerable<n11.IPreTexAdvectComputeGraphProvider_I>>> __cache_ShxWaPrL072LSOdZiLueB4, n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n53.IOrderedEnumerable<n11.IPreTexAdvectComputeStageProvider_I>>> __cache_GTR37ITSyTCPEpnlBr7JVO, n1.IVLNode __p_IwBjXvGGCsMMU3tKBaX2ta, n4.BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt __p_LtYf3AnKztwM7lgy87kYnN, n12.Spread<n28.GpuValue<n54.GpuVoid>> __cp_VniVMlhGBOjQdDFaXjhj5r, n56.Group_GpuVoid___Spectral_OniBIg3gb9nMspROrxur1f __p_QJf72bmyTCTLIudhRVmVRk, n56.Group_GpuVoid_PRMY4HYRXTzM4hzmICywZJ __p_F8yBocws3gLM24t48EmM4Y, n12.Spread<n28.GpuValue<n54.GpuVoid>> __pin_group_Input_In_F8yBocws3gLM24t48EmM4Y, n55.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2 __p_Rm38VF44RnrQPxrHETPZAr, n12.Spread<n33.IGraphicsRendererBase> __cp_FwpcKXzjlMXOJTxY8TU3s3, n35.GraphicsRendererGroup __p_QFq91oXVy93OciNOaxKwy4, n38.Group_JjpUJ7D6yd9L6tZwkMXdAR __p_OgzHyo3BMoGMyHFj3fcc5T, n12.Spread<n33.IGraphicsRendererBase> __pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T)
        {
            n4.PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_ShxWaPrL072LSOdZiLueB4 != this.__cache_ShxWaPrL072LSOdZiLueB4 || __cache_GTR37ITSyTCPEpnlBr7JVO != this.__cache_GTR37ITSyTCPEpnlBr7JVO || __p_IwBjXvGGCsMMU3tKBaX2ta != this.__p_IwBjXvGGCsMMU3tKBaX2ta || __p_LtYf3AnKztwM7lgy87kYnN != this.__p_LtYf3AnKztwM7lgy87kYnN || __cp_VniVMlhGBOjQdDFaXjhj5r != this.__cp_VniVMlhGBOjQdDFaXjhj5r || __p_QJf72bmyTCTLIudhRVmVRk != this.__p_QJf72bmyTCTLIudhRVmVRk || __p_F8yBocws3gLM24t48EmM4Y != this.__p_F8yBocws3gLM24t48EmM4Y || __pin_group_Input_In_F8yBocws3gLM24t48EmM4Y != this.__pin_group_Input_In_F8yBocws3gLM24t48EmM4Y || __p_Rm38VF44RnrQPxrHETPZAr != this.__p_Rm38VF44RnrQPxrHETPZAr || __cp_FwpcKXzjlMXOJTxY8TU3s3 != this.__cp_FwpcKXzjlMXOJTxY8TU3s3 || __p_QFq91oXVy93OciNOaxKwy4 != this.__p_QFq91oXVy93OciNOaxKwy4 || __p_OgzHyo3BMoGMyHFj3fcc5T != this.__p_OgzHyo3BMoGMyHFj3fcc5T || __pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T != this.__pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T ? new PreTexAdvectionComponentsProcessor_DSmG7BduRxiNtFndZfaM9U(this)
                {__cache_ShxWaPrL072LSOdZiLueB4 = __cache_ShxWaPrL072LSOdZiLueB4, __cache_GTR37ITSyTCPEpnlBr7JVO = __cache_GTR37ITSyTCPEpnlBr7JVO, __p_IwBjXvGGCsMMU3tKBaX2ta = __p_IwBjXvGGCsMMU3tKBaX2ta, __p_LtYf3AnKztwM7lgy87kYnN = __p_LtYf3AnKztwM7lgy87kYnN, __cp_VniVMlhGBOjQdDFaXjhj5r = __cp_VniVMlhGBOjQdDFaXjhj5r, __p_QJf72bmyTCTLIudhRVmVRk = __p_QJf72bmyTCTLIudhRVmVRk, __p_F8yBocws3gLM24t48EmM4Y = __p_F8yBocws3gLM24t48EmM4Y, __pin_group_Input_In_F8yBocws3gLM24t48EmM4Y = __pin_group_Input_In_F8yBocws3gLM24t48EmM4Y, __p_Rm38VF44RnrQPxrHETPZAr = __p_Rm38VF44RnrQPxrHETPZAr, __cp_FwpcKXzjlMXOJTxY8TU3s3 = __cp_FwpcKXzjlMXOJTxY8TU3s3, __p_QFq91oXVy93OciNOaxKwy4 = __p_QFq91oXVy93OciNOaxKwy4, __p_OgzHyo3BMoGMyHFj3fcc5T = __p_OgzHyo3BMoGMyHFj3fcc5T, __pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T = __pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T} : that_0;
            else
            {
                this.__cache_ShxWaPrL072LSOdZiLueB4 = __cache_ShxWaPrL072LSOdZiLueB4;
                this.__cache_GTR37ITSyTCPEpnlBr7JVO = __cache_GTR37ITSyTCPEpnlBr7JVO;
                this.__p_IwBjXvGGCsMMU3tKBaX2ta = __p_IwBjXvGGCsMMU3tKBaX2ta;
                this.__p_LtYf3AnKztwM7lgy87kYnN = __p_LtYf3AnKztwM7lgy87kYnN;
                this.__cp_VniVMlhGBOjQdDFaXjhj5r = __cp_VniVMlhGBOjQdDFaXjhj5r;
                this.__p_QJf72bmyTCTLIudhRVmVRk = __p_QJf72bmyTCTLIudhRVmVRk;
                this.__p_F8yBocws3gLM24t48EmM4Y = __p_F8yBocws3gLM24t48EmM4Y;
                this.__pin_group_Input_In_F8yBocws3gLM24t48EmM4Y = __pin_group_Input_In_F8yBocws3gLM24t48EmM4Y;
                this.__p_Rm38VF44RnrQPxrHETPZAr = __p_Rm38VF44RnrQPxrHETPZAr;
                this.__cp_FwpcKXzjlMXOJTxY8TU3s3 = __cp_FwpcKXzjlMXOJTxY8TU3s3;
                this.__p_QFq91oXVy93OciNOaxKwy4 = __p_QFq91oXVy93OciNOaxKwy4;
                this.__p_OgzHyo3BMoGMyHFj3fcc5T = __p_OgzHyo3BMoGMyHFj3fcc5T;
                this.__pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T = __pin_group_Input_In_OgzHyo3BMoGMyHFj3fcc5T;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 347191U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "T3nXI7v2LHMLv5BbagTwwt", Name = "BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt")]
    [n2.SerializableAttribute]
    public class BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt Create(n1.NodeContext Node_Context)
        {
            var instance = new BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt CreateDefault()
        {
            var instance = new BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt Update(n4.FluidContext_C Context_In, out n28.GpuValue<n54.GpuVoid> Graph_Out)
        {
            string __pad_QVfE1TjpwkCLk8SBsVZiZc_0 = __slot_QVfE1TjpwkCLk8SBsVZiZc;
            float __pad_QApCSf13hCKPb8KUN2OEta_1 = __slot_QApCSf13hCKPb8KUN2OEta;
            float __pad_DsgFdb1XRdHNarIkPWqG01_2 = __slot_DsgFdb1XRdHNarIkPWqG01;
            var Output_8 = Context_In.GetTextureWithName(Texture_Name_In: __pad_QVfE1TjpwkCLk8SBsVZiZc_0, Texture_Read_Out: out n27.Texture Texture_Read_3, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_4, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_5, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_6, Found_Out: out bool Found_7);
            var State_Output_10 = this.__p_IIbN5p6H965MAXA4NlRDvy.GetOutput(Output_Out: out n28.GpuValue<n6.Int3> Output_9);
            var State_Output_12 = this.__p_JONDpmWCHP0NidrXUa8bip.GetOutput(Output_Out: out n28.GpuValue<n6.Int3> Output_11);
            var Output_14 = Context_In.GetResolution(Resolution_Out: out n6.Int3 Resolution_13);
            var Output_16 = this.__p_Dt5oKZ5KNSVMY0kBdA9Gzb.Update(Cell_Coordinate_In: Output_11, Fluid_Dimensions_In: Resolution_13, output_Out: out n28.GpuValue<bool> output_15);
            var Output_18 = this.__p_RmabzTyn74HMK4E24DXBSe.Update(Value_In: __pad_QApCSf13hCKPb8KUN2OEta_1, GpuValue_Out: out n28.GpuValue<float> GpuValue_17);
            var Output_20 = this.__p_KXTnVSe1po3PslKYKTzTV7.Update(Value_In: __pad_DsgFdb1XRdHNarIkPWqG01_2, GpuValue_Out: out n28.GpuValue<float> GpuValue_19);
            n28.GpuValue<float> The_Default_21 = default(n28.GpuValue<float>);
            var State_Output_23 = this.__p_Jx1HCaXWyAEMNa4lRwntws.Update(In_Check_In: output_15, In_False_In: GpuValue_17, In_True_In: GpuValue_19, The_Default_In: The_Default_21, Output_Out: out n28.GpuValue<float> Output_22);
            var State_Output_25 = this.__p_NHE4Kx3FIfCNH2fvYlBJRV.Update(Texture_In: Texture_ReadWrite_Graph_6, index_In: Output_9, value_In: Output_22, Output_Out: out n28.GpuValue<n54.GpuVoid> Output_24);
            Graph_Out = Output_24;
            n4.BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt that_26 = this;
            if (this.__GetContext__().IsImmutable)
                that_26 = State_Output_10 != this.__p_IIbN5p6H965MAXA4NlRDvy || State_Output_12 != this.__p_JONDpmWCHP0NidrXUa8bip || Output_16 != this.__p_Dt5oKZ5KNSVMY0kBdA9Gzb || Output_18 != this.__p_RmabzTyn74HMK4E24DXBSe || Output_20 != this.__p_KXTnVSe1po3PslKYKTzTV7 || State_Output_23 != this.__p_Jx1HCaXWyAEMNa4lRwntws || State_Output_25 != this.__p_NHE4Kx3FIfCNH2fvYlBJRV ? new BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt(this)
                {__p_IIbN5p6H965MAXA4NlRDvy = State_Output_10, __p_JONDpmWCHP0NidrXUa8bip = State_Output_12, __p_Dt5oKZ5KNSVMY0kBdA9Gzb = Output_16, __p_RmabzTyn74HMK4E24DXBSe = Output_18, __p_KXTnVSe1po3PslKYKTzTV7 = Output_20, __p_Jx1HCaXWyAEMNa4lRwntws = State_Output_23, __p_NHE4Kx3FIfCNH2fvYlBJRV = State_Output_25} : that_26;
            else
            {
                this.__p_IIbN5p6H965MAXA4NlRDvy = State_Output_10;
                this.__p_JONDpmWCHP0NidrXUa8bip = State_Output_12;
                this.__p_Dt5oKZ5KNSVMY0kBdA9Gzb = Output_16;
                this.__p_RmabzTyn74HMK4E24DXBSe = Output_18;
                this.__p_KXTnVSe1po3PslKYKTzTV7 = Output_20;
                this.__p_Jx1HCaXWyAEMNa4lRwntws = State_Output_23;
                this.__p_NHE4Kx3FIfCNH2fvYlBJRV = State_Output_25;
            }

            return that_26;
        }

        public n4.BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "RmabzTyn74HMK4E24DXBSe", 347254U);
            var Output_1 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Dt5oKZ5KNSVMY0kBdA9Gzb", 347279U);
            var Output_3 = n58.CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Jx1HCaXWyAEMNa4lRwntws", 347297U);
            var Output_5 = n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<float>.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "KXTnVSe1po3PslKYKTzTV7", 347320U);
            var Output_7 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "NHE4Kx3FIfCNH2fvYlBJRV", 347338U);
            var Output_9 = n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, float>.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "IIbN5p6H965MAXA4NlRDvy", 347350U);
            var Output_11 = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_10);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "JONDpmWCHP0NidrXUa8bip", 347361U);
            var Output_13 = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_12);
            n4.BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt that_14 = this;
            this.__p_RmabzTyn74HMK4E24DXBSe = Output_1;
            this.__p_Dt5oKZ5KNSVMY0kBdA9Gzb = Output_3;
            this.__p_Jx1HCaXWyAEMNa4lRwntws = Output_5;
            this.__p_KXTnVSe1po3PslKYKTzTV7 = Output_7;
            this.__p_NHE4Kx3FIfCNH2fvYlBJRV = Output_9;
            this.__p_IIbN5p6H965MAXA4NlRDvy = Output_11;
            this.__p_JONDpmWCHP0NidrXUa8bip = Output_13;
            return that_14;
        }

        public n4.BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt __CreateDefault__()
        {
            n4.BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt that_0 = this;
            this.__p_IIbN5p6H965MAXA4NlRDvy = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.CreateDefault();
            this.__p_JONDpmWCHP0NidrXUa8bip = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.CreateDefault();
            this.__p_Dt5oKZ5KNSVMY0kBdA9Gzb = n58.CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS.CreateDefault();
            this.__p_RmabzTyn74HMK4E24DXBSe = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.CreateDefault();
            this.__p_KXTnVSe1po3PslKYKTzTV7 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.CreateDefault();
            this.__p_Jx1HCaXWyAEMNa4lRwntws = n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<float>.CreateDefault();
            this.__p_NHE4Kx3FIfCNH2fvYlBJRV = n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, float>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_IIbN5p6H965MAXA4NlRDvy);
            n1.CompilationHelper.SafeDispose(this.__p_JONDpmWCHP0NidrXUa8bip);
            n1.CompilationHelper.SafeDispose(this.__p_Dt5oKZ5KNSVMY0kBdA9Gzb);
            n1.CompilationHelper.SafeDispose(this.__p_RmabzTyn74HMK4E24DXBSe);
            n1.CompilationHelper.SafeDispose(this.__p_KXTnVSe1po3PslKYKTzTV7);
            n1.CompilationHelper.SafeDispose(this.__p_Jx1HCaXWyAEMNa4lRwntws);
            n1.CompilationHelper.SafeDispose(this.__p_NHE4Kx3FIfCNH2fvYlBJRV);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 347274U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QApCSf13hCKPb8KUN2OEta", Name = "__slot_QApCSf13hCKPb8KUN2OEta")]
        public static float __slot_QApCSf13hCKPb8KUN2OEta = 0.5F;
        [n1.ElementAttribute(TracingId = 347330U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DsgFdb1XRdHNarIkPWqG01", Name = "__slot_DsgFdb1XRdHNarIkPWqG01")]
        public static float __slot_DsgFdb1XRdHNarIkPWqG01 = 0F;
        [n1.ElementAttribute(TracingId = 347367U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QVfE1TjpwkCLk8SBsVZiZc", Name = "__slot_QVfE1TjpwkCLk8SBsVZiZc")]
        public static string __slot_QVfE1TjpwkCLk8SBsVZiZc = "ObstaclesGradient";
        [n1.ElementAttribute(TracingId = 347350U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IIbN5p6H965MAXA4NlRDvy", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
        public n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_IIbN5p6H965MAXA4NlRDvy;
        [n1.ElementAttribute(TracingId = 347361U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JONDpmWCHP0NidrXUa8bip", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
        public n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_JONDpmWCHP0NidrXUa8bip;
        [n1.ElementAttribute(TracingId = 347279U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Dt5oKZ5KNSVMY0kBdA9Gzb", Name = "CellIsNodBoxBorder", IsManaged = true, IsAutoGenerated = true)]
        public n58.CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS __p_Dt5oKZ5KNSVMY0kBdA9Gzb;
        [n1.ElementAttribute(TracingId = 347254U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RmabzTyn74HMK4E24DXBSe", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
        public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_RmabzTyn74HMK4E24DXBSe;
        [n1.ElementAttribute(TracingId = 347320U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KXTnVSe1po3PslKYKTzTV7", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
        public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_KXTnVSe1po3PslKYKTzTV7;
        [n1.ElementAttribute(TracingId = 347297U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Jx1HCaXWyAEMNa4lRwntws", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
        public n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<float> __p_Jx1HCaXWyAEMNa4lRwntws;
        [n1.ElementAttribute(TracingId = 347338U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NHE4Kx3FIfCNH2fvYlBJRV", Name = "TextureSet", IsManaged = true, IsAutoGenerated = true)]
        public n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, float> __p_NHE4Kx3FIfCNH2fvYlBJRV;
        static BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt()
        {
        }

        public BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt(BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt other): base(other)
        {
            this.__p_IIbN5p6H965MAXA4NlRDvy = other.__p_IIbN5p6H965MAXA4NlRDvy;
            this.__p_JONDpmWCHP0NidrXUa8bip = other.__p_JONDpmWCHP0NidrXUa8bip;
            this.__p_Dt5oKZ5KNSVMY0kBdA9Gzb = other.__p_Dt5oKZ5KNSVMY0kBdA9Gzb;
            this.__p_RmabzTyn74HMK4E24DXBSe = other.__p_RmabzTyn74HMK4E24DXBSe;
            this.__p_KXTnVSe1po3PslKYKTzTV7 = other.__p_KXTnVSe1po3PslKYKTzTV7;
            this.__p_Jx1HCaXWyAEMNa4lRwntws = other.__p_Jx1HCaXWyAEMNa4lRwntws;
            this.__p_NHE4Kx3FIfCNH2fvYlBJRV = other.__p_NHE4Kx3FIfCNH2fvYlBJRV;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IIbN5p6H965MAXA4NlRDvy", in __p_IIbN5p6H965MAXA4NlRDvy), n1.CompilationHelper.GetValueOrExisting(values, "__p_JONDpmWCHP0NidrXUa8bip", in __p_JONDpmWCHP0NidrXUa8bip), n1.CompilationHelper.GetValueOrExisting(values, "__p_Dt5oKZ5KNSVMY0kBdA9Gzb", in __p_Dt5oKZ5KNSVMY0kBdA9Gzb), n1.CompilationHelper.GetValueOrExisting(values, "__p_RmabzTyn74HMK4E24DXBSe", in __p_RmabzTyn74HMK4E24DXBSe), n1.CompilationHelper.GetValueOrExisting(values, "__p_KXTnVSe1po3PslKYKTzTV7", in __p_KXTnVSe1po3PslKYKTzTV7), n1.CompilationHelper.GetValueOrExisting(values, "__p_Jx1HCaXWyAEMNa4lRwntws", in __p_Jx1HCaXWyAEMNa4lRwntws), n1.CompilationHelper.GetValueOrExisting(values, "__p_NHE4Kx3FIfCNH2fvYlBJRV", in __p_NHE4Kx3FIfCNH2fvYlBJRV));
        }

        internal BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt __WITH__(n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_IIbN5p6H965MAXA4NlRDvy, n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_JONDpmWCHP0NidrXUa8bip, n58.CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS __p_Dt5oKZ5KNSVMY0kBdA9Gzb, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_RmabzTyn74HMK4E24DXBSe, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_KXTnVSe1po3PslKYKTzTV7, n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<float> __p_Jx1HCaXWyAEMNa4lRwntws, n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, float> __p_NHE4Kx3FIfCNH2fvYlBJRV)
        {
            n4.BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_IIbN5p6H965MAXA4NlRDvy != this.__p_IIbN5p6H965MAXA4NlRDvy || __p_JONDpmWCHP0NidrXUa8bip != this.__p_JONDpmWCHP0NidrXUa8bip || __p_Dt5oKZ5KNSVMY0kBdA9Gzb != this.__p_Dt5oKZ5KNSVMY0kBdA9Gzb || __p_RmabzTyn74HMK4E24DXBSe != this.__p_RmabzTyn74HMK4E24DXBSe || __p_KXTnVSe1po3PslKYKTzTV7 != this.__p_KXTnVSe1po3PslKYKTzTV7 || __p_Jx1HCaXWyAEMNa4lRwntws != this.__p_Jx1HCaXWyAEMNa4lRwntws || __p_NHE4Kx3FIfCNH2fvYlBJRV != this.__p_NHE4Kx3FIfCNH2fvYlBJRV ? new BoxBorderObstacle_T3nXI7v2LHMLv5BbagTwwt(this)
                {__p_IIbN5p6H965MAXA4NlRDvy = __p_IIbN5p6H965MAXA4NlRDvy, __p_JONDpmWCHP0NidrXUa8bip = __p_JONDpmWCHP0NidrXUa8bip, __p_Dt5oKZ5KNSVMY0kBdA9Gzb = __p_Dt5oKZ5KNSVMY0kBdA9Gzb, __p_RmabzTyn74HMK4E24DXBSe = __p_RmabzTyn74HMK4E24DXBSe, __p_KXTnVSe1po3PslKYKTzTV7 = __p_KXTnVSe1po3PslKYKTzTV7, __p_Jx1HCaXWyAEMNa4lRwntws = __p_Jx1HCaXWyAEMNa4lRwntws, __p_NHE4Kx3FIfCNH2fvYlBJRV = __p_NHE4Kx3FIfCNH2fvYlBJRV} : that_0;
            else
            {
                this.__p_IIbN5p6H965MAXA4NlRDvy = __p_IIbN5p6H965MAXA4NlRDvy;
                this.__p_JONDpmWCHP0NidrXUa8bip = __p_JONDpmWCHP0NidrXUa8bip;
                this.__p_Dt5oKZ5KNSVMY0kBdA9Gzb = __p_Dt5oKZ5KNSVMY0kBdA9Gzb;
                this.__p_RmabzTyn74HMK4E24DXBSe = __p_RmabzTyn74HMK4E24DXBSe;
                this.__p_KXTnVSe1po3PslKYKTzTV7 = __p_KXTnVSe1po3PslKYKTzTV7;
                this.__p_Jx1HCaXWyAEMNa4lRwntws = __p_Jx1HCaXWyAEMNa4lRwntws;
                this.__p_NHE4Kx3FIfCNH2fvYlBJRV = __p_NHE4Kx3FIfCNH2fvYlBJRV;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 347457U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "D1s2HY7PFJKNgie1qUSNRw", Name = "PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw")]
    [n2.SerializableAttribute]
    public class PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw Create(n1.NodeContext Node_Context)
        {
            var instance = new PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw CreateDefault()
        {
            var instance = new PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw Update(n4.FluidContext_C Context_In, out n35.GraphicsRendererGroup Dispatcher_Out)
        {
            var Output_2 = Context_In.GetDispatch(Thread_Group_Count_Out: out n6.Int3 Thread_Group_Count_0, Thread_Group_Size_Out: out n6.Int3 Thread_Group_Size_1);
            n1.CompilationHelper.WritePin(this.__p_QzPIZyGLHNDPENpKs0SwvA.Inputs[0], ref Thread_Group_Count_0);
            n1.CompilationHelper.ReadPin(this.__p_QzPIZyGLHNDPENpKs0SwvA.Outputs[0], out n32.IComputeEffectDispatcher out_3);
            var Output_5 = Context_In.GetComponents(Components_Out: out n12.Spread<n11.IFluidComponent_I> Components_4);
            bool Force_6 = false;
            bool Dispose_Cached_Outputs_7 = false;
            var manager_8 = this.__cache_CqMSyyUqGEHN80zwrCIg2P;
            if (manager_8 is null)
            {
                manager_8 = new n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n53.IOrderedEnumerable<n11.IPostTexAdvectComputeGraphProvider_I>>>(n2.ValueTuple.Create(default(n53.IOrderedEnumerable<n11.IPostTexAdvectComputeGraphProvider_I>)));
            }

            var inputs_9 = n2.ValueTuple.Create(Components_4);
            var outputs_10 = manager_8.Outputs;
            var Has_Changed_11 = Force_6 || manager_8.InputsChanged(inputs_9);
            if (Has_Changed_11)
            {
                if (Dispose_Cached_Outputs_7)
                    manager_8.DisposeOutputs();
                n21.IEnumerable Input_13 = (n21.IEnumerable)Components_4;
                n23._Operations_.OfType<n11.IPostTexAdvectComputeGraphProvider_I>(Input_In: Input_13, Result_Out: out n22.IEnumerable<n11.IPostTexAdvectComputeGraphProvider_I> Result_14);
                var __fallback___15 = n1.ServiceRegistry.Current;
                n23._Operations_.OrderBy<n11.IPostTexAdvectComputeGraphProvider_I, float>(Input_In: Result_14, Key_Selector_In: (n11.IPostTexAdvectComputeGraphProvider_I Input_In_17) =>
                {
                    using var __current_16 = __fallback___15.MakeCurrentIfNone();
                    var Output_19 = ((n11.IPostTexAdvectComputeGraphProvider_I)Input_In_17).GetPriority(Priority_Out: out float Priority_18);
                    return Priority_18;
                }

                , Result_Out: out n53.IOrderedEnumerable<n11.IPostTexAdvectComputeGraphProvider_I> Result_20);
                outputs_10 = n2.ValueTuple.Create(Result_20);
                manager_8 = manager_8.Update(inputs_9, __GetContext__().IsImmutable, Dispose_Cached_Outputs_7, default, outputs_10);
            }
            else
            {
                manager_8.Update(inputs_9, __GetContext__().IsImmutable, Dispose_Cached_Outputs_7);
            }

            var __auto_21 = outputs_10.Item1;
            var builder_29 = n5.CollectionBuilders.GetBuilder(this.__cp_MSKZS1oPvIvP1ROVBFBIiZ, 16);
            n12.Spread<n28.GpuValue<n54.GpuVoid>> output_30;
            try
            {
                var i_24 = 0;
                foreach (var item_22 in __auto_21)
                {
                    var splicer_23 = item_22;
                    var i_local_25 = i_24;
                    var Output_28 = ((n11.IPostTexAdvectComputeGraphProvider_I)splicer_23).Update(Graph_Out: out n28.GpuValue<n54.GpuVoid> Graph_27);
                    builder_29.Add(Graph_27);
                    i_24++;
                }
            }
            finally
            {
                output_30 = builder_29.Commit();
            }

            bool Enabled_31 = true;
            var State_Output_33 = this.__p_CzAWQBc8yHIPVnkGVbyURI.Update(Input_In: output_30, Enabled_In: Enabled_31, Output_Out: out n28.GpuValue<n54.GpuVoid> Output_32);
            bool Enabled_34 = true;
            var Output_38 = this.__p_SXq5kVeJjNhNVgFWGI40fL.Update(Dispatcher_In: out_3, Thread_Group_Size_In: Thread_Group_Size_1, GpuValue_In: Output_32, Enabled_In: Enabled_34, Dispatcher_Out: out n32.VLComputeEffectShader Dispatcher_35, Last_Error_Out: out string Last_Error_36, Shader_Code_Out: out string Shader_Code_37);
            n33.IGraphicsRendererBase Input_39 = (n33.IGraphicsRendererBase)Dispatcher_35;
            var Output_41 = Context_In.GetComponents(Components_Out: out n12.Spread<n11.IFluidComponent_I> Components_40);
            bool Force_42 = false;
            bool Dispose_Cached_Outputs_43 = false;
            var manager_44 = this.__cache_TA6kaMmquKML5N2vaeTSEV;
            if (manager_44 is null)
            {
                manager_44 = new n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n53.IOrderedEnumerable<n11.IPostTexAdvectComputeStageProvider_I>>>(n2.ValueTuple.Create(default(n53.IOrderedEnumerable<n11.IPostTexAdvectComputeStageProvider_I>)));
            }

            var inputs_45 = n2.ValueTuple.Create(Components_40);
            var outputs_46 = manager_44.Outputs;
            var Has_Changed_47 = Force_42 || manager_44.InputsChanged(inputs_45);
            if (Has_Changed_47)
            {
                if (Dispose_Cached_Outputs_43)
                    manager_44.DisposeOutputs();
                n21.IEnumerable Input_49 = (n21.IEnumerable)Components_40;
                n23._Operations_.OfType<n11.IPostTexAdvectComputeStageProvider_I>(Input_In: Input_49, Result_Out: out n22.IEnumerable<n11.IPostTexAdvectComputeStageProvider_I> Result_50);
                var __fallback___51 = n1.ServiceRegistry.Current;
                n23._Operations_.OrderBy<n11.IPostTexAdvectComputeStageProvider_I, float>(Input_In: Result_50, Key_Selector_In: (n11.IPostTexAdvectComputeStageProvider_I Input_In_53) =>
                {
                    using var __current_52 = __fallback___51.MakeCurrentIfNone();
                    var Output_55 = ((n11.IPostTexAdvectComputeStageProvider_I)Input_In_53).GetPriority(Priority_Out: out float Priority_54);
                    return Priority_54;
                }

                , Result_Out: out n53.IOrderedEnumerable<n11.IPostTexAdvectComputeStageProvider_I> Result_56);
                outputs_46 = n2.ValueTuple.Create(Result_56);
                manager_44 = manager_44.Update(inputs_45, __GetContext__().IsImmutable, Dispose_Cached_Outputs_43, default, outputs_46);
            }
            else
            {
                manager_44.Update(inputs_45, __GetContext__().IsImmutable, Dispose_Cached_Outputs_43);
            }

            var __auto_57 = outputs_46.Item1;
            var builder_65 = n5.CollectionBuilders.GetBuilder(this.__cp_GUJnFJVl1XcNpnYFK5Zg16, 16);
            n12.Spread<n33.IGraphicsRendererBase> output_66;
            try
            {
                var i_60 = 0;
                foreach (var item_58 in __auto_57)
                {
                    var splicer_59 = item_58;
                    var i_local_61 = i_60;
                    var Output_64 = ((n11.IPostTexAdvectComputeStageProvider_I)splicer_59).Update(Compute_Stage_Out: out n33.IGraphicsRendererBase Compute_Stage_63);
                    builder_65.Add(Compute_Stage_63);
                    i_60++;
                }
            }
            finally
            {
                output_66 = builder_65.Commit();
            }

            bool Update_67 = true;
            var Output_68 = this.__p_DWG9MoJ3kq6Mwqk1tWdO9M;
            if (Update_67)
            {
                n35.GraphicsRendererGroup Input__this__69 = this.__p_DWG9MoJ3kq6Mwqk1tWdO9M;
                Input__this__69.Update(input: output_66);
                Output_68 = Input__this__69;
            }

            n33.IGraphicsRendererBase Input_2_70 = (n33.IGraphicsRendererBase)Output_68;
            var builder_71 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_IomctlBL1VHOouihVnabfS, 2);
            builder_71.Add(Input_39);
            builder_71.Add(Input_2_70);
            var __pin_group_Input_In_IomctlBL1VHOouihVnabfS_72 = builder_71.Commit();
            var State_Output_74 = this.__p_IomctlBL1VHOouihVnabfS.Update(Input_In: __pin_group_Input_In_IomctlBL1VHOouihVnabfS_72, Output_Out: out n35.GraphicsRendererGroup Output_73);
            Dispatcher_Out = Output_73;
            n4.PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw that_75 = this;
            if (this.__GetContext__().IsImmutable)
                that_75 = this.__p_QzPIZyGLHNDPENpKs0SwvA != this.__p_QzPIZyGLHNDPENpKs0SwvA || manager_8 != this.__cache_CqMSyyUqGEHN80zwrCIg2P || output_30 != this.__cp_MSKZS1oPvIvP1ROVBFBIiZ || State_Output_33 != this.__p_CzAWQBc8yHIPVnkGVbyURI || Output_38 != this.__p_SXq5kVeJjNhNVgFWGI40fL || manager_44 != this.__cache_TA6kaMmquKML5N2vaeTSEV || output_66 != this.__cp_GUJnFJVl1XcNpnYFK5Zg16 || Output_68 != this.__p_DWG9MoJ3kq6Mwqk1tWdO9M || __pin_group_Input_In_IomctlBL1VHOouihVnabfS_72 != this.__pin_group_Input_In_IomctlBL1VHOouihVnabfS || State_Output_74 != this.__p_IomctlBL1VHOouihVnabfS ? new PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw(this)
                {__p_QzPIZyGLHNDPENpKs0SwvA = this.__p_QzPIZyGLHNDPENpKs0SwvA, __cache_CqMSyyUqGEHN80zwrCIg2P = manager_8, __cp_MSKZS1oPvIvP1ROVBFBIiZ = output_30, __p_CzAWQBc8yHIPVnkGVbyURI = State_Output_33, __p_SXq5kVeJjNhNVgFWGI40fL = Output_38, __cache_TA6kaMmquKML5N2vaeTSEV = manager_44, __cp_GUJnFJVl1XcNpnYFK5Zg16 = output_66, __p_DWG9MoJ3kq6Mwqk1tWdO9M = Output_68, __pin_group_Input_In_IomctlBL1VHOouihVnabfS = __pin_group_Input_In_IomctlBL1VHOouihVnabfS_72, __p_IomctlBL1VHOouihVnabfS = State_Output_74} : that_75;
            else
            {
                this.__p_QzPIZyGLHNDPENpKs0SwvA = this.__p_QzPIZyGLHNDPENpKs0SwvA;
                this.__cache_CqMSyyUqGEHN80zwrCIg2P = manager_8;
                this.__cp_MSKZS1oPvIvP1ROVBFBIiZ = output_30;
                this.__p_CzAWQBc8yHIPVnkGVbyURI = State_Output_33;
                this.__p_SXq5kVeJjNhNVgFWGI40fL = Output_38;
                this.__cache_TA6kaMmquKML5N2vaeTSEV = manager_44;
                this.__cp_GUJnFJVl1XcNpnYFK5Zg16 = output_66;
                this.__p_DWG9MoJ3kq6Mwqk1tWdO9M = Output_68;
                this.__pin_group_Input_In_IomctlBL1VHOouihVnabfS = __pin_group_Input_In_IomctlBL1VHOouihVnabfS_72;
                this.__p_IomctlBL1VHOouihVnabfS = State_Output_74;
            }

            return that_75;
        }

        public n4.PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "SXq5kVeJjNhNVgFWGI40fL", 347519U);
            var Output_1 = n55.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "CzAWQBc8yHIPVnkGVbyURI", 348407U);
            var Output_3 = n56.Group_GpuVoid___Spectral_OniBIg3gb9nMspROrxur1f.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "IomctlBL1VHOouihVnabfS", 348433U);
            var Output_5 = n38.Group_JjpUJ7D6yd9L6tZwkMXdAR.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "DWG9MoJ3kq6Mwqk1tWdO9M", 348457U);
            n37._Operations_.Create(Node_Context: Node_Context_6, Output_Out: out n35.GraphicsRendererGroup Output_7);
            var node_8 = n1.CompilationHelper.CreateNodeById(Node_Context, "DirectDispatcher", "Stride.Rendering.Advanced");
            n4.PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw that_9 = this;
            this.__cp_MSKZS1oPvIvP1ROVBFBIiZ = n14._Operations_.CreateDefault<n28.GpuValue<n54.GpuVoid>>();
            this.__cp_GUJnFJVl1XcNpnYFK5Zg16 = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__pin_group_Input_In_IomctlBL1VHOouihVnabfS = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__p_SXq5kVeJjNhNVgFWGI40fL = Output_1;
            this.__p_CzAWQBc8yHIPVnkGVbyURI = Output_3;
            this.__p_IomctlBL1VHOouihVnabfS = Output_5;
            this.__p_DWG9MoJ3kq6Mwqk1tWdO9M = Output_7;
            this.__p_QzPIZyGLHNDPENpKs0SwvA = node_8;
            this.__cache_CqMSyyUqGEHN80zwrCIg2P = null;
            this.__cache_TA6kaMmquKML5N2vaeTSEV = null;
            return that_9;
        }

        public n4.PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw __CreateDefault__()
        {
            n4.PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw that_0 = this;
            this.__cp_MSKZS1oPvIvP1ROVBFBIiZ = n14._Operations_.CreateDefault<n28.GpuValue<n54.GpuVoid>>();
            this.__cp_GUJnFJVl1XcNpnYFK5Zg16 = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__pin_group_Input_In_IomctlBL1VHOouihVnabfS = n14._Operations_.CreateDefault<n33.IGraphicsRendererBase>();
            this.__p_QzPIZyGLHNDPENpKs0SwvA = default(n1.IVLNode);
            this.__cache_CqMSyyUqGEHN80zwrCIg2P = null;
            this.__p_CzAWQBc8yHIPVnkGVbyURI = n56.Group_GpuVoid___Spectral_OniBIg3gb9nMspROrxur1f.CreateDefault();
            this.__p_SXq5kVeJjNhNVgFWGI40fL = n55.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2.CreateDefault();
            this.__cache_TA6kaMmquKML5N2vaeTSEV = null;
            this.__p_DWG9MoJ3kq6Mwqk1tWdO9M = default(n35.GraphicsRendererGroup);
            this.__p_IomctlBL1VHOouihVnabfS = n38.Group_JjpUJ7D6yd9L6tZwkMXdAR.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_QzPIZyGLHNDPENpKs0SwvA);
            n1.CompilationHelper.SafeDispose(this.__cache_CqMSyyUqGEHN80zwrCIg2P);
            n1.CompilationHelper.SafeDispose(this.__p_CzAWQBc8yHIPVnkGVbyURI);
            n1.CompilationHelper.SafeDispose(this.__p_SXq5kVeJjNhNVgFWGI40fL);
            n1.CompilationHelper.SafeDispose(this.__cache_TA6kaMmquKML5N2vaeTSEV);
            n1.CompilationHelper.SafeDispose(this.__p_DWG9MoJ3kq6Mwqk1tWdO9M);
            n1.CompilationHelper.SafeDispose(this.__p_IomctlBL1VHOouihVnabfS);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 348551U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QzPIZyGLHNDPENpKs0SwvA", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
        public n1.IVLNode __p_QzPIZyGLHNDPENpKs0SwvA;
        [n1.ElementAttribute(TracingId = 348560U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CqMSyyUqGEHN80zwrCIg2P", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n53.IOrderedEnumerable<n11.IPostTexAdvectComputeGraphProvider_I>>> __cache_CqMSyyUqGEHN80zwrCIg2P = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n28.GpuValue<n54.GpuVoid>> __cp_MSKZS1oPvIvP1ROVBFBIiZ;
        [n1.ElementAttribute(TracingId = 348407U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CzAWQBc8yHIPVnkGVbyURI", Name = "Group (GpuVoid) (Spectral)", IsManaged = true, IsAutoGenerated = true)]
        public n56.Group_GpuVoid___Spectral_OniBIg3gb9nMspROrxur1f __p_CzAWQBc8yHIPVnkGVbyURI;
        [n1.ElementAttribute(TracingId = 347519U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SXq5kVeJjNhNVgFWGI40fL", Name = "ComputeShaderGraph", IsManaged = true, IsAutoGenerated = true)]
        public n55.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2 __p_SXq5kVeJjNhNVgFWGI40fL;
        [n1.ElementAttribute(TracingId = 348794U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TA6kaMmquKML5N2vaeTSEV", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n53.IOrderedEnumerable<n11.IPostTexAdvectComputeStageProvider_I>>> __cache_TA6kaMmquKML5N2vaeTSEV = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n33.IGraphicsRendererBase> __cp_GUJnFJVl1XcNpnYFK5Zg16;
        [n1.ElementAttribute(TracingId = 348457U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DWG9MoJ3kq6Mwqk1tWdO9M", Name = "Group (Spectral)", IsManaged = true, IsAutoGenerated = true)]
        public n35.GraphicsRendererGroup __p_DWG9MoJ3kq6Mwqk1tWdO9M;
        [n1.ElementAttribute(TracingId = 348433U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IomctlBL1VHOouihVnabfS", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n38.Group_JjpUJ7D6yd9L6tZwkMXdAR __p_IomctlBL1VHOouihVnabfS;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n33.IGraphicsRendererBase> __pin_group_Input_In_IomctlBL1VHOouihVnabfS = default(n12.Spread<n33.IGraphicsRendererBase>);
        public PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw(PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw other): base(other)
        {
            this.__p_QzPIZyGLHNDPENpKs0SwvA = other.__p_QzPIZyGLHNDPENpKs0SwvA;
            this.__cache_CqMSyyUqGEHN80zwrCIg2P = other.__cache_CqMSyyUqGEHN80zwrCIg2P;
            this.__cp_MSKZS1oPvIvP1ROVBFBIiZ = other.__cp_MSKZS1oPvIvP1ROVBFBIiZ;
            this.__p_CzAWQBc8yHIPVnkGVbyURI = other.__p_CzAWQBc8yHIPVnkGVbyURI;
            this.__p_SXq5kVeJjNhNVgFWGI40fL = other.__p_SXq5kVeJjNhNVgFWGI40fL;
            this.__cache_TA6kaMmquKML5N2vaeTSEV = other.__cache_TA6kaMmquKML5N2vaeTSEV;
            this.__cp_GUJnFJVl1XcNpnYFK5Zg16 = other.__cp_GUJnFJVl1XcNpnYFK5Zg16;
            this.__p_DWG9MoJ3kq6Mwqk1tWdO9M = other.__p_DWG9MoJ3kq6Mwqk1tWdO9M;
            this.__p_IomctlBL1VHOouihVnabfS = other.__p_IomctlBL1VHOouihVnabfS;
            this.__pin_group_Input_In_IomctlBL1VHOouihVnabfS = other.__pin_group_Input_In_IomctlBL1VHOouihVnabfS;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QzPIZyGLHNDPENpKs0SwvA", in __p_QzPIZyGLHNDPENpKs0SwvA), n1.CompilationHelper.GetValueOrExisting(values, "__cache_CqMSyyUqGEHN80zwrCIg2P", in __cache_CqMSyyUqGEHN80zwrCIg2P), n1.CompilationHelper.GetValueOrExisting(values, "__cp_MSKZS1oPvIvP1ROVBFBIiZ", in __cp_MSKZS1oPvIvP1ROVBFBIiZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_CzAWQBc8yHIPVnkGVbyURI", in __p_CzAWQBc8yHIPVnkGVbyURI), n1.CompilationHelper.GetValueOrExisting(values, "__p_SXq5kVeJjNhNVgFWGI40fL", in __p_SXq5kVeJjNhNVgFWGI40fL), n1.CompilationHelper.GetValueOrExisting(values, "__cache_TA6kaMmquKML5N2vaeTSEV", in __cache_TA6kaMmquKML5N2vaeTSEV), n1.CompilationHelper.GetValueOrExisting(values, "__cp_GUJnFJVl1XcNpnYFK5Zg16", in __cp_GUJnFJVl1XcNpnYFK5Zg16), n1.CompilationHelper.GetValueOrExisting(values, "__p_DWG9MoJ3kq6Mwqk1tWdO9M", in __p_DWG9MoJ3kq6Mwqk1tWdO9M), n1.CompilationHelper.GetValueOrExisting(values, "__p_IomctlBL1VHOouihVnabfS", in __p_IomctlBL1VHOouihVnabfS), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_IomctlBL1VHOouihVnabfS", in __pin_group_Input_In_IomctlBL1VHOouihVnabfS));
        }

        internal PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw __WITH__(n1.IVLNode __p_QzPIZyGLHNDPENpKs0SwvA, n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n53.IOrderedEnumerable<n11.IPostTexAdvectComputeGraphProvider_I>>> __cache_CqMSyyUqGEHN80zwrCIg2P, n12.Spread<n28.GpuValue<n54.GpuVoid>> __cp_MSKZS1oPvIvP1ROVBFBIiZ, n56.Group_GpuVoid___Spectral_OniBIg3gb9nMspROrxur1f __p_CzAWQBc8yHIPVnkGVbyURI, n55.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2 __p_SXq5kVeJjNhNVgFWGI40fL, n13.Manager<n2.ValueTuple<n12.Spread<n11.IFluidComponent_I>>, n2.ValueTuple<n53.IOrderedEnumerable<n11.IPostTexAdvectComputeStageProvider_I>>> __cache_TA6kaMmquKML5N2vaeTSEV, n12.Spread<n33.IGraphicsRendererBase> __cp_GUJnFJVl1XcNpnYFK5Zg16, n35.GraphicsRendererGroup __p_DWG9MoJ3kq6Mwqk1tWdO9M, n38.Group_JjpUJ7D6yd9L6tZwkMXdAR __p_IomctlBL1VHOouihVnabfS, n12.Spread<n33.IGraphicsRendererBase> __pin_group_Input_In_IomctlBL1VHOouihVnabfS)
        {
            n4.PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_QzPIZyGLHNDPENpKs0SwvA != this.__p_QzPIZyGLHNDPENpKs0SwvA || __cache_CqMSyyUqGEHN80zwrCIg2P != this.__cache_CqMSyyUqGEHN80zwrCIg2P || __cp_MSKZS1oPvIvP1ROVBFBIiZ != this.__cp_MSKZS1oPvIvP1ROVBFBIiZ || __p_CzAWQBc8yHIPVnkGVbyURI != this.__p_CzAWQBc8yHIPVnkGVbyURI || __p_SXq5kVeJjNhNVgFWGI40fL != this.__p_SXq5kVeJjNhNVgFWGI40fL || __cache_TA6kaMmquKML5N2vaeTSEV != this.__cache_TA6kaMmquKML5N2vaeTSEV || __cp_GUJnFJVl1XcNpnYFK5Zg16 != this.__cp_GUJnFJVl1XcNpnYFK5Zg16 || __p_DWG9MoJ3kq6Mwqk1tWdO9M != this.__p_DWG9MoJ3kq6Mwqk1tWdO9M || __p_IomctlBL1VHOouihVnabfS != this.__p_IomctlBL1VHOouihVnabfS || __pin_group_Input_In_IomctlBL1VHOouihVnabfS != this.__pin_group_Input_In_IomctlBL1VHOouihVnabfS ? new PostTexAdvectionComponentsProcessor_D1s2HY7PFJKNgie1qUSNRw(this)
                {__p_QzPIZyGLHNDPENpKs0SwvA = __p_QzPIZyGLHNDPENpKs0SwvA, __cache_CqMSyyUqGEHN80zwrCIg2P = __cache_CqMSyyUqGEHN80zwrCIg2P, __cp_MSKZS1oPvIvP1ROVBFBIiZ = __cp_MSKZS1oPvIvP1ROVBFBIiZ, __p_CzAWQBc8yHIPVnkGVbyURI = __p_CzAWQBc8yHIPVnkGVbyURI, __p_SXq5kVeJjNhNVgFWGI40fL = __p_SXq5kVeJjNhNVgFWGI40fL, __cache_TA6kaMmquKML5N2vaeTSEV = __cache_TA6kaMmquKML5N2vaeTSEV, __cp_GUJnFJVl1XcNpnYFK5Zg16 = __cp_GUJnFJVl1XcNpnYFK5Zg16, __p_DWG9MoJ3kq6Mwqk1tWdO9M = __p_DWG9MoJ3kq6Mwqk1tWdO9M, __p_IomctlBL1VHOouihVnabfS = __p_IomctlBL1VHOouihVnabfS, __pin_group_Input_In_IomctlBL1VHOouihVnabfS = __pin_group_Input_In_IomctlBL1VHOouihVnabfS} : that_0;
            else
            {
                this.__p_QzPIZyGLHNDPENpKs0SwvA = __p_QzPIZyGLHNDPENpKs0SwvA;
                this.__cache_CqMSyyUqGEHN80zwrCIg2P = __cache_CqMSyyUqGEHN80zwrCIg2P;
                this.__cp_MSKZS1oPvIvP1ROVBFBIiZ = __cp_MSKZS1oPvIvP1ROVBFBIiZ;
                this.__p_CzAWQBc8yHIPVnkGVbyURI = __p_CzAWQBc8yHIPVnkGVbyURI;
                this.__p_SXq5kVeJjNhNVgFWGI40fL = __p_SXq5kVeJjNhNVgFWGI40fL;
                this.__cache_TA6kaMmquKML5N2vaeTSEV = __cache_TA6kaMmquKML5N2vaeTSEV;
                this.__cp_GUJnFJVl1XcNpnYFK5Zg16 = __cp_GUJnFJVl1XcNpnYFK5Zg16;
                this.__p_DWG9MoJ3kq6Mwqk1tWdO9M = __p_DWG9MoJ3kq6Mwqk1tWdO9M;
                this.__p_IomctlBL1VHOouihVnabfS = __p_IomctlBL1VHOouihVnabfS;
                this.__pin_group_Input_In_IomctlBL1VHOouihVnabfS = __pin_group_Input_In_IomctlBL1VHOouihVnabfS;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 361783U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EJQWWf1QDslOEX3cwB0xgt", Name = "PingPongTexture3D_Fluid_C")]
    [n2.SerializableAttribute]
    public class PingPongTexture3D_Fluid_C : n1.VLObject, n4.ISimulationTexture_I, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.PingPongTexture3D_Fluid_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new PingPongTexture3D_Fluid_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.PingPongTexture3D_Fluid_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new PingPongTexture3D_Fluid_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.PingPongTexture3D_Fluid_C GetTexture_(out n27.Texture Texture_Read_Out, out n28.GpuValue<n27.Texture> Texture_Read_Graph_Out, out n27.Texture Texture_ReadWrite_Out, out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_Out)
        {
            n27.Texture __auto_0 = this.Texture_A;
            n27.Texture __auto_1 = this.Texture_B;
            bool __pad_FKImWK2TbHlOjTRbZMCSzC_2 = __slot_FKImWK2TbHlOjTRbZMCSzC;
            bool __pad_VTwfDBVMeb4P1w15nUQT1k_3 = __slot_VTwfDBVMeb4P1w15nUQT1k;
            n27.Texture __auto_4 = this.Texture_A;
            n27.Texture __auto_5 = this.Texture_B;
            bool SetValue_6 = true;
            var Output_7 = this.__p_UUaLxkYJdmrOCepGyDT8F5;
            if (SetValue_6)
            {
                Output_7 = this.__p_UUaLxkYJdmrOCepGyDT8F5.SetValue(Texture_In: __auto_4);
            }

            this.__p_UUaLxkYJdmrOCepGyDT8F5 = Output_7;
            bool SetRW_8 = true;
            var Output_9 = Output_7;
            if (SetRW_8)
            {
                Output_9 = Output_7.SetRW(RW_In: __pad_VTwfDBVMeb4P1w15nUQT1k_3);
            }

            this.__p_UUaLxkYJdmrOCepGyDT8F5 = Output_9;
            var State_Output_11 = Output_9.Update(Output_Out: out n28.GpuValue<n27.Texture> Output_10);
            this.__p_UUaLxkYJdmrOCepGyDT8F5 = State_Output_11;
            bool SetValue_12 = true;
            var Output_13 = this.__p_CWHRJIUlyTSNwlGCIHtTPT;
            if (SetValue_12)
            {
                Output_13 = this.__p_CWHRJIUlyTSNwlGCIHtTPT.SetValue(Texture_In: __auto_5);
            }

            this.__p_CWHRJIUlyTSNwlGCIHtTPT = Output_13;
            bool SetRW_14 = true;
            var Output_15 = Output_13;
            if (SetRW_14)
            {
                Output_15 = Output_13.SetRW(RW_In: __pad_FKImWK2TbHlOjTRbZMCSzC_2);
            }

            this.__p_CWHRJIUlyTSNwlGCIHtTPT = Output_15;
            var State_Output_17 = Output_15.Update(Output_Out: out n28.GpuValue<n27.Texture> Output_16);
            this.__p_CWHRJIUlyTSNwlGCIHtTPT = State_Output_17;
            Texture_Read_Out = __auto_0;
            Texture_Read_Graph_Out = Output_10;
            Texture_ReadWrite_Out = __auto_1;
            Texture_ReadWrite_Graph_Out = Output_16;
            return this;
        }

        public n4.PingPongTexture3D_Fluid_C SwapTexture()
        {
            n27.Texture __auto_0 = this.Texture_A;
            n27.Texture __auto_1 = this.Texture_B;
            this.Texture_B = __auto_0;
            n27.Texture __auto_2 = __auto_0;
            this.Texture_A = __auto_1;
            n27.Texture __auto_3 = __auto_1;
            return this;
        }

        public n4.PingPongTexture3D_Fluid_C Update([n5.SerializedDefaultValueAttribute("16, 16, 16", false)] n6.Int3 Size_In, [n5.SerializedDefaultValueAttribute("R16G16B16A16_Float", false)] n3.PixelFormat Format_In, bool Recreate_In)
        {
            n27.Texture __auto_0 = this.Texture_A;
            n27.Texture __auto_1 = this.Texture_B;
            n42.IGraphicsDataProvider[] Initial_Data_2 = n52._Operations_.CreateDefault<n42.IGraphicsDataProvider>();
            int Array_Size_3 = 1;
            int Mip_Levels_4 = 1;
            bool Is_Unordered_Access_5 = true;
            bool Is_Render_Target_6 = false;
            var State_Output_9 = this.__p_BeBS4Wg4t6DQP2eDngGwUU.Update(Size_In: Size_In, Initial_Data_In: Initial_Data_2, Array_Size_In: Array_Size_3, Mip_Levels_In: Mip_Levels_4, Format_In: Format_In, Is_Unordered_Access_In: Is_Unordered_Access_5, Is_Render_Target_In: Is_Render_Target_6, Recreate_In: Recreate_In, Output_Out: out n27.Texture Output_7, Has_Changed_Out: out bool Has_Changed_8);
            this.__p_BeBS4Wg4t6DQP2eDngGwUU = State_Output_9;
            n42.IGraphicsDataProvider[] Initial_Data_10 = n52._Operations_.CreateDefault<n42.IGraphicsDataProvider>();
            int Array_Size_11 = 1;
            int Mip_Levels_12 = 1;
            bool Is_Unordered_Access_13 = true;
            bool Is_Render_Target_14 = false;
            var State_Output_17 = this.__p_So5cRN2YfjOMH93Fifmzb2.Update(Size_In: Size_In, Initial_Data_In: Initial_Data_10, Array_Size_In: Array_Size_11, Mip_Levels_In: Mip_Levels_12, Format_In: Format_In, Is_Unordered_Access_In: Is_Unordered_Access_13, Is_Render_Target_In: Is_Render_Target_14, Recreate_In: Recreate_In, Output_Out: out n27.Texture Output_15, Has_Changed_Out: out bool Has_Changed_16);
            this.__p_So5cRN2YfjOMH93Fifmzb2 = State_Output_17;
            n27.Texture __auto_18;
            n27.Texture __auto_19;
            if (Has_Changed_8)
            {
                __auto_18 = Output_7;
                __auto_19 = Output_15;
            }
            else
            {
                __auto_18 = __auto_0;
                __auto_19 = __auto_1;
            }

            this.Texture_B = __auto_19;
            n27.Texture __auto_21 = __auto_19;
            this.Texture_A = __auto_18;
            n27.Texture __auto_22 = __auto_18;
            return this;
        }

        public n4.PingPongTexture3D_Fluid_C __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Texture_B = default(n27.Texture);
            this.Texture_A = default(n27.Texture);
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "So5cRN2YfjOMH93Fifmzb2", 361790U);
            var Output_1 = n61.ComputeTexture3D_SO197zGpVYsOMINttv8noS.Create(Node_Context: Node_Context_0);
            this.__p_So5cRN2YfjOMH93Fifmzb2 = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "BeBS4Wg4t6DQP2eDngGwUU", 361837U);
            var Output_3 = n61.ComputeTexture3D_SO197zGpVYsOMINttv8noS.Create(Node_Context: Node_Context_2);
            this.__p_BeBS4Wg4t6DQP2eDngGwUU = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "CWHRJIUlyTSNwlGCIHtTPT", 361956U);
            var Output_5 = n62.TextureIn_Fuse_C.Create(Node_Context: Node_Context_4);
            this.__p_CWHRJIUlyTSNwlGCIHtTPT = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "UUaLxkYJdmrOCepGyDT8F5", 362090U);
            var Output_7 = n62.TextureIn_Fuse_C.Create(Node_Context: Node_Context_6);
            this.__p_UUaLxkYJdmrOCepGyDT8F5 = Output_7;
            return this;
        }

        public n4.PingPongTexture3D_Fluid_C __CreateDefault__()
        {
            this.Texture_B = default(n27.Texture);
            this.Texture_A = default(n27.Texture);
            this.__p_UUaLxkYJdmrOCepGyDT8F5 = n62.TextureIn_Fuse_C.CreateDefault();
            this.__p_CWHRJIUlyTSNwlGCIHtTPT = n62.TextureIn_Fuse_C.CreateDefault();
            this.__p_BeBS4Wg4t6DQP2eDngGwUU = n61.ComputeTexture3D_SO197zGpVYsOMINttv8noS.CreateDefault();
            this.__p_So5cRN2YfjOMH93Fifmzb2 = n61.ComputeTexture3D_SO197zGpVYsOMINttv8noS.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_UUaLxkYJdmrOCepGyDT8F5);
            n1.CompilationHelper.SafeDispose(this.__p_CWHRJIUlyTSNwlGCIHtTPT);
            n1.CompilationHelper.SafeDispose(this.__p_BeBS4Wg4t6DQP2eDngGwUU);
            n1.CompilationHelper.SafeDispose(this.__p_So5cRN2YfjOMH93Fifmzb2);
            return;
        }

        n4.ISimulationTexture_I n4.ISimulationTexture_I.GetTexture(out n27.Texture Texture_Read_Out, out n28.GpuValue<n27.Texture> Texture_Read_Graph_Out, out n27.Texture Texture_ReadWrite_Out, out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetTexture_(out Texture_Read_Out, out Texture_Read_Graph_Out, out Texture_ReadWrite_Out, out Texture_ReadWrite_Graph_Out);
            return __returnValue__;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 362079U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FKImWK2TbHlOjTRbZMCSzC", Name = "__slot_FKImWK2TbHlOjTRbZMCSzC")]
        public static bool __slot_FKImWK2TbHlOjTRbZMCSzC = true;
        [n1.ElementAttribute(TracingId = 362102U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VTwfDBVMeb4P1w15nUQT1k", Name = "__slot_VTwfDBVMeb4P1w15nUQT1k")]
        public static bool __slot_VTwfDBVMeb4P1w15nUQT1k = false;
        [n1.ElementAttribute(TracingId = 361881U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SGArNEm8hIPNubDHmVMiAv", Name = "Texture_B")]
        public n27.Texture Texture_B;
        [n1.ElementAttribute(TracingId = 361877U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IFVKDnlwuxDNYZIidT97Kf", Name = "Texture_A")]
        public n27.Texture Texture_A;
        [n1.ElementAttribute(TracingId = 362090U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UUaLxkYJdmrOCepGyDT8F5", Name = "TextureIn (Fuse)", IsManaged = true, IsAutoGenerated = true)]
        public n62.TextureIn_Fuse_C __p_UUaLxkYJdmrOCepGyDT8F5;
        [n1.ElementAttribute(TracingId = 361956U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CWHRJIUlyTSNwlGCIHtTPT", Name = "TextureIn (Fuse)", IsManaged = true, IsAutoGenerated = true)]
        public n62.TextureIn_Fuse_C __p_CWHRJIUlyTSNwlGCIHtTPT;
        [n1.ElementAttribute(TracingId = 361837U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BeBS4Wg4t6DQP2eDngGwUU", Name = "ComputeTexture3D", IsManaged = true, IsAutoGenerated = true)]
        public n61.ComputeTexture3D_SO197zGpVYsOMINttv8noS __p_BeBS4Wg4t6DQP2eDngGwUU;
        [n1.ElementAttribute(TracingId = 361790U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "So5cRN2YfjOMH93Fifmzb2", Name = "ComputeTexture3D", IsManaged = true, IsAutoGenerated = true)]
        public n61.ComputeTexture3D_SO197zGpVYsOMINttv8noS __p_So5cRN2YfjOMH93Fifmzb2;
        static PingPongTexture3D_Fluid_C()
        {
        }

        public PingPongTexture3D_Fluid_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PingPongTexture3D_Fluid_C(PingPongTexture3D_Fluid_C other): base(other)
        {
            this.Texture_B = other.Texture_B;
            this.Texture_A = other.Texture_A;
            this.__p_UUaLxkYJdmrOCepGyDT8F5 = other.__p_UUaLxkYJdmrOCepGyDT8F5;
            this.__p_CWHRJIUlyTSNwlGCIHtTPT = other.__p_CWHRJIUlyTSNwlGCIHtTPT;
            this.__p_BeBS4Wg4t6DQP2eDngGwUU = other.__p_BeBS4Wg4t6DQP2eDngGwUU;
            this.__p_So5cRN2YfjOMH93Fifmzb2 = other.__p_So5cRN2YfjOMH93Fifmzb2;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Texture_B", in Texture_B), n1.CompilationHelper.GetValueOrExisting(values, "Texture_A", in Texture_A), n1.CompilationHelper.GetValueOrExisting(values, "__p_UUaLxkYJdmrOCepGyDT8F5", in __p_UUaLxkYJdmrOCepGyDT8F5), n1.CompilationHelper.GetValueOrExisting(values, "__p_CWHRJIUlyTSNwlGCIHtTPT", in __p_CWHRJIUlyTSNwlGCIHtTPT), n1.CompilationHelper.GetValueOrExisting(values, "__p_BeBS4Wg4t6DQP2eDngGwUU", in __p_BeBS4Wg4t6DQP2eDngGwUU), n1.CompilationHelper.GetValueOrExisting(values, "__p_So5cRN2YfjOMH93Fifmzb2", in __p_So5cRN2YfjOMH93Fifmzb2));
        }

        internal PingPongTexture3D_Fluid_C __WITH__(n27.Texture Texture_B, n27.Texture Texture_A, n62.TextureIn_Fuse_C __p_UUaLxkYJdmrOCepGyDT8F5, n62.TextureIn_Fuse_C __p_CWHRJIUlyTSNwlGCIHtTPT, n61.ComputeTexture3D_SO197zGpVYsOMINttv8noS __p_BeBS4Wg4t6DQP2eDngGwUU, n61.ComputeTexture3D_SO197zGpVYsOMINttv8noS __p_So5cRN2YfjOMH93Fifmzb2)
        {
            n4.PingPongTexture3D_Fluid_C that_0 = this;
            this.Texture_B = Texture_B;
            this.Texture_A = Texture_A;
            this.__p_UUaLxkYJdmrOCepGyDT8F5 = __p_UUaLxkYJdmrOCepGyDT8F5;
            this.__p_CWHRJIUlyTSNwlGCIHtTPT = __p_CWHRJIUlyTSNwlGCIHtTPT;
            this.__p_BeBS4Wg4t6DQP2eDngGwUU = __p_BeBS4Wg4t6DQP2eDngGwUU;
            this.__p_So5cRN2YfjOMH93Fifmzb2 = __p_So5cRN2YfjOMH93Fifmzb2;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 362293U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FgllyWQspgBQGU9LpN9TR5", Name = "ISimulationTexture_I")]
    public interface ISimulationTexture_I : n1.IVLObject
    {
        public n4.ISimulationTexture_I GetTexture(out n27.Texture Texture_Read_Out, out n28.GpuValue<n27.Texture> Texture_Read_Graph_Out, out n27.Texture Texture_ReadWrite_Out, out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_Out);
    }

    [n1.ElementAttribute(TracingId = 362387U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "N8bfj9Ud7BnLr1U6MHnOTr", Name = "Texture3D_Fluid_C")]
    [n2.SerializableAttribute]
    public class Texture3D_Fluid_C : n1.VLObject, n4.ISimulationTexture_I, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Texture3D_Fluid_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new Texture3D_Fluid_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Texture3D_Fluid_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new Texture3D_Fluid_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Texture3D_Fluid_C GetTexture_(out n27.Texture Texture_Read_Out, out n28.GpuValue<n27.Texture> Texture_Read_Graph_Out, out n27.Texture Texture_ReadWrite_Out, out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_Out)
        {
            n27.Texture __auto_0 = this.Texture;
            bool __pad_B63W1LFzQOHOHCQg19MA0s_1 = __slot_B63W1LFzQOHOHCQg19MA0s;
            bool SetValue_2 = true;
            var Output_3 = this.__p_GYbGeMesOvzMTUeXymbbz1;
            if (SetValue_2)
            {
                Output_3 = this.__p_GYbGeMesOvzMTUeXymbbz1.SetValue(Texture_In: __auto_0);
            }

            this.__p_GYbGeMesOvzMTUeXymbbz1 = Output_3;
            bool SetRW_4 = true;
            var Output_5 = Output_3;
            if (SetRW_4)
            {
                Output_5 = Output_3.SetRW(RW_In: __pad_B63W1LFzQOHOHCQg19MA0s_1);
            }

            this.__p_GYbGeMesOvzMTUeXymbbz1 = Output_5;
            var State_Output_7 = Output_5.Update(Output_Out: out n28.GpuValue<n27.Texture> Output_6);
            this.__p_GYbGeMesOvzMTUeXymbbz1 = State_Output_7;
            Texture_Read_Out = __auto_0;
            Texture_Read_Graph_Out = Output_6;
            Texture_ReadWrite_Out = __auto_0;
            Texture_ReadWrite_Graph_Out = Output_6;
            return this;
        }

        public n4.Texture3D_Fluid_C Update([n5.SerializedDefaultValueAttribute("16, 16, 16", false)] n6.Int3 Size_In, [n5.SerializedDefaultValueAttribute("R16G16B16A16_Float", false)] n3.PixelFormat Format_In, bool Recreate_In)
        {
            n42.IGraphicsDataProvider[] Initial_Data_0 = n52._Operations_.CreateDefault<n42.IGraphicsDataProvider>();
            int Array_Size_1 = 1;
            int Mip_Levels_2 = 1;
            bool Is_Unordered_Access_3 = true;
            bool Is_Render_Target_4 = false;
            var State_Output_7 = this.__p_TyI4GFCqGGMMTXpJIqDHcS.Update(Size_In: Size_In, Initial_Data_In: Initial_Data_0, Array_Size_In: Array_Size_1, Mip_Levels_In: Mip_Levels_2, Format_In: Format_In, Is_Unordered_Access_In: Is_Unordered_Access_3, Is_Render_Target_In: Is_Render_Target_4, Recreate_In: Recreate_In, Output_Out: out n27.Texture Output_5, Has_Changed_Out: out bool Has_Changed_6);
            this.__p_TyI4GFCqGGMMTXpJIqDHcS = State_Output_7;
            this.Texture = Output_5;
            n27.Texture __auto_8 = Output_5;
            return this;
        }

        public n4.Texture3D_Fluid_C __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Texture = default(n27.Texture);
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "TyI4GFCqGGMMTXpJIqDHcS", 362395U);
            var Output_1 = n61.ComputeTexture3D_SO197zGpVYsOMINttv8noS.Create(Node_Context: Node_Context_0);
            this.__p_TyI4GFCqGGMMTXpJIqDHcS = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "GYbGeMesOvzMTUeXymbbz1", 362432U);
            var Output_3 = n62.TextureIn_Fuse_C.Create(Node_Context: Node_Context_2);
            this.__p_GYbGeMesOvzMTUeXymbbz1 = Output_3;
            return this;
        }

        public n4.Texture3D_Fluid_C __CreateDefault__()
        {
            this.Texture = default(n27.Texture);
            this.__p_GYbGeMesOvzMTUeXymbbz1 = n62.TextureIn_Fuse_C.CreateDefault();
            this.__p_TyI4GFCqGGMMTXpJIqDHcS = n61.ComputeTexture3D_SO197zGpVYsOMINttv8noS.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_GYbGeMesOvzMTUeXymbbz1);
            n1.CompilationHelper.SafeDispose(this.__p_TyI4GFCqGGMMTXpJIqDHcS);
            return;
        }

        n4.ISimulationTexture_I n4.ISimulationTexture_I.GetTexture(out n27.Texture Texture_Read_Out, out n28.GpuValue<n27.Texture> Texture_Read_Graph_Out, out n27.Texture Texture_ReadWrite_Out, out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetTexture_(out Texture_Read_Out, out Texture_Read_Graph_Out, out Texture_ReadWrite_Out, out Texture_ReadWrite_Graph_Out);
            return __returnValue__;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 362454U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "B63W1LFzQOHOHCQg19MA0s", Name = "__slot_B63W1LFzQOHOHCQg19MA0s")]
        public static bool __slot_B63W1LFzQOHOHCQg19MA0s = true;
        [n1.ElementAttribute(TracingId = 362430U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BvgpX8FXNTcQMcWhfzfnQl", Name = "Texture")]
        public n27.Texture Texture;
        [n1.ElementAttribute(TracingId = 362432U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GYbGeMesOvzMTUeXymbbz1", Name = "TextureIn (Fuse)", IsManaged = true, IsAutoGenerated = true)]
        public n62.TextureIn_Fuse_C __p_GYbGeMesOvzMTUeXymbbz1;
        [n1.ElementAttribute(TracingId = 362395U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TyI4GFCqGGMMTXpJIqDHcS", Name = "ComputeTexture3D", IsManaged = true, IsAutoGenerated = true)]
        public n61.ComputeTexture3D_SO197zGpVYsOMINttv8noS __p_TyI4GFCqGGMMTXpJIqDHcS;
        static Texture3D_Fluid_C()
        {
        }

        public Texture3D_Fluid_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Texture3D_Fluid_C(Texture3D_Fluid_C other): base(other)
        {
            this.Texture = other.Texture;
            this.__p_GYbGeMesOvzMTUeXymbbz1 = other.__p_GYbGeMesOvzMTUeXymbbz1;
            this.__p_TyI4GFCqGGMMTXpJIqDHcS = other.__p_TyI4GFCqGGMMTXpJIqDHcS;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Texture", in Texture), n1.CompilationHelper.GetValueOrExisting(values, "__p_GYbGeMesOvzMTUeXymbbz1", in __p_GYbGeMesOvzMTUeXymbbz1), n1.CompilationHelper.GetValueOrExisting(values, "__p_TyI4GFCqGGMMTXpJIqDHcS", in __p_TyI4GFCqGGMMTXpJIqDHcS));
        }

        internal Texture3D_Fluid_C __WITH__(n27.Texture Texture, n62.TextureIn_Fuse_C __p_GYbGeMesOvzMTUeXymbbz1, n61.ComputeTexture3D_SO197zGpVYsOMINttv8noS __p_TyI4GFCqGGMMTXpJIqDHcS)
        {
            n4.Texture3D_Fluid_C that_0 = this;
            this.Texture = Texture;
            this.__p_GYbGeMesOvzMTUeXymbbz1 = __p_GYbGeMesOvzMTUeXymbbz1;
            this.__p_TyI4GFCqGGMMTXpJIqDHcS = __p_TyI4GFCqGGMMTXpJIqDHcS;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 362587U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "PFbJuQWNlkCPT1qxbbodp8", Name = "TextureAdvector_C")]
    [n2.SerializableAttribute]
    public class TextureAdvector_C : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.TextureAdvector_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new TextureAdvector_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.TextureAdvector_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new TextureAdvector_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.TextureAdvector_C Split(out string Name_Out, out string VectorField_Texture_Id_Out, out string Target_Texture_Id_Out, out float Modulate_Out, out float Forward_Out, out bool Enabled_Out)
        {
            string __auto_0 = this.Name;
            string __auto_1 = this.VectorField_Texture_Id;
            string __auto_2 = this.Target_Texture_Id;
            float __auto_3 = this.Modulate;
            float __auto_4 = this.Forward;
            bool __auto_5 = this.Enabled;
            Name_Out = __auto_0;
            VectorField_Texture_Id_Out = __auto_1;
            Target_Texture_Id_Out = __auto_2;
            Modulate_Out = __auto_3;
            Forward_Out = __auto_4;
            Enabled_Out = __auto_5;
            return this;
        }

        public n4.TextureAdvector_C Update(string Name_In, string VectorField_Texture_Id_In, string Target_Texture_Id_In, [n5.SerializedDefaultValueAttribute("1", false)] float Modulate_In, [n5.SerializedDefaultValueAttribute("1", false)] float Forward_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In)
        {
            this.Name = Name_In;
            string __auto_0 = Name_In;
            this.VectorField_Texture_Id = VectorField_Texture_Id_In;
            string __auto_1 = VectorField_Texture_Id_In;
            this.Target_Texture_Id = Target_Texture_Id_In;
            string __auto_2 = Target_Texture_Id_In;
            this.Modulate = Modulate_In;
            float __auto_3 = Modulate_In;
            this.Forward = Forward_In;
            float __auto_4 = Forward_In;
            this.Enabled = Enabled_In;
            bool __auto_5 = Enabled_In;
            return this;
        }

        public n4.TextureAdvector_C __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.VectorField_Texture_Id = "";
            this.Target_Texture_Id = "";
            this.Name = "";
            this.Forward = 0F;
            this.Enabled = false;
            this.Modulate = 0F;
            return this;
        }

        public n4.TextureAdvector_C __CreateDefault__()
        {
            this.VectorField_Texture_Id = "";
            this.Target_Texture_Id = "";
            this.Name = "";
            this.Forward = 0F;
            this.Enabled = false;
            this.Modulate = 0F;
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

        [n1.ElementAttribute(TracingId = 362593U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FIiBNJPm0ptNK90BDmEy4v", Name = "VectorField Texture Id")]
        public string VectorField_Texture_Id;
        [n1.ElementAttribute(TracingId = 362598U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TQDJgwPfXetM8iMJbNsqol", Name = "Target Texture Id")]
        public string Target_Texture_Id;
        [n1.ElementAttribute(TracingId = 362617U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "K1s5Jtv2SXOOhGJeWZKjAu", Name = "Name")]
        public string Name;
        [n1.ElementAttribute(TracingId = 362626U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "N8GCTz6ig9QLw6CHratRqg", Name = "Forward")]
        public float Forward;
        [n1.ElementAttribute(TracingId = 362638U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MtQ9A3fKhOgOfOa0qE8fXl", Name = "Enabled")]
        public bool Enabled;
        [n1.ElementAttribute(TracingId = 362649U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KZ530ckpvv5Odos4CGRygd", Name = "Modulate")]
        public float Modulate;
        public TextureAdvector_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TextureAdvector_C(TextureAdvector_C other): base(other)
        {
            this.VectorField_Texture_Id = other.VectorField_Texture_Id;
            this.Target_Texture_Id = other.Target_Texture_Id;
            this.Name = other.Name;
            this.Forward = other.Forward;
            this.Enabled = other.Enabled;
            this.Modulate = other.Modulate;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "VectorField_Texture_Id", in VectorField_Texture_Id), n1.CompilationHelper.GetValueOrExisting(values, "Target_Texture_Id", in Target_Texture_Id), n1.CompilationHelper.GetValueOrExisting(values, "Name", in Name), n1.CompilationHelper.GetValueOrExisting(values, "Forward", in Forward), n1.CompilationHelper.GetValueOrExisting(values, "Enabled", in Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Modulate", in Modulate));
        }

        internal TextureAdvector_C __WITH__(string VectorField_Texture_Id, string Target_Texture_Id, string Name, float Forward, bool Enabled, float Modulate)
        {
            n4.TextureAdvector_C that_0 = this;
            this.VectorField_Texture_Id = VectorField_Texture_Id;
            this.Target_Texture_Id = Target_Texture_Id;
            this.Name = Name;
            this.Forward = Forward;
            this.Enabled = Enabled;
            this.Modulate = Modulate;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 362813U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OGd3KtwNPMwNO7RtSuhg08", Name = "Fuse_Fluid3DApplication_OGd3KtwNPMwNO7RtSuhg08")]
    [n2.SerializableAttribute]
    public class Fuse_Fluid3DApplication_OGd3KtwNPMwNO7RtSuhg08 : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Fuse_Fluid3DApplication_OGd3KtwNPMwNO7RtSuhg08 Create(n1.NodeContext Node_Context)
        {
            var instance = new Fuse_Fluid3DApplication_OGd3KtwNPMwNO7RtSuhg08(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Fuse_Fluid3DApplication_OGd3KtwNPMwNO7RtSuhg08 CreateDefault()
        {
            var instance = new Fuse_Fluid3DApplication_OGd3KtwNPMwNO7RtSuhg08(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Fuse_Fluid3DApplication_OGd3KtwNPMwNO7RtSuhg08 Update()
        {
            return this;
        }

        public n4.Fuse_Fluid3DApplication_OGd3KtwNPMwNO7RtSuhg08 __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n4.Fuse_Fluid3DApplication_OGd3KtwNPMwNO7RtSuhg08 __CreateDefault__()
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

        public Fuse_Fluid3DApplication_OGd3KtwNPMwNO7RtSuhg08(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Fuse_Fluid3DApplication_OGd3KtwNPMwNO7RtSuhg08(Fuse_Fluid3DApplication_OGd3KtwNPMwNO7RtSuhg08 other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal Fuse_Fluid3DApplication_OGd3KtwNPMwNO7RtSuhg08 __WITH__()
        {
            return this;
        }
    }
}

namespace _Fuse_Fluid3D_.Fuse.Fluid3D.VolumeRaymarching
{
    [n1.ElementAttribute(TracingId = 343894U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "V4EAZMiJ0cQNNERN7rr9iY", Name = "GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY")]
    [n2.SerializableAttribute]
    public class GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n45.GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY Create(n1.NodeContext Node_Context)
        {
            var instance = new GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n45.GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY CreateDefault()
        {
            var instance = new GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n45.GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY Update(n6.Matrix Volume_Transformation_In, n6.Matrix View_Projection_In, out n6.Vector2 Center_Out, out n6.Vector2 Width_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_NcibIAidtDoOR3N4EhrzBs;
            if (manager_2 is null)
            {
                manager_2 = new n13.Manager<n2.ValueTuple<n6.Matrix, n6.Matrix>, n2.ValueTuple<n6.Vector2, n6.Vector2>>((n40._Operations_.CreateDefault(), n40._Operations_.CreateDefault()));
            }

            var inputs_3 = (Volume_Transformation_In, View_Projection_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__Ki8uqPsbRnNLXco6EMKMVQ>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __Ki8uqPsbRnNLXco6EMKMVQ(__GetContext__(), n1.VLObject.NewIdentity());
                    n6.Vector3 Center_7 = n7._Operations_.CreateDefault();
                    n6.Vector3 Size_8 = __c_SCe1fGTNU0cOm2xfsXMEor;
                    var Result_9 = n8.BoxExtensions.CreateCenterSize(center: ref Center_7, size: ref Size_8);
                    state_6.__slot_CHsTL4wr2KfPNb3b7O85CJ = Result_9;
                    n8.OrientedBoundingBox __pad_CHsTL4wr2KfPNb3b7O85CJ_10 = Result_9;
                }

                n8.OrientedBoundingBox __pad_CHsTL4wr2KfPNb3b7O85CJ_11 = state_6.__slot_CHsTL4wr2KfPNb3b7O85CJ;
                var Output_12 = n8.BoxExtensions.Transform(input: ref __pad_CHsTL4wr2KfPNb3b7O85CJ_11, transformation: ref Volume_Transformation_In);
                var Result_13 = Output_12.GetCorners();
                var Max_Value_14 = float.MaxValue;
                var Output_15 = new n6.Vector2(x: Max_Value_14, y: Max_Value_14);
                var Min_Value_16 = float.MinValue;
                var Output_17 = new n6.Vector2(x: Min_Value_16, y: Min_Value_16);
                n6.Vector2 accumulator_19 = Output_15;
                n6.Vector2 accumulator_20 = Output_17;
                var i_22 = 0;
                foreach (var item_18 in Result_13)
                {
                    var splicer_21 = item_18;
                    var i_local_23 = i_22;
                    n63._Operations_.ProjectToScreen(Input_In: splicer_21, View_Projection_In: View_Projection_In, Output_Out: out n6.Vector2 Output_25);
                    n40._Operations_.Min(Input_In: Output_25, Input_2_In: accumulator_19, Output_Out: out n6.Vector2 Output_26);
                    n40._Operations_.Max(Input_In: Output_25, Input_2_In: accumulator_20, Output_Out: out n6.Vector2 Output_27);
                    n6.Vector2 Input_2_28 = __c_CBvhLcBpICrON8gmiNMwBE;
                    n40._Operations_.Min(Input_In: Output_27, Input_2_In: Input_2_28, Output_Out: out n6.Vector2 Output_29);
                    n6.Vector2 Input_2_30 = __c_ClxbMvgECPWLutpdXgBMf7;
                    n40._Operations_.Max(Input_In: Output_26, Input_2_In: Input_2_30, Output_Out: out n6.Vector2 Output_31);
                    accumulator_19 = Output_31;
                    accumulator_20 = Output_29;
                    i_22++;
                }

                n64._Operations_.Range_Join<n6.Vector2>(From_In: accumulator_19, To_In: accumulator_20, Output_Out: out n8.Range<n6.Vector2> Output_32);
                n64._Operations_.GetCenterWidth<n6.Vector2, n31.__AdaptiveImplementations__KeWf79wIWCVN4a6TzD33r2>(Input_In: Output_32, Center_Out: out n6.Vector2 Center_33, Width_Out: out n6.Vector2 Width_34);
                outputs_4 = (Center_33, Width_34);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_35, __auto_36) = outputs_4;
            Center_Out = __auto_35;
            Width_Out = __auto_36;
            n45.GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY that_37 = this;
            if (this.__GetContext__().IsImmutable)
                that_37 = manager_2 != this.__cache_NcibIAidtDoOR3N4EhrzBs ? new GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY(this)
                {__cache_NcibIAidtDoOR3N4EhrzBs = manager_2} : that_37;
            else
            {
                this.__cache_NcibIAidtDoOR3N4EhrzBs = manager_2;
            }

            return that_37;
        }

        public n45.GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n45.GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY that_0 = this;
            this.__cache_NcibIAidtDoOR3N4EhrzBs = null;
            return that_0;
        }

        public n45.GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY __CreateDefault__()
        {
            n45.GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY that_0 = this;
            this.__cache_NcibIAidtDoOR3N4EhrzBs = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_NcibIAidtDoOR3N4EhrzBs);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 343911U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NcibIAidtDoOR3N4EhrzBs", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<n6.Matrix, n6.Matrix>, n2.ValueTuple<n6.Vector2, n6.Vector2>> __cache_NcibIAidtDoOR3N4EhrzBs = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.Vector3 __c_SCe1fGTNU0cOm2xfsXMEor = n1.CompilationHelper.Deserialize<n6.Vector3>("1, 1, 1", false, "KeWf79wIWCVN4a6TzD33r2", "SCe1fGTNU0cOm2xfsXMEor");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.Vector2 __c_CBvhLcBpICrON8gmiNMwBE = n1.CompilationHelper.Deserialize<n6.Vector2>("1, 1", false, "KeWf79wIWCVN4a6TzD33r2", "CBvhLcBpICrON8gmiNMwBE");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.Vector2 __c_ClxbMvgECPWLutpdXgBMf7 = n1.CompilationHelper.Deserialize<n6.Vector2>("-1, -1", false, "KeWf79wIWCVN4a6TzD33r2", "ClxbMvgECPWLutpdXgBMf7");
        static GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY()
        {
        }

        public GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY(GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY other): base(other)
        {
            this.__cache_NcibIAidtDoOR3N4EhrzBs = other.__cache_NcibIAidtDoOR3N4EhrzBs;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_NcibIAidtDoOR3N4EhrzBs", in __cache_NcibIAidtDoOR3N4EhrzBs));
        }

        internal GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY __WITH__(n13.Manager<n2.ValueTuple<n6.Matrix, n6.Matrix>, n2.ValueTuple<n6.Vector2, n6.Vector2>> __cache_NcibIAidtDoOR3N4EhrzBs)
        {
            n45.GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_NcibIAidtDoOR3N4EhrzBs != this.__cache_NcibIAidtDoOR3N4EhrzBs ? new GetScreenCoverageQuad_V4EAZMiJ0cQNNERN7rr9iY(this)
                {__cache_NcibIAidtDoOR3N4EhrzBs = __cache_NcibIAidtDoOR3N4EhrzBs} : that_0;
            else
            {
                this.__cache_NcibIAidtDoOR3N4EhrzBs = __cache_NcibIAidtDoOR3N4EhrzBs;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Ki8uqPsbRnNLXco6EMKMVQ", Name = "__Ki8uqPsbRnNLXco6EMKMVQ")]
        [n2.SerializableAttribute]
        public class __Ki8uqPsbRnNLXco6EMKMVQ : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(TracingId = 344338U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CHsTL4wr2KfPNb3b7O85CJ", Name = "__slot_CHsTL4wr2KfPNb3b7O85CJ")]
            public n8.OrientedBoundingBox __slot_CHsTL4wr2KfPNb3b7O85CJ;
            public __Ki8uqPsbRnNLXco6EMKMVQ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Ki8uqPsbRnNLXco6EMKMVQ(__Ki8uqPsbRnNLXco6EMKMVQ other): base(other)
            {
                this.__slot_CHsTL4wr2KfPNb3b7O85CJ = other.__slot_CHsTL4wr2KfPNb3b7O85CJ;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_CHsTL4wr2KfPNb3b7O85CJ", in __slot_CHsTL4wr2KfPNb3b7O85CJ));
            }

            internal __Ki8uqPsbRnNLXco6EMKMVQ __WITH__(n8.OrientedBoundingBox __slot_CHsTL4wr2KfPNb3b7O85CJ)
            {
                __Ki8uqPsbRnNLXco6EMKMVQ that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = !n22.EqualityComparer<n8.OrientedBoundingBox>.Default.Equals(__slot_CHsTL4wr2KfPNb3b7O85CJ, this.__slot_CHsTL4wr2KfPNb3b7O85CJ) ? new __Ki8uqPsbRnNLXco6EMKMVQ(this)
                    {__slot_CHsTL4wr2KfPNb3b7O85CJ = __slot_CHsTL4wr2KfPNb3b7O85CJ} : that_0;
                else
                {
                    this.__slot_CHsTL4wr2KfPNb3b7O85CJ = __slot_CHsTL4wr2KfPNb3b7O85CJ;
                }

                return that_0;
            }
        }
    }
}

namespace _Fuse_Fluid3D_.Fuse.Fluid3D.VolumeRaymarching.GetScreenCoverageQuad
{
    [n1.ElementAttribute(TracingId = 339767U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ProjectToScreen(n6.Vector3 Input_In, n6.Matrix View_Projection_In, out n6.Vector2 Output_Out)
        {
            n6.Vector3.Transform(vector: ref Input_In, transform: ref View_Projection_In, result: out n6.Vector4 Result_0);
            var Result_1 = (n6.Vector2)Result_0;
            var W_2 = Result_0.W;
            n8.Vector2Nodes.DivScale(input: ref Result_1, scalar: W_2, output: out n6.Vector2 Output_3);
            Output_Out = Output_3;
            return;
        }
    }
}

namespace _Fuse_Fluid3D_.Fuse.Fluid3D.Component
{
    [n1.ElementAttribute(TracingId = 349035U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EtreCtuZ37vLc1RDPtHJ5O", Name = "SphericalImpulse_C")]
    [n2.SerializableAttribute]
    public class SphericalImpulse_C : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n11.SphericalImpulse_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new SphericalImpulse_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.SphericalImpulse_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new SphericalImpulse_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.SphericalImpulse_C Split(out n6.Vector3 Position_Out, out n6.Vector3 FluidVolumePosition_Out, out float Radius_Out, out n6.Vector3 Impulse_Value_Out, out n6.Color4 Helper_Color_Out)
        {
            n6.Vector3 __auto_0 = this.Position;
            n6.Vector3 __auto_1 = this.FluidVolumePosition;
            float __auto_2 = this.Radius;
            n6.Vector3 __auto_3 = this.Impulse_Value;
            n6.Color4 __auto_4 = this.Helper_Color;
            Position_Out = __auto_0;
            FluidVolumePosition_Out = __auto_1;
            Radius_Out = __auto_2;
            Impulse_Value_Out = __auto_3;
            Helper_Color_Out = __auto_4;
            return this;
        }

        public n11.SphericalImpulse_C Update(n6.Vector3 Position_In, [n5.SerializedDefaultValueAttribute("0.2", false)] float Radius_In, [n5.SerializedDefaultValueAttribute("0, 1, 0", false)] n6.Vector3 Impulse_Value_In, n6.Color4 Helper_Color_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Helper_Henabled_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In)
        {
            this.Position = Position_In;
            n6.Vector3 __auto_0 = Position_In;
            this.Radius = Radius_In;
            float __auto_1 = Radius_In;
            this.Impulse_Value = Impulse_Value_In;
            n6.Vector3 __auto_2 = Impulse_Value_In;
            this.Helper_Color = Helper_Color_In;
            n6.Color4 __auto_3 = Helper_Color_In;
            this.Helper_Henabled = Helper_Henabled_In;
            bool __auto_4 = Helper_Henabled_In;
            this.Enabled = Enabled_In;
            bool __auto_5 = Enabled_In;
            return this;
        }

        public n11.SphericalImpulse_C ApplyVolumeTransform(n6.Matrix Volume_Transform_Inverse_In, n6.Vector3 Volume_Resolution_In, out bool Is_Inside_Out)
        {
            n6.Vector3 __auto_0 = this.Position;
            n6.Vector3 __pad_EWCDbAgOTZaLn26bZ2ShZR_1 = __slot_EWCDbAgOTZaLn26bZ2ShZR;
            n6.Vector3 __pad_JM3bXysYGuSLWOpCYb2hzD_2 = __slot_JM3bXysYGuSLWOpCYb2hzD;
            n6.Vector3.TransformCoordinate(coordinate: ref __auto_0, transform: ref Volume_Transform_Inverse_In, result: out n6.Vector3 Output_3);
            n6.Vector3 Output_Minimum_4 = n7._Operations_.CreateDefault();
            n65._Operations_.Map<n6.Vector3, n31.__AdaptiveImplementations__KeWf79wIWCVN4a6TzD33r2>(Input_In: Output_3, Input_Minimum_In: __pad_EWCDbAgOTZaLn26bZ2ShZR_1, Input_Maximum_In: __pad_JM3bXysYGuSLWOpCYb2hzD_2, Output_Minimum_In: Output_Minimum_4, Output_Maximum_In: Volume_Resolution_In, Output_Out: out n6.Vector3 Output_5);
            this.FluidVolumePosition = Output_5;
            n6.Vector3 __auto_6 = Output_5;
            n7._Operations_.Abs(Input_In: Output_3, Output_Out: out n6.Vector3 Output_7);
            n7._Operations_.OperatorLess_Component(Input_In: Output_7, Input_2_In: __pad_JM3bXysYGuSLWOpCYb2hzD_2, Result_Out: out n6.Vector3 Result_8);
            n8.Vector3Nodes.Vector(input: ref Result_8, x: out float X_9, y: out float Y_10, z: out float Z_11);
            float Input_2_12 = 0F;
            var Result_13 = X_9 > Input_2_12;
            float Input_2_14 = 0F;
            var Result_15 = Y_10 > Input_2_14;
            float Input_2_16 = 0F;
            var Result_17 = Z_11 > Input_2_16;
            var Output_18 = Result_13 && Result_15;
            var Output_19 = Output_18 && Result_17;
            Is_Inside_Out = Output_19;
            return this;
        }

        public n11.SphericalImpulse_C Join(n6.Vector3 Position_In, float Radius_In, n6.Vector3 Impulse_Value_In, n6.Color4 Helper_Color_In)
        {
            this.Position = Position_In;
            n6.Vector3 __auto_0 = Position_In;
            this.Radius = Radius_In;
            float __auto_1 = Radius_In;
            this.Impulse_Value = Impulse_Value_In;
            n6.Vector3 __auto_2 = Impulse_Value_In;
            this.Helper_Color = Helper_Color_In;
            n6.Color4 __auto_3 = Helper_Color_In;
            return this;
        }

        public n11.SphericalImpulse_C GetCompactData(out n6.Vector4 PosSize_Out, out n6.Vector4 Impulse_Value_Out)
        {
            n6.Vector3 __auto_0 = this.FluidVolumePosition;
            float __auto_1 = this.Radius;
            n6.Vector3 __auto_2 = this.Impulse_Value;
            float Input_3 = 1F;
            var Output_4 = (float)Input_3 / __auto_1;
            var Result_5 = n8.Vector3Nodes.ToVector4(input: ref __auto_0, w: Output_4);
            float W_6 = 1F;
            var Result_7 = n8.Vector3Nodes.ToVector4(input: ref __auto_2, w: W_6);
            PosSize_Out = Result_5;
            Impulse_Value_Out = Result_7;
            return this;
        }

        public n11.SphericalImpulse_C GetHelperEnabled(out bool Helper_Henabled_Out)
        {
            bool __auto_0 = this.Helper_Henabled;
            Helper_Henabled_Out = __auto_0;
            return this;
        }

        public n11.SphericalImpulse_C GetHelperEntity(out n43.Entity Helper_Entity_Out)
        {
            float __auto_0 = this.Radius;
            n6.Vector3 __auto_1 = this.Position;
            n6.Color4 __auto_2 = this.Helper_Color;
            n6.Vector3 __auto_3 = this.Impulse_Value;
            var Output_4 = new n6.Vector3(x: __auto_0, y: __auto_0, z: __auto_0);
            float Scalar_5 = 0.1F;
            n8.Vector3Nodes.Scale(input: ref Output_4, scalar: Scalar_5, output: out n6.Vector3 Output_6);
            n6.Matrix Input_7 = n9._Operations_.CreateDefault();
            n6.Vector3 Rotation_8 = n7._Operations_.CreateDefault();
            n10._Operations_.TransformSRT(Input_In: Input_7, Scaling_In: Output_6, Rotation_In: Rotation_8, Translation_In: __auto_1, Output_Out: out n6.Matrix Output_9);
            bool SetTransformation_10 = true;
            var Output_11 = this.__p_OUws40NbKCwPPx7W22fflM;
            if (SetTransformation_10)
            {
                Output_11 = this.__p_OUws40NbKCwPPx7W22fflM.SetTransformation(Transformation_In: Output_9);
            }

            this.__p_OUws40NbKCwPPx7W22fflM = Output_11;
            bool SetColor_12 = true;
            var Output_13 = this.__p_K0tV6db0xMrPMDWySMM046;
            if (SetColor_12)
            {
                Output_13 = this.__p_K0tV6db0xMrPMDWySMM046.SetColor(Color_In: __auto_2);
            }

            this.__p_K0tV6db0xMrPMDWySMM046 = Output_13;
            var State_Output_15 = Output_13.Update(Output_Out: out n33.Material Output_14);
            this.__p_K0tV6db0xMrPMDWySMM046 = State_Output_15;
            bool SetMaterial_16 = true;
            var Output_17 = Output_11;
            if (SetMaterial_16)
            {
                Output_17 = Output_11.SetMaterial(Material_In: Output_14);
            }

            this.__p_OUws40NbKCwPPx7W22fflM = Output_17;
            var Output_19 = Output_17.Update(Entity_Out: out n43.Entity Entity_18);
            this.__p_OUws40NbKCwPPx7W22fflM = Output_19;
            n6.Vector3.Add(left: ref __auto_1, right: ref __auto_3, result: out n6.Vector3 Output_20);
            n6.Matrix Transformation_21 = __c_RU2sjmGlFg0PR6MVjqYNAp;
            float Scale_22 = 1F;
            var State_Output_24 = this.__p_J8fvKhQv8D9MPhGeETT1H6.Update(Transformation_In: Transformation_21, From_In: __auto_1, To_In: Output_20, Color_In: __auto_2, Scale_In: Scale_22, Output_Out: out n38.MeshRenderer_C Output_23);
            this.__p_J8fvKhQv8D9MPhGeETT1H6 = State_Output_24;
            n33.IGraphicsRendererBase Input_25 = (n33.IGraphicsRendererBase)Output_23;
            n35.DrawerRenderStage Render_Stage_26 = __c_OsRPkySflyrQJTGh08kXwl;
            bool Single_Call_Per_Frame_27 = false;
            bool SetupRendering_28 = true;
            var Output_29 = this.__p_CMAUlKqZctXOtQp1Q3uR3f;
            if (SetupRendering_28)
            {
                Output_29 = this.__p_CMAUlKqZctXOtQp1Q3uR3f.SetupRendering(Input_In: Input_25, Render_Stage_In: Render_Stage_26, Single_Call_Per_Frame_In: Single_Call_Per_Frame_27);
            }

            this.__p_CMAUlKqZctXOtQp1Q3uR3f = Output_29;
            var State_Output_31 = Output_29.Update(Output_Out: out n43.Entity Output_30);
            this.__p_CMAUlKqZctXOtQp1Q3uR3f = State_Output_31;
            bool SetChildren_32 = true;
            var builder_33 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG, 2);
            builder_33.Add(Entity_18);
            builder_33.Add(Output_30);
            var __pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG_34 = builder_33.Commit();
            this.__pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG = __pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG_34;
            var Output_35 = this.__p_CmPby8nLuhAQZup8KeaVaG;
            if (SetChildren_32)
            {
                Output_35 = this.__p_CmPby8nLuhAQZup8KeaVaG.SetChildren(Child_In: __pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG_34);
            }

            this.__p_CmPby8nLuhAQZup8KeaVaG = Output_35;
            var State_Output_37 = Output_35.Update(Output_Out: out n43.Entity Output_36);
            this.__p_CmPby8nLuhAQZup8KeaVaG = State_Output_37;
            Helper_Entity_Out = Output_36;
            return this;
        }

        public n11.SphericalImpulse_C GetEnabled(out bool Enabled_Out)
        {
            bool __auto_0 = this.Enabled;
            Enabled_Out = __auto_0;
            return this;
        }

        public n11.SphericalImpulse_C __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Position = n7._Operations_.CreateDefault();
            this.Impulse_Value = n7._Operations_.CreateDefault();
            this.Radius = 0F;
            this.Helper_Color = n50._Operations_.CreateDefault();
            this.FluidVolumePosition = n7._Operations_.CreateDefault();
            this.Helper_Henabled = false;
            this.Enabled = false;
            this.__pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG = n14._Operations_.CreateDefault<n43.Entity>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "OUws40NbKCwPPx7W22fflM", 349524U);
            var Output_1 = n66.Sphere_C.Create(Node_Context: Node_Context_0);
            this.__p_OUws40NbKCwPPx7W22fflM = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "K0tV6db0xMrPMDWySMM046", 349560U);
            var Output_3 = n67.ColorMaterial_ACO3Uqp9Yc6MtJchUA03i9.Create(Node_Context: Node_Context_2);
            this.__p_K0tV6db0xMrPMDWySMM046 = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "J8fvKhQv8D9MPhGeETT1H6", 349598U);
            var Output_5 = n68.ArrowRenderer_KNKDF7wyyK9LxCfeS3EoyX.Create(Node_Context: Node_Context_4);
            this.__p_J8fvKhQv8D9MPhGeETT1H6 = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "CmPby8nLuhAQZup8KeaVaG", 349618U);
            var Output_7 = n47.Group_TqwCZl6Gra4OmgvUg1POgm.Create(Node_Context: Node_Context_6);
            this.__p_CmPby8nLuhAQZup8KeaVaG = Output_7;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "CMAUlKqZctXOtQp1Q3uR3f", 349640U);
            var Output_9 = n44.RenderEntity_HYRtmvUkSb6PheJUi3kp3r.Create(Node_Context: Node_Context_8);
            this.__p_CMAUlKqZctXOtQp1Q3uR3f = Output_9;
            return this;
        }

        public n11.SphericalImpulse_C __CreateDefault__()
        {
            this.Position = n7._Operations_.CreateDefault();
            this.Impulse_Value = n7._Operations_.CreateDefault();
            this.Radius = 0F;
            this.Helper_Color = n50._Operations_.CreateDefault();
            this.FluidVolumePosition = n7._Operations_.CreateDefault();
            this.Helper_Henabled = false;
            this.Enabled = false;
            this.__pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG = n14._Operations_.CreateDefault<n43.Entity>();
            this.__p_OUws40NbKCwPPx7W22fflM = n66.Sphere_C.CreateDefault();
            this.__p_K0tV6db0xMrPMDWySMM046 = n67.ColorMaterial_ACO3Uqp9Yc6MtJchUA03i9.CreateDefault();
            this.__p_J8fvKhQv8D9MPhGeETT1H6 = n68.ArrowRenderer_KNKDF7wyyK9LxCfeS3EoyX.CreateDefault();
            this.__p_CMAUlKqZctXOtQp1Q3uR3f = n44.RenderEntity_HYRtmvUkSb6PheJUi3kp3r.CreateDefault();
            this.__p_CmPby8nLuhAQZup8KeaVaG = n47.Group_TqwCZl6Gra4OmgvUg1POgm.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_OUws40NbKCwPPx7W22fflM);
            n1.CompilationHelper.SafeDispose(this.__p_K0tV6db0xMrPMDWySMM046);
            n1.CompilationHelper.SafeDispose(this.__p_J8fvKhQv8D9MPhGeETT1H6);
            n1.CompilationHelper.SafeDispose(this.__p_CMAUlKqZctXOtQp1Q3uR3f);
            n1.CompilationHelper.SafeDispose(this.__p_CmPby8nLuhAQZup8KeaVaG);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 349152U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EWCDbAgOTZaLn26bZ2ShZR", Name = "__slot_EWCDbAgOTZaLn26bZ2ShZR")]
        public static n6.Vector3 __slot_EWCDbAgOTZaLn26bZ2ShZR = n1.CompilationHelper.Deserialize<n6.Vector3>("-0.5, -0.5, -0.5", false, "KeWf79wIWCVN4a6TzD33r2", "EWCDbAgOTZaLn26bZ2ShZR");
        [n1.ElementAttribute(TracingId = 349160U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JM3bXysYGuSLWOpCYb2hzD", Name = "__slot_JM3bXysYGuSLWOpCYb2hzD")]
        public static n6.Vector3 __slot_JM3bXysYGuSLWOpCYb2hzD = n1.CompilationHelper.Deserialize<n6.Vector3>("0.5, 0.5, 0.5", false, "KeWf79wIWCVN4a6TzD33r2", "JM3bXysYGuSLWOpCYb2hzD");
        [n1.ElementAttribute(TracingId = 349044U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BvgC0ETWsXBNvyJ9I2qkop", Name = "Position")]
        public n6.Vector3 Position;
        [n1.ElementAttribute(TracingId = 349055U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DtwGtGxSNMuPa8j6BptJTK", Name = "Impulse Value")]
        public n6.Vector3 Impulse_Value;
        [n1.ElementAttribute(TracingId = 349064U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JbPLhZ03wqyMZWgPUxG44n", Name = "Radius")]
        public float Radius;
        [n1.ElementAttribute(TracingId = 349078U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "PH1N18fuWuLOdQDotC0zZg", Name = "Helper Color")]
        public n6.Color4 Helper_Color;
        [n1.ElementAttribute(TracingId = 349301U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MIxnhgUP0pDOMyQGncDOxL", Name = "FluidVolumePosition")]
        public n6.Vector3 FluidVolumePosition;
        [n1.ElementAttribute(TracingId = 349469U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "R7TBrdy3l4VNDWvxLksrYX", Name = "Helper Henabled")]
        public bool Helper_Henabled;
        [n1.ElementAttribute(TracingId = 349591U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UOcto9Dc7p7N1VC9p2R7Dn", Name = "Enabled")]
        public bool Enabled;
        [n1.ElementAttribute(TracingId = 349524U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OUws40NbKCwPPx7W22fflM", Name = "Sphere", IsManaged = true, IsAutoGenerated = true)]
        public n66.Sphere_C __p_OUws40NbKCwPPx7W22fflM;
        [n1.ElementAttribute(TracingId = 349560U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "K0tV6db0xMrPMDWySMM046", Name = "ColorMaterial", IsManaged = true, IsAutoGenerated = true)]
        public n67.ColorMaterial_ACO3Uqp9Yc6MtJchUA03i9 __p_K0tV6db0xMrPMDWySMM046;
        [n1.ElementAttribute(TracingId = 349598U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "J8fvKhQv8D9MPhGeETT1H6", Name = "ArrowRenderer", IsManaged = true, IsAutoGenerated = true)]
        public n68.ArrowRenderer_KNKDF7wyyK9LxCfeS3EoyX __p_J8fvKhQv8D9MPhGeETT1H6;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.Matrix __c_RU2sjmGlFg0PR6MVjqYNAp = n1.CompilationHelper.Deserialize<n6.Matrix>("1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1", false, "KeWf79wIWCVN4a6TzD33r2", "RU2sjmGlFg0PR6MVjqYNAp");
        [n1.ElementAttribute(TracingId = 349640U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CMAUlKqZctXOtQp1Q3uR3f", Name = "RenderEntity", IsManaged = true, IsAutoGenerated = true)]
        public n44.RenderEntity_HYRtmvUkSb6PheJUi3kp3r __p_CMAUlKqZctXOtQp1Q3uR3f;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n35.DrawerRenderStage __c_OsRPkySflyrQJTGh08kXwl = n1.CompilationHelper.Deserialize<n35.DrawerRenderStage>("Opaque", false, "KeWf79wIWCVN4a6TzD33r2", "OsRPkySflyrQJTGh08kXwl");
        [n1.ElementAttribute(TracingId = 349618U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CmPby8nLuhAQZup8KeaVaG", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n47.Group_TqwCZl6Gra4OmgvUg1POgm __p_CmPby8nLuhAQZup8KeaVaG;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n43.Entity> __pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG = default(n12.Spread<n43.Entity>);
        static SphericalImpulse_C()
        {
        }

        public SphericalImpulse_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SphericalImpulse_C(SphericalImpulse_C other): base(other)
        {
            this.Position = other.Position;
            this.Impulse_Value = other.Impulse_Value;
            this.Radius = other.Radius;
            this.Helper_Color = other.Helper_Color;
            this.FluidVolumePosition = other.FluidVolumePosition;
            this.Helper_Henabled = other.Helper_Henabled;
            this.Enabled = other.Enabled;
            this.__p_OUws40NbKCwPPx7W22fflM = other.__p_OUws40NbKCwPPx7W22fflM;
            this.__p_K0tV6db0xMrPMDWySMM046 = other.__p_K0tV6db0xMrPMDWySMM046;
            this.__p_J8fvKhQv8D9MPhGeETT1H6 = other.__p_J8fvKhQv8D9MPhGeETT1H6;
            this.__p_CMAUlKqZctXOtQp1Q3uR3f = other.__p_CMAUlKqZctXOtQp1Q3uR3f;
            this.__p_CmPby8nLuhAQZup8KeaVaG = other.__p_CmPby8nLuhAQZup8KeaVaG;
            this.__pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG = other.__pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Position", in Position), n1.CompilationHelper.GetValueOrExisting(values, "Impulse_Value", in Impulse_Value), n1.CompilationHelper.GetValueOrExisting(values, "Radius", in Radius), n1.CompilationHelper.GetValueOrExisting(values, "Helper_Color", in Helper_Color), n1.CompilationHelper.GetValueOrExisting(values, "FluidVolumePosition", in FluidVolumePosition), n1.CompilationHelper.GetValueOrExisting(values, "Helper_Henabled", in Helper_Henabled), n1.CompilationHelper.GetValueOrExisting(values, "Enabled", in Enabled), n1.CompilationHelper.GetValueOrExisting(values, "__p_OUws40NbKCwPPx7W22fflM", in __p_OUws40NbKCwPPx7W22fflM), n1.CompilationHelper.GetValueOrExisting(values, "__p_K0tV6db0xMrPMDWySMM046", in __p_K0tV6db0xMrPMDWySMM046), n1.CompilationHelper.GetValueOrExisting(values, "__p_J8fvKhQv8D9MPhGeETT1H6", in __p_J8fvKhQv8D9MPhGeETT1H6), n1.CompilationHelper.GetValueOrExisting(values, "__p_CMAUlKqZctXOtQp1Q3uR3f", in __p_CMAUlKqZctXOtQp1Q3uR3f), n1.CompilationHelper.GetValueOrExisting(values, "__p_CmPby8nLuhAQZup8KeaVaG", in __p_CmPby8nLuhAQZup8KeaVaG), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG", in __pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG));
        }

        internal SphericalImpulse_C __WITH__(n6.Vector3 Position, n6.Vector3 Impulse_Value, float Radius, n6.Color4 Helper_Color, n6.Vector3 FluidVolumePosition, bool Helper_Henabled, bool Enabled, n66.Sphere_C __p_OUws40NbKCwPPx7W22fflM, n67.ColorMaterial_ACO3Uqp9Yc6MtJchUA03i9 __p_K0tV6db0xMrPMDWySMM046, n68.ArrowRenderer_KNKDF7wyyK9LxCfeS3EoyX __p_J8fvKhQv8D9MPhGeETT1H6, n44.RenderEntity_HYRtmvUkSb6PheJUi3kp3r __p_CMAUlKqZctXOtQp1Q3uR3f, n47.Group_TqwCZl6Gra4OmgvUg1POgm __p_CmPby8nLuhAQZup8KeaVaG, n12.Spread<n43.Entity> __pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG)
        {
            n11.SphericalImpulse_C that_0 = this;
            this.Position = Position;
            this.Impulse_Value = Impulse_Value;
            this.Radius = Radius;
            this.Helper_Color = Helper_Color;
            this.FluidVolumePosition = FluidVolumePosition;
            this.Helper_Henabled = Helper_Henabled;
            this.Enabled = Enabled;
            this.__p_OUws40NbKCwPPx7W22fflM = __p_OUws40NbKCwPPx7W22fflM;
            this.__p_K0tV6db0xMrPMDWySMM046 = __p_K0tV6db0xMrPMDWySMM046;
            this.__p_J8fvKhQv8D9MPhGeETT1H6 = __p_J8fvKhQv8D9MPhGeETT1H6;
            this.__p_CMAUlKqZctXOtQp1Q3uR3f = __p_CMAUlKqZctXOtQp1Q3uR3f;
            this.__p_CmPby8nLuhAQZup8KeaVaG = __p_CmPby8nLuhAQZup8KeaVaG;
            this.__pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG = __pin_group_Child_In_CmPby8nLuhAQZup8KeaVaG;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 350085U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SXQRZIrX6CnNRrjzo9epkZ", Name = "SphericalImpulses_C")]
    [n2.SerializableAttribute]
    public class SphericalImpulses_C : n1.VLObject, n11.IFluidComponent_I, n11.IPostTexAdvectComputeStageProvider_I, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n11.SphericalImpulses_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new SphericalImpulses_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.SphericalImpulses_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new SphericalImpulses_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.SphericalImpulses_C Update_(out n33.IGraphicsRendererBase Compute_Stage_Out)
        {
            bool __auto_0 = this.Enabled;
            n12.Spread<n11.SphericalImpulse_C> __auto_1 = this.Spherical_Impulses;
            n4.FluidContext_C __auto_2 = this.Context;
            n4.FluidContext_C __auto_3 = this.Context;
            string __pad_QYBHhuCRfybLPNUCcbSYhJ_4 = this.__slot_QYBHhuCRfybLPNUCcbSYhJ;
            string __pad_BVY2K3yu954OVM288AEE8W_5 = __slot_BVY2K3yu954OVM288AEE8W;
            n4.FluidContext_C __auto_6 = this.Context;
            var Output_9 = __auto_6.GetDispatch(Thread_Group_Count_Out: out n6.Int3 Thread_Group_Count_7, Thread_Group_Size_Out: out n6.Int3 Thread_Group_Size_8);
            n1.CompilationHelper.WritePin(this.__p_C9wEXl5GQWvPYnuC8lkIUr.Inputs[0], ref Thread_Group_Count_7);
            this.__p_C9wEXl5GQWvPYnuC8lkIUr = this.__p_C9wEXl5GQWvPYnuC8lkIUr;
            n1.CompilationHelper.ReadPin(this.__p_C9wEXl5GQWvPYnuC8lkIUr.Outputs[0], out n32.IComputeEffectDispatcher out_10);
            this.__p_C9wEXl5GQWvPYnuC8lkIUr = this.__p_C9wEXl5GQWvPYnuC8lkIUr;
            n1.CompilationHelper.WritePin(this.__p_GEkGpr00pyOL3HADKpq7bu.Inputs[0], ref out_10);
            this.__p_GEkGpr00pyOL3HADKpq7bu = this.__p_GEkGpr00pyOL3HADKpq7bu;
            n1.CompilationHelper.WritePin(this.__p_GEkGpr00pyOL3HADKpq7bu.Inputs[1], ref Thread_Group_Size_8);
            this.__p_GEkGpr00pyOL3HADKpq7bu = this.__p_GEkGpr00pyOL3HADKpq7bu;
            var Output_16 = __auto_3.GetTextureWithName(Texture_Name_In: __pad_QYBHhuCRfybLPNUCcbSYhJ_4, Texture_Read_Out: out n27.Texture Texture_Read_11, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_12, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_13, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_14, Found_Out: out bool Found_15);
            n1.CompilationHelper.WritePin(this.__p_GEkGpr00pyOL3HADKpq7bu.Inputs[2], ref Texture_Read_11);
            this.__p_GEkGpr00pyOL3HADKpq7bu = this.__p_GEkGpr00pyOL3HADKpq7bu;
            var Output_22 = Output_16.GetTextureWithName(Texture_Name_In: __pad_BVY2K3yu954OVM288AEE8W_5, Texture_Read_Out: out n27.Texture Texture_Read_17, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_18, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_19, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_20, Found_Out: out bool Found_21);
            n1.CompilationHelper.WritePin(this.__p_GEkGpr00pyOL3HADKpq7bu.Inputs[3], ref Texture_Read_17);
            this.__p_GEkGpr00pyOL3HADKpq7bu = this.__p_GEkGpr00pyOL3HADKpq7bu;
            var Output_24 = __auto_2.GetResolutionVector(Resolution_Out: out n6.Vector3 Resolution_23);
            var Output_27 = Output_24.GetTransform(Transform_Out: out n6.Matrix Transform_25, Transform_Inverse_Out: out n6.Matrix Transform_Inverse_26);
            var builder_44 = n5.CollectionBuilders.GetBuilder(this.__cp_Ocei3BvOoOlMAu5u7WJaVW, 16);
            n12.Spread<n6.Vector4> output_45;
            var builder_46 = n5.CollectionBuilders.GetBuilder(this.__cp_QpaEZvNnQtxO9FFhfkTGJR, 16);
            n12.Spread<n6.Vector4> output_47;
            try
            {
                var i_30 = 0;
                foreach (var item_28 in n5.CollectionExtensions.AsSpan(__auto_1))
                {
                    var splicer_29 = item_28;
                    var i_local_31 = i_30;
                    var Output_34 = splicer_29.GetEnabled(Enabled_Out: out bool Enabled_33);
                    n6.Vector4 __auto_35;
                    n6.Vector4 __auto_36;
                    bool __auto_37;
                    if (Enabled_33)
                    {
                        var Output_40 = Output_34.ApplyVolumeTransform(Volume_Transform_Inverse_In: Transform_Inverse_26, Volume_Resolution_In: Resolution_23, Is_Inside_Out: out bool Is_Inside_39);
                        var Output_43 = Output_40.GetCompactData(PosSize_Out: out n6.Vector4 PosSize_41, Impulse_Value_Out: out n6.Vector4 Impulse_Value_42);
                        __auto_35 = PosSize_41;
                        __auto_36 = Impulse_Value_42;
                        __auto_37 = Is_Inside_39;
                    }
                    else
                    {
                        __auto_35 = n69._Operations_.CreateDefault();
                        __auto_36 = n69._Operations_.CreateDefault();
                        __auto_37 = false;
                    }

                    if (__auto_37)
                    {
                        builder_44.Add(__auto_35);
                        builder_46.Add(__auto_36);
                    }

                    i_30++;
                }
            }
            finally
            {
                output_45 = builder_44.Commit();
                this.__cp_Ocei3BvOoOlMAu5u7WJaVW = output_45;
                output_47 = builder_46.Commit();
                this.__cp_QpaEZvNnQtxO9FFhfkTGJR = output_47;
            }

            n22.IEnumerable<n6.Vector4> Input_48 = (n22.IEnumerable<n6.Vector4>)output_47;
            n23._Operations_.Any<n6.Vector4>(Input_In: Input_48, Result_Out: out bool Result_49);
            int Element_Size_In_Bytes_50 = 0;
            int Offset_In_Bytes_51 = 0;
            bool Is_Structured_Buffer_52 = false;
            bool Is_Vertex_Buffer_53 = false;
            bool Is_Index_Buffer_54 = false;
            bool Allow_Raw_Views_55 = false;
            bool Recreate_56 = false;
            var State_Output_59 = this.__p_ICcF07iLmoVOcf7wVdCYaC.Update<n31.__AdaptiveImplementations__KeWf79wIWCVN4a6TzD33r2>(Input_In: output_45, Element_Size_In_Bytes_In: Element_Size_In_Bytes_50, Offset_In_Bytes_In: Offset_In_Bytes_51, Is_Structured_Buffer_In: Is_Structured_Buffer_52, Is_Vertex_Buffer_In: Is_Vertex_Buffer_53, Is_Index_Buffer_In: Is_Index_Buffer_54, Allow_Raw_Views_In: Allow_Raw_Views_55, Recreate_In: Recreate_56, Apply_In: Result_49, Output_Out: out n27.Buffer Output_57, Has_Changed_Out: out bool Has_Changed_58);
            this.__p_ICcF07iLmoVOcf7wVdCYaC = State_Output_59;
            n1.CompilationHelper.WritePin(this.__p_GEkGpr00pyOL3HADKpq7bu.Inputs[4], ref Output_57);
            this.__p_GEkGpr00pyOL3HADKpq7bu = this.__p_GEkGpr00pyOL3HADKpq7bu;
            int Element_Size_In_Bytes_60 = 0;
            int Offset_In_Bytes_61 = 0;
            bool Is_Structured_Buffer_62 = false;
            bool Is_Vertex_Buffer_63 = false;
            bool Is_Index_Buffer_64 = false;
            bool Allow_Raw_Views_65 = false;
            bool Recreate_66 = false;
            var State_Output_69 = this.__p_CIPYBYIYMhYNj4MbOqBwje.Update<n31.__AdaptiveImplementations__KeWf79wIWCVN4a6TzD33r2>(Input_In: output_47, Element_Size_In_Bytes_In: Element_Size_In_Bytes_60, Offset_In_Bytes_In: Offset_In_Bytes_61, Is_Structured_Buffer_In: Is_Structured_Buffer_62, Is_Vertex_Buffer_In: Is_Vertex_Buffer_63, Is_Index_Buffer_In: Is_Index_Buffer_64, Allow_Raw_Views_In: Allow_Raw_Views_65, Recreate_In: Recreate_66, Apply_In: Result_49, Output_Out: out n27.Buffer Output_67, Has_Changed_Out: out bool Has_Changed_68);
            this.__p_CIPYBYIYMhYNj4MbOqBwje = State_Output_69;
            n1.CompilationHelper.WritePin(this.__p_GEkGpr00pyOL3HADKpq7bu.Inputs[5], ref Output_67);
            this.__p_GEkGpr00pyOL3HADKpq7bu = this.__p_GEkGpr00pyOL3HADKpq7bu;
            n1.CompilationHelper.WritePin(this.__p_GEkGpr00pyOL3HADKpq7bu.Inputs[6], ref Texture_ReadWrite_13);
            this.__p_GEkGpr00pyOL3HADKpq7bu = this.__p_GEkGpr00pyOL3HADKpq7bu;
            n22.IEnumerable<n6.Vector4> Input_70 = (n22.IEnumerable<n6.Vector4>)output_47;
            n23._Operations_.Count<n6.Vector4>(Input_In: Input_70, Result_Out: out int Result_71);
            n1.CompilationHelper.WritePin(this.__p_GEkGpr00pyOL3HADKpq7bu.Inputs[10], ref Result_71);
            this.__p_GEkGpr00pyOL3HADKpq7bu = this.__p_GEkGpr00pyOL3HADKpq7bu;
            var Output_74 = this.__p_JznA65GQD1lM5dSJAVs9Ox.Update(Value_In: Result_49, Up_Edge_Out: out bool Up_Edge_72, Down_Edge_Out: out bool Down_Edge_73);
            this.__p_JznA65GQD1lM5dSJAVs9Ox = Output_74;
            var Output_75 = Result_49 || Down_Edge_73;
            var Output_76 = __auto_0 && Output_75;
            n1.CompilationHelper.WritePin(this.__p_GEkGpr00pyOL3HADKpq7bu.Inputs[11], ref Output_76);
            this.__p_GEkGpr00pyOL3HADKpq7bu = this.__p_GEkGpr00pyOL3HADKpq7bu;
            n1.CompilationHelper.ReadPin(this.__p_GEkGpr00pyOL3HADKpq7bu.Outputs[0], out n33.IGraphicsRendererBase out_77);
            this.__p_GEkGpr00pyOL3HADKpq7bu = this.__p_GEkGpr00pyOL3HADKpq7bu;
            n33.IGraphicsRendererBase __auto_78;
            if (Output_76)
            {
                var Output_81 = Output_22.SwapPingPongTextureWithName(Texture_Name_In: __pad_QYBHhuCRfybLPNUCcbSYhJ_4, Found_Out: out bool Found_80);
                __auto_78 = out_77;
            }
            else
            {
                __auto_78 = out_77;
            }

            Compute_Stage_Out = __auto_78;
            return this;
        }

        public n11.SphericalImpulses_C Configure(n12.Spread<n11.SphericalImpulse_C> Spherical_Impulses_In, [n5.SerializedDefaultValueAttribute("Velocity", false)] string Target_Texture_Name_In, float Priority_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Helper_Enabled_In, bool Enabled_In)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_LnPJeWed02mNuLeWDrib4v;
            if (manager_2 is null)
            {
                manager_2 = new n13.Manager<n2.ValueTuple<n12.Spread<n11.SphericalImpulse_C>>, n2.ValueTuple<n12.Spread<n11.SphericalImpulse_C>>>(n2.ValueTuple.Create(n14._Operations_.CreateDefault<n11.SphericalImpulse_C>()));
            }

            var inputs_3 = n2.ValueTuple.Create(Spherical_Impulses_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var __fallback___7 = n1.ServiceRegistry.Current;
                n14._Operations_.Where<n11.SphericalImpulse_C>(Input_In: Spherical_Impulses_In, Predicate_In: (n11.SphericalImpulse_C Input_1_In_9, int Input_2_In_10) =>
                {
                    using var __current_8 = __fallback___7.MakeCurrentIfNone();
                    n15.ObjectHelpers.IsAssigned(x: Input_1_In_9, result: out bool Result_11, notAssigned: out bool Not_Assigned_12);
                    return Result_11;
                }

                , Output_Out: out n12.Spread<n11.SphericalImpulse_C> Output_13);
                outputs_4 = n2.ValueTuple.Create(Output_13);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_14 = outputs_4.Item1;
            this.__cache_LnPJeWed02mNuLeWDrib4v = manager_2;
            this.__slot_QYBHhuCRfybLPNUCcbSYhJ = Target_Texture_Name_In;
            string __pad_QYBHhuCRfybLPNUCcbSYhJ_15 = Target_Texture_Name_In;
            this.Priority = Priority_In;
            float __auto_16 = Priority_In;
            this.Helper_Enabled = Helper_Enabled_In;
            bool __auto_17 = Helper_Enabled_In;
            this.Enabled = Enabled_In;
            bool __auto_18 = Enabled_In;
            this.Spherical_Impulses = __auto_14;
            n12.Spread<n11.SphericalImpulse_C> __auto_19 = __auto_14;
            return this;
        }

        public n11.SphericalImpulses_C GetPriority_(out float Priority_Out)
        {
            float __auto_0 = this.Priority;
            Priority_Out = __auto_0;
            return this;
        }

        public n11.SphericalImpulses_C GetHelperEnabled_(out bool Helper_Enabled_Out)
        {
            bool __auto_0 = this.Helper_Enabled;
            Helper_Enabled_Out = __auto_0;
            return this;
        }

        public n11.SphericalImpulses_C GetHelperEntity_(out n43.Entity Helper_Entity_Out)
        {
            n12.Spread<n11.SphericalImpulse_C> __auto_0 = this.Spherical_Impulses;
            var builder_12 = n5.CollectionBuilders.GetBuilder(this.__cp_BEhZ4uthzIHN1qhlzBT4br, 16);
            n12.Spread<n43.Entity> output_13;
            try
            {
                var i_3 = 0;
                foreach (var item_1 in n5.CollectionExtensions.AsSpan(__auto_0))
                {
                    var splicer_2 = item_1;
                    var i_local_4 = i_3;
                    var Output_7 = splicer_2.GetHelperEnabled(Helper_Henabled_Out: out bool Helper_Henabled_6);
                    n43.Entity __auto_8;
                    if (Helper_Henabled_6)
                    {
                        var Output_11 = Output_7.GetHelperEntity(Helper_Entity_Out: out n43.Entity Helper_Entity_10);
                        __auto_8 = Helper_Entity_10;
                    }
                    else
                    {
                        __auto_8 = default(n43.Entity);
                    }

                    builder_12.Add(__auto_8);
                    i_3++;
                }
            }
            finally
            {
                output_13 = builder_12.Commit();
                this.__cp_BEhZ4uthzIHN1qhlzBT4br = output_13;
            }

            bool SetEntities_14 = true;
            var Output_15 = this.__p_Te6TaArgG3sQGzzRczdCqH;
            if (SetEntities_14)
            {
                Output_15 = this.__p_Te6TaArgG3sQGzzRczdCqH.SetEntities(Children_In: output_13);
            }

            this.__p_Te6TaArgG3sQGzzRczdCqH = Output_15;
            var State_Output_17 = Output_15.Update(Output_Out: out n43.Entity Output_16);
            this.__p_Te6TaArgG3sQGzzRczdCqH = State_Output_17;
            Helper_Entity_Out = Output_16;
            return this;
        }

        public n11.SphericalImpulses_C SetContext_(n4.FluidContext_C Context_In)
        {
            this.Context = Context_In;
            n4.FluidContext_C __auto_0 = Context_In;
            return this;
        }

        public n11.SphericalImpulses_C __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_QYBHhuCRfybLPNUCcbSYhJ = "";
            this.Spherical_Impulses = n14._Operations_.CreateDefault<n11.SphericalImpulse_C>();
            this.Priority = 0F;
            this.Enabled = false;
            this.Helper_Enabled = false;
            this.Context = n4.FluidContext_C.CreateDefault();
            this.__cp_Ocei3BvOoOlMAu5u7WJaVW = n14._Operations_.CreateDefault<n6.Vector4>();
            this.__cp_QpaEZvNnQtxO9FFhfkTGJR = n14._Operations_.CreateDefault<n6.Vector4>();
            this.__cp_BEhZ4uthzIHN1qhlzBT4br = n14._Operations_.CreateDefault<n43.Entity>();
            bool __pad_JKrfAKJMlJZOne8zak3VkJ_0 = __slot_JKrfAKJMlJZOne8zak3VkJ;
            bool __pad_ShXwMBMKyNCLvhXKZTwsXq_1 = __slot_ShXwMBMKyNCLvhXKZTwsXq;
            this.Enabled = __pad_JKrfAKJMlJZOne8zak3VkJ_0;
            bool __auto_2 = __pad_JKrfAKJMlJZOne8zak3VkJ_0;
            this.Helper_Enabled = __pad_ShXwMBMKyNCLvhXKZTwsXq_1;
            bool __auto_3 = __pad_ShXwMBMKyNCLvhXKZTwsXq_1;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "ICcF07iLmoVOcf7wVdCYaC", 350121U);
            var Output_5 = n70.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n12.Spread<n6.Vector4>>.Create(Node_Context: Node_Context_4);
            this.__p_ICcF07iLmoVOcf7wVdCYaC = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "JznA65GQD1lM5dSJAVs9Ox", 350220U);
            var Output_7 = n49.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_6);
            this.__p_JznA65GQD1lM5dSJAVs9Ox = Output_7;
            var node_8 = n1.CompilationHelper.CreateNodeById(Node_Context, "Fluid3DSphericalImpulseShader (Internal)", "Stride.Rendering.ComputeShaders");
            this.__p_GEkGpr00pyOL3HADKpq7bu = node_8;
            var node_9 = n1.CompilationHelper.CreateNodeById(Node_Context, "DirectDispatcher", "Stride.Rendering.Advanced");
            this.__p_C9wEXl5GQWvPYnuC8lkIUr = node_9;
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "CIPYBYIYMhYNj4MbOqBwje", 350312U);
            var Output_11 = n70.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n12.Spread<n6.Vector4>>.Create(Node_Context: Node_Context_10);
            this.__p_CIPYBYIYMhYNj4MbOqBwje = Output_11;
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Te6TaArgG3sQGzzRczdCqH", 350753U);
            var Output_13 = n47.Group_Spectral_OrFKGqkce2jOmqneI85BeX.Create(Node_Context: Node_Context_12);
            this.__p_Te6TaArgG3sQGzzRczdCqH = Output_13;
            this.__cache_LnPJeWed02mNuLeWDrib4v = null;
            return this;
        }

        public n11.SphericalImpulses_C __CreateDefault__()
        {
            this.__slot_QYBHhuCRfybLPNUCcbSYhJ = "";
            this.Spherical_Impulses = n14._Operations_.CreateDefault<n11.SphericalImpulse_C>();
            this.Priority = 0F;
            this.Enabled = false;
            this.Helper_Enabled = false;
            this.Context = n4.FluidContext_C.CreateDefault();
            this.__cp_Ocei3BvOoOlMAu5u7WJaVW = n14._Operations_.CreateDefault<n6.Vector4>();
            this.__cp_QpaEZvNnQtxO9FFhfkTGJR = n14._Operations_.CreateDefault<n6.Vector4>();
            this.__cp_BEhZ4uthzIHN1qhlzBT4br = n14._Operations_.CreateDefault<n43.Entity>();
            this.__p_C9wEXl5GQWvPYnuC8lkIUr = default(n1.IVLNode);
            this.__p_GEkGpr00pyOL3HADKpq7bu = default(n1.IVLNode);
            this.__p_ICcF07iLmoVOcf7wVdCYaC = n70.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n12.Spread<n6.Vector4>>.CreateDefault();
            this.__p_CIPYBYIYMhYNj4MbOqBwje = n70.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n12.Spread<n6.Vector4>>.CreateDefault();
            this.__p_JznA65GQD1lM5dSJAVs9Ox = n49.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__cache_LnPJeWed02mNuLeWDrib4v = null;
            this.__p_Te6TaArgG3sQGzzRczdCqH = n47.Group_Spectral_OrFKGqkce2jOmqneI85BeX.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_C9wEXl5GQWvPYnuC8lkIUr);
            n1.CompilationHelper.SafeDispose(this.__p_GEkGpr00pyOL3HADKpq7bu);
            n1.CompilationHelper.SafeDispose(this.__p_ICcF07iLmoVOcf7wVdCYaC);
            n1.CompilationHelper.SafeDispose(this.__p_CIPYBYIYMhYNj4MbOqBwje);
            n1.CompilationHelper.SafeDispose(this.__p_JznA65GQD1lM5dSJAVs9Ox);
            n1.CompilationHelper.SafeDispose(this.__cache_LnPJeWed02mNuLeWDrib4v);
            n1.CompilationHelper.SafeDispose(this.__p_Te6TaArgG3sQGzzRczdCqH);
            return;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.GetHelperEntity(out n43.Entity Helper_Entity_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetHelperEntity_(out Helper_Entity_Out);
            return __returnValue__;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.GetHelperEnabled(out bool Helper_Enabled_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetHelperEnabled_(out Helper_Enabled_Out);
            return __returnValue__;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.SetContext(n4.FluidContext_C Context_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = SetContext_(Context_In);
            return __returnValue__;
        }

        n11.IPostTexAdvectComputeStageProvider_I n11.IPostTexAdvectComputeStageProvider_I.GetPriority(out float Priority_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetPriority_(out Priority_Out);
            return __returnValue__;
        }

        n11.IPostTexAdvectComputeStageProvider_I n11.IPostTexAdvectComputeStageProvider_I.Update(out n33.IGraphicsRendererBase Compute_Stage_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(out Compute_Stage_Out);
            return __returnValue__;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 350603U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JKrfAKJMlJZOne8zak3VkJ", Name = "__slot_JKrfAKJMlJZOne8zak3VkJ")]
        public static bool __slot_JKrfAKJMlJZOne8zak3VkJ = true;
        [n1.ElementAttribute(TracingId = 350632U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ShXwMBMKyNCLvhXKZTwsXq", Name = "__slot_ShXwMBMKyNCLvhXKZTwsXq")]
        public static bool __slot_ShXwMBMKyNCLvhXKZTwsXq = true;
        [n1.ElementAttribute(TracingId = 350869U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BVY2K3yu954OVM288AEE8W", Name = "__slot_BVY2K3yu954OVM288AEE8W")]
        public static string __slot_BVY2K3yu954OVM288AEE8W = "ObstaclesGradient";
        [n1.ElementAttribute(TracingId = 350898U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QYBHhuCRfybLPNUCcbSYhJ", Name = "__slot_QYBHhuCRfybLPNUCcbSYhJ")]
        public string __slot_QYBHhuCRfybLPNUCcbSYhJ;
        [n1.ElementAttribute(TracingId = 350349U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CI8fWjMYA4TLPTeihMrX2B", Name = "Spherical Impulses")]
        public n12.Spread<n11.SphericalImpulse_C> Spherical_Impulses;
        [n1.ElementAttribute(TracingId = 350585U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EMeTALX0wz7NAN32S5Ehsv", Name = "Priority")]
        public float Priority;
        [n1.ElementAttribute(TracingId = 350598U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EQixjyEY6giPsIvM69Pf6b", Name = "Enabled")]
        public bool Enabled;
        [n1.ElementAttribute(TracingId = 350623U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Niy4h2RF61oMvVHPdACENl", Name = "Helper Enabled")]
        public bool Helper_Enabled;
        [n1.ElementAttribute(TracingId = 350873U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TFsqoPsZzzCMprr0OhxpVK", Name = "Context")]
        public n4.FluidContext_C Context;
        [n1.ElementAttribute(TracingId = 350279U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "C9wEXl5GQWvPYnuC8lkIUr", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
        public n1.IVLNode __p_C9wEXl5GQWvPYnuC8lkIUr;
        [n1.ElementAttribute(TracingId = 350242U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GEkGpr00pyOL3HADKpq7bu", Name = "Fluid3DSphericalImpulseShader", IsManaged = true, IsAutoGenerated = true, NodeName = "Fluid3DSphericalImpulseShader (Internal)", NodeCategory = "Stride.Rendering.ComputeShaders")]
        public n1.IVLNode __p_GEkGpr00pyOL3HADKpq7bu;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n6.Vector4> __cp_Ocei3BvOoOlMAu5u7WJaVW;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n6.Vector4> __cp_QpaEZvNnQtxO9FFhfkTGJR;
        [n1.ElementAttribute(TracingId = 350121U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ICcF07iLmoVOcf7wVdCYaC", Name = "DynamicBuffer", IsManaged = true, IsAutoGenerated = true)]
        public n70.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n12.Spread<n6.Vector4>> __p_ICcF07iLmoVOcf7wVdCYaC;
        [n1.ElementAttribute(TracingId = 350312U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CIPYBYIYMhYNj4MbOqBwje", Name = "DynamicBuffer", IsManaged = true, IsAutoGenerated = true)]
        public n70.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n12.Spread<n6.Vector4>> __p_CIPYBYIYMhYNj4MbOqBwje;
        [n1.ElementAttribute(TracingId = 350220U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JznA65GQD1lM5dSJAVs9Ox", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n49.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_JznA65GQD1lM5dSJAVs9Ox;
        [n1.ElementAttribute(TracingId = 350518U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LnPJeWed02mNuLeWDrib4v", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<n12.Spread<n11.SphericalImpulse_C>>, n2.ValueTuple<n12.Spread<n11.SphericalImpulse_C>>> __cache_LnPJeWed02mNuLeWDrib4v = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n43.Entity> __cp_BEhZ4uthzIHN1qhlzBT4br;
        [n1.ElementAttribute(TracingId = 350753U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Te6TaArgG3sQGzzRczdCqH", Name = "Group (Spectral)", IsManaged = true, IsAutoGenerated = true)]
        public n47.Group_Spectral_OrFKGqkce2jOmqneI85BeX __p_Te6TaArgG3sQGzzRczdCqH;
        static SphericalImpulses_C()
        {
        }

        public SphericalImpulses_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SphericalImpulses_C(SphericalImpulses_C other): base(other)
        {
            this.__slot_QYBHhuCRfybLPNUCcbSYhJ = other.__slot_QYBHhuCRfybLPNUCcbSYhJ;
            this.Spherical_Impulses = other.Spherical_Impulses;
            this.Priority = other.Priority;
            this.Enabled = other.Enabled;
            this.Helper_Enabled = other.Helper_Enabled;
            this.Context = other.Context;
            this.__p_C9wEXl5GQWvPYnuC8lkIUr = other.__p_C9wEXl5GQWvPYnuC8lkIUr;
            this.__p_GEkGpr00pyOL3HADKpq7bu = other.__p_GEkGpr00pyOL3HADKpq7bu;
            this.__cp_Ocei3BvOoOlMAu5u7WJaVW = other.__cp_Ocei3BvOoOlMAu5u7WJaVW;
            this.__cp_QpaEZvNnQtxO9FFhfkTGJR = other.__cp_QpaEZvNnQtxO9FFhfkTGJR;
            this.__p_ICcF07iLmoVOcf7wVdCYaC = other.__p_ICcF07iLmoVOcf7wVdCYaC;
            this.__p_CIPYBYIYMhYNj4MbOqBwje = other.__p_CIPYBYIYMhYNj4MbOqBwje;
            this.__p_JznA65GQD1lM5dSJAVs9Ox = other.__p_JznA65GQD1lM5dSJAVs9Ox;
            this.__cache_LnPJeWed02mNuLeWDrib4v = other.__cache_LnPJeWed02mNuLeWDrib4v;
            this.__cp_BEhZ4uthzIHN1qhlzBT4br = other.__cp_BEhZ4uthzIHN1qhlzBT4br;
            this.__p_Te6TaArgG3sQGzzRczdCqH = other.__p_Te6TaArgG3sQGzzRczdCqH;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_QYBHhuCRfybLPNUCcbSYhJ", in __slot_QYBHhuCRfybLPNUCcbSYhJ), n1.CompilationHelper.GetValueOrExisting(values, "Spherical_Impulses", in Spherical_Impulses), n1.CompilationHelper.GetValueOrExisting(values, "Priority", in Priority), n1.CompilationHelper.GetValueOrExisting(values, "Enabled", in Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Helper_Enabled", in Helper_Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Context", in Context), n1.CompilationHelper.GetValueOrExisting(values, "__p_C9wEXl5GQWvPYnuC8lkIUr", in __p_C9wEXl5GQWvPYnuC8lkIUr), n1.CompilationHelper.GetValueOrExisting(values, "__p_GEkGpr00pyOL3HADKpq7bu", in __p_GEkGpr00pyOL3HADKpq7bu), n1.CompilationHelper.GetValueOrExisting(values, "__cp_Ocei3BvOoOlMAu5u7WJaVW", in __cp_Ocei3BvOoOlMAu5u7WJaVW), n1.CompilationHelper.GetValueOrExisting(values, "__cp_QpaEZvNnQtxO9FFhfkTGJR", in __cp_QpaEZvNnQtxO9FFhfkTGJR), n1.CompilationHelper.GetValueOrExisting(values, "__p_ICcF07iLmoVOcf7wVdCYaC", in __p_ICcF07iLmoVOcf7wVdCYaC), n1.CompilationHelper.GetValueOrExisting(values, "__p_CIPYBYIYMhYNj4MbOqBwje", in __p_CIPYBYIYMhYNj4MbOqBwje), n1.CompilationHelper.GetValueOrExisting(values, "__p_JznA65GQD1lM5dSJAVs9Ox", in __p_JznA65GQD1lM5dSJAVs9Ox), n1.CompilationHelper.GetValueOrExisting(values, "__cache_LnPJeWed02mNuLeWDrib4v", in __cache_LnPJeWed02mNuLeWDrib4v), n1.CompilationHelper.GetValueOrExisting(values, "__cp_BEhZ4uthzIHN1qhlzBT4br", in __cp_BEhZ4uthzIHN1qhlzBT4br), n1.CompilationHelper.GetValueOrExisting(values, "__p_Te6TaArgG3sQGzzRczdCqH", in __p_Te6TaArgG3sQGzzRczdCqH));
        }

        internal SphericalImpulses_C __WITH__(string __slot_QYBHhuCRfybLPNUCcbSYhJ, n12.Spread<n11.SphericalImpulse_C> Spherical_Impulses, float Priority, bool Enabled, bool Helper_Enabled, n4.FluidContext_C Context, n1.IVLNode __p_C9wEXl5GQWvPYnuC8lkIUr, n1.IVLNode __p_GEkGpr00pyOL3HADKpq7bu, n12.Spread<n6.Vector4> __cp_Ocei3BvOoOlMAu5u7WJaVW, n12.Spread<n6.Vector4> __cp_QpaEZvNnQtxO9FFhfkTGJR, n70.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n12.Spread<n6.Vector4>> __p_ICcF07iLmoVOcf7wVdCYaC, n70.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n12.Spread<n6.Vector4>> __p_CIPYBYIYMhYNj4MbOqBwje, n49.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_JznA65GQD1lM5dSJAVs9Ox, n13.Manager<n2.ValueTuple<n12.Spread<n11.SphericalImpulse_C>>, n2.ValueTuple<n12.Spread<n11.SphericalImpulse_C>>> __cache_LnPJeWed02mNuLeWDrib4v, n12.Spread<n43.Entity> __cp_BEhZ4uthzIHN1qhlzBT4br, n47.Group_Spectral_OrFKGqkce2jOmqneI85BeX __p_Te6TaArgG3sQGzzRczdCqH)
        {
            n11.SphericalImpulses_C that_0 = this;
            this.__slot_QYBHhuCRfybLPNUCcbSYhJ = __slot_QYBHhuCRfybLPNUCcbSYhJ;
            this.Spherical_Impulses = Spherical_Impulses;
            this.Priority = Priority;
            this.Enabled = Enabled;
            this.Helper_Enabled = Helper_Enabled;
            this.Context = Context;
            this.__p_C9wEXl5GQWvPYnuC8lkIUr = __p_C9wEXl5GQWvPYnuC8lkIUr;
            this.__p_GEkGpr00pyOL3HADKpq7bu = __p_GEkGpr00pyOL3HADKpq7bu;
            this.__cp_Ocei3BvOoOlMAu5u7WJaVW = __cp_Ocei3BvOoOlMAu5u7WJaVW;
            this.__cp_QpaEZvNnQtxO9FFhfkTGJR = __cp_QpaEZvNnQtxO9FFhfkTGJR;
            this.__p_ICcF07iLmoVOcf7wVdCYaC = __p_ICcF07iLmoVOcf7wVdCYaC;
            this.__p_CIPYBYIYMhYNj4MbOqBwje = __p_CIPYBYIYMhYNj4MbOqBwje;
            this.__p_JznA65GQD1lM5dSJAVs9Ox = __p_JznA65GQD1lM5dSJAVs9Ox;
            this.__cache_LnPJeWed02mNuLeWDrib4v = __cache_LnPJeWed02mNuLeWDrib4v;
            this.__cp_BEhZ4uthzIHN1qhlzBT4br = __cp_BEhZ4uthzIHN1qhlzBT4br;
            this.__p_Te6TaArgG3sQGzzRczdCqH = __p_Te6TaArgG3sQGzzRczdCqH;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 351618U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "U3KicrJo270OgwPj6PRTcC", Name = "ObstacleSDF_C")]
    [n2.SerializableAttribute]
    public class ObstacleSDF_C : n1.VLObject, n11.IPreTexAdvectComputeGraphProvider_I, n11.IFluidComponent_I, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n11.ObstacleSDF_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new ObstacleSDF_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.ObstacleSDF_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new ObstacleSDF_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.ObstacleSDF_C Update_(out n28.GpuValue<n54.GpuVoid> Graph_Out)
        {
            n4.FluidContext_C __auto_0 = this.Context;
            n28.GpuValue<float> __auto_1 = this.SDF;
            float __auto_2 = this.Surface_Border_Thickness;
            bool __auto_3 = this.Enabled;
            n4.FluidContext_C __auto_4 = this.Context;
            string __pad_Eo3a13W3Kx9MDAj2ioVtzm_5 = __slot_Eo3a13W3Kx9MDAj2ioVtzm;
            var Output_11 = __auto_4.GetTextureWithName(Texture_Name_In: __pad_Eo3a13W3Kx9MDAj2ioVtzm_5, Texture_Read_Out: out n27.Texture Texture_Read_6, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_7, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_8, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_9, Found_Out: out bool Found_10);
            var State_Output_13 = this.__p_C5hKA3jXVBaMsUKR4CRYRv.GetOutput(Output_Out: out n28.GpuValue<n6.Int3> Output_12);
            this.__p_C5hKA3jXVBaMsUKR4CRYRv = State_Output_13;
            var Output_16 = __auto_0.GetTransform(Transform_Out: out n6.Matrix Transform_14, Transform_Inverse_Out: out n6.Matrix Transform_Inverse_15);
            var Output_18 = Output_16.GetResolution(Resolution_Out: out n6.Int3 Resolution_17);
            var State_Output_20 = this.__p_F2PNLXM3oqWN9GjmTbjOtC.Update(Cell_Coordinate_In: Output_12, Grid_Resolution_In: Resolution_17, Volume_Transform_In: Transform_14, Output_Out: out n28.GpuValue<n6.Vector3> Output_19);
            this.__p_F2PNLXM3oqWN9GjmTbjOtC = State_Output_20;
            n28.GpuValue<bool> Condition_21 = this.__monadBuilder_UONJoMby7qQQYV9mfui4i8.Return(__auto_3);
            var customRegion_22 = this.__customRegion_TaewM6x2AErMr284kTd08U ?? new n71.CustomRegion();
            this.__customRegion_TaewM6x2AErMr284kTd08U = customRegion_22;
            customRegion_22.newPatchSymbol = 30489873;
            customRegion_22.BeginChanges();
            customRegion_22.AddIncomingLink(typeof(n28.GpuValue<n6.Int3>), 0);
            customRegion_22.AddIncomingLink(typeof(n28.GpuValue<n6.Vector3>), 1);
            customRegion_22.AddIncomingLink(typeof(n28.GpuValue<float>), 2);
            customRegion_22.AddIncomingLink(typeof(float), 3);
            customRegion_22.AddIncomingLink(typeof(n28.GpuValue<float>), 4);
            customRegion_22.AddIncomingLink(typeof(n28.GpuValue<n6.Int3>), 5);
            customRegion_22.AddIncomingLink(typeof(n28.GpuValue<n27.Texture>), 6);
            customRegion_22.AddIncomingLink(typeof(n28.GpuValue<n27.Texture>), 7);
            customRegion_22.AddOutput("", typeof(n28.GpuValue<n54.GpuVoid>), 0);
            customRegion_22.SetInputValues(default(n28.GpuValue<n54.GpuVoid>));
            customRegion_22.SetIncomingLinkValues(Output_12, Output_19, __auto_1, __auto_2, __auto_1, Output_12, Texture_Read_Graph_7, Texture_ReadWrite_Graph_9);
            customRegion_22.EndChanges();
            var __fallback___23 = n1.ServiceRegistry.Current;
            customRegion_22.PatchUpdator = (n2.Object stateInput_26, n22.IReadOnlyList<n2.Object> inputs_27, n22.IReadOnlyList<n2.Object> incomingLinks_28, out n2.Object stateOutput_37, out n12.Spread<n2.Object> outputs_38) =>
            {
                using var __current_24 = __fallback___23.MakeCurrentIfNone();
                var state_25 = n1.CompilationHelper.Restore<__JbEzzfeh9pxO1cvTgHk8o3>(stateInput_26, __GetContext__());
                var link_CRmmvNxlMhWMBpF6IlOfIz_29 = (n28.GpuValue<n6.Int3>)incomingLinks_28[0];
                var link_CUvBDnCRtGrOW5fyWEUVPl_30 = (n28.GpuValue<n6.Vector3>)incomingLinks_28[1];
                var link_RYckpT2AnSLMu7ciWR6a7l_31 = (n28.GpuValue<float>)incomingLinks_28[2];
                var link_PWUrohoG1HON9xpgj98ayX_32 = (float)incomingLinks_28[3];
                var link_Vu31hrDx77LQNnmIWtQnd5_33 = (n28.GpuValue<float>)incomingLinks_28[4];
                var link_FGHTNRzorQyPNm1CKrznVe_34 = (n28.GpuValue<n6.Int3>)incomingLinks_28[5];
                var link_KtHM1IRKye2P7qm1Xb3FdB_35 = (n28.GpuValue<n27.Texture>)incomingLinks_28[6];
                var link_SnfOstP0hQwPsjTrgprFm1_36 = (n28.GpuValue<n27.Texture>)incomingLinks_28[7];
                n15.ObjectHelpers.IsAssigned(x: link_RYckpT2AnSLMu7ciWR6a7l_31, result: out bool Result_39, notAssigned: out bool Not_Assigned_40);
                n28.GpuValue<float> default_41 = default(n28.GpuValue<float>);
                var State_Output_43 = state_25.__p_DbPC5hKseB2NnYDs9BZthT.Update(Texture_In: link_KtHM1IRKye2P7qm1Xb3FdB_35, index_In: link_FGHTNRzorQyPNm1CKrznVe_34, default_In: default_41, Output_Out: out n28.GpuValue<float> Output_42);
                var Output_45 = state_25.__p_RElEA0iTvfCQP1maWqiIfE.Update(Gradient_In: Output_42, Position_In: link_CUvBDnCRtGrOW5fyWEUVPl_30, SDF_In: link_Vu31hrDx77LQNnmIWtQnd5_33, Surface_Border_Thickness_In: link_PWUrohoG1HON9xpgj98ayX_32, Gradient_Out: out n28.GpuValue<float> Gradient_44);
                n39._Operations_.Switch_Boolean<n28.GpuValue<float>>(Condition_In: Result_39, Input_In: Output_42, Input_2_In: Gradient_44, Output_Out: out n28.GpuValue<float> Output_46);
                var State_Output_48 = state_25.__p_TW68V8TYSLqLvOKNbYJpAw.Update(Texture_In: link_SnfOstP0hQwPsjTrgprFm1_36, index_In: link_CRmmvNxlMhWMBpF6IlOfIz_29, value_In: Output_46, Output_Out: out n28.GpuValue<n54.GpuVoid> Output_47);
                state_25.__p_DbPC5hKseB2NnYDs9BZthT = State_Output_43;
                state_25.__p_RElEA0iTvfCQP1maWqiIfE = Output_45;
                state_25.__p_TW68V8TYSLqLvOKNbYJpAw = State_Output_48;
                stateOutput_37 = state_25;
                outputs_38 = n5.CollectionExtensions.CreateSpreadOfObjects(Output_47);
            }

            ;
            customRegion_22.PatchCreator = (n22.IReadOnlyList<n2.Object> initialInputs_50, out n2.Object stateOutput_51, out n12.Spread<n2.Object> initialOutputs_52) =>
            {
                using var __current_49 = __fallback___23.MakeCurrentIfNone();
                var state_25 = new __JbEzzfeh9pxO1cvTgHk8o3(__GetContext__(), n1.VLObject.NewIdentity());
                n1.NodeContext Node_Context_53 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "TW68V8TYSLqLvOKNbYJpAw", 351798U);
                var Output_54 = n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, float>.Create(Node_Context: Node_Context_53);
                state_25.__p_TW68V8TYSLqLvOKNbYJpAw = Output_54;
                n1.NodeContext Node_Context_55 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "RElEA0iTvfCQP1maWqiIfE", 351817U);
                var Output_56 = n11.ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T.Create(Node_Context: Node_Context_55);
                state_25.__p_RElEA0iTvfCQP1maWqiIfE = Output_56;
                n1.NodeContext Node_Context_57 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "DbPC5hKseB2NnYDs9BZthT", 351887U);
                var Output_58 = n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, float>.Create(Node_Context: Node_Context_57);
                state_25.__p_DbPC5hKseB2NnYDs9BZthT = Output_58;
                stateOutput_51 = state_25;
                initialOutputs_52 = n5.CollectionExtensions.CreateSpreadOfObjects(default(n28.GpuValue<n54.GpuVoid>));
            }

            ;
            var Output_60 = this.__p_TaewM6x2AErMr284kTd08U.Update(Condition_In: Condition_21, Region_In: customRegion_22, Has_Changed_Out: out bool Has_Changed_59);
            this.__p_TaewM6x2AErMr284kTd08U = Output_60;
            var __auto_61 = (n28.GpuValue<n54.GpuVoid>)customRegion_22.OutputValues[0];
            Graph_Out = __auto_61;
            return this;
        }

        public n11.ObstacleSDF_C GetHelperEntity_(out n43.Entity Helper_Entity_Out)
        {
            bool __auto_0 = this.Helper_Enabled;
            n28.GpuValue<float> __auto_1 = this.SDF;
            bool AutoCompile_2 = true;
            int Max_Iterations_3 = 180;
            n6.Vector4 Color_4 = __c_IuIlAaxTKvDPgV94JsCZeD;
            n6.Vector3 Bounding_Box_Position_6 = n7._Operations_.CreateDefault();
            n6.Vector3 Bounding_Box_Size_7 = __c_QSO1e22Lvd3L9QZCsClBYc;
            bool Show_Normals_8 = true;
            n28.GpuValue<n6.Vector4> Color_5 = this.__monadBuilder_IuIlAaxTKvDPgV94JsCZeD.Return(Color_4);
            var State_Output_12 = this.__p_LuV5aRZUrHSNfKttYV5HoE.Update(SDFT_In: __auto_1, AutoCompile_In: AutoCompile_2, Max_Iterations_In: Max_Iterations_3, Color_In: Color_5, Bounding_Box_Position_In: Bounding_Box_Position_6, Bounding_Box_Size_In: Bounding_Box_Size_7, Show_Normals_In: Show_Normals_8, Enabled_In: __auto_0, Output_Out: out n43.Entity Output_9, lastError_Out: out string lastError_10, Shader_Code_Out: out string Shader_Code_11);
            this.__p_LuV5aRZUrHSNfKttYV5HoE = State_Output_12;
            Helper_Entity_Out = Output_9;
            return this;
        }

        public n11.ObstacleSDF_C Configure(n28.GpuValue<float> SDF_In, [n5.SerializedDefaultValueAttribute("0.03", false)] float Surface_Border_Thickness_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Helper_Enabled_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In)
        {
            this.SDF = SDF_In;
            n28.GpuValue<float> __auto_0 = SDF_In;
            this.Surface_Border_Thickness = Surface_Border_Thickness_In;
            float __auto_1 = Surface_Border_Thickness_In;
            this.Helper_Enabled = Helper_Enabled_In;
            bool __auto_2 = Helper_Enabled_In;
            this.Enabled = Enabled_In;
            bool __auto_3 = Enabled_In;
            return this;
        }

        public n11.ObstacleSDF_C GetHelperEnabled_(out bool Helper_Enabled_Out)
        {
            bool __auto_0 = this.Helper_Enabled;
            Helper_Enabled_Out = __auto_0;
            return this;
        }

        public n11.ObstacleSDF_C SetContext_(n4.FluidContext_C Context_In)
        {
            this.Context = Context_In;
            n4.FluidContext_C __auto_0 = Context_In;
            return this;
        }

        public n11.ObstacleSDF_C __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Surface_Border_Thickness = 0F;
            this.SDF = default(n28.GpuValue<float>);
            this.Enabled = false;
            this.Helper_Enabled = false;
            this.Context = n4.FluidContext_C.CreateDefault();
            float __pad_GUWt37iUaWqLcMo9xzUhbc_0 = __slot_GUWt37iUaWqLcMo9xzUhbc;
            this.Surface_Border_Thickness = __pad_GUWt37iUaWqLcMo9xzUhbc_0;
            float __auto_1 = __pad_GUWt37iUaWqLcMo9xzUhbc_0;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "C5hKA3jXVBaMsUKR4CRYRv", 351640U);
            var Output_3 = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_2);
            this.__p_C5hKA3jXVBaMsUKR4CRYRv = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "F2PNLXM3oqWN9GjmTbjOtC", 351656U);
            var Output_5 = n72.VolumeCellCoordToPosition_P7ztrzbErhnLtBeQ04ZWFo.Create(Node_Context: Node_Context_4);
            this.__p_F2PNLXM3oqWN9GjmTbjOtC = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "LuV5aRZUrHSNfKttYV5HoE", 351739U);
            var Output_7 = n73.RayMarch_Basic_G1rmTuYo917LHCEFh32ucW.Create(Node_Context: Node_Context_6);
            this.__p_LuV5aRZUrHSNfKttYV5HoE = Output_7;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "TaewM6x2AErMr284kTd08U", 351790U);
            var Output_9 = n74.If_Fuse_C.Create(Node_Context: Node_Context_8);
            this.__p_TaewM6x2AErMr284kTd08U = Output_9;
            this.__monadBuilder_UONJoMby7qQQYV9mfui4i8 = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            this.__customRegion_TaewM6x2AErMr284kTd08U = default(n71.CustomRegion);
            this.__monadBuilder_IuIlAaxTKvDPgV94JsCZeD = n28.GpuValueMonadicFactory<n6.Vector4>.Default.GetMonadBuilder(true);
            return this;
        }

        public n11.ObstacleSDF_C __CreateDefault__()
        {
            this.Surface_Border_Thickness = 0F;
            this.SDF = default(n28.GpuValue<float>);
            this.Enabled = false;
            this.Helper_Enabled = false;
            this.Context = n4.FluidContext_C.CreateDefault();
            this.__p_C5hKA3jXVBaMsUKR4CRYRv = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.CreateDefault();
            this.__p_F2PNLXM3oqWN9GjmTbjOtC = n72.VolumeCellCoordToPosition_P7ztrzbErhnLtBeQ04ZWFo.CreateDefault();
            this.__monadBuilder_UONJoMby7qQQYV9mfui4i8 = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            this.__p_TaewM6x2AErMr284kTd08U = n74.If_Fuse_C.CreateDefault();
            this.__customRegion_TaewM6x2AErMr284kTd08U = default(n71.CustomRegion);
            this.__p_LuV5aRZUrHSNfKttYV5HoE = n73.RayMarch_Basic_G1rmTuYo917LHCEFh32ucW.CreateDefault();
            this.__monadBuilder_IuIlAaxTKvDPgV94JsCZeD = n28.GpuValueMonadicFactory<n6.Vector4>.Default.GetMonadBuilder(true);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_C5hKA3jXVBaMsUKR4CRYRv);
            n1.CompilationHelper.SafeDispose(this.__p_F2PNLXM3oqWN9GjmTbjOtC);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_UONJoMby7qQQYV9mfui4i8);
            n1.CompilationHelper.SafeDispose(this.__p_TaewM6x2AErMr284kTd08U);
            n1.CompilationHelper.SafeDispose(this.__customRegion_TaewM6x2AErMr284kTd08U);
            n1.CompilationHelper.SafeDispose(this.__p_LuV5aRZUrHSNfKttYV5HoE);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_IuIlAaxTKvDPgV94JsCZeD);
            return;
        }

        n11.IPreTexAdvectComputeGraphProvider_I n11.IPreTexAdvectComputeGraphProvider_I.GetPriority(out float Priority_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Priority_Out = 0F;
            return this;
        }

        n11.IPreTexAdvectComputeGraphProvider_I n11.IPreTexAdvectComputeGraphProvider_I.Update(out n28.GpuValue<n54.GpuVoid> Graph_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(out Graph_Out);
            return __returnValue__;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.GetHelperEntity(out n43.Entity Helper_Entity_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetHelperEntity_(out Helper_Entity_Out);
            return __returnValue__;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.GetHelperEnabled(out bool Helper_Enabled_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetHelperEnabled_(out Helper_Enabled_Out);
            return __returnValue__;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.SetContext(n4.FluidContext_C Context_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = SetContext_(Context_In);
            return __returnValue__;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 352363U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GUWt37iUaWqLcMo9xzUhbc", Name = "__slot_GUWt37iUaWqLcMo9xzUhbc")]
        public static float __slot_GUWt37iUaWqLcMo9xzUhbc = 0.03F;
        [n1.ElementAttribute(TracingId = 352391U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Eo3a13W3Kx9MDAj2ioVtzm", Name = "__slot_Eo3a13W3Kx9MDAj2ioVtzm")]
        public static string __slot_Eo3a13W3Kx9MDAj2ioVtzm = "ObstaclesGradient";
        [n1.ElementAttribute(TracingId = 351702U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NtY91qAQBmQPVLe3HzKbn9", Name = "Surface Border Thickness")]
        public float Surface_Border_Thickness;
        [n1.ElementAttribute(TracingId = 351697U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ETjhlq3B3viNNu7jjibC85", Name = "SDF")]
        public n28.GpuValue<float> SDF;
        [n1.ElementAttribute(TracingId = 351713U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FzEV9d5opAxMKx8rLHsWZf", Name = "Enabled")]
        public bool Enabled;
        [n1.ElementAttribute(TracingId = 351731U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OAeRI8a7NmeOGWnvxHPOHs", Name = "Helper Enabled")]
        public bool Helper_Enabled;
        [n1.ElementAttribute(TracingId = 352401U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FCTgIv1OKZLPfbvMH0eZfJ", Name = "Context")]
        public n4.FluidContext_C Context;
        [n1.ElementAttribute(TracingId = 351640U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "C5hKA3jXVBaMsUKR4CRYRv", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
        public n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_C5hKA3jXVBaMsUKR4CRYRv;
        [n1.ElementAttribute(TracingId = 351656U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "F2PNLXM3oqWN9GjmTbjOtC", Name = "VolumeCellCoordToPosition", IsManaged = true, IsAutoGenerated = true)]
        public n72.VolumeCellCoordToPosition_P7ztrzbErhnLtBeQ04ZWFo __p_F2PNLXM3oqWN9GjmTbjOtC;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_UONJoMby7qQQYV9mfui4i8 = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 351790U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TaewM6x2AErMr284kTd08U", Name = "If (Fuse)", IsManaged = true, IsAutoGenerated = true)]
        public n74.If_Fuse_C __p_TaewM6x2AErMr284kTd08U;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n71.CustomRegion __customRegion_TaewM6x2AErMr284kTd08U;
        [n1.ElementAttribute(TracingId = 351739U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LuV5aRZUrHSNfKttYV5HoE", Name = "RayMarch (Basic)", IsManaged = true, IsAutoGenerated = true)]
        public n73.RayMarch_Basic_G1rmTuYo917LHCEFh32ucW __p_LuV5aRZUrHSNfKttYV5HoE;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.Vector4 __c_IuIlAaxTKvDPgV94JsCZeD = n1.CompilationHelper.Deserialize<n6.Vector4>("0.92, 0.36, 0.05, 1", false, "KeWf79wIWCVN4a6TzD33r2", "IuIlAaxTKvDPgV94JsCZeD");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<n6.Vector4, n28.GpuValue<n6.Vector4>> __monadBuilder_IuIlAaxTKvDPgV94JsCZeD = n28.GpuValueMonadicFactory<n6.Vector4>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.Vector3 __c_QSO1e22Lvd3L9QZCsClBYc = n1.CompilationHelper.Deserialize<n6.Vector3>("10, 10, 10", false, "KeWf79wIWCVN4a6TzD33r2", "QSO1e22Lvd3L9QZCsClBYc");
        static ObstacleSDF_C()
        {
        }

        public ObstacleSDF_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ObstacleSDF_C(ObstacleSDF_C other): base(other)
        {
            this.Surface_Border_Thickness = other.Surface_Border_Thickness;
            this.SDF = other.SDF;
            this.Enabled = other.Enabled;
            this.Helper_Enabled = other.Helper_Enabled;
            this.Context = other.Context;
            this.__p_C5hKA3jXVBaMsUKR4CRYRv = other.__p_C5hKA3jXVBaMsUKR4CRYRv;
            this.__p_F2PNLXM3oqWN9GjmTbjOtC = other.__p_F2PNLXM3oqWN9GjmTbjOtC;
            this.__monadBuilder_UONJoMby7qQQYV9mfui4i8 = other.__monadBuilder_UONJoMby7qQQYV9mfui4i8;
            this.__p_TaewM6x2AErMr284kTd08U = other.__p_TaewM6x2AErMr284kTd08U;
            this.__customRegion_TaewM6x2AErMr284kTd08U = other.__customRegion_TaewM6x2AErMr284kTd08U;
            this.__p_LuV5aRZUrHSNfKttYV5HoE = other.__p_LuV5aRZUrHSNfKttYV5HoE;
            this.__monadBuilder_IuIlAaxTKvDPgV94JsCZeD = other.__monadBuilder_IuIlAaxTKvDPgV94JsCZeD;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Surface_Border_Thickness", in Surface_Border_Thickness), n1.CompilationHelper.GetValueOrExisting(values, "SDF", in SDF), n1.CompilationHelper.GetValueOrExisting(values, "Enabled", in Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Helper_Enabled", in Helper_Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Context", in Context), n1.CompilationHelper.GetValueOrExisting(values, "__p_C5hKA3jXVBaMsUKR4CRYRv", in __p_C5hKA3jXVBaMsUKR4CRYRv), n1.CompilationHelper.GetValueOrExisting(values, "__p_F2PNLXM3oqWN9GjmTbjOtC", in __p_F2PNLXM3oqWN9GjmTbjOtC), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_UONJoMby7qQQYV9mfui4i8", in __monadBuilder_UONJoMby7qQQYV9mfui4i8), n1.CompilationHelper.GetValueOrExisting(values, "__p_TaewM6x2AErMr284kTd08U", in __p_TaewM6x2AErMr284kTd08U), n1.CompilationHelper.GetValueOrExisting(values, "__customRegion_TaewM6x2AErMr284kTd08U", in __customRegion_TaewM6x2AErMr284kTd08U), n1.CompilationHelper.GetValueOrExisting(values, "__p_LuV5aRZUrHSNfKttYV5HoE", in __p_LuV5aRZUrHSNfKttYV5HoE), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_IuIlAaxTKvDPgV94JsCZeD", in __monadBuilder_IuIlAaxTKvDPgV94JsCZeD));
        }

        internal ObstacleSDF_C __WITH__(float Surface_Border_Thickness, n28.GpuValue<float> SDF, bool Enabled, bool Helper_Enabled, n4.FluidContext_C Context, n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_C5hKA3jXVBaMsUKR4CRYRv, n72.VolumeCellCoordToPosition_P7ztrzbErhnLtBeQ04ZWFo __p_F2PNLXM3oqWN9GjmTbjOtC, n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_UONJoMby7qQQYV9mfui4i8, n74.If_Fuse_C __p_TaewM6x2AErMr284kTd08U, n71.CustomRegion __customRegion_TaewM6x2AErMr284kTd08U, n73.RayMarch_Basic_G1rmTuYo917LHCEFh32ucW __p_LuV5aRZUrHSNfKttYV5HoE, n1.IMonadBuilder<n6.Vector4, n28.GpuValue<n6.Vector4>> __monadBuilder_IuIlAaxTKvDPgV94JsCZeD)
        {
            n11.ObstacleSDF_C that_0 = this;
            this.Surface_Border_Thickness = Surface_Border_Thickness;
            this.SDF = SDF;
            this.Enabled = Enabled;
            this.Helper_Enabled = Helper_Enabled;
            this.Context = Context;
            this.__p_C5hKA3jXVBaMsUKR4CRYRv = __p_C5hKA3jXVBaMsUKR4CRYRv;
            this.__p_F2PNLXM3oqWN9GjmTbjOtC = __p_F2PNLXM3oqWN9GjmTbjOtC;
            this.__monadBuilder_UONJoMby7qQQYV9mfui4i8 = __monadBuilder_UONJoMby7qQQYV9mfui4i8;
            this.__p_TaewM6x2AErMr284kTd08U = __p_TaewM6x2AErMr284kTd08U;
            this.__customRegion_TaewM6x2AErMr284kTd08U = __customRegion_TaewM6x2AErMr284kTd08U;
            this.__p_LuV5aRZUrHSNfKttYV5HoE = __p_LuV5aRZUrHSNfKttYV5HoE;
            this.__monadBuilder_IuIlAaxTKvDPgV94JsCZeD = __monadBuilder_IuIlAaxTKvDPgV94JsCZeD;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JbEzzfeh9pxO1cvTgHk8o3", Name = "__JbEzzfeh9pxO1cvTgHk8o3")]
        [n2.SerializableAttribute]
        public class __JbEzzfeh9pxO1cvTgHk8o3 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_DbPC5hKseB2NnYDs9BZthT);
                n1.CompilationHelper.SafeDispose(this.__p_RElEA0iTvfCQP1maWqiIfE);
                n1.CompilationHelper.SafeDispose(this.__p_TW68V8TYSLqLvOKNbYJpAw);
                return;
            }

            [n1.ElementAttribute(TracingId = 351887U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DbPC5hKseB2NnYDs9BZthT", Name = "TextureGet", IsManaged = true, IsAutoGenerated = true)]
            public n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, float> __p_DbPC5hKseB2NnYDs9BZthT;
            [n1.ElementAttribute(TracingId = 351817U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RElEA0iTvfCQP1maWqiIfE", Name = "ObstacleGradientSDF", IsManaged = true, IsAutoGenerated = true)]
            public n11.ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T __p_RElEA0iTvfCQP1maWqiIfE;
            [n1.ElementAttribute(TracingId = 351798U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TW68V8TYSLqLvOKNbYJpAw", Name = "TextureSet", IsManaged = true, IsAutoGenerated = true)]
            public n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, float> __p_TW68V8TYSLqLvOKNbYJpAw;
            public __JbEzzfeh9pxO1cvTgHk8o3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __JbEzzfeh9pxO1cvTgHk8o3(__JbEzzfeh9pxO1cvTgHk8o3 other): base(other)
            {
                this.__p_DbPC5hKseB2NnYDs9BZthT = other.__p_DbPC5hKseB2NnYDs9BZthT;
                this.__p_RElEA0iTvfCQP1maWqiIfE = other.__p_RElEA0iTvfCQP1maWqiIfE;
                this.__p_TW68V8TYSLqLvOKNbYJpAw = other.__p_TW68V8TYSLqLvOKNbYJpAw;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DbPC5hKseB2NnYDs9BZthT", in __p_DbPC5hKseB2NnYDs9BZthT), n1.CompilationHelper.GetValueOrExisting(values, "__p_RElEA0iTvfCQP1maWqiIfE", in __p_RElEA0iTvfCQP1maWqiIfE), n1.CompilationHelper.GetValueOrExisting(values, "__p_TW68V8TYSLqLvOKNbYJpAw", in __p_TW68V8TYSLqLvOKNbYJpAw));
            }

            internal __JbEzzfeh9pxO1cvTgHk8o3 __WITH__(n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, float> __p_DbPC5hKseB2NnYDs9BZthT, n11.ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T __p_RElEA0iTvfCQP1maWqiIfE, n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, float> __p_TW68V8TYSLqLvOKNbYJpAw)
            {
                __JbEzzfeh9pxO1cvTgHk8o3 that_0 = this;
                this.__p_DbPC5hKseB2NnYDs9BZthT = __p_DbPC5hKseB2NnYDs9BZthT;
                this.__p_RElEA0iTvfCQP1maWqiIfE = __p_RElEA0iTvfCQP1maWqiIfE;
                this.__p_TW68V8TYSLqLvOKNbYJpAw = __p_TW68V8TYSLqLvOKNbYJpAw;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 352564U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TN4o2o0C0kVLtVuoIzgJ2f", Name = "Texture2DVectorField_Fluid3D_C")]
    [n2.SerializableAttribute]
    public class Texture2DVectorField_Fluid3D_C : n1.VLObject, n11.IFluidComponent_I, n11.IPostTexAdvectComputeGraphProvider_I, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n11.Texture2DVectorField_Fluid3D_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new Texture2DVectorField_Fluid3D_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.Texture2DVectorField_Fluid3D_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new Texture2DVectorField_Fluid3D_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.Texture2DVectorField_Fluid3D_C Update_(out n28.GpuValue<n54.GpuVoid> Graph_Out)
        {
            n4.FluidContext_C __auto_0 = this.Context;
            n27.Texture __auto_1 = this.Texture;
            bool __auto_2 = this.Normalized_Texture_Data;
            n6.Matrix __auto_3 = this.Transformation;
            float __auto_4 = this.Strength;
            bool __auto_5 = this.Z_Box_Vector_Confinement_Enabled;
            bool __auto_6 = this.Helper_Texture_Enabled;
            bool __auto_7 = this.Helper_Enabled;
            n6.Color4 __auto_8 = this.Helper_Frame_Color;
            n28.GpuValue<float> __auto_9 = this.Level;
            n28.GpuValue<n27.SamplerState> __auto_10 = this.Sampler;
            bool __auto_11 = this.Enabled;
            n28.GpuValue<n6.Vector3> __auto_12 = this.TVector_Transformation_Function;
            n27.Texture __auto_13 = this.Texture;
            bool __auto_14 = this.Enabled;
            n4.FluidContext_C __auto_15 = this.Context;
            bool __auto_16 = this.Additive;
            n28.GpuValue<float> __auto_17 = this.Threshold;
            var State_Output_19 = this.__p_VBFpaun3X9nPxGr1RvMfSJ.GetOutput(Output_Out: out n28.GpuValue<n6.Int3> Output_18);
            this.__p_VBFpaun3X9nPxGr1RvMfSJ = State_Output_19;
            var Output_22 = __auto_0.GetTransform(Transform_Out: out n6.Matrix Transform_20, Transform_Inverse_Out: out n6.Matrix Transform_Inverse_21);
            var Output_24 = Output_22.GetResolution(Resolution_Out: out n6.Int3 Resolution_23);
            var State_Output_26 = this.__p_FoZALuaNNkrO5WKvlSUfTF.Update(Cell_Coordinate_In: Output_18, Grid_Resolution_In: Resolution_23, Volume_Transform_In: Transform_20, Output_Out: out n28.GpuValue<n6.Vector3> Output_25);
            this.__p_FoZALuaNNkrO5WKvlSUfTF = State_Output_26;
            n28.GpuValue<float> Strength_27 = this.__monadBuilder_GF39ZcFazsVOClsw3oxr12.Return(__auto_4);
            n28.GpuValue<bool> Enabled_28 = this.__monadBuilder_M8yNtNJmfqfMloLrJdXNK4.Return(__auto_11);
            var State_Output_31 = this.__p_JTODYq10Q2JPBm3cZg3kdy.Update(Texture_In: __auto_1, Normalized_Texture_Data_In: __auto_2, Sampling_Position_In: Output_25, Field_Transformation_In: __auto_3, Sampler_In: __auto_10, Level_In: __auto_9, TVector_Transformation_Function_In: __auto_12, Strength_In: Strength_27, Z_Box_Vector_Confinement_Enabled_In: __auto_5, Helper_Frame_Color_In: __auto_8, Helper_Texture_Enabled_In: __auto_6, Helper_Enabled_In: __auto_7, Enabled_In: Enabled_28, Output_Out: out n28.GpuValue<n6.Vector3> Output_29, UVZ_Projected_Coordinates_Out: out n28.GpuValue<n6.Vector3> UVZ_Projected_Coordinates_30);
            this.__p_JTODYq10Q2JPBm3cZg3kdy = State_Output_31;
            bool Force_32 = false;
            bool Dispose_Cached_Outputs_33 = false;
            var manager_34 = this.__cache_UVDnzVc4t1iLIxr4zKKbIS;
            if (manager_34 is null)
            {
                manager_34 = new n13.Manager<n2.ValueTuple<n27.Texture, bool, n4.FluidContext_C, bool, n28.GpuValue<float>, n28.GpuValue<n6.Vector3>>, n2.ValueTuple<n28.GpuValue<n54.GpuVoid>>>(n2.ValueTuple.Create(default(n28.GpuValue<n54.GpuVoid>)));
            }

            var inputs_35 = (__auto_13, __auto_14, __auto_15, __auto_16, __auto_17, Output_29);
            var outputs_36 = manager_34.Outputs;
            var Has_Changed_37 = Force_32 || manager_34.InputsChanged(inputs_35);
            if (Has_Changed_37)
            {
                if (Dispose_Cached_Outputs_33)
                    manager_34.DisposeOutputs();
                var state_38 = n1.CompilationHelper.Restore<__JDjLw0zovKyN5bFk16wxyd>(manager_34.State, __GetContext__());
                if (state_38 == null)
                {
                    state_38 = new __JDjLw0zovKyN5bFk16wxyd(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Values_In_GiCscrboaDbL4k3nomGK6m = n14._Operations_.CreateDefault<n28.GpuValue<bool>>()};
                    n1.NodeContext Node_Context_39 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "D7sdDuLc0ZeOJB0awPgXpm", 352955U);
                    var Output_40 = n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, float>.Create(Node_Context: Node_Context_39);
                    state_38.__p_D7sdDuLc0ZeOJB0awPgXpm = Output_40;
                    n1.NodeContext Node_Context_41 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Q78qsi0MpUkPPJbhnY4OaG", 352971U);
                    var Output_42 = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_41);
                    state_38.__p_Q78qsi0MpUkPPJbhnY4OaG = Output_42;
                    n1.NodeContext Node_Context_43 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "ERL1bnLYlq4N3GhHePIOws", 352985U);
                    var Output_44 = n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float>.Create(Node_Context: Node_Context_43);
                    state_38.__p_ERL1bnLYlq4N3GhHePIOws = Output_44;
                    n1.NodeContext Node_Context_45 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Oi3N1vX4hVYN1WJ6jsXgu1", 353001U);
                    var Output_46 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_45);
                    state_38.__p_Oi3N1vX4hVYN1WJ6jsXgu1 = Output_46;
                    n1.NodeContext Node_Context_47 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "GiCscrboaDbL4k3nomGK6m", 353025U);
                    var Output_48 = n59.AND_TkWZzQWwZ0tLZt6ooZGazh.Create(Node_Context: Node_Context_47);
                    state_38.__p_GiCscrboaDbL4k3nomGK6m = Output_48;
                    n1.NodeContext Node_Context_49 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "UJ7g3dMxczsNhtNnmkBsBJ", 353042U);
                    var Output_50 = n74.If_Fuse_C.Create(Node_Context: Node_Context_49);
                    state_38.__p_UJ7g3dMxczsNhtNnmkBsBJ = Output_50;
                }

                string __pad_COdQSSRXedwPs4CDUmorR7_51 = __slot_COdQSSRXedwPs4CDUmorR7;
                float __pad_QcvrMVqfzIJLUk8XEVGbjs_52 = __slot_QcvrMVqfzIJLUk8XEVGbjs;
                n15.ObjectHelpers.IsAssigned(x: __auto_13, result: out bool Result_53, notAssigned: out bool Not_Assigned_54);
                n28.GpuValue<bool> Values_55 = state_38.__monadBuilder_AFadesiuFxoQB7yuJEtd0j.Return(Result_53);
                n28.GpuValue<bool> Values_2_56 = state_38.__monadBuilder_TNeapDzkHJMNcF6hfCUzwu.Return(__auto_14);
                var Output_62 = __auto_15.GetTextureWithName(Texture_Name_In: __pad_COdQSSRXedwPs4CDUmorR7_51, Texture_Read_Out: out n27.Texture Texture_Read_57, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_58, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_59, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_60, Found_Out: out bool Found_61);
                var State_Output_64 = state_38.__p_Q78qsi0MpUkPPJbhnY4OaG.GetOutput(Output_Out: out n28.GpuValue<n6.Int3> Output_63);
                n28.GpuValue<float> default_65 = default(n28.GpuValue<float>);
                var State_Output_67 = state_38.__p_D7sdDuLc0ZeOJB0awPgXpm.Update(Texture_In: Texture_Read_Graph_58, index_In: Output_63, default_In: default_65, Output_Out: out n28.GpuValue<float> Output_66);
                var Output_69 = state_38.__p_Oi3N1vX4hVYN1WJ6jsXgu1.Update(Value_In: __pad_QcvrMVqfzIJLUk8XEVGbjs_52, GpuValue_Out: out n28.GpuValue<float> GpuValue_68);
                var Output_71 = state_38.__p_ERL1bnLYlq4N3GhHePIOws.Update(x_In: Output_66, y_In: GpuValue_68, value_Out: out n28.GpuValue<bool> value_70);
                var builder_72 = n5.CollectionBuilders.GetBuilder(state_38.__pin_group_Values_In_GiCscrboaDbL4k3nomGK6m, 3);
                builder_72.Add(Values_55);
                builder_72.Add(Values_2_56);
                builder_72.Add(value_70);
                var __pin_group_Values_In_GiCscrboaDbL4k3nomGK6m_73 = builder_72.Commit();
                var State_Output_75 = state_38.__p_GiCscrboaDbL4k3nomGK6m.Update(Values_In: __pin_group_Values_In_GiCscrboaDbL4k3nomGK6m_73, Output_Out: out n28.GpuValue<bool> Output_74);
                var customRegion_76 = state_38.__customRegion_UJ7g3dMxczsNhtNnmkBsBJ ?? new n71.CustomRegion();
                customRegion_76.newPatchSymbol = 27726329;
                customRegion_76.BeginChanges();
                customRegion_76.AddIncomingLink(typeof(bool), 0);
                customRegion_76.AddIncomingLink(typeof(n28.GpuValue<float>), 1);
                customRegion_76.AddIncomingLink(typeof(n28.GpuValue<n6.Vector3>), 2);
                customRegion_76.AddIncomingLink(typeof(n28.GpuValue<n6.Vector3>), 3);
                customRegion_76.AddIncomingLink(typeof(n28.GpuValue<n6.Vector3>), 4);
                customRegion_76.AddIncomingLink(typeof(n4.FluidContext_C), 5);
                customRegion_76.AddOutput("", typeof(n28.GpuValue<n54.GpuVoid>), 0);
                customRegion_76.SetInputValues(default(n28.GpuValue<n54.GpuVoid>));
                customRegion_76.SetIncomingLinkValues(__auto_16, __auto_17, Output_29, Output_29, Output_29, __auto_15);
                customRegion_76.EndChanges();
                var __fallback___77 = n1.ServiceRegistry.Current;
                customRegion_76.PatchUpdator = (n2.Object stateInput_80, n22.IReadOnlyList<n2.Object> inputs_81, n22.IReadOnlyList<n2.Object> incomingLinks_82, out n2.Object stateOutput_89, out n12.Spread<n2.Object> outputs_90) =>
                {
                    using var __current_78 = __fallback___77.MakeCurrentIfNone();
                    var state_79 = n1.CompilationHelper.Restore<__DhhMcxxAtO4PsA6RHzAlkL>(stateInput_80, __GetContext__());
                    var link_FSVNLpDqZUGO5JuowMdu5g_83 = (bool)incomingLinks_82[0];
                    var link_GYwy7ypo7rlMrlHWafwrrI_84 = (n28.GpuValue<float>)incomingLinks_82[1];
                    var link_UcSjYQGAiYIPS6QUtzneXW_85 = (n28.GpuValue<n6.Vector3>)incomingLinks_82[2];
                    var link_VJ0KnRb33T7OTzkRrEZigh_86 = (n28.GpuValue<n6.Vector3>)incomingLinks_82[3];
                    var link_HTN66gQeDbpQZRu036DmXQ_87 = (n28.GpuValue<n6.Vector3>)incomingLinks_82[4];
                    var link_GQ4Rc86KlFmOP38kOLwUKh_88 = (n4.FluidContext_C)incomingLinks_82[5];
                    string __pad_ELjTtzu5hqaNPwWMzEbC8r_91 = __slot_ELjTtzu5hqaNPwWMzEbC8r;
                    var State_Output_93 = state_79.__p_BYN2xBsNGbsLktL1BKbK3t.Update(Input_In: link_UcSjYQGAiYIPS6QUtzneXW_85, Output_Out: out n28.GpuValue<float> Output_92);
                    var Output_95 = state_79.__p_KZiROCzyaCDLC9YMLiNuzu.Update(x_In: Output_92, y_In: link_GYwy7ypo7rlMrlHWafwrrI_84, value_Out: out n28.GpuValue<bool> value_94);
                    var Output_101 = link_GQ4Rc86KlFmOP38kOLwUKh_88.GetTextureWithName(Texture_Name_In: __pad_ELjTtzu5hqaNPwWMzEbC8r_91, Texture_Read_Out: out n27.Texture Texture_Read_96, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_97, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_98, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_99, Found_Out: out bool Found_100);
                    var State_Output_103 = state_79.__p_I2WICMlX9LZMvkhKh74rCu.GetOutput(Output_Out: out n28.GpuValue<n6.Int3> Output_102);
                    n28.GpuValue<n6.Vector4> default_104 = default(n28.GpuValue<n6.Vector4>);
                    var State_Output_106 = state_79.__p_ITdM86MSPEnPJiBUdefbof.Update(Texture_In: Texture_Read_Graph_97, index_In: Output_102, default_In: default_104, Output_Out: out n28.GpuValue<n6.Vector4> Output_105);
                    var State_Output_108 = state_79.__p_HCThqVtngoaPGww0rkoOm2.Update(Input_In: Output_105, Output_Out: out n28.GpuValue<n6.Vector3> Output_107);
                    n28.GpuValue<n6.Vector3> The_Default_109 = default(n28.GpuValue<n6.Vector3>);
                    var State_Output_111 = state_79.__p_GS9rMF6FOXjLzMNu4dwyIo.Update(In_Check_In: value_94, In_False_In: Output_107, In_True_In: link_VJ0KnRb33T7OTzkRrEZigh_86, The_Default_In: The_Default_109, Output_Out: out n28.GpuValue<n6.Vector3> Output_110);
                    var builder_112 = n5.CollectionBuilders.GetBuilder(state_79.__pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98, 2);
                    builder_112.Add(Output_107);
                    builder_112.Add(link_HTN66gQeDbpQZRu036DmXQ_87);
                    var __pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98_113 = builder_112.Commit();
                    var State_Output_115 = state_79.__p_DAPmpFBoFXvOs8cEAI3e98.Update(Input_In: __pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98_113, Output_Out: out n28.GpuValue<n6.Vector3> Output_114);
                    n39._Operations_.Switch_Boolean<n28.GpuValue<n6.Vector3>>(Condition_In: link_FSVNLpDqZUGO5JuowMdu5g_83, Input_In: Output_110, Input_2_In: Output_114, Output_Out: out n28.GpuValue<n6.Vector3> Output_116);
                    n28.GpuValue<float> w_117 = default(n28.GpuValue<float>);
                    var State_Output_119 = state_79.__p_FogbL6neCTlP61paeOVp0q.Update(xyz_In: Output_116, w_In: w_117, Output_Out: out n28.GpuValue<n6.Vector4> Output_118);
                    var State_Output_121 = state_79.__p_AtdqSCk0lP3ORvl6zABoOk.GetOutput(Output_Out: out n28.GpuValue<n6.Int3> Output_120);
                    var State_Output_123 = state_79.__p_Ng7d9nqjXGNMdUzKKw2K5L.Update(Texture_In: Texture_ReadWrite_Graph_99, index_In: Output_120, value_In: Output_118, Output_Out: out n28.GpuValue<n54.GpuVoid> Output_122);
                    state_79.__p_BYN2xBsNGbsLktL1BKbK3t = State_Output_93;
                    state_79.__p_KZiROCzyaCDLC9YMLiNuzu = Output_95;
                    state_79.__p_I2WICMlX9LZMvkhKh74rCu = State_Output_103;
                    state_79.__p_ITdM86MSPEnPJiBUdefbof = State_Output_106;
                    state_79.__p_HCThqVtngoaPGww0rkoOm2 = State_Output_108;
                    state_79.__p_GS9rMF6FOXjLzMNu4dwyIo = State_Output_111;
                    state_79.__pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98 = __pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98_113;
                    state_79.__p_DAPmpFBoFXvOs8cEAI3e98 = State_Output_115;
                    state_79.__p_FogbL6neCTlP61paeOVp0q = State_Output_119;
                    state_79.__p_AtdqSCk0lP3ORvl6zABoOk = State_Output_121;
                    state_79.__p_Ng7d9nqjXGNMdUzKKw2K5L = State_Output_123;
                    stateOutput_89 = state_79;
                    outputs_90 = n5.CollectionExtensions.CreateSpreadOfObjects(Output_122);
                }

                ;
                customRegion_76.PatchCreator = (n22.IReadOnlyList<n2.Object> initialInputs_125, out n2.Object stateOutput_126, out n12.Spread<n2.Object> initialOutputs_127) =>
                {
                    using var __current_124 = __fallback___77.MakeCurrentIfNone();
                    var state_79 = new __DhhMcxxAtO4PsA6RHzAlkL(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98 = n14._Operations_.CreateDefault<n28.GpuValue<n6.Vector3>>()};
                    n1.NodeContext Node_Context_128 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Ng7d9nqjXGNMdUzKKw2K5L", 353067U);
                    var Output_129 = n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, n6.Vector4>.Create(Node_Context: Node_Context_128);
                    state_79.__p_Ng7d9nqjXGNMdUzKKw2K5L = Output_129;
                    n1.NodeContext Node_Context_130 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "AtdqSCk0lP3ORvl6zABoOk", 353078U);
                    var Output_131 = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_130);
                    state_79.__p_AtdqSCk0lP3ORvl6zABoOk = Output_131;
                    n1.NodeContext Node_Context_132 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "BYN2xBsNGbsLktL1BKbK3t", 353089U);
                    var Output_133 = n75.Length_P0UB6WKESd0PjWRm8eD1d4<n6.Vector3>.Create(Node_Context: Node_Context_132);
                    state_79.__p_BYN2xBsNGbsLktL1BKbK3t = Output_133;
                    n1.NodeContext Node_Context_134 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "KZiROCzyaCDLC9YMLiNuzu", 353119U);
                    var Output_135 = n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float>.Create(Node_Context: Node_Context_134);
                    state_79.__p_KZiROCzyaCDLC9YMLiNuzu = Output_135;
                    n1.NodeContext Node_Context_136 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "HCThqVtngoaPGww0rkoOm2", 353165U);
                    var Output_137 = n76.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_136);
                    state_79.__p_HCThqVtngoaPGww0rkoOm2 = Output_137;
                    n1.NodeContext Node_Context_138 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "ITdM86MSPEnPJiBUdefbof", 353170U);
                    var Output_139 = n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, n6.Vector4>.Create(Node_Context: Node_Context_138);
                    state_79.__p_ITdM86MSPEnPJiBUdefbof = Output_139;
                    n1.NodeContext Node_Context_140 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "GS9rMF6FOXjLzMNu4dwyIo", 353191U);
                    var Output_141 = n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector3>.Create(Node_Context: Node_Context_140);
                    state_79.__p_GS9rMF6FOXjLzMNu4dwyIo = Output_141;
                    n1.NodeContext Node_Context_142 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "I2WICMlX9LZMvkhKh74rCu", 353219U);
                    var Output_143 = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_142);
                    state_79.__p_I2WICMlX9LZMvkhKh74rCu = Output_143;
                    n1.NodeContext Node_Context_144 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "DAPmpFBoFXvOs8cEAI3e98", 353234U);
                    var Output_145 = n75.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n6.Vector3>.Create(Node_Context: Node_Context_144);
                    state_79.__p_DAPmpFBoFXvOs8cEAI3e98 = Output_145;
                    n1.NodeContext Node_Context_146 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "FogbL6neCTlP61paeOVp0q", 353255U);
                    var Output_147 = n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_146);
                    state_79.__p_FogbL6neCTlP61paeOVp0q = Output_147;
                    stateOutput_126 = state_79;
                    initialOutputs_127 = n5.CollectionExtensions.CreateSpreadOfObjects(default(n28.GpuValue<n54.GpuVoid>));
                }

                ;
                var Output_149 = state_38.__p_UJ7g3dMxczsNhtNnmkBsBJ.Update(Condition_In: Output_74, Region_In: customRegion_76, Has_Changed_Out: out bool Has_Changed_148);
                var __auto_150 = (n28.GpuValue<n54.GpuVoid>)customRegion_76.OutputValues[0];
                state_38.__p_Q78qsi0MpUkPPJbhnY4OaG = State_Output_64;
                state_38.__p_D7sdDuLc0ZeOJB0awPgXpm = State_Output_67;
                state_38.__p_Oi3N1vX4hVYN1WJ6jsXgu1 = Output_69;
                state_38.__p_ERL1bnLYlq4N3GhHePIOws = Output_71;
                state_38.__pin_group_Values_In_GiCscrboaDbL4k3nomGK6m = __pin_group_Values_In_GiCscrboaDbL4k3nomGK6m_73;
                state_38.__p_GiCscrboaDbL4k3nomGK6m = State_Output_75;
                state_38.__customRegion_UJ7g3dMxczsNhtNnmkBsBJ = customRegion_76;
                state_38.__p_UJ7g3dMxczsNhtNnmkBsBJ = Output_149;
                outputs_36 = n2.ValueTuple.Create(__auto_150);
                manager_34 = manager_34.Update(inputs_35, __GetContext__().IsImmutable, Dispose_Cached_Outputs_33, state_38, outputs_36);
            }
            else
            {
                manager_34.Update(inputs_35, __GetContext__().IsImmutable, Dispose_Cached_Outputs_33);
            }

            var __auto_151 = outputs_36.Item1;
            this.__cache_UVDnzVc4t1iLIxr4zKKbIS = manager_34;
            this.__slot_A8tjSzdjnuuOUcnSnLeH7P = Output_29;
            n28.GpuValue<n6.Vector3> __pad_A8tjSzdjnuuOUcnSnLeH7P_152 = Output_29;
            this.__slot_K9ndibvVOlsP8bsakMHwno = UVZ_Projected_Coordinates_30;
            n28.GpuValue<n6.Vector3> __pad_K9ndibvVOlsP8bsakMHwno_153 = UVZ_Projected_Coordinates_30;
            Graph_Out = __auto_151;
            return this;
        }

        public n11.Texture2DVectorField_Fluid3D_C Configure(n27.Texture Texture_In, bool Normalized_Texture_Data_In, n28.GpuValue<n27.SamplerState> Sampler_In, n28.GpuValue<float> Level_In, n6.Matrix Transformation_In, n28.GpuValue<n6.Vector3> TVector_Transformation_Function_In, [n5.SerializedDefaultValueAttribute("1", false)] float Strength_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Z_Box_Vector_Confinement_Enabled_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Additive_In, n28.GpuValue<float> Threshold_In, n6.Color4 Helper_Frame_Color_In, bool Helper_Texture_Enabled_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Helper_Enabled_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In)
        {
            this.Texture = Texture_In;
            n27.Texture __auto_0 = Texture_In;
            this.Normalized_Texture_Data = Normalized_Texture_Data_In;
            bool __auto_1 = Normalized_Texture_Data_In;
            this.Sampler = Sampler_In;
            n28.GpuValue<n27.SamplerState> __auto_2 = Sampler_In;
            this.Level = Level_In;
            n28.GpuValue<float> __auto_3 = Level_In;
            this.Transformation = Transformation_In;
            n6.Matrix __auto_4 = Transformation_In;
            this.TVector_Transformation_Function = TVector_Transformation_Function_In;
            n28.GpuValue<n6.Vector3> __auto_5 = TVector_Transformation_Function_In;
            this.Strength = Strength_In;
            float __auto_6 = Strength_In;
            this.Z_Box_Vector_Confinement_Enabled = Z_Box_Vector_Confinement_Enabled_In;
            bool __auto_7 = Z_Box_Vector_Confinement_Enabled_In;
            this.Additive = Additive_In;
            bool __auto_8 = Additive_In;
            this.Threshold = Threshold_In;
            n28.GpuValue<float> __auto_9 = Threshold_In;
            this.Helper_Frame_Color = Helper_Frame_Color_In;
            n6.Color4 __auto_10 = Helper_Frame_Color_In;
            this.Helper_Texture_Enabled = Helper_Texture_Enabled_In;
            bool __auto_11 = Helper_Texture_Enabled_In;
            this.Helper_Enabled = Helper_Enabled_In;
            bool __auto_12 = Helper_Enabled_In;
            this.Enabled = Enabled_In;
            bool __auto_13 = Enabled_In;
            return this;
        }

        public n11.Texture2DVectorField_Fluid3D_C GetHelperEntity_(out n43.Entity Helper_Entity_Out)
        {
            n28.GpuValue<n6.Vector3> __pad_A8tjSzdjnuuOUcnSnLeH7P_0 = this.__slot_A8tjSzdjnuuOUcnSnLeH7P;
            var Output_2 = this.__p_KOjQZbYEMgQMJ3E9v0Lqod.Update(Input_In: __pad_A8tjSzdjnuuOUcnSnLeH7P_0, Entity_Out: out n43.Entity Entity_1);
            this.__p_KOjQZbYEMgQMJ3E9v0Lqod = Output_2;
            Helper_Entity_Out = Entity_1;
            return this;
        }

        public n11.Texture2DVectorField_Fluid3D_C GetHelperEnabled_(out bool Helper_Enabled_Out)
        {
            bool __auto_0 = this.Helper_Enabled;
            Helper_Enabled_Out = __auto_0;
            return this;
        }

        public n11.Texture2DVectorField_Fluid3D_C GetUVZProjectedCoordinates(out n28.GpuValue<n6.Vector3> UVZ_Projected_Coordinates_Out)
        {
            n28.GpuValue<n6.Vector3> __pad_K9ndibvVOlsP8bsakMHwno_0 = this.__slot_K9ndibvVOlsP8bsakMHwno;
            UVZ_Projected_Coordinates_Out = __pad_K9ndibvVOlsP8bsakMHwno_0;
            return this;
        }

        public n11.Texture2DVectorField_Fluid3D_C SetContext_(n4.FluidContext_C Context_In)
        {
            this.Context = Context_In;
            n4.FluidContext_C __auto_0 = Context_In;
            return this;
        }

        public n11.Texture2DVectorField_Fluid3D_C __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_K9ndibvVOlsP8bsakMHwno = default(n28.GpuValue<n6.Vector3>);
            this.__slot_A8tjSzdjnuuOUcnSnLeH7P = default(n28.GpuValue<n6.Vector3>);
            this.Texture = default(n27.Texture);
            this.Transformation = n9._Operations_.CreateDefault();
            this.Additive = false;
            this.Strength = 0F;
            this.Enabled = false;
            this.Helper_Enabled = false;
            this.Threshold = default(n28.GpuValue<float>);
            this.Normalized_Texture_Data = false;
            this.Z_Box_Vector_Confinement_Enabled = false;
            this.Helper_Texture_Enabled = false;
            this.Helper_Frame_Color = n50._Operations_.CreateDefault();
            this.Level = default(n28.GpuValue<float>);
            this.Sampler = default(n28.GpuValue<n27.SamplerState>);
            this.TVector_Transformation_Function = default(n28.GpuValue<n6.Vector3>);
            this.Context = n4.FluidContext_C.CreateDefault();
            bool __pad_Tv7yJWOfpNSL55S50in7Er_0 = __slot_Tv7yJWOfpNSL55S50in7Er;
            float __pad_OZL2FOBGm3CL8BB7hbIx8N_1 = __slot_OZL2FOBGm3CL8BB7hbIx8N;
            bool __pad_LbiPDdyyAASMo8hD34anvE_2 = __slot_LbiPDdyyAASMo8hD34anvE;
            bool __pad_PYyozTa3frhLMxDyarTWxL_3 = __slot_PYyozTa3frhLMxDyarTWxL;
            bool __pad_BnzxzIxc4lAPuecK8fPdNP_4 = __slot_BnzxzIxc4lAPuecK8fPdNP;
            this.Additive = __pad_Tv7yJWOfpNSL55S50in7Er_0;
            bool __auto_5 = __pad_Tv7yJWOfpNSL55S50in7Er_0;
            this.Strength = __pad_OZL2FOBGm3CL8BB7hbIx8N_1;
            float __auto_6 = __pad_OZL2FOBGm3CL8BB7hbIx8N_1;
            this.Enabled = __pad_LbiPDdyyAASMo8hD34anvE_2;
            bool __auto_7 = __pad_LbiPDdyyAASMo8hD34anvE_2;
            this.Helper_Enabled = __pad_PYyozTa3frhLMxDyarTWxL_3;
            bool __auto_8 = __pad_PYyozTa3frhLMxDyarTWxL_3;
            this.Z_Box_Vector_Confinement_Enabled = __pad_BnzxzIxc4lAPuecK8fPdNP_4;
            bool __auto_9 = __pad_BnzxzIxc4lAPuecK8fPdNP_4;
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "FoZALuaNNkrO5WKvlSUfTF", 352594U);
            var Output_11 = n72.VolumeCellCoordToPosition_P7ztrzbErhnLtBeQ04ZWFo.Create(Node_Context: Node_Context_10);
            this.__p_FoZALuaNNkrO5WKvlSUfTF = Output_11;
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "VBFpaun3X9nPxGr1RvMfSJ", 352691U);
            var Output_13 = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_12);
            this.__p_VBFpaun3X9nPxGr1RvMfSJ = Output_13;
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "JTODYq10Q2JPBm3cZg3kdy", 352714U);
            var Output_15 = n78.SampleTexture2DVectorField_C.Create(Node_Context: Node_Context_14);
            this.__p_JTODYq10Q2JPBm3cZg3kdy = Output_15;
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "KOjQZbYEMgQMJ3E9v0Lqod", 353397U);
            var Output_17 = n79.GetHelper_SIlUS90jQlRLGG88cf3x83.Create(Node_Context: Node_Context_16);
            this.__p_KOjQZbYEMgQMJ3E9v0Lqod = Output_17;
            this.__monadBuilder_GF39ZcFazsVOClsw3oxr12 = n28.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_M8yNtNJmfqfMloLrJdXNK4 = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            this.__cache_UVDnzVc4t1iLIxr4zKKbIS = null;
            return this;
        }

        public n11.Texture2DVectorField_Fluid3D_C __CreateDefault__()
        {
            this.__slot_K9ndibvVOlsP8bsakMHwno = default(n28.GpuValue<n6.Vector3>);
            this.__slot_A8tjSzdjnuuOUcnSnLeH7P = default(n28.GpuValue<n6.Vector3>);
            this.Texture = default(n27.Texture);
            this.Transformation = n9._Operations_.CreateDefault();
            this.Additive = false;
            this.Strength = 0F;
            this.Enabled = false;
            this.Helper_Enabled = false;
            this.Threshold = default(n28.GpuValue<float>);
            this.Normalized_Texture_Data = false;
            this.Z_Box_Vector_Confinement_Enabled = false;
            this.Helper_Texture_Enabled = false;
            this.Helper_Frame_Color = n50._Operations_.CreateDefault();
            this.Level = default(n28.GpuValue<float>);
            this.Sampler = default(n28.GpuValue<n27.SamplerState>);
            this.TVector_Transformation_Function = default(n28.GpuValue<n6.Vector3>);
            this.Context = n4.FluidContext_C.CreateDefault();
            this.__p_VBFpaun3X9nPxGr1RvMfSJ = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.CreateDefault();
            this.__p_FoZALuaNNkrO5WKvlSUfTF = n72.VolumeCellCoordToPosition_P7ztrzbErhnLtBeQ04ZWFo.CreateDefault();
            this.__monadBuilder_GF39ZcFazsVOClsw3oxr12 = n28.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_M8yNtNJmfqfMloLrJdXNK4 = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            this.__p_JTODYq10Q2JPBm3cZg3kdy = n78.SampleTexture2DVectorField_C.CreateDefault();
            this.__cache_UVDnzVc4t1iLIxr4zKKbIS = null;
            this.__p_KOjQZbYEMgQMJ3E9v0Lqod = n79.GetHelper_SIlUS90jQlRLGG88cf3x83.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_VBFpaun3X9nPxGr1RvMfSJ);
            n1.CompilationHelper.SafeDispose(this.__p_FoZALuaNNkrO5WKvlSUfTF);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_GF39ZcFazsVOClsw3oxr12);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_M8yNtNJmfqfMloLrJdXNK4);
            n1.CompilationHelper.SafeDispose(this.__p_JTODYq10Q2JPBm3cZg3kdy);
            n1.CompilationHelper.SafeDispose(this.__cache_UVDnzVc4t1iLIxr4zKKbIS);
            n1.CompilationHelper.SafeDispose(this.__p_KOjQZbYEMgQMJ3E9v0Lqod);
            return;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.GetHelperEntity(out n43.Entity Helper_Entity_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetHelperEntity_(out Helper_Entity_Out);
            return __returnValue__;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.GetHelperEnabled(out bool Helper_Enabled_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetHelperEnabled_(out Helper_Enabled_Out);
            return __returnValue__;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.SetContext(n4.FluidContext_C Context_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = SetContext_(Context_In);
            return __returnValue__;
        }

        n11.IPostTexAdvectComputeGraphProvider_I n11.IPostTexAdvectComputeGraphProvider_I.GetPriority(out float Priority_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Priority_Out = 0F;
            return this;
        }

        n11.IPostTexAdvectComputeGraphProvider_I n11.IPostTexAdvectComputeGraphProvider_I.Update(out n28.GpuValue<n54.GpuVoid> Graph_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(out Graph_Out);
            return __returnValue__;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 352648U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Tv7yJWOfpNSL55S50in7Er", Name = "__slot_Tv7yJWOfpNSL55S50in7Er")]
        public static bool __slot_Tv7yJWOfpNSL55S50in7Er = true;
        [n1.ElementAttribute(TracingId = 352657U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OZL2FOBGm3CL8BB7hbIx8N", Name = "__slot_OZL2FOBGm3CL8BB7hbIx8N")]
        public static float __slot_OZL2FOBGm3CL8BB7hbIx8N = 1F;
        [n1.ElementAttribute(TracingId = 352679U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LbiPDdyyAASMo8hD34anvE", Name = "__slot_LbiPDdyyAASMo8hD34anvE")]
        public static bool __slot_LbiPDdyyAASMo8hD34anvE = true;
        [n1.ElementAttribute(TracingId = 352688U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "PYyozTa3frhLMxDyarTWxL", Name = "__slot_PYyozTa3frhLMxDyarTWxL")]
        public static bool __slot_PYyozTa3frhLMxDyarTWxL = true;
        [n1.ElementAttribute(TracingId = 352864U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BnzxzIxc4lAPuecK8fPdNP", Name = "__slot_BnzxzIxc4lAPuecK8fPdNP")]
        public static bool __slot_BnzxzIxc4lAPuecK8fPdNP = true;
        [n1.ElementAttribute(TracingId = 353395U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "K9ndibvVOlsP8bsakMHwno", Name = "__slot_K9ndibvVOlsP8bsakMHwno")]
        public n28.GpuValue<n6.Vector3> __slot_K9ndibvVOlsP8bsakMHwno;
        [n1.ElementAttribute(TracingId = 353410U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "A8tjSzdjnuuOUcnSnLeH7P", Name = "__slot_A8tjSzdjnuuOUcnSnLeH7P")]
        public n28.GpuValue<n6.Vector3> __slot_A8tjSzdjnuuOUcnSnLeH7P;
        [n1.ElementAttribute(TracingId = 352635U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "AvRQWim6R2kOkWpQtniP6H", Name = "Texture")]
        public n27.Texture Texture;
        [n1.ElementAttribute(TracingId = 352638U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GD0PeAxeTUIOjc9sLvDA0i", Name = "Transformation")]
        public n6.Matrix Transformation;
        [n1.ElementAttribute(TracingId = 352590U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JwrqMqyiwoMNK5seZJqShX", Name = "Additive")]
        public bool Additive;
        [n1.ElementAttribute(TracingId = 352641U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "V0IKK9MR5yqQSndK5VSh7N", Name = "Strength")]
        public float Strength;
        [n1.ElementAttribute(TracingId = 352666U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "HvNCQoCIZpQLRNNCfU6iJN", Name = "Enabled")]
        public bool Enabled;
        [n1.ElementAttribute(TracingId = 352676U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VvLDi2TlG9pMH7JER4AcRS", Name = "Helper Enabled")]
        public bool Helper_Enabled;
        [n1.ElementAttribute(TracingId = 352701U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Hp7QvG3mkGAOmKahiRVMsi", Name = "Threshold")]
        public n28.GpuValue<float> Threshold;
        [n1.ElementAttribute(TracingId = 352846U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VE8vveIntgHLGHuaKitQ2B", Name = "Normalized Texture Data")]
        public bool Normalized_Texture_Data;
        [n1.ElementAttribute(TracingId = 352855U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "PdbzU2KM57gMbD8OJTjLix", Name = "Z Box Vector Confinement Enabled")]
        public bool Z_Box_Vector_Confinement_Enabled;
        [n1.ElementAttribute(TracingId = 352884U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UnhMG08OaOzPQw6cG4q5bo", Name = "Helper Texture Enabled")]
        public bool Helper_Texture_Enabled;
        [n1.ElementAttribute(TracingId = 353370U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IjqHtxpNLRxOtv6ThJaGE9", Name = "Helper Frame Color")]
        public n6.Color4 Helper_Frame_Color;
        [n1.ElementAttribute(TracingId = 353378U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "AKA9olUcn7cPL6JMxfpzQF", Name = "Level")]
        public n28.GpuValue<float> Level;
        [n1.ElementAttribute(TracingId = 353386U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MfhIJbXh6VDM3nzeqzRuqe", Name = "Sampler")]
        public n28.GpuValue<n27.SamplerState> Sampler;
        [n1.ElementAttribute(TracingId = 352849U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BsOsaHhqWOlNk8amorqCD7", Name = "~Vector Transformation Function")]
        public n28.GpuValue<n6.Vector3> TVector_Transformation_Function;
        [n1.ElementAttribute(TracingId = 353420U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UWV1TRUCirINbtFtp4YlMA", Name = "Context")]
        public n4.FluidContext_C Context;
        [n1.ElementAttribute(TracingId = 352691U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VBFpaun3X9nPxGr1RvMfSJ", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
        public n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_VBFpaun3X9nPxGr1RvMfSJ;
        [n1.ElementAttribute(TracingId = 352594U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FoZALuaNNkrO5WKvlSUfTF", Name = "VolumeCellCoordToPosition", IsManaged = true, IsAutoGenerated = true)]
        public n72.VolumeCellCoordToPosition_P7ztrzbErhnLtBeQ04ZWFo __p_FoZALuaNNkrO5WKvlSUfTF;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<float, n28.GpuValue<float>> __monadBuilder_GF39ZcFazsVOClsw3oxr12 = n28.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_M8yNtNJmfqfMloLrJdXNK4 = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 352714U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JTODYq10Q2JPBm3cZg3kdy", Name = "SampleTexture2DVectorField", IsManaged = true, IsAutoGenerated = true)]
        public n78.SampleTexture2DVectorField_C __p_JTODYq10Q2JPBm3cZg3kdy;
        [n1.ElementAttribute(TracingId = 352889U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UVDnzVc4t1iLIxr4zKKbIS", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<n27.Texture, bool, n4.FluidContext_C, bool, n28.GpuValue<float>, n28.GpuValue<n6.Vector3>>, n2.ValueTuple<n28.GpuValue<n54.GpuVoid>>> __cache_UVDnzVc4t1iLIxr4zKKbIS = null;
        [n1.ElementAttribute(TracingId = 353353U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "COdQSSRXedwPs4CDUmorR7", Name = "__slot_COdQSSRXedwPs4CDUmorR7")]
        public static string __slot_COdQSSRXedwPs4CDUmorR7 = "ObstaclesGradient";
        [n1.ElementAttribute(TracingId = 353019U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QcvrMVqfzIJLUk8XEVGbjs", Name = "__slot_QcvrMVqfzIJLUk8XEVGbjs")]
        public static float __slot_QcvrMVqfzIJLUk8XEVGbjs = 0.09999999F;
        [n1.ElementAttribute(TracingId = 353305U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ELjTtzu5hqaNPwWMzEbC8r", Name = "__slot_ELjTtzu5hqaNPwWMzEbC8r")]
        public static string __slot_ELjTtzu5hqaNPwWMzEbC8r = "Velocity";
        [n1.ElementAttribute(TracingId = 353397U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KOjQZbYEMgQMJ3E9v0Lqod", Name = "GetHelper", IsManaged = true, IsAutoGenerated = true)]
        public n79.GetHelper_SIlUS90jQlRLGG88cf3x83 __p_KOjQZbYEMgQMJ3E9v0Lqod;
        static Texture2DVectorField_Fluid3D_C()
        {
        }

        public Texture2DVectorField_Fluid3D_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Texture2DVectorField_Fluid3D_C(Texture2DVectorField_Fluid3D_C other): base(other)
        {
            this.__slot_K9ndibvVOlsP8bsakMHwno = other.__slot_K9ndibvVOlsP8bsakMHwno;
            this.__slot_A8tjSzdjnuuOUcnSnLeH7P = other.__slot_A8tjSzdjnuuOUcnSnLeH7P;
            this.Texture = other.Texture;
            this.Transformation = other.Transformation;
            this.Additive = other.Additive;
            this.Strength = other.Strength;
            this.Enabled = other.Enabled;
            this.Helper_Enabled = other.Helper_Enabled;
            this.Threshold = other.Threshold;
            this.Normalized_Texture_Data = other.Normalized_Texture_Data;
            this.Z_Box_Vector_Confinement_Enabled = other.Z_Box_Vector_Confinement_Enabled;
            this.Helper_Texture_Enabled = other.Helper_Texture_Enabled;
            this.Helper_Frame_Color = other.Helper_Frame_Color;
            this.Level = other.Level;
            this.Sampler = other.Sampler;
            this.TVector_Transformation_Function = other.TVector_Transformation_Function;
            this.Context = other.Context;
            this.__p_VBFpaun3X9nPxGr1RvMfSJ = other.__p_VBFpaun3X9nPxGr1RvMfSJ;
            this.__p_FoZALuaNNkrO5WKvlSUfTF = other.__p_FoZALuaNNkrO5WKvlSUfTF;
            this.__monadBuilder_GF39ZcFazsVOClsw3oxr12 = other.__monadBuilder_GF39ZcFazsVOClsw3oxr12;
            this.__monadBuilder_M8yNtNJmfqfMloLrJdXNK4 = other.__monadBuilder_M8yNtNJmfqfMloLrJdXNK4;
            this.__p_JTODYq10Q2JPBm3cZg3kdy = other.__p_JTODYq10Q2JPBm3cZg3kdy;
            this.__cache_UVDnzVc4t1iLIxr4zKKbIS = other.__cache_UVDnzVc4t1iLIxr4zKKbIS;
            this.__p_KOjQZbYEMgQMJ3E9v0Lqod = other.__p_KOjQZbYEMgQMJ3E9v0Lqod;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_K9ndibvVOlsP8bsakMHwno", in __slot_K9ndibvVOlsP8bsakMHwno), n1.CompilationHelper.GetValueOrExisting(values, "__slot_A8tjSzdjnuuOUcnSnLeH7P", in __slot_A8tjSzdjnuuOUcnSnLeH7P), n1.CompilationHelper.GetValueOrExisting(values, "Texture", in Texture), n1.CompilationHelper.GetValueOrExisting(values, "Transformation", in Transformation), n1.CompilationHelper.GetValueOrExisting(values, "Additive", in Additive), n1.CompilationHelper.GetValueOrExisting(values, "Strength", in Strength), n1.CompilationHelper.GetValueOrExisting(values, "Enabled", in Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Helper_Enabled", in Helper_Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Threshold", in Threshold), n1.CompilationHelper.GetValueOrExisting(values, "Normalized_Texture_Data", in Normalized_Texture_Data), n1.CompilationHelper.GetValueOrExisting(values, "Z_Box_Vector_Confinement_Enabled", in Z_Box_Vector_Confinement_Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Helper_Texture_Enabled", in Helper_Texture_Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Helper_Frame_Color", in Helper_Frame_Color), n1.CompilationHelper.GetValueOrExisting(values, "Level", in Level), n1.CompilationHelper.GetValueOrExisting(values, "Sampler", in Sampler), n1.CompilationHelper.GetValueOrExisting(values, "TVector_Transformation_Function", in TVector_Transformation_Function), n1.CompilationHelper.GetValueOrExisting(values, "Context", in Context), n1.CompilationHelper.GetValueOrExisting(values, "__p_VBFpaun3X9nPxGr1RvMfSJ", in __p_VBFpaun3X9nPxGr1RvMfSJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_FoZALuaNNkrO5WKvlSUfTF", in __p_FoZALuaNNkrO5WKvlSUfTF), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_GF39ZcFazsVOClsw3oxr12", in __monadBuilder_GF39ZcFazsVOClsw3oxr12), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_M8yNtNJmfqfMloLrJdXNK4", in __monadBuilder_M8yNtNJmfqfMloLrJdXNK4), n1.CompilationHelper.GetValueOrExisting(values, "__p_JTODYq10Q2JPBm3cZg3kdy", in __p_JTODYq10Q2JPBm3cZg3kdy), n1.CompilationHelper.GetValueOrExisting(values, "__cache_UVDnzVc4t1iLIxr4zKKbIS", in __cache_UVDnzVc4t1iLIxr4zKKbIS), n1.CompilationHelper.GetValueOrExisting(values, "__p_KOjQZbYEMgQMJ3E9v0Lqod", in __p_KOjQZbYEMgQMJ3E9v0Lqod));
        }

        internal Texture2DVectorField_Fluid3D_C __WITH__(n28.GpuValue<n6.Vector3> __slot_K9ndibvVOlsP8bsakMHwno, n28.GpuValue<n6.Vector3> __slot_A8tjSzdjnuuOUcnSnLeH7P, n27.Texture Texture, n6.Matrix Transformation, bool Additive, float Strength, bool Enabled, bool Helper_Enabled, n28.GpuValue<float> Threshold, bool Normalized_Texture_Data, bool Z_Box_Vector_Confinement_Enabled, bool Helper_Texture_Enabled, n6.Color4 Helper_Frame_Color, n28.GpuValue<float> Level, n28.GpuValue<n27.SamplerState> Sampler, n28.GpuValue<n6.Vector3> TVector_Transformation_Function, n4.FluidContext_C Context, n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_VBFpaun3X9nPxGr1RvMfSJ, n72.VolumeCellCoordToPosition_P7ztrzbErhnLtBeQ04ZWFo __p_FoZALuaNNkrO5WKvlSUfTF, n1.IMonadBuilder<float, n28.GpuValue<float>> __monadBuilder_GF39ZcFazsVOClsw3oxr12, n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_M8yNtNJmfqfMloLrJdXNK4, n78.SampleTexture2DVectorField_C __p_JTODYq10Q2JPBm3cZg3kdy, n13.Manager<n2.ValueTuple<n27.Texture, bool, n4.FluidContext_C, bool, n28.GpuValue<float>, n28.GpuValue<n6.Vector3>>, n2.ValueTuple<n28.GpuValue<n54.GpuVoid>>> __cache_UVDnzVc4t1iLIxr4zKKbIS, n79.GetHelper_SIlUS90jQlRLGG88cf3x83 __p_KOjQZbYEMgQMJ3E9v0Lqod)
        {
            n11.Texture2DVectorField_Fluid3D_C that_0 = this;
            this.__slot_K9ndibvVOlsP8bsakMHwno = __slot_K9ndibvVOlsP8bsakMHwno;
            this.__slot_A8tjSzdjnuuOUcnSnLeH7P = __slot_A8tjSzdjnuuOUcnSnLeH7P;
            this.Texture = Texture;
            this.Transformation = Transformation;
            this.Additive = Additive;
            this.Strength = Strength;
            this.Enabled = Enabled;
            this.Helper_Enabled = Helper_Enabled;
            this.Threshold = Threshold;
            this.Normalized_Texture_Data = Normalized_Texture_Data;
            this.Z_Box_Vector_Confinement_Enabled = Z_Box_Vector_Confinement_Enabled;
            this.Helper_Texture_Enabled = Helper_Texture_Enabled;
            this.Helper_Frame_Color = Helper_Frame_Color;
            this.Level = Level;
            this.Sampler = Sampler;
            this.TVector_Transformation_Function = TVector_Transformation_Function;
            this.Context = Context;
            this.__p_VBFpaun3X9nPxGr1RvMfSJ = __p_VBFpaun3X9nPxGr1RvMfSJ;
            this.__p_FoZALuaNNkrO5WKvlSUfTF = __p_FoZALuaNNkrO5WKvlSUfTF;
            this.__monadBuilder_GF39ZcFazsVOClsw3oxr12 = __monadBuilder_GF39ZcFazsVOClsw3oxr12;
            this.__monadBuilder_M8yNtNJmfqfMloLrJdXNK4 = __monadBuilder_M8yNtNJmfqfMloLrJdXNK4;
            this.__p_JTODYq10Q2JPBm3cZg3kdy = __p_JTODYq10Q2JPBm3cZg3kdy;
            this.__cache_UVDnzVc4t1iLIxr4zKKbIS = __cache_UVDnzVc4t1iLIxr4zKKbIS;
            this.__p_KOjQZbYEMgQMJ3E9v0Lqod = __p_KOjQZbYEMgQMJ3E9v0Lqod;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JDjLw0zovKyN5bFk16wxyd", Name = "__JDjLw0zovKyN5bFk16wxyd")]
        [n2.SerializableAttribute]
        public class __JDjLw0zovKyN5bFk16wxyd : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_D7sdDuLc0ZeOJB0awPgXpm);
                n1.CompilationHelper.SafeDispose(this.__p_Q78qsi0MpUkPPJbhnY4OaG);
                n1.CompilationHelper.SafeDispose(this.__p_ERL1bnLYlq4N3GhHePIOws);
                n1.CompilationHelper.SafeDispose(this.__p_Oi3N1vX4hVYN1WJ6jsXgu1);
                n1.CompilationHelper.SafeDispose(this.__p_GiCscrboaDbL4k3nomGK6m);
                n1.CompilationHelper.SafeDispose(this.__p_UJ7g3dMxczsNhtNnmkBsBJ);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_AFadesiuFxoQB7yuJEtd0j);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_TNeapDzkHJMNcF6hfCUzwu);
                n1.CompilationHelper.SafeDispose(this.__customRegion_UJ7g3dMxczsNhtNnmkBsBJ);
                return;
            }

            [n1.ElementAttribute(TracingId = 352955U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "D7sdDuLc0ZeOJB0awPgXpm", Name = "TextureGet", IsManaged = true, IsAutoGenerated = true)]
            public n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, float> __p_D7sdDuLc0ZeOJB0awPgXpm;
            [n1.ElementAttribute(TracingId = 352971U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Q78qsi0MpUkPPJbhnY4OaG", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
            public n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_Q78qsi0MpUkPPJbhnY4OaG;
            [n1.ElementAttribute(TracingId = 352985U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ERL1bnLYlq4N3GhHePIOws", Name = "<", IsManaged = true, IsAutoGenerated = true)]
            public n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_ERL1bnLYlq4N3GhHePIOws;
            [n1.ElementAttribute(TracingId = 353001U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Oi3N1vX4hVYN1WJ6jsXgu1", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_Oi3N1vX4hVYN1WJ6jsXgu1;
            [n1.ElementAttribute(TracingId = 353025U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GiCscrboaDbL4k3nomGK6m", Name = "AND", IsManaged = true, IsAutoGenerated = true)]
            public n59.AND_TkWZzQWwZ0tLZt6ooZGazh __p_GiCscrboaDbL4k3nomGK6m;
            [n1.ElementAttribute(TracingId = 353042U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UJ7g3dMxczsNhtNnmkBsBJ", Name = "If (Fuse)", IsManaged = true, IsAutoGenerated = true)]
            public n74.If_Fuse_C __p_UJ7g3dMxczsNhtNnmkBsBJ;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_AFadesiuFxoQB7yuJEtd0j = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_TNeapDzkHJMNcF6hfCUzwu = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n28.GpuValue<bool>> __pin_group_Values_In_GiCscrboaDbL4k3nomGK6m = default(n12.Spread<n28.GpuValue<bool>>);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n71.CustomRegion __customRegion_UJ7g3dMxczsNhtNnmkBsBJ;
            public __JDjLw0zovKyN5bFk16wxyd(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __JDjLw0zovKyN5bFk16wxyd(__JDjLw0zovKyN5bFk16wxyd other): base(other)
            {
                this.__p_D7sdDuLc0ZeOJB0awPgXpm = other.__p_D7sdDuLc0ZeOJB0awPgXpm;
                this.__p_Q78qsi0MpUkPPJbhnY4OaG = other.__p_Q78qsi0MpUkPPJbhnY4OaG;
                this.__p_ERL1bnLYlq4N3GhHePIOws = other.__p_ERL1bnLYlq4N3GhHePIOws;
                this.__p_Oi3N1vX4hVYN1WJ6jsXgu1 = other.__p_Oi3N1vX4hVYN1WJ6jsXgu1;
                this.__p_GiCscrboaDbL4k3nomGK6m = other.__p_GiCscrboaDbL4k3nomGK6m;
                this.__p_UJ7g3dMxczsNhtNnmkBsBJ = other.__p_UJ7g3dMxczsNhtNnmkBsBJ;
                this.__monadBuilder_AFadesiuFxoQB7yuJEtd0j = other.__monadBuilder_AFadesiuFxoQB7yuJEtd0j;
                this.__monadBuilder_TNeapDzkHJMNcF6hfCUzwu = other.__monadBuilder_TNeapDzkHJMNcF6hfCUzwu;
                this.__pin_group_Values_In_GiCscrboaDbL4k3nomGK6m = other.__pin_group_Values_In_GiCscrboaDbL4k3nomGK6m;
                this.__customRegion_UJ7g3dMxczsNhtNnmkBsBJ = other.__customRegion_UJ7g3dMxczsNhtNnmkBsBJ;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_D7sdDuLc0ZeOJB0awPgXpm", in __p_D7sdDuLc0ZeOJB0awPgXpm), n1.CompilationHelper.GetValueOrExisting(values, "__p_Q78qsi0MpUkPPJbhnY4OaG", in __p_Q78qsi0MpUkPPJbhnY4OaG), n1.CompilationHelper.GetValueOrExisting(values, "__p_ERL1bnLYlq4N3GhHePIOws", in __p_ERL1bnLYlq4N3GhHePIOws), n1.CompilationHelper.GetValueOrExisting(values, "__p_Oi3N1vX4hVYN1WJ6jsXgu1", in __p_Oi3N1vX4hVYN1WJ6jsXgu1), n1.CompilationHelper.GetValueOrExisting(values, "__p_GiCscrboaDbL4k3nomGK6m", in __p_GiCscrboaDbL4k3nomGK6m), n1.CompilationHelper.GetValueOrExisting(values, "__p_UJ7g3dMxczsNhtNnmkBsBJ", in __p_UJ7g3dMxczsNhtNnmkBsBJ), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_AFadesiuFxoQB7yuJEtd0j", in __monadBuilder_AFadesiuFxoQB7yuJEtd0j), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_TNeapDzkHJMNcF6hfCUzwu", in __monadBuilder_TNeapDzkHJMNcF6hfCUzwu), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Values_In_GiCscrboaDbL4k3nomGK6m", in __pin_group_Values_In_GiCscrboaDbL4k3nomGK6m), n1.CompilationHelper.GetValueOrExisting(values, "__customRegion_UJ7g3dMxczsNhtNnmkBsBJ", in __customRegion_UJ7g3dMxczsNhtNnmkBsBJ));
            }

            internal __JDjLw0zovKyN5bFk16wxyd __WITH__(n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, float> __p_D7sdDuLc0ZeOJB0awPgXpm, n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_Q78qsi0MpUkPPJbhnY4OaG, n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_ERL1bnLYlq4N3GhHePIOws, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_Oi3N1vX4hVYN1WJ6jsXgu1, n59.AND_TkWZzQWwZ0tLZt6ooZGazh __p_GiCscrboaDbL4k3nomGK6m, n74.If_Fuse_C __p_UJ7g3dMxczsNhtNnmkBsBJ, n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_AFadesiuFxoQB7yuJEtd0j, n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_TNeapDzkHJMNcF6hfCUzwu, n12.Spread<n28.GpuValue<bool>> __pin_group_Values_In_GiCscrboaDbL4k3nomGK6m, n71.CustomRegion __customRegion_UJ7g3dMxczsNhtNnmkBsBJ)
            {
                __JDjLw0zovKyN5bFk16wxyd that_0 = this;
                this.__p_D7sdDuLc0ZeOJB0awPgXpm = __p_D7sdDuLc0ZeOJB0awPgXpm;
                this.__p_Q78qsi0MpUkPPJbhnY4OaG = __p_Q78qsi0MpUkPPJbhnY4OaG;
                this.__p_ERL1bnLYlq4N3GhHePIOws = __p_ERL1bnLYlq4N3GhHePIOws;
                this.__p_Oi3N1vX4hVYN1WJ6jsXgu1 = __p_Oi3N1vX4hVYN1WJ6jsXgu1;
                this.__p_GiCscrboaDbL4k3nomGK6m = __p_GiCscrboaDbL4k3nomGK6m;
                this.__p_UJ7g3dMxczsNhtNnmkBsBJ = __p_UJ7g3dMxczsNhtNnmkBsBJ;
                this.__monadBuilder_AFadesiuFxoQB7yuJEtd0j = __monadBuilder_AFadesiuFxoQB7yuJEtd0j;
                this.__monadBuilder_TNeapDzkHJMNcF6hfCUzwu = __monadBuilder_TNeapDzkHJMNcF6hfCUzwu;
                this.__pin_group_Values_In_GiCscrboaDbL4k3nomGK6m = __pin_group_Values_In_GiCscrboaDbL4k3nomGK6m;
                this.__customRegion_UJ7g3dMxczsNhtNnmkBsBJ = __customRegion_UJ7g3dMxczsNhtNnmkBsBJ;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DhhMcxxAtO4PsA6RHzAlkL", Name = "__DhhMcxxAtO4PsA6RHzAlkL")]
        [n2.SerializableAttribute]
        public class __DhhMcxxAtO4PsA6RHzAlkL : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_BYN2xBsNGbsLktL1BKbK3t);
                n1.CompilationHelper.SafeDispose(this.__p_KZiROCzyaCDLC9YMLiNuzu);
                n1.CompilationHelper.SafeDispose(this.__p_I2WICMlX9LZMvkhKh74rCu);
                n1.CompilationHelper.SafeDispose(this.__p_ITdM86MSPEnPJiBUdefbof);
                n1.CompilationHelper.SafeDispose(this.__p_HCThqVtngoaPGww0rkoOm2);
                n1.CompilationHelper.SafeDispose(this.__p_GS9rMF6FOXjLzMNu4dwyIo);
                n1.CompilationHelper.SafeDispose(this.__p_DAPmpFBoFXvOs8cEAI3e98);
                n1.CompilationHelper.SafeDispose(this.__p_FogbL6neCTlP61paeOVp0q);
                n1.CompilationHelper.SafeDispose(this.__p_AtdqSCk0lP3ORvl6zABoOk);
                n1.CompilationHelper.SafeDispose(this.__p_Ng7d9nqjXGNMdUzKKw2K5L);
                return;
            }

            [n1.ElementAttribute(TracingId = 353089U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BYN2xBsNGbsLktL1BKbK3t", Name = "Length", IsManaged = true, IsAutoGenerated = true)]
            public n75.Length_P0UB6WKESd0PjWRm8eD1d4<n6.Vector3> __p_BYN2xBsNGbsLktL1BKbK3t;
            [n1.ElementAttribute(TracingId = 353119U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KZiROCzyaCDLC9YMLiNuzu", Name = ">", IsManaged = true, IsAutoGenerated = true)]
            public n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_KZiROCzyaCDLC9YMLiNuzu;
            [n1.ElementAttribute(TracingId = 353219U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "I2WICMlX9LZMvkhKh74rCu", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
            public n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_I2WICMlX9LZMvkhKh74rCu;
            [n1.ElementAttribute(TracingId = 353170U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ITdM86MSPEnPJiBUdefbof", Name = "TextureGet", IsManaged = true, IsAutoGenerated = true)]
            public n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, n6.Vector4> __p_ITdM86MSPEnPJiBUdefbof;
            [n1.ElementAttribute(TracingId = 353165U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "HCThqVtngoaPGww0rkoOm2", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
            public n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_HCThqVtngoaPGww0rkoOm2;
            [n1.ElementAttribute(TracingId = 353191U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GS9rMF6FOXjLzMNu4dwyIo", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
            public n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector3> __p_GS9rMF6FOXjLzMNu4dwyIo;
            [n1.ElementAttribute(TracingId = 353234U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DAPmpFBoFXvOs8cEAI3e98", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n75.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n6.Vector3> __p_DAPmpFBoFXvOs8cEAI3e98;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n28.GpuValue<n6.Vector3>> __pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98 = default(n12.Spread<n28.GpuValue<n6.Vector3>>);
            [n1.ElementAttribute(TracingId = 353255U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FogbL6neCTlP61paeOVp0q", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_FogbL6neCTlP61paeOVp0q;
            [n1.ElementAttribute(TracingId = 353078U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "AtdqSCk0lP3ORvl6zABoOk", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
            public n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_AtdqSCk0lP3ORvl6zABoOk;
            [n1.ElementAttribute(TracingId = 353067U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Ng7d9nqjXGNMdUzKKw2K5L", Name = "TextureSet", IsManaged = true, IsAutoGenerated = true)]
            public n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, n6.Vector4> __p_Ng7d9nqjXGNMdUzKKw2K5L;
            public __DhhMcxxAtO4PsA6RHzAlkL(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DhhMcxxAtO4PsA6RHzAlkL(__DhhMcxxAtO4PsA6RHzAlkL other): base(other)
            {
                this.__p_BYN2xBsNGbsLktL1BKbK3t = other.__p_BYN2xBsNGbsLktL1BKbK3t;
                this.__p_KZiROCzyaCDLC9YMLiNuzu = other.__p_KZiROCzyaCDLC9YMLiNuzu;
                this.__p_I2WICMlX9LZMvkhKh74rCu = other.__p_I2WICMlX9LZMvkhKh74rCu;
                this.__p_ITdM86MSPEnPJiBUdefbof = other.__p_ITdM86MSPEnPJiBUdefbof;
                this.__p_HCThqVtngoaPGww0rkoOm2 = other.__p_HCThqVtngoaPGww0rkoOm2;
                this.__p_GS9rMF6FOXjLzMNu4dwyIo = other.__p_GS9rMF6FOXjLzMNu4dwyIo;
                this.__p_DAPmpFBoFXvOs8cEAI3e98 = other.__p_DAPmpFBoFXvOs8cEAI3e98;
                this.__pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98 = other.__pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98;
                this.__p_FogbL6neCTlP61paeOVp0q = other.__p_FogbL6neCTlP61paeOVp0q;
                this.__p_AtdqSCk0lP3ORvl6zABoOk = other.__p_AtdqSCk0lP3ORvl6zABoOk;
                this.__p_Ng7d9nqjXGNMdUzKKw2K5L = other.__p_Ng7d9nqjXGNMdUzKKw2K5L;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BYN2xBsNGbsLktL1BKbK3t", in __p_BYN2xBsNGbsLktL1BKbK3t), n1.CompilationHelper.GetValueOrExisting(values, "__p_KZiROCzyaCDLC9YMLiNuzu", in __p_KZiROCzyaCDLC9YMLiNuzu), n1.CompilationHelper.GetValueOrExisting(values, "__p_I2WICMlX9LZMvkhKh74rCu", in __p_I2WICMlX9LZMvkhKh74rCu), n1.CompilationHelper.GetValueOrExisting(values, "__p_ITdM86MSPEnPJiBUdefbof", in __p_ITdM86MSPEnPJiBUdefbof), n1.CompilationHelper.GetValueOrExisting(values, "__p_HCThqVtngoaPGww0rkoOm2", in __p_HCThqVtngoaPGww0rkoOm2), n1.CompilationHelper.GetValueOrExisting(values, "__p_GS9rMF6FOXjLzMNu4dwyIo", in __p_GS9rMF6FOXjLzMNu4dwyIo), n1.CompilationHelper.GetValueOrExisting(values, "__p_DAPmpFBoFXvOs8cEAI3e98", in __p_DAPmpFBoFXvOs8cEAI3e98), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98", in __pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98), n1.CompilationHelper.GetValueOrExisting(values, "__p_FogbL6neCTlP61paeOVp0q", in __p_FogbL6neCTlP61paeOVp0q), n1.CompilationHelper.GetValueOrExisting(values, "__p_AtdqSCk0lP3ORvl6zABoOk", in __p_AtdqSCk0lP3ORvl6zABoOk), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ng7d9nqjXGNMdUzKKw2K5L", in __p_Ng7d9nqjXGNMdUzKKw2K5L));
            }

            internal __DhhMcxxAtO4PsA6RHzAlkL __WITH__(n75.Length_P0UB6WKESd0PjWRm8eD1d4<n6.Vector3> __p_BYN2xBsNGbsLktL1BKbK3t, n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_KZiROCzyaCDLC9YMLiNuzu, n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_I2WICMlX9LZMvkhKh74rCu, n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, n6.Vector4> __p_ITdM86MSPEnPJiBUdefbof, n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_HCThqVtngoaPGww0rkoOm2, n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector3> __p_GS9rMF6FOXjLzMNu4dwyIo, n75.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n6.Vector3> __p_DAPmpFBoFXvOs8cEAI3e98, n12.Spread<n28.GpuValue<n6.Vector3>> __pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98, n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_FogbL6neCTlP61paeOVp0q, n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_AtdqSCk0lP3ORvl6zABoOk, n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, n6.Vector4> __p_Ng7d9nqjXGNMdUzKKw2K5L)
            {
                __DhhMcxxAtO4PsA6RHzAlkL that_0 = this;
                this.__p_BYN2xBsNGbsLktL1BKbK3t = __p_BYN2xBsNGbsLktL1BKbK3t;
                this.__p_KZiROCzyaCDLC9YMLiNuzu = __p_KZiROCzyaCDLC9YMLiNuzu;
                this.__p_I2WICMlX9LZMvkhKh74rCu = __p_I2WICMlX9LZMvkhKh74rCu;
                this.__p_ITdM86MSPEnPJiBUdefbof = __p_ITdM86MSPEnPJiBUdefbof;
                this.__p_HCThqVtngoaPGww0rkoOm2 = __p_HCThqVtngoaPGww0rkoOm2;
                this.__p_GS9rMF6FOXjLzMNu4dwyIo = __p_GS9rMF6FOXjLzMNu4dwyIo;
                this.__p_DAPmpFBoFXvOs8cEAI3e98 = __p_DAPmpFBoFXvOs8cEAI3e98;
                this.__pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98 = __pin_group_Input_In_DAPmpFBoFXvOs8cEAI3e98;
                this.__p_FogbL6neCTlP61paeOVp0q = __p_FogbL6neCTlP61paeOVp0q;
                this.__p_AtdqSCk0lP3ORvl6zABoOk = __p_AtdqSCk0lP3ORvl6zABoOk;
                this.__p_Ng7d9nqjXGNMdUzKKw2K5L = __p_Ng7d9nqjXGNMdUzKKw2K5L;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 353907U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IlotDWCS5aALQ0vLXjJw9T", Name = "ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T")]
    [n2.SerializableAttribute]
    public class ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n11.ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T Create(n1.NodeContext Node_Context)
        {
            var instance = new ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T CreateDefault()
        {
            var instance = new ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T Update(n28.GpuValue<float> Gradient_In, n28.GpuValue<n6.Vector3> Position_In, n28.GpuValue<float> SDF_In, [n5.SerializedDefaultValueAttribute("0.03", false)] float Surface_Border_Thickness_In, out n28.GpuValue<float> Gradient_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_UZETflGRDTqLEplPyAdikT;
            if (manager_2 is null)
            {
                manager_2 = new n13.Manager<n2.ValueTuple<n28.GpuValue<float>, n28.GpuValue<n6.Vector3>, float, n28.GpuValue<float>>, n2.ValueTuple<n28.GpuValue<float>>>(n2.ValueTuple.Create(default(n28.GpuValue<float>)));
            }

            var inputs_3 = (SDF_In, Position_In, Surface_Border_Thickness_In, Gradient_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__JFcjRwkqaAwL7KLMxNimOU>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __JFcjRwkqaAwL7KLMxNimOU(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7 = n14._Operations_.CreateDefault<n28.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "DpkjmK0yXSfMaHN9VaFbn7", 353960U);
                    var Output_8 = n80.Invoke_C<float>.Create(Node_Context: Node_Context_7);
                    state_6.__p_DpkjmK0yXSfMaHN9VaFbn7 = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "RRWuJvkspzJQHUCXi1yGqQ", 353981U);
                    var Output_10 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_9);
                    state_6.__p_RRWuJvkspzJQHUCXi1yGqQ = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "UxJ0pUdh0D4PKZ7LD1gwxF", 354127U);
                    var Output_12 = n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<float>.Create(Node_Context: Node_Context_11);
                    state_6.__p_UxJ0pUdh0D4PKZ7LD1gwxF = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "IFlXQxud99yLFsivyrOuZW", 354150U);
                    var Output_14 = n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float>.Create(Node_Context: Node_Context_13);
                    state_6.__p_IFlXQxud99yLFsivyrOuZW = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Ab53owWvs2XLRoCtaoYeYI", 354167U);
                    var Output_16 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_15);
                    state_6.__p_Ab53owWvs2XLRoCtaoYeYI = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Vd0IyDHTA26LPVpQhrOuUw", 354188U);
                    var Output_18 = n59.OperatorLessThan_SUuTD4z7mZLO9C4ZqWp0i4<float>.Create(Node_Context: Node_Context_17);
                    state_6.__p_Vd0IyDHTA26LPVpQhrOuUw = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "A8U7F4oVDG2PN3BjyUzqzw", 354208U);
                    var Output_20 = n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<float>.Create(Node_Context: Node_Context_19);
                    state_6.__p_A8U7F4oVDG2PN3BjyUzqzw = Output_20;
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "KzwnnnVdOqaNh1cc8rvZvO", 354230U);
                    var Output_22 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_21);
                    state_6.__p_KzwnnnVdOqaNh1cc8rvZvO = Output_22;
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Du565gxutj0QbY2k8ptKl5", 354249U);
                    var Output_24 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_23);
                    state_6.__p_Du565gxutj0QbY2k8ptKl5 = Output_24;
                }

                float __pad_OTBKCcMj1siNCCk0OJquEp_25 = __slot_OTBKCcMj1siNCCk0OJquEp;
                float __pad_OjnJNdkH9EwP0d2azOevQl_26 = __slot_OjnJNdkH9EwP0d2azOevQl;
                float __pad_K0vUfJiW3qzLd5qDxHvfCT_27 = __slot_K0vUfJiW3qzLd5qDxHvfCT;
                var builder_28 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7, 1);
                builder_28.Add(Position_In);
                var __pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7_29 = builder_28.Commit();
                var State_Output_31 = state_6.__p_DpkjmK0yXSfMaHN9VaFbn7.Update(Function_In: SDF_In, Parameters_In: __pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7_29, Output_Out: out n28.GpuValue<float> Output_30);
                var Output_33 = state_6.__p_RRWuJvkspzJQHUCXi1yGqQ.Update(Value_In: Surface_Border_Thickness_In, GpuValue_Out: out n28.GpuValue<float> GpuValue_32);
                var Output_35 = state_6.__p_IFlXQxud99yLFsivyrOuZW.Update(x_In: Output_30, y_In: GpuValue_32, value_Out: out n28.GpuValue<bool> value_34);
                var Output_37 = state_6.__p_Ab53owWvs2XLRoCtaoYeYI.Update(Value_In: __pad_OTBKCcMj1siNCCk0OJquEp_25, GpuValue_Out: out n28.GpuValue<float> GpuValue_36);
                n28.GpuValue<float> The_Default_38 = default(n28.GpuValue<float>);
                var State_Output_40 = state_6.__p_UxJ0pUdh0D4PKZ7LD1gwxF.Update(In_Check_In: value_34, In_False_In: Gradient_In, In_True_In: GpuValue_36, The_Default_In: The_Default_38, Output_Out: out n28.GpuValue<float> Output_39);
                var Output_42 = state_6.__p_Du565gxutj0QbY2k8ptKl5.Update(Value_In: __pad_K0vUfJiW3qzLd5qDxHvfCT_27, GpuValue_Out: out n28.GpuValue<float> GpuValue_41);
                var Output_44 = state_6.__p_Vd0IyDHTA26LPVpQhrOuUw.Update(x_In: Output_30, y_In: GpuValue_41, value_Out: out n28.GpuValue<bool> value_43);
                var Output_46 = state_6.__p_KzwnnnVdOqaNh1cc8rvZvO.Update(Value_In: __pad_OjnJNdkH9EwP0d2azOevQl_26, GpuValue_Out: out n28.GpuValue<float> GpuValue_45);
                n28.GpuValue<float> The_Default_47 = default(n28.GpuValue<float>);
                var State_Output_49 = state_6.__p_A8U7F4oVDG2PN3BjyUzqzw.Update(In_Check_In: value_43, In_False_In: Output_39, In_True_In: GpuValue_45, The_Default_In: The_Default_47, Output_Out: out n28.GpuValue<float> Output_48);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = __pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7_29 != state_6.__pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7 || State_Output_31 != state_6.__p_DpkjmK0yXSfMaHN9VaFbn7 || Output_33 != state_6.__p_RRWuJvkspzJQHUCXi1yGqQ || Output_35 != state_6.__p_IFlXQxud99yLFsivyrOuZW || Output_37 != state_6.__p_Ab53owWvs2XLRoCtaoYeYI || State_Output_40 != state_6.__p_UxJ0pUdh0D4PKZ7LD1gwxF || Output_42 != state_6.__p_Du565gxutj0QbY2k8ptKl5 || Output_44 != state_6.__p_Vd0IyDHTA26LPVpQhrOuUw || Output_46 != state_6.__p_KzwnnnVdOqaNh1cc8rvZvO || State_Output_49 != state_6.__p_A8U7F4oVDG2PN3BjyUzqzw ? new __JFcjRwkqaAwL7KLMxNimOU(state_6)
                    {__pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7 = __pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7_29, __p_DpkjmK0yXSfMaHN9VaFbn7 = State_Output_31, __p_RRWuJvkspzJQHUCXi1yGqQ = Output_33, __p_IFlXQxud99yLFsivyrOuZW = Output_35, __p_Ab53owWvs2XLRoCtaoYeYI = Output_37, __p_UxJ0pUdh0D4PKZ7LD1gwxF = State_Output_40, __p_Du565gxutj0QbY2k8ptKl5 = Output_42, __p_Vd0IyDHTA26LPVpQhrOuUw = Output_44, __p_KzwnnnVdOqaNh1cc8rvZvO = Output_46, __p_A8U7F4oVDG2PN3BjyUzqzw = State_Output_49} : state_6;
                else
                {
                    state_6.__pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7 = __pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7_29;
                    state_6.__p_DpkjmK0yXSfMaHN9VaFbn7 = State_Output_31;
                    state_6.__p_RRWuJvkspzJQHUCXi1yGqQ = Output_33;
                    state_6.__p_IFlXQxud99yLFsivyrOuZW = Output_35;
                    state_6.__p_Ab53owWvs2XLRoCtaoYeYI = Output_37;
                    state_6.__p_UxJ0pUdh0D4PKZ7LD1gwxF = State_Output_40;
                    state_6.__p_Du565gxutj0QbY2k8ptKl5 = Output_42;
                    state_6.__p_Vd0IyDHTA26LPVpQhrOuUw = Output_44;
                    state_6.__p_KzwnnnVdOqaNh1cc8rvZvO = Output_46;
                    state_6.__p_A8U7F4oVDG2PN3BjyUzqzw = State_Output_49;
                }

                outputs_4 = n2.ValueTuple.Create(Output_48);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_50 = outputs_4.Item1;
            Gradient_Out = __auto_50;
            n11.ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T that_51 = this;
            if (this.__GetContext__().IsImmutable)
                that_51 = manager_2 != this.__cache_UZETflGRDTqLEplPyAdikT ? new ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T(this)
                {__cache_UZETflGRDTqLEplPyAdikT = manager_2} : that_51;
            else
            {
                this.__cache_UZETflGRDTqLEplPyAdikT = manager_2;
            }

            return that_51;
        }

        public n11.ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n11.ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T that_0 = this;
            this.__cache_UZETflGRDTqLEplPyAdikT = null;
            return that_0;
        }

        public n11.ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T __CreateDefault__()
        {
            n11.ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T that_0 = this;
            this.__cache_UZETflGRDTqLEplPyAdikT = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_UZETflGRDTqLEplPyAdikT);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 353927U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UZETflGRDTqLEplPyAdikT", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<n28.GpuValue<float>, n28.GpuValue<n6.Vector3>, float, n28.GpuValue<float>>, n2.ValueTuple<n28.GpuValue<float>>> __cache_UZETflGRDTqLEplPyAdikT = null;
        [n1.ElementAttribute(TracingId = 354183U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OTBKCcMj1siNCCk0OJquEp", Name = "__slot_OTBKCcMj1siNCCk0OJquEp")]
        public static float __slot_OTBKCcMj1siNCCk0OJquEp = 0.5F;
        [n1.ElementAttribute(TracingId = 354245U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OjnJNdkH9EwP0d2azOevQl", Name = "__slot_OjnJNdkH9EwP0d2azOevQl")]
        public static float __slot_OjnJNdkH9EwP0d2azOevQl = 1F;
        [n1.ElementAttribute(TracingId = 354269U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "K0vUfJiW3qzLd5qDxHvfCT", Name = "__slot_K0vUfJiW3qzLd5qDxHvfCT")]
        public static float __slot_K0vUfJiW3qzLd5qDxHvfCT = 0F;
        static ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T()
        {
        }

        public ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T(ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T other): base(other)
        {
            this.__cache_UZETflGRDTqLEplPyAdikT = other.__cache_UZETflGRDTqLEplPyAdikT;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_UZETflGRDTqLEplPyAdikT", in __cache_UZETflGRDTqLEplPyAdikT));
        }

        internal ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T __WITH__(n13.Manager<n2.ValueTuple<n28.GpuValue<float>, n28.GpuValue<n6.Vector3>, float, n28.GpuValue<float>>, n2.ValueTuple<n28.GpuValue<float>>> __cache_UZETflGRDTqLEplPyAdikT)
        {
            n11.ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_UZETflGRDTqLEplPyAdikT != this.__cache_UZETflGRDTqLEplPyAdikT ? new ObstacleGradientSDF_IlotDWCS5aALQ0vLXjJw9T(this)
                {__cache_UZETflGRDTqLEplPyAdikT = __cache_UZETflGRDTqLEplPyAdikT} : that_0;
            else
            {
                this.__cache_UZETflGRDTqLEplPyAdikT = __cache_UZETflGRDTqLEplPyAdikT;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JFcjRwkqaAwL7KLMxNimOU", Name = "__JFcjRwkqaAwL7KLMxNimOU")]
        [n2.SerializableAttribute]
        public class __JFcjRwkqaAwL7KLMxNimOU : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_DpkjmK0yXSfMaHN9VaFbn7);
                n1.CompilationHelper.SafeDispose(this.__p_RRWuJvkspzJQHUCXi1yGqQ);
                n1.CompilationHelper.SafeDispose(this.__p_UxJ0pUdh0D4PKZ7LD1gwxF);
                n1.CompilationHelper.SafeDispose(this.__p_IFlXQxud99yLFsivyrOuZW);
                n1.CompilationHelper.SafeDispose(this.__p_Ab53owWvs2XLRoCtaoYeYI);
                n1.CompilationHelper.SafeDispose(this.__p_Vd0IyDHTA26LPVpQhrOuUw);
                n1.CompilationHelper.SafeDispose(this.__p_A8U7F4oVDG2PN3BjyUzqzw);
                n1.CompilationHelper.SafeDispose(this.__p_KzwnnnVdOqaNh1cc8rvZvO);
                n1.CompilationHelper.SafeDispose(this.__p_Du565gxutj0QbY2k8ptKl5);
                return;
            }

            [n1.ElementAttribute(TracingId = 353960U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DpkjmK0yXSfMaHN9VaFbn7", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n80.Invoke_C<float> __p_DpkjmK0yXSfMaHN9VaFbn7;
            [n1.ElementAttribute(TracingId = 353981U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RRWuJvkspzJQHUCXi1yGqQ", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_RRWuJvkspzJQHUCXi1yGqQ;
            [n1.ElementAttribute(TracingId = 354127U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UxJ0pUdh0D4PKZ7LD1gwxF", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
            public n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<float> __p_UxJ0pUdh0D4PKZ7LD1gwxF;
            [n1.ElementAttribute(TracingId = 354150U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IFlXQxud99yLFsivyrOuZW", Name = "<", IsManaged = true, IsAutoGenerated = true)]
            public n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_IFlXQxud99yLFsivyrOuZW;
            [n1.ElementAttribute(TracingId = 354167U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Ab53owWvs2XLRoCtaoYeYI", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_Ab53owWvs2XLRoCtaoYeYI;
            [n1.ElementAttribute(TracingId = 354188U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Vd0IyDHTA26LPVpQhrOuUw", Name = "<=", IsManaged = true, IsAutoGenerated = true)]
            public n59.OperatorLessThan_SUuTD4z7mZLO9C4ZqWp0i4<float> __p_Vd0IyDHTA26LPVpQhrOuUw;
            [n1.ElementAttribute(TracingId = 354208U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "A8U7F4oVDG2PN3BjyUzqzw", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
            public n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<float> __p_A8U7F4oVDG2PN3BjyUzqzw;
            [n1.ElementAttribute(TracingId = 354230U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KzwnnnVdOqaNh1cc8rvZvO", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_KzwnnnVdOqaNh1cc8rvZvO;
            [n1.ElementAttribute(TracingId = 354249U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Du565gxutj0QbY2k8ptKl5", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_Du565gxutj0QbY2k8ptKl5;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n28.AbstractGpuValue> __pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7 = default(n12.Spread<n28.AbstractGpuValue>);
            public __JFcjRwkqaAwL7KLMxNimOU(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __JFcjRwkqaAwL7KLMxNimOU(__JFcjRwkqaAwL7KLMxNimOU other): base(other)
            {
                this.__p_DpkjmK0yXSfMaHN9VaFbn7 = other.__p_DpkjmK0yXSfMaHN9VaFbn7;
                this.__p_RRWuJvkspzJQHUCXi1yGqQ = other.__p_RRWuJvkspzJQHUCXi1yGqQ;
                this.__p_UxJ0pUdh0D4PKZ7LD1gwxF = other.__p_UxJ0pUdh0D4PKZ7LD1gwxF;
                this.__p_IFlXQxud99yLFsivyrOuZW = other.__p_IFlXQxud99yLFsivyrOuZW;
                this.__p_Ab53owWvs2XLRoCtaoYeYI = other.__p_Ab53owWvs2XLRoCtaoYeYI;
                this.__p_Vd0IyDHTA26LPVpQhrOuUw = other.__p_Vd0IyDHTA26LPVpQhrOuUw;
                this.__p_A8U7F4oVDG2PN3BjyUzqzw = other.__p_A8U7F4oVDG2PN3BjyUzqzw;
                this.__p_KzwnnnVdOqaNh1cc8rvZvO = other.__p_KzwnnnVdOqaNh1cc8rvZvO;
                this.__p_Du565gxutj0QbY2k8ptKl5 = other.__p_Du565gxutj0QbY2k8ptKl5;
                this.__pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7 = other.__pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DpkjmK0yXSfMaHN9VaFbn7", in __p_DpkjmK0yXSfMaHN9VaFbn7), n1.CompilationHelper.GetValueOrExisting(values, "__p_RRWuJvkspzJQHUCXi1yGqQ", in __p_RRWuJvkspzJQHUCXi1yGqQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_UxJ0pUdh0D4PKZ7LD1gwxF", in __p_UxJ0pUdh0D4PKZ7LD1gwxF), n1.CompilationHelper.GetValueOrExisting(values, "__p_IFlXQxud99yLFsivyrOuZW", in __p_IFlXQxud99yLFsivyrOuZW), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ab53owWvs2XLRoCtaoYeYI", in __p_Ab53owWvs2XLRoCtaoYeYI), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vd0IyDHTA26LPVpQhrOuUw", in __p_Vd0IyDHTA26LPVpQhrOuUw), n1.CompilationHelper.GetValueOrExisting(values, "__p_A8U7F4oVDG2PN3BjyUzqzw", in __p_A8U7F4oVDG2PN3BjyUzqzw), n1.CompilationHelper.GetValueOrExisting(values, "__p_KzwnnnVdOqaNh1cc8rvZvO", in __p_KzwnnnVdOqaNh1cc8rvZvO), n1.CompilationHelper.GetValueOrExisting(values, "__p_Du565gxutj0QbY2k8ptKl5", in __p_Du565gxutj0QbY2k8ptKl5), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7", in __pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7));
            }

            internal __JFcjRwkqaAwL7KLMxNimOU __WITH__(n80.Invoke_C<float> __p_DpkjmK0yXSfMaHN9VaFbn7, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_RRWuJvkspzJQHUCXi1yGqQ, n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<float> __p_UxJ0pUdh0D4PKZ7LD1gwxF, n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_IFlXQxud99yLFsivyrOuZW, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_Ab53owWvs2XLRoCtaoYeYI, n59.OperatorLessThan_SUuTD4z7mZLO9C4ZqWp0i4<float> __p_Vd0IyDHTA26LPVpQhrOuUw, n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<float> __p_A8U7F4oVDG2PN3BjyUzqzw, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_KzwnnnVdOqaNh1cc8rvZvO, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_Du565gxutj0QbY2k8ptKl5, n12.Spread<n28.AbstractGpuValue> __pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7)
            {
                __JFcjRwkqaAwL7KLMxNimOU that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_DpkjmK0yXSfMaHN9VaFbn7 != this.__p_DpkjmK0yXSfMaHN9VaFbn7 || __p_RRWuJvkspzJQHUCXi1yGqQ != this.__p_RRWuJvkspzJQHUCXi1yGqQ || __p_UxJ0pUdh0D4PKZ7LD1gwxF != this.__p_UxJ0pUdh0D4PKZ7LD1gwxF || __p_IFlXQxud99yLFsivyrOuZW != this.__p_IFlXQxud99yLFsivyrOuZW || __p_Ab53owWvs2XLRoCtaoYeYI != this.__p_Ab53owWvs2XLRoCtaoYeYI || __p_Vd0IyDHTA26LPVpQhrOuUw != this.__p_Vd0IyDHTA26LPVpQhrOuUw || __p_A8U7F4oVDG2PN3BjyUzqzw != this.__p_A8U7F4oVDG2PN3BjyUzqzw || __p_KzwnnnVdOqaNh1cc8rvZvO != this.__p_KzwnnnVdOqaNh1cc8rvZvO || __p_Du565gxutj0QbY2k8ptKl5 != this.__p_Du565gxutj0QbY2k8ptKl5 || __pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7 != this.__pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7 ? new __JFcjRwkqaAwL7KLMxNimOU(this)
                    {__p_DpkjmK0yXSfMaHN9VaFbn7 = __p_DpkjmK0yXSfMaHN9VaFbn7, __p_RRWuJvkspzJQHUCXi1yGqQ = __p_RRWuJvkspzJQHUCXi1yGqQ, __p_UxJ0pUdh0D4PKZ7LD1gwxF = __p_UxJ0pUdh0D4PKZ7LD1gwxF, __p_IFlXQxud99yLFsivyrOuZW = __p_IFlXQxud99yLFsivyrOuZW, __p_Ab53owWvs2XLRoCtaoYeYI = __p_Ab53owWvs2XLRoCtaoYeYI, __p_Vd0IyDHTA26LPVpQhrOuUw = __p_Vd0IyDHTA26LPVpQhrOuUw, __p_A8U7F4oVDG2PN3BjyUzqzw = __p_A8U7F4oVDG2PN3BjyUzqzw, __p_KzwnnnVdOqaNh1cc8rvZvO = __p_KzwnnnVdOqaNh1cc8rvZvO, __p_Du565gxutj0QbY2k8ptKl5 = __p_Du565gxutj0QbY2k8ptKl5, __pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7 = __pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7} : that_0;
                else
                {
                    this.__p_DpkjmK0yXSfMaHN9VaFbn7 = __p_DpkjmK0yXSfMaHN9VaFbn7;
                    this.__p_RRWuJvkspzJQHUCXi1yGqQ = __p_RRWuJvkspzJQHUCXi1yGqQ;
                    this.__p_UxJ0pUdh0D4PKZ7LD1gwxF = __p_UxJ0pUdh0D4PKZ7LD1gwxF;
                    this.__p_IFlXQxud99yLFsivyrOuZW = __p_IFlXQxud99yLFsivyrOuZW;
                    this.__p_Ab53owWvs2XLRoCtaoYeYI = __p_Ab53owWvs2XLRoCtaoYeYI;
                    this.__p_Vd0IyDHTA26LPVpQhrOuUw = __p_Vd0IyDHTA26LPVpQhrOuUw;
                    this.__p_A8U7F4oVDG2PN3BjyUzqzw = __p_A8U7F4oVDG2PN3BjyUzqzw;
                    this.__p_KzwnnnVdOqaNh1cc8rvZvO = __p_KzwnnnVdOqaNh1cc8rvZvO;
                    this.__p_Du565gxutj0QbY2k8ptKl5 = __p_Du565gxutj0QbY2k8ptKl5;
                    this.__pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7 = __pin_group_Parameters_In_DpkjmK0yXSfMaHN9VaFbn7;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 354853U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RwrvWPOOIbQMzEcXRlsmOe", Name = "IFluidComponent_I")]
    public interface IFluidComponent_I : n1.IVLObject
    {
        public n11.IFluidComponent_I GetHelperEntity(out n43.Entity Helper_Entity_Out);
        public n11.IFluidComponent_I GetHelperEnabled(out bool Helper_Enabled_Out);
        public n11.IFluidComponent_I SetContext(n4.FluidContext_C Context_In);
    }

    [n1.ElementAttribute(TracingId = 354953U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ISCZnlTgfIMNL3vE2B7Nop", Name = "IPreTexAdvectComputeGraphProvider_I")]
    public interface IPreTexAdvectComputeGraphProvider_I : n1.IVLObject
    {
        public n11.IPreTexAdvectComputeGraphProvider_I GetPriority(out float Priority_Out);
        public n11.IPreTexAdvectComputeGraphProvider_I Update(out n28.GpuValue<n54.GpuVoid> Graph_Out);
    }

    [n1.ElementAttribute(TracingId = 355035U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LXJQHbc1eJkMTk3h6lKN64", Name = "IPreTexAdvectComputeStageProvider_I")]
    public interface IPreTexAdvectComputeStageProvider_I : n1.IVLObject
    {
        public n11.IPreTexAdvectComputeStageProvider_I GetPriority(out float Priority_Out);
        public n11.IPreTexAdvectComputeStageProvider_I Update(out n33.IGraphicsRendererBase Compute_Stage_Out);
    }

    [n1.ElementAttribute(TracingId = 355098U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Q06AuJxGZCpP864RdYHYR6", Name = "IPostTexAdvectComputeGraphProvider_I")]
    public interface IPostTexAdvectComputeGraphProvider_I : n1.IVLObject
    {
        public n11.IPostTexAdvectComputeGraphProvider_I GetPriority(out float Priority_Out);
        public n11.IPostTexAdvectComputeGraphProvider_I Update(out n28.GpuValue<n54.GpuVoid> Graph_Out);
    }

    [n1.ElementAttribute(TracingId = 355168U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NbmIkTi6hkbNSyzBMD0C8L", Name = "IPostTexAdvectComputeStageProvider_I")]
    public interface IPostTexAdvectComputeStageProvider_I : n1.IVLObject
    {
        public n11.IPostTexAdvectComputeStageProvider_I GetPriority(out float Priority_Out);
        public n11.IPostTexAdvectComputeStageProvider_I Update(out n33.IGraphicsRendererBase Compute_Stage_Out);
    }

    [n1.ElementAttribute(TracingId = 355264U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LONZ6M43cGjLOX194A5ik4", Name = "AugmentedTexture2DVectorField_Fluid3D_C")]
    [n2.SerializableAttribute]
    public class AugmentedTexture2DVectorField_Fluid3D_C : n1.VLObject, n11.IFluidComponent_I, n11.IPostTexAdvectComputeStageProvider_I, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n11.AugmentedTexture2DVectorField_Fluid3D_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new AugmentedTexture2DVectorField_Fluid3D_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.AugmentedTexture2DVectorField_Fluid3D_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new AugmentedTexture2DVectorField_Fluid3D_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.AugmentedTexture2DVectorField_Fluid3D_C Update_(out n33.IGraphicsRendererBase Compute_Stage_Out)
        {
            n27.Texture __auto_0 = this.VectorField_Texture;
            n27.Texture __auto_1 = this.World_Texture;
            bool __auto_2 = this.Enabled;
            n4.FluidContext_C __auto_3 = this.Context;
            n27.Texture __auto_4 = this.World_Texture;
            n28.GpuValue<n27.SamplerState> __auto_5 = this.Sampler;
            n28.GpuValue<float> __auto_6 = this.Level;
            bool __auto_7 = this.Additive;
            n6.Matrix __auto_8 = this.World_Transformation;
            n28.GpuValue<float> __auto_9 = this.Threshold;
            n27.Texture __auto_10 = this.VectorField_Texture;
            n6.Vector2 __auto_11 = this.Texture_Resolution;
            bool __auto_12 = this.Flip_X;
            int __auto_13 = this.X_Resolution;
            int __auto_14 = this.Y_Resolution;
            int __pad_QXGuHtWE9tPQUDdUOHQCxf_15 = __slot_QXGuHtWE9tPQUDdUOHQCxf;
            float __auto_16 = this.Strength;
            bool Force_17 = false;
            bool Dispose_Cached_Outputs_18 = false;
            var manager_19 = this.__cache_UAWDxcbxBYNOzxkgjDN0Le;
            if (manager_19 is null)
            {
                manager_19 = new n13.Manager<n2.ValueTuple<int, int>, n2.ValueTuple<n32.IComputeEffectDispatcher, n6.Int3>>((default(n32.IComputeEffectDispatcher), default(n6.Int3)));
            }

            var inputs_20 = (__auto_13, __auto_14);
            var outputs_21 = manager_19.Outputs;
            var Has_Changed_22 = Force_17 || manager_19.InputsChanged(inputs_20);
            if (Has_Changed_22)
            {
                if (Dispose_Cached_Outputs_18)
                    manager_19.DisposeOutputs();
                var state_23 = n1.CompilationHelper.Restore<__EcejEp9Irj4OzVKq7M6f8r>(manager_19.State, __GetContext__());
                if (state_23 == null)
                {
                    state_23 = new __EcejEp9Irj4OzVKq7M6f8r(__GetContext__(), n1.VLObject.NewIdentity())
                    {__slot_LOBOhPNpCzDOtDAao2Q0cK = default(n6.Int3)};
                    var node_24 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "DirectDispatcher", "Stride.Rendering.Advanced");
                    state_23.__p_Muhpax2oZ9bLYlU9YqNMmV = node_24;
                }

                int __pad_MA0ysUvySljLKsUO5XlIU7_25 = __slot_MA0ysUvySljLKsUO5XlIU7;
                n81._Operations_.DIVCeilValue(Input_In: __auto_13, Div_In: __pad_MA0ysUvySljLKsUO5XlIU7_25, Output_Out: out int Output_26);
                n81._Operations_.DIVCeilValue(Input_In: __auto_14, Div_In: __pad_MA0ysUvySljLKsUO5XlIU7_25, Output_Out: out int Output_27);
                int Z_28 = 1;
                var Output_29 = new n6.Int3(x: Output_26, y: Output_27, z: Z_28);
                n1.CompilationHelper.WritePin(state_23.__p_Muhpax2oZ9bLYlU9YqNMmV.Inputs[0], ref Output_29);
                n1.CompilationHelper.ReadPin(state_23.__p_Muhpax2oZ9bLYlU9YqNMmV.Outputs[0], out n32.IComputeEffectDispatcher out_30);
                int Z_31 = 1;
                var Output_32 = new n6.Int3(x: __pad_MA0ysUvySljLKsUO5XlIU7_25, y: __pad_MA0ysUvySljLKsUO5XlIU7_25, z: Z_31);
                n6.Int3 __pad_LOBOhPNpCzDOtDAao2Q0cK_33 = Output_32;
                state_23.__p_Muhpax2oZ9bLYlU9YqNMmV = state_23.__p_Muhpax2oZ9bLYlU9YqNMmV;
                state_23.__slot_LOBOhPNpCzDOtDAao2Q0cK = Output_32;
                outputs_21 = (out_30, __pad_LOBOhPNpCzDOtDAao2Q0cK_33);
                manager_19 = manager_19.Update(inputs_20, __GetContext__().IsImmutable, Dispose_Cached_Outputs_18, state_23, outputs_21);
            }
            else
            {
                manager_19.Update(inputs_20, __GetContext__().IsImmutable, Dispose_Cached_Outputs_18);
            }

            var(__auto_34, __auto_35) = outputs_21;
            this.__cache_UAWDxcbxBYNOzxkgjDN0Le = manager_19;
            var State_Output_37 = this.__p_V5t6mr40Q5yNH3WpEdNHaB.Update(Output_Out: out n28.GpuValue<float> Output_36);
            this.__p_V5t6mr40Q5yNH3WpEdNHaB = State_Output_37;
            bool Force_38 = false;
            bool Dispose_Cached_Outputs_39 = false;
            var manager_40 = this.__cache_RVDYVY9EfcbLWYutkZ5IGH;
            if (manager_40 is null)
            {
                manager_40 = new n13.Manager<n2.ValueTuple<n27.Texture, n27.Texture, bool, n4.FluidContext_C, n27.Texture, n28.GpuValue<n27.SamplerState>, n28.GpuValue<float>, n2.ValueTuple<bool, n6.Matrix, n28.GpuValue<float>, n27.Texture, n6.Vector2, bool>>, n2.ValueTuple<n28.GpuValue<n54.GpuVoid>>>(n2.ValueTuple.Create(default(n28.GpuValue<n54.GpuVoid>)));
            }

            var inputs_41 = (__auto_0, __auto_1, __auto_2, __auto_3, __auto_4, __auto_5, __auto_6, __auto_7, __auto_8, __auto_9, __auto_10, __auto_11, __auto_12);
            var outputs_42 = manager_40.Outputs;
            var Has_Changed_43 = Force_38 || manager_40.InputsChanged(inputs_41);
            if (Has_Changed_43)
            {
                if (Dispose_Cached_Outputs_39)
                    manager_40.DisposeOutputs();
                var state_44 = n1.CompilationHelper.Restore<__C9mAwGBsbceMDNVros5sDA>(manager_40.State, __GetContext__());
                if (state_44 == null)
                {
                    state_44 = new __C9mAwGBsbceMDNVros5sDA(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n = n14._Operations_.CreateDefault<n28.GpuValue<bool>>(), __pin_group_Input_In_S60yboHKYMdMudOyJzgqY0 = n14._Operations_.CreateDefault<n28.GpuValue<n6.Vector2>>(), __slot_CoImXpPEcBiPLNDjlnzUaU = default(n28.GpuValue<n6.Vector2>), __pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J = n14._Operations_.CreateDefault<n28.GpuValue<n6.Vector3>>(), __pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ = n14._Operations_.CreateDefault<n28.GpuValue<n6.Vector3>>(), __pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf = n14._Operations_.CreateDefault<n28.GpuValue<float>>()};
                    n1.NodeContext Node_Context_45 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "NlR9zBPt78lQdHZlzJXgIt", 355511U);
                    var Output_46 = n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, float>.Create(Node_Context: Node_Context_45);
                    state_44.__p_NlR9zBPt78lQdHZlzJXgIt = Output_46;
                    n1.NodeContext Node_Context_47 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "B4sahqLbnHcORFaoiwoF13", 355538U);
                    var Output_48 = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_47);
                    state_44.__p_B4sahqLbnHcORFaoiwoF13 = Output_48;
                    n1.NodeContext Node_Context_49 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "OEQyaPLeoFPNLI9Qsy9ugc", 355553U);
                    var Output_50 = n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float>.Create(Node_Context: Node_Context_49);
                    state_44.__p_OEQyaPLeoFPNLI9Qsy9ugc = Output_50;
                    n1.NodeContext Node_Context_51 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "DCJ7ygOPcm0N1b0eWbOoab", 355565U);
                    var Output_52 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_51);
                    state_44.__p_DCJ7ygOPcm0N1b0eWbOoab = Output_52;
                    n1.NodeContext Node_Context_53 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "EXf0M02nN3ZOebwIjZiW6n", 355591U);
                    var Output_54 = n59.AND_TkWZzQWwZ0tLZt6ooZGazh.Create(Node_Context: Node_Context_53);
                    state_44.__p_EXf0M02nN3ZOebwIjZiW6n = Output_54;
                    n1.NodeContext Node_Context_55 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "U9123t5EgJCNabvmwRdz6g", 355610U);
                    var Output_56 = n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, n6.Vector4>.Create(Node_Context: Node_Context_55);
                    state_44.__p_U9123t5EgJCNabvmwRdz6g = Output_56;
                    n1.NodeContext Node_Context_57 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "EPjJp86lllMMMxfs8V3Brf", 355625U);
                    var Output_58 = n75.Length_P0UB6WKESd0PjWRm8eD1d4<n6.Vector3>.Create(Node_Context: Node_Context_57);
                    state_44.__p_EPjJp86lllMMMxfs8V3Brf = Output_58;
                    n1.NodeContext Node_Context_59 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Qe6BRlJgbdqOgZ0L1zLs2q", 355637U);
                    var Output_60 = n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float>.Create(Node_Context: Node_Context_59);
                    state_44.__p_Qe6BRlJgbdqOgZ0L1zLs2q = Output_60;
                    n1.NodeContext Node_Context_61 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "J5xamYbncw4Nz3vJJCHdMa", 356583U);
                    var Output_62 = n76.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_61);
                    state_44.__p_J5xamYbncw4Nz3vJJCHdMa = Output_62;
                    n1.NodeContext Node_Context_63 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "QBfAM7LFIlEQKjKvLZivkC", 356604U);
                    var Output_64 = n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, n6.Vector4>.Create(Node_Context: Node_Context_63);
                    state_44.__p_QBfAM7LFIlEQKjKvLZivkC = Output_64;
                    n1.NodeContext Node_Context_65 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Lh28ioPoApjMEeDpBRf89D", 356627U);
                    var Output_66 = n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector3>.Create(Node_Context: Node_Context_65);
                    state_44.__p_Lh28ioPoApjMEeDpBRf89D = Output_66;
                    n1.NodeContext Node_Context_67 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "SlgnLIwHScwLkPTYSxhGdJ", 356646U);
                    var Output_68 = n75.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n6.Vector3>.Create(Node_Context: Node_Context_67);
                    state_44.__p_SlgnLIwHScwLkPTYSxhGdJ = Output_68;
                    n1.NodeContext Node_Context_69 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Vk6I19HMkMZMQrAcvK79VF", 356667U);
                    var Output_70 = n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_69);
                    state_44.__p_Vk6I19HMkMZMQrAcvK79VF = Output_70;
                    n1.NodeContext Node_Context_71 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "VGYpJekRixkMkICjCiR22a", 356687U);
                    var Output_72 = n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector4>.Create(Node_Context: Node_Context_71);
                    state_44.__p_VGYpJekRixkMkICjCiR22a = Output_72;
                    n1.NodeContext Node_Context_73 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "G0gzyyus8Q5PcmuUjOIR4R", 356703U);
                    var Output_74 = n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n54.GpuVoid>.Create(Node_Context: Node_Context_73);
                    state_44.__p_G0gzyyus8Q5PcmuUjOIR4R = Output_74;
                    n1.NodeContext Node_Context_75 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "GjoP8uR2na9LVa0T0vslcR", 356789U);
                    var Output_76 = n72.PositionToVolumeCellCoord_HItUPv4kH5jOKmuxJkiY5B.Create(Node_Context: Node_Context_75);
                    state_44.__p_GjoP8uR2na9LVa0T0vslcR = Output_76;
                    n1.NodeContext Node_Context_77 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "KkjuVnbuKzjQbt6PjsgNv1", 356810U);
                    var Output_78 = n62.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n6.Vector2>.Create(Node_Context: Node_Context_77);
                    state_44.__p_KkjuVnbuKzjQbt6PjsgNv1 = Output_78;
                    n1.NodeContext Node_Context_79 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "MRsP3ujFKbLLeNBfiB4DnB", 356831U);
                    var Output_80 = n76.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_79);
                    state_44.__p_MRsP3ujFKbLLeNBfiB4DnB = Output_80;
                    n1.NodeContext Node_Context_81 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "EWKGBvR711IOm1itym0Ryv", 356847U);
                    var Output_82 = n62.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n6.Vector2>.Create(Node_Context: Node_Context_81);
                    state_44.__p_EWKGBvR711IOm1itym0Ryv = Output_82;
                    n1.NodeContext Node_Context_83 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "ASxvz3suRV7O2KjvOP8o5A", 356864U);
                    var Output_84 = n76.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_83);
                    state_44.__p_ASxvz3suRV7O2KjvOP8o5A = Output_84;
                    n1.NodeContext Node_Context_85 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "SMIyUHVq5JaNQbhadshKIs", 356885U);
                    var Output_86 = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_85);
                    state_44.__p_SMIyUHVq5JaNQbhadshKIs = Output_86;
                    n1.NodeContext Node_Context_87 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "S60yboHKYMdMudOyJzgqY0", 356898U);
                    var Output_88 = n75.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n6.Vector2>.Create(Node_Context: Node_Context_87);
                    state_44.__p_S60yboHKYMdMudOyJzgqY0 = Output_88;
                    n1.NodeContext Node_Context_89 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "F5O6rgf6OqHP9AsRJyGPGi", 356919U);
                    var Output_90 = n82.To_Qgkn15Kxt1HLURmAdSAN7m<n6.Vector2, n6.Vector2>.Create(Node_Context: Node_Context_89);
                    state_44.__p_F5O6rgf6OqHP9AsRJyGPGi = Output_90;
                    n1.NodeContext Node_Context_91 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Uq8tAa9olcXQQdO8ImqcwD", 356937U);
                    var Output_92 = n76.xy_EiegIBeM6c8OnN5CcRLRyU<n6.Int3>.Create(Node_Context: Node_Context_91);
                    state_44.__p_Uq8tAa9olcXQQdO8ImqcwD = Output_92;
                    n1.NodeContext Node_Context_93 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "MdL6aDqoplyLUCZ2bYhrDZ", 356953U);
                    var Output_94 = n82.To_Qgkn15Kxt1HLURmAdSAN7m<n6.Vector2, n6.Vector2>.Create(Node_Context: Node_Context_93);
                    state_44.__p_MdL6aDqoplyLUCZ2bYhrDZ = Output_94;
                    n1.NodeContext Node_Context_95 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "MCtdPtr9MjuPt42vKzsmfk", 356978U);
                    var Output_96 = n75.Mul_B0P7ghpqXJiLy15iE7sIid<n6.Vector4, n6.Matrix, n6.Vector4>.Create(Node_Context: Node_Context_95);
                    state_44.__p_MCtdPtr9MjuPt42vKzsmfk = Output_96;
                    n1.NodeContext Node_Context_97 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Or4mozdOD62MZnFtwwGali", 357005U);
                    var Output_98 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_97);
                    state_44.__p_Or4mozdOD62MZnFtwwGali = Output_98;
                    n1.NodeContext Node_Context_99 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Gpl9GZ5CGHiOfJy8Qbq68J", 357044U);
                    var Output_100 = n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_99);
                    state_44.__p_Gpl9GZ5CGHiOfJy8Qbq68J = Output_100;
                    n1.NodeContext Node_Context_101 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "BrcrG3zSybxObQmQ2n9FYs", 357075U);
                    var Output_102 = n57.GPUIn_C<n6.Matrix>.Create(Node_Context: Node_Context_101);
                    state_44.__p_BrcrG3zSybxObQmQ2n9FYs = Output_102;
                    n1.NodeContext Node_Context_103 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "VsTjyIPH8K4Odcau0Lnggg", 357094U);
                    var Output_104 = n76.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_103);
                    state_44.__p_VsTjyIPH8K4Odcau0Lnggg = Output_104;
                    n1.NodeContext Node_Context_105 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "F2kzjm0knY1LaZ3X5rA2i3", 357733U);
                    var Output_106 = n75.Mul_B0P7ghpqXJiLy15iE7sIid<n6.Vector4, n6.Matrix, n6.Vector3>.Create(Node_Context: Node_Context_105);
                    state_44.__p_F2kzjm0knY1LaZ3X5rA2i3 = Output_106;
                    n1.NodeContext Node_Context_107 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "TMQtR7fQRuTPrAnWVfo1ug", 357751U);
                    var Output_108 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_107);
                    state_44.__p_TMQtR7fQRuTPrAnWVfo1ug = Output_108;
                    n1.NodeContext Node_Context_109 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Mf1I9F0Gl1qNDq4Fgs9mje", 357768U);
                    var Output_110 = n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_109);
                    state_44.__p_Mf1I9F0Gl1qNDq4Fgs9mje = Output_110;
                    n1.NodeContext Node_Context_111 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "OCMH1YHplwnQOs2c1Peuvx", 357786U);
                    var Output_112 = n57.GPUIn_C<n6.Matrix>.Create(Node_Context: Node_Context_111);
                    state_44.__p_OCMH1YHplwnQOs2c1Peuvx = Output_112;
                    n1.NodeContext Node_Context_113 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "RgPPsUAfRIFLueFHYGmG4J", 357799U);
                    var Output_114 = n75.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n6.Vector3>.Create(Node_Context: Node_Context_113);
                    state_44.__p_RgPPsUAfRIFLueFHYGmG4J = Output_114;
                    n1.NodeContext Node_Context_115 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "QdG3xLb1SfQLd63exGRrnb", 357818U);
                    var Output_116 = n82.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<n6.Vector3>.Create(Node_Context: Node_Context_115);
                    state_44.__p_QdG3xLb1SfQLd63exGRrnb = Output_116;
                    n1.NodeContext Node_Context_117 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Kmge7kpo6cPPL16ywaBWa7", 357833U);
                    var Output_118 = n79.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float>.Create(Node_Context: Node_Context_117);
                    state_44.__p_Kmge7kpo6cPPL16ywaBWa7 = Output_118;
                    n1.NodeContext Node_Context_119 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "IrdLHflPjOhK98vlxajKrE", 357874U);
                    var Output_120 = n83.xMyz_split_AJovkBTfOKGNHniZzmUeC0.Create(Node_Context: Node_Context_119);
                    state_44.__p_IrdLHflPjOhK98vlxajKrE = Output_120;
                    n1.NodeContext Node_Context_121 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "FZFZaMga7C0MHSY2momT7T", 357888U);
                    var Output_122 = n77.xPyz_join_TfjUbK4F10LQJgxHoD2Rkv.Create(Node_Context: Node_Context_121);
                    state_44.__p_FZFZaMga7C0MHSY2momT7T = Output_122;
                    n1.NodeContext Node_Context_123 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "EObAHtzUwYDN4QQ1pwnKGm", 357914U);
                    var Output_124 = n75.Negate_P5nGfBLszbBL1YRjqmyYHC<float>.Create(Node_Context: Node_Context_123);
                    state_44.__p_EObAHtzUwYDN4QQ1pwnKGm = Output_124;
                    n1.NodeContext Node_Context_125 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "JkJjwhrlRt4MnIeRBF64VP", 357963U);
                    var Output_126 = n83.xMyz_split_AJovkBTfOKGNHniZzmUeC0.Create(Node_Context: Node_Context_125);
                    state_44.__p_JkJjwhrlRt4MnIeRBF64VP = Output_126;
                    n1.NodeContext Node_Context_127 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Txg022TJAfkQXeshliMXZ5", 357978U);
                    var Output_128 = n77.xPyz_join_TfjUbK4F10LQJgxHoD2Rkv.Create(Node_Context: Node_Context_127);
                    state_44.__p_Txg022TJAfkQXeshliMXZ5 = Output_128;
                    n1.NodeContext Node_Context_129 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "A5YUKxwLfwpLqlzzjjHzHx", 357987U);
                    var Output_130 = n75.Negate_P5nGfBLszbBL1YRjqmyYHC<float>.Create(Node_Context: Node_Context_129);
                    state_44.__p_A5YUKxwLfwpLqlzzjjHzHx = Output_130;
                    n1.NodeContext Node_Context_131 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "RzfrLKpqe8NN1rRC8gF1Mf", 357997U);
                    var Output_132 = n75.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float>.Create(Node_Context: Node_Context_131);
                    state_44.__p_RzfrLKpqe8NN1rRC8gF1Mf = Output_132;
                    n1.NodeContext Node_Context_133 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "BG2VoIHhrfyOPgDiP89lnu", 358009U);
                    var Output_134 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_133);
                    state_44.__p_BG2VoIHhrfyOPgDiP89lnu = Output_134;
                }

                float __pad_GTMawVtcHLsNFIGcnDqdB8_135 = __slot_GTMawVtcHLsNFIGcnDqdB8;
                float __pad_JIW5dd3P4NvOvhsLz8r3C9_136 = __slot_JIW5dd3P4NvOvhsLz8r3C9;
                float __pad_UoxvIs43Th1LDr5N3Myx7P_137 = __slot_UoxvIs43Th1LDr5N3Myx7P;
                float __pad_GsFr4NPbxGUP1sNdGfSTD5_138 = __slot_GsFr4NPbxGUP1sNdGfSTD5;
                string __pad_AQyUld7UGGPQLhWAAmxpHW_139 = __slot_AQyUld7UGGPQLhWAAmxpHW;
                string __pad_Sn71uwDEkTQORA7tHwiIci_140 = __slot_Sn71uwDEkTQORA7tHwiIci;
                float __pad_AmUJIFEdj8CM9eAno0MjPc_141 = __slot_AmUJIFEdj8CM9eAno0MjPc;
                n15.ObjectHelpers.IsAssigned(x: __auto_0, result: out bool Result_142, notAssigned: out bool Not_Assigned_143);
                n28.GpuValue<bool> Values_144 = state_44.__monadBuilder_R1rAY6Goo41OQzfrET27Zh.Return(Result_142);
                n15.ObjectHelpers.IsAssigned(x: __auto_1, result: out bool Result_145, notAssigned: out bool Not_Assigned_146);
                n28.GpuValue<bool> Values_2_147 = state_44.__monadBuilder_BnuBSRDzsQ7QIMBzKCIRVn.Return(Result_145);
                n28.GpuValue<bool> Values_3_148 = state_44.__monadBuilder_Hx9OgGroD8CP35UMHfk3tH.Return(__auto_2);
                var Output_154 = __auto_3.GetTextureWithName(Texture_Name_In: __pad_Sn71uwDEkTQORA7tHwiIci_140, Texture_Read_Out: out n27.Texture Texture_Read_149, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_150, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_151, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_152, Found_Out: out bool Found_153);
                var State_Output_156 = state_44.__p_B4sahqLbnHcORFaoiwoF13.GetOutput(Output_Out: out n28.GpuValue<n6.Int3> Output_155);
                n28.GpuValue<float> default_157 = default(n28.GpuValue<float>);
                var State_Output_159 = state_44.__p_NlR9zBPt78lQdHZlzJXgIt.Update(Texture_In: Texture_Read_Graph_150, index_In: Output_155, default_In: default_157, Output_Out: out n28.GpuValue<float> Output_158);
                var Output_161 = state_44.__p_DCJ7ygOPcm0N1b0eWbOoab.Update(Value_In: __pad_AmUJIFEdj8CM9eAno0MjPc_141, GpuValue_Out: out n28.GpuValue<float> GpuValue_160);
                var Output_163 = state_44.__p_OEQyaPLeoFPNLI9Qsy9ugc.Update(x_In: Output_158, y_In: GpuValue_160, value_Out: out n28.GpuValue<bool> value_162);
                var builder_164 = n5.CollectionBuilders.GetBuilder(state_44.__pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n, 4);
                builder_164.Add(Values_144);
                builder_164.Add(Values_2_147);
                builder_164.Add(Values_3_148);
                builder_164.Add(value_162);
                var __pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n_165 = builder_164.Commit();
                var State_Output_167 = state_44.__p_EXf0M02nN3ZOebwIjZiW6n.Update(Values_In: __pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n_165, Output_Out: out n28.GpuValue<bool> Output_166);
                var Output_170 = __auto_3.GetTransform(Transform_Out: out n6.Matrix Transform_168, Transform_Inverse_Out: out n6.Matrix Transform_Inverse_169);
                var Output_172 = Output_170.GetResolution(Resolution_Out: out n6.Int3 Resolution_171);
                n28.GpuValue<n27.Texture> Texture_173 = state_44.__monadBuilder_ITALcgI0eOQQFbYNaPaL2l.Return(__auto_4);
                var State_Output_175 = state_44.__p_SMIyUHVq5JaNQbhadshKIs.GetOutput(Output_Out: out n28.GpuValue<n6.Int3> Output_174);
                var State_Output_177 = state_44.__p_Uq8tAa9olcXQQdO8ImqcwD.Update(Input_In: Output_174, Output_Out: out n28.GpuValue<n6.Vector2> Output_176);
                n28.GpuValue<n6.Vector2> default_178 = default(n28.GpuValue<n6.Vector2>);
                var State_Output_180 = state_44.__p_F5O6rgf6OqHP9AsRJyGPGi.Update(x_In: Output_176, default_In: default_178, Output_Out: out n28.GpuValue<n6.Vector2> Output_179);
                n28.GpuValue<n6.Vector2> x_181 = state_44.__monadBuilder_C6gi0LD9PAjNdXIptcrj8P.Return(__auto_11);
                n28.GpuValue<n6.Vector2> default_182 = default(n28.GpuValue<n6.Vector2>);
                var State_Output_184 = state_44.__p_MdL6aDqoplyLUCZ2bYhrDZ.Update(x_In: x_181, default_In: default_182, Output_Out: out n28.GpuValue<n6.Vector2> Output_183);
                var builder_185 = n5.CollectionBuilders.GetBuilder(state_44.__pin_group_Input_In_S60yboHKYMdMudOyJzgqY0, 2);
                builder_185.Add(Output_179);
                builder_185.Add(Output_183);
                var __pin_group_Input_In_S60yboHKYMdMudOyJzgqY0_186 = builder_185.Commit();
                var State_Output_188 = state_44.__p_S60yboHKYMdMudOyJzgqY0.Update(Input_In: __pin_group_Input_In_S60yboHKYMdMudOyJzgqY0_186, Output_Out: out n28.GpuValue<n6.Vector2> Output_187);
                n28.GpuValue<n6.Vector2> __pad_CoImXpPEcBiPLNDjlnzUaU_189 = Output_187;
                n28.GpuValue<n6.Vector4> Default_190 = default(n28.GpuValue<n6.Vector4>);
                var State_Output_192 = state_44.__p_KkjuVnbuKzjQbt6PjsgNv1.Update(Texture_In: Texture_173, Sampler_In: __auto_5, Texture_Coords_In: __pad_CoImXpPEcBiPLNDjlnzUaU_189, Level_In: __auto_6, Default_In: Default_190, Output_Out: out n28.GpuValue<n6.Vector4> Output_191);
                var State_Output_194 = state_44.__p_MRsP3ujFKbLLeNBfiB4DnB.Update(Input_In: Output_191, Output_Out: out n28.GpuValue<n6.Vector3> Output_193);
                var Output_197 = state_44.__p_JkJjwhrlRt4MnIeRBF64VP.Update(value_In: Output_193, x_Out: out n28.GpuValue<float> x_195, yz_Out: out n28.GpuValue<n6.Vector2> yz_196);
                var State_Output_199 = state_44.__p_A5YUKxwLfwpLqlzzjjHzHx.Update(Input_In: x_195, Output_Out: out n28.GpuValue<float> Output_198);
                var State_Output_201 = state_44.__p_Txg022TJAfkQXeshliMXZ5.Update(x_In: Output_198, yz_In: yz_196, Output_Out: out n28.GpuValue<n6.Vector3> Output_200);
                n39._Operations_.Switch_Boolean<n28.GpuValue<n6.Vector3>>(Condition_In: __auto_12, Input_In: Output_193, Input_2_In: Output_200, Output_Out: out n28.GpuValue<n6.Vector3> Output_202);
                var Output_204 = state_44.__p_Or4mozdOD62MZnFtwwGali.Update(Value_In: __pad_GTMawVtcHLsNFIGcnDqdB8_135, GpuValue_Out: out n28.GpuValue<float> GpuValue_203);
                var State_Output_206 = state_44.__p_Gpl9GZ5CGHiOfJy8Qbq68J.Update(xyz_In: Output_202, w_In: GpuValue_203, Output_Out: out n28.GpuValue<n6.Vector4> Output_205);
                var State_Output_208 = state_44.__p_BrcrG3zSybxObQmQ2n9FYs.Update(Output_Out: out n28.GpuValue<n6.Matrix> Output_207);
                var State_Output_210 = state_44.__p_MCtdPtr9MjuPt42vKzsmfk.Update(Input1_In: Output_205, Input2_In: Output_207, Output_Out: out n28.GpuValue<n6.Vector4> Output_209);
                var State_Output_212 = state_44.__p_VsTjyIPH8K4Odcau0Lnggg.Update(Input_In: Output_209, Output_Out: out n28.GpuValue<n6.Vector3> Output_211);
                var State_Output_215 = state_44.__p_GjoP8uR2na9LVa0T0vslcR.Update(Position_In: Output_211, Volume_Transform_In: Transform_168, Grid_Resolution_In: Resolution_171, Output_Out: out n28.GpuValue<n6.Int3> Output_213, Volume_Space_Position_Out: out n28.GpuValue<n6.Vector3> Volume_Space_Position_214);
                n28.GpuValue<n27.Texture> Texture_216 = state_44.__monadBuilder_HZ7FLxXj55kO0bZR8BoN80.Return(__auto_10);
                n28.GpuValue<n6.Vector4> Default_217 = default(n28.GpuValue<n6.Vector4>);
                var State_Output_219 = state_44.__p_EWKGBvR711IOm1itym0Ryv.Update(Texture_In: Texture_216, Sampler_In: __auto_5, Texture_Coords_In: __pad_CoImXpPEcBiPLNDjlnzUaU_189, Level_In: __auto_6, Default_In: Default_217, Output_Out: out n28.GpuValue<n6.Vector4> Output_218);
                var State_Output_221 = state_44.__p_ASxvz3suRV7O2KjvOP8o5A.Update(Input_In: Output_218, Output_Out: out n28.GpuValue<n6.Vector3> Output_220);
                var Output_224 = state_44.__p_IrdLHflPjOhK98vlxajKrE.Update(value_In: Output_220, x_Out: out n28.GpuValue<float> x_222, yz_Out: out n28.GpuValue<n6.Vector2> yz_223);
                var State_Output_226 = state_44.__p_EObAHtzUwYDN4QQ1pwnKGm.Update(Input_In: x_222, Output_Out: out n28.GpuValue<float> Output_225);
                var State_Output_228 = state_44.__p_FZFZaMga7C0MHSY2momT7T.Update(x_In: Output_225, yz_In: yz_223, Output_Out: out n28.GpuValue<n6.Vector3> Output_227);
                n39._Operations_.Switch_Boolean<n28.GpuValue<n6.Vector3>>(Condition_In: __auto_12, Input_In: Output_220, Input_2_In: Output_227, Output_Out: out n28.GpuValue<n6.Vector3> Output_229);
                var Output_231 = state_44.__p_TMQtR7fQRuTPrAnWVfo1ug.Update(Value_In: __pad_JIW5dd3P4NvOvhsLz8r3C9_136, GpuValue_Out: out n28.GpuValue<float> GpuValue_230);
                var State_Output_233 = state_44.__p_Mf1I9F0Gl1qNDq4Fgs9mje.Update(xyz_In: Output_229, w_In: GpuValue_230, Output_Out: out n28.GpuValue<n6.Vector4> Output_232);
                var State_Output_235 = state_44.__p_OCMH1YHplwnQOs2c1Peuvx.Update(Output_Out: out n28.GpuValue<n6.Matrix> Output_234);
                var State_Output_237 = state_44.__p_F2kzjm0knY1LaZ3X5rA2i3.Update(Input1_In: Output_232, Input2_In: Output_234, Output_Out: out n28.GpuValue<n6.Vector3> Output_236);
                var Result_241 = __auto_8.Decompose(scale: out n6.Vector3 Scale_238, rotation: out n6.Quaternion Rotation_239, translation: out n6.Vector3 Translation_240);
                n6.Matrix Input_242 = n9._Operations_.CreateDefault();
                n10._Operations_.Rotate_Quaternion(Input_In: Input_242, Rotation_In: Rotation_239, Output_Out: out n6.Matrix Output_243);
                bool SetValue_244 = true;
                var Output_245 = State_Output_235;
                if (SetValue_244)
                {
                    Output_245 = State_Output_235.SetValue(Input_In: Output_243);
                }

                var State_Output_247 = state_44.__p_QdG3xLb1SfQLd63exGRrnb.Update(value_In: Output_36, Output_Out: out n28.GpuValue<n6.Vector3> Output_246);
                var builder_248 = n5.CollectionBuilders.GetBuilder(state_44.__pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J, 2);
                builder_248.Add(Output_236);
                builder_248.Add(Output_246);
                var __pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J_249 = builder_248.Commit();
                var State_Output_251 = state_44.__p_RgPPsUAfRIFLueFHYGmG4J.Update(Input_In: __pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J_249, Output_Out: out n28.GpuValue<n6.Vector3> Output_250);
                var Output_257 = __auto_3.GetTextureWithName(Texture_Name_In: __pad_AQyUld7UGGPQLhWAAmxpHW_139, Texture_Read_Out: out n27.Texture Texture_Read_252, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_253, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_254, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_255, Found_Out: out bool Found_256);
                n28.GpuValue<n6.Vector4> default_258 = default(n28.GpuValue<n6.Vector4>);
                var State_Output_260 = state_44.__p_QBfAM7LFIlEQKjKvLZivkC.Update(Texture_In: Texture_Read_Graph_253, index_In: Output_213, default_In: default_258, Output_Out: out n28.GpuValue<n6.Vector4> Output_259);
                var State_Output_262 = state_44.__p_J5xamYbncw4Nz3vJJCHdMa.Update(Input_In: Output_259, Output_Out: out n28.GpuValue<n6.Vector3> Output_261);
                var builder_263 = n5.CollectionBuilders.GetBuilder(state_44.__pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ, 2);
                builder_263.Add(Output_261);
                builder_263.Add(Output_250);
                var __pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ_264 = builder_263.Commit();
                var State_Output_266 = state_44.__p_SlgnLIwHScwLkPTYSxhGdJ.Update(Input_In: __pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ_264, Output_Out: out n28.GpuValue<n6.Vector3> Output_265);
                var State_Output_268 = state_44.__p_EPjJp86lllMMMxfs8V3Brf.Update(Input_In: Output_250, Output_Out: out n28.GpuValue<float> Output_267);
                var State_Output_270 = state_44.__p_Kmge7kpo6cPPL16ywaBWa7.Update(GpuValue_In: __auto_9, The_Value_In: __pad_UoxvIs43Th1LDr5N3Myx7P_137, Output_Out: out n28.GpuValue<float> Output_269);
                var builder_271 = n5.CollectionBuilders.GetBuilder(state_44.__pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf, 2);
                builder_271.Add(Output_267);
                builder_271.Add(Output_269);
                var __pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf_272 = builder_271.Commit();
                var State_Output_274 = state_44.__p_RzfrLKpqe8NN1rRC8gF1Mf.Update(Input_In: __pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf_272, Output_Out: out n28.GpuValue<float> Output_273);
                var Output_276 = state_44.__p_BG2VoIHhrfyOPgDiP89lnu.Update(Value_In: __pad_GsFr4NPbxGUP1sNdGfSTD5_138, GpuValue_Out: out n28.GpuValue<float> GpuValue_275);
                var Output_278 = state_44.__p_Qe6BRlJgbdqOgZ0L1zLs2q.Update(x_In: Output_273, y_In: GpuValue_275, value_Out: out n28.GpuValue<bool> value_277);
                n28.GpuValue<n6.Vector3> The_Default_279 = default(n28.GpuValue<n6.Vector3>);
                var State_Output_281 = state_44.__p_Lh28ioPoApjMEeDpBRf89D.Update(In_Check_In: value_277, In_False_In: Output_261, In_True_In: Output_250, The_Default_In: The_Default_279, Output_Out: out n28.GpuValue<n6.Vector3> Output_280);
                n39._Operations_.Switch_Boolean<n28.GpuValue<n6.Vector3>>(Condition_In: __auto_7, Input_In: Output_280, Input_2_In: Output_265, Output_Out: out n28.GpuValue<n6.Vector3> Output_282);
                n28.GpuValue<float> w_283 = default(n28.GpuValue<float>);
                var State_Output_285 = state_44.__p_Vk6I19HMkMZMQrAcvK79VF.Update(xyz_In: Output_282, w_In: w_283, Output_Out: out n28.GpuValue<n6.Vector4> Output_284);
                n28.GpuValue<n6.Vector4> The_Default_286 = default(n28.GpuValue<n6.Vector4>);
                var State_Output_288 = state_44.__p_VGYpJekRixkMkICjCiR22a.Update(In_Check_In: Output_166, In_False_In: Output_259, In_True_In: Output_284, The_Default_In: The_Default_286, Output_Out: out n28.GpuValue<n6.Vector4> Output_287);
                var State_Output_290 = state_44.__p_U9123t5EgJCNabvmwRdz6g.Update(Texture_In: Texture_ReadWrite_Graph_255, index_In: Output_213, value_In: Output_287, Output_Out: out n28.GpuValue<n54.GpuVoid> Output_289);
                n28.GpuValue<n54.GpuVoid> In_False_291 = default(n28.GpuValue<n54.GpuVoid>);
                n28.GpuValue<n54.GpuVoid> The_Default_292 = default(n28.GpuValue<n54.GpuVoid>);
                var State_Output_294 = state_44.__p_G0gzyyus8Q5PcmuUjOIR4R.Update(In_Check_In: Output_166, In_False_In: In_False_291, In_True_In: Output_289, The_Default_In: The_Default_292, Output_Out: out n28.GpuValue<n54.GpuVoid> Output_293);
                bool SetValue_295 = true;
                var Output_296 = State_Output_208;
                if (SetValue_295)
                {
                    Output_296 = State_Output_208.SetValue(Input_In: __auto_8);
                }

                state_44.__p_B4sahqLbnHcORFaoiwoF13 = State_Output_156;
                state_44.__p_NlR9zBPt78lQdHZlzJXgIt = State_Output_159;
                state_44.__p_DCJ7ygOPcm0N1b0eWbOoab = Output_161;
                state_44.__p_OEQyaPLeoFPNLI9Qsy9ugc = Output_163;
                state_44.__pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n = __pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n_165;
                state_44.__p_EXf0M02nN3ZOebwIjZiW6n = State_Output_167;
                state_44.__p_SMIyUHVq5JaNQbhadshKIs = State_Output_175;
                state_44.__p_Uq8tAa9olcXQQdO8ImqcwD = State_Output_177;
                state_44.__p_F5O6rgf6OqHP9AsRJyGPGi = State_Output_180;
                state_44.__p_MdL6aDqoplyLUCZ2bYhrDZ = State_Output_184;
                state_44.__pin_group_Input_In_S60yboHKYMdMudOyJzgqY0 = __pin_group_Input_In_S60yboHKYMdMudOyJzgqY0_186;
                state_44.__p_S60yboHKYMdMudOyJzgqY0 = State_Output_188;
                state_44.__slot_CoImXpPEcBiPLNDjlnzUaU = Output_187;
                state_44.__p_KkjuVnbuKzjQbt6PjsgNv1 = State_Output_192;
                state_44.__p_MRsP3ujFKbLLeNBfiB4DnB = State_Output_194;
                state_44.__p_JkJjwhrlRt4MnIeRBF64VP = Output_197;
                state_44.__p_A5YUKxwLfwpLqlzzjjHzHx = State_Output_199;
                state_44.__p_Txg022TJAfkQXeshliMXZ5 = State_Output_201;
                state_44.__p_Or4mozdOD62MZnFtwwGali = Output_204;
                state_44.__p_Gpl9GZ5CGHiOfJy8Qbq68J = State_Output_206;
                state_44.__p_BrcrG3zSybxObQmQ2n9FYs = Output_296;
                state_44.__p_MCtdPtr9MjuPt42vKzsmfk = State_Output_210;
                state_44.__p_VsTjyIPH8K4Odcau0Lnggg = State_Output_212;
                state_44.__p_GjoP8uR2na9LVa0T0vslcR = State_Output_215;
                state_44.__p_EWKGBvR711IOm1itym0Ryv = State_Output_219;
                state_44.__p_ASxvz3suRV7O2KjvOP8o5A = State_Output_221;
                state_44.__p_IrdLHflPjOhK98vlxajKrE = Output_224;
                state_44.__p_EObAHtzUwYDN4QQ1pwnKGm = State_Output_226;
                state_44.__p_FZFZaMga7C0MHSY2momT7T = State_Output_228;
                state_44.__p_TMQtR7fQRuTPrAnWVfo1ug = Output_231;
                state_44.__p_Mf1I9F0Gl1qNDq4Fgs9mje = State_Output_233;
                state_44.__p_OCMH1YHplwnQOs2c1Peuvx = Output_245;
                state_44.__p_F2kzjm0knY1LaZ3X5rA2i3 = State_Output_237;
                state_44.__p_QdG3xLb1SfQLd63exGRrnb = State_Output_247;
                state_44.__pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J = __pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J_249;
                state_44.__p_RgPPsUAfRIFLueFHYGmG4J = State_Output_251;
                state_44.__p_QBfAM7LFIlEQKjKvLZivkC = State_Output_260;
                state_44.__p_J5xamYbncw4Nz3vJJCHdMa = State_Output_262;
                state_44.__pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ = __pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ_264;
                state_44.__p_SlgnLIwHScwLkPTYSxhGdJ = State_Output_266;
                state_44.__p_EPjJp86lllMMMxfs8V3Brf = State_Output_268;
                state_44.__p_Kmge7kpo6cPPL16ywaBWa7 = State_Output_270;
                state_44.__pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf = __pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf_272;
                state_44.__p_RzfrLKpqe8NN1rRC8gF1Mf = State_Output_274;
                state_44.__p_BG2VoIHhrfyOPgDiP89lnu = Output_276;
                state_44.__p_Qe6BRlJgbdqOgZ0L1zLs2q = Output_278;
                state_44.__p_Lh28ioPoApjMEeDpBRf89D = State_Output_281;
                state_44.__p_Vk6I19HMkMZMQrAcvK79VF = State_Output_285;
                state_44.__p_VGYpJekRixkMkICjCiR22a = State_Output_288;
                state_44.__p_U9123t5EgJCNabvmwRdz6g = State_Output_290;
                state_44.__p_G0gzyyus8Q5PcmuUjOIR4R = State_Output_294;
                outputs_42 = n2.ValueTuple.Create(Output_289);
                manager_40 = manager_40.Update(inputs_41, __GetContext__().IsImmutable, Dispose_Cached_Outputs_39, state_44, outputs_42);
            }
            else
            {
                manager_40.Update(inputs_41, __GetContext__().IsImmutable, Dispose_Cached_Outputs_39);
            }

            var __auto_297 = outputs_42.Item1;
            this.__cache_RVDYVY9EfcbLWYutkZ5IGH = manager_40;
            bool Enabled_298 = true;
            var Output_302 = this.__p_J2dqHl61o8CMNysess9gOM.Update(Dispatcher_In: __auto_34, Thread_Group_Size_In: __auto_35, GpuValue_In: __auto_297, Enabled_In: Enabled_298, Dispatcher_Out: out n32.VLComputeEffectShader Dispatcher_299, Last_Error_Out: out string Last_Error_300, Shader_Code_Out: out string Shader_Code_301);
            this.__p_J2dqHl61o8CMNysess9gOM = Output_302;
            n33.IGraphicsRendererBase Compute_Stage_Out_303 = (n33.IGraphicsRendererBase)Dispatcher_299;
            bool SetValue_304 = true;
            var Output_305 = State_Output_37;
            if (SetValue_304)
            {
                Output_305 = State_Output_37.SetValue(Input_In: __auto_16);
            }

            this.__p_V5t6mr40Q5yNH3WpEdNHaB = Output_305;
            bool Update_306 = true;
            var Output_307 = this.__p_DB1cfOZbgdHPk7tID41Nxl;
            if (Update_306)
            {
                Output_307 = this.__p_DB1cfOZbgdHPk7tID41Nxl.Update();
            }

            this.__p_DB1cfOZbgdHPk7tID41Nxl = Output_307;
            bool SetElementCount_308 = true;
            var Output_309 = Output_307;
            if (SetElementCount_308)
            {
                Output_309 = Output_307.SetElementCount(ElementCount_In: __pad_QXGuHtWE9tPQUDdUOHQCxf_15);
            }

            this.__p_DB1cfOZbgdHPk7tID41Nxl = Output_309;
            Compute_Stage_Out = Compute_Stage_Out_303;
            return this;
        }

        public n11.AugmentedTexture2DVectorField_Fluid3D_C Configure(n27.Texture VectorField_Texture_In, n27.Texture World_Texture_In, [n5.SerializedDefaultValueAttribute("False", false)] bool Flip_X_In, n6.Matrix World_Transformation_In, n28.GpuValue<n27.SamplerState> Sampler_In, n28.GpuValue<float> Level_In, [n5.SerializedDefaultValueAttribute("1", false)] float Strength_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Additive_In, n28.GpuValue<float> Threshold_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Helper_Enabled_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In)
        {
            this.VectorField_Texture = VectorField_Texture_In;
            n27.Texture __auto_0 = VectorField_Texture_In;
            this.World_Texture = World_Texture_In;
            n27.Texture __auto_1 = World_Texture_In;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_D1QjSRn0tP6LtOTvBlaMPa;
            if (manager_4 is null)
            {
                manager_4 = new n13.Manager<n2.ValueTuple<n27.Texture>, n2.ValueTuple<n6.Vector2, int, int>>((n40._Operations_.CreateDefault(), 0, 0));
            }

            var inputs_5 = n2.ValueTuple.Create(World_Texture_In);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                int __pad_UWf0ub6EVeNOFXt08Ia2xQ_9 = __slot_UWf0ub6EVeNOFXt08Ia2xQ;
                n15.ObjectHelpers.IsAssigned(x: World_Texture_In, result: out bool Result_10, notAssigned: out bool Not_Assigned_11);
                int __auto_12;
                int __auto_13;
                if (Result_10)
                {
                    var Width_15 = World_Texture_In.Width;
                    var Height_16 = World_Texture_In.Height;
                    __auto_13 = Height_16;
                    __auto_12 = Width_15;
                }
                else
                {
                    __auto_12 = __pad_UWf0ub6EVeNOFXt08Ia2xQ_9;
                    __auto_13 = __pad_UWf0ub6EVeNOFXt08Ia2xQ_9;
                }

                float X_17 = (float)__auto_12;
                float Y_18 = (float)__auto_13;
                var Output_19 = new n6.Vector2(x: X_17, y: Y_18);
                outputs_6 = (Output_19, __auto_12, __auto_13);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, default, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var(__auto_20, __auto_21, __auto_22) = outputs_6;
            this.__cache_D1QjSRn0tP6LtOTvBlaMPa = manager_4;
            this.Flip_X = Flip_X_In;
            bool __auto_23 = Flip_X_In;
            this.World_Transformation = World_Transformation_In;
            n6.Matrix __auto_24 = World_Transformation_In;
            this.Sampler = Sampler_In;
            n28.GpuValue<n27.SamplerState> __auto_25 = Sampler_In;
            this.Level = Level_In;
            n28.GpuValue<float> __auto_26 = Level_In;
            this.Strength = Strength_In;
            float __auto_27 = Strength_In;
            this.Additive = Additive_In;
            bool __auto_28 = Additive_In;
            this.Threshold = Threshold_In;
            n28.GpuValue<float> __auto_29 = Threshold_In;
            this.Helper_Enabled = Helper_Enabled_In;
            bool __auto_30 = Helper_Enabled_In;
            this.Enabled = Enabled_In;
            bool __auto_31 = Enabled_In;
            this.X_Resolution = __auto_21;
            int __auto_32 = __auto_21;
            this.Y_Resolution = __auto_22;
            int __auto_33 = __auto_22;
            this.Texture_Resolution = __auto_20;
            n6.Vector2 __auto_34 = __auto_20;
            return this;
        }

        public n11.AugmentedTexture2DVectorField_Fluid3D_C GetHelperEntity_(out n43.Entity Helper_Entity_Out)
        {
            float __pad_GHzZY9oujHbNm74JzAwsoU_0 = __slot_GHzZY9oujHbNm74JzAwsoU;
            bool __auto_1 = this.Flip_X;
            n27.Texture __auto_2 = this.World_Texture;
            n6.Vector2 __pad_NfcKmp2W1N5MM3TQ3Pl6vD_3 = __slot_NfcKmp2W1N5MM3TQ3Pl6vD;
            n6.Vector2 __pad_KU4nQPk6AyiOfTTbD05lsz_4 = __slot_KU4nQPk6AyiOfTTbD05lsz;
            n28.GpuValue<float> __auto_5 = this.Level;
            float __pad_ITOriOgSxkcPvx7Rzd2ziu_6 = __slot_ITOriOgSxkcPvx7Rzd2ziu;
            float __pad_SAGxfvU2lX3PHTNcGHIqb0_7 = __slot_SAGxfvU2lX3PHTNcGHIqb0;
            float __pad_FOWcxe9XfVgPfVzcKpLAbc_8 = __slot_FOWcxe9XfVgPfVzcKpLAbc;
            n3.TextureFilter __pad_IRdSx4QaiBVMX7tI1IyH8M_9 = __slot_IRdSx4QaiBVMX7tI1IyH8M;
            n6.Matrix __auto_10 = this.World_Transformation;
            var None_11 = n42.DepthStencilStateDescriptions.None;
            var Output_13 = this.__p_NB9UGFvQAD8NauxrNc8IRX.GetShaderGraph(graph_Out: out n28.GpuValue<n6.Vector4> graph_12);
            this.__p_NB9UGFvQAD8NauxrNc8IRX = Output_13;
            var State_Output_15 = this.__p_T4PKbOmcmh5LXuqOhMveA6.Update(Input_In: graph_12, Output_Out: out n28.GpuValue<n6.Vector3> Output_14);
            this.__p_T4PKbOmcmh5LXuqOhMveA6 = State_Output_15;
            var State_Output_17 = this.__p_JjqD1lAD5JnLG51xtUpiru.Update(Output_Out: out n28.GpuValue<float> Output_16);
            this.__p_JjqD1lAD5JnLG51xtUpiru = State_Output_17;
            var State_Output_19 = this.__p_OPJrArTCSDLLJHEniTH0V6.Update(Input_In: Output_16, Output_Out: out n28.GpuValue<float> Output_18);
            this.__p_OPJrArTCSDLLJHEniTH0V6 = State_Output_19;
            var State_Output_21 = this.__p_LYnKOD5g74jLfE4bITSec5.Update(xyz_In: Output_14, w_In: Output_18, Output_Out: out n28.GpuValue<n6.Vector4> Output_20);
            this.__p_LYnKOD5g74jLfE4bITSec5 = State_Output_21;
            n28.GpuValue<n6.Vector3> Position_22 = default(n28.GpuValue<n6.Vector3>);
            n28.GpuValue<float> Size_23 = default(n28.GpuValue<float>);
            n28.GpuValue<bool> Skip_24 = default(n28.GpuValue<bool>);
            n28.GpuValue<n6.Vector4> ColorTarget_25 = default(n28.GpuValue<n6.Vector4>);
            n28.GpuValue<float> Clip_26 = default(n28.GpuValue<float>);
            bool Force_Cache_27 = false;
            bool Enabled_28 = true;
            var Output_34 = this.__p_VtBfs78zVbbN97Kk4eYMYR.Update(Depth_Stencil_State_In: None_11, Position_In: Position_22, Size_In: Size_23, Color_In: Output_20, Skip_In: Skip_24, ColorTarget_In: ColorTarget_25, Clip_In: Clip_26, Force_Cache_In: Force_Cache_27, Enabled_In: Enabled_28, ComputeStage_Out: out n84.BaseRenderer_C ComputeStage_29, Entity_Out: out n43.Entity Entity_30, lastError_Out: out string lastError_31, Shader_Code_Out: out string Shader_Code_32, Ticket_Out: out int Ticket_33);
            this.__p_VtBfs78zVbbN97Kk4eYMYR = Output_34;
            n85.IComputeStage_I Input_4_35 = (n85.IComputeStage_I)ComputeStage_29;
            var Output_36 = this.__p_DB1cfOZbgdHPk7tID41Nxl;
            n85.IResourceHandler_I Resource_Handler_37 = (n85.IResourceHandler_I)Output_36;
            n28.GpuValue<float> Probability_38 = this.__monadBuilder_GS23KZ8tYf0PLg7e2G37ht.Return(__pad_SAGxfvU2lX3PHTNcGHIqb0_7);
            n28.GpuValue<n27.Texture> Texture_39 = this.__monadBuilder_EookRU9opqsPtYkLwnP9o3.Return(__auto_2);
            var State_Output_41 = this.__p_F5tBVKYz7YePjkHu5YXvDf.Update(Output_Out: out n28.GpuValue<n27.SamplerState> Output_40);
            this.__p_F5tBVKYz7YePjkHu5YXvDf = State_Output_41;
            n28.GpuValue<n6.Vector2> Min_42 = this.__monadBuilder_UKUcJ0KljjRPNTTT512qMw.Return(__pad_NfcKmp2W1N5MM3TQ3Pl6vD_3);
            n28.GpuValue<n6.Vector2> Max_43 = this.__monadBuilder_EgliWEbqsFHQSDc9V5oHSY.Return(__pad_KU4nQPk6AyiOfTTbD05lsz_4);
            bool PerID_44 = true;
            int seed_45 = -1;
            bool Constant_46 = false;
            var Output_48 = this.__p_ELvShHV97OzORGvrEbKYXh.Update(PerID_In: PerID_44, seed_In: seed_45, Constant_In: Constant_46, Min_In: Min_42, Max_In: Max_43, Shader_Graph_Out: out n28.GpuValue<n6.Vector2> Shader_Graph_47);
            this.__p_ELvShHV97OzORGvrEbKYXh = Output_48;
            n28.GpuValue<n6.Vector4> Default_49 = default(n28.GpuValue<n6.Vector4>);
            var State_Output_51 = this.__p_Sn4WIl2h8jgNEyrWl7vFr9.Update(Texture_In: Texture_39, Sampler_In: Output_40, Texture_Coords_In: Shader_Graph_47, Level_In: __auto_5, Default_In: Default_49, Output_Out: out n28.GpuValue<n6.Vector4> Output_50);
            this.__p_Sn4WIl2h8jgNEyrWl7vFr9 = State_Output_51;
            var State_Output_53 = this.__p_B6RvDFS9gxTP7rHlBRgS5R.Update(Input_In: Output_50, Output_Out: out n28.GpuValue<n6.Vector3> Output_52);
            this.__p_B6RvDFS9gxTP7rHlBRgS5R = State_Output_53;
            var Output_56 = this.__p_O9pnMU2xuTgNMVBMcGf0mi.Update(value_In: Output_52, x_Out: out n28.GpuValue<float> x_54, yz_Out: out n28.GpuValue<n6.Vector2> yz_55);
            this.__p_O9pnMU2xuTgNMVBMcGf0mi = Output_56;
            var State_Output_58 = this.__p_EGo36afa43zNbVL6HV5goC.Update(Input_In: x_54, Output_Out: out n28.GpuValue<float> Output_57);
            this.__p_EGo36afa43zNbVL6HV5goC = State_Output_58;
            var State_Output_60 = this.__p_HRm2QROss2dQTwJ6zaz2zh.Update(x_In: Output_57, yz_In: yz_55, Output_Out: out n28.GpuValue<n6.Vector3> Output_59);
            this.__p_HRm2QROss2dQTwJ6zaz2zh = State_Output_60;
            n39._Operations_.Switch_Boolean<n28.GpuValue<n6.Vector3>>(Condition_In: __auto_1, Input_In: Output_52, Input_2_In: Output_59, Output_Out: out n28.GpuValue<n6.Vector3> Output_61);
            var Output_63 = this.__p_NfRzfAnwI1aNiW2tfHnmGX.Update(Value_In: __pad_GHzZY9oujHbNm74JzAwsoU_0, GpuValue_Out: out n28.GpuValue<float> GpuValue_62);
            this.__p_NfRzfAnwI1aNiW2tfHnmGX = Output_63;
            var State_Output_65 = this.__p_BFYojzYZdTpOYkXXcEvIKS.Update(xyz_In: Output_61, w_In: GpuValue_62, Output_Out: out n28.GpuValue<n6.Vector4> Output_64);
            this.__p_BFYojzYZdTpOYkXXcEvIKS = State_Output_65;
            var State_Output_67 = this.__p_P9LEX7PQURKN849ikWpMZg.Update(Output_Out: out n28.GpuValue<n6.Matrix> Output_66);
            this.__p_P9LEX7PQURKN849ikWpMZg = State_Output_67;
            var State_Output_69 = this.__p_GurACfxLkegO8NdBVcEblV.Update(Input1_In: Output_64, Input2_In: Output_66, Output_Out: out n28.GpuValue<n6.Vector4> Output_68);
            this.__p_GurACfxLkegO8NdBVcEblV = State_Output_69;
            var State_Output_71 = this.__p_KmVw2zrYyvMM7DjNIIdOq7.Update(Input_In: Output_68, Output_Out: out n28.GpuValue<n6.Vector3> Output_70);
            this.__p_KmVw2zrYyvMM7DjNIIdOq7 = State_Output_71;
            n28.GpuValue<float> Lifetime_72 = this.__monadBuilder_FC3z6Xu0RPANqY7PdUATno.Return(__pad_FOWcxe9XfVgPfVzcKpLAbc_8);
            var Output_74 = this.__p_MnkQ87CgN27OXdUg8RCdoy.GetShaderGraph(graph_Out: out n28.GpuValue<float> graph_73);
            this.__p_MnkQ87CgN27OXdUg8RCdoy = Output_74;
            n28.GpuValue<float> The_Source_75 = this.__monadBuilder_SQEjMfbxUI9Oy03vkn1ECk.Return(__pad_ITOriOgSxkcPvx7Rzd2ziu_6);
            var Output_78 = this.__p_FjaAhCwKIapOhtTArYesxP.Update(The_Target_In: graph_73, The_Source_In: The_Source_75, Value_Out: out n28.GpuValue<float> Value_76, Void_Out: out n28.GpuValue<n54.GpuVoid> Void_77);
            this.__p_FjaAhCwKIapOhtTArYesxP = Output_78;
            n28.GpuValue<n6.Vector3> Velocity_79 = default(n28.GpuValue<n6.Vector3>);
            n28.GpuValue<float> mass_80 = default(n28.GpuValue<float>);
            n28.GpuValue<n6.Vector4> Color_81 = default(n28.GpuValue<n6.Vector4>);
            n28.GpuValue<n54.GpuVoid> Custom_2_82 = default(n28.GpuValue<n54.GpuVoid>);
            n28.GpuValue<float> DeltaTime_83 = default(n28.GpuValue<float>);
            bool Enabled_84 = true;
            var builder_85 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb, 2);
            builder_85.Add(Void_77);
            builder_85.Add(Custom_2_82);
            var __pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb_86 = builder_85.Commit();
            this.__pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb = __pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb_86;
            var State_Output_88 = this.__p_U8BWCraLmBKMKN4JBLCYOb.Update(Probability_In: Probability_38, Position_In: Output_70, Velocity_In: Velocity_79, mass_In: mass_80, Lifetime_In: Lifetime_72, Color_In: Color_81, Custom_In: __pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb_86, DeltaTime_In: DeltaTime_83, Enabled_In: Enabled_84, Output_Out: out n28.GpuValue<n54.GpuVoid> Output_87);
            this.__p_U8BWCraLmBKMKN4JBLCYOb = State_Output_88;
            n28.GpuValue<float> ScalePositionDelta_89 = default(n28.GpuValue<float>);
            n28.GpuValue<float> ScaleAgeDelta_90 = default(n28.GpuValue<float>);
            bool Enabled_91 = true;
            n28.GpuValue<bool> Enabled_92 = this.__monadBuilder_H9Dt1Few6gdPYVFRJKLEXR.Return(Enabled_91);
            var State_Output_94 = this.__p_TOFW6p4MqlkPctT79ts2Et.Update(ScalePositionDelta_In: ScalePositionDelta_89, ScaleAgeDelta_In: ScaleAgeDelta_90, Enabled_In: Enabled_92, Output_Out: out n28.GpuValue<n54.GpuVoid> Output_93);
            this.__p_TOFW6p4MqlkPctT79ts2Et = State_Output_94;
            n28.GpuValue<n54.GpuVoid> Input_3_95 = default(n28.GpuValue<n54.GpuVoid>);
            bool Enabled_96 = true;
            var builder_97 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_NnM74lDYxqPOnLE16RVex1, 3);
            builder_97.Add(Output_87);
            builder_97.Add(Output_93);
            builder_97.Add(Input_3_95);
            var __pin_group_Input_In_NnM74lDYxqPOnLE16RVex1_98 = builder_97.Commit();
            this.__pin_group_Input_In_NnM74lDYxqPOnLE16RVex1 = __pin_group_Input_In_NnM74lDYxqPOnLE16RVex1_98;
            var State_Output_100 = this.__p_NnM74lDYxqPOnLE16RVex1.Update(Input_In: __pin_group_Input_In_NnM74lDYxqPOnLE16RVex1_98, Enabled_In: Enabled_96, Output_Out: out n28.GpuValue<n54.GpuVoid> Output_99);
            this.__p_NnM74lDYxqPOnLE16RVex1 = State_Output_100;
            var Output_103 = this.__p_TXrqvb2BEjEQZeQ9ODAYzr.Update(Shader_Graph_In: Output_99, Shader_Graph_Out: out n28.GpuValue<n54.GpuVoid> Shader_Graph_101, Attributes_Out: out n22.Dictionary<string, n22.List<n85.AttributeReference_C>> Attributes_102);
            this.__p_TXrqvb2BEjEQZeQ9ODAYzr = Output_103;
            n85.IComputeStage_I Input_2_104 = (n85.IComputeStage_I)Output_103;
            n12.Spread<n85.IUpdateGraph_I> UpdateGraphs_105 = __c_GjedOUE793ULaHlz9ymRZ1;
            var builder_106 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2, 2);
            builder_106.Add(Input_4_35);
            builder_106.Add(Input_2_104);
            var __pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2_107 = builder_106.Commit();
            this.__pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2 = __pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2_107;
            var State_Output_110 = this.__p_KzXzg2Eb1mXOJKB19FY9T2.Update(Resource_Handler_In: Resource_Handler_37, UpdateGraphs_In: UpdateGraphs_105, Input_In: __pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2_107, Output_Out: out bool Output_108, Highest_Ticket_Out: out int Highest_Ticket_109);
            this.__p_KzXzg2Eb1mXOJKB19FY9T2 = State_Output_110;
            n1.CompilationHelper.WritePin(this.__p_C7Q4tyPHJeqLtrsAXLfqQq.Inputs[0], ref __pad_IRdSx4QaiBVMX7tI1IyH8M_9);
            this.__p_C7Q4tyPHJeqLtrsAXLfqQq = this.__p_C7Q4tyPHJeqLtrsAXLfqQq;
            n1.CompilationHelper.ReadPin(this.__p_C7Q4tyPHJeqLtrsAXLfqQq.Outputs[0], out n27.SamplerState out_111);
            this.__p_C7Q4tyPHJeqLtrsAXLfqQq = this.__p_C7Q4tyPHJeqLtrsAXLfqQq;
            bool SetValue_112 = true;
            var Output_113 = State_Output_41;
            if (SetValue_112)
            {
                Output_113 = State_Output_41.SetValue(Input_In: out_111);
            }

            this.__p_F5tBVKYz7YePjkHu5YXvDf = Output_113;
            bool SetValue_114 = true;
            var Output_115 = State_Output_67;
            if (SetValue_114)
            {
                Output_115 = State_Output_67.SetValue(Input_In: __auto_10);
            }

            this.__p_P9LEX7PQURKN849ikWpMZg = Output_115;
            Helper_Entity_Out = Entity_30;
            return this;
        }

        public n11.AugmentedTexture2DVectorField_Fluid3D_C GetHelperEnabled_(out bool Helper_Enabled_Out)
        {
            bool __auto_0 = this.Helper_Enabled;
            Helper_Enabled_Out = __auto_0;
            return this;
        }

        public n11.AugmentedTexture2DVectorField_Fluid3D_C GetPriority_(out float Priority_Out)
        {
            float __auto_0 = this.Priority;
            Priority_Out = __auto_0;
            return this;
        }

        public n11.AugmentedTexture2DVectorField_Fluid3D_C SetContext_(n4.FluidContext_C Context_In)
        {
            this.Context = Context_In;
            n4.FluidContext_C __auto_0 = Context_In;
            return this;
        }

        public n11.AugmentedTexture2DVectorField_Fluid3D_C __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.VectorField_Texture = default(n27.Texture);
            this.World_Transformation = n9._Operations_.CreateDefault();
            this.Additive = false;
            this.Strength = 0F;
            this.Enabled = false;
            this.Helper_Enabled = false;
            this.Threshold = default(n28.GpuValue<float>);
            this.Level = default(n28.GpuValue<float>);
            this.Sampler = default(n28.GpuValue<n27.SamplerState>);
            this.Priority = 0F;
            this.World_Texture = default(n27.Texture);
            this.Texture_Resolution = n40._Operations_.CreateDefault();
            this.Flip_X = false;
            this.X_Resolution = 0;
            this.Y_Resolution = 0;
            this.Context = n4.FluidContext_C.CreateDefault();
            this.__pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb = n14._Operations_.CreateDefault<n28.GpuValue<n54.GpuVoid>>();
            this.__pin_group_Input_In_NnM74lDYxqPOnLE16RVex1 = n14._Operations_.CreateDefault<n28.GpuValue<n54.GpuVoid>>();
            this.__pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2 = n14._Operations_.CreateDefault<n85.IComputeStage_I>();
            bool __pad_VqUcN5HxNdFOMoHhLiWFOb_0 = __slot_VqUcN5HxNdFOMoHhLiWFOb;
            float __pad_Cej794SVuqzMRxBADkocJb_1 = __slot_Cej794SVuqzMRxBADkocJb;
            bool __pad_BF8GPcgZazLPneZv9B0WAW_2 = __slot_BF8GPcgZazLPneZv9B0WAW;
            bool __pad_Td3vKSCpVSCPOVPbY2Qwzo_3 = __slot_Td3vKSCpVSCPOVPbY2Qwzo;
            this.Additive = __pad_VqUcN5HxNdFOMoHhLiWFOb_0;
            bool __auto_4 = __pad_VqUcN5HxNdFOMoHhLiWFOb_0;
            this.Strength = __pad_Cej794SVuqzMRxBADkocJb_1;
            float __auto_5 = __pad_Cej794SVuqzMRxBADkocJb_1;
            this.Enabled = __pad_BF8GPcgZazLPneZv9B0WAW_2;
            bool __auto_6 = __pad_BF8GPcgZazLPneZv9B0WAW_2;
            this.Helper_Enabled = __pad_Td3vKSCpVSCPOVPbY2Qwzo_3;
            bool __auto_7 = __pad_Td3vKSCpVSCPOVPbY2Qwzo_3;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "J2dqHl61o8CMNysess9gOM", 358133U);
            var Output_9 = n55.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2.Create(Node_Context: Node_Context_8);
            this.__p_J2dqHl61o8CMNysess9gOM = Output_9;
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "TOFW6p4MqlkPctT79ts2Et", 358506U);
            var Output_11 = n86.IntegrateVelocityAndPosition_C.Create(Node_Context: Node_Context_10);
            this.__p_TOFW6p4MqlkPctT79ts2Et = Output_11;
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "TXrqvb2BEjEQZeQ9ODAYzr", 358514U);
            var Output_13 = n85.ComputeStage_C.Create(Node_Context: Node_Context_12);
            this.__p_TXrqvb2BEjEQZeQ9ODAYzr = Output_13;
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "U8BWCraLmBKMKN4JBLCYOb", 358547U);
            var Output_15 = n87.ProbabilityEmitter_AES99Kg9CLFOmrKjo7Tiub.Create(Node_Context: Node_Context_14);
            this.__p_U8BWCraLmBKMKN4JBLCYOb = Output_15;
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "VtBfs78zVbbN97Kk4eYMYR", 358596U);
            var Output_17 = n88.SpriteRenderer_Particle_C.Create(Node_Context: Node_Context_16);
            this.__p_VtBfs78zVbbN97Kk4eYMYR = Output_17;
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "NnM74lDYxqPOnLE16RVex1", 358648U);
            var Output_19 = n56.Group_GpuVoid_PRMY4HYRXTzM4hzmICywZJ.Create(Node_Context: Node_Context_18);
            this.__p_NnM74lDYxqPOnLE16RVex1 = Output_19;
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "NB9UGFvQAD8NauxrNc8IRX", 358665U);
            var Output_21 = n89.Color_Particle_LlPANDKLszZP94y29eyOob.Create(Node_Context: Node_Context_20);
            this.__p_NB9UGFvQAD8NauxrNc8IRX = Output_21;
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "LYnKOD5g74jLfE4bITSec5", 358674U);
            var Output_23 = n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_22);
            this.__p_LYnKOD5g74jLfE4bITSec5 = Output_23;
            n1.NodeContext Node_Context_24 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "OPJrArTCSDLLJHEniTH0V6", 358691U);
            var Output_25 = n75.OneMinus_TZSID1klGMVLkhX7sgErcR<float>.Create(Node_Context: Node_Context_24);
            this.__p_OPJrArTCSDLLJHEniTH0V6 = Output_25;
            n1.NodeContext Node_Context_26 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "JjqD1lAD5JnLG51xtUpiru", 358701U);
            var Output_27 = n90.AgeOverLifeTime_L63dVGA8FhRMrtDsWIyrMT.Create(Node_Context: Node_Context_26);
            this.__p_JjqD1lAD5JnLG51xtUpiru = Output_27;
            n1.NodeContext Node_Context_28 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "KzXzg2Eb1mXOJKB19FY9T2", 358715U);
            var Output_29 = n85.ComputeSystem_Spectral_C.Create(Node_Context: Node_Context_28);
            this.__p_KzXzg2Eb1mXOJKB19FY9T2 = Output_29;
            n1.NodeContext Node_Context_30 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "MnkQ87CgN27OXdUg8RCdoy", 358759U);
            var Output_31 = n89.Size_Particle_PU7rrzAob6oOOELRssVZS9.Create(Node_Context: Node_Context_30);
            this.__p_MnkQ87CgN27OXdUg8RCdoy = Output_31;
            n1.NodeContext Node_Context_32 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "FjaAhCwKIapOhtTArYesxP", 358768U);
            var Output_33 = n57.Set_B3yQBkmuq1cLLobAtKQD9i<float>.Create(Node_Context: Node_Context_32);
            this.__p_FjaAhCwKIapOhtTArYesxP = Output_33;
            n1.NodeContext Node_Context_34 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "DB1cfOZbgdHPk7tID41Nxl", 358793U);
            var Output_35 = n85.BufferResourceHandler_C.Create(Node_Context: Node_Context_34);
            this.__p_DB1cfOZbgdHPk7tID41Nxl = Output_35;
            n1.NodeContext Node_Context_36 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "T4PKbOmcmh5LXuqOhMveA6", 358811U);
            var Output_37 = n76.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_36);
            this.__p_T4PKbOmcmh5LXuqOhMveA6 = Output_37;
            n1.NodeContext Node_Context_38 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "ELvShHV97OzORGvrEbKYXh", 358820U);
            var Output_39 = n91.Random_C<n6.Vector2>.Create(Node_Context: Node_Context_38);
            this.__p_ELvShHV97OzORGvrEbKYXh = Output_39;
            n1.NodeContext Node_Context_40 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Sn4WIl2h8jgNEyrWl7vFr9", 358900U);
            var Output_41 = n62.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n6.Vector2>.Create(Node_Context: Node_Context_40);
            this.__p_Sn4WIl2h8jgNEyrWl7vFr9 = Output_41;
            n1.NodeContext Node_Context_42 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "B6RvDFS9gxTP7rHlBRgS5R", 358936U);
            var Output_43 = n76.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_42);
            this.__p_B6RvDFS9gxTP7rHlBRgS5R = Output_43;
            n1.NodeContext Node_Context_44 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "GurACfxLkegO8NdBVcEblV", 358961U);
            var Output_45 = n75.Mul_B0P7ghpqXJiLy15iE7sIid<n6.Vector4, n6.Matrix, n6.Vector4>.Create(Node_Context: Node_Context_44);
            this.__p_GurACfxLkegO8NdBVcEblV = Output_45;
            n1.NodeContext Node_Context_46 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "NfRzfAnwI1aNiW2tfHnmGX", 358995U);
            var Output_47 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_46);
            this.__p_NfRzfAnwI1aNiW2tfHnmGX = Output_47;
            n1.NodeContext Node_Context_48 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "BFYojzYZdTpOYkXXcEvIKS", 359019U);
            var Output_49 = n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_48);
            this.__p_BFYojzYZdTpOYkXXcEvIKS = Output_49;
            n1.NodeContext Node_Context_50 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "P9LEX7PQURKN849ikWpMZg", 359037U);
            var Output_51 = n57.GPUIn_C<n6.Matrix>.Create(Node_Context: Node_Context_50);
            this.__p_P9LEX7PQURKN849ikWpMZg = Output_51;
            n1.NodeContext Node_Context_52 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "KmVw2zrYyvMM7DjNIIdOq7", 359045U);
            var Output_53 = n76.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_52);
            this.__p_KmVw2zrYyvMM7DjNIIdOq7 = Output_53;
            var node_54 = n1.CompilationHelper.CreateNodeById(Node_Context, "SamplerState", "Stride.Graphics.Advanced");
            this.__p_C7Q4tyPHJeqLtrsAXLfqQq = node_54;
            n1.NodeContext Node_Context_55 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "F5tBVKYz7YePjkHu5YXvDf", 359090U);
            var Output_56 = n62.SamplerIn_Fuse_Ow27E5pjREtLkbiG0rRYjW.Create(Node_Context: Node_Context_55);
            this.__p_F5tBVKYz7YePjkHu5YXvDf = Output_56;
            n1.NodeContext Node_Context_57 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "V5t6mr40Q5yNH3WpEdNHaB", 359126U);
            var Output_58 = n57.GPUIn_C<float>.Create(Node_Context: Node_Context_57);
            this.__p_V5t6mr40Q5yNH3WpEdNHaB = Output_58;
            n1.NodeContext Node_Context_59 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "O9pnMU2xuTgNMVBMcGf0mi", 359165U);
            var Output_60 = n83.xMyz_split_AJovkBTfOKGNHniZzmUeC0.Create(Node_Context: Node_Context_59);
            this.__p_O9pnMU2xuTgNMVBMcGf0mi = Output_60;
            n1.NodeContext Node_Context_61 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "HRm2QROss2dQTwJ6zaz2zh", 359182U);
            var Output_62 = n77.xPyz_join_TfjUbK4F10LQJgxHoD2Rkv.Create(Node_Context: Node_Context_61);
            this.__p_HRm2QROss2dQTwJ6zaz2zh = Output_62;
            n1.NodeContext Node_Context_63 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "EGo36afa43zNbVL6HV5goC", 359198U);
            var Output_64 = n75.Negate_P5nGfBLszbBL1YRjqmyYHC<float>.Create(Node_Context: Node_Context_63);
            this.__p_EGo36afa43zNbVL6HV5goC = Output_64;
            this.__cache_UAWDxcbxBYNOzxkgjDN0Le = null;
            this.__cache_RVDYVY9EfcbLWYutkZ5IGH = null;
            this.__cache_D1QjSRn0tP6LtOTvBlaMPa = null;
            this.__monadBuilder_GS23KZ8tYf0PLg7e2G37ht = n28.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_EookRU9opqsPtYkLwnP9o3 = n28.GpuValueMonadicFactory<n27.Texture>.Default.GetMonadBuilder(true);
            this.__monadBuilder_UKUcJ0KljjRPNTTT512qMw = n28.GpuValueMonadicFactory<n6.Vector2>.Default.GetMonadBuilder(true);
            this.__monadBuilder_EgliWEbqsFHQSDc9V5oHSY = n28.GpuValueMonadicFactory<n6.Vector2>.Default.GetMonadBuilder(true);
            this.__monadBuilder_FC3z6Xu0RPANqY7PdUATno = n28.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_SQEjMfbxUI9Oy03vkn1ECk = n28.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_H9Dt1Few6gdPYVFRJKLEXR = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            return this;
        }

        public n11.AugmentedTexture2DVectorField_Fluid3D_C __CreateDefault__()
        {
            this.VectorField_Texture = default(n27.Texture);
            this.World_Transformation = n9._Operations_.CreateDefault();
            this.Additive = false;
            this.Strength = 0F;
            this.Enabled = false;
            this.Helper_Enabled = false;
            this.Threshold = default(n28.GpuValue<float>);
            this.Level = default(n28.GpuValue<float>);
            this.Sampler = default(n28.GpuValue<n27.SamplerState>);
            this.Priority = 0F;
            this.World_Texture = default(n27.Texture);
            this.Texture_Resolution = n40._Operations_.CreateDefault();
            this.Flip_X = false;
            this.X_Resolution = 0;
            this.Y_Resolution = 0;
            this.Context = n4.FluidContext_C.CreateDefault();
            this.__pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb = n14._Operations_.CreateDefault<n28.GpuValue<n54.GpuVoid>>();
            this.__pin_group_Input_In_NnM74lDYxqPOnLE16RVex1 = n14._Operations_.CreateDefault<n28.GpuValue<n54.GpuVoid>>();
            this.__pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2 = n14._Operations_.CreateDefault<n85.IComputeStage_I>();
            this.__cache_UAWDxcbxBYNOzxkgjDN0Le = null;
            this.__p_V5t6mr40Q5yNH3WpEdNHaB = n57.GPUIn_C<float>.CreateDefault();
            this.__cache_RVDYVY9EfcbLWYutkZ5IGH = null;
            this.__p_J2dqHl61o8CMNysess9gOM = n55.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2.CreateDefault();
            this.__p_DB1cfOZbgdHPk7tID41Nxl = n85.BufferResourceHandler_C.CreateDefault();
            this.__cache_D1QjSRn0tP6LtOTvBlaMPa = null;
            this.__p_NB9UGFvQAD8NauxrNc8IRX = n89.Color_Particle_LlPANDKLszZP94y29eyOob.CreateDefault();
            this.__p_T4PKbOmcmh5LXuqOhMveA6 = n76.xyz_T2WwCF9xAltPhlUuLjVDje.CreateDefault();
            this.__p_JjqD1lAD5JnLG51xtUpiru = n90.AgeOverLifeTime_L63dVGA8FhRMrtDsWIyrMT.CreateDefault();
            this.__p_OPJrArTCSDLLJHEniTH0V6 = n75.OneMinus_TZSID1klGMVLkhX7sgErcR<float>.CreateDefault();
            this.__p_LYnKOD5g74jLfE4bITSec5 = n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.CreateDefault();
            this.__p_VtBfs78zVbbN97Kk4eYMYR = n88.SpriteRenderer_Particle_C.CreateDefault();
            this.__monadBuilder_GS23KZ8tYf0PLg7e2G37ht = n28.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_EookRU9opqsPtYkLwnP9o3 = n28.GpuValueMonadicFactory<n27.Texture>.Default.GetMonadBuilder(true);
            this.__p_F5tBVKYz7YePjkHu5YXvDf = n62.SamplerIn_Fuse_Ow27E5pjREtLkbiG0rRYjW.CreateDefault();
            this.__monadBuilder_UKUcJ0KljjRPNTTT512qMw = n28.GpuValueMonadicFactory<n6.Vector2>.Default.GetMonadBuilder(true);
            this.__monadBuilder_EgliWEbqsFHQSDc9V5oHSY = n28.GpuValueMonadicFactory<n6.Vector2>.Default.GetMonadBuilder(true);
            this.__p_ELvShHV97OzORGvrEbKYXh = n91.Random_C<n6.Vector2>.CreateDefault();
            this.__p_Sn4WIl2h8jgNEyrWl7vFr9 = n62.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n6.Vector2>.CreateDefault();
            this.__p_B6RvDFS9gxTP7rHlBRgS5R = n76.xyz_T2WwCF9xAltPhlUuLjVDje.CreateDefault();
            this.__p_O9pnMU2xuTgNMVBMcGf0mi = n83.xMyz_split_AJovkBTfOKGNHniZzmUeC0.CreateDefault();
            this.__p_EGo36afa43zNbVL6HV5goC = n75.Negate_P5nGfBLszbBL1YRjqmyYHC<float>.CreateDefault();
            this.__p_HRm2QROss2dQTwJ6zaz2zh = n77.xPyz_join_TfjUbK4F10LQJgxHoD2Rkv.CreateDefault();
            this.__p_NfRzfAnwI1aNiW2tfHnmGX = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.CreateDefault();
            this.__p_BFYojzYZdTpOYkXXcEvIKS = n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.CreateDefault();
            this.__p_P9LEX7PQURKN849ikWpMZg = n57.GPUIn_C<n6.Matrix>.CreateDefault();
            this.__p_GurACfxLkegO8NdBVcEblV = n75.Mul_B0P7ghpqXJiLy15iE7sIid<n6.Vector4, n6.Matrix, n6.Vector4>.CreateDefault();
            this.__p_KmVw2zrYyvMM7DjNIIdOq7 = n76.xyz_T2WwCF9xAltPhlUuLjVDje.CreateDefault();
            this.__monadBuilder_FC3z6Xu0RPANqY7PdUATno = n28.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__p_MnkQ87CgN27OXdUg8RCdoy = n89.Size_Particle_PU7rrzAob6oOOELRssVZS9.CreateDefault();
            this.__monadBuilder_SQEjMfbxUI9Oy03vkn1ECk = n28.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__p_FjaAhCwKIapOhtTArYesxP = n57.Set_B3yQBkmuq1cLLobAtKQD9i<float>.CreateDefault();
            this.__p_U8BWCraLmBKMKN4JBLCYOb = n87.ProbabilityEmitter_AES99Kg9CLFOmrKjo7Tiub.CreateDefault();
            this.__p_TOFW6p4MqlkPctT79ts2Et = n86.IntegrateVelocityAndPosition_C.CreateDefault();
            this.__monadBuilder_H9Dt1Few6gdPYVFRJKLEXR = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            this.__p_NnM74lDYxqPOnLE16RVex1 = n56.Group_GpuVoid_PRMY4HYRXTzM4hzmICywZJ.CreateDefault();
            this.__p_TXrqvb2BEjEQZeQ9ODAYzr = n85.ComputeStage_C.CreateDefault();
            this.__p_KzXzg2Eb1mXOJKB19FY9T2 = default(n85.ComputeSystem_Spectral_C);
            this.__p_C7Q4tyPHJeqLtrsAXLfqQq = default(n1.IVLNode);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_UAWDxcbxBYNOzxkgjDN0Le);
            n1.CompilationHelper.SafeDispose(this.__p_V5t6mr40Q5yNH3WpEdNHaB);
            n1.CompilationHelper.SafeDispose(this.__cache_RVDYVY9EfcbLWYutkZ5IGH);
            n1.CompilationHelper.SafeDispose(this.__p_J2dqHl61o8CMNysess9gOM);
            n1.CompilationHelper.SafeDispose(this.__p_DB1cfOZbgdHPk7tID41Nxl);
            n1.CompilationHelper.SafeDispose(this.__cache_D1QjSRn0tP6LtOTvBlaMPa);
            n1.CompilationHelper.SafeDispose(this.__p_NB9UGFvQAD8NauxrNc8IRX);
            n1.CompilationHelper.SafeDispose(this.__p_T4PKbOmcmh5LXuqOhMveA6);
            n1.CompilationHelper.SafeDispose(this.__p_JjqD1lAD5JnLG51xtUpiru);
            n1.CompilationHelper.SafeDispose(this.__p_OPJrArTCSDLLJHEniTH0V6);
            n1.CompilationHelper.SafeDispose(this.__p_LYnKOD5g74jLfE4bITSec5);
            n1.CompilationHelper.SafeDispose(this.__p_VtBfs78zVbbN97Kk4eYMYR);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_GS23KZ8tYf0PLg7e2G37ht);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_EookRU9opqsPtYkLwnP9o3);
            n1.CompilationHelper.SafeDispose(this.__p_F5tBVKYz7YePjkHu5YXvDf);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_UKUcJ0KljjRPNTTT512qMw);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_EgliWEbqsFHQSDc9V5oHSY);
            n1.CompilationHelper.SafeDispose(this.__p_ELvShHV97OzORGvrEbKYXh);
            n1.CompilationHelper.SafeDispose(this.__p_Sn4WIl2h8jgNEyrWl7vFr9);
            n1.CompilationHelper.SafeDispose(this.__p_B6RvDFS9gxTP7rHlBRgS5R);
            n1.CompilationHelper.SafeDispose(this.__p_O9pnMU2xuTgNMVBMcGf0mi);
            n1.CompilationHelper.SafeDispose(this.__p_EGo36afa43zNbVL6HV5goC);
            n1.CompilationHelper.SafeDispose(this.__p_HRm2QROss2dQTwJ6zaz2zh);
            n1.CompilationHelper.SafeDispose(this.__p_NfRzfAnwI1aNiW2tfHnmGX);
            n1.CompilationHelper.SafeDispose(this.__p_BFYojzYZdTpOYkXXcEvIKS);
            n1.CompilationHelper.SafeDispose(this.__p_P9LEX7PQURKN849ikWpMZg);
            n1.CompilationHelper.SafeDispose(this.__p_GurACfxLkegO8NdBVcEblV);
            n1.CompilationHelper.SafeDispose(this.__p_KmVw2zrYyvMM7DjNIIdOq7);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_FC3z6Xu0RPANqY7PdUATno);
            n1.CompilationHelper.SafeDispose(this.__p_MnkQ87CgN27OXdUg8RCdoy);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_SQEjMfbxUI9Oy03vkn1ECk);
            n1.CompilationHelper.SafeDispose(this.__p_FjaAhCwKIapOhtTArYesxP);
            n1.CompilationHelper.SafeDispose(this.__p_U8BWCraLmBKMKN4JBLCYOb);
            n1.CompilationHelper.SafeDispose(this.__p_TOFW6p4MqlkPctT79ts2Et);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_H9Dt1Few6gdPYVFRJKLEXR);
            n1.CompilationHelper.SafeDispose(this.__p_NnM74lDYxqPOnLE16RVex1);
            n1.CompilationHelper.SafeDispose(this.__p_TXrqvb2BEjEQZeQ9ODAYzr);
            n1.CompilationHelper.SafeDispose(this.__p_KzXzg2Eb1mXOJKB19FY9T2);
            n1.CompilationHelper.SafeDispose(this.__p_C7Q4tyPHJeqLtrsAXLfqQq);
            return;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.GetHelperEntity(out n43.Entity Helper_Entity_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetHelperEntity_(out Helper_Entity_Out);
            return __returnValue__;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.GetHelperEnabled(out bool Helper_Enabled_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetHelperEnabled_(out Helper_Enabled_Out);
            return __returnValue__;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.SetContext(n4.FluidContext_C Context_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = SetContext_(Context_In);
            return __returnValue__;
        }

        n11.IPostTexAdvectComputeStageProvider_I n11.IPostTexAdvectComputeStageProvider_I.GetPriority(out float Priority_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetPriority_(out Priority_Out);
            return __returnValue__;
        }

        n11.IPostTexAdvectComputeStageProvider_I n11.IPostTexAdvectComputeStageProvider_I.Update(out n33.IGraphicsRendererBase Compute_Stage_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(out Compute_Stage_Out);
            return __returnValue__;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 355322U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VqUcN5HxNdFOMoHhLiWFOb", Name = "__slot_VqUcN5HxNdFOMoHhLiWFOb")]
        public static bool __slot_VqUcN5HxNdFOMoHhLiWFOb = true;
        [n1.ElementAttribute(TracingId = 355347U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Cej794SVuqzMRxBADkocJb", Name = "__slot_Cej794SVuqzMRxBADkocJb")]
        public static float __slot_Cej794SVuqzMRxBADkocJb = 1F;
        [n1.ElementAttribute(TracingId = 355368U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BF8GPcgZazLPneZv9B0WAW", Name = "__slot_BF8GPcgZazLPneZv9B0WAW")]
        public static bool __slot_BF8GPcgZazLPneZv9B0WAW = true;
        [n1.ElementAttribute(TracingId = 355376U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Td3vKSCpVSCPOVPbY2Qwzo", Name = "__slot_Td3vKSCpVSCPOVPbY2Qwzo")]
        public static bool __slot_Td3vKSCpVSCPOVPbY2Qwzo = true;
        [n1.ElementAttribute(TracingId = 358589U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SAGxfvU2lX3PHTNcGHIqb0", Name = "__slot_SAGxfvU2lX3PHTNcGHIqb0")]
        public static float __slot_SAGxfvU2lX3PHTNcGHIqb0 = 0.0186F;
        [n1.ElementAttribute(TracingId = 358786U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ITOriOgSxkcPvx7Rzd2ziu", Name = "__slot_ITOriOgSxkcPvx7Rzd2ziu")]
        public static float __slot_ITOriOgSxkcPvx7Rzd2ziu = 0.005F;
        [n1.ElementAttribute(TracingId = 358843U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NfcKmp2W1N5MM3TQ3Pl6vD", Name = "__slot_NfcKmp2W1N5MM3TQ3Pl6vD")]
        public static n6.Vector2 __slot_NfcKmp2W1N5MM3TQ3Pl6vD = n1.CompilationHelper.Deserialize<n6.Vector2>("0, 0", false, "KeWf79wIWCVN4a6TzD33r2", "NfcKmp2W1N5MM3TQ3Pl6vD");
        [n1.ElementAttribute(TracingId = 358850U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KU4nQPk6AyiOfTTbD05lsz", Name = "__slot_KU4nQPk6AyiOfTTbD05lsz")]
        public static n6.Vector2 __slot_KU4nQPk6AyiOfTTbD05lsz = n1.CompilationHelper.Deserialize<n6.Vector2>("1, 1", false, "KeWf79wIWCVN4a6TzD33r2", "KU4nQPk6AyiOfTTbD05lsz");
        [n1.ElementAttribute(TracingId = 358887U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QXGuHtWE9tPQUDdUOHQCxf", Name = "__slot_QXGuHtWE9tPQUDdUOHQCxf")]
        public static int __slot_QXGuHtWE9tPQUDdUOHQCxf = 100000;
        [n1.ElementAttribute(TracingId = 359014U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GHzZY9oujHbNm74JzAwsoU", Name = "__slot_GHzZY9oujHbNm74JzAwsoU")]
        public static float __slot_GHzZY9oujHbNm74JzAwsoU = 1F;
        [n1.ElementAttribute(TracingId = 359102U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IRdSx4QaiBVMX7tI1IyH8M", Name = "__slot_IRdSx4QaiBVMX7tI1IyH8M")]
        public static n3.TextureFilter __slot_IRdSx4QaiBVMX7tI1IyH8M = n1.CompilationHelper.Deserialize<n3.TextureFilter>("Point", false, "KeWf79wIWCVN4a6TzD33r2", "IRdSx4QaiBVMX7tI1IyH8M");
        [n1.ElementAttribute(TracingId = 359115U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FOWcxe9XfVgPfVzcKpLAbc", Name = "__slot_FOWcxe9XfVgPfVzcKpLAbc")]
        public static float __slot_FOWcxe9XfVgPfVzcKpLAbc = 1F;
        [n1.ElementAttribute(TracingId = 355301U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QttxZw5J2zUNmV6gcqsANS", Name = "VectorField Texture")]
        public n27.Texture VectorField_Texture;
        [n1.ElementAttribute(TracingId = 355306U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CBGoYniWKz8OaTcbzApOYw", Name = "World Transformation")]
        public n6.Matrix World_Transformation;
        [n1.ElementAttribute(TracingId = 355285U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CfxqSvamgC5N3VFMVNa2Eh", Name = "Additive")]
        public bool Additive;
        [n1.ElementAttribute(TracingId = 355311U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FKhuT46cQGYL82n2tf62v3", Name = "Strength")]
        public float Strength;
        [n1.ElementAttribute(TracingId = 355359U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "PbI2ez1arpGNDLEGvKoMEZ", Name = "Enabled")]
        public bool Enabled;
        [n1.ElementAttribute(TracingId = 355364U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VhkCyjwg6Z3MpmFfGU6Hzr", Name = "Helper Enabled")]
        public bool Helper_Enabled;
        [n1.ElementAttribute(TracingId = 355385U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QPB7IDj16DCQSlPhXwxFXn", Name = "Threshold")]
        public n28.GpuValue<float> Threshold;
        [n1.ElementAttribute(TracingId = 358119U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "U8vpy6ewqfBN0yE2fLMjzA", Name = "Level")]
        public n28.GpuValue<float> Level;
        [n1.ElementAttribute(TracingId = 358126U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DrSfdQiQT0ALrqd855IPKG", Name = "Sampler")]
        public n28.GpuValue<n27.SamplerState> Sampler;
        [n1.ElementAttribute(TracingId = 358311U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IhDACeUFYQqLmlXmcgly4k", Name = "Priority")]
        public float Priority;
        [n1.ElementAttribute(TracingId = 358319U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NzU8IqaGPL1MwHQFPBdKdB", Name = "World Texture")]
        public n27.Texture World_Texture;
        [n1.ElementAttribute(TracingId = 358326U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MpgifTiosNxMzVFjugUr4J", Name = "Texture Resolution")]
        public n6.Vector2 Texture_Resolution;
        [n1.ElementAttribute(TracingId = 359140U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Errnh0AQiIJOzdHiqGDzAX", Name = "Flip X")]
        public bool Flip_X;
        [n1.ElementAttribute(TracingId = 359366U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TOI3fdyfu46P0w55SQ7zQ1", Name = "X Resolution")]
        public int X_Resolution;
        [n1.ElementAttribute(TracingId = 359370U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QtoVzhoFXetLGkWjexFe01", Name = "Y Resolution")]
        public int Y_Resolution;
        [n1.ElementAttribute(TracingId = 359391U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Cq95KIwOVehLpHr7U6ii33", Name = "Context")]
        public n4.FluidContext_C Context;
        [n1.ElementAttribute(TracingId = 358351U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UAWDxcbxBYNOzxkgjDN0Le", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<int, int>, n2.ValueTuple<n32.IComputeEffectDispatcher, n6.Int3>> __cache_UAWDxcbxBYNOzxkgjDN0Le = null;
        [n1.ElementAttribute(TracingId = 358441U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MA0ysUvySljLKsUO5XlIU7", Name = "__slot_MA0ysUvySljLKsUO5XlIU7")]
        public static int __slot_MA0ysUvySljLKsUO5XlIU7 = 8;
        [n1.ElementAttribute(TracingId = 359126U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "V5t6mr40Q5yNH3WpEdNHaB", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
        public n57.GPUIn_C<float> __p_V5t6mr40Q5yNH3WpEdNHaB;
        [n1.ElementAttribute(TracingId = 355402U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RVDYVY9EfcbLWYutkZ5IGH", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<n27.Texture, n27.Texture, bool, n4.FluidContext_C, n27.Texture, n28.GpuValue<n27.SamplerState>, n28.GpuValue<float>, n2.ValueTuple<bool, n6.Matrix, n28.GpuValue<float>, n27.Texture, n6.Vector2, bool>>, n2.ValueTuple<n28.GpuValue<n54.GpuVoid>>> __cache_RVDYVY9EfcbLWYutkZ5IGH = null;
        [n1.ElementAttribute(TracingId = 357033U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GTMawVtcHLsNFIGcnDqdB8", Name = "__slot_GTMawVtcHLsNFIGcnDqdB8")]
        public static float __slot_GTMawVtcHLsNFIGcnDqdB8 = 1F;
        [n1.ElementAttribute(TracingId = 357763U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JIW5dd3P4NvOvhsLz8r3C9", Name = "__slot_JIW5dd3P4NvOvhsLz8r3C9")]
        public static float __slot_JIW5dd3P4NvOvhsLz8r3C9 = 1F;
        [n1.ElementAttribute(TracingId = 357848U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UoxvIs43Th1LDr5N3Myx7P", Name = "__slot_UoxvIs43Th1LDr5N3Myx7P")]
        public static float __slot_UoxvIs43Th1LDr5N3Myx7P = 0.0001F;
        [n1.ElementAttribute(TracingId = 358027U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GsFr4NPbxGUP1sNdGfSTD5", Name = "__slot_GsFr4NPbxGUP1sNdGfSTD5")]
        public static float __slot_GsFr4NPbxGUP1sNdGfSTD5 = 0F;
        [n1.ElementAttribute(TracingId = 358072U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "AQyUld7UGGPQLhWAAmxpHW", Name = "__slot_AQyUld7UGGPQLhWAAmxpHW")]
        public static string __slot_AQyUld7UGGPQLhWAAmxpHW = "Velocity";
        [n1.ElementAttribute(TracingId = 358104U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Sn71uwDEkTQORA7tHwiIci", Name = "__slot_Sn71uwDEkTQORA7tHwiIci")]
        public static string __slot_Sn71uwDEkTQORA7tHwiIci = "ObstaclesGradient";
        [n1.ElementAttribute(TracingId = 355586U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "AmUJIFEdj8CM9eAno0MjPc", Name = "__slot_AmUJIFEdj8CM9eAno0MjPc")]
        public static float __slot_AmUJIFEdj8CM9eAno0MjPc = 0.09999999F;
        [n1.ElementAttribute(TracingId = 358133U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "J2dqHl61o8CMNysess9gOM", Name = "ComputeShaderGraph", IsManaged = true, IsAutoGenerated = true)]
        public n55.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2 __p_J2dqHl61o8CMNysess9gOM;
        [n1.ElementAttribute(TracingId = 358793U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DB1cfOZbgdHPk7tID41Nxl", Name = "BufferResourceHandler", IsManaged = true, IsAutoGenerated = true)]
        public n85.BufferResourceHandler_C __p_DB1cfOZbgdHPk7tID41Nxl;
        [n1.ElementAttribute(TracingId = 359210U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "D1QjSRn0tP6LtOTvBlaMPa", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<n27.Texture>, n2.ValueTuple<n6.Vector2, int, int>> __cache_D1QjSRn0tP6LtOTvBlaMPa = null;
        [n1.ElementAttribute(TracingId = 359326U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UWf0ub6EVeNOFXt08Ia2xQ", Name = "__slot_UWf0ub6EVeNOFXt08Ia2xQ")]
        public static int __slot_UWf0ub6EVeNOFXt08Ia2xQ = 8;
        [n1.ElementAttribute(TracingId = 358665U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NB9UGFvQAD8NauxrNc8IRX", Name = "Color (Particle)", IsManaged = true, IsAutoGenerated = true)]
        public n89.Color_Particle_LlPANDKLszZP94y29eyOob __p_NB9UGFvQAD8NauxrNc8IRX;
        [n1.ElementAttribute(TracingId = 358811U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "T4PKbOmcmh5LXuqOhMveA6", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
        public n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_T4PKbOmcmh5LXuqOhMveA6;
        [n1.ElementAttribute(TracingId = 358701U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JjqD1lAD5JnLG51xtUpiru", Name = "AgeOverLifeTime", IsManaged = true, IsAutoGenerated = true)]
        public n90.AgeOverLifeTime_L63dVGA8FhRMrtDsWIyrMT __p_JjqD1lAD5JnLG51xtUpiru;
        [n1.ElementAttribute(TracingId = 358691U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OPJrArTCSDLLJHEniTH0V6", Name = "OneMinus", IsManaged = true, IsAutoGenerated = true)]
        public n75.OneMinus_TZSID1klGMVLkhX7sgErcR<float> __p_OPJrArTCSDLLJHEniTH0V6;
        [n1.ElementAttribute(TracingId = 358674U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LYnKOD5g74jLfE4bITSec5", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
        public n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_LYnKOD5g74jLfE4bITSec5;
        [n1.ElementAttribute(TracingId = 358596U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VtBfs78zVbbN97Kk4eYMYR", Name = "SpriteRenderer (Particle)", IsManaged = true, IsAutoGenerated = true)]
        public n88.SpriteRenderer_Particle_C __p_VtBfs78zVbbN97Kk4eYMYR;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<float, n28.GpuValue<float>> __monadBuilder_GS23KZ8tYf0PLg7e2G37ht = n28.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<n27.Texture, n28.GpuValue<n27.Texture>> __monadBuilder_EookRU9opqsPtYkLwnP9o3 = n28.GpuValueMonadicFactory<n27.Texture>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 359090U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "F5tBVKYz7YePjkHu5YXvDf", Name = "SamplerIn (Fuse)", IsManaged = true, IsAutoGenerated = true)]
        public n62.SamplerIn_Fuse_Ow27E5pjREtLkbiG0rRYjW __p_F5tBVKYz7YePjkHu5YXvDf;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<n6.Vector2, n28.GpuValue<n6.Vector2>> __monadBuilder_UKUcJ0KljjRPNTTT512qMw = n28.GpuValueMonadicFactory<n6.Vector2>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<n6.Vector2, n28.GpuValue<n6.Vector2>> __monadBuilder_EgliWEbqsFHQSDc9V5oHSY = n28.GpuValueMonadicFactory<n6.Vector2>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 358820U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ELvShHV97OzORGvrEbKYXh", Name = "Random", IsManaged = true, IsAutoGenerated = true)]
        public n91.Random_C<n6.Vector2> __p_ELvShHV97OzORGvrEbKYXh;
        [n1.ElementAttribute(TracingId = 358900U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Sn4WIl2h8jgNEyrWl7vFr9", Name = "SampleTexture (Fuse)", IsManaged = true, IsAutoGenerated = true)]
        public n62.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n6.Vector2> __p_Sn4WIl2h8jgNEyrWl7vFr9;
        [n1.ElementAttribute(TracingId = 358936U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "B6RvDFS9gxTP7rHlBRgS5R", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
        public n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_B6RvDFS9gxTP7rHlBRgS5R;
        [n1.ElementAttribute(TracingId = 359165U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "O9pnMU2xuTgNMVBMcGf0mi", Name = "x-yz (split)", IsManaged = true, IsAutoGenerated = true)]
        public n83.xMyz_split_AJovkBTfOKGNHniZzmUeC0 __p_O9pnMU2xuTgNMVBMcGf0mi;
        [n1.ElementAttribute(TracingId = 359198U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EGo36afa43zNbVL6HV5goC", Name = "Negate", IsManaged = true, IsAutoGenerated = true)]
        public n75.Negate_P5nGfBLszbBL1YRjqmyYHC<float> __p_EGo36afa43zNbVL6HV5goC;
        [n1.ElementAttribute(TracingId = 359182U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "HRm2QROss2dQTwJ6zaz2zh", Name = "x+yz (join)", IsManaged = true, IsAutoGenerated = true)]
        public n77.xPyz_join_TfjUbK4F10LQJgxHoD2Rkv __p_HRm2QROss2dQTwJ6zaz2zh;
        [n1.ElementAttribute(TracingId = 358995U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NfRzfAnwI1aNiW2tfHnmGX", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
        public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_NfRzfAnwI1aNiW2tfHnmGX;
        [n1.ElementAttribute(TracingId = 359019U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BFYojzYZdTpOYkXXcEvIKS", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
        public n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_BFYojzYZdTpOYkXXcEvIKS;
        [n1.ElementAttribute(TracingId = 359037U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "P9LEX7PQURKN849ikWpMZg", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
        public n57.GPUIn_C<n6.Matrix> __p_P9LEX7PQURKN849ikWpMZg;
        [n1.ElementAttribute(TracingId = 358961U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GurACfxLkegO8NdBVcEblV", Name = "Mul", IsManaged = true, IsAutoGenerated = true)]
        public n75.Mul_B0P7ghpqXJiLy15iE7sIid<n6.Vector4, n6.Matrix, n6.Vector4> __p_GurACfxLkegO8NdBVcEblV;
        [n1.ElementAttribute(TracingId = 359045U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KmVw2zrYyvMM7DjNIIdOq7", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
        public n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_KmVw2zrYyvMM7DjNIIdOq7;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<float, n28.GpuValue<float>> __monadBuilder_FC3z6Xu0RPANqY7PdUATno = n28.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 358759U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MnkQ87CgN27OXdUg8RCdoy", Name = "Size (Particle)", IsManaged = true, IsAutoGenerated = true)]
        public n89.Size_Particle_PU7rrzAob6oOOELRssVZS9 __p_MnkQ87CgN27OXdUg8RCdoy;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<float, n28.GpuValue<float>> __monadBuilder_SQEjMfbxUI9Oy03vkn1ECk = n28.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 358768U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FjaAhCwKIapOhtTArYesxP", Name = "Set", IsManaged = true, IsAutoGenerated = true)]
        public n57.Set_B3yQBkmuq1cLLobAtKQD9i<float> __p_FjaAhCwKIapOhtTArYesxP;
        [n1.ElementAttribute(TracingId = 358547U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "U8BWCraLmBKMKN4JBLCYOb", Name = "ProbabilityEmitter", IsManaged = true, IsAutoGenerated = true)]
        public n87.ProbabilityEmitter_AES99Kg9CLFOmrKjo7Tiub __p_U8BWCraLmBKMKN4JBLCYOb;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n28.GpuValue<n54.GpuVoid>> __pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb = default(n12.Spread<n28.GpuValue<n54.GpuVoid>>);
        [n1.ElementAttribute(TracingId = 358506U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TOFW6p4MqlkPctT79ts2Et", Name = "IntegrateVelocityAndPosition", IsManaged = true, IsAutoGenerated = true)]
        public n86.IntegrateVelocityAndPosition_C __p_TOFW6p4MqlkPctT79ts2Et;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_H9Dt1Few6gdPYVFRJKLEXR = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 358648U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NnM74lDYxqPOnLE16RVex1", Name = "Group (GpuVoid)", IsManaged = true, IsAutoGenerated = true)]
        public n56.Group_GpuVoid_PRMY4HYRXTzM4hzmICywZJ __p_NnM74lDYxqPOnLE16RVex1;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n28.GpuValue<n54.GpuVoid>> __pin_group_Input_In_NnM74lDYxqPOnLE16RVex1 = default(n12.Spread<n28.GpuValue<n54.GpuVoid>>);
        [n1.ElementAttribute(TracingId = 358514U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TXrqvb2BEjEQZeQ9ODAYzr", Name = "ComputeStage", IsManaged = true, IsAutoGenerated = true)]
        public n85.ComputeStage_C __p_TXrqvb2BEjEQZeQ9ODAYzr;
        [n1.ElementAttribute(TracingId = 358715U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KzXzg2Eb1mXOJKB19FY9T2", Name = "ComputeSystem (Spectral)", IsManaged = true, IsAutoGenerated = true)]
        public n85.ComputeSystem_Spectral_C __p_KzXzg2Eb1mXOJKB19FY9T2;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n12.Spread<n85.IUpdateGraph_I> __c_GjedOUE793ULaHlz9ymRZ1 = n1.CompilationHelper.Deserialize<n12.Spread<n85.IUpdateGraph_I>>("<Value xmlns=\"property\" />", true, "KeWf79wIWCVN4a6TzD33r2", "GjedOUE793ULaHlz9ymRZ1");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n85.IComputeStage_I> __pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2 = default(n12.Spread<n85.IComputeStage_I>);
        [n1.ElementAttribute(TracingId = 359060U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "C7Q4tyPHJeqLtrsAXLfqQq", Name = "SamplerState", IsManaged = true, IsAutoGenerated = true, NodeName = "SamplerState", NodeCategory = "Stride.Graphics.Advanced")]
        public n1.IVLNode __p_C7Q4tyPHJeqLtrsAXLfqQq;
        static AugmentedTexture2DVectorField_Fluid3D_C()
        {
        }

        public AugmentedTexture2DVectorField_Fluid3D_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AugmentedTexture2DVectorField_Fluid3D_C(AugmentedTexture2DVectorField_Fluid3D_C other): base(other)
        {
            this.VectorField_Texture = other.VectorField_Texture;
            this.World_Transformation = other.World_Transformation;
            this.Additive = other.Additive;
            this.Strength = other.Strength;
            this.Enabled = other.Enabled;
            this.Helper_Enabled = other.Helper_Enabled;
            this.Threshold = other.Threshold;
            this.Level = other.Level;
            this.Sampler = other.Sampler;
            this.Priority = other.Priority;
            this.World_Texture = other.World_Texture;
            this.Texture_Resolution = other.Texture_Resolution;
            this.Flip_X = other.Flip_X;
            this.X_Resolution = other.X_Resolution;
            this.Y_Resolution = other.Y_Resolution;
            this.Context = other.Context;
            this.__cache_UAWDxcbxBYNOzxkgjDN0Le = other.__cache_UAWDxcbxBYNOzxkgjDN0Le;
            this.__p_V5t6mr40Q5yNH3WpEdNHaB = other.__p_V5t6mr40Q5yNH3WpEdNHaB;
            this.__cache_RVDYVY9EfcbLWYutkZ5IGH = other.__cache_RVDYVY9EfcbLWYutkZ5IGH;
            this.__p_J2dqHl61o8CMNysess9gOM = other.__p_J2dqHl61o8CMNysess9gOM;
            this.__p_DB1cfOZbgdHPk7tID41Nxl = other.__p_DB1cfOZbgdHPk7tID41Nxl;
            this.__cache_D1QjSRn0tP6LtOTvBlaMPa = other.__cache_D1QjSRn0tP6LtOTvBlaMPa;
            this.__p_NB9UGFvQAD8NauxrNc8IRX = other.__p_NB9UGFvQAD8NauxrNc8IRX;
            this.__p_T4PKbOmcmh5LXuqOhMveA6 = other.__p_T4PKbOmcmh5LXuqOhMveA6;
            this.__p_JjqD1lAD5JnLG51xtUpiru = other.__p_JjqD1lAD5JnLG51xtUpiru;
            this.__p_OPJrArTCSDLLJHEniTH0V6 = other.__p_OPJrArTCSDLLJHEniTH0V6;
            this.__p_LYnKOD5g74jLfE4bITSec5 = other.__p_LYnKOD5g74jLfE4bITSec5;
            this.__p_VtBfs78zVbbN97Kk4eYMYR = other.__p_VtBfs78zVbbN97Kk4eYMYR;
            this.__monadBuilder_GS23KZ8tYf0PLg7e2G37ht = other.__monadBuilder_GS23KZ8tYf0PLg7e2G37ht;
            this.__monadBuilder_EookRU9opqsPtYkLwnP9o3 = other.__monadBuilder_EookRU9opqsPtYkLwnP9o3;
            this.__p_F5tBVKYz7YePjkHu5YXvDf = other.__p_F5tBVKYz7YePjkHu5YXvDf;
            this.__monadBuilder_UKUcJ0KljjRPNTTT512qMw = other.__monadBuilder_UKUcJ0KljjRPNTTT512qMw;
            this.__monadBuilder_EgliWEbqsFHQSDc9V5oHSY = other.__monadBuilder_EgliWEbqsFHQSDc9V5oHSY;
            this.__p_ELvShHV97OzORGvrEbKYXh = other.__p_ELvShHV97OzORGvrEbKYXh;
            this.__p_Sn4WIl2h8jgNEyrWl7vFr9 = other.__p_Sn4WIl2h8jgNEyrWl7vFr9;
            this.__p_B6RvDFS9gxTP7rHlBRgS5R = other.__p_B6RvDFS9gxTP7rHlBRgS5R;
            this.__p_O9pnMU2xuTgNMVBMcGf0mi = other.__p_O9pnMU2xuTgNMVBMcGf0mi;
            this.__p_EGo36afa43zNbVL6HV5goC = other.__p_EGo36afa43zNbVL6HV5goC;
            this.__p_HRm2QROss2dQTwJ6zaz2zh = other.__p_HRm2QROss2dQTwJ6zaz2zh;
            this.__p_NfRzfAnwI1aNiW2tfHnmGX = other.__p_NfRzfAnwI1aNiW2tfHnmGX;
            this.__p_BFYojzYZdTpOYkXXcEvIKS = other.__p_BFYojzYZdTpOYkXXcEvIKS;
            this.__p_P9LEX7PQURKN849ikWpMZg = other.__p_P9LEX7PQURKN849ikWpMZg;
            this.__p_GurACfxLkegO8NdBVcEblV = other.__p_GurACfxLkegO8NdBVcEblV;
            this.__p_KmVw2zrYyvMM7DjNIIdOq7 = other.__p_KmVw2zrYyvMM7DjNIIdOq7;
            this.__monadBuilder_FC3z6Xu0RPANqY7PdUATno = other.__monadBuilder_FC3z6Xu0RPANqY7PdUATno;
            this.__p_MnkQ87CgN27OXdUg8RCdoy = other.__p_MnkQ87CgN27OXdUg8RCdoy;
            this.__monadBuilder_SQEjMfbxUI9Oy03vkn1ECk = other.__monadBuilder_SQEjMfbxUI9Oy03vkn1ECk;
            this.__p_FjaAhCwKIapOhtTArYesxP = other.__p_FjaAhCwKIapOhtTArYesxP;
            this.__p_U8BWCraLmBKMKN4JBLCYOb = other.__p_U8BWCraLmBKMKN4JBLCYOb;
            this.__pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb = other.__pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb;
            this.__p_TOFW6p4MqlkPctT79ts2Et = other.__p_TOFW6p4MqlkPctT79ts2Et;
            this.__monadBuilder_H9Dt1Few6gdPYVFRJKLEXR = other.__monadBuilder_H9Dt1Few6gdPYVFRJKLEXR;
            this.__p_NnM74lDYxqPOnLE16RVex1 = other.__p_NnM74lDYxqPOnLE16RVex1;
            this.__pin_group_Input_In_NnM74lDYxqPOnLE16RVex1 = other.__pin_group_Input_In_NnM74lDYxqPOnLE16RVex1;
            this.__p_TXrqvb2BEjEQZeQ9ODAYzr = other.__p_TXrqvb2BEjEQZeQ9ODAYzr;
            this.__p_KzXzg2Eb1mXOJKB19FY9T2 = other.__p_KzXzg2Eb1mXOJKB19FY9T2;
            this.__pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2 = other.__pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2;
            this.__p_C7Q4tyPHJeqLtrsAXLfqQq = other.__p_C7Q4tyPHJeqLtrsAXLfqQq;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "VectorField_Texture", in VectorField_Texture), n1.CompilationHelper.GetValueOrExisting(values, "World_Transformation", in World_Transformation), n1.CompilationHelper.GetValueOrExisting(values, "Additive", in Additive), n1.CompilationHelper.GetValueOrExisting(values, "Strength", in Strength), n1.CompilationHelper.GetValueOrExisting(values, "Enabled", in Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Helper_Enabled", in Helper_Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Threshold", in Threshold), n1.CompilationHelper.GetValueOrExisting(values, "Level", in Level), n1.CompilationHelper.GetValueOrExisting(values, "Sampler", in Sampler), n1.CompilationHelper.GetValueOrExisting(values, "Priority", in Priority), n1.CompilationHelper.GetValueOrExisting(values, "World_Texture", in World_Texture), n1.CompilationHelper.GetValueOrExisting(values, "Texture_Resolution", in Texture_Resolution), n1.CompilationHelper.GetValueOrExisting(values, "Flip_X", in Flip_X), n1.CompilationHelper.GetValueOrExisting(values, "X_Resolution", in X_Resolution), n1.CompilationHelper.GetValueOrExisting(values, "Y_Resolution", in Y_Resolution), n1.CompilationHelper.GetValueOrExisting(values, "Context", in Context), n1.CompilationHelper.GetValueOrExisting(values, "__cache_UAWDxcbxBYNOzxkgjDN0Le", in __cache_UAWDxcbxBYNOzxkgjDN0Le), n1.CompilationHelper.GetValueOrExisting(values, "__p_V5t6mr40Q5yNH3WpEdNHaB", in __p_V5t6mr40Q5yNH3WpEdNHaB), n1.CompilationHelper.GetValueOrExisting(values, "__cache_RVDYVY9EfcbLWYutkZ5IGH", in __cache_RVDYVY9EfcbLWYutkZ5IGH), n1.CompilationHelper.GetValueOrExisting(values, "__p_J2dqHl61o8CMNysess9gOM", in __p_J2dqHl61o8CMNysess9gOM), n1.CompilationHelper.GetValueOrExisting(values, "__p_DB1cfOZbgdHPk7tID41Nxl", in __p_DB1cfOZbgdHPk7tID41Nxl), n1.CompilationHelper.GetValueOrExisting(values, "__cache_D1QjSRn0tP6LtOTvBlaMPa", in __cache_D1QjSRn0tP6LtOTvBlaMPa), n1.CompilationHelper.GetValueOrExisting(values, "__p_NB9UGFvQAD8NauxrNc8IRX", in __p_NB9UGFvQAD8NauxrNc8IRX), n1.CompilationHelper.GetValueOrExisting(values, "__p_T4PKbOmcmh5LXuqOhMveA6", in __p_T4PKbOmcmh5LXuqOhMveA6), n1.CompilationHelper.GetValueOrExisting(values, "__p_JjqD1lAD5JnLG51xtUpiru", in __p_JjqD1lAD5JnLG51xtUpiru), n1.CompilationHelper.GetValueOrExisting(values, "__p_OPJrArTCSDLLJHEniTH0V6", in __p_OPJrArTCSDLLJHEniTH0V6), n1.CompilationHelper.GetValueOrExisting(values, "__p_LYnKOD5g74jLfE4bITSec5", in __p_LYnKOD5g74jLfE4bITSec5), n1.CompilationHelper.GetValueOrExisting(values, "__p_VtBfs78zVbbN97Kk4eYMYR", in __p_VtBfs78zVbbN97Kk4eYMYR), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_GS23KZ8tYf0PLg7e2G37ht", in __monadBuilder_GS23KZ8tYf0PLg7e2G37ht), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_EookRU9opqsPtYkLwnP9o3", in __monadBuilder_EookRU9opqsPtYkLwnP9o3), n1.CompilationHelper.GetValueOrExisting(values, "__p_F5tBVKYz7YePjkHu5YXvDf", in __p_F5tBVKYz7YePjkHu5YXvDf), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_UKUcJ0KljjRPNTTT512qMw", in __monadBuilder_UKUcJ0KljjRPNTTT512qMw), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_EgliWEbqsFHQSDc9V5oHSY", in __monadBuilder_EgliWEbqsFHQSDc9V5oHSY), n1.CompilationHelper.GetValueOrExisting(values, "__p_ELvShHV97OzORGvrEbKYXh", in __p_ELvShHV97OzORGvrEbKYXh), n1.CompilationHelper.GetValueOrExisting(values, "__p_Sn4WIl2h8jgNEyrWl7vFr9", in __p_Sn4WIl2h8jgNEyrWl7vFr9), n1.CompilationHelper.GetValueOrExisting(values, "__p_B6RvDFS9gxTP7rHlBRgS5R", in __p_B6RvDFS9gxTP7rHlBRgS5R), n1.CompilationHelper.GetValueOrExisting(values, "__p_O9pnMU2xuTgNMVBMcGf0mi", in __p_O9pnMU2xuTgNMVBMcGf0mi), n1.CompilationHelper.GetValueOrExisting(values, "__p_EGo36afa43zNbVL6HV5goC", in __p_EGo36afa43zNbVL6HV5goC), n1.CompilationHelper.GetValueOrExisting(values, "__p_HRm2QROss2dQTwJ6zaz2zh", in __p_HRm2QROss2dQTwJ6zaz2zh), n1.CompilationHelper.GetValueOrExisting(values, "__p_NfRzfAnwI1aNiW2tfHnmGX", in __p_NfRzfAnwI1aNiW2tfHnmGX), n1.CompilationHelper.GetValueOrExisting(values, "__p_BFYojzYZdTpOYkXXcEvIKS", in __p_BFYojzYZdTpOYkXXcEvIKS), n1.CompilationHelper.GetValueOrExisting(values, "__p_P9LEX7PQURKN849ikWpMZg", in __p_P9LEX7PQURKN849ikWpMZg), n1.CompilationHelper.GetValueOrExisting(values, "__p_GurACfxLkegO8NdBVcEblV", in __p_GurACfxLkegO8NdBVcEblV), n1.CompilationHelper.GetValueOrExisting(values, "__p_KmVw2zrYyvMM7DjNIIdOq7", in __p_KmVw2zrYyvMM7DjNIIdOq7), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_FC3z6Xu0RPANqY7PdUATno", in __monadBuilder_FC3z6Xu0RPANqY7PdUATno), n1.CompilationHelper.GetValueOrExisting(values, "__p_MnkQ87CgN27OXdUg8RCdoy", in __p_MnkQ87CgN27OXdUg8RCdoy), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_SQEjMfbxUI9Oy03vkn1ECk", in __monadBuilder_SQEjMfbxUI9Oy03vkn1ECk), n1.CompilationHelper.GetValueOrExisting(values, "__p_FjaAhCwKIapOhtTArYesxP", in __p_FjaAhCwKIapOhtTArYesxP), n1.CompilationHelper.GetValueOrExisting(values, "__p_U8BWCraLmBKMKN4JBLCYOb", in __p_U8BWCraLmBKMKN4JBLCYOb), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb", in __pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb), n1.CompilationHelper.GetValueOrExisting(values, "__p_TOFW6p4MqlkPctT79ts2Et", in __p_TOFW6p4MqlkPctT79ts2Et), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_H9Dt1Few6gdPYVFRJKLEXR", in __monadBuilder_H9Dt1Few6gdPYVFRJKLEXR), n1.CompilationHelper.GetValueOrExisting(values, "__p_NnM74lDYxqPOnLE16RVex1", in __p_NnM74lDYxqPOnLE16RVex1), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_NnM74lDYxqPOnLE16RVex1", in __pin_group_Input_In_NnM74lDYxqPOnLE16RVex1), n1.CompilationHelper.GetValueOrExisting(values, "__p_TXrqvb2BEjEQZeQ9ODAYzr", in __p_TXrqvb2BEjEQZeQ9ODAYzr), n1.CompilationHelper.GetValueOrExisting(values, "__p_KzXzg2Eb1mXOJKB19FY9T2", in __p_KzXzg2Eb1mXOJKB19FY9T2), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2", in __pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2), n1.CompilationHelper.GetValueOrExisting(values, "__p_C7Q4tyPHJeqLtrsAXLfqQq", in __p_C7Q4tyPHJeqLtrsAXLfqQq));
        }

        internal AugmentedTexture2DVectorField_Fluid3D_C __WITH__(n27.Texture VectorField_Texture, n6.Matrix World_Transformation, bool Additive, float Strength, bool Enabled, bool Helper_Enabled, n28.GpuValue<float> Threshold, n28.GpuValue<float> Level, n28.GpuValue<n27.SamplerState> Sampler, float Priority, n27.Texture World_Texture, n6.Vector2 Texture_Resolution, bool Flip_X, int X_Resolution, int Y_Resolution, n4.FluidContext_C Context, n13.Manager<n2.ValueTuple<int, int>, n2.ValueTuple<n32.IComputeEffectDispatcher, n6.Int3>> __cache_UAWDxcbxBYNOzxkgjDN0Le, n57.GPUIn_C<float> __p_V5t6mr40Q5yNH3WpEdNHaB, n13.Manager<n2.ValueTuple<n27.Texture, n27.Texture, bool, n4.FluidContext_C, n27.Texture, n28.GpuValue<n27.SamplerState>, n28.GpuValue<float>, n2.ValueTuple<bool, n6.Matrix, n28.GpuValue<float>, n27.Texture, n6.Vector2, bool>>, n2.ValueTuple<n28.GpuValue<n54.GpuVoid>>> __cache_RVDYVY9EfcbLWYutkZ5IGH, n55.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2 __p_J2dqHl61o8CMNysess9gOM, n85.BufferResourceHandler_C __p_DB1cfOZbgdHPk7tID41Nxl, n13.Manager<n2.ValueTuple<n27.Texture>, n2.ValueTuple<n6.Vector2, int, int>> __cache_D1QjSRn0tP6LtOTvBlaMPa, n89.Color_Particle_LlPANDKLszZP94y29eyOob __p_NB9UGFvQAD8NauxrNc8IRX, n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_T4PKbOmcmh5LXuqOhMveA6, n90.AgeOverLifeTime_L63dVGA8FhRMrtDsWIyrMT __p_JjqD1lAD5JnLG51xtUpiru, n75.OneMinus_TZSID1klGMVLkhX7sgErcR<float> __p_OPJrArTCSDLLJHEniTH0V6, n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_LYnKOD5g74jLfE4bITSec5, n88.SpriteRenderer_Particle_C __p_VtBfs78zVbbN97Kk4eYMYR, n1.IMonadBuilder<float, n28.GpuValue<float>> __monadBuilder_GS23KZ8tYf0PLg7e2G37ht, n1.IMonadBuilder<n27.Texture, n28.GpuValue<n27.Texture>> __monadBuilder_EookRU9opqsPtYkLwnP9o3, n62.SamplerIn_Fuse_Ow27E5pjREtLkbiG0rRYjW __p_F5tBVKYz7YePjkHu5YXvDf, n1.IMonadBuilder<n6.Vector2, n28.GpuValue<n6.Vector2>> __monadBuilder_UKUcJ0KljjRPNTTT512qMw, n1.IMonadBuilder<n6.Vector2, n28.GpuValue<n6.Vector2>> __monadBuilder_EgliWEbqsFHQSDc9V5oHSY, n91.Random_C<n6.Vector2> __p_ELvShHV97OzORGvrEbKYXh, n62.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n6.Vector2> __p_Sn4WIl2h8jgNEyrWl7vFr9, n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_B6RvDFS9gxTP7rHlBRgS5R, n83.xMyz_split_AJovkBTfOKGNHniZzmUeC0 __p_O9pnMU2xuTgNMVBMcGf0mi, n75.Negate_P5nGfBLszbBL1YRjqmyYHC<float> __p_EGo36afa43zNbVL6HV5goC, n77.xPyz_join_TfjUbK4F10LQJgxHoD2Rkv __p_HRm2QROss2dQTwJ6zaz2zh, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_NfRzfAnwI1aNiW2tfHnmGX, n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_BFYojzYZdTpOYkXXcEvIKS, n57.GPUIn_C<n6.Matrix> __p_P9LEX7PQURKN849ikWpMZg, n75.Mul_B0P7ghpqXJiLy15iE7sIid<n6.Vector4, n6.Matrix, n6.Vector4> __p_GurACfxLkegO8NdBVcEblV, n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_KmVw2zrYyvMM7DjNIIdOq7, n1.IMonadBuilder<float, n28.GpuValue<float>> __monadBuilder_FC3z6Xu0RPANqY7PdUATno, n89.Size_Particle_PU7rrzAob6oOOELRssVZS9 __p_MnkQ87CgN27OXdUg8RCdoy, n1.IMonadBuilder<float, n28.GpuValue<float>> __monadBuilder_SQEjMfbxUI9Oy03vkn1ECk, n57.Set_B3yQBkmuq1cLLobAtKQD9i<float> __p_FjaAhCwKIapOhtTArYesxP, n87.ProbabilityEmitter_AES99Kg9CLFOmrKjo7Tiub __p_U8BWCraLmBKMKN4JBLCYOb, n12.Spread<n28.GpuValue<n54.GpuVoid>> __pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb, n86.IntegrateVelocityAndPosition_C __p_TOFW6p4MqlkPctT79ts2Et, n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_H9Dt1Few6gdPYVFRJKLEXR, n56.Group_GpuVoid_PRMY4HYRXTzM4hzmICywZJ __p_NnM74lDYxqPOnLE16RVex1, n12.Spread<n28.GpuValue<n54.GpuVoid>> __pin_group_Input_In_NnM74lDYxqPOnLE16RVex1, n85.ComputeStage_C __p_TXrqvb2BEjEQZeQ9ODAYzr, n85.ComputeSystem_Spectral_C __p_KzXzg2Eb1mXOJKB19FY9T2, n12.Spread<n85.IComputeStage_I> __pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2, n1.IVLNode __p_C7Q4tyPHJeqLtrsAXLfqQq)
        {
            n11.AugmentedTexture2DVectorField_Fluid3D_C that_0 = this;
            this.VectorField_Texture = VectorField_Texture;
            this.World_Transformation = World_Transformation;
            this.Additive = Additive;
            this.Strength = Strength;
            this.Enabled = Enabled;
            this.Helper_Enabled = Helper_Enabled;
            this.Threshold = Threshold;
            this.Level = Level;
            this.Sampler = Sampler;
            this.Priority = Priority;
            this.World_Texture = World_Texture;
            this.Texture_Resolution = Texture_Resolution;
            this.Flip_X = Flip_X;
            this.X_Resolution = X_Resolution;
            this.Y_Resolution = Y_Resolution;
            this.Context = Context;
            this.__cache_UAWDxcbxBYNOzxkgjDN0Le = __cache_UAWDxcbxBYNOzxkgjDN0Le;
            this.__p_V5t6mr40Q5yNH3WpEdNHaB = __p_V5t6mr40Q5yNH3WpEdNHaB;
            this.__cache_RVDYVY9EfcbLWYutkZ5IGH = __cache_RVDYVY9EfcbLWYutkZ5IGH;
            this.__p_J2dqHl61o8CMNysess9gOM = __p_J2dqHl61o8CMNysess9gOM;
            this.__p_DB1cfOZbgdHPk7tID41Nxl = __p_DB1cfOZbgdHPk7tID41Nxl;
            this.__cache_D1QjSRn0tP6LtOTvBlaMPa = __cache_D1QjSRn0tP6LtOTvBlaMPa;
            this.__p_NB9UGFvQAD8NauxrNc8IRX = __p_NB9UGFvQAD8NauxrNc8IRX;
            this.__p_T4PKbOmcmh5LXuqOhMveA6 = __p_T4PKbOmcmh5LXuqOhMveA6;
            this.__p_JjqD1lAD5JnLG51xtUpiru = __p_JjqD1lAD5JnLG51xtUpiru;
            this.__p_OPJrArTCSDLLJHEniTH0V6 = __p_OPJrArTCSDLLJHEniTH0V6;
            this.__p_LYnKOD5g74jLfE4bITSec5 = __p_LYnKOD5g74jLfE4bITSec5;
            this.__p_VtBfs78zVbbN97Kk4eYMYR = __p_VtBfs78zVbbN97Kk4eYMYR;
            this.__monadBuilder_GS23KZ8tYf0PLg7e2G37ht = __monadBuilder_GS23KZ8tYf0PLg7e2G37ht;
            this.__monadBuilder_EookRU9opqsPtYkLwnP9o3 = __monadBuilder_EookRU9opqsPtYkLwnP9o3;
            this.__p_F5tBVKYz7YePjkHu5YXvDf = __p_F5tBVKYz7YePjkHu5YXvDf;
            this.__monadBuilder_UKUcJ0KljjRPNTTT512qMw = __monadBuilder_UKUcJ0KljjRPNTTT512qMw;
            this.__monadBuilder_EgliWEbqsFHQSDc9V5oHSY = __monadBuilder_EgliWEbqsFHQSDc9V5oHSY;
            this.__p_ELvShHV97OzORGvrEbKYXh = __p_ELvShHV97OzORGvrEbKYXh;
            this.__p_Sn4WIl2h8jgNEyrWl7vFr9 = __p_Sn4WIl2h8jgNEyrWl7vFr9;
            this.__p_B6RvDFS9gxTP7rHlBRgS5R = __p_B6RvDFS9gxTP7rHlBRgS5R;
            this.__p_O9pnMU2xuTgNMVBMcGf0mi = __p_O9pnMU2xuTgNMVBMcGf0mi;
            this.__p_EGo36afa43zNbVL6HV5goC = __p_EGo36afa43zNbVL6HV5goC;
            this.__p_HRm2QROss2dQTwJ6zaz2zh = __p_HRm2QROss2dQTwJ6zaz2zh;
            this.__p_NfRzfAnwI1aNiW2tfHnmGX = __p_NfRzfAnwI1aNiW2tfHnmGX;
            this.__p_BFYojzYZdTpOYkXXcEvIKS = __p_BFYojzYZdTpOYkXXcEvIKS;
            this.__p_P9LEX7PQURKN849ikWpMZg = __p_P9LEX7PQURKN849ikWpMZg;
            this.__p_GurACfxLkegO8NdBVcEblV = __p_GurACfxLkegO8NdBVcEblV;
            this.__p_KmVw2zrYyvMM7DjNIIdOq7 = __p_KmVw2zrYyvMM7DjNIIdOq7;
            this.__monadBuilder_FC3z6Xu0RPANqY7PdUATno = __monadBuilder_FC3z6Xu0RPANqY7PdUATno;
            this.__p_MnkQ87CgN27OXdUg8RCdoy = __p_MnkQ87CgN27OXdUg8RCdoy;
            this.__monadBuilder_SQEjMfbxUI9Oy03vkn1ECk = __monadBuilder_SQEjMfbxUI9Oy03vkn1ECk;
            this.__p_FjaAhCwKIapOhtTArYesxP = __p_FjaAhCwKIapOhtTArYesxP;
            this.__p_U8BWCraLmBKMKN4JBLCYOb = __p_U8BWCraLmBKMKN4JBLCYOb;
            this.__pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb = __pin_group_Custom_In_U8BWCraLmBKMKN4JBLCYOb;
            this.__p_TOFW6p4MqlkPctT79ts2Et = __p_TOFW6p4MqlkPctT79ts2Et;
            this.__monadBuilder_H9Dt1Few6gdPYVFRJKLEXR = __monadBuilder_H9Dt1Few6gdPYVFRJKLEXR;
            this.__p_NnM74lDYxqPOnLE16RVex1 = __p_NnM74lDYxqPOnLE16RVex1;
            this.__pin_group_Input_In_NnM74lDYxqPOnLE16RVex1 = __pin_group_Input_In_NnM74lDYxqPOnLE16RVex1;
            this.__p_TXrqvb2BEjEQZeQ9ODAYzr = __p_TXrqvb2BEjEQZeQ9ODAYzr;
            this.__p_KzXzg2Eb1mXOJKB19FY9T2 = __p_KzXzg2Eb1mXOJKB19FY9T2;
            this.__pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2 = __pin_group_Input_In_KzXzg2Eb1mXOJKB19FY9T2;
            this.__p_C7Q4tyPHJeqLtrsAXLfqQq = __p_C7Q4tyPHJeqLtrsAXLfqQq;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EcejEp9Irj4OzVKq7M6f8r", Name = "__EcejEp9Irj4OzVKq7M6f8r")]
        [n2.SerializableAttribute]
        public class __EcejEp9Irj4OzVKq7M6f8r : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Muhpax2oZ9bLYlU9YqNMmV);
                return;
            }

            [n1.ElementAttribute(TracingId = 358386U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Muhpax2oZ9bLYlU9YqNMmV", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
            public n1.IVLNode __p_Muhpax2oZ9bLYlU9YqNMmV;
            [n1.ElementAttribute(TracingId = 358409U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LOBOhPNpCzDOtDAao2Q0cK", Name = "__slot_LOBOhPNpCzDOtDAao2Q0cK")]
            public n6.Int3 __slot_LOBOhPNpCzDOtDAao2Q0cK;
            public __EcejEp9Irj4OzVKq7M6f8r(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __EcejEp9Irj4OzVKq7M6f8r(__EcejEp9Irj4OzVKq7M6f8r other): base(other)
            {
                this.__p_Muhpax2oZ9bLYlU9YqNMmV = other.__p_Muhpax2oZ9bLYlU9YqNMmV;
                this.__slot_LOBOhPNpCzDOtDAao2Q0cK = other.__slot_LOBOhPNpCzDOtDAao2Q0cK;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Muhpax2oZ9bLYlU9YqNMmV", in __p_Muhpax2oZ9bLYlU9YqNMmV), n1.CompilationHelper.GetValueOrExisting(values, "__slot_LOBOhPNpCzDOtDAao2Q0cK", in __slot_LOBOhPNpCzDOtDAao2Q0cK));
            }

            internal __EcejEp9Irj4OzVKq7M6f8r __WITH__(n1.IVLNode __p_Muhpax2oZ9bLYlU9YqNMmV, n6.Int3 __slot_LOBOhPNpCzDOtDAao2Q0cK)
            {
                __EcejEp9Irj4OzVKq7M6f8r that_0 = this;
                this.__p_Muhpax2oZ9bLYlU9YqNMmV = __p_Muhpax2oZ9bLYlU9YqNMmV;
                this.__slot_LOBOhPNpCzDOtDAao2Q0cK = __slot_LOBOhPNpCzDOtDAao2Q0cK;
                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "C9mAwGBsbceMDNVros5sDA", Name = "__C9mAwGBsbceMDNVros5sDA")]
        [n2.SerializableAttribute]
        public class __C9mAwGBsbceMDNVros5sDA : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_NlR9zBPt78lQdHZlzJXgIt);
                n1.CompilationHelper.SafeDispose(this.__p_B4sahqLbnHcORFaoiwoF13);
                n1.CompilationHelper.SafeDispose(this.__p_OEQyaPLeoFPNLI9Qsy9ugc);
                n1.CompilationHelper.SafeDispose(this.__p_DCJ7ygOPcm0N1b0eWbOoab);
                n1.CompilationHelper.SafeDispose(this.__p_EXf0M02nN3ZOebwIjZiW6n);
                n1.CompilationHelper.SafeDispose(this.__p_U9123t5EgJCNabvmwRdz6g);
                n1.CompilationHelper.SafeDispose(this.__p_EPjJp86lllMMMxfs8V3Brf);
                n1.CompilationHelper.SafeDispose(this.__p_Qe6BRlJgbdqOgZ0L1zLs2q);
                n1.CompilationHelper.SafeDispose(this.__p_J5xamYbncw4Nz3vJJCHdMa);
                n1.CompilationHelper.SafeDispose(this.__p_QBfAM7LFIlEQKjKvLZivkC);
                n1.CompilationHelper.SafeDispose(this.__p_Lh28ioPoApjMEeDpBRf89D);
                n1.CompilationHelper.SafeDispose(this.__p_SlgnLIwHScwLkPTYSxhGdJ);
                n1.CompilationHelper.SafeDispose(this.__p_Vk6I19HMkMZMQrAcvK79VF);
                n1.CompilationHelper.SafeDispose(this.__p_VGYpJekRixkMkICjCiR22a);
                n1.CompilationHelper.SafeDispose(this.__p_G0gzyyus8Q5PcmuUjOIR4R);
                n1.CompilationHelper.SafeDispose(this.__p_GjoP8uR2na9LVa0T0vslcR);
                n1.CompilationHelper.SafeDispose(this.__p_KkjuVnbuKzjQbt6PjsgNv1);
                n1.CompilationHelper.SafeDispose(this.__p_MRsP3ujFKbLLeNBfiB4DnB);
                n1.CompilationHelper.SafeDispose(this.__p_EWKGBvR711IOm1itym0Ryv);
                n1.CompilationHelper.SafeDispose(this.__p_ASxvz3suRV7O2KjvOP8o5A);
                n1.CompilationHelper.SafeDispose(this.__p_SMIyUHVq5JaNQbhadshKIs);
                n1.CompilationHelper.SafeDispose(this.__p_S60yboHKYMdMudOyJzgqY0);
                n1.CompilationHelper.SafeDispose(this.__p_F5O6rgf6OqHP9AsRJyGPGi);
                n1.CompilationHelper.SafeDispose(this.__p_Uq8tAa9olcXQQdO8ImqcwD);
                n1.CompilationHelper.SafeDispose(this.__p_MdL6aDqoplyLUCZ2bYhrDZ);
                n1.CompilationHelper.SafeDispose(this.__p_MCtdPtr9MjuPt42vKzsmfk);
                n1.CompilationHelper.SafeDispose(this.__p_Or4mozdOD62MZnFtwwGali);
                n1.CompilationHelper.SafeDispose(this.__p_Gpl9GZ5CGHiOfJy8Qbq68J);
                n1.CompilationHelper.SafeDispose(this.__p_BrcrG3zSybxObQmQ2n9FYs);
                n1.CompilationHelper.SafeDispose(this.__p_VsTjyIPH8K4Odcau0Lnggg);
                n1.CompilationHelper.SafeDispose(this.__p_F2kzjm0knY1LaZ3X5rA2i3);
                n1.CompilationHelper.SafeDispose(this.__p_TMQtR7fQRuTPrAnWVfo1ug);
                n1.CompilationHelper.SafeDispose(this.__p_Mf1I9F0Gl1qNDq4Fgs9mje);
                n1.CompilationHelper.SafeDispose(this.__p_OCMH1YHplwnQOs2c1Peuvx);
                n1.CompilationHelper.SafeDispose(this.__p_RgPPsUAfRIFLueFHYGmG4J);
                n1.CompilationHelper.SafeDispose(this.__p_QdG3xLb1SfQLd63exGRrnb);
                n1.CompilationHelper.SafeDispose(this.__p_Kmge7kpo6cPPL16ywaBWa7);
                n1.CompilationHelper.SafeDispose(this.__p_IrdLHflPjOhK98vlxajKrE);
                n1.CompilationHelper.SafeDispose(this.__p_FZFZaMga7C0MHSY2momT7T);
                n1.CompilationHelper.SafeDispose(this.__p_EObAHtzUwYDN4QQ1pwnKGm);
                n1.CompilationHelper.SafeDispose(this.__p_JkJjwhrlRt4MnIeRBF64VP);
                n1.CompilationHelper.SafeDispose(this.__p_Txg022TJAfkQXeshliMXZ5);
                n1.CompilationHelper.SafeDispose(this.__p_A5YUKxwLfwpLqlzzjjHzHx);
                n1.CompilationHelper.SafeDispose(this.__p_RzfrLKpqe8NN1rRC8gF1Mf);
                n1.CompilationHelper.SafeDispose(this.__p_BG2VoIHhrfyOPgDiP89lnu);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_R1rAY6Goo41OQzfrET27Zh);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_BnuBSRDzsQ7QIMBzKCIRVn);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_Hx9OgGroD8CP35UMHfk3tH);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_ITALcgI0eOQQFbYNaPaL2l);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_C6gi0LD9PAjNdXIptcrj8P);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_HZ7FLxXj55kO0bZR8BoN80);
                return;
            }

            [n1.ElementAttribute(TracingId = 355511U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NlR9zBPt78lQdHZlzJXgIt", Name = "TextureGet", IsManaged = true, IsAutoGenerated = true)]
            public n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, float> __p_NlR9zBPt78lQdHZlzJXgIt;
            [n1.ElementAttribute(TracingId = 355538U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "B4sahqLbnHcORFaoiwoF13", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
            public n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_B4sahqLbnHcORFaoiwoF13;
            [n1.ElementAttribute(TracingId = 355553U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OEQyaPLeoFPNLI9Qsy9ugc", Name = "<", IsManaged = true, IsAutoGenerated = true)]
            public n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_OEQyaPLeoFPNLI9Qsy9ugc;
            [n1.ElementAttribute(TracingId = 355565U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DCJ7ygOPcm0N1b0eWbOoab", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_DCJ7ygOPcm0N1b0eWbOoab;
            [n1.ElementAttribute(TracingId = 355591U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EXf0M02nN3ZOebwIjZiW6n", Name = "AND", IsManaged = true, IsAutoGenerated = true)]
            public n59.AND_TkWZzQWwZ0tLZt6ooZGazh __p_EXf0M02nN3ZOebwIjZiW6n;
            [n1.ElementAttribute(TracingId = 355610U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "U9123t5EgJCNabvmwRdz6g", Name = "TextureSet", IsManaged = true, IsAutoGenerated = true)]
            public n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, n6.Vector4> __p_U9123t5EgJCNabvmwRdz6g;
            [n1.ElementAttribute(TracingId = 355625U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EPjJp86lllMMMxfs8V3Brf", Name = "Length", IsManaged = true, IsAutoGenerated = true)]
            public n75.Length_P0UB6WKESd0PjWRm8eD1d4<n6.Vector3> __p_EPjJp86lllMMMxfs8V3Brf;
            [n1.ElementAttribute(TracingId = 355637U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Qe6BRlJgbdqOgZ0L1zLs2q", Name = ">", IsManaged = true, IsAutoGenerated = true)]
            public n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_Qe6BRlJgbdqOgZ0L1zLs2q;
            [n1.ElementAttribute(TracingId = 356583U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "J5xamYbncw4Nz3vJJCHdMa", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
            public n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_J5xamYbncw4Nz3vJJCHdMa;
            [n1.ElementAttribute(TracingId = 356604U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QBfAM7LFIlEQKjKvLZivkC", Name = "TextureGet", IsManaged = true, IsAutoGenerated = true)]
            public n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, n6.Vector4> __p_QBfAM7LFIlEQKjKvLZivkC;
            [n1.ElementAttribute(TracingId = 356627U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Lh28ioPoApjMEeDpBRf89D", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
            public n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector3> __p_Lh28ioPoApjMEeDpBRf89D;
            [n1.ElementAttribute(TracingId = 356646U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SlgnLIwHScwLkPTYSxhGdJ", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n75.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n6.Vector3> __p_SlgnLIwHScwLkPTYSxhGdJ;
            [n1.ElementAttribute(TracingId = 356667U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Vk6I19HMkMZMQrAcvK79VF", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_Vk6I19HMkMZMQrAcvK79VF;
            [n1.ElementAttribute(TracingId = 356687U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VGYpJekRixkMkICjCiR22a", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
            public n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector4> __p_VGYpJekRixkMkICjCiR22a;
            [n1.ElementAttribute(TracingId = 356703U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "G0gzyyus8Q5PcmuUjOIR4R", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
            public n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n54.GpuVoid> __p_G0gzyyus8Q5PcmuUjOIR4R;
            [n1.ElementAttribute(TracingId = 356789U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "GjoP8uR2na9LVa0T0vslcR", Name = "PositionToVolumeCellCoord", IsManaged = true, IsAutoGenerated = true)]
            public n72.PositionToVolumeCellCoord_HItUPv4kH5jOKmuxJkiY5B __p_GjoP8uR2na9LVa0T0vslcR;
            [n1.ElementAttribute(TracingId = 356810U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KkjuVnbuKzjQbt6PjsgNv1", Name = "SampleTexture (Fuse)", IsManaged = true, IsAutoGenerated = true)]
            public n62.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n6.Vector2> __p_KkjuVnbuKzjQbt6PjsgNv1;
            [n1.ElementAttribute(TracingId = 356831U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MRsP3ujFKbLLeNBfiB4DnB", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
            public n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_MRsP3ujFKbLLeNBfiB4DnB;
            [n1.ElementAttribute(TracingId = 356847U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EWKGBvR711IOm1itym0Ryv", Name = "SampleTexture (Fuse)", IsManaged = true, IsAutoGenerated = true)]
            public n62.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n6.Vector2> __p_EWKGBvR711IOm1itym0Ryv;
            [n1.ElementAttribute(TracingId = 356864U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ASxvz3suRV7O2KjvOP8o5A", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
            public n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_ASxvz3suRV7O2KjvOP8o5A;
            [n1.ElementAttribute(TracingId = 356885U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SMIyUHVq5JaNQbhadshKIs", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
            public n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_SMIyUHVq5JaNQbhadshKIs;
            [n1.ElementAttribute(TracingId = 356898U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "S60yboHKYMdMudOyJzgqY0", Name = "/", IsManaged = true, IsAutoGenerated = true)]
            public n75.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n6.Vector2> __p_S60yboHKYMdMudOyJzgqY0;
            [n1.ElementAttribute(TracingId = 356919U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "F5O6rgf6OqHP9AsRJyGPGi", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n82.To_Qgkn15Kxt1HLURmAdSAN7m<n6.Vector2, n6.Vector2> __p_F5O6rgf6OqHP9AsRJyGPGi;
            [n1.ElementAttribute(TracingId = 356937U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Uq8tAa9olcXQQdO8ImqcwD", Name = "xy", IsManaged = true, IsAutoGenerated = true)]
            public n76.xy_EiegIBeM6c8OnN5CcRLRyU<n6.Int3> __p_Uq8tAa9olcXQQdO8ImqcwD;
            [n1.ElementAttribute(TracingId = 356953U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MdL6aDqoplyLUCZ2bYhrDZ", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n82.To_Qgkn15Kxt1HLURmAdSAN7m<n6.Vector2, n6.Vector2> __p_MdL6aDqoplyLUCZ2bYhrDZ;
            [n1.ElementAttribute(TracingId = 356978U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MCtdPtr9MjuPt42vKzsmfk", Name = "Mul", IsManaged = true, IsAutoGenerated = true)]
            public n75.Mul_B0P7ghpqXJiLy15iE7sIid<n6.Vector4, n6.Matrix, n6.Vector4> __p_MCtdPtr9MjuPt42vKzsmfk;
            [n1.ElementAttribute(TracingId = 357005U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Or4mozdOD62MZnFtwwGali", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_Or4mozdOD62MZnFtwwGali;
            [n1.ElementAttribute(TracingId = 357044U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Gpl9GZ5CGHiOfJy8Qbq68J", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_Gpl9GZ5CGHiOfJy8Qbq68J;
            [n1.ElementAttribute(TracingId = 357075U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BrcrG3zSybxObQmQ2n9FYs", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
            public n57.GPUIn_C<n6.Matrix> __p_BrcrG3zSybxObQmQ2n9FYs;
            [n1.ElementAttribute(TracingId = 357094U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VsTjyIPH8K4Odcau0Lnggg", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
            public n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_VsTjyIPH8K4Odcau0Lnggg;
            [n1.ElementAttribute(TracingId = 357733U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "F2kzjm0knY1LaZ3X5rA2i3", Name = "Mul", IsManaged = true, IsAutoGenerated = true)]
            public n75.Mul_B0P7ghpqXJiLy15iE7sIid<n6.Vector4, n6.Matrix, n6.Vector3> __p_F2kzjm0knY1LaZ3X5rA2i3;
            [n1.ElementAttribute(TracingId = 357751U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TMQtR7fQRuTPrAnWVfo1ug", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_TMQtR7fQRuTPrAnWVfo1ug;
            [n1.ElementAttribute(TracingId = 357768U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Mf1I9F0Gl1qNDq4Fgs9mje", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_Mf1I9F0Gl1qNDq4Fgs9mje;
            [n1.ElementAttribute(TracingId = 357786U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OCMH1YHplwnQOs2c1Peuvx", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
            public n57.GPUIn_C<n6.Matrix> __p_OCMH1YHplwnQOs2c1Peuvx;
            [n1.ElementAttribute(TracingId = 357799U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RgPPsUAfRIFLueFHYGmG4J", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n75.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n6.Vector3> __p_RgPPsUAfRIFLueFHYGmG4J;
            [n1.ElementAttribute(TracingId = 357818U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QdG3xLb1SfQLd63exGRrnb", Name = "FromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n82.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<n6.Vector3> __p_QdG3xLb1SfQLd63exGRrnb;
            [n1.ElementAttribute(TracingId = 357833U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Kmge7kpo6cPPL16ywaBWa7", Name = "CheckDefault", IsManaged = true, IsAutoGenerated = true)]
            public n79.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_Kmge7kpo6cPPL16ywaBWa7;
            [n1.ElementAttribute(TracingId = 357874U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IrdLHflPjOhK98vlxajKrE", Name = "x-yz (split)", IsManaged = true, IsAutoGenerated = true)]
            public n83.xMyz_split_AJovkBTfOKGNHniZzmUeC0 __p_IrdLHflPjOhK98vlxajKrE;
            [n1.ElementAttribute(TracingId = 357888U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FZFZaMga7C0MHSY2momT7T", Name = "x+yz (join)", IsManaged = true, IsAutoGenerated = true)]
            public n77.xPyz_join_TfjUbK4F10LQJgxHoD2Rkv __p_FZFZaMga7C0MHSY2momT7T;
            [n1.ElementAttribute(TracingId = 357914U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EObAHtzUwYDN4QQ1pwnKGm", Name = "Negate", IsManaged = true, IsAutoGenerated = true)]
            public n75.Negate_P5nGfBLszbBL1YRjqmyYHC<float> __p_EObAHtzUwYDN4QQ1pwnKGm;
            [n1.ElementAttribute(TracingId = 357963U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JkJjwhrlRt4MnIeRBF64VP", Name = "x-yz (split)", IsManaged = true, IsAutoGenerated = true)]
            public n83.xMyz_split_AJovkBTfOKGNHniZzmUeC0 __p_JkJjwhrlRt4MnIeRBF64VP;
            [n1.ElementAttribute(TracingId = 357978U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Txg022TJAfkQXeshliMXZ5", Name = "x+yz (join)", IsManaged = true, IsAutoGenerated = true)]
            public n77.xPyz_join_TfjUbK4F10LQJgxHoD2Rkv __p_Txg022TJAfkQXeshliMXZ5;
            [n1.ElementAttribute(TracingId = 357987U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "A5YUKxwLfwpLqlzzjjHzHx", Name = "Negate", IsManaged = true, IsAutoGenerated = true)]
            public n75.Negate_P5nGfBLszbBL1YRjqmyYHC<float> __p_A5YUKxwLfwpLqlzzjjHzHx;
            [n1.ElementAttribute(TracingId = 357997U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RzfrLKpqe8NN1rRC8gF1Mf", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n75.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float> __p_RzfrLKpqe8NN1rRC8gF1Mf;
            [n1.ElementAttribute(TracingId = 358009U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BG2VoIHhrfyOPgDiP89lnu", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_BG2VoIHhrfyOPgDiP89lnu;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_R1rAY6Goo41OQzfrET27Zh = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_BnuBSRDzsQ7QIMBzKCIRVn = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_Hx9OgGroD8CP35UMHfk3tH = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n28.GpuValue<bool>> __pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n = default(n12.Spread<n28.GpuValue<bool>>);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<n27.Texture, n28.GpuValue<n27.Texture>> __monadBuilder_ITALcgI0eOQQFbYNaPaL2l = n28.GpuValueMonadicFactory<n27.Texture>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<n6.Vector2, n28.GpuValue<n6.Vector2>> __monadBuilder_C6gi0LD9PAjNdXIptcrj8P = n28.GpuValueMonadicFactory<n6.Vector2>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n28.GpuValue<n6.Vector2>> __pin_group_Input_In_S60yboHKYMdMudOyJzgqY0 = default(n12.Spread<n28.GpuValue<n6.Vector2>>);
            [n1.ElementAttribute(TracingId = 356972U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CoImXpPEcBiPLNDjlnzUaU", Name = "__slot_CoImXpPEcBiPLNDjlnzUaU")]
            public n28.GpuValue<n6.Vector2> __slot_CoImXpPEcBiPLNDjlnzUaU;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<n27.Texture, n28.GpuValue<n27.Texture>> __monadBuilder_HZ7FLxXj55kO0bZR8BoN80 = n28.GpuValueMonadicFactory<n27.Texture>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n28.GpuValue<n6.Vector3>> __pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J = default(n12.Spread<n28.GpuValue<n6.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n28.GpuValue<n6.Vector3>> __pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ = default(n12.Spread<n28.GpuValue<n6.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n28.GpuValue<float>> __pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf = default(n12.Spread<n28.GpuValue<float>>);
            public __C9mAwGBsbceMDNVros5sDA(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __C9mAwGBsbceMDNVros5sDA(__C9mAwGBsbceMDNVros5sDA other): base(other)
            {
                this.__p_NlR9zBPt78lQdHZlzJXgIt = other.__p_NlR9zBPt78lQdHZlzJXgIt;
                this.__p_B4sahqLbnHcORFaoiwoF13 = other.__p_B4sahqLbnHcORFaoiwoF13;
                this.__p_OEQyaPLeoFPNLI9Qsy9ugc = other.__p_OEQyaPLeoFPNLI9Qsy9ugc;
                this.__p_DCJ7ygOPcm0N1b0eWbOoab = other.__p_DCJ7ygOPcm0N1b0eWbOoab;
                this.__p_EXf0M02nN3ZOebwIjZiW6n = other.__p_EXf0M02nN3ZOebwIjZiW6n;
                this.__p_U9123t5EgJCNabvmwRdz6g = other.__p_U9123t5EgJCNabvmwRdz6g;
                this.__p_EPjJp86lllMMMxfs8V3Brf = other.__p_EPjJp86lllMMMxfs8V3Brf;
                this.__p_Qe6BRlJgbdqOgZ0L1zLs2q = other.__p_Qe6BRlJgbdqOgZ0L1zLs2q;
                this.__p_J5xamYbncw4Nz3vJJCHdMa = other.__p_J5xamYbncw4Nz3vJJCHdMa;
                this.__p_QBfAM7LFIlEQKjKvLZivkC = other.__p_QBfAM7LFIlEQKjKvLZivkC;
                this.__p_Lh28ioPoApjMEeDpBRf89D = other.__p_Lh28ioPoApjMEeDpBRf89D;
                this.__p_SlgnLIwHScwLkPTYSxhGdJ = other.__p_SlgnLIwHScwLkPTYSxhGdJ;
                this.__p_Vk6I19HMkMZMQrAcvK79VF = other.__p_Vk6I19HMkMZMQrAcvK79VF;
                this.__p_VGYpJekRixkMkICjCiR22a = other.__p_VGYpJekRixkMkICjCiR22a;
                this.__p_G0gzyyus8Q5PcmuUjOIR4R = other.__p_G0gzyyus8Q5PcmuUjOIR4R;
                this.__p_GjoP8uR2na9LVa0T0vslcR = other.__p_GjoP8uR2na9LVa0T0vslcR;
                this.__p_KkjuVnbuKzjQbt6PjsgNv1 = other.__p_KkjuVnbuKzjQbt6PjsgNv1;
                this.__p_MRsP3ujFKbLLeNBfiB4DnB = other.__p_MRsP3ujFKbLLeNBfiB4DnB;
                this.__p_EWKGBvR711IOm1itym0Ryv = other.__p_EWKGBvR711IOm1itym0Ryv;
                this.__p_ASxvz3suRV7O2KjvOP8o5A = other.__p_ASxvz3suRV7O2KjvOP8o5A;
                this.__p_SMIyUHVq5JaNQbhadshKIs = other.__p_SMIyUHVq5JaNQbhadshKIs;
                this.__p_S60yboHKYMdMudOyJzgqY0 = other.__p_S60yboHKYMdMudOyJzgqY0;
                this.__p_F5O6rgf6OqHP9AsRJyGPGi = other.__p_F5O6rgf6OqHP9AsRJyGPGi;
                this.__p_Uq8tAa9olcXQQdO8ImqcwD = other.__p_Uq8tAa9olcXQQdO8ImqcwD;
                this.__p_MdL6aDqoplyLUCZ2bYhrDZ = other.__p_MdL6aDqoplyLUCZ2bYhrDZ;
                this.__p_MCtdPtr9MjuPt42vKzsmfk = other.__p_MCtdPtr9MjuPt42vKzsmfk;
                this.__p_Or4mozdOD62MZnFtwwGali = other.__p_Or4mozdOD62MZnFtwwGali;
                this.__p_Gpl9GZ5CGHiOfJy8Qbq68J = other.__p_Gpl9GZ5CGHiOfJy8Qbq68J;
                this.__p_BrcrG3zSybxObQmQ2n9FYs = other.__p_BrcrG3zSybxObQmQ2n9FYs;
                this.__p_VsTjyIPH8K4Odcau0Lnggg = other.__p_VsTjyIPH8K4Odcau0Lnggg;
                this.__p_F2kzjm0knY1LaZ3X5rA2i3 = other.__p_F2kzjm0knY1LaZ3X5rA2i3;
                this.__p_TMQtR7fQRuTPrAnWVfo1ug = other.__p_TMQtR7fQRuTPrAnWVfo1ug;
                this.__p_Mf1I9F0Gl1qNDq4Fgs9mje = other.__p_Mf1I9F0Gl1qNDq4Fgs9mje;
                this.__p_OCMH1YHplwnQOs2c1Peuvx = other.__p_OCMH1YHplwnQOs2c1Peuvx;
                this.__p_RgPPsUAfRIFLueFHYGmG4J = other.__p_RgPPsUAfRIFLueFHYGmG4J;
                this.__p_QdG3xLb1SfQLd63exGRrnb = other.__p_QdG3xLb1SfQLd63exGRrnb;
                this.__p_Kmge7kpo6cPPL16ywaBWa7 = other.__p_Kmge7kpo6cPPL16ywaBWa7;
                this.__p_IrdLHflPjOhK98vlxajKrE = other.__p_IrdLHflPjOhK98vlxajKrE;
                this.__p_FZFZaMga7C0MHSY2momT7T = other.__p_FZFZaMga7C0MHSY2momT7T;
                this.__p_EObAHtzUwYDN4QQ1pwnKGm = other.__p_EObAHtzUwYDN4QQ1pwnKGm;
                this.__p_JkJjwhrlRt4MnIeRBF64VP = other.__p_JkJjwhrlRt4MnIeRBF64VP;
                this.__p_Txg022TJAfkQXeshliMXZ5 = other.__p_Txg022TJAfkQXeshliMXZ5;
                this.__p_A5YUKxwLfwpLqlzzjjHzHx = other.__p_A5YUKxwLfwpLqlzzjjHzHx;
                this.__p_RzfrLKpqe8NN1rRC8gF1Mf = other.__p_RzfrLKpqe8NN1rRC8gF1Mf;
                this.__p_BG2VoIHhrfyOPgDiP89lnu = other.__p_BG2VoIHhrfyOPgDiP89lnu;
                this.__monadBuilder_R1rAY6Goo41OQzfrET27Zh = other.__monadBuilder_R1rAY6Goo41OQzfrET27Zh;
                this.__monadBuilder_BnuBSRDzsQ7QIMBzKCIRVn = other.__monadBuilder_BnuBSRDzsQ7QIMBzKCIRVn;
                this.__monadBuilder_Hx9OgGroD8CP35UMHfk3tH = other.__monadBuilder_Hx9OgGroD8CP35UMHfk3tH;
                this.__pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n = other.__pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n;
                this.__monadBuilder_ITALcgI0eOQQFbYNaPaL2l = other.__monadBuilder_ITALcgI0eOQQFbYNaPaL2l;
                this.__monadBuilder_C6gi0LD9PAjNdXIptcrj8P = other.__monadBuilder_C6gi0LD9PAjNdXIptcrj8P;
                this.__pin_group_Input_In_S60yboHKYMdMudOyJzgqY0 = other.__pin_group_Input_In_S60yboHKYMdMudOyJzgqY0;
                this.__slot_CoImXpPEcBiPLNDjlnzUaU = other.__slot_CoImXpPEcBiPLNDjlnzUaU;
                this.__monadBuilder_HZ7FLxXj55kO0bZR8BoN80 = other.__monadBuilder_HZ7FLxXj55kO0bZR8BoN80;
                this.__pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J = other.__pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J;
                this.__pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ = other.__pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ;
                this.__pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf = other.__pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NlR9zBPt78lQdHZlzJXgIt", in __p_NlR9zBPt78lQdHZlzJXgIt), n1.CompilationHelper.GetValueOrExisting(values, "__p_B4sahqLbnHcORFaoiwoF13", in __p_B4sahqLbnHcORFaoiwoF13), n1.CompilationHelper.GetValueOrExisting(values, "__p_OEQyaPLeoFPNLI9Qsy9ugc", in __p_OEQyaPLeoFPNLI9Qsy9ugc), n1.CompilationHelper.GetValueOrExisting(values, "__p_DCJ7ygOPcm0N1b0eWbOoab", in __p_DCJ7ygOPcm0N1b0eWbOoab), n1.CompilationHelper.GetValueOrExisting(values, "__p_EXf0M02nN3ZOebwIjZiW6n", in __p_EXf0M02nN3ZOebwIjZiW6n), n1.CompilationHelper.GetValueOrExisting(values, "__p_U9123t5EgJCNabvmwRdz6g", in __p_U9123t5EgJCNabvmwRdz6g), n1.CompilationHelper.GetValueOrExisting(values, "__p_EPjJp86lllMMMxfs8V3Brf", in __p_EPjJp86lllMMMxfs8V3Brf), n1.CompilationHelper.GetValueOrExisting(values, "__p_Qe6BRlJgbdqOgZ0L1zLs2q", in __p_Qe6BRlJgbdqOgZ0L1zLs2q), n1.CompilationHelper.GetValueOrExisting(values, "__p_J5xamYbncw4Nz3vJJCHdMa", in __p_J5xamYbncw4Nz3vJJCHdMa), n1.CompilationHelper.GetValueOrExisting(values, "__p_QBfAM7LFIlEQKjKvLZivkC", in __p_QBfAM7LFIlEQKjKvLZivkC), n1.CompilationHelper.GetValueOrExisting(values, "__p_Lh28ioPoApjMEeDpBRf89D", in __p_Lh28ioPoApjMEeDpBRf89D), n1.CompilationHelper.GetValueOrExisting(values, "__p_SlgnLIwHScwLkPTYSxhGdJ", in __p_SlgnLIwHScwLkPTYSxhGdJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vk6I19HMkMZMQrAcvK79VF", in __p_Vk6I19HMkMZMQrAcvK79VF), n1.CompilationHelper.GetValueOrExisting(values, "__p_VGYpJekRixkMkICjCiR22a", in __p_VGYpJekRixkMkICjCiR22a), n1.CompilationHelper.GetValueOrExisting(values, "__p_G0gzyyus8Q5PcmuUjOIR4R", in __p_G0gzyyus8Q5PcmuUjOIR4R), n1.CompilationHelper.GetValueOrExisting(values, "__p_GjoP8uR2na9LVa0T0vslcR", in __p_GjoP8uR2na9LVa0T0vslcR), n1.CompilationHelper.GetValueOrExisting(values, "__p_KkjuVnbuKzjQbt6PjsgNv1", in __p_KkjuVnbuKzjQbt6PjsgNv1), n1.CompilationHelper.GetValueOrExisting(values, "__p_MRsP3ujFKbLLeNBfiB4DnB", in __p_MRsP3ujFKbLLeNBfiB4DnB), n1.CompilationHelper.GetValueOrExisting(values, "__p_EWKGBvR711IOm1itym0Ryv", in __p_EWKGBvR711IOm1itym0Ryv), n1.CompilationHelper.GetValueOrExisting(values, "__p_ASxvz3suRV7O2KjvOP8o5A", in __p_ASxvz3suRV7O2KjvOP8o5A), n1.CompilationHelper.GetValueOrExisting(values, "__p_SMIyUHVq5JaNQbhadshKIs", in __p_SMIyUHVq5JaNQbhadshKIs), n1.CompilationHelper.GetValueOrExisting(values, "__p_S60yboHKYMdMudOyJzgqY0", in __p_S60yboHKYMdMudOyJzgqY0), n1.CompilationHelper.GetValueOrExisting(values, "__p_F5O6rgf6OqHP9AsRJyGPGi", in __p_F5O6rgf6OqHP9AsRJyGPGi), n1.CompilationHelper.GetValueOrExisting(values, "__p_Uq8tAa9olcXQQdO8ImqcwD", in __p_Uq8tAa9olcXQQdO8ImqcwD), n1.CompilationHelper.GetValueOrExisting(values, "__p_MdL6aDqoplyLUCZ2bYhrDZ", in __p_MdL6aDqoplyLUCZ2bYhrDZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_MCtdPtr9MjuPt42vKzsmfk", in __p_MCtdPtr9MjuPt42vKzsmfk), n1.CompilationHelper.GetValueOrExisting(values, "__p_Or4mozdOD62MZnFtwwGali", in __p_Or4mozdOD62MZnFtwwGali), n1.CompilationHelper.GetValueOrExisting(values, "__p_Gpl9GZ5CGHiOfJy8Qbq68J", in __p_Gpl9GZ5CGHiOfJy8Qbq68J), n1.CompilationHelper.GetValueOrExisting(values, "__p_BrcrG3zSybxObQmQ2n9FYs", in __p_BrcrG3zSybxObQmQ2n9FYs), n1.CompilationHelper.GetValueOrExisting(values, "__p_VsTjyIPH8K4Odcau0Lnggg", in __p_VsTjyIPH8K4Odcau0Lnggg), n1.CompilationHelper.GetValueOrExisting(values, "__p_F2kzjm0knY1LaZ3X5rA2i3", in __p_F2kzjm0knY1LaZ3X5rA2i3), n1.CompilationHelper.GetValueOrExisting(values, "__p_TMQtR7fQRuTPrAnWVfo1ug", in __p_TMQtR7fQRuTPrAnWVfo1ug), n1.CompilationHelper.GetValueOrExisting(values, "__p_Mf1I9F0Gl1qNDq4Fgs9mje", in __p_Mf1I9F0Gl1qNDq4Fgs9mje), n1.CompilationHelper.GetValueOrExisting(values, "__p_OCMH1YHplwnQOs2c1Peuvx", in __p_OCMH1YHplwnQOs2c1Peuvx), n1.CompilationHelper.GetValueOrExisting(values, "__p_RgPPsUAfRIFLueFHYGmG4J", in __p_RgPPsUAfRIFLueFHYGmG4J), n1.CompilationHelper.GetValueOrExisting(values, "__p_QdG3xLb1SfQLd63exGRrnb", in __p_QdG3xLb1SfQLd63exGRrnb), n1.CompilationHelper.GetValueOrExisting(values, "__p_Kmge7kpo6cPPL16ywaBWa7", in __p_Kmge7kpo6cPPL16ywaBWa7), n1.CompilationHelper.GetValueOrExisting(values, "__p_IrdLHflPjOhK98vlxajKrE", in __p_IrdLHflPjOhK98vlxajKrE), n1.CompilationHelper.GetValueOrExisting(values, "__p_FZFZaMga7C0MHSY2momT7T", in __p_FZFZaMga7C0MHSY2momT7T), n1.CompilationHelper.GetValueOrExisting(values, "__p_EObAHtzUwYDN4QQ1pwnKGm", in __p_EObAHtzUwYDN4QQ1pwnKGm), n1.CompilationHelper.GetValueOrExisting(values, "__p_JkJjwhrlRt4MnIeRBF64VP", in __p_JkJjwhrlRt4MnIeRBF64VP), n1.CompilationHelper.GetValueOrExisting(values, "__p_Txg022TJAfkQXeshliMXZ5", in __p_Txg022TJAfkQXeshliMXZ5), n1.CompilationHelper.GetValueOrExisting(values, "__p_A5YUKxwLfwpLqlzzjjHzHx", in __p_A5YUKxwLfwpLqlzzjjHzHx), n1.CompilationHelper.GetValueOrExisting(values, "__p_RzfrLKpqe8NN1rRC8gF1Mf", in __p_RzfrLKpqe8NN1rRC8gF1Mf), n1.CompilationHelper.GetValueOrExisting(values, "__p_BG2VoIHhrfyOPgDiP89lnu", in __p_BG2VoIHhrfyOPgDiP89lnu), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_R1rAY6Goo41OQzfrET27Zh", in __monadBuilder_R1rAY6Goo41OQzfrET27Zh), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_BnuBSRDzsQ7QIMBzKCIRVn", in __monadBuilder_BnuBSRDzsQ7QIMBzKCIRVn), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_Hx9OgGroD8CP35UMHfk3tH", in __monadBuilder_Hx9OgGroD8CP35UMHfk3tH), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n", in __pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_ITALcgI0eOQQFbYNaPaL2l", in __monadBuilder_ITALcgI0eOQQFbYNaPaL2l), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_C6gi0LD9PAjNdXIptcrj8P", in __monadBuilder_C6gi0LD9PAjNdXIptcrj8P), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_S60yboHKYMdMudOyJzgqY0", in __pin_group_Input_In_S60yboHKYMdMudOyJzgqY0), n1.CompilationHelper.GetValueOrExisting(values, "__slot_CoImXpPEcBiPLNDjlnzUaU", in __slot_CoImXpPEcBiPLNDjlnzUaU), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_HZ7FLxXj55kO0bZR8BoN80", in __monadBuilder_HZ7FLxXj55kO0bZR8BoN80), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J", in __pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ", in __pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf", in __pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf));
            }

            internal __C9mAwGBsbceMDNVros5sDA __WITH__(n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, float> __p_NlR9zBPt78lQdHZlzJXgIt, n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_B4sahqLbnHcORFaoiwoF13, n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_OEQyaPLeoFPNLI9Qsy9ugc, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_DCJ7ygOPcm0N1b0eWbOoab, n59.AND_TkWZzQWwZ0tLZt6ooZGazh __p_EXf0M02nN3ZOebwIjZiW6n, n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, n6.Vector4> __p_U9123t5EgJCNabvmwRdz6g, n75.Length_P0UB6WKESd0PjWRm8eD1d4<n6.Vector3> __p_EPjJp86lllMMMxfs8V3Brf, n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_Qe6BRlJgbdqOgZ0L1zLs2q, n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_J5xamYbncw4Nz3vJJCHdMa, n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, n6.Vector4> __p_QBfAM7LFIlEQKjKvLZivkC, n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector3> __p_Lh28ioPoApjMEeDpBRf89D, n75.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n6.Vector3> __p_SlgnLIwHScwLkPTYSxhGdJ, n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_Vk6I19HMkMZMQrAcvK79VF, n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector4> __p_VGYpJekRixkMkICjCiR22a, n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n54.GpuVoid> __p_G0gzyyus8Q5PcmuUjOIR4R, n72.PositionToVolumeCellCoord_HItUPv4kH5jOKmuxJkiY5B __p_GjoP8uR2na9LVa0T0vslcR, n62.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n6.Vector2> __p_KkjuVnbuKzjQbt6PjsgNv1, n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_MRsP3ujFKbLLeNBfiB4DnB, n62.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n6.Vector2> __p_EWKGBvR711IOm1itym0Ryv, n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_ASxvz3suRV7O2KjvOP8o5A, n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_SMIyUHVq5JaNQbhadshKIs, n75.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n6.Vector2> __p_S60yboHKYMdMudOyJzgqY0, n82.To_Qgkn15Kxt1HLURmAdSAN7m<n6.Vector2, n6.Vector2> __p_F5O6rgf6OqHP9AsRJyGPGi, n76.xy_EiegIBeM6c8OnN5CcRLRyU<n6.Int3> __p_Uq8tAa9olcXQQdO8ImqcwD, n82.To_Qgkn15Kxt1HLURmAdSAN7m<n6.Vector2, n6.Vector2> __p_MdL6aDqoplyLUCZ2bYhrDZ, n75.Mul_B0P7ghpqXJiLy15iE7sIid<n6.Vector4, n6.Matrix, n6.Vector4> __p_MCtdPtr9MjuPt42vKzsmfk, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_Or4mozdOD62MZnFtwwGali, n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_Gpl9GZ5CGHiOfJy8Qbq68J, n57.GPUIn_C<n6.Matrix> __p_BrcrG3zSybxObQmQ2n9FYs, n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_VsTjyIPH8K4Odcau0Lnggg, n75.Mul_B0P7ghpqXJiLy15iE7sIid<n6.Vector4, n6.Matrix, n6.Vector3> __p_F2kzjm0knY1LaZ3X5rA2i3, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_TMQtR7fQRuTPrAnWVfo1ug, n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_Mf1I9F0Gl1qNDq4Fgs9mje, n57.GPUIn_C<n6.Matrix> __p_OCMH1YHplwnQOs2c1Peuvx, n75.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n6.Vector3> __p_RgPPsUAfRIFLueFHYGmG4J, n82.FromFloat_Gkgbb9BjQakQN7GgeRsQaW<n6.Vector3> __p_QdG3xLb1SfQLd63exGRrnb, n79.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_Kmge7kpo6cPPL16ywaBWa7, n83.xMyz_split_AJovkBTfOKGNHniZzmUeC0 __p_IrdLHflPjOhK98vlxajKrE, n77.xPyz_join_TfjUbK4F10LQJgxHoD2Rkv __p_FZFZaMga7C0MHSY2momT7T, n75.Negate_P5nGfBLszbBL1YRjqmyYHC<float> __p_EObAHtzUwYDN4QQ1pwnKGm, n83.xMyz_split_AJovkBTfOKGNHniZzmUeC0 __p_JkJjwhrlRt4MnIeRBF64VP, n77.xPyz_join_TfjUbK4F10LQJgxHoD2Rkv __p_Txg022TJAfkQXeshliMXZ5, n75.Negate_P5nGfBLszbBL1YRjqmyYHC<float> __p_A5YUKxwLfwpLqlzzjjHzHx, n75.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float> __p_RzfrLKpqe8NN1rRC8gF1Mf, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_BG2VoIHhrfyOPgDiP89lnu, n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_R1rAY6Goo41OQzfrET27Zh, n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_BnuBSRDzsQ7QIMBzKCIRVn, n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_Hx9OgGroD8CP35UMHfk3tH, n12.Spread<n28.GpuValue<bool>> __pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n, n1.IMonadBuilder<n27.Texture, n28.GpuValue<n27.Texture>> __monadBuilder_ITALcgI0eOQQFbYNaPaL2l, n1.IMonadBuilder<n6.Vector2, n28.GpuValue<n6.Vector2>> __monadBuilder_C6gi0LD9PAjNdXIptcrj8P, n12.Spread<n28.GpuValue<n6.Vector2>> __pin_group_Input_In_S60yboHKYMdMudOyJzgqY0, n28.GpuValue<n6.Vector2> __slot_CoImXpPEcBiPLNDjlnzUaU, n1.IMonadBuilder<n27.Texture, n28.GpuValue<n27.Texture>> __monadBuilder_HZ7FLxXj55kO0bZR8BoN80, n12.Spread<n28.GpuValue<n6.Vector3>> __pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J, n12.Spread<n28.GpuValue<n6.Vector3>> __pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ, n12.Spread<n28.GpuValue<float>> __pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf)
            {
                __C9mAwGBsbceMDNVros5sDA that_0 = this;
                this.__p_NlR9zBPt78lQdHZlzJXgIt = __p_NlR9zBPt78lQdHZlzJXgIt;
                this.__p_B4sahqLbnHcORFaoiwoF13 = __p_B4sahqLbnHcORFaoiwoF13;
                this.__p_OEQyaPLeoFPNLI9Qsy9ugc = __p_OEQyaPLeoFPNLI9Qsy9ugc;
                this.__p_DCJ7ygOPcm0N1b0eWbOoab = __p_DCJ7ygOPcm0N1b0eWbOoab;
                this.__p_EXf0M02nN3ZOebwIjZiW6n = __p_EXf0M02nN3ZOebwIjZiW6n;
                this.__p_U9123t5EgJCNabvmwRdz6g = __p_U9123t5EgJCNabvmwRdz6g;
                this.__p_EPjJp86lllMMMxfs8V3Brf = __p_EPjJp86lllMMMxfs8V3Brf;
                this.__p_Qe6BRlJgbdqOgZ0L1zLs2q = __p_Qe6BRlJgbdqOgZ0L1zLs2q;
                this.__p_J5xamYbncw4Nz3vJJCHdMa = __p_J5xamYbncw4Nz3vJJCHdMa;
                this.__p_QBfAM7LFIlEQKjKvLZivkC = __p_QBfAM7LFIlEQKjKvLZivkC;
                this.__p_Lh28ioPoApjMEeDpBRf89D = __p_Lh28ioPoApjMEeDpBRf89D;
                this.__p_SlgnLIwHScwLkPTYSxhGdJ = __p_SlgnLIwHScwLkPTYSxhGdJ;
                this.__p_Vk6I19HMkMZMQrAcvK79VF = __p_Vk6I19HMkMZMQrAcvK79VF;
                this.__p_VGYpJekRixkMkICjCiR22a = __p_VGYpJekRixkMkICjCiR22a;
                this.__p_G0gzyyus8Q5PcmuUjOIR4R = __p_G0gzyyus8Q5PcmuUjOIR4R;
                this.__p_GjoP8uR2na9LVa0T0vslcR = __p_GjoP8uR2na9LVa0T0vslcR;
                this.__p_KkjuVnbuKzjQbt6PjsgNv1 = __p_KkjuVnbuKzjQbt6PjsgNv1;
                this.__p_MRsP3ujFKbLLeNBfiB4DnB = __p_MRsP3ujFKbLLeNBfiB4DnB;
                this.__p_EWKGBvR711IOm1itym0Ryv = __p_EWKGBvR711IOm1itym0Ryv;
                this.__p_ASxvz3suRV7O2KjvOP8o5A = __p_ASxvz3suRV7O2KjvOP8o5A;
                this.__p_SMIyUHVq5JaNQbhadshKIs = __p_SMIyUHVq5JaNQbhadshKIs;
                this.__p_S60yboHKYMdMudOyJzgqY0 = __p_S60yboHKYMdMudOyJzgqY0;
                this.__p_F5O6rgf6OqHP9AsRJyGPGi = __p_F5O6rgf6OqHP9AsRJyGPGi;
                this.__p_Uq8tAa9olcXQQdO8ImqcwD = __p_Uq8tAa9olcXQQdO8ImqcwD;
                this.__p_MdL6aDqoplyLUCZ2bYhrDZ = __p_MdL6aDqoplyLUCZ2bYhrDZ;
                this.__p_MCtdPtr9MjuPt42vKzsmfk = __p_MCtdPtr9MjuPt42vKzsmfk;
                this.__p_Or4mozdOD62MZnFtwwGali = __p_Or4mozdOD62MZnFtwwGali;
                this.__p_Gpl9GZ5CGHiOfJy8Qbq68J = __p_Gpl9GZ5CGHiOfJy8Qbq68J;
                this.__p_BrcrG3zSybxObQmQ2n9FYs = __p_BrcrG3zSybxObQmQ2n9FYs;
                this.__p_VsTjyIPH8K4Odcau0Lnggg = __p_VsTjyIPH8K4Odcau0Lnggg;
                this.__p_F2kzjm0knY1LaZ3X5rA2i3 = __p_F2kzjm0knY1LaZ3X5rA2i3;
                this.__p_TMQtR7fQRuTPrAnWVfo1ug = __p_TMQtR7fQRuTPrAnWVfo1ug;
                this.__p_Mf1I9F0Gl1qNDq4Fgs9mje = __p_Mf1I9F0Gl1qNDq4Fgs9mje;
                this.__p_OCMH1YHplwnQOs2c1Peuvx = __p_OCMH1YHplwnQOs2c1Peuvx;
                this.__p_RgPPsUAfRIFLueFHYGmG4J = __p_RgPPsUAfRIFLueFHYGmG4J;
                this.__p_QdG3xLb1SfQLd63exGRrnb = __p_QdG3xLb1SfQLd63exGRrnb;
                this.__p_Kmge7kpo6cPPL16ywaBWa7 = __p_Kmge7kpo6cPPL16ywaBWa7;
                this.__p_IrdLHflPjOhK98vlxajKrE = __p_IrdLHflPjOhK98vlxajKrE;
                this.__p_FZFZaMga7C0MHSY2momT7T = __p_FZFZaMga7C0MHSY2momT7T;
                this.__p_EObAHtzUwYDN4QQ1pwnKGm = __p_EObAHtzUwYDN4QQ1pwnKGm;
                this.__p_JkJjwhrlRt4MnIeRBF64VP = __p_JkJjwhrlRt4MnIeRBF64VP;
                this.__p_Txg022TJAfkQXeshliMXZ5 = __p_Txg022TJAfkQXeshliMXZ5;
                this.__p_A5YUKxwLfwpLqlzzjjHzHx = __p_A5YUKxwLfwpLqlzzjjHzHx;
                this.__p_RzfrLKpqe8NN1rRC8gF1Mf = __p_RzfrLKpqe8NN1rRC8gF1Mf;
                this.__p_BG2VoIHhrfyOPgDiP89lnu = __p_BG2VoIHhrfyOPgDiP89lnu;
                this.__monadBuilder_R1rAY6Goo41OQzfrET27Zh = __monadBuilder_R1rAY6Goo41OQzfrET27Zh;
                this.__monadBuilder_BnuBSRDzsQ7QIMBzKCIRVn = __monadBuilder_BnuBSRDzsQ7QIMBzKCIRVn;
                this.__monadBuilder_Hx9OgGroD8CP35UMHfk3tH = __monadBuilder_Hx9OgGroD8CP35UMHfk3tH;
                this.__pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n = __pin_group_Values_In_EXf0M02nN3ZOebwIjZiW6n;
                this.__monadBuilder_ITALcgI0eOQQFbYNaPaL2l = __monadBuilder_ITALcgI0eOQQFbYNaPaL2l;
                this.__monadBuilder_C6gi0LD9PAjNdXIptcrj8P = __monadBuilder_C6gi0LD9PAjNdXIptcrj8P;
                this.__pin_group_Input_In_S60yboHKYMdMudOyJzgqY0 = __pin_group_Input_In_S60yboHKYMdMudOyJzgqY0;
                this.__slot_CoImXpPEcBiPLNDjlnzUaU = __slot_CoImXpPEcBiPLNDjlnzUaU;
                this.__monadBuilder_HZ7FLxXj55kO0bZR8BoN80 = __monadBuilder_HZ7FLxXj55kO0bZR8BoN80;
                this.__pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J = __pin_group_Input_In_RgPPsUAfRIFLueFHYGmG4J;
                this.__pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ = __pin_group_Input_In_SlgnLIwHScwLkPTYSxhGdJ;
                this.__pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf = __pin_group_Input_In_RzfrLKpqe8NN1rRC8gF1Mf;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 360118U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TXlNdvWFKhHPGtZjJxBp5H", Name = "DynamicVectorField_Fluid3D_C")]
    [n2.SerializableAttribute]
    public class DynamicVectorField_Fluid3D_C : n1.VLObject, n11.IFluidComponent_I, n11.IPostTexAdvectComputeGraphProvider_I, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n11.DynamicVectorField_Fluid3D_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new DynamicVectorField_Fluid3D_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.DynamicVectorField_Fluid3D_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new DynamicVectorField_Fluid3D_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.DynamicVectorField_Fluid3D_C Update_(out n28.GpuValue<n54.GpuVoid> Graph_Out)
        {
            bool __pad_NT2EkzWh2ShMUlt1oTguLC_0 = __slot_NT2EkzWh2ShMUlt1oTguLC;
            n27.Texture __auto_1 = this.Texture;
            bool __auto_2 = this.Enabled;
            n4.FluidContext_C __auto_3 = this.Context;
            bool __auto_4 = this.Additive;
            n28.GpuValue<float> __auto_5 = this.Threshold;
            n28.GpuValue<n6.Vector3> __auto_6 = this.Gravity;
            bool Dispose_Cached_Outputs_7 = false;
            var manager_8 = this.__cache_QFcWxarzOD7NMh8d9NEhYz;
            if (manager_8 is null)
            {
                manager_8 = new n13.Manager<n2.ValueTuple<n27.Texture, bool, n4.FluidContext_C, bool, n28.GpuValue<float>, n28.GpuValue<n6.Vector3>>, n2.ValueTuple<n28.GpuValue<n54.GpuVoid>>>(n2.ValueTuple.Create(default(n28.GpuValue<n54.GpuVoid>)));
            }

            var inputs_9 = (__auto_1, __auto_2, __auto_3, __auto_4, __auto_5, __auto_6);
            var outputs_10 = manager_8.Outputs;
            var Has_Changed_11 = __pad_NT2EkzWh2ShMUlt1oTguLC_0 || manager_8.InputsChanged(inputs_9);
            if (Has_Changed_11)
            {
                if (Dispose_Cached_Outputs_7)
                    manager_8.DisposeOutputs();
                var state_12 = n1.CompilationHelper.Restore<__Fu7PgYb9CYpLrAIxzsvcDp>(manager_8.State, __GetContext__());
                if (state_12 == null)
                {
                    state_12 = new __Fu7PgYb9CYpLrAIxzsvcDp(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF = n14._Operations_.CreateDefault<n28.GpuValue<bool>>(), __slot_T1IpKypMVYxQB6DBLnX8YG = default(n28.GpuValue<n6.Vector3>), __pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm = n14._Operations_.CreateDefault<n28.AbstractGpuValue>(), __pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m = n14._Operations_.CreateDefault<n28.GpuValue<n6.Vector3>>()};
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "L7AVHquRoBPONI1jNJh2qX", 360298U);
                    var Output_14 = n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, float>.Create(Node_Context: Node_Context_13);
                    state_12.__p_L7AVHquRoBPONI1jNJh2qX = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "DbV3SyKnKxhPYYTptHAvGb", 360316U);
                    var Output_16 = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_15);
                    state_12.__p_DbV3SyKnKxhPYYTptHAvGb = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Fpnac3G1CagMkW2Vu0d6r6", 360328U);
                    var Output_18 = n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float>.Create(Node_Context: Node_Context_17);
                    state_12.__p_Fpnac3G1CagMkW2Vu0d6r6 = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "JdbDYtdJwhmO4LgmTz9VtO", 360359U);
                    var Output_20 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_19);
                    state_12.__p_JdbDYtdJwhmO4LgmTz9VtO = Output_20;
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "SOAnI1kmaUbOtXklbsjSyF", 360380U);
                    var Output_22 = n59.AND_TkWZzQWwZ0tLZt6ooZGazh.Create(Node_Context: Node_Context_21);
                    state_12.__p_SOAnI1kmaUbOtXklbsjSyF = Output_22;
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "MPNNDwnZOZTOIWQ8pLKhcu", 360399U);
                    var Output_24 = n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, n6.Vector4>.Create(Node_Context: Node_Context_23);
                    state_12.__p_MPNNDwnZOZTOIWQ8pLKhcu = Output_24;
                    n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "FWzJr8akSf7MQvVkO0Uqtr", 360422U);
                    var Output_26 = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_25);
                    state_12.__p_FWzJr8akSf7MQvVkO0Uqtr = Output_26;
                    n1.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "FuEAIOKIRJ3N4GcrZv5bcT", 360434U);
                    var Output_28 = n75.Length_P0UB6WKESd0PjWRm8eD1d4<n6.Vector3>.Create(Node_Context: Node_Context_27);
                    state_12.__p_FuEAIOKIRJ3N4GcrZv5bcT = Output_28;
                    n1.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "VB8QgjO1tkLNjkK76s4pnt", 360448U);
                    var Output_30 = n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float>.Create(Node_Context: Node_Context_29);
                    state_12.__p_VB8QgjO1tkLNjkK76s4pnt = Output_30;
                    n1.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "R6glZvHSmQLQCXhGE6QLlT", 360490U);
                    var Output_32 = n76.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_31);
                    state_12.__p_R6glZvHSmQLQCXhGE6QLlT = Output_32;
                    n1.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "DAqw1iiIrwjQKxvsjvAi2H", 360497U);
                    var Output_34 = n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, n6.Vector4>.Create(Node_Context: Node_Context_33);
                    state_12.__p_DAqw1iiIrwjQKxvsjvAi2H = Output_34;
                    n1.NodeContext Node_Context_35 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "KNBWKTUbqdOQW67KuhYEHj", 360527U);
                    var Output_36 = n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector3>.Create(Node_Context: Node_Context_35);
                    state_12.__p_KNBWKTUbqdOQW67KuhYEHj = Output_36;
                    n1.NodeContext Node_Context_37 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "O2goAio1o2CPaCusGfDdkL", 360554U);
                    var Output_38 = n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_37);
                    state_12.__p_O2goAio1o2CPaCusGfDdkL = Output_38;
                    n1.NodeContext Node_Context_39 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "TdNcJm1yZGyLMeEhLmWf4m", 360567U);
                    var Output_40 = n75.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n6.Vector3>.Create(Node_Context: Node_Context_39);
                    state_12.__p_TdNcJm1yZGyLMeEhLmWf4m = Output_40;
                    n1.NodeContext Node_Context_41 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "HugvFunRSIpL4zJNxmfbcy", 360571U);
                    var Output_42 = n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_41);
                    state_12.__p_HugvFunRSIpL4zJNxmfbcy = Output_42;
                    n1.NodeContext Node_Context_43 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "HcHrJdlvJVcOiDrRqV08QM", 360592U);
                    var Output_44 = n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector4>.Create(Node_Context: Node_Context_43);
                    state_12.__p_HcHrJdlvJVcOiDrRqV08QM = Output_44;
                    n1.NodeContext Node_Context_45 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "I4DoOhZMIChLduYUaqPa7B", 360607U);
                    var Output_46 = n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n54.GpuVoid>.Create(Node_Context: Node_Context_45);
                    state_12.__p_I4DoOhZMIChLduYUaqPa7B = Output_46;
                    n1.NodeContext Node_Context_47 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "CuiQsSE6qJ7MMqis8yTSvm", 360671U);
                    var Output_48 = n80.Invoke_C<n6.Vector3>.Create(Node_Context: Node_Context_47);
                    state_12.__p_CuiQsSE6qJ7MMqis8yTSvm = Output_48;
                    n1.NodeContext Node_Context_49 = __GetContext__().CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "CPwhMCynf8XNuyydTWS4Yi", 360693U);
                    var Output_50 = n82.To_Qgkn15Kxt1HLURmAdSAN7m<n6.Int3, n6.Vector3>.Create(Node_Context: Node_Context_49);
                    state_12.__p_CPwhMCynf8XNuyydTWS4Yi = Output_50;
                }

                string __pad_Fml5zKCCJpgLIMagV1lgXr_51 = __slot_Fml5zKCCJpgLIMagV1lgXr;
                string __pad_ENh7BpxR2NcQLgmZNnfpJU_52 = __slot_ENh7BpxR2NcQLgmZNnfpJU;
                float __pad_Cu9lp1QsY2MMOGlFBFKpyR_53 = __slot_Cu9lp1QsY2MMOGlFBFKpyR;
                n15.ObjectHelpers.IsAssigned(x: __auto_1, result: out bool Result_54, notAssigned: out bool Not_Assigned_55);
                n28.GpuValue<bool> Values_56 = state_12.__monadBuilder_DjFJzSeJNvWQdQtj6Mkzje.Return(Result_54);
                n28.GpuValue<bool> Values_2_57 = state_12.__monadBuilder_MIe9yI0Wq6HLpcHEbiDGVr.Return(__auto_2);
                var Output_63 = __auto_3.GetTextureWithName(Texture_Name_In: __pad_ENh7BpxR2NcQLgmZNnfpJU_52, Texture_Read_Out: out n27.Texture Texture_Read_58, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_59, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_60, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_61, Found_Out: out bool Found_62);
                var State_Output_65 = state_12.__p_DbV3SyKnKxhPYYTptHAvGb.GetOutput(Output_Out: out n28.GpuValue<n6.Int3> Output_64);
                n28.GpuValue<float> default_66 = default(n28.GpuValue<float>);
                var State_Output_68 = state_12.__p_L7AVHquRoBPONI1jNJh2qX.Update(Texture_In: Texture_Read_Graph_59, index_In: Output_64, default_In: default_66, Output_Out: out n28.GpuValue<float> Output_67);
                var Output_70 = state_12.__p_JdbDYtdJwhmO4LgmTz9VtO.Update(Value_In: __pad_Cu9lp1QsY2MMOGlFBFKpyR_53, GpuValue_Out: out n28.GpuValue<float> GpuValue_69);
                var Output_72 = state_12.__p_Fpnac3G1CagMkW2Vu0d6r6.Update(x_In: Output_67, y_In: GpuValue_69, value_Out: out n28.GpuValue<bool> value_71);
                var builder_73 = n5.CollectionBuilders.GetBuilder(state_12.__pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF, 3);
                builder_73.Add(Values_56);
                builder_73.Add(Values_2_57);
                builder_73.Add(value_71);
                var __pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF_74 = builder_73.Commit();
                var State_Output_76 = state_12.__p_SOAnI1kmaUbOtXklbsjSyF.Update(Values_In: __pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF_74, Output_Out: out n28.GpuValue<bool> Output_75);
                var Output_82 = __auto_3.GetTextureWithName(Texture_Name_In: __pad_Fml5zKCCJpgLIMagV1lgXr_51, Texture_Read_Out: out n27.Texture Texture_Read_77, Texture_Read_Graph_Out: out n28.GpuValue<n27.Texture> Texture_Read_Graph_78, Texture_ReadWrite_Out: out n27.Texture Texture_ReadWrite_79, Texture_ReadWrite_Graph_Out: out n28.GpuValue<n27.Texture> Texture_ReadWrite_Graph_80, Found_Out: out bool Found_81);
                var State_Output_84 = state_12.__p_O2goAio1o2CPaCusGfDdkL.GetOutput(Output_Out: out n28.GpuValue<n6.Int3> Output_83);
                n28.GpuValue<n6.Vector4> default_85 = default(n28.GpuValue<n6.Vector4>);
                var State_Output_87 = state_12.__p_DAqw1iiIrwjQKxvsjvAi2H.Update(Texture_In: Texture_Read_Graph_78, index_In: Output_83, default_In: default_85, Output_Out: out n28.GpuValue<n6.Vector4> Output_86);
                n28.GpuValue<n6.Vector3> default_88 = default(n28.GpuValue<n6.Vector3>);
                var State_Output_90 = state_12.__p_CPwhMCynf8XNuyydTWS4Yi.Update(x_In: Output_83, default_In: default_88, Output_Out: out n28.GpuValue<n6.Vector3> Output_89);
                n28.GpuValue<n6.Vector3> __pad_T1IpKypMVYxQB6DBLnX8YG_91 = Output_89;
                var State_Output_93 = state_12.__p_R6glZvHSmQLQCXhGE6QLlT.Update(Input_In: Output_86, Output_Out: out n28.GpuValue<n6.Vector3> Output_92);
                var builder_94 = n5.CollectionBuilders.GetBuilder(state_12.__pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm, 1);
                builder_94.Add(__pad_T1IpKypMVYxQB6DBLnX8YG_91);
                var __pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm_95 = builder_94.Commit();
                var State_Output_97 = state_12.__p_CuiQsSE6qJ7MMqis8yTSvm.Update(Function_In: __auto_6, Parameters_In: __pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm_95, Output_Out: out n28.GpuValue<n6.Vector3> Output_96);
                var State_Output_99 = state_12.__p_FuEAIOKIRJ3N4GcrZv5bcT.Update(Input_In: Output_96, Output_Out: out n28.GpuValue<float> Output_98);
                var Output_101 = state_12.__p_VB8QgjO1tkLNjkK76s4pnt.Update(x_In: Output_98, y_In: __auto_5, value_Out: out n28.GpuValue<bool> value_100);
                n28.GpuValue<n6.Vector3> The_Default_102 = default(n28.GpuValue<n6.Vector3>);
                var State_Output_104 = state_12.__p_KNBWKTUbqdOQW67KuhYEHj.Update(In_Check_In: value_100, In_False_In: Output_92, In_True_In: Output_96, The_Default_In: The_Default_102, Output_Out: out n28.GpuValue<n6.Vector3> Output_103);
                var builder_105 = n5.CollectionBuilders.GetBuilder(state_12.__pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m, 2);
                builder_105.Add(Output_92);
                builder_105.Add(Output_96);
                var __pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m_106 = builder_105.Commit();
                var State_Output_108 = state_12.__p_TdNcJm1yZGyLMeEhLmWf4m.Update(Input_In: __pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m_106, Output_Out: out n28.GpuValue<n6.Vector3> Output_107);
                n39._Operations_.Switch_Boolean<n28.GpuValue<n6.Vector3>>(Condition_In: __auto_4, Input_In: Output_103, Input_2_In: Output_107, Output_Out: out n28.GpuValue<n6.Vector3> Output_109);
                n28.GpuValue<float> w_110 = default(n28.GpuValue<float>);
                var State_Output_112 = state_12.__p_HugvFunRSIpL4zJNxmfbcy.Update(xyz_In: Output_109, w_In: w_110, Output_Out: out n28.GpuValue<n6.Vector4> Output_111);
                n28.GpuValue<n6.Vector4> The_Default_113 = default(n28.GpuValue<n6.Vector4>);
                var State_Output_115 = state_12.__p_HcHrJdlvJVcOiDrRqV08QM.Update(In_Check_In: Output_75, In_False_In: Output_86, In_True_In: Output_111, The_Default_In: The_Default_113, Output_Out: out n28.GpuValue<n6.Vector4> Output_114);
                var State_Output_117 = state_12.__p_FWzJr8akSf7MQvVkO0Uqtr.GetOutput(Output_Out: out n28.GpuValue<n6.Int3> Output_116);
                var State_Output_119 = state_12.__p_MPNNDwnZOZTOIWQ8pLKhcu.Update(Texture_In: Texture_ReadWrite_Graph_80, index_In: Output_116, value_In: Output_114, Output_Out: out n28.GpuValue<n54.GpuVoid> Output_118);
                n28.GpuValue<n54.GpuVoid> In_False_120 = default(n28.GpuValue<n54.GpuVoid>);
                n28.GpuValue<n54.GpuVoid> The_Default_121 = default(n28.GpuValue<n54.GpuVoid>);
                var State_Output_123 = state_12.__p_I4DoOhZMIChLduYUaqPa7B.Update(In_Check_In: Output_75, In_False_In: In_False_120, In_True_In: Output_118, The_Default_In: The_Default_121, Output_Out: out n28.GpuValue<n54.GpuVoid> Output_122);
                state_12.__p_DbV3SyKnKxhPYYTptHAvGb = State_Output_65;
                state_12.__p_L7AVHquRoBPONI1jNJh2qX = State_Output_68;
                state_12.__p_JdbDYtdJwhmO4LgmTz9VtO = Output_70;
                state_12.__p_Fpnac3G1CagMkW2Vu0d6r6 = Output_72;
                state_12.__pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF = __pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF_74;
                state_12.__p_SOAnI1kmaUbOtXklbsjSyF = State_Output_76;
                state_12.__p_O2goAio1o2CPaCusGfDdkL = State_Output_84;
                state_12.__p_DAqw1iiIrwjQKxvsjvAi2H = State_Output_87;
                state_12.__p_CPwhMCynf8XNuyydTWS4Yi = State_Output_90;
                state_12.__slot_T1IpKypMVYxQB6DBLnX8YG = Output_89;
                state_12.__p_R6glZvHSmQLQCXhGE6QLlT = State_Output_93;
                state_12.__pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm = __pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm_95;
                state_12.__p_CuiQsSE6qJ7MMqis8yTSvm = State_Output_97;
                state_12.__p_FuEAIOKIRJ3N4GcrZv5bcT = State_Output_99;
                state_12.__p_VB8QgjO1tkLNjkK76s4pnt = Output_101;
                state_12.__p_KNBWKTUbqdOQW67KuhYEHj = State_Output_104;
                state_12.__pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m = __pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m_106;
                state_12.__p_TdNcJm1yZGyLMeEhLmWf4m = State_Output_108;
                state_12.__p_HugvFunRSIpL4zJNxmfbcy = State_Output_112;
                state_12.__p_HcHrJdlvJVcOiDrRqV08QM = State_Output_115;
                state_12.__p_FWzJr8akSf7MQvVkO0Uqtr = State_Output_117;
                state_12.__p_MPNNDwnZOZTOIWQ8pLKhcu = State_Output_119;
                state_12.__p_I4DoOhZMIChLduYUaqPa7B = State_Output_123;
                outputs_10 = n2.ValueTuple.Create(Output_118);
                manager_8 = manager_8.Update(inputs_9, __GetContext__().IsImmutable, Dispose_Cached_Outputs_7, state_12, outputs_10);
            }
            else
            {
                manager_8.Update(inputs_9, __GetContext__().IsImmutable, Dispose_Cached_Outputs_7);
            }

            var __auto_124 = outputs_10.Item1;
            this.__cache_QFcWxarzOD7NMh8d9NEhYz = manager_8;
            Graph_Out = __auto_124;
            return this;
        }

        public n11.DynamicVectorField_Fluid3D_C Configure(n27.Texture Texture_In, [n5.SerializedDefaultValueAttribute("1", false)] float Strength_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Additive_In, n28.GpuValue<float> Threshold_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Helper_Enabled_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, n28.GpuValue<n6.Vector3> Gravity_In)
        {
            this.Texture = Texture_In;
            n27.Texture __auto_0 = Texture_In;
            this.Strength = Strength_In;
            float __auto_1 = Strength_In;
            this.Additive = Additive_In;
            bool __auto_2 = Additive_In;
            this.Threshold = Threshold_In;
            n28.GpuValue<float> __auto_3 = Threshold_In;
            this.Helper_Enabled = Helper_Enabled_In;
            bool __auto_4 = Helper_Enabled_In;
            this.Enabled = Enabled_In;
            bool __auto_5 = Enabled_In;
            this.Gravity = Gravity_In;
            n28.GpuValue<n6.Vector3> __auto_6 = Gravity_In;
            return this;
        }

        public n11.DynamicVectorField_Fluid3D_C GetHelperEntity_(out n43.Entity Helper_Entity_Out)
        {
            n28.AbstractGpuValue __pad_EOpGRI0HOT0PXpSWMsSirp_0 = __slot_EOpGRI0HOT0PXpSWMsSirp;
            var Output_2 = this.__p_R7YqwoD7W8MQEMJxefVKrh.Update(Input_In: __pad_EOpGRI0HOT0PXpSWMsSirp_0, Entity_Out: out n43.Entity Entity_1);
            this.__p_R7YqwoD7W8MQEMJxefVKrh = Output_2;
            Helper_Entity_Out = Entity_1;
            return this;
        }

        public n11.DynamicVectorField_Fluid3D_C GetHelperEnabled_(out bool Helper_Enabled_Out)
        {
            bool __auto_0 = this.Helper_Enabled;
            Helper_Enabled_Out = __auto_0;
            return this;
        }

        public n11.DynamicVectorField_Fluid3D_C GetUVZProjectedCoordinates()
        {
            return this;
        }

        public n11.DynamicVectorField_Fluid3D_C SetContext_(n4.FluidContext_C Context_In)
        {
            this.Context = Context_In;
            n4.FluidContext_C __auto_0 = Context_In;
            return this;
        }

        public n11.DynamicVectorField_Fluid3D_C __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Texture = default(n27.Texture);
            this.Additive = false;
            this.Strength = 0F;
            this.Enabled = false;
            this.Helper_Enabled = false;
            this.Threshold = default(n28.GpuValue<float>);
            this.Gravity = default(n28.GpuValue<n6.Vector3>);
            this.Context = n4.FluidContext_C.CreateDefault();
            bool __pad_MWIBbgWHoJQLKriyDYKMkX_0 = __slot_MWIBbgWHoJQLKriyDYKMkX;
            float __pad_PuW2ZjNMcCPNAdJkoDrK4I_1 = __slot_PuW2ZjNMcCPNAdJkoDrK4I;
            bool __pad_RjYWEA3wDBVN1GUAjGRr49_2 = __slot_RjYWEA3wDBVN1GUAjGRr49;
            bool __pad_LvvPvd2THDMNYEzV0HG6Ji_3 = __slot_LvvPvd2THDMNYEzV0HG6Ji;
            this.Additive = __pad_MWIBbgWHoJQLKriyDYKMkX_0;
            bool __auto_4 = __pad_MWIBbgWHoJQLKriyDYKMkX_0;
            this.Strength = __pad_PuW2ZjNMcCPNAdJkoDrK4I_1;
            float __auto_5 = __pad_PuW2ZjNMcCPNAdJkoDrK4I_1;
            this.Enabled = __pad_RjYWEA3wDBVN1GUAjGRr49_2;
            bool __auto_6 = __pad_RjYWEA3wDBVN1GUAjGRr49_2;
            this.Helper_Enabled = __pad_LvvPvd2THDMNYEzV0HG6Ji_3;
            bool __auto_7 = __pad_LvvPvd2THDMNYEzV0HG6Ji_3;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "R7YqwoD7W8MQEMJxefVKrh", 360833U);
            var Output_9 = n79.GetHelper_SIlUS90jQlRLGG88cf3x83.Create(Node_Context: Node_Context_8);
            this.__p_R7YqwoD7W8MQEMJxefVKrh = Output_9;
            this.__cache_QFcWxarzOD7NMh8d9NEhYz = null;
            return this;
        }

        public n11.DynamicVectorField_Fluid3D_C __CreateDefault__()
        {
            this.Texture = default(n27.Texture);
            this.Additive = false;
            this.Strength = 0F;
            this.Enabled = false;
            this.Helper_Enabled = false;
            this.Threshold = default(n28.GpuValue<float>);
            this.Gravity = default(n28.GpuValue<n6.Vector3>);
            this.Context = n4.FluidContext_C.CreateDefault();
            this.__cache_QFcWxarzOD7NMh8d9NEhYz = null;
            this.__p_R7YqwoD7W8MQEMJxefVKrh = n79.GetHelper_SIlUS90jQlRLGG88cf3x83.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_QFcWxarzOD7NMh8d9NEhYz);
            n1.CompilationHelper.SafeDispose(this.__p_R7YqwoD7W8MQEMJxefVKrh);
            return;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.GetHelperEntity(out n43.Entity Helper_Entity_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetHelperEntity_(out Helper_Entity_Out);
            return __returnValue__;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.GetHelperEnabled(out bool Helper_Enabled_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetHelperEnabled_(out Helper_Enabled_Out);
            return __returnValue__;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.SetContext(n4.FluidContext_C Context_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = SetContext_(Context_In);
            return __returnValue__;
        }

        n11.IPostTexAdvectComputeGraphProvider_I n11.IPostTexAdvectComputeGraphProvider_I.GetPriority(out float Priority_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Priority_Out = 0F;
            return this;
        }

        n11.IPostTexAdvectComputeGraphProvider_I n11.IPostTexAdvectComputeGraphProvider_I.Update(out n28.GpuValue<n54.GpuVoid> Graph_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Update_(out Graph_Out);
            return __returnValue__;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 360153U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MWIBbgWHoJQLKriyDYKMkX", Name = "__slot_MWIBbgWHoJQLKriyDYKMkX")]
        public static bool __slot_MWIBbgWHoJQLKriyDYKMkX = true;
        [n1.ElementAttribute(TracingId = 360165U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "PuW2ZjNMcCPNAdJkoDrK4I", Name = "__slot_PuW2ZjNMcCPNAdJkoDrK4I")]
        public static float __slot_PuW2ZjNMcCPNAdJkoDrK4I = 1F;
        [n1.ElementAttribute(TracingId = 360193U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RjYWEA3wDBVN1GUAjGRr49", Name = "__slot_RjYWEA3wDBVN1GUAjGRr49")]
        public static bool __slot_RjYWEA3wDBVN1GUAjGRr49 = true;
        [n1.ElementAttribute(TracingId = 360211U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LvvPvd2THDMNYEzV0HG6Ji", Name = "__slot_LvvPvd2THDMNYEzV0HG6Ji")]
        public static bool __slot_LvvPvd2THDMNYEzV0HG6Ji = true;
        [n1.ElementAttribute(TracingId = 360847U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EOpGRI0HOT0PXpSWMsSirp", Name = "__slot_EOpGRI0HOT0PXpSWMsSirp")]
        public static n28.AbstractGpuValue __slot_EOpGRI0HOT0PXpSWMsSirp = default(n28.AbstractGpuValue);
        [n1.ElementAttribute(TracingId = 360861U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "NT2EkzWh2ShMUlt1oTguLC", Name = "__slot_NT2EkzWh2ShMUlt1oTguLC")]
        public static bool __slot_NT2EkzWh2ShMUlt1oTguLC = false;
        [n1.ElementAttribute(TracingId = 360140U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DpBxEv6fdbBQboiHXyDnog", Name = "Texture")]
        public n27.Texture Texture;
        [n1.ElementAttribute(TracingId = 360131U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Tqh7HDVvLJ6N4Q3JBfdibV", Name = "Additive")]
        public bool Additive;
        [n1.ElementAttribute(TracingId = 360144U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Jan8OUika5YLya3njFPaQT", Name = "Strength")]
        public float Strength;
        [n1.ElementAttribute(TracingId = 360174U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Ou0XdkCD4tzP5BQHkZv6Ak", Name = "Enabled")]
        public bool Enabled;
        [n1.ElementAttribute(TracingId = 360185U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SZpX6FvxetjQU4XlQWwK2b", Name = "Helper Enabled")]
        public bool Helper_Enabled;
        [n1.ElementAttribute(TracingId = 360222U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OaFQLRY3FPxPmVERAraJo2", Name = "Threshold")]
        public n28.GpuValue<float> Threshold;
        [n1.ElementAttribute(TracingId = 360853U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Dso8A22r9IfOWnfYzN8pag", Name = "Gravity")]
        public n28.GpuValue<n6.Vector3> Gravity;
        [n1.ElementAttribute(TracingId = 360878U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IUTbAzV9R3pL4sykiAyyH7", Name = "Context")]
        public n4.FluidContext_C Context;
        [n1.ElementAttribute(TracingId = 360237U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QFcWxarzOD7NMh8d9NEhYz", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<n27.Texture, bool, n4.FluidContext_C, bool, n28.GpuValue<float>, n28.GpuValue<n6.Vector3>>, n2.ValueTuple<n28.GpuValue<n54.GpuVoid>>> __cache_QFcWxarzOD7NMh8d9NEhYz = null;
        [n1.ElementAttribute(TracingId = 360776U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Fml5zKCCJpgLIMagV1lgXr", Name = "__slot_Fml5zKCCJpgLIMagV1lgXr")]
        public static string __slot_Fml5zKCCJpgLIMagV1lgXr = "Velocity";
        [n1.ElementAttribute(TracingId = 360819U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ENh7BpxR2NcQLgmZNnfpJU", Name = "__slot_ENh7BpxR2NcQLgmZNnfpJU")]
        public static string __slot_ENh7BpxR2NcQLgmZNnfpJU = "ObstaclesGradient";
        [n1.ElementAttribute(TracingId = 360378U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Cu9lp1QsY2MMOGlFBFKpyR", Name = "__slot_Cu9lp1QsY2MMOGlFBFKpyR")]
        public static float __slot_Cu9lp1QsY2MMOGlFBFKpyR = 0.09999999F;
        [n1.ElementAttribute(TracingId = 360833U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "R7YqwoD7W8MQEMJxefVKrh", Name = "GetHelper", IsManaged = true, IsAutoGenerated = true)]
        public n79.GetHelper_SIlUS90jQlRLGG88cf3x83 __p_R7YqwoD7W8MQEMJxefVKrh;
        static DynamicVectorField_Fluid3D_C()
        {
        }

        public DynamicVectorField_Fluid3D_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DynamicVectorField_Fluid3D_C(DynamicVectorField_Fluid3D_C other): base(other)
        {
            this.Texture = other.Texture;
            this.Additive = other.Additive;
            this.Strength = other.Strength;
            this.Enabled = other.Enabled;
            this.Helper_Enabled = other.Helper_Enabled;
            this.Threshold = other.Threshold;
            this.Gravity = other.Gravity;
            this.Context = other.Context;
            this.__cache_QFcWxarzOD7NMh8d9NEhYz = other.__cache_QFcWxarzOD7NMh8d9NEhYz;
            this.__p_R7YqwoD7W8MQEMJxefVKrh = other.__p_R7YqwoD7W8MQEMJxefVKrh;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Texture", in Texture), n1.CompilationHelper.GetValueOrExisting(values, "Additive", in Additive), n1.CompilationHelper.GetValueOrExisting(values, "Strength", in Strength), n1.CompilationHelper.GetValueOrExisting(values, "Enabled", in Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Helper_Enabled", in Helper_Enabled), n1.CompilationHelper.GetValueOrExisting(values, "Threshold", in Threshold), n1.CompilationHelper.GetValueOrExisting(values, "Gravity", in Gravity), n1.CompilationHelper.GetValueOrExisting(values, "Context", in Context), n1.CompilationHelper.GetValueOrExisting(values, "__cache_QFcWxarzOD7NMh8d9NEhYz", in __cache_QFcWxarzOD7NMh8d9NEhYz), n1.CompilationHelper.GetValueOrExisting(values, "__p_R7YqwoD7W8MQEMJxefVKrh", in __p_R7YqwoD7W8MQEMJxefVKrh));
        }

        internal DynamicVectorField_Fluid3D_C __WITH__(n27.Texture Texture, bool Additive, float Strength, bool Enabled, bool Helper_Enabled, n28.GpuValue<float> Threshold, n28.GpuValue<n6.Vector3> Gravity, n4.FluidContext_C Context, n13.Manager<n2.ValueTuple<n27.Texture, bool, n4.FluidContext_C, bool, n28.GpuValue<float>, n28.GpuValue<n6.Vector3>>, n2.ValueTuple<n28.GpuValue<n54.GpuVoid>>> __cache_QFcWxarzOD7NMh8d9NEhYz, n79.GetHelper_SIlUS90jQlRLGG88cf3x83 __p_R7YqwoD7W8MQEMJxefVKrh)
        {
            n11.DynamicVectorField_Fluid3D_C that_0 = this;
            this.Texture = Texture;
            this.Additive = Additive;
            this.Strength = Strength;
            this.Enabled = Enabled;
            this.Helper_Enabled = Helper_Enabled;
            this.Threshold = Threshold;
            this.Gravity = Gravity;
            this.Context = Context;
            this.__cache_QFcWxarzOD7NMh8d9NEhYz = __cache_QFcWxarzOD7NMh8d9NEhYz;
            this.__p_R7YqwoD7W8MQEMJxefVKrh = __p_R7YqwoD7W8MQEMJxefVKrh;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Fu7PgYb9CYpLrAIxzsvcDp", Name = "__Fu7PgYb9CYpLrAIxzsvcDp")]
        [n2.SerializableAttribute]
        public class __Fu7PgYb9CYpLrAIxzsvcDp : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_L7AVHquRoBPONI1jNJh2qX);
                n1.CompilationHelper.SafeDispose(this.__p_DbV3SyKnKxhPYYTptHAvGb);
                n1.CompilationHelper.SafeDispose(this.__p_Fpnac3G1CagMkW2Vu0d6r6);
                n1.CompilationHelper.SafeDispose(this.__p_JdbDYtdJwhmO4LgmTz9VtO);
                n1.CompilationHelper.SafeDispose(this.__p_SOAnI1kmaUbOtXklbsjSyF);
                n1.CompilationHelper.SafeDispose(this.__p_MPNNDwnZOZTOIWQ8pLKhcu);
                n1.CompilationHelper.SafeDispose(this.__p_FWzJr8akSf7MQvVkO0Uqtr);
                n1.CompilationHelper.SafeDispose(this.__p_FuEAIOKIRJ3N4GcrZv5bcT);
                n1.CompilationHelper.SafeDispose(this.__p_VB8QgjO1tkLNjkK76s4pnt);
                n1.CompilationHelper.SafeDispose(this.__p_R6glZvHSmQLQCXhGE6QLlT);
                n1.CompilationHelper.SafeDispose(this.__p_DAqw1iiIrwjQKxvsjvAi2H);
                n1.CompilationHelper.SafeDispose(this.__p_KNBWKTUbqdOQW67KuhYEHj);
                n1.CompilationHelper.SafeDispose(this.__p_O2goAio1o2CPaCusGfDdkL);
                n1.CompilationHelper.SafeDispose(this.__p_TdNcJm1yZGyLMeEhLmWf4m);
                n1.CompilationHelper.SafeDispose(this.__p_HugvFunRSIpL4zJNxmfbcy);
                n1.CompilationHelper.SafeDispose(this.__p_HcHrJdlvJVcOiDrRqV08QM);
                n1.CompilationHelper.SafeDispose(this.__p_I4DoOhZMIChLduYUaqPa7B);
                n1.CompilationHelper.SafeDispose(this.__p_CuiQsSE6qJ7MMqis8yTSvm);
                n1.CompilationHelper.SafeDispose(this.__p_CPwhMCynf8XNuyydTWS4Yi);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_DjFJzSeJNvWQdQtj6Mkzje);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_MIe9yI0Wq6HLpcHEbiDGVr);
                return;
            }

            [n1.ElementAttribute(TracingId = 360298U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "L7AVHquRoBPONI1jNJh2qX", Name = "TextureGet", IsManaged = true, IsAutoGenerated = true)]
            public n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, float> __p_L7AVHquRoBPONI1jNJh2qX;
            [n1.ElementAttribute(TracingId = 360316U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DbV3SyKnKxhPYYTptHAvGb", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
            public n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_DbV3SyKnKxhPYYTptHAvGb;
            [n1.ElementAttribute(TracingId = 360328U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Fpnac3G1CagMkW2Vu0d6r6", Name = "<", IsManaged = true, IsAutoGenerated = true)]
            public n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_Fpnac3G1CagMkW2Vu0d6r6;
            [n1.ElementAttribute(TracingId = 360359U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JdbDYtdJwhmO4LgmTz9VtO", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_JdbDYtdJwhmO4LgmTz9VtO;
            [n1.ElementAttribute(TracingId = 360380U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SOAnI1kmaUbOtXklbsjSyF", Name = "AND", IsManaged = true, IsAutoGenerated = true)]
            public n59.AND_TkWZzQWwZ0tLZt6ooZGazh __p_SOAnI1kmaUbOtXklbsjSyF;
            [n1.ElementAttribute(TracingId = 360399U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MPNNDwnZOZTOIWQ8pLKhcu", Name = "TextureSet", IsManaged = true, IsAutoGenerated = true)]
            public n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, n6.Vector4> __p_MPNNDwnZOZTOIWQ8pLKhcu;
            [n1.ElementAttribute(TracingId = 360422U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FWzJr8akSf7MQvVkO0Uqtr", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
            public n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_FWzJr8akSf7MQvVkO0Uqtr;
            [n1.ElementAttribute(TracingId = 360434U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FuEAIOKIRJ3N4GcrZv5bcT", Name = "Length", IsManaged = true, IsAutoGenerated = true)]
            public n75.Length_P0UB6WKESd0PjWRm8eD1d4<n6.Vector3> __p_FuEAIOKIRJ3N4GcrZv5bcT;
            [n1.ElementAttribute(TracingId = 360448U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "VB8QgjO1tkLNjkK76s4pnt", Name = ">", IsManaged = true, IsAutoGenerated = true)]
            public n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_VB8QgjO1tkLNjkK76s4pnt;
            [n1.ElementAttribute(TracingId = 360490U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "R6glZvHSmQLQCXhGE6QLlT", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
            public n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_R6glZvHSmQLQCXhGE6QLlT;
            [n1.ElementAttribute(TracingId = 360497U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "DAqw1iiIrwjQKxvsjvAi2H", Name = "TextureGet", IsManaged = true, IsAutoGenerated = true)]
            public n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, n6.Vector4> __p_DAqw1iiIrwjQKxvsjvAi2H;
            [n1.ElementAttribute(TracingId = 360527U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "KNBWKTUbqdOQW67KuhYEHj", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
            public n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector3> __p_KNBWKTUbqdOQW67KuhYEHj;
            [n1.ElementAttribute(TracingId = 360554U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "O2goAio1o2CPaCusGfDdkL", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
            public n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_O2goAio1o2CPaCusGfDdkL;
            [n1.ElementAttribute(TracingId = 360567U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TdNcJm1yZGyLMeEhLmWf4m", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n75.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n6.Vector3> __p_TdNcJm1yZGyLMeEhLmWf4m;
            [n1.ElementAttribute(TracingId = 360571U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "HugvFunRSIpL4zJNxmfbcy", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_HugvFunRSIpL4zJNxmfbcy;
            [n1.ElementAttribute(TracingId = 360592U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "HcHrJdlvJVcOiDrRqV08QM", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
            public n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector4> __p_HcHrJdlvJVcOiDrRqV08QM;
            [n1.ElementAttribute(TracingId = 360607U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "I4DoOhZMIChLduYUaqPa7B", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
            public n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n54.GpuVoid> __p_I4DoOhZMIChLduYUaqPa7B;
            [n1.ElementAttribute(TracingId = 360671U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CuiQsSE6qJ7MMqis8yTSvm", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n80.Invoke_C<n6.Vector3> __p_CuiQsSE6qJ7MMqis8yTSvm;
            [n1.ElementAttribute(TracingId = 360693U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CPwhMCynf8XNuyydTWS4Yi", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n82.To_Qgkn15Kxt1HLURmAdSAN7m<n6.Int3, n6.Vector3> __p_CPwhMCynf8XNuyydTWS4Yi;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_DjFJzSeJNvWQdQtj6Mkzje = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_MIe9yI0Wq6HLpcHEbiDGVr = n28.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n28.GpuValue<bool>> __pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF = default(n12.Spread<n28.GpuValue<bool>>);
            [n1.ElementAttribute(TracingId = 360711U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "T1IpKypMVYxQB6DBLnX8YG", Name = "__slot_T1IpKypMVYxQB6DBLnX8YG")]
            public n28.GpuValue<n6.Vector3> __slot_T1IpKypMVYxQB6DBLnX8YG;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n28.AbstractGpuValue> __pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm = default(n12.Spread<n28.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n12.Spread<n28.GpuValue<n6.Vector3>> __pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m = default(n12.Spread<n28.GpuValue<n6.Vector3>>);
            public __Fu7PgYb9CYpLrAIxzsvcDp(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Fu7PgYb9CYpLrAIxzsvcDp(__Fu7PgYb9CYpLrAIxzsvcDp other): base(other)
            {
                this.__p_L7AVHquRoBPONI1jNJh2qX = other.__p_L7AVHquRoBPONI1jNJh2qX;
                this.__p_DbV3SyKnKxhPYYTptHAvGb = other.__p_DbV3SyKnKxhPYYTptHAvGb;
                this.__p_Fpnac3G1CagMkW2Vu0d6r6 = other.__p_Fpnac3G1CagMkW2Vu0d6r6;
                this.__p_JdbDYtdJwhmO4LgmTz9VtO = other.__p_JdbDYtdJwhmO4LgmTz9VtO;
                this.__p_SOAnI1kmaUbOtXklbsjSyF = other.__p_SOAnI1kmaUbOtXklbsjSyF;
                this.__p_MPNNDwnZOZTOIWQ8pLKhcu = other.__p_MPNNDwnZOZTOIWQ8pLKhcu;
                this.__p_FWzJr8akSf7MQvVkO0Uqtr = other.__p_FWzJr8akSf7MQvVkO0Uqtr;
                this.__p_FuEAIOKIRJ3N4GcrZv5bcT = other.__p_FuEAIOKIRJ3N4GcrZv5bcT;
                this.__p_VB8QgjO1tkLNjkK76s4pnt = other.__p_VB8QgjO1tkLNjkK76s4pnt;
                this.__p_R6glZvHSmQLQCXhGE6QLlT = other.__p_R6glZvHSmQLQCXhGE6QLlT;
                this.__p_DAqw1iiIrwjQKxvsjvAi2H = other.__p_DAqw1iiIrwjQKxvsjvAi2H;
                this.__p_KNBWKTUbqdOQW67KuhYEHj = other.__p_KNBWKTUbqdOQW67KuhYEHj;
                this.__p_O2goAio1o2CPaCusGfDdkL = other.__p_O2goAio1o2CPaCusGfDdkL;
                this.__p_TdNcJm1yZGyLMeEhLmWf4m = other.__p_TdNcJm1yZGyLMeEhLmWf4m;
                this.__p_HugvFunRSIpL4zJNxmfbcy = other.__p_HugvFunRSIpL4zJNxmfbcy;
                this.__p_HcHrJdlvJVcOiDrRqV08QM = other.__p_HcHrJdlvJVcOiDrRqV08QM;
                this.__p_I4DoOhZMIChLduYUaqPa7B = other.__p_I4DoOhZMIChLduYUaqPa7B;
                this.__p_CuiQsSE6qJ7MMqis8yTSvm = other.__p_CuiQsSE6qJ7MMqis8yTSvm;
                this.__p_CPwhMCynf8XNuyydTWS4Yi = other.__p_CPwhMCynf8XNuyydTWS4Yi;
                this.__monadBuilder_DjFJzSeJNvWQdQtj6Mkzje = other.__monadBuilder_DjFJzSeJNvWQdQtj6Mkzje;
                this.__monadBuilder_MIe9yI0Wq6HLpcHEbiDGVr = other.__monadBuilder_MIe9yI0Wq6HLpcHEbiDGVr;
                this.__pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF = other.__pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF;
                this.__slot_T1IpKypMVYxQB6DBLnX8YG = other.__slot_T1IpKypMVYxQB6DBLnX8YG;
                this.__pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm = other.__pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm;
                this.__pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m = other.__pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m;
            }

            protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_L7AVHquRoBPONI1jNJh2qX", in __p_L7AVHquRoBPONI1jNJh2qX), n1.CompilationHelper.GetValueOrExisting(values, "__p_DbV3SyKnKxhPYYTptHAvGb", in __p_DbV3SyKnKxhPYYTptHAvGb), n1.CompilationHelper.GetValueOrExisting(values, "__p_Fpnac3G1CagMkW2Vu0d6r6", in __p_Fpnac3G1CagMkW2Vu0d6r6), n1.CompilationHelper.GetValueOrExisting(values, "__p_JdbDYtdJwhmO4LgmTz9VtO", in __p_JdbDYtdJwhmO4LgmTz9VtO), n1.CompilationHelper.GetValueOrExisting(values, "__p_SOAnI1kmaUbOtXklbsjSyF", in __p_SOAnI1kmaUbOtXklbsjSyF), n1.CompilationHelper.GetValueOrExisting(values, "__p_MPNNDwnZOZTOIWQ8pLKhcu", in __p_MPNNDwnZOZTOIWQ8pLKhcu), n1.CompilationHelper.GetValueOrExisting(values, "__p_FWzJr8akSf7MQvVkO0Uqtr", in __p_FWzJr8akSf7MQvVkO0Uqtr), n1.CompilationHelper.GetValueOrExisting(values, "__p_FuEAIOKIRJ3N4GcrZv5bcT", in __p_FuEAIOKIRJ3N4GcrZv5bcT), n1.CompilationHelper.GetValueOrExisting(values, "__p_VB8QgjO1tkLNjkK76s4pnt", in __p_VB8QgjO1tkLNjkK76s4pnt), n1.CompilationHelper.GetValueOrExisting(values, "__p_R6glZvHSmQLQCXhGE6QLlT", in __p_R6glZvHSmQLQCXhGE6QLlT), n1.CompilationHelper.GetValueOrExisting(values, "__p_DAqw1iiIrwjQKxvsjvAi2H", in __p_DAqw1iiIrwjQKxvsjvAi2H), n1.CompilationHelper.GetValueOrExisting(values, "__p_KNBWKTUbqdOQW67KuhYEHj", in __p_KNBWKTUbqdOQW67KuhYEHj), n1.CompilationHelper.GetValueOrExisting(values, "__p_O2goAio1o2CPaCusGfDdkL", in __p_O2goAio1o2CPaCusGfDdkL), n1.CompilationHelper.GetValueOrExisting(values, "__p_TdNcJm1yZGyLMeEhLmWf4m", in __p_TdNcJm1yZGyLMeEhLmWf4m), n1.CompilationHelper.GetValueOrExisting(values, "__p_HugvFunRSIpL4zJNxmfbcy", in __p_HugvFunRSIpL4zJNxmfbcy), n1.CompilationHelper.GetValueOrExisting(values, "__p_HcHrJdlvJVcOiDrRqV08QM", in __p_HcHrJdlvJVcOiDrRqV08QM), n1.CompilationHelper.GetValueOrExisting(values, "__p_I4DoOhZMIChLduYUaqPa7B", in __p_I4DoOhZMIChLduYUaqPa7B), n1.CompilationHelper.GetValueOrExisting(values, "__p_CuiQsSE6qJ7MMqis8yTSvm", in __p_CuiQsSE6qJ7MMqis8yTSvm), n1.CompilationHelper.GetValueOrExisting(values, "__p_CPwhMCynf8XNuyydTWS4Yi", in __p_CPwhMCynf8XNuyydTWS4Yi), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_DjFJzSeJNvWQdQtj6Mkzje", in __monadBuilder_DjFJzSeJNvWQdQtj6Mkzje), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_MIe9yI0Wq6HLpcHEbiDGVr", in __monadBuilder_MIe9yI0Wq6HLpcHEbiDGVr), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF", in __pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF), n1.CompilationHelper.GetValueOrExisting(values, "__slot_T1IpKypMVYxQB6DBLnX8YG", in __slot_T1IpKypMVYxQB6DBLnX8YG), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm", in __pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m", in __pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m));
            }

            internal __Fu7PgYb9CYpLrAIxzsvcDp __WITH__(n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, float> __p_L7AVHquRoBPONI1jNJh2qX, n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_DbV3SyKnKxhPYYTptHAvGb, n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_Fpnac3G1CagMkW2Vu0d6r6, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_JdbDYtdJwhmO4LgmTz9VtO, n59.AND_TkWZzQWwZ0tLZt6ooZGazh __p_SOAnI1kmaUbOtXklbsjSyF, n60.TextureSet_GTElf8F5BISPYwp53N4yR3<n28.GpuValue<n6.Int3>, n6.Vector4> __p_MPNNDwnZOZTOIWQ8pLKhcu, n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_FWzJr8akSf7MQvVkO0Uqtr, n75.Length_P0UB6WKESd0PjWRm8eD1d4<n6.Vector3> __p_FuEAIOKIRJ3N4GcrZv5bcT, n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_VB8QgjO1tkLNjkK76s4pnt, n76.xyz_T2WwCF9xAltPhlUuLjVDje __p_R6glZvHSmQLQCXhGE6QLlT, n60.TextureGet_UxJKLH9rdjAMjr7mGssWtV<n28.GpuValue<n6.Int3>, n6.Vector4> __p_DAqw1iiIrwjQKxvsjvAi2H, n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector3> __p_KNBWKTUbqdOQW67KuhYEHj, n56.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_O2goAio1o2CPaCusGfDdkL, n75.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n6.Vector3> __p_TdNcJm1yZGyLMeEhLmWf4m, n77.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_HugvFunRSIpL4zJNxmfbcy, n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n6.Vector4> __p_HcHrJdlvJVcOiDrRqV08QM, n59.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<n54.GpuVoid> __p_I4DoOhZMIChLduYUaqPa7B, n80.Invoke_C<n6.Vector3> __p_CuiQsSE6qJ7MMqis8yTSvm, n82.To_Qgkn15Kxt1HLURmAdSAN7m<n6.Int3, n6.Vector3> __p_CPwhMCynf8XNuyydTWS4Yi, n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_DjFJzSeJNvWQdQtj6Mkzje, n1.IMonadBuilder<bool, n28.GpuValue<bool>> __monadBuilder_MIe9yI0Wq6HLpcHEbiDGVr, n12.Spread<n28.GpuValue<bool>> __pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF, n28.GpuValue<n6.Vector3> __slot_T1IpKypMVYxQB6DBLnX8YG, n12.Spread<n28.AbstractGpuValue> __pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm, n12.Spread<n28.GpuValue<n6.Vector3>> __pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m)
            {
                __Fu7PgYb9CYpLrAIxzsvcDp that_0 = this;
                this.__p_L7AVHquRoBPONI1jNJh2qX = __p_L7AVHquRoBPONI1jNJh2qX;
                this.__p_DbV3SyKnKxhPYYTptHAvGb = __p_DbV3SyKnKxhPYYTptHAvGb;
                this.__p_Fpnac3G1CagMkW2Vu0d6r6 = __p_Fpnac3G1CagMkW2Vu0d6r6;
                this.__p_JdbDYtdJwhmO4LgmTz9VtO = __p_JdbDYtdJwhmO4LgmTz9VtO;
                this.__p_SOAnI1kmaUbOtXklbsjSyF = __p_SOAnI1kmaUbOtXklbsjSyF;
                this.__p_MPNNDwnZOZTOIWQ8pLKhcu = __p_MPNNDwnZOZTOIWQ8pLKhcu;
                this.__p_FWzJr8akSf7MQvVkO0Uqtr = __p_FWzJr8akSf7MQvVkO0Uqtr;
                this.__p_FuEAIOKIRJ3N4GcrZv5bcT = __p_FuEAIOKIRJ3N4GcrZv5bcT;
                this.__p_VB8QgjO1tkLNjkK76s4pnt = __p_VB8QgjO1tkLNjkK76s4pnt;
                this.__p_R6glZvHSmQLQCXhGE6QLlT = __p_R6glZvHSmQLQCXhGE6QLlT;
                this.__p_DAqw1iiIrwjQKxvsjvAi2H = __p_DAqw1iiIrwjQKxvsjvAi2H;
                this.__p_KNBWKTUbqdOQW67KuhYEHj = __p_KNBWKTUbqdOQW67KuhYEHj;
                this.__p_O2goAio1o2CPaCusGfDdkL = __p_O2goAio1o2CPaCusGfDdkL;
                this.__p_TdNcJm1yZGyLMeEhLmWf4m = __p_TdNcJm1yZGyLMeEhLmWf4m;
                this.__p_HugvFunRSIpL4zJNxmfbcy = __p_HugvFunRSIpL4zJNxmfbcy;
                this.__p_HcHrJdlvJVcOiDrRqV08QM = __p_HcHrJdlvJVcOiDrRqV08QM;
                this.__p_I4DoOhZMIChLduYUaqPa7B = __p_I4DoOhZMIChLduYUaqPa7B;
                this.__p_CuiQsSE6qJ7MMqis8yTSvm = __p_CuiQsSE6qJ7MMqis8yTSvm;
                this.__p_CPwhMCynf8XNuyydTWS4Yi = __p_CPwhMCynf8XNuyydTWS4Yi;
                this.__monadBuilder_DjFJzSeJNvWQdQtj6Mkzje = __monadBuilder_DjFJzSeJNvWQdQtj6Mkzje;
                this.__monadBuilder_MIe9yI0Wq6HLpcHEbiDGVr = __monadBuilder_MIe9yI0Wq6HLpcHEbiDGVr;
                this.__pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF = __pin_group_Values_In_SOAnI1kmaUbOtXklbsjSyF;
                this.__slot_T1IpKypMVYxQB6DBLnX8YG = __slot_T1IpKypMVYxQB6DBLnX8YG;
                this.__pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm = __pin_group_Parameters_In_CuiQsSE6qJ7MMqis8yTSvm;
                this.__pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m = __pin_group_Input_In_TdNcJm1yZGyLMeEhLmWf4m;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 361203U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "HcqJA7e3aCdLxTjviFiS5R", Name = "ITextureProvider_I")]
    public interface ITextureProvider_I : n1.IVLObject
    {
        public n11.ITextureProvider_I GetTextures(out n18.ImmutableDictionary<string, n4.ISimulationTexture_I> Textures_Out);
        public n11.ITextureProvider_I SetTextureSettings(n6.Int3 Size_In, bool Recreate_In);
    }

    [n1.ElementAttribute(TracingId = 361324U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "IC8b3FbpvjHPC37upYEa15", Name = "ITextureAdvectorProvider_I")]
    public interface ITextureAdvectorProvider_I : n1.IVLObject
    {
        public n11.ITextureAdvectorProvider_I GetTextureAdvectors(out n12.Spread<n4.TextureAdvector_C> Texture_Advectors_Out);
    }

    [n1.ElementAttribute(TracingId = 361356U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Ohes24nuK0NO3jsIE39k2A", Name = "AdvectedAttribute_C")]
    [n2.SerializableAttribute]
    public class AdvectedAttribute_C : n1.VLObject, n11.IFluidComponent_I, n11.ITextureProvider_I, n11.ITextureAdvectorProvider_I, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n11.AdvectedAttribute_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new AdvectedAttribute_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n11.AdvectedAttribute_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new AdvectedAttribute_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.AdvectedAttribute_C Update([n5.SerializedDefaultValueAttribute("Attribute", false)] string Attribute_Name_In, [n5.SerializedDefaultValueAttribute("R16G16B16A16_Float", false)] n3.PixelFormat Format_In, [n5.SerializedDefaultValueAttribute("1", false)] float Modulate_In, [n5.SerializedDefaultValueAttribute("1", false)] float Forward_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In)
        {
            string __pad_ToxDX52zVEPMJLCOSOvj6L_0 = __slot_ToxDX52zVEPMJLCOSOvj6L;
            n6.Int3 __auto_1 = this.Size;
            bool __pad_Px3Hc3gfLzePacEPmjyReE_2 = __slot_Px3Hc3gfLzePacEPmjyReE;
            string Input_2_3 = "Advector";
            var Output_4 = n92.StringExtensions.Plus(input: Attribute_Name_In, input2: Input_2_3);
            this.__slot_AZfqr94riWpLqaz0YAEnMH = Attribute_Name_In;
            string __pad_AZfqr94riWpLqaz0YAEnMH_5 = Attribute_Name_In;
            bool Update_6 = true;
            var Output_7 = this.__p_PcPAbGRkQtsQO5KmfMJ9j7;
            if (Update_6)
            {
                Output_7 = this.__p_PcPAbGRkQtsQO5KmfMJ9j7.Update(Name_In: Output_4, VectorField_Texture_Id_In: __pad_ToxDX52zVEPMJLCOSOvj6L_0, Target_Texture_Id_In: __pad_AZfqr94riWpLqaz0YAEnMH_5, Modulate_In: Modulate_In, Forward_In: Forward_In, Enabled_In: Enabled_In);
            }

            this.__p_PcPAbGRkQtsQO5KmfMJ9j7 = Output_7;
            this.Recreate = __pad_Px3Hc3gfLzePacEPmjyReE_2;
            bool __auto_8 = __pad_Px3Hc3gfLzePacEPmjyReE_2;
            bool Update_9 = true;
            var Output_10 = this.__p_JSDpS2oyJQWOal6mbACwTc;
            if (Update_9)
            {
                Output_10 = this.__p_JSDpS2oyJQWOal6mbACwTc.Update(Size_In: __auto_1, Format_In: Format_In, Recreate_In: __auto_8);
            }

            this.__p_JSDpS2oyJQWOal6mbACwTc = Output_10;
            bool Force_11 = false;
            bool Dispose_Cached_Outputs_12 = false;
            var manager_13 = this.__cache_TUIjIA342iHLDesYOS3Maf;
            if (manager_13 is null)
            {
                manager_13 = new n13.Manager<n2.ValueTuple<string, n4.PingPongTexture3D_Fluid_C>, n2.ValueTuple<n18.ImmutableDictionary<string, n4.ISimulationTexture_I>>>(n2.ValueTuple.Create(n93._Operations_.CreateDefault<string, n4.ISimulationTexture_I>()));
            }

            var inputs_14 = (Attribute_Name_In, Output_10);
            var outputs_15 = manager_13.Outputs;
            var Has_Changed_16 = Force_11 || manager_13.InputsChanged(inputs_14);
            if (Has_Changed_16)
            {
                if (Dispose_Cached_Outputs_12)
                    manager_13.DisposeOutputs();
                n4.ISimulationTexture_I Value_18 = (n4.ISimulationTexture_I)Output_10;
                n18.ImmutableDictionary<string, n4.ISimulationTexture_I> Input_19 = n93._Operations_.CreateDefault<string, n4.ISimulationTexture_I>();
                var Output_20 = Input_19.Add(key: Attribute_Name_In, value: Value_18);
                outputs_15 = n2.ValueTuple.Create(Output_20);
                manager_13 = manager_13.Update(inputs_14, __GetContext__().IsImmutable, Dispose_Cached_Outputs_12, default, outputs_15);
            }
            else
            {
                manager_13.Update(inputs_14, __GetContext__().IsImmutable, Dispose_Cached_Outputs_12);
            }

            var __auto_21 = outputs_15.Item1;
            this.__cache_TUIjIA342iHLDesYOS3Maf = manager_13;
            return this;
        }

        public n11.AdvectedAttribute_C GetTextureAdvectors_(out n12.Spread<n4.TextureAdvector_C> Texture_Advectors_Out)
        {
            var Output_0 = this.__p_PcPAbGRkQtsQO5KmfMJ9j7;
            var builder_1 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE, 1);
            builder_1.Add(Output_0);
            var __pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE_2 = builder_1.Commit();
            this.__pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE = __pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE_2;
            n14._Operations_.FromValue<n4.TextureAdvector_C>(Input_In: __pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE_2, Result_Out: out n12.Spread<n4.TextureAdvector_C> Result_3);
            Texture_Advectors_Out = Result_3;
            return this;
        }

        public n11.AdvectedAttribute_C SetTextureSettings_(n6.Int3 Size_In, bool Recreate_In)
        {
            this.Size = Size_In;
            n6.Int3 __auto_0 = Size_In;
            this.Recreate = Recreate_In;
            bool __auto_1 = Recreate_In;
            return this;
        }

        public n11.AdvectedAttribute_C GetTextures_(out n18.ImmutableDictionary<string, n4.ISimulationTexture_I> Textures_Out)
        {
            var manager_0 = this.__cache_TUIjIA342iHLDesYOS3Maf;
            if (manager_0 is null)
            {
                manager_0 = new n13.Manager<n2.ValueTuple<string, n4.PingPongTexture3D_Fluid_C>, n2.ValueTuple<n18.ImmutableDictionary<string, n4.ISimulationTexture_I>>>(n2.ValueTuple.Create(n93._Operations_.CreateDefault<string, n4.ISimulationTexture_I>()));
            }

            var __auto_1 = manager_0.Outputs.Item1;
            Textures_Out = __auto_1;
            return this;
        }

        public n11.AdvectedAttribute_C __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_AZfqr94riWpLqaz0YAEnMH = "";
            this.Size = default(n6.Int3);
            this.Recreate = false;
            this.__pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE = n14._Operations_.CreateDefault<n4.TextureAdvector_C>();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "JSDpS2oyJQWOal6mbACwTc", 361363U);
            var Output_1 = n4.PingPongTexture3D_Fluid_C.Create(Node_Context: Node_Context_0);
            this.__p_JSDpS2oyJQWOal6mbACwTc = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "PcPAbGRkQtsQO5KmfMJ9j7", 361377U);
            var Output_3 = n4.TextureAdvector_C.Create(Node_Context: Node_Context_2);
            this.__p_PcPAbGRkQtsQO5KmfMJ9j7 = Output_3;
            this.__cache_TUIjIA342iHLDesYOS3Maf = null;
            return this;
        }

        public n11.AdvectedAttribute_C __CreateDefault__()
        {
            this.__slot_AZfqr94riWpLqaz0YAEnMH = "";
            this.Size = default(n6.Int3);
            this.Recreate = false;
            this.__pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE = n14._Operations_.CreateDefault<n4.TextureAdvector_C>();
            this.__p_PcPAbGRkQtsQO5KmfMJ9j7 = n4.TextureAdvector_C.CreateDefault();
            this.__p_JSDpS2oyJQWOal6mbACwTc = n4.PingPongTexture3D_Fluid_C.CreateDefault();
            this.__cache_TUIjIA342iHLDesYOS3Maf = null;
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_PcPAbGRkQtsQO5KmfMJ9j7);
            n1.CompilationHelper.SafeDispose(this.__p_JSDpS2oyJQWOal6mbACwTc);
            n1.CompilationHelper.SafeDispose(this.__cache_TUIjIA342iHLDesYOS3Maf);
            return;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.GetHelperEntity(out n43.Entity Helper_Entity_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Helper_Entity_Out = default(n43.Entity);
            return this;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.GetHelperEnabled(out bool Helper_Enabled_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Helper_Enabled_Out = false;
            return this;
        }

        n11.IFluidComponent_I n11.IFluidComponent_I.SetContext(n4.FluidContext_C Context_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            return this;
        }

        n11.ITextureProvider_I n11.ITextureProvider_I.GetTextures(out n18.ImmutableDictionary<string, n4.ISimulationTexture_I> Textures_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetTextures_(out Textures_Out);
            return __returnValue__;
        }

        n11.ITextureProvider_I n11.ITextureProvider_I.SetTextureSettings(n6.Int3 Size_In, bool Recreate_In)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = SetTextureSettings_(Size_In, Recreate_In);
            return __returnValue__;
        }

        n11.ITextureAdvectorProvider_I n11.ITextureAdvectorProvider_I.GetTextureAdvectors(out n12.Spread<n4.TextureAdvector_C> Texture_Advectors_Out)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = GetTextureAdvectors_(out Texture_Advectors_Out);
            return __returnValue__;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 361412U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "ToxDX52zVEPMJLCOSOvj6L", Name = "__slot_ToxDX52zVEPMJLCOSOvj6L")]
        public static string __slot_ToxDX52zVEPMJLCOSOvj6L = "Velocity";
        [n1.ElementAttribute(TracingId = 361417U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "AZfqr94riWpLqaz0YAEnMH", Name = "__slot_AZfqr94riWpLqaz0YAEnMH")]
        public string __slot_AZfqr94riWpLqaz0YAEnMH;
        [n1.ElementAttribute(TracingId = 361577U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Px3Hc3gfLzePacEPmjyReE", Name = "__slot_Px3Hc3gfLzePacEPmjyReE")]
        public static bool __slot_Px3Hc3gfLzePacEPmjyReE = false;
        [n1.ElementAttribute(TracingId = 361478U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Qmo38Ro3winLNrVWUkEayi", Name = "Size")]
        public n6.Int3 Size;
        [n1.ElementAttribute(TracingId = 361484U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "OUnMOpgcmZnOFTdbHTo4vT", Name = "Recreate")]
        public bool Recreate;
        [n1.ElementAttribute(TracingId = 361377U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "PcPAbGRkQtsQO5KmfMJ9j7", Name = "TextureAdvector", IsManaged = true, IsAutoGenerated = true)]
        public n4.TextureAdvector_C __p_PcPAbGRkQtsQO5KmfMJ9j7;
        [n1.ElementAttribute(TracingId = 361363U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "JSDpS2oyJQWOal6mbACwTc", Name = "PingPongTexture3D (Fluid)", IsManaged = true, IsAutoGenerated = true)]
        public n4.PingPongTexture3D_Fluid_C __p_JSDpS2oyJQWOal6mbACwTc;
        [n1.ElementAttribute(TracingId = 361505U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "TUIjIA342iHLDesYOS3Maf", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n13.Manager<n2.ValueTuple<string, n4.PingPongTexture3D_Fluid_C>, n2.ValueTuple<n18.ImmutableDictionary<string, n4.ISimulationTexture_I>>> __cache_TUIjIA342iHLDesYOS3Maf = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n4.TextureAdvector_C> __pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE = default(n12.Spread<n4.TextureAdvector_C>);
        static AdvectedAttribute_C()
        {
        }

        public AdvectedAttribute_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AdvectedAttribute_C(AdvectedAttribute_C other): base(other)
        {
            this.__slot_AZfqr94riWpLqaz0YAEnMH = other.__slot_AZfqr94riWpLqaz0YAEnMH;
            this.Size = other.Size;
            this.Recreate = other.Recreate;
            this.__p_PcPAbGRkQtsQO5KmfMJ9j7 = other.__p_PcPAbGRkQtsQO5KmfMJ9j7;
            this.__p_JSDpS2oyJQWOal6mbACwTc = other.__p_JSDpS2oyJQWOal6mbACwTc;
            this.__cache_TUIjIA342iHLDesYOS3Maf = other.__cache_TUIjIA342iHLDesYOS3Maf;
            this.__pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE = other.__pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_AZfqr94riWpLqaz0YAEnMH", in __slot_AZfqr94riWpLqaz0YAEnMH), n1.CompilationHelper.GetValueOrExisting(values, "Size", in Size), n1.CompilationHelper.GetValueOrExisting(values, "Recreate", in Recreate), n1.CompilationHelper.GetValueOrExisting(values, "__p_PcPAbGRkQtsQO5KmfMJ9j7", in __p_PcPAbGRkQtsQO5KmfMJ9j7), n1.CompilationHelper.GetValueOrExisting(values, "__p_JSDpS2oyJQWOal6mbACwTc", in __p_JSDpS2oyJQWOal6mbACwTc), n1.CompilationHelper.GetValueOrExisting(values, "__cache_TUIjIA342iHLDesYOS3Maf", in __cache_TUIjIA342iHLDesYOS3Maf), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE", in __pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE));
        }

        internal AdvectedAttribute_C __WITH__(string __slot_AZfqr94riWpLqaz0YAEnMH, n6.Int3 Size, bool Recreate, n4.TextureAdvector_C __p_PcPAbGRkQtsQO5KmfMJ9j7, n4.PingPongTexture3D_Fluid_C __p_JSDpS2oyJQWOal6mbACwTc, n13.Manager<n2.ValueTuple<string, n4.PingPongTexture3D_Fluid_C>, n2.ValueTuple<n18.ImmutableDictionary<string, n4.ISimulationTexture_I>>> __cache_TUIjIA342iHLDesYOS3Maf, n12.Spread<n4.TextureAdvector_C> __pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE)
        {
            n11.AdvectedAttribute_C that_0 = this;
            this.__slot_AZfqr94riWpLqaz0YAEnMH = __slot_AZfqr94riWpLqaz0YAEnMH;
            this.Size = Size;
            this.Recreate = Recreate;
            this.__p_PcPAbGRkQtsQO5KmfMJ9j7 = __p_PcPAbGRkQtsQO5KmfMJ9j7;
            this.__p_JSDpS2oyJQWOal6mbACwTc = __p_JSDpS2oyJQWOal6mbACwTc;
            this.__cache_TUIjIA342iHLDesYOS3Maf = __cache_TUIjIA342iHLDesYOS3Maf;
            this.__pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE = __pin_group_Input_In_GrslUtQBCSSMIaWMrUpXAE;
            return that_0;
        }
    }
}

namespace _Fuse_Fluid3D_.Fuse.Fluid3D.Component.SphericalImpulse
{
    [n1.ElementAttribute(TracingId = 339767U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n5.CreateDefaultAttribute]
        public static n11.SphericalImpulse_C CreateDefault()
        {
            n26._Operations_.NULL<n11.SphericalImpulse_C>(Result_Out: out n11.SphericalImpulse_C Result_0);
            return Result_0;
        }
    }
}

namespace _Fuse_Fluid3D_.Fuse.Fluid3D.Component.Utils
{
    [n1.ElementAttribute(TracingId = 354382U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "EVwxc1yexSePxR5L2zHoqS", Name = "CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS")]
    [n2.SerializableAttribute]
    public class CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n58.CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS Create(n1.NodeContext Node_Context)
        {
            var instance = new CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n58.CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS CreateDefault()
        {
            var instance = new CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n58.CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS Update(n28.GpuValue<n6.Int3> Cell_Coordinate_In, n6.Int3 Fluid_Dimensions_In, out n28.GpuValue<bool> output_Out)
        {
            n6.Int3 __pad_Pka2OO0jfH2K9z4axzrqRD_0 = __slot_Pka2OO0jfH2K9z4axzrqRD;
            var State_Output_2 = this.__p_MFXVNAbn2NSMKiSxr3gADS.Update(x_In: Cell_Coordinate_In, Output_Out: out n28.GpuValue<n6.Vector3> Output_1);
            var State_Output_4 = this.__p_O5P4Mq8iFPmMDszvTKffFV.Update(Input_In: Output_1, Output_Out: out n28.GpuValue<float> Output_3);
            float Value_5 = 0F;
            var Output_7 = this.__p_LnWotypRhC7NEPPFnvGMaV.Update(Value_In: Value_5, GpuValue_Out: out n28.GpuValue<float> GpuValue_6);
            var Output_9 = this.__p_LvbZUxkHz6GNmypPFU0QRe.Update(x_In: Output_3, y_In: GpuValue_6, value_Out: out n28.GpuValue<bool> value_8);
            var State_Output_11 = this.__p_QxVX6UuV9O2MQbKKV4gQui.Update(Input_In: Output_1, Output_Out: out n28.GpuValue<float> Output_10);
            var Output_13 = this.__p_SogMCtXeYKbOOuuo5OEf5W.Update(x_In: Output_10, y_In: GpuValue_6, value_Out: out n28.GpuValue<bool> value_12);
            var State_Output_15 = this.__p_CadqLTqHj5tM14H6kzV53i.Update(Output_Out: out n28.GpuValue<n6.Vector3> Output_14);
            var State_Output_17 = this.__p_BiD3YYWWewAQKV4pd9dbwM.Update(Input_In: Output_14, Output_Out: out n28.GpuValue<float> Output_16);
            var Output_19 = this.__p_UFl9zC1yKaVPmBHRt6Q2xy.Update(x_In: Output_10, y_In: Output_16, value_Out: out n28.GpuValue<bool> value_18);
            var Output_20 = Fluid_Dimensions_In - __pad_Pka2OO0jfH2K9z4axzrqRD_0;
            var Result_21 = (n6.Vector3)Output_20;
            bool SetValue_22 = true;
            var Output_23 = State_Output_15;
            if (SetValue_22)
            {
                Output_23 = State_Output_15.SetValue(Input_In: Result_21);
            }

            var State_Output_25 = this.__p_Vl7MbJkRZraLawCydmuxkz.Update(Input_In: Output_14, Output_Out: out n28.GpuValue<float> Output_24);
            var Output_27 = this.__p_RHfHBBJ7omiM0VCtlmT9ep.Update(x_In: Output_3, y_In: Output_24, value_Out: out n28.GpuValue<bool> value_26);
            var State_Output_29 = this.__p_FVBUr6O3P7ZOjAWjgZ0nDL.Update(Input_In: Output_1, Output_Out: out n28.GpuValue<float> Output_28);
            var Output_31 = this.__p_Kk1skaYTKrULotKTVyMLcm.Update(x_In: Output_28, y_In: GpuValue_6, value_Out: out n28.GpuValue<bool> value_30);
            var State_Output_33 = this.__p_MyHrdAgoZFqPF7dVBhPDeH.Update(Input_In: Output_14, Output_Out: out n28.GpuValue<float> Output_32);
            var Output_35 = this.__p_LxiFKnGLojALIMCEilGmFU.Update(x_In: Output_28, y_In: Output_32, value_Out: out n28.GpuValue<bool> value_34);
            var builder_36 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Values_In_LntzsttXVUcOQwVGP6lN02, 6);
            builder_36.Add(value_8);
            builder_36.Add(value_26);
            builder_36.Add(value_12);
            builder_36.Add(value_18);
            builder_36.Add(value_30);
            builder_36.Add(value_34);
            var __pin_group_Values_In_LntzsttXVUcOQwVGP6lN02_37 = builder_36.Commit();
            var State_Output_39 = this.__p_LntzsttXVUcOQwVGP6lN02.Update(Values_In: __pin_group_Values_In_LntzsttXVUcOQwVGP6lN02_37, Output_Out: out n28.GpuValue<bool> Output_38);
            output_Out = Output_38;
            n58.CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS that_40 = this;
            if (this.__GetContext__().IsImmutable)
                that_40 = State_Output_2 != this.__p_MFXVNAbn2NSMKiSxr3gADS || State_Output_4 != this.__p_O5P4Mq8iFPmMDszvTKffFV || Output_7 != this.__p_LnWotypRhC7NEPPFnvGMaV || Output_9 != this.__p_LvbZUxkHz6GNmypPFU0QRe || State_Output_11 != this.__p_QxVX6UuV9O2MQbKKV4gQui || Output_13 != this.__p_SogMCtXeYKbOOuuo5OEf5W || Output_23 != this.__p_CadqLTqHj5tM14H6kzV53i || State_Output_17 != this.__p_BiD3YYWWewAQKV4pd9dbwM || Output_19 != this.__p_UFl9zC1yKaVPmBHRt6Q2xy || State_Output_25 != this.__p_Vl7MbJkRZraLawCydmuxkz || Output_27 != this.__p_RHfHBBJ7omiM0VCtlmT9ep || State_Output_29 != this.__p_FVBUr6O3P7ZOjAWjgZ0nDL || Output_31 != this.__p_Kk1skaYTKrULotKTVyMLcm || State_Output_33 != this.__p_MyHrdAgoZFqPF7dVBhPDeH || Output_35 != this.__p_LxiFKnGLojALIMCEilGmFU || __pin_group_Values_In_LntzsttXVUcOQwVGP6lN02_37 != this.__pin_group_Values_In_LntzsttXVUcOQwVGP6lN02 || State_Output_39 != this.__p_LntzsttXVUcOQwVGP6lN02 ? new CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS(this)
                {__p_MFXVNAbn2NSMKiSxr3gADS = State_Output_2, __p_O5P4Mq8iFPmMDszvTKffFV = State_Output_4, __p_LnWotypRhC7NEPPFnvGMaV = Output_7, __p_LvbZUxkHz6GNmypPFU0QRe = Output_9, __p_QxVX6UuV9O2MQbKKV4gQui = State_Output_11, __p_SogMCtXeYKbOOuuo5OEf5W = Output_13, __p_CadqLTqHj5tM14H6kzV53i = Output_23, __p_BiD3YYWWewAQKV4pd9dbwM = State_Output_17, __p_UFl9zC1yKaVPmBHRt6Q2xy = Output_19, __p_Vl7MbJkRZraLawCydmuxkz = State_Output_25, __p_RHfHBBJ7omiM0VCtlmT9ep = Output_27, __p_FVBUr6O3P7ZOjAWjgZ0nDL = State_Output_29, __p_Kk1skaYTKrULotKTVyMLcm = Output_31, __p_MyHrdAgoZFqPF7dVBhPDeH = State_Output_33, __p_LxiFKnGLojALIMCEilGmFU = Output_35, __pin_group_Values_In_LntzsttXVUcOQwVGP6lN02 = __pin_group_Values_In_LntzsttXVUcOQwVGP6lN02_37, __p_LntzsttXVUcOQwVGP6lN02 = State_Output_39} : that_40;
            else
            {
                this.__p_MFXVNAbn2NSMKiSxr3gADS = State_Output_2;
                this.__p_O5P4Mq8iFPmMDszvTKffFV = State_Output_4;
                this.__p_LnWotypRhC7NEPPFnvGMaV = Output_7;
                this.__p_LvbZUxkHz6GNmypPFU0QRe = Output_9;
                this.__p_QxVX6UuV9O2MQbKKV4gQui = State_Output_11;
                this.__p_SogMCtXeYKbOOuuo5OEf5W = Output_13;
                this.__p_CadqLTqHj5tM14H6kzV53i = Output_23;
                this.__p_BiD3YYWWewAQKV4pd9dbwM = State_Output_17;
                this.__p_UFl9zC1yKaVPmBHRt6Q2xy = Output_19;
                this.__p_Vl7MbJkRZraLawCydmuxkz = State_Output_25;
                this.__p_RHfHBBJ7omiM0VCtlmT9ep = Output_27;
                this.__p_FVBUr6O3P7ZOjAWjgZ0nDL = State_Output_29;
                this.__p_Kk1skaYTKrULotKTVyMLcm = Output_31;
                this.__p_MyHrdAgoZFqPF7dVBhPDeH = State_Output_33;
                this.__p_LxiFKnGLojALIMCEilGmFU = Output_35;
                this.__pin_group_Values_In_LntzsttXVUcOQwVGP6lN02 = __pin_group_Values_In_LntzsttXVUcOQwVGP6lN02_37;
                this.__p_LntzsttXVUcOQwVGP6lN02 = State_Output_39;
            }

            return that_40;
        }

        public n58.CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "O5P4Mq8iFPmMDszvTKffFV", 354385U);
            var Output_1 = n76.x_CThKQPdF8roMfrpnCR01ll<n6.Vector3>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "LvbZUxkHz6GNmypPFU0QRe", 354397U);
            var Output_3 = n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float>.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "LnWotypRhC7NEPPFnvGMaV", 354410U);
            var Output_5 = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "LntzsttXVUcOQwVGP6lN02", 354422U);
            var Output_7 = n59.AND_TkWZzQWwZ0tLZt6ooZGazh.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "RHfHBBJ7omiM0VCtlmT9ep", 354473U);
            var Output_9 = n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float>.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Vl7MbJkRZraLawCydmuxkz", 354491U);
            var Output_11 = n76.x_CThKQPdF8roMfrpnCR01ll<n6.Vector3>.Create(Node_Context: Node_Context_10);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "QxVX6UuV9O2MQbKKV4gQui", 354511U);
            var Output_13 = n76.y_EqOmImsLEfKMwPNqId2m1L<n6.Vector3>.Create(Node_Context: Node_Context_12);
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "SogMCtXeYKbOOuuo5OEf5W", 354535U);
            var Output_15 = n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float>.Create(Node_Context: Node_Context_14);
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "UFl9zC1yKaVPmBHRt6Q2xy", 354560U);
            var Output_17 = n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float>.Create(Node_Context: Node_Context_16);
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "BiD3YYWWewAQKV4pd9dbwM", 354576U);
            var Output_19 = n76.y_EqOmImsLEfKMwPNqId2m1L<n6.Vector3>.Create(Node_Context: Node_Context_18);
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "FVBUr6O3P7ZOjAWjgZ0nDL", 354593U);
            var Output_21 = n76.z_EOvTnjQku9NNwhiVmmQpmT<n6.Vector3>.Create(Node_Context: Node_Context_20);
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "Kk1skaYTKrULotKTVyMLcm", 354607U);
            var Output_23 = n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float>.Create(Node_Context: Node_Context_22);
            n1.NodeContext Node_Context_24 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "LxiFKnGLojALIMCEilGmFU", 354618U);
            var Output_25 = n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float>.Create(Node_Context: Node_Context_24);
            n1.NodeContext Node_Context_26 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "MyHrdAgoZFqPF7dVBhPDeH", 354644U);
            var Output_27 = n76.z_EOvTnjQku9NNwhiVmmQpmT<n6.Vector3>.Create(Node_Context: Node_Context_26);
            n1.NodeContext Node_Context_28 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "MFXVNAbn2NSMKiSxr3gADS", 354688U);
            var Output_29 = n82.ToVector3_BiGMZixIzsHMmgVTnvnygH<n6.Int3>.Create(Node_Context: Node_Context_28);
            n1.NodeContext Node_Context_30 = Node_Context.CreateSubContext("KeWf79wIWCVN4a6TzD33r2", "CadqLTqHj5tM14H6kzV53i", 354704U);
            var Output_31 = n57.GPUIn_C<n6.Vector3>.Create(Node_Context: Node_Context_30);
            n58.CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS that_32 = this;
            this.__pin_group_Values_In_LntzsttXVUcOQwVGP6lN02 = n14._Operations_.CreateDefault<n28.GpuValue<bool>>();
            this.__p_O5P4Mq8iFPmMDszvTKffFV = Output_1;
            this.__p_LvbZUxkHz6GNmypPFU0QRe = Output_3;
            this.__p_LnWotypRhC7NEPPFnvGMaV = Output_5;
            this.__p_LntzsttXVUcOQwVGP6lN02 = Output_7;
            this.__p_RHfHBBJ7omiM0VCtlmT9ep = Output_9;
            this.__p_Vl7MbJkRZraLawCydmuxkz = Output_11;
            this.__p_QxVX6UuV9O2MQbKKV4gQui = Output_13;
            this.__p_SogMCtXeYKbOOuuo5OEf5W = Output_15;
            this.__p_UFl9zC1yKaVPmBHRt6Q2xy = Output_17;
            this.__p_BiD3YYWWewAQKV4pd9dbwM = Output_19;
            this.__p_FVBUr6O3P7ZOjAWjgZ0nDL = Output_21;
            this.__p_Kk1skaYTKrULotKTVyMLcm = Output_23;
            this.__p_LxiFKnGLojALIMCEilGmFU = Output_25;
            this.__p_MyHrdAgoZFqPF7dVBhPDeH = Output_27;
            this.__p_MFXVNAbn2NSMKiSxr3gADS = Output_29;
            this.__p_CadqLTqHj5tM14H6kzV53i = Output_31;
            return that_32;
        }

        public n58.CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS __CreateDefault__()
        {
            n58.CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS that_0 = this;
            this.__pin_group_Values_In_LntzsttXVUcOQwVGP6lN02 = n14._Operations_.CreateDefault<n28.GpuValue<bool>>();
            this.__p_MFXVNAbn2NSMKiSxr3gADS = n82.ToVector3_BiGMZixIzsHMmgVTnvnygH<n6.Int3>.CreateDefault();
            this.__p_O5P4Mq8iFPmMDszvTKffFV = n76.x_CThKQPdF8roMfrpnCR01ll<n6.Vector3>.CreateDefault();
            this.__p_LnWotypRhC7NEPPFnvGMaV = n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.CreateDefault();
            this.__p_LvbZUxkHz6GNmypPFU0QRe = n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float>.CreateDefault();
            this.__p_QxVX6UuV9O2MQbKKV4gQui = n76.y_EqOmImsLEfKMwPNqId2m1L<n6.Vector3>.CreateDefault();
            this.__p_SogMCtXeYKbOOuuo5OEf5W = n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float>.CreateDefault();
            this.__p_CadqLTqHj5tM14H6kzV53i = n57.GPUIn_C<n6.Vector3>.CreateDefault();
            this.__p_BiD3YYWWewAQKV4pd9dbwM = n76.y_EqOmImsLEfKMwPNqId2m1L<n6.Vector3>.CreateDefault();
            this.__p_UFl9zC1yKaVPmBHRt6Q2xy = n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float>.CreateDefault();
            this.__p_Vl7MbJkRZraLawCydmuxkz = n76.x_CThKQPdF8roMfrpnCR01ll<n6.Vector3>.CreateDefault();
            this.__p_RHfHBBJ7omiM0VCtlmT9ep = n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float>.CreateDefault();
            this.__p_FVBUr6O3P7ZOjAWjgZ0nDL = n76.z_EOvTnjQku9NNwhiVmmQpmT<n6.Vector3>.CreateDefault();
            this.__p_Kk1skaYTKrULotKTVyMLcm = n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float>.CreateDefault();
            this.__p_MyHrdAgoZFqPF7dVBhPDeH = n76.z_EOvTnjQku9NNwhiVmmQpmT<n6.Vector3>.CreateDefault();
            this.__p_LxiFKnGLojALIMCEilGmFU = n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float>.CreateDefault();
            this.__p_LntzsttXVUcOQwVGP6lN02 = n59.AND_TkWZzQWwZ0tLZt6ooZGazh.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_MFXVNAbn2NSMKiSxr3gADS);
            n1.CompilationHelper.SafeDispose(this.__p_O5P4Mq8iFPmMDszvTKffFV);
            n1.CompilationHelper.SafeDispose(this.__p_LnWotypRhC7NEPPFnvGMaV);
            n1.CompilationHelper.SafeDispose(this.__p_LvbZUxkHz6GNmypPFU0QRe);
            n1.CompilationHelper.SafeDispose(this.__p_QxVX6UuV9O2MQbKKV4gQui);
            n1.CompilationHelper.SafeDispose(this.__p_SogMCtXeYKbOOuuo5OEf5W);
            n1.CompilationHelper.SafeDispose(this.__p_CadqLTqHj5tM14H6kzV53i);
            n1.CompilationHelper.SafeDispose(this.__p_BiD3YYWWewAQKV4pd9dbwM);
            n1.CompilationHelper.SafeDispose(this.__p_UFl9zC1yKaVPmBHRt6Q2xy);
            n1.CompilationHelper.SafeDispose(this.__p_Vl7MbJkRZraLawCydmuxkz);
            n1.CompilationHelper.SafeDispose(this.__p_RHfHBBJ7omiM0VCtlmT9ep);
            n1.CompilationHelper.SafeDispose(this.__p_FVBUr6O3P7ZOjAWjgZ0nDL);
            n1.CompilationHelper.SafeDispose(this.__p_Kk1skaYTKrULotKTVyMLcm);
            n1.CompilationHelper.SafeDispose(this.__p_MyHrdAgoZFqPF7dVBhPDeH);
            n1.CompilationHelper.SafeDispose(this.__p_LxiFKnGLojALIMCEilGmFU);
            n1.CompilationHelper.SafeDispose(this.__p_LntzsttXVUcOQwVGP6lN02);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 354740U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Pka2OO0jfH2K9z4axzrqRD", Name = "__slot_Pka2OO0jfH2K9z4axzrqRD")]
        public static n6.Int3 __slot_Pka2OO0jfH2K9z4axzrqRD = n1.CompilationHelper.Deserialize<n6.Int3>("1, 1, 1", false, "KeWf79wIWCVN4a6TzD33r2", "Pka2OO0jfH2K9z4axzrqRD");
        [n1.ElementAttribute(TracingId = 354688U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MFXVNAbn2NSMKiSxr3gADS", Name = "ToVector3", IsManaged = true, IsAutoGenerated = true)]
        public n82.ToVector3_BiGMZixIzsHMmgVTnvnygH<n6.Int3> __p_MFXVNAbn2NSMKiSxr3gADS;
        [n1.ElementAttribute(TracingId = 354385U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "O5P4Mq8iFPmMDszvTKffFV", Name = "x", IsManaged = true, IsAutoGenerated = true)]
        public n76.x_CThKQPdF8roMfrpnCR01ll<n6.Vector3> __p_O5P4Mq8iFPmMDszvTKffFV;
        [n1.ElementAttribute(TracingId = 354410U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LnWotypRhC7NEPPFnvGMaV", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
        public n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_LnWotypRhC7NEPPFnvGMaV;
        [n1.ElementAttribute(TracingId = 354397U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LvbZUxkHz6GNmypPFU0QRe", Name = ">", IsManaged = true, IsAutoGenerated = true)]
        public n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_LvbZUxkHz6GNmypPFU0QRe;
        [n1.ElementAttribute(TracingId = 354511U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "QxVX6UuV9O2MQbKKV4gQui", Name = "y", IsManaged = true, IsAutoGenerated = true)]
        public n76.y_EqOmImsLEfKMwPNqId2m1L<n6.Vector3> __p_QxVX6UuV9O2MQbKKV4gQui;
        [n1.ElementAttribute(TracingId = 354535U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "SogMCtXeYKbOOuuo5OEf5W", Name = ">", IsManaged = true, IsAutoGenerated = true)]
        public n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_SogMCtXeYKbOOuuo5OEf5W;
        [n1.ElementAttribute(TracingId = 354704U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "CadqLTqHj5tM14H6kzV53i", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
        public n57.GPUIn_C<n6.Vector3> __p_CadqLTqHj5tM14H6kzV53i;
        [n1.ElementAttribute(TracingId = 354576U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "BiD3YYWWewAQKV4pd9dbwM", Name = "y", IsManaged = true, IsAutoGenerated = true)]
        public n76.y_EqOmImsLEfKMwPNqId2m1L<n6.Vector3> __p_BiD3YYWWewAQKV4pd9dbwM;
        [n1.ElementAttribute(TracingId = 354560U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "UFl9zC1yKaVPmBHRt6Q2xy", Name = "<", IsManaged = true, IsAutoGenerated = true)]
        public n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_UFl9zC1yKaVPmBHRt6Q2xy;
        [n1.ElementAttribute(TracingId = 354491U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Vl7MbJkRZraLawCydmuxkz", Name = "x", IsManaged = true, IsAutoGenerated = true)]
        public n76.x_CThKQPdF8roMfrpnCR01ll<n6.Vector3> __p_Vl7MbJkRZraLawCydmuxkz;
        [n1.ElementAttribute(TracingId = 354473U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "RHfHBBJ7omiM0VCtlmT9ep", Name = "<", IsManaged = true, IsAutoGenerated = true)]
        public n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_RHfHBBJ7omiM0VCtlmT9ep;
        [n1.ElementAttribute(TracingId = 354593U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "FVBUr6O3P7ZOjAWjgZ0nDL", Name = "z", IsManaged = true, IsAutoGenerated = true)]
        public n76.z_EOvTnjQku9NNwhiVmmQpmT<n6.Vector3> __p_FVBUr6O3P7ZOjAWjgZ0nDL;
        [n1.ElementAttribute(TracingId = 354607U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "Kk1skaYTKrULotKTVyMLcm", Name = ">", IsManaged = true, IsAutoGenerated = true)]
        public n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_Kk1skaYTKrULotKTVyMLcm;
        [n1.ElementAttribute(TracingId = 354644U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "MyHrdAgoZFqPF7dVBhPDeH", Name = "z", IsManaged = true, IsAutoGenerated = true)]
        public n76.z_EOvTnjQku9NNwhiVmmQpmT<n6.Vector3> __p_MyHrdAgoZFqPF7dVBhPDeH;
        [n1.ElementAttribute(TracingId = 354618U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LxiFKnGLojALIMCEilGmFU", Name = "<", IsManaged = true, IsAutoGenerated = true)]
        public n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_LxiFKnGLojALIMCEilGmFU;
        [n1.ElementAttribute(TracingId = 354422U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", PersistentId = "LntzsttXVUcOQwVGP6lN02", Name = "AND", IsManaged = true, IsAutoGenerated = true)]
        public n59.AND_TkWZzQWwZ0tLZt6ooZGazh __p_LntzsttXVUcOQwVGP6lN02;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n12.Spread<n28.GpuValue<bool>> __pin_group_Values_In_LntzsttXVUcOQwVGP6lN02 = default(n12.Spread<n28.GpuValue<bool>>);
        static CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS()
        {
        }

        public CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS(CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS other): base(other)
        {
            this.__p_MFXVNAbn2NSMKiSxr3gADS = other.__p_MFXVNAbn2NSMKiSxr3gADS;
            this.__p_O5P4Mq8iFPmMDszvTKffFV = other.__p_O5P4Mq8iFPmMDszvTKffFV;
            this.__p_LnWotypRhC7NEPPFnvGMaV = other.__p_LnWotypRhC7NEPPFnvGMaV;
            this.__p_LvbZUxkHz6GNmypPFU0QRe = other.__p_LvbZUxkHz6GNmypPFU0QRe;
            this.__p_QxVX6UuV9O2MQbKKV4gQui = other.__p_QxVX6UuV9O2MQbKKV4gQui;
            this.__p_SogMCtXeYKbOOuuo5OEf5W = other.__p_SogMCtXeYKbOOuuo5OEf5W;
            this.__p_CadqLTqHj5tM14H6kzV53i = other.__p_CadqLTqHj5tM14H6kzV53i;
            this.__p_BiD3YYWWewAQKV4pd9dbwM = other.__p_BiD3YYWWewAQKV4pd9dbwM;
            this.__p_UFl9zC1yKaVPmBHRt6Q2xy = other.__p_UFl9zC1yKaVPmBHRt6Q2xy;
            this.__p_Vl7MbJkRZraLawCydmuxkz = other.__p_Vl7MbJkRZraLawCydmuxkz;
            this.__p_RHfHBBJ7omiM0VCtlmT9ep = other.__p_RHfHBBJ7omiM0VCtlmT9ep;
            this.__p_FVBUr6O3P7ZOjAWjgZ0nDL = other.__p_FVBUr6O3P7ZOjAWjgZ0nDL;
            this.__p_Kk1skaYTKrULotKTVyMLcm = other.__p_Kk1skaYTKrULotKTVyMLcm;
            this.__p_MyHrdAgoZFqPF7dVBhPDeH = other.__p_MyHrdAgoZFqPF7dVBhPDeH;
            this.__p_LxiFKnGLojALIMCEilGmFU = other.__p_LxiFKnGLojALIMCEilGmFU;
            this.__p_LntzsttXVUcOQwVGP6lN02 = other.__p_LntzsttXVUcOQwVGP6lN02;
            this.__pin_group_Values_In_LntzsttXVUcOQwVGP6lN02 = other.__pin_group_Values_In_LntzsttXVUcOQwVGP6lN02;
        }

        protected override n1.IVLObject __With__(n22.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MFXVNAbn2NSMKiSxr3gADS", in __p_MFXVNAbn2NSMKiSxr3gADS), n1.CompilationHelper.GetValueOrExisting(values, "__p_O5P4Mq8iFPmMDszvTKffFV", in __p_O5P4Mq8iFPmMDszvTKffFV), n1.CompilationHelper.GetValueOrExisting(values, "__p_LnWotypRhC7NEPPFnvGMaV", in __p_LnWotypRhC7NEPPFnvGMaV), n1.CompilationHelper.GetValueOrExisting(values, "__p_LvbZUxkHz6GNmypPFU0QRe", in __p_LvbZUxkHz6GNmypPFU0QRe), n1.CompilationHelper.GetValueOrExisting(values, "__p_QxVX6UuV9O2MQbKKV4gQui", in __p_QxVX6UuV9O2MQbKKV4gQui), n1.CompilationHelper.GetValueOrExisting(values, "__p_SogMCtXeYKbOOuuo5OEf5W", in __p_SogMCtXeYKbOOuuo5OEf5W), n1.CompilationHelper.GetValueOrExisting(values, "__p_CadqLTqHj5tM14H6kzV53i", in __p_CadqLTqHj5tM14H6kzV53i), n1.CompilationHelper.GetValueOrExisting(values, "__p_BiD3YYWWewAQKV4pd9dbwM", in __p_BiD3YYWWewAQKV4pd9dbwM), n1.CompilationHelper.GetValueOrExisting(values, "__p_UFl9zC1yKaVPmBHRt6Q2xy", in __p_UFl9zC1yKaVPmBHRt6Q2xy), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vl7MbJkRZraLawCydmuxkz", in __p_Vl7MbJkRZraLawCydmuxkz), n1.CompilationHelper.GetValueOrExisting(values, "__p_RHfHBBJ7omiM0VCtlmT9ep", in __p_RHfHBBJ7omiM0VCtlmT9ep), n1.CompilationHelper.GetValueOrExisting(values, "__p_FVBUr6O3P7ZOjAWjgZ0nDL", in __p_FVBUr6O3P7ZOjAWjgZ0nDL), n1.CompilationHelper.GetValueOrExisting(values, "__p_Kk1skaYTKrULotKTVyMLcm", in __p_Kk1skaYTKrULotKTVyMLcm), n1.CompilationHelper.GetValueOrExisting(values, "__p_MyHrdAgoZFqPF7dVBhPDeH", in __p_MyHrdAgoZFqPF7dVBhPDeH), n1.CompilationHelper.GetValueOrExisting(values, "__p_LxiFKnGLojALIMCEilGmFU", in __p_LxiFKnGLojALIMCEilGmFU), n1.CompilationHelper.GetValueOrExisting(values, "__p_LntzsttXVUcOQwVGP6lN02", in __p_LntzsttXVUcOQwVGP6lN02), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Values_In_LntzsttXVUcOQwVGP6lN02", in __pin_group_Values_In_LntzsttXVUcOQwVGP6lN02));
        }

        internal CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS __WITH__(n82.ToVector3_BiGMZixIzsHMmgVTnvnygH<n6.Int3> __p_MFXVNAbn2NSMKiSxr3gADS, n76.x_CThKQPdF8roMfrpnCR01ll<n6.Vector3> __p_O5P4Mq8iFPmMDszvTKffFV, n57.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_LnWotypRhC7NEPPFnvGMaV, n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_LvbZUxkHz6GNmypPFU0QRe, n76.y_EqOmImsLEfKMwPNqId2m1L<n6.Vector3> __p_QxVX6UuV9O2MQbKKV4gQui, n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_SogMCtXeYKbOOuuo5OEf5W, n57.GPUIn_C<n6.Vector3> __p_CadqLTqHj5tM14H6kzV53i, n76.y_EqOmImsLEfKMwPNqId2m1L<n6.Vector3> __p_BiD3YYWWewAQKV4pd9dbwM, n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_UFl9zC1yKaVPmBHRt6Q2xy, n76.x_CThKQPdF8roMfrpnCR01ll<n6.Vector3> __p_Vl7MbJkRZraLawCydmuxkz, n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_RHfHBBJ7omiM0VCtlmT9ep, n76.z_EOvTnjQku9NNwhiVmmQpmT<n6.Vector3> __p_FVBUr6O3P7ZOjAWjgZ0nDL, n59.OperatorGreater_JbYVzVatqDOP3DdvvBw1XF<float> __p_Kk1skaYTKrULotKTVyMLcm, n76.z_EOvTnjQku9NNwhiVmmQpmT<n6.Vector3> __p_MyHrdAgoZFqPF7dVBhPDeH, n59.OperatorLess_HBD89IfXGDAMdK34KcZAoh<float> __p_LxiFKnGLojALIMCEilGmFU, n59.AND_TkWZzQWwZ0tLZt6ooZGazh __p_LntzsttXVUcOQwVGP6lN02, n12.Spread<n28.GpuValue<bool>> __pin_group_Values_In_LntzsttXVUcOQwVGP6lN02)
        {
            n58.CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_MFXVNAbn2NSMKiSxr3gADS != this.__p_MFXVNAbn2NSMKiSxr3gADS || __p_O5P4Mq8iFPmMDszvTKffFV != this.__p_O5P4Mq8iFPmMDszvTKffFV || __p_LnWotypRhC7NEPPFnvGMaV != this.__p_LnWotypRhC7NEPPFnvGMaV || __p_LvbZUxkHz6GNmypPFU0QRe != this.__p_LvbZUxkHz6GNmypPFU0QRe || __p_QxVX6UuV9O2MQbKKV4gQui != this.__p_QxVX6UuV9O2MQbKKV4gQui || __p_SogMCtXeYKbOOuuo5OEf5W != this.__p_SogMCtXeYKbOOuuo5OEf5W || __p_CadqLTqHj5tM14H6kzV53i != this.__p_CadqLTqHj5tM14H6kzV53i || __p_BiD3YYWWewAQKV4pd9dbwM != this.__p_BiD3YYWWewAQKV4pd9dbwM || __p_UFl9zC1yKaVPmBHRt6Q2xy != this.__p_UFl9zC1yKaVPmBHRt6Q2xy || __p_Vl7MbJkRZraLawCydmuxkz != this.__p_Vl7MbJkRZraLawCydmuxkz || __p_RHfHBBJ7omiM0VCtlmT9ep != this.__p_RHfHBBJ7omiM0VCtlmT9ep || __p_FVBUr6O3P7ZOjAWjgZ0nDL != this.__p_FVBUr6O3P7ZOjAWjgZ0nDL || __p_Kk1skaYTKrULotKTVyMLcm != this.__p_Kk1skaYTKrULotKTVyMLcm || __p_MyHrdAgoZFqPF7dVBhPDeH != this.__p_MyHrdAgoZFqPF7dVBhPDeH || __p_LxiFKnGLojALIMCEilGmFU != this.__p_LxiFKnGLojALIMCEilGmFU || __p_LntzsttXVUcOQwVGP6lN02 != this.__p_LntzsttXVUcOQwVGP6lN02 || __pin_group_Values_In_LntzsttXVUcOQwVGP6lN02 != this.__pin_group_Values_In_LntzsttXVUcOQwVGP6lN02 ? new CellIsNodBoxBorder_EVwxc1yexSePxR5L2zHoqS(this)
                {__p_MFXVNAbn2NSMKiSxr3gADS = __p_MFXVNAbn2NSMKiSxr3gADS, __p_O5P4Mq8iFPmMDszvTKffFV = __p_O5P4Mq8iFPmMDszvTKffFV, __p_LnWotypRhC7NEPPFnvGMaV = __p_LnWotypRhC7NEPPFnvGMaV, __p_LvbZUxkHz6GNmypPFU0QRe = __p_LvbZUxkHz6GNmypPFU0QRe, __p_QxVX6UuV9O2MQbKKV4gQui = __p_QxVX6UuV9O2MQbKKV4gQui, __p_SogMCtXeYKbOOuuo5OEf5W = __p_SogMCtXeYKbOOuuo5OEf5W, __p_CadqLTqHj5tM14H6kzV53i = __p_CadqLTqHj5tM14H6kzV53i, __p_BiD3YYWWewAQKV4pd9dbwM = __p_BiD3YYWWewAQKV4pd9dbwM, __p_UFl9zC1yKaVPmBHRt6Q2xy = __p_UFl9zC1yKaVPmBHRt6Q2xy, __p_Vl7MbJkRZraLawCydmuxkz = __p_Vl7MbJkRZraLawCydmuxkz, __p_RHfHBBJ7omiM0VCtlmT9ep = __p_RHfHBBJ7omiM0VCtlmT9ep, __p_FVBUr6O3P7ZOjAWjgZ0nDL = __p_FVBUr6O3P7ZOjAWjgZ0nDL, __p_Kk1skaYTKrULotKTVyMLcm = __p_Kk1skaYTKrULotKTVyMLcm, __p_MyHrdAgoZFqPF7dVBhPDeH = __p_MyHrdAgoZFqPF7dVBhPDeH, __p_LxiFKnGLojALIMCEilGmFU = __p_LxiFKnGLojALIMCEilGmFU, __p_LntzsttXVUcOQwVGP6lN02 = __p_LntzsttXVUcOQwVGP6lN02, __pin_group_Values_In_LntzsttXVUcOQwVGP6lN02 = __pin_group_Values_In_LntzsttXVUcOQwVGP6lN02} : that_0;
            else
            {
                this.__p_MFXVNAbn2NSMKiSxr3gADS = __p_MFXVNAbn2NSMKiSxr3gADS;
                this.__p_O5P4Mq8iFPmMDszvTKffFV = __p_O5P4Mq8iFPmMDszvTKffFV;
                this.__p_LnWotypRhC7NEPPFnvGMaV = __p_LnWotypRhC7NEPPFnvGMaV;
                this.__p_LvbZUxkHz6GNmypPFU0QRe = __p_LvbZUxkHz6GNmypPFU0QRe;
                this.__p_QxVX6UuV9O2MQbKKV4gQui = __p_QxVX6UuV9O2MQbKKV4gQui;
                this.__p_SogMCtXeYKbOOuuo5OEf5W = __p_SogMCtXeYKbOOuuo5OEf5W;
                this.__p_CadqLTqHj5tM14H6kzV53i = __p_CadqLTqHj5tM14H6kzV53i;
                this.__p_BiD3YYWWewAQKV4pd9dbwM = __p_BiD3YYWWewAQKV4pd9dbwM;
                this.__p_UFl9zC1yKaVPmBHRt6Q2xy = __p_UFl9zC1yKaVPmBHRt6Q2xy;
                this.__p_Vl7MbJkRZraLawCydmuxkz = __p_Vl7MbJkRZraLawCydmuxkz;
                this.__p_RHfHBBJ7omiM0VCtlmT9ep = __p_RHfHBBJ7omiM0VCtlmT9ep;
                this.__p_FVBUr6O3P7ZOjAWjgZ0nDL = __p_FVBUr6O3P7ZOjAWjgZ0nDL;
                this.__p_Kk1skaYTKrULotKTVyMLcm = __p_Kk1skaYTKrULotKTVyMLcm;
                this.__p_MyHrdAgoZFqPF7dVBhPDeH = __p_MyHrdAgoZFqPF7dVBhPDeH;
                this.__p_LxiFKnGLojALIMCEilGmFU = __p_LxiFKnGLojALIMCEilGmFU;
                this.__p_LntzsttXVUcOQwVGP6lN02 = __p_LntzsttXVUcOQwVGP6lN02;
                this.__pin_group_Values_In_LntzsttXVUcOQwVGP6lN02 = __pin_group_Values_In_LntzsttXVUcOQwVGP6lN02;
            }

            return that_0;
        }
    }
}

namespace _Fuse_Fluid3D_.Fuse.Fluid3D.Component.AugmentedTexture2DVectorField_Fluid3D.Internal
{
    [n1.ElementAttribute(TracingId = 339767U, DocumentId = "KeWf79wIWCVN4a6TzD33r2", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void DIVCeilValue(int Input_In, int Div_In, out int Output_Out)
        {
            var Result_0 = n92.IntegerConversions.ToFloat32(input: Input_In);
            var Result_1 = n92.IntegerConversions.ToFloat32(input: Div_In);
            var Output_2 = (float)Result_0 / Result_1;
            n92.Float32Extensions.Frac(input: Output_2, wholePart: out int Whole_Part_3, fractionalPart: out float Fractional_Part_4);
            float Input_2_5 = 0F;
            var Result_6 = Fractional_Part_4 > Input_2_5;
            var Output_7 = Whole_Part_3;
            if (Result_6)
            {
                var Output_8 = n92.Integer32Extensions.Inc(input: Whole_Part_3);
                Output_7 = Output_8;
            }

            Output_Out = Output_7;
            return;
        }
    }
}

namespace _Fuse_Fluid3D_
{
    public struct __AdaptiveImplementations__KeWf79wIWCVN4a6TzD33r2 : n97.IAdaptiveCreateDefault<n6.Vector3>, n98.IAdaptiveOperatorMinus<n6.Vector3>, n97.IAdaptiveCreateDefault<n6.Vector2>, n98.IAdaptiveOperatorMinus<n6.Vector2>, n98.IAdaptiveOperatorMulitply_Scale<n6.Vector2>, n98.IAdaptiveOperatorPlus<n6.Vector2>, n97.IAdaptiveCreateDefault<n27.Texture>, n98.IAdaptiveOperatorDivide<n6.Vector3>, n98.IAdaptiveOperatorMulitply<n6.Vector3>, n98.IAdaptiveOperatorPlus<n6.Vector3>, n95.IAdaptiveSetGraphicsData<n12.Spread<n6.Vector4>>, n99.IAdaptiveAsReadOnlyMemory<n12.Spread<n6.Vector4>, n6.Vector4>
    {
        public void CreateDefault(out n6.Vector3 Output_Out)
        {
            var Zero_0 = n7._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }

        public void OperatorMinus(n6.Vector3 Input_In, n6.Vector3 Input_2_In, out n6.Vector3 Output_Out)
        {
            n6.Vector3.Subtract(left: ref Input_In, right: ref Input_2_In, result: out n6.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n6.Vector2 Output_Out)
        {
            var Zero_0 = n40._Operations_.CreateDefault();
            Output_Out = Zero_0;
            return;
        }

        public void OperatorMinus(n6.Vector2 Input_In, n6.Vector2 Input_2_In, out n6.Vector2 Output_Out)
        {
            n6.Vector2.Subtract(left: ref Input_In, right: ref Input_2_In, result: out n6.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply_Scale(n6.Vector2 Input_In, float Scalar_In, out n6.Vector2 Output_Out)
        {
            n8.Vector2Nodes.Scale(input: ref Input_In, scalar: Scalar_In, output: out n6.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(n6.Vector2 Input_In, n6.Vector2 Input_2_In, out n6.Vector2 Output_Out)
        {
            n6.Vector2.Add(left: ref Input_In, right: ref Input_2_In, result: out n6.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n27.Texture Output_Out)
        {
            n94._Operations_.CreateDefault_Generic<n27.Texture>(Output_Out: out n27.Texture Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide(n6.Vector3 Input_In, n6.Vector3 Input_2_In, out n6.Vector3 Output_Out)
        {
            var Output_0 = (n6.Vector3)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply(n6.Vector3 Input_In, n6.Vector3 Input_2_In, out n6.Vector3 Output_Out)
        {
            n8.Vector3Nodes.Multiply(left: ref Input_In, right: ref Input_2_In, result: out n6.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(n6.Vector3 Input_In, n6.Vector3 Input_2_In, out n6.Vector3 Output_Out)
        {
            n6.Vector3.Add(left: ref Input_In, right: ref Input_2_In, result: out n6.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void SetGraphicsData(n42.MemoryDataProvider Input_In, n12.Spread<n6.Vector4> Data_In, int Offset_In_Bytes_In, int Size_In_Bytes_In, int Element_Size_In_Bytes_In, int Row_Size_In_Bytes_In, int Slice_Size_In_Bytes_In, out n42.MemoryDataProvider Output_Out)
        {
            n95._Operations_.SetGraphicsData<n12.Spread<n6.Vector4>, n6.Vector4, n31.__AdaptiveImplementations__KeWf79wIWCVN4a6TzD33r2>(Input_In: Input_In, Data_In: Data_In, Offset_In_Bytes_In: Offset_In_Bytes_In, Size_In_Bytes_In: Size_In_Bytes_In, Element_Size_In_Bytes_In: Element_Size_In_Bytes_In, Row_Size_In_Bytes_In: Row_Size_In_Bytes_In, Slice_Size_In_Bytes_In: Slice_Size_In_Bytes_In, Output_Out: out n42.MemoryDataProvider Output_0);
            Output_Out = Output_0;
            return;
        }

        public void AsReadOnlyMemory(n12.Spread<n6.Vector4> Input_In, out n2.ReadOnlyMemory<n6.Vector4> Result_Out)
        {
            n22.IReadOnlyList<n6.Vector4> Input_0 = (n22.IReadOnlyList<n6.Vector4>)Input_In;
            var Result_1 = n96.MemoryUtils.AsReadOnlyMemory<n6.Vector4>(input: Input_0);
            Result_Out = Result_1;
            return;
        }
    }
}