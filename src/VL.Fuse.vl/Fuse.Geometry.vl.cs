extern alias e31;
extern alias e3;
extern alias e2;
extern alias e71;
extern alias e29;
extern alias e4;

using n13 = e2::VL.Lib.Collections;
using n7 = e3::VL.Lib.Primitive.CacheRegion;
using n27 = _CoreLibBasics_.Control;
using n15 = _VL_Collections_.Collections.Dictionary;
using n16 = global::System.Collections.Immutable;
using n6 = e71::Fuse;
using n19 = e31::VL.Stride.Shaders.ShaderFX;
using n28 = _Fuse_Core_Calculus_.Fuse.Core.Calculus.Differentiation;
using n20 = e71::Fuse.ShaderFX;
using n10 = _Fuse_Core_.Fuse.Core.Function;
using n8 = global::System.Collections.Generic;
using n32 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n29 = e71::Fuse.Core.Calculus;
using n26 = _Fuse_Core_Math_.Fuse.Core.Math;
using n30 = _Fuse_Geometry_;
using n24 = _Fuse_Core_.Fuse.Core.StrideIntegration;
using n1 = e2::VL.Core;
using n12 = _Fuse_Core_.Fuse.Core.Value;
using n2 = global::System;
using n5 = e4::Stride.Core.Mathematics;
using n3 = _Fuse_Geometry_.Fuse.Geometry;
using n25 = _Fuse_Core_Math_.Fuse.Core.Math.transform;
using n4 = e2::VL.Core.CompilerServices;
using n9 = _Fuse_Core_.Fuse.Core.Implementation;
using n22 = e29::Stride.Rendering;
using n17 = _VL_Collections_.Collections.Sequence;
using n23 = global::System.Runtime.CompilerServices;
using n18 = _Fuse_Core_.Fuse.Core.Conversion;
using n14 = _VL_Collections_.Collections.Spread;
using n11 = e71::Fuse.Geometry;
using n31 = _CoreLibBasics_.Primitive.Advanced;
using n21 = e29::Stride.Rendering.Materials;

