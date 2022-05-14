extern alias e27;
extern alias e26;
extern alias e40;
extern alias e57;
extern alias e28;
extern alias e24;
extern alias e5;
extern alias e1;
extern alias e20;

using n12 = _CoreLibBasics_._3D.Matrix;
using n27 = _VL_Stride_Rendering_ShaderFX_.Stride.Materials.Inputs;
using n13 = _CoreLibBasics_._3D.Transform;
using n15 = e26::Stride.Rendering.Materials;
using n21 = e26::Stride.Rendering.Images;
using n8 = e27::Stride.Graphics;
using n4 = _SolarSystem_.Main;
using n32 = e5::VL.Lib.Animation;
using n5 = e5::VL.Core.CompilerServices;
using n28 = _VL_Stride_Rendering_ShaderFX_.Stride.Materials;
using n31 = _CoreLibBasics_.Animation.IFrameClock.Advanced;
using n35 = global::System.Collections.Generic;
using n9 = e40::VL.Stride.Rendering.Lights;
using n3 = e1::Stride.Core.Mathematics;
using n36 = _CoreLibBasics_.Math.Adaptive;
using n23 = e28::Stride.Games;
using n7 = e57::Stride.Assets.Textures;
using n22 = _VL_Stride_Engine_.Stride.Rendering;
using n30 = _VL_Stride_Assets_Windows_.Stride.Assets;
using n33 = _CoreLibBasics_.Animation;
using n20 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n34 = _VL_Stride_Engine_.Stride.Lights;
using n10 = e24::Stride.Engine;
using n16 = e26::Stride.Rendering;
using n1 = e5::VL.Core;
using n25 = e20::Stride.Graphics;
using n19 = _SolarSystem_;
using n29 = _VL_Stride_Engine_.Stride.Models;
using n2 = global::System;
using n14 = e40::VL.Stride.Shaders.ShaderFX;
using n26 = _VL_Stride_Engine_.Stride;
using n24 = global::System.Runtime.CompilerServices;
using n11 = _CoreLibBasics_.Math;
using n18 = e5::VL.Lib.Collections;
using n6 = e5::VL.Lib.IO;
using n17 = _VL_Collections_.Collections.Spread;

namespace _SolarSystem_.Main
{
    [n1.ElementAttribute(TracingId = 314575U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "EnZiuY2Vb0QLrZO1M4x3Xe", Name = "SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe")]
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
            string __pad_Su9eu5EQnKcNqYZ9i6ylZX_6 = __slot_Su9eu5EQnKcNqYZ9i6ylZX;
            float __pad_GAF7PE77ztCQSKS8FZbD2v_7 = __slot_GAF7PE77ztCQSKS8FZbD2v;
            float __pad_Im0kbKlxiapQJVu62daFTD_8 = __slot_Im0kbKlxiapQJVu62daFTD;
            float __pad_IiRyUXU8UOXLLYgfKoAmvi_9 = __slot_IiRyUXU8UOXLLYgfKoAmvi;
            float __pad_TwJlA2dszaCPagj5CLaBlJ_10 = __slot_TwJlA2dszaCPagj5CLaBlJ;
            float __pad_Gt5u29j3RK6PR8FvXPCAUi_11 = __slot_Gt5u29j3RK6PR8FvXPCAUi;
            float __pad_IGkMiifOOukPySqcXHucq9_12 = __slot_IGkMiifOOukPySqcXHucq9;
            float __pad_MIbLpkqshZzOgbhPCvqbnI_13 = __slot_MIbLpkqshZzOgbhPCvqbnI;
            float __pad_UxxedL043pjOC95XRxn7eR_14 = __slot_UxxedL043pjOC95XRxn7eR;
            float __pad_EC4TvsaMoPIMxRt28NC4F0_15 = __slot_EC4TvsaMoPIMxRt28NC4F0;
            n6.Path Path_16 = __c_BnrnhRkobFHPoWPxN1Xxg8;
            bool Generate_Mipmaps_17 = true;
            bool Is_sRGB_18 = true;
            bool Premultiply_Alpha_19 = true;
            bool Compress_20 = false;
            n7.AlphaFormat Alpha_Format_21 = __c_Bc4QQHV78TgLZjk7mEkrPb;
            bool Reload_22 = false;
            var Output_26 = this.__p_U0OkmtJOnXTPgwmTNjmrvE.Update(Path_In: Path_16, Generate_Mipmaps_In: Generate_Mipmaps_17, Is_sRGB_In: Is_sRGB_18, Premultiply_Alpha_In: Premultiply_Alpha_19, Compress_In: Compress_20, Alpha_Format_In: Alpha_Format_21, Reload_In: Reload_22, Texture_Out: out n8.Texture Texture_23, Is_Loading_Out: out bool Is_Loading_24, Already_Loaded_Out: out bool Already_Loaded_25);
            bool Is_Specular_Only_27 = false;
            n9.SkyboxPreFilteringDiffuseOrder Diffuse_SHOrder_28 = n1.CompilationHelper.Deserialize<n9.SkyboxPreFilteringDiffuseOrder>("Order3", false, null, null);
            int Specular_Cube_Map_Size_29 = 256;
            bool Force_Build_30 = false;
            float Background_Intensity_31 = 1F;
            bool Background_Enabled_32 = true;
            bool SetupLight_33 = true;
            var Output_34 = this.__p_Ec9scCf8vbvMnZgY3Ql0Av;
            if (SetupLight_33)
            {
                Output_34 = this.__p_Ec9scCf8vbvMnZgY3Ql0Av.SetupLight(Cube_Map_In: Texture_23, Is_Specular_Only_In: Is_Specular_Only_27, Intensity_In: __pad_EC4TvsaMoPIMxRt28NC4F0_15, Diffuse_SHOrder_In: Diffuse_SHOrder_28, Specular_Cube_Map_Size_In: Specular_Cube_Map_Size_29, Force_Build_In: Force_Build_30, Background_Intensity_In: Background_Intensity_31, Background_Enabled_In: Background_Enabled_32);
            }

            var Output_36 = Output_34.Update(Entity_Out: out n10.Entity Entity_35);
            bool Pause_37 = false;
            bool Update_38 = true;
            var Output_39 = this.__p_LFGKDhTXHAMMxaYMlzdHdi;
            if (Update_38)
            {
                Output_39 = this.__p_LFGKDhTXHAMMxaYMlzdHdi.Update(Period_In: __pad_MIbLpkqshZzOgbhPCvqbnI_13, Pause_In: Pause_37);
            }

