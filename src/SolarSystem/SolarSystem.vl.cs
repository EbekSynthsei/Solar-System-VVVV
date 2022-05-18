extern alias e22;
extern alias e24;
extern alias e31;
extern alias e26;
extern alias e3;
extern alias e25;
extern alias e2;
extern alias e48;
extern alias e71;
extern alias e29;
extern alias e4;

using n45 = _Fuse_Fluid3D_.Fuse.Fluid3D;
using n36 = e26::Stride.Graphics;
using n7 = _CoreLibBasics_._3D.Matrix;
using n19 = e2::VL.Lib.Collections;
using n21 = _Fuse_Fluid3D_.Fuse.Fluid3D.Component.SphericalImpulse;
using n38 = _VL_Stride_Rendering_ShaderFX_.Stride.Materials.Inputs;
using n16 = e71::Fuse;
using n8 = _CoreLibBasics_._3D.Transform;
using n30 = e29::Stride.Rendering.Images;
using n12 = e31::VL.Stride.Shaders.ShaderFX;
using n4 = _SolarSystem_.Main;
using n39 = _VL_Stride_Rendering_ShaderFX_.Stride.Materials;
using n22 = _Fuse_Fluid3D_.Fuse.Fluid3D.Component;
using n49 = _Fuse_Common_Compute_.Fuse.Common.Compute.Random;
using n42 = _CoreLibBasics_.Animation.IFrameClock.Advanced;
using n25 = global::System.Collections.Generic;
using n29 = e31::VL.Stride.Rendering.Lights;
using n59 = _CoreLibBasics_.Math.Adaptive;
using n33 = _VL_Stride_Engine_.Stride.Rendering;
using n18 = e71::Fuse.compute;
using n41 = _VL_Stride_Assets_Windows_.Stride.Assets;
using n55 = _Fuse_Core_Math_.Fuse.Core.Math;
using n44 = _CoreLibBasics_.Animation;
using n53 = _Fuse_Core_.Fuse.Core.Join;
using n32 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n58 = _VL_Stride_Engine_.Stride.Lights;
using n50 = _Fuse_Particles_.Fuse.Particles.Force;
using n28 = e24::Stride.Engine;
using n20 = e3::VL.Lib.Mathematics;
using n34 = e25::Stride.Games;
using n31 = _SolarSystem_;
using n40 = _VL_Stride_Engine_.Stride.Models;
using n1 = e2::VL.Core;
using n24 = e31::VL.Stride.Rendering;
using n11 = e22::Stride.Graphics;
using n56 = _Fuse_Core_.Fuse.Core.Value;
using n2 = global::System;
using n3 = e4::Stride.Core.Mathematics;
using n52 = _Fuse_Particles_.Fuse.Particles.Attribute;
using n17 = _CoreLibBasics_.Color.RGBA;
using n9 = e2::VL.Lib.IO;
using n57 = _Fuse_Core_.Fuse.Core.Swizzle;
using n51 = _Fuse_Particles_.Fuse.Particles.Drawer;
using n5 = e2::VL.Core.CompilerServices;
using n47 = _Fuse_Particles_.Fuse.Particles.Emitter;
using n46 = _Fuse_Particles_.Fuse.Particles.Integration;
using n27 = _Fuse_Common_Compute_.Fuse.Common.Compute.Draw.Internal;
using n26 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.DepthStencilStateDescription.Advanced;
using n37 = _VL_Stride_Engine_.Stride;
using n43 = e2::VL.Lib.Animation;
using n14 = e29::Stride.Rendering;
using n35 = global::System.Runtime.CompilerServices;
using n6 = _CoreLibBasics_.Math;
using n15 = _Fuse_Common_Compute_.Fuse.Common.Compute;
using n10 = e48::Stride.Assets.Textures;
using n54 = _Fuse_Particles_.Fuse.Particles.Operation;
using n23 = _VL_Collections_.Collections.Spread;
using n48 = _Fuse_Core_.Fuse.Core.ComputeShader;
using n13 = e29::Stride.Rendering.Materials;

namespace _SolarSystem_.Main
{
    [n1.ElementAttribute(TracingId = 314424U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "EnZiuY2Vb0QLrZO1M4x3Xe", Name = "SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe")]
    [n2.SerializableAttribute]
    public class SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe Create(n1.NodeContext Node_Context)
        {
            var instance = new SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe CreateDefault()
        {
            var instance = new SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe Update()
        {
            n3.Color4 __pad_QvfgDEapxguOHsgsbrdfhQ_0 = __slot_QvfgDEapxguOHsgsbrdfhQ;
            float __pad_EPUeJfqUMHMQXuL2EKfkRt_1 = __slot_EPUeJfqUMHMQXuL2EKfkRt;
            float __pad_Dr5eyJso53sNHfmfwIorSU_2 = __slot_Dr5eyJso53sNHfmfwIorSU;
            float __pad_G2SngEuROj3OjpqJ381uPg_3 = __slot_G2SngEuROj3OjpqJ381uPg;
            float __pad_BfGf5Xs3RVFOZxZABBVsSo_4 = __slot_BfGf5Xs3RVFOZxZABBVsSo;
            n3.Vector3 __pad_LJj6ofOvFTPQaRa9qlcpP8_5 = __slot_LJj6ofOvFTPQaRa9qlcpP8;
            float __pad_ElLKiM9nwQWPrizJxSrshO_6 = __slot_ElLKiM9nwQWPrizJxSrshO;
            string __pad_Su9eu5EQnKcNqYZ9i6ylZX_7 = __slot_Su9eu5EQnKcNqYZ9i6ylZX;
            float __pad_GAF7PE77ztCQSKS8FZbD2v_8 = __slot_GAF7PE77ztCQSKS8FZbD2v;
            float __pad_Im0kbKlxiapQJVu62daFTD_9 = __slot_Im0kbKlxiapQJVu62daFTD;
            float __pad_IiRyUXU8UOXLLYgfKoAmvi_10 = __slot_IiRyUXU8UOXLLYgfKoAmvi;
            float __pad_TwJlA2dszaCPagj5CLaBlJ_11 = __slot_TwJlA2dszaCPagj5CLaBlJ;
            float __pad_Gt5u29j3RK6PR8FvXPCAUi_12 = __slot_Gt5u29j3RK6PR8FvXPCAUi;
            float __pad_IGkMiifOOukPySqcXHucq9_13 = __slot_IGkMiifOOukPySqcXHucq9;
            float __pad_MIbLpkqshZzOgbhPCvqbnI_14 = __slot_MIbLpkqshZzOgbhPCvqbnI;
            float __pad_UUnuED7kaLLLKBQdlIfMAO_15 = __slot_UUnuED7kaLLLKBQdlIfMAO;
            float __pad_Lx83aOmXbQNPQ9dj7VNSdn_16 = __slot_Lx83aOmXbQNPQ9dj7VNSdn;
            bool __pad_FrvoWOlIadEL3SsVx8zadB_17 = __slot_FrvoWOlIadEL3SsVx8zadB;
            bool __pad_M8t1Yzt3VXiNNuZ5cLlpE3_18 = __slot_M8t1Yzt3VXiNNuZ5cLlpE3;
            n3.Color4 __pad_EyK4v7BqHIcMYh4uf2z2se_19 = __slot_EyK4v7BqHIcMYh4uf2z2se;
            n3.Vector3 __pad_SPgCKmAE5gENe2Wt0rl6aQ_20 = __slot_SPgCKmAE5gENe2Wt0rl6aQ;
            n3.Vector3 __pad_SH92pe7L5jLMlN1BDFClz8_21 = __slot_SH92pe7L5jLMlN1BDFClz8;
            n3.Vector3 __pad_OQIQTm7J51rNZdjXyUIKKy_22 = __slot_OQIQTm7J51rNZdjXyUIKKy;
            bool __pad_I4BQIaSNUGTMaARYZncVs2_23 = __slot_I4BQIaSNUGTMaARYZncVs2;
            bool __pad_BDT1cjoC45MOvdqXC0DYmg_24 = __slot_BDT1cjoC45MOvdqXC0DYmg;
            n3.Vector3 __pad_AxVbZAlvdqNL5Awjias4aG_25 = __slot_AxVbZAlvdqNL5Awjias4aG;
            n3.Vector3 __pad_Cnn9z927rzZNwzXR6m3ljr_26 = __slot_Cnn9z927rzZNwzXR6m3ljr;
            float __pad_QHZ3uzdvXUjLf2UV9c4eIS_27 = __slot_QHZ3uzdvXUjLf2UV9c4eIS;
            float __pad_E6Ym8sBgculP3UFLrNUWi1_28 = __slot_E6Ym8sBgculP3UFLrNUWi1;
            float __pad_KB4H7X6nsHcPP5V3lSnqAZ_29 = __slot_KB4H7X6nsHcPP5V3lSnqAZ;
            float __pad_M0QHaJh4XoQL1SIck8fT8d_30 = __slot_M0QHaJh4XoQL1SIck8fT8d;
            n3.Vector3 __pad_BMYNXuWezKgPx5VuCBwTYq_31 = __slot_BMYNXuWezKgPx5VuCBwTYq;
            n3.Vector3 __pad_CKCwVmMzoIQPFIkTXZUCAx_32 = __slot_CKCwVmMzoIQPFIkTXZUCAx;
            float __pad_GefaxCZlT0BOcRz83bdQOF_33 = __slot_GefaxCZlT0BOcRz83bdQOF;
            float __pad_CpTNE6Bw24TMPYZE0hSj1F_34 = __slot_CpTNE6Bw24TMPYZE0hSj1F;
            int __pad_SUqIiQ6kKyLNnIrvCORVrH_35 = __slot_SUqIiQ6kKyLNnIrvCORVrH;
            float __pad_JQnsjCJwuc8M5ebI9zH5Av_36 = __slot_JQnsjCJwuc8M5ebI9zH5Av;
            float __pad_Tuy1tIxzGMVNSHTnurU6vr_37 = __slot_Tuy1tIxzGMVNSHTnurU6vr;
            n3.Int3 __pad_QxDMNKsgBveMUETh04R4Rf_38 = __slot_QxDMNKsgBveMUETh04R4Rf;
            bool __pad_IBdRsPLm565LLBSSTfSnWL_39 = __slot_IBdRsPLm565LLBSSTfSnWL;
            bool __pad_Jm88CF0iTHyLlwHNnL9CQG_40 = __slot_Jm88CF0iTHyLlwHNnL9CQG;
            int __pad_AGQ9Syt3RuFQIpr2frULID_41 = __slot_AGQ9Syt3RuFQIpr2frULID;
            bool __pad_GN7zRmO26qIOVymEtZdXFT_42 = __slot_GN7zRmO26qIOVymEtZdXFT;
            bool __pad_LHbPOgTIvTIPBRIKw1TRZl_43 = __slot_LHbPOgTIvTIPBRIKw1TRZl;
            bool __pad_AR9RQ7xAE10QddTcONSdDo_44 = __slot_AR9RQ7xAE10QddTcONSdDo;
            float __pad_P6p4HFdccgEQKncO6DqMoK_45 = __slot_P6p4HFdccgEQKncO6DqMoK;
            n3.Vector3 __pad_AWALTrhZHc7Pv9sN7WpqWM_46 = __slot_AWALTrhZHc7Pv9sN7WpqWM;
            bool __pad_ItYbQaI1jv7QDycnchM5UI_47 = __slot_ItYbQaI1jv7QDycnchM5UI;
            float __pad_C14EnKTG8cQNrbpYc05JyI_48 = __slot_C14EnKTG8cQNrbpYc05JyI;
            bool Pause_49 = false;
            bool Update_50 = true;
            var Output_51 = this.__p_LFGKDhTXHAMMxaYMlzdHdi;
            if (Update_50)
            {
                Output_51 = this.__p_LFGKDhTXHAMMxaYMlzdHdi.Update(Period_In: __pad_MIbLpkqshZzOgbhPCvqbnI_14, Pause_In: Pause_49);
            }

            var Output_55 = Output_51.GetValues(Phase_Out: out float Phase_52, On_New_Cycle_Out: out bool On_New_Cycle_53, Cycles_Out: out int Cycles_54);
            bool Inverse_56 = false;
            n6._Operations_.SawtoothWave(Phase_In: Phase_52, Inverse_In: Inverse_56, Output_Out: out float Output_57);
            n3.Matrix Input_58 = n7._Operations_.CreateDefault();
            n8._Operations_.Rotate_Axis(Input_In: Input_58, Axis_In: __pad_LJj6ofOvFTPQaRa9qlcpP8_5, Angle_In: Output_57, Output_Out: out n3.Matrix Output_59);
            bool SetTransformation_60 = true;
            var Output_61 = this.__p_ERkRanxvitmLzn4m9aC7dO;
            if (SetTransformation_60)
            {
                Output_61 = this.__p_ERkRanxvitmLzn4m9aC7dO.SetTransformation(Transformation_In: Output_59);
            }

            int Tessellation_62 = 16;
            bool SetupModel_63 = true;
            var Output_64 = Output_61;
            if (SetupModel_63)
            {
                Output_64 = Output_61.SetupModel(Radius_In: __pad_ElLKiM9nwQWPrizJxSrshO_6, Tessellation_In: Tessellation_62);
            }

            n9.Path Path_65 = __c_UlO3Efn87NJQKsbm4PZlok;
            bool Generate_Mipmaps_66 = true;
            bool Is_sRGB_67 = true;
            bool Premultiply_Alpha_68 = true;
            bool Compress_69 = false;
            n10.AlphaFormat Alpha_Format_70 = __c_VaUJ2yQ5QlcPIyddkiszNb;
            bool Reload_71 = false;
            var Output_75 = this.__p_Bfr5HYSsZP7LzIkGCfTtKJ.Update(Path_In: Path_65, Generate_Mipmaps_In: Generate_Mipmaps_66, Is_sRGB_In: Is_sRGB_67, Premultiply_Alpha_In: Premultiply_Alpha_68, Compress_In: Compress_69, Alpha_Format_In: Alpha_Format_70, Reload_In: Reload_71, Texture_Out: out n11.Texture Texture_72, Is_Loading_Out: out bool Is_Loading_73, Already_Loaded_Out: out bool Already_Loaded_74);
            bool SetTexure_76 = true;
            var Output_77 = this.__p_GtE3SRD0l67PPMD3tR7Yk3;
            if (SetTexure_76)
            {
                Output_77 = this.__p_GtE3SRD0l67PPMD3tR7Yk3.SetTexure(Texture_In: Texture_72);
            }

            var State_Output_79 = Output_77.Update(Output_Out: out n12.SetVar<n3.Vector4> Output_78);
            n1.CompilationHelper.WritePin(this.__p_DQ0002lcFvpOxWQbfChKsz.Inputs[0], ref Output_78);
            bool SetTexure_80 = true;
            var Output_81 = this.__p_ST6vfERwyI6LVi6c6j8xqr;
            if (SetTexure_80)
            {
                Output_81 = this.__p_ST6vfERwyI6LVi6c6j8xqr.SetTexure(Texture_In: Texture_72);
            }

            var State_Output_83 = Output_81.Update(Output_Out: out n12.SetVar<float> Output_82);
            n1.CompilationHelper.WritePin(this.__p_DQ0002lcFvpOxWQbfChKsz.Inputs[1], ref Output_82);
            n1.CompilationHelper.ReadPin(this.__p_DQ0002lcFvpOxWQbfChKsz.Outputs[0], out n13.MaterialEmissiveMapFeature out_84);
            n13.IMaterialEmissiveFeature Emissive_85 = (n13.IMaterialEmissiveFeature)out_84;
            bool SetEmissive_86 = true;
            var Output_87 = this.__p_OnshscpT9JwPOvREOUyCqX;
            if (SetEmissive_86)
            {
                Output_87 = this.__p_OnshscpT9JwPOvREOUyCqX.SetEmissive(Emissive_In: Emissive_85);
            }

            var State_Output_89 = Output_87.Update(Output_Out: out n14.Material Output_88);
            bool SetMaterial_90 = true;
            var Output_91 = Output_64;
            if (SetMaterial_90)
            {
                Output_91 = Output_64.SetMaterial(Material_In: Output_88);
            }

            bool Update_92 = true;
            var Output_93 = this.__p_GGeWWawk2BXQSONZdtWM3Y;
            if (Update_92)
            {
                Output_93 = this.__p_GGeWWawk2BXQSONZdtWM3Y.Update();
            }

            n15.IResourceHandler_I Resource_Handler_94 = (n15.IResourceHandler_I)Output_93;
            n16.GpuValue<float> Probability_95 = this.__monadBuilder_SQvW9DjumhULceku1CfaO3.Return(__pad_GefaxCZlT0BOcRz83bdQOF_33);
            n16.GpuValue<n3.Vector3> Min_96 = this.__monadBuilder_PpkB3lWQ8YGNjnomhVcQvr.Return(__pad_CKCwVmMzoIQPFIkTXZUCAx_32);
            n16.GpuValue<n3.Vector3> Max_97 = this.__monadBuilder_FvbQXvSGiDwNMZOK5846cQ.Return(__pad_BMYNXuWezKgPx5VuCBwTYq_31);
            bool PerID_98 = true;
            int seed_99 = -1;
            bool Constant_100 = false;
            var Output_102 = this.__p_CfJsgWMgYUPO3wcjLTXna5.Update(PerID_In: PerID_98, seed_In: seed_99, Constant_In: Constant_100, Min_In: Min_96, Max_In: Max_97, Shader_Graph_Out: out n16.GpuValue<n3.Vector3> Shader_Graph_101);
            n16.GpuValue<float> Radius_103 = this.__monadBuilder_Hv290cWar54LTWf1KsF725.Return(__pad_E6Ym8sBgculP3UFLrNUWi1_28);
            n16.GpuValue<n3.Vector3> Center_104 = default(n16.GpuValue<n3.Vector3>);
            bool Volume_105 = true;
            n3.Color4 Helper_Color_106 = n17._Operations_.CreateDefault();
            bool Helper_Enabled_107 = true;
            var State_Output_109 = this.__p_EHCd4QZiBmMPridsXQZXnH.Update(Center_In: Center_104, Radius_In: Radius_103, Volume_In: Volume_105, Helper_Color_In: Helper_Color_106, Helper_Enabled_In: Helper_Enabled_107, Output_Out: out n16.GpuValue<n3.Vector3> Output_108);
            n16.GpuValue<float> Min_110 = this.__monadBuilder_Uik8KLTSKWHQYCBuRdcHwE.Return(__pad_KB4H7X6nsHcPP5V3lSnqAZ_29);
            n16.GpuValue<float> Max_111 = this.__monadBuilder_NQ4BEMMnc7BMtXZurttGhG.Return(__pad_M0QHaJh4XoQL1SIck8fT8d_30);
            bool PerID_112 = true;
            int seed_113 = -1;
            bool Constant_114 = false;
            var Output_116 = this.__p_PWUlZefy3hJNdtSJzVHeAm.Update(PerID_In: PerID_112, seed_In: seed_113, Constant_In: Constant_114, Min_In: Min_110, Max_In: Max_111, Shader_Graph_Out: out n16.GpuValue<float> Shader_Graph_115);
            n16.GpuValue<float> mass_117 = default(n16.GpuValue<float>);
            n16.GpuValue<n3.Vector4> Color_118 = default(n16.GpuValue<n3.Vector4>);
            n16.GpuValue<n18.GpuVoid> Custom_119 = default(n16.GpuValue<n18.GpuVoid>);
            n16.GpuValue<float> DeltaTime_120 = default(n16.GpuValue<float>);
            bool Enabled_121 = true;
            var builder_122 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw, 1);
            builder_122.Add(Custom_119);
            var __pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw_123 = builder_122.Commit();
            var State_Output_125 = this.__p_Q6JNBAuu5VeQEyX9fshZGw.Update(Probability_In: Probability_95, Position_In: Shader_Graph_101, Velocity_In: Output_108, mass_In: mass_117, Lifetime_In: Shader_Graph_115, Color_In: Color_118, Custom_In: __pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw_123, DeltaTime_In: DeltaTime_120, Enabled_In: Enabled_121, Output_Out: out n16.GpuValue<n18.GpuVoid> Output_124);
            n3.Matrix Input_126 = __c_JE9MS0W6yH3Lx1mAhNMx77;
            n3.Vector3 Rotation_127 = __c_BYR4bPl8XjbMVT79XZp9BI;
            n8._Operations_.TransformSRT(Input_In: Input_126, Scaling_In: __pad_AxVbZAlvdqNL5Awjias4aG_25, Rotation_In: Rotation_127, Translation_In: __pad_Cnn9z927rzZNwzXR6m3ljr_26, Output_Out: out n3.Matrix Output_128);
            var Output_129 = n20.Noise.Random(from: __pad_SH92pe7L5jLMlN1BDFClz8_21, to: __pad_OQIQTm7J51rNZdjXyUIKKy_22);
            bool Update_130 = true;
            var Output_131 = this.__p_Ufv8dRgeGhHLr5VHF387ue;
            if (Update_130)
            {
                Output_131 = this.__p_Ufv8dRgeGhHLr5VHF387ue.Update(Position_In: __pad_SPgCKmAE5gENe2Wt0rl6aQ_20, Radius_In: __pad_Lx83aOmXbQNPQ9dj7VNSdn_16, Impulse_Value_In: Output_129, Helper_Color_In: __pad_EyK4v7BqHIcMYh4uf2z2se_19, Helper_Henabled_In: __pad_FrvoWOlIadEL3SsVx8zadB_17, Enabled_In: __pad_M8t1Yzt3VXiNNuZ5cLlpE3_18);
            }

            n22.SphericalImpulse_C Input_2_132 = n21._Operations_.CreateDefault();
            n22.SphericalImpulse_C Input_3_133 = n21._Operations_.CreateDefault();
            var builder_134 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz, 3);
            builder_134.Add(Output_131);
            builder_134.Add(Input_2_132);
            builder_134.Add(Input_3_133);
            var __pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz_135 = builder_134.Commit();
            n23._Operations_.Cons<n22.SphericalImpulse_C>(Input_In: __pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz_135, Result_Out: out n19.Spread<n22.SphericalImpulse_C> Result_136);
            string Target_Texture_Name_137 = "Velocity";
            float Priority_138 = 0F;
            bool Configure_139 = true;
            var Output_140 = this.__p_ICy6XyB1hLzLLFrhFJby2G;
            if (Configure_139)
            {
                Output_140 = this.__p_ICy6XyB1hLzLLFrhFJby2G.Configure(Spherical_Impulses_In: Result_136, Target_Texture_Name_In: Target_Texture_Name_137, Priority_In: Priority_138, Helper_Enabled_In: __pad_BDT1cjoC45MOvdqXC0DYmg_24, Enabled_In: __pad_I4BQIaSNUGTMaARYZncVs2_23);
            }

