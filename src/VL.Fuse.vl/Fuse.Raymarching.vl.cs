extern alias e24;
extern alias e31;
extern alias e3;
extern alias e2;
extern alias e71;
extern alias e29;
extern alias e4;

using n30 = _VL_Stride_Rendering_.Stride.Rendering;
using n5 = e2::VL.Lib.Collections;
using n10 = e3::VL.Lib.Primitive.CacheRegion;
using n38 = _CoreLibBasics_.Primitive.Object.Advanced;
using n6 = _Fuse_Raymarching_;
using n7 = _CoreLibBasics_.Control;
using n23 = _VL_Collections_.Collections.Dictionary;
using n22 = global::System.Collections.Immutable;
using n8 = e71::Fuse;
using n18 = _Fuse_Core_.Fuse.Core.DrawShader;
using n16 = e71::Fuse.sdf;
using n34 = e31::VL.Stride.Shaders.ShaderFX;
using n41 = _CoreLibBasics_.Primitive.String;
using n35 = e71::Fuse.ShaderFX;
using n14 = _Fuse_Core_.Fuse.Core.Function;
using n11 = global::System.Collections.Generic;
using n31 = _VL_Stride_Engine_.Stride.Rendering;
using n43 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n19 = _Fuse_Core_Math_.Fuse.Core.Math;
using n3 = _Fuse_Raymarching_.Fuse.Raymarching;
using n28 = e24::Stride.Engine;
using n32 = _Fuse_Core_.Fuse.Core.StrideIntegration;
using n15 = _Fuse_Raymarching_.Fuse.Raymarching.Internal;
using n33 = _VL_Stride_Engine_.Stride.Models;
using n1 = e2::VL.Core;
using n26 = e31::VL.Stride.Rendering;
using n13 = _Fuse_Core_.Fuse.Core.Value;
using n25 = _VL_Stride_Rendering_ShaderFX_.Stride.Rendering.Experimental;
using n2 = global::System;
using n9 = e4::Stride.Core.Mathematics;
using n39 = e3::VL.Lib.Primitive.Object;
using n4 = e2::VL.Core.CompilerServices;
using n17 = _Fuse_Core_Color_.Fuse.Core.Color;
using n12 = _Fuse_Core_.Fuse.Core.Implementation;
using n27 = e29::Stride.Rendering;
using n37 = _Fuse_Core_.Fuse.Core.Util;
using n24 = _VL_Collections_.Collections.Sequence;
using n29 = global::System.Runtime.CompilerServices;
using n20 = _Fuse_Core_.Fuse.Core.Conversion;
using n21 = _VL_Collections_.Collections.Spread;
using n42 = _CoreLibBasics_.Primitive.Advanced;
using n36 = e29::Stride.Rendering.Materials;
using n40 = _CoreLibBasics_._3D.Vector3;