            var Output_43 = Output_39.GetValues(Phase_Out: out float Phase_40, On_New_Cycle_Out: out bool On_New_Cycle_41, Cycles_Out: out int Cycles_42);
            bool Inverse_44 = false;
            n11._Operations_.SawtoothWave(Phase_In: Phase_40, Inverse_In: Inverse_44, Output_Out: out float Output_45);
            n3.Matrix Input_46 = n12._Operations_.CreateDefault();
            n13._Operations_.Rotate_Axis(Input_In: Input_46, Axis_In: __pad_LJj6ofOvFTPQaRa9qlcpP8_5, Angle_In: Output_45, Output_Out: out n3.Matrix Output_47);
            bool SetTransformation_48 = true;
            var Output_49 = this.__p_ERkRanxvitmLzn4m9aC7dO;
            if (SetTransformation_48)
            {
                Output_49 = this.__p_ERkRanxvitmLzn4m9aC7dO.SetTransformation(Transformation_In: Output_47);
            }

            float Radius_50 = 1F;
            int Tessellation_51 = 16;
            bool SetupModel_52 = true;
            var Output_53 = Output_49;
            if (SetupModel_52)
            {
                Output_53 = Output_49.SetupModel(Radius_In: Radius_50, Tessellation_In: Tessellation_51);
            }

            n6.Path Path_54 = __c_UlO3Efn87NJQKsbm4PZlok;
            bool Generate_Mipmaps_55 = true;
            bool Is_sRGB_56 = true;
            bool Premultiply_Alpha_57 = true;
            bool Compress_58 = false;
            n7.AlphaFormat Alpha_Format_59 = __c_VaUJ2yQ5QlcPIyddkiszNb;
            bool Reload_60 = false;
            var Output_64 = this.__p_Bfr5HYSsZP7LzIkGCfTtKJ.Update(Path_In: Path_54, Generate_Mipmaps_In: Generate_Mipmaps_55, Is_sRGB_In: Is_sRGB_56, Premultiply_Alpha_In: Premultiply_Alpha_57, Compress_In: Compress_58, Alpha_Format_In: Alpha_Format_59, Reload_In: Reload_60, Texture_Out: out n8.Texture Texture_61, Is_Loading_Out: out bool Is_Loading_62, Already_Loaded_Out: out bool Already_Loaded_63);
            bool SetTexure_65 = true;
            var Output_66 = this.__p_GtE3SRD0l67PPMD3tR7Yk3;
            if (SetTexure_65)
            {
                Output_66 = this.__p_GtE3SRD0l67PPMD3tR7Yk3.SetTexure(Texture_In: Texture_61);
            }

            var State_Output_68 = Output_66.Update(Output_Out: out n14.SetVar<n3.Vector4> Output_67);
            n1.CompilationHelper.WritePin(this.__p_DQ0002lcFvpOxWQbfChKsz.Inputs[0], ref Output_67);
            var State_Output_70 = this.__p_ST6vfERwyI6LVi6c6j8xqr.Update(Output_Out: out n14.SetVar<float> Output_69);
            n1.CompilationHelper.WritePin(this.__p_DQ0002lcFvpOxWQbfChKsz.Inputs[1], ref Output_69);
            n1.CompilationHelper.ReadPin(this.__p_DQ0002lcFvpOxWQbfChKsz.Outputs[0], out n15.MaterialEmissiveMapFeature out_71);
            n15.IMaterialEmissiveFeature Emissive_72 = (n15.IMaterialEmissiveFeature)out_71;
            bool SetEmissive_73 = true;
            var Output_74 = this.__p_OnshscpT9JwPOvREOUyCqX;
            if (SetEmissive_73)
            {
                Output_74 = this.__p_OnshscpT9JwPOvREOUyCqX.SetEmissive(Emissive_In: Emissive_72);
            }

            var State_Output_76 = Output_74.Update(Output_Out: out n16.Material Output_75);
            bool SetMaterial_77 = true;
            var Output_78 = Output_53;
            if (SetMaterial_77)
            {
                Output_78 = Output_53.SetMaterial(Material_In: Output_75);
            }

            bool SetName_79 = true;
            var Output_80 = Output_78;
            if (SetName_79)
            {
                Output_80 = Output_78.SetName(Name_In: __pad_Su9eu5EQnKcNqYZ9i6ylZX_6);
            }

