extern alias e22;
extern alias e24;
extern alias e31;
extern alias e26;
extern alias e3;
extern alias e2;
extern alias e29;
extern alias e4;

using n36 = e26::Stride.Graphics;
using n44 = _CoreLibBasics_._3D.Matrix;
using n24 = _VL_Stride_Graphics_.Stride.Utils.Advanced;
using n42 = _CoreLibBasics_.Control.Advanced;
using n18 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Core.Mathematics.Advanced;
using n23 = e2::VL.Lib.Collections;
using n35 = e3::VL.Lib.Primitive.CacheRegion;
using n17 = _CoreLibBasics_.Primitive.Object.Advanced;
using n32 = _CoreLibBasics_.Control;
using n43 = _CoreLibBasics_.Math.Generic.Advanced;
using n48 = _System_Memory_.System.Advanced.Adaptive;
using n33 = _CoreLibBasics_.Animation.IClock.Advanced;
using n20 = e3::VL.Lib.Reactive;
using n4 = _VL_Stride_Rendering_Instancer_.Stride.Rendering;
using n39 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Rendering.Model.Advanced;
using n9 = e31::VL.Stride.Graphics;
using n41 = _VL_Stride_Rendering_Instancer_;
using n16 = global::System.Collections.Generic;
using n37 = _VL_Stride_Rendering_.Stride.Utils.Advanced;
using n49 = _CoreLibBasics_.Math.Adaptive;
using n29 = _VL_Stride_Engine_.Stride.Rendering;
using n5 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n47 = e3::VL.Lib.Primitive;
using n13 = global::System.Threading;
using n12 = e24::Stride.Engine;
using n19 = e3::VL.Lib.Mathematics;
using n1 = e2::VL.Core;
using n10 = e31::VL.Stride.Rendering;
using n3 = e22::Stride.Graphics;
using n2 = global::System;
using n21 = _VL_Reactive_.Reactive.AsyncTask;
using n14 = e4::Stride.Core.Mathematics;
using n31 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.VertexDeclaration.Advanced;
using n28 = _VL_Stride_Graphics_.Stride.Buffers;
using n7 = e3::VL.Lib.Primitive.Object;
using n6 = e2::VL.Core.CompilerServices;
using n45 = e3::VL.Lib;
using n11 = _VL_Collections_.Collections.Mutable.MutableArray.Advanced;
using n22 = _VL_Reactive_.Reactive.HoldLatest;
using n30 = _VL_Stride_Engine_.Stride;
using n34 = e2::VL.Lib.Animation;
using n40 = _VL_Stride_Engine_.Stride.Utils.Advanced;
using n8 = e29::Stride.Rendering;
using n15 = _VL_Collections_.Collections.Sequence;
using n25 = global::System.Runtime.CompilerServices;
using n27 = _VL_Collections_.Collections.Spread;
using n46 = _CoreLibBasics_.Primitive.Advanced;
using n38 = _CoreLibBasics_._3D.Vector4;
using n26 = _CoreLibBasics_._3D.Vector3;

