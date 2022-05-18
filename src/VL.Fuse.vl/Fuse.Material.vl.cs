extern alias e22;
extern alias e31;
extern alias e26;
extern alias e3;
extern alias e2;
extern alias e71;
extern alias e29;
extern alias e4;

using n29 = _Fuse_Material_;
using n34 = e26::Stride.Graphics;
using n18 = e2::VL.Lib.Collections;
using n20 = e3::VL.Lib.Primitive.CacheRegion;
using n9 = e31::VL.Stride.Rendering.Materials;
using n30 = _CoreLibBasics_.Control;
using n11 = e71::Fuse;
using n26 = _Fuse_Core_.Fuse.Core.DrawShader;
using n6 = e31::VL.Stride.Shaders.ShaderFX;
using n27 = _Fuse_Core_Calculus_.Fuse.Core.Calculus.Differentiation;
using n7 = e71::Fuse.ShaderFX;
using n23 = _Fuse_Core_.Fuse.Core.Function;
using n13 = global::System.Collections.Generic;
using n17 = _CoreLibBasics_._2D.Vector2;
using n25 = _Fuse_Core_.Fuse.Core.Split;
using n32 = _Fuse_Core_.Fuse.Core.Texture;
using n38 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n21 = _Fuse_Core_Math_.Fuse.Core.Math;
using n28 = _Fuse_Core_.Fuse.Core.Join;
using n15 = _Fuse_Core_.Fuse.Core.StrideIntegration;
using n1 = e2::VL.Core;
using n12 = e22::Stride.Graphics;
using n2 = global::System;
using n5 = e4::Stride.Core.Mathematics;
using n36 = _Fuse_Core_.Fuse.Core.Control;
using n16 = e3::VL.Lib.Primitive.Object;
using n24 = _Fuse_Core_.Fuse.Core.Swizzle;
using n4 = e2::VL.Core.CompilerServices;
using n3 = _Fuse_Material_.Fuse.Material;
using n31 = _Fuse_Core_.Fuse.Core.Implementation;
using n10 = e29::Stride.Rendering;
using n33 = _Fuse_Core_.Fuse.Core.Util;
using n35 = _VL_Collections_.Collections.Sequence;
using n14 = global::System.Runtime.CompilerServices;
using n22 = _Fuse_Core_.Fuse.Core.Conversion;
using n19 = _VL_Collections_.Collections.Spread;
using n37 = _CoreLibBasics_.Primitive.Advanced;
using n8 = e29::Stride.Rendering.Materials;

namespace _Fuse_Material_.Fuse.Material
{
    [n1.ElementAttribute(TracingId = 318956U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "RzYozbDE3MaM0HuWmWJRzh", Name = "ColorMaterial_RzYozbDE3MaM0HuWmWJRzh")]
    [n2.SerializableAttribute]
    public class ColorMaterial_RzYozbDE3MaM0HuWmWJRzh : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh Create(n1.NodeContext Node_Context)
        {
            var instance = new ColorMaterial_RzYozbDE3MaM0HuWmWJRzh(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh CreateDefault()
        {
            var instance = new ColorMaterial_RzYozbDE3MaM0HuWmWJRzh(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh Update([n4.SerializedDefaultValueAttribute("1, 1, 1, 1", false)] n11.GpuValue<n5.Vector4> Color_In, out n10.Material Output_Out)
        {
            bool __pad_JD0ODRz02uhM5Q4BSFRHmf_0 = __slot_JD0ODRz02uhM5Q4BSFRHmf;
            var State_Output_4 = this.__p_OmunCoMhotPPdmfGoknBX5.Update(GpuValue_In: Color_In, Output_Out: out n6.SetVar<n5.Vector4> Output_1, Original_Shader_Source_Out: out n7.ToShaderFX<n5.Vector4> Original_Shader_Source_2, Shader_Code_Out: out string Shader_Code_3);
            n1.CompilationHelper.WritePin(this.__p_EsmsWEjHsGlMX1vCvuFDAA.Inputs[0], ref Output_1);
            n1.CompilationHelper.WritePin(this.__p_EsmsWEjHsGlMX1vCvuFDAA.Inputs[2], ref __pad_JD0ODRz02uhM5Q4BSFRHmf_0);
            n1.CompilationHelper.ReadPin(this.__p_EsmsWEjHsGlMX1vCvuFDAA.Outputs[0], out n8.MaterialEmissiveMapFeature out_5);
            n8.IMaterialEmissiveFeature Emissive_6 = (n8.IMaterialEmissiveFeature)out_5;
            n1.CompilationHelper.WritePin(this.__p_MxP0GOkaAAXOZSeT8kt2yD.Inputs[4], ref Emissive_6);
            n1.CompilationHelper.ReadPin(this.__p_MxP0GOkaAAXOZSeT8kt2yD.Outputs[0], out n9.ShadingAttributes out_7);
            n1.CompilationHelper.WritePin(this.__p_OEGsqZ62GL1MX2emoYY9iq.Inputs[1], ref out_7);
            n1.CompilationHelper.ReadPin(this.__p_AN04SWxbQQrMV0oPE7OY3q.Outputs[0], out n9.MiscAttributes out_8);
            n1.CompilationHelper.WritePin(this.__p_OEGsqZ62GL1MX2emoYY9iq.Inputs[2], ref out_8);
            n1.CompilationHelper.ReadPin(this.__p_OEGsqZ62GL1MX2emoYY9iq.Outputs[0], out n10.Material out_9);
            Output_Out = out_9;
            n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = State_Output_4 != this.__p_OmunCoMhotPPdmfGoknBX5 || this.__p_EsmsWEjHsGlMX1vCvuFDAA != this.__p_EsmsWEjHsGlMX1vCvuFDAA || this.__p_MxP0GOkaAAXOZSeT8kt2yD != this.__p_MxP0GOkaAAXOZSeT8kt2yD || this.__p_OEGsqZ62GL1MX2emoYY9iq != this.__p_OEGsqZ62GL1MX2emoYY9iq || this.__p_AN04SWxbQQrMV0oPE7OY3q != this.__p_AN04SWxbQQrMV0oPE7OY3q ? new ColorMaterial_RzYozbDE3MaM0HuWmWJRzh(this)
                {__p_OmunCoMhotPPdmfGoknBX5 = State_Output_4, __p_EsmsWEjHsGlMX1vCvuFDAA = this.__p_EsmsWEjHsGlMX1vCvuFDAA, __p_MxP0GOkaAAXOZSeT8kt2yD = this.__p_MxP0GOkaAAXOZSeT8kt2yD, __p_OEGsqZ62GL1MX2emoYY9iq = this.__p_OEGsqZ62GL1MX2emoYY9iq, __p_AN04SWxbQQrMV0oPE7OY3q = this.__p_AN04SWxbQQrMV0oPE7OY3q} : that_10;
            else
            {
                this.__p_OmunCoMhotPPdmfGoknBX5 = State_Output_4;
                this.__p_EsmsWEjHsGlMX1vCvuFDAA = this.__p_EsmsWEjHsGlMX1vCvuFDAA;
                this.__p_MxP0GOkaAAXOZSeT8kt2yD = this.__p_MxP0GOkaAAXOZSeT8kt2yD;
                this.__p_OEGsqZ62GL1MX2emoYY9iq = this.__p_OEGsqZ62GL1MX2emoYY9iq;
                this.__p_AN04SWxbQQrMV0oPE7OY3q = this.__p_AN04SWxbQQrMV0oPE7OY3q;
            }

            return that_10;
        }

        public n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh SetTransparency(n8.IMaterialTransparencyFeature Transparency_In)
        {
            n1.CompilationHelper.WritePin(this.__p_AN04SWxbQQrMV0oPE7OY3q.Inputs[1], ref Transparency_In);
            n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_AN04SWxbQQrMV0oPE7OY3q != this.__p_AN04SWxbQQrMV0oPE7OY3q ? new ColorMaterial_RzYozbDE3MaM0HuWmWJRzh(this)
                {__p_AN04SWxbQQrMV0oPE7OY3q = this.__p_AN04SWxbQQrMV0oPE7OY3q} : that_0;
            else
            {
                this.__p_AN04SWxbQQrMV0oPE7OY3q = this.__p_AN04SWxbQQrMV0oPE7OY3q;
            }

            return that_0;
        }

        public n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh SetCullMode([n4.SerializedDefaultValueAttribute("Back", false)] n12.CullMode Cull_Mode_In)
        {
            n1.CompilationHelper.WritePin(this.__p_AN04SWxbQQrMV0oPE7OY3q.Inputs[3], ref Cull_Mode_In);
            n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_AN04SWxbQQrMV0oPE7OY3q != this.__p_AN04SWxbQQrMV0oPE7OY3q ? new ColorMaterial_RzYozbDE3MaM0HuWmWJRzh(this)
                {__p_AN04SWxbQQrMV0oPE7OY3q = this.__p_AN04SWxbQQrMV0oPE7OY3q} : that_0;
            else
            {
                this.__p_AN04SWxbQQrMV0oPE7OY3q = this.__p_AN04SWxbQQrMV0oPE7OY3q;
            }

            return that_0;
        }

        public n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh SetLayers(n13.IReadOnlyList<n8.MaterialBlendLayer> Layers_In)
        {
            n1.CompilationHelper.WritePin(this.__p_OEGsqZ62GL1MX2emoYY9iq.Inputs[3], ref Layers_In);
            n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_OEGsqZ62GL1MX2emoYY9iq != this.__p_OEGsqZ62GL1MX2emoYY9iq ? new ColorMaterial_RzYozbDE3MaM0HuWmWJRzh(this)
                {__p_OEGsqZ62GL1MX2emoYY9iq = this.__p_OEGsqZ62GL1MX2emoYY9iq} : that_0;
            else
            {
                this.__p_OEGsqZ62GL1MX2emoYY9iq = this.__p_OEGsqZ62GL1MX2emoYY9iq;
            }

            return that_0;
        }

        public n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "ShadingAttributes", "Stride.Advanced.Materials");
            var node_1 = n1.CompilationHelper.CreateNodeById(Node_Context, "MiscAttributes", "Stride.Advanced.Materials");
            var node_2 = n1.CompilationHelper.CreateNodeById(Node_Context, "Material", "Stride.Advanced.Materials");
            var node_3 = n1.CompilationHelper.CreateNodeById(Node_Context, "Emissive", "Stride.Materials.ShadingAttributes");
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "OmunCoMhotPPdmfGoknBX5", 319013U);
            var Output_5 = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4>.Create(Node_Context: Node_Context_4);
            n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh that_6 = this;
            this.__p_MxP0GOkaAAXOZSeT8kt2yD = node_0;
            this.__p_AN04SWxbQQrMV0oPE7OY3q = node_1;
            this.__p_OEGsqZ62GL1MX2emoYY9iq = node_2;
            this.__p_EsmsWEjHsGlMX1vCvuFDAA = node_3;
            this.__p_OmunCoMhotPPdmfGoknBX5 = Output_5;
            return that_6;
        }