            n22.IFluidComponent_I Input_141 = (n22.IFluidComponent_I)Output_140;
            n22.IFluidComponent_I Input_2_142 = default(n22.IFluidComponent_I);
            var builder_143 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA, 2);
            builder_143.Add(Input_141);
            builder_143.Add(Input_2_142);
            var __pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA_144 = builder_143.Commit();
            n23._Operations_.Cons<n22.IFluidComponent_I>(Input_In: __pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA_144, Result_Out: out n19.Spread<n22.IFluidComponent_I> Result_145);
            bool Configure_146 = true;
            var Output_147 = this.__p_UX5gEDZEBNLMWbHcXmfHl2;
            if (Configure_146)
            {
                Output_147 = this.__p_UX5gEDZEBNLMWbHcXmfHl2.Configure(Transform_In: Output_128, Resolution_In: __pad_QxDMNKsgBveMUETh04R4Rf_38, Fluid_TimeStep_In: __pad_Tuy1tIxzGMVNSHTnurU6vr_37, Velocity_Mult_In: __pad_JQnsjCJwuc8M5ebI9zH5Av_36, Jacobi_Iterations_In: __pad_SUqIiQ6kKyLNnIrvCORVrH_35, Vorticity_Strength_In: __pad_CpTNE6Bw24TMPYZE0hSj1F_34, Components_In: Result_145, Volume_Raymarching_Helper_Enabled_In: __pad_Jm88CF0iTHyLlwHNnL9CQG_40, Raymarching_Fluid_Texture_Index_In: __pad_AGQ9Syt3RuFQIpr2frULID_41, Helper_Enabled_In: __pad_IBdRsPLm565LLBSSTfSnWL_39);
            }

            var Output_148 = Output_147;
            if (__pad_GN7zRmO26qIOVymEtZdXFT_42)
            {
                Output_148 = Output_147.Reset();
            }

