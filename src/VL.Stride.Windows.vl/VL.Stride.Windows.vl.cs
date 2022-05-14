extern alias e27;
extern alias e18;
extern alias e26;
extern alias e56;
extern alias e2;
extern alias e40;
extern alias e5;
extern alias e1;
extern alias e20;

using n18 = _VL_Stride_Rendering_.Stride.Rendering;
using n21 = _VL_Skia_.Graphics.Skia;
using n3 = _VL_Stride_Windows_.Stride.Rendering;
using n24 = _VL_Stride_Windows_.Stride;
using n23 = e2::VL.Lib.Mathematics;
using n20 = _VL_Skia_.Graphics.Skia.Layers;
using n27 = e40::VL.Stride.Rendering;
using n12 = e27::Stride.Graphics;
using n14 = e2::VL.Lib.Primitive.Object;
using n4 = e5::VL.Core.CompilerServices;
using n22 = _VL_Skia_.Graphics.Skia.Paint;
using n10 = global::System.Collections.Generic;
using n15 = global::SkiaSharp;
using n11 = _VL_Stride_Windows_.Stride.Textures.Source;
using n13 = e1::Stride.Core.Mathematics;
using n17 = e2::VL.Lib.Primitive.CacheRegion;
using n7 = e26::Stride.Rendering;
using n1 = e5::VL.Core;
using n16 = e20::Stride.Graphics;
using n2 = global::System;
using n9 = _VL_Skia_.Graphics.Skia.Transform;
using n19 = _VL_Stride_Rendering_.Stride.Textures;
using n5 = e56::VL.Stride.Windows;
using n28 = _VL_Stride_Engine_.Stride;
using n8 = global::System.Runtime.CompilerServices;
using n6 = e18::VL.Skia;
using n25 = e5::VL.Lib.Collections;
using n26 = _VL_Collections_.Collections.Spread;

namespace _VL_Stride_Windows_.Stride.Rendering
{
    [n1.ElementAttribute(TracingId = 96U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "POSaPE5Tv7ON6Pep1InAoI", Name = "SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI")]
    [n2.SerializableAttribute]
    public class SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI Create(n1.NodeContext Node_Context)
        {
            var instance = new SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI CreateDefault()
        {
            var instance = new SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI Update(n6.ILayer Input_In, [n4.SerializedDefaultValueAttribute("Normalized", false)] n6.CommonSpace Space_In, out n7.IGraphicsRendererBase Output_Out)
        {
            n5.SkiaRenderer __auto_0 = this.Instance;
            var State_Output_2 = this.__p_NoCBzrzRCfuMZ3qPTWqdif.Update(Input_In: Input_In, Space_In: Space_In, Output_Out: out n6.ILayer Output_1);
            __auto_0.Layer = Output_1;
            n7.IGraphicsRendererBase Output_Out_3 = (n7.IGraphicsRendererBase)__auto_0;
            Output_Out = Output_Out_3;
            n3.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = State_Output_2 != this.__p_NoCBzrzRCfuMZ3qPTWqdif ? new SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI(this)
                {__p_NoCBzrzRCfuMZ3qPTWqdif = State_Output_2} : that_4;
            else
            {
                this.__p_NoCBzrzRCfuMZ3qPTWqdif = State_Output_2;
            }

            return that_4;
        }

        public n3.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n5.SkiaRenderer();
            n5.SkiaRenderer __auto_1 = Output_0;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "NoCBzrzRCfuMZ3qPTWqdif", 110U);
            var Output_3 = n9.WithinCommonSpace_DSW6lVxTq3xLoRd5BCbhOD.Create(Node_Context: Node_Context_2);
            n3.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI that_4 = this;
            this.Instance = Output_0;
            this.__p_NoCBzrzRCfuMZ3qPTWqdif = Output_3;
            return that_4;
        }

