extern alias e22;
extern alias e24;
extern alias e21;
extern alias e31;
extern alias e26;
extern alias e3;
extern alias e25;
extern alias e2;
extern alias e48;
extern alias e71;
extern alias e29;
extern alias e4;

using n10 = _VL_Stride_Rendering_.Stride.Rendering;
using n18 = e26::Stride.Graphics;
using n27 = _CoreLibBasics_._3D.Matrix;
using n43 = e22::Stride.Graphics.GeometricPrimitives;
using n15 = _CoreLibBasics_.Control.Advanced;
using n20 = e2::VL.Lib.Collections;
using n59 = e3::VL.Lib.Primitive.CacheRegion;
using n78 = _CoreLibBasics_.Animation.FrameBased;
using n79 = _CoreLibBasics_.Primitive.Object.Advanced;
using n22 = _CoreLibBasics_.Control;
using n28 = _VL_Collections_.Collections.Dictionary;
using n24 = global::System.Collections.Immutable;
using n19 = e71::Fuse;
using n45 = _CoreLibBasics_._3D.Transform;
using n36 = e29::Stride.Rendering.Images;
using n41 = e29::Stride.Rendering.Lights;
using n32 = e31::VL.Stride.Shaders.ShaderFX;
using n73 = _VL_Stride_Rendering_.Stride.Rendering.Utils;
using n39 = _VL_Stride_Rendering_ShaderFX_.Stride.Rendering;
using n53 = _VL_Stride_Engine_.Stride.Models.Experimental;
using n54 = _VL_Stride_Rendering_ShaderFX_.Stride.Materials;
using n26 = e31::VL.Stride.Graphics;
using n56 = _CoreLibBasics_.Animation.IFrameClock.Advanced;
using n8 = e21::Stride.Shaders;
using n61 = _Fuse_Core_.Fuse.Core.Function;
using n13 = global::System.Collections.Generic;
using n47 = e31::VL.Stride.Rendering.Lights;
using n83 = _CoreLibBasics_.Math.Adaptive;
using n69 = _Fuse_Core_.Fuse.Core.Texture;
using n37 = _VL_Stride_Engine_.Stride.Rendering;
using n82 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n75 = e71::Fuse.compute;
using n50 = _VL_Stride_Assets_Windows_.Stride.Assets;
using n63 = _Fuse_Core_Math_.Fuse.Core.Math;
using n12 = _VL_Stride_Rendering_.Stride.Models.Meshes.Experimental;
using n58 = _CoreLibBasics_.Animation;
using n71 = _Fuse_Core_.Fuse.Core.Join;
using n77 = e3::VL.Lib.Primitive;
using n76 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n49 = _VL_Stride_Engine_.Stride.Lights;
using n16 = e24::Stride.Engine;
using n21 = _Fuse_Common_Draw_;
using n62 = _Fuse_Core_Domain_.Fuse.Core.Domain._2D;
using n38 = e25::Stride.Games;
using n29 = _Fuse_Core_.Fuse.Core.StrideIntegration;
using n17 = _VL_Stride_Engine_.Stride.Models;
using n1 = e2::VL.Core;
using n6 = e31::VL.Stride.Rendering;
using n3 = e22::Stride.Graphics;
using n65 = _Fuse_Core_.Fuse.Core.Value;
using n25 = _VL_Stride_Rendering_ShaderFX_.Stride.Rendering.Experimental;
using n2 = global::System;
using n7 = e4::Stride.Core.Mathematics;
using n42 = e29::Stride.Rendering.Images.FXAAEffect;
using n33 = _CoreLibBasics_.Color.RGBA;
using n68 = _VL_Stride_Graphics_.Stride.Textures;
using n40 = e2::VL.Lib.IO;
using n70 = _Fuse_Core_.Fuse.Core.Swizzle;
using n5 = e2::VL.Core.CompilerServices;
using n31 = _Fuse_Core_Color_.Fuse.Core.Color;
using n52 = _VL_Stride_Rendering_.Stride.Models.Meshes.Advanced;
using n67 = _Fuse_Core_.Fuse.Core.ComputeShader.FixedType;
using n74 = _VL_Collections_.Collections.Mutable.MutableArray.Advanced;
using n35 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.DepthStencilStateDescription.Advanced;
using n30 = _VL_Stride_Engine_.Stride;
using n34 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.RasterizerStateDescription.Advanced;
using n57 = e2::VL.Lib.Animation;
using n60 = _Fuse_Core_.Fuse.Core.Implementation;
using n9 = e29::Stride.Rendering;
using n48 = _CoreLibBasics_._3D;
using n80 = _Fuse_Core_.Fuse.Core.Util;
using n51 = _VL_Collections_.Collections.Sequence;
using n11 = global::System.Runtime.CompilerServices;
using n64 = _Fuse_Core_.Fuse.Core.Conversion;
using n55 = _VL_Stride_Rendering_.Stride.Models;
using n46 = e48::Stride.Assets.Textures;
using n23 = _VL_Collections_.Collections.Spread;
using n66 = e31::VL.Stride.Rendering.ComputeEffect;
using n72 = _Fuse_Core_.Fuse.Core.ComputeShader;
using n81 = _CoreLibBasics_.Primitive.Advanced;
using n14 = e29::Stride.Rendering.Materials;
using n4 = _Fuse_Common_Draw_.Fuse.Common.Draw;
using n44 = _CoreLibBasics_._3D.Vector3;

namespace _Fuse_Common_Draw_.Fuse.Common.Draw
{
    [n1.ElementAttribute(TracingId = 314960U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "UNWDZ9whb4yMN6zUAgyTUN", Name = "Sprite_UNWDZ9whb4yMN6zUAgyTUN")]
    [n2.SerializableAttribute]
    public class Sprite_UNWDZ9whb4yMN6zUAgyTUN : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Sprite_UNWDZ9whb4yMN6zUAgyTUN Create(n1.NodeContext Node_Context)
        {
            var instance = new Sprite_UNWDZ9whb4yMN6zUAgyTUN(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Sprite_UNWDZ9whb4yMN6zUAgyTUN CreateDefault()
        {
            var instance = new Sprite_UNWDZ9whb4yMN6zUAgyTUN(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Sprite_UNWDZ9whb4yMN6zUAgyTUN Update(object Position_3D_Buffer_In, object Size_Buffer_In, [n5.SerializedDefaultValueAttribute("0.01", false)] float Size_Default_In, object Color_Buffer_In, [n5.SerializedDefaultValueAttribute("1, 1, 1, 0", false)] n7.Color4 Color_Defualt_In, object World_In, n3.BlendStateDescription Blend_State_In, n3.DepthStencilStateDescription Depth_Stencil_State_In, [n5.SerializedDefaultValueAttribute("9", false)] int Count_In, out n10.MeshRenderer_C Output_Out)
        {
            n3.PrimitiveType __pad_UY7uI9MzQSfOQaYgYXAwoH_0 = __slot_UY7uI9MzQSfOQaYgYXAwoH;
            n6.IEffect Effect_Instance_1 = default(n6.IEffect);
            bool SetEffect_2 = true;
            var Output_3 = this.__p_OLDxmUVaqS9NZemJq3ukuA;
            if (SetEffect_2)
            {
                Output_3 = this.__p_OLDxmUVaqS9NZemJq3ukuA.SetEffect(Effect_Instance_In: Effect_Instance_1);
            }

            bool SetBlendState_4 = true;
            var Output_5 = Output_3;
            if (SetBlendState_4)
            {
                Output_5 = Output_3.SetBlendState(Blend_State_In: Blend_State_In);
            }

            bool SetDepthStencilState_6 = true;
            var Output_7 = Output_5;
            if (SetDepthStencilState_6)
            {
                Output_7 = Output_5.SetDepthStencilState(Depth_Stencil_State_In: Depth_Stencil_State_In);
            }

            n3.PrimitiveType Topology_8 = __c_CQBj9t5ndq3N7CmBMvQlyq;
            n7.BoundingBox Bounding_Box_9 = default(n7.BoundingBox);
            string Material_Extension_Name_10 = "";
            n8.ShaderSource Material_Extension_Shader_11 = default(n8.ShaderSource);
            var State_Output_13 = this.__p_N7xZz0tggRcMjryFMoVOn0.Update(Count_In: Count_In, Topology_In: Topology_8, Bounding_Box_In: Bounding_Box_9, Material_Extension_Name_In: Material_Extension_Name_10, Material_Extension_Shader_In: Material_Extension_Shader_11, Output_Out: out n9.Mesh Output_12);
            int Instance_Count_14 = 1;
            string Profiling_Name_15 = "Mesh Renderer";
            bool Update_16 = true;
            var Output_17 = Output_7;
            if (Update_16)
            {
                Output_17 = Output_7.Update(Mesh_In: Output_12, Instance_Count_In: Instance_Count_14, Profiling_Name_In: Profiling_Name_15);
            }

            bool SetTopology_18 = true;
            var Output_19 = Output_17;
            if (SetTopology_18)
            {
                Output_19 = Output_17.SetTopology(Topology_In: __pad_UY7uI9MzQSfOQaYgYXAwoH_0);
            }

            int Draw_Count_20 = 0;
            bool SetDrawCount_21 = true;
            var Output_22 = Output_19;
            if (SetDrawCount_21)
            {
                Output_22 = Output_19.SetDrawCount(Draw_Count_In: Draw_Count_20);
            }

            Output_Out = Output_22;
            n4.Sprite_UNWDZ9whb4yMN6zUAgyTUN that_23 = this;
            if (this.__GetContext__().IsImmutable)
                that_23 = Output_22 != this.__p_OLDxmUVaqS9NZemJq3ukuA || State_Output_13 != this.__p_N7xZz0tggRcMjryFMoVOn0 ? new Sprite_UNWDZ9whb4yMN6zUAgyTUN(this)
                {__p_OLDxmUVaqS9NZemJq3ukuA = Output_22, __p_N7xZz0tggRcMjryFMoVOn0 = State_Output_13} : that_23;
            else
            {
                this.__p_OLDxmUVaqS9NZemJq3ukuA = Output_22;
                this.__p_N7xZz0tggRcMjryFMoVOn0 = State_Output_13;
            }

            return that_23;
        }

        public n4.Sprite_UNWDZ9whb4yMN6zUAgyTUN __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "OLDxmUVaqS9NZemJq3ukuA", 314964U);
            var Output_1 = n10.MeshRenderer_C.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "N7xZz0tggRcMjryFMoVOn0", 314994U);
            var Output_3 = n12.NullMesh_RVhRxaDLhacPJItJYT8T62.Create(Node_Context: Node_Context_2);
            n4.Sprite_UNWDZ9whb4yMN6zUAgyTUN that_4 = this;
            this.__p_OLDxmUVaqS9NZemJq3ukuA = Output_1;
            this.__p_N7xZz0tggRcMjryFMoVOn0 = Output_3;
            return that_4;
        }

        public n4.Sprite_UNWDZ9whb4yMN6zUAgyTUN __CreateDefault__()
        {
            n4.Sprite_UNWDZ9whb4yMN6zUAgyTUN that_0 = this;
            this.__p_OLDxmUVaqS9NZemJq3ukuA = n10.MeshRenderer_C.CreateDefault();
            this.__p_N7xZz0tggRcMjryFMoVOn0 = n12.NullMesh_RVhRxaDLhacPJItJYT8T62.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_OLDxmUVaqS9NZemJq3ukuA);
            n1.CompilationHelper.SafeDispose(this.__p_N7xZz0tggRcMjryFMoVOn0);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 314978U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "UY7uI9MzQSfOQaYgYXAwoH", Name = "__slot_UY7uI9MzQSfOQaYgYXAwoH")]
        public static n3.PrimitiveType __slot_UY7uI9MzQSfOQaYgYXAwoH = n1.CompilationHelper.Deserialize<n3.PrimitiveType>("TriangleStrip", false, "JPmuEharYwiLQs6dOuoEQQ", "UY7uI9MzQSfOQaYgYXAwoH");
        [n1.ElementAttribute(TracingId = 314964U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "OLDxmUVaqS9NZemJq3ukuA", Name = "MeshRenderer", IsManaged = true, IsAutoGenerated = true)]
        public n10.MeshRenderer_C __p_OLDxmUVaqS9NZemJq3ukuA;
        [n1.ElementAttribute(TracingId = 314994U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "N7xZz0tggRcMjryFMoVOn0", Name = "NullMesh", IsManaged = true, IsAutoGenerated = true)]
        public n12.NullMesh_RVhRxaDLhacPJItJYT8T62 __p_N7xZz0tggRcMjryFMoVOn0;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.PrimitiveType __c_CQBj9t5ndq3N7CmBMvQlyq = n1.CompilationHelper.Deserialize<n3.PrimitiveType>("TriangleStrip", false, "JPmuEharYwiLQs6dOuoEQQ", "CQBj9t5ndq3N7CmBMvQlyq");
        static Sprite_UNWDZ9whb4yMN6zUAgyTUN()
        {
        }

        public Sprite_UNWDZ9whb4yMN6zUAgyTUN(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Sprite_UNWDZ9whb4yMN6zUAgyTUN(Sprite_UNWDZ9whb4yMN6zUAgyTUN other): base(other)
        {
            this.__p_OLDxmUVaqS9NZemJq3ukuA = other.__p_OLDxmUVaqS9NZemJq3ukuA;
            this.__p_N7xZz0tggRcMjryFMoVOn0 = other.__p_N7xZz0tggRcMjryFMoVOn0;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_OLDxmUVaqS9NZemJq3ukuA", in __p_OLDxmUVaqS9NZemJq3ukuA), n1.CompilationHelper.GetValueOrExisting(values, "__p_N7xZz0tggRcMjryFMoVOn0", in __p_N7xZz0tggRcMjryFMoVOn0));
        }

        internal Sprite_UNWDZ9whb4yMN6zUAgyTUN __WITH__(n10.MeshRenderer_C __p_OLDxmUVaqS9NZemJq3ukuA, n12.NullMesh_RVhRxaDLhacPJItJYT8T62 __p_N7xZz0tggRcMjryFMoVOn0)
        {
            n4.Sprite_UNWDZ9whb4yMN6zUAgyTUN that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_OLDxmUVaqS9NZemJq3ukuA != this.__p_OLDxmUVaqS9NZemJq3ukuA || __p_N7xZz0tggRcMjryFMoVOn0 != this.__p_N7xZz0tggRcMjryFMoVOn0 ? new Sprite_UNWDZ9whb4yMN6zUAgyTUN(this)
                {__p_OLDxmUVaqS9NZemJq3ukuA = __p_OLDxmUVaqS9NZemJq3ukuA, __p_N7xZz0tggRcMjryFMoVOn0 = __p_N7xZz0tggRcMjryFMoVOn0} : that_0;
            else
            {
                this.__p_OLDxmUVaqS9NZemJq3ukuA = __p_OLDxmUVaqS9NZemJq3ukuA;
                this.__p_N7xZz0tggRcMjryFMoVOn0 = __p_N7xZz0tggRcMjryFMoVOn0;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 315041U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Vr0Pzykf2I3PC6fkNuzYAR", Name = "SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR")]
    [n2.SerializableAttribute]
    public class SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR Create(n1.NodeContext Node_Context)
        {
            var instance = new SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR CreateDefault()
        {
            var instance = new SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR Update(n3.Buffer Pos_Buffer_In, n3.Buffer Size_Buffer_In, [n5.SerializedDefaultValueAttribute("0.07", false)] float Size_Defualt_In, n9.Material Material_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Draw_Perspective_In, [n5.SerializedDefaultValueAttribute("64", false)] int Draw_Count_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Is_Shadow_Caster_In, n7.BoundingBox Bounding_Box_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n16.Entity Entity_Out)
        {
            n7.Vector3 __pad_BzT78Gdv13ENrZilgu9DsZ_0 = __slot_BzT78Gdv13ENrZilgu9DsZ;
            n7.Vector3 __pad_Fak9uXHVyKnOCBCqdeIvTX_1 = __slot_Fak9uXHVyKnOCBCqdeIvTX;
            bool __pad_DGHgSD9WWblOugpqB5BTom_2 = __slot_DGHgSD9WWblOugpqB5BTom;
            n1.CompilationHelper.WritePin(this.__p_SafZRlOmgpFQDkafJRhHhP.Inputs[0], ref Pos_Buffer_In);
            n1.CompilationHelper.WritePin(this.__p_SafZRlOmgpFQDkafJRhHhP.Inputs[1], ref Size_Buffer_In);
            n1.CompilationHelper.WritePin(this.__p_SafZRlOmgpFQDkafJRhHhP.Inputs[2], ref Size_Defualt_In);
            n1.CompilationHelper.ReadPin(this.__p_SafZRlOmgpFQDkafJRhHhP.Outputs[0], out n14.IComputeNode out_3);
            n1.CompilationHelper.WritePin(this.__p_GvUfYE9avW2QQ3RwNP6CI2.Inputs[0], ref Material_In);
            bool __pad_OReY8fkrh8yOcaRo9hJq62_4 = Draw_Perspective_In;
            n1.CompilationHelper.WritePin(this.__p_QcjE9kcplOYOyHq2kgcQFj.Inputs[0], ref out_3);
            n1.CompilationHelper.ReadPin(this.__p_QcjE9kcplOYOyHq2kgcQFj.Outputs[0], out n14.IComputeNode out_5);
            n1.CompilationHelper.WritePin(this.__p_UsZcekzZylbMSNRjNtiZ4X.Inputs[0], ref out_3);
            n1.CompilationHelper.ReadPin(this.__p_UsZcekzZylbMSNRjNtiZ4X.Outputs[0], out n14.IComputeNode out_6);
            n15._Operations_.Switch_Boolean<n14.IComputeNode>(Condition_In: __pad_OReY8fkrh8yOcaRo9hJq62_4, Input_In: out_5, Input_2_In: out_6, Output_Out: out n14.IComputeNode Output_7);
            n1.CompilationHelper.WritePin(this.__p_GvUfYE9avW2QQ3RwNP6CI2.Inputs[1], ref Output_7);
            n1.CompilationHelper.WritePin(this.__p_GvUfYE9avW2QQ3RwNP6CI2.Inputs[4], ref __pad_DGHgSD9WWblOugpqB5BTom_2);
            n1.CompilationHelper.ReadPin(this.__p_GvUfYE9avW2QQ3RwNP6CI2.Outputs[0], out n9.Material out_8);
            n7.BoundingBox Input_2_9 = default(n7.BoundingBox);
            var Result_10 = Bounding_Box_In == Input_2_9;
            var Output_11 = new n7.BoundingBox(minimum: __pad_BzT78Gdv13ENrZilgu9DsZ_0, maximum: __pad_Fak9uXHVyKnOCBCqdeIvTX_1);
            n15._Operations_.Switch_Boolean<n7.BoundingBox>(Condition_In: Result_10, Input_In: Bounding_Box_In, Input_2_In: Output_11, Output_Out: out n7.BoundingBox Output_12);
            n3.PrimitiveType Topology_13 = __c_FI19xzu4YzLLXlCwM9zVCb;
            string Material_Extension_Name_14 = "";
            n8.ShaderSource Material_Extension_Shader_15 = default(n8.ShaderSource);
            var State_Output_17 = this.__p_J3ARyRUzRziPNY0jWJUFgs.Update(Count_In: Draw_Count_In, Topology_In: Topology_13, Bounding_Box_In: Output_12, Material_Extension_Name_In: Material_Extension_Name_14, Material_Extension_Shader_In: Material_Extension_Shader_15, Output_Out: out n9.Mesh Output_16);
            bool SetMesh_18 = true;
            var Output_19 = this.__p_EBZRfmI2KT1NMmgPm65KmV;
            if (SetMesh_18)
            {
                Output_19 = this.__p_EBZRfmI2KT1NMmgPm65KmV.SetMesh(Mesh_In: Output_16);
            }

            bool SetMaterial_20 = true;
            var Output_21 = Output_19;
            if (SetMaterial_20)
            {
                Output_21 = Output_19.SetMaterial(Material_In: out_8);
            }

            bool SetIsShadowCaster_22 = true;
            var Output_23 = Output_21;
            if (SetIsShadowCaster_22)
            {
                Output_23 = Output_21.SetIsShadowCaster(Is_Shadow_Caster_In: Is_Shadow_Caster_In);
            }

            bool SetEnabled_24 = true;
            var Output_25 = Output_23;
            if (SetEnabled_24)
            {
                Output_25 = Output_23.SetEnabled(Enabled_In: Enabled_In);
            }

            var Output_27 = Output_25.Update(Entity_Out: out n16.Entity Entity_26);
            Entity_Out = Entity_26;
            n4.SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR that_28 = this;
            if (this.__GetContext__().IsImmutable)
                that_28 = this.__p_SafZRlOmgpFQDkafJRhHhP != this.__p_SafZRlOmgpFQDkafJRhHhP || this.__p_GvUfYE9avW2QQ3RwNP6CI2 != this.__p_GvUfYE9avW2QQ3RwNP6CI2 || Draw_Perspective_In != this.__slot_OReY8fkrh8yOcaRo9hJq62 || this.__p_QcjE9kcplOYOyHq2kgcQFj != this.__p_QcjE9kcplOYOyHq2kgcQFj || this.__p_UsZcekzZylbMSNRjNtiZ4X != this.__p_UsZcekzZylbMSNRjNtiZ4X || State_Output_17 != this.__p_J3ARyRUzRziPNY0jWJUFgs || Output_27 != this.__p_EBZRfmI2KT1NMmgPm65KmV ? new SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR(this)
                {__p_SafZRlOmgpFQDkafJRhHhP = this.__p_SafZRlOmgpFQDkafJRhHhP, __p_GvUfYE9avW2QQ3RwNP6CI2 = this.__p_GvUfYE9avW2QQ3RwNP6CI2, __slot_OReY8fkrh8yOcaRo9hJq62 = Draw_Perspective_In, __p_QcjE9kcplOYOyHq2kgcQFj = this.__p_QcjE9kcplOYOyHq2kgcQFj, __p_UsZcekzZylbMSNRjNtiZ4X = this.__p_UsZcekzZylbMSNRjNtiZ4X, __p_J3ARyRUzRziPNY0jWJUFgs = State_Output_17, __p_EBZRfmI2KT1NMmgPm65KmV = Output_27} : that_28;
            else
            {
                this.__p_SafZRlOmgpFQDkafJRhHhP = this.__p_SafZRlOmgpFQDkafJRhHhP;
                this.__p_GvUfYE9avW2QQ3RwNP6CI2 = this.__p_GvUfYE9avW2QQ3RwNP6CI2;
                this.__slot_OReY8fkrh8yOcaRo9hJq62 = Draw_Perspective_In;
                this.__p_QcjE9kcplOYOyHq2kgcQFj = this.__p_QcjE9kcplOYOyHq2kgcQFj;
                this.__p_UsZcekzZylbMSNRjNtiZ4X = this.__p_UsZcekzZylbMSNRjNtiZ4X;
                this.__p_J3ARyRUzRziPNY0jWJUFgs = State_Output_17;
                this.__p_EBZRfmI2KT1NMmgPm65KmV = Output_27;
            }

            return that_28;
        }

        public n4.SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "EBZRfmI2KT1NMmgPm65KmV", 315044U);
            var Output_1 = n17.MeshEntity_C.Create(Node_Context: Node_Context_0);
            var node_2 = n1.CompilationHelper.CreateNodeById(Node_Context, "Imposter", "Stride.Rendering.Experimental.ShaderFX");
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "J3ARyRUzRziPNY0jWJUFgs", 315089U);
            var Output_4 = n12.NullMesh_RVhRxaDLhacPJItJYT8T62.Create(Node_Context: Node_Context_3);
            var node_5 = n1.CompilationHelper.CreateNodeById(Node_Context, "MaterialExtension", "Stride.Advanced.Materials");
            var node_6 = n1.CompilationHelper.CreateNodeById(Node_Context, "FuseCommonDrawSphereSimpleExtension", "Stride.Rendering.Experimental.ShaderFX");
            var node_7 = n1.CompilationHelper.CreateNodeById(Node_Context, "FuseCommonDrawSphereImposterExtension", "Stride.Rendering.Experimental.ShaderFX");
            n4.SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR that_8 = this;
            this.__slot_OReY8fkrh8yOcaRo9hJq62 = false;
            this.__p_EBZRfmI2KT1NMmgPm65KmV = Output_1;
            this.__p_SafZRlOmgpFQDkafJRhHhP = node_2;
            this.__p_J3ARyRUzRziPNY0jWJUFgs = Output_4;
            this.__p_GvUfYE9avW2QQ3RwNP6CI2 = node_5;
            this.__p_QcjE9kcplOYOyHq2kgcQFj = node_6;
            this.__p_UsZcekzZylbMSNRjNtiZ4X = node_7;
            return that_8;
        }

        public n4.SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR __CreateDefault__()
        {
            n4.SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR that_0 = this;
            this.__slot_OReY8fkrh8yOcaRo9hJq62 = false;
            this.__p_SafZRlOmgpFQDkafJRhHhP = default(n1.IVLNode);
            this.__p_GvUfYE9avW2QQ3RwNP6CI2 = default(n1.IVLNode);
            this.__p_QcjE9kcplOYOyHq2kgcQFj = default(n1.IVLNode);
            this.__p_UsZcekzZylbMSNRjNtiZ4X = default(n1.IVLNode);
            this.__p_J3ARyRUzRziPNY0jWJUFgs = n12.NullMesh_RVhRxaDLhacPJItJYT8T62.CreateDefault();
            this.__p_EBZRfmI2KT1NMmgPm65KmV = n17.MeshEntity_C.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_SafZRlOmgpFQDkafJRhHhP);
            n1.CompilationHelper.SafeDispose(this.__p_GvUfYE9avW2QQ3RwNP6CI2);
            n1.CompilationHelper.SafeDispose(this.__p_QcjE9kcplOYOyHq2kgcQFj);
            n1.CompilationHelper.SafeDispose(this.__p_UsZcekzZylbMSNRjNtiZ4X);
            n1.CompilationHelper.SafeDispose(this.__p_J3ARyRUzRziPNY0jWJUFgs);
            n1.CompilationHelper.SafeDispose(this.__p_EBZRfmI2KT1NMmgPm65KmV);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 315054U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "GvxgqHr1nUtMVHVeo5NYwk", Name = "__slot_GvxgqHr1nUtMVHVeo5NYwk")]
        public static string __slot_GvxgqHr1nUtMVHVeo5NYwk = "needs to render in transparent stage";
        [n1.ElementAttribute(TracingId = 315066U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Fak9uXHVyKnOCBCqdeIvTX", Name = "__slot_Fak9uXHVyKnOCBCqdeIvTX")]
        public static n7.Vector3 __slot_Fak9uXHVyKnOCBCqdeIvTX = n1.CompilationHelper.Deserialize<n7.Vector3>("10, 10, 10", false, "JPmuEharYwiLQs6dOuoEQQ", "Fak9uXHVyKnOCBCqdeIvTX");
        [n1.ElementAttribute(TracingId = 315067U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "BzT78Gdv13ENrZilgu9DsZ", Name = "__slot_BzT78Gdv13ENrZilgu9DsZ")]
        public static n7.Vector3 __slot_BzT78Gdv13ENrZilgu9DsZ = n1.CompilationHelper.Deserialize<n7.Vector3>("-10, -10, -10", false, "JPmuEharYwiLQs6dOuoEQQ", "BzT78Gdv13ENrZilgu9DsZ");
        [n1.ElementAttribute(TracingId = 315068U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "OReY8fkrh8yOcaRo9hJq62", Name = "__slot_OReY8fkrh8yOcaRo9hJq62")]
        public bool __slot_OReY8fkrh8yOcaRo9hJq62;
        [n1.ElementAttribute(TracingId = 315080U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "LaTID0uUKjrLh67ZV4pVIy", Name = "__slot_LaTID0uUKjrLh67ZV4pVIy")]
        public static string __slot_LaTID0uUKjrLh67ZV4pVIy = "Defualt Setting";
        [n1.ElementAttribute(TracingId = 315087U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "BidOukIiD9LP51zxEotFHr", Name = "__slot_BidOukIiD9LP51zxEotFHr")]
        public static string __slot_BidOukIiD9LP51zxEotFHr = "Hack for IsAssigned";
        [n1.ElementAttribute(TracingId = 315099U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "DGHgSD9WWblOugpqB5BTom", Name = "__slot_DGHgSD9WWblOugpqB5BTom")]
        public static bool __slot_DGHgSD9WWblOugpqB5BTom = true;
        [n1.ElementAttribute(TracingId = 315056U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "SafZRlOmgpFQDkafJRhHhP", Name = "Imposter", IsManaged = true, IsAutoGenerated = true, NodeName = "Imposter", NodeCategory = "Stride.Rendering.Experimental.ShaderFX")]
        public n1.IVLNode __p_SafZRlOmgpFQDkafJRhHhP;
        [n1.ElementAttribute(TracingId = 315094U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "GvUfYE9avW2QQ3RwNP6CI2", Name = "MaterialExtension", IsManaged = true, IsAutoGenerated = true, NodeName = "MaterialExtension", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_GvUfYE9avW2QQ3RwNP6CI2;
        [n1.ElementAttribute(TracingId = 315100U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "QcjE9kcplOYOyHq2kgcQFj", Name = "FuseCommonDrawSphereSimpleExtension", IsManaged = true, IsAutoGenerated = true, NodeName = "FuseCommonDrawSphereSimpleExtension", NodeCategory = "Stride.Rendering.Experimental.ShaderFX")]
        public n1.IVLNode __p_QcjE9kcplOYOyHq2kgcQFj;
        [n1.ElementAttribute(TracingId = 315110U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "UsZcekzZylbMSNRjNtiZ4X", Name = "FuseCommonDrawSphereImposterExtension", IsManaged = true, IsAutoGenerated = true, NodeName = "FuseCommonDrawSphereImposterExtension", NodeCategory = "Stride.Rendering.Experimental.ShaderFX")]
        public n1.IVLNode __p_UsZcekzZylbMSNRjNtiZ4X;
        [n1.ElementAttribute(TracingId = 315089U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "J3ARyRUzRziPNY0jWJUFgs", Name = "NullMesh", IsManaged = true, IsAutoGenerated = true)]
        public n12.NullMesh_RVhRxaDLhacPJItJYT8T62 __p_J3ARyRUzRziPNY0jWJUFgs;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n3.PrimitiveType __c_FI19xzu4YzLLXlCwM9zVCb = n1.CompilationHelper.Deserialize<n3.PrimitiveType>("TriangleStrip", false, "JPmuEharYwiLQs6dOuoEQQ", "FI19xzu4YzLLXlCwM9zVCb");
        [n1.ElementAttribute(TracingId = 315044U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "EBZRfmI2KT1NMmgPm65KmV", Name = "MeshEntity", IsManaged = true, IsAutoGenerated = true)]
        public n17.MeshEntity_C __p_EBZRfmI2KT1NMmgPm65KmV;
        static SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR()
        {
        }

        public SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR(SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR other): base(other)
        {
            this.__slot_OReY8fkrh8yOcaRo9hJq62 = other.__slot_OReY8fkrh8yOcaRo9hJq62;
            this.__p_SafZRlOmgpFQDkafJRhHhP = other.__p_SafZRlOmgpFQDkafJRhHhP;
            this.__p_GvUfYE9avW2QQ3RwNP6CI2 = other.__p_GvUfYE9avW2QQ3RwNP6CI2;
            this.__p_QcjE9kcplOYOyHq2kgcQFj = other.__p_QcjE9kcplOYOyHq2kgcQFj;
            this.__p_UsZcekzZylbMSNRjNtiZ4X = other.__p_UsZcekzZylbMSNRjNtiZ4X;
            this.__p_J3ARyRUzRziPNY0jWJUFgs = other.__p_J3ARyRUzRziPNY0jWJUFgs;
            this.__p_EBZRfmI2KT1NMmgPm65KmV = other.__p_EBZRfmI2KT1NMmgPm65KmV;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_OReY8fkrh8yOcaRo9hJq62", in __slot_OReY8fkrh8yOcaRo9hJq62), n1.CompilationHelper.GetValueOrExisting(values, "__p_SafZRlOmgpFQDkafJRhHhP", in __p_SafZRlOmgpFQDkafJRhHhP), n1.CompilationHelper.GetValueOrExisting(values, "__p_GvUfYE9avW2QQ3RwNP6CI2", in __p_GvUfYE9avW2QQ3RwNP6CI2), n1.CompilationHelper.GetValueOrExisting(values, "__p_QcjE9kcplOYOyHq2kgcQFj", in __p_QcjE9kcplOYOyHq2kgcQFj), n1.CompilationHelper.GetValueOrExisting(values, "__p_UsZcekzZylbMSNRjNtiZ4X", in __p_UsZcekzZylbMSNRjNtiZ4X), n1.CompilationHelper.GetValueOrExisting(values, "__p_J3ARyRUzRziPNY0jWJUFgs", in __p_J3ARyRUzRziPNY0jWJUFgs), n1.CompilationHelper.GetValueOrExisting(values, "__p_EBZRfmI2KT1NMmgPm65KmV", in __p_EBZRfmI2KT1NMmgPm65KmV));
        }

        internal SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR __WITH__(bool __slot_OReY8fkrh8yOcaRo9hJq62, n1.IVLNode __p_SafZRlOmgpFQDkafJRhHhP, n1.IVLNode __p_GvUfYE9avW2QQ3RwNP6CI2, n1.IVLNode __p_QcjE9kcplOYOyHq2kgcQFj, n1.IVLNode __p_UsZcekzZylbMSNRjNtiZ4X, n12.NullMesh_RVhRxaDLhacPJItJYT8T62 __p_J3ARyRUzRziPNY0jWJUFgs, n17.MeshEntity_C __p_EBZRfmI2KT1NMmgPm65KmV)
        {
            n4.SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_OReY8fkrh8yOcaRo9hJq62 != this.__slot_OReY8fkrh8yOcaRo9hJq62 || __p_SafZRlOmgpFQDkafJRhHhP != this.__p_SafZRlOmgpFQDkafJRhHhP || __p_GvUfYE9avW2QQ3RwNP6CI2 != this.__p_GvUfYE9avW2QQ3RwNP6CI2 || __p_QcjE9kcplOYOyHq2kgcQFj != this.__p_QcjE9kcplOYOyHq2kgcQFj || __p_UsZcekzZylbMSNRjNtiZ4X != this.__p_UsZcekzZylbMSNRjNtiZ4X || __p_J3ARyRUzRziPNY0jWJUFgs != this.__p_J3ARyRUzRziPNY0jWJUFgs || __p_EBZRfmI2KT1NMmgPm65KmV != this.__p_EBZRfmI2KT1NMmgPm65KmV ? new SphereImposter_Material_Vr0Pzykf2I3PC6fkNuzYAR(this)
                {__slot_OReY8fkrh8yOcaRo9hJq62 = __slot_OReY8fkrh8yOcaRo9hJq62, __p_SafZRlOmgpFQDkafJRhHhP = __p_SafZRlOmgpFQDkafJRhHhP, __p_GvUfYE9avW2QQ3RwNP6CI2 = __p_GvUfYE9avW2QQ3RwNP6CI2, __p_QcjE9kcplOYOyHq2kgcQFj = __p_QcjE9kcplOYOyHq2kgcQFj, __p_UsZcekzZylbMSNRjNtiZ4X = __p_UsZcekzZylbMSNRjNtiZ4X, __p_J3ARyRUzRziPNY0jWJUFgs = __p_J3ARyRUzRziPNY0jWJUFgs, __p_EBZRfmI2KT1NMmgPm65KmV = __p_EBZRfmI2KT1NMmgPm65KmV} : that_0;
            else
            {
                this.__slot_OReY8fkrh8yOcaRo9hJq62 = __slot_OReY8fkrh8yOcaRo9hJq62;
                this.__p_SafZRlOmgpFQDkafJRhHhP = __p_SafZRlOmgpFQDkafJRhHhP;
                this.__p_GvUfYE9avW2QQ3RwNP6CI2 = __p_GvUfYE9avW2QQ3RwNP6CI2;
                this.__p_QcjE9kcplOYOyHq2kgcQFj = __p_QcjE9kcplOYOyHq2kgcQFj;
                this.__p_UsZcekzZylbMSNRjNtiZ4X = __p_UsZcekzZylbMSNRjNtiZ4X;
                this.__p_J3ARyRUzRziPNY0jWJUFgs = __p_J3ARyRUzRziPNY0jWJUFgs;
                this.__p_EBZRfmI2KT1NMmgPm65KmV = __p_EBZRfmI2KT1NMmgPm65KmV;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 315165U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "C6uIqzI5uPRMM3sQmst2S5", Name = "RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5")]
    [n2.SerializableAttribute]
    public class RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 Create(n1.NodeContext Node_Context)
        {
            var instance = new RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 CreateDefault()
        {
            var instance = new RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 Update(n19.GpuValue<n7.Vector4> Input_In, [n5.SerializedDefaultValueAttribute("1024, 1024", false)] n7.Int2 Size_In, [n5.SerializedDefaultValueAttribute("R16G16B16A16_Float", false)] n18.PixelFormat Format_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Clear_In, [n5.SerializedDefaultValueAttribute("0, 0, 0, 0", false)] n7.Color4 Clear_Color_In, bool Convert_SRGB_to_RGB_In, out n3.Texture Texture_Out, out string lastError_Out, out string Shader_Code_Out)
        {
            n18.PixelFormat __pad_LKG7CiUMwQLNG9RddzCE2e_0 = __slot_LKG7CiUMwQLNG9RddzCE2e;
            var Output_2 = this.__p_VpwZHLVtPVvMh7vH4WyzN3.Update(sRGB_In: Input_In, RGB_Out: out n19.GpuValue<n7.Vector4> RGB_1);
            bool __pad_Ri3xmeug5NaLRWzqBe410l_3 = Convert_SRGB_to_RGB_In;
            int Index_4 = n2.Convert.ToInt32(__pad_Ri3xmeug5NaLRWzqBe410l_3);
            var builder_5 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV, 2);
            builder_5.Add(Input_In);
            builder_5.Add(RGB_1);
            var __pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV_6 = builder_5.Commit();
            n22._Operations_.Switch<n19.GpuValue<n7.Vector4>, n21.__AdaptiveImplementations__JPmuEharYwiLQs6dOuoEQQ>(Index_In: Index_4, Input_In: __pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV_6, Output_Out: out n19.GpuValue<n7.Vector4> Output_7);
            bool Force_8 = false;
            n19.GpuValue<n7.Vector4> Position_9 = default(n19.GpuValue<n7.Vector4>);
            string TheTemplate_10 = "shader ${shaderID} : VS_PS_Base, Texturing${mixins}\r\n{\r\n    cbuffer Inputs{\r\n${declarations}\r\n    }\r\n\r\n${structs}\r\n\r\n${functions}\r\n${streamDeclaration}\r\n\r\n    stage override void VSMain()\r\n    {\r\n${sourceVS}\r\n${streamsVS}\r\n    }\r\n\r\n    stage override void PSMain()\r\n    {\r\n${sourcePS}\r\n${streamsPS}\r\n    }\r\n};";
            n20.Spread<string> The_Defined_Streams_11 = n23._Operations_.CreateDefault<string>();
            bool SetInputs_12 = true;
            var builder_13 = n5.CollectionBuilders.GetBuilder(this.__pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL, 0);
            var __pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL_14 = builder_13.Commit();
            var Output_15 = this.__p_MNb8POqy5JnMd2aMQ9eRnL;
            if (SetInputs_12)
            {
                Output_15 = this.__p_MNb8POqy5JnMd2aMQ9eRnL.SetInputs(Force_In: Force_8, Position_In: Position_9, CustomStreams_In: __pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL_14, ColorTarget_In: Output_7, TheTemplate_In: TheTemplate_10, The_Defined_Streams_In: The_Defined_Streams_11);
            }

            var State_Output_17 = Output_15.Update(Output_Out: out n25.CustomEffect_C Output_16);
            var Output_19 = State_Output_17.GetLastError(lastError_Out: out string lastError_18);
            var Output_21 = Output_19.GetShaderCode(Shader_Code_Out: out string Shader_Code_20);
            n6.IEffect Effect_Instance_22 = (n6.IEffect)Output_16;
            bool SetEffect_23 = true;
            var Output_24 = this.__p_BDUT8ELCQWQOLmxc2mrBtU;
            if (SetEffect_23)
            {
                Output_24 = this.__p_BDUT8ELCQWQOLmxc2mrBtU.SetEffect(Effect_Instance_In: Effect_Instance_22);
            }

            var Alpha_Blend_25 = n26.BlendStateDescriptions.AlphaBlend;
            bool SetBlendState_26 = true;
            var Output_27 = Output_24;
            if (SetBlendState_26)
            {
                Output_27 = Output_24.SetBlendState(Blend_State_In: Alpha_Blend_25);
            }

            n7.Vector2 Size_28 = __c_MINX0QEnUByNdzCepWHf1N;
            n1.CompilationHelper.WritePin(this.__p_Sy4WD09V3c0Pa4KaMA3l1v.Inputs[0], ref Size_28);
            n1.CompilationHelper.ReadPin(this.__p_Sy4WD09V3c0Pa4KaMA3l1v.Outputs[0], out n9.Mesh out_29);
            int Instance_Count_30 = 1;
            string Profiling_Name_31 = "Mesh Renderer";
            bool Update_32 = true;
            var Output_33 = Output_27;
            if (Update_32)
            {
                Output_33 = Output_27.Update(Mesh_In: out_29, Instance_Count_In: Instance_Count_30, Profiling_Name_In: Profiling_Name_31);
            }

            n9.IGraphicsRendererBase Input_34 = (n9.IGraphicsRendererBase)Output_33;
            n7.Matrix View_35 = n27._Operations_.CreateDefault();
            n7.Matrix Projection_36 = n27._Operations_.CreateDefault();
            float Near_Plane_37 = 0.05F;
            float Far_Plane_38 = 100F;
            var State_Output_40 = this.__p_Gef1AKcqdEsQaHB2149cPN.Update(View_In: View_35, Projection_In: Projection_36, Near_Plane_In: Near_Plane_37, Far_Plane_In: Far_Plane_38, Output_Out: out n9.RenderView Output_39);
            bool Color_Shared_41 = false;
            bool Depth_Shared_42 = false;
            n9.ClearRendererFlags Clear_Flags_43 = default(n9.ClearRendererFlags);
            float Clear_Depth_44 = 1F;
            byte Clear_Stencil_45 = 0;
            bool Auto_Render_46 = true;
            var Output_50 = this.__p_KwrR0U5x9JcMIE7fSwCvjE.Update(Input_In: Input_34, Size_In: Size_In, Render_View_In: Output_39, Format_In: Format_In, Color_Shared_In: Color_Shared_41, Depth_Format_In: __pad_LKG7CiUMwQLNG9RddzCE2e_0, Depth_Shared_In: Depth_Shared_42, Clear_Flags_In: Clear_Flags_43, Clear_Color_In: Clear_Color_In, Clear_Depth_In: Clear_Depth_44, Clear_Stencil_In: Clear_Stencil_45, Clear_In: Clear_In, Auto_Render_In: Auto_Render_46, Layer_Out: out n6.WithRenderTargetAndViewPort Layer_47, Color_Out: out n3.Texture Color_48, Depth_Out: out n3.Texture Depth_49);
            Texture_Out = Color_48;
            lastError_Out = lastError_18;
            Shader_Code_Out = Shader_Code_20;
            n4.RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 that_51 = this;
            if (this.__GetContext__().IsImmutable)
                that_51 = Output_2 != this.__p_VpwZHLVtPVvMh7vH4WyzN3 || Convert_SRGB_to_RGB_In != this.__slot_Ri3xmeug5NaLRWzqBe410l || __pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV_6 != this.__pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV || __pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL_14 != this.__pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL || Output_21 != this.__p_MNb8POqy5JnMd2aMQ9eRnL || Output_33 != this.__p_BDUT8ELCQWQOLmxc2mrBtU || this.__p_Sy4WD09V3c0Pa4KaMA3l1v != this.__p_Sy4WD09V3c0Pa4KaMA3l1v || State_Output_40 != this.__p_Gef1AKcqdEsQaHB2149cPN || Output_50 != this.__p_KwrR0U5x9JcMIE7fSwCvjE ? new RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5(this)
                {__p_VpwZHLVtPVvMh7vH4WyzN3 = Output_2, __slot_Ri3xmeug5NaLRWzqBe410l = Convert_SRGB_to_RGB_In, __pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV = __pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV_6, __pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL = __pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL_14, __p_MNb8POqy5JnMd2aMQ9eRnL = Output_21, __p_BDUT8ELCQWQOLmxc2mrBtU = Output_33, __p_Sy4WD09V3c0Pa4KaMA3l1v = this.__p_Sy4WD09V3c0Pa4KaMA3l1v, __p_Gef1AKcqdEsQaHB2149cPN = State_Output_40, __p_KwrR0U5x9JcMIE7fSwCvjE = Output_50} : that_51;
            else
            {
                this.__p_VpwZHLVtPVvMh7vH4WyzN3 = Output_2;
                this.__slot_Ri3xmeug5NaLRWzqBe410l = Convert_SRGB_to_RGB_In;
                this.__pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV = __pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV_6;
                this.__pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL = __pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL_14;
                this.__p_MNb8POqy5JnMd2aMQ9eRnL = Output_21;
                this.__p_BDUT8ELCQWQOLmxc2mrBtU = Output_33;
                this.__p_Sy4WD09V3c0Pa4KaMA3l1v = this.__p_Sy4WD09V3c0Pa4KaMA3l1v;
                this.__p_Gef1AKcqdEsQaHB2149cPN = State_Output_40;
                this.__p_KwrR0U5x9JcMIE7fSwCvjE = Output_50;
            }

            return that_51;
        }

        public n4.RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "BDUT8ELCQWQOLmxc2mrBtU", 315168U);
            var Output_1 = n10.MeshRenderer_C.Create(Node_Context: Node_Context_0);
            var node_2 = n1.CompilationHelper.CreateNodeById(Node_Context, "PlaneMesh", "Stride.Models.Meshes");
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "MNb8POqy5JnMd2aMQ9eRnL", 315202U);
            var Output_4 = n29.DrawShaderGraph_C.Create(Node_Context: Node_Context_3);
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "KwrR0U5x9JcMIE7fSwCvjE", 315219U);
            var Output_6 = n30.RenderTexture_IYQobGzVbWEQYcMFud8H4J.Create(Node_Context: Node_Context_5);
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Gef1AKcqdEsQaHB2149cPN", 315238U);
            var Output_8 = n10.RenderView_NalvfCkTVBPN12jxpmho9b.Create(Node_Context: Node_Context_7);
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "VpwZHLVtPVvMh7vH4WyzN3", 315249U);
            var Output_10 = n31.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<n7.Vector4>.Create(Node_Context: Node_Context_9);
            n4.RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 that_11 = this;
            this.__slot_Ri3xmeug5NaLRWzqBe410l = false;
            this.__pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV = n23._Operations_.CreateDefault<n19.GpuValue<n7.Vector4>>();
            this.__pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL = n28._Operations_.CreateDefault<string, n19.AbstractGpuValue>();
            this.__p_BDUT8ELCQWQOLmxc2mrBtU = Output_1;
            this.__p_Sy4WD09V3c0Pa4KaMA3l1v = node_2;
            this.__p_MNb8POqy5JnMd2aMQ9eRnL = Output_4;
            this.__p_KwrR0U5x9JcMIE7fSwCvjE = Output_6;
            this.__p_Gef1AKcqdEsQaHB2149cPN = Output_8;
            this.__p_VpwZHLVtPVvMh7vH4WyzN3 = Output_10;
            return that_11;
        }

        public n4.RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 __CreateDefault__()
        {
            n4.RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 that_0 = this;
            this.__slot_Ri3xmeug5NaLRWzqBe410l = false;
            this.__pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV = n23._Operations_.CreateDefault<n19.GpuValue<n7.Vector4>>();
            this.__pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL = n28._Operations_.CreateDefault<string, n19.AbstractGpuValue>();
            this.__p_VpwZHLVtPVvMh7vH4WyzN3 = n31.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<n7.Vector4>.CreateDefault();
            this.__p_MNb8POqy5JnMd2aMQ9eRnL = n29.DrawShaderGraph_C.CreateDefault();
            this.__p_BDUT8ELCQWQOLmxc2mrBtU = n10.MeshRenderer_C.CreateDefault();
            this.__p_Sy4WD09V3c0Pa4KaMA3l1v = default(n1.IVLNode);
            this.__p_Gef1AKcqdEsQaHB2149cPN = n10.RenderView_NalvfCkTVBPN12jxpmho9b.CreateDefault();
            this.__p_KwrR0U5x9JcMIE7fSwCvjE = n30.RenderTexture_IYQobGzVbWEQYcMFud8H4J.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_VpwZHLVtPVvMh7vH4WyzN3);
            n1.CompilationHelper.SafeDispose(this.__p_MNb8POqy5JnMd2aMQ9eRnL);
            n1.CompilationHelper.SafeDispose(this.__p_BDUT8ELCQWQOLmxc2mrBtU);
            n1.CompilationHelper.SafeDispose(this.__p_Sy4WD09V3c0Pa4KaMA3l1v);
            n1.CompilationHelper.SafeDispose(this.__p_Gef1AKcqdEsQaHB2149cPN);
            n1.CompilationHelper.SafeDispose(this.__p_KwrR0U5x9JcMIE7fSwCvjE);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 315265U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Ri3xmeug5NaLRWzqBe410l", Name = "__slot_Ri3xmeug5NaLRWzqBe410l")]
        public bool __slot_Ri3xmeug5NaLRWzqBe410l;
        [n1.ElementAttribute(TracingId = 315276U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "LKG7CiUMwQLNG9RddzCE2e", Name = "__slot_LKG7CiUMwQLNG9RddzCE2e")]
        public static n18.PixelFormat __slot_LKG7CiUMwQLNG9RddzCE2e = n1.CompilationHelper.Deserialize<n18.PixelFormat>("None", false, "JPmuEharYwiLQs6dOuoEQQ", "LKG7CiUMwQLNG9RddzCE2e");
        [n1.ElementAttribute(TracingId = 315249U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "VpwZHLVtPVvMh7vH4WyzN3", Name = "SRGBToRGB", IsManaged = true, IsAutoGenerated = true)]
        public n31.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<n7.Vector4> __p_VpwZHLVtPVvMh7vH4WyzN3;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n19.GpuValue<n7.Vector4>> __pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV = default(n20.Spread<n19.GpuValue<n7.Vector4>>);
        [n1.ElementAttribute(TracingId = 315202U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "MNb8POqy5JnMd2aMQ9eRnL", Name = "DrawShaderGraph", IsManaged = true, IsAutoGenerated = true)]
        public n29.DrawShaderGraph_C __p_MNb8POqy5JnMd2aMQ9eRnL;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n24.ImmutableDictionary<string, n19.AbstractGpuValue> __pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL = default(n24.ImmutableDictionary<string, n19.AbstractGpuValue>);
        [n1.ElementAttribute(TracingId = 315168U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "BDUT8ELCQWQOLmxc2mrBtU", Name = "MeshRenderer", IsManaged = true, IsAutoGenerated = true)]
        public n10.MeshRenderer_C __p_BDUT8ELCQWQOLmxc2mrBtU;
        [n1.ElementAttribute(TracingId = 315187U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Sy4WD09V3c0Pa4KaMA3l1v", Name = "PlaneMesh", IsManaged = true, IsAutoGenerated = true, NodeName = "PlaneMesh", NodeCategory = "Stride.Models.Meshes")]
        public n1.IVLNode __p_Sy4WD09V3c0Pa4KaMA3l1v;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Vector2 __c_MINX0QEnUByNdzCepWHf1N = n1.CompilationHelper.Deserialize<n7.Vector2>("2, 2", false, "JPmuEharYwiLQs6dOuoEQQ", "MINX0QEnUByNdzCepWHf1N");
        [n1.ElementAttribute(TracingId = 315238U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Gef1AKcqdEsQaHB2149cPN", Name = "RenderView", IsManaged = true, IsAutoGenerated = true)]
        public n10.RenderView_NalvfCkTVBPN12jxpmho9b __p_Gef1AKcqdEsQaHB2149cPN;
        [n1.ElementAttribute(TracingId = 315219U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "KwrR0U5x9JcMIE7fSwCvjE", Name = "RenderTexture", IsManaged = true, IsAutoGenerated = true)]
        public n30.RenderTexture_IYQobGzVbWEQYcMFud8H4J __p_KwrR0U5x9JcMIE7fSwCvjE;
        static RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5()
        {
        }

        public RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5(RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 other): base(other)
        {
            this.__slot_Ri3xmeug5NaLRWzqBe410l = other.__slot_Ri3xmeug5NaLRWzqBe410l;
            this.__p_VpwZHLVtPVvMh7vH4WyzN3 = other.__p_VpwZHLVtPVvMh7vH4WyzN3;
            this.__pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV = other.__pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV;
            this.__p_MNb8POqy5JnMd2aMQ9eRnL = other.__p_MNb8POqy5JnMd2aMQ9eRnL;
            this.__pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL = other.__pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL;
            this.__p_BDUT8ELCQWQOLmxc2mrBtU = other.__p_BDUT8ELCQWQOLmxc2mrBtU;
            this.__p_Sy4WD09V3c0Pa4KaMA3l1v = other.__p_Sy4WD09V3c0Pa4KaMA3l1v;
            this.__p_Gef1AKcqdEsQaHB2149cPN = other.__p_Gef1AKcqdEsQaHB2149cPN;
            this.__p_KwrR0U5x9JcMIE7fSwCvjE = other.__p_KwrR0U5x9JcMIE7fSwCvjE;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Ri3xmeug5NaLRWzqBe410l", in __slot_Ri3xmeug5NaLRWzqBe410l), n1.CompilationHelper.GetValueOrExisting(values, "__p_VpwZHLVtPVvMh7vH4WyzN3", in __p_VpwZHLVtPVvMh7vH4WyzN3), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV", in __pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV), n1.CompilationHelper.GetValueOrExisting(values, "__p_MNb8POqy5JnMd2aMQ9eRnL", in __p_MNb8POqy5JnMd2aMQ9eRnL), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL", in __pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL), n1.CompilationHelper.GetValueOrExisting(values, "__p_BDUT8ELCQWQOLmxc2mrBtU", in __p_BDUT8ELCQWQOLmxc2mrBtU), n1.CompilationHelper.GetValueOrExisting(values, "__p_Sy4WD09V3c0Pa4KaMA3l1v", in __p_Sy4WD09V3c0Pa4KaMA3l1v), n1.CompilationHelper.GetValueOrExisting(values, "__p_Gef1AKcqdEsQaHB2149cPN", in __p_Gef1AKcqdEsQaHB2149cPN), n1.CompilationHelper.GetValueOrExisting(values, "__p_KwrR0U5x9JcMIE7fSwCvjE", in __p_KwrR0U5x9JcMIE7fSwCvjE));
        }

        internal RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 __WITH__(bool __slot_Ri3xmeug5NaLRWzqBe410l, n31.SRGBToRGB_ImvAPNRgqi4MyMa115cMZI<n7.Vector4> __p_VpwZHLVtPVvMh7vH4WyzN3, n20.Spread<n19.GpuValue<n7.Vector4>> __pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV, n29.DrawShaderGraph_C __p_MNb8POqy5JnMd2aMQ9eRnL, n24.ImmutableDictionary<string, n19.AbstractGpuValue> __pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL, n10.MeshRenderer_C __p_BDUT8ELCQWQOLmxc2mrBtU, n1.IVLNode __p_Sy4WD09V3c0Pa4KaMA3l1v, n10.RenderView_NalvfCkTVBPN12jxpmho9b __p_Gef1AKcqdEsQaHB2149cPN, n30.RenderTexture_IYQobGzVbWEQYcMFud8H4J __p_KwrR0U5x9JcMIE7fSwCvjE)
        {
            n4.RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_Ri3xmeug5NaLRWzqBe410l != this.__slot_Ri3xmeug5NaLRWzqBe410l || __p_VpwZHLVtPVvMh7vH4WyzN3 != this.__p_VpwZHLVtPVvMh7vH4WyzN3 || __pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV != this.__pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV || __p_MNb8POqy5JnMd2aMQ9eRnL != this.__p_MNb8POqy5JnMd2aMQ9eRnL || __pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL != this.__pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL || __p_BDUT8ELCQWQOLmxc2mrBtU != this.__p_BDUT8ELCQWQOLmxc2mrBtU || __p_Sy4WD09V3c0Pa4KaMA3l1v != this.__p_Sy4WD09V3c0Pa4KaMA3l1v || __p_Gef1AKcqdEsQaHB2149cPN != this.__p_Gef1AKcqdEsQaHB2149cPN || __p_KwrR0U5x9JcMIE7fSwCvjE != this.__p_KwrR0U5x9JcMIE7fSwCvjE ? new RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5(this)
                {__slot_Ri3xmeug5NaLRWzqBe410l = __slot_Ri3xmeug5NaLRWzqBe410l, __p_VpwZHLVtPVvMh7vH4WyzN3 = __p_VpwZHLVtPVvMh7vH4WyzN3, __pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV = __pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV, __p_MNb8POqy5JnMd2aMQ9eRnL = __p_MNb8POqy5JnMd2aMQ9eRnL, __pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL = __pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL, __p_BDUT8ELCQWQOLmxc2mrBtU = __p_BDUT8ELCQWQOLmxc2mrBtU, __p_Sy4WD09V3c0Pa4KaMA3l1v = __p_Sy4WD09V3c0Pa4KaMA3l1v, __p_Gef1AKcqdEsQaHB2149cPN = __p_Gef1AKcqdEsQaHB2149cPN, __p_KwrR0U5x9JcMIE7fSwCvjE = __p_KwrR0U5x9JcMIE7fSwCvjE} : that_0;
            else
            {
                this.__slot_Ri3xmeug5NaLRWzqBe410l = __slot_Ri3xmeug5NaLRWzqBe410l;
                this.__p_VpwZHLVtPVvMh7vH4WyzN3 = __p_VpwZHLVtPVvMh7vH4WyzN3;
                this.__pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV = __pin_group_Input_In_AbuJsbHbl1qLxdUmm4OJPV;
                this.__p_MNb8POqy5JnMd2aMQ9eRnL = __p_MNb8POqy5JnMd2aMQ9eRnL;
                this.__pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL = __pin_group_CustomStreams_In_MNb8POqy5JnMd2aMQ9eRnL;
                this.__p_BDUT8ELCQWQOLmxc2mrBtU = __p_BDUT8ELCQWQOLmxc2mrBtU;
                this.__p_Sy4WD09V3c0Pa4KaMA3l1v = __p_Sy4WD09V3c0Pa4KaMA3l1v;
                this.__p_Gef1AKcqdEsQaHB2149cPN = __p_Gef1AKcqdEsQaHB2149cPN;
                this.__p_KwrR0U5x9JcMIE7fSwCvjE = __p_KwrR0U5x9JcMIE7fSwCvjE;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 315350U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "NoEYE0i2bxTQKLGQadRdMn", Name = "TextureBasedDocumentation_NoEYE0i2bxTQKLGQadRdMn")]
    [n2.SerializableAttribute]
    public class TextureBasedDocumentation_NoEYE0i2bxTQKLGQadRdMn : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.TextureBasedDocumentation_NoEYE0i2bxTQKLGQadRdMn Create(n1.NodeContext Node_Context)
        {
            var instance = new TextureBasedDocumentation_NoEYE0i2bxTQKLGQadRdMn(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.TextureBasedDocumentation_NoEYE0i2bxTQKLGQadRdMn CreateDefault()
        {
            var instance = new TextureBasedDocumentation_NoEYE0i2bxTQKLGQadRdMn(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.TextureBasedDocumentation_NoEYE0i2bxTQKLGQadRdMn Update()
        {
            return this;
        }

        public n4.TextureBasedDocumentation_NoEYE0i2bxTQKLGQadRdMn __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n4.TextureBasedDocumentation_NoEYE0i2bxTQKLGQadRdMn __CreateDefault__()
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

        public TextureBasedDocumentation_NoEYE0i2bxTQKLGQadRdMn(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TextureBasedDocumentation_NoEYE0i2bxTQKLGQadRdMn(TextureBasedDocumentation_NoEYE0i2bxTQKLGQadRdMn other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal TextureBasedDocumentation_NoEYE0i2bxTQKLGQadRdMn __WITH__()
        {
            return this;
        }
    }

    [n1.ElementAttribute(TracingId = 315364U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Ggxbkm4rZ5mNYKSy4h9z8H", Name = "HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H")]
    [n2.SerializableAttribute]
    public class HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H Create(n1.NodeContext Node_Context)
        {
            var instance = new HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H CreateDefault()
        {
            var instance = new HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H Update(n19.GpuValue<n7.Vector4> Input_In, bool Convert_SRGB_to_RGB_In)
        {
            n7.Int2 __pad_TD2ro7IuvmqMfbvUBo6toj_0 = __slot_TD2ro7IuvmqMfbvUBo6toj;
            string __pad_BQoclI0YOaEPZvRc927seo_1 = __slot_BQoclI0YOaEPZvRc927seo;
            n18.PixelFormat Format_2 = __c_Rk0gld3dItTLdmaB4lRfp3;
            bool Clear_3 = true;
            n7.Color4 Clear_Color_4 = __c_MZk0RzctorJPRDCBR5SkoT;
            var Output_8 = this.__p_ISBV3ZueC2ePuC9ownpJ7o.Update(Input_In: Input_In, Size_In: __pad_TD2ro7IuvmqMfbvUBo6toj_0, Format_In: Format_2, Clear_In: Clear_3, Clear_Color_In: Clear_Color_4, Convert_SRGB_to_RGB_In: Convert_SRGB_to_RGB_In, Texture_Out: out n3.Texture Texture_5, lastError_Out: out string lastError_6, Shader_Code_Out: out string Shader_Code_7);
            var Alpha_Blend_9 = n26.BlendStateDescriptions.AlphaBlend;
            n7.Matrix Transformation_10 = n27._Operations_.CreateDefault();
            n32.DeclSampler Sampler_11 = default(n32.DeclSampler);
            n32.SampleMode Sample_Mode_12 = default(n32.SampleMode);
            n7.Color4 Color_13 = n33._Operations_.CreateDefault();
            n3.RasterizerStateDescription Rasterizer_State_14 = n34._Operations_.CreateDefault_H();
            n3.DepthStencilStateDescription Depth_Stencil_State_15 = n35._Operations_.CreateDefault_H();
            var State_Output_17 = this.__p_Dyy0Xeu0gfKNCQcerY4GeZ.Update(Transformation_In: Transformation_10, Texture_In: Texture_5, Sampler_In: Sampler_11, Sample_Mode_In: Sample_Mode_12, Blend_State_In: Alpha_Blend_9, Color_In: Color_13, Rasterizer_State_In: Rasterizer_State_14, Depth_Stencil_State_In: Depth_Stencil_State_15, Output_Out: out n10.MeshRenderer_C Output_16);
            n9.IGraphicsRendererBase Input_18 = (n9.IGraphicsRendererBase)Output_16;
            n6.DrawerRenderStage Render_Stage_19 = __c_MRKyMiDwZBwOPQ9Nk1hrg8;
            bool Single_Call_Per_Frame_20 = false;
            bool SetupRendering_21 = true;
            var Output_22 = this.__p_PmCjT1Xat3IMuXHPwjOFWN;
            if (SetupRendering_21)
            {
                Output_22 = this.__p_PmCjT1Xat3IMuXHPwjOFWN.SetupRendering(Input_In: Input_18, Render_Stage_In: Render_Stage_19, Single_Call_Per_Frame_In: Single_Call_Per_Frame_20);
            }

            var State_Output_24 = Output_22.Update(Output_Out: out n16.Entity Output_23);
            n16.Entity Child_25 = default(n16.Entity);
            n16.Entity Child_3_26 = default(n16.Entity);
            n16.Entity Child_4_27 = default(n16.Entity);
            n16.Entity Child_5_28 = default(n16.Entity);
            n20.Spread<n16.Scene> Child_Scenes_29 = n23._Operations_.CreateDefault<n16.Scene>();
            bool Enabled_30 = true;
            var builder_31 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh, 5);
            builder_31.Add(Child_25);
            builder_31.Add(Output_23);
            builder_31.Add(Child_3_26);
            builder_31.Add(Child_4_27);
            builder_31.Add(Child_5_28);
            var __pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh_32 = builder_31.Commit();
            var State_Output_34 = this.__p_MFmyjCbOVFCNbaYuuIbhQh.Update(Child_In: __pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh_32, Child_Scenes_In: Child_Scenes_29, Enabled_In: Enabled_30, Output_Out: out n16.SceneInstance Output_33);
            n16.Entity Camera_35 = default(n16.Entity);
            bool Enable_Default_Camera_36 = true;
            n7.Color4 Clear_Color_37 = __c_AebnEAiAoxoM5F3KqApGOz;
            bool Clear_38 = true;
            n36.IPostProcessingEffects Post_Effects_39 = default(n36.IPostProcessingEffects);
            bool Enable_Default_Post_Effects_40 = false;
            n9.RenderGroupMask Render_Group_Mask_41 = n1.CompilationHelper.Deserialize<n9.RenderGroupMask>("All", false, null, null);
            bool Enable_Keyboard_Shortcuts_42 = true;
            string Model_Effect_Name_43 = "VLEffectMain";
            n20.Spread<n37.IAdditionalSceneRenderer_I> Additional_Scene_Renderers_44 = n23._Operations_.CreateDefault<n37.IAdditionalSceneRenderer_I>();
            bool Enabled_45 = true;
            var State_Output_47 = this.__p_SWOBLIkPgLTQIZFHjJCmON.Update(Input_In: Output_33, Camera_In: Camera_35, Enable_Default_Camera_In: Enable_Default_Camera_36, Title_In: __pad_BQoclI0YOaEPZvRc927seo_1, Clear_Color_In: Clear_Color_37, Clear_In: Clear_38, Post_Effects_In: Post_Effects_39, Enable_Default_Post_Effects_In: Enable_Default_Post_Effects_40, Render_Group_Mask_In: Render_Group_Mask_41, Enable_Keyboard_Shortcuts_In: Enable_Keyboard_Shortcuts_42, Model_Effect_Name_In: Model_Effect_Name_43, Additional_Scene_Renderers_In: Additional_Scene_Renderers_44, Enabled_In: Enabled_45, Output_Out: out n38.GameWindow Output_46);
            n4.HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H that_48 = this;
            if (this.__GetContext__().IsImmutable)
                that_48 = Output_8 != this.__p_ISBV3ZueC2ePuC9ownpJ7o || State_Output_17 != this.__p_Dyy0Xeu0gfKNCQcerY4GeZ || State_Output_24 != this.__p_PmCjT1Xat3IMuXHPwjOFWN || __pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh_32 != this.__pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh || State_Output_34 != this.__p_MFmyjCbOVFCNbaYuuIbhQh || State_Output_47 != this.__p_SWOBLIkPgLTQIZFHjJCmON ? new HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H(this)
                {__p_ISBV3ZueC2ePuC9ownpJ7o = Output_8, __p_Dyy0Xeu0gfKNCQcerY4GeZ = State_Output_17, __p_PmCjT1Xat3IMuXHPwjOFWN = State_Output_24, __pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh = __pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh_32, __p_MFmyjCbOVFCNbaYuuIbhQh = State_Output_34, __p_SWOBLIkPgLTQIZFHjJCmON = State_Output_47} : that_48;
            else
            {
                this.__p_ISBV3ZueC2ePuC9ownpJ7o = Output_8;
                this.__p_Dyy0Xeu0gfKNCQcerY4GeZ = State_Output_17;
                this.__p_PmCjT1Xat3IMuXHPwjOFWN = State_Output_24;
                this.__pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh = __pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh_32;
                this.__p_MFmyjCbOVFCNbaYuuIbhQh = State_Output_34;
                this.__p_SWOBLIkPgLTQIZFHjJCmON = State_Output_47;
            }

            return that_48;
        }

        public n4.HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "MFmyjCbOVFCNbaYuuIbhQh", 315367U);
            var Output_1 = n30.RootScene_GcBzJdp7uHFN7DqiDqkHlb.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "SWOBLIkPgLTQIZFHjJCmON", 315380U);
            n7.RectangleF Bounds_3 = __c_Ub5jtMQlJhNNn83h5mLjK7;
            bool Bound_to_Document_4 = true;
            bool Dialog_If_Document_Changed_5 = false;
            bool Save_Bounds_6 = true;
            n18.PixelFormat Back_Buffer_Format_7 = n1.CompilationHelper.Deserialize<n18.PixelFormat>("R8G8B8A8_UNorm_SRgb", false, null, null);
            n18.PixelFormat Depth_Buffer_Format_8 = n1.CompilationHelper.Deserialize<n18.PixelFormat>("D24_UNorm_S8_UInt", false, null, null);
            var Output_9 = n30.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k.Create(Node_Context: Node_Context_2, Bounds_In: Bounds_3, Bound_to_Document_In: Bound_to_Document_4, Dialog_If_Document_Changed_In: Dialog_If_Document_Changed_5, Save_Bounds_In: Save_Bounds_6, Back_Buffer_Format_In: Back_Buffer_Format_7, Depth_Buffer_Format_In: Depth_Buffer_Format_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "PmCjT1Xat3IMuXHPwjOFWN", 315415U);
            var Output_11 = n37.RenderEntity_HYRtmvUkSb6PheJUi3kp3r.Create(Node_Context: Node_Context_10);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "ISBV3ZueC2ePuC9ownpJ7o", 315434U);
            var Output_13 = n4.RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5.Create(Node_Context: Node_Context_12);
            n1.NodeContext Node_Context_14 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Dyy0Xeu0gfKNCQcerY4GeZ", 315455U);
            var Output_15 = n39.FullscreenQuadRenderer_BhJSftTYy1YMqMFg7MasQE.Create(Node_Context: Node_Context_14);
            n4.HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H that_16 = this;
            this.__pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh = n23._Operations_.CreateDefault<n16.Entity>();
            this.__p_MFmyjCbOVFCNbaYuuIbhQh = Output_1;
            this.__p_SWOBLIkPgLTQIZFHjJCmON = Output_9;
            this.__p_PmCjT1Xat3IMuXHPwjOFWN = Output_11;
            this.__p_ISBV3ZueC2ePuC9ownpJ7o = Output_13;
            this.__p_Dyy0Xeu0gfKNCQcerY4GeZ = Output_15;
            return that_16;
        }

        public n4.HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H __CreateDefault__()
        {
            n4.HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H that_0 = this;
            this.__pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh = n23._Operations_.CreateDefault<n16.Entity>();
            this.__p_ISBV3ZueC2ePuC9ownpJ7o = n4.RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5.CreateDefault();
            this.__p_Dyy0Xeu0gfKNCQcerY4GeZ = n39.FullscreenQuadRenderer_BhJSftTYy1YMqMFg7MasQE.CreateDefault();
            this.__p_PmCjT1Xat3IMuXHPwjOFWN = n37.RenderEntity_HYRtmvUkSb6PheJUi3kp3r.CreateDefault();
            this.__p_MFmyjCbOVFCNbaYuuIbhQh = n30.RootScene_GcBzJdp7uHFN7DqiDqkHlb.CreateDefault();
            this.__p_SWOBLIkPgLTQIZFHjJCmON = n30.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_ISBV3ZueC2ePuC9ownpJ7o);
            n1.CompilationHelper.SafeDispose(this.__p_Dyy0Xeu0gfKNCQcerY4GeZ);
            n1.CompilationHelper.SafeDispose(this.__p_PmCjT1Xat3IMuXHPwjOFWN);
            n1.CompilationHelper.SafeDispose(this.__p_MFmyjCbOVFCNbaYuuIbhQh);
            n1.CompilationHelper.SafeDispose(this.__p_SWOBLIkPgLTQIZFHjJCmON);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 315475U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "TD2ro7IuvmqMfbvUBo6toj", Name = "__slot_TD2ro7IuvmqMfbvUBo6toj")]
        public static n7.Int2 __slot_TD2ro7IuvmqMfbvUBo6toj = n1.CompilationHelper.Deserialize<n7.Int2>("1024, 1024", false, "JPmuEharYwiLQs6dOuoEQQ", "TD2ro7IuvmqMfbvUBo6toj");
        [n1.ElementAttribute(TracingId = 315490U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "BQoclI0YOaEPZvRc927seo", Name = "__slot_BQoclI0YOaEPZvRc927seo")]
        public static string __slot_BQoclI0YOaEPZvRc927seo = "FUSE Help";
        [n1.ElementAttribute(TracingId = 315434U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "ISBV3ZueC2ePuC9ownpJ7o", Name = "RenderTexture (Fuse)", IsManaged = true, IsAutoGenerated = true)]
        public n4.RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 __p_ISBV3ZueC2ePuC9ownpJ7o;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n18.PixelFormat __c_Rk0gld3dItTLdmaB4lRfp3 = n1.CompilationHelper.Deserialize<n18.PixelFormat>("R16G16B16A16_Float", false, "JPmuEharYwiLQs6dOuoEQQ", "Rk0gld3dItTLdmaB4lRfp3");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_MZk0RzctorJPRDCBR5SkoT = n1.CompilationHelper.Deserialize<n7.Color4>("0, 0, 0, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "MZk0RzctorJPRDCBR5SkoT");
        [n1.ElementAttribute(TracingId = 315455U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Dyy0Xeu0gfKNCQcerY4GeZ", Name = "FullscreenQuadRenderer", IsManaged = true, IsAutoGenerated = true)]
        public n39.FullscreenQuadRenderer_BhJSftTYy1YMqMFg7MasQE __p_Dyy0Xeu0gfKNCQcerY4GeZ;
        [n1.ElementAttribute(TracingId = 315415U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "PmCjT1Xat3IMuXHPwjOFWN", Name = "RenderEntity", IsManaged = true, IsAutoGenerated = true)]
        public n37.RenderEntity_HYRtmvUkSb6PheJUi3kp3r __p_PmCjT1Xat3IMuXHPwjOFWN;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.DrawerRenderStage __c_MRKyMiDwZBwOPQ9Nk1hrg8 = n1.CompilationHelper.Deserialize<n6.DrawerRenderStage>("Transparent", false, "JPmuEharYwiLQs6dOuoEQQ", "MRKyMiDwZBwOPQ9Nk1hrg8");
        [n1.ElementAttribute(TracingId = 315367U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "MFmyjCbOVFCNbaYuuIbhQh", Name = "RootScene", IsManaged = true, IsAutoGenerated = true)]
        public n30.RootScene_GcBzJdp7uHFN7DqiDqkHlb __p_MFmyjCbOVFCNbaYuuIbhQh;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.Entity> __pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh = default(n20.Spread<n16.Entity>);
        [n1.ElementAttribute(TracingId = 315380U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "SWOBLIkPgLTQIZFHjJCmON", Name = "SceneWindow", IsManaged = true, IsAutoGenerated = true)]
        public n30.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k __p_SWOBLIkPgLTQIZFHjJCmON;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_AebnEAiAoxoM5F3KqApGOz = n1.CompilationHelper.Deserialize<n7.Color4>("0.09529408, 0.09529408, 0.09529408, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "AebnEAiAoxoM5F3KqApGOz");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.RectangleF __c_Ub5jtMQlJhNNn83h5mLjK7 = n1.CompilationHelper.Deserialize<n7.RectangleF>("1243.2, 112.8, 624, 608", false, "JPmuEharYwiLQs6dOuoEQQ", "Ub5jtMQlJhNNn83h5mLjK7");
        static HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H()
        {
        }

        public HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H(HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H other): base(other)
        {
            this.__p_ISBV3ZueC2ePuC9ownpJ7o = other.__p_ISBV3ZueC2ePuC9ownpJ7o;
            this.__p_Dyy0Xeu0gfKNCQcerY4GeZ = other.__p_Dyy0Xeu0gfKNCQcerY4GeZ;
            this.__p_PmCjT1Xat3IMuXHPwjOFWN = other.__p_PmCjT1Xat3IMuXHPwjOFWN;
            this.__p_MFmyjCbOVFCNbaYuuIbhQh = other.__p_MFmyjCbOVFCNbaYuuIbhQh;
            this.__pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh = other.__pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh;
            this.__p_SWOBLIkPgLTQIZFHjJCmON = other.__p_SWOBLIkPgLTQIZFHjJCmON;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_ISBV3ZueC2ePuC9ownpJ7o", in __p_ISBV3ZueC2ePuC9ownpJ7o), n1.CompilationHelper.GetValueOrExisting(values, "__p_Dyy0Xeu0gfKNCQcerY4GeZ", in __p_Dyy0Xeu0gfKNCQcerY4GeZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_PmCjT1Xat3IMuXHPwjOFWN", in __p_PmCjT1Xat3IMuXHPwjOFWN), n1.CompilationHelper.GetValueOrExisting(values, "__p_MFmyjCbOVFCNbaYuuIbhQh", in __p_MFmyjCbOVFCNbaYuuIbhQh), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh", in __pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh), n1.CompilationHelper.GetValueOrExisting(values, "__p_SWOBLIkPgLTQIZFHjJCmON", in __p_SWOBLIkPgLTQIZFHjJCmON));
        }

        internal HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H __WITH__(n4.RenderTexture_Fuse_C6uIqzI5uPRMM3sQmst2S5 __p_ISBV3ZueC2ePuC9ownpJ7o, n39.FullscreenQuadRenderer_BhJSftTYy1YMqMFg7MasQE __p_Dyy0Xeu0gfKNCQcerY4GeZ, n37.RenderEntity_HYRtmvUkSb6PheJUi3kp3r __p_PmCjT1Xat3IMuXHPwjOFWN, n30.RootScene_GcBzJdp7uHFN7DqiDqkHlb __p_MFmyjCbOVFCNbaYuuIbhQh, n20.Spread<n16.Entity> __pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh, n30.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k __p_SWOBLIkPgLTQIZFHjJCmON)
        {
            n4.HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_ISBV3ZueC2ePuC9ownpJ7o != this.__p_ISBV3ZueC2ePuC9ownpJ7o || __p_Dyy0Xeu0gfKNCQcerY4GeZ != this.__p_Dyy0Xeu0gfKNCQcerY4GeZ || __p_PmCjT1Xat3IMuXHPwjOFWN != this.__p_PmCjT1Xat3IMuXHPwjOFWN || __p_MFmyjCbOVFCNbaYuuIbhQh != this.__p_MFmyjCbOVFCNbaYuuIbhQh || __pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh != this.__pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh || __p_SWOBLIkPgLTQIZFHjJCmON != this.__p_SWOBLIkPgLTQIZFHjJCmON ? new HelpWindow_Texture_Ggxbkm4rZ5mNYKSy4h9z8H(this)
                {__p_ISBV3ZueC2ePuC9ownpJ7o = __p_ISBV3ZueC2ePuC9ownpJ7o, __p_Dyy0Xeu0gfKNCQcerY4GeZ = __p_Dyy0Xeu0gfKNCQcerY4GeZ, __p_PmCjT1Xat3IMuXHPwjOFWN = __p_PmCjT1Xat3IMuXHPwjOFWN, __p_MFmyjCbOVFCNbaYuuIbhQh = __p_MFmyjCbOVFCNbaYuuIbhQh, __pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh = __pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh, __p_SWOBLIkPgLTQIZFHjJCmON = __p_SWOBLIkPgLTQIZFHjJCmON} : that_0;
            else
            {
                this.__p_ISBV3ZueC2ePuC9ownpJ7o = __p_ISBV3ZueC2ePuC9ownpJ7o;
                this.__p_Dyy0Xeu0gfKNCQcerY4GeZ = __p_Dyy0Xeu0gfKNCQcerY4GeZ;
                this.__p_PmCjT1Xat3IMuXHPwjOFWN = __p_PmCjT1Xat3IMuXHPwjOFWN;
                this.__p_MFmyjCbOVFCNbaYuuIbhQh = __p_MFmyjCbOVFCNbaYuuIbhQh;
                this.__pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh = __pin_group_Child_In_MFmyjCbOVFCNbaYuuIbhQh;
                this.__p_SWOBLIkPgLTQIZFHjJCmON = __p_SWOBLIkPgLTQIZFHjJCmON;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 315547U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Iu0D0SDDMseNZZodQPhpqH", Name = "LightStudios_Iu0D0SDDMseNZZodQPhpqH")]
    [n2.SerializableAttribute]
    public class LightStudios_Iu0D0SDDMseNZZodQPhpqH : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.LightStudios_Iu0D0SDDMseNZZodQPhpqH Create(n1.NodeContext Node_Context)
        {
            var instance = new LightStudios_Iu0D0SDDMseNZZodQPhpqH(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.LightStudios_Iu0D0SDDMseNZZodQPhpqH CreateDefault()
        {
            var instance = new LightStudios_Iu0D0SDDMseNZZodQPhpqH(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.LightStudios_Iu0D0SDDMseNZZodQPhpqH Update([n5.SerializedDefaultValueAttribute("True", false)] bool PostFX_Enabled_In, [n5.SerializedDefaultValueAttribute("True", false)] bool DoF_Enabled_In, [n5.SerializedDefaultValueAttribute("False", false)] bool Auto_Focus_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Show_Guide_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Stage_Enabled_In, [n5.SerializedDefaultValueAttribute("4", false)] int LightPreset_In, bool Background_Enabled_In, out n16.Entity Lights_Out, out n36.PostProcessingEffects PostFX_Out, out n36.LightShafts LightShafts_Out)
        {
            n7.Vector3 __pad_Vu5FjpkSalUOyyXNoe0aCa_0 = __slot_Vu5FjpkSalUOyyXNoe0aCa;
            n40.Path __pad_JhwqVgRchaHPqkanMBqnTa_1 = __slot_JhwqVgRchaHPqkanMBqnTa;
            bool __auto_2 = this.Background_Enabled;
            n7.Vector3 __pad_I43q45FJUEZOBjWlyFoN9U_3 = __slot_I43q45FJUEZOBjWlyFoN9U;
            n41.LightShadowMapFilterTypePcfSize __pad_Kk95YrDeFLpNRnPQEf1vlw_4 = __slot_Kk95YrDeFLpNRnPQEf1vlw;
            n7.Color4 __pad_MlmYhDPKG8hOivPtXnbFcG_5 = __slot_MlmYhDPKG8hOivPtXnbFcG;
            n7.Vector3 __pad_QBpQ3JKmf8sMCpnXsJpc5r_6 = __slot_QBpQ3JKmf8sMCpnXsJpc5r;
            float __pad_VOFcKF62HiYMfI6k58M0Rt_7 = __slot_VOFcKF62HiYMfI6k58M0Rt;
            n7.Vector3 __pad_JKbM66PcDIBM3wpX7uz4iI_8 = __slot_JKbM66PcDIBM3wpX7uz4iI;
            n7.Vector3 __pad_SmV5mvCrccjPOsKV3o6SiO_9 = __slot_SmV5mvCrccjPOsKV3o6SiO;
            n40.Path __pad_VAmFBkFaVZjOxJev7GS1YZ_10 = __slot_VAmFBkFaVZjOxJev7GS1YZ;
            bool __auto_11 = this.Background_Enabled;
            n7.Color4 __pad_KJQf5gCDTFFLjvz9NELHkn_12 = __slot_KJQf5gCDTFFLjvz9NELHkn;
            float __pad_BADeqRYzlm8M2eFDJmyjqK_13 = __slot_BADeqRYzlm8M2eFDJmyjqK;
            float __pad_PVjXdUocZIPLwwKq2Gr4Um_14 = __slot_PVjXdUocZIPLwwKq2Gr4Um;
            n7.Vector3 __pad_Mtt6R0xrquEMVq7yoq4aGF_15 = __slot_Mtt6R0xrquEMVq7yoq4aGF;
            n40.Path __pad_SEycS7fVjWFLq9BXC5xDkI_16 = __slot_SEycS7fVjWFLq9BXC5xDkI;
            bool __auto_17 = this.Background_Enabled;
            n7.Vector3 __pad_TnlI0YTrV2EM6FVdRvBwG9_18 = __slot_TnlI0YTrV2EM6FVdRvBwG9;
            n7.Vector3 __pad_RW9OYBO3IM8Lg2QTIABaER_19 = __slot_RW9OYBO3IM8Lg2QTIABaER;
            float __pad_V30CePQwKYwNHr09PY39Mt_20 = __slot_V30CePQwKYwNHr09PY39Mt;
            float __pad_ATw1UY2NJn9NpaRW2jUZlv_21 = __slot_ATw1UY2NJn9NpaRW2jUZlv;
            float __pad_UE4AUm23ZMWLINVBXNGXtb_22 = __slot_UE4AUm23ZMWLINVBXNGXtb;
            n7.Vector3 __pad_SodEdCVcG80NjIGqjqavha_23 = __slot_SodEdCVcG80NjIGqjqavha;
            n7.Color4 __pad_NTVOzt1zxsAMRuUcT4rQ3a_24 = __slot_NTVOzt1zxsAMRuUcT4rQ3a;
            n7.Matrix __auto_25 = this.BBox;
            float __pad_G18HNH7XPdmPHbpzZo6y0L_26 = __slot_G18HNH7XPdmPHbpzZo6y0L;
            int __pad_PIZ0wY9DkpVPY1vc9LsaUp_27 = __slot_PIZ0wY9DkpVPY1vc9LsaUp;
            bool __pad_GmIIGuL7uILMzUP6C1684w_28 = __slot_GmIIGuL7uILMzUP6C1684w;
            bool __pad_A5fMJXXXq30QRD492gR3qN_29 = __slot_A5fMJXXXq30QRD492gR3qN;
            float __pad_FNJLkBC7otfQK2nRhlOH46_30 = __slot_FNJLkBC7otfQK2nRhlOH46;
            n7.Vector3 __pad_R5UHxOeaDRQLpsCcJyrYk6_31 = __slot_R5UHxOeaDRQLpsCcJyrYk6;
            n7.Vector3 __pad_NToWGCWgDrxNdGY7Lfi7FG_32 = __slot_NToWGCWgDrxNdGY7Lfi7FG;
            n7.Vector3 __pad_Nrni0XgJZU4Nc0JC61JDan_33 = __slot_Nrni0XgJZU4Nc0JC61JDan;
            n7.Vector3 __pad_It50TDAwo89OaAaf3cyhmb_34 = __slot_It50TDAwo89OaAaf3cyhmb;
            n40.Path __pad_IL3Ga2zLUeYMUEephXKehK_35 = __slot_IL3Ga2zLUeYMUEephXKehK;
            bool __auto_36 = this.Background_Enabled;
            n7.Vector3 __pad_MSeyhzx7RQILXPHxKrXPs6_37 = __slot_MSeyhzx7RQILXPHxKrXPs6;
            n7.Vector3 __pad_MHGItF376AtN0AneZTHhj2_38 = __slot_MHGItF376AtN0AneZTHhj2;
            n7.Vector3 __pad_UHvwNPRwngAMSyw84GpTxo_39 = __slot_UHvwNPRwngAMSyw84GpTxo;
            n40.Path __pad_RABYUZiAQEROHCSHlyJGtO_40 = __slot_RABYUZiAQEROHCSHlyJGtO;
            float __pad_SuO3USX97nbOZkyAnpraqe_41 = __slot_SuO3USX97nbOZkyAnpraqe;
            bool __auto_42 = this.Background_Enabled;
            int __pad_HSRNTIJGdVjLXpjTJRqoPx_43 = __slot_HSRNTIJGdVjLXpjTJRqoPx;
            int __pad_DoGOVLnoGRHLuACY7NwcYq_44 = __slot_DoGOVLnoGRHLuACY7NwcYq;
            n41.LightShadowMapFilterTypePcfSize __pad_CCi5gx1CJ32OPXIUCYRlXm_45 = __slot_CCi5gx1CJ32OPXIUCYRlXm;
            n7.Vector3 __pad_O3g4b8EfxUjOr4bjVwWxsM_46 = __slot_O3g4b8EfxUjOr4bjVwWxsM;
            bool __auto_47 = this.Background_Enabled;
            n41.LightShadowMapFilterTypePcfSize __pad_Ctd9iNx7yxMOYG6vUFzjdD_48 = __slot_Ctd9iNx7yxMOYG6vUFzjdD;
            bool __pad_PHtPr62IPUNLhYzHWZVWON_49 = PostFX_Enabled_In;
            n1.CompilationHelper.ReadPin(this.__p_POI2G3HeNMPObLndUPeL1H.Outputs[0], out n36.ToneMapHejl2Operator out_50);
            n36.PostProcessingEffects __auto_51;
            var state_52 = n1.CompilationHelper.Restore<__I30iaMzRRy4LNTxqhhvoVu>(this.__if_Dxra1WEwF1hLxNGfl2D8lt, __GetContext__());
            if (__pad_PHtPr62IPUNLhYzHWZVWON_49)
            {
                if (state_52 == null)
                {
                    state_52 = new __I30iaMzRRy4LNTxqhhvoVu(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI = n23._Operations_.CreateDefault<n36.ColorTransform>()};
                    n1.NodeContext Node_Context_53 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "FLlTfOrpicKP5Vw6UpZWEG", 315977U);
                    var Output_54 = n37.PostFX_C.Create(Node_Context: Node_Context_53);
                    state_52.__p_FLlTfOrpicKP5Vw6UpZWEG = Output_54;
                    var node_55 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "AmbientOcclusion", "Stride.Rendering.PostFX");
                    state_52.__p_PYhtkVIxBSRNfTZ41JFxQm = node_55;
                    var node_56 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "BrightFilter", "Stride.Rendering.PostFX");
                    state_52.__p_OZZRXF2oGSbNkdyx0cJDgs = node_56;
                    var node_57 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Bloom", "Stride.Rendering.PostFX");
                    state_52.__p_KhDhTGBxXYMNy4TUBnA7Y1 = node_57;
                    var node_58 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "DepthOfField", "Stride.Rendering.PostFX");
                    state_52.__p_M7GGPysJb1UPMbjG14NvwK = node_58;
                    var node_59 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "LightStreak", "Stride.Rendering.PostFX");
                    state_52.__p_V3eaLbPDXoLNN8p88OjuDF = node_59;
                    var node_60 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "LensFlare", "Stride.Rendering.PostFX");
                    state_52.__p_CnCFB7G36eZO6rhgt8ccAc = node_60;
                    var node_61 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "FXAAEffect", "Stride.Rendering.PostFX");
                    state_52.__p_F3cAGZxJ2NoMJ6ytBaA3RH = node_61;
                    var node_62 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "ToneMap", "Stride.Rendering.PostFX.ColorTransforms");
                    state_52.__p_HVF3nI6EZREOKWG7zQCEtL = node_62;
                    var node_63 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "Vignetting", "Stride.Rendering.PostFX.ColorTransforms");
                    state_52.__p_BkzEreSiWkoNgdbDWGOJ6b = node_63;
                    var node_64 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "FilmGrain", "Stride.Rendering.PostFX.ColorTransforms");
                    state_52.__p_UGm6M1ifjE0LGowzDRvvZ6 = node_64;
                    var node_65 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "U2Filmic", "Stride.Rendering.PostFX.ColorTransforms.ToneMapOperators");
                    state_52.__p_EnCvbImiDHANtpydvwVr4v = node_65;
                }

                float __pad_H2xDJZL4VzINangNmx1UJG_66 = __slot_H2xDJZL4VzINangNmx1UJG;
                n7.Vector4 __pad_TSNgDflJz38MGIlCOaT9py_67 = __slot_TSNgDflJz38MGIlCOaT9py;
                bool __pad_KpDA2ori8VpMDO7Rdfm2Uu_68 = __slot_KpDA2ori8VpMDO7Rdfm2Uu;
                float Projection_Scale_69 = 0.666F;
                n1.CompilationHelper.WritePin(state_52.__p_PYhtkVIxBSRNfTZ41JFxQm.Inputs[1], ref Projection_Scale_69);
                float Sample_Bias_70 = 0.01F;
                n1.CompilationHelper.WritePin(state_52.__p_PYhtkVIxBSRNfTZ41JFxQm.Inputs[3], ref Sample_Bias_70);
                bool Enabled_71 = true;
                n1.CompilationHelper.WritePin(state_52.__p_PYhtkVIxBSRNfTZ41JFxQm.Inputs[9], ref Enabled_71);
                n1.CompilationHelper.ReadPin(state_52.__p_PYhtkVIxBSRNfTZ41JFxQm.Outputs[0], out n36.AmbientOcclusion out_72);
                bool SetAmbientOcclusion_73 = true;
                var Output_74 = state_52.__p_FLlTfOrpicKP5Vw6UpZWEG;
                if (SetAmbientOcclusion_73)
                {
                    Output_74 = state_52.__p_FLlTfOrpicKP5Vw6UpZWEG.SetAmbientOcclusion(Ambient_Occlusion_In: out_72);
                }

                n1.CompilationHelper.WritePin(state_52.__p_M7GGPysJb1UPMbjG14NvwK.Inputs[0], ref __pad_H2xDJZL4VzINangNmx1UJG_66);
                n1.CompilationHelper.WritePin(state_52.__p_M7GGPysJb1UPMbjG14NvwK.Inputs[1], ref __pad_TSNgDflJz38MGIlCOaT9py_67);
                float Quality_Preset_75 = 0.5F;
                n1.CompilationHelper.WritePin(state_52.__p_M7GGPysJb1UPMbjG14NvwK.Inputs[2], ref Quality_Preset_75);
                n1.CompilationHelper.WritePin(state_52.__p_M7GGPysJb1UPMbjG14NvwK.Inputs[4], ref Auto_Focus_In);
                n1.CompilationHelper.WritePin(state_52.__p_M7GGPysJb1UPMbjG14NvwK.Inputs[5], ref DoF_Enabled_In);
                n1.CompilationHelper.ReadPin(state_52.__p_M7GGPysJb1UPMbjG14NvwK.Outputs[0], out n36.DepthOfField out_76);
                bool SetDepthOfField_77 = true;
                var Output_78 = Output_74;
                if (SetDepthOfField_77)
                {
                    Output_78 = Output_74.SetDepthOfField(Depth_Of_Field_In: out_76);
                }

                float Threshold_79 = 0.5F;
                n1.CompilationHelper.WritePin(state_52.__p_OZZRXF2oGSbNkdyx0cJDgs.Inputs[0], ref Threshold_79);
                float Steepness_80 = 0.53F;
                n1.CompilationHelper.WritePin(state_52.__p_OZZRXF2oGSbNkdyx0cJDgs.Inputs[1], ref Steepness_80);
                bool Enabled_81 = true;
                n1.CompilationHelper.WritePin(state_52.__p_OZZRXF2oGSbNkdyx0cJDgs.Inputs[3], ref Enabled_81);
                n1.CompilationHelper.ReadPin(state_52.__p_OZZRXF2oGSbNkdyx0cJDgs.Outputs[0], out n36.BrightFilter out_82);
                bool SetBrightFilter_83 = true;
                var Output_84 = Output_78;
                if (SetBrightFilter_83)
                {
                    Output_84 = Output_78.SetBrightFilter(Bright_Filter_In: out_82);
                }

                bool Expanded_Filtering_85 = true;
                n1.CompilationHelper.WritePin(state_52.__p_KhDhTGBxXYMNy4TUBnA7Y1.Inputs[5], ref Expanded_Filtering_85);
                bool Enabled_86 = true;
                n1.CompilationHelper.WritePin(state_52.__p_KhDhTGBxXYMNy4TUBnA7Y1.Inputs[6], ref Enabled_86);
                n1.CompilationHelper.ReadPin(state_52.__p_KhDhTGBxXYMNy4TUBnA7Y1.Outputs[0], out n36.Bloom out_87);
                bool SetBloom_88 = true;
                var Output_89 = Output_84;
                if (SetBloom_88)
                {
                    Output_89 = Output_84.SetBloom(Bloom_In: out_87);
                }

                int Streaks_90 = 4;
                n1.CompilationHelper.WritePin(state_52.__p_V3eaLbPDXoLNN8p88OjuDF.Inputs[1], ref Streaks_90);
                float Attenuation_91 = 0.57F;
                n1.CompilationHelper.WritePin(state_52.__p_V3eaLbPDXoLNN8p88OjuDF.Inputs[2], ref Attenuation_91);
                float Phase_92 = 29.79F;
                n1.CompilationHelper.WritePin(state_52.__p_V3eaLbPDXoLNN8p88OjuDF.Inputs[3], ref Phase_92);
                bool Anamorphic_93 = false;
                n1.CompilationHelper.WritePin(state_52.__p_V3eaLbPDXoLNN8p88OjuDF.Inputs[5], ref Anamorphic_93);
                bool Enabled_94 = true;
                n1.CompilationHelper.WritePin(state_52.__p_V3eaLbPDXoLNN8p88OjuDF.Inputs[6], ref Enabled_94);
                n1.CompilationHelper.ReadPin(state_52.__p_V3eaLbPDXoLNN8p88OjuDF.Outputs[0], out n36.LightStreak out_95);
                bool SetLightStreak_96 = true;
                var Output_97 = Output_89;
                if (SetLightStreak_96)
                {
                    Output_97 = Output_89.SetLightStreak(Light_Streak_In: out_95);
                }

                float Color_Abberation_98 = 0.17F;
                n1.CompilationHelper.WritePin(state_52.__p_CnCFB7G36eZO6rhgt8ccAc.Inputs[1], ref Color_Abberation_98);
                float Halo_99 = 0.34F;
                n1.CompilationHelper.WritePin(state_52.__p_CnCFB7G36eZO6rhgt8ccAc.Inputs[2], ref Halo_99);
                bool Enabled_100 = true;
                n1.CompilationHelper.WritePin(state_52.__p_CnCFB7G36eZO6rhgt8ccAc.Inputs[3], ref Enabled_100);
                n1.CompilationHelper.ReadPin(state_52.__p_CnCFB7G36eZO6rhgt8ccAc.Outputs[0], out n36.LensFlare out_101);
                bool SetLensFlare_102 = true;
                var Output_103 = Output_97;
                if (SetLensFlare_102)
                {
                    Output_103 = Output_97.SetLensFlare(Lens_Flare_In: out_101);
                }

                float Amount_104 = 0.09999999F;
                n1.CompilationHelper.WritePin(state_52.__p_UGm6M1ifjE0LGowzDRvvZ6.Inputs[0], ref Amount_104);
                float Grain_Size_105 = 0.7F;
                n1.CompilationHelper.WritePin(state_52.__p_UGm6M1ifjE0LGowzDRvvZ6.Inputs[1], ref Grain_Size_105);
                bool Animate_106 = true;
                n1.CompilationHelper.WritePin(state_52.__p_UGm6M1ifjE0LGowzDRvvZ6.Inputs[2], ref Animate_106);
                n1.CompilationHelper.ReadPin(state_52.__p_UGm6M1ifjE0LGowzDRvvZ6.Outputs[0], out n36.FilmGrain out_107);
                float Radius_108 = 0.48F;
                n1.CompilationHelper.WritePin(state_52.__p_BkzEreSiWkoNgdbDWGOJ6b.Inputs[1], ref Radius_108);
                n7.Color4 Color_109 = __c_ETIIyqFqpWINItkMu1MsT2;
                n1.CompilationHelper.WritePin(state_52.__p_BkzEreSiWkoNgdbDWGOJ6b.Inputs[2], ref Color_109);
                bool Enabled_110 = true;
                n1.CompilationHelper.WritePin(state_52.__p_BkzEreSiWkoNgdbDWGOJ6b.Inputs[3], ref Enabled_110);
                n1.CompilationHelper.ReadPin(state_52.__p_BkzEreSiWkoNgdbDWGOJ6b.Outputs[0], out n36.Vignetting out_111);
                n1.CompilationHelper.WritePin(state_52.__p_HVF3nI6EZREOKWG7zQCEtL.Inputs[0], ref out_50);
                bool Auto_Key_Value_112 = false;
                n1.CompilationHelper.WritePin(state_52.__p_HVF3nI6EZREOKWG7zQCEtL.Inputs[1], ref Auto_Key_Value_112);
                float Key_Value_113 = 0.68F;
                n1.CompilationHelper.WritePin(state_52.__p_HVF3nI6EZREOKWG7zQCEtL.Inputs[2], ref Key_Value_113);
                bool Auto_Exposure_114 = false;
                n1.CompilationHelper.WritePin(state_52.__p_HVF3nI6EZREOKWG7zQCEtL.Inputs[3], ref Auto_Exposure_114);
                float Exposure_115 = 0F;
                n1.CompilationHelper.WritePin(state_52.__p_HVF3nI6EZREOKWG7zQCEtL.Inputs[4], ref Exposure_115);
                bool Temporal_Adaptation_116 = false;
                n1.CompilationHelper.WritePin(state_52.__p_HVF3nI6EZREOKWG7zQCEtL.Inputs[5], ref Temporal_Adaptation_116);
                bool Use_Local_Luminance_117 = false;
                n1.CompilationHelper.WritePin(state_52.__p_HVF3nI6EZREOKWG7zQCEtL.Inputs[7], ref Use_Local_Luminance_117);
                n1.CompilationHelper.WritePin(state_52.__p_HVF3nI6EZREOKWG7zQCEtL.Inputs[11], ref __pad_KpDA2ori8VpMDO7Rdfm2Uu_68);
                n1.CompilationHelper.ReadPin(state_52.__p_HVF3nI6EZREOKWG7zQCEtL.Outputs[0], out n36.ToneMap out_118);
                var builder_119 = n5.CollectionBuilders.GetBuilder(state_52.__pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI, 3);
                builder_119.Add(out_107);
                builder_119.Add(out_111);
                builder_119.Add(out_118);
                var __pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI_120 = builder_119.Commit();
                n23._Operations_.Cons<n36.ColorTransform>(Input_In: __pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI_120, Result_Out: out n20.Spread<n36.ColorTransform> Result_121);
                bool Enable_Default_ToneMap_122 = true;
                bool SetColorTransforms_123 = true;
                var Output_124 = Output_103;
                if (SetColorTransforms_123)
                {
                    Output_124 = Output_103.SetColorTransforms(Color_Transforms_In: Result_121, Enable_Default_ToneMap_In: Enable_Default_ToneMap_122);
                }

                n42.DitherType Dither_125 = __c_GwfzwYe96s4MCp5DgD6CQB;
                n1.CompilationHelper.WritePin(state_52.__p_F3cAGZxJ2NoMJ6ytBaA3RH.Inputs[0], ref Dither_125);
                int Quality_126 = 5;
                n1.CompilationHelper.WritePin(state_52.__p_F3cAGZxJ2NoMJ6ytBaA3RH.Inputs[1], ref Quality_126);
                bool Input_Luminance_From_Alpha_127 = true;
                n1.CompilationHelper.WritePin(state_52.__p_F3cAGZxJ2NoMJ6ytBaA3RH.Inputs[2], ref Input_Luminance_From_Alpha_127);
                bool Enabled_128 = true;
                n1.CompilationHelper.WritePin(state_52.__p_F3cAGZxJ2NoMJ6ytBaA3RH.Inputs[3], ref Enabled_128);
                n1.CompilationHelper.ReadPin(state_52.__p_F3cAGZxJ2NoMJ6ytBaA3RH.Outputs[0], out n36.FXAAEffect out_129);
                n36.IScreenSpaceAntiAliasingEffect Antialiasing_130 = (n36.IScreenSpaceAntiAliasingEffect)out_129;
                bool SetAntialiasing_131 = true;
                var Output_132 = Output_124;
                if (SetAntialiasing_131)
                {
                    Output_132 = Output_124.SetAntialiasing(Antialiasing_In: Antialiasing_130);
                }

                var State_Output_134 = Output_132.Update(Output_Out: out n36.PostProcessingEffects Output_133);
                __auto_51 = Output_133;
                bool Condition_135 = false;
                var state_136 = n1.CompilationHelper.Restore<__UOlCd7KUusFLxKiyLKA8mC>(state_52.__if_Jun4ntyn4WHLhsavPcEVrr, __GetContext__());
                if (Condition_135)
                {
                    if (state_136 == null)
                    {
                        state_136 = new __UOlCd7KUusFLxKiyLKA8mC(__GetContext__(), n1.VLObject.NewIdentity());
                        var node_137 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "LocalReflections", "Stride.Rendering.PostFX");
                        state_136.__p_CKHkgLZlmn9PzK6bD0B0fK = node_137;
                    }

                    n1.CompilationHelper.ReadPin(state_136.__p_CKHkgLZlmn9PzK6bD0B0fK.Outputs[0], out n36.LocalReflections out_138);
                    if (state_136.__GetContext__().IsImmutable)
                        state_136 = state_136.__p_CKHkgLZlmn9PzK6bD0B0fK != state_136.__p_CKHkgLZlmn9PzK6bD0B0fK ? new __UOlCd7KUusFLxKiyLKA8mC(state_136)
                        {__p_CKHkgLZlmn9PzK6bD0B0fK = state_136.__p_CKHkgLZlmn9PzK6bD0B0fK} : state_136;
                    else
                    {
                        state_136.__p_CKHkgLZlmn9PzK6bD0B0fK = state_136.__p_CKHkgLZlmn9PzK6bD0B0fK;
                    }
                }

                n1.CompilationHelper.ReadPin(state_52.__p_EnCvbImiDHANtpydvwVr4v.Outputs[0], out n36.ToneMapU2FilmicOperator out_139);
                if (state_52.__GetContext__().IsImmutable)
                    state_52 = state_52.__p_PYhtkVIxBSRNfTZ41JFxQm != state_52.__p_PYhtkVIxBSRNfTZ41JFxQm || State_Output_134 != state_52.__p_FLlTfOrpicKP5Vw6UpZWEG || state_52.__p_M7GGPysJb1UPMbjG14NvwK != state_52.__p_M7GGPysJb1UPMbjG14NvwK || state_52.__p_OZZRXF2oGSbNkdyx0cJDgs != state_52.__p_OZZRXF2oGSbNkdyx0cJDgs || state_52.__p_KhDhTGBxXYMNy4TUBnA7Y1 != state_52.__p_KhDhTGBxXYMNy4TUBnA7Y1 || state_52.__p_V3eaLbPDXoLNN8p88OjuDF != state_52.__p_V3eaLbPDXoLNN8p88OjuDF || state_52.__p_CnCFB7G36eZO6rhgt8ccAc != state_52.__p_CnCFB7G36eZO6rhgt8ccAc || state_52.__p_UGm6M1ifjE0LGowzDRvvZ6 != state_52.__p_UGm6M1ifjE0LGowzDRvvZ6 || state_52.__p_BkzEreSiWkoNgdbDWGOJ6b != state_52.__p_BkzEreSiWkoNgdbDWGOJ6b || state_52.__p_HVF3nI6EZREOKWG7zQCEtL != state_52.__p_HVF3nI6EZREOKWG7zQCEtL || __pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI_120 != state_52.__pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI || state_52.__p_F3cAGZxJ2NoMJ6ytBaA3RH != state_52.__p_F3cAGZxJ2NoMJ6ytBaA3RH || state_136 != state_52.__if_Jun4ntyn4WHLhsavPcEVrr || state_52.__p_EnCvbImiDHANtpydvwVr4v != state_52.__p_EnCvbImiDHANtpydvwVr4v ? new __I30iaMzRRy4LNTxqhhvoVu(state_52)
                    {__p_PYhtkVIxBSRNfTZ41JFxQm = state_52.__p_PYhtkVIxBSRNfTZ41JFxQm, __p_FLlTfOrpicKP5Vw6UpZWEG = State_Output_134, __p_M7GGPysJb1UPMbjG14NvwK = state_52.__p_M7GGPysJb1UPMbjG14NvwK, __p_OZZRXF2oGSbNkdyx0cJDgs = state_52.__p_OZZRXF2oGSbNkdyx0cJDgs, __p_KhDhTGBxXYMNy4TUBnA7Y1 = state_52.__p_KhDhTGBxXYMNy4TUBnA7Y1, __p_V3eaLbPDXoLNN8p88OjuDF = state_52.__p_V3eaLbPDXoLNN8p88OjuDF, __p_CnCFB7G36eZO6rhgt8ccAc = state_52.__p_CnCFB7G36eZO6rhgt8ccAc, __p_UGm6M1ifjE0LGowzDRvvZ6 = state_52.__p_UGm6M1ifjE0LGowzDRvvZ6, __p_BkzEreSiWkoNgdbDWGOJ6b = state_52.__p_BkzEreSiWkoNgdbDWGOJ6b, __p_HVF3nI6EZREOKWG7zQCEtL = state_52.__p_HVF3nI6EZREOKWG7zQCEtL, __pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI = __pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI_120, __p_F3cAGZxJ2NoMJ6ytBaA3RH = state_52.__p_F3cAGZxJ2NoMJ6ytBaA3RH, __if_Jun4ntyn4WHLhsavPcEVrr = state_136, __p_EnCvbImiDHANtpydvwVr4v = state_52.__p_EnCvbImiDHANtpydvwVr4v} : state_52;
                else
                {
                    state_52.__p_PYhtkVIxBSRNfTZ41JFxQm = state_52.__p_PYhtkVIxBSRNfTZ41JFxQm;
                    state_52.__p_FLlTfOrpicKP5Vw6UpZWEG = State_Output_134;
                    state_52.__p_M7GGPysJb1UPMbjG14NvwK = state_52.__p_M7GGPysJb1UPMbjG14NvwK;
                    state_52.__p_OZZRXF2oGSbNkdyx0cJDgs = state_52.__p_OZZRXF2oGSbNkdyx0cJDgs;
                    state_52.__p_KhDhTGBxXYMNy4TUBnA7Y1 = state_52.__p_KhDhTGBxXYMNy4TUBnA7Y1;
                    state_52.__p_V3eaLbPDXoLNN8p88OjuDF = state_52.__p_V3eaLbPDXoLNN8p88OjuDF;
                    state_52.__p_CnCFB7G36eZO6rhgt8ccAc = state_52.__p_CnCFB7G36eZO6rhgt8ccAc;
                    state_52.__p_UGm6M1ifjE0LGowzDRvvZ6 = state_52.__p_UGm6M1ifjE0LGowzDRvvZ6;
                    state_52.__p_BkzEreSiWkoNgdbDWGOJ6b = state_52.__p_BkzEreSiWkoNgdbDWGOJ6b;
                    state_52.__p_HVF3nI6EZREOKWG7zQCEtL = state_52.__p_HVF3nI6EZREOKWG7zQCEtL;
                    state_52.__pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI = __pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI_120;
                    state_52.__p_F3cAGZxJ2NoMJ6ytBaA3RH = state_52.__p_F3cAGZxJ2NoMJ6ytBaA3RH;
                    state_52.__if_Jun4ntyn4WHLhsavPcEVrr = state_136;
                    state_52.__p_EnCvbImiDHANtpydvwVr4v = state_52.__p_EnCvbImiDHANtpydvwVr4v;
                }
            }
            else
            {
                __auto_51 = default(n36.PostProcessingEffects);
            }

            bool __pad_NhXnrXGBOR6L5J1GNUxsjV_140 = Show_Guide_In;
            n7.Vector2 Size_141 = __c_TIpmdGnvHCwPdPLoAhhR55;
            n7.Int2 Tessellation_142 = __c_RUKeOGvKVO0PSUwgZ3cis4;
            n43.NormalDirection Normal_143 = __c_ECnsZmxCPSuLQFwj7jXGND;
            bool Generate_Back_Face_144 = true;
            bool SetupModel_145 = true;
            var Output_146 = this.__p_U0z7CJxgjTwOi3BwfgMTKT;
            if (SetupModel_145)
            {
                Output_146 = this.__p_U0z7CJxgjTwOi3BwfgMTKT.SetupModel(Size_In: Size_141, Tessellation_In: Tessellation_142, Normal_In: Normal_143, Generate_Back_Face_In: Generate_Back_Face_144);
            }

            var State_Output_148 = this.__p_KUOxKfQJDWOQUluNScNX67.Update(Output_Out: out n9.Material Output_147);
            bool SetMaterial_149 = true;
            var Output_150 = Output_146;
            if (SetMaterial_149)
            {
                Output_150 = Output_146.SetMaterial(Material_In: Output_147);
            }

            bool SetEnabled_151 = true;
            var Output_152 = Output_150;
            if (SetEnabled_151)
            {
                Output_152 = Output_150.SetEnabled(Enabled_In: Stage_Enabled_In);
            }

            var Output_154 = Output_152.Update(Entity_Out: out n16.Entity Entity_153);
            int __pad_OJARAgZICF2L6ucXq8sFsh_155 = LightPreset_In;
            bool __auto_156 = Background_Enabled_In;
            var Y_157 = __pad_QBpQ3JKmf8sMCpnXsJpc5r_6.Y;
            var Output_158 = Y_157 * __pad_VOFcKF62HiYMfI6k58M0Rt_7;
            float X_159 = 0F;
            float Z_160 = 0F;
            var Output_161 = new n7.Vector3(x: X_159, y: Output_158, z: Z_160);
            n7.Matrix Input_162 = n27._Operations_.CreateDefault();
            n7.Vector3 Rotation_163 = n44._Operations_.CreateDefault();
            n45._Operations_.TransformSRT(Input_In: Input_162, Scaling_In: __pad_QBpQ3JKmf8sMCpnXsJpc5r_6, Rotation_In: Rotation_163, Translation_In: Output_161, Output_Out: out n7.Matrix Output_164);
            n7.Color4 Color_165 = __c_EKKnEgVE8TTOjCmA7wnVBA;
            var State_Output_167 = this.__p_QuexozVp4iELOOPugFiTsc.Update(Transformation_In: Output_164, Color_In: Color_165, Output_Out: out n10.MeshRenderer_C Output_166);
            n9.IGraphicsRendererBase Input_168 = (n9.IGraphicsRendererBase)Output_166;
            bool SetDrawer_169 = true;
            var Output_170 = this.__p_EdUxqYnbY29Ork1eOjzeI6;
            if (SetDrawer_169)
            {
                Output_170 = this.__p_EdUxqYnbY29Ork1eOjzeI6.SetDrawer(Input_In: Input_168);
            }

            var Output_172 = Output_170.GetComponent(Component_Out: out n6.EntityRendererComponent Component_171);
            var builder_173 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs, 1);
            builder_173.Add(Component_171);
            var __pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs_174 = builder_173.Commit();
            n23._Operations_.FromValue<n16.EntityComponent>(Input_In: __pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs_174, Result_Out: out n20.Spread<n16.EntityComponent> Result_175);
            bool SetComponents_176 = true;
            var Output_177 = this.__p_CGVQbiWlZ6gMMXPGelynpi;
            if (SetComponents_176)
            {
                Output_177 = this.__p_CGVQbiWlZ6gMMXPGelynpi.SetComponents(Components_In: Result_175);
            }

            bool SetEnabled_178 = true;
            var Output_179 = Output_177;
            if (SetEnabled_178)
            {
                Output_179 = Output_177.SetEnabled(Enabled_In: __pad_NhXnrXGBOR6L5J1GNUxsjV_140);
            }

            var State_Output_181 = Output_179.GetEntity(Output_Out: out n16.Entity Output_180);
            n7.Matrix Transformation_182 = __c_PYp4LuJoMsZNHAM0HZ9Mrk;
            bool Axis_183 = false;
            int Radius_184 = 5;
            bool Enabled_185 = true;
            var State_Output_187 = this.__p_M7l9WCzq0kYLJR9eyFqCBP.Update(Transformation_In: Transformation_182, Axis_In: Axis_183, Grid_In: __pad_NhXnrXGBOR6L5J1GNUxsjV_140, Grid_Color_In: __pad_MlmYhDPKG8hOivPtXnbFcG_5, Radius_In: Radius_184, Enabled_In: Enabled_185, Output_Out: out n16.Entity Output_186);
            bool SetChildren_188 = true;
            var builder_189 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC, 2);
            builder_189.Add(Output_180);
            builder_189.Add(Output_186);
            var __pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC_190 = builder_189.Commit();
            var Output_191 = this.__p_JjeqbOoVZIUP04IXDC1ehC;
            if (SetChildren_188)
            {
                Output_191 = this.__p_JjeqbOoVZIUP04IXDC1ehC.SetChildren(Child_In: __pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC_190);
            }

            var State_Output_193 = Output_191.Update(Output_Out: out n16.Entity Output_192);
            n7.Matrix Input_194 = n27._Operations_.CreateDefault();
            n45._Operations_.Rotate(Input_In: Input_194, Rotation_In: __pad_Vu5FjpkSalUOyyXNoe0aCa_0, Output_Out: out n7.Matrix Output_195);
            bool SetTransformation_196 = true;
            var Output_197 = this.__p_DsUYgcIgAqgNpIByjD5qry;
            if (SetTransformation_196)
            {
                Output_197 = this.__p_DsUYgcIgAqgNpIByjD5qry.SetTransformation(Transformation_In: Output_195);
            }

            bool Generate_Mipmaps_198 = true;
            bool Is_sRGB_199 = true;
            bool Premultiply_Alpha_200 = true;
            bool Compress_201 = false;
            n46.AlphaFormat Alpha_Format_202 = __c_Vc3FG2ZlVyoNl5ZkMq5cY4;
            bool Reload_203 = false;
            var Output_207 = this.__p_TnZGwyZOOAvLNsbG5YzGoo.Update(Path_In: __pad_JhwqVgRchaHPqkanMBqnTa_1, Generate_Mipmaps_In: Generate_Mipmaps_198, Is_sRGB_In: Is_sRGB_199, Premultiply_Alpha_In: Premultiply_Alpha_200, Compress_In: Compress_201, Alpha_Format_In: Alpha_Format_202, Reload_In: Reload_203, Texture_Out: out n3.Texture Texture_204, Is_Loading_Out: out bool Is_Loading_205, Already_Loaded_Out: out bool Already_Loaded_206);
            bool Is_Specular_Only_208 = false;
            float Intensity_209 = 0.5F;
            n47.SkyboxPreFilteringDiffuseOrder Diffuse_SHOrder_210 = n1.CompilationHelper.Deserialize<n47.SkyboxPreFilteringDiffuseOrder>("Order3", false, null, null);
            int Specular_Cube_Map_Size_211 = 256;
            bool Force_Build_212 = false;
            float Background_Intensity_213 = 1F;
            bool SetupLight_214 = true;
            var Output_215 = Output_197;
            if (SetupLight_214)
            {
                Output_215 = Output_197.SetupLight(Cube_Map_In: Texture_204, Is_Specular_Only_In: Is_Specular_Only_208, Intensity_In: Intensity_209, Diffuse_SHOrder_In: Diffuse_SHOrder_210, Specular_Cube_Map_Size_In: Specular_Cube_Map_Size_211, Force_Build_In: Force_Build_212, Background_Intensity_In: Background_Intensity_213, Background_Enabled_In: __auto_2);
            }

            var Output_217 = Output_215.Update(Entity_Out: out n16.Entity Entity_216);
            n7.Vector3 Target_218 = __c_O6g6BssX30FOY8DOVTzbfy;
            n7.Color4 Color_219 = __c_AnR350Xko6MNE9fe7c8w5b;
            float Intensity_220 = 0.64F;
            bool SetupLight_221 = true;
            var Output_222 = this.__p_FCEGzRTSAY2O1ikFPemSw0;
            if (SetupLight_221)
            {
                Output_222 = this.__p_FCEGzRTSAY2O1ikFPemSw0.SetupLight(Position_In: __pad_I43q45FJUEZOBjWlyFoN9U_3, Target_In: Target_218, Color_In: Color_219, Intensity_In: Intensity_220);
            }

            n1.CompilationHelper.WritePin(this.__p_B6e5crkSWyBQah1Lbf5Xcx.Inputs[0], ref __pad_Kk95YrDeFLpNRnPQEf1vlw_4);
            n1.CompilationHelper.ReadPin(this.__p_B6e5crkSWyBQah1Lbf5Xcx.Outputs[0], out n41.LightShadowMapFilterTypePcf out_223);
            n41.ILightShadowMapFilterType Filter_224 = (n41.ILightShadowMapFilterType)out_223;
            n1.CompilationHelper.WritePin(this.__p_Dga49V9W4TTN8hChcfHnKM.Inputs[4], ref Filter_224);
            n41.LightShadowMapSize Size_225 = __c_OZAkST1MnfaQWg6yqJSQAK;
            n1.CompilationHelper.WritePin(this.__p_Dga49V9W4TTN8hChcfHnKM.Inputs[5], ref Size_225);
            n1.CompilationHelper.ReadPin(this.__p_Dga49V9W4TTN8hChcfHnKM.Outputs[0], out n41.LightDirectionalShadowMap out_226);
            bool Enable_Default_Shadow_227 = true;
            bool SetShadow_228 = true;
            var Output_229 = Output_222;
            if (SetShadow_228)
            {
                Output_229 = Output_222.SetShadow(Shadow_In: out_226, Enable_Default_Shadow_In: Enable_Default_Shadow_227);
            }

            bool Show_Helper_230 = true;
            var Output_232 = Output_229.Update(Show_Helper_In: Show_Helper_230, Entity_Out: out n16.Entity Entity_231);
            n7.Vector3 Position_233 = __c_MCG2aejPzIMMmMnUiPYLhG;
            n7.Vector3 Target_234 = __c_B5Do8tnCftnLXYdD75bLPn;
            n7.Color4 Color_235 = __c_Kht9P5tbKU2P5jUXegvmE5;
            float Intensity_236 = 1F;
            float Range_237 = 5F;
            float Angle_238 = 0.25F;
            float Softness_239 = 0.01F;
            bool SetupLight_240 = true;
            var Output_241 = this.__p_C406t4F9APFL7HLbeRZ9Ir;
            if (SetupLight_240)
            {
                Output_241 = this.__p_C406t4F9APFL7HLbeRZ9Ir.SetupLight(Position_In: Position_233, Target_In: Target_234, Color_In: Color_235, Intensity_In: Intensity_236, Range_In: Range_237, Angle_In: Angle_238, Softness_In: Softness_239);
            }

            bool Show_Helper_242 = true;
            var Output_244 = Output_241.Update(Show_Helper_In: Show_Helper_242, Entity_Out: out n16.Entity Entity_243);
            bool SetChildren_245 = true;
            var builder_246 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9, 3);
            builder_246.Add(Entity_216);
            builder_246.Add(Entity_231);
            builder_246.Add(Entity_243);
            var __pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9_247 = builder_246.Commit();
            var Output_248 = this.__p_RUFuwB5bt97LlcLQcPESV9;
            if (SetChildren_245)
            {
                Output_248 = this.__p_RUFuwB5bt97LlcLQcPESV9.SetChildren(Child_In: __pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9_247);
            }

            var State_Output_250 = Output_248.Update(Output_Out: out n16.Entity Output_249);
            n7.Matrix Input_251 = n27._Operations_.CreateDefault();
            n45._Operations_.Rotate(Input_In: Input_251, Rotation_In: __pad_SmV5mvCrccjPOsKV3o6SiO_9, Output_Out: out n7.Matrix Output_252);
            bool SetTransformation_253 = true;
            var Output_254 = this.__p_KkxFEvV6CdWMrZMkykhBMi;
            if (SetTransformation_253)
            {
                Output_254 = this.__p_KkxFEvV6CdWMrZMkykhBMi.SetTransformation(Transformation_In: Output_252);
            }

            bool Generate_Mipmaps_255 = true;
            bool Is_sRGB_256 = true;
            bool Premultiply_Alpha_257 = true;
            bool Compress_258 = false;
            n46.AlphaFormat Alpha_Format_259 = __c_RXSV8w6H1bHLoQUtFL84ss;
            bool Reload_260 = false;
            var Output_264 = this.__p_CtoO6xEdfhdOTUjTpnNf8N.Update(Path_In: __pad_VAmFBkFaVZjOxJev7GS1YZ_10, Generate_Mipmaps_In: Generate_Mipmaps_255, Is_sRGB_In: Is_sRGB_256, Premultiply_Alpha_In: Premultiply_Alpha_257, Compress_In: Compress_258, Alpha_Format_In: Alpha_Format_259, Reload_In: Reload_260, Texture_Out: out n3.Texture Texture_261, Is_Loading_Out: out bool Is_Loading_262, Already_Loaded_Out: out bool Already_Loaded_263);
            bool Is_Specular_Only_265 = false;
            float Intensity_266 = 2.5F;
            n47.SkyboxPreFilteringDiffuseOrder Diffuse_SHOrder_267 = n1.CompilationHelper.Deserialize<n47.SkyboxPreFilteringDiffuseOrder>("Order3", false, null, null);
            int Specular_Cube_Map_Size_268 = 256;
            bool Force_Build_269 = false;
            float Background_Intensity_270 = 1F;
            bool SetupLight_271 = true;
            var Output_272 = Output_254;
            if (SetupLight_271)
            {
                Output_272 = Output_254.SetupLight(Cube_Map_In: Texture_261, Is_Specular_Only_In: Is_Specular_Only_265, Intensity_In: Intensity_266, Diffuse_SHOrder_In: Diffuse_SHOrder_267, Specular_Cube_Map_Size_In: Specular_Cube_Map_Size_268, Force_Build_In: Force_Build_269, Background_Intensity_In: Background_Intensity_270, Background_Enabled_In: __auto_11);
            }

            var Output_274 = Output_272.Update(Entity_Out: out n16.Entity Entity_273);
            n7.Vector3 Target_275 = __c_IHIpzPc1Xm4PIHDGgMHXc2;
            n7.Color4 Color_276 = __c_VAAGmGjIReSPeyZr9XtVbP;
            float Intensity_277 = 1F;
            bool SetupLight_278 = true;
            var Output_279 = this.__p_QK7hngAdoaDN76tZOseXvN;
            if (SetupLight_278)
            {
                Output_279 = this.__p_QK7hngAdoaDN76tZOseXvN.SetupLight(Position_In: __pad_JKbM66PcDIBM3wpX7uz4iI_8, Target_In: Target_275, Color_In: Color_276, Intensity_In: Intensity_277);
            }

            bool Enabled_280 = true;
            bool SetEnabled_281 = true;
            var Output_282 = Output_279;
            if (SetEnabled_281)
            {
                Output_282 = Output_279.SetEnabled(Enabled_In: Enabled_280);
            }

            bool Show_Helper_283 = true;
            var Output_285 = Output_282.Update(Show_Helper_In: Show_Helper_283, Entity_Out: out n16.Entity Entity_284);
            n7.Color4 Color_286 = __c_SWqnDLnkSDVPti0XfgBY9s;
            float Intensity_287 = 3F;
            bool SetupLight_288 = true;
            var Output_289 = this.__p_AKAzR4zLycYMkPcdO1se2V;
            if (SetupLight_288)
            {
                Output_289 = this.__p_AKAzR4zLycYMkPcdO1se2V.SetupLight(Color_In: Color_286, Intensity_In: Intensity_287);
            }

            var Output_291 = Output_289.Update(Entity_Out: out n16.Entity Entity_290);
            bool Enable_Default_Shadow_292 = true;
            bool SetShadow_293 = true;
            var Output_294 = this.__p_BkxLipNAhZKMEfU5vo2GnW;
            if (SetShadow_293)
            {
                Output_294 = this.__p_BkxLipNAhZKMEfU5vo2GnW.SetShadow(Shadow_In: out_226, Enable_Default_Shadow_In: Enable_Default_Shadow_292);
            }

            bool Show_Helper_295 = true;
            var Output_297 = Output_294.Update(Show_Helper_In: Show_Helper_295, Entity_Out: out n16.Entity Entity_296);
            bool SetChildren_298 = true;
            var builder_299 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20, 4);
            builder_299.Add(Entity_273);
            builder_299.Add(Entity_284);
            builder_299.Add(Entity_290);
            builder_299.Add(Entity_296);
            var __pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20_300 = builder_299.Commit();
            var Output_301 = this.__p_KM1V4OUPbJoM9RMwCBqb20;
            if (SetChildren_298)
            {
                Output_301 = this.__p_KM1V4OUPbJoM9RMwCBqb20.SetChildren(Child_In: __pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20_300);
            }

            var State_Output_303 = Output_301.Update(Output_Out: out n16.Entity Output_302);
            n7.Matrix Input_304 = n27._Operations_.CreateDefault();
            n45._Operations_.Rotate(Input_In: Input_304, Rotation_In: __pad_Mtt6R0xrquEMVq7yoq4aGF_15, Output_Out: out n7.Matrix Output_305);
            bool SetTransformation_306 = true;
            var Output_307 = this.__p_FWyfZaT4PhkNyQJ8vguC5x;
            if (SetTransformation_306)
            {
                Output_307 = this.__p_FWyfZaT4PhkNyQJ8vguC5x.SetTransformation(Transformation_In: Output_305);
            }

            bool Generate_Mipmaps_308 = true;
            bool Is_sRGB_309 = true;
            bool Premultiply_Alpha_310 = true;
            bool Compress_311 = false;
            n46.AlphaFormat Alpha_Format_312 = __c_DOi4rV3S9y0PTBrLHyP4Xh;
            bool Reload_313 = false;
            var Output_317 = this.__p_LGArFWy3lqdOlbLn3s4kfp.Update(Path_In: __pad_SEycS7fVjWFLq9BXC5xDkI_16, Generate_Mipmaps_In: Generate_Mipmaps_308, Is_sRGB_In: Is_sRGB_309, Premultiply_Alpha_In: Premultiply_Alpha_310, Compress_In: Compress_311, Alpha_Format_In: Alpha_Format_312, Reload_In: Reload_313, Texture_Out: out n3.Texture Texture_314, Is_Loading_Out: out bool Is_Loading_315, Already_Loaded_Out: out bool Already_Loaded_316);
            bool Is_Specular_Only_318 = false;
            float Intensity_319 = 0.5F;
            n47.SkyboxPreFilteringDiffuseOrder Diffuse_SHOrder_320 = n1.CompilationHelper.Deserialize<n47.SkyboxPreFilteringDiffuseOrder>("Order3", false, null, null);
            int Specular_Cube_Map_Size_321 = 256;
            bool Force_Build_322 = false;
            float Background_Intensity_323 = 1F;
            bool SetupLight_324 = true;
            var Output_325 = Output_307;
            if (SetupLight_324)
            {
                Output_325 = Output_307.SetupLight(Cube_Map_In: Texture_314, Is_Specular_Only_In: Is_Specular_Only_318, Intensity_In: Intensity_319, Diffuse_SHOrder_In: Diffuse_SHOrder_320, Specular_Cube_Map_Size_In: Specular_Cube_Map_Size_321, Force_Build_In: Force_Build_322, Background_Intensity_In: Background_Intensity_323, Background_Enabled_In: __auto_17);
            }

            var Output_327 = Output_325.Update(Entity_Out: out n16.Entity Entity_326);
            n7.Vector3 Target_328 = __c_EaE0uAFVvzENd09iQJXsZ7;
            n7.Color4 Color_329 = __c_N1IDy3OEOA0QVjR2334KOA;
            float Intensity_330 = 0.64F;
            bool SetupLight_331 = true;
            var Output_332 = this.__p_Nx0ogFUOMk0PjrK6d9Mx5Q;
            if (SetupLight_331)
            {
                Output_332 = this.__p_Nx0ogFUOMk0PjrK6d9Mx5Q.SetupLight(Position_In: __pad_TnlI0YTrV2EM6FVdRvBwG9_18, Target_In: Target_328, Color_In: Color_329, Intensity_In: Intensity_330);
            }

            bool Enable_Default_Shadow_333 = true;
            bool SetShadow_334 = true;
            var Output_335 = Output_332;
            if (SetShadow_334)
            {
                Output_335 = Output_332.SetShadow(Shadow_In: out_226, Enable_Default_Shadow_In: Enable_Default_Shadow_333);
            }

            bool Show_Helper_336 = true;
            var Output_338 = Output_335.Update(Show_Helper_In: Show_Helper_336, Entity_Out: out n16.Entity Entity_337);
            float Period_339 = 24F;
            bool Pause_340 = false;
            bool Update_341 = true;
            var Output_342 = this.__p_VmBqYmSD1I0PiIuwqelTbJ;
            if (Update_341)
            {
                Output_342 = this.__p_VmBqYmSD1I0PiIuwqelTbJ.Update(Period_In: Period_339, Pause_In: Pause_340);
            }

            var Output_346 = Output_342.GetValues(Phase_Out: out float Phase_343, On_New_Cycle_Out: out bool On_New_Cycle_344, Cycles_Out: out int Cycles_345);
            float Latitude_347 = 1.56F;
            n48._Operations_.FromGeographic(Latitude_In: Latitude_347, Longitude_In: Phase_343, Radius_In: __pad_FNJLkBC7otfQK2nRhlOH46_30, Output_Out: out n7.Vector3 Output_348);
            n7.Vector3 __pad_BZQwCBgn5JVOW9pS7IwzL5_349 = Output_348;
            n7.Color4 Color_350 = __c_FPgxXO7SxQAL9mvqN0mSb3;
            float Intensity_351 = 1F;
            float Radius_352 = 5F;
            bool SetupLight_353 = true;
            var Output_354 = this.__p_PQwJhjYBk5KPlDxx3iMIWi;
            if (SetupLight_353)
            {
                Output_354 = this.__p_PQwJhjYBk5KPlDxx3iMIWi.SetupLight(Position_In: __pad_BZQwCBgn5JVOW9pS7IwzL5_349, Color_In: Color_350, Intensity_In: Intensity_351, Radius_In: Radius_352);
            }

            bool Show_Helper_355 = true;
            var Output_357 = Output_354.Update(Show_Helper_In: Show_Helper_355, Entity_Out: out n16.Entity Entity_356);
            n7.Color4 Color_358 = __c_LmyjAufbh1ONbeZvbo70K6;
            float Intensity_359 = 2.65F;
            float Range_360 = 10F;
            float Angle_361 = 0.25F;
            float Softness_362 = 0.01F;
            bool SetupLight_363 = true;
            var Output_364 = this.__p_SmR8pfakQuFM4Kb64PiXK7;
            if (SetupLight_363)
            {
                Output_364 = this.__p_SmR8pfakQuFM4Kb64PiXK7.SetupLight(Position_In: __pad_R5UHxOeaDRQLpsCcJyrYk6_31, Target_In: __pad_NToWGCWgDrxNdGY7Lfi7FG_32, Color_In: Color_358, Intensity_In: Intensity_359, Range_In: Range_360, Angle_In: Angle_361, Softness_In: Softness_362);
            }

            bool Show_Helper_365 = true;
            var Output_367 = Output_364.Update(Show_Helper_In: Show_Helper_365, Entity_Out: out n16.Entity Entity_366);
            bool SetChildren_368 = true;
            var builder_369 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw, 4);
            builder_369.Add(Entity_326);
            builder_369.Add(Entity_337);
            builder_369.Add(Entity_356);
            builder_369.Add(Entity_366);
            var __pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw_370 = builder_369.Commit();
            var Output_371 = this.__p_PnKXaDQXUdDQWKI1DJM6Sw;
            if (SetChildren_368)
            {
                Output_371 = this.__p_PnKXaDQXUdDQWKI1DJM6Sw.SetChildren(Child_In: __pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw_370);
            }

            var State_Output_373 = Output_371.Update(Output_Out: out n16.Entity Output_372);
            n7.Matrix Input_374 = n27._Operations_.CreateDefault();
            n45._Operations_.Rotate(Input_In: Input_374, Rotation_In: __pad_It50TDAwo89OaAaf3cyhmb_34, Output_Out: out n7.Matrix Output_375);
            bool SetTransformation_376 = true;
            var Output_377 = this.__p_HagAUNvLtbKOBDHJTMLDdk;
            if (SetTransformation_376)
            {
                Output_377 = this.__p_HagAUNvLtbKOBDHJTMLDdk.SetTransformation(Transformation_In: Output_375);
            }

            bool Generate_Mipmaps_378 = true;
            bool Is_sRGB_379 = true;
            bool Premultiply_Alpha_380 = true;
            bool Compress_381 = false;
            n46.AlphaFormat Alpha_Format_382 = __c_A4H6kVbpp5VOYP00VnTo1t;
            bool Reload_383 = false;
            var Output_387 = this.__p_QQaemaNEegjLMVZVeE4JJc.Update(Path_In: __pad_IL3Ga2zLUeYMUEephXKehK_35, Generate_Mipmaps_In: Generate_Mipmaps_378, Is_sRGB_In: Is_sRGB_379, Premultiply_Alpha_In: Premultiply_Alpha_380, Compress_In: Compress_381, Alpha_Format_In: Alpha_Format_382, Reload_In: Reload_383, Texture_Out: out n3.Texture Texture_384, Is_Loading_Out: out bool Is_Loading_385, Already_Loaded_Out: out bool Already_Loaded_386);
            bool Is_Specular_Only_388 = false;
            float Intensity_389 = 0.5F;
            n47.SkyboxPreFilteringDiffuseOrder Diffuse_SHOrder_390 = n1.CompilationHelper.Deserialize<n47.SkyboxPreFilteringDiffuseOrder>("Order3", false, null, null);
            int Specular_Cube_Map_Size_391 = 256;
            bool Force_Build_392 = false;
            float Background_Intensity_393 = 1F;
            bool SetupLight_394 = true;
            var Output_395 = Output_377;
            if (SetupLight_394)
            {
                Output_395 = Output_377.SetupLight(Cube_Map_In: Texture_384, Is_Specular_Only_In: Is_Specular_Only_388, Intensity_In: Intensity_389, Diffuse_SHOrder_In: Diffuse_SHOrder_390, Specular_Cube_Map_Size_In: Specular_Cube_Map_Size_391, Force_Build_In: Force_Build_392, Background_Intensity_In: Background_Intensity_393, Background_Enabled_In: __auto_36);
            }

            var Output_397 = Output_395.Update(Entity_Out: out n16.Entity Entity_396);
            n7.Vector3 Target_398 = __c_Pp7G6mOWZg5N1DAUIhzHYn;
            n7.Color4 Color_399 = __c_Iv1V5Uvd2AlMxRfNe98q2Y;
            float Intensity_400 = 0.2F;
            bool SetupLight_401 = true;
            var Output_402 = this.__p_Ekau9A7qIKWPH3n4iukg3a;
            if (SetupLight_401)
            {
                Output_402 = this.__p_Ekau9A7qIKWPH3n4iukg3a.SetupLight(Position_In: __pad_Nrni0XgJZU4Nc0JC61JDan_33, Target_In: Target_398, Color_In: Color_399, Intensity_In: Intensity_400);
            }

            n1.CompilationHelper.WritePin(this.__p_N5QqZaAkdMTNMNFNdnVUoU.Inputs[0], ref __pad_CCi5gx1CJ32OPXIUCYRlXm_45);
            n1.CompilationHelper.ReadPin(this.__p_N5QqZaAkdMTNMNFNdnVUoU.Outputs[0], out n41.LightShadowMapFilterTypePcf out_403);
            n41.ILightShadowMapFilterType Filter_404 = (n41.ILightShadowMapFilterType)out_403;
            n1.CompilationHelper.WritePin(this.__p_BJ7Y5jADNNfPthHrqKfQHd.Inputs[4], ref Filter_404);
            n41.LightShadowMapSize Size_405 = __c_VTWo65t8eSiNMRGUh0hQiD;
            n1.CompilationHelper.WritePin(this.__p_BJ7Y5jADNNfPthHrqKfQHd.Inputs[5], ref Size_405);
            n1.CompilationHelper.ReadPin(this.__p_BJ7Y5jADNNfPthHrqKfQHd.Outputs[0], out n41.LightDirectionalShadowMap out_406);
            bool Enable_Default_Shadow_407 = false;
            bool SetShadow_408 = true;
            var Output_409 = Output_402;
            if (SetShadow_408)
            {
                Output_409 = Output_402.SetShadow(Shadow_In: out_406, Enable_Default_Shadow_In: Enable_Default_Shadow_407);
            }

            bool Show_Helper_410 = true;
            var Output_412 = Output_409.Update(Show_Helper_In: Show_Helper_410, Entity_Out: out n16.Entity Entity_411);
            n7.Vector3 Target_413 = __c_HElHYvpcHs7Mb3pbE2op8N;
            n7.Color4 Color_414 = __c_L9gWA3KkbZyP0f412WrjvO;
            float Intensity_415 = 6.01F;
            float Range_416 = 5F;
            float Angle_417 = 0.25F;
            float Softness_418 = 0.01F;
            bool SetupLight_419 = true;
            var Output_420 = this.__p_R9T0bq9ZB8zPKD6mugiPMV;
            if (SetupLight_419)
            {
                Output_420 = this.__p_R9T0bq9ZB8zPKD6mugiPMV.SetupLight(Position_In: __pad_MSeyhzx7RQILXPHxKrXPs6_37, Target_In: Target_413, Color_In: Color_414, Intensity_In: Intensity_415, Range_In: Range_416, Angle_In: Angle_417, Softness_In: Softness_418);
            }

            bool Show_Helper_421 = true;
            var Output_423 = Output_420.Update(Show_Helper_In: Show_Helper_421, Entity_Out: out n16.Entity Entity_422);
            n7.Vector3 Target_424 = __c_BaRUSuZj0NeOmDzElpfabQ;
            n7.Color4 Color_425 = __c_Q4Q8ps6u9adMrROCUtWBb7;
            float Intensity_426 = 6.01F;
            float Range_427 = 5F;
            float Angle_428 = 0.25F;
            float Softness_429 = 0.01F;
            bool SetupLight_430 = true;
            var Output_431 = this.__p_HEb8kibmAUvPp7LCzqnh59;
            if (SetupLight_430)
            {
                Output_431 = this.__p_HEb8kibmAUvPp7LCzqnh59.SetupLight(Position_In: __pad_MHGItF376AtN0AneZTHhj2_38, Target_In: Target_424, Color_In: Color_425, Intensity_In: Intensity_426, Range_In: Range_427, Angle_In: Angle_428, Softness_In: Softness_429);
            }

            bool Show_Helper_432 = true;
            var Output_434 = Output_431.Update(Show_Helper_In: Show_Helper_432, Entity_Out: out n16.Entity Entity_433);
            n16.Entity Child_5_435 = default(n16.Entity);
            bool SetChildren_436 = true;
            var builder_437 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB, 5);
            builder_437.Add(Entity_396);
            builder_437.Add(Entity_411);
            builder_437.Add(Entity_422);
            builder_437.Add(Entity_433);
            builder_437.Add(Child_5_435);
            var __pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB_438 = builder_437.Commit();
            var Output_439 = this.__p_EaGTrQGlWWnNkAf0vdkSCB;
            if (SetChildren_436)
            {
                Output_439 = this.__p_EaGTrQGlWWnNkAf0vdkSCB.SetChildren(Child_In: __pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB_438);
            }

            var State_Output_441 = Output_439.Update(Output_Out: out n16.Entity Output_440);
            n7.Vector3 Target_442 = __c_KKwBzLtzPYlLXopirZNROC;
            n7.Color4 Color_443 = __c_TKbPSTgVBBVO5cbTJVOEzP;
            float Intensity_444 = 5F;
            bool SetupLight_445 = true;
            var Output_446 = this.__p_QQyHwUHxbpGNiBaGFnCq31;
            if (SetupLight_445)
            {
                Output_446 = this.__p_QQyHwUHxbpGNiBaGFnCq31.SetupLight(Position_In: __pad_O3g4b8EfxUjOr4bjVwWxsM_46, Target_In: Target_442, Color_In: Color_443, Intensity_In: Intensity_444);
            }

            n1.CompilationHelper.WritePin(this.__p_CMmAcXMEPFcQGMBASpUfa4.Inputs[0], ref __pad_Ctd9iNx7yxMOYG6vUFzjdD_48);
            n1.CompilationHelper.ReadPin(this.__p_CMmAcXMEPFcQGMBASpUfa4.Outputs[0], out n41.LightShadowMapFilterTypePcf out_447);
            n41.ILightShadowMapFilterType Filter_448 = (n41.ILightShadowMapFilterType)out_447;
            n1.CompilationHelper.WritePin(this.__p_TGaqE9XAoLvMIcFLRXc49a.Inputs[4], ref Filter_448);
            n41.LightShadowMapSize Size_449 = __c_LQtAcgxKQeLMs0PfQLDTX2;
            n1.CompilationHelper.WritePin(this.__p_TGaqE9XAoLvMIcFLRXc49a.Inputs[5], ref Size_449);
            n1.CompilationHelper.ReadPin(this.__p_TGaqE9XAoLvMIcFLRXc49a.Outputs[0], out n41.LightDirectionalShadowMap out_450);
            bool Enable_Default_Shadow_451 = true;
            bool SetShadow_452 = true;
            var Output_453 = Output_446;
            if (SetShadow_452)
            {
                Output_453 = Output_446.SetShadow(Shadow_In: out_450, Enable_Default_Shadow_In: Enable_Default_Shadow_451);
            }

            bool Show_Helper_454 = true;
            var Output_456 = Output_453.Update(Show_Helper_In: Show_Helper_454, Entity_Out: out n16.Entity Entity_455);
            n3.Texture Cube_Map_457 = default(n3.Texture);
            bool Is_Specular_Only_458 = false;
            float Intensity_459 = 0.49F;
            n47.SkyboxPreFilteringDiffuseOrder Diffuse_SHOrder_460 = n1.CompilationHelper.Deserialize<n47.SkyboxPreFilteringDiffuseOrder>("Order3", false, null, null);
            int Specular_Cube_Map_Size_461 = 256;
            bool Force_Build_462 = false;
            float Background_Intensity_463 = 0.33F;
            bool SetupLight_464 = true;
            var Output_465 = this.__p_SKrWf5e2Qh1NDQEgVEfFOB;
            if (SetupLight_464)
            {
                Output_465 = this.__p_SKrWf5e2Qh1NDQEgVEfFOB.SetupLight(Cube_Map_In: Cube_Map_457, Is_Specular_Only_In: Is_Specular_Only_458, Intensity_In: Intensity_459, Diffuse_SHOrder_In: Diffuse_SHOrder_460, Specular_Cube_Map_Size_In: Specular_Cube_Map_Size_461, Force_Build_In: Force_Build_462, Background_Intensity_In: Background_Intensity_463, Background_Enabled_In: __auto_47);
            }

            var Output_467 = Output_465.Update(Entity_Out: out n16.Entity Entity_466);
            n16.Entity Child_3_468 = default(n16.Entity);
            bool SetChildren_469 = true;
            var builder_470 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF, 3);
            builder_470.Add(Entity_455);
            builder_470.Add(Entity_466);
            builder_470.Add(Child_3_468);
            var __pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF_471 = builder_470.Commit();
            var Output_472 = this.__p_AnySrXohzM4L9fzfb2yFWF;
            if (SetChildren_469)
            {
                Output_472 = this.__p_AnySrXohzM4L9fzfb2yFWF.SetChildren(Child_In: __pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF_471);
            }

            bool Enabled_473 = true;
            bool SetEnabled_474 = true;
            var Output_475 = Output_472;
            if (SetEnabled_474)
            {
                Output_475 = Output_472.SetEnabled(Enabled_In: Enabled_473);
            }

            var State_Output_477 = Output_475.Update(Output_Out: out n16.Entity Output_476);
            n7.Matrix Input_478 = n27._Operations_.CreateDefault();
            n45._Operations_.Rotate(Input_In: Input_478, Rotation_In: __pad_UHvwNPRwngAMSyw84GpTxo_39, Output_Out: out n7.Matrix Output_479);
            bool SetTransformation_480 = true;
            var Output_481 = this.__p_Jb49oG861DPL87MSSAVVtT;
            if (SetTransformation_480)
            {
                Output_481 = this.__p_Jb49oG861DPL87MSSAVVtT.SetTransformation(Transformation_In: Output_479);
            }

            bool Generate_Mipmaps_482 = true;
            bool Is_sRGB_483 = true;
            bool Premultiply_Alpha_484 = true;
            bool Compress_485 = false;
            n46.AlphaFormat Alpha_Format_486 = __c_U29jKRKxTY1L1IMCdkBYnp;
            bool Reload_487 = false;
            var Output_491 = this.__p_LhwmT3fbQU4L4uCcfkqBn8.Update(Path_In: __pad_RABYUZiAQEROHCSHlyJGtO_40, Generate_Mipmaps_In: Generate_Mipmaps_482, Is_sRGB_In: Is_sRGB_483, Premultiply_Alpha_In: Premultiply_Alpha_484, Compress_In: Compress_485, Alpha_Format_In: Alpha_Format_486, Reload_In: Reload_487, Texture_Out: out n3.Texture Texture_488, Is_Loading_Out: out bool Is_Loading_489, Already_Loaded_Out: out bool Already_Loaded_490);
            bool Is_Specular_Only_492 = false;
            n47.SkyboxPreFilteringDiffuseOrder Diffuse_SHOrder_493 = n1.CompilationHelper.Deserialize<n47.SkyboxPreFilteringDiffuseOrder>("Order3", false, null, null);
            int Specular_Cube_Map_Size_494 = 256;
            bool Force_Build_495 = false;
            float Background_Intensity_496 = 1F;
            bool SetupLight_497 = true;
            var Output_498 = Output_481;
            if (SetupLight_497)
            {
                Output_498 = Output_481.SetupLight(Cube_Map_In: Texture_488, Is_Specular_Only_In: Is_Specular_Only_492, Intensity_In: __pad_SuO3USX97nbOZkyAnpraqe_41, Diffuse_SHOrder_In: Diffuse_SHOrder_493, Specular_Cube_Map_Size_In: Specular_Cube_Map_Size_494, Force_Build_In: Force_Build_495, Background_Intensity_In: Background_Intensity_496, Background_Enabled_In: __auto_42);
            }

            var Output_500 = Output_498.Update(Entity_Out: out n16.Entity Entity_499);
            n7.Matrix Transform_501 = n27._Operations_.CreateDefault();
            n7.Vector3.TransformCoordinate(coordinate: ref __pad_SodEdCVcG80NjIGqjqavha_23, transform: ref Transform_501, result: out n7.Vector3 Output_502);
            float Softness_503 = 0.01F;
            bool SetupLight_504 = true;
            var Output_505 = this.__p_G0oM3QInjsLQPW7P4SCcfW;
            if (SetupLight_504)
            {
                Output_505 = this.__p_G0oM3QInjsLQPW7P4SCcfW.SetupLight(Position_In: Output_502, Target_In: __pad_RW9OYBO3IM8Lg2QTIABaER_19, Color_In: __pad_NTVOzt1zxsAMRuUcT4rQ3a_24, Intensity_In: __pad_V30CePQwKYwNHr09PY39Mt_20, Range_In: __pad_ATw1UY2NJn9NpaRW2jUZlv_21, Angle_In: __pad_UE4AUm23ZMWLINVBXNGXtb_22, Softness_In: Softness_503);
            }

            n41.LightStandardShadowMap Shadow_506 = default(n41.LightStandardShadowMap);
            bool Enable_Default_Shadow_507 = true;
            bool SetShadow_508 = true;
            var Output_509 = Output_505;
            if (SetShadow_508)
            {
                Output_509 = Output_505.SetShadow(Shadow_In: Shadow_506, Enable_Default_Shadow_In: Enable_Default_Shadow_507);
            }

            n1.CompilationHelper.WritePin(this.__p_StHT1NNUzl5MiqEEGVHrc0.Inputs[0], ref __pad_G18HNH7XPdmPHbpzZo6y0L_26);
            n1.CompilationHelper.WritePin(this.__p_StHT1NNUzl5MiqEEGVHrc0.Inputs[1], ref __pad_PIZ0wY9DkpVPY1vc9LsaUp_27);
            n1.CompilationHelper.WritePin(this.__p_StHT1NNUzl5MiqEEGVHrc0.Inputs[2], ref __pad_GmIIGuL7uILMzUP6C1684w_28);
            n1.CompilationHelper.ReadPin(this.__p_StHT1NNUzl5MiqEEGVHrc0.Outputs[0], out n16.LightShaftComponent out_510);
            var builder_511 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k, 1);
            builder_511.Add(out_510);
            var __pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k_512 = builder_511.Commit();
            n23._Operations_.FromValue<n16.EntityComponent>(Input_In: __pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k_512, Result_Out: out n20.Spread<n16.EntityComponent> Result_513);
            bool SetComponent_514 = true;
            var Output_515 = Output_509;
            if (SetComponent_514)
            {
                Output_515 = Output_509.SetComponent(Component_In: Result_513);
            }

            bool Enabled_516 = true;
            bool SetEnabled_517 = true;
            var Output_518 = Output_515;
            if (SetEnabled_517)
            {
                Output_518 = Output_515.SetEnabled(Enabled_In: Enabled_516);
            }

            bool Show_Helper_519 = true;
            var Output_521 = Output_518.Update(Show_Helper_In: Show_Helper_519, Entity_Out: out n16.Entity Entity_520);
            bool SetTransformation_522 = true;
            var Output_523 = this.__p_LwRCLYxIu53PxSXTuvsgOV;
            if (SetTransformation_522)
            {
                Output_523 = this.__p_LwRCLYxIu53PxSXTuvsgOV.SetTransformation(Transformation_In: __auto_25);
            }

            n1.CompilationHelper.ReadPin(this.__p_NKNPlE5g1XKLBJ3Bl0r8X0.Outputs[0], out n9.Mesh out_524);
            var State_Output_526 = this.__p_DMnnH1Kf4EmLDBBBLj4GcT.Update(Mesh_In: out_524, Output_Out: out n9.Model Output_525);
            n1.CompilationHelper.WritePin(this.__p_ULmyB5dpbyaMdKdw0vpfDp.Inputs[0], ref Output_525);
            n1.CompilationHelper.WritePin(this.__p_ULmyB5dpbyaMdKdw0vpfDp.Inputs[1], ref out_510);
            n1.CompilationHelper.ReadPin(this.__p_ULmyB5dpbyaMdKdw0vpfDp.Outputs[0], out n16.LightShaftBoundingVolumeComponent out_527);
            n7.Matrix Transformation_528 = __c_DPyn6k03eLcPjAcffo4Wi1;
            n7.Color4 Color_529 = __c_DPlhH0NJFk2MiP8d5sZ5ex;
            var State_Output_531 = this.__p_Q5Ckc7j8dHwPDBxnaZhBgd.Update(Transformation_In: Transformation_528, Color_In: Color_529, Output_Out: out n10.MeshRenderer_C Output_530);
            n9.IGraphicsRendererBase Input_532 = (n9.IGraphicsRendererBase)Output_530;
            bool SetDrawer_533 = true;
            var Output_534 = this.__p_MdFqf5PXmLsMU2nO73hmMY;
            if (SetDrawer_533)
            {
                Output_534 = this.__p_MdFqf5PXmLsMU2nO73hmMY.SetDrawer(Input_In: Input_532);
            }

            bool SetEnabled_535 = true;
            var Output_536 = Output_534;
            if (SetEnabled_535)
            {
                Output_536 = Output_534.SetEnabled(Enabled_In: __pad_A5fMJXXXq30QRD492gR3qN_29);
            }

            var Output_538 = Output_536.GetComponent(Component_Out: out n6.EntityRendererComponent Component_537);
            var builder_539 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx, 2);
            builder_539.Add(out_527);
            builder_539.Add(Component_537);
            var __pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx_540 = builder_539.Commit();
            n23._Operations_.Cons<n16.EntityComponent>(Input_In: __pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx_540, Result_Out: out n20.Spread<n16.EntityComponent> Result_541);
            bool SetComponents_542 = true;
            var Output_543 = Output_523;
            if (SetComponents_542)
            {
                Output_543 = Output_523.SetComponents(Components_In: Result_541);
            }

            var State_Output_545 = Output_543.GetEntity(Output_Out: out n16.Entity Output_544);
            bool SetChildren_546 = true;
            var builder_547 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_B65LHCjZaSYPOpObti5hKp, 3);
            builder_547.Add(Entity_499);
            builder_547.Add(Entity_520);
            builder_547.Add(Output_544);
            var __pin_group_Child_In_B65LHCjZaSYPOpObti5hKp_548 = builder_547.Commit();
            var Output_549 = this.__p_B65LHCjZaSYPOpObti5hKp;
            if (SetChildren_546)
            {
                Output_549 = this.__p_B65LHCjZaSYPOpObti5hKp.SetChildren(Child_In: __pin_group_Child_In_B65LHCjZaSYPOpObti5hKp_548);
            }

            bool Enabled_550 = true;
            bool SetEnabled_551 = true;
            var Output_552 = Output_549;
            if (SetEnabled_551)
            {
                Output_552 = Output_549.SetEnabled(Enabled_In: Enabled_550);
            }

            var State_Output_554 = Output_552.Update(Output_Out: out n16.Entity Output_553);
            var builder_555 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw, 6);
            builder_555.Add(Output_249);
            builder_555.Add(Output_302);
            builder_555.Add(Output_372);
            builder_555.Add(Output_440);
            builder_555.Add(Output_476);
            builder_555.Add(Output_553);
            var __pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw_556 = builder_555.Commit();
            n22._Operations_.Switch<n16.Entity, n21.__AdaptiveImplementations__JPmuEharYwiLQs6dOuoEQQ>(Index_In: __pad_OJARAgZICF2L6ucXq8sFsh_155, Input_In: __pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw_556, Output_Out: out n16.Entity Output_557);
            bool SetChildren_558 = true;
            var builder_559 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G, 3);
            builder_559.Add(Output_192);
            builder_559.Add(Entity_153);
            builder_559.Add(Output_557);
            var __pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G_560 = builder_559.Commit();
            var Output_561 = this.__p_GO8HMpNlikDNYGhQCIAv8G;
            if (SetChildren_558)
            {
                Output_561 = this.__p_GO8HMpNlikDNYGhQCIAv8G.SetChildren(Child_In: __pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G_560);
            }

            var State_Output_563 = Output_561.Update(Output_Out: out n16.Entity Output_562);
            n1.CompilationHelper.WritePin(this.__p_CCRsbVu1Dw8On1sS2bLBuQ.Inputs[0], ref __pad_HSRNTIJGdVjLXpjTJRqoPx_43);
            n1.CompilationHelper.WritePin(this.__p_CCRsbVu1Dw8On1sS2bLBuQ.Inputs[1], ref __pad_DoGOVLnoGRHLuACY7NwcYq_44);
            n1.CompilationHelper.ReadPin(this.__p_CCRsbVu1Dw8On1sS2bLBuQ.Outputs[0], out n36.LightShafts out_564);
            bool SetColor_565 = true;
            var Output_566 = State_Output_148;
            if (SetColor_565)
            {
                Output_566 = State_Output_148.SetColor(Color_In: __pad_KJQf5gCDTFFLjvz9NELHkn_12);
            }

            bool SetMatalness_567 = true;
            var Output_568 = Output_566;
            if (SetMatalness_567)
            {
                Output_568 = Output_566.SetMatalness(Metalness_In: __pad_BADeqRYzlm8M2eFDJmyjqK_13);
            }

            bool SetRoughness_569 = true;
            var Output_570 = Output_568;
            if (SetRoughness_569)
            {
                Output_570 = Output_568.SetRoughness(Roughness_In: __pad_PVjXdUocZIPLwwKq2Gr4Um_14);
            }

            n7.Matrix __auto_571 = Output_164;
            Lights_Out = Output_562;
            PostFX_Out = __auto_51;
            LightShafts_Out = out_564;
            n4.LightStudios_Iu0D0SDDMseNZZodQPhpqH that_572 = this;
            if (this.__GetContext__().IsImmutable)
                that_572 = PostFX_Enabled_In != this.__slot_PHtPr62IPUNLhYzHWZVWON || this.__p_POI2G3HeNMPObLndUPeL1H != this.__p_POI2G3HeNMPObLndUPeL1H || state_52 != this.__if_Dxra1WEwF1hLxNGfl2D8lt || Show_Guide_In != this.__slot_NhXnrXGBOR6L5J1GNUxsjV || Output_154 != this.__p_U0z7CJxgjTwOi3BwfgMTKT || Output_570 != this.__p_KUOxKfQJDWOQUluNScNX67 || LightPreset_In != this.__slot_OJARAgZICF2L6ucXq8sFsh || Background_Enabled_In != this.Background_Enabled || State_Output_167 != this.__p_QuexozVp4iELOOPugFiTsc || Output_172 != this.__p_EdUxqYnbY29Ork1eOjzeI6 || __pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs_174 != this.__pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs || State_Output_181 != this.__p_CGVQbiWlZ6gMMXPGelynpi || State_Output_187 != this.__p_M7l9WCzq0kYLJR9eyFqCBP || __pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC_190 != this.__pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC || State_Output_193 != this.__p_JjeqbOoVZIUP04IXDC1ehC || Output_217 != this.__p_DsUYgcIgAqgNpIByjD5qry || Output_207 != this.__p_TnZGwyZOOAvLNsbG5YzGoo || Output_232 != this.__p_FCEGzRTSAY2O1ikFPemSw0 || this.__p_B6e5crkSWyBQah1Lbf5Xcx != this.__p_B6e5crkSWyBQah1Lbf5Xcx || this.__p_Dga49V9W4TTN8hChcfHnKM != this.__p_Dga49V9W4TTN8hChcfHnKM || Output_244 != this.__p_C406t4F9APFL7HLbeRZ9Ir || __pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9_247 != this.__pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9 || State_Output_250 != this.__p_RUFuwB5bt97LlcLQcPESV9 || Output_274 != this.__p_KkxFEvV6CdWMrZMkykhBMi || Output_264 != this.__p_CtoO6xEdfhdOTUjTpnNf8N || Output_285 != this.__p_QK7hngAdoaDN76tZOseXvN || Output_291 != this.__p_AKAzR4zLycYMkPcdO1se2V || Output_297 != this.__p_BkxLipNAhZKMEfU5vo2GnW || __pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20_300 != this.__pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20 || State_Output_303 != this.__p_KM1V4OUPbJoM9RMwCBqb20 || Output_327 != this.__p_FWyfZaT4PhkNyQJ8vguC5x || Output_317 != this.__p_LGArFWy3lqdOlbLn3s4kfp || Output_338 != this.__p_Nx0ogFUOMk0PjrK6d9Mx5Q || Output_346 != this.__p_VmBqYmSD1I0PiIuwqelTbJ || Output_348 != this.__slot_BZQwCBgn5JVOW9pS7IwzL5 || Output_357 != this.__p_PQwJhjYBk5KPlDxx3iMIWi || Output_367 != this.__p_SmR8pfakQuFM4Kb64PiXK7 || __pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw_370 != this.__pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw || State_Output_373 != this.__p_PnKXaDQXUdDQWKI1DJM6Sw || Output_397 != this.__p_HagAUNvLtbKOBDHJTMLDdk || Output_387 != this.__p_QQaemaNEegjLMVZVeE4JJc || Output_412 != this.__p_Ekau9A7qIKWPH3n4iukg3a || this.__p_N5QqZaAkdMTNMNFNdnVUoU != this.__p_N5QqZaAkdMTNMNFNdnVUoU || this.__p_BJ7Y5jADNNfPthHrqKfQHd != this.__p_BJ7Y5jADNNfPthHrqKfQHd || Output_423 != this.__p_R9T0bq9ZB8zPKD6mugiPMV || Output_434 != this.__p_HEb8kibmAUvPp7LCzqnh59 || __pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB_438 != this.__pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB || State_Output_441 != this.__p_EaGTrQGlWWnNkAf0vdkSCB || Output_456 != this.__p_QQyHwUHxbpGNiBaGFnCq31 || this.__p_CMmAcXMEPFcQGMBASpUfa4 != this.__p_CMmAcXMEPFcQGMBASpUfa4 || this.__p_TGaqE9XAoLvMIcFLRXc49a != this.__p_TGaqE9XAoLvMIcFLRXc49a || Output_467 != this.__p_SKrWf5e2Qh1NDQEgVEfFOB || __pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF_471 != this.__pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF || State_Output_477 != this.__p_AnySrXohzM4L9fzfb2yFWF || Output_500 != this.__p_Jb49oG861DPL87MSSAVVtT || Output_491 != this.__p_LhwmT3fbQU4L4uCcfkqBn8 || Output_521 != this.__p_G0oM3QInjsLQPW7P4SCcfW || this.__p_StHT1NNUzl5MiqEEGVHrc0 != this.__p_StHT1NNUzl5MiqEEGVHrc0 || __pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k_512 != this.__pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k || State_Output_545 != this.__p_LwRCLYxIu53PxSXTuvsgOV || this.__p_NKNPlE5g1XKLBJ3Bl0r8X0 != this.__p_NKNPlE5g1XKLBJ3Bl0r8X0 || State_Output_526 != this.__p_DMnnH1Kf4EmLDBBBLj4GcT || this.__p_ULmyB5dpbyaMdKdw0vpfDp != this.__p_ULmyB5dpbyaMdKdw0vpfDp || State_Output_531 != this.__p_Q5Ckc7j8dHwPDBxnaZhBgd || Output_538 != this.__p_MdFqf5PXmLsMU2nO73hmMY || __pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx_540 != this.__pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx || __pin_group_Child_In_B65LHCjZaSYPOpObti5hKp_548 != this.__pin_group_Child_In_B65LHCjZaSYPOpObti5hKp || State_Output_554 != this.__p_B65LHCjZaSYPOpObti5hKp || __pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw_556 != this.__pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw || __pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G_560 != this.__pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G || State_Output_563 != this.__p_GO8HMpNlikDNYGhQCIAv8G || this.__p_CCRsbVu1Dw8On1sS2bLBuQ != this.__p_CCRsbVu1Dw8On1sS2bLBuQ || !n13.EqualityComparer<n7.Matrix>.Default.Equals(Output_164, this.BBox) ? new LightStudios_Iu0D0SDDMseNZZodQPhpqH(this)
                {__slot_PHtPr62IPUNLhYzHWZVWON = PostFX_Enabled_In, __p_POI2G3HeNMPObLndUPeL1H = this.__p_POI2G3HeNMPObLndUPeL1H, __if_Dxra1WEwF1hLxNGfl2D8lt = state_52, __slot_NhXnrXGBOR6L5J1GNUxsjV = Show_Guide_In, __p_U0z7CJxgjTwOi3BwfgMTKT = Output_154, __p_KUOxKfQJDWOQUluNScNX67 = Output_570, __slot_OJARAgZICF2L6ucXq8sFsh = LightPreset_In, Background_Enabled = Background_Enabled_In, __p_QuexozVp4iELOOPugFiTsc = State_Output_167, __p_EdUxqYnbY29Ork1eOjzeI6 = Output_172, __pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs = __pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs_174, __p_CGVQbiWlZ6gMMXPGelynpi = State_Output_181, __p_M7l9WCzq0kYLJR9eyFqCBP = State_Output_187, __pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC = __pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC_190, __p_JjeqbOoVZIUP04IXDC1ehC = State_Output_193, __p_DsUYgcIgAqgNpIByjD5qry = Output_217, __p_TnZGwyZOOAvLNsbG5YzGoo = Output_207, __p_FCEGzRTSAY2O1ikFPemSw0 = Output_232, __p_B6e5crkSWyBQah1Lbf5Xcx = this.__p_B6e5crkSWyBQah1Lbf5Xcx, __p_Dga49V9W4TTN8hChcfHnKM = this.__p_Dga49V9W4TTN8hChcfHnKM, __p_C406t4F9APFL7HLbeRZ9Ir = Output_244, __pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9 = __pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9_247, __p_RUFuwB5bt97LlcLQcPESV9 = State_Output_250, __p_KkxFEvV6CdWMrZMkykhBMi = Output_274, __p_CtoO6xEdfhdOTUjTpnNf8N = Output_264, __p_QK7hngAdoaDN76tZOseXvN = Output_285, __p_AKAzR4zLycYMkPcdO1se2V = Output_291, __p_BkxLipNAhZKMEfU5vo2GnW = Output_297, __pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20 = __pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20_300, __p_KM1V4OUPbJoM9RMwCBqb20 = State_Output_303, __p_FWyfZaT4PhkNyQJ8vguC5x = Output_327, __p_LGArFWy3lqdOlbLn3s4kfp = Output_317, __p_Nx0ogFUOMk0PjrK6d9Mx5Q = Output_338, __p_VmBqYmSD1I0PiIuwqelTbJ = Output_346, __slot_BZQwCBgn5JVOW9pS7IwzL5 = Output_348, __p_PQwJhjYBk5KPlDxx3iMIWi = Output_357, __p_SmR8pfakQuFM4Kb64PiXK7 = Output_367, __pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw = __pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw_370, __p_PnKXaDQXUdDQWKI1DJM6Sw = State_Output_373, __p_HagAUNvLtbKOBDHJTMLDdk = Output_397, __p_QQaemaNEegjLMVZVeE4JJc = Output_387, __p_Ekau9A7qIKWPH3n4iukg3a = Output_412, __p_N5QqZaAkdMTNMNFNdnVUoU = this.__p_N5QqZaAkdMTNMNFNdnVUoU, __p_BJ7Y5jADNNfPthHrqKfQHd = this.__p_BJ7Y5jADNNfPthHrqKfQHd, __p_R9T0bq9ZB8zPKD6mugiPMV = Output_423, __p_HEb8kibmAUvPp7LCzqnh59 = Output_434, __pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB = __pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB_438, __p_EaGTrQGlWWnNkAf0vdkSCB = State_Output_441, __p_QQyHwUHxbpGNiBaGFnCq31 = Output_456, __p_CMmAcXMEPFcQGMBASpUfa4 = this.__p_CMmAcXMEPFcQGMBASpUfa4, __p_TGaqE9XAoLvMIcFLRXc49a = this.__p_TGaqE9XAoLvMIcFLRXc49a, __p_SKrWf5e2Qh1NDQEgVEfFOB = Output_467, __pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF = __pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF_471, __p_AnySrXohzM4L9fzfb2yFWF = State_Output_477, __p_Jb49oG861DPL87MSSAVVtT = Output_500, __p_LhwmT3fbQU4L4uCcfkqBn8 = Output_491, __p_G0oM3QInjsLQPW7P4SCcfW = Output_521, __p_StHT1NNUzl5MiqEEGVHrc0 = this.__p_StHT1NNUzl5MiqEEGVHrc0, __pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k = __pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k_512, __p_LwRCLYxIu53PxSXTuvsgOV = State_Output_545, __p_NKNPlE5g1XKLBJ3Bl0r8X0 = this.__p_NKNPlE5g1XKLBJ3Bl0r8X0, __p_DMnnH1Kf4EmLDBBBLj4GcT = State_Output_526, __p_ULmyB5dpbyaMdKdw0vpfDp = this.__p_ULmyB5dpbyaMdKdw0vpfDp, __p_Q5Ckc7j8dHwPDBxnaZhBgd = State_Output_531, __p_MdFqf5PXmLsMU2nO73hmMY = Output_538, __pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx = __pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx_540, __pin_group_Child_In_B65LHCjZaSYPOpObti5hKp = __pin_group_Child_In_B65LHCjZaSYPOpObti5hKp_548, __p_B65LHCjZaSYPOpObti5hKp = State_Output_554, __pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw = __pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw_556, __pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G = __pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G_560, __p_GO8HMpNlikDNYGhQCIAv8G = State_Output_563, __p_CCRsbVu1Dw8On1sS2bLBuQ = this.__p_CCRsbVu1Dw8On1sS2bLBuQ, BBox = Output_164} : that_572;
            else
            {
                this.__slot_PHtPr62IPUNLhYzHWZVWON = PostFX_Enabled_In;
                this.__p_POI2G3HeNMPObLndUPeL1H = this.__p_POI2G3HeNMPObLndUPeL1H;
                this.__if_Dxra1WEwF1hLxNGfl2D8lt = state_52;
                this.__slot_NhXnrXGBOR6L5J1GNUxsjV = Show_Guide_In;
                this.__p_U0z7CJxgjTwOi3BwfgMTKT = Output_154;
                this.__p_KUOxKfQJDWOQUluNScNX67 = Output_570;
                this.__slot_OJARAgZICF2L6ucXq8sFsh = LightPreset_In;
                this.Background_Enabled = Background_Enabled_In;
                this.__p_QuexozVp4iELOOPugFiTsc = State_Output_167;
                this.__p_EdUxqYnbY29Ork1eOjzeI6 = Output_172;
                this.__pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs = __pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs_174;
                this.__p_CGVQbiWlZ6gMMXPGelynpi = State_Output_181;
                this.__p_M7l9WCzq0kYLJR9eyFqCBP = State_Output_187;
                this.__pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC = __pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC_190;
                this.__p_JjeqbOoVZIUP04IXDC1ehC = State_Output_193;
                this.__p_DsUYgcIgAqgNpIByjD5qry = Output_217;
                this.__p_TnZGwyZOOAvLNsbG5YzGoo = Output_207;
                this.__p_FCEGzRTSAY2O1ikFPemSw0 = Output_232;
                this.__p_B6e5crkSWyBQah1Lbf5Xcx = this.__p_B6e5crkSWyBQah1Lbf5Xcx;
                this.__p_Dga49V9W4TTN8hChcfHnKM = this.__p_Dga49V9W4TTN8hChcfHnKM;
                this.__p_C406t4F9APFL7HLbeRZ9Ir = Output_244;
                this.__pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9 = __pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9_247;
                this.__p_RUFuwB5bt97LlcLQcPESV9 = State_Output_250;
                this.__p_KkxFEvV6CdWMrZMkykhBMi = Output_274;
                this.__p_CtoO6xEdfhdOTUjTpnNf8N = Output_264;
                this.__p_QK7hngAdoaDN76tZOseXvN = Output_285;
                this.__p_AKAzR4zLycYMkPcdO1se2V = Output_291;
                this.__p_BkxLipNAhZKMEfU5vo2GnW = Output_297;
                this.__pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20 = __pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20_300;
                this.__p_KM1V4OUPbJoM9RMwCBqb20 = State_Output_303;
                this.__p_FWyfZaT4PhkNyQJ8vguC5x = Output_327;
                this.__p_LGArFWy3lqdOlbLn3s4kfp = Output_317;
                this.__p_Nx0ogFUOMk0PjrK6d9Mx5Q = Output_338;
                this.__p_VmBqYmSD1I0PiIuwqelTbJ = Output_346;
                this.__slot_BZQwCBgn5JVOW9pS7IwzL5 = Output_348;
                this.__p_PQwJhjYBk5KPlDxx3iMIWi = Output_357;
                this.__p_SmR8pfakQuFM4Kb64PiXK7 = Output_367;
                this.__pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw = __pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw_370;
                this.__p_PnKXaDQXUdDQWKI1DJM6Sw = State_Output_373;
                this.__p_HagAUNvLtbKOBDHJTMLDdk = Output_397;
                this.__p_QQaemaNEegjLMVZVeE4JJc = Output_387;
                this.__p_Ekau9A7qIKWPH3n4iukg3a = Output_412;
                this.__p_N5QqZaAkdMTNMNFNdnVUoU = this.__p_N5QqZaAkdMTNMNFNdnVUoU;
                this.__p_BJ7Y5jADNNfPthHrqKfQHd = this.__p_BJ7Y5jADNNfPthHrqKfQHd;
                this.__p_R9T0bq9ZB8zPKD6mugiPMV = Output_423;
                this.__p_HEb8kibmAUvPp7LCzqnh59 = Output_434;
                this.__pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB = __pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB_438;
                this.__p_EaGTrQGlWWnNkAf0vdkSCB = State_Output_441;
                this.__p_QQyHwUHxbpGNiBaGFnCq31 = Output_456;
                this.__p_CMmAcXMEPFcQGMBASpUfa4 = this.__p_CMmAcXMEPFcQGMBASpUfa4;
                this.__p_TGaqE9XAoLvMIcFLRXc49a = this.__p_TGaqE9XAoLvMIcFLRXc49a;
                this.__p_SKrWf5e2Qh1NDQEgVEfFOB = Output_467;
                this.__pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF = __pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF_471;
                this.__p_AnySrXohzM4L9fzfb2yFWF = State_Output_477;
                this.__p_Jb49oG861DPL87MSSAVVtT = Output_500;
                this.__p_LhwmT3fbQU4L4uCcfkqBn8 = Output_491;
                this.__p_G0oM3QInjsLQPW7P4SCcfW = Output_521;
                this.__p_StHT1NNUzl5MiqEEGVHrc0 = this.__p_StHT1NNUzl5MiqEEGVHrc0;
                this.__pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k = __pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k_512;
                this.__p_LwRCLYxIu53PxSXTuvsgOV = State_Output_545;
                this.__p_NKNPlE5g1XKLBJ3Bl0r8X0 = this.__p_NKNPlE5g1XKLBJ3Bl0r8X0;
                this.__p_DMnnH1Kf4EmLDBBBLj4GcT = State_Output_526;
                this.__p_ULmyB5dpbyaMdKdw0vpfDp = this.__p_ULmyB5dpbyaMdKdw0vpfDp;
                this.__p_Q5Ckc7j8dHwPDBxnaZhBgd = State_Output_531;
                this.__p_MdFqf5PXmLsMU2nO73hmMY = Output_538;
                this.__pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx = __pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx_540;
                this.__pin_group_Child_In_B65LHCjZaSYPOpObti5hKp = __pin_group_Child_In_B65LHCjZaSYPOpObti5hKp_548;
                this.__p_B65LHCjZaSYPOpObti5hKp = State_Output_554;
                this.__pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw = __pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw_556;
                this.__pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G = __pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G_560;
                this.__p_GO8HMpNlikDNYGhQCIAv8G = State_Output_563;
                this.__p_CCRsbVu1Dw8On1sS2bLBuQ = this.__p_CCRsbVu1Dw8On1sS2bLBuQ;
                this.BBox = Output_164;
            }

            return that_572;
        }

        public n4.LightStudios_Iu0D0SDDMseNZZodQPhpqH __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "DsUYgcIgAqgNpIByjD5qry", 315551U);
            var Output_1 = n49.SkyboxLight_C.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "TnZGwyZOOAvLNsbG5YzGoo", 315578U);
            var Output_3 = n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "FCEGzRTSAY2O1ikFPemSw0", 315604U);
            var Output_5 = n49.DirectionalLight_C.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "GO8HMpNlikDNYGhQCIAv8G", 315636U);
            var Output_7 = n30.Group_TqwCZl6Gra4OmgvUg1POgm.Create(Node_Context: Node_Context_6);
            var node_8 = n1.CompilationHelper.CreateNodeById(Node_Context, "LightDirectionalShadowMap", "Stride.Lights.Advanced.ShadowMaps");
            var node_9 = n1.CompilationHelper.CreateNodeById(Node_Context, "LightShadowMapFilterTypePcf", "Stride.Lights.Advanced.ShadowMaps");
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "U0z7CJxgjTwOi3BwfgMTKT", 315704U);
            var Output_11 = n17.Plane_C.Create(Node_Context: Node_Context_10);
            n1.NodeContext Node_Context_12 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "CGVQbiWlZ6gMMXPGelynpi", 315752U);
            string Initial_Name_13 = "";
            n13.IEnumerable<n16.EntityComponent> Base_Components_14 = n51._Operations_.CreateDefault<n16.EntityComponent>();
            var Output_15 = n30.Entity_OfyExcqEe4CPH8Wq0L8jzv.Create(Node_Context: Node_Context_12, Initial_Name_In: Initial_Name_13, Base_Components_In: Base_Components_14);
            n1.NodeContext Node_Context_16 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "QuexozVp4iELOOPugFiTsc", 315766U);
            var Output_17 = n52.BoxFrameRenderer_KnIeAhvGyP7OturynhaRbP.Create(Node_Context: Node_Context_16);
            n1.NodeContext Node_Context_18 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "EdUxqYnbY29Ork1eOjzeI6", 315776U);
            var Output_19 = n37.RenderComponent_LYdoKoeCq7MPXOIsyysl4d.Create(Node_Context: Node_Context_18);
            n1.NodeContext Node_Context_20 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "RUFuwB5bt97LlcLQcPESV9", 315908U);
            var Output_21 = n30.Group_TqwCZl6Gra4OmgvUg1POgm.Create(Node_Context: Node_Context_20);
            n1.NodeContext Node_Context_22 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "M7l9WCzq0kYLJR9eyFqCBP", 315930U);
            var Output_23 = n53.AxisAndGrid_UVYBbYPB2FTPRFmVzqosNK.Create(Node_Context: Node_Context_22);
            n1.NodeContext Node_Context_24 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "JjeqbOoVZIUP04IXDC1ehC", 315946U);
            var Output_25 = n30.Group_TqwCZl6Gra4OmgvUg1POgm.Create(Node_Context: Node_Context_24);
            n1.NodeContext Node_Context_26 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "QK7hngAdoaDN76tZOseXvN", 316258U);
            var Output_27 = n49.DirectionalLight_C.Create(Node_Context: Node_Context_26);
            n1.NodeContext Node_Context_28 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "KkxFEvV6CdWMrZMkykhBMi", 316270U);
            var Output_29 = n49.SkyboxLight_C.Create(Node_Context: Node_Context_28);
            n1.NodeContext Node_Context_30 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "CtoO6xEdfhdOTUjTpnNf8N", 316283U);
            var Output_31 = n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z.Create(Node_Context: Node_Context_30);
            n1.NodeContext Node_Context_32 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "KM1V4OUPbJoM9RMwCBqb20", 316293U);
            var Output_33 = n30.Group_TqwCZl6Gra4OmgvUg1POgm.Create(Node_Context: Node_Context_32);
            n1.NodeContext Node_Context_34 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "AKAzR4zLycYMkPcdO1se2V", 316302U);
            var Output_35 = n49.AmbientLight_C.Create(Node_Context: Node_Context_34);
            n1.NodeContext Node_Context_36 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "BkxLipNAhZKMEfU5vo2GnW", 316309U);
            var Output_37 = n49.DirectionalLight_C.Create(Node_Context: Node_Context_36);
            n1.NodeContext Node_Context_38 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "KUOxKfQJDWOQUluNScNX67", 316321U);
            var Output_39 = n54.PBRMaterial_C.Create(Node_Context: Node_Context_38);
            n1.NodeContext Node_Context_40 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "FWyfZaT4PhkNyQJ8vguC5x", 316342U);
            var Output_41 = n49.SkyboxLight_C.Create(Node_Context: Node_Context_40);
            n1.NodeContext Node_Context_42 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "LGArFWy3lqdOlbLn3s4kfp", 316355U);
            var Output_43 = n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z.Create(Node_Context: Node_Context_42);
            n1.NodeContext Node_Context_44 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Nx0ogFUOMk0PjrK6d9Mx5Q", 316371U);
            var Output_45 = n49.DirectionalLight_C.Create(Node_Context: Node_Context_44);
            n1.NodeContext Node_Context_46 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "PnKXaDQXUdDQWKI1DJM6Sw", 316384U);
            var Output_47 = n30.Group_TqwCZl6Gra4OmgvUg1POgm.Create(Node_Context: Node_Context_46);
            n1.NodeContext Node_Context_48 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "G0oM3QInjsLQPW7P4SCcfW", 316411U);
            var Output_49 = n49.SpotLight_C.Create(Node_Context: Node_Context_48);
            n1.NodeContext Node_Context_50 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "LwRCLYxIu53PxSXTuvsgOV", 316426U);
            string Initial_Name_51 = "";
            n13.IEnumerable<n16.EntityComponent> Base_Components_52 = n51._Operations_.CreateDefault<n16.EntityComponent>();
            var Output_53 = n30.Entity_OfyExcqEe4CPH8Wq0L8jzv.Create(Node_Context: Node_Context_50, Initial_Name_In: Initial_Name_51, Base_Components_In: Base_Components_52);
            n1.NodeContext Node_Context_54 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "B65LHCjZaSYPOpObti5hKp", 316433U);
            var Output_55 = n30.Group_TqwCZl6Gra4OmgvUg1POgm.Create(Node_Context: Node_Context_54);
            var node_56 = n1.CompilationHelper.CreateNodeById(Node_Context, "LightShaftComponent", "Stride.Lights.Advanced");
            var node_57 = n1.CompilationHelper.CreateNodeById(Node_Context, "LightShaftBoundingVolumeComponent", "Stride.Lights.Advanced");
            n1.NodeContext Node_Context_58 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "DMnnH1Kf4EmLDBBBLj4GcT", 316456U);
            var Output_59 = n55.MeshModel_IM96OF8Pn3tLaQml9JGZT1.Create(Node_Context: Node_Context_58);
            var node_60 = n1.CompilationHelper.CreateNodeById(Node_Context, "BoxMesh", "Stride.Models.Meshes");
            n1.NodeContext Node_Context_61 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Q5Ckc7j8dHwPDBxnaZhBgd", 316473U);
            var Output_62 = n52.BoxFrameRenderer_KnIeAhvGyP7OturynhaRbP.Create(Node_Context: Node_Context_61);
            n1.NodeContext Node_Context_63 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "MdFqf5PXmLsMU2nO73hmMY", 316477U);
            var Output_64 = n37.RenderComponent_LYdoKoeCq7MPXOIsyysl4d.Create(Node_Context: Node_Context_63);
            var node_65 = n1.CompilationHelper.CreateNodeById(Node_Context, "Hejl2", "Stride.Rendering.PostFX.ColorTransforms.ToneMapOperators");
            n1.NodeContext Node_Context_66 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "PQwJhjYBk5KPlDxx3iMIWi", 316491U);
            var Output_67 = n49.PointLight_C.Create(Node_Context: Node_Context_66);
            n1.NodeContext Node_Context_68 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "VmBqYmSD1I0PiIuwqelTbJ", 316509U);
            n57.IFrameClock Clock_69 = n56._Operations_.CreateDefault();
            var Output_70 = n58.LFO_F48sA9CC7kzM1Y1LIpWRrD.Create(Node_Context: Node_Context_68, Clock_In: Clock_69);
            n1.NodeContext Node_Context_71 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "SmR8pfakQuFM4Kb64PiXK7", 316517U);
            var Output_72 = n49.SpotLight_C.Create(Node_Context: Node_Context_71);
            n1.NodeContext Node_Context_73 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "EaGTrQGlWWnNkAf0vdkSCB", 316534U);
            var Output_74 = n30.Group_TqwCZl6Gra4OmgvUg1POgm.Create(Node_Context: Node_Context_73);
            n1.NodeContext Node_Context_75 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Ekau9A7qIKWPH3n4iukg3a", 316544U);
            var Output_76 = n49.DirectionalLight_C.Create(Node_Context: Node_Context_75);
            n1.NodeContext Node_Context_77 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "HagAUNvLtbKOBDHJTMLDdk", 316556U);
            var Output_78 = n49.SkyboxLight_C.Create(Node_Context: Node_Context_77);
            n1.NodeContext Node_Context_79 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "QQaemaNEegjLMVZVeE4JJc", 316569U);
            var Output_80 = n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z.Create(Node_Context: Node_Context_79);
            n1.NodeContext Node_Context_81 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "R9T0bq9ZB8zPKD6mugiPMV", 316585U);
            var Output_82 = n49.SpotLight_C.Create(Node_Context: Node_Context_81);
            n1.NodeContext Node_Context_83 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "HEb8kibmAUvPp7LCzqnh59", 316601U);
            var Output_84 = n49.SpotLight_C.Create(Node_Context: Node_Context_83);
            n1.NodeContext Node_Context_85 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Jb49oG861DPL87MSSAVVtT", 316617U);
            var Output_86 = n49.SkyboxLight_C.Create(Node_Context: Node_Context_85);
            n1.NodeContext Node_Context_87 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "LhwmT3fbQU4L4uCcfkqBn8", 316630U);
            var Output_88 = n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z.Create(Node_Context: Node_Context_87);
            n1.NodeContext Node_Context_89 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "C406t4F9APFL7HLbeRZ9Ir", 316647U);
            var Output_90 = n49.SpotLight_C.Create(Node_Context: Node_Context_89);
            var node_91 = n1.CompilationHelper.CreateNodeById(Node_Context, "LightShafts", "Stride.Rendering.Advanced.Compositing");
            var node_92 = n1.CompilationHelper.CreateNodeById(Node_Context, "LightDirectionalShadowMap", "Stride.Lights.Advanced.ShadowMaps");
            var node_93 = n1.CompilationHelper.CreateNodeById(Node_Context, "LightShadowMapFilterTypePcf", "Stride.Lights.Advanced.ShadowMaps");
            n1.NodeContext Node_Context_94 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "QQyHwUHxbpGNiBaGFnCq31", 316696U);
            var Output_95 = n49.DirectionalLight_C.Create(Node_Context: Node_Context_94);
            n1.NodeContext Node_Context_96 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "SKrWf5e2Qh1NDQEgVEfFOB", 316708U);
            var Output_97 = n49.SkyboxLight_C.Create(Node_Context: Node_Context_96);
            var node_98 = n1.CompilationHelper.CreateNodeById(Node_Context, "LightDirectionalShadowMap", "Stride.Lights.Advanced.ShadowMaps");
            var node_99 = n1.CompilationHelper.CreateNodeById(Node_Context, "LightShadowMapFilterTypePcf", "Stride.Lights.Advanced.ShadowMaps");
            n1.NodeContext Node_Context_100 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "AnySrXohzM4L9fzfb2yFWF", 316768U);
            var Output_101 = n30.Group_TqwCZl6Gra4OmgvUg1POgm.Create(Node_Context: Node_Context_100);
            n4.LightStudios_Iu0D0SDDMseNZZodQPhpqH that_102 = this;
            this.__slot_NhXnrXGBOR6L5J1GNUxsjV = false;
            this.__slot_PHtPr62IPUNLhYzHWZVWON = false;
            this.__slot_OJARAgZICF2L6ucXq8sFsh = 0;
            this.__slot_BZQwCBgn5JVOW9pS7IwzL5 = n44._Operations_.CreateDefault();
            this.BBox = n27._Operations_.CreateDefault();
            this.Background_Enabled = false;
            this.__pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs = n23._Operations_.CreateDefault<n16.EntityComponent>();
            this.__pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9 = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20 = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k = n23._Operations_.CreateDefault<n16.EntityComponent>();
            this.__pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx = n23._Operations_.CreateDefault<n16.EntityComponent>();
            this.__pin_group_Child_In_B65LHCjZaSYPOpObti5hKp = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G = n23._Operations_.CreateDefault<n16.Entity>();
            this.__p_DsUYgcIgAqgNpIByjD5qry = Output_1;
            this.__p_TnZGwyZOOAvLNsbG5YzGoo = Output_3;
            this.__p_FCEGzRTSAY2O1ikFPemSw0 = Output_5;
            this.__p_GO8HMpNlikDNYGhQCIAv8G = Output_7;
            this.__p_Dga49V9W4TTN8hChcfHnKM = node_8;
            this.__p_B6e5crkSWyBQah1Lbf5Xcx = node_9;
            this.__p_U0z7CJxgjTwOi3BwfgMTKT = Output_11;
            this.__p_CGVQbiWlZ6gMMXPGelynpi = Output_15;
            this.__p_QuexozVp4iELOOPugFiTsc = Output_17;
            this.__p_EdUxqYnbY29Ork1eOjzeI6 = Output_19;
            this.__p_RUFuwB5bt97LlcLQcPESV9 = Output_21;
            this.__p_M7l9WCzq0kYLJR9eyFqCBP = Output_23;
            this.__p_JjeqbOoVZIUP04IXDC1ehC = Output_25;
            this.__p_QK7hngAdoaDN76tZOseXvN = Output_27;
            this.__p_KkxFEvV6CdWMrZMkykhBMi = Output_29;
            this.__p_CtoO6xEdfhdOTUjTpnNf8N = Output_31;
            this.__p_KM1V4OUPbJoM9RMwCBqb20 = Output_33;
            this.__p_AKAzR4zLycYMkPcdO1se2V = Output_35;
            this.__p_BkxLipNAhZKMEfU5vo2GnW = Output_37;
            this.__p_KUOxKfQJDWOQUluNScNX67 = Output_39;
            this.__p_FWyfZaT4PhkNyQJ8vguC5x = Output_41;
            this.__p_LGArFWy3lqdOlbLn3s4kfp = Output_43;
            this.__p_Nx0ogFUOMk0PjrK6d9Mx5Q = Output_45;
            this.__p_PnKXaDQXUdDQWKI1DJM6Sw = Output_47;
            this.__p_G0oM3QInjsLQPW7P4SCcfW = Output_49;
            this.__p_LwRCLYxIu53PxSXTuvsgOV = Output_53;
            this.__p_B65LHCjZaSYPOpObti5hKp = Output_55;
            this.__p_StHT1NNUzl5MiqEEGVHrc0 = node_56;
            this.__p_ULmyB5dpbyaMdKdw0vpfDp = node_57;
            this.__p_DMnnH1Kf4EmLDBBBLj4GcT = Output_59;
            this.__p_NKNPlE5g1XKLBJ3Bl0r8X0 = node_60;
            this.__p_Q5Ckc7j8dHwPDBxnaZhBgd = Output_62;
            this.__p_MdFqf5PXmLsMU2nO73hmMY = Output_64;
            this.__p_POI2G3HeNMPObLndUPeL1H = node_65;
            this.__p_PQwJhjYBk5KPlDxx3iMIWi = Output_67;
            this.__p_VmBqYmSD1I0PiIuwqelTbJ = Output_70;
            this.__p_SmR8pfakQuFM4Kb64PiXK7 = Output_72;
            this.__p_EaGTrQGlWWnNkAf0vdkSCB = Output_74;
            this.__p_Ekau9A7qIKWPH3n4iukg3a = Output_76;
            this.__p_HagAUNvLtbKOBDHJTMLDdk = Output_78;
            this.__p_QQaemaNEegjLMVZVeE4JJc = Output_80;
            this.__p_R9T0bq9ZB8zPKD6mugiPMV = Output_82;
            this.__p_HEb8kibmAUvPp7LCzqnh59 = Output_84;
            this.__p_Jb49oG861DPL87MSSAVVtT = Output_86;
            this.__p_LhwmT3fbQU4L4uCcfkqBn8 = Output_88;
            this.__p_C406t4F9APFL7HLbeRZ9Ir = Output_90;
            this.__p_CCRsbVu1Dw8On1sS2bLBuQ = node_91;
            this.__p_BJ7Y5jADNNfPthHrqKfQHd = node_92;
            this.__p_N5QqZaAkdMTNMNFNdnVUoU = node_93;
            this.__p_QQyHwUHxbpGNiBaGFnCq31 = Output_95;
            this.__p_SKrWf5e2Qh1NDQEgVEfFOB = Output_97;
            this.__p_TGaqE9XAoLvMIcFLRXc49a = node_98;
            this.__p_CMmAcXMEPFcQGMBASpUfa4 = node_99;
            this.__p_AnySrXohzM4L9fzfb2yFWF = Output_101;
            this.__if_Dxra1WEwF1hLxNGfl2D8lt = default(n2.Object);
            return that_102;
        }

        public n4.LightStudios_Iu0D0SDDMseNZZodQPhpqH __CreateDefault__()
        {
            n4.LightStudios_Iu0D0SDDMseNZZodQPhpqH that_0 = this;
            this.__slot_NhXnrXGBOR6L5J1GNUxsjV = false;
            this.__slot_PHtPr62IPUNLhYzHWZVWON = false;
            this.__slot_OJARAgZICF2L6ucXq8sFsh = 0;
            this.__slot_BZQwCBgn5JVOW9pS7IwzL5 = n44._Operations_.CreateDefault();
            this.BBox = n27._Operations_.CreateDefault();
            this.Background_Enabled = false;
            this.__pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs = n23._Operations_.CreateDefault<n16.EntityComponent>();
            this.__pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9 = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20 = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k = n23._Operations_.CreateDefault<n16.EntityComponent>();
            this.__pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx = n23._Operations_.CreateDefault<n16.EntityComponent>();
            this.__pin_group_Child_In_B65LHCjZaSYPOpObti5hKp = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw = n23._Operations_.CreateDefault<n16.Entity>();
            this.__pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G = n23._Operations_.CreateDefault<n16.Entity>();
            this.__p_POI2G3HeNMPObLndUPeL1H = default(n1.IVLNode);
            this.__if_Dxra1WEwF1hLxNGfl2D8lt = default(n2.Object);
            this.__p_U0z7CJxgjTwOi3BwfgMTKT = n17.Plane_C.CreateDefault();
            this.__p_KUOxKfQJDWOQUluNScNX67 = n54.PBRMaterial_C.CreateDefault();
            this.__p_QuexozVp4iELOOPugFiTsc = n52.BoxFrameRenderer_KnIeAhvGyP7OturynhaRbP.CreateDefault();
            this.__p_EdUxqYnbY29Ork1eOjzeI6 = n37.RenderComponent_LYdoKoeCq7MPXOIsyysl4d.CreateDefault();
            this.__p_CGVQbiWlZ6gMMXPGelynpi = n30.Entity_OfyExcqEe4CPH8Wq0L8jzv.CreateDefault();
            this.__p_M7l9WCzq0kYLJR9eyFqCBP = n53.AxisAndGrid_UVYBbYPB2FTPRFmVzqosNK.CreateDefault();
            this.__p_JjeqbOoVZIUP04IXDC1ehC = n30.Group_TqwCZl6Gra4OmgvUg1POgm.CreateDefault();
            this.__p_DsUYgcIgAqgNpIByjD5qry = n49.SkyboxLight_C.CreateDefault();
            this.__p_TnZGwyZOOAvLNsbG5YzGoo = n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z.CreateDefault();
            this.__p_FCEGzRTSAY2O1ikFPemSw0 = n49.DirectionalLight_C.CreateDefault();
            this.__p_B6e5crkSWyBQah1Lbf5Xcx = default(n1.IVLNode);
            this.__p_Dga49V9W4TTN8hChcfHnKM = default(n1.IVLNode);
            this.__p_C406t4F9APFL7HLbeRZ9Ir = n49.SpotLight_C.CreateDefault();
            this.__p_RUFuwB5bt97LlcLQcPESV9 = n30.Group_TqwCZl6Gra4OmgvUg1POgm.CreateDefault();
            this.__p_KkxFEvV6CdWMrZMkykhBMi = n49.SkyboxLight_C.CreateDefault();
            this.__p_CtoO6xEdfhdOTUjTpnNf8N = n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z.CreateDefault();
            this.__p_QK7hngAdoaDN76tZOseXvN = n49.DirectionalLight_C.CreateDefault();
            this.__p_AKAzR4zLycYMkPcdO1se2V = n49.AmbientLight_C.CreateDefault();
            this.__p_BkxLipNAhZKMEfU5vo2GnW = n49.DirectionalLight_C.CreateDefault();
            this.__p_KM1V4OUPbJoM9RMwCBqb20 = n30.Group_TqwCZl6Gra4OmgvUg1POgm.CreateDefault();
            this.__p_FWyfZaT4PhkNyQJ8vguC5x = n49.SkyboxLight_C.CreateDefault();
            this.__p_LGArFWy3lqdOlbLn3s4kfp = n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z.CreateDefault();
            this.__p_Nx0ogFUOMk0PjrK6d9Mx5Q = n49.DirectionalLight_C.CreateDefault();
            this.__p_VmBqYmSD1I0PiIuwqelTbJ = n58.LFO_F48sA9CC7kzM1Y1LIpWRrD.CreateDefault();
            this.__p_PQwJhjYBk5KPlDxx3iMIWi = n49.PointLight_C.CreateDefault();
            this.__p_SmR8pfakQuFM4Kb64PiXK7 = n49.SpotLight_C.CreateDefault();
            this.__p_PnKXaDQXUdDQWKI1DJM6Sw = n30.Group_TqwCZl6Gra4OmgvUg1POgm.CreateDefault();
            this.__p_HagAUNvLtbKOBDHJTMLDdk = n49.SkyboxLight_C.CreateDefault();
            this.__p_QQaemaNEegjLMVZVeE4JJc = n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z.CreateDefault();
            this.__p_Ekau9A7qIKWPH3n4iukg3a = n49.DirectionalLight_C.CreateDefault();
            this.__p_N5QqZaAkdMTNMNFNdnVUoU = default(n1.IVLNode);
            this.__p_BJ7Y5jADNNfPthHrqKfQHd = default(n1.IVLNode);
            this.__p_R9T0bq9ZB8zPKD6mugiPMV = n49.SpotLight_C.CreateDefault();
            this.__p_HEb8kibmAUvPp7LCzqnh59 = n49.SpotLight_C.CreateDefault();
            this.__p_EaGTrQGlWWnNkAf0vdkSCB = n30.Group_TqwCZl6Gra4OmgvUg1POgm.CreateDefault();
            this.__p_QQyHwUHxbpGNiBaGFnCq31 = n49.DirectionalLight_C.CreateDefault();
            this.__p_CMmAcXMEPFcQGMBASpUfa4 = default(n1.IVLNode);
            this.__p_TGaqE9XAoLvMIcFLRXc49a = default(n1.IVLNode);
            this.__p_SKrWf5e2Qh1NDQEgVEfFOB = n49.SkyboxLight_C.CreateDefault();
            this.__p_AnySrXohzM4L9fzfb2yFWF = n30.Group_TqwCZl6Gra4OmgvUg1POgm.CreateDefault();
            this.__p_Jb49oG861DPL87MSSAVVtT = n49.SkyboxLight_C.CreateDefault();
            this.__p_LhwmT3fbQU4L4uCcfkqBn8 = n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z.CreateDefault();
            this.__p_G0oM3QInjsLQPW7P4SCcfW = n49.SpotLight_C.CreateDefault();
            this.__p_StHT1NNUzl5MiqEEGVHrc0 = default(n1.IVLNode);
            this.__p_LwRCLYxIu53PxSXTuvsgOV = n30.Entity_OfyExcqEe4CPH8Wq0L8jzv.CreateDefault();
            this.__p_NKNPlE5g1XKLBJ3Bl0r8X0 = default(n1.IVLNode);
            this.__p_DMnnH1Kf4EmLDBBBLj4GcT = n55.MeshModel_IM96OF8Pn3tLaQml9JGZT1.CreateDefault();
            this.__p_ULmyB5dpbyaMdKdw0vpfDp = default(n1.IVLNode);
            this.__p_Q5Ckc7j8dHwPDBxnaZhBgd = n52.BoxFrameRenderer_KnIeAhvGyP7OturynhaRbP.CreateDefault();
            this.__p_MdFqf5PXmLsMU2nO73hmMY = n37.RenderComponent_LYdoKoeCq7MPXOIsyysl4d.CreateDefault();
            this.__p_B65LHCjZaSYPOpObti5hKp = n30.Group_TqwCZl6Gra4OmgvUg1POgm.CreateDefault();
            this.__p_GO8HMpNlikDNYGhQCIAv8G = n30.Group_TqwCZl6Gra4OmgvUg1POgm.CreateDefault();
            this.__p_CCRsbVu1Dw8On1sS2bLBuQ = default(n1.IVLNode);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_POI2G3HeNMPObLndUPeL1H);
            n1.CompilationHelper.SafeDispose(this.__if_Dxra1WEwF1hLxNGfl2D8lt);
            n1.CompilationHelper.SafeDispose(this.__p_U0z7CJxgjTwOi3BwfgMTKT);
            n1.CompilationHelper.SafeDispose(this.__p_KUOxKfQJDWOQUluNScNX67);
            n1.CompilationHelper.SafeDispose(this.__p_QuexozVp4iELOOPugFiTsc);
            n1.CompilationHelper.SafeDispose(this.__p_EdUxqYnbY29Ork1eOjzeI6);
            n1.CompilationHelper.SafeDispose(this.__p_CGVQbiWlZ6gMMXPGelynpi);
            n1.CompilationHelper.SafeDispose(this.__p_M7l9WCzq0kYLJR9eyFqCBP);
            n1.CompilationHelper.SafeDispose(this.__p_JjeqbOoVZIUP04IXDC1ehC);
            n1.CompilationHelper.SafeDispose(this.__p_DsUYgcIgAqgNpIByjD5qry);
            n1.CompilationHelper.SafeDispose(this.__p_TnZGwyZOOAvLNsbG5YzGoo);
            n1.CompilationHelper.SafeDispose(this.__p_FCEGzRTSAY2O1ikFPemSw0);
            n1.CompilationHelper.SafeDispose(this.__p_B6e5crkSWyBQah1Lbf5Xcx);
            n1.CompilationHelper.SafeDispose(this.__p_Dga49V9W4TTN8hChcfHnKM);
            n1.CompilationHelper.SafeDispose(this.__p_C406t4F9APFL7HLbeRZ9Ir);
            n1.CompilationHelper.SafeDispose(this.__p_RUFuwB5bt97LlcLQcPESV9);
            n1.CompilationHelper.SafeDispose(this.__p_KkxFEvV6CdWMrZMkykhBMi);
            n1.CompilationHelper.SafeDispose(this.__p_CtoO6xEdfhdOTUjTpnNf8N);
            n1.CompilationHelper.SafeDispose(this.__p_QK7hngAdoaDN76tZOseXvN);
            n1.CompilationHelper.SafeDispose(this.__p_AKAzR4zLycYMkPcdO1se2V);
            n1.CompilationHelper.SafeDispose(this.__p_BkxLipNAhZKMEfU5vo2GnW);
            n1.CompilationHelper.SafeDispose(this.__p_KM1V4OUPbJoM9RMwCBqb20);
            n1.CompilationHelper.SafeDispose(this.__p_FWyfZaT4PhkNyQJ8vguC5x);
            n1.CompilationHelper.SafeDispose(this.__p_LGArFWy3lqdOlbLn3s4kfp);
            n1.CompilationHelper.SafeDispose(this.__p_Nx0ogFUOMk0PjrK6d9Mx5Q);
            n1.CompilationHelper.SafeDispose(this.__p_VmBqYmSD1I0PiIuwqelTbJ);
            n1.CompilationHelper.SafeDispose(this.__p_PQwJhjYBk5KPlDxx3iMIWi);
            n1.CompilationHelper.SafeDispose(this.__p_SmR8pfakQuFM4Kb64PiXK7);
            n1.CompilationHelper.SafeDispose(this.__p_PnKXaDQXUdDQWKI1DJM6Sw);
            n1.CompilationHelper.SafeDispose(this.__p_HagAUNvLtbKOBDHJTMLDdk);
            n1.CompilationHelper.SafeDispose(this.__p_QQaemaNEegjLMVZVeE4JJc);
            n1.CompilationHelper.SafeDispose(this.__p_Ekau9A7qIKWPH3n4iukg3a);
            n1.CompilationHelper.SafeDispose(this.__p_N5QqZaAkdMTNMNFNdnVUoU);
            n1.CompilationHelper.SafeDispose(this.__p_BJ7Y5jADNNfPthHrqKfQHd);
            n1.CompilationHelper.SafeDispose(this.__p_R9T0bq9ZB8zPKD6mugiPMV);
            n1.CompilationHelper.SafeDispose(this.__p_HEb8kibmAUvPp7LCzqnh59);
            n1.CompilationHelper.SafeDispose(this.__p_EaGTrQGlWWnNkAf0vdkSCB);
            n1.CompilationHelper.SafeDispose(this.__p_QQyHwUHxbpGNiBaGFnCq31);
            n1.CompilationHelper.SafeDispose(this.__p_CMmAcXMEPFcQGMBASpUfa4);
            n1.CompilationHelper.SafeDispose(this.__p_TGaqE9XAoLvMIcFLRXc49a);
            n1.CompilationHelper.SafeDispose(this.__p_SKrWf5e2Qh1NDQEgVEfFOB);
            n1.CompilationHelper.SafeDispose(this.__p_AnySrXohzM4L9fzfb2yFWF);
            n1.CompilationHelper.SafeDispose(this.__p_Jb49oG861DPL87MSSAVVtT);
            n1.CompilationHelper.SafeDispose(this.__p_LhwmT3fbQU4L4uCcfkqBn8);
            n1.CompilationHelper.SafeDispose(this.__p_G0oM3QInjsLQPW7P4SCcfW);
            n1.CompilationHelper.SafeDispose(this.__p_StHT1NNUzl5MiqEEGVHrc0);
            n1.CompilationHelper.SafeDispose(this.__p_LwRCLYxIu53PxSXTuvsgOV);
            n1.CompilationHelper.SafeDispose(this.__p_NKNPlE5g1XKLBJ3Bl0r8X0);
            n1.CompilationHelper.SafeDispose(this.__p_DMnnH1Kf4EmLDBBBLj4GcT);
            n1.CompilationHelper.SafeDispose(this.__p_ULmyB5dpbyaMdKdw0vpfDp);
            n1.CompilationHelper.SafeDispose(this.__p_Q5Ckc7j8dHwPDBxnaZhBgd);
            n1.CompilationHelper.SafeDispose(this.__p_MdFqf5PXmLsMU2nO73hmMY);
            n1.CompilationHelper.SafeDispose(this.__p_B65LHCjZaSYPOpObti5hKp);
            n1.CompilationHelper.SafeDispose(this.__p_GO8HMpNlikDNYGhQCIAv8G);
            n1.CompilationHelper.SafeDispose(this.__p_CCRsbVu1Dw8On1sS2bLBuQ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 315592U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "JhwqVgRchaHPqkanMBqnTa", Name = "__slot_JhwqVgRchaHPqkanMBqnTa")]
        public static n40.Path __slot_JhwqVgRchaHPqkanMBqnTa = n1.CompilationHelper.Deserialize<n40.Path>("..\\resources\\textures\\EnviromentMaps\\SingaporeAlley2_RC_512_.dds", false, "JPmuEharYwiLQs6dOuoEQQ", "JhwqVgRchaHPqkanMBqnTa");
        [n1.ElementAttribute(TracingId = 315603U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Vu5FjpkSalUOyyXNoe0aCa", Name = "__slot_Vu5FjpkSalUOyyXNoe0aCa")]
        public static n7.Vector3 __slot_Vu5FjpkSalUOyyXNoe0aCa = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0.5, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "Vu5FjpkSalUOyyXNoe0aCa");
        [n1.ElementAttribute(TracingId = 315631U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "I43q45FJUEZOBjWlyFoN9U", Name = "__slot_I43q45FJUEZOBjWlyFoN9U")]
        public static n7.Vector3 __slot_I43q45FJUEZOBjWlyFoN9U = n1.CompilationHelper.Deserialize<n7.Vector3>("3, 4, 3", false, "JPmuEharYwiLQs6dOuoEQQ", "I43q45FJUEZOBjWlyFoN9U");
        [n1.ElementAttribute(TracingId = 315701U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Kk95YrDeFLpNRnPQEf1vlw", Name = "__slot_Kk95YrDeFLpNRnPQEf1vlw")]
        public static n41.LightShadowMapFilterTypePcfSize __slot_Kk95YrDeFLpNRnPQEf1vlw = n1.CompilationHelper.Deserialize<n41.LightShadowMapFilterTypePcfSize>("Filter7x7", false, "JPmuEharYwiLQs6dOuoEQQ", "Kk95YrDeFLpNRnPQEf1vlw");
        [n1.ElementAttribute(TracingId = 315734U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "BPWUWJK6C10QbYLOWYMBVP", Name = "__slot_BPWUWJK6C10QbYLOWYMBVP")]
        public static string __slot_BPWUWJK6C10QbYLOWYMBVP = "Note Stage geometry is in here too.  Good if want to do Reflections PostFX";
        [n1.ElementAttribute(TracingId = 315813U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "NhXnrXGBOR6L5J1GNUxsjV", Name = "__slot_NhXnrXGBOR6L5J1GNUxsjV")]
        public bool __slot_NhXnrXGBOR6L5J1GNUxsjV;
        [n1.ElementAttribute(TracingId = 315829U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "TLwpw4qiIhYNPPD1z1t5IG", Name = "__slot_TLwpw4qiIhYNPPD1z1t5IG")]
        public static string __slot_TLwpw4qiIhYNPPD1z1t5IG = "Lights";
        [n1.ElementAttribute(TracingId = 315843U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "TNmAji8nsbKNRY7GMQ9OPk", Name = "__slot_TNmAji8nsbKNRY7GMQ9OPk")]
        public static string __slot_TNmAji8nsbKNRY7GMQ9OPk = "PostFX";
        [n1.ElementAttribute(TracingId = 315857U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "LZxXvPHhGOBMfvI6ch2QuM", Name = "__slot_LZxXvPHhGOBMfvI6ch2QuM")]
        public static string __slot_LZxXvPHhGOBMfvI6ch2QuM = "Stage";
        [n1.ElementAttribute(TracingId = 315869U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "AgdfDPpVf7zPyqkqw2tWw6", Name = "__slot_AgdfDPpVf7zPyqkqw2tWw6")]
        public static string __slot_AgdfDPpVf7zPyqkqw2tWw6 = "Guide";
        [n1.ElementAttribute(TracingId = 315870U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "QBpQ3JKmf8sMCpnXsJpc5r", Name = "__slot_QBpQ3JKmf8sMCpnXsJpc5r")]
        public static n7.Vector3 __slot_QBpQ3JKmf8sMCpnXsJpc5r = n1.CompilationHelper.Deserialize<n7.Vector3>("4, 4, 4", false, "JPmuEharYwiLQs6dOuoEQQ", "QBpQ3JKmf8sMCpnXsJpc5r");
        [n1.ElementAttribute(TracingId = 316257U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "PHtPr62IPUNLhYzHWZVWON", Name = "__slot_PHtPr62IPUNLhYzHWZVWON")]
        public bool __slot_PHtPr62IPUNLhYzHWZVWON;
        [n1.ElementAttribute(TracingId = 316328U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "KJQf5gCDTFFLjvz9NELHkn", Name = "__slot_KJQf5gCDTFFLjvz9NELHkn")]
        public static n7.Color4 __slot_KJQf5gCDTFFLjvz9NELHkn = n1.CompilationHelper.Deserialize<n7.Color4>("0.3000002, 0.3000002, 0.3000002, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "KJQf5gCDTFFLjvz9NELHkn");
        [n1.ElementAttribute(TracingId = 316329U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "MlmYhDPKG8hOivPtXnbFcG", Name = "__slot_MlmYhDPKG8hOivPtXnbFcG")]
        public static n7.Color4 __slot_MlmYhDPKG8hOivPtXnbFcG = n1.CompilationHelper.Deserialize<n7.Color4>("0, 0, 0, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "MlmYhDPKG8hOivPtXnbFcG");
        [n1.ElementAttribute(TracingId = 316330U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "VOFcKF62HiYMfI6k58M0Rt", Name = "__slot_VOFcKF62HiYMfI6k58M0Rt")]
        public static float __slot_VOFcKF62HiYMfI6k58M0Rt = 0.51F;
        [n1.ElementAttribute(TracingId = 316341U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "OJARAgZICF2L6ucXq8sFsh", Name = "__slot_OJARAgZICF2L6ucXq8sFsh")]
        public int __slot_OJARAgZICF2L6ucXq8sFsh;
        [n1.ElementAttribute(TracingId = 316365U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "VAmFBkFaVZjOxJev7GS1YZ", Name = "__slot_VAmFBkFaVZjOxJev7GS1YZ")]
        public static n40.Path __slot_VAmFBkFaVZjOxJev7GS1YZ = n1.CompilationHelper.Deserialize<n40.Path>("..\\resources\\textures\\EnviromentMaps\\GiliSunset_R_512.dds", false, "JPmuEharYwiLQs6dOuoEQQ", "VAmFBkFaVZjOxJev7GS1YZ");
        [n1.ElementAttribute(TracingId = 316370U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Mtt6R0xrquEMVq7yoq4aGF", Name = "__slot_Mtt6R0xrquEMVq7yoq4aGF")]
        public static n7.Vector3 __slot_Mtt6R0xrquEMVq7yoq4aGF = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0.5, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "Mtt6R0xrquEMVq7yoq4aGF");
        [n1.ElementAttribute(TracingId = 316383U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "TnlI0YTrV2EM6FVdRvBwG9", Name = "__slot_TnlI0YTrV2EM6FVdRvBwG9")]
        public static n7.Vector3 __slot_TnlI0YTrV2EM6FVdRvBwG9 = n1.CompilationHelper.Deserialize<n7.Vector3>("3, 3.3, 3", false, "JPmuEharYwiLQs6dOuoEQQ", "TnlI0YTrV2EM6FVdRvBwG9");
        [n1.ElementAttribute(TracingId = 316393U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "JKbM66PcDIBM3wpX7uz4iI", Name = "__slot_JKbM66PcDIBM3wpX7uz4iI")]
        public static n7.Vector3 __slot_JKbM66PcDIBM3wpX7uz4iI = n1.CompilationHelper.Deserialize<n7.Vector3>("3.45, 3.8, -3.3", false, "JPmuEharYwiLQs6dOuoEQQ", "JKbM66PcDIBM3wpX7uz4iI");
        [n1.ElementAttribute(TracingId = 316394U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "PVjXdUocZIPLwwKq2Gr4Um", Name = "__slot_PVjXdUocZIPLwwKq2Gr4Um")]
        public static float __slot_PVjXdUocZIPLwwKq2Gr4Um = 0.12F;
        [n1.ElementAttribute(TracingId = 316395U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "BADeqRYzlm8M2eFDJmyjqK", Name = "__slot_BADeqRYzlm8M2eFDJmyjqK")]
        public static float __slot_BADeqRYzlm8M2eFDJmyjqK = 0.1F;
        [n1.ElementAttribute(TracingId = 316400U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "SmV5mvCrccjPOsKV3o6SiO", Name = "__slot_SmV5mvCrccjPOsKV3o6SiO")]
        public static n7.Vector3 __slot_SmV5mvCrccjPOsKV3o6SiO = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0.5, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "SmV5mvCrccjPOsKV3o6SiO");
        [n1.ElementAttribute(TracingId = 316401U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "G18HNH7XPdmPHbpzZo6y0L", Name = "__slot_G18HNH7XPdmPHbpzZo6y0L")]
        public static float __slot_G18HNH7XPdmPHbpzZo6y0L = 0.02F;
        [n1.ElementAttribute(TracingId = 316402U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "PIZ0wY9DkpVPY1vc9LsaUp", Name = "__slot_PIZ0wY9DkpVPY1vc9LsaUp")]
        public static int __slot_PIZ0wY9DkpVPY1vc9LsaUp = 32;
        [n1.ElementAttribute(TracingId = 316403U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "AfJaDEI2N10MPLiMzYWr7W", Name = "__slot_AfJaDEI2N10MPLiMzYWr7W")]
        public static string __slot_AfJaDEI2N10MPLiMzYWr7W = "Higher values produce brighter light shafts\r\n(default: 0.002)";
        [n1.ElementAttribute(TracingId = 316404U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Ul4luMZTuhgNMvN7aKT8JS", Name = "__slot_Ul4luMZTuhgNMvN7aKT8JS")]
        public static string __slot_Ul4luMZTuhgNMvN7aKT8JS = "Higher values produce better light shafts but use more GPU\r\n(default: 16)";
        [n1.ElementAttribute(TracingId = 316405U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "KMuk6XeS5SePHXYgcpA517", Name = "__slot_KMuk6XeS5SePHXYgcpA517")]
        public static string __slot_KMuk6XeS5SePHXYgcpA517 = "Preserves light shaft quality when seen through separate bounding boxes, but uses more GPU\r\n(default: on)";
        [n1.ElementAttribute(TracingId = 316406U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "GmIIGuL7uILMzUP6C1684w", Name = "__slot_GmIIGuL7uILMzUP6C1684w")]
        public static bool __slot_GmIIGuL7uILMzUP6C1684w = true;
        [n1.ElementAttribute(TracingId = 316407U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "RW9OYBO3IM8Lg2QTIABaER", Name = "__slot_RW9OYBO3IM8Lg2QTIABaER")]
        public static n7.Vector3 __slot_RW9OYBO3IM8Lg2QTIABaER = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "RW9OYBO3IM8Lg2QTIABaER");
        [n1.ElementAttribute(TracingId = 316408U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "V30CePQwKYwNHr09PY39Mt", Name = "__slot_V30CePQwKYwNHr09PY39Mt")]
        public static float __slot_V30CePQwKYwNHr09PY39Mt = 6.93F;
        [n1.ElementAttribute(TracingId = 316409U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "ATw1UY2NJn9NpaRW2jUZlv", Name = "__slot_ATw1UY2NJn9NpaRW2jUZlv")]
        public static float __slot_ATw1UY2NJn9NpaRW2jUZlv = 6.06F;
        [n1.ElementAttribute(TracingId = 316410U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "UE4AUm23ZMWLINVBXNGXtb", Name = "__slot_UE4AUm23ZMWLINVBXNGXtb")]
        public static float __slot_UE4AUm23ZMWLINVBXNGXtb = -0.17F;
        [n1.ElementAttribute(TracingId = 316467U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "SGrp4dDFm45L9UsArC9Qmj", Name = "__slot_SGrp4dDFm45L9UsArC9Qmj")]
        public static string __slot_SGrp4dDFm45L9UsArC9Qmj = "<  define the Bounding Volume. Can be any Model.";
        [n1.ElementAttribute(TracingId = 316472U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "SodEdCVcG80NjIGqjqavha", Name = "__slot_SodEdCVcG80NjIGqjqavha")]
        public static n7.Vector3 __slot_SodEdCVcG80NjIGqjqavha = n1.CompilationHelper.Deserialize<n7.Vector3>("0.19, 3.56, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "SodEdCVcG80NjIGqjqavha");
        [n1.ElementAttribute(TracingId = 316484U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "A5fMJXXXq30QRD492gR3qN", Name = "__slot_A5fMJXXXq30QRD492gR3qN")]
        public static bool __slot_A5fMJXXXq30QRD492gR3qN = false;
        [n1.ElementAttribute(TracingId = 316503U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "BZQwCBgn5JVOW9pS7IwzL5", Name = "__slot_BZQwCBgn5JVOW9pS7IwzL5")]
        public n7.Vector3 __slot_BZQwCBgn5JVOW9pS7IwzL5;
        [n1.ElementAttribute(TracingId = 316516U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "FNJLkBC7otfQK2nRhlOH46", Name = "__slot_FNJLkBC7otfQK2nRhlOH46")]
        public static float __slot_FNJLkBC7otfQK2nRhlOH46 = 2.17F;
        [n1.ElementAttribute(TracingId = 316532U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "R5UHxOeaDRQLpsCcJyrYk6", Name = "__slot_R5UHxOeaDRQLpsCcJyrYk6")]
        public static n7.Vector3 __slot_R5UHxOeaDRQLpsCcJyrYk6 = n1.CompilationHelper.Deserialize<n7.Vector3>("-0.08, 3.51, 0.16", false, "JPmuEharYwiLQs6dOuoEQQ", "R5UHxOeaDRQLpsCcJyrYk6");
        [n1.ElementAttribute(TracingId = 316533U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "NToWGCWgDrxNdGY7Lfi7FG", Name = "__slot_NToWGCWgDrxNdGY7Lfi7FG")]
        public static n7.Vector3 __slot_NToWGCWgDrxNdGY7Lfi7FG = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "NToWGCWgDrxNdGY7Lfi7FG");
        [n1.ElementAttribute(TracingId = 316583U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "It50TDAwo89OaAaf3cyhmb", Name = "__slot_It50TDAwo89OaAaf3cyhmb")]
        public static n7.Vector3 __slot_It50TDAwo89OaAaf3cyhmb = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0.5, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "It50TDAwo89OaAaf3cyhmb");
        [n1.ElementAttribute(TracingId = 316584U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "IL3Ga2zLUeYMUEephXKehK", Name = "__slot_IL3Ga2zLUeYMUEephXKehK")]
        public static n40.Path __slot_IL3Ga2zLUeYMUEephXKehK = n1.CompilationHelper.Deserialize<n40.Path>("..\\resources\\textures\\EnviromentMaps\\SLQ_R_512.dds", false, "JPmuEharYwiLQs6dOuoEQQ", "IL3Ga2zLUeYMUEephXKehK");
        [n1.ElementAttribute(TracingId = 316600U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "MSeyhzx7RQILXPHxKrXPs6", Name = "__slot_MSeyhzx7RQILXPHxKrXPs6")]
        public static n7.Vector3 __slot_MSeyhzx7RQILXPHxKrXPs6 = n1.CompilationHelper.Deserialize<n7.Vector3>("2.39, 3.13, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "MSeyhzx7RQILXPHxKrXPs6");
        [n1.ElementAttribute(TracingId = 316616U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "MHGItF376AtN0AneZTHhj2", Name = "__slot_MHGItF376AtN0AneZTHhj2")]
        public static n7.Vector3 __slot_MHGItF376AtN0AneZTHhj2 = n1.CompilationHelper.Deserialize<n7.Vector3>("-2.67, 3.13, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "MHGItF376AtN0AneZTHhj2");
        [n1.ElementAttribute(TracingId = 316644U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "UHvwNPRwngAMSyw84GpTxo", Name = "__slot_UHvwNPRwngAMSyw84GpTxo")]
        public static n7.Vector3 __slot_UHvwNPRwngAMSyw84GpTxo = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0.5, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "UHvwNPRwngAMSyw84GpTxo");
        [n1.ElementAttribute(TracingId = 316645U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "RABYUZiAQEROHCSHlyJGtO", Name = "__slot_RABYUZiAQEROHCSHlyJGtO")]
        public static n40.Path __slot_RABYUZiAQEROHCSHlyJGtO = n1.CompilationHelper.Deserialize<n40.Path>("..\\resources\\textures\\EnviromentMaps\\SLQ_R_512.dds", false, "JPmuEharYwiLQs6dOuoEQQ", "RABYUZiAQEROHCSHlyJGtO");
        [n1.ElementAttribute(TracingId = 316646U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "NTVOzt1zxsAMRuUcT4rQ3a", Name = "__slot_NTVOzt1zxsAMRuUcT4rQ3a")]
        public static n7.Color4 __slot_NTVOzt1zxsAMRuUcT4rQ3a = n1.CompilationHelper.Deserialize<n7.Color4>("0.7500002, 0.6642001, 0.5850002, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "NTVOzt1zxsAMRuUcT4rQ3a");
        [n1.ElementAttribute(TracingId = 316662U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Nrni0XgJZU4Nc0JC61JDan", Name = "__slot_Nrni0XgJZU4Nc0JC61JDan")]
        public static n7.Vector3 __slot_Nrni0XgJZU4Nc0JC61JDan = n1.CompilationHelper.Deserialize<n7.Vector3>("1, 4.39, 2", false, "JPmuEharYwiLQs6dOuoEQQ", "Nrni0XgJZU4Nc0JC61JDan");
        [n1.ElementAttribute(TracingId = 316668U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "HSRNTIJGdVjLXpjTJRqoPx", Name = "__slot_HSRNTIJGdVjLXpjTJRqoPx")]
        public static int __slot_HSRNTIJGdVjLXpjTJRqoPx = 8;
        [n1.ElementAttribute(TracingId = 316669U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "DoGOVLnoGRHLuACY7NwcYq", Name = "__slot_DoGOVLnoGRHLuACY7NwcYq")]
        public static int __slot_DoGOVLnoGRHLuACY7NwcYq = 4;
        [n1.ElementAttribute(TracingId = 316670U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Q3ye53u0zHvPuh0NWxE7Ho", Name = "__slot_Q3ye53u0zHvPuh0NWxE7Ho")]
        public static string __slot_Q3ye53u0zHvPuh0NWxE7Ho = "Lower values produce more precise volume buffer areas, but use more GPU \r\n(default: 8)";
        [n1.ElementAttribute(TracingId = 316671U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "KHPbwHFGGvPO6RvvKHZVki", Name = "__slot_KHPbwHFGGvPO6RvvKHZVki")]
        public static string __slot_KHPbwHFGGvPO6RvvKHZVki = "Lower values produce sharper light shafts, but use more GPU\r\n(default: 2)";
        [n1.ElementAttribute(TracingId = 316677U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "SuO3USX97nbOZkyAnpraqe", Name = "__slot_SuO3USX97nbOZkyAnpraqe")]
        public static float __slot_SuO3USX97nbOZkyAnpraqe = 0.15F;
        [n1.ElementAttribute(TracingId = 316693U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "CCi5gx1CJ32OPXIUCYRlXm", Name = "__slot_CCi5gx1CJ32OPXIUCYRlXm")]
        public static n41.LightShadowMapFilterTypePcfSize __slot_CCi5gx1CJ32OPXIUCYRlXm = n1.CompilationHelper.Deserialize<n41.LightShadowMapFilterTypePcfSize>("Filter7x7", false, "JPmuEharYwiLQs6dOuoEQQ", "CCi5gx1CJ32OPXIUCYRlXm");
        [n1.ElementAttribute(TracingId = 316694U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "SEycS7fVjWFLq9BXC5xDkI", Name = "__slot_SEycS7fVjWFLq9BXC5xDkI")]
        public static n40.Path __slot_SEycS7fVjWFLq9BXC5xDkI = n1.CompilationHelper.Deserialize<n40.Path>("..\\resources\\textures\\EnviromentMaps\\SLQ_R_512.dds", false, "JPmuEharYwiLQs6dOuoEQQ", "SEycS7fVjWFLq9BXC5xDkI");
        [n1.ElementAttribute(TracingId = 316721U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "O3g4b8EfxUjOr4bjVwWxsM", Name = "__slot_O3g4b8EfxUjOr4bjVwWxsM")]
        public static n7.Vector3 __slot_O3g4b8EfxUjOr4bjVwWxsM = n1.CompilationHelper.Deserialize<n7.Vector3>("0.37, 1.24, 1.44", false, "JPmuEharYwiLQs6dOuoEQQ", "O3g4b8EfxUjOr4bjVwWxsM");
        [n1.ElementAttribute(TracingId = 316766U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Ctd9iNx7yxMOYG6vUFzjdD", Name = "__slot_Ctd9iNx7yxMOYG6vUFzjdD")]
        public static n41.LightShadowMapFilterTypePcfSize __slot_Ctd9iNx7yxMOYG6vUFzjdD = n1.CompilationHelper.Deserialize<n41.LightShadowMapFilterTypePcfSize>("Filter7x7", false, "JPmuEharYwiLQs6dOuoEQQ", "Ctd9iNx7yxMOYG6vUFzjdD");
        [n1.ElementAttribute(TracingId = 316674U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "N3pNzCdtg3SN0iZKrC9yGJ", Name = "BBox")]
        public n7.Matrix BBox;
        [n1.ElementAttribute(TracingId = 316782U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "NHEziK2UslmPfcrYCl97HF", Name = "Background Enabled")]
        public bool Background_Enabled;
        [n1.ElementAttribute(TracingId = 316488U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "POI2G3HeNMPObLndUPeL1H", Name = "Hejl2", IsManaged = true, IsAutoGenerated = true, NodeName = "Hejl2", NodeCategory = "Stride.Rendering.PostFX.ColorTransforms.ToneMapOperators")]
        public n1.IVLNode __p_POI2G3HeNMPObLndUPeL1H;
        [n1.ElementAttribute(TracingId = 316255U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "H2xDJZL4VzINangNmx1UJG", Name = "__slot_H2xDJZL4VzINangNmx1UJG")]
        public static float __slot_H2xDJZL4VzINangNmx1UJG = 0.06F;
        [n1.ElementAttribute(TracingId = 316093U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "TSNgDflJz38MGIlCOaT9py", Name = "__slot_TSNgDflJz38MGIlCOaT9py")]
        public static n7.Vector4 __slot_TSNgDflJz38MGIlCOaT9py = n1.CompilationHelper.Deserialize<n7.Vector4>("0.5, 1.89, 4.32, 50", false, "JPmuEharYwiLQs6dOuoEQQ", "TSNgDflJz38MGIlCOaT9py");
        [n1.ElementAttribute(TracingId = 316253U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "KpDA2ori8VpMDO7Rdfm2Uu", Name = "__slot_KpDA2ori8VpMDO7Rdfm2Uu")]
        public static bool __slot_KpDA2ori8VpMDO7Rdfm2Uu = true;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_ETIIyqFqpWINItkMu1MsT2 = n1.CompilationHelper.Deserialize<n7.Color4>("0, 0, 0, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "ETIIyqFqpWINItkMu1MsT2");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n42.DitherType __c_GwfzwYe96s4MCp5DgD6CQB = n1.CompilationHelper.Deserialize<n42.DitherType>("Medium", false, "JPmuEharYwiLQs6dOuoEQQ", "GwfzwYe96s4MCp5DgD6CQB");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_Dxra1WEwF1hLxNGfl2D8lt;
        [n1.ElementAttribute(TracingId = 315704U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "U0z7CJxgjTwOi3BwfgMTKT", Name = "Plane", IsManaged = true, IsAutoGenerated = true)]
        public n17.Plane_C __p_U0z7CJxgjTwOi3BwfgMTKT;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Vector2 __c_TIpmdGnvHCwPdPLoAhhR55 = n1.CompilationHelper.Deserialize<n7.Vector2>("32, 32", false, "JPmuEharYwiLQs6dOuoEQQ", "TIpmdGnvHCwPdPLoAhhR55");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Int2 __c_RUKeOGvKVO0PSUwgZ3cis4 = n1.CompilationHelper.Deserialize<n7.Int2>("1, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "RUKeOGvKVO0PSUwgZ3cis4");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n43.NormalDirection __c_ECnsZmxCPSuLQFwj7jXGND = n1.CompilationHelper.Deserialize<n43.NormalDirection>("UpY", false, "JPmuEharYwiLQs6dOuoEQQ", "ECnsZmxCPSuLQFwj7jXGND");
        [n1.ElementAttribute(TracingId = 316321U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "KUOxKfQJDWOQUluNScNX67", Name = "PBRMaterial", IsManaged = true, IsAutoGenerated = true)]
        public n54.PBRMaterial_C __p_KUOxKfQJDWOQUluNScNX67;
        [n1.ElementAttribute(TracingId = 315766U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "QuexozVp4iELOOPugFiTsc", Name = "BoxFrameRenderer", IsManaged = true, IsAutoGenerated = true)]
        public n52.BoxFrameRenderer_KnIeAhvGyP7OturynhaRbP __p_QuexozVp4iELOOPugFiTsc;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_EKKnEgVE8TTOjCmA7wnVBA = n1.CompilationHelper.Deserialize<n7.Color4>("0.1000004, 0.1000004, 0.1000004, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "EKKnEgVE8TTOjCmA7wnVBA");
        [n1.ElementAttribute(TracingId = 315776U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "EdUxqYnbY29Ork1eOjzeI6", Name = "RenderComponent", IsManaged = true, IsAutoGenerated = true)]
        public n37.RenderComponent_LYdoKoeCq7MPXOIsyysl4d __p_EdUxqYnbY29Ork1eOjzeI6;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.EntityComponent> __pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs = default(n20.Spread<n16.EntityComponent>);
        [n1.ElementAttribute(TracingId = 315752U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "CGVQbiWlZ6gMMXPGelynpi", Name = "Entity", IsManaged = true, IsAutoGenerated = true)]
        public n30.Entity_OfyExcqEe4CPH8Wq0L8jzv __p_CGVQbiWlZ6gMMXPGelynpi;
        [n1.ElementAttribute(TracingId = 315930U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "M7l9WCzq0kYLJR9eyFqCBP", Name = "AxisAndGrid", IsManaged = true, IsAutoGenerated = true)]
        public n53.AxisAndGrid_UVYBbYPB2FTPRFmVzqosNK __p_M7l9WCzq0kYLJR9eyFqCBP;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Matrix __c_PYp4LuJoMsZNHAM0HZ9Mrk = n1.CompilationHelper.Deserialize<n7.Matrix>("1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "PYp4LuJoMsZNHAM0HZ9Mrk");
        [n1.ElementAttribute(TracingId = 315946U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "JjeqbOoVZIUP04IXDC1ehC", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_JjeqbOoVZIUP04IXDC1ehC;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.Entity> __pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC = default(n20.Spread<n16.Entity>);
        [n1.ElementAttribute(TracingId = 315551U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "DsUYgcIgAqgNpIByjD5qry", Name = "SkyboxLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.SkyboxLight_C __p_DsUYgcIgAqgNpIByjD5qry;
        [n1.ElementAttribute(TracingId = 315578U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "TnZGwyZOOAvLNsbG5YzGoo", Name = "FileTexture", IsManaged = true, IsAutoGenerated = true)]
        public n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_TnZGwyZOOAvLNsbG5YzGoo;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n46.AlphaFormat __c_Vc3FG2ZlVyoNl5ZkMq5cY4 = n1.CompilationHelper.Deserialize<n46.AlphaFormat>("Auto", false, "JPmuEharYwiLQs6dOuoEQQ", "Vc3FG2ZlVyoNl5ZkMq5cY4");
        [n1.ElementAttribute(TracingId = 315604U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "FCEGzRTSAY2O1ikFPemSw0", Name = "DirectionalLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.DirectionalLight_C __p_FCEGzRTSAY2O1ikFPemSw0;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Vector3 __c_O6g6BssX30FOY8DOVTzbfy = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "O6g6BssX30FOY8DOVTzbfy");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_AnR350Xko6MNE9fe7c8w5b = n1.CompilationHelper.Deserialize<n7.Color4>("1, 1, 1, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "AnR350Xko6MNE9fe7c8w5b");
        [n1.ElementAttribute(TracingId = 315691U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "B6e5crkSWyBQah1Lbf5Xcx", Name = "LightShadowMapFilterTypePcf", IsManaged = true, IsAutoGenerated = true, NodeName = "LightShadowMapFilterTypePcf", NodeCategory = "Stride.Lights.Advanced.ShadowMaps")]
        public n1.IVLNode __p_B6e5crkSWyBQah1Lbf5Xcx;
        [n1.ElementAttribute(TracingId = 315658U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Dga49V9W4TTN8hChcfHnKM", Name = "LightDirectionalShadowMap", IsManaged = true, IsAutoGenerated = true, NodeName = "LightDirectionalShadowMap", NodeCategory = "Stride.Lights.Advanced.ShadowMaps")]
        public n1.IVLNode __p_Dga49V9W4TTN8hChcfHnKM;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n41.LightShadowMapSize __c_OZAkST1MnfaQWg6yqJSQAK = n1.CompilationHelper.Deserialize<n41.LightShadowMapSize>("XLarge", false, "JPmuEharYwiLQs6dOuoEQQ", "OZAkST1MnfaQWg6yqJSQAK");
        [n1.ElementAttribute(TracingId = 316647U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "C406t4F9APFL7HLbeRZ9Ir", Name = "SpotLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.SpotLight_C __p_C406t4F9APFL7HLbeRZ9Ir;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Vector3 __c_MCG2aejPzIMMmMnUiPYLhG = n1.CompilationHelper.Deserialize<n7.Vector3>("1, 2, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "MCG2aejPzIMMmMnUiPYLhG");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Vector3 __c_B5Do8tnCftnLXYdD75bLPn = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "B5Do8tnCftnLXYdD75bLPn");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_Kht9P5tbKU2P5jUXegvmE5 = n1.CompilationHelper.Deserialize<n7.Color4>("0.5464001, 0.19, 1, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "Kht9P5tbKU2P5jUXegvmE5");
        [n1.ElementAttribute(TracingId = 315908U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "RUFuwB5bt97LlcLQcPESV9", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_RUFuwB5bt97LlcLQcPESV9;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.Entity> __pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9 = default(n20.Spread<n16.Entity>);
        [n1.ElementAttribute(TracingId = 316270U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "KkxFEvV6CdWMrZMkykhBMi", Name = "SkyboxLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.SkyboxLight_C __p_KkxFEvV6CdWMrZMkykhBMi;
        [n1.ElementAttribute(TracingId = 316283U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "CtoO6xEdfhdOTUjTpnNf8N", Name = "FileTexture", IsManaged = true, IsAutoGenerated = true)]
        public n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_CtoO6xEdfhdOTUjTpnNf8N;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n46.AlphaFormat __c_RXSV8w6H1bHLoQUtFL84ss = n1.CompilationHelper.Deserialize<n46.AlphaFormat>("Auto", false, "JPmuEharYwiLQs6dOuoEQQ", "RXSV8w6H1bHLoQUtFL84ss");
        [n1.ElementAttribute(TracingId = 316258U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "QK7hngAdoaDN76tZOseXvN", Name = "DirectionalLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.DirectionalLight_C __p_QK7hngAdoaDN76tZOseXvN;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Vector3 __c_IHIpzPc1Xm4PIHDGgMHXc2 = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "IHIpzPc1Xm4PIHDGgMHXc2");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_VAAGmGjIReSPeyZr9XtVbP = n1.CompilationHelper.Deserialize<n7.Color4>("1, 1, 1, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "VAAGmGjIReSPeyZr9XtVbP");
        [n1.ElementAttribute(TracingId = 316302U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "AKAzR4zLycYMkPcdO1se2V", Name = "AmbientLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.AmbientLight_C __p_AKAzR4zLycYMkPcdO1se2V;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_SWqnDLnkSDVPti0XfgBY9s = n1.CompilationHelper.Deserialize<n7.Color4>("0.19, 0.19, 0.19, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "SWqnDLnkSDVPti0XfgBY9s");
        [n1.ElementAttribute(TracingId = 316309U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "BkxLipNAhZKMEfU5vo2GnW", Name = "DirectionalLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.DirectionalLight_C __p_BkxLipNAhZKMEfU5vo2GnW;
        [n1.ElementAttribute(TracingId = 316293U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "KM1V4OUPbJoM9RMwCBqb20", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_KM1V4OUPbJoM9RMwCBqb20;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.Entity> __pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20 = default(n20.Spread<n16.Entity>);
        [n1.ElementAttribute(TracingId = 316342U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "FWyfZaT4PhkNyQJ8vguC5x", Name = "SkyboxLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.SkyboxLight_C __p_FWyfZaT4PhkNyQJ8vguC5x;
        [n1.ElementAttribute(TracingId = 316355U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "LGArFWy3lqdOlbLn3s4kfp", Name = "FileTexture", IsManaged = true, IsAutoGenerated = true)]
        public n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_LGArFWy3lqdOlbLn3s4kfp;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n46.AlphaFormat __c_DOi4rV3S9y0PTBrLHyP4Xh = n1.CompilationHelper.Deserialize<n46.AlphaFormat>("Auto", false, "JPmuEharYwiLQs6dOuoEQQ", "DOi4rV3S9y0PTBrLHyP4Xh");
        [n1.ElementAttribute(TracingId = 316371U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Nx0ogFUOMk0PjrK6d9Mx5Q", Name = "DirectionalLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.DirectionalLight_C __p_Nx0ogFUOMk0PjrK6d9Mx5Q;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Vector3 __c_EaE0uAFVvzENd09iQJXsZ7 = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "EaE0uAFVvzENd09iQJXsZ7");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_N1IDy3OEOA0QVjR2334KOA = n1.CompilationHelper.Deserialize<n7.Color4>("1, 1, 1, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "N1IDy3OEOA0QVjR2334KOA");
        [n1.ElementAttribute(TracingId = 316509U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "VmBqYmSD1I0PiIuwqelTbJ", Name = "LFO", IsManaged = true, IsAutoGenerated = true)]
        public n58.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_VmBqYmSD1I0PiIuwqelTbJ;
        [n1.ElementAttribute(TracingId = 316491U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "PQwJhjYBk5KPlDxx3iMIWi", Name = "PointLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.PointLight_C __p_PQwJhjYBk5KPlDxx3iMIWi;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_FPgxXO7SxQAL9mvqN0mSb3 = n1.CompilationHelper.Deserialize<n7.Color4>("1, 1, 1, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "FPgxXO7SxQAL9mvqN0mSb3");
        [n1.ElementAttribute(TracingId = 316517U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "SmR8pfakQuFM4Kb64PiXK7", Name = "SpotLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.SpotLight_C __p_SmR8pfakQuFM4Kb64PiXK7;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_LmyjAufbh1ONbeZvbo70K6 = n1.CompilationHelper.Deserialize<n7.Color4>("0.5799999, 0.3132, 0, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "LmyjAufbh1ONbeZvbo70K6");
        [n1.ElementAttribute(TracingId = 316384U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "PnKXaDQXUdDQWKI1DJM6Sw", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_PnKXaDQXUdDQWKI1DJM6Sw;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.Entity> __pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw = default(n20.Spread<n16.Entity>);
        [n1.ElementAttribute(TracingId = 316556U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "HagAUNvLtbKOBDHJTMLDdk", Name = "SkyboxLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.SkyboxLight_C __p_HagAUNvLtbKOBDHJTMLDdk;
        [n1.ElementAttribute(TracingId = 316569U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "QQaemaNEegjLMVZVeE4JJc", Name = "FileTexture", IsManaged = true, IsAutoGenerated = true)]
        public n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_QQaemaNEegjLMVZVeE4JJc;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n46.AlphaFormat __c_A4H6kVbpp5VOYP00VnTo1t = n1.CompilationHelper.Deserialize<n46.AlphaFormat>("Auto", false, "JPmuEharYwiLQs6dOuoEQQ", "A4H6kVbpp5VOYP00VnTo1t");
        [n1.ElementAttribute(TracingId = 316544U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Ekau9A7qIKWPH3n4iukg3a", Name = "DirectionalLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.DirectionalLight_C __p_Ekau9A7qIKWPH3n4iukg3a;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Vector3 __c_Pp7G6mOWZg5N1DAUIhzHYn = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "Pp7G6mOWZg5N1DAUIhzHYn");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_Iv1V5Uvd2AlMxRfNe98q2Y = n1.CompilationHelper.Deserialize<n7.Color4>("1, 1, 1, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "Iv1V5Uvd2AlMxRfNe98q2Y");
        [n1.ElementAttribute(TracingId = 316690U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "N5QqZaAkdMTNMNFNdnVUoU", Name = "LightShadowMapFilterTypePcf", IsManaged = true, IsAutoGenerated = true, NodeName = "LightShadowMapFilterTypePcf", NodeCategory = "Stride.Lights.Advanced.ShadowMaps")]
        public n1.IVLNode __p_N5QqZaAkdMTNMNFNdnVUoU;
        [n1.ElementAttribute(TracingId = 316678U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "BJ7Y5jADNNfPthHrqKfQHd", Name = "LightDirectionalShadowMap", IsManaged = true, IsAutoGenerated = true, NodeName = "LightDirectionalShadowMap", NodeCategory = "Stride.Lights.Advanced.ShadowMaps")]
        public n1.IVLNode __p_BJ7Y5jADNNfPthHrqKfQHd;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n41.LightShadowMapSize __c_VTWo65t8eSiNMRGUh0hQiD = n1.CompilationHelper.Deserialize<n41.LightShadowMapSize>("XLarge", false, "JPmuEharYwiLQs6dOuoEQQ", "VTWo65t8eSiNMRGUh0hQiD");
        [n1.ElementAttribute(TracingId = 316585U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "R9T0bq9ZB8zPKD6mugiPMV", Name = "SpotLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.SpotLight_C __p_R9T0bq9ZB8zPKD6mugiPMV;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Vector3 __c_HElHYvpcHs7Mb3pbE2op8N = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "HElHYvpcHs7Mb3pbE2op8N");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_L9gWA3KkbZyP0f412WrjvO = n1.CompilationHelper.Deserialize<n7.Color4>("1, 0.6600004, 0, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "L9gWA3KkbZyP0f412WrjvO");
        [n1.ElementAttribute(TracingId = 316601U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "HEb8kibmAUvPp7LCzqnh59", Name = "SpotLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.SpotLight_C __p_HEb8kibmAUvPp7LCzqnh59;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Vector3 __c_BaRUSuZj0NeOmDzElpfabQ = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "BaRUSuZj0NeOmDzElpfabQ");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_Q4Q8ps6u9adMrROCUtWBb7 = n1.CompilationHelper.Deserialize<n7.Color4>("0.1, 0.7299992, 1, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "Q4Q8ps6u9adMrROCUtWBb7");
        [n1.ElementAttribute(TracingId = 316534U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "EaGTrQGlWWnNkAf0vdkSCB", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_EaGTrQGlWWnNkAf0vdkSCB;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.Entity> __pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB = default(n20.Spread<n16.Entity>);
        [n1.ElementAttribute(TracingId = 316696U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "QQyHwUHxbpGNiBaGFnCq31", Name = "DirectionalLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.DirectionalLight_C __p_QQyHwUHxbpGNiBaGFnCq31;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Vector3 __c_KKwBzLtzPYlLXopirZNROC = n1.CompilationHelper.Deserialize<n7.Vector3>("0, 0, 0", false, "JPmuEharYwiLQs6dOuoEQQ", "KKwBzLtzPYlLXopirZNROC");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_TKbPSTgVBBVO5cbTJVOEzP = n1.CompilationHelper.Deserialize<n7.Color4>("1, 1, 1, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "TKbPSTgVBBVO5cbTJVOEzP");
        [n1.ElementAttribute(TracingId = 316755U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "CMmAcXMEPFcQGMBASpUfa4", Name = "LightShadowMapFilterTypePcf", IsManaged = true, IsAutoGenerated = true, NodeName = "LightShadowMapFilterTypePcf", NodeCategory = "Stride.Lights.Advanced.ShadowMaps")]
        public n1.IVLNode __p_CMmAcXMEPFcQGMBASpUfa4;
        [n1.ElementAttribute(TracingId = 316722U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "TGaqE9XAoLvMIcFLRXc49a", Name = "LightDirectionalShadowMap", IsManaged = true, IsAutoGenerated = true, NodeName = "LightDirectionalShadowMap", NodeCategory = "Stride.Lights.Advanced.ShadowMaps")]
        public n1.IVLNode __p_TGaqE9XAoLvMIcFLRXc49a;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n41.LightShadowMapSize __c_LQtAcgxKQeLMs0PfQLDTX2 = n1.CompilationHelper.Deserialize<n41.LightShadowMapSize>("XLarge", false, "JPmuEharYwiLQs6dOuoEQQ", "LQtAcgxKQeLMs0PfQLDTX2");
        [n1.ElementAttribute(TracingId = 316708U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "SKrWf5e2Qh1NDQEgVEfFOB", Name = "SkyboxLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.SkyboxLight_C __p_SKrWf5e2Qh1NDQEgVEfFOB;
        [n1.ElementAttribute(TracingId = 316768U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "AnySrXohzM4L9fzfb2yFWF", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_AnySrXohzM4L9fzfb2yFWF;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.Entity> __pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF = default(n20.Spread<n16.Entity>);
        [n1.ElementAttribute(TracingId = 316617U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Jb49oG861DPL87MSSAVVtT", Name = "SkyboxLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.SkyboxLight_C __p_Jb49oG861DPL87MSSAVVtT;
        [n1.ElementAttribute(TracingId = 316630U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "LhwmT3fbQU4L4uCcfkqBn8", Name = "FileTexture", IsManaged = true, IsAutoGenerated = true)]
        public n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_LhwmT3fbQU4L4uCcfkqBn8;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n46.AlphaFormat __c_U29jKRKxTY1L1IMCdkBYnp = n1.CompilationHelper.Deserialize<n46.AlphaFormat>("Auto", false, "JPmuEharYwiLQs6dOuoEQQ", "U29jKRKxTY1L1IMCdkBYnp");
        [n1.ElementAttribute(TracingId = 316411U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "G0oM3QInjsLQPW7P4SCcfW", Name = "SpotLight", IsManaged = true, IsAutoGenerated = true)]
        public n49.SpotLight_C __p_G0oM3QInjsLQPW7P4SCcfW;
        [n1.ElementAttribute(TracingId = 316441U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "StHT1NNUzl5MiqEEGVHrc0", Name = "LightShaftComponent", IsManaged = true, IsAutoGenerated = true, NodeName = "LightShaftComponent", NodeCategory = "Stride.Lights.Advanced")]
        public n1.IVLNode __p_StHT1NNUzl5MiqEEGVHrc0;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.EntityComponent> __pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k = default(n20.Spread<n16.EntityComponent>);
        [n1.ElementAttribute(TracingId = 316426U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "LwRCLYxIu53PxSXTuvsgOV", Name = "Entity", IsManaged = true, IsAutoGenerated = true)]
        public n30.Entity_OfyExcqEe4CPH8Wq0L8jzv __p_LwRCLYxIu53PxSXTuvsgOV;
        [n1.ElementAttribute(TracingId = 316460U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "NKNPlE5g1XKLBJ3Bl0r8X0", Name = "BoxMesh", IsManaged = true, IsAutoGenerated = true, NodeName = "BoxMesh", NodeCategory = "Stride.Models.Meshes")]
        public n1.IVLNode __p_NKNPlE5g1XKLBJ3Bl0r8X0;
        [n1.ElementAttribute(TracingId = 316456U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "DMnnH1Kf4EmLDBBBLj4GcT", Name = "MeshModel", IsManaged = true, IsAutoGenerated = true)]
        public n55.MeshModel_IM96OF8Pn3tLaQml9JGZT1 __p_DMnnH1Kf4EmLDBBBLj4GcT;
        [n1.ElementAttribute(TracingId = 316447U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "ULmyB5dpbyaMdKdw0vpfDp", Name = "LightShaftBoundingVolumeComponent", IsManaged = true, IsAutoGenerated = true, NodeName = "LightShaftBoundingVolumeComponent", NodeCategory = "Stride.Lights.Advanced")]
        public n1.IVLNode __p_ULmyB5dpbyaMdKdw0vpfDp;
        [n1.ElementAttribute(TracingId = 316473U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Q5Ckc7j8dHwPDBxnaZhBgd", Name = "BoxFrameRenderer", IsManaged = true, IsAutoGenerated = true)]
        public n52.BoxFrameRenderer_KnIeAhvGyP7OturynhaRbP __p_Q5Ckc7j8dHwPDBxnaZhBgd;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Matrix __c_DPyn6k03eLcPjAcffo4Wi1 = n1.CompilationHelper.Deserialize<n7.Matrix>("1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "DPyn6k03eLcPjAcffo4Wi1");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Color4 __c_DPlhH0NJFk2MiP8d5sZ5ex = n1.CompilationHelper.Deserialize<n7.Color4>("0.1000004, 0.1000004, 0.1000004, 1", false, "JPmuEharYwiLQs6dOuoEQQ", "DPlhH0NJFk2MiP8d5sZ5ex");
        [n1.ElementAttribute(TracingId = 316477U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "MdFqf5PXmLsMU2nO73hmMY", Name = "RenderComponent", IsManaged = true, IsAutoGenerated = true)]
        public n37.RenderComponent_LYdoKoeCq7MPXOIsyysl4d __p_MdFqf5PXmLsMU2nO73hmMY;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.EntityComponent> __pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx = default(n20.Spread<n16.EntityComponent>);
        [n1.ElementAttribute(TracingId = 316433U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "B65LHCjZaSYPOpObti5hKp", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_B65LHCjZaSYPOpObti5hKp;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.Entity> __pin_group_Child_In_B65LHCjZaSYPOpObti5hKp = default(n20.Spread<n16.Entity>);
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.Entity> __pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw = default(n20.Spread<n16.Entity>);
        [n1.ElementAttribute(TracingId = 315636U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "GO8HMpNlikDNYGhQCIAv8G", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
        public n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_GO8HMpNlikDNYGhQCIAv8G;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.Entity> __pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G = default(n20.Spread<n16.Entity>);
        [n1.ElementAttribute(TracingId = 316663U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "CCRsbVu1Dw8On1sS2bLBuQ", Name = "LightShafts", IsManaged = true, IsAutoGenerated = true, NodeName = "LightShafts", NodeCategory = "Stride.Rendering.Advanced.Compositing")]
        public n1.IVLNode __p_CCRsbVu1Dw8On1sS2bLBuQ;
        static LightStudios_Iu0D0SDDMseNZZodQPhpqH()
        {
        }

        public LightStudios_Iu0D0SDDMseNZZodQPhpqH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal LightStudios_Iu0D0SDDMseNZZodQPhpqH(LightStudios_Iu0D0SDDMseNZZodQPhpqH other): base(other)
        {
            this.__slot_NhXnrXGBOR6L5J1GNUxsjV = other.__slot_NhXnrXGBOR6L5J1GNUxsjV;
            this.__slot_PHtPr62IPUNLhYzHWZVWON = other.__slot_PHtPr62IPUNLhYzHWZVWON;
            this.__slot_OJARAgZICF2L6ucXq8sFsh = other.__slot_OJARAgZICF2L6ucXq8sFsh;
            this.__slot_BZQwCBgn5JVOW9pS7IwzL5 = other.__slot_BZQwCBgn5JVOW9pS7IwzL5;
            this.BBox = other.BBox;
            this.Background_Enabled = other.Background_Enabled;
            this.__p_POI2G3HeNMPObLndUPeL1H = other.__p_POI2G3HeNMPObLndUPeL1H;
            this.__if_Dxra1WEwF1hLxNGfl2D8lt = other.__if_Dxra1WEwF1hLxNGfl2D8lt;
            this.__p_U0z7CJxgjTwOi3BwfgMTKT = other.__p_U0z7CJxgjTwOi3BwfgMTKT;
            this.__p_KUOxKfQJDWOQUluNScNX67 = other.__p_KUOxKfQJDWOQUluNScNX67;
            this.__p_QuexozVp4iELOOPugFiTsc = other.__p_QuexozVp4iELOOPugFiTsc;
            this.__p_EdUxqYnbY29Ork1eOjzeI6 = other.__p_EdUxqYnbY29Ork1eOjzeI6;
            this.__pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs = other.__pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs;
            this.__p_CGVQbiWlZ6gMMXPGelynpi = other.__p_CGVQbiWlZ6gMMXPGelynpi;
            this.__p_M7l9WCzq0kYLJR9eyFqCBP = other.__p_M7l9WCzq0kYLJR9eyFqCBP;
            this.__p_JjeqbOoVZIUP04IXDC1ehC = other.__p_JjeqbOoVZIUP04IXDC1ehC;
            this.__pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC = other.__pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC;
            this.__p_DsUYgcIgAqgNpIByjD5qry = other.__p_DsUYgcIgAqgNpIByjD5qry;
            this.__p_TnZGwyZOOAvLNsbG5YzGoo = other.__p_TnZGwyZOOAvLNsbG5YzGoo;
            this.__p_FCEGzRTSAY2O1ikFPemSw0 = other.__p_FCEGzRTSAY2O1ikFPemSw0;
            this.__p_B6e5crkSWyBQah1Lbf5Xcx = other.__p_B6e5crkSWyBQah1Lbf5Xcx;
            this.__p_Dga49V9W4TTN8hChcfHnKM = other.__p_Dga49V9W4TTN8hChcfHnKM;
            this.__p_C406t4F9APFL7HLbeRZ9Ir = other.__p_C406t4F9APFL7HLbeRZ9Ir;
            this.__p_RUFuwB5bt97LlcLQcPESV9 = other.__p_RUFuwB5bt97LlcLQcPESV9;
            this.__pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9 = other.__pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9;
            this.__p_KkxFEvV6CdWMrZMkykhBMi = other.__p_KkxFEvV6CdWMrZMkykhBMi;
            this.__p_CtoO6xEdfhdOTUjTpnNf8N = other.__p_CtoO6xEdfhdOTUjTpnNf8N;
            this.__p_QK7hngAdoaDN76tZOseXvN = other.__p_QK7hngAdoaDN76tZOseXvN;
            this.__p_AKAzR4zLycYMkPcdO1se2V = other.__p_AKAzR4zLycYMkPcdO1se2V;
            this.__p_BkxLipNAhZKMEfU5vo2GnW = other.__p_BkxLipNAhZKMEfU5vo2GnW;
            this.__p_KM1V4OUPbJoM9RMwCBqb20 = other.__p_KM1V4OUPbJoM9RMwCBqb20;
            this.__pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20 = other.__pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20;
            this.__p_FWyfZaT4PhkNyQJ8vguC5x = other.__p_FWyfZaT4PhkNyQJ8vguC5x;
            this.__p_LGArFWy3lqdOlbLn3s4kfp = other.__p_LGArFWy3lqdOlbLn3s4kfp;
            this.__p_Nx0ogFUOMk0PjrK6d9Mx5Q = other.__p_Nx0ogFUOMk0PjrK6d9Mx5Q;
            this.__p_VmBqYmSD1I0PiIuwqelTbJ = other.__p_VmBqYmSD1I0PiIuwqelTbJ;
            this.__p_PQwJhjYBk5KPlDxx3iMIWi = other.__p_PQwJhjYBk5KPlDxx3iMIWi;
            this.__p_SmR8pfakQuFM4Kb64PiXK7 = other.__p_SmR8pfakQuFM4Kb64PiXK7;
            this.__p_PnKXaDQXUdDQWKI1DJM6Sw = other.__p_PnKXaDQXUdDQWKI1DJM6Sw;
            this.__pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw = other.__pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw;
            this.__p_HagAUNvLtbKOBDHJTMLDdk = other.__p_HagAUNvLtbKOBDHJTMLDdk;
            this.__p_QQaemaNEegjLMVZVeE4JJc = other.__p_QQaemaNEegjLMVZVeE4JJc;
            this.__p_Ekau9A7qIKWPH3n4iukg3a = other.__p_Ekau9A7qIKWPH3n4iukg3a;
            this.__p_N5QqZaAkdMTNMNFNdnVUoU = other.__p_N5QqZaAkdMTNMNFNdnVUoU;
            this.__p_BJ7Y5jADNNfPthHrqKfQHd = other.__p_BJ7Y5jADNNfPthHrqKfQHd;
            this.__p_R9T0bq9ZB8zPKD6mugiPMV = other.__p_R9T0bq9ZB8zPKD6mugiPMV;
            this.__p_HEb8kibmAUvPp7LCzqnh59 = other.__p_HEb8kibmAUvPp7LCzqnh59;
            this.__p_EaGTrQGlWWnNkAf0vdkSCB = other.__p_EaGTrQGlWWnNkAf0vdkSCB;
            this.__pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB = other.__pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB;
            this.__p_QQyHwUHxbpGNiBaGFnCq31 = other.__p_QQyHwUHxbpGNiBaGFnCq31;
            this.__p_CMmAcXMEPFcQGMBASpUfa4 = other.__p_CMmAcXMEPFcQGMBASpUfa4;
            this.__p_TGaqE9XAoLvMIcFLRXc49a = other.__p_TGaqE9XAoLvMIcFLRXc49a;
            this.__p_SKrWf5e2Qh1NDQEgVEfFOB = other.__p_SKrWf5e2Qh1NDQEgVEfFOB;
            this.__p_AnySrXohzM4L9fzfb2yFWF = other.__p_AnySrXohzM4L9fzfb2yFWF;
            this.__pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF = other.__pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF;
            this.__p_Jb49oG861DPL87MSSAVVtT = other.__p_Jb49oG861DPL87MSSAVVtT;
            this.__p_LhwmT3fbQU4L4uCcfkqBn8 = other.__p_LhwmT3fbQU4L4uCcfkqBn8;
            this.__p_G0oM3QInjsLQPW7P4SCcfW = other.__p_G0oM3QInjsLQPW7P4SCcfW;
            this.__p_StHT1NNUzl5MiqEEGVHrc0 = other.__p_StHT1NNUzl5MiqEEGVHrc0;
            this.__pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k = other.__pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k;
            this.__p_LwRCLYxIu53PxSXTuvsgOV = other.__p_LwRCLYxIu53PxSXTuvsgOV;
            this.__p_NKNPlE5g1XKLBJ3Bl0r8X0 = other.__p_NKNPlE5g1XKLBJ3Bl0r8X0;
            this.__p_DMnnH1Kf4EmLDBBBLj4GcT = other.__p_DMnnH1Kf4EmLDBBBLj4GcT;
            this.__p_ULmyB5dpbyaMdKdw0vpfDp = other.__p_ULmyB5dpbyaMdKdw0vpfDp;
            this.__p_Q5Ckc7j8dHwPDBxnaZhBgd = other.__p_Q5Ckc7j8dHwPDBxnaZhBgd;
            this.__p_MdFqf5PXmLsMU2nO73hmMY = other.__p_MdFqf5PXmLsMU2nO73hmMY;
            this.__pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx = other.__pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx;
            this.__p_B65LHCjZaSYPOpObti5hKp = other.__p_B65LHCjZaSYPOpObti5hKp;
            this.__pin_group_Child_In_B65LHCjZaSYPOpObti5hKp = other.__pin_group_Child_In_B65LHCjZaSYPOpObti5hKp;
            this.__pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw = other.__pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw;
            this.__p_GO8HMpNlikDNYGhQCIAv8G = other.__p_GO8HMpNlikDNYGhQCIAv8G;
            this.__pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G = other.__pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G;
            this.__p_CCRsbVu1Dw8On1sS2bLBuQ = other.__p_CCRsbVu1Dw8On1sS2bLBuQ;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_NhXnrXGBOR6L5J1GNUxsjV", in __slot_NhXnrXGBOR6L5J1GNUxsjV), n1.CompilationHelper.GetValueOrExisting(values, "__slot_PHtPr62IPUNLhYzHWZVWON", in __slot_PHtPr62IPUNLhYzHWZVWON), n1.CompilationHelper.GetValueOrExisting(values, "__slot_OJARAgZICF2L6ucXq8sFsh", in __slot_OJARAgZICF2L6ucXq8sFsh), n1.CompilationHelper.GetValueOrExisting(values, "__slot_BZQwCBgn5JVOW9pS7IwzL5", in __slot_BZQwCBgn5JVOW9pS7IwzL5), n1.CompilationHelper.GetValueOrExisting(values, "BBox", in BBox), n1.CompilationHelper.GetValueOrExisting(values, "Background_Enabled", in Background_Enabled), n1.CompilationHelper.GetValueOrExisting(values, "__p_POI2G3HeNMPObLndUPeL1H", in __p_POI2G3HeNMPObLndUPeL1H), n1.CompilationHelper.GetValueOrExisting(values, "__if_Dxra1WEwF1hLxNGfl2D8lt", in __if_Dxra1WEwF1hLxNGfl2D8lt), n1.CompilationHelper.GetValueOrExisting(values, "__p_U0z7CJxgjTwOi3BwfgMTKT", in __p_U0z7CJxgjTwOi3BwfgMTKT), n1.CompilationHelper.GetValueOrExisting(values, "__p_KUOxKfQJDWOQUluNScNX67", in __p_KUOxKfQJDWOQUluNScNX67), n1.CompilationHelper.GetValueOrExisting(values, "__p_QuexozVp4iELOOPugFiTsc", in __p_QuexozVp4iELOOPugFiTsc), n1.CompilationHelper.GetValueOrExisting(values, "__p_EdUxqYnbY29Ork1eOjzeI6", in __p_EdUxqYnbY29Ork1eOjzeI6), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs", in __pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs), n1.CompilationHelper.GetValueOrExisting(values, "__p_CGVQbiWlZ6gMMXPGelynpi", in __p_CGVQbiWlZ6gMMXPGelynpi), n1.CompilationHelper.GetValueOrExisting(values, "__p_M7l9WCzq0kYLJR9eyFqCBP", in __p_M7l9WCzq0kYLJR9eyFqCBP), n1.CompilationHelper.GetValueOrExisting(values, "__p_JjeqbOoVZIUP04IXDC1ehC", in __p_JjeqbOoVZIUP04IXDC1ehC), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC", in __pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC), n1.CompilationHelper.GetValueOrExisting(values, "__p_DsUYgcIgAqgNpIByjD5qry", in __p_DsUYgcIgAqgNpIByjD5qry), n1.CompilationHelper.GetValueOrExisting(values, "__p_TnZGwyZOOAvLNsbG5YzGoo", in __p_TnZGwyZOOAvLNsbG5YzGoo), n1.CompilationHelper.GetValueOrExisting(values, "__p_FCEGzRTSAY2O1ikFPemSw0", in __p_FCEGzRTSAY2O1ikFPemSw0), n1.CompilationHelper.GetValueOrExisting(values, "__p_B6e5crkSWyBQah1Lbf5Xcx", in __p_B6e5crkSWyBQah1Lbf5Xcx), n1.CompilationHelper.GetValueOrExisting(values, "__p_Dga49V9W4TTN8hChcfHnKM", in __p_Dga49V9W4TTN8hChcfHnKM), n1.CompilationHelper.GetValueOrExisting(values, "__p_C406t4F9APFL7HLbeRZ9Ir", in __p_C406t4F9APFL7HLbeRZ9Ir), n1.CompilationHelper.GetValueOrExisting(values, "__p_RUFuwB5bt97LlcLQcPESV9", in __p_RUFuwB5bt97LlcLQcPESV9), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9", in __pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9), n1.CompilationHelper.GetValueOrExisting(values, "__p_KkxFEvV6CdWMrZMkykhBMi", in __p_KkxFEvV6CdWMrZMkykhBMi), n1.CompilationHelper.GetValueOrExisting(values, "__p_CtoO6xEdfhdOTUjTpnNf8N", in __p_CtoO6xEdfhdOTUjTpnNf8N), n1.CompilationHelper.GetValueOrExisting(values, "__p_QK7hngAdoaDN76tZOseXvN", in __p_QK7hngAdoaDN76tZOseXvN), n1.CompilationHelper.GetValueOrExisting(values, "__p_AKAzR4zLycYMkPcdO1se2V", in __p_AKAzR4zLycYMkPcdO1se2V), n1.CompilationHelper.GetValueOrExisting(values, "__p_BkxLipNAhZKMEfU5vo2GnW", in __p_BkxLipNAhZKMEfU5vo2GnW), n1.CompilationHelper.GetValueOrExisting(values, "__p_KM1V4OUPbJoM9RMwCBqb20", in __p_KM1V4OUPbJoM9RMwCBqb20), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20", in __pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20), n1.CompilationHelper.GetValueOrExisting(values, "__p_FWyfZaT4PhkNyQJ8vguC5x", in __p_FWyfZaT4PhkNyQJ8vguC5x), n1.CompilationHelper.GetValueOrExisting(values, "__p_LGArFWy3lqdOlbLn3s4kfp", in __p_LGArFWy3lqdOlbLn3s4kfp), n1.CompilationHelper.GetValueOrExisting(values, "__p_Nx0ogFUOMk0PjrK6d9Mx5Q", in __p_Nx0ogFUOMk0PjrK6d9Mx5Q), n1.CompilationHelper.GetValueOrExisting(values, "__p_VmBqYmSD1I0PiIuwqelTbJ", in __p_VmBqYmSD1I0PiIuwqelTbJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_PQwJhjYBk5KPlDxx3iMIWi", in __p_PQwJhjYBk5KPlDxx3iMIWi), n1.CompilationHelper.GetValueOrExisting(values, "__p_SmR8pfakQuFM4Kb64PiXK7", in __p_SmR8pfakQuFM4Kb64PiXK7), n1.CompilationHelper.GetValueOrExisting(values, "__p_PnKXaDQXUdDQWKI1DJM6Sw", in __p_PnKXaDQXUdDQWKI1DJM6Sw), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw", in __pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw), n1.CompilationHelper.GetValueOrExisting(values, "__p_HagAUNvLtbKOBDHJTMLDdk", in __p_HagAUNvLtbKOBDHJTMLDdk), n1.CompilationHelper.GetValueOrExisting(values, "__p_QQaemaNEegjLMVZVeE4JJc", in __p_QQaemaNEegjLMVZVeE4JJc), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ekau9A7qIKWPH3n4iukg3a", in __p_Ekau9A7qIKWPH3n4iukg3a), n1.CompilationHelper.GetValueOrExisting(values, "__p_N5QqZaAkdMTNMNFNdnVUoU", in __p_N5QqZaAkdMTNMNFNdnVUoU), n1.CompilationHelper.GetValueOrExisting(values, "__p_BJ7Y5jADNNfPthHrqKfQHd", in __p_BJ7Y5jADNNfPthHrqKfQHd), n1.CompilationHelper.GetValueOrExisting(values, "__p_R9T0bq9ZB8zPKD6mugiPMV", in __p_R9T0bq9ZB8zPKD6mugiPMV), n1.CompilationHelper.GetValueOrExisting(values, "__p_HEb8kibmAUvPp7LCzqnh59", in __p_HEb8kibmAUvPp7LCzqnh59), n1.CompilationHelper.GetValueOrExisting(values, "__p_EaGTrQGlWWnNkAf0vdkSCB", in __p_EaGTrQGlWWnNkAf0vdkSCB), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB", in __pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB), n1.CompilationHelper.GetValueOrExisting(values, "__p_QQyHwUHxbpGNiBaGFnCq31", in __p_QQyHwUHxbpGNiBaGFnCq31), n1.CompilationHelper.GetValueOrExisting(values, "__p_CMmAcXMEPFcQGMBASpUfa4", in __p_CMmAcXMEPFcQGMBASpUfa4), n1.CompilationHelper.GetValueOrExisting(values, "__p_TGaqE9XAoLvMIcFLRXc49a", in __p_TGaqE9XAoLvMIcFLRXc49a), n1.CompilationHelper.GetValueOrExisting(values, "__p_SKrWf5e2Qh1NDQEgVEfFOB", in __p_SKrWf5e2Qh1NDQEgVEfFOB), n1.CompilationHelper.GetValueOrExisting(values, "__p_AnySrXohzM4L9fzfb2yFWF", in __p_AnySrXohzM4L9fzfb2yFWF), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF", in __pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF), n1.CompilationHelper.GetValueOrExisting(values, "__p_Jb49oG861DPL87MSSAVVtT", in __p_Jb49oG861DPL87MSSAVVtT), n1.CompilationHelper.GetValueOrExisting(values, "__p_LhwmT3fbQU4L4uCcfkqBn8", in __p_LhwmT3fbQU4L4uCcfkqBn8), n1.CompilationHelper.GetValueOrExisting(values, "__p_G0oM3QInjsLQPW7P4SCcfW", in __p_G0oM3QInjsLQPW7P4SCcfW), n1.CompilationHelper.GetValueOrExisting(values, "__p_StHT1NNUzl5MiqEEGVHrc0", in __p_StHT1NNUzl5MiqEEGVHrc0), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k", in __pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k), n1.CompilationHelper.GetValueOrExisting(values, "__p_LwRCLYxIu53PxSXTuvsgOV", in __p_LwRCLYxIu53PxSXTuvsgOV), n1.CompilationHelper.GetValueOrExisting(values, "__p_NKNPlE5g1XKLBJ3Bl0r8X0", in __p_NKNPlE5g1XKLBJ3Bl0r8X0), n1.CompilationHelper.GetValueOrExisting(values, "__p_DMnnH1Kf4EmLDBBBLj4GcT", in __p_DMnnH1Kf4EmLDBBBLj4GcT), n1.CompilationHelper.GetValueOrExisting(values, "__p_ULmyB5dpbyaMdKdw0vpfDp", in __p_ULmyB5dpbyaMdKdw0vpfDp), n1.CompilationHelper.GetValueOrExisting(values, "__p_Q5Ckc7j8dHwPDBxnaZhBgd", in __p_Q5Ckc7j8dHwPDBxnaZhBgd), n1.CompilationHelper.GetValueOrExisting(values, "__p_MdFqf5PXmLsMU2nO73hmMY", in __p_MdFqf5PXmLsMU2nO73hmMY), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx", in __pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx), n1.CompilationHelper.GetValueOrExisting(values, "__p_B65LHCjZaSYPOpObti5hKp", in __p_B65LHCjZaSYPOpObti5hKp), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_B65LHCjZaSYPOpObti5hKp", in __pin_group_Child_In_B65LHCjZaSYPOpObti5hKp), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw", in __pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw), n1.CompilationHelper.GetValueOrExisting(values, "__p_GO8HMpNlikDNYGhQCIAv8G", in __p_GO8HMpNlikDNYGhQCIAv8G), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G", in __pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G), n1.CompilationHelper.GetValueOrExisting(values, "__p_CCRsbVu1Dw8On1sS2bLBuQ", in __p_CCRsbVu1Dw8On1sS2bLBuQ));
        }

        internal LightStudios_Iu0D0SDDMseNZZodQPhpqH __WITH__(bool __slot_NhXnrXGBOR6L5J1GNUxsjV, bool __slot_PHtPr62IPUNLhYzHWZVWON, int __slot_OJARAgZICF2L6ucXq8sFsh, n7.Vector3 __slot_BZQwCBgn5JVOW9pS7IwzL5, n7.Matrix BBox, bool Background_Enabled, n1.IVLNode __p_POI2G3HeNMPObLndUPeL1H, n2.Object __if_Dxra1WEwF1hLxNGfl2D8lt, n17.Plane_C __p_U0z7CJxgjTwOi3BwfgMTKT, n54.PBRMaterial_C __p_KUOxKfQJDWOQUluNScNX67, n52.BoxFrameRenderer_KnIeAhvGyP7OturynhaRbP __p_QuexozVp4iELOOPugFiTsc, n37.RenderComponent_LYdoKoeCq7MPXOIsyysl4d __p_EdUxqYnbY29Ork1eOjzeI6, n20.Spread<n16.EntityComponent> __pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs, n30.Entity_OfyExcqEe4CPH8Wq0L8jzv __p_CGVQbiWlZ6gMMXPGelynpi, n53.AxisAndGrid_UVYBbYPB2FTPRFmVzqosNK __p_M7l9WCzq0kYLJR9eyFqCBP, n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_JjeqbOoVZIUP04IXDC1ehC, n20.Spread<n16.Entity> __pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC, n49.SkyboxLight_C __p_DsUYgcIgAqgNpIByjD5qry, n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_TnZGwyZOOAvLNsbG5YzGoo, n49.DirectionalLight_C __p_FCEGzRTSAY2O1ikFPemSw0, n1.IVLNode __p_B6e5crkSWyBQah1Lbf5Xcx, n1.IVLNode __p_Dga49V9W4TTN8hChcfHnKM, n49.SpotLight_C __p_C406t4F9APFL7HLbeRZ9Ir, n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_RUFuwB5bt97LlcLQcPESV9, n20.Spread<n16.Entity> __pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9, n49.SkyboxLight_C __p_KkxFEvV6CdWMrZMkykhBMi, n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_CtoO6xEdfhdOTUjTpnNf8N, n49.DirectionalLight_C __p_QK7hngAdoaDN76tZOseXvN, n49.AmbientLight_C __p_AKAzR4zLycYMkPcdO1se2V, n49.DirectionalLight_C __p_BkxLipNAhZKMEfU5vo2GnW, n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_KM1V4OUPbJoM9RMwCBqb20, n20.Spread<n16.Entity> __pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20, n49.SkyboxLight_C __p_FWyfZaT4PhkNyQJ8vguC5x, n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_LGArFWy3lqdOlbLn3s4kfp, n49.DirectionalLight_C __p_Nx0ogFUOMk0PjrK6d9Mx5Q, n58.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_VmBqYmSD1I0PiIuwqelTbJ, n49.PointLight_C __p_PQwJhjYBk5KPlDxx3iMIWi, n49.SpotLight_C __p_SmR8pfakQuFM4Kb64PiXK7, n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_PnKXaDQXUdDQWKI1DJM6Sw, n20.Spread<n16.Entity> __pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw, n49.SkyboxLight_C __p_HagAUNvLtbKOBDHJTMLDdk, n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_QQaemaNEegjLMVZVeE4JJc, n49.DirectionalLight_C __p_Ekau9A7qIKWPH3n4iukg3a, n1.IVLNode __p_N5QqZaAkdMTNMNFNdnVUoU, n1.IVLNode __p_BJ7Y5jADNNfPthHrqKfQHd, n49.SpotLight_C __p_R9T0bq9ZB8zPKD6mugiPMV, n49.SpotLight_C __p_HEb8kibmAUvPp7LCzqnh59, n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_EaGTrQGlWWnNkAf0vdkSCB, n20.Spread<n16.Entity> __pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB, n49.DirectionalLight_C __p_QQyHwUHxbpGNiBaGFnCq31, n1.IVLNode __p_CMmAcXMEPFcQGMBASpUfa4, n1.IVLNode __p_TGaqE9XAoLvMIcFLRXc49a, n49.SkyboxLight_C __p_SKrWf5e2Qh1NDQEgVEfFOB, n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_AnySrXohzM4L9fzfb2yFWF, n20.Spread<n16.Entity> __pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF, n49.SkyboxLight_C __p_Jb49oG861DPL87MSSAVVtT, n50.FileTexture_VHk2U8mzzVePYWKVz5dr4z __p_LhwmT3fbQU4L4uCcfkqBn8, n49.SpotLight_C __p_G0oM3QInjsLQPW7P4SCcfW, n1.IVLNode __p_StHT1NNUzl5MiqEEGVHrc0, n20.Spread<n16.EntityComponent> __pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k, n30.Entity_OfyExcqEe4CPH8Wq0L8jzv __p_LwRCLYxIu53PxSXTuvsgOV, n1.IVLNode __p_NKNPlE5g1XKLBJ3Bl0r8X0, n55.MeshModel_IM96OF8Pn3tLaQml9JGZT1 __p_DMnnH1Kf4EmLDBBBLj4GcT, n1.IVLNode __p_ULmyB5dpbyaMdKdw0vpfDp, n52.BoxFrameRenderer_KnIeAhvGyP7OturynhaRbP __p_Q5Ckc7j8dHwPDBxnaZhBgd, n37.RenderComponent_LYdoKoeCq7MPXOIsyysl4d __p_MdFqf5PXmLsMU2nO73hmMY, n20.Spread<n16.EntityComponent> __pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx, n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_B65LHCjZaSYPOpObti5hKp, n20.Spread<n16.Entity> __pin_group_Child_In_B65LHCjZaSYPOpObti5hKp, n20.Spread<n16.Entity> __pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw, n30.Group_TqwCZl6Gra4OmgvUg1POgm __p_GO8HMpNlikDNYGhQCIAv8G, n20.Spread<n16.Entity> __pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G, n1.IVLNode __p_CCRsbVu1Dw8On1sS2bLBuQ)
        {
            n4.LightStudios_Iu0D0SDDMseNZZodQPhpqH that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_NhXnrXGBOR6L5J1GNUxsjV != this.__slot_NhXnrXGBOR6L5J1GNUxsjV || __slot_PHtPr62IPUNLhYzHWZVWON != this.__slot_PHtPr62IPUNLhYzHWZVWON || __slot_OJARAgZICF2L6ucXq8sFsh != this.__slot_OJARAgZICF2L6ucXq8sFsh || __slot_BZQwCBgn5JVOW9pS7IwzL5 != this.__slot_BZQwCBgn5JVOW9pS7IwzL5 || !n13.EqualityComparer<n7.Matrix>.Default.Equals(BBox, this.BBox) || Background_Enabled != this.Background_Enabled || __p_POI2G3HeNMPObLndUPeL1H != this.__p_POI2G3HeNMPObLndUPeL1H || __if_Dxra1WEwF1hLxNGfl2D8lt != this.__if_Dxra1WEwF1hLxNGfl2D8lt || __p_U0z7CJxgjTwOi3BwfgMTKT != this.__p_U0z7CJxgjTwOi3BwfgMTKT || __p_KUOxKfQJDWOQUluNScNX67 != this.__p_KUOxKfQJDWOQUluNScNX67 || __p_QuexozVp4iELOOPugFiTsc != this.__p_QuexozVp4iELOOPugFiTsc || __p_EdUxqYnbY29Ork1eOjzeI6 != this.__p_EdUxqYnbY29Ork1eOjzeI6 || __pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs != this.__pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs || __p_CGVQbiWlZ6gMMXPGelynpi != this.__p_CGVQbiWlZ6gMMXPGelynpi || __p_M7l9WCzq0kYLJR9eyFqCBP != this.__p_M7l9WCzq0kYLJR9eyFqCBP || __p_JjeqbOoVZIUP04IXDC1ehC != this.__p_JjeqbOoVZIUP04IXDC1ehC || __pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC != this.__pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC || __p_DsUYgcIgAqgNpIByjD5qry != this.__p_DsUYgcIgAqgNpIByjD5qry || __p_TnZGwyZOOAvLNsbG5YzGoo != this.__p_TnZGwyZOOAvLNsbG5YzGoo || __p_FCEGzRTSAY2O1ikFPemSw0 != this.__p_FCEGzRTSAY2O1ikFPemSw0 || __p_B6e5crkSWyBQah1Lbf5Xcx != this.__p_B6e5crkSWyBQah1Lbf5Xcx || __p_Dga49V9W4TTN8hChcfHnKM != this.__p_Dga49V9W4TTN8hChcfHnKM || __p_C406t4F9APFL7HLbeRZ9Ir != this.__p_C406t4F9APFL7HLbeRZ9Ir || __p_RUFuwB5bt97LlcLQcPESV9 != this.__p_RUFuwB5bt97LlcLQcPESV9 || __pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9 != this.__pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9 || __p_KkxFEvV6CdWMrZMkykhBMi != this.__p_KkxFEvV6CdWMrZMkykhBMi || __p_CtoO6xEdfhdOTUjTpnNf8N != this.__p_CtoO6xEdfhdOTUjTpnNf8N || __p_QK7hngAdoaDN76tZOseXvN != this.__p_QK7hngAdoaDN76tZOseXvN || __p_AKAzR4zLycYMkPcdO1se2V != this.__p_AKAzR4zLycYMkPcdO1se2V || __p_BkxLipNAhZKMEfU5vo2GnW != this.__p_BkxLipNAhZKMEfU5vo2GnW || __p_KM1V4OUPbJoM9RMwCBqb20 != this.__p_KM1V4OUPbJoM9RMwCBqb20 || __pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20 != this.__pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20 || __p_FWyfZaT4PhkNyQJ8vguC5x != this.__p_FWyfZaT4PhkNyQJ8vguC5x || __p_LGArFWy3lqdOlbLn3s4kfp != this.__p_LGArFWy3lqdOlbLn3s4kfp || __p_Nx0ogFUOMk0PjrK6d9Mx5Q != this.__p_Nx0ogFUOMk0PjrK6d9Mx5Q || __p_VmBqYmSD1I0PiIuwqelTbJ != this.__p_VmBqYmSD1I0PiIuwqelTbJ || __p_PQwJhjYBk5KPlDxx3iMIWi != this.__p_PQwJhjYBk5KPlDxx3iMIWi || __p_SmR8pfakQuFM4Kb64PiXK7 != this.__p_SmR8pfakQuFM4Kb64PiXK7 || __p_PnKXaDQXUdDQWKI1DJM6Sw != this.__p_PnKXaDQXUdDQWKI1DJM6Sw || __pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw != this.__pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw || __p_HagAUNvLtbKOBDHJTMLDdk != this.__p_HagAUNvLtbKOBDHJTMLDdk || __p_QQaemaNEegjLMVZVeE4JJc != this.__p_QQaemaNEegjLMVZVeE4JJc || __p_Ekau9A7qIKWPH3n4iukg3a != this.__p_Ekau9A7qIKWPH3n4iukg3a || __p_N5QqZaAkdMTNMNFNdnVUoU != this.__p_N5QqZaAkdMTNMNFNdnVUoU || __p_BJ7Y5jADNNfPthHrqKfQHd != this.__p_BJ7Y5jADNNfPthHrqKfQHd || __p_R9T0bq9ZB8zPKD6mugiPMV != this.__p_R9T0bq9ZB8zPKD6mugiPMV || __p_HEb8kibmAUvPp7LCzqnh59 != this.__p_HEb8kibmAUvPp7LCzqnh59 || __p_EaGTrQGlWWnNkAf0vdkSCB != this.__p_EaGTrQGlWWnNkAf0vdkSCB || __pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB != this.__pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB || __p_QQyHwUHxbpGNiBaGFnCq31 != this.__p_QQyHwUHxbpGNiBaGFnCq31 || __p_CMmAcXMEPFcQGMBASpUfa4 != this.__p_CMmAcXMEPFcQGMBASpUfa4 || __p_TGaqE9XAoLvMIcFLRXc49a != this.__p_TGaqE9XAoLvMIcFLRXc49a || __p_SKrWf5e2Qh1NDQEgVEfFOB != this.__p_SKrWf5e2Qh1NDQEgVEfFOB || __p_AnySrXohzM4L9fzfb2yFWF != this.__p_AnySrXohzM4L9fzfb2yFWF || __pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF != this.__pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF || __p_Jb49oG861DPL87MSSAVVtT != this.__p_Jb49oG861DPL87MSSAVVtT || __p_LhwmT3fbQU4L4uCcfkqBn8 != this.__p_LhwmT3fbQU4L4uCcfkqBn8 || __p_G0oM3QInjsLQPW7P4SCcfW != this.__p_G0oM3QInjsLQPW7P4SCcfW || __p_StHT1NNUzl5MiqEEGVHrc0 != this.__p_StHT1NNUzl5MiqEEGVHrc0 || __pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k != this.__pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k || __p_LwRCLYxIu53PxSXTuvsgOV != this.__p_LwRCLYxIu53PxSXTuvsgOV || __p_NKNPlE5g1XKLBJ3Bl0r8X0 != this.__p_NKNPlE5g1XKLBJ3Bl0r8X0 || __p_DMnnH1Kf4EmLDBBBLj4GcT != this.__p_DMnnH1Kf4EmLDBBBLj4GcT || __p_ULmyB5dpbyaMdKdw0vpfDp != this.__p_ULmyB5dpbyaMdKdw0vpfDp || __p_Q5Ckc7j8dHwPDBxnaZhBgd != this.__p_Q5Ckc7j8dHwPDBxnaZhBgd || __p_MdFqf5PXmLsMU2nO73hmMY != this.__p_MdFqf5PXmLsMU2nO73hmMY || __pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx != this.__pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx || __p_B65LHCjZaSYPOpObti5hKp != this.__p_B65LHCjZaSYPOpObti5hKp || __pin_group_Child_In_B65LHCjZaSYPOpObti5hKp != this.__pin_group_Child_In_B65LHCjZaSYPOpObti5hKp || __pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw != this.__pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw || __p_GO8HMpNlikDNYGhQCIAv8G != this.__p_GO8HMpNlikDNYGhQCIAv8G || __pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G != this.__pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G || __p_CCRsbVu1Dw8On1sS2bLBuQ != this.__p_CCRsbVu1Dw8On1sS2bLBuQ ? new LightStudios_Iu0D0SDDMseNZZodQPhpqH(this)
                {__slot_NhXnrXGBOR6L5J1GNUxsjV = __slot_NhXnrXGBOR6L5J1GNUxsjV, __slot_PHtPr62IPUNLhYzHWZVWON = __slot_PHtPr62IPUNLhYzHWZVWON, __slot_OJARAgZICF2L6ucXq8sFsh = __slot_OJARAgZICF2L6ucXq8sFsh, __slot_BZQwCBgn5JVOW9pS7IwzL5 = __slot_BZQwCBgn5JVOW9pS7IwzL5, BBox = BBox, Background_Enabled = Background_Enabled, __p_POI2G3HeNMPObLndUPeL1H = __p_POI2G3HeNMPObLndUPeL1H, __if_Dxra1WEwF1hLxNGfl2D8lt = __if_Dxra1WEwF1hLxNGfl2D8lt, __p_U0z7CJxgjTwOi3BwfgMTKT = __p_U0z7CJxgjTwOi3BwfgMTKT, __p_KUOxKfQJDWOQUluNScNX67 = __p_KUOxKfQJDWOQUluNScNX67, __p_QuexozVp4iELOOPugFiTsc = __p_QuexozVp4iELOOPugFiTsc, __p_EdUxqYnbY29Ork1eOjzeI6 = __p_EdUxqYnbY29Ork1eOjzeI6, __pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs = __pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs, __p_CGVQbiWlZ6gMMXPGelynpi = __p_CGVQbiWlZ6gMMXPGelynpi, __p_M7l9WCzq0kYLJR9eyFqCBP = __p_M7l9WCzq0kYLJR9eyFqCBP, __p_JjeqbOoVZIUP04IXDC1ehC = __p_JjeqbOoVZIUP04IXDC1ehC, __pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC = __pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC, __p_DsUYgcIgAqgNpIByjD5qry = __p_DsUYgcIgAqgNpIByjD5qry, __p_TnZGwyZOOAvLNsbG5YzGoo = __p_TnZGwyZOOAvLNsbG5YzGoo, __p_FCEGzRTSAY2O1ikFPemSw0 = __p_FCEGzRTSAY2O1ikFPemSw0, __p_B6e5crkSWyBQah1Lbf5Xcx = __p_B6e5crkSWyBQah1Lbf5Xcx, __p_Dga49V9W4TTN8hChcfHnKM = __p_Dga49V9W4TTN8hChcfHnKM, __p_C406t4F9APFL7HLbeRZ9Ir = __p_C406t4F9APFL7HLbeRZ9Ir, __p_RUFuwB5bt97LlcLQcPESV9 = __p_RUFuwB5bt97LlcLQcPESV9, __pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9 = __pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9, __p_KkxFEvV6CdWMrZMkykhBMi = __p_KkxFEvV6CdWMrZMkykhBMi, __p_CtoO6xEdfhdOTUjTpnNf8N = __p_CtoO6xEdfhdOTUjTpnNf8N, __p_QK7hngAdoaDN76tZOseXvN = __p_QK7hngAdoaDN76tZOseXvN, __p_AKAzR4zLycYMkPcdO1se2V = __p_AKAzR4zLycYMkPcdO1se2V, __p_BkxLipNAhZKMEfU5vo2GnW = __p_BkxLipNAhZKMEfU5vo2GnW, __p_KM1V4OUPbJoM9RMwCBqb20 = __p_KM1V4OUPbJoM9RMwCBqb20, __pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20 = __pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20, __p_FWyfZaT4PhkNyQJ8vguC5x = __p_FWyfZaT4PhkNyQJ8vguC5x, __p_LGArFWy3lqdOlbLn3s4kfp = __p_LGArFWy3lqdOlbLn3s4kfp, __p_Nx0ogFUOMk0PjrK6d9Mx5Q = __p_Nx0ogFUOMk0PjrK6d9Mx5Q, __p_VmBqYmSD1I0PiIuwqelTbJ = __p_VmBqYmSD1I0PiIuwqelTbJ, __p_PQwJhjYBk5KPlDxx3iMIWi = __p_PQwJhjYBk5KPlDxx3iMIWi, __p_SmR8pfakQuFM4Kb64PiXK7 = __p_SmR8pfakQuFM4Kb64PiXK7, __p_PnKXaDQXUdDQWKI1DJM6Sw = __p_PnKXaDQXUdDQWKI1DJM6Sw, __pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw = __pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw, __p_HagAUNvLtbKOBDHJTMLDdk = __p_HagAUNvLtbKOBDHJTMLDdk, __p_QQaemaNEegjLMVZVeE4JJc = __p_QQaemaNEegjLMVZVeE4JJc, __p_Ekau9A7qIKWPH3n4iukg3a = __p_Ekau9A7qIKWPH3n4iukg3a, __p_N5QqZaAkdMTNMNFNdnVUoU = __p_N5QqZaAkdMTNMNFNdnVUoU, __p_BJ7Y5jADNNfPthHrqKfQHd = __p_BJ7Y5jADNNfPthHrqKfQHd, __p_R9T0bq9ZB8zPKD6mugiPMV = __p_R9T0bq9ZB8zPKD6mugiPMV, __p_HEb8kibmAUvPp7LCzqnh59 = __p_HEb8kibmAUvPp7LCzqnh59, __p_EaGTrQGlWWnNkAf0vdkSCB = __p_EaGTrQGlWWnNkAf0vdkSCB, __pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB = __pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB, __p_QQyHwUHxbpGNiBaGFnCq31 = __p_QQyHwUHxbpGNiBaGFnCq31, __p_CMmAcXMEPFcQGMBASpUfa4 = __p_CMmAcXMEPFcQGMBASpUfa4, __p_TGaqE9XAoLvMIcFLRXc49a = __p_TGaqE9XAoLvMIcFLRXc49a, __p_SKrWf5e2Qh1NDQEgVEfFOB = __p_SKrWf5e2Qh1NDQEgVEfFOB, __p_AnySrXohzM4L9fzfb2yFWF = __p_AnySrXohzM4L9fzfb2yFWF, __pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF = __pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF, __p_Jb49oG861DPL87MSSAVVtT = __p_Jb49oG861DPL87MSSAVVtT, __p_LhwmT3fbQU4L4uCcfkqBn8 = __p_LhwmT3fbQU4L4uCcfkqBn8, __p_G0oM3QInjsLQPW7P4SCcfW = __p_G0oM3QInjsLQPW7P4SCcfW, __p_StHT1NNUzl5MiqEEGVHrc0 = __p_StHT1NNUzl5MiqEEGVHrc0, __pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k = __pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k, __p_LwRCLYxIu53PxSXTuvsgOV = __p_LwRCLYxIu53PxSXTuvsgOV, __p_NKNPlE5g1XKLBJ3Bl0r8X0 = __p_NKNPlE5g1XKLBJ3Bl0r8X0, __p_DMnnH1Kf4EmLDBBBLj4GcT = __p_DMnnH1Kf4EmLDBBBLj4GcT, __p_ULmyB5dpbyaMdKdw0vpfDp = __p_ULmyB5dpbyaMdKdw0vpfDp, __p_Q5Ckc7j8dHwPDBxnaZhBgd = __p_Q5Ckc7j8dHwPDBxnaZhBgd, __p_MdFqf5PXmLsMU2nO73hmMY = __p_MdFqf5PXmLsMU2nO73hmMY, __pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx = __pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx, __p_B65LHCjZaSYPOpObti5hKp = __p_B65LHCjZaSYPOpObti5hKp, __pin_group_Child_In_B65LHCjZaSYPOpObti5hKp = __pin_group_Child_In_B65LHCjZaSYPOpObti5hKp, __pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw = __pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw, __p_GO8HMpNlikDNYGhQCIAv8G = __p_GO8HMpNlikDNYGhQCIAv8G, __pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G = __pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G, __p_CCRsbVu1Dw8On1sS2bLBuQ = __p_CCRsbVu1Dw8On1sS2bLBuQ} : that_0;
            else
            {
                this.__slot_NhXnrXGBOR6L5J1GNUxsjV = __slot_NhXnrXGBOR6L5J1GNUxsjV;
                this.__slot_PHtPr62IPUNLhYzHWZVWON = __slot_PHtPr62IPUNLhYzHWZVWON;
                this.__slot_OJARAgZICF2L6ucXq8sFsh = __slot_OJARAgZICF2L6ucXq8sFsh;
                this.__slot_BZQwCBgn5JVOW9pS7IwzL5 = __slot_BZQwCBgn5JVOW9pS7IwzL5;
                this.BBox = BBox;
                this.Background_Enabled = Background_Enabled;
                this.__p_POI2G3HeNMPObLndUPeL1H = __p_POI2G3HeNMPObLndUPeL1H;
                this.__if_Dxra1WEwF1hLxNGfl2D8lt = __if_Dxra1WEwF1hLxNGfl2D8lt;
                this.__p_U0z7CJxgjTwOi3BwfgMTKT = __p_U0z7CJxgjTwOi3BwfgMTKT;
                this.__p_KUOxKfQJDWOQUluNScNX67 = __p_KUOxKfQJDWOQUluNScNX67;
                this.__p_QuexozVp4iELOOPugFiTsc = __p_QuexozVp4iELOOPugFiTsc;
                this.__p_EdUxqYnbY29Ork1eOjzeI6 = __p_EdUxqYnbY29Ork1eOjzeI6;
                this.__pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs = __pin_group_Input_In_HFe16aSD24bMRiw1y8yZHs;
                this.__p_CGVQbiWlZ6gMMXPGelynpi = __p_CGVQbiWlZ6gMMXPGelynpi;
                this.__p_M7l9WCzq0kYLJR9eyFqCBP = __p_M7l9WCzq0kYLJR9eyFqCBP;
                this.__p_JjeqbOoVZIUP04IXDC1ehC = __p_JjeqbOoVZIUP04IXDC1ehC;
                this.__pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC = __pin_group_Child_In_JjeqbOoVZIUP04IXDC1ehC;
                this.__p_DsUYgcIgAqgNpIByjD5qry = __p_DsUYgcIgAqgNpIByjD5qry;
                this.__p_TnZGwyZOOAvLNsbG5YzGoo = __p_TnZGwyZOOAvLNsbG5YzGoo;
                this.__p_FCEGzRTSAY2O1ikFPemSw0 = __p_FCEGzRTSAY2O1ikFPemSw0;
                this.__p_B6e5crkSWyBQah1Lbf5Xcx = __p_B6e5crkSWyBQah1Lbf5Xcx;
                this.__p_Dga49V9W4TTN8hChcfHnKM = __p_Dga49V9W4TTN8hChcfHnKM;
                this.__p_C406t4F9APFL7HLbeRZ9Ir = __p_C406t4F9APFL7HLbeRZ9Ir;
                this.__p_RUFuwB5bt97LlcLQcPESV9 = __p_RUFuwB5bt97LlcLQcPESV9;
                this.__pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9 = __pin_group_Child_In_RUFuwB5bt97LlcLQcPESV9;
                this.__p_KkxFEvV6CdWMrZMkykhBMi = __p_KkxFEvV6CdWMrZMkykhBMi;
                this.__p_CtoO6xEdfhdOTUjTpnNf8N = __p_CtoO6xEdfhdOTUjTpnNf8N;
                this.__p_QK7hngAdoaDN76tZOseXvN = __p_QK7hngAdoaDN76tZOseXvN;
                this.__p_AKAzR4zLycYMkPcdO1se2V = __p_AKAzR4zLycYMkPcdO1se2V;
                this.__p_BkxLipNAhZKMEfU5vo2GnW = __p_BkxLipNAhZKMEfU5vo2GnW;
                this.__p_KM1V4OUPbJoM9RMwCBqb20 = __p_KM1V4OUPbJoM9RMwCBqb20;
                this.__pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20 = __pin_group_Child_In_KM1V4OUPbJoM9RMwCBqb20;
                this.__p_FWyfZaT4PhkNyQJ8vguC5x = __p_FWyfZaT4PhkNyQJ8vguC5x;
                this.__p_LGArFWy3lqdOlbLn3s4kfp = __p_LGArFWy3lqdOlbLn3s4kfp;
                this.__p_Nx0ogFUOMk0PjrK6d9Mx5Q = __p_Nx0ogFUOMk0PjrK6d9Mx5Q;
                this.__p_VmBqYmSD1I0PiIuwqelTbJ = __p_VmBqYmSD1I0PiIuwqelTbJ;
                this.__p_PQwJhjYBk5KPlDxx3iMIWi = __p_PQwJhjYBk5KPlDxx3iMIWi;
                this.__p_SmR8pfakQuFM4Kb64PiXK7 = __p_SmR8pfakQuFM4Kb64PiXK7;
                this.__p_PnKXaDQXUdDQWKI1DJM6Sw = __p_PnKXaDQXUdDQWKI1DJM6Sw;
                this.__pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw = __pin_group_Child_In_PnKXaDQXUdDQWKI1DJM6Sw;
                this.__p_HagAUNvLtbKOBDHJTMLDdk = __p_HagAUNvLtbKOBDHJTMLDdk;
                this.__p_QQaemaNEegjLMVZVeE4JJc = __p_QQaemaNEegjLMVZVeE4JJc;
                this.__p_Ekau9A7qIKWPH3n4iukg3a = __p_Ekau9A7qIKWPH3n4iukg3a;
                this.__p_N5QqZaAkdMTNMNFNdnVUoU = __p_N5QqZaAkdMTNMNFNdnVUoU;
                this.__p_BJ7Y5jADNNfPthHrqKfQHd = __p_BJ7Y5jADNNfPthHrqKfQHd;
                this.__p_R9T0bq9ZB8zPKD6mugiPMV = __p_R9T0bq9ZB8zPKD6mugiPMV;
                this.__p_HEb8kibmAUvPp7LCzqnh59 = __p_HEb8kibmAUvPp7LCzqnh59;
                this.__p_EaGTrQGlWWnNkAf0vdkSCB = __p_EaGTrQGlWWnNkAf0vdkSCB;
                this.__pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB = __pin_group_Child_In_EaGTrQGlWWnNkAf0vdkSCB;
                this.__p_QQyHwUHxbpGNiBaGFnCq31 = __p_QQyHwUHxbpGNiBaGFnCq31;
                this.__p_CMmAcXMEPFcQGMBASpUfa4 = __p_CMmAcXMEPFcQGMBASpUfa4;
                this.__p_TGaqE9XAoLvMIcFLRXc49a = __p_TGaqE9XAoLvMIcFLRXc49a;
                this.__p_SKrWf5e2Qh1NDQEgVEfFOB = __p_SKrWf5e2Qh1NDQEgVEfFOB;
                this.__p_AnySrXohzM4L9fzfb2yFWF = __p_AnySrXohzM4L9fzfb2yFWF;
                this.__pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF = __pin_group_Child_In_AnySrXohzM4L9fzfb2yFWF;
                this.__p_Jb49oG861DPL87MSSAVVtT = __p_Jb49oG861DPL87MSSAVVtT;
                this.__p_LhwmT3fbQU4L4uCcfkqBn8 = __p_LhwmT3fbQU4L4uCcfkqBn8;
                this.__p_G0oM3QInjsLQPW7P4SCcfW = __p_G0oM3QInjsLQPW7P4SCcfW;
                this.__p_StHT1NNUzl5MiqEEGVHrc0 = __p_StHT1NNUzl5MiqEEGVHrc0;
                this.__pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k = __pin_group_Input_In_EyLc7XdoYSUMSh7JbiKC4k;
                this.__p_LwRCLYxIu53PxSXTuvsgOV = __p_LwRCLYxIu53PxSXTuvsgOV;
                this.__p_NKNPlE5g1XKLBJ3Bl0r8X0 = __p_NKNPlE5g1XKLBJ3Bl0r8X0;
                this.__p_DMnnH1Kf4EmLDBBBLj4GcT = __p_DMnnH1Kf4EmLDBBBLj4GcT;
                this.__p_ULmyB5dpbyaMdKdw0vpfDp = __p_ULmyB5dpbyaMdKdw0vpfDp;
                this.__p_Q5Ckc7j8dHwPDBxnaZhBgd = __p_Q5Ckc7j8dHwPDBxnaZhBgd;
                this.__p_MdFqf5PXmLsMU2nO73hmMY = __p_MdFqf5PXmLsMU2nO73hmMY;
                this.__pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx = __pin_group_Input_In_RkrFPVbN3nMLIMLpFWccAx;
                this.__p_B65LHCjZaSYPOpObti5hKp = __p_B65LHCjZaSYPOpObti5hKp;
                this.__pin_group_Child_In_B65LHCjZaSYPOpObti5hKp = __pin_group_Child_In_B65LHCjZaSYPOpObti5hKp;
                this.__pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw = __pin_group_Input_In_IH8iiap2b4oOg8kaOCthBw;
                this.__p_GO8HMpNlikDNYGhQCIAv8G = __p_GO8HMpNlikDNYGhQCIAv8G;
                this.__pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G = __pin_group_Child_In_GO8HMpNlikDNYGhQCIAv8G;
                this.__p_CCRsbVu1Dw8On1sS2bLBuQ = __p_CCRsbVu1Dw8On1sS2bLBuQ;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "I30iaMzRRy4LNTxqhhvoVu", Name = "__I30iaMzRRy4LNTxqhhvoVu")]
        [n2.SerializableAttribute]
        public class __I30iaMzRRy4LNTxqhhvoVu : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_FLlTfOrpicKP5Vw6UpZWEG);
                n1.CompilationHelper.SafeDispose(this.__p_PYhtkVIxBSRNfTZ41JFxQm);
                n1.CompilationHelper.SafeDispose(this.__p_OZZRXF2oGSbNkdyx0cJDgs);
                n1.CompilationHelper.SafeDispose(this.__p_KhDhTGBxXYMNy4TUBnA7Y1);
                n1.CompilationHelper.SafeDispose(this.__p_M7GGPysJb1UPMbjG14NvwK);
                n1.CompilationHelper.SafeDispose(this.__p_V3eaLbPDXoLNN8p88OjuDF);
                n1.CompilationHelper.SafeDispose(this.__p_CnCFB7G36eZO6rhgt8ccAc);
                n1.CompilationHelper.SafeDispose(this.__p_F3cAGZxJ2NoMJ6ytBaA3RH);
                n1.CompilationHelper.SafeDispose(this.__p_HVF3nI6EZREOKWG7zQCEtL);
                n1.CompilationHelper.SafeDispose(this.__p_BkzEreSiWkoNgdbDWGOJ6b);
                n1.CompilationHelper.SafeDispose(this.__p_UGm6M1ifjE0LGowzDRvvZ6);
                n1.CompilationHelper.SafeDispose(this.__p_EnCvbImiDHANtpydvwVr4v);
                n1.CompilationHelper.SafeDispose(this.__if_Jun4ntyn4WHLhsavPcEVrr);
                return;
            }

            [n1.ElementAttribute(TracingId = 315977U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "FLlTfOrpicKP5Vw6UpZWEG", Name = "PostFX", IsManaged = true, IsAutoGenerated = true)]
            public n37.PostFX_C __p_FLlTfOrpicKP5Vw6UpZWEG;
            [n1.ElementAttribute(TracingId = 316007U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "PYhtkVIxBSRNfTZ41JFxQm", Name = "AmbientOcclusion", IsManaged = true, IsAutoGenerated = true, NodeName = "AmbientOcclusion", NodeCategory = "Stride.Rendering.PostFX")]
            public n1.IVLNode __p_PYhtkVIxBSRNfTZ41JFxQm;
            [n1.ElementAttribute(TracingId = 316030U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "OZZRXF2oGSbNkdyx0cJDgs", Name = "BrightFilter", IsManaged = true, IsAutoGenerated = true, NodeName = "BrightFilter", NodeCategory = "Stride.Rendering.PostFX")]
            public n1.IVLNode __p_OZZRXF2oGSbNkdyx0cJDgs;
            [n1.ElementAttribute(TracingId = 316042U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "KhDhTGBxXYMNy4TUBnA7Y1", Name = "Bloom", IsManaged = true, IsAutoGenerated = true, NodeName = "Bloom", NodeCategory = "Stride.Rendering.PostFX")]
            public n1.IVLNode __p_KhDhTGBxXYMNy4TUBnA7Y1;
            [n1.ElementAttribute(TracingId = 316061U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "M7GGPysJb1UPMbjG14NvwK", Name = "DepthOfField", IsManaged = true, IsAutoGenerated = true, NodeName = "DepthOfField", NodeCategory = "Stride.Rendering.PostFX")]
            public n1.IVLNode __p_M7GGPysJb1UPMbjG14NvwK;
            [n1.ElementAttribute(TracingId = 316076U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "V3eaLbPDXoLNN8p88OjuDF", Name = "LightStreak", IsManaged = true, IsAutoGenerated = true, NodeName = "LightStreak", NodeCategory = "Stride.Rendering.PostFX")]
            public n1.IVLNode __p_V3eaLbPDXoLNN8p88OjuDF;
            [n1.ElementAttribute(TracingId = 316094U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "CnCFB7G36eZO6rhgt8ccAc", Name = "LensFlare", IsManaged = true, IsAutoGenerated = true, NodeName = "LensFlare", NodeCategory = "Stride.Rendering.PostFX")]
            public n1.IVLNode __p_CnCFB7G36eZO6rhgt8ccAc;
            [n1.ElementAttribute(TracingId = 316107U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "F3cAGZxJ2NoMJ6ytBaA3RH", Name = "FXAAEffect", IsManaged = true, IsAutoGenerated = true, NodeName = "FXAAEffect", NodeCategory = "Stride.Rendering.PostFX")]
            public n1.IVLNode __p_F3cAGZxJ2NoMJ6ytBaA3RH;
            [n1.ElementAttribute(TracingId = 316123U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "HVF3nI6EZREOKWG7zQCEtL", Name = "ToneMap", IsManaged = true, IsAutoGenerated = true, NodeName = "ToneMap", NodeCategory = "Stride.Rendering.PostFX.ColorTransforms")]
            public n1.IVLNode __p_HVF3nI6EZREOKWG7zQCEtL;
            [n1.ElementAttribute(TracingId = 316149U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "BkzEreSiWkoNgdbDWGOJ6b", Name = "Vignetting", IsManaged = true, IsAutoGenerated = true, NodeName = "Vignetting", NodeCategory = "Stride.Rendering.PostFX.ColorTransforms")]
            public n1.IVLNode __p_BkzEreSiWkoNgdbDWGOJ6b;
            [n1.ElementAttribute(TracingId = 316163U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "UGm6M1ifjE0LGowzDRvvZ6", Name = "FilmGrain", IsManaged = true, IsAutoGenerated = true, NodeName = "FilmGrain", NodeCategory = "Stride.Rendering.PostFX.ColorTransforms")]
            public n1.IVLNode __p_UGm6M1ifjE0LGowzDRvvZ6;
            [n1.ElementAttribute(TracingId = 316242U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "EnCvbImiDHANtpydvwVr4v", Name = "U2Filmic", IsManaged = true, IsAutoGenerated = true, NodeName = "U2Filmic", NodeCategory = "Stride.Rendering.PostFX.ColorTransforms.ToneMapOperators")]
            public n1.IVLNode __p_EnCvbImiDHANtpydvwVr4v;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n20.Spread<n36.ColorTransform> __pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI = default(n20.Spread<n36.ColorTransform>);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_Jun4ntyn4WHLhsavPcEVrr;
            public __I30iaMzRRy4LNTxqhhvoVu(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __I30iaMzRRy4LNTxqhhvoVu(__I30iaMzRRy4LNTxqhhvoVu other): base(other)
            {
                this.__p_FLlTfOrpicKP5Vw6UpZWEG = other.__p_FLlTfOrpicKP5Vw6UpZWEG;
                this.__p_PYhtkVIxBSRNfTZ41JFxQm = other.__p_PYhtkVIxBSRNfTZ41JFxQm;
                this.__p_OZZRXF2oGSbNkdyx0cJDgs = other.__p_OZZRXF2oGSbNkdyx0cJDgs;
                this.__p_KhDhTGBxXYMNy4TUBnA7Y1 = other.__p_KhDhTGBxXYMNy4TUBnA7Y1;
                this.__p_M7GGPysJb1UPMbjG14NvwK = other.__p_M7GGPysJb1UPMbjG14NvwK;
                this.__p_V3eaLbPDXoLNN8p88OjuDF = other.__p_V3eaLbPDXoLNN8p88OjuDF;
                this.__p_CnCFB7G36eZO6rhgt8ccAc = other.__p_CnCFB7G36eZO6rhgt8ccAc;
                this.__p_F3cAGZxJ2NoMJ6ytBaA3RH = other.__p_F3cAGZxJ2NoMJ6ytBaA3RH;
                this.__p_HVF3nI6EZREOKWG7zQCEtL = other.__p_HVF3nI6EZREOKWG7zQCEtL;
                this.__p_BkzEreSiWkoNgdbDWGOJ6b = other.__p_BkzEreSiWkoNgdbDWGOJ6b;
                this.__p_UGm6M1ifjE0LGowzDRvvZ6 = other.__p_UGm6M1ifjE0LGowzDRvvZ6;
                this.__p_EnCvbImiDHANtpydvwVr4v = other.__p_EnCvbImiDHANtpydvwVr4v;
                this.__pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI = other.__pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI;
                this.__if_Jun4ntyn4WHLhsavPcEVrr = other.__if_Jun4ntyn4WHLhsavPcEVrr;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FLlTfOrpicKP5Vw6UpZWEG", in __p_FLlTfOrpicKP5Vw6UpZWEG), n1.CompilationHelper.GetValueOrExisting(values, "__p_PYhtkVIxBSRNfTZ41JFxQm", in __p_PYhtkVIxBSRNfTZ41JFxQm), n1.CompilationHelper.GetValueOrExisting(values, "__p_OZZRXF2oGSbNkdyx0cJDgs", in __p_OZZRXF2oGSbNkdyx0cJDgs), n1.CompilationHelper.GetValueOrExisting(values, "__p_KhDhTGBxXYMNy4TUBnA7Y1", in __p_KhDhTGBxXYMNy4TUBnA7Y1), n1.CompilationHelper.GetValueOrExisting(values, "__p_M7GGPysJb1UPMbjG14NvwK", in __p_M7GGPysJb1UPMbjG14NvwK), n1.CompilationHelper.GetValueOrExisting(values, "__p_V3eaLbPDXoLNN8p88OjuDF", in __p_V3eaLbPDXoLNN8p88OjuDF), n1.CompilationHelper.GetValueOrExisting(values, "__p_CnCFB7G36eZO6rhgt8ccAc", in __p_CnCFB7G36eZO6rhgt8ccAc), n1.CompilationHelper.GetValueOrExisting(values, "__p_F3cAGZxJ2NoMJ6ytBaA3RH", in __p_F3cAGZxJ2NoMJ6ytBaA3RH), n1.CompilationHelper.GetValueOrExisting(values, "__p_HVF3nI6EZREOKWG7zQCEtL", in __p_HVF3nI6EZREOKWG7zQCEtL), n1.CompilationHelper.GetValueOrExisting(values, "__p_BkzEreSiWkoNgdbDWGOJ6b", in __p_BkzEreSiWkoNgdbDWGOJ6b), n1.CompilationHelper.GetValueOrExisting(values, "__p_UGm6M1ifjE0LGowzDRvvZ6", in __p_UGm6M1ifjE0LGowzDRvvZ6), n1.CompilationHelper.GetValueOrExisting(values, "__p_EnCvbImiDHANtpydvwVr4v", in __p_EnCvbImiDHANtpydvwVr4v), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI", in __pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI), n1.CompilationHelper.GetValueOrExisting(values, "__if_Jun4ntyn4WHLhsavPcEVrr", in __if_Jun4ntyn4WHLhsavPcEVrr));
            }

            internal __I30iaMzRRy4LNTxqhhvoVu __WITH__(n37.PostFX_C __p_FLlTfOrpicKP5Vw6UpZWEG, n1.IVLNode __p_PYhtkVIxBSRNfTZ41JFxQm, n1.IVLNode __p_OZZRXF2oGSbNkdyx0cJDgs, n1.IVLNode __p_KhDhTGBxXYMNy4TUBnA7Y1, n1.IVLNode __p_M7GGPysJb1UPMbjG14NvwK, n1.IVLNode __p_V3eaLbPDXoLNN8p88OjuDF, n1.IVLNode __p_CnCFB7G36eZO6rhgt8ccAc, n1.IVLNode __p_F3cAGZxJ2NoMJ6ytBaA3RH, n1.IVLNode __p_HVF3nI6EZREOKWG7zQCEtL, n1.IVLNode __p_BkzEreSiWkoNgdbDWGOJ6b, n1.IVLNode __p_UGm6M1ifjE0LGowzDRvvZ6, n1.IVLNode __p_EnCvbImiDHANtpydvwVr4v, n20.Spread<n36.ColorTransform> __pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI, n2.Object __if_Jun4ntyn4WHLhsavPcEVrr)
            {
                __I30iaMzRRy4LNTxqhhvoVu that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_FLlTfOrpicKP5Vw6UpZWEG != this.__p_FLlTfOrpicKP5Vw6UpZWEG || __p_PYhtkVIxBSRNfTZ41JFxQm != this.__p_PYhtkVIxBSRNfTZ41JFxQm || __p_OZZRXF2oGSbNkdyx0cJDgs != this.__p_OZZRXF2oGSbNkdyx0cJDgs || __p_KhDhTGBxXYMNy4TUBnA7Y1 != this.__p_KhDhTGBxXYMNy4TUBnA7Y1 || __p_M7GGPysJb1UPMbjG14NvwK != this.__p_M7GGPysJb1UPMbjG14NvwK || __p_V3eaLbPDXoLNN8p88OjuDF != this.__p_V3eaLbPDXoLNN8p88OjuDF || __p_CnCFB7G36eZO6rhgt8ccAc != this.__p_CnCFB7G36eZO6rhgt8ccAc || __p_F3cAGZxJ2NoMJ6ytBaA3RH != this.__p_F3cAGZxJ2NoMJ6ytBaA3RH || __p_HVF3nI6EZREOKWG7zQCEtL != this.__p_HVF3nI6EZREOKWG7zQCEtL || __p_BkzEreSiWkoNgdbDWGOJ6b != this.__p_BkzEreSiWkoNgdbDWGOJ6b || __p_UGm6M1ifjE0LGowzDRvvZ6 != this.__p_UGm6M1ifjE0LGowzDRvvZ6 || __p_EnCvbImiDHANtpydvwVr4v != this.__p_EnCvbImiDHANtpydvwVr4v || __pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI != this.__pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI || __if_Jun4ntyn4WHLhsavPcEVrr != this.__if_Jun4ntyn4WHLhsavPcEVrr ? new __I30iaMzRRy4LNTxqhhvoVu(this)
                    {__p_FLlTfOrpicKP5Vw6UpZWEG = __p_FLlTfOrpicKP5Vw6UpZWEG, __p_PYhtkVIxBSRNfTZ41JFxQm = __p_PYhtkVIxBSRNfTZ41JFxQm, __p_OZZRXF2oGSbNkdyx0cJDgs = __p_OZZRXF2oGSbNkdyx0cJDgs, __p_KhDhTGBxXYMNy4TUBnA7Y1 = __p_KhDhTGBxXYMNy4TUBnA7Y1, __p_M7GGPysJb1UPMbjG14NvwK = __p_M7GGPysJb1UPMbjG14NvwK, __p_V3eaLbPDXoLNN8p88OjuDF = __p_V3eaLbPDXoLNN8p88OjuDF, __p_CnCFB7G36eZO6rhgt8ccAc = __p_CnCFB7G36eZO6rhgt8ccAc, __p_F3cAGZxJ2NoMJ6ytBaA3RH = __p_F3cAGZxJ2NoMJ6ytBaA3RH, __p_HVF3nI6EZREOKWG7zQCEtL = __p_HVF3nI6EZREOKWG7zQCEtL, __p_BkzEreSiWkoNgdbDWGOJ6b = __p_BkzEreSiWkoNgdbDWGOJ6b, __p_UGm6M1ifjE0LGowzDRvvZ6 = __p_UGm6M1ifjE0LGowzDRvvZ6, __p_EnCvbImiDHANtpydvwVr4v = __p_EnCvbImiDHANtpydvwVr4v, __pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI = __pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI, __if_Jun4ntyn4WHLhsavPcEVrr = __if_Jun4ntyn4WHLhsavPcEVrr} : that_0;
                else
                {
                    this.__p_FLlTfOrpicKP5Vw6UpZWEG = __p_FLlTfOrpicKP5Vw6UpZWEG;
                    this.__p_PYhtkVIxBSRNfTZ41JFxQm = __p_PYhtkVIxBSRNfTZ41JFxQm;
                    this.__p_OZZRXF2oGSbNkdyx0cJDgs = __p_OZZRXF2oGSbNkdyx0cJDgs;
                    this.__p_KhDhTGBxXYMNy4TUBnA7Y1 = __p_KhDhTGBxXYMNy4TUBnA7Y1;
                    this.__p_M7GGPysJb1UPMbjG14NvwK = __p_M7GGPysJb1UPMbjG14NvwK;
                    this.__p_V3eaLbPDXoLNN8p88OjuDF = __p_V3eaLbPDXoLNN8p88OjuDF;
                    this.__p_CnCFB7G36eZO6rhgt8ccAc = __p_CnCFB7G36eZO6rhgt8ccAc;
                    this.__p_F3cAGZxJ2NoMJ6ytBaA3RH = __p_F3cAGZxJ2NoMJ6ytBaA3RH;
                    this.__p_HVF3nI6EZREOKWG7zQCEtL = __p_HVF3nI6EZREOKWG7zQCEtL;
                    this.__p_BkzEreSiWkoNgdbDWGOJ6b = __p_BkzEreSiWkoNgdbDWGOJ6b;
                    this.__p_UGm6M1ifjE0LGowzDRvvZ6 = __p_UGm6M1ifjE0LGowzDRvvZ6;
                    this.__p_EnCvbImiDHANtpydvwVr4v = __p_EnCvbImiDHANtpydvwVr4v;
                    this.__pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI = __pin_group_Input_In_Q52rFoPKj7XPbO9uyW02kI;
                    this.__if_Jun4ntyn4WHLhsavPcEVrr = __if_Jun4ntyn4WHLhsavPcEVrr;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "UOlCd7KUusFLxKiyLKA8mC", Name = "__UOlCd7KUusFLxKiyLKA8mC")]
        [n2.SerializableAttribute]
        public class __UOlCd7KUusFLxKiyLKA8mC : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_CKHkgLZlmn9PzK6bD0B0fK);
                return;
            }

            [n1.ElementAttribute(TracingId = 316218U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "CKHkgLZlmn9PzK6bD0B0fK", Name = "LocalReflections", IsManaged = true, IsAutoGenerated = true, NodeName = "LocalReflections", NodeCategory = "Stride.Rendering.PostFX")]
            public n1.IVLNode __p_CKHkgLZlmn9PzK6bD0B0fK;
            public __UOlCd7KUusFLxKiyLKA8mC(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __UOlCd7KUusFLxKiyLKA8mC(__UOlCd7KUusFLxKiyLKA8mC other): base(other)
            {
                this.__p_CKHkgLZlmn9PzK6bD0B0fK = other.__p_CKHkgLZlmn9PzK6bD0B0fK;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_CKHkgLZlmn9PzK6bD0B0fK", in __p_CKHkgLZlmn9PzK6bD0B0fK));
            }

            internal __UOlCd7KUusFLxKiyLKA8mC __WITH__(n1.IVLNode __p_CKHkgLZlmn9PzK6bD0B0fK)
            {
                __UOlCd7KUusFLxKiyLKA8mC that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_CKHkgLZlmn9PzK6bD0B0fK != this.__p_CKHkgLZlmn9PzK6bD0B0fK ? new __UOlCd7KUusFLxKiyLKA8mC(this)
                    {__p_CKHkgLZlmn9PzK6bD0B0fK = __p_CKHkgLZlmn9PzK6bD0B0fK} : that_0;
                else
                {
                    this.__p_CKHkgLZlmn9PzK6bD0B0fK = __p_CKHkgLZlmn9PzK6bD0B0fK;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 317082U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "O8ezeO8JfIhPrzbCh9XULr", Name = "HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr")]
    [n2.SerializableAttribute]
    public class HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr Create(n1.NodeContext Node_Context)
        {
            var instance = new HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr CreateDefault()
        {
            var instance = new HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr Update(n16.Entity Scene_In, n16.Entity Camera_In, [n5.SerializedDefaultValueAttribute("True", false)] bool PostFX_Enabled_In, [n5.SerializedDefaultValueAttribute("0, 0, 0, 1", false)] n7.Color4 Clear_Color_In, [n5.SerializedDefaultValueAttribute("True", false)] bool DoF_Enabled_In, [n5.SerializedDefaultValueAttribute("False", false)] bool Auto_Focus_In, [n5.SerializedDefaultValueAttribute("False", false)] bool Show_Guide_In, [n5.SerializedDefaultValueAttribute("False", false)] bool Stage_Enabled_In, [n5.SerializedDefaultValueAttribute("4", false)] int LightPreset_In, bool Background_Enabled_In, [n5.SerializedDefaultValueAttribute("FUSE Help", false)] string Title_In)
        {
            var Output_3 = this.__p_DnSoQxjr1whNwm4Dy22vj3.Update(PostFX_Enabled_In: PostFX_Enabled_In, DoF_Enabled_In: DoF_Enabled_In, Auto_Focus_In: Auto_Focus_In, Show_Guide_In: Show_Guide_In, Stage_Enabled_In: Stage_Enabled_In, LightPreset_In: LightPreset_In, Background_Enabled_In: Background_Enabled_In, Lights_Out: out n16.Entity Lights_0, PostFX_Out: out n36.PostProcessingEffects PostFX_1, LightShafts_Out: out n36.LightShafts LightShafts_2);
            n20.Spread<n16.Scene> Child_Scenes_4 = n23._Operations_.CreateDefault<n16.Scene>();
            bool Enabled_5 = true;
            var builder_6 = n5.CollectionBuilders.GetBuilder(this.__pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif, 2);
            builder_6.Add(Scene_In);
            builder_6.Add(Lights_0);
            var __pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif_7 = builder_6.Commit();
            var State_Output_9 = this.__p_AnsJb4TohrxO4oIMtWCQif.Update(Child_In: __pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif_7, Child_Scenes_In: Child_Scenes_4, Enabled_In: Enabled_5, Output_Out: out n16.SceneInstance Output_8);
            n36.IPostProcessingEffects Post_Effects_10 = (n36.IPostProcessingEffects)PostFX_1;
            string __pad_Sg8y0d0BCG6MvJzdFXyZBG_11 = Title_In;
            bool Enable_Default_Camera_12 = true;
            bool Clear_13 = true;
            bool Enable_Default_Post_Effects_14 = true;
            n9.RenderGroupMask Render_Group_Mask_15 = n1.CompilationHelper.Deserialize<n9.RenderGroupMask>("All", false, null, null);
            bool Enable_Keyboard_Shortcuts_16 = true;
            string Model_Effect_Name_17 = "VLEffectMain";
            n20.Spread<n37.IAdditionalSceneRenderer_I> Additional_Scene_Renderers_18 = n23._Operations_.CreateDefault<n37.IAdditionalSceneRenderer_I>();
            bool Enabled_19 = true;
            var State_Output_21 = this.__p_Hv3Kj6CkyMeM3PcHq0qG5i.Update(Input_In: Output_8, Camera_In: Camera_In, Enable_Default_Camera_In: Enable_Default_Camera_12, Title_In: __pad_Sg8y0d0BCG6MvJzdFXyZBG_11, Clear_Color_In: Clear_Color_In, Clear_In: Clear_13, Post_Effects_In: Post_Effects_10, Enable_Default_Post_Effects_In: Enable_Default_Post_Effects_14, Render_Group_Mask_In: Render_Group_Mask_15, Enable_Keyboard_Shortcuts_In: Enable_Keyboard_Shortcuts_16, Model_Effect_Name_In: Model_Effect_Name_17, Additional_Scene_Renderers_In: Additional_Scene_Renderers_18, Enabled_In: Enabled_19, Output_Out: out n38.GameWindow Output_20);
            bool SetLightShafts_22 = true;
            var Output_23 = State_Output_21;
            if (SetLightShafts_22)
            {
                Output_23 = State_Output_21.SetLightShafts(Light_Shafts_In: LightShafts_2);
            }

            n4.HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr that_24 = this;
            if (this.__GetContext__().IsImmutable)
                that_24 = Output_3 != this.__p_DnSoQxjr1whNwm4Dy22vj3 || __pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif_7 != this.__pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif || State_Output_9 != this.__p_AnsJb4TohrxO4oIMtWCQif || Title_In != this.__slot_Sg8y0d0BCG6MvJzdFXyZBG || Output_23 != this.__p_Hv3Kj6CkyMeM3PcHq0qG5i ? new HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr(this)
                {__p_DnSoQxjr1whNwm4Dy22vj3 = Output_3, __pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif = __pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif_7, __p_AnsJb4TohrxO4oIMtWCQif = State_Output_9, __slot_Sg8y0d0BCG6MvJzdFXyZBG = Title_In, __p_Hv3Kj6CkyMeM3PcHq0qG5i = Output_23} : that_24;
            else
            {
                this.__p_DnSoQxjr1whNwm4Dy22vj3 = Output_3;
                this.__pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif = __pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif_7;
                this.__p_AnsJb4TohrxO4oIMtWCQif = State_Output_9;
                this.__slot_Sg8y0d0BCG6MvJzdFXyZBG = Title_In;
                this.__p_Hv3Kj6CkyMeM3PcHq0qG5i = Output_23;
            }

            return that_24;
        }

        public n4.HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Hv3Kj6CkyMeM3PcHq0qG5i", 317086U);
            n7.RectangleF Bounds_1 = __c_ULc0HIvMlSPOzy8Cvje9xH;
            bool Bound_to_Document_2 = true;
            bool Dialog_If_Document_Changed_3 = false;
            bool Save_Bounds_4 = true;
            n18.PixelFormat Back_Buffer_Format_5 = n1.CompilationHelper.Deserialize<n18.PixelFormat>("R8G8B8A8_UNorm_SRgb", false, null, null);
            n18.PixelFormat Depth_Buffer_Format_6 = n1.CompilationHelper.Deserialize<n18.PixelFormat>("D24_UNorm_S8_UInt", false, null, null);
            var Output_7 = n30.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k.Create(Node_Context: Node_Context_0, Bounds_In: Bounds_1, Bound_to_Document_In: Bound_to_Document_2, Dialog_If_Document_Changed_In: Dialog_If_Document_Changed_3, Save_Bounds_In: Save_Bounds_4, Back_Buffer_Format_In: Back_Buffer_Format_5, Depth_Buffer_Format_In: Depth_Buffer_Format_6);
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "AnsJb4TohrxO4oIMtWCQif", 317127U);
            var Output_9 = n30.RootScene_GcBzJdp7uHFN7DqiDqkHlb.Create(Node_Context: Node_Context_8);
            n1.NodeContext Node_Context_10 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "DnSoQxjr1whNwm4Dy22vj3", 317140U);
            var Output_11 = n4.LightStudios_Iu0D0SDDMseNZZodQPhpqH.Create(Node_Context: Node_Context_10);
            n4.HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr that_12 = this;
            this.__slot_Sg8y0d0BCG6MvJzdFXyZBG = "";
            this.__pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif = n23._Operations_.CreateDefault<n16.Entity>();
            this.__p_Hv3Kj6CkyMeM3PcHq0qG5i = Output_7;
            this.__p_AnsJb4TohrxO4oIMtWCQif = Output_9;
            this.__p_DnSoQxjr1whNwm4Dy22vj3 = Output_11;
            return that_12;
        }

        public n4.HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr __CreateDefault__()
        {
            n4.HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr that_0 = this;
            this.__slot_Sg8y0d0BCG6MvJzdFXyZBG = "";
            this.__pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif = n23._Operations_.CreateDefault<n16.Entity>();
            this.__p_DnSoQxjr1whNwm4Dy22vj3 = n4.LightStudios_Iu0D0SDDMseNZZodQPhpqH.CreateDefault();
            this.__p_AnsJb4TohrxO4oIMtWCQif = n30.RootScene_GcBzJdp7uHFN7DqiDqkHlb.CreateDefault();
            this.__p_Hv3Kj6CkyMeM3PcHq0qG5i = n30.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DnSoQxjr1whNwm4Dy22vj3);
            n1.CompilationHelper.SafeDispose(this.__p_AnsJb4TohrxO4oIMtWCQif);
            n1.CompilationHelper.SafeDispose(this.__p_Hv3Kj6CkyMeM3PcHq0qG5i);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 317167U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Sg8y0d0BCG6MvJzdFXyZBG", Name = "__slot_Sg8y0d0BCG6MvJzdFXyZBG")]
        public string __slot_Sg8y0d0BCG6MvJzdFXyZBG;
        [n1.ElementAttribute(TracingId = 317140U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "DnSoQxjr1whNwm4Dy22vj3", Name = "LightStudios", IsManaged = true, IsAutoGenerated = true)]
        public n4.LightStudios_Iu0D0SDDMseNZZodQPhpqH __p_DnSoQxjr1whNwm4Dy22vj3;
        [n1.ElementAttribute(TracingId = 317127U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "AnsJb4TohrxO4oIMtWCQif", Name = "RootScene", IsManaged = true, IsAutoGenerated = true)]
        public n30.RootScene_GcBzJdp7uHFN7DqiDqkHlb __p_AnsJb4TohrxO4oIMtWCQif;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<n16.Entity> __pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif = default(n20.Spread<n16.Entity>);
        [n1.ElementAttribute(TracingId = 317086U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Hv3Kj6CkyMeM3PcHq0qG5i", Name = "SceneWindow", IsManaged = true, IsAutoGenerated = true)]
        public n30.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k __p_Hv3Kj6CkyMeM3PcHq0qG5i;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.RectangleF __c_ULc0HIvMlSPOzy8Cvje9xH = n1.CompilationHelper.Deserialize<n7.RectangleF>("1364, 461, 1115, 988", false, "JPmuEharYwiLQs6dOuoEQQ", "ULc0HIvMlSPOzy8Cvje9xH");
        static HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr()
        {
        }

        public HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr(HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr other): base(other)
        {
            this.__slot_Sg8y0d0BCG6MvJzdFXyZBG = other.__slot_Sg8y0d0BCG6MvJzdFXyZBG;
            this.__p_DnSoQxjr1whNwm4Dy22vj3 = other.__p_DnSoQxjr1whNwm4Dy22vj3;
            this.__p_AnsJb4TohrxO4oIMtWCQif = other.__p_AnsJb4TohrxO4oIMtWCQif;
            this.__pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif = other.__pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif;
            this.__p_Hv3Kj6CkyMeM3PcHq0qG5i = other.__p_Hv3Kj6CkyMeM3PcHq0qG5i;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Sg8y0d0BCG6MvJzdFXyZBG", in __slot_Sg8y0d0BCG6MvJzdFXyZBG), n1.CompilationHelper.GetValueOrExisting(values, "__p_DnSoQxjr1whNwm4Dy22vj3", in __p_DnSoQxjr1whNwm4Dy22vj3), n1.CompilationHelper.GetValueOrExisting(values, "__p_AnsJb4TohrxO4oIMtWCQif", in __p_AnsJb4TohrxO4oIMtWCQif), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif", in __pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif), n1.CompilationHelper.GetValueOrExisting(values, "__p_Hv3Kj6CkyMeM3PcHq0qG5i", in __p_Hv3Kj6CkyMeM3PcHq0qG5i));
        }

        internal HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr __WITH__(string __slot_Sg8y0d0BCG6MvJzdFXyZBG, n4.LightStudios_Iu0D0SDDMseNZZodQPhpqH __p_DnSoQxjr1whNwm4Dy22vj3, n30.RootScene_GcBzJdp7uHFN7DqiDqkHlb __p_AnsJb4TohrxO4oIMtWCQif, n20.Spread<n16.Entity> __pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif, n30.SceneWindow_Hcvhp04ldd6NeZxLwOrv9k __p_Hv3Kj6CkyMeM3PcHq0qG5i)
        {
            n4.HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_Sg8y0d0BCG6MvJzdFXyZBG != this.__slot_Sg8y0d0BCG6MvJzdFXyZBG || __p_DnSoQxjr1whNwm4Dy22vj3 != this.__p_DnSoQxjr1whNwm4Dy22vj3 || __p_AnsJb4TohrxO4oIMtWCQif != this.__p_AnsJb4TohrxO4oIMtWCQif || __pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif != this.__pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif || __p_Hv3Kj6CkyMeM3PcHq0qG5i != this.__p_Hv3Kj6CkyMeM3PcHq0qG5i ? new HelpWindow__3D_View_O8ezeO8JfIhPrzbCh9XULr(this)
                {__slot_Sg8y0d0BCG6MvJzdFXyZBG = __slot_Sg8y0d0BCG6MvJzdFXyZBG, __p_DnSoQxjr1whNwm4Dy22vj3 = __p_DnSoQxjr1whNwm4Dy22vj3, __p_AnsJb4TohrxO4oIMtWCQif = __p_AnsJb4TohrxO4oIMtWCQif, __pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif = __pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif, __p_Hv3Kj6CkyMeM3PcHq0qG5i = __p_Hv3Kj6CkyMeM3PcHq0qG5i} : that_0;
            else
            {
                this.__slot_Sg8y0d0BCG6MvJzdFXyZBG = __slot_Sg8y0d0BCG6MvJzdFXyZBG;
                this.__p_DnSoQxjr1whNwm4Dy22vj3 = __p_DnSoQxjr1whNwm4Dy22vj3;
                this.__p_AnsJb4TohrxO4oIMtWCQif = __p_AnsJb4TohrxO4oIMtWCQif;
                this.__pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif = __pin_group_Child_In_AnsJb4TohrxO4oIMtWCQif;
                this.__p_Hv3Kj6CkyMeM3PcHq0qG5i = __p_Hv3Kj6CkyMeM3PcHq0qG5i;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 317238U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "TTeljbbbzLSL2j8U6uqzc8", Name = "Graph_TTeljbbbzLSL2j8U6uqzc8")]
    [n2.SerializableAttribute]
    public class Graph_TTeljbbbzLSL2j8U6uqzc8 : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Graph_TTeljbbbzLSL2j8U6uqzc8 Create(n1.NodeContext Node_Context)
        {
            var instance = new Graph_TTeljbbbzLSL2j8U6uqzc8(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Graph_TTeljbbbzLSL2j8U6uqzc8 CreateDefault()
        {
            var instance = new Graph_TTeljbbbzLSL2j8U6uqzc8(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Graph_TTeljbbbzLSL2j8U6uqzc8 Update(n19.GpuValue<float> InputT_In, [n5.SerializedDefaultValueAttribute("1", false)] float Zoom_In, n7.Vector2 Pan_In, [n5.SerializedDefaultValueAttribute("0.01", false)] n19.GpuValue<float> Width_In, out n19.GpuValue<n7.Vector4> Output_Out)
        {
            string __pad_OqLtNSBS0rQPZda4f8RNza_0 = __slot_OqLtNSBS0rQPZda4f8RNza;
            var State_Output_2 = this.__p_PFTs8Xrm9jzNjKm5jHUuFX.Update(Output_Out: out n19.GpuValue<float> Output_1);
            var State_Output_4 = this.__p_S7odYVKT3CPNtBOdpEAc70.Update(Output_Out: out n19.GpuValue<n7.Vector2> Output_3);
            bool Force_5 = false;
            bool Dispose_Cached_Outputs_6 = false;
            var manager_7 = this.__cache_BPAhDLVF9meLWTHWDAxKS7;
            if (manager_7 is null)
            {
                manager_7 = new n59.Manager<n2.ValueTuple<n19.GpuValue<float>, n19.GpuValue<n7.Vector2>, n19.GpuValue<float>, n19.GpuValue<float>, string>, n2.ValueTuple<n19.GpuValue<n7.Vector4>>>(n2.ValueTuple.Create(default(n19.GpuValue<n7.Vector4>)));
            }

            var inputs_8 = (Output_1, Output_3, Width_In, InputT_In, __pad_OqLtNSBS0rQPZda4f8RNza_0);
            var outputs_9 = manager_7.Outputs;
            var Has_Changed_10 = Force_5 || manager_7.InputsChanged(inputs_8);
            if (Has_Changed_10)
            {
                if (Dispose_Cached_Outputs_6)
                    manager_7.DisposeOutputs();
                var state_11 = n1.CompilationHelper.Restore<__E4kcHNPLXyYMyeLt5yXQuA>(manager_7.State, __GetContext__());
                if (state_11 == null)
                {
                    state_11 = new __E4kcHNPLXyYMyeLt5yXQuA(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa = n23._Operations_.CreateDefault<n19.GpuValue<n7.Vector2>>(), __slot_IdygOFECN10OHqRwbx3KL2 = default(n19.GpuValue<float>), __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg = n23._Operations_.CreateDefault<n19.AbstractGpuValue>(), __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU = n23._Operations_.CreateDefault<n19.IFunctionInvokeNode>(), __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z = n23._Operations_.CreateDefault<n19.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Q1VcR9z5rS9LbldVwK5O9z", 317258U);
                    var Output_13 = n60.CustomFunction_SbJY8E2PFscPAropl3Jh79<n7.Vector4, n13.IEnumerable<n19.InputModifier>>.Create(Node_Context: Node_Context_12);
                    state_11.__p_Q1VcR9z5rS9LbldVwK5O9z = Output_13;
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "OMauLx7vDeaMczsvx2tqQw", 317283U);
                    var Output_15 = n61.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<float>.Create(Node_Context: Node_Context_14);
                    state_11.__p_OMauLx7vDeaMczsvx2tqQw = Output_15;
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Kks7RMQJO2APZJW27DZhHg", 317293U);
                    var Output_17 = n61.Function_IubJYJ2Zy72PGqdBGy0rgZ<float>.Create(Node_Context: Node_Context_16);
                    state_11.__p_Kks7RMQJO2APZJW27DZhHg = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "NU6y2j6bGJbNJv5w5EK8XY", 317307U);
                    var Output_19 = n62.UVSpace_TTfuBbKAgyvPaTVshEyQ40.Create(Node_Context: Node_Context_18);
                    state_11.__p_NU6y2j6bGJbNJv5w5EK8XY = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "PLHJZQtLhrhNRGwhDsIfJP", 317312U);
                    var Output_21 = n31.FuseColors_DoTfmLFOXmxO9Gz80n2F7s.Create(Node_Context: Node_Context_20);
                    state_11.__p_PLHJZQtLhrhNRGwhDsIfJP = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "C74HLcVclrYPqbgkUkbkSa", 317358U);
                    var Output_23 = n63.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n7.Vector2>.Create(Node_Context: Node_Context_22);
                    state_11.__p_C74HLcVclrYPqbgkUkbkSa = Output_23;
                }

                string __pad_QGbY53nmykjPztMQe73BTr_24 = __slot_QGbY53nmykjPztMQe73BTr;
                string __pad_IqxH2pVenOOOkHGV4ipavV_25 = __slot_IqxH2pVenOOOkHGV4ipavV;
                bool Map_To_Screen_Coords_26 = true;
                var State_Output_28 = state_11.__p_NU6y2j6bGJbNJv5w5EK8XY.Update(Map_To_Screen_Coords_In: Map_To_Screen_Coords_26, Output_Out: out n19.GpuValue<n7.Vector2> Output_27);
                n19.GpuValue<n7.Vector2> Input_2_29 = default(n19.GpuValue<n7.Vector2>);
                var builder_30 = n5.CollectionBuilders.GetBuilder(state_11.__pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa, 2);
                builder_30.Add(Output_27);
                builder_30.Add(Input_2_29);
                var __pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa_31 = builder_30.Commit();
                var State_Output_33 = state_11.__p_C74HLcVclrYPqbgkUkbkSa.Update(Input_In: __pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa_31, Output_Out: out n19.GpuValue<n7.Vector2> Output_32);
                var Output_41 = state_11.__p_PLHJZQtLhrhNRGwhDsIfJP.Update(Color_Palette_Out: out n20.Spread<n7.Color4> Color_Palette_34, Color_Palette_GPU_Out: out n20.Spread<n19.GpuValue<n7.Vector4>> Color_Palette_GPU_35, Black_Out: out n7.Color4 Black_36, White_Out: out n7.Color4 White_37, Tone_Light_Out: out n7.Color4 Tone_Light_38, Tone_Dark_Out: out n7.Color4 Tone_Dark_39, Tone_Saturated_Out: out n7.Color4 Tone_Saturated_40);
                n19.GpuValue<n7.Vector4> Default_Value_42 = default(n19.GpuValue<n7.Vector4>);
                int Index_43 = 4;
                n23._Operations_.GetSlice<n19.GpuValue<n7.Vector4>>(Input_In: Color_Palette_GPU_35, Default_Value_In: Default_Value_42, Index_In: Index_43, Result_Out: out n19.GpuValue<n7.Vector4> Result_44);
                n19.GpuValue<n7.Vector4> Default_Value_45 = default(n19.GpuValue<n7.Vector4>);
                int Index_46 = 3;
                n23._Operations_.GetSlice<n19.GpuValue<n7.Vector4>>(Input_In: Color_Palette_GPU_35, Default_Value_In: Default_Value_45, Index_In: Index_46, Result_Out: out n19.GpuValue<n7.Vector4> Result_47);
                n19.GpuValue<n7.Vector4> Default_Value_48 = default(n19.GpuValue<n7.Vector4>);
                int Index_49 = 2;
                n23._Operations_.GetSlice<n19.GpuValue<n7.Vector4>>(Input_In: Color_Palette_GPU_35, Default_Value_In: Default_Value_48, Index_In: Index_49, Result_Out: out n19.GpuValue<n7.Vector4> Result_50);
                n19.GpuValue<float> __pad_IdygOFECN10OHqRwbx3KL2_51 = InputT_In;
                n64._Operations_.TypeFloat(Input_In: __pad_IdygOFECN10OHqRwbx3KL2_51, Output_Out: out n19.GpuValue<float> Output_52);
                n19.GpuValue<float> The_Override_53 = default(n19.GpuValue<float>);
                int Id_54 = 0;
                var State_Output_56 = state_11.__p_OMauLx7vDeaMczsvx2tqQw.Update(The_Override_In: The_Override_53, Id_In: Id_54, Output_Out: out n19.GpuValue<float> Output_55);
                n64._Operations_.TypeFloat(Input_In: Output_55, Output_Out: out n19.GpuValue<float> Output_57);
                var builder_58 = n5.CollectionBuilders.GetBuilder(state_11.__pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg, 1);
                builder_58.Add(Output_57);
                var __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg_59 = builder_58.Commit();
                var State_Output_61 = state_11.__p_Kks7RMQJO2APZJW27DZhHg.Update(Function_In: Output_52, Parameters_In: __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg_59, Id_In: __pad_IqxH2pVenOOOkHGV4ipavV_25, Output_Out: out n19.FunctionInvokeNode<float> Output_60);
                n19.IFunctionInvokeNode Input_62 = (n19.IFunctionInvokeNode)Output_60;
                var builder_63 = n5.CollectionBuilders.GetBuilder(state_11.__pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU, 1);
                builder_63.Add(Input_62);
                var __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU_64 = builder_63.Commit();
                n23._Operations_.Cons<n19.IFunctionInvokeNode>(Input_In: __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU_64, Result_Out: out n20.Spread<n19.IFunctionInvokeNode> Result_65);
                n19.GpuValue<n7.Vector4> Default_Result_66 = default(n19.GpuValue<n7.Vector4>);
                n13.IEnumerable<string> Mixins_67 = n51._Operations_.CreateDefault<string>();
                n24.ImmutableDictionary<string, string> Template_Values_68 = n28._Operations_.CreateDefault<string, string>();
                bool Is_Groupable_69 = false;
                n13.IEnumerable<n19.InputModifier> The_Modifiers_70 = n51._Operations_.CreateDefault<n19.InputModifier>();
                var builder_71 = n5.CollectionBuilders.GetBuilder(state_11.__pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z, 7);
                builder_71.Add(Output_32);
                builder_71.Add(Output_1);
                builder_71.Add(Output_3);
                builder_71.Add(Width_In);
                builder_71.Add(Result_44);
                builder_71.Add(Result_47);
                builder_71.Add(Result_50);
                var __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z_72 = builder_71.Commit();
                var State_Output_75 = state_11.__p_Q1VcR9z5rS9LbldVwK5O9z.Update(Arguments_In: __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z_72, Function_Name_In: __pad_QGbY53nmykjPztMQe73BTr_24, Code_Template_In: __pad_OqLtNSBS0rQPZda4f8RNza_0, Default_Result_In: Default_Result_66, Functions_In: Result_65, Mixins_In: Mixins_67, Template_Values_In: Template_Values_68, Is_Groupable_In: Is_Groupable_69, The_Modifiers_In: The_Modifiers_70, Output_Out: out n19.GpuValue<n7.Vector4> Output_73, AdditionalOutputs_Out: out n20.Spread<n19.AbstractGpuValue> AdditionalOutputs_74);
                n64._Operations_.TypeVector4(Input_In: Output_73, Output_Out: out n19.GpuValue<n7.Vector4> Output_76);
                if (state_11.__GetContext__().IsImmutable)
                    state_11 = State_Output_28 != state_11.__p_NU6y2j6bGJbNJv5w5EK8XY || __pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa_31 != state_11.__pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa || State_Output_33 != state_11.__p_C74HLcVclrYPqbgkUkbkSa || Output_41 != state_11.__p_PLHJZQtLhrhNRGwhDsIfJP || InputT_In != state_11.__slot_IdygOFECN10OHqRwbx3KL2 || State_Output_56 != state_11.__p_OMauLx7vDeaMczsvx2tqQw || __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg_59 != state_11.__pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg || State_Output_61 != state_11.__p_Kks7RMQJO2APZJW27DZhHg || __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU_64 != state_11.__pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU || __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z_72 != state_11.__pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z || State_Output_75 != state_11.__p_Q1VcR9z5rS9LbldVwK5O9z ? new __E4kcHNPLXyYMyeLt5yXQuA(state_11)
                    {__p_NU6y2j6bGJbNJv5w5EK8XY = State_Output_28, __pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa = __pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa_31, __p_C74HLcVclrYPqbgkUkbkSa = State_Output_33, __p_PLHJZQtLhrhNRGwhDsIfJP = Output_41, __slot_IdygOFECN10OHqRwbx3KL2 = InputT_In, __p_OMauLx7vDeaMczsvx2tqQw = State_Output_56, __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg = __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg_59, __p_Kks7RMQJO2APZJW27DZhHg = State_Output_61, __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU = __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU_64, __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z = __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z_72, __p_Q1VcR9z5rS9LbldVwK5O9z = State_Output_75} : state_11;
                else
                {
                    state_11.__p_NU6y2j6bGJbNJv5w5EK8XY = State_Output_28;
                    state_11.__pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa = __pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa_31;
                    state_11.__p_C74HLcVclrYPqbgkUkbkSa = State_Output_33;
                    state_11.__p_PLHJZQtLhrhNRGwhDsIfJP = Output_41;
                    state_11.__slot_IdygOFECN10OHqRwbx3KL2 = InputT_In;
                    state_11.__p_OMauLx7vDeaMczsvx2tqQw = State_Output_56;
                    state_11.__pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg = __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg_59;
                    state_11.__p_Kks7RMQJO2APZJW27DZhHg = State_Output_61;
                    state_11.__pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU = __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU_64;
                    state_11.__pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z = __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z_72;
                    state_11.__p_Q1VcR9z5rS9LbldVwK5O9z = State_Output_75;
                }

                outputs_9 = n2.ValueTuple.Create(Output_76);
                manager_7 = manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6, state_11, outputs_9);
            }
            else
            {
                manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6);
            }

            var __auto_77 = outputs_9.Item1;
            bool SetValue_78 = true;
            var Output_79 = State_Output_2;
            if (SetValue_78)
            {
                Output_79 = State_Output_2.SetValue(Input_In: Zoom_In);
            }

            bool SetValue_80 = true;
            var Output_81 = State_Output_4;
            if (SetValue_80)
            {
                Output_81 = State_Output_4.SetValue(Input_In: Pan_In);
            }

            Output_Out = __auto_77;
            n4.Graph_TTeljbbbzLSL2j8U6uqzc8 that_82 = this;
            if (this.__GetContext__().IsImmutable)
                that_82 = Output_79 != this.__p_PFTs8Xrm9jzNjKm5jHUuFX || Output_81 != this.__p_S7odYVKT3CPNtBOdpEAc70 || manager_7 != this.__cache_BPAhDLVF9meLWTHWDAxKS7 ? new Graph_TTeljbbbzLSL2j8U6uqzc8(this)
                {__p_PFTs8Xrm9jzNjKm5jHUuFX = Output_79, __p_S7odYVKT3CPNtBOdpEAc70 = Output_81, __cache_BPAhDLVF9meLWTHWDAxKS7 = manager_7} : that_82;
            else
            {
                this.__p_PFTs8Xrm9jzNjKm5jHUuFX = Output_79;
                this.__p_S7odYVKT3CPNtBOdpEAc70 = Output_81;
                this.__cache_BPAhDLVF9meLWTHWDAxKS7 = manager_7;
            }

            return that_82;
        }

        public n4.Graph_TTeljbbbzLSL2j8U6uqzc8 __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "PFTs8Xrm9jzNjKm5jHUuFX", 317377U);
            var Output_1 = n65.GPUIn_C<float>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "S7odYVKT3CPNtBOdpEAc70", 317381U);
            var Output_3 = n65.GPUIn_C<n7.Vector2>.Create(Node_Context: Node_Context_2);
            n4.Graph_TTeljbbbzLSL2j8U6uqzc8 that_4 = this;
            this.__p_PFTs8Xrm9jzNjKm5jHUuFX = Output_1;
            this.__p_S7odYVKT3CPNtBOdpEAc70 = Output_3;
            this.__cache_BPAhDLVF9meLWTHWDAxKS7 = null;
            return that_4;
        }

        public n4.Graph_TTeljbbbzLSL2j8U6uqzc8 __CreateDefault__()
        {
            n4.Graph_TTeljbbbzLSL2j8U6uqzc8 that_0 = this;
            this.__p_PFTs8Xrm9jzNjKm5jHUuFX = n65.GPUIn_C<float>.CreateDefault();
            this.__p_S7odYVKT3CPNtBOdpEAc70 = n65.GPUIn_C<n7.Vector2>.CreateDefault();
            this.__cache_BPAhDLVF9meLWTHWDAxKS7 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_PFTs8Xrm9jzNjKm5jHUuFX);
            n1.CompilationHelper.SafeDispose(this.__p_S7odYVKT3CPNtBOdpEAc70);
            n1.CompilationHelper.SafeDispose(this.__cache_BPAhDLVF9meLWTHWDAxKS7);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 317242U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "OqLtNSBS0rQPZda4f8RNza", Name = "__slot_OqLtNSBS0rQPZda4f8RNza")]
        public static string __slot_OqLtNSBS0rQPZda4f8RNza = "\r\nfloat ${signature}_grad(float p )\r\n{\r\n\tfloat e = 0.001;\r\n\treturn (${Function1D}(p + e) - ${Function1D}(p - e)) / (2*e);\r\n}\r\n\r\n// https://www.iquilezles.org/www/articles/distance/distance.htm\r\n// 1D version using |f(x)-y| / sqrt(1+f'(x)2)\r\nfloat ${signature}_de(float2 p)\r\n{\r\n    float v = ${Function1D}(p.x)-p.y;\r\n\tfloat g = ${signature}_grad(p.x);\r\n    return abs(v) / sqrt(1 + g * g); // Draw Graph\r\n\t// return -v / sqrt(1 + g * g); //  Fill graph\r\n}\r\n\r\nfloat ${signature}_grid(float2 p, float width)\r\n{\r\n\tfloat grid = 0.;\r\n\tfloat freq = 4.;\r\n\t// main axis\r\n\tgrid = step(abs(p.x), width*.5);\r\n\tgrid = max(step(abs(p.y), width*.5), grid); \r\n\t// grid lines\r\n\tgrid = max(step(frac(p.x * freq), width * freq)*.2, grid);\r\n\tgrid = max(step(frac(p.y * freq), width * freq)*.2, grid);\r\n\treturn grid;\r\n}\r\n\r\n\r\nfloat4 ${signature}(float2 p, float zoom, float2 pan, float width, float4 graphCol, float4 gridCol, float4 bgCol)\r\n{\r\n\tfloat scale = 1. / zoom;\r\n\tp *= scale;\r\n\tp += pan;\r\n\twidth *= scale;\r\n\tfloat grid = ${signature}_grid(p, width);\r\n\tfloat graph = smoothstep( 0., width, ${signature}_de(p));\r\n\tfloat4 col = lerp(bgCol, gridCol, grid);\r\n\tcol = lerp(graphCol, col, graph);\r\n\treturn col;\r\n}\r\n\r\n\r\n";
        [n1.ElementAttribute(TracingId = 317374U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "GONPK7zemgMMFkMqtybdLQ", Name = "__slot_GONPK7zemgMMFkMqtybdLQ")]
        public static string __slot_GONPK7zemgMMFkMqtybdLQ = "Can extend this but need to do in IDE and not here!";
        [n1.ElementAttribute(TracingId = 317377U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "PFTs8Xrm9jzNjKm5jHUuFX", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
        public n65.GPUIn_C<float> __p_PFTs8Xrm9jzNjKm5jHUuFX;
        [n1.ElementAttribute(TracingId = 317381U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "S7odYVKT3CPNtBOdpEAc70", Name = "GPUIn", IsManaged = true, IsAutoGenerated = true)]
        public n65.GPUIn_C<n7.Vector2> __p_S7odYVKT3CPNtBOdpEAc70;
        [n1.ElementAttribute(TracingId = 317244U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "BPAhDLVF9meLWTHWDAxKS7", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n59.Manager<n2.ValueTuple<n19.GpuValue<float>, n19.GpuValue<n7.Vector2>, n19.GpuValue<float>, n19.GpuValue<float>, string>, n2.ValueTuple<n19.GpuValue<n7.Vector4>>> __cache_BPAhDLVF9meLWTHWDAxKS7 = null;
        [n1.ElementAttribute(TracingId = 317275U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "QGbY53nmykjPztMQe73BTr", Name = "__slot_QGbY53nmykjPztMQe73BTr")]
        public static string __slot_QGbY53nmykjPztMQe73BTr = "Graph1D";
        [n1.ElementAttribute(TracingId = 317300U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "IqxH2pVenOOOkHGV4ipavV", Name = "__slot_IqxH2pVenOOOkHGV4ipavV")]
        public static string __slot_IqxH2pVenOOOkHGV4ipavV = "Function1D";
        static Graph_TTeljbbbzLSL2j8U6uqzc8()
        {
        }

        public Graph_TTeljbbbzLSL2j8U6uqzc8(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Graph_TTeljbbbzLSL2j8U6uqzc8(Graph_TTeljbbbzLSL2j8U6uqzc8 other): base(other)
        {
            this.__p_PFTs8Xrm9jzNjKm5jHUuFX = other.__p_PFTs8Xrm9jzNjKm5jHUuFX;
            this.__p_S7odYVKT3CPNtBOdpEAc70 = other.__p_S7odYVKT3CPNtBOdpEAc70;
            this.__cache_BPAhDLVF9meLWTHWDAxKS7 = other.__cache_BPAhDLVF9meLWTHWDAxKS7;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_PFTs8Xrm9jzNjKm5jHUuFX", in __p_PFTs8Xrm9jzNjKm5jHUuFX), n1.CompilationHelper.GetValueOrExisting(values, "__p_S7odYVKT3CPNtBOdpEAc70", in __p_S7odYVKT3CPNtBOdpEAc70), n1.CompilationHelper.GetValueOrExisting(values, "__cache_BPAhDLVF9meLWTHWDAxKS7", in __cache_BPAhDLVF9meLWTHWDAxKS7));
        }

        internal Graph_TTeljbbbzLSL2j8U6uqzc8 __WITH__(n65.GPUIn_C<float> __p_PFTs8Xrm9jzNjKm5jHUuFX, n65.GPUIn_C<n7.Vector2> __p_S7odYVKT3CPNtBOdpEAc70, n59.Manager<n2.ValueTuple<n19.GpuValue<float>, n19.GpuValue<n7.Vector2>, n19.GpuValue<float>, n19.GpuValue<float>, string>, n2.ValueTuple<n19.GpuValue<n7.Vector4>>> __cache_BPAhDLVF9meLWTHWDAxKS7)
        {
            n4.Graph_TTeljbbbzLSL2j8U6uqzc8 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_PFTs8Xrm9jzNjKm5jHUuFX != this.__p_PFTs8Xrm9jzNjKm5jHUuFX || __p_S7odYVKT3CPNtBOdpEAc70 != this.__p_S7odYVKT3CPNtBOdpEAc70 || __cache_BPAhDLVF9meLWTHWDAxKS7 != this.__cache_BPAhDLVF9meLWTHWDAxKS7 ? new Graph_TTeljbbbzLSL2j8U6uqzc8(this)
                {__p_PFTs8Xrm9jzNjKm5jHUuFX = __p_PFTs8Xrm9jzNjKm5jHUuFX, __p_S7odYVKT3CPNtBOdpEAc70 = __p_S7odYVKT3CPNtBOdpEAc70, __cache_BPAhDLVF9meLWTHWDAxKS7 = __cache_BPAhDLVF9meLWTHWDAxKS7} : that_0;
            else
            {
                this.__p_PFTs8Xrm9jzNjKm5jHUuFX = __p_PFTs8Xrm9jzNjKm5jHUuFX;
                this.__p_S7odYVKT3CPNtBOdpEAc70 = __p_S7odYVKT3CPNtBOdpEAc70;
                this.__cache_BPAhDLVF9meLWTHWDAxKS7 = __cache_BPAhDLVF9meLWTHWDAxKS7;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "E4kcHNPLXyYMyeLt5yXQuA", Name = "__E4kcHNPLXyYMyeLt5yXQuA")]
        [n2.SerializableAttribute]
        public class __E4kcHNPLXyYMyeLt5yXQuA : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Q1VcR9z5rS9LbldVwK5O9z);
                n1.CompilationHelper.SafeDispose(this.__p_OMauLx7vDeaMczsvx2tqQw);
                n1.CompilationHelper.SafeDispose(this.__p_Kks7RMQJO2APZJW27DZhHg);
                n1.CompilationHelper.SafeDispose(this.__p_NU6y2j6bGJbNJv5w5EK8XY);
                n1.CompilationHelper.SafeDispose(this.__p_PLHJZQtLhrhNRGwhDsIfJP);
                n1.CompilationHelper.SafeDispose(this.__p_C74HLcVclrYPqbgkUkbkSa);
                return;
            }

            [n1.ElementAttribute(TracingId = 317258U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Q1VcR9z5rS9LbldVwK5O9z", Name = "CustomFunction", IsManaged = true, IsAutoGenerated = true)]
            public n60.CustomFunction_SbJY8E2PFscPAropl3Jh79<n7.Vector4, n13.IEnumerable<n19.InputModifier>> __p_Q1VcR9z5rS9LbldVwK5O9z;
            [n1.ElementAttribute(TracingId = 317283U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "OMauLx7vDeaMczsvx2tqQw", Name = "FunctionParameter (1 Parameter)", IsManaged = true, IsAutoGenerated = true)]
            public n61.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<float> __p_OMauLx7vDeaMczsvx2tqQw;
            [n1.ElementAttribute(TracingId = 317293U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Kks7RMQJO2APZJW27DZhHg", Name = "Function", IsManaged = true, IsAutoGenerated = true)]
            public n61.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_Kks7RMQJO2APZJW27DZhHg;
            [n1.ElementAttribute(TracingId = 317307U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "NU6y2j6bGJbNJv5w5EK8XY", Name = "UVSpace", IsManaged = true, IsAutoGenerated = true)]
            public n62.UVSpace_TTfuBbKAgyvPaTVshEyQ40 __p_NU6y2j6bGJbNJv5w5EK8XY;
            [n1.ElementAttribute(TracingId = 317312U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "PLHJZQtLhrhNRGwhDsIfJP", Name = "FuseColors", IsManaged = true, IsAutoGenerated = true)]
            public n31.FuseColors_DoTfmLFOXmxO9Gz80n2F7s __p_PLHJZQtLhrhNRGwhDsIfJP;
            [n1.ElementAttribute(TracingId = 317358U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "C74HLcVclrYPqbgkUkbkSa", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n63.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n7.Vector2> __p_C74HLcVclrYPqbgkUkbkSa;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n20.Spread<n19.GpuValue<n7.Vector2>> __pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa = default(n20.Spread<n19.GpuValue<n7.Vector2>>);
            [n1.ElementAttribute(TracingId = 317302U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "IdygOFECN10OHqRwbx3KL2", Name = "__slot_IdygOFECN10OHqRwbx3KL2")]
            public n19.GpuValue<float> __slot_IdygOFECN10OHqRwbx3KL2;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n20.Spread<n19.AbstractGpuValue> __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg = default(n20.Spread<n19.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n20.Spread<n19.IFunctionInvokeNode> __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU = default(n20.Spread<n19.IFunctionInvokeNode>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n20.Spread<n19.AbstractGpuValue> __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z = default(n20.Spread<n19.AbstractGpuValue>);
            public __E4kcHNPLXyYMyeLt5yXQuA(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __E4kcHNPLXyYMyeLt5yXQuA(__E4kcHNPLXyYMyeLt5yXQuA other): base(other)
            {
                this.__p_Q1VcR9z5rS9LbldVwK5O9z = other.__p_Q1VcR9z5rS9LbldVwK5O9z;
                this.__p_OMauLx7vDeaMczsvx2tqQw = other.__p_OMauLx7vDeaMczsvx2tqQw;
                this.__p_Kks7RMQJO2APZJW27DZhHg = other.__p_Kks7RMQJO2APZJW27DZhHg;
                this.__p_NU6y2j6bGJbNJv5w5EK8XY = other.__p_NU6y2j6bGJbNJv5w5EK8XY;
                this.__p_PLHJZQtLhrhNRGwhDsIfJP = other.__p_PLHJZQtLhrhNRGwhDsIfJP;
                this.__p_C74HLcVclrYPqbgkUkbkSa = other.__p_C74HLcVclrYPqbgkUkbkSa;
                this.__pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa = other.__pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa;
                this.__slot_IdygOFECN10OHqRwbx3KL2 = other.__slot_IdygOFECN10OHqRwbx3KL2;
                this.__pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg = other.__pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg;
                this.__pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU = other.__pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU;
                this.__pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z = other.__pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Q1VcR9z5rS9LbldVwK5O9z", in __p_Q1VcR9z5rS9LbldVwK5O9z), n1.CompilationHelper.GetValueOrExisting(values, "__p_OMauLx7vDeaMczsvx2tqQw", in __p_OMauLx7vDeaMczsvx2tqQw), n1.CompilationHelper.GetValueOrExisting(values, "__p_Kks7RMQJO2APZJW27DZhHg", in __p_Kks7RMQJO2APZJW27DZhHg), n1.CompilationHelper.GetValueOrExisting(values, "__p_NU6y2j6bGJbNJv5w5EK8XY", in __p_NU6y2j6bGJbNJv5w5EK8XY), n1.CompilationHelper.GetValueOrExisting(values, "__p_PLHJZQtLhrhNRGwhDsIfJP", in __p_PLHJZQtLhrhNRGwhDsIfJP), n1.CompilationHelper.GetValueOrExisting(values, "__p_C74HLcVclrYPqbgkUkbkSa", in __p_C74HLcVclrYPqbgkUkbkSa), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa", in __pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa), n1.CompilationHelper.GetValueOrExisting(values, "__slot_IdygOFECN10OHqRwbx3KL2", in __slot_IdygOFECN10OHqRwbx3KL2), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg", in __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU", in __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z", in __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z));
            }

            internal __E4kcHNPLXyYMyeLt5yXQuA __WITH__(n60.CustomFunction_SbJY8E2PFscPAropl3Jh79<n7.Vector4, n13.IEnumerable<n19.InputModifier>> __p_Q1VcR9z5rS9LbldVwK5O9z, n61.FunctionParameter__1_Parameter_Fnd0yFggk9QN4iUtZKYV0K<float> __p_OMauLx7vDeaMczsvx2tqQw, n61.Function_IubJYJ2Zy72PGqdBGy0rgZ<float> __p_Kks7RMQJO2APZJW27DZhHg, n62.UVSpace_TTfuBbKAgyvPaTVshEyQ40 __p_NU6y2j6bGJbNJv5w5EK8XY, n31.FuseColors_DoTfmLFOXmxO9Gz80n2F7s __p_PLHJZQtLhrhNRGwhDsIfJP, n63.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<n7.Vector2> __p_C74HLcVclrYPqbgkUkbkSa, n20.Spread<n19.GpuValue<n7.Vector2>> __pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa, n19.GpuValue<float> __slot_IdygOFECN10OHqRwbx3KL2, n20.Spread<n19.AbstractGpuValue> __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg, n20.Spread<n19.IFunctionInvokeNode> __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU, n20.Spread<n19.AbstractGpuValue> __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z)
            {
                __E4kcHNPLXyYMyeLt5yXQuA that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Q1VcR9z5rS9LbldVwK5O9z != this.__p_Q1VcR9z5rS9LbldVwK5O9z || __p_OMauLx7vDeaMczsvx2tqQw != this.__p_OMauLx7vDeaMczsvx2tqQw || __p_Kks7RMQJO2APZJW27DZhHg != this.__p_Kks7RMQJO2APZJW27DZhHg || __p_NU6y2j6bGJbNJv5w5EK8XY != this.__p_NU6y2j6bGJbNJv5w5EK8XY || __p_PLHJZQtLhrhNRGwhDsIfJP != this.__p_PLHJZQtLhrhNRGwhDsIfJP || __p_C74HLcVclrYPqbgkUkbkSa != this.__p_C74HLcVclrYPqbgkUkbkSa || __pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa != this.__pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa || __slot_IdygOFECN10OHqRwbx3KL2 != this.__slot_IdygOFECN10OHqRwbx3KL2 || __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg != this.__pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg || __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU != this.__pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU || __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z != this.__pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z ? new __E4kcHNPLXyYMyeLt5yXQuA(this)
                    {__p_Q1VcR9z5rS9LbldVwK5O9z = __p_Q1VcR9z5rS9LbldVwK5O9z, __p_OMauLx7vDeaMczsvx2tqQw = __p_OMauLx7vDeaMczsvx2tqQw, __p_Kks7RMQJO2APZJW27DZhHg = __p_Kks7RMQJO2APZJW27DZhHg, __p_NU6y2j6bGJbNJv5w5EK8XY = __p_NU6y2j6bGJbNJv5w5EK8XY, __p_PLHJZQtLhrhNRGwhDsIfJP = __p_PLHJZQtLhrhNRGwhDsIfJP, __p_C74HLcVclrYPqbgkUkbkSa = __p_C74HLcVclrYPqbgkUkbkSa, __pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa = __pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa, __slot_IdygOFECN10OHqRwbx3KL2 = __slot_IdygOFECN10OHqRwbx3KL2, __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg = __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg, __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU = __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU, __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z = __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z} : that_0;
                else
                {
                    this.__p_Q1VcR9z5rS9LbldVwK5O9z = __p_Q1VcR9z5rS9LbldVwK5O9z;
                    this.__p_OMauLx7vDeaMczsvx2tqQw = __p_OMauLx7vDeaMczsvx2tqQw;
                    this.__p_Kks7RMQJO2APZJW27DZhHg = __p_Kks7RMQJO2APZJW27DZhHg;
                    this.__p_NU6y2j6bGJbNJv5w5EK8XY = __p_NU6y2j6bGJbNJv5w5EK8XY;
                    this.__p_PLHJZQtLhrhNRGwhDsIfJP = __p_PLHJZQtLhrhNRGwhDsIfJP;
                    this.__p_C74HLcVclrYPqbgkUkbkSa = __p_C74HLcVclrYPqbgkUkbkSa;
                    this.__pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa = __pin_group_Input_In_C74HLcVclrYPqbgkUkbkSa;
                    this.__slot_IdygOFECN10OHqRwbx3KL2 = __slot_IdygOFECN10OHqRwbx3KL2;
                    this.__pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg = __pin_group_Parameters_In_Kks7RMQJO2APZJW27DZhHg;
                    this.__pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU = __pin_group_Input_In_Ni0x2WJd5SYP3I5vsiITeU;
                    this.__pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z = __pin_group_Arguments_In_Q1VcR9z5rS9LbldVwK5O9z;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 317484U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "GxH7VQOueXJQEMSnPYYFBb", Name = "RingBuffer3D_C")]
    [n2.SerializableAttribute]
    public class RingBuffer3D_C : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.RingBuffer3D_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new RingBuffer3D_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.RingBuffer3D_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new RingBuffer3D_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.RingBuffer3D_C Update([n5.SerializedDefaultValueAttribute("R32G32B32A32_Float", false)] n18.PixelFormat Format_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enable_In, out n66.VLComputeEffectShader Dispatcher_Out, out n3.Texture Texture_Out)
        {
            bool __pad_AGOmYkdYyo5LAXCCaomIC7_0 = __slot_AGOmYkdYyo5LAXCCaomIC7;
            n7.Int3 __auto_1 = this.resolution;
            n3.Texture __auto_2 = this.InTexture;
            var State_Output_4 = this.__p_K5qG10lnaQnLCgHT9CWFcT.Update(Simulate_In: __pad_AGOmYkdYyo5LAXCCaomIC7_0, Output_Out: out bool Output_3);
            this.__p_K5qG10lnaQnLCgHT9CWFcT = State_Output_4;
            n19.GpuValue<n3.Texture> Texture_5 = this.__monadBuilder_FVoQBBTe1peLY5TA6z3gvE.Return(__auto_2);
            RingBuffer3D_C Instance_6 = this;
            var Output_8 = Instance_6.UpdateCounter(Enable_In: Enable_In, index_Out: out int index_7);
            n19.GpuValue<int> z_9 = this.__monadBuilder_L24dbS4idWTMHcMjUC5Hj0.Return(index_7);
            bool Dispose_Cached_Outputs_10 = false;
            var manager_11 = this.__cache_OxmCLX9qLHONIl1JBBpcon;
            if (manager_11 is null)
            {
                manager_11 = new n59.Manager<n2.ValueTuple<n7.Int3, n18.PixelFormat>, n2.ValueTuple<n66.VLComputeEffectShader, n3.Texture>>((default(n66.VLComputeEffectShader), default(n3.Texture)));
            }

            var inputs_12 = (__auto_1, Format_In);
            var outputs_13 = manager_11.Outputs;
            var Has_Changed_14 = Output_3 || manager_11.InputsChanged(inputs_12);
            if (Has_Changed_14)
            {
                if (Dispose_Cached_Outputs_10)
                    manager_11.DisposeOutputs();
                var state_15 = n1.CompilationHelper.Restore<__PxQQtzWA9EYLbvrgcRsZ3a>(manager_11.State, __GetContext__());
                if (state_15 == null)
                {
                    state_15 = new __PxQQtzWA9EYLbvrgcRsZ3a(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_FKPAI8325RILlFU2McFlc2 = n23._Operations_.CreateDefault<n19.GpuValue<n7.Vector3>>()};
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "RDddVzLOgAtPC16zxjxOw0", 317559U);
                    var Output_17 = n29.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2.Create(Node_Context: Node_Context_16);
                    state_15.__p_RDddVzLOgAtPC16zxjxOw0 = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "OCm2Nk3q339Om2B4G4jw0A", 317567U);
                    var Output_19 = n67.TextureSet_GTElf8F5BISPYwp53N4yR3<n19.GpuValue<n7.Int3>, n7.Vector4>.Create(Node_Context: Node_Context_18);
                    state_15.__p_OCm2Nk3q339Om2B4G4jw0A = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Rmk8pmE5vnpLTD7uZKcleP", 317572U);
                    var Output_21 = n64.ToVector3_BiGMZixIzsHMmgVTnvnygH<n7.Int3>.Create(Node_Context: Node_Context_20);
                    state_15.__p_Rmk8pmE5vnpLTD7uZKcleP = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "OTecqSPY3g2PYjRlVfzd3Q", 317576U);
                    var Output_23 = n68.ComputeTexture3D_SO197zGpVYsOMINttv8noS.Create(Node_Context: Node_Context_22);
                    state_15.__p_OTecqSPY3g2PYjRlVfzd3Q = Output_23;
                    var node_24 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "DirectDispatcher", "Stride.Rendering.Advanced");
                    state_15.__p_FXsb77a210NNBeP1mR8LFu = node_24;
                    n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "FKPAI8325RILlFU2McFlc2", 317599U);
                    var Output_26 = n63.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n7.Vector3>.Create(Node_Context: Node_Context_25);
                    state_15.__p_FKPAI8325RILlFU2McFlc2 = Output_26;
                    n1.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "DrpDUwHrug5OqZ96QxzE9e", 317609U);
                    var Output_28 = n69.TextureIn_Fuse_C.Create(Node_Context: Node_Context_27);
                    state_15.__p_DrpDUwHrug5OqZ96QxzE9e = Output_28;
                    n1.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "EHxhZWMcdpAOA1aHxLjxkz", 317618U);
                    var Output_30 = n70.xy_int_SItNjydkI3fK9bxXkl1p4y<n7.Int3>.Create(Node_Context: Node_Context_29);
                    state_15.__p_EHxhZWMcdpAOA1aHxLjxkz = Output_30;
                    n1.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Rxtxi2CvQ2HLvDQIqPn4IK", 317626U);
                    var Output_32 = n71.xyPz_join__int_MZyR1GvxRXJN1HuTcwqmuw.Create(Node_Context: Node_Context_31);
                    state_15.__p_Rxtxi2CvQ2HLvDQIqPn4IK = Output_32;
                    n1.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "JhURCOcruH7MZB7zzjqgxW", 317646U);
                    var Output_34 = n72.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_33);
                    state_15.__p_JhURCOcruH7MZB7zzjqgxW = Output_34;
                    n1.NodeContext Node_Context_35 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Ianf4w5qBjHPPlt0X7kMrq", 317651U);
                    var Output_36 = n69.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n7.Vector3>.Create(Node_Context: Node_Context_35);
                    state_15.__p_Ianf4w5qBjHPPlt0X7kMrq = Output_36;
                }

                var X_37 = __auto_1.X;
                var Y_38 = __auto_1.Y;
                var Output_39 = new n7.Int2(x: X_37, y: Y_38);
                n7.Int2 Thread_Group_Size_40 = __c_Es28TH3oLdBPXW0IaG90g0;
                n73._Operations_.CalcDispatchArgs2D(Count_In: Output_39, Thread_Group_Size_In: Thread_Group_Size_40, Thread_Group_Count_Out: out n7.Int3 Thread_Group_Count_41, Thread_Group_Size_Out: out n7.Int3 Thread_Group_Size_42);
                n1.CompilationHelper.WritePin(state_15.__p_FXsb77a210NNBeP1mR8LFu.Inputs[0], ref Thread_Group_Count_41);
                n1.CompilationHelper.ReadPin(state_15.__p_FXsb77a210NNBeP1mR8LFu.Outputs[0], out n66.IComputeEffectDispatcher out_43);
                n26.IGraphicsDataProvider[] Initial_Data_44 = n74._Operations_.CreateDefault<n26.IGraphicsDataProvider>();
                int Array_Size_45 = 1;
                int Mip_Levels_46 = 1;
                bool Is_Unordered_Access_47 = true;
                bool Is_Render_Target_48 = false;
                bool Recreate_49 = false;
                var State_Output_52 = state_15.__p_OTecqSPY3g2PYjRlVfzd3Q.Update(Size_In: __auto_1, Initial_Data_In: Initial_Data_44, Array_Size_In: Array_Size_45, Mip_Levels_In: Mip_Levels_46, Format_In: Format_In, Is_Unordered_Access_In: Is_Unordered_Access_47, Is_Render_Target_In: Is_Render_Target_48, Recreate_In: Recreate_49, Output_Out: out n3.Texture Output_50, Has_Changed_Out: out bool Has_Changed_51);
                bool SetValue_53 = true;
                var Output_54 = state_15.__p_DrpDUwHrug5OqZ96QxzE9e;
                if (SetValue_53)
                {
                    Output_54 = state_15.__p_DrpDUwHrug5OqZ96QxzE9e.SetValue(Texture_In: Output_50);
                }

                bool RW_55 = true;
                bool SetRW_56 = true;
                var Output_57 = Output_54;
                if (SetRW_56)
                {
                    Output_57 = Output_54.SetRW(RW_In: RW_55);
                }

                var State_Output_59 = Output_57.Update(Output_Out: out n19.GpuValue<n3.Texture> Output_58);
                var State_Output_61 = state_15.__p_JhURCOcruH7MZB7zzjqgxW.GetOutput(Output_Out: out n19.GpuValue<n7.Int3> Output_60);
                bool Update_62 = true;
                var Output_63 = state_15.__p_EHxhZWMcdpAOA1aHxLjxkz;
                if (Update_62)
                {
                    Output_63 = state_15.__p_EHxhZWMcdpAOA1aHxLjxkz.Update(Input_In: Output_60);
                }

                var State_Output_65 = Output_63.GetX(Output_Out: out n19.GpuValue<n7.Int2> Output_64);
                var State_Output_67 = state_15.__p_Rxtxi2CvQ2HLvDQIqPn4IK.Update(xy_In: Output_64, z_In: z_9, Output_Out: out n19.GpuValue<n7.Int3> Output_66);
                var State_Output_69 = state_15.__p_Rmk8pmE5vnpLTD7uZKcleP.Update(x_In: Output_60, Output_Out: out n19.GpuValue<n7.Vector3> Output_68);
                var Result_70 = (n7.Vector3)__auto_1;
                n19.GpuValue<n7.Vector3> Input_2_71 = state_15.__monadBuilder_U06FoQ8Yq2RLrRF0rPPNBT.Return(Result_70);
                var builder_72 = n5.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_FKPAI8325RILlFU2McFlc2, 2);
                builder_72.Add(Output_68);
                builder_72.Add(Input_2_71);
                var __pin_group_Input_In_FKPAI8325RILlFU2McFlc2_73 = builder_72.Commit();
                var State_Output_75 = state_15.__p_FKPAI8325RILlFU2McFlc2.Update(Input_In: __pin_group_Input_In_FKPAI8325RILlFU2McFlc2_73, Output_Out: out n19.GpuValue<n7.Vector3> Output_74);
                n19.GpuValue<n3.SamplerState> Sampler_76 = default(n19.GpuValue<n3.SamplerState>);
                n19.GpuValue<float> Level_77 = default(n19.GpuValue<float>);
                n19.GpuValue<n7.Vector4> Default_78 = default(n19.GpuValue<n7.Vector4>);
                var State_Output_80 = state_15.__p_Ianf4w5qBjHPPlt0X7kMrq.Update(Texture_In: Texture_5, Sampler_In: Sampler_76, Texture_Coords_In: Output_74, Level_In: Level_77, Default_In: Default_78, Output_Out: out n19.GpuValue<n7.Vector4> Output_79);
                var State_Output_82 = state_15.__p_OCm2Nk3q339Om2B4G4jw0A.Update(Texture_In: Output_58, index_In: Output_66, value_In: Output_79, Output_Out: out n19.GpuValue<n75.GpuVoid> Output_81);
                bool Enabled_83 = true;
                var Output_87 = state_15.__p_RDddVzLOgAtPC16zxjxOw0.Update(Dispatcher_In: out_43, Thread_Group_Size_In: Thread_Group_Size_42, GpuValue_In: Output_81, Enabled_In: Enabled_83, Dispatcher_Out: out n66.VLComputeEffectShader Dispatcher_84, Last_Error_Out: out string Last_Error_85, Shader_Code_Out: out string Shader_Code_86);
                state_15.__p_FXsb77a210NNBeP1mR8LFu = state_15.__p_FXsb77a210NNBeP1mR8LFu;
                state_15.__p_OTecqSPY3g2PYjRlVfzd3Q = State_Output_52;
                state_15.__p_DrpDUwHrug5OqZ96QxzE9e = State_Output_59;
                state_15.__p_JhURCOcruH7MZB7zzjqgxW = State_Output_61;
                state_15.__p_EHxhZWMcdpAOA1aHxLjxkz = State_Output_65;
                state_15.__p_Rxtxi2CvQ2HLvDQIqPn4IK = State_Output_67;
                state_15.__p_Rmk8pmE5vnpLTD7uZKcleP = State_Output_69;
                state_15.__pin_group_Input_In_FKPAI8325RILlFU2McFlc2 = __pin_group_Input_In_FKPAI8325RILlFU2McFlc2_73;
                state_15.__p_FKPAI8325RILlFU2McFlc2 = State_Output_75;
                state_15.__p_Ianf4w5qBjHPPlt0X7kMrq = State_Output_80;
                state_15.__p_OCm2Nk3q339Om2B4G4jw0A = State_Output_82;
                state_15.__p_RDddVzLOgAtPC16zxjxOw0 = Output_87;
                outputs_13 = (Dispatcher_84, Output_50);
                manager_11 = manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10, state_15, outputs_13);
            }
            else
            {
                manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10);
            }

            var(__auto_88, __auto_89) = outputs_13;
            this.__cache_OxmCLX9qLHONIl1JBBpcon = manager_11;
            this.OutTexture = __auto_89;
            n3.Texture __auto_90 = __auto_89;
            Dispatcher_Out = __auto_88;
            Texture_Out = __auto_90;
            return this;
        }

        public n4.RingBuffer3D_C SetDepth([n5.SerializedDefaultValueAttribute("1", false)] int Depth_In)
        {
            int __auto_0 = this.Width;
            int __auto_1 = this.Height;
            this.Depth = Depth_In;
            int __auto_2 = Depth_In;
            var Output_3 = new n7.Int3(x: __auto_0, y: __auto_1, z: __auto_2);
            this.resolution = Output_3;
            n7.Int3 __auto_4 = Output_3;
            return this;
        }

        public n4.RingBuffer3D_C SetTexture(n3.Texture Texture_In)
        {
            int __auto_0 = this.Depth;
            this.InTexture = Texture_In;
            n3.Texture __auto_1 = Texture_In;
            var Height_2 = __auto_1.Height;
            this.Height = Height_2;
            int __auto_3 = Height_2;
            var Width_4 = __auto_1.Width;
            this.Width = Width_4;
            int __auto_5 = Width_4;
            var Output_6 = new n7.Int3(x: __auto_5, y: __auto_3, z: __auto_0);
            this.resolution = Output_6;
            n7.Int3 __auto_7 = Output_6;
            return this;
        }

        public n4.RingBuffer3D_C UpdateCounter([n5.SerializedDefaultValueAttribute("True", false)] bool Enable_In, out int index_Out)
        {
            int __auto_0 = this.Depth;
            int __pad_UI4yER25ROlNEuUl5Ryi3y_1 = __slot_UI4yER25ROlNEuUl5Ryi3y;
            var Output_2 = this.__p_R8MMjQQbkgPQXXYu5h4z8P;
            if (Enable_In)
            {
                Output_2 = this.__p_R8MMjQQbkgPQXXYu5h4z8P.Count();
            }

            this.__p_R8MMjQQbkgPQXXYu5h4z8P = Output_2;
            var Output_4 = Output_2.GetValue(Value_Out: out int Value_3);
            this.__p_R8MMjQQbkgPQXXYu5h4z8P = Output_4;
            n76._Operations_.Max<int, n21.__AdaptiveImplementations__JPmuEharYwiLQs6dOuoEQQ>(Input_In: __auto_0, Input_2_In: __pad_UI4yER25ROlNEuUl5Ryi3y_1, Output_Out: out int Output_5);
            var Output_6 = Value_3 % Output_5;
            this.index = Output_6;
            int __auto_7 = Output_6;
            float Input_2_8 = (float)Output_5;
            var Result_9 = n77.IntegerConversions.ToFloat32(input: Output_6);
            var Output_10 = (float)Result_9 / Input_2_8;
            this.progress = Output_10;
            float __auto_11 = Output_10;
            index_Out = __auto_7;
            return this;
        }

        public n4.RingBuffer3D_C GetIndex(out int Index_Out)
        {
            int __auto_0 = this.index;
            Index_Out = __auto_0;
            return this;
        }

        public n4.RingBuffer3D_C GetProgress(out float Progress_Out)
        {
            float __auto_0 = this.progress;
            Progress_Out = __auto_0;
            return this;
        }

        public n4.RingBuffer3D_C GetTexture(out n3.Texture Texture_Out)
        {
            n3.Texture __auto_0 = this.OutTexture;
            Texture_Out = __auto_0;
            return this;
        }

        public n4.RingBuffer3D_C __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Depth = 0;
            this.Width = 0;
            this.Height = 0;
            this.resolution = default(n7.Int3);
            this.index = 0;
            this.progress = 0F;
            this.InTexture = default(n3.Texture);
            this.OutTexture = default(n3.Texture);
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "R8MMjQQbkgPQXXYu5h4z8P", 317697U);
            var Output_1 = n78.FrameCounter_BTu2lIk3ErHQUOIIjwJYCm.Create(Node_Context: Node_Context_0);
            this.__p_R8MMjQQbkgPQXXYu5h4z8P = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "K5qG10lnaQnLCgHT9CWFcT", 317753U);
            var Output_3 = n22.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_2);
            this.__p_K5qG10lnaQnLCgHT9CWFcT = Output_3;
            this.__monadBuilder_FVoQBBTe1peLY5TA6z3gvE = n19.GpuValueMonadicFactory<n3.Texture>.Default.GetMonadBuilder(true);
            this.__p_Ch39g3CJupuMW2DThruNvS = n79._Operations_.CreateDefault();
            this.__monadBuilder_L24dbS4idWTMHcMjUC5Hj0 = n19.GpuValueMonadicFactory<int>.Default.GetMonadBuilder(true);
            this.__cache_OxmCLX9qLHONIl1JBBpcon = null;
            return this;
        }

        public n4.RingBuffer3D_C __CreateDefault__()
        {
            this.Depth = 0;
            this.Width = 0;
            this.Height = 0;
            this.resolution = default(n7.Int3);
            this.index = 0;
            this.progress = 0F;
            this.InTexture = default(n3.Texture);
            this.OutTexture = default(n3.Texture);
            this.__p_K5qG10lnaQnLCgHT9CWFcT = n22.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__monadBuilder_FVoQBBTe1peLY5TA6z3gvE = n19.GpuValueMonadicFactory<n3.Texture>.Default.GetMonadBuilder(true);
            this.__p_Ch39g3CJupuMW2DThruNvS = n79._Operations_.CreateDefault();
            this.__monadBuilder_L24dbS4idWTMHcMjUC5Hj0 = n19.GpuValueMonadicFactory<int>.Default.GetMonadBuilder(true);
            this.__cache_OxmCLX9qLHONIl1JBBpcon = null;
            this.__p_R8MMjQQbkgPQXXYu5h4z8P = n78.FrameCounter_BTu2lIk3ErHQUOIIjwJYCm.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_K5qG10lnaQnLCgHT9CWFcT);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_FVoQBBTe1peLY5TA6z3gvE);
            n1.CompilationHelper.SafeDispose(this.__p_Ch39g3CJupuMW2DThruNvS);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_L24dbS4idWTMHcMjUC5Hj0);
            n1.CompilationHelper.SafeDispose(this.__cache_OxmCLX9qLHONIl1JBBpcon);
            n1.CompilationHelper.SafeDispose(this.__p_R8MMjQQbkgPQXXYu5h4z8P);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 317695U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "AGOmYkdYyo5LAXCCaomIC7", Name = "__slot_AGOmYkdYyo5LAXCCaomIC7")]
        public static bool __slot_AGOmYkdYyo5LAXCCaomIC7 = false;
        [n1.ElementAttribute(TracingId = 317734U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "UI4yER25ROlNEuUl5Ryi3y", Name = "__slot_UI4yER25ROlNEuUl5Ryi3y")]
        public static int __slot_UI4yER25ROlNEuUl5Ryi3y = 1;
        [n1.ElementAttribute(TracingId = 317534U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "KQ31AOv36rFPkDoH2KWLVF", Name = "Depth")]
        public int Depth;
        [n1.ElementAttribute(TracingId = 317542U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "KupQvt0cGG4OKW5JClP4A3", Name = "Width")]
        public int Width;
        [n1.ElementAttribute(TracingId = 317546U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "HFhkqmzLohMNRS2TeJvaDK", Name = "Height")]
        public int Height;
        [n1.ElementAttribute(TracingId = 317763U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "FNMgYj5JXhLMsr6M7Gep4K", Name = "resolution")]
        public n7.Int3 resolution;
        [n1.ElementAttribute(TracingId = 317803U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "A3niXeOx12BQBmfUZMSdnf", Name = "index")]
        public int index;
        [n1.ElementAttribute(TracingId = 317806U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "AtrRZSHBh1JM2XXYBygCao", Name = "progress")]
        public float progress;
        [n1.ElementAttribute(TracingId = 317538U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "EcYvFNK4YckQQ0bfgLBypX", Name = "InTexture")]
        public n3.Texture InTexture;
        [n1.ElementAttribute(TracingId = 317819U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "NtJk918PlLiNLoAaf9Xu9D", Name = "OutTexture")]
        public n3.Texture OutTexture;
        [n1.ElementAttribute(TracingId = 317753U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "K5qG10lnaQnLCgHT9CWFcT", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n22.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_K5qG10lnaQnLCgHT9CWFcT;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<n3.Texture, n19.GpuValue<n3.Texture>> __monadBuilder_FVoQBBTe1peLY5TA6z3gvE = n19.GpuValueMonadicFactory<n3.Texture>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 317746U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Ch39g3CJupuMW2DThruNvS", Name = "This", IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __p_Ch39g3CJupuMW2DThruNvS;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<int, n19.GpuValue<int>> __monadBuilder_L24dbS4idWTMHcMjUC5Hj0 = n19.GpuValueMonadicFactory<int>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 317548U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "OxmCLX9qLHONIl1JBBpcon", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n59.Manager<n2.ValueTuple<n7.Int3, n18.PixelFormat>, n2.ValueTuple<n66.VLComputeEffectShader, n3.Texture>> __cache_OxmCLX9qLHONIl1JBBpcon = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n7.Int2 __c_Es28TH3oLdBPXW0IaG90g0 = n1.CompilationHelper.Deserialize<n7.Int2>("8, 8", false, "JPmuEharYwiLQs6dOuoEQQ", "Es28TH3oLdBPXW0IaG90g0");
        [n1.ElementAttribute(TracingId = 317697U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "R8MMjQQbkgPQXXYu5h4z8P", Name = "FrameCounter", IsManaged = true, IsAutoGenerated = true)]
        public n78.FrameCounter_BTu2lIk3ErHQUOIIjwJYCm __p_R8MMjQQbkgPQXXYu5h4z8P;
        static RingBuffer3D_C()
        {
        }

        public RingBuffer3D_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RingBuffer3D_C(RingBuffer3D_C other): base(other)
        {
            this.Depth = other.Depth;
            this.Width = other.Width;
            this.Height = other.Height;
            this.resolution = other.resolution;
            this.index = other.index;
            this.progress = other.progress;
            this.InTexture = other.InTexture;
            this.OutTexture = other.OutTexture;
            this.__p_K5qG10lnaQnLCgHT9CWFcT = other.__p_K5qG10lnaQnLCgHT9CWFcT;
            this.__monadBuilder_FVoQBBTe1peLY5TA6z3gvE = other.__monadBuilder_FVoQBBTe1peLY5TA6z3gvE;
            this.__p_Ch39g3CJupuMW2DThruNvS = other.__p_Ch39g3CJupuMW2DThruNvS;
            this.__monadBuilder_L24dbS4idWTMHcMjUC5Hj0 = other.__monadBuilder_L24dbS4idWTMHcMjUC5Hj0;
            this.__cache_OxmCLX9qLHONIl1JBBpcon = other.__cache_OxmCLX9qLHONIl1JBBpcon;
            this.__p_R8MMjQQbkgPQXXYu5h4z8P = other.__p_R8MMjQQbkgPQXXYu5h4z8P;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Depth", in Depth), n1.CompilationHelper.GetValueOrExisting(values, "Width", in Width), n1.CompilationHelper.GetValueOrExisting(values, "Height", in Height), n1.CompilationHelper.GetValueOrExisting(values, "resolution", in resolution), n1.CompilationHelper.GetValueOrExisting(values, "index", in index), n1.CompilationHelper.GetValueOrExisting(values, "progress", in progress), n1.CompilationHelper.GetValueOrExisting(values, "InTexture", in InTexture), n1.CompilationHelper.GetValueOrExisting(values, "OutTexture", in OutTexture), n1.CompilationHelper.GetValueOrExisting(values, "__p_K5qG10lnaQnLCgHT9CWFcT", in __p_K5qG10lnaQnLCgHT9CWFcT), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_FVoQBBTe1peLY5TA6z3gvE", in __monadBuilder_FVoQBBTe1peLY5TA6z3gvE), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ch39g3CJupuMW2DThruNvS", in __p_Ch39g3CJupuMW2DThruNvS), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_L24dbS4idWTMHcMjUC5Hj0", in __monadBuilder_L24dbS4idWTMHcMjUC5Hj0), n1.CompilationHelper.GetValueOrExisting(values, "__cache_OxmCLX9qLHONIl1JBBpcon", in __cache_OxmCLX9qLHONIl1JBBpcon), n1.CompilationHelper.GetValueOrExisting(values, "__p_R8MMjQQbkgPQXXYu5h4z8P", in __p_R8MMjQQbkgPQXXYu5h4z8P));
        }

        internal RingBuffer3D_C __WITH__(int Depth, int Width, int Height, n7.Int3 resolution, int index, float progress, n3.Texture InTexture, n3.Texture OutTexture, n22.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_K5qG10lnaQnLCgHT9CWFcT, n1.IMonadBuilder<n3.Texture, n19.GpuValue<n3.Texture>> __monadBuilder_FVoQBBTe1peLY5TA6z3gvE, n2.Object __p_Ch39g3CJupuMW2DThruNvS, n1.IMonadBuilder<int, n19.GpuValue<int>> __monadBuilder_L24dbS4idWTMHcMjUC5Hj0, n59.Manager<n2.ValueTuple<n7.Int3, n18.PixelFormat>, n2.ValueTuple<n66.VLComputeEffectShader, n3.Texture>> __cache_OxmCLX9qLHONIl1JBBpcon, n78.FrameCounter_BTu2lIk3ErHQUOIIjwJYCm __p_R8MMjQQbkgPQXXYu5h4z8P)
        {
            n4.RingBuffer3D_C that_0 = this;
            this.Depth = Depth;
            this.Width = Width;
            this.Height = Height;
            this.resolution = resolution;
            this.index = index;
            this.progress = progress;
            this.InTexture = InTexture;
            this.OutTexture = OutTexture;
            this.__p_K5qG10lnaQnLCgHT9CWFcT = __p_K5qG10lnaQnLCgHT9CWFcT;
            this.__monadBuilder_FVoQBBTe1peLY5TA6z3gvE = __monadBuilder_FVoQBBTe1peLY5TA6z3gvE;
            this.__p_Ch39g3CJupuMW2DThruNvS = __p_Ch39g3CJupuMW2DThruNvS;
            this.__monadBuilder_L24dbS4idWTMHcMjUC5Hj0 = __monadBuilder_L24dbS4idWTMHcMjUC5Hj0;
            this.__cache_OxmCLX9qLHONIl1JBBpcon = __cache_OxmCLX9qLHONIl1JBBpcon;
            this.__p_R8MMjQQbkgPQXXYu5h4z8P = __p_R8MMjQQbkgPQXXYu5h4z8P;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "PxQQtzWA9EYLbvrgcRsZ3a", Name = "__PxQQtzWA9EYLbvrgcRsZ3a")]
        [n2.SerializableAttribute]
        public class __PxQQtzWA9EYLbvrgcRsZ3a : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RDddVzLOgAtPC16zxjxOw0);
                n1.CompilationHelper.SafeDispose(this.__p_OCm2Nk3q339Om2B4G4jw0A);
                n1.CompilationHelper.SafeDispose(this.__p_Rmk8pmE5vnpLTD7uZKcleP);
                n1.CompilationHelper.SafeDispose(this.__p_OTecqSPY3g2PYjRlVfzd3Q);
                n1.CompilationHelper.SafeDispose(this.__p_FXsb77a210NNBeP1mR8LFu);
                n1.CompilationHelper.SafeDispose(this.__p_FKPAI8325RILlFU2McFlc2);
                n1.CompilationHelper.SafeDispose(this.__p_DrpDUwHrug5OqZ96QxzE9e);
                n1.CompilationHelper.SafeDispose(this.__p_EHxhZWMcdpAOA1aHxLjxkz);
                n1.CompilationHelper.SafeDispose(this.__p_Rxtxi2CvQ2HLvDQIqPn4IK);
                n1.CompilationHelper.SafeDispose(this.__p_JhURCOcruH7MZB7zzjqgxW);
                n1.CompilationHelper.SafeDispose(this.__p_Ianf4w5qBjHPPlt0X7kMrq);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_U06FoQ8Yq2RLrRF0rPPNBT);
                return;
            }

            [n1.ElementAttribute(TracingId = 317559U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "RDddVzLOgAtPC16zxjxOw0", Name = "ComputeShaderGraph", IsManaged = true, IsAutoGenerated = true)]
            public n29.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2 __p_RDddVzLOgAtPC16zxjxOw0;
            [n1.ElementAttribute(TracingId = 317567U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "OCm2Nk3q339Om2B4G4jw0A", Name = "TextureSet", IsManaged = true, IsAutoGenerated = true)]
            public n67.TextureSet_GTElf8F5BISPYwp53N4yR3<n19.GpuValue<n7.Int3>, n7.Vector4> __p_OCm2Nk3q339Om2B4G4jw0A;
            [n1.ElementAttribute(TracingId = 317572U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Rmk8pmE5vnpLTD7uZKcleP", Name = "ToVector3", IsManaged = true, IsAutoGenerated = true)]
            public n64.ToVector3_BiGMZixIzsHMmgVTnvnygH<n7.Int3> __p_Rmk8pmE5vnpLTD7uZKcleP;
            [n1.ElementAttribute(TracingId = 317576U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "OTecqSPY3g2PYjRlVfzd3Q", Name = "ComputeTexture3D", IsManaged = true, IsAutoGenerated = true)]
            public n68.ComputeTexture3D_SO197zGpVYsOMINttv8noS __p_OTecqSPY3g2PYjRlVfzd3Q;
            [n1.ElementAttribute(TracingId = 317594U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "FXsb77a210NNBeP1mR8LFu", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
            public n1.IVLNode __p_FXsb77a210NNBeP1mR8LFu;
            [n1.ElementAttribute(TracingId = 317599U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "FKPAI8325RILlFU2McFlc2", Name = "/", IsManaged = true, IsAutoGenerated = true)]
            public n63.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n7.Vector3> __p_FKPAI8325RILlFU2McFlc2;
            [n1.ElementAttribute(TracingId = 317609U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "DrpDUwHrug5OqZ96QxzE9e", Name = "TextureIn (Fuse)", IsManaged = true, IsAutoGenerated = true)]
            public n69.TextureIn_Fuse_C __p_DrpDUwHrug5OqZ96QxzE9e;
            [n1.ElementAttribute(TracingId = 317618U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "EHxhZWMcdpAOA1aHxLjxkz", Name = "xy (int)", IsManaged = true, IsAutoGenerated = true)]
            public n70.xy_int_SItNjydkI3fK9bxXkl1p4y<n7.Int3> __p_EHxhZWMcdpAOA1aHxLjxkz;
            [n1.ElementAttribute(TracingId = 317626U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Rxtxi2CvQ2HLvDQIqPn4IK", Name = "xy+z (join)(int)", IsManaged = true, IsAutoGenerated = true)]
            public n71.xyPz_join__int_MZyR1GvxRXJN1HuTcwqmuw __p_Rxtxi2CvQ2HLvDQIqPn4IK;
            [n1.ElementAttribute(TracingId = 317646U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "JhURCOcruH7MZB7zzjqgxW", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
            public n72.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_JhURCOcruH7MZB7zzjqgxW;
            [n1.ElementAttribute(TracingId = 317651U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Ianf4w5qBjHPPlt0X7kMrq", Name = "SampleTexture (Fuse)", IsManaged = true, IsAutoGenerated = true)]
            public n69.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n7.Vector3> __p_Ianf4w5qBjHPPlt0X7kMrq;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<n7.Vector3, n19.GpuValue<n7.Vector3>> __monadBuilder_U06FoQ8Yq2RLrRF0rPPNBT = n19.GpuValueMonadicFactory<n7.Vector3>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n20.Spread<n19.GpuValue<n7.Vector3>> __pin_group_Input_In_FKPAI8325RILlFU2McFlc2 = default(n20.Spread<n19.GpuValue<n7.Vector3>>);
            public __PxQQtzWA9EYLbvrgcRsZ3a(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __PxQQtzWA9EYLbvrgcRsZ3a(__PxQQtzWA9EYLbvrgcRsZ3a other): base(other)
            {
                this.__p_RDddVzLOgAtPC16zxjxOw0 = other.__p_RDddVzLOgAtPC16zxjxOw0;
                this.__p_OCm2Nk3q339Om2B4G4jw0A = other.__p_OCm2Nk3q339Om2B4G4jw0A;
                this.__p_Rmk8pmE5vnpLTD7uZKcleP = other.__p_Rmk8pmE5vnpLTD7uZKcleP;
                this.__p_OTecqSPY3g2PYjRlVfzd3Q = other.__p_OTecqSPY3g2PYjRlVfzd3Q;
                this.__p_FXsb77a210NNBeP1mR8LFu = other.__p_FXsb77a210NNBeP1mR8LFu;
                this.__p_FKPAI8325RILlFU2McFlc2 = other.__p_FKPAI8325RILlFU2McFlc2;
                this.__p_DrpDUwHrug5OqZ96QxzE9e = other.__p_DrpDUwHrug5OqZ96QxzE9e;
                this.__p_EHxhZWMcdpAOA1aHxLjxkz = other.__p_EHxhZWMcdpAOA1aHxLjxkz;
                this.__p_Rxtxi2CvQ2HLvDQIqPn4IK = other.__p_Rxtxi2CvQ2HLvDQIqPn4IK;
                this.__p_JhURCOcruH7MZB7zzjqgxW = other.__p_JhURCOcruH7MZB7zzjqgxW;
                this.__p_Ianf4w5qBjHPPlt0X7kMrq = other.__p_Ianf4w5qBjHPPlt0X7kMrq;
                this.__monadBuilder_U06FoQ8Yq2RLrRF0rPPNBT = other.__monadBuilder_U06FoQ8Yq2RLrRF0rPPNBT;
                this.__pin_group_Input_In_FKPAI8325RILlFU2McFlc2 = other.__pin_group_Input_In_FKPAI8325RILlFU2McFlc2;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RDddVzLOgAtPC16zxjxOw0", in __p_RDddVzLOgAtPC16zxjxOw0), n1.CompilationHelper.GetValueOrExisting(values, "__p_OCm2Nk3q339Om2B4G4jw0A", in __p_OCm2Nk3q339Om2B4G4jw0A), n1.CompilationHelper.GetValueOrExisting(values, "__p_Rmk8pmE5vnpLTD7uZKcleP", in __p_Rmk8pmE5vnpLTD7uZKcleP), n1.CompilationHelper.GetValueOrExisting(values, "__p_OTecqSPY3g2PYjRlVfzd3Q", in __p_OTecqSPY3g2PYjRlVfzd3Q), n1.CompilationHelper.GetValueOrExisting(values, "__p_FXsb77a210NNBeP1mR8LFu", in __p_FXsb77a210NNBeP1mR8LFu), n1.CompilationHelper.GetValueOrExisting(values, "__p_FKPAI8325RILlFU2McFlc2", in __p_FKPAI8325RILlFU2McFlc2), n1.CompilationHelper.GetValueOrExisting(values, "__p_DrpDUwHrug5OqZ96QxzE9e", in __p_DrpDUwHrug5OqZ96QxzE9e), n1.CompilationHelper.GetValueOrExisting(values, "__p_EHxhZWMcdpAOA1aHxLjxkz", in __p_EHxhZWMcdpAOA1aHxLjxkz), n1.CompilationHelper.GetValueOrExisting(values, "__p_Rxtxi2CvQ2HLvDQIqPn4IK", in __p_Rxtxi2CvQ2HLvDQIqPn4IK), n1.CompilationHelper.GetValueOrExisting(values, "__p_JhURCOcruH7MZB7zzjqgxW", in __p_JhURCOcruH7MZB7zzjqgxW), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ianf4w5qBjHPPlt0X7kMrq", in __p_Ianf4w5qBjHPPlt0X7kMrq), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_U06FoQ8Yq2RLrRF0rPPNBT", in __monadBuilder_U06FoQ8Yq2RLrRF0rPPNBT), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_FKPAI8325RILlFU2McFlc2", in __pin_group_Input_In_FKPAI8325RILlFU2McFlc2));
            }

            internal __PxQQtzWA9EYLbvrgcRsZ3a __WITH__(n29.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2 __p_RDddVzLOgAtPC16zxjxOw0, n67.TextureSet_GTElf8F5BISPYwp53N4yR3<n19.GpuValue<n7.Int3>, n7.Vector4> __p_OCm2Nk3q339Om2B4G4jw0A, n64.ToVector3_BiGMZixIzsHMmgVTnvnygH<n7.Int3> __p_Rmk8pmE5vnpLTD7uZKcleP, n68.ComputeTexture3D_SO197zGpVYsOMINttv8noS __p_OTecqSPY3g2PYjRlVfzd3Q, n1.IVLNode __p_FXsb77a210NNBeP1mR8LFu, n63.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n7.Vector3> __p_FKPAI8325RILlFU2McFlc2, n69.TextureIn_Fuse_C __p_DrpDUwHrug5OqZ96QxzE9e, n70.xy_int_SItNjydkI3fK9bxXkl1p4y<n7.Int3> __p_EHxhZWMcdpAOA1aHxLjxkz, n71.xyPz_join__int_MZyR1GvxRXJN1HuTcwqmuw __p_Rxtxi2CvQ2HLvDQIqPn4IK, n72.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_JhURCOcruH7MZB7zzjqgxW, n69.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n7.Vector3> __p_Ianf4w5qBjHPPlt0X7kMrq, n1.IMonadBuilder<n7.Vector3, n19.GpuValue<n7.Vector3>> __monadBuilder_U06FoQ8Yq2RLrRF0rPPNBT, n20.Spread<n19.GpuValue<n7.Vector3>> __pin_group_Input_In_FKPAI8325RILlFU2McFlc2)
            {
                __PxQQtzWA9EYLbvrgcRsZ3a that_0 = this;
                this.__p_RDddVzLOgAtPC16zxjxOw0 = __p_RDddVzLOgAtPC16zxjxOw0;
                this.__p_OCm2Nk3q339Om2B4G4jw0A = __p_OCm2Nk3q339Om2B4G4jw0A;
                this.__p_Rmk8pmE5vnpLTD7uZKcleP = __p_Rmk8pmE5vnpLTD7uZKcleP;
                this.__p_OTecqSPY3g2PYjRlVfzd3Q = __p_OTecqSPY3g2PYjRlVfzd3Q;
                this.__p_FXsb77a210NNBeP1mR8LFu = __p_FXsb77a210NNBeP1mR8LFu;
                this.__p_FKPAI8325RILlFU2McFlc2 = __p_FKPAI8325RILlFU2McFlc2;
                this.__p_DrpDUwHrug5OqZ96QxzE9e = __p_DrpDUwHrug5OqZ96QxzE9e;
                this.__p_EHxhZWMcdpAOA1aHxLjxkz = __p_EHxhZWMcdpAOA1aHxLjxkz;
                this.__p_Rxtxi2CvQ2HLvDQIqPn4IK = __p_Rxtxi2CvQ2HLvDQIqPn4IK;
                this.__p_JhURCOcruH7MZB7zzjqgxW = __p_JhURCOcruH7MZB7zzjqgxW;
                this.__p_Ianf4w5qBjHPPlt0X7kMrq = __p_Ianf4w5qBjHPPlt0X7kMrq;
                this.__monadBuilder_U06FoQ8Yq2RLrRF0rPPNBT = __monadBuilder_U06FoQ8Yq2RLrRF0rPPNBT;
                this.__pin_group_Input_In_FKPAI8325RILlFU2McFlc2 = __pin_group_Input_In_FKPAI8325RILlFU2McFlc2;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 318011U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "SteV6wUPNFaO7qKZnPaWEP", Name = "IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP")]
    [n2.SerializableAttribute]
    public class IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP Create(n1.NodeContext Node_Context)
        {
            var instance = new IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP CreateDefault()
        {
            var instance = new IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP Update(n19.GpuValue<int> Input_In, [n5.SerializedDefaultValueAttribute("1", false)] n19.GpuValue<int> Width_In, [n5.SerializedDefaultValueAttribute("1", false)] n19.GpuValue<int> Height_In, out n19.GpuValue<n7.Int3> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_Q178uq1J7lZMcsVjxoiwkz;
            if (manager_2 is null)
            {
                manager_2 = new n59.Manager<n2.ValueTuple<n19.GpuValue<int>, n19.GpuValue<int>, n19.GpuValue<int>>, n2.ValueTuple<n19.GpuValue<n7.Int3>>>(n2.ValueTuple.Create(default(n19.GpuValue<n7.Int3>)));
            }

            var inputs_3 = (Input_In, Width_In, Height_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__RsbtCYR8R9HOndepQuEGTZ>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __RsbtCYR8R9HOndepQuEGTZ(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_HBggr0HXW1hNmfowR43hj9 = n23._Operations_.CreateDefault<n19.GpuValue<int>>(), __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB = n23._Operations_.CreateDefault<n19.GpuValue<int>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "SgN0wm5y6VHLuk3IzlmEO0", 318035U);
                    var Output_8 = n63.Mod_CJuXD7Kyc5dPlhUjYxVZnV<int>.Create(Node_Context: Node_Context_7);
                    state_6.__p_SgN0wm5y6VHLuk3IzlmEO0 = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "HBggr0HXW1hNmfowR43hj9", 318044U);
                    var Output_10 = n63.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<int>.Create(Node_Context: Node_Context_9);
                    state_6.__p_HBggr0HXW1hNmfowR43hj9 = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "GrLGrnEUC89P6gr7dRtywp", 318057U);
                    var Output_12 = n63.Mod_CJuXD7Kyc5dPlhUjYxVZnV<int>.Create(Node_Context: Node_Context_11);
                    state_6.__p_GrLGrnEUC89P6gr7dRtywp = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "LrD44QaUGqFNGAi28GzuOB", 318067U);
                    var Output_14 = n63.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<int>.Create(Node_Context: Node_Context_13);
                    state_6.__p_LrD44QaUGqFNGAi28GzuOB = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "L6mZnul29qKNzUQWuBfwVC", 318074U);
                    var Output_16 = n71.xPyPz_join__int_Lf6o5qkCO5VORoVR4GhDld.Create(Node_Context: Node_Context_15);
                    state_6.__p_L6mZnul29qKNzUQWuBfwVC = Output_16;
                }

                var State_Output_18 = state_6.__p_SgN0wm5y6VHLuk3IzlmEO0.Update(Input_In: Input_In, Mod_In: Width_In, Output_Out: out n19.GpuValue<int> Output_17);
                var builder_19 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_HBggr0HXW1hNmfowR43hj9, 2);
                builder_19.Add(Input_In);
                builder_19.Add(Width_In);
                var __pin_group_Input_In_HBggr0HXW1hNmfowR43hj9_20 = builder_19.Commit();
                var State_Output_22 = state_6.__p_HBggr0HXW1hNmfowR43hj9.Update(Input_In: __pin_group_Input_In_HBggr0HXW1hNmfowR43hj9_20, Output_Out: out n19.GpuValue<int> Output_21);
                var State_Output_24 = state_6.__p_GrLGrnEUC89P6gr7dRtywp.Update(Input_In: Output_21, Mod_In: Height_In, Output_Out: out n19.GpuValue<int> Output_23);
                var builder_25 = n5.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB, 2);
                builder_25.Add(Output_21);
                builder_25.Add(Height_In);
                var __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB_26 = builder_25.Commit();
                var State_Output_28 = state_6.__p_LrD44QaUGqFNGAi28GzuOB.Update(Input_In: __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB_26, Output_Out: out n19.GpuValue<int> Output_27);
                var State_Output_30 = state_6.__p_L6mZnul29qKNzUQWuBfwVC.Update(x_In: Output_17, y_In: Output_23, z_In: Output_27, Output_Out: out n19.GpuValue<n7.Int3> Output_29);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_18 != state_6.__p_SgN0wm5y6VHLuk3IzlmEO0 || __pin_group_Input_In_HBggr0HXW1hNmfowR43hj9_20 != state_6.__pin_group_Input_In_HBggr0HXW1hNmfowR43hj9 || State_Output_22 != state_6.__p_HBggr0HXW1hNmfowR43hj9 || State_Output_24 != state_6.__p_GrLGrnEUC89P6gr7dRtywp || __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB_26 != state_6.__pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB || State_Output_28 != state_6.__p_LrD44QaUGqFNGAi28GzuOB || State_Output_30 != state_6.__p_L6mZnul29qKNzUQWuBfwVC ? new __RsbtCYR8R9HOndepQuEGTZ(state_6)
                    {__p_SgN0wm5y6VHLuk3IzlmEO0 = State_Output_18, __pin_group_Input_In_HBggr0HXW1hNmfowR43hj9 = __pin_group_Input_In_HBggr0HXW1hNmfowR43hj9_20, __p_HBggr0HXW1hNmfowR43hj9 = State_Output_22, __p_GrLGrnEUC89P6gr7dRtywp = State_Output_24, __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB = __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB_26, __p_LrD44QaUGqFNGAi28GzuOB = State_Output_28, __p_L6mZnul29qKNzUQWuBfwVC = State_Output_30} : state_6;
                else
                {
                    state_6.__p_SgN0wm5y6VHLuk3IzlmEO0 = State_Output_18;
                    state_6.__pin_group_Input_In_HBggr0HXW1hNmfowR43hj9 = __pin_group_Input_In_HBggr0HXW1hNmfowR43hj9_20;
                    state_6.__p_HBggr0HXW1hNmfowR43hj9 = State_Output_22;
                    state_6.__p_GrLGrnEUC89P6gr7dRtywp = State_Output_24;
                    state_6.__pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB = __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB_26;
                    state_6.__p_LrD44QaUGqFNGAi28GzuOB = State_Output_28;
                    state_6.__p_L6mZnul29qKNzUQWuBfwVC = State_Output_30;
                }

                outputs_4 = n2.ValueTuple.Create(Output_29);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_31 = outputs_4.Item1;
            Output_Out = __auto_31;
            n4.IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP that_32 = this;
            if (this.__GetContext__().IsImmutable)
                that_32 = manager_2 != this.__cache_Q178uq1J7lZMcsVjxoiwkz ? new IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP(this)
                {__cache_Q178uq1J7lZMcsVjxoiwkz = manager_2} : that_32;
            else
            {
                this.__cache_Q178uq1J7lZMcsVjxoiwkz = manager_2;
            }

            return that_32;
        }

        public n4.IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP that_0 = this;
            this.__cache_Q178uq1J7lZMcsVjxoiwkz = null;
            return that_0;
        }

        public n4.IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP __CreateDefault__()
        {
            n4.IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP that_0 = this;
            this.__cache_Q178uq1J7lZMcsVjxoiwkz = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_Q178uq1J7lZMcsVjxoiwkz);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 318024U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Q178uq1J7lZMcsVjxoiwkz", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n59.Manager<n2.ValueTuple<n19.GpuValue<int>, n19.GpuValue<int>, n19.GpuValue<int>>, n2.ValueTuple<n19.GpuValue<n7.Int3>>> __cache_Q178uq1J7lZMcsVjxoiwkz = null;
        public IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP(IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP other): base(other)
        {
            this.__cache_Q178uq1J7lZMcsVjxoiwkz = other.__cache_Q178uq1J7lZMcsVjxoiwkz;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Q178uq1J7lZMcsVjxoiwkz", in __cache_Q178uq1J7lZMcsVjxoiwkz));
        }

        internal IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP __WITH__(n59.Manager<n2.ValueTuple<n19.GpuValue<int>, n19.GpuValue<int>, n19.GpuValue<int>>, n2.ValueTuple<n19.GpuValue<n7.Int3>>> __cache_Q178uq1J7lZMcsVjxoiwkz)
        {
            n4.IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Q178uq1J7lZMcsVjxoiwkz != this.__cache_Q178uq1J7lZMcsVjxoiwkz ? new IdToGrid__3D_SteV6wUPNFaO7qKZnPaWEP(this)
                {__cache_Q178uq1J7lZMcsVjxoiwkz = __cache_Q178uq1J7lZMcsVjxoiwkz} : that_0;
            else
            {
                this.__cache_Q178uq1J7lZMcsVjxoiwkz = __cache_Q178uq1J7lZMcsVjxoiwkz;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "RsbtCYR8R9HOndepQuEGTZ", Name = "__RsbtCYR8R9HOndepQuEGTZ")]
        [n2.SerializableAttribute]
        public class __RsbtCYR8R9HOndepQuEGTZ : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_SgN0wm5y6VHLuk3IzlmEO0);
                n1.CompilationHelper.SafeDispose(this.__p_HBggr0HXW1hNmfowR43hj9);
                n1.CompilationHelper.SafeDispose(this.__p_GrLGrnEUC89P6gr7dRtywp);
                n1.CompilationHelper.SafeDispose(this.__p_LrD44QaUGqFNGAi28GzuOB);
                n1.CompilationHelper.SafeDispose(this.__p_L6mZnul29qKNzUQWuBfwVC);
                return;
            }

            [n1.ElementAttribute(TracingId = 318035U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "SgN0wm5y6VHLuk3IzlmEO0", Name = "Mod", IsManaged = true, IsAutoGenerated = true)]
            public n63.Mod_CJuXD7Kyc5dPlhUjYxVZnV<int> __p_SgN0wm5y6VHLuk3IzlmEO0;
            [n1.ElementAttribute(TracingId = 318044U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "HBggr0HXW1hNmfowR43hj9", Name = "/", IsManaged = true, IsAutoGenerated = true)]
            public n63.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<int> __p_HBggr0HXW1hNmfowR43hj9;
            [n1.ElementAttribute(TracingId = 318057U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "GrLGrnEUC89P6gr7dRtywp", Name = "Mod", IsManaged = true, IsAutoGenerated = true)]
            public n63.Mod_CJuXD7Kyc5dPlhUjYxVZnV<int> __p_GrLGrnEUC89P6gr7dRtywp;
            [n1.ElementAttribute(TracingId = 318067U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "LrD44QaUGqFNGAi28GzuOB", Name = "/", IsManaged = true, IsAutoGenerated = true)]
            public n63.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<int> __p_LrD44QaUGqFNGAi28GzuOB;
            [n1.ElementAttribute(TracingId = 318074U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "L6mZnul29qKNzUQWuBfwVC", Name = "x+y+z (join)(int)", IsManaged = true, IsAutoGenerated = true)]
            public n71.xPyPz_join__int_Lf6o5qkCO5VORoVR4GhDld __p_L6mZnul29qKNzUQWuBfwVC;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n20.Spread<n19.GpuValue<int>> __pin_group_Input_In_HBggr0HXW1hNmfowR43hj9 = default(n20.Spread<n19.GpuValue<int>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n20.Spread<n19.GpuValue<int>> __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB = default(n20.Spread<n19.GpuValue<int>>);
            public __RsbtCYR8R9HOndepQuEGTZ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RsbtCYR8R9HOndepQuEGTZ(__RsbtCYR8R9HOndepQuEGTZ other): base(other)
            {
                this.__p_SgN0wm5y6VHLuk3IzlmEO0 = other.__p_SgN0wm5y6VHLuk3IzlmEO0;
                this.__p_HBggr0HXW1hNmfowR43hj9 = other.__p_HBggr0HXW1hNmfowR43hj9;
                this.__p_GrLGrnEUC89P6gr7dRtywp = other.__p_GrLGrnEUC89P6gr7dRtywp;
                this.__p_LrD44QaUGqFNGAi28GzuOB = other.__p_LrD44QaUGqFNGAi28GzuOB;
                this.__p_L6mZnul29qKNzUQWuBfwVC = other.__p_L6mZnul29qKNzUQWuBfwVC;
                this.__pin_group_Input_In_HBggr0HXW1hNmfowR43hj9 = other.__pin_group_Input_In_HBggr0HXW1hNmfowR43hj9;
                this.__pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB = other.__pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_SgN0wm5y6VHLuk3IzlmEO0", in __p_SgN0wm5y6VHLuk3IzlmEO0), n1.CompilationHelper.GetValueOrExisting(values, "__p_HBggr0HXW1hNmfowR43hj9", in __p_HBggr0HXW1hNmfowR43hj9), n1.CompilationHelper.GetValueOrExisting(values, "__p_GrLGrnEUC89P6gr7dRtywp", in __p_GrLGrnEUC89P6gr7dRtywp), n1.CompilationHelper.GetValueOrExisting(values, "__p_LrD44QaUGqFNGAi28GzuOB", in __p_LrD44QaUGqFNGAi28GzuOB), n1.CompilationHelper.GetValueOrExisting(values, "__p_L6mZnul29qKNzUQWuBfwVC", in __p_L6mZnul29qKNzUQWuBfwVC), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HBggr0HXW1hNmfowR43hj9", in __pin_group_Input_In_HBggr0HXW1hNmfowR43hj9), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB", in __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB));
            }

            internal __RsbtCYR8R9HOndepQuEGTZ __WITH__(n63.Mod_CJuXD7Kyc5dPlhUjYxVZnV<int> __p_SgN0wm5y6VHLuk3IzlmEO0, n63.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<int> __p_HBggr0HXW1hNmfowR43hj9, n63.Mod_CJuXD7Kyc5dPlhUjYxVZnV<int> __p_GrLGrnEUC89P6gr7dRtywp, n63.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<int> __p_LrD44QaUGqFNGAi28GzuOB, n71.xPyPz_join__int_Lf6o5qkCO5VORoVR4GhDld __p_L6mZnul29qKNzUQWuBfwVC, n20.Spread<n19.GpuValue<int>> __pin_group_Input_In_HBggr0HXW1hNmfowR43hj9, n20.Spread<n19.GpuValue<int>> __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB)
            {
                __RsbtCYR8R9HOndepQuEGTZ that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_SgN0wm5y6VHLuk3IzlmEO0 != this.__p_SgN0wm5y6VHLuk3IzlmEO0 || __p_HBggr0HXW1hNmfowR43hj9 != this.__p_HBggr0HXW1hNmfowR43hj9 || __p_GrLGrnEUC89P6gr7dRtywp != this.__p_GrLGrnEUC89P6gr7dRtywp || __p_LrD44QaUGqFNGAi28GzuOB != this.__p_LrD44QaUGqFNGAi28GzuOB || __p_L6mZnul29qKNzUQWuBfwVC != this.__p_L6mZnul29qKNzUQWuBfwVC || __pin_group_Input_In_HBggr0HXW1hNmfowR43hj9 != this.__pin_group_Input_In_HBggr0HXW1hNmfowR43hj9 || __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB != this.__pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB ? new __RsbtCYR8R9HOndepQuEGTZ(this)
                    {__p_SgN0wm5y6VHLuk3IzlmEO0 = __p_SgN0wm5y6VHLuk3IzlmEO0, __p_HBggr0HXW1hNmfowR43hj9 = __p_HBggr0HXW1hNmfowR43hj9, __p_GrLGrnEUC89P6gr7dRtywp = __p_GrLGrnEUC89P6gr7dRtywp, __p_LrD44QaUGqFNGAi28GzuOB = __p_LrD44QaUGqFNGAi28GzuOB, __p_L6mZnul29qKNzUQWuBfwVC = __p_L6mZnul29qKNzUQWuBfwVC, __pin_group_Input_In_HBggr0HXW1hNmfowR43hj9 = __pin_group_Input_In_HBggr0HXW1hNmfowR43hj9, __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB = __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB} : that_0;
                else
                {
                    this.__p_SgN0wm5y6VHLuk3IzlmEO0 = __p_SgN0wm5y6VHLuk3IzlmEO0;
                    this.__p_HBggr0HXW1hNmfowR43hj9 = __p_HBggr0HXW1hNmfowR43hj9;
                    this.__p_GrLGrnEUC89P6gr7dRtywp = __p_GrLGrnEUC89P6gr7dRtywp;
                    this.__p_LrD44QaUGqFNGAi28GzuOB = __p_LrD44QaUGqFNGAi28GzuOB;
                    this.__p_L6mZnul29qKNzUQWuBfwVC = __p_L6mZnul29qKNzUQWuBfwVC;
                    this.__pin_group_Input_In_HBggr0HXW1hNmfowR43hj9 = __pin_group_Input_In_HBggr0HXW1hNmfowR43hj9;
                    this.__pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB = __pin_group_Input_In_LrD44QaUGqFNGAi28GzuOB;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 318142U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "QYXkrChsxRvPTrNIaMH0hy", Name = "SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy")]
    [n2.SerializableAttribute]
    public class SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy Create(n1.NodeContext Node_Context)
        {
            var instance = new SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy CreateDefault()
        {
            var instance = new SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy Update(n4.RingBuffer3D_C Input_In, n19.GpuValue<n7.Vector2> xy_In, n19.GpuValue<float> Depth_In, out n19.GpuValue<n7.Vector4> Output_Out)
        {
            var Output_1 = Input_In.GetProgress(Progress_Out: out float Progress_0);
            n19.GpuValue<float> Input_2_2 = this.__monadBuilder_U7mXWmbPhBOOnVheYU5Tbr.Return(Progress_0);
            bool Force_3 = false;
            bool Dispose_Cached_Outputs_4 = false;
            var manager_5 = this.__cache_I4mOPIsXW2bO1Lp5BmK4aX;
            if (manager_5 is null)
            {
                manager_5 = new n59.Manager<n2.ValueTuple<n4.RingBuffer3D_C, n19.GpuValue<n7.Vector2>, n19.GpuValue<float>>, n2.ValueTuple<n19.GpuValue<n7.Vector4>>>(n2.ValueTuple.Create(default(n19.GpuValue<n7.Vector4>)));
            }

            var inputs_6 = (Input_In, xy_In, Depth_In);
            var outputs_7 = manager_5.Outputs;
            var Has_Changed_8 = Force_3 || manager_5.InputsChanged(inputs_6);
            if (Has_Changed_8)
            {
                if (Dispose_Cached_Outputs_4)
                    manager_5.DisposeOutputs();
                var state_9 = n1.CompilationHelper.Restore<__Vz0yu2sMB2LMkWHjkXt3TF>(manager_5.State, __GetContext__());
                if (state_9 == null)
                {
                    state_9 = new __Vz0yu2sMB2LMkWHjkXt3TF(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L = n23._Operations_.CreateDefault<n19.GpuValue<float>>()};
                    n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "ObhZUAHuvMrMUiyqZSLQTE", 318163U);
                    var Output_11 = n71.xyPz_join_UJclk3jWrSYPt4FX0qtEhr.Create(Node_Context: Node_Context_10);
                    state_9.__p_ObhZUAHuvMrMUiyqZSLQTE = Output_11;
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Qyzh7iEiFAIOtHPdlHbD0L", 318167U);
                    var Output_13 = n63.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float>.Create(Node_Context: Node_Context_12);
                    state_9.__p_Qyzh7iEiFAIOtHPdlHbD0L = Output_13;
                    n1.NodeContext Node_Context_14 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "CPzx2i0BnsTMhCZ9d3icSx", 318172U);
                    var Output_15 = n69.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n7.Vector3>.Create(Node_Context: Node_Context_14);
                    state_9.__p_CPzx2i0BnsTMhCZ9d3icSx = Output_15;
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "EnItYeds6yaNhWdurwCnX3", 318183U);
                    var Output_17 = n63.Frac_KqFv3USsLfWLyl494nU4Z6<float>.Create(Node_Context: Node_Context_16);
                    state_9.__p_EnItYeds6yaNhWdurwCnX3 = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "PM6vi6oQBStQDj7dH9FIup", 318189U);
                    var Output_19 = n69.TextureIn_Fuse_C.Create(Node_Context: Node_Context_18);
                    state_9.__p_PM6vi6oQBStQDj7dH9FIup = Output_19;
                }

                var builder_20 = n5.CollectionBuilders.GetBuilder(state_9.__pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L, 2);
                builder_20.Add(Depth_In);
                builder_20.Add(Input_2_2);
                var __pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L_21 = builder_20.Commit();
                var State_Output_23 = state_9.__p_Qyzh7iEiFAIOtHPdlHbD0L.Update(Input_In: __pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L_21, Output_Out: out n19.GpuValue<float> Output_22);
                var State_Output_25 = state_9.__p_EnItYeds6yaNhWdurwCnX3.Update(Input_In: Output_22, Output_Out: out n19.GpuValue<float> Output_24);
                var State_Output_27 = state_9.__p_ObhZUAHuvMrMUiyqZSLQTE.Update(xy_In: xy_In, z_In: Output_24, Output_Out: out n19.GpuValue<n7.Vector3> Output_26);
                var Output_29 = Input_In.GetTexture(Texture_Out: out n3.Texture Texture_28);
                bool SetValue_30 = true;
                var Output_31 = state_9.__p_PM6vi6oQBStQDj7dH9FIup;
                if (SetValue_30)
                {
                    Output_31 = state_9.__p_PM6vi6oQBStQDj7dH9FIup.SetValue(Texture_In: Texture_28);
                }

                var State_Output_33 = Output_31.Update(Output_Out: out n19.GpuValue<n3.Texture> Output_32);
                n19.GpuValue<n3.SamplerState> Sampler_34 = default(n19.GpuValue<n3.SamplerState>);
                n19.GpuValue<float> Level_35 = default(n19.GpuValue<float>);
                n19.GpuValue<n7.Vector4> Default_36 = default(n19.GpuValue<n7.Vector4>);
                var State_Output_38 = state_9.__p_CPzx2i0BnsTMhCZ9d3icSx.Update(Texture_In: Output_32, Sampler_In: Sampler_34, Texture_Coords_In: Output_26, Level_In: Level_35, Default_In: Default_36, Output_Out: out n19.GpuValue<n7.Vector4> Output_37);
                if (state_9.__GetContext__().IsImmutable)
                    state_9 = __pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L_21 != state_9.__pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L || State_Output_23 != state_9.__p_Qyzh7iEiFAIOtHPdlHbD0L || State_Output_25 != state_9.__p_EnItYeds6yaNhWdurwCnX3 || State_Output_27 != state_9.__p_ObhZUAHuvMrMUiyqZSLQTE || State_Output_33 != state_9.__p_PM6vi6oQBStQDj7dH9FIup || State_Output_38 != state_9.__p_CPzx2i0BnsTMhCZ9d3icSx ? new __Vz0yu2sMB2LMkWHjkXt3TF(state_9)
                    {__pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L = __pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L_21, __p_Qyzh7iEiFAIOtHPdlHbD0L = State_Output_23, __p_EnItYeds6yaNhWdurwCnX3 = State_Output_25, __p_ObhZUAHuvMrMUiyqZSLQTE = State_Output_27, __p_PM6vi6oQBStQDj7dH9FIup = State_Output_33, __p_CPzx2i0BnsTMhCZ9d3icSx = State_Output_38} : state_9;
                else
                {
                    state_9.__pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L = __pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L_21;
                    state_9.__p_Qyzh7iEiFAIOtHPdlHbD0L = State_Output_23;
                    state_9.__p_EnItYeds6yaNhWdurwCnX3 = State_Output_25;
                    state_9.__p_ObhZUAHuvMrMUiyqZSLQTE = State_Output_27;
                    state_9.__p_PM6vi6oQBStQDj7dH9FIup = State_Output_33;
                    state_9.__p_CPzx2i0BnsTMhCZ9d3icSx = State_Output_38;
                }

                outputs_7 = n2.ValueTuple.Create(Output_37);
                manager_5 = manager_5.Update(inputs_6, __GetContext__().IsImmutable, Dispose_Cached_Outputs_4, state_9, outputs_7);
            }
            else
            {
                manager_5.Update(inputs_6, __GetContext__().IsImmutable, Dispose_Cached_Outputs_4);
            }

            var __auto_39 = outputs_7.Item1;
            Output_Out = __auto_39;
            n4.SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy that_40 = this;
            if (this.__GetContext__().IsImmutable)
                that_40 = manager_5 != this.__cache_I4mOPIsXW2bO1Lp5BmK4aX ? new SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy(this)
                {__cache_I4mOPIsXW2bO1Lp5BmK4aX = manager_5} : that_40;
            else
            {
                this.__cache_I4mOPIsXW2bO1Lp5BmK4aX = manager_5;
            }

            return that_40;
        }

        public n4.SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n4.SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy that_0 = this;
            this.__monadBuilder_U7mXWmbPhBOOnVheYU5Tbr = n19.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__cache_I4mOPIsXW2bO1Lp5BmK4aX = null;
            return that_0;
        }

        public n4.SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy __CreateDefault__()
        {
            n4.SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy that_0 = this;
            this.__monadBuilder_U7mXWmbPhBOOnVheYU5Tbr = n19.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__cache_I4mOPIsXW2bO1Lp5BmK4aX = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_U7mXWmbPhBOOnVheYU5Tbr);
            n1.CompilationHelper.SafeDispose(this.__cache_I4mOPIsXW2bO1Lp5BmK4aX);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<float, n19.GpuValue<float>> __monadBuilder_U7mXWmbPhBOOnVheYU5Tbr = n19.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 318154U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "I4mOPIsXW2bO1Lp5BmK4aX", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n59.Manager<n2.ValueTuple<n4.RingBuffer3D_C, n19.GpuValue<n7.Vector2>, n19.GpuValue<float>>, n2.ValueTuple<n19.GpuValue<n7.Vector4>>> __cache_I4mOPIsXW2bO1Lp5BmK4aX = null;
        public SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy(SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy other): base(other)
        {
            this.__monadBuilder_U7mXWmbPhBOOnVheYU5Tbr = other.__monadBuilder_U7mXWmbPhBOOnVheYU5Tbr;
            this.__cache_I4mOPIsXW2bO1Lp5BmK4aX = other.__cache_I4mOPIsXW2bO1Lp5BmK4aX;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_U7mXWmbPhBOOnVheYU5Tbr", in __monadBuilder_U7mXWmbPhBOOnVheYU5Tbr), n1.CompilationHelper.GetValueOrExisting(values, "__cache_I4mOPIsXW2bO1Lp5BmK4aX", in __cache_I4mOPIsXW2bO1Lp5BmK4aX));
        }

        internal SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy __WITH__(n1.IMonadBuilder<float, n19.GpuValue<float>> __monadBuilder_U7mXWmbPhBOOnVheYU5Tbr, n59.Manager<n2.ValueTuple<n4.RingBuffer3D_C, n19.GpuValue<n7.Vector2>, n19.GpuValue<float>>, n2.ValueTuple<n19.GpuValue<n7.Vector4>>> __cache_I4mOPIsXW2bO1Lp5BmK4aX)
        {
            n4.SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __monadBuilder_U7mXWmbPhBOOnVheYU5Tbr != this.__monadBuilder_U7mXWmbPhBOOnVheYU5Tbr || __cache_I4mOPIsXW2bO1Lp5BmK4aX != this.__cache_I4mOPIsXW2bO1Lp5BmK4aX ? new SampleRingBuffer3D_QYXkrChsxRvPTrNIaMH0hy(this)
                {__monadBuilder_U7mXWmbPhBOOnVheYU5Tbr = __monadBuilder_U7mXWmbPhBOOnVheYU5Tbr, __cache_I4mOPIsXW2bO1Lp5BmK4aX = __cache_I4mOPIsXW2bO1Lp5BmK4aX} : that_0;
            else
            {
                this.__monadBuilder_U7mXWmbPhBOOnVheYU5Tbr = __monadBuilder_U7mXWmbPhBOOnVheYU5Tbr;
                this.__cache_I4mOPIsXW2bO1Lp5BmK4aX = __cache_I4mOPIsXW2bO1Lp5BmK4aX;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Vz0yu2sMB2LMkWHjkXt3TF", Name = "__Vz0yu2sMB2LMkWHjkXt3TF")]
        [n2.SerializableAttribute]
        public class __Vz0yu2sMB2LMkWHjkXt3TF : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_ObhZUAHuvMrMUiyqZSLQTE);
                n1.CompilationHelper.SafeDispose(this.__p_Qyzh7iEiFAIOtHPdlHbD0L);
                n1.CompilationHelper.SafeDispose(this.__p_CPzx2i0BnsTMhCZ9d3icSx);
                n1.CompilationHelper.SafeDispose(this.__p_EnItYeds6yaNhWdurwCnX3);
                n1.CompilationHelper.SafeDispose(this.__p_PM6vi6oQBStQDj7dH9FIup);
                return;
            }

            [n1.ElementAttribute(TracingId = 318163U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "ObhZUAHuvMrMUiyqZSLQTE", Name = "xy+z (join)", IsManaged = true, IsAutoGenerated = true)]
            public n71.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_ObhZUAHuvMrMUiyqZSLQTE;
            [n1.ElementAttribute(TracingId = 318167U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Qyzh7iEiFAIOtHPdlHbD0L", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n63.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_Qyzh7iEiFAIOtHPdlHbD0L;
            [n1.ElementAttribute(TracingId = 318172U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "CPzx2i0BnsTMhCZ9d3icSx", Name = "SampleTexture (Fuse)", IsManaged = true, IsAutoGenerated = true)]
            public n69.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n7.Vector3> __p_CPzx2i0BnsTMhCZ9d3icSx;
            [n1.ElementAttribute(TracingId = 318183U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "EnItYeds6yaNhWdurwCnX3", Name = "Frac", IsManaged = true, IsAutoGenerated = true)]
            public n63.Frac_KqFv3USsLfWLyl494nU4Z6<float> __p_EnItYeds6yaNhWdurwCnX3;
            [n1.ElementAttribute(TracingId = 318189U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "PM6vi6oQBStQDj7dH9FIup", Name = "TextureIn (Fuse)", IsManaged = true, IsAutoGenerated = true)]
            public n69.TextureIn_Fuse_C __p_PM6vi6oQBStQDj7dH9FIup;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n20.Spread<n19.GpuValue<float>> __pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L = default(n20.Spread<n19.GpuValue<float>>);
            public __Vz0yu2sMB2LMkWHjkXt3TF(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Vz0yu2sMB2LMkWHjkXt3TF(__Vz0yu2sMB2LMkWHjkXt3TF other): base(other)
            {
                this.__p_ObhZUAHuvMrMUiyqZSLQTE = other.__p_ObhZUAHuvMrMUiyqZSLQTE;
                this.__p_Qyzh7iEiFAIOtHPdlHbD0L = other.__p_Qyzh7iEiFAIOtHPdlHbD0L;
                this.__p_CPzx2i0BnsTMhCZ9d3icSx = other.__p_CPzx2i0BnsTMhCZ9d3icSx;
                this.__p_EnItYeds6yaNhWdurwCnX3 = other.__p_EnItYeds6yaNhWdurwCnX3;
                this.__p_PM6vi6oQBStQDj7dH9FIup = other.__p_PM6vi6oQBStQDj7dH9FIup;
                this.__pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L = other.__pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_ObhZUAHuvMrMUiyqZSLQTE", in __p_ObhZUAHuvMrMUiyqZSLQTE), n1.CompilationHelper.GetValueOrExisting(values, "__p_Qyzh7iEiFAIOtHPdlHbD0L", in __p_Qyzh7iEiFAIOtHPdlHbD0L), n1.CompilationHelper.GetValueOrExisting(values, "__p_CPzx2i0BnsTMhCZ9d3icSx", in __p_CPzx2i0BnsTMhCZ9d3icSx), n1.CompilationHelper.GetValueOrExisting(values, "__p_EnItYeds6yaNhWdurwCnX3", in __p_EnItYeds6yaNhWdurwCnX3), n1.CompilationHelper.GetValueOrExisting(values, "__p_PM6vi6oQBStQDj7dH9FIup", in __p_PM6vi6oQBStQDj7dH9FIup), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L", in __pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L));
            }

            internal __Vz0yu2sMB2LMkWHjkXt3TF __WITH__(n71.xyPz_join_UJclk3jWrSYPt4FX0qtEhr __p_ObhZUAHuvMrMUiyqZSLQTE, n63.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_Qyzh7iEiFAIOtHPdlHbD0L, n69.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n7.Vector3> __p_CPzx2i0BnsTMhCZ9d3icSx, n63.Frac_KqFv3USsLfWLyl494nU4Z6<float> __p_EnItYeds6yaNhWdurwCnX3, n69.TextureIn_Fuse_C __p_PM6vi6oQBStQDj7dH9FIup, n20.Spread<n19.GpuValue<float>> __pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L)
            {
                __Vz0yu2sMB2LMkWHjkXt3TF that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_ObhZUAHuvMrMUiyqZSLQTE != this.__p_ObhZUAHuvMrMUiyqZSLQTE || __p_Qyzh7iEiFAIOtHPdlHbD0L != this.__p_Qyzh7iEiFAIOtHPdlHbD0L || __p_CPzx2i0BnsTMhCZ9d3icSx != this.__p_CPzx2i0BnsTMhCZ9d3icSx || __p_EnItYeds6yaNhWdurwCnX3 != this.__p_EnItYeds6yaNhWdurwCnX3 || __p_PM6vi6oQBStQDj7dH9FIup != this.__p_PM6vi6oQBStQDj7dH9FIup || __pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L != this.__pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L ? new __Vz0yu2sMB2LMkWHjkXt3TF(this)
                    {__p_ObhZUAHuvMrMUiyqZSLQTE = __p_ObhZUAHuvMrMUiyqZSLQTE, __p_Qyzh7iEiFAIOtHPdlHbD0L = __p_Qyzh7iEiFAIOtHPdlHbD0L, __p_CPzx2i0BnsTMhCZ9d3icSx = __p_CPzx2i0BnsTMhCZ9d3icSx, __p_EnItYeds6yaNhWdurwCnX3 = __p_EnItYeds6yaNhWdurwCnX3, __p_PM6vi6oQBStQDj7dH9FIup = __p_PM6vi6oQBStQDj7dH9FIup, __pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L = __pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L} : that_0;
                else
                {
                    this.__p_ObhZUAHuvMrMUiyqZSLQTE = __p_ObhZUAHuvMrMUiyqZSLQTE;
                    this.__p_Qyzh7iEiFAIOtHPdlHbD0L = __p_Qyzh7iEiFAIOtHPdlHbD0L;
                    this.__p_CPzx2i0BnsTMhCZ9d3icSx = __p_CPzx2i0BnsTMhCZ9d3icSx;
                    this.__p_EnItYeds6yaNhWdurwCnX3 = __p_EnItYeds6yaNhWdurwCnX3;
                    this.__p_PM6vi6oQBStQDj7dH9FIup = __p_PM6vi6oQBStQDj7dH9FIup;
                    this.__pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L = __pin_group_Input_In_Qyzh7iEiFAIOtHPdlHbD0L;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 318264U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "BFdaFQnWiLOPF7uGzOiltZ", Name = "SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ")]
    [n2.SerializableAttribute]
    public class SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ Create(n1.NodeContext Node_Context)
        {
            var instance = new SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ CreateDefault()
        {
            var instance = new SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ Update(n4.RingBuffer2D_C Input_In, n19.GpuValue<float> x_In, n19.GpuValue<float> Depth_In, out n19.GpuValue<n7.Vector4> Output_Out)
        {
            var Output_1 = Input_In.GetProgress(Progress_Out: out float Progress_0);
            n19.GpuValue<float> Input_2_2 = this.__monadBuilder_DydD5i6OWA9LFyPZqCwCq9.Return(Progress_0);
            var Output_4 = Input_In.GetTexture(Texture_Out: out n3.Texture Texture_3);
            bool SetValue_5 = true;
            var Output_6 = this.__p_UQt1olci4LtOgJqw1E5uW0;
            if (SetValue_5)
            {
                Output_6 = this.__p_UQt1olci4LtOgJqw1E5uW0.SetValue(Texture_In: Texture_3);
            }

            var State_Output_8 = Output_6.Update(Output_Out: out n19.GpuValue<n3.Texture> Output_7);
            bool Force_9 = false;
            bool Dispose_Cached_Outputs_10 = false;
            var manager_11 = this.__cache_RDa7gxiyPIwNgHCKXvdt4k;
            if (manager_11 is null)
            {
                manager_11 = new n59.Manager<n2.ValueTuple<n19.GpuValue<n3.Texture>, n19.GpuValue<float>, n19.GpuValue<float>>, n2.ValueTuple<n19.GpuValue<n7.Vector4>>>(n2.ValueTuple.Create(default(n19.GpuValue<n7.Vector4>)));
            }

            var inputs_12 = (Output_7, x_In, Depth_In);
            var outputs_13 = manager_11.Outputs;
            var Has_Changed_14 = Force_9 || manager_11.InputsChanged(inputs_12);
            if (Has_Changed_14)
            {
                if (Dispose_Cached_Outputs_10)
                    manager_11.DisposeOutputs();
                var state_15 = n1.CompilationHelper.Restore<__L639wvqsCehL281V2puSGw>(manager_11.State, __GetContext__());
                if (state_15 == null)
                {
                    state_15 = new __L639wvqsCehL281V2puSGw(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX = n23._Operations_.CreateDefault<n19.GpuValue<float>>()};
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Ia1XbjZ7UJrNGIzn2GropX", 318282U);
                    var Output_17 = n63.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float>.Create(Node_Context: Node_Context_16);
                    state_15.__p_Ia1XbjZ7UJrNGIzn2GropX = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "EUKjGNNTM3uQIXBmoZ84XL", 318287U);
                    var Output_19 = n69.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n7.Vector2>.Create(Node_Context: Node_Context_18);
                    state_15.__p_EUKjGNNTM3uQIXBmoZ84XL = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "L9BgdrkCxrIPKbUX5gQZE1", 318298U);
                    var Output_21 = n63.Frac_KqFv3USsLfWLyl494nU4Z6<float>.Create(Node_Context: Node_Context_20);
                    state_15.__p_L9BgdrkCxrIPKbUX5gQZE1 = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "EcLykUa7UTZL3SkfVJS6CA", 318304U);
                    var Output_23 = n71.xPy_join_JIONWu6byjBM6yvKcs4o8k.Create(Node_Context: Node_Context_22);
                    state_15.__p_EcLykUa7UTZL3SkfVJS6CA = Output_23;
                    n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "GHJDEhx8yDxPENvU77N62G", 318312U);
                    var Output_25 = n80.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float>.Create(Node_Context: Node_Context_24);
                    state_15.__p_GHJDEhx8yDxPENvU77N62G = Output_25;
                }

                float The_Value_26 = 0F;
                var State_Output_28 = state_15.__p_GHJDEhx8yDxPENvU77N62G.Update(GpuValue_In: Depth_In, The_Value_In: The_Value_26, Output_Out: out n19.GpuValue<float> Output_27);
                var builder_29 = n5.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX, 2);
                builder_29.Add(Output_27);
                builder_29.Add(Input_2_2);
                var __pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX_30 = builder_29.Commit();
                var State_Output_32 = state_15.__p_Ia1XbjZ7UJrNGIzn2GropX.Update(Input_In: __pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX_30, Output_Out: out n19.GpuValue<float> Output_31);
                var State_Output_34 = state_15.__p_L9BgdrkCxrIPKbUX5gQZE1.Update(Input_In: Output_31, Output_Out: out n19.GpuValue<float> Output_33);
                var State_Output_36 = state_15.__p_EcLykUa7UTZL3SkfVJS6CA.Update(x_In: x_In, y_In: Output_33, Output_Out: out n19.GpuValue<n7.Vector2> Output_35);
                n19.GpuValue<n3.SamplerState> Sampler_37 = default(n19.GpuValue<n3.SamplerState>);
                n19.GpuValue<float> Level_38 = default(n19.GpuValue<float>);
                n19.GpuValue<n7.Vector4> Default_39 = default(n19.GpuValue<n7.Vector4>);
                var State_Output_41 = state_15.__p_EUKjGNNTM3uQIXBmoZ84XL.Update(Texture_In: Output_7, Sampler_In: Sampler_37, Texture_Coords_In: Output_35, Level_In: Level_38, Default_In: Default_39, Output_Out: out n19.GpuValue<n7.Vector4> Output_40);
                if (state_15.__GetContext__().IsImmutable)
                    state_15 = State_Output_28 != state_15.__p_GHJDEhx8yDxPENvU77N62G || __pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX_30 != state_15.__pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX || State_Output_32 != state_15.__p_Ia1XbjZ7UJrNGIzn2GropX || State_Output_34 != state_15.__p_L9BgdrkCxrIPKbUX5gQZE1 || State_Output_36 != state_15.__p_EcLykUa7UTZL3SkfVJS6CA || State_Output_41 != state_15.__p_EUKjGNNTM3uQIXBmoZ84XL ? new __L639wvqsCehL281V2puSGw(state_15)
                    {__p_GHJDEhx8yDxPENvU77N62G = State_Output_28, __pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX = __pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX_30, __p_Ia1XbjZ7UJrNGIzn2GropX = State_Output_32, __p_L9BgdrkCxrIPKbUX5gQZE1 = State_Output_34, __p_EcLykUa7UTZL3SkfVJS6CA = State_Output_36, __p_EUKjGNNTM3uQIXBmoZ84XL = State_Output_41} : state_15;
                else
                {
                    state_15.__p_GHJDEhx8yDxPENvU77N62G = State_Output_28;
                    state_15.__pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX = __pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX_30;
                    state_15.__p_Ia1XbjZ7UJrNGIzn2GropX = State_Output_32;
                    state_15.__p_L9BgdrkCxrIPKbUX5gQZE1 = State_Output_34;
                    state_15.__p_EcLykUa7UTZL3SkfVJS6CA = State_Output_36;
                    state_15.__p_EUKjGNNTM3uQIXBmoZ84XL = State_Output_41;
                }

                outputs_13 = n2.ValueTuple.Create(Output_40);
                manager_11 = manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10, state_15, outputs_13);
            }
            else
            {
                manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10);
            }

            var __auto_42 = outputs_13.Item1;
            Output_Out = __auto_42;
            n4.SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ that_43 = this;
            if (this.__GetContext__().IsImmutable)
                that_43 = State_Output_8 != this.__p_UQt1olci4LtOgJqw1E5uW0 || manager_11 != this.__cache_RDa7gxiyPIwNgHCKXvdt4k ? new SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ(this)
                {__p_UQt1olci4LtOgJqw1E5uW0 = State_Output_8, __cache_RDa7gxiyPIwNgHCKXvdt4k = manager_11} : that_43;
            else
            {
                this.__p_UQt1olci4LtOgJqw1E5uW0 = State_Output_8;
                this.__cache_RDa7gxiyPIwNgHCKXvdt4k = manager_11;
            }

            return that_43;
        }

        public n4.SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "UQt1olci4LtOgJqw1E5uW0", 318337U);
            var Output_1 = n69.TextureIn_Fuse_C.Create(Node_Context: Node_Context_0);
            n4.SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ that_2 = this;
            this.__p_UQt1olci4LtOgJqw1E5uW0 = Output_1;
            this.__monadBuilder_DydD5i6OWA9LFyPZqCwCq9 = n19.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__cache_RDa7gxiyPIwNgHCKXvdt4k = null;
            return that_2;
        }

        public n4.SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ __CreateDefault__()
        {
            n4.SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ that_0 = this;
            this.__monadBuilder_DydD5i6OWA9LFyPZqCwCq9 = n19.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            this.__p_UQt1olci4LtOgJqw1E5uW0 = n69.TextureIn_Fuse_C.CreateDefault();
            this.__cache_RDa7gxiyPIwNgHCKXvdt4k = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_DydD5i6OWA9LFyPZqCwCq9);
            n1.CompilationHelper.SafeDispose(this.__p_UQt1olci4LtOgJqw1E5uW0);
            n1.CompilationHelper.SafeDispose(this.__cache_RDa7gxiyPIwNgHCKXvdt4k);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<float, n19.GpuValue<float>> __monadBuilder_DydD5i6OWA9LFyPZqCwCq9 = n19.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 318337U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "UQt1olci4LtOgJqw1E5uW0", Name = "TextureIn (Fuse)", IsManaged = true, IsAutoGenerated = true)]
        public n69.TextureIn_Fuse_C __p_UQt1olci4LtOgJqw1E5uW0;
        [n1.ElementAttribute(TracingId = 318272U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "RDa7gxiyPIwNgHCKXvdt4k", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n59.Manager<n2.ValueTuple<n19.GpuValue<n3.Texture>, n19.GpuValue<float>, n19.GpuValue<float>>, n2.ValueTuple<n19.GpuValue<n7.Vector4>>> __cache_RDa7gxiyPIwNgHCKXvdt4k = null;
        public SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ(SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ other): base(other)
        {
            this.__monadBuilder_DydD5i6OWA9LFyPZqCwCq9 = other.__monadBuilder_DydD5i6OWA9LFyPZqCwCq9;
            this.__p_UQt1olci4LtOgJqw1E5uW0 = other.__p_UQt1olci4LtOgJqw1E5uW0;
            this.__cache_RDa7gxiyPIwNgHCKXvdt4k = other.__cache_RDa7gxiyPIwNgHCKXvdt4k;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_DydD5i6OWA9LFyPZqCwCq9", in __monadBuilder_DydD5i6OWA9LFyPZqCwCq9), n1.CompilationHelper.GetValueOrExisting(values, "__p_UQt1olci4LtOgJqw1E5uW0", in __p_UQt1olci4LtOgJqw1E5uW0), n1.CompilationHelper.GetValueOrExisting(values, "__cache_RDa7gxiyPIwNgHCKXvdt4k", in __cache_RDa7gxiyPIwNgHCKXvdt4k));
        }

        internal SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ __WITH__(n1.IMonadBuilder<float, n19.GpuValue<float>> __monadBuilder_DydD5i6OWA9LFyPZqCwCq9, n69.TextureIn_Fuse_C __p_UQt1olci4LtOgJqw1E5uW0, n59.Manager<n2.ValueTuple<n19.GpuValue<n3.Texture>, n19.GpuValue<float>, n19.GpuValue<float>>, n2.ValueTuple<n19.GpuValue<n7.Vector4>>> __cache_RDa7gxiyPIwNgHCKXvdt4k)
        {
            n4.SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __monadBuilder_DydD5i6OWA9LFyPZqCwCq9 != this.__monadBuilder_DydD5i6OWA9LFyPZqCwCq9 || __p_UQt1olci4LtOgJqw1E5uW0 != this.__p_UQt1olci4LtOgJqw1E5uW0 || __cache_RDa7gxiyPIwNgHCKXvdt4k != this.__cache_RDa7gxiyPIwNgHCKXvdt4k ? new SampleRingBuffer2D_BFdaFQnWiLOPF7uGzOiltZ(this)
                {__monadBuilder_DydD5i6OWA9LFyPZqCwCq9 = __monadBuilder_DydD5i6OWA9LFyPZqCwCq9, __p_UQt1olci4LtOgJqw1E5uW0 = __p_UQt1olci4LtOgJqw1E5uW0, __cache_RDa7gxiyPIwNgHCKXvdt4k = __cache_RDa7gxiyPIwNgHCKXvdt4k} : that_0;
            else
            {
                this.__monadBuilder_DydD5i6OWA9LFyPZqCwCq9 = __monadBuilder_DydD5i6OWA9LFyPZqCwCq9;
                this.__p_UQt1olci4LtOgJqw1E5uW0 = __p_UQt1olci4LtOgJqw1E5uW0;
                this.__cache_RDa7gxiyPIwNgHCKXvdt4k = __cache_RDa7gxiyPIwNgHCKXvdt4k;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "L639wvqsCehL281V2puSGw", Name = "__L639wvqsCehL281V2puSGw")]
        [n2.SerializableAttribute]
        public class __L639wvqsCehL281V2puSGw : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Ia1XbjZ7UJrNGIzn2GropX);
                n1.CompilationHelper.SafeDispose(this.__p_EUKjGNNTM3uQIXBmoZ84XL);
                n1.CompilationHelper.SafeDispose(this.__p_L9BgdrkCxrIPKbUX5gQZE1);
                n1.CompilationHelper.SafeDispose(this.__p_EcLykUa7UTZL3SkfVJS6CA);
                n1.CompilationHelper.SafeDispose(this.__p_GHJDEhx8yDxPENvU77N62G);
                return;
            }

            [n1.ElementAttribute(TracingId = 318282U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Ia1XbjZ7UJrNGIzn2GropX", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n63.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_Ia1XbjZ7UJrNGIzn2GropX;
            [n1.ElementAttribute(TracingId = 318287U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "EUKjGNNTM3uQIXBmoZ84XL", Name = "SampleTexture (Fuse)", IsManaged = true, IsAutoGenerated = true)]
            public n69.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n7.Vector2> __p_EUKjGNNTM3uQIXBmoZ84XL;
            [n1.ElementAttribute(TracingId = 318298U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "L9BgdrkCxrIPKbUX5gQZE1", Name = "Frac", IsManaged = true, IsAutoGenerated = true)]
            public n63.Frac_KqFv3USsLfWLyl494nU4Z6<float> __p_L9BgdrkCxrIPKbUX5gQZE1;
            [n1.ElementAttribute(TracingId = 318304U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "EcLykUa7UTZL3SkfVJS6CA", Name = "x+y (join)", IsManaged = true, IsAutoGenerated = true)]
            public n71.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_EcLykUa7UTZL3SkfVJS6CA;
            [n1.ElementAttribute(TracingId = 318312U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "GHJDEhx8yDxPENvU77N62G", Name = "CheckDefault", IsManaged = true, IsAutoGenerated = true)]
            public n80.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_GHJDEhx8yDxPENvU77N62G;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n20.Spread<n19.GpuValue<float>> __pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX = default(n20.Spread<n19.GpuValue<float>>);
            public __L639wvqsCehL281V2puSGw(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __L639wvqsCehL281V2puSGw(__L639wvqsCehL281V2puSGw other): base(other)
            {
                this.__p_Ia1XbjZ7UJrNGIzn2GropX = other.__p_Ia1XbjZ7UJrNGIzn2GropX;
                this.__p_EUKjGNNTM3uQIXBmoZ84XL = other.__p_EUKjGNNTM3uQIXBmoZ84XL;
                this.__p_L9BgdrkCxrIPKbUX5gQZE1 = other.__p_L9BgdrkCxrIPKbUX5gQZE1;
                this.__p_EcLykUa7UTZL3SkfVJS6CA = other.__p_EcLykUa7UTZL3SkfVJS6CA;
                this.__p_GHJDEhx8yDxPENvU77N62G = other.__p_GHJDEhx8yDxPENvU77N62G;
                this.__pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX = other.__pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Ia1XbjZ7UJrNGIzn2GropX", in __p_Ia1XbjZ7UJrNGIzn2GropX), n1.CompilationHelper.GetValueOrExisting(values, "__p_EUKjGNNTM3uQIXBmoZ84XL", in __p_EUKjGNNTM3uQIXBmoZ84XL), n1.CompilationHelper.GetValueOrExisting(values, "__p_L9BgdrkCxrIPKbUX5gQZE1", in __p_L9BgdrkCxrIPKbUX5gQZE1), n1.CompilationHelper.GetValueOrExisting(values, "__p_EcLykUa7UTZL3SkfVJS6CA", in __p_EcLykUa7UTZL3SkfVJS6CA), n1.CompilationHelper.GetValueOrExisting(values, "__p_GHJDEhx8yDxPENvU77N62G", in __p_GHJDEhx8yDxPENvU77N62G), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX", in __pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX));
            }

            internal __L639wvqsCehL281V2puSGw __WITH__(n63.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<float> __p_Ia1XbjZ7UJrNGIzn2GropX, n69.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n7.Vector2> __p_EUKjGNNTM3uQIXBmoZ84XL, n63.Frac_KqFv3USsLfWLyl494nU4Z6<float> __p_L9BgdrkCxrIPKbUX5gQZE1, n71.xPy_join_JIONWu6byjBM6yvKcs4o8k __p_EcLykUa7UTZL3SkfVJS6CA, n80.CheckDefault_V0hO4nVYvs5LgOocFB6XqD<float> __p_GHJDEhx8yDxPENvU77N62G, n20.Spread<n19.GpuValue<float>> __pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX)
            {
                __L639wvqsCehL281V2puSGw that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Ia1XbjZ7UJrNGIzn2GropX != this.__p_Ia1XbjZ7UJrNGIzn2GropX || __p_EUKjGNNTM3uQIXBmoZ84XL != this.__p_EUKjGNNTM3uQIXBmoZ84XL || __p_L9BgdrkCxrIPKbUX5gQZE1 != this.__p_L9BgdrkCxrIPKbUX5gQZE1 || __p_EcLykUa7UTZL3SkfVJS6CA != this.__p_EcLykUa7UTZL3SkfVJS6CA || __p_GHJDEhx8yDxPENvU77N62G != this.__p_GHJDEhx8yDxPENvU77N62G || __pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX != this.__pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX ? new __L639wvqsCehL281V2puSGw(this)
                    {__p_Ia1XbjZ7UJrNGIzn2GropX = __p_Ia1XbjZ7UJrNGIzn2GropX, __p_EUKjGNNTM3uQIXBmoZ84XL = __p_EUKjGNNTM3uQIXBmoZ84XL, __p_L9BgdrkCxrIPKbUX5gQZE1 = __p_L9BgdrkCxrIPKbUX5gQZE1, __p_EcLykUa7UTZL3SkfVJS6CA = __p_EcLykUa7UTZL3SkfVJS6CA, __p_GHJDEhx8yDxPENvU77N62G = __p_GHJDEhx8yDxPENvU77N62G, __pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX = __pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX} : that_0;
                else
                {
                    this.__p_Ia1XbjZ7UJrNGIzn2GropX = __p_Ia1XbjZ7UJrNGIzn2GropX;
                    this.__p_EUKjGNNTM3uQIXBmoZ84XL = __p_EUKjGNNTM3uQIXBmoZ84XL;
                    this.__p_L9BgdrkCxrIPKbUX5gQZE1 = __p_L9BgdrkCxrIPKbUX5gQZE1;
                    this.__p_EcLykUa7UTZL3SkfVJS6CA = __p_EcLykUa7UTZL3SkfVJS6CA;
                    this.__p_GHJDEhx8yDxPENvU77N62G = __p_GHJDEhx8yDxPENvU77N62G;
                    this.__pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX = __pin_group_Input_In_Ia1XbjZ7UJrNGIzn2GropX;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 318393U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "VT1KRTQBhDzQVnEU7JNiUh", Name = "RingBuffer2D_C")]
    [n2.SerializableAttribute]
    public class RingBuffer2D_C : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.RingBuffer2D_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new RingBuffer2D_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.RingBuffer2D_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new RingBuffer2D_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.RingBuffer2D_C Update([n5.SerializedDefaultValueAttribute("R32G32B32A32_Float", false)] n18.PixelFormat Format_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enable_In, out n66.VLComputeEffectShader Dispatcher_Out, out n3.Texture Texture_Out)
        {
            bool __pad_PrhhPBIAGfKM6KR2DmU0d6_0 = __slot_PrhhPBIAGfKM6KR2DmU0d6;
            n7.Int2 __auto_1 = this.resolution;
            n3.Texture __auto_2 = this.InTexture;
            var State_Output_4 = this.__p_L4Vn9Kjch9uMPaHwT6dupK.Update(Simulate_In: __pad_PrhhPBIAGfKM6KR2DmU0d6_0, Output_Out: out bool Output_3);
            this.__p_L4Vn9Kjch9uMPaHwT6dupK = State_Output_4;
            n19.GpuValue<n3.Texture> Texture_5 = this.__monadBuilder_RJu07OgFPdwPHGdLZmwmhC.Return(__auto_2);
            RingBuffer2D_C Instance_6 = this;
            var Output_8 = Instance_6.UpdateCounter(Enable_In: Enable_In, index_Out: out int index_7);
            n19.GpuValue<int> y_9 = this.__monadBuilder_EogJLjq65PLN8oZ3fhjgGL.Return(index_7);
            bool Dispose_Cached_Outputs_10 = false;
            var manager_11 = this.__cache_CGxF1IMNe8rPU6zE1Z6xr9;
            if (manager_11 is null)
            {
                manager_11 = new n59.Manager<n2.ValueTuple<n7.Int2, n18.PixelFormat>, n2.ValueTuple<n66.VLComputeEffectShader, n3.Texture>>((default(n66.VLComputeEffectShader), default(n3.Texture)));
            }

            var inputs_12 = (__auto_1, Format_In);
            var outputs_13 = manager_11.Outputs;
            var Has_Changed_14 = Output_3 || manager_11.InputsChanged(inputs_12);
            if (Has_Changed_14)
            {
                if (Dispose_Cached_Outputs_10)
                    manager_11.DisposeOutputs();
                var state_15 = n1.CompilationHelper.Restore<__CSD8AtCnIceMMVMP7Zd4cY>(manager_11.State, __GetContext__());
                if (state_15 == null)
                {
                    state_15 = new __CSD8AtCnIceMMVMP7Zd4cY(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX = n23._Operations_.CreateDefault<n19.GpuValue<n7.Vector2>>()};
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Tp3Ec8mos1lQIS3hKK8Ey2", 318459U);
                    var Output_17 = n29.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2.Create(Node_Context: Node_Context_16);
                    state_15.__p_Tp3Ec8mos1lQIS3hKK8Ey2 = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "E59IFiEv0CtP81ywyh22xx", 318477U);
                    var Output_19 = n67.TextureSet_GTElf8F5BISPYwp53N4yR3<n19.GpuValue<n7.Int2>, n7.Vector4>.Create(Node_Context: Node_Context_18);
                    state_15.__p_E59IFiEv0CtP81ywyh22xx = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "DXi2vrlLoBZMJlTN4yBAhT", 318490U);
                    var Output_21 = n64.ToVector2_G7HULoyX6qHQO2XXvbzbNX<n7.Int2>.Create(Node_Context: Node_Context_20);
                    state_15.__p_DXi2vrlLoBZMJlTN4yBAhT = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "GtYe1Z7CeAMMSCtO90El9x", 318500U);
                    var Output_23 = n68.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy.Create(Node_Context: Node_Context_22);
                    state_15.__p_GtYe1Z7CeAMMSCtO90El9x = Output_23;
                    var node_24 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "DirectDispatcher", "Stride.Rendering.Advanced");
                    state_15.__p_KYeMA5uZn0hOqpJ1hRzVTC = node_24;
                    n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "UdL9pJF2SsZLt32iQhTrwX", 318524U);
                    var Output_26 = n63.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n7.Vector2>.Create(Node_Context: Node_Context_25);
                    state_15.__p_UdL9pJF2SsZLt32iQhTrwX = Output_26;
                    n1.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "R1uiy3VXVDCPoUE0Kip2yV", 318534U);
                    var Output_28 = n69.TextureIn_Fuse_C.Create(Node_Context: Node_Context_27);
                    state_15.__p_R1uiy3VXVDCPoUE0Kip2yV = Output_28;
                    n1.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "RfNCjVL8BaJNy04Oxt6PdB", 318557U);
                    var Output_30 = n70.xy_int_SItNjydkI3fK9bxXkl1p4y<n7.Int3>.Create(Node_Context: Node_Context_29);
                    state_15.__p_RfNCjVL8BaJNy04Oxt6PdB = Output_30;
                    n1.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "HPPPRzb5hKVOTeWAxUTupN", 318565U);
                    var Output_32 = n72.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5.Create(Node_Context: Node_Context_31);
                    state_15.__p_HPPPRzb5hKVOTeWAxUTupN = Output_32;
                    n1.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "P9jAwtAxEu4LQRelVJAs0Q", 318567U);
                    var Output_34 = n69.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n7.Vector2>.Create(Node_Context: Node_Context_33);
                    state_15.__p_P9jAwtAxEu4LQRelVJAs0Q = Output_34;
                    n1.NodeContext Node_Context_35 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "Pi4wTUvNuTsL3fgH4YPuia", 318585U);
                    var Output_36 = n70.x_int_PUaEI1VIPPBQSz39ANSlWr<n7.Int2>.Create(Node_Context: Node_Context_35);
                    state_15.__p_Pi4wTUvNuTsL3fgH4YPuia = Output_36;
                    n1.NodeContext Node_Context_37 = __GetContext__().CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "SlvVpo2Xdq7MHIxZYWPFLU", 318596U);
                    var Output_38 = n71.xPy_join__int_Cy7ymCbgc9gPxpPuzLgd2z.Create(Node_Context: Node_Context_37);
                    state_15.__p_SlvVpo2Xdq7MHIxZYWPFLU = Output_38;
                }

                var X_39 = __auto_1.X;
                int Thread_Group_Size_40 = 64;
                n73._Operations_.CalcDispatchArgs1D(Count_In: X_39, Thread_Group_Size_In: Thread_Group_Size_40, Thread_Group_Count_Out: out n7.Int3 Thread_Group_Count_41, Thread_Group_Size_Out: out n7.Int3 Thread_Group_Size_42);
                n1.CompilationHelper.WritePin(state_15.__p_KYeMA5uZn0hOqpJ1hRzVTC.Inputs[0], ref Thread_Group_Count_41);
                n1.CompilationHelper.ReadPin(state_15.__p_KYeMA5uZn0hOqpJ1hRzVTC.Outputs[0], out n66.IComputeEffectDispatcher out_43);
                n26.IGraphicsDataProvider[] Initial_Data_44 = n74._Operations_.CreateDefault<n26.IGraphicsDataProvider>();
                int Array_Size_45 = 1;
                int Mip_Levels_46 = 1;
                bool Is_Unordered_Access_47 = true;
                bool Is_Render_Target_48 = false;
                bool Is_Depth_Stencil_49 = false;
                bool Is_Shared_50 = false;
                bool Recreate_51 = false;
                var State_Output_54 = state_15.__p_GtYe1Z7CeAMMSCtO90El9x.Update(Size_In: __auto_1, Initial_Data_In: Initial_Data_44, Array_Size_In: Array_Size_45, Mip_Levels_In: Mip_Levels_46, Format_In: Format_In, Is_Unordered_Access_In: Is_Unordered_Access_47, Is_Render_Target_In: Is_Render_Target_48, Is_Depth_Stencil_In: Is_Depth_Stencil_49, Is_Shared_In: Is_Shared_50, Recreate_In: Recreate_51, Output_Out: out n3.Texture Output_52, Has_Changed_Out: out bool Has_Changed_53);
                bool SetValue_55 = true;
                var Output_56 = state_15.__p_R1uiy3VXVDCPoUE0Kip2yV;
                if (SetValue_55)
                {
                    Output_56 = state_15.__p_R1uiy3VXVDCPoUE0Kip2yV.SetValue(Texture_In: Output_52);
                }

                bool RW_57 = true;
                bool SetRW_58 = true;
                var Output_59 = Output_56;
                if (SetRW_58)
                {
                    Output_59 = Output_56.SetRW(RW_In: RW_57);
                }

                var State_Output_61 = Output_59.Update(Output_Out: out n19.GpuValue<n3.Texture> Output_60);
                var State_Output_63 = state_15.__p_HPPPRzb5hKVOTeWAxUTupN.GetOutput(Output_Out: out n19.GpuValue<n7.Int3> Output_62);
                bool Update_64 = true;
                var Output_65 = state_15.__p_RfNCjVL8BaJNy04Oxt6PdB;
                if (Update_64)
                {
                    Output_65 = state_15.__p_RfNCjVL8BaJNy04Oxt6PdB.Update(Input_In: Output_62);
                }

                var State_Output_67 = Output_65.GetX(Output_Out: out n19.GpuValue<n7.Int2> Output_66);
                bool Update_68 = true;
                var Output_69 = state_15.__p_Pi4wTUvNuTsL3fgH4YPuia;
                if (Update_68)
                {
                    Output_69 = state_15.__p_Pi4wTUvNuTsL3fgH4YPuia.Update(Input_In: Output_66);
                }

                var State_Output_71 = Output_69.GetX(Output_Out: out n19.GpuValue<int> Output_70);
                var State_Output_73 = state_15.__p_SlvVpo2Xdq7MHIxZYWPFLU.Update(x_In: Output_70, y_In: y_9, Output_Out: out n19.GpuValue<n7.Int2> Output_72);
                var State_Output_75 = state_15.__p_DXi2vrlLoBZMJlTN4yBAhT.Update(x_In: Output_66, Output_Out: out n19.GpuValue<n7.Vector2> Output_74);
                var Result_76 = (n7.Vector2)__auto_1;
                n19.GpuValue<n7.Vector2> Input_2_77 = state_15.__monadBuilder_Mj25O8KnFRoOeiVO0LGSd9.Return(Result_76);
                var builder_78 = n5.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX, 2);
                builder_78.Add(Output_74);
                builder_78.Add(Input_2_77);
                var __pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX_79 = builder_78.Commit();
                var State_Output_81 = state_15.__p_UdL9pJF2SsZLt32iQhTrwX.Update(Input_In: __pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX_79, Output_Out: out n19.GpuValue<n7.Vector2> Output_80);
                n19.GpuValue<n3.SamplerState> Sampler_82 = default(n19.GpuValue<n3.SamplerState>);
                n19.GpuValue<float> Level_83 = default(n19.GpuValue<float>);
                n19.GpuValue<n7.Vector4> Default_84 = default(n19.GpuValue<n7.Vector4>);
                var State_Output_86 = state_15.__p_P9jAwtAxEu4LQRelVJAs0Q.Update(Texture_In: Texture_5, Sampler_In: Sampler_82, Texture_Coords_In: Output_80, Level_In: Level_83, Default_In: Default_84, Output_Out: out n19.GpuValue<n7.Vector4> Output_85);
                var State_Output_88 = state_15.__p_E59IFiEv0CtP81ywyh22xx.Update(Texture_In: Output_60, index_In: Output_72, value_In: Output_85, Output_Out: out n19.GpuValue<n75.GpuVoid> Output_87);
                bool Enabled_89 = true;
                var Output_93 = state_15.__p_Tp3Ec8mos1lQIS3hKK8Ey2.Update(Dispatcher_In: out_43, Thread_Group_Size_In: Thread_Group_Size_42, GpuValue_In: Output_87, Enabled_In: Enabled_89, Dispatcher_Out: out n66.VLComputeEffectShader Dispatcher_90, Last_Error_Out: out string Last_Error_91, Shader_Code_Out: out string Shader_Code_92);
                state_15.__p_KYeMA5uZn0hOqpJ1hRzVTC = state_15.__p_KYeMA5uZn0hOqpJ1hRzVTC;
                state_15.__p_GtYe1Z7CeAMMSCtO90El9x = State_Output_54;
                state_15.__p_R1uiy3VXVDCPoUE0Kip2yV = State_Output_61;
                state_15.__p_HPPPRzb5hKVOTeWAxUTupN = State_Output_63;
                state_15.__p_RfNCjVL8BaJNy04Oxt6PdB = State_Output_67;
                state_15.__p_Pi4wTUvNuTsL3fgH4YPuia = State_Output_71;
                state_15.__p_SlvVpo2Xdq7MHIxZYWPFLU = State_Output_73;
                state_15.__p_DXi2vrlLoBZMJlTN4yBAhT = State_Output_75;
                state_15.__pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX = __pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX_79;
                state_15.__p_UdL9pJF2SsZLt32iQhTrwX = State_Output_81;
                state_15.__p_P9jAwtAxEu4LQRelVJAs0Q = State_Output_86;
                state_15.__p_E59IFiEv0CtP81ywyh22xx = State_Output_88;
                state_15.__p_Tp3Ec8mos1lQIS3hKK8Ey2 = Output_93;
                outputs_13 = (Dispatcher_90, Output_52);
                manager_11 = manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10, state_15, outputs_13);
            }
            else
            {
                manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10);
            }

            var(__auto_94, __auto_95) = outputs_13;
            this.__cache_CGxF1IMNe8rPU6zE1Z6xr9 = manager_11;
            this.OutTexture = __auto_95;
            n3.Texture __auto_96 = __auto_95;
            Dispatcher_Out = __auto_94;
            Texture_Out = __auto_96;
            return this;
        }

        public n4.RingBuffer2D_C SetHeight([n5.SerializedDefaultValueAttribute("1", false)] int Height_In)
        {
            int __auto_0 = this.Width;
            this.Height = Height_In;
            int __auto_1 = Height_In;
            var Output_2 = new n7.Int2(x: __auto_0, y: __auto_1);
            this.resolution = Output_2;
            n7.Int2 __auto_3 = Output_2;
            return this;
        }

        public n4.RingBuffer2D_C SetTexture(n3.Texture Texture_In)
        {
            int __auto_0 = this.Height;
            this.InTexture = Texture_In;
            n3.Texture __auto_1 = Texture_In;
            var Width_2 = __auto_1.Width;
            this.Width = Width_2;
            int __auto_3 = Width_2;
            var Output_4 = new n7.Int2(x: __auto_3, y: __auto_0);
            this.resolution = Output_4;
            n7.Int2 __auto_5 = Output_4;
            return this;
        }

        public n4.RingBuffer2D_C UpdateCounter([n5.SerializedDefaultValueAttribute("True", false)] bool Enable_In, out int index_Out)
        {
            int __auto_0 = this.Height;
            int __pad_SO3Zh8VWHeGL71aSAQH0X1_1 = __slot_SO3Zh8VWHeGL71aSAQH0X1;
            var Output_2 = this.__p_TTvvDtxMLYCP9Mgl8MSz5j;
            if (Enable_In)
            {
                Output_2 = this.__p_TTvvDtxMLYCP9Mgl8MSz5j.Count();
            }

            this.__p_TTvvDtxMLYCP9Mgl8MSz5j = Output_2;
            var Output_4 = Output_2.GetValue(Value_Out: out int Value_3);
            this.__p_TTvvDtxMLYCP9Mgl8MSz5j = Output_4;
            n76._Operations_.Max<int, n21.__AdaptiveImplementations__JPmuEharYwiLQs6dOuoEQQ>(Input_In: __auto_0, Input_2_In: __pad_SO3Zh8VWHeGL71aSAQH0X1_1, Output_Out: out int Output_5);
            var Output_6 = Value_3 % Output_5;
            this.index = Output_6;
            int __auto_7 = Output_6;
            float Input_2_8 = (float)Output_5;
            var Result_9 = n77.IntegerConversions.ToFloat32(input: Output_6);
            var Output_10 = (float)Result_9 / Input_2_8;
            this.progress = Output_10;
            float __auto_11 = Output_10;
            index_Out = __auto_7;
            return this;
        }

        public n4.RingBuffer2D_C GetIndex(out int Index_Out)
        {
            int __auto_0 = this.index;
            Index_Out = __auto_0;
            return this;
        }

        public n4.RingBuffer2D_C GetProgress(out float Progress_Out)
        {
            float __auto_0 = this.progress;
            Progress_Out = __auto_0;
            return this;
        }

        public n4.RingBuffer2D_C GetTexture(out n3.Texture Texture_Out)
        {
            n3.Texture __auto_0 = this.OutTexture;
            Texture_Out = __auto_0;
            return this;
        }

        public n4.RingBuffer2D_C __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Width = 0;
            this.Height = 0;
            this.resolution = default(n7.Int2);
            this.index = 0;
            this.progress = 0F;
            this.InTexture = default(n3.Texture);
            this.OutTexture = default(n3.Texture);
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "TTvvDtxMLYCP9Mgl8MSz5j", 318616U);
            var Output_1 = n78.FrameCounter_BTu2lIk3ErHQUOIIjwJYCm.Create(Node_Context: Node_Context_0);
            this.__p_TTvvDtxMLYCP9Mgl8MSz5j = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("JPmuEharYwiLQs6dOuoEQQ", "L4Vn9Kjch9uMPaHwT6dupK", 318686U);
            var Output_3 = n22.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_2);
            this.__p_L4Vn9Kjch9uMPaHwT6dupK = Output_3;
            this.__monadBuilder_RJu07OgFPdwPHGdLZmwmhC = n19.GpuValueMonadicFactory<n3.Texture>.Default.GetMonadBuilder(true);
            this.__p_GbCrtsBSPZ3OGf0DpSTmLN = n79._Operations_.CreateDefault();
            this.__monadBuilder_EogJLjq65PLN8oZ3fhjgGL = n19.GpuValueMonadicFactory<int>.Default.GetMonadBuilder(true);
            this.__cache_CGxF1IMNe8rPU6zE1Z6xr9 = null;
            return this;
        }

        public n4.RingBuffer2D_C __CreateDefault__()
        {
            this.Width = 0;
            this.Height = 0;
            this.resolution = default(n7.Int2);
            this.index = 0;
            this.progress = 0F;
            this.InTexture = default(n3.Texture);
            this.OutTexture = default(n3.Texture);
            this.__p_L4Vn9Kjch9uMPaHwT6dupK = n22.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__monadBuilder_RJu07OgFPdwPHGdLZmwmhC = n19.GpuValueMonadicFactory<n3.Texture>.Default.GetMonadBuilder(true);
            this.__p_GbCrtsBSPZ3OGf0DpSTmLN = n79._Operations_.CreateDefault();
            this.__monadBuilder_EogJLjq65PLN8oZ3fhjgGL = n19.GpuValueMonadicFactory<int>.Default.GetMonadBuilder(true);
            this.__cache_CGxF1IMNe8rPU6zE1Z6xr9 = null;
            this.__p_TTvvDtxMLYCP9Mgl8MSz5j = n78.FrameCounter_BTu2lIk3ErHQUOIIjwJYCm.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_L4Vn9Kjch9uMPaHwT6dupK);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_RJu07OgFPdwPHGdLZmwmhC);
            n1.CompilationHelper.SafeDispose(this.__p_GbCrtsBSPZ3OGf0DpSTmLN);
            n1.CompilationHelper.SafeDispose(this.__monadBuilder_EogJLjq65PLN8oZ3fhjgGL);
            n1.CompilationHelper.SafeDispose(this.__cache_CGxF1IMNe8rPU6zE1Z6xr9);
            n1.CompilationHelper.SafeDispose(this.__p_TTvvDtxMLYCP9Mgl8MSz5j);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 318606U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "PrhhPBIAGfKM6KR2DmU0d6", Name = "__slot_PrhhPBIAGfKM6KR2DmU0d6")]
        public static bool __slot_PrhhPBIAGfKM6KR2DmU0d6 = false;
        [n1.ElementAttribute(TracingId = 318661U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "SO3Zh8VWHeGL71aSAQH0X1", Name = "__slot_SO3Zh8VWHeGL71aSAQH0X1")]
        public static int __slot_SO3Zh8VWHeGL71aSAQH0X1 = 1;
        [n1.ElementAttribute(TracingId = 318428U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Tym4bDI5Ww9MGFEDhTDLxB", Name = "Width")]
        public int Width;
        [n1.ElementAttribute(TracingId = 318431U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "UHH0T8sGT2aP8GusaQaVs4", Name = "Height")]
        public int Height;
        [n1.ElementAttribute(TracingId = 318696U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "HMlSyUI53oILv6t7JVPb02", Name = "resolution")]
        public n7.Int2 resolution;
        [n1.ElementAttribute(TracingId = 318740U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "BxSG57OYiHRM6mWMKQvv9a", Name = "index")]
        public int index;
        [n1.ElementAttribute(TracingId = 318743U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "GSNMkmzIYXkNYgV2jYCLP2", Name = "progress")]
        public float progress;
        [n1.ElementAttribute(TracingId = 318425U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "KQGCH80xTpXLVqvC7T2Jq7", Name = "InTexture")]
        public n3.Texture InTexture;
        [n1.ElementAttribute(TracingId = 318752U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Qz6g3TBkgeyPyedoLS34lT", Name = "OutTexture")]
        public n3.Texture OutTexture;
        [n1.ElementAttribute(TracingId = 318686U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "L4Vn9Kjch9uMPaHwT6dupK", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n22.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_L4Vn9Kjch9uMPaHwT6dupK;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<n3.Texture, n19.GpuValue<n3.Texture>> __monadBuilder_RJu07OgFPdwPHGdLZmwmhC = n19.GpuValueMonadicFactory<n3.Texture>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 318679U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "GbCrtsBSPZ3OGf0DpSTmLN", Name = "This", IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __p_GbCrtsBSPZ3OGf0DpSTmLN;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n1.IMonadBuilder<int, n19.GpuValue<int>> __monadBuilder_EogJLjq65PLN8oZ3fhjgGL = n19.GpuValueMonadicFactory<int>.Default.GetMonadBuilder(true);
        [n1.ElementAttribute(TracingId = 318435U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "CGxF1IMNe8rPU6zE1Z6xr9", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n59.Manager<n2.ValueTuple<n7.Int2, n18.PixelFormat>, n2.ValueTuple<n66.VLComputeEffectShader, n3.Texture>> __cache_CGxF1IMNe8rPU6zE1Z6xr9 = null;
        [n1.ElementAttribute(TracingId = 318616U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "TTvvDtxMLYCP9Mgl8MSz5j", Name = "FrameCounter", IsManaged = true, IsAutoGenerated = true)]
        public n78.FrameCounter_BTu2lIk3ErHQUOIIjwJYCm __p_TTvvDtxMLYCP9Mgl8MSz5j;
        static RingBuffer2D_C()
        {
        }

        public RingBuffer2D_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RingBuffer2D_C(RingBuffer2D_C other): base(other)
        {
            this.Width = other.Width;
            this.Height = other.Height;
            this.resolution = other.resolution;
            this.index = other.index;
            this.progress = other.progress;
            this.InTexture = other.InTexture;
            this.OutTexture = other.OutTexture;
            this.__p_L4Vn9Kjch9uMPaHwT6dupK = other.__p_L4Vn9Kjch9uMPaHwT6dupK;
            this.__monadBuilder_RJu07OgFPdwPHGdLZmwmhC = other.__monadBuilder_RJu07OgFPdwPHGdLZmwmhC;
            this.__p_GbCrtsBSPZ3OGf0DpSTmLN = other.__p_GbCrtsBSPZ3OGf0DpSTmLN;
            this.__monadBuilder_EogJLjq65PLN8oZ3fhjgGL = other.__monadBuilder_EogJLjq65PLN8oZ3fhjgGL;
            this.__cache_CGxF1IMNe8rPU6zE1Z6xr9 = other.__cache_CGxF1IMNe8rPU6zE1Z6xr9;
            this.__p_TTvvDtxMLYCP9Mgl8MSz5j = other.__p_TTvvDtxMLYCP9Mgl8MSz5j;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Width", in Width), n1.CompilationHelper.GetValueOrExisting(values, "Height", in Height), n1.CompilationHelper.GetValueOrExisting(values, "resolution", in resolution), n1.CompilationHelper.GetValueOrExisting(values, "index", in index), n1.CompilationHelper.GetValueOrExisting(values, "progress", in progress), n1.CompilationHelper.GetValueOrExisting(values, "InTexture", in InTexture), n1.CompilationHelper.GetValueOrExisting(values, "OutTexture", in OutTexture), n1.CompilationHelper.GetValueOrExisting(values, "__p_L4Vn9Kjch9uMPaHwT6dupK", in __p_L4Vn9Kjch9uMPaHwT6dupK), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_RJu07OgFPdwPHGdLZmwmhC", in __monadBuilder_RJu07OgFPdwPHGdLZmwmhC), n1.CompilationHelper.GetValueOrExisting(values, "__p_GbCrtsBSPZ3OGf0DpSTmLN", in __p_GbCrtsBSPZ3OGf0DpSTmLN), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_EogJLjq65PLN8oZ3fhjgGL", in __monadBuilder_EogJLjq65PLN8oZ3fhjgGL), n1.CompilationHelper.GetValueOrExisting(values, "__cache_CGxF1IMNe8rPU6zE1Z6xr9", in __cache_CGxF1IMNe8rPU6zE1Z6xr9), n1.CompilationHelper.GetValueOrExisting(values, "__p_TTvvDtxMLYCP9Mgl8MSz5j", in __p_TTvvDtxMLYCP9Mgl8MSz5j));
        }

        internal RingBuffer2D_C __WITH__(int Width, int Height, n7.Int2 resolution, int index, float progress, n3.Texture InTexture, n3.Texture OutTexture, n22.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_L4Vn9Kjch9uMPaHwT6dupK, n1.IMonadBuilder<n3.Texture, n19.GpuValue<n3.Texture>> __monadBuilder_RJu07OgFPdwPHGdLZmwmhC, n2.Object __p_GbCrtsBSPZ3OGf0DpSTmLN, n1.IMonadBuilder<int, n19.GpuValue<int>> __monadBuilder_EogJLjq65PLN8oZ3fhjgGL, n59.Manager<n2.ValueTuple<n7.Int2, n18.PixelFormat>, n2.ValueTuple<n66.VLComputeEffectShader, n3.Texture>> __cache_CGxF1IMNe8rPU6zE1Z6xr9, n78.FrameCounter_BTu2lIk3ErHQUOIIjwJYCm __p_TTvvDtxMLYCP9Mgl8MSz5j)
        {
            n4.RingBuffer2D_C that_0 = this;
            this.Width = Width;
            this.Height = Height;
            this.resolution = resolution;
            this.index = index;
            this.progress = progress;
            this.InTexture = InTexture;
            this.OutTexture = OutTexture;
            this.__p_L4Vn9Kjch9uMPaHwT6dupK = __p_L4Vn9Kjch9uMPaHwT6dupK;
            this.__monadBuilder_RJu07OgFPdwPHGdLZmwmhC = __monadBuilder_RJu07OgFPdwPHGdLZmwmhC;
            this.__p_GbCrtsBSPZ3OGf0DpSTmLN = __p_GbCrtsBSPZ3OGf0DpSTmLN;
            this.__monadBuilder_EogJLjq65PLN8oZ3fhjgGL = __monadBuilder_EogJLjq65PLN8oZ3fhjgGL;
            this.__cache_CGxF1IMNe8rPU6zE1Z6xr9 = __cache_CGxF1IMNe8rPU6zE1Z6xr9;
            this.__p_TTvvDtxMLYCP9Mgl8MSz5j = __p_TTvvDtxMLYCP9Mgl8MSz5j;
            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "CSD8AtCnIceMMVMP7Zd4cY", Name = "__CSD8AtCnIceMMVMP7Zd4cY")]
        [n2.SerializableAttribute]
        public class __CSD8AtCnIceMMVMP7Zd4cY : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Tp3Ec8mos1lQIS3hKK8Ey2);
                n1.CompilationHelper.SafeDispose(this.__p_E59IFiEv0CtP81ywyh22xx);
                n1.CompilationHelper.SafeDispose(this.__p_DXi2vrlLoBZMJlTN4yBAhT);
                n1.CompilationHelper.SafeDispose(this.__p_GtYe1Z7CeAMMSCtO90El9x);
                n1.CompilationHelper.SafeDispose(this.__p_KYeMA5uZn0hOqpJ1hRzVTC);
                n1.CompilationHelper.SafeDispose(this.__p_UdL9pJF2SsZLt32iQhTrwX);
                n1.CompilationHelper.SafeDispose(this.__p_R1uiy3VXVDCPoUE0Kip2yV);
                n1.CompilationHelper.SafeDispose(this.__p_RfNCjVL8BaJNy04Oxt6PdB);
                n1.CompilationHelper.SafeDispose(this.__p_HPPPRzb5hKVOTeWAxUTupN);
                n1.CompilationHelper.SafeDispose(this.__p_P9jAwtAxEu4LQRelVJAs0Q);
                n1.CompilationHelper.SafeDispose(this.__p_Pi4wTUvNuTsL3fgH4YPuia);
                n1.CompilationHelper.SafeDispose(this.__p_SlvVpo2Xdq7MHIxZYWPFLU);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_Mj25O8KnFRoOeiVO0LGSd9);
                return;
            }

            [n1.ElementAttribute(TracingId = 318459U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Tp3Ec8mos1lQIS3hKK8Ey2", Name = "ComputeShaderGraph", IsManaged = true, IsAutoGenerated = true)]
            public n29.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2 __p_Tp3Ec8mos1lQIS3hKK8Ey2;
            [n1.ElementAttribute(TracingId = 318477U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "E59IFiEv0CtP81ywyh22xx", Name = "TextureSet", IsManaged = true, IsAutoGenerated = true)]
            public n67.TextureSet_GTElf8F5BISPYwp53N4yR3<n19.GpuValue<n7.Int2>, n7.Vector4> __p_E59IFiEv0CtP81ywyh22xx;
            [n1.ElementAttribute(TracingId = 318490U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "DXi2vrlLoBZMJlTN4yBAhT", Name = "ToVector2", IsManaged = true, IsAutoGenerated = true)]
            public n64.ToVector2_G7HULoyX6qHQO2XXvbzbNX<n7.Int2> __p_DXi2vrlLoBZMJlTN4yBAhT;
            [n1.ElementAttribute(TracingId = 318500U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "GtYe1Z7CeAMMSCtO90El9x", Name = "ComputeTexture2D", IsManaged = true, IsAutoGenerated = true)]
            public n68.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_GtYe1Z7CeAMMSCtO90El9x;
            [n1.ElementAttribute(TracingId = 318515U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "KYeMA5uZn0hOqpJ1hRzVTC", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
            public n1.IVLNode __p_KYeMA5uZn0hOqpJ1hRzVTC;
            [n1.ElementAttribute(TracingId = 318524U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "UdL9pJF2SsZLt32iQhTrwX", Name = "/", IsManaged = true, IsAutoGenerated = true)]
            public n63.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n7.Vector2> __p_UdL9pJF2SsZLt32iQhTrwX;
            [n1.ElementAttribute(TracingId = 318534U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "R1uiy3VXVDCPoUE0Kip2yV", Name = "TextureIn (Fuse)", IsManaged = true, IsAutoGenerated = true)]
            public n69.TextureIn_Fuse_C __p_R1uiy3VXVDCPoUE0Kip2yV;
            [n1.ElementAttribute(TracingId = 318557U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "RfNCjVL8BaJNy04Oxt6PdB", Name = "xy (int)", IsManaged = true, IsAutoGenerated = true)]
            public n70.xy_int_SItNjydkI3fK9bxXkl1p4y<n7.Int3> __p_RfNCjVL8BaJNy04Oxt6PdB;
            [n1.ElementAttribute(TracingId = 318565U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "HPPPRzb5hKVOTeWAxUTupN", Name = "DispatchThreadId", IsManaged = true, IsAutoGenerated = true)]
            public n72.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_HPPPRzb5hKVOTeWAxUTupN;
            [n1.ElementAttribute(TracingId = 318567U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "P9jAwtAxEu4LQRelVJAs0Q", Name = "SampleTexture (Fuse)", IsManaged = true, IsAutoGenerated = true)]
            public n69.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n7.Vector2> __p_P9jAwtAxEu4LQRelVJAs0Q;
            [n1.ElementAttribute(TracingId = 318585U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Pi4wTUvNuTsL3fgH4YPuia", Name = "x (int)", IsManaged = true, IsAutoGenerated = true)]
            public n70.x_int_PUaEI1VIPPBQSz39ANSlWr<n7.Int2> __p_Pi4wTUvNuTsL3fgH4YPuia;
            [n1.ElementAttribute(TracingId = 318596U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "SlvVpo2Xdq7MHIxZYWPFLU", Name = "x+y (join)(int)", IsManaged = true, IsAutoGenerated = true)]
            public n71.xPy_join__int_Cy7ymCbgc9gPxpPuzLgd2z __p_SlvVpo2Xdq7MHIxZYWPFLU;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<n7.Vector2, n19.GpuValue<n7.Vector2>> __monadBuilder_Mj25O8KnFRoOeiVO0LGSd9 = n19.GpuValueMonadicFactory<n7.Vector2>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n20.Spread<n19.GpuValue<n7.Vector2>> __pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX = default(n20.Spread<n19.GpuValue<n7.Vector2>>);
            public __CSD8AtCnIceMMVMP7Zd4cY(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CSD8AtCnIceMMVMP7Zd4cY(__CSD8AtCnIceMMVMP7Zd4cY other): base(other)
            {
                this.__p_Tp3Ec8mos1lQIS3hKK8Ey2 = other.__p_Tp3Ec8mos1lQIS3hKK8Ey2;
                this.__p_E59IFiEv0CtP81ywyh22xx = other.__p_E59IFiEv0CtP81ywyh22xx;
                this.__p_DXi2vrlLoBZMJlTN4yBAhT = other.__p_DXi2vrlLoBZMJlTN4yBAhT;
                this.__p_GtYe1Z7CeAMMSCtO90El9x = other.__p_GtYe1Z7CeAMMSCtO90El9x;
                this.__p_KYeMA5uZn0hOqpJ1hRzVTC = other.__p_KYeMA5uZn0hOqpJ1hRzVTC;
                this.__p_UdL9pJF2SsZLt32iQhTrwX = other.__p_UdL9pJF2SsZLt32iQhTrwX;
                this.__p_R1uiy3VXVDCPoUE0Kip2yV = other.__p_R1uiy3VXVDCPoUE0Kip2yV;
                this.__p_RfNCjVL8BaJNy04Oxt6PdB = other.__p_RfNCjVL8BaJNy04Oxt6PdB;
                this.__p_HPPPRzb5hKVOTeWAxUTupN = other.__p_HPPPRzb5hKVOTeWAxUTupN;
                this.__p_P9jAwtAxEu4LQRelVJAs0Q = other.__p_P9jAwtAxEu4LQRelVJAs0Q;
                this.__p_Pi4wTUvNuTsL3fgH4YPuia = other.__p_Pi4wTUvNuTsL3fgH4YPuia;
                this.__p_SlvVpo2Xdq7MHIxZYWPFLU = other.__p_SlvVpo2Xdq7MHIxZYWPFLU;
                this.__monadBuilder_Mj25O8KnFRoOeiVO0LGSd9 = other.__monadBuilder_Mj25O8KnFRoOeiVO0LGSd9;
                this.__pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX = other.__pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Tp3Ec8mos1lQIS3hKK8Ey2", in __p_Tp3Ec8mos1lQIS3hKK8Ey2), n1.CompilationHelper.GetValueOrExisting(values, "__p_E59IFiEv0CtP81ywyh22xx", in __p_E59IFiEv0CtP81ywyh22xx), n1.CompilationHelper.GetValueOrExisting(values, "__p_DXi2vrlLoBZMJlTN4yBAhT", in __p_DXi2vrlLoBZMJlTN4yBAhT), n1.CompilationHelper.GetValueOrExisting(values, "__p_GtYe1Z7CeAMMSCtO90El9x", in __p_GtYe1Z7CeAMMSCtO90El9x), n1.CompilationHelper.GetValueOrExisting(values, "__p_KYeMA5uZn0hOqpJ1hRzVTC", in __p_KYeMA5uZn0hOqpJ1hRzVTC), n1.CompilationHelper.GetValueOrExisting(values, "__p_UdL9pJF2SsZLt32iQhTrwX", in __p_UdL9pJF2SsZLt32iQhTrwX), n1.CompilationHelper.GetValueOrExisting(values, "__p_R1uiy3VXVDCPoUE0Kip2yV", in __p_R1uiy3VXVDCPoUE0Kip2yV), n1.CompilationHelper.GetValueOrExisting(values, "__p_RfNCjVL8BaJNy04Oxt6PdB", in __p_RfNCjVL8BaJNy04Oxt6PdB), n1.CompilationHelper.GetValueOrExisting(values, "__p_HPPPRzb5hKVOTeWAxUTupN", in __p_HPPPRzb5hKVOTeWAxUTupN), n1.CompilationHelper.GetValueOrExisting(values, "__p_P9jAwtAxEu4LQRelVJAs0Q", in __p_P9jAwtAxEu4LQRelVJAs0Q), n1.CompilationHelper.GetValueOrExisting(values, "__p_Pi4wTUvNuTsL3fgH4YPuia", in __p_Pi4wTUvNuTsL3fgH4YPuia), n1.CompilationHelper.GetValueOrExisting(values, "__p_SlvVpo2Xdq7MHIxZYWPFLU", in __p_SlvVpo2Xdq7MHIxZYWPFLU), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_Mj25O8KnFRoOeiVO0LGSd9", in __monadBuilder_Mj25O8KnFRoOeiVO0LGSd9), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX", in __pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX));
            }

            internal __CSD8AtCnIceMMVMP7Zd4cY __WITH__(n29.ComputeShaderGraph_EVCRJXH2vciNFpVLLt6pR2 __p_Tp3Ec8mos1lQIS3hKK8Ey2, n67.TextureSet_GTElf8F5BISPYwp53N4yR3<n19.GpuValue<n7.Int2>, n7.Vector4> __p_E59IFiEv0CtP81ywyh22xx, n64.ToVector2_G7HULoyX6qHQO2XXvbzbNX<n7.Int2> __p_DXi2vrlLoBZMJlTN4yBAhT, n68.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_GtYe1Z7CeAMMSCtO90El9x, n1.IVLNode __p_KYeMA5uZn0hOqpJ1hRzVTC, n63.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n7.Vector2> __p_UdL9pJF2SsZLt32iQhTrwX, n69.TextureIn_Fuse_C __p_R1uiy3VXVDCPoUE0Kip2yV, n70.xy_int_SItNjydkI3fK9bxXkl1p4y<n7.Int3> __p_RfNCjVL8BaJNy04Oxt6PdB, n72.DispatchThreadId_M4aoTu19KsNQCFWcm0NAf5 __p_HPPPRzb5hKVOTeWAxUTupN, n69.SampleTexture_Fuse_I0GFhZOLyu2LhLrIDhp86J<n7.Vector2> __p_P9jAwtAxEu4LQRelVJAs0Q, n70.x_int_PUaEI1VIPPBQSz39ANSlWr<n7.Int2> __p_Pi4wTUvNuTsL3fgH4YPuia, n71.xPy_join__int_Cy7ymCbgc9gPxpPuzLgd2z __p_SlvVpo2Xdq7MHIxZYWPFLU, n1.IMonadBuilder<n7.Vector2, n19.GpuValue<n7.Vector2>> __monadBuilder_Mj25O8KnFRoOeiVO0LGSd9, n20.Spread<n19.GpuValue<n7.Vector2>> __pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX)
            {
                __CSD8AtCnIceMMVMP7Zd4cY that_0 = this;
                this.__p_Tp3Ec8mos1lQIS3hKK8Ey2 = __p_Tp3Ec8mos1lQIS3hKK8Ey2;
                this.__p_E59IFiEv0CtP81ywyh22xx = __p_E59IFiEv0CtP81ywyh22xx;
                this.__p_DXi2vrlLoBZMJlTN4yBAhT = __p_DXi2vrlLoBZMJlTN4yBAhT;
                this.__p_GtYe1Z7CeAMMSCtO90El9x = __p_GtYe1Z7CeAMMSCtO90El9x;
                this.__p_KYeMA5uZn0hOqpJ1hRzVTC = __p_KYeMA5uZn0hOqpJ1hRzVTC;
                this.__p_UdL9pJF2SsZLt32iQhTrwX = __p_UdL9pJF2SsZLt32iQhTrwX;
                this.__p_R1uiy3VXVDCPoUE0Kip2yV = __p_R1uiy3VXVDCPoUE0Kip2yV;
                this.__p_RfNCjVL8BaJNy04Oxt6PdB = __p_RfNCjVL8BaJNy04Oxt6PdB;
                this.__p_HPPPRzb5hKVOTeWAxUTupN = __p_HPPPRzb5hKVOTeWAxUTupN;
                this.__p_P9jAwtAxEu4LQRelVJAs0Q = __p_P9jAwtAxEu4LQRelVJAs0Q;
                this.__p_Pi4wTUvNuTsL3fgH4YPuia = __p_Pi4wTUvNuTsL3fgH4YPuia;
                this.__p_SlvVpo2Xdq7MHIxZYWPFLU = __p_SlvVpo2Xdq7MHIxZYWPFLU;
                this.__monadBuilder_Mj25O8KnFRoOeiVO0LGSd9 = __monadBuilder_Mj25O8KnFRoOeiVO0LGSd9;
                this.__pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX = __pin_group_Input_In_UdL9pJF2SsZLt32iQhTrwX;
                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 318932U, DocumentId = "JPmuEharYwiLQs6dOuoEQQ", PersistentId = "Irt0YFriJdfL2EJnYYiPxv", Name = "Fuse_Common_DrawApplication_Irt0YFriJdfL2EJnYYiPxv")]
    [n2.SerializableAttribute]
    public class Fuse_Common_DrawApplication_Irt0YFriJdfL2EJnYYiPxv : n1.VLObject, n2.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.Fuse_Common_DrawApplication_Irt0YFriJdfL2EJnYYiPxv Create(n1.NodeContext Node_Context)
        {
            var instance = new Fuse_Common_DrawApplication_Irt0YFriJdfL2EJnYYiPxv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.Fuse_Common_DrawApplication_Irt0YFriJdfL2EJnYYiPxv CreateDefault()
        {
            var instance = new Fuse_Common_DrawApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.Fuse_Common_DrawApplication_Irt0YFriJdfL2EJnYYiPxv Update()
        {
            return this;
        }

        public n4.Fuse_Common_DrawApplication_Irt0YFriJdfL2EJnYYiPxv __Create__(n1.NodeContext Node_Context)
        {
            n11.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n4.Fuse_Common_DrawApplication_Irt0YFriJdfL2EJnYYiPxv __CreateDefault__()
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

        public Fuse_Common_DrawApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Fuse_Common_DrawApplication_Irt0YFriJdfL2EJnYYiPxv(Fuse_Common_DrawApplication_Irt0YFriJdfL2EJnYYiPxv other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal Fuse_Common_DrawApplication_Irt0YFriJdfL2EJnYYiPxv __WITH__()
        {
            return this;
        }
    }
}

namespace _Fuse_Common_Draw_
{
    public struct __AdaptiveImplementations__JPmuEharYwiLQs6dOuoEQQ : n82.IAdaptiveCreateDefault<n19.GpuValue<n7.Vector4>>, n82.IAdaptiveCreateDefault<n16.Entity>, n83.IAdaptiveOperatorGreater<int>
    {
        public void CreateDefault(out n19.GpuValue<n7.Vector4> Output_Out)
        {
            n81._Operations_.CreateDefault_Generic<n19.GpuValue<n7.Vector4>>(Output_Out: out n19.GpuValue<n7.Vector4> Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n16.Entity Output_Out)
        {
            n81._Operations_.CreateDefault_Generic<n16.Entity>(Output_Out: out n16.Entity Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorGreater(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In > Input_2_In;
            Result_Out = Result_0;
            return;
        }
    }
}