namespace _Fuse_Raymarching_.Fuse.Raymarching
{
    [n1.ElementAttribute(TracingId = 326748U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "G1rmTuYo917LHCEFh32ucW", Name = "RayMarch_Basic_G1rmTuYo917LHCEFh32ucW")]
    [n2.SerializableAttribute]
    public class RayMarch_Basic_G1rmTuYo917LHCEFh32ucW : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.RayMarch_Basic_G1rmTuYo917LHCEFh32ucW Create(n1.NodeContext Node_Context)
        {
            var instance = new RayMarch_Basic_G1rmTuYo917LHCEFh32ucW(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.RayMarch_Basic_G1rmTuYo917LHCEFh32ucW CreateDefault()
        {
            var instance = new RayMarch_Basic_G1rmTuYo917LHCEFh32ucW(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.RayMarch_Basic_G1rmTuYo917LHCEFh32ucW Update(n8.GpuValue<float> SDFT_In, [n4.SerializedDefaultValueAttribute("True", false)] bool AutoCompile_In, [n4.SerializedDefaultValueAttribute("180", false)] int Max_Iterations_In, [n4.SerializedDefaultValueAttribute("0.92, 0.36, 0.05, 1", false)] n8.GpuValue<n9.Vector4> Color_In, n9.Vector3 Bounding_Box_Position_In, [n4.SerializedDefaultValueAttribute("10, 10, 10", false)] n9.Vector3 Bounding_Box_Size_In, bool Show_Normals_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n28.Entity Output_Out, out string lastError_Out, out string Shader_Code_Out)
        {
            string __pad_T7QMxKwPMKnOVIqoTYE0iL_0 = __slot_T7QMxKwPMKnOVIqoTYE0iL;
            string __pad_AEqrniIISbzPVPNlSN5K8X_1 = __slot_AEqrniIISbzPVPNlSN5K8X;
            int Index_2 = n2.Convert.ToInt32(Show_Normals_In);
            string Input_3 = "shadeRayGradient(ray, col)";
            string Input_2_4 = "shadeRayNormals(ray, true)";
            var builder_5 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5, 2);
            builder_5.Add(Input_3);
            builder_5.Add(Input_2_4);
            var __pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5_6 = builder_5.Commit();
            n7._Operations_.Switch<string, n6.__AdaptiveImplementations__RGYLe02tPXEQEO6aJ6Qsjm>(Index_In: Index_2, Input_In: __pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5_6, Output_Out: out string Output_7);
            bool Force_8 = false;
            bool Dispose_Cached_Outputs_9 = false;
            var manager_10 = this.__cache_D4PfuRFD0mvLavwU8AWkjq;
            if (manager_10 is null)
            {
                manager_10 = new n10.Manager<n2.ValueTuple<string, n8.GpuValue<float>, int, n8.GpuValue<n9.Vector4>, n9.Vector3, n9.Vector3, string>, n2.ValueTuple<n8.GpuValue<n9.Vector4>, n8.GpuValue<n9.Vector4>>>((default(n8.GpuValue<n9.Vector4>), default(n8.GpuValue<n9.Vector4>)));
            }

            var inputs_11 = (__pad_T7QMxKwPMKnOVIqoTYE0iL_0, SDFT_In, Max_Iterations_In, Color_In, Bounding_Box_Position_In, Bounding_Box_Size_In, Output_7);
            var outputs_12 = manager_10.Outputs;
            var Has_Changed_13 = Force_8 || manager_10.InputsChanged(inputs_11);
            if (Has_Changed_13)
            {
                if (Dispose_Cached_Outputs_9)
                    manager_10.DisposeOutputs();
                var state_14 = n1.CompilationHelper.Restore<__SEn4DAvajL1PniLUyjCFYe>(manager_10.State, __GetContext__());
                if (state_14 == null)
                {
                    state_14 = new __SEn4DAvajL1PniLUyjCFYe(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c = n21._Operations_.CreateDefault<n8.AbstractGpuValue>(), __slot_MUvRyk90XydM4FzbACVFpX = default(n8.GpuValue<n16.Ray>), __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3 = n21._Operations_.CreateDefault<n8.AbstractGpuValue>(), __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd = n21._Operations_.CreateDefault<n8.AbstractGpuValue>(), __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP = n21._Operations_.CreateDefault<n8.IFunctionInvokeNode>(), __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ = n21._Operations_.CreateDefault<string>(), __slot_GasJgtyAFJEQRz0YFqFRyz = "", __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm = n23._Operations_.CreateDefault<string, string>(), __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD = n21._Operations_.CreateDefault<n8.AbstractGpuValue>(), __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa = n21._Operations_.CreateDefault<n8.GpuValue<n9.Vector4>>()};
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "UTGmh8e0IyIOUsVNsoyQvD", 326789U);
                    var Output_16 = n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<n9.Vector4, n11.IEnumerable<n8.InputModifier>>.Create(Node_Context: Node_Context_15);
                    state_14.__p_UTGmh8e0IyIOUsVNsoyQvD = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "NeVxSlOVbiHOgoAk6ghrbd", 326823U);
                    var Output_18 = n13.GPUIn_C<int>.Create(Node_Context: Node_Context_17);
                    state_14.__p_NeVxSlOVbiHOgoAk6ghrbd = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "Roj8OttRNtDPhZ0MULZw4c", 326839U);
                    var Output_20 = n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.Create(Node_Context: Node_Context_19);
                    state_14.__p_Roj8OttRNtDPhZ0MULZw4c = Output_20;
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "LqmhEIdOw4YLN2OxnSVISB", 326850U);
                    var Output_22 = n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt.Create(Node_Context: Node_Context_21);
                    state_14.__p_LqmhEIdOw4YLN2OxnSVISB = Output_22;
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "MbDWeukNgZdMNLkOKO1vJi", 326856U);
                    var Output_24 = n15.CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b.Create(Node_Context: Node_Context_23);
                    state_14.__p_MbDWeukNgZdMNLkOKO1vJi = Output_24;
                    n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "K6UNPLbWcpQOogBuncnIxd", 326867U);
                    var Output_26 = n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<n9.Vector2>.Create(Node_Context: Node_Context_25);
                    state_14.__p_K6UNPLbWcpQOogBuncnIxd = Output_26;
                    n1.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "DQah0MHHty4P0K2g6Cw3U3", 326893U);
                    var Output_28 = n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<n16.Ray>.Create(Node_Context: Node_Context_27);
                    state_14.__p_DQah0MHHty4P0K2g6Cw3U3 = Output_28;
                    n1.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "DtP553iLWVqONSTAm72518", 326903U);
                    var Output_30 = n17.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<n9.Vector4>.Create(Node_Context: Node_Context_29);
                    state_14.__p_DtP553iLWVqONSTAm72518 = Output_30;
                    n1.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "QoN2VDrPbLZMWSyw7SluIQ", 326910U);
                    var Output_32 = n18.Position_PeLDdeSku4ANhU5oe5SfPy.Create(Node_Context: Node_Context_31);
                    state_14.__p_QoN2VDrPbLZMWSyw7SluIQ = Output_32;
                    n1.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "RUaxcSKIx9YNxalNOWUS5R", 326918U);
                    var Output_34 = n13.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n9.Vector4>.Create(Node_Context: Node_Context_33);
                    state_14.__p_RUaxcSKIx9YNxalNOWUS5R = Output_34;
                    n1.NodeContext Node_Context_35 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "QHX6DTMvvHzL0q2tbruhJa", 326923U);
                    var Output_36 = n19.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n9.Vector4>.Create(Node_Context: Node_Context_35);
                    state_14.__p_QHX6DTMvvHzL0q2tbruhJa = Output_36;
                    n1.NodeContext Node_Context_37 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "DJHPMOWIRNBOY6HRKdzjC8", 326936U);
                    var Output_38 = n14.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n9.Vector3>.Create(Node_Context: Node_Context_37);
                    state_14.__p_DJHPMOWIRNBOY6HRKdzjC8 = Output_38;
                }

                string __pad_MZOtJuN48VsP2TRUh6oVol_39 = __slot_MZOtJuN48VsP2TRUh6oVol;
                string __pad_DHQKnol1bOIQRT6KpazYwP_40 = __slot_DHQKnol1bOIQRT6KpazYwP;
                string __pad_EL55wCQ7hJrPgwA8S4Mh2z_41 = __slot_EL55wCQ7hJrPgwA8S4Mh2z;
                string __pad_UyMIOT1340QPgCaqlfZLH3_42 = __slot_UyMIOT1340QPgCaqlfZLH3;
                string __pad_H0R2DwJ6QzqQDkiTQp28qe_43 = __slot_H0R2DwJ6QzqQDkiTQp28qe;
                string __pad_O8T5BCwn1EwPfnANWdwLSI_44 = __slot_O8T5BCwn1EwPfnANWdwLSI;
                n9.Vector4 __pad_QFrWcFnuLTpNapZ0DTo5Pb_45 = __slot_QFrWcFnuLTpNapZ0DTo5Pb;
                var State_Output_47 = state_14.__p_NeVxSlOVbiHOgoAk6ghrbd.Update(Output_Out: out n8.GpuValue<int> Output_46);
                n8.GpuValue<n9.Vector3> Input_48 = default(n8.GpuValue<n9.Vector3>);
                n20._Operations_.TypeVector3(Input_In: Input_48, Output_Out: out n8.GpuValue<n9.Vector3> Output_49);
                int Id_50 = 0;
                var State_Output_52 = state_14.__p_DJHPMOWIRNBOY6HRKdzjC8.Update(The_Override_In: Output_49, Id_In: Id_50, Output_Out: out n8.GpuValue<n9.Vector3> Output_51);
                var builder_53 = n4.CollectionBuilders.GetBuilder(state_14.__pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c, 1);
                builder_53.Add(Output_51);
                var __pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c_54 = builder_53.Commit();
                var State_Output_56 = state_14.__p_Roj8OttRNtDPhZ0MULZw4c.Update(Function_In: SDFT_In, Parameters_In: __pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c_54, Id_In: __pad_EL55wCQ7hJrPgwA8S4Mh2z_41, Output_Out: out n8.FunctionInvokeNode<float> Output_55);
                n8.IFunctionInvokeNode Input_57 = (n8.IFunctionInvokeNode)Output_55;
                var Output_59 = state_14.__p_LqmhEIdOw4YLN2OxnSVISB.Update(Ray_Out: out n8.GpuValue<n16.Ray> Ray_58);
                n8.GpuValue<n16.Ray> __pad_MUvRyk90XydM4FzbACVFpX_60 = Ray_58;
                var builder_61 = n4.CollectionBuilders.GetBuilder(state_14.__pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3, 0);
                var __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3_62 = builder_61.Commit();
                var State_Output_64 = state_14.__p_DQah0MHHty4P0K2g6Cw3U3.Update(Function_In: __pad_MUvRyk90XydM4FzbACVFpX_60, Parameters_In: __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3_62, Id_In: __pad_UyMIOT1340QPgCaqlfZLH3_42, Output_Out: out n8.FunctionInvokeNode<n16.Ray> Output_63);
                n8.IFunctionInvokeNode Input_2_65 = (n8.IFunctionInvokeNode)Output_63;
                n8.GpuValue<n16.Ray> Ray_66 = default(n8.GpuValue<n16.Ray>);
                var Output_68 = state_14.__p_MbDWeukNgZdMNLkOKO1vJi.Update(Ray_In: Ray_66, Position_In: Bounding_Box_Position_In, Size_In: Bounding_Box_Size_In, Cull_Ray_Out: out n8.GpuValue<n9.Vector2> Cull_Ray_67);
                var builder_69 = n4.CollectionBuilders.GetBuilder(state_14.__pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd, 1);
                builder_69.Add(__pad_MUvRyk90XydM4FzbACVFpX_60);
                var __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd_70 = builder_69.Commit();
                var State_Output_72 = state_14.__p_K6UNPLbWcpQOogBuncnIxd.Update(Function_In: Cull_Ray_67, Parameters_In: __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd_70, Id_In: __pad_H0R2DwJ6QzqQDkiTQp28qe_43, Output_Out: out n8.FunctionInvokeNode<n9.Vector2> Output_71);
                n8.IFunctionInvokeNode Input_3_73 = (n8.IFunctionInvokeNode)Output_71;
                var builder_74 = n4.CollectionBuilders.GetBuilder(state_14.__pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP, 3);
                builder_74.Add(Input_57);
                builder_74.Add(Input_2_65);
                builder_74.Add(Input_3_73);
                var __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP_75 = builder_74.Commit();
                n21._Operations_.Cons<n8.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP_75, Result_Out: out n5.Spread<n8.IFunctionInvokeNode> Result_76);
                var builder_77 = n4.CollectionBuilders.GetBuilder(state_14.__pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ, 1);
                builder_77.Add(__pad_MZOtJuN48VsP2TRUh6oVol_39);
                var __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ_78 = builder_77.Commit();
                n21._Operations_.Cons<string>(Input_In: __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ_78, Result_Out: out n5.Spread<string> Result_79);
                n11.IEnumerable<string> Mixins_80 = (n11.IEnumerable<string>)Result_79;
                string __pad_GasJgtyAFJEQRz0YFqFRyz_81 = Output_7;
                var builder_82 = n4.CollectionBuilders.GetBuilder(state_14.__pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm, 2);
                builder_82.Add("MARCH", __pad_O8T5BCwn1EwPfnANWdwLSI_44);
                builder_82.Add("SHADE", __pad_GasJgtyAFJEQRz0YFqFRyz_81);
                var __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm_83 = builder_82.Commit();
                n23._Operations_.Cons<string>(Input_In: __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm_83, Output_Out: out n22.ImmutableDictionary<string, string> Output_84);
                n8.GpuValue<n9.Vector4> Default_Result_85 = default(n8.GpuValue<n9.Vector4>);
                bool Is_Groupable_86 = false;
                n11.IEnumerable<n8.InputModifier> The_Modifiers_87 = n24._Operations_.CreateDefault<n8.InputModifier>();
                var builder_88 = n4.CollectionBuilders.GetBuilder(state_14.__pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD, 2);
                builder_88.Add(Output_46);
                builder_88.Add(Color_In);
                var __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD_89 = builder_88.Commit();
                var State_Output_92 = state_14.__p_UTGmh8e0IyIOUsVNsoyQvD.Update(Arguments_In: __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD_89, Function_Name_In: __pad_DHQKnol1bOIQRT6KpazYwP_40, Code_Template_In: __pad_T7QMxKwPMKnOVIqoTYE0iL_0, Default_Result_In: Default_Result_85, Functions_In: Result_76, Mixins_In: Mixins_80, Template_Values_In: Output_84, Is_Groupable_In: Is_Groupable_86, The_Modifiers_In: The_Modifiers_87, Output_Out: out n8.GpuValue<n9.Vector4> Output_90, AdditionalOutputs_Out: out n5.Spread<n8.AbstractGpuValue> AdditionalOutputs_91);
                bool SetValue_93 = true;
                var Output_94 = State_Output_47;
                if (SetValue_93)
                {
                    Output_94 = State_Output_47.SetValue(Input_In: Max_Iterations_In);
                }

                var Output_96 = state_14.__p_DtP553iLWVqONSTAm72518.Update(sRGB_In: Output_90, RGB_Out: out n8.GpuValue<n9.Vector4> RGB_95);
                var State_Output_98 = state_14.__p_QoN2VDrPbLZMWSyw7SluIQ.Update(Output_Out: out n8.GpuValue<n9.Vector4> Output_97);
                var Output_100 = state_14.__p_RUaxcSKIx9YNxalNOWUS5R.Update(Value_In: __pad_QFrWcFnuLTpNapZ0DTo5Pb_45, GpuValue_Out: out n8.GpuValue<n9.Vector4> GpuValue_99);
                var builder_101 = n4.CollectionBuilders.GetBuilder(state_14.__pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa, 2);
                builder_101.Add(Output_97);
                builder_101.Add(GpuValue_99);
                var __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa_102 = builder_101.Commit();
                var State_Output_104 = state_14.__p_QHX6DTMvvHzL0q2tbruhJa.Update(Input_In: __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa_102, Output_Out: out n8.GpuValue<n9.Vector4> Output_103);
                if (state_14.__GetContext__().IsImmutable)
                    state_14 = Output_94 != state_14.__p_NeVxSlOVbiHOgoAk6ghrbd || State_Output_52 != state_14.__p_DJHPMOWIRNBOY6HRKdzjC8 || __pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c_54 != state_14.__pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c || State_Output_56 != state_14.__p_Roj8OttRNtDPhZ0MULZw4c || Output_59 != state_14.__p_LqmhEIdOw4YLN2OxnSVISB || Ray_58 != state_14.__slot_MUvRyk90XydM4FzbACVFpX || __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3_62 != state_14.__pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3 || State_Output_64 != state_14.__p_DQah0MHHty4P0K2g6Cw3U3 || Output_68 != state_14.__p_MbDWeukNgZdMNLkOKO1vJi || __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd_70 != state_14.__pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd || State_Output_72 != state_14.__p_K6UNPLbWcpQOogBuncnIxd || __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP_75 != state_14.__pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP || __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ_78 != state_14.__pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ || Output_7 != state_14.__slot_GasJgtyAFJEQRz0YFqFRyz || __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm_83 != state_14.__pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm || __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD_89 != state_14.__pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD || State_Output_92 != state_14.__p_UTGmh8e0IyIOUsVNsoyQvD || Output_96 != state_14.__p_DtP553iLWVqONSTAm72518 || State_Output_98 != state_14.__p_QoN2VDrPbLZMWSyw7SluIQ || Output_100 != state_14.__p_RUaxcSKIx9YNxalNOWUS5R || __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa_102 != state_14.__pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa || State_Output_104 != state_14.__p_QHX6DTMvvHzL0q2tbruhJa ? new __SEn4DAvajL1PniLUyjCFYe(state_14)
                    {__p_NeVxSlOVbiHOgoAk6ghrbd = Output_94, __p_DJHPMOWIRNBOY6HRKdzjC8 = State_Output_52, __pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c = __pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c_54, __p_Roj8OttRNtDPhZ0MULZw4c = State_Output_56, __p_LqmhEIdOw4YLN2OxnSVISB = Output_59, __slot_MUvRyk90XydM4FzbACVFpX = Ray_58, __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3 = __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3_62, __p_DQah0MHHty4P0K2g6Cw3U3 = State_Output_64, __p_MbDWeukNgZdMNLkOKO1vJi = Output_68, __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd = __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd_70, __p_K6UNPLbWcpQOogBuncnIxd = State_Output_72, __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP = __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP_75, __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ = __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ_78, __slot_GasJgtyAFJEQRz0YFqFRyz = Output_7, __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm = __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm_83, __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD = __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD_89, __p_UTGmh8e0IyIOUsVNsoyQvD = State_Output_92, __p_DtP553iLWVqONSTAm72518 = Output_96, __p_QoN2VDrPbLZMWSyw7SluIQ = State_Output_98, __p_RUaxcSKIx9YNxalNOWUS5R = Output_100, __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa = __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa_102, __p_QHX6DTMvvHzL0q2tbruhJa = State_Output_104} : state_14;
                else
                {
                    state_14.__p_NeVxSlOVbiHOgoAk6ghrbd = Output_94;
                    state_14.__p_DJHPMOWIRNBOY6HRKdzjC8 = State_Output_52;
                    state_14.__pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c = __pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c_54;
                    state_14.__p_Roj8OttRNtDPhZ0MULZw4c = State_Output_56;
                    state_14.__p_LqmhEIdOw4YLN2OxnSVISB = Output_59;
                    state_14.__slot_MUvRyk90XydM4FzbACVFpX = Ray_58;
                    state_14.__pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3 = __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3_62;
                    state_14.__p_DQah0MHHty4P0K2g6Cw3U3 = State_Output_64;
                    state_14.__p_MbDWeukNgZdMNLkOKO1vJi = Output_68;
                    state_14.__pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd = __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd_70;
                    state_14.__p_K6UNPLbWcpQOogBuncnIxd = State_Output_72;
                    state_14.__pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP = __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP_75;
                    state_14.__pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ = __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ_78;
                    state_14.__slot_GasJgtyAFJEQRz0YFqFRyz = Output_7;
                    state_14.__pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm = __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm_83;
                    state_14.__pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD = __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD_89;
                    state_14.__p_UTGmh8e0IyIOUsVNsoyQvD = State_Output_92;
                    state_14.__p_DtP553iLWVqONSTAm72518 = Output_96;
                    state_14.__p_QoN2VDrPbLZMWSyw7SluIQ = State_Output_98;
                    state_14.__p_RUaxcSKIx9YNxalNOWUS5R = Output_100;
                    state_14.__pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa = __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa_102;
                    state_14.__p_QHX6DTMvvHzL0q2tbruhJa = State_Output_104;
                }

                outputs_12 = (Output_103, RGB_95);
                manager_10 = manager_10.Update(inputs_11, __GetContext__().IsImmutable, Dispose_Cached_Outputs_9, state_14, outputs_12);
            }
            else
            {
                manager_10.Update(inputs_11, __GetContext__().IsImmutable, Dispose_Cached_Outputs_9);
            }

            var(__auto_105, __auto_106) = outputs_12;
            bool Force_107 = false;
            string TheTemplate_108 = "shader ${shaderID} : VS_PS_Base, Texturing${mixins}\r\n{\r\n    cbuffer Inputs{\r\n${declarations}\r\n    }\r\n\r\n${structs}\r\n\r\n${functions}\r\n${streamDeclaration}\r\n\r\n    stage override void VSMain()\r\n    {\r\n${sourceVS}\r\n${streamsVS}\r\n    }\r\n\r\n    stage override void PSMain()\r\n    {\r\n${sourcePS}\r\n${streamsPS}\r\n    }\r\n};";
            n5.Spread<string> The_Defined_Streams_109 = n21._Operations_.CreateDefault<string>();
            bool SetInputs_110 = true;
            var builder_111 = n4.CollectionBuilders.GetBuilder(this.__pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq, 0);
            var __pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq_112 = builder_111.Commit();
            var Output_113 = this.__p_IOxk48ciszUMK1bTK8fJpq;
            if (SetInputs_110)
            {
                Output_113 = this.__p_IOxk48ciszUMK1bTK8fJpq.SetInputs(Force_In: Force_107, Position_In: __auto_105, CustomStreams_In: __pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq_112, ColorTarget_In: __auto_106, TheTemplate_In: TheTemplate_108, The_Defined_Streams_In: The_Defined_Streams_109);
            }

            var State_Output_115 = Output_113.Update(Output_Out: out n25.CustomEffect_C Output_114);
            var Output_117 = State_Output_115.GetLastError(lastError_Out: out string lastError_116);
            var Output_119 = Output_117.GetShaderCode(Shader_Code_Out: out string Shader_Code_118);
            var Output_120 = Output_119;
            if (AutoCompile_In)
            {
                Output_120 = Output_119.AutoCompile();
            }

            n26.IEffect Effect_Instance_121 = (n26.IEffect)Output_114;
            bool SetEffect_122 = true;
            var Output_123 = this.__p_GUIT9pJGBufPtzXh1PWp5A;
            if (SetEffect_122)
            {
                Output_123 = this.__p_GUIT9pJGBufPtzXh1PWp5A.SetEffect(Effect_Instance_In: Effect_Instance_121);
            }

            n1.CompilationHelper.ReadPin(this.__p_NxIg1Lan5AaLQG9QrMTHoG.Outputs[0], out n27.Mesh out_124);
            int Instance_Count_125 = 1;
            string Profiling_Name_126 = "Mesh Renderer";
            bool Update_127 = true;
            var Output_128 = Output_123;
            if (Update_127)
            {
                Output_128 = Output_123.Update(Mesh_In: out_124, Instance_Count_In: Instance_Count_125, Profiling_Name_In: Profiling_Name_126);
            }

            n27.IGraphicsRendererBase Input_129 = (n27.IGraphicsRendererBase)Output_128;
            n26.DrawerRenderStage Render_Stage_130 = __c_VO1oab1vS11N25QETO1YaD;
            bool Single_Call_Per_Frame_131 = false;
            bool SetupRendering_132 = true;
            var Output_133 = this.__p_HkGY9pw7IkhP2qUjDxZ60y;
            if (SetupRendering_132)
            {
                Output_133 = this.__p_HkGY9pw7IkhP2qUjDxZ60y.SetupRendering(Input_In: Input_129, Render_Stage_In: Render_Stage_130, Single_Call_Per_Frame_In: Single_Call_Per_Frame_131);
            }

            string Name_134 = "Raymarch";
            bool SetName_135 = true;
            var Output_136 = Output_133;
            if (SetName_135)
            {
                Output_136 = Output_133.SetName(Name_In: Name_134);
            }

            bool SetEnabled_137 = true;
            var Output_138 = Output_136;
            if (SetEnabled_137)
            {
                Output_138 = Output_136.SetEnabled(Enabled_In: Enabled_In);
            }

            var State_Output_140 = Output_138.Update(Output_Out: out n28.Entity Output_139);
            var builder_141 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW, 1);
            builder_141.Add(__pad_AEqrniIISbzPVPNlSN5K8X_1);
            var __pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW_142 = builder_141.Commit();
            n21._Operations_.FromValue<string>(Input_In: __pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW_142, Result_Out: out n5.Spread<string> Result_143);
            n11.IEnumerable<string> Input_144 = (n11.IEnumerable<string>)Result_143;
            n24._Operations_.ToList<string>(Input_In: Input_144, Result_Out: out n11.List<string> Result_145);
            Output_Out = Output_139;
            lastError_Out = lastError_116;
            Shader_Code_Out = Shader_Code_118;
            n3.RayMarch_Basic_G1rmTuYo917LHCEFh32ucW that_146 = this;
            if (this.__GetContext__().IsImmutable)
                that_146 = __pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5_6 != this.__pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5 || manager_10 != this.__cache_D4PfuRFD0mvLavwU8AWkjq || __pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq_112 != this.__pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq || Output_120 != this.__p_IOxk48ciszUMK1bTK8fJpq || Output_128 != this.__p_GUIT9pJGBufPtzXh1PWp5A || this.__p_NxIg1Lan5AaLQG9QrMTHoG != this.__p_NxIg1Lan5AaLQG9QrMTHoG || State_Output_140 != this.__p_HkGY9pw7IkhP2qUjDxZ60y || __pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW_142 != this.__pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW ? new RayMarch_Basic_G1rmTuYo917LHCEFh32ucW(this)
                {__pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5 = __pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5_6, __cache_D4PfuRFD0mvLavwU8AWkjq = manager_10, __pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq = __pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq_112, __p_IOxk48ciszUMK1bTK8fJpq = Output_120, __p_GUIT9pJGBufPtzXh1PWp5A = Output_128, __p_NxIg1Lan5AaLQG9QrMTHoG = this.__p_NxIg1Lan5AaLQG9QrMTHoG, __p_HkGY9pw7IkhP2qUjDxZ60y = State_Output_140, __pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW = __pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW_142} : that_146;
            else
            {
                this.__pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5 = __pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5_6;
                this.__cache_D4PfuRFD0mvLavwU8AWkjq = manager_10;
                this.__pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq = __pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq_112;
                this.__p_IOxk48ciszUMK1bTK8fJpq = Output_120;
                this.__p_GUIT9pJGBufPtzXh1PWp5A = Output_128;
                this.__p_NxIg1Lan5AaLQG9QrMTHoG = this.__p_NxIg1Lan5AaLQG9QrMTHoG;
                this.__p_HkGY9pw7IkhP2qUjDxZ60y = State_Output_140;
                this.__pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW = __pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW_142;
            }

            return that_146;
        }

        public n3.RayMarch_Basic_G1rmTuYo917LHCEFh32ucW __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "GUIT9pJGBufPtzXh1PWp5A", 327004U);
            var Output_1 = n30.MeshRenderer_C.Create(Node_Context: Node_Context_0);
            var node_2 = n1.CompilationHelper.CreateNodeById(Node_Context, "PlaneMesh", "Stride.Models.Meshes");
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "HkGY9pw7IkhP2qUjDxZ60y", 327052U);
            var Output_4 = n31.RenderEntity_HYRtmvUkSb6PheJUi3kp3r.Create(Node_Context: Node_Context_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "IOxk48ciszUMK1bTK8fJpq", 327074U);
            var Output_6 = n32.DrawShaderGraph_C.Create(Node_Context: Node_Context_5);
            n3.RayMarch_Basic_G1rmTuYo917LHCEFh32ucW that_7 = this;
            this.__pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5 = n21._Operations_.CreateDefault<string>();
            this.__pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq = n23._Operations_.CreateDefault<string, n8.AbstractGpuValue>();
            this.__pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW = n21._Operations_.CreateDefault<string>();
            this.__p_GUIT9pJGBufPtzXh1PWp5A = Output_1;
            this.__p_NxIg1Lan5AaLQG9QrMTHoG = node_2;
            this.__p_HkGY9pw7IkhP2qUjDxZ60y = Output_4;
            this.__p_IOxk48ciszUMK1bTK8fJpq = Output_6;
            this.__cache_D4PfuRFD0mvLavwU8AWkjq = null;
            return that_7;
        }

        public n3.RayMarch_Basic_G1rmTuYo917LHCEFh32ucW __CreateDefault__()
        {
            n3.RayMarch_Basic_G1rmTuYo917LHCEFh32ucW that_0 = this;
            this.__pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5 = n21._Operations_.CreateDefault<string>();
            this.__pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq = n23._Operations_.CreateDefault<string, n8.AbstractGpuValue>();
            this.__pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW = n21._Operations_.CreateDefault<string>();
            this.__cache_D4PfuRFD0mvLavwU8AWkjq = null;
            this.__p_IOxk48ciszUMK1bTK8fJpq = n32.DrawShaderGraph_C.CreateDefault();
            this.__p_GUIT9pJGBufPtzXh1PWp5A = n30.MeshRenderer_C.CreateDefault();
            this.__p_NxIg1Lan5AaLQG9QrMTHoG = default(n1.IVLNode);
            this.__p_HkGY9pw7IkhP2qUjDxZ60y = n31.RenderEntity_HYRtmvUkSb6PheJUi3kp3r.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_D4PfuRFD0mvLavwU8AWkjq);
            n1.CompilationHelper.SafeDispose(this.__p_IOxk48ciszUMK1bTK8fJpq);
            n1.CompilationHelper.SafeDispose(this.__p_GUIT9pJGBufPtzXh1PWp5A);
            n1.CompilationHelper.SafeDispose(this.__p_NxIg1Lan5AaLQG9QrMTHoG);
            n1.CompilationHelper.SafeDispose(this.__p_HkGY9pw7IkhP2qUjDxZ60y);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 326962U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "T7QMxKwPMKnOVIqoTYE0iL", Name = "__slot_T7QMxKwPMKnOVIqoTYE0iL")]
        public static string __slot_T7QMxKwPMKnOVIqoTYE0iL = "// raymarcher\r\nfloat SDF(float3 p) // should be override unless it's the first imp.  Gets called by the other functions\r\n{\r\n\treturn ${SDF}(p);\r\n}\r\n\r\n\r\nfloat4 ${signature}(int maxIter, float4 col)\r\n{\r\n\tRay ray = ${SETUP}();\r\n\tfloat2 minMaxDist = ${CULL}(ray);\r\n\t${MARCH}(ray, minMaxDist, maxIter);\r\n\r\n\t//streams.PositionWS.xyz = ray.sp;\r\n    //streams.normalWS.xyz = ray.sn;\r\n\treturn ${SHADE};\r\n}\r\n";
        [n1.ElementAttribute(TracingId = 326971U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "B0nLMoc5SOfQEdqRvqBv9z", Name = "__slot_B0nLMoc5SOfQEdqRvqBv9z")]
        public static string __slot_B0nLMoc5SOfQEdqRvqBv9z = "TODO add world transform";
        [n1.ElementAttribute(TracingId = 327098U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "DwjnjWiHJHHNULbL0PRpUt", Name = "__slot_DwjnjWiHJHHNULbL0PRpUt")]
        public static string __slot_DwjnjWiHJHHNULbL0PRpUt = "Fails without error if we try to write to these >";
        [n1.ElementAttribute(TracingId = 327103U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "AEqrniIISbzPVPNlSN5K8X", Name = "__slot_AEqrniIISbzPVPNlSN5K8X")]
        public static string __slot_AEqrniIISbzPVPNlSN5K8X = "float4 PositionWS : POSITION_WS;";
        [n1.ElementAttribute(TracingId = 327116U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "GEBY7bzYxwVMUNGX4VZk9o", Name = "__slot_GEBY7bzYxwVMUNGX4VZk9o")]
        public static string __slot_GEBY7bzYxwVMUNGX4VZk9o = "Do need to do something here?";
        [n1.ElementAttribute(TracingId = 327118U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "IYYmm9Oczz7QWZaOirkRcz", Name = "__slot_IYYmm9Oczz7QWZaOirkRcz")]
        public static string __slot_IYYmm9Oczz7QWZaOirkRcz = "shader ${shaderID} : VS_PS_Base, Texturing, PositionStream4${mixins}\r\n{\r\n    cbuffer Inputs{\r\n${declarations}\r\n    }\r\n\r\n${structs}\r\n\r\n${functions}\r\n${streamDeclaration}\r\n\r\n    stage override void VSMain()\r\n    {\r\n${sourceVS}\r\n${streamsVS}\r\n    }\r\n\r\n    stage override void PSMain()\r\n    {\r\n${sourcePS}\r\n${streamsPS}\r\n    }\r\n};";
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<string> __pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5 = default(n5.Spread<string>);
        [n1.ElementAttribute(TracingId = 326754U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "D4PfuRFD0mvLavwU8AWkjq", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n10.Manager<n2.ValueTuple<string, n8.GpuValue<float>, int, n8.GpuValue<n9.Vector4>, n9.Vector3, n9.Vector3, string>, n2.ValueTuple<n8.GpuValue<n9.Vector4>, n8.GpuValue<n9.Vector4>>> __cache_D4PfuRFD0mvLavwU8AWkjq = null;
        [n1.ElementAttribute(TracingId = 326821U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "MZOtJuN48VsP2TRUh6oVol", Name = "__slot_MZOtJuN48VsP2TRUh6oVol")]
        public static string __slot_MZOtJuN48VsP2TRUh6oVol = "FuseRayMarch";
        [n1.ElementAttribute(TracingId = 326810U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "DHQKnol1bOIQRT6KpazYwP", Name = "__slot_DHQKnol1bOIQRT6KpazYwP")]
        public static string __slot_DHQKnol1bOIQRT6KpazYwP = "RayMarcher";
        [n1.ElementAttribute(TracingId = 326812U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "EL55wCQ7hJrPgwA8S4Mh2z", Name = "__slot_EL55wCQ7hJrPgwA8S4Mh2z")]
        public static string __slot_EL55wCQ7hJrPgwA8S4Mh2z = "SDF";
        [n1.ElementAttribute(TracingId = 326900U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "UyMIOT1340QPgCaqlfZLH3", Name = "__slot_UyMIOT1340QPgCaqlfZLH3")]
        public static string __slot_UyMIOT1340QPgCaqlfZLH3 = "SETUP";
        [n1.ElementAttribute(TracingId = 326879U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "H0R2DwJ6QzqQDkiTQp28qe", Name = "__slot_H0R2DwJ6QzqQDkiTQp28qe")]
        public static string __slot_H0R2DwJ6QzqQDkiTQp28qe = "CULL";
        [n1.ElementAttribute(TracingId = 326834U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "O8T5BCwn1EwPfnANWdwLSI", Name = "__slot_O8T5BCwn1EwPfnANWdwLSI")]
        public static string __slot_O8T5BCwn1EwPfnANWdwLSI = "marchRayDefualt";
        [n1.ElementAttribute(TracingId = 326914U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "QFrWcFnuLTpNapZ0DTo5Pb", Name = "__slot_QFrWcFnuLTpNapZ0DTo5Pb")]
        public static n9.Vector4 __slot_QFrWcFnuLTpNapZ0DTo5Pb = n1.CompilationHelper.Deserialize<n9.Vector4>("2, 2, 0, 1", false, "RGYLe02tPXEQEO6aJ6Qsjm", "QFrWcFnuLTpNapZ0DTo5Pb");
        [n1.ElementAttribute(TracingId = 327074U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "IOxk48ciszUMK1bTK8fJpq", Name = "DrawShaderGraph", IsManaged = true, IsAutoGenerated = true)]
        public n32.DrawShaderGraph_C __p_IOxk48ciszUMK1bTK8fJpq;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n22.ImmutableDictionary<string, n8.AbstractGpuValue> __pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq = default(n22.ImmutableDictionary<string, n8.AbstractGpuValue>);
        [n1.ElementAttribute(TracingId = 327004U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "GUIT9pJGBufPtzXh1PWp5A", Name = "MeshRenderer", IsManaged = true, IsAutoGenerated = true)]
        public n30.MeshRenderer_C __p_GUIT9pJGBufPtzXh1PWp5A;
        [n1.ElementAttribute(TracingId = 327029U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "NxIg1Lan5AaLQG9QrMTHoG", Name = "PlaneMesh", IsManaged = true, IsAutoGenerated = true, NodeName = "PlaneMesh", NodeCategory = "Stride.Models.Meshes")]
        public n1.IVLNode __p_NxIg1Lan5AaLQG9QrMTHoG;
        [n1.ElementAttribute(TracingId = 327052U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "HkGY9pw7IkhP2qUjDxZ60y", Name = "RenderEntity", IsManaged = true, IsAutoGenerated = true)]
        public n31.RenderEntity_HYRtmvUkSb6PheJUi3kp3r __p_HkGY9pw7IkhP2qUjDxZ60y;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n26.DrawerRenderStage __c_VO1oab1vS11N25QETO1YaD = n1.CompilationHelper.Deserialize<n26.DrawerRenderStage>("Opaque", false, "RGYLe02tPXEQEO6aJ6Qsjm", "VO1oab1vS11N25QETO1YaD");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n5.Spread<string> __pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW = default(n5.Spread<string>);
        static RayMarch_Basic_G1rmTuYo917LHCEFh32ucW()
        {
        }

        public RayMarch_Basic_G1rmTuYo917LHCEFh32ucW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RayMarch_Basic_G1rmTuYo917LHCEFh32ucW(RayMarch_Basic_G1rmTuYo917LHCEFh32ucW other): base(other)
        {
            this.__pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5 = other.__pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5;
            this.__cache_D4PfuRFD0mvLavwU8AWkjq = other.__cache_D4PfuRFD0mvLavwU8AWkjq;
            this.__p_IOxk48ciszUMK1bTK8fJpq = other.__p_IOxk48ciszUMK1bTK8fJpq;
            this.__pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq = other.__pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq;
            this.__p_GUIT9pJGBufPtzXh1PWp5A = other.__p_GUIT9pJGBufPtzXh1PWp5A;
            this.__p_NxIg1Lan5AaLQG9QrMTHoG = other.__p_NxIg1Lan5AaLQG9QrMTHoG;
            this.__p_HkGY9pw7IkhP2qUjDxZ60y = other.__p_HkGY9pw7IkhP2qUjDxZ60y;
            this.__pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW = other.__pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5", in __pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5), n1.CompilationHelper.GetValueOrExisting(values, "__cache_D4PfuRFD0mvLavwU8AWkjq", in __cache_D4PfuRFD0mvLavwU8AWkjq), n1.CompilationHelper.GetValueOrExisting(values, "__p_IOxk48ciszUMK1bTK8fJpq", in __p_IOxk48ciszUMK1bTK8fJpq), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq", in __pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq), n1.CompilationHelper.GetValueOrExisting(values, "__p_GUIT9pJGBufPtzXh1PWp5A", in __p_GUIT9pJGBufPtzXh1PWp5A), n1.CompilationHelper.GetValueOrExisting(values, "__p_NxIg1Lan5AaLQG9QrMTHoG", in __p_NxIg1Lan5AaLQG9QrMTHoG), n1.CompilationHelper.GetValueOrExisting(values, "__p_HkGY9pw7IkhP2qUjDxZ60y", in __p_HkGY9pw7IkhP2qUjDxZ60y), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW", in __pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW));
        }

        internal RayMarch_Basic_G1rmTuYo917LHCEFh32ucW __WITH__(n5.Spread<string> __pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5, n10.Manager<n2.ValueTuple<string, n8.GpuValue<float>, int, n8.GpuValue<n9.Vector4>, n9.Vector3, n9.Vector3, string>, n2.ValueTuple<n8.GpuValue<n9.Vector4>, n8.GpuValue<n9.Vector4>>> __cache_D4PfuRFD0mvLavwU8AWkjq, n32.DrawShaderGraph_C __p_IOxk48ciszUMK1bTK8fJpq, n22.ImmutableDictionary<string, n8.AbstractGpuValue> __pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq, n30.MeshRenderer_C __p_GUIT9pJGBufPtzXh1PWp5A, n1.IVLNode __p_NxIg1Lan5AaLQG9QrMTHoG, n31.RenderEntity_HYRtmvUkSb6PheJUi3kp3r __p_HkGY9pw7IkhP2qUjDxZ60y, n5.Spread<string> __pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW)
        {
            n3.RayMarch_Basic_G1rmTuYo917LHCEFh32ucW that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5 != this.__pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5 || __cache_D4PfuRFD0mvLavwU8AWkjq != this.__cache_D4PfuRFD0mvLavwU8AWkjq || __p_IOxk48ciszUMK1bTK8fJpq != this.__p_IOxk48ciszUMK1bTK8fJpq || __pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq != this.__pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq || __p_GUIT9pJGBufPtzXh1PWp5A != this.__p_GUIT9pJGBufPtzXh1PWp5A || __p_NxIg1Lan5AaLQG9QrMTHoG != this.__p_NxIg1Lan5AaLQG9QrMTHoG || __p_HkGY9pw7IkhP2qUjDxZ60y != this.__p_HkGY9pw7IkhP2qUjDxZ60y || __pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW != this.__pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW ? new RayMarch_Basic_G1rmTuYo917LHCEFh32ucW(this)
                {__pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5 = __pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5, __cache_D4PfuRFD0mvLavwU8AWkjq = __cache_D4PfuRFD0mvLavwU8AWkjq, __p_IOxk48ciszUMK1bTK8fJpq = __p_IOxk48ciszUMK1bTK8fJpq, __pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq = __pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq, __p_GUIT9pJGBufPtzXh1PWp5A = __p_GUIT9pJGBufPtzXh1PWp5A, __p_NxIg1Lan5AaLQG9QrMTHoG = __p_NxIg1Lan5AaLQG9QrMTHoG, __p_HkGY9pw7IkhP2qUjDxZ60y = __p_HkGY9pw7IkhP2qUjDxZ60y, __pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW = __pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW} : that_0;
            else
            {
                this.__pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5 = __pin_group_Input_In_V8Sf0y3mq2SPHI4AWOpBL5;
                this.__cache_D4PfuRFD0mvLavwU8AWkjq = __cache_D4PfuRFD0mvLavwU8AWkjq;
                this.__p_IOxk48ciszUMK1bTK8fJpq = __p_IOxk48ciszUMK1bTK8fJpq;
                this.__pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq = __pin_group_CustomStreams_In_IOxk48ciszUMK1bTK8fJpq;
                this.__p_GUIT9pJGBufPtzXh1PWp5A = __p_GUIT9pJGBufPtzXh1PWp5A;
                this.__p_NxIg1Lan5AaLQG9QrMTHoG = __p_NxIg1Lan5AaLQG9QrMTHoG;
                this.__p_HkGY9pw7IkhP2qUjDxZ60y = __p_HkGY9pw7IkhP2qUjDxZ60y;
                this.__pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW = __pin_group_Input_In_SCKVbtbEljRMxSg9a7BGKW;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "SEn4DAvajL1PniLUyjCFYe", Name = "__SEn4DAvajL1PniLUyjCFYe")]
        [n2.SerializableAttribute]
        public class __SEn4DAvajL1PniLUyjCFYe : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UTGmh8e0IyIOUsVNsoyQvD);
                n1.CompilationHelper.SafeDispose(this.__p_NeVxSlOVbiHOgoAk6ghrbd);
                n1.CompilationHelper.SafeDispose(this.__p_Roj8OttRNtDPhZ0MULZw4c);
                n1.CompilationHelper.SafeDispose(this.__p_LqmhEIdOw4YLN2OxnSVISB);
                n1.CompilationHelper.SafeDispose(this.__p_MbDWeukNgZdMNLkOKO1vJi);
                n1.CompilationHelper.SafeDispose(this.__p_K6UNPLbWcpQOogBuncnIxd);
                n1.CompilationHelper.SafeDispose(this.__p_DQah0MHHty4P0K2g6Cw3U3);
                n1.CompilationHelper.SafeDispose(this.__p_DtP553iLWVqONSTAm72518);
                n1.CompilationHelper.SafeDispose(this.__p_QoN2VDrPbLZMWSyw7SluIQ);
                n1.CompilationHelper.SafeDispose(this.__p_RUaxcSKIx9YNxalNOWUS5R);
                n1.CompilationHelper.SafeDispose(this.__p_QHX6DTMvvHzL0q2tbruhJa);
                n1.CompilationHelper.SafeDispose(this.__p_DJHPMOWIRNBOY6HRKdzjC8);
                return;
            }

            [n1.ElementAttribute(TracingId = 326789U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "UTGmh8e0IyIOUsVNsoyQvD", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<n9.Vector4, n11.IEnumerable<n8.InputModifier>> __p_UTGmh8e0IyIOUsVNsoyQvD;
            [n1.ElementAttribute(TracingId = 326823U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "NeVxSlOVbiHOgoAk6ghrbd", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
            public n13.GPUIn_C<int> __p_NeVxSlOVbiHOgoAk6ghrbd;
            [n1.ElementAttribute(TracingId = 326839U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Roj8OttRNtDPhZ0MULZw4c", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_Roj8OttRNtDPhZ0MULZw4c;
            [n1.ElementAttribute(TracingId = 326850U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "LqmhEIdOw4YLN2OxnSVISB", Name = "SetupRayByCamera", IsManaged = true, IsAutoGenerated = true)]
            public n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt __p_LqmhEIdOw4YLN2OxnSVISB;
            [n1.ElementAttribute(TracingId = 326856U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "MbDWeukNgZdMNLkOKO1vJi", Name = "CullRayByBoundingBox", IsManaged = true, IsAutoGenerated = true)]
            public n15.CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b __p_MbDWeukNgZdMNLkOKO1vJi;
            [n1.ElementAttribute(TracingId = 326867U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "K6UNPLbWcpQOogBuncnIxd", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<n9.Vector2> __p_K6UNPLbWcpQOogBuncnIxd;
            [n1.ElementAttribute(TracingId = 326893U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "DQah0MHHty4P0K2g6Cw3U3", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<n16.Ray> __p_DQah0MHHty4P0K2g6Cw3U3;
            [n1.ElementAttribute(TracingId = 326903U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "DtP553iLWVqONSTAm72518", Name = "SRGBToRGB", IsManaged = true, IsAutoGenerated = true)]
            public n17.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<n9.Vector4> __p_DtP553iLWVqONSTAm72518;
            [n1.ElementAttribute(TracingId = 326910U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "QoN2VDrPbLZMWSyw7SluIQ", Name = "Position", IsManaged = true, IsAutoGenerated = true)]
            public n18.Position_PeLDdeSku4ANhU5oe5SfPy __p_QoN2VDrPbLZMWSyw7SluIQ;
            [n1.ElementAttribute(TracingId = 326918U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "RUaxcSKIx9YNxalNOWUS5R", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n13.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n9.Vector4> __p_RUaxcSKIx9YNxalNOWUS5R;
            [n1.ElementAttribute(TracingId = 326923U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "QHX6DTMvvHzL0q2tbruhJa", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n19.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n9.Vector4> __p_QHX6DTMvvHzL0q2tbruhJa;
            [n1.ElementAttribute(TracingId = 326936U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "DJHPMOWIRNBOY6HRKdzjC8", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n14.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n9.Vector3> __p_DJHPMOWIRNBOY6HRKdzjC8;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c = default(n5.Spread<n8.AbstractGpuValue>);
            [n1.ElementAttribute(TracingId = 326880U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "MUvRyk90XydM4FzbACVFpX", Name = "__slot_MUvRyk90XydM4FzbACVFpX")]
            public n8.GpuValue<n16.Ray> __slot_MUvRyk90XydM4FzbACVFpX;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3 = default(n5.Spread<n8.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd = default(n5.Spread<n8.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.IFunctionInvokeNode> __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP = default(n5.Spread<n8.IFunctionInvokeNode>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<string> __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ = default(n5.Spread<string>);
            [n1.ElementAttribute(TracingId = 326835U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "GasJgtyAFJEQRz0YFqFRyz", Name = "__slot_GasJgtyAFJEQRz0YFqFRyz")]
            public string __slot_GasJgtyAFJEQRz0YFqFRyz;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n22.ImmutableDictionary<string, string> __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm = default(n22.ImmutableDictionary<string, string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD = default(n5.Spread<n8.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.GpuValue<n9.Vector4>> __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa = default(n5.Spread<n8.GpuValue<n9.Vector4>>);
            public __SEn4DAvajL1PniLUyjCFYe(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SEn4DAvajL1PniLUyjCFYe(__SEn4DAvajL1PniLUyjCFYe other): base(other)
            {
                this.__p_UTGmh8e0IyIOUsVNsoyQvD = other.__p_UTGmh8e0IyIOUsVNsoyQvD;
                this.__p_NeVxSlOVbiHOgoAk6ghrbd = other.__p_NeVxSlOVbiHOgoAk6ghrbd;
                this.__p_Roj8OttRNtDPhZ0MULZw4c = other.__p_Roj8OttRNtDPhZ0MULZw4c;
                this.__p_LqmhEIdOw4YLN2OxnSVISB = other.__p_LqmhEIdOw4YLN2OxnSVISB;
                this.__p_MbDWeukNgZdMNLkOKO1vJi = other.__p_MbDWeukNgZdMNLkOKO1vJi;
                this.__p_K6UNPLbWcpQOogBuncnIxd = other.__p_K6UNPLbWcpQOogBuncnIxd;
                this.__p_DQah0MHHty4P0K2g6Cw3U3 = other.__p_DQah0MHHty4P0K2g6Cw3U3;
                this.__p_DtP553iLWVqONSTAm72518 = other.__p_DtP553iLWVqONSTAm72518;
                this.__p_QoN2VDrPbLZMWSyw7SluIQ = other.__p_QoN2VDrPbLZMWSyw7SluIQ;
                this.__p_RUaxcSKIx9YNxalNOWUS5R = other.__p_RUaxcSKIx9YNxalNOWUS5R;
                this.__p_QHX6DTMvvHzL0q2tbruhJa = other.__p_QHX6DTMvvHzL0q2tbruhJa;
                this.__p_DJHPMOWIRNBOY6HRKdzjC8 = other.__p_DJHPMOWIRNBOY6HRKdzjC8;
                this.__pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c = other.__pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c;
                this.__slot_MUvRyk90XydM4FzbACVFpX = other.__slot_MUvRyk90XydM4FzbACVFpX;
                this.__pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3 = other.__pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3;
                this.__pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd = other.__pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd;
                this.__pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP = other.__pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP;
                this.__pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ = other.__pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ;
                this.__slot_GasJgtyAFJEQRz0YFqFRyz = other.__slot_GasJgtyAFJEQRz0YFqFRyz;
                this.__pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm = other.__pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm;
                this.__pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD = other.__pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD;
                this.__pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa = other.__pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UTGmh8e0IyIOUsVNsoyQvD", in __p_UTGmh8e0IyIOUsVNsoyQvD), n1.CompilationHelper.GetValueOrExisting(values, "__p_NeVxSlOVbiHOgoAk6ghrbd", in __p_NeVxSlOVbiHOgoAk6ghrbd), n1.CompilationHelper.GetValueOrExisting(values, "__p_Roj8OttRNtDPhZ0MULZw4c", in __p_Roj8OttRNtDPhZ0MULZw4c), n1.CompilationHelper.GetValueOrExisting(values, "__p_LqmhEIdOw4YLN2OxnSVISB", in __p_LqmhEIdOw4YLN2OxnSVISB), n1.CompilationHelper.GetValueOrExisting(values, "__p_MbDWeukNgZdMNLkOKO1vJi", in __p_MbDWeukNgZdMNLkOKO1vJi), n1.CompilationHelper.GetValueOrExisting(values, "__p_K6UNPLbWcpQOogBuncnIxd", in __p_K6UNPLbWcpQOogBuncnIxd), n1.CompilationHelper.GetValueOrExisting(values, "__p_DQah0MHHty4P0K2g6Cw3U3", in __p_DQah0MHHty4P0K2g6Cw3U3), n1.CompilationHelper.GetValueOrExisting(values, "__p_DtP553iLWVqONSTAm72518", in __p_DtP553iLWVqONSTAm72518), n1.CompilationHelper.GetValueOrExisting(values, "__p_QoN2VDrPbLZMWSyw7SluIQ", in __p_QoN2VDrPbLZMWSyw7SluIQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_RUaxcSKIx9YNxalNOWUS5R", in __p_RUaxcSKIx9YNxalNOWUS5R), n1.CompilationHelper.GetValueOrExisting(values, "__p_QHX6DTMvvHzL0q2tbruhJa", in __p_QHX6DTMvvHzL0q2tbruhJa), n1.CompilationHelper.GetValueOrExisting(values, "__p_DJHPMOWIRNBOY6HRKdzjC8", in __p_DJHPMOWIRNBOY6HRKdzjC8), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c", in __pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c), n1.CompilationHelper.GetValueOrExisting(values, "__slot_MUvRyk90XydM4FzbACVFpX", in __slot_MUvRyk90XydM4FzbACVFpX), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3", in __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd", in __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP", in __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ", in __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ), n1.CompilationHelper.GetValueOrExisting(values, "__slot_GasJgtyAFJEQRz0YFqFRyz", in __slot_GasJgtyAFJEQRz0YFqFRyz), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm", in __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD", in __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa", in __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa));
            }

            internal __SEn4DAvajL1PniLUyjCFYe __WITH__(n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<n9.Vector4, n11.IEnumerable<n8.InputModifier>> __p_UTGmh8e0IyIOUsVNsoyQvD, n13.GPUIn_C<int> __p_NeVxSlOVbiHOgoAk6ghrbd, n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_Roj8OttRNtDPhZ0MULZw4c, n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt __p_LqmhEIdOw4YLN2OxnSVISB, n15.CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b __p_MbDWeukNgZdMNLkOKO1vJi, n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<n9.Vector2> __p_K6UNPLbWcpQOogBuncnIxd, n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<n16.Ray> __p_DQah0MHHty4P0K2g6Cw3U3, n17.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<n9.Vector4> __p_DtP553iLWVqONSTAm72518, n18.Position_PeLDdeSku4ANhU5oe5SfPy __p_QoN2VDrPbLZMWSyw7SluIQ, n13.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n9.Vector4> __p_RUaxcSKIx9YNxalNOWUS5R, n19.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n9.Vector4> __p_QHX6DTMvvHzL0q2tbruhJa, n14.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n9.Vector3> __p_DJHPMOWIRNBOY6HRKdzjC8, n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c, n8.GpuValue<n16.Ray> __slot_MUvRyk90XydM4FzbACVFpX, n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3, n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd, n5.Spread<n8.IFunctionInvokeNode> __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP, n5.Spread<string> __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ, string __slot_GasJgtyAFJEQRz0YFqFRyz, n22.ImmutableDictionary<string, string> __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm, n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD, n5.Spread<n8.GpuValue<n9.Vector4>> __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa)
            {
                __SEn4DAvajL1PniLUyjCFYe that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_UTGmh8e0IyIOUsVNsoyQvD != this.__p_UTGmh8e0IyIOUsVNsoyQvD || __p_NeVxSlOVbiHOgoAk6ghrbd != this.__p_NeVxSlOVbiHOgoAk6ghrbd || __p_Roj8OttRNtDPhZ0MULZw4c != this.__p_Roj8OttRNtDPhZ0MULZw4c || __p_LqmhEIdOw4YLN2OxnSVISB != this.__p_LqmhEIdOw4YLN2OxnSVISB || __p_MbDWeukNgZdMNLkOKO1vJi != this.__p_MbDWeukNgZdMNLkOKO1vJi || __p_K6UNPLbWcpQOogBuncnIxd != this.__p_K6UNPLbWcpQOogBuncnIxd || __p_DQah0MHHty4P0K2g6Cw3U3 != this.__p_DQah0MHHty4P0K2g6Cw3U3 || __p_DtP553iLWVqONSTAm72518 != this.__p_DtP553iLWVqONSTAm72518 || __p_QoN2VDrPbLZMWSyw7SluIQ != this.__p_QoN2VDrPbLZMWSyw7SluIQ || __p_RUaxcSKIx9YNxalNOWUS5R != this.__p_RUaxcSKIx9YNxalNOWUS5R || __p_QHX6DTMvvHzL0q2tbruhJa != this.__p_QHX6DTMvvHzL0q2tbruhJa || __p_DJHPMOWIRNBOY6HRKdzjC8 != this.__p_DJHPMOWIRNBOY6HRKdzjC8 || __pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c != this.__pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c || __slot_MUvRyk90XydM4FzbACVFpX != this.__slot_MUvRyk90XydM4FzbACVFpX || __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3 != this.__pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3 || __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd != this.__pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd || __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP != this.__pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP || __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ != this.__pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ || __slot_GasJgtyAFJEQRz0YFqFRyz != this.__slot_GasJgtyAFJEQRz0YFqFRyz || __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm != this.__pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm || __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD != this.__pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD || __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa != this.__pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa ? new __SEn4DAvajL1PniLUyjCFYe(this)
                    {__p_UTGmh8e0IyIOUsVNsoyQvD = __p_UTGmh8e0IyIOUsVNsoyQvD, __p_NeVxSlOVbiHOgoAk6ghrbd = __p_NeVxSlOVbiHOgoAk6ghrbd, __p_Roj8OttRNtDPhZ0MULZw4c = __p_Roj8OttRNtDPhZ0MULZw4c, __p_LqmhEIdOw4YLN2OxnSVISB = __p_LqmhEIdOw4YLN2OxnSVISB, __p_MbDWeukNgZdMNLkOKO1vJi = __p_MbDWeukNgZdMNLkOKO1vJi, __p_K6UNPLbWcpQOogBuncnIxd = __p_K6UNPLbWcpQOogBuncnIxd, __p_DQah0MHHty4P0K2g6Cw3U3 = __p_DQah0MHHty4P0K2g6Cw3U3, __p_DtP553iLWVqONSTAm72518 = __p_DtP553iLWVqONSTAm72518, __p_QoN2VDrPbLZMWSyw7SluIQ = __p_QoN2VDrPbLZMWSyw7SluIQ, __p_RUaxcSKIx9YNxalNOWUS5R = __p_RUaxcSKIx9YNxalNOWUS5R, __p_QHX6DTMvvHzL0q2tbruhJa = __p_QHX6DTMvvHzL0q2tbruhJa, __p_DJHPMOWIRNBOY6HRKdzjC8 = __p_DJHPMOWIRNBOY6HRKdzjC8, __pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c = __pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c, __slot_MUvRyk90XydM4FzbACVFpX = __slot_MUvRyk90XydM4FzbACVFpX, __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3 = __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3, __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd = __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd, __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP = __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP, __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ = __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ, __slot_GasJgtyAFJEQRz0YFqFRyz = __slot_GasJgtyAFJEQRz0YFqFRyz, __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm = __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm, __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD = __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD, __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa = __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa} : that_0;
                else
                {
                    this.__p_UTGmh8e0IyIOUsVNsoyQvD = __p_UTGmh8e0IyIOUsVNsoyQvD;
                    this.__p_NeVxSlOVbiHOgoAk6ghrbd = __p_NeVxSlOVbiHOgoAk6ghrbd;
                    this.__p_Roj8OttRNtDPhZ0MULZw4c = __p_Roj8OttRNtDPhZ0MULZw4c;
                    this.__p_LqmhEIdOw4YLN2OxnSVISB = __p_LqmhEIdOw4YLN2OxnSVISB;
                    this.__p_MbDWeukNgZdMNLkOKO1vJi = __p_MbDWeukNgZdMNLkOKO1vJi;
                    this.__p_K6UNPLbWcpQOogBuncnIxd = __p_K6UNPLbWcpQOogBuncnIxd;
                    this.__p_DQah0MHHty4P0K2g6Cw3U3 = __p_DQah0MHHty4P0K2g6Cw3U3;
                    this.__p_DtP553iLWVqONSTAm72518 = __p_DtP553iLWVqONSTAm72518;
                    this.__p_QoN2VDrPbLZMWSyw7SluIQ = __p_QoN2VDrPbLZMWSyw7SluIQ;
                    this.__p_RUaxcSKIx9YNxalNOWUS5R = __p_RUaxcSKIx9YNxalNOWUS5R;
                    this.__p_QHX6DTMvvHzL0q2tbruhJa = __p_QHX6DTMvvHzL0q2tbruhJa;
                    this.__p_DJHPMOWIRNBOY6HRKdzjC8 = __p_DJHPMOWIRNBOY6HRKdzjC8;
                    this.__pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c = __pin_group_Parameters_In_Roj8OttRNtDPhZ0MULZw4c;
                    this.__slot_MUvRyk90XydM4FzbACVFpX = __slot_MUvRyk90XydM4FzbACVFpX;
                    this.__pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3 = __pin_group_Parameters_In_DQah0MHHty4P0K2g6Cw3U3;
                    this.__pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd = __pin_group_Parameters_In_K6UNPLbWcpQOogBuncnIxd;
                    this.__pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP = __pin_group_Input_In_RoTLp2Coz0HPmTUhWDbatP;
                    this.__pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ = __pin_group_Input_In_P3eVhqjS3FUNXUZbBPAflZ;
                    this.__slot_GasJgtyAFJEQRz0YFqFRyz = __slot_GasJgtyAFJEQRz0YFqFRyz;
                    this.__pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm = __pin_group_Input_In_MLomVaQLrpBLa3BYUJmsTm;
                    this.__pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD = __pin_group_Arguments_In_UTGmh8e0IyIOUsVNsoyQvD;
                    this.__pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa = __pin_group_Input_In_QHX6DTMvvHzL0q2tbruhJa;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 327273U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "VuFXVdZpPTEOVSuy71r7md", Name = "RayMarch_Material_VuFXVdZpPTEOVSuy71r7md")]
    [n2.SerializableAttribute]
    public class RayMarch_Material_VuFXVdZpPTEOVSuy71r7md : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.RayMarch_Material_VuFXVdZpPTEOVSuy71r7md Create(n1.NodeContext Node_Context)
        {
            var instance = new RayMarch_Material_VuFXVdZpPTEOVSuy71r7md(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.RayMarch_Material_VuFXVdZpPTEOVSuy71r7md CreateDefault()
        {
            var instance = new RayMarch_Material_VuFXVdZpPTEOVSuy71r7md(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.RayMarch_Material_VuFXVdZpPTEOVSuy71r7md Update(n8.GpuValue<float> SDFT_In, n27.Material Material_In, bool Is_Shadow_Caster_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n28.Entity Entity_Out, out string Shader_Code_Out)
        {
            string __pad_T01g5Wki2oRQKzaJXPFw4W_0 = __slot_T01g5Wki2oRQKzaJXPFw4W;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_Qd43eApO0N5LUOPDoq6ngf;
            if (manager_3 is null)
            {
                manager_3 = new n10.Manager<n2.ValueTuple<n8.GpuValue<float>, n27.Material, string, bool, bool>, n2.ValueTuple<n28.Entity, string>>((default(n28.Entity), ""));
            }

            var inputs_4 = (SDFT_In, Material_In, __pad_T01g5Wki2oRQKzaJXPFw4W_0, Is_Shadow_Caster_In, Enabled_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__O7BNxSpKLN0MPdRpV2t0Ye>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __O7BNxSpKLN0MPdRpV2t0Ye(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz = n21._Operations_.CreateDefault<n8.AbstractGpuValue>(), __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz = n21._Operations_.CreateDefault<n8.IFunctionInvokeNode>(), __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB = n21._Operations_.CreateDefault<string>(), __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d = n21._Operations_.CreateDefault<n8.AbstractGpuValue>(), __slot_F8bAqVcvhK1OXwR3DCLnaT = default(n34.SetVar<float>)};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "DlOXOjN5LvRMRMAEqOltfI", 327302U);
                    var Output_9 = n13.GPUIn_C<float>.Create(Node_Context: Node_Context_8);
                    state_7.__p_DlOXOjN5LvRMRMAEqOltfI = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "CY5m0X0AbrPPHkHmKaIvpl", 327318U);
                    var Output_11 = n33.MeshEntity_C.Create(Node_Context: Node_Context_10);
                    state_7.__p_CY5m0X0AbrPPHkHmKaIvpl = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "MmRt7rpybEELwkTEPa2p1d", 327344U);
                    var Output_13 = n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n11.IEnumerable<n8.InputModifier>>.Create(Node_Context: Node_Context_12);
                    state_7.__p_MmRt7rpybEELwkTEPa2p1d = Output_13;
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "BCxcYMWYR5YLgUS2Ek3ba3", 327387U);
                    var Output_15 = n32.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float>.Create(Node_Context: Node_Context_14);
                    state_7.__p_BCxcYMWYR5YLgUS2Ek3ba3 = Output_15;
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "BvCPY1QOQr1OTpzROBcBxz", 327396U);
                    var Output_17 = n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.Create(Node_Context: Node_Context_16);
                    state_7.__p_BvCPY1QOQr1OTpzROBcBxz = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "EZRulHoDN68PPD3zVyxjQP", 327403U);
                    var Output_19 = n14.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n9.Vector3>.Create(Node_Context: Node_Context_18);
                    state_7.__p_EZRulHoDN68PPD3zVyxjQP = Output_19;
                    var node_20 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "PlaneMesh", "Stride.Models.Meshes");
                    state_7.__p_KNviEbNPgTyQG1tD5NW42O = node_20;
                    var node_21 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "MaterialExtension", "Stride.Advanced.Materials");
                    state_7.__p_FNhyZET0NX0PM3c455qRSs = node_21;
                    var node_22 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "FuseCommonDrawPosNormExtension", "Stride.Rendering.Experimental.ShaderFX");
                    state_7.__p_MFpfQ96qibFLmgwAWv2uIO = node_22;
                }

                string __pad_KYLU1XybjdGNqPXoWlWcfX_23 = __slot_KYLU1XybjdGNqPXoWlWcfX;
                n8.GpuValue<n9.Vector3> __pad_MZY7mz46FcWNRu97pM12Ru_24 = __slot_MZY7mz46FcWNRu97pM12Ru;
                string __pad_U3Dtta1tq6rPGZTlfZCk7I_25 = __slot_U3Dtta1tq6rPGZTlfZCk7I;
                string __pad_PjSTmwAYteWOAAc77NFlDN_26 = __slot_PjSTmwAYteWOAAc77NFlDN;
                float __pad_Dp9reY7mkA8LW2TXpAl356_27 = __slot_Dp9reY7mkA8LW2TXpAl356;
                n9.Vector3 __pad_UEJKboc7TqsL0rYmgvU2vF_28 = __slot_UEJKboc7TqsL0rYmgvU2vF;
                n9.Vector3 __pad_A5RQUxzHxn4MvKSMMCiIYd_29 = __slot_A5RQUxzHxn4MvKSMMCiIYd;
                n9.Vector2 __pad_P3lEsMtC4hwPfOGRxCYFot_30 = __slot_P3lEsMtC4hwPfOGRxCYFot;
                bool __pad_DCwjsJzxewlPXSb1By2nSR_31 = __slot_DCwjsJzxewlPXSb1By2nSR;
                var State_Output_33 = state_7.__p_DlOXOjN5LvRMRMAEqOltfI.Update(Output_Out: out n8.GpuValue<float> Output_32);
                bool SetValue_34 = true;
                var Output_35 = State_Output_33;
                if (SetValue_34)
                {
                    Output_35 = State_Output_33.SetValue(Input_In: __pad_Dp9reY7mkA8LW2TXpAl356_27);
                }

                int Id_36 = 0;
                var State_Output_38 = state_7.__p_EZRulHoDN68PPD3zVyxjQP.Update(The_Override_In: __pad_MZY7mz46FcWNRu97pM12Ru_24, Id_In: Id_36, Output_Out: out n8.GpuValue<n9.Vector3> Output_37);
                var builder_39 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz, 1);
                builder_39.Add(Output_37);
                var __pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz_40 = builder_39.Commit();
                var State_Output_42 = state_7.__p_BvCPY1QOQr1OTpzROBcBxz.Update(Function_In: SDFT_In, Parameters_In: __pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz_40, Id_In: __pad_KYLU1XybjdGNqPXoWlWcfX_23, Output_Out: out n8.FunctionInvokeNode<float> Output_41);
                n8.IFunctionInvokeNode Input_43 = (n8.IFunctionInvokeNode)Output_41;
                var builder_44 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz, 1);
                builder_44.Add(Input_43);
                var __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz_45 = builder_44.Commit();
                n21._Operations_.FromValue<n8.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz_45, Result_Out: out n5.Spread<n8.IFunctionInvokeNode> Result_46);
                var builder_47 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB, 2);
                builder_47.Add(__pad_U3Dtta1tq6rPGZTlfZCk7I_25);
                builder_47.Add(__pad_PjSTmwAYteWOAAc77NFlDN_26);
                var __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB_48 = builder_47.Commit();
                n21._Operations_.Cons<string>(Input_In: __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB_48, Result_Out: out n5.Spread<string> Result_49);
                n11.IEnumerable<string> Mixins_50 = (n11.IEnumerable<string>)Result_49;
                string Function_Name_51 = "RayMarchPBR";
                n8.GpuValue<float> Default_Result_52 = default(n8.GpuValue<float>);
                n22.ImmutableDictionary<string, string> Template_Values_53 = n23._Operations_.CreateDefault<string, string>();
                bool Is_Groupable_54 = false;
                n11.IEnumerable<n8.InputModifier> The_Modifiers_55 = n24._Operations_.CreateDefault<n8.InputModifier>();
                var builder_56 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d, 1);
                builder_56.Add(Output_32);
                var __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d_57 = builder_56.Commit();
                var State_Output_60 = state_7.__p_MmRt7rpybEELwkTEPa2p1d.Update(Arguments_In: __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d_57, Function_Name_In: Function_Name_51, Code_Template_In: __pad_T01g5Wki2oRQKzaJXPFw4W_0, Default_Result_In: Default_Result_52, Functions_In: Result_46, Mixins_In: Mixins_50, Template_Values_In: Template_Values_53, Is_Groupable_In: Is_Groupable_54, The_Modifiers_In: The_Modifiers_55, Output_Out: out n8.GpuValue<float> Output_58, AdditionalOutputs_Out: out n5.Spread<n8.AbstractGpuValue> AdditionalOutputs_59);
                var State_Output_64 = state_7.__p_BCxcYMWYR5YLgUS2Ek3ba3.Update(GpuValue_In: Output_58, Output_Out: out n34.SetVar<float> Output_61, Original_Shader_Source_Out: out n35.ToShaderFX<float> Original_Shader_Source_62, Shader_Code_Out: out string Shader_Code_63);
                n34.SetVar<float> __pad_F8bAqVcvhK1OXwR3DCLnaT_65 = Output_61;
                n36.IComputeNode Surface_66 = (n36.IComputeNode)Original_Shader_Source_62;
                n1.CompilationHelper.WritePin(state_7.__p_MFpfQ96qibFLmgwAWv2uIO.Inputs[0], ref Surface_66);
                n1.CompilationHelper.ReadPin(state_7.__p_MFpfQ96qibFLmgwAWv2uIO.Outputs[0], out n36.IComputeNode out_67);
                n1.CompilationHelper.WritePin(state_7.__p_KNviEbNPgTyQG1tD5NW42O.Inputs[0], ref __pad_P3lEsMtC4hwPfOGRxCYFot_30);
                n1.CompilationHelper.WritePin(state_7.__p_KNviEbNPgTyQG1tD5NW42O.Inputs[3], ref __pad_DCwjsJzxewlPXSb1By2nSR_31);
                n1.CompilationHelper.ReadPin(state_7.__p_KNviEbNPgTyQG1tD5NW42O.Outputs[0], out n27.Mesh out_68);
                var Output_69 = new n9.BoundingBox(minimum: __pad_UEJKboc7TqsL0rYmgvU2vF_28, maximum: __pad_A5RQUxzHxn4MvKSMMCiIYd_29);
                out_68.BoundingBox = Output_69;
                bool SetMesh_70 = true;
                var Output_71 = state_7.__p_CY5m0X0AbrPPHkHmKaIvpl;
                if (SetMesh_70)
                {
                    Output_71 = state_7.__p_CY5m0X0AbrPPHkHmKaIvpl.SetMesh(Mesh_In: out_68);
                }

                n1.CompilationHelper.WritePin(state_7.__p_FNhyZET0NX0PM3c455qRSs.Inputs[0], ref Material_In);
                n1.CompilationHelper.WritePin(state_7.__p_FNhyZET0NX0PM3c455qRSs.Inputs[1], ref out_67);
                bool Cutoff_72 = true;
                n1.CompilationHelper.WritePin(state_7.__p_FNhyZET0NX0PM3c455qRSs.Inputs[4], ref Cutoff_72);
                n1.CompilationHelper.ReadPin(state_7.__p_FNhyZET0NX0PM3c455qRSs.Outputs[0], out n27.Material out_73);
                bool SetMaterial_74 = true;
                var Output_75 = Output_71;
                if (SetMaterial_74)
                {
                    Output_75 = Output_71.SetMaterial(Material_In: out_73);
                }

                bool SetIsShadowCaster_76 = true;
                var Output_77 = Output_75;
                if (SetIsShadowCaster_76)
                {
                    Output_77 = Output_75.SetIsShadowCaster(Is_Shadow_Caster_In: Is_Shadow_Caster_In);
                }

                bool SetEnabled_78 = true;
                var Output_79 = Output_77;
                if (SetEnabled_78)
                {
                    Output_79 = Output_77.SetEnabled(Enabled_In: Enabled_In);
                }

                var Output_81 = Output_79.Update(Entity_Out: out n28.Entity Entity_80);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_35 != state_7.__p_DlOXOjN5LvRMRMAEqOltfI || State_Output_38 != state_7.__p_EZRulHoDN68PPD3zVyxjQP || __pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz_40 != state_7.__pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz || State_Output_42 != state_7.__p_BvCPY1QOQr1OTpzROBcBxz || __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz_45 != state_7.__pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz || __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB_48 != state_7.__pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB || __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d_57 != state_7.__pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d || State_Output_60 != state_7.__p_MmRt7rpybEELwkTEPa2p1d || State_Output_64 != state_7.__p_BCxcYMWYR5YLgUS2Ek3ba3 || Output_61 != state_7.__slot_F8bAqVcvhK1OXwR3DCLnaT || state_7.__p_MFpfQ96qibFLmgwAWv2uIO != state_7.__p_MFpfQ96qibFLmgwAWv2uIO || state_7.__p_KNviEbNPgTyQG1tD5NW42O != state_7.__p_KNviEbNPgTyQG1tD5NW42O || Output_81 != state_7.__p_CY5m0X0AbrPPHkHmKaIvpl || state_7.__p_FNhyZET0NX0PM3c455qRSs != state_7.__p_FNhyZET0NX0PM3c455qRSs ? new __O7BNxSpKLN0MPdRpV2t0Ye(state_7)
                    {__p_DlOXOjN5LvRMRMAEqOltfI = Output_35, __p_EZRulHoDN68PPD3zVyxjQP = State_Output_38, __pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz = __pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz_40, __p_BvCPY1QOQr1OTpzROBcBxz = State_Output_42, __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz = __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz_45, __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB = __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB_48, __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d = __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d_57, __p_MmRt7rpybEELwkTEPa2p1d = State_Output_60, __p_BCxcYMWYR5YLgUS2Ek3ba3 = State_Output_64, __slot_F8bAqVcvhK1OXwR3DCLnaT = Output_61, __p_MFpfQ96qibFLmgwAWv2uIO = state_7.__p_MFpfQ96qibFLmgwAWv2uIO, __p_KNviEbNPgTyQG1tD5NW42O = state_7.__p_KNviEbNPgTyQG1tD5NW42O, __p_CY5m0X0AbrPPHkHmKaIvpl = Output_81, __p_FNhyZET0NX0PM3c455qRSs = state_7.__p_FNhyZET0NX0PM3c455qRSs} : state_7;
                else
                {
                    state_7.__p_DlOXOjN5LvRMRMAEqOltfI = Output_35;
                    state_7.__p_EZRulHoDN68PPD3zVyxjQP = State_Output_38;
                    state_7.__pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz = __pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz_40;
                    state_7.__p_BvCPY1QOQr1OTpzROBcBxz = State_Output_42;
                    state_7.__pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz = __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz_45;
                    state_7.__pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB = __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB_48;
                    state_7.__pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d = __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d_57;
                    state_7.__p_MmRt7rpybEELwkTEPa2p1d = State_Output_60;
                    state_7.__p_BCxcYMWYR5YLgUS2Ek3ba3 = State_Output_64;
                    state_7.__slot_F8bAqVcvhK1OXwR3DCLnaT = Output_61;
                    state_7.__p_MFpfQ96qibFLmgwAWv2uIO = state_7.__p_MFpfQ96qibFLmgwAWv2uIO;
                    state_7.__p_KNviEbNPgTyQG1tD5NW42O = state_7.__p_KNviEbNPgTyQG1tD5NW42O;
                    state_7.__p_CY5m0X0AbrPPHkHmKaIvpl = Output_81;
                    state_7.__p_FNhyZET0NX0PM3c455qRSs = state_7.__p_FNhyZET0NX0PM3c455qRSs;
                }

                outputs_5 = (Entity_80, Shader_Code_63);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var(__auto_82, __auto_83) = outputs_5;
            Entity_Out = __auto_82;
            Shader_Code_Out = __auto_83;
            n3.RayMarch_Material_VuFXVdZpPTEOVSuy71r7md that_84 = this;
            if (this.__GetContext__().IsImmutable)
                that_84 = manager_3 != this.__cache_Qd43eApO0N5LUOPDoq6ngf ? new RayMarch_Material_VuFXVdZpPTEOVSuy71r7md(this)
                {__cache_Qd43eApO0N5LUOPDoq6ngf = manager_3} : that_84;
            else
            {
                this.__cache_Qd43eApO0N5LUOPDoq6ngf = manager_3;
            }

            return that_84;
        }

        public n3.RayMarch_Material_VuFXVdZpPTEOVSuy71r7md __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.RayMarch_Material_VuFXVdZpPTEOVSuy71r7md that_0 = this;
            this.__cache_Qd43eApO0N5LUOPDoq6ngf = null;
            return that_0;
        }

        public n3.RayMarch_Material_VuFXVdZpPTEOVSuy71r7md __CreateDefault__()
        {
            n3.RayMarch_Material_VuFXVdZpPTEOVSuy71r7md that_0 = this;
            this.__cache_Qd43eApO0N5LUOPDoq6ngf = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_Qd43eApO0N5LUOPDoq6ngf);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 327277U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "T01g5Wki2oRQKzaJXPFw4W", Name = "__slot_T01g5Wki2oRQKzaJXPFw4W")]
        public static string __slot_T01g5Wki2oRQKzaJXPFw4W = "override stage float SDF(float3 p)\r\n{\r\n    return ${FuseSDF}(p);\r\n}\r\n\r\n\r\nfloat ${signature} (float myValue)\r\n{\r\n    return myValue;\r\n}\r\n\r\n\r\noverride stage void posNormByFunction (out float3 p, out float3 n)\r\n{\r\n    // Raymarcher \r\n    ////////////////////////////////////////////////////////////////\r\n\r\n    // Takes uv as input\r\n    float2 uv = streams.TexCoord.xy; \r\n    float3 rd;   \t\r\n    float z; \r\n    rayMarcher(uv, p, n, rd, z); \r\n    // Outputs surface posistion(p) & normals(n), ray direction(rd) & length(z) \r\n\r\n    ////////////////////////////////////////////////////////////////\r\n}";
        [n1.ElementAttribute(TracingId = 327518U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "RZhrGIkDMD7N58lMDXY0Q8", Name = "__slot_RZhrGIkDMD7N58lMDXY0Q8")]
        public static string __slot_RZhrGIkDMD7N58lMDXY0Q8 = "// raymarcher\r\nfloat SDF(float3 p) // should be override unless it's the first imp.  Gets called by the other functions\r\n{\r\n\treturn ${SDF}(p);\r\n}\r\n\r\nRay ${signature}(float3 p, int maxIter)\r\n{\r\n\tRay ray = ${SETUP}();\r\n\tfloat2 minMaxDist = ${CULL}(ray);\r\n\tmarchRayDefualt(ray, minMaxDist, maxIter);\r\n\treturn ray;\r\n}";
        [n1.ElementAttribute(TracingId = 327282U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Qd43eApO0N5LUOPDoq6ngf", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n10.Manager<n2.ValueTuple<n8.GpuValue<float>, n27.Material, string, bool, bool>, n2.ValueTuple<n28.Entity, string>> __cache_Qd43eApO0N5LUOPDoq6ngf = null;
        [n1.ElementAttribute(TracingId = 327369U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "KYLU1XybjdGNqPXoWlWcfX", Name = "__slot_KYLU1XybjdGNqPXoWlWcfX")]
        public static string __slot_KYLU1XybjdGNqPXoWlWcfX = "FuseSDF";
        [n1.ElementAttribute(TracingId = 327314U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "MZY7mz46FcWNRu97pM12Ru", Name = "__slot_MZY7mz46FcWNRu97pM12Ru")]
        public static n8.GpuValue<n9.Vector3> __slot_MZY7mz46FcWNRu97pM12Ru = default(n8.GpuValue<n9.Vector3>);
        [n1.ElementAttribute(TracingId = 327372U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "U3Dtta1tq6rPGZTlfZCk7I", Name = "__slot_U3Dtta1tq6rPGZTlfZCk7I")]
        public static string __slot_U3Dtta1tq6rPGZTlfZCk7I = "FuseRayMarch";
        [n1.ElementAttribute(TracingId = 327384U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "PjSTmwAYteWOAAc77NFlDN", Name = "__slot_PjSTmwAYteWOAAc77NFlDN")]
        public static string __slot_PjSTmwAYteWOAAc77NFlDN = "FuseCommonDrawPosNorm";
        [n1.ElementAttribute(TracingId = 327310U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Dp9reY7mkA8LW2TXpAl356", Name = "__slot_Dp9reY7mkA8LW2TXpAl356")]
        public static float __slot_Dp9reY7mkA8LW2TXpAl356 = 0.25F;
        [n1.ElementAttribute(TracingId = 327504U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "UEJKboc7TqsL0rYmgvU2vF", Name = "__slot_UEJKboc7TqsL0rYmgvU2vF")]
        public static n9.Vector3 __slot_UEJKboc7TqsL0rYmgvU2vF = n1.CompilationHelper.Deserialize<n9.Vector3>("-10, -10, -10", false, "RGYLe02tPXEQEO6aJ6Qsjm", "UEJKboc7TqsL0rYmgvU2vF");
        [n1.ElementAttribute(TracingId = 327505U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "A5RQUxzHxn4MvKSMMCiIYd", Name = "__slot_A5RQUxzHxn4MvKSMMCiIYd")]
        public static n9.Vector3 __slot_A5RQUxzHxn4MvKSMMCiIYd = n1.CompilationHelper.Deserialize<n9.Vector3>("10, 10, 10", false, "RGYLe02tPXEQEO6aJ6Qsjm", "A5RQUxzHxn4MvKSMMCiIYd");
        [n1.ElementAttribute(TracingId = 327442U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "P3lEsMtC4hwPfOGRxCYFot", Name = "__slot_P3lEsMtC4hwPfOGRxCYFot")]
        public static n9.Vector2 __slot_P3lEsMtC4hwPfOGRxCYFot = n1.CompilationHelper.Deserialize<n9.Vector2>("2, 2", false, "RGYLe02tPXEQEO6aJ6Qsjm", "P3lEsMtC4hwPfOGRxCYFot");
        [n1.ElementAttribute(TracingId = 327447U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "DCwjsJzxewlPXSb1By2nSR", Name = "__slot_DCwjsJzxewlPXSb1By2nSR")]
        public static bool __slot_DCwjsJzxewlPXSb1By2nSR = false;
        static RayMarch_Material_VuFXVdZpPTEOVSuy71r7md()
        {
        }

        public RayMarch_Material_VuFXVdZpPTEOVSuy71r7md(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RayMarch_Material_VuFXVdZpPTEOVSuy71r7md(RayMarch_Material_VuFXVdZpPTEOVSuy71r7md other): base(other)
        {
            this.__cache_Qd43eApO0N5LUOPDoq6ngf = other.__cache_Qd43eApO0N5LUOPDoq6ngf;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Qd43eApO0N5LUOPDoq6ngf", in __cache_Qd43eApO0N5LUOPDoq6ngf));
        }

        internal RayMarch_Material_VuFXVdZpPTEOVSuy71r7md __WITH__(n10.Manager<n2.ValueTuple<n8.GpuValue<float>, n27.Material, string, bool, bool>, n2.ValueTuple<n28.Entity, string>> __cache_Qd43eApO0N5LUOPDoq6ngf)
        {
            n3.RayMarch_Material_VuFXVdZpPTEOVSuy71r7md that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Qd43eApO0N5LUOPDoq6ngf != this.__cache_Qd43eApO0N5LUOPDoq6ngf ? new RayMarch_Material_VuFXVdZpPTEOVSuy71r7md(this)
                {__cache_Qd43eApO0N5LUOPDoq6ngf = __cache_Qd43eApO0N5LUOPDoq6ngf} : that_0;
            else
            {
                this.__cache_Qd43eApO0N5LUOPDoq6ngf = __cache_Qd43eApO0N5LUOPDoq6ngf;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "O7BNxSpKLN0MPdRpV2t0Ye", Name = "__O7BNxSpKLN0MPdRpV2t0Ye")]
        [n2.SerializableAttribute]
        public class __O7BNxSpKLN0MPdRpV2t0Ye : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_DlOXOjN5LvRMRMAEqOltfI);
                n1.CompilationHelper.SafeDispose(this.__p_CY5m0X0AbrPPHkHmKaIvpl);
                n1.CompilationHelper.SafeDispose(this.__p_MmRt7rpybEELwkTEPa2p1d);
                n1.CompilationHelper.SafeDispose(this.__p_BCxcYMWYR5YLgUS2Ek3ba3);
                n1.CompilationHelper.SafeDispose(this.__p_BvCPY1QOQr1OTpzROBcBxz);
                n1.CompilationHelper.SafeDispose(this.__p_EZRulHoDN68PPD3zVyxjQP);
                n1.CompilationHelper.SafeDispose(this.__p_KNviEbNPgTyQG1tD5NW42O);
                n1.CompilationHelper.SafeDispose(this.__p_FNhyZET0NX0PM3c455qRSs);
                n1.CompilationHelper.SafeDispose(this.__p_MFpfQ96qibFLmgwAWv2uIO);
                return;
            }

            [n1.ElementAttribute(TracingId = 327302U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "DlOXOjN5LvRMRMAEqOltfI", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
            public n13.GPUIn_C<float> __p_DlOXOjN5LvRMRMAEqOltfI;
            [n1.ElementAttribute(TracingId = 327318U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "CY5m0X0AbrPPHkHmKaIvpl", Name = "MeshEntity", IsManaged = true, IsAutoGenerated = true)]
            public n33.MeshEntity_C __p_CY5m0X0AbrPPHkHmKaIvpl;
            [n1.ElementAttribute(TracingId = 327344U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "MmRt7rpybEELwkTEPa2p1d", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n11.IEnumerable<n8.InputModifier>> __p_MmRt7rpybEELwkTEPa2p1d;
            [n1.ElementAttribute(TracingId = 327387U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "BCxcYMWYR5YLgUS2Ek3ba3", Name = "ToShaderFX", IsManaged = true, IsAutoGenerated = true)]
            public n32.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_BCxcYMWYR5YLgUS2Ek3ba3;
            [n1.ElementAttribute(TracingId = 327396U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "BvCPY1QOQr1OTpzROBcBxz", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_BvCPY1QOQr1OTpzROBcBxz;
            [n1.ElementAttribute(TracingId = 327403U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "EZRulHoDN68PPD3zVyxjQP", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n14.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n9.Vector3> __p_EZRulHoDN68PPD3zVyxjQP;
            [n1.ElementAttribute(TracingId = 327412U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "KNviEbNPgTyQG1tD5NW42O", Name = "PlaneMesh", IsManaged = true, IsAutoGenerated = true, NodeName = "PlaneMesh", NodeCategory = "Stride.Models.Meshes")]
            public n1.IVLNode __p_KNviEbNPgTyQG1tD5NW42O;
            [n1.ElementAttribute(TracingId = 327462U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "FNhyZET0NX0PM3c455qRSs", Name = "MaterialExtension", IsManaged = true, IsAutoGenerated = true, NodeName = "MaterialExtension", NodeCategory = "Stride.Advanced.Materials")]
            public n1.IVLNode __p_FNhyZET0NX0PM3c455qRSs;
            [n1.ElementAttribute(TracingId = 327472U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "MFpfQ96qibFLmgwAWv2uIO", Name = "FuseCommonDrawPosNormExtension", IsManaged = true, IsAutoGenerated = true, NodeName = "FuseCommonDrawPosNormExtension", NodeCategory = "Stride.Rendering.Experimental.ShaderFX")]
            public n1.IVLNode __p_MFpfQ96qibFLmgwAWv2uIO;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz = default(n5.Spread<n8.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.IFunctionInvokeNode> __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz = default(n5.Spread<n8.IFunctionInvokeNode>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<string> __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB = default(n5.Spread<string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d = default(n5.Spread<n8.AbstractGpuValue>);
            [n1.ElementAttribute(TracingId = 327477U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "F8bAqVcvhK1OXwR3DCLnaT", Name = "__slot_F8bAqVcvhK1OXwR3DCLnaT")]
            public n34.SetVar<float> __slot_F8bAqVcvhK1OXwR3DCLnaT;
            public __O7BNxSpKLN0MPdRpV2t0Ye(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __O7BNxSpKLN0MPdRpV2t0Ye(__O7BNxSpKLN0MPdRpV2t0Ye other): base(other)
            {
                this.__p_DlOXOjN5LvRMRMAEqOltfI = other.__p_DlOXOjN5LvRMRMAEqOltfI;
                this.__p_CY5m0X0AbrPPHkHmKaIvpl = other.__p_CY5m0X0AbrPPHkHmKaIvpl;
                this.__p_MmRt7rpybEELwkTEPa2p1d = other.__p_MmRt7rpybEELwkTEPa2p1d;
                this.__p_BCxcYMWYR5YLgUS2Ek3ba3 = other.__p_BCxcYMWYR5YLgUS2Ek3ba3;
                this.__p_BvCPY1QOQr1OTpzROBcBxz = other.__p_BvCPY1QOQr1OTpzROBcBxz;
                this.__p_EZRulHoDN68PPD3zVyxjQP = other.__p_EZRulHoDN68PPD3zVyxjQP;
                this.__p_KNviEbNPgTyQG1tD5NW42O = other.__p_KNviEbNPgTyQG1tD5NW42O;
                this.__p_FNhyZET0NX0PM3c455qRSs = other.__p_FNhyZET0NX0PM3c455qRSs;
                this.__p_MFpfQ96qibFLmgwAWv2uIO = other.__p_MFpfQ96qibFLmgwAWv2uIO;
                this.__pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz = other.__pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz;
                this.__pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz = other.__pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz;
                this.__pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB = other.__pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB;
                this.__pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d = other.__pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d;
                this.__slot_F8bAqVcvhK1OXwR3DCLnaT = other.__slot_F8bAqVcvhK1OXwR3DCLnaT;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DlOXOjN5LvRMRMAEqOltfI", in __p_DlOXOjN5LvRMRMAEqOltfI), n1.CompilationHelper.GetValueOrExisting(values, "__p_CY5m0X0AbrPPHkHmKaIvpl", in __p_CY5m0X0AbrPPHkHmKaIvpl), n1.CompilationHelper.GetValueOrExisting(values, "__p_MmRt7rpybEELwkTEPa2p1d", in __p_MmRt7rpybEELwkTEPa2p1d), n1.CompilationHelper.GetValueOrExisting(values, "__p_BCxcYMWYR5YLgUS2Ek3ba3", in __p_BCxcYMWYR5YLgUS2Ek3ba3), n1.CompilationHelper.GetValueOrExisting(values, "__p_BvCPY1QOQr1OTpzROBcBxz", in __p_BvCPY1QOQr1OTpzROBcBxz), n1.CompilationHelper.GetValueOrExisting(values, "__p_EZRulHoDN68PPD3zVyxjQP", in __p_EZRulHoDN68PPD3zVyxjQP), n1.CompilationHelper.GetValueOrExisting(values, "__p_KNviEbNPgTyQG1tD5NW42O", in __p_KNviEbNPgTyQG1tD5NW42O), n1.CompilationHelper.GetValueOrExisting(values, "__p_FNhyZET0NX0PM3c455qRSs", in __p_FNhyZET0NX0PM3c455qRSs), n1.CompilationHelper.GetValueOrExisting(values, "__p_MFpfQ96qibFLmgwAWv2uIO", in __p_MFpfQ96qibFLmgwAWv2uIO), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz", in __pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz", in __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB", in __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d", in __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d), n1.CompilationHelper.GetValueOrExisting(values, "__slot_F8bAqVcvhK1OXwR3DCLnaT", in __slot_F8bAqVcvhK1OXwR3DCLnaT));
            }

            internal __O7BNxSpKLN0MPdRpV2t0Ye __WITH__(n13.GPUIn_C<float> __p_DlOXOjN5LvRMRMAEqOltfI, n33.MeshEntity_C __p_CY5m0X0AbrPPHkHmKaIvpl, n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n11.IEnumerable<n8.InputModifier>> __p_MmRt7rpybEELwkTEPa2p1d, n32.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_BCxcYMWYR5YLgUS2Ek3ba3, n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_BvCPY1QOQr1OTpzROBcBxz, n14.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n9.Vector3> __p_EZRulHoDN68PPD3zVyxjQP, n1.IVLNode __p_KNviEbNPgTyQG1tD5NW42O, n1.IVLNode __p_FNhyZET0NX0PM3c455qRSs, n1.IVLNode __p_MFpfQ96qibFLmgwAWv2uIO, n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz, n5.Spread<n8.IFunctionInvokeNode> __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz, n5.Spread<string> __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB, n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d, n34.SetVar<float> __slot_F8bAqVcvhK1OXwR3DCLnaT)
            {
                __O7BNxSpKLN0MPdRpV2t0Ye that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_DlOXOjN5LvRMRMAEqOltfI != this.__p_DlOXOjN5LvRMRMAEqOltfI || __p_CY5m0X0AbrPPHkHmKaIvpl != this.__p_CY5m0X0AbrPPHkHmKaIvpl || __p_MmRt7rpybEELwkTEPa2p1d != this.__p_MmRt7rpybEELwkTEPa2p1d || __p_BCxcYMWYR5YLgUS2Ek3ba3 != this.__p_BCxcYMWYR5YLgUS2Ek3ba3 || __p_BvCPY1QOQr1OTpzROBcBxz != this.__p_BvCPY1QOQr1OTpzROBcBxz || __p_EZRulHoDN68PPD3zVyxjQP != this.__p_EZRulHoDN68PPD3zVyxjQP || __p_KNviEbNPgTyQG1tD5NW42O != this.__p_KNviEbNPgTyQG1tD5NW42O || __p_FNhyZET0NX0PM3c455qRSs != this.__p_FNhyZET0NX0PM3c455qRSs || __p_MFpfQ96qibFLmgwAWv2uIO != this.__p_MFpfQ96qibFLmgwAWv2uIO || __pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz != this.__pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz || __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz != this.__pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz || __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB != this.__pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB || __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d != this.__pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d || __slot_F8bAqVcvhK1OXwR3DCLnaT != this.__slot_F8bAqVcvhK1OXwR3DCLnaT ? new __O7BNxSpKLN0MPdRpV2t0Ye(this)
                    {__p_DlOXOjN5LvRMRMAEqOltfI = __p_DlOXOjN5LvRMRMAEqOltfI, __p_CY5m0X0AbrPPHkHmKaIvpl = __p_CY5m0X0AbrPPHkHmKaIvpl, __p_MmRt7rpybEELwkTEPa2p1d = __p_MmRt7rpybEELwkTEPa2p1d, __p_BCxcYMWYR5YLgUS2Ek3ba3 = __p_BCxcYMWYR5YLgUS2Ek3ba3, __p_BvCPY1QOQr1OTpzROBcBxz = __p_BvCPY1QOQr1OTpzROBcBxz, __p_EZRulHoDN68PPD3zVyxjQP = __p_EZRulHoDN68PPD3zVyxjQP, __p_KNviEbNPgTyQG1tD5NW42O = __p_KNviEbNPgTyQG1tD5NW42O, __p_FNhyZET0NX0PM3c455qRSs = __p_FNhyZET0NX0PM3c455qRSs, __p_MFpfQ96qibFLmgwAWv2uIO = __p_MFpfQ96qibFLmgwAWv2uIO, __pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz = __pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz, __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz = __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz, __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB = __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB, __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d = __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d, __slot_F8bAqVcvhK1OXwR3DCLnaT = __slot_F8bAqVcvhK1OXwR3DCLnaT} : that_0;
                else
                {
                    this.__p_DlOXOjN5LvRMRMAEqOltfI = __p_DlOXOjN5LvRMRMAEqOltfI;
                    this.__p_CY5m0X0AbrPPHkHmKaIvpl = __p_CY5m0X0AbrPPHkHmKaIvpl;
                    this.__p_MmRt7rpybEELwkTEPa2p1d = __p_MmRt7rpybEELwkTEPa2p1d;
                    this.__p_BCxcYMWYR5YLgUS2Ek3ba3 = __p_BCxcYMWYR5YLgUS2Ek3ba3;
                    this.__p_BvCPY1QOQr1OTpzROBcBxz = __p_BvCPY1QOQr1OTpzROBcBxz;
                    this.__p_EZRulHoDN68PPD3zVyxjQP = __p_EZRulHoDN68PPD3zVyxjQP;
                    this.__p_KNviEbNPgTyQG1tD5NW42O = __p_KNviEbNPgTyQG1tD5NW42O;
                    this.__p_FNhyZET0NX0PM3c455qRSs = __p_FNhyZET0NX0PM3c455qRSs;
                    this.__p_MFpfQ96qibFLmgwAWv2uIO = __p_MFpfQ96qibFLmgwAWv2uIO;
                    this.__pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz = __pin_group_Parameters_In_BvCPY1QOQr1OTpzROBcBxz;
                    this.__pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz = __pin_group_Input_In_QjcC1jmG8Z8PnuUOYL4Izz;
                    this.__pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB = __pin_group_Input_In_GGUvkIGO1IXLnYy1hiXJVB;
                    this.__pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d = __pin_group_Arguments_In_MmRt7rpybEELwkTEPa2p1d;
                    this.__slot_F8bAqVcvhK1OXwR3DCLnaT = __slot_F8bAqVcvhK1OXwR3DCLnaT;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 327616U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "HUDROnpSFpnMTVDf6D9p93", Name = "ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93")]
    [n2.SerializableAttribute]
    public class ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93 Create(n1.NodeContext Node_Context)
        {
            var instance = new ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93 CreateDefault()
        {
            var instance = new ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93 Update(n8.GpuValue<float> SDF_In, n8.GpuValue<n9.Vector3> Ray_Position_In, n8.GpuValue<n9.Vector3> Ray_Direction_In, n8.GpuValue<float> Step_Length_In, n8.GpuValue<float> Min_Distance_In, n8.GpuValue<float> Max_Distance_In, [n4.SerializedDefaultValueAttribute("120", false)] int Max_Iterations_In, out n8.GpuValue<n9.Vector3> Output_Out)
        {
            string __pad_MRilQDuiSlgPLxew8ikHeb_0 = __slot_MRilQDuiSlgPLxew8ikHeb;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_FE0isfYslSfP6PSg4Bfyrn;
            if (manager_3 is null)
            {
                manager_3 = new n10.Manager<n2.ValueTuple<string, n8.GpuValue<float>, n8.GpuValue<n9.Vector3>, n8.GpuValue<n9.Vector3>, n8.GpuValue<float>, n8.GpuValue<float>, n8.GpuValue<float>, n2.ValueTuple<int>>, n2.ValueTuple<n8.GpuValue<n9.Vector3>>>(n2.ValueTuple.Create(default(n8.GpuValue<n9.Vector3>)));
            }

            var inputs_4 = (__pad_MRilQDuiSlgPLxew8ikHeb_0, SDF_In, Ray_Position_In, Ray_Direction_In, Step_Length_In, Min_Distance_In, Max_Distance_In, Max_Iterations_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__IzARKtNK8rUPLFNP0SrnWh>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __IzARKtNK8rUPLFNP0SrnWh(__GetContext__(), n1.VLObject.NewIdentity())
                    {__slot_Gj9AqtaOGVINGeAWlUtz5g = default(n8.GpuValue<n9.Vector3>), __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM = n21._Operations_.CreateDefault<n8.AbstractGpuValue>(), __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd = n21._Operations_.CreateDefault<n8.IFunctionInvokeNode>(), __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n = n21._Operations_.CreateDefault<string>(), __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k = n21._Operations_.CreateDefault<n8.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "PDcuZcyIGz0QQ05JN8cf8k", 327659U);
                    var Output_9 = n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<n9.Vector3, n11.IEnumerable<n8.InputModifier>>.Create(Node_Context: Node_Context_8);
                    state_7.__p_PDcuZcyIGz0QQ05JN8cf8k = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "SwqmPUW3GVuOjI04SjGGIU", 327701U);
                    var Output_11 = n13.GPUIn_C<int>.Create(Node_Context: Node_Context_10);
                    state_7.__p_SwqmPUW3GVuOjI04SjGGIU = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "K8W6K38MRUzOqjT7QMfugE", 327717U);
                    var Output_13 = n18.Position_PeLDdeSku4ANhU5oe5SfPy.Create(Node_Context: Node_Context_12);
                    state_7.__p_K8W6K38MRUzOqjT7QMfugE = Output_13;
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "RfHXehgFrDoMWlydb7V1EX", 327722U);
                    var Output_15 = n20.To_Qgkn15Kxt1HLURmAdSAN7m<n9.Vector4, n9.Vector3>.Create(Node_Context: Node_Context_14);
                    state_7.__p_RfHXehgFrDoMWlydb7V1EX = Output_15;
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "ROJzOFNqtTZNxmUJMDbesM", 327739U);
                    var Output_17 = n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.Create(Node_Context: Node_Context_16);
                    state_7.__p_ROJzOFNqtTZNxmUJMDbesM = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "Vp6QHZOnB1iNPWo0KSpTp7", 327749U);
                    var Output_19 = n37.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float>.Create(Node_Context: Node_Context_18);
                    state_7.__p_Vp6QHZOnB1iNPWo0KSpTp7 = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "RLwFUBctlUfNMyg5HOJfGp", 327759U);
                    var Output_21 = n37.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float>.Create(Node_Context: Node_Context_20);
                    state_7.__p_RLwFUBctlUfNMyg5HOJfGp = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "IzVUGZ6jl0yNJPXWLq4TVV", 327772U);
                    var Output_23 = n37.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float>.Create(Node_Context: Node_Context_22);
                    state_7.__p_IzVUGZ6jl0yNJPXWLq4TVV = Output_23;
                    n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "IYNmY5ueSNQORO3Fh45xnA", 327782U);
                    var Output_25 = n19.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n9.Vector3>.Create(Node_Context: Node_Context_24);
                    state_7.__p_IYNmY5ueSNQORO3Fh45xnA = Output_25;
                }

                string __pad_UywGVb6klurPcQIjWHNUFf_26 = __slot_UywGVb6klurPcQIjWHNUFf;
                string __pad_JUtKR8dNGdHOMEG69KaCik_27 = __slot_JUtKR8dNGdHOMEG69KaCik;
                string __pad_F26GmWMbRefOUfFabCGqRk_28 = __slot_F26GmWMbRefOUfFabCGqRk;
                float __pad_Q8YIKwrHm4qPCz8lDtal9a_29 = __slot_Q8YIKwrHm4qPCz8lDtal9a;
                float __pad_NzrkzsmG6cnNTPjObBLRAp_30 = __slot_NzrkzsmG6cnNTPjObBLRAp;
                float __pad_BoAbcEN4acHLsWaVDEFOsU_31 = __slot_BoAbcEN4acHLsWaVDEFOsU;
                var State_Output_33 = state_7.__p_IYNmY5ueSNQORO3Fh45xnA.Update(Input_In: Ray_Direction_In, Output_Out: out n8.GpuValue<n9.Vector3> Output_32);
                var State_Output_35 = state_7.__p_Vp6QHZOnB1iNPWo0KSpTp7.Update(GpuValue_In: Step_Length_In, The_Value_In: __pad_Q8YIKwrHm4qPCz8lDtal9a_29, Output_Out: out n8.GpuValue<float> Output_34);
                var State_Output_37 = state_7.__p_RLwFUBctlUfNMyg5HOJfGp.Update(GpuValue_In: Min_Distance_In, The_Value_In: __pad_NzrkzsmG6cnNTPjObBLRAp_30, Output_Out: out n8.GpuValue<float> Output_36);
                var State_Output_39 = state_7.__p_IzVUGZ6jl0yNJPXWLq4TVV.Update(GpuValue_In: Max_Distance_In, The_Value_In: __pad_BoAbcEN4acHLsWaVDEFOsU_31, Output_Out: out n8.GpuValue<float> Output_38);
                var State_Output_41 = state_7.__p_SwqmPUW3GVuOjI04SjGGIU.Update(Output_Out: out n8.GpuValue<int> Output_40);
                var State_Output_43 = state_7.__p_K8W6K38MRUzOqjT7QMfugE.Update(Output_Out: out n8.GpuValue<n9.Vector4> Output_42);
                n8.GpuValue<n9.Vector3> default_44 = default(n8.GpuValue<n9.Vector3>);
                var State_Output_46 = state_7.__p_RfHXehgFrDoMWlydb7V1EX.Update(x_In: Output_42, default_In: default_44, Output_Out: out n8.GpuValue<n9.Vector3> Output_45);
                n8.GpuValue<n9.Vector3> __pad_Gj9AqtaOGVINGeAWlUtz5g_47 = Output_45;
                var builder_48 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM, 1);
                builder_48.Add(__pad_Gj9AqtaOGVINGeAWlUtz5g_47);
                var __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM_49 = builder_48.Commit();
                var State_Output_51 = state_7.__p_ROJzOFNqtTZNxmUJMDbesM.Update(Function_In: SDF_In, Parameters_In: __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM_49, Id_In: __pad_F26GmWMbRefOUfFabCGqRk_28, Output_Out: out n8.FunctionInvokeNode<float> Output_50);
                n8.IFunctionInvokeNode Input_52 = (n8.IFunctionInvokeNode)Output_50;
                var builder_53 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd, 1);
                builder_53.Add(Input_52);
                var __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd_54 = builder_53.Commit();
                n21._Operations_.Cons<n8.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd_54, Result_Out: out n5.Spread<n8.IFunctionInvokeNode> Result_55);
                var builder_56 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n, 1);
                builder_56.Add(__pad_UywGVb6klurPcQIjWHNUFf_26);
                var __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n_57 = builder_56.Commit();
                n21._Operations_.Cons<string>(Input_In: __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n_57, Result_Out: out n5.Spread<string> Result_58);
                n11.IEnumerable<string> Mixins_59 = (n11.IEnumerable<string>)Result_58;
                n8.GpuValue<n9.Vector3> Default_Result_60 = default(n8.GpuValue<n9.Vector3>);
                n22.ImmutableDictionary<string, string> Template_Values_61 = n23._Operations_.CreateDefault<string, string>();
                bool Is_Groupable_62 = false;
                n11.IEnumerable<n8.InputModifier> The_Modifiers_63 = n24._Operations_.CreateDefault<n8.InputModifier>();
                var builder_64 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k, 6);
                builder_64.Add(Ray_Position_In);
                builder_64.Add(Output_32);
                builder_64.Add(Output_34);
                builder_64.Add(Output_36);
                builder_64.Add(Output_38);
                builder_64.Add(Output_40);
                var __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k_65 = builder_64.Commit();
                var State_Output_68 = state_7.__p_PDcuZcyIGz0QQ05JN8cf8k.Update(Arguments_In: __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k_65, Function_Name_In: __pad_JUtKR8dNGdHOMEG69KaCik_27, Code_Template_In: __pad_MRilQDuiSlgPLxew8ikHeb_0, Default_Result_In: Default_Result_60, Functions_In: Result_55, Mixins_In: Mixins_59, Template_Values_In: Template_Values_61, Is_Groupable_In: Is_Groupable_62, The_Modifiers_In: The_Modifiers_63, Output_Out: out n8.GpuValue<n9.Vector3> Output_66, AdditionalOutputs_Out: out n5.Spread<n8.AbstractGpuValue> AdditionalOutputs_67);
                var AdditionalOutputs_69 = (n8.AbstractGpuValue)AdditionalOutputs_67[0];
                bool SetValue_70 = true;
                var Output_71 = State_Output_41;
                if (SetValue_70)
                {
                    Output_71 = State_Output_41.SetValue(Input_In: Max_Iterations_In);
                }

                n2.Object X_72 = n38._Operations_.CreateDefault();
                n39.ObjectHelpers.IsAssigned(x: X_72, result: out bool Result_73, notAssigned: out bool Not_Assigned_74);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_33 != state_7.__p_IYNmY5ueSNQORO3Fh45xnA || State_Output_35 != state_7.__p_Vp6QHZOnB1iNPWo0KSpTp7 || State_Output_37 != state_7.__p_RLwFUBctlUfNMyg5HOJfGp || State_Output_39 != state_7.__p_IzVUGZ6jl0yNJPXWLq4TVV || Output_71 != state_7.__p_SwqmPUW3GVuOjI04SjGGIU || State_Output_43 != state_7.__p_K8W6K38MRUzOqjT7QMfugE || State_Output_46 != state_7.__p_RfHXehgFrDoMWlydb7V1EX || Output_45 != state_7.__slot_Gj9AqtaOGVINGeAWlUtz5g || __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM_49 != state_7.__pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM || State_Output_51 != state_7.__p_ROJzOFNqtTZNxmUJMDbesM || __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd_54 != state_7.__pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd || __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n_57 != state_7.__pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n || __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k_65 != state_7.__pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k || State_Output_68 != state_7.__p_PDcuZcyIGz0QQ05JN8cf8k ? new __IzARKtNK8rUPLFNP0SrnWh(state_7)
                    {__p_IYNmY5ueSNQORO3Fh45xnA = State_Output_33, __p_Vp6QHZOnB1iNPWo0KSpTp7 = State_Output_35, __p_RLwFUBctlUfNMyg5HOJfGp = State_Output_37, __p_IzVUGZ6jl0yNJPXWLq4TVV = State_Output_39, __p_SwqmPUW3GVuOjI04SjGGIU = Output_71, __p_K8W6K38MRUzOqjT7QMfugE = State_Output_43, __p_RfHXehgFrDoMWlydb7V1EX = State_Output_46, __slot_Gj9AqtaOGVINGeAWlUtz5g = Output_45, __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM = __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM_49, __p_ROJzOFNqtTZNxmUJMDbesM = State_Output_51, __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd = __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd_54, __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n = __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n_57, __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k = __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k_65, __p_PDcuZcyIGz0QQ05JN8cf8k = State_Output_68} : state_7;
                else
                {
                    state_7.__p_IYNmY5ueSNQORO3Fh45xnA = State_Output_33;
                    state_7.__p_Vp6QHZOnB1iNPWo0KSpTp7 = State_Output_35;
                    state_7.__p_RLwFUBctlUfNMyg5HOJfGp = State_Output_37;
                    state_7.__p_IzVUGZ6jl0yNJPXWLq4TVV = State_Output_39;
                    state_7.__p_SwqmPUW3GVuOjI04SjGGIU = Output_71;
                    state_7.__p_K8W6K38MRUzOqjT7QMfugE = State_Output_43;
                    state_7.__p_RfHXehgFrDoMWlydb7V1EX = State_Output_46;
                    state_7.__slot_Gj9AqtaOGVINGeAWlUtz5g = Output_45;
                    state_7.__pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM = __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM_49;
                    state_7.__p_ROJzOFNqtTZNxmUJMDbesM = State_Output_51;
                    state_7.__pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd = __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd_54;
                    state_7.__pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n = __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n_57;
                    state_7.__pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k = __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k_65;
                    state_7.__p_PDcuZcyIGz0QQ05JN8cf8k = State_Output_68;
                }

                outputs_5 = n2.ValueTuple.Create(Output_66);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_75 = outputs_5.Item1;
            Output_Out = __auto_75;
            n3.ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93 that_76 = this;
            if (this.__GetContext__().IsImmutable)
                that_76 = manager_3 != this.__cache_FE0isfYslSfP6PSg4Bfyrn ? new ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93(this)
                {__cache_FE0isfYslSfP6PSg4Bfyrn = manager_3} : that_76;
            else
            {
                this.__cache_FE0isfYslSfP6PSg4Bfyrn = manager_3;
            }

            return that_76;
        }

        public n3.ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93 __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93 that_0 = this;
            this.__cache_FE0isfYslSfP6PSg4Bfyrn = null;
            return that_0;
        }

        public n3.ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93 __CreateDefault__()
        {
            n3.ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93 that_0 = this;
            this.__cache_FE0isfYslSfP6PSg4Bfyrn = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_FE0isfYslSfP6PSg4Bfyrn);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 327798U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "MRilQDuiSlgPLxew8ikHeb", Name = "__slot_MRilQDuiSlgPLxew8ikHeb")]
        public static string __slot_MRilQDuiSlgPLxew8ikHeb = "// raymarcher\r\nfloat SDF(float3 p) // should be override unless it's the first imp.  Gets called by the other functions\r\n{\r\n\treturn ${SDF}(p);\r\n}\r\n\r\nRay ${signature}float3 rayPos, float3 rayDir, float stepLength = .9, float minDist = 0.1, float maxDist = 200.0, int maxIter = 120)\r\n{\r\n\tfloat3 p = rayMarch( rayPos, rayDir, stepLength, minDist, maxDist,  maxIter);\r\n\treturn p;\r\n}";
        [n1.ElementAttribute(TracingId = 327619U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "FE0isfYslSfP6PSg4Bfyrn", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n10.Manager<n2.ValueTuple<string, n8.GpuValue<float>, n8.GpuValue<n9.Vector3>, n8.GpuValue<n9.Vector3>, n8.GpuValue<float>, n8.GpuValue<float>, n8.GpuValue<float>, n2.ValueTuple<int>>, n2.ValueTuple<n8.GpuValue<n9.Vector3>>> __cache_FE0isfYslSfP6PSg4Bfyrn = null;
        [n1.ElementAttribute(TracingId = 327699U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "UywGVb6klurPcQIjWHNUFf", Name = "__slot_UywGVb6klurPcQIjWHNUFf")]
        public static string __slot_UywGVb6klurPcQIjWHNUFf = "FuseRayMarch";
        [n1.ElementAttribute(TracingId = 327688U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "JUtKR8dNGdHOMEG69KaCik", Name = "__slot_JUtKR8dNGdHOMEG69KaCik")]
        public static string __slot_JUtKR8dNGdHOMEG69KaCik = "ProjectPointOnSDF3D";
        [n1.ElementAttribute(TracingId = 327689U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "F26GmWMbRefOUfFabCGqRk", Name = "__slot_F26GmWMbRefOUfFabCGqRk")]
        public static string __slot_F26GmWMbRefOUfFabCGqRk = "SDF";
        [n1.ElementAttribute(TracingId = 327756U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Q8YIKwrHm4qPCz8lDtal9a", Name = "__slot_Q8YIKwrHm4qPCz8lDtal9a")]
        public static float __slot_Q8YIKwrHm4qPCz8lDtal9a = 0.9F;
        [n1.ElementAttribute(TracingId = 327770U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "NzrkzsmG6cnNTPjObBLRAp", Name = "__slot_NzrkzsmG6cnNTPjObBLRAp")]
        public static float __slot_NzrkzsmG6cnNTPjObBLRAp = 0.1F;
        [n1.ElementAttribute(TracingId = 327780U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "BoAbcEN4acHLsWaVDEFOsU", Name = "__slot_BoAbcEN4acHLsWaVDEFOsU")]
        public static float __slot_BoAbcEN4acHLsWaVDEFOsU = 100F;
        static ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93()
        {
        }

        public ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93(ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93 other): base(other)
        {
            this.__cache_FE0isfYslSfP6PSg4Bfyrn = other.__cache_FE0isfYslSfP6PSg4Bfyrn;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_FE0isfYslSfP6PSg4Bfyrn", in __cache_FE0isfYslSfP6PSg4Bfyrn));
        }

        internal ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93 __WITH__(n10.Manager<n2.ValueTuple<string, n8.GpuValue<float>, n8.GpuValue<n9.Vector3>, n8.GpuValue<n9.Vector3>, n8.GpuValue<float>, n8.GpuValue<float>, n8.GpuValue<float>, n2.ValueTuple<int>>, n2.ValueTuple<n8.GpuValue<n9.Vector3>>> __cache_FE0isfYslSfP6PSg4Bfyrn)
        {
            n3.ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_FE0isfYslSfP6PSg4Bfyrn != this.__cache_FE0isfYslSfP6PSg4Bfyrn ? new ProjectPointOnSDF_HUDROnpSFpnMTVDf6D9p93(this)
                {__cache_FE0isfYslSfP6PSg4Bfyrn = __cache_FE0isfYslSfP6PSg4Bfyrn} : that_0;
            else
            {
                this.__cache_FE0isfYslSfP6PSg4Bfyrn = __cache_FE0isfYslSfP6PSg4Bfyrn;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "IzARKtNK8rUPLFNP0SrnWh", Name = "__IzARKtNK8rUPLFNP0SrnWh")]
        [n2.SerializableAttribute]
        public class __IzARKtNK8rUPLFNP0SrnWh : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_PDcuZcyIGz0QQ05JN8cf8k);
                n1.CompilationHelper.SafeDispose(this.__p_SwqmPUW3GVuOjI04SjGGIU);
                n1.CompilationHelper.SafeDispose(this.__p_K8W6K38MRUzOqjT7QMfugE);
                n1.CompilationHelper.SafeDispose(this.__p_RfHXehgFrDoMWlydb7V1EX);
                n1.CompilationHelper.SafeDispose(this.__p_ROJzOFNqtTZNxmUJMDbesM);
                n1.CompilationHelper.SafeDispose(this.__p_Vp6QHZOnB1iNPWo0KSpTp7);
                n1.CompilationHelper.SafeDispose(this.__p_RLwFUBctlUfNMyg5HOJfGp);
                n1.CompilationHelper.SafeDispose(this.__p_IzVUGZ6jl0yNJPXWLq4TVV);
                n1.CompilationHelper.SafeDispose(this.__p_IYNmY5ueSNQORO3Fh45xnA);
                return;
            }

            [n1.ElementAttribute(TracingId = 327659U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "PDcuZcyIGz0QQ05JN8cf8k", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<n9.Vector3, n11.IEnumerable<n8.InputModifier>> __p_PDcuZcyIGz0QQ05JN8cf8k;
            [n1.ElementAttribute(TracingId = 327701U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "SwqmPUW3GVuOjI04SjGGIU", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
            public n13.GPUIn_C<int> __p_SwqmPUW3GVuOjI04SjGGIU;
            [n1.ElementAttribute(TracingId = 327717U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "K8W6K38MRUzOqjT7QMfugE", Name = "Position", IsManaged = true, IsAutoGenerated = true)]
            public n18.Position_PeLDdeSku4ANhU5oe5SfPy __p_K8W6K38MRUzOqjT7QMfugE;
            [n1.ElementAttribute(TracingId = 327722U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "RfHXehgFrDoMWlydb7V1EX", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n20.To_Qgkn15Kxt1HLURmAdSAN7m<n9.Vector4, n9.Vector3> __p_RfHXehgFrDoMWlydb7V1EX;
            [n1.ElementAttribute(TracingId = 327739U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "ROJzOFNqtTZNxmUJMDbesM", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_ROJzOFNqtTZNxmUJMDbesM;
            [n1.ElementAttribute(TracingId = 327749U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Vp6QHZOnB1iNPWo0KSpTp7", Name = "CheckDefault", IsManaged = true, IsAutoGenerated = true)]
            public n37.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_Vp6QHZOnB1iNPWo0KSpTp7;
            [n1.ElementAttribute(TracingId = 327759U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "RLwFUBctlUfNMyg5HOJfGp", Name = "CheckDefault", IsManaged = true, IsAutoGenerated = true)]
            public n37.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_RLwFUBctlUfNMyg5HOJfGp;
            [n1.ElementAttribute(TracingId = 327772U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "IzVUGZ6jl0yNJPXWLq4TVV", Name = "CheckDefault", IsManaged = true, IsAutoGenerated = true)]
            public n37.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_IzVUGZ6jl0yNJPXWLq4TVV;
            [n1.ElementAttribute(TracingId = 327782U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "IYNmY5ueSNQORO3Fh45xnA", Name = "Normalize", IsManaged = true, IsAutoGenerated = true)]
            public n19.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n9.Vector3> __p_IYNmY5ueSNQORO3Fh45xnA;
            [n1.ElementAttribute(TracingId = 327714U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Gj9AqtaOGVINGeAWlUtz5g", Name = "__slot_Gj9AqtaOGVINGeAWlUtz5g")]
            public n8.GpuValue<n9.Vector3> __slot_Gj9AqtaOGVINGeAWlUtz5g;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM = default(n5.Spread<n8.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.IFunctionInvokeNode> __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd = default(n5.Spread<n8.IFunctionInvokeNode>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<string> __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n = default(n5.Spread<string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k = default(n5.Spread<n8.AbstractGpuValue>);
            public __IzARKtNK8rUPLFNP0SrnWh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __IzARKtNK8rUPLFNP0SrnWh(__IzARKtNK8rUPLFNP0SrnWh other): base(other)
            {
                this.__p_PDcuZcyIGz0QQ05JN8cf8k = other.__p_PDcuZcyIGz0QQ05JN8cf8k;
                this.__p_SwqmPUW3GVuOjI04SjGGIU = other.__p_SwqmPUW3GVuOjI04SjGGIU;
                this.__p_K8W6K38MRUzOqjT7QMfugE = other.__p_K8W6K38MRUzOqjT7QMfugE;
                this.__p_RfHXehgFrDoMWlydb7V1EX = other.__p_RfHXehgFrDoMWlydb7V1EX;
                this.__p_ROJzOFNqtTZNxmUJMDbesM = other.__p_ROJzOFNqtTZNxmUJMDbesM;
                this.__p_Vp6QHZOnB1iNPWo0KSpTp7 = other.__p_Vp6QHZOnB1iNPWo0KSpTp7;
                this.__p_RLwFUBctlUfNMyg5HOJfGp = other.__p_RLwFUBctlUfNMyg5HOJfGp;
                this.__p_IzVUGZ6jl0yNJPXWLq4TVV = other.__p_IzVUGZ6jl0yNJPXWLq4TVV;
                this.__p_IYNmY5ueSNQORO3Fh45xnA = other.__p_IYNmY5ueSNQORO3Fh45xnA;
                this.__slot_Gj9AqtaOGVINGeAWlUtz5g = other.__slot_Gj9AqtaOGVINGeAWlUtz5g;
                this.__pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM = other.__pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM;
                this.__pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd = other.__pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd;
                this.__pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n = other.__pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n;
                this.__pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k = other.__pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_PDcuZcyIGz0QQ05JN8cf8k", in __p_PDcuZcyIGz0QQ05JN8cf8k), n1.CompilationHelper.GetValueOrExisting(values, "__p_SwqmPUW3GVuOjI04SjGGIU", in __p_SwqmPUW3GVuOjI04SjGGIU), n1.CompilationHelper.GetValueOrExisting(values, "__p_K8W6K38MRUzOqjT7QMfugE", in __p_K8W6K38MRUzOqjT7QMfugE), n1.CompilationHelper.GetValueOrExisting(values, "__p_RfHXehgFrDoMWlydb7V1EX", in __p_RfHXehgFrDoMWlydb7V1EX), n1.CompilationHelper.GetValueOrExisting(values, "__p_ROJzOFNqtTZNxmUJMDbesM", in __p_ROJzOFNqtTZNxmUJMDbesM), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vp6QHZOnB1iNPWo0KSpTp7", in __p_Vp6QHZOnB1iNPWo0KSpTp7), n1.CompilationHelper.GetValueOrExisting(values, "__p_RLwFUBctlUfNMyg5HOJfGp", in __p_RLwFUBctlUfNMyg5HOJfGp), n1.CompilationHelper.GetValueOrExisting(values, "__p_IzVUGZ6jl0yNJPXWLq4TVV", in __p_IzVUGZ6jl0yNJPXWLq4TVV), n1.CompilationHelper.GetValueOrExisting(values, "__p_IYNmY5ueSNQORO3Fh45xnA", in __p_IYNmY5ueSNQORO3Fh45xnA), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Gj9AqtaOGVINGeAWlUtz5g", in __slot_Gj9AqtaOGVINGeAWlUtz5g), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM", in __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd", in __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n", in __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k", in __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k));
            }

            internal __IzARKtNK8rUPLFNP0SrnWh __WITH__(n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<n9.Vector3, n11.IEnumerable<n8.InputModifier>> __p_PDcuZcyIGz0QQ05JN8cf8k, n13.GPUIn_C<int> __p_SwqmPUW3GVuOjI04SjGGIU, n18.Position_PeLDdeSku4ANhU5oe5SfPy __p_K8W6K38MRUzOqjT7QMfugE, n20.To_Qgkn15Kxt1HLURmAdSAN7m<n9.Vector4, n9.Vector3> __p_RfHXehgFrDoMWlydb7V1EX, n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_ROJzOFNqtTZNxmUJMDbesM, n37.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_Vp6QHZOnB1iNPWo0KSpTp7, n37.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_RLwFUBctlUfNMyg5HOJfGp, n37.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_IzVUGZ6jl0yNJPXWLq4TVV, n19.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n9.Vector3> __p_IYNmY5ueSNQORO3Fh45xnA, n8.GpuValue<n9.Vector3> __slot_Gj9AqtaOGVINGeAWlUtz5g, n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM, n5.Spread<n8.IFunctionInvokeNode> __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd, n5.Spread<string> __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n, n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k)
            {
                __IzARKtNK8rUPLFNP0SrnWh that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_PDcuZcyIGz0QQ05JN8cf8k != this.__p_PDcuZcyIGz0QQ05JN8cf8k || __p_SwqmPUW3GVuOjI04SjGGIU != this.__p_SwqmPUW3GVuOjI04SjGGIU || __p_K8W6K38MRUzOqjT7QMfugE != this.__p_K8W6K38MRUzOqjT7QMfugE || __p_RfHXehgFrDoMWlydb7V1EX != this.__p_RfHXehgFrDoMWlydb7V1EX || __p_ROJzOFNqtTZNxmUJMDbesM != this.__p_ROJzOFNqtTZNxmUJMDbesM || __p_Vp6QHZOnB1iNPWo0KSpTp7 != this.__p_Vp6QHZOnB1iNPWo0KSpTp7 || __p_RLwFUBctlUfNMyg5HOJfGp != this.__p_RLwFUBctlUfNMyg5HOJfGp || __p_IzVUGZ6jl0yNJPXWLq4TVV != this.__p_IzVUGZ6jl0yNJPXWLq4TVV || __p_IYNmY5ueSNQORO3Fh45xnA != this.__p_IYNmY5ueSNQORO3Fh45xnA || __slot_Gj9AqtaOGVINGeAWlUtz5g != this.__slot_Gj9AqtaOGVINGeAWlUtz5g || __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM != this.__pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM || __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd != this.__pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd || __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n != this.__pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n || __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k != this.__pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k ? new __IzARKtNK8rUPLFNP0SrnWh(this)
                    {__p_PDcuZcyIGz0QQ05JN8cf8k = __p_PDcuZcyIGz0QQ05JN8cf8k, __p_SwqmPUW3GVuOjI04SjGGIU = __p_SwqmPUW3GVuOjI04SjGGIU, __p_K8W6K38MRUzOqjT7QMfugE = __p_K8W6K38MRUzOqjT7QMfugE, __p_RfHXehgFrDoMWlydb7V1EX = __p_RfHXehgFrDoMWlydb7V1EX, __p_ROJzOFNqtTZNxmUJMDbesM = __p_ROJzOFNqtTZNxmUJMDbesM, __p_Vp6QHZOnB1iNPWo0KSpTp7 = __p_Vp6QHZOnB1iNPWo0KSpTp7, __p_RLwFUBctlUfNMyg5HOJfGp = __p_RLwFUBctlUfNMyg5HOJfGp, __p_IzVUGZ6jl0yNJPXWLq4TVV = __p_IzVUGZ6jl0yNJPXWLq4TVV, __p_IYNmY5ueSNQORO3Fh45xnA = __p_IYNmY5ueSNQORO3Fh45xnA, __slot_Gj9AqtaOGVINGeAWlUtz5g = __slot_Gj9AqtaOGVINGeAWlUtz5g, __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM = __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM, __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd = __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd, __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n = __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n, __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k = __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k} : that_0;
                else
                {
                    this.__p_PDcuZcyIGz0QQ05JN8cf8k = __p_PDcuZcyIGz0QQ05JN8cf8k;
                    this.__p_SwqmPUW3GVuOjI04SjGGIU = __p_SwqmPUW3GVuOjI04SjGGIU;
                    this.__p_K8W6K38MRUzOqjT7QMfugE = __p_K8W6K38MRUzOqjT7QMfugE;
                    this.__p_RfHXehgFrDoMWlydb7V1EX = __p_RfHXehgFrDoMWlydb7V1EX;
                    this.__p_ROJzOFNqtTZNxmUJMDbesM = __p_ROJzOFNqtTZNxmUJMDbesM;
                    this.__p_Vp6QHZOnB1iNPWo0KSpTp7 = __p_Vp6QHZOnB1iNPWo0KSpTp7;
                    this.__p_RLwFUBctlUfNMyg5HOJfGp = __p_RLwFUBctlUfNMyg5HOJfGp;
                    this.__p_IzVUGZ6jl0yNJPXWLq4TVV = __p_IzVUGZ6jl0yNJPXWLq4TVV;
                    this.__p_IYNmY5ueSNQORO3Fh45xnA = __p_IYNmY5ueSNQORO3Fh45xnA;
                    this.__slot_Gj9AqtaOGVINGeAWlUtz5g = __slot_Gj9AqtaOGVINGeAWlUtz5g;
                    this.__pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM = __pin_group_Parameters_In_ROJzOFNqtTZNxmUJMDbesM;
                    this.__pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd = __pin_group_Input_In_OLya0ZqCIXeO7d4Rapv5hd;
                    this.__pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n = __pin_group_Input_In_A6WFA9p0M2yMDRE4Vqfh7n;
                    this.__pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k = __pin_group_Arguments_In_PDcuZcyIGz0QQ05JN8cf8k;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 328847U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Irt0YFriJdfL2EJnYYiPxv", Name = "Fuse_RaymarchingApplication_Irt0YFriJdfL2EJnYYiPxv")]
    [n2.SerializableAttribute]
    public class Fuse_RaymarchingApplication_Irt0YFriJdfL2EJnYYiPxv : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Fuse_RaymarchingApplication_Irt0YFriJdfL2EJnYYiPxv Create(n1.NodeContext Node_Context)
        {
            var instance = new Fuse_RaymarchingApplication_Irt0YFriJdfL2EJnYYiPxv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Fuse_RaymarchingApplication_Irt0YFriJdfL2EJnYYiPxv CreateDefault()
        {
            var instance = new Fuse_RaymarchingApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Fuse_RaymarchingApplication_Irt0YFriJdfL2EJnYYiPxv Update()
        {
            return this;
        }

        public n3.Fuse_RaymarchingApplication_Irt0YFriJdfL2EJnYYiPxv __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.Fuse_RaymarchingApplication_Irt0YFriJdfL2EJnYYiPxv __CreateDefault__()
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

        public Fuse_RaymarchingApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Fuse_RaymarchingApplication_Irt0YFriJdfL2EJnYYiPxv(Fuse_RaymarchingApplication_Irt0YFriJdfL2EJnYYiPxv other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal Fuse_RaymarchingApplication_Irt0YFriJdfL2EJnYYiPxv __WITH__()
        {
            return this;
        }
    }
}

namespace _Fuse_Raymarching_.Fuse.Raymarching.Internal
{
    [n1.ElementAttribute(TracingId = 327921U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "HqylyjSwFgyNhK9CERO68b", Name = "CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b")]
    [n2.SerializableAttribute]
    public class CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n15.CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b Create(n1.NodeContext Node_Context)
        {
            var instance = new CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n15.CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b CreateDefault()
        {
            var instance = new CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n15.CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b Update(n8.GpuValue<n16.Ray> Ray_In, n9.Vector3 Position_In, [n4.SerializedDefaultValueAttribute("4, 4, 4", false)] n9.Vector3 Size_In, out n8.GpuValue<n9.Vector2> Cull_Ray_Out)
        {
            string __pad_KexJqGViyMdNQxnBWOrrHK_0 = __slot_KexJqGViyMdNQxnBWOrrHK;
            string __pad_TvCsUghI3bPNNe997CZyto_1 = __slot_TvCsUghI3bPNNe997CZyto;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_ViGL8DFsyafOpewEUPEyYn;
            if (manager_4 is null)
            {
                manager_4 = new n10.Manager<n2.ValueTuple<n8.GpuValue<n16.Ray>, n9.Vector3, n9.Vector3, string, string>, n2.ValueTuple<n8.GpuValue<n9.Vector2>>>(n2.ValueTuple.Create(default(n8.GpuValue<n9.Vector2>)));
            }

            var inputs_5 = (Ray_In, Position_In, Size_In, __pad_KexJqGViyMdNQxnBWOrrHK_0, __pad_TvCsUghI3bPNNe997CZyto_1);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__F57417hdA2uOWskrLqy1ME>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __F57417hdA2uOWskrLqy1ME(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs = n21._Operations_.CreateDefault<n8.AbstractGpuValue>(), __slot_GqBtfBPgQ1eM0JlQSF3cEa = n40._Operations_.CreateDefault(), __slot_Dmb31neK5QbMkBa9EvQWdN = n40._Operations_.CreateDefault()};
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "EPW4fW2R9ziOQy0BKxtdqs", 327948U);
                    var Output_10 = n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n9.Vector2>.Create(Node_Context: Node_Context_9);
                    state_8.__p_EPW4fW2R9ziOQy0BKxtdqs = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "UimHSO05WqJL5FHOvxj2FG", 327964U);
                    var Output_12 = n14.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n16.Ray>.Create(Node_Context: Node_Context_11);
                    state_8.__p_UimHSO05WqJL5FHOvxj2FG = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "JOPYeqo20OLLPGTjSdQvIq", 327969U);
                    var Output_14 = n13.GPUIn_C<n9.Vector3>.Create(Node_Context: Node_Context_13);
                    state_8.__p_JOPYeqo20OLLPGTjSdQvIq = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "IMtPaBINcszQOy00htCrlS", 327976U);
                    var Output_16 = n13.GPUIn_C<n9.Vector3>.Create(Node_Context: Node_Context_15);
                    state_8.__p_IMtPaBINcszQOy00htCrlS = Output_16;
                }

                int Id_17 = 0;
                var State_Output_19 = state_8.__p_UimHSO05WqJL5FHOvxj2FG.Update(The_Override_In: Ray_In, Id_In: Id_17, Output_Out: out n8.GpuValue<n16.Ray> Output_18);
                var State_Output_21 = state_8.__p_JOPYeqo20OLLPGTjSdQvIq.Update(Output_Out: out n8.GpuValue<n9.Vector3> Output_20);
                var State_Output_23 = state_8.__p_IMtPaBINcszQOy00htCrlS.Update(Output_Out: out n8.GpuValue<n9.Vector3> Output_22);
                n8.GpuValue<n9.Vector2> Default_24 = default(n8.GpuValue<n9.Vector2>);
                bool Is_Groupable_25 = false;
                n11.IEnumerable<n8.InputModifier> The_Modifiers_26 = n24._Operations_.CreateDefault<n8.InputModifier>();
                var builder_27 = n4.CollectionBuilders.GetBuilder(state_8.__pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs, 3);
                builder_27.Add(Output_18);
                builder_27.Add(Output_20);
                builder_27.Add(Output_22);
                var __pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs_28 = builder_27.Commit();
                var State_Output_31 = state_8.__p_EPW4fW2R9ziOQy0BKxtdqs.Update(Arguments_In: __pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs_28, Function_Name_In: __pad_KexJqGViyMdNQxnBWOrrHK_0, Default_In: Default_24, Mixins_In: __pad_TvCsUghI3bPNNe997CZyto_1, Is_Groupable_In: Is_Groupable_25, The_Modifiers_In: The_Modifiers_26, Output_Out: out n8.GpuValue<n9.Vector2> Output_29, Additional_Outputs_Out: out n5.Spread<n8.AbstractGpuValue> Additional_Outputs_30);
                n9.Vector3 __pad_GqBtfBPgQ1eM0JlQSF3cEa_32 = Position_In;
                bool SetValue_33 = true;
                var Output_34 = State_Output_21;
                if (SetValue_33)
                {
                    Output_34 = State_Output_21.SetValue(Input_In: __pad_GqBtfBPgQ1eM0JlQSF3cEa_32);
                }

                n9.Vector3 __pad_Dmb31neK5QbMkBa9EvQWdN_35 = Size_In;
                bool SetValue_36 = true;
                var Output_37 = State_Output_23;
                if (SetValue_36)
                {
                    Output_37 = State_Output_23.SetValue(Input_In: __pad_Dmb31neK5QbMkBa9EvQWdN_35);
                }

                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_19 != state_8.__p_UimHSO05WqJL5FHOvxj2FG || Output_34 != state_8.__p_JOPYeqo20OLLPGTjSdQvIq || Output_37 != state_8.__p_IMtPaBINcszQOy00htCrlS || __pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs_28 != state_8.__pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs || State_Output_31 != state_8.__p_EPW4fW2R9ziOQy0BKxtdqs || Position_In != state_8.__slot_GqBtfBPgQ1eM0JlQSF3cEa || Size_In != state_8.__slot_Dmb31neK5QbMkBa9EvQWdN ? new __F57417hdA2uOWskrLqy1ME(state_8)
                    {__p_UimHSO05WqJL5FHOvxj2FG = State_Output_19, __p_JOPYeqo20OLLPGTjSdQvIq = Output_34, __p_IMtPaBINcszQOy00htCrlS = Output_37, __pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs = __pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs_28, __p_EPW4fW2R9ziOQy0BKxtdqs = State_Output_31, __slot_GqBtfBPgQ1eM0JlQSF3cEa = Position_In, __slot_Dmb31neK5QbMkBa9EvQWdN = Size_In} : state_8;
                else
                {
                    state_8.__p_UimHSO05WqJL5FHOvxj2FG = State_Output_19;
                    state_8.__p_JOPYeqo20OLLPGTjSdQvIq = Output_34;
                    state_8.__p_IMtPaBINcszQOy00htCrlS = Output_37;
                    state_8.__pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs = __pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs_28;
                    state_8.__p_EPW4fW2R9ziOQy0BKxtdqs = State_Output_31;
                    state_8.__slot_GqBtfBPgQ1eM0JlQSF3cEa = Position_In;
                    state_8.__slot_Dmb31neK5QbMkBa9EvQWdN = Size_In;
                }

                outputs_6 = n2.ValueTuple.Create(Output_29);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_38 = outputs_6.Item1;
            Cull_Ray_Out = __auto_38;
            n15.CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b that_39 = this;
            if (this.__GetContext__().IsImmutable)
                that_39 = manager_4 != this.__cache_ViGL8DFsyafOpewEUPEyYn ? new CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b(this)
                {__cache_ViGL8DFsyafOpewEUPEyYn = manager_4} : that_39;
            else
            {
                this.__cache_ViGL8DFsyafOpewEUPEyYn = manager_4;
            }

            return that_39;
        }

        public n15.CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n15.CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b that_0 = this;
            this.__cache_ViGL8DFsyafOpewEUPEyYn = null;
            return that_0;
        }

        public n15.CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b __CreateDefault__()
        {
            n15.CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b that_0 = this;
            this.__cache_ViGL8DFsyafOpewEUPEyYn = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_ViGL8DFsyafOpewEUPEyYn);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 327993U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "KexJqGViyMdNQxnBWOrrHK", Name = "__slot_KexJqGViyMdNQxnBWOrrHK")]
        public static string __slot_KexJqGViyMdNQxnBWOrrHK = "cullRayByBox";
        [n1.ElementAttribute(TracingId = 327994U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "TvCsUghI3bPNNe997CZyto", Name = "__slot_TvCsUghI3bPNNe997CZyto")]
        public static string __slot_TvCsUghI3bPNNe997CZyto = "FuseRayMarch";
        [n1.ElementAttribute(TracingId = 327926U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "ViGL8DFsyafOpewEUPEyYn", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n10.Manager<n2.ValueTuple<n8.GpuValue<n16.Ray>, n9.Vector3, n9.Vector3, string, string>, n2.ValueTuple<n8.GpuValue<n9.Vector2>>> __cache_ViGL8DFsyafOpewEUPEyYn = null;
        static CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b()
        {
        }

        public CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b(CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b other): base(other)
        {
            this.__cache_ViGL8DFsyafOpewEUPEyYn = other.__cache_ViGL8DFsyafOpewEUPEyYn;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_ViGL8DFsyafOpewEUPEyYn", in __cache_ViGL8DFsyafOpewEUPEyYn));
        }

        internal CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b __WITH__(n10.Manager<n2.ValueTuple<n8.GpuValue<n16.Ray>, n9.Vector3, n9.Vector3, string, string>, n2.ValueTuple<n8.GpuValue<n9.Vector2>>> __cache_ViGL8DFsyafOpewEUPEyYn)
        {
            n15.CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_ViGL8DFsyafOpewEUPEyYn != this.__cache_ViGL8DFsyafOpewEUPEyYn ? new CullRayByBoundingBox_HqylyjSwFgyNhK9CERO68b(this)
                {__cache_ViGL8DFsyafOpewEUPEyYn = __cache_ViGL8DFsyafOpewEUPEyYn} : that_0;
            else
            {
                this.__cache_ViGL8DFsyafOpewEUPEyYn = __cache_ViGL8DFsyafOpewEUPEyYn;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "F57417hdA2uOWskrLqy1ME", Name = "__F57417hdA2uOWskrLqy1ME")]
        [n2.SerializableAttribute]
        public class __F57417hdA2uOWskrLqy1ME : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_EPW4fW2R9ziOQy0BKxtdqs);
                n1.CompilationHelper.SafeDispose(this.__p_UimHSO05WqJL5FHOvxj2FG);
                n1.CompilationHelper.SafeDispose(this.__p_JOPYeqo20OLLPGTjSdQvIq);
                n1.CompilationHelper.SafeDispose(this.__p_IMtPaBINcszQOy00htCrlS);
                return;
            }

            [n1.ElementAttribute(TracingId = 327948U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "EPW4fW2R9ziOQy0BKxtdqs", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n9.Vector2> __p_EPW4fW2R9ziOQy0BKxtdqs;
            [n1.ElementAttribute(TracingId = 327964U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "UimHSO05WqJL5FHOvxj2FG", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n14.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n16.Ray> __p_UimHSO05WqJL5FHOvxj2FG;
            [n1.ElementAttribute(TracingId = 327969U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "JOPYeqo20OLLPGTjSdQvIq", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
            public n13.GPUIn_C<n9.Vector3> __p_JOPYeqo20OLLPGTjSdQvIq;
            [n1.ElementAttribute(TracingId = 327976U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "IMtPaBINcszQOy00htCrlS", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
            public n13.GPUIn_C<n9.Vector3> __p_IMtPaBINcszQOy00htCrlS;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs = default(n5.Spread<n8.AbstractGpuValue>);
            [n1.ElementAttribute(TracingId = 327982U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "GqBtfBPgQ1eM0JlQSF3cEa", Name = "__slot_GqBtfBPgQ1eM0JlQSF3cEa")]
            public n9.Vector3 __slot_GqBtfBPgQ1eM0JlQSF3cEa;
            [n1.ElementAttribute(TracingId = 327985U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Dmb31neK5QbMkBa9EvQWdN", Name = "__slot_Dmb31neK5QbMkBa9EvQWdN")]
            public n9.Vector3 __slot_Dmb31neK5QbMkBa9EvQWdN;
            public __F57417hdA2uOWskrLqy1ME(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __F57417hdA2uOWskrLqy1ME(__F57417hdA2uOWskrLqy1ME other): base(other)
            {
                this.__p_EPW4fW2R9ziOQy0BKxtdqs = other.__p_EPW4fW2R9ziOQy0BKxtdqs;
                this.__p_UimHSO05WqJL5FHOvxj2FG = other.__p_UimHSO05WqJL5FHOvxj2FG;
                this.__p_JOPYeqo20OLLPGTjSdQvIq = other.__p_JOPYeqo20OLLPGTjSdQvIq;
                this.__p_IMtPaBINcszQOy00htCrlS = other.__p_IMtPaBINcszQOy00htCrlS;
                this.__pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs = other.__pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs;
                this.__slot_GqBtfBPgQ1eM0JlQSF3cEa = other.__slot_GqBtfBPgQ1eM0JlQSF3cEa;
                this.__slot_Dmb31neK5QbMkBa9EvQWdN = other.__slot_Dmb31neK5QbMkBa9EvQWdN;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_EPW4fW2R9ziOQy0BKxtdqs", in __p_EPW4fW2R9ziOQy0BKxtdqs), n1.CompilationHelper.GetValueOrExisting(values, "__p_UimHSO05WqJL5FHOvxj2FG", in __p_UimHSO05WqJL5FHOvxj2FG), n1.CompilationHelper.GetValueOrExisting(values, "__p_JOPYeqo20OLLPGTjSdQvIq", in __p_JOPYeqo20OLLPGTjSdQvIq), n1.CompilationHelper.GetValueOrExisting(values, "__p_IMtPaBINcszQOy00htCrlS", in __p_IMtPaBINcszQOy00htCrlS), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs", in __pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs), n1.CompilationHelper.GetValueOrExisting(values, "__slot_GqBtfBPgQ1eM0JlQSF3cEa", in __slot_GqBtfBPgQ1eM0JlQSF3cEa), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Dmb31neK5QbMkBa9EvQWdN", in __slot_Dmb31neK5QbMkBa9EvQWdN));
            }

            internal __F57417hdA2uOWskrLqy1ME __WITH__(n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n9.Vector2> __p_EPW4fW2R9ziOQy0BKxtdqs, n14.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n16.Ray> __p_UimHSO05WqJL5FHOvxj2FG, n13.GPUIn_C<n9.Vector3> __p_JOPYeqo20OLLPGTjSdQvIq, n13.GPUIn_C<n9.Vector3> __p_IMtPaBINcszQOy00htCrlS, n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs, n9.Vector3 __slot_GqBtfBPgQ1eM0JlQSF3cEa, n9.Vector3 __slot_Dmb31neK5QbMkBa9EvQWdN)
            {
                __F57417hdA2uOWskrLqy1ME that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_EPW4fW2R9ziOQy0BKxtdqs != this.__p_EPW4fW2R9ziOQy0BKxtdqs || __p_UimHSO05WqJL5FHOvxj2FG != this.__p_UimHSO05WqJL5FHOvxj2FG || __p_JOPYeqo20OLLPGTjSdQvIq != this.__p_JOPYeqo20OLLPGTjSdQvIq || __p_IMtPaBINcszQOy00htCrlS != this.__p_IMtPaBINcszQOy00htCrlS || __pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs != this.__pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs || __slot_GqBtfBPgQ1eM0JlQSF3cEa != this.__slot_GqBtfBPgQ1eM0JlQSF3cEa || __slot_Dmb31neK5QbMkBa9EvQWdN != this.__slot_Dmb31neK5QbMkBa9EvQWdN ? new __F57417hdA2uOWskrLqy1ME(this)
                    {__p_EPW4fW2R9ziOQy0BKxtdqs = __p_EPW4fW2R9ziOQy0BKxtdqs, __p_UimHSO05WqJL5FHOvxj2FG = __p_UimHSO05WqJL5FHOvxj2FG, __p_JOPYeqo20OLLPGTjSdQvIq = __p_JOPYeqo20OLLPGTjSdQvIq, __p_IMtPaBINcszQOy00htCrlS = __p_IMtPaBINcszQOy00htCrlS, __pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs = __pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs, __slot_GqBtfBPgQ1eM0JlQSF3cEa = __slot_GqBtfBPgQ1eM0JlQSF3cEa, __slot_Dmb31neK5QbMkBa9EvQWdN = __slot_Dmb31neK5QbMkBa9EvQWdN} : that_0;
                else
                {
                    this.__p_EPW4fW2R9ziOQy0BKxtdqs = __p_EPW4fW2R9ziOQy0BKxtdqs;
                    this.__p_UimHSO05WqJL5FHOvxj2FG = __p_UimHSO05WqJL5FHOvxj2FG;
                    this.__p_JOPYeqo20OLLPGTjSdQvIq = __p_JOPYeqo20OLLPGTjSdQvIq;
                    this.__p_IMtPaBINcszQOy00htCrlS = __p_IMtPaBINcszQOy00htCrlS;
                    this.__pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs = __pin_group_Arguments_In_EPW4fW2R9ziOQy0BKxtdqs;
                    this.__slot_GqBtfBPgQ1eM0JlQSF3cEa = __slot_GqBtfBPgQ1eM0JlQSF3cEa;
                    this.__slot_Dmb31neK5QbMkBa9EvQWdN = __slot_Dmb31neK5QbMkBa9EvQWdN;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 328052U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "RiQdApsbM5FLrA6NHCrBHt", Name = "SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt")]
    [n2.SerializableAttribute]
    public class SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt Create(n1.NodeContext Node_Context)
        {
            var instance = new SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt CreateDefault()
        {
            var instance = new SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt Update(out n8.GpuValue<n16.Ray> Ray_Out)
        {
            string __pad_RqWz0KvgHhFPvHHGmaW3DM_0 = __slot_RqWz0KvgHhFPvHHGmaW3DM;
            string __pad_OGKAlfJg9FnPSi0ULWHoDH_1 = __slot_OGKAlfJg9FnPSi0ULWHoDH;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_Cfb9flW5CpVOXn9BILCHQP;
            if (manager_4 is null)
            {
                manager_4 = new n10.Manager<n2.ValueTuple<string, string>, n2.ValueTuple<n8.GpuValue<n16.Ray>>>(n2.ValueTuple.Create(default(n8.GpuValue<n16.Ray>)));
            }

            var inputs_5 = (__pad_RqWz0KvgHhFPvHHGmaW3DM_0, __pad_OGKAlfJg9FnPSi0ULWHoDH_1);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__Hdr80jz4bgFO347clgCE11>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __Hdr80jz4bgFO347clgCE11(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F = n21._Operations_.CreateDefault<n8.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "PxZH6ZiOtY5PkXjIB2u64F", 328072U);
                    var Output_10 = n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n16.Ray>.Create(Node_Context: Node_Context_9);
                    state_8.__p_PxZH6ZiOtY5PkXjIB2u64F = Output_10;
                }

                n8.GpuValue<n16.Ray> Default_11 = default(n8.GpuValue<n16.Ray>);
                bool Is_Groupable_12 = false;
                n11.IEnumerable<n8.InputModifier> The_Modifiers_13 = n24._Operations_.CreateDefault<n8.InputModifier>();
                var builder_14 = n4.CollectionBuilders.GetBuilder(state_8.__pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F, 0);
                var __pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F_15 = builder_14.Commit();
                var State_Output_18 = state_8.__p_PxZH6ZiOtY5PkXjIB2u64F.Update(Arguments_In: __pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F_15, Function_Name_In: __pad_RqWz0KvgHhFPvHHGmaW3DM_0, Default_In: Default_11, Mixins_In: __pad_OGKAlfJg9FnPSi0ULWHoDH_1, Is_Groupable_In: Is_Groupable_12, The_Modifiers_In: The_Modifiers_13, Output_Out: out n8.GpuValue<n16.Ray> Output_16, Additional_Outputs_Out: out n5.Spread<n8.AbstractGpuValue> Additional_Outputs_17);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = __pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F_15 != state_8.__pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F || State_Output_18 != state_8.__p_PxZH6ZiOtY5PkXjIB2u64F ? new __Hdr80jz4bgFO347clgCE11(state_8)
                    {__pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F = __pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F_15, __p_PxZH6ZiOtY5PkXjIB2u64F = State_Output_18} : state_8;
                else
                {
                    state_8.__pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F = __pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F_15;
                    state_8.__p_PxZH6ZiOtY5PkXjIB2u64F = State_Output_18;
                }

                outputs_6 = n2.ValueTuple.Create(Output_16);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_19 = outputs_6.Item1;
            Ray_Out = __auto_19;
            n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt that_20 = this;
            if (this.__GetContext__().IsImmutable)
                that_20 = manager_4 != this.__cache_Cfb9flW5CpVOXn9BILCHQP ? new SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt(this)
                {__cache_Cfb9flW5CpVOXn9BILCHQP = manager_4} : that_20;
            else
            {
                this.__cache_Cfb9flW5CpVOXn9BILCHQP = manager_4;
            }

            return that_20;
        }

        public n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt that_0 = this;
            this.__cache_Cfb9flW5CpVOXn9BILCHQP = null;
            return that_0;
        }

        public n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt __CreateDefault__()
        {
            n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt that_0 = this;
            this.__cache_Cfb9flW5CpVOXn9BILCHQP = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_Cfb9flW5CpVOXn9BILCHQP);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 328086U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "RqWz0KvgHhFPvHHGmaW3DM", Name = "__slot_RqWz0KvgHhFPvHHGmaW3DM")]
        public static string __slot_RqWz0KvgHhFPvHHGmaW3DM = "setupRaybyCamera";
        [n1.ElementAttribute(TracingId = 328090U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "OGKAlfJg9FnPSi0ULWHoDH", Name = "__slot_OGKAlfJg9FnPSi0ULWHoDH")]
        public static string __slot_OGKAlfJg9FnPSi0ULWHoDH = "FuseRayMarch";
        [n1.ElementAttribute(TracingId = 328056U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Cfb9flW5CpVOXn9BILCHQP", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n10.Manager<n2.ValueTuple<string, string>, n2.ValueTuple<n8.GpuValue<n16.Ray>>> __cache_Cfb9flW5CpVOXn9BILCHQP = null;
        static SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt()
        {
        }

        public SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt(SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt other): base(other)
        {
            this.__cache_Cfb9flW5CpVOXn9BILCHQP = other.__cache_Cfb9flW5CpVOXn9BILCHQP;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Cfb9flW5CpVOXn9BILCHQP", in __cache_Cfb9flW5CpVOXn9BILCHQP));
        }

        internal SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt __WITH__(n10.Manager<n2.ValueTuple<string, string>, n2.ValueTuple<n8.GpuValue<n16.Ray>>> __cache_Cfb9flW5CpVOXn9BILCHQP)
        {
            n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Cfb9flW5CpVOXn9BILCHQP != this.__cache_Cfb9flW5CpVOXn9BILCHQP ? new SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt(this)
                {__cache_Cfb9flW5CpVOXn9BILCHQP = __cache_Cfb9flW5CpVOXn9BILCHQP} : that_0;
            else
            {
                this.__cache_Cfb9flW5CpVOXn9BILCHQP = __cache_Cfb9flW5CpVOXn9BILCHQP;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Hdr80jz4bgFO347clgCE11", Name = "__Hdr80jz4bgFO347clgCE11")]
        [n2.SerializableAttribute]
        public class __Hdr80jz4bgFO347clgCE11 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_PxZH6ZiOtY5PkXjIB2u64F);
                return;
            }

            [n1.ElementAttribute(TracingId = 328072U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "PxZH6ZiOtY5PkXjIB2u64F", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n16.Ray> __p_PxZH6ZiOtY5PkXjIB2u64F;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F = default(n5.Spread<n8.AbstractGpuValue>);
            public __Hdr80jz4bgFO347clgCE11(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Hdr80jz4bgFO347clgCE11(__Hdr80jz4bgFO347clgCE11 other): base(other)
            {
                this.__p_PxZH6ZiOtY5PkXjIB2u64F = other.__p_PxZH6ZiOtY5PkXjIB2u64F;
                this.__pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F = other.__pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_PxZH6ZiOtY5PkXjIB2u64F", in __p_PxZH6ZiOtY5PkXjIB2u64F), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F", in __pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F));
            }

            internal __Hdr80jz4bgFO347clgCE11 __WITH__(n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n16.Ray> __p_PxZH6ZiOtY5PkXjIB2u64F, n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F)
            {
                __Hdr80jz4bgFO347clgCE11 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_PxZH6ZiOtY5PkXjIB2u64F != this.__p_PxZH6ZiOtY5PkXjIB2u64F || __pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F != this.__pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F ? new __Hdr80jz4bgFO347clgCE11(this)
                    {__p_PxZH6ZiOtY5PkXjIB2u64F = __p_PxZH6ZiOtY5PkXjIB2u64F, __pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F = __pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F} : that_0;
                else
                {
                    this.__p_PxZH6ZiOtY5PkXjIB2u64F = __p_PxZH6ZiOtY5PkXjIB2u64F;
                    this.__pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F = __pin_group_Arguments_In_PxZH6ZiOtY5PkXjIB2u64F;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 328115U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "N3svfid7Nt6OfgkZE6IjlB", Name = "CullRayDefault_N3svfid7Nt6OfgkZE6IjlB")]
    [n2.SerializableAttribute]
    public class CullRayDefault_N3svfid7Nt6OfgkZE6IjlB : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n15.CullRayDefault_N3svfid7Nt6OfgkZE6IjlB Create(n1.NodeContext Node_Context)
        {
            var instance = new CullRayDefault_N3svfid7Nt6OfgkZE6IjlB(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n15.CullRayDefault_N3svfid7Nt6OfgkZE6IjlB CreateDefault()
        {
            var instance = new CullRayDefault_N3svfid7Nt6OfgkZE6IjlB(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n15.CullRayDefault_N3svfid7Nt6OfgkZE6IjlB Update(n8.GpuValue<n16.Ray> Ray_In, [n4.SerializedDefaultValueAttribute("0.01", false)] float Min_Distance_In, [n4.SerializedDefaultValueAttribute("200", false)] float Max_Distance_In, out n8.GpuValue<n9.Vector2> Cull_Ray_Out)
        {
            string __pad_KuVdcPPEyU3M2Vfh7pXm2h_0 = __slot_KuVdcPPEyU3M2Vfh7pXm2h;
            string __pad_FxFIcx0PzYEMOP2pZVoluF_1 = __slot_FxFIcx0PzYEMOP2pZVoluF;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_VXCejg8xLhmN91XamefUSg;
            if (manager_4 is null)
            {
                manager_4 = new n10.Manager<n2.ValueTuple<n8.GpuValue<n16.Ray>, float, float, string, string>, n2.ValueTuple<n8.GpuValue<n9.Vector2>>>(n2.ValueTuple.Create(default(n8.GpuValue<n9.Vector2>)));
            }

            var inputs_5 = (Ray_In, Min_Distance_In, Max_Distance_In, __pad_KuVdcPPEyU3M2Vfh7pXm2h_0, __pad_FxFIcx0PzYEMOP2pZVoluF_1);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__Ov3Zmq2UbifNCwa9qfAJSx>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __Ov3Zmq2UbifNCwa9qfAJSx(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq = n21._Operations_.CreateDefault<n8.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "GgdOhSg6zyoNgGGcJwd2rq", 328140U);
                    var Output_10 = n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n9.Vector2>.Create(Node_Context: Node_Context_9);
                    state_8.__p_GgdOhSg6zyoNgGGcJwd2rq = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "HVG5WG7l9GSLlY9kPfDKDP", 328154U);
                    var Output_12 = n14.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n16.Ray>.Create(Node_Context: Node_Context_11);
                    state_8.__p_HVG5WG7l9GSLlY9kPfDKDP = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "ME7z6kbGII7NgjAUKkXaTG", 328159U);
                    var Output_14 = n13.GPUIn_C<n9.Vector2>.Create(Node_Context: Node_Context_13);
                    state_8.__p_ME7z6kbGII7NgjAUKkXaTG = Output_14;
                }

                int Id_15 = 0;
                var State_Output_17 = state_8.__p_HVG5WG7l9GSLlY9kPfDKDP.Update(The_Override_In: Ray_In, Id_In: Id_15, Output_Out: out n8.GpuValue<n16.Ray> Output_16);
                var State_Output_19 = state_8.__p_ME7z6kbGII7NgjAUKkXaTG.Update(Output_Out: out n8.GpuValue<n9.Vector2> Output_18);
                n8.GpuValue<n9.Vector2> Default_20 = default(n8.GpuValue<n9.Vector2>);
                bool Is_Groupable_21 = false;
                n11.IEnumerable<n8.InputModifier> The_Modifiers_22 = n24._Operations_.CreateDefault<n8.InputModifier>();
                var builder_23 = n4.CollectionBuilders.GetBuilder(state_8.__pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq, 2);
                builder_23.Add(Output_16);
                builder_23.Add(Output_18);
                var __pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq_24 = builder_23.Commit();
                var State_Output_27 = state_8.__p_GgdOhSg6zyoNgGGcJwd2rq.Update(Arguments_In: __pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq_24, Function_Name_In: __pad_KuVdcPPEyU3M2Vfh7pXm2h_0, Default_In: Default_20, Mixins_In: __pad_FxFIcx0PzYEMOP2pZVoluF_1, Is_Groupable_In: Is_Groupable_21, The_Modifiers_In: The_Modifiers_22, Output_Out: out n8.GpuValue<n9.Vector2> Output_25, Additional_Outputs_Out: out n5.Spread<n8.AbstractGpuValue> Additional_Outputs_26);
                var Output_28 = new n9.Vector2(x: Min_Distance_In, y: Max_Distance_In);
                bool SetValue_29 = true;
                var Output_30 = State_Output_19;
                if (SetValue_29)
                {
                    Output_30 = State_Output_19.SetValue(Input_In: Output_28);
                }

                if (state_8.__GetContext__().IsImmutable)
                    state_8 = State_Output_17 != state_8.__p_HVG5WG7l9GSLlY9kPfDKDP || Output_30 != state_8.__p_ME7z6kbGII7NgjAUKkXaTG || __pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq_24 != state_8.__pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq || State_Output_27 != state_8.__p_GgdOhSg6zyoNgGGcJwd2rq ? new __Ov3Zmq2UbifNCwa9qfAJSx(state_8)
                    {__p_HVG5WG7l9GSLlY9kPfDKDP = State_Output_17, __p_ME7z6kbGII7NgjAUKkXaTG = Output_30, __pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq = __pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq_24, __p_GgdOhSg6zyoNgGGcJwd2rq = State_Output_27} : state_8;
                else
                {
                    state_8.__p_HVG5WG7l9GSLlY9kPfDKDP = State_Output_17;
                    state_8.__p_ME7z6kbGII7NgjAUKkXaTG = Output_30;
                    state_8.__pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq = __pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq_24;
                    state_8.__p_GgdOhSg6zyoNgGGcJwd2rq = State_Output_27;
                }

                outputs_6 = n2.ValueTuple.Create(Output_25);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_31 = outputs_6.Item1;
            Cull_Ray_Out = __auto_31;
            n15.CullRayDefault_N3svfid7Nt6OfgkZE6IjlB that_32 = this;
            if (this.__GetContext__().IsImmutable)
                that_32 = manager_4 != this.__cache_VXCejg8xLhmN91XamefUSg ? new CullRayDefault_N3svfid7Nt6OfgkZE6IjlB(this)
                {__cache_VXCejg8xLhmN91XamefUSg = manager_4} : that_32;
            else
            {
                this.__cache_VXCejg8xLhmN91XamefUSg = manager_4;
            }

            return that_32;
        }

        public n15.CullRayDefault_N3svfid7Nt6OfgkZE6IjlB __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n15.CullRayDefault_N3svfid7Nt6OfgkZE6IjlB that_0 = this;
            this.__cache_VXCejg8xLhmN91XamefUSg = null;
            return that_0;
        }

        public n15.CullRayDefault_N3svfid7Nt6OfgkZE6IjlB __CreateDefault__()
        {
            n15.CullRayDefault_N3svfid7Nt6OfgkZE6IjlB that_0 = this;
            this.__cache_VXCejg8xLhmN91XamefUSg = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_VXCejg8xLhmN91XamefUSg);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 328179U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "KuVdcPPEyU3M2Vfh7pXm2h", Name = "__slot_KuVdcPPEyU3M2Vfh7pXm2h")]
        public static string __slot_KuVdcPPEyU3M2Vfh7pXm2h = "cullRayDefualt";
        [n1.ElementAttribute(TracingId = 328181U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "FxFIcx0PzYEMOP2pZVoluF", Name = "__slot_FxFIcx0PzYEMOP2pZVoluF")]
        public static string __slot_FxFIcx0PzYEMOP2pZVoluF = "FuseRayMarch";
        [n1.ElementAttribute(TracingId = 328118U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "VXCejg8xLhmN91XamefUSg", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n10.Manager<n2.ValueTuple<n8.GpuValue<n16.Ray>, float, float, string, string>, n2.ValueTuple<n8.GpuValue<n9.Vector2>>> __cache_VXCejg8xLhmN91XamefUSg = null;
        static CullRayDefault_N3svfid7Nt6OfgkZE6IjlB()
        {
        }

        public CullRayDefault_N3svfid7Nt6OfgkZE6IjlB(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CullRayDefault_N3svfid7Nt6OfgkZE6IjlB(CullRayDefault_N3svfid7Nt6OfgkZE6IjlB other): base(other)
        {
            this.__cache_VXCejg8xLhmN91XamefUSg = other.__cache_VXCejg8xLhmN91XamefUSg;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_VXCejg8xLhmN91XamefUSg", in __cache_VXCejg8xLhmN91XamefUSg));
        }

        internal CullRayDefault_N3svfid7Nt6OfgkZE6IjlB __WITH__(n10.Manager<n2.ValueTuple<n8.GpuValue<n16.Ray>, float, float, string, string>, n2.ValueTuple<n8.GpuValue<n9.Vector2>>> __cache_VXCejg8xLhmN91XamefUSg)
        {
            n15.CullRayDefault_N3svfid7Nt6OfgkZE6IjlB that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_VXCejg8xLhmN91XamefUSg != this.__cache_VXCejg8xLhmN91XamefUSg ? new CullRayDefault_N3svfid7Nt6OfgkZE6IjlB(this)
                {__cache_VXCejg8xLhmN91XamefUSg = __cache_VXCejg8xLhmN91XamefUSg} : that_0;
            else
            {
                this.__cache_VXCejg8xLhmN91XamefUSg = __cache_VXCejg8xLhmN91XamefUSg;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Ov3Zmq2UbifNCwa9qfAJSx", Name = "__Ov3Zmq2UbifNCwa9qfAJSx")]
        [n2.SerializableAttribute]
        public class __Ov3Zmq2UbifNCwa9qfAJSx : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_GgdOhSg6zyoNgGGcJwd2rq);
                n1.CompilationHelper.SafeDispose(this.__p_HVG5WG7l9GSLlY9kPfDKDP);
                n1.CompilationHelper.SafeDispose(this.__p_ME7z6kbGII7NgjAUKkXaTG);
                return;
            }

            [n1.ElementAttribute(TracingId = 328140U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "GgdOhSg6zyoNgGGcJwd2rq", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n9.Vector2> __p_GgdOhSg6zyoNgGGcJwd2rq;
            [n1.ElementAttribute(TracingId = 328154U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "HVG5WG7l9GSLlY9kPfDKDP", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n14.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n16.Ray> __p_HVG5WG7l9GSLlY9kPfDKDP;
            [n1.ElementAttribute(TracingId = 328159U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "ME7z6kbGII7NgjAUKkXaTG", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
            public n13.GPUIn_C<n9.Vector2> __p_ME7z6kbGII7NgjAUKkXaTG;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq = default(n5.Spread<n8.AbstractGpuValue>);
            public __Ov3Zmq2UbifNCwa9qfAJSx(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Ov3Zmq2UbifNCwa9qfAJSx(__Ov3Zmq2UbifNCwa9qfAJSx other): base(other)
            {
                this.__p_GgdOhSg6zyoNgGGcJwd2rq = other.__p_GgdOhSg6zyoNgGGcJwd2rq;
                this.__p_HVG5WG7l9GSLlY9kPfDKDP = other.__p_HVG5WG7l9GSLlY9kPfDKDP;
                this.__p_ME7z6kbGII7NgjAUKkXaTG = other.__p_ME7z6kbGII7NgjAUKkXaTG;
                this.__pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq = other.__pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_GgdOhSg6zyoNgGGcJwd2rq", in __p_GgdOhSg6zyoNgGGcJwd2rq), n1.CompilationHelper.GetValueOrExisting(values, "__p_HVG5WG7l9GSLlY9kPfDKDP", in __p_HVG5WG7l9GSLlY9kPfDKDP), n1.CompilationHelper.GetValueOrExisting(values, "__p_ME7z6kbGII7NgjAUKkXaTG", in __p_ME7z6kbGII7NgjAUKkXaTG), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq", in __pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq));
            }

            internal __Ov3Zmq2UbifNCwa9qfAJSx __WITH__(n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n9.Vector2> __p_GgdOhSg6zyoNgGGcJwd2rq, n14.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n16.Ray> __p_HVG5WG7l9GSLlY9kPfDKDP, n13.GPUIn_C<n9.Vector2> __p_ME7z6kbGII7NgjAUKkXaTG, n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq)
            {
                __Ov3Zmq2UbifNCwa9qfAJSx that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_GgdOhSg6zyoNgGGcJwd2rq != this.__p_GgdOhSg6zyoNgGGcJwd2rq || __p_HVG5WG7l9GSLlY9kPfDKDP != this.__p_HVG5WG7l9GSLlY9kPfDKDP || __p_ME7z6kbGII7NgjAUKkXaTG != this.__p_ME7z6kbGII7NgjAUKkXaTG || __pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq != this.__pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq ? new __Ov3Zmq2UbifNCwa9qfAJSx(this)
                    {__p_GgdOhSg6zyoNgGGcJwd2rq = __p_GgdOhSg6zyoNgGGcJwd2rq, __p_HVG5WG7l9GSLlY9kPfDKDP = __p_HVG5WG7l9GSLlY9kPfDKDP, __p_ME7z6kbGII7NgjAUKkXaTG = __p_ME7z6kbGII7NgjAUKkXaTG, __pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq = __pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq} : that_0;
                else
                {
                    this.__p_GgdOhSg6zyoNgGGcJwd2rq = __p_GgdOhSg6zyoNgGGcJwd2rq;
                    this.__p_HVG5WG7l9GSLlY9kPfDKDP = __p_HVG5WG7l9GSLlY9kPfDKDP;
                    this.__p_ME7z6kbGII7NgjAUKkXaTG = __p_ME7z6kbGII7NgjAUKkXaTG;
                    this.__pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq = __pin_group_Arguments_In_GgdOhSg6zyoNgGGcJwd2rq;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 328235U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "H9TiFzHGgLFLzt1tQo8ADc", Name = "ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc")]
    [n2.SerializableAttribute]
    public class ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n15.ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc Create(n1.NodeContext Node_Context)
        {
            var instance = new ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n15.ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc CreateDefault()
        {
            var instance = new ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n15.ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc Update(n8.GpuValue<n16.Ray> Ray_In, [n4.SerializedDefaultValueAttribute("True", false)] bool View_Friendly_In, out n8.GpuValue<n9.Vector4> Output_Out)
        {
            string __pad_EcG8CXFlY2ENtjFfunmtqA_0 = __slot_EcG8CXFlY2ENtjFfunmtqA;
            string __pad_CwkosT3vwUbOkjxtBp9g49_1 = __slot_CwkosT3vwUbOkjxtBp9g49;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_AGRbILu2XfXMLLQP56sKjA;
            if (manager_4 is null)
            {
                manager_4 = new n10.Manager<n2.ValueTuple<n8.GpuValue<n16.Ray>, bool, string, string>, n2.ValueTuple<n8.GpuValue<n9.Vector4>>>(n2.ValueTuple.Create(default(n8.GpuValue<n9.Vector4>)));
            }

            var inputs_5 = (Ray_In, View_Friendly_In, __pad_EcG8CXFlY2ENtjFfunmtqA_0, __pad_CwkosT3vwUbOkjxtBp9g49_1);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__E6h2VU7jBxSOHsN8HeTffJ>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __E6h2VU7jBxSOHsN8HeTffJ(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq = n21._Operations_.CreateDefault<n8.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "VVPzKMIjUx1LQjhgrxSQHq", 328260U);
                    var Output_10 = n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n9.Vector4>.Create(Node_Context: Node_Context_9);
                    state_8.__p_VVPzKMIjUx1LQjhgrxSQHq = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "Jm6v2vXnOXqORKdhkcWqWF", 328273U);
                    var Output_12 = n13.Constant_C05sp6Ijg7TN6Mfl7g0LqX<bool>.Create(Node_Context: Node_Context_11);
                    state_8.__p_Jm6v2vXnOXqORKdhkcWqWF = Output_12;
                }

                var Output_14 = state_8.__p_Jm6v2vXnOXqORKdhkcWqWF.Update(Value_In: View_Friendly_In, GpuValue_Out: out n8.GpuValue<bool> GpuValue_13);
                n8.GpuValue<n9.Vector4> Default_15 = default(n8.GpuValue<n9.Vector4>);
                bool Is_Groupable_16 = false;
                n11.IEnumerable<n8.InputModifier> The_Modifiers_17 = n24._Operations_.CreateDefault<n8.InputModifier>();
                var builder_18 = n4.CollectionBuilders.GetBuilder(state_8.__pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq, 2);
                builder_18.Add(Ray_In);
                builder_18.Add(GpuValue_13);
                var __pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq_19 = builder_18.Commit();
                var State_Output_22 = state_8.__p_VVPzKMIjUx1LQjhgrxSQHq.Update(Arguments_In: __pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq_19, Function_Name_In: __pad_EcG8CXFlY2ENtjFfunmtqA_0, Default_In: Default_15, Mixins_In: __pad_CwkosT3vwUbOkjxtBp9g49_1, Is_Groupable_In: Is_Groupable_16, The_Modifiers_In: The_Modifiers_17, Output_Out: out n8.GpuValue<n9.Vector4> Output_20, Additional_Outputs_Out: out n5.Spread<n8.AbstractGpuValue> Additional_Outputs_21);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = Output_14 != state_8.__p_Jm6v2vXnOXqORKdhkcWqWF || __pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq_19 != state_8.__pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq || State_Output_22 != state_8.__p_VVPzKMIjUx1LQjhgrxSQHq ? new __E6h2VU7jBxSOHsN8HeTffJ(state_8)
                    {__p_Jm6v2vXnOXqORKdhkcWqWF = Output_14, __pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq = __pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq_19, __p_VVPzKMIjUx1LQjhgrxSQHq = State_Output_22} : state_8;
                else
                {
                    state_8.__p_Jm6v2vXnOXqORKdhkcWqWF = Output_14;
                    state_8.__pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq = __pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq_19;
                    state_8.__p_VVPzKMIjUx1LQjhgrxSQHq = State_Output_22;
                }

                outputs_6 = n2.ValueTuple.Create(Output_20);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_23 = outputs_6.Item1;
            Output_Out = __auto_23;
            n15.ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc that_24 = this;
            if (this.__GetContext__().IsImmutable)
                that_24 = manager_4 != this.__cache_AGRbILu2XfXMLLQP56sKjA ? new ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc(this)
                {__cache_AGRbILu2XfXMLLQP56sKjA = manager_4} : that_24;
            else
            {
                this.__cache_AGRbILu2XfXMLLQP56sKjA = manager_4;
            }

            return that_24;
        }

        public n15.ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n15.ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc that_0 = this;
            this.__cache_AGRbILu2XfXMLLQP56sKjA = null;
            return that_0;
        }

        public n15.ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc __CreateDefault__()
        {
            n15.ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc that_0 = this;
            this.__cache_AGRbILu2XfXMLLQP56sKjA = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_AGRbILu2XfXMLLQP56sKjA);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 328283U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "EcG8CXFlY2ENtjFfunmtqA", Name = "__slot_EcG8CXFlY2ENtjFfunmtqA")]
        public static string __slot_EcG8CXFlY2ENtjFfunmtqA = "shadeRayNormals";
        [n1.ElementAttribute(TracingId = 328285U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "CwkosT3vwUbOkjxtBp9g49", Name = "__slot_CwkosT3vwUbOkjxtBp9g49")]
        public static string __slot_CwkosT3vwUbOkjxtBp9g49 = "FuseRayMarch";
        [n1.ElementAttribute(TracingId = 328238U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "AGRbILu2XfXMLLQP56sKjA", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n10.Manager<n2.ValueTuple<n8.GpuValue<n16.Ray>, bool, string, string>, n2.ValueTuple<n8.GpuValue<n9.Vector4>>> __cache_AGRbILu2XfXMLLQP56sKjA = null;
        static ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc()
        {
        }

        public ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc(ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc other): base(other)
        {
            this.__cache_AGRbILu2XfXMLLQP56sKjA = other.__cache_AGRbILu2XfXMLLQP56sKjA;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_AGRbILu2XfXMLLQP56sKjA", in __cache_AGRbILu2XfXMLLQP56sKjA));
        }

        internal ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc __WITH__(n10.Manager<n2.ValueTuple<n8.GpuValue<n16.Ray>, bool, string, string>, n2.ValueTuple<n8.GpuValue<n9.Vector4>>> __cache_AGRbILu2XfXMLLQP56sKjA)
        {
            n15.ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_AGRbILu2XfXMLLQP56sKjA != this.__cache_AGRbILu2XfXMLLQP56sKjA ? new ShadeRayNormals_H9TiFzHGgLFLzt1tQo8ADc(this)
                {__cache_AGRbILu2XfXMLLQP56sKjA = __cache_AGRbILu2XfXMLLQP56sKjA} : that_0;
            else
            {
                this.__cache_AGRbILu2XfXMLLQP56sKjA = __cache_AGRbILu2XfXMLLQP56sKjA;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "E6h2VU7jBxSOHsN8HeTffJ", Name = "__E6h2VU7jBxSOHsN8HeTffJ")]
        [n2.SerializableAttribute]
        public class __E6h2VU7jBxSOHsN8HeTffJ : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_VVPzKMIjUx1LQjhgrxSQHq);
                n1.CompilationHelper.SafeDispose(this.__p_Jm6v2vXnOXqORKdhkcWqWF);
                return;
            }

            [n1.ElementAttribute(TracingId = 328260U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "VVPzKMIjUx1LQjhgrxSQHq", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n9.Vector4> __p_VVPzKMIjUx1LQjhgrxSQHq;
            [n1.ElementAttribute(TracingId = 328273U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Jm6v2vXnOXqORKdhkcWqWF", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n13.Constant_C05sp6Ijg7TN6Mfl7g0LqX<bool> __p_Jm6v2vXnOXqORKdhkcWqWF;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq = default(n5.Spread<n8.AbstractGpuValue>);
            public __E6h2VU7jBxSOHsN8HeTffJ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __E6h2VU7jBxSOHsN8HeTffJ(__E6h2VU7jBxSOHsN8HeTffJ other): base(other)
            {
                this.__p_VVPzKMIjUx1LQjhgrxSQHq = other.__p_VVPzKMIjUx1LQjhgrxSQHq;
                this.__p_Jm6v2vXnOXqORKdhkcWqWF = other.__p_Jm6v2vXnOXqORKdhkcWqWF;
                this.__pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq = other.__pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VVPzKMIjUx1LQjhgrxSQHq", in __p_VVPzKMIjUx1LQjhgrxSQHq), n1.CompilationHelper.GetValueOrExisting(values, "__p_Jm6v2vXnOXqORKdhkcWqWF", in __p_Jm6v2vXnOXqORKdhkcWqWF), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq", in __pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq));
            }

            internal __E6h2VU7jBxSOHsN8HeTffJ __WITH__(n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n9.Vector4> __p_VVPzKMIjUx1LQjhgrxSQHq, n13.Constant_C05sp6Ijg7TN6Mfl7g0LqX<bool> __p_Jm6v2vXnOXqORKdhkcWqWF, n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq)
            {
                __E6h2VU7jBxSOHsN8HeTffJ that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_VVPzKMIjUx1LQjhgrxSQHq != this.__p_VVPzKMIjUx1LQjhgrxSQHq || __p_Jm6v2vXnOXqORKdhkcWqWF != this.__p_Jm6v2vXnOXqORKdhkcWqWF || __pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq != this.__pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq ? new __E6h2VU7jBxSOHsN8HeTffJ(this)
                    {__p_VVPzKMIjUx1LQjhgrxSQHq = __p_VVPzKMIjUx1LQjhgrxSQHq, __p_Jm6v2vXnOXqORKdhkcWqWF = __p_Jm6v2vXnOXqORKdhkcWqWF, __pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq = __pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq} : that_0;
                else
                {
                    this.__p_VVPzKMIjUx1LQjhgrxSQHq = __p_VVPzKMIjUx1LQjhgrxSQHq;
                    this.__p_Jm6v2vXnOXqORKdhkcWqWF = __p_Jm6v2vXnOXqORKdhkcWqWF;
                    this.__pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq = __pin_group_Arguments_In_VVPzKMIjUx1LQjhgrxSQHq;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 328327U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "BVjz0DL5EVfNcvUGyzWisH", Name = "SetupRayPano_BVjz0DL5EVfNcvUGyzWisH")]
    [n2.SerializableAttribute]
    public class SetupRayPano_BVjz0DL5EVfNcvUGyzWisH : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n15.SetupRayPano_BVjz0DL5EVfNcvUGyzWisH Create(n1.NodeContext Node_Context)
        {
            var instance = new SetupRayPano_BVjz0DL5EVfNcvUGyzWisH(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n15.SetupRayPano_BVjz0DL5EVfNcvUGyzWisH CreateDefault()
        {
            var instance = new SetupRayPano_BVjz0DL5EVfNcvUGyzWisH(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n15.SetupRayPano_BVjz0DL5EVfNcvUGyzWisH Update(out n8.GpuValue<n16.Ray> Ray_Out)
        {
            string __pad_AzEUqrAbI1RLWmKlryTzsz_0 = __slot_AzEUqrAbI1RLWmKlryTzsz;
            string __pad_KswTgsxTyU0Oo2FypH2Qz6_1 = __slot_KswTgsxTyU0Oo2FypH2Qz6;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_B3osGAtmF6ALEg4lVfDn3Y;
            if (manager_4 is null)
            {
                manager_4 = new n10.Manager<n2.ValueTuple<string, string>, n2.ValueTuple<n8.GpuValue<n16.Ray>>>(n2.ValueTuple.Create(default(n8.GpuValue<n16.Ray>)));
            }

            var inputs_5 = (__pad_AzEUqrAbI1RLWmKlryTzsz_0, __pad_KswTgsxTyU0Oo2FypH2Qz6_1);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__LVQpQxmCTNnNCnjh7xb78j>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __LVQpQxmCTNnNCnjh7xb78j(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7 = n21._Operations_.CreateDefault<n8.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "Mxv5JL1VvrSLo0D53FNUe7", 328358U);
                    var Output_10 = n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n16.Ray>.Create(Node_Context: Node_Context_9);
                    state_8.__p_Mxv5JL1VvrSLo0D53FNUe7 = Output_10;
                }

                n8.GpuValue<n16.Ray> Default_11 = default(n8.GpuValue<n16.Ray>);
                bool Is_Groupable_12 = false;
                n11.IEnumerable<n8.InputModifier> The_Modifiers_13 = n24._Operations_.CreateDefault<n8.InputModifier>();
                var builder_14 = n4.CollectionBuilders.GetBuilder(state_8.__pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7, 0);
                var __pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7_15 = builder_14.Commit();
                var State_Output_18 = state_8.__p_Mxv5JL1VvrSLo0D53FNUe7.Update(Arguments_In: __pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7_15, Function_Name_In: __pad_AzEUqrAbI1RLWmKlryTzsz_0, Default_In: Default_11, Mixins_In: __pad_KswTgsxTyU0Oo2FypH2Qz6_1, Is_Groupable_In: Is_Groupable_12, The_Modifiers_In: The_Modifiers_13, Output_Out: out n8.GpuValue<n16.Ray> Output_16, Additional_Outputs_Out: out n5.Spread<n8.AbstractGpuValue> Additional_Outputs_17);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = __pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7_15 != state_8.__pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7 || State_Output_18 != state_8.__p_Mxv5JL1VvrSLo0D53FNUe7 ? new __LVQpQxmCTNnNCnjh7xb78j(state_8)
                    {__pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7 = __pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7_15, __p_Mxv5JL1VvrSLo0D53FNUe7 = State_Output_18} : state_8;
                else
                {
                    state_8.__pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7 = __pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7_15;
                    state_8.__p_Mxv5JL1VvrSLo0D53FNUe7 = State_Output_18;
                }

                outputs_6 = n2.ValueTuple.Create(Output_16);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_19 = outputs_6.Item1;
            Ray_Out = __auto_19;
            n15.SetupRayPano_BVjz0DL5EVfNcvUGyzWisH that_20 = this;
            if (this.__GetContext__().IsImmutable)
                that_20 = manager_4 != this.__cache_B3osGAtmF6ALEg4lVfDn3Y ? new SetupRayPano_BVjz0DL5EVfNcvUGyzWisH(this)
                {__cache_B3osGAtmF6ALEg4lVfDn3Y = manager_4} : that_20;
            else
            {
                this.__cache_B3osGAtmF6ALEg4lVfDn3Y = manager_4;
            }

            return that_20;
        }

        public n15.SetupRayPano_BVjz0DL5EVfNcvUGyzWisH __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n15.SetupRayPano_BVjz0DL5EVfNcvUGyzWisH that_0 = this;
            this.__cache_B3osGAtmF6ALEg4lVfDn3Y = null;
            return that_0;
        }

        public n15.SetupRayPano_BVjz0DL5EVfNcvUGyzWisH __CreateDefault__()
        {
            n15.SetupRayPano_BVjz0DL5EVfNcvUGyzWisH that_0 = this;
            this.__cache_B3osGAtmF6ALEg4lVfDn3Y = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_B3osGAtmF6ALEg4lVfDn3Y);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 328365U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "AzEUqrAbI1RLWmKlryTzsz", Name = "__slot_AzEUqrAbI1RLWmKlryTzsz")]
        public static string __slot_AzEUqrAbI1RLWmKlryTzsz = "setupRayPano";
        [n1.ElementAttribute(TracingId = 328367U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "KswTgsxTyU0Oo2FypH2Qz6", Name = "__slot_KswTgsxTyU0Oo2FypH2Qz6")]
        public static string __slot_KswTgsxTyU0Oo2FypH2Qz6 = "FuseRayMarch";
        [n1.ElementAttribute(TracingId = 328334U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "B3osGAtmF6ALEg4lVfDn3Y", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n10.Manager<n2.ValueTuple<string, string>, n2.ValueTuple<n8.GpuValue<n16.Ray>>> __cache_B3osGAtmF6ALEg4lVfDn3Y = null;
        static SetupRayPano_BVjz0DL5EVfNcvUGyzWisH()
        {
        }

        public SetupRayPano_BVjz0DL5EVfNcvUGyzWisH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SetupRayPano_BVjz0DL5EVfNcvUGyzWisH(SetupRayPano_BVjz0DL5EVfNcvUGyzWisH other): base(other)
        {
            this.__cache_B3osGAtmF6ALEg4lVfDn3Y = other.__cache_B3osGAtmF6ALEg4lVfDn3Y;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_B3osGAtmF6ALEg4lVfDn3Y", in __cache_B3osGAtmF6ALEg4lVfDn3Y));
        }

        internal SetupRayPano_BVjz0DL5EVfNcvUGyzWisH __WITH__(n10.Manager<n2.ValueTuple<string, string>, n2.ValueTuple<n8.GpuValue<n16.Ray>>> __cache_B3osGAtmF6ALEg4lVfDn3Y)
        {
            n15.SetupRayPano_BVjz0DL5EVfNcvUGyzWisH that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_B3osGAtmF6ALEg4lVfDn3Y != this.__cache_B3osGAtmF6ALEg4lVfDn3Y ? new SetupRayPano_BVjz0DL5EVfNcvUGyzWisH(this)
                {__cache_B3osGAtmF6ALEg4lVfDn3Y = __cache_B3osGAtmF6ALEg4lVfDn3Y} : that_0;
            else
            {
                this.__cache_B3osGAtmF6ALEg4lVfDn3Y = __cache_B3osGAtmF6ALEg4lVfDn3Y;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "LVQpQxmCTNnNCnjh7xb78j", Name = "__LVQpQxmCTNnNCnjh7xb78j")]
        [n2.SerializableAttribute]
        public class __LVQpQxmCTNnNCnjh7xb78j : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Mxv5JL1VvrSLo0D53FNUe7);
                return;
            }

            [n1.ElementAttribute(TracingId = 328358U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Mxv5JL1VvrSLo0D53FNUe7", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n16.Ray> __p_Mxv5JL1VvrSLo0D53FNUe7;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7 = default(n5.Spread<n8.AbstractGpuValue>);
            public __LVQpQxmCTNnNCnjh7xb78j(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __LVQpQxmCTNnNCnjh7xb78j(__LVQpQxmCTNnNCnjh7xb78j other): base(other)
            {
                this.__p_Mxv5JL1VvrSLo0D53FNUe7 = other.__p_Mxv5JL1VvrSLo0D53FNUe7;
                this.__pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7 = other.__pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Mxv5JL1VvrSLo0D53FNUe7", in __p_Mxv5JL1VvrSLo0D53FNUe7), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7", in __pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7));
            }

            internal __LVQpQxmCTNnNCnjh7xb78j __WITH__(n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n16.Ray> __p_Mxv5JL1VvrSLo0D53FNUe7, n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7)
            {
                __LVQpQxmCTNnNCnjh7xb78j that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Mxv5JL1VvrSLo0D53FNUe7 != this.__p_Mxv5JL1VvrSLo0D53FNUe7 || __pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7 != this.__pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7 ? new __LVQpQxmCTNnNCnjh7xb78j(this)
                    {__p_Mxv5JL1VvrSLo0D53FNUe7 = __p_Mxv5JL1VvrSLo0D53FNUe7, __pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7 = __pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7} : that_0;
                else
                {
                    this.__p_Mxv5JL1VvrSLo0D53FNUe7 = __p_Mxv5JL1VvrSLo0D53FNUe7;
                    this.__pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7 = __pin_group_Arguments_In_Mxv5JL1VvrSLo0D53FNUe7;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 328406U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "BLZePIt8AjYPSCPhuMjBzi", Name = "MarchRay_BLZePIt8AjYPSCPhuMjBzi")]
    [n2.SerializableAttribute]
    public class MarchRay_BLZePIt8AjYPSCPhuMjBzi : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n15.MarchRay_BLZePIt8AjYPSCPhuMjBzi Create(n1.NodeContext Node_Context)
        {
            var instance = new MarchRay_BLZePIt8AjYPSCPhuMjBzi(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n15.MarchRay_BLZePIt8AjYPSCPhuMjBzi CreateDefault()
        {
            var instance = new MarchRay_BLZePIt8AjYPSCPhuMjBzi(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n15.MarchRay_BLZePIt8AjYPSCPhuMjBzi Update(n8.GpuValue<float> SDF_In, [n4.SerializedDefaultValueAttribute("180", false)] int Max_Iterations_In, n8.GpuValue<n16.Ray> SetupRay_In, n8.GpuValue<n9.Vector2> CullRay_In, out n8.GpuValue<n16.Ray> Output_Out)
        {
            string __pad_Bn3h8AqHjkVLPZQod8Hq9C_0 = __slot_Bn3h8AqHjkVLPZQod8Hq9C;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_N1cVY4lTMQELfJYQJkjIem;
            if (manager_3 is null)
            {
                manager_3 = new n10.Manager<n2.ValueTuple<string, n8.GpuValue<float>, int, n8.GpuValue<n16.Ray>, n8.GpuValue<n9.Vector2>>, n2.ValueTuple<n8.GpuValue<n16.Ray>>>(n2.ValueTuple.Create(default(n8.GpuValue<n16.Ray>)));
            }

            var inputs_4 = (__pad_Bn3h8AqHjkVLPZQod8Hq9C_0, SDF_In, Max_Iterations_In, SetupRay_In, CullRay_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__DhI6tZHu2mWLYPWSvcg9UF>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __DhI6tZHu2mWLYPWSvcg9UF(__GetContext__(), n1.VLObject.NewIdentity())
                    {__slot_I4psfXoOuKuNwMB2K8N8sM = default(n8.GpuValue<n9.Vector3>), __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj = n21._Operations_.CreateDefault<n8.AbstractGpuValue>(), __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j = n21._Operations_.CreateDefault<n8.GpuValue<n16.Ray>>(), __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn = n21._Operations_.CreateDefault<n8.AbstractGpuValue>(), __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D = n21._Operations_.CreateDefault<n8.GpuValue<n9.Vector2>>(), __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe = n21._Operations_.CreateDefault<n8.AbstractGpuValue>(), __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx = n21._Operations_.CreateDefault<n8.IFunctionInvokeNode>(), __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR = n21._Operations_.CreateDefault<string>(), __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp = n21._Operations_.CreateDefault<n8.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "FYCWb81ZCnKMk6ML8clwfp", 328444U);
                    var Output_9 = n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<n16.Ray, n11.IEnumerable<n8.InputModifier>>.Create(Node_Context: Node_Context_8);
                    state_7.__p_FYCWb81ZCnKMk6ML8clwfp = Output_9;
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "OfpUsAdBxTdMG5vXOydHoz", 328497U);
                    var Output_11 = n13.GPUIn_C<int>.Create(Node_Context: Node_Context_10);
                    state_7.__p_OfpUsAdBxTdMG5vXOydHoz = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "A8uNvEbAvEoMMWjP1xGMFm", 328530U);
                    var Output_13 = n18.Position_PeLDdeSku4ANhU5oe5SfPy.Create(Node_Context: Node_Context_12);
                    state_7.__p_A8uNvEbAvEoMMWjP1xGMFm = Output_13;
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "Od0Pg2RrY7oNrISfOh2y2M", 328538U);
                    var Output_15 = n20.To_Qgkn15Kxt1HLURmAdSAN7m<n9.Vector4, n9.Vector3>.Create(Node_Context: Node_Context_14);
                    state_7.__p_Od0Pg2RrY7oNrISfOh2y2M = Output_15;
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "GUYjzQfpXAEQBBeFiMQyRJ", 328560U);
                    var Output_17 = n15.CullRayDefault_N3svfid7Nt6OfgkZE6IjlB.Create(Node_Context: Node_Context_16);
                    state_7.__p_GUYjzQfpXAEQBBeFiMQyRJ = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "DWMx9AKbKOtMBFOiy7L5e1", 328587U);
                    var Output_19 = n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt.Create(Node_Context: Node_Context_18);
                    state_7.__p_DWMx9AKbKOtMBFOiy7L5e1 = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "PfJiq9cUvz4MkDcAe6SkHe", 328593U);
                    var Output_21 = n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<n9.Vector2>.Create(Node_Context: Node_Context_20);
                    state_7.__p_PfJiq9cUvz4MkDcAe6SkHe = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "Bb9y5uOq3u2LQMxRJeFvyn", 328603U);
                    var Output_23 = n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<n16.Ray>.Create(Node_Context: Node_Context_22);
                    state_7.__p_Bb9y5uOq3u2LQMxRJeFvyn = Output_23;
                    n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "O4uY4wtQ91uLJDMmFafbwj", 328611U);
                    var Output_25 = n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.Create(Node_Context: Node_Context_24);
                    state_7.__p_O4uY4wtQ91uLJDMmFafbwj = Output_25;
                }

                string __pad_UPPg81FJqA7OMQESVtrj77_26 = __slot_UPPg81FJqA7OMQESVtrj77;
                string __pad_RRS4RPvYHrqLqEIiXuMNQX_27 = __slot_RRS4RPvYHrqLqEIiXuMNQX;
                string __pad_RXNzGJr0kLkMpENRoVO9FZ_28 = __slot_RXNzGJr0kLkMpENRoVO9FZ;
                string __pad_IbDUjWQA3KAQSD1iAIsNXt_29 = __slot_IbDUjWQA3KAQSD1iAIsNXt;
                string __pad_G2QtsoLiCyDPM8VM0mQGg7_30 = __slot_G2QtsoLiCyDPM8VM0mQGg7;
                var State_Output_32 = state_7.__p_A8uNvEbAvEoMMWjP1xGMFm.Update(Output_Out: out n8.GpuValue<n9.Vector4> Output_31);
                n8.GpuValue<n9.Vector3> default_33 = default(n8.GpuValue<n9.Vector3>);
                var State_Output_35 = state_7.__p_Od0Pg2RrY7oNrISfOh2y2M.Update(x_In: Output_31, default_In: default_33, Output_Out: out n8.GpuValue<n9.Vector3> Output_34);
                n8.GpuValue<n9.Vector3> __pad_I4psfXoOuKuNwMB2K8N8sM_36 = Output_34;
                var State_Output_38 = state_7.__p_OfpUsAdBxTdMG5vXOydHoz.Update(Output_Out: out n8.GpuValue<int> Output_37);
                var builder_39 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj, 1);
                builder_39.Add(__pad_I4psfXoOuKuNwMB2K8N8sM_36);
                var __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj_40 = builder_39.Commit();
                var State_Output_42 = state_7.__p_O4uY4wtQ91uLJDMmFafbwj.Update(Function_In: SDF_In, Parameters_In: __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj_40, Id_In: __pad_RXNzGJr0kLkMpENRoVO9FZ_28, Output_Out: out n8.FunctionInvokeNode<float> Output_41);
                n8.IFunctionInvokeNode Input_43 = (n8.IFunctionInvokeNode)Output_41;
                n39.ObjectHelpers.IsAssigned(x: SetupRay_In, result: out bool Result_44, notAssigned: out bool Not_Assigned_45);
                int Index_46 = n2.Convert.ToInt32(Result_44);
                var Output_48 = state_7.__p_DWMx9AKbKOtMBFOiy7L5e1.Update(Ray_Out: out n8.GpuValue<n16.Ray> Ray_47);
                var builder_49 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j, 2);
                builder_49.Add(Ray_47);
                builder_49.Add(SetupRay_In);
                var __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j_50 = builder_49.Commit();
                n7._Operations_.Switch<n8.GpuValue<n16.Ray>, n6.__AdaptiveImplementations__RGYLe02tPXEQEO6aJ6Qsjm>(Index_In: Index_46, Input_In: __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j_50, Output_Out: out n8.GpuValue<n16.Ray> Output_51);
                var builder_52 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn, 0);
                var __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn_53 = builder_52.Commit();
                var State_Output_55 = state_7.__p_Bb9y5uOq3u2LQMxRJeFvyn.Update(Function_In: Output_51, Parameters_In: __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn_53, Id_In: __pad_IbDUjWQA3KAQSD1iAIsNXt_29, Output_Out: out n8.FunctionInvokeNode<n16.Ray> Output_54);
                n8.IFunctionInvokeNode Input_2_56 = (n8.IFunctionInvokeNode)Output_54;
                n39.ObjectHelpers.IsAssigned(x: CullRay_In, result: out bool Result_57, notAssigned: out bool Not_Assigned_58);
                int Index_59 = n2.Convert.ToInt32(Result_57);
                n8.GpuValue<n16.Ray> Ray_60 = default(n8.GpuValue<n16.Ray>);
                float Min_Distance_61 = 0.01F;
                float Max_Distance_62 = 200F;
                var Output_64 = state_7.__p_GUYjzQfpXAEQBBeFiMQyRJ.Update(Ray_In: Ray_60, Min_Distance_In: Min_Distance_61, Max_Distance_In: Max_Distance_62, Cull_Ray_Out: out n8.GpuValue<n9.Vector2> Cull_Ray_63);
                var builder_65 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D, 2);
                builder_65.Add(Cull_Ray_63);
                builder_65.Add(CullRay_In);
                var __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D_66 = builder_65.Commit();
                n7._Operations_.Switch<n8.GpuValue<n9.Vector2>, n6.__AdaptiveImplementations__RGYLe02tPXEQEO6aJ6Qsjm>(Index_In: Index_59, Input_In: __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D_66, Output_Out: out n8.GpuValue<n9.Vector2> Output_67);
                var builder_68 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe, 1);
                builder_68.Add(Output_51);
                var __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe_69 = builder_68.Commit();
                var State_Output_71 = state_7.__p_PfJiq9cUvz4MkDcAe6SkHe.Update(Function_In: Output_67, Parameters_In: __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe_69, Id_In: __pad_G2QtsoLiCyDPM8VM0mQGg7_30, Output_Out: out n8.FunctionInvokeNode<n9.Vector2> Output_70);
                n8.IFunctionInvokeNode Input_3_72 = (n8.IFunctionInvokeNode)Output_70;
                var builder_73 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx, 3);
                builder_73.Add(Input_43);
                builder_73.Add(Input_2_56);
                builder_73.Add(Input_3_72);
                var __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx_74 = builder_73.Commit();
                n21._Operations_.Cons<n8.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx_74, Result_Out: out n5.Spread<n8.IFunctionInvokeNode> Result_75);
                var builder_76 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR, 1);
                builder_76.Add(__pad_UPPg81FJqA7OMQESVtrj77_26);
                var __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR_77 = builder_76.Commit();
                n21._Operations_.Cons<string>(Input_In: __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR_77, Result_Out: out n5.Spread<string> Result_78);
                n11.IEnumerable<string> Mixins_79 = (n11.IEnumerable<string>)Result_78;
                n8.GpuValue<n16.Ray> Default_Result_80 = default(n8.GpuValue<n16.Ray>);
                n22.ImmutableDictionary<string, string> Template_Values_81 = n23._Operations_.CreateDefault<string, string>();
                bool Is_Groupable_82 = false;
                n11.IEnumerable<n8.InputModifier> The_Modifiers_83 = n24._Operations_.CreateDefault<n8.InputModifier>();
                var builder_84 = n4.CollectionBuilders.GetBuilder(state_7.__pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp, 2);
                builder_84.Add(__pad_I4psfXoOuKuNwMB2K8N8sM_36);
                builder_84.Add(Output_37);
                var __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp_85 = builder_84.Commit();
                var State_Output_88 = state_7.__p_FYCWb81ZCnKMk6ML8clwfp.Update(Arguments_In: __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp_85, Function_Name_In: __pad_RRS4RPvYHrqLqEIiXuMNQX_27, Code_Template_In: __pad_Bn3h8AqHjkVLPZQod8Hq9C_0, Default_Result_In: Default_Result_80, Functions_In: Result_75, Mixins_In: Mixins_79, Template_Values_In: Template_Values_81, Is_Groupable_In: Is_Groupable_82, The_Modifiers_In: The_Modifiers_83, Output_Out: out n8.GpuValue<n16.Ray> Output_86, AdditionalOutputs_Out: out n5.Spread<n8.AbstractGpuValue> AdditionalOutputs_87);
                var AdditionalOutputs_89 = (n8.AbstractGpuValue)AdditionalOutputs_87[0];
                bool SetValue_90 = true;
                var Output_91 = State_Output_38;
                if (SetValue_90)
                {
                    Output_91 = State_Output_38.SetValue(Input_In: Max_Iterations_In);
                }

                if (state_7.__GetContext__().IsImmutable)
                    state_7 = State_Output_32 != state_7.__p_A8uNvEbAvEoMMWjP1xGMFm || State_Output_35 != state_7.__p_Od0Pg2RrY7oNrISfOh2y2M || Output_34 != state_7.__slot_I4psfXoOuKuNwMB2K8N8sM || Output_91 != state_7.__p_OfpUsAdBxTdMG5vXOydHoz || __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj_40 != state_7.__pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj || State_Output_42 != state_7.__p_O4uY4wtQ91uLJDMmFafbwj || Output_48 != state_7.__p_DWMx9AKbKOtMBFOiy7L5e1 || __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j_50 != state_7.__pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j || __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn_53 != state_7.__pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn || State_Output_55 != state_7.__p_Bb9y5uOq3u2LQMxRJeFvyn || Output_64 != state_7.__p_GUYjzQfpXAEQBBeFiMQyRJ || __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D_66 != state_7.__pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D || __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe_69 != state_7.__pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe || State_Output_71 != state_7.__p_PfJiq9cUvz4MkDcAe6SkHe || __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx_74 != state_7.__pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx || __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR_77 != state_7.__pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR || __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp_85 != state_7.__pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp || State_Output_88 != state_7.__p_FYCWb81ZCnKMk6ML8clwfp ? new __DhI6tZHu2mWLYPWSvcg9UF(state_7)
                    {__p_A8uNvEbAvEoMMWjP1xGMFm = State_Output_32, __p_Od0Pg2RrY7oNrISfOh2y2M = State_Output_35, __slot_I4psfXoOuKuNwMB2K8N8sM = Output_34, __p_OfpUsAdBxTdMG5vXOydHoz = Output_91, __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj = __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj_40, __p_O4uY4wtQ91uLJDMmFafbwj = State_Output_42, __p_DWMx9AKbKOtMBFOiy7L5e1 = Output_48, __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j = __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j_50, __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn = __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn_53, __p_Bb9y5uOq3u2LQMxRJeFvyn = State_Output_55, __p_GUYjzQfpXAEQBBeFiMQyRJ = Output_64, __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D = __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D_66, __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe = __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe_69, __p_PfJiq9cUvz4MkDcAe6SkHe = State_Output_71, __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx = __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx_74, __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR = __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR_77, __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp = __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp_85, __p_FYCWb81ZCnKMk6ML8clwfp = State_Output_88} : state_7;
                else
                {
                    state_7.__p_A8uNvEbAvEoMMWjP1xGMFm = State_Output_32;
                    state_7.__p_Od0Pg2RrY7oNrISfOh2y2M = State_Output_35;
                    state_7.__slot_I4psfXoOuKuNwMB2K8N8sM = Output_34;
                    state_7.__p_OfpUsAdBxTdMG5vXOydHoz = Output_91;
                    state_7.__pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj = __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj_40;
                    state_7.__p_O4uY4wtQ91uLJDMmFafbwj = State_Output_42;
                    state_7.__p_DWMx9AKbKOtMBFOiy7L5e1 = Output_48;
                    state_7.__pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j = __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j_50;
                    state_7.__pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn = __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn_53;
                    state_7.__p_Bb9y5uOq3u2LQMxRJeFvyn = State_Output_55;
                    state_7.__p_GUYjzQfpXAEQBBeFiMQyRJ = Output_64;
                    state_7.__pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D = __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D_66;
                    state_7.__pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe = __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe_69;
                    state_7.__p_PfJiq9cUvz4MkDcAe6SkHe = State_Output_71;
                    state_7.__pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx = __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx_74;
                    state_7.__pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR = __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR_77;
                    state_7.__pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp = __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp_85;
                    state_7.__p_FYCWb81ZCnKMk6ML8clwfp = State_Output_88;
                }

                outputs_5 = n2.ValueTuple.Create(Output_86);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_92 = outputs_5.Item1;
            Output_Out = __auto_92;
            n15.MarchRay_BLZePIt8AjYPSCPhuMjBzi that_93 = this;
            if (this.__GetContext__().IsImmutable)
                that_93 = manager_3 != this.__cache_N1cVY4lTMQELfJYQJkjIem ? new MarchRay_BLZePIt8AjYPSCPhuMjBzi(this)
                {__cache_N1cVY4lTMQELfJYQJkjIem = manager_3} : that_93;
            else
            {
                this.__cache_N1cVY4lTMQELfJYQJkjIem = manager_3;
            }

            return that_93;
        }

        public n15.MarchRay_BLZePIt8AjYPSCPhuMjBzi __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n15.MarchRay_BLZePIt8AjYPSCPhuMjBzi that_0 = this;
            this.__cache_N1cVY4lTMQELfJYQJkjIem = null;
            return that_0;
        }

        public n15.MarchRay_BLZePIt8AjYPSCPhuMjBzi __CreateDefault__()
        {
            n15.MarchRay_BLZePIt8AjYPSCPhuMjBzi that_0 = this;
            this.__cache_N1cVY4lTMQELfJYQJkjIem = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_N1cVY4lTMQELfJYQJkjIem);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 328624U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Bn3h8AqHjkVLPZQod8Hq9C", Name = "__slot_Bn3h8AqHjkVLPZQod8Hq9C")]
        public static string __slot_Bn3h8AqHjkVLPZQod8Hq9C = "// raymarcher\r\nfloat SDF(float3 p) // should be override unless it's the first imp.  Gets called by the other functions\r\n{\r\n\treturn ${SDF}(p);\r\n}\r\n\r\nRay ${signature}(float3 p, int maxIter)\r\n{\r\n\tRay ray = ${SETUP}();\r\n\tfloat2 minMaxDist = ${CULL}(ray);\r\n\tmarchRayDefualt(ray, minMaxDist, maxIter);\r\n\treturn ray;\r\n}";
        [n1.ElementAttribute(TracingId = 328412U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "N1cVY4lTMQELfJYQJkjIem", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n10.Manager<n2.ValueTuple<string, n8.GpuValue<float>, int, n8.GpuValue<n16.Ray>, n8.GpuValue<n9.Vector2>>, n2.ValueTuple<n8.GpuValue<n16.Ray>>> __cache_N1cVY4lTMQELfJYQJkjIem = null;
        [n1.ElementAttribute(TracingId = 328493U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "UPPg81FJqA7OMQESVtrj77", Name = "__slot_UPPg81FJqA7OMQESVtrj77")]
        public static string __slot_UPPg81FJqA7OMQESVtrj77 = "FuseRayMarch";
        [n1.ElementAttribute(TracingId = 328477U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "RRS4RPvYHrqLqEIiXuMNQX", Name = "__slot_RRS4RPvYHrqLqEIiXuMNQX")]
        public static string __slot_RRS4RPvYHrqLqEIiXuMNQX = "MarchRay";
        [n1.ElementAttribute(TracingId = 328482U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "RXNzGJr0kLkMpENRoVO9FZ", Name = "__slot_RXNzGJr0kLkMpENRoVO9FZ")]
        public static string __slot_RXNzGJr0kLkMpENRoVO9FZ = "SDF";
        [n1.ElementAttribute(TracingId = 328519U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "IbDUjWQA3KAQSD1iAIsNXt", Name = "__slot_IbDUjWQA3KAQSD1iAIsNXt")]
        public static string __slot_IbDUjWQA3KAQSD1iAIsNXt = "SETUP";
        [n1.ElementAttribute(TracingId = 328522U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "G2QtsoLiCyDPM8VM0mQGg7", Name = "__slot_G2QtsoLiCyDPM8VM0mQGg7")]
        public static string __slot_G2QtsoLiCyDPM8VM0mQGg7 = "CULL";
        static MarchRay_BLZePIt8AjYPSCPhuMjBzi()
        {
        }

        public MarchRay_BLZePIt8AjYPSCPhuMjBzi(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal MarchRay_BLZePIt8AjYPSCPhuMjBzi(MarchRay_BLZePIt8AjYPSCPhuMjBzi other): base(other)
        {
            this.__cache_N1cVY4lTMQELfJYQJkjIem = other.__cache_N1cVY4lTMQELfJYQJkjIem;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_N1cVY4lTMQELfJYQJkjIem", in __cache_N1cVY4lTMQELfJYQJkjIem));
        }

        internal MarchRay_BLZePIt8AjYPSCPhuMjBzi __WITH__(n10.Manager<n2.ValueTuple<string, n8.GpuValue<float>, int, n8.GpuValue<n16.Ray>, n8.GpuValue<n9.Vector2>>, n2.ValueTuple<n8.GpuValue<n16.Ray>>> __cache_N1cVY4lTMQELfJYQJkjIem)
        {
            n15.MarchRay_BLZePIt8AjYPSCPhuMjBzi that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_N1cVY4lTMQELfJYQJkjIem != this.__cache_N1cVY4lTMQELfJYQJkjIem ? new MarchRay_BLZePIt8AjYPSCPhuMjBzi(this)
                {__cache_N1cVY4lTMQELfJYQJkjIem = __cache_N1cVY4lTMQELfJYQJkjIem} : that_0;
            else
            {
                this.__cache_N1cVY4lTMQELfJYQJkjIem = __cache_N1cVY4lTMQELfJYQJkjIem;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "DhI6tZHu2mWLYPWSvcg9UF", Name = "__DhI6tZHu2mWLYPWSvcg9UF")]
        [n2.SerializableAttribute]
        public class __DhI6tZHu2mWLYPWSvcg9UF : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_FYCWb81ZCnKMk6ML8clwfp);
                n1.CompilationHelper.SafeDispose(this.__p_OfpUsAdBxTdMG5vXOydHoz);
                n1.CompilationHelper.SafeDispose(this.__p_A8uNvEbAvEoMMWjP1xGMFm);
                n1.CompilationHelper.SafeDispose(this.__p_Od0Pg2RrY7oNrISfOh2y2M);
                n1.CompilationHelper.SafeDispose(this.__p_GUYjzQfpXAEQBBeFiMQyRJ);
                n1.CompilationHelper.SafeDispose(this.__p_DWMx9AKbKOtMBFOiy7L5e1);
                n1.CompilationHelper.SafeDispose(this.__p_PfJiq9cUvz4MkDcAe6SkHe);
                n1.CompilationHelper.SafeDispose(this.__p_Bb9y5uOq3u2LQMxRJeFvyn);
                n1.CompilationHelper.SafeDispose(this.__p_O4uY4wtQ91uLJDMmFafbwj);
                return;
            }

            [n1.ElementAttribute(TracingId = 328444U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "FYCWb81ZCnKMk6ML8clwfp", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<n16.Ray, n11.IEnumerable<n8.InputModifier>> __p_FYCWb81ZCnKMk6ML8clwfp;
            [n1.ElementAttribute(TracingId = 328497U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "OfpUsAdBxTdMG5vXOydHoz", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
            public n13.GPUIn_C<int> __p_OfpUsAdBxTdMG5vXOydHoz;
            [n1.ElementAttribute(TracingId = 328530U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "A8uNvEbAvEoMMWjP1xGMFm", Name = "Position", IsManaged = true, IsAutoGenerated = true)]
            public n18.Position_PeLDdeSku4ANhU5oe5SfPy __p_A8uNvEbAvEoMMWjP1xGMFm;
            [n1.ElementAttribute(TracingId = 328538U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Od0Pg2RrY7oNrISfOh2y2M", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n20.To_Qgkn15Kxt1HLURmAdSAN7m<n9.Vector4, n9.Vector3> __p_Od0Pg2RrY7oNrISfOh2y2M;
            [n1.ElementAttribute(TracingId = 328560U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "GUYjzQfpXAEQBBeFiMQyRJ", Name = "CullRayDefault", IsManaged = true, IsAutoGenerated = true)]
            public n15.CullRayDefault_N3svfid7Nt6OfgkZE6IjlB __p_GUYjzQfpXAEQBBeFiMQyRJ;
            [n1.ElementAttribute(TracingId = 328587U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "DWMx9AKbKOtMBFOiy7L5e1", Name = "SetupRayByCamera", IsManaged = true, IsAutoGenerated = true)]
            public n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt __p_DWMx9AKbKOtMBFOiy7L5e1;
            [n1.ElementAttribute(TracingId = 328593U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "PfJiq9cUvz4MkDcAe6SkHe", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<n9.Vector2> __p_PfJiq9cUvz4MkDcAe6SkHe;
            [n1.ElementAttribute(TracingId = 328603U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Bb9y5uOq3u2LQMxRJeFvyn", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<n16.Ray> __p_Bb9y5uOq3u2LQMxRJeFvyn;
            [n1.ElementAttribute(TracingId = 328611U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "O4uY4wtQ91uLJDMmFafbwj", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_O4uY4wtQ91uLJDMmFafbwj;
            [n1.ElementAttribute(TracingId = 328526U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "I4psfXoOuKuNwMB2K8N8sM", Name = "__slot_I4psfXoOuKuNwMB2K8N8sM")]
            public n8.GpuValue<n9.Vector3> __slot_I4psfXoOuKuNwMB2K8N8sM;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj = default(n5.Spread<n8.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.GpuValue<n16.Ray>> __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j = default(n5.Spread<n8.GpuValue<n16.Ray>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn = default(n5.Spread<n8.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.GpuValue<n9.Vector2>> __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D = default(n5.Spread<n8.GpuValue<n9.Vector2>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe = default(n5.Spread<n8.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.IFunctionInvokeNode> __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx = default(n5.Spread<n8.IFunctionInvokeNode>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<string> __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR = default(n5.Spread<string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp = default(n5.Spread<n8.AbstractGpuValue>);
            public __DhI6tZHu2mWLYPWSvcg9UF(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DhI6tZHu2mWLYPWSvcg9UF(__DhI6tZHu2mWLYPWSvcg9UF other): base(other)
            {
                this.__p_FYCWb81ZCnKMk6ML8clwfp = other.__p_FYCWb81ZCnKMk6ML8clwfp;
                this.__p_OfpUsAdBxTdMG5vXOydHoz = other.__p_OfpUsAdBxTdMG5vXOydHoz;
                this.__p_A8uNvEbAvEoMMWjP1xGMFm = other.__p_A8uNvEbAvEoMMWjP1xGMFm;
                this.__p_Od0Pg2RrY7oNrISfOh2y2M = other.__p_Od0Pg2RrY7oNrISfOh2y2M;
                this.__p_GUYjzQfpXAEQBBeFiMQyRJ = other.__p_GUYjzQfpXAEQBBeFiMQyRJ;
                this.__p_DWMx9AKbKOtMBFOiy7L5e1 = other.__p_DWMx9AKbKOtMBFOiy7L5e1;
                this.__p_PfJiq9cUvz4MkDcAe6SkHe = other.__p_PfJiq9cUvz4MkDcAe6SkHe;
                this.__p_Bb9y5uOq3u2LQMxRJeFvyn = other.__p_Bb9y5uOq3u2LQMxRJeFvyn;
                this.__p_O4uY4wtQ91uLJDMmFafbwj = other.__p_O4uY4wtQ91uLJDMmFafbwj;
                this.__slot_I4psfXoOuKuNwMB2K8N8sM = other.__slot_I4psfXoOuKuNwMB2K8N8sM;
                this.__pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj = other.__pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj;
                this.__pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j = other.__pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j;
                this.__pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn = other.__pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn;
                this.__pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D = other.__pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D;
                this.__pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe = other.__pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe;
                this.__pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx = other.__pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx;
                this.__pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR = other.__pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR;
                this.__pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp = other.__pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FYCWb81ZCnKMk6ML8clwfp", in __p_FYCWb81ZCnKMk6ML8clwfp), n1.CompilationHelper.GetValueOrExisting(values, "__p_OfpUsAdBxTdMG5vXOydHoz", in __p_OfpUsAdBxTdMG5vXOydHoz), n1.CompilationHelper.GetValueOrExisting(values, "__p_A8uNvEbAvEoMMWjP1xGMFm", in __p_A8uNvEbAvEoMMWjP1xGMFm), n1.CompilationHelper.GetValueOrExisting(values, "__p_Od0Pg2RrY7oNrISfOh2y2M", in __p_Od0Pg2RrY7oNrISfOh2y2M), n1.CompilationHelper.GetValueOrExisting(values, "__p_GUYjzQfpXAEQBBeFiMQyRJ", in __p_GUYjzQfpXAEQBBeFiMQyRJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_DWMx9AKbKOtMBFOiy7L5e1", in __p_DWMx9AKbKOtMBFOiy7L5e1), n1.CompilationHelper.GetValueOrExisting(values, "__p_PfJiq9cUvz4MkDcAe6SkHe", in __p_PfJiq9cUvz4MkDcAe6SkHe), n1.CompilationHelper.GetValueOrExisting(values, "__p_Bb9y5uOq3u2LQMxRJeFvyn", in __p_Bb9y5uOq3u2LQMxRJeFvyn), n1.CompilationHelper.GetValueOrExisting(values, "__p_O4uY4wtQ91uLJDMmFafbwj", in __p_O4uY4wtQ91uLJDMmFafbwj), n1.CompilationHelper.GetValueOrExisting(values, "__slot_I4psfXoOuKuNwMB2K8N8sM", in __slot_I4psfXoOuKuNwMB2K8N8sM), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj", in __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j", in __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn", in __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D", in __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe", in __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx", in __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR", in __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp", in __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp));
            }

            internal __DhI6tZHu2mWLYPWSvcg9UF __WITH__(n12.CustomFunction_SbJY8E2PFscPAropl3Jh79<n16.Ray, n11.IEnumerable<n8.InputModifier>> __p_FYCWb81ZCnKMk6ML8clwfp, n13.GPUIn_C<int> __p_OfpUsAdBxTdMG5vXOydHoz, n18.Position_PeLDdeSku4ANhU5oe5SfPy __p_A8uNvEbAvEoMMWjP1xGMFm, n20.To_Qgkn15Kxt1HLURmAdSAN7m<n9.Vector4, n9.Vector3> __p_Od0Pg2RrY7oNrISfOh2y2M, n15.CullRayDefault_N3svfid7Nt6OfgkZE6IjlB __p_GUYjzQfpXAEQBBeFiMQyRJ, n15.SetupRayByCamera_RiQdApsbM5FLrA6NHCrBHt __p_DWMx9AKbKOtMBFOiy7L5e1, n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<n9.Vector2> __p_PfJiq9cUvz4MkDcAe6SkHe, n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<n16.Ray> __p_Bb9y5uOq3u2LQMxRJeFvyn, n14.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_O4uY4wtQ91uLJDMmFafbwj, n8.GpuValue<n9.Vector3> __slot_I4psfXoOuKuNwMB2K8N8sM, n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj, n5.Spread<n8.GpuValue<n16.Ray>> __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j, n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn, n5.Spread<n8.GpuValue<n9.Vector2>> __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D, n5.Spread<n8.AbstractGpuValue> __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe, n5.Spread<n8.IFunctionInvokeNode> __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx, n5.Spread<string> __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR, n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp)
            {
                __DhI6tZHu2mWLYPWSvcg9UF that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_FYCWb81ZCnKMk6ML8clwfp != this.__p_FYCWb81ZCnKMk6ML8clwfp || __p_OfpUsAdBxTdMG5vXOydHoz != this.__p_OfpUsAdBxTdMG5vXOydHoz || __p_A8uNvEbAvEoMMWjP1xGMFm != this.__p_A8uNvEbAvEoMMWjP1xGMFm || __p_Od0Pg2RrY7oNrISfOh2y2M != this.__p_Od0Pg2RrY7oNrISfOh2y2M || __p_GUYjzQfpXAEQBBeFiMQyRJ != this.__p_GUYjzQfpXAEQBBeFiMQyRJ || __p_DWMx9AKbKOtMBFOiy7L5e1 != this.__p_DWMx9AKbKOtMBFOiy7L5e1 || __p_PfJiq9cUvz4MkDcAe6SkHe != this.__p_PfJiq9cUvz4MkDcAe6SkHe || __p_Bb9y5uOq3u2LQMxRJeFvyn != this.__p_Bb9y5uOq3u2LQMxRJeFvyn || __p_O4uY4wtQ91uLJDMmFafbwj != this.__p_O4uY4wtQ91uLJDMmFafbwj || __slot_I4psfXoOuKuNwMB2K8N8sM != this.__slot_I4psfXoOuKuNwMB2K8N8sM || __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj != this.__pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj || __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j != this.__pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j || __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn != this.__pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn || __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D != this.__pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D || __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe != this.__pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe || __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx != this.__pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx || __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR != this.__pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR || __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp != this.__pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp ? new __DhI6tZHu2mWLYPWSvcg9UF(this)
                    {__p_FYCWb81ZCnKMk6ML8clwfp = __p_FYCWb81ZCnKMk6ML8clwfp, __p_OfpUsAdBxTdMG5vXOydHoz = __p_OfpUsAdBxTdMG5vXOydHoz, __p_A8uNvEbAvEoMMWjP1xGMFm = __p_A8uNvEbAvEoMMWjP1xGMFm, __p_Od0Pg2RrY7oNrISfOh2y2M = __p_Od0Pg2RrY7oNrISfOh2y2M, __p_GUYjzQfpXAEQBBeFiMQyRJ = __p_GUYjzQfpXAEQBBeFiMQyRJ, __p_DWMx9AKbKOtMBFOiy7L5e1 = __p_DWMx9AKbKOtMBFOiy7L5e1, __p_PfJiq9cUvz4MkDcAe6SkHe = __p_PfJiq9cUvz4MkDcAe6SkHe, __p_Bb9y5uOq3u2LQMxRJeFvyn = __p_Bb9y5uOq3u2LQMxRJeFvyn, __p_O4uY4wtQ91uLJDMmFafbwj = __p_O4uY4wtQ91uLJDMmFafbwj, __slot_I4psfXoOuKuNwMB2K8N8sM = __slot_I4psfXoOuKuNwMB2K8N8sM, __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj = __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj, __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j = __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j, __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn = __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn, __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D = __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D, __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe = __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe, __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx = __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx, __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR = __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR, __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp = __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp} : that_0;
                else
                {
                    this.__p_FYCWb81ZCnKMk6ML8clwfp = __p_FYCWb81ZCnKMk6ML8clwfp;
                    this.__p_OfpUsAdBxTdMG5vXOydHoz = __p_OfpUsAdBxTdMG5vXOydHoz;
                    this.__p_A8uNvEbAvEoMMWjP1xGMFm = __p_A8uNvEbAvEoMMWjP1xGMFm;
                    this.__p_Od0Pg2RrY7oNrISfOh2y2M = __p_Od0Pg2RrY7oNrISfOh2y2M;
                    this.__p_GUYjzQfpXAEQBBeFiMQyRJ = __p_GUYjzQfpXAEQBBeFiMQyRJ;
                    this.__p_DWMx9AKbKOtMBFOiy7L5e1 = __p_DWMx9AKbKOtMBFOiy7L5e1;
                    this.__p_PfJiq9cUvz4MkDcAe6SkHe = __p_PfJiq9cUvz4MkDcAe6SkHe;
                    this.__p_Bb9y5uOq3u2LQMxRJeFvyn = __p_Bb9y5uOq3u2LQMxRJeFvyn;
                    this.__p_O4uY4wtQ91uLJDMmFafbwj = __p_O4uY4wtQ91uLJDMmFafbwj;
                    this.__slot_I4psfXoOuKuNwMB2K8N8sM = __slot_I4psfXoOuKuNwMB2K8N8sM;
                    this.__pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj = __pin_group_Parameters_In_O4uY4wtQ91uLJDMmFafbwj;
                    this.__pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j = __pin_group_Input_In_LV6Sh9YgToyMC1G1TcqT3j;
                    this.__pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn = __pin_group_Parameters_In_Bb9y5uOq3u2LQMxRJeFvyn;
                    this.__pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D = __pin_group_Input_In_Qiph7qoufsOLM6TQXn1O7D;
                    this.__pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe = __pin_group_Parameters_In_PfJiq9cUvz4MkDcAe6SkHe;
                    this.__pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx = __pin_group_Input_In_VQDsEPuDI67M4nwKpNQKQx;
                    this.__pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR = __pin_group_Input_In_Jn9YZflB09FODVOX6bFvjR;
                    this.__pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp = __pin_group_Arguments_In_FYCWb81ZCnKMk6ML8clwfp;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 328718U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "CDnLTzrfqhNM1ECGG8anEg", Name = "ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg")]
    [n2.SerializableAttribute]
    public class ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n15.ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg Create(n1.NodeContext Node_Context)
        {
            var instance = new ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n15.ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg CreateDefault()
        {
            var instance = new ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n15.ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg Update(n8.GpuValue<n16.Ray> Ray_In, n8.GpuValue<n9.Vector4> Color_In, out n8.GpuValue<n9.Vector4> Output_Out)
        {
            string __pad_BXgzoTxxPzCOZ81NU3uGUs_0 = __slot_BXgzoTxxPzCOZ81NU3uGUs;
            string __pad_RXtDZo3E4meOcVH8kGs8O5_1 = __slot_RXtDZo3E4meOcVH8kGs8O5;
            bool Force_2 = false;
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_SYu6z7Z2oWNQZ9CNRDPMyT;
            if (manager_4 is null)
            {
                manager_4 = new n10.Manager<n2.ValueTuple<n8.GpuValue<n16.Ray>, n8.GpuValue<n9.Vector4>, string, string>, n2.ValueTuple<n8.GpuValue<n9.Vector4>>>(n2.ValueTuple.Create(default(n8.GpuValue<n9.Vector4>)));
            }

            var inputs_5 = (Ray_In, Color_In, __pad_BXgzoTxxPzCOZ81NU3uGUs_0, __pad_RXtDZo3E4meOcVH8kGs8O5_1);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = Force_2 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__Q3tGuLNXPkhLV6mHAR1vz6>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __Q3tGuLNXPkhLV6mHAR1vz6(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8 = n21._Operations_.CreateDefault<n8.GpuValue<n9.Vector4>>(), __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN = n21._Operations_.CreateDefault<n8.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "Uptq00k7N6eMln0E136hPN", 328741U);
                    var Output_10 = n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n9.Vector4>.Create(Node_Context: Node_Context_9);
                    state_8.__p_Uptq00k7N6eMln0E136hPN = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("RGYLe02tPXEQEO6aJ6Qsjm", "AePH0TVuKpqOZGzfsJAUWe", 328776U);
                    var Output_12 = n17.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB.Create(Node_Context: Node_Context_11);
                    state_8.__p_AePH0TVuKpqOZGzfsJAUWe = Output_12;
                }

                n9.Color4 __pad_OP9fl7UGjBQO7L1HtbvUHD_13 = __slot_OP9fl7UGjBQO7L1HtbvUHD;
                n39.ObjectHelpers.IsAssigned(x: Color_In, result: out bool Result_14, notAssigned: out bool Not_Assigned_15);
                int Index_16 = n2.Convert.ToInt32(Not_Assigned_15);
                var Output_19 = state_8.__p_AePH0TVuKpqOZGzfsJAUWe.Update(Input_In: __pad_OP9fl7UGjBQO7L1HtbvUHD_13, RGBA_Out: out n8.GpuValue<n9.Vector4> RGBA_17, RGB_Out: out n8.GpuValue<n9.Vector3> RGB_18);
                var builder_20 = n4.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8, 2);
                builder_20.Add(Color_In);
                builder_20.Add(RGBA_17);
                var __pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8_21 = builder_20.Commit();
                n7._Operations_.Switch<n8.GpuValue<n9.Vector4>, n6.__AdaptiveImplementations__RGYLe02tPXEQEO6aJ6Qsjm>(Index_In: Index_16, Input_In: __pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8_21, Output_Out: out n8.GpuValue<n9.Vector4> Output_22);
                n8.GpuValue<n9.Vector4> Default_23 = default(n8.GpuValue<n9.Vector4>);
                bool Is_Groupable_24 = false;
                n11.IEnumerable<n8.InputModifier> The_Modifiers_25 = n24._Operations_.CreateDefault<n8.InputModifier>();
                var builder_26 = n4.CollectionBuilders.GetBuilder(state_8.__pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN, 2);
                builder_26.Add(Ray_In);
                builder_26.Add(Output_22);
                var __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN_27 = builder_26.Commit();
                var State_Output_30 = state_8.__p_Uptq00k7N6eMln0E136hPN.Update(Arguments_In: __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN_27, Function_Name_In: __pad_BXgzoTxxPzCOZ81NU3uGUs_0, Default_In: Default_23, Mixins_In: __pad_RXtDZo3E4meOcVH8kGs8O5_1, Is_Groupable_In: Is_Groupable_24, The_Modifiers_In: The_Modifiers_25, Output_Out: out n8.GpuValue<n9.Vector4> Output_28, Additional_Outputs_Out: out n5.Spread<n8.AbstractGpuValue> Additional_Outputs_29);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = Output_19 != state_8.__p_AePH0TVuKpqOZGzfsJAUWe || __pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8_21 != state_8.__pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8 || __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN_27 != state_8.__pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN || State_Output_30 != state_8.__p_Uptq00k7N6eMln0E136hPN ? new __Q3tGuLNXPkhLV6mHAR1vz6(state_8)
                    {__p_AePH0TVuKpqOZGzfsJAUWe = Output_19, __pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8 = __pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8_21, __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN = __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN_27, __p_Uptq00k7N6eMln0E136hPN = State_Output_30} : state_8;
                else
                {
                    state_8.__p_AePH0TVuKpqOZGzfsJAUWe = Output_19;
                    state_8.__pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8 = __pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8_21;
                    state_8.__pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN = __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN_27;
                    state_8.__p_Uptq00k7N6eMln0E136hPN = State_Output_30;
                }

                outputs_6 = n2.ValueTuple.Create(Output_28);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_31 = outputs_6.Item1;
            Output_Out = __auto_31;
            n15.ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg that_32 = this;
            if (this.__GetContext__().IsImmutable)
                that_32 = manager_4 != this.__cache_SYu6z7Z2oWNQZ9CNRDPMyT ? new ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg(this)
                {__cache_SYu6z7Z2oWNQZ9CNRDPMyT = manager_4} : that_32;
            else
            {
                this.__cache_SYu6z7Z2oWNQZ9CNRDPMyT = manager_4;
            }

            return that_32;
        }

        public n15.ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg __Create__(n1.NodeContext Node_Context)
        {
            n29.RuntimeHelpers.EnsureSufficientExecutionStack();
            n15.ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg that_0 = this;
            this.__cache_SYu6z7Z2oWNQZ9CNRDPMyT = null;
            return that_0;
        }

        public n15.ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg __CreateDefault__()
        {
            n15.ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg that_0 = this;
            this.__cache_SYu6z7Z2oWNQZ9CNRDPMyT = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_SYu6z7Z2oWNQZ9CNRDPMyT);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 328789U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "BXgzoTxxPzCOZ81NU3uGUs", Name = "__slot_BXgzoTxxPzCOZ81NU3uGUs")]
        public static string __slot_BXgzoTxxPzCOZ81NU3uGUs = "shadeRayGradient";
        [n1.ElementAttribute(TracingId = 328792U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "RXtDZo3E4meOcVH8kGs8O5", Name = "__slot_RXtDZo3E4meOcVH8kGs8O5")]
        public static string __slot_RXtDZo3E4meOcVH8kGs8O5 = "FuseRayMarch";
        [n1.ElementAttribute(TracingId = 328721U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "SYu6z7Z2oWNQZ9CNRDPMyT", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n10.Manager<n2.ValueTuple<n8.GpuValue<n16.Ray>, n8.GpuValue<n9.Vector4>, string, string>, n2.ValueTuple<n8.GpuValue<n9.Vector4>>> __cache_SYu6z7Z2oWNQZ9CNRDPMyT = null;
        [n1.ElementAttribute(TracingId = 328772U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "OP9fl7UGjBQO7L1HtbvUHD", Name = "__slot_OP9fl7UGjBQO7L1HtbvUHD")]
        public static n9.Color4 __slot_OP9fl7UGjBQO7L1HtbvUHD = n1.CompilationHelper.Deserialize<n9.Color4>("1, 1, 1, 1", false, "RGYLe02tPXEQEO6aJ6Qsjm", "OP9fl7UGjBQO7L1HtbvUHD");
        static ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg()
        {
        }

        public ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg(ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg other): base(other)
        {
            this.__cache_SYu6z7Z2oWNQZ9CNRDPMyT = other.__cache_SYu6z7Z2oWNQZ9CNRDPMyT;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_SYu6z7Z2oWNQZ9CNRDPMyT", in __cache_SYu6z7Z2oWNQZ9CNRDPMyT));
        }

        internal ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg __WITH__(n10.Manager<n2.ValueTuple<n8.GpuValue<n16.Ray>, n8.GpuValue<n9.Vector4>, string, string>, n2.ValueTuple<n8.GpuValue<n9.Vector4>>> __cache_SYu6z7Z2oWNQZ9CNRDPMyT)
        {
            n15.ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_SYu6z7Z2oWNQZ9CNRDPMyT != this.__cache_SYu6z7Z2oWNQZ9CNRDPMyT ? new ShadeRayGradient_CDnLTzrfqhNM1ECGG8anEg(this)
                {__cache_SYu6z7Z2oWNQZ9CNRDPMyT = __cache_SYu6z7Z2oWNQZ9CNRDPMyT} : that_0;
            else
            {
                this.__cache_SYu6z7Z2oWNQZ9CNRDPMyT = __cache_SYu6z7Z2oWNQZ9CNRDPMyT;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Q3tGuLNXPkhLV6mHAR1vz6", Name = "__Q3tGuLNXPkhLV6mHAR1vz6")]
        [n2.SerializableAttribute]
        public class __Q3tGuLNXPkhLV6mHAR1vz6 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Uptq00k7N6eMln0E136hPN);
                n1.CompilationHelper.SafeDispose(this.__p_AePH0TVuKpqOZGzfsJAUWe);
                return;
            }

            [n1.ElementAttribute(TracingId = 328741U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "Uptq00k7N6eMln0E136hPN", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n9.Vector4> __p_Uptq00k7N6eMln0E136hPN;
            [n1.ElementAttribute(TracingId = 328776U, DocumentId = "RGYLe02tPXEQEO6aJ6Qsjm", PersistentId = "AePH0TVuKpqOZGzfsJAUWe", Name = "GPUIn (Color)", IsManaged = true, IsAutoGenerated = true)]
            public n17.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB __p_AePH0TVuKpqOZGzfsJAUWe;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.GpuValue<n9.Vector4>> __pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8 = default(n5.Spread<n8.GpuValue<n9.Vector4>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN = default(n5.Spread<n8.AbstractGpuValue>);
            public __Q3tGuLNXPkhLV6mHAR1vz6(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Q3tGuLNXPkhLV6mHAR1vz6(__Q3tGuLNXPkhLV6mHAR1vz6 other): base(other)
            {
                this.__p_Uptq00k7N6eMln0E136hPN = other.__p_Uptq00k7N6eMln0E136hPN;
                this.__p_AePH0TVuKpqOZGzfsJAUWe = other.__p_AePH0TVuKpqOZGzfsJAUWe;
                this.__pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8 = other.__pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8;
                this.__pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN = other.__pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Uptq00k7N6eMln0E136hPN", in __p_Uptq00k7N6eMln0E136hPN), n1.CompilationHelper.GetValueOrExisting(values, "__p_AePH0TVuKpqOZGzfsJAUWe", in __p_AePH0TVuKpqOZGzfsJAUWe), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8", in __pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN", in __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN));
            }

            internal __Q3tGuLNXPkhLV6mHAR1vz6 __WITH__(n12.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n9.Vector4> __p_Uptq00k7N6eMln0E136hPN, n17.GPUIn_Color_CvM0rgqyaZJNCZdtgWsdAB __p_AePH0TVuKpqOZGzfsJAUWe, n5.Spread<n8.GpuValue<n9.Vector4>> __pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8, n5.Spread<n8.AbstractGpuValue> __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN)
            {
                __Q3tGuLNXPkhLV6mHAR1vz6 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Uptq00k7N6eMln0E136hPN != this.__p_Uptq00k7N6eMln0E136hPN || __p_AePH0TVuKpqOZGzfsJAUWe != this.__p_AePH0TVuKpqOZGzfsJAUWe || __pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8 != this.__pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8 || __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN != this.__pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN ? new __Q3tGuLNXPkhLV6mHAR1vz6(this)
                    {__p_Uptq00k7N6eMln0E136hPN = __p_Uptq00k7N6eMln0E136hPN, __p_AePH0TVuKpqOZGzfsJAUWe = __p_AePH0TVuKpqOZGzfsJAUWe, __pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8 = __pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8, __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN = __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN} : that_0;
                else
                {
                    this.__p_Uptq00k7N6eMln0E136hPN = __p_Uptq00k7N6eMln0E136hPN;
                    this.__p_AePH0TVuKpqOZGzfsJAUWe = __p_AePH0TVuKpqOZGzfsJAUWe;
                    this.__pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8 = __pin_group_Input_In_IApWUxmeOTqNt9RhkNLEu8;
                    this.__pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN = __pin_group_Arguments_In_Uptq00k7N6eMln0E136hPN;
                }

                return that_0;
            }
        }
    }
}

namespace _Fuse_Raymarching_
{
    public struct __AdaptiveImplementations__RGYLe02tPXEQEO6aJ6Qsjm : n43.IAdaptiveCreateDefault<string>, n43.IAdaptiveCreateDefault<n8.GpuValue<n9.Vector2>>, n43.IAdaptiveCreateDefault<n8.GpuValue<n16.Ray>>, n43.IAdaptiveCreateDefault<n8.GpuValue<n9.Vector4>>
    {
        public void CreateDefault(out string Output_Out)
        {
            var Empty_0 = n41._Operations_.CreateDefault();
            Output_Out = Empty_0;
            return;
        }

        public void CreateDefault(out n8.GpuValue<n9.Vector2> Output_Out)
        {
            n42._Operations_.CreateDefault_Generic<n8.GpuValue<n9.Vector2>>(Output_Out: out n8.GpuValue<n9.Vector2> Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n8.GpuValue<n16.Ray> Output_Out)
        {
            n42._Operations_.CreateDefault_Generic<n8.GpuValue<n16.Ray>>(Output_Out: out n8.GpuValue<n16.Ray> Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n8.GpuValue<n9.Vector4> Output_Out)
        {
            n42._Operations_.CreateDefault_Generic<n8.GpuValue<n9.Vector4>>(Output_Out: out n8.GpuValue<n9.Vector4> Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}