namespace _VL_Stride_Rendering_Instancer_.Stride.Rendering
{
    [n1.ElementAttribute(TracingId = 22386U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "FBHuNRR7L9ALXC8p0GP3eB", Name = "StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB")]
    [n2.SerializableAttribute]
    public class StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T[]>
        {
            var instance = new StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T> CreateDefault<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T[]>
        {
            var instance = new StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n4.StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T> Update<AdM>(n8.Mesh Mesh_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, [n6.SerializedDefaultValueAttribute("100000", false)] int Max_Instance_Count_In, n8.Material Material_In, T[] Instance_Transformations_In, n14.Matrix Transformation_In, out n12.Entity Entity_Out, out int Vertex_Count_Out)
            where AdM : struct, n24.IAdaptiveSetGraphicsData<T[]>
        {
            var w_0 = default(AdM);
            n3.PrimitiveType __pad_FwaP69AYYNiNsVEEN3nAm4_1 = __slot_FwaP69AYYNiNsVEEN3nAm4;
            n3.PrimitiveType __pad_BjQCtqINP9xMTpLPb1A4yn_2 = __slot_BjQCtqINP9xMTpLPb1A4yn;
            bool __pad_NfZmTOrrk3GNfQ470J2Dma_3 = __slot_NfZmTOrrk3GNfQ470J2Dma;
            string __pad_EMwZe5JLMYxO39XVkdWaho_4 = __slot_EMwZe5JLMYxO39XVkdWaho;
            string __pad_AhXI63kyHHkOH2jelo9LY6_5 = __slot_AhXI63kyHHkOH2jelo9LY6;
            n7.ObjectHelpers.IsAssigned(x: Mesh_In, result: out bool Result_6, notAssigned: out bool Not_Assigned_7);
            n8.Mesh __auto_8;
            var state_9 = n1.CompilationHelper.Restore<__KlDK8r8CxyZMcOFG1If084>(this.__if_M9iQKD16APBP175imqmL5R, __GetContext__());
            if (Not_Assigned_7)
            {
                if (state_9 == null)
                {
                    state_9 = new __KlDK8r8CxyZMcOFG1If084(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_10 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BoxMesh", "Stride.Models.Meshes");
                    state_9.__p_UX0PvcaX7j0Ps1JM0VwWU3 = node_10;
                }

                n1.CompilationHelper.ReadPin(state_9.__p_UX0PvcaX7j0Ps1JM0VwWU3.Outputs[0], out n8.Mesh out_11);
                __auto_8 = out_11;
                if (state_9.__GetContext__().IsImmutable)
                    state_9 = state_9.__p_UX0PvcaX7j0Ps1JM0VwWU3 != state_9.__p_UX0PvcaX7j0Ps1JM0VwWU3 ? new __KlDK8r8CxyZMcOFG1If084(state_9)
                    {__p_UX0PvcaX7j0Ps1JM0VwWU3 = state_9.__p_UX0PvcaX7j0Ps1JM0VwWU3} : state_9;
                else
                {
                    state_9.__p_UX0PvcaX7j0Ps1JM0VwWU3 = state_9.__p_UX0PvcaX7j0Ps1JM0VwWU3;
                }
            }
            else
            {
                __auto_8 = Mesh_In;
            }

            var Output_15 = this.__p_Sl9gmDMFzcDPX7btyM5wuz.Update(Mesh_In: __auto_8, Mesh_Draw_Out: out n8.MeshDraw Mesh_Draw_12, Has_Tangent_Out: out bool Has_Tangent_13, Draw_Count_Out: out int Draw_Count_14);
            var Output_16 = Draw_Count_14 * Max_Instance_Count_In;
            var State_Output_18 = this.__p_K30vX2JIRdrOEEQwSBQY10.Update(Output_Out: out n3.VertexDeclaration Output_17);
            var Vertex_Stride_19 = Output_17.VertexStride;
            n9.IGraphicsDataProvider Initial_Data_20 = default(n9.IGraphicsDataProvider);
            bool Is_Unordered_Access_21 = true;
            n9.StructuredBufferType Structured_Buffer_Type_22 = n1.CompilationHelper.Deserialize<n9.StructuredBufferType>("StructuredBuffer", false, null, null);
            bool Allow_Raw_Views_23 = false;
            bool Recreate_24 = false;
            var State_Output_27 = this.__p_Pik1hNA6CYgLdYApdOVPVl.Update(Element_Count_In: Output_16, Element_Size_In_Bytes_In: Vertex_Stride_19, Initial_Data_In: Initial_Data_20, Is_Unordered_Access_In: Is_Unordered_Access_21, Structured_Buffer_Type_In: Structured_Buffer_Type_22, Is_Stream_Output_In: __pad_NfZmTOrrk3GNfQ470J2Dma_3, Allow_Raw_Views_In: Allow_Raw_Views_23, Recreate_In: Recreate_24, Output_Out: out n3.Buffer Output_25, Has_Changed_Out: out bool Has_Changed_26);
            int Element_Size_In_Bytes_28 = 0;
            int Offset_In_Bytes_29 = 0;
            bool Is_Structured_Buffer_30 = false;
            bool Is_Vertex_Buffer_31 = false;
            bool Is_Index_Buffer_32 = false;
            bool Allow_Raw_Views_33 = false;
            bool Recreate_34 = false;
            bool Apply_35 = true;
            var State_Output_38 = this.__p_AgLdJpYx4ohM24BRpVck8U.Update<AdM>(Input_In: Instance_Transformations_In, Element_Size_In_Bytes_In: Element_Size_In_Bytes_28, Offset_In_Bytes_In: Offset_In_Bytes_29, Is_Structured_Buffer_In: Is_Structured_Buffer_30, Is_Vertex_Buffer_In: Is_Vertex_Buffer_31, Is_Index_Buffer_In: Is_Index_Buffer_32, Allow_Raw_Views_In: Allow_Raw_Views_33, Recreate_In: Recreate_34, Apply_In: Apply_35, Output_Out: out n3.Buffer Output_36, Has_Changed_Out: out bool Has_Changed_37);
            n1.CompilationHelper.WritePin(this.__p_RrLpUEnP1jHMtQrcOlloKy.Inputs[0], ref Output_36);
            n1.CompilationHelper.ReadPin(this.__p_RrLpUEnP1jHMtQrcOlloKy.Outputs[0], out n10.IEffect out_39);
            n11._Operations_.Length<T>(Input_In: Instance_Transformations_In, Output_Out: out T[] Output_40, Length_Out: out int Length_41);
            bool Update_42 = true;
            var Output_43 = this.__p_Fk69ptSPXAiQCGG9JKQBfK;
            if (Update_42)
            {
                Output_43 = this.__p_Fk69ptSPXAiQCGG9JKQBfK.Update(Topology_In: __pad_FwaP69AYYNiNsVEEN3nAm4_1, Stream_Out_Buffer_In: Output_25, Effect_Instance_In: out_39, Instance_Count_In: Length_41, Mesh_Draw_In: Mesh_Draw_12);
            }

            var Output_45 = this.__p_IpTgJtfhVBpOIAiPoMMZ03.GetValue(Value_Out: out int Value_44);
            var Output_46 = Draw_Count_14 * Value_44;
            var Output_48 = this.__p_C92R2lWxcjpMp2fL4EReyK.Update(Material_In: Material_In, Primitive_Type_In: __pad_BjQCtqINP9xMTpLPb1A4yn_2, Transformation_In: Transformation_In, Vertex_Buffer_In: Output_25, Vertex_Declaration_In: Output_17, Enabled_In: Enabled_In, Vertex_Count_In: Output_46, Entity_Out: out n12.Entity Entity_47);
            var Output_50 = this.__p_EKy8KJ6D6rIQP1vxlGAoln.GetValue(Value_Out: out bool Value_49);
            bool Abort_51 = false;
            var __fallback___52 = n1.ServiceRegistry.Current;
            n21._Operations_.Update_H<n14.BoundingBox, n2.Object>(Input_In: this.__p_AzGGOnslQHgM5XvM4edg4v, Trigger_In: Value_49, Abort_In: Abort_51, Update_In: (n2.Object s_55, n13.CancellationToken Input_1_In_56) =>
            {
                using var __current_53 = __fallback___52.MakeCurrentIfNone();
                var state_54 = n1.CompilationHelper.Restore<__VVEBQHVkzTVLbjPJAdpnB7>(s_55, __GetContext__());
                n16.IEnumerable<n14.Matrix> Default_57 = n15._Operations_.CreateDefault<n14.Matrix>();
                n17._Operations_.CastAs<n16.IEnumerable<n14.Matrix>>(Input_In: Instance_Transformations_In, Default_In: Default_57, Result_Out: out n16.IEnumerable<n14.Matrix> Result_58, Success_Out: out bool Success_59);
                n16.IEnumerable<n14.Matrix> __pad_PuFKxd0ytmXOOeZDMxUJR1_60 = Result_58;
                n18._Operations_.CreateUnitBoundingBox(Output_Out: out n14.BoundingBox Output_61);
                n14.BoundingBox __auto_62;
                if (Success_59)
                {
                    n14.BoundingBox accumulator_65 = default(n14.BoundingBox);
                    var i_67 = 0;
                    foreach (var item_64 in __pad_PuFKxd0ytmXOOeZDMxUJR1_60)
                    {
                        var splicer_66 = item_64;
                        var i_local_68 = i_67;
                        var Translation_Vector_70 = splicer_66.TranslationVector;
                        var One_71 = n14.Vector3.One;
                        var Result_72 = n19.AlignedBoxExtensions.CreateCenterSize(center: ref Translation_Vector_70, size: ref One_71);
                        n14.BoundingBox.Merge(value1: ref Result_72, value2: ref accumulator_65, result: out n14.BoundingBox Output_73);
                        accumulator_65 = Output_73;
                        i_67++;
                    }

                    __auto_62 = accumulator_65;
                }
                else
                {
                    __auto_62 = Output_61;
                }

                if (state_54.__GetContext__().IsImmutable)
                    state_54 = Result_58 != state_54.__slot_PuFKxd0ytmXOOeZDMxUJR1 ? new __VVEBQHVkzTVLbjPJAdpnB7(state_54)
                    {__slot_PuFKxd0ytmXOOeZDMxUJR1 = Result_58} : state_54;
                else
                {
                    state_54.__slot_PuFKxd0ytmXOOeZDMxUJR1 = Result_58;
                }

                return n2.Tuple.Create<n2.Object, n14.BoundingBox>(state_54, __auto_62);
            }

            , Create_In: () =>
            {
                using var __current_74 = __fallback___52.MakeCurrentIfNone();
                var state_54 = new __VVEBQHVkzTVLbjPJAdpnB7(__GetContext__(), n1.VLObject.NewIdentity())
                {__slot_PuFKxd0ytmXOOeZDMxUJR1 = n15._Operations_.CreateDefault<n14.Matrix>()};
                return state_54;
            }

            , Output_Out: out n20.AsyncTask<n14.BoundingBox> Output_75, Result_Out: out n2.IObservable<n14.BoundingBox> Result_76, In_Progress_Out: out bool In_Progress_77);
            bool Reset_78 = false;
            bool Update_79 = true;
            var Output_80 = this.__p_HsiNjGnaf8oO5LkWShBzhZ;
            if (Update_79)
            {
                n22._Operations_.Update_H<n14.BoundingBox>(Input_In: this.__p_HsiNjGnaf8oO5LkWShBzhZ, Async_Notifications_In: Result_76, Reset_In: Reset_78, Output_Out: out Output_80);
            }

            n22._Operations_.GetData_H<n14.BoundingBox>(Input_In: Output_80, Output_Out: out n20.HoldLatest<n14.BoundingBox> Output_81, Value_Out: out n14.BoundingBox Value_82, On_Data_Out: out bool On_Data_83);
            var Output_84 = Output_48;
            if (On_Data_83)
            {
                Output_84 = Output_48.SetBoundingBox(Bounding_Box_In: Value_82);
            }

            bool SetValue_85 = true;
            var Output_86 = Output_45;
            if (SetValue_85)
            {
                Output_86 = Output_45.SetValue(Value_In: Length_41);
            }

            n8.IGraphicsRendererBase Input_87 = (n8.IGraphicsRendererBase)Output_43;
            n10.DrawerRenderStage Render_Stage_88 = __c_DuKZTgu3wM3PUAEBL5YwBL;
            bool Single_Call_Per_Frame_89 = false;
            bool SetupRendering_90 = true;
            var Output_91 = this.__p_TPv3FYpjnrHLfSK49Gi7KL;
            if (SetupRendering_90)
            {
                Output_91 = this.__p_TPv3FYpjnrHLfSK49Gi7KL.SetupRendering(Input_In: Input_87, Render_Stage_In: Render_Stage_88, Single_Call_Per_Frame_In: Single_Call_Per_Frame_89);
            }

            bool SetName_92 = true;
            var Output_93 = Output_91;
            if (SetName_92)
            {
                Output_93 = Output_91.SetName(Name_In: __pad_EMwZe5JLMYxO39XVkdWaho_4);
            }

            bool SetEnabled_94 = true;
            var Output_95 = Output_93;
            if (SetEnabled_94)
            {
                Output_95 = Output_93.SetEnabled(Enabled_In: Enabled_In);
            }

            var State_Output_97 = Output_95.Update(Output_Out: out n12.Entity Output_96);
            bool SetChildren_98 = true;
            var builder_99 = n6.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8, 2);
            builder_99.Add(Output_96);
            builder_99.Add(Entity_47);
            var __pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8_100 = builder_99.Commit();
            var Output_101 = this.__p_Mqpo2zCE1uyMDUj0hjTWm8;
            if (SetChildren_98)
            {
                Output_101 = this.__p_Mqpo2zCE1uyMDUj0hjTWm8.SetChildren(Child_In: __pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8_100);
            }

            bool SetName_102 = true;
            var Output_103 = Output_101;
            if (SetName_102)
            {
                Output_103 = Output_101.SetName(Name_In: __pad_AhXI63kyHHkOH2jelo9LY6_5);
            }

            var State_Output_105 = Output_103.Update(Output_Out: out n12.Entity Output_104);
            var Output_108 = this.__p_LYKVdsFMChTO0L21jVuOeI.Update(Value_In: Instance_Transformations_In, Result_Out: out bool Result_106, Unchanged_Out: out bool Unchanged_107);
            float Time_109 = 1F;
            bool Retriggerable_110 = false;
            bool Reset_111 = false;
            var Output_114 = this.__p_OFp8JdoWuZUOXalQi37qBD.Update(Set_In: Result_106, Time_In: Time_109, Retriggerable_In: Retriggerable_110, Reset_In: Reset_111, Value_Out: out bool Value_112, Inverse_Output_Out: out bool Inverse_Output_113);
            var Output_117 = this.__p_CmxSHi24Yb3MY0DqaTolM1.Update(Value_In: Value_112, Up_Edge_Out: out bool Up_Edge_115, Down_Edge_Out: out bool Down_Edge_116);
            bool SetValue_118 = true;
            var Output_119 = Output_50;
            if (SetValue_118)
            {
                Output_119 = Output_50.SetValue(Value_In: Up_Edge_115);
            }

            var Maximum_120 = Value_82.Maximum;
            n14.Vector3 __pad_QniUHjPL2auMFnFNR9c1Lt_121 = Maximum_120;
            Entity_Out = Output_104;
            Vertex_Count_Out = Output_46;
            n4.StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T> that_122 = this;
            if (this.__GetContext__().IsImmutable)
                that_122 = state_9 != this.__if_M9iQKD16APBP175imqmL5R || Output_15 != this.__p_Sl9gmDMFzcDPX7btyM5wuz || State_Output_18 != this.__p_K30vX2JIRdrOEEQwSBQY10 || State_Output_27 != this.__p_Pik1hNA6CYgLdYApdOVPVl || State_Output_38 != this.__p_AgLdJpYx4ohM24BRpVck8U || this.__p_RrLpUEnP1jHMtQrcOlloKy != this.__p_RrLpUEnP1jHMtQrcOlloKy || Output_43 != this.__p_Fk69ptSPXAiQCGG9JKQBfK || Output_86 != this.__p_IpTgJtfhVBpOIAiPoMMZ03 || Output_84 != this.__p_C92R2lWxcjpMp2fL4EReyK || Output_119 != this.__p_EKy8KJ6D6rIQP1vxlGAoln || Output_75 != this.__p_AzGGOnslQHgM5XvM4edg4v || Output_81 != this.__p_HsiNjGnaf8oO5LkWShBzhZ || State_Output_97 != this.__p_TPv3FYpjnrHLfSK49Gi7KL || __pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8_100 != this.__pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8 || State_Output_105 != this.__p_Mqpo2zCE1uyMDUj0hjTWm8 || Output_108 != this.__p_LYKVdsFMChTO0L21jVuOeI || Output_114 != this.__p_OFp8JdoWuZUOXalQi37qBD || Output_117 != this.__p_CmxSHi24Yb3MY0DqaTolM1 || Maximum_120 != this.__slot_QniUHjPL2auMFnFNR9c1Lt ? new StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T>(this)
                {__if_M9iQKD16APBP175imqmL5R = state_9, __p_Sl9gmDMFzcDPX7btyM5wuz = Output_15, __p_K30vX2JIRdrOEEQwSBQY10 = State_Output_18, __p_Pik1hNA6CYgLdYApdOVPVl = State_Output_27, __p_AgLdJpYx4ohM24BRpVck8U = State_Output_38, __p_RrLpUEnP1jHMtQrcOlloKy = this.__p_RrLpUEnP1jHMtQrcOlloKy, __p_Fk69ptSPXAiQCGG9JKQBfK = Output_43, __p_IpTgJtfhVBpOIAiPoMMZ03 = Output_86, __p_C92R2lWxcjpMp2fL4EReyK = Output_84, __p_EKy8KJ6D6rIQP1vxlGAoln = Output_119, __p_AzGGOnslQHgM5XvM4edg4v = Output_75, __p_HsiNjGnaf8oO5LkWShBzhZ = Output_81, __p_TPv3FYpjnrHLfSK49Gi7KL = State_Output_97, __pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8 = __pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8_100, __p_Mqpo2zCE1uyMDUj0hjTWm8 = State_Output_105, __p_LYKVdsFMChTO0L21jVuOeI = Output_108, __p_OFp8JdoWuZUOXalQi37qBD = Output_114, __p_CmxSHi24Yb3MY0DqaTolM1 = Output_117, __slot_QniUHjPL2auMFnFNR9c1Lt = Maximum_120} : that_122;
            else
            {
                this.__if_M9iQKD16APBP175imqmL5R = state_9;
                this.__p_Sl9gmDMFzcDPX7btyM5wuz = Output_15;
                this.__p_K30vX2JIRdrOEEQwSBQY10 = State_Output_18;
                this.__p_Pik1hNA6CYgLdYApdOVPVl = State_Output_27;
                this.__p_AgLdJpYx4ohM24BRpVck8U = State_Output_38;
                this.__p_RrLpUEnP1jHMtQrcOlloKy = this.__p_RrLpUEnP1jHMtQrcOlloKy;
                this.__p_Fk69ptSPXAiQCGG9JKQBfK = Output_43;
                this.__p_IpTgJtfhVBpOIAiPoMMZ03 = Output_86;
                this.__p_C92R2lWxcjpMp2fL4EReyK = Output_84;
                this.__p_EKy8KJ6D6rIQP1vxlGAoln = Output_119;
                this.__p_AzGGOnslQHgM5XvM4edg4v = Output_75;
                this.__p_HsiNjGnaf8oO5LkWShBzhZ = Output_81;
                this.__p_TPv3FYpjnrHLfSK49Gi7KL = State_Output_97;
                this.__pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8 = __pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8_100;
                this.__p_Mqpo2zCE1uyMDUj0hjTWm8 = State_Output_105;
                this.__p_LYKVdsFMChTO0L21jVuOeI = Output_108;
                this.__p_OFp8JdoWuZUOXalQi37qBD = Output_114;
                this.__p_CmxSHi24Yb3MY0DqaTolM1 = Output_117;
                this.__slot_QniUHjPL2auMFnFNR9c1Lt = Maximum_120;
            }

            return that_122;
        }

        public n4.StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T[]>
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            string __pad_KT91ezfzY9oPV7ZcdEP4gE_1 = __slot_KT91ezfzY9oPV7ZcdEP4gE;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "C92R2lWxcjpMp2fL4EReyK", 25164U);
            var Output_3 = n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v.Create(Node_Context: Node_Context_2);
            bool SetName_4 = true;
            var Output_5 = Output_3;
            if (SetName_4)
            {
                Output_5 = Output_3.SetName(Name_In: __pad_KT91ezfzY9oPV7ZcdEP4gE_1);
            }

            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "AgLdJpYx4ohM24BRpVck8U", 22389U);
            var Output_7 = n28.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T[]>.Create(Node_Context: Node_Context_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "Pik1hNA6CYgLdYApdOVPVl", 25109U);
            var Output_9 = n28.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "Sl9gmDMFzcDPX7btyM5wuz", 25130U);
            var Output_11 = n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO.Create(Node_Context: Node_Context_10);
            var node_12 = n1.CompilationHelper.CreateNodeById(Node_Context, "InstancedMeshStreamOutShader", "Stride.Rendering.DrawShaders");
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "Fk69ptSPXAiQCGG9JKQBfK", 25212U);
            var Output_14 = n4.MeshDrawerStreamOut_C.Create(Node_Context: Node_Context_13);
            n1.NodeContext Node_Context_15 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "TPv3FYpjnrHLfSK49Gi7KL", 25231U);
            var Output_16 = n29.RenderEntity_HYRtmvUkSb6PheJUi3kp3r.Create(Node_Context: Node_Context_15);
            n1.NodeContext Node_Context_17 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "Mqpo2zCE1uyMDUj0hjTWm8", 25267U);
            var Output_18 = n30.Group_TqwCZl6Gra4OmgvUg1POgm.Create(Node_Context: Node_Context_17);
            n1.NodeContext Node_Context_19 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "K30vX2JIRdrOEEQwSBQY10", 25286U);
            var Output_20 = n31.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc.Create(Node_Context: Node_Context_19);
            n1.NodeContext Node_Context_21 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "IpTgJtfhVBpOIAiPoMMZ03", 25340U);
            int Initial_Value_22 = 0;
            var Output_23 = n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<int>.Create(Node_Context: Node_Context_21, Initial_Value_In: Initial_Value_22);
            n1.NodeContext Node_Context_24 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "AzGGOnslQHgM5XvM4edg4v", 25377U);
            n21._Operations_.Create_H<n14.BoundingBox>(Node_Context: Node_Context_24, Output_Out: out n20.AsyncTask<n14.BoundingBox> Output_25);
            n1.NodeContext Node_Context_26 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "HsiNjGnaf8oO5LkWShBzhZ", 25521U);
            n14.BoundingBox Initial_Result_27 = default(n14.BoundingBox);
            n22._Operations_.Create_H<n14.BoundingBox>(Node_Context: Node_Context_26, Initial_Result_In: Initial_Result_27, Output_Out: out n20.HoldLatest<n14.BoundingBox> Output_28);
            n1.NodeContext Node_Context_29 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "LYKVdsFMChTO0L21jVuOeI", 25533U);
            bool Changed_On_Create_30 = true;
            var Output_31 = n32.Changed_A8JGbead2bxNdnPybiEqVS<T[]>.Create<AdM>(Node_Context: Node_Context_29, Changed_On_Create_In: Changed_On_Create_30);
            n1.NodeContext Node_Context_32 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "OFp8JdoWuZUOXalQi37qBD", 25547U);
            n34.IClock Clock_33 = n33._Operations_.CreateDefault();
            var Output_34 = n32.MonoFlop_GeOV3KtNF5BPYMkYFPPAst.Create(Node_Context: Node_Context_32, Clock_In: Clock_33);
            n1.NodeContext Node_Context_35 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "CmxSHi24Yb3MY0DqaTolM1", 25566U);
            var Output_36 = n32.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_35);
            n1.NodeContext Node_Context_37 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "EKy8KJ6D6rIQP1vxlGAoln", 25597U);
            bool Initial_Value_38 = false;
            var Output_39 = n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool>.Create(Node_Context: Node_Context_37, Initial_Value_In: Initial_Value_38);
            n4.StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T> that_40 = this;
            this.__slot_QniUHjPL2auMFnFNR9c1Lt = n26._Operations_.CreateDefault();
            this.__pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8 = n27._Operations_.CreateDefault<n12.Entity>();
            this.__p_C92R2lWxcjpMp2fL4EReyK = Output_5;
            this.__p_AgLdJpYx4ohM24BRpVck8U = Output_7;
            this.__p_Pik1hNA6CYgLdYApdOVPVl = Output_9;
            this.__p_Sl9gmDMFzcDPX7btyM5wuz = Output_11;
            this.__p_RrLpUEnP1jHMtQrcOlloKy = node_12;
            this.__p_Fk69ptSPXAiQCGG9JKQBfK = Output_14;
            this.__p_TPv3FYpjnrHLfSK49Gi7KL = Output_16;
            this.__p_Mqpo2zCE1uyMDUj0hjTWm8 = Output_18;
            this.__p_K30vX2JIRdrOEEQwSBQY10 = Output_20;
            this.__p_IpTgJtfhVBpOIAiPoMMZ03 = Output_23;
            this.__p_AzGGOnslQHgM5XvM4edg4v = Output_25;
            this.__p_HsiNjGnaf8oO5LkWShBzhZ = Output_28;
            this.__p_LYKVdsFMChTO0L21jVuOeI = Output_31;
            this.__p_OFp8JdoWuZUOXalQi37qBD = Output_34;
            this.__p_CmxSHi24Yb3MY0DqaTolM1 = Output_36;
            this.__p_EKy8KJ6D6rIQP1vxlGAoln = Output_39;
            this.__if_M9iQKD16APBP175imqmL5R = default(n2.Object);
            return that_40;
        }

        public n4.StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T> __CreateDefault__<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T[]>
        {
            var w_0 = default(AdM);
            n4.StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T> that_1 = this;
            this.__slot_QniUHjPL2auMFnFNR9c1Lt = n26._Operations_.CreateDefault();
            this.__pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8 = n27._Operations_.CreateDefault<n12.Entity>();
            this.__if_M9iQKD16APBP175imqmL5R = default(n2.Object);
            this.__p_Sl9gmDMFzcDPX7btyM5wuz = n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO.CreateDefault();
            this.__p_K30vX2JIRdrOEEQwSBQY10 = n31.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc.CreateDefault();
            this.__p_Pik1hNA6CYgLdYApdOVPVl = n28.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM.CreateDefault();
            this.__p_AgLdJpYx4ohM24BRpVck8U = n28.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T[]>.CreateDefault();
            this.__p_RrLpUEnP1jHMtQrcOlloKy = default(n1.IVLNode);
            this.__p_Fk69ptSPXAiQCGG9JKQBfK = n4.MeshDrawerStreamOut_C.CreateDefault();
            this.__p_IpTgJtfhVBpOIAiPoMMZ03 = n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<int>.CreateDefault();
            this.__p_C92R2lWxcjpMp2fL4EReyK = n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v.CreateDefault();
            this.__p_EKy8KJ6D6rIQP1vxlGAoln = n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool>.CreateDefault();
            this.__p_AzGGOnslQHgM5XvM4edg4v = default(n20.AsyncTask<n14.BoundingBox>);
            this.__p_HsiNjGnaf8oO5LkWShBzhZ = default(n20.HoldLatest<n14.BoundingBox>);
            this.__p_TPv3FYpjnrHLfSK49Gi7KL = n29.RenderEntity_HYRtmvUkSb6PheJUi3kp3r.CreateDefault();
            this.__p_Mqpo2zCE1uyMDUj0hjTWm8 = n30.Group_TqwCZl6Gra4OmgvUg1POgm.CreateDefault();
            this.__p_LYKVdsFMChTO0L21jVuOeI = n32.Changed_A8JGbead2bxNdnPybiEqVS<T[]>.CreateDefault<AdM>();
            this.__p_OFp8JdoWuZUOXalQi37qBD = n32.MonoFlop_GeOV3KtNF5BPYMkYFPPAst.CreateDefault();
            this.__p_CmxSHi24Yb3MY0DqaTolM1 = n32.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_M9iQKD16APBP175imqmL5R);
            n1.CompilationHelper.SafeDispose(this.__p_Sl9gmDMFzcDPX7btyM5wuz);
            n1.CompilationHelper.SafeDispose(this.__p_K30vX2JIRdrOEEQwSBQY10);
            n1.CompilationHelper.SafeDispose(this.__p_Pik1hNA6CYgLdYApdOVPVl);
            n1.CompilationHelper.SafeDispose(this.__p_AgLdJpYx4ohM24BRpVck8U);
            n1.CompilationHelper.SafeDispose(this.__p_RrLpUEnP1jHMtQrcOlloKy);
            n1.CompilationHelper.SafeDispose(this.__p_Fk69ptSPXAiQCGG9JKQBfK);
            n1.CompilationHelper.SafeDispose(this.__p_IpTgJtfhVBpOIAiPoMMZ03);
            n1.CompilationHelper.SafeDispose(this.__p_C92R2lWxcjpMp2fL4EReyK);
            n1.CompilationHelper.SafeDispose(this.__p_EKy8KJ6D6rIQP1vxlGAoln);
            n1.CompilationHelper.SafeDispose(this.__p_AzGGOnslQHgM5XvM4edg4v);
            n1.CompilationHelper.SafeDispose(this.__p_HsiNjGnaf8oO5LkWShBzhZ);
            n1.CompilationHelper.SafeDispose(this.__p_TPv3FYpjnrHLfSK49Gi7KL);
            n1.CompilationHelper.SafeDispose(this.__p_Mqpo2zCE1uyMDUj0hjTWm8);
            n1.CompilationHelper.SafeDispose(this.__p_LYKVdsFMChTO0L21jVuOeI);
            n1.CompilationHelper.SafeDispose(this.__p_OFp8JdoWuZUOXalQi37qBD);
            n1.CompilationHelper.SafeDispose(this.__p_CmxSHi24Yb3MY0DqaTolM1);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 25193U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "BjQCtqINP9xMTpLPb1A4yn", Name = "__slot_BjQCtqINP9xMTpLPb1A4yn")]
        public static n3.PrimitiveType __slot_BjQCtqINP9xMTpLPb1A4yn = n1.CompilationHelper.Deserialize<n3.PrimitiveType>("TriangleList", false, "NL6SEAZgmRHQPFCm3uYN3A", "BjQCtqINP9xMTpLPb1A4yn");
        [n1.ElementAttribute(TracingId = 25196U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "NfZmTOrrk3GNfQ470J2Dma", Name = "__slot_NfZmTOrrk3GNfQ470J2Dma")]
        public static bool __slot_NfZmTOrrk3GNfQ470J2Dma = true;
        [n1.ElementAttribute(TracingId = 25301U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "CLnZGzf3gxXOk9nlb63RCu", Name = "__slot_CLnZGzf3gxXOk9nlb63RCu")]
        public static string __slot_CLnZGzf3gxXOk9nlb63RCu = "transformation buffer";
        [n1.ElementAttribute(TracingId = 25307U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "VeUCMKwr9MIL6S9xP2QKeU", Name = "__slot_VeUCMKwr9MIL6S9xP2QKeU")]
        public static string __slot_VeUCMKwr9MIL6S9xP2QKeU = "geometry shader";
        [n1.ElementAttribute(TracingId = 25318U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "CMcNnKyMzPbQGuernphriQ", Name = "__slot_CMcNnKyMzPbQGuernphriQ")]
        public static string __slot_CMcNnKyMzPbQGuernphriQ = "stream out draw call";
        [n1.ElementAttribute(TracingId = 25364U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "KT91ezfzY9oPV7ZcdEP4gE", Name = "__slot_KT91ezfzY9oPV7ZcdEP4gE")]
        public static string __slot_KT91ezfzY9oPV7ZcdEP4gE = "StreamOut Instancer Model";
        [n1.ElementAttribute(TracingId = 25368U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "EMwZe5JLMYxO39XVkdWaho", Name = "__slot_EMwZe5JLMYxO39XVkdWaho")]
        public static string __slot_EMwZe5JLMYxO39XVkdWaho = "StreamOut Instancer";
        [n1.ElementAttribute(TracingId = 25373U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "AhXI63kyHHkOH2jelo9LY6", Name = "__slot_AhXI63kyHHkOH2jelo9LY6")]
        public static string __slot_AhXI63kyHHkOH2jelo9LY6 = "StreamOut Instancer Group";
        [n1.ElementAttribute(TracingId = 25595U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "QniUHjPL2auMFnFNR9c1Lt", Name = "__slot_QniUHjPL2auMFnFNR9c1Lt")]
        public n14.Vector3 __slot_QniUHjPL2auMFnFNR9c1Lt;
        [n1.ElementAttribute(TracingId = 25680U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "FwaP69AYYNiNsVEEN3nAm4", Name = "__slot_FwaP69AYYNiNsVEEN3nAm4")]
        public static n3.PrimitiveType __slot_FwaP69AYYNiNsVEEN3nAm4 = n1.CompilationHelper.Deserialize<n3.PrimitiveType>("TriangleList", false, "NL6SEAZgmRHQPFCm3uYN3A", "FwaP69AYYNiNsVEEN3nAm4");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_M9iQKD16APBP175imqmL5R;
        [n1.ElementAttribute(TracingId = 25130U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "Sl9gmDMFzcDPX7btyM5wuz", Name = "AnalyzeMesh", IsManaged = true, IsAutoGenerated = true)]
        public n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO __p_Sl9gmDMFzcDPX7btyM5wuz;
        [n1.ElementAttribute(TracingId = 25286U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "K30vX2JIRdrOEEQwSBQY10", Name = "Pos3Norm3Tex2", IsManaged = true, IsAutoGenerated = true)]
        public n31.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc __p_K30vX2JIRdrOEEQwSBQY10;
        [n1.ElementAttribute(TracingId = 25109U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "Pik1hNA6CYgLdYApdOVPVl", Name = "ComputeBuffer", IsManaged = true, IsAutoGenerated = true)]
        public n28.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM __p_Pik1hNA6CYgLdYApdOVPVl;
        [n1.ElementAttribute(TracingId = 22389U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "AgLdJpYx4ohM24BRpVck8U", Name = "DynamicBuffer", IsManaged = true, IsAutoGenerated = true)]
        public n28.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T[]> __p_AgLdJpYx4ohM24BRpVck8U;
        [n1.ElementAttribute(TracingId = 25199U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "RrLpUEnP1jHMtQrcOlloKy", Name = "InstancedMeshStreamOutShader", IsManaged = true, IsAutoGenerated = true, NodeName = "InstancedMeshStreamOutShader", NodeCategory = "Stride.Rendering.DrawShaders")]
        public n1.IVLNode __p_RrLpUEnP1jHMtQrcOlloKy;
        [n1.ElementAttribute(TracingId = 25212U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "Fk69ptSPXAiQCGG9JKQBfK", Name = "MeshDrawerStreamOut", IsManaged = true, IsAutoGenerated = true)]
        public n4.MeshDrawerStreamOut_C __p_Fk69ptSPXAiQCGG9JKQBfK;
        [n1.ElementAttribute(TracingId = 25340U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "IpTgJtfhVBpOIAiPoMMZ03", Name = "FrameDelay", IsManaged = true, IsAutoGenerated = true)]
        public n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<int> __p_IpTgJtfhVBpOIAiPoMMZ03;
        [n1.ElementAttribute(TracingId = 25164U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "C92R2lWxcjpMp2fL4EReyK", Name = "VertexBufferModelEntity", IsManaged = true, IsAutoGenerated = true)]
        public n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v __p_C92R2lWxcjpMp2fL4EReyK;
        [n1.ElementAttribute(TracingId = 25597U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "EKy8KJ6D6rIQP1vxlGAoln", Name = "FrameDelay", IsManaged = true, IsAutoGenerated = true)]
        public n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool> __p_EKy8KJ6D6rIQP1vxlGAoln;
        [n1.ElementAttribute(TracingId = 25377U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "AzGGOnslQHgM5XvM4edg4v", Name = "AsyncTask", IsManaged = true, IsAutoGenerated = true)]
        public n20.AsyncTask<n14.BoundingBox> __p_AzGGOnslQHgM5XvM4edg4v;
        [n1.ElementAttribute(TracingId = 25521U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "HsiNjGnaf8oO5LkWShBzhZ", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n20.HoldLatest<n14.BoundingBox> __p_HsiNjGnaf8oO5LkWShBzhZ;
        [n1.ElementAttribute(TracingId = 25231U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "TPv3FYpjnrHLfSK49Gi7KL", Name = "RenderEntity", IsManaged = true, IsAutoGenerated = true)]
        public n29.RenderEntity_HYRtmvUkSb6PheJUi3kp3r __p_TPv3FYpjnrHLfSK49Gi7KL;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n10.DrawerRenderStage __c_DuKZTgu3wM3PUAEBL5YwBL = n1.CompilationHelper.Deserialize<n10.DrawerRenderStage>("Opaque", false, "NL6SEAZgmRHQPFCm3uYN3A", "DuKZTgu3wM3PUAEBL5YwBL");
        [n1.ElementAttribute(TracingId = 25267U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "Mqpo2zCE1uyMDUj0hjTWm8", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_Mqpo2zCE1uyMDUj0hjTWm8;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n23.Spread<n12.Entity> __pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8 = default(n23.Spread<n12.Entity>);
        [n1.ElementAttribute(TracingId = 25533U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "LYKVdsFMChTO0L21jVuOeI", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n32.Changed_A8JGbead2bxNdnPybiEqVS<T[]> __p_LYKVdsFMChTO0L21jVuOeI;
        [n1.ElementAttribute(TracingId = 25547U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "OFp8JdoWuZUOXalQi37qBD", Name = "MonoFlop", IsManaged = true, IsAutoGenerated = true)]
        public n32.MonoFlop_GeOV3KtNF5BPYMkYFPPAst __p_OFp8JdoWuZUOXalQi37qBD;
        [n1.ElementAttribute(TracingId = 25566U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "CmxSHi24Yb3MY0DqaTolM1", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n32.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CmxSHi24Yb3MY0DqaTolM1;
        static StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB()
        {
        }

        public StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB(StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T> other): base(other)
        {
            this.__slot_QniUHjPL2auMFnFNR9c1Lt = other.__slot_QniUHjPL2auMFnFNR9c1Lt;
            this.__if_M9iQKD16APBP175imqmL5R = other.__if_M9iQKD16APBP175imqmL5R;
            this.__p_Sl9gmDMFzcDPX7btyM5wuz = other.__p_Sl9gmDMFzcDPX7btyM5wuz;
            this.__p_K30vX2JIRdrOEEQwSBQY10 = other.__p_K30vX2JIRdrOEEQwSBQY10;
            this.__p_Pik1hNA6CYgLdYApdOVPVl = other.__p_Pik1hNA6CYgLdYApdOVPVl;
            this.__p_AgLdJpYx4ohM24BRpVck8U = other.__p_AgLdJpYx4ohM24BRpVck8U;
            this.__p_RrLpUEnP1jHMtQrcOlloKy = other.__p_RrLpUEnP1jHMtQrcOlloKy;
            this.__p_Fk69ptSPXAiQCGG9JKQBfK = other.__p_Fk69ptSPXAiQCGG9JKQBfK;
            this.__p_IpTgJtfhVBpOIAiPoMMZ03 = other.__p_IpTgJtfhVBpOIAiPoMMZ03;
            this.__p_C92R2lWxcjpMp2fL4EReyK = other.__p_C92R2lWxcjpMp2fL4EReyK;
            this.__p_EKy8KJ6D6rIQP1vxlGAoln = other.__p_EKy8KJ6D6rIQP1vxlGAoln;
            this.__p_AzGGOnslQHgM5XvM4edg4v = other.__p_AzGGOnslQHgM5XvM4edg4v;
            this.__p_HsiNjGnaf8oO5LkWShBzhZ = other.__p_HsiNjGnaf8oO5LkWShBzhZ;
            this.__p_TPv3FYpjnrHLfSK49Gi7KL = other.__p_TPv3FYpjnrHLfSK49Gi7KL;
            this.__p_Mqpo2zCE1uyMDUj0hjTWm8 = other.__p_Mqpo2zCE1uyMDUj0hjTWm8;
            this.__pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8 = other.__pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8;
            this.__p_LYKVdsFMChTO0L21jVuOeI = other.__p_LYKVdsFMChTO0L21jVuOeI;
            this.__p_OFp8JdoWuZUOXalQi37qBD = other.__p_OFp8JdoWuZUOXalQi37qBD;
            this.__p_CmxSHi24Yb3MY0DqaTolM1 = other.__p_CmxSHi24Yb3MY0DqaTolM1;
        }

        protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_QniUHjPL2auMFnFNR9c1Lt", in __slot_QniUHjPL2auMFnFNR9c1Lt), n1.CompilationHelper.GetValueOrExisting(values, "__if_M9iQKD16APBP175imqmL5R", in __if_M9iQKD16APBP175imqmL5R), n1.CompilationHelper.GetValueOrExisting(values, "__p_Sl9gmDMFzcDPX7btyM5wuz", in __p_Sl9gmDMFzcDPX7btyM5wuz), n1.CompilationHelper.GetValueOrExisting(values, "__p_K30vX2JIRdrOEEQwSBQY10", in __p_K30vX2JIRdrOEEQwSBQY10), n1.CompilationHelper.GetValueOrExisting(values, "__p_Pik1hNA6CYgLdYApdOVPVl", in __p_Pik1hNA6CYgLdYApdOVPVl), n1.CompilationHelper.GetValueOrExisting(values, "__p_AgLdJpYx4ohM24BRpVck8U", in __p_AgLdJpYx4ohM24BRpVck8U), n1.CompilationHelper.GetValueOrExisting(values, "__p_RrLpUEnP1jHMtQrcOlloKy", in __p_RrLpUEnP1jHMtQrcOlloKy), n1.CompilationHelper.GetValueOrExisting(values, "__p_Fk69ptSPXAiQCGG9JKQBfK", in __p_Fk69ptSPXAiQCGG9JKQBfK), n1.CompilationHelper.GetValueOrExisting(values, "__p_IpTgJtfhVBpOIAiPoMMZ03", in __p_IpTgJtfhVBpOIAiPoMMZ03), n1.CompilationHelper.GetValueOrExisting(values, "__p_C92R2lWxcjpMp2fL4EReyK", in __p_C92R2lWxcjpMp2fL4EReyK), n1.CompilationHelper.GetValueOrExisting(values, "__p_EKy8KJ6D6rIQP1vxlGAoln", in __p_EKy8KJ6D6rIQP1vxlGAoln), n1.CompilationHelper.GetValueOrExisting(values, "__p_AzGGOnslQHgM5XvM4edg4v", in __p_AzGGOnslQHgM5XvM4edg4v), n1.CompilationHelper.GetValueOrExisting(values, "__p_HsiNjGnaf8oO5LkWShBzhZ", in __p_HsiNjGnaf8oO5LkWShBzhZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_TPv3FYpjnrHLfSK49Gi7KL", in __p_TPv3FYpjnrHLfSK49Gi7KL), n1.CompilationHelper.GetValueOrExisting(values, "__p_Mqpo2zCE1uyMDUj0hjTWm8", in __p_Mqpo2zCE1uyMDUj0hjTWm8), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8", in __pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8), n1.CompilationHelper.GetValueOrExisting(values, "__p_LYKVdsFMChTO0L21jVuOeI", in __p_LYKVdsFMChTO0L21jVuOeI), n1.CompilationHelper.GetValueOrExisting(values, "__p_OFp8JdoWuZUOXalQi37qBD", in __p_OFp8JdoWuZUOXalQi37qBD), n1.CompilationHelper.GetValueOrExisting(values, "__p_CmxSHi24Yb3MY0DqaTolM1", in __p_CmxSHi24Yb3MY0DqaTolM1));
        }

        internal StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T> __WITH__(n14.Vector3 __slot_QniUHjPL2auMFnFNR9c1Lt, n2.Object __if_M9iQKD16APBP175imqmL5R, n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO __p_Sl9gmDMFzcDPX7btyM5wuz, n31.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc __p_K30vX2JIRdrOEEQwSBQY10, n28.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM __p_Pik1hNA6CYgLdYApdOVPVl, n28.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T[]> __p_AgLdJpYx4ohM24BRpVck8U, n1.IVLNode __p_RrLpUEnP1jHMtQrcOlloKy, n4.MeshDrawerStreamOut_C __p_Fk69ptSPXAiQCGG9JKQBfK, n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<int> __p_IpTgJtfhVBpOIAiPoMMZ03, n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v __p_C92R2lWxcjpMp2fL4EReyK, n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool> __p_EKy8KJ6D6rIQP1vxlGAoln, n20.AsyncTask<n14.BoundingBox> __p_AzGGOnslQHgM5XvM4edg4v, n20.HoldLatest<n14.BoundingBox> __p_HsiNjGnaf8oO5LkWShBzhZ, n29.RenderEntity_HYRtmvUkSb6PheJUi3kp3r __p_TPv3FYpjnrHLfSK49Gi7KL, n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_Mqpo2zCE1uyMDUj0hjTWm8, n23.Spread<n12.Entity> __pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8, n32.Changed_A8JGbead2bxNdnPybiEqVS<T[]> __p_LYKVdsFMChTO0L21jVuOeI, n32.MonoFlop_GeOV3KtNF5BPYMkYFPPAst __p_OFp8JdoWuZUOXalQi37qBD, n32.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_CmxSHi24Yb3MY0DqaTolM1)
        {
            n4.StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_QniUHjPL2auMFnFNR9c1Lt != this.__slot_QniUHjPL2auMFnFNR9c1Lt || __if_M9iQKD16APBP175imqmL5R != this.__if_M9iQKD16APBP175imqmL5R || __p_Sl9gmDMFzcDPX7btyM5wuz != this.__p_Sl9gmDMFzcDPX7btyM5wuz || __p_K30vX2JIRdrOEEQwSBQY10 != this.__p_K30vX2JIRdrOEEQwSBQY10 || __p_Pik1hNA6CYgLdYApdOVPVl != this.__p_Pik1hNA6CYgLdYApdOVPVl || __p_AgLdJpYx4ohM24BRpVck8U != this.__p_AgLdJpYx4ohM24BRpVck8U || __p_RrLpUEnP1jHMtQrcOlloKy != this.__p_RrLpUEnP1jHMtQrcOlloKy || __p_Fk69ptSPXAiQCGG9JKQBfK != this.__p_Fk69ptSPXAiQCGG9JKQBfK || __p_IpTgJtfhVBpOIAiPoMMZ03 != this.__p_IpTgJtfhVBpOIAiPoMMZ03 || __p_C92R2lWxcjpMp2fL4EReyK != this.__p_C92R2lWxcjpMp2fL4EReyK || __p_EKy8KJ6D6rIQP1vxlGAoln != this.__p_EKy8KJ6D6rIQP1vxlGAoln || __p_AzGGOnslQHgM5XvM4edg4v != this.__p_AzGGOnslQHgM5XvM4edg4v || __p_HsiNjGnaf8oO5LkWShBzhZ != this.__p_HsiNjGnaf8oO5LkWShBzhZ || __p_TPv3FYpjnrHLfSK49Gi7KL != this.__p_TPv3FYpjnrHLfSK49Gi7KL || __p_Mqpo2zCE1uyMDUj0hjTWm8 != this.__p_Mqpo2zCE1uyMDUj0hjTWm8 || __pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8 != this.__pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8 || __p_LYKVdsFMChTO0L21jVuOeI != this.__p_LYKVdsFMChTO0L21jVuOeI || __p_OFp8JdoWuZUOXalQi37qBD != this.__p_OFp8JdoWuZUOXalQi37qBD || __p_CmxSHi24Yb3MY0DqaTolM1 != this.__p_CmxSHi24Yb3MY0DqaTolM1 ? new StreamOutInstancer_FBHuNRR7L9ALXC8p0GP3eB<T>(this)
                {__slot_QniUHjPL2auMFnFNR9c1Lt = __slot_QniUHjPL2auMFnFNR9c1Lt, __if_M9iQKD16APBP175imqmL5R = __if_M9iQKD16APBP175imqmL5R, __p_Sl9gmDMFzcDPX7btyM5wuz = __p_Sl9gmDMFzcDPX7btyM5wuz, __p_K30vX2JIRdrOEEQwSBQY10 = __p_K30vX2JIRdrOEEQwSBQY10, __p_Pik1hNA6CYgLdYApdOVPVl = __p_Pik1hNA6CYgLdYApdOVPVl, __p_AgLdJpYx4ohM24BRpVck8U = __p_AgLdJpYx4ohM24BRpVck8U, __p_RrLpUEnP1jHMtQrcOlloKy = __p_RrLpUEnP1jHMtQrcOlloKy, __p_Fk69ptSPXAiQCGG9JKQBfK = __p_Fk69ptSPXAiQCGG9JKQBfK, __p_IpTgJtfhVBpOIAiPoMMZ03 = __p_IpTgJtfhVBpOIAiPoMMZ03, __p_C92R2lWxcjpMp2fL4EReyK = __p_C92R2lWxcjpMp2fL4EReyK, __p_EKy8KJ6D6rIQP1vxlGAoln = __p_EKy8KJ6D6rIQP1vxlGAoln, __p_AzGGOnslQHgM5XvM4edg4v = __p_AzGGOnslQHgM5XvM4edg4v, __p_HsiNjGnaf8oO5LkWShBzhZ = __p_HsiNjGnaf8oO5LkWShBzhZ, __p_TPv3FYpjnrHLfSK49Gi7KL = __p_TPv3FYpjnrHLfSK49Gi7KL, __p_Mqpo2zCE1uyMDUj0hjTWm8 = __p_Mqpo2zCE1uyMDUj0hjTWm8, __pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8 = __pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8, __p_LYKVdsFMChTO0L21jVuOeI = __p_LYKVdsFMChTO0L21jVuOeI, __p_OFp8JdoWuZUOXalQi37qBD = __p_OFp8JdoWuZUOXalQi37qBD, __p_CmxSHi24Yb3MY0DqaTolM1 = __p_CmxSHi24Yb3MY0DqaTolM1} : that_0;
            else
            {
                this.__slot_QniUHjPL2auMFnFNR9c1Lt = __slot_QniUHjPL2auMFnFNR9c1Lt;
                this.__if_M9iQKD16APBP175imqmL5R = __if_M9iQKD16APBP175imqmL5R;
                this.__p_Sl9gmDMFzcDPX7btyM5wuz = __p_Sl9gmDMFzcDPX7btyM5wuz;
                this.__p_K30vX2JIRdrOEEQwSBQY10 = __p_K30vX2JIRdrOEEQwSBQY10;
                this.__p_Pik1hNA6CYgLdYApdOVPVl = __p_Pik1hNA6CYgLdYApdOVPVl;
                this.__p_AgLdJpYx4ohM24BRpVck8U = __p_AgLdJpYx4ohM24BRpVck8U;
                this.__p_RrLpUEnP1jHMtQrcOlloKy = __p_RrLpUEnP1jHMtQrcOlloKy;
                this.__p_Fk69ptSPXAiQCGG9JKQBfK = __p_Fk69ptSPXAiQCGG9JKQBfK;
                this.__p_IpTgJtfhVBpOIAiPoMMZ03 = __p_IpTgJtfhVBpOIAiPoMMZ03;
                this.__p_C92R2lWxcjpMp2fL4EReyK = __p_C92R2lWxcjpMp2fL4EReyK;
                this.__p_EKy8KJ6D6rIQP1vxlGAoln = __p_EKy8KJ6D6rIQP1vxlGAoln;
                this.__p_AzGGOnslQHgM5XvM4edg4v = __p_AzGGOnslQHgM5XvM4edg4v;
                this.__p_HsiNjGnaf8oO5LkWShBzhZ = __p_HsiNjGnaf8oO5LkWShBzhZ;
                this.__p_TPv3FYpjnrHLfSK49Gi7KL = __p_TPv3FYpjnrHLfSK49Gi7KL;
                this.__p_Mqpo2zCE1uyMDUj0hjTWm8 = __p_Mqpo2zCE1uyMDUj0hjTWm8;
                this.__pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8 = __pin_group_Child_In_Mqpo2zCE1uyMDUj0hjTWm8;
                this.__p_LYKVdsFMChTO0L21jVuOeI = __p_LYKVdsFMChTO0L21jVuOeI;
                this.__p_OFp8JdoWuZUOXalQi37qBD = __p_OFp8JdoWuZUOXalQi37qBD;
                this.__p_CmxSHi24Yb3MY0DqaTolM1 = __p_CmxSHi24Yb3MY0DqaTolM1;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "KlDK8r8CxyZMcOFG1If084", Name = "__KlDK8r8CxyZMcOFG1If084")]
        [n2.SerializableAttribute]
        public class __KlDK8r8CxyZMcOFG1If084 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UX0PvcaX7j0Ps1JM0VwWU3);
                return;
            }

            [n1.ElementAttribute(TracingId = 25629U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "UX0PvcaX7j0Ps1JM0VwWU3", Name = "BoxMesh", IsManaged = true, IsAutoGenerated = true, NodeName = "BoxMesh", NodeCategory = "Stride.Models.Meshes")]
            public n1.IVLNode __p_UX0PvcaX7j0Ps1JM0VwWU3;
            public __KlDK8r8CxyZMcOFG1If084(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __KlDK8r8CxyZMcOFG1If084(__KlDK8r8CxyZMcOFG1If084 other): base(other)
            {
                this.__p_UX0PvcaX7j0Ps1JM0VwWU3 = other.__p_UX0PvcaX7j0Ps1JM0VwWU3;
            }

            protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UX0PvcaX7j0Ps1JM0VwWU3", in __p_UX0PvcaX7j0Ps1JM0VwWU3));
            }

            internal __KlDK8r8CxyZMcOFG1If084 __WITH__(n1.IVLNode __p_UX0PvcaX7j0Ps1JM0VwWU3)
            {
                __KlDK8r8CxyZMcOFG1If084 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_UX0PvcaX7j0Ps1JM0VwWU3 != this.__p_UX0PvcaX7j0Ps1JM0VwWU3 ? new __KlDK8r8CxyZMcOFG1If084(this)
                    {__p_UX0PvcaX7j0Ps1JM0VwWU3 = __p_UX0PvcaX7j0Ps1JM0VwWU3} : that_0;
                else
                {
                    this.__p_UX0PvcaX7j0Ps1JM0VwWU3 = __p_UX0PvcaX7j0Ps1JM0VwWU3;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "VVEBQHVkzTVLbjPJAdpnB7", Name = "__VVEBQHVkzTVLbjPJAdpnB7")]
        [n2.SerializableAttribute]
        public class __VVEBQHVkzTVLbjPJAdpnB7 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(TracingId = 25509U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "PuFKxd0ytmXOOeZDMxUJR1", Name = "__slot_PuFKxd0ytmXOOeZDMxUJR1")]
            public n16.IEnumerable<n14.Matrix> __slot_PuFKxd0ytmXOOeZDMxUJR1;
            public __VVEBQHVkzTVLbjPJAdpnB7(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __VVEBQHVkzTVLbjPJAdpnB7(__VVEBQHVkzTVLbjPJAdpnB7 other): base(other)
            {
                this.__slot_PuFKxd0ytmXOOeZDMxUJR1 = other.__slot_PuFKxd0ytmXOOeZDMxUJR1;
            }

            protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_PuFKxd0ytmXOOeZDMxUJR1", in __slot_PuFKxd0ytmXOOeZDMxUJR1));
            }

            internal __VVEBQHVkzTVLbjPJAdpnB7 __WITH__(n16.IEnumerable<n14.Matrix> __slot_PuFKxd0ytmXOOeZDMxUJR1)
            {
                __VVEBQHVkzTVLbjPJAdpnB7 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __slot_PuFKxd0ytmXOOeZDMxUJR1 != this.__slot_PuFKxd0ytmXOOeZDMxUJR1 ? new __VVEBQHVkzTVLbjPJAdpnB7(this)
                    {__slot_PuFKxd0ytmXOOeZDMxUJR1 = __slot_PuFKxd0ytmXOOeZDMxUJR1} : that_0;
                else
                {
                    this.__slot_PuFKxd0ytmXOOeZDMxUJR1 = __slot_PuFKxd0ytmXOOeZDMxUJR1;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 25898U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "Jeoc7D9B7h9PBUqptKAvLO", Name = "AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO")]
    [n2.SerializableAttribute]
    public class AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO Create(n1.NodeContext Node_Context)
        {
            var instance = new AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO CreateDefault()
        {
            var instance = new AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO Update(n8.Mesh Mesh_In, out n8.MeshDraw Mesh_Draw_Out, out bool Has_Tangent_Out, out int Draw_Count_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_D39C2NzScu1QPzSJiNtBJw;
            if (manager_2 is null)
            {
                manager_2 = new n35.Manager<n2.ValueTuple<n8.Mesh>, n2.ValueTuple<n8.MeshDraw, bool, int>>((default(n8.MeshDraw), false, 0));
            }

            var inputs_3 = n2.ValueTuple.Create(Mesh_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var Draw_7 = Mesh_In.Draw;
                var Vertex_Buffers_8 = Draw_7.VertexBuffers;
                var Index_Buffer_9 = Draw_7.IndexBuffer;
                var Count_10 = Index_Buffer_9.Count;
                n3.VertexBufferBinding Default_Value_11 = default(n3.VertexBufferBinding);
                n15._Operations_.FirstOrDefault<n3.VertexBufferBinding[], n3.VertexBufferBinding>(Input_In: Vertex_Buffers_8, Default_Value_In: Default_Value_11, Output_Out: out n3.VertexBufferBinding[] Output_12, Result_Out: out n3.VertexBufferBinding Result_13);
                var Declaration_14 = Result_13.Declaration;
                var Vertex_Elements_15 = Declaration_14.VertexElements;
                n16.IEnumerable<n3.VertexElement> Input_16 = (n16.IEnumerable<n3.VertexElement>)Vertex_Elements_15;
                var __fallback___17 = n1.ServiceRegistry.Current;
                n15._Operations_.Any_Predicate<n3.VertexElement>(Input_In: Input_16, Predicate_In: (n3.VertexElement Input_In_19) =>
                {
                    using var __current_18 = __fallback___17.MakeCurrentIfNone();
                    var Semantic_Name_20 = Input_In_19.SemanticName;
                    var Tangent_21 = n3.VertexElementUsage.Tangent;
                    var Result_22 = Semantic_Name_20 == Tangent_21;
                    return Result_22;
                }

                , Result_Out: out bool Result_23);
                outputs_4 = (Draw_7, Result_23, Count_10);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, default, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var(__auto_24, __auto_25, __auto_26) = outputs_4;
            Mesh_Draw_Out = __auto_24;
            Has_Tangent_Out = __auto_25;
            Draw_Count_Out = __auto_26;
            n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO that_27 = this;
            if (this.__GetContext__().IsImmutable)
                that_27 = manager_2 != this.__cache_D39C2NzScu1QPzSJiNtBJw ? new AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO(this)
                {__cache_D39C2NzScu1QPzSJiNtBJw = manager_2} : that_27;
            else
            {
                this.__cache_D39C2NzScu1QPzSJiNtBJw = manager_2;
            }

            return that_27;
        }

        public n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO __Create__(n1.NodeContext Node_Context)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO that_0 = this;
            this.__cache_D39C2NzScu1QPzSJiNtBJw = null;
            return that_0;
        }

        public n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO __CreateDefault__()
        {
            n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO that_0 = this;
            this.__cache_D39C2NzScu1QPzSJiNtBJw = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_D39C2NzScu1QPzSJiNtBJw);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 25907U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "D39C2NzScu1QPzSJiNtBJw", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n35.Manager<n2.ValueTuple<n8.Mesh>, n2.ValueTuple<n8.MeshDraw, bool, int>> __cache_D39C2NzScu1QPzSJiNtBJw = null;
        public AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO(AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO other): base(other)
        {
            this.__cache_D39C2NzScu1QPzSJiNtBJw = other.__cache_D39C2NzScu1QPzSJiNtBJw;
        }

        protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_D39C2NzScu1QPzSJiNtBJw", in __cache_D39C2NzScu1QPzSJiNtBJw));
        }

        internal AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO __WITH__(n35.Manager<n2.ValueTuple<n8.Mesh>, n2.ValueTuple<n8.MeshDraw, bool, int>> __cache_D39C2NzScu1QPzSJiNtBJw)
        {
            n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_D39C2NzScu1QPzSJiNtBJw != this.__cache_D39C2NzScu1QPzSJiNtBJw ? new AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO(this)
                {__cache_D39C2NzScu1QPzSJiNtBJw = __cache_D39C2NzScu1QPzSJiNtBJw} : that_0;
            else
            {
                this.__cache_D39C2NzScu1QPzSJiNtBJw = __cache_D39C2NzScu1QPzSJiNtBJw;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 30740U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "V0gZTBaXuOlOokaX9Jnq6v", Name = "VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v")]
    [n2.SerializableAttribute]
    public class VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v Create(n1.NodeContext Node_Context)
        {
            var instance = new VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v CreateDefault()
        {
            var instance = new VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v Update(n8.Material Material_In, n3.PrimitiveType Primitive_Type_In, n14.Matrix Transformation_In, n3.Buffer Vertex_Buffer_In, n3.VertexDeclaration Vertex_Declaration_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, int Vertex_Count_In, out n12.Entity Entity_Out)
        {
            bool Update_0 = true;
            var Output_1 = this.__p_FxwbAGlYcWyMfqSRUgL0oA;
            if (Update_0)
            {
                Output_1 = this.__p_FxwbAGlYcWyMfqSRUgL0oA.Update(Material_In: Material_In, Primitive_Type_In: Primitive_Type_In, Vertex_Buffer_In: Vertex_Buffer_In, Vertex_Declaration_In: Vertex_Declaration_In, Vertex_Count_In: Vertex_Count_In);
            }

            bool SetTransformation_2 = true;
            var Output_3 = this.__p_ARVylOsN7WtONhh7OeAAza;
            if (SetTransformation_2)
            {
                Output_3 = this.__p_ARVylOsN7WtONhh7OeAAza.SetTransformation(Transformation_In: Transformation_In);
            }

            bool SetEnabled_4 = true;
            var Output_5 = Output_3;
            if (SetEnabled_4)
            {
                Output_5 = Output_3.SetEnabled(Enabled_In: Enabled_In);
            }

            var State_Output_7 = Output_5.GetEntity(Output_Out: out n12.Entity Output_6);
            Entity_Out = Output_6;
            n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v that_8 = this;
            if (this.__GetContext__().IsImmutable)
                that_8 = Output_1 != this.__p_FxwbAGlYcWyMfqSRUgL0oA || State_Output_7 != this.__p_ARVylOsN7WtONhh7OeAAza ? new VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v(this)
                {__p_FxwbAGlYcWyMfqSRUgL0oA = Output_1, __p_ARVylOsN7WtONhh7OeAAza = State_Output_7} : that_8;
            else
            {
                this.__p_FxwbAGlYcWyMfqSRUgL0oA = Output_1;
                this.__p_ARVylOsN7WtONhh7OeAAza = State_Output_7;
            }

            return that_8;
        }

        public n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v SetName(string Name_In)
        {
            bool SetName_0 = true;
            var Output_1 = this.__p_ARVylOsN7WtONhh7OeAAza;
            if (SetName_0)
            {
                Output_1 = this.__p_ARVylOsN7WtONhh7OeAAza.SetName(Name_In: Name_In);
            }

            n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_ARVylOsN7WtONhh7OeAAza ? new VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v(this)
                {__p_ARVylOsN7WtONhh7OeAAza = Output_1} : that_2;
            else
            {
                this.__p_ARVylOsN7WtONhh7OeAAza = Output_1;
            }

            return that_2;
        }

        public n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v SetBoundingBox(n14.BoundingBox Bounding_Box_In)
        {
            bool SetBoundingBox_0 = true;
            var Output_1 = this.__p_FxwbAGlYcWyMfqSRUgL0oA;
            if (SetBoundingBox_0)
            {
                Output_1 = this.__p_FxwbAGlYcWyMfqSRUgL0oA.SetBoundingBox(Bounding_Box_In: Bounding_Box_In);
            }

            n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_FxwbAGlYcWyMfqSRUgL0oA ? new VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v(this)
                {__p_FxwbAGlYcWyMfqSRUgL0oA = Output_1} : that_2;
            else
            {
                this.__p_FxwbAGlYcWyMfqSRUgL0oA = Output_1;
            }

            return that_2;
        }

        public n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v __Create__(n1.NodeContext Node_Context)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "FxwbAGlYcWyMfqSRUgL0oA", 30774U);
            var Output_1 = n4.StreamOutModelComponent_C.Create(Node_Context: Node_Context_0);
            var Output_3 = Output_1.GetComponent(Component_Out: out n12.ModelComponent Component_2);
            var builder_4 = n6.CollectionBuilders.GetBuilder(n27._Operations_.CreateDefault<n12.ModelComponent>(), 1);
            builder_4.Add(Component_2);
            var __pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c_5 = builder_4.Commit();
            n27._Operations_.FromValue<n12.ModelComponent>(Input_In: __pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c_5, Result_Out: out n23.Spread<n12.ModelComponent> Result_6);
            n16.IEnumerable<n12.EntityComponent> Base_Components_7 = (n16.IEnumerable<n12.EntityComponent>)Result_6;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "ARVylOsN7WtONhh7OeAAza", 30743U);
            string Initial_Name_9 = "";
            var Output_10 = n30.Entity_OfyExcqEe4CPH8Wq0L8jzv.Create(Node_Context: Node_Context_8, Initial_Name_In: Initial_Name_9, Base_Components_In: Base_Components_7);
            n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v that_11 = this;
            this.__pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c = __pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c_5;
            this.__p_FxwbAGlYcWyMfqSRUgL0oA = Output_3;
            this.__p_ARVylOsN7WtONhh7OeAAza = Output_10;
            return that_11;
        }

        public n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v __CreateDefault__()
        {
            n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v that_0 = this;
            this.__pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c = n27._Operations_.CreateDefault<n12.ModelComponent>();
            this.__p_FxwbAGlYcWyMfqSRUgL0oA = n4.StreamOutModelComponent_C.CreateDefault();
            this.__p_ARVylOsN7WtONhh7OeAAza = n30.Entity_OfyExcqEe4CPH8Wq0L8jzv.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_FxwbAGlYcWyMfqSRUgL0oA);
            n1.CompilationHelper.SafeDispose(this.__p_ARVylOsN7WtONhh7OeAAza);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 30774U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "FxwbAGlYcWyMfqSRUgL0oA", Name = "StreamOutModelComponent", IsManaged = true, IsAutoGenerated = true)]
        public n4.StreamOutModelComponent_C __p_FxwbAGlYcWyMfqSRUgL0oA;
        [n1.ElementAttribute(TracingId = 30743U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "ARVylOsN7WtONhh7OeAAza", Name = "Entity", IsManaged = true, IsAutoGenerated = true)]
        public n30.Entity_OfyExcqEe4CPH8Wq0L8jzv __p_ARVylOsN7WtONhh7OeAAza;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n23.Spread<n12.ModelComponent> __pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c = default(n23.Spread<n12.ModelComponent>);
        public VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v(VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v other): base(other)
        {
            this.__p_FxwbAGlYcWyMfqSRUgL0oA = other.__p_FxwbAGlYcWyMfqSRUgL0oA;
            this.__p_ARVylOsN7WtONhh7OeAAza = other.__p_ARVylOsN7WtONhh7OeAAza;
            this.__pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c = other.__pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c;
        }

        protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FxwbAGlYcWyMfqSRUgL0oA", in __p_FxwbAGlYcWyMfqSRUgL0oA), n1.CompilationHelper.GetValueOrExisting(values, "__p_ARVylOsN7WtONhh7OeAAza", in __p_ARVylOsN7WtONhh7OeAAza), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c", in __pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c));
        }

        internal VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v __WITH__(n4.StreamOutModelComponent_C __p_FxwbAGlYcWyMfqSRUgL0oA, n30.Entity_OfyExcqEe4CPH8Wq0L8jzv __p_ARVylOsN7WtONhh7OeAAza, n23.Spread<n12.ModelComponent> __pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c)
        {
            n4.VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_FxwbAGlYcWyMfqSRUgL0oA != this.__p_FxwbAGlYcWyMfqSRUgL0oA || __p_ARVylOsN7WtONhh7OeAAza != this.__p_ARVylOsN7WtONhh7OeAAza || __pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c != this.__pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c ? new VertexBufferModelEntity_V0gZTBaXuOlOokaX9Jnq6v(this)
                {__p_FxwbAGlYcWyMfqSRUgL0oA = __p_FxwbAGlYcWyMfqSRUgL0oA, __p_ARVylOsN7WtONhh7OeAAza = __p_ARVylOsN7WtONhh7OeAAza, __pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c = __pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c} : that_0;
            else
            {
                this.__p_FxwbAGlYcWyMfqSRUgL0oA = __p_FxwbAGlYcWyMfqSRUgL0oA;
                this.__p_ARVylOsN7WtONhh7OeAAza = __p_ARVylOsN7WtONhh7OeAAza;
                this.__pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c = __pin_group_Input_In_MnIH6LaztkvPBql3hbOC3c;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 30928U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "PJgyWNdTkGvLdtBMDaYOhz", Name = "MeshDrawerStreamOut_C")]
    [n2.SerializableAttribute]
    public class MeshDrawerStreamOut_C : n1.VLObject, n8.IGraphicsRendererBase, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.MeshDrawerStreamOut_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new MeshDrawerStreamOut_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.MeshDrawerStreamOut_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new MeshDrawerStreamOut_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.MeshDrawerStreamOut_C Draw_(n8.RenderDrawContext Context_In)
        {
            n10.IEffect __auto_0 = this.Effect;
            n8.MeshDraw __pad_RCmUrP0i3FoMIg2Lm0szhu_1 = this.__slot_RCmUrP0i3FoMIg2Lm0szhu;
            int __auto_2 = this.Instance_Count;
            n3.MutablePipelineState __auto_3 = this.Mutable_Pipeline_State;
            n3.PrimitiveType __auto_4 = this.Topology;
            n3.Buffer[] __auto_5 = this.Buffers;
            var Render_Context_6 = Context_In.RenderContext;
            var Render_View_7 = Render_Context_6.RenderView;
            var Result_8 = ((n10.IEffect)__auto_0).SetParameters(renderView: Render_View_7, renderDrawContext: Context_In);
            var Command_List_9 = Context_In.CommandList;
            var State_10 = __auto_3.State;
            n7.ObjectHelpers.IsAssigned(x: __pad_RCmUrP0i3FoMIg2Lm0szhu_1, result: out bool Result_11, notAssigned: out bool Not_Assigned_12);
            var Root_Signature_13 = Result_8.RootSignature;
            var Effect_14 = Result_8.Effect;
            var Bytecode_15 = Effect_14.Bytecode;
            n3.MutablePipelineState __auto_16;
            n3.VertexBufferBinding __auto_17;
            if (Result_11)
            {
                State_10.PrimitiveType = __auto_4;
                State_10.RootSignature = Root_Signature_13;
                State_10.EffectBytecode = Bytecode_15;
                var Vertex_Buffers_19 = __pad_RCmUrP0i3FoMIg2Lm0szhu_1.VertexBuffers;
                n3.VertexBufferBinding Default_Value_20 = default(n3.VertexBufferBinding);
                n15._Operations_.FirstOrDefault<n3.VertexBufferBinding[], n3.VertexBufferBinding>(Input_In: Vertex_Buffers_19, Default_Value_In: Default_Value_20, Output_Out: out n3.VertexBufferBinding[] Output_21, Result_Out: out n3.VertexBufferBinding Result_22);
                var Declaration_23 = Result_22.Declaration;
                var Result_24 = n3.VertexBufferBindingExtensions.CreateInputElements(vertexDeclaration: Declaration_23);
                State_10.InputElements = Result_24;
                __auto_17 = Result_22;
                var Output_25 = State_10.Output;
                Output_25.CaptureState(commandList: Command_List_9);
                __auto_16 = __auto_3;
            }
            else
            {
                __auto_16 = __auto_3;
                __auto_17 = default(n3.VertexBufferBinding);
            }

            __auto_16.Update();
            var Current_State_26 = __auto_16.CurrentState;
            Command_List_9.SetPipelineState(pipelineState: Current_State_26);
            Command_List_9.SetStreamTargets(buffers: __auto_5);
            var Graphics_Context_27 = Context_In.GraphicsContext;
            bool Condition_28 = true;
            n3.CommandList __auto_29;
            if (Condition_28)
            {
                Result_8.Apply(graphicsContext: Graphics_Context_27);
                __auto_29 = Command_List_9;
            }
            else
            {
                __auto_29 = Command_List_9;
            }

            n3.CommandList __auto_31;
            if (Result_11)
            {
                var Stride_33 = __auto_17.Stride;
                var Offset_34 = __auto_17.Offset;
                var Buffer_35 = __auto_17.Buffer;
                int Index_36 = 0;
                __auto_29.SetVertexBuffer(index: Index_36, buffer: Buffer_35, offset: Offset_34, stride: Stride_33);
                var Vertex_Buffers_37 = __pad_RCmUrP0i3FoMIg2Lm0szhu_1.VertexBuffers;
                var Index_Buffer_38 = __pad_RCmUrP0i3FoMIg2Lm0szhu_1.IndexBuffer;
                var Is_32Bit_39 = Index_Buffer_38.Is32Bit;
                var Offset_40 = Index_Buffer_38.Offset;
                var Buffer_41 = Index_Buffer_38.Buffer;
                __auto_29.SetIndexBuffer(buffer: Buffer_41, offset: Offset_40, is32bits: Is_32Bit_39);
                var Start_Location_42 = __pad_RCmUrP0i3FoMIg2Lm0szhu_1.StartLocation;
                var Draw_Count_43 = __pad_RCmUrP0i3FoMIg2Lm0szhu_1.DrawCount;
                int Base_Vertex_Location_44 = 0;
                int Start_Instance_Location_45 = 0;
                __auto_29.DrawIndexedInstanced(indexCountPerInstance: Draw_Count_43, instanceCount: __auto_2, startIndexLocation: Start_Location_42, baseVertexLocation: Base_Vertex_Location_44, startInstanceLocation: Start_Instance_Location_45);
                __auto_31 = __auto_29;
            }
            else
            {
                __auto_31 = __auto_29;
            }

            n17._Operations_.NULL<n3.Buffer[]>(Result_Out: out n3.Buffer[] Result_46);
            __auto_31.SetStreamTargets(buffers: Result_46);
            return this;
        }

        public n4.MeshDrawerStreamOut_C Update(n3.PrimitiveType Topology_In, n3.Buffer Stream_Out_Buffer_In, n10.IEffect Effect_Instance_In, int Instance_Count_In, n8.MeshDraw Mesh_Draw_In)
        {
            this.Topology = Topology_In;
            n3.PrimitiveType __auto_0 = Topology_In;
            bool Force_1 = false;
            var State_Output_3 = this.__p_EJsPsVwiyG1PjQM0gXqj4H.Update(Input_In: Stream_Out_Buffer_In, Force_In: Force_1, Output_Out: out n3.Buffer[] Output_2);
            this.__p_EJsPsVwiyG1PjQM0gXqj4H = State_Output_3;
            this.Buffers = Output_2;
            n3.Buffer[] __auto_4 = Output_2;
            this.Effect = Effect_Instance_In;
            n10.IEffect __auto_5 = Effect_Instance_In;
            this.Instance_Count = Instance_Count_In;
            int __auto_6 = Instance_Count_In;
            this.__slot_RCmUrP0i3FoMIg2Lm0szhu = Mesh_Draw_In;
            n8.MeshDraw __pad_RCmUrP0i3FoMIg2Lm0szhu_7 = Mesh_Draw_In;
            return this;
        }

        public n4.MeshDrawerStreamOut_C __Create__(n1.NodeContext Node_Context)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_RCmUrP0i3FoMIg2Lm0szhu = default(n8.MeshDraw);
            this.Sampler_State = default(n3.SamplerState);
            this.Mutable_Pipeline_State = default(n3.MutablePipelineState);
            this.Topology = default(n3.PrimitiveType);
            this.Buffers = n11._Operations_.CreateDefault<n3.Buffer>();
            this.Instance_Count = 0;
            this.Effect = default(n10.IEffect);
            n36.TextureFilter __pad_EGc7lmBvlM4LpSh9Wm34KT_0 = __slot_EGc7lmBvlM4LpSh9Wm34KT;
            n36.TextureAddressMode __pad_KUf4UeoynGHMx4bWkye3Ul_1 = __slot_KUf4UeoynGHMx4bWkye3Ul;
            n3.PrimitiveType __pad_FwAsFM2LAazNA5LjNSl4o5_2 = __slot_FwAsFM2LAazNA5LjNSl4o5;
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "G90yNPVlSvXMV1azhcbDyL", 31782U);
            var Output_4 = n37.GameProvider_Pd38wXWKEIYP1l5KGR7wKt.Create(Node_Context_In: Node_Context_3);
            this.__p_G90yNPVlSvXMV1azhcbDyL = Output_4;
            var Output_6 = Output_4.GetGraphicsDevice(Graphics_Device_Out: out n3.GraphicsDevice Graphics_Device_5);
            this.__p_G90yNPVlSvXMV1azhcbDyL = Output_6;
            var Output_7 = new n36.SamplerStateDescription(filter: __pad_EGc7lmBvlM4LpSh9Wm34KT_0, addressMode: __pad_KUf4UeoynGHMx4bWkye3Ul_1);
            var Result_8 = n3.SamplerState.New(graphicsDevice: Graphics_Device_5, samplerStateDescription: Output_7);
            this.Sampler_State = Result_8;
            n3.SamplerState __auto_9 = Result_8;
            var Output_10 = new n3.MutablePipelineState(graphicsDevice: Graphics_Device_5);
            var State_11 = Output_10.State;
            this.Mutable_Pipeline_State = Output_10;
            n3.MutablePipelineState __auto_12 = Output_10;
            State_11.SetDefaults();
            State_11.PrimitiveType = __pad_FwAsFM2LAazNA5LjNSl4o5_2;
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "EJsPsVwiyG1PjQM0gXqj4H", 31492U);
            var Output_14 = n11.FromValue_OH4TKYsSUseQU3JpOZF4kZ<n3.Buffer>.Create(Node_Context: Node_Context_13);
            this.__p_EJsPsVwiyG1PjQM0gXqj4H = Output_14;
            return this;
        }

        public n4.MeshDrawerStreamOut_C __CreateDefault__()
        {
            this.__slot_RCmUrP0i3FoMIg2Lm0szhu = default(n8.MeshDraw);
            this.Sampler_State = default(n3.SamplerState);
            this.Mutable_Pipeline_State = default(n3.MutablePipelineState);
            this.Topology = default(n3.PrimitiveType);
            this.Buffers = n11._Operations_.CreateDefault<n3.Buffer>();
            this.Instance_Count = 0;
            this.Effect = default(n10.IEffect);
            this.__p_EJsPsVwiyG1PjQM0gXqj4H = n11.FromValue_OH4TKYsSUseQU3JpOZF4kZ<n3.Buffer>.CreateDefault();
            this.__p_G90yNPVlSvXMV1azhcbDyL = n37.GameProvider_Pd38wXWKEIYP1l5KGR7wKt.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_EJsPsVwiyG1PjQM0gXqj4H);
            n1.CompilationHelper.SafeDispose(this.__p_G90yNPVlSvXMV1azhcbDyL);
            return;
        }

        void n8.IGraphicsRendererBase.Draw(n8.RenderDrawContext context)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Draw_(context);
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 31014U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "EGc7lmBvlM4LpSh9Wm34KT", Name = "__slot_EGc7lmBvlM4LpSh9Wm34KT")]
        public static n36.TextureFilter __slot_EGc7lmBvlM4LpSh9Wm34KT = n1.CompilationHelper.Deserialize<n36.TextureFilter>("Linear", false, "NL6SEAZgmRHQPFCm3uYN3A", "EGc7lmBvlM4LpSh9Wm34KT");
        [n1.ElementAttribute(TracingId = 31022U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "KUf4UeoynGHMx4bWkye3Ul", Name = "__slot_KUf4UeoynGHMx4bWkye3Ul")]
        public static n36.TextureAddressMode __slot_KUf4UeoynGHMx4bWkye3Ul = n1.CompilationHelper.Deserialize<n36.TextureAddressMode>("Clamp", false, "NL6SEAZgmRHQPFCm3uYN3A", "KUf4UeoynGHMx4bWkye3Ul");
        [n1.ElementAttribute(TracingId = 31465U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "FwAsFM2LAazNA5LjNSl4o5", Name = "__slot_FwAsFM2LAazNA5LjNSl4o5")]
        public static n3.PrimitiveType __slot_FwAsFM2LAazNA5LjNSl4o5 = n1.CompilationHelper.Deserialize<n3.PrimitiveType>("PointList", false, "NL6SEAZgmRHQPFCm3uYN3A", "FwAsFM2LAazNA5LjNSl4o5");
        [n1.ElementAttribute(TracingId = 31745U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "RCmUrP0i3FoMIg2Lm0szhu", Name = "__slot_RCmUrP0i3FoMIg2Lm0szhu")]
        public n8.MeshDraw __slot_RCmUrP0i3FoMIg2Lm0szhu;
        [n1.ElementAttribute(TracingId = 31031U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "CQqRzb7wcPmNbz0Rw9eESo", Name = "Sampler State")]
        public n3.SamplerState Sampler_State;
        [n1.ElementAttribute(TracingId = 31050U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "LVLqrC7VcqlLL4texjGakl", Name = "Mutable Pipeline State")]
        public n3.MutablePipelineState Mutable_Pipeline_State;
        [n1.ElementAttribute(TracingId = 31420U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "QqdSBl6iaj8QNaSOSbjbDz", Name = "Topology")]
        public n3.PrimitiveType Topology;
        [n1.ElementAttribute(TracingId = 31434U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "V0MFYwh4a6KOLPRyWZXDmE", Name = "Buffers")]
        public n3.Buffer[] Buffers;
        [n1.ElementAttribute(TracingId = 31761U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "RlAy2S0iydJQC2LSOJRpYa", Name = "Instance Count")]
        public int Instance_Count;
        [n1.ElementAttribute(TracingId = 31430U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "NSotyrthTKnLV6txgPHw3Y", Name = "Effect")]
        public n10.IEffect Effect;
        [n1.ElementAttribute(TracingId = 31492U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "EJsPsVwiyG1PjQM0gXqj4H", Name = "FromValue", IsManaged = true, IsAutoGenerated = true)]
        public n11.FromValue_OH4TKYsSUseQU3JpOZF4kZ<n3.Buffer> __p_EJsPsVwiyG1PjQM0gXqj4H;
        [n1.ElementAttribute(TracingId = 31782U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "G90yNPVlSvXMV1azhcbDyL", Name = "GameProvider", IsManaged = true, IsAutoGenerated = true)]
        public n37.GameProvider_Pd38wXWKEIYP1l5KGR7wKt __p_G90yNPVlSvXMV1azhcbDyL;
        static MeshDrawerStreamOut_C()
        {
        }

        public MeshDrawerStreamOut_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal MeshDrawerStreamOut_C(MeshDrawerStreamOut_C other): base(other)
        {
            this.__slot_RCmUrP0i3FoMIg2Lm0szhu = other.__slot_RCmUrP0i3FoMIg2Lm0szhu;
            this.Sampler_State = other.Sampler_State;
            this.Mutable_Pipeline_State = other.Mutable_Pipeline_State;
            this.Topology = other.Topology;
            this.Buffers = other.Buffers;
            this.Instance_Count = other.Instance_Count;
            this.Effect = other.Effect;
            this.__p_EJsPsVwiyG1PjQM0gXqj4H = other.__p_EJsPsVwiyG1PjQM0gXqj4H;
            this.__p_G90yNPVlSvXMV1azhcbDyL = other.__p_G90yNPVlSvXMV1azhcbDyL;
        }

        protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_RCmUrP0i3FoMIg2Lm0szhu", in __slot_RCmUrP0i3FoMIg2Lm0szhu), n1.CompilationHelper.GetValueOrExisting(values, "Sampler_State", in Sampler_State), n1.CompilationHelper.GetValueOrExisting(values, "Mutable_Pipeline_State", in Mutable_Pipeline_State), n1.CompilationHelper.GetValueOrExisting(values, "Topology", in Topology), n1.CompilationHelper.GetValueOrExisting(values, "Buffers", in Buffers), n1.CompilationHelper.GetValueOrExisting(values, "Instance_Count", in Instance_Count), n1.CompilationHelper.GetValueOrExisting(values, "Effect", in Effect), n1.CompilationHelper.GetValueOrExisting(values, "__p_EJsPsVwiyG1PjQM0gXqj4H", in __p_EJsPsVwiyG1PjQM0gXqj4H), n1.CompilationHelper.GetValueOrExisting(values, "__p_G90yNPVlSvXMV1azhcbDyL", in __p_G90yNPVlSvXMV1azhcbDyL));
        }

        internal MeshDrawerStreamOut_C __WITH__(n8.MeshDraw __slot_RCmUrP0i3FoMIg2Lm0szhu, n3.SamplerState Sampler_State, n3.MutablePipelineState Mutable_Pipeline_State, n3.PrimitiveType Topology, n3.Buffer[] Buffers, int Instance_Count, n10.IEffect Effect, n11.FromValue_OH4TKYsSUseQU3JpOZF4kZ<n3.Buffer> __p_EJsPsVwiyG1PjQM0gXqj4H, n37.GameProvider_Pd38wXWKEIYP1l5KGR7wKt __p_G90yNPVlSvXMV1azhcbDyL)
        {
            n4.MeshDrawerStreamOut_C that_0 = this;
            this.__slot_RCmUrP0i3FoMIg2Lm0szhu = __slot_RCmUrP0i3FoMIg2Lm0szhu;
            this.Sampler_State = Sampler_State;
            this.Mutable_Pipeline_State = Mutable_Pipeline_State;
            this.Topology = Topology;
            this.Buffers = Buffers;
            this.Instance_Count = Instance_Count;
            this.Effect = Effect;
            this.__p_EJsPsVwiyG1PjQM0gXqj4H = __p_EJsPsVwiyG1PjQM0gXqj4H;
            this.__p_G90yNPVlSvXMV1azhcbDyL = __p_G90yNPVlSvXMV1azhcbDyL;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 33814U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "VPD0Bjs7T2mNWOzwXPAy9U", Name = "StreamOutModelComponent_C")]
    [n2.SerializableAttribute]
    public class StreamOutModelComponent_C : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.StreamOutModelComponent_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new StreamOutModelComponent_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.StreamOutModelComponent_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new StreamOutModelComponent_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.StreamOutModelComponent_C Update(n8.Material Material_In, n3.PrimitiveType Primitive_Type_In, n3.Buffer Vertex_Buffer_In, n3.VertexDeclaration Vertex_Declaration_In, int Vertex_Count_In)
        {
            n8.Model __auto_0 = this.Model;
            n8.MeshDraw __auto_1 = this.Mesh_Draw;
            var Output_4 = this.__p_Mnh4j6eKyvJQEYbELchA01.Update(Value_In: Material_In, Result_Out: out bool Result_2, Unchanged_Out: out bool Unchanged_3);
            this.__p_Mnh4j6eKyvJQEYbELchA01 = Output_4;
            if (Result_2)
            {
                n39._Operations_.SetSingleMaterial(Model_In: __auto_0, Material_In: Material_In, Output_Out: out n8.Model Output_6);
            }

            __auto_1.PrimitiveType = Primitive_Type_In;
            n7.ObjectHelpers.IsAssigned(x: Vertex_Buffer_In, result: out bool Result_7, notAssigned: out bool Not_Assigned_8);
            n7.ObjectHelpers.IsAssigned(x: Vertex_Declaration_In, result: out bool Result_9, notAssigned: out bool Not_Assigned_10);
            var Output_11 = Result_7 && Result_9;
            n8.MeshDraw __auto_12;
            if (Output_11)
            {
                int Vertex_Stride_14 = -1;
                int Vertex_Offset_15 = 0;
                var Output_16 = new n3.VertexBufferBinding(vertexBuffer: Vertex_Buffer_In, vertexDeclaration: Vertex_Declaration_In, vertexCount: Vertex_Count_In, vertexStride: Vertex_Stride_14, vertexOffset: Vertex_Offset_15);
                n11._Operations_.ToArray<n3.VertexBufferBinding>(Input_In: Output_16, Result_Out: out n3.VertexBufferBinding[] Result_17);
                __auto_1.VertexBuffers = Result_17;
                __auto_12 = __auto_1;
            }
            else
            {
                __auto_12 = __auto_1;
            }

            __auto_12.DrawCount = Vertex_Count_In;
            return this;
        }

        public n4.StreamOutModelComponent_C GetComponent(out n12.ModelComponent Component_Out)
        {
            n12.ModelComponent __auto_0 = this.Component;
            Component_Out = __auto_0;
            return this;
        }

        public n4.StreamOutModelComponent_C SetBoundingBox(n14.BoundingBox Bounding_Box_In)
        {
            n8.Model __auto_0 = this.Model;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_GECRTieQSGmOPAVChicclB;
            if (manager_3 is null)
            {
                manager_3 = new n35.Manager<n2.ValueTuple<n14.BoundingBox>, n2.ValueTuple>(n2.ValueTuple.Create());
            }

            var inputs_4 = n2.ValueTuple.Create(Bounding_Box_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var Meshes_8 = __auto_0.Meshes;
                n8.Mesh Default_Value_9 = default(n8.Mesh);
                n15._Operations_.FirstOrDefault<n16.List<n8.Mesh>, n8.Mesh>(Input_In: Meshes_8, Default_Value_In: Default_Value_9, Output_Out: out n16.List<n8.Mesh> Output_10, Result_Out: out n8.Mesh Result_11);
                Result_11.BoundingBox = Bounding_Box_In;
                outputs_5 = n2.ValueTuple.Create();
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, default, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            this.__cache_GECRTieQSGmOPAVChicclB = manager_3;
            return this;
        }

        public n4.StreamOutModelComponent_C SetRenderGroup(n8.RenderGroup Render_Group_In)
        {
            n12.ModelComponent __auto_0 = this.Component;
            __auto_0.RenderGroup = Render_Group_In;
            return this;
        }

        public n4.StreamOutModelComponent_C __Create__(n1.NodeContext Node_Context)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Component = default(n12.ModelComponent);
            this.Mesh_Draw = default(n8.MeshDraw);
            this.Model = default(n8.Model);
            this.__pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T = n27._Operations_.CreateDefault<n14.Vector4>();
            n14.Vector4 __pad_Azh6byGCH3CMusKzaPT5xH_0 = __slot_Azh6byGCH3CMusKzaPT5xH;
            bool __pad_TZZ70QdUBKvOzR8YTreMy4_1 = __slot_TZZ70QdUBKvOzR8YTreMy4;
            var Output_2 = new n8.MeshDraw();
            var Output_3 = new n8.Mesh();
            n18._Operations_.CreateUnitBoundingBox(Output_Out: out n14.BoundingBox Output_4);
            Output_3.BoundingBox = Output_4;
            Output_3.Draw = Output_2;
            var Output_5 = new n8.Model();
            var Meshes_6 = Output_5.Meshes;
            Meshes_6.Add(item: Output_3);
            var Output_7 = new n12.ModelComponent(model: Output_5);
            this.Component = Output_7;
            n12.ModelComponent __auto_8 = Output_7;
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "AGYHMFIS2KsM6zK1T633l6", 35008U);
            var Output_11 = n40.ComponentManager_Mp1an8YjRmjLSMhA4AMi5G.Create(Node_Context: Node_Context_9, Component_In: Output_7, Component_Out: out n12.EntityComponent Component_10);
            this.__p_AGYHMFIS2KsM6zK1T633l6 = Output_11;
            this.Model = Output_5;
            n8.Model __auto_12 = Output_5;
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "L9BtQwjlQnLODBpFCPGRhk", 34751U);
            var Output_14 = n28.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n23.Spread<n14.Vector4>>.Create(Node_Context: Node_Context_13);
            this.__p_L9BtQwjlQnLODBpFCPGRhk = Output_14;
            var builder_15 = n6.CollectionBuilders.GetBuilder(n27._Operations_.CreateDefault<n14.Vector4>(), 1);
            builder_15.Add(__pad_Azh6byGCH3CMusKzaPT5xH_0);
            var __pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T_16 = builder_15.Commit();
            this.__pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T = __pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T_16;
            n27._Operations_.FromValue<n14.Vector4>(Input_In: __pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T_16, Result_Out: out n23.Spread<n14.Vector4> Result_17);
            int Element_Size_In_Bytes_18 = 0;
            int Offset_In_Bytes_19 = 0;
            bool Is_Structured_Buffer_20 = false;
            bool Is_Index_Buffer_21 = false;
            bool Allow_Raw_Views_22 = false;
            bool Recreate_23 = false;
            bool Apply_24 = true;
            var State_Output_27 = Output_14.Update<n41.__AdaptiveImplementations__NL6SEAZgmRHQPFCm3uYN3A>(Input_In: Result_17, Element_Size_In_Bytes_In: Element_Size_In_Bytes_18, Offset_In_Bytes_In: Offset_In_Bytes_19, Is_Structured_Buffer_In: Is_Structured_Buffer_20, Is_Vertex_Buffer_In: __pad_TZZ70QdUBKvOzR8YTreMy4_1, Is_Index_Buffer_In: Is_Index_Buffer_21, Allow_Raw_Views_In: Allow_Raw_Views_22, Recreate_In: Recreate_23, Apply_In: Apply_24, Output_Out: out n3.Buffer Output_25, Has_Changed_Out: out bool Has_Changed_26);
            this.__p_L9BtQwjlQnLODBpFCPGRhk = State_Output_27;
            n1.NodeContext Node_Context_28 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "IxZU8QPZiGiL8n6KaugRBg", 34977U);
            var Output_29 = n31.Pos4_VRjiXKBp4VDPqPzXrIixwv.Create(Node_Context: Node_Context_28);
            this.__p_IxZU8QPZiGiL8n6KaugRBg = Output_29;
            var State_Output_31 = Output_29.Update(Output_Out: out n3.VertexDeclaration Output_30);
            this.__p_IxZU8QPZiGiL8n6KaugRBg = State_Output_31;
            int Vertex_Count_32 = 1;
            int Vertex_Stride_33 = -1;
            int Vertex_Offset_34 = 0;
            var Output_35 = new n3.VertexBufferBinding(vertexBuffer: Output_25, vertexDeclaration: Output_30, vertexCount: Vertex_Count_32, vertexStride: Vertex_Stride_33, vertexOffset: Vertex_Offset_34);
            n11._Operations_.ToArray<n3.VertexBufferBinding>(Input_In: Output_35, Result_Out: out n3.VertexBufferBinding[] Result_36);
            Output_2.VertexBuffers = Result_36;
            this.Mesh_Draw = Output_2;
            n8.MeshDraw __auto_37 = Output_2;
            n1.NodeContext Node_Context_38 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "Mnh4j6eKyvJQEYbELchA01", 34980U);
            bool Changed_On_Create_39 = true;
            var Output_40 = n32.Changed_A8JGbead2bxNdnPybiEqVS<n8.Material>.Create<n41.__AdaptiveImplementations__NL6SEAZgmRHQPFCm3uYN3A>(Node_Context: Node_Context_38, Changed_On_Create_In: Changed_On_Create_39);
            this.__p_Mnh4j6eKyvJQEYbELchA01 = Output_40;
            this.__cache_GECRTieQSGmOPAVChicclB = null;
            return this;
        }

        public n4.StreamOutModelComponent_C Dispose_()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Mnh4j6eKyvJQEYbELchA01);
            n1.CompilationHelper.SafeDispose(this.__cache_GECRTieQSGmOPAVChicclB);
            n1.CompilationHelper.SafeDispose(this.__p_AGYHMFIS2KsM6zK1T633l6);
            n1.CompilationHelper.SafeDispose(this.__p_L9BtQwjlQnLODBpFCPGRhk);
            n1.CompilationHelper.SafeDispose(this.__p_IxZU8QPZiGiL8n6KaugRBg);
            return this;
        }

        public n4.StreamOutModelComponent_C __CreateDefault__()
        {
            this.Component = default(n12.ModelComponent);
            this.Mesh_Draw = default(n8.MeshDraw);
            this.Model = default(n8.Model);
            this.__pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T = n27._Operations_.CreateDefault<n14.Vector4>();
            this.__p_Mnh4j6eKyvJQEYbELchA01 = n32.Changed_A8JGbead2bxNdnPybiEqVS<n8.Material>.CreateDefault<n41.__AdaptiveImplementations__NL6SEAZgmRHQPFCm3uYN3A>();
            this.__cache_GECRTieQSGmOPAVChicclB = null;
            this.__p_AGYHMFIS2KsM6zK1T633l6 = n40.ComponentManager_Mp1an8YjRmjLSMhA4AMi5G.CreateDefault();
            this.__p_L9BtQwjlQnLODBpFCPGRhk = n28.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n23.Spread<n14.Vector4>>.CreateDefault();
            this.__p_IxZU8QPZiGiL8n6KaugRBg = n31.Pos4_VRjiXKBp4VDPqPzXrIixwv.CreateDefault();
            return this;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 34777U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "Azh6byGCH3CMusKzaPT5xH", Name = "__slot_Azh6byGCH3CMusKzaPT5xH")]
        public static n14.Vector4 __slot_Azh6byGCH3CMusKzaPT5xH = n38._Operations_.CreateDefault();
        [n1.ElementAttribute(TracingId = 34845U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "TZZ70QdUBKvOzR8YTreMy4", Name = "__slot_TZZ70QdUBKvOzR8YTreMy4")]
        public static bool __slot_TZZ70QdUBKvOzR8YTreMy4 = true;
        [n1.ElementAttribute(TracingId = 34670U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "ARaB6BEgXscMTloXTncahS", Name = "Component")]
        public n12.ModelComponent Component;
        [n1.ElementAttribute(TracingId = 34674U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "NmYbtMTACDRMbb326ALQts", Name = "Mesh Draw")]
        public n8.MeshDraw Mesh_Draw;
        [n1.ElementAttribute(TracingId = 35005U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "GzO5fBnEOGnLGhpnHSwc6z", Name = "Model")]
        public n8.Model Model;
        [n1.ElementAttribute(TracingId = 34980U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "Mnh4j6eKyvJQEYbELchA01", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n32.Changed_A8JGbead2bxNdnPybiEqVS<n8.Material> __p_Mnh4j6eKyvJQEYbELchA01;
        [n1.ElementAttribute(TracingId = 34884U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "GECRTieQSGmOPAVChicclB", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n35.Manager<n2.ValueTuple<n14.BoundingBox>, n2.ValueTuple> __cache_GECRTieQSGmOPAVChicclB = null;
        [n1.ElementAttribute(TracingId = 35008U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "AGYHMFIS2KsM6zK1T633l6", Name = "ComponentManager", IsManaged = true, IsAutoGenerated = true)]
        public n40.ComponentManager_Mp1an8YjRmjLSMhA4AMi5G __p_AGYHMFIS2KsM6zK1T633l6;
        [n1.ElementAttribute(TracingId = 34751U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "L9BtQwjlQnLODBpFCPGRhk", Name = "DynamicBuffer", IsManaged = true, IsAutoGenerated = true)]
        public n28.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n23.Spread<n14.Vector4>> __p_L9BtQwjlQnLODBpFCPGRhk;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n23.Spread<n14.Vector4> __pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T = default(n23.Spread<n14.Vector4>);
        [n1.ElementAttribute(TracingId = 34977U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "IxZU8QPZiGiL8n6KaugRBg", Name = "Pos4", IsManaged = true, IsAutoGenerated = true)]
        public n31.Pos4_VRjiXKBp4VDPqPzXrIixwv __p_IxZU8QPZiGiL8n6KaugRBg;
        static StreamOutModelComponent_C()
        {
        }

        public StreamOutModelComponent_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal StreamOutModelComponent_C(StreamOutModelComponent_C other): base(other)
        {
            this.Component = other.Component;
            this.Mesh_Draw = other.Mesh_Draw;
            this.Model = other.Model;
            this.__p_Mnh4j6eKyvJQEYbELchA01 = other.__p_Mnh4j6eKyvJQEYbELchA01;
            this.__cache_GECRTieQSGmOPAVChicclB = other.__cache_GECRTieQSGmOPAVChicclB;
            this.__p_AGYHMFIS2KsM6zK1T633l6 = other.__p_AGYHMFIS2KsM6zK1T633l6;
            this.__p_L9BtQwjlQnLODBpFCPGRhk = other.__p_L9BtQwjlQnLODBpFCPGRhk;
            this.__pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T = other.__pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T;
            this.__p_IxZU8QPZiGiL8n6KaugRBg = other.__p_IxZU8QPZiGiL8n6KaugRBg;
        }

        protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Component", in Component), n1.CompilationHelper.GetValueOrExisting(values, "Mesh_Draw", in Mesh_Draw), n1.CompilationHelper.GetValueOrExisting(values, "Model", in Model), n1.CompilationHelper.GetValueOrExisting(values, "__p_Mnh4j6eKyvJQEYbELchA01", in __p_Mnh4j6eKyvJQEYbELchA01), n1.CompilationHelper.GetValueOrExisting(values, "__cache_GECRTieQSGmOPAVChicclB", in __cache_GECRTieQSGmOPAVChicclB), n1.CompilationHelper.GetValueOrExisting(values, "__p_AGYHMFIS2KsM6zK1T633l6", in __p_AGYHMFIS2KsM6zK1T633l6), n1.CompilationHelper.GetValueOrExisting(values, "__p_L9BtQwjlQnLODBpFCPGRhk", in __p_L9BtQwjlQnLODBpFCPGRhk), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T", in __pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T), n1.CompilationHelper.GetValueOrExisting(values, "__p_IxZU8QPZiGiL8n6KaugRBg", in __p_IxZU8QPZiGiL8n6KaugRBg));
        }

        internal StreamOutModelComponent_C __WITH__(n12.ModelComponent Component, n8.MeshDraw Mesh_Draw, n8.Model Model, n32.Changed_A8JGbead2bxNdnPybiEqVS<n8.Material> __p_Mnh4j6eKyvJQEYbELchA01, n35.Manager<n2.ValueTuple<n14.BoundingBox>, n2.ValueTuple> __cache_GECRTieQSGmOPAVChicclB, n40.ComponentManager_Mp1an8YjRmjLSMhA4AMi5G __p_AGYHMFIS2KsM6zK1T633l6, n28.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n23.Spread<n14.Vector4>> __p_L9BtQwjlQnLODBpFCPGRhk, n23.Spread<n14.Vector4> __pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T, n31.Pos4_VRjiXKBp4VDPqPzXrIixwv __p_IxZU8QPZiGiL8n6KaugRBg)
        {
            n4.StreamOutModelComponent_C that_0 = this;
            this.Component = Component;
            this.Mesh_Draw = Mesh_Draw;
            this.Model = Model;
            this.__p_Mnh4j6eKyvJQEYbELchA01 = __p_Mnh4j6eKyvJQEYbELchA01;
            this.__cache_GECRTieQSGmOPAVChicclB = __cache_GECRTieQSGmOPAVChicclB;
            this.__p_AGYHMFIS2KsM6zK1T633l6 = __p_AGYHMFIS2KsM6zK1T633l6;
            this.__p_L9BtQwjlQnLODBpFCPGRhk = __p_L9BtQwjlQnLODBpFCPGRhk;
            this.__pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T = __pin_group_Input_In_PyiybyjJiJtQPrtSe96R5T;
            this.__p_IxZU8QPZiGiL8n6KaugRBg = __p_IxZU8QPZiGiL8n6KaugRBg;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 35249U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "DbyCuy9U0UpK95gjQWxDXj", Name = "StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj")]
    [n2.SerializableAttribute]
    public class StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T> : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T> Create<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T[]>
        {
            var instance = new StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__<AdM>(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T> CreateDefault<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T[]>
        {
            var instance = new StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__<AdM>();
        }

        public n4.StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T> Update<AdM>(n8.Mesh Mesh_In, [n6.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, [n6.SerializedDefaultValueAttribute("10000", false)] int Max_Instance_Count_In, n8.Material Material_In, T[] Instance_Transformations_In, out n23.Spread<n12.EntityComponent> Components_Out, out int Vertex_Count_Out)
            where AdM : struct, n24.IAdaptiveSetGraphicsData<T[]>
        {
            var w_0 = default(AdM);
            n3.PrimitiveType __pad_VJhdixHM1rXL5HQ3uUciMg_1 = __slot_VJhdixHM1rXL5HQ3uUciMg;
            n3.PrimitiveType __pad_CsAPIP1I7LDLMIB4eccBcU_2 = __slot_CsAPIP1I7LDLMIB4eccBcU;
            bool __pad_AqodGclsRGbN38cJZtHgSK_3 = __slot_AqodGclsRGbN38cJZtHgSK;
            n7.ObjectHelpers.IsAssigned(x: Mesh_In, result: out bool Result_4, notAssigned: out bool Not_Assigned_5);
            n8.Mesh __auto_6;
            var state_7 = n1.CompilationHelper.Restore<__Kb5Zq1RmMspMmwLIwNTMm0>(this.__if_TDcxKfEudH2OIFoAn6wnUA, __GetContext__());
            if (Not_Assigned_5)
            {
                if (state_7 == null)
                {
                    state_7 = new __Kb5Zq1RmMspMmwLIwNTMm0(__GetContext__(), n1.VLObject.NewIdentity());
                    var node_8 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BoxMesh", "Stride.Models.Meshes");
                    state_7.__p_LdF0mSWmmuUP56ZjBqNAmR = node_8;
                }

                n1.CompilationHelper.ReadPin(state_7.__p_LdF0mSWmmuUP56ZjBqNAmR.Outputs[0], out n8.Mesh out_9);
                __auto_6 = out_9;
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = state_7.__p_LdF0mSWmmuUP56ZjBqNAmR != state_7.__p_LdF0mSWmmuUP56ZjBqNAmR ? new __Kb5Zq1RmMspMmwLIwNTMm0(state_7)
                    {__p_LdF0mSWmmuUP56ZjBqNAmR = state_7.__p_LdF0mSWmmuUP56ZjBqNAmR} : state_7;
                else
                {
                    state_7.__p_LdF0mSWmmuUP56ZjBqNAmR = state_7.__p_LdF0mSWmmuUP56ZjBqNAmR;
                }
            }
            else
            {
                __auto_6 = Mesh_In;
            }

            var Output_13 = this.__p_LAemX8Ltd3ALIo1J4kzo6J.Update(Mesh_In: __auto_6, Mesh_Draw_Out: out n8.MeshDraw Mesh_Draw_10, Has_Tangent_Out: out bool Has_Tangent_11, Draw_Count_Out: out int Draw_Count_12);
            var Output_14 = Draw_Count_12 * Max_Instance_Count_In;
            var State_Output_16 = this.__p_ShjgkOdE4vSP0BDWFaImFs.Update(Output_Out: out n3.VertexDeclaration Output_15);
            var Vertex_Stride_17 = Output_15.VertexStride;
            n9.IGraphicsDataProvider Initial_Data_18 = default(n9.IGraphicsDataProvider);
            bool Is_Unordered_Access_19 = true;
            n9.StructuredBufferType Structured_Buffer_Type_20 = n1.CompilationHelper.Deserialize<n9.StructuredBufferType>("StructuredBuffer", false, null, null);
            bool Allow_Raw_Views_21 = false;
            bool Recreate_22 = false;
            var State_Output_25 = this.__p_OX8jqbpLVdUO6oVHPxpmMg.Update(Element_Count_In: Output_14, Element_Size_In_Bytes_In: Vertex_Stride_17, Initial_Data_In: Initial_Data_18, Is_Unordered_Access_In: Is_Unordered_Access_19, Structured_Buffer_Type_In: Structured_Buffer_Type_20, Is_Stream_Output_In: __pad_AqodGclsRGbN38cJZtHgSK_3, Allow_Raw_Views_In: Allow_Raw_Views_21, Recreate_In: Recreate_22, Output_Out: out n3.Buffer Output_23, Has_Changed_Out: out bool Has_Changed_24);
            int Element_Size_In_Bytes_26 = 0;
            int Offset_In_Bytes_27 = 0;
            bool Is_Structured_Buffer_28 = false;
            bool Is_Vertex_Buffer_29 = false;
            bool Is_Index_Buffer_30 = false;
            bool Allow_Raw_Views_31 = false;
            bool Recreate_32 = false;
            bool Apply_33 = true;
            var State_Output_36 = this.__p_OtgASnr4P7xL980xzAxSsd.Update<AdM>(Input_In: Instance_Transformations_In, Element_Size_In_Bytes_In: Element_Size_In_Bytes_26, Offset_In_Bytes_In: Offset_In_Bytes_27, Is_Structured_Buffer_In: Is_Structured_Buffer_28, Is_Vertex_Buffer_In: Is_Vertex_Buffer_29, Is_Index_Buffer_In: Is_Index_Buffer_30, Allow_Raw_Views_In: Allow_Raw_Views_31, Recreate_In: Recreate_32, Apply_In: Apply_33, Output_Out: out n3.Buffer Output_34, Has_Changed_Out: out bool Has_Changed_35);
            n1.CompilationHelper.WritePin(this.__p_KyTnWRPsGHSOlA9cO9Y9cb.Inputs[0], ref Output_34);
            n1.CompilationHelper.ReadPin(this.__p_KyTnWRPsGHSOlA9cO9Y9cb.Outputs[0], out n10.IEffect out_37);
            n1.CompilationHelper.WritePin(this.__p_LPpXMZXReOhPZ7WT93JHvb.Inputs[0], ref Output_34);
            n1.CompilationHelper.ReadPin(this.__p_LPpXMZXReOhPZ7WT93JHvb.Outputs[0], out n10.IEffect out_38);
            n42._Operations_.Switch_Boolean<n10.IEffect>(Condition_In: Has_Tangent_11, Input_In: out_37, Input_2_In: out_38, Output_Out: out n10.IEffect Output_39);
            n11._Operations_.Length<T>(Input_In: Instance_Transformations_In, Output_Out: out T[] Output_40, Length_Out: out int Length_41);
            bool Update_42 = true;
            var Output_43 = this.__p_TsPWqq3MVTLO8B4jftYgHT;
            if (Update_42)
            {
                Output_43 = this.__p_TsPWqq3MVTLO8B4jftYgHT.Update(Topology_In: __pad_VJhdixHM1rXL5HQ3uUciMg_1, Stream_Out_Buffer_In: Output_23, Effect_Instance_In: Output_39, Instance_Count_In: Length_41, Mesh_Draw_In: Mesh_Draw_10);
            }

            n8.IGraphicsRendererBase Input_44 = (n8.IGraphicsRendererBase)Output_43;
            bool SetDrawer_45 = true;
            var Output_46 = this.__p_QsYhAUS9JYZP4WSsMGDd1u;
            if (SetDrawer_45)
            {
                Output_46 = this.__p_QsYhAUS9JYZP4WSsMGDd1u.SetDrawer(Input_In: Input_44);
            }

            bool SetEnabled_47 = true;
            var Output_48 = Output_46;
            if (SetEnabled_47)
            {
                Output_48 = Output_46.SetEnabled(Enabled_In: Enabled_In);
            }

            var Output_50 = this.__p_J953BWVPZphLnP0BWUOe2j.GetValue(Value_Out: out bool Value_49);
            var State_Output_52 = this.__p_JHeOgwxsg2LP4NqshXKUsz.Update(Output_Out: out n3.VertexDeclaration Output_51);
            n42._Operations_.Switch_Boolean<n3.VertexDeclaration>(Condition_In: Value_49, Input_In: Output_51, Input_2_In: Output_15, Output_Out: out n3.VertexDeclaration Output_53);
            var Output_55 = this.__p_KuI20UGqPB9MNyF9PlIhLk.GetValue(Value_Out: out int Value_54);
            bool Update_56 = true;
            var Output_57 = this.__p_CSKVBOXUoHsPUjBEim88jG;
            if (Update_56)
            {
                Output_57 = this.__p_CSKVBOXUoHsPUjBEim88jG.Update(Material_In: Material_In, Primitive_Type_In: __pad_CsAPIP1I7LDLMIB4eccBcU_2, Vertex_Buffer_In: Output_23, Vertex_Declaration_In: Output_53, Vertex_Count_In: Value_54);
            }

            n23.Spread<n12.EntityComponent> __auto_58 = this.Components;
            bool SetValue_59 = true;
            var Output_60 = Output_50;
            if (SetValue_59)
            {
                Output_60 = Output_50.SetValue(Value_In: Has_Tangent_11);
            }

            var Output_62 = this.__p_RDML4rFTwsNMnUE1PDAQSX.GetValue(Value_Out: out bool Value_61);
            bool Abort_63 = false;
            var __fallback___64 = n1.ServiceRegistry.Current;
            n21._Operations_.Update_H<n14.BoundingBox, n2.Object>(Input_In: this.__p_DuKIFJLNkFXPnCS1GBdcDi, Trigger_In: Value_61, Abort_In: Abort_63, Update_In: (n2.Object s_67, n13.CancellationToken Input_1_In_68) =>
            {
                using var __current_65 = __fallback___64.MakeCurrentIfNone();
                var state_66 = n1.CompilationHelper.Restore<__M6K98CKvlVyP0gGZMNPVF4>(s_67, __GetContext__());
                n16.IEnumerable<n14.Matrix> Default_69 = n15._Operations_.CreateDefault<n14.Matrix>();
                n17._Operations_.CastAs<n16.IEnumerable<n14.Matrix>>(Input_In: Instance_Transformations_In, Default_In: Default_69, Result_Out: out n16.IEnumerable<n14.Matrix> Result_70, Success_Out: out bool Success_71);
                n16.IEnumerable<n14.Matrix> __pad_RzkUcd3rCb9NU1LDI6jSZR_72 = Result_70;
                n43._Operations_.Half<float, n41.__AdaptiveImplementations__NL6SEAZgmRHQPFCm3uYN3A>(Half_Out: out float Half_73);
                n18._Operations_.CreateUnitBoundingBox(Output_Out: out n14.BoundingBox Output_74);
                n14.Vector3 Center_75 = n26._Operations_.CreateDefault();
                var Output_76 = new n14.BoundingSphere(center: Center_75, radius: Half_73);
                n14.BoundingBox __auto_77;
                if (Success_71)
                {
                    var One_79 = n14.Vector3.One;
                    n14.BoundingBox accumulator_81 = default(n14.BoundingBox);
                    n14.BoundingSphere accumulator_82 = default(n14.BoundingSphere);
                    var i_84 = 0;
                    foreach (var item_80 in __pad_RzkUcd3rCb9NU1LDI6jSZR_72)
                    {
                        var splicer_83 = item_80;
                        var i_local_85 = i_84;
                        var Translation_Vector_87 = splicer_83.TranslationVector;
                        var Result_88 = n19.AlignedBoxExtensions.CreateCenterSize(center: ref Translation_Vector_87, size: ref One_79);
                        n14.BoundingBox.Merge(value1: ref Result_88, value2: ref accumulator_81, result: out n14.BoundingBox Output_89);
                        n14.Vector3 Center_90 = n26._Operations_.CreateDefault();
                        var Output_91 = new n14.BoundingSphere(center: Center_90, radius: Half_73);
                        n14.BoundingSphere.Merge(value1: ref Output_91, value2: ref accumulator_82, result: out n14.BoundingSphere Output_92);
                        accumulator_81 = Output_89;
                        accumulator_82 = Output_92;
                        i_84++;
                    }

                    __auto_77 = accumulator_81;
                    n14.Matrix Default_Value_93 = n44._Operations_.CreateDefault();
                    n15._Operations_.FirstOrDefault<n16.IEnumerable<n14.Matrix>, n14.Matrix>(Input_In: __pad_RzkUcd3rCb9NU1LDI6jSZR_72, Default_Value_In: Default_Value_93, Output_Out: out n16.IEnumerable<n14.Matrix> Output_94, Result_Out: out n14.Matrix Result_95);
                }
                else
                {
                    __auto_77 = Output_74;
                }

                if (state_66.__GetContext__().IsImmutable)
                    state_66 = Result_70 != state_66.__slot_RzkUcd3rCb9NU1LDI6jSZR ? new __M6K98CKvlVyP0gGZMNPVF4(state_66)
                    {__slot_RzkUcd3rCb9NU1LDI6jSZR = Result_70} : state_66;
                else
                {
                    state_66.__slot_RzkUcd3rCb9NU1LDI6jSZR = Result_70;
                }

                return n2.Tuple.Create<n2.Object, n14.BoundingBox>(state_66, __auto_77);
            }

            , Create_In: () =>
            {
                using var __current_96 = __fallback___64.MakeCurrentIfNone();
                var state_66 = new __M6K98CKvlVyP0gGZMNPVF4(__GetContext__(), n1.VLObject.NewIdentity())
                {__slot_RzkUcd3rCb9NU1LDI6jSZR = n15._Operations_.CreateDefault<n14.Matrix>()};
                return state_66;
            }

            , Output_Out: out n20.AsyncTask<n14.BoundingBox> Output_97, Result_Out: out n2.IObservable<n14.BoundingBox> Result_98, In_Progress_Out: out bool In_Progress_99);
            bool Reset_100 = false;
            bool Update_101 = true;
            var Output_102 = this.__p_ScxsV06h0M2LNDimZK2lXE;
            if (Update_101)
            {
                n22._Operations_.Update_H<n14.BoundingBox>(Input_In: this.__p_ScxsV06h0M2LNDimZK2lXE, Async_Notifications_In: Result_98, Reset_In: Reset_100, Output_Out: out Output_102);
            }

            n22._Operations_.GetData_H<n14.BoundingBox>(Input_In: Output_102, Output_Out: out n20.HoldLatest<n14.BoundingBox> Output_103, Value_Out: out n14.BoundingBox Value_104, On_Data_Out: out bool On_Data_105);
            var Output_106 = Output_57;
            if (On_Data_105)
            {
                Output_106 = Output_57.SetBoundingBox(Bounding_Box_In: Value_104);
            }

            var Output_107 = Draw_Count_12 * Length_41;
            bool SetValue_108 = true;
            var Output_109 = Output_55;
            if (SetValue_108)
            {
                Output_109 = Output_55.SetValue(Value_In: Output_107);
            }

            var Output_112 = this.__p_PQditynQexDPdZfDCXIhqO.Update(Value_In: Instance_Transformations_In, Result_Out: out bool Result_110, Unchanged_Out: out bool Unchanged_111);
            float Time_113 = 1F;
            bool Retriggerable_114 = false;
            bool Reset_115 = false;
            var Output_118 = this.__p_F6EkCoqDBFANn20vbYkbxb.Update(Set_In: Result_110, Time_In: Time_113, Retriggerable_In: Retriggerable_114, Reset_In: Reset_115, Value_Out: out bool Value_116, Inverse_Output_Out: out bool Inverse_Output_117);
            var Output_121 = this.__p_KalBKYkNIBLLY6odbO55DN.Update(Value_In: Value_116, Up_Edge_Out: out bool Up_Edge_119, Down_Edge_Out: out bool Down_Edge_120);
            bool SetValue_122 = true;
            var Output_123 = Output_62;
            if (SetValue_122)
            {
                Output_123 = Output_62.SetValue(Value_In: Up_Edge_119);
            }

            var Maximum_124 = Value_104.Maximum;
            n14.Vector3 __pad_Sbk4MdEg1gSP7ce6fGHKVL_125 = Maximum_124;
            Components_Out = __auto_58;
            Vertex_Count_Out = Value_54;
            n4.StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T> that_126 = this;
            if (this.__GetContext__().IsImmutable)
                that_126 = state_7 != this.__if_TDcxKfEudH2OIFoAn6wnUA || Output_13 != this.__p_LAemX8Ltd3ALIo1J4kzo6J || State_Output_16 != this.__p_ShjgkOdE4vSP0BDWFaImFs || State_Output_25 != this.__p_OX8jqbpLVdUO6oVHPxpmMg || State_Output_36 != this.__p_OtgASnr4P7xL980xzAxSsd || this.__p_KyTnWRPsGHSOlA9cO9Y9cb != this.__p_KyTnWRPsGHSOlA9cO9Y9cb || this.__p_LPpXMZXReOhPZ7WT93JHvb != this.__p_LPpXMZXReOhPZ7WT93JHvb || Output_43 != this.__p_TsPWqq3MVTLO8B4jftYgHT || Output_48 != this.__p_QsYhAUS9JYZP4WSsMGDd1u || Output_60 != this.__p_J953BWVPZphLnP0BWUOe2j || State_Output_52 != this.__p_JHeOgwxsg2LP4NqshXKUsz || Output_109 != this.__p_KuI20UGqPB9MNyF9PlIhLk || Output_106 != this.__p_CSKVBOXUoHsPUjBEim88jG || Output_123 != this.__p_RDML4rFTwsNMnUE1PDAQSX || Output_97 != this.__p_DuKIFJLNkFXPnCS1GBdcDi || Output_103 != this.__p_ScxsV06h0M2LNDimZK2lXE || Output_112 != this.__p_PQditynQexDPdZfDCXIhqO || Output_118 != this.__p_F6EkCoqDBFANn20vbYkbxb || Output_121 != this.__p_KalBKYkNIBLLY6odbO55DN || Maximum_124 != this.__slot_Sbk4MdEg1gSP7ce6fGHKVL ? new StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T>(this)
                {__if_TDcxKfEudH2OIFoAn6wnUA = state_7, __p_LAemX8Ltd3ALIo1J4kzo6J = Output_13, __p_ShjgkOdE4vSP0BDWFaImFs = State_Output_16, __p_OX8jqbpLVdUO6oVHPxpmMg = State_Output_25, __p_OtgASnr4P7xL980xzAxSsd = State_Output_36, __p_KyTnWRPsGHSOlA9cO9Y9cb = this.__p_KyTnWRPsGHSOlA9cO9Y9cb, __p_LPpXMZXReOhPZ7WT93JHvb = this.__p_LPpXMZXReOhPZ7WT93JHvb, __p_TsPWqq3MVTLO8B4jftYgHT = Output_43, __p_QsYhAUS9JYZP4WSsMGDd1u = Output_48, __p_J953BWVPZphLnP0BWUOe2j = Output_60, __p_JHeOgwxsg2LP4NqshXKUsz = State_Output_52, __p_KuI20UGqPB9MNyF9PlIhLk = Output_109, __p_CSKVBOXUoHsPUjBEim88jG = Output_106, __p_RDML4rFTwsNMnUE1PDAQSX = Output_123, __p_DuKIFJLNkFXPnCS1GBdcDi = Output_97, __p_ScxsV06h0M2LNDimZK2lXE = Output_103, __p_PQditynQexDPdZfDCXIhqO = Output_112, __p_F6EkCoqDBFANn20vbYkbxb = Output_118, __p_KalBKYkNIBLLY6odbO55DN = Output_121, __slot_Sbk4MdEg1gSP7ce6fGHKVL = Maximum_124} : that_126;
            else
            {
                this.__if_TDcxKfEudH2OIFoAn6wnUA = state_7;
                this.__p_LAemX8Ltd3ALIo1J4kzo6J = Output_13;
                this.__p_ShjgkOdE4vSP0BDWFaImFs = State_Output_16;
                this.__p_OX8jqbpLVdUO6oVHPxpmMg = State_Output_25;
                this.__p_OtgASnr4P7xL980xzAxSsd = State_Output_36;
                this.__p_KyTnWRPsGHSOlA9cO9Y9cb = this.__p_KyTnWRPsGHSOlA9cO9Y9cb;
                this.__p_LPpXMZXReOhPZ7WT93JHvb = this.__p_LPpXMZXReOhPZ7WT93JHvb;
                this.__p_TsPWqq3MVTLO8B4jftYgHT = Output_43;
                this.__p_QsYhAUS9JYZP4WSsMGDd1u = Output_48;
                this.__p_J953BWVPZphLnP0BWUOe2j = Output_60;
                this.__p_JHeOgwxsg2LP4NqshXKUsz = State_Output_52;
                this.__p_KuI20UGqPB9MNyF9PlIhLk = Output_109;
                this.__p_CSKVBOXUoHsPUjBEim88jG = Output_106;
                this.__p_RDML4rFTwsNMnUE1PDAQSX = Output_123;
                this.__p_DuKIFJLNkFXPnCS1GBdcDi = Output_97;
                this.__p_ScxsV06h0M2LNDimZK2lXE = Output_103;
                this.__p_PQditynQexDPdZfDCXIhqO = Output_112;
                this.__p_F6EkCoqDBFANn20vbYkbxb = Output_118;
                this.__p_KalBKYkNIBLLY6odbO55DN = Output_121;
                this.__slot_Sbk4MdEg1gSP7ce6fGHKVL = Maximum_124;
            }

            return that_126;
        }

        public n4.StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T> SetBoundingBox()
        {
            return this;
        }

        public n4.StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T> __Create__<AdM>(n1.NodeContext Node_Context)
            where AdM : struct, n5.IAdaptiveCreateDefault<T[]>
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            var w_0 = default(AdM);
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "QsYhAUS9JYZP4WSsMGDd1u", 40677U);
            var Output_2 = n29.RenderComponent_LYdoKoeCq7MPXOIsyysl4d.Create(Node_Context: Node_Context_1);
            var Output_4 = Output_2.GetComponent(Component_Out: out n10.EntityRendererComponent Component_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "CSKVBOXUoHsPUjBEim88jG", 40699U);
            var Output_6 = n4.StreamOutModelComponent_C.Create(Node_Context: Node_Context_5);
            var Output_8 = Output_6.GetComponent(Component_Out: out n12.ModelComponent Component_7);
            var builder_9 = n6.CollectionBuilders.GetBuilder(n27._Operations_.CreateDefault<n12.EntityComponent>(), 2);
            builder_9.Add(Component_3);
            builder_9.Add(Component_7);
            var __pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C_10 = builder_9.Commit();
            n27._Operations_.Cons<n12.EntityComponent>(Input_In: __pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C_10, Result_Out: out n23.Spread<n12.EntityComponent> Result_11);
            n23.Spread<n12.EntityComponent> __auto_12 = Result_11;
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "OtgASnr4P7xL980xzAxSsd", 35258U);
            var Output_14 = n28.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T[]>.Create(Node_Context: Node_Context_13);
            n1.NodeContext Node_Context_15 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "OX8jqbpLVdUO6oVHPxpmMg", 35309U);
            var Output_16 = n28.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM.Create(Node_Context: Node_Context_15);
            n1.NodeContext Node_Context_17 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "LAemX8Ltd3ALIo1J4kzo6J", 35338U);
            var Output_18 = n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO.Create(Node_Context: Node_Context_17);
            var node_19 = n1.CompilationHelper.CreateNodeById(Node_Context, "InstancedMeshStreamOutShader", "Stride.Rendering.DrawShaders");
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "TsPWqq3MVTLO8B4jftYgHT", 35409U);
            var Output_21 = n4.MeshDrawerStreamOut_C.Create(Node_Context: Node_Context_20);
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "ShjgkOdE4vSP0BDWFaImFs", 35537U);
            var Output_23 = n31.Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i.Create(Node_Context: Node_Context_22);
            n1.NodeContext Node_Context_24 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "KuI20UGqPB9MNyF9PlIhLk", 35586U);
            int Initial_Value_25 = 0;
            var Output_26 = n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<int>.Create(Node_Context: Node_Context_24, Initial_Value_In: Initial_Value_25);
            n1.NodeContext Node_Context_27 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "DuKIFJLNkFXPnCS1GBdcDi", 35611U);
            n21._Operations_.Create_H<n14.BoundingBox>(Node_Context: Node_Context_27, Output_Out: out n20.AsyncTask<n14.BoundingBox> Output_28);
            n1.NodeContext Node_Context_29 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "ScxsV06h0M2LNDimZK2lXE", 40537U);
            n14.BoundingBox Initial_Result_30 = default(n14.BoundingBox);
            n22._Operations_.Create_H<n14.BoundingBox>(Node_Context: Node_Context_29, Initial_Result_In: Initial_Result_30, Output_Out: out n20.HoldLatest<n14.BoundingBox> Output_31);
            n1.NodeContext Node_Context_32 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "PQditynQexDPdZfDCXIhqO", 40548U);
            bool Changed_On_Create_33 = true;
            var Output_34 = n32.Changed_A8JGbead2bxNdnPybiEqVS<T[]>.Create<AdM>(Node_Context: Node_Context_32, Changed_On_Create_In: Changed_On_Create_33);
            n1.NodeContext Node_Context_35 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "F6EkCoqDBFANn20vbYkbxb", 40564U);
            n34.IClock Clock_36 = n33._Operations_.CreateDefault();
            var Output_37 = n32.MonoFlop_GeOV3KtNF5BPYMkYFPPAst.Create(Node_Context: Node_Context_35, Clock_In: Clock_36);
            n1.NodeContext Node_Context_38 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "KalBKYkNIBLLY6odbO55DN", 40586U);
            var Output_39 = n32.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_38);
            n1.NodeContext Node_Context_40 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "RDML4rFTwsNMnUE1PDAQSX", 40615U);
            bool Initial_Value_41 = false;
            var Output_42 = n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool>.Create(Node_Context: Node_Context_40, Initial_Value_In: Initial_Value_41);
            n1.NodeContext Node_Context_43 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "JHeOgwxsg2LP4NqshXKUsz", 40727U);
            var Output_44 = n31.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc.Create(Node_Context: Node_Context_43);
            n1.NodeContext Node_Context_45 = Node_Context.CreateSubContext("NL6SEAZgmRHQPFCm3uYN3A", "J953BWVPZphLnP0BWUOe2j", 40742U);
            bool Initial_Value_46 = false;
            var Output_47 = n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool>.Create(Node_Context: Node_Context_45, Initial_Value_In: Initial_Value_46);
            var node_48 = n1.CompilationHelper.CreateNodeById(Node_Context, "InstancedMeshTangentStreamOutShader", "Stride.Rendering.DrawShaders");
            n4.StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T> that_49 = this;
            this.__slot_Sbk4MdEg1gSP7ce6fGHKVL = n26._Operations_.CreateDefault();
            this.Components = Result_11;
            this.__pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C = __pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C_10;
            this.__p_QsYhAUS9JYZP4WSsMGDd1u = Output_4;
            this.__p_CSKVBOXUoHsPUjBEim88jG = Output_8;
            this.__p_OtgASnr4P7xL980xzAxSsd = Output_14;
            this.__p_OX8jqbpLVdUO6oVHPxpmMg = Output_16;
            this.__p_LAemX8Ltd3ALIo1J4kzo6J = Output_18;
            this.__p_KyTnWRPsGHSOlA9cO9Y9cb = node_19;
            this.__p_TsPWqq3MVTLO8B4jftYgHT = Output_21;
            this.__p_ShjgkOdE4vSP0BDWFaImFs = Output_23;
            this.__p_KuI20UGqPB9MNyF9PlIhLk = Output_26;
            this.__p_DuKIFJLNkFXPnCS1GBdcDi = Output_28;
            this.__p_ScxsV06h0M2LNDimZK2lXE = Output_31;
            this.__p_PQditynQexDPdZfDCXIhqO = Output_34;
            this.__p_F6EkCoqDBFANn20vbYkbxb = Output_37;
            this.__p_KalBKYkNIBLLY6odbO55DN = Output_39;
            this.__p_RDML4rFTwsNMnUE1PDAQSX = Output_42;
            this.__p_JHeOgwxsg2LP4NqshXKUsz = Output_44;
            this.__p_J953BWVPZphLnP0BWUOe2j = Output_47;
            this.__p_LPpXMZXReOhPZ7WT93JHvb = node_48;
            this.__if_TDcxKfEudH2OIFoAn6wnUA = default(n2.Object);
            return that_49;
        }

        public n4.StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T> __CreateDefault__<AdM>()
            where AdM : struct, n5.IAdaptiveCreateDefault<T[]>
        {
            var w_0 = default(AdM);
            n4.StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T> that_1 = this;
            this.__slot_Sbk4MdEg1gSP7ce6fGHKVL = n26._Operations_.CreateDefault();
            this.Components = n27._Operations_.CreateDefault<n12.EntityComponent>();
            this.__pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C = n27._Operations_.CreateDefault<n12.EntityComponent>();
            this.__if_TDcxKfEudH2OIFoAn6wnUA = default(n2.Object);
            this.__p_LAemX8Ltd3ALIo1J4kzo6J = n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO.CreateDefault();
            this.__p_ShjgkOdE4vSP0BDWFaImFs = n31.Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i.CreateDefault();
            this.__p_OX8jqbpLVdUO6oVHPxpmMg = n28.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM.CreateDefault();
            this.__p_OtgASnr4P7xL980xzAxSsd = n28.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T[]>.CreateDefault();
            this.__p_KyTnWRPsGHSOlA9cO9Y9cb = default(n1.IVLNode);
            this.__p_LPpXMZXReOhPZ7WT93JHvb = default(n1.IVLNode);
            this.__p_TsPWqq3MVTLO8B4jftYgHT = n4.MeshDrawerStreamOut_C.CreateDefault();
            this.__p_QsYhAUS9JYZP4WSsMGDd1u = n29.RenderComponent_LYdoKoeCq7MPXOIsyysl4d.CreateDefault();
            this.__p_J953BWVPZphLnP0BWUOe2j = n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool>.CreateDefault();
            this.__p_JHeOgwxsg2LP4NqshXKUsz = n31.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc.CreateDefault();
            this.__p_KuI20UGqPB9MNyF9PlIhLk = n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<int>.CreateDefault();
            this.__p_CSKVBOXUoHsPUjBEim88jG = n4.StreamOutModelComponent_C.CreateDefault();
            this.__p_RDML4rFTwsNMnUE1PDAQSX = n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool>.CreateDefault();
            this.__p_DuKIFJLNkFXPnCS1GBdcDi = default(n20.AsyncTask<n14.BoundingBox>);
            this.__p_ScxsV06h0M2LNDimZK2lXE = default(n20.HoldLatest<n14.BoundingBox>);
            this.__p_PQditynQexDPdZfDCXIhqO = n32.Changed_A8JGbead2bxNdnPybiEqVS<T[]>.CreateDefault<AdM>();
            this.__p_F6EkCoqDBFANn20vbYkbxb = n32.MonoFlop_GeOV3KtNF5BPYMkYFPPAst.CreateDefault();
            this.__p_KalBKYkNIBLLY6odbO55DN = n32.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_1;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_TDcxKfEudH2OIFoAn6wnUA);
            n1.CompilationHelper.SafeDispose(this.__p_LAemX8Ltd3ALIo1J4kzo6J);
            n1.CompilationHelper.SafeDispose(this.__p_ShjgkOdE4vSP0BDWFaImFs);
            n1.CompilationHelper.SafeDispose(this.__p_OX8jqbpLVdUO6oVHPxpmMg);
            n1.CompilationHelper.SafeDispose(this.__p_OtgASnr4P7xL980xzAxSsd);
            n1.CompilationHelper.SafeDispose(this.__p_KyTnWRPsGHSOlA9cO9Y9cb);
            n1.CompilationHelper.SafeDispose(this.__p_LPpXMZXReOhPZ7WT93JHvb);
            n1.CompilationHelper.SafeDispose(this.__p_TsPWqq3MVTLO8B4jftYgHT);
            n1.CompilationHelper.SafeDispose(this.__p_QsYhAUS9JYZP4WSsMGDd1u);
            n1.CompilationHelper.SafeDispose(this.__p_J953BWVPZphLnP0BWUOe2j);
            n1.CompilationHelper.SafeDispose(this.__p_JHeOgwxsg2LP4NqshXKUsz);
            n1.CompilationHelper.SafeDispose(this.__p_KuI20UGqPB9MNyF9PlIhLk);
            n1.CompilationHelper.SafeDispose(this.__p_CSKVBOXUoHsPUjBEim88jG);
            n1.CompilationHelper.SafeDispose(this.__p_RDML4rFTwsNMnUE1PDAQSX);
            n1.CompilationHelper.SafeDispose(this.__p_DuKIFJLNkFXPnCS1GBdcDi);
            n1.CompilationHelper.SafeDispose(this.__p_ScxsV06h0M2LNDimZK2lXE);
            n1.CompilationHelper.SafeDispose(this.__p_PQditynQexDPdZfDCXIhqO);
            n1.CompilationHelper.SafeDispose(this.__p_F6EkCoqDBFANn20vbYkbxb);
            n1.CompilationHelper.SafeDispose(this.__p_KalBKYkNIBLLY6odbO55DN);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 35392U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "CsAPIP1I7LDLMIB4eccBcU", Name = "__slot_CsAPIP1I7LDLMIB4eccBcU")]
        public static n3.PrimitiveType __slot_CsAPIP1I7LDLMIB4eccBcU = n1.CompilationHelper.Deserialize<n3.PrimitiveType>("TriangleList", false, "NL6SEAZgmRHQPFCm3uYN3A", "CsAPIP1I7LDLMIB4eccBcU");
        [n1.ElementAttribute(TracingId = 35541U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "EM4sN253hiyN9g8PzQh2A3", Name = "__slot_EM4sN253hiyN9g8PzQh2A3")]
        public static string __slot_EM4sN253hiyN9g8PzQh2A3 = "transformation buffer";
        [n1.ElementAttribute(TracingId = 35562U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "HE6dkA7X1UpPh2iUwZckuY", Name = "__slot_HE6dkA7X1UpPh2iUwZckuY")]
        public static string __slot_HE6dkA7X1UpPh2iUwZckuY = "geometry shader";
        [n1.ElementAttribute(TracingId = 35567U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "FbfS0npuav7LLcWpDgl1Uj", Name = "__slot_FbfS0npuav7LLcWpDgl1Uj")]
        public static string __slot_FbfS0npuav7LLcWpDgl1Uj = "stream out draw call";
        [n1.ElementAttribute(TracingId = 40610U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "Sbk4MdEg1gSP7ce6fGHKVL", Name = "__slot_Sbk4MdEg1gSP7ce6fGHKVL")]
        public n14.Vector3 __slot_Sbk4MdEg1gSP7ce6fGHKVL;
        [n1.ElementAttribute(TracingId = 40674U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "VJhdixHM1rXL5HQ3uUciMg", Name = "__slot_VJhdixHM1rXL5HQ3uUciMg")]
        public static n3.PrimitiveType __slot_VJhdixHM1rXL5HQ3uUciMg = n1.CompilationHelper.Deserialize<n3.PrimitiveType>("TriangleList", false, "NL6SEAZgmRHQPFCm3uYN3A", "VJhdixHM1rXL5HQ3uUciMg");
        [n1.ElementAttribute(TracingId = 40774U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "AqodGclsRGbN38cJZtHgSK", Name = "__slot_AqodGclsRGbN38cJZtHgSK")]
        public static bool __slot_AqodGclsRGbN38cJZtHgSK = true;
        [n1.ElementAttribute(TracingId = 40725U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "BN2aDIPm6QHP1WzXUYFLEx", Name = "Components")]
        public n23.Spread<n12.EntityComponent> Components;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_TDcxKfEudH2OIFoAn6wnUA;
        [n1.ElementAttribute(TracingId = 35338U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "LAemX8Ltd3ALIo1J4kzo6J", Name = "AnalyzeMesh", IsManaged = true, IsAutoGenerated = true)]
        public n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO __p_LAemX8Ltd3ALIo1J4kzo6J;
        [n1.ElementAttribute(TracingId = 35537U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "ShjgkOdE4vSP0BDWFaImFs", Name = "Pos3Norm3Tang4Tex2", IsManaged = true, IsAutoGenerated = true)]
        public n31.Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i __p_ShjgkOdE4vSP0BDWFaImFs;
        [n1.ElementAttribute(TracingId = 35309U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "OX8jqbpLVdUO6oVHPxpmMg", Name = "ComputeBuffer", IsManaged = true, IsAutoGenerated = true)]
        public n28.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM __p_OX8jqbpLVdUO6oVHPxpmMg;
        [n1.ElementAttribute(TracingId = 35258U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "OtgASnr4P7xL980xzAxSsd", Name = "DynamicBuffer", IsManaged = true, IsAutoGenerated = true)]
        public n28.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T[]> __p_OtgASnr4P7xL980xzAxSsd;
        [n1.ElementAttribute(TracingId = 35400U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "KyTnWRPsGHSOlA9cO9Y9cb", Name = "InstancedMeshStreamOutShader", IsManaged = true, IsAutoGenerated = true, NodeName = "InstancedMeshStreamOutShader", NodeCategory = "Stride.Rendering.DrawShaders")]
        public n1.IVLNode __p_KyTnWRPsGHSOlA9cO9Y9cb;
        [n1.ElementAttribute(TracingId = 40762U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "LPpXMZXReOhPZ7WT93JHvb", Name = "InstancedMeshTangentStreamOutShader", IsManaged = true, IsAutoGenerated = true, NodeName = "InstancedMeshTangentStreamOutShader", NodeCategory = "Stride.Rendering.DrawShaders")]
        public n1.IVLNode __p_LPpXMZXReOhPZ7WT93JHvb;
        [n1.ElementAttribute(TracingId = 35409U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "TsPWqq3MVTLO8B4jftYgHT", Name = "MeshDrawerStreamOut", IsManaged = true, IsAutoGenerated = true)]
        public n4.MeshDrawerStreamOut_C __p_TsPWqq3MVTLO8B4jftYgHT;
        [n1.ElementAttribute(TracingId = 40677U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "QsYhAUS9JYZP4WSsMGDd1u", Name = "RenderComponent", IsManaged = true, IsAutoGenerated = true)]
        public n29.RenderComponent_LYdoKoeCq7MPXOIsyysl4d __p_QsYhAUS9JYZP4WSsMGDd1u;
        [n1.ElementAttribute(TracingId = 40742U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "J953BWVPZphLnP0BWUOe2j", Name = "FrameDelay", IsManaged = true, IsAutoGenerated = true)]
        public n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool> __p_J953BWVPZphLnP0BWUOe2j;
        [n1.ElementAttribute(TracingId = 40727U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "JHeOgwxsg2LP4NqshXKUsz", Name = "Pos3Norm3Tex2", IsManaged = true, IsAutoGenerated = true)]
        public n31.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc __p_JHeOgwxsg2LP4NqshXKUsz;
        [n1.ElementAttribute(TracingId = 35586U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "KuI20UGqPB9MNyF9PlIhLk", Name = "FrameDelay", IsManaged = true, IsAutoGenerated = true)]
        public n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<int> __p_KuI20UGqPB9MNyF9PlIhLk;
        [n1.ElementAttribute(TracingId = 40699U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "CSKVBOXUoHsPUjBEim88jG", Name = "StreamOutModelComponent", IsManaged = true, IsAutoGenerated = true)]
        public n4.StreamOutModelComponent_C __p_CSKVBOXUoHsPUjBEim88jG;
        [n1.ElementAttribute(TracingId = 40615U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "RDML4rFTwsNMnUE1PDAQSX", Name = "FrameDelay", IsManaged = true, IsAutoGenerated = true)]
        public n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool> __p_RDML4rFTwsNMnUE1PDAQSX;
        [n1.ElementAttribute(TracingId = 35611U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "DuKIFJLNkFXPnCS1GBdcDi", Name = "AsyncTask", IsManaged = true, IsAutoGenerated = true)]
        public n20.AsyncTask<n14.BoundingBox> __p_DuKIFJLNkFXPnCS1GBdcDi;
        [n1.ElementAttribute(TracingId = 40537U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "ScxsV06h0M2LNDimZK2lXE", Name = "HoldLatest", IsManaged = true, IsAutoGenerated = true)]
        public n20.HoldLatest<n14.BoundingBox> __p_ScxsV06h0M2LNDimZK2lXE;
        [n1.ElementAttribute(TracingId = 40548U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "PQditynQexDPdZfDCXIhqO", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n32.Changed_A8JGbead2bxNdnPybiEqVS<T[]> __p_PQditynQexDPdZfDCXIhqO;
        [n1.ElementAttribute(TracingId = 40564U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "F6EkCoqDBFANn20vbYkbxb", Name = "MonoFlop", IsManaged = true, IsAutoGenerated = true)]
        public n32.MonoFlop_GeOV3KtNF5BPYMkYFPPAst __p_F6EkCoqDBFANn20vbYkbxb;
        [n1.ElementAttribute(TracingId = 40586U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "KalBKYkNIBLLY6odbO55DN", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n32.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_KalBKYkNIBLLY6odbO55DN;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n23.Spread<n12.EntityComponent> __pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C = default(n23.Spread<n12.EntityComponent>);
        static StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj()
        {
        }

        public StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj(StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T> other): base(other)
        {
            this.__slot_Sbk4MdEg1gSP7ce6fGHKVL = other.__slot_Sbk4MdEg1gSP7ce6fGHKVL;
            this.Components = other.Components;
            this.__if_TDcxKfEudH2OIFoAn6wnUA = other.__if_TDcxKfEudH2OIFoAn6wnUA;
            this.__p_LAemX8Ltd3ALIo1J4kzo6J = other.__p_LAemX8Ltd3ALIo1J4kzo6J;
            this.__p_ShjgkOdE4vSP0BDWFaImFs = other.__p_ShjgkOdE4vSP0BDWFaImFs;
            this.__p_OX8jqbpLVdUO6oVHPxpmMg = other.__p_OX8jqbpLVdUO6oVHPxpmMg;
            this.__p_OtgASnr4P7xL980xzAxSsd = other.__p_OtgASnr4P7xL980xzAxSsd;
            this.__p_KyTnWRPsGHSOlA9cO9Y9cb = other.__p_KyTnWRPsGHSOlA9cO9Y9cb;
            this.__p_LPpXMZXReOhPZ7WT93JHvb = other.__p_LPpXMZXReOhPZ7WT93JHvb;
            this.__p_TsPWqq3MVTLO8B4jftYgHT = other.__p_TsPWqq3MVTLO8B4jftYgHT;
            this.__p_QsYhAUS9JYZP4WSsMGDd1u = other.__p_QsYhAUS9JYZP4WSsMGDd1u;
            this.__p_J953BWVPZphLnP0BWUOe2j = other.__p_J953BWVPZphLnP0BWUOe2j;
            this.__p_JHeOgwxsg2LP4NqshXKUsz = other.__p_JHeOgwxsg2LP4NqshXKUsz;
            this.__p_KuI20UGqPB9MNyF9PlIhLk = other.__p_KuI20UGqPB9MNyF9PlIhLk;
            this.__p_CSKVBOXUoHsPUjBEim88jG = other.__p_CSKVBOXUoHsPUjBEim88jG;
            this.__p_RDML4rFTwsNMnUE1PDAQSX = other.__p_RDML4rFTwsNMnUE1PDAQSX;
            this.__p_DuKIFJLNkFXPnCS1GBdcDi = other.__p_DuKIFJLNkFXPnCS1GBdcDi;
            this.__p_ScxsV06h0M2LNDimZK2lXE = other.__p_ScxsV06h0M2LNDimZK2lXE;
            this.__p_PQditynQexDPdZfDCXIhqO = other.__p_PQditynQexDPdZfDCXIhqO;
            this.__p_F6EkCoqDBFANn20vbYkbxb = other.__p_F6EkCoqDBFANn20vbYkbxb;
            this.__p_KalBKYkNIBLLY6odbO55DN = other.__p_KalBKYkNIBLLY6odbO55DN;
            this.__pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C = other.__pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C;
        }

        protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Sbk4MdEg1gSP7ce6fGHKVL", in __slot_Sbk4MdEg1gSP7ce6fGHKVL), n1.CompilationHelper.GetValueOrExisting(values, "Components", in Components), n1.CompilationHelper.GetValueOrExisting(values, "__if_TDcxKfEudH2OIFoAn6wnUA", in __if_TDcxKfEudH2OIFoAn6wnUA), n1.CompilationHelper.GetValueOrExisting(values, "__p_LAemX8Ltd3ALIo1J4kzo6J", in __p_LAemX8Ltd3ALIo1J4kzo6J), n1.CompilationHelper.GetValueOrExisting(values, "__p_ShjgkOdE4vSP0BDWFaImFs", in __p_ShjgkOdE4vSP0BDWFaImFs), n1.CompilationHelper.GetValueOrExisting(values, "__p_OX8jqbpLVdUO6oVHPxpmMg", in __p_OX8jqbpLVdUO6oVHPxpmMg), n1.CompilationHelper.GetValueOrExisting(values, "__p_OtgASnr4P7xL980xzAxSsd", in __p_OtgASnr4P7xL980xzAxSsd), n1.CompilationHelper.GetValueOrExisting(values, "__p_KyTnWRPsGHSOlA9cO9Y9cb", in __p_KyTnWRPsGHSOlA9cO9Y9cb), n1.CompilationHelper.GetValueOrExisting(values, "__p_LPpXMZXReOhPZ7WT93JHvb", in __p_LPpXMZXReOhPZ7WT93JHvb), n1.CompilationHelper.GetValueOrExisting(values, "__p_TsPWqq3MVTLO8B4jftYgHT", in __p_TsPWqq3MVTLO8B4jftYgHT), n1.CompilationHelper.GetValueOrExisting(values, "__p_QsYhAUS9JYZP4WSsMGDd1u", in __p_QsYhAUS9JYZP4WSsMGDd1u), n1.CompilationHelper.GetValueOrExisting(values, "__p_J953BWVPZphLnP0BWUOe2j", in __p_J953BWVPZphLnP0BWUOe2j), n1.CompilationHelper.GetValueOrExisting(values, "__p_JHeOgwxsg2LP4NqshXKUsz", in __p_JHeOgwxsg2LP4NqshXKUsz), n1.CompilationHelper.GetValueOrExisting(values, "__p_KuI20UGqPB9MNyF9PlIhLk", in __p_KuI20UGqPB9MNyF9PlIhLk), n1.CompilationHelper.GetValueOrExisting(values, "__p_CSKVBOXUoHsPUjBEim88jG", in __p_CSKVBOXUoHsPUjBEim88jG), n1.CompilationHelper.GetValueOrExisting(values, "__p_RDML4rFTwsNMnUE1PDAQSX", in __p_RDML4rFTwsNMnUE1PDAQSX), n1.CompilationHelper.GetValueOrExisting(values, "__p_DuKIFJLNkFXPnCS1GBdcDi", in __p_DuKIFJLNkFXPnCS1GBdcDi), n1.CompilationHelper.GetValueOrExisting(values, "__p_ScxsV06h0M2LNDimZK2lXE", in __p_ScxsV06h0M2LNDimZK2lXE), n1.CompilationHelper.GetValueOrExisting(values, "__p_PQditynQexDPdZfDCXIhqO", in __p_PQditynQexDPdZfDCXIhqO), n1.CompilationHelper.GetValueOrExisting(values, "__p_F6EkCoqDBFANn20vbYkbxb", in __p_F6EkCoqDBFANn20vbYkbxb), n1.CompilationHelper.GetValueOrExisting(values, "__p_KalBKYkNIBLLY6odbO55DN", in __p_KalBKYkNIBLLY6odbO55DN), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C", in __pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C));
        }

        internal StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T> __WITH__(n14.Vector3 __slot_Sbk4MdEg1gSP7ce6fGHKVL, n23.Spread<n12.EntityComponent> Components, n2.Object __if_TDcxKfEudH2OIFoAn6wnUA, n4.AnalyzeMesh_Jeoc7D9B7h9PBUqptKAvLO __p_LAemX8Ltd3ALIo1J4kzo6J, n31.Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i __p_ShjgkOdE4vSP0BDWFaImFs, n28.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM __p_OX8jqbpLVdUO6oVHPxpmMg, n28.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<T[]> __p_OtgASnr4P7xL980xzAxSsd, n1.IVLNode __p_KyTnWRPsGHSOlA9cO9Y9cb, n1.IVLNode __p_LPpXMZXReOhPZ7WT93JHvb, n4.MeshDrawerStreamOut_C __p_TsPWqq3MVTLO8B4jftYgHT, n29.RenderComponent_LYdoKoeCq7MPXOIsyysl4d __p_QsYhAUS9JYZP4WSsMGDd1u, n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool> __p_J953BWVPZphLnP0BWUOe2j, n31.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc __p_JHeOgwxsg2LP4NqshXKUsz, n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<int> __p_KuI20UGqPB9MNyF9PlIhLk, n4.StreamOutModelComponent_C __p_CSKVBOXUoHsPUjBEim88jG, n32.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool> __p_RDML4rFTwsNMnUE1PDAQSX, n20.AsyncTask<n14.BoundingBox> __p_DuKIFJLNkFXPnCS1GBdcDi, n20.HoldLatest<n14.BoundingBox> __p_ScxsV06h0M2LNDimZK2lXE, n32.Changed_A8JGbead2bxNdnPybiEqVS<T[]> __p_PQditynQexDPdZfDCXIhqO, n32.MonoFlop_GeOV3KtNF5BPYMkYFPPAst __p_F6EkCoqDBFANn20vbYkbxb, n32.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_KalBKYkNIBLLY6odbO55DN, n23.Spread<n12.EntityComponent> __pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C)
        {
            n4.StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_Sbk4MdEg1gSP7ce6fGHKVL != this.__slot_Sbk4MdEg1gSP7ce6fGHKVL || Components != this.Components || __if_TDcxKfEudH2OIFoAn6wnUA != this.__if_TDcxKfEudH2OIFoAn6wnUA || __p_LAemX8Ltd3ALIo1J4kzo6J != this.__p_LAemX8Ltd3ALIo1J4kzo6J || __p_ShjgkOdE4vSP0BDWFaImFs != this.__p_ShjgkOdE4vSP0BDWFaImFs || __p_OX8jqbpLVdUO6oVHPxpmMg != this.__p_OX8jqbpLVdUO6oVHPxpmMg || __p_OtgASnr4P7xL980xzAxSsd != this.__p_OtgASnr4P7xL980xzAxSsd || __p_KyTnWRPsGHSOlA9cO9Y9cb != this.__p_KyTnWRPsGHSOlA9cO9Y9cb || __p_LPpXMZXReOhPZ7WT93JHvb != this.__p_LPpXMZXReOhPZ7WT93JHvb || __p_TsPWqq3MVTLO8B4jftYgHT != this.__p_TsPWqq3MVTLO8B4jftYgHT || __p_QsYhAUS9JYZP4WSsMGDd1u != this.__p_QsYhAUS9JYZP4WSsMGDd1u || __p_J953BWVPZphLnP0BWUOe2j != this.__p_J953BWVPZphLnP0BWUOe2j || __p_JHeOgwxsg2LP4NqshXKUsz != this.__p_JHeOgwxsg2LP4NqshXKUsz || __p_KuI20UGqPB9MNyF9PlIhLk != this.__p_KuI20UGqPB9MNyF9PlIhLk || __p_CSKVBOXUoHsPUjBEim88jG != this.__p_CSKVBOXUoHsPUjBEim88jG || __p_RDML4rFTwsNMnUE1PDAQSX != this.__p_RDML4rFTwsNMnUE1PDAQSX || __p_DuKIFJLNkFXPnCS1GBdcDi != this.__p_DuKIFJLNkFXPnCS1GBdcDi || __p_ScxsV06h0M2LNDimZK2lXE != this.__p_ScxsV06h0M2LNDimZK2lXE || __p_PQditynQexDPdZfDCXIhqO != this.__p_PQditynQexDPdZfDCXIhqO || __p_F6EkCoqDBFANn20vbYkbxb != this.__p_F6EkCoqDBFANn20vbYkbxb || __p_KalBKYkNIBLLY6odbO55DN != this.__p_KalBKYkNIBLLY6odbO55DN || __pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C != this.__pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C ? new StreamOutInstancer2_DbyCuy9U0UpK95gjQWxDXj<T>(this)
                {__slot_Sbk4MdEg1gSP7ce6fGHKVL = __slot_Sbk4MdEg1gSP7ce6fGHKVL, Components = Components, __if_TDcxKfEudH2OIFoAn6wnUA = __if_TDcxKfEudH2OIFoAn6wnUA, __p_LAemX8Ltd3ALIo1J4kzo6J = __p_LAemX8Ltd3ALIo1J4kzo6J, __p_ShjgkOdE4vSP0BDWFaImFs = __p_ShjgkOdE4vSP0BDWFaImFs, __p_OX8jqbpLVdUO6oVHPxpmMg = __p_OX8jqbpLVdUO6oVHPxpmMg, __p_OtgASnr4P7xL980xzAxSsd = __p_OtgASnr4P7xL980xzAxSsd, __p_KyTnWRPsGHSOlA9cO9Y9cb = __p_KyTnWRPsGHSOlA9cO9Y9cb, __p_LPpXMZXReOhPZ7WT93JHvb = __p_LPpXMZXReOhPZ7WT93JHvb, __p_TsPWqq3MVTLO8B4jftYgHT = __p_TsPWqq3MVTLO8B4jftYgHT, __p_QsYhAUS9JYZP4WSsMGDd1u = __p_QsYhAUS9JYZP4WSsMGDd1u, __p_J953BWVPZphLnP0BWUOe2j = __p_J953BWVPZphLnP0BWUOe2j, __p_JHeOgwxsg2LP4NqshXKUsz = __p_JHeOgwxsg2LP4NqshXKUsz, __p_KuI20UGqPB9MNyF9PlIhLk = __p_KuI20UGqPB9MNyF9PlIhLk, __p_CSKVBOXUoHsPUjBEim88jG = __p_CSKVBOXUoHsPUjBEim88jG, __p_RDML4rFTwsNMnUE1PDAQSX = __p_RDML4rFTwsNMnUE1PDAQSX, __p_DuKIFJLNkFXPnCS1GBdcDi = __p_DuKIFJLNkFXPnCS1GBdcDi, __p_ScxsV06h0M2LNDimZK2lXE = __p_ScxsV06h0M2LNDimZK2lXE, __p_PQditynQexDPdZfDCXIhqO = __p_PQditynQexDPdZfDCXIhqO, __p_F6EkCoqDBFANn20vbYkbxb = __p_F6EkCoqDBFANn20vbYkbxb, __p_KalBKYkNIBLLY6odbO55DN = __p_KalBKYkNIBLLY6odbO55DN, __pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C = __pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C} : that_0;
            else
            {
                this.__slot_Sbk4MdEg1gSP7ce6fGHKVL = __slot_Sbk4MdEg1gSP7ce6fGHKVL;
                this.Components = Components;
                this.__if_TDcxKfEudH2OIFoAn6wnUA = __if_TDcxKfEudH2OIFoAn6wnUA;
                this.__p_LAemX8Ltd3ALIo1J4kzo6J = __p_LAemX8Ltd3ALIo1J4kzo6J;
                this.__p_ShjgkOdE4vSP0BDWFaImFs = __p_ShjgkOdE4vSP0BDWFaImFs;
                this.__p_OX8jqbpLVdUO6oVHPxpmMg = __p_OX8jqbpLVdUO6oVHPxpmMg;
                this.__p_OtgASnr4P7xL980xzAxSsd = __p_OtgASnr4P7xL980xzAxSsd;
                this.__p_KyTnWRPsGHSOlA9cO9Y9cb = __p_KyTnWRPsGHSOlA9cO9Y9cb;
                this.__p_LPpXMZXReOhPZ7WT93JHvb = __p_LPpXMZXReOhPZ7WT93JHvb;
                this.__p_TsPWqq3MVTLO8B4jftYgHT = __p_TsPWqq3MVTLO8B4jftYgHT;
                this.__p_QsYhAUS9JYZP4WSsMGDd1u = __p_QsYhAUS9JYZP4WSsMGDd1u;
                this.__p_J953BWVPZphLnP0BWUOe2j = __p_J953BWVPZphLnP0BWUOe2j;
                this.__p_JHeOgwxsg2LP4NqshXKUsz = __p_JHeOgwxsg2LP4NqshXKUsz;
                this.__p_KuI20UGqPB9MNyF9PlIhLk = __p_KuI20UGqPB9MNyF9PlIhLk;
                this.__p_CSKVBOXUoHsPUjBEim88jG = __p_CSKVBOXUoHsPUjBEim88jG;
                this.__p_RDML4rFTwsNMnUE1PDAQSX = __p_RDML4rFTwsNMnUE1PDAQSX;
                this.__p_DuKIFJLNkFXPnCS1GBdcDi = __p_DuKIFJLNkFXPnCS1GBdcDi;
                this.__p_ScxsV06h0M2LNDimZK2lXE = __p_ScxsV06h0M2LNDimZK2lXE;
                this.__p_PQditynQexDPdZfDCXIhqO = __p_PQditynQexDPdZfDCXIhqO;
                this.__p_F6EkCoqDBFANn20vbYkbxb = __p_F6EkCoqDBFANn20vbYkbxb;
                this.__p_KalBKYkNIBLLY6odbO55DN = __p_KalBKYkNIBLLY6odbO55DN;
                this.__pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C = __pin_group_Input_In_Lbs05XbwKXFP7nINAkAn1C;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "Kb5Zq1RmMspMmwLIwNTMm0", Name = "__Kb5Zq1RmMspMmwLIwNTMm0")]
        [n2.SerializableAttribute]
        public class __Kb5Zq1RmMspMmwLIwNTMm0 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_LdF0mSWmmuUP56ZjBqNAmR);
                return;
            }

            [n1.ElementAttribute(TracingId = 40639U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "LdF0mSWmmuUP56ZjBqNAmR", Name = "BoxMesh", IsManaged = true, IsAutoGenerated = true, NodeName = "BoxMesh", NodeCategory = "Stride.Models.Meshes")]
            public n1.IVLNode __p_LdF0mSWmmuUP56ZjBqNAmR;
            public __Kb5Zq1RmMspMmwLIwNTMm0(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Kb5Zq1RmMspMmwLIwNTMm0(__Kb5Zq1RmMspMmwLIwNTMm0 other): base(other)
            {
                this.__p_LdF0mSWmmuUP56ZjBqNAmR = other.__p_LdF0mSWmmuUP56ZjBqNAmR;
            }

            protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LdF0mSWmmuUP56ZjBqNAmR", in __p_LdF0mSWmmuUP56ZjBqNAmR));
            }

            internal __Kb5Zq1RmMspMmwLIwNTMm0 __WITH__(n1.IVLNode __p_LdF0mSWmmuUP56ZjBqNAmR)
            {
                __Kb5Zq1RmMspMmwLIwNTMm0 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_LdF0mSWmmuUP56ZjBqNAmR != this.__p_LdF0mSWmmuUP56ZjBqNAmR ? new __Kb5Zq1RmMspMmwLIwNTMm0(this)
                    {__p_LdF0mSWmmuUP56ZjBqNAmR = __p_LdF0mSWmmuUP56ZjBqNAmR} : that_0;
                else
                {
                    this.__p_LdF0mSWmmuUP56ZjBqNAmR = __p_LdF0mSWmmuUP56ZjBqNAmR;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "M6K98CKvlVyP0gGZMNPVF4", Name = "__M6K98CKvlVyP0gGZMNPVF4")]
        [n2.SerializableAttribute]
        public class __M6K98CKvlVyP0gGZMNPVF4 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(TracingId = 35797U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "RzkUcd3rCb9NU1LDI6jSZR", Name = "__slot_RzkUcd3rCb9NU1LDI6jSZR")]
            public n16.IEnumerable<n14.Matrix> __slot_RzkUcd3rCb9NU1LDI6jSZR;
            public __M6K98CKvlVyP0gGZMNPVF4(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __M6K98CKvlVyP0gGZMNPVF4(__M6K98CKvlVyP0gGZMNPVF4 other): base(other)
            {
                this.__slot_RzkUcd3rCb9NU1LDI6jSZR = other.__slot_RzkUcd3rCb9NU1LDI6jSZR;
            }

            protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_RzkUcd3rCb9NU1LDI6jSZR", in __slot_RzkUcd3rCb9NU1LDI6jSZR));
            }

            internal __M6K98CKvlVyP0gGZMNPVF4 __WITH__(n16.IEnumerable<n14.Matrix> __slot_RzkUcd3rCb9NU1LDI6jSZR)
            {
                __M6K98CKvlVyP0gGZMNPVF4 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __slot_RzkUcd3rCb9NU1LDI6jSZR != this.__slot_RzkUcd3rCb9NU1LDI6jSZR ? new __M6K98CKvlVyP0gGZMNPVF4(this)
                    {__slot_RzkUcd3rCb9NU1LDI6jSZR = __slot_RzkUcd3rCb9NU1LDI6jSZR} : that_0;
                else
                {
                    this.__slot_RzkUcd3rCb9NU1LDI6jSZR = __slot_RzkUcd3rCb9NU1LDI6jSZR;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 40952U, DocumentId = "NL6SEAZgmRHQPFCm3uYN3A", PersistentId = "RiqvYTxBGhJPNWSeOu26U2", Name = "VL_Stride_Rendering_InstancerApplication_RiqvYTxBGhJPNWSeOu26U2")]
    [n2.SerializableAttribute]
    public class VL_Stride_Rendering_InstancerApplication_RiqvYTxBGhJPNWSeOu26U2 : n1.VLObject, n2.IDisposable
    {
        [n6.CreateNewAttribute]
        public static n4.VL_Stride_Rendering_InstancerApplication_RiqvYTxBGhJPNWSeOu26U2 Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_Stride_Rendering_InstancerApplication_RiqvYTxBGhJPNWSeOu26U2(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n6.CreateDefaultAttribute]
        public static n4.VL_Stride_Rendering_InstancerApplication_RiqvYTxBGhJPNWSeOu26U2 CreateDefault()
        {
            var instance = new VL_Stride_Rendering_InstancerApplication_RiqvYTxBGhJPNWSeOu26U2(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.VL_Stride_Rendering_InstancerApplication_RiqvYTxBGhJPNWSeOu26U2 Update()
        {
            return this;
        }

        public n4.VL_Stride_Rendering_InstancerApplication_RiqvYTxBGhJPNWSeOu26U2 __Create__(n1.NodeContext Node_Context)
        {
            n25.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n4.VL_Stride_Rendering_InstancerApplication_RiqvYTxBGhJPNWSeOu26U2 __CreateDefault__()
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

        public VL_Stride_Rendering_InstancerApplication_RiqvYTxBGhJPNWSeOu26U2(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_Stride_Rendering_InstancerApplication_RiqvYTxBGhJPNWSeOu26U2(VL_Stride_Rendering_InstancerApplication_RiqvYTxBGhJPNWSeOu26U2 other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n16.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_Stride_Rendering_InstancerApplication_RiqvYTxBGhJPNWSeOu26U2 __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Stride_Rendering_Instancer_
{
    public struct __AdaptiveImplementations__NL6SEAZgmRHQPFCm3uYN3A : n24.IAdaptiveSetGraphicsData<n23.Spread<n14.Vector4>>, n48.IAdaptiveAsReadOnlyMemory<n23.Spread<n14.Vector4>, n14.Vector4>, n5.IAdaptiveCreateDefault<n8.Material>, n49.IAdaptiveOne<float>, n49.IAdaptiveOperatorMulitply_Scale<float>
    {
        public void SetGraphicsData(n9.MemoryDataProvider Input_In, n23.Spread<n14.Vector4> Data_In, int Offset_In_Bytes_In, int Size_In_Bytes_In, int Element_Size_In_Bytes_In, int Row_Size_In_Bytes_In, int Slice_Size_In_Bytes_In, out n9.MemoryDataProvider Output_Out)
        {
            n24._Operations_.SetGraphicsData<n23.Spread<n14.Vector4>, n14.Vector4, n41.__AdaptiveImplementations__NL6SEAZgmRHQPFCm3uYN3A>(Input_In: Input_In, Data_In: Data_In, Offset_In_Bytes_In: Offset_In_Bytes_In, Size_In_Bytes_In: Size_In_Bytes_In, Element_Size_In_Bytes_In: Element_Size_In_Bytes_In, Row_Size_In_Bytes_In: Row_Size_In_Bytes_In, Slice_Size_In_Bytes_In: Slice_Size_In_Bytes_In, Output_Out: out n9.MemoryDataProvider Output_0);
            Output_Out = Output_0;
            return;
        }

        public void AsReadOnlyMemory(n23.Spread<n14.Vector4> Input_In, out n2.ReadOnlyMemory<n14.Vector4> Result_Out)
        {
            n16.IReadOnlyList<n14.Vector4> Input_0 = (n16.IReadOnlyList<n14.Vector4>)Input_In;
            var Result_1 = n45.MemoryUtils.AsReadOnlyMemory<n14.Vector4>(input: Input_0);
            Result_Out = Result_1;
            return;
        }

        public void CreateDefault(out n8.Material Output_Out)
        {
            n46._Operations_.CreateDefault_Generic<n8.Material>(Output_Out: out n8.Material Output_0);
            Output_Out = Output_0;
            return;
        }

        public void One(out float One_Out)
        {
            var One_0 = n47.Float32Extensions.One;
            One_Out = One_0;
            return;
        }

        public void OperatorMulitply_Scale(float Input_In, float Scalar_In, out float Output_Out)
        {
            var Output_0 = n47.Float32Extensions.Scale(input: Input_In, scalar: Scalar_In);
            Output_Out = Output_0;
            return;
        }
    }
}