            bool External_Renderer_Enabled_149 = false;
            string Debug_Custom_Texture_Name_150 = "";
            var Output_152 = Output_148.Update(Simulation_Enabled_In: __pad_LHbPOgTIvTIPBRIKw1TRZl_43, External_Renderer_Enabled_In: External_Renderer_Enabled_149, Debug_Custom_Texture_Name_In: Debug_Custom_Texture_Name_150, Renderer_Out: out n24.GraphicsRendererGroup Renderer_151);
            var Output_154 = Output_152.GetVelocityTexture(Velocity_Texture_Out: out n11.Texture Velocity_Texture_153);
            n16.GpuValue<float> Strength_155 = this.__monadBuilder_DsJlpRsag2mPPtZAwPnuay.Return(__pad_QHZ3uzdvXUjLf2UV9c4eIS_27);
            n16.GpuValue<n11.SamplerState> Sampler_156 = default(n16.GpuValue<n11.SamplerState>);
            n16.GpuValue<float> Sample_Level_157 = default(n16.GpuValue<float>);
            bool Mode_VelocityDForce_158 = false;
            bool Force_is_Relative_159 = false;
            bool Enabled_160 = true;
            bool Helper_Enabled_162 = false;
            bool Helper_Texture_Enabled_163 = false;
            n16.GpuValue<bool> Enabled_161 = this.__monadBuilder_U5cWl62ykMBMEQYkrVXAfQ.Return(Enabled_160);
            var State_Output_166 = this.__p_G3uepad3fsSOxk4R7P9jNO.Update(Texture_In: Velocity_Texture_153, Sampler_In: Sampler_156, Sample_Level_In: Sample_Level_157, Transformation_In: Output_128, Strength_In: Strength_155, Mode_VelocityDForce_In: Mode_VelocityDForce_158, Force_is_Relative_In: Force_is_Relative_159, Enabled_In: Enabled_161, Helper_Enabled_In: Helper_Enabled_162, Helper_Texture_Enabled_In: Helper_Texture_Enabled_163, Output_Out: out n16.GpuValue<n18.GpuVoid> Output_164, Vector_Out: out n16.GpuValue<n3.Vector3> Vector_165);
            n16.GpuValue<float> ScalePositionDelta_167 = default(n16.GpuValue<float>);
            n16.GpuValue<float> ScaleAgeDelta_168 = default(n16.GpuValue<float>);
            bool Enabled_169 = true;
            n16.GpuValue<bool> Enabled_170 = this.__monadBuilder_VSmT69vvnssOiUexZCxxzz.Return(Enabled_169);
            var State_Output_172 = this.__p_LwQHfdgLmF2OBmSFZop08B.Update(ScalePositionDelta_In: ScalePositionDelta_167, ScaleAgeDelta_In: ScaleAgeDelta_168, Enabled_In: Enabled_170, Output_Out: out n16.GpuValue<n18.GpuVoid> Output_171);
            bool Enabled_173 = true;
            var builder_174 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE, 3);
            builder_174.Add(Output_124);
            builder_174.Add(Output_164);
            builder_174.Add(Output_171);
            var __pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE_175 = builder_174.Commit();
            var State_Output_177 = this.__p_JSEh1Uk1o9IOpCdt2wLfpE.Update(Input_In: __pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE_175, Enabled_In: Enabled_173, Output_Out: out n16.GpuValue<n18.GpuVoid> Output_176);
            var Output_180 = this.__p_SOWQ6XzhJFsOyESZPeZSgQ.Update(Shader_Graph_In: Output_176, Shader_Graph_Out: out n16.GpuValue<n18.GpuVoid> Shader_Graph_178, Attributes_Out: out n25.Dictionary<string, n25.List<n15.AttributeReference_C>> Attributes_179);
            n15.IComputeStage_I Input_4_181 = (n15.IComputeStage_I)Output_180;
            n16.GpuValue<float> Input_182 = this.__monadBuilder_AmfCdWhIzArMRoBIflQeCe.Return(__pad_P6p4HFdccgEQKncO6DqMoK_45);
            var State_Output_184 = this.__p_S9ovLip24W4NDIxtbORWr8.Update(Output_Out: out n16.GpuValue<float> Output_183);
            var builder_185 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_OdbXhnD00IdNQY62paTYzX, 2);
            builder_185.Add(Input_182);
            builder_185.Add(Output_183);
            var __pin_group_Input_In_OdbXhnD00IdNQY62paTYzX_186 = builder_185.Commit();
            var State_Output_188 = this.__p_OdbXhnD00IdNQY62paTYzX.Update(Input_In: __pin_group_Input_In_OdbXhnD00IdNQY62paTYzX_186, Output_Out: out n16.GpuValue<float> Output_187);
            var Output_190 = this.__p_PFy7VK8L0W0QU7tMBGS1uR.GetShaderGraph(graph_Out: out n16.GpuValue<n3.Vector4> graph_189);
            var State_Output_192 = this.__p_VP2jZdismcJPmArV0EYcpU.Update(Input_In: graph_189, Output_Out: out n16.GpuValue<n3.Vector3> Output_191);
            n16.GpuValue<n3.Vector3> Input_193 = this.__monadBuilder_ROokG4ir22VL4m6cKXIKnH.Return(__pad_AWALTrhZHc7Pv9sN7WpqWM_46);
            var State_Output_195 = this.__p_HKF9qVG4T1lPHPnt5wyo93.Update(Output_Out: out n16.GpuValue<n3.Vector3> Output_194);
            var builder_196 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_MuE2Xk4eqcBM22oIb32War, 2);
            builder_196.Add(Input_193);
            builder_196.Add(Output_194);
            var __pin_group_Input_In_MuE2Xk4eqcBM22oIb32War_197 = builder_196.Commit();
            var State_Output_199 = this.__p_MuE2Xk4eqcBM22oIb32War.Update(Input_In: __pin_group_Input_In_MuE2Xk4eqcBM22oIb32War_197, Output_Out: out n16.GpuValue<n3.Vector3> Output_198);
            float The_Value_200 = 0.5F;
            var State_Output_202 = this.__p_FDnKyk7VUYiP1TdcUPqiXI.Update(The_Value_In: The_Value_200, Output_Out: out n16.ConstantValue<n3.Vector3> Output_201);
            var builder_203 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL, 2);
            builder_203.Add(Output_198);
            builder_203.Add(Output_201);
            var __pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL_204 = builder_203.Commit();
            var State_Output_206 = this.__p_R8vq1DF3FPgLR8qvhRvjSL.Update(Input_In: __pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL_204, Output_Out: out n16.GpuValue<n3.Vector3> Output_205);
            var builder_207 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI, 2);
            builder_207.Add(Output_191);
            builder_207.Add(Output_205);
            var __pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI_208 = builder_207.Commit();
            var State_Output_210 = this.__p_CWYW4NkTQxeLwuvt9fnNKI.Update(Input_In: __pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI_208, Output_Out: out n16.GpuValue<n3.Vector3> Output_209);
            n16.GpuValue<float> w_211 = default(n16.GpuValue<float>);
            var State_Output_213 = this.__p_N8WAgidoDtILowoa9u0wXn.Update(xyz_In: Output_209, w_In: w_211, Output_Out: out n16.GpuValue<n3.Vector4> Output_212);
            n11.DepthStencilStateDescription Depth_Stencil_State_214 = n26._Operations_.CreateDefault_H();
            n16.GpuValue<n3.Vector3> Position_215 = default(n16.GpuValue<n3.Vector3>);
            n16.GpuValue<bool> Skip_216 = default(n16.GpuValue<bool>);
            n16.GpuValue<n3.Vector4> ColorTarget_217 = default(n16.GpuValue<n3.Vector4>);
            n16.GpuValue<float> Clip_218 = default(n16.GpuValue<float>);
            bool Force_Cache_219 = false;
            var Output_225 = this.__p_AGYldRxOaffOvgLjEVQa9Y.Update(Depth_Stencil_State_In: Depth_Stencil_State_214, Position_In: Position_215, Size_In: Output_187, Color_In: Output_212, Skip_In: Skip_216, ColorTarget_In: ColorTarget_217, Clip_In: Clip_218, Force_Cache_In: Force_Cache_219, Enabled_In: __pad_AR9RQ7xAE10QddTcONSdDo_44, ComputeStage_Out: out n27.BaseRenderer_C ComputeStage_220, Entity_Out: out n28.Entity Entity_221, lastError_Out: out string lastError_222, Shader_Code_Out: out string Shader_Code_223, Ticket_Out: out int Ticket_224);
            n15.IComputeStage_I Input_2_226 = (n15.IComputeStage_I)ComputeStage_220;
            n19.Spread<n15.IUpdateGraph_I> UpdateGraphs_227 = __c_PYnws25s2pNP9iE9pskkXz;
            var builder_228 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2, 2);
            builder_228.Add(Input_4_181);
            builder_228.Add(Input_2_226);
            var __pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2_229 = builder_228.Commit();
            var State_Output_232 = this.__p_IISoeXJhwaTPSR0W9XTTU2.Update(Resource_Handler_In: Resource_Handler_94, UpdateGraphs_In: UpdateGraphs_227, Input_In: __pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2_229, Output_Out: out bool Output_230, Highest_Ticket_Out: out int Highest_Ticket_231);
            bool SetHelperEnabled_233 = true;
            var Output_234 = State_Output_232;
            if (SetHelperEnabled_233)
            {
                Output_234 = State_Output_232.SetHelperEnabled(Helper_Enabled_In: __pad_ItYbQaI1jv7QDycnchM5UI_47);
            }

            var Output_236 = Output_234.GetHelperEntity(Helper_Entity_Out: out n28.Entity Helper_Entity_235);
            var Output_238 = Output_154.GetHelperEntity(Helper_Entity_Out: out n28.Entity Helper_Entity_237);
            n28.Entity Child_4_239 = default(n28.Entity);
            bool SetChildren_240 = true;
            var builder_241 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI, 4);
            builder_241.Add(Helper_Entity_235);
            builder_241.Add(Helper_Entity_237);
            builder_241.Add(Entity_221);
            builder_241.Add(Child_4_239);
            var __pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI_242 = builder_241.Commit();
            var Output_243 = this.__p_PIlyGh2nlRJPewsBw9eraI;
            if (SetChildren_240)
            {
                Output_243 = this.__p_PIlyGh2nlRJPewsBw9eraI.SetChildren(Child_In: __pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI_242);
            }

            var State_Output_245 = Output_243.Update(Output_Out: out n28.Entity Output_244);
            int Count_246 = 1;
            n23._Operations_.Repeat<n28.Entity>(Element_In: Output_244, Count_In: Count_246, Result_Out: out n19.Spread<n28.Entity> Result_247);
            bool SetChildren_248 = true;
            var Output_249 = Output_91;
            if (SetChildren_248)
            {
                Output_249 = Output_91.SetChildren(Children_In: Result_247);
            }

            bool SetName_250 = true;
            var Output_251 = Output_249;
            if (SetName_250)
            {
                Output_251 = Output_249.SetName(Name_In: __pad_Su9eu5EQnKcNqYZ9i6ylZX_7);
            }

            var Output_253 = Output_251.Update(Entity_Out: out n28.Entity Entity_252);
            n9.Path Path_254 = __c_T7ja0sZUaiuMa0pDwNGc2k;
            bool Generate_Mipmaps_255 = true;
            bool Is_sRGB_256 = true;
            bool Premultiply_Alpha_257 = true;
            bool Compress_258 = false;
            n10.AlphaFormat Alpha_Format_259 = __c_Pg0LAhaGh1bMIV7y55Yo71;
            bool Reload_260 = false;
            var Output_264 = this.__p_OfTtOPMBdg3OHwnYTj54BI.Update(Path_In: Path_254, Generate_Mipmaps_In: Generate_Mipmaps_255, Is_sRGB_In: Is_sRGB_256, Premultiply_Alpha_In: Premultiply_Alpha_257, Compress_In: Compress_258, Alpha_Format_In: Alpha_Format_259, Reload_In: Reload_260, Texture_Out: out n11.Texture Texture_261, Is_Loading_Out: out bool Is_Loading_262, Already_Loaded_Out: out bool Already_Loaded_263);
            bool Is_Specular_Only_265 = false;
            float Intensity_266 = 0.5F;
            n29.SkyboxPreFilteringDiffuseOrder Diffuse_SHOrder_267 = n1.CompilationHelper.Deserialize<n29.SkyboxPreFilteringDiffuseOrder>("Order3", false, null, null);
            int Specular_Cube_Map_Size_268 = 256;
            bool Force_Build_269 = false;
            float Background_Intensity_270 = 1F;
            bool Background_Enabled_271 = true;
            bool SetupLight_272 = true;
            var Output_273 = this.__p_KcP0mVGEEMyMJSIIOz4q6G;
            if (SetupLight_272)
            {
                Output_273 = this.__p_KcP0mVGEEMyMJSIIOz4q6G.SetupLight(Cube_Map_In: Texture_261, Is_Specular_Only_In: Is_Specular_Only_265, Intensity_In: Intensity_266, Diffuse_SHOrder_In: Diffuse_SHOrder_267, Specular_Cube_Map_Size_In: Specular_Cube_Map_Size_268, Force_Build_In: Force_Build_269, Background_Intensity_In: Background_Intensity_270, Background_Enabled_In: Background_Enabled_271);
            }

            var Output_275 = Output_273.Update(Entity_Out: out n28.Entity Entity_274);
            n28.Entity Child_3_276 = default(n28.Entity);
            n28.Entity Child_4_277 = default(n28.Entity);
            n19.Spread<n28.Scene> Child_Scenes_278 = n23._Operations_.CreateDefault<n28.Scene>();
            bool Enabled_279 = true;
            var builder_280 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X, 4);
            builder_280.Add(Entity_252);
            builder_280.Add(Entity_274);
            builder_280.Add(Child_3_276);
            builder_280.Add(Child_4_277);
            var __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X_281 = builder_280.Commit();
            var State_Output_283 = this.__p_K3KQpcOhUioPgSrxkO4C8X.Update(Child_In: __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X_281, Child_Scenes_In: Child_Scenes_278, Enabled_In: Enabled_279, Output_Out: out n28.SceneInstance Output_282);
            float Threshold_284 = 0.25F;
            n1.CompilationHelper.WritePin(this.__p_ICYDa1ufXCnM07cWMLwy26.Inputs[0], ref Threshold_284);
            float Steepness_285 = 0.69F;
            n1.CompilationHelper.WritePin(this.__p_ICYDa1ufXCnM07cWMLwy26.Inputs[1], ref Steepness_285);
            n1.CompilationHelper.ReadPin(this.__p_ICYDa1ufXCnM07cWMLwy26.Outputs[0], out n30.BrightFilter out_286);
            bool SetBrightFilter_287 = true;
            var Output_288 = this.__p_AWPP9NmBEsSPEZwWyWxim8;
            if (SetBrightFilter_287)
            {
                Output_288 = this.__p_AWPP9NmBEsSPEZwWyWxim8.SetBrightFilter(Bright_Filter_In: out_286);
            }

            n1.CompilationHelper.WritePin(this.__p_DePkTYuokNyLpjnZCSEsLh.Inputs[0], ref __pad_GAF7PE77ztCQSKS8FZbD2v_8);
            bool Pause_289 = false;
            bool Update_290 = true;
            var Output_291 = this.__p_RXYspH49pTUPY59Q5ELaE3;
            if (Update_290)
            {
                Output_291 = this.__p_RXYspH49pTUPY59Q5ELaE3.Update(Period_In: __pad_UUnuED7kaLLLKBQdlIfMAO_15, Pause_In: Pause_289);
            }

            var Output_295 = Output_291.GetValues(Phase_Out: out float Phase_292, On_New_Cycle_Out: out bool On_New_Cycle_293, Cycles_Out: out int Cycles_294);
            n6._Operations_.SineWave(Phase_In: Phase_292, Output_Out: out float Output_296);
            n32._Operations_.Map<float, n31.__AdaptiveImplementations__KYrBT1ndOH9MqXl8wdSpYV>(Input_In: Output_296, Input_Minimum_In: __pad_Im0kbKlxiapQJVu62daFTD_9, Input_Maximum_In: __pad_IiRyUXU8UOXLLYgfKoAmvi_10, Output_Minimum_In: __pad_TwJlA2dszaCPagj5CLaBlJ_11, Output_Maximum_In: __pad_Gt5u29j3RK6PR8FvXPCAUi_12, Output_Out: out float Output_297);
            n1.CompilationHelper.WritePin(this.__p_DePkTYuokNyLpjnZCSEsLh.Inputs[1], ref Output_297);
            n1.CompilationHelper.ReadPin(this.__p_DePkTYuokNyLpjnZCSEsLh.Outputs[0], out n30.Bloom out_298);
            bool SetBloom_299 = true;
            var Output_300 = Output_288;
            if (SetBloom_299)
            {
                Output_300 = Output_288.SetBloom(Bloom_In: out_298);
            }

            var State_Output_302 = Output_300.Update(Output_Out: out n30.PostProcessingEffects Output_301);
            n30.IPostProcessingEffects Post_Effects_303 = (n30.IPostProcessingEffects)Output_301;
            n28.Entity Camera_304 = default(n28.Entity);
            bool Enable_Default_Camera_305 = true;
            string Title_306 = "Stride";
            n3.Color4 Clear_Color_307 = __c_JEl7pDETGAvNkXUCGrl3dv;
            bool Clear_308 = true;
            bool Enable_Default_Post_Effects_309 = true;
            n14.RenderGroupMask Render_Group_Mask_310 = n1.CompilationHelper.Deserialize<n14.RenderGroupMask>("All", false, null, null);
            bool Enable_Keyboard_Shortcuts_311 = true;
            string Model_Effect_Name_312 = "VLEffectMain";
            n19.Spread<n33.IAdditionalSceneRenderer_I> Additional_Scene_Renderers_313 = n23._Operations_.CreateDefault<n33.IAdditionalSceneRenderer_I>();
            bool Enabled_314 = true;
            var State_Output_316 = this.__p_IH6pxwZSh1qPYIOjUJVLYx.Update(Input_In: Output_282, Camera_In: Camera_304, Enable_Default_Camera_In: Enable_Default_Camera_305, Title_In: Title_306, Clear_Color_In: Clear_Color_307, Clear_In: Clear_308, Post_Effects_In: Post_Effects_303, Enable_Default_Post_Effects_In: Enable_Default_Post_Effects_309, Render_Group_Mask_In: Render_Group_Mask_310, Enable_Keyboard_Shortcuts_In: Enable_Keyboard_Shortcuts_311, Model_Effect_Name_In: Model_Effect_Name_312, Additional_Scene_Renderers_In: Additional_Scene_Renderers_313, Enabled_In: Enabled_314, Output_Out: out n34.GameWindow Output_315);
            bool Fallback_Color_Premultiply_Alpha_317 = true;
            bool Is_Normal_318 = false;
            bool SetFallbackColor_319 = true;
            var Output_320 = State_Output_79;
            if (SetFallbackColor_319)
            {
                Output_320 = State_Output_79.SetFallbackColor(Fallback_Color_In: __pad_QvfgDEapxguOHsgsbrdfhQ_0, Fallback_Color_Premultiply_Alpha_In: Fallback_Color_Premultiply_Alpha_317, Is_Normal_In: Is_Normal_318);
            }

            bool Pause_321 = false;
            bool Update_322 = true;
            var Output_323 = this.__p_I2X9mE0xUf5MjMshDBZjXM;
            if (Update_322)
            {
                Output_323 = this.__p_I2X9mE0xUf5MjMshDBZjXM.Update(Period_In: __pad_IGkMiifOOukPySqcXHucq9_13, Pause_In: Pause_321);
            }

            var Output_327 = Output_323.GetValues(Phase_Out: out float Phase_324, On_New_Cycle_Out: out bool On_New_Cycle_325, Cycles_Out: out int Cycles_326);
            n6._Operations_.SineWave(Phase_In: Phase_324, Output_Out: out float Output_328);
            n32._Operations_.Map<float, n31.__AdaptiveImplementations__KYrBT1ndOH9MqXl8wdSpYV>(Input_In: Output_328, Input_Minimum_In: __pad_EPUeJfqUMHMQXuL2EKfkRt_1, Input_Maximum_In: __pad_Dr5eyJso53sNHfmfwIorSU_2, Output_Minimum_In: __pad_G2SngEuROj3OjpqJ381uPg_3, Output_Maximum_In: __pad_BfGf5Xs3RVFOZxZABBVsSo_4, Output_Out: out float Output_329);
            bool SetFallbackValue_330 = true;
            var Output_331 = State_Output_83;
            if (SetFallbackValue_330)
            {
                Output_331 = State_Output_83.SetFallbackValue(Fallback_Value_In: Output_329);
            }

            bool SetValue_332 = true;
            var Output_333 = State_Output_195;
            if (SetValue_332)
            {
                Output_333 = State_Output_195.SetValue(Input_In: __pad_C14EnKTG8cQNrbpYc05JyI_48);
            }

            n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe that_334 = this;
            if (this.__GetContext__().IsImmutable)
                that_334 = Output_55 != this.__p_LFGKDhTXHAMMxaYMlzdHdi || Output_253 != this.__p_ERkRanxvitmLzn4m9aC7dO || Output_75 != this.__p_Bfr5HYSsZP7LzIkGCfTtKJ || Output_320 != this.__p_GtE3SRD0l67PPMD3tR7Yk3 || this.__p_DQ0002lcFvpOxWQbfChKsz != this.__p_DQ0002lcFvpOxWQbfChKsz || Output_331 != this.__p_ST6vfERwyI6LVi6c6j8xqr || State_Output_89 != this.__p_OnshscpT9JwPOvREOUyCqX || Output_93 != this.__p_GGeWWawk2BXQSONZdtWM3Y || Output_102 != this.__p_CfJsgWMgYUPO3wcjLTXna5 || State_Output_109 != this.__p_EHCd4QZiBmMPridsXQZXnH || Output_116 != this.__p_PWUlZefy3hJNdtSJzVHeAm || __pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw_123 != this.__pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw || State_Output_125 != this.__p_Q6JNBAuu5VeQEyX9fshZGw || Output_131 != this.__p_Ufv8dRgeGhHLr5VHF387ue || __pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz_135 != this.__pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz || Output_140 != this.__p_ICy6XyB1hLzLLFrhFJby2G || __pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA_144 != this.__pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA || Output_238 != this.__p_UX5gEDZEBNLMWbHcXmfHl2 || State_Output_166 != this.__p_G3uepad3fsSOxk4R7P9jNO || State_Output_172 != this.__p_LwQHfdgLmF2OBmSFZop08B || __pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE_175 != this.__pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE || State_Output_177 != this.__p_JSEh1Uk1o9IOpCdt2wLfpE || Output_180 != this.__p_SOWQ6XzhJFsOyESZPeZSgQ || State_Output_184 != this.__p_S9ovLip24W4NDIxtbORWr8 || __pin_group_Input_In_OdbXhnD00IdNQY62paTYzX_186 != this.__pin_group_Input_In_OdbXhnD00IdNQY62paTYzX || State_Output_188 != this.__p_OdbXhnD00IdNQY62paTYzX || Output_190 != this.__p_PFy7VK8L0W0QU7tMBGS1uR || State_Output_192 != this.__p_VP2jZdismcJPmArV0EYcpU || Output_333 != this.__p_HKF9qVG4T1lPHPnt5wyo93 || __pin_group_Input_In_MuE2Xk4eqcBM22oIb32War_197 != this.__pin_group_Input_In_MuE2Xk4eqcBM22oIb32War || State_Output_199 != this.__p_MuE2Xk4eqcBM22oIb32War || State_Output_202 != this.__p_FDnKyk7VUYiP1TdcUPqiXI || __pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL_204 != this.__pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL || State_Output_206 != this.__p_R8vq1DF3FPgLR8qvhRvjSL || __pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI_208 != this.__pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI || State_Output_210 != this.__p_CWYW4NkTQxeLwuvt9fnNKI || State_Output_213 != this.__p_N8WAgidoDtILowoa9u0wXn || Output_225 != this.__p_AGYldRxOaffOvgLjEVQa9Y || __pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2_229 != this.__pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2 || Output_236 != this.__p_IISoeXJhwaTPSR0W9XTTU2 || __pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI_242 != this.__pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI || State_Output_245 != this.__p_PIlyGh2nlRJPewsBw9eraI || Output_264 != this.__p_OfTtOPMBdg3OHwnYTj54BI || Output_275 != this.__p_KcP0mVGEEMyMJSIIOz4q6G || __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X_281 != this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X || State_Output_283 != this.__p_K3KQpcOhUioPgSrxkO4C8X || this.__p_ICYDa1ufXCnM07cWMLwy26 != this.__p_ICYDa1ufXCnM07cWMLwy26 || State_Output_302 != this.__p_AWPP9NmBEsSPEZwWyWxim8 || this.__p_DePkTYuokNyLpjnZCSEsLh != this.__p_DePkTYuokNyLpjnZCSEsLh || Output_295 != this.__p_RXYspH49pTUPY59Q5ELaE3 || State_Output_316 != this.__p_IH6pxwZSh1qPYIOjUJVLYx || Output_327 != this.__p_I2X9mE0xUf5MjMshDBZjXM ? new SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe(this)
                {__p_LFGKDhTXHAMMxaYMlzdHdi = Output_55, __p_ERkRanxvitmLzn4m9aC7dO = Output_253, __p_Bfr5HYSsZP7LzIkGCfTtKJ = Output_75, __p_GtE3SRD0l67PPMD3tR7Yk3 = Output_320, __p_DQ0002lcFvpOxWQbfChKsz = this.__p_DQ0002lcFvpOxWQbfChKsz, __p_ST6vfERwyI6LVi6c6j8xqr = Output_331, __p_OnshscpT9JwPOvREOUyCqX = State_Output_89, __p_GGeWWawk2BXQSONZdtWM3Y = Output_93, __p_CfJsgWMgYUPO3wcjLTXna5 = Output_102, __p_EHCd4QZiBmMPridsXQZXnH = State_Output_109, __p_PWUlZefy3hJNdtSJzVHeAm = Output_116, __pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw = __pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw_123, __p_Q6JNBAuu5VeQEyX9fshZGw = State_Output_125, __p_Ufv8dRgeGhHLr5VHF387ue = Output_131, __pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz = __pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz_135, __p_ICy6XyB1hLzLLFrhFJby2G = Output_140, __pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA = __pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA_144, __p_UX5gEDZEBNLMWbHcXmfHl2 = Output_238, __p_G3uepad3fsSOxk4R7P9jNO = State_Output_166, __p_LwQHfdgLmF2OBmSFZop08B = State_Output_172, __pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE = __pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE_175, __p_JSEh1Uk1o9IOpCdt2wLfpE = State_Output_177, __p_SOWQ6XzhJFsOyESZPeZSgQ = Output_180, __p_S9ovLip24W4NDIxtbORWr8 = State_Output_184, __pin_group_Input_In_OdbXhnD00IdNQY62paTYzX = __pin_group_Input_In_OdbXhnD00IdNQY62paTYzX_186, __p_OdbXhnD00IdNQY62paTYzX = State_Output_188, __p_PFy7VK8L0W0QU7tMBGS1uR = Output_190, __p_VP2jZdismcJPmArV0EYcpU = State_Output_192, __p_HKF9qVG4T1lPHPnt5wyo93 = Output_333, __pin_group_Input_In_MuE2Xk4eqcBM22oIb32War = __pin_group_Input_In_MuE2Xk4eqcBM22oIb32War_197, __p_MuE2Xk4eqcBM22oIb32War = State_Output_199, __p_FDnKyk7VUYiP1TdcUPqiXI = State_Output_202, __pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL = __pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL_204, __p_R8vq1DF3FPgLR8qvhRvjSL = State_Output_206, __pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI = __pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI_208, __p_CWYW4NkTQxeLwuvt9fnNKI = State_Output_210, __p_N8WAgidoDtILowoa9u0wXn = State_Output_213, __p_AGYldRxOaffOvgLjEVQa9Y = Output_225, __pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2 = __pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2_229, __p_IISoeXJhwaTPSR0W9XTTU2 = Output_236, __pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI = __pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI_242, __p_PIlyGh2nlRJPewsBw9eraI = State_Output_245, __p_OfTtOPMBdg3OHwnYTj54BI = Output_264, __p_KcP0mVGEEMyMJSIIOz4q6G = Output_275, __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X_281, __p_K3KQpcOhUioPgSrxkO4C8X = State_Output_283, __p_ICYDa1ufXCnM07cWMLwy26 = this.__p_ICYDa1ufXCnM07cWMLwy26, __p_AWPP9NmBEsSPEZwWyWxim8 = State_Output_302, __p_DePkTYuokNyLpjnZCSEsLh = this.__p_DePkTYuokNyLpjnZCSEsLh, __p_RXYspH49pTUPY59Q5ELaE3 = Output_295, __p_IH6pxwZSh1qPYIOjUJVLYx = State_Output_316, __p_I2X9mE0xUf5MjMshDBZjXM = Output_327} : that_334;
            else
            {
                this.__p_LFGKDhTXHAMMxaYMlzdHdi = Output_55;
                this.__p_ERkRanxvitmLzn4m9aC7dO = Output_253;
                this.__p_Bfr5HYSsZP7LzIkGCfTtKJ = Output_75;
                this.__p_GtE3SRD0l67PPMD3tR7Yk3 = Output_320;
                this.__p_DQ0002lcFvpOxWQbfChKsz = this.__p_DQ0002lcFvpOxWQbfChKsz;
                this.__p_ST6vfERwyI6LVi6c6j8xqr = Output_331;
                this.__p_OnshscpT9JwPOvREOUyCqX = State_Output_89;
                this.__p_GGeWWawk2BXQSONZdtWM3Y = Output_93;
                this.__p_CfJsgWMgYUPO3wcjLTXna5 = Output_102;
                this.__p_EHCd4QZiBmMPridsXQZXnH = State_Output_109;
                this.__p_PWUlZefy3hJNdtSJzVHeAm = Output_116;
                this.__pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw = __pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw_123;
                this.__p_Q6JNBAuu5VeQEyX9fshZGw = State_Output_125;
                this.__p_Ufv8dRgeGhHLr5VHF387ue = Output_131;
                this.__pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz = __pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz_135;
                this.__p_ICy6XyB1hLzLLFrhFJby2G = Output_140;
                this.__pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA = __pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA_144;
                this.__p_UX5gEDZEBNLMWbHcXmfHl2 = Output_238;
                this.__p_G3uepad3fsSOxk4R7P9jNO = State_Output_166;
                this.__p_LwQHfdgLmF2OBmSFZop08B = State_Output_172;
                this.__pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE = __pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE_175;
                this.__p_JSEh1Uk1o9IOpCdt2wLfpE = State_Output_177;
                this.__p_SOWQ6XzhJFsOyESZPeZSgQ = Output_180;
                this.__p_S9ovLip24W4NDIxtbORWr8 = State_Output_184;
                this.__pin_group_Input_In_OdbXhnD00IdNQY62paTYzX = __pin_group_Input_In_OdbXhnD00IdNQY62paTYzX_186;
                this.__p_OdbXhnD00IdNQY62paTYzX = State_Output_188;
                this.__p_PFy7VK8L0W0QU7tMBGS1uR = Output_190;
                this.__p_VP2jZdismcJPmArV0EYcpU = State_Output_192;
                this.__p_HKF9qVG4T1lPHPnt5wyo93 = Output_333;
                this.__pin_group_Input_In_MuE2Xk4eqcBM22oIb32War = __pin_group_Input_In_MuE2Xk4eqcBM22oIb32War_197;
                this.__p_MuE2Xk4eqcBM22oIb32War = State_Output_199;
                this.__p_FDnKyk7VUYiP1TdcUPqiXI = State_Output_202;
                this.__pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL = __pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL_204;
                this.__p_R8vq1DF3FPgLR8qvhRvjSL = State_Output_206;
                this.__pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI = __pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI_208;
                this.__p_CWYW4NkTQxeLwuvt9fnNKI = State_Output_210;
                this.__p_N8WAgidoDtILowoa9u0wXn = State_Output_213;
                this.__p_AGYldRxOaffOvgLjEVQa9Y = Output_225;
                this.__pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2 = __pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2_229;
                this.__p_IISoeXJhwaTPSR0W9XTTU2 = Output_236;
                this.__pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI = __pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI_242;
                this.__p_PIlyGh2nlRJPewsBw9eraI = State_Output_245;
                this.__p_OfTtOPMBdg3OHwnYTj54BI = Output_264;
                this.__p_KcP0mVGEEMyMJSIIOz4q6G = Output_275;
                this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X_281;
                this.__p_K3KQpcOhUioPgSrxkO4C8X = State_Output_283;
                this.__p_ICYDa1ufXCnM07cWMLwy26 = this.__p_ICYDa1ufXCnM07cWMLwy26;
                this.__p_AWPP9NmBEsSPEZwWyWxim8 = State_Output_302;
                this.__p_DePkTYuokNyLpjnZCSEsLh = this.__p_DePkTYuokNyLpjnZCSEsLh;
                this.__p_RXYspH49pTUPY59Q5ELaE3 = Output_295;
                this.__p_IH6pxwZSh1qPYIOjUJVLYx = State_Output_316;
                this.__p_I2X9mE0xUf5MjMshDBZjXM = Output_327;
            }

            return that_334;
        }

        public n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe __Create__(n1.NodeContext Node_Context)
        {
            n35.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "IH6pxwZSh1qPYIOjUJVLYx", 314427U);
            n3.RectangleF Bounds_1 = __c_GNx6dLQT3hgPLq0SpZyCh1;
            bool Bound_to_Document_2 = false;
            bool Dialog_If_Document_Changed_3 = false;
            bool Save_Bounds_4 = true;
            n36.PixelFormat Back_Buffer_Format_5 = n1.CompilationHelper.Deserialize<n36.PixelFormat>("R8G8B8A8_UNorm_SRgb", false, null, null);
            n36.PixelFormat Depth_Buffer_Format_6 = n1.CompilationHelper.Deserialize<n36.PixelFormat>("D24_UNorm_S8_UInt", false, null, null);
            var Output_7 = n37.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k.Create(Node_Context: Node_Context_0, Bounds_In: Bounds_1, Bound_to_Document_In: Bound_to_Document_2, Dialog_If_Document_Changed_In: Dialog_If_Document_Changed_3, Save_Bounds_In: Save_Bounds_4, Back_Buffer_Format_In: Back_Buffer_Format_5, Depth_Buffer_Format_In: Depth_Buffer_Format_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "K3KQpcOhUioPgSrxkO4C8X", 314442U);
            var Output_9 = n37.RootScene_GcBzJdp7uHFN7DqiDqkHlb.Create(Node_Context: Node_Context_8);
            var node_10 = n1.CompilationHelper.CreateNodeById(Node_Context, "Emissive", "Stride.Materials.ShadingAttributes");
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "GtE3SRD0l67PPMD3tR7Yk3", 314455U);
            var Output_12 = n38.ColorMap_KOxQ1z1ZXvlODfQvuwEtGx.Create(Node_Context: Node_Context_11);
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "OnshscpT9JwPOvREOUyCqX", 314462U);
            var Output_14 = n39.PBRMaterial_Metallic_FiHTnsXENg8Pe4uJCxGwGT.Create(Node_Context: Node_Context_13);
            n1.NodeContext Node_Context_15 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "ST6vfERwyI6LVi6c6j8xqr", 314476U);
            var Output_16 = n38.ValueMap_MSDYzfiuxQTMHIqVDSqrQu.Create(Node_Context: Node_Context_15);
            n1.NodeContext Node_Context_17 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "ERkRanxvitmLzn4m9aC7dO", 314482U);
            var Output_18 = n40.Sphere_C.Create(Node_Context: Node_Context_17);
            n1.NodeContext Node_Context_19 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "AWPP9NmBEsSPEZwWyWxim8", 314493U);
            var Output_20 = n33.PostFX_C.Create(Node_Context: Node_Context_19);
            var node_21 = n1.CompilationHelper.CreateNodeById(Node_Context, "Bloom", "Stride.Rendering.PostFX");
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "Bfr5HYSsZP7LzIkGCfTtKJ", 314516U);
            var Output_23 = n41.FileTexture_VHk2U8mzzVePYWKVz5dr4z.Create(Node_Context: Node_Context_22);
            n1.NodeContext Node_Context_24 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "I2X9mE0xUf5MjMshDBZjXM", 314546U);
            n43.IFrameClock Clock_25 = n42._Operations_.CreateDefault();
            var Output_26 = n44.LFO_F48sA9CC7kzM1Y1LIpWRrD.Create(Node_Context: Node_Context_24, Clock_In: Clock_25);
            n1.NodeContext Node_Context_27 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "LFGKDhTXHAMMxaYMlzdHdi", 314557U);
            n43.IFrameClock Clock_28 = n42._Operations_.CreateDefault();
            var Output_29 = n44.LFO_F48sA9CC7kzM1Y1LIpWRrD.Create(Node_Context: Node_Context_27, Clock_In: Clock_28);
            n1.NodeContext Node_Context_30 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "RXYspH49pTUPY59Q5ELaE3", 314566U);
            n43.IFrameClock Clock_31 = n42._Operations_.CreateDefault();
            var Output_32 = n44.LFO_F48sA9CC7kzM1Y1LIpWRrD.Create(Node_Context: Node_Context_30, Clock_In: Clock_31);
            var Output_33 = n21._Operations_.CreateDefault();
            n1.NodeContext Node_Context_34 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "Ufv8dRgeGhHLr5VHF387ue", 314593U);
            var Output_35 = n22.SphericalImpulse_C.Create(Node_Context: Node_Context_34);
            n1.NodeContext Node_Context_36 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "ICy6XyB1hLzLLFrhFJby2G", 314607U);
            var Output_37 = n22.SphericalImpulses_C.Create(Node_Context: Node_Context_36);
            n1.NodeContext Node_Context_38 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "UX5gEDZEBNLMWbHcXmfHl2", 314618U);
            var Output_39 = n45.Fluid3D_JpxxW5bjXm4NABtE3B6DIu.Create(Node_Context: Node_Context_38);
            n1.NodeContext Node_Context_40 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "LwQHfdgLmF2OBmSFZop08B", 314656U);
            var Output_41 = n46.IntegrateVelocityAndPosition_C.Create(Node_Context: Node_Context_40);
            n1.NodeContext Node_Context_42 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "SOWQ6XzhJFsOyESZPeZSgQ", 314659U);
            var Output_43 = n15.ComputeStage_C.Create(Node_Context: Node_Context_42);
            n1.NodeContext Node_Context_44 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "Q6JNBAuu5VeQEyX9fshZGw", 314670U);
            var Output_45 = n47.ProbabilityEmitter_AES99Kg9CLFOmrKjo7Tiub.Create(Node_Context: Node_Context_44);
            n1.NodeContext Node_Context_46 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "JSEh1Uk1o9IOpCdt2wLfpE", 314681U);
            var Output_47 = n48.Group_GpuVoid_PRMY4HYRXTzM4hzmICywZJ.Create(Node_Context: Node_Context_46);
            n1.NodeContext Node_Context_48 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "IISoeXJhwaTPSR0W9XTTU2", 314687U);
            var Output_49 = n15.ComputeSystem_Spectral_C.Create(Node_Context: Node_Context_48);
            n1.NodeContext Node_Context_50 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "EHCd4QZiBmMPridsXQZXnH", 314699U);
            var Output_51 = n49.SphereRandom_Compute_RSopXV2deoBP83q16kHJw9.Create(Node_Context: Node_Context_50);
            n1.NodeContext Node_Context_52 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "PWUlZefy3hJNdtSJzVHeAm", 314707U);
            var Output_53 = n49.Random_C<float>.Create(Node_Context: Node_Context_52);
            n1.NodeContext Node_Context_54 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "GGeWWawk2BXQSONZdtWM3Y", 314715U);
            var Output_55 = n15.BufferResourceHandler_C.Create(Node_Context: Node_Context_54);
            n1.NodeContext Node_Context_56 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "CfJsgWMgYUPO3wcjLTXna5", 314720U);
            var Output_57 = n49.Random_C<n3.Vector3>.Create(Node_Context: Node_Context_56);
            n1.NodeContext Node_Context_58 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "G3uepad3fsSOxk4R7P9jNO", 314729U);
            var Output_59 = n50.Texture3DForceField_AKqxJL5R1MoOVHKT0pi0jQ.Create(Node_Context: Node_Context_58);
            n1.NodeContext Node_Context_60 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "AGYldRxOaffOvgLjEVQa9Y", 314742U);
            var Output_61 = n51.SpriteRenderer_Particle_C.Create(Node_Context: Node_Context_60);
            n1.NodeContext Node_Context_62 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "PFy7VK8L0W0QU7tMBGS1uR", 314755U);
            var Output_63 = n52.Color_Particle_LlPANDKLszZP94y29eyOob.Create(Node_Context: Node_Context_62);
            n1.NodeContext Node_Context_64 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "N8WAgidoDtILowoa9u0wXn", 314757U);
            var Output_65 = n53.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_64);
            n1.NodeContext Node_Context_66 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "S9ovLip24W4NDIxtbORWr8", 314761U);
            var Output_67 = n54.AgeOverLifeTime_L63dVGA8FhRMrtDsWIyrMT.Create(Node_Context: Node_Context_66);
            n1.NodeContext Node_Context_68 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "OdbXhnD00IdNQY62paTYzX", 314764U);
            var Output_69 = n55.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_68);
            n1.NodeContext Node_Context_70 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "CWYW4NkTQxeLwuvt9fnNKI", 314768U);
            var Output_71 = n55.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n3.Vector3>.Create(Node_Context: Node_Context_70);
            n1.NodeContext Node_Context_72 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "MuE2Xk4eqcBM22oIb32War", 314772U);
            var Output_73 = n55.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n3.Vector3>.Create(Node_Context: Node_Context_72);
            n1.NodeContext Node_Context_74 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "HKF9qVG4T1lPHPnt5wyo93", 314776U);
            var Output_75 = n56.GPUInFromFloat_I8BJWfdKlplN7rvcBs80sD<n3.Vector3>.Create(Node_Context: Node_Context_74);
            n1.NodeContext Node_Context_76 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "R8vq1DF3FPgLR8qvhRvjSL", 314780U);
            var Output_77 = n55.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n3.Vector3>.Create(Node_Context: Node_Context_76);
            n1.NodeContext Node_Context_78 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "FDnKyk7VUYiP1TdcUPqiXI", 314784U);
            var Output_79 = n56.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<n3.Vector3>.Create(Node_Context: Node_Context_78);
            n1.NodeContext Node_Context_80 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "VP2jZdismcJPmArV0EYcpU", 314787U);
            var Output_81 = n57.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_80);
            n1.NodeContext Node_Context_82 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "PIlyGh2nlRJPewsBw9eraI", 314791U);
            var Output_83 = n37.Group_TqwCZl6Gra4OmgvUg1POgm.Create(Node_Context: Node_Context_82);
            var node_84 = n1.CompilationHelper.CreateNodeById(Node_Context, "BrightFilter", "Stride.Rendering.PostFX");
            n1.NodeContext Node_Context_85 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "KcP0mVGEEMyMJSIIOz4q6G", 397221U);
            var Output_86 = n58.SkyboxLight_C.Create(Node_Context: Node_Context_85);
            n1.NodeContext Node_Context_87 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "OfTtOPMBdg3OHwnYTj54BI", 398182U);
            var Output_88 = n41.FileTexture_VHk2U8mzzVePYWKVz5dr4z.Create(Node_Context: Node_Context_87);
            n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe that_89 = this;
            this.__pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw = n23._Operations_.CreateDefault<n16.GpuValue<n18.GpuVoid>>();
            this.__pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz = n23._Operations_.CreateDefault<n22.SphericalImpulse_C>();
            this.__pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA = n23._Operations_.CreateDefault<n22.IFluidComponent_I>();
            this.__pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE = n23._Operations_.CreateDefault<n16.GpuValue<n18.GpuVoid>>();
            this.__pin_group_Input_In_OdbXhnD00IdNQY62paTYzX = n23._Operations_.CreateDefault<n16.GpuValue<float>>();
            this.__pin_group_Input_In_MuE2Xk4eqcBM22oIb32War = n23._Operations_.CreateDefault<n16.GpuValue<n3.Vector3>>();
            this.__pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL = n23._Operations_.CreateDefault<n16.GpuValue<n3.Vector3>>();
            this.__pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI = n23._Operations_.CreateDefault<n16.GpuValue<n3.Vector3>>();
            this.__pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2 = n23._Operations_.CreateDefault<n15.IComputeStage_I>();
            this.__pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI = n23._Operations_.CreateDefault<n28.Entity>();
            this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = n23._Operations_.CreateDefault<n28.Entity>();
            this.__p_IH6pxwZSh1qPYIOjUJVLYx = Output_7;
            this.__p_K3KQpcOhUioPgSrxkO4C8X = Output_9;
            this.__p_DQ0002lcFvpOxWQbfChKsz = node_10;
            this.__p_GtE3SRD0l67PPMD3tR7Yk3 = Output_12;
            this.__p_OnshscpT9JwPOvREOUyCqX = Output_14;
            this.__p_ST6vfERwyI6LVi6c6j8xqr = Output_16;
            this.__p_ERkRanxvitmLzn4m9aC7dO = Output_18;
            this.__p_AWPP9NmBEsSPEZwWyWxim8 = Output_20;
            this.__p_DePkTYuokNyLpjnZCSEsLh = node_21;
            this.__p_Bfr5HYSsZP7LzIkGCfTtKJ = Output_23;
            this.__p_I2X9mE0xUf5MjMshDBZjXM = Output_26;
            this.__p_LFGKDhTXHAMMxaYMlzdHdi = Output_29;
            this.__p_RXYspH49pTUPY59Q5ELaE3 = Output_32;
            this.__p_Ufv8dRgeGhHLr5VHF387ue = Output_35;
            this.__p_ICy6XyB1hLzLLFrhFJby2G = Output_37;
            this.__p_UX5gEDZEBNLMWbHcXmfHl2 = Output_39;
            this.__p_LwQHfdgLmF2OBmSFZop08B = Output_41;
            this.__p_SOWQ6XzhJFsOyESZPeZSgQ = Output_43;
            this.__p_Q6JNBAuu5VeQEyX9fshZGw = Output_45;
            this.__p_JSEh1Uk1o9IOpCdt2wLfpE = Output_47;
            this.__p_IISoeXJhwaTPSR0W9XTTU2 = Output_49;
            this.__p_EHCd4QZiBmMPridsXQZXnH = Output_51;
            this.__p_PWUlZefy3hJNdtSJzVHeAm = Output_53;
            this.__p_GGeWWawk2BXQSONZdtWM3Y = Output_55;
            this.__p_CfJsgWMgYUPO3wcjLTXna5 = Output_57;
            this.__p_G3uepad3fsSOxk4R7P9jNO = Output_59;
            this.__p_AGYldRxOaffOvgLjEVQa9Y = Output_61;
            this.__p_PFy7VK8L0W0QU7tMBGS1uR = Output_63;
            this.__p_N8WAgidoDtILowoa9u0wXn = Output_65;
            this.__p_S9ovLip24W4NDIxtbORWr8 = Output_67;
            this.__p_OdbXhnD00IdNQY62paTYzX = Output_69;
            this.__p_CWYW4NkTQxeLwuvt9fnNKI = Output_71;
            this.__p_MuE2Xk4eqcBM22oIb32War = Output_73;
            this.__p_HKF9qVG4T1lPHPnt5wyo93 = Output_75;
            this.__p_R8vq1DF3FPgLR8qvhRvjSL = Output_77;
            this.__p_FDnKyk7VUYiP1TdcUPqiXI = Output_79;
            this.__p_VP2jZdismcJPmArV0EYcpU = Output_81;
            this.__p_PIlyGh2nlRJPewsBw9eraI = Output_83;
            this.__p_ICYDa1ufXCnM07cWMLwy26 = node_84;
            this.__p_KcP0mVGEEMyMJSIIOz4q6G = Output_86;
            this.__p_OfTtOPMBdg3OHwnYTj54BI = Output_88;
            this.__monadBuilder_SQvW9DjumhULceku1CfaO3 = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_PpkB3lWQ8YGNjnomhVcQvr = n16.GpuValueMonadicFactory<n3.Vector3>.Default.GetMonadBuilder(true);
            this.__monadBuilder_FvbQXvSGiDwNMZOK5846cQ = n16.GpuValueMonadicFactory<n3.Vector3>.Default.GetMonadBuilder(true);
            this.__monadBuilder_Hv290cWar54LTWf1KsF725 = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_Uik8KLTSKWHQYCBuRdcHwE = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_NQ4BEMMnc7BMtXZurttGhG = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_DsJlpRsag2mPPtZAwPnuay = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_U5cWl62ykMBMEQYkrVXAfQ = n16.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            this.__monadBuilder_VSmT69vvnssOiUexZCxxzz = n16.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            this.__monadBuilder_AmfCdWhIzArMRoBIflQeCe = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_ROokG4ir22VL4m6cKXIKnH = n16.GpuValueMonadicFactory<n3.Vector3>.Default.GetMonadBuilder(true);
            return that_89;
        }

        public n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe __CreateDefault__()
        {
            n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe that_0 = this;
            this.__pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw = n23._Operations_.CreateDefault<n16.GpuValue<n18.GpuVoid>>();
            this.__pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz = n23._Operations_.CreateDefault<n22.SphericalImpulse_C>();
            this.__pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA = n23._Operations_.CreateDefault<n22.IFluidComponent_I>();
            this.__pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE = n23._Operations_.CreateDefault<n16.GpuValue<n18.GpuVoid>>();
            this.__pin_group_Input_In_OdbXhnD00IdNQY62paTYzX = n23._Operations_.CreateDefault<n16.GpuValue<float>>();
            this.__pin_group_Input_In_MuE2Xk4eqcBM22oIb32War = n23._Operations_.CreateDefault<n16.GpuValue<n3.Vector3>>();
            this.__pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL = n23._Operations_.CreateDefault<n16.GpuValue<n3.Vector3>>();
            this.__pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI = n23._Operations_.CreateDefault<n16.GpuValue<n3.Vector3>>();
            this.__pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2 = n23._Operations_.CreateDefault<n15.IComputeStage_I>();
            this.__pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI = n23._Operations_.CreateDefault<n28.Entity>();
            this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = n23._Operations_.CreateDefault<n28.Entity>();
            this.__p_LFGKDhTXHAMMxaYMlzdHdi = n44.LFO_F48sA9CC7kzM1Y1LIpWRrD.CreateDefault();
            this.__p_ERkRanxvitmLzn4m9aC7dO = n40.Sphere_C.CreateDefault();
            this.__p_Bfr5HYSsZP7LzIkGCfTtKJ = n41.FileTexture_VHk2U8mzzVePYWKVz5dr4z.CreateDefault();
            this.__p_GtE3SRD0l67PPMD3tR7Yk3 = n38.ColorMap_KOxQ1z1ZXvlODfQvuwEtGx.CreateDefault();
            this.__p_DQ0002lcFvpOxWQbfChKsz = default(n1.IVLNode);
            this.__p_ST6vfERwyI6LVi6c6j8xqr = n38.ValueMap_MSDYzfiuxQTMHIqVDSqrQu.CreateDefault();
            this.__p_OnshscpT9JwPOvREOUyCqX = n39.PBRMaterial_Metallic_FiHTnsXENg8Pe4uJCxGwGT.CreateDefault();
            this.__p_GGeWWawk2BXQSONZdtWM3Y = n15.BufferResourceHandler_C.CreateDefault();
            this.__monadBuilder_SQvW9DjumhULceku1CfaO3 = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_PpkB3lWQ8YGNjnomhVcQvr = n16.GpuValueMonadicFactory<n3.Vector3>.Default.GetMonadBuilder(true);
            this.__monadBuilder_FvbQXvSGiDwNMZOK5846cQ = n16.GpuValueMonadicFactory<n3.Vector3>.Default.GetMonadBuilder(true);
            this.__p_CfJsgWMgYUPO3wcjLTXna5 = n49.Random_C<n3.Vector3>.CreateDefault();
            this.__monadBuilder_Hv290cWar54LTWf1KsF725 = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__p_EHCd4QZiBmMPridsXQZXnH = n49.SphereRandom_Compute_RSopXV2deoBP83q16kHJw9.CreateDefault();
            this.__monadBuilder_Uik8KLTSKWHQYCBuRdcHwE = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__monadBuilder_NQ4BEMMnc7BMtXZurttGhG = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__p_PWUlZefy3hJNdtSJzVHeAm = n49.Random_C<float>.CreateDefault();
            this.__p_Q6JNBAuu5VeQEyX9fshZGw = n47.ProbabilityEmitter_AES99Kg9CLFOmrKjo7Tiub.CreateDefault();
            this.__p_Ufv8dRgeGhHLr5VHF387ue = n21._Operations_.CreateDefault();
            this.__p_ICy6XyB1hLzLLFrhFJby2G = n22.SphericalImpulses_C.CreateDefault();
            this.__p_UX5gEDZEBNLMWbHcXmfHl2 = n45.Fluid3D_JpxxW5bjXm4NABtE3B6DIu.CreateDefault();
            this.__monadBuilder_DsJlpRsag2mPPtZAwPnuay = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__p_G3uepad3fsSOxk4R7P9jNO = n50.Texture3DForceField_AKqxJL5R1MoOVHKT0pi0jQ.CreateDefault();
            this.__monadBuilder_U5cWl62ykMBMEQYkrVXAfQ = n16.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            this.__p_LwQHfdgLmF2OBmSFZop08B = n46.IntegrateVelocityAndPosition_C.CreateDefault();
            this.__monadBuilder_VSmT69vvnssOiUexZCxxzz = n16.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            this.__p_JSEh1Uk1o9IOpCdt2wLfpE = n48.Group_GpuVoid_PRMY4HYRXTzM4hzmICywZJ.CreateDefault();
            this.__p_SOWQ6XzhJFsOyESZPeZSgQ = n15.ComputeStage_C.CreateDefault();
            this.__monadBuilder_AmfCdWhIzArMRoBIflQeCe = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__p_S9ovLip24W4NDIxtbORWr8 = n54.AgeOverLifeTime_L63dVGA8FhRMrtDsWIyrMT.CreateDefault();
            this.__p_OdbXhnD00IdNQY62paTYzX = n55.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.CreateDefault();
            this.__p_PFy7VK8L0W0QU7tMBGS1uR = n52.Color_Particle_LlPANDKLszZP94y29eyOob.CreateDefault();
            this.__p_VP2jZdismcJPmArV0EYcpU = n57.xyz_T2WwCF9xAltPhlUuLjVDje.CreateDefault();
            this.__monadBuilder_ROokG4ir22VL4m6cKXIKnH = n16.GpuValueMonadicFactory<n3.Vector3>.Default.GetMonadBuilder(true);
            this.__p_HKF9qVG4T1lPHPnt5wyo93 = n56.GPUInFromFloat_I8BJWfdKlplN7rvcBs80sD<n3.Vector3>.CreateDefault();
            this.__p_MuE2Xk4eqcBM22oIb32War = n55.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n3.Vector3>.CreateDefault();
            this.__p_FDnKyk7VUYiP1TdcUPqiXI = n56.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<n3.Vector3>.CreateDefault();
            this.__p_R8vq1DF3FPgLR8qvhRvjSL = n55.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n3.Vector3>.CreateDefault();
            this.__p_CWYW4NkTQxeLwuvt9fnNKI = n55.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n3.Vector3>.CreateDefault();
            this.__p_N8WAgidoDtILowoa9u0wXn = n53.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.CreateDefault();
            this.__p_AGYldRxOaffOvgLjEVQa9Y = n51.SpriteRenderer_Particle_C.CreateDefault();
            this.__p_IISoeXJhwaTPSR0W9XTTU2 = default(n15.ComputeSystem_Spectral_C);
            this.__p_PIlyGh2nlRJPewsBw9eraI = n37.Group_TqwCZl6Gra4OmgvUg1POgm.CreateDefault();
            this.__p_OfTtOPMBdg3OHwnYTj54BI = n41.FileTexture_VHk2U8mzzVePYWKVz5dr4z.CreateDefault();
            this.__p_KcP0mVGEEMyMJSIIOz4q6G = n58.SkyboxLight_C.CreateDefault();
            this.__p_K3KQpcOhUioPgSrxkO4C8X = n37.RootScene_GcBzJdp7uHFN7DqiDqkHlb.CreateDefault();
            this.__p_ICYDa1ufXCnM07cWMLwy26 = default(n1.IVLNode);
            this.__p_AWPP9NmBEsSPEZwWyWxim8 = n33.PostFX_C.CreateDefault();
            this.__p_DePkTYuokNyLpjnZCSEsLh = default(n1.IVLNode);
            this.__p_RXYspH49pTUPY59Q5ELaE3 = n44.LFO_F48sA9CC7kzM1Y1LIpWRrD.CreateDefault();
            this.__p_IH6pxwZSh1qPYIOjUJVLYx = n37.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k.CreateDefault();
            this.__p_I2X9mE0xUf5MjMshDBZjXM = n44.LFO_F48sA9CC7kzM1Y1LIpWRrD.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_LFGKDhTXHAMMxaYMlzdHdi);
            n1.CompilationHelper.SafeDispose(this.__p_ERkRanxvitmLzn4m9aC7dO);
            n1.CompilationHelper.SafeDispose(this.__p_Bfr5HYSsZP7LzIkGCfTtKJ);
            n1.CompilationHelper.SafeDispose(this.__p_GtE3SRD0l67PPMD3tR7Yk3);
            n1.CompilationHelper.SafeDispose(this.__p_DQ0002lcFvpOxWQbfChKsz);
            n1.CompilationHelper.SafeDispose(this.__p_ST6vfERwyI6LVi6c6j8xqr);
            n1.CompilationHelper.SafeDispose(this.__p_OnshscpT9JwPOvREOUyCqX);
            n1.CompilationHelper.SafeDispose(this.__p_GGeWWawk2BXQSONZdtWM3Y);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_SQvW9DjumhULceku1CfaO3);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_PpkB3lWQ8YGNjnomhVcQvr);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_FvbQXvSGiDwNMZOK5846cQ);
            n1.CompilationHelper.SafeDispose(this.__p_CfJsgWMgYUPO3wcjLTXna5);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_Hv290cWar54LTWf1KsF725);
            n1.CompilationHelper.SafeDispose(this.__p_EHCd4QZiBmMPridsXQZXnH);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_Uik8KLTSKWHQYCBuRdcHwE);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_NQ4BEMMnc7BMtXZurttGhG);
            n1.CompilationHelper.SafeDispose(this.__p_PWUlZefy3hJNdtSJzVHeAm);
            n1.CompilationHelper.SafeDispose(this.__p_Q6JNBAuu5VeQEyX9fshZGw);
            n1.CompilationHelper.SafeDispose(this.__p_Ufv8dRgeGhHLr5VHF387ue);
            n1.CompilationHelper.SafeDispose(this.__p_ICy6XyB1hLzLLFrhFJby2G);
            n1.CompilationHelper.SafeDispose(this.__p_UX5gEDZEBNLMWbHcXmfHl2);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_DsJlpRsag2mPPtZAwPnuay);
            n1.CompilationHelper.SafeDispose(this.__p_G3uepad3fsSOxk4R7P9jNO);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_U5cWl62ykMBMEQYkrVXAfQ);
            n1.CompilationHelper.SafeDispose(this.__p_LwQHfdgLmF2OBmSFZop08B);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_VSmT69vvnssOiUexZCxxzz);
            n1.CompilationHelper.SafeDispose(this.__p_JSEh1Uk1o9IOpCdt2wLfpE);
            n1.CompilationHelper.SafeDispose(this.__p_SOWQ6XzhJFsOyESZPeZSgQ);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_AmfCdWhIzArMRoBIflQeCe);
            n1.CompilationHelper.SafeDispose(this.__p_S9ovLip24W4NDIxtbORWr8);
            n1.CompilationHelper.SafeDispose(this.__p_OdbXhnD00IdNQY62paTYzX);
            n1.CompilationHelper.SafeDispose(this.__p_PFy7VK8L0W0QU7tMBGS1uR);
            n1.CompilationHelper.SafeDispose(this.__p_VP2jZdismcJPmArV0EYcpU);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_ROokG4ir22VL4m6cKXIKnH);
            n1.CompilationHelper.SafeDispose(this.__p_HKF9qVG4T1lPHPnt5wyo93);
            n1.CompilationHelper.SafeDispose(this.__p_MuE2Xk4eqcBM22oIb32War);
            n1.CompilationHelper.SafeDispose(this.__p_FDnKyk7VUYiP1TdcUPqiXI);
            n1.CompilationHelper.SafeDispose(this.__p_R8vq1DF3FPgLR8qvhRvjSL);
            n1.CompilationHelper.SafeDispose(this.__p_CWYW4NkTQxeLwuvt9fnNKI);
            n1.CompilationHelper.SafeDispose(this.__p_N8WAgidoDtILowoa9u0wXn);
            n1.CompilationHelper.SafeDispose(this.__p_AGYldRxOaffOvgLjEVQa9Y);
            n1.CompilationHelper.SafeDispose(this.__p_IISoeXJhwaTPSR0W9XTTU2);
            n1.CompilationHelper.SafeDispose(this.__p_PIlyGh2nlRJPewsBw9eraI);
            n1.CompilationHelper.SafeDispose(this.__p_OfTtOPMBdg3OHwnYTj54BI);
            n1.CompilationHelper.SafeDispose(this.__p_KcP0mVGEEMyMJSIIOz4q6G);
            n1.CompilationHelper.SafeDispose(this.__p_K3KQpcOhUioPgSrxkO4C8X);
            n1.CompilationHelper.SafeDispose(this.__p_ICYDa1ufXCnM07cWMLwy26);
            n1.CompilationHelper.SafeDispose(this.__p_AWPP9NmBEsSPEZwWyWxim8);
            n1.CompilationHelper.SafeDispose(this.__p_DePkTYuokNyLpjnZCSEsLh);
            n1.CompilationHelper.SafeDispose(this.__p_RXYspH49pTUPY59Q5ELaE3);
            n1.CompilationHelper.SafeDispose(this.__p_IH6pxwZSh1qPYIOjUJVLYx);
            n1.CompilationHelper.SafeDispose(this.__p_I2X9mE0xUf5MjMshDBZjXM);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 314461U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "QvfgDEapxguOHsgsbrdfhQ", Name = "__slot_QvfgDEapxguOHsgsbrdfhQ")]
        public static n3.Color4 __slot_QvfgDEapxguOHsgsbrdfhQ = n1.CompilationHelper.Deserialize<n3.Color4>("0.88, 0.5632, 0.088, 1", false, "KYrBT1ndOH9MqXl8wdSpYV", "QvfgDEapxguOHsgsbrdfhQ");
        [n1.ElementAttribute(TracingId = 314531U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "LJj6ofOvFTPQaRa9qlcpP8", Name = "__slot_LJj6ofOvFTPQaRa9qlcpP8")]
        public static n3.Vector3 __slot_LJj6ofOvFTPQaRa9qlcpP8 = n1.CompilationHelper.Deserialize<n3.Vector3>("0, 1, 0", false, "KYrBT1ndOH9MqXl8wdSpYV", "LJj6ofOvFTPQaRa9qlcpP8");
        [n1.ElementAttribute(TracingId = 314542U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "EPUeJfqUMHMQXuL2EKfkRt", Name = "__slot_EPUeJfqUMHMQXuL2EKfkRt")]
        public static float __slot_EPUeJfqUMHMQXuL2EKfkRt = -1F;
        [n1.ElementAttribute(TracingId = 314543U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Dr5eyJso53sNHfmfwIorSU", Name = "__slot_Dr5eyJso53sNHfmfwIorSU")]
        public static float __slot_Dr5eyJso53sNHfmfwIorSU = 1F;
        [n1.ElementAttribute(TracingId = 314544U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "G2SngEuROj3OjpqJ381uPg", Name = "__slot_G2SngEuROj3OjpqJ381uPg")]
        public static float __slot_G2SngEuROj3OjpqJ381uPg = 1.45F;
        [n1.ElementAttribute(TracingId = 314545U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "BfGf5Xs3RVFOZxZABBVsSo", Name = "__slot_BfGf5Xs3RVFOZxZABBVsSo")]
        public static float __slot_BfGf5Xs3RVFOZxZABBVsSo = 1.8F;
        [n1.ElementAttribute(TracingId = 314564U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "MIbLpkqshZzOgbhPCvqbnI", Name = "__slot_MIbLpkqshZzOgbhPCvqbnI")]
        public static float __slot_MIbLpkqshZzOgbhPCvqbnI = 60F;
        [n1.ElementAttribute(TracingId = 314565U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "IGkMiifOOukPySqcXHucq9", Name = "__slot_IGkMiifOOukPySqcXHucq9")]
        public static float __slot_IGkMiifOOukPySqcXHucq9 = 3F;
        [n1.ElementAttribute(TracingId = 314583U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Im0kbKlxiapQJVu62daFTD", Name = "__slot_Im0kbKlxiapQJVu62daFTD")]
        public static float __slot_Im0kbKlxiapQJVu62daFTD = -1F;
        [n1.ElementAttribute(TracingId = 314584U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "IiRyUXU8UOXLLYgfKoAmvi", Name = "__slot_IiRyUXU8UOXLLYgfKoAmvi")]
        public static float __slot_IiRyUXU8UOXLLYgfKoAmvi = 1F;
        [n1.ElementAttribute(TracingId = 314585U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "TwJlA2dszaCPagj5CLaBlJ", Name = "__slot_TwJlA2dszaCPagj5CLaBlJ")]
        public static float __slot_TwJlA2dszaCPagj5CLaBlJ = 2.2F;
        [n1.ElementAttribute(TracingId = 314586U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Gt5u29j3RK6PR8FvXPCAUi", Name = "__slot_Gt5u29j3RK6PR8FvXPCAUi")]
        public static float __slot_Gt5u29j3RK6PR8FvXPCAUi = 2.4F;
        [n1.ElementAttribute(TracingId = 314587U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "GAF7PE77ztCQSKS8FZbD2v", Name = "__slot_GAF7PE77ztCQSKS8FZbD2v")]
        public static float __slot_GAF7PE77ztCQSKS8FZbD2v = 40F;
        [n1.ElementAttribute(TracingId = 314588U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Su9eu5EQnKcNqYZ9i6ylZX", Name = "__slot_Su9eu5EQnKcNqYZ9i6ylZX")]
        public static string __slot_Su9eu5EQnKcNqYZ9i6ylZX = "Sun";
        [n1.ElementAttribute(TracingId = 314589U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "UUnuED7kaLLLKBQdlIfMAO", Name = "__slot_UUnuED7kaLLLKBQdlIfMAO")]
        public static float __slot_UUnuED7kaLLLKBQdlIfMAO = 10F;
        [n1.ElementAttribute(TracingId = 314590U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "ElLKiM9nwQWPrizJxSrshO", Name = "__slot_ElLKiM9nwQWPrizJxSrshO")]
        public static float __slot_ElLKiM9nwQWPrizJxSrshO = 5F;
        [n1.ElementAttribute(TracingId = 314591U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Lx83aOmXbQNPQ9dj7VNSdn", Name = "__slot_Lx83aOmXbQNPQ9dj7VNSdn")]
        public static float __slot_Lx83aOmXbQNPQ9dj7VNSdn = 10F;
        [n1.ElementAttribute(TracingId = 314592U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "EyK4v7BqHIcMYh4uf2z2se", Name = "__slot_EyK4v7BqHIcMYh4uf2z2se")]
        public static n3.Color4 __slot_EyK4v7BqHIcMYh4uf2z2se = n1.CompilationHelper.Deserialize<n3.Color4>("0.96, 0.5183992, 0, 1", false, "KYrBT1ndOH9MqXl8wdSpYV", "EyK4v7BqHIcMYh4uf2z2se");
        [n1.ElementAttribute(TracingId = 314614U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "I4BQIaSNUGTMaARYZncVs2", Name = "__slot_I4BQIaSNUGTMaARYZncVs2")]
        public static bool __slot_I4BQIaSNUGTMaARYZncVs2 = true;
        [n1.ElementAttribute(TracingId = 314615U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "BDT1cjoC45MOvdqXC0DYmg", Name = "__slot_BDT1cjoC45MOvdqXC0DYmg")]
        public static bool __slot_BDT1cjoC45MOvdqXC0DYmg = false;
        [n1.ElementAttribute(TracingId = 314616U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "FrvoWOlIadEL3SsVx8zadB", Name = "__slot_FrvoWOlIadEL3SsVx8zadB")]
        public static bool __slot_FrvoWOlIadEL3SsVx8zadB = true;
        [n1.ElementAttribute(TracingId = 314617U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "M8t1Yzt3VXiNNuZ5cLlpE3", Name = "__slot_M8t1Yzt3VXiNNuZ5cLlpE3")]
        public static bool __slot_M8t1Yzt3VXiNNuZ5cLlpE3 = true;
        [n1.ElementAttribute(TracingId = 314640U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "GN7zRmO26qIOVymEtZdXFT", Name = "__slot_GN7zRmO26qIOVymEtZdXFT")]
        public static bool __slot_GN7zRmO26qIOVymEtZdXFT = false;
        [n1.ElementAttribute(TracingId = 314641U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Cnn9z927rzZNwzXR6m3ljr", Name = "__slot_Cnn9z927rzZNwzXR6m3ljr")]
        public static n3.Vector3 __slot_Cnn9z927rzZNwzXR6m3ljr = n1.CompilationHelper.Deserialize<n3.Vector3>("0, 0, 0", false, "KYrBT1ndOH9MqXl8wdSpYV", "Cnn9z927rzZNwzXR6m3ljr");
        [n1.ElementAttribute(TracingId = 314642U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "AxVbZAlvdqNL5Awjias4aG", Name = "__slot_AxVbZAlvdqNL5Awjias4aG")]
        public static n3.Vector3 __slot_AxVbZAlvdqNL5Awjias4aG = n1.CompilationHelper.Deserialize<n3.Vector3>("15, 15, 15", false, "KYrBT1ndOH9MqXl8wdSpYV", "AxVbZAlvdqNL5Awjias4aG");
        [n1.ElementAttribute(TracingId = 314643U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "QxDMNKsgBveMUETh04R4Rf", Name = "__slot_QxDMNKsgBveMUETh04R4Rf")]
        public static n3.Int3 __slot_QxDMNKsgBveMUETh04R4Rf = n1.CompilationHelper.Deserialize<n3.Int3>("128, 128, 128", false, "KYrBT1ndOH9MqXl8wdSpYV", "QxDMNKsgBveMUETh04R4Rf");
        [n1.ElementAttribute(TracingId = 314644U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "CpTNE6Bw24TMPYZE0hSj1F", Name = "__slot_CpTNE6Bw24TMPYZE0hSj1F")]
        public static float __slot_CpTNE6Bw24TMPYZE0hSj1F = 0.5F;
        [n1.ElementAttribute(TracingId = 314645U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "SUqIiQ6kKyLNnIrvCORVrH", Name = "__slot_SUqIiQ6kKyLNnIrvCORVrH")]
        public static int __slot_SUqIiQ6kKyLNnIrvCORVrH = 1;
        [n1.ElementAttribute(TracingId = 314646U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "JQnsjCJwuc8M5ebI9zH5Av", Name = "__slot_JQnsjCJwuc8M5ebI9zH5Av")]
        public static float __slot_JQnsjCJwuc8M5ebI9zH5Av = 1F;
        [n1.ElementAttribute(TracingId = 314647U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Tuy1tIxzGMVNSHTnurU6vr", Name = "__slot_Tuy1tIxzGMVNSHTnurU6vr")]
        public static float __slot_Tuy1tIxzGMVNSHTnurU6vr = 1F;
        [n1.ElementAttribute(TracingId = 314648U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Jm88CF0iTHyLlwHNnL9CQG", Name = "__slot_Jm88CF0iTHyLlwHNnL9CQG")]
        public static bool __slot_Jm88CF0iTHyLlwHNnL9CQG = false;
        [n1.ElementAttribute(TracingId = 314649U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "AGQ9Syt3RuFQIpr2frULID", Name = "__slot_AGQ9Syt3RuFQIpr2frULID")]
        public static int __slot_AGQ9Syt3RuFQIpr2frULID = 0;
        [n1.ElementAttribute(TracingId = 314650U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "IBdRsPLm565LLBSSTfSnWL", Name = "__slot_IBdRsPLm565LLBSSTfSnWL")]
        public static bool __slot_IBdRsPLm565LLBSSTfSnWL = false;
        [n1.ElementAttribute(TracingId = 314651U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "LHbPOgTIvTIPBRIKw1TRZl", Name = "__slot_LHbPOgTIvTIPBRIKw1TRZl")]
        public static bool __slot_LHbPOgTIvTIPBRIKw1TRZl = true;
        [n1.ElementAttribute(TracingId = 314680U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "GefaxCZlT0BOcRz83bdQOF", Name = "__slot_GefaxCZlT0BOcRz83bdQOF")]
        public static float __slot_GefaxCZlT0BOcRz83bdQOF = 0.0202F;
        [n1.ElementAttribute(TracingId = 314705U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "E6Ym8sBgculP3UFLrNUWi1", Name = "__slot_E6Ym8sBgculP3UFLrNUWi1")]
        public static float __slot_E6Ym8sBgculP3UFLrNUWi1 = 0F;
        [n1.ElementAttribute(TracingId = 314706U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "M0QHaJh4XoQL1SIck8fT8d", Name = "__slot_M0QHaJh4XoQL1SIck8fT8d")]
        public static float __slot_M0QHaJh4XoQL1SIck8fT8d = 7F;
        [n1.ElementAttribute(TracingId = 314714U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "KB4H7X6nsHcPP5V3lSnqAZ", Name = "__slot_KB4H7X6nsHcPP5V3lSnqAZ")]
        public static float __slot_KB4H7X6nsHcPP5V3lSnqAZ = 2.88F;
        [n1.ElementAttribute(TracingId = 314727U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "BMYNXuWezKgPx5VuCBwTYq", Name = "__slot_BMYNXuWezKgPx5VuCBwTYq")]
        public static n3.Vector3 __slot_BMYNXuWezKgPx5VuCBwTYq = n1.CompilationHelper.Deserialize<n3.Vector3>("2.5, 2.5, 2.5", false, "KYrBT1ndOH9MqXl8wdSpYV", "BMYNXuWezKgPx5VuCBwTYq");
        [n1.ElementAttribute(TracingId = 314728U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "CKCwVmMzoIQPFIkTXZUCAx", Name = "__slot_CKCwVmMzoIQPFIkTXZUCAx")]
        public static n3.Vector3 __slot_CKCwVmMzoIQPFIkTXZUCAx = n1.CompilationHelper.Deserialize<n3.Vector3>("-2.5, -2.5, -2.5", false, "KYrBT1ndOH9MqXl8wdSpYV", "CKCwVmMzoIQPFIkTXZUCAx");
        [n1.ElementAttribute(TracingId = 314740U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "QHZ3uzdvXUjLf2UV9c4eIS", Name = "__slot_QHZ3uzdvXUjLf2UV9c4eIS")]
        public static float __slot_QHZ3uzdvXUjLf2UV9c4eIS = 4F;
        [n1.ElementAttribute(TracingId = 314741U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "ItYbQaI1jv7QDycnchM5UI", Name = "__slot_ItYbQaI1jv7QDycnchM5UI")]
        public static bool __slot_ItYbQaI1jv7QDycnchM5UI = false;
        [n1.ElementAttribute(TracingId = 314763U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "P6p4HFdccgEQKncO6DqMoK", Name = "__slot_P6p4HFdccgEQKncO6DqMoK")]
        public static float __slot_P6p4HFdccgEQKncO6DqMoK = 0.014F;
        [n1.ElementAttribute(TracingId = 314779U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "C14EnKTG8cQNrbpYc05JyI", Name = "__slot_C14EnKTG8cQNrbpYc05JyI")]
        public static float __slot_C14EnKTG8cQNrbpYc05JyI = 0.97F;
        [n1.ElementAttribute(TracingId = 314790U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "AR9RQ7xAE10QddTcONSdDo", Name = "__slot_AR9RQ7xAE10QddTcONSdDo")]
        public static bool __slot_AR9RQ7xAE10QddTcONSdDo = true;
        [n1.ElementAttribute(TracingId = 314800U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "SPgCKmAE5gENe2Wt0rl6aQ", Name = "__slot_SPgCKmAE5gENe2Wt0rl6aQ")]
        public static n3.Vector3 __slot_SPgCKmAE5gENe2Wt0rl6aQ = n1.CompilationHelper.Deserialize<n3.Vector3>("0, 0, 0", false, "KYrBT1ndOH9MqXl8wdSpYV", "SPgCKmAE5gENe2Wt0rl6aQ");
        [n1.ElementAttribute(TracingId = 314801U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "AWALTrhZHc7Pv9sN7WpqWM", Name = "__slot_AWALTrhZHc7Pv9sN7WpqWM")]
        public static n3.Vector3 __slot_AWALTrhZHc7Pv9sN7WpqWM = n1.CompilationHelper.Deserialize<n3.Vector3>("1, 0.43, 0", false, "KYrBT1ndOH9MqXl8wdSpYV", "AWALTrhZHc7Pv9sN7WpqWM");
        [n1.ElementAttribute(TracingId = 314807U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "SH92pe7L5jLMlN1BDFClz8", Name = "__slot_SH92pe7L5jLMlN1BDFClz8")]
        public static n3.Vector3 __slot_SH92pe7L5jLMlN1BDFClz8 = n1.CompilationHelper.Deserialize<n3.Vector3>("-2, -2, -1", false, "KYrBT1ndOH9MqXl8wdSpYV", "SH92pe7L5jLMlN1BDFClz8");
        [n1.ElementAttribute(TracingId = 314808U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "OQIQTm7J51rNZdjXyUIKKy", Name = "__slot_OQIQTm7J51rNZdjXyUIKKy")]
        public static n3.Vector3 __slot_OQIQTm7J51rNZdjXyUIKKy = n1.CompilationHelper.Deserialize<n3.Vector3>("2, 2, 1", false, "KYrBT1ndOH9MqXl8wdSpYV", "OQIQTm7J51rNZdjXyUIKKy");
        [n1.ElementAttribute(TracingId = 314557U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "LFGKDhTXHAMMxaYMlzdHdi", Name = "LFO", IsManaged = true, IsAutoGenerated = true)]
        public n44.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_LFGKDhTXHAMMxaYMlzdHdi;
        [n1.ElementAttribute(TracingId = 314482U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "ERkRanxvitmLzn4m9aC7dO", Name = "Sphere", IsManaged = true, IsAutoGenerated = true)]
        public n40.Sphere_C __p_ERkRanxvitmLzn4m9aC7dO;
        [n1.ElementAttribute(TracingId = 314516U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Bfr5HYSsZP7LzIkGCfTtKJ", Name = "FileTexture", IsManaged = true, IsAutoGenerated = true)]
        public n41.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_Bfr5HYSsZP7LzIkGCfTtKJ;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n9.Path __c_UlO3Efn87NJQKsbm4PZlok = n1.CompilationHelper.Deserialize<n9.Path>("..\\..\\..\\..\\Desktop\\2k_sun.jpg", false, "KYrBT1ndOH9MqXl8wdSpYV", "UlO3Efn87NJQKsbm4PZlok");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n10.AlphaFormat __c_VaUJ2yQ5QlcPIyddkiszNb = n1.CompilationHelper.Deserialize<n10.AlphaFormat>("Auto", false, "KYrBT1ndOH9MqXl8wdSpYV", "VaUJ2yQ5QlcPIyddkiszNb");
        [n1.ElementAttribute(TracingId = 314455U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "GtE3SRD0l67PPMD3tR7Yk3", Name = "ColorMap", IsManaged = true, IsAutoGenerated = true)]
        public n38.ColorMap_KOxQ1z1ZXvlODfQvuwEtGx __p_GtE3SRD0l67PPMD3tR7Yk3;
        [n1.ElementAttribute(TracingId = 314449U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "DQ0002lcFvpOxWQbfChKsz", Name = "Emissive", IsManaged = true, IsAutoGenerated = true, NodeName = "Emissive", NodeCategory = "Stride.Materials.ShadingAttributes")]
        public n1.IVLNode __p_DQ0002lcFvpOxWQbfChKsz;
        [n1.ElementAttribute(TracingId = 314476U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "ST6vfERwyI6LVi6c6j8xqr", Name = "ValueMap", IsManaged = true, IsAutoGenerated = true)]
        public n38.ValueMap_MSDYzfiuxQTMHIqVDSqrQu __p_ST6vfERwyI6LVi6c6j8xqr;
        [n1.ElementAttribute(TracingId = 314462U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "OnshscpT9JwPOvREOUyCqX", Name = "PBRMaterial (Metallic)", IsManaged = true, IsAutoGenerated = true)]
        public n39.PBRMaterial_Metallic_FiHTnsXENg8Pe4uJCxGwGT __p_OnshscpT9JwPOvREOUyCqX;
        [n1.ElementAttribute(TracingId = 314715U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "GGeWWawk2BXQSONZdtWM3Y", Name = "BufferResourceHandler", IsManaged = true, IsAutoGenerated = true)]
        public n15.BufferResourceHandler_C __p_GGeWWawk2BXQSONZdtWM3Y;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<float, n16.GpuValue<float>> __monadBuilder_SQvW9DjumhULceku1CfaO3 = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<n3.Vector3, n16.GpuValue<n3.Vector3>> __monadBuilder_PpkB3lWQ8YGNjnomhVcQvr = n16.GpuValueMonadicFactory<n3.Vector3>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<n3.Vector3, n16.GpuValue<n3.Vector3>> __monadBuilder_FvbQXvSGiDwNMZOK5846cQ = n16.GpuValueMonadicFactory<n3.Vector3>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 314720U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "CfJsgWMgYUPO3wcjLTXna5", Name = "Random", IsManaged = true, IsAutoGenerated = true)]
        public n49.Random_C<n3.Vector3> __p_CfJsgWMgYUPO3wcjLTXna5;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<float, n16.GpuValue<float>> __monadBuilder_Hv290cWar54LTWf1KsF725 = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 314699U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "EHCd4QZiBmMPridsXQZXnH", Name = "SphereRandom (Compute)", IsManaged = true, IsAutoGenerated = true)]
        public n49.SphereRandom_Compute_RSopXV2deoBP83q16kHJw9 __p_EHCd4QZiBmMPridsXQZXnH;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<float, n16.GpuValue<float>> __monadBuilder_Uik8KLTSKWHQYCBuRdcHwE = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<float, n16.GpuValue<float>> __monadBuilder_NQ4BEMMnc7BMtXZurttGhG = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 314707U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "PWUlZefy3hJNdtSJzVHeAm", Name = "Random", IsManaged = true, IsAutoGenerated = true)]
        public n49.Random_C<float> __p_PWUlZefy3hJNdtSJzVHeAm;
        [n1.ElementAttribute(TracingId = 314670U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Q6JNBAuu5VeQEyX9fshZGw", Name = "ProbabilityEmitter", IsManaged = true, IsAutoGenerated = true)]
        public n47.ProbabilityEmitter_AES99Kg9CLFOmrKjo7Tiub __p_Q6JNBAuu5VeQEyX9fshZGw;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n19.Spread<n16.GpuValue<n18.GpuVoid>> __pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw = default(n19.Spread<n16.GpuValue<n18.GpuVoid>>);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.Matrix __c_JE9MS0W6yH3Lx1mAhNMx77 = n1.CompilationHelper.Deserialize<n3.Matrix>("1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1", false, "KYrBT1ndOH9MqXl8wdSpYV", "JE9MS0W6yH3Lx1mAhNMx77");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.Vector3 __c_BYR4bPl8XjbMVT79XZp9BI = n1.CompilationHelper.Deserialize<n3.Vector3>("0, 0, 0", false, "KYrBT1ndOH9MqXl8wdSpYV", "BYR4bPl8XjbMVT79XZp9BI");
        [n1.ElementAttribute(TracingId = 314593U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Ufv8dRgeGhHLr5VHF387ue", Name = "SphericalImpulse", IsManaged = true, IsAutoGenerated = true)]
        public n22.SphericalImpulse_C __p_Ufv8dRgeGhHLr5VHF387ue;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n19.Spread<n22.SphericalImpulse_C> __pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz = default(n19.Spread<n22.SphericalImpulse_C>);
        [n1.ElementAttribute(TracingId = 314607U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "ICy6XyB1hLzLLFrhFJby2G", Name = "SphericalImpulses", IsManaged = true, IsAutoGenerated = true)]
        public n22.SphericalImpulses_C __p_ICy6XyB1hLzLLFrhFJby2G;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n19.Spread<n22.IFluidComponent_I> __pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA = default(n19.Spread<n22.IFluidComponent_I>);
        [n1.ElementAttribute(TracingId = 314618U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "UX5gEDZEBNLMWbHcXmfHl2", Name = "Fluid3D", IsManaged = true, IsAutoGenerated = true)]
        public n45.Fluid3D_JpxxW5bjXm4NABtE3B6DIu __p_UX5gEDZEBNLMWbHcXmfHl2;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<float, n16.GpuValue<float>> __monadBuilder_DsJlpRsag2mPPtZAwPnuay = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 314729U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "G3uepad3fsSOxk4R7P9jNO", Name = "Texture3DForceField", IsManaged = true, IsAutoGenerated = true)]
        public n50.Texture3DForceField_AKqxJL5R1MoOVHKT0pi0jQ __p_G3uepad3fsSOxk4R7P9jNO;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<bool, n16.GpuValue<bool>> __monadBuilder_U5cWl62ykMBMEQYkrVXAfQ = n16.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 314656U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "LwQHfdgLmF2OBmSFZop08B", Name = "IntegrateVelocityAndPosition", IsManaged = true, IsAutoGenerated = true)]
        public n46.IntegrateVelocityAndPosition_C __p_LwQHfdgLmF2OBmSFZop08B;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<bool, n16.GpuValue<bool>> __monadBuilder_VSmT69vvnssOiUexZCxxzz = n16.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 314681U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "JSEh1Uk1o9IOpCdt2wLfpE", Name = "Group (GpuVoid)", IsManaged = true, IsAutoGenerated = true)]
        public n48.Group_GpuVoid_PRMY4HYRXTzM4hzmICywZJ __p_JSEh1Uk1o9IOpCdt2wLfpE;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n19.Spread<n16.GpuValue<n18.GpuVoid>> __pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE = default(n19.Spread<n16.GpuValue<n18.GpuVoid>>);
        [n1.ElementAttribute(TracingId = 314659U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "SOWQ6XzhJFsOyESZPeZSgQ", Name = "ComputeStage", IsManaged = true, IsAutoGenerated = true)]
        public n15.ComputeStage_C __p_SOWQ6XzhJFsOyESZPeZSgQ;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<float, n16.GpuValue<float>> __monadBuilder_AmfCdWhIzArMRoBIflQeCe = n16.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 314761U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "S9ovLip24W4NDIxtbORWr8", Name = "AgeOverLifeTime", IsManaged = true, IsAutoGenerated = true)]
        public n54.AgeOverLifeTime_L63dVGA8FhRMrtDsWIyrMT __p_S9ovLip24W4NDIxtbORWr8;
        [n1.ElementAttribute(TracingId = 314764U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "OdbXhnD00IdNQY62paTYzX", Name = "*", IsManaged = true, IsAutoGenerated = true)]
        public n55.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_OdbXhnD00IdNQY62paTYzX;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n19.Spread<n16.GpuValue<float>> __pin_group_Input_In_OdbXhnD00IdNQY62paTYzX = default(n19.Spread<n16.GpuValue<float>>);
        [n1.ElementAttribute(TracingId = 314755U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "PFy7VK8L0W0QU7tMBGS1uR", Name = "Color (Particle)", IsManaged = true, IsAutoGenerated = true)]
        public n52.Color_Particle_LlPANDKLszZP94y29eyOob __p_PFy7VK8L0W0QU7tMBGS1uR;
        [n1.ElementAttribute(TracingId = 314787U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "VP2jZdismcJPmArV0EYcpU", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
        public n57.xyz_T2WwCF9xAltPhlUuLjVDje __p_VP2jZdismcJPmArV0EYcpU;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<n3.Vector3, n16.GpuValue<n3.Vector3>> __monadBuilder_ROokG4ir22VL4m6cKXIKnH = n16.GpuValueMonadicFactory<n3.Vector3>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 314776U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "HKF9qVG4T1lPHPnt5wyo93", Name = "GPUInFromFloat", IsManaged = true, IsAutoGenerated = true)]
        public n56.GPUInFromFloat_I8BJWfdKlplN7rvcBs80sD<n3.Vector3> __p_HKF9qVG4T1lPHPnt5wyo93;
        [n1.ElementAttribute(TracingId = 314772U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "MuE2Xk4eqcBM22oIb32War", Name = "*", IsManaged = true, IsAutoGenerated = true)]
        public n55.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n3.Vector3> __p_MuE2Xk4eqcBM22oIb32War;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n19.Spread<n16.GpuValue<n3.Vector3>> __pin_group_Input_In_MuE2Xk4eqcBM22oIb32War = default(n19.Spread<n16.GpuValue<n3.Vector3>>);
        [n1.ElementAttribute(TracingId = 314784U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "FDnKyk7VUYiP1TdcUPqiXI", Name = "ConstantFromFloat", IsManaged = true, IsAutoGenerated = true)]
        public n56.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<n3.Vector3> __p_FDnKyk7VUYiP1TdcUPqiXI;
        [n1.ElementAttribute(TracingId = 314780U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "R8vq1DF3FPgLR8qvhRvjSL", Name = "+", IsManaged = true, IsAutoGenerated = true)]
        public n55.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n3.Vector3> __p_R8vq1DF3FPgLR8qvhRvjSL;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n19.Spread<n16.GpuValue<n3.Vector3>> __pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL = default(n19.Spread<n16.GpuValue<n3.Vector3>>);
        [n1.ElementAttribute(TracingId = 314768U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "CWYW4NkTQxeLwuvt9fnNKI", Name = "*", IsManaged = true, IsAutoGenerated = true)]
        public n55.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n3.Vector3> __p_CWYW4NkTQxeLwuvt9fnNKI;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n19.Spread<n16.GpuValue<n3.Vector3>> __pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI = default(n19.Spread<n16.GpuValue<n3.Vector3>>);
        [n1.ElementAttribute(TracingId = 314757U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "N8WAgidoDtILowoa9u0wXn", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
        public n53.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_N8WAgidoDtILowoa9u0wXn;
        [n1.ElementAttribute(TracingId = 314742U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "AGYldRxOaffOvgLjEVQa9Y", Name = "SpriteRenderer (Particle)", IsManaged = true, IsAutoGenerated = true)]
        public n51.SpriteRenderer_Particle_C __p_AGYldRxOaffOvgLjEVQa9Y;
        [n1.ElementAttribute(TracingId = 314687U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "IISoeXJhwaTPSR0W9XTTU2", Name = "ComputeSystem (Spectral)", IsManaged = true, IsAutoGenerated = true)]
        public n15.ComputeSystem_Spectral_C __p_IISoeXJhwaTPSR0W9XTTU2;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n19.Spread<n15.IUpdateGraph_I> __c_PYnws25s2pNP9iE9pskkXz = n1.CompilationHelper.Deserialize<n19.Spread<n15.IUpdateGraph_I>>("<Value xmlns=\"property\" />", true, "KYrBT1ndOH9MqXl8wdSpYV", "PYnws25s2pNP9iE9pskkXz");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n19.Spread<n15.IComputeStage_I> __pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2 = default(n19.Spread<n15.IComputeStage_I>);
        [n1.ElementAttribute(TracingId = 314791U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "PIlyGh2nlRJPewsBw9eraI", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n37.Group_TqwCZl6Gra4OmgvUg1POgm __p_PIlyGh2nlRJPewsBw9eraI;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n19.Spread<n28.Entity> __pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI = default(n19.Spread<n28.Entity>);
        [n1.ElementAttribute(TracingId = 398182U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "OfTtOPMBdg3OHwnYTj54BI", Name = "FileTexture", IsManaged = true, IsAutoGenerated = true)]
        public n41.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_OfTtOPMBdg3OHwnYTj54BI;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n9.Path __c_T7ja0sZUaiuMa0pDwNGc2k = n1.CompilationHelper.Deserialize<n9.Path>("..\\..\\..\\..\\Desktop\\Skybox.webp", false, "KYrBT1ndOH9MqXl8wdSpYV", "T7ja0sZUaiuMa0pDwNGc2k");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n10.AlphaFormat __c_Pg0LAhaGh1bMIV7y55Yo71 = n1.CompilationHelper.Deserialize<n10.AlphaFormat>("Auto", false, "KYrBT1ndOH9MqXl8wdSpYV", "Pg0LAhaGh1bMIV7y55Yo71");
        [n1.ElementAttribute(TracingId = 397221U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "KcP0mVGEEMyMJSIIOz4q6G", Name = "SkyboxLight", IsManaged = true, IsAutoGenerated = true)]
        public n58.SkyboxLight_C __p_KcP0mVGEEMyMJSIIOz4q6G;
        [n1.ElementAttribute(TracingId = 314442U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "K3KQpcOhUioPgSrxkO4C8X", Name = "RootScene", IsManaged = true, IsAutoGenerated = true)]
        public n37.RootScene_GcBzJdp7uHFN7DqiDqkHlb __p_K3KQpcOhUioPgSrxkO4C8X;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n19.Spread<n28.Entity> __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = default(n19.Spread<n28.Entity>);
        [n1.ElementAttribute(TracingId = 314809U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "ICYDa1ufXCnM07cWMLwy26", Name = "BrightFilter", IsManaged = true, IsAutoGenerated = true, NodeName = "BrightFilter", NodeCategory = "Stride.Rendering.PostFX")]
        public n1.IVLNode __p_ICYDa1ufXCnM07cWMLwy26;
        [n1.ElementAttribute(TracingId = 314493U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "AWPP9NmBEsSPEZwWyWxim8", Name = "PostFX", IsManaged = true, IsAutoGenerated = true)]
        public n33.PostFX_C __p_AWPP9NmBEsSPEZwWyWxim8;
        [n1.ElementAttribute(TracingId = 314507U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "DePkTYuokNyLpjnZCSEsLh", Name = "Bloom", IsManaged = true, IsAutoGenerated = true, NodeName = "Bloom", NodeCategory = "Stride.Rendering.PostFX")]
        public n1.IVLNode __p_DePkTYuokNyLpjnZCSEsLh;
        [n1.ElementAttribute(TracingId = 314566U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "RXYspH49pTUPY59Q5ELaE3", Name = "LFO", IsManaged = true, IsAutoGenerated = true)]
        public n44.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_RXYspH49pTUPY59Q5ELaE3;
        [n1.ElementAttribute(TracingId = 314427U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "IH6pxwZSh1qPYIOjUJVLYx", Name = "SceneWindow", IsManaged = true, IsAutoGenerated = true)]
        public n37.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k __p_IH6pxwZSh1qPYIOjUJVLYx;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.Color4 __c_JEl7pDETGAvNkXUCGrl3dv = n1.CompilationHelper.Deserialize<n3.Color4>("0.09529408, 0.09529408, 0.09529408, 1", false, "KYrBT1ndOH9MqXl8wdSpYV", "JEl7pDETGAvNkXUCGrl3dv");
        [n1.ElementAttribute(TracingId = 314546U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "I2X9mE0xUf5MjMshDBZjXM", Name = "LFO", IsManaged = true, IsAutoGenerated = true)]
        public n44.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_I2X9mE0xUf5MjMshDBZjXM;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.RectangleF __c_GNx6dLQT3hgPLq0SpZyCh1 = n1.CompilationHelper.Deserialize<n3.RectangleF>("1920, 23, 1920, 1057", false, "KYrBT1ndOH9MqXl8wdSpYV", "GNx6dLQT3hgPLq0SpZyCh1");
        static SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe()
        {
        }

        public SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe(SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe other): base(other)
        {
            this.__p_LFGKDhTXHAMMxaYMlzdHdi = other.__p_LFGKDhTXHAMMxaYMlzdHdi;
            this.__p_ERkRanxvitmLzn4m9aC7dO = other.__p_ERkRanxvitmLzn4m9aC7dO;
            this.__p_Bfr5HYSsZP7LzIkGCfTtKJ = other.__p_Bfr5HYSsZP7LzIkGCfTtKJ;
            this.__p_GtE3SRD0l67PPMD3tR7Yk3 = other.__p_GtE3SRD0l67PPMD3tR7Yk3;
            this.__p_DQ0002lcFvpOxWQbfChKsz = other.__p_DQ0002lcFvpOxWQbfChKsz;
            this.__p_ST6vfERwyI6LVi6c6j8xqr = other.__p_ST6vfERwyI6LVi6c6j8xqr;
            this.__p_OnshscpT9JwPOvREOUyCqX = other.__p_OnshscpT9JwPOvREOUyCqX;
            this.__p_GGeWWawk2BXQSONZdtWM3Y = other.__p_GGeWWawk2BXQSONZdtWM3Y;
            this.__monadBuilder_SQvW9DjumhULceku1CfaO3 = other.__monadBuilder_SQvW9DjumhULceku1CfaO3;
            this.__monadBuilder_PpkB3lWQ8YGNjnomhVcQvr = other.__monadBuilder_PpkB3lWQ8YGNjnomhVcQvr;
            this.__monadBuilder_FvbQXvSGiDwNMZOK5846cQ = other.__monadBuilder_FvbQXvSGiDwNMZOK5846cQ;
            this.__p_CfJsgWMgYUPO3wcjLTXna5 = other.__p_CfJsgWMgYUPO3wcjLTXna5;
            this.__monadBuilder_Hv290cWar54LTWf1KsF725 = other.__monadBuilder_Hv290cWar54LTWf1KsF725;
            this.__p_EHCd4QZiBmMPridsXQZXnH = other.__p_EHCd4QZiBmMPridsXQZXnH;
            this.__monadBuilder_Uik8KLTSKWHQYCBuRdcHwE = other.__monadBuilder_Uik8KLTSKWHQYCBuRdcHwE;
            this.__monadBuilder_NQ4BEMMnc7BMtXZurttGhG = other.__monadBuilder_NQ4BEMMnc7BMtXZurttGhG;
            this.__p_PWUlZefy3hJNdtSJzVHeAm = other.__p_PWUlZefy3hJNdtSJzVHeAm;
            this.__p_Q6JNBAuu5VeQEyX9fshZGw = other.__p_Q6JNBAuu5VeQEyX9fshZGw;
            this.__pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw = other.__pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw;
            this.__p_Ufv8dRgeGhHLr5VHF387ue = other.__p_Ufv8dRgeGhHLr5VHF387ue;
            this.__pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz = other.__pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz;
            this.__p_ICy6XyB1hLzLLFrhFJby2G = other.__p_ICy6XyB1hLzLLFrhFJby2G;
            this.__pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA = other.__pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA;
            this.__p_UX5gEDZEBNLMWbHcXmfHl2 = other.__p_UX5gEDZEBNLMWbHcXmfHl2;
            this.__monadBuilder_DsJlpRsag2mPPtZAwPnuay = other.__monadBuilder_DsJlpRsag2mPPtZAwPnuay;
            this.__p_G3uepad3fsSOxk4R7P9jNO = other.__p_G3uepad3fsSOxk4R7P9jNO;
            this.__monadBuilder_U5cWl62ykMBMEQYkrVXAfQ = other.__monadBuilder_U5cWl62ykMBMEQYkrVXAfQ;
            this.__p_LwQHfdgLmF2OBmSFZop08B = other.__p_LwQHfdgLmF2OBmSFZop08B;
            this.__monadBuilder_VSmT69vvnssOiUexZCxxzz = other.__monadBuilder_VSmT69vvnssOiUexZCxxzz;
            this.__p_JSEh1Uk1o9IOpCdt2wLfpE = other.__p_JSEh1Uk1o9IOpCdt2wLfpE;
            this.__pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE = other.__pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE;
            this.__p_SOWQ6XzhJFsOyESZPeZSgQ = other.__p_SOWQ6XzhJFsOyESZPeZSgQ;
            this.__monadBuilder_AmfCdWhIzArMRoBIflQeCe = other.__monadBuilder_AmfCdWhIzArMRoBIflQeCe;
            this.__p_S9ovLip24W4NDIxtbORWr8 = other.__p_S9ovLip24W4NDIxtbORWr8;
            this.__p_OdbXhnD00IdNQY62paTYzX = other.__p_OdbXhnD00IdNQY62paTYzX;
            this.__pin_group_Input_In_OdbXhnD00IdNQY62paTYzX = other.__pin_group_Input_In_OdbXhnD00IdNQY62paTYzX;
            this.__p_PFy7VK8L0W0QU7tMBGS1uR = other.__p_PFy7VK8L0W0QU7tMBGS1uR;
            this.__p_VP2jZdismcJPmArV0EYcpU = other.__p_VP2jZdismcJPmArV0EYcpU;
            this.__monadBuilder_ROokG4ir22VL4m6cKXIKnH = other.__monadBuilder_ROokG4ir22VL4m6cKXIKnH;
            this.__p_HKF9qVG4T1lPHPnt5wyo93 = other.__p_HKF9qVG4T1lPHPnt5wyo93;
            this.__p_MuE2Xk4eqcBM22oIb32War = other.__p_MuE2Xk4eqcBM22oIb32War;
            this.__pin_group_Input_In_MuE2Xk4eqcBM22oIb32War = other.__pin_group_Input_In_MuE2Xk4eqcBM22oIb32War;
            this.__p_FDnKyk7VUYiP1TdcUPqiXI = other.__p_FDnKyk7VUYiP1TdcUPqiXI;
            this.__p_R8vq1DF3FPgLR8qvhRvjSL = other.__p_R8vq1DF3FPgLR8qvhRvjSL;
            this.__pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL = other.__pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL;
            this.__p_CWYW4NkTQxeLwuvt9fnNKI = other.__p_CWYW4NkTQxeLwuvt9fnNKI;
            this.__pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI = other.__pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI;
            this.__p_N8WAgidoDtILowoa9u0wXn = other.__p_N8WAgidoDtILowoa9u0wXn;
            this.__p_AGYldRxOaffOvgLjEVQa9Y = other.__p_AGYldRxOaffOvgLjEVQa9Y;
            this.__p_IISoeXJhwaTPSR0W9XTTU2 = other.__p_IISoeXJhwaTPSR0W9XTTU2;
            this.__pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2 = other.__pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2;
            this.__p_PIlyGh2nlRJPewsBw9eraI = other.__p_PIlyGh2nlRJPewsBw9eraI;
            this.__pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI = other.__pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI;
            this.__p_OfTtOPMBdg3OHwnYTj54BI = other.__p_OfTtOPMBdg3OHwnYTj54BI;
            this.__p_KcP0mVGEEMyMJSIIOz4q6G = other.__p_KcP0mVGEEMyMJSIIOz4q6G;
            this.__p_K3KQpcOhUioPgSrxkO4C8X = other.__p_K3KQpcOhUioPgSrxkO4C8X;
            this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = other.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X;
            this.__p_ICYDa1ufXCnM07cWMLwy26 = other.__p_ICYDa1ufXCnM07cWMLwy26;
            this.__p_AWPP9NmBEsSPEZwWyWxim8 = other.__p_AWPP9NmBEsSPEZwWyWxim8;
            this.__p_DePkTYuokNyLpjnZCSEsLh = other.__p_DePkTYuokNyLpjnZCSEsLh;
            this.__p_RXYspH49pTUPY59Q5ELaE3 = other.__p_RXYspH49pTUPY59Q5ELaE3;
            this.__p_IH6pxwZSh1qPYIOjUJVLYx = other.__p_IH6pxwZSh1qPYIOjUJVLYx;
            this.__p_I2X9mE0xUf5MjMshDBZjXM = other.__p_I2X9mE0xUf5MjMshDBZjXM;
        }

        protected override n1.IVLObject __With__(n25.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LFGKDhTXHAMMxaYMlzdHdi", in __p_LFGKDhTXHAMMxaYMlzdHdi), n1.CompilationHelper.GetValueOrExisting(values, "__p_ERkRanxvitmLzn4m9aC7dO", in __p_ERkRanxvitmLzn4m9aC7dO), n1.CompilationHelper.GetValueOrExisting(values, "__p_Bfr5HYSsZP7LzIkGCfTtKJ", in __p_Bfr5HYSsZP7LzIkGCfTtKJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_GtE3SRD0l67PPMD3tR7Yk3", in __p_GtE3SRD0l67PPMD3tR7Yk3), n1.CompilationHelper.GetValueOrExisting(values, "__p_DQ0002lcFvpOxWQbfChKsz", in __p_DQ0002lcFvpOxWQbfChKsz), n1.CompilationHelper.GetValueOrExisting(values, "__p_ST6vfERwyI6LVi6c6j8xqr", in __p_ST6vfERwyI6LVi6c6j8xqr), n1.CompilationHelper.GetValueOrExisting(values, "__p_OnshscpT9JwPOvREOUyCqX", in __p_OnshscpT9JwPOvREOUyCqX), n1.CompilationHelper.GetValueOrExisting(values, "__p_GGeWWawk2BXQSONZdtWM3Y", in __p_GGeWWawk2BXQSONZdtWM3Y), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_SQvW9DjumhULceku1CfaO3", in __monadBuilder_SQvW9DjumhULceku1CfaO3), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_PpkB3lWQ8YGNjnomhVcQvr", in __monadBuilder_PpkB3lWQ8YGNjnomhVcQvr), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_FvbQXvSGiDwNMZOK5846cQ", in __monadBuilder_FvbQXvSGiDwNMZOK5846cQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_CfJsgWMgYUPO3wcjLTXna5", in __p_CfJsgWMgYUPO3wcjLTXna5), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_Hv290cWar54LTWf1KsF725", in __monadBuilder_Hv290cWar54LTWf1KsF725), n1.CompilationHelper.GetValueOrExisting(values, "__p_EHCd4QZiBmMPridsXQZXnH", in __p_EHCd4QZiBmMPridsXQZXnH), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_Uik8KLTSKWHQYCBuRdcHwE", in __monadBuilder_Uik8KLTSKWHQYCBuRdcHwE), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_NQ4BEMMnc7BMtXZurttGhG", in __monadBuilder_NQ4BEMMnc7BMtXZurttGhG), n1.CompilationHelper.GetValueOrExisting(values, "__p_PWUlZefy3hJNdtSJzVHeAm", in __p_PWUlZefy3hJNdtSJzVHeAm), n1.CompilationHelper.GetValueOrExisting(values, "__p_Q6JNBAuu5VeQEyX9fshZGw", in __p_Q6JNBAuu5VeQEyX9fshZGw), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw", in __pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ufv8dRgeGhHLr5VHF387ue", in __p_Ufv8dRgeGhHLr5VHF387ue), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz", in __pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz), n1.CompilationHelper.GetValueOrExisting(values, "__p_ICy6XyB1hLzLLFrhFJby2G", in __p_ICy6XyB1hLzLLFrhFJby2G), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA", in __pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA), n1.CompilationHelper.GetValueOrExisting(values, "__p_UX5gEDZEBNLMWbHcXmfHl2", in __p_UX5gEDZEBNLMWbHcXmfHl2), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_DsJlpRsag2mPPtZAwPnuay", in __monadBuilder_DsJlpRsag2mPPtZAwPnuay), n1.CompilationHelper.GetValueOrExisting(values, "__p_G3uepad3fsSOxk4R7P9jNO", in __p_G3uepad3fsSOxk4R7P9jNO), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_U5cWl62ykMBMEQYkrVXAfQ", in __monadBuilder_U5cWl62ykMBMEQYkrVXAfQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_LwQHfdgLmF2OBmSFZop08B", in __p_LwQHfdgLmF2OBmSFZop08B), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_VSmT69vvnssOiUexZCxxzz", in __monadBuilder_VSmT69vvnssOiUexZCxxzz), n1.CompilationHelper.GetValueOrExisting(values, "__p_JSEh1Uk1o9IOpCdt2wLfpE", in __p_JSEh1Uk1o9IOpCdt2wLfpE), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE", in __pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE), n1.CompilationHelper.GetValueOrExisting(values, "__p_SOWQ6XzhJFsOyESZPeZSgQ", in __p_SOWQ6XzhJFsOyESZPeZSgQ), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_AmfCdWhIzArMRoBIflQeCe", in __monadBuilder_AmfCdWhIzArMRoBIflQeCe), n1.CompilationHelper.GetValueOrExisting(values, "__p_S9ovLip24W4NDIxtbORWr8", in __p_S9ovLip24W4NDIxtbORWr8), n1.CompilationHelper.GetValueOrExisting(values, "__p_OdbXhnD00IdNQY62paTYzX", in __p_OdbXhnD00IdNQY62paTYzX), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_OdbXhnD00IdNQY62paTYzX", in __pin_group_Input_In_OdbXhnD00IdNQY62paTYzX), n1.CompilationHelper.GetValueOrExisting(values, "__p_PFy7VK8L0W0QU7tMBGS1uR", in __p_PFy7VK8L0W0QU7tMBGS1uR), n1.CompilationHelper.GetValueOrExisting(values, "__p_VP2jZdismcJPmArV0EYcpU", in __p_VP2jZdismcJPmArV0EYcpU), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_ROokG4ir22VL4m6cKXIKnH", in __monadBuilder_ROokG4ir22VL4m6cKXIKnH), n1.CompilationHelper.GetValueOrExisting(values, "__p_HKF9qVG4T1lPHPnt5wyo93", in __p_HKF9qVG4T1lPHPnt5wyo93), n1.CompilationHelper.GetValueOrExisting(values, "__p_MuE2Xk4eqcBM22oIb32War", in __p_MuE2Xk4eqcBM22oIb32War), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_MuE2Xk4eqcBM22oIb32War", in __pin_group_Input_In_MuE2Xk4eqcBM22oIb32War), n1.CompilationHelper.GetValueOrExisting(values, "__p_FDnKyk7VUYiP1TdcUPqiXI", in __p_FDnKyk7VUYiP1TdcUPqiXI), n1.CompilationHelper.GetValueOrExisting(values, "__p_R8vq1DF3FPgLR8qvhRvjSL", in __p_R8vq1DF3FPgLR8qvhRvjSL), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL", in __pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL), n1.CompilationHelper.GetValueOrExisting(values, "__p_CWYW4NkTQxeLwuvt9fnNKI", in __p_CWYW4NkTQxeLwuvt9fnNKI), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI", in __pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI), n1.CompilationHelper.GetValueOrExisting(values, "__p_N8WAgidoDtILowoa9u0wXn", in __p_N8WAgidoDtILowoa9u0wXn), n1.CompilationHelper.GetValueOrExisting(values, "__p_AGYldRxOaffOvgLjEVQa9Y", in __p_AGYldRxOaffOvgLjEVQa9Y), n1.CompilationHelper.GetValueOrExisting(values, "__p_IISoeXJhwaTPSR0W9XTTU2", in __p_IISoeXJhwaTPSR0W9XTTU2), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2", in __pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2), n1.CompilationHelper.GetValueOrExisting(values, "__p_PIlyGh2nlRJPewsBw9eraI", in __p_PIlyGh2nlRJPewsBw9eraI), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI", in __pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI), n1.CompilationHelper.GetValueOrExisting(values, "__p_OfTtOPMBdg3OHwnYTj54BI", in __p_OfTtOPMBdg3OHwnYTj54BI), n1.CompilationHelper.GetValueOrExisting(values, "__p_KcP0mVGEEMyMJSIIOz4q6G", in __p_KcP0mVGEEMyMJSIIOz4q6G), n1.CompilationHelper.GetValueOrExisting(values, "__p_K3KQpcOhUioPgSrxkO4C8X", in __p_K3KQpcOhUioPgSrxkO4C8X), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X", in __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X), n1.CompilationHelper.GetValueOrExisting(values, "__p_ICYDa1ufXCnM07cWMLwy26", in __p_ICYDa1ufXCnM07cWMLwy26), n1.CompilationHelper.GetValueOrExisting(values, "__p_AWPP9NmBEsSPEZwWyWxim8", in __p_AWPP9NmBEsSPEZwWyWxim8), n1.CompilationHelper.GetValueOrExisting(values, "__p_DePkTYuokNyLpjnZCSEsLh", in __p_DePkTYuokNyLpjnZCSEsLh), n1.CompilationHelper.GetValueOrExisting(values, "__p_RXYspH49pTUPY59Q5ELaE3", in __p_RXYspH49pTUPY59Q5ELaE3), n1.CompilationHelper.GetValueOrExisting(values, "__p_IH6pxwZSh1qPYIOjUJVLYx", in __p_IH6pxwZSh1qPYIOjUJVLYx), n1.CompilationHelper.GetValueOrExisting(values, "__p_I2X9mE0xUf5MjMshDBZjXM", in __p_I2X9mE0xUf5MjMshDBZjXM));
        }

        internal SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe __WITH__(n44.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_LFGKDhTXHAMMxaYMlzdHdi, n40.Sphere_C __p_ERkRanxvitmLzn4m9aC7dO, n41.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_Bfr5HYSsZP7LzIkGCfTtKJ, n38.ColorMap_KOxQ1z1ZXvlODfQvuwEtGx __p_GtE3SRD0l67PPMD3tR7Yk3, n1.IVLNode __p_DQ0002lcFvpOxWQbfChKsz, n38.ValueMap_MSDYzfiuxQTMHIqVDSqrQu __p_ST6vfERwyI6LVi6c6j8xqr, n39.PBRMaterial_Metallic_FiHTnsXENg8Pe4uJCxGwGT __p_OnshscpT9JwPOvREOUyCqX, n15.BufferResourceHandler_C __p_GGeWWawk2BXQSONZdtWM3Y, n1.IMonadBuilder<float, n16.GpuValue<float>> __monadBuilder_SQvW9DjumhULceku1CfaO3, n1.IMonadBuilder<n3.Vector3, n16.GpuValue<n3.Vector3>> __monadBuilder_PpkB3lWQ8YGNjnomhVcQvr, n1.IMonadBuilder<n3.Vector3, n16.GpuValue<n3.Vector3>> __monadBuilder_FvbQXvSGiDwNMZOK5846cQ, n49.Random_C<n3.Vector3> __p_CfJsgWMgYUPO3wcjLTXna5, n1.IMonadBuilder<float, n16.GpuValue<float>> __monadBuilder_Hv290cWar54LTWf1KsF725, n49.SphereRandom_Compute_RSopXV2deoBP83q16kHJw9 __p_EHCd4QZiBmMPridsXQZXnH, n1.IMonadBuilder<float, n16.GpuValue<float>> __monadBuilder_Uik8KLTSKWHQYCBuRdcHwE, n1.IMonadBuilder<float, n16.GpuValue<float>> __monadBuilder_NQ4BEMMnc7BMtXZurttGhG, n49.Random_C<float> __p_PWUlZefy3hJNdtSJzVHeAm, n47.ProbabilityEmitter_AES99Kg9CLFOmrKjo7Tiub __p_Q6JNBAuu5VeQEyX9fshZGw, n19.Spread<n16.GpuValue<n18.GpuVoid>> __pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw, n22.SphericalImpulse_C __p_Ufv8dRgeGhHLr5VHF387ue, n19.Spread<n22.SphericalImpulse_C> __pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz, n22.SphericalImpulses_C __p_ICy6XyB1hLzLLFrhFJby2G, n19.Spread<n22.IFluidComponent_I> __pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA, n45.Fluid3D_JpxxW5bjXm4NABtE3B6DIu __p_UX5gEDZEBNLMWbHcXmfHl2, n1.IMonadBuilder<float, n16.GpuValue<float>> __monadBuilder_DsJlpRsag2mPPtZAwPnuay, n50.Texture3DForceField_AKqxJL5R1MoOVHKT0pi0jQ __p_G3uepad3fsSOxk4R7P9jNO, n1.IMonadBuilder<bool, n16.GpuValue<bool>> __monadBuilder_U5cWl62ykMBMEQYkrVXAfQ, n46.IntegrateVelocityAndPosition_C __p_LwQHfdgLmF2OBmSFZop08B, n1.IMonadBuilder<bool, n16.GpuValue<bool>> __monadBuilder_VSmT69vvnssOiUexZCxxzz, n48.Group_GpuVoid_PRMY4HYRXTzM4hzmICywZJ __p_JSEh1Uk1o9IOpCdt2wLfpE, n19.Spread<n16.GpuValue<n18.GpuVoid>> __pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE, n15.ComputeStage_C __p_SOWQ6XzhJFsOyESZPeZSgQ, n1.IMonadBuilder<float, n16.GpuValue<float>> __monadBuilder_AmfCdWhIzArMRoBIflQeCe, n54.AgeOverLifeTime_L63dVGA8FhRMrtDsWIyrMT __p_S9ovLip24W4NDIxtbORWr8, n55.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_OdbXhnD00IdNQY62paTYzX, n19.Spread<n16.GpuValue<float>> __pin_group_Input_In_OdbXhnD00IdNQY62paTYzX, n52.Color_Particle_LlPANDKLszZP94y29eyOob __p_PFy7VK8L0W0QU7tMBGS1uR, n57.xyz_T2WwCF9xAltPhlUuLjVDje __p_VP2jZdismcJPmArV0EYcpU, n1.IMonadBuilder<n3.Vector3, n16.GpuValue<n3.Vector3>> __monadBuilder_ROokG4ir22VL4m6cKXIKnH, n56.GPUInFromFloat_I8BJWfdKlplN7rvcBs80sD<n3.Vector3> __p_HKF9qVG4T1lPHPnt5wyo93, n55.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n3.Vector3> __p_MuE2Xk4eqcBM22oIb32War, n19.Spread<n16.GpuValue<n3.Vector3>> __pin_group_Input_In_MuE2Xk4eqcBM22oIb32War, n56.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<n3.Vector3> __p_FDnKyk7VUYiP1TdcUPqiXI, n55.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n3.Vector3> __p_R8vq1DF3FPgLR8qvhRvjSL, n19.Spread<n16.GpuValue<n3.Vector3>> __pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL, n55.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n3.Vector3> __p_CWYW4NkTQxeLwuvt9fnNKI, n19.Spread<n16.GpuValue<n3.Vector3>> __pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI, n53.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_N8WAgidoDtILowoa9u0wXn, n51.SpriteRenderer_Particle_C __p_AGYldRxOaffOvgLjEVQa9Y, n15.ComputeSystem_Spectral_C __p_IISoeXJhwaTPSR0W9XTTU2, n19.Spread<n15.IComputeStage_I> __pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2, n37.Group_TqwCZl6Gra4OmgvUg1POgm __p_PIlyGh2nlRJPewsBw9eraI, n19.Spread<n28.Entity> __pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI, n41.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_OfTtOPMBdg3OHwnYTj54BI, n58.SkyboxLight_C __p_KcP0mVGEEMyMJSIIOz4q6G, n37.RootScene_GcBzJdp7uHFN7DqiDqkHlb __p_K3KQpcOhUioPgSrxkO4C8X, n19.Spread<n28.Entity> __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X, n1.IVLNode __p_ICYDa1ufXCnM07cWMLwy26, n33.PostFX_C __p_AWPP9NmBEsSPEZwWyWxim8, n1.IVLNode __p_DePkTYuokNyLpjnZCSEsLh, n44.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_RXYspH49pTUPY59Q5ELaE3, n37.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k __p_IH6pxwZSh1qPYIOjUJVLYx, n44.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_I2X9mE0xUf5MjMshDBZjXM)
        {
            n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_LFGKDhTXHAMMxaYMlzdHdi != this.__p_LFGKDhTXHAMMxaYMlzdHdi || __p_ERkRanxvitmLzn4m9aC7dO != this.__p_ERkRanxvitmLzn4m9aC7dO || __p_Bfr5HYSsZP7LzIkGCfTtKJ != this.__p_Bfr5HYSsZP7LzIkGCfTtKJ || __p_GtE3SRD0l67PPMD3tR7Yk3 != this.__p_GtE3SRD0l67PPMD3tR7Yk3 || __p_DQ0002lcFvpOxWQbfChKsz != this.__p_DQ0002lcFvpOxWQbfChKsz || __p_ST6vfERwyI6LVi6c6j8xqr != this.__p_ST6vfERwyI6LVi6c6j8xqr || __p_OnshscpT9JwPOvREOUyCqX != this.__p_OnshscpT9JwPOvREOUyCqX || __p_GGeWWawk2BXQSONZdtWM3Y != this.__p_GGeWWawk2BXQSONZdtWM3Y || __monadBuilder_SQvW9DjumhULceku1CfaO3 != this.__monadBuilder_SQvW9DjumhULceku1CfaO3 || __monadBuilder_PpkB3lWQ8YGNjnomhVcQvr != this.__monadBuilder_PpkB3lWQ8YGNjnomhVcQvr || __monadBuilder_FvbQXvSGiDwNMZOK5846cQ != this.__monadBuilder_FvbQXvSGiDwNMZOK5846cQ || __p_CfJsgWMgYUPO3wcjLTXna5 != this.__p_CfJsgWMgYUPO3wcjLTXna5 || __monadBuilder_Hv290cWar54LTWf1KsF725 != this.__monadBuilder_Hv290cWar54LTWf1KsF725 || __p_EHCd4QZiBmMPridsXQZXnH != this.__p_EHCd4QZiBmMPridsXQZXnH || __monadBuilder_Uik8KLTSKWHQYCBuRdcHwE != this.__monadBuilder_Uik8KLTSKWHQYCBuRdcHwE || __monadBuilder_NQ4BEMMnc7BMtXZurttGhG != this.__monadBuilder_NQ4BEMMnc7BMtXZurttGhG || __p_PWUlZefy3hJNdtSJzVHeAm != this.__p_PWUlZefy3hJNdtSJzVHeAm || __p_Q6JNBAuu5VeQEyX9fshZGw != this.__p_Q6JNBAuu5VeQEyX9fshZGw || __pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw != this.__pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw || __p_Ufv8dRgeGhHLr5VHF387ue != this.__p_Ufv8dRgeGhHLr5VHF387ue || __pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz != this.__pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz || __p_ICy6XyB1hLzLLFrhFJby2G != this.__p_ICy6XyB1hLzLLFrhFJby2G || __pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA != this.__pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA || __p_UX5gEDZEBNLMWbHcXmfHl2 != this.__p_UX5gEDZEBNLMWbHcXmfHl2 || __monadBuilder_DsJlpRsag2mPPtZAwPnuay != this.__monadBuilder_DsJlpRsag2mPPtZAwPnuay || __p_G3uepad3fsSOxk4R7P9jNO != this.__p_G3uepad3fsSOxk4R7P9jNO || __monadBuilder_U5cWl62ykMBMEQYkrVXAfQ != this.__monadBuilder_U5cWl62ykMBMEQYkrVXAfQ || __p_LwQHfdgLmF2OBmSFZop08B != this.__p_LwQHfdgLmF2OBmSFZop08B || __monadBuilder_VSmT69vvnssOiUexZCxxzz != this.__monadBuilder_VSmT69vvnssOiUexZCxxzz || __p_JSEh1Uk1o9IOpCdt2wLfpE != this.__p_JSEh1Uk1o9IOpCdt2wLfpE || __pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE != this.__pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE || __p_SOWQ6XzhJFsOyESZPeZSgQ != this.__p_SOWQ6XzhJFsOyESZPeZSgQ || __monadBuilder_AmfCdWhIzArMRoBIflQeCe != this.__monadBuilder_AmfCdWhIzArMRoBIflQeCe || __p_S9ovLip24W4NDIxtbORWr8 != this.__p_S9ovLip24W4NDIxtbORWr8 || __p_OdbXhnD00IdNQY62paTYzX != this.__p_OdbXhnD00IdNQY62paTYzX || __pin_group_Input_In_OdbXhnD00IdNQY62paTYzX != this.__pin_group_Input_In_OdbXhnD00IdNQY62paTYzX || __p_PFy7VK8L0W0QU7tMBGS1uR != this.__p_PFy7VK8L0W0QU7tMBGS1uR || __p_VP2jZdismcJPmArV0EYcpU != this.__p_VP2jZdismcJPmArV0EYcpU || __monadBuilder_ROokG4ir22VL4m6cKXIKnH != this.__monadBuilder_ROokG4ir22VL4m6cKXIKnH || __p_HKF9qVG4T1lPHPnt5wyo93 != this.__p_HKF9qVG4T1lPHPnt5wyo93 || __p_MuE2Xk4eqcBM22oIb32War != this.__p_MuE2Xk4eqcBM22oIb32War || __pin_group_Input_In_MuE2Xk4eqcBM22oIb32War != this.__pin_group_Input_In_MuE2Xk4eqcBM22oIb32War || __p_FDnKyk7VUYiP1TdcUPqiXI != this.__p_FDnKyk7VUYiP1TdcUPqiXI || __p_R8vq1DF3FPgLR8qvhRvjSL != this.__p_R8vq1DF3FPgLR8qvhRvjSL || __pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL != this.__pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL || __p_CWYW4NkTQxeLwuvt9fnNKI != this.__p_CWYW4NkTQxeLwuvt9fnNKI || __pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI != this.__pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI || __p_N8WAgidoDtILowoa9u0wXn != this.__p_N8WAgidoDtILowoa9u0wXn || __p_AGYldRxOaffOvgLjEVQa9Y != this.__p_AGYldRxOaffOvgLjEVQa9Y || __p_IISoeXJhwaTPSR0W9XTTU2 != this.__p_IISoeXJhwaTPSR0W9XTTU2 || __pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2 != this.__pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2 || __p_PIlyGh2nlRJPewsBw9eraI != this.__p_PIlyGh2nlRJPewsBw9eraI || __pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI != this.__pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI || __p_OfTtOPMBdg3OHwnYTj54BI != this.__p_OfTtOPMBdg3OHwnYTj54BI || __p_KcP0mVGEEMyMJSIIOz4q6G != this.__p_KcP0mVGEEMyMJSIIOz4q6G || __p_K3KQpcOhUioPgSrxkO4C8X != this.__p_K3KQpcOhUioPgSrxkO4C8X || __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X != this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X || __p_ICYDa1ufXCnM07cWMLwy26 != this.__p_ICYDa1ufXCnM07cWMLwy26 || __p_AWPP9NmBEsSPEZwWyWxim8 != this.__p_AWPP9NmBEsSPEZwWyWxim8 || __p_DePkTYuokNyLpjnZCSEsLh != this.__p_DePkTYuokNyLpjnZCSEsLh || __p_RXYspH49pTUPY59Q5ELaE3 != this.__p_RXYspH49pTUPY59Q5ELaE3 || __p_IH6pxwZSh1qPYIOjUJVLYx != this.__p_IH6pxwZSh1qPYIOjUJVLYx || __p_I2X9mE0xUf5MjMshDBZjXM != this.__p_I2X9mE0xUf5MjMshDBZjXM ? new SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe(this)
                {__p_LFGKDhTXHAMMxaYMlzdHdi = __p_LFGKDhTXHAMMxaYMlzdHdi, __p_ERkRanxvitmLzn4m9aC7dO = __p_ERkRanxvitmLzn4m9aC7dO, __p_Bfr5HYSsZP7LzIkGCfTtKJ = __p_Bfr5HYSsZP7LzIkGCfTtKJ, __p_GtE3SRD0l67PPMD3tR7Yk3 = __p_GtE3SRD0l67PPMD3tR7Yk3, __p_DQ0002lcFvpOxWQbfChKsz = __p_DQ0002lcFvpOxWQbfChKsz, __p_ST6vfERwyI6LVi6c6j8xqr = __p_ST6vfERwyI6LVi6c6j8xqr, __p_OnshscpT9JwPOvREOUyCqX = __p_OnshscpT9JwPOvREOUyCqX, __p_GGeWWawk2BXQSONZdtWM3Y = __p_GGeWWawk2BXQSONZdtWM3Y, __monadBuilder_SQvW9DjumhULceku1CfaO3 = __monadBuilder_SQvW9DjumhULceku1CfaO3, __monadBuilder_PpkB3lWQ8YGNjnomhVcQvr = __monadBuilder_PpkB3lWQ8YGNjnomhVcQvr, __monadBuilder_FvbQXvSGiDwNMZOK5846cQ = __monadBuilder_FvbQXvSGiDwNMZOK5846cQ, __p_CfJsgWMgYUPO3wcjLTXna5 = __p_CfJsgWMgYUPO3wcjLTXna5, __monadBuilder_Hv290cWar54LTWf1KsF725 = __monadBuilder_Hv290cWar54LTWf1KsF725, __p_EHCd4QZiBmMPridsXQZXnH = __p_EHCd4QZiBmMPridsXQZXnH, __monadBuilder_Uik8KLTSKWHQYCBuRdcHwE = __monadBuilder_Uik8KLTSKWHQYCBuRdcHwE, __monadBuilder_NQ4BEMMnc7BMtXZurttGhG = __monadBuilder_NQ4BEMMnc7BMtXZurttGhG, __p_PWUlZefy3hJNdtSJzVHeAm = __p_PWUlZefy3hJNdtSJzVHeAm, __p_Q6JNBAuu5VeQEyX9fshZGw = __p_Q6JNBAuu5VeQEyX9fshZGw, __pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw = __pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw, __p_Ufv8dRgeGhHLr5VHF387ue = __p_Ufv8dRgeGhHLr5VHF387ue, __pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz = __pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz, __p_ICy6XyB1hLzLLFrhFJby2G = __p_ICy6XyB1hLzLLFrhFJby2G, __pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA = __pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA, __p_UX5gEDZEBNLMWbHcXmfHl2 = __p_UX5gEDZEBNLMWbHcXmfHl2, __monadBuilder_DsJlpRsag2mPPtZAwPnuay = __monadBuilder_DsJlpRsag2mPPtZAwPnuay, __p_G3uepad3fsSOxk4R7P9jNO = __p_G3uepad3fsSOxk4R7P9jNO, __monadBuilder_U5cWl62ykMBMEQYkrVXAfQ = __monadBuilder_U5cWl62ykMBMEQYkrVXAfQ, __p_LwQHfdgLmF2OBmSFZop08B = __p_LwQHfdgLmF2OBmSFZop08B, __monadBuilder_VSmT69vvnssOiUexZCxxzz = __monadBuilder_VSmT69vvnssOiUexZCxxzz, __p_JSEh1Uk1o9IOpCdt2wLfpE = __p_JSEh1Uk1o9IOpCdt2wLfpE, __pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE = __pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE, __p_SOWQ6XzhJFsOyESZPeZSgQ = __p_SOWQ6XzhJFsOyESZPeZSgQ, __monadBuilder_AmfCdWhIzArMRoBIflQeCe = __monadBuilder_AmfCdWhIzArMRoBIflQeCe, __p_S9ovLip24W4NDIxtbORWr8 = __p_S9ovLip24W4NDIxtbORWr8, __p_OdbXhnD00IdNQY62paTYzX = __p_OdbXhnD00IdNQY62paTYzX, __pin_group_Input_In_OdbXhnD00IdNQY62paTYzX = __pin_group_Input_In_OdbXhnD00IdNQY62paTYzX, __p_PFy7VK8L0W0QU7tMBGS1uR = __p_PFy7VK8L0W0QU7tMBGS1uR, __p_VP2jZdismcJPmArV0EYcpU = __p_VP2jZdismcJPmArV0EYcpU, __monadBuilder_ROokG4ir22VL4m6cKXIKnH = __monadBuilder_ROokG4ir22VL4m6cKXIKnH, __p_HKF9qVG4T1lPHPnt5wyo93 = __p_HKF9qVG4T1lPHPnt5wyo93, __p_MuE2Xk4eqcBM22oIb32War = __p_MuE2Xk4eqcBM22oIb32War, __pin_group_Input_In_MuE2Xk4eqcBM22oIb32War = __pin_group_Input_In_MuE2Xk4eqcBM22oIb32War, __p_FDnKyk7VUYiP1TdcUPqiXI = __p_FDnKyk7VUYiP1TdcUPqiXI, __p_R8vq1DF3FPgLR8qvhRvjSL = __p_R8vq1DF3FPgLR8qvhRvjSL, __pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL = __pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL, __p_CWYW4NkTQxeLwuvt9fnNKI = __p_CWYW4NkTQxeLwuvt9fnNKI, __pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI = __pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI, __p_N8WAgidoDtILowoa9u0wXn = __p_N8WAgidoDtILowoa9u0wXn, __p_AGYldRxOaffOvgLjEVQa9Y = __p_AGYldRxOaffOvgLjEVQa9Y, __p_IISoeXJhwaTPSR0W9XTTU2 = __p_IISoeXJhwaTPSR0W9XTTU2, __pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2 = __pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2, __p_PIlyGh2nlRJPewsBw9eraI = __p_PIlyGh2nlRJPewsBw9eraI, __pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI = __pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI, __p_OfTtOPMBdg3OHwnYTj54BI = __p_OfTtOPMBdg3OHwnYTj54BI, __p_KcP0mVGEEMyMJSIIOz4q6G = __p_KcP0mVGEEMyMJSIIOz4q6G, __p_K3KQpcOhUioPgSrxkO4C8X = __p_K3KQpcOhUioPgSrxkO4C8X, __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X, __p_ICYDa1ufXCnM07cWMLwy26 = __p_ICYDa1ufXCnM07cWMLwy26, __p_AWPP9NmBEsSPEZwWyWxim8 = __p_AWPP9NmBEsSPEZwWyWxim8, __p_DePkTYuokNyLpjnZCSEsLh = __p_DePkTYuokNyLpjnZCSEsLh, __p_RXYspH49pTUPY59Q5ELaE3 = __p_RXYspH49pTUPY59Q5ELaE3, __p_IH6pxwZSh1qPYIOjUJVLYx = __p_IH6pxwZSh1qPYIOjUJVLYx, __p_I2X9mE0xUf5MjMshDBZjXM = __p_I2X9mE0xUf5MjMshDBZjXM} : that_0;
            else
            {
                this.__p_LFGKDhTXHAMMxaYMlzdHdi = __p_LFGKDhTXHAMMxaYMlzdHdi;
                this.__p_ERkRanxvitmLzn4m9aC7dO = __p_ERkRanxvitmLzn4m9aC7dO;
                this.__p_Bfr5HYSsZP7LzIkGCfTtKJ = __p_Bfr5HYSsZP7LzIkGCfTtKJ;
                this.__p_GtE3SRD0l67PPMD3tR7Yk3 = __p_GtE3SRD0l67PPMD3tR7Yk3;
                this.__p_DQ0002lcFvpOxWQbfChKsz = __p_DQ0002lcFvpOxWQbfChKsz;
                this.__p_ST6vfERwyI6LVi6c6j8xqr = __p_ST6vfERwyI6LVi6c6j8xqr;
                this.__p_OnshscpT9JwPOvREOUyCqX = __p_OnshscpT9JwPOvREOUyCqX;
                this.__p_GGeWWawk2BXQSONZdtWM3Y = __p_GGeWWawk2BXQSONZdtWM3Y;
                this.__monadBuilder_SQvW9DjumhULceku1CfaO3 = __monadBuilder_SQvW9DjumhULceku1CfaO3;
                this.__monadBuilder_PpkB3lWQ8YGNjnomhVcQvr = __monadBuilder_PpkB3lWQ8YGNjnomhVcQvr;
                this.__monadBuilder_FvbQXvSGiDwNMZOK5846cQ = __monadBuilder_FvbQXvSGiDwNMZOK5846cQ;
                this.__p_CfJsgWMgYUPO3wcjLTXna5 = __p_CfJsgWMgYUPO3wcjLTXna5;
                this.__monadBuilder_Hv290cWar54LTWf1KsF725 = __monadBuilder_Hv290cWar54LTWf1KsF725;
                this.__p_EHCd4QZiBmMPridsXQZXnH = __p_EHCd4QZiBmMPridsXQZXnH;
                this.__monadBuilder_Uik8KLTSKWHQYCBuRdcHwE = __monadBuilder_Uik8KLTSKWHQYCBuRdcHwE;
                this.__monadBuilder_NQ4BEMMnc7BMtXZurttGhG = __monadBuilder_NQ4BEMMnc7BMtXZurttGhG;
                this.__p_PWUlZefy3hJNdtSJzVHeAm = __p_PWUlZefy3hJNdtSJzVHeAm;
                this.__p_Q6JNBAuu5VeQEyX9fshZGw = __p_Q6JNBAuu5VeQEyX9fshZGw;
                this.__pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw = __pin_group_Custom_In_Q6JNBAuu5VeQEyX9fshZGw;
                this.__p_Ufv8dRgeGhHLr5VHF387ue = __p_Ufv8dRgeGhHLr5VHF387ue;
                this.__pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz = __pin_group_Input_In_RyYzBWRPzYUOwIixKZcaMz;
                this.__p_ICy6XyB1hLzLLFrhFJby2G = __p_ICy6XyB1hLzLLFrhFJby2G;
                this.__pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA = __pin_group_Input_In_EHxKOheF5Z6OdNprmYGbkA;
                this.__p_UX5gEDZEBNLMWbHcXmfHl2 = __p_UX5gEDZEBNLMWbHcXmfHl2;
                this.__monadBuilder_DsJlpRsag2mPPtZAwPnuay = __monadBuilder_DsJlpRsag2mPPtZAwPnuay;
                this.__p_G3uepad3fsSOxk4R7P9jNO = __p_G3uepad3fsSOxk4R7P9jNO;
                this.__monadBuilder_U5cWl62ykMBMEQYkrVXAfQ = __monadBuilder_U5cWl62ykMBMEQYkrVXAfQ;
                this.__p_LwQHfdgLmF2OBmSFZop08B = __p_LwQHfdgLmF2OBmSFZop08B;
                this.__monadBuilder_VSmT69vvnssOiUexZCxxzz = __monadBuilder_VSmT69vvnssOiUexZCxxzz;
                this.__p_JSEh1Uk1o9IOpCdt2wLfpE = __p_JSEh1Uk1o9IOpCdt2wLfpE;
                this.__pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE = __pin_group_Input_In_JSEh1Uk1o9IOpCdt2wLfpE;
                this.__p_SOWQ6XzhJFsOyESZPeZSgQ = __p_SOWQ6XzhJFsOyESZPeZSgQ;
                this.__monadBuilder_AmfCdWhIzArMRoBIflQeCe = __monadBuilder_AmfCdWhIzArMRoBIflQeCe;
                this.__p_S9ovLip24W4NDIxtbORWr8 = __p_S9ovLip24W4NDIxtbORWr8;
                this.__p_OdbXhnD00IdNQY62paTYzX = __p_OdbXhnD00IdNQY62paTYzX;
                this.__pin_group_Input_In_OdbXhnD00IdNQY62paTYzX = __pin_group_Input_In_OdbXhnD00IdNQY62paTYzX;
                this.__p_PFy7VK8L0W0QU7tMBGS1uR = __p_PFy7VK8L0W0QU7tMBGS1uR;
                this.__p_VP2jZdismcJPmArV0EYcpU = __p_VP2jZdismcJPmArV0EYcpU;
                this.__monadBuilder_ROokG4ir22VL4m6cKXIKnH = __monadBuilder_ROokG4ir22VL4m6cKXIKnH;
                this.__p_HKF9qVG4T1lPHPnt5wyo93 = __p_HKF9qVG4T1lPHPnt5wyo93;
                this.__p_MuE2Xk4eqcBM22oIb32War = __p_MuE2Xk4eqcBM22oIb32War;
                this.__pin_group_Input_In_MuE2Xk4eqcBM22oIb32War = __pin_group_Input_In_MuE2Xk4eqcBM22oIb32War;
                this.__p_FDnKyk7VUYiP1TdcUPqiXI = __p_FDnKyk7VUYiP1TdcUPqiXI;
                this.__p_R8vq1DF3FPgLR8qvhRvjSL = __p_R8vq1DF3FPgLR8qvhRvjSL;
                this.__pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL = __pin_group_Input_In_R8vq1DF3FPgLR8qvhRvjSL;
                this.__p_CWYW4NkTQxeLwuvt9fnNKI = __p_CWYW4NkTQxeLwuvt9fnNKI;
                this.__pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI = __pin_group_Input_In_CWYW4NkTQxeLwuvt9fnNKI;
                this.__p_N8WAgidoDtILowoa9u0wXn = __p_N8WAgidoDtILowoa9u0wXn;
                this.__p_AGYldRxOaffOvgLjEVQa9Y = __p_AGYldRxOaffOvgLjEVQa9Y;
                this.__p_IISoeXJhwaTPSR0W9XTTU2 = __p_IISoeXJhwaTPSR0W9XTTU2;
                this.__pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2 = __pin_group_Input_In_IISoeXJhwaTPSR0W9XTTU2;
                this.__p_PIlyGh2nlRJPewsBw9eraI = __p_PIlyGh2nlRJPewsBw9eraI;
                this.__pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI = __pin_group_Child_In_PIlyGh2nlRJPewsBw9eraI;
                this.__p_OfTtOPMBdg3OHwnYTj54BI = __p_OfTtOPMBdg3OHwnYTj54BI;
                this.__p_KcP0mVGEEMyMJSIIOz4q6G = __p_KcP0mVGEEMyMJSIIOz4q6G;
                this.__p_K3KQpcOhUioPgSrxkO4C8X = __p_K3KQpcOhUioPgSrxkO4C8X;
                this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X;
                this.__p_ICYDa1ufXCnM07cWMLwy26 = __p_ICYDa1ufXCnM07cWMLwy26;
                this.__p_AWPP9NmBEsSPEZwWyWxim8 = __p_AWPP9NmBEsSPEZwWyWxim8;
                this.__p_DePkTYuokNyLpjnZCSEsLh = __p_DePkTYuokNyLpjnZCSEsLh;
                this.__p_RXYspH49pTUPY59Q5ELaE3 = __p_RXYspH49pTUPY59Q5ELaE3;
                this.__p_IH6pxwZSh1qPYIOjUJVLYx = __p_IH6pxwZSh1qPYIOjUJVLYx;
                this.__p_I2X9mE0xUf5MjMshDBZjXM = __p_I2X9mE0xUf5MjMshDBZjXM;
            }

            return that_0;
        }
    }
}

namespace _SolarSystem_
{
    public struct __AdaptiveImplementations__KYrBT1ndOH9MqXl8wdSpYV : n59.IAdaptiveOperatorMinus<float>, n59.IAdaptiveOperatorDivide<float>, n59.IAdaptiveOperatorMulitply<float>, n59.IAdaptiveOperatorPlus<float>
    {
        public void OperatorMinus(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In - Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = (float)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In * Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In + Input_2_In;
            Output_Out = Output_0;
            return;
        }
    }
}