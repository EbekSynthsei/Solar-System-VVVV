extern alias e31;
extern alias e27;
extern alias e26;
extern alias e25;
extern alias e21;
extern alias e2;
extern alias e40;
extern alias e3;
extern alias e28;
extern alias e24;
extern alias e5;
extern alias e1;
extern alias e20;

using n16 = _CoreLibBasics_.Control.Advanced;
using n21 = e2::VL.Lib.Primitive;
using n19 = _CoreLibBasics_.Primitive.Object.Advanced;
using n41 = _CoreLibBasics_.Control;
using n11 = e20::Stride.Rendering;
using n12 = e21::Stride.Core.Serialization.Contents;
using n29 = e2::VL.Lib.Mathematics;
using n30 = e40::VL.Stride.Graphics;
using n5 = e27::Stride.Graphics;
using n27 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.DisplayMode.Advanced;
using n25 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.GraphicsOutput.Advanced;
using n35 = e31::Stride.Input;
using n15 = e2::VL.Lib.Primitive.Object;
using n4 = e5::VL.Core.CompilerServices;
using n42 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Rendering.Model.Advanced;
using n20 = _CoreLibBasics_.Primitive.Delegates.Delegate__0_MG_1.Advanced;
using n7 = global::System.Collections.Generic;
using n24 = _VL_Stride_Runtime_TypeForwards_.Stride;
using n10 = e1::Stride.Core.Mathematics;
using n18 = _CoreLibBasics_.Math.Adaptive;
using n14 = e28::Stride.Games;
using n9 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Rendering.Advanced;
using n36 = e40::VL.Stride.Input;
using n34 = e2::VL.Lib.Primitive.CacheRegion;
using n32 = _VL_Collections_.Collections.Spread.Advanced;
using n22 = e24::Stride.Engine;
using n8 = e26::Stride.Rendering;
using n1 = e5::VL.Core;
using n26 = e20::Stride.Graphics;
using n2 = global::System;
using n39 = _CoreLibBasics_.Primitive.Int2;
using n3 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.VertexDeclaration.Advanced;
using n28 = _CoreLibBasics_._2D.RectangleAnchor;
using n38 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.TextureViewDescription.Advanced;
using n40 = e25::Stride.Shaders;
using n23 = e3::Stride.Core.Collections;
using n33 = _VL_Collections_.Collections.Mutable.MutableArray.Advanced;
using n13 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Games.Utils.Advanced;
using n37 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.TextureDescription.Advanced;
using n6 = global::System.Runtime.CompilerServices;
using n31 = e5::VL.Lib.Collections;
using n43 = _VL_Collections_.Collections.Spread;
using n17 = _VL_CoreLib_Experimental_.Control.Experimental;

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.VertexDeclaration.Advanced
{
    [n1.ElementAttribute(TracingId = 124000U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "VRjiXKBp4VDPqPzXrIixwv", Name = "Pos4_VRjiXKBp4VDPqPzXrIixwv")]
    [n2.SerializableAttribute]
    public class Pos4_VRjiXKBp4VDPqPzXrIixwv : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Pos4_VRjiXKBp4VDPqPzXrIixwv Create(n1.NodeContext Node_Context)
        {
            var instance = new Pos4_VRjiXKBp4VDPqPzXrIixwv(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Pos4_VRjiXKBp4VDPqPzXrIixwv CreateDefault()
        {
            var instance = new Pos4_VRjiXKBp4VDPqPzXrIixwv(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Pos4_VRjiXKBp4VDPqPzXrIixwv Update(out n5.VertexDeclaration Output_Out)
        {
            n5.VertexDeclaration __auto_0 = this.Output;
            Output_Out = __auto_0;
            return this;
        }

        public n3.Pos4_VRjiXKBp4VDPqPzXrIixwv __Create__(n1.NodeContext Node_Context)
        {
            n6.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3._Operations_.CreatePos4(Output_Out: out n5.VertexDeclaration Output_0);
            n5.VertexDeclaration __auto_1 = Output_0;
            n3.Pos4_VRjiXKBp4VDPqPzXrIixwv that_2 = this;
            this.Output = Output_0;
            return that_2;
        }

        public n3.Pos4_VRjiXKBp4VDPqPzXrIixwv __CreateDefault__()
        {
            n3.Pos4_VRjiXKBp4VDPqPzXrIixwv that_0 = this;
            this.Output = default(n5.VertexDeclaration);
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

        [n1.ElementAttribute(TracingId = 124017U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "M4OLEBjmHcAQOiatt8MryL", Name = "Output")]
        public n5.VertexDeclaration Output;
        public Pos4_VRjiXKBp4VDPqPzXrIixwv(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Pos4_VRjiXKBp4VDPqPzXrIixwv(Pos4_VRjiXKBp4VDPqPzXrIixwv other): base(other)
        {
            this.Output = other.Output;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Output", in Output));
        }

        internal Pos4_VRjiXKBp4VDPqPzXrIixwv __WITH__(n5.VertexDeclaration Output)
        {
            n3.Pos4_VRjiXKBp4VDPqPzXrIixwv that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Output != this.Output ? new Pos4_VRjiXKBp4VDPqPzXrIixwv(this)
                {Output = Output} : that_0;
            else
            {
                this.Output = Output;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 124318U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "T5nlQ9NTaLdQAGRzwKUdRc", Name = "Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc")]
    [n2.SerializableAttribute]
    public class Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc Create(n1.NodeContext Node_Context)
        {
            var instance = new Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc CreateDefault()
        {
            var instance = new Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc Update(out n5.VertexDeclaration Output_Out)
        {
            n5.VertexDeclaration __auto_0 = this.Output;
            Output_Out = __auto_0;
            return this;
        }

        public n3.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc __Create__(n1.NodeContext Node_Context)
        {
            n6.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3._Operations_.CreatePos3Norm3Tex2(Output_Out: out n5.VertexDeclaration Output_0);
            n5.VertexDeclaration __auto_1 = Output_0;
            n3.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc that_2 = this;
            this.Output = Output_0;
            return that_2;
        }

        public n3.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc __CreateDefault__()
        {
            n3.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc that_0 = this;
            this.Output = default(n5.VertexDeclaration);
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

        [n1.ElementAttribute(TracingId = 124333U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "A2OckjUwuZcM9dJRprhBiQ", Name = "Output")]
        public n5.VertexDeclaration Output;
        public Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc(Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc other): base(other)
        {
            this.Output = other.Output;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Output", in Output));
        }

        internal Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc __WITH__(n5.VertexDeclaration Output)
        {
            n3.Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Output != this.Output ? new Pos3Norm3Tex2_T5nlQ9NTaLdQAGRzwKUdRc(this)
                {Output = Output} : that_0;
            else
            {
                this.Output = Output;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 124594U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "QolmucOYvm9NopK4AAzv3i", Name = "Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i")]
    [n2.SerializableAttribute]
    public class Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i Create(n1.NodeContext Node_Context)
        {
            var instance = new Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i CreateDefault()
        {
            var instance = new Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i Update(out n5.VertexDeclaration Output_Out)
        {
            n5.VertexDeclaration __auto_0 = this.Output;
            Output_Out = __auto_0;
            return this;
        }

        public n3.Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i __Create__(n1.NodeContext Node_Context)
        {
            n6.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3._Operations_.CreatePos3Norm3Tang4Tex2(Output_Out: out n5.VertexDeclaration Output_0);
            n5.VertexDeclaration __auto_1 = Output_0;
            n3.Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i that_2 = this;
            this.Output = Output_0;
            return that_2;
        }

        public n3.Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i __CreateDefault__()
        {
            n3.Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i that_0 = this;
            this.Output = default(n5.VertexDeclaration);
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

        [n1.ElementAttribute(TracingId = 124613U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "IjT6V0RcCy4OFQ43p4STnu", Name = "Output")]
        public n5.VertexDeclaration Output;
        public Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i(Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i other): base(other)
        {
            this.Output = other.Output;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Output", in Output));
        }

        internal Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i __WITH__(n5.VertexDeclaration Output)
        {
            n3.Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Output != this.Output ? new Pos3Norm3Tang4Tex2_QolmucOYvm9NopK4AAzv3i(this)
                {Output = Output} : that_0;
            else
            {
                this.Output = Output;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CreatePos4(out n5.VertexDeclaration Output_Out)
        {
            string __pad_GOl5WszkEO8NpU0xZYvaEG_0 = __slot_GOl5WszkEO8NpU0xZYvaEG;
            n26.PixelFormat Format_1 = __c_M3MoOVzqLFhLkN06bdit4P;
            var Output_2 = new n5.VertexElement(semanticName: __pad_GOl5WszkEO8NpU0xZYvaEG_0, format: Format_1);
            n33._Operations_.ToArray<n5.VertexElement>(Input_In: Output_2, Result_Out: out n5.VertexElement[] Result_3);
            var Output_4 = new n5.VertexDeclaration(elements: Result_3);
            Output_Out = Output_4;
            return;
        }

        public static void CreatePos3Norm3Tex2(out n5.VertexDeclaration Output_Out)
        {
            string __pad_EiiTrQ1cBjZPte5UVDd18Z_0 = __slot_EiiTrQ1cBjZPte5UVDd18Z;
            int __pad_Qbtbm99bizIL3ZTkU5b7k3_1 = __slot_Qbtbm99bizIL3ZTkU5b7k3;
            string __pad_UzpQeTJB2X3MkN8Lkcy3vV_2 = __slot_UzpQeTJB2X3MkN8Lkcy3vV;
            string __pad_CjwDcTfq9S9M4A1v7KJRU9_3 = __slot_CjwDcTfq9S9M4A1v7KJRU9;
            n26.PixelFormat Format_4 = __c_LegXW2n43nNQNgGSZwoLjL;
            var Output_5 = new n5.VertexElement(semanticName: __pad_EiiTrQ1cBjZPte5UVDd18Z_0, format: Format_4);
            n1.NodeContext Node_Context_6 = n1.NodeContext.Default.CreateSubContext("TiJxb2oN2LtNWRy2MbJV6Q", "J8naile72bFNfPQiStRUhX", 124203U);
            n33._Operations_.Create<n5.VertexElement>(Node_Context: Node_Context_6, Length_In: __pad_Qbtbm99bizIL3ZTkU5b7k3_1, Result_Out: out n5.VertexElement[] Result_7);
            int Index_8 = 0;
            n33._Operations_.SetItem<n5.VertexElement>(Input_In: Result_7, Index_In: Index_8, Value_In: Output_5, Output_Out: out n5.VertexElement[] Output_9);
            n26.PixelFormat Format_10 = __c_ROcb1Ud70JKPogECPThqD4;
            var Output_11 = new n5.VertexElement(semanticName: __pad_UzpQeTJB2X3MkN8Lkcy3vV_2, format: Format_10);
            int Index_12 = 1;
            n33._Operations_.SetItem<n5.VertexElement>(Input_In: Output_9, Index_In: Index_12, Value_In: Output_11, Output_Out: out n5.VertexElement[] Output_13);
            n26.PixelFormat Format_14 = __c_NJ8cp3LyBf8ONATJzwI3Dj;
            var Output_15 = new n5.VertexElement(semanticName: __pad_CjwDcTfq9S9M4A1v7KJRU9_3, format: Format_14);
            int Index_16 = 2;
            n33._Operations_.SetItem<n5.VertexElement>(Input_In: Output_13, Index_In: Index_16, Value_In: Output_15, Output_Out: out n5.VertexElement[] Output_17);
            var Output_18 = new n5.VertexDeclaration(elements: Output_17);
            Output_Out = Output_18;
            return;
        }

        public static void CreatePos3Norm3Tang4Tex2(out n5.VertexDeclaration Output_Out)
        {
            string __pad_OhpQg8vyCmnLfL42nsHfig_0 = __slot_OhpQg8vyCmnLfL42nsHfig;
            int __pad_MqaA7iwc9HENSPb8FheHqa_1 = __slot_MqaA7iwc9HENSPb8FheHqa;
            string __pad_So22cotvw6mNBN2BqUwOXo_2 = __slot_So22cotvw6mNBN2BqUwOXo;
            string __pad_T4gjQqBKYQKMh3idiukDo8_3 = __slot_T4gjQqBKYQKMh3idiukDo8;
            string __pad_OZzbPDwVZj0NLX1GLYoC5k_4 = __slot_OZzbPDwVZj0NLX1GLYoC5k;
            n26.PixelFormat Format_5 = __c_T7qHgcQCXlFNIvRZt2gEYf;
            var Output_6 = new n5.VertexElement(semanticName: __pad_OhpQg8vyCmnLfL42nsHfig_0, format: Format_5);
            n1.NodeContext Node_Context_7 = n1.NodeContext.Default.CreateSubContext("TiJxb2oN2LtNWRy2MbJV6Q", "VLd78jJvMgeNEWWhkgNYhz", 124418U);
            n33._Operations_.Create<n5.VertexElement>(Node_Context: Node_Context_7, Length_In: __pad_MqaA7iwc9HENSPb8FheHqa_1, Result_Out: out n5.VertexElement[] Result_8);
            int Index_9 = 0;
            n33._Operations_.SetItem<n5.VertexElement>(Input_In: Result_8, Index_In: Index_9, Value_In: Output_6, Output_Out: out n5.VertexElement[] Output_10);
            n26.PixelFormat Format_11 = __c_HICq0ZC5NL3LVgatk4EJxy;
            var Output_12 = new n5.VertexElement(semanticName: __pad_So22cotvw6mNBN2BqUwOXo_2, format: Format_11);
            int Index_13 = 1;
            n33._Operations_.SetItem<n5.VertexElement>(Input_In: Output_10, Index_In: Index_13, Value_In: Output_12, Output_Out: out n5.VertexElement[] Output_14);
            n26.PixelFormat Format_15 = __c_AH8vFEWVAeFMzx8yeXNUzT;
            var Output_16 = new n5.VertexElement(semanticName: __pad_T4gjQqBKYQKMh3idiukDo8_3, format: Format_15);
            int Index_17 = 2;
            n33._Operations_.SetItem<n5.VertexElement>(Input_In: Output_14, Index_In: Index_17, Value_In: Output_16, Output_Out: out n5.VertexElement[] Output_18);
            n26.PixelFormat Format_19 = __c_IUj5Q9m4hysNUNZdlHY26S;
            var Output_20 = new n5.VertexElement(semanticName: __pad_OZzbPDwVZj0NLX1GLYoC5k_4, format: Format_19);
            int Index_21 = 3;
            n33._Operations_.SetItem<n5.VertexElement>(Input_In: Output_18, Index_In: Index_21, Value_In: Output_20, Output_Out: out n5.VertexElement[] Output_22);
            var Output_23 = new n5.VertexDeclaration(elements: Output_22);
            Output_Out = Output_23;
            return;
        }

        [n1.ElementAttribute(TracingId = 124099U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "GOl5WszkEO8NpU0xZYvaEG", Name = "__slot_GOl5WszkEO8NpU0xZYvaEG")]
        public static string __slot_GOl5WszkEO8NpU0xZYvaEG = "POSITION";
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n26.PixelFormat __c_M3MoOVzqLFhLkN06bdit4P = n1.CompilationHelper.Deserialize<n26.PixelFormat>("R32G32B32A32_Float", false, "TiJxb2oN2LtNWRy2MbJV6Q", "M3MoOVzqLFhLkN06bdit4P");
        [n1.ElementAttribute(TracingId = 124291U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "EiiTrQ1cBjZPte5UVDd18Z", Name = "__slot_EiiTrQ1cBjZPte5UVDd18Z")]
        public static string __slot_EiiTrQ1cBjZPte5UVDd18Z = "POSITION";
        [n1.ElementAttribute(TracingId = 124243U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "Qbtbm99bizIL3ZTkU5b7k3", Name = "__slot_Qbtbm99bizIL3ZTkU5b7k3")]
        public static int __slot_Qbtbm99bizIL3ZTkU5b7k3 = 3;
        [n1.ElementAttribute(TracingId = 124298U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "UzpQeTJB2X3MkN8Lkcy3vV", Name = "__slot_UzpQeTJB2X3MkN8Lkcy3vV")]
        public static string __slot_UzpQeTJB2X3MkN8Lkcy3vV = "NORMAL";
        [n1.ElementAttribute(TracingId = 124306U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "CjwDcTfq9S9M4A1v7KJRU9", Name = "__slot_CjwDcTfq9S9M4A1v7KJRU9")]
        public static string __slot_CjwDcTfq9S9M4A1v7KJRU9 = "TEXCOORD0";
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n26.PixelFormat __c_LegXW2n43nNQNgGSZwoLjL = n1.CompilationHelper.Deserialize<n26.PixelFormat>("R32G32B32_Float", false, "TiJxb2oN2LtNWRy2MbJV6Q", "LegXW2n43nNQNgGSZwoLjL");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n26.PixelFormat __c_ROcb1Ud70JKPogECPThqD4 = n1.CompilationHelper.Deserialize<n26.PixelFormat>("R32G32B32_Float", false, "TiJxb2oN2LtNWRy2MbJV6Q", "ROcb1Ud70JKPogECPThqD4");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n26.PixelFormat __c_NJ8cp3LyBf8ONATJzwI3Dj = n1.CompilationHelper.Deserialize<n26.PixelFormat>("R32G32_Float", false, "TiJxb2oN2LtNWRy2MbJV6Q", "NJ8cp3LyBf8ONATJzwI3Dj");
        [n1.ElementAttribute(TracingId = 124536U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "OhpQg8vyCmnLfL42nsHfig", Name = "__slot_OhpQg8vyCmnLfL42nsHfig")]
        public static string __slot_OhpQg8vyCmnLfL42nsHfig = "POSITION";
        [n1.ElementAttribute(TracingId = 124477U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "MqaA7iwc9HENSPb8FheHqa", Name = "__slot_MqaA7iwc9HENSPb8FheHqa")]
        public static int __slot_MqaA7iwc9HENSPb8FheHqa = 4;
        [n1.ElementAttribute(TracingId = 124539U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "So22cotvw6mNBN2BqUwOXo", Name = "__slot_So22cotvw6mNBN2BqUwOXo")]
        public static string __slot_So22cotvw6mNBN2BqUwOXo = "NORMAL";
        [n1.ElementAttribute(TracingId = 124579U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "T4gjQqBKYQKMh3idiukDo8", Name = "__slot_T4gjQqBKYQKMh3idiukDo8")]
        public static string __slot_T4gjQqBKYQKMh3idiukDo8 = "TANGENT";
        [n1.ElementAttribute(TracingId = 124546U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "OZzbPDwVZj0NLX1GLYoC5k", Name = "__slot_OZzbPDwVZj0NLX1GLYoC5k")]
        public static string __slot_OZzbPDwVZj0NLX1GLYoC5k = "TEXCOORD0";
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n26.PixelFormat __c_T7qHgcQCXlFNIvRZt2gEYf = n1.CompilationHelper.Deserialize<n26.PixelFormat>("R32G32B32_Float", false, "TiJxb2oN2LtNWRy2MbJV6Q", "T7qHgcQCXlFNIvRZt2gEYf");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n26.PixelFormat __c_HICq0ZC5NL3LVgatk4EJxy = n1.CompilationHelper.Deserialize<n26.PixelFormat>("R32G32B32_Float", false, "TiJxb2oN2LtNWRy2MbJV6Q", "HICq0ZC5NL3LVgatk4EJxy");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n26.PixelFormat __c_AH8vFEWVAeFMzx8yeXNUzT = n1.CompilationHelper.Deserialize<n26.PixelFormat>("R32G32B32A32_Float", false, "TiJxb2oN2LtNWRy2MbJV6Q", "AH8vFEWVAeFMzx8yeXNUzT");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n26.PixelFormat __c_IUj5Q9m4hysNUNZdlHY26S = n1.CompilationHelper.Deserialize<n26.PixelFormat>("R32G32_Float", false, "TiJxb2oN2LtNWRy2MbJV6Q", "IUj5Q9m4hysNUNZdlHY26S");
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.PrimitiveType.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void ControlPointCount(n5.PrimitiveType Input_In, int Control_Points_In, out n5.PrimitiveType Output_Out)
        {
            var Output_0 = n5.PrimitiveTypeExtensions.ControlPointCount(primitiveType: Input_In, controlPoints: Control_Points_In);
            Output_Out = Output_0;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.Texture.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CloneWithOptions(n5.Texture Input_In, n26.PixelFormat Format_In, n5.TextureFlags Flags_In, n5.GraphicsResourceUsage Usage_In, n5.TextureOptions Options_In, out n5.Texture Result_Out)
        {
            var Graphics_Device_0 = Input_In.GraphicsDevice;
            var View_Description_1 = Input_In.ViewDescription;
            var Description_2 = Input_In.Description;
            n37._Operations_.CloneWithOptions(Input_In: Description_2, Format_In: Format_In, Flags_In: Flags_In, Usage_In: Usage_In, Options_In: Options_In, Output_Out: out n5.TextureDescription Output_3);
            n38._Operations_.CloneWithOptions(Input_In: View_Description_1, Flags_In: Flags_In, Format_In: Format_In, Output_Out: out n5.TextureViewDescription Output_4);
            n19._Operations_.NULL<n26.DataBox[]>(Result_Out: out n26.DataBox[] Result_5);
            var Result_6 = n5.Texture.New(graphicsDevice: Graphics_Device_0, description: Output_3, viewDescription: Output_4, boxes: Result_5);
            Result_Out = Result_6;
            return;
        }

        public static void Load(n5.GraphicsDevice Device_In, string File_In, [n4.SerializedDefaultValueAttribute("ShaderResource", false)] n5.TextureFlags Texture_Flags_In, [n4.SerializedDefaultValueAttribute("Immutable", false)] n5.GraphicsResourceUsage Usage_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Load_As_SRGB_In, out n5.Texture Result_Out)
        {
            var Result_0 = n30.TextureExtensions.Load(device: Device_In, file: File_In, textureFlags: Texture_Flags_In, usage: Usage_In, loadAsSRGB: Load_As_SRGB_In);
            Result_Out = Result_0;
            return;
        }

        public static void ViewSize(n5.Texture Input_In, out n5.Texture Output_Out, out n10.Int2 View_Size_Out, out n26.PixelFormat View_Format_Out, out bool Exists_Out)
        {
            n15.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            n10.Int2 __auto_2;
            n26.PixelFormat __auto_3;
            if (Result_0)
            {
                var View_Width_4 = Input_In.ViewWidth;
                var View_Height_5 = Input_In.ViewHeight;
                n1.NodeContext Node_Context_6 = n1.NodeContext.Default.CreateSubContext("TiJxb2oN2LtNWRy2MbJV6Q", "OSSFvJtIHrWOTfGgxuMl95", 125180U);
                n39._Operations_.Create(Node_Context: Node_Context_6, X_In: View_Width_4, Y_In: View_Height_5, Output_Out: out n10.Int2 Output_7);
                __auto_2 = Output_7;
                var View_Format_8 = Input_In.ViewFormat;
                __auto_3 = View_Format_8;
            }
            else
            {
                __auto_2 = default(n10.Int2);
                __auto_3 = default(n26.PixelFormat);
            }

            Output_Out = Input_In;
            View_Size_Out = __auto_2;
            View_Format_Out = __auto_3;
            Exists_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.GraphicsOutput.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Split(n5.GraphicsOutput Input_In, out n10.RectangleF Desktop_Out, out int Width_Out, out int Height_Out, out float Aspect_Ratio_Out, out float Refresh_Rate_Out, out n26.PixelFormat Format_Out)
        {
            var Current_Display_Mode_0 = Input_In.CurrentDisplayMode;
            var Desktop_Bounds_1 = Input_In.DesktopBounds;
            n25._Operations_.FixDisplayRectangle(Input_In: Desktop_Bounds_1, Output_Out: out n10.RectangleF Output_2);
            n15.ObjectHelpers.IsAssigned(x: Current_Display_Mode_0, result: out bool Result_3, notAssigned: out bool Not_Assigned_4);
            int __auto_5;
            int __auto_6;
            float __auto_7;
            float __auto_8;
            n26.PixelFormat __auto_9;
            if (Result_3)
            {
                n27._Operations_.Split(Input_In: Current_Display_Mode_0, Width_Out: out int Width_10, Height_Out: out int Height_11, Aspect_Ratio_Out: out float Aspect_Ratio_12, Refresh_Rate_Out: out float Refresh_Rate_13, Format_Out: out n26.PixelFormat Format_14);
                __auto_5 = Width_10;
                __auto_6 = Height_11;
                __auto_7 = Aspect_Ratio_12;
                __auto_8 = Refresh_Rate_13;
                __auto_9 = Format_14;
            }
            else
            {
                __auto_5 = 0;
                __auto_6 = 0;
                __auto_7 = 0F;
                __auto_8 = 0F;
                __auto_9 = default(n26.PixelFormat);
            }

            Desktop_Out = Output_2;
            Width_Out = __auto_5;
            Height_Out = __auto_6;
            Aspect_Ratio_Out = __auto_7;
            Refresh_Rate_Out = __auto_8;
            Format_Out = __auto_9;
            return;
        }

        public static void FixDisplayRectangle(n10.Rectangle Input_In, out n10.RectangleF Output_Out)
        {
            var X_0 = Input_In.X;
            var Y_1 = Input_In.Y;
            var Width_2 = Input_In.Width;
            var Height_3 = Input_In.Height;
            var Output_4 = Width_2 - X_0;
            float Width_5 = (float)Output_4;
            float Position_X_6 = (float)X_0;
            float Position_Y_7 = (float)Y_1;
            var Output_8 = Height_3 - Y_1;
            float Height_9 = (float)Output_8;
            n29.RectangleAnchor Anchor_10 = n28._Operations_.CreateDefault();
            n29.RectangleNodes.JoinComponentwise(positionX: Position_X_6, positionY: Position_Y_7, width: Width_5, height: Height_9, anchor: Anchor_10, output: out n10.RectangleF Output_11);
            Output_Out = Output_11;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.DisplayMode.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Split(n5.DisplayMode Input_In, out int Width_Out, out int Height_Out, out float Aspect_Ratio_Out, out float Refresh_Rate_Out, out n26.PixelFormat Format_Out)
        {
            var Width_0 = Input_In.Width;
            var Height_1 = Input_In.Height;
            var Aspect_Ratio_2 = Input_In.AspectRatio;
            var Refresh_Rate_3 = Input_In.RefreshRate;
            var Format_4 = Input_In.Format;
            var Numerator_5 = Refresh_Rate_3.Numerator;
            var Denominator_6 = Refresh_Rate_3.Denominator;
            float Input_2_7 = (float)Denominator_6;
            float Input_8 = (float)Numerator_5;
            var Output_9 = (float)Input_8 / Input_2_7;
            Width_Out = Width_0;
            Height_Out = Height_1;
            Aspect_Ratio_Out = Aspect_Ratio_2;
            Refresh_Rate_Out = Output_9;
            Format_Out = Format_4;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.BlendStateDescription.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Additive(out n5.BlendStateDescription Additive_Out)
        {
            var Additive_0 = n30.BlendStateDescriptions.Additive;
            Additive_Out = Additive_0;
            return;
        }

        public static void AlphaBlend(out n5.BlendStateDescription Alpha_Blend_Out)
        {
            var Alpha_Blend_0 = n30.BlendStateDescriptions.AlphaBlend;
            Alpha_Blend_Out = Alpha_Blend_0;
            return;
        }

        public static void AlphaBlendPremultiplied(out n5.BlendStateDescription Alpha_Blend_Premultiplied_Out)
        {
            var Alpha_Blend_Premultiplied_0 = n30.BlendStateDescriptions.AlphaBlendPremultiplied;
            Alpha_Blend_Premultiplied_Out = Alpha_Blend_Premultiplied_0;
            return;
        }

        public static void None(out n5.BlendStateDescription None_Out)
        {
            var None_0 = n30.BlendStateDescriptions.None;
            None_Out = None_0;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static n5.BlendStateDescription CreateDefault_H()
        {
            var None_0 = n30.BlendStateDescriptions.None;
            return None_0;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.DepthStencilStateDescription.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Default(out n5.DepthStencilStateDescription Default_Out)
        {
            var Default_0 = n30.DepthStencilStateDescriptions.Default;
            Default_Out = Default_0;
            return;
        }

        public static void DefaultInverse(out n5.DepthStencilStateDescription Default_Inverse_Out)
        {
            var Default_Inverse_0 = n30.DepthStencilStateDescriptions.DefaultInverse;
            Default_Inverse_Out = Default_Inverse_0;
            return;
        }

        public static void DepthRead(out n5.DepthStencilStateDescription Depth_Read_Out)
        {
            var Depth_Read_0 = n30.DepthStencilStateDescriptions.DepthRead;
            Depth_Read_Out = Depth_Read_0;
            return;
        }

        public static void None(out n5.DepthStencilStateDescription None_Out)
        {
            var None_0 = n30.DepthStencilStateDescriptions.None;
            None_Out = None_0;
            return;
        }

        [n4.CreateDefaultAttribute]
        public static n5.DepthStencilStateDescription CreateDefault_H()
        {
            var Default_0 = n30.DepthStencilStateDescriptions.Default;
            return Default_0;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.RasterizerStateDescription.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateDefaultAttribute]
        public static n5.RasterizerStateDescription CreateDefault_H()
        {
            var Default_0 = n30.RasterizerStateDescriptions.Default;
            return Default_0;
        }

        public static void CullBack(out n5.RasterizerStateDescription Cull_Back_Out)
        {
            var Cull_Back_0 = n30.RasterizerStateDescriptions.CullBack;
            Cull_Back_Out = Cull_Back_0;
            return;
        }

        public static void CullFront(out n5.RasterizerStateDescription Cull_Front_Out)
        {
            var Cull_Front_0 = n30.RasterizerStateDescriptions.CullFront;
            Cull_Front_Out = Cull_Front_0;
            return;
        }

        public static void CullNone(out n5.RasterizerStateDescription Cull_None_Out)
        {
            var Cull_None_0 = n30.RasterizerStateDescriptions.CullNone;
            Cull_None_Out = Cull_None_0;
            return;
        }

        public static void Default(out n5.RasterizerStateDescription Default_Out)
        {
            var Default_0 = n30.RasterizerStateDescriptions.Default;
            Default_Out = Default_0;
            return;
        }

        public static void Wireframe(out n5.RasterizerStateDescription Wireframe_Out)
        {
            var Wireframe_0 = n30.RasterizerStateDescriptions.Wireframe;
            Wireframe_Out = Wireframe_0;
            return;
        }

        public static void WireframeCullBack(out n5.RasterizerStateDescription Wireframe_Cull_Back_Out)
        {
            var Wireframe_Cull_Back_0 = n30.RasterizerStateDescriptions.WireframeCullBack;
            Wireframe_Cull_Back_Out = Wireframe_Cull_Back_0;
            return;
        }

        public static void WireframeCullFront(out n5.RasterizerStateDescription Wireframe_Cull_Front_Out)
        {
            var Wireframe_Cull_Front_0 = n30.RasterizerStateDescriptions.WireframeCullFront;
            Wireframe_Cull_Front_Out = Wireframe_Cull_Front_0;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.TextureDescription.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CloneWithOptions(n5.TextureDescription Input_In, n26.PixelFormat Format_In, n5.TextureFlags Flags_In, n5.GraphicsResourceUsage Usage_In, n5.TextureOptions Options_In, out n5.TextureDescription Output_Out)
        {
            n5.TextureFlags __pad_JXQDT34KR7kNp5yrC65XFg_0 = __slot_JXQDT34KR7kNp5yrC65XFg;
            n26.PixelFormat __pad_EuDgtCjMqobQUbEThva1sn_1 = __slot_EuDgtCjMqobQUbEThva1sn;
            string __pad_QoHZVY1eToyL7KRBLtaOeN_2 = __slot_QoHZVY1eToyL7KRBLtaOeN;
            var Format_3 = Input_In.Format;
            var Result_4 = n26.PixelFormatExtensions.BlockSize(format: Format_3);
            var Result_5 = n26.PixelFormatExtensions.BlockSize(format: Format_In);
            var Result_6 = Result_4 == Result_5;
            var Result_7 = Format_In != __pad_EuDgtCjMqobQUbEThva1sn_1;
            var Output_8 = Result_6 && Result_7;
            n5.TextureDescription __auto_9;
            if (Output_8)
            {
                Input_In.Format = Format_In;
                __auto_9 = Input_In;
            }
            else
            {
                __auto_9 = Input_In;
            }

            var Result_10 = Flags_In != __pad_JXQDT34KR7kNp5yrC65XFg_0;
            n5.TextureDescription __auto_11;
            if (Result_10)
            {
                __auto_9.Flags = Flags_In;
                __auto_11 = __auto_9;
            }
            else
            {
                __auto_11 = __auto_9;
            }

            __auto_11.Usage = Usage_In;
            __auto_11.Options = Options_In;
            Output_Out = __auto_11;
            return;
        }

        [n1.ElementAttribute(TracingId = 127097U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "JXQDT34KR7kNp5yrC65XFg", Name = "__slot_JXQDT34KR7kNp5yrC65XFg")]
        public static n5.TextureFlags __slot_JXQDT34KR7kNp5yrC65XFg = n1.CompilationHelper.Deserialize<n5.TextureFlags>("None", false, "TiJxb2oN2LtNWRy2MbJV6Q", "JXQDT34KR7kNp5yrC65XFg");
        [n1.ElementAttribute(TracingId = 127105U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "EuDgtCjMqobQUbEThva1sn", Name = "__slot_EuDgtCjMqobQUbEThva1sn")]
        public static n26.PixelFormat __slot_EuDgtCjMqobQUbEThva1sn = n1.CompilationHelper.Deserialize<n26.PixelFormat>("None", false, "TiJxb2oN2LtNWRy2MbJV6Q", "EuDgtCjMqobQUbEThva1sn");
        [n1.ElementAttribute(TracingId = 127289U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "QoHZVY1eToyL7KRBLtaOeN", Name = "__slot_QoHZVY1eToyL7KRBLtaOeN")]
        public static string __slot_QoHZVY1eToyL7KRBLtaOeN = "Apply pin doesn't work!?";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.TextureViewDescription.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CloneWithOptions(n5.TextureViewDescription Input_In, n5.TextureFlags Flags_In, n26.PixelFormat Format_In, out n5.TextureViewDescription Output_Out)
        {
            n26.PixelFormat __pad_U13Nxk7DBamLTPpCqpx8N5_0 = __slot_U13Nxk7DBamLTPpCqpx8N5;
            string __pad_Rt7V9oiQfBoPCwxu5GmlA9_1 = __slot_Rt7V9oiQfBoPCwxu5GmlA9;
            var Format_2 = Input_In.Format;
            var Result_3 = n26.PixelFormatExtensions.BlockSize(format: Format_2);
            var Result_4 = n26.PixelFormatExtensions.BlockSize(format: Format_In);
            var Result_5 = Result_3 == Result_4;
            var Result_6 = Format_In != __pad_U13Nxk7DBamLTPpCqpx8N5_0;
            var Output_7 = Result_5 && Result_6;
            n5.TextureViewDescription __auto_8;
            if (Output_7)
            {
                Input_In.Format = Format_In;
                __auto_8 = Input_In;
            }
            else
            {
                __auto_8 = Input_In;
            }

            n5.TextureFlags Input_2_9 = default(n5.TextureFlags);
            var Result_10 = Flags_In != Input_2_9;
            n5.TextureViewDescription __auto_11;
            if (Result_10)
            {
                __auto_8.Flags = Flags_In;
                __auto_11 = __auto_8;
            }
            else
            {
                __auto_11 = __auto_8;
            }

            Output_Out = __auto_11;
            return;
        }

        [n1.ElementAttribute(TracingId = 127438U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "U13Nxk7DBamLTPpCqpx8N5", Name = "__slot_U13Nxk7DBamLTPpCqpx8N5")]
        public static n26.PixelFormat __slot_U13Nxk7DBamLTPpCqpx8N5 = n1.CompilationHelper.Deserialize<n26.PixelFormat>("None", false, "TiJxb2oN2LtNWRy2MbJV6Q", "U13Nxk7DBamLTPpCqpx8N5");
        [n1.ElementAttribute(TracingId = 127614U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "Rt7V9oiQfBoPCwxu5GmlA9", Name = "__slot_Rt7V9oiQfBoPCwxu5GmlA9")]
        public static string __slot_Rt7V9oiQfBoPCwxu5GmlA9 = "Apply pin doesn't work!?";
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Rendering.Advanced
{
    [n1.ElementAttribute(TracingId = 128120U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "DrRTbaiZGP9NAPMch8BXDP", Name = "RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP")]
    [n2.SerializableAttribute]
    public class RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n9.RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP Create(n1.NodeContext Node_Context)
        {
            var instance = new RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n9.RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP CreateDefault()
        {
            var instance = new RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n9.RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP Update([n4.SerializedDefaultValueAttribute("<DefaultValue xmlns=\"property\">\r\n  <Item xmlns=\"\">Group0</Item>\r\n</DefaultValue>", true)] n31.Spread<n8.RenderGroupMask> Input_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Reset_In, out n8.RenderGroupMask Output_Out)
        {
            n8.RenderGroupMask __pad_I4QKZnk6hD1L9s5wjnuYXl_0 = __slot_I4QKZnk6hD1L9s5wjnuYXl;
            bool Force_1 = false;
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_Ktx1UBgmRstMoCudcOHSjx;
            if (manager_3 is null)
            {
                manager_3 = new n34.Manager<n2.ValueTuple<n31.Spread<n8.RenderGroupMask>>, n2.ValueTuple<n8.RenderGroupMask>>(n2.ValueTuple.Create(default(n8.RenderGroupMask)));
            }

            var inputs_4 = n2.ValueTuple.Create(Input_In);
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Force_1 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                n8.RenderGroupMask __pad_R4kY9wrHDa3Ljt7D1H6wCD_8 = __slot_R4kY9wrHDa3Ljt7D1H6wCD;
                n8.RenderGroupMask accumulator_10 = __pad_R4kY9wrHDa3Ljt7D1H6wCD_8;
                var i_12 = 0;
                foreach (var item_9 in n4.CollectionExtensions.AsSpan(Input_In))
                {
                    var splicer_11 = item_9;
                    var i_local_13 = i_12;
                    var Output_15 = splicer_11 | accumulator_10;
                    accumulator_10 = Output_15;
                    i_12++;
                }

                outputs_5 = n2.ValueTuple.Create(accumulator_10);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, default, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_16 = outputs_5.Item1;
            var Output_19 = this.__p_PQTXdswwZZWLyJEtFst5nS.Update(Value_In: Reset_In, Up_Edge_Out: out bool Up_Edge_17, Down_Edge_Out: out bool Down_Edge_18);
            n16._Operations_.Switch_Boolean<n8.RenderGroupMask>(Condition_In: Up_Edge_17, Input_In: __auto_16, Input_2_In: __pad_I4QKZnk6hD1L9s5wjnuYXl_0, Output_Out: out n8.RenderGroupMask Output_20);
            Output_Out = Output_20;
            n9.RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP that_21 = this;
            if (this.__GetContext__().IsImmutable)
                that_21 = manager_3 != this.__cache_Ktx1UBgmRstMoCudcOHSjx || Output_19 != this.__p_PQTXdswwZZWLyJEtFst5nS ? new RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP(this)
                {__cache_Ktx1UBgmRstMoCudcOHSjx = manager_3, __p_PQTXdswwZZWLyJEtFst5nS = Output_19} : that_21;
            else
            {
                this.__cache_Ktx1UBgmRstMoCudcOHSjx = manager_3;
                this.__p_PQTXdswwZZWLyJEtFst5nS = Output_19;
            }

            return that_21;
        }

        public n9.RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP __Create__(n1.NodeContext Node_Context)
        {
            n6.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("TiJxb2oN2LtNWRy2MbJV6Q", "PQTXdswwZZWLyJEtFst5nS", 128208U);
            var Output_1 = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_0);
            n9.RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP that_2 = this;
            this.__p_PQTXdswwZZWLyJEtFst5nS = Output_1;
            this.__cache_Ktx1UBgmRstMoCudcOHSjx = null;
            return that_2;
        }

        public n9.RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP __CreateDefault__()
        {
            n9.RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP that_0 = this;
            this.__cache_Ktx1UBgmRstMoCudcOHSjx = null;
            this.__p_PQTXdswwZZWLyJEtFst5nS = n41.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_Ktx1UBgmRstMoCudcOHSjx);
            n1.CompilationHelper.SafeDispose(this.__p_PQTXdswwZZWLyJEtFst5nS);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 128202U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "I4QKZnk6hD1L9s5wjnuYXl", Name = "__slot_I4QKZnk6hD1L9s5wjnuYXl")]
        public static n8.RenderGroupMask __slot_I4QKZnk6hD1L9s5wjnuYXl = n1.CompilationHelper.Deserialize<n8.RenderGroupMask>("None", false, "TiJxb2oN2LtNWRy2MbJV6Q", "I4QKZnk6hD1L9s5wjnuYXl");
        [n1.ElementAttribute(TracingId = 128127U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "Ktx1UBgmRstMoCudcOHSjx", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n34.Manager<n2.ValueTuple<n31.Spread<n8.RenderGroupMask>>, n2.ValueTuple<n8.RenderGroupMask>> __cache_Ktx1UBgmRstMoCudcOHSjx = null;
        [n1.ElementAttribute(TracingId = 128171U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "R4kY9wrHDa3Ljt7D1H6wCD", Name = "__slot_R4kY9wrHDa3Ljt7D1H6wCD")]
        public static n8.RenderGroupMask __slot_R4kY9wrHDa3Ljt7D1H6wCD = default(n8.RenderGroupMask);
        [n1.ElementAttribute(TracingId = 128208U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "PQTXdswwZZWLyJEtFst5nS", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_PQTXdswwZZWLyJEtFst5nS;
        static RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP()
        {
        }

        public RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP(RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP other): base(other)
        {
            this.__cache_Ktx1UBgmRstMoCudcOHSjx = other.__cache_Ktx1UBgmRstMoCudcOHSjx;
            this.__p_PQTXdswwZZWLyJEtFst5nS = other.__p_PQTXdswwZZWLyJEtFst5nS;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Ktx1UBgmRstMoCudcOHSjx", in __cache_Ktx1UBgmRstMoCudcOHSjx), n1.CompilationHelper.GetValueOrExisting(values, "__p_PQTXdswwZZWLyJEtFst5nS", in __p_PQTXdswwZZWLyJEtFst5nS));
        }

        internal RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP __WITH__(n34.Manager<n2.ValueTuple<n31.Spread<n8.RenderGroupMask>>, n2.ValueTuple<n8.RenderGroupMask>> __cache_Ktx1UBgmRstMoCudcOHSjx, n41.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_PQTXdswwZZWLyJEtFst5nS)
        {
            n9.RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_Ktx1UBgmRstMoCudcOHSjx != this.__cache_Ktx1UBgmRstMoCudcOHSjx || __p_PQTXdswwZZWLyJEtFst5nS != this.__p_PQTXdswwZZWLyJEtFst5nS ? new RenderGroupSelector_DrRTbaiZGP9NAPMch8BXDP(this)
                {__cache_Ktx1UBgmRstMoCudcOHSjx = __cache_Ktx1UBgmRstMoCudcOHSjx, __p_PQTXdswwZZWLyJEtFst5nS = __p_PQTXdswwZZWLyJEtFst5nS} : that_0;
            else
            {
                this.__cache_Ktx1UBgmRstMoCudcOHSjx = __cache_Ktx1UBgmRstMoCudcOHSjx;
                this.__p_PQTXdswwZZWLyJEtFst5nS = __p_PQTXdswwZZWLyJEtFst5nS;
            }

            return that_0;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Rendering.Model.Advanced
{
    [n1.ElementAttribute(TracingId = 129745U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "IJUdBw4bPbUPe8cdqVGJ84", Name = "SetMaterials_IJUdBw4bPbUPe8cdqVGJ84")]
    [n2.SerializableAttribute]
    public class SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n42.SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 Create(n1.NodeContext Node_Context)
        {
            var instance = new SetMaterials_IJUdBw4bPbUPe8cdqVGJ84(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n42.SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 CreateDefault()
        {
            var instance = new SetMaterials_IJUdBw4bPbUPe8cdqVGJ84(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n42.SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 Update(n8.Model Input_In, out n8.Model Output_Out)
        {
            n8.Model __auto_0 = Input_In;
            Output_Out = __auto_0;
            n42.SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = Input_In != this.Model ? new SetMaterials_IJUdBw4bPbUPe8cdqVGJ84(this)
                {Model = Input_In} : that_1;
            else
            {
                this.Model = Input_In;
            }

            return that_1;
        }

        public n42.SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 SetMeshMaterialIndices(n7.IReadOnlyList<int> Material_Indices_In)
        {
            n8.Model __auto_0 = this.Model;
            n15.ObjectHelpers.IsAssigned(x: __auto_0, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            var state_3 = n1.CompilationHelper.Restore<__GR4o3D80zQZLc32cte47wk>(this.__if_OT46qxX1bbnPvl5Uj8AtZW, __GetContext__());
            if (Result_1)
            {
                if (state_3 == null)
                {
                    state_3 = new __GR4o3D80zQZLc32cte47wk(__GetContext__(), n1.VLObject.NewIdentity());
                }

                bool Force_4 = false;
                bool Dispose_Cached_Outputs_5 = false;
                var manager_6 = state_3.__cache_MurH9825PdtLWGXISIJFoy;
                if (manager_6 is null)
                {
                    manager_6 = new n34.Manager<n2.ValueTuple<n8.Model, n7.IReadOnlyList<int>>, n2.ValueTuple>(n2.ValueTuple.Create());
                }

                var inputs_7 = (__auto_0, Material_Indices_In);
                var outputs_8 = manager_6.Outputs;
                var Has_Changed_9 = Force_4 || manager_6.InputsChanged(inputs_7);
                if (Has_Changed_9)
                {
                    if (Dispose_Cached_Outputs_5)
                        manager_6.DisposeOutputs();
                    n42._Operations_.UpdateMaterialIndices(Model_In: __auto_0, Material_Indices_In: Material_Indices_In, Output_Out: out n8.Model Output_11);
                    outputs_8 = n2.ValueTuple.Create();
                    manager_6 = manager_6.Update(inputs_7, __GetContext__().IsImmutable, Dispose_Cached_Outputs_5, default, outputs_8);
                }
                else
                {
                    manager_6.Update(inputs_7, __GetContext__().IsImmutable, Dispose_Cached_Outputs_5);
                }

                if (state_3.__GetContext__().IsImmutable)
                    state_3 = manager_6 != state_3.__cache_MurH9825PdtLWGXISIJFoy ? new __GR4o3D80zQZLc32cte47wk(state_3)
                    {__cache_MurH9825PdtLWGXISIJFoy = manager_6} : state_3;
                else
                {
                    state_3.__cache_MurH9825PdtLWGXISIJFoy = manager_6;
                }
            }

            n42.SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = state_3 != this.__if_OT46qxX1bbnPvl5Uj8AtZW ? new SetMaterials_IJUdBw4bPbUPe8cdqVGJ84(this)
                {__if_OT46qxX1bbnPvl5Uj8AtZW = state_3} : that_12;
            else
            {
                this.__if_OT46qxX1bbnPvl5Uj8AtZW = state_3;
            }

            return that_12;
        }

        public n42.SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 SetMaterials(n7.IReadOnlyList<n8.Material> Materials_In)
        {
            n8.Model __auto_0 = this.Model;
            n15.ObjectHelpers.IsAssigned(x: __auto_0, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            var state_3 = n1.CompilationHelper.Restore<__BEo7oYgkKDBPj0iUlsKysz>(this.__if_P85MqbuxyhKObww3MGCCrS, __GetContext__());
            if (Result_1)
            {
                if (state_3 == null)
                {
                    state_3 = new __BEo7oYgkKDBPj0iUlsKysz(__GetContext__(), n1.VLObject.NewIdentity());
                }

                bool Force_4 = false;
                bool Dispose_Cached_Outputs_5 = false;
                var manager_6 = state_3.__cache_VlvoshEYo61MwC5oKXHNIt;
                if (manager_6 is null)
                {
                    manager_6 = new n34.Manager<n2.ValueTuple<n8.Model, n7.IReadOnlyList<n8.Material>>, n2.ValueTuple>(n2.ValueTuple.Create());
                }

                var inputs_7 = (__auto_0, Materials_In);
                var outputs_8 = manager_6.Outputs;
                var Has_Changed_9 = Force_4 || manager_6.InputsChanged(inputs_7);
                if (Has_Changed_9)
                {
                    if (Dispose_Cached_Outputs_5)
                        manager_6.DisposeOutputs();
                    n42._Operations_.UpdateMaterials(Model_In: __auto_0, Materials_In: Materials_In, Output_Out: out n8.Model Output_11);
                    outputs_8 = n2.ValueTuple.Create();
                    manager_6 = manager_6.Update(inputs_7, __GetContext__().IsImmutable, Dispose_Cached_Outputs_5, default, outputs_8);
                }
                else
                {
                    manager_6.Update(inputs_7, __GetContext__().IsImmutable, Dispose_Cached_Outputs_5);
                }

                if (state_3.__GetContext__().IsImmutable)
                    state_3 = manager_6 != state_3.__cache_VlvoshEYo61MwC5oKXHNIt ? new __BEo7oYgkKDBPj0iUlsKysz(state_3)
                    {__cache_VlvoshEYo61MwC5oKXHNIt = manager_6} : state_3;
                else
                {
                    state_3.__cache_VlvoshEYo61MwC5oKXHNIt = manager_6;
                }
            }

            n42.SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = state_3 != this.__if_P85MqbuxyhKObww3MGCCrS ? new SetMaterials_IJUdBw4bPbUPe8cdqVGJ84(this)
                {__if_P85MqbuxyhKObww3MGCCrS = state_3} : that_12;
            else
            {
                this.__if_P85MqbuxyhKObww3MGCCrS = state_3;
            }

            return that_12;
        }

        public n42.SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 __Create__(n1.NodeContext Node_Context)
        {
            n6.RuntimeHelpers.EnsureSufficientExecutionStack();
            n42.SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 that_0 = this;
            this.Model = default(n8.Model);
            this.__if_OT46qxX1bbnPvl5Uj8AtZW = default(n2.Object);
            this.__if_P85MqbuxyhKObww3MGCCrS = default(n2.Object);
            return that_0;
        }

        public n42.SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 __CreateDefault__()
        {
            n42.SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 that_0 = this;
            this.Model = default(n8.Model);
            this.__if_OT46qxX1bbnPvl5Uj8AtZW = default(n2.Object);
            this.__if_P85MqbuxyhKObww3MGCCrS = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_OT46qxX1bbnPvl5Uj8AtZW);
            n1.CompilationHelper.SafeDispose(this.__if_P85MqbuxyhKObww3MGCCrS);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 129960U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "TPH7CYOMshbP4HfZSWpwLH", Name = "Model")]
        public n8.Model Model;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_OT46qxX1bbnPvl5Uj8AtZW;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_P85MqbuxyhKObww3MGCCrS;
        public SetMaterials_IJUdBw4bPbUPe8cdqVGJ84(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SetMaterials_IJUdBw4bPbUPe8cdqVGJ84(SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 other): base(other)
        {
            this.Model = other.Model;
            this.__if_OT46qxX1bbnPvl5Uj8AtZW = other.__if_OT46qxX1bbnPvl5Uj8AtZW;
            this.__if_P85MqbuxyhKObww3MGCCrS = other.__if_P85MqbuxyhKObww3MGCCrS;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Model", in Model), n1.CompilationHelper.GetValueOrExisting(values, "__if_OT46qxX1bbnPvl5Uj8AtZW", in __if_OT46qxX1bbnPvl5Uj8AtZW), n1.CompilationHelper.GetValueOrExisting(values, "__if_P85MqbuxyhKObww3MGCCrS", in __if_P85MqbuxyhKObww3MGCCrS));
        }

        internal SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 __WITH__(n8.Model Model, n2.Object __if_OT46qxX1bbnPvl5Uj8AtZW, n2.Object __if_P85MqbuxyhKObww3MGCCrS)
        {
            n42.SetMaterials_IJUdBw4bPbUPe8cdqVGJ84 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Model != this.Model || __if_OT46qxX1bbnPvl5Uj8AtZW != this.__if_OT46qxX1bbnPvl5Uj8AtZW || __if_P85MqbuxyhKObww3MGCCrS != this.__if_P85MqbuxyhKObww3MGCCrS ? new SetMaterials_IJUdBw4bPbUPe8cdqVGJ84(this)
                {Model = Model, __if_OT46qxX1bbnPvl5Uj8AtZW = __if_OT46qxX1bbnPvl5Uj8AtZW, __if_P85MqbuxyhKObww3MGCCrS = __if_P85MqbuxyhKObww3MGCCrS} : that_0;
            else
            {
                this.Model = Model;
                this.__if_OT46qxX1bbnPvl5Uj8AtZW = __if_OT46qxX1bbnPvl5Uj8AtZW;
                this.__if_P85MqbuxyhKObww3MGCCrS = __if_P85MqbuxyhKObww3MGCCrS;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "GR4o3D80zQZLc32cte47wk", Name = "__GR4o3D80zQZLc32cte47wk")]
        [n2.SerializableAttribute]
        public class __GR4o3D80zQZLc32cte47wk : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__cache_MurH9825PdtLWGXISIJFoy);
                return;
            }

            [n1.ElementAttribute(TracingId = 129888U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "MurH9825PdtLWGXISIJFoy", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n34.Manager<n2.ValueTuple<n8.Model, n7.IReadOnlyList<int>>, n2.ValueTuple> __cache_MurH9825PdtLWGXISIJFoy = null;
            public __GR4o3D80zQZLc32cte47wk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __GR4o3D80zQZLc32cte47wk(__GR4o3D80zQZLc32cte47wk other): base(other)
            {
                this.__cache_MurH9825PdtLWGXISIJFoy = other.__cache_MurH9825PdtLWGXISIJFoy;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_MurH9825PdtLWGXISIJFoy", in __cache_MurH9825PdtLWGXISIJFoy));
            }

            internal __GR4o3D80zQZLc32cte47wk __WITH__(n34.Manager<n2.ValueTuple<n8.Model, n7.IReadOnlyList<int>>, n2.ValueTuple> __cache_MurH9825PdtLWGXISIJFoy)
            {
                __GR4o3D80zQZLc32cte47wk that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cache_MurH9825PdtLWGXISIJFoy != this.__cache_MurH9825PdtLWGXISIJFoy ? new __GR4o3D80zQZLc32cte47wk(this)
                    {__cache_MurH9825PdtLWGXISIJFoy = __cache_MurH9825PdtLWGXISIJFoy} : that_0;
                else
                {
                    this.__cache_MurH9825PdtLWGXISIJFoy = __cache_MurH9825PdtLWGXISIJFoy;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "BEo7oYgkKDBPj0iUlsKysz", Name = "__BEo7oYgkKDBPj0iUlsKysz")]
        [n2.SerializableAttribute]
        public class __BEo7oYgkKDBPj0iUlsKysz : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__cache_VlvoshEYo61MwC5oKXHNIt);
                return;
            }

            [n1.ElementAttribute(TracingId = 129788U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "VlvoshEYo61MwC5oKXHNIt", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n34.Manager<n2.ValueTuple<n8.Model, n7.IReadOnlyList<n8.Material>>, n2.ValueTuple> __cache_VlvoshEYo61MwC5oKXHNIt = null;
            public __BEo7oYgkKDBPj0iUlsKysz(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BEo7oYgkKDBPj0iUlsKysz(__BEo7oYgkKDBPj0iUlsKysz other): base(other)
            {
                this.__cache_VlvoshEYo61MwC5oKXHNIt = other.__cache_VlvoshEYo61MwC5oKXHNIt;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_VlvoshEYo61MwC5oKXHNIt", in __cache_VlvoshEYo61MwC5oKXHNIt));
            }

            internal __BEo7oYgkKDBPj0iUlsKysz __WITH__(n34.Manager<n2.ValueTuple<n8.Model, n7.IReadOnlyList<n8.Material>>, n2.ValueTuple> __cache_VlvoshEYo61MwC5oKXHNIt)
            {
                __BEo7oYgkKDBPj0iUlsKysz that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cache_VlvoshEYo61MwC5oKXHNIt != this.__cache_VlvoshEYo61MwC5oKXHNIt ? new __BEo7oYgkKDBPj0iUlsKysz(this)
                    {__cache_VlvoshEYo61MwC5oKXHNIt = __cache_VlvoshEYo61MwC5oKXHNIt} : that_0;
                else
                {
                    this.__cache_VlvoshEYo61MwC5oKXHNIt = __cache_VlvoshEYo61MwC5oKXHNIt;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 130066U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "GpWudul0K9tNrLaUbk13Gk", Name = "SetMaterial_GpWudul0K9tNrLaUbk13Gk")]
    [n2.SerializableAttribute]
    public class SetMaterial_GpWudul0K9tNrLaUbk13Gk : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n42.SetMaterial_GpWudul0K9tNrLaUbk13Gk Create(n1.NodeContext Node_Context)
        {
            var instance = new SetMaterial_GpWudul0K9tNrLaUbk13Gk(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n42.SetMaterial_GpWudul0K9tNrLaUbk13Gk CreateDefault()
        {
            var instance = new SetMaterial_GpWudul0K9tNrLaUbk13Gk(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n42.SetMaterial_GpWudul0K9tNrLaUbk13Gk Update(n8.Model Input_In, out n8.Model Output_Out)
        {
            n8.Model __auto_0 = Input_In;
            Output_Out = __auto_0;
            n42.SetMaterial_GpWudul0K9tNrLaUbk13Gk that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = Input_In != this.Model ? new SetMaterial_GpWudul0K9tNrLaUbk13Gk(this)
                {Model = Input_In} : that_1;
            else
            {
                this.Model = Input_In;
            }

            return that_1;
        }

        public n42.SetMaterial_GpWudul0K9tNrLaUbk13Gk SetMeshMaterialIndices()
        {
            return this;
        }

        public n42.SetMaterial_GpWudul0K9tNrLaUbk13Gk SetMaterials(n8.Material Material_In)
        {
            n8.Model __auto_0 = this.Model;
            n15.ObjectHelpers.IsAssigned(x: __auto_0, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            var state_3 = n1.CompilationHelper.Restore<__QNkho7YAkx6MxB7qCSU9vH>(this.__if_TgKcWRYpJ8KONfpgh2lv8p, __GetContext__());
            if (Result_1)
            {
                if (state_3 == null)
                {
                    state_3 = new __QNkho7YAkx6MxB7qCSU9vH(__GetContext__(), n1.VLObject.NewIdentity());
                }

                bool Force_4 = false;
                bool Dispose_Cached_Outputs_5 = false;
                var manager_6 = state_3.__cache_C1eALY8txJ5LorUH1WRhm0;
                if (manager_6 is null)
                {
                    manager_6 = new n34.Manager<n2.ValueTuple<n8.Model, n8.Material>, n2.ValueTuple>(n2.ValueTuple.Create());
                }

                var inputs_7 = (__auto_0, Material_In);
                var outputs_8 = manager_6.Outputs;
                var Has_Changed_9 = Force_4 || manager_6.InputsChanged(inputs_7);
                if (Has_Changed_9)
                {
                    if (Dispose_Cached_Outputs_5)
                        manager_6.DisposeOutputs();
                    var state_10 = n1.CompilationHelper.Restore<__DUqCRf9yTJrMzpy8SiXLlC>(manager_6.State, __GetContext__());
                    if (state_10 == null)
                    {
                        state_10 = new __DUqCRf9yTJrMzpy8SiXLlC(__GetContext__(), n1.VLObject.NewIdentity())
                        {__pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28 = n43._Operations_.CreateDefault<n8.Material>()};
                    }

                    n31.Spread<int> __pad_RKHAtE82apjPzH0ryL9GsK_11 = __slot_RKHAtE82apjPzH0ryL9GsK;
                    var builder_12 = n4.CollectionBuilders.GetBuilder(state_10.__pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28, 1);
                    builder_12.Add(Material_In);
                    var __pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28_13 = builder_12.Commit();
                    n43._Operations_.FromValue<n8.Material>(Input_In: __pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28_13, Result_Out: out n31.Spread<n8.Material> Result_14);
                    n7.IReadOnlyList<n8.Material> Materials_15 = (n7.IReadOnlyList<n8.Material>)Result_14;
                    n42._Operations_.UpdateMaterials(Model_In: __auto_0, Materials_In: Materials_15, Output_Out: out n8.Model Output_16);
                    n7.IReadOnlyList<int> Material_Indices_17 = (n7.IReadOnlyList<int>)__pad_RKHAtE82apjPzH0ryL9GsK_11;
                    n42._Operations_.UpdateMaterialIndices(Model_In: Output_16, Material_Indices_In: Material_Indices_17, Output_Out: out n8.Model Output_18);
                    if (state_10.__GetContext__().IsImmutable)
                        state_10 = __pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28_13 != state_10.__pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28 ? new __DUqCRf9yTJrMzpy8SiXLlC(state_10)
                        {__pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28 = __pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28_13} : state_10;
                    else
                    {
                        state_10.__pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28 = __pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28_13;
                    }

                    outputs_8 = n2.ValueTuple.Create();
                    manager_6 = manager_6.Update(inputs_7, __GetContext__().IsImmutable, Dispose_Cached_Outputs_5, state_10, outputs_8);
                }
                else
                {
                    manager_6.Update(inputs_7, __GetContext__().IsImmutable, Dispose_Cached_Outputs_5);
                }

                if (state_3.__GetContext__().IsImmutable)
                    state_3 = manager_6 != state_3.__cache_C1eALY8txJ5LorUH1WRhm0 ? new __QNkho7YAkx6MxB7qCSU9vH(state_3)
                    {__cache_C1eALY8txJ5LorUH1WRhm0 = manager_6} : state_3;
                else
                {
                    state_3.__cache_C1eALY8txJ5LorUH1WRhm0 = manager_6;
                }
            }

            n42.SetMaterial_GpWudul0K9tNrLaUbk13Gk that_19 = this;
            if (this.__GetContext__().IsImmutable)
                that_19 = state_3 != this.__if_TgKcWRYpJ8KONfpgh2lv8p ? new SetMaterial_GpWudul0K9tNrLaUbk13Gk(this)
                {__if_TgKcWRYpJ8KONfpgh2lv8p = state_3} : that_19;
            else
            {
                this.__if_TgKcWRYpJ8KONfpgh2lv8p = state_3;
            }

            return that_19;
        }

        public n42.SetMaterial_GpWudul0K9tNrLaUbk13Gk __Create__(n1.NodeContext Node_Context)
        {
            n6.RuntimeHelpers.EnsureSufficientExecutionStack();
            n42.SetMaterial_GpWudul0K9tNrLaUbk13Gk that_0 = this;
            this.Model = default(n8.Model);
            this.__if_TgKcWRYpJ8KONfpgh2lv8p = default(n2.Object);
            return that_0;
        }

        public n42.SetMaterial_GpWudul0K9tNrLaUbk13Gk __CreateDefault__()
        {
            n42.SetMaterial_GpWudul0K9tNrLaUbk13Gk that_0 = this;
            this.Model = default(n8.Model);
            this.__if_TgKcWRYpJ8KONfpgh2lv8p = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_TgKcWRYpJ8KONfpgh2lv8p);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 130216U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "LMajKRyjAJ5M5pTvUnoEDt", Name = "Model")]
        public n8.Model Model;
        [n1.ElementAttribute(TracingId = 130155U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "RKHAtE82apjPzH0ryL9GsK", Name = "__slot_RKHAtE82apjPzH0ryL9GsK")]
        public static n31.Spread<int> __slot_RKHAtE82apjPzH0ryL9GsK = n1.CompilationHelper.Deserialize<n31.Spread<int>>("0", false, "TiJxb2oN2LtNWRy2MbJV6Q", "RKHAtE82apjPzH0ryL9GsK");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_TgKcWRYpJ8KONfpgh2lv8p;
        static SetMaterial_GpWudul0K9tNrLaUbk13Gk()
        {
        }

        public SetMaterial_GpWudul0K9tNrLaUbk13Gk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SetMaterial_GpWudul0K9tNrLaUbk13Gk(SetMaterial_GpWudul0K9tNrLaUbk13Gk other): base(other)
        {
            this.Model = other.Model;
            this.__if_TgKcWRYpJ8KONfpgh2lv8p = other.__if_TgKcWRYpJ8KONfpgh2lv8p;
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Model", in Model), n1.CompilationHelper.GetValueOrExisting(values, "__if_TgKcWRYpJ8KONfpgh2lv8p", in __if_TgKcWRYpJ8KONfpgh2lv8p));
        }

        internal SetMaterial_GpWudul0K9tNrLaUbk13Gk __WITH__(n8.Model Model, n2.Object __if_TgKcWRYpJ8KONfpgh2lv8p)
        {
            n42.SetMaterial_GpWudul0K9tNrLaUbk13Gk that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Model != this.Model || __if_TgKcWRYpJ8KONfpgh2lv8p != this.__if_TgKcWRYpJ8KONfpgh2lv8p ? new SetMaterial_GpWudul0K9tNrLaUbk13Gk(this)
                {Model = Model, __if_TgKcWRYpJ8KONfpgh2lv8p = __if_TgKcWRYpJ8KONfpgh2lv8p} : that_0;
            else
            {
                this.Model = Model;
                this.__if_TgKcWRYpJ8KONfpgh2lv8p = __if_TgKcWRYpJ8KONfpgh2lv8p;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "QNkho7YAkx6MxB7qCSU9vH", Name = "__QNkho7YAkx6MxB7qCSU9vH")]
        [n2.SerializableAttribute]
        public class __QNkho7YAkx6MxB7qCSU9vH : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__cache_C1eALY8txJ5LorUH1WRhm0);
                return;
            }

            [n1.ElementAttribute(TracingId = 130091U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "C1eALY8txJ5LorUH1WRhm0", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n34.Manager<n2.ValueTuple<n8.Model, n8.Material>, n2.ValueTuple> __cache_C1eALY8txJ5LorUH1WRhm0 = null;
            public __QNkho7YAkx6MxB7qCSU9vH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __QNkho7YAkx6MxB7qCSU9vH(__QNkho7YAkx6MxB7qCSU9vH other): base(other)
            {
                this.__cache_C1eALY8txJ5LorUH1WRhm0 = other.__cache_C1eALY8txJ5LorUH1WRhm0;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_C1eALY8txJ5LorUH1WRhm0", in __cache_C1eALY8txJ5LorUH1WRhm0));
            }

            internal __QNkho7YAkx6MxB7qCSU9vH __WITH__(n34.Manager<n2.ValueTuple<n8.Model, n8.Material>, n2.ValueTuple> __cache_C1eALY8txJ5LorUH1WRhm0)
            {
                __QNkho7YAkx6MxB7qCSU9vH that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cache_C1eALY8txJ5LorUH1WRhm0 != this.__cache_C1eALY8txJ5LorUH1WRhm0 ? new __QNkho7YAkx6MxB7qCSU9vH(this)
                    {__cache_C1eALY8txJ5LorUH1WRhm0 = __cache_C1eALY8txJ5LorUH1WRhm0} : that_0;
                else
                {
                    this.__cache_C1eALY8txJ5LorUH1WRhm0 = __cache_C1eALY8txJ5LorUH1WRhm0;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "DUqCRf9yTJrMzpy8SiXLlC", Name = "__DUqCRf9yTJrMzpy8SiXLlC")]
        [n2.SerializableAttribute]
        public class __DUqCRf9yTJrMzpy8SiXLlC : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n31.Spread<n8.Material> __pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28 = default(n31.Spread<n8.Material>);
            public __DUqCRf9yTJrMzpy8SiXLlC(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DUqCRf9yTJrMzpy8SiXLlC(__DUqCRf9yTJrMzpy8SiXLlC other): base(other)
            {
                this.__pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28 = other.__pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28;
            }

            protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28", in __pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28));
            }

            internal __DUqCRf9yTJrMzpy8SiXLlC __WITH__(n31.Spread<n8.Material> __pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28)
            {
                __DUqCRf9yTJrMzpy8SiXLlC that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28 != this.__pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28 ? new __DUqCRf9yTJrMzpy8SiXLlC(this)
                    {__pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28 = __pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28} : that_0;
                else
                {
                    this.__pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28 = __pin_group_Input_In_VGNI8vUDiWlMX5VOyBme28;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CreateWithMesh(n8.Mesh Mesh_In, out n8.Model Output_Out)
        {
            var Output_0 = new n8.Model();
            Output_0.Add(mesh: Mesh_In);
            Output_Out = Output_0;
            return;
        }

        public static void UpdateMaterials(n8.Model Model_In, n7.IReadOnlyList<n8.Material> Materials_In, out n8.Model Output_Out)
        {
            var Materials_0 = Model_In.Materials;
            Materials_0.Clear();
            var i_3 = 0;
            foreach (var item_1 in Materials_In)
            {
                var splicer_2 = item_1;
                var i_local_4 = i_3;
                n15.ObjectHelpers.IsAssigned(x: splicer_2, result: out bool Result_5, notAssigned: out bool Not_Assigned_6);
                if (Result_5)
                {
                    var Result_7 = (n8.MaterialInstance)splicer_2;
                    Materials_0.Add(item: Result_7);
                }

                i_3++;
            }

            Output_Out = Model_In;
            return;
        }

        public static void UpdateMaterialIndices(n8.Model Model_In, n7.IReadOnlyList<int> Material_Indices_In, out n8.Model Output_Out)
        {
            var Meshes_0 = Model_In.Meshes;
            var Count_1 = Meshes_0.Count;
            var __auto_Count_3 = Meshes_0.Count;
            var __safeGuard_4 = __auto_Count_3 >= Count_1;
            var __auto_Count_6 = Material_Indices_In.Count;
            var __safeGuard_7 = __auto_Count_6 >= Count_1;
            for (var i_2 = 0; i_2 < Count_1; i_2++)
            {
                var splicer_5 = __safeGuard_4 ? Meshes_0[i_2] : __auto_Count_3 > 0 ? Meshes_0[i_2 % __auto_Count_3] : default(n8.Mesh);
                var splicer_8 = __safeGuard_7 ? Material_Indices_In[i_2] : __auto_Count_6 > 0 ? Material_Indices_In[i_2 % __auto_Count_6] : default(int);
                var i_local_9 = i_2;
                splicer_5.MaterialIndex = splicer_8;
            }

            Output_Out = Model_In;
            return;
        }

        public static void SetSingleMaterial(n8.Model Model_In, n8.Material Material_In, out n8.Model Output_Out)
        {
            var Materials_0 = Model_In.Materials;
            n15.ObjectHelpers.IsAssigned(x: Material_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            Materials_0.Clear();
            if (Result_1)
            {
                n31.Spread<int> __pad_BlGB6cvUqT0LbUVMlSw7hm_3 = __slot_BlGB6cvUqT0LbUVMlSw7hm;
                var Result_4 = (n8.MaterialInstance)Material_In;
                Materials_0.Add(item: Result_4);
                n7.IReadOnlyList<int> Material_Indices_5 = (n7.IReadOnlyList<int>)__pad_BlGB6cvUqT0LbUVMlSw7hm_3;
                n42._Operations_.UpdateMaterialIndices(Model_In: Model_In, Material_Indices_In: Material_Indices_5, Output_Out: out n8.Model Output_6);
            }

            Output_Out = Model_In;
            return;
        }

        [n1.ElementAttribute(TracingId = 129682U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "BlGB6cvUqT0LbUVMlSw7hm", Name = "__slot_BlGB6cvUqT0LbUVMlSw7hm")]
        public static n31.Spread<int> __slot_BlGB6cvUqT0LbUVMlSw7hm = n1.CompilationHelper.Deserialize<n31.Spread<int>>("0", false, "TiJxb2oN2LtNWRy2MbJV6Q", "BlGB6cvUqT0LbUVMlSw7hm");
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Rendering.Mesh.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CreateWithMeshDrawAndBoundingBox(n8.MeshDraw Mesh_Draw_In, n10.BoundingBox BoundingBox_In, out n8.Mesh Output_Out)
        {
            var Output_0 = new n8.Mesh();
            Output_0.Draw = Mesh_Draw_In;
            Output_0.BoundingBox = BoundingBox_In;
            Output_Out = Output_0;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Rendering.ParameterCollection.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void Set<T>(n11.ParameterCollection Input_In, n11.ValueParameter<T> Parameter_In, T Value_In, out n11.ParameterCollection Output_Out)
            where T : struct
        {
            Input_In.Set<T>(parameter: Parameter_In, value: ref Value_In);
            Output_Out = Input_In;
            return;
        }

        public static void Set<T>(n11.ParameterCollection Input_In, n11.ValueParameterKey<T> Parameter_In, T[] Values_In, out n11.ParameterCollection Output_Out)
            where T : struct
        {
            Input_In.Set<T>(parameter: Parameter_In, values: Values_In);
            Output_Out = Input_In;
            return;
        }

        public static void SetObject<T>(n11.ParameterCollection Input_In, n11.ObjectParameterKey<T> Parameter_In, T Value_In, out n11.ParameterCollection Output_Out)
        {
            Input_In.Set<T>(parameter: Parameter_In, value: Value_In);
            Output_Out = Input_In;
            return;
        }

        public static void Set<T>(n11.ParameterCollection Input_In, n11.PermutationParameter<T> Parameter_In, T Value_In, out n11.ParameterCollection Output_Out)
        {
            Input_In.Set<T>(parameter: Parameter_In, value: Value_In);
            Output_Out = Input_In;
            return;
        }

        public static void SetValue<T>(n11.ParameterCollection Input_In, n11.ValueParameterKey<T> Parameter_In, T Value_In, out n11.ParameterCollection Output_Out)
            where T : struct
        {
            Input_In.Set<T>(parameter: Parameter_In, value: ref Value_In);
            Output_Out = Input_In;
            return;
        }

        public static void Set<T>(n11.ParameterCollection Input_In, n11.ObjectParameterAccessor<T> Parameter_Accessor_In, T Value_In, out n11.ParameterCollection Output_Out)
        {
            Input_In.Set<T>(parameterAccessor: Parameter_Accessor_In, value: Value_In);
            Output_Out = Input_In;
            return;
        }

        public static void Set<T>(n11.ParameterCollection Input_In, n11.PermutationParameterKey<T> Parameter_In, T Value_In, out n11.ParameterCollection Output_Out)
        {
            Input_In.Set<T>(parameter: Parameter_In, value: Value_In);
            Output_Out = Input_In;
            return;
        }

        public static void Set<T>(n11.ParameterCollection Input_In, n11.ValueParameterKey<T> Parameter_In, int Count_In, T First_Value_In, out n11.ParameterCollection Output_Out)
            where T : struct
        {
            Input_In.Set<T>(parameter: Parameter_In, count: Count_In, firstValue: ref First_Value_In);
            Output_Out = Input_In;
            return;
        }

        public static void Set<T>(n11.ParameterCollection Input_In, n11.ValueParameter<T> Parameter_In, int Count_In, T First_Value_In, out n11.ParameterCollection Output_Out)
            where T : struct
        {
            Input_In.Set<T>(parameter: Parameter_In, count: Count_In, firstValue: ref First_Value_In);
            Output_Out = Input_In;
            return;
        }

        public static void Set<T>(n11.ParameterCollection Input_In, n11.ValueParameterKey<T> Parameter_In, T Value_In, out n11.ParameterCollection Output_Out)
            where T : struct
        {
            Input_In.Set<T>(parameter: Parameter_In, value: ref Value_In);
            Output_Out = Input_In;
            return;
        }

        public static void Set<T>(n11.ParameterCollection Input_In, n11.ObjectParameterKey<T> Parameter_In, T Value_In, out n11.ParameterCollection Output_Out)
        {
            Input_In.Set<T>(parameter: Parameter_In, value: Value_In);
            Output_Out = Input_In;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Rendering.ParameterKeys.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void NewObject<T>(T Default_Value_In, string Name_In, out n11.ObjectParameterKey<T> Result_Out)
        {
            var Result_0 = n11.ParameterKeys.NewObject<T>(defaultValue: Default_Value_In, name: Name_In);
            Result_Out = Result_0;
            return;
        }

        public static void NewValue<T>(T Default_Value_In, string Name_In, out n11.ValueParameterKey<T> Result_Out)
            where T : struct
        {
            var Result_0 = n11.ParameterKeys.NewValue<T>(defaultValue: Default_Value_In, name: Name_In);
            Result_Out = Result_0;
            return;
        }

        public static void TryFindByName(string Name_In, out n11.ParameterKey Result_Out)
        {
            var Result_0 = n11.ParameterKeys.TryFindByName(name: Name_In);
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Games.Utils.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void LoadAsset<T2, T>(T2 Game_In, n12.ContentManager Content_Manager_In, string Path_In, out T Result_Out)
            where T2 : n14.GameBase where T : class
        {
            n13._Operations_.GetDefaultContentManagerIfNull(Game_In: Game_In, Content_Manager_In: Content_Manager_In, Content_Manager_Out: out n12.ContentManager Content_Manager_0);
            n12.ContentManagerLoaderSettings Settings_1 = default(n12.ContentManagerLoaderSettings);
            var Result_2 = Content_Manager_0.Load<T>(url: Path_In, settings: Settings_1);
            Result_Out = Result_2;
            return;
        }

        public static void GetDefaultContentManagerIfNull(n14.GameBase Game_In, n12.ContentManager Content_Manager_In, out n12.ContentManager Content_Manager_Out)
        {
            n15.ObjectHelpers.IsAssigned(x: Content_Manager_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            n12.ContentManager __auto_2;
            if (Not_Assigned_1)
            {
                var Content_3 = Game_In.Content;
                __auto_2 = Content_3;
            }
            else
            {
                __auto_2 = Content_Manager_In;
            }

            Content_Manager_Out = __auto_2;
            return;
        }

        public static void AssetExists(n14.GameBase Game_In, n12.ContentManager Content_Manager_In, string Url_In, string Default_Url_In, out n12.ContentManager Content_Manager_Out, out bool Result_Out, out string Url_Out)
        {
            n13._Operations_.GetDefaultContentManagerIfNull(Game_In: Game_In, Content_Manager_In: Content_Manager_In, Content_Manager_Out: out n12.ContentManager Content_Manager_0);
            n12.ContentManager Default_Output_1_1 = default(n12.ContentManager);
            bool Default_Output_2_2 = false;
            var __fallback___3 = n1.ServiceRegistry.Current;
            n17._Operations_.Try3__3Outputs_Stateless<n12.ContentManager, bool, string>(Default_Output_1_In: Default_Output_1_1, Default_Output_2_In: Default_Output_2_2, Default_Output_3_In: Default_Url_In, Try_In: () =>
            {
                using var __current_4 = __fallback___3.MakeCurrentIfNone();
                var Result_5 = Content_Manager_0.Exists(url: Url_In);
                n16._Operations_.Switch_Boolean<string>(Condition_In: Result_5, Input_In: Default_Url_In, Input_2_In: Url_In, Output_Out: out string Output_6);
                return n2.Tuple.Create<n12.ContentManager, bool, string>(Content_Manager_0, Result_5, Output_6);
            }

            , Output_1_Out: out n12.ContentManager Output_1_7, Output_2_Out: out bool Output_2_8, Output_3_Out: out string Output_3_9, Success_Out: out bool Success_10, Error_Message_Out: out string Error_Message_11);
            Content_Manager_Out = Output_1_7;
            Result_Out = Output_2_8;
            Url_Out = Output_3_9;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Core.Utils.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void EnsureOne<T, AdM>(T Input_In, out T Output_Out)
            where AdM : struct, n18.IAdaptiveMax<T>, n18.IAdaptiveOne<T>
        {
            var w_0 = default(AdM);
            w_0.One(One_Out: out T One_1);
            w_0.Max(Input_In: Input_In, Input_2_In: One_1, Output_Out: out T Output_2);
            Output_Out = Output_2;
            return;
        }

        public static void AvoidNull<T>(T Input_In, n2.Func<T> Create_Default_Value_In, out T Output_Out)
        {
            n19._Operations_.AsObject<T>(Input_In: Input_In, Result_Out: out n2.Object Result_0);
            n15.ObjectHelpers.IsAssigned(x: Result_0, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            T __auto_3;
            if (Not_Assigned_2)
            {
                n20._Operations_.Invoke<T>(Input_In: Create_Default_Value_In, Result_Out: out T Result_4);
                __auto_3 = Result_4;
            }
            else
            {
                __auto_3 = Input_In;
            }

            Output_Out = __auto_3;
            return;
        }

        public static void SafeListSetter<T2, T>(T2 Input_In, int Index_In, T Item_In, out T2 Output_Out, out int Item_Index_Out)
            where T2 : n7.IList<T>
        {
            int __pad_GVxA6asPHr8NSmJ5LJhsXy_0 = __slot_GVxA6asPHr8NSmJ5LJhsXy;
            n15.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            n7.ICollection<T> Input_3 = (n7.ICollection<T>)Input_In;
            n7.IList<T> Input_4 = (n7.IList<T>)Input_In;
            int __auto_5;
            if (Result_1)
            {
                var Count_6 = Input_3.Count;
                int Input_2_7 = 0;
                var Result_8 = Count_6 > Input_2_7;
                var Output_9 = !Result_8;
                var Output_10 = Input_3;
                if (Output_9)
                {
                    ((n7.ICollection<T>)Input_3).Add(item: Item_In);
                }

                int __auto_11;
                if (Result_8)
                {
                    var Output_12 = n21.Integer32Extensions.ZMOD(z: Index_In, input2: Count_6);
                    Input_4[Output_12] = Item_In;
                    __auto_11 = Output_12;
                }
                else
                {
                    __auto_11 = __pad_GVxA6asPHr8NSmJ5LJhsXy_0;
                }

                __auto_5 = __auto_11;
            }
            else
            {
                __auto_5 = __pad_GVxA6asPHr8NSmJ5LJhsXy_0;
            }

            Output_Out = Input_In;
            Item_Index_Out = __auto_5;
            return;
        }

        public static void SafeListGetter<T2, T>(T2 Input_In, int Index_In, T Default_Item_In, out T2 Output_Out, out T Item_Out, out int Item_Index_Out)
            where T2 : n7.IList<T>
        {
            int __pad_VJEdioclbFSM48DmLaDRK1_0 = __slot_VJEdioclbFSM48DmLaDRK1;
            n7.ICollection<T> Input_1 = (n7.ICollection<T>)Input_In;
            n15.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_2, notAssigned: out bool Not_Assigned_3);
            n7.IList<T> Input_4 = (n7.IList<T>)Input_In;
            T __auto_5;
            int __auto_6;
            if (Result_2)
            {
                var Count_7 = Input_1.Count;
                int Input_2_8 = 0;
                var Result_9 = Count_7 > Input_2_8;
                T __auto_10;
                int __auto_11;
                if (Result_9)
                {
                    var Output_12 = n21.Integer32Extensions.ZMOD(z: Index_In, input2: Count_7);
                    var Item_13 = Input_4[Output_12];
                    __auto_11 = Output_12;
                    __auto_10 = Item_13;
                }
                else
                {
                    __auto_10 = Default_Item_In;
                    __auto_11 = __pad_VJEdioclbFSM48DmLaDRK1_0;
                }

                __auto_5 = __auto_10;
                __auto_6 = __auto_11;
            }
            else
            {
                __auto_5 = Default_Item_In;
                __auto_6 = __pad_VJEdioclbFSM48DmLaDRK1_0;
            }

            Output_Out = Input_In;
            Item_Out = __auto_5;
            Item_Index_Out = __auto_6;
            return;
        }

        [n1.ElementAttribute(TracingId = 139768U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "GVxA6asPHr8NSmJ5LJhsXy", Name = "__slot_GVxA6asPHr8NSmJ5LJhsXy")]
        public static int __slot_GVxA6asPHr8NSmJ5LJhsXy = -1;
        [n1.ElementAttribute(TracingId = 139905U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "VJEdioclbFSM48DmLaDRK1", Name = "__slot_VJEdioclbFSM48DmLaDRK1")]
        public static int __slot_VJEdioclbFSM48DmLaDRK1 = -1;
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Core.Mathematics.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CreateUnitBoundingBox(out n10.BoundingBox Output_Out)
        {
            n10.Vector3 __pad_VvLkAL0eDRvLknd099F98K_0 = __slot_VvLkAL0eDRvLknd099F98K;
            n10.Vector3 __pad_Tng6ZJMazWWNhVZwRtwWIa_1 = __slot_Tng6ZJMazWWNhVZwRtwWIa;
            var Output_2 = new n10.BoundingBox(minimum: __pad_VvLkAL0eDRvLknd099F98K_0, maximum: __pad_Tng6ZJMazWWNhVZwRtwWIa_1);
            Output_Out = Output_2;
            return;
        }

        [n1.ElementAttribute(TracingId = 139963U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "VvLkAL0eDRvLknd099F98K", Name = "__slot_VvLkAL0eDRvLknd099F98K")]
        public static n10.Vector3 __slot_VvLkAL0eDRvLknd099F98K = n1.CompilationHelper.Deserialize<n10.Vector3>("-0.5, -0.5, -0.5", false, "TiJxb2oN2LtNWRy2MbJV6Q", "VvLkAL0eDRvLknd099F98K");
        [n1.ElementAttribute(TracingId = 139966U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "Tng6ZJMazWWNhVZwRtwWIa", Name = "__slot_Tng6ZJMazWWNhVZwRtwWIa")]
        public static n10.Vector3 __slot_Tng6ZJMazWWNhVZwRtwWIa = n1.CompilationHelper.Deserialize<n10.Vector3>("0.5, 0.5, 0.5", false, "TiJxb2oN2LtNWRy2MbJV6Q", "Tng6ZJMazWWNhVZwRtwWIa");
        static _Operations_()
        {
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Engine.Scene.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create(n1.NodeContext Node_Context, out n22.Scene Output_Out)
        {
            var Output_0 = new n22.Scene();
            Output_Out = Output_0;
            return;
        }

        public static void Children(n22.Scene Input_In, out n22.Scene Output_Out, out n23.TrackingCollection<n22.Scene> Children_Out)
        {
            var Children_0 = Input_In.Children;
            Output_Out = Input_In;
            Children_Out = Children_0;
            return;
        }

        public static void Entities(n22.Scene Input_In, out n22.Scene Output_Out, out n23.TrackingCollection<n22.Entity> Entities_Out)
        {
            var Entities_0 = Input_In.Entities;
            Output_Out = Input_In;
            Entities_Out = Entities_0;
            return;
        }

        public static void Id(n22.Scene Input_In, out n22.Scene Output_Out, out n2.Guid Id_Out)
        {
            var Id_0 = Input_In.Id;
            Output_Out = Input_In;
            Id_Out = Id_0;
            return;
        }

        public static void Parent(n22.Scene Input_In, out n22.Scene Output_Out, out n22.Scene Parent_Out)
        {
            var Parent_0 = Input_In.Parent;
            Output_Out = Input_In;
            Parent_Out = Parent_0;
            return;
        }

        public static void SetOffset(n22.Scene Input_In, n10.Vector3 Value_In, out n22.Scene Output_Out)
        {
            Input_In.Offset = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void Offset(n22.Scene Input_In, out n22.Scene Output_Out, out n10.Vector3 Offset_Out)
        {
            var Offset_0 = Input_In.Offset;
            Output_Out = Input_In;
            Offset_Out = Offset_0;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Engine.Entity.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        [n4.CreateNewAttribute]
        public static void Create(n1.NodeContext Node_Context, out n22.Entity Output_Out)
        {
            var Output_0 = new n22.Entity();
            Output_Out = Output_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create(n1.NodeContext Node_Context, string Name_In, out n22.Entity Output_Out)
        {
            var Output_0 = new n22.Entity(name: Name_In);
            Output_Out = Output_0;
            return;
        }

        [n4.CreateNewAttribute]
        public static void Create(n1.NodeContext Node_Context, n10.Vector3 Position_In, string Name_In, out n22.Entity Output_Out)
        {
            var Output_0 = new n22.Entity(position: Position_In, name: Name_In);
            Output_Out = Output_0;
            return;
        }

        public static void AddComponent(n22.Entity Input_In, n22.EntityComponent Component_In, out n22.Entity Output_Out)
        {
            Input_In.Add(component: Component_In);
            Output_Out = Input_In;
            return;
        }

        public static void GetComponent<T>(n22.Entity Input_In, out n22.Entity Output_Out, out T Result_Out)
            where T : n22.EntityComponent
        {
            var Result_0 = Input_In.Get<T>();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void GetComponent<T>(n22.Entity Input_In, int Index_In, out n22.Entity Output_Out, out T Result_Out)
            where T : n22.EntityComponent
        {
            var Result_0 = Input_In.Get<T>(index: Index_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void GetAllComponents<T>(n22.Entity Input_In, out n22.Entity Output_Out, out n7.IEnumerable<T> Result_Out)
            where T : n22.EntityComponent
        {
            var Result_0 = Input_In.GetAll<T>();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void GetEnumerator(n22.Entity Input_In, out n22.Entity Output_Out, out n23.FastCollection<n22.EntityComponent>.Enumerator Result_Out)
        {
            var Result_0 = Input_In.GetEnumerator();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void GetOrCreateComponent<T>(n22.Entity Input_In, out n22.Entity Output_Out, out T Result_Out)
            where T : n22.EntityComponent, new()
        {
            var Result_0 = Input_In.GetOrCreate<T>();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void RemoveComponent(n22.Entity Input_In, out n22.Entity Output_Out)
        {
            Output_Out = default(n22.Entity);
            return;
        }

        public static void RemoveComponent(n22.Entity Input_In, n22.EntityComponent Component_In, out n22.Entity Output_Out)
        {
            Input_In.Remove(component: Component_In);
            Output_Out = Input_In;
            return;
        }

        public static void RemoveAllComponents(n22.Entity Input_In, out n22.Entity Output_Out)
        {
            Output_Out = default(n22.Entity);
            return;
        }

        public static void ToString(n22.Entity Input_In, out n22.Entity Output_Out, out string Result_Out)
        {
            var Result_0 = Input_In.ToString();
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void Components(n22.Entity Input_In, out n22.Entity Output_Out, out n22.EntityComponentCollection Components_Out)
        {
            var Components_0 = Input_In.Components;
            Output_Out = Input_In;
            Components_Out = Components_0;
            return;
        }

        public static void EntityManager(n22.Entity Input_In, out n22.Entity Output_Out, out n22.EntityManager Entity_Manager_Out)
        {
            var Entity_Manager_0 = Input_In.EntityManager;
            Output_Out = Input_In;
            Entity_Manager_Out = Entity_Manager_0;
            return;
        }

        public static void Id(n22.Entity Input_In, out n22.Entity Output_Out, out n2.Guid Id_Out)
        {
            var Id_0 = Input_In.Id;
            Output_Out = Input_In;
            Id_Out = Id_0;
            return;
        }

        public static void SetId(n22.Entity Input_In, n2.Guid Value_In, out n22.Entity Output_Out)
        {
            Input_In.Id = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void Name(n22.Entity Input_In, out n22.Entity Output_Out, out string Name_Out)
        {
            var Name_0 = Input_In.Name;
            Output_Out = Input_In;
            Name_Out = Name_0;
            return;
        }

        public static void SetName(n22.Entity Input_In, string Value_In, out n22.Entity Output_Out)
        {
            Input_In.Name = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void Scene(n22.Entity Input_In, out n22.Entity Output_Out, out n22.Scene Scene_Out)
        {
            var Scene_0 = Input_In.Scene;
            Output_Out = Input_In;
            Scene_Out = Scene_0;
            return;
        }

        public static void SetScene(n22.Entity Input_In, n22.Scene Value_In, out n22.Entity Output_Out)
        {
            Input_In.Scene = Value_In;
            Output_Out = Input_In;
            return;
        }

        public static void Transform(n22.Entity Input_In, out n22.Entity Output_Out, out n22.TransformComponent Transform_Out)
        {
            var Transform_0 = Input_In.Transform;
            Output_Out = Input_In;
            Transform_Out = Transform_0;
            return;
        }

        public static void Clone(n22.Entity Input_In, out n22.Entity Output_Out)
        {
            var Output_0 = n22.EntityExtensions.Clone(entity: Input_In);
            Output_Out = Output_0;
            return;
        }

        public static void Enable(n22.Entity Input_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Apply_On_Children_In)
        {
            return;
        }

        public static void EnableAll(n22.Entity Input_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Apply_On_Children_In)
        {
            n22.EntityExtensions.EnableAll(entity: Input_In, enabled: Enabled_In, applyOnChildren: Apply_On_Children_In);
            return;
        }

        public static void GetChildren(n22.Entity Input_In, out n7.IEnumerable<n22.Entity> Result_Out)
        {
            var Result_0 = n22.EntityExtensions.GetChildren(entity: Input_In);
            Result_Out = Result_0;
            return;
        }

        public static void SetLocalMatrix(n22.Entity Input_In, n10.Matrix Transformation_In, out n22.Entity Output_Out)
        {
            var Transform_0 = Input_In.Transform;
            bool Value_1 = false;
            Transform_0.UseTRS = Value_1;
            Transform_0.LocalMatrix = Transformation_In;
            Output_Out = Input_In;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Input.KeyEvent.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void IsKey(n35.KeyEvent Input_In, n35.Keys Key_In, out n35.KeyEvent Output_Out, out bool Result_Out)
        {
            var Key_0 = Input_In.Key;
            var Result_1 = Key_0 == Key_In;
            Output_Out = Input_In;
            Result_Out = Result_1;
            return;
        }

        public static void IsFirstDown(n35.KeyEvent Input_In, out n35.KeyEvent Output_Out, out bool Result_Out)
        {
            var Is_Down_0 = Input_In.IsDown;
            var Repeat_Count_1 = Input_In.RepeatCount;
            int Input_2_2 = 0;
            var Result_3 = Repeat_Count_1 == Input_2_2;
            var Output_4 = Is_Down_0 && Result_3;
            Output_Out = Input_In;
            Result_Out = Output_4;
            return;
        }

        public static void IsFromSource(n35.InputEvent Input_In, n35.IInputSource Source_In, out n35.InputEvent Output_Out, out bool Result_Out)
        {
            var Device_0 = Input_In.Device;
            var Source_1 = Device_0.Source;
            var Result_2 = n15.ObjectHelpers.Eq(input: Source_1, input2: Source_In);
            Output_Out = Input_In;
            Result_Out = Result_2;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Input.IMouseDevice.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void IsButtonDown(n35.IMouseDevice Input_In, n35.MouseButton Mouse_Button_In, out n35.IMouseDevice Output_Out, out bool Result_Out)
        {
            var Result_0 = n36.InputNodes.IsButtonDown(input: Input_In, mouseButton: Mouse_Button_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void IsButtonPressed(n35.IMouseDevice Input_In, n35.MouseButton Mouse_Button_In, out n35.IMouseDevice Output_Out, out bool Result_Out)
        {
            var Result_0 = n36.InputNodes.IsButtonPressed(input: Input_In, mouseButton: Mouse_Button_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void IsButtonReleased(n35.IMouseDevice Input_In, n35.MouseButton Mouse_Button_In, out n35.IMouseDevice Output_Out, out bool Result_Out)
        {
            var Result_0 = n36.InputNodes.IsButtonReleased(input: Input_In, mouseButton: Mouse_Button_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Input.IKeyboardDevice.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void IsKeyDown(n35.IKeyboardDevice Input_In, n35.Keys Key_In, out n35.IKeyboardDevice Output_Out, out bool Result_Out)
        {
            var Result_0 = n36.InputNodes.IsKeyDown(input: Input_In, key: Key_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void IsKeyPressed(n35.IKeyboardDevice Input_In, n35.Keys Key_In, out n35.IKeyboardDevice Output_Out, out bool Result_Out)
        {
            var Result_0 = n36.InputNodes.IsKeyPressed(input: Input_In, key: Key_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }

        public static void IsKeyReleased(n35.IKeyboardDevice Input_In, n35.Keys Key_In, out n35.IKeyboardDevice Output_Out, out bool Result_Out)
        {
            var Result_0 = n36.InputNodes.IsKeyReleased(input: Input_In, key: Key_In);
            Output_Out = Input_In;
            Result_Out = Result_0;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride.API.Shaders.ShaderClassSource.Advanced
{
    [n1.ElementAttribute(TracingId = 123958U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CreateWithGenericArgs(string Class_Name_In, n31.Spread<n2.Object> Arg_In, out n40.ShaderClassSource Output_Out)
        {
            n32._Operations_.GetInternalArray<n2.Object>(Input_In: Arg_In, Result_Out: out n2.Object[] Result_0);
            var Output_1 = new n40.ShaderClassSource(className: Class_Name_In, genericArguments: Result_0);
            Output_Out = Output_1;
            return;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_.Stride
{
    [n1.ElementAttribute(TracingId = 141474U, DocumentId = "TiJxb2oN2LtNWRy2MbJV6Q", PersistentId = "JN0dOi6Wbp4OxwqxmP2BBl", Name = "VL_Stride_Runtime_TypeForwardsApplication_JN0dOi6Wbp4OxwqxmP2BBl")]
    [n2.SerializableAttribute]
    public class VL_Stride_Runtime_TypeForwardsApplication_JN0dOi6Wbp4OxwqxmP2BBl : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n24.VL_Stride_Runtime_TypeForwardsApplication_JN0dOi6Wbp4OxwqxmP2BBl Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_Stride_Runtime_TypeForwardsApplication_JN0dOi6Wbp4OxwqxmP2BBl(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n24.VL_Stride_Runtime_TypeForwardsApplication_JN0dOi6Wbp4OxwqxmP2BBl CreateDefault()
        {
            var instance = new VL_Stride_Runtime_TypeForwardsApplication_JN0dOi6Wbp4OxwqxmP2BBl(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n24.VL_Stride_Runtime_TypeForwardsApplication_JN0dOi6Wbp4OxwqxmP2BBl Update()
        {
            return this;
        }

        public n24.VL_Stride_Runtime_TypeForwardsApplication_JN0dOi6Wbp4OxwqxmP2BBl __Create__(n1.NodeContext Node_Context)
        {
            n6.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n24.VL_Stride_Runtime_TypeForwardsApplication_JN0dOi6Wbp4OxwqxmP2BBl __CreateDefault__()
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

        public VL_Stride_Runtime_TypeForwardsApplication_JN0dOi6Wbp4OxwqxmP2BBl(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_Stride_Runtime_TypeForwardsApplication_JN0dOi6Wbp4OxwqxmP2BBl(VL_Stride_Runtime_TypeForwardsApplication_JN0dOi6Wbp4OxwqxmP2BBl other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n7.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_Stride_Runtime_TypeForwardsApplication_JN0dOi6Wbp4OxwqxmP2BBl __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Stride_Runtime_TypeForwards_
{
    public struct __AdaptiveImplementations__TiJxb2oN2LtNWRy2MbJV6Q
    {
    }
}