namespace _Fuse_Geometry_.Fuse.Geometry
{
    [n1.ElementAttribute(TracingId = 315196U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "PaYvnM2MLijMZq3pPaW9ib", Name = "ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib")]
    [n2.SerializableAttribute]
    public class ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib Create(n1.NodeContext Node_Context)
        {
            var instance = new ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib CreateDefault()
        {
            var instance = new ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib Update(n22.Material Material_In, n6.GpuValue<n5.Vector3> Postion_In, n6.GpuValue<n5.Vector3> Normals_In, n6.GpuValue<n5.Vector2> UV_In, out n22.Material Output_Out)
        {
            bool __pad_BEjiniEXor9NSV0tRmw4GR_0 = __slot_BEjiniEXor9NSV0tRmw4GR;
            string __pad_Cd6NQlODEreMAVEMdXQTDW_1 = __slot_Cd6NQlODEreMAVEMdXQTDW;
            string __pad_RxKE73gbXYPPKMXrYPb6vh_2 = __slot_RxKE73gbXYPPKMXrYPb6vh;
            n1.CompilationHelper.WritePin(this.__p_KEWzUucFcCEP7zqXLOZWtx.Inputs[0], ref Material_In);
            bool Dispose_Cached_Outputs_3 = false;
            var manager_4 = this.__cache_OCH8wpgUUwYOmkFOLaTExI;
            if (manager_4 is null)
            {
                manager_4 = new n7.Manager<n2.ValueTuple<string, n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector2>, string>, n2.ValueTuple<n6.GpuValue<float>>>(n2.ValueTuple.Create(default(n6.GpuValue<float>)));
            }

            var inputs_5 = (__pad_Cd6NQlODEreMAVEMdXQTDW_1, Postion_In, Normals_In, UV_In, __pad_RxKE73gbXYPPKMXrYPb6vh_2);
            var outputs_6 = manager_4.Outputs;
            var Has_Changed_7 = __pad_BEjiniEXor9NSV0tRmw4GR_0 || manager_4.InputsChanged(inputs_5);
            if (Has_Changed_7)
            {
                if (Dispose_Cached_Outputs_3)
                    manager_4.DisposeOutputs();
                var state_8 = n1.CompilationHelper.Restore<__CeFBWrWo0LSMKImawF0ujR>(manager_4.State, __GetContext__());
                if (state_8 == null)
                {
                    state_8 = new __CeFBWrWo0LSMKImawF0ujR(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa = n14._Operations_.CreateDefault<string>(), __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O = n14._Operations_.CreateDefault<n6.AbstractGpuValue>(), __slot_FjxLwnVbvKLMPrUG9bDra2 = default(n6.GpuValue<n11.MeshSurface>), __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN = n14._Operations_.CreateDefault<n6.AbstractGpuValue>(), __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith = n14._Operations_.CreateDefault<n6.IFunctionInvokeNode>(), __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD = n14._Operations_.CreateDefault<string>(), __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR = n14._Operations_.CreateDefault<n6.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "BKNuWmrLKpbP6bf1lUjWjR", 315241U);
                    var Output_10 = n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n8.IEnumerable<n6.InputModifier>>.Create(Node_Context: Node_Context_9);
                    state_8.__p_BKNuWmrLKpbP6bf1lUjWjR = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "Qm9x03LXxICPJrHai362Ns", 315277U);
                    var Output_12 = n10.FunctionParameter__3_Parameters_UPscneAUAH9OIC6ocXJWdO<n5.Vector3, n5.Vector3, n5.Vector2>.Create(Node_Context: Node_Context_11);
                    state_8.__p_Qm9x03LXxICPJrHai362Ns = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "PCU9dkntvZxNrGBDrQEABN", 315332U);
                    var Output_14 = n10.Function_IubJYJ2Zy72PGqdBGy0rgZ<n11.MeshSurface>.Create(Node_Context: Node_Context_13);
                    state_8.__p_PCU9dkntvZxNrGBDrQEABN = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "FnJSIA5NdGxMJH313MW19O", 315341U);
                    var Output_16 = n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<n11.MeshSurface, n8.IEnumerable<n6.InputModifier>>.Create(Node_Context: Node_Context_15);
                    state_8.__p_FnJSIA5NdGxMJH313MW19O = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "QDg9Sly604wMEVyHHUOON8", 315390U);
                    var Output_18 = n10.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n5.Vector3>.Create(Node_Context: Node_Context_17);
                    state_8.__p_QDg9Sly604wMEVyHHUOON8 = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "CAW2q6ZE4PcQN9ZBFRk4ak", 315397U);
                    var Output_20 = n10.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n5.Vector3>.Create(Node_Context: Node_Context_19);
                    state_8.__p_CAW2q6ZE4PcQN9ZBFRk4ak = Output_20;
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "SeaGLL3rPCYNtWdK44hGva", 315403U);
                    var Output_22 = n10.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n5.Vector2>.Create(Node_Context: Node_Context_21);
                    state_8.__p_SeaGLL3rPCYNtWdK44hGva = Output_22;
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "EqEBeU32HDsPuaUYh7WhBF", 315409U);
                    var Output_24 = n12.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float>.Create(Node_Context: Node_Context_23);
                    state_8.__p_EqEBeU32HDsPuaUYh7WhBF = Output_24;
                }

                string __pad_K9fEytcaGmrMTps2HYBxPZ_25 = __slot_K9fEytcaGmrMTps2HYBxPZ;
                string __pad_ADKZbpQUfumOB1Pxykygma_26 = __slot_ADKZbpQUfumOB1Pxykygma;
                string __pad_Vgv1cTzyZuFQXgotXlBUX2_27 = __slot_Vgv1cTzyZuFQXgotXlBUX2;
                float __pad_Noe05gl6pkpOQilxQ9WpoS_28 = __slot_Noe05gl6pkpOQilxQ9WpoS;
                string __pad_Hz6y4SeEyhDMpBNYKmjLEn_29 = __slot_Hz6y4SeEyhDMpBNYKmjLEn;
                string __pad_LpUlF6Cgl6HNoIPHbfH3m1_30 = __slot_LpUlF6Cgl6HNoIPHbfH3m1;
                var Output_32 = state_8.__p_EqEBeU32HDsPuaUYh7WhBF.Update(Value_In: __pad_Noe05gl6pkpOQilxQ9WpoS_28, GpuValue_Out: out n6.GpuValue<float> GpuValue_31);
                int Id_33 = 0;
                var State_Output_35 = state_8.__p_QDg9Sly604wMEVyHHUOON8.Update(The_Override_In: Postion_In, Id_In: Id_33, Output_Out: out n6.GpuValue<n5.Vector3> Output_34);
                int Id_36 = 0;
                var State_Output_38 = state_8.__p_CAW2q6ZE4PcQN9ZBFRk4ak.Update(The_Override_In: Normals_In, Id_In: Id_36, Output_Out: out n6.GpuValue<n5.Vector3> Output_37);
                int Id_39 = 0;
                var State_Output_41 = state_8.__p_SeaGLL3rPCYNtWdK44hGva.Update(The_Override_In: UV_In, Id_In: Id_39, Output_Out: out n6.GpuValue<n5.Vector2> Output_40);
                var builder_42 = n4.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa, 1);
                builder_42.Add(__pad_Hz6y4SeEyhDMpBNYKmjLEn_29);
                var __pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa_43 = builder_42.Commit();
                n14._Operations_.Cons<string>(Input_In: __pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa_43, Result_Out: out n13.Spread<string> Result_44);
                n8.IEnumerable<string> Mixins_45 = (n8.IEnumerable<string>)Result_44;
                n6.GpuValue<n11.MeshSurface> Default_Result_46 = default(n6.GpuValue<n11.MeshSurface>);
                n13.Spread<n6.IFunctionInvokeNode> Functions_47 = n14._Operations_.CreateDefault<n6.IFunctionInvokeNode>();
                n16.ImmutableDictionary<string, string> Template_Values_48 = n15._Operations_.CreateDefault<string, string>();
                bool Is_Groupable_49 = false;
                n8.IEnumerable<n6.InputModifier> The_Modifiers_50 = n17._Operations_.CreateDefault<n6.InputModifier>();
                var builder_51 = n4.CollectionBuilders.GetBuilder(state_8.__pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O, 3);
                builder_51.Add(Output_34);
                builder_51.Add(Output_37);
                builder_51.Add(Output_40);
                var __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O_52 = builder_51.Commit();
                var State_Output_55 = state_8.__p_FnJSIA5NdGxMJH313MW19O.Update(Arguments_In: __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O_52, Function_Name_In: __pad_LpUlF6Cgl6HNoIPHbfH3m1_30, Code_Template_In: __pad_RxKE73gbXYPPKMXrYPb6vh_2, Default_Result_In: Default_Result_46, Functions_In: Functions_47, Mixins_In: Mixins_45, Template_Values_In: Template_Values_48, Is_Groupable_In: Is_Groupable_49, The_Modifiers_In: The_Modifiers_50, Output_Out: out n6.GpuValue<n11.MeshSurface> Output_53, AdditionalOutputs_Out: out n13.Spread<n6.AbstractGpuValue> AdditionalOutputs_54);
                n6.GpuValue<n11.MeshSurface> __pad_FjxLwnVbvKLMPrUG9bDra2_56 = Output_53;
                n6.GpuValue<n5.Vector3> Input_57 = default(n6.GpuValue<n5.Vector3>);
                n18._Operations_.TypeVector3(Input_In: Input_57, Output_Out: out n6.GpuValue<n5.Vector3> Output_58);
                n6.GpuValue<n5.Vector3> Input_59 = default(n6.GpuValue<n5.Vector3>);
                n18._Operations_.TypeVector3(Input_In: Input_59, Output_Out: out n6.GpuValue<n5.Vector3> Output_60);
                n6.GpuValue<n5.Vector2> Input_61 = default(n6.GpuValue<n5.Vector2>);
                n18._Operations_.TypeVector2(Input_In: Input_61, Output_Out: out n6.GpuValue<n5.Vector2> Output_62);
                var State_Output_66 = state_8.__p_Qm9x03LXxICPJrHai362Ns.Update(Input_In: Output_58, Input2_In: Output_60, Input3_In: Output_62, Output_Out: out n6.GpuValue<n5.Vector3> Output_63, Output2_Out: out n6.GpuValue<n5.Vector3> Output2_64, Output3_Out: out n6.GpuValue<n5.Vector2> Output3_65);
                var builder_67 = n4.CollectionBuilders.GetBuilder(state_8.__pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN, 3);
                builder_67.Add(Output_63);
                builder_67.Add(Output2_64);
                builder_67.Add(Output3_65);
                var __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN_68 = builder_67.Commit();
                var State_Output_70 = state_8.__p_PCU9dkntvZxNrGBDrQEABN.Update(Function_In: __pad_FjxLwnVbvKLMPrUG9bDra2_56, Parameters_In: __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN_68, Id_In: __pad_Vgv1cTzyZuFQXgotXlBUX2_27, Output_Out: out n6.FunctionInvokeNode<n11.MeshSurface> Output_69);
                n6.IFunctionInvokeNode Input_71 = (n6.IFunctionInvokeNode)Output_69;
                var builder_72 = n4.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith, 1);
                builder_72.Add(Input_71);
                var __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith_73 = builder_72.Commit();
                n14._Operations_.Cons<n6.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith_73, Result_Out: out n13.Spread<n6.IFunctionInvokeNode> Result_74);
                var builder_75 = n4.CollectionBuilders.GetBuilder(state_8.__pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD, 1);
                builder_75.Add(__pad_ADKZbpQUfumOB1Pxykygma_26);
                var __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD_76 = builder_75.Commit();
                n14._Operations_.Cons<string>(Input_In: __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD_76, Result_Out: out n13.Spread<string> Result_77);
                n8.IEnumerable<string> Mixins_78 = (n8.IEnumerable<string>)Result_77;
                n6.GpuValue<float> Default_Result_79 = default(n6.GpuValue<float>);
                n16.ImmutableDictionary<string, string> Template_Values_80 = n15._Operations_.CreateDefault<string, string>();
                bool Is_Groupable_81 = false;
                n8.IEnumerable<n6.InputModifier> The_Modifiers_82 = n17._Operations_.CreateDefault<n6.InputModifier>();
                var builder_83 = n4.CollectionBuilders.GetBuilder(state_8.__pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR, 1);
                builder_83.Add(GpuValue_31);
                var __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR_84 = builder_83.Commit();
                var State_Output_87 = state_8.__p_BKNuWmrLKpbP6bf1lUjWjR.Update(Arguments_In: __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR_84, Function_Name_In: __pad_K9fEytcaGmrMTps2HYBxPZ_25, Code_Template_In: __pad_Cd6NQlODEreMAVEMdXQTDW_1, Default_Result_In: Default_Result_79, Functions_In: Result_74, Mixins_In: Mixins_78, Template_Values_In: Template_Values_80, Is_Groupable_In: Is_Groupable_81, The_Modifiers_In: The_Modifiers_82, Output_Out: out n6.GpuValue<float> Output_85, AdditionalOutputs_Out: out n13.Spread<n6.AbstractGpuValue> AdditionalOutputs_86);
                n18._Operations_.TypeFloat(Input_In: Output_85, Output_Out: out n6.GpuValue<float> Output_88);
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = Output_32 != state_8.__p_EqEBeU32HDsPuaUYh7WhBF || State_Output_35 != state_8.__p_QDg9Sly604wMEVyHHUOON8 || State_Output_38 != state_8.__p_CAW2q6ZE4PcQN9ZBFRk4ak || State_Output_41 != state_8.__p_SeaGLL3rPCYNtWdK44hGva || __pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa_43 != state_8.__pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa || __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O_52 != state_8.__pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O || State_Output_55 != state_8.__p_FnJSIA5NdGxMJH313MW19O || Output_53 != state_8.__slot_FjxLwnVbvKLMPrUG9bDra2 || State_Output_66 != state_8.__p_Qm9x03LXxICPJrHai362Ns || __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN_68 != state_8.__pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN || State_Output_70 != state_8.__p_PCU9dkntvZxNrGBDrQEABN || __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith_73 != state_8.__pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith || __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD_76 != state_8.__pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD || __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR_84 != state_8.__pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR || State_Output_87 != state_8.__p_BKNuWmrLKpbP6bf1lUjWjR ? new __CeFBWrWo0LSMKImawF0ujR(state_8)
                    {__p_EqEBeU32HDsPuaUYh7WhBF = Output_32, __p_QDg9Sly604wMEVyHHUOON8 = State_Output_35, __p_CAW2q6ZE4PcQN9ZBFRk4ak = State_Output_38, __p_SeaGLL3rPCYNtWdK44hGva = State_Output_41, __pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa = __pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa_43, __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O = __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O_52, __p_FnJSIA5NdGxMJH313MW19O = State_Output_55, __slot_FjxLwnVbvKLMPrUG9bDra2 = Output_53, __p_Qm9x03LXxICPJrHai362Ns = State_Output_66, __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN = __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN_68, __p_PCU9dkntvZxNrGBDrQEABN = State_Output_70, __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith = __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith_73, __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD = __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD_76, __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR = __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR_84, __p_BKNuWmrLKpbP6bf1lUjWjR = State_Output_87} : state_8;
                else
                {
                    state_8.__p_EqEBeU32HDsPuaUYh7WhBF = Output_32;
                    state_8.__p_QDg9Sly604wMEVyHHUOON8 = State_Output_35;
                    state_8.__p_CAW2q6ZE4PcQN9ZBFRk4ak = State_Output_38;
                    state_8.__p_SeaGLL3rPCYNtWdK44hGva = State_Output_41;
                    state_8.__pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa = __pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa_43;
                    state_8.__pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O = __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O_52;
                    state_8.__p_FnJSIA5NdGxMJH313MW19O = State_Output_55;
                    state_8.__slot_FjxLwnVbvKLMPrUG9bDra2 = Output_53;
                    state_8.__p_Qm9x03LXxICPJrHai362Ns = State_Output_66;
                    state_8.__pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN = __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN_68;
                    state_8.__p_PCU9dkntvZxNrGBDrQEABN = State_Output_70;
                    state_8.__pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith = __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith_73;
                    state_8.__pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD = __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD_76;
                    state_8.__pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR = __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR_84;
                    state_8.__p_BKNuWmrLKpbP6bf1lUjWjR = State_Output_87;
                }

                outputs_6 = n2.ValueTuple.Create(Output_88);
                manager_4 = manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3, state_8, outputs_6);
            }
            else
            {
                manager_4.Update(inputs_5, __GetContext__().IsImmutable, Dispose_Cached_Outputs_3);
            }

            var __auto_89 = outputs_6.Item1;
            var State_Output_93 = this.__p_KQ5Ux08n2IwOWjtswkl2sV.Update(GpuValue_In: __auto_89, Output_Out: out n19.SetVar<float> Output_90, Original_Shader_Source_Out: out n20.ToShaderFX<float> Original_Shader_Source_91, Shader_Code_Out: out string Shader_Code_92);
            n21.IComputeNode Surface_94 = (n21.IComputeNode)Original_Shader_Source_91;
            n1.CompilationHelper.WritePin(this.__p_NHTNI3Kzu9dQTHKZ4xSyeO.Inputs[0], ref Surface_94);
            n1.CompilationHelper.ReadPin(this.__p_NHTNI3Kzu9dQTHKZ4xSyeO.Outputs[0], out n21.IComputeNode out_95);
            n1.CompilationHelper.WritePin(this.__p_KEWzUucFcCEP7zqXLOZWtx.Inputs[1], ref out_95);
            n1.CompilationHelper.ReadPin(this.__p_KEWzUucFcCEP7zqXLOZWtx.Outputs[0], out n22.Material out_96);
            Output_Out = out_96;
            n3.ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib that_97 = this;
            if (this.__GetContext__().IsImmutable)
                that_97 = this.__p_KEWzUucFcCEP7zqXLOZWtx != this.__p_KEWzUucFcCEP7zqXLOZWtx || manager_4 != this.__cache_OCH8wpgUUwYOmkFOLaTExI || State_Output_93 != this.__p_KQ5Ux08n2IwOWjtswkl2sV || this.__p_NHTNI3Kzu9dQTHKZ4xSyeO != this.__p_NHTNI3Kzu9dQTHKZ4xSyeO ? new ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib(this)
                {__p_KEWzUucFcCEP7zqXLOZWtx = this.__p_KEWzUucFcCEP7zqXLOZWtx, __cache_OCH8wpgUUwYOmkFOLaTExI = manager_4, __p_KQ5Ux08n2IwOWjtswkl2sV = State_Output_93, __p_NHTNI3Kzu9dQTHKZ4xSyeO = this.__p_NHTNI3Kzu9dQTHKZ4xSyeO} : that_97;
            else
            {
                this.__p_KEWzUucFcCEP7zqXLOZWtx = this.__p_KEWzUucFcCEP7zqXLOZWtx;
                this.__cache_OCH8wpgUUwYOmkFOLaTExI = manager_4;
                this.__p_KQ5Ux08n2IwOWjtswkl2sV = State_Output_93;
                this.__p_NHTNI3Kzu9dQTHKZ4xSyeO = this.__p_NHTNI3Kzu9dQTHKZ4xSyeO;
            }

            return that_97;
        }

        public n3.ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib __Create__(n1.NodeContext Node_Context)
        {
            n23.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "KQ5Ux08n2IwOWjtswkl2sV", 315432U);
            var Output_1 = n24.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float>.Create(Node_Context: Node_Context_0);
            var node_2 = n1.CompilationHelper.CreateNodeById(Node_Context, "FuseGeometryMeshSurfaceVSExtension", "Stride.Rendering.Experimental.ShaderFX");
            var node_3 = n1.CompilationHelper.CreateNodeById(Node_Context, "MaterialExtension", "Stride.Advanced.Materials");
            n3.ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib that_4 = this;
            this.__p_KQ5Ux08n2IwOWjtswkl2sV = Output_1;
            this.__p_NHTNI3Kzu9dQTHKZ4xSyeO = node_2;
            this.__p_KEWzUucFcCEP7zqXLOZWtx = node_3;
            this.__cache_OCH8wpgUUwYOmkFOLaTExI = null;
            return that_4;
        }

        public n3.ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib __CreateDefault__()
        {
            n3.ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib that_0 = this;
            this.__p_KEWzUucFcCEP7zqXLOZWtx = default(n1.IVLNode);
            this.__cache_OCH8wpgUUwYOmkFOLaTExI = null;
            this.__p_KQ5Ux08n2IwOWjtswkl2sV = n24.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float>.CreateDefault();
            this.__p_NHTNI3Kzu9dQTHKZ4xSyeO = default(n1.IVLNode);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_KEWzUucFcCEP7zqXLOZWtx);
            n1.CompilationHelper.SafeDispose(this.__cache_OCH8wpgUUwYOmkFOLaTExI);
            n1.CompilationHelper.SafeDispose(this.__p_KQ5Ux08n2IwOWjtswkl2sV);
            n1.CompilationHelper.SafeDispose(this.__p_NHTNI3Kzu9dQTHKZ4xSyeO);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 315419U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "BEjiniEXor9NSV0tRmw4GR", Name = "__slot_BEjiniEXor9NSV0tRmw4GR")]
        public static bool __slot_BEjiniEXor9NSV0tRmw4GR = false;
        [n1.ElementAttribute(TracingId = 315424U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "Cd6NQlODEreMAVEMdXQTDW", Name = "__slot_Cd6NQlODEreMAVEMdXQTDW")]
        public static string __slot_Cd6NQlODEreMAVEMdXQTDW = "// just passthrough\r\nfloat ${signature} (float myValue)\r\n{\r\n    return myValue;\r\n}\r\n\r\noverride MeshSurface makeSurface(float3 p, float3 n, float2 uv)\r\n{   \r\n    return ${SURFACEFUNCTION}(p, n, uv);\r\n}";
        [n1.ElementAttribute(TracingId = 315427U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "RxKE73gbXYPPKMXrYPb6vh", Name = "__slot_RxKE73gbXYPPKMXrYPb6vh")]
        public static string __slot_RxKE73gbXYPPKMXrYPb6vh = "MeshSurface ${signature}(float3 p, float3 n, float2 uv)\r\n{\r\n        MeshSurface surface;\r\n        surface.p = p;\r\n        surface.n = n;\r\n        surface.uv = uv;\r\n        return surface;\r\n}";
        [n1.ElementAttribute(TracingId = 315451U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "KEWzUucFcCEP7zqXLOZWtx", Name = "MaterialExtension", IsManaged = true, IsAutoGenerated = true, NodeName = "MaterialExtension", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_KEWzUucFcCEP7zqXLOZWtx;
        [n1.ElementAttribute(TracingId = 315200U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "OCH8wpgUUwYOmkFOLaTExI", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<string, n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector2>, string>, n2.ValueTuple<n6.GpuValue<float>>> __cache_OCH8wpgUUwYOmkFOLaTExI = null;
        [n1.ElementAttribute(TracingId = 315267U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "K9fEytcaGmrMTps2HYBxPZ", Name = "__slot_K9fEytcaGmrMTps2HYBxPZ")]
        public static string __slot_K9fEytcaGmrMTps2HYBxPZ = "ModifyMesh";
        [n1.ElementAttribute(TracingId = 315273U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "ADKZbpQUfumOB1Pxykygma", Name = "__slot_ADKZbpQUfumOB1Pxykygma")]
        public static string __slot_ADKZbpQUfumOB1Pxykygma = "FuseGeometryMeshSurface";
        [n1.ElementAttribute(TracingId = 315339U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "Vgv1cTzyZuFQXgotXlBUX2", Name = "__slot_Vgv1cTzyZuFQXgotXlBUX2")]
        public static string __slot_Vgv1cTzyZuFQXgotXlBUX2 = "SURFACEFUNCTION";
        [n1.ElementAttribute(TracingId = 315414U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "Noe05gl6pkpOQilxQ9WpoS", Name = "__slot_Noe05gl6pkpOQilxQ9WpoS")]
        public static float __slot_Noe05gl6pkpOQilxQ9WpoS = 0F;
        [n1.ElementAttribute(TracingId = 315377U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "Hz6y4SeEyhDMpBNYKmjLEn", Name = "__slot_Hz6y4SeEyhDMpBNYKmjLEn")]
        public static string __slot_Hz6y4SeEyhDMpBNYKmjLEn = "FuseGeometryMeshSurface";
        [n1.ElementAttribute(TracingId = 315381U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "LpUlF6Cgl6HNoIPHbfH3m1", Name = "__slot_LpUlF6Cgl6HNoIPHbfH3m1")]
        public static string __slot_LpUlF6Cgl6HNoIPHbfH3m1 = "SurfaceModify";
        [n1.ElementAttribute(TracingId = 315432U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "KQ5Ux08n2IwOWjtswkl2sV", Name = "ToShaderFX", IsManaged = true, IsAutoGenerated = true)]
        public n24.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_KQ5Ux08n2IwOWjtswkl2sV;
        [n1.ElementAttribute(TracingId = 315442U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "NHTNI3Kzu9dQTHKZ4xSyeO", Name = "FuseGeometryMeshSurfaceVSExtension", IsManaged = true, IsAutoGenerated = true, NodeName = "FuseGeometryMeshSurfaceVSExtension", NodeCategory = "Stride.Rendering.Experimental.ShaderFX")]
        public n1.IVLNode __p_NHTNI3Kzu9dQTHKZ4xSyeO;
        static ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib()
        {
        }

        public ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib(ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib other): base(other)
        {
            this.__p_KEWzUucFcCEP7zqXLOZWtx = other.__p_KEWzUucFcCEP7zqXLOZWtx;
            this.__cache_OCH8wpgUUwYOmkFOLaTExI = other.__cache_OCH8wpgUUwYOmkFOLaTExI;
            this.__p_KQ5Ux08n2IwOWjtswkl2sV = other.__p_KQ5Ux08n2IwOWjtswkl2sV;
            this.__p_NHTNI3Kzu9dQTHKZ4xSyeO = other.__p_NHTNI3Kzu9dQTHKZ4xSyeO;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_KEWzUucFcCEP7zqXLOZWtx", in __p_KEWzUucFcCEP7zqXLOZWtx), n1.CompilationHelper.GetValueOrExisting(values, "__cache_OCH8wpgUUwYOmkFOLaTExI", in __cache_OCH8wpgUUwYOmkFOLaTExI), n1.CompilationHelper.GetValueOrExisting(values, "__p_KQ5Ux08n2IwOWjtswkl2sV", in __p_KQ5Ux08n2IwOWjtswkl2sV), n1.CompilationHelper.GetValueOrExisting(values, "__p_NHTNI3Kzu9dQTHKZ4xSyeO", in __p_NHTNI3Kzu9dQTHKZ4xSyeO));
        }

        internal ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib __WITH__(n1.IVLNode __p_KEWzUucFcCEP7zqXLOZWtx, n7.Manager<n2.ValueTuple<string, n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector2>, string>, n2.ValueTuple<n6.GpuValue<float>>> __cache_OCH8wpgUUwYOmkFOLaTExI, n24.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_KQ5Ux08n2IwOWjtswkl2sV, n1.IVLNode __p_NHTNI3Kzu9dQTHKZ4xSyeO)
        {
            n3.ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_KEWzUucFcCEP7zqXLOZWtx != this.__p_KEWzUucFcCEP7zqXLOZWtx || __cache_OCH8wpgUUwYOmkFOLaTExI != this.__cache_OCH8wpgUUwYOmkFOLaTExI || __p_KQ5Ux08n2IwOWjtswkl2sV != this.__p_KQ5Ux08n2IwOWjtswkl2sV || __p_NHTNI3Kzu9dQTHKZ4xSyeO != this.__p_NHTNI3Kzu9dQTHKZ4xSyeO ? new ModifyMeshSurface_Material_PaYvnM2MLijMZq3pPaW9ib(this)
                {__p_KEWzUucFcCEP7zqXLOZWtx = __p_KEWzUucFcCEP7zqXLOZWtx, __cache_OCH8wpgUUwYOmkFOLaTExI = __cache_OCH8wpgUUwYOmkFOLaTExI, __p_KQ5Ux08n2IwOWjtswkl2sV = __p_KQ5Ux08n2IwOWjtswkl2sV, __p_NHTNI3Kzu9dQTHKZ4xSyeO = __p_NHTNI3Kzu9dQTHKZ4xSyeO} : that_0;
            else
            {
                this.__p_KEWzUucFcCEP7zqXLOZWtx = __p_KEWzUucFcCEP7zqXLOZWtx;
                this.__cache_OCH8wpgUUwYOmkFOLaTExI = __cache_OCH8wpgUUwYOmkFOLaTExI;
                this.__p_KQ5Ux08n2IwOWjtswkl2sV = __p_KQ5Ux08n2IwOWjtswkl2sV;
                this.__p_NHTNI3Kzu9dQTHKZ4xSyeO = __p_NHTNI3Kzu9dQTHKZ4xSyeO;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "CeFBWrWo0LSMKImawF0ujR", Name = "__CeFBWrWo0LSMKImawF0ujR")]
        [n2.SerializableAttribute]
        public class __CeFBWrWo0LSMKImawF0ujR : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_BKNuWmrLKpbP6bf1lUjWjR);
                n1.CompilationHelper.SafeDispose(this.__p_Qm9x03LXxICPJrHai362Ns);
                n1.CompilationHelper.SafeDispose(this.__p_PCU9dkntvZxNrGBDrQEABN);
                n1.CompilationHelper.SafeDispose(this.__p_FnJSIA5NdGxMJH313MW19O);
                n1.CompilationHelper.SafeDispose(this.__p_QDg9Sly604wMEVyHHUOON8);
                n1.CompilationHelper.SafeDispose(this.__p_CAW2q6ZE4PcQN9ZBFRk4ak);
                n1.CompilationHelper.SafeDispose(this.__p_SeaGLL3rPCYNtWdK44hGva);
                n1.CompilationHelper.SafeDispose(this.__p_EqEBeU32HDsPuaUYh7WhBF);
                return;
            }

            [n1.ElementAttribute(TracingId = 315241U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "BKNuWmrLKpbP6bf1lUjWjR", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n8.IEnumerable<n6.InputModifier>> __p_BKNuWmrLKpbP6bf1lUjWjR;
            [n1.ElementAttribute(TracingId = 315277U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "Qm9x03LXxICPJrHai362Ns", Name = "FunctionParameter (3 Parameters)", IsManaged = true, IsAutoGenerated = true)]
            public n10.FunctionParameter__3_Parameters_UPscneAUAH9OIC6ocXJWdO<n5.Vector3, n5.Vector3, n5.Vector2> __p_Qm9x03LXxICPJrHai362Ns;
            [n1.ElementAttribute(TracingId = 315332U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "PCU9dkntvZxNrGBDrQEABN", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n10.Function_IubJYJ2Zy72PGqdBGy0rgZ<n11.MeshSurface> __p_PCU9dkntvZxNrGBDrQEABN;
            [n1.ElementAttribute(TracingId = 315341U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "FnJSIA5NdGxMJH313MW19O", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<n11.MeshSurface, n8.IEnumerable<n6.InputModifier>> __p_FnJSIA5NdGxMJH313MW19O;
            [n1.ElementAttribute(TracingId = 315390U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "QDg9Sly604wMEVyHHUOON8", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n10.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n5.Vector3> __p_QDg9Sly604wMEVyHHUOON8;
            [n1.ElementAttribute(TracingId = 315397U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "CAW2q6ZE4PcQN9ZBFRk4ak", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n10.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n5.Vector3> __p_CAW2q6ZE4PcQN9ZBFRk4ak;
            [n1.ElementAttribute(TracingId = 315403U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "SeaGLL3rPCYNtWdK44hGva", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n10.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n5.Vector2> __p_SeaGLL3rPCYNtWdK44hGva;
            [n1.ElementAttribute(TracingId = 315409U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "EqEBeU32HDsPuaUYh7WhBF", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n12.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_EqEBeU32HDsPuaUYh7WhBF;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<string> __pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa = default(n13.Spread<string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O = default(n13.Spread<n6.AbstractGpuValue>);
            [n1.ElementAttribute(TracingId = 315379U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "FjxLwnVbvKLMPrUG9bDra2", Name = "__slot_FjxLwnVbvKLMPrUG9bDra2")]
            public n6.GpuValue<n11.MeshSurface> __slot_FjxLwnVbvKLMPrUG9bDra2;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN = default(n13.Spread<n6.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.IFunctionInvokeNode> __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith = default(n13.Spread<n6.IFunctionInvokeNode>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<string> __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD = default(n13.Spread<string>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR = default(n13.Spread<n6.AbstractGpuValue>);
            public __CeFBWrWo0LSMKImawF0ujR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CeFBWrWo0LSMKImawF0ujR(__CeFBWrWo0LSMKImawF0ujR other): base(other)
            {
                this.__p_BKNuWmrLKpbP6bf1lUjWjR = other.__p_BKNuWmrLKpbP6bf1lUjWjR;
                this.__p_Qm9x03LXxICPJrHai362Ns = other.__p_Qm9x03LXxICPJrHai362Ns;
                this.__p_PCU9dkntvZxNrGBDrQEABN = other.__p_PCU9dkntvZxNrGBDrQEABN;
                this.__p_FnJSIA5NdGxMJH313MW19O = other.__p_FnJSIA5NdGxMJH313MW19O;
                this.__p_QDg9Sly604wMEVyHHUOON8 = other.__p_QDg9Sly604wMEVyHHUOON8;
                this.__p_CAW2q6ZE4PcQN9ZBFRk4ak = other.__p_CAW2q6ZE4PcQN9ZBFRk4ak;
                this.__p_SeaGLL3rPCYNtWdK44hGva = other.__p_SeaGLL3rPCYNtWdK44hGva;
                this.__p_EqEBeU32HDsPuaUYh7WhBF = other.__p_EqEBeU32HDsPuaUYh7WhBF;
                this.__pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa = other.__pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa;
                this.__pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O = other.__pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O;
                this.__slot_FjxLwnVbvKLMPrUG9bDra2 = other.__slot_FjxLwnVbvKLMPrUG9bDra2;
                this.__pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN = other.__pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN;
                this.__pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith = other.__pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith;
                this.__pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD = other.__pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD;
                this.__pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR = other.__pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BKNuWmrLKpbP6bf1lUjWjR", in __p_BKNuWmrLKpbP6bf1lUjWjR), n1.CompilationHelper.GetValueOrExisting(values, "__p_Qm9x03LXxICPJrHai362Ns", in __p_Qm9x03LXxICPJrHai362Ns), n1.CompilationHelper.GetValueOrExisting(values, "__p_PCU9dkntvZxNrGBDrQEABN", in __p_PCU9dkntvZxNrGBDrQEABN), n1.CompilationHelper.GetValueOrExisting(values, "__p_FnJSIA5NdGxMJH313MW19O", in __p_FnJSIA5NdGxMJH313MW19O), n1.CompilationHelper.GetValueOrExisting(values, "__p_QDg9Sly604wMEVyHHUOON8", in __p_QDg9Sly604wMEVyHHUOON8), n1.CompilationHelper.GetValueOrExisting(values, "__p_CAW2q6ZE4PcQN9ZBFRk4ak", in __p_CAW2q6ZE4PcQN9ZBFRk4ak), n1.CompilationHelper.GetValueOrExisting(values, "__p_SeaGLL3rPCYNtWdK44hGva", in __p_SeaGLL3rPCYNtWdK44hGva), n1.CompilationHelper.GetValueOrExisting(values, "__p_EqEBeU32HDsPuaUYh7WhBF", in __p_EqEBeU32HDsPuaUYh7WhBF), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa", in __pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O", in __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O), n1.CompilationHelper.GetValueOrExisting(values, "__slot_FjxLwnVbvKLMPrUG9bDra2", in __slot_FjxLwnVbvKLMPrUG9bDra2), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN", in __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith", in __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD", in __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR", in __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR));
            }

            internal __CeFBWrWo0LSMKImawF0ujR __WITH__(n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<float, n8.IEnumerable<n6.InputModifier>> __p_BKNuWmrLKpbP6bf1lUjWjR, n10.FunctionParameter__3_Parameters_UPscneAUAH9OIC6ocXJWdO<n5.Vector3, n5.Vector3, n5.Vector2> __p_Qm9x03LXxICPJrHai362Ns, n10.Function_IubJYJ2Zy72PGqdBGy0rgZ<n11.MeshSurface> __p_PCU9dkntvZxNrGBDrQEABN, n9.CustomFunction_SbJY8E2PFscPAropl3Jh79<n11.MeshSurface, n8.IEnumerable<n6.InputModifier>> __p_FnJSIA5NdGxMJH313MW19O, n10.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n5.Vector3> __p_QDg9Sly604wMEVyHHUOON8, n10.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n5.Vector3> __p_CAW2q6ZE4PcQN9ZBFRk4ak, n10.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<n5.Vector2> __p_SeaGLL3rPCYNtWdK44hGva, n12.Constant_C05sp6Ijg7TN6Mfl7g0LqX<float> __p_EqEBeU32HDsPuaUYh7WhBF, n13.Spread<string> __pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa, n13.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O, n6.GpuValue<n11.MeshSurface> __slot_FjxLwnVbvKLMPrUG9bDra2, n13.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN, n13.Spread<n6.IFunctionInvokeNode> __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith, n13.Spread<string> __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD, n13.Spread<n6.AbstractGpuValue> __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR)
            {
                __CeFBWrWo0LSMKImawF0ujR that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_BKNuWmrLKpbP6bf1lUjWjR != this.__p_BKNuWmrLKpbP6bf1lUjWjR || __p_Qm9x03LXxICPJrHai362Ns != this.__p_Qm9x03LXxICPJrHai362Ns || __p_PCU9dkntvZxNrGBDrQEABN != this.__p_PCU9dkntvZxNrGBDrQEABN || __p_FnJSIA5NdGxMJH313MW19O != this.__p_FnJSIA5NdGxMJH313MW19O || __p_QDg9Sly604wMEVyHHUOON8 != this.__p_QDg9Sly604wMEVyHHUOON8 || __p_CAW2q6ZE4PcQN9ZBFRk4ak != this.__p_CAW2q6ZE4PcQN9ZBFRk4ak || __p_SeaGLL3rPCYNtWdK44hGva != this.__p_SeaGLL3rPCYNtWdK44hGva || __p_EqEBeU32HDsPuaUYh7WhBF != this.__p_EqEBeU32HDsPuaUYh7WhBF || __pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa != this.__pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa || __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O != this.__pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O || __slot_FjxLwnVbvKLMPrUG9bDra2 != this.__slot_FjxLwnVbvKLMPrUG9bDra2 || __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN != this.__pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN || __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith != this.__pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith || __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD != this.__pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD || __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR != this.__pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR ? new __CeFBWrWo0LSMKImawF0ujR(this)
                    {__p_BKNuWmrLKpbP6bf1lUjWjR = __p_BKNuWmrLKpbP6bf1lUjWjR, __p_Qm9x03LXxICPJrHai362Ns = __p_Qm9x03LXxICPJrHai362Ns, __p_PCU9dkntvZxNrGBDrQEABN = __p_PCU9dkntvZxNrGBDrQEABN, __p_FnJSIA5NdGxMJH313MW19O = __p_FnJSIA5NdGxMJH313MW19O, __p_QDg9Sly604wMEVyHHUOON8 = __p_QDg9Sly604wMEVyHHUOON8, __p_CAW2q6ZE4PcQN9ZBFRk4ak = __p_CAW2q6ZE4PcQN9ZBFRk4ak, __p_SeaGLL3rPCYNtWdK44hGva = __p_SeaGLL3rPCYNtWdK44hGva, __p_EqEBeU32HDsPuaUYh7WhBF = __p_EqEBeU32HDsPuaUYh7WhBF, __pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa = __pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa, __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O = __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O, __slot_FjxLwnVbvKLMPrUG9bDra2 = __slot_FjxLwnVbvKLMPrUG9bDra2, __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN = __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN, __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith = __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith, __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD = __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD, __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR = __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR} : that_0;
                else
                {
                    this.__p_BKNuWmrLKpbP6bf1lUjWjR = __p_BKNuWmrLKpbP6bf1lUjWjR;
                    this.__p_Qm9x03LXxICPJrHai362Ns = __p_Qm9x03LXxICPJrHai362Ns;
                    this.__p_PCU9dkntvZxNrGBDrQEABN = __p_PCU9dkntvZxNrGBDrQEABN;
                    this.__p_FnJSIA5NdGxMJH313MW19O = __p_FnJSIA5NdGxMJH313MW19O;
                    this.__p_QDg9Sly604wMEVyHHUOON8 = __p_QDg9Sly604wMEVyHHUOON8;
                    this.__p_CAW2q6ZE4PcQN9ZBFRk4ak = __p_CAW2q6ZE4PcQN9ZBFRk4ak;
                    this.__p_SeaGLL3rPCYNtWdK44hGva = __p_SeaGLL3rPCYNtWdK44hGva;
                    this.__p_EqEBeU32HDsPuaUYh7WhBF = __p_EqEBeU32HDsPuaUYh7WhBF;
                    this.__pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa = __pin_group_Input_In_Ij0lAN2elFnPWT2Kv6jNPa;
                    this.__pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O = __pin_group_Arguments_In_FnJSIA5NdGxMJH313MW19O;
                    this.__slot_FjxLwnVbvKLMPrUG9bDra2 = __slot_FjxLwnVbvKLMPrUG9bDra2;
                    this.__pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN = __pin_group_Parameters_In_PCU9dkntvZxNrGBDrQEABN;
                    this.__pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith = __pin_group_Input_In_AHKvcDScj7SNLQlz1m6ith;
                    this.__pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD = __pin_group_Input_In_C8v8LT6WBQOMFHdZLQp8gD;
                    this.__pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR = __pin_group_Arguments_In_BKNuWmrLKpbP6bf1lUjWjR;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 315562U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "GiBmqOr2ltJPa2TS4YRfqo", Name = "VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo")]
    [n2.SerializableAttribute]
    public class VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo Create(n1.NodeContext Node_Context)
        {
            var instance = new VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo CreateDefault()
        {
            var instance = new VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo Update(n6.GpuValue<n5.Vector3> InputT_In, [n4.SerializedDefaultValueAttribute("1", false)] n6.GpuValue<float> Strength_In, [n4.SerializedDefaultValueAttribute("0.01", false)] n6.GpuValue<float> Epsilon_In, out n6.GpuValue<n5.Vector3> Position_Out, out n6.GpuValue<n5.Vector3> Normal_Out, out n6.GpuValue<n5.Vector2> UV_Out)
        {
            bool Simulate_0 = false;
            var State_Output_2 = this.__p_PtlzWvzYztEMjcCBQDR3BB.Update(Simulate_In: Simulate_0, Output_Out: out bool Output_1);
            int Frames_3 = 2;
            bool Retriggerable_4 = true;
            bool Reset_5 = false;
            var Output_8 = this.__p_Eq0dNkYR9AjLkqRNKio9dm.Update(Set_In: Output_1, Frames_In: Frames_3, Retriggerable_In: Retriggerable_4, Reset_In: Reset_5, Value_Out: out bool Value_6, Inverse_Output_Out: out bool Inverse_Output_7);
            bool __pad_MXgNNL7Bi4rOCOiiLea54k_9 = Value_6;
            bool Dispose_Cached_Outputs_10 = false;
            var manager_11 = this.__cache_RMAPDlUmitrOm56B4Shp0g;
            if (manager_11 is null)
            {
                manager_11 = new n7.Manager<n2.ValueTuple<n6.GpuValue<n5.Vector3>, n6.GpuValue<float>, n6.GpuValue<float>>, n2.ValueTuple<n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector2>>>((default(n6.GpuValue<n5.Vector3>), default(n6.GpuValue<n5.Vector3>), default(n6.GpuValue<n5.Vector2>)));
            }

            var inputs_12 = (InputT_In, Strength_In, Epsilon_In);
            var outputs_13 = manager_11.Outputs;
            var Has_Changed_14 = __pad_MXgNNL7Bi4rOCOiiLea54k_9 || manager_11.InputsChanged(inputs_12);
            if (Has_Changed_14)
            {
                if (Dispose_Cached_Outputs_10)
                    manager_11.DisposeOutputs();
                var state_15 = n1.CompilationHelper.Restore<__MXrX6gPKykrLK6fO18EGpK>(manager_11.State, __GetContext__());
                if (state_15 == null)
                {
                    state_15 = new __MXrX6gPKykrLK6fO18EGpK(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __slot_PGLeahjnZrcNOLCUGvu9r1 = default(n6.GpuValue<n5.Vector3>), __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8 = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __slot_N5xiwpipAjcPRVygFegigh = default(n6.GpuValue<n5.Vector3>), __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __slot_Jg1AnzOHvjGPOZAv4iDsSy = default(n6.GpuValue<n5.Vector3>), __slot_VsmZclzWcvZQCBYCcZt0cx = default(n6.GpuValue<n5.Vector3>), __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i = n14._Operations_.CreateDefault<n6.AbstractGpuValue>(), __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O = n14._Operations_.CreateDefault<n6.AbstractGpuValue>(), __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6 = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8 = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU = n14._Operations_.CreateDefault<n6.AbstractGpuValue>(), __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>()};
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "PNj57LoDN45OQU9H1QRtLe", 315574U);
                    var Output_17 = n25.LookAt_Matrix_QeFbsTihjrUMC42dXaXehg.Create(Node_Context: Node_Context_16);
                    state_15.__p_PNj57LoDN45OQU9H1QRtLe = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "CB8uOfH6XoANo72goch15O", 315580U);
                    var Output_19 = n26.Cross_NPx4F770UpZL3ddpapJ5Xw<n5.Vector3>.Create(Node_Context: Node_Context_18);
                    state_15.__p_CB8uOfH6XoANo72goch15O = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "HqGOtmVOHHeLEU9ckUvUjY", 315593U);
                    var Output_21 = n26.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector3>.Create(Node_Context: Node_Context_20);
                    state_15.__p_HqGOtmVOHHeLEU9ckUvUjY = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "D11h79IWrqFNGMRdVTVN9x", 315600U);
                    var Output_23 = n12.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n5.Vector3>.Create(Node_Context: Node_Context_22);
                    state_15.__p_D11h79IWrqFNGMRdVTVN9x = Output_23;
                    n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "HXM9u3btMsMODejR6vBRyO", 315609U);
                    var Output_25 = n26.Mul_B0P7ghpqXJiLy15iE7sIid<n5.Vector3, n5.Matrix, n5.Vector3>.Create(Node_Context: Node_Context_24);
                    state_15.__p_HXM9u3btMsMODejR6vBRyO = Output_25;
                    n1.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "LkUMtxgpxwSPup95ZEzgJa", 315620U);
                    var Output_27 = n26.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector3>.Create(Node_Context: Node_Context_26);
                    state_15.__p_LkUMtxgpxwSPup95ZEzgJa = Output_27;
                    n1.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "UpXsZa2BlFfODiOUAtn61i", 315627U);
                    var Output_29 = n10.Invoke_C<n5.Vector3>.Create(Node_Context: Node_Context_28);
                    state_15.__p_UpXsZa2BlFfODiOUAtn61i = Output_29;
                    n1.NodeContext Node_Context_30 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "NlDFmaRqkqKNy3Uu3tqr0O", 315633U);
                    var Output_31 = n10.Invoke_C<n5.Vector3>.Create(Node_Context: Node_Context_30);
                    state_15.__p_NlDFmaRqkqKNy3Uu3tqr0O = Output_31;
                    n1.NodeContext Node_Context_32 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "CP51aUjfOV7LwifOnD5uNU", 315640U);
                    var Output_33 = n10.Invoke_C<n5.Vector3>.Create(Node_Context: Node_Context_32);
                    state_15.__p_CP51aUjfOV7LwifOnD5uNU = Output_33;
                    n1.NodeContext Node_Context_34 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "QatDHdzu5QfQMNdHx5BUC8", 315648U);
                    var Output_35 = n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3>.Create(Node_Context: Node_Context_34);
                    state_15.__p_QatDHdzu5QfQMNdHx5BUC8 = Output_35;
                    n1.NodeContext Node_Context_36 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "PwIiyLpWdwuN9pDuxJWlrA", 315657U);
                    var Output_37 = n18.ToVector3_BiGMZixIzsHMmgVTnvnygH<float>.Create(Node_Context: Node_Context_36);
                    state_15.__p_PwIiyLpWdwuN9pDuxJWlrA = Output_37;
                    n1.NodeContext Node_Context_38 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "E818YqVjnHENtuNz3Pvcyp", 315664U);
                    var Output_39 = n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3>.Create(Node_Context: Node_Context_38);
                    state_15.__p_E818YqVjnHENtuNz3Pvcyp = Output_39;
                    n1.NodeContext Node_Context_40 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "FsD2hW0CFKbMInHvvF0Ope", 315671U);
                    var Output_41 = n18.ToVector3_BiGMZixIzsHMmgVTnvnygH<float>.Create(Node_Context: Node_Context_40);
                    state_15.__p_FsD2hW0CFKbMInHvvF0Ope = Output_41;
                    n1.NodeContext Node_Context_42 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "PL2jfDWN6ztL8bxOGkAEdP", 315676U);
                    var Output_43 = n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3>.Create(Node_Context: Node_Context_42);
                    state_15.__p_PL2jfDWN6ztL8bxOGkAEdP = Output_43;
                    n1.NodeContext Node_Context_44 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "TTwgrVrneqIQNOh5l3ftp8", 315683U);
                    var Output_45 = n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3>.Create(Node_Context: Node_Context_44);
                    state_15.__p_TTwgrVrneqIQNOh5l3ftp8 = Output_45;
                    n1.NodeContext Node_Context_46 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "BT21p4gvlmxQBFgm158WP6", 315687U);
                    var Output_47 = n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3>.Create(Node_Context: Node_Context_46);
                    state_15.__p_BT21p4gvlmxQBFgm158WP6 = Output_47;
                    n1.NodeContext Node_Context_48 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "NIuQnKpAVYUMhPpU94xBDl", 315693U);
                    var Output_49 = n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3>.Create(Node_Context: Node_Context_48);
                    state_15.__p_NIuQnKpAVYUMhPpU94xBDl = Output_49;
                    n1.NodeContext Node_Context_50 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "OXHDrFarYUiMMdn8NZeAOf", 315698U);
                    var Output_51 = n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3>.Create(Node_Context: Node_Context_50);
                    state_15.__p_OXHDrFarYUiMMdn8NZeAOf = Output_51;
                    n1.NodeContext Node_Context_52 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "Str9mm10a5jMfiCwLgGkgm", 315703U);
                    var Output_53 = n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3>.Create(Node_Context: Node_Context_52);
                    state_15.__p_Str9mm10a5jMfiCwLgGkgm = Output_53;
                    n1.NodeContext Node_Context_54 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "DgmqeAJZEQKNw2aC2D3xCW", 315711U);
                    var Output_55 = n26.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n5.Vector3>.Create(Node_Context: Node_Context_54);
                    state_15.__p_DgmqeAJZEQKNw2aC2D3xCW = Output_55;
                    n1.NodeContext Node_Context_56 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "J8CM01BzZAGPc0suDOTY0g", 315720U);
                    var Output_57 = n26.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n5.Vector3>.Create(Node_Context: Node_Context_56);
                    state_15.__p_J8CM01BzZAGPc0suDOTY0g = Output_57;
                    n1.NodeContext Node_Context_58 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "GLhZyKfZLRUNNtZ58CuiR0", 315727U);
                    var Output_59 = n26.Cross_NPx4F770UpZL3ddpapJ5Xw<n5.Vector3>.Create(Node_Context: Node_Context_58);
                    state_15.__p_GLhZyKfZLRUNNtZ58CuiR0 = Output_59;
                    n1.NodeContext Node_Context_60 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "H3rGbOyxghwMtZ4D3xsoQz", 315732U);
                    var Output_61 = n26.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector3>.Create(Node_Context: Node_Context_60);
                    state_15.__p_H3rGbOyxghwMtZ4D3xsoQz = Output_61;
                    n1.NodeContext Node_Context_62 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "UWRieC1P2usMCsLbUzluLY", 315736U);
                    var Output_63 = n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3>.Create(Node_Context: Node_Context_62);
                    state_15.__p_UWRieC1P2usMCsLbUzluLY = Output_63;
                    n1.NodeContext Node_Context_64 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "OQI5enOD5WrLTBXQpFPuKM", 315740U);
                    var Output_65 = n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3>.Create(Node_Context: Node_Context_64);
                    state_15.__p_OQI5enOD5WrLTBXQpFPuKM = Output_65;
                    n1.NodeContext Node_Context_66 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "SUn1LRvrMFlLr9uFXK1Kuo", 315747U);
                    var Output_67 = n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT.Create(Node_Context: Node_Context_66);
                    state_15.__p_SUn1LRvrMFlLr9uFXK1Kuo = Output_67;
                    n1.NodeContext Node_Context_68 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "RA3Io7ik8oOL8aYn6MSLNo", 315757U);
                    var Output_69 = n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3>.Create(Node_Context: Node_Context_68);
                    state_15.__p_RA3Io7ik8oOL8aYn6MSLNo = Output_69;
                    n1.NodeContext Node_Context_70 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "SqE4XrWu5APQOQ4BiM5idP", 315764U);
                    var Output_71 = n12.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<n5.Vector3>.Create(Node_Context: Node_Context_70);
                    state_15.__p_SqE4XrWu5APQOQ4BiM5idP = Output_71;
                }

                float __pad_B5LIjIbye9vNsnr5H7kPYP_72 = __slot_B5LIjIbye9vNsnr5H7kPYP;
                n5.Vector3 __pad_RhcH7sxhywRMavfUllVH7O_73 = __slot_RhcH7sxhywRMavfUllVH7O;
                n5.Vector3 __pad_VfYYneAVG1FO2yYpZsLK5G_74 = __slot_VfYYneAVG1FO2yYpZsLK5G;
                var Output_78 = state_15.__p_SUn1LRvrMFlLr9uFXK1Kuo.Update(Postion_Out: out n6.GpuValue<n5.Vector3> Postion_75, Normal_Out: out n6.GpuValue<n5.Vector3> Normal_76, UV_Out: out n6.GpuValue<n5.Vector2> UV_77);
                var State_Output_80 = state_15.__p_SqE4XrWu5APQOQ4BiM5idP.Update(The_Value_In: __pad_B5LIjIbye9vNsnr5H7kPYP_72, Output_Out: out n6.ConstantValue<n5.Vector3> Output_79);
                var builder_81 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo, 2);
                builder_81.Add(Normal_76);
                builder_81.Add(Output_79);
                var __pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo_82 = builder_81.Commit();
                var State_Output_84 = state_15.__p_RA3Io7ik8oOL8aYn6MSLNo.Update(Input_In: __pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo_82, Output_Out: out n6.GpuValue<n5.Vector3> Output_83);
                n6.GpuValue<n5.Vector3> up_85 = state_15.__monadBuilder_IfvX39F5ojGOMx10bnGGIw.Return(__pad_RhcH7sxhywRMavfUllVH7O_73);
                var State_Output_87 = state_15.__p_PNj57LoDN45OQU9H1QRtLe.Update(direction_In: Output_83, up_In: up_85, Output_Out: out n6.GpuValue<n5.Matrix> Output_86);
                n6.GpuValue<n5.Vector3> __pad_PGLeahjnZrcNOLCUGvu9r1_88 = Postion_75;
                var Output_90 = state_15.__p_D11h79IWrqFNGMRdVTVN9x.Update(Value_In: __pad_VfYYneAVG1FO2yYpZsLK5G_74, GpuValue_Out: out n6.GpuValue<n5.Vector3> GpuValue_89);
                var State_Output_92 = state_15.__p_HXM9u3btMsMODejR6vBRyO.Update(Input1_In: GpuValue_89, Input2_In: Output_86, Output_Out: out n6.GpuValue<n5.Vector3> Output_91);
                n18._Operations_.TypeVector3(Input_In: Output_91, Output_Out: out n6.GpuValue<n5.Vector3> Output_93);
                var State_Output_95 = state_15.__p_HqGOtmVOHHeLEU9ckUvUjY.Update(Input_In: Output_93, Output_Out: out n6.GpuValue<n5.Vector3> Output_94);
                var State_Output_97 = state_15.__p_CB8uOfH6XoANo72goch15O.Update(Input1_In: Normal_76, Input2_In: Output_94, Output_Out: out n6.GpuValue<n5.Vector3> Output_96);
                var State_Output_99 = state_15.__p_PwIiyLpWdwuN9pDuxJWlrA.Update(x_In: Epsilon_In, Output_Out: out n6.GpuValue<n5.Vector3> Output_98);
                var builder_100 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8, 2);
                builder_100.Add(Output_94);
                builder_100.Add(Output_98);
                var __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8_101 = builder_100.Commit();
                var State_Output_103 = state_15.__p_QatDHdzu5QfQMNdHx5BUC8.Update(Input_In: __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8_101, Output_Out: out n6.GpuValue<n5.Vector3> Output_102);
                var State_Output_105 = state_15.__p_LkUMtxgpxwSPup95ZEzgJa.Update(Input_In: Output_96, Output_Out: out n6.GpuValue<n5.Vector3> Output_104);
                var builder_106 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp, 2);
                builder_106.Add(Output_104);
                builder_106.Add(Output_98);
                var __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp_107 = builder_106.Commit();
                var State_Output_109 = state_15.__p_E818YqVjnHENtuNz3Pvcyp.Update(Input_In: __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp_107, Output_Out: out n6.GpuValue<n5.Vector3> Output_108);
                var builder_110 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM, 2);
                builder_110.Add(__pad_PGLeahjnZrcNOLCUGvu9r1_88);
                builder_110.Add(Output_108);
                var __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM_111 = builder_110.Commit();
                var State_Output_113 = state_15.__p_OQI5enOD5WrLTBXQpFPuKM.Update(Input_In: __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM_111, Output_Out: out n6.GpuValue<n5.Vector3> Output_112);
                n6.GpuValue<n5.Vector3> __pad_N5xiwpipAjcPRVygFegigh_114 = Output_112;
                var builder_115 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_UWRieC1P2usMCsLbUzluLY, 2);
                builder_115.Add(__pad_PGLeahjnZrcNOLCUGvu9r1_88);
                builder_115.Add(Output_102);
                var __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY_116 = builder_115.Commit();
                var State_Output_118 = state_15.__p_UWRieC1P2usMCsLbUzluLY.Update(Input_In: __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY_116, Output_Out: out n6.GpuValue<n5.Vector3> Output_117);
                n6.GpuValue<n5.Vector3> __pad_Jg1AnzOHvjGPOZAv4iDsSy_119 = Output_117;
                n6.GpuValue<n5.Vector3> __pad_VsmZclzWcvZQCBYCcZt0cx_120 = InputT_In;
                var builder_121 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i, 1);
                builder_121.Add(__pad_PGLeahjnZrcNOLCUGvu9r1_88);
                var __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i_122 = builder_121.Commit();
                var State_Output_124 = state_15.__p_UpXsZa2BlFfODiOUAtn61i.Update(Function_In: __pad_VsmZclzWcvZQCBYCcZt0cx_120, Parameters_In: __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i_122, Output_Out: out n6.GpuValue<n5.Vector3> Output_123);
                var State_Output_126 = state_15.__p_FsD2hW0CFKbMInHvvF0Ope.Update(x_In: Strength_In, Output_Out: out n6.GpuValue<n5.Vector3> Output_125);
                var builder_127 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP, 2);
                builder_127.Add(Output_125);
                builder_127.Add(Output_123);
                var __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP_128 = builder_127.Commit();
                var State_Output_130 = state_15.__p_PL2jfDWN6ztL8bxOGkAEdP.Update(Input_In: __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP_128, Output_Out: out n6.GpuValue<n5.Vector3> Output_129);
                var builder_131 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O, 1);
                builder_131.Add(__pad_Jg1AnzOHvjGPOZAv4iDsSy_119);
                var __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O_132 = builder_131.Commit();
                var State_Output_134 = state_15.__p_NlDFmaRqkqKNy3Uu3tqr0O.Update(Function_In: __pad_VsmZclzWcvZQCBYCcZt0cx_120, Parameters_In: __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O_132, Output_Out: out n6.GpuValue<n5.Vector3> Output_133);
                var builder_135 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_BT21p4gvlmxQBFgm158WP6, 2);
                builder_135.Add(Output_125);
                builder_135.Add(Output_133);
                var __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6_136 = builder_135.Commit();
                var State_Output_138 = state_15.__p_BT21p4gvlmxQBFgm158WP6.Update(Input_In: __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6_136, Output_Out: out n6.GpuValue<n5.Vector3> Output_137);
                var builder_139 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl, 2);
                builder_139.Add(Output_137);
                builder_139.Add(__pad_Jg1AnzOHvjGPOZAv4iDsSy_119);
                var __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl_140 = builder_139.Commit();
                var State_Output_142 = state_15.__p_NIuQnKpAVYUMhPpU94xBDl.Update(Input_In: __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl_140, Output_Out: out n6.GpuValue<n5.Vector3> Output_141);
                var builder_143 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8, 2);
                builder_143.Add(Output_129);
                builder_143.Add(__pad_PGLeahjnZrcNOLCUGvu9r1_88);
                var __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8_144 = builder_143.Commit();
                var State_Output_146 = state_15.__p_TTwgrVrneqIQNOh5l3ftp8.Update(Input_In: __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8_144, Output_Out: out n6.GpuValue<n5.Vector3> Output_145);
                var builder_147 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW, 2);
                builder_147.Add(Output_141);
                builder_147.Add(Output_145);
                var __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW_148 = builder_147.Commit();
                var State_Output_150 = state_15.__p_DgmqeAJZEQKNw2aC2D3xCW.Update(Input_In: __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW_148, Output_Out: out n6.GpuValue<n5.Vector3> Output_149);
                var builder_151 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU, 1);
                builder_151.Add(__pad_N5xiwpipAjcPRVygFegigh_114);
                var __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU_152 = builder_151.Commit();
                var State_Output_154 = state_15.__p_CP51aUjfOV7LwifOnD5uNU.Update(Function_In: __pad_VsmZclzWcvZQCBYCcZt0cx_120, Parameters_In: __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU_152, Output_Out: out n6.GpuValue<n5.Vector3> Output_153);
                var builder_155 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf, 2);
                builder_155.Add(Output_125);
                builder_155.Add(Output_153);
                var __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf_156 = builder_155.Commit();
                var State_Output_158 = state_15.__p_OXHDrFarYUiMMdn8NZeAOf.Update(Input_In: __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf_156, Output_Out: out n6.GpuValue<n5.Vector3> Output_157);
                var builder_159 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm, 2);
                builder_159.Add(Output_157);
                builder_159.Add(__pad_N5xiwpipAjcPRVygFegigh_114);
                var __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm_160 = builder_159.Commit();
                var State_Output_162 = state_15.__p_Str9mm10a5jMfiCwLgGkgm.Update(Input_In: __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm_160, Output_Out: out n6.GpuValue<n5.Vector3> Output_161);
                var builder_163 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g, 2);
                builder_163.Add(Output_161);
                builder_163.Add(Output_145);
                var __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g_164 = builder_163.Commit();
                var State_Output_166 = state_15.__p_J8CM01BzZAGPc0suDOTY0g.Update(Input_In: __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g_164, Output_Out: out n6.GpuValue<n5.Vector3> Output_165);
                var State_Output_168 = state_15.__p_GLhZyKfZLRUNNtZ58CuiR0.Update(Input1_In: Output_149, Input2_In: Output_165, Output_Out: out n6.GpuValue<n5.Vector3> Output_167);
                var State_Output_170 = state_15.__p_H3rGbOyxghwMtZ4D3xsoQz.Update(Input_In: Output_167, Output_Out: out n6.GpuValue<n5.Vector3> Output_169);
                if (state_15.__GetContext__().IsImmutable)
                    state_15 = Output_78 != state_15.__p_SUn1LRvrMFlLr9uFXK1Kuo || State_Output_80 != state_15.__p_SqE4XrWu5APQOQ4BiM5idP || __pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo_82 != state_15.__pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo || State_Output_84 != state_15.__p_RA3Io7ik8oOL8aYn6MSLNo || State_Output_87 != state_15.__p_PNj57LoDN45OQU9H1QRtLe || Postion_75 != state_15.__slot_PGLeahjnZrcNOLCUGvu9r1 || Output_90 != state_15.__p_D11h79IWrqFNGMRdVTVN9x || State_Output_92 != state_15.__p_HXM9u3btMsMODejR6vBRyO || State_Output_95 != state_15.__p_HqGOtmVOHHeLEU9ckUvUjY || State_Output_97 != state_15.__p_CB8uOfH6XoANo72goch15O || State_Output_99 != state_15.__p_PwIiyLpWdwuN9pDuxJWlrA || __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8_101 != state_15.__pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8 || State_Output_103 != state_15.__p_QatDHdzu5QfQMNdHx5BUC8 || State_Output_105 != state_15.__p_LkUMtxgpxwSPup95ZEzgJa || __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp_107 != state_15.__pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp || State_Output_109 != state_15.__p_E818YqVjnHENtuNz3Pvcyp || __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM_111 != state_15.__pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM || State_Output_113 != state_15.__p_OQI5enOD5WrLTBXQpFPuKM || Output_112 != state_15.__slot_N5xiwpipAjcPRVygFegigh || __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY_116 != state_15.__pin_group_Input_In_UWRieC1P2usMCsLbUzluLY || State_Output_118 != state_15.__p_UWRieC1P2usMCsLbUzluLY || Output_117 != state_15.__slot_Jg1AnzOHvjGPOZAv4iDsSy || InputT_In != state_15.__slot_VsmZclzWcvZQCBYCcZt0cx || __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i_122 != state_15.__pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i || State_Output_124 != state_15.__p_UpXsZa2BlFfODiOUAtn61i || State_Output_126 != state_15.__p_FsD2hW0CFKbMInHvvF0Ope || __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP_128 != state_15.__pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP || State_Output_130 != state_15.__p_PL2jfDWN6ztL8bxOGkAEdP || __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O_132 != state_15.__pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O || State_Output_134 != state_15.__p_NlDFmaRqkqKNy3Uu3tqr0O || __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6_136 != state_15.__pin_group_Input_In_BT21p4gvlmxQBFgm158WP6 || State_Output_138 != state_15.__p_BT21p4gvlmxQBFgm158WP6 || __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl_140 != state_15.__pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl || State_Output_142 != state_15.__p_NIuQnKpAVYUMhPpU94xBDl || __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8_144 != state_15.__pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8 || State_Output_146 != state_15.__p_TTwgrVrneqIQNOh5l3ftp8 || __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW_148 != state_15.__pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW || State_Output_150 != state_15.__p_DgmqeAJZEQKNw2aC2D3xCW || __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU_152 != state_15.__pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU || State_Output_154 != state_15.__p_CP51aUjfOV7LwifOnD5uNU || __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf_156 != state_15.__pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf || State_Output_158 != state_15.__p_OXHDrFarYUiMMdn8NZeAOf || __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm_160 != state_15.__pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm || State_Output_162 != state_15.__p_Str9mm10a5jMfiCwLgGkgm || __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g_164 != state_15.__pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g || State_Output_166 != state_15.__p_J8CM01BzZAGPc0suDOTY0g || State_Output_168 != state_15.__p_GLhZyKfZLRUNNtZ58CuiR0 || State_Output_170 != state_15.__p_H3rGbOyxghwMtZ4D3xsoQz ? new __MXrX6gPKykrLK6fO18EGpK(state_15)
                    {__p_SUn1LRvrMFlLr9uFXK1Kuo = Output_78, __p_SqE4XrWu5APQOQ4BiM5idP = State_Output_80, __pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo = __pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo_82, __p_RA3Io7ik8oOL8aYn6MSLNo = State_Output_84, __p_PNj57LoDN45OQU9H1QRtLe = State_Output_87, __slot_PGLeahjnZrcNOLCUGvu9r1 = Postion_75, __p_D11h79IWrqFNGMRdVTVN9x = Output_90, __p_HXM9u3btMsMODejR6vBRyO = State_Output_92, __p_HqGOtmVOHHeLEU9ckUvUjY = State_Output_95, __p_CB8uOfH6XoANo72goch15O = State_Output_97, __p_PwIiyLpWdwuN9pDuxJWlrA = State_Output_99, __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8 = __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8_101, __p_QatDHdzu5QfQMNdHx5BUC8 = State_Output_103, __p_LkUMtxgpxwSPup95ZEzgJa = State_Output_105, __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp = __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp_107, __p_E818YqVjnHENtuNz3Pvcyp = State_Output_109, __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM = __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM_111, __p_OQI5enOD5WrLTBXQpFPuKM = State_Output_113, __slot_N5xiwpipAjcPRVygFegigh = Output_112, __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY = __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY_116, __p_UWRieC1P2usMCsLbUzluLY = State_Output_118, __slot_Jg1AnzOHvjGPOZAv4iDsSy = Output_117, __slot_VsmZclzWcvZQCBYCcZt0cx = InputT_In, __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i = __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i_122, __p_UpXsZa2BlFfODiOUAtn61i = State_Output_124, __p_FsD2hW0CFKbMInHvvF0Ope = State_Output_126, __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP = __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP_128, __p_PL2jfDWN6ztL8bxOGkAEdP = State_Output_130, __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O = __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O_132, __p_NlDFmaRqkqKNy3Uu3tqr0O = State_Output_134, __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6 = __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6_136, __p_BT21p4gvlmxQBFgm158WP6 = State_Output_138, __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl = __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl_140, __p_NIuQnKpAVYUMhPpU94xBDl = State_Output_142, __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8 = __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8_144, __p_TTwgrVrneqIQNOh5l3ftp8 = State_Output_146, __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW = __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW_148, __p_DgmqeAJZEQKNw2aC2D3xCW = State_Output_150, __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU = __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU_152, __p_CP51aUjfOV7LwifOnD5uNU = State_Output_154, __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf = __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf_156, __p_OXHDrFarYUiMMdn8NZeAOf = State_Output_158, __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm = __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm_160, __p_Str9mm10a5jMfiCwLgGkgm = State_Output_162, __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g = __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g_164, __p_J8CM01BzZAGPc0suDOTY0g = State_Output_166, __p_GLhZyKfZLRUNNtZ58CuiR0 = State_Output_168, __p_H3rGbOyxghwMtZ4D3xsoQz = State_Output_170} : state_15;
                else
                {
                    state_15.__p_SUn1LRvrMFlLr9uFXK1Kuo = Output_78;
                    state_15.__p_SqE4XrWu5APQOQ4BiM5idP = State_Output_80;
                    state_15.__pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo = __pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo_82;
                    state_15.__p_RA3Io7ik8oOL8aYn6MSLNo = State_Output_84;
                    state_15.__p_PNj57LoDN45OQU9H1QRtLe = State_Output_87;
                    state_15.__slot_PGLeahjnZrcNOLCUGvu9r1 = Postion_75;
                    state_15.__p_D11h79IWrqFNGMRdVTVN9x = Output_90;
                    state_15.__p_HXM9u3btMsMODejR6vBRyO = State_Output_92;
                    state_15.__p_HqGOtmVOHHeLEU9ckUvUjY = State_Output_95;
                    state_15.__p_CB8uOfH6XoANo72goch15O = State_Output_97;
                    state_15.__p_PwIiyLpWdwuN9pDuxJWlrA = State_Output_99;
                    state_15.__pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8 = __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8_101;
                    state_15.__p_QatDHdzu5QfQMNdHx5BUC8 = State_Output_103;
                    state_15.__p_LkUMtxgpxwSPup95ZEzgJa = State_Output_105;
                    state_15.__pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp = __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp_107;
                    state_15.__p_E818YqVjnHENtuNz3Pvcyp = State_Output_109;
                    state_15.__pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM = __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM_111;
                    state_15.__p_OQI5enOD5WrLTBXQpFPuKM = State_Output_113;
                    state_15.__slot_N5xiwpipAjcPRVygFegigh = Output_112;
                    state_15.__pin_group_Input_In_UWRieC1P2usMCsLbUzluLY = __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY_116;
                    state_15.__p_UWRieC1P2usMCsLbUzluLY = State_Output_118;
                    state_15.__slot_Jg1AnzOHvjGPOZAv4iDsSy = Output_117;
                    state_15.__slot_VsmZclzWcvZQCBYCcZt0cx = InputT_In;
                    state_15.__pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i = __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i_122;
                    state_15.__p_UpXsZa2BlFfODiOUAtn61i = State_Output_124;
                    state_15.__p_FsD2hW0CFKbMInHvvF0Ope = State_Output_126;
                    state_15.__pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP = __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP_128;
                    state_15.__p_PL2jfDWN6ztL8bxOGkAEdP = State_Output_130;
                    state_15.__pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O = __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O_132;
                    state_15.__p_NlDFmaRqkqKNy3Uu3tqr0O = State_Output_134;
                    state_15.__pin_group_Input_In_BT21p4gvlmxQBFgm158WP6 = __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6_136;
                    state_15.__p_BT21p4gvlmxQBFgm158WP6 = State_Output_138;
                    state_15.__pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl = __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl_140;
                    state_15.__p_NIuQnKpAVYUMhPpU94xBDl = State_Output_142;
                    state_15.__pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8 = __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8_144;
                    state_15.__p_TTwgrVrneqIQNOh5l3ftp8 = State_Output_146;
                    state_15.__pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW = __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW_148;
                    state_15.__p_DgmqeAJZEQKNw2aC2D3xCW = State_Output_150;
                    state_15.__pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU = __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU_152;
                    state_15.__p_CP51aUjfOV7LwifOnD5uNU = State_Output_154;
                    state_15.__pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf = __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf_156;
                    state_15.__p_OXHDrFarYUiMMdn8NZeAOf = State_Output_158;
                    state_15.__pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm = __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm_160;
                    state_15.__p_Str9mm10a5jMfiCwLgGkgm = State_Output_162;
                    state_15.__pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g = __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g_164;
                    state_15.__p_J8CM01BzZAGPc0suDOTY0g = State_Output_166;
                    state_15.__p_GLhZyKfZLRUNNtZ58CuiR0 = State_Output_168;
                    state_15.__p_H3rGbOyxghwMtZ4D3xsoQz = State_Output_170;
                }

                outputs_13 = (Output_145, Output_169, UV_77);
                manager_11 = manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10, state_15, outputs_13);
            }
            else
            {
                manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10);
            }

            var(__auto_171, __auto_172, __auto_173) = outputs_13;
            Position_Out = __auto_171;
            Normal_Out = __auto_172;
            UV_Out = __auto_173;
            n3.VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo that_174 = this;
            if (this.__GetContext__().IsImmutable)
                that_174 = State_Output_2 != this.__p_PtlzWvzYztEMjcCBQDR3BB || Output_8 != this.__p_Eq0dNkYR9AjLkqRNKio9dm || Value_6 != this.__slot_MXgNNL7Bi4rOCOiiLea54k || manager_11 != this.__cache_RMAPDlUmitrOm56B4Shp0g ? new VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo(this)
                {__p_PtlzWvzYztEMjcCBQDR3BB = State_Output_2, __p_Eq0dNkYR9AjLkqRNKio9dm = Output_8, __slot_MXgNNL7Bi4rOCOiiLea54k = Value_6, __cache_RMAPDlUmitrOm56B4Shp0g = manager_11} : that_174;
            else
            {
                this.__p_PtlzWvzYztEMjcCBQDR3BB = State_Output_2;
                this.__p_Eq0dNkYR9AjLkqRNKio9dm = Output_8;
                this.__slot_MXgNNL7Bi4rOCOiiLea54k = Value_6;
                this.__cache_RMAPDlUmitrOm56B4Shp0g = manager_11;
            }

            return that_174;
        }

        public n3.VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo __Create__(n1.NodeContext Node_Context)
        {
            n23.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "PtlzWvzYztEMjcCBQDR3BB", 315794U);
            var Output_1 = n27.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "Eq0dNkYR9AjLkqRNKio9dm", 315799U);
            var Output_3 = n27.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX.Create(Node_Context: Node_Context_2);
            n3.VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo that_4 = this;
            this.__slot_MXgNNL7Bi4rOCOiiLea54k = false;
            this.__p_PtlzWvzYztEMjcCBQDR3BB = Output_1;
            this.__p_Eq0dNkYR9AjLkqRNKio9dm = Output_3;
            this.__cache_RMAPDlUmitrOm56B4Shp0g = null;
            return that_4;
        }

        public n3.VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo __CreateDefault__()
        {
            n3.VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo that_0 = this;
            this.__slot_MXgNNL7Bi4rOCOiiLea54k = false;
            this.__p_PtlzWvzYztEMjcCBQDR3BB = n27.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__p_Eq0dNkYR9AjLkqRNKio9dm = n27.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX.CreateDefault();
            this.__cache_RMAPDlUmitrOm56B4Shp0g = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_PtlzWvzYztEMjcCBQDR3BB);
            n1.CompilationHelper.SafeDispose(this.__p_Eq0dNkYR9AjLkqRNKio9dm);
            n1.CompilationHelper.SafeDispose(this.__cache_RMAPDlUmitrOm56B4Shp0g);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 315782U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "MXgNNL7Bi4rOCOiiLea54k", Name = "__slot_MXgNNL7Bi4rOCOiiLea54k")]
        public bool __slot_MXgNNL7Bi4rOCOiiLea54k;
        [n1.ElementAttribute(TracingId = 315794U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "PtlzWvzYztEMjcCBQDR3BB", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n27.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_PtlzWvzYztEMjcCBQDR3BB;
        [n1.ElementAttribute(TracingId = 315799U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "Eq0dNkYR9AjLkqRNKio9dm", Name = "MonoFlop (FrameBased)", IsManaged = true, IsAutoGenerated = true)]
        public n27.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_Eq0dNkYR9AjLkqRNKio9dm;
        [n1.ElementAttribute(TracingId = 315565U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "RMAPDlUmitrOm56B4Shp0g", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n6.GpuValue<n5.Vector3>, n6.GpuValue<float>, n6.GpuValue<float>>, n2.ValueTuple<n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector2>>> __cache_RMAPDlUmitrOm56B4Shp0g = null;
        [n1.ElementAttribute(TracingId = 315763U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "B5LIjIbye9vNsnr5H7kPYP", Name = "__slot_B5LIjIbye9vNsnr5H7kPYP")]
        public static float __slot_B5LIjIbye9vNsnr5H7kPYP = 1E-06F;
        [n1.ElementAttribute(TracingId = 315770U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "RhcH7sxhywRMavfUllVH7O", Name = "__slot_RhcH7sxhywRMavfUllVH7O")]
        public static n5.Vector3 __slot_RhcH7sxhywRMavfUllVH7O = n1.CompilationHelper.Deserialize<n5.Vector3>("0.01, 1, 0.01", false, "DlkLpgWeKDyMtsyzTWkBms", "RhcH7sxhywRMavfUllVH7O");
        [n1.ElementAttribute(TracingId = 315605U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "VfYYneAVG1FO2yYpZsLK5G", Name = "__slot_VfYYneAVG1FO2yYpZsLK5G")]
        public static n5.Vector3 __slot_VfYYneAVG1FO2yYpZsLK5G = n1.CompilationHelper.Deserialize<n5.Vector3>("1, 0, 0", false, "DlkLpgWeKDyMtsyzTWkBms", "VfYYneAVG1FO2yYpZsLK5G");
        static VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo()
        {
        }

        public VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo(VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo other): base(other)
        {
            this.__slot_MXgNNL7Bi4rOCOiiLea54k = other.__slot_MXgNNL7Bi4rOCOiiLea54k;
            this.__p_PtlzWvzYztEMjcCBQDR3BB = other.__p_PtlzWvzYztEMjcCBQDR3BB;
            this.__p_Eq0dNkYR9AjLkqRNKio9dm = other.__p_Eq0dNkYR9AjLkqRNKio9dm;
            this.__cache_RMAPDlUmitrOm56B4Shp0g = other.__cache_RMAPDlUmitrOm56B4Shp0g;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_MXgNNL7Bi4rOCOiiLea54k", in __slot_MXgNNL7Bi4rOCOiiLea54k), n1.CompilationHelper.GetValueOrExisting(values, "__p_PtlzWvzYztEMjcCBQDR3BB", in __p_PtlzWvzYztEMjcCBQDR3BB), n1.CompilationHelper.GetValueOrExisting(values, "__p_Eq0dNkYR9AjLkqRNKio9dm", in __p_Eq0dNkYR9AjLkqRNKio9dm), n1.CompilationHelper.GetValueOrExisting(values, "__cache_RMAPDlUmitrOm56B4Shp0g", in __cache_RMAPDlUmitrOm56B4Shp0g));
        }

        internal VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo __WITH__(bool __slot_MXgNNL7Bi4rOCOiiLea54k, n27.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_PtlzWvzYztEMjcCBQDR3BB, n27.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_Eq0dNkYR9AjLkqRNKio9dm, n7.Manager<n2.ValueTuple<n6.GpuValue<n5.Vector3>, n6.GpuValue<float>, n6.GpuValue<float>>, n2.ValueTuple<n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector2>>> __cache_RMAPDlUmitrOm56B4Shp0g)
        {
            n3.VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_MXgNNL7Bi4rOCOiiLea54k != this.__slot_MXgNNL7Bi4rOCOiiLea54k || __p_PtlzWvzYztEMjcCBQDR3BB != this.__p_PtlzWvzYztEMjcCBQDR3BB || __p_Eq0dNkYR9AjLkqRNKio9dm != this.__p_Eq0dNkYR9AjLkqRNKio9dm || __cache_RMAPDlUmitrOm56B4Shp0g != this.__cache_RMAPDlUmitrOm56B4Shp0g ? new VertexDisplacement__3D_Vector_GiBmqOr2ltJPa2TS4YRfqo(this)
                {__slot_MXgNNL7Bi4rOCOiiLea54k = __slot_MXgNNL7Bi4rOCOiiLea54k, __p_PtlzWvzYztEMjcCBQDR3BB = __p_PtlzWvzYztEMjcCBQDR3BB, __p_Eq0dNkYR9AjLkqRNKio9dm = __p_Eq0dNkYR9AjLkqRNKio9dm, __cache_RMAPDlUmitrOm56B4Shp0g = __cache_RMAPDlUmitrOm56B4Shp0g} : that_0;
            else
            {
                this.__slot_MXgNNL7Bi4rOCOiiLea54k = __slot_MXgNNL7Bi4rOCOiiLea54k;
                this.__p_PtlzWvzYztEMjcCBQDR3BB = __p_PtlzWvzYztEMjcCBQDR3BB;
                this.__p_Eq0dNkYR9AjLkqRNKio9dm = __p_Eq0dNkYR9AjLkqRNKio9dm;
                this.__cache_RMAPDlUmitrOm56B4Shp0g = __cache_RMAPDlUmitrOm56B4Shp0g;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "MXrX6gPKykrLK6fO18EGpK", Name = "__MXrX6gPKykrLK6fO18EGpK")]
        [n2.SerializableAttribute]
        public class __MXrX6gPKykrLK6fO18EGpK : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_PNj57LoDN45OQU9H1QRtLe);
                n1.CompilationHelper.SafeDispose(this.__p_CB8uOfH6XoANo72goch15O);
                n1.CompilationHelper.SafeDispose(this.__p_HqGOtmVOHHeLEU9ckUvUjY);
                n1.CompilationHelper.SafeDispose(this.__p_D11h79IWrqFNGMRdVTVN9x);
                n1.CompilationHelper.SafeDispose(this.__p_HXM9u3btMsMODejR6vBRyO);
                n1.CompilationHelper.SafeDispose(this.__p_LkUMtxgpxwSPup95ZEzgJa);
                n1.CompilationHelper.SafeDispose(this.__p_UpXsZa2BlFfODiOUAtn61i);
                n1.CompilationHelper.SafeDispose(this.__p_NlDFmaRqkqKNy3Uu3tqr0O);
                n1.CompilationHelper.SafeDispose(this.__p_CP51aUjfOV7LwifOnD5uNU);
                n1.CompilationHelper.SafeDispose(this.__p_QatDHdzu5QfQMNdHx5BUC8);
                n1.CompilationHelper.SafeDispose(this.__p_PwIiyLpWdwuN9pDuxJWlrA);
                n1.CompilationHelper.SafeDispose(this.__p_E818YqVjnHENtuNz3Pvcyp);
                n1.CompilationHelper.SafeDispose(this.__p_FsD2hW0CFKbMInHvvF0Ope);
                n1.CompilationHelper.SafeDispose(this.__p_PL2jfDWN6ztL8bxOGkAEdP);
                n1.CompilationHelper.SafeDispose(this.__p_TTwgrVrneqIQNOh5l3ftp8);
                n1.CompilationHelper.SafeDispose(this.__p_BT21p4gvlmxQBFgm158WP6);
                n1.CompilationHelper.SafeDispose(this.__p_NIuQnKpAVYUMhPpU94xBDl);
                n1.CompilationHelper.SafeDispose(this.__p_OXHDrFarYUiMMdn8NZeAOf);
                n1.CompilationHelper.SafeDispose(this.__p_Str9mm10a5jMfiCwLgGkgm);
                n1.CompilationHelper.SafeDispose(this.__p_DgmqeAJZEQKNw2aC2D3xCW);
                n1.CompilationHelper.SafeDispose(this.__p_J8CM01BzZAGPc0suDOTY0g);
                n1.CompilationHelper.SafeDispose(this.__p_GLhZyKfZLRUNNtZ58CuiR0);
                n1.CompilationHelper.SafeDispose(this.__p_H3rGbOyxghwMtZ4D3xsoQz);
                n1.CompilationHelper.SafeDispose(this.__p_UWRieC1P2usMCsLbUzluLY);
                n1.CompilationHelper.SafeDispose(this.__p_OQI5enOD5WrLTBXQpFPuKM);
                n1.CompilationHelper.SafeDispose(this.__p_SUn1LRvrMFlLr9uFXK1Kuo);
                n1.CompilationHelper.SafeDispose(this.__p_RA3Io7ik8oOL8aYn6MSLNo);
                n1.CompilationHelper.SafeDispose(this.__p_SqE4XrWu5APQOQ4BiM5idP);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_IfvX39F5ojGOMx10bnGGIw);
                return;
            }

            [n1.ElementAttribute(TracingId = 315574U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "PNj57LoDN45OQU9H1QRtLe", Name = "LookAt (Matrix)", IsManaged = true, IsAutoGenerated = true)]
            public n25.LookAt_Matrix_QeFbsTihjrUMC42dXaXehg __p_PNj57LoDN45OQU9H1QRtLe;
            [n1.ElementAttribute(TracingId = 315580U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "CB8uOfH6XoANo72goch15O", Name = "Cross", IsManaged = true, IsAutoGenerated = true)]
            public n26.Cross_NPx4F770UpZL3ddpapJ5Xw<n5.Vector3> __p_CB8uOfH6XoANo72goch15O;
            [n1.ElementAttribute(TracingId = 315593U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "HqGOtmVOHHeLEU9ckUvUjY", Name = "Normalize", IsManaged = true, IsAutoGenerated = true)]
            public n26.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector3> __p_HqGOtmVOHHeLEU9ckUvUjY;
            [n1.ElementAttribute(TracingId = 315600U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "D11h79IWrqFNGMRdVTVN9x", Name = "Constant", IsManaged = true, IsAutoGenerated = true)]
            public n12.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n5.Vector3> __p_D11h79IWrqFNGMRdVTVN9x;
            [n1.ElementAttribute(TracingId = 315609U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "HXM9u3btMsMODejR6vBRyO", Name = "Mul", IsManaged = true, IsAutoGenerated = true)]
            public n26.Mul_B0P7ghpqXJiLy15iE7sIid<n5.Vector3, n5.Matrix, n5.Vector3> __p_HXM9u3btMsMODejR6vBRyO;
            [n1.ElementAttribute(TracingId = 315620U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "LkUMtxgpxwSPup95ZEzgJa", Name = "Normalize", IsManaged = true, IsAutoGenerated = true)]
            public n26.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector3> __p_LkUMtxgpxwSPup95ZEzgJa;
            [n1.ElementAttribute(TracingId = 315627U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "UpXsZa2BlFfODiOUAtn61i", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n10.Invoke_C<n5.Vector3> __p_UpXsZa2BlFfODiOUAtn61i;
            [n1.ElementAttribute(TracingId = 315633U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "NlDFmaRqkqKNy3Uu3tqr0O", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n10.Invoke_C<n5.Vector3> __p_NlDFmaRqkqKNy3Uu3tqr0O;
            [n1.ElementAttribute(TracingId = 315640U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "CP51aUjfOV7LwifOnD5uNU", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n10.Invoke_C<n5.Vector3> __p_CP51aUjfOV7LwifOnD5uNU;
            [n1.ElementAttribute(TracingId = 315648U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "QatDHdzu5QfQMNdHx5BUC8", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_QatDHdzu5QfQMNdHx5BUC8;
            [n1.ElementAttribute(TracingId = 315657U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "PwIiyLpWdwuN9pDuxJWlrA", Name = "ToVector3", IsManaged = true, IsAutoGenerated = true)]
            public n18.ToVector3_BiGMZixIzsHMmgVTnvnygH<float> __p_PwIiyLpWdwuN9pDuxJWlrA;
            [n1.ElementAttribute(TracingId = 315664U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "E818YqVjnHENtuNz3Pvcyp", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_E818YqVjnHENtuNz3Pvcyp;
            [n1.ElementAttribute(TracingId = 315671U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "FsD2hW0CFKbMInHvvF0Ope", Name = "ToVector3", IsManaged = true, IsAutoGenerated = true)]
            public n18.ToVector3_BiGMZixIzsHMmgVTnvnygH<float> __p_FsD2hW0CFKbMInHvvF0Ope;
            [n1.ElementAttribute(TracingId = 315676U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "PL2jfDWN6ztL8bxOGkAEdP", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_PL2jfDWN6ztL8bxOGkAEdP;
            [n1.ElementAttribute(TracingId = 315683U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "TTwgrVrneqIQNOh5l3ftp8", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_TTwgrVrneqIQNOh5l3ftp8;
            [n1.ElementAttribute(TracingId = 315687U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "BT21p4gvlmxQBFgm158WP6", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_BT21p4gvlmxQBFgm158WP6;
            [n1.ElementAttribute(TracingId = 315693U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "NIuQnKpAVYUMhPpU94xBDl", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_NIuQnKpAVYUMhPpU94xBDl;
            [n1.ElementAttribute(TracingId = 315698U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "OXHDrFarYUiMMdn8NZeAOf", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_OXHDrFarYUiMMdn8NZeAOf;
            [n1.ElementAttribute(TracingId = 315703U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "Str9mm10a5jMfiCwLgGkgm", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_Str9mm10a5jMfiCwLgGkgm;
            [n1.ElementAttribute(TracingId = 315711U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "DgmqeAJZEQKNw2aC2D3xCW", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n5.Vector3> __p_DgmqeAJZEQKNw2aC2D3xCW;
            [n1.ElementAttribute(TracingId = 315720U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "J8CM01BzZAGPc0suDOTY0g", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n5.Vector3> __p_J8CM01BzZAGPc0suDOTY0g;
            [n1.ElementAttribute(TracingId = 315727U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "GLhZyKfZLRUNNtZ58CuiR0", Name = "Cross", IsManaged = true, IsAutoGenerated = true)]
            public n26.Cross_NPx4F770UpZL3ddpapJ5Xw<n5.Vector3> __p_GLhZyKfZLRUNNtZ58CuiR0;
            [n1.ElementAttribute(TracingId = 315732U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "H3rGbOyxghwMtZ4D3xsoQz", Name = "Normalize", IsManaged = true, IsAutoGenerated = true)]
            public n26.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector3> __p_H3rGbOyxghwMtZ4D3xsoQz;
            [n1.ElementAttribute(TracingId = 315736U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "UWRieC1P2usMCsLbUzluLY", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_UWRieC1P2usMCsLbUzluLY;
            [n1.ElementAttribute(TracingId = 315740U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "OQI5enOD5WrLTBXQpFPuKM", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_OQI5enOD5WrLTBXQpFPuKM;
            [n1.ElementAttribute(TracingId = 315747U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "SUn1LRvrMFlLr9uFXK1Kuo", Name = "FunctionParameters (MeshSurface)", IsManaged = true, IsAutoGenerated = true)]
            public n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT __p_SUn1LRvrMFlLr9uFXK1Kuo;
            [n1.ElementAttribute(TracingId = 315757U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "RA3Io7ik8oOL8aYn6MSLNo", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_RA3Io7ik8oOL8aYn6MSLNo;
            [n1.ElementAttribute(TracingId = 315764U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "SqE4XrWu5APQOQ4BiM5idP", Name = "ConstantFromFloat", IsManaged = true, IsAutoGenerated = true)]
            public n12.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<n5.Vector3> __p_SqE4XrWu5APQOQ4BiM5idP;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<n5.Vector3, n6.GpuValue<n5.Vector3>> __monadBuilder_IfvX39F5ojGOMx10bnGGIw = n6.GpuValueMonadicFactory<n5.Vector3>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(TracingId = 315653U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "PGLeahjnZrcNOLCUGvu9r1", Name = "__slot_PGLeahjnZrcNOLCUGvu9r1")]
            public n6.GpuValue<n5.Vector3> __slot_PGLeahjnZrcNOLCUGvu9r1;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8 = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(TracingId = 315655U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "N5xiwpipAjcPRVygFegigh", Name = "__slot_N5xiwpipAjcPRVygFegigh")]
            public n6.GpuValue<n5.Vector3> __slot_N5xiwpipAjcPRVygFegigh;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(TracingId = 315654U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "Jg1AnzOHvjGPOZAv4iDsSy", Name = "__slot_Jg1AnzOHvjGPOZAv4iDsSy")]
            public n6.GpuValue<n5.Vector3> __slot_Jg1AnzOHvjGPOZAv4iDsSy;
            [n1.ElementAttribute(TracingId = 315632U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "VsmZclzWcvZQCBYCcZt0cx", Name = "__slot_VsmZclzWcvZQCBYCcZt0cx")]
            public n6.GpuValue<n5.Vector3> __slot_VsmZclzWcvZQCBYCcZt0cx;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i = default(n13.Spread<n6.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O = default(n13.Spread<n6.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6 = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8 = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU = default(n13.Spread<n6.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            public __MXrX6gPKykrLK6fO18EGpK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MXrX6gPKykrLK6fO18EGpK(__MXrX6gPKykrLK6fO18EGpK other): base(other)
            {
                this.__p_PNj57LoDN45OQU9H1QRtLe = other.__p_PNj57LoDN45OQU9H1QRtLe;
                this.__p_CB8uOfH6XoANo72goch15O = other.__p_CB8uOfH6XoANo72goch15O;
                this.__p_HqGOtmVOHHeLEU9ckUvUjY = other.__p_HqGOtmVOHHeLEU9ckUvUjY;
                this.__p_D11h79IWrqFNGMRdVTVN9x = other.__p_D11h79IWrqFNGMRdVTVN9x;
                this.__p_HXM9u3btMsMODejR6vBRyO = other.__p_HXM9u3btMsMODejR6vBRyO;
                this.__p_LkUMtxgpxwSPup95ZEzgJa = other.__p_LkUMtxgpxwSPup95ZEzgJa;
                this.__p_UpXsZa2BlFfODiOUAtn61i = other.__p_UpXsZa2BlFfODiOUAtn61i;
                this.__p_NlDFmaRqkqKNy3Uu3tqr0O = other.__p_NlDFmaRqkqKNy3Uu3tqr0O;
                this.__p_CP51aUjfOV7LwifOnD5uNU = other.__p_CP51aUjfOV7LwifOnD5uNU;
                this.__p_QatDHdzu5QfQMNdHx5BUC8 = other.__p_QatDHdzu5QfQMNdHx5BUC8;
                this.__p_PwIiyLpWdwuN9pDuxJWlrA = other.__p_PwIiyLpWdwuN9pDuxJWlrA;
                this.__p_E818YqVjnHENtuNz3Pvcyp = other.__p_E818YqVjnHENtuNz3Pvcyp;
                this.__p_FsD2hW0CFKbMInHvvF0Ope = other.__p_FsD2hW0CFKbMInHvvF0Ope;
                this.__p_PL2jfDWN6ztL8bxOGkAEdP = other.__p_PL2jfDWN6ztL8bxOGkAEdP;
                this.__p_TTwgrVrneqIQNOh5l3ftp8 = other.__p_TTwgrVrneqIQNOh5l3ftp8;
                this.__p_BT21p4gvlmxQBFgm158WP6 = other.__p_BT21p4gvlmxQBFgm158WP6;
                this.__p_NIuQnKpAVYUMhPpU94xBDl = other.__p_NIuQnKpAVYUMhPpU94xBDl;
                this.__p_OXHDrFarYUiMMdn8NZeAOf = other.__p_OXHDrFarYUiMMdn8NZeAOf;
                this.__p_Str9mm10a5jMfiCwLgGkgm = other.__p_Str9mm10a5jMfiCwLgGkgm;
                this.__p_DgmqeAJZEQKNw2aC2D3xCW = other.__p_DgmqeAJZEQKNw2aC2D3xCW;
                this.__p_J8CM01BzZAGPc0suDOTY0g = other.__p_J8CM01BzZAGPc0suDOTY0g;
                this.__p_GLhZyKfZLRUNNtZ58CuiR0 = other.__p_GLhZyKfZLRUNNtZ58CuiR0;
                this.__p_H3rGbOyxghwMtZ4D3xsoQz = other.__p_H3rGbOyxghwMtZ4D3xsoQz;
                this.__p_UWRieC1P2usMCsLbUzluLY = other.__p_UWRieC1P2usMCsLbUzluLY;
                this.__p_OQI5enOD5WrLTBXQpFPuKM = other.__p_OQI5enOD5WrLTBXQpFPuKM;
                this.__p_SUn1LRvrMFlLr9uFXK1Kuo = other.__p_SUn1LRvrMFlLr9uFXK1Kuo;
                this.__p_RA3Io7ik8oOL8aYn6MSLNo = other.__p_RA3Io7ik8oOL8aYn6MSLNo;
                this.__p_SqE4XrWu5APQOQ4BiM5idP = other.__p_SqE4XrWu5APQOQ4BiM5idP;
                this.__pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo = other.__pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo;
                this.__monadBuilder_IfvX39F5ojGOMx10bnGGIw = other.__monadBuilder_IfvX39F5ojGOMx10bnGGIw;
                this.__slot_PGLeahjnZrcNOLCUGvu9r1 = other.__slot_PGLeahjnZrcNOLCUGvu9r1;
                this.__pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8 = other.__pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8;
                this.__pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp = other.__pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp;
                this.__pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM = other.__pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM;
                this.__slot_N5xiwpipAjcPRVygFegigh = other.__slot_N5xiwpipAjcPRVygFegigh;
                this.__pin_group_Input_In_UWRieC1P2usMCsLbUzluLY = other.__pin_group_Input_In_UWRieC1P2usMCsLbUzluLY;
                this.__slot_Jg1AnzOHvjGPOZAv4iDsSy = other.__slot_Jg1AnzOHvjGPOZAv4iDsSy;
                this.__slot_VsmZclzWcvZQCBYCcZt0cx = other.__slot_VsmZclzWcvZQCBYCcZt0cx;
                this.__pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i = other.__pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i;
                this.__pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP = other.__pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP;
                this.__pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O = other.__pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O;
                this.__pin_group_Input_In_BT21p4gvlmxQBFgm158WP6 = other.__pin_group_Input_In_BT21p4gvlmxQBFgm158WP6;
                this.__pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl = other.__pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl;
                this.__pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8 = other.__pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8;
                this.__pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW = other.__pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW;
                this.__pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU = other.__pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU;
                this.__pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf = other.__pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf;
                this.__pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm = other.__pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm;
                this.__pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g = other.__pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_PNj57LoDN45OQU9H1QRtLe", in __p_PNj57LoDN45OQU9H1QRtLe), n1.CompilationHelper.GetValueOrExisting(values, "__p_CB8uOfH6XoANo72goch15O", in __p_CB8uOfH6XoANo72goch15O), n1.CompilationHelper.GetValueOrExisting(values, "__p_HqGOtmVOHHeLEU9ckUvUjY", in __p_HqGOtmVOHHeLEU9ckUvUjY), n1.CompilationHelper.GetValueOrExisting(values, "__p_D11h79IWrqFNGMRdVTVN9x", in __p_D11h79IWrqFNGMRdVTVN9x), n1.CompilationHelper.GetValueOrExisting(values, "__p_HXM9u3btMsMODejR6vBRyO", in __p_HXM9u3btMsMODejR6vBRyO), n1.CompilationHelper.GetValueOrExisting(values, "__p_LkUMtxgpxwSPup95ZEzgJa", in __p_LkUMtxgpxwSPup95ZEzgJa), n1.CompilationHelper.GetValueOrExisting(values, "__p_UpXsZa2BlFfODiOUAtn61i", in __p_UpXsZa2BlFfODiOUAtn61i), n1.CompilationHelper.GetValueOrExisting(values, "__p_NlDFmaRqkqKNy3Uu3tqr0O", in __p_NlDFmaRqkqKNy3Uu3tqr0O), n1.CompilationHelper.GetValueOrExisting(values, "__p_CP51aUjfOV7LwifOnD5uNU", in __p_CP51aUjfOV7LwifOnD5uNU), n1.CompilationHelper.GetValueOrExisting(values, "__p_QatDHdzu5QfQMNdHx5BUC8", in __p_QatDHdzu5QfQMNdHx5BUC8), n1.CompilationHelper.GetValueOrExisting(values, "__p_PwIiyLpWdwuN9pDuxJWlrA", in __p_PwIiyLpWdwuN9pDuxJWlrA), n1.CompilationHelper.GetValueOrExisting(values, "__p_E818YqVjnHENtuNz3Pvcyp", in __p_E818YqVjnHENtuNz3Pvcyp), n1.CompilationHelper.GetValueOrExisting(values, "__p_FsD2hW0CFKbMInHvvF0Ope", in __p_FsD2hW0CFKbMInHvvF0Ope), n1.CompilationHelper.GetValueOrExisting(values, "__p_PL2jfDWN6ztL8bxOGkAEdP", in __p_PL2jfDWN6ztL8bxOGkAEdP), n1.CompilationHelper.GetValueOrExisting(values, "__p_TTwgrVrneqIQNOh5l3ftp8", in __p_TTwgrVrneqIQNOh5l3ftp8), n1.CompilationHelper.GetValueOrExisting(values, "__p_BT21p4gvlmxQBFgm158WP6", in __p_BT21p4gvlmxQBFgm158WP6), n1.CompilationHelper.GetValueOrExisting(values, "__p_NIuQnKpAVYUMhPpU94xBDl", in __p_NIuQnKpAVYUMhPpU94xBDl), n1.CompilationHelper.GetValueOrExisting(values, "__p_OXHDrFarYUiMMdn8NZeAOf", in __p_OXHDrFarYUiMMdn8NZeAOf), n1.CompilationHelper.GetValueOrExisting(values, "__p_Str9mm10a5jMfiCwLgGkgm", in __p_Str9mm10a5jMfiCwLgGkgm), n1.CompilationHelper.GetValueOrExisting(values, "__p_DgmqeAJZEQKNw2aC2D3xCW", in __p_DgmqeAJZEQKNw2aC2D3xCW), n1.CompilationHelper.GetValueOrExisting(values, "__p_J8CM01BzZAGPc0suDOTY0g", in __p_J8CM01BzZAGPc0suDOTY0g), n1.CompilationHelper.GetValueOrExisting(values, "__p_GLhZyKfZLRUNNtZ58CuiR0", in __p_GLhZyKfZLRUNNtZ58CuiR0), n1.CompilationHelper.GetValueOrExisting(values, "__p_H3rGbOyxghwMtZ4D3xsoQz", in __p_H3rGbOyxghwMtZ4D3xsoQz), n1.CompilationHelper.GetValueOrExisting(values, "__p_UWRieC1P2usMCsLbUzluLY", in __p_UWRieC1P2usMCsLbUzluLY), n1.CompilationHelper.GetValueOrExisting(values, "__p_OQI5enOD5WrLTBXQpFPuKM", in __p_OQI5enOD5WrLTBXQpFPuKM), n1.CompilationHelper.GetValueOrExisting(values, "__p_SUn1LRvrMFlLr9uFXK1Kuo", in __p_SUn1LRvrMFlLr9uFXK1Kuo), n1.CompilationHelper.GetValueOrExisting(values, "__p_RA3Io7ik8oOL8aYn6MSLNo", in __p_RA3Io7ik8oOL8aYn6MSLNo), n1.CompilationHelper.GetValueOrExisting(values, "__p_SqE4XrWu5APQOQ4BiM5idP", in __p_SqE4XrWu5APQOQ4BiM5idP), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo", in __pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_IfvX39F5ojGOMx10bnGGIw", in __monadBuilder_IfvX39F5ojGOMx10bnGGIw), n1.CompilationHelper.GetValueOrExisting(values, "__slot_PGLeahjnZrcNOLCUGvu9r1", in __slot_PGLeahjnZrcNOLCUGvu9r1), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8", in __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp", in __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM", in __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM), n1.CompilationHelper.GetValueOrExisting(values, "__slot_N5xiwpipAjcPRVygFegigh", in __slot_N5xiwpipAjcPRVygFegigh), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_UWRieC1P2usMCsLbUzluLY", in __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Jg1AnzOHvjGPOZAv4iDsSy", in __slot_Jg1AnzOHvjGPOZAv4iDsSy), n1.CompilationHelper.GetValueOrExisting(values, "__slot_VsmZclzWcvZQCBYCcZt0cx", in __slot_VsmZclzWcvZQCBYCcZt0cx), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i", in __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP", in __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O", in __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_BT21p4gvlmxQBFgm158WP6", in __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl", in __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8", in __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW", in __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU", in __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf", in __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm", in __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g", in __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g));
            }

            internal __MXrX6gPKykrLK6fO18EGpK __WITH__(n25.LookAt_Matrix_QeFbsTihjrUMC42dXaXehg __p_PNj57LoDN45OQU9H1QRtLe, n26.Cross_NPx4F770UpZL3ddpapJ5Xw<n5.Vector3> __p_CB8uOfH6XoANo72goch15O, n26.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector3> __p_HqGOtmVOHHeLEU9ckUvUjY, n12.Constant_C05sp6Ijg7TN6Mfl7g0LqX<n5.Vector3> __p_D11h79IWrqFNGMRdVTVN9x, n26.Mul_B0P7ghpqXJiLy15iE7sIid<n5.Vector3, n5.Matrix, n5.Vector3> __p_HXM9u3btMsMODejR6vBRyO, n26.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector3> __p_LkUMtxgpxwSPup95ZEzgJa, n10.Invoke_C<n5.Vector3> __p_UpXsZa2BlFfODiOUAtn61i, n10.Invoke_C<n5.Vector3> __p_NlDFmaRqkqKNy3Uu3tqr0O, n10.Invoke_C<n5.Vector3> __p_CP51aUjfOV7LwifOnD5uNU, n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_QatDHdzu5QfQMNdHx5BUC8, n18.ToVector3_BiGMZixIzsHMmgVTnvnygH<float> __p_PwIiyLpWdwuN9pDuxJWlrA, n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_E818YqVjnHENtuNz3Pvcyp, n18.ToVector3_BiGMZixIzsHMmgVTnvnygH<float> __p_FsD2hW0CFKbMInHvvF0Ope, n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_PL2jfDWN6ztL8bxOGkAEdP, n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_TTwgrVrneqIQNOh5l3ftp8, n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_BT21p4gvlmxQBFgm158WP6, n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_NIuQnKpAVYUMhPpU94xBDl, n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_OXHDrFarYUiMMdn8NZeAOf, n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_Str9mm10a5jMfiCwLgGkgm, n26.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n5.Vector3> __p_DgmqeAJZEQKNw2aC2D3xCW, n26.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n5.Vector3> __p_J8CM01BzZAGPc0suDOTY0g, n26.Cross_NPx4F770UpZL3ddpapJ5Xw<n5.Vector3> __p_GLhZyKfZLRUNNtZ58CuiR0, n26.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector3> __p_H3rGbOyxghwMtZ4D3xsoQz, n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_UWRieC1P2usMCsLbUzluLY, n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_OQI5enOD5WrLTBXQpFPuKM, n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT __p_SUn1LRvrMFlLr9uFXK1Kuo, n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_RA3Io7ik8oOL8aYn6MSLNo, n12.ConstantFromFloat_Htzu4qaypocNx5DUVYrMpA<n5.Vector3> __p_SqE4XrWu5APQOQ4BiM5idP, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo, n1.IMonadBuilder<n5.Vector3, n6.GpuValue<n5.Vector3>> __monadBuilder_IfvX39F5ojGOMx10bnGGIw, n6.GpuValue<n5.Vector3> __slot_PGLeahjnZrcNOLCUGvu9r1, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM, n6.GpuValue<n5.Vector3> __slot_N5xiwpipAjcPRVygFegigh, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY, n6.GpuValue<n5.Vector3> __slot_Jg1AnzOHvjGPOZAv4iDsSy, n6.GpuValue<n5.Vector3> __slot_VsmZclzWcvZQCBYCcZt0cx, n13.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP, n13.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW, n13.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g)
            {
                __MXrX6gPKykrLK6fO18EGpK that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_PNj57LoDN45OQU9H1QRtLe != this.__p_PNj57LoDN45OQU9H1QRtLe || __p_CB8uOfH6XoANo72goch15O != this.__p_CB8uOfH6XoANo72goch15O || __p_HqGOtmVOHHeLEU9ckUvUjY != this.__p_HqGOtmVOHHeLEU9ckUvUjY || __p_D11h79IWrqFNGMRdVTVN9x != this.__p_D11h79IWrqFNGMRdVTVN9x || __p_HXM9u3btMsMODejR6vBRyO != this.__p_HXM9u3btMsMODejR6vBRyO || __p_LkUMtxgpxwSPup95ZEzgJa != this.__p_LkUMtxgpxwSPup95ZEzgJa || __p_UpXsZa2BlFfODiOUAtn61i != this.__p_UpXsZa2BlFfODiOUAtn61i || __p_NlDFmaRqkqKNy3Uu3tqr0O != this.__p_NlDFmaRqkqKNy3Uu3tqr0O || __p_CP51aUjfOV7LwifOnD5uNU != this.__p_CP51aUjfOV7LwifOnD5uNU || __p_QatDHdzu5QfQMNdHx5BUC8 != this.__p_QatDHdzu5QfQMNdHx5BUC8 || __p_PwIiyLpWdwuN9pDuxJWlrA != this.__p_PwIiyLpWdwuN9pDuxJWlrA || __p_E818YqVjnHENtuNz3Pvcyp != this.__p_E818YqVjnHENtuNz3Pvcyp || __p_FsD2hW0CFKbMInHvvF0Ope != this.__p_FsD2hW0CFKbMInHvvF0Ope || __p_PL2jfDWN6ztL8bxOGkAEdP != this.__p_PL2jfDWN6ztL8bxOGkAEdP || __p_TTwgrVrneqIQNOh5l3ftp8 != this.__p_TTwgrVrneqIQNOh5l3ftp8 || __p_BT21p4gvlmxQBFgm158WP6 != this.__p_BT21p4gvlmxQBFgm158WP6 || __p_NIuQnKpAVYUMhPpU94xBDl != this.__p_NIuQnKpAVYUMhPpU94xBDl || __p_OXHDrFarYUiMMdn8NZeAOf != this.__p_OXHDrFarYUiMMdn8NZeAOf || __p_Str9mm10a5jMfiCwLgGkgm != this.__p_Str9mm10a5jMfiCwLgGkgm || __p_DgmqeAJZEQKNw2aC2D3xCW != this.__p_DgmqeAJZEQKNw2aC2D3xCW || __p_J8CM01BzZAGPc0suDOTY0g != this.__p_J8CM01BzZAGPc0suDOTY0g || __p_GLhZyKfZLRUNNtZ58CuiR0 != this.__p_GLhZyKfZLRUNNtZ58CuiR0 || __p_H3rGbOyxghwMtZ4D3xsoQz != this.__p_H3rGbOyxghwMtZ4D3xsoQz || __p_UWRieC1P2usMCsLbUzluLY != this.__p_UWRieC1P2usMCsLbUzluLY || __p_OQI5enOD5WrLTBXQpFPuKM != this.__p_OQI5enOD5WrLTBXQpFPuKM || __p_SUn1LRvrMFlLr9uFXK1Kuo != this.__p_SUn1LRvrMFlLr9uFXK1Kuo || __p_RA3Io7ik8oOL8aYn6MSLNo != this.__p_RA3Io7ik8oOL8aYn6MSLNo || __p_SqE4XrWu5APQOQ4BiM5idP != this.__p_SqE4XrWu5APQOQ4BiM5idP || __pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo != this.__pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo || __monadBuilder_IfvX39F5ojGOMx10bnGGIw != this.__monadBuilder_IfvX39F5ojGOMx10bnGGIw || __slot_PGLeahjnZrcNOLCUGvu9r1 != this.__slot_PGLeahjnZrcNOLCUGvu9r1 || __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8 != this.__pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8 || __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp != this.__pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp || __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM != this.__pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM || __slot_N5xiwpipAjcPRVygFegigh != this.__slot_N5xiwpipAjcPRVygFegigh || __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY != this.__pin_group_Input_In_UWRieC1P2usMCsLbUzluLY || __slot_Jg1AnzOHvjGPOZAv4iDsSy != this.__slot_Jg1AnzOHvjGPOZAv4iDsSy || __slot_VsmZclzWcvZQCBYCcZt0cx != this.__slot_VsmZclzWcvZQCBYCcZt0cx || __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i != this.__pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i || __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP != this.__pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP || __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O != this.__pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O || __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6 != this.__pin_group_Input_In_BT21p4gvlmxQBFgm158WP6 || __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl != this.__pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl || __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8 != this.__pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8 || __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW != this.__pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW || __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU != this.__pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU || __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf != this.__pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf || __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm != this.__pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm || __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g != this.__pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g ? new __MXrX6gPKykrLK6fO18EGpK(this)
                    {__p_PNj57LoDN45OQU9H1QRtLe = __p_PNj57LoDN45OQU9H1QRtLe, __p_CB8uOfH6XoANo72goch15O = __p_CB8uOfH6XoANo72goch15O, __p_HqGOtmVOHHeLEU9ckUvUjY = __p_HqGOtmVOHHeLEU9ckUvUjY, __p_D11h79IWrqFNGMRdVTVN9x = __p_D11h79IWrqFNGMRdVTVN9x, __p_HXM9u3btMsMODejR6vBRyO = __p_HXM9u3btMsMODejR6vBRyO, __p_LkUMtxgpxwSPup95ZEzgJa = __p_LkUMtxgpxwSPup95ZEzgJa, __p_UpXsZa2BlFfODiOUAtn61i = __p_UpXsZa2BlFfODiOUAtn61i, __p_NlDFmaRqkqKNy3Uu3tqr0O = __p_NlDFmaRqkqKNy3Uu3tqr0O, __p_CP51aUjfOV7LwifOnD5uNU = __p_CP51aUjfOV7LwifOnD5uNU, __p_QatDHdzu5QfQMNdHx5BUC8 = __p_QatDHdzu5QfQMNdHx5BUC8, __p_PwIiyLpWdwuN9pDuxJWlrA = __p_PwIiyLpWdwuN9pDuxJWlrA, __p_E818YqVjnHENtuNz3Pvcyp = __p_E818YqVjnHENtuNz3Pvcyp, __p_FsD2hW0CFKbMInHvvF0Ope = __p_FsD2hW0CFKbMInHvvF0Ope, __p_PL2jfDWN6ztL8bxOGkAEdP = __p_PL2jfDWN6ztL8bxOGkAEdP, __p_TTwgrVrneqIQNOh5l3ftp8 = __p_TTwgrVrneqIQNOh5l3ftp8, __p_BT21p4gvlmxQBFgm158WP6 = __p_BT21p4gvlmxQBFgm158WP6, __p_NIuQnKpAVYUMhPpU94xBDl = __p_NIuQnKpAVYUMhPpU94xBDl, __p_OXHDrFarYUiMMdn8NZeAOf = __p_OXHDrFarYUiMMdn8NZeAOf, __p_Str9mm10a5jMfiCwLgGkgm = __p_Str9mm10a5jMfiCwLgGkgm, __p_DgmqeAJZEQKNw2aC2D3xCW = __p_DgmqeAJZEQKNw2aC2D3xCW, __p_J8CM01BzZAGPc0suDOTY0g = __p_J8CM01BzZAGPc0suDOTY0g, __p_GLhZyKfZLRUNNtZ58CuiR0 = __p_GLhZyKfZLRUNNtZ58CuiR0, __p_H3rGbOyxghwMtZ4D3xsoQz = __p_H3rGbOyxghwMtZ4D3xsoQz, __p_UWRieC1P2usMCsLbUzluLY = __p_UWRieC1P2usMCsLbUzluLY, __p_OQI5enOD5WrLTBXQpFPuKM = __p_OQI5enOD5WrLTBXQpFPuKM, __p_SUn1LRvrMFlLr9uFXK1Kuo = __p_SUn1LRvrMFlLr9uFXK1Kuo, __p_RA3Io7ik8oOL8aYn6MSLNo = __p_RA3Io7ik8oOL8aYn6MSLNo, __p_SqE4XrWu5APQOQ4BiM5idP = __p_SqE4XrWu5APQOQ4BiM5idP, __pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo = __pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo, __monadBuilder_IfvX39F5ojGOMx10bnGGIw = __monadBuilder_IfvX39F5ojGOMx10bnGGIw, __slot_PGLeahjnZrcNOLCUGvu9r1 = __slot_PGLeahjnZrcNOLCUGvu9r1, __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8 = __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8, __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp = __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp, __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM = __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM, __slot_N5xiwpipAjcPRVygFegigh = __slot_N5xiwpipAjcPRVygFegigh, __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY = __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY, __slot_Jg1AnzOHvjGPOZAv4iDsSy = __slot_Jg1AnzOHvjGPOZAv4iDsSy, __slot_VsmZclzWcvZQCBYCcZt0cx = __slot_VsmZclzWcvZQCBYCcZt0cx, __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i = __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i, __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP = __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP, __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O = __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O, __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6 = __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6, __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl = __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl, __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8 = __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8, __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW = __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW, __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU = __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU, __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf = __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf, __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm = __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm, __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g = __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g} : that_0;
                else
                {
                    this.__p_PNj57LoDN45OQU9H1QRtLe = __p_PNj57LoDN45OQU9H1QRtLe;
                    this.__p_CB8uOfH6XoANo72goch15O = __p_CB8uOfH6XoANo72goch15O;
                    this.__p_HqGOtmVOHHeLEU9ckUvUjY = __p_HqGOtmVOHHeLEU9ckUvUjY;
                    this.__p_D11h79IWrqFNGMRdVTVN9x = __p_D11h79IWrqFNGMRdVTVN9x;
                    this.__p_HXM9u3btMsMODejR6vBRyO = __p_HXM9u3btMsMODejR6vBRyO;
                    this.__p_LkUMtxgpxwSPup95ZEzgJa = __p_LkUMtxgpxwSPup95ZEzgJa;
                    this.__p_UpXsZa2BlFfODiOUAtn61i = __p_UpXsZa2BlFfODiOUAtn61i;
                    this.__p_NlDFmaRqkqKNy3Uu3tqr0O = __p_NlDFmaRqkqKNy3Uu3tqr0O;
                    this.__p_CP51aUjfOV7LwifOnD5uNU = __p_CP51aUjfOV7LwifOnD5uNU;
                    this.__p_QatDHdzu5QfQMNdHx5BUC8 = __p_QatDHdzu5QfQMNdHx5BUC8;
                    this.__p_PwIiyLpWdwuN9pDuxJWlrA = __p_PwIiyLpWdwuN9pDuxJWlrA;
                    this.__p_E818YqVjnHENtuNz3Pvcyp = __p_E818YqVjnHENtuNz3Pvcyp;
                    this.__p_FsD2hW0CFKbMInHvvF0Ope = __p_FsD2hW0CFKbMInHvvF0Ope;
                    this.__p_PL2jfDWN6ztL8bxOGkAEdP = __p_PL2jfDWN6ztL8bxOGkAEdP;
                    this.__p_TTwgrVrneqIQNOh5l3ftp8 = __p_TTwgrVrneqIQNOh5l3ftp8;
                    this.__p_BT21p4gvlmxQBFgm158WP6 = __p_BT21p4gvlmxQBFgm158WP6;
                    this.__p_NIuQnKpAVYUMhPpU94xBDl = __p_NIuQnKpAVYUMhPpU94xBDl;
                    this.__p_OXHDrFarYUiMMdn8NZeAOf = __p_OXHDrFarYUiMMdn8NZeAOf;
                    this.__p_Str9mm10a5jMfiCwLgGkgm = __p_Str9mm10a5jMfiCwLgGkgm;
                    this.__p_DgmqeAJZEQKNw2aC2D3xCW = __p_DgmqeAJZEQKNw2aC2D3xCW;
                    this.__p_J8CM01BzZAGPc0suDOTY0g = __p_J8CM01BzZAGPc0suDOTY0g;
                    this.__p_GLhZyKfZLRUNNtZ58CuiR0 = __p_GLhZyKfZLRUNNtZ58CuiR0;
                    this.__p_H3rGbOyxghwMtZ4D3xsoQz = __p_H3rGbOyxghwMtZ4D3xsoQz;
                    this.__p_UWRieC1P2usMCsLbUzluLY = __p_UWRieC1P2usMCsLbUzluLY;
                    this.__p_OQI5enOD5WrLTBXQpFPuKM = __p_OQI5enOD5WrLTBXQpFPuKM;
                    this.__p_SUn1LRvrMFlLr9uFXK1Kuo = __p_SUn1LRvrMFlLr9uFXK1Kuo;
                    this.__p_RA3Io7ik8oOL8aYn6MSLNo = __p_RA3Io7ik8oOL8aYn6MSLNo;
                    this.__p_SqE4XrWu5APQOQ4BiM5idP = __p_SqE4XrWu5APQOQ4BiM5idP;
                    this.__pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo = __pin_group_Input_In_RA3Io7ik8oOL8aYn6MSLNo;
                    this.__monadBuilder_IfvX39F5ojGOMx10bnGGIw = __monadBuilder_IfvX39F5ojGOMx10bnGGIw;
                    this.__slot_PGLeahjnZrcNOLCUGvu9r1 = __slot_PGLeahjnZrcNOLCUGvu9r1;
                    this.__pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8 = __pin_group_Input_In_QatDHdzu5QfQMNdHx5BUC8;
                    this.__pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp = __pin_group_Input_In_E818YqVjnHENtuNz3Pvcyp;
                    this.__pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM = __pin_group_Input_In_OQI5enOD5WrLTBXQpFPuKM;
                    this.__slot_N5xiwpipAjcPRVygFegigh = __slot_N5xiwpipAjcPRVygFegigh;
                    this.__pin_group_Input_In_UWRieC1P2usMCsLbUzluLY = __pin_group_Input_In_UWRieC1P2usMCsLbUzluLY;
                    this.__slot_Jg1AnzOHvjGPOZAv4iDsSy = __slot_Jg1AnzOHvjGPOZAv4iDsSy;
                    this.__slot_VsmZclzWcvZQCBYCcZt0cx = __slot_VsmZclzWcvZQCBYCcZt0cx;
                    this.__pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i = __pin_group_Parameters_In_UpXsZa2BlFfODiOUAtn61i;
                    this.__pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP = __pin_group_Input_In_PL2jfDWN6ztL8bxOGkAEdP;
                    this.__pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O = __pin_group_Parameters_In_NlDFmaRqkqKNy3Uu3tqr0O;
                    this.__pin_group_Input_In_BT21p4gvlmxQBFgm158WP6 = __pin_group_Input_In_BT21p4gvlmxQBFgm158WP6;
                    this.__pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl = __pin_group_Input_In_NIuQnKpAVYUMhPpU94xBDl;
                    this.__pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8 = __pin_group_Input_In_TTwgrVrneqIQNOh5l3ftp8;
                    this.__pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW = __pin_group_Input_In_DgmqeAJZEQKNw2aC2D3xCW;
                    this.__pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU = __pin_group_Parameters_In_CP51aUjfOV7LwifOnD5uNU;
                    this.__pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf = __pin_group_Input_In_OXHDrFarYUiMMdn8NZeAOf;
                    this.__pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm = __pin_group_Input_In_Str9mm10a5jMfiCwLgGkgm;
                    this.__pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g = __pin_group_Input_In_J8CM01BzZAGPc0suDOTY0g;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 315912U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "IyKq68Yg5L9LhU3pt9kDRT", Name = "FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT")]
    [n2.SerializableAttribute]
    public class FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT Create(n1.NodeContext Node_Context)
        {
            var instance = new FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT CreateDefault()
        {
            var instance = new FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT Update(out n6.GpuValue<n5.Vector3> Postion_Out, out n6.GpuValue<n5.Vector3> Normal_Out, out n6.GpuValue<n5.Vector2> UV_Out)
        {
            n6.GpuValue<n5.Vector3> Input_0 = default(n6.GpuValue<n5.Vector3>);
            n18._Operations_.TypeVector3(Input_In: Input_0, Output_Out: out n6.GpuValue<n5.Vector3> Output_1);
            n6.GpuValue<n5.Vector3> Input_2 = default(n6.GpuValue<n5.Vector3>);
            n18._Operations_.TypeVector3(Input_In: Input_2, Output_Out: out n6.GpuValue<n5.Vector3> Output_3);
            n6.GpuValue<n5.Vector2> Input_4 = default(n6.GpuValue<n5.Vector2>);
            n18._Operations_.TypeVector2(Input_In: Input_4, Output_Out: out n6.GpuValue<n5.Vector2> Output_5);
            var State_Output_9 = this.__p_Cs4MPjapTFJPPWCXr8Qn85.Update(Input_In: Output_1, Input2_In: Output_3, Input3_In: Output_5, Output_Out: out n6.GpuValue<n5.Vector3> Output_6, Output2_Out: out n6.GpuValue<n5.Vector3> Output2_7, Output3_Out: out n6.GpuValue<n5.Vector2> Output3_8);
            Postion_Out = Output_6;
            Normal_Out = Output2_7;
            UV_Out = Output3_8;
            n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = State_Output_9 != this.__p_Cs4MPjapTFJPPWCXr8Qn85 ? new FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT(this)
                {__p_Cs4MPjapTFJPPWCXr8Qn85 = State_Output_9} : that_10;
            else
            {
                this.__p_Cs4MPjapTFJPPWCXr8Qn85 = State_Output_9;
            }

            return that_10;
        }

        public n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT __Create__(n1.NodeContext Node_Context)
        {
            n23.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "Cs4MPjapTFJPPWCXr8Qn85", 315916U);
            var Output_1 = n10.FunctionParameter__3_Parameters_UPscneAUAH9OIC6ocXJWdO<n5.Vector3, n5.Vector3, n5.Vector2>.Create(Node_Context: Node_Context_0);
            n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT that_2 = this;
            this.__p_Cs4MPjapTFJPPWCXr8Qn85 = Output_1;
            return that_2;
        }

        public n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT __CreateDefault__()
        {
            n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT that_0 = this;
            this.__p_Cs4MPjapTFJPPWCXr8Qn85 = n10.FunctionParameter__3_Parameters_UPscneAUAH9OIC6ocXJWdO<n5.Vector3, n5.Vector3, n5.Vector2>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Cs4MPjapTFJPPWCXr8Qn85);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 315916U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "Cs4MPjapTFJPPWCXr8Qn85", Name = "FunctionParameter (3 Parameters)", IsManaged = true, IsAutoGenerated = true)]
        public n10.FunctionParameter__3_Parameters_UPscneAUAH9OIC6ocXJWdO<n5.Vector3, n5.Vector3, n5.Vector2> __p_Cs4MPjapTFJPPWCXr8Qn85;
        public FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT(FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT other): base(other)
        {
            this.__p_Cs4MPjapTFJPPWCXr8Qn85 = other.__p_Cs4MPjapTFJPPWCXr8Qn85;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Cs4MPjapTFJPPWCXr8Qn85", in __p_Cs4MPjapTFJPPWCXr8Qn85));
        }

        internal FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT __WITH__(n10.FunctionParameter__3_Parameters_UPscneAUAH9OIC6ocXJWdO<n5.Vector3, n5.Vector3, n5.Vector2> __p_Cs4MPjapTFJPPWCXr8Qn85)
        {
            n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Cs4MPjapTFJPPWCXr8Qn85 != this.__p_Cs4MPjapTFJPPWCXr8Qn85 ? new FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT(this)
                {__p_Cs4MPjapTFJPPWCXr8Qn85 = __p_Cs4MPjapTFJPPWCXr8Qn85} : that_0;
            else
            {
                this.__p_Cs4MPjapTFJPPWCXr8Qn85 = __p_Cs4MPjapTFJPPWCXr8Qn85;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 315988U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "K3tAiNBBhkqQNFtEwT1qh0", Name = "VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0")]
    [n2.SerializableAttribute]
    public class VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0 Create(n1.NodeContext Node_Context)
        {
            var instance = new VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0 CreateDefault()
        {
            var instance = new VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0 Update(n6.GpuValue<float> InputT_In, [n4.SerializedDefaultValueAttribute("1", false)] n6.GpuValue<float> Strength_In, [n4.SerializedDefaultValueAttribute("0.01", false)] n6.GpuValue<float> Epsilon_In, out n6.GpuValue<n5.Vector3> Position_Out, out n6.GpuValue<n5.Vector3> Normal_Out, out n6.GpuValue<n5.Vector2> UV_Out)
        {
            bool Simulate_0 = false;
            var State_Output_2 = this.__p_EiSIl7Nef1xNnBJ6r6FnHe.Update(Simulate_In: Simulate_0, Output_Out: out bool Output_1);
            int Frames_3 = 2;
            bool Retriggerable_4 = true;
            bool Reset_5 = false;
            var Output_8 = this.__p_ChGEpw4gFezLAOhwVOH2JV.Update(Set_In: Output_1, Frames_In: Frames_3, Retriggerable_In: Retriggerable_4, Reset_In: Reset_5, Value_Out: out bool Value_6, Inverse_Output_Out: out bool Inverse_Output_7);
            bool __pad_LeBQYWgChncLbA9KhXmck2_9 = Value_6;
            bool Dispose_Cached_Outputs_10 = false;
            var manager_11 = this.__cache_H8ILkJYc4WbLDdZiDdJtoR;
            if (manager_11 is null)
            {
                manager_11 = new n7.Manager<n2.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>>, n2.ValueTuple<n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector2>>>((default(n6.GpuValue<n5.Vector3>), default(n6.GpuValue<n5.Vector3>), default(n6.GpuValue<n5.Vector2>)));
            }

            var inputs_12 = (InputT_In, Strength_In, Epsilon_In);
            var outputs_13 = manager_11.Outputs;
            var Has_Changed_14 = __pad_LeBQYWgChncLbA9KhXmck2_9 || manager_11.InputsChanged(inputs_12);
            if (Has_Changed_14)
            {
                if (Dispose_Cached_Outputs_10)
                    manager_11.DisposeOutputs();
                var state_15 = n1.CompilationHelper.Restore<__F1Qepe36uBuQJFNJD1O3Zc>(manager_11.State, __GetContext__());
                if (state_15 == null)
                {
                    state_15 = new __F1Qepe36uBuQJFNJD1O3Zc(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c = n14._Operations_.CreateDefault<n6.AbstractGpuValue>(), __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>(), __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X = n14._Operations_.CreateDefault<n6.GpuValue<n5.Vector3>>()};
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "BwEetSfMDC0N7Vqbu22Orm", 316004U);
                    var Output_17 = n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT.Create(Node_Context: Node_Context_16);
                    state_15.__p_BwEetSfMDC0N7Vqbu22Orm = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "FApVKj8BXz8QJBw1XjR93X", 316019U);
                    var Output_19 = n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3>.Create(Node_Context: Node_Context_18);
                    state_15.__p_FApVKj8BXz8QJBw1XjR93X = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "BWWCUxA4cHGOs1rt79OHbq", 316027U);
                    var Output_21 = n18.ToVector3_BiGMZixIzsHMmgVTnvnygH<float>.Create(Node_Context: Node_Context_20);
                    state_15.__p_BWWCUxA4cHGOs1rt79OHbq = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "BkHEGDb7TQdPX3TCkdQdnv", 316033U);
                    var Output_23 = n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3>.Create(Node_Context: Node_Context_22);
                    state_15.__p_BkHEGDb7TQdPX3TCkdQdnv = Output_23;
                    n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "QQhVSj6xwgKLYeb5vrGyUF", 316041U);
                    var Output_25 = n28.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<n5.Vector3>.Create(Node_Context: Node_Context_24);
                    state_15.__p_QQhVSj6xwgKLYeb5vrGyUF = Output_25;
                    n1.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "ABswv4jlkUbLVaAbjl0olf", 316056U);
                    var Output_27 = n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3>.Create(Node_Context: Node_Context_26);
                    state_15.__p_ABswv4jlkUbLVaAbjl0olf = Output_27;
                    n1.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "VPq9et9dCQTPblkdKJ4Cwp", 316064U);
                    var Output_29 = n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3>.Create(Node_Context: Node_Context_28);
                    state_15.__p_VPq9et9dCQTPblkdKJ4Cwp = Output_29;
                    n1.NodeContext Node_Context_30 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "RfnWsbW5paiMCMGB0ViQkw", 316071U);
                    var Output_31 = n18.ToVector3_BiGMZixIzsHMmgVTnvnygH<float>.Create(Node_Context: Node_Context_30);
                    state_15.__p_RfnWsbW5paiMCMGB0ViQkw = Output_31;
                    n1.NodeContext Node_Context_32 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "I0fvU963JWPMdidvrw1vNU", 316077U);
                    var Output_33 = n26.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector3>.Create(Node_Context: Node_Context_32);
                    state_15.__p_I0fvU963JWPMdidvrw1vNU = Output_33;
                    n1.NodeContext Node_Context_34 = __GetContext__().CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "UvrIsMTD504Pz7QcI3lH3c", 316083U);
                    var Output_35 = n10.Invoke_C<float>.Create(Node_Context: Node_Context_34);
                    state_15.__p_UvrIsMTD504Pz7QcI3lH3c = Output_35;
                }

                var Output_39 = state_15.__p_BwEetSfMDC0N7Vqbu22Orm.Update(Postion_Out: out n6.GpuValue<n5.Vector3> Postion_36, Normal_Out: out n6.GpuValue<n5.Vector3> Normal_37, UV_Out: out n6.GpuValue<n5.Vector2> UV_38);
                n18._Operations_.TypeFloat(Input_In: InputT_In, Output_Out: out n6.GpuValue<float> Output_40);
                var builder_41 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c, 1);
                builder_41.Add(Postion_36);
                var __pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c_42 = builder_41.Commit();
                var State_Output_44 = state_15.__p_UvrIsMTD504Pz7QcI3lH3c.Update(Function_In: Output_40, Parameters_In: __pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c_42, Output_Out: out n6.GpuValue<float> Output_43);
                var State_Output_46 = state_15.__p_RfnWsbW5paiMCMGB0ViQkw.Update(x_In: Output_43, Output_Out: out n6.GpuValue<n5.Vector3> Output_45);
                var State_Output_48 = state_15.__p_BWWCUxA4cHGOs1rt79OHbq.Update(x_In: Strength_In, Output_Out: out n6.GpuValue<n5.Vector3> Output_47);
                var builder_49 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv, 3);
                builder_49.Add(Output_45);
                builder_49.Add(Output_47);
                builder_49.Add(Normal_37);
                var __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv_50 = builder_49.Commit();
                var State_Output_52 = state_15.__p_BkHEGDb7TQdPX3TCkdQdnv.Update(Input_In: __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv_50, Output_Out: out n6.GpuValue<n5.Vector3> Output_51);
                var builder_53 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp, 2);
                builder_53.Add(Output_51);
                builder_53.Add(Postion_36);
                var __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp_54 = builder_53.Commit();
                var State_Output_56 = state_15.__p_VPq9et9dCQTPblkdKJ4Cwp.Update(Input_In: __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp_54, Output_Out: out n6.GpuValue<n5.Vector3> Output_55);
                n29.GradientDifferentiationMode Numerical_Differentiation_Mode_57 = __c_TZzF6s23tvHQBqRmNgoz1f;
                bool Normalize_58 = false;
                var State_Output_60 = state_15.__p_QQhVSj6xwgKLYeb5vrGyUF.Update<n30.__AdaptiveImplementations__DlkLpgWeKDyMtsyzTWkBms>(Function_In: Output_40, Position_In: Output_55, Epsilon_In: Epsilon_In, Numerical_Differentiation_Mode_In: Numerical_Differentiation_Mode_57, Normalize_In: Normalize_58, Output_Out: out n6.GpuValue<n5.Vector3> Output_59);
                var builder_61 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf, 2);
                builder_61.Add(Output_59);
                builder_61.Add(Output_47);
                var __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf_62 = builder_61.Commit();
                var State_Output_64 = state_15.__p_ABswv4jlkUbLVaAbjl0olf.Update(Input_In: __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf_62, Output_Out: out n6.GpuValue<n5.Vector3> Output_63);
                var builder_65 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X, 2);
                builder_65.Add(Output_63);
                builder_65.Add(Normal_37);
                var __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X_66 = builder_65.Commit();
                var State_Output_68 = state_15.__p_FApVKj8BXz8QJBw1XjR93X.Update(Input_In: __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X_66, Output_Out: out n6.GpuValue<n5.Vector3> Output_67);
                var State_Output_70 = state_15.__p_I0fvU963JWPMdidvrw1vNU.Update(Input_In: Output_67, Output_Out: out n6.GpuValue<n5.Vector3> Output_69);
                if (state_15.__GetContext__().IsImmutable)
                    state_15 = Output_39 != state_15.__p_BwEetSfMDC0N7Vqbu22Orm || __pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c_42 != state_15.__pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c || State_Output_44 != state_15.__p_UvrIsMTD504Pz7QcI3lH3c || State_Output_46 != state_15.__p_RfnWsbW5paiMCMGB0ViQkw || State_Output_48 != state_15.__p_BWWCUxA4cHGOs1rt79OHbq || __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv_50 != state_15.__pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv || State_Output_52 != state_15.__p_BkHEGDb7TQdPX3TCkdQdnv || __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp_54 != state_15.__pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp || State_Output_56 != state_15.__p_VPq9et9dCQTPblkdKJ4Cwp || State_Output_60 != state_15.__p_QQhVSj6xwgKLYeb5vrGyUF || __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf_62 != state_15.__pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf || State_Output_64 != state_15.__p_ABswv4jlkUbLVaAbjl0olf || __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X_66 != state_15.__pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X || State_Output_68 != state_15.__p_FApVKj8BXz8QJBw1XjR93X || State_Output_70 != state_15.__p_I0fvU963JWPMdidvrw1vNU ? new __F1Qepe36uBuQJFNJD1O3Zc(state_15)
                    {__p_BwEetSfMDC0N7Vqbu22Orm = Output_39, __pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c = __pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c_42, __p_UvrIsMTD504Pz7QcI3lH3c = State_Output_44, __p_RfnWsbW5paiMCMGB0ViQkw = State_Output_46, __p_BWWCUxA4cHGOs1rt79OHbq = State_Output_48, __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv = __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv_50, __p_BkHEGDb7TQdPX3TCkdQdnv = State_Output_52, __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp = __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp_54, __p_VPq9et9dCQTPblkdKJ4Cwp = State_Output_56, __p_QQhVSj6xwgKLYeb5vrGyUF = State_Output_60, __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf = __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf_62, __p_ABswv4jlkUbLVaAbjl0olf = State_Output_64, __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X = __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X_66, __p_FApVKj8BXz8QJBw1XjR93X = State_Output_68, __p_I0fvU963JWPMdidvrw1vNU = State_Output_70} : state_15;
                else
                {
                    state_15.__p_BwEetSfMDC0N7Vqbu22Orm = Output_39;
                    state_15.__pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c = __pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c_42;
                    state_15.__p_UvrIsMTD504Pz7QcI3lH3c = State_Output_44;
                    state_15.__p_RfnWsbW5paiMCMGB0ViQkw = State_Output_46;
                    state_15.__p_BWWCUxA4cHGOs1rt79OHbq = State_Output_48;
                    state_15.__pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv = __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv_50;
                    state_15.__p_BkHEGDb7TQdPX3TCkdQdnv = State_Output_52;
                    state_15.__pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp = __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp_54;
                    state_15.__p_VPq9et9dCQTPblkdKJ4Cwp = State_Output_56;
                    state_15.__p_QQhVSj6xwgKLYeb5vrGyUF = State_Output_60;
                    state_15.__pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf = __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf_62;
                    state_15.__p_ABswv4jlkUbLVaAbjl0olf = State_Output_64;
                    state_15.__pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X = __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X_66;
                    state_15.__p_FApVKj8BXz8QJBw1XjR93X = State_Output_68;
                    state_15.__p_I0fvU963JWPMdidvrw1vNU = State_Output_70;
                }

                outputs_13 = (Output_55, Output_69, UV_38);
                manager_11 = manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10, state_15, outputs_13);
            }
            else
            {
                manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10);
            }

            var(__auto_71, __auto_72, __auto_73) = outputs_13;
            Position_Out = __auto_71;
            Normal_Out = __auto_72;
            UV_Out = __auto_73;
            n3.VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0 that_74 = this;
            if (this.__GetContext__().IsImmutable)
                that_74 = State_Output_2 != this.__p_EiSIl7Nef1xNnBJ6r6FnHe || Output_8 != this.__p_ChGEpw4gFezLAOhwVOH2JV || Value_6 != this.__slot_LeBQYWgChncLbA9KhXmck2 || manager_11 != this.__cache_H8ILkJYc4WbLDdZiDdJtoR ? new VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0(this)
                {__p_EiSIl7Nef1xNnBJ6r6FnHe = State_Output_2, __p_ChGEpw4gFezLAOhwVOH2JV = Output_8, __slot_LeBQYWgChncLbA9KhXmck2 = Value_6, __cache_H8ILkJYc4WbLDdZiDdJtoR = manager_11} : that_74;
            else
            {
                this.__p_EiSIl7Nef1xNnBJ6r6FnHe = State_Output_2;
                this.__p_ChGEpw4gFezLAOhwVOH2JV = Output_8;
                this.__slot_LeBQYWgChncLbA9KhXmck2 = Value_6;
                this.__cache_H8ILkJYc4WbLDdZiDdJtoR = manager_11;
            }

            return that_74;
        }

        public n3.VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0 __Create__(n1.NodeContext Node_Context)
        {
            n23.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "EiSIl7Nef1xNnBJ6r6FnHe", 316120U);
            var Output_1 = n27.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("DlkLpgWeKDyMtsyzTWkBms", "ChGEpw4gFezLAOhwVOH2JV", 316125U);
            var Output_3 = n27.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX.Create(Node_Context: Node_Context_2);
            n3.VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0 that_4 = this;
            this.__slot_LeBQYWgChncLbA9KhXmck2 = false;
            this.__p_EiSIl7Nef1xNnBJ6r6FnHe = Output_1;
            this.__p_ChGEpw4gFezLAOhwVOH2JV = Output_3;
            this.__cache_H8ILkJYc4WbLDdZiDdJtoR = null;
            return that_4;
        }

        public n3.VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0 __CreateDefault__()
        {
            n3.VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0 that_0 = this;
            this.__slot_LeBQYWgChncLbA9KhXmck2 = false;
            this.__p_EiSIl7Nef1xNnBJ6r6FnHe = n27.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__p_ChGEpw4gFezLAOhwVOH2JV = n27.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX.CreateDefault();
            this.__cache_H8ILkJYc4WbLDdZiDdJtoR = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_EiSIl7Nef1xNnBJ6r6FnHe);
            n1.CompilationHelper.SafeDispose(this.__p_ChGEpw4gFezLAOhwVOH2JV);
            n1.CompilationHelper.SafeDispose(this.__cache_H8ILkJYc4WbLDdZiDdJtoR);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 316106U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "LeBQYWgChncLbA9KhXmck2", Name = "__slot_LeBQYWgChncLbA9KhXmck2")]
        public bool __slot_LeBQYWgChncLbA9KhXmck2;
        [n1.ElementAttribute(TracingId = 316137U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "PAK8vHCqkACQdazW6l9SET", Name = "__slot_PAK8vHCqkACQdazW6l9SET")]
        public static string __slot_PAK8vHCqkACQdazW6l9SET = "\tfloat3 pp = p + bump * n * bumpAmt;\r\n\tn += calcGradS3(INPUTBUMP, pp, 0.01)* bumpAmt;\r\n\tn = normalize(n);";
        [n1.ElementAttribute(TracingId = 316120U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "EiSIl7Nef1xNnBJ6r6FnHe", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n27.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_EiSIl7Nef1xNnBJ6r6FnHe;
        [n1.ElementAttribute(TracingId = 316125U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "ChGEpw4gFezLAOhwVOH2JV", Name = "MonoFlop (FrameBased)", IsManaged = true, IsAutoGenerated = true)]
        public n27.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_ChGEpw4gFezLAOhwVOH2JV;
        [n1.ElementAttribute(TracingId = 315993U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "H8ILkJYc4WbLDdZiDdJtoR", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>>, n2.ValueTuple<n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector2>>> __cache_H8ILkJYc4WbLDdZiDdJtoR = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n29.GradientDifferentiationMode __c_TZzF6s23tvHQBqRmNgoz1f = n1.CompilationHelper.Deserialize<n29.GradientDifferentiationMode>("CentralDifference", false, "DlkLpgWeKDyMtsyzTWkBms", "TZzF6s23tvHQBqRmNgoz1f");
        static VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0()
        {
        }

        public VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0(VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0 other): base(other)
        {
            this.__slot_LeBQYWgChncLbA9KhXmck2 = other.__slot_LeBQYWgChncLbA9KhXmck2;
            this.__p_EiSIl7Nef1xNnBJ6r6FnHe = other.__p_EiSIl7Nef1xNnBJ6r6FnHe;
            this.__p_ChGEpw4gFezLAOhwVOH2JV = other.__p_ChGEpw4gFezLAOhwVOH2JV;
            this.__cache_H8ILkJYc4WbLDdZiDdJtoR = other.__cache_H8ILkJYc4WbLDdZiDdJtoR;
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_LeBQYWgChncLbA9KhXmck2", in __slot_LeBQYWgChncLbA9KhXmck2), n1.CompilationHelper.GetValueOrExisting(values, "__p_EiSIl7Nef1xNnBJ6r6FnHe", in __p_EiSIl7Nef1xNnBJ6r6FnHe), n1.CompilationHelper.GetValueOrExisting(values, "__p_ChGEpw4gFezLAOhwVOH2JV", in __p_ChGEpw4gFezLAOhwVOH2JV), n1.CompilationHelper.GetValueOrExisting(values, "__cache_H8ILkJYc4WbLDdZiDdJtoR", in __cache_H8ILkJYc4WbLDdZiDdJtoR));
        }

        internal VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0 __WITH__(bool __slot_LeBQYWgChncLbA9KhXmck2, n27.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_EiSIl7Nef1xNnBJ6r6FnHe, n27.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_ChGEpw4gFezLAOhwVOH2JV, n7.Manager<n2.ValueTuple<n6.GpuValue<float>, n6.GpuValue<float>, n6.GpuValue<float>>, n2.ValueTuple<n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector3>, n6.GpuValue<n5.Vector2>>> __cache_H8ILkJYc4WbLDdZiDdJtoR)
        {
            n3.VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_LeBQYWgChncLbA9KhXmck2 != this.__slot_LeBQYWgChncLbA9KhXmck2 || __p_EiSIl7Nef1xNnBJ6r6FnHe != this.__p_EiSIl7Nef1xNnBJ6r6FnHe || __p_ChGEpw4gFezLAOhwVOH2JV != this.__p_ChGEpw4gFezLAOhwVOH2JV || __cache_H8ILkJYc4WbLDdZiDdJtoR != this.__cache_H8ILkJYc4WbLDdZiDdJtoR ? new VertexDisplacement__3D_Scalar_K3tAiNBBhkqQNFtEwT1qh0(this)
                {__slot_LeBQYWgChncLbA9KhXmck2 = __slot_LeBQYWgChncLbA9KhXmck2, __p_EiSIl7Nef1xNnBJ6r6FnHe = __p_EiSIl7Nef1xNnBJ6r6FnHe, __p_ChGEpw4gFezLAOhwVOH2JV = __p_ChGEpw4gFezLAOhwVOH2JV, __cache_H8ILkJYc4WbLDdZiDdJtoR = __cache_H8ILkJYc4WbLDdZiDdJtoR} : that_0;
            else
            {
                this.__slot_LeBQYWgChncLbA9KhXmck2 = __slot_LeBQYWgChncLbA9KhXmck2;
                this.__p_EiSIl7Nef1xNnBJ6r6FnHe = __p_EiSIl7Nef1xNnBJ6r6FnHe;
                this.__p_ChGEpw4gFezLAOhwVOH2JV = __p_ChGEpw4gFezLAOhwVOH2JV;
                this.__cache_H8ILkJYc4WbLDdZiDdJtoR = __cache_H8ILkJYc4WbLDdZiDdJtoR;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "F1Qepe36uBuQJFNJD1O3Zc", Name = "__F1Qepe36uBuQJFNJD1O3Zc")]
        [n2.SerializableAttribute]
        public class __F1Qepe36uBuQJFNJD1O3Zc : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_BwEetSfMDC0N7Vqbu22Orm);
                n1.CompilationHelper.SafeDispose(this.__p_FApVKj8BXz8QJBw1XjR93X);
                n1.CompilationHelper.SafeDispose(this.__p_BWWCUxA4cHGOs1rt79OHbq);
                n1.CompilationHelper.SafeDispose(this.__p_BkHEGDb7TQdPX3TCkdQdnv);
                n1.CompilationHelper.SafeDispose(this.__p_QQhVSj6xwgKLYeb5vrGyUF);
                n1.CompilationHelper.SafeDispose(this.__p_ABswv4jlkUbLVaAbjl0olf);
                n1.CompilationHelper.SafeDispose(this.__p_VPq9et9dCQTPblkdKJ4Cwp);
                n1.CompilationHelper.SafeDispose(this.__p_RfnWsbW5paiMCMGB0ViQkw);
                n1.CompilationHelper.SafeDispose(this.__p_I0fvU963JWPMdidvrw1vNU);
                n1.CompilationHelper.SafeDispose(this.__p_UvrIsMTD504Pz7QcI3lH3c);
                return;
            }

            [n1.ElementAttribute(TracingId = 316004U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "BwEetSfMDC0N7Vqbu22Orm", Name = "FunctionParameters (MeshSurface)", IsManaged = true, IsAutoGenerated = true)]
            public n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT __p_BwEetSfMDC0N7Vqbu22Orm;
            [n1.ElementAttribute(TracingId = 316019U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "FApVKj8BXz8QJBw1XjR93X", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_FApVKj8BXz8QJBw1XjR93X;
            [n1.ElementAttribute(TracingId = 316027U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "BWWCUxA4cHGOs1rt79OHbq", Name = "ToVector3", IsManaged = true, IsAutoGenerated = true)]
            public n18.ToVector3_BiGMZixIzsHMmgVTnvnygH<float> __p_BWWCUxA4cHGOs1rt79OHbq;
            [n1.ElementAttribute(TracingId = 316033U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "BkHEGDb7TQdPX3TCkdQdnv", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_BkHEGDb7TQdPX3TCkdQdnv;
            [n1.ElementAttribute(TracingId = 316041U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "QQhVSj6xwgKLYeb5vrGyUF", Name = "FunctionGradient", IsManaged = true, IsAutoGenerated = true)]
            public n28.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<n5.Vector3> __p_QQhVSj6xwgKLYeb5vrGyUF;
            [n1.ElementAttribute(TracingId = 316056U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "ABswv4jlkUbLVaAbjl0olf", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_ABswv4jlkUbLVaAbjl0olf;
            [n1.ElementAttribute(TracingId = 316064U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "VPq9et9dCQTPblkdKJ4Cwp", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_VPq9et9dCQTPblkdKJ4Cwp;
            [n1.ElementAttribute(TracingId = 316071U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "RfnWsbW5paiMCMGB0ViQkw", Name = "ToVector3", IsManaged = true, IsAutoGenerated = true)]
            public n18.ToVector3_BiGMZixIzsHMmgVTnvnygH<float> __p_RfnWsbW5paiMCMGB0ViQkw;
            [n1.ElementAttribute(TracingId = 316077U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "I0fvU963JWPMdidvrw1vNU", Name = "Normalize", IsManaged = true, IsAutoGenerated = true)]
            public n26.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector3> __p_I0fvU963JWPMdidvrw1vNU;
            [n1.ElementAttribute(TracingId = 316083U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "UvrIsMTD504Pz7QcI3lH3c", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n10.Invoke_C<float> __p_UvrIsMTD504Pz7QcI3lH3c;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c = default(n13.Spread<n6.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X = default(n13.Spread<n6.GpuValue<n5.Vector3>>);
            public __F1Qepe36uBuQJFNJD1O3Zc(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __F1Qepe36uBuQJFNJD1O3Zc(__F1Qepe36uBuQJFNJD1O3Zc other): base(other)
            {
                this.__p_BwEetSfMDC0N7Vqbu22Orm = other.__p_BwEetSfMDC0N7Vqbu22Orm;
                this.__p_FApVKj8BXz8QJBw1XjR93X = other.__p_FApVKj8BXz8QJBw1XjR93X;
                this.__p_BWWCUxA4cHGOs1rt79OHbq = other.__p_BWWCUxA4cHGOs1rt79OHbq;
                this.__p_BkHEGDb7TQdPX3TCkdQdnv = other.__p_BkHEGDb7TQdPX3TCkdQdnv;
                this.__p_QQhVSj6xwgKLYeb5vrGyUF = other.__p_QQhVSj6xwgKLYeb5vrGyUF;
                this.__p_ABswv4jlkUbLVaAbjl0olf = other.__p_ABswv4jlkUbLVaAbjl0olf;
                this.__p_VPq9et9dCQTPblkdKJ4Cwp = other.__p_VPq9et9dCQTPblkdKJ4Cwp;
                this.__p_RfnWsbW5paiMCMGB0ViQkw = other.__p_RfnWsbW5paiMCMGB0ViQkw;
                this.__p_I0fvU963JWPMdidvrw1vNU = other.__p_I0fvU963JWPMdidvrw1vNU;
                this.__p_UvrIsMTD504Pz7QcI3lH3c = other.__p_UvrIsMTD504Pz7QcI3lH3c;
                this.__pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c = other.__pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c;
                this.__pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv = other.__pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv;
                this.__pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp = other.__pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp;
                this.__pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf = other.__pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf;
                this.__pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X = other.__pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X;
            }

            protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BwEetSfMDC0N7Vqbu22Orm", in __p_BwEetSfMDC0N7Vqbu22Orm), n1.CompilationHelper.GetValueOrExisting(values, "__p_FApVKj8BXz8QJBw1XjR93X", in __p_FApVKj8BXz8QJBw1XjR93X), n1.CompilationHelper.GetValueOrExisting(values, "__p_BWWCUxA4cHGOs1rt79OHbq", in __p_BWWCUxA4cHGOs1rt79OHbq), n1.CompilationHelper.GetValueOrExisting(values, "__p_BkHEGDb7TQdPX3TCkdQdnv", in __p_BkHEGDb7TQdPX3TCkdQdnv), n1.CompilationHelper.GetValueOrExisting(values, "__p_QQhVSj6xwgKLYeb5vrGyUF", in __p_QQhVSj6xwgKLYeb5vrGyUF), n1.CompilationHelper.GetValueOrExisting(values, "__p_ABswv4jlkUbLVaAbjl0olf", in __p_ABswv4jlkUbLVaAbjl0olf), n1.CompilationHelper.GetValueOrExisting(values, "__p_VPq9et9dCQTPblkdKJ4Cwp", in __p_VPq9et9dCQTPblkdKJ4Cwp), n1.CompilationHelper.GetValueOrExisting(values, "__p_RfnWsbW5paiMCMGB0ViQkw", in __p_RfnWsbW5paiMCMGB0ViQkw), n1.CompilationHelper.GetValueOrExisting(values, "__p_I0fvU963JWPMdidvrw1vNU", in __p_I0fvU963JWPMdidvrw1vNU), n1.CompilationHelper.GetValueOrExisting(values, "__p_UvrIsMTD504Pz7QcI3lH3c", in __p_UvrIsMTD504Pz7QcI3lH3c), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c", in __pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv", in __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp", in __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf", in __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X", in __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X));
            }

            internal __F1Qepe36uBuQJFNJD1O3Zc __WITH__(n3.FunctionParameters_MeshSurface_IyKq68Yg5L9LhU3pt9kDRT __p_BwEetSfMDC0N7Vqbu22Orm, n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_FApVKj8BXz8QJBw1XjR93X, n18.ToVector3_BiGMZixIzsHMmgVTnvnygH<float> __p_BWWCUxA4cHGOs1rt79OHbq, n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_BkHEGDb7TQdPX3TCkdQdnv, n28.FunctionGradient_EJ8X6U6YJ9EMNwQhIeY9Zl<n5.Vector3> __p_QQhVSj6xwgKLYeb5vrGyUF, n26.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_ABswv4jlkUbLVaAbjl0olf, n26.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n5.Vector3> __p_VPq9et9dCQTPblkdKJ4Cwp, n18.ToVector3_BiGMZixIzsHMmgVTnvnygH<float> __p_RfnWsbW5paiMCMGB0ViQkw, n26.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector3> __p_I0fvU963JWPMdidvrw1vNU, n10.Invoke_C<float> __p_UvrIsMTD504Pz7QcI3lH3c, n13.Spread<n6.AbstractGpuValue> __pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf, n13.Spread<n6.GpuValue<n5.Vector3>> __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X)
            {
                __F1Qepe36uBuQJFNJD1O3Zc that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_BwEetSfMDC0N7Vqbu22Orm != this.__p_BwEetSfMDC0N7Vqbu22Orm || __p_FApVKj8BXz8QJBw1XjR93X != this.__p_FApVKj8BXz8QJBw1XjR93X || __p_BWWCUxA4cHGOs1rt79OHbq != this.__p_BWWCUxA4cHGOs1rt79OHbq || __p_BkHEGDb7TQdPX3TCkdQdnv != this.__p_BkHEGDb7TQdPX3TCkdQdnv || __p_QQhVSj6xwgKLYeb5vrGyUF != this.__p_QQhVSj6xwgKLYeb5vrGyUF || __p_ABswv4jlkUbLVaAbjl0olf != this.__p_ABswv4jlkUbLVaAbjl0olf || __p_VPq9et9dCQTPblkdKJ4Cwp != this.__p_VPq9et9dCQTPblkdKJ4Cwp || __p_RfnWsbW5paiMCMGB0ViQkw != this.__p_RfnWsbW5paiMCMGB0ViQkw || __p_I0fvU963JWPMdidvrw1vNU != this.__p_I0fvU963JWPMdidvrw1vNU || __p_UvrIsMTD504Pz7QcI3lH3c != this.__p_UvrIsMTD504Pz7QcI3lH3c || __pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c != this.__pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c || __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv != this.__pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv || __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp != this.__pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp || __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf != this.__pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf || __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X != this.__pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X ? new __F1Qepe36uBuQJFNJD1O3Zc(this)
                    {__p_BwEetSfMDC0N7Vqbu22Orm = __p_BwEetSfMDC0N7Vqbu22Orm, __p_FApVKj8BXz8QJBw1XjR93X = __p_FApVKj8BXz8QJBw1XjR93X, __p_BWWCUxA4cHGOs1rt79OHbq = __p_BWWCUxA4cHGOs1rt79OHbq, __p_BkHEGDb7TQdPX3TCkdQdnv = __p_BkHEGDb7TQdPX3TCkdQdnv, __p_QQhVSj6xwgKLYeb5vrGyUF = __p_QQhVSj6xwgKLYeb5vrGyUF, __p_ABswv4jlkUbLVaAbjl0olf = __p_ABswv4jlkUbLVaAbjl0olf, __p_VPq9et9dCQTPblkdKJ4Cwp = __p_VPq9et9dCQTPblkdKJ4Cwp, __p_RfnWsbW5paiMCMGB0ViQkw = __p_RfnWsbW5paiMCMGB0ViQkw, __p_I0fvU963JWPMdidvrw1vNU = __p_I0fvU963JWPMdidvrw1vNU, __p_UvrIsMTD504Pz7QcI3lH3c = __p_UvrIsMTD504Pz7QcI3lH3c, __pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c = __pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c, __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv = __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv, __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp = __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp, __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf = __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf, __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X = __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X} : that_0;
                else
                {
                    this.__p_BwEetSfMDC0N7Vqbu22Orm = __p_BwEetSfMDC0N7Vqbu22Orm;
                    this.__p_FApVKj8BXz8QJBw1XjR93X = __p_FApVKj8BXz8QJBw1XjR93X;
                    this.__p_BWWCUxA4cHGOs1rt79OHbq = __p_BWWCUxA4cHGOs1rt79OHbq;
                    this.__p_BkHEGDb7TQdPX3TCkdQdnv = __p_BkHEGDb7TQdPX3TCkdQdnv;
                    this.__p_QQhVSj6xwgKLYeb5vrGyUF = __p_QQhVSj6xwgKLYeb5vrGyUF;
                    this.__p_ABswv4jlkUbLVaAbjl0olf = __p_ABswv4jlkUbLVaAbjl0olf;
                    this.__p_VPq9et9dCQTPblkdKJ4Cwp = __p_VPq9et9dCQTPblkdKJ4Cwp;
                    this.__p_RfnWsbW5paiMCMGB0ViQkw = __p_RfnWsbW5paiMCMGB0ViQkw;
                    this.__p_I0fvU963JWPMdidvrw1vNU = __p_I0fvU963JWPMdidvrw1vNU;
                    this.__p_UvrIsMTD504Pz7QcI3lH3c = __p_UvrIsMTD504Pz7QcI3lH3c;
                    this.__pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c = __pin_group_Parameters_In_UvrIsMTD504Pz7QcI3lH3c;
                    this.__pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv = __pin_group_Input_In_BkHEGDb7TQdPX3TCkdQdnv;
                    this.__pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp = __pin_group_Input_In_VPq9et9dCQTPblkdKJ4Cwp;
                    this.__pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf = __pin_group_Input_In_ABswv4jlkUbLVaAbjl0olf;
                    this.__pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X = __pin_group_Input_In_FApVKj8BXz8QJBw1XjR93X;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 316214U, DocumentId = "DlkLpgWeKDyMtsyzTWkBms", PersistentId = "Irt0YFriJdfL2EJnYYiPxv", Name = "Fuse_GeometryApplication_Irt0YFriJdfL2EJnYYiPxv")]
    [n2.SerializableAttribute]
    public class Fuse_GeometryApplication_Irt0YFriJdfL2EJnYYiPxv : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Fuse_GeometryApplication_Irt0YFriJdfL2EJnYYiPxv Create(n1.NodeContext Node_Context)
        {
            var instance = new Fuse_GeometryApplication_Irt0YFriJdfL2EJnYYiPxv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Fuse_GeometryApplication_Irt0YFriJdfL2EJnYYiPxv CreateDefault()
        {
            var instance = new Fuse_GeometryApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Fuse_GeometryApplication_Irt0YFriJdfL2EJnYYiPxv Update()
        {
            return this;
        }

        public n3.Fuse_GeometryApplication_Irt0YFriJdfL2EJnYYiPxv __Create__(n1.NodeContext Node_Context)
        {
            n23.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.Fuse_GeometryApplication_Irt0YFriJdfL2EJnYYiPxv __CreateDefault__()
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

        public Fuse_GeometryApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Fuse_GeometryApplication_Irt0YFriJdfL2EJnYYiPxv(Fuse_GeometryApplication_Irt0YFriJdfL2EJnYYiPxv other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n8.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal Fuse_GeometryApplication_Irt0YFriJdfL2EJnYYiPxv __WITH__()
        {
            return this;
        }
    }
}

namespace _Fuse_Geometry_
{
    public struct __AdaptiveImplementations__DlkLpgWeKDyMtsyzTWkBms : n32.IAdaptiveCreateDefault<n6.GpuValue<n5.Vector3>>
    {
        public void CreateDefault(out n6.GpuValue<n5.Vector3> Output_Out)
        {
            n31._Operations_.CreateDefault_Generic<n6.GpuValue<n5.Vector3>>(Output_Out: out n6.GpuValue<n5.Vector3> Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}