        public n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh __CreateDefault__()
        {
            n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh that_0 = this;
            this.__p_OmunCoMhotPPdmfGoknBX5 = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4>.CreateDefault();
            this.__p_EsmsWEjHsGlMX1vCvuFDAA = default(n1.IVLNode);
            this.__p_MxP0GOkaAAXOZSeT8kt2yD = default(n1.IVLNode);
            this.__p_OEGsqZ62GL1MX2emoYY9iq = default(n1.IVLNode);
            this.__p_AN04SWxbQQrMV0oPE7OY3q = default(n1.IVLNode);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_OmunCoMhotPPdmfGoknBX5);
            n1.CompilationHelper.SafeDispose(this.__p_EsmsWEjHsGlMX1vCvuFDAA);
            n1.CompilationHelper.SafeDispose(this.__p_MxP0GOkaAAXOZSeT8kt2yD);
            n1.CompilationHelper.SafeDispose(this.__p_OEGsqZ62GL1MX2emoYY9iq);
            n1.CompilationHelper.SafeDispose(this.__p_AN04SWxbQQrMV0oPE7OY3q);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 319010U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "JD0ODRz02uhM5Q4BSFRHmf", Name = "__slot_JD0ODRz02uhM5Q4BSFRHmf")]
        public static bool __slot_JD0ODRz02uhM5Q4BSFRHmf = true;
        [n1.ElementAttribute(TracingId = 319013U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "OmunCoMhotPPdmfGoknBX5", Name = "ToShaderFX", IsManaged = true, IsAutoGenerated = true)]
        public n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4> __p_OmunCoMhotPPdmfGoknBX5;
        [n1.ElementAttribute(TracingId = 319001U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "EsmsWEjHsGlMX1vCvuFDAA", Name = "Emissive", IsManaged = true, IsAutoGenerated = true, NodeName = "Emissive", NodeCategory = "Stride.Materials.ShadingAttributes")]
        public n1.IVLNode __p_EsmsWEjHsGlMX1vCvuFDAA;
        [n1.ElementAttribute(TracingId = 318962U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "MxP0GOkaAAXOZSeT8kt2yD", Name = "ShadingAttributes", IsManaged = true, IsAutoGenerated = true, NodeName = "ShadingAttributes", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_MxP0GOkaAAXOZSeT8kt2yD;
        [n1.ElementAttribute(TracingId = 318989U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "OEGsqZ62GL1MX2emoYY9iq", Name = "Material", IsManaged = true, IsAutoGenerated = true, NodeName = "Material", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_OEGsqZ62GL1MX2emoYY9iq;
        [n1.ElementAttribute(TracingId = 318978U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "AN04SWxbQQrMV0oPE7OY3q", Name = "MiscAttributes", IsManaged = true, IsAutoGenerated = true, NodeName = "MiscAttributes", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_AN04SWxbQQrMV0oPE7OY3q;
        static ColorMaterial_RzYozbDE3MaM0HuWmWJRzh()
        {
        }

        public ColorMaterial_RzYozbDE3MaM0HuWmWJRzh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ColorMaterial_RzYozbDE3MaM0HuWmWJRzh(ColorMaterial_RzYozbDE3MaM0HuWmWJRzh other): base(other)
        {
            this.__p_OmunCoMhotPPdmfGoknBX5 = other.__p_OmunCoMhotPPdmfGoknBX5;
            this.__p_EsmsWEjHsGlMX1vCvuFDAA = other.__p_EsmsWEjHsGlMX1vCvuFDAA;
            this.__p_MxP0GOkaAAXOZSeT8kt2yD = other.__p_MxP0GOkaAAXOZSeT8kt2yD;
            this.__p_OEGsqZ62GL1MX2emoYY9iq = other.__p_OEGsqZ62GL1MX2emoYY9iq;
            this.__p_AN04SWxbQQrMV0oPE7OY3q = other.__p_AN04SWxbQQrMV0oPE7OY3q;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_OmunCoMhotPPdmfGoknBX5", in __p_OmunCoMhotPPdmfGoknBX5), n1.CompilationHelper.GetValueOrExisting(values, "__p_EsmsWEjHsGlMX1vCvuFDAA", in __p_EsmsWEjHsGlMX1vCvuFDAA), n1.CompilationHelper.GetValueOrExisting(values, "__p_MxP0GOkaAAXOZSeT8kt2yD", in __p_MxP0GOkaAAXOZSeT8kt2yD), n1.CompilationHelper.GetValueOrExisting(values, "__p_OEGsqZ62GL1MX2emoYY9iq", in __p_OEGsqZ62GL1MX2emoYY9iq), n1.CompilationHelper.GetValueOrExisting(values, "__p_AN04SWxbQQrMV0oPE7OY3q", in __p_AN04SWxbQQrMV0oPE7OY3q));
        }

        internal ColorMaterial_RzYozbDE3MaM0HuWmWJRzh __WITH__(n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4> __p_OmunCoMhotPPdmfGoknBX5, n1.IVLNode __p_EsmsWEjHsGlMX1vCvuFDAA, n1.IVLNode __p_MxP0GOkaAAXOZSeT8kt2yD, n1.IVLNode __p_OEGsqZ62GL1MX2emoYY9iq, n1.IVLNode __p_AN04SWxbQQrMV0oPE7OY3q)
        {
            n3.ColorMaterial_RzYozbDE3MaM0HuWmWJRzh that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_OmunCoMhotPPdmfGoknBX5 != this.__p_OmunCoMhotPPdmfGoknBX5 || __p_EsmsWEjHsGlMX1vCvuFDAA != this.__p_EsmsWEjHsGlMX1vCvuFDAA || __p_MxP0GOkaAAXOZSeT8kt2yD != this.__p_MxP0GOkaAAXOZSeT8kt2yD || __p_OEGsqZ62GL1MX2emoYY9iq != this.__p_OEGsqZ62GL1MX2emoYY9iq || __p_AN04SWxbQQrMV0oPE7OY3q != this.__p_AN04SWxbQQrMV0oPE7OY3q ? new ColorMaterial_RzYozbDE3MaM0HuWmWJRzh(this)
                {__p_OmunCoMhotPPdmfGoknBX5 = __p_OmunCoMhotPPdmfGoknBX5, __p_EsmsWEjHsGlMX1vCvuFDAA = __p_EsmsWEjHsGlMX1vCvuFDAA, __p_MxP0GOkaAAXOZSeT8kt2yD = __p_MxP0GOkaAAXOZSeT8kt2yD, __p_OEGsqZ62GL1MX2emoYY9iq = __p_OEGsqZ62GL1MX2emoYY9iq, __p_AN04SWxbQQrMV0oPE7OY3q = __p_AN04SWxbQQrMV0oPE7OY3q} : that_0;
            else
            {
                this.__p_OmunCoMhotPPdmfGoknBX5 = __p_OmunCoMhotPPdmfGoknBX5;
                this.__p_EsmsWEjHsGlMX1vCvuFDAA = __p_EsmsWEjHsGlMX1vCvuFDAA;
                this.__p_MxP0GOkaAAXOZSeT8kt2yD = __p_MxP0GOkaAAXOZSeT8kt2yD;
                this.__p_OEGsqZ62GL1MX2emoYY9iq = __p_OEGsqZ62GL1MX2emoYY9iq;
                this.__p_AN04SWxbQQrMV0oPE7OY3q = __p_AN04SWxbQQrMV0oPE7OY3q;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 319077U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "PM7i6MhpFWVLqVVV4ZUj60", Name = "HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60")]
    [n2.SerializableAttribute]
    public class HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60 Create(n1.NodeContext Node_Context)
        {
            var instance = new HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60 CreateDefault()
        {
            var instance = new HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60 Update(n12.Texture Input_In, [n4.SerializedDefaultValueAttribute("1", false)] float Radius_In, [n4.SerializedDefaultValueAttribute("1", false)] float Depth_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n12.Texture Output__Out)
        {
            n1.CompilationHelper.WritePin(this.__p_LxhCPGZDVe8MBML1x6aMr1.Inputs[0], ref Input_In);
            n16.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            n5.Vector2 __auto_2;
            if (Result_0)
            {
                var View_Width_4 = Input_In.ViewWidth;
                float X_5 = (float)View_Width_4;
                var View_Height_6 = Input_In.ViewHeight;
                float Y_7 = (float)View_Height_6;
                var Output_8 = new n5.Vector2(x: X_5, y: Y_7);
                __auto_2 = Output_8;
            }
            else
            {
                __auto_2 = n17._Operations_.CreateDefault();
            }

            n1.CompilationHelper.WritePin(this.__p_LxhCPGZDVe8MBML1x6aMr1.Inputs[2], ref __auto_2);
            n1.CompilationHelper.WritePin(this.__p_LxhCPGZDVe8MBML1x6aMr1.Inputs[3], ref Radius_In);
            n1.CompilationHelper.WritePin(this.__p_LxhCPGZDVe8MBML1x6aMr1.Inputs[4], ref Depth_In);
            n1.CompilationHelper.WritePin(this.__p_LxhCPGZDVe8MBML1x6aMr1.Inputs[9], ref Enabled_In);
            n1.CompilationHelper.ReadPin(this.__p_LxhCPGZDVe8MBML1x6aMr1.Outputs[0], out n12.Texture out_9);
            n1.CompilationHelper.WritePin(this.__p_EcO5ea1pLFfQLVAFhgTv1t.Inputs[0], ref out_9);
            n1.CompilationHelper.ReadPin(this.__p_EcO5ea1pLFfQLVAFhgTv1t.Outputs[0], out n12.Texture out_10);
            Output__Out = out_10;
            n3.HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60 that_11 = this;
            if (this.__GetContext__().IsImmutable)
                that_11 = this.__p_LxhCPGZDVe8MBML1x6aMr1 != this.__p_LxhCPGZDVe8MBML1x6aMr1 || this.__p_EcO5ea1pLFfQLVAFhgTv1t != this.__p_EcO5ea1pLFfQLVAFhgTv1t ? new HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60(this)
                {__p_LxhCPGZDVe8MBML1x6aMr1 = this.__p_LxhCPGZDVe8MBML1x6aMr1, __p_EcO5ea1pLFfQLVAFhgTv1t = this.__p_EcO5ea1pLFfQLVAFhgTv1t} : that_11;
            else
            {
                this.__p_LxhCPGZDVe8MBML1x6aMr1 = this.__p_LxhCPGZDVe8MBML1x6aMr1;
                this.__p_EcO5ea1pLFfQLVAFhgTv1t = this.__p_EcO5ea1pLFfQLVAFhgTv1t;
            }

            return that_11;
        }

        public n3.HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60 __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "BumpToNormal", "Stride.Textures");
            var node_1 = n1.CompilationHelper.CreateNodeById(Node_Context, "MipMap", "Stride.Textures.Experimental.Utils");
            n3.HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60 that_2 = this;
            this.__p_LxhCPGZDVe8MBML1x6aMr1 = node_0;
            this.__p_EcO5ea1pLFfQLVAFhgTv1t = node_1;
            return that_2;
        }

        public n3.HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60 __CreateDefault__()
        {
            n3.HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60 that_0 = this;
            this.__p_LxhCPGZDVe8MBML1x6aMr1 = default(n1.IVLNode);
            this.__p_EcO5ea1pLFfQLVAFhgTv1t = default(n1.IVLNode);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_LxhCPGZDVe8MBML1x6aMr1);
            n1.CompilationHelper.SafeDispose(this.__p_EcO5ea1pLFfQLVAFhgTv1t);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 319080U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "LxhCPGZDVe8MBML1x6aMr1", Name = "BumpToNormal", IsManaged = true, IsAutoGenerated = true, NodeName = "BumpToNormal", NodeCategory = "Stride.Textures")]
        public n1.IVLNode __p_LxhCPGZDVe8MBML1x6aMr1;
        [n1.ElementAttribute(TracingId = 319097U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "EcO5ea1pLFfQLVAFhgTv1t", Name = "MipMap", IsManaged = true, IsAutoGenerated = true, NodeName = "MipMap", NodeCategory = "Stride.Textures.Experimental.Utils")]
        public n1.IVLNode __p_EcO5ea1pLFfQLVAFhgTv1t;
        public HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60(HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60 other): base(other)
        {
            this.__p_LxhCPGZDVe8MBML1x6aMr1 = other.__p_LxhCPGZDVe8MBML1x6aMr1;
            this.__p_EcO5ea1pLFfQLVAFhgTv1t = other.__p_EcO5ea1pLFfQLVAFhgTv1t;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LxhCPGZDVe8MBML1x6aMr1", in __p_LxhCPGZDVe8MBML1x6aMr1), n1.CompilationHelper.GetValueOrExisting(values, "__p_EcO5ea1pLFfQLVAFhgTv1t", in __p_EcO5ea1pLFfQLVAFhgTv1t));
        }

        internal HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60 __WITH__(n1.IVLNode __p_LxhCPGZDVe8MBML1x6aMr1, n1.IVLNode __p_EcO5ea1pLFfQLVAFhgTv1t)
        {
            n3.HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_LxhCPGZDVe8MBML1x6aMr1 != this.__p_LxhCPGZDVe8MBML1x6aMr1 || __p_EcO5ea1pLFfQLVAFhgTv1t != this.__p_EcO5ea1pLFfQLVAFhgTv1t ? new HeightToNormal_PM7i6MhpFWVLqVVV4ZUj60(this)
                {__p_LxhCPGZDVe8MBML1x6aMr1 = __p_LxhCPGZDVe8MBML1x6aMr1, __p_EcO5ea1pLFfQLVAFhgTv1t = __p_EcO5ea1pLFfQLVAFhgTv1t} : that_0;
            else
            {
                this.__p_LxhCPGZDVe8MBML1x6aMr1 = __p_LxhCPGZDVe8MBML1x6aMr1;
                this.__p_EcO5ea1pLFfQLVAFhgTv1t = __p_EcO5ea1pLFfQLVAFhgTv1t;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 319177U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "SKxEXRVYrWaPR3rsXyxEw1", Name = "PBRMaterial_Metallic_C")]
    [n2.SerializableAttribute]
    public class PBRMaterial_Metallic_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.PBRMaterial_Metallic_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new PBRMaterial_Metallic_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.PBRMaterial_Metallic_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new PBRMaterial_Metallic_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.PBRMaterial_Metallic_C Update([n4.SerializedDefaultValueAttribute("1, 1, 1, 1", false)] n11.GpuValue<n5.Vector4> Diffuse_In, [n4.SerializedDefaultValueAttribute("0", false)] n11.GpuValue<float> Metalness_In, [n4.SerializedDefaultValueAttribute("0.35", false)] n11.GpuValue<float> Roughness_In, out n10.Material Output_Out)
        {
            bool __pad_M2RbPpCjhGnOlfXhqCXO3p_0 = __slot_M2RbPpCjhGnOlfXhqCXO3p;
            var State_Output_4 = this.__p_DRXbkUh9DZBLThuIZw7fGJ.Update(GpuValue_In: Diffuse_In, Output_Out: out n6.SetVar<n5.Vector4> Output_1, Original_Shader_Source_Out: out n7.ToShaderFX<n5.Vector4> Original_Shader_Source_2, Shader_Code_Out: out string Shader_Code_3);
            this.__p_DRXbkUh9DZBLThuIZw7fGJ = State_Output_4;
            n1.CompilationHelper.WritePin(this.__p_KRedvCIFdGOMZyua9OVTHG.Inputs[0], ref Output_1);
            this.__p_KRedvCIFdGOMZyua9OVTHG = this.__p_KRedvCIFdGOMZyua9OVTHG;
            n1.CompilationHelper.ReadPin(this.__p_KRedvCIFdGOMZyua9OVTHG.Outputs[0], out n8.MaterialDiffuseMapFeature out_5);
            this.__p_KRedvCIFdGOMZyua9OVTHG = this.__p_KRedvCIFdGOMZyua9OVTHG;
            var State_Output_9 = this.__p_EmsSxTa8wkrNPeC3Lkxc3F.Update(GpuValue_In: Metalness_In, Output_Out: out n6.SetVar<float> Output_6, Original_Shader_Source_Out: out n7.ToShaderFX<float> Original_Shader_Source_7, Shader_Code_Out: out string Shader_Code_8);
            this.__p_EmsSxTa8wkrNPeC3Lkxc3F = State_Output_9;
            n1.CompilationHelper.WritePin(this.__p_Hh6mbWTd32WPRIcE9ex4VU.Inputs[0], ref Output_6);
            this.__p_Hh6mbWTd32WPRIcE9ex4VU = this.__p_Hh6mbWTd32WPRIcE9ex4VU;
            n1.CompilationHelper.ReadPin(this.__p_Hh6mbWTd32WPRIcE9ex4VU.Outputs[0], out n8.MaterialMetalnessMapFeature out_10);
            this.__p_Hh6mbWTd32WPRIcE9ex4VU = this.__p_Hh6mbWTd32WPRIcE9ex4VU;
            var State_Output_14 = this.__p_B1PSWQQtEVNMmkoxrwbPXC.Update(GpuValue_In: Roughness_In, Output_Out: out n6.SetVar<float> Output_11, Original_Shader_Source_Out: out n7.ToShaderFX<float> Original_Shader_Source_12, Shader_Code_Out: out string Shader_Code_13);
            this.__p_B1PSWQQtEVNMmkoxrwbPXC = State_Output_14;
            n1.CompilationHelper.WritePin(this.__p_IPJ25wpovMPOAyWLfINSSe.Inputs[0], ref Output_11);
            this.__p_IPJ25wpovMPOAyWLfINSSe = this.__p_IPJ25wpovMPOAyWLfINSSe;
            n1.CompilationHelper.WritePin(this.__p_IPJ25wpovMPOAyWLfINSSe.Inputs[1], ref __pad_M2RbPpCjhGnOlfXhqCXO3p_0);
            this.__p_IPJ25wpovMPOAyWLfINSSe = this.__p_IPJ25wpovMPOAyWLfINSSe;
            n1.CompilationHelper.ReadPin(this.__p_IPJ25wpovMPOAyWLfINSSe.Outputs[0], out n8.MaterialGlossinessMapFeature out_15);
            this.__p_IPJ25wpovMPOAyWLfINSSe = this.__p_IPJ25wpovMPOAyWLfINSSe;
            n8.IMaterialMicroSurfaceFeature Micro_Surface_16 = (n8.IMaterialMicroSurfaceFeature)out_15;
            n1.CompilationHelper.WritePin(this.__p_G4d8WGSZ2JsNcXQZWqkoVm.Inputs[3], ref Micro_Surface_16);
            this.__p_G4d8WGSZ2JsNcXQZWqkoVm = this.__p_G4d8WGSZ2JsNcXQZWqkoVm;
            n1.CompilationHelper.ReadPin(this.__p_G4d8WGSZ2JsNcXQZWqkoVm.Outputs[0], out n9.GeometryAttributes out_17);
            this.__p_G4d8WGSZ2JsNcXQZWqkoVm = this.__p_G4d8WGSZ2JsNcXQZWqkoVm;
            n1.CompilationHelper.WritePin(this.__p_CpGPXTZ5TaLQFWfpGi9xQH.Inputs[0], ref out_17);
            this.__p_CpGPXTZ5TaLQFWfpGi9xQH = this.__p_CpGPXTZ5TaLQFWfpGi9xQH;
            n8.IMaterialDiffuseFeature Diffuse_18 = (n8.IMaterialDiffuseFeature)out_5;
            n1.CompilationHelper.WritePin(this.__p_TJ7HzQxOtPKOpN3wj3IwM6.Inputs[0], ref Diffuse_18);
            this.__p_TJ7HzQxOtPKOpN3wj3IwM6 = this.__p_TJ7HzQxOtPKOpN3wj3IwM6;
            n1.CompilationHelper.ReadPin(this.__p_AoJeIVhPv8NM9Xa9BA8xBU.Outputs[0], out n8.MaterialDiffuseLambertModelFeature out_19);
            this.__p_AoJeIVhPv8NM9Xa9BA8xBU = this.__p_AoJeIVhPv8NM9Xa9BA8xBU;
            n8.IMaterialDiffuseModelFeature Diffuse_Model_20 = (n8.IMaterialDiffuseModelFeature)out_19;
            n1.CompilationHelper.WritePin(this.__p_TJ7HzQxOtPKOpN3wj3IwM6.Inputs[1], ref Diffuse_Model_20);
            this.__p_TJ7HzQxOtPKOpN3wj3IwM6 = this.__p_TJ7HzQxOtPKOpN3wj3IwM6;
            n8.IMaterialSpecularFeature Specular_21 = (n8.IMaterialSpecularFeature)out_10;
            n1.CompilationHelper.WritePin(this.__p_TJ7HzQxOtPKOpN3wj3IwM6.Inputs[2], ref Specular_21);
            this.__p_TJ7HzQxOtPKOpN3wj3IwM6 = this.__p_TJ7HzQxOtPKOpN3wj3IwM6;
            n1.CompilationHelper.ReadPin(this.__p_HaqtyM3KtYfPeNxxeXfeSa.Outputs[0], out n8.MaterialSpecularMicrofacetModelFeature out_22);
            this.__p_HaqtyM3KtYfPeNxxeXfeSa = this.__p_HaqtyM3KtYfPeNxxeXfeSa;
            n8.IMaterialSpecularModelFeature Specular_Model_23 = (n8.IMaterialSpecularModelFeature)out_22;
            n1.CompilationHelper.WritePin(this.__p_TJ7HzQxOtPKOpN3wj3IwM6.Inputs[3], ref Specular_Model_23);
            this.__p_TJ7HzQxOtPKOpN3wj3IwM6 = this.__p_TJ7HzQxOtPKOpN3wj3IwM6;
            n1.CompilationHelper.ReadPin(this.__p_TJ7HzQxOtPKOpN3wj3IwM6.Outputs[0], out n9.ShadingAttributes out_24);
            this.__p_TJ7HzQxOtPKOpN3wj3IwM6 = this.__p_TJ7HzQxOtPKOpN3wj3IwM6;
            n1.CompilationHelper.WritePin(this.__p_CpGPXTZ5TaLQFWfpGi9xQH.Inputs[1], ref out_24);
            this.__p_CpGPXTZ5TaLQFWfpGi9xQH = this.__p_CpGPXTZ5TaLQFWfpGi9xQH;
            n1.CompilationHelper.ReadPin(this.__p_CCaOA36FbypOeUVEIOTmJU.Outputs[0], out n9.MiscAttributes out_25);
            this.__p_CCaOA36FbypOeUVEIOTmJU = this.__p_CCaOA36FbypOeUVEIOTmJU;
            n1.CompilationHelper.WritePin(this.__p_CpGPXTZ5TaLQFWfpGi9xQH.Inputs[2], ref out_25);
            this.__p_CpGPXTZ5TaLQFWfpGi9xQH = this.__p_CpGPXTZ5TaLQFWfpGi9xQH;
            n1.CompilationHelper.ReadPin(this.__p_CpGPXTZ5TaLQFWfpGi9xQH.Outputs[0], out n10.Material out_26);
            this.__p_CpGPXTZ5TaLQFWfpGi9xQH = this.__p_CpGPXTZ5TaLQFWfpGi9xQH;
            Output_Out = out_26;
            return this;
        }

        public n3.PBRMaterial_Metallic_C SetCullMode([n4.SerializedDefaultValueAttribute("Back", false)] n12.CullMode Cull_Mode_In)
        {
            n1.CompilationHelper.WritePin(this.__p_CCaOA36FbypOeUVEIOTmJU.Inputs[3], ref Cull_Mode_In);
            this.__p_CCaOA36FbypOeUVEIOTmJU = this.__p_CCaOA36FbypOeUVEIOTmJU;
            return this;
        }

        public n3.PBRMaterial_Metallic_C SetDisplacement(n8.IMaterialDisplacementFeature Displacement_In)
        {
            n1.CompilationHelper.WritePin(this.__p_G4d8WGSZ2JsNcXQZWqkoVm.Inputs[1], ref Displacement_In);
            this.__p_G4d8WGSZ2JsNcXQZWqkoVm = this.__p_G4d8WGSZ2JsNcXQZWqkoVm;
            return this;
        }

        public n3.PBRMaterial_Metallic_C SetOcclusion(n8.IMaterialOcclusionFeature Occlusion_In)
        {
            n1.CompilationHelper.WritePin(this.__p_CCaOA36FbypOeUVEIOTmJU.Inputs[0], ref Occlusion_In);
            this.__p_CCaOA36FbypOeUVEIOTmJU = this.__p_CCaOA36FbypOeUVEIOTmJU;
            return this;
        }

        public n3.PBRMaterial_Metallic_C SetSubsurfaceScattering(n8.IMaterialSubsurfaceScatteringFeature Subsurface_Scattering_In)
        {
            n1.CompilationHelper.WritePin(this.__p_TJ7HzQxOtPKOpN3wj3IwM6.Inputs[5], ref Subsurface_Scattering_In);
            this.__p_TJ7HzQxOtPKOpN3wj3IwM6 = this.__p_TJ7HzQxOtPKOpN3wj3IwM6;
            return this;
        }

        public n3.PBRMaterial_Metallic_C SetTransparency(n8.IMaterialTransparencyFeature Transparency_In)
        {
            n1.CompilationHelper.WritePin(this.__p_CCaOA36FbypOeUVEIOTmJU.Inputs[1], ref Transparency_In);
            this.__p_CCaOA36FbypOeUVEIOTmJU = this.__p_CCaOA36FbypOeUVEIOTmJU;
            return this;
        }

        public n3.PBRMaterial_Metallic_C SetEmissive(n8.IMaterialEmissiveFeature Emissive_In)
        {
            n1.CompilationHelper.WritePin(this.__p_TJ7HzQxOtPKOpN3wj3IwM6.Inputs[4], ref Emissive_In);
            this.__p_TJ7HzQxOtPKOpN3wj3IwM6 = this.__p_TJ7HzQxOtPKOpN3wj3IwM6;
            return this;
        }

        public n3.PBRMaterial_Metallic_C SetLayers(n13.IReadOnlyList<n8.MaterialBlendLayer> Layers_In)
        {
            n1.CompilationHelper.WritePin(this.__p_CpGPXTZ5TaLQFWfpGi9xQH.Inputs[3], ref Layers_In);
            this.__p_CpGPXTZ5TaLQFWfpGi9xQH = this.__p_CpGPXTZ5TaLQFWfpGi9xQH;
            return this;
        }

        public n3.PBRMaterial_Metallic_C SetNormal(n8.IMaterialSurfaceFeature Normal_In)
        {
            n1.CompilationHelper.WritePin(this.__p_G4d8WGSZ2JsNcXQZWqkoVm.Inputs[2], ref Normal_In);
            this.__p_G4d8WGSZ2JsNcXQZWqkoVm = this.__p_G4d8WGSZ2JsNcXQZWqkoVm;
            return this;
        }

        public n3.PBRMaterial_Metallic_C SetTesselation(n8.IMaterialTessellationFeature Tessellation_In)
        {
            n1.CompilationHelper.WritePin(this.__p_G4d8WGSZ2JsNcXQZWqkoVm.Inputs[0], ref Tessellation_In);
            this.__p_G4d8WGSZ2JsNcXQZWqkoVm = this.__p_G4d8WGSZ2JsNcXQZWqkoVm;
            return this;
        }

        public n3.PBRMaterial_Metallic_C __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "GeometryAttributes", "Stride.Advanced.Materials");
            this.__p_G4d8WGSZ2JsNcXQZWqkoVm = node_0;
            var node_1 = n1.CompilationHelper.CreateNodeById(Node_Context, "ShadingAttributes", "Stride.Advanced.Materials");
            this.__p_TJ7HzQxOtPKOpN3wj3IwM6 = node_1;
            var node_2 = n1.CompilationHelper.CreateNodeById(Node_Context, "Lambert", "Stride.Advanced.Materials.ShadingAttributes.DiffuseModel");
            this.__p_AoJeIVhPv8NM9Xa9BA8xBU = node_2;
            var node_3 = n1.CompilationHelper.CreateNodeById(Node_Context, "Microfacet", "Stride.Advanced.Materials.ShadingAttributes.SpecularModel");
            this.__p_HaqtyM3KtYfPeNxxeXfeSa = node_3;
            var node_4 = n1.CompilationHelper.CreateNodeById(Node_Context, "MiscAttributes", "Stride.Advanced.Materials");
            this.__p_CCaOA36FbypOeUVEIOTmJU = node_4;
            var node_5 = n1.CompilationHelper.CreateNodeById(Node_Context, "Material", "Stride.Advanced.Materials");
            this.__p_CpGPXTZ5TaLQFWfpGi9xQH = node_5;
            var node_6 = n1.CompilationHelper.CreateNodeById(Node_Context, "Metalness", "Stride.Advanced.Materials.ShadingAttributes");
            this.__p_Hh6mbWTd32WPRIcE9ex4VU = node_6;
            var node_7 = n1.CompilationHelper.CreateNodeById(Node_Context, "Glossiness", "Stride.Advanced.Materials.GeometryAttributes");
            this.__p_IPJ25wpovMPOAyWLfINSSe = node_7;
            var node_8 = n1.CompilationHelper.CreateNodeById(Node_Context, "Diffuse", "Stride.Advanced.Materials.ShadingAttributes");
            this.__p_KRedvCIFdGOMZyua9OVTHG = node_8;
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "DRXbkUh9DZBLThuIZw7fGJ", 319314U);
            var Output_10 = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4>.Create(Node_Context: Node_Context_9);
            this.__p_DRXbkUh9DZBLThuIZw7fGJ = Output_10;
            n1.NodeContext Node_Context_11 = Node_Context.CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "B1PSWQQtEVNMmkoxrwbPXC", 319323U);
            var Output_12 = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float>.Create(Node_Context: Node_Context_11);
            this.__p_B1PSWQQtEVNMmkoxrwbPXC = Output_12;
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "EmsSxTa8wkrNPeC3Lkxc3F", 319329U);
            var Output_14 = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float>.Create(Node_Context: Node_Context_13);
            this.__p_EmsSxTa8wkrNPeC3Lkxc3F = Output_14;
            return this;
        }

        public n3.PBRMaterial_Metallic_C __CreateDefault__()
        {
            this.__p_DRXbkUh9DZBLThuIZw7fGJ = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4>.CreateDefault();
            this.__p_KRedvCIFdGOMZyua9OVTHG = default(n1.IVLNode);
            this.__p_EmsSxTa8wkrNPeC3Lkxc3F = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float>.CreateDefault();
            this.__p_Hh6mbWTd32WPRIcE9ex4VU = default(n1.IVLNode);
            this.__p_B1PSWQQtEVNMmkoxrwbPXC = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float>.CreateDefault();
            this.__p_IPJ25wpovMPOAyWLfINSSe = default(n1.IVLNode);
            this.__p_G4d8WGSZ2JsNcXQZWqkoVm = default(n1.IVLNode);
            this.__p_CpGPXTZ5TaLQFWfpGi9xQH = default(n1.IVLNode);
            this.__p_TJ7HzQxOtPKOpN3wj3IwM6 = default(n1.IVLNode);
            this.__p_AoJeIVhPv8NM9Xa9BA8xBU = default(n1.IVLNode);
            this.__p_HaqtyM3KtYfPeNxxeXfeSa = default(n1.IVLNode);
            this.__p_CCaOA36FbypOeUVEIOTmJU = default(n1.IVLNode);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DRXbkUh9DZBLThuIZw7fGJ);
            n1.CompilationHelper.SafeDispose(this.__p_KRedvCIFdGOMZyua9OVTHG);
            n1.CompilationHelper.SafeDispose(this.__p_EmsSxTa8wkrNPeC3Lkxc3F);
            n1.CompilationHelper.SafeDispose(this.__p_Hh6mbWTd32WPRIcE9ex4VU);
            n1.CompilationHelper.SafeDispose(this.__p_B1PSWQQtEVNMmkoxrwbPXC);
            n1.CompilationHelper.SafeDispose(this.__p_IPJ25wpovMPOAyWLfINSSe);
            n1.CompilationHelper.SafeDispose(this.__p_G4d8WGSZ2JsNcXQZWqkoVm);
            n1.CompilationHelper.SafeDispose(this.__p_CpGPXTZ5TaLQFWfpGi9xQH);
            n1.CompilationHelper.SafeDispose(this.__p_TJ7HzQxOtPKOpN3wj3IwM6);
            n1.CompilationHelper.SafeDispose(this.__p_AoJeIVhPv8NM9Xa9BA8xBU);
            n1.CompilationHelper.SafeDispose(this.__p_HaqtyM3KtYfPeNxxeXfeSa);
            n1.CompilationHelper.SafeDispose(this.__p_CCaOA36FbypOeUVEIOTmJU);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 319307U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "M2RbPpCjhGnOlfXhqCXO3p", Name = "__slot_M2RbPpCjhGnOlfXhqCXO3p")]
        public static bool __slot_M2RbPpCjhGnOlfXhqCXO3p = true;
        [n1.ElementAttribute(TracingId = 319314U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "DRXbkUh9DZBLThuIZw7fGJ", Name = "ToShaderFX", IsManaged = true, IsAutoGenerated = true)]
        public n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4> __p_DRXbkUh9DZBLThuIZw7fGJ;
        [n1.ElementAttribute(TracingId = 319309U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "KRedvCIFdGOMZyua9OVTHG", Name = "Diffuse", IsManaged = true, IsAutoGenerated = true, NodeName = "Diffuse", NodeCategory = "Stride.Advanced.Materials.ShadingAttributes")]
        public n1.IVLNode __p_KRedvCIFdGOMZyua9OVTHG;
        [n1.ElementAttribute(TracingId = 319329U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "EmsSxTa8wkrNPeC3Lkxc3F", Name = "ToShaderFX", IsManaged = true, IsAutoGenerated = true)]
        public n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_EmsSxTa8wkrNPeC3Lkxc3F;
        [n1.ElementAttribute(TracingId = 319298U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Hh6mbWTd32WPRIcE9ex4VU", Name = "Metalness", IsManaged = true, IsAutoGenerated = true, NodeName = "Metalness", NodeCategory = "Stride.Advanced.Materials.ShadingAttributes")]
        public n1.IVLNode __p_Hh6mbWTd32WPRIcE9ex4VU;
        [n1.ElementAttribute(TracingId = 319323U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "B1PSWQQtEVNMmkoxrwbPXC", Name = "ToShaderFX", IsManaged = true, IsAutoGenerated = true)]
        public n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_B1PSWQQtEVNMmkoxrwbPXC;
        [n1.ElementAttribute(TracingId = 319302U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "IPJ25wpovMPOAyWLfINSSe", Name = "Glossiness", IsManaged = true, IsAutoGenerated = true, NodeName = "Glossiness", NodeCategory = "Stride.Advanced.Materials.GeometryAttributes")]
        public n1.IVLNode __p_IPJ25wpovMPOAyWLfINSSe;
        [n1.ElementAttribute(TracingId = 319181U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "G4d8WGSZ2JsNcXQZWqkoVm", Name = "GeometryAttributes", IsManaged = true, IsAutoGenerated = true, NodeName = "GeometryAttributes", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_G4d8WGSZ2JsNcXQZWqkoVm;
        [n1.ElementAttribute(TracingId = 319264U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "CpGPXTZ5TaLQFWfpGi9xQH", Name = "Material", IsManaged = true, IsAutoGenerated = true, NodeName = "Material", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_CpGPXTZ5TaLQFWfpGi9xQH;
        [n1.ElementAttribute(TracingId = 319192U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "TJ7HzQxOtPKOpN3wj3IwM6", Name = "ShadingAttributes", IsManaged = true, IsAutoGenerated = true, NodeName = "ShadingAttributes", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_TJ7HzQxOtPKOpN3wj3IwM6;
        [n1.ElementAttribute(TracingId = 319206U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "AoJeIVhPv8NM9Xa9BA8xBU", Name = "Lambert", IsManaged = true, IsAutoGenerated = true, NodeName = "Lambert", NodeCategory = "Stride.Advanced.Materials.ShadingAttributes.DiffuseModel")]
        public n1.IVLNode __p_AoJeIVhPv8NM9Xa9BA8xBU;
        [n1.ElementAttribute(TracingId = 319217U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "HaqtyM3KtYfPeNxxeXfeSa", Name = "Microfacet", IsManaged = true, IsAutoGenerated = true, NodeName = "Microfacet", NodeCategory = "Stride.Advanced.Materials.ShadingAttributes.SpecularModel")]
        public n1.IVLNode __p_HaqtyM3KtYfPeNxxeXfeSa;
        [n1.ElementAttribute(TracingId = 319239U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "CCaOA36FbypOeUVEIOTmJU", Name = "MiscAttributes", IsManaged = true, IsAutoGenerated = true, NodeName = "MiscAttributes", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_CCaOA36FbypOeUVEIOTmJU;
        static PBRMaterial_Metallic_C()
        {
        }

        public PBRMaterial_Metallic_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal PBRMaterial_Metallic_C(PBRMaterial_Metallic_C other): base(other)
        {
            this.__p_DRXbkUh9DZBLThuIZw7fGJ = other.__p_DRXbkUh9DZBLThuIZw7fGJ;
            this.__p_KRedvCIFdGOMZyua9OVTHG = other.__p_KRedvCIFdGOMZyua9OVTHG;
            this.__p_EmsSxTa8wkrNPeC3Lkxc3F = other.__p_EmsSxTa8wkrNPeC3Lkxc3F;
            this.__p_Hh6mbWTd32WPRIcE9ex4VU = other.__p_Hh6mbWTd32WPRIcE9ex4VU;
            this.__p_B1PSWQQtEVNMmkoxrwbPXC = other.__p_B1PSWQQtEVNMmkoxrwbPXC;
            this.__p_IPJ25wpovMPOAyWLfINSSe = other.__p_IPJ25wpovMPOAyWLfINSSe;
            this.__p_G4d8WGSZ2JsNcXQZWqkoVm = other.__p_G4d8WGSZ2JsNcXQZWqkoVm;
            this.__p_CpGPXTZ5TaLQFWfpGi9xQH = other.__p_CpGPXTZ5TaLQFWfpGi9xQH;
            this.__p_TJ7HzQxOtPKOpN3wj3IwM6 = other.__p_TJ7HzQxOtPKOpN3wj3IwM6;
            this.__p_AoJeIVhPv8NM9Xa9BA8xBU = other.__p_AoJeIVhPv8NM9Xa9BA8xBU;
            this.__p_HaqtyM3KtYfPeNxxeXfeSa = other.__p_HaqtyM3KtYfPeNxxeXfeSa;
            this.__p_CCaOA36FbypOeUVEIOTmJU = other.__p_CCaOA36FbypOeUVEIOTmJU;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_DRXbkUh9DZBLThuIZw7fGJ", in __p_DRXbkUh9DZBLThuIZw7fGJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_KRedvCIFdGOMZyua9OVTHG", in __p_KRedvCIFdGOMZyua9OVTHG), n1.CompilationHelper.GetValueOrExisting(values, "__p_EmsSxTa8wkrNPeC3Lkxc3F", in __p_EmsSxTa8wkrNPeC3Lkxc3F), n1.CompilationHelper.GetValueOrExisting(values, "__p_Hh6mbWTd32WPRIcE9ex4VU", in __p_Hh6mbWTd32WPRIcE9ex4VU), n1.CompilationHelper.GetValueOrExisting(values, "__p_B1PSWQQtEVNMmkoxrwbPXC", in __p_B1PSWQQtEVNMmkoxrwbPXC), n1.CompilationHelper.GetValueOrExisting(values, "__p_IPJ25wpovMPOAyWLfINSSe", in __p_IPJ25wpovMPOAyWLfINSSe), n1.CompilationHelper.GetValueOrExisting(values, "__p_G4d8WGSZ2JsNcXQZWqkoVm", in __p_G4d8WGSZ2JsNcXQZWqkoVm), n1.CompilationHelper.GetValueOrExisting(values, "__p_CpGPXTZ5TaLQFWfpGi9xQH", in __p_CpGPXTZ5TaLQFWfpGi9xQH), n1.CompilationHelper.GetValueOrExisting(values, "__p_TJ7HzQxOtPKOpN3wj3IwM6", in __p_TJ7HzQxOtPKOpN3wj3IwM6), n1.CompilationHelper.GetValueOrExisting(values, "__p_AoJeIVhPv8NM9Xa9BA8xBU", in __p_AoJeIVhPv8NM9Xa9BA8xBU), n1.CompilationHelper.GetValueOrExisting(values, "__p_HaqtyM3KtYfPeNxxeXfeSa", in __p_HaqtyM3KtYfPeNxxeXfeSa), n1.CompilationHelper.GetValueOrExisting(values, "__p_CCaOA36FbypOeUVEIOTmJU", in __p_CCaOA36FbypOeUVEIOTmJU));
        }

        internal PBRMaterial_Metallic_C __WITH__(n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4> __p_DRXbkUh9DZBLThuIZw7fGJ, n1.IVLNode __p_KRedvCIFdGOMZyua9OVTHG, n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_EmsSxTa8wkrNPeC3Lkxc3F, n1.IVLNode __p_Hh6mbWTd32WPRIcE9ex4VU, n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_B1PSWQQtEVNMmkoxrwbPXC, n1.IVLNode __p_IPJ25wpovMPOAyWLfINSSe, n1.IVLNode __p_G4d8WGSZ2JsNcXQZWqkoVm, n1.IVLNode __p_CpGPXTZ5TaLQFWfpGi9xQH, n1.IVLNode __p_TJ7HzQxOtPKOpN3wj3IwM6, n1.IVLNode __p_AoJeIVhPv8NM9Xa9BA8xBU, n1.IVLNode __p_HaqtyM3KtYfPeNxxeXfeSa, n1.IVLNode __p_CCaOA36FbypOeUVEIOTmJU)
        {
            n3.PBRMaterial_Metallic_C that_0 = this;
            this.__p_DRXbkUh9DZBLThuIZw7fGJ = __p_DRXbkUh9DZBLThuIZw7fGJ;
            this.__p_KRedvCIFdGOMZyua9OVTHG = __p_KRedvCIFdGOMZyua9OVTHG;
            this.__p_EmsSxTa8wkrNPeC3Lkxc3F = __p_EmsSxTa8wkrNPeC3Lkxc3F;
            this.__p_Hh6mbWTd32WPRIcE9ex4VU = __p_Hh6mbWTd32WPRIcE9ex4VU;
            this.__p_B1PSWQQtEVNMmkoxrwbPXC = __p_B1PSWQQtEVNMmkoxrwbPXC;
            this.__p_IPJ25wpovMPOAyWLfINSSe = __p_IPJ25wpovMPOAyWLfINSSe;
            this.__p_G4d8WGSZ2JsNcXQZWqkoVm = __p_G4d8WGSZ2JsNcXQZWqkoVm;
            this.__p_CpGPXTZ5TaLQFWfpGi9xQH = __p_CpGPXTZ5TaLQFWfpGi9xQH;
            this.__p_TJ7HzQxOtPKOpN3wj3IwM6 = __p_TJ7HzQxOtPKOpN3wj3IwM6;
            this.__p_AoJeIVhPv8NM9Xa9BA8xBU = __p_AoJeIVhPv8NM9Xa9BA8xBU;
            this.__p_HaqtyM3KtYfPeNxxeXfeSa = __p_HaqtyM3KtYfPeNxxeXfeSa;
            this.__p_CCaOA36FbypOeUVEIOTmJU = __p_CCaOA36FbypOeUVEIOTmJU;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 319481U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "TuidnBSW4klMFieVC0lYyZ", Name = "Emissive_TuidnBSW4klMFieVC0lYyZ")]
    [n2.SerializableAttribute]
    public class Emissive_TuidnBSW4klMFieVC0lYyZ : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Emissive_TuidnBSW4klMFieVC0lYyZ Create(n1.NodeContext Node_Context)
        {
            var instance = new Emissive_TuidnBSW4klMFieVC0lYyZ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Emissive_TuidnBSW4klMFieVC0lYyZ CreateDefault()
        {
            var instance = new Emissive_TuidnBSW4klMFieVC0lYyZ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Emissive_TuidnBSW4klMFieVC0lYyZ Update([n4.SerializedDefaultValueAttribute("1, 1, 1, 1", false)] n11.GpuValue<n5.Vector4> Color_In, [n4.SerializedDefaultValueAttribute("1", false)] n11.GpuValue<float> Intensity_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Use_Alpha_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n8.MaterialEmissiveMapFeature Output_Out)
        {
            var State_Output_3 = this.__p_FVJ9qBQPf7dNM9Zj7qFeX2.Update(GpuValue_In: Color_In, Output_Out: out n6.SetVar<n5.Vector4> Output_0, Original_Shader_Source_Out: out n7.ToShaderFX<n5.Vector4> Original_Shader_Source_1, Shader_Code_Out: out string Shader_Code_2);
            n1.CompilationHelper.WritePin(this.__p_KT53y9SfXOAOvNFyhuO5Q1.Inputs[0], ref Output_0);
            var State_Output_7 = this.__p_CbhV7rZ8VBgQZ531eq7jaX.Update(GpuValue_In: Intensity_In, Output_Out: out n6.SetVar<float> Output_4, Original_Shader_Source_Out: out n7.ToShaderFX<float> Original_Shader_Source_5, Shader_Code_Out: out string Shader_Code_6);
            n1.CompilationHelper.WritePin(this.__p_KT53y9SfXOAOvNFyhuO5Q1.Inputs[1], ref Output_4);
            n1.CompilationHelper.WritePin(this.__p_KT53y9SfXOAOvNFyhuO5Q1.Inputs[2], ref Use_Alpha_In);
            n1.CompilationHelper.WritePin(this.__p_KT53y9SfXOAOvNFyhuO5Q1.Inputs[3], ref Enabled_In);
            n1.CompilationHelper.ReadPin(this.__p_KT53y9SfXOAOvNFyhuO5Q1.Outputs[0], out n8.MaterialEmissiveMapFeature out_8);
            Output_Out = out_8;
            n3.Emissive_TuidnBSW4klMFieVC0lYyZ that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = State_Output_3 != this.__p_FVJ9qBQPf7dNM9Zj7qFeX2 || this.__p_KT53y9SfXOAOvNFyhuO5Q1 != this.__p_KT53y9SfXOAOvNFyhuO5Q1 || State_Output_7 != this.__p_CbhV7rZ8VBgQZ531eq7jaX ? new Emissive_TuidnBSW4klMFieVC0lYyZ(this)
                {__p_FVJ9qBQPf7dNM9Zj7qFeX2 = State_Output_3, __p_KT53y9SfXOAOvNFyhuO5Q1 = this.__p_KT53y9SfXOAOvNFyhuO5Q1, __p_CbhV7rZ8VBgQZ531eq7jaX = State_Output_7} : that_9;
            else
            {
                this.__p_FVJ9qBQPf7dNM9Zj7qFeX2 = State_Output_3;
                this.__p_KT53y9SfXOAOvNFyhuO5Q1 = this.__p_KT53y9SfXOAOvNFyhuO5Q1;
                this.__p_CbhV7rZ8VBgQZ531eq7jaX = State_Output_7;
            }

            return that_9;
        }

        public n3.Emissive_TuidnBSW4klMFieVC0lYyZ __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "Emissive", "Stride.Materials.ShadingAttributes");
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "FVJ9qBQPf7dNM9Zj7qFeX2", 319493U);
            var Output_2 = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4>.Create(Node_Context: Node_Context_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "CbhV7rZ8VBgQZ531eq7jaX", 319498U);
            var Output_4 = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float>.Create(Node_Context: Node_Context_3);
            n3.Emissive_TuidnBSW4klMFieVC0lYyZ that_5 = this;
            this.__p_KT53y9SfXOAOvNFyhuO5Q1 = node_0;
            this.__p_FVJ9qBQPf7dNM9Zj7qFeX2 = Output_2;
            this.__p_CbhV7rZ8VBgQZ531eq7jaX = Output_4;
            return that_5;
        }

        public n3.Emissive_TuidnBSW4klMFieVC0lYyZ __CreateDefault__()
        {
            n3.Emissive_TuidnBSW4klMFieVC0lYyZ that_0 = this;
            this.__p_FVJ9qBQPf7dNM9Zj7qFeX2 = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4>.CreateDefault();
            this.__p_KT53y9SfXOAOvNFyhuO5Q1 = default(n1.IVLNode);
            this.__p_CbhV7rZ8VBgQZ531eq7jaX = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_FVJ9qBQPf7dNM9Zj7qFeX2);
            n1.CompilationHelper.SafeDispose(this.__p_KT53y9SfXOAOvNFyhuO5Q1);
            n1.CompilationHelper.SafeDispose(this.__p_CbhV7rZ8VBgQZ531eq7jaX);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 319493U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "FVJ9qBQPf7dNM9Zj7qFeX2", Name = "ToShaderFX", IsManaged = true, IsAutoGenerated = true)]
        public n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4> __p_FVJ9qBQPf7dNM9Zj7qFeX2;
        [n1.ElementAttribute(TracingId = 319487U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "KT53y9SfXOAOvNFyhuO5Q1", Name = "Emissive", IsManaged = true, IsAutoGenerated = true, NodeName = "Emissive", NodeCategory = "Stride.Materials.ShadingAttributes")]
        public n1.IVLNode __p_KT53y9SfXOAOvNFyhuO5Q1;
        [n1.ElementAttribute(TracingId = 319498U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "CbhV7rZ8VBgQZ531eq7jaX", Name = "ToShaderFX", IsManaged = true, IsAutoGenerated = true)]
        public n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_CbhV7rZ8VBgQZ531eq7jaX;
        public Emissive_TuidnBSW4klMFieVC0lYyZ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Emissive_TuidnBSW4klMFieVC0lYyZ(Emissive_TuidnBSW4klMFieVC0lYyZ other): base(other)
        {
            this.__p_FVJ9qBQPf7dNM9Zj7qFeX2 = other.__p_FVJ9qBQPf7dNM9Zj7qFeX2;
            this.__p_KT53y9SfXOAOvNFyhuO5Q1 = other.__p_KT53y9SfXOAOvNFyhuO5Q1;
            this.__p_CbhV7rZ8VBgQZ531eq7jaX = other.__p_CbhV7rZ8VBgQZ531eq7jaX;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FVJ9qBQPf7dNM9Zj7qFeX2", in __p_FVJ9qBQPf7dNM9Zj7qFeX2), n1.CompilationHelper.GetValueOrExisting(values, "__p_KT53y9SfXOAOvNFyhuO5Q1", in __p_KT53y9SfXOAOvNFyhuO5Q1), n1.CompilationHelper.GetValueOrExisting(values, "__p_CbhV7rZ8VBgQZ531eq7jaX", in __p_CbhV7rZ8VBgQZ531eq7jaX));
        }

        internal Emissive_TuidnBSW4klMFieVC0lYyZ __WITH__(n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4> __p_FVJ9qBQPf7dNM9Zj7qFeX2, n1.IVLNode __p_KT53y9SfXOAOvNFyhuO5Q1, n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_CbhV7rZ8VBgQZ531eq7jaX)
        {
            n3.Emissive_TuidnBSW4klMFieVC0lYyZ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_FVJ9qBQPf7dNM9Zj7qFeX2 != this.__p_FVJ9qBQPf7dNM9Zj7qFeX2 || __p_KT53y9SfXOAOvNFyhuO5Q1 != this.__p_KT53y9SfXOAOvNFyhuO5Q1 || __p_CbhV7rZ8VBgQZ531eq7jaX != this.__p_CbhV7rZ8VBgQZ531eq7jaX ? new Emissive_TuidnBSW4klMFieVC0lYyZ(this)
                {__p_FVJ9qBQPf7dNM9Zj7qFeX2 = __p_FVJ9qBQPf7dNM9Zj7qFeX2, __p_KT53y9SfXOAOvNFyhuO5Q1 = __p_KT53y9SfXOAOvNFyhuO5Q1, __p_CbhV7rZ8VBgQZ531eq7jaX = __p_CbhV7rZ8VBgQZ531eq7jaX} : that_0;
            else
            {
                this.__p_FVJ9qBQPf7dNM9Zj7qFeX2 = __p_FVJ9qBQPf7dNM9Zj7qFeX2;
                this.__p_KT53y9SfXOAOvNFyhuO5Q1 = __p_KT53y9SfXOAOvNFyhuO5Q1;
                this.__p_CbhV7rZ8VBgQZ531eq7jaX = __p_CbhV7rZ8VBgQZ531eq7jaX;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 319551U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "FoByDhloXA2QRxbsLRzGA1", Name = "MaterialLayer_FoByDhloXA2QRxbsLRzGA1")]
    [n2.SerializableAttribute]
    public class MaterialLayer_FoByDhloXA2QRxbsLRzGA1 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.MaterialLayer_FoByDhloXA2QRxbsLRzGA1 Create(n1.NodeContext Node_Context)
        {
            var instance = new MaterialLayer_FoByDhloXA2QRxbsLRzGA1(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.MaterialLayer_FoByDhloXA2QRxbsLRzGA1 CreateDefault()
        {
            var instance = new MaterialLayer_FoByDhloXA2QRxbsLRzGA1(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.MaterialLayer_FoByDhloXA2QRxbsLRzGA1 Update(n10.Material Material_In, n11.GpuValue<float> Blend_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n18.Spread<n8.MaterialBlendLayer> Result_Out, out string Shader_Code_Out)
        {
            n1.CompilationHelper.WritePin(this.__p_IkkDj24UhWIN5ENgTN8A3f.Inputs[1], ref Material_In);
            var State_Output_3 = this.__p_CUEEShkSmbZLjXaiqRsDbS.Update(GpuValue_In: Blend_In, Output_Out: out n6.SetVar<float> Output_0, Original_Shader_Source_Out: out n7.ToShaderFX<float> Original_Shader_Source_1, Shader_Code_Out: out string Shader_Code_2);
            n1.CompilationHelper.WritePin(this.__p_IkkDj24UhWIN5ENgTN8A3f.Inputs[2], ref Output_0);
            n1.CompilationHelper.WritePin(this.__p_IkkDj24UhWIN5ENgTN8A3f.Inputs[4], ref Enabled_In);
            n1.CompilationHelper.ReadPin(this.__p_IkkDj24UhWIN5ENgTN8A3f.Outputs[0], out n8.MaterialBlendLayer out_4);
            var builder_5 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4, 1);
            builder_5.Add(out_4);
            var __pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4_6 = builder_5.Commit();
            n19._Operations_.FromValue<n8.MaterialBlendLayer>(Input_In: __pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4_6, Result_Out: out n18.Spread<n8.MaterialBlendLayer> Result_7);
            Result_Out = Result_7;
            Shader_Code_Out = Shader_Code_2;
            n3.MaterialLayer_FoByDhloXA2QRxbsLRzGA1 that_8 = this;
            if (this.__GetContext__().IsImmutable)
                that_8 = this.__p_IkkDj24UhWIN5ENgTN8A3f != this.__p_IkkDj24UhWIN5ENgTN8A3f || State_Output_3 != this.__p_CUEEShkSmbZLjXaiqRsDbS || __pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4_6 != this.__pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4 ? new MaterialLayer_FoByDhloXA2QRxbsLRzGA1(this)
                {__p_IkkDj24UhWIN5ENgTN8A3f = this.__p_IkkDj24UhWIN5ENgTN8A3f, __p_CUEEShkSmbZLjXaiqRsDbS = State_Output_3, __pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4 = __pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4_6} : that_8;
            else
            {
                this.__p_IkkDj24UhWIN5ENgTN8A3f = this.__p_IkkDj24UhWIN5ENgTN8A3f;
                this.__p_CUEEShkSmbZLjXaiqRsDbS = State_Output_3;
                this.__pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4 = __pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4_6;
            }

            return that_8;
        }

        public n3.MaterialLayer_FoByDhloXA2QRxbsLRzGA1 __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "MaterialLayer", "Stride.Materials.Layers");
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "CUEEShkSmbZLjXaiqRsDbS", 319595U);
            var Output_2 = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float>.Create(Node_Context: Node_Context_1);
            n3.MaterialLayer_FoByDhloXA2QRxbsLRzGA1 that_3 = this;
            this.__pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4 = n19._Operations_.CreateDefault<n8.MaterialBlendLayer>();
            this.__p_IkkDj24UhWIN5ENgTN8A3f = node_0;
            this.__p_CUEEShkSmbZLjXaiqRsDbS = Output_2;
            return that_3;
        }

        public n3.MaterialLayer_FoByDhloXA2QRxbsLRzGA1 __CreateDefault__()
        {
            n3.MaterialLayer_FoByDhloXA2QRxbsLRzGA1 that_0 = this;
            this.__pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4 = n19._Operations_.CreateDefault<n8.MaterialBlendLayer>();
            this.__p_IkkDj24UhWIN5ENgTN8A3f = default(n1.IVLNode);
            this.__p_CUEEShkSmbZLjXaiqRsDbS = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_IkkDj24UhWIN5ENgTN8A3f);
            n1.CompilationHelper.SafeDispose(this.__p_CUEEShkSmbZLjXaiqRsDbS);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 319560U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "IkkDj24UhWIN5ENgTN8A3f", Name = "MaterialLayer", IsManaged = true, IsAutoGenerated = true, NodeName = "MaterialLayer", NodeCategory = "Stride.Materials.Layers")]
        public n1.IVLNode __p_IkkDj24UhWIN5ENgTN8A3f;
        [n1.ElementAttribute(TracingId = 319595U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "CUEEShkSmbZLjXaiqRsDbS", Name = "ToShaderFX", IsManaged = true, IsAutoGenerated = true)]
        public n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_CUEEShkSmbZLjXaiqRsDbS;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n18.Spread<n8.MaterialBlendLayer> __pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4 = default(n18.Spread<n8.MaterialBlendLayer>);
        public MaterialLayer_FoByDhloXA2QRxbsLRzGA1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal MaterialLayer_FoByDhloXA2QRxbsLRzGA1(MaterialLayer_FoByDhloXA2QRxbsLRzGA1 other): base(other)
        {
            this.__p_IkkDj24UhWIN5ENgTN8A3f = other.__p_IkkDj24UhWIN5ENgTN8A3f;
            this.__p_CUEEShkSmbZLjXaiqRsDbS = other.__p_CUEEShkSmbZLjXaiqRsDbS;
            this.__pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4 = other.__pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IkkDj24UhWIN5ENgTN8A3f", in __p_IkkDj24UhWIN5ENgTN8A3f), n1.CompilationHelper.GetValueOrExisting(values, "__p_CUEEShkSmbZLjXaiqRsDbS", in __p_CUEEShkSmbZLjXaiqRsDbS), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4", in __pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4));
        }

        internal MaterialLayer_FoByDhloXA2QRxbsLRzGA1 __WITH__(n1.IVLNode __p_IkkDj24UhWIN5ENgTN8A3f, n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_CUEEShkSmbZLjXaiqRsDbS, n18.Spread<n8.MaterialBlendLayer> __pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4)
        {
            n3.MaterialLayer_FoByDhloXA2QRxbsLRzGA1 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_IkkDj24UhWIN5ENgTN8A3f != this.__p_IkkDj24UhWIN5ENgTN8A3f || __p_CUEEShkSmbZLjXaiqRsDbS != this.__p_CUEEShkSmbZLjXaiqRsDbS || __pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4 != this.__pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4 ? new MaterialLayer_FoByDhloXA2QRxbsLRzGA1(this)
                {__p_IkkDj24UhWIN5ENgTN8A3f = __p_IkkDj24UhWIN5ENgTN8A3f, __p_CUEEShkSmbZLjXaiqRsDbS = __p_CUEEShkSmbZLjXaiqRsDbS, __pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4 = __pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4} : that_0;
            else
            {
                this.__p_IkkDj24UhWIN5ENgTN8A3f = __p_IkkDj24UhWIN5ENgTN8A3f;
                this.__p_CUEEShkSmbZLjXaiqRsDbS = __p_CUEEShkSmbZLjXaiqRsDbS;
                this.__pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4 = __pin_group_Input_In_J5wUUWx0to3OzVZM6fAyg4;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 319641U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "CNgu5ElzJK9Pso9J6Q6yaR", Name = "TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR")]
    [n2.SerializableAttribute]
    public class TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T> : n1.VLObject, n2.IDisposable where T : struct
    {
        [n4.CreateNewAttribute]
        public static n3.TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T> Create(n1.NodeContext Node_Context)
        {
            var instance = new TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T>(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T> CreateDefault()
        {
            var instance = new TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T>(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T> Update(n11.GpuValue<T> InputT_In, [n4.SerializedDefaultValueAttribute("1", false)] n11.GpuValue<float> Sharpness_In, [n4.SerializedDefaultValueAttribute("1, 1, 1", false)] n11.GpuValue<n5.Vector3> Scale_In, out n11.GpuValue<T> Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_SWZBbXYEY2PMWyU7H5aDcP;
            if (manager_2 is null)
            {
                manager_2 = new n20.Manager<n2.ValueTuple<n11.GpuValue<float>, n11.GpuValue<T>, n11.GpuValue<n5.Vector3>>, n2.ValueTuple<n11.GpuValue<T>>>(n2.ValueTuple.Create(default(n11.GpuValue<T>)));
            }

            var inputs_3 = (Sharpness_In, InputT_In, Scale_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__CcoZtWrSwvHOKeat1OIBko>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __CcoZtWrSwvHOKeat1OIBko(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV = n19._Operations_.CreateDefault<n11.GpuValue<n5.Vector3>>(), __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw = n19._Operations_.CreateDefault<n11.GpuValue<n5.Vector3>>(), __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ = n19._Operations_.CreateDefault<n11.AbstractGpuValue>(), __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb = n19._Operations_.CreateDefault<n11.GpuValue<T>>(), __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5 = n19._Operations_.CreateDefault<n11.AbstractGpuValue>(), __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb = n19._Operations_.CreateDefault<n11.AbstractGpuValue>(), __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK = n19._Operations_.CreateDefault<n11.GpuValue<T>>(), __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P = n19._Operations_.CreateDefault<n11.GpuValue<T>>(), __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV = n19._Operations_.CreateDefault<n11.GpuValue<T>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "VXU0mPPgV3XOVa8h0LcRlt", 319673U);
                    var Output_8 = n21.Pow_OYho3WrJhN0LWEmoMe81d4<n5.Vector3>.Create(Node_Context: Node_Context_7);
                    state_6.__p_VXU0mPPgV3XOVa8h0LcRlt = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "AaoV4AMYaquLUiqu94GaDN", 319680U);
                    var Output_10 = n21.Abs_HYWPOtC1lkrNB5uGryHr5l<n5.Vector3>.Create(Node_Context: Node_Context_9);
                    state_6.__p_AaoV4AMYaquLUiqu94GaDN = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "HLrgOsa20jJMpoBrqQ1Sgl", 319689U);
                    var Output_12 = n21.sumComponent_LdOKHH3PAvJM9rCpHusHUl<n5.Vector3>.Create(Node_Context: Node_Context_11);
                    state_6.__p_HLrgOsa20jJMpoBrqQ1Sgl = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "AAazI0LlVahP1ToJhpl2OV", 319705U);
                    var Output_14 = n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, n5.Vector3>.Create(Node_Context: Node_Context_13);
                    state_6.__p_AAazI0LlVahP1ToJhpl2OV = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "PsFPOB0ZO4vPCAp6wQflvV", 319720U);
                    var Output_16 = n21.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n5.Vector3>.Create(Node_Context: Node_Context_15);
                    state_6.__p_PsFPOB0ZO4vPCAp6wQflvV = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "JIxlRVm6fhZNbzEgadESjA", 319728U);
                    var Output_18 = n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, n5.Vector3>.Create(Node_Context: Node_Context_17);
                    state_6.__p_JIxlRVm6fhZNbzEgadESjA = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "Qc5rZp2zV8KPG9tACLcSGb", 319732U);
                    var Output_20 = n23.Invoke_C<T>.Create(Node_Context: Node_Context_19);
                    state_6.__p_Qc5rZp2zV8KPG9tACLcSGb = Output_20;
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "K8zQvPE8FQXMr6xFKxZU8i", 319736U);
                    var Output_22 = n24.xy_EiegIBeM6c8OnN5CcRLRyU<n5.Vector3>.Create(Node_Context: Node_Context_21);
                    state_6.__p_K8zQvPE8FQXMr6xFKxZU8i = Output_22;
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "I90fQDotFc7MObpomzroYO", 319739U);
                    var Output_24 = n24.xz_QELrHhPP9HQOKXyh2AbSn6<n5.Vector3>.Create(Node_Context: Node_Context_23);
                    state_6.__p_I90fQDotFc7MObpomzroYO = Output_24;
                    n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "ABkWNurFFyPMObybM8in6j", 319744U);
                    var Output_26 = n24.yz_UwHE83eg6BmNIdbSAmuyYp<n5.Vector3>.Create(Node_Context: Node_Context_25);
                    state_6.__p_ABkWNurFFyPMObybM8in6j = Output_26;
                    n1.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "LHkKcCk216ROJYoWDzHZCL", 319753U);
                    var Output_28 = n25.xMyMz_split_HhwKvU63boDLFOLEO95pTD.Create(Node_Context: Node_Context_27);
                    state_6.__p_LHkKcCk216ROJYoWDzHZCL = Output_28;
                    n1.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "HsIoUKtgiqCOOO3y4nsvrK", 319763U);
                    var Output_30 = n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_29);
                    state_6.__p_HsIoUKtgiqCOOO3y4nsvrK = Output_30;
                    n1.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "TGfwEat6LquNqm4wT4hYI5", 319774U);
                    var Output_32 = n23.Invoke_C<T>.Create(Node_Context: Node_Context_31);
                    state_6.__p_TGfwEat6LquNqm4wT4hYI5 = Output_32;
                    n1.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "DYT9ywQyL0NOVHovZM2YmQ", 319783U);
                    var Output_34 = n23.Invoke_C<T>.Create(Node_Context: Node_Context_33);
                    state_6.__p_DYT9ywQyL0NOVHovZM2YmQ = Output_34;
                    n1.NodeContext Node_Context_35 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "EMRr0mZjl7tQBKKhLrKRZd", 319788U);
                    var Output_36 = n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, T>.Create(Node_Context: Node_Context_35);
                    state_6.__p_EMRr0mZjl7tQBKKhLrKRZd = Output_36;
                    n1.NodeContext Node_Context_37 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "V4h8IF3QNLeNtzfB9RovDV", 319807U);
                    var Output_38 = n21.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T>.Create(Node_Context: Node_Context_37);
                    state_6.__p_V4h8IF3QNLeNtzfB9RovDV = Output_38;
                    n1.NodeContext Node_Context_39 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "NRsblKPYEa1LjvsW0pZ0WZ", 319826U);
                    var Output_40 = n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, T>.Create(Node_Context: Node_Context_39);
                    state_6.__p_NRsblKPYEa1LjvsW0pZ0WZ = Output_40;
                    n1.NodeContext Node_Context_41 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "DXLT8svVX8XM8pljMTrvKS", 319835U);
                    var Output_42 = n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, T>.Create(Node_Context: Node_Context_41);
                    state_6.__p_DXLT8svVX8XM8pljMTrvKS = Output_42;
                    n1.NodeContext Node_Context_43 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "J3h59rv2kEnLfCxBT1ki2P", 319839U);
                    var Output_44 = n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_43);
                    state_6.__p_J3h59rv2kEnLfCxBT1ki2P = Output_44;
                    n1.NodeContext Node_Context_45 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "MfV8KivL3GfOWasvYJFnAb", 319843U);
                    var Output_46 = n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T>.Create(Node_Context: Node_Context_45);
                    state_6.__p_MfV8KivL3GfOWasvYJFnAb = Output_46;
                    n1.NodeContext Node_Context_47 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "HKzZITPZOX8LvG10jgpWcw", 319847U);
                    var Output_48 = n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3>.Create(Node_Context: Node_Context_47);
                    state_6.__p_HKzZITPZOX8LvG10jgpWcw = Output_48;
                    n1.NodeContext Node_Context_49 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "CQbQ3j9TATQPlqIntDsTn9", 319851U);
                    var Output_50 = n24.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_49);
                    state_6.__p_CQbQ3j9TATQPlqIntDsTn9 = Output_50;
                    n1.NodeContext Node_Context_51 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "MGxEuzytm5POiubJVNVeek", 319854U);
                    var Output_52 = n26.PositionWS_EqNTwQZFoLOQdVEmvtk795.Create(Node_Context: Node_Context_51);
                    state_6.__p_MGxEuzytm5POiubJVNVeek = Output_52;
                    n1.NodeContext Node_Context_53 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "LgcK1i5zsrxLKF3nERlq2b", 319856U);
                    var Output_54 = n26.MeshNormalWS_Gppq7KtrvrwLtF4UYBlDgj.Create(Node_Context: Node_Context_53);
                    state_6.__p_LgcK1i5zsrxLKF3nERlq2b = Output_54;
                }

                var State_Output_56 = state_6.__p_LgcK1i5zsrxLKF3nERlq2b.Update(Output_Out: out n11.GpuValue<n5.Vector3> Output_55);
                var Output_58 = state_6.__p_AaoV4AMYaquLUiqu94GaDN.Update(Input_In: Output_55, Out_Out: out n11.GpuValue<n5.Vector3> Out_57);
                n11.GpuValue<n5.Vector3> default_59 = default(n11.GpuValue<n5.Vector3>);
                var State_Output_61 = state_6.__p_AAazI0LlVahP1ToJhpl2OV.Update(x_In: Sharpness_In, default_In: default_59, Output_Out: out n11.GpuValue<n5.Vector3> Output_60);
                var State_Output_63 = state_6.__p_VXU0mPPgV3XOVa8h0LcRlt.Update(Input_In: Out_57, Pow_In: Output_60, Output_Out: out n11.GpuValue<n5.Vector3> Output_62);
                n11.GpuValue<float> Default_64 = default(n11.GpuValue<float>);
                var State_Output_66 = state_6.__p_HLrgOsa20jJMpoBrqQ1Sgl.Update(Input_In: Output_62, Default_In: Default_64, Output_Out: out n11.GpuValue<float> Output_65);
                n11.GpuValue<n5.Vector3> default_67 = default(n11.GpuValue<n5.Vector3>);
                var State_Output_69 = state_6.__p_JIxlRVm6fhZNbzEgadESjA.Update(x_In: Output_65, default_In: default_67, Output_Out: out n11.GpuValue<n5.Vector3> Output_68);
                var builder_70 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV, 2);
                builder_70.Add(Output_62);
                builder_70.Add(Output_68);
                var __pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV_71 = builder_70.Commit();
                var State_Output_73 = state_6.__p_PsFPOB0ZO4vPCAp6wQflvV.Update(Input_In: __pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV_71, Output_Out: out n11.GpuValue<n5.Vector3> Output_72);
                var Output_77 = state_6.__p_LHkKcCk216ROJYoWDzHZCL.Update(value_In: Output_72, x_Out: out n11.GpuValue<float> x_74, y_Out: out n11.GpuValue<float> y_75, z_Out: out n11.GpuValue<float> z_76);
                n11.GpuValue<T> default_78 = default(n11.GpuValue<T>);
                var State_Output_80 = state_6.__p_DXLT8svVX8XM8pljMTrvKS.Update(x_In: x_74, default_In: default_78, Output_Out: out n11.GpuValue<T> Output_79);
                var State_Output_82 = state_6.__p_MGxEuzytm5POiubJVNVeek.Update(Output_Out: out n11.GpuValue<n5.Vector4> Output_81);
                var State_Output_84 = state_6.__p_CQbQ3j9TATQPlqIntDsTn9.Update(Input_In: Output_81, Output_Out: out n11.GpuValue<n5.Vector3> Output_83);
                var builder_85 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw, 2);
                builder_85.Add(Output_83);
                builder_85.Add(Scale_In);
                var __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw_86 = builder_85.Commit();
                var State_Output_88 = state_6.__p_HKzZITPZOX8LvG10jgpWcw.Update(Input_In: __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw_86, Output_Out: out n11.GpuValue<n5.Vector3> Output_87);
                var State_Output_90 = state_6.__p_ABkWNurFFyPMObybM8in6j.Update(Input_In: Output_87, Output_Out: out n11.GpuValue<n5.Vector2> Output_89);
                var builder_91 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ, 1);
                builder_91.Add(Output_89);
                var __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ_92 = builder_91.Commit();
                var State_Output_94 = state_6.__p_DYT9ywQyL0NOVHovZM2YmQ.Update(Function_In: InputT_In, Parameters_In: __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ_92, Output_Out: out n11.GpuValue<T> Output_93);
                var builder_95 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb, 2);
                builder_95.Add(Output_93);
                builder_95.Add(Output_79);
                var __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb_96 = builder_95.Commit();
                var State_Output_98 = state_6.__p_MfV8KivL3GfOWasvYJFnAb.Update(Input_In: __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb_96, Output_Out: out n11.GpuValue<T> Output_97);
                var State_Output_100 = state_6.__p_I90fQDotFc7MObpomzroYO.Update(Input_In: Output_87, Output_Out: out n11.GpuValue<n5.Vector2> Output_99);
                var builder_101 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5, 1);
                builder_101.Add(Output_99);
                var __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5_102 = builder_101.Commit();
                var State_Output_104 = state_6.__p_TGfwEat6LquNqm4wT4hYI5.Update(Function_In: InputT_In, Parameters_In: __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5_102, Output_Out: out n11.GpuValue<T> Output_103);
                var State_Output_106 = state_6.__p_K8zQvPE8FQXMr6xFKxZU8i.Update(Input_In: Output_87, Output_Out: out n11.GpuValue<n5.Vector2> Output_105);
                var builder_107 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb, 1);
                builder_107.Add(Output_105);
                var __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb_108 = builder_107.Commit();
                var State_Output_110 = state_6.__p_Qc5rZp2zV8KPG9tACLcSGb.Update(Function_In: InputT_In, Parameters_In: __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb_108, Output_Out: out n11.GpuValue<T> Output_109);
                n11.GpuValue<T> default_111 = default(n11.GpuValue<T>);
                var State_Output_113 = state_6.__p_EMRr0mZjl7tQBKKhLrKRZd.Update(x_In: z_76, default_In: default_111, Output_Out: out n11.GpuValue<T> Output_112);
                var builder_114 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK, 2);
                builder_114.Add(Output_109);
                builder_114.Add(Output_112);
                var __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK_115 = builder_114.Commit();
                var State_Output_117 = state_6.__p_HsIoUKtgiqCOOO3y4nsvrK.Update(Input_In: __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK_115, Output_Out: out n11.GpuValue<T> Output_116);
                n11.GpuValue<T> default_118 = default(n11.GpuValue<T>);
                var State_Output_120 = state_6.__p_NRsblKPYEa1LjvsW0pZ0WZ.Update(x_In: y_75, default_In: default_118, Output_Out: out n11.GpuValue<T> Output_119);
                var builder_121 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P, 2);
                builder_121.Add(Output_103);
                builder_121.Add(Output_119);
                var __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P_122 = builder_121.Commit();
                var State_Output_124 = state_6.__p_J3h59rv2kEnLfCxBT1ki2P.Update(Input_In: __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P_122, Output_Out: out n11.GpuValue<T> Output_123);
                var builder_125 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV, 3);
                builder_125.Add(Output_116);
                builder_125.Add(Output_123);
                builder_125.Add(Output_97);
                var __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV_126 = builder_125.Commit();
                var State_Output_128 = state_6.__p_V4h8IF3QNLeNtzfB9RovDV.Update(Input_In: __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV_126, Output_Out: out n11.GpuValue<T> Output_127);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_56 != state_6.__p_LgcK1i5zsrxLKF3nERlq2b || Output_58 != state_6.__p_AaoV4AMYaquLUiqu94GaDN || State_Output_61 != state_6.__p_AAazI0LlVahP1ToJhpl2OV || State_Output_63 != state_6.__p_VXU0mPPgV3XOVa8h0LcRlt || State_Output_66 != state_6.__p_HLrgOsa20jJMpoBrqQ1Sgl || State_Output_69 != state_6.__p_JIxlRVm6fhZNbzEgadESjA || __pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV_71 != state_6.__pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV || State_Output_73 != state_6.__p_PsFPOB0ZO4vPCAp6wQflvV || Output_77 != state_6.__p_LHkKcCk216ROJYoWDzHZCL || State_Output_80 != state_6.__p_DXLT8svVX8XM8pljMTrvKS || State_Output_82 != state_6.__p_MGxEuzytm5POiubJVNVeek || State_Output_84 != state_6.__p_CQbQ3j9TATQPlqIntDsTn9 || __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw_86 != state_6.__pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw || State_Output_88 != state_6.__p_HKzZITPZOX8LvG10jgpWcw || State_Output_90 != state_6.__p_ABkWNurFFyPMObybM8in6j || __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ_92 != state_6.__pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ || State_Output_94 != state_6.__p_DYT9ywQyL0NOVHovZM2YmQ || __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb_96 != state_6.__pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb || State_Output_98 != state_6.__p_MfV8KivL3GfOWasvYJFnAb || State_Output_100 != state_6.__p_I90fQDotFc7MObpomzroYO || __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5_102 != state_6.__pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5 || State_Output_104 != state_6.__p_TGfwEat6LquNqm4wT4hYI5 || State_Output_106 != state_6.__p_K8zQvPE8FQXMr6xFKxZU8i || __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb_108 != state_6.__pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb || State_Output_110 != state_6.__p_Qc5rZp2zV8KPG9tACLcSGb || State_Output_113 != state_6.__p_EMRr0mZjl7tQBKKhLrKRZd || __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK_115 != state_6.__pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK || State_Output_117 != state_6.__p_HsIoUKtgiqCOOO3y4nsvrK || State_Output_120 != state_6.__p_NRsblKPYEa1LjvsW0pZ0WZ || __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P_122 != state_6.__pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P || State_Output_124 != state_6.__p_J3h59rv2kEnLfCxBT1ki2P || __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV_126 != state_6.__pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV || State_Output_128 != state_6.__p_V4h8IF3QNLeNtzfB9RovDV ? new __CcoZtWrSwvHOKeat1OIBko(state_6)
                    {__p_LgcK1i5zsrxLKF3nERlq2b = State_Output_56, __p_AaoV4AMYaquLUiqu94GaDN = Output_58, __p_AAazI0LlVahP1ToJhpl2OV = State_Output_61, __p_VXU0mPPgV3XOVa8h0LcRlt = State_Output_63, __p_HLrgOsa20jJMpoBrqQ1Sgl = State_Output_66, __p_JIxlRVm6fhZNbzEgadESjA = State_Output_69, __pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV = __pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV_71, __p_PsFPOB0ZO4vPCAp6wQflvV = State_Output_73, __p_LHkKcCk216ROJYoWDzHZCL = Output_77, __p_DXLT8svVX8XM8pljMTrvKS = State_Output_80, __p_MGxEuzytm5POiubJVNVeek = State_Output_82, __p_CQbQ3j9TATQPlqIntDsTn9 = State_Output_84, __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw = __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw_86, __p_HKzZITPZOX8LvG10jgpWcw = State_Output_88, __p_ABkWNurFFyPMObybM8in6j = State_Output_90, __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ = __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ_92, __p_DYT9ywQyL0NOVHovZM2YmQ = State_Output_94, __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb = __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb_96, __p_MfV8KivL3GfOWasvYJFnAb = State_Output_98, __p_I90fQDotFc7MObpomzroYO = State_Output_100, __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5 = __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5_102, __p_TGfwEat6LquNqm4wT4hYI5 = State_Output_104, __p_K8zQvPE8FQXMr6xFKxZU8i = State_Output_106, __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb = __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb_108, __p_Qc5rZp2zV8KPG9tACLcSGb = State_Output_110, __p_EMRr0mZjl7tQBKKhLrKRZd = State_Output_113, __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK = __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK_115, __p_HsIoUKtgiqCOOO3y4nsvrK = State_Output_117, __p_NRsblKPYEa1LjvsW0pZ0WZ = State_Output_120, __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P = __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P_122, __p_J3h59rv2kEnLfCxBT1ki2P = State_Output_124, __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV = __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV_126, __p_V4h8IF3QNLeNtzfB9RovDV = State_Output_128} : state_6;
                else
                {
                    state_6.__p_LgcK1i5zsrxLKF3nERlq2b = State_Output_56;
                    state_6.__p_AaoV4AMYaquLUiqu94GaDN = Output_58;
                    state_6.__p_AAazI0LlVahP1ToJhpl2OV = State_Output_61;
                    state_6.__p_VXU0mPPgV3XOVa8h0LcRlt = State_Output_63;
                    state_6.__p_HLrgOsa20jJMpoBrqQ1Sgl = State_Output_66;
                    state_6.__p_JIxlRVm6fhZNbzEgadESjA = State_Output_69;
                    state_6.__pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV = __pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV_71;
                    state_6.__p_PsFPOB0ZO4vPCAp6wQflvV = State_Output_73;
                    state_6.__p_LHkKcCk216ROJYoWDzHZCL = Output_77;
                    state_6.__p_DXLT8svVX8XM8pljMTrvKS = State_Output_80;
                    state_6.__p_MGxEuzytm5POiubJVNVeek = State_Output_82;
                    state_6.__p_CQbQ3j9TATQPlqIntDsTn9 = State_Output_84;
                    state_6.__pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw = __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw_86;
                    state_6.__p_HKzZITPZOX8LvG10jgpWcw = State_Output_88;
                    state_6.__p_ABkWNurFFyPMObybM8in6j = State_Output_90;
                    state_6.__pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ = __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ_92;
                    state_6.__p_DYT9ywQyL0NOVHovZM2YmQ = State_Output_94;
                    state_6.__pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb = __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb_96;
                    state_6.__p_MfV8KivL3GfOWasvYJFnAb = State_Output_98;
                    state_6.__p_I90fQDotFc7MObpomzroYO = State_Output_100;
                    state_6.__pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5 = __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5_102;
                    state_6.__p_TGfwEat6LquNqm4wT4hYI5 = State_Output_104;
                    state_6.__p_K8zQvPE8FQXMr6xFKxZU8i = State_Output_106;
                    state_6.__pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb = __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb_108;
                    state_6.__p_Qc5rZp2zV8KPG9tACLcSGb = State_Output_110;
                    state_6.__p_EMRr0mZjl7tQBKKhLrKRZd = State_Output_113;
                    state_6.__pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK = __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK_115;
                    state_6.__p_HsIoUKtgiqCOOO3y4nsvrK = State_Output_117;
                    state_6.__p_NRsblKPYEa1LjvsW0pZ0WZ = State_Output_120;
                    state_6.__pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P = __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P_122;
                    state_6.__p_J3h59rv2kEnLfCxBT1ki2P = State_Output_124;
                    state_6.__pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV = __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV_126;
                    state_6.__p_V4h8IF3QNLeNtzfB9RovDV = State_Output_128;
                }

                outputs_4 = n2.ValueTuple.Create(Output_127);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_129 = outputs_4.Item1;
            Output_Out = __auto_129;
            n3.TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T> that_130 = this;
            if (this.__GetContext__().IsImmutable)
                that_130 = manager_2 != this.__cache_SWZBbXYEY2PMWyU7H5aDcP ? new TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T>(this)
                {__cache_SWZBbXYEY2PMWyU7H5aDcP = manager_2} : that_130;
            else
            {
                this.__cache_SWZBbXYEY2PMWyU7H5aDcP = manager_2;
            }

            return that_130;
        }

        public n3.TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T> __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T> that_0 = this;
            this.__cache_SWZBbXYEY2PMWyU7H5aDcP = null;
            return that_0;
        }

        public n3.TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T> __CreateDefault__()
        {
            n3.TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T> that_0 = this;
            this.__cache_SWZBbXYEY2PMWyU7H5aDcP = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_SWZBbXYEY2PMWyU7H5aDcP);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 319649U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "SWZBbXYEY2PMWyU7H5aDcP", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n20.Manager<n2.ValueTuple<n11.GpuValue<float>, n11.GpuValue<T>, n11.GpuValue<n5.Vector3>>, n2.ValueTuple<n11.GpuValue<T>>> __cache_SWZBbXYEY2PMWyU7H5aDcP = null;
        public TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR(TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T> other): base(other)
        {
            this.__cache_SWZBbXYEY2PMWyU7H5aDcP = other.__cache_SWZBbXYEY2PMWyU7H5aDcP;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_SWZBbXYEY2PMWyU7H5aDcP", in __cache_SWZBbXYEY2PMWyU7H5aDcP));
        }

        internal TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T> __WITH__(n20.Manager<n2.ValueTuple<n11.GpuValue<float>, n11.GpuValue<T>, n11.GpuValue<n5.Vector3>>, n2.ValueTuple<n11.GpuValue<T>>> __cache_SWZBbXYEY2PMWyU7H5aDcP)
        {
            n3.TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T> that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_SWZBbXYEY2PMWyU7H5aDcP != this.__cache_SWZBbXYEY2PMWyU7H5aDcP ? new TriPlanar_CNgu5ElzJK9Pso9J6Q6yaR<T>(this)
                {__cache_SWZBbXYEY2PMWyU7H5aDcP = __cache_SWZBbXYEY2PMWyU7H5aDcP} : that_0;
            else
            {
                this.__cache_SWZBbXYEY2PMWyU7H5aDcP = __cache_SWZBbXYEY2PMWyU7H5aDcP;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "CcoZtWrSwvHOKeat1OIBko", Name = "__CcoZtWrSwvHOKeat1OIBko")]
        [n2.SerializableAttribute]
        public class __CcoZtWrSwvHOKeat1OIBko : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_VXU0mPPgV3XOVa8h0LcRlt);
                n1.CompilationHelper.SafeDispose(this.__p_AaoV4AMYaquLUiqu94GaDN);
                n1.CompilationHelper.SafeDispose(this.__p_HLrgOsa20jJMpoBrqQ1Sgl);
                n1.CompilationHelper.SafeDispose(this.__p_AAazI0LlVahP1ToJhpl2OV);
                n1.CompilationHelper.SafeDispose(this.__p_PsFPOB0ZO4vPCAp6wQflvV);
                n1.CompilationHelper.SafeDispose(this.__p_JIxlRVm6fhZNbzEgadESjA);
                n1.CompilationHelper.SafeDispose(this.__p_Qc5rZp2zV8KPG9tACLcSGb);
                n1.CompilationHelper.SafeDispose(this.__p_K8zQvPE8FQXMr6xFKxZU8i);
                n1.CompilationHelper.SafeDispose(this.__p_I90fQDotFc7MObpomzroYO);
                n1.CompilationHelper.SafeDispose(this.__p_ABkWNurFFyPMObybM8in6j);
                n1.CompilationHelper.SafeDispose(this.__p_LHkKcCk216ROJYoWDzHZCL);
                n1.CompilationHelper.SafeDispose(this.__p_HsIoUKtgiqCOOO3y4nsvrK);
                n1.CompilationHelper.SafeDispose(this.__p_TGfwEat6LquNqm4wT4hYI5);
                n1.CompilationHelper.SafeDispose(this.__p_DYT9ywQyL0NOVHovZM2YmQ);
                n1.CompilationHelper.SafeDispose(this.__p_EMRr0mZjl7tQBKKhLrKRZd);
                n1.CompilationHelper.SafeDispose(this.__p_V4h8IF3QNLeNtzfB9RovDV);
                n1.CompilationHelper.SafeDispose(this.__p_NRsblKPYEa1LjvsW0pZ0WZ);
                n1.CompilationHelper.SafeDispose(this.__p_DXLT8svVX8XM8pljMTrvKS);
                n1.CompilationHelper.SafeDispose(this.__p_J3h59rv2kEnLfCxBT1ki2P);
                n1.CompilationHelper.SafeDispose(this.__p_MfV8KivL3GfOWasvYJFnAb);
                n1.CompilationHelper.SafeDispose(this.__p_HKzZITPZOX8LvG10jgpWcw);
                n1.CompilationHelper.SafeDispose(this.__p_CQbQ3j9TATQPlqIntDsTn9);
                n1.CompilationHelper.SafeDispose(this.__p_MGxEuzytm5POiubJVNVeek);
                n1.CompilationHelper.SafeDispose(this.__p_LgcK1i5zsrxLKF3nERlq2b);
                return;
            }

            [n1.ElementAttribute(TracingId = 319673U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "VXU0mPPgV3XOVa8h0LcRlt", Name = "Pow", IsManaged = true, IsAutoGenerated = true)]
            public n21.Pow_OYho3WrJhN0LWEmoMe81d4<n5.Vector3> __p_VXU0mPPgV3XOVa8h0LcRlt;
            [n1.ElementAttribute(TracingId = 319680U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "AaoV4AMYaquLUiqu94GaDN", Name = "Abs", IsManaged = true, IsAutoGenerated = true)]
            public n21.Abs_HYWPOtC1lkrNB5uGryHr5l<n5.Vector3> __p_AaoV4AMYaquLUiqu94GaDN;
            [n1.ElementAttribute(TracingId = 319689U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "HLrgOsa20jJMpoBrqQ1Sgl", Name = "sumComponent", IsManaged = true, IsAutoGenerated = true)]
            public n21.sumComponent_LdOKHH3PAvJM9rCpHusHUl<n5.Vector3> __p_HLrgOsa20jJMpoBrqQ1Sgl;
            [n1.ElementAttribute(TracingId = 319705U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "AAazI0LlVahP1ToJhpl2OV", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, n5.Vector3> __p_AAazI0LlVahP1ToJhpl2OV;
            [n1.ElementAttribute(TracingId = 319720U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "PsFPOB0ZO4vPCAp6wQflvV", Name = "/", IsManaged = true, IsAutoGenerated = true)]
            public n21.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n5.Vector3> __p_PsFPOB0ZO4vPCAp6wQflvV;
            [n1.ElementAttribute(TracingId = 319728U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "JIxlRVm6fhZNbzEgadESjA", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, n5.Vector3> __p_JIxlRVm6fhZNbzEgadESjA;
            [n1.ElementAttribute(TracingId = 319732U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Qc5rZp2zV8KPG9tACLcSGb", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n23.Invoke_C<T> __p_Qc5rZp2zV8KPG9tACLcSGb;
            [n1.ElementAttribute(TracingId = 319736U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "K8zQvPE8FQXMr6xFKxZU8i", Name = "xy", IsManaged = true, IsAutoGenerated = true)]
            public n24.xy_EiegIBeM6c8OnN5CcRLRyU<n5.Vector3> __p_K8zQvPE8FQXMr6xFKxZU8i;
            [n1.ElementAttribute(TracingId = 319739U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "I90fQDotFc7MObpomzroYO", Name = "xz", IsManaged = true, IsAutoGenerated = true)]
            public n24.xz_QELrHhPP9HQOKXyh2AbSn6<n5.Vector3> __p_I90fQDotFc7MObpomzroYO;
            [n1.ElementAttribute(TracingId = 319744U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "ABkWNurFFyPMObybM8in6j", Name = "yz", IsManaged = true, IsAutoGenerated = true)]
            public n24.yz_UwHE83eg6BmNIdbSAmuyYp<n5.Vector3> __p_ABkWNurFFyPMObybM8in6j;
            [n1.ElementAttribute(TracingId = 319753U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "LHkKcCk216ROJYoWDzHZCL", Name = "x-y-z (split)", IsManaged = true, IsAutoGenerated = true)]
            public n25.xMyMz_split_HhwKvU63boDLFOLEO95pTD __p_LHkKcCk216ROJYoWDzHZCL;
            [n1.ElementAttribute(TracingId = 319763U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "HsIoUKtgiqCOOO3y4nsvrK", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_HsIoUKtgiqCOOO3y4nsvrK;
            [n1.ElementAttribute(TracingId = 319774U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "TGfwEat6LquNqm4wT4hYI5", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n23.Invoke_C<T> __p_TGfwEat6LquNqm4wT4hYI5;
            [n1.ElementAttribute(TracingId = 319783U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "DYT9ywQyL0NOVHovZM2YmQ", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n23.Invoke_C<T> __p_DYT9ywQyL0NOVHovZM2YmQ;
            [n1.ElementAttribute(TracingId = 319788U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "EMRr0mZjl7tQBKKhLrKRZd", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_EMRr0mZjl7tQBKKhLrKRZd;
            [n1.ElementAttribute(TracingId = 319807U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "V4h8IF3QNLeNtzfB9RovDV", Name = "+", IsManaged = true, IsAutoGenerated = true)]
            public n21.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_V4h8IF3QNLeNtzfB9RovDV;
            [n1.ElementAttribute(TracingId = 319826U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "NRsblKPYEa1LjvsW0pZ0WZ", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_NRsblKPYEa1LjvsW0pZ0WZ;
            [n1.ElementAttribute(TracingId = 319835U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "DXLT8svVX8XM8pljMTrvKS", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_DXLT8svVX8XM8pljMTrvKS;
            [n1.ElementAttribute(TracingId = 319839U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "J3h59rv2kEnLfCxBT1ki2P", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_J3h59rv2kEnLfCxBT1ki2P;
            [n1.ElementAttribute(TracingId = 319843U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "MfV8KivL3GfOWasvYJFnAb", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_MfV8KivL3GfOWasvYJFnAb;
            [n1.ElementAttribute(TracingId = 319847U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "HKzZITPZOX8LvG10jgpWcw", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_HKzZITPZOX8LvG10jgpWcw;
            [n1.ElementAttribute(TracingId = 319851U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "CQbQ3j9TATQPlqIntDsTn9", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
            public n24.xyz_T2WwCF9xAltPhlUuLjVDje __p_CQbQ3j9TATQPlqIntDsTn9;
            [n1.ElementAttribute(TracingId = 319854U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "MGxEuzytm5POiubJVNVeek", Name = "PositionWS", IsManaged = true, IsAutoGenerated = true)]
            public n26.PositionWS_EqNTwQZFoLOQdVEmvtk795 __p_MGxEuzytm5POiubJVNVeek;
            [n1.ElementAttribute(TracingId = 319856U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "LgcK1i5zsrxLKF3nERlq2b", Name = "MeshNormalWS", IsManaged = true, IsAutoGenerated = true)]
            public n26.MeshNormalWS_Gppq7KtrvrwLtF4UYBlDgj __p_LgcK1i5zsrxLKF3nERlq2b;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.GpuValue<n5.Vector3>> __pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV = default(n18.Spread<n11.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.GpuValue<n5.Vector3>> __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw = default(n18.Spread<n11.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.AbstractGpuValue> __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ = default(n18.Spread<n11.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.GpuValue<T>> __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb = default(n18.Spread<n11.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.AbstractGpuValue> __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5 = default(n18.Spread<n11.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.AbstractGpuValue> __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb = default(n18.Spread<n11.AbstractGpuValue>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.GpuValue<T>> __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK = default(n18.Spread<n11.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.GpuValue<T>> __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P = default(n18.Spread<n11.GpuValue<T>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.GpuValue<T>> __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV = default(n18.Spread<n11.GpuValue<T>>);
            public __CcoZtWrSwvHOKeat1OIBko(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CcoZtWrSwvHOKeat1OIBko(__CcoZtWrSwvHOKeat1OIBko other): base(other)
            {
                this.__p_VXU0mPPgV3XOVa8h0LcRlt = other.__p_VXU0mPPgV3XOVa8h0LcRlt;
                this.__p_AaoV4AMYaquLUiqu94GaDN = other.__p_AaoV4AMYaquLUiqu94GaDN;
                this.__p_HLrgOsa20jJMpoBrqQ1Sgl = other.__p_HLrgOsa20jJMpoBrqQ1Sgl;
                this.__p_AAazI0LlVahP1ToJhpl2OV = other.__p_AAazI0LlVahP1ToJhpl2OV;
                this.__p_PsFPOB0ZO4vPCAp6wQflvV = other.__p_PsFPOB0ZO4vPCAp6wQflvV;
                this.__p_JIxlRVm6fhZNbzEgadESjA = other.__p_JIxlRVm6fhZNbzEgadESjA;
                this.__p_Qc5rZp2zV8KPG9tACLcSGb = other.__p_Qc5rZp2zV8KPG9tACLcSGb;
                this.__p_K8zQvPE8FQXMr6xFKxZU8i = other.__p_K8zQvPE8FQXMr6xFKxZU8i;
                this.__p_I90fQDotFc7MObpomzroYO = other.__p_I90fQDotFc7MObpomzroYO;
                this.__p_ABkWNurFFyPMObybM8in6j = other.__p_ABkWNurFFyPMObybM8in6j;
                this.__p_LHkKcCk216ROJYoWDzHZCL = other.__p_LHkKcCk216ROJYoWDzHZCL;
                this.__p_HsIoUKtgiqCOOO3y4nsvrK = other.__p_HsIoUKtgiqCOOO3y4nsvrK;
                this.__p_TGfwEat6LquNqm4wT4hYI5 = other.__p_TGfwEat6LquNqm4wT4hYI5;
                this.__p_DYT9ywQyL0NOVHovZM2YmQ = other.__p_DYT9ywQyL0NOVHovZM2YmQ;
                this.__p_EMRr0mZjl7tQBKKhLrKRZd = other.__p_EMRr0mZjl7tQBKKhLrKRZd;
                this.__p_V4h8IF3QNLeNtzfB9RovDV = other.__p_V4h8IF3QNLeNtzfB9RovDV;
                this.__p_NRsblKPYEa1LjvsW0pZ0WZ = other.__p_NRsblKPYEa1LjvsW0pZ0WZ;
                this.__p_DXLT8svVX8XM8pljMTrvKS = other.__p_DXLT8svVX8XM8pljMTrvKS;
                this.__p_J3h59rv2kEnLfCxBT1ki2P = other.__p_J3h59rv2kEnLfCxBT1ki2P;
                this.__p_MfV8KivL3GfOWasvYJFnAb = other.__p_MfV8KivL3GfOWasvYJFnAb;
                this.__p_HKzZITPZOX8LvG10jgpWcw = other.__p_HKzZITPZOX8LvG10jgpWcw;
                this.__p_CQbQ3j9TATQPlqIntDsTn9 = other.__p_CQbQ3j9TATQPlqIntDsTn9;
                this.__p_MGxEuzytm5POiubJVNVeek = other.__p_MGxEuzytm5POiubJVNVeek;
                this.__p_LgcK1i5zsrxLKF3nERlq2b = other.__p_LgcK1i5zsrxLKF3nERlq2b;
                this.__pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV = other.__pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV;
                this.__pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw = other.__pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw;
                this.__pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ = other.__pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ;
                this.__pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb = other.__pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb;
                this.__pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5 = other.__pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5;
                this.__pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb = other.__pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb;
                this.__pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK = other.__pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK;
                this.__pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P = other.__pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P;
                this.__pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV = other.__pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VXU0mPPgV3XOVa8h0LcRlt", in __p_VXU0mPPgV3XOVa8h0LcRlt), n1.CompilationHelper.GetValueOrExisting(values, "__p_AaoV4AMYaquLUiqu94GaDN", in __p_AaoV4AMYaquLUiqu94GaDN), n1.CompilationHelper.GetValueOrExisting(values, "__p_HLrgOsa20jJMpoBrqQ1Sgl", in __p_HLrgOsa20jJMpoBrqQ1Sgl), n1.CompilationHelper.GetValueOrExisting(values, "__p_AAazI0LlVahP1ToJhpl2OV", in __p_AAazI0LlVahP1ToJhpl2OV), n1.CompilationHelper.GetValueOrExisting(values, "__p_PsFPOB0ZO4vPCAp6wQflvV", in __p_PsFPOB0ZO4vPCAp6wQflvV), n1.CompilationHelper.GetValueOrExisting(values, "__p_JIxlRVm6fhZNbzEgadESjA", in __p_JIxlRVm6fhZNbzEgadESjA), n1.CompilationHelper.GetValueOrExisting(values, "__p_Qc5rZp2zV8KPG9tACLcSGb", in __p_Qc5rZp2zV8KPG9tACLcSGb), n1.CompilationHelper.GetValueOrExisting(values, "__p_K8zQvPE8FQXMr6xFKxZU8i", in __p_K8zQvPE8FQXMr6xFKxZU8i), n1.CompilationHelper.GetValueOrExisting(values, "__p_I90fQDotFc7MObpomzroYO", in __p_I90fQDotFc7MObpomzroYO), n1.CompilationHelper.GetValueOrExisting(values, "__p_ABkWNurFFyPMObybM8in6j", in __p_ABkWNurFFyPMObybM8in6j), n1.CompilationHelper.GetValueOrExisting(values, "__p_LHkKcCk216ROJYoWDzHZCL", in __p_LHkKcCk216ROJYoWDzHZCL), n1.CompilationHelper.GetValueOrExisting(values, "__p_HsIoUKtgiqCOOO3y4nsvrK", in __p_HsIoUKtgiqCOOO3y4nsvrK), n1.CompilationHelper.GetValueOrExisting(values, "__p_TGfwEat6LquNqm4wT4hYI5", in __p_TGfwEat6LquNqm4wT4hYI5), n1.CompilationHelper.GetValueOrExisting(values, "__p_DYT9ywQyL0NOVHovZM2YmQ", in __p_DYT9ywQyL0NOVHovZM2YmQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_EMRr0mZjl7tQBKKhLrKRZd", in __p_EMRr0mZjl7tQBKKhLrKRZd), n1.CompilationHelper.GetValueOrExisting(values, "__p_V4h8IF3QNLeNtzfB9RovDV", in __p_V4h8IF3QNLeNtzfB9RovDV), n1.CompilationHelper.GetValueOrExisting(values, "__p_NRsblKPYEa1LjvsW0pZ0WZ", in __p_NRsblKPYEa1LjvsW0pZ0WZ), n1.CompilationHelper.GetValueOrExisting(values, "__p_DXLT8svVX8XM8pljMTrvKS", in __p_DXLT8svVX8XM8pljMTrvKS), n1.CompilationHelper.GetValueOrExisting(values, "__p_J3h59rv2kEnLfCxBT1ki2P", in __p_J3h59rv2kEnLfCxBT1ki2P), n1.CompilationHelper.GetValueOrExisting(values, "__p_MfV8KivL3GfOWasvYJFnAb", in __p_MfV8KivL3GfOWasvYJFnAb), n1.CompilationHelper.GetValueOrExisting(values, "__p_HKzZITPZOX8LvG10jgpWcw", in __p_HKzZITPZOX8LvG10jgpWcw), n1.CompilationHelper.GetValueOrExisting(values, "__p_CQbQ3j9TATQPlqIntDsTn9", in __p_CQbQ3j9TATQPlqIntDsTn9), n1.CompilationHelper.GetValueOrExisting(values, "__p_MGxEuzytm5POiubJVNVeek", in __p_MGxEuzytm5POiubJVNVeek), n1.CompilationHelper.GetValueOrExisting(values, "__p_LgcK1i5zsrxLKF3nERlq2b", in __p_LgcK1i5zsrxLKF3nERlq2b), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV", in __pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw", in __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ", in __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb", in __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5", in __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb", in __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK", in __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P", in __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV", in __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV));
            }

            internal __CcoZtWrSwvHOKeat1OIBko __WITH__(n21.Pow_OYho3WrJhN0LWEmoMe81d4<n5.Vector3> __p_VXU0mPPgV3XOVa8h0LcRlt, n21.Abs_HYWPOtC1lkrNB5uGryHr5l<n5.Vector3> __p_AaoV4AMYaquLUiqu94GaDN, n21.sumComponent_LdOKHH3PAvJM9rCpHusHUl<n5.Vector3> __p_HLrgOsa20jJMpoBrqQ1Sgl, n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, n5.Vector3> __p_AAazI0LlVahP1ToJhpl2OV, n21.OperatorDivide_DkVxI7rpQSdP4cSJ43xq6M<n5.Vector3> __p_PsFPOB0ZO4vPCAp6wQflvV, n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, n5.Vector3> __p_JIxlRVm6fhZNbzEgadESjA, n23.Invoke_C<T> __p_Qc5rZp2zV8KPG9tACLcSGb, n24.xy_EiegIBeM6c8OnN5CcRLRyU<n5.Vector3> __p_K8zQvPE8FQXMr6xFKxZU8i, n24.xz_QELrHhPP9HQOKXyh2AbSn6<n5.Vector3> __p_I90fQDotFc7MObpomzroYO, n24.yz_UwHE83eg6BmNIdbSAmuyYp<n5.Vector3> __p_ABkWNurFFyPMObybM8in6j, n25.xMyMz_split_HhwKvU63boDLFOLEO95pTD __p_LHkKcCk216ROJYoWDzHZCL, n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_HsIoUKtgiqCOOO3y4nsvrK, n23.Invoke_C<T> __p_TGfwEat6LquNqm4wT4hYI5, n23.Invoke_C<T> __p_DYT9ywQyL0NOVHovZM2YmQ, n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_EMRr0mZjl7tQBKKhLrKRZd, n21.OperatorPlus_AYSFYgf8yYbNvItIkWCXlg<T> __p_V4h8IF3QNLeNtzfB9RovDV, n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_NRsblKPYEa1LjvsW0pZ0WZ, n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, T> __p_DXLT8svVX8XM8pljMTrvKS, n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_J3h59rv2kEnLfCxBT1ki2P, n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<T> __p_MfV8KivL3GfOWasvYJFnAb, n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_HKzZITPZOX8LvG10jgpWcw, n24.xyz_T2WwCF9xAltPhlUuLjVDje __p_CQbQ3j9TATQPlqIntDsTn9, n26.PositionWS_EqNTwQZFoLOQdVEmvtk795 __p_MGxEuzytm5POiubJVNVeek, n26.MeshNormalWS_Gppq7KtrvrwLtF4UYBlDgj __p_LgcK1i5zsrxLKF3nERlq2b, n18.Spread<n11.GpuValue<n5.Vector3>> __pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV, n18.Spread<n11.GpuValue<n5.Vector3>> __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw, n18.Spread<n11.AbstractGpuValue> __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ, n18.Spread<n11.GpuValue<T>> __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb, n18.Spread<n11.AbstractGpuValue> __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5, n18.Spread<n11.AbstractGpuValue> __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb, n18.Spread<n11.GpuValue<T>> __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK, n18.Spread<n11.GpuValue<T>> __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P, n18.Spread<n11.GpuValue<T>> __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV)
            {
                __CcoZtWrSwvHOKeat1OIBko that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_VXU0mPPgV3XOVa8h0LcRlt != this.__p_VXU0mPPgV3XOVa8h0LcRlt || __p_AaoV4AMYaquLUiqu94GaDN != this.__p_AaoV4AMYaquLUiqu94GaDN || __p_HLrgOsa20jJMpoBrqQ1Sgl != this.__p_HLrgOsa20jJMpoBrqQ1Sgl || __p_AAazI0LlVahP1ToJhpl2OV != this.__p_AAazI0LlVahP1ToJhpl2OV || __p_PsFPOB0ZO4vPCAp6wQflvV != this.__p_PsFPOB0ZO4vPCAp6wQflvV || __p_JIxlRVm6fhZNbzEgadESjA != this.__p_JIxlRVm6fhZNbzEgadESjA || __p_Qc5rZp2zV8KPG9tACLcSGb != this.__p_Qc5rZp2zV8KPG9tACLcSGb || __p_K8zQvPE8FQXMr6xFKxZU8i != this.__p_K8zQvPE8FQXMr6xFKxZU8i || __p_I90fQDotFc7MObpomzroYO != this.__p_I90fQDotFc7MObpomzroYO || __p_ABkWNurFFyPMObybM8in6j != this.__p_ABkWNurFFyPMObybM8in6j || __p_LHkKcCk216ROJYoWDzHZCL != this.__p_LHkKcCk216ROJYoWDzHZCL || __p_HsIoUKtgiqCOOO3y4nsvrK != this.__p_HsIoUKtgiqCOOO3y4nsvrK || __p_TGfwEat6LquNqm4wT4hYI5 != this.__p_TGfwEat6LquNqm4wT4hYI5 || __p_DYT9ywQyL0NOVHovZM2YmQ != this.__p_DYT9ywQyL0NOVHovZM2YmQ || __p_EMRr0mZjl7tQBKKhLrKRZd != this.__p_EMRr0mZjl7tQBKKhLrKRZd || __p_V4h8IF3QNLeNtzfB9RovDV != this.__p_V4h8IF3QNLeNtzfB9RovDV || __p_NRsblKPYEa1LjvsW0pZ0WZ != this.__p_NRsblKPYEa1LjvsW0pZ0WZ || __p_DXLT8svVX8XM8pljMTrvKS != this.__p_DXLT8svVX8XM8pljMTrvKS || __p_J3h59rv2kEnLfCxBT1ki2P != this.__p_J3h59rv2kEnLfCxBT1ki2P || __p_MfV8KivL3GfOWasvYJFnAb != this.__p_MfV8KivL3GfOWasvYJFnAb || __p_HKzZITPZOX8LvG10jgpWcw != this.__p_HKzZITPZOX8LvG10jgpWcw || __p_CQbQ3j9TATQPlqIntDsTn9 != this.__p_CQbQ3j9TATQPlqIntDsTn9 || __p_MGxEuzytm5POiubJVNVeek != this.__p_MGxEuzytm5POiubJVNVeek || __p_LgcK1i5zsrxLKF3nERlq2b != this.__p_LgcK1i5zsrxLKF3nERlq2b || __pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV != this.__pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV || __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw != this.__pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw || __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ != this.__pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ || __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb != this.__pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb || __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5 != this.__pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5 || __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb != this.__pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb || __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK != this.__pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK || __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P != this.__pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P || __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV != this.__pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV ? new __CcoZtWrSwvHOKeat1OIBko(this)
                    {__p_VXU0mPPgV3XOVa8h0LcRlt = __p_VXU0mPPgV3XOVa8h0LcRlt, __p_AaoV4AMYaquLUiqu94GaDN = __p_AaoV4AMYaquLUiqu94GaDN, __p_HLrgOsa20jJMpoBrqQ1Sgl = __p_HLrgOsa20jJMpoBrqQ1Sgl, __p_AAazI0LlVahP1ToJhpl2OV = __p_AAazI0LlVahP1ToJhpl2OV, __p_PsFPOB0ZO4vPCAp6wQflvV = __p_PsFPOB0ZO4vPCAp6wQflvV, __p_JIxlRVm6fhZNbzEgadESjA = __p_JIxlRVm6fhZNbzEgadESjA, __p_Qc5rZp2zV8KPG9tACLcSGb = __p_Qc5rZp2zV8KPG9tACLcSGb, __p_K8zQvPE8FQXMr6xFKxZU8i = __p_K8zQvPE8FQXMr6xFKxZU8i, __p_I90fQDotFc7MObpomzroYO = __p_I90fQDotFc7MObpomzroYO, __p_ABkWNurFFyPMObybM8in6j = __p_ABkWNurFFyPMObybM8in6j, __p_LHkKcCk216ROJYoWDzHZCL = __p_LHkKcCk216ROJYoWDzHZCL, __p_HsIoUKtgiqCOOO3y4nsvrK = __p_HsIoUKtgiqCOOO3y4nsvrK, __p_TGfwEat6LquNqm4wT4hYI5 = __p_TGfwEat6LquNqm4wT4hYI5, __p_DYT9ywQyL0NOVHovZM2YmQ = __p_DYT9ywQyL0NOVHovZM2YmQ, __p_EMRr0mZjl7tQBKKhLrKRZd = __p_EMRr0mZjl7tQBKKhLrKRZd, __p_V4h8IF3QNLeNtzfB9RovDV = __p_V4h8IF3QNLeNtzfB9RovDV, __p_NRsblKPYEa1LjvsW0pZ0WZ = __p_NRsblKPYEa1LjvsW0pZ0WZ, __p_DXLT8svVX8XM8pljMTrvKS = __p_DXLT8svVX8XM8pljMTrvKS, __p_J3h59rv2kEnLfCxBT1ki2P = __p_J3h59rv2kEnLfCxBT1ki2P, __p_MfV8KivL3GfOWasvYJFnAb = __p_MfV8KivL3GfOWasvYJFnAb, __p_HKzZITPZOX8LvG10jgpWcw = __p_HKzZITPZOX8LvG10jgpWcw, __p_CQbQ3j9TATQPlqIntDsTn9 = __p_CQbQ3j9TATQPlqIntDsTn9, __p_MGxEuzytm5POiubJVNVeek = __p_MGxEuzytm5POiubJVNVeek, __p_LgcK1i5zsrxLKF3nERlq2b = __p_LgcK1i5zsrxLKF3nERlq2b, __pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV = __pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV, __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw = __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw, __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ = __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ, __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb = __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb, __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5 = __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5, __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb = __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb, __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK = __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK, __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P = __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P, __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV = __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV} : that_0;
                else
                {
                    this.__p_VXU0mPPgV3XOVa8h0LcRlt = __p_VXU0mPPgV3XOVa8h0LcRlt;
                    this.__p_AaoV4AMYaquLUiqu94GaDN = __p_AaoV4AMYaquLUiqu94GaDN;
                    this.__p_HLrgOsa20jJMpoBrqQ1Sgl = __p_HLrgOsa20jJMpoBrqQ1Sgl;
                    this.__p_AAazI0LlVahP1ToJhpl2OV = __p_AAazI0LlVahP1ToJhpl2OV;
                    this.__p_PsFPOB0ZO4vPCAp6wQflvV = __p_PsFPOB0ZO4vPCAp6wQflvV;
                    this.__p_JIxlRVm6fhZNbzEgadESjA = __p_JIxlRVm6fhZNbzEgadESjA;
                    this.__p_Qc5rZp2zV8KPG9tACLcSGb = __p_Qc5rZp2zV8KPG9tACLcSGb;
                    this.__p_K8zQvPE8FQXMr6xFKxZU8i = __p_K8zQvPE8FQXMr6xFKxZU8i;
                    this.__p_I90fQDotFc7MObpomzroYO = __p_I90fQDotFc7MObpomzroYO;
                    this.__p_ABkWNurFFyPMObybM8in6j = __p_ABkWNurFFyPMObybM8in6j;
                    this.__p_LHkKcCk216ROJYoWDzHZCL = __p_LHkKcCk216ROJYoWDzHZCL;
                    this.__p_HsIoUKtgiqCOOO3y4nsvrK = __p_HsIoUKtgiqCOOO3y4nsvrK;
                    this.__p_TGfwEat6LquNqm4wT4hYI5 = __p_TGfwEat6LquNqm4wT4hYI5;
                    this.__p_DYT9ywQyL0NOVHovZM2YmQ = __p_DYT9ywQyL0NOVHovZM2YmQ;
                    this.__p_EMRr0mZjl7tQBKKhLrKRZd = __p_EMRr0mZjl7tQBKKhLrKRZd;
                    this.__p_V4h8IF3QNLeNtzfB9RovDV = __p_V4h8IF3QNLeNtzfB9RovDV;
                    this.__p_NRsblKPYEa1LjvsW0pZ0WZ = __p_NRsblKPYEa1LjvsW0pZ0WZ;
                    this.__p_DXLT8svVX8XM8pljMTrvKS = __p_DXLT8svVX8XM8pljMTrvKS;
                    this.__p_J3h59rv2kEnLfCxBT1ki2P = __p_J3h59rv2kEnLfCxBT1ki2P;
                    this.__p_MfV8KivL3GfOWasvYJFnAb = __p_MfV8KivL3GfOWasvYJFnAb;
                    this.__p_HKzZITPZOX8LvG10jgpWcw = __p_HKzZITPZOX8LvG10jgpWcw;
                    this.__p_CQbQ3j9TATQPlqIntDsTn9 = __p_CQbQ3j9TATQPlqIntDsTn9;
                    this.__p_MGxEuzytm5POiubJVNVeek = __p_MGxEuzytm5POiubJVNVeek;
                    this.__p_LgcK1i5zsrxLKF3nERlq2b = __p_LgcK1i5zsrxLKF3nERlq2b;
                    this.__pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV = __pin_group_Input_In_PsFPOB0ZO4vPCAp6wQflvV;
                    this.__pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw = __pin_group_Input_In_HKzZITPZOX8LvG10jgpWcw;
                    this.__pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ = __pin_group_Parameters_In_DYT9ywQyL0NOVHovZM2YmQ;
                    this.__pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb = __pin_group_Input_In_MfV8KivL3GfOWasvYJFnAb;
                    this.__pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5 = __pin_group_Parameters_In_TGfwEat6LquNqm4wT4hYI5;
                    this.__pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb = __pin_group_Parameters_In_Qc5rZp2zV8KPG9tACLcSGb;
                    this.__pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK = __pin_group_Input_In_HsIoUKtgiqCOOO3y4nsvrK;
                    this.__pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P = __pin_group_Input_In_J3h59rv2kEnLfCxBT1ki2P;
                    this.__pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV = __pin_group_Input_In_V4h8IF3QNLeNtzfB9RovDV;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 319942U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "UGVz4QabjSZOUCs75L1eCQ", Name = "SurfaceBump_UGVz4QabjSZOUCs75L1eCQ")]
    [n2.SerializableAttribute]
    public class SurfaceBump_UGVz4QabjSZOUCs75L1eCQ : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SurfaceBump_UGVz4QabjSZOUCs75L1eCQ Create(n1.NodeContext Node_Context)
        {
            var instance = new SurfaceBump_UGVz4QabjSZOUCs75L1eCQ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SurfaceBump_UGVz4QabjSZOUCs75L1eCQ CreateDefault()
        {
            var instance = new SurfaceBump_UGVz4QabjSZOUCs75L1eCQ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SurfaceBump_UGVz4QabjSZOUCs75L1eCQ Update(n10.Material Material_In, n11.GpuValue<float> BumpT_In, [n4.SerializedDefaultValueAttribute("0.01", false)] n11.GpuValue<float> Bump_Amt_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Object_D_World_Space_In, n11.GpuValue<n5.Vector3> TDomain_In, out n10.Material Output_Out)
        {
            bool __auto_0 = this.Changed;
            n1.CompilationHelper.WritePin(this.__p_P3iiaBw2ZqHNmwqETSCr3y.Inputs[0], ref Material_In);
            var State_Output_2 = this.__p_Irmz5lrppt5Pw03jGTIi3Q.Update(Simulate_In: __auto_0, Output_Out: out bool Output_1);
            int Frames_3 = 2;
            bool Retriggerable_4 = false;
            bool Reset_5 = false;
            var Output_8 = this.__p_KIPsvd56q0gMme7MdvqKqO.Update(Set_In: Output_1, Frames_In: Frames_3, Retriggerable_In: Retriggerable_4, Reset_In: Reset_5, Value_Out: out bool Value_6, Inverse_Output_Out: out bool Inverse_Output_7);
            bool __pad_BLGQ1kbmnaeNX4heX2sF4d_9 = Value_6;
            bool Dispose_Cached_Outputs_10 = false;
            var manager_11 = this.__cache_Ax5MlV6O7nhONaXANu22wj;
            if (manager_11 is null)
            {
                manager_11 = new n20.Manager<n2.ValueTuple<n11.GpuValue<float>, n11.GpuValue<float>, bool, n11.GpuValue<n5.Vector3>>, n2.ValueTuple<n8.IComputeNode>>(n2.ValueTuple.Create(default(n8.IComputeNode)));
            }

            var inputs_12 = (BumpT_In, Bump_Amt_In, Object_D_World_Space_In, TDomain_In);
            var outputs_13 = manager_11.Outputs;
            var Has_Changed_14 = __pad_BLGQ1kbmnaeNX4heX2sF4d_9 || manager_11.InputsChanged(inputs_12);
            if (Has_Changed_14)
            {
                if (Dispose_Cached_Outputs_10)
                    manager_11.DisposeOutputs();
                var state_15 = n1.CompilationHelper.Restore<__B4tfHGh6iUjOrfMiSlcfQ3>(manager_11.State, __GetContext__());
                if (state_15 == null)
                {
                    state_15 = new __B4tfHGh6iUjOrfMiSlcfQ3(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_RVXv87y36YHORjScZnUTJ2 = n19._Operations_.CreateDefault<n11.GpuValue<n5.Vector4>>(), __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF = n19._Operations_.CreateDefault<n11.GpuValue<n5.Vector3>>(), __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc = n19._Operations_.CreateDefault<n11.AbstractGpuValue>(), __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO = n19._Operations_.CreateDefault<n11.GpuValue<float>>()};
                    n1.NodeContext Node_Context_16 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "Jb4dnKTUy5cNfg0KRWD0PS", 319966U);
                    var Output_17 = n27.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<n5.Vector3>.Create(Node_Context: Node_Context_16);
                    state_15.__p_Jb4dnKTUy5cNfg0KRWD0PS = Output_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "KnaTsYM9RsHQQgrVK27Hdc", 319976U);
                    var Output_19 = n23.Invoke_C<float>.Create(Node_Context: Node_Context_18);
                    state_15.__p_KnaTsYM9RsHQQgrVK27Hdc = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "IM9PaxNBTRzLcyNkXadtvX", 319986U);
                    var Output_21 = n24.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_20);
                    state_15.__p_IM9PaxNBTRzLcyNkXadtvX = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "IoxIdzBb7FLNCAnPvY8YCh", 319992U);
                    var Output_23 = n26.PositionWS_EqNTwQZFoLOQdVEmvtk795.Create(Node_Context: Node_Context_22);
                    state_15.__p_IoxIdzBb7FLNCAnPvY8YCh = Output_23;
                    n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "JJKf8vXkjPjOcoSPdL2wfO", 319997U);
                    var Output_25 = n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_24);
                    state_15.__p_JJKf8vXkjPjOcoSPdL2wfO = Output_25;
                    n1.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "NI8IUOjlzJKOmVMzPRR6Ni", 320035U);
                    var Output_27 = n26.Position_PeLDdeSku4ANhU5oe5SfPy.Create(Node_Context: Node_Context_26);
                    state_15.__p_NI8IUOjlzJKOmVMzPRR6Ni = Output_27;
                    n1.NodeContext Node_Context_28 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "TmHL9udycKxOvQdFmZaoyu", 320055U);
                    var Output_29 = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4>.Create(Node_Context: Node_Context_28);
                    state_15.__p_TmHL9udycKxOvQdFmZaoyu = Output_29;
                    n1.NodeContext Node_Context_30 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "RDG154mUTKPLwCffxUAWgI", 320067U);
                    var Output_31 = n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float>.Create(Node_Context: Node_Context_30);
                    state_15.__p_RDG154mUTKPLwCffxUAWgI = Output_31;
                    var node_32 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "FuseGeometryBumpExtension", "Stride.Rendering.Experimental.ShaderFX");
                    state_15.__p_NHto1xorZ4TOreI6U1O9m4 = node_32;
                    n1.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "HsfzqZnLmXrQS3LbPsmLte", 320085U);
                    var Output_34 = n28.xPyPzPw_join_BGVj6H1I9pwLDUpQUyUl56.Create(Node_Context: Node_Context_33);
                    state_15.__p_HsfzqZnLmXrQS3LbPsmLte = Output_34;
                    n1.NodeContext Node_Context_35 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "MkfCAzvzzWsPwwNyPypy45", 320094U);
                    var Output_36 = n25.xMyMz_split_HhwKvU63boDLFOLEO95pTD.Create(Node_Context: Node_Context_35);
                    state_15.__p_MkfCAzvzzWsPwwNyPypy45 = Output_36;
                }

                float __pad_FSimlSPC18KLqSxRWFba7n_37 = __slot_FSimlSPC18KLqSxRWFba7n;
                n16.ObjectHelpers.IsAssigned(x: TDomain_In, result: out bool Result_38, notAssigned: out bool Not_Assigned_39);
                int Index_40 = n2.Convert.ToInt32(Result_38);
                bool __pad_NV2j4wKGb1QL2ztmE1SMNI_41 = Object_D_World_Space_In;
                int Index_42 = n2.Convert.ToInt32(__pad_NV2j4wKGb1QL2ztmE1SMNI_41);
                var State_Output_44 = state_15.__p_NI8IUOjlzJKOmVMzPRR6Ni.Update(Output_Out: out n11.GpuValue<n5.Vector4> Output_43);
                var State_Output_46 = state_15.__p_IoxIdzBb7FLNCAnPvY8YCh.Update(Output_Out: out n11.GpuValue<n5.Vector4> Output_45);
                var builder_47 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_RVXv87y36YHORjScZnUTJ2, 2);
                builder_47.Add(Output_43);
                builder_47.Add(Output_45);
                var __pin_group_Input_In_RVXv87y36YHORjScZnUTJ2_48 = builder_47.Commit();
                n30._Operations_.Switch<n11.GpuValue<n5.Vector4>, n29.__AdaptiveImplementations__O1Y26euhDfkOXD56tZlYl5>(Index_In: Index_42, Input_In: __pin_group_Input_In_RVXv87y36YHORjScZnUTJ2_48, Output_Out: out n11.GpuValue<n5.Vector4> Output_49);
                var State_Output_51 = state_15.__p_IM9PaxNBTRzLcyNkXadtvX.Update(Input_In: Output_49, Output_Out: out n11.GpuValue<n5.Vector3> Output_50);
                var builder_52 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF, 2);
                builder_52.Add(Output_50);
                builder_52.Add(TDomain_In);
                var __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF_53 = builder_52.Commit();
                n30._Operations_.Switch<n11.GpuValue<n5.Vector3>, n29.__AdaptiveImplementations__O1Y26euhDfkOXD56tZlYl5>(Index_In: Index_40, Input_In: __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF_53, Output_Out: out n11.GpuValue<n5.Vector3> Output_54);
                n11.GpuValue<float> Epsilon_55 = state_15.__monadBuilder_SseE3wI039BNFbSb6cuLrn.Return(__pad_FSimlSPC18KLqSxRWFba7n_37);
                var State_Output_57 = state_15.__p_Jb4dnKTUy5cNfg0KRWD0PS.Update(Function_In: BumpT_In, Position_In: Output_54, Epsilon_In: Epsilon_55, Output_Out: out n11.GpuValue<n5.Vector3> Output_56);
                var builder_58 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc, 1);
                builder_58.Add(Output_54);
                var __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc_59 = builder_58.Commit();
                var State_Output_61 = state_15.__p_KnaTsYM9RsHQQgrVK27Hdc.Update(Function_In: BumpT_In, Parameters_In: __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc_59, Output_Out: out n11.GpuValue<float> Output_60);
                var Output_65 = state_15.__p_MkfCAzvzzWsPwwNyPypy45.Update(value_In: Output_56, x_Out: out n11.GpuValue<float> x_62, y_Out: out n11.GpuValue<float> y_63, z_Out: out n11.GpuValue<float> z_64);
                var State_Output_67 = state_15.__p_HsfzqZnLmXrQS3LbPsmLte.Update(x_In: Output_60, y_In: x_62, z_In: y_63, w_In: z_64, Output_Out: out n11.GpuValue<n5.Vector4> Output_66);
                var State_Output_71 = state_15.__p_TmHL9udycKxOvQdFmZaoyu.Update(GpuValue_In: Output_66, Output_Out: out n6.SetVar<n5.Vector4> Output_68, Original_Shader_Source_Out: out n7.ToShaderFX<n5.Vector4> Original_Shader_Source_69, Shader_Code_Out: out string Shader_Code_70);
                n1.CompilationHelper.WritePin(state_15.__p_NHto1xorZ4TOreI6U1O9m4.Inputs[0], ref Output_68);
                float Input_2_72 = 0.1F;
                n11.GpuValue<float> Input_2_73 = state_15.__monadBuilder_T0HeuwM3L8TMWWgXr7wqtR.Return(Input_2_72);
                var builder_74 = n4.CollectionBuilders.GetBuilder(state_15.__pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO, 2);
                builder_74.Add(Bump_Amt_In);
                builder_74.Add(Input_2_73);
                var __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO_75 = builder_74.Commit();
                var State_Output_77 = state_15.__p_JJKf8vXkjPjOcoSPdL2wfO.Update(Input_In: __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO_75, Output_Out: out n11.GpuValue<float> Output_76);
                var State_Output_81 = state_15.__p_RDG154mUTKPLwCffxUAWgI.Update(GpuValue_In: Output_76, Output_Out: out n6.SetVar<float> Output_78, Original_Shader_Source_Out: out n7.ToShaderFX<float> Original_Shader_Source_79, Shader_Code_Out: out string Shader_Code_80);
                n1.CompilationHelper.WritePin(state_15.__p_NHto1xorZ4TOreI6U1O9m4.Inputs[1], ref Output_78);
                n1.CompilationHelper.ReadPin(state_15.__p_NHto1xorZ4TOreI6U1O9m4.Outputs[0], out n8.IComputeNode out_82);
                if (state_15.__GetContext__().IsImmutable)
                    state_15 = Object_D_World_Space_In != state_15.__slot_NV2j4wKGb1QL2ztmE1SMNI || State_Output_44 != state_15.__p_NI8IUOjlzJKOmVMzPRR6Ni || State_Output_46 != state_15.__p_IoxIdzBb7FLNCAnPvY8YCh || __pin_group_Input_In_RVXv87y36YHORjScZnUTJ2_48 != state_15.__pin_group_Input_In_RVXv87y36YHORjScZnUTJ2 || State_Output_51 != state_15.__p_IM9PaxNBTRzLcyNkXadtvX || __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF_53 != state_15.__pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF || State_Output_57 != state_15.__p_Jb4dnKTUy5cNfg0KRWD0PS || __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc_59 != state_15.__pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc || State_Output_61 != state_15.__p_KnaTsYM9RsHQQgrVK27Hdc || Output_65 != state_15.__p_MkfCAzvzzWsPwwNyPypy45 || State_Output_67 != state_15.__p_HsfzqZnLmXrQS3LbPsmLte || State_Output_71 != state_15.__p_TmHL9udycKxOvQdFmZaoyu || state_15.__p_NHto1xorZ4TOreI6U1O9m4 != state_15.__p_NHto1xorZ4TOreI6U1O9m4 || __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO_75 != state_15.__pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO || State_Output_77 != state_15.__p_JJKf8vXkjPjOcoSPdL2wfO || State_Output_81 != state_15.__p_RDG154mUTKPLwCffxUAWgI ? new __B4tfHGh6iUjOrfMiSlcfQ3(state_15)
                    {__slot_NV2j4wKGb1QL2ztmE1SMNI = Object_D_World_Space_In, __p_NI8IUOjlzJKOmVMzPRR6Ni = State_Output_44, __p_IoxIdzBb7FLNCAnPvY8YCh = State_Output_46, __pin_group_Input_In_RVXv87y36YHORjScZnUTJ2 = __pin_group_Input_In_RVXv87y36YHORjScZnUTJ2_48, __p_IM9PaxNBTRzLcyNkXadtvX = State_Output_51, __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF = __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF_53, __p_Jb4dnKTUy5cNfg0KRWD0PS = State_Output_57, __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc = __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc_59, __p_KnaTsYM9RsHQQgrVK27Hdc = State_Output_61, __p_MkfCAzvzzWsPwwNyPypy45 = Output_65, __p_HsfzqZnLmXrQS3LbPsmLte = State_Output_67, __p_TmHL9udycKxOvQdFmZaoyu = State_Output_71, __p_NHto1xorZ4TOreI6U1O9m4 = state_15.__p_NHto1xorZ4TOreI6U1O9m4, __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO = __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO_75, __p_JJKf8vXkjPjOcoSPdL2wfO = State_Output_77, __p_RDG154mUTKPLwCffxUAWgI = State_Output_81} : state_15;
                else
                {
                    state_15.__slot_NV2j4wKGb1QL2ztmE1SMNI = Object_D_World_Space_In;
                    state_15.__p_NI8IUOjlzJKOmVMzPRR6Ni = State_Output_44;
                    state_15.__p_IoxIdzBb7FLNCAnPvY8YCh = State_Output_46;
                    state_15.__pin_group_Input_In_RVXv87y36YHORjScZnUTJ2 = __pin_group_Input_In_RVXv87y36YHORjScZnUTJ2_48;
                    state_15.__p_IM9PaxNBTRzLcyNkXadtvX = State_Output_51;
                    state_15.__pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF = __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF_53;
                    state_15.__p_Jb4dnKTUy5cNfg0KRWD0PS = State_Output_57;
                    state_15.__pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc = __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc_59;
                    state_15.__p_KnaTsYM9RsHQQgrVK27Hdc = State_Output_61;
                    state_15.__p_MkfCAzvzzWsPwwNyPypy45 = Output_65;
                    state_15.__p_HsfzqZnLmXrQS3LbPsmLte = State_Output_67;
                    state_15.__p_TmHL9udycKxOvQdFmZaoyu = State_Output_71;
                    state_15.__p_NHto1xorZ4TOreI6U1O9m4 = state_15.__p_NHto1xorZ4TOreI6U1O9m4;
                    state_15.__pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO = __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO_75;
                    state_15.__p_JJKf8vXkjPjOcoSPdL2wfO = State_Output_77;
                    state_15.__p_RDG154mUTKPLwCffxUAWgI = State_Output_81;
                }

                outputs_13 = n2.ValueTuple.Create(out_82);
                manager_11 = manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10, state_15, outputs_13);
            }
            else
            {
                manager_11.Update(inputs_12, __GetContext__().IsImmutable, Dispose_Cached_Outputs_10);
            }

            var __auto_83 = outputs_13.Item1;
            n1.CompilationHelper.WritePin(this.__p_P3iiaBw2ZqHNmwqETSCr3y.Inputs[1], ref __auto_83);
            n1.CompilationHelper.ReadPin(this.__p_P3iiaBw2ZqHNmwqETSCr3y.Outputs[0], out n10.Material out_84);
            bool __auto_85 = Has_Changed_14;
            Output_Out = out_84;
            n3.SurfaceBump_UGVz4QabjSZOUCs75L1eCQ that_86 = this;
            if (this.__GetContext__().IsImmutable)
                that_86 = this.__p_P3iiaBw2ZqHNmwqETSCr3y != this.__p_P3iiaBw2ZqHNmwqETSCr3y || State_Output_2 != this.__p_Irmz5lrppt5Pw03jGTIi3Q || Output_8 != this.__p_KIPsvd56q0gMme7MdvqKqO || Value_6 != this.__slot_BLGQ1kbmnaeNX4heX2sF4d || manager_11 != this.__cache_Ax5MlV6O7nhONaXANu22wj || Has_Changed_14 != this.Changed ? new SurfaceBump_UGVz4QabjSZOUCs75L1eCQ(this)
                {__p_P3iiaBw2ZqHNmwqETSCr3y = this.__p_P3iiaBw2ZqHNmwqETSCr3y, __p_Irmz5lrppt5Pw03jGTIi3Q = State_Output_2, __p_KIPsvd56q0gMme7MdvqKqO = Output_8, __slot_BLGQ1kbmnaeNX4heX2sF4d = Value_6, __cache_Ax5MlV6O7nhONaXANu22wj = manager_11, Changed = Has_Changed_14} : that_86;
            else
            {
                this.__p_P3iiaBw2ZqHNmwqETSCr3y = this.__p_P3iiaBw2ZqHNmwqETSCr3y;
                this.__p_Irmz5lrppt5Pw03jGTIi3Q = State_Output_2;
                this.__p_KIPsvd56q0gMme7MdvqKqO = Output_8;
                this.__slot_BLGQ1kbmnaeNX4heX2sF4d = Value_6;
                this.__cache_Ax5MlV6O7nhONaXANu22wj = manager_11;
                this.Changed = Has_Changed_14;
            }

            return that_86;
        }

        public n3.SurfaceBump_UGVz4QabjSZOUCs75L1eCQ __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "Irmz5lrppt5Pw03jGTIi3Q", 320119U);
            var Output_1 = n30.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "KIPsvd56q0gMme7MdvqKqO", 320127U);
            var Output_3 = n30.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX.Create(Node_Context: Node_Context_2);
            var node_4 = n1.CompilationHelper.CreateNodeById(Node_Context, "MaterialExtension", "Stride.Advanced.Materials");
            n3.SurfaceBump_UGVz4QabjSZOUCs75L1eCQ that_5 = this;
            this.__slot_BLGQ1kbmnaeNX4heX2sF4d = false;
            this.Changed = false;
            this.__p_Irmz5lrppt5Pw03jGTIi3Q = Output_1;
            this.__p_KIPsvd56q0gMme7MdvqKqO = Output_3;
            this.__p_P3iiaBw2ZqHNmwqETSCr3y = node_4;
            this.__cache_Ax5MlV6O7nhONaXANu22wj = null;
            return that_5;
        }

        public n3.SurfaceBump_UGVz4QabjSZOUCs75L1eCQ __CreateDefault__()
        {
            n3.SurfaceBump_UGVz4QabjSZOUCs75L1eCQ that_0 = this;
            this.__slot_BLGQ1kbmnaeNX4heX2sF4d = false;
            this.Changed = false;
            this.__p_P3iiaBw2ZqHNmwqETSCr3y = default(n1.IVLNode);
            this.__p_Irmz5lrppt5Pw03jGTIi3Q = n30.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__p_KIPsvd56q0gMme7MdvqKqO = n30.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX.CreateDefault();
            this.__cache_Ax5MlV6O7nhONaXANu22wj = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_P3iiaBw2ZqHNmwqETSCr3y);
            n1.CompilationHelper.SafeDispose(this.__p_Irmz5lrppt5Pw03jGTIi3Q);
            n1.CompilationHelper.SafeDispose(this.__p_KIPsvd56q0gMme7MdvqKqO);
            n1.CompilationHelper.SafeDispose(this.__cache_Ax5MlV6O7nhONaXANu22wj);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 320108U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "BLGQ1kbmnaeNX4heX2sF4d", Name = "__slot_BLGQ1kbmnaeNX4heX2sF4d")]
        public bool __slot_BLGQ1kbmnaeNX4heX2sF4d;
        [n1.ElementAttribute(TracingId = 320152U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "A0gD4qsmCagOmE4eeIekX1", Name = "__slot_A0gD4qsmCagOmE4eeIekX1")]
        public static string __slot_A0gD4qsmCagOmE4eeIekX1 = "Nasty";
        [n1.ElementAttribute(TracingId = 320149U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Sn7VjAe3kNnOzosQmsY2GL", Name = "Changed")]
        public bool Changed;
        [n1.ElementAttribute(TracingId = 320139U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "P3iiaBw2ZqHNmwqETSCr3y", Name = "MaterialExtension", IsManaged = true, IsAutoGenerated = true, NodeName = "MaterialExtension", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_P3iiaBw2ZqHNmwqETSCr3y;
        [n1.ElementAttribute(TracingId = 320119U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Irmz5lrppt5Pw03jGTIi3Q", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n30.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_Irmz5lrppt5Pw03jGTIi3Q;
        [n1.ElementAttribute(TracingId = 320127U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "KIPsvd56q0gMme7MdvqKqO", Name = "MonoFlop (FrameBased)", IsManaged = true, IsAutoGenerated = true)]
        public n30.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_KIPsvd56q0gMme7MdvqKqO;
        [n1.ElementAttribute(TracingId = 319946U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Ax5MlV6O7nhONaXANu22wj", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n20.Manager<n2.ValueTuple<n11.GpuValue<float>, n11.GpuValue<float>, bool, n11.GpuValue<n5.Vector3>>, n2.ValueTuple<n8.IComputeNode>> __cache_Ax5MlV6O7nhONaXANu22wj = null;
        [n1.ElementAttribute(TracingId = 319984U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "FSimlSPC18KLqSxRWFba7n", Name = "__slot_FSimlSPC18KLqSxRWFba7n")]
        public static float __slot_FSimlSPC18KLqSxRWFba7n = 0.01F;
        static SurfaceBump_UGVz4QabjSZOUCs75L1eCQ()
        {
        }

        public SurfaceBump_UGVz4QabjSZOUCs75L1eCQ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SurfaceBump_UGVz4QabjSZOUCs75L1eCQ(SurfaceBump_UGVz4QabjSZOUCs75L1eCQ other): base(other)
        {
            this.__slot_BLGQ1kbmnaeNX4heX2sF4d = other.__slot_BLGQ1kbmnaeNX4heX2sF4d;
            this.Changed = other.Changed;
            this.__p_P3iiaBw2ZqHNmwqETSCr3y = other.__p_P3iiaBw2ZqHNmwqETSCr3y;
            this.__p_Irmz5lrppt5Pw03jGTIi3Q = other.__p_Irmz5lrppt5Pw03jGTIi3Q;
            this.__p_KIPsvd56q0gMme7MdvqKqO = other.__p_KIPsvd56q0gMme7MdvqKqO;
            this.__cache_Ax5MlV6O7nhONaXANu22wj = other.__cache_Ax5MlV6O7nhONaXANu22wj;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_BLGQ1kbmnaeNX4heX2sF4d", in __slot_BLGQ1kbmnaeNX4heX2sF4d), n1.CompilationHelper.GetValueOrExisting(values, "Changed", in Changed), n1.CompilationHelper.GetValueOrExisting(values, "__p_P3iiaBw2ZqHNmwqETSCr3y", in __p_P3iiaBw2ZqHNmwqETSCr3y), n1.CompilationHelper.GetValueOrExisting(values, "__p_Irmz5lrppt5Pw03jGTIi3Q", in __p_Irmz5lrppt5Pw03jGTIi3Q), n1.CompilationHelper.GetValueOrExisting(values, "__p_KIPsvd56q0gMme7MdvqKqO", in __p_KIPsvd56q0gMme7MdvqKqO), n1.CompilationHelper.GetValueOrExisting(values, "__cache_Ax5MlV6O7nhONaXANu22wj", in __cache_Ax5MlV6O7nhONaXANu22wj));
        }

        internal SurfaceBump_UGVz4QabjSZOUCs75L1eCQ __WITH__(bool __slot_BLGQ1kbmnaeNX4heX2sF4d, bool Changed, n1.IVLNode __p_P3iiaBw2ZqHNmwqETSCr3y, n30.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_Irmz5lrppt5Pw03jGTIi3Q, n30.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_KIPsvd56q0gMme7MdvqKqO, n20.Manager<n2.ValueTuple<n11.GpuValue<float>, n11.GpuValue<float>, bool, n11.GpuValue<n5.Vector3>>, n2.ValueTuple<n8.IComputeNode>> __cache_Ax5MlV6O7nhONaXANu22wj)
        {
            n3.SurfaceBump_UGVz4QabjSZOUCs75L1eCQ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_BLGQ1kbmnaeNX4heX2sF4d != this.__slot_BLGQ1kbmnaeNX4heX2sF4d || Changed != this.Changed || __p_P3iiaBw2ZqHNmwqETSCr3y != this.__p_P3iiaBw2ZqHNmwqETSCr3y || __p_Irmz5lrppt5Pw03jGTIi3Q != this.__p_Irmz5lrppt5Pw03jGTIi3Q || __p_KIPsvd56q0gMme7MdvqKqO != this.__p_KIPsvd56q0gMme7MdvqKqO || __cache_Ax5MlV6O7nhONaXANu22wj != this.__cache_Ax5MlV6O7nhONaXANu22wj ? new SurfaceBump_UGVz4QabjSZOUCs75L1eCQ(this)
                {__slot_BLGQ1kbmnaeNX4heX2sF4d = __slot_BLGQ1kbmnaeNX4heX2sF4d, Changed = Changed, __p_P3iiaBw2ZqHNmwqETSCr3y = __p_P3iiaBw2ZqHNmwqETSCr3y, __p_Irmz5lrppt5Pw03jGTIi3Q = __p_Irmz5lrppt5Pw03jGTIi3Q, __p_KIPsvd56q0gMme7MdvqKqO = __p_KIPsvd56q0gMme7MdvqKqO, __cache_Ax5MlV6O7nhONaXANu22wj = __cache_Ax5MlV6O7nhONaXANu22wj} : that_0;
            else
            {
                this.__slot_BLGQ1kbmnaeNX4heX2sF4d = __slot_BLGQ1kbmnaeNX4heX2sF4d;
                this.Changed = Changed;
                this.__p_P3iiaBw2ZqHNmwqETSCr3y = __p_P3iiaBw2ZqHNmwqETSCr3y;
                this.__p_Irmz5lrppt5Pw03jGTIi3Q = __p_Irmz5lrppt5Pw03jGTIi3Q;
                this.__p_KIPsvd56q0gMme7MdvqKqO = __p_KIPsvd56q0gMme7MdvqKqO;
                this.__cache_Ax5MlV6O7nhONaXANu22wj = __cache_Ax5MlV6O7nhONaXANu22wj;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "B4tfHGh6iUjOrfMiSlcfQ3", Name = "__B4tfHGh6iUjOrfMiSlcfQ3")]
        [n2.SerializableAttribute]
        public class __B4tfHGh6iUjOrfMiSlcfQ3 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Jb4dnKTUy5cNfg0KRWD0PS);
                n1.CompilationHelper.SafeDispose(this.__p_KnaTsYM9RsHQQgrVK27Hdc);
                n1.CompilationHelper.SafeDispose(this.__p_IM9PaxNBTRzLcyNkXadtvX);
                n1.CompilationHelper.SafeDispose(this.__p_IoxIdzBb7FLNCAnPvY8YCh);
                n1.CompilationHelper.SafeDispose(this.__p_JJKf8vXkjPjOcoSPdL2wfO);
                n1.CompilationHelper.SafeDispose(this.__p_NI8IUOjlzJKOmVMzPRR6Ni);
                n1.CompilationHelper.SafeDispose(this.__p_TmHL9udycKxOvQdFmZaoyu);
                n1.CompilationHelper.SafeDispose(this.__p_RDG154mUTKPLwCffxUAWgI);
                n1.CompilationHelper.SafeDispose(this.__p_NHto1xorZ4TOreI6U1O9m4);
                n1.CompilationHelper.SafeDispose(this.__p_HsfzqZnLmXrQS3LbPsmLte);
                n1.CompilationHelper.SafeDispose(this.__p_MkfCAzvzzWsPwwNyPypy45);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_SseE3wI039BNFbSb6cuLrn);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_T0HeuwM3L8TMWWgXr7wqtR);
                return;
            }

            [n1.ElementAttribute(TracingId = 319966U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Jb4dnKTUy5cNfg0KRWD0PS", Name = "CentralDifference", IsManaged = true, IsAutoGenerated = true)]
            public n27.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<n5.Vector3> __p_Jb4dnKTUy5cNfg0KRWD0PS;
            [n1.ElementAttribute(TracingId = 319976U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "KnaTsYM9RsHQQgrVK27Hdc", Name = "Invoke", IsManaged = true, IsAutoGenerated = true)]
            public n23.Invoke_C<float> __p_KnaTsYM9RsHQQgrVK27Hdc;
            [n1.ElementAttribute(TracingId = 319986U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "IM9PaxNBTRzLcyNkXadtvX", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
            public n24.xyz_T2WwCF9xAltPhlUuLjVDje __p_IM9PaxNBTRzLcyNkXadtvX;
            [n1.ElementAttribute(TracingId = 319992U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "IoxIdzBb7FLNCAnPvY8YCh", Name = "PositionWS", IsManaged = true, IsAutoGenerated = true)]
            public n26.PositionWS_EqNTwQZFoLOQdVEmvtk795 __p_IoxIdzBb7FLNCAnPvY8YCh;
            [n1.ElementAttribute(TracingId = 319997U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "JJKf8vXkjPjOcoSPdL2wfO", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_JJKf8vXkjPjOcoSPdL2wfO;
            [n1.ElementAttribute(TracingId = 320035U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "NI8IUOjlzJKOmVMzPRR6Ni", Name = "Position", IsManaged = true, IsAutoGenerated = true)]
            public n26.Position_PeLDdeSku4ANhU5oe5SfPy __p_NI8IUOjlzJKOmVMzPRR6Ni;
            [n1.ElementAttribute(TracingId = 320055U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "TmHL9udycKxOvQdFmZaoyu", Name = "ToShaderFX", IsManaged = true, IsAutoGenerated = true)]
            public n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4> __p_TmHL9udycKxOvQdFmZaoyu;
            [n1.ElementAttribute(TracingId = 320067U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "RDG154mUTKPLwCffxUAWgI", Name = "ToShaderFX", IsManaged = true, IsAutoGenerated = true)]
            public n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_RDG154mUTKPLwCffxUAWgI;
            [n1.ElementAttribute(TracingId = 320076U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "NHto1xorZ4TOreI6U1O9m4", Name = "FuseGeometryBumpExtension", IsManaged = true, IsAutoGenerated = true, NodeName = "FuseGeometryBumpExtension", NodeCategory = "Stride.Rendering.Experimental.ShaderFX")]
            public n1.IVLNode __p_NHto1xorZ4TOreI6U1O9m4;
            [n1.ElementAttribute(TracingId = 320085U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "HsfzqZnLmXrQS3LbPsmLte", Name = "x+y+z+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n28.xPyPzPw_join_BGVj6H1I9pwLDUpQUyUl56 __p_HsfzqZnLmXrQS3LbPsmLte;
            [n1.ElementAttribute(TracingId = 320094U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "MkfCAzvzzWsPwwNyPypy45", Name = "x-y-z (split)", IsManaged = true, IsAutoGenerated = true)]
            public n25.xMyMz_split_HhwKvU63boDLFOLEO95pTD __p_MkfCAzvzzWsPwwNyPypy45;
            [n1.ElementAttribute(TracingId = 320047U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "NV2j4wKGb1QL2ztmE1SMNI", Name = "__slot_NV2j4wKGb1QL2ztmE1SMNI")]
            public bool __slot_NV2j4wKGb1QL2ztmE1SMNI;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.GpuValue<n5.Vector4>> __pin_group_Input_In_RVXv87y36YHORjScZnUTJ2 = default(n18.Spread<n11.GpuValue<n5.Vector4>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.GpuValue<n5.Vector3>> __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF = default(n18.Spread<n11.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<float, n11.GpuValue<float>> __monadBuilder_SseE3wI039BNFbSb6cuLrn = n11.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.AbstractGpuValue> __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc = default(n18.Spread<n11.AbstractGpuValue>);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<float, n11.GpuValue<float>> __monadBuilder_T0HeuwM3L8TMWWgXr7wqtR = n11.GpuValueMonadicFactory<float>.Default.GetMonadBuilder(true);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.GpuValue<float>> __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO = default(n18.Spread<n11.GpuValue<float>>);
            public __B4tfHGh6iUjOrfMiSlcfQ3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __B4tfHGh6iUjOrfMiSlcfQ3(__B4tfHGh6iUjOrfMiSlcfQ3 other): base(other)
            {
                this.__p_Jb4dnKTUy5cNfg0KRWD0PS = other.__p_Jb4dnKTUy5cNfg0KRWD0PS;
                this.__p_KnaTsYM9RsHQQgrVK27Hdc = other.__p_KnaTsYM9RsHQQgrVK27Hdc;
                this.__p_IM9PaxNBTRzLcyNkXadtvX = other.__p_IM9PaxNBTRzLcyNkXadtvX;
                this.__p_IoxIdzBb7FLNCAnPvY8YCh = other.__p_IoxIdzBb7FLNCAnPvY8YCh;
                this.__p_JJKf8vXkjPjOcoSPdL2wfO = other.__p_JJKf8vXkjPjOcoSPdL2wfO;
                this.__p_NI8IUOjlzJKOmVMzPRR6Ni = other.__p_NI8IUOjlzJKOmVMzPRR6Ni;
                this.__p_TmHL9udycKxOvQdFmZaoyu = other.__p_TmHL9udycKxOvQdFmZaoyu;
                this.__p_RDG154mUTKPLwCffxUAWgI = other.__p_RDG154mUTKPLwCffxUAWgI;
                this.__p_NHto1xorZ4TOreI6U1O9m4 = other.__p_NHto1xorZ4TOreI6U1O9m4;
                this.__p_HsfzqZnLmXrQS3LbPsmLte = other.__p_HsfzqZnLmXrQS3LbPsmLte;
                this.__p_MkfCAzvzzWsPwwNyPypy45 = other.__p_MkfCAzvzzWsPwwNyPypy45;
                this.__slot_NV2j4wKGb1QL2ztmE1SMNI = other.__slot_NV2j4wKGb1QL2ztmE1SMNI;
                this.__pin_group_Input_In_RVXv87y36YHORjScZnUTJ2 = other.__pin_group_Input_In_RVXv87y36YHORjScZnUTJ2;
                this.__pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF = other.__pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF;
                this.__monadBuilder_SseE3wI039BNFbSb6cuLrn = other.__monadBuilder_SseE3wI039BNFbSb6cuLrn;
                this.__pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc = other.__pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc;
                this.__monadBuilder_T0HeuwM3L8TMWWgXr7wqtR = other.__monadBuilder_T0HeuwM3L8TMWWgXr7wqtR;
                this.__pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO = other.__pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Jb4dnKTUy5cNfg0KRWD0PS", in __p_Jb4dnKTUy5cNfg0KRWD0PS), n1.CompilationHelper.GetValueOrExisting(values, "__p_KnaTsYM9RsHQQgrVK27Hdc", in __p_KnaTsYM9RsHQQgrVK27Hdc), n1.CompilationHelper.GetValueOrExisting(values, "__p_IM9PaxNBTRzLcyNkXadtvX", in __p_IM9PaxNBTRzLcyNkXadtvX), n1.CompilationHelper.GetValueOrExisting(values, "__p_IoxIdzBb7FLNCAnPvY8YCh", in __p_IoxIdzBb7FLNCAnPvY8YCh), n1.CompilationHelper.GetValueOrExisting(values, "__p_JJKf8vXkjPjOcoSPdL2wfO", in __p_JJKf8vXkjPjOcoSPdL2wfO), n1.CompilationHelper.GetValueOrExisting(values, "__p_NI8IUOjlzJKOmVMzPRR6Ni", in __p_NI8IUOjlzJKOmVMzPRR6Ni), n1.CompilationHelper.GetValueOrExisting(values, "__p_TmHL9udycKxOvQdFmZaoyu", in __p_TmHL9udycKxOvQdFmZaoyu), n1.CompilationHelper.GetValueOrExisting(values, "__p_RDG154mUTKPLwCffxUAWgI", in __p_RDG154mUTKPLwCffxUAWgI), n1.CompilationHelper.GetValueOrExisting(values, "__p_NHto1xorZ4TOreI6U1O9m4", in __p_NHto1xorZ4TOreI6U1O9m4), n1.CompilationHelper.GetValueOrExisting(values, "__p_HsfzqZnLmXrQS3LbPsmLte", in __p_HsfzqZnLmXrQS3LbPsmLte), n1.CompilationHelper.GetValueOrExisting(values, "__p_MkfCAzvzzWsPwwNyPypy45", in __p_MkfCAzvzzWsPwwNyPypy45), n1.CompilationHelper.GetValueOrExisting(values, "__slot_NV2j4wKGb1QL2ztmE1SMNI", in __slot_NV2j4wKGb1QL2ztmE1SMNI), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_RVXv87y36YHORjScZnUTJ2", in __pin_group_Input_In_RVXv87y36YHORjScZnUTJ2), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF", in __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_SseE3wI039BNFbSb6cuLrn", in __monadBuilder_SseE3wI039BNFbSb6cuLrn), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc", in __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_T0HeuwM3L8TMWWgXr7wqtR", in __monadBuilder_T0HeuwM3L8TMWWgXr7wqtR), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO", in __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO));
            }

            internal __B4tfHGh6iUjOrfMiSlcfQ3 __WITH__(n27.CentralDifference_Gcf1XoiXkEeOwd3lB1bB7W<n5.Vector3> __p_Jb4dnKTUy5cNfg0KRWD0PS, n23.Invoke_C<float> __p_KnaTsYM9RsHQQgrVK27Hdc, n24.xyz_T2WwCF9xAltPhlUuLjVDje __p_IM9PaxNBTRzLcyNkXadtvX, n26.PositionWS_EqNTwQZFoLOQdVEmvtk795 __p_IoxIdzBb7FLNCAnPvY8YCh, n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_JJKf8vXkjPjOcoSPdL2wfO, n26.Position_PeLDdeSku4ANhU5oe5SfPy __p_NI8IUOjlzJKOmVMzPRR6Ni, n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<n5.Vector4> __p_TmHL9udycKxOvQdFmZaoyu, n15.ToShaderFX_B2r7xU6vkFZPaug3kJOU12<float> __p_RDG154mUTKPLwCffxUAWgI, n1.IVLNode __p_NHto1xorZ4TOreI6U1O9m4, n28.xPyPzPw_join_BGVj6H1I9pwLDUpQUyUl56 __p_HsfzqZnLmXrQS3LbPsmLte, n25.xMyMz_split_HhwKvU63boDLFOLEO95pTD __p_MkfCAzvzzWsPwwNyPypy45, bool __slot_NV2j4wKGb1QL2ztmE1SMNI, n18.Spread<n11.GpuValue<n5.Vector4>> __pin_group_Input_In_RVXv87y36YHORjScZnUTJ2, n18.Spread<n11.GpuValue<n5.Vector3>> __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF, n1.IMonadBuilder<float, n11.GpuValue<float>> __monadBuilder_SseE3wI039BNFbSb6cuLrn, n18.Spread<n11.AbstractGpuValue> __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc, n1.IMonadBuilder<float, n11.GpuValue<float>> __monadBuilder_T0HeuwM3L8TMWWgXr7wqtR, n18.Spread<n11.GpuValue<float>> __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO)
            {
                __B4tfHGh6iUjOrfMiSlcfQ3 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Jb4dnKTUy5cNfg0KRWD0PS != this.__p_Jb4dnKTUy5cNfg0KRWD0PS || __p_KnaTsYM9RsHQQgrVK27Hdc != this.__p_KnaTsYM9RsHQQgrVK27Hdc || __p_IM9PaxNBTRzLcyNkXadtvX != this.__p_IM9PaxNBTRzLcyNkXadtvX || __p_IoxIdzBb7FLNCAnPvY8YCh != this.__p_IoxIdzBb7FLNCAnPvY8YCh || __p_JJKf8vXkjPjOcoSPdL2wfO != this.__p_JJKf8vXkjPjOcoSPdL2wfO || __p_NI8IUOjlzJKOmVMzPRR6Ni != this.__p_NI8IUOjlzJKOmVMzPRR6Ni || __p_TmHL9udycKxOvQdFmZaoyu != this.__p_TmHL9udycKxOvQdFmZaoyu || __p_RDG154mUTKPLwCffxUAWgI != this.__p_RDG154mUTKPLwCffxUAWgI || __p_NHto1xorZ4TOreI6U1O9m4 != this.__p_NHto1xorZ4TOreI6U1O9m4 || __p_HsfzqZnLmXrQS3LbPsmLte != this.__p_HsfzqZnLmXrQS3LbPsmLte || __p_MkfCAzvzzWsPwwNyPypy45 != this.__p_MkfCAzvzzWsPwwNyPypy45 || __slot_NV2j4wKGb1QL2ztmE1SMNI != this.__slot_NV2j4wKGb1QL2ztmE1SMNI || __pin_group_Input_In_RVXv87y36YHORjScZnUTJ2 != this.__pin_group_Input_In_RVXv87y36YHORjScZnUTJ2 || __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF != this.__pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF || __monadBuilder_SseE3wI039BNFbSb6cuLrn != this.__monadBuilder_SseE3wI039BNFbSb6cuLrn || __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc != this.__pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc || __monadBuilder_T0HeuwM3L8TMWWgXr7wqtR != this.__monadBuilder_T0HeuwM3L8TMWWgXr7wqtR || __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO != this.__pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO ? new __B4tfHGh6iUjOrfMiSlcfQ3(this)
                    {__p_Jb4dnKTUy5cNfg0KRWD0PS = __p_Jb4dnKTUy5cNfg0KRWD0PS, __p_KnaTsYM9RsHQQgrVK27Hdc = __p_KnaTsYM9RsHQQgrVK27Hdc, __p_IM9PaxNBTRzLcyNkXadtvX = __p_IM9PaxNBTRzLcyNkXadtvX, __p_IoxIdzBb7FLNCAnPvY8YCh = __p_IoxIdzBb7FLNCAnPvY8YCh, __p_JJKf8vXkjPjOcoSPdL2wfO = __p_JJKf8vXkjPjOcoSPdL2wfO, __p_NI8IUOjlzJKOmVMzPRR6Ni = __p_NI8IUOjlzJKOmVMzPRR6Ni, __p_TmHL9udycKxOvQdFmZaoyu = __p_TmHL9udycKxOvQdFmZaoyu, __p_RDG154mUTKPLwCffxUAWgI = __p_RDG154mUTKPLwCffxUAWgI, __p_NHto1xorZ4TOreI6U1O9m4 = __p_NHto1xorZ4TOreI6U1O9m4, __p_HsfzqZnLmXrQS3LbPsmLte = __p_HsfzqZnLmXrQS3LbPsmLte, __p_MkfCAzvzzWsPwwNyPypy45 = __p_MkfCAzvzzWsPwwNyPypy45, __slot_NV2j4wKGb1QL2ztmE1SMNI = __slot_NV2j4wKGb1QL2ztmE1SMNI, __pin_group_Input_In_RVXv87y36YHORjScZnUTJ2 = __pin_group_Input_In_RVXv87y36YHORjScZnUTJ2, __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF = __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF, __monadBuilder_SseE3wI039BNFbSb6cuLrn = __monadBuilder_SseE3wI039BNFbSb6cuLrn, __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc = __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc, __monadBuilder_T0HeuwM3L8TMWWgXr7wqtR = __monadBuilder_T0HeuwM3L8TMWWgXr7wqtR, __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO = __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO} : that_0;
                else
                {
                    this.__p_Jb4dnKTUy5cNfg0KRWD0PS = __p_Jb4dnKTUy5cNfg0KRWD0PS;
                    this.__p_KnaTsYM9RsHQQgrVK27Hdc = __p_KnaTsYM9RsHQQgrVK27Hdc;
                    this.__p_IM9PaxNBTRzLcyNkXadtvX = __p_IM9PaxNBTRzLcyNkXadtvX;
                    this.__p_IoxIdzBb7FLNCAnPvY8YCh = __p_IoxIdzBb7FLNCAnPvY8YCh;
                    this.__p_JJKf8vXkjPjOcoSPdL2wfO = __p_JJKf8vXkjPjOcoSPdL2wfO;
                    this.__p_NI8IUOjlzJKOmVMzPRR6Ni = __p_NI8IUOjlzJKOmVMzPRR6Ni;
                    this.__p_TmHL9udycKxOvQdFmZaoyu = __p_TmHL9udycKxOvQdFmZaoyu;
                    this.__p_RDG154mUTKPLwCffxUAWgI = __p_RDG154mUTKPLwCffxUAWgI;
                    this.__p_NHto1xorZ4TOreI6U1O9m4 = __p_NHto1xorZ4TOreI6U1O9m4;
                    this.__p_HsfzqZnLmXrQS3LbPsmLte = __p_HsfzqZnLmXrQS3LbPsmLte;
                    this.__p_MkfCAzvzzWsPwwNyPypy45 = __p_MkfCAzvzzWsPwwNyPypy45;
                    this.__slot_NV2j4wKGb1QL2ztmE1SMNI = __slot_NV2j4wKGb1QL2ztmE1SMNI;
                    this.__pin_group_Input_In_RVXv87y36YHORjScZnUTJ2 = __pin_group_Input_In_RVXv87y36YHORjScZnUTJ2;
                    this.__pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF = __pin_group_Input_In_Jjzn5hZDuKFLCxj9IJSPOF;
                    this.__monadBuilder_SseE3wI039BNFbSb6cuLrn = __monadBuilder_SseE3wI039BNFbSb6cuLrn;
                    this.__pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc = __pin_group_Parameters_In_KnaTsYM9RsHQQgrVK27Hdc;
                    this.__monadBuilder_T0HeuwM3L8TMWWgXr7wqtR = __monadBuilder_T0HeuwM3L8TMWWgXr7wqtR;
                    this.__pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO = __pin_group_Input_In_JJKf8vXkjPjOcoSPdL2wfO;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 320248U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "RF8EWA5ZT4lLMBpP4hibSc", Name = "CelMaterial_RF8EWA5ZT4lLMBpP4hibSc")]
    [n2.SerializableAttribute]
    public class CelMaterial_RF8EWA5ZT4lLMBpP4hibSc : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc Create(n1.NodeContext Node_Context)
        {
            var instance = new CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc CreateDefault()
        {
            var instance = new CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc Update(n12.Texture Ramp_Texture_In, [n4.SerializedDefaultValueAttribute("1, 1, 1, 1", false)] n6.SetVar<n5.Vector4> Diffuse_In, [n4.SerializedDefaultValueAttribute("0.35", false)] n6.SetVar<float> Roughness_In, [n4.SerializedDefaultValueAttribute("0", false)] float Modify_N_L_Factor_In, out n10.Material Output_Out)
        {
            n1.CompilationHelper.WritePin(this.__p_II4FOLke3B3NJ0PVT9zMvM.Inputs[0], ref Ramp_Texture_In);
            n1.CompilationHelper.ReadPin(this.__p_II4FOLke3B3NJ0PVT9zMvM.Outputs[0], out n8.MaterialCelShadingLightRamp out_0);
            n1.CompilationHelper.WritePin(this.__p_RKRwQOqaHZMOjTcuu5Dzpu.Inputs[0], ref Diffuse_In);
            n1.CompilationHelper.ReadPin(this.__p_RKRwQOqaHZMOjTcuu5Dzpu.Outputs[0], out n8.MaterialDiffuseMapFeature out_1);
            n1.CompilationHelper.WritePin(this.__p_Fxdhm9xAOjrPwM1Flh6xYE.Inputs[0], ref Roughness_In);
            n1.CompilationHelper.ReadPin(this.__p_Fxdhm9xAOjrPwM1Flh6xYE.Outputs[0], out n8.MaterialGlossinessMapFeature out_2);
            n1.CompilationHelper.WritePin(this.__p_Jn6vlonERIILyuBr3WWHd5.Inputs[0], ref Modify_N_L_Factor_In);
            n8.IMaterialCelShadingLightFunction Ramp_Function_3 = (n8.IMaterialCelShadingLightFunction)out_0;
            n1.CompilationHelper.WritePin(this.__p_Jn6vlonERIILyuBr3WWHd5.Inputs[1], ref Ramp_Function_3);
            n1.CompilationHelper.ReadPin(this.__p_Jn6vlonERIILyuBr3WWHd5.Outputs[0], out n8.MaterialDiffuseCelShadingModelFeature out_4);
            n8.IMaterialMicroSurfaceFeature Micro_Surface_5 = (n8.IMaterialMicroSurfaceFeature)out_2;
            n1.CompilationHelper.WritePin(this.__p_EIsCrMLnYyTOU5rAX5xIaC.Inputs[3], ref Micro_Surface_5);
            n1.CompilationHelper.ReadPin(this.__p_EIsCrMLnYyTOU5rAX5xIaC.Outputs[0], out n9.GeometryAttributes out_6);
            n1.CompilationHelper.WritePin(this.__p_LAoTlwIvWAmMfYx0knct1b.Inputs[0], ref out_6);
            n8.IMaterialDiffuseFeature Diffuse_7 = (n8.IMaterialDiffuseFeature)out_1;
            n1.CompilationHelper.WritePin(this.__p_U1PwlB3c64jLFCtGDQbrfk.Inputs[0], ref Diffuse_7);
            n8.IMaterialDiffuseModelFeature Diffuse_Model_8 = (n8.IMaterialDiffuseModelFeature)out_4;
            n1.CompilationHelper.WritePin(this.__p_U1PwlB3c64jLFCtGDQbrfk.Inputs[1], ref Diffuse_Model_8);
            n8.IMaterialCelShadingLightFunction Ramp_Function_9 = (n8.IMaterialCelShadingLightFunction)out_0;
            n1.CompilationHelper.WritePin(this.__p_Kn0bK0GzBpRO1rC5Pnxd7b.Inputs[4], ref Ramp_Function_9);
            n1.CompilationHelper.ReadPin(this.__p_Kn0bK0GzBpRO1rC5Pnxd7b.Outputs[0], out n8.MaterialSpecularCelShadingModelFeature out_10);
            n8.IMaterialSpecularModelFeature Specular_Model_11 = (n8.IMaterialSpecularModelFeature)out_10;
            n1.CompilationHelper.WritePin(this.__p_U1PwlB3c64jLFCtGDQbrfk.Inputs[3], ref Specular_Model_11);
            n1.CompilationHelper.ReadPin(this.__p_U1PwlB3c64jLFCtGDQbrfk.Outputs[0], out n9.ShadingAttributes out_12);
            n1.CompilationHelper.WritePin(this.__p_LAoTlwIvWAmMfYx0knct1b.Inputs[1], ref out_12);
            n1.CompilationHelper.ReadPin(this.__p_CQVqhvQUTdyPo1ku9xnreq.Outputs[0], out n9.MiscAttributes out_13);
            n1.CompilationHelper.WritePin(this.__p_LAoTlwIvWAmMfYx0knct1b.Inputs[2], ref out_13);
            n1.CompilationHelper.ReadPin(this.__p_LAoTlwIvWAmMfYx0knct1b.Outputs[0], out n10.Material out_14);
            Output_Out = out_14;
            n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = this.__p_II4FOLke3B3NJ0PVT9zMvM != this.__p_II4FOLke3B3NJ0PVT9zMvM || this.__p_RKRwQOqaHZMOjTcuu5Dzpu != this.__p_RKRwQOqaHZMOjTcuu5Dzpu || this.__p_Fxdhm9xAOjrPwM1Flh6xYE != this.__p_Fxdhm9xAOjrPwM1Flh6xYE || this.__p_Jn6vlonERIILyuBr3WWHd5 != this.__p_Jn6vlonERIILyuBr3WWHd5 || this.__p_EIsCrMLnYyTOU5rAX5xIaC != this.__p_EIsCrMLnYyTOU5rAX5xIaC || this.__p_LAoTlwIvWAmMfYx0knct1b != this.__p_LAoTlwIvWAmMfYx0knct1b || this.__p_U1PwlB3c64jLFCtGDQbrfk != this.__p_U1PwlB3c64jLFCtGDQbrfk || this.__p_Kn0bK0GzBpRO1rC5Pnxd7b != this.__p_Kn0bK0GzBpRO1rC5Pnxd7b || this.__p_CQVqhvQUTdyPo1ku9xnreq != this.__p_CQVqhvQUTdyPo1ku9xnreq ? new CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(this)
                {__p_II4FOLke3B3NJ0PVT9zMvM = this.__p_II4FOLke3B3NJ0PVT9zMvM, __p_RKRwQOqaHZMOjTcuu5Dzpu = this.__p_RKRwQOqaHZMOjTcuu5Dzpu, __p_Fxdhm9xAOjrPwM1Flh6xYE = this.__p_Fxdhm9xAOjrPwM1Flh6xYE, __p_Jn6vlonERIILyuBr3WWHd5 = this.__p_Jn6vlonERIILyuBr3WWHd5, __p_EIsCrMLnYyTOU5rAX5xIaC = this.__p_EIsCrMLnYyTOU5rAX5xIaC, __p_LAoTlwIvWAmMfYx0knct1b = this.__p_LAoTlwIvWAmMfYx0knct1b, __p_U1PwlB3c64jLFCtGDQbrfk = this.__p_U1PwlB3c64jLFCtGDQbrfk, __p_Kn0bK0GzBpRO1rC5Pnxd7b = this.__p_Kn0bK0GzBpRO1rC5Pnxd7b, __p_CQVqhvQUTdyPo1ku9xnreq = this.__p_CQVqhvQUTdyPo1ku9xnreq} : that_15;
            else
            {
                this.__p_II4FOLke3B3NJ0PVT9zMvM = this.__p_II4FOLke3B3NJ0PVT9zMvM;
                this.__p_RKRwQOqaHZMOjTcuu5Dzpu = this.__p_RKRwQOqaHZMOjTcuu5Dzpu;
                this.__p_Fxdhm9xAOjrPwM1Flh6xYE = this.__p_Fxdhm9xAOjrPwM1Flh6xYE;
                this.__p_Jn6vlonERIILyuBr3WWHd5 = this.__p_Jn6vlonERIILyuBr3WWHd5;
                this.__p_EIsCrMLnYyTOU5rAX5xIaC = this.__p_EIsCrMLnYyTOU5rAX5xIaC;
                this.__p_LAoTlwIvWAmMfYx0knct1b = this.__p_LAoTlwIvWAmMfYx0knct1b;
                this.__p_U1PwlB3c64jLFCtGDQbrfk = this.__p_U1PwlB3c64jLFCtGDQbrfk;
                this.__p_Kn0bK0GzBpRO1rC5Pnxd7b = this.__p_Kn0bK0GzBpRO1rC5Pnxd7b;
                this.__p_CQVqhvQUTdyPo1ku9xnreq = this.__p_CQVqhvQUTdyPo1ku9xnreq;
            }

            return that_15;
        }

        public n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc SetCullMode([n4.SerializedDefaultValueAttribute("Back", false)] n12.CullMode Cull_Mode_In)
        {
            n1.CompilationHelper.WritePin(this.__p_CQVqhvQUTdyPo1ku9xnreq.Inputs[3], ref Cull_Mode_In);
            n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_CQVqhvQUTdyPo1ku9xnreq != this.__p_CQVqhvQUTdyPo1ku9xnreq ? new CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(this)
                {__p_CQVqhvQUTdyPo1ku9xnreq = this.__p_CQVqhvQUTdyPo1ku9xnreq} : that_0;
            else
            {
                this.__p_CQVqhvQUTdyPo1ku9xnreq = this.__p_CQVqhvQUTdyPo1ku9xnreq;
            }

            return that_0;
        }

        public n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc SetDisplacement(n8.IMaterialDisplacementFeature Displacement_In)
        {
            n1.CompilationHelper.WritePin(this.__p_EIsCrMLnYyTOU5rAX5xIaC.Inputs[1], ref Displacement_In);
            n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_EIsCrMLnYyTOU5rAX5xIaC != this.__p_EIsCrMLnYyTOU5rAX5xIaC ? new CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(this)
                {__p_EIsCrMLnYyTOU5rAX5xIaC = this.__p_EIsCrMLnYyTOU5rAX5xIaC} : that_0;
            else
            {
                this.__p_EIsCrMLnYyTOU5rAX5xIaC = this.__p_EIsCrMLnYyTOU5rAX5xIaC;
            }

            return that_0;
        }

        public n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc SetOcclusion(n8.IMaterialOcclusionFeature Occlusion_In)
        {
            n1.CompilationHelper.WritePin(this.__p_CQVqhvQUTdyPo1ku9xnreq.Inputs[0], ref Occlusion_In);
            n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_CQVqhvQUTdyPo1ku9xnreq != this.__p_CQVqhvQUTdyPo1ku9xnreq ? new CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(this)
                {__p_CQVqhvQUTdyPo1ku9xnreq = this.__p_CQVqhvQUTdyPo1ku9xnreq} : that_0;
            else
            {
                this.__p_CQVqhvQUTdyPo1ku9xnreq = this.__p_CQVqhvQUTdyPo1ku9xnreq;
            }

            return that_0;
        }

        public n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc SetSubsurfaceScattering(n8.IMaterialSubsurfaceScatteringFeature Subsurface_Scattering_In)
        {
            n1.CompilationHelper.WritePin(this.__p_U1PwlB3c64jLFCtGDQbrfk.Inputs[5], ref Subsurface_Scattering_In);
            n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_U1PwlB3c64jLFCtGDQbrfk != this.__p_U1PwlB3c64jLFCtGDQbrfk ? new CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(this)
                {__p_U1PwlB3c64jLFCtGDQbrfk = this.__p_U1PwlB3c64jLFCtGDQbrfk} : that_0;
            else
            {
                this.__p_U1PwlB3c64jLFCtGDQbrfk = this.__p_U1PwlB3c64jLFCtGDQbrfk;
            }

            return that_0;
        }

        public n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc SetTransparency(n8.IMaterialTransparencyFeature Transparency_In)
        {
            n1.CompilationHelper.WritePin(this.__p_CQVqhvQUTdyPo1ku9xnreq.Inputs[1], ref Transparency_In);
            n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_CQVqhvQUTdyPo1ku9xnreq != this.__p_CQVqhvQUTdyPo1ku9xnreq ? new CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(this)
                {__p_CQVqhvQUTdyPo1ku9xnreq = this.__p_CQVqhvQUTdyPo1ku9xnreq} : that_0;
            else
            {
                this.__p_CQVqhvQUTdyPo1ku9xnreq = this.__p_CQVqhvQUTdyPo1ku9xnreq;
            }

            return that_0;
        }

        public n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc SetEmissive(n8.IMaterialEmissiveFeature Emissive_In)
        {
            n1.CompilationHelper.WritePin(this.__p_U1PwlB3c64jLFCtGDQbrfk.Inputs[4], ref Emissive_In);
            n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_U1PwlB3c64jLFCtGDQbrfk != this.__p_U1PwlB3c64jLFCtGDQbrfk ? new CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(this)
                {__p_U1PwlB3c64jLFCtGDQbrfk = this.__p_U1PwlB3c64jLFCtGDQbrfk} : that_0;
            else
            {
                this.__p_U1PwlB3c64jLFCtGDQbrfk = this.__p_U1PwlB3c64jLFCtGDQbrfk;
            }

            return that_0;
        }

        public n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc SetLayers(n13.IReadOnlyList<n8.MaterialBlendLayer> Layers_In)
        {
            n1.CompilationHelper.WritePin(this.__p_LAoTlwIvWAmMfYx0knct1b.Inputs[3], ref Layers_In);
            n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_LAoTlwIvWAmMfYx0knct1b != this.__p_LAoTlwIvWAmMfYx0knct1b ? new CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(this)
                {__p_LAoTlwIvWAmMfYx0knct1b = this.__p_LAoTlwIvWAmMfYx0knct1b} : that_0;
            else
            {
                this.__p_LAoTlwIvWAmMfYx0knct1b = this.__p_LAoTlwIvWAmMfYx0knct1b;
            }

            return that_0;
        }

        public n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc SetNormal(n8.IMaterialSurfaceFeature Normal_In)
        {
            n1.CompilationHelper.WritePin(this.__p_EIsCrMLnYyTOU5rAX5xIaC.Inputs[2], ref Normal_In);
            n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_EIsCrMLnYyTOU5rAX5xIaC != this.__p_EIsCrMLnYyTOU5rAX5xIaC ? new CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(this)
                {__p_EIsCrMLnYyTOU5rAX5xIaC = this.__p_EIsCrMLnYyTOU5rAX5xIaC} : that_0;
            else
            {
                this.__p_EIsCrMLnYyTOU5rAX5xIaC = this.__p_EIsCrMLnYyTOU5rAX5xIaC;
            }

            return that_0;
        }

        public n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc SetTesselation(n8.IMaterialTessellationFeature Tessellation_In)
        {
            n1.CompilationHelper.WritePin(this.__p_EIsCrMLnYyTOU5rAX5xIaC.Inputs[0], ref Tessellation_In);
            n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_EIsCrMLnYyTOU5rAX5xIaC != this.__p_EIsCrMLnYyTOU5rAX5xIaC ? new CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(this)
                {__p_EIsCrMLnYyTOU5rAX5xIaC = this.__p_EIsCrMLnYyTOU5rAX5xIaC} : that_0;
            else
            {
                this.__p_EIsCrMLnYyTOU5rAX5xIaC = this.__p_EIsCrMLnYyTOU5rAX5xIaC;
            }

            return that_0;
        }

        public n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            bool __pad_EJCU5kHLJ67NF1SaWh96YD_0 = __slot_EJCU5kHLJ67NF1SaWh96YD;
            var node_1 = n1.CompilationHelper.CreateNodeById(Node_Context, "Glossiness", "Stride.Advanced.Materials.GeometryAttributes");
            n1.CompilationHelper.WritePin(node_1.Inputs[1], ref __pad_EJCU5kHLJ67NF1SaWh96YD_0);
            var node_2 = n1.CompilationHelper.CreateNodeById(Node_Context, "GeometryAttributes", "Stride.Advanced.Materials");
            var node_3 = n1.CompilationHelper.CreateNodeById(Node_Context, "ShadingAttributes", "Stride.Advanced.Materials");
            var node_4 = n1.CompilationHelper.CreateNodeById(Node_Context, "MiscAttributes", "Stride.Advanced.Materials");
            var node_5 = n1.CompilationHelper.CreateNodeById(Node_Context, "Material", "Stride.Advanced.Materials");
            var node_6 = n1.CompilationHelper.CreateNodeById(Node_Context, "Diffuse", "Stride.Advanced.Materials.ShadingAttributes");
            var node_7 = n1.CompilationHelper.CreateNodeById(Node_Context, "RampLightFunction", "Stride.Advanced.Materials.ShadingAttributes.SpecularModel.CelShading");
            var node_8 = n1.CompilationHelper.CreateNodeById(Node_Context, "CelShading", "Stride.Advanced.Materials.ShadingAttributes.DiffuseModel");
            var node_9 = n1.CompilationHelper.CreateNodeById(Node_Context, "CelShading", "Stride.Advanced.Materials.ShadingAttributes.SpecularModel");
            n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc that_10 = this;
            this.__p_Fxdhm9xAOjrPwM1Flh6xYE = node_1;
            this.__p_EIsCrMLnYyTOU5rAX5xIaC = node_2;
            this.__p_U1PwlB3c64jLFCtGDQbrfk = node_3;
            this.__p_CQVqhvQUTdyPo1ku9xnreq = node_4;
            this.__p_LAoTlwIvWAmMfYx0knct1b = node_5;
            this.__p_RKRwQOqaHZMOjTcuu5Dzpu = node_6;
            this.__p_II4FOLke3B3NJ0PVT9zMvM = node_7;
            this.__p_Jn6vlonERIILyuBr3WWHd5 = node_8;
            this.__p_Kn0bK0GzBpRO1rC5Pnxd7b = node_9;
            return that_10;
        }

        public n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc __CreateDefault__()
        {
            n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc that_0 = this;
            this.__p_II4FOLke3B3NJ0PVT9zMvM = default(n1.IVLNode);
            this.__p_RKRwQOqaHZMOjTcuu5Dzpu = default(n1.IVLNode);
            this.__p_Fxdhm9xAOjrPwM1Flh6xYE = default(n1.IVLNode);
            this.__p_Jn6vlonERIILyuBr3WWHd5 = default(n1.IVLNode);
            this.__p_EIsCrMLnYyTOU5rAX5xIaC = default(n1.IVLNode);
            this.__p_LAoTlwIvWAmMfYx0knct1b = default(n1.IVLNode);
            this.__p_U1PwlB3c64jLFCtGDQbrfk = default(n1.IVLNode);
            this.__p_Kn0bK0GzBpRO1rC5Pnxd7b = default(n1.IVLNode);
            this.__p_CQVqhvQUTdyPo1ku9xnreq = default(n1.IVLNode);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_II4FOLke3B3NJ0PVT9zMvM);
            n1.CompilationHelper.SafeDispose(this.__p_RKRwQOqaHZMOjTcuu5Dzpu);
            n1.CompilationHelper.SafeDispose(this.__p_Fxdhm9xAOjrPwM1Flh6xYE);
            n1.CompilationHelper.SafeDispose(this.__p_Jn6vlonERIILyuBr3WWHd5);
            n1.CompilationHelper.SafeDispose(this.__p_EIsCrMLnYyTOU5rAX5xIaC);
            n1.CompilationHelper.SafeDispose(this.__p_LAoTlwIvWAmMfYx0knct1b);
            n1.CompilationHelper.SafeDispose(this.__p_U1PwlB3c64jLFCtGDQbrfk);
            n1.CompilationHelper.SafeDispose(this.__p_Kn0bK0GzBpRO1rC5Pnxd7b);
            n1.CompilationHelper.SafeDispose(this.__p_CQVqhvQUTdyPo1ku9xnreq);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 320343U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "EJCU5kHLJ67NF1SaWh96YD", Name = "__slot_EJCU5kHLJ67NF1SaWh96YD")]
        public static bool __slot_EJCU5kHLJ67NF1SaWh96YD = true;
        [n1.ElementAttribute(TracingId = 320353U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "II4FOLke3B3NJ0PVT9zMvM", Name = "RampLightFunction", IsManaged = true, IsAutoGenerated = true, NodeName = "RampLightFunction", NodeCategory = "Stride.Advanced.Materials.ShadingAttributes.SpecularModel.CelShading")]
        public n1.IVLNode __p_II4FOLke3B3NJ0PVT9zMvM;
        [n1.ElementAttribute(TracingId = 320346U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "RKRwQOqaHZMOjTcuu5Dzpu", Name = "Diffuse", IsManaged = true, IsAutoGenerated = true, NodeName = "Diffuse", NodeCategory = "Stride.Advanced.Materials.ShadingAttributes")]
        public n1.IVLNode __p_RKRwQOqaHZMOjTcuu5Dzpu;
        [n1.ElementAttribute(TracingId = 320331U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Fxdhm9xAOjrPwM1Flh6xYE", Name = "Glossiness", IsManaged = true, IsAutoGenerated = true, NodeName = "Glossiness", NodeCategory = "Stride.Advanced.Materials.GeometryAttributes")]
        public n1.IVLNode __p_Fxdhm9xAOjrPwM1Flh6xYE;
        [n1.ElementAttribute(TracingId = 320360U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Jn6vlonERIILyuBr3WWHd5", Name = "CelShading", IsManaged = true, IsAutoGenerated = true, NodeName = "CelShading", NodeCategory = "Stride.Advanced.Materials.ShadingAttributes.DiffuseModel")]
        public n1.IVLNode __p_Jn6vlonERIILyuBr3WWHd5;
        [n1.ElementAttribute(TracingId = 320257U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "EIsCrMLnYyTOU5rAX5xIaC", Name = "GeometryAttributes", IsManaged = true, IsAutoGenerated = true, NodeName = "GeometryAttributes", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_EIsCrMLnYyTOU5rAX5xIaC;
        [n1.ElementAttribute(TracingId = 320305U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "LAoTlwIvWAmMfYx0knct1b", Name = "Material", IsManaged = true, IsAutoGenerated = true, NodeName = "Material", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_LAoTlwIvWAmMfYx0knct1b;
        [n1.ElementAttribute(TracingId = 320271U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "U1PwlB3c64jLFCtGDQbrfk", Name = "ShadingAttributes", IsManaged = true, IsAutoGenerated = true, NodeName = "ShadingAttributes", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_U1PwlB3c64jLFCtGDQbrfk;
        [n1.ElementAttribute(TracingId = 320369U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Kn0bK0GzBpRO1rC5Pnxd7b", Name = "CelShading", IsManaged = true, IsAutoGenerated = true, NodeName = "CelShading", NodeCategory = "Stride.Advanced.Materials.ShadingAttributes.SpecularModel")]
        public n1.IVLNode __p_Kn0bK0GzBpRO1rC5Pnxd7b;
        [n1.ElementAttribute(TracingId = 320290U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "CQVqhvQUTdyPo1ku9xnreq", Name = "MiscAttributes", IsManaged = true, IsAutoGenerated = true, NodeName = "MiscAttributes", NodeCategory = "Stride.Advanced.Materials")]
        public n1.IVLNode __p_CQVqhvQUTdyPo1ku9xnreq;
        static CelMaterial_RF8EWA5ZT4lLMBpP4hibSc()
        {
        }

        public CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(CelMaterial_RF8EWA5ZT4lLMBpP4hibSc other): base(other)
        {
            this.__p_II4FOLke3B3NJ0PVT9zMvM = other.__p_II4FOLke3B3NJ0PVT9zMvM;
            this.__p_RKRwQOqaHZMOjTcuu5Dzpu = other.__p_RKRwQOqaHZMOjTcuu5Dzpu;
            this.__p_Fxdhm9xAOjrPwM1Flh6xYE = other.__p_Fxdhm9xAOjrPwM1Flh6xYE;
            this.__p_Jn6vlonERIILyuBr3WWHd5 = other.__p_Jn6vlonERIILyuBr3WWHd5;
            this.__p_EIsCrMLnYyTOU5rAX5xIaC = other.__p_EIsCrMLnYyTOU5rAX5xIaC;
            this.__p_LAoTlwIvWAmMfYx0knct1b = other.__p_LAoTlwIvWAmMfYx0knct1b;
            this.__p_U1PwlB3c64jLFCtGDQbrfk = other.__p_U1PwlB3c64jLFCtGDQbrfk;
            this.__p_Kn0bK0GzBpRO1rC5Pnxd7b = other.__p_Kn0bK0GzBpRO1rC5Pnxd7b;
            this.__p_CQVqhvQUTdyPo1ku9xnreq = other.__p_CQVqhvQUTdyPo1ku9xnreq;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_II4FOLke3B3NJ0PVT9zMvM", in __p_II4FOLke3B3NJ0PVT9zMvM), n1.CompilationHelper.GetValueOrExisting(values, "__p_RKRwQOqaHZMOjTcuu5Dzpu", in __p_RKRwQOqaHZMOjTcuu5Dzpu), n1.CompilationHelper.GetValueOrExisting(values, "__p_Fxdhm9xAOjrPwM1Flh6xYE", in __p_Fxdhm9xAOjrPwM1Flh6xYE), n1.CompilationHelper.GetValueOrExisting(values, "__p_Jn6vlonERIILyuBr3WWHd5", in __p_Jn6vlonERIILyuBr3WWHd5), n1.CompilationHelper.GetValueOrExisting(values, "__p_EIsCrMLnYyTOU5rAX5xIaC", in __p_EIsCrMLnYyTOU5rAX5xIaC), n1.CompilationHelper.GetValueOrExisting(values, "__p_LAoTlwIvWAmMfYx0knct1b", in __p_LAoTlwIvWAmMfYx0knct1b), n1.CompilationHelper.GetValueOrExisting(values, "__p_U1PwlB3c64jLFCtGDQbrfk", in __p_U1PwlB3c64jLFCtGDQbrfk), n1.CompilationHelper.GetValueOrExisting(values, "__p_Kn0bK0GzBpRO1rC5Pnxd7b", in __p_Kn0bK0GzBpRO1rC5Pnxd7b), n1.CompilationHelper.GetValueOrExisting(values, "__p_CQVqhvQUTdyPo1ku9xnreq", in __p_CQVqhvQUTdyPo1ku9xnreq));
        }

        internal CelMaterial_RF8EWA5ZT4lLMBpP4hibSc __WITH__(n1.IVLNode __p_II4FOLke3B3NJ0PVT9zMvM, n1.IVLNode __p_RKRwQOqaHZMOjTcuu5Dzpu, n1.IVLNode __p_Fxdhm9xAOjrPwM1Flh6xYE, n1.IVLNode __p_Jn6vlonERIILyuBr3WWHd5, n1.IVLNode __p_EIsCrMLnYyTOU5rAX5xIaC, n1.IVLNode __p_LAoTlwIvWAmMfYx0knct1b, n1.IVLNode __p_U1PwlB3c64jLFCtGDQbrfk, n1.IVLNode __p_Kn0bK0GzBpRO1rC5Pnxd7b, n1.IVLNode __p_CQVqhvQUTdyPo1ku9xnreq)
        {
            n3.CelMaterial_RF8EWA5ZT4lLMBpP4hibSc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_II4FOLke3B3NJ0PVT9zMvM != this.__p_II4FOLke3B3NJ0PVT9zMvM || __p_RKRwQOqaHZMOjTcuu5Dzpu != this.__p_RKRwQOqaHZMOjTcuu5Dzpu || __p_Fxdhm9xAOjrPwM1Flh6xYE != this.__p_Fxdhm9xAOjrPwM1Flh6xYE || __p_Jn6vlonERIILyuBr3WWHd5 != this.__p_Jn6vlonERIILyuBr3WWHd5 || __p_EIsCrMLnYyTOU5rAX5xIaC != this.__p_EIsCrMLnYyTOU5rAX5xIaC || __p_LAoTlwIvWAmMfYx0knct1b != this.__p_LAoTlwIvWAmMfYx0knct1b || __p_U1PwlB3c64jLFCtGDQbrfk != this.__p_U1PwlB3c64jLFCtGDQbrfk || __p_Kn0bK0GzBpRO1rC5Pnxd7b != this.__p_Kn0bK0GzBpRO1rC5Pnxd7b || __p_CQVqhvQUTdyPo1ku9xnreq != this.__p_CQVqhvQUTdyPo1ku9xnreq ? new CelMaterial_RF8EWA5ZT4lLMBpP4hibSc(this)
                {__p_II4FOLke3B3NJ0PVT9zMvM = __p_II4FOLke3B3NJ0PVT9zMvM, __p_RKRwQOqaHZMOjTcuu5Dzpu = __p_RKRwQOqaHZMOjTcuu5Dzpu, __p_Fxdhm9xAOjrPwM1Flh6xYE = __p_Fxdhm9xAOjrPwM1Flh6xYE, __p_Jn6vlonERIILyuBr3WWHd5 = __p_Jn6vlonERIILyuBr3WWHd5, __p_EIsCrMLnYyTOU5rAX5xIaC = __p_EIsCrMLnYyTOU5rAX5xIaC, __p_LAoTlwIvWAmMfYx0knct1b = __p_LAoTlwIvWAmMfYx0knct1b, __p_U1PwlB3c64jLFCtGDQbrfk = __p_U1PwlB3c64jLFCtGDQbrfk, __p_Kn0bK0GzBpRO1rC5Pnxd7b = __p_Kn0bK0GzBpRO1rC5Pnxd7b, __p_CQVqhvQUTdyPo1ku9xnreq = __p_CQVqhvQUTdyPo1ku9xnreq} : that_0;
            else
            {
                this.__p_II4FOLke3B3NJ0PVT9zMvM = __p_II4FOLke3B3NJ0PVT9zMvM;
                this.__p_RKRwQOqaHZMOjTcuu5Dzpu = __p_RKRwQOqaHZMOjTcuu5Dzpu;
                this.__p_Fxdhm9xAOjrPwM1Flh6xYE = __p_Fxdhm9xAOjrPwM1Flh6xYE;
                this.__p_Jn6vlonERIILyuBr3WWHd5 = __p_Jn6vlonERIILyuBr3WWHd5;
                this.__p_EIsCrMLnYyTOU5rAX5xIaC = __p_EIsCrMLnYyTOU5rAX5xIaC;
                this.__p_LAoTlwIvWAmMfYx0knct1b = __p_LAoTlwIvWAmMfYx0knct1b;
                this.__p_U1PwlB3c64jLFCtGDQbrfk = __p_U1PwlB3c64jLFCtGDQbrfk;
                this.__p_Kn0bK0GzBpRO1rC5Pnxd7b = __p_Kn0bK0GzBpRO1rC5Pnxd7b;
                this.__p_CQVqhvQUTdyPo1ku9xnreq = __p_CQVqhvQUTdyPo1ku9xnreq;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 320497U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "F9heGRX7EqPLWAHdSRUpHe", Name = "TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe")]
    [n2.SerializableAttribute]
    public class TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe Create(n1.NodeContext Node_Context)
        {
            var instance = new TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe CreateDefault()
        {
            var instance = new TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe Update(n11.GpuValue<n12.Texture> Texture_In, n11.GpuValue<n12.SamplerState> Sampler_In, [n4.SerializedDefaultValueAttribute("1", false)] n11.GpuValue<float> Sharpness_In, [n4.SerializedDefaultValueAttribute("1, 1, 1", false)] n11.GpuValue<n5.Vector3> Scale_In, [n4.SerializedDefaultValueAttribute("1", false)] n11.GpuValue<float> Strength_In, out n11.GpuValue<n5.Vector4> Output_Out)
        {
            bool __pad_E4XLlPiH6nkMG40UB1tvEF_0 = __slot_E4XLlPiH6nkMG40UB1tvEF;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_SwEwOTGCKbmLSNQ0biJhrB;
            if (manager_2 is null)
            {
                manager_2 = new n20.Manager<n2.ValueTuple<n11.GpuValue<n12.Texture>, n11.GpuValue<n12.SamplerState>, n11.GpuValue<n5.Vector3>, n11.GpuValue<float>, n11.GpuValue<float>>, n2.ValueTuple<n11.GpuValue<n5.Vector4>>>(n2.ValueTuple.Create(default(n11.GpuValue<n5.Vector4>)));
            }

            var inputs_3 = (Texture_In, Sampler_In, Scale_In, Sharpness_In, Strength_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = __pad_E4XLlPiH6nkMG40UB1tvEF_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__TmxOiY7WuZGMX9p9sJSyMa>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __TmxOiY7WuZGMX9p9sJSyMa(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD = n19._Operations_.CreateDefault<n11.GpuValue<n5.Vector3>>(), __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk = n19._Operations_.CreateDefault<n11.AbstractGpuValue>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "KVhVuRExrdDNtUzxsZNalH", 320527U);
                    var Output_8 = n24.xyz_T2WwCF9xAltPhlUuLjVDje.Create(Node_Context: Node_Context_7);
                    state_6.__p_KVhVuRExrdDNtUzxsZNalH = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "LTdrwsh7DEPPwNtTuPQLVy", 320538U);
                    var Output_10 = n26.PositionWS_EqNTwQZFoLOQdVEmvtk795.Create(Node_Context: Node_Context_9);
                    state_6.__p_LTdrwsh7DEPPwNtTuPQLVy = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "J8SUYPyygQ1PNf3b1rv0Kk", 320547U);
                    var Output_12 = n31.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n5.Vector3>.Create(Node_Context: Node_Context_11);
                    state_6.__p_J8SUYPyygQ1PNf3b1rv0Kk = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "P3LXTLNTuayLH3zyHkOwpL", 320574U);
                    var Output_14 = n26.MeshNormalWS_Gppq7KtrvrwLtF4UYBlDgj.Create(Node_Context: Node_Context_13);
                    state_6.__p_P3LXTLNTuayLH3zyHkOwpL = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "SlM6e4zoELjNNJn2LHHFnK", 320579U);
                    var Output_16 = n28.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l.Create(Node_Context: Node_Context_15);
                    state_6.__p_SlM6e4zoELjNNJn2LHHFnK = Output_16;
                    var node_17 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "SamplerState", "Stride.Graphics.Advanced");
                    state_6.__p_Ak5FslRKGbHQVNHilwSdwC = node_17;
                    n1.NodeContext Node_Context_18 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "Vv0aJxFJ2yuN3aHQGMNCjW", 320608U);
                    var Output_19 = n32.SamplerIn_Fuse_Ow27E5pjREtLkbiG0rRYjW.Create(Node_Context: Node_Context_18);
                    state_6.__p_Vv0aJxFJ2yuN3aHQGMNCjW = Output_19;
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "BLN0P3yLN7mNmylssr2anS", 320619U);
                    var Output_21 = n33.CheckDefault_GpuValue_PdsuywpUtM6PfMHKiPiuYX<n12.SamplerState>.Create(Node_Context: Node_Context_20);
                    state_6.__p_BLN0P3yLN7mNmylssr2anS = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "RqzTrkFNcp9Nq8X1YJ7HpE", 320639U);
                    var Output_23 = n21.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float>.Create(Node_Context: Node_Context_22);
                    state_6.__p_RqzTrkFNcp9Nq8X1YJ7HpE = Output_23;
                    n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "KpPvg3ljokYPQQNlBrrBfD", 320645U);
                    var Output_25 = n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3>.Create(Node_Context: Node_Context_24);
                    state_6.__p_KpPvg3ljokYPQQNlBrrBfD = Output_25;
                    n1.NodeContext Node_Context_26 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "PnZCpMv8mkiPUYBnOj9lKH", 320656U);
                    var Output_27 = n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, n5.Vector3>.Create(Node_Context: Node_Context_26);
                    state_6.__p_PnZCpMv8mkiPUYBnOj9lKH = Output_27;
                }

                string __pad_RuBt71Ftfd7OhMxLM2Uc05_28 = __slot_RuBt71Ftfd7OhMxLM2Uc05;
                string __pad_MO6MBS1jH1jNE1OzwN8V3i_29 = __slot_MO6MBS1jH1jNE1OzwN8V3i;
                n34.TextureAddressMode __pad_GRr4BINq68aQVHCW3HkFbL_30 = __slot_GRr4BINq68aQVHCW3HkFbL;
                var State_Output_32 = state_6.__p_LTdrwsh7DEPPwNtTuPQLVy.Update(Output_Out: out n11.GpuValue<n5.Vector4> Output_31);
                var State_Output_34 = state_6.__p_KVhVuRExrdDNtUzxsZNalH.Update(Input_In: Output_31, Output_Out: out n11.GpuValue<n5.Vector3> Output_33);
                var State_Output_36 = state_6.__p_Vv0aJxFJ2yuN3aHQGMNCjW.Update(Output_Out: out n11.GpuValue<n12.SamplerState> Output_35);
                var State_Output_38 = state_6.__p_BLN0P3yLN7mNmylssr2anS.Update(GpuValue_In: Sampler_In, Default_In: Output_35, Output_Out: out n11.GpuValue<n12.SamplerState> Output_37);
                var State_Output_40 = state_6.__p_P3LXTLNTuayLH3zyHkOwpL.Update(Output_Out: out n11.GpuValue<n5.Vector3> Output_39);
                n11.GpuValue<n5.Vector3> default_41 = default(n11.GpuValue<n5.Vector3>);
                var State_Output_43 = state_6.__p_PnZCpMv8mkiPUYBnOj9lKH.Update(x_In: Strength_In, default_In: default_41, Output_Out: out n11.GpuValue<n5.Vector3> Output_42);
                var builder_44 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD, 2);
                builder_44.Add(Output_39);
                builder_44.Add(Output_42);
                var __pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD_45 = builder_44.Commit();
                var State_Output_47 = state_6.__p_KpPvg3ljokYPQQNlBrrBfD.Update(Input_In: __pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD_45, Output_Out: out n11.GpuValue<n5.Vector3> Output_46);
                n11.GpuValue<n5.Vector3> Default_48 = default(n11.GpuValue<n5.Vector3>);
                bool Is_Groupable_49 = false;
                n13.IEnumerable<n11.InputModifier> The_Modifiers_50 = n35._Operations_.CreateDefault<n11.InputModifier>();
                var builder_51 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk, 6);
                builder_51.Add(Texture_In);
                builder_51.Add(Output_37);
                builder_51.Add(Output_33);
                builder_51.Add(Output_46);
                builder_51.Add(Scale_In);
                builder_51.Add(Sharpness_In);
                var __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk_52 = builder_51.Commit();
                var State_Output_55 = state_6.__p_J8SUYPyygQ1PNf3b1rv0Kk.Update(Arguments_In: __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk_52, Function_Name_In: __pad_MO6MBS1jH1jNE1OzwN8V3i_29, Default_In: Default_48, Mixins_In: __pad_RuBt71Ftfd7OhMxLM2Uc05_28, Is_Groupable_In: Is_Groupable_49, The_Modifiers_In: The_Modifiers_50, Output_Out: out n11.GpuValue<n5.Vector3> Output_53, Additional_Outputs_Out: out n18.Spread<n11.AbstractGpuValue> Additional_Outputs_54);
                n1.CompilationHelper.WritePin(state_6.__p_Ak5FslRKGbHQVNHilwSdwC.Inputs[1], ref __pad_GRr4BINq68aQVHCW3HkFbL_30);
                n1.CompilationHelper.WritePin(state_6.__p_Ak5FslRKGbHQVNHilwSdwC.Inputs[2], ref __pad_GRr4BINq68aQVHCW3HkFbL_30);
                n1.CompilationHelper.WritePin(state_6.__p_Ak5FslRKGbHQVNHilwSdwC.Inputs[3], ref __pad_GRr4BINq68aQVHCW3HkFbL_30);
                n1.CompilationHelper.ReadPin(state_6.__p_Ak5FslRKGbHQVNHilwSdwC.Outputs[0], out n12.SamplerState out_56);
                bool SetValue_57 = true;
                var Output_58 = State_Output_36;
                if (SetValue_57)
                {
                    Output_58 = State_Output_36.SetValue(Input_In: out_56);
                }

                n22._Operations_.TypeVector3(Input_In: Output_53, Output_Out: out n11.GpuValue<n5.Vector3> Output_59);
                var State_Output_61 = state_6.__p_RqzTrkFNcp9Nq8X1YJ7HpE.Update(Output_Out: out n11.GpuValue<float> Output_60);
                var State_Output_63 = state_6.__p_SlM6e4zoELjNNJn2LHHFnK.Update(xyz_In: Output_59, w_In: Output_60, Output_Out: out n11.GpuValue<n5.Vector4> Output_62);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_32 != state_6.__p_LTdrwsh7DEPPwNtTuPQLVy || State_Output_34 != state_6.__p_KVhVuRExrdDNtUzxsZNalH || Output_58 != state_6.__p_Vv0aJxFJ2yuN3aHQGMNCjW || State_Output_38 != state_6.__p_BLN0P3yLN7mNmylssr2anS || State_Output_40 != state_6.__p_P3LXTLNTuayLH3zyHkOwpL || State_Output_43 != state_6.__p_PnZCpMv8mkiPUYBnOj9lKH || __pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD_45 != state_6.__pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD || State_Output_47 != state_6.__p_KpPvg3ljokYPQQNlBrrBfD || __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk_52 != state_6.__pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk || State_Output_55 != state_6.__p_J8SUYPyygQ1PNf3b1rv0Kk || state_6.__p_Ak5FslRKGbHQVNHilwSdwC != state_6.__p_Ak5FslRKGbHQVNHilwSdwC || State_Output_61 != state_6.__p_RqzTrkFNcp9Nq8X1YJ7HpE || State_Output_63 != state_6.__p_SlM6e4zoELjNNJn2LHHFnK ? new __TmxOiY7WuZGMX9p9sJSyMa(state_6)
                    {__p_LTdrwsh7DEPPwNtTuPQLVy = State_Output_32, __p_KVhVuRExrdDNtUzxsZNalH = State_Output_34, __p_Vv0aJxFJ2yuN3aHQGMNCjW = Output_58, __p_BLN0P3yLN7mNmylssr2anS = State_Output_38, __p_P3LXTLNTuayLH3zyHkOwpL = State_Output_40, __p_PnZCpMv8mkiPUYBnOj9lKH = State_Output_43, __pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD = __pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD_45, __p_KpPvg3ljokYPQQNlBrrBfD = State_Output_47, __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk = __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk_52, __p_J8SUYPyygQ1PNf3b1rv0Kk = State_Output_55, __p_Ak5FslRKGbHQVNHilwSdwC = state_6.__p_Ak5FslRKGbHQVNHilwSdwC, __p_RqzTrkFNcp9Nq8X1YJ7HpE = State_Output_61, __p_SlM6e4zoELjNNJn2LHHFnK = State_Output_63} : state_6;
                else
                {
                    state_6.__p_LTdrwsh7DEPPwNtTuPQLVy = State_Output_32;
                    state_6.__p_KVhVuRExrdDNtUzxsZNalH = State_Output_34;
                    state_6.__p_Vv0aJxFJ2yuN3aHQGMNCjW = Output_58;
                    state_6.__p_BLN0P3yLN7mNmylssr2anS = State_Output_38;
                    state_6.__p_P3LXTLNTuayLH3zyHkOwpL = State_Output_40;
                    state_6.__p_PnZCpMv8mkiPUYBnOj9lKH = State_Output_43;
                    state_6.__pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD = __pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD_45;
                    state_6.__p_KpPvg3ljokYPQQNlBrrBfD = State_Output_47;
                    state_6.__pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk = __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk_52;
                    state_6.__p_J8SUYPyygQ1PNf3b1rv0Kk = State_Output_55;
                    state_6.__p_Ak5FslRKGbHQVNHilwSdwC = state_6.__p_Ak5FslRKGbHQVNHilwSdwC;
                    state_6.__p_RqzTrkFNcp9Nq8X1YJ7HpE = State_Output_61;
                    state_6.__p_SlM6e4zoELjNNJn2LHHFnK = State_Output_63;
                }

                outputs_4 = n2.ValueTuple.Create(Output_62);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_64 = outputs_4.Item1;
            Output_Out = __auto_64;
            n3.TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe that_65 = this;
            if (this.__GetContext__().IsImmutable)
                that_65 = manager_2 != this.__cache_SwEwOTGCKbmLSNQ0biJhrB ? new TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe(this)
                {__cache_SwEwOTGCKbmLSNQ0biJhrB = manager_2} : that_65;
            else
            {
                this.__cache_SwEwOTGCKbmLSNQ0biJhrB = manager_2;
            }

            return that_65;
        }

        public n3.TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe that_0 = this;
            this.__cache_SwEwOTGCKbmLSNQ0biJhrB = null;
            return that_0;
        }

        public n3.TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe __CreateDefault__()
        {
            n3.TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe that_0 = this;
            this.__cache_SwEwOTGCKbmLSNQ0biJhrB = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_SwEwOTGCKbmLSNQ0biJhrB);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 320679U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "VwaiuZahGJKO2364i9uQy8", Name = "__slot_VwaiuZahGJKO2364i9uQy8")]
        public static string __slot_VwaiuZahGJKO2364i9uQy8 = "\t    p*= scale;\r\n\t    float3 Tangent1 = normalize(float3(n.x, 1, n.y));\r\n\t    float3 Tangent2 = normalize(float3(n.y, 1, n.z));\r\n\t    float3 Tangent3 = normalize(float3(n.z, 1, n.x));\r\n\t    float3x3 TBN1, TBN2, TBN3;\r\n\t    TBN1[0] = Tangent1;\r\n\t    TBN1[1] = cross(Tangent1, n);\r\n\t    TBN1[2] = n;\r\n\t    TBN2[0] = Tangent2;\r\n\t    TBN2[1] = cross(Tangent2, n);\r\n\t    TBN2[2] = n;\r\n\t    TBN3[0] = Tangent3;\r\n\t    TBN3[1] = cross(Tangent3, n);\r\n\t    TBN3[2] = n;\r\n\r\n        float3 m = pow( abs( n ), k );\r\n        float3 n1 = tex.Sample( s, p.yz ).rgb * 2.0 - 1.0;;\r\n        float3 n2 = tex.Sample( s, p.zx ).rgb * 2.0 - 1.0;;\r\n        float3 n3 = tex.Sample( s, p.xy ).rgb * 2.0 - 1.0;;\r\n\t    // Transform normals into world space\r\n\t    n1 = mul(n1, TBN1);\r\n\t    n2 = mul(n2, TBN2);\r\n\t    n3 = mul(n3, TBN1);\r\n\t\r\n        return normalize((n1*m.x + n2*m.y + n3*m.z) / (m.x + m.y + m.z));";
        [n1.ElementAttribute(TracingId = 320688U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "E4XLlPiH6nkMG40UB1tvEF", Name = "__slot_E4XLlPiH6nkMG40UB1tvEF")]
        public static bool __slot_E4XLlPiH6nkMG40UB1tvEF = false;
        [n1.ElementAttribute(TracingId = 320503U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "SwEwOTGCKbmLSNQ0biJhrB", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n20.Manager<n2.ValueTuple<n11.GpuValue<n12.Texture>, n11.GpuValue<n12.SamplerState>, n11.GpuValue<n5.Vector3>, n11.GpuValue<float>, n11.GpuValue<float>>, n2.ValueTuple<n11.GpuValue<n5.Vector4>>> __cache_SwEwOTGCKbmLSNQ0biJhrB = null;
        [n1.ElementAttribute(TracingId = 320627U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "RuBt71Ftfd7OhMxLM2Uc05", Name = "__slot_RuBt71Ftfd7OhMxLM2Uc05")]
        public static string __slot_RuBt71Ftfd7OhMxLM2Uc05 = "FuseCoreTexture";
        [n1.ElementAttribute(TracingId = 320631U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "MO6MBS1jH1jNE1OzwN8V3i", Name = "__slot_MO6MBS1jH1jNE1OzwN8V3i")]
        public static string __slot_MO6MBS1jH1jNE1OzwN8V3i = "triPlaneNormal";
        [n1.ElementAttribute(TracingId = 320635U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "GRr4BINq68aQVHCW3HkFbL", Name = "__slot_GRr4BINq68aQVHCW3HkFbL")]
        public static n34.TextureAddressMode __slot_GRr4BINq68aQVHCW3HkFbL = n1.CompilationHelper.Deserialize<n34.TextureAddressMode>("Wrap", false, "O1Y26euhDfkOXD56tZlYl5", "GRr4BINq68aQVHCW3HkFbL");
        static TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe()
        {
        }

        public TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe(TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe other): base(other)
        {
            this.__cache_SwEwOTGCKbmLSNQ0biJhrB = other.__cache_SwEwOTGCKbmLSNQ0biJhrB;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_SwEwOTGCKbmLSNQ0biJhrB", in __cache_SwEwOTGCKbmLSNQ0biJhrB));
        }

        internal TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe __WITH__(n20.Manager<n2.ValueTuple<n11.GpuValue<n12.Texture>, n11.GpuValue<n12.SamplerState>, n11.GpuValue<n5.Vector3>, n11.GpuValue<float>, n11.GpuValue<float>>, n2.ValueTuple<n11.GpuValue<n5.Vector4>>> __cache_SwEwOTGCKbmLSNQ0biJhrB)
        {
            n3.TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_SwEwOTGCKbmLSNQ0biJhrB != this.__cache_SwEwOTGCKbmLSNQ0biJhrB ? new TriPlanarNormals_F9heGRX7EqPLWAHdSRUpHe(this)
                {__cache_SwEwOTGCKbmLSNQ0biJhrB = __cache_SwEwOTGCKbmLSNQ0biJhrB} : that_0;
            else
            {
                this.__cache_SwEwOTGCKbmLSNQ0biJhrB = __cache_SwEwOTGCKbmLSNQ0biJhrB;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "TmxOiY7WuZGMX9p9sJSyMa", Name = "__TmxOiY7WuZGMX9p9sJSyMa")]
        [n2.SerializableAttribute]
        public class __TmxOiY7WuZGMX9p9sJSyMa : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_KVhVuRExrdDNtUzxsZNalH);
                n1.CompilationHelper.SafeDispose(this.__p_LTdrwsh7DEPPwNtTuPQLVy);
                n1.CompilationHelper.SafeDispose(this.__p_J8SUYPyygQ1PNf3b1rv0Kk);
                n1.CompilationHelper.SafeDispose(this.__p_P3LXTLNTuayLH3zyHkOwpL);
                n1.CompilationHelper.SafeDispose(this.__p_SlM6e4zoELjNNJn2LHHFnK);
                n1.CompilationHelper.SafeDispose(this.__p_Ak5FslRKGbHQVNHilwSdwC);
                n1.CompilationHelper.SafeDispose(this.__p_Vv0aJxFJ2yuN3aHQGMNCjW);
                n1.CompilationHelper.SafeDispose(this.__p_BLN0P3yLN7mNmylssr2anS);
                n1.CompilationHelper.SafeDispose(this.__p_RqzTrkFNcp9Nq8X1YJ7HpE);
                n1.CompilationHelper.SafeDispose(this.__p_KpPvg3ljokYPQQNlBrrBfD);
                n1.CompilationHelper.SafeDispose(this.__p_PnZCpMv8mkiPUYBnOj9lKH);
                return;
            }

            [n1.ElementAttribute(TracingId = 320527U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "KVhVuRExrdDNtUzxsZNalH", Name = "xyz", IsManaged = true, IsAutoGenerated = true)]
            public n24.xyz_T2WwCF9xAltPhlUuLjVDje __p_KVhVuRExrdDNtUzxsZNalH;
            [n1.ElementAttribute(TracingId = 320538U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "LTdrwsh7DEPPwNtTuPQLVy", Name = "PositionWS", IsManaged = true, IsAutoGenerated = true)]
            public n26.PositionWS_EqNTwQZFoLOQdVEmvtk795 __p_LTdrwsh7DEPPwNtTuPQLVy;
            [n1.ElementAttribute(TracingId = 320547U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "J8SUYPyygQ1PNf3b1rv0Kk", Name = "MixinFunction", IsManaged = true, IsAutoGenerated = true)]
            public n31.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n5.Vector3> __p_J8SUYPyygQ1PNf3b1rv0Kk;
            [n1.ElementAttribute(TracingId = 320574U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "P3LXTLNTuayLH3zyHkOwpL", Name = "MeshNormalWS", IsManaged = true, IsAutoGenerated = true)]
            public n26.MeshNormalWS_Gppq7KtrvrwLtF4UYBlDgj __p_P3LXTLNTuayLH3zyHkOwpL;
            [n1.ElementAttribute(TracingId = 320579U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "SlM6e4zoELjNNJn2LHHFnK", Name = "xyz+w (join)", IsManaged = true, IsAutoGenerated = true)]
            public n28.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_SlM6e4zoELjNNJn2LHHFnK;
            [n1.ElementAttribute(TracingId = 320583U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Ak5FslRKGbHQVNHilwSdwC", Name = "SamplerState", IsManaged = true, IsAutoGenerated = true, NodeName = "SamplerState", NodeCategory = "Stride.Graphics.Advanced")]
            public n1.IVLNode __p_Ak5FslRKGbHQVNHilwSdwC;
            [n1.ElementAttribute(TracingId = 320608U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Vv0aJxFJ2yuN3aHQGMNCjW", Name = "SamplerIn (Fuse)", IsManaged = true, IsAutoGenerated = true)]
            public n32.SamplerIn_Fuse_Ow27E5pjREtLkbiG0rRYjW __p_Vv0aJxFJ2yuN3aHQGMNCjW;
            [n1.ElementAttribute(TracingId = 320619U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "BLN0P3yLN7mNmylssr2anS", Name = "CheckDefault (GpuValue)", IsManaged = true, IsAutoGenerated = true)]
            public n33.CheckDefault_GpuValue_PdsuywpUtM6PfMHKiPiuYX<n12.SamplerState> __p_BLN0P3yLN7mNmylssr2anS;
            [n1.ElementAttribute(TracingId = 320639U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "RqzTrkFNcp9Nq8X1YJ7HpE", Name = "ZERO", IsManaged = true, IsAutoGenerated = true)]
            public n21.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float> __p_RqzTrkFNcp9Nq8X1YJ7HpE;
            [n1.ElementAttribute(TracingId = 320645U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "KpPvg3ljokYPQQNlBrrBfD", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_KpPvg3ljokYPQQNlBrrBfD;
            [n1.ElementAttribute(TracingId = 320656U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "PnZCpMv8mkiPUYBnOj9lKH", Name = "To", IsManaged = true, IsAutoGenerated = true)]
            public n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, n5.Vector3> __p_PnZCpMv8mkiPUYBnOj9lKH;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.GpuValue<n5.Vector3>> __pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD = default(n18.Spread<n11.GpuValue<n5.Vector3>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.AbstractGpuValue> __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk = default(n18.Spread<n11.AbstractGpuValue>);
            public __TmxOiY7WuZGMX9p9sJSyMa(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __TmxOiY7WuZGMX9p9sJSyMa(__TmxOiY7WuZGMX9p9sJSyMa other): base(other)
            {
                this.__p_KVhVuRExrdDNtUzxsZNalH = other.__p_KVhVuRExrdDNtUzxsZNalH;
                this.__p_LTdrwsh7DEPPwNtTuPQLVy = other.__p_LTdrwsh7DEPPwNtTuPQLVy;
                this.__p_J8SUYPyygQ1PNf3b1rv0Kk = other.__p_J8SUYPyygQ1PNf3b1rv0Kk;
                this.__p_P3LXTLNTuayLH3zyHkOwpL = other.__p_P3LXTLNTuayLH3zyHkOwpL;
                this.__p_SlM6e4zoELjNNJn2LHHFnK = other.__p_SlM6e4zoELjNNJn2LHHFnK;
                this.__p_Ak5FslRKGbHQVNHilwSdwC = other.__p_Ak5FslRKGbHQVNHilwSdwC;
                this.__p_Vv0aJxFJ2yuN3aHQGMNCjW = other.__p_Vv0aJxFJ2yuN3aHQGMNCjW;
                this.__p_BLN0P3yLN7mNmylssr2anS = other.__p_BLN0P3yLN7mNmylssr2anS;
                this.__p_RqzTrkFNcp9Nq8X1YJ7HpE = other.__p_RqzTrkFNcp9Nq8X1YJ7HpE;
                this.__p_KpPvg3ljokYPQQNlBrrBfD = other.__p_KpPvg3ljokYPQQNlBrrBfD;
                this.__p_PnZCpMv8mkiPUYBnOj9lKH = other.__p_PnZCpMv8mkiPUYBnOj9lKH;
                this.__pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD = other.__pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD;
                this.__pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk = other.__pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_KVhVuRExrdDNtUzxsZNalH", in __p_KVhVuRExrdDNtUzxsZNalH), n1.CompilationHelper.GetValueOrExisting(values, "__p_LTdrwsh7DEPPwNtTuPQLVy", in __p_LTdrwsh7DEPPwNtTuPQLVy), n1.CompilationHelper.GetValueOrExisting(values, "__p_J8SUYPyygQ1PNf3b1rv0Kk", in __p_J8SUYPyygQ1PNf3b1rv0Kk), n1.CompilationHelper.GetValueOrExisting(values, "__p_P3LXTLNTuayLH3zyHkOwpL", in __p_P3LXTLNTuayLH3zyHkOwpL), n1.CompilationHelper.GetValueOrExisting(values, "__p_SlM6e4zoELjNNJn2LHHFnK", in __p_SlM6e4zoELjNNJn2LHHFnK), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ak5FslRKGbHQVNHilwSdwC", in __p_Ak5FslRKGbHQVNHilwSdwC), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vv0aJxFJ2yuN3aHQGMNCjW", in __p_Vv0aJxFJ2yuN3aHQGMNCjW), n1.CompilationHelper.GetValueOrExisting(values, "__p_BLN0P3yLN7mNmylssr2anS", in __p_BLN0P3yLN7mNmylssr2anS), n1.CompilationHelper.GetValueOrExisting(values, "__p_RqzTrkFNcp9Nq8X1YJ7HpE", in __p_RqzTrkFNcp9Nq8X1YJ7HpE), n1.CompilationHelper.GetValueOrExisting(values, "__p_KpPvg3ljokYPQQNlBrrBfD", in __p_KpPvg3ljokYPQQNlBrrBfD), n1.CompilationHelper.GetValueOrExisting(values, "__p_PnZCpMv8mkiPUYBnOj9lKH", in __p_PnZCpMv8mkiPUYBnOj9lKH), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD", in __pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk", in __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk));
            }

            internal __TmxOiY7WuZGMX9p9sJSyMa __WITH__(n24.xyz_T2WwCF9xAltPhlUuLjVDje __p_KVhVuRExrdDNtUzxsZNalH, n26.PositionWS_EqNTwQZFoLOQdVEmvtk795 __p_LTdrwsh7DEPPwNtTuPQLVy, n31.MixinFunction_PbBd46gEgn9QQSstPcUUPi<n5.Vector3> __p_J8SUYPyygQ1PNf3b1rv0Kk, n26.MeshNormalWS_Gppq7KtrvrwLtF4UYBlDgj __p_P3LXTLNTuayLH3zyHkOwpL, n28.xyzPw_join_Hk5ZXTAZsWnPywHBGnhx8l __p_SlM6e4zoELjNNJn2LHHFnK, n1.IVLNode __p_Ak5FslRKGbHQVNHilwSdwC, n32.SamplerIn_Fuse_Ow27E5pjREtLkbiG0rRYjW __p_Vv0aJxFJ2yuN3aHQGMNCjW, n33.CheckDefault_GpuValue_PdsuywpUtM6PfMHKiPiuYX<n12.SamplerState> __p_BLN0P3yLN7mNmylssr2anS, n21.ZERO_VCHAwwn3zHKNb7JLcjVhA5<float> __p_RqzTrkFNcp9Nq8X1YJ7HpE, n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<n5.Vector3> __p_KpPvg3ljokYPQQNlBrrBfD, n22.To_Qgkn15Kxt1HLURmAdSAN7m<float, n5.Vector3> __p_PnZCpMv8mkiPUYBnOj9lKH, n18.Spread<n11.GpuValue<n5.Vector3>> __pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD, n18.Spread<n11.AbstractGpuValue> __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk)
            {
                __TmxOiY7WuZGMX9p9sJSyMa that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_KVhVuRExrdDNtUzxsZNalH != this.__p_KVhVuRExrdDNtUzxsZNalH || __p_LTdrwsh7DEPPwNtTuPQLVy != this.__p_LTdrwsh7DEPPwNtTuPQLVy || __p_J8SUYPyygQ1PNf3b1rv0Kk != this.__p_J8SUYPyygQ1PNf3b1rv0Kk || __p_P3LXTLNTuayLH3zyHkOwpL != this.__p_P3LXTLNTuayLH3zyHkOwpL || __p_SlM6e4zoELjNNJn2LHHFnK != this.__p_SlM6e4zoELjNNJn2LHHFnK || __p_Ak5FslRKGbHQVNHilwSdwC != this.__p_Ak5FslRKGbHQVNHilwSdwC || __p_Vv0aJxFJ2yuN3aHQGMNCjW != this.__p_Vv0aJxFJ2yuN3aHQGMNCjW || __p_BLN0P3yLN7mNmylssr2anS != this.__p_BLN0P3yLN7mNmylssr2anS || __p_RqzTrkFNcp9Nq8X1YJ7HpE != this.__p_RqzTrkFNcp9Nq8X1YJ7HpE || __p_KpPvg3ljokYPQQNlBrrBfD != this.__p_KpPvg3ljokYPQQNlBrrBfD || __p_PnZCpMv8mkiPUYBnOj9lKH != this.__p_PnZCpMv8mkiPUYBnOj9lKH || __pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD != this.__pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD || __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk != this.__pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk ? new __TmxOiY7WuZGMX9p9sJSyMa(this)
                    {__p_KVhVuRExrdDNtUzxsZNalH = __p_KVhVuRExrdDNtUzxsZNalH, __p_LTdrwsh7DEPPwNtTuPQLVy = __p_LTdrwsh7DEPPwNtTuPQLVy, __p_J8SUYPyygQ1PNf3b1rv0Kk = __p_J8SUYPyygQ1PNf3b1rv0Kk, __p_P3LXTLNTuayLH3zyHkOwpL = __p_P3LXTLNTuayLH3zyHkOwpL, __p_SlM6e4zoELjNNJn2LHHFnK = __p_SlM6e4zoELjNNJn2LHHFnK, __p_Ak5FslRKGbHQVNHilwSdwC = __p_Ak5FslRKGbHQVNHilwSdwC, __p_Vv0aJxFJ2yuN3aHQGMNCjW = __p_Vv0aJxFJ2yuN3aHQGMNCjW, __p_BLN0P3yLN7mNmylssr2anS = __p_BLN0P3yLN7mNmylssr2anS, __p_RqzTrkFNcp9Nq8X1YJ7HpE = __p_RqzTrkFNcp9Nq8X1YJ7HpE, __p_KpPvg3ljokYPQQNlBrrBfD = __p_KpPvg3ljokYPQQNlBrrBfD, __p_PnZCpMv8mkiPUYBnOj9lKH = __p_PnZCpMv8mkiPUYBnOj9lKH, __pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD = __pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD, __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk = __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk} : that_0;
                else
                {
                    this.__p_KVhVuRExrdDNtUzxsZNalH = __p_KVhVuRExrdDNtUzxsZNalH;
                    this.__p_LTdrwsh7DEPPwNtTuPQLVy = __p_LTdrwsh7DEPPwNtTuPQLVy;
                    this.__p_J8SUYPyygQ1PNf3b1rv0Kk = __p_J8SUYPyygQ1PNf3b1rv0Kk;
                    this.__p_P3LXTLNTuayLH3zyHkOwpL = __p_P3LXTLNTuayLH3zyHkOwpL;
                    this.__p_SlM6e4zoELjNNJn2LHHFnK = __p_SlM6e4zoELjNNJn2LHHFnK;
                    this.__p_Ak5FslRKGbHQVNHilwSdwC = __p_Ak5FslRKGbHQVNHilwSdwC;
                    this.__p_Vv0aJxFJ2yuN3aHQGMNCjW = __p_Vv0aJxFJ2yuN3aHQGMNCjW;
                    this.__p_BLN0P3yLN7mNmylssr2anS = __p_BLN0P3yLN7mNmylssr2anS;
                    this.__p_RqzTrkFNcp9Nq8X1YJ7HpE = __p_RqzTrkFNcp9Nq8X1YJ7HpE;
                    this.__p_KpPvg3ljokYPQQNlBrrBfD = __p_KpPvg3ljokYPQQNlBrrBfD;
                    this.__p_PnZCpMv8mkiPUYBnOj9lKH = __p_PnZCpMv8mkiPUYBnOj9lKH;
                    this.__pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD = __pin_group_Input_In_KpPvg3ljokYPQQNlBrrBfD;
                    this.__pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk = __pin_group_Arguments_In_J8SUYPyygQ1PNf3b1rv0Kk;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 320768U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Sapn2q8V4SzLAAU61xnZNn", Name = "Fresnel_Sapn2q8V4SzLAAU61xnZNn")]
    [n2.SerializableAttribute]
    public class Fresnel_Sapn2q8V4SzLAAU61xnZNn : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Fresnel_Sapn2q8V4SzLAAU61xnZNn Create(n1.NodeContext Node_Context)
        {
            var instance = new Fresnel_Sapn2q8V4SzLAAU61xnZNn(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Fresnel_Sapn2q8V4SzLAAU61xnZNn CreateDefault()
        {
            var instance = new Fresnel_Sapn2q8V4SzLAAU61xnZNn(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Fresnel_Sapn2q8V4SzLAAU61xnZNn Update([n4.SerializedDefaultValueAttribute("1", false)] n11.GpuValue<float> Exponent_In, [n4.SerializedDefaultValueAttribute("1.25", false)] n11.GpuValue<float> Scale_In, n11.GpuValue<float> Bias_In, bool Invert_In, out n11.GpuValue<float> Fresnel_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_QEpSW3SaPlkLxJwrdpK1vl;
            if (manager_2 is null)
            {
                manager_2 = new n20.Manager<n2.ValueTuple<n11.GpuValue<float>, n11.GpuValue<float>, n11.GpuValue<float>, bool>, n2.ValueTuple<n11.GpuValue<float>>>(n2.ValueTuple.Create(default(n11.GpuValue<float>)));
            }

            var inputs_3 = (Exponent_In, Scale_In, Bias_In, Invert_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__UfQE40yWIVoM0IhB4PXGZ9>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __UfQE40yWIVoM0IhB4PXGZ9(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G = n19._Operations_.CreateDefault<n11.GpuValue<float>>(), __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF = n19._Operations_.CreateDefault<n11.GpuValue<n5.Vector4>>(), __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR = n19._Operations_.CreateDefault<n11.GpuValue<float>>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "ALJLKbUnpg4Ld1TVu2yV3G", 320788U);
                    var Output_8 = n21.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float>.Create(Node_Context: Node_Context_7);
                    state_6.__p_ALJLKbUnpg4Ld1TVu2yV3G = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "Gf6UMsRHDchOwZifUXtTXj", 320794U);
                    var Output_10 = n33.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_9);
                    state_6.__p_Gf6UMsRHDchOwZifUXtTXj = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "SOkdVR6F2qnNQk8CPNezhO", 320803U);
                    var Output_12 = n26.Eye_RqdQkneNJa7QajqXnXfDYz.Create(Node_Context: Node_Context_11);
                    state_6.__p_SOkdVR6F2qnNQk8CPNezhO = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "UcgxSrCoPzxNZrOLDoygZx", 320807U);
                    var Output_14 = n26.PositionWS_EqNTwQZFoLOQdVEmvtk795.Create(Node_Context: Node_Context_13);
                    state_6.__p_UcgxSrCoPzxNZrOLDoygZx = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "B7LvXJ1jTflOQbVuBcADSF", 320809U);
                    var Output_16 = n21.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n5.Vector4>.Create(Node_Context: Node_Context_15);
                    state_6.__p_B7LvXJ1jTflOQbVuBcADSF = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "J4a5k9JxKRXQBninAf1asY", 320813U);
                    var Output_18 = n21.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector4>.Create(Node_Context: Node_Context_17);
                    state_6.__p_J4a5k9JxKRXQBninAf1asY = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "EMm2nWU9uNON6L4SskQ44E", 320820U);
                    var Output_20 = n26.NormalWS_Gr7aABUWwEjNM3XChZ7Tfy.Create(Node_Context: Node_Context_19);
                    state_6.__p_EMm2nWU9uNON6L4SskQ44E = Output_20;
                    n1.NodeContext Node_Context_21 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "LkaxvX7n0CpOSkifYChTIP", 320825U);
                    var Output_22 = n21.Dot_VjBgbBbkOkiMLqm9EWGCSn<n5.Vector4>.Create(Node_Context: Node_Context_21);
                    state_6.__p_LkaxvX7n0CpOSkifYChTIP = Output_22;
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "LylWYed3JcAMyzxyCdf3tt", 320833U);
                    var Output_24 = n21.Saturate_HJGjOY7U6BSLBVUcDCTES2<float>.Create(Node_Context: Node_Context_23);
                    state_6.__p_LylWYed3JcAMyzxyCdf3tt = Output_24;
                    n1.NodeContext Node_Context_25 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "QzuWzqZ7Gc0MqhmZWoST3K", 320836U);
                    var Output_26 = n21.OneMinus_TZSID1klGMVLkhX7sgErcR<float>.Create(Node_Context: Node_Context_25);
                    state_6.__p_QzuWzqZ7Gc0MqhmZWoST3K = Output_26;
                    n1.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "RcfTUE1M6i7PvvowhsyZ7j", 320842U);
                    var Output_28 = n21.Pow_OYho3WrJhN0LWEmoMe81d4<float>.Create(Node_Context: Node_Context_27);
                    state_6.__p_RcfTUE1M6i7PvvowhsyZ7j = Output_28;
                    n1.NodeContext Node_Context_29 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "KdqY4my5zQFOKdY5BJCzKk", 320849U);
                    var Output_30 = n21.Saturate_HJGjOY7U6BSLBVUcDCTES2<float>.Create(Node_Context: Node_Context_29);
                    state_6.__p_KdqY4my5zQFOKdY5BJCzKk = Output_30;
                    n1.NodeContext Node_Context_31 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "BXXWPbyBnRPMuXc8Z4yJLR", 320853U);
                    var Output_32 = n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float>.Create(Node_Context: Node_Context_31);
                    state_6.__p_BXXWPbyBnRPMuXc8Z4yJLR = Output_32;
                    n1.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "B1EXEsUmCZbO95nBNxiwDP", 320862U);
                    var Output_34 = n36.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<float>.Create(Node_Context: Node_Context_33);
                    state_6.__p_B1EXEsUmCZbO95nBNxiwDP = Output_34;
                    n1.NodeContext Node_Context_35 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "DaNDpQZbMO6NQNXq64Dd2s", 320880U);
                    var Output_36 = n33.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_35);
                    state_6.__p_DaNDpQZbMO6NQNXq64Dd2s = Output_36;
                    n1.NodeContext Node_Context_37 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "KsUDXy8xriiNOUjhwhiGRN", 320892U);
                    var Output_38 = n33.CheckDefaultBooleanWorkaround_UeszWB8mLbnLw7rj4EXhp5.Create(Node_Context: Node_Context_37);
                    state_6.__p_KsUDXy8xriiNOUjhwhiGRN = Output_38;
                    n1.NodeContext Node_Context_39 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "H0uGKoLAAIhOW1zbcmkYf2", 320912U);
                    var Output_40 = n21.OneMinus_TZSID1klGMVLkhX7sgErcR<float>.Create(Node_Context: Node_Context_39);
                    state_6.__p_H0uGKoLAAIhOW1zbcmkYf2 = Output_40;
                    n1.NodeContext Node_Context_41 = __GetContext__().CreateSubContext("O1Y26euhDfkOXD56tZlYl5", "QdWbc3eNeTjP4uatDCQ6Ql", 320922U);
                    var Output_42 = n33.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float>.Create(Node_Context: Node_Context_41);
                    state_6.__p_QdWbc3eNeTjP4uatDCQ6Ql = Output_42;
                }

                float __pad_QsOTg261qo1PHYpU7MgOXO_43 = __slot_QsOTg261qo1PHYpU7MgOXO;
                float __pad_SdtJzckIrkgMzeWK5rgvOY_44 = __slot_SdtJzckIrkgMzeWK5rgvOY;
                float __pad_Oc9R0iOyZ3ANSEtsZSQexI_45 = __slot_Oc9R0iOyZ3ANSEtsZSQexI;
                bool __pad_RaXO0UwLa4qLjEZHhkb8vt_46 = __slot_RaXO0UwLa4qLjEZHhkb8vt;
                var State_Output_48 = state_6.__p_Gf6UMsRHDchOwZifUXtTXj.Update(GpuValue_In: Scale_In, The_Value_In: __pad_QsOTg261qo1PHYpU7MgOXO_43, Output_Out: out n11.GpuValue<float> Output_47);
                var State_Output_50 = state_6.__p_QdWbc3eNeTjP4uatDCQ6Ql.Update(GpuValue_In: Bias_In, The_Value_In: __pad_SdtJzckIrkgMzeWK5rgvOY_44, Output_Out: out n11.GpuValue<float> Output_49);
                var builder_51 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G, 2);
                builder_51.Add(Output_47);
                builder_51.Add(Output_49);
                var __pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G_52 = builder_51.Commit();
                var State_Output_54 = state_6.__p_ALJLKbUnpg4Ld1TVu2yV3G.Update(Input_In: __pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G_52, Output_Out: out n11.GpuValue<float> Output_53);
                var State_Output_56 = state_6.__p_EMm2nWU9uNON6L4SskQ44E.Update(Output_Out: out n11.GpuValue<n5.Vector4> Output_55);
                var State_Output_58 = state_6.__p_SOkdVR6F2qnNQk8CPNezhO.Update(Output_Out: out n11.GpuValue<n5.Vector4> Output_57);
                var State_Output_60 = state_6.__p_UcgxSrCoPzxNZrOLDoygZx.Update(Output_Out: out n11.GpuValue<n5.Vector4> Output_59);
                var builder_61 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF, 2);
                builder_61.Add(Output_57);
                builder_61.Add(Output_59);
                var __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF_62 = builder_61.Commit();
                var State_Output_64 = state_6.__p_B7LvXJ1jTflOQbVuBcADSF.Update(Input_In: __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF_62, Output_Out: out n11.GpuValue<n5.Vector4> Output_63);
                var State_Output_66 = state_6.__p_J4a5k9JxKRXQBninAf1asY.Update(Input_In: Output_63, Output_Out: out n11.GpuValue<n5.Vector4> Output_65);
                var State_Output_68 = state_6.__p_LkaxvX7n0CpOSkifYChTIP.Update(Input1_In: Output_55, Input2_In: Output_65, Output_Out: out n11.GpuValue<float> Output_67);
                var State_Output_70 = state_6.__p_QzuWzqZ7Gc0MqhmZWoST3K.Update(Input_In: Output_67, Output_Out: out n11.GpuValue<float> Output_69);
                var State_Output_72 = state_6.__p_LylWYed3JcAMyzxyCdf3tt.Update(Input_In: Output_69, Output_Out: out n11.GpuValue<float> Output_71);
                var State_Output_74 = state_6.__p_DaNDpQZbMO6NQNXq64Dd2s.Update(GpuValue_In: Exponent_In, The_Value_In: __pad_Oc9R0iOyZ3ANSEtsZSQexI_45, Output_Out: out n11.GpuValue<float> Output_73);
                var State_Output_76 = state_6.__p_RcfTUE1M6i7PvvowhsyZ7j.Update(Input_In: Output_71, Pow_In: Output_73, Output_Out: out n11.GpuValue<float> Output_75);
                var builder_77 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR, 2);
                builder_77.Add(Output_75);
                builder_77.Add(Output_53);
                var __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR_78 = builder_77.Commit();
                var State_Output_80 = state_6.__p_BXXWPbyBnRPMuXc8Z4yJLR.Update(Input_In: __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR_78, Output_Out: out n11.GpuValue<float> Output_79);
                var State_Output_82 = state_6.__p_KdqY4my5zQFOKdY5BJCzKk.Update(Input_In: Output_79, Output_Out: out n11.GpuValue<float> Output_81);
                n11.GpuValue<bool> GpuValue_83 = state_6.__monadBuilder_NxZJMJZ52ujLvveoqeLCTR.Return(Invert_In);
                var State_Output_85 = state_6.__p_KsUDXy8xriiNOUjhwhiGRN.Update(GpuValue_In: GpuValue_83, The_Value_In: __pad_RaXO0UwLa4qLjEZHhkb8vt_46, Output_Out: out n11.GpuValue<bool> Output_84);
                var State_Output_87 = state_6.__p_H0uGKoLAAIhOW1zbcmkYf2.Update(Input_In: Output_81, Output_Out: out n11.GpuValue<float> Output_86);
                n11.GpuValue<float> The_Default_88 = default(n11.GpuValue<float>);
                var State_Output_90 = state_6.__p_B1EXEsUmCZbO95nBNxiwDP.Update(In_Check_In: Output_84, In_False_In: Output_81, In_True_In: Output_86, The_Default_In: The_Default_88, Output_Out: out n11.GpuValue<float> Output_89);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_48 != state_6.__p_Gf6UMsRHDchOwZifUXtTXj || State_Output_50 != state_6.__p_QdWbc3eNeTjP4uatDCQ6Ql || __pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G_52 != state_6.__pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G || State_Output_54 != state_6.__p_ALJLKbUnpg4Ld1TVu2yV3G || State_Output_56 != state_6.__p_EMm2nWU9uNON6L4SskQ44E || State_Output_58 != state_6.__p_SOkdVR6F2qnNQk8CPNezhO || State_Output_60 != state_6.__p_UcgxSrCoPzxNZrOLDoygZx || __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF_62 != state_6.__pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF || State_Output_64 != state_6.__p_B7LvXJ1jTflOQbVuBcADSF || State_Output_66 != state_6.__p_J4a5k9JxKRXQBninAf1asY || State_Output_68 != state_6.__p_LkaxvX7n0CpOSkifYChTIP || State_Output_70 != state_6.__p_QzuWzqZ7Gc0MqhmZWoST3K || State_Output_72 != state_6.__p_LylWYed3JcAMyzxyCdf3tt || State_Output_74 != state_6.__p_DaNDpQZbMO6NQNXq64Dd2s || State_Output_76 != state_6.__p_RcfTUE1M6i7PvvowhsyZ7j || __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR_78 != state_6.__pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR || State_Output_80 != state_6.__p_BXXWPbyBnRPMuXc8Z4yJLR || State_Output_82 != state_6.__p_KdqY4my5zQFOKdY5BJCzKk || State_Output_85 != state_6.__p_KsUDXy8xriiNOUjhwhiGRN || State_Output_87 != state_6.__p_H0uGKoLAAIhOW1zbcmkYf2 || State_Output_90 != state_6.__p_B1EXEsUmCZbO95nBNxiwDP ? new __UfQE40yWIVoM0IhB4PXGZ9(state_6)
                    {__p_Gf6UMsRHDchOwZifUXtTXj = State_Output_48, __p_QdWbc3eNeTjP4uatDCQ6Ql = State_Output_50, __pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G = __pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G_52, __p_ALJLKbUnpg4Ld1TVu2yV3G = State_Output_54, __p_EMm2nWU9uNON6L4SskQ44E = State_Output_56, __p_SOkdVR6F2qnNQk8CPNezhO = State_Output_58, __p_UcgxSrCoPzxNZrOLDoygZx = State_Output_60, __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF = __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF_62, __p_B7LvXJ1jTflOQbVuBcADSF = State_Output_64, __p_J4a5k9JxKRXQBninAf1asY = State_Output_66, __p_LkaxvX7n0CpOSkifYChTIP = State_Output_68, __p_QzuWzqZ7Gc0MqhmZWoST3K = State_Output_70, __p_LylWYed3JcAMyzxyCdf3tt = State_Output_72, __p_DaNDpQZbMO6NQNXq64Dd2s = State_Output_74, __p_RcfTUE1M6i7PvvowhsyZ7j = State_Output_76, __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR = __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR_78, __p_BXXWPbyBnRPMuXc8Z4yJLR = State_Output_80, __p_KdqY4my5zQFOKdY5BJCzKk = State_Output_82, __p_KsUDXy8xriiNOUjhwhiGRN = State_Output_85, __p_H0uGKoLAAIhOW1zbcmkYf2 = State_Output_87, __p_B1EXEsUmCZbO95nBNxiwDP = State_Output_90} : state_6;
                else
                {
                    state_6.__p_Gf6UMsRHDchOwZifUXtTXj = State_Output_48;
                    state_6.__p_QdWbc3eNeTjP4uatDCQ6Ql = State_Output_50;
                    state_6.__pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G = __pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G_52;
                    state_6.__p_ALJLKbUnpg4Ld1TVu2yV3G = State_Output_54;
                    state_6.__p_EMm2nWU9uNON6L4SskQ44E = State_Output_56;
                    state_6.__p_SOkdVR6F2qnNQk8CPNezhO = State_Output_58;
                    state_6.__p_UcgxSrCoPzxNZrOLDoygZx = State_Output_60;
                    state_6.__pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF = __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF_62;
                    state_6.__p_B7LvXJ1jTflOQbVuBcADSF = State_Output_64;
                    state_6.__p_J4a5k9JxKRXQBninAf1asY = State_Output_66;
                    state_6.__p_LkaxvX7n0CpOSkifYChTIP = State_Output_68;
                    state_6.__p_QzuWzqZ7Gc0MqhmZWoST3K = State_Output_70;
                    state_6.__p_LylWYed3JcAMyzxyCdf3tt = State_Output_72;
                    state_6.__p_DaNDpQZbMO6NQNXq64Dd2s = State_Output_74;
                    state_6.__p_RcfTUE1M6i7PvvowhsyZ7j = State_Output_76;
                    state_6.__pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR = __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR_78;
                    state_6.__p_BXXWPbyBnRPMuXc8Z4yJLR = State_Output_80;
                    state_6.__p_KdqY4my5zQFOKdY5BJCzKk = State_Output_82;
                    state_6.__p_KsUDXy8xriiNOUjhwhiGRN = State_Output_85;
                    state_6.__p_H0uGKoLAAIhOW1zbcmkYf2 = State_Output_87;
                    state_6.__p_B1EXEsUmCZbO95nBNxiwDP = State_Output_90;
                }

                outputs_4 = n2.ValueTuple.Create(Output_89);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_91 = outputs_4.Item1;
            Fresnel_Out = __auto_91;
            n3.Fresnel_Sapn2q8V4SzLAAU61xnZNn that_92 = this;
            if (this.__GetContext__().IsImmutable)
                that_92 = manager_2 != this.__cache_QEpSW3SaPlkLxJwrdpK1vl ? new Fresnel_Sapn2q8V4SzLAAU61xnZNn(this)
                {__cache_QEpSW3SaPlkLxJwrdpK1vl = manager_2} : that_92;
            else
            {
                this.__cache_QEpSW3SaPlkLxJwrdpK1vl = manager_2;
            }

            return that_92;
        }

        public n3.Fresnel_Sapn2q8V4SzLAAU61xnZNn __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.Fresnel_Sapn2q8V4SzLAAU61xnZNn that_0 = this;
            this.__cache_QEpSW3SaPlkLxJwrdpK1vl = null;
            return that_0;
        }

        public n3.Fresnel_Sapn2q8V4SzLAAU61xnZNn __CreateDefault__()
        {
            n3.Fresnel_Sapn2q8V4SzLAAU61xnZNn that_0 = this;
            this.__cache_QEpSW3SaPlkLxJwrdpK1vl = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_QEpSW3SaPlkLxJwrdpK1vl);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 320772U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "QEpSW3SaPlkLxJwrdpK1vl", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n20.Manager<n2.ValueTuple<n11.GpuValue<float>, n11.GpuValue<float>, n11.GpuValue<float>, bool>, n2.ValueTuple<n11.GpuValue<float>>> __cache_QEpSW3SaPlkLxJwrdpK1vl = null;
        [n1.ElementAttribute(TracingId = 320800U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "QsOTg261qo1PHYpU7MgOXO", Name = "__slot_QsOTg261qo1PHYpU7MgOXO")]
        public static float __slot_QsOTg261qo1PHYpU7MgOXO = 1.27F;
        [n1.ElementAttribute(TracingId = 320802U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "SdtJzckIrkgMzeWK5rgvOY", Name = "__slot_SdtJzckIrkgMzeWK5rgvOY")]
        public static float __slot_SdtJzckIrkgMzeWK5rgvOY = 0F;
        [n1.ElementAttribute(TracingId = 320876U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Oc9R0iOyZ3ANSEtsZSQexI", Name = "__slot_Oc9R0iOyZ3ANSEtsZSQexI")]
        public static float __slot_Oc9R0iOyZ3ANSEtsZSQexI = 1F;
        [n1.ElementAttribute(TracingId = 320903U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "RaXO0UwLa4qLjEZHhkb8vt", Name = "__slot_RaXO0UwLa4qLjEZHhkb8vt")]
        public static bool __slot_RaXO0UwLa4qLjEZHhkb8vt = false;
        static Fresnel_Sapn2q8V4SzLAAU61xnZNn()
        {
        }

        public Fresnel_Sapn2q8V4SzLAAU61xnZNn(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Fresnel_Sapn2q8V4SzLAAU61xnZNn(Fresnel_Sapn2q8V4SzLAAU61xnZNn other): base(other)
        {
            this.__cache_QEpSW3SaPlkLxJwrdpK1vl = other.__cache_QEpSW3SaPlkLxJwrdpK1vl;
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_QEpSW3SaPlkLxJwrdpK1vl", in __cache_QEpSW3SaPlkLxJwrdpK1vl));
        }

        internal Fresnel_Sapn2q8V4SzLAAU61xnZNn __WITH__(n20.Manager<n2.ValueTuple<n11.GpuValue<float>, n11.GpuValue<float>, n11.GpuValue<float>, bool>, n2.ValueTuple<n11.GpuValue<float>>> __cache_QEpSW3SaPlkLxJwrdpK1vl)
        {
            n3.Fresnel_Sapn2q8V4SzLAAU61xnZNn that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_QEpSW3SaPlkLxJwrdpK1vl != this.__cache_QEpSW3SaPlkLxJwrdpK1vl ? new Fresnel_Sapn2q8V4SzLAAU61xnZNn(this)
                {__cache_QEpSW3SaPlkLxJwrdpK1vl = __cache_QEpSW3SaPlkLxJwrdpK1vl} : that_0;
            else
            {
                this.__cache_QEpSW3SaPlkLxJwrdpK1vl = __cache_QEpSW3SaPlkLxJwrdpK1vl;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "UfQE40yWIVoM0IhB4PXGZ9", Name = "__UfQE40yWIVoM0IhB4PXGZ9")]
        [n2.SerializableAttribute]
        public class __UfQE40yWIVoM0IhB4PXGZ9 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_ALJLKbUnpg4Ld1TVu2yV3G);
                n1.CompilationHelper.SafeDispose(this.__p_Gf6UMsRHDchOwZifUXtTXj);
                n1.CompilationHelper.SafeDispose(this.__p_SOkdVR6F2qnNQk8CPNezhO);
                n1.CompilationHelper.SafeDispose(this.__p_UcgxSrCoPzxNZrOLDoygZx);
                n1.CompilationHelper.SafeDispose(this.__p_B7LvXJ1jTflOQbVuBcADSF);
                n1.CompilationHelper.SafeDispose(this.__p_J4a5k9JxKRXQBninAf1asY);
                n1.CompilationHelper.SafeDispose(this.__p_EMm2nWU9uNON6L4SskQ44E);
                n1.CompilationHelper.SafeDispose(this.__p_LkaxvX7n0CpOSkifYChTIP);
                n1.CompilationHelper.SafeDispose(this.__p_LylWYed3JcAMyzxyCdf3tt);
                n1.CompilationHelper.SafeDispose(this.__p_QzuWzqZ7Gc0MqhmZWoST3K);
                n1.CompilationHelper.SafeDispose(this.__p_RcfTUE1M6i7PvvowhsyZ7j);
                n1.CompilationHelper.SafeDispose(this.__p_KdqY4my5zQFOKdY5BJCzKk);
                n1.CompilationHelper.SafeDispose(this.__p_BXXWPbyBnRPMuXc8Z4yJLR);
                n1.CompilationHelper.SafeDispose(this.__p_B1EXEsUmCZbO95nBNxiwDP);
                n1.CompilationHelper.SafeDispose(this.__p_DaNDpQZbMO6NQNXq64Dd2s);
                n1.CompilationHelper.SafeDispose(this.__p_KsUDXy8xriiNOUjhwhiGRN);
                n1.CompilationHelper.SafeDispose(this.__p_H0uGKoLAAIhOW1zbcmkYf2);
                n1.CompilationHelper.SafeDispose(this.__p_QdWbc3eNeTjP4uatDCQ6Ql);
                n1.CompilationHelper.SafeDispose(this.__monadBuilder_NxZJMJZ52ujLvveoqeLCTR);
                return;
            }

            [n1.ElementAttribute(TracingId = 320788U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "ALJLKbUnpg4Ld1TVu2yV3G", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n21.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float> __p_ALJLKbUnpg4Ld1TVu2yV3G;
            [n1.ElementAttribute(TracingId = 320794U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Gf6UMsRHDchOwZifUXtTXj", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n33.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_Gf6UMsRHDchOwZifUXtTXj;
            [n1.ElementAttribute(TracingId = 320803U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "SOkdVR6F2qnNQk8CPNezhO", Name = "Eye", IsManaged = true, IsAutoGenerated = true)]
            public n26.Eye_RqdQkneNJa7QajqXnXfDYz __p_SOkdVR6F2qnNQk8CPNezhO;
            [n1.ElementAttribute(TracingId = 320807U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "UcgxSrCoPzxNZrOLDoygZx", Name = "PositionWS", IsManaged = true, IsAutoGenerated = true)]
            public n26.PositionWS_EqNTwQZFoLOQdVEmvtk795 __p_UcgxSrCoPzxNZrOLDoygZx;
            [n1.ElementAttribute(TracingId = 320809U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "B7LvXJ1jTflOQbVuBcADSF", Name = "-", IsManaged = true, IsAutoGenerated = true)]
            public n21.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n5.Vector4> __p_B7LvXJ1jTflOQbVuBcADSF;
            [n1.ElementAttribute(TracingId = 320813U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "J4a5k9JxKRXQBninAf1asY", Name = "Normalize", IsManaged = true, IsAutoGenerated = true)]
            public n21.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector4> __p_J4a5k9JxKRXQBninAf1asY;
            [n1.ElementAttribute(TracingId = 320820U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "EMm2nWU9uNON6L4SskQ44E", Name = "NormalWS", IsManaged = true, IsAutoGenerated = true)]
            public n26.NormalWS_Gr7aABUWwEjNM3XChZ7Tfy __p_EMm2nWU9uNON6L4SskQ44E;
            [n1.ElementAttribute(TracingId = 320825U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "LkaxvX7n0CpOSkifYChTIP", Name = "Dot", IsManaged = true, IsAutoGenerated = true)]
            public n21.Dot_VjBgbBbkOkiMLqm9EWGCSn<n5.Vector4> __p_LkaxvX7n0CpOSkifYChTIP;
            [n1.ElementAttribute(TracingId = 320833U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "LylWYed3JcAMyzxyCdf3tt", Name = "Saturate", IsManaged = true, IsAutoGenerated = true)]
            public n21.Saturate_HJGjOY7U6BSLBVUcDCTES2<float> __p_LylWYed3JcAMyzxyCdf3tt;
            [n1.ElementAttribute(TracingId = 320836U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "QzuWzqZ7Gc0MqhmZWoST3K", Name = "OneMinus", IsManaged = true, IsAutoGenerated = true)]
            public n21.OneMinus_TZSID1klGMVLkhX7sgErcR<float> __p_QzuWzqZ7Gc0MqhmZWoST3K;
            [n1.ElementAttribute(TracingId = 320842U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "RcfTUE1M6i7PvvowhsyZ7j", Name = "Pow", IsManaged = true, IsAutoGenerated = true)]
            public n21.Pow_OYho3WrJhN0LWEmoMe81d4<float> __p_RcfTUE1M6i7PvvowhsyZ7j;
            [n1.ElementAttribute(TracingId = 320849U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "KdqY4my5zQFOKdY5BJCzKk", Name = "Saturate", IsManaged = true, IsAutoGenerated = true)]
            public n21.Saturate_HJGjOY7U6BSLBVUcDCTES2<float> __p_KdqY4my5zQFOKdY5BJCzKk;
            [n1.ElementAttribute(TracingId = 320853U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "BXXWPbyBnRPMuXc8Z4yJLR", Name = "*", IsManaged = true, IsAutoGenerated = true)]
            public n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_BXXWPbyBnRPMuXc8Z4yJLR;
            [n1.ElementAttribute(TracingId = 320862U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "B1EXEsUmCZbO95nBNxiwDP", Name = "Switch (Boolean)", IsManaged = true, IsAutoGenerated = true)]
            public n36.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<float> __p_B1EXEsUmCZbO95nBNxiwDP;
            [n1.ElementAttribute(TracingId = 320880U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "DaNDpQZbMO6NQNXq64Dd2s", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n33.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_DaNDpQZbMO6NQNXq64Dd2s;
            [n1.ElementAttribute(TracingId = 320892U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "KsUDXy8xriiNOUjhwhiGRN", Name = "CheckDefaultBooleanWorkaround", IsManaged = true, IsAutoGenerated = true)]
            public n33.CheckDefaultBooleanWorkaround_UeszWB8mLbnLw7rj4EXhp5 __p_KsUDXy8xriiNOUjhwhiGRN;
            [n1.ElementAttribute(TracingId = 320912U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "H0uGKoLAAIhOW1zbcmkYf2", Name = "OneMinus", IsManaged = true, IsAutoGenerated = true)]
            public n21.OneMinus_TZSID1klGMVLkhX7sgErcR<float> __p_H0uGKoLAAIhOW1zbcmkYf2;
            [n1.ElementAttribute(TracingId = 320922U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "QdWbc3eNeTjP4uatDCQ6Ql", Name = "CheckDefault (FromFloat)", IsManaged = true, IsAutoGenerated = true)]
            public n33.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_QdWbc3eNeTjP4uatDCQ6Ql;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.GpuValue<float>> __pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G = default(n18.Spread<n11.GpuValue<float>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.GpuValue<n5.Vector4>> __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF = default(n18.Spread<n11.GpuValue<n5.Vector4>>);
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n18.Spread<n11.GpuValue<float>> __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR = default(n18.Spread<n11.GpuValue<float>>);
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n1.IMonadBuilder<bool, n11.GpuValue<bool>> __monadBuilder_NxZJMJZ52ujLvveoqeLCTR = n11.GpuValueMonadicFactory<bool>.Default.GetMonadBuilder(true);
            public __UfQE40yWIVoM0IhB4PXGZ9(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __UfQE40yWIVoM0IhB4PXGZ9(__UfQE40yWIVoM0IhB4PXGZ9 other): base(other)
            {
                this.__p_ALJLKbUnpg4Ld1TVu2yV3G = other.__p_ALJLKbUnpg4Ld1TVu2yV3G;
                this.__p_Gf6UMsRHDchOwZifUXtTXj = other.__p_Gf6UMsRHDchOwZifUXtTXj;
                this.__p_SOkdVR6F2qnNQk8CPNezhO = other.__p_SOkdVR6F2qnNQk8CPNezhO;
                this.__p_UcgxSrCoPzxNZrOLDoygZx = other.__p_UcgxSrCoPzxNZrOLDoygZx;
                this.__p_B7LvXJ1jTflOQbVuBcADSF = other.__p_B7LvXJ1jTflOQbVuBcADSF;
                this.__p_J4a5k9JxKRXQBninAf1asY = other.__p_J4a5k9JxKRXQBninAf1asY;
                this.__p_EMm2nWU9uNON6L4SskQ44E = other.__p_EMm2nWU9uNON6L4SskQ44E;
                this.__p_LkaxvX7n0CpOSkifYChTIP = other.__p_LkaxvX7n0CpOSkifYChTIP;
                this.__p_LylWYed3JcAMyzxyCdf3tt = other.__p_LylWYed3JcAMyzxyCdf3tt;
                this.__p_QzuWzqZ7Gc0MqhmZWoST3K = other.__p_QzuWzqZ7Gc0MqhmZWoST3K;
                this.__p_RcfTUE1M6i7PvvowhsyZ7j = other.__p_RcfTUE1M6i7PvvowhsyZ7j;
                this.__p_KdqY4my5zQFOKdY5BJCzKk = other.__p_KdqY4my5zQFOKdY5BJCzKk;
                this.__p_BXXWPbyBnRPMuXc8Z4yJLR = other.__p_BXXWPbyBnRPMuXc8Z4yJLR;
                this.__p_B1EXEsUmCZbO95nBNxiwDP = other.__p_B1EXEsUmCZbO95nBNxiwDP;
                this.__p_DaNDpQZbMO6NQNXq64Dd2s = other.__p_DaNDpQZbMO6NQNXq64Dd2s;
                this.__p_KsUDXy8xriiNOUjhwhiGRN = other.__p_KsUDXy8xriiNOUjhwhiGRN;
                this.__p_H0uGKoLAAIhOW1zbcmkYf2 = other.__p_H0uGKoLAAIhOW1zbcmkYf2;
                this.__p_QdWbc3eNeTjP4uatDCQ6Ql = other.__p_QdWbc3eNeTjP4uatDCQ6Ql;
                this.__pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G = other.__pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G;
                this.__pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF = other.__pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF;
                this.__pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR = other.__pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR;
                this.__monadBuilder_NxZJMJZ52ujLvveoqeLCTR = other.__monadBuilder_NxZJMJZ52ujLvveoqeLCTR;
            }

            protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_ALJLKbUnpg4Ld1TVu2yV3G", in __p_ALJLKbUnpg4Ld1TVu2yV3G), n1.CompilationHelper.GetValueOrExisting(values, "__p_Gf6UMsRHDchOwZifUXtTXj", in __p_Gf6UMsRHDchOwZifUXtTXj), n1.CompilationHelper.GetValueOrExisting(values, "__p_SOkdVR6F2qnNQk8CPNezhO", in __p_SOkdVR6F2qnNQk8CPNezhO), n1.CompilationHelper.GetValueOrExisting(values, "__p_UcgxSrCoPzxNZrOLDoygZx", in __p_UcgxSrCoPzxNZrOLDoygZx), n1.CompilationHelper.GetValueOrExisting(values, "__p_B7LvXJ1jTflOQbVuBcADSF", in __p_B7LvXJ1jTflOQbVuBcADSF), n1.CompilationHelper.GetValueOrExisting(values, "__p_J4a5k9JxKRXQBninAf1asY", in __p_J4a5k9JxKRXQBninAf1asY), n1.CompilationHelper.GetValueOrExisting(values, "__p_EMm2nWU9uNON6L4SskQ44E", in __p_EMm2nWU9uNON6L4SskQ44E), n1.CompilationHelper.GetValueOrExisting(values, "__p_LkaxvX7n0CpOSkifYChTIP", in __p_LkaxvX7n0CpOSkifYChTIP), n1.CompilationHelper.GetValueOrExisting(values, "__p_LylWYed3JcAMyzxyCdf3tt", in __p_LylWYed3JcAMyzxyCdf3tt), n1.CompilationHelper.GetValueOrExisting(values, "__p_QzuWzqZ7Gc0MqhmZWoST3K", in __p_QzuWzqZ7Gc0MqhmZWoST3K), n1.CompilationHelper.GetValueOrExisting(values, "__p_RcfTUE1M6i7PvvowhsyZ7j", in __p_RcfTUE1M6i7PvvowhsyZ7j), n1.CompilationHelper.GetValueOrExisting(values, "__p_KdqY4my5zQFOKdY5BJCzKk", in __p_KdqY4my5zQFOKdY5BJCzKk), n1.CompilationHelper.GetValueOrExisting(values, "__p_BXXWPbyBnRPMuXc8Z4yJLR", in __p_BXXWPbyBnRPMuXc8Z4yJLR), n1.CompilationHelper.GetValueOrExisting(values, "__p_B1EXEsUmCZbO95nBNxiwDP", in __p_B1EXEsUmCZbO95nBNxiwDP), n1.CompilationHelper.GetValueOrExisting(values, "__p_DaNDpQZbMO6NQNXq64Dd2s", in __p_DaNDpQZbMO6NQNXq64Dd2s), n1.CompilationHelper.GetValueOrExisting(values, "__p_KsUDXy8xriiNOUjhwhiGRN", in __p_KsUDXy8xriiNOUjhwhiGRN), n1.CompilationHelper.GetValueOrExisting(values, "__p_H0uGKoLAAIhOW1zbcmkYf2", in __p_H0uGKoLAAIhOW1zbcmkYf2), n1.CompilationHelper.GetValueOrExisting(values, "__p_QdWbc3eNeTjP4uatDCQ6Ql", in __p_QdWbc3eNeTjP4uatDCQ6Ql), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G", in __pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF", in __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR", in __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR), n1.CompilationHelper.GetValueOrExisting(values, "__monadBuilder_NxZJMJZ52ujLvveoqeLCTR", in __monadBuilder_NxZJMJZ52ujLvveoqeLCTR));
            }

            internal __UfQE40yWIVoM0IhB4PXGZ9 __WITH__(n21.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<float> __p_ALJLKbUnpg4Ld1TVu2yV3G, n33.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_Gf6UMsRHDchOwZifUXtTXj, n26.Eye_RqdQkneNJa7QajqXnXfDYz __p_SOkdVR6F2qnNQk8CPNezhO, n26.PositionWS_EqNTwQZFoLOQdVEmvtk795 __p_UcgxSrCoPzxNZrOLDoygZx, n21.OperatorMinus_T6tMqMSvUiWPOjj10ol5Dg<n5.Vector4> __p_B7LvXJ1jTflOQbVuBcADSF, n21.Normalize_O9SF3b7zMM0NEJ2mnF2fkF<n5.Vector4> __p_J4a5k9JxKRXQBninAf1asY, n26.NormalWS_Gr7aABUWwEjNM3XChZ7Tfy __p_EMm2nWU9uNON6L4SskQ44E, n21.Dot_VjBgbBbkOkiMLqm9EWGCSn<n5.Vector4> __p_LkaxvX7n0CpOSkifYChTIP, n21.Saturate_HJGjOY7U6BSLBVUcDCTES2<float> __p_LylWYed3JcAMyzxyCdf3tt, n21.OneMinus_TZSID1klGMVLkhX7sgErcR<float> __p_QzuWzqZ7Gc0MqhmZWoST3K, n21.Pow_OYho3WrJhN0LWEmoMe81d4<float> __p_RcfTUE1M6i7PvvowhsyZ7j, n21.Saturate_HJGjOY7U6BSLBVUcDCTES2<float> __p_KdqY4my5zQFOKdY5BJCzKk, n21.OperatorMulitply_Qo4H68oG7GbQAgb6Tiaizx<float> __p_BXXWPbyBnRPMuXc8Z4yJLR, n36.Switch_Boolean_VHlzr7mAaGlN4ppBGvRF5t<float> __p_B1EXEsUmCZbO95nBNxiwDP, n33.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_DaNDpQZbMO6NQNXq64Dd2s, n33.CheckDefaultBooleanWorkaround_UeszWB8mLbnLw7rj4EXhp5 __p_KsUDXy8xriiNOUjhwhiGRN, n21.OneMinus_TZSID1klGMVLkhX7sgErcR<float> __p_H0uGKoLAAIhOW1zbcmkYf2, n33.CheckDefault_FromFloat_JlpT9SoMkVGL1mhIfr21L3<float> __p_QdWbc3eNeTjP4uatDCQ6Ql, n18.Spread<n11.GpuValue<float>> __pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G, n18.Spread<n11.GpuValue<n5.Vector4>> __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF, n18.Spread<n11.GpuValue<float>> __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR, n1.IMonadBuilder<bool, n11.GpuValue<bool>> __monadBuilder_NxZJMJZ52ujLvveoqeLCTR)
            {
                __UfQE40yWIVoM0IhB4PXGZ9 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_ALJLKbUnpg4Ld1TVu2yV3G != this.__p_ALJLKbUnpg4Ld1TVu2yV3G || __p_Gf6UMsRHDchOwZifUXtTXj != this.__p_Gf6UMsRHDchOwZifUXtTXj || __p_SOkdVR6F2qnNQk8CPNezhO != this.__p_SOkdVR6F2qnNQk8CPNezhO || __p_UcgxSrCoPzxNZrOLDoygZx != this.__p_UcgxSrCoPzxNZrOLDoygZx || __p_B7LvXJ1jTflOQbVuBcADSF != this.__p_B7LvXJ1jTflOQbVuBcADSF || __p_J4a5k9JxKRXQBninAf1asY != this.__p_J4a5k9JxKRXQBninAf1asY || __p_EMm2nWU9uNON6L4SskQ44E != this.__p_EMm2nWU9uNON6L4SskQ44E || __p_LkaxvX7n0CpOSkifYChTIP != this.__p_LkaxvX7n0CpOSkifYChTIP || __p_LylWYed3JcAMyzxyCdf3tt != this.__p_LylWYed3JcAMyzxyCdf3tt || __p_QzuWzqZ7Gc0MqhmZWoST3K != this.__p_QzuWzqZ7Gc0MqhmZWoST3K || __p_RcfTUE1M6i7PvvowhsyZ7j != this.__p_RcfTUE1M6i7PvvowhsyZ7j || __p_KdqY4my5zQFOKdY5BJCzKk != this.__p_KdqY4my5zQFOKdY5BJCzKk || __p_BXXWPbyBnRPMuXc8Z4yJLR != this.__p_BXXWPbyBnRPMuXc8Z4yJLR || __p_B1EXEsUmCZbO95nBNxiwDP != this.__p_B1EXEsUmCZbO95nBNxiwDP || __p_DaNDpQZbMO6NQNXq64Dd2s != this.__p_DaNDpQZbMO6NQNXq64Dd2s || __p_KsUDXy8xriiNOUjhwhiGRN != this.__p_KsUDXy8xriiNOUjhwhiGRN || __p_H0uGKoLAAIhOW1zbcmkYf2 != this.__p_H0uGKoLAAIhOW1zbcmkYf2 || __p_QdWbc3eNeTjP4uatDCQ6Ql != this.__p_QdWbc3eNeTjP4uatDCQ6Ql || __pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G != this.__pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G || __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF != this.__pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF || __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR != this.__pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR || __monadBuilder_NxZJMJZ52ujLvveoqeLCTR != this.__monadBuilder_NxZJMJZ52ujLvveoqeLCTR ? new __UfQE40yWIVoM0IhB4PXGZ9(this)
                    {__p_ALJLKbUnpg4Ld1TVu2yV3G = __p_ALJLKbUnpg4Ld1TVu2yV3G, __p_Gf6UMsRHDchOwZifUXtTXj = __p_Gf6UMsRHDchOwZifUXtTXj, __p_SOkdVR6F2qnNQk8CPNezhO = __p_SOkdVR6F2qnNQk8CPNezhO, __p_UcgxSrCoPzxNZrOLDoygZx = __p_UcgxSrCoPzxNZrOLDoygZx, __p_B7LvXJ1jTflOQbVuBcADSF = __p_B7LvXJ1jTflOQbVuBcADSF, __p_J4a5k9JxKRXQBninAf1asY = __p_J4a5k9JxKRXQBninAf1asY, __p_EMm2nWU9uNON6L4SskQ44E = __p_EMm2nWU9uNON6L4SskQ44E, __p_LkaxvX7n0CpOSkifYChTIP = __p_LkaxvX7n0CpOSkifYChTIP, __p_LylWYed3JcAMyzxyCdf3tt = __p_LylWYed3JcAMyzxyCdf3tt, __p_QzuWzqZ7Gc0MqhmZWoST3K = __p_QzuWzqZ7Gc0MqhmZWoST3K, __p_RcfTUE1M6i7PvvowhsyZ7j = __p_RcfTUE1M6i7PvvowhsyZ7j, __p_KdqY4my5zQFOKdY5BJCzKk = __p_KdqY4my5zQFOKdY5BJCzKk, __p_BXXWPbyBnRPMuXc8Z4yJLR = __p_BXXWPbyBnRPMuXc8Z4yJLR, __p_B1EXEsUmCZbO95nBNxiwDP = __p_B1EXEsUmCZbO95nBNxiwDP, __p_DaNDpQZbMO6NQNXq64Dd2s = __p_DaNDpQZbMO6NQNXq64Dd2s, __p_KsUDXy8xriiNOUjhwhiGRN = __p_KsUDXy8xriiNOUjhwhiGRN, __p_H0uGKoLAAIhOW1zbcmkYf2 = __p_H0uGKoLAAIhOW1zbcmkYf2, __p_QdWbc3eNeTjP4uatDCQ6Ql = __p_QdWbc3eNeTjP4uatDCQ6Ql, __pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G = __pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G, __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF = __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF, __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR = __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR, __monadBuilder_NxZJMJZ52ujLvveoqeLCTR = __monadBuilder_NxZJMJZ52ujLvveoqeLCTR} : that_0;
                else
                {
                    this.__p_ALJLKbUnpg4Ld1TVu2yV3G = __p_ALJLKbUnpg4Ld1TVu2yV3G;
                    this.__p_Gf6UMsRHDchOwZifUXtTXj = __p_Gf6UMsRHDchOwZifUXtTXj;
                    this.__p_SOkdVR6F2qnNQk8CPNezhO = __p_SOkdVR6F2qnNQk8CPNezhO;
                    this.__p_UcgxSrCoPzxNZrOLDoygZx = __p_UcgxSrCoPzxNZrOLDoygZx;
                    this.__p_B7LvXJ1jTflOQbVuBcADSF = __p_B7LvXJ1jTflOQbVuBcADSF;
                    this.__p_J4a5k9JxKRXQBninAf1asY = __p_J4a5k9JxKRXQBninAf1asY;
                    this.__p_EMm2nWU9uNON6L4SskQ44E = __p_EMm2nWU9uNON6L4SskQ44E;
                    this.__p_LkaxvX7n0CpOSkifYChTIP = __p_LkaxvX7n0CpOSkifYChTIP;
                    this.__p_LylWYed3JcAMyzxyCdf3tt = __p_LylWYed3JcAMyzxyCdf3tt;
                    this.__p_QzuWzqZ7Gc0MqhmZWoST3K = __p_QzuWzqZ7Gc0MqhmZWoST3K;
                    this.__p_RcfTUE1M6i7PvvowhsyZ7j = __p_RcfTUE1M6i7PvvowhsyZ7j;
                    this.__p_KdqY4my5zQFOKdY5BJCzKk = __p_KdqY4my5zQFOKdY5BJCzKk;
                    this.__p_BXXWPbyBnRPMuXc8Z4yJLR = __p_BXXWPbyBnRPMuXc8Z4yJLR;
                    this.__p_B1EXEsUmCZbO95nBNxiwDP = __p_B1EXEsUmCZbO95nBNxiwDP;
                    this.__p_DaNDpQZbMO6NQNXq64Dd2s = __p_DaNDpQZbMO6NQNXq64Dd2s;
                    this.__p_KsUDXy8xriiNOUjhwhiGRN = __p_KsUDXy8xriiNOUjhwhiGRN;
                    this.__p_H0uGKoLAAIhOW1zbcmkYf2 = __p_H0uGKoLAAIhOW1zbcmkYf2;
                    this.__p_QdWbc3eNeTjP4uatDCQ6Ql = __p_QdWbc3eNeTjP4uatDCQ6Ql;
                    this.__pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G = __pin_group_Input_In_ALJLKbUnpg4Ld1TVu2yV3G;
                    this.__pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF = __pin_group_Input_In_B7LvXJ1jTflOQbVuBcADSF;
                    this.__pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR = __pin_group_Input_In_BXXWPbyBnRPMuXc8Z4yJLR;
                    this.__monadBuilder_NxZJMJZ52ujLvveoqeLCTR = __monadBuilder_NxZJMJZ52ujLvveoqeLCTR;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 321003U, DocumentId = "O1Y26euhDfkOXD56tZlYl5", PersistentId = "Irt0YFriJdfL2EJnYYiPxv", Name = "Fuse_MaterialApplication_Irt0YFriJdfL2EJnYYiPxv")]
    [n2.SerializableAttribute]
    public class Fuse_MaterialApplication_Irt0YFriJdfL2EJnYYiPxv : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Fuse_MaterialApplication_Irt0YFriJdfL2EJnYYiPxv Create(n1.NodeContext Node_Context)
        {
            var instance = new Fuse_MaterialApplication_Irt0YFriJdfL2EJnYYiPxv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Fuse_MaterialApplication_Irt0YFriJdfL2EJnYYiPxv CreateDefault()
        {
            var instance = new Fuse_MaterialApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Fuse_MaterialApplication_Irt0YFriJdfL2EJnYYiPxv Update()
        {
            return this;
        }

        public n3.Fuse_MaterialApplication_Irt0YFriJdfL2EJnYYiPxv __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n3.Fuse_MaterialApplication_Irt0YFriJdfL2EJnYYiPxv __CreateDefault__()
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

        public Fuse_MaterialApplication_Irt0YFriJdfL2EJnYYiPxv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Fuse_MaterialApplication_Irt0YFriJdfL2EJnYYiPxv(Fuse_MaterialApplication_Irt0YFriJdfL2EJnYYiPxv other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n13.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal Fuse_MaterialApplication_Irt0YFriJdfL2EJnYYiPxv __WITH__()
        {
            return this;
        }
    }
}

namespace _Fuse_Material_
{
    public struct __AdaptiveImplementations__O1Y26euhDfkOXD56tZlYl5 : n38.IAdaptiveCreateDefault<n11.GpuValue<n5.Vector3>>, n38.IAdaptiveCreateDefault<n11.GpuValue<n5.Vector4>>
    {
        public void CreateDefault(out n11.GpuValue<n5.Vector3> Output_Out)
        {
            n37._Operations_.CreateDefault_Generic<n11.GpuValue<n5.Vector3>>(Output_Out: out n11.GpuValue<n5.Vector3> Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n11.GpuValue<n5.Vector4> Output_Out)
        {
            n37._Operations_.CreateDefault_Generic<n11.GpuValue<n5.Vector4>>(Output_Out: out n11.GpuValue<n5.Vector4> Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}