        public n3.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI __CreateDefault__()
        {
            n3.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI that_0 = this;
            this.Instance = default(n5.SkiaRenderer);
            this.__p_NoCBzrzRCfuMZ3qPTWqdif = n9.WithinCommonSpace_DSW6lVxTq3xLoRd5BCbhOD.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_NoCBzrzRCfuMZ3qPTWqdif);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 106U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "FpIo8wiqr9KPV9FcC4ZgGS", Name = "Instance")]
        public n5.SkiaRenderer Instance;
        [n1.ElementAttribute(TracingId = 110U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "NoCBzrzRCfuMZ3qPTWqdif", Name = "WithinCommonSpace", IsManaged = true, IsAutoGenerated = true)]
        public n9.WithinCommonSpace_DSW6lVxTq3xLoRd5BCbhOD __p_NoCBzrzRCfuMZ3qPTWqdif;
        public SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI(SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI other): base(other)
        {
            this.Instance = other.Instance;
            this.__p_NoCBzrzRCfuMZ3qPTWqdif = other.__p_NoCBzrzRCfuMZ3qPTWqdif;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Instance", in Instance), n1.CompilationHelper.GetValueOrExisting(values, "__p_NoCBzrzRCfuMZ3qPTWqdif", in __p_NoCBzrzRCfuMZ3qPTWqdif));
        }

        internal SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI __WITH__(n5.SkiaRenderer Instance, n9.WithinCommonSpace_DSW6lVxTq3xLoRd5BCbhOD __p_NoCBzrzRCfuMZ3qPTWqdif)
        {
            n3.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Instance != this.Instance || __p_NoCBzrzRCfuMZ3qPTWqdif != this.__p_NoCBzrzRCfuMZ3qPTWqdif ? new SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI(this)
                {Instance = Instance, __p_NoCBzrzRCfuMZ3qPTWqdif = __p_NoCBzrzRCfuMZ3qPTWqdif} : that_0;
            else
            {
                this.Instance = Instance;
                this.__p_NoCBzrzRCfuMZ3qPTWqdif = __p_NoCBzrzRCfuMZ3qPTWqdif;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 131U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "QPinH2kdJ21LstCls82xZe", Name = "AsSharedTexture_QPinH2kdJ21LstCls82xZe")]
    [n2.SerializableAttribute]
    public class AsSharedTexture_QPinH2kdJ21LstCls82xZe : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.AsSharedTexture_QPinH2kdJ21LstCls82xZe Create(n1.NodeContext Node_Context)
        {
            var instance = new AsSharedTexture_QPinH2kdJ21LstCls82xZe(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.AsSharedTexture_QPinH2kdJ21LstCls82xZe CreateDefault()
        {
            var instance = new AsSharedTexture_QPinH2kdJ21LstCls82xZe(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.AsSharedTexture_QPinH2kdJ21LstCls82xZe Update(n12.Texture Input_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Auto_Render_In, out n18.CopyTextureRenderer_C Renderer_Out, out n12.Texture Output_Out, out long Shared_Handle_Out)
        {
            n12.GraphicsResourceUsage __pad_D1vYWkDsuXnP2WvyjhHfEx_0 = __slot_D1vYWkDsuXnP2WvyjhHfEx;
            n12.TextureOptions __pad_P3cnnWp1IgGPa7wG1cPhyx_1 = __slot_P3cnnWp1IgGPa7wG1cPhyx;
            long __pad_Lbl8w2dWh7WPdjTRdq0KZg_2 = __slot_Lbl8w2dWh7WPdjTRdq0KZg;
            n14.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_3, notAssigned: out bool Not_Assigned_4);
            n12.TextureOptions __auto_5;
            n12.GraphicsResourceUsage __auto_6;
            if (Result_3)
            {
                var Options_8 = Input_In.Options;
                __auto_5 = Options_8;
                var Usage_9 = Input_In.Usage;
                __auto_6 = Usage_9;
            }
            else
            {
                __auto_5 = default(n12.TextureOptions);
                __auto_6 = default(n12.GraphicsResourceUsage);
            }

            var Result_10 = __auto_5 != __pad_P3cnnWp1IgGPa7wG1cPhyx_1;
            var Result_11 = __auto_6 == __pad_D1vYWkDsuXnP2WvyjhHfEx_0;
            n18.CopyTextureRenderer_C __auto_12;
            n12.Texture __auto_13;
            var state_14 = n1.CompilationHelper.Restore<__Fzd6vRwxX9TPg3Ta7ql2DK>(this.__if_DHHsQyDAXYkOWTIwUmz3vR, __GetContext__());
            if (Result_10)
            {
                if (state_14 == null)
                {
                    state_14 = new __Fzd6vRwxX9TPg3Ta7ql2DK(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "BxmwWENFVJcMHMuFDY9GXS", 167U);
                    var Output_16 = n19.CopyTexture_UGdw4Tvemx5QK60AS7AHcT.Create(Node_Context: Node_Context_15);
                    state_14.__p_BxmwWENFVJcMHMuFDY9GXS = Output_16;
                }

                bool __pad_ELmTaRTAT1QOEGTMFAYKU5_17 = __slot_ELmTaRTAT1QOEGTMFAYKU5;
                var Output_18 = !Result_11;
                var Output_19 = Auto_Render_In && Output_18;
                n16.PixelFormat Format_20 = default(n16.PixelFormat);
                n12.TextureFlags Flags_21 = default(n12.TextureFlags);
                bool Dispose_Cached_Texture_22 = true;
                var State_Output_25 = state_14.__p_BxmwWENFVJcMHMuFDY9GXS.Update(Input_In: Input_In, Copy_Content_On_Clone_In: Result_11, Format_In: Format_20, Flags_In: Flags_21, Dispose_Cached_Texture_In: Dispose_Cached_Texture_22, To_Shared_Texture_In: __pad_ELmTaRTAT1QOEGTMFAYKU5_17, Auto_Render_In: Output_19, Renderer_Out: out n18.CopyTextureRenderer_C Renderer_23, Output_Out: out n12.Texture Output_24);
                __auto_13 = Output_24;
                __auto_12 = Renderer_23;
                if (state_14.__GetContext__().IsImmutable)
                    state_14 = State_Output_25 != state_14.__p_BxmwWENFVJcMHMuFDY9GXS ? new __Fzd6vRwxX9TPg3Ta7ql2DK(state_14)
                    {__p_BxmwWENFVJcMHMuFDY9GXS = State_Output_25} : state_14;
                else
                {
                    state_14.__p_BxmwWENFVJcMHMuFDY9GXS = State_Output_25;
                }
            }
            else
            {
                __auto_12 = n18.CopyTextureRenderer_C.CreateDefault();
                __auto_13 = Input_In;
            }

            n14.ObjectHelpers.IsAssigned(x: __auto_13, result: out bool Result_26, notAssigned: out bool Not_Assigned_27);
            long __auto_28;
            if (Result_26)
            {
                var Shared_Handle_30 = __auto_13.SharedHandle;
                var Result_31 = Shared_Handle_30.ToInt64();
                __auto_28 = Result_31;
            }
            else
            {
                __auto_28 = __pad_Lbl8w2dWh7WPdjTRdq0KZg_2;
            }

            Renderer_Out = __auto_12;
            Output_Out = __auto_13;
            Shared_Handle_Out = __auto_28;
            n3.AsSharedTexture_QPinH2kdJ21LstCls82xZe that_32 = this;
            if (this.__GetContext__().IsImmutable)
                that_32 = state_14 != this.__if_DHHsQyDAXYkOWTIwUmz3vR ? new AsSharedTexture_QPinH2kdJ21LstCls82xZe(this)
                {__if_DHHsQyDAXYkOWTIwUmz3vR = state_14} : that_32;
            else
            {
                this.__if_DHHsQyDAXYkOWTIwUmz3vR = state_14;
            }

            return that_32;
        }

        public n3.AsSharedTexture_QPinH2kdJ21LstCls82xZe __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.AsSharedTexture_QPinH2kdJ21LstCls82xZe that_0 = this;
            this.__if_DHHsQyDAXYkOWTIwUmz3vR = default(n2.Object);
            return that_0;
        }

        public n3.AsSharedTexture_QPinH2kdJ21LstCls82xZe __CreateDefault__()
        {
            n3.AsSharedTexture_QPinH2kdJ21LstCls82xZe that_0 = this;
            this.__if_DHHsQyDAXYkOWTIwUmz3vR = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_DHHsQyDAXYkOWTIwUmz3vR);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 156U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "Lbl8w2dWh7WPdjTRdq0KZg", Name = "__slot_Lbl8w2dWh7WPdjTRdq0KZg")]
        public static long __slot_Lbl8w2dWh7WPdjTRdq0KZg = -1L;
        [n1.ElementAttribute(TracingId = 209U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "P3cnnWp1IgGPa7wG1cPhyx", Name = "__slot_P3cnnWp1IgGPa7wG1cPhyx")]
        public static n12.TextureOptions __slot_P3cnnWp1IgGPa7wG1cPhyx = n1.CompilationHelper.Deserialize<n12.TextureOptions>("Shared", false, "Qi7h0S2HFoXQSgcrQLzJIk", "P3cnnWp1IgGPa7wG1cPhyx");
        [n1.ElementAttribute(TracingId = 214U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "D1vYWkDsuXnP2WvyjhHfEx", Name = "__slot_D1vYWkDsuXnP2WvyjhHfEx")]
        public static n12.GraphicsResourceUsage __slot_D1vYWkDsuXnP2WvyjhHfEx = n1.CompilationHelper.Deserialize<n12.GraphicsResourceUsage>("Immutable", false, "Qi7h0S2HFoXQSgcrQLzJIk", "D1vYWkDsuXnP2WvyjhHfEx");
        [n1.ElementAttribute(TracingId = 176U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "ELmTaRTAT1QOEGTMFAYKU5", Name = "__slot_ELmTaRTAT1QOEGTMFAYKU5")]
        public static bool __slot_ELmTaRTAT1QOEGTMFAYKU5 = true;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_DHHsQyDAXYkOWTIwUmz3vR;
        static AsSharedTexture_QPinH2kdJ21LstCls82xZe()
        {
        }

        public AsSharedTexture_QPinH2kdJ21LstCls82xZe(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal AsSharedTexture_QPinH2kdJ21LstCls82xZe(AsSharedTexture_QPinH2kdJ21LstCls82xZe other): base(other)
        {
            this.__if_DHHsQyDAXYkOWTIwUmz3vR = other.__if_DHHsQyDAXYkOWTIwUmz3vR;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_DHHsQyDAXYkOWTIwUmz3vR", in __if_DHHsQyDAXYkOWTIwUmz3vR));
        }

        internal AsSharedTexture_QPinH2kdJ21LstCls82xZe __WITH__(n2.Object __if_DHHsQyDAXYkOWTIwUmz3vR)
        {
            n3.AsSharedTexture_QPinH2kdJ21LstCls82xZe that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_DHHsQyDAXYkOWTIwUmz3vR != this.__if_DHHsQyDAXYkOWTIwUmz3vR ? new AsSharedTexture_QPinH2kdJ21LstCls82xZe(this)
                {__if_DHHsQyDAXYkOWTIwUmz3vR = __if_DHHsQyDAXYkOWTIwUmz3vR} : that_0;
            else
            {
                this.__if_DHHsQyDAXYkOWTIwUmz3vR = __if_DHHsQyDAXYkOWTIwUmz3vR;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "Fzd6vRwxX9TPg3Ta7ql2DK", Name = "__Fzd6vRwxX9TPg3Ta7ql2DK")]
        [n2.SerializableAttribute]
        public class __Fzd6vRwxX9TPg3Ta7ql2DK : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_BxmwWENFVJcMHMuFDY9GXS);
                return;
            }

            [n1.ElementAttribute(TracingId = 167U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "BxmwWENFVJcMHMuFDY9GXS", Name = "CopyTexture", IsManaged = true, IsAutoGenerated = true)]
            public n19.CopyTexture_UGdw4Tvemx5QK60AS7AHcT __p_BxmwWENFVJcMHMuFDY9GXS;
            public __Fzd6vRwxX9TPg3Ta7ql2DK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Fzd6vRwxX9TPg3Ta7ql2DK(__Fzd6vRwxX9TPg3Ta7ql2DK other): base(other)
            {
                this.__p_BxmwWENFVJcMHMuFDY9GXS = other.__p_BxmwWENFVJcMHMuFDY9GXS;
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_BxmwWENFVJcMHMuFDY9GXS", in __p_BxmwWENFVJcMHMuFDY9GXS));
            }

            internal __Fzd6vRwxX9TPg3Ta7ql2DK __WITH__(n19.CopyTexture_UGdw4Tvemx5QK60AS7AHcT __p_BxmwWENFVJcMHMuFDY9GXS)
            {
                __Fzd6vRwxX9TPg3Ta7ql2DK that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_BxmwWENFVJcMHMuFDY9GXS != this.__p_BxmwWENFVJcMHMuFDY9GXS ? new __Fzd6vRwxX9TPg3Ta7ql2DK(this)
                    {__p_BxmwWENFVJcMHMuFDY9GXS = __p_BxmwWENFVJcMHMuFDY9GXS} : that_0;
                else
                {
                    this.__p_BxmwWENFVJcMHMuFDY9GXS = __p_BxmwWENFVJcMHMuFDY9GXS;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Stride_Windows_.Stride.Textures.Source
{
    [n1.ElementAttribute(TracingId = 267U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "R51yPqjFZmpPw6aX2G3LE0", Name = "Rectangle_R51yPqjFZmpPw6aX2G3LE0")]
    [n2.SerializableAttribute]
    public class Rectangle_R51yPqjFZmpPw6aX2G3LE0 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n11.Rectangle_R51yPqjFZmpPw6aX2G3LE0 Create(n1.NodeContext Node_Context)
        {
            var instance = new Rectangle_R51yPqjFZmpPw6aX2G3LE0(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n11.Rectangle_R51yPqjFZmpPw6aX2G3LE0 CreateDefault()
        {
            var instance = new Rectangle_R51yPqjFZmpPw6aX2G3LE0(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.Rectangle_R51yPqjFZmpPw6aX2G3LE0 Update(n13.Vector2 Position_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n13.Vector2 Size_In, n13.Vector2 Corner_Radius_In, n13.Matrix Transformation_In, [n4.SerializedDefaultValueAttribute("0, 0, 0, 1", false)] n13.Color4 Background_Color_In, n13.Color4 Fill_Color_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Fill_Enabled_In, n13.Color4 Stroke_Color_In, [n4.SerializedDefaultValueAttribute("0.02", false)] float Stroke_Width_In, n15.SKStrokeJoin Stroke_Join_In, [n4.SerializedDefaultValueAttribute("1.5", false)] float Stroke_Miter_In, n13.Vector2 Stroke_Offset_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Stroke_Enabled_In, [n4.SerializedDefaultValueAttribute("512, 512", false)] n13.Int2 Output_Size_In, [n4.SerializedDefaultValueAttribute("R8G8B8A8_UNorm_SRgb", false)] n16.PixelFormat Output_Format_In, out n12.Texture Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_T1yXrkxlTqjO2BIGxAW6vv;
            if (manager_2 is null)
            {
                manager_2 = new n17.Manager<n2.ValueTuple<n13.Vector2, n13.Vector2, n13.Vector2, n13.Color4, bool, n13.Color4, float, n2.ValueTuple<n15.SKStrokeJoin, float, bool, n13.Matrix, n13.Int2, n13.Color4, n16.PixelFormat>>, n2.ValueTuple<n12.Texture>>(n2.ValueTuple.Create(default(n12.Texture)));
            }

            var inputs_3 = (Position_In, Size_In, Corner_Radius_In, Fill_Color_In, Fill_Enabled_In, Stroke_Color_In, Stroke_Width_In, Stroke_Join_In, Stroke_Miter_In, Stroke_Enabled_In, Transformation_In, Output_Size_In, Background_Color_In, Output_Format_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__DkQor3yem0IMs1KAjcxqUH>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __DkQor3yem0IMs1KAjcxqUH(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_NKykEWs3DxQOQb59Tap13W = n26._Operations_.CreateDefault<n6.ILayer>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "J27BsA2qt54PVI34krFRiP", 293U);
                    var Output_8 = n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa.Create(Node_Context: Node_Context_7);
                    state_6.__p_J27BsA2qt54PVI34krFRiP = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "BTwtrielIzVNG26xjjUvat", 301U);
                    var Output_10 = n20.RoundRectangle_ORIzah5ECIFPO6Z983qw5x.Create(Node_Context: Node_Context_9);
                    state_6.__p_BTwtrielIzVNG26xjjUvat = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "NKykEWs3DxQOQb59Tap13W", 309U);
                    var Output_12 = n21.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_11);
                    state_6.__p_NKykEWs3DxQOQb59Tap13W = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "MkNP3kKURd5QBxyBRnHNNX", 315U);
                    var Output_14 = n20.RoundRectangle_ORIzah5ECIFPO6Z983qw5x.Create(Node_Context: Node_Context_13);
                    state_6.__p_MkNP3kKURd5QBxyBRnHNNX = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "LeHhcuoepBUOy4XUiQxOjs", 323U);
                    var Output_16 = n22.Stroke_ApdGyamrLDXOTiJpdyhyN9.Create(Node_Context: Node_Context_15);
                    state_6.__p_LeHhcuoepBUOy4XUiQxOjs = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "EJmh889Wqa0O2QelrtzbJn", 331U);
                    var Output_18 = n22.Fill_UsNlhFP5Z8VOaaHSrZXiyC.Create(Node_Context: Node_Context_17);
                    state_6.__p_EJmh889Wqa0O2QelrtzbJn = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "DOJrlcAOfUdP5MgP9RS6DS", 336U);
                    var Output_20 = n9.Transform_FwX2Jt8yhtVOKxyXSTS8pk.Create(Node_Context: Node_Context_19);
                    state_6.__p_DOJrlcAOfUdP5MgP9RS6DS = Output_20;
                }

                n21.SkiaPaint_R Input_21 = n21.SkiaPaint_R.CreateDefault();
                n15.SKShader Shader_22 = default(n15.SKShader);
                var State_Output_24 = state_6.__p_EJmh889Wqa0O2QelrtzbJn.Update(Input_In: Input_21, Color_In: Fill_Color_In, Shader_In: Shader_22, Output_Out: out n21.SkiaPaint_R Output_23);
                n23.RectangleAnchor Anchor_25 = __c_CYUflpBdlDzQUHRqIszt2X;
                var State_Output_27 = state_6.__p_BTwtrielIzVNG26xjjUvat.Update(Position_In: Position_In, Size_In: Size_In, Radius_In: Corner_Radius_In, Anchor_In: Anchor_25, Paint_In: Output_23, Enabled_In: Fill_Enabled_In, Output_Out: out n6.ILayer Output_26);
                n13.Vector2.Add(left: ref Size_In, right: ref Stroke_Offset_In, result: out n13.Vector2 Output_28);
                n21.SkiaPaint_R Input_29 = n21.SkiaPaint_R.CreateDefault();
                n15.SKStrokeCap Cap_30 = __c_ONRfn6xlNyPOlp5RJNyeAp;
                var State_Output_32 = state_6.__p_LeHhcuoepBUOy4XUiQxOjs.Update(Input_In: Input_29, Color_In: Stroke_Color_In, Stroke_Width_In: Stroke_Width_In, Join_In: Stroke_Join_In, Cap_In: Cap_30, Miter_In: Stroke_Miter_In, Output_Out: out n21.SkiaPaint_R Output_31);
                n23.RectangleAnchor Anchor_33 = __c_OAjWHVpQoWdNmpavY9ezvc;
                var State_Output_35 = state_6.__p_MkNP3kKURd5QBxyBRnHNNX.Update(Position_In: Position_In, Size_In: Output_28, Radius_In: Corner_Radius_In, Anchor_In: Anchor_33, Paint_In: Output_31, Enabled_In: Stroke_Enabled_In, Output_Out: out n6.ILayer Output_34);
                bool Debug_36 = false;
                bool Enabled_37 = true;
                var builder_38 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_NKykEWs3DxQOQb59Tap13W, 2);
                builder_38.Add(Output_26);
                builder_38.Add(Output_34);
                var __pin_group_Input_In_NKykEWs3DxQOQb59Tap13W_39 = builder_38.Commit();
                var State_Output_41 = state_6.__p_NKykEWs3DxQOQb59Tap13W.Update(Input_In: __pin_group_Input_In_NKykEWs3DxQOQb59Tap13W_39, Debug_In: Debug_36, Enabled_In: Enabled_37, Output_Out: out n6.ILayer Output_40);
                var State_Output_43 = state_6.__p_DOJrlcAOfUdP5MgP9RS6DS.Update(Input_In: Output_40, Transformation_In: Transformation_In, Output_Out: out n6.ILayer Output_42);
                n6.CommonSpace Space_44 = __c_UgpuHvx9MIiNEw9grPXFCD;
                bool Clear_45 = true;
                var State_Output_47 = state_6.__p_J27BsA2qt54PVI34krFRiP.Update(Input_In: Output_42, Size_In: Output_Size_In, Space_In: Space_44, Clear_In: Clear_45, Clear_Color_In: Background_Color_In, Format_In: Output_Format_In, Output_Out: out n12.Texture Output_46);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_24 != state_6.__p_EJmh889Wqa0O2QelrtzbJn || State_Output_27 != state_6.__p_BTwtrielIzVNG26xjjUvat || State_Output_32 != state_6.__p_LeHhcuoepBUOy4XUiQxOjs || State_Output_35 != state_6.__p_MkNP3kKURd5QBxyBRnHNNX || __pin_group_Input_In_NKykEWs3DxQOQb59Tap13W_39 != state_6.__pin_group_Input_In_NKykEWs3DxQOQb59Tap13W || State_Output_41 != state_6.__p_NKykEWs3DxQOQb59Tap13W || State_Output_43 != state_6.__p_DOJrlcAOfUdP5MgP9RS6DS || State_Output_47 != state_6.__p_J27BsA2qt54PVI34krFRiP ? new __DkQor3yem0IMs1KAjcxqUH(state_6)
                    {__p_EJmh889Wqa0O2QelrtzbJn = State_Output_24, __p_BTwtrielIzVNG26xjjUvat = State_Output_27, __p_LeHhcuoepBUOy4XUiQxOjs = State_Output_32, __p_MkNP3kKURd5QBxyBRnHNNX = State_Output_35, __pin_group_Input_In_NKykEWs3DxQOQb59Tap13W = __pin_group_Input_In_NKykEWs3DxQOQb59Tap13W_39, __p_NKykEWs3DxQOQb59Tap13W = State_Output_41, __p_DOJrlcAOfUdP5MgP9RS6DS = State_Output_43, __p_J27BsA2qt54PVI34krFRiP = State_Output_47} : state_6;
                else
                {
                    state_6.__p_EJmh889Wqa0O2QelrtzbJn = State_Output_24;
                    state_6.__p_BTwtrielIzVNG26xjjUvat = State_Output_27;
                    state_6.__p_LeHhcuoepBUOy4XUiQxOjs = State_Output_32;
                    state_6.__p_MkNP3kKURd5QBxyBRnHNNX = State_Output_35;
                    state_6.__pin_group_Input_In_NKykEWs3DxQOQb59Tap13W = __pin_group_Input_In_NKykEWs3DxQOQb59Tap13W_39;
                    state_6.__p_NKykEWs3DxQOQb59Tap13W = State_Output_41;
                    state_6.__p_DOJrlcAOfUdP5MgP9RS6DS = State_Output_43;
                    state_6.__p_J27BsA2qt54PVI34krFRiP = State_Output_47;
                }

                outputs_4 = n2.ValueTuple.Create(Output_46);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_48 = outputs_4.Item1;
            Output_Out = __auto_48;
            n11.Rectangle_R51yPqjFZmpPw6aX2G3LE0 that_49 = this;
            if (this.__GetContext__().IsImmutable)
                that_49 = manager_2 != this.__cache_T1yXrkxlTqjO2BIGxAW6vv ? new Rectangle_R51yPqjFZmpPw6aX2G3LE0(this)
                {__cache_T1yXrkxlTqjO2BIGxAW6vv = manager_2} : that_49;
            else
            {
                this.__cache_T1yXrkxlTqjO2BIGxAW6vv = manager_2;
            }

            return that_49;
        }

        public n11.Rectangle_R51yPqjFZmpPw6aX2G3LE0 __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n11.Rectangle_R51yPqjFZmpPw6aX2G3LE0 that_0 = this;
            this.__cache_T1yXrkxlTqjO2BIGxAW6vv = null;
            return that_0;
        }

        public n11.Rectangle_R51yPqjFZmpPw6aX2G3LE0 __CreateDefault__()
        {
            n11.Rectangle_R51yPqjFZmpPw6aX2G3LE0 that_0 = this;
            this.__cache_T1yXrkxlTqjO2BIGxAW6vv = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_T1yXrkxlTqjO2BIGxAW6vv);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 286U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "T1yXrkxlTqjO2BIGxAW6vv", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n17.Manager<n2.ValueTuple<n13.Vector2, n13.Vector2, n13.Vector2, n13.Color4, bool, n13.Color4, float, n2.ValueTuple<n15.SKStrokeJoin, float, bool, n13.Matrix, n13.Int2, n13.Color4, n16.PixelFormat>>, n2.ValueTuple<n12.Texture>> __cache_T1yXrkxlTqjO2BIGxAW6vv = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n23.RectangleAnchor __c_CYUflpBdlDzQUHRqIszt2X = n1.CompilationHelper.Deserialize<n23.RectangleAnchor>("Center", false, "Qi7h0S2HFoXQSgcrQLzJIk", "CYUflpBdlDzQUHRqIszt2X");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n15.SKStrokeCap __c_ONRfn6xlNyPOlp5RJNyeAp = n1.CompilationHelper.Deserialize<n15.SKStrokeCap>("Butt", false, "Qi7h0S2HFoXQSgcrQLzJIk", "ONRfn6xlNyPOlp5RJNyeAp");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n23.RectangleAnchor __c_OAjWHVpQoWdNmpavY9ezvc = n1.CompilationHelper.Deserialize<n23.RectangleAnchor>("Center", false, "Qi7h0S2HFoXQSgcrQLzJIk", "OAjWHVpQoWdNmpavY9ezvc");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.CommonSpace __c_UgpuHvx9MIiNEw9grPXFCD = n1.CompilationHelper.Deserialize<n6.CommonSpace>("Normalized", false, "Qi7h0S2HFoXQSgcrQLzJIk", "UgpuHvx9MIiNEw9grPXFCD");
        static Rectangle_R51yPqjFZmpPw6aX2G3LE0()
        {
        }

        public Rectangle_R51yPqjFZmpPw6aX2G3LE0(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Rectangle_R51yPqjFZmpPw6aX2G3LE0(Rectangle_R51yPqjFZmpPw6aX2G3LE0 other): base(other)
        {
            this.__cache_T1yXrkxlTqjO2BIGxAW6vv = other.__cache_T1yXrkxlTqjO2BIGxAW6vv;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_T1yXrkxlTqjO2BIGxAW6vv", in __cache_T1yXrkxlTqjO2BIGxAW6vv));
        }

        internal Rectangle_R51yPqjFZmpPw6aX2G3LE0 __WITH__(n17.Manager<n2.ValueTuple<n13.Vector2, n13.Vector2, n13.Vector2, n13.Color4, bool, n13.Color4, float, n2.ValueTuple<n15.SKStrokeJoin, float, bool, n13.Matrix, n13.Int2, n13.Color4, n16.PixelFormat>>, n2.ValueTuple<n12.Texture>> __cache_T1yXrkxlTqjO2BIGxAW6vv)
        {
            n11.Rectangle_R51yPqjFZmpPw6aX2G3LE0 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_T1yXrkxlTqjO2BIGxAW6vv != this.__cache_T1yXrkxlTqjO2BIGxAW6vv ? new Rectangle_R51yPqjFZmpPw6aX2G3LE0(this)
                {__cache_T1yXrkxlTqjO2BIGxAW6vv = __cache_T1yXrkxlTqjO2BIGxAW6vv} : that_0;
            else
            {
                this.__cache_T1yXrkxlTqjO2BIGxAW6vv = __cache_T1yXrkxlTqjO2BIGxAW6vv;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "DkQor3yem0IMs1KAjcxqUH", Name = "__DkQor3yem0IMs1KAjcxqUH")]
        [n2.SerializableAttribute]
        public class __DkQor3yem0IMs1KAjcxqUH : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_J27BsA2qt54PVI34krFRiP);
                n1.CompilationHelper.SafeDispose(this.__p_BTwtrielIzVNG26xjjUvat);
                n1.CompilationHelper.SafeDispose(this.__p_NKykEWs3DxQOQb59Tap13W);
                n1.CompilationHelper.SafeDispose(this.__p_MkNP3kKURd5QBxyBRnHNNX);
                n1.CompilationHelper.SafeDispose(this.__p_LeHhcuoepBUOy4XUiQxOjs);
                n1.CompilationHelper.SafeDispose(this.__p_EJmh889Wqa0O2QelrtzbJn);
                n1.CompilationHelper.SafeDispose(this.__p_DOJrlcAOfUdP5MgP9RS6DS);
                return;
            }

            [n1.ElementAttribute(TracingId = 293U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "J27BsA2qt54PVI34krFRiP", Name = "SkiaTexture", IsManaged = true, IsAutoGenerated = true)]
            public n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa __p_J27BsA2qt54PVI34krFRiP;
            [n1.ElementAttribute(TracingId = 301U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "BTwtrielIzVNG26xjjUvat", Name = "RoundRectangle", IsManaged = true, IsAutoGenerated = true)]
            public n20.RoundRectangle_ORIzah5ECIFPO6Z983qw5x __p_BTwtrielIzVNG26xjjUvat;
            [n1.ElementAttribute(TracingId = 309U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "NKykEWs3DxQOQb59Tap13W", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n21.Group_TKtMtIW1WMIOfh4AlYkjTy __p_NKykEWs3DxQOQb59Tap13W;
            [n1.ElementAttribute(TracingId = 315U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "MkNP3kKURd5QBxyBRnHNNX", Name = "RoundRectangle", IsManaged = true, IsAutoGenerated = true)]
            public n20.RoundRectangle_ORIzah5ECIFPO6Z983qw5x __p_MkNP3kKURd5QBxyBRnHNNX;
            [n1.ElementAttribute(TracingId = 323U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "LeHhcuoepBUOy4XUiQxOjs", Name = "Stroke", IsManaged = true, IsAutoGenerated = true)]
            public n22.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_LeHhcuoepBUOy4XUiQxOjs;
            [n1.ElementAttribute(TracingId = 331U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "EJmh889Wqa0O2QelrtzbJn", Name = "Fill", IsManaged = true, IsAutoGenerated = true)]
            public n22.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_EJmh889Wqa0O2QelrtzbJn;
            [n1.ElementAttribute(TracingId = 336U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "DOJrlcAOfUdP5MgP9RS6DS", Name = "Transform", IsManaged = true, IsAutoGenerated = true)]
            public n9.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_DOJrlcAOfUdP5MgP9RS6DS;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n25.Spread<n6.ILayer> __pin_group_Input_In_NKykEWs3DxQOQb59Tap13W = default(n25.Spread<n6.ILayer>);
            public __DkQor3yem0IMs1KAjcxqUH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __DkQor3yem0IMs1KAjcxqUH(__DkQor3yem0IMs1KAjcxqUH other): base(other)
            {
                this.__p_J27BsA2qt54PVI34krFRiP = other.__p_J27BsA2qt54PVI34krFRiP;
                this.__p_BTwtrielIzVNG26xjjUvat = other.__p_BTwtrielIzVNG26xjjUvat;
                this.__p_NKykEWs3DxQOQb59Tap13W = other.__p_NKykEWs3DxQOQb59Tap13W;
                this.__p_MkNP3kKURd5QBxyBRnHNNX = other.__p_MkNP3kKURd5QBxyBRnHNNX;
                this.__p_LeHhcuoepBUOy4XUiQxOjs = other.__p_LeHhcuoepBUOy4XUiQxOjs;
                this.__p_EJmh889Wqa0O2QelrtzbJn = other.__p_EJmh889Wqa0O2QelrtzbJn;
                this.__p_DOJrlcAOfUdP5MgP9RS6DS = other.__p_DOJrlcAOfUdP5MgP9RS6DS;
                this.__pin_group_Input_In_NKykEWs3DxQOQb59Tap13W = other.__pin_group_Input_In_NKykEWs3DxQOQb59Tap13W;
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_J27BsA2qt54PVI34krFRiP", in __p_J27BsA2qt54PVI34krFRiP), n1.CompilationHelper.GetValueOrExisting(values, "__p_BTwtrielIzVNG26xjjUvat", in __p_BTwtrielIzVNG26xjjUvat), n1.CompilationHelper.GetValueOrExisting(values, "__p_NKykEWs3DxQOQb59Tap13W", in __p_NKykEWs3DxQOQb59Tap13W), n1.CompilationHelper.GetValueOrExisting(values, "__p_MkNP3kKURd5QBxyBRnHNNX", in __p_MkNP3kKURd5QBxyBRnHNNX), n1.CompilationHelper.GetValueOrExisting(values, "__p_LeHhcuoepBUOy4XUiQxOjs", in __p_LeHhcuoepBUOy4XUiQxOjs), n1.CompilationHelper.GetValueOrExisting(values, "__p_EJmh889Wqa0O2QelrtzbJn", in __p_EJmh889Wqa0O2QelrtzbJn), n1.CompilationHelper.GetValueOrExisting(values, "__p_DOJrlcAOfUdP5MgP9RS6DS", in __p_DOJrlcAOfUdP5MgP9RS6DS), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_NKykEWs3DxQOQb59Tap13W", in __pin_group_Input_In_NKykEWs3DxQOQb59Tap13W));
            }

            internal __DkQor3yem0IMs1KAjcxqUH __WITH__(n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa __p_J27BsA2qt54PVI34krFRiP, n20.RoundRectangle_ORIzah5ECIFPO6Z983qw5x __p_BTwtrielIzVNG26xjjUvat, n21.Group_TKtMtIW1WMIOfh4AlYkjTy __p_NKykEWs3DxQOQb59Tap13W, n20.RoundRectangle_ORIzah5ECIFPO6Z983qw5x __p_MkNP3kKURd5QBxyBRnHNNX, n22.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_LeHhcuoepBUOy4XUiQxOjs, n22.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_EJmh889Wqa0O2QelrtzbJn, n9.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_DOJrlcAOfUdP5MgP9RS6DS, n25.Spread<n6.ILayer> __pin_group_Input_In_NKykEWs3DxQOQb59Tap13W)
            {
                __DkQor3yem0IMs1KAjcxqUH that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_J27BsA2qt54PVI34krFRiP != this.__p_J27BsA2qt54PVI34krFRiP || __p_BTwtrielIzVNG26xjjUvat != this.__p_BTwtrielIzVNG26xjjUvat || __p_NKykEWs3DxQOQb59Tap13W != this.__p_NKykEWs3DxQOQb59Tap13W || __p_MkNP3kKURd5QBxyBRnHNNX != this.__p_MkNP3kKURd5QBxyBRnHNNX || __p_LeHhcuoepBUOy4XUiQxOjs != this.__p_LeHhcuoepBUOy4XUiQxOjs || __p_EJmh889Wqa0O2QelrtzbJn != this.__p_EJmh889Wqa0O2QelrtzbJn || __p_DOJrlcAOfUdP5MgP9RS6DS != this.__p_DOJrlcAOfUdP5MgP9RS6DS || __pin_group_Input_In_NKykEWs3DxQOQb59Tap13W != this.__pin_group_Input_In_NKykEWs3DxQOQb59Tap13W ? new __DkQor3yem0IMs1KAjcxqUH(this)
                    {__p_J27BsA2qt54PVI34krFRiP = __p_J27BsA2qt54PVI34krFRiP, __p_BTwtrielIzVNG26xjjUvat = __p_BTwtrielIzVNG26xjjUvat, __p_NKykEWs3DxQOQb59Tap13W = __p_NKykEWs3DxQOQb59Tap13W, __p_MkNP3kKURd5QBxyBRnHNNX = __p_MkNP3kKURd5QBxyBRnHNNX, __p_LeHhcuoepBUOy4XUiQxOjs = __p_LeHhcuoepBUOy4XUiQxOjs, __p_EJmh889Wqa0O2QelrtzbJn = __p_EJmh889Wqa0O2QelrtzbJn, __p_DOJrlcAOfUdP5MgP9RS6DS = __p_DOJrlcAOfUdP5MgP9RS6DS, __pin_group_Input_In_NKykEWs3DxQOQb59Tap13W = __pin_group_Input_In_NKykEWs3DxQOQb59Tap13W} : that_0;
                else
                {
                    this.__p_J27BsA2qt54PVI34krFRiP = __p_J27BsA2qt54PVI34krFRiP;
                    this.__p_BTwtrielIzVNG26xjjUvat = __p_BTwtrielIzVNG26xjjUvat;
                    this.__p_NKykEWs3DxQOQb59Tap13W = __p_NKykEWs3DxQOQb59Tap13W;
                    this.__p_MkNP3kKURd5QBxyBRnHNNX = __p_MkNP3kKURd5QBxyBRnHNNX;
                    this.__p_LeHhcuoepBUOy4XUiQxOjs = __p_LeHhcuoepBUOy4XUiQxOjs;
                    this.__p_EJmh889Wqa0O2QelrtzbJn = __p_EJmh889Wqa0O2QelrtzbJn;
                    this.__p_DOJrlcAOfUdP5MgP9RS6DS = __p_DOJrlcAOfUdP5MgP9RS6DS;
                    this.__pin_group_Input_In_NKykEWs3DxQOQb59Tap13W = __pin_group_Input_In_NKykEWs3DxQOQb59Tap13W;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 437U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "KZJ9Mw0tv2YQAAENG41G31", Name = "Circle_KZJ9Mw0tv2YQAAENG41G31")]
    [n2.SerializableAttribute]
    public class Circle_KZJ9Mw0tv2YQAAENG41G31 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n11.Circle_KZJ9Mw0tv2YQAAENG41G31 Create(n1.NodeContext Node_Context)
        {
            var instance = new Circle_KZJ9Mw0tv2YQAAENG41G31(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n11.Circle_KZJ9Mw0tv2YQAAENG41G31 CreateDefault()
        {
            var instance = new Circle_KZJ9Mw0tv2YQAAENG41G31(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.Circle_KZJ9Mw0tv2YQAAENG41G31 Update(n13.Vector2 Position_In, [n4.SerializedDefaultValueAttribute("0.5", false)] float Radius_In, n13.Matrix Transformation_In, [n4.SerializedDefaultValueAttribute("0, 0, 0, 1", false)] n13.Color4 Background_Color_In, n13.Color4 Fill_Color_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Fill_Enabled_In, n13.Color4 Stroke_Color_In, [n4.SerializedDefaultValueAttribute("0.02", false)] float Stroke_Width_In, float Stroke_Offset_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Stroke_Enabled_In, [n4.SerializedDefaultValueAttribute("512, 512", false)] n13.Int2 Output_Size_In, [n4.SerializedDefaultValueAttribute("R8G8B8A8_UNorm_SRgb", false)] n16.PixelFormat Output_Format_In, out n12.Texture Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_NC6ocyPm5xLLqMsmS7nNUT;
            if (manager_2 is null)
            {
                manager_2 = new n17.Manager<n2.ValueTuple<n13.Vector2, float, n13.Color4, bool, float, n13.Color4, float, n2.ValueTuple<bool, n13.Matrix, n13.Int2, n13.Color4, n16.PixelFormat>>, n2.ValueTuple<n12.Texture>>(n2.ValueTuple.Create(default(n12.Texture)));
            }

            var inputs_3 = (Position_In, Radius_In, Fill_Color_In, Fill_Enabled_In, Stroke_Offset_In, Stroke_Color_In, Stroke_Width_In, Stroke_Enabled_In, Transformation_In, Output_Size_In, Background_Color_In, Output_Format_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__R9saCXVWumeP7Zyg6LJAZD>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __R9saCXVWumeP7Zyg6LJAZD(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_Vubgu341YesLbVfo9nGGlT = n26._Operations_.CreateDefault<n6.ILayer>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "RNgJ29APs4nN5ll5svWQOG", 460U);
                    var Output_8 = n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa.Create(Node_Context: Node_Context_7);
                    state_6.__p_RNgJ29APs4nN5ll5svWQOG = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "JmITKG2aYldLwfuPmg0url", 468U);
                    var Output_10 = n20.Circle_PkBNwasMVJjOdYsVSPoZ1g.Create(Node_Context: Node_Context_9);
                    state_6.__p_JmITKG2aYldLwfuPmg0url = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "Vubgu341YesLbVfo9nGGlT", 475U);
                    var Output_12 = n21.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_11);
                    state_6.__p_Vubgu341YesLbVfo9nGGlT = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "VPaxj4OCoCXN1WrH2mvkIK", 481U);
                    var Output_14 = n20.Circle_PkBNwasMVJjOdYsVSPoZ1g.Create(Node_Context: Node_Context_13);
                    state_6.__p_VPaxj4OCoCXN1WrH2mvkIK = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "AK1BdIiUAY0QBFAg9e6l0a", 488U);
                    var Output_16 = n22.Stroke_ApdGyamrLDXOTiJpdyhyN9.Create(Node_Context: Node_Context_15);
                    state_6.__p_AK1BdIiUAY0QBFAg9e6l0a = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "Q9bvWBDXgq9OSK5C67X8Js", 496U);
                    var Output_18 = n22.Fill_UsNlhFP5Z8VOaaHSrZXiyC.Create(Node_Context: Node_Context_17);
                    state_6.__p_Q9bvWBDXgq9OSK5C67X8Js = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "TSMjq293f3bOZT5U05RH1M", 501U);
                    var Output_20 = n9.Transform_FwX2Jt8yhtVOKxyXSTS8pk.Create(Node_Context: Node_Context_19);
                    state_6.__p_TSMjq293f3bOZT5U05RH1M = Output_20;
                }

                n21.SkiaPaint_R Input_21 = n21.SkiaPaint_R.CreateDefault();
                n15.SKShader Shader_22 = default(n15.SKShader);
                var State_Output_24 = state_6.__p_Q9bvWBDXgq9OSK5C67X8Js.Update(Input_In: Input_21, Color_In: Fill_Color_In, Shader_In: Shader_22, Output_Out: out n21.SkiaPaint_R Output_23);
                n23.RectangleAnchor Anchor_25 = __c_VQu9ll7tVfFPs1yqSdfTMy;
                var State_Output_27 = state_6.__p_JmITKG2aYldLwfuPmg0url.Update(Position_In: Position_In, Radius_In: Radius_In, Anchor_In: Anchor_25, Paint_In: Output_23, Enabled_In: Fill_Enabled_In, Output_Out: out n6.ILayer Output_26);
                var Output_28 = Radius_In + Stroke_Offset_In;
                n21.SkiaPaint_R Input_29 = n21.SkiaPaint_R.CreateDefault();
                n15.SKStrokeJoin Join_30 = __c_BNbejFwx649Ld1BKsHMzCG;
                n15.SKStrokeCap Cap_31 = __c_GlD9GpCRBwuO0mDLcB4zyN;
                float Miter_32 = 0F;
                var State_Output_34 = state_6.__p_AK1BdIiUAY0QBFAg9e6l0a.Update(Input_In: Input_29, Color_In: Stroke_Color_In, Stroke_Width_In: Stroke_Width_In, Join_In: Join_30, Cap_In: Cap_31, Miter_In: Miter_32, Output_Out: out n21.SkiaPaint_R Output_33);
                n23.RectangleAnchor Anchor_35 = __c_PDXYWsPp4b8P8YclAE3P80;
                var State_Output_37 = state_6.__p_VPaxj4OCoCXN1WrH2mvkIK.Update(Position_In: Position_In, Radius_In: Output_28, Anchor_In: Anchor_35, Paint_In: Output_33, Enabled_In: Stroke_Enabled_In, Output_Out: out n6.ILayer Output_36);
                bool Debug_38 = false;
                bool Enabled_39 = true;
                var builder_40 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_Vubgu341YesLbVfo9nGGlT, 2);
                builder_40.Add(Output_26);
                builder_40.Add(Output_36);
                var __pin_group_Input_In_Vubgu341YesLbVfo9nGGlT_41 = builder_40.Commit();
                var State_Output_43 = state_6.__p_Vubgu341YesLbVfo9nGGlT.Update(Input_In: __pin_group_Input_In_Vubgu341YesLbVfo9nGGlT_41, Debug_In: Debug_38, Enabled_In: Enabled_39, Output_Out: out n6.ILayer Output_42);
                var State_Output_45 = state_6.__p_TSMjq293f3bOZT5U05RH1M.Update(Input_In: Output_42, Transformation_In: Transformation_In, Output_Out: out n6.ILayer Output_44);
                n6.CommonSpace Space_46 = __c_Rdb9kBbIoohNixQNHBzEMc;
                bool Clear_47 = true;
                var State_Output_49 = state_6.__p_RNgJ29APs4nN5ll5svWQOG.Update(Input_In: Output_44, Size_In: Output_Size_In, Space_In: Space_46, Clear_In: Clear_47, Clear_Color_In: Background_Color_In, Format_In: Output_Format_In, Output_Out: out n12.Texture Output_48);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_24 != state_6.__p_Q9bvWBDXgq9OSK5C67X8Js || State_Output_27 != state_6.__p_JmITKG2aYldLwfuPmg0url || State_Output_34 != state_6.__p_AK1BdIiUAY0QBFAg9e6l0a || State_Output_37 != state_6.__p_VPaxj4OCoCXN1WrH2mvkIK || __pin_group_Input_In_Vubgu341YesLbVfo9nGGlT_41 != state_6.__pin_group_Input_In_Vubgu341YesLbVfo9nGGlT || State_Output_43 != state_6.__p_Vubgu341YesLbVfo9nGGlT || State_Output_45 != state_6.__p_TSMjq293f3bOZT5U05RH1M || State_Output_49 != state_6.__p_RNgJ29APs4nN5ll5svWQOG ? new __R9saCXVWumeP7Zyg6LJAZD(state_6)
                    {__p_Q9bvWBDXgq9OSK5C67X8Js = State_Output_24, __p_JmITKG2aYldLwfuPmg0url = State_Output_27, __p_AK1BdIiUAY0QBFAg9e6l0a = State_Output_34, __p_VPaxj4OCoCXN1WrH2mvkIK = State_Output_37, __pin_group_Input_In_Vubgu341YesLbVfo9nGGlT = __pin_group_Input_In_Vubgu341YesLbVfo9nGGlT_41, __p_Vubgu341YesLbVfo9nGGlT = State_Output_43, __p_TSMjq293f3bOZT5U05RH1M = State_Output_45, __p_RNgJ29APs4nN5ll5svWQOG = State_Output_49} : state_6;
                else
                {
                    state_6.__p_Q9bvWBDXgq9OSK5C67X8Js = State_Output_24;
                    state_6.__p_JmITKG2aYldLwfuPmg0url = State_Output_27;
                    state_6.__p_AK1BdIiUAY0QBFAg9e6l0a = State_Output_34;
                    state_6.__p_VPaxj4OCoCXN1WrH2mvkIK = State_Output_37;
                    state_6.__pin_group_Input_In_Vubgu341YesLbVfo9nGGlT = __pin_group_Input_In_Vubgu341YesLbVfo9nGGlT_41;
                    state_6.__p_Vubgu341YesLbVfo9nGGlT = State_Output_43;
                    state_6.__p_TSMjq293f3bOZT5U05RH1M = State_Output_45;
                    state_6.__p_RNgJ29APs4nN5ll5svWQOG = State_Output_49;
                }

                outputs_4 = n2.ValueTuple.Create(Output_48);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_50 = outputs_4.Item1;
            Output_Out = __auto_50;
            n11.Circle_KZJ9Mw0tv2YQAAENG41G31 that_51 = this;
            if (this.__GetContext__().IsImmutable)
                that_51 = manager_2 != this.__cache_NC6ocyPm5xLLqMsmS7nNUT ? new Circle_KZJ9Mw0tv2YQAAENG41G31(this)
                {__cache_NC6ocyPm5xLLqMsmS7nNUT = manager_2} : that_51;
            else
            {
                this.__cache_NC6ocyPm5xLLqMsmS7nNUT = manager_2;
            }

            return that_51;
        }

        public n11.Circle_KZJ9Mw0tv2YQAAENG41G31 __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n11.Circle_KZJ9Mw0tv2YQAAENG41G31 that_0 = this;
            this.__cache_NC6ocyPm5xLLqMsmS7nNUT = null;
            return that_0;
        }

        public n11.Circle_KZJ9Mw0tv2YQAAENG41G31 __CreateDefault__()
        {
            n11.Circle_KZJ9Mw0tv2YQAAENG41G31 that_0 = this;
            this.__cache_NC6ocyPm5xLLqMsmS7nNUT = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_NC6ocyPm5xLLqMsmS7nNUT);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 453U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "NC6ocyPm5xLLqMsmS7nNUT", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n17.Manager<n2.ValueTuple<n13.Vector2, float, n13.Color4, bool, float, n13.Color4, float, n2.ValueTuple<bool, n13.Matrix, n13.Int2, n13.Color4, n16.PixelFormat>>, n2.ValueTuple<n12.Texture>> __cache_NC6ocyPm5xLLqMsmS7nNUT = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n23.RectangleAnchor __c_VQu9ll7tVfFPs1yqSdfTMy = n1.CompilationHelper.Deserialize<n23.RectangleAnchor>("Center", false, "Qi7h0S2HFoXQSgcrQLzJIk", "VQu9ll7tVfFPs1yqSdfTMy");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n15.SKStrokeJoin __c_BNbejFwx649Ld1BKsHMzCG = n1.CompilationHelper.Deserialize<n15.SKStrokeJoin>("Miter", false, "Qi7h0S2HFoXQSgcrQLzJIk", "BNbejFwx649Ld1BKsHMzCG");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n15.SKStrokeCap __c_GlD9GpCRBwuO0mDLcB4zyN = n1.CompilationHelper.Deserialize<n15.SKStrokeCap>("Butt", false, "Qi7h0S2HFoXQSgcrQLzJIk", "GlD9GpCRBwuO0mDLcB4zyN");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n23.RectangleAnchor __c_PDXYWsPp4b8P8YclAE3P80 = n1.CompilationHelper.Deserialize<n23.RectangleAnchor>("Center", false, "Qi7h0S2HFoXQSgcrQLzJIk", "PDXYWsPp4b8P8YclAE3P80");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.CommonSpace __c_Rdb9kBbIoohNixQNHBzEMc = n1.CompilationHelper.Deserialize<n6.CommonSpace>("Normalized", false, "Qi7h0S2HFoXQSgcrQLzJIk", "Rdb9kBbIoohNixQNHBzEMc");
        static Circle_KZJ9Mw0tv2YQAAENG41G31()
        {
        }

        public Circle_KZJ9Mw0tv2YQAAENG41G31(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Circle_KZJ9Mw0tv2YQAAENG41G31(Circle_KZJ9Mw0tv2YQAAENG41G31 other): base(other)
        {
            this.__cache_NC6ocyPm5xLLqMsmS7nNUT = other.__cache_NC6ocyPm5xLLqMsmS7nNUT;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_NC6ocyPm5xLLqMsmS7nNUT", in __cache_NC6ocyPm5xLLqMsmS7nNUT));
        }

        internal Circle_KZJ9Mw0tv2YQAAENG41G31 __WITH__(n17.Manager<n2.ValueTuple<n13.Vector2, float, n13.Color4, bool, float, n13.Color4, float, n2.ValueTuple<bool, n13.Matrix, n13.Int2, n13.Color4, n16.PixelFormat>>, n2.ValueTuple<n12.Texture>> __cache_NC6ocyPm5xLLqMsmS7nNUT)
        {
            n11.Circle_KZJ9Mw0tv2YQAAENG41G31 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_NC6ocyPm5xLLqMsmS7nNUT != this.__cache_NC6ocyPm5xLLqMsmS7nNUT ? new Circle_KZJ9Mw0tv2YQAAENG41G31(this)
                {__cache_NC6ocyPm5xLLqMsmS7nNUT = __cache_NC6ocyPm5xLLqMsmS7nNUT} : that_0;
            else
            {
                this.__cache_NC6ocyPm5xLLqMsmS7nNUT = __cache_NC6ocyPm5xLLqMsmS7nNUT;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "R9saCXVWumeP7Zyg6LJAZD", Name = "__R9saCXVWumeP7Zyg6LJAZD")]
        [n2.SerializableAttribute]
        public class __R9saCXVWumeP7Zyg6LJAZD : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RNgJ29APs4nN5ll5svWQOG);
                n1.CompilationHelper.SafeDispose(this.__p_JmITKG2aYldLwfuPmg0url);
                n1.CompilationHelper.SafeDispose(this.__p_Vubgu341YesLbVfo9nGGlT);
                n1.CompilationHelper.SafeDispose(this.__p_VPaxj4OCoCXN1WrH2mvkIK);
                n1.CompilationHelper.SafeDispose(this.__p_AK1BdIiUAY0QBFAg9e6l0a);
                n1.CompilationHelper.SafeDispose(this.__p_Q9bvWBDXgq9OSK5C67X8Js);
                n1.CompilationHelper.SafeDispose(this.__p_TSMjq293f3bOZT5U05RH1M);
                return;
            }

            [n1.ElementAttribute(TracingId = 460U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "RNgJ29APs4nN5ll5svWQOG", Name = "SkiaTexture", IsManaged = true, IsAutoGenerated = true)]
            public n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa __p_RNgJ29APs4nN5ll5svWQOG;
            [n1.ElementAttribute(TracingId = 468U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "JmITKG2aYldLwfuPmg0url", Name = "Circle", IsManaged = true, IsAutoGenerated = true)]
            public n20.Circle_PkBNwasMVJjOdYsVSPoZ1g __p_JmITKG2aYldLwfuPmg0url;
            [n1.ElementAttribute(TracingId = 475U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "Vubgu341YesLbVfo9nGGlT", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n21.Group_TKtMtIW1WMIOfh4AlYkjTy __p_Vubgu341YesLbVfo9nGGlT;
            [n1.ElementAttribute(TracingId = 481U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "VPaxj4OCoCXN1WrH2mvkIK", Name = "Circle", IsManaged = true, IsAutoGenerated = true)]
            public n20.Circle_PkBNwasMVJjOdYsVSPoZ1g __p_VPaxj4OCoCXN1WrH2mvkIK;
            [n1.ElementAttribute(TracingId = 488U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "AK1BdIiUAY0QBFAg9e6l0a", Name = "Stroke", IsManaged = true, IsAutoGenerated = true)]
            public n22.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_AK1BdIiUAY0QBFAg9e6l0a;
            [n1.ElementAttribute(TracingId = 496U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "Q9bvWBDXgq9OSK5C67X8Js", Name = "Fill", IsManaged = true, IsAutoGenerated = true)]
            public n22.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_Q9bvWBDXgq9OSK5C67X8Js;
            [n1.ElementAttribute(TracingId = 501U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "TSMjq293f3bOZT5U05RH1M", Name = "Transform", IsManaged = true, IsAutoGenerated = true)]
            public n9.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_TSMjq293f3bOZT5U05RH1M;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n25.Spread<n6.ILayer> __pin_group_Input_In_Vubgu341YesLbVfo9nGGlT = default(n25.Spread<n6.ILayer>);
            public __R9saCXVWumeP7Zyg6LJAZD(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __R9saCXVWumeP7Zyg6LJAZD(__R9saCXVWumeP7Zyg6LJAZD other): base(other)
            {
                this.__p_RNgJ29APs4nN5ll5svWQOG = other.__p_RNgJ29APs4nN5ll5svWQOG;
                this.__p_JmITKG2aYldLwfuPmg0url = other.__p_JmITKG2aYldLwfuPmg0url;
                this.__p_Vubgu341YesLbVfo9nGGlT = other.__p_Vubgu341YesLbVfo9nGGlT;
                this.__p_VPaxj4OCoCXN1WrH2mvkIK = other.__p_VPaxj4OCoCXN1WrH2mvkIK;
                this.__p_AK1BdIiUAY0QBFAg9e6l0a = other.__p_AK1BdIiUAY0QBFAg9e6l0a;
                this.__p_Q9bvWBDXgq9OSK5C67X8Js = other.__p_Q9bvWBDXgq9OSK5C67X8Js;
                this.__p_TSMjq293f3bOZT5U05RH1M = other.__p_TSMjq293f3bOZT5U05RH1M;
                this.__pin_group_Input_In_Vubgu341YesLbVfo9nGGlT = other.__pin_group_Input_In_Vubgu341YesLbVfo9nGGlT;
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RNgJ29APs4nN5ll5svWQOG", in __p_RNgJ29APs4nN5ll5svWQOG), n1.CompilationHelper.GetValueOrExisting(values, "__p_JmITKG2aYldLwfuPmg0url", in __p_JmITKG2aYldLwfuPmg0url), n1.CompilationHelper.GetValueOrExisting(values, "__p_Vubgu341YesLbVfo9nGGlT", in __p_Vubgu341YesLbVfo9nGGlT), n1.CompilationHelper.GetValueOrExisting(values, "__p_VPaxj4OCoCXN1WrH2mvkIK", in __p_VPaxj4OCoCXN1WrH2mvkIK), n1.CompilationHelper.GetValueOrExisting(values, "__p_AK1BdIiUAY0QBFAg9e6l0a", in __p_AK1BdIiUAY0QBFAg9e6l0a), n1.CompilationHelper.GetValueOrExisting(values, "__p_Q9bvWBDXgq9OSK5C67X8Js", in __p_Q9bvWBDXgq9OSK5C67X8Js), n1.CompilationHelper.GetValueOrExisting(values, "__p_TSMjq293f3bOZT5U05RH1M", in __p_TSMjq293f3bOZT5U05RH1M), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_Vubgu341YesLbVfo9nGGlT", in __pin_group_Input_In_Vubgu341YesLbVfo9nGGlT));
            }

            internal __R9saCXVWumeP7Zyg6LJAZD __WITH__(n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa __p_RNgJ29APs4nN5ll5svWQOG, n20.Circle_PkBNwasMVJjOdYsVSPoZ1g __p_JmITKG2aYldLwfuPmg0url, n21.Group_TKtMtIW1WMIOfh4AlYkjTy __p_Vubgu341YesLbVfo9nGGlT, n20.Circle_PkBNwasMVJjOdYsVSPoZ1g __p_VPaxj4OCoCXN1WrH2mvkIK, n22.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_AK1BdIiUAY0QBFAg9e6l0a, n22.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_Q9bvWBDXgq9OSK5C67X8Js, n9.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_TSMjq293f3bOZT5U05RH1M, n25.Spread<n6.ILayer> __pin_group_Input_In_Vubgu341YesLbVfo9nGGlT)
            {
                __R9saCXVWumeP7Zyg6LJAZD that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RNgJ29APs4nN5ll5svWQOG != this.__p_RNgJ29APs4nN5ll5svWQOG || __p_JmITKG2aYldLwfuPmg0url != this.__p_JmITKG2aYldLwfuPmg0url || __p_Vubgu341YesLbVfo9nGGlT != this.__p_Vubgu341YesLbVfo9nGGlT || __p_VPaxj4OCoCXN1WrH2mvkIK != this.__p_VPaxj4OCoCXN1WrH2mvkIK || __p_AK1BdIiUAY0QBFAg9e6l0a != this.__p_AK1BdIiUAY0QBFAg9e6l0a || __p_Q9bvWBDXgq9OSK5C67X8Js != this.__p_Q9bvWBDXgq9OSK5C67X8Js || __p_TSMjq293f3bOZT5U05RH1M != this.__p_TSMjq293f3bOZT5U05RH1M || __pin_group_Input_In_Vubgu341YesLbVfo9nGGlT != this.__pin_group_Input_In_Vubgu341YesLbVfo9nGGlT ? new __R9saCXVWumeP7Zyg6LJAZD(this)
                    {__p_RNgJ29APs4nN5ll5svWQOG = __p_RNgJ29APs4nN5ll5svWQOG, __p_JmITKG2aYldLwfuPmg0url = __p_JmITKG2aYldLwfuPmg0url, __p_Vubgu341YesLbVfo9nGGlT = __p_Vubgu341YesLbVfo9nGGlT, __p_VPaxj4OCoCXN1WrH2mvkIK = __p_VPaxj4OCoCXN1WrH2mvkIK, __p_AK1BdIiUAY0QBFAg9e6l0a = __p_AK1BdIiUAY0QBFAg9e6l0a, __p_Q9bvWBDXgq9OSK5C67X8Js = __p_Q9bvWBDXgq9OSK5C67X8Js, __p_TSMjq293f3bOZT5U05RH1M = __p_TSMjq293f3bOZT5U05RH1M, __pin_group_Input_In_Vubgu341YesLbVfo9nGGlT = __pin_group_Input_In_Vubgu341YesLbVfo9nGGlT} : that_0;
                else
                {
                    this.__p_RNgJ29APs4nN5ll5svWQOG = __p_RNgJ29APs4nN5ll5svWQOG;
                    this.__p_JmITKG2aYldLwfuPmg0url = __p_JmITKG2aYldLwfuPmg0url;
                    this.__p_Vubgu341YesLbVfo9nGGlT = __p_Vubgu341YesLbVfo9nGGlT;
                    this.__p_VPaxj4OCoCXN1WrH2mvkIK = __p_VPaxj4OCoCXN1WrH2mvkIK;
                    this.__p_AK1BdIiUAY0QBFAg9e6l0a = __p_AK1BdIiUAY0QBFAg9e6l0a;
                    this.__p_Q9bvWBDXgq9OSK5C67X8Js = __p_Q9bvWBDXgq9OSK5C67X8Js;
                    this.__p_TSMjq293f3bOZT5U05RH1M = __p_TSMjq293f3bOZT5U05RH1M;
                    this.__pin_group_Input_In_Vubgu341YesLbVfo9nGGlT = __pin_group_Input_In_Vubgu341YesLbVfo9nGGlT;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 588U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "Crg4bCepjCgOB2arXcsjeQ", Name = "Polygon_Crg4bCepjCgOB2arXcsjeQ")]
    [n2.SerializableAttribute]
    public class Polygon_Crg4bCepjCgOB2arXcsjeQ : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n11.Polygon_Crg4bCepjCgOB2arXcsjeQ Create(n1.NodeContext Node_Context)
        {
            var instance = new Polygon_Crg4bCepjCgOB2arXcsjeQ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n11.Polygon_Crg4bCepjCgOB2arXcsjeQ CreateDefault()
        {
            var instance = new Polygon_Crg4bCepjCgOB2arXcsjeQ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.Polygon_Crg4bCepjCgOB2arXcsjeQ Update(n10.IEnumerable<n13.Vector2> Points_In, bool Closed_In, n13.Matrix Transformation_In, [n4.SerializedDefaultValueAttribute("0, 0, 0, 1", false)] n13.Color4 Background_Color_In, n13.Color4 Fill_Color_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Fill_Enabled_In, n13.Color4 Stroke_Color_In, [n4.SerializedDefaultValueAttribute("0.02", false)] float Stroke_Width_In, n15.SKStrokeJoin Stroke_Join_In, [n4.SerializedDefaultValueAttribute("1.5", false)] float Stroke_Miter_In, n15.SKStrokeCap Stroke_Cap_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Stroke_Enabled_In, [n4.SerializedDefaultValueAttribute("512, 512", false)] n13.Int2 Output_Size_In, [n4.SerializedDefaultValueAttribute("R8G8B8A8_UNorm_SRgb", false)] n16.PixelFormat Output_Format_In, out n12.Texture Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_CmxYdt1kblPNgsXLA65Oh7;
            if (manager_2 is null)
            {
                manager_2 = new n17.Manager<n2.ValueTuple<n10.IEnumerable<n13.Vector2>, bool, n13.Color4, bool, n13.Color4, float, n15.SKStrokeJoin, n2.ValueTuple<n15.SKStrokeCap, float, bool, n13.Matrix, n13.Int2, n13.Color4, n16.PixelFormat>>, n2.ValueTuple<n12.Texture>>(n2.ValueTuple.Create(default(n12.Texture)));
            }

            var inputs_3 = (Points_In, Closed_In, Fill_Color_In, Fill_Enabled_In, Stroke_Color_In, Stroke_Width_In, Stroke_Join_In, Stroke_Cap_In, Stroke_Miter_In, Stroke_Enabled_In, Transformation_In, Output_Size_In, Background_Color_In, Output_Format_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__CcILq8AorBaQcwYsQ6qy26>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __CcILq8AorBaQcwYsQ6qy26(__GetContext__(), n1.VLObject.NewIdentity())
                    {__pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6 = n26._Operations_.CreateDefault<n6.ILayer>()};
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "QRCE8EHa1zAODQObgfCdvY", 612U);
                    var Output_8 = n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa.Create(Node_Context: Node_Context_7);
                    state_6.__p_QRCE8EHa1zAODQObgfCdvY = Output_8;
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "U1Lg0rE5wiwN9x9jxGoFJ3", 620U);
                    var Output_10 = n20.Polygon_OpmdO5gZr3xLcHs8bYnFf1.Create(Node_Context: Node_Context_9);
                    state_6.__p_U1Lg0rE5wiwN9x9jxGoFJ3 = Output_10;
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "M9SIoYWLUpDMxmsfCKAQJ6", 627U);
                    var Output_12 = n21.Group_TKtMtIW1WMIOfh4AlYkjTy.Create(Node_Context: Node_Context_11);
                    state_6.__p_M9SIoYWLUpDMxmsfCKAQJ6 = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "HsF7SOk8cqRPwEJcphJqWF", 633U);
                    var Output_14 = n20.Polygon_OpmdO5gZr3xLcHs8bYnFf1.Create(Node_Context: Node_Context_13);
                    state_6.__p_HsF7SOk8cqRPwEJcphJqWF = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "IR9tgYFoEwFLQFOQwulAiF", 640U);
                    var Output_16 = n22.Stroke_ApdGyamrLDXOTiJpdyhyN9.Create(Node_Context: Node_Context_15);
                    state_6.__p_IR9tgYFoEwFLQFOQwulAiF = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "SkcJ3G4gg03Mm8ybuqiX13", 648U);
                    var Output_18 = n22.Fill_UsNlhFP5Z8VOaaHSrZXiyC.Create(Node_Context: Node_Context_17);
                    state_6.__p_SkcJ3G4gg03Mm8ybuqiX13 = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "QWQ4u3vU2OcM1rvxvoIRG2", 653U);
                    var Output_20 = n9.Transform_FwX2Jt8yhtVOKxyXSTS8pk.Create(Node_Context: Node_Context_19);
                    state_6.__p_QWQ4u3vU2OcM1rvxvoIRG2 = Output_20;
                }

                n21.SkiaPaint_R Input_21 = n21.SkiaPaint_R.CreateDefault();
                n15.SKShader Shader_22 = default(n15.SKShader);
                var State_Output_24 = state_6.__p_SkcJ3G4gg03Mm8ybuqiX13.Update(Input_In: Input_21, Color_In: Fill_Color_In, Shader_In: Shader_22, Output_Out: out n21.SkiaPaint_R Output_23);
                n15.SKPathFillType Winding_25 = default(n15.SKPathFillType);
                var State_Output_27 = state_6.__p_U1Lg0rE5wiwN9x9jxGoFJ3.Update(Points_In: Points_In, Closed_In: Closed_In, Paint_In: Output_23, Winding_In: Winding_25, Enabled_In: Fill_Enabled_In, Output_Out: out n20.PathLayer_C Output_26);
                n6.ILayer Input_28 = (n6.ILayer)Output_26;
                n21.SkiaPaint_R Input_29 = n21.SkiaPaint_R.CreateDefault();
                var State_Output_31 = state_6.__p_IR9tgYFoEwFLQFOQwulAiF.Update(Input_In: Input_29, Color_In: Stroke_Color_In, Stroke_Width_In: Stroke_Width_In, Join_In: Stroke_Join_In, Cap_In: Stroke_Cap_In, Miter_In: Stroke_Miter_In, Output_Out: out n21.SkiaPaint_R Output_30);
                n15.SKPathFillType Winding_32 = default(n15.SKPathFillType);
                var State_Output_34 = state_6.__p_HsF7SOk8cqRPwEJcphJqWF.Update(Points_In: Points_In, Closed_In: Closed_In, Paint_In: Output_30, Winding_In: Winding_32, Enabled_In: Stroke_Enabled_In, Output_Out: out n20.PathLayer_C Output_33);
                n6.ILayer Input_2_35 = (n6.ILayer)Output_33;
                bool Debug_36 = false;
                bool Enabled_37 = true;
                var builder_38 = n4.CollectionBuilders.GetBuilder(state_6.__pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6, 2);
                builder_38.Add(Input_28);
                builder_38.Add(Input_2_35);
                var __pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6_39 = builder_38.Commit();
                var State_Output_41 = state_6.__p_M9SIoYWLUpDMxmsfCKAQJ6.Update(Input_In: __pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6_39, Debug_In: Debug_36, Enabled_In: Enabled_37, Output_Out: out n6.ILayer Output_40);
                var State_Output_43 = state_6.__p_QWQ4u3vU2OcM1rvxvoIRG2.Update(Input_In: Output_40, Transformation_In: Transformation_In, Output_Out: out n6.ILayer Output_42);
                n6.CommonSpace Space_44 = __c_BXd6zYmwXy3LM8PdrmdYPR;
                bool Clear_45 = true;
                var State_Output_47 = state_6.__p_QRCE8EHa1zAODQObgfCdvY.Update(Input_In: Output_42, Size_In: Output_Size_In, Space_In: Space_44, Clear_In: Clear_45, Clear_Color_In: Background_Color_In, Format_In: Output_Format_In, Output_Out: out n12.Texture Output_46);
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_24 != state_6.__p_SkcJ3G4gg03Mm8ybuqiX13 || State_Output_27 != state_6.__p_U1Lg0rE5wiwN9x9jxGoFJ3 || State_Output_31 != state_6.__p_IR9tgYFoEwFLQFOQwulAiF || State_Output_34 != state_6.__p_HsF7SOk8cqRPwEJcphJqWF || __pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6_39 != state_6.__pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6 || State_Output_41 != state_6.__p_M9SIoYWLUpDMxmsfCKAQJ6 || State_Output_43 != state_6.__p_QWQ4u3vU2OcM1rvxvoIRG2 || State_Output_47 != state_6.__p_QRCE8EHa1zAODQObgfCdvY ? new __CcILq8AorBaQcwYsQ6qy26(state_6)
                    {__p_SkcJ3G4gg03Mm8ybuqiX13 = State_Output_24, __p_U1Lg0rE5wiwN9x9jxGoFJ3 = State_Output_27, __p_IR9tgYFoEwFLQFOQwulAiF = State_Output_31, __p_HsF7SOk8cqRPwEJcphJqWF = State_Output_34, __pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6 = __pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6_39, __p_M9SIoYWLUpDMxmsfCKAQJ6 = State_Output_41, __p_QWQ4u3vU2OcM1rvxvoIRG2 = State_Output_43, __p_QRCE8EHa1zAODQObgfCdvY = State_Output_47} : state_6;
                else
                {
                    state_6.__p_SkcJ3G4gg03Mm8ybuqiX13 = State_Output_24;
                    state_6.__p_U1Lg0rE5wiwN9x9jxGoFJ3 = State_Output_27;
                    state_6.__p_IR9tgYFoEwFLQFOQwulAiF = State_Output_31;
                    state_6.__p_HsF7SOk8cqRPwEJcphJqWF = State_Output_34;
                    state_6.__pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6 = __pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6_39;
                    state_6.__p_M9SIoYWLUpDMxmsfCKAQJ6 = State_Output_41;
                    state_6.__p_QWQ4u3vU2OcM1rvxvoIRG2 = State_Output_43;
                    state_6.__p_QRCE8EHa1zAODQObgfCdvY = State_Output_47;
                }

                outputs_4 = n2.ValueTuple.Create(Output_46);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_48 = outputs_4.Item1;
            Output_Out = __auto_48;
            n11.Polygon_Crg4bCepjCgOB2arXcsjeQ that_49 = this;
            if (this.__GetContext__().IsImmutable)
                that_49 = manager_2 != this.__cache_CmxYdt1kblPNgsXLA65Oh7 ? new Polygon_Crg4bCepjCgOB2arXcsjeQ(this)
                {__cache_CmxYdt1kblPNgsXLA65Oh7 = manager_2} : that_49;
            else
            {
                this.__cache_CmxYdt1kblPNgsXLA65Oh7 = manager_2;
            }

            return that_49;
        }

        public n11.Polygon_Crg4bCepjCgOB2arXcsjeQ __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n11.Polygon_Crg4bCepjCgOB2arXcsjeQ that_0 = this;
            this.__cache_CmxYdt1kblPNgsXLA65Oh7 = null;
            return that_0;
        }

        public n11.Polygon_Crg4bCepjCgOB2arXcsjeQ __CreateDefault__()
        {
            n11.Polygon_Crg4bCepjCgOB2arXcsjeQ that_0 = this;
            this.__cache_CmxYdt1kblPNgsXLA65Oh7 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_CmxYdt1kblPNgsXLA65Oh7);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 605U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "CmxYdt1kblPNgsXLA65Oh7", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n17.Manager<n2.ValueTuple<n10.IEnumerable<n13.Vector2>, bool, n13.Color4, bool, n13.Color4, float, n15.SKStrokeJoin, n2.ValueTuple<n15.SKStrokeCap, float, bool, n13.Matrix, n13.Int2, n13.Color4, n16.PixelFormat>>, n2.ValueTuple<n12.Texture>> __cache_CmxYdt1kblPNgsXLA65Oh7 = null;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n6.CommonSpace __c_BXd6zYmwXy3LM8PdrmdYPR = n1.CompilationHelper.Deserialize<n6.CommonSpace>("Normalized", false, "Qi7h0S2HFoXQSgcrQLzJIk", "BXd6zYmwXy3LM8PdrmdYPR");
        static Polygon_Crg4bCepjCgOB2arXcsjeQ()
        {
        }

        public Polygon_Crg4bCepjCgOB2arXcsjeQ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Polygon_Crg4bCepjCgOB2arXcsjeQ(Polygon_Crg4bCepjCgOB2arXcsjeQ other): base(other)
        {
            this.__cache_CmxYdt1kblPNgsXLA65Oh7 = other.__cache_CmxYdt1kblPNgsXLA65Oh7;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_CmxYdt1kblPNgsXLA65Oh7", in __cache_CmxYdt1kblPNgsXLA65Oh7));
        }

        internal Polygon_Crg4bCepjCgOB2arXcsjeQ __WITH__(n17.Manager<n2.ValueTuple<n10.IEnumerable<n13.Vector2>, bool, n13.Color4, bool, n13.Color4, float, n15.SKStrokeJoin, n2.ValueTuple<n15.SKStrokeCap, float, bool, n13.Matrix, n13.Int2, n13.Color4, n16.PixelFormat>>, n2.ValueTuple<n12.Texture>> __cache_CmxYdt1kblPNgsXLA65Oh7)
        {
            n11.Polygon_Crg4bCepjCgOB2arXcsjeQ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_CmxYdt1kblPNgsXLA65Oh7 != this.__cache_CmxYdt1kblPNgsXLA65Oh7 ? new Polygon_Crg4bCepjCgOB2arXcsjeQ(this)
                {__cache_CmxYdt1kblPNgsXLA65Oh7 = __cache_CmxYdt1kblPNgsXLA65Oh7} : that_0;
            else
            {
                this.__cache_CmxYdt1kblPNgsXLA65Oh7 = __cache_CmxYdt1kblPNgsXLA65Oh7;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "CcILq8AorBaQcwYsQ6qy26", Name = "__CcILq8AorBaQcwYsQ6qy26")]
        [n2.SerializableAttribute]
        public class __CcILq8AorBaQcwYsQ6qy26 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_QRCE8EHa1zAODQObgfCdvY);
                n1.CompilationHelper.SafeDispose(this.__p_U1Lg0rE5wiwN9x9jxGoFJ3);
                n1.CompilationHelper.SafeDispose(this.__p_M9SIoYWLUpDMxmsfCKAQJ6);
                n1.CompilationHelper.SafeDispose(this.__p_HsF7SOk8cqRPwEJcphJqWF);
                n1.CompilationHelper.SafeDispose(this.__p_IR9tgYFoEwFLQFOQwulAiF);
                n1.CompilationHelper.SafeDispose(this.__p_SkcJ3G4gg03Mm8ybuqiX13);
                n1.CompilationHelper.SafeDispose(this.__p_QWQ4u3vU2OcM1rvxvoIRG2);
                return;
            }

            [n1.ElementAttribute(TracingId = 612U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "QRCE8EHa1zAODQObgfCdvY", Name = "SkiaTexture", IsManaged = true, IsAutoGenerated = true)]
            public n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa __p_QRCE8EHa1zAODQObgfCdvY;
            [n1.ElementAttribute(TracingId = 620U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "U1Lg0rE5wiwN9x9jxGoFJ3", Name = "Polygon", IsManaged = true, IsAutoGenerated = true)]
            public n20.Polygon_OpmdO5gZr3xLcHs8bYnFf1 __p_U1Lg0rE5wiwN9x9jxGoFJ3;
            [n1.ElementAttribute(TracingId = 627U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "M9SIoYWLUpDMxmsfCKAQJ6", Name = "Group", IsManaged = true, IsAutoGenerated = true)]
            public n21.Group_TKtMtIW1WMIOfh4AlYkjTy __p_M9SIoYWLUpDMxmsfCKAQJ6;
            [n1.ElementAttribute(TracingId = 633U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "HsF7SOk8cqRPwEJcphJqWF", Name = "Polygon", IsManaged = true, IsAutoGenerated = true)]
            public n20.Polygon_OpmdO5gZr3xLcHs8bYnFf1 __p_HsF7SOk8cqRPwEJcphJqWF;
            [n1.ElementAttribute(TracingId = 640U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "IR9tgYFoEwFLQFOQwulAiF", Name = "Stroke", IsManaged = true, IsAutoGenerated = true)]
            public n22.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_IR9tgYFoEwFLQFOQwulAiF;
            [n1.ElementAttribute(TracingId = 648U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "SkcJ3G4gg03Mm8ybuqiX13", Name = "Fill", IsManaged = true, IsAutoGenerated = true)]
            public n22.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_SkcJ3G4gg03Mm8ybuqiX13;
            [n1.ElementAttribute(TracingId = 653U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "QWQ4u3vU2OcM1rvxvoIRG2", Name = "Transform", IsManaged = true, IsAutoGenerated = true)]
            public n9.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_QWQ4u3vU2OcM1rvxvoIRG2;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n25.Spread<n6.ILayer> __pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6 = default(n25.Spread<n6.ILayer>);
            public __CcILq8AorBaQcwYsQ6qy26(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __CcILq8AorBaQcwYsQ6qy26(__CcILq8AorBaQcwYsQ6qy26 other): base(other)
            {
                this.__p_QRCE8EHa1zAODQObgfCdvY = other.__p_QRCE8EHa1zAODQObgfCdvY;
                this.__p_U1Lg0rE5wiwN9x9jxGoFJ3 = other.__p_U1Lg0rE5wiwN9x9jxGoFJ3;
                this.__p_M9SIoYWLUpDMxmsfCKAQJ6 = other.__p_M9SIoYWLUpDMxmsfCKAQJ6;
                this.__p_HsF7SOk8cqRPwEJcphJqWF = other.__p_HsF7SOk8cqRPwEJcphJqWF;
                this.__p_IR9tgYFoEwFLQFOQwulAiF = other.__p_IR9tgYFoEwFLQFOQwulAiF;
                this.__p_SkcJ3G4gg03Mm8ybuqiX13 = other.__p_SkcJ3G4gg03Mm8ybuqiX13;
                this.__p_QWQ4u3vU2OcM1rvxvoIRG2 = other.__p_QWQ4u3vU2OcM1rvxvoIRG2;
                this.__pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6 = other.__pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6;
            }

            protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QRCE8EHa1zAODQObgfCdvY", in __p_QRCE8EHa1zAODQObgfCdvY), n1.CompilationHelper.GetValueOrExisting(values, "__p_U1Lg0rE5wiwN9x9jxGoFJ3", in __p_U1Lg0rE5wiwN9x9jxGoFJ3), n1.CompilationHelper.GetValueOrExisting(values, "__p_M9SIoYWLUpDMxmsfCKAQJ6", in __p_M9SIoYWLUpDMxmsfCKAQJ6), n1.CompilationHelper.GetValueOrExisting(values, "__p_HsF7SOk8cqRPwEJcphJqWF", in __p_HsF7SOk8cqRPwEJcphJqWF), n1.CompilationHelper.GetValueOrExisting(values, "__p_IR9tgYFoEwFLQFOQwulAiF", in __p_IR9tgYFoEwFLQFOQwulAiF), n1.CompilationHelper.GetValueOrExisting(values, "__p_SkcJ3G4gg03Mm8ybuqiX13", in __p_SkcJ3G4gg03Mm8ybuqiX13), n1.CompilationHelper.GetValueOrExisting(values, "__p_QWQ4u3vU2OcM1rvxvoIRG2", in __p_QWQ4u3vU2OcM1rvxvoIRG2), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6", in __pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6));
            }

            internal __CcILq8AorBaQcwYsQ6qy26 __WITH__(n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa __p_QRCE8EHa1zAODQObgfCdvY, n20.Polygon_OpmdO5gZr3xLcHs8bYnFf1 __p_U1Lg0rE5wiwN9x9jxGoFJ3, n21.Group_TKtMtIW1WMIOfh4AlYkjTy __p_M9SIoYWLUpDMxmsfCKAQJ6, n20.Polygon_OpmdO5gZr3xLcHs8bYnFf1 __p_HsF7SOk8cqRPwEJcphJqWF, n22.Stroke_ApdGyamrLDXOTiJpdyhyN9 __p_IR9tgYFoEwFLQFOQwulAiF, n22.Fill_UsNlhFP5Z8VOaaHSrZXiyC __p_SkcJ3G4gg03Mm8ybuqiX13, n9.Transform_FwX2Jt8yhtVOKxyXSTS8pk __p_QWQ4u3vU2OcM1rvxvoIRG2, n25.Spread<n6.ILayer> __pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6)
            {
                __CcILq8AorBaQcwYsQ6qy26 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_QRCE8EHa1zAODQObgfCdvY != this.__p_QRCE8EHa1zAODQObgfCdvY || __p_U1Lg0rE5wiwN9x9jxGoFJ3 != this.__p_U1Lg0rE5wiwN9x9jxGoFJ3 || __p_M9SIoYWLUpDMxmsfCKAQJ6 != this.__p_M9SIoYWLUpDMxmsfCKAQJ6 || __p_HsF7SOk8cqRPwEJcphJqWF != this.__p_HsF7SOk8cqRPwEJcphJqWF || __p_IR9tgYFoEwFLQFOQwulAiF != this.__p_IR9tgYFoEwFLQFOQwulAiF || __p_SkcJ3G4gg03Mm8ybuqiX13 != this.__p_SkcJ3G4gg03Mm8ybuqiX13 || __p_QWQ4u3vU2OcM1rvxvoIRG2 != this.__p_QWQ4u3vU2OcM1rvxvoIRG2 || __pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6 != this.__pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6 ? new __CcILq8AorBaQcwYsQ6qy26(this)
                    {__p_QRCE8EHa1zAODQObgfCdvY = __p_QRCE8EHa1zAODQObgfCdvY, __p_U1Lg0rE5wiwN9x9jxGoFJ3 = __p_U1Lg0rE5wiwN9x9jxGoFJ3, __p_M9SIoYWLUpDMxmsfCKAQJ6 = __p_M9SIoYWLUpDMxmsfCKAQJ6, __p_HsF7SOk8cqRPwEJcphJqWF = __p_HsF7SOk8cqRPwEJcphJqWF, __p_IR9tgYFoEwFLQFOQwulAiF = __p_IR9tgYFoEwFLQFOQwulAiF, __p_SkcJ3G4gg03Mm8ybuqiX13 = __p_SkcJ3G4gg03Mm8ybuqiX13, __p_QWQ4u3vU2OcM1rvxvoIRG2 = __p_QWQ4u3vU2OcM1rvxvoIRG2, __pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6 = __pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6} : that_0;
                else
                {
                    this.__p_QRCE8EHa1zAODQObgfCdvY = __p_QRCE8EHa1zAODQObgfCdvY;
                    this.__p_U1Lg0rE5wiwN9x9jxGoFJ3 = __p_U1Lg0rE5wiwN9x9jxGoFJ3;
                    this.__p_M9SIoYWLUpDMxmsfCKAQJ6 = __p_M9SIoYWLUpDMxmsfCKAQJ6;
                    this.__p_HsF7SOk8cqRPwEJcphJqWF = __p_HsF7SOk8cqRPwEJcphJqWF;
                    this.__p_IR9tgYFoEwFLQFOQwulAiF = __p_IR9tgYFoEwFLQFOQwulAiF;
                    this.__p_SkcJ3G4gg03Mm8ybuqiX13 = __p_SkcJ3G4gg03Mm8ybuqiX13;
                    this.__p_QWQ4u3vU2OcM1rvxvoIRG2 = __p_QWQ4u3vU2OcM1rvxvoIRG2;
                    this.__pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6 = __pin_group_Input_In_M9SIoYWLUpDMxmsfCKAQJ6;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 746U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "Ub6uZs9pYr2PATN5LXKTMa", Name = "SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa")]
    [n2.SerializableAttribute]
    public class SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa Create(n1.NodeContext Node_Context)
        {
            var instance = new SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa CreateDefault()
        {
            var instance = new SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa Update(n6.ILayer Input_In, [n4.SerializedDefaultValueAttribute("1280, 720", false)] n13.Int2 Size_In, [n4.SerializedDefaultValueAttribute("Normalized", false)] n6.CommonSpace Space_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Clear_In, [n4.SerializedDefaultValueAttribute("0, 0, 0, 1", false)] n13.Color4 Clear_Color_In, [n4.SerializedDefaultValueAttribute("R16G16B16A16_Float", false)] n16.PixelFormat Format_In, out n12.Texture Output_Out)
        {
            var State_Output_1 = this.__p_NHU250rBdFxQbLnvtqQbKr.Update(Input_In: Input_In, Space_In: Space_In, Output_Out: out n7.IGraphicsRendererBase Output_0);
            n7.RenderView Render_View_2 = default(n7.RenderView);
            bool Color_Shared_3 = false;
            n16.PixelFormat Depth_Format_4 = __c_PvSIsGNkAWGQXbiEvcvDvO;
            bool Depth_Shared_5 = false;
            n7.ClearRendererFlags Clear_Flags_6 = default(n7.ClearRendererFlags);
            float Clear_Depth_7 = 1F;
            byte Clear_Stencil_8 = 0;
            bool Auto_Render_9 = true;
            var Output_13 = this.__p_OUYjQjHxwrQOhJCPSw4Wi0.Update(Input_In: Output_0, Size_In: Size_In, Render_View_In: Render_View_2, Format_In: Format_In, Color_Shared_In: Color_Shared_3, Depth_Format_In: Depth_Format_4, Depth_Shared_In: Depth_Shared_5, Clear_Flags_In: Clear_Flags_6, Clear_Color_In: Clear_Color_In, Clear_Depth_In: Clear_Depth_7, Clear_Stencil_In: Clear_Stencil_8, Clear_In: Clear_In, Auto_Render_In: Auto_Render_9, Layer_Out: out n27.WithRenderTargetAndViewPort Layer_10, Color_Out: out n12.Texture Color_11, Depth_Out: out n12.Texture Depth_12);
            Output_Out = Color_11;
            n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa that_14 = this;
            if (this.__GetContext__().IsImmutable)
                that_14 = State_Output_1 != this.__p_NHU250rBdFxQbLnvtqQbKr || Output_13 != this.__p_OUYjQjHxwrQOhJCPSw4Wi0 ? new SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa(this)
                {__p_NHU250rBdFxQbLnvtqQbKr = State_Output_1, __p_OUYjQjHxwrQOhJCPSw4Wi0 = Output_13} : that_14;
            else
            {
                this.__p_NHU250rBdFxQbLnvtqQbKr = State_Output_1;
                this.__p_OUYjQjHxwrQOhJCPSw4Wi0 = Output_13;
            }

            return that_14;
        }

        public n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "NHU250rBdFxQbLnvtqQbKr", 749U);
            var Output_1 = n3.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("Qi7h0S2HFoXQSgcrQLzJIk", "OUYjQjHxwrQOhJCPSw4Wi0", 753U);
            var Output_3 = n28.RenderTexture_IYQobGzVbWEQYcMFud8H4J.Create(Node_Context: Node_Context_2);
            n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa that_4 = this;
            this.__p_NHU250rBdFxQbLnvtqQbKr = Output_1;
            this.__p_OUYjQjHxwrQOhJCPSw4Wi0 = Output_3;
            return that_4;
        }

        public n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa __CreateDefault__()
        {
            n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa that_0 = this;
            this.__p_NHU250rBdFxQbLnvtqQbKr = n3.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI.CreateDefault();
            this.__p_OUYjQjHxwrQOhJCPSw4Wi0 = n28.RenderTexture_IYQobGzVbWEQYcMFud8H4J.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_NHU250rBdFxQbLnvtqQbKr);
            n1.CompilationHelper.SafeDispose(this.__p_OUYjQjHxwrQOhJCPSw4Wi0);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 749U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "NHU250rBdFxQbLnvtqQbKr", Name = "SkiaRenderer", IsManaged = true, IsAutoGenerated = true)]
        public n3.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI __p_NHU250rBdFxQbLnvtqQbKr;
        [n1.ElementAttribute(TracingId = 753U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "OUYjQjHxwrQOhJCPSw4Wi0", Name = "RenderTexture", IsManaged = true, IsAutoGenerated = true)]
        public n28.RenderTexture_IYQobGzVbWEQYcMFud8H4J __p_OUYjQjHxwrQOhJCPSw4Wi0;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n16.PixelFormat __c_PvSIsGNkAWGQXbiEvcvDvO = n1.CompilationHelper.Deserialize<n16.PixelFormat>("D24_UNorm_S8_UInt", false, "Qi7h0S2HFoXQSgcrQLzJIk", "PvSIsGNkAWGQXbiEvcvDvO");
        static SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa()
        {
        }

        public SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa(SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa other): base(other)
        {
            this.__p_NHU250rBdFxQbLnvtqQbKr = other.__p_NHU250rBdFxQbLnvtqQbKr;
            this.__p_OUYjQjHxwrQOhJCPSw4Wi0 = other.__p_OUYjQjHxwrQOhJCPSw4Wi0;
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NHU250rBdFxQbLnvtqQbKr", in __p_NHU250rBdFxQbLnvtqQbKr), n1.CompilationHelper.GetValueOrExisting(values, "__p_OUYjQjHxwrQOhJCPSw4Wi0", in __p_OUYjQjHxwrQOhJCPSw4Wi0));
        }

        internal SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa __WITH__(n3.SkiaRenderer_POSaPE5Tv7ON6Pep1InAoI __p_NHU250rBdFxQbLnvtqQbKr, n28.RenderTexture_IYQobGzVbWEQYcMFud8H4J __p_OUYjQjHxwrQOhJCPSw4Wi0)
        {
            n11.SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_NHU250rBdFxQbLnvtqQbKr != this.__p_NHU250rBdFxQbLnvtqQbKr || __p_OUYjQjHxwrQOhJCPSw4Wi0 != this.__p_OUYjQjHxwrQOhJCPSw4Wi0 ? new SkiaTexture_Ub6uZs9pYr2PATN5LXKTMa(this)
                {__p_NHU250rBdFxQbLnvtqQbKr = __p_NHU250rBdFxQbLnvtqQbKr, __p_OUYjQjHxwrQOhJCPSw4Wi0 = __p_OUYjQjHxwrQOhJCPSw4Wi0} : that_0;
            else
            {
                this.__p_NHU250rBdFxQbLnvtqQbKr = __p_NHU250rBdFxQbLnvtqQbKr;
                this.__p_OUYjQjHxwrQOhJCPSw4Wi0 = __p_OUYjQjHxwrQOhJCPSw4Wi0;
            }

            return that_0;
        }
    }
}

namespace _VL_Stride_Windows_.Stride
{
    [n1.ElementAttribute(TracingId = 797U, DocumentId = "Qi7h0S2HFoXQSgcrQLzJIk", PersistentId = "HCvcUQNecQcMeAC4SyYpiJ", Name = "VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ")]
    [n2.SerializableAttribute]
    public class VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n24.VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n24.VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ CreateDefault()
        {
            var instance = new VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n24.VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ Update()
        {
            return this;
        }

        public n24.VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ __Create__(n1.NodeContext Node_Context)
        {
            n8.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n24.VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ __CreateDefault__()
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

        public VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ(VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n10.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_Stride_WindowsApplication_HCvcUQNecQcMeAC4SyYpiJ __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Stride_Windows_
{
    public struct __AdaptiveImplementations__Qi7h0S2HFoXQSgcrQLzJIk
    {
    }
}