            var Output_82 = Output_80.Update(Entity_Out: out n10.Entity Entity_81);
            n10.Entity Child_3_83 = default(n10.Entity);
            n10.Entity Child_4_84 = default(n10.Entity);
            n18.Spread<n10.Scene> Child_Scenes_85 = n17._Operations_.CreateDefault<n10.Scene>();
            bool Enabled_86 = true;
            var builder_87 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X, 4);
            builder_87.Add(Entity_35);
            builder_87.Add(Entity_81);
            builder_87.Add(Child_3_83);
            builder_87.Add(Child_4_84);
            var __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X_88 = builder_87.Commit();
            var State_Output_90 = this.__p_K3KQpcOhUioPgSrxkO4C8X.Update(Child_In: __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X_88, Child_Scenes_In: Child_Scenes_85, Enabled_In: Enabled_86, Output_Out: out n10.SceneInstance Output_89);
            n1.CompilationHelper.WritePin(this.__p_DePkTYuokNyLpjnZCSEsLh.Inputs[0], ref __pad_GAF7PE77ztCQSKS8FZbD2v_7);
            bool Pause_91 = false;
            bool Update_92 = true;
            var Output_93 = this.__p_RXYspH49pTUPY59Q5ELaE3;
            if (Update_92)
            {
                Output_93 = this.__p_RXYspH49pTUPY59Q5ELaE3.Update(Period_In: __pad_UxxedL043pjOC95XRxn7eR_14, Pause_In: Pause_91);
            }

            var Output_97 = Output_93.GetValues(Phase_Out: out float Phase_94, On_New_Cycle_Out: out bool On_New_Cycle_95, Cycles_Out: out int Cycles_96);
            n11._Operations_.SineWave(Phase_In: Phase_94, Output_Out: out float Output_98);
            n20._Operations_.Map<float, n19.__AdaptiveImplementations__KYrBT1ndOH9MqXl8wdSpYV>(Input_In: Output_98, Input_Minimum_In: __pad_Im0kbKlxiapQJVu62daFTD_8, Input_Maximum_In: __pad_IiRyUXU8UOXLLYgfKoAmvi_9, Output_Minimum_In: __pad_TwJlA2dszaCPagj5CLaBlJ_10, Output_Maximum_In: __pad_Gt5u29j3RK6PR8FvXPCAUi_11, Output_Out: out float Output_99);
            n1.CompilationHelper.WritePin(this.__p_DePkTYuokNyLpjnZCSEsLh.Inputs[1], ref Output_99);
            n1.CompilationHelper.ReadPin(this.__p_DePkTYuokNyLpjnZCSEsLh.Outputs[0], out n21.Bloom out_100);
            bool SetBloom_101 = true;
            var Output_102 = this.__p_AWPP9NmBEsSPEZwWyWxim8;
            if (SetBloom_101)
            {
                Output_102 = this.__p_AWPP9NmBEsSPEZwWyWxim8.SetBloom(Bloom_In: out_100);
            }

            var State_Output_104 = Output_102.Update(Output_Out: out n21.PostProcessingEffects Output_103);
            n21.IPostProcessingEffects Post_Effects_105 = (n21.IPostProcessingEffects)Output_103;
            n10.Entity Camera_106 = default(n10.Entity);
            bool Enable_Default_Camera_107 = true;
            string Title_108 = "Stride";
            n3.Color4 Clear_Color_109 = __c_JEl7pDETGAvNkXUCGrl3dv;
            bool Clear_110 = true;
            bool Enable_Default_Post_Effects_111 = true;
            n16.RenderGroupMask Render_Group_Mask_112 = n1.CompilationHelper.Deserialize<n16.RenderGroupMask>("All", false, null, null);
            bool Enable_Keyboard_Shortcuts_113 = true;
            string Model_Effect_Name_114 = "VLEffectMain";
            n18.Spread<n22.IAdditionalSceneRenderer_I> Additional_Scene_Renderers_115 = n17._Operations_.CreateDefault<n22.IAdditionalSceneRenderer_I>();
            bool Enabled_116 = true;
            var State_Output_118 = this.__p_IH6pxwZSh1qPYIOjUJVLYx.Update(Input_In: Output_89, Camera_In: Camera_106, Enable_Default_Camera_In: Enable_Default_Camera_107, Title_In: Title_108, Clear_Color_In: Clear_Color_109, Clear_In: Clear_110, Post_Effects_In: Post_Effects_105, Enable_Default_Post_Effects_In: Enable_Default_Post_Effects_111, Render_Group_Mask_In: Render_Group_Mask_112, Enable_Keyboard_Shortcuts_In: Enable_Keyboard_Shortcuts_113, Model_Effect_Name_In: Model_Effect_Name_114, Additional_Scene_Renderers_In: Additional_Scene_Renderers_115, Enabled_In: Enabled_116, Output_Out: out n23.GameWindow Output_117);
            bool Fallback_Color_Premultiply_Alpha_119 = true;
            bool Is_Normal_120 = false;
            bool SetFallbackColor_121 = true;
            var Output_122 = State_Output_68;
            if (SetFallbackColor_121)
            {
                Output_122 = State_Output_68.SetFallbackColor(Fallback_Color_In: __pad_QvfgDEapxguOHsgsbrdfhQ_0, Fallback_Color_Premultiply_Alpha_In: Fallback_Color_Premultiply_Alpha_119, Is_Normal_In: Is_Normal_120);
            }

            bool Pause_123 = false;
            bool Update_124 = true;
            var Output_125 = this.__p_I2X9mE0xUf5MjMshDBZjXM;
            if (Update_124)
            {
                Output_125 = this.__p_I2X9mE0xUf5MjMshDBZjXM.Update(Period_In: __pad_IGkMiifOOukPySqcXHucq9_12, Pause_In: Pause_123);
            }

            var Output_129 = Output_125.GetValues(Phase_Out: out float Phase_126, On_New_Cycle_Out: out bool On_New_Cycle_127, Cycles_Out: out int Cycles_128);
            n11._Operations_.SineWave(Phase_In: Phase_126, Output_Out: out float Output_130);
            n20._Operations_.Map<float, n19.__AdaptiveImplementations__KYrBT1ndOH9MqXl8wdSpYV>(Input_In: Output_130, Input_Minimum_In: __pad_EPUeJfqUMHMQXuL2EKfkRt_1, Input_Maximum_In: __pad_Dr5eyJso53sNHfmfwIorSU_2, Output_Minimum_In: __pad_G2SngEuROj3OjpqJ381uPg_3, Output_Maximum_In: __pad_BfGf5Xs3RVFOZxZABBVsSo_4, Output_Out: out float Output_131);
            bool SetFallbackValue_132 = true;
            var Output_133 = State_Output_70;
            if (SetFallbackValue_132)
            {
                Output_133 = State_Output_70.SetFallbackValue(Fallback_Value_In: Output_131);
            }

            n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe that_134 = this;
            if (this.__GetContext__().IsImmutable)
                that_134 = Output_26 != this.__p_U0OkmtJOnXTPgwmTNjmrvE || Output_36 != this.__p_Ec9scCf8vbvMnZgY3Ql0Av || Output_43 != this.__p_LFGKDhTXHAMMxaYMlzdHdi || Output_82 != this.__p_ERkRanxvitmLzn4m9aC7dO || Output_64 != this.__p_Bfr5HYSsZP7LzIkGCfTtKJ || Output_122 != this.__p_GtE3SRD0l67PPMD3tR7Yk3 || this.__p_DQ0002lcFvpOxWQbfChKsz != this.__p_DQ0002lcFvpOxWQbfChKsz || Output_133 != this.__p_ST6vfERwyI6LVi6c6j8xqr || State_Output_76 != this.__p_OnshscpT9JwPOvREOUyCqX || __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X_88 != this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X || State_Output_90 != this.__p_K3KQpcOhUioPgSrxkO4C8X || this.__p_DePkTYuokNyLpjnZCSEsLh != this.__p_DePkTYuokNyLpjnZCSEsLh || Output_97 != this.__p_RXYspH49pTUPY59Q5ELaE3 || State_Output_104 != this.__p_AWPP9NmBEsSPEZwWyWxim8 || State_Output_118 != this.__p_IH6pxwZSh1qPYIOjUJVLYx || Output_129 != this.__p_I2X9mE0xUf5MjMshDBZjXM ? new SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe(this)
                {__p_U0OkmtJOnXTPgwmTNjmrvE = Output_26, __p_Ec9scCf8vbvMnZgY3Ql0Av = Output_36, __p_LFGKDhTXHAMMxaYMlzdHdi = Output_43, __p_ERkRanxvitmLzn4m9aC7dO = Output_82, __p_Bfr5HYSsZP7LzIkGCfTtKJ = Output_64, __p_GtE3SRD0l67PPMD3tR7Yk3 = Output_122, __p_DQ0002lcFvpOxWQbfChKsz = this.__p_DQ0002lcFvpOxWQbfChKsz, __p_ST6vfERwyI6LVi6c6j8xqr = Output_133, __p_OnshscpT9JwPOvREOUyCqX = State_Output_76, __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X_88, __p_K3KQpcOhUioPgSrxkO4C8X = State_Output_90, __p_DePkTYuokNyLpjnZCSEsLh = this.__p_DePkTYuokNyLpjnZCSEsLh, __p_RXYspH49pTUPY59Q5ELaE3 = Output_97, __p_AWPP9NmBEsSPEZwWyWxim8 = State_Output_104, __p_IH6pxwZSh1qPYIOjUJVLYx = State_Output_118, __p_I2X9mE0xUf5MjMshDBZjXM = Output_129} : that_134;
            else
            {
                this.__p_U0OkmtJOnXTPgwmTNjmrvE = Output_26;
                this.__p_Ec9scCf8vbvMnZgY3Ql0Av = Output_36;
                this.__p_LFGKDhTXHAMMxaYMlzdHdi = Output_43;
                this.__p_ERkRanxvitmLzn4m9aC7dO = Output_82;
                this.__p_Bfr5HYSsZP7LzIkGCfTtKJ = Output_64;
                this.__p_GtE3SRD0l67PPMD3tR7Yk3 = Output_122;
                this.__p_DQ0002lcFvpOxWQbfChKsz = this.__p_DQ0002lcFvpOxWQbfChKsz;
                this.__p_ST6vfERwyI6LVi6c6j8xqr = Output_133;
                this.__p_OnshscpT9JwPOvREOUyCqX = State_Output_76;
                this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X_88;
                this.__p_K3KQpcOhUioPgSrxkO4C8X = State_Output_90;
                this.__p_DePkTYuokNyLpjnZCSEsLh = this.__p_DePkTYuokNyLpjnZCSEsLh;
                this.__p_RXYspH49pTUPY59Q5ELaE3 = Output_97;
                this.__p_AWPP9NmBEsSPEZwWyWxim8 = State_Output_104;
                this.__p_IH6pxwZSh1qPYIOjUJVLYx = State_Output_118;
                this.__p_I2X9mE0xUf5MjMshDBZjXM = Output_129;
            }

            return that_134;
        }

        public n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe __Create__(n1.NodeContext Node_Context)
        {
            n24.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "IH6pxwZSh1qPYIOjUJVLYx", 314578U);
            n3.RectangleF Bounds_1 = __c_GNx6dLQT3hgPLq0SpZyCh1;
            bool Bound_to_Document_2 = false;
            bool Dialog_If_Document_Changed_3 = false;
            bool Save_Bounds_4 = true;
            n25.PixelFormat Back_Buffer_Format_5 = n1.CompilationHelper.Deserialize<n25.PixelFormat>("R8G8B8A8_UNorm_SRgb", false, null, null);
            n25.PixelFormat Depth_Buffer_Format_6 = n1.CompilationHelper.Deserialize<n25.PixelFormat>("D24_UNorm_S8_UInt", false, null, null);
            var Output_7 = n26.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k.Create(Node_Context: Node_Context_0, Bounds_In: Bounds_1, Bound_to_Document_In: Bound_to_Document_2, Dialog_If_Document_Changed_In: Dialog_If_Document_Changed_3, Save_Bounds_In: Save_Bounds_4, Back_Buffer_Format_In: Back_Buffer_Format_5, Depth_Buffer_Format_In: Depth_Buffer_Format_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "K3KQpcOhUioPgSrxkO4C8X", 314593U);
            var Output_9 = n26.RootScene_GcBzJdp7uHFN7DqiDqkHlb.Create(Node_Context: Node_Context_8);
            var node_10 = n1.CompilationHelper.CreateNodeById(Node_Context, "Emissive", "Stride.Materials.ShadingAttributes");
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "GtE3SRD0l67PPMD3tR7Yk3", 314619U);
            var Output_12 = n27.ColorMap_KOxQ1z1ZXvlODfQvuwEtGx.Create(Node_Context: Node_Context_11);
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "OnshscpT9JwPOvREOUyCqX", 314626U);
            var Output_14 = n28.PBRMaterial_Metallic_FiHTnsXENg8Pe4uJCxGwGT.Create(Node_Context: Node_Context_13);
            n1.NodeContext Node_Context_15 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "ST6vfERwyI6LVi6c6j8xqr", 314640U);
            var Output_16 = n27.ValueMap_MSDYzfiuxQTMHIqVDSqrQu.Create(Node_Context: Node_Context_15);
            n1.NodeContext Node_Context_17 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "ERkRanxvitmLzn4m9aC7dO", 314646U);
            var Output_18 = n29.Sphere_C.Create(Node_Context: Node_Context_17);
            n1.NodeContext Node_Context_19 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "AWPP9NmBEsSPEZwWyWxim8", 314657U);
            var Output_20 = n22.PostFX_C.Create(Node_Context: Node_Context_19);
            var node_21 = n1.CompilationHelper.CreateNodeById(Node_Context, "Bloom", "Stride.Rendering.PostFX");
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "Bfr5HYSsZP7LzIkGCfTtKJ", 317243U);
            var Output_23 = n30.FileTexture_VHk2U8mzzVePYWKVz5dr4z.Create(Node_Context: Node_Context_22);
            n1.NodeContext Node_Context_24 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "I2X9mE0xUf5MjMshDBZjXM", 326569U);
            n32.IFrameClock Clock_25 = n31._Operations_.CreateDefault();
            var Output_26 = n33.LFO_F48sA9CC7kzM1Y1LIpWRrD.Create(Node_Context: Node_Context_24, Clock_In: Clock_25);
            n1.NodeContext Node_Context_27 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "LFGKDhTXHAMMxaYMlzdHdi", 327894U);
            n32.IFrameClock Clock_28 = n31._Operations_.CreateDefault();
            var Output_29 = n33.LFO_F48sA9CC7kzM1Y1LIpWRrD.Create(Node_Context: Node_Context_27, Clock_In: Clock_28);
            n1.NodeContext Node_Context_30 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "RXYspH49pTUPY59Q5ELaE3", 331562U);
            n32.IFrameClock Clock_31 = n31._Operations_.CreateDefault();
            var Output_32 = n33.LFO_F48sA9CC7kzM1Y1LIpWRrD.Create(Node_Context: Node_Context_30, Clock_In: Clock_31);
            n1.NodeContext Node_Context_33 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "Ec9scCf8vbvMnZgY3Ql0Av", 339231U);
            var Output_34 = n34.SkyboxLight_C.Create(Node_Context: Node_Context_33);
            n1.NodeContext Node_Context_35 = Node_Context.CreateSubContext("KYrBT1ndOH9MqXl8wdSpYV", "U0OkmtJOnXTPgwmTNjmrvE", 339758U);
            var Output_36 = n30.FileTexture_VHk2U8mzzVePYWKVz5dr4z.Create(Node_Context: Node_Context_35);
            n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe that_37 = this;
            this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = n17._Operations_.CreateDefault<n10.Entity>();
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
            this.__p_Ec9scCf8vbvMnZgY3Ql0Av = Output_34;
            this.__p_U0OkmtJOnXTPgwmTNjmrvE = Output_36;
            return that_37;
        }

        public n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe __CreateDefault__()
        {
            n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe that_0 = this;
            this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = n17._Operations_.CreateDefault<n10.Entity>();
            this.__p_U0OkmtJOnXTPgwmTNjmrvE = n30.FileTexture_VHk2U8mzzVePYWKVz5dr4z.CreateDefault();
            this.__p_Ec9scCf8vbvMnZgY3Ql0Av = n34.SkyboxLight_C.CreateDefault();
            this.__p_LFGKDhTXHAMMxaYMlzdHdi = n33.LFO_F48sA9CC7kzM1Y1LIpWRrD.CreateDefault();
            this.__p_ERkRanxvitmLzn4m9aC7dO = n29.Sphere_C.CreateDefault();
            this.__p_Bfr5HYSsZP7LzIkGCfTtKJ = n30.FileTexture_VHk2U8mzzVePYWKVz5dr4z.CreateDefault();
            this.__p_GtE3SRD0l67PPMD3tR7Yk3 = n27.ColorMap_KOxQ1z1ZXvlODfQvuwEtGx.CreateDefault();
            this.__p_DQ0002lcFvpOxWQbfChKsz = default(n1.IVLNode);
            this.__p_ST6vfERwyI6LVi6c6j8xqr = n27.ValueMap_MSDYzfiuxQTMHIqVDSqrQu.CreateDefault();
            this.__p_OnshscpT9JwPOvREOUyCqX = n28.PBRMaterial_Metallic_FiHTnsXENg8Pe4uJCxGwGT.CreateDefault();
            this.__p_K3KQpcOhUioPgSrxkO4C8X = n26.RootScene_GcBzJdp7uHFN7DqiDqkHlb.CreateDefault();
            this.__p_DePkTYuokNyLpjnZCSEsLh = default(n1.IVLNode);
            this.__p_RXYspH49pTUPY59Q5ELaE3 = n33.LFO_F48sA9CC7kzM1Y1LIpWRrD.CreateDefault();
            this.__p_AWPP9NmBEsSPEZwWyWxim8 = n22.PostFX_C.CreateDefault();
            this.__p_IH6pxwZSh1qPYIOjUJVLYx = n26.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k.CreateDefault();
            this.__p_I2X9mE0xUf5MjMshDBZjXM = n33.LFO_F48sA9CC7kzM1Y1LIpWRrD.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_U0OkmtJOnXTPgwmTNjmrvE);
            n1.CompilationHelper.SafeDispose(this.__p_Ec9scCf8vbvMnZgY3Ql0Av);
            n1.CompilationHelper.SafeDispose(this.__p_LFGKDhTXHAMMxaYMlzdHdi);
            n1.CompilationHelper.SafeDispose(this.__p_ERkRanxvitmLzn4m9aC7dO);
            n1.CompilationHelper.SafeDispose(this.__p_Bfr5HYSsZP7LzIkGCfTtKJ);
            n1.CompilationHelper.SafeDispose(this.__p_GtE3SRD0l67PPMD3tR7Yk3);
            n1.CompilationHelper.SafeDispose(this.__p_DQ0002lcFvpOxWQbfChKsz);
            n1.CompilationHelper.SafeDispose(this.__p_ST6vfERwyI6LVi6c6j8xqr);
            n1.CompilationHelper.SafeDispose(this.__p_OnshscpT9JwPOvREOUyCqX);
            n1.CompilationHelper.SafeDispose(this.__p_K3KQpcOhUioPgSrxkO4C8X);
            n1.CompilationHelper.SafeDispose(this.__p_DePkTYuokNyLpjnZCSEsLh);
            n1.CompilationHelper.SafeDispose(this.__p_RXYspH49pTUPY59Q5ELaE3);
            n1.CompilationHelper.SafeDispose(this.__p_AWPP9NmBEsSPEZwWyWxim8);
            n1.CompilationHelper.SafeDispose(this.__p_IH6pxwZSh1qPYIOjUJVLYx);
            n1.CompilationHelper.SafeDispose(this.__p_I2X9mE0xUf5MjMshDBZjXM);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 314625U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "QvfgDEapxguOHsgsbrdfhQ", Name = "__slot_QvfgDEapxguOHsgsbrdfhQ")]
        public static n3.Color4 __slot_QvfgDEapxguOHsgsbrdfhQ = n1.CompilationHelper.Deserialize<n3.Color4>("0.88, 0.5632, 0.088, 1", false, "KYrBT1ndOH9MqXl8wdSpYV", "QvfgDEapxguOHsgsbrdfhQ");
        [n1.ElementAttribute(TracingId = 320809U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "LJj6ofOvFTPQaRa9qlcpP8", Name = "__slot_LJj6ofOvFTPQaRa9qlcpP8")]
        public static n3.Vector3 __slot_LJj6ofOvFTPQaRa9qlcpP8 = n1.CompilationHelper.Deserialize<n3.Vector3>("0, 1, 0", false, "KYrBT1ndOH9MqXl8wdSpYV", "LJj6ofOvFTPQaRa9qlcpP8");
        [n1.ElementAttribute(TracingId = 324163U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "EPUeJfqUMHMQXuL2EKfkRt", Name = "__slot_EPUeJfqUMHMQXuL2EKfkRt")]
        public static float __slot_EPUeJfqUMHMQXuL2EKfkRt = -1F;
        [n1.ElementAttribute(TracingId = 324791U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Dr5eyJso53sNHfmfwIorSU", Name = "__slot_Dr5eyJso53sNHfmfwIorSU")]
        public static float __slot_Dr5eyJso53sNHfmfwIorSU = 1F;
        [n1.ElementAttribute(TracingId = 325419U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "G2SngEuROj3OjpqJ381uPg", Name = "__slot_G2SngEuROj3OjpqJ381uPg")]
        public static float __slot_G2SngEuROj3OjpqJ381uPg = 1.45F;
        [n1.ElementAttribute(TracingId = 326047U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "BfGf5Xs3RVFOZxZABBVsSo", Name = "__slot_BfGf5Xs3RVFOZxZABBVsSo")]
        public static float __slot_BfGf5Xs3RVFOZxZABBVsSo = 1.8F;
        [n1.ElementAttribute(TracingId = 328934U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "MIbLpkqshZzOgbhPCvqbnI", Name = "__slot_MIbLpkqshZzOgbhPCvqbnI")]
        public static float __slot_MIbLpkqshZzOgbhPCvqbnI = 60F;
        [n1.ElementAttribute(TracingId = 329850U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "IGkMiifOOukPySqcXHucq9", Name = "__slot_IGkMiifOOukPySqcXHucq9")]
        public static float __slot_IGkMiifOOukPySqcXHucq9 = 3F;
        [n1.ElementAttribute(TracingId = 333134U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Im0kbKlxiapQJVu62daFTD", Name = "__slot_Im0kbKlxiapQJVu62daFTD")]
        public static float __slot_Im0kbKlxiapQJVu62daFTD = -1F;
        [n1.ElementAttribute(TracingId = 333852U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "IiRyUXU8UOXLLYgfKoAmvi", Name = "__slot_IiRyUXU8UOXLLYgfKoAmvi")]
        public static float __slot_IiRyUXU8UOXLLYgfKoAmvi = 1F;
        [n1.ElementAttribute(TracingId = 334570U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "TwJlA2dszaCPagj5CLaBlJ", Name = "__slot_TwJlA2dszaCPagj5CLaBlJ")]
        public static float __slot_TwJlA2dszaCPagj5CLaBlJ = 2F;
        [n1.ElementAttribute(TracingId = 335288U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Gt5u29j3RK6PR8FvXPCAUi", Name = "__slot_Gt5u29j3RK6PR8FvXPCAUi")]
        public static float __slot_Gt5u29j3RK6PR8FvXPCAUi = 2.6F;
        [n1.ElementAttribute(TracingId = 336366U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "UxxedL043pjOC95XRxn7eR", Name = "__slot_UxxedL043pjOC95XRxn7eR")]
        public static float __slot_UxxedL043pjOC95XRxn7eR = 4F;
        [n1.ElementAttribute(TracingId = 337084U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "GAF7PE77ztCQSKS8FZbD2v", Name = "__slot_GAF7PE77ztCQSKS8FZbD2v")]
        public static float __slot_GAF7PE77ztCQSKS8FZbD2v = 25F;
        [n1.ElementAttribute(TracingId = 341070U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Su9eu5EQnKcNqYZ9i6ylZX", Name = "__slot_Su9eu5EQnKcNqYZ9i6ylZX")]
        public static string __slot_Su9eu5EQnKcNqYZ9i6ylZX = "Sun";
        [n1.ElementAttribute(TracingId = 342114U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "EC4TvsaMoPIMxRt28NC4F0", Name = "__slot_EC4TvsaMoPIMxRt28NC4F0")]
        public static float __slot_EC4TvsaMoPIMxRt28NC4F0 = 0F;
        [n1.ElementAttribute(TracingId = 339758U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "U0OkmtJOnXTPgwmTNjmrvE", Name = "FileTexture", IsManaged = true, IsAutoGenerated = true)]
        public n30.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_U0OkmtJOnXTPgwmTNjmrvE;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.Path __c_BnrnhRkobFHPoWPxN1Xxg8 = n1.CompilationHelper.Deserialize<n6.Path>("..\\..\\..\\..\\Desktop\\Skybox.webp", false, "KYrBT1ndOH9MqXl8wdSpYV", "BnrnhRkobFHPoWPxN1Xxg8");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.AlphaFormat __c_Bc4QQHV78TgLZjk7mEkrPb = n1.CompilationHelper.Deserialize<n7.AlphaFormat>("Auto", false, "KYrBT1ndOH9MqXl8wdSpYV", "Bc4QQHV78TgLZjk7mEkrPb");
        [n1.ElementAttribute(TracingId = 339231U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Ec9scCf8vbvMnZgY3Ql0Av", Name = "SkyboxLight", IsManaged = true, IsAutoGenerated = true)]
        public n34.SkyboxLight_C __p_Ec9scCf8vbvMnZgY3Ql0Av;
        [n1.ElementAttribute(TracingId = 327894U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "LFGKDhTXHAMMxaYMlzdHdi", Name = "LFO", IsManaged = true, IsAutoGenerated = true)]
        public n33.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_LFGKDhTXHAMMxaYMlzdHdi;
        [n1.ElementAttribute(TracingId = 314646U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "ERkRanxvitmLzn4m9aC7dO", Name = "Sphere", IsManaged = true, IsAutoGenerated = true)]
        public n29.Sphere_C __p_ERkRanxvitmLzn4m9aC7dO;
        [n1.ElementAttribute(TracingId = 317243U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "Bfr5HYSsZP7LzIkGCfTtKJ", Name = "FileTexture", IsManaged = true, IsAutoGenerated = true)]
        public n30.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_Bfr5HYSsZP7LzIkGCfTtKJ;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.Path __c_UlO3Efn87NJQKsbm4PZlok = n1.CompilationHelper.Deserialize<n6.Path>("..\\..\\..\\..\\Desktop\\2k_sun.jpg", false, "KYrBT1ndOH9MqXl8wdSpYV", "UlO3Efn87NJQKsbm4PZlok");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.AlphaFormat __c_VaUJ2yQ5QlcPIyddkiszNb = n1.CompilationHelper.Deserialize<n7.AlphaFormat>("Auto", false, "KYrBT1ndOH9MqXl8wdSpYV", "VaUJ2yQ5QlcPIyddkiszNb");
        [n1.ElementAttribute(TracingId = 314619U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "GtE3SRD0l67PPMD3tR7Yk3", Name = "ColorMap", IsManaged = true, IsAutoGenerated = true)]
        public n27.ColorMap_KOxQ1z1ZXvlODfQvuwEtGx __p_GtE3SRD0l67PPMD3tR7Yk3;
        [n1.ElementAttribute(TracingId = 314600U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "DQ0002lcFvpOxWQbfChKsz", Name = "Emissive", IsManaged = true, IsAutoGenerated = true, NodeName = "Emissive", NodeCategory = "Stride.Materials.ShadingAttributes")]
        public n1.IVLNode __p_DQ0002lcFvpOxWQbfChKsz;
        [n1.ElementAttribute(TracingId = 314640U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "ST6vfERwyI6LVi6c6j8xqr", Name = "ValueMap", IsManaged = true, IsAutoGenerated = true)]
        public n27.ValueMap_MSDYzfiuxQTMHIqVDSqrQu __p_ST6vfERwyI6LVi6c6j8xqr;
        [n1.ElementAttribute(TracingId = 314626U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "OnshscpT9JwPOvREOUyCqX", Name = "PBRMaterial (Metallic)", IsManaged = true, IsAutoGenerated = true)]
        public n28.PBRMaterial_Metallic_FiHTnsXENg8Pe4uJCxGwGT __p_OnshscpT9JwPOvREOUyCqX;
        [n1.ElementAttribute(TracingId = 314593U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "K3KQpcOhUioPgSrxkO4C8X", Name = "RootScene", IsManaged = true, IsAutoGenerated = true)]
        public n26.RootScene_GcBzJdp7uHFN7DqiDqkHlb __p_K3KQpcOhUioPgSrxkO4C8X;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n18.Spread<n10.Entity> __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = default(n18.Spread<n10.Entity>);
        [n1.ElementAttribute(TracingId = 314671U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "DePkTYuokNyLpjnZCSEsLh", Name = "Bloom", IsManaged = true, IsAutoGenerated = true, NodeName = "Bloom", NodeCategory = "Stride.Rendering.PostFX")]
        public n1.IVLNode __p_DePkTYuokNyLpjnZCSEsLh;
        [n1.ElementAttribute(TracingId = 331562U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "RXYspH49pTUPY59Q5ELaE3", Name = "LFO", IsManaged = true, IsAutoGenerated = true)]
        public n33.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_RXYspH49pTUPY59Q5ELaE3;
        [n1.ElementAttribute(TracingId = 314657U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "AWPP9NmBEsSPEZwWyWxim8", Name = "PostFX", IsManaged = true, IsAutoGenerated = true)]
        public n22.PostFX_C __p_AWPP9NmBEsSPEZwWyWxim8;
        [n1.ElementAttribute(TracingId = 314578U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "IH6pxwZSh1qPYIOjUJVLYx", Name = "SceneWindow", IsManaged = true, IsAutoGenerated = true)]
        public n26.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k __p_IH6pxwZSh1qPYIOjUJVLYx;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.Color4 __c_JEl7pDETGAvNkXUCGrl3dv = n1.CompilationHelper.Deserialize<n3.Color4>("0.09529408, 0.09529408, 0.09529408, 1", false, "KYrBT1ndOH9MqXl8wdSpYV", "JEl7pDETGAvNkXUCGrl3dv");
        [n1.ElementAttribute(TracingId = 326569U, DocumentId = "KYrBT1ndOH9MqXl8wdSpYV", PersistentId = "I2X9mE0xUf5MjMshDBZjXM", Name = "LFO", IsManaged = true, IsAutoGenerated = true)]
        public n33.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_I2X9mE0xUf5MjMshDBZjXM;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.RectangleF __c_GNx6dLQT3hgPLq0SpZyCh1 = n1.CompilationHelper.Deserialize<n3.RectangleF>("1070, 200, 786, 432", false, "KYrBT1ndOH9MqXl8wdSpYV", "GNx6dLQT3hgPLq0SpZyCh1");
        static SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe()
        {
        }

        public SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe(SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe other): base(other)
        {
            this.__p_U0OkmtJOnXTPgwmTNjmrvE = other.__p_U0OkmtJOnXTPgwmTNjmrvE;
            this.__p_Ec9scCf8vbvMnZgY3Ql0Av = other.__p_Ec9scCf8vbvMnZgY3Ql0Av;
            this.__p_LFGKDhTXHAMMxaYMlzdHdi = other.__p_LFGKDhTXHAMMxaYMlzdHdi;
            this.__p_ERkRanxvitmLzn4m9aC7dO = other.__p_ERkRanxvitmLzn4m9aC7dO;
            this.__p_Bfr5HYSsZP7LzIkGCfTtKJ = other.__p_Bfr5HYSsZP7LzIkGCfTtKJ;
            this.__p_GtE3SRD0l67PPMD3tR7Yk3 = other.__p_GtE3SRD0l67PPMD3tR7Yk3;
            this.__p_DQ0002lcFvpOxWQbfChKsz = other.__p_DQ0002lcFvpOxWQbfChKsz;
            this.__p_ST6vfERwyI6LVi6c6j8xqr = other.__p_ST6vfERwyI6LVi6c6j8xqr;
            this.__p_OnshscpT9JwPOvREOUyCqX = other.__p_OnshscpT9JwPOvREOUyCqX;
            this.__p_K3KQpcOhUioPgSrxkO4C8X = other.__p_K3KQpcOhUioPgSrxkO4C8X;
            this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = other.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X;
            this.__p_DePkTYuokNyLpjnZCSEsLh = other.__p_DePkTYuokNyLpjnZCSEsLh;
            this.__p_RXYspH49pTUPY59Q5ELaE3 = other.__p_RXYspH49pTUPY59Q5ELaE3;
            this.__p_AWPP9NmBEsSPEZwWyWxim8 = other.__p_AWPP9NmBEsSPEZwWyWxim8;
            this.__p_IH6pxwZSh1qPYIOjUJVLYx = other.__p_IH6pxwZSh1qPYIOjUJVLYx;
            this.__p_I2X9mE0xUf5MjMshDBZjXM = other.__p_I2X9mE0xUf5MjMshDBZjXM;
        }

        protected override n1.IVLObject __With__(n35.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_U0OkmtJOnXTPgwmTNjmrvE", in __p_U0OkmtJOnXTPgwmTNjmrvE), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ec9scCf8vbvMnZgY3Ql0Av", in __p_Ec9scCf8vbvMnZgY3Ql0Av), n1.CompilationHelper.GetValueOrExisting(values, "__p_LFGKDhTXHAMMxaYMlzdHdi", in __p_LFGKDhTXHAMMxaYMlzdHdi), n1.CompilationHelper.GetValueOrExisting(values, "__p_ERkRanxvitmLzn4m9aC7dO", in __p_ERkRanxvitmLzn4m9aC7dO), n1.CompilationHelper.GetValueOrExisting(values, "__p_Bfr5HYSsZP7LzIkGCfTtKJ", in __p_Bfr5HYSsZP7LzIkGCfTtKJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_GtE3SRD0l67PPMD3tR7Yk3", in __p_GtE3SRD0l67PPMD3tR7Yk3), n1.CompilationHelper.GetValueOrExisting(values, "__p_DQ0002lcFvpOxWQbfChKsz", in __p_DQ0002lcFvpOxWQbfChKsz), n1.CompilationHelper.GetValueOrExisting(values, "__p_ST6vfERwyI6LVi6c6j8xqr", in __p_ST6vfERwyI6LVi6c6j8xqr), n1.CompilationHelper.GetValueOrExisting(values, "__p_OnshscpT9JwPOvREOUyCqX", in __p_OnshscpT9JwPOvREOUyCqX), n1.CompilationHelper.GetValueOrExisting(values, "__p_K3KQpcOhUioPgSrxkO4C8X", in __p_K3KQpcOhUioPgSrxkO4C8X), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X", in __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X), n1.CompilationHelper.GetValueOrExisting(values, "__p_DePkTYuokNyLpjnZCSEsLh", in __p_DePkTYuokNyLpjnZCSEsLh), n1.CompilationHelper.GetValueOrExisting(values, "__p_RXYspH49pTUPY59Q5ELaE3", in __p_RXYspH49pTUPY59Q5ELaE3), n1.CompilationHelper.GetValueOrExisting(values, "__p_AWPP9NmBEsSPEZwWyWxim8", in __p_AWPP9NmBEsSPEZwWyWxim8), n1.CompilationHelper.GetValueOrExisting(values, "__p_IH6pxwZSh1qPYIOjUJVLYx", in __p_IH6pxwZSh1qPYIOjUJVLYx), n1.CompilationHelper.GetValueOrExisting(values, "__p_I2X9mE0xUf5MjMshDBZjXM", in __p_I2X9mE0xUf5MjMshDBZjXM));
        }

        internal SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe __WITH__(n30.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_U0OkmtJOnXTPgwmTNjmrvE, n34.SkyboxLight_C __p_Ec9scCf8vbvMnZgY3Ql0Av, n33.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_LFGKDhTXHAMMxaYMlzdHdi, n29.Sphere_C __p_ERkRanxvitmLzn4m9aC7dO, n30.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_Bfr5HYSsZP7LzIkGCfTtKJ, n27.ColorMap_KOxQ1z1ZXvlODfQvuwEtGx __p_GtE3SRD0l67PPMD3tR7Yk3, n1.IVLNode __p_DQ0002lcFvpOxWQbfChKsz, n27.ValueMap_MSDYzfiuxQTMHIqVDSqrQu __p_ST6vfERwyI6LVi6c6j8xqr, n28.PBRMaterial_Metallic_FiHTnsXENg8Pe4uJCxGwGT __p_OnshscpT9JwPOvREOUyCqX, n26.RootScene_GcBzJdp7uHFN7DqiDqkHlb __p_K3KQpcOhUioPgSrxkO4C8X, n18.Spread<n10.Entity> __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X, n1.IVLNode __p_DePkTYuokNyLpjnZCSEsLh, n33.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_RXYspH49pTUPY59Q5ELaE3, n22.PostFX_C __p_AWPP9NmBEsSPEZwWyWxim8, n26.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k __p_IH6pxwZSh1qPYIOjUJVLYx, n33.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_I2X9mE0xUf5MjMshDBZjXM)
        {
            n4.SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_U0OkmtJOnXTPgwmTNjmrvE != this.__p_U0OkmtJOnXTPgwmTNjmrvE || __p_Ec9scCf8vbvMnZgY3Ql0Av != this.__p_Ec9scCf8vbvMnZgY3Ql0Av || __p_LFGKDhTXHAMMxaYMlzdHdi != this.__p_LFGKDhTXHAMMxaYMlzdHdi || __p_ERkRanxvitmLzn4m9aC7dO != this.__p_ERkRanxvitmLzn4m9aC7dO || __p_Bfr5HYSsZP7LzIkGCfTtKJ != this.__p_Bfr5HYSsZP7LzIkGCfTtKJ || __p_GtE3SRD0l67PPMD3tR7Yk3 != this.__p_GtE3SRD0l67PPMD3tR7Yk3 || __p_DQ0002lcFvpOxWQbfChKsz != this.__p_DQ0002lcFvpOxWQbfChKsz || __p_ST6vfERwyI6LVi6c6j8xqr != this.__p_ST6vfERwyI6LVi6c6j8xqr || __p_OnshscpT9JwPOvREOUyCqX != this.__p_OnshscpT9JwPOvREOUyCqX || __p_K3KQpcOhUioPgSrxkO4C8X != this.__p_K3KQpcOhUioPgSrxkO4C8X || __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X != this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X || __p_DePkTYuokNyLpjnZCSEsLh != this.__p_DePkTYuokNyLpjnZCSEsLh || __p_RXYspH49pTUPY59Q5ELaE3 != this.__p_RXYspH49pTUPY59Q5ELaE3 || __p_AWPP9NmBEsSPEZwWyWxim8 != this.__p_AWPP9NmBEsSPEZwWyWxim8 || __p_IH6pxwZSh1qPYIOjUJVLYx != this.__p_IH6pxwZSh1qPYIOjUJVLYx || __p_I2X9mE0xUf5MjMshDBZjXM != this.__p_I2X9mE0xUf5MjMshDBZjXM ? new SolarSystemApplication_EnZiuY2Vb0QLrZO1M4x3Xe(this)
                {__p_U0OkmtJOnXTPgwmTNjmrvE = __p_U0OkmtJOnXTPgwmTNjmrvE, __p_Ec9scCf8vbvMnZgY3Ql0Av = __p_Ec9scCf8vbvMnZgY3Ql0Av, __p_LFGKDhTXHAMMxaYMlzdHdi = __p_LFGKDhTXHAMMxaYMlzdHdi, __p_ERkRanxvitmLzn4m9aC7dO = __p_ERkRanxvitmLzn4m9aC7dO, __p_Bfr5HYSsZP7LzIkGCfTtKJ = __p_Bfr5HYSsZP7LzIkGCfTtKJ, __p_GtE3SRD0l67PPMD3tR7Yk3 = __p_GtE3SRD0l67PPMD3tR7Yk3, __p_DQ0002lcFvpOxWQbfChKsz = __p_DQ0002lcFvpOxWQbfChKsz, __p_ST6vfERwyI6LVi6c6j8xqr = __p_ST6vfERwyI6LVi6c6j8xqr, __p_OnshscpT9JwPOvREOUyCqX = __p_OnshscpT9JwPOvREOUyCqX, __p_K3KQpcOhUioPgSrxkO4C8X = __p_K3KQpcOhUioPgSrxkO4C8X, __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X, __p_DePkTYuokNyLpjnZCSEsLh = __p_DePkTYuokNyLpjnZCSEsLh, __p_RXYspH49pTUPY59Q5ELaE3 = __p_RXYspH49pTUPY59Q5ELaE3, __p_AWPP9NmBEsSPEZwWyWxim8 = __p_AWPP9NmBEsSPEZwWyWxim8, __p_IH6pxwZSh1qPYIOjUJVLYx = __p_IH6pxwZSh1qPYIOjUJVLYx, __p_I2X9mE0xUf5MjMshDBZjXM = __p_I2X9mE0xUf5MjMshDBZjXM} : that_0;
            else
            {
                this.__p_U0OkmtJOnXTPgwmTNjmrvE = __p_U0OkmtJOnXTPgwmTNjmrvE;
                this.__p_Ec9scCf8vbvMnZgY3Ql0Av = __p_Ec9scCf8vbvMnZgY3Ql0Av;
                this.__p_LFGKDhTXHAMMxaYMlzdHdi = __p_LFGKDhTXHAMMxaYMlzdHdi;
                this.__p_ERkRanxvitmLzn4m9aC7dO = __p_ERkRanxvitmLzn4m9aC7dO;
                this.__p_Bfr5HYSsZP7LzIkGCfTtKJ = __p_Bfr5HYSsZP7LzIkGCfTtKJ;
                this.__p_GtE3SRD0l67PPMD3tR7Yk3 = __p_GtE3SRD0l67PPMD3tR7Yk3;
                this.__p_DQ0002lcFvpOxWQbfChKsz = __p_DQ0002lcFvpOxWQbfChKsz;
                this.__p_ST6vfERwyI6LVi6c6j8xqr = __p_ST6vfERwyI6LVi6c6j8xqr;
                this.__p_OnshscpT9JwPOvREOUyCqX = __p_OnshscpT9JwPOvREOUyCqX;
                this.__p_K3KQpcOhUioPgSrxkO4C8X = __p_K3KQpcOhUioPgSrxkO4C8X;
                this.__pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X = __pin_group_Child_In_K3KQpcOhUioPgSrxkO4C8X;
                this.__p_DePkTYuokNyLpjnZCSEsLh = __p_DePkTYuokNyLpjnZCSEsLh;
                this.__p_RXYspH49pTUPY59Q5ELaE3 = __p_RXYspH49pTUPY59Q5ELaE3;
                this.__p_AWPP9NmBEsSPEZwWyWxim8 = __p_AWPP9NmBEsSPEZwWyWxim8;
                this.__p_IH6pxwZSh1qPYIOjUJVLYx = __p_IH6pxwZSh1qPYIOjUJVLYx;
                this.__p_I2X9mE0xUf5MjMshDBZjXM = __p_I2X9mE0xUf5MjMshDBZjXM;
            }

            return that_0;
        }
    }
}

namespace _SolarSystem_
{
    public struct __AdaptiveImplementations__KYrBT1ndOH9MqXl8wdSpYV : n36.IAdaptiveOperatorMulitply<float>, n36.IAdaptiveOperatorDivide<float>, n36.IAdaptiveOperatorPlus<float>, n36.IAdaptiveOperatorMinus<float>
    {
        public void OperatorMulitply(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In * Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = (float)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorPlus(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In + Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorMinus(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In - Input_2_In;
            Output_Out = Output_0;
            return;
        }
    }
}