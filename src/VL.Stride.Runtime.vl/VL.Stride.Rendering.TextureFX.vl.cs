extern alias e22;
extern alias e24;
extern alias e31;
extern alias e26;
extern alias e3;
extern alias e25;
extern alias e2;
extern alias e23;
extern alias e29;
extern alias e4;

using n47 = _VL_Stride_Rendering_.Stride.Rendering;
using n9 = e26::Stride.Graphics;
using n35 = _VL_Stride_Graphics_.Stride.Utils.Advanced;
using n29 = _CoreLibBasics_.Control.Advanced;
using n31 = e2::VL.Lib.Collections;
using n19 = e3::VL.Lib.Primitive.CacheRegion;
using n56 = _CoreLibBasics_.Primitive.Object.Advanced;
using n32 = _CoreLibBasics_.Control;
using n26 = _VL_Stride_Graphics_.Stride.Textures.Utils.Obsolete;
using n60 = _CoreLibBasics_.Math.Generic.Advanced;
using n57 = _VL_Stride_Rendering_TextureFX_.Stride.Textures;
using n5 = e29::Stride.Rendering.Images;
using n24 = _VL_Stride_Games_.Stride.Utils;
using n16 = e31::VL.Stride.Shaders.ShaderFX;
using n13 = _VL_Stride_Rendering_TextureFX_;
using n28 = e31::VL.Stride.Graphics;
using n53 = _CoreLibBasics_.Animation.IFrameClock.Advanced;
using n11 = global::System.Collections.Generic;
using n44 = _CoreLibBasics_._2D.Vector2;
using n21 = _VL_Stride_Rendering_ShaderFX_.Stride.Rendering.ShaderFX.Texture.Experimental;
using n8 = _VL_Stride_Rendering_TextureFX_.Stride.Textures.Utils.Advanced.Experimental;
using n49 = _CoreLibBasics_.Math.Generic;
using n61 = _CoreLibBasics_.Math.Adaptive;
using n48 = _VL_Stride_Rendering_TextureFX_.Stride.Textures.Source;
using n62 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n27 = _VL_Stride_Graphics_.Stride.Textures.Utils.Advanced;
using n20 = _VL_Stride_Rendering_ShaderFX_.Stride.Rendering.ShaderFX.Operations.Experimental;
using n55 = _CoreLibBasics_.Animation;
using n45 = _CoreLibBasics_.Primitive.Boolean;
using n59 = e3::VL.Lib.Primitive;
using n14 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n51 = e24::Stride.Engine;
using n42 = e3::VL.Lib.Mathematics;
using n52 = e25::Stride.Games;
using n37 = _VL_Stride_Rendering_ShaderFX_.Stride.Rendering.ShaderFX.Variables.Advanced.Experimental;
using n1 = e2::VL.Core;
using n34 = e31::VL.Stride.Rendering;
using n7 = e22::Stride.Graphics;
using n2 = global::System;
using n43 = _CoreLibBasics_.Primitive.Int2;
using n6 = e4::Stride.Core.Mathematics;
using n50 = e23::Stride.Core.Serialization.Contents;
using n12 = e29::Stride.Rendering.Images.FXAAEffect;
using n30 = _VL_Stride_Graphics_.Stride.Textures;
using n25 = e3::VL.Lib.Primitive.Object;
using n4 = e2::VL.Core.CompilerServices;
using n40 = e31::VL.Stride.Shaders.ShaderFX.Control;
using n3 = _VL_Stride_Rendering_TextureFX_.Stride.Textures.Filter.Experimental;
using n18 = _VL_Stride_Rendering_TextureFX_.Stride.Textures.Mixer;
using n22 = _VL_Collections_.Collections.Mutable.MutableArray.Advanced;
using n46 = _VL_Stride_Rendering_.Stride.Textures;
using n17 = e31::VL.Stride.Effects.TextureFX;
using n54 = e2::VL.Lib.Animation;
using n41 = _VL_Stride_Rendering_TextureFX_.Stride.Textures.Utils;
using n23 = e29::Stride.Rendering;
using n39 = _VL_Collections_.Collections.Sequence;
using n10 = global::System.Runtime.CompilerServices;
using n15 = _VL_Stride_Rendering_TextureFX_.Stride.Textures.Filter;
using n33 = _VL_Collections_.Collections.Spread;
using n58 = _CoreLibBasics_.Primitive.Advanced;
using n38 = e29::Stride.Rendering.Materials;
using n36 = _CoreLibBasics_._3D.Vector4;

namespace _VL_Stride_Rendering_TextureFX_.Stride.Textures.Filter.Experimental
{
    [n1.ElementAttribute(TracingId = 25070U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "Oe7tegq1obkONdqlU5NVZG", Name = "BrightFilter_Oe7tegq1obkONdqlU5NVZG")]
    [n2.SerializableAttribute]
    public class BrightFilter_Oe7tegq1obkONdqlU5NVZG : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.BrightFilter_Oe7tegq1obkONdqlU5NVZG Create(n1.NodeContext Node_Context)
        {
            var instance = new BrightFilter_Oe7tegq1obkONdqlU5NVZG(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.BrightFilter_Oe7tegq1obkONdqlU5NVZG CreateDefault()
        {
            var instance = new BrightFilter_Oe7tegq1obkONdqlU5NVZG(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.BrightFilter_Oe7tegq1obkONdqlU5NVZG Update([n4.SerializedDefaultValueAttribute("True", false)] bool Auto_Draw_In, n7.Texture Input_In, n6.Int2 Size_In, [n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat New_Format_In, n6.Color4 Color_In, [n4.SerializedDefaultValueAttribute("0.2", false)] float Threshold_In, [n4.SerializedDefaultValueAttribute("1", false)] float Steepness_In, out n7.Texture Output_Out, out n8.TextureFXDrawer_C Renderer_Out)
        {
            n5.BrightFilter __auto_0 = this.Effect;
            var Result_1 = (n6.Color3)Color_In;
            __auto_0.Color = Result_1;
            __auto_0.Threshold = Threshold_In;
            __auto_0.Steepness = Steepness_In;
            n5.IImageEffect Image_Effect_2 = (n5.IImageEffect)__auto_0;
            var State_Output_5 = this.__p_NWdhRxTy4yJQdY9Ren4RC0.Update(Image_Effect_In: Image_Effect_2, Auto_Draw_In: Auto_Draw_In, Input_In: Input_In, Size_In: Size_In, New_Format_In: New_Format_In, Output_Out: out n7.Texture Output_3, Renderer_Out: out n8.TextureFXDrawer_C Renderer_4);
            Output_Out = Output_3;
            Renderer_Out = Renderer_4;
            n3.BrightFilter_Oe7tegq1obkONdqlU5NVZG that_6 = this;
            if (this.__GetContext__().IsImmutable)
                that_6 = State_Output_5 != this.__p_NWdhRxTy4yJQdY9Ren4RC0 ? new BrightFilter_Oe7tegq1obkONdqlU5NVZG(this)
                {__p_NWdhRxTy4yJQdY9Ren4RC0 = State_Output_5} : that_6;
            else
            {
                this.__p_NWdhRxTy4yJQdY9Ren4RC0 = State_Output_5;
            }

            return that_6;
        }

        public n3.BrightFilter_Oe7tegq1obkONdqlU5NVZG __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n5.BrightFilter();
            n5.BrightFilter __auto_1 = Output_0;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "NWdhRxTy4yJQdY9Ren4RC0", 29439U);
            var Output_3 = n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb.Create(Node_Context: Node_Context_2);
            n3.BrightFilter_Oe7tegq1obkONdqlU5NVZG that_4 = this;
            this.Effect = Output_0;
            this.__p_NWdhRxTy4yJQdY9Ren4RC0 = Output_3;
            return that_4;
        }

        public n3.BrightFilter_Oe7tegq1obkONdqlU5NVZG __CreateDefault__()
        {
            n3.BrightFilter_Oe7tegq1obkONdqlU5NVZG that_0 = this;
            this.Effect = default(n5.BrightFilter);
            this.__p_NWdhRxTy4yJQdY9Ren4RC0 = n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_NWdhRxTy4yJQdY9Ren4RC0);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 29420U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "Jf4xN2317bKNJuZJr65D1m", Name = "Effect")]
        public n5.BrightFilter Effect;
        [n1.ElementAttribute(TracingId = 29439U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "NWdhRxTy4yJQdY9Ren4RC0", Name = "TextureFXBase", IsManaged = true, IsAutoGenerated = true)]
        public n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb __p_NWdhRxTy4yJQdY9Ren4RC0;
        public BrightFilter_Oe7tegq1obkONdqlU5NVZG(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal BrightFilter_Oe7tegq1obkONdqlU5NVZG(BrightFilter_Oe7tegq1obkONdqlU5NVZG other): base(other)
        {
            this.Effect = other.Effect;
            this.__p_NWdhRxTy4yJQdY9Ren4RC0 = other.__p_NWdhRxTy4yJQdY9Ren4RC0;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Effect", in Effect), n1.CompilationHelper.GetValueOrExisting(values, "__p_NWdhRxTy4yJQdY9Ren4RC0", in __p_NWdhRxTy4yJQdY9Ren4RC0));
        }

        internal BrightFilter_Oe7tegq1obkONdqlU5NVZG __WITH__(n5.BrightFilter Effect, n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb __p_NWdhRxTy4yJQdY9Ren4RC0)
        {
            n3.BrightFilter_Oe7tegq1obkONdqlU5NVZG that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Effect != this.Effect || __p_NWdhRxTy4yJQdY9Ren4RC0 != this.__p_NWdhRxTy4yJQdY9Ren4RC0 ? new BrightFilter_Oe7tegq1obkONdqlU5NVZG(this)
                {Effect = Effect, __p_NWdhRxTy4yJQdY9Ren4RC0 = __p_NWdhRxTy4yJQdY9Ren4RC0} : that_0;
            else
            {
                this.Effect = Effect;
                this.__p_NWdhRxTy4yJQdY9Ren4RC0 = __p_NWdhRxTy4yJQdY9Ren4RC0;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 29473U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "IDPuh5sP2lXNbcfVcVbXdB", Name = "FXAA_IDPuh5sP2lXNbcfVcVbXdB")]
    [n2.SerializableAttribute]
    public class FXAA_IDPuh5sP2lXNbcfVcVbXdB : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.FXAA_IDPuh5sP2lXNbcfVcVbXdB Create(n1.NodeContext Node_Context)
        {
            var instance = new FXAA_IDPuh5sP2lXNbcfVcVbXdB(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.FXAA_IDPuh5sP2lXNbcfVcVbXdB CreateDefault()
        {
            var instance = new FXAA_IDPuh5sP2lXNbcfVcVbXdB(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.FXAA_IDPuh5sP2lXNbcfVcVbXdB Update([n4.SerializedDefaultValueAttribute("True", false)] bool Auto_Draw_In, n7.Texture Input_In, n6.Int2 Size_In, [n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat New_Format_In, [n4.SerializedDefaultValueAttribute("Medium", false)] n12.DitherType Dither_Type_In, bool Input_Luminance_Alpha_In, [n4.SerializedDefaultValueAttribute("3", false)] int Quality_In, out n7.Texture Output_Out, out n8.TextureFXDrawer_C Renderer_Out)
        {
            n5.FXAAEffect __auto_0 = this.Effect;
            n12.DitherType __pad_Khk7xsy5GGqLQWEveXplF6_1 = __slot_Khk7xsy5GGqLQWEveXplF6;
            n12.DitherType __pad_KfN10MqqV0KQMVt486nLVh_2 = __slot_KfN10MqqV0KQMVt486nLVh;
            n12.DitherType __pad_GYbIDAIrYlJNn5ZzNPHN9T_3 = __slot_GYbIDAIrYlJNn5ZzNPHN9T;
            __auto_0.Dither = Dither_Type_In;
            __auto_0.InputLuminanceInAlpha = Input_Luminance_Alpha_In;
            var Result_4 = Dither_Type_In == __pad_Khk7xsy5GGqLQWEveXplF6_1;
            int __auto_5;
            if (Result_4)
            {
                int __pad_H54dmGWPMkwP1FxcR6Jr6M_7 = __slot_H54dmGWPMkwP1FxcR6Jr6M;
                __auto_5 = __pad_H54dmGWPMkwP1FxcR6Jr6M_7;
            }
            else
            {
                __auto_5 = Quality_In;
            }

            var Result_8 = Dither_Type_In == __pad_KfN10MqqV0KQMVt486nLVh_2;
            int __auto_9;
            if (Result_8)
            {
                int __pad_KZ54Kur2qozOZ5lciGceLX_11 = __slot_KZ54Kur2qozOZ5lciGceLX;
                int Minimum_12 = 0;
                n14._Operations_.Clamp<int, n13.__AdaptiveImplementations__BzGvoB2aLhzP7WO4jVw5sI>(Input_In: __auto_5, Minimum_In: Minimum_12, Maximum_In: __pad_KZ54Kur2qozOZ5lciGceLX_11, Output_Out: out int Output_13);
                __auto_9 = Output_13;
            }
            else
            {
                __auto_9 = __auto_5;
            }

            var Result_14 = Dither_Type_In == __pad_GYbIDAIrYlJNn5ZzNPHN9T_3;
            int __auto_15;
            if (Result_14)
            {
                int __pad_PhdEo7bNJymN3e2avPapIo_17 = __slot_PhdEo7bNJymN3e2avPapIo;
                int Minimum_18 = 0;
                n14._Operations_.Clamp<int, n13.__AdaptiveImplementations__BzGvoB2aLhzP7WO4jVw5sI>(Input_In: __auto_9, Minimum_In: Minimum_18, Maximum_In: __pad_PhdEo7bNJymN3e2avPapIo_17, Output_Out: out int Output_19);
                __auto_15 = Output_19;
            }
            else
            {
                __auto_15 = __auto_9;
            }

            __auto_0.Quality = __auto_15;
            n5.IImageEffect Image_Effect_20 = (n5.IImageEffect)__auto_0;
            var State_Output_23 = this.__p_QOtJ05Cgg2yMCpKk8OcPLF.Update(Image_Effect_In: Image_Effect_20, Auto_Draw_In: Auto_Draw_In, Input_In: Input_In, Size_In: Size_In, New_Format_In: New_Format_In, Output_Out: out n7.Texture Output_21, Renderer_Out: out n8.TextureFXDrawer_C Renderer_22);
            Output_Out = Output_21;
            Renderer_Out = Renderer_22;
            n3.FXAA_IDPuh5sP2lXNbcfVcVbXdB that_24 = this;
            if (this.__GetContext__().IsImmutable)
                that_24 = State_Output_23 != this.__p_QOtJ05Cgg2yMCpKk8OcPLF ? new FXAA_IDPuh5sP2lXNbcfVcVbXdB(this)
                {__p_QOtJ05Cgg2yMCpKk8OcPLF = State_Output_23} : that_24;
            else
            {
                this.__p_QOtJ05Cgg2yMCpKk8OcPLF = State_Output_23;
            }

            return that_24;
        }

        public n3.FXAA_IDPuh5sP2lXNbcfVcVbXdB __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n5.FXAAEffect();
            n5.FXAAEffect __auto_1 = Output_0;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "QOtJ05Cgg2yMCpKk8OcPLF", 29625U);
            var Output_3 = n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb.Create(Node_Context: Node_Context_2);
            n3.FXAA_IDPuh5sP2lXNbcfVcVbXdB that_4 = this;
            this.Effect = Output_0;
            this.__p_QOtJ05Cgg2yMCpKk8OcPLF = Output_3;
            return that_4;
        }

        public n3.FXAA_IDPuh5sP2lXNbcfVcVbXdB __CreateDefault__()
        {
            n3.FXAA_IDPuh5sP2lXNbcfVcVbXdB that_0 = this;
            this.Effect = default(n5.FXAAEffect);
            this.__p_QOtJ05Cgg2yMCpKk8OcPLF = n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_QOtJ05Cgg2yMCpKk8OcPLF);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 29499U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "Khk7xsy5GGqLQWEveXplF6", Name = "__slot_Khk7xsy5GGqLQWEveXplF6")]
        public static n12.DitherType __slot_Khk7xsy5GGqLQWEveXplF6 = n1.CompilationHelper.Deserialize<n12.DitherType>("None", false, "BzGvoB2aLhzP7WO4jVw5sI", "Khk7xsy5GGqLQWEveXplF6");
        [n1.ElementAttribute(TracingId = 29552U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "KfN10MqqV0KQMVt486nLVh", Name = "__slot_KfN10MqqV0KQMVt486nLVh")]
        public static n12.DitherType __slot_KfN10MqqV0KQMVt486nLVh = n1.CompilationHelper.Deserialize<n12.DitherType>("Medium", false, "BzGvoB2aLhzP7WO4jVw5sI", "KfN10MqqV0KQMVt486nLVh");
        [n1.ElementAttribute(TracingId = 29621U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "GYbIDAIrYlJNn5ZzNPHN9T", Name = "__slot_GYbIDAIrYlJNn5ZzNPHN9T")]
        public static n12.DitherType __slot_GYbIDAIrYlJNn5ZzNPHN9T = n1.CompilationHelper.Deserialize<n12.DitherType>("Low", false, "BzGvoB2aLhzP7WO4jVw5sI", "GYbIDAIrYlJNn5ZzNPHN9T");
        [n1.ElementAttribute(TracingId = 29477U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "GIq92m8YLP6MkIHf3Qt2Hg", Name = "Effect")]
        public n5.FXAAEffect Effect;
        [n1.ElementAttribute(TracingId = 29505U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "H54dmGWPMkwP1FxcR6Jr6M", Name = "__slot_H54dmGWPMkwP1FxcR6Jr6M")]
        public static int __slot_H54dmGWPMkwP1FxcR6Jr6M = 9;
        [n1.ElementAttribute(TracingId = 29520U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "KZ54Kur2qozOZ5lciGceLX", Name = "__slot_KZ54Kur2qozOZ5lciGceLX")]
        public static int __slot_KZ54Kur2qozOZ5lciGceLX = 5;
        [n1.ElementAttribute(TracingId = 29570U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "PhdEo7bNJymN3e2avPapIo", Name = "__slot_PhdEo7bNJymN3e2avPapIo")]
        public static int __slot_PhdEo7bNJymN3e2avPapIo = 9;
        [n1.ElementAttribute(TracingId = 29625U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "QOtJ05Cgg2yMCpKk8OcPLF", Name = "TextureFXBase", IsManaged = true, IsAutoGenerated = true)]
        public n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb __p_QOtJ05Cgg2yMCpKk8OcPLF;
        static FXAA_IDPuh5sP2lXNbcfVcVbXdB()
        {
        }

        public FXAA_IDPuh5sP2lXNbcfVcVbXdB(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FXAA_IDPuh5sP2lXNbcfVcVbXdB(FXAA_IDPuh5sP2lXNbcfVcVbXdB other): base(other)
        {
            this.Effect = other.Effect;
            this.__p_QOtJ05Cgg2yMCpKk8OcPLF = other.__p_QOtJ05Cgg2yMCpKk8OcPLF;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Effect", in Effect), n1.CompilationHelper.GetValueOrExisting(values, "__p_QOtJ05Cgg2yMCpKk8OcPLF", in __p_QOtJ05Cgg2yMCpKk8OcPLF));
        }

        internal FXAA_IDPuh5sP2lXNbcfVcVbXdB __WITH__(n5.FXAAEffect Effect, n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb __p_QOtJ05Cgg2yMCpKk8OcPLF)
        {
            n3.FXAA_IDPuh5sP2lXNbcfVcVbXdB that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Effect != this.Effect || __p_QOtJ05Cgg2yMCpKk8OcPLF != this.__p_QOtJ05Cgg2yMCpKk8OcPLF ? new FXAA_IDPuh5sP2lXNbcfVcVbXdB(this)
                {Effect = Effect, __p_QOtJ05Cgg2yMCpKk8OcPLF = __p_QOtJ05Cgg2yMCpKk8OcPLF} : that_0;
            else
            {
                this.Effect = Effect;
                this.__p_QOtJ05Cgg2yMCpKk8OcPLF = __p_QOtJ05Cgg2yMCpKk8OcPLF;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 29786U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "HwlDvBwIe1hNuaDhyskust", Name = "GaussianBlur_HwlDvBwIe1hNuaDhyskust")]
    [n2.SerializableAttribute]
    public class GaussianBlur_HwlDvBwIe1hNuaDhyskust : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.GaussianBlur_HwlDvBwIe1hNuaDhyskust Create(n1.NodeContext Node_Context)
        {
            var instance = new GaussianBlur_HwlDvBwIe1hNuaDhyskust(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.GaussianBlur_HwlDvBwIe1hNuaDhyskust CreateDefault()
        {
            var instance = new GaussianBlur_HwlDvBwIe1hNuaDhyskust(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.GaussianBlur_HwlDvBwIe1hNuaDhyskust Update(n7.Texture Input_In, n6.Int2 Size_In, [n4.SerializedDefaultValueAttribute("10", false)] int Radius_In, [n4.SerializedDefaultValueAttribute("3", false)] float Sigma_Ratio_In, [n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat New_Format_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Auto_Draw_In, out n7.Texture Output_Out, out n8.TextureFXDrawer_C Renderer_Out)
        {
            n5.GaussianBlur __auto_0 = this.Effect;
            int Input_2_1 = 1;
            n14._Operations_.Max<int, n13.__AdaptiveImplementations__BzGvoB2aLhzP7WO4jVw5sI>(Input_In: Radius_In, Input_2_In: Input_2_1, Output_Out: out int Output_2);
            __auto_0.Radius = Output_2;
            __auto_0.SigmaRatio = Sigma_Ratio_In;
            n5.IImageEffect Image_Effect_3 = (n5.IImageEffect)__auto_0;
            var State_Output_6 = this.__p_RNwjLWJSTSnMhyyKu7x5Rf.Update(Image_Effect_In: Image_Effect_3, Auto_Draw_In: Auto_Draw_In, Input_In: Input_In, Size_In: Size_In, New_Format_In: New_Format_In, Output_Out: out n7.Texture Output_4, Renderer_Out: out n8.TextureFXDrawer_C Renderer_5);
            Output_Out = Output_4;
            Renderer_Out = Renderer_5;
            n3.GaussianBlur_HwlDvBwIe1hNuaDhyskust that_7 = this;
            if (this.__GetContext__().IsImmutable)
                that_7 = State_Output_6 != this.__p_RNwjLWJSTSnMhyyKu7x5Rf ? new GaussianBlur_HwlDvBwIe1hNuaDhyskust(this)
                {__p_RNwjLWJSTSnMhyyKu7x5Rf = State_Output_6} : that_7;
            else
            {
                this.__p_RNwjLWJSTSnMhyyKu7x5Rf = State_Output_6;
            }

            return that_7;
        }

        public n3.GaussianBlur_HwlDvBwIe1hNuaDhyskust __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n5.GaussianBlur();
            n5.GaussianBlur __auto_1 = Output_0;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "RNwjLWJSTSnMhyyKu7x5Rf", 29811U);
            var Output_3 = n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb.Create(Node_Context: Node_Context_2);
            n3.GaussianBlur_HwlDvBwIe1hNuaDhyskust that_4 = this;
            this.Effect = Output_0;
            this.__p_RNwjLWJSTSnMhyyKu7x5Rf = Output_3;
            return that_4;
        }

        public n3.GaussianBlur_HwlDvBwIe1hNuaDhyskust __CreateDefault__()
        {
            n3.GaussianBlur_HwlDvBwIe1hNuaDhyskust that_0 = this;
            this.Effect = default(n5.GaussianBlur);
            this.__p_RNwjLWJSTSnMhyyKu7x5Rf = n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_RNwjLWJSTSnMhyyKu7x5Rf);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 29799U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "GU2AkDUFqH3NMFN3hhFAyJ", Name = "Effect")]
        public n5.GaussianBlur Effect;
        [n1.ElementAttribute(TracingId = 29811U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "RNwjLWJSTSnMhyyKu7x5Rf", Name = "TextureFXBase", IsManaged = true, IsAutoGenerated = true)]
        public n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb __p_RNwjLWJSTSnMhyyKu7x5Rf;
        public GaussianBlur_HwlDvBwIe1hNuaDhyskust(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GaussianBlur_HwlDvBwIe1hNuaDhyskust(GaussianBlur_HwlDvBwIe1hNuaDhyskust other): base(other)
        {
            this.Effect = other.Effect;
            this.__p_RNwjLWJSTSnMhyyKu7x5Rf = other.__p_RNwjLWJSTSnMhyyKu7x5Rf;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Effect", in Effect), n1.CompilationHelper.GetValueOrExisting(values, "__p_RNwjLWJSTSnMhyyKu7x5Rf", in __p_RNwjLWJSTSnMhyyKu7x5Rf));
        }

        internal GaussianBlur_HwlDvBwIe1hNuaDhyskust __WITH__(n5.GaussianBlur Effect, n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb __p_RNwjLWJSTSnMhyyKu7x5Rf)
        {
            n3.GaussianBlur_HwlDvBwIe1hNuaDhyskust that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Effect != this.Effect || __p_RNwjLWJSTSnMhyyKu7x5Rf != this.__p_RNwjLWJSTSnMhyyKu7x5Rf ? new GaussianBlur_HwlDvBwIe1hNuaDhyskust(this)
                {Effect = Effect, __p_RNwjLWJSTSnMhyyKu7x5Rf = __p_RNwjLWJSTSnMhyyKu7x5Rf} : that_0;
            else
            {
                this.Effect = Effect;
                this.__p_RNwjLWJSTSnMhyyKu7x5Rf = __p_RNwjLWJSTSnMhyyKu7x5Rf;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 29935U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "HB0NfEHHDypNbgKEAZZGL8", Name = "Bloom_HB0NfEHHDypNbgKEAZZGL8")]
    [n2.SerializableAttribute]
    public class Bloom_HB0NfEHHDypNbgKEAZZGL8 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.Bloom_HB0NfEHHDypNbgKEAZZGL8 Create(n1.NodeContext Node_Context)
        {
            var instance = new Bloom_HB0NfEHHDypNbgKEAZZGL8(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.Bloom_HB0NfEHHDypNbgKEAZZGL8 CreateDefault()
        {
            var instance = new Bloom_HB0NfEHHDypNbgKEAZZGL8(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.Bloom_HB0NfEHHDypNbgKEAZZGL8 Update([n4.SerializedDefaultValueAttribute("True", false)] bool Auto_Draw_In, n7.Texture Input_In, n6.Int2 Size_In, [n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat New_Format_In, [n4.SerializedDefaultValueAttribute("0.25", false)] float Amount_In, int Mip_Index_In, n6.Vector2 Distortion_In, float Radius_In, bool Show_Only_Bloom_In, bool Show_Only_Mip_In, float Sigma_Ratio_In, bool Stable_Convolution_In, out n7.Texture Output_Out, out n8.TextureFXDrawer_C Renderer_Out)
        {
            n5.Bloom __auto_0 = this.Effect;
            __auto_0.Amount = Amount_In;
            __auto_0.Distortion = Distortion_In;
            __auto_0.MipIndex = Mip_Index_In;
            __auto_0.Radius = Radius_In;
            __auto_0.ShowOnlyBloom = Show_Only_Bloom_In;
            __auto_0.ShowOnlyMip = Show_Only_Mip_In;
            __auto_0.SigmaRatio = Sigma_Ratio_In;
            __auto_0.StableConvolution = Stable_Convolution_In;
            n5.IImageEffect Image_Effect_1 = (n5.IImageEffect)__auto_0;
            var State_Output_4 = this.__p_GgXiR3hbpIaL0Oell29pmm.Update(Image_Effect_In: Image_Effect_1, Auto_Draw_In: Auto_Draw_In, Input_In: Input_In, Size_In: Size_In, New_Format_In: New_Format_In, Output_Out: out n7.Texture Output_2, Renderer_Out: out n8.TextureFXDrawer_C Renderer_3);
            Output_Out = Output_2;
            Renderer_Out = Renderer_3;
            n3.Bloom_HB0NfEHHDypNbgKEAZZGL8 that_5 = this;
            if (this.__GetContext__().IsImmutable)
                that_5 = State_Output_4 != this.__p_GgXiR3hbpIaL0Oell29pmm ? new Bloom_HB0NfEHHDypNbgKEAZZGL8(this)
                {__p_GgXiR3hbpIaL0Oell29pmm = State_Output_4} : that_5;
            else
            {
                this.__p_GgXiR3hbpIaL0Oell29pmm = State_Output_4;
            }

            return that_5;
        }

        public n3.Bloom_HB0NfEHHDypNbgKEAZZGL8 __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var Output_0 = new n5.Bloom();
            n5.Bloom __auto_1 = Output_0;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "GgXiR3hbpIaL0Oell29pmm", 29975U);
            var Output_3 = n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb.Create(Node_Context: Node_Context_2);
            n3.Bloom_HB0NfEHHDypNbgKEAZZGL8 that_4 = this;
            this.Effect = Output_0;
            this.__p_GgXiR3hbpIaL0Oell29pmm = Output_3;
            return that_4;
        }

        public n3.Bloom_HB0NfEHHDypNbgKEAZZGL8 __CreateDefault__()
        {
            n3.Bloom_HB0NfEHHDypNbgKEAZZGL8 that_0 = this;
            this.Effect = default(n5.Bloom);
            this.__p_GgXiR3hbpIaL0Oell29pmm = n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_GgXiR3hbpIaL0Oell29pmm);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 29950U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "IhKOylwxsd7Lk62G1GKo6B", Name = "Effect")]
        public n5.Bloom Effect;
        [n1.ElementAttribute(TracingId = 29975U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "GgXiR3hbpIaL0Oell29pmm", Name = "TextureFXBase", IsManaged = true, IsAutoGenerated = true)]
        public n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb __p_GgXiR3hbpIaL0Oell29pmm;
        public Bloom_HB0NfEHHDypNbgKEAZZGL8(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Bloom_HB0NfEHHDypNbgKEAZZGL8(Bloom_HB0NfEHHDypNbgKEAZZGL8 other): base(other)
        {
            this.Effect = other.Effect;
            this.__p_GgXiR3hbpIaL0Oell29pmm = other.__p_GgXiR3hbpIaL0Oell29pmm;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Effect", in Effect), n1.CompilationHelper.GetValueOrExisting(values, "__p_GgXiR3hbpIaL0Oell29pmm", in __p_GgXiR3hbpIaL0Oell29pmm));
        }

        internal Bloom_HB0NfEHHDypNbgKEAZZGL8 __WITH__(n5.Bloom Effect, n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb __p_GgXiR3hbpIaL0Oell29pmm)
        {
            n3.Bloom_HB0NfEHHDypNbgKEAZZGL8 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Effect != this.Effect || __p_GgXiR3hbpIaL0Oell29pmm != this.__p_GgXiR3hbpIaL0Oell29pmm ? new Bloom_HB0NfEHHDypNbgKEAZZGL8(this)
                {Effect = Effect, __p_GgXiR3hbpIaL0Oell29pmm = __p_GgXiR3hbpIaL0Oell29pmm} : that_0;
            else
            {
                this.Effect = Effect;
                this.__p_GgXiR3hbpIaL0Oell29pmm = __p_GgXiR3hbpIaL0Oell29pmm;
            }

            return that_0;
        }
    }
}

namespace _VL_Stride_Rendering_TextureFX_.Stride.Textures.Filter
{
    [n1.ElementAttribute(TracingId = 30219U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "JQMxtk4r0EVPNzXMfWWGlS", Name = "DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS")]
    [n2.SerializableAttribute]
    public class DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n15.DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS Create(n1.NodeContext Node_Context)
        {
            var instance = new DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n15.DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS CreateDefault()
        {
            var instance = new DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n15.DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS Update(n7.Texture Input_In, n16.SetVar<float> Strength_In, [n4.SerializedDefaultValueAttribute("0.25, 0", false)] n6.Vector2 Direction_In, [n4.SerializedDefaultValueAttribute("0.5, 0.5", false)] n6.Vector2 Sample_Center_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Aspect_In, n16.SetVar<n6.Vector4> Control_In, n7.Texture Output_Texture_In, [n4.SerializedDefaultValueAttribute("0, 0", false)] n6.Int2 Output_Size_In, [n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat Output_Format_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In, out n7.Texture Output_Out)
        {
            n1.CompilationHelper.WritePin(this.__p_Glj4lPui8hmPh4keuUClgN.Inputs[0], ref Input_In);
            n1.CompilationHelper.WritePin(this.__p_Glj4lPui8hmPh4keuUClgN.Inputs[2], ref Direction_In);
            n1.CompilationHelper.WritePin(this.__p_Glj4lPui8hmPh4keuUClgN.Inputs[3], ref Sample_Center_In);
            n1.CompilationHelper.WritePin(this.__p_Glj4lPui8hmPh4keuUClgN.Inputs[4], ref Aspect_In);
            n1.CompilationHelper.WritePin(this.__p_Glj4lPui8hmPh4keuUClgN.Inputs[5], ref Strength_In);
            n1.CompilationHelper.WritePin(this.__p_Glj4lPui8hmPh4keuUClgN.Inputs[6], ref Control_In);
            n1.CompilationHelper.WritePin(this.__p_Glj4lPui8hmPh4keuUClgN.Inputs[7], ref Output_Texture_In);
            n1.CompilationHelper.WritePin(this.__p_Glj4lPui8hmPh4keuUClgN.Inputs[8], ref Output_Size_In);
            n1.CompilationHelper.WritePin(this.__p_Glj4lPui8hmPh4keuUClgN.Inputs[9], ref Output_Format_In);
            n1.CompilationHelper.WritePin(this.__p_Glj4lPui8hmPh4keuUClgN.Inputs[11], ref Apply_In);
            n1.CompilationHelper.ReadPin(this.__p_Glj4lPui8hmPh4keuUClgN.Outputs[0], out n7.Texture out_0);
            n1.CompilationHelper.WritePin(this.__p_JcUmVRZpdzPLSZswJjO39e.Inputs[0], ref out_0);
            n1.CompilationHelper.WritePin(this.__p_JcUmVRZpdzPLSZswJjO39e.Inputs[2], ref Direction_In);
            n1.CompilationHelper.WritePin(this.__p_JcUmVRZpdzPLSZswJjO39e.Inputs[3], ref Sample_Center_In);
            n1.CompilationHelper.WritePin(this.__p_JcUmVRZpdzPLSZswJjO39e.Inputs[4], ref Aspect_In);
            n1.CompilationHelper.WritePin(this.__p_JcUmVRZpdzPLSZswJjO39e.Inputs[5], ref Strength_In);
            n1.CompilationHelper.WritePin(this.__p_JcUmVRZpdzPLSZswJjO39e.Inputs[6], ref Control_In);
            n1.CompilationHelper.WritePin(this.__p_JcUmVRZpdzPLSZswJjO39e.Inputs[7], ref Output_Texture_In);
            n1.CompilationHelper.WritePin(this.__p_JcUmVRZpdzPLSZswJjO39e.Inputs[8], ref Output_Size_In);
            n1.CompilationHelper.WritePin(this.__p_JcUmVRZpdzPLSZswJjO39e.Inputs[9], ref Output_Format_In);
            n1.CompilationHelper.WritePin(this.__p_JcUmVRZpdzPLSZswJjO39e.Inputs[11], ref Apply_In);
            n1.CompilationHelper.ReadPin(this.__p_JcUmVRZpdzPLSZswJjO39e.Outputs[0], out n7.Texture out_1);
            Output_Out = out_1;
            n15.DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = this.__p_Glj4lPui8hmPh4keuUClgN != this.__p_Glj4lPui8hmPh4keuUClgN || this.__p_JcUmVRZpdzPLSZswJjO39e != this.__p_JcUmVRZpdzPLSZswJjO39e ? new DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS(this)
                {__p_Glj4lPui8hmPh4keuUClgN = this.__p_Glj4lPui8hmPh4keuUClgN, __p_JcUmVRZpdzPLSZswJjO39e = this.__p_JcUmVRZpdzPLSZswJjO39e} : that_2;
            else
            {
                this.__p_Glj4lPui8hmPh4keuUClgN = this.__p_Glj4lPui8hmPh4keuUClgN;
                this.__p_JcUmVRZpdzPLSZswJjO39e = this.__p_JcUmVRZpdzPLSZswJjO39e;
            }

            return that_2;
        }

        public n15.DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "DirectionalBlur (Pass0 Internal)", "Stride.Textures.Filter");
            var node_1 = n1.CompilationHelper.CreateNodeById(Node_Context, "DirectionalBlur (Pass1 Internal)", "Stride.Textures.Filter");
            n15.DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS that_2 = this;
            this.__p_Glj4lPui8hmPh4keuUClgN = node_0;
            this.__p_JcUmVRZpdzPLSZswJjO39e = node_1;
            return that_2;
        }

        public n15.DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS __CreateDefault__()
        {
            n15.DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS that_0 = this;
            this.__p_Glj4lPui8hmPh4keuUClgN = default(n1.IVLNode);
            this.__p_JcUmVRZpdzPLSZswJjO39e = default(n1.IVLNode);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Glj4lPui8hmPh4keuUClgN);
            n1.CompilationHelper.SafeDispose(this.__p_JcUmVRZpdzPLSZswJjO39e);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 30224U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "Glj4lPui8hmPh4keuUClgN", Name = "DirectionalBlur (Pass0)", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectionalBlur (Pass0 Internal)", NodeCategory = "Stride.Textures.Filter")]
        public n1.IVLNode __p_Glj4lPui8hmPh4keuUClgN;
        [n1.ElementAttribute(TracingId = 30259U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "JcUmVRZpdzPLSZswJjO39e", Name = "DirectionalBlur (Pass1)", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectionalBlur (Pass1 Internal)", NodeCategory = "Stride.Textures.Filter")]
        public n1.IVLNode __p_JcUmVRZpdzPLSZswJjO39e;
        public DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS(DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS other): base(other)
        {
            this.__p_Glj4lPui8hmPh4keuUClgN = other.__p_Glj4lPui8hmPh4keuUClgN;
            this.__p_JcUmVRZpdzPLSZswJjO39e = other.__p_JcUmVRZpdzPLSZswJjO39e;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Glj4lPui8hmPh4keuUClgN", in __p_Glj4lPui8hmPh4keuUClgN), n1.CompilationHelper.GetValueOrExisting(values, "__p_JcUmVRZpdzPLSZswJjO39e", in __p_JcUmVRZpdzPLSZswJjO39e));
        }

        internal DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS __WITH__(n1.IVLNode __p_Glj4lPui8hmPh4keuUClgN, n1.IVLNode __p_JcUmVRZpdzPLSZswJjO39e)
        {
            n15.DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Glj4lPui8hmPh4keuUClgN != this.__p_Glj4lPui8hmPh4keuUClgN || __p_JcUmVRZpdzPLSZswJjO39e != this.__p_JcUmVRZpdzPLSZswJjO39e ? new DirectionalBlur_JQMxtk4r0EVPNzXMfWWGlS(this)
                {__p_Glj4lPui8hmPh4keuUClgN = __p_Glj4lPui8hmPh4keuUClgN, __p_JcUmVRZpdzPLSZswJjO39e = __p_JcUmVRZpdzPLSZswJjO39e} : that_0;
            else
            {
                this.__p_Glj4lPui8hmPh4keuUClgN = __p_Glj4lPui8hmPh4keuUClgN;
                this.__p_JcUmVRZpdzPLSZswJjO39e = __p_JcUmVRZpdzPLSZswJjO39e;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 30385U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "Hz2rlbtqlofLP8AQAVPqLb", Name = "Glow_Hz2rlbtqlofLP8AQAVPqLb")]
    [n2.SerializableAttribute]
    public class Glow_Hz2rlbtqlofLP8AQAVPqLb : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n15.Glow_Hz2rlbtqlofLP8AQAVPqLb Create(n1.NodeContext Node_Context)
        {
            var instance = new Glow_Hz2rlbtqlofLP8AQAVPqLb(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n15.Glow_Hz2rlbtqlofLP8AQAVPqLb CreateDefault()
        {
            var instance = new Glow_Hz2rlbtqlofLP8AQAVPqLb(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n15.Glow_Hz2rlbtqlofLP8AQAVPqLb Update(n7.Texture Input_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Always_Generate_Mips_for_Input_In, [n4.SerializedDefaultValueAttribute("1", false)] float Amount_In, [n4.SerializedDefaultValueAttribute("0", false)] float Shape_In, [n4.SerializedDefaultValueAttribute("0", false)] float Highlight_Boost_In, [n4.SerializedDefaultValueAttribute("1", false)] float Exposure_In, [n4.SerializedDefaultValueAttribute("1", false)] float Saturation_In, [n4.SerializedDefaultValueAttribute("0", false)] float Auto_Exposure_Factor_In, [n4.SerializedDefaultValueAttribute("1", false)] float Max_Radius_In, [n4.SerializedDefaultValueAttribute("8", false)] float Pre_Blur_Width_In, n16.SetVar<n6.Vector4> Control_In, n7.Texture Output_Texture_In, [n4.SerializedDefaultValueAttribute("0, 0", false)] n6.Int2 Output_Size_In, [n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat Render_Format_In, [n4.SerializedDefaultValueAttribute("R8G8B8A8_UNorm_SRgb", false)] n9.PixelFormat Output_Format_In, n7.SamplerState Sampler_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In, out n7.Texture Output_Out)
        {
            n9.PixelFormat __pad_RWW6tG0PIkgPkHbm37l85I_0 = __slot_RWW6tG0PIkgPkHbm37l85I;
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[0], ref Input_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[1], ref Always_Generate_Mips_for_Input_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[2], ref Sampler_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[3], ref Amount_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[4], ref Shape_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[5], ref Highlight_Boost_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[6], ref Exposure_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[7], ref Saturation_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[8], ref Auto_Exposure_Factor_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[9], ref Max_Radius_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[10], ref Pre_Blur_Width_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[11], ref Control_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[12], ref Output_Texture_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[13], ref Output_Size_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[14], ref __pad_RWW6tG0PIkgPkHbm37l85I_0);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[15], ref Render_Format_In);
            n1.CompilationHelper.WritePin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Inputs[16], ref Apply_In);
            n1.CompilationHelper.ReadPin(this.__p_EY9kx6KXSElPMQjJVhcJWi.Outputs[0], out n7.Texture out_1);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[0], ref out_1);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[1], ref Always_Generate_Mips_for_Input_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[2], ref Sampler_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[3], ref Input_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[4], ref Always_Generate_Mips_for_Input_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[5], ref Sampler_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[6], ref Amount_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[7], ref Shape_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[8], ref Highlight_Boost_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[9], ref Exposure_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[10], ref Saturation_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[11], ref Auto_Exposure_Factor_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[12], ref Max_Radius_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[13], ref Pre_Blur_Width_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[14], ref Control_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[15], ref Output_Texture_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[16], ref Output_Size_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[17], ref __pad_RWW6tG0PIkgPkHbm37l85I_0);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[18], ref Render_Format_In);
            n1.CompilationHelper.WritePin(this.__p_LfGRHN57azpPNlV6sfz4lH.Inputs[19], ref Apply_In);
            n1.CompilationHelper.ReadPin(this.__p_LfGRHN57azpPNlV6sfz4lH.Outputs[0], out n7.Texture out_2);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[0], ref out_2);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[1], ref Always_Generate_Mips_for_Input_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[2], ref Sampler_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[3], ref Input_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[4], ref Sampler_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[5], ref Amount_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[6], ref Shape_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[7], ref Highlight_Boost_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[8], ref Exposure_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[9], ref Saturation_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[10], ref Auto_Exposure_Factor_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[11], ref Max_Radius_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[12], ref Pre_Blur_Width_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[13], ref Control_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[14], ref Output_Texture_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[15], ref Output_Size_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[16], ref Output_Format_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[17], ref Render_Format_In);
            n1.CompilationHelper.WritePin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Inputs[18], ref Apply_In);
            n1.CompilationHelper.ReadPin(this.__p_M8OpGwcioQXLGa6rfG2nJz.Outputs[0], out n7.Texture out_3);
            Output_Out = out_3;
            n15.Glow_Hz2rlbtqlofLP8AQAVPqLb that_4 = this;
            if (this.__GetContext__().IsImmutable)
                that_4 = this.__p_EY9kx6KXSElPMQjJVhcJWi != this.__p_EY9kx6KXSElPMQjJVhcJWi || this.__p_LfGRHN57azpPNlV6sfz4lH != this.__p_LfGRHN57azpPNlV6sfz4lH || this.__p_M8OpGwcioQXLGa6rfG2nJz != this.__p_M8OpGwcioQXLGa6rfG2nJz ? new Glow_Hz2rlbtqlofLP8AQAVPqLb(this)
                {__p_EY9kx6KXSElPMQjJVhcJWi = this.__p_EY9kx6KXSElPMQjJVhcJWi, __p_LfGRHN57azpPNlV6sfz4lH = this.__p_LfGRHN57azpPNlV6sfz4lH, __p_M8OpGwcioQXLGa6rfG2nJz = this.__p_M8OpGwcioQXLGa6rfG2nJz} : that_4;
            else
            {
                this.__p_EY9kx6KXSElPMQjJVhcJWi = this.__p_EY9kx6KXSElPMQjJVhcJWi;
                this.__p_LfGRHN57azpPNlV6sfz4lH = this.__p_LfGRHN57azpPNlV6sfz4lH;
                this.__p_M8OpGwcioQXLGa6rfG2nJz = this.__p_M8OpGwcioQXLGa6rfG2nJz;
            }

            return that_4;
        }

        public n15.Glow_Hz2rlbtqlofLP8AQAVPqLb __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "GlowPre (Internal)", "Stride.Textures.Filter");
            var node_1 = n1.CompilationHelper.CreateNodeById(Node_Context, "GlowMain (Internal)", "Stride.Textures.Filter");
            var node_2 = n1.CompilationHelper.CreateNodeById(Node_Context, "GlowMix (Internal)", "Stride.Textures.Filter");
            n15.Glow_Hz2rlbtqlofLP8AQAVPqLb that_3 = this;
            this.__p_EY9kx6KXSElPMQjJVhcJWi = node_0;
            this.__p_LfGRHN57azpPNlV6sfz4lH = node_1;
            this.__p_M8OpGwcioQXLGa6rfG2nJz = node_2;
            return that_3;
        }

        public n15.Glow_Hz2rlbtqlofLP8AQAVPqLb __CreateDefault__()
        {
            n15.Glow_Hz2rlbtqlofLP8AQAVPqLb that_0 = this;
            this.__p_EY9kx6KXSElPMQjJVhcJWi = default(n1.IVLNode);
            this.__p_LfGRHN57azpPNlV6sfz4lH = default(n1.IVLNode);
            this.__p_M8OpGwcioQXLGa6rfG2nJz = default(n1.IVLNode);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_EY9kx6KXSElPMQjJVhcJWi);
            n1.CompilationHelper.SafeDispose(this.__p_LfGRHN57azpPNlV6sfz4lH);
            n1.CompilationHelper.SafeDispose(this.__p_M8OpGwcioQXLGa6rfG2nJz);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 30547U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "RWW6tG0PIkgPkHbm37l85I", Name = "__slot_RWW6tG0PIkgPkHbm37l85I")]
        public static n9.PixelFormat __slot_RWW6tG0PIkgPkHbm37l85I = n1.CompilationHelper.Deserialize<n9.PixelFormat>("R16G16B16A16_Float", false, "BzGvoB2aLhzP7WO4jVw5sI", "RWW6tG0PIkgPkHbm37l85I");
        [n1.ElementAttribute(TracingId = 30390U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "EY9kx6KXSElPMQjJVhcJWi", Name = "GlowPre", IsManaged = true, IsAutoGenerated = true, NodeName = "GlowPre (Internal)", NodeCategory = "Stride.Textures.Filter")]
        public n1.IVLNode __p_EY9kx6KXSElPMQjJVhcJWi;
        [n1.ElementAttribute(TracingId = 30440U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "LfGRHN57azpPNlV6sfz4lH", Name = "GlowMain", IsManaged = true, IsAutoGenerated = true, NodeName = "GlowMain (Internal)", NodeCategory = "Stride.Textures.Filter")]
        public n1.IVLNode __p_LfGRHN57azpPNlV6sfz4lH;
        [n1.ElementAttribute(TracingId = 30503U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "M8OpGwcioQXLGa6rfG2nJz", Name = "GlowMix", IsManaged = true, IsAutoGenerated = true, NodeName = "GlowMix (Internal)", NodeCategory = "Stride.Textures.Filter")]
        public n1.IVLNode __p_M8OpGwcioQXLGa6rfG2nJz;
        static Glow_Hz2rlbtqlofLP8AQAVPqLb()
        {
        }

        public Glow_Hz2rlbtqlofLP8AQAVPqLb(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Glow_Hz2rlbtqlofLP8AQAVPqLb(Glow_Hz2rlbtqlofLP8AQAVPqLb other): base(other)
        {
            this.__p_EY9kx6KXSElPMQjJVhcJWi = other.__p_EY9kx6KXSElPMQjJVhcJWi;
            this.__p_LfGRHN57azpPNlV6sfz4lH = other.__p_LfGRHN57azpPNlV6sfz4lH;
            this.__p_M8OpGwcioQXLGa6rfG2nJz = other.__p_M8OpGwcioQXLGa6rfG2nJz;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_EY9kx6KXSElPMQjJVhcJWi", in __p_EY9kx6KXSElPMQjJVhcJWi), n1.CompilationHelper.GetValueOrExisting(values, "__p_LfGRHN57azpPNlV6sfz4lH", in __p_LfGRHN57azpPNlV6sfz4lH), n1.CompilationHelper.GetValueOrExisting(values, "__p_M8OpGwcioQXLGa6rfG2nJz", in __p_M8OpGwcioQXLGa6rfG2nJz));
        }

        internal Glow_Hz2rlbtqlofLP8AQAVPqLb __WITH__(n1.IVLNode __p_EY9kx6KXSElPMQjJVhcJWi, n1.IVLNode __p_LfGRHN57azpPNlV6sfz4lH, n1.IVLNode __p_M8OpGwcioQXLGa6rfG2nJz)
        {
            n15.Glow_Hz2rlbtqlofLP8AQAVPqLb that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_EY9kx6KXSElPMQjJVhcJWi != this.__p_EY9kx6KXSElPMQjJVhcJWi || __p_LfGRHN57azpPNlV6sfz4lH != this.__p_LfGRHN57azpPNlV6sfz4lH || __p_M8OpGwcioQXLGa6rfG2nJz != this.__p_M8OpGwcioQXLGa6rfG2nJz ? new Glow_Hz2rlbtqlofLP8AQAVPqLb(this)
                {__p_EY9kx6KXSElPMQjJVhcJWi = __p_EY9kx6KXSElPMQjJVhcJWi, __p_LfGRHN57azpPNlV6sfz4lH = __p_LfGRHN57azpPNlV6sfz4lH, __p_M8OpGwcioQXLGa6rfG2nJz = __p_M8OpGwcioQXLGa6rfG2nJz} : that_0;
            else
            {
                this.__p_EY9kx6KXSElPMQjJVhcJWi = __p_EY9kx6KXSElPMQjJVhcJWi;
                this.__p_LfGRHN57azpPNlV6sfz4lH = __p_LfGRHN57azpPNlV6sfz4lH;
                this.__p_M8OpGwcioQXLGa6rfG2nJz = __p_M8OpGwcioQXLGa6rfG2nJz;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 30627U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "ALTJTssa9nvNoz0sSFsEtj", Name = "Blur_C")]
    [n2.SerializableAttribute]
    public class Blur_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n15.Blur_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new Blur_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n15.Blur_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new Blur_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n15.Blur_C Update([n4.SerializedDefaultValueAttribute("TwoPasses", false)] n17.BlurPasses Passes_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In, out n7.Texture Output_Out)
        {
            n17.BlurPasses __pad_SBQaCgZJjo8NUhYUkEcewh_0 = __slot_SBQaCgZJjo8NUhYUkEcewh;
            n17.BlurPasses __pad_LtGNxOMXs8BNpWqvzcxrP6_1 = __slot_LtGNxOMXs8BNpWqvzcxrP6;
            var Result_2 = Passes_In == __pad_SBQaCgZJjo8NUhYUkEcewh_0;
            var Result_3 = Passes_In == __pad_LtGNxOMXs8BNpWqvzcxrP6_1;
            var Output_4 = Result_2 || Result_3;
            var Output_5 = Apply_In && Result_3;
            var Output_6 = Apply_In && Output_4;
            n1.CompilationHelper.WritePin(this.__p_LyhpggIH6KlMsrQNXxQ7Kk.Inputs[9], ref Output_6);
            this.__p_LyhpggIH6KlMsrQNXxQ7Kk = this.__p_LyhpggIH6KlMsrQNXxQ7Kk;
            n1.CompilationHelper.ReadPin(this.__p_LyhpggIH6KlMsrQNXxQ7Kk.Outputs[0], out n7.Texture out_7);
            this.__p_LyhpggIH6KlMsrQNXxQ7Kk = this.__p_LyhpggIH6KlMsrQNXxQ7Kk;
            n1.CompilationHelper.WritePin(this.__p_RRFlOpVJLFFPEmkHowHgjB.Inputs[0], ref out_7);
            this.__p_RRFlOpVJLFFPEmkHowHgjB = this.__p_RRFlOpVJLFFPEmkHowHgjB;
            n1.CompilationHelper.WritePin(this.__p_RRFlOpVJLFFPEmkHowHgjB.Inputs[9], ref Apply_In);
            this.__p_RRFlOpVJLFFPEmkHowHgjB = this.__p_RRFlOpVJLFFPEmkHowHgjB;
            n1.CompilationHelper.ReadPin(this.__p_RRFlOpVJLFFPEmkHowHgjB.Outputs[0], out n7.Texture out_8);
            this.__p_RRFlOpVJLFFPEmkHowHgjB = this.__p_RRFlOpVJLFFPEmkHowHgjB;
            n1.CompilationHelper.WritePin(this.__p_KRFkC4qcNDYPX63tq04uUZ.Inputs[0], ref out_8);
            this.__p_KRFkC4qcNDYPX63tq04uUZ = this.__p_KRFkC4qcNDYPX63tq04uUZ;
            n1.CompilationHelper.WritePin(this.__p_KRFkC4qcNDYPX63tq04uUZ.Inputs[9], ref Output_5);
            this.__p_KRFkC4qcNDYPX63tq04uUZ = this.__p_KRFkC4qcNDYPX63tq04uUZ;
            n1.CompilationHelper.ReadPin(this.__p_KRFkC4qcNDYPX63tq04uUZ.Outputs[0], out n7.Texture out_9);
            this.__p_KRFkC4qcNDYPX63tq04uUZ = this.__p_KRFkC4qcNDYPX63tq04uUZ;
            Output_Out = out_9;
            return this;
        }

        public n15.Blur_C SetInput(n7.Texture Input_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Always_Generate_Mips_for_Input_In)
        {
            n1.CompilationHelper.WritePin(this.__p_LyhpggIH6KlMsrQNXxQ7Kk.Inputs[0], ref Input_In);
            this.__p_LyhpggIH6KlMsrQNXxQ7Kk = this.__p_LyhpggIH6KlMsrQNXxQ7Kk;
            n1.CompilationHelper.WritePin(this.__p_LyhpggIH6KlMsrQNXxQ7Kk.Inputs[1], ref Always_Generate_Mips_for_Input_In);
            this.__p_LyhpggIH6KlMsrQNXxQ7Kk = this.__p_LyhpggIH6KlMsrQNXxQ7Kk;
            return this;
        }

        public n15.Blur_C SetOutputFormat([n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat Output_Format_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RRFlOpVJLFFPEmkHowHgjB.Inputs[7], ref Output_Format_In);
            this.__p_RRFlOpVJLFFPEmkHowHgjB = this.__p_RRFlOpVJLFFPEmkHowHgjB;
            n1.CompilationHelper.WritePin(this.__p_KRFkC4qcNDYPX63tq04uUZ.Inputs[7], ref Output_Format_In);
            this.__p_KRFkC4qcNDYPX63tq04uUZ = this.__p_KRFkC4qcNDYPX63tq04uUZ;
            n1.CompilationHelper.WritePin(this.__p_LyhpggIH6KlMsrQNXxQ7Kk.Inputs[7], ref Output_Format_In);
            this.__p_LyhpggIH6KlMsrQNXxQ7Kk = this.__p_LyhpggIH6KlMsrQNXxQ7Kk;
            return this;
        }

        public n15.Blur_C SetRenderFormat([n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat Render_Format_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RRFlOpVJLFFPEmkHowHgjB.Inputs[8], ref Render_Format_In);
            this.__p_RRFlOpVJLFFPEmkHowHgjB = this.__p_RRFlOpVJLFFPEmkHowHgjB;
            n1.CompilationHelper.WritePin(this.__p_KRFkC4qcNDYPX63tq04uUZ.Inputs[8], ref Render_Format_In);
            this.__p_KRFkC4qcNDYPX63tq04uUZ = this.__p_KRFkC4qcNDYPX63tq04uUZ;
            n1.CompilationHelper.WritePin(this.__p_LyhpggIH6KlMsrQNXxQ7Kk.Inputs[8], ref Render_Format_In);
            this.__p_LyhpggIH6KlMsrQNXxQ7Kk = this.__p_LyhpggIH6KlMsrQNXxQ7Kk;
            return this;
        }

        public n15.Blur_C SetOutputTexture(n7.Texture Output_Texture_In)
        {
            n1.CompilationHelper.WritePin(this.__p_KRFkC4qcNDYPX63tq04uUZ.Inputs[5], ref Output_Texture_In);
            this.__p_KRFkC4qcNDYPX63tq04uUZ = this.__p_KRFkC4qcNDYPX63tq04uUZ;
            return this;
        }

        public n15.Blur_C SetOutputSize([n4.SerializedDefaultValueAttribute("0, 0", false)] n6.Int2 Output_Size_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RRFlOpVJLFFPEmkHowHgjB.Inputs[6], ref Output_Size_In);
            this.__p_RRFlOpVJLFFPEmkHowHgjB = this.__p_RRFlOpVJLFFPEmkHowHgjB;
            n1.CompilationHelper.WritePin(this.__p_KRFkC4qcNDYPX63tq04uUZ.Inputs[6], ref Output_Size_In);
            this.__p_KRFkC4qcNDYPX63tq04uUZ = this.__p_KRFkC4qcNDYPX63tq04uUZ;
            n1.CompilationHelper.WritePin(this.__p_LyhpggIH6KlMsrQNXxQ7Kk.Inputs[6], ref Output_Size_In);
            this.__p_LyhpggIH6KlMsrQNXxQ7Kk = this.__p_LyhpggIH6KlMsrQNXxQ7Kk;
            return this;
        }

        public n15.Blur_C SetControl(n16.SetVar<n6.Vector4> Control_In)
        {
            n1.CompilationHelper.WritePin(this.__p_LyhpggIH6KlMsrQNXxQ7Kk.Inputs[4], ref Control_In);
            this.__p_LyhpggIH6KlMsrQNXxQ7Kk = this.__p_LyhpggIH6KlMsrQNXxQ7Kk;
            n1.CompilationHelper.WritePin(this.__p_RRFlOpVJLFFPEmkHowHgjB.Inputs[4], ref Control_In);
            this.__p_RRFlOpVJLFFPEmkHowHgjB = this.__p_RRFlOpVJLFFPEmkHowHgjB;
            n1.CompilationHelper.WritePin(this.__p_KRFkC4qcNDYPX63tq04uUZ.Inputs[4], ref Control_In);
            this.__p_KRFkC4qcNDYPX63tq04uUZ = this.__p_KRFkC4qcNDYPX63tq04uUZ;
            return this;
        }

        public n15.Blur_C SetStrength(n16.SetVar<float> Strength_In)
        {
            n1.CompilationHelper.WritePin(this.__p_LyhpggIH6KlMsrQNXxQ7Kk.Inputs[3], ref Strength_In);
            this.__p_LyhpggIH6KlMsrQNXxQ7Kk = this.__p_LyhpggIH6KlMsrQNXxQ7Kk;
            n1.CompilationHelper.WritePin(this.__p_RRFlOpVJLFFPEmkHowHgjB.Inputs[3], ref Strength_In);
            this.__p_RRFlOpVJLFFPEmkHowHgjB = this.__p_RRFlOpVJLFFPEmkHowHgjB;
            n1.CompilationHelper.WritePin(this.__p_KRFkC4qcNDYPX63tq04uUZ.Inputs[3], ref Strength_In);
            this.__p_KRFkC4qcNDYPX63tq04uUZ = this.__p_KRFkC4qcNDYPX63tq04uUZ;
            return this;
        }

        public n15.Blur_C __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "BlurPass2 (Internal)", "Stride.Textures.Filter");
            this.__p_RRFlOpVJLFFPEmkHowHgjB = node_0;
            var node_1 = n1.CompilationHelper.CreateNodeById(Node_Context, "BlurPass3 (Internal)", "Stride.Textures.Filter");
            this.__p_KRFkC4qcNDYPX63tq04uUZ = node_1;
            var node_2 = n1.CompilationHelper.CreateNodeById(Node_Context, "BlurPass1 (Internal)", "Stride.Textures.Filter");
            this.__p_LyhpggIH6KlMsrQNXxQ7Kk = node_2;
            return this;
        }

        public n15.Blur_C __CreateDefault__()
        {
            this.__p_LyhpggIH6KlMsrQNXxQ7Kk = default(n1.IVLNode);
            this.__p_RRFlOpVJLFFPEmkHowHgjB = default(n1.IVLNode);
            this.__p_KRFkC4qcNDYPX63tq04uUZ = default(n1.IVLNode);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_LyhpggIH6KlMsrQNXxQ7Kk);
            n1.CompilationHelper.SafeDispose(this.__p_RRFlOpVJLFFPEmkHowHgjB);
            n1.CompilationHelper.SafeDispose(this.__p_KRFkC4qcNDYPX63tq04uUZ);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 30784U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "SBQaCgZJjo8NUhYUkEcewh", Name = "__slot_SBQaCgZJjo8NUhYUkEcewh")]
        public static n17.BlurPasses __slot_SBQaCgZJjo8NUhYUkEcewh = n1.CompilationHelper.Deserialize<n17.BlurPasses>("TwoPasses", false, "BzGvoB2aLhzP7WO4jVw5sI", "SBQaCgZJjo8NUhYUkEcewh");
        [n1.ElementAttribute(TracingId = 30808U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "LtGNxOMXs8BNpWqvzcxrP6", Name = "__slot_LtGNxOMXs8BNpWqvzcxrP6")]
        public static n17.BlurPasses __slot_LtGNxOMXs8BNpWqvzcxrP6 = n1.CompilationHelper.Deserialize<n17.BlurPasses>("ThreePasses", false, "BzGvoB2aLhzP7WO4jVw5sI", "LtGNxOMXs8BNpWqvzcxrP6");
        [n1.ElementAttribute(TracingId = 30722U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "LyhpggIH6KlMsrQNXxQ7Kk", Name = "BlurPass1", IsManaged = true, IsAutoGenerated = true, NodeName = "BlurPass1 (Internal)", NodeCategory = "Stride.Textures.Filter")]
        public n1.IVLNode __p_LyhpggIH6KlMsrQNXxQ7Kk;
        [n1.ElementAttribute(TracingId = 30633U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "RRFlOpVJLFFPEmkHowHgjB", Name = "BlurPass2", IsManaged = true, IsAutoGenerated = true, NodeName = "BlurPass2 (Internal)", NodeCategory = "Stride.Textures.Filter")]
        public n1.IVLNode __p_RRFlOpVJLFFPEmkHowHgjB;
        [n1.ElementAttribute(TracingId = 30674U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "KRFkC4qcNDYPX63tq04uUZ", Name = "BlurPass3", IsManaged = true, IsAutoGenerated = true, NodeName = "BlurPass3 (Internal)", NodeCategory = "Stride.Textures.Filter")]
        public n1.IVLNode __p_KRFkC4qcNDYPX63tq04uUZ;
        static Blur_C()
        {
        }

        public Blur_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Blur_C(Blur_C other): base(other)
        {
            this.__p_LyhpggIH6KlMsrQNXxQ7Kk = other.__p_LyhpggIH6KlMsrQNXxQ7Kk;
            this.__p_RRFlOpVJLFFPEmkHowHgjB = other.__p_RRFlOpVJLFFPEmkHowHgjB;
            this.__p_KRFkC4qcNDYPX63tq04uUZ = other.__p_KRFkC4qcNDYPX63tq04uUZ;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LyhpggIH6KlMsrQNXxQ7Kk", in __p_LyhpggIH6KlMsrQNXxQ7Kk), n1.CompilationHelper.GetValueOrExisting(values, "__p_RRFlOpVJLFFPEmkHowHgjB", in __p_RRFlOpVJLFFPEmkHowHgjB), n1.CompilationHelper.GetValueOrExisting(values, "__p_KRFkC4qcNDYPX63tq04uUZ", in __p_KRFkC4qcNDYPX63tq04uUZ));
        }

        internal Blur_C __WITH__(n1.IVLNode __p_LyhpggIH6KlMsrQNXxQ7Kk, n1.IVLNode __p_RRFlOpVJLFFPEmkHowHgjB, n1.IVLNode __p_KRFkC4qcNDYPX63tq04uUZ)
        {
            n15.Blur_C that_0 = this;
            this.__p_LyhpggIH6KlMsrQNXxQ7Kk = __p_LyhpggIH6KlMsrQNXxQ7Kk;
            this.__p_RRFlOpVJLFFPEmkHowHgjB = __p_RRFlOpVJLFFPEmkHowHgjB;
            this.__p_KRFkC4qcNDYPX63tq04uUZ = __p_KRFkC4qcNDYPX63tq04uUZ;
            return that_0;
        }
    }
}

namespace _VL_Stride_Rendering_TextureFX_.Stride.Textures.Mixer
{
    [n1.ElementAttribute(TracingId = 31059U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "AFu86hoz4AgPNxFpUGXY6q", Name = "Blend_AFu86hoz4AgPNxFpUGXY6q")]
    [n2.SerializableAttribute]
    public class Blend_AFu86hoz4AgPNxFpUGXY6q : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n18.Blend_AFu86hoz4AgPNxFpUGXY6q Create(n1.NodeContext Node_Context)
        {
            var instance = new Blend_AFu86hoz4AgPNxFpUGXY6q(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n18.Blend_AFu86hoz4AgPNxFpUGXY6q CreateDefault()
        {
            var instance = new Blend_AFu86hoz4AgPNxFpUGXY6q(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n18.Blend_AFu86hoz4AgPNxFpUGXY6q SetInput(n7.Texture Input_In, n7.SamplerState Sampler_In, n7.Texture Input_2_In, n7.SamplerState Sampler_2_In, [n4.SerializedDefaultValueAttribute("Average", false)] n16.BlendOperator Blend_Operation_In)
        {
            n1.CompilationHelper.WritePin(this.__p_P4aqh5oLEcgNkbG3nlH8yy.Inputs[0], ref Input_In);
            n1.CompilationHelper.WritePin(this.__p_P4aqh5oLEcgNkbG3nlH8yy.Inputs[1], ref Sampler_In);
            n1.CompilationHelper.WritePin(this.__p_P4aqh5oLEcgNkbG3nlH8yy.Inputs[2], ref Input_2_In);
            n1.CompilationHelper.WritePin(this.__p_P4aqh5oLEcgNkbG3nlH8yy.Inputs[3], ref Sampler_2_In);
            string Resource_Group_Name_0 = "";
            var State_Output_2 = this.__p_BxxDlwFAvzcOJFAxwIegrq.Update(Resource_Group_Name_In: Resource_Group_Name_0, Output_Out: out n16.DeclSampler Output_1);
            string Resource_Group_Name_3 = "";
            var State_Output_5 = this.__p_VA0b5LXsdq6O9hK77paOU4.Update(Resource_Group_Name_In: Resource_Group_Name_3, Output_Out: out n16.DeclSampler Output_4);
            bool Force_6 = false;
            bool Dispose_Cached_Outputs_7 = false;
            var manager_8 = this.__cache_G2MyopW4dR6L92CZbQThfg;
            if (manager_8 is null)
            {
                manager_8 = new n19.Manager<n2.ValueTuple<n7.Texture, n7.Texture, n16.BlendOperator>, n2.ValueTuple<n16.SetVar<n6.Vector4>>>(n2.ValueTuple.Create(default(n16.SetVar<n6.Vector4>)));
            }

            var inputs_9 = (Input_In, Input_2_In, Blend_Operation_In);
            var outputs_10 = manager_8.Outputs;
            var Has_Changed_11 = Force_6 || manager_8.InputsChanged(inputs_9);
            if (Has_Changed_11)
            {
                if (Dispose_Cached_Outputs_7)
                    manager_8.DisposeOutputs();
                var state_12 = n1.CompilationHelper.Restore<__SOrZIuTuQnTLFIxLmyAX2J>(manager_8.State, __GetContext__());
                if (state_12 == null)
                {
                    state_12 = new __SOrZIuTuQnTLFIxLmyAX2J(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "O4bZCYWiNf9QFRDhhg9W4c", 31167U);
                    var Output_14 = n20.BlendOp_Gg4gUVHOObnLietoehvV1h.Create(Node_Context: Node_Context_13);
                    state_12.__p_O4bZCYWiNf9QFRDhhg9W4c = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "MnPsqGCc3BuP8cufABeVFj", 31187U);
                    var Output_16 = n21.SampleTexture_BckflDe3bBbM1KG5LnQIxv<n6.Vector4>.Create(Node_Context: Node_Context_15);
                    state_12.__p_MnPsqGCc3BuP8cufABeVFj = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "MzOLT674vfYOrzZQ2Zpijf", 31201U);
                    var Output_18 = n21.SampleTexture_BckflDe3bBbM1KG5LnQIxv<n6.Vector4>.Create(Node_Context: Node_Context_17);
                    state_12.__p_MzOLT674vfYOrzZQ2Zpijf = Output_18;
                    n1.NodeContext Node_Context_19 = __GetContext__().CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "CoQ2uTZF7HnNlW3oBVbr33", 31213U);
                    string Resource_Group_Name_20 = "";
                    var Output_21 = n21.TextureIn_OypDfnSaGa1OvYqvLU5EVc.Create(Node_Context: Node_Context_19, Resource_Group_Name_In: Resource_Group_Name_20);
                    state_12.__p_CoQ2uTZF7HnNlW3oBVbr33 = Output_21;
                    n1.NodeContext Node_Context_22 = __GetContext__().CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "VD0ihgp6OlTNkRAMHU0mkw", 31230U);
                    string Resource_Group_Name_23 = "";
                    var Output_24 = n21.TextureIn_OypDfnSaGa1OvYqvLU5EVc.Create(Node_Context: Node_Context_22, Resource_Group_Name_In: Resource_Group_Name_23);
                    state_12.__p_VD0ihgp6OlTNkRAMHU0mkw = Output_24;
                }

                var State_Output_26 = state_12.__p_CoQ2uTZF7HnNlW3oBVbr33.Update(Output_Out: out n16.DeclTexture Output_25);
                n16.SetVar<n6.Vector2> Tex_Coord_27 = default(n16.SetVar<n6.Vector2>);
                n16.SampleMode Sample_Mode_28 = default(n16.SampleMode);
                var State_Output_30 = state_12.__p_MnPsqGCc3BuP8cufABeVFj.Update(Texture_In: Output_25, Sampler_In: Output_1, Tex_Coord_In: Tex_Coord_27, Sample_Mode_In: Sample_Mode_28, Output_Out: out n16.SetVar<n6.Vector4> Output_29);
                var State_Output_32 = state_12.__p_VD0ihgp6OlTNkRAMHU0mkw.Update(Output_Out: out n16.DeclTexture Output_31);
                n16.SetVar<n6.Vector2> Tex_Coord_33 = default(n16.SetVar<n6.Vector2>);
                n16.SampleMode Sample_Mode_34 = default(n16.SampleMode);
                var State_Output_36 = state_12.__p_MzOLT674vfYOrzZQ2Zpijf.Update(Texture_In: Output_31, Sampler_In: Output_4, Tex_Coord_In: Tex_Coord_33, Sample_Mode_In: Sample_Mode_34, Output_Out: out n16.SetVar<n6.Vector4> Output_35);
                var State_Output_38 = state_12.__p_O4bZCYWiNf9QFRDhhg9W4c.Update(Back_Color_In: Output_29, Front_Color_In: Output_35, Blend_Operation_In: Blend_Operation_In, Output_Out: out n16.SetVar<n6.Vector4> Output_37);
                bool SetValue_39 = true;
                var Output_40 = State_Output_26;
                if (SetValue_39)
                {
                    Output_40 = State_Output_26.SetValue(Value_In: Input_In);
                }

                bool SetValue_41 = true;
                var Output_42 = State_Output_32;
                if (SetValue_41)
                {
                    Output_42 = State_Output_32.SetValue(Value_In: Input_2_In);
                }

                if (state_12.__GetContext__().IsImmutable)
                    state_12 = Output_40 != state_12.__p_CoQ2uTZF7HnNlW3oBVbr33 || State_Output_30 != state_12.__p_MnPsqGCc3BuP8cufABeVFj || Output_42 != state_12.__p_VD0ihgp6OlTNkRAMHU0mkw || State_Output_36 != state_12.__p_MzOLT674vfYOrzZQ2Zpijf || State_Output_38 != state_12.__p_O4bZCYWiNf9QFRDhhg9W4c ? new __SOrZIuTuQnTLFIxLmyAX2J(state_12)
                    {__p_CoQ2uTZF7HnNlW3oBVbr33 = Output_40, __p_MnPsqGCc3BuP8cufABeVFj = State_Output_30, __p_VD0ihgp6OlTNkRAMHU0mkw = Output_42, __p_MzOLT674vfYOrzZQ2Zpijf = State_Output_36, __p_O4bZCYWiNf9QFRDhhg9W4c = State_Output_38} : state_12;
                else
                {
                    state_12.__p_CoQ2uTZF7HnNlW3oBVbr33 = Output_40;
                    state_12.__p_MnPsqGCc3BuP8cufABeVFj = State_Output_30;
                    state_12.__p_VD0ihgp6OlTNkRAMHU0mkw = Output_42;
                    state_12.__p_MzOLT674vfYOrzZQ2Zpijf = State_Output_36;
                    state_12.__p_O4bZCYWiNf9QFRDhhg9W4c = State_Output_38;
                }

                outputs_10 = n2.ValueTuple.Create(Output_37);
                manager_8 = manager_8.Update(inputs_9, __GetContext__().IsImmutable, Dispose_Cached_Outputs_7, state_12, outputs_10);
            }
            else
            {
                manager_8.Update(inputs_9, __GetContext__().IsImmutable, Dispose_Cached_Outputs_7);
            }

            var __auto_43 = outputs_10.Item1;
            n1.CompilationHelper.WritePin(this.__p_P4aqh5oLEcgNkbG3nlH8yy.Inputs[5], ref __auto_43);
            bool SetValue_44 = true;
            var Output_45 = State_Output_2;
            if (SetValue_44)
            {
                Output_45 = State_Output_2.SetValue(Value_In: Sampler_In);
            }

            bool SetValue_46 = true;
            var Output_47 = State_Output_5;
            if (SetValue_46)
            {
                Output_47 = State_Output_5.SetValue(Value_In: Sampler_2_In);
            }

            n18.Blend_AFu86hoz4AgPNxFpUGXY6q that_48 = this;
            if (this.__GetContext__().IsImmutable)
                that_48 = this.__p_P4aqh5oLEcgNkbG3nlH8yy != this.__p_P4aqh5oLEcgNkbG3nlH8yy || Output_45 != this.__p_BxxDlwFAvzcOJFAxwIegrq || Output_47 != this.__p_VA0b5LXsdq6O9hK77paOU4 || manager_8 != this.__cache_G2MyopW4dR6L92CZbQThfg ? new Blend_AFu86hoz4AgPNxFpUGXY6q(this)
                {__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy, __p_BxxDlwFAvzcOJFAxwIegrq = Output_45, __p_VA0b5LXsdq6O9hK77paOU4 = Output_47, __cache_G2MyopW4dR6L92CZbQThfg = manager_8} : that_48;
            else
            {
                this.__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy;
                this.__p_BxxDlwFAvzcOJFAxwIegrq = Output_45;
                this.__p_VA0b5LXsdq6O9hK77paOU4 = Output_47;
                this.__cache_G2MyopW4dR6L92CZbQThfg = manager_8;
            }

            return that_48;
        }

        public n18.Blend_AFu86hoz4AgPNxFpUGXY6q SetFader(n16.SetVar<float> Fader_In)
        {
            n1.CompilationHelper.WritePin(this.__p_P4aqh5oLEcgNkbG3nlH8yy.Inputs[4], ref Fader_In);
            n18.Blend_AFu86hoz4AgPNxFpUGXY6q that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_P4aqh5oLEcgNkbG3nlH8yy != this.__p_P4aqh5oLEcgNkbG3nlH8yy ? new Blend_AFu86hoz4AgPNxFpUGXY6q(this)
                {__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy} : that_0;
            else
            {
                this.__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy;
            }

            return that_0;
        }

        public n18.Blend_AFu86hoz4AgPNxFpUGXY6q SetApply([n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In)
        {
            n1.CompilationHelper.WritePin(this.__p_P4aqh5oLEcgNkbG3nlH8yy.Inputs[10], ref Apply_In);
            n18.Blend_AFu86hoz4AgPNxFpUGXY6q that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_P4aqh5oLEcgNkbG3nlH8yy != this.__p_P4aqh5oLEcgNkbG3nlH8yy ? new Blend_AFu86hoz4AgPNxFpUGXY6q(this)
                {__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy} : that_0;
            else
            {
                this.__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy;
            }

            return that_0;
        }

        public n18.Blend_AFu86hoz4AgPNxFpUGXY6q SetOutputTexture(n7.Texture Output_Texture_In)
        {
            n1.CompilationHelper.WritePin(this.__p_P4aqh5oLEcgNkbG3nlH8yy.Inputs[6], ref Output_Texture_In);
            n18.Blend_AFu86hoz4AgPNxFpUGXY6q that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_P4aqh5oLEcgNkbG3nlH8yy != this.__p_P4aqh5oLEcgNkbG3nlH8yy ? new Blend_AFu86hoz4AgPNxFpUGXY6q(this)
                {__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy} : that_0;
            else
            {
                this.__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy;
            }

            return that_0;
        }

        public n18.Blend_AFu86hoz4AgPNxFpUGXY6q SetOutputSize([n4.SerializedDefaultValueAttribute("0, 0", false)] n6.Int2 Output_Size_In)
        {
            n1.CompilationHelper.WritePin(this.__p_P4aqh5oLEcgNkbG3nlH8yy.Inputs[7], ref Output_Size_In);
            n18.Blend_AFu86hoz4AgPNxFpUGXY6q that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_P4aqh5oLEcgNkbG3nlH8yy != this.__p_P4aqh5oLEcgNkbG3nlH8yy ? new Blend_AFu86hoz4AgPNxFpUGXY6q(this)
                {__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy} : that_0;
            else
            {
                this.__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy;
            }

            return that_0;
        }

        public n18.Blend_AFu86hoz4AgPNxFpUGXY6q SetOutputFormat([n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat Output_Format_In)
        {
            n1.CompilationHelper.WritePin(this.__p_P4aqh5oLEcgNkbG3nlH8yy.Inputs[8], ref Output_Format_In);
            n18.Blend_AFu86hoz4AgPNxFpUGXY6q that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = this.__p_P4aqh5oLEcgNkbG3nlH8yy != this.__p_P4aqh5oLEcgNkbG3nlH8yy ? new Blend_AFu86hoz4AgPNxFpUGXY6q(this)
                {__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy} : that_0;
            else
            {
                this.__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy;
            }

            return that_0;
        }

        public n18.Blend_AFu86hoz4AgPNxFpUGXY6q GetOutput(out n7.Texture Output_Out)
        {
            n1.CompilationHelper.ReadPin(this.__p_P4aqh5oLEcgNkbG3nlH8yy.Outputs[0], out n7.Texture out_0);
            Output_Out = out_0;
            n18.Blend_AFu86hoz4AgPNxFpUGXY6q that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = this.__p_P4aqh5oLEcgNkbG3nlH8yy != this.__p_P4aqh5oLEcgNkbG3nlH8yy ? new Blend_AFu86hoz4AgPNxFpUGXY6q(this)
                {__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy} : that_1;
            else
            {
                this.__p_P4aqh5oLEcgNkbG3nlH8yy = this.__p_P4aqh5oLEcgNkbG3nlH8yy;
            }

            return that_1;
        }

        public n18.Blend_AFu86hoz4AgPNxFpUGXY6q __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "BlendMixer", "Stride.Textures.Mixer.Advanced");
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "VA0b5LXsdq6O9hK77paOU4", 31112U);
            var Output_2 = n21.SamplerIn_CwsiBD2yjEVMKfFxOsIL7f.Create(Node_Context: Node_Context_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "BxxDlwFAvzcOJFAxwIegrq", 31246U);
            var Output_4 = n21.SamplerIn_CwsiBD2yjEVMKfFxOsIL7f.Create(Node_Context: Node_Context_3);
            n18.Blend_AFu86hoz4AgPNxFpUGXY6q that_5 = this;
            this.__p_P4aqh5oLEcgNkbG3nlH8yy = node_0;
            this.__p_VA0b5LXsdq6O9hK77paOU4 = Output_2;
            this.__p_BxxDlwFAvzcOJFAxwIegrq = Output_4;
            this.__cache_G2MyopW4dR6L92CZbQThfg = null;
            return that_5;
        }

        public n18.Blend_AFu86hoz4AgPNxFpUGXY6q __CreateDefault__()
        {
            n18.Blend_AFu86hoz4AgPNxFpUGXY6q that_0 = this;
            this.__p_P4aqh5oLEcgNkbG3nlH8yy = default(n1.IVLNode);
            this.__p_BxxDlwFAvzcOJFAxwIegrq = n21.SamplerIn_CwsiBD2yjEVMKfFxOsIL7f.CreateDefault();
            this.__p_VA0b5LXsdq6O9hK77paOU4 = n21.SamplerIn_CwsiBD2yjEVMKfFxOsIL7f.CreateDefault();
            this.__cache_G2MyopW4dR6L92CZbQThfg = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_P4aqh5oLEcgNkbG3nlH8yy);
            n1.CompilationHelper.SafeDispose(this.__p_BxxDlwFAvzcOJFAxwIegrq);
            n1.CompilationHelper.SafeDispose(this.__p_VA0b5LXsdq6O9hK77paOU4);
            n1.CompilationHelper.SafeDispose(this.__cache_G2MyopW4dR6L92CZbQThfg);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 31064U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "P4aqh5oLEcgNkbG3nlH8yy", Name = "BlendMixer", IsManaged = true, IsAutoGenerated = true, NodeName = "BlendMixer", NodeCategory = "Stride.Textures.Mixer.Advanced")]
        public n1.IVLNode __p_P4aqh5oLEcgNkbG3nlH8yy;
        [n1.ElementAttribute(TracingId = 31246U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "BxxDlwFAvzcOJFAxwIegrq", Name = "SamplerIn", IsManaged = true, IsAutoGenerated = true)]
        public n21.SamplerIn_CwsiBD2yjEVMKfFxOsIL7f __p_BxxDlwFAvzcOJFAxwIegrq;
        [n1.ElementAttribute(TracingId = 31112U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "VA0b5LXsdq6O9hK77paOU4", Name = "SamplerIn", IsManaged = true, IsAutoGenerated = true)]
        public n21.SamplerIn_CwsiBD2yjEVMKfFxOsIL7f __p_VA0b5LXsdq6O9hK77paOU4;
        [n1.ElementAttribute(TracingId = 31130U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "G2MyopW4dR6L92CZbQThfg", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n19.Manager<n2.ValueTuple<n7.Texture, n7.Texture, n16.BlendOperator>, n2.ValueTuple<n16.SetVar<n6.Vector4>>> __cache_G2MyopW4dR6L92CZbQThfg = null;
        public Blend_AFu86hoz4AgPNxFpUGXY6q(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Blend_AFu86hoz4AgPNxFpUGXY6q(Blend_AFu86hoz4AgPNxFpUGXY6q other): base(other)
        {
            this.__p_P4aqh5oLEcgNkbG3nlH8yy = other.__p_P4aqh5oLEcgNkbG3nlH8yy;
            this.__p_BxxDlwFAvzcOJFAxwIegrq = other.__p_BxxDlwFAvzcOJFAxwIegrq;
            this.__p_VA0b5LXsdq6O9hK77paOU4 = other.__p_VA0b5LXsdq6O9hK77paOU4;
            this.__cache_G2MyopW4dR6L92CZbQThfg = other.__cache_G2MyopW4dR6L92CZbQThfg;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_P4aqh5oLEcgNkbG3nlH8yy", in __p_P4aqh5oLEcgNkbG3nlH8yy), n1.CompilationHelper.GetValueOrExisting(values, "__p_BxxDlwFAvzcOJFAxwIegrq", in __p_BxxDlwFAvzcOJFAxwIegrq), n1.CompilationHelper.GetValueOrExisting(values, "__p_VA0b5LXsdq6O9hK77paOU4", in __p_VA0b5LXsdq6O9hK77paOU4), n1.CompilationHelper.GetValueOrExisting(values, "__cache_G2MyopW4dR6L92CZbQThfg", in __cache_G2MyopW4dR6L92CZbQThfg));
        }

        internal Blend_AFu86hoz4AgPNxFpUGXY6q __WITH__(n1.IVLNode __p_P4aqh5oLEcgNkbG3nlH8yy, n21.SamplerIn_CwsiBD2yjEVMKfFxOsIL7f __p_BxxDlwFAvzcOJFAxwIegrq, n21.SamplerIn_CwsiBD2yjEVMKfFxOsIL7f __p_VA0b5LXsdq6O9hK77paOU4, n19.Manager<n2.ValueTuple<n7.Texture, n7.Texture, n16.BlendOperator>, n2.ValueTuple<n16.SetVar<n6.Vector4>>> __cache_G2MyopW4dR6L92CZbQThfg)
        {
            n18.Blend_AFu86hoz4AgPNxFpUGXY6q that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_P4aqh5oLEcgNkbG3nlH8yy != this.__p_P4aqh5oLEcgNkbG3nlH8yy || __p_BxxDlwFAvzcOJFAxwIegrq != this.__p_BxxDlwFAvzcOJFAxwIegrq || __p_VA0b5LXsdq6O9hK77paOU4 != this.__p_VA0b5LXsdq6O9hK77paOU4 || __cache_G2MyopW4dR6L92CZbQThfg != this.__cache_G2MyopW4dR6L92CZbQThfg ? new Blend_AFu86hoz4AgPNxFpUGXY6q(this)
                {__p_P4aqh5oLEcgNkbG3nlH8yy = __p_P4aqh5oLEcgNkbG3nlH8yy, __p_BxxDlwFAvzcOJFAxwIegrq = __p_BxxDlwFAvzcOJFAxwIegrq, __p_VA0b5LXsdq6O9hK77paOU4 = __p_VA0b5LXsdq6O9hK77paOU4, __cache_G2MyopW4dR6L92CZbQThfg = __cache_G2MyopW4dR6L92CZbQThfg} : that_0;
            else
            {
                this.__p_P4aqh5oLEcgNkbG3nlH8yy = __p_P4aqh5oLEcgNkbG3nlH8yy;
                this.__p_BxxDlwFAvzcOJFAxwIegrq = __p_BxxDlwFAvzcOJFAxwIegrq;
                this.__p_VA0b5LXsdq6O9hK77paOU4 = __p_VA0b5LXsdq6O9hK77paOU4;
                this.__cache_G2MyopW4dR6L92CZbQThfg = __cache_G2MyopW4dR6L92CZbQThfg;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "SOrZIuTuQnTLFIxLmyAX2J", Name = "__SOrZIuTuQnTLFIxLmyAX2J")]
        [n2.SerializableAttribute]
        public class __SOrZIuTuQnTLFIxLmyAX2J : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_O4bZCYWiNf9QFRDhhg9W4c);
                n1.CompilationHelper.SafeDispose(this.__p_MnPsqGCc3BuP8cufABeVFj);
                n1.CompilationHelper.SafeDispose(this.__p_MzOLT674vfYOrzZQ2Zpijf);
                n1.CompilationHelper.SafeDispose(this.__p_CoQ2uTZF7HnNlW3oBVbr33);
                n1.CompilationHelper.SafeDispose(this.__p_VD0ihgp6OlTNkRAMHU0mkw);
                return;
            }

            [n1.ElementAttribute(TracingId = 31167U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "O4bZCYWiNf9QFRDhhg9W4c", Name = "BlendOp", IsManaged = true, IsAutoGenerated = true)]
            public n20.BlendOp_Gg4gUVHOObnLietoehvV1h __p_O4bZCYWiNf9QFRDhhg9W4c;
            [n1.ElementAttribute(TracingId = 31187U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "MnPsqGCc3BuP8cufABeVFj", Name = "SampleTexture", IsManaged = true, IsAutoGenerated = true)]
            public n21.SampleTexture_BckflDe3bBbM1KG5LnQIxv<n6.Vector4> __p_MnPsqGCc3BuP8cufABeVFj;
            [n1.ElementAttribute(TracingId = 31201U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "MzOLT674vfYOrzZQ2Zpijf", Name = "SampleTexture", IsManaged = true, IsAutoGenerated = true)]
            public n21.SampleTexture_BckflDe3bBbM1KG5LnQIxv<n6.Vector4> __p_MzOLT674vfYOrzZQ2Zpijf;
            [n1.ElementAttribute(TracingId = 31213U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "CoQ2uTZF7HnNlW3oBVbr33", Name = "TextureIn", IsManaged = true, IsAutoGenerated = true)]
            public n21.TextureIn_OypDfnSaGa1OvYqvLU5EVc __p_CoQ2uTZF7HnNlW3oBVbr33;
            [n1.ElementAttribute(TracingId = 31230U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "VD0ihgp6OlTNkRAMHU0mkw", Name = "TextureIn", IsManaged = true, IsAutoGenerated = true)]
            public n21.TextureIn_OypDfnSaGa1OvYqvLU5EVc __p_VD0ihgp6OlTNkRAMHU0mkw;
            public __SOrZIuTuQnTLFIxLmyAX2J(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SOrZIuTuQnTLFIxLmyAX2J(__SOrZIuTuQnTLFIxLmyAX2J other): base(other)
            {
                this.__p_O4bZCYWiNf9QFRDhhg9W4c = other.__p_O4bZCYWiNf9QFRDhhg9W4c;
                this.__p_MnPsqGCc3BuP8cufABeVFj = other.__p_MnPsqGCc3BuP8cufABeVFj;
                this.__p_MzOLT674vfYOrzZQ2Zpijf = other.__p_MzOLT674vfYOrzZQ2Zpijf;
                this.__p_CoQ2uTZF7HnNlW3oBVbr33 = other.__p_CoQ2uTZF7HnNlW3oBVbr33;
                this.__p_VD0ihgp6OlTNkRAMHU0mkw = other.__p_VD0ihgp6OlTNkRAMHU0mkw;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_O4bZCYWiNf9QFRDhhg9W4c", in __p_O4bZCYWiNf9QFRDhhg9W4c), n1.CompilationHelper.GetValueOrExisting(values, "__p_MnPsqGCc3BuP8cufABeVFj", in __p_MnPsqGCc3BuP8cufABeVFj), n1.CompilationHelper.GetValueOrExisting(values, "__p_MzOLT674vfYOrzZQ2Zpijf", in __p_MzOLT674vfYOrzZQ2Zpijf), n1.CompilationHelper.GetValueOrExisting(values, "__p_CoQ2uTZF7HnNlW3oBVbr33", in __p_CoQ2uTZF7HnNlW3oBVbr33), n1.CompilationHelper.GetValueOrExisting(values, "__p_VD0ihgp6OlTNkRAMHU0mkw", in __p_VD0ihgp6OlTNkRAMHU0mkw));
            }

            internal __SOrZIuTuQnTLFIxLmyAX2J __WITH__(n20.BlendOp_Gg4gUVHOObnLietoehvV1h __p_O4bZCYWiNf9QFRDhhg9W4c, n21.SampleTexture_BckflDe3bBbM1KG5LnQIxv<n6.Vector4> __p_MnPsqGCc3BuP8cufABeVFj, n21.SampleTexture_BckflDe3bBbM1KG5LnQIxv<n6.Vector4> __p_MzOLT674vfYOrzZQ2Zpijf, n21.TextureIn_OypDfnSaGa1OvYqvLU5EVc __p_CoQ2uTZF7HnNlW3oBVbr33, n21.TextureIn_OypDfnSaGa1OvYqvLU5EVc __p_VD0ihgp6OlTNkRAMHU0mkw)
            {
                __SOrZIuTuQnTLFIxLmyAX2J that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_O4bZCYWiNf9QFRDhhg9W4c != this.__p_O4bZCYWiNf9QFRDhhg9W4c || __p_MnPsqGCc3BuP8cufABeVFj != this.__p_MnPsqGCc3BuP8cufABeVFj || __p_MzOLT674vfYOrzZQ2Zpijf != this.__p_MzOLT674vfYOrzZQ2Zpijf || __p_CoQ2uTZF7HnNlW3oBVbr33 != this.__p_CoQ2uTZF7HnNlW3oBVbr33 || __p_VD0ihgp6OlTNkRAMHU0mkw != this.__p_VD0ihgp6OlTNkRAMHU0mkw ? new __SOrZIuTuQnTLFIxLmyAX2J(this)
                    {__p_O4bZCYWiNf9QFRDhhg9W4c = __p_O4bZCYWiNf9QFRDhhg9W4c, __p_MnPsqGCc3BuP8cufABeVFj = __p_MnPsqGCc3BuP8cufABeVFj, __p_MzOLT674vfYOrzZQ2Zpijf = __p_MzOLT674vfYOrzZQ2Zpijf, __p_CoQ2uTZF7HnNlW3oBVbr33 = __p_CoQ2uTZF7HnNlW3oBVbr33, __p_VD0ihgp6OlTNkRAMHU0mkw = __p_VD0ihgp6OlTNkRAMHU0mkw} : that_0;
                else
                {
                    this.__p_O4bZCYWiNf9QFRDhhg9W4c = __p_O4bZCYWiNf9QFRDhhg9W4c;
                    this.__p_MnPsqGCc3BuP8cufABeVFj = __p_MnPsqGCc3BuP8cufABeVFj;
                    this.__p_MzOLT674vfYOrzZQ2Zpijf = __p_MzOLT674vfYOrzZQ2Zpijf;
                    this.__p_CoQ2uTZF7HnNlW3oBVbr33 = __p_CoQ2uTZF7HnNlW3oBVbr33;
                    this.__p_VD0ihgp6OlTNkRAMHU0mkw = __p_VD0ihgp6OlTNkRAMHU0mkw;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Stride_Rendering_TextureFX_.Stride.Textures.Utils.Advanced.Experimental
{
    [n1.ElementAttribute(TracingId = 31413U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "DjzETyjdqw1NI0YIhMLrmb", Name = "TextureFXBase_DjzETyjdqw1NI0YIhMLrmb")]
    [n2.SerializableAttribute]
    public class TextureFXBase_DjzETyjdqw1NI0YIhMLrmb : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb Create(n1.NodeContext Node_Context)
        {
            var instance = new TextureFXBase_DjzETyjdqw1NI0YIhMLrmb(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb CreateDefault()
        {
            var instance = new TextureFXBase_DjzETyjdqw1NI0YIhMLrmb(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb Update(n5.IImageEffect Image_Effect_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Auto_Draw_In, n7.Texture Input_In, n6.Int2 Size_In, [n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat New_Format_In, out n7.Texture Output_Out, out n8.TextureFXDrawer_C Renderer_Out)
        {
            var Output_3 = this.__p_JGxt7BRK7GGNcL5q2LWpzP.Update(Input_In: Input_In, Size_In: Size_In, New_Format_In: New_Format_In, Texture_Inputs_Out: out n7.Texture[] Texture_Inputs_0, Render_Target_Out: out n7.Texture Render_Target_1, Loaded_Out: out bool Loaded_2);
            n11.IEnumerable<n7.Texture> Inputs_4 = (n11.IEnumerable<n7.Texture>)Texture_Inputs_0;
            n7.Texture[] Outputs_5 = n22._Operations_.CreateDefault<n7.Texture>();
            bool Update_6 = true;
            var Output_7 = this.__p_RYBpICXcWAiLKfIpCAv4ah;
            if (Update_6)
            {
                Output_7 = this.__p_RYBpICXcWAiLKfIpCAv4ah.Update(Effect_In: Image_Effect_In, Inputs_In: Inputs_4, Output_In: Render_Target_1, Outputs_In: Outputs_5, Enabled_In: Loaded_2);
            }

            n23.IGraphicsRendererBase Renderer_8 = (n23.IGraphicsRendererBase)Output_7;
            var Output_9 = this.__p_TD7V0hCOjXSQHh8xAEW5EK;
            if (Auto_Draw_In)
            {
                Output_9 = this.__p_TD7V0hCOjXSQHh8xAEW5EK.Schedule(Renderer_In: Renderer_8);
            }

            Output_Out = Render_Target_1;
            Renderer_Out = Output_7;
            n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = Output_3 != this.__p_JGxt7BRK7GGNcL5q2LWpzP || Output_7 != this.__p_RYBpICXcWAiLKfIpCAv4ah || Output_9 != this.__p_TD7V0hCOjXSQHh8xAEW5EK ? new TextureFXBase_DjzETyjdqw1NI0YIhMLrmb(this)
                {__p_JGxt7BRK7GGNcL5q2LWpzP = Output_3, __p_RYBpICXcWAiLKfIpCAv4ah = Output_7, __p_TD7V0hCOjXSQHh8xAEW5EK = Output_9} : that_10;
            else
            {
                this.__p_JGxt7BRK7GGNcL5q2LWpzP = Output_3;
                this.__p_RYBpICXcWAiLKfIpCAv4ah = Output_7;
                this.__p_TD7V0hCOjXSQHh8xAEW5EK = Output_9;
            }

            return that_10;
        }

        public n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "RYBpICXcWAiLKfIpCAv4ah", 31416U);
            var Output_1 = n8.TextureFXDrawer_C.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "JGxt7BRK7GGNcL5q2LWpzP", 31440U);
            var Output_3 = n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "TD7V0hCOjXSQHh8xAEW5EK", 31463U);
            var Output_5 = n24.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D.Create(Node_Context: Node_Context_4);
            n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb that_6 = this;
            this.__p_RYBpICXcWAiLKfIpCAv4ah = Output_1;
            this.__p_JGxt7BRK7GGNcL5q2LWpzP = Output_3;
            this.__p_TD7V0hCOjXSQHh8xAEW5EK = Output_5;
            return that_6;
        }

        public n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb __CreateDefault__()
        {
            n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb that_0 = this;
            this.__p_JGxt7BRK7GGNcL5q2LWpzP = n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh.CreateDefault();
            this.__p_RYBpICXcWAiLKfIpCAv4ah = n8.TextureFXDrawer_C.CreateDefault();
            this.__p_TD7V0hCOjXSQHh8xAEW5EK = n24.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_JGxt7BRK7GGNcL5q2LWpzP);
            n1.CompilationHelper.SafeDispose(this.__p_RYBpICXcWAiLKfIpCAv4ah);
            n1.CompilationHelper.SafeDispose(this.__p_TD7V0hCOjXSQHh8xAEW5EK);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 31440U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "JGxt7BRK7GGNcL5q2LWpzP", Name = "RenderTargetFromInput", IsManaged = true, IsAutoGenerated = true)]
        public n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh __p_JGxt7BRK7GGNcL5q2LWpzP;
        [n1.ElementAttribute(TracingId = 31416U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "RYBpICXcWAiLKfIpCAv4ah", Name = "TextureFXDrawer", IsManaged = true, IsAutoGenerated = true)]
        public n8.TextureFXDrawer_C __p_RYBpICXcWAiLKfIpCAv4ah;
        [n1.ElementAttribute(TracingId = 31463U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "TD7V0hCOjXSQHh8xAEW5EK", Name = "RendererScheduler", IsManaged = true, IsAutoGenerated = true)]
        public n24.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D __p_TD7V0hCOjXSQHh8xAEW5EK;
        public TextureFXBase_DjzETyjdqw1NI0YIhMLrmb(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TextureFXBase_DjzETyjdqw1NI0YIhMLrmb(TextureFXBase_DjzETyjdqw1NI0YIhMLrmb other): base(other)
        {
            this.__p_JGxt7BRK7GGNcL5q2LWpzP = other.__p_JGxt7BRK7GGNcL5q2LWpzP;
            this.__p_RYBpICXcWAiLKfIpCAv4ah = other.__p_RYBpICXcWAiLKfIpCAv4ah;
            this.__p_TD7V0hCOjXSQHh8xAEW5EK = other.__p_TD7V0hCOjXSQHh8xAEW5EK;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_JGxt7BRK7GGNcL5q2LWpzP", in __p_JGxt7BRK7GGNcL5q2LWpzP), n1.CompilationHelper.GetValueOrExisting(values, "__p_RYBpICXcWAiLKfIpCAv4ah", in __p_RYBpICXcWAiLKfIpCAv4ah), n1.CompilationHelper.GetValueOrExisting(values, "__p_TD7V0hCOjXSQHh8xAEW5EK", in __p_TD7V0hCOjXSQHh8xAEW5EK));
        }

        internal TextureFXBase_DjzETyjdqw1NI0YIhMLrmb __WITH__(n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh __p_JGxt7BRK7GGNcL5q2LWpzP, n8.TextureFXDrawer_C __p_RYBpICXcWAiLKfIpCAv4ah, n24.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D __p_TD7V0hCOjXSQHh8xAEW5EK)
        {
            n8.TextureFXBase_DjzETyjdqw1NI0YIhMLrmb that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_JGxt7BRK7GGNcL5q2LWpzP != this.__p_JGxt7BRK7GGNcL5q2LWpzP || __p_RYBpICXcWAiLKfIpCAv4ah != this.__p_RYBpICXcWAiLKfIpCAv4ah || __p_TD7V0hCOjXSQHh8xAEW5EK != this.__p_TD7V0hCOjXSQHh8xAEW5EK ? new TextureFXBase_DjzETyjdqw1NI0YIhMLrmb(this)
                {__p_JGxt7BRK7GGNcL5q2LWpzP = __p_JGxt7BRK7GGNcL5q2LWpzP, __p_RYBpICXcWAiLKfIpCAv4ah = __p_RYBpICXcWAiLKfIpCAv4ah, __p_TD7V0hCOjXSQHh8xAEW5EK = __p_TD7V0hCOjXSQHh8xAEW5EK} : that_0;
            else
            {
                this.__p_JGxt7BRK7GGNcL5q2LWpzP = __p_JGxt7BRK7GGNcL5q2LWpzP;
                this.__p_RYBpICXcWAiLKfIpCAv4ah = __p_RYBpICXcWAiLKfIpCAv4ah;
                this.__p_TD7V0hCOjXSQHh8xAEW5EK = __p_TD7V0hCOjXSQHh8xAEW5EK;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 31542U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "BGKMBSYtIAIMsHq1s7ojsl", Name = "TextureFXDrawer_C")]
    [n2.SerializableAttribute]
    public class TextureFXDrawer_C : n1.VLObject, n23.IGraphicsRendererBase, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n8.TextureFXDrawer_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new TextureFXDrawer_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n8.TextureFXDrawer_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new TextureFXDrawer_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n8.TextureFXDrawer_C Draw_(n23.RenderDrawContext Context_In)
        {
            n5.IImageEffect __auto_0 = this.Effect;
            var Render_Context_1 = Context_In.RenderContext;
            var Time_2 = Render_Context_1.Time;
            var Frame_Count_3 = Time_2.FrameCount;
            n23.IGraphicsRendererBase Input_4 = (n23.IGraphicsRendererBase)__auto_0;
            bool Force_5 = false;
            bool Dispose_Cached_Outputs_6 = false;
            var manager_7 = this.__cache_KGCy2TEanhWMDRnU8Lb16A;
            if (manager_7 is null)
            {
                manager_7 = new n19.Manager<n2.ValueTuple<int>, n2.ValueTuple>(n2.ValueTuple.Create());
            }

            var inputs_8 = n2.ValueTuple.Create(Frame_Count_3);
            var outputs_9 = manager_7.Outputs;
            var Has_Changed_10 = Force_5 || manager_7.InputsChanged(inputs_8);
            if (Has_Changed_10)
            {
                if (Dispose_Cached_Outputs_6)
                    manager_7.DisposeOutputs();
                n25.ObjectHelpers.IsAssigned(x: __auto_0, result: out bool Result_12, notAssigned: out bool Not_Assigned_13);
                var Output_14 = Input_4;
                if (Result_12)
                {
                    ((n23.IGraphicsRendererBase)Input_4).Draw(context: Context_In);
                }

                outputs_9 = n2.ValueTuple.Create();
                manager_7 = manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6, default, outputs_9);
            }
            else
            {
                manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6);
            }

            this.__cache_KGCy2TEanhWMDRnU8Lb16A = manager_7;
            return this;
        }

        public n8.TextureFXDrawer_C Update(n5.IImageEffect Effect_In, n11.IEnumerable<n7.Texture> Inputs_In, n7.Texture Output_In, n7.Texture[] Outputs_In, bool Enabled_In)
        {
            this.Effect = Effect_In;
            n5.IImageEffect __auto_0 = Effect_In;
            n5.IImageEffect accumulator_2 = __auto_0;
            var i_4 = 0;
            foreach (var item_1 in Inputs_In)
            {
                var splicer_3 = item_1;
                var i_local_5 = i_4;
                ((n5.IImageEffect)accumulator_2).SetInput(slot: i_local_5, texture: splicer_3);
                i_4++;
            }

            n25.ObjectHelpers.IsAssigned(x: Output_In, result: out bool Result_7, notAssigned: out bool Not_Assigned_8);
            var Output_9 = accumulator_2;
            if (Result_7)
            {
                ((n5.IImageEffect)accumulator_2).SetOutput(view: Output_In);
            }

            n25.ObjectHelpers.IsAssigned(x: Outputs_In, result: out bool Result_10, notAssigned: out bool Not_Assigned_11);
            n5.IImageEffect __auto_12;
            if (Result_10)
            {
                n22._Operations_.Length<n7.Texture>(Input_In: Outputs_In, Output_Out: out n7.Texture[] Output_14, Length_Out: out int Length_15);
                int Input_2_16 = 0;
                var Result_17 = Length_15 > Input_2_16;
                var Output_18 = Output_9;
                if (Result_17)
                {
                    ((n5.IImageEffect)Output_9).SetOutput(views: Output_14);
                }

                __auto_12 = Output_18;
            }
            else
            {
                __auto_12 = Output_9;
            }

            n23.IGraphicsRendererCore Input_19 = (n23.IGraphicsRendererCore)__auto_12;
            Input_19.Enabled = Enabled_In;
            return this;
        }

        public n8.TextureFXDrawer_C __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.Effect = default(n5.IImageEffect);
            this.__cache_KGCy2TEanhWMDRnU8Lb16A = null;
            return this;
        }

        public n8.TextureFXDrawer_C __CreateDefault__()
        {
            this.Effect = default(n5.IImageEffect);
            this.__cache_KGCy2TEanhWMDRnU8Lb16A = null;
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_KGCy2TEanhWMDRnU8Lb16A);
            return;
        }

        void n23.IGraphicsRendererBase.Draw(n23.RenderDrawContext context)
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Draw_(context);
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 31570U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "CgSxggAXUuKMUFGN5Uo1rQ", Name = "Effect")]
        public n5.IImageEffect Effect;
        [n1.ElementAttribute(TracingId = 31765U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "KGCy2TEanhWMDRnU8Lb16A", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n19.Manager<n2.ValueTuple<int>, n2.ValueTuple> __cache_KGCy2TEanhWMDRnU8Lb16A = null;
        public TextureFXDrawer_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TextureFXDrawer_C(TextureFXDrawer_C other): base(other)
        {
            this.Effect = other.Effect;
            this.__cache_KGCy2TEanhWMDRnU8Lb16A = other.__cache_KGCy2TEanhWMDRnU8Lb16A;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Effect", in Effect), n1.CompilationHelper.GetValueOrExisting(values, "__cache_KGCy2TEanhWMDRnU8Lb16A", in __cache_KGCy2TEanhWMDRnU8Lb16A));
        }

        internal TextureFXDrawer_C __WITH__(n5.IImageEffect Effect, n19.Manager<n2.ValueTuple<int>, n2.ValueTuple> __cache_KGCy2TEanhWMDRnU8Lb16A)
        {
            n8.TextureFXDrawer_C that_0 = this;
            this.Effect = Effect;
            this.__cache_KGCy2TEanhWMDRnU8Lb16A = __cache_KGCy2TEanhWMDRnU8Lb16A;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 33256U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "TQTuf7FUMdCMBja7wK8kVh", Name = "RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh")]
    [n2.SerializableAttribute]
    public class RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh Create(n1.NodeContext Node_Context)
        {
            var instance = new RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh CreateDefault()
        {
            var instance = new RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh Update(n7.Texture Input_In, n6.Int2 Size_In, [n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat New_Format_In, out n7.Texture[] Texture_Inputs_Out, out n7.Texture Render_Target_Out, out bool Loaded_Out)
        {
            bool __pad_LOF0GFRsudBOxnCnkOTnQt_0 = __slot_LOF0GFRsudBOxnCnkOTnQt;
            n7.Texture[] __pad_IE6VbHata26Nz4uyTauJWQ_1 = this.__slot_IE6VbHata26Nz4uyTauJWQ;
            n26._Operations_.TextureInfo_Basic(Input_In: Input_In, Output_Out: out n7.Texture Output_2, Size_Out: out n6.Int2 Size_3, Width_Out: out int Width_4, Height_Out: out int Height_5, Format_Out: out n9.PixelFormat Format_6, Loaded_Out: out bool Loaded_7);
            n27._Operations_.ReplaceSize(Size_In: Size_3, Replace_Size_In: Size_In, Output_Out: out n6.Int2 Output_8);
            n27._Operations_.ReplaceFormat(Input_In: Format_6, New_Format_In: New_Format_In, Output_Out: out n9.PixelFormat Output_9);
            n28.IGraphicsDataProvider[] Initial_Data_10 = n22._Operations_.CreateDefault<n28.IGraphicsDataProvider>();
            int Array_Size_11 = 1;
            int Mip_Levels_12 = 1;
            bool Is_Unordered_Access_13 = true;
            bool Is_Depth_Stencil_14 = false;
            bool Is_Shared_15 = false;
            bool Recreate_16 = false;
            var State_Output_19 = this.__p_Dx5dRlyJsXVMb5JPUcK50m.Update(Size_In: Output_8, Initial_Data_In: Initial_Data_10, Array_Size_In: Array_Size_11, Mip_Levels_In: Mip_Levels_12, Format_In: Output_9, Is_Unordered_Access_In: Is_Unordered_Access_13, Is_Render_Target_In: __pad_LOF0GFRsudBOxnCnkOTnQt_0, Is_Depth_Stencil_In: Is_Depth_Stencil_14, Is_Shared_In: Is_Shared_15, Recreate_In: Recreate_16, Output_Out: out n7.Texture Output_17, Has_Changed_Out: out bool Has_Changed_18);
            n29._Operations_.Switch_Boolean<n7.Texture>(Condition_In: Loaded_7, Input_In: Output_17, Input_2_In: Output_2, Output_Out: out n7.Texture Output_20);
            n25.ObjectHelpers.IsAssigned(x: Output_17, result: out bool Result_21, notAssigned: out bool Not_Assigned_22);
            int Index_23 = 0;
            n22._Operations_.SetItem<n7.Texture>(Input_In: __pad_IE6VbHata26Nz4uyTauJWQ_1, Index_In: Index_23, Value_In: Output_20, Output_Out: out n7.Texture[] Output_24);
            Texture_Inputs_Out = Output_24;
            Render_Target_Out = Output_17;
            Loaded_Out = Result_21;
            n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh that_25 = this;
            if (this.__GetContext__().IsImmutable)
                that_25 = State_Output_19 != this.__p_Dx5dRlyJsXVMb5JPUcK50m ? new RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh(this)
                {__p_Dx5dRlyJsXVMb5JPUcK50m = State_Output_19} : that_25;
            else
            {
                this.__p_Dx5dRlyJsXVMb5JPUcK50m = State_Output_19;
            }

            return that_25;
        }

        public n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "IRcZRqqGqTbN5XeYUhRXIm", 33295U);
            int Length_1 = 1;
            n22._Operations_.Create<n7.Texture>(Node_Context: Node_Context_0, Length_In: Length_1, Result_Out: out n7.Texture[] Result_2);
            n7.Texture[] __pad_IE6VbHata26Nz4uyTauJWQ_3 = Result_2;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "Dx5dRlyJsXVMb5JPUcK50m", 33263U);
            var Output_5 = n30.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy.Create(Node_Context: Node_Context_4);
            n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh that_6 = this;
            this.__slot_IE6VbHata26Nz4uyTauJWQ = Result_2;
            this.__p_Dx5dRlyJsXVMb5JPUcK50m = Output_5;
            return that_6;
        }

        public n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh __CreateDefault__()
        {
            n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh that_0 = this;
            this.__slot_IE6VbHata26Nz4uyTauJWQ = n22._Operations_.CreateDefault<n7.Texture>();
            this.__p_Dx5dRlyJsXVMb5JPUcK50m = n30.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Dx5dRlyJsXVMb5JPUcK50m);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 33289U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "LOF0GFRsudBOxnCnkOTnQt", Name = "__slot_LOF0GFRsudBOxnCnkOTnQt")]
        public static bool __slot_LOF0GFRsudBOxnCnkOTnQt = true;
        [n1.ElementAttribute(TracingId = 33329U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "IE6VbHata26Nz4uyTauJWQ", Name = "__slot_IE6VbHata26Nz4uyTauJWQ")]
        public n7.Texture[] __slot_IE6VbHata26Nz4uyTauJWQ;
        [n1.ElementAttribute(TracingId = 33263U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "Dx5dRlyJsXVMb5JPUcK50m", Name = "ComputeTexture2D", IsManaged = true, IsAutoGenerated = true)]
        public n30.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_Dx5dRlyJsXVMb5JPUcK50m;
        static RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh()
        {
        }

        public RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh(RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh other): base(other)
        {
            this.__slot_IE6VbHata26Nz4uyTauJWQ = other.__slot_IE6VbHata26Nz4uyTauJWQ;
            this.__p_Dx5dRlyJsXVMb5JPUcK50m = other.__p_Dx5dRlyJsXVMb5JPUcK50m;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_IE6VbHata26Nz4uyTauJWQ", in __slot_IE6VbHata26Nz4uyTauJWQ), n1.CompilationHelper.GetValueOrExisting(values, "__p_Dx5dRlyJsXVMb5JPUcK50m", in __p_Dx5dRlyJsXVMb5JPUcK50m));
        }

        internal RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh __WITH__(n7.Texture[] __slot_IE6VbHata26Nz4uyTauJWQ, n30.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_Dx5dRlyJsXVMb5JPUcK50m)
        {
            n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_IE6VbHata26Nz4uyTauJWQ != this.__slot_IE6VbHata26Nz4uyTauJWQ || __p_Dx5dRlyJsXVMb5JPUcK50m != this.__p_Dx5dRlyJsXVMb5JPUcK50m ? new RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh(this)
                {__slot_IE6VbHata26Nz4uyTauJWQ = __slot_IE6VbHata26Nz4uyTauJWQ, __p_Dx5dRlyJsXVMb5JPUcK50m = __p_Dx5dRlyJsXVMb5JPUcK50m} : that_0;
            else
            {
                this.__slot_IE6VbHata26Nz4uyTauJWQ = __slot_IE6VbHata26Nz4uyTauJWQ;
                this.__p_Dx5dRlyJsXVMb5JPUcK50m = __p_Dx5dRlyJsXVMb5JPUcK50m;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 41795U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "HoI1m5RbT1KL8Qev8rb3S3", Name = "RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3")]
    [n2.SerializableAttribute]
    public class RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n8.RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3 Create(n1.NodeContext Node_Context)
        {
            var instance = new RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n8.RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3 CreateDefault()
        {
            var instance = new RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n8.RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3 Update(n7.Texture Input_In, n7.Texture Input_2_In, int Use_Input_In, n6.Int2 Size_In, [n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat New_Format_In, out n7.Texture[] Shader_Inputs_Out, out n7.Texture Render_Target_Out, out bool Loaded_Out)
        {
            n7.Texture[] __pad_GzOHfHnXYwyP2erBCOHqvx_0 = this.__slot_GzOHfHnXYwyP2erBCOHqvx;
            bool __pad_TUrX158dQz6NCxxOlWqHmf_1 = __slot_TUrX158dQz6NCxxOlWqHmf;
            int Index_2 = 0;
            n22._Operations_.SetItem<n7.Texture>(Input_In: __pad_GzOHfHnXYwyP2erBCOHqvx_0, Index_In: Index_2, Value_In: Input_In, Output_Out: out n7.Texture[] Output_3);
            int Index_4 = 1;
            n22._Operations_.SetItem<n7.Texture>(Input_In: Output_3, Index_In: Index_4, Value_In: Input_2_In, Output_Out: out n7.Texture[] Output_5);
            var builder_6 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB, 2);
            builder_6.Add(Input_In);
            builder_6.Add(Input_2_In);
            var __pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB_7 = builder_6.Commit();
            n32._Operations_.Switch<n7.Texture, n13.__AdaptiveImplementations__BzGvoB2aLhzP7WO4jVw5sI>(Index_In: Use_Input_In, Input_In: __pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB_7, Output_Out: out n7.Texture Output_8);
            n26._Operations_.TextureInfo_Basic(Input_In: Output_8, Output_Out: out n7.Texture Output_9, Size_Out: out n6.Int2 Size_10, Width_Out: out int Width_11, Height_Out: out int Height_12, Format_Out: out n9.PixelFormat Format_13, Loaded_Out: out bool Loaded_14);
            n27._Operations_.ReplaceSize(Size_In: Size_10, Replace_Size_In: Size_In, Output_Out: out n6.Int2 Output_15);
            n27._Operations_.ReplaceFormat(Input_In: Format_13, New_Format_In: New_Format_In, Output_Out: out n9.PixelFormat Output_16);
            n28.IGraphicsDataProvider[] Initial_Data_17 = n22._Operations_.CreateDefault<n28.IGraphicsDataProvider>();
            int Array_Size_18 = 1;
            int Mip_Levels_19 = 1;
            bool Is_Unordered_Access_20 = true;
            bool Is_Depth_Stencil_21 = false;
            bool Is_Shared_22 = false;
            bool Recreate_23 = false;
            var State_Output_26 = this.__p_RlZj9C4xFHGMTppy6wVsNS.Update(Size_In: Output_15, Initial_Data_In: Initial_Data_17, Array_Size_In: Array_Size_18, Mip_Levels_In: Mip_Levels_19, Format_In: Output_16, Is_Unordered_Access_In: Is_Unordered_Access_20, Is_Render_Target_In: __pad_TUrX158dQz6NCxxOlWqHmf_1, Is_Depth_Stencil_In: Is_Depth_Stencil_21, Is_Shared_In: Is_Shared_22, Recreate_In: Recreate_23, Output_Out: out n7.Texture Output_24, Has_Changed_Out: out bool Has_Changed_25);
            Shader_Inputs_Out = Output_5;
            Render_Target_Out = Output_24;
            Loaded_Out = Loaded_14;
            n8.RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3 that_27 = this;
            if (this.__GetContext__().IsImmutable)
                that_27 = __pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB_7 != this.__pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB || State_Output_26 != this.__p_RlZj9C4xFHGMTppy6wVsNS ? new RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3(this)
                {__pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB = __pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB_7, __p_RlZj9C4xFHGMTppy6wVsNS = State_Output_26} : that_27;
            else
            {
                this.__pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB = __pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB_7;
                this.__p_RlZj9C4xFHGMTppy6wVsNS = State_Output_26;
            }

            return that_27;
        }

        public n8.RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3 __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "PhyeYinL8GHPXPG8kwHmcU", 41814U);
            int Length_1 = 2;
            n22._Operations_.Create<n7.Texture>(Node_Context: Node_Context_0, Length_In: Length_1, Result_Out: out n7.Texture[] Result_2);
            n7.Texture[] __pad_GzOHfHnXYwyP2erBCOHqvx_3 = Result_2;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "RlZj9C4xFHGMTppy6wVsNS", 41802U);
            var Output_5 = n30.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy.Create(Node_Context: Node_Context_4);
            n8.RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3 that_6 = this;
            this.__slot_GzOHfHnXYwyP2erBCOHqvx = Result_2;
            this.__pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB = n33._Operations_.CreateDefault<n7.Texture>();
            this.__p_RlZj9C4xFHGMTppy6wVsNS = Output_5;
            return that_6;
        }

        public n8.RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3 __CreateDefault__()
        {
            n8.RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3 that_0 = this;
            this.__slot_GzOHfHnXYwyP2erBCOHqvx = n22._Operations_.CreateDefault<n7.Texture>();
            this.__pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB = n33._Operations_.CreateDefault<n7.Texture>();
            this.__p_RlZj9C4xFHGMTppy6wVsNS = n30.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_RlZj9C4xFHGMTppy6wVsNS);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 41810U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "TUrX158dQz6NCxxOlWqHmf", Name = "__slot_TUrX158dQz6NCxxOlWqHmf")]
        public static bool __slot_TUrX158dQz6NCxxOlWqHmf = true;
        [n1.ElementAttribute(TracingId = 41830U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "GzOHfHnXYwyP2erBCOHqvx", Name = "__slot_GzOHfHnXYwyP2erBCOHqvx")]
        public n7.Texture[] __slot_GzOHfHnXYwyP2erBCOHqvx;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n31.Spread<n7.Texture> __pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB = default(n31.Spread<n7.Texture>);
        [n1.ElementAttribute(TracingId = 41802U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "RlZj9C4xFHGMTppy6wVsNS", Name = "ComputeTexture2D", IsManaged = true, IsAutoGenerated = true)]
        public n30.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_RlZj9C4xFHGMTppy6wVsNS;
        static RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3()
        {
        }

        public RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3(RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3 other): base(other)
        {
            this.__slot_GzOHfHnXYwyP2erBCOHqvx = other.__slot_GzOHfHnXYwyP2erBCOHqvx;
            this.__pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB = other.__pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB;
            this.__p_RlZj9C4xFHGMTppy6wVsNS = other.__p_RlZj9C4xFHGMTppy6wVsNS;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_GzOHfHnXYwyP2erBCOHqvx", in __slot_GzOHfHnXYwyP2erBCOHqvx), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB", in __pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB), n1.CompilationHelper.GetValueOrExisting(values, "__p_RlZj9C4xFHGMTppy6wVsNS", in __p_RlZj9C4xFHGMTppy6wVsNS));
        }

        internal RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3 __WITH__(n7.Texture[] __slot_GzOHfHnXYwyP2erBCOHqvx, n31.Spread<n7.Texture> __pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB, n30.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_RlZj9C4xFHGMTppy6wVsNS)
        {
            n8.RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_GzOHfHnXYwyP2erBCOHqvx != this.__slot_GzOHfHnXYwyP2erBCOHqvx || __pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB != this.__pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB || __p_RlZj9C4xFHGMTppy6wVsNS != this.__p_RlZj9C4xFHGMTppy6wVsNS ? new RenderTargetFrom2Inputs_HoI1m5RbT1KL8Qev8rb3S3(this)
                {__slot_GzOHfHnXYwyP2erBCOHqvx = __slot_GzOHfHnXYwyP2erBCOHqvx, __pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB = __pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB, __p_RlZj9C4xFHGMTppy6wVsNS = __p_RlZj9C4xFHGMTppy6wVsNS} : that_0;
            else
            {
                this.__slot_GzOHfHnXYwyP2erBCOHqvx = __slot_GzOHfHnXYwyP2erBCOHqvx;
                this.__pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB = __pin_group_Input_In_TeDPckcE8HAOzxQyHBIVgB;
                this.__p_RlZj9C4xFHGMTppy6wVsNS = __p_RlZj9C4xFHGMTppy6wVsNS;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 41948U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "PJIIm3Cdxn0PvwywMQZ6ha", Name = "TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha")]
    [n2.SerializableAttribute]
    public class TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n8.TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha Create(n1.NodeContext Node_Context)
        {
            var instance = new TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n8.TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha CreateDefault()
        {
            var instance = new TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n8.TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha Update(n7.Texture Input_In, n16.SetVar<n6.Vector4> Root_In, n6.Int2 Size_In, [n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat New_Format_In, out n7.Texture Output_Out)
        {
            bool __pad_VDyq7j9mxvjOsGPtu1i02f_0 = __slot_VDyq7j9mxvjOsGPtu1i02f;
            bool __pad_JPQuqKYJkA9Lv4KTvWmwAt_1 = __slot_JPQuqKYJkA9Lv4KTvWmwAt;
            var Output_5 = this.__p_M3EgLjEpBkyLiItLeCQL4l.Update(Input_In: Input_In, Size_In: Size_In, New_Format_In: New_Format_In, Texture_Inputs_Out: out n7.Texture[] Texture_Inputs_2, Render_Target_Out: out n7.Texture Render_Target_3, Loaded_Out: out bool Loaded_4);
            n7.Texture[] __pad_BvZu4eh0WVvQNsu6GoX9qW_6 = Texture_Inputs_2;
            bool Force_7 = false;
            var manager_8 = this.__cache_KvdqzZMSHzDM5lhaXkBuWJ;
            if (manager_8 is null)
            {
                manager_8 = new n19.Manager<n2.ValueTuple<n16.SetVar<n6.Vector4>>, n2.ValueTuple<n34.TextureFXEffect>>(n2.ValueTuple.Create(default(n34.TextureFXEffect)));
            }

            var inputs_9 = n2.ValueTuple.Create(Root_In);
            var outputs_10 = manager_8.Outputs;
            var Has_Changed_11 = Force_7 || manager_8.InputsChanged(inputs_9);
            if (Has_Changed_11)
            {
                if (__pad_VDyq7j9mxvjOsGPtu1i02f_0)
                    manager_8.DisposeOutputs();
                var state_12 = n1.CompilationHelper.Restore<__LccDdAffRmVNLXyB9hoJIE>(manager_8.State, __GetContext__());
                if (state_12 == null)
                {
                    state_12 = new __LccDdAffRmVNLXyB9hoJIE(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "MjIVyMzEdVqLyJa9Cnk9UH", 42539U);
                    var Output_14 = n35.GraphicsDevice_V0mXf77TurpOVQNzgviejb.Create(Node_Context_In: Node_Context_13);
                    state_12.__p_MjIVyMzEdVqLyJa9Cnk9UH = Output_14;
                }

                var State_Output_16 = state_12.__p_MjIVyMzEdVqLyJa9Cnk9UH.Update(Output_Out: out n7.GraphicsDevice Output_15);
                n6.Vector4 Default_Value_17 = n36._Operations_.CreateDefault();
                n37._Operations_.GetVarValue<n6.Vector4>(Input_In: Root_In, Default_Value_In: Default_Value_17, Result_Out: out n16.IComputeValue<n6.Vector4> Result_18);
                n38.IComputeNode Root_19 = (n38.IComputeNode)Result_18;
                n11.IEnumerable<n38.IComputeNode> Excludes_20 = n39._Operations_.CreateDefault<n38.IComputeNode>();
                var Result_21 = n16.ShaderGraph.BuildFinalShaderGraph(root: Root_19, excludes: Excludes_20);
                var Output_22 = new n40.Do<n6.Vector4>(before: Result_21, value: Result_18);
                n16.IComputeValue<n6.Vector4> Root_23 = (n16.IComputeValue<n6.Vector4>)Output_22;
                var Result_24 = n16.ShaderGraph.ComposeShader(graphicsDevice: Output_15, root: Root_23);
                if (state_12.__GetContext__().IsImmutable)
                    state_12 = State_Output_16 != state_12.__p_MjIVyMzEdVqLyJa9Cnk9UH ? new __LccDdAffRmVNLXyB9hoJIE(state_12)
                    {__p_MjIVyMzEdVqLyJa9Cnk9UH = State_Output_16} : state_12;
                else
                {
                    state_12.__p_MjIVyMzEdVqLyJa9Cnk9UH = State_Output_16;
                }

                outputs_10 = n2.ValueTuple.Create(Result_24);
                manager_8 = manager_8.Update(inputs_9, __GetContext__().IsImmutable, __pad_VDyq7j9mxvjOsGPtu1i02f_0, state_12, outputs_10);
            }
            else
            {
                manager_8.Update(inputs_9, __GetContext__().IsImmutable, __pad_VDyq7j9mxvjOsGPtu1i02f_0);
            }

            var __auto_25 = outputs_10.Item1;
            n5.IImageEffect Effect_26 = (n5.IImageEffect)__auto_25;
            n11.IEnumerable<n7.Texture> Inputs_27 = n39._Operations_.CreateDefault<n7.Texture>();
            n7.Texture[] Outputs_28 = n22._Operations_.CreateDefault<n7.Texture>();
            bool Update_29 = true;
            var Output_30 = this.__p_Q7Gg1ZNC3jZOe2zFOBqlQT;
            if (Update_29)
            {
                Output_30 = this.__p_Q7Gg1ZNC3jZOe2zFOBqlQT.Update(Effect_In: Effect_26, Inputs_In: Inputs_27, Output_In: Render_Target_3, Outputs_In: Outputs_28, Enabled_In: Loaded_4);
            }

            n23.IGraphicsRendererBase Renderer_31 = (n23.IGraphicsRendererBase)Output_30;
            var Output_32 = this.__p_REtSLf22VmuNu13iVbUj2k;
            if (__pad_JPQuqKYJkA9Lv4KTvWmwAt_1)
            {
                Output_32 = this.__p_REtSLf22VmuNu13iVbUj2k.Schedule(Renderer_In: Renderer_31);
            }

            Output_Out = Render_Target_3;
            n8.TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha that_33 = this;
            if (this.__GetContext__().IsImmutable)
                that_33 = Output_5 != this.__p_M3EgLjEpBkyLiItLeCQL4l || Texture_Inputs_2 != this.__slot_BvZu4eh0WVvQNsu6GoX9qW || manager_8 != this.__cache_KvdqzZMSHzDM5lhaXkBuWJ || Output_30 != this.__p_Q7Gg1ZNC3jZOe2zFOBqlQT || Output_32 != this.__p_REtSLf22VmuNu13iVbUj2k ? new TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha(this)
                {__p_M3EgLjEpBkyLiItLeCQL4l = Output_5, __slot_BvZu4eh0WVvQNsu6GoX9qW = Texture_Inputs_2, __cache_KvdqzZMSHzDM5lhaXkBuWJ = manager_8, __p_Q7Gg1ZNC3jZOe2zFOBqlQT = Output_30, __p_REtSLf22VmuNu13iVbUj2k = Output_32} : that_33;
            else
            {
                this.__p_M3EgLjEpBkyLiItLeCQL4l = Output_5;
                this.__slot_BvZu4eh0WVvQNsu6GoX9qW = Texture_Inputs_2;
                this.__cache_KvdqzZMSHzDM5lhaXkBuWJ = manager_8;
                this.__p_Q7Gg1ZNC3jZOe2zFOBqlQT = Output_30;
                this.__p_REtSLf22VmuNu13iVbUj2k = Output_32;
            }

            return that_33;
        }

        public n8.TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "Q7Gg1ZNC3jZOe2zFOBqlQT", 41954U);
            var Output_1 = n8.TextureFXDrawer_C.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "M3EgLjEpBkyLiItLeCQL4l", 41966U);
            var Output_3 = n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "REtSLf22VmuNu13iVbUj2k", 42564U);
            var Output_5 = n24.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D.Create(Node_Context: Node_Context_4);
            n8.TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha that_6 = this;
            this.__slot_BvZu4eh0WVvQNsu6GoX9qW = n22._Operations_.CreateDefault<n7.Texture>();
            this.__p_Q7Gg1ZNC3jZOe2zFOBqlQT = Output_1;
            this.__p_M3EgLjEpBkyLiItLeCQL4l = Output_3;
            this.__p_REtSLf22VmuNu13iVbUj2k = Output_5;
            this.__cache_KvdqzZMSHzDM5lhaXkBuWJ = null;
            return that_6;
        }

        public n8.TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha __CreateDefault__()
        {
            n8.TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha that_0 = this;
            this.__slot_BvZu4eh0WVvQNsu6GoX9qW = n22._Operations_.CreateDefault<n7.Texture>();
            this.__p_M3EgLjEpBkyLiItLeCQL4l = n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh.CreateDefault();
            this.__cache_KvdqzZMSHzDM5lhaXkBuWJ = null;
            this.__p_Q7Gg1ZNC3jZOe2zFOBqlQT = n8.TextureFXDrawer_C.CreateDefault();
            this.__p_REtSLf22VmuNu13iVbUj2k = n24.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_M3EgLjEpBkyLiItLeCQL4l);
            n1.CompilationHelper.SafeDispose(this.__cache_KvdqzZMSHzDM5lhaXkBuWJ);
            n1.CompilationHelper.SafeDispose(this.__p_Q7Gg1ZNC3jZOe2zFOBqlQT);
            n1.CompilationHelper.SafeDispose(this.__p_REtSLf22VmuNu13iVbUj2k);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 42562U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "BvZu4eh0WVvQNsu6GoX9qW", Name = "__slot_BvZu4eh0WVvQNsu6GoX9qW")]
        public n7.Texture[] __slot_BvZu4eh0WVvQNsu6GoX9qW;
        [n1.ElementAttribute(TracingId = 42580U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "JPQuqKYJkA9Lv4KTvWmwAt", Name = "__slot_JPQuqKYJkA9Lv4KTvWmwAt")]
        public static bool __slot_JPQuqKYJkA9Lv4KTvWmwAt = true;
        [n1.ElementAttribute(TracingId = 42585U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "VDyq7j9mxvjOsGPtu1i02f", Name = "__slot_VDyq7j9mxvjOsGPtu1i02f")]
        public static bool __slot_VDyq7j9mxvjOsGPtu1i02f = true;
        [n1.ElementAttribute(TracingId = 41966U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "M3EgLjEpBkyLiItLeCQL4l", Name = "RenderTargetFromInput", IsManaged = true, IsAutoGenerated = true)]
        public n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh __p_M3EgLjEpBkyLiItLeCQL4l;
        [n1.ElementAttribute(TracingId = 41987U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "KvdqzZMSHzDM5lhaXkBuWJ", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n19.Manager<n2.ValueTuple<n16.SetVar<n6.Vector4>>, n2.ValueTuple<n34.TextureFXEffect>> __cache_KvdqzZMSHzDM5lhaXkBuWJ = null;
        [n1.ElementAttribute(TracingId = 41954U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "Q7Gg1ZNC3jZOe2zFOBqlQT", Name = "TextureFXDrawer", IsManaged = true, IsAutoGenerated = true)]
        public n8.TextureFXDrawer_C __p_Q7Gg1ZNC3jZOe2zFOBqlQT;
        [n1.ElementAttribute(TracingId = 42564U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "REtSLf22VmuNu13iVbUj2k", Name = "RendererScheduler", IsManaged = true, IsAutoGenerated = true)]
        public n24.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D __p_REtSLf22VmuNu13iVbUj2k;
        static TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha()
        {
        }

        public TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha(TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha other): base(other)
        {
            this.__slot_BvZu4eh0WVvQNsu6GoX9qW = other.__slot_BvZu4eh0WVvQNsu6GoX9qW;
            this.__p_M3EgLjEpBkyLiItLeCQL4l = other.__p_M3EgLjEpBkyLiItLeCQL4l;
            this.__cache_KvdqzZMSHzDM5lhaXkBuWJ = other.__cache_KvdqzZMSHzDM5lhaXkBuWJ;
            this.__p_Q7Gg1ZNC3jZOe2zFOBqlQT = other.__p_Q7Gg1ZNC3jZOe2zFOBqlQT;
            this.__p_REtSLf22VmuNu13iVbUj2k = other.__p_REtSLf22VmuNu13iVbUj2k;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_BvZu4eh0WVvQNsu6GoX9qW", in __slot_BvZu4eh0WVvQNsu6GoX9qW), n1.CompilationHelper.GetValueOrExisting(values, "__p_M3EgLjEpBkyLiItLeCQL4l", in __p_M3EgLjEpBkyLiItLeCQL4l), n1.CompilationHelper.GetValueOrExisting(values, "__cache_KvdqzZMSHzDM5lhaXkBuWJ", in __cache_KvdqzZMSHzDM5lhaXkBuWJ), n1.CompilationHelper.GetValueOrExisting(values, "__p_Q7Gg1ZNC3jZOe2zFOBqlQT", in __p_Q7Gg1ZNC3jZOe2zFOBqlQT), n1.CompilationHelper.GetValueOrExisting(values, "__p_REtSLf22VmuNu13iVbUj2k", in __p_REtSLf22VmuNu13iVbUj2k));
        }

        internal TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha __WITH__(n7.Texture[] __slot_BvZu4eh0WVvQNsu6GoX9qW, n8.RenderTargetFromInput_TQTuf7FUMdCMBja7wK8kVh __p_M3EgLjEpBkyLiItLeCQL4l, n19.Manager<n2.ValueTuple<n16.SetVar<n6.Vector4>>, n2.ValueTuple<n34.TextureFXEffect>> __cache_KvdqzZMSHzDM5lhaXkBuWJ, n8.TextureFXDrawer_C __p_Q7Gg1ZNC3jZOe2zFOBqlQT, n24.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D __p_REtSLf22VmuNu13iVbUj2k)
        {
            n8.TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_BvZu4eh0WVvQNsu6GoX9qW != this.__slot_BvZu4eh0WVvQNsu6GoX9qW || __p_M3EgLjEpBkyLiItLeCQL4l != this.__p_M3EgLjEpBkyLiItLeCQL4l || __cache_KvdqzZMSHzDM5lhaXkBuWJ != this.__cache_KvdqzZMSHzDM5lhaXkBuWJ || __p_Q7Gg1ZNC3jZOe2zFOBqlQT != this.__p_Q7Gg1ZNC3jZOe2zFOBqlQT || __p_REtSLf22VmuNu13iVbUj2k != this.__p_REtSLf22VmuNu13iVbUj2k ? new TextureFXGraph_PJIIm3Cdxn0PvwywMQZ6ha(this)
                {__slot_BvZu4eh0WVvQNsu6GoX9qW = __slot_BvZu4eh0WVvQNsu6GoX9qW, __p_M3EgLjEpBkyLiItLeCQL4l = __p_M3EgLjEpBkyLiItLeCQL4l, __cache_KvdqzZMSHzDM5lhaXkBuWJ = __cache_KvdqzZMSHzDM5lhaXkBuWJ, __p_Q7Gg1ZNC3jZOe2zFOBqlQT = __p_Q7Gg1ZNC3jZOe2zFOBqlQT, __p_REtSLf22VmuNu13iVbUj2k = __p_REtSLf22VmuNu13iVbUj2k} : that_0;
            else
            {
                this.__slot_BvZu4eh0WVvQNsu6GoX9qW = __slot_BvZu4eh0WVvQNsu6GoX9qW;
                this.__p_M3EgLjEpBkyLiItLeCQL4l = __p_M3EgLjEpBkyLiItLeCQL4l;
                this.__cache_KvdqzZMSHzDM5lhaXkBuWJ = __cache_KvdqzZMSHzDM5lhaXkBuWJ;
                this.__p_Q7Gg1ZNC3jZOe2zFOBqlQT = __p_Q7Gg1ZNC3jZOe2zFOBqlQT;
                this.__p_REtSLf22VmuNu13iVbUj2k = __p_REtSLf22VmuNu13iVbUj2k;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "LccDdAffRmVNLXyB9hoJIE", Name = "__LccDdAffRmVNLXyB9hoJIE")]
        [n2.SerializableAttribute]
        public class __LccDdAffRmVNLXyB9hoJIE : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_MjIVyMzEdVqLyJa9Cnk9UH);
                return;
            }

            [n1.ElementAttribute(TracingId = 42539U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "MjIVyMzEdVqLyJa9Cnk9UH", Name = "GraphicsDevice", IsManaged = true, IsAutoGenerated = true)]
            public n35.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_MjIVyMzEdVqLyJa9Cnk9UH;
            public __LccDdAffRmVNLXyB9hoJIE(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __LccDdAffRmVNLXyB9hoJIE(__LccDdAffRmVNLXyB9hoJIE other): base(other)
            {
                this.__p_MjIVyMzEdVqLyJa9Cnk9UH = other.__p_MjIVyMzEdVqLyJa9Cnk9UH;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MjIVyMzEdVqLyJa9Cnk9UH", in __p_MjIVyMzEdVqLyJa9Cnk9UH));
            }

            internal __LccDdAffRmVNLXyB9hoJIE __WITH__(n35.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_MjIVyMzEdVqLyJa9Cnk9UH)
            {
                __LccDdAffRmVNLXyB9hoJIE that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_MjIVyMzEdVqLyJa9Cnk9UH != this.__p_MjIVyMzEdVqLyJa9Cnk9UH ? new __LccDdAffRmVNLXyB9hoJIE(this)
                    {__p_MjIVyMzEdVqLyJa9Cnk9UH = __p_MjIVyMzEdVqLyJa9Cnk9UH} : that_0;
                else
                {
                    this.__p_MjIVyMzEdVqLyJa9Cnk9UH = __p_MjIVyMzEdVqLyJa9Cnk9UH;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Stride_Rendering_TextureFX_.Stride.Textures.Utils
{
    [n1.ElementAttribute(TracingId = 44967U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "KMhnX1iRAMqQChHGljYrk4", Name = "Resize_Relative_C")]
    [n2.SerializableAttribute]
    public class Resize_Relative_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n41.Resize_Relative_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new Resize_Relative_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n41.Resize_Relative_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new Resize_Relative_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n41.Resize_Relative_C Update(out n7.Texture Output_Out)
        {
            n1.CompilationHelper.ReadPin(this.__p_RQKw4lWFxYUL19qhP8KfYN.Outputs[0], out n7.Texture out_0);
            this.__p_RQKw4lWFxYUL19qhP8KfYN = this.__p_RQKw4lWFxYUL19qhP8KfYN;
            Output_Out = out_0;
            return this;
        }

        public n41.Resize_Relative_C SetInput(n7.Texture Input_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n6.Vector2 Size_Scale_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RQKw4lWFxYUL19qhP8KfYN.Inputs[0], ref Input_In);
            this.__p_RQKw4lWFxYUL19qhP8KfYN = this.__p_RQKw4lWFxYUL19qhP8KfYN;
            n25.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            n6.Int2 __auto_2;
            if (Result_0)
            {
                var View_Width_4 = Input_In.ViewWidth;
                float X_5 = (float)View_Width_4;
                var View_Height_6 = Input_In.ViewHeight;
                float Y_7 = (float)View_Height_6;
                var Output_8 = new n6.Vector2(x: X_5, y: Y_7);
                n42.Vector2Nodes.Multiply(left: ref Output_8, right: ref Size_Scale_In, result: out n6.Vector2 Output_9);
                n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "IUg37LmLkcIMO6SuCcIcvY", 45017U);
                n43._Operations_.Create(Node_Context: Node_Context_10, Value_In: Output_9, Output_Out: out n6.Int2 Output_11);
                __auto_2 = Output_11;
            }
            else
            {
                __auto_2 = default(n6.Int2);
            }

            n1.CompilationHelper.WritePin(this.__p_RQKw4lWFxYUL19qhP8KfYN.Inputs[5], ref __auto_2);
            this.__p_RQKw4lWFxYUL19qhP8KfYN = this.__p_RQKw4lWFxYUL19qhP8KfYN;
            return this;
        }

        public n41.Resize_Relative_C SetMode([n4.SerializedDefaultValueAttribute("Linear", false)] n17.ResizeInterpolationType Mode_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RQKw4lWFxYUL19qhP8KfYN.Inputs[3], ref Mode_In);
            this.__p_RQKw4lWFxYUL19qhP8KfYN = this.__p_RQKw4lWFxYUL19qhP8KfYN;
            return this;
        }

        public n41.Resize_Relative_C SetOutputFormat([n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat Output_Format_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RQKw4lWFxYUL19qhP8KfYN.Inputs[6], ref Output_Format_In);
            this.__p_RQKw4lWFxYUL19qhP8KfYN = this.__p_RQKw4lWFxYUL19qhP8KfYN;
            return this;
        }

        public n41.Resize_Relative_C SetRenderFormat([n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat Render_Format_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RQKw4lWFxYUL19qhP8KfYN.Inputs[7], ref Render_Format_In);
            this.__p_RQKw4lWFxYUL19qhP8KfYN = this.__p_RQKw4lWFxYUL19qhP8KfYN;
            return this;
        }

        public n41.Resize_Relative_C SetOutputTexture(n7.Texture Output_Texture_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RQKw4lWFxYUL19qhP8KfYN.Inputs[4], ref Output_Texture_In);
            this.__p_RQKw4lWFxYUL19qhP8KfYN = this.__p_RQKw4lWFxYUL19qhP8KfYN;
            return this;
        }

        public n41.Resize_Relative_C SetApply([n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RQKw4lWFxYUL19qhP8KfYN.Inputs[8], ref Apply_In);
            this.__p_RQKw4lWFxYUL19qhP8KfYN = this.__p_RQKw4lWFxYUL19qhP8KfYN;
            return this;
        }

        public n41.Resize_Relative_C __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "Resize", "Stride.Textures.Utils");
            this.__p_RQKw4lWFxYUL19qhP8KfYN = node_0;
            return this;
        }

        public n41.Resize_Relative_C __CreateDefault__()
        {
            this.__p_RQKw4lWFxYUL19qhP8KfYN = default(n1.IVLNode);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_RQKw4lWFxYUL19qhP8KfYN);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 44970U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "RQKw4lWFxYUL19qhP8KfYN", Name = "Resize", IsManaged = true, IsAutoGenerated = true, NodeName = "Resize", NodeCategory = "Stride.Textures.Utils")]
        public n1.IVLNode __p_RQKw4lWFxYUL19qhP8KfYN;
        public Resize_Relative_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Resize_Relative_C(Resize_Relative_C other): base(other)
        {
            this.__p_RQKw4lWFxYUL19qhP8KfYN = other.__p_RQKw4lWFxYUL19qhP8KfYN;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RQKw4lWFxYUL19qhP8KfYN", in __p_RQKw4lWFxYUL19qhP8KfYN));
        }

        internal Resize_Relative_C __WITH__(n1.IVLNode __p_RQKw4lWFxYUL19qhP8KfYN)
        {
            n41.Resize_Relative_C that_0 = this;
            this.__p_RQKw4lWFxYUL19qhP8KfYN = __p_RQKw4lWFxYUL19qhP8KfYN;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 45120U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "GwkPxFfWmJbP7A1hB1PVvI", Name = "Crop_Relative_C")]
    [n2.SerializableAttribute]
    public class Crop_Relative_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n41.Crop_Relative_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new Crop_Relative_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n41.Crop_Relative_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new Crop_Relative_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n41.Crop_Relative_C Update(out n7.Texture Output_Out)
        {
            n1.CompilationHelper.ReadPin(this.__p_K6eVBXP1iv7QNZ4LtvK0mw.Outputs[0], out n7.Texture out_0);
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = this.__p_K6eVBXP1iv7QNZ4LtvK0mw;
            Output_Out = out_0;
            return this;
        }

        public n41.Crop_Relative_C SetInput(n7.Texture Input_In, [n4.SerializedDefaultValueAttribute("0, 0", false)] n6.Vector2 Top_Left_In, [n4.SerializedDefaultValueAttribute("1, 1", false)] n6.Vector2 Size_In, n6.Int2 Output_Size_In)
        {
            n1.CompilationHelper.WritePin(this.__p_K6eVBXP1iv7QNZ4LtvK0mw.Inputs[0], ref Input_In);
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = this.__p_K6eVBXP1iv7QNZ4LtvK0mw;
            n1.CompilationHelper.WritePin(this.__p_K6eVBXP1iv7QNZ4LtvK0mw.Inputs[3], ref Top_Left_In);
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = this.__p_K6eVBXP1iv7QNZ4LtvK0mw;
            n1.CompilationHelper.WritePin(this.__p_K6eVBXP1iv7QNZ4LtvK0mw.Inputs[4], ref Size_In);
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = this.__p_K6eVBXP1iv7QNZ4LtvK0mw;
            n25.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            n6.Int2 __auto_2;
            if (Result_0)
            {
                var View_Width_4 = Input_In.ViewWidth;
                float X_5 = (float)View_Width_4;
                var View_Height_6 = Input_In.ViewHeight;
                float Y_7 = (float)View_Height_6;
                var Output_8 = new n6.Vector2(x: X_5, y: Y_7);
                n42.Vector2Nodes.Multiply(left: ref Output_8, right: ref Size_In, result: out n6.Vector2 Output_9);
                n1.NodeContext Node_Context_10 = __GetContext__().CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "CsaREzWehyQPhEpuEqH8vw", 45227U);
                n43._Operations_.Create(Node_Context: Node_Context_10, Value_In: Output_9, Output_Out: out n6.Int2 Output_11);
                n27._Operations_.ReplaceSize(Size_In: Output_11, Replace_Size_In: Output_Size_In, Output_Out: out n6.Int2 Output_12);
                __auto_2 = Output_12;
            }
            else
            {
                __auto_2 = default(n6.Int2);
            }

            n1.CompilationHelper.WritePin(this.__p_K6eVBXP1iv7QNZ4LtvK0mw.Inputs[7], ref __auto_2);
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = this.__p_K6eVBXP1iv7QNZ4LtvK0mw;
            return this;
        }

        public n41.Crop_Relative_C SetMode([n4.SerializedDefaultValueAttribute("NearestNeighbor", false)] n17.ResizeInterpolationType Mode_In)
        {
            n1.CompilationHelper.WritePin(this.__p_K6eVBXP1iv7QNZ4LtvK0mw.Inputs[5], ref Mode_In);
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = this.__p_K6eVBXP1iv7QNZ4LtvK0mw;
            return this;
        }

        public n41.Crop_Relative_C SetOutputFormat([n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat Output_Format_In)
        {
            n1.CompilationHelper.WritePin(this.__p_K6eVBXP1iv7QNZ4LtvK0mw.Inputs[8], ref Output_Format_In);
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = this.__p_K6eVBXP1iv7QNZ4LtvK0mw;
            return this;
        }

        public n41.Crop_Relative_C SetRenderFormat([n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat Render_Format_In)
        {
            n1.CompilationHelper.WritePin(this.__p_K6eVBXP1iv7QNZ4LtvK0mw.Inputs[9], ref Render_Format_In);
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = this.__p_K6eVBXP1iv7QNZ4LtvK0mw;
            return this;
        }

        public n41.Crop_Relative_C SetOutputTexture(n7.Texture Output_Texture_In)
        {
            n1.CompilationHelper.WritePin(this.__p_K6eVBXP1iv7QNZ4LtvK0mw.Inputs[6], ref Output_Texture_In);
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = this.__p_K6eVBXP1iv7QNZ4LtvK0mw;
            return this;
        }

        public n41.Crop_Relative_C SetApply([n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In)
        {
            n1.CompilationHelper.WritePin(this.__p_K6eVBXP1iv7QNZ4LtvK0mw.Inputs[10], ref Apply_In);
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = this.__p_K6eVBXP1iv7QNZ4LtvK0mw;
            return this;
        }

        public n41.Crop_Relative_C SetPointSampler(n7.SamplerState Point_Sampler_In)
        {
            n1.CompilationHelper.WritePin(this.__p_K6eVBXP1iv7QNZ4LtvK0mw.Inputs[1], ref Point_Sampler_In);
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = this.__p_K6eVBXP1iv7QNZ4LtvK0mw;
            return this;
        }

        public n41.Crop_Relative_C SetLinearSampler(n7.SamplerState Linear_Sampler_In)
        {
            n1.CompilationHelper.WritePin(this.__p_K6eVBXP1iv7QNZ4LtvK0mw.Inputs[2], ref Linear_Sampler_In);
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = this.__p_K6eVBXP1iv7QNZ4LtvK0mw;
            return this;
        }

        public n41.Crop_Relative_C __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "Crop (Internal)", "Stride.Textures.Utils");
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = node_0;
            return this;
        }

        public n41.Crop_Relative_C __CreateDefault__()
        {
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = default(n1.IVLNode);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_K6eVBXP1iv7QNZ4LtvK0mw);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 45123U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "K6eVBXP1iv7QNZ4LtvK0mw", Name = "Crop", IsManaged = true, IsAutoGenerated = true, NodeName = "Crop (Internal)", NodeCategory = "Stride.Textures.Utils")]
        public n1.IVLNode __p_K6eVBXP1iv7QNZ4LtvK0mw;
        public Crop_Relative_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Crop_Relative_C(Crop_Relative_C other): base(other)
        {
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = other.__p_K6eVBXP1iv7QNZ4LtvK0mw;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_K6eVBXP1iv7QNZ4LtvK0mw", in __p_K6eVBXP1iv7QNZ4LtvK0mw));
        }

        internal Crop_Relative_C __WITH__(n1.IVLNode __p_K6eVBXP1iv7QNZ4LtvK0mw)
        {
            n41.Crop_Relative_C that_0 = this;
            this.__p_K6eVBXP1iv7QNZ4LtvK0mw = __p_K6eVBXP1iv7QNZ4LtvK0mw;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 45404U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "HzvOknOScWOLH7cwA7AiVx", Name = "Crop_C")]
    [n2.SerializableAttribute]
    public class Crop_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n41.Crop_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new Crop_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n41.Crop_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new Crop_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n41.Crop_C Update(out n7.Texture Output_Out)
        {
            n1.CompilationHelper.ReadPin(this.__p_VRbjdQ7QisiO0MqhSMbgkA.Outputs[0], out n7.Texture out_0);
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = this.__p_VRbjdQ7QisiO0MqhSMbgkA;
            Output_Out = out_0;
            return this;
        }

        public n41.Crop_C SetInput(n7.Texture Input_In, n6.Int2 Top_Left_In, [n4.SerializedDefaultValueAttribute("64, 64", false)] n6.Int2 Size_In, n6.Int2 Output_Size_In)
        {
            n1.CompilationHelper.WritePin(this.__p_VRbjdQ7QisiO0MqhSMbgkA.Inputs[0], ref Input_In);
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = this.__p_VRbjdQ7QisiO0MqhSMbgkA;
            n25.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            n6.Vector2 __auto_2;
            n6.Vector2 __auto_3;
            n6.Int2 __auto_4;
            if (Result_0)
            {
                var View_Width_6 = Input_In.ViewWidth;
                float X_7 = (float)View_Width_6;
                var View_Height_8 = Input_In.ViewHeight;
                float Y_9 = (float)View_Height_8;
                var Output_10 = new n6.Vector2(x: X_7, y: Y_9);
                var Result_11 = (n6.Vector2)Size_In;
                var Output_12 = (n6.Vector2)Result_11 / Output_10;
                __auto_3 = Output_12;
                var Result_13 = (n6.Vector2)Top_Left_In;
                var Output_14 = (n6.Vector2)Result_13 / Output_10;
                __auto_2 = Output_14;
                n27._Operations_.ReplaceSize(Size_In: Size_In, Replace_Size_In: Output_Size_In, Output_Out: out n6.Int2 Output_15);
                __auto_4 = Output_15;
            }
            else
            {
                __auto_2 = n44._Operations_.CreateDefault();
                __auto_3 = n44._Operations_.CreateDefault();
                __auto_4 = default(n6.Int2);
            }

            n1.CompilationHelper.WritePin(this.__p_VRbjdQ7QisiO0MqhSMbgkA.Inputs[3], ref __auto_2);
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = this.__p_VRbjdQ7QisiO0MqhSMbgkA;
            n1.CompilationHelper.WritePin(this.__p_VRbjdQ7QisiO0MqhSMbgkA.Inputs[4], ref __auto_3);
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = this.__p_VRbjdQ7QisiO0MqhSMbgkA;
            n1.CompilationHelper.WritePin(this.__p_VRbjdQ7QisiO0MqhSMbgkA.Inputs[7], ref __auto_4);
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = this.__p_VRbjdQ7QisiO0MqhSMbgkA;
            return this;
        }

        public n41.Crop_C SetMode([n4.SerializedDefaultValueAttribute("NearestNeighbor", false)] n17.ResizeInterpolationType Mode_In)
        {
            n1.CompilationHelper.WritePin(this.__p_VRbjdQ7QisiO0MqhSMbgkA.Inputs[5], ref Mode_In);
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = this.__p_VRbjdQ7QisiO0MqhSMbgkA;
            return this;
        }

        public n41.Crop_C SetOutputFormat([n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat Output_Format_In)
        {
            n1.CompilationHelper.WritePin(this.__p_VRbjdQ7QisiO0MqhSMbgkA.Inputs[8], ref Output_Format_In);
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = this.__p_VRbjdQ7QisiO0MqhSMbgkA;
            return this;
        }

        public n41.Crop_C SetRenderFormat([n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat Render_Format_In)
        {
            n1.CompilationHelper.WritePin(this.__p_VRbjdQ7QisiO0MqhSMbgkA.Inputs[9], ref Render_Format_In);
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = this.__p_VRbjdQ7QisiO0MqhSMbgkA;
            return this;
        }

        public n41.Crop_C SetOutputTexture(n7.Texture Output_Texture_In)
        {
            n1.CompilationHelper.WritePin(this.__p_VRbjdQ7QisiO0MqhSMbgkA.Inputs[6], ref Output_Texture_In);
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = this.__p_VRbjdQ7QisiO0MqhSMbgkA;
            return this;
        }

        public n41.Crop_C SetApply([n4.SerializedDefaultValueAttribute("True", false)] bool Apply_In)
        {
            n1.CompilationHelper.WritePin(this.__p_VRbjdQ7QisiO0MqhSMbgkA.Inputs[10], ref Apply_In);
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = this.__p_VRbjdQ7QisiO0MqhSMbgkA;
            return this;
        }

        public n41.Crop_C SetPointSampler(n7.SamplerState Point_Sampler_In)
        {
            n1.CompilationHelper.WritePin(this.__p_VRbjdQ7QisiO0MqhSMbgkA.Inputs[1], ref Point_Sampler_In);
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = this.__p_VRbjdQ7QisiO0MqhSMbgkA;
            return this;
        }

        public n41.Crop_C SetLinearSampler(n7.SamplerState Linear_Sampler_In)
        {
            n1.CompilationHelper.WritePin(this.__p_VRbjdQ7QisiO0MqhSMbgkA.Inputs[2], ref Linear_Sampler_In);
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = this.__p_VRbjdQ7QisiO0MqhSMbgkA;
            return this;
        }

        public n41.Crop_C __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "Crop (Internal)", "Stride.Textures.Utils");
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = node_0;
            return this;
        }

        public n41.Crop_C __CreateDefault__()
        {
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = default(n1.IVLNode);
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_VRbjdQ7QisiO0MqhSMbgkA);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 45410U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "VRbjdQ7QisiO0MqhSMbgkA", Name = "Crop", IsManaged = true, IsAutoGenerated = true, NodeName = "Crop (Internal)", NodeCategory = "Stride.Textures.Utils")]
        public n1.IVLNode __p_VRbjdQ7QisiO0MqhSMbgkA;
        public Crop_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Crop_C(Crop_C other): base(other)
        {
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = other.__p_VRbjdQ7QisiO0MqhSMbgkA;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VRbjdQ7QisiO0MqhSMbgkA", in __p_VRbjdQ7QisiO0MqhSMbgkA));
        }

        internal Crop_C __WITH__(n1.IVLNode __p_VRbjdQ7QisiO0MqhSMbgkA)
        {
            n41.Crop_C that_0 = this;
            this.__p_VRbjdQ7QisiO0MqhSMbgkA = __p_VRbjdQ7QisiO0MqhSMbgkA;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 48439U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "RrwOcCmgdsKOgmTkIHE6fV", Name = "ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV")]
    [n2.SerializableAttribute]
    public class ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n41.ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV Create(n1.NodeContext Node_Context)
        {
            var instance = new ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n41.ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV CreateDefault()
        {
            var instance = new ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n41.ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV Update(n7.Texture Input_In, [n4.SerializedDefaultValueAttribute("R16G16B16A16_Float", false)] n9.PixelFormat Target_Format_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Always_Generate_Mipmaps_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Use_Direct_Copy_If_Possible_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n7.Texture Output__Out, out bool Direct_Copy_Out)
        {
            n25.ObjectHelpers.IsAssigned(x: Input_In, result: out bool Result_0, notAssigned: out bool Not_Assigned_1);
            var Output_2 = Enabled_In && Result_0;
            var Output_3 = Result_0 && Use_Direct_Copy_If_Possible_In;
            bool __auto_4;
            if (Output_3)
            {
                var Is_Depth_Stencil_Read_Only_6 = Input_In.IsDepthStencilReadOnly;
                var Is_Depth_Stencil_7 = Input_In.IsDepthStencil;
                var Output_8 = Is_Depth_Stencil_7 || Is_Depth_Stencil_Read_Only_6;
                var Output_9 = !Output_8;
                bool __auto_10;
                if (Output_9)
                {
                    var Format_12 = Input_In.Format;
                    var Result_13 = n9.PixelFormatExtensions.BlockSize(format: Format_12);
                    var Result_14 = n9.PixelFormatExtensions.BlockSize(format: Target_Format_In);
                    var Result_15 = Result_13 == Result_14;
                    __auto_10 = Result_15;
                }
                else
                {
                    __auto_10 = false;
                }

                __auto_4 = __auto_10;
            }
            else
            {
                __auto_4 = false;
            }

            n45._Operations_.ANDNOT(Input_In: Output_2, Input_2_In: __auto_4, Output_Out: out bool Output_16);
            var Output_17 = Output_2 && __auto_4;
            n7.Texture __auto_18;
            var state_19 = n1.CompilationHelper.Restore<__Eb8ysPunDB7LrMp9DYGQ3T>(this.__if_OBwi9EHNfQkNMUB5i4v9I0, __GetContext__());
            if (Output_17)
            {
                if (state_19 == null)
                {
                    state_19 = new __Eb8ysPunDB7LrMp9DYGQ3T(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_20 = __GetContext__().CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "RgnogG6muL9LkzRZdrBUK3", 48588U);
                    var Output_21 = n46.CopyTexture_UGdw4Tvemx5QK60AS7AHcT.Create(Node_Context: Node_Context_20);
                    state_19.__p_RgnogG6muL9LkzRZdrBUK3 = Output_21;
                }

                n7.TextureFlags __pad_UATntHwj44TNOwbUQKB2Fb_22 = __slot_UATntHwj44TNOwbUQKB2Fb;
                bool Copy_Content_On_Clone_23 = false;
                bool Dispose_Cached_Texture_24 = true;
                bool To_Shared_Texture_25 = false;
                bool Auto_Render_26 = true;
                var State_Output_29 = state_19.__p_RgnogG6muL9LkzRZdrBUK3.Update(Input_In: Input_In, Copy_Content_On_Clone_In: Copy_Content_On_Clone_23, Format_In: Target_Format_In, Flags_In: __pad_UATntHwj44TNOwbUQKB2Fb_22, Dispose_Cached_Texture_In: Dispose_Cached_Texture_24, To_Shared_Texture_In: To_Shared_Texture_25, Auto_Render_In: Auto_Render_26, Renderer_Out: out n47.CopyTextureRenderer_C Renderer_27, Output_Out: out n7.Texture Output_28);
                __auto_18 = Output_28;
                if (state_19.__GetContext__().IsImmutable)
                    state_19 = State_Output_29 != state_19.__p_RgnogG6muL9LkzRZdrBUK3 ? new __Eb8ysPunDB7LrMp9DYGQ3T(state_19)
                    {__p_RgnogG6muL9LkzRZdrBUK3 = State_Output_29} : state_19;
                else
                {
                    state_19.__p_RgnogG6muL9LkzRZdrBUK3 = State_Output_29;
                }
            }
            else
            {
                __auto_18 = Input_In;
            }

            n7.Texture __auto_30;
            var state_31 = n1.CompilationHelper.Restore<__Q3E9Pnrcx7MNXhRPCTxZdn>(this.__if_LQvko7iOEMALk7Yi1jtmCX, __GetContext__());
            if (Output_16)
            {
                if (state_31 == null)
                {
                    state_31 = new __Q3E9Pnrcx7MNXhRPCTxZdn(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_32 = __GetContext__().CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "IlWBjOgJQ9KOxFxa61Qeft", 48695U);
                    bool Changed_On_Create_33 = true;
                    var Output_34 = n32.Changed_A8JGbead2bxNdnPybiEqVS<n7.Texture>.Create<n13.__AdaptiveImplementations__BzGvoB2aLhzP7WO4jVw5sI>(Node_Context: Node_Context_32, Changed_On_Create_In: Changed_On_Create_33);
                    state_31.__p_IlWBjOgJQ9KOxFxa61Qeft = Output_34;
                    var node_35 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "PassThrough", "Stride.Textures.Utils.Advanced");
                    state_31.__p_T2Z7X5LFXRqPMJFZReTGVK = node_35;
                }

                var Mip_Levels_36 = __auto_18.MipLevels;
                var Output_39 = state_31.__p_IlWBjOgJQ9KOxFxa61Qeft.Update(Value_In: __auto_18, Result_Out: out bool Result_37, Unchanged_Out: out bool Unchanged_38);
                var Output_40 = Always_Generate_Mipmaps_In || Result_37;
                int Input_2_41 = 1;
                var Result_42 = Mip_Levels_36 > Input_2_41;
                var Output_43 = Output_40 && Result_42;
                n1.CompilationHelper.WritePin(state_31.__p_T2Z7X5LFXRqPMJFZReTGVK.Inputs[0], ref __auto_18);
                n1.CompilationHelper.WritePin(state_31.__p_T2Z7X5LFXRqPMJFZReTGVK.Inputs[3], ref Target_Format_In);
                n1.CompilationHelper.ReadPin(state_31.__p_T2Z7X5LFXRqPMJFZReTGVK.Outputs[0], out n7.Texture out_44);
                n7.Texture __auto_45;
                var state_46 = n1.CompilationHelper.Restore<__Mo09qk5gBVXLZNrDSBvqOj>(state_31.__if_UFah7MSb4q5OZ3BSlZS9oL, __GetContext__());
                if (Output_43)
                {
                    if (state_46 == null)
                    {
                        state_46 = new __Mo09qk5gBVXLZNrDSBvqOj(__GetContext__(), n1.VLObject.NewIdentity());
                        var node_47 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "MipMap", "Stride.Textures.Experimental.Utils");
                        state_46.__p_LZzYcp4060POsVEslf5NUc = node_47;
                    }

                    n1.CompilationHelper.WritePin(state_46.__p_LZzYcp4060POsVEslf5NUc.Inputs[0], ref out_44);
                    n1.CompilationHelper.WritePin(state_46.__p_LZzYcp4060POsVEslf5NUc.Inputs[1], ref Mip_Levels_36);
                    n1.CompilationHelper.ReadPin(state_46.__p_LZzYcp4060POsVEslf5NUc.Outputs[0], out n7.Texture out_48);
                    __auto_45 = out_48;
                    if (state_46.__GetContext__().IsImmutable)
                        state_46 = state_46.__p_LZzYcp4060POsVEslf5NUc != state_46.__p_LZzYcp4060POsVEslf5NUc ? new __Mo09qk5gBVXLZNrDSBvqOj(state_46)
                        {__p_LZzYcp4060POsVEslf5NUc = state_46.__p_LZzYcp4060POsVEslf5NUc} : state_46;
                    else
                    {
                        state_46.__p_LZzYcp4060POsVEslf5NUc = state_46.__p_LZzYcp4060POsVEslf5NUc;
                    }
                }
                else
                {
                    __auto_45 = out_44;
                }

                __auto_30 = __auto_45;
                if (state_31.__GetContext__().IsImmutable)
                    state_31 = Output_39 != state_31.__p_IlWBjOgJQ9KOxFxa61Qeft || state_31.__p_T2Z7X5LFXRqPMJFZReTGVK != state_31.__p_T2Z7X5LFXRqPMJFZReTGVK || state_46 != state_31.__if_UFah7MSb4q5OZ3BSlZS9oL ? new __Q3E9Pnrcx7MNXhRPCTxZdn(state_31)
                    {__p_IlWBjOgJQ9KOxFxa61Qeft = Output_39, __p_T2Z7X5LFXRqPMJFZReTGVK = state_31.__p_T2Z7X5LFXRqPMJFZReTGVK, __if_UFah7MSb4q5OZ3BSlZS9oL = state_46} : state_31;
                else
                {
                    state_31.__p_IlWBjOgJQ9KOxFxa61Qeft = Output_39;
                    state_31.__p_T2Z7X5LFXRqPMJFZReTGVK = state_31.__p_T2Z7X5LFXRqPMJFZReTGVK;
                    state_31.__if_UFah7MSb4q5OZ3BSlZS9oL = state_46;
                }
            }
            else
            {
                __auto_30 = __auto_18;
            }

            Output__Out = __auto_30;
            Direct_Copy_Out = __auto_4;
            n41.ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV that_49 = this;
            if (this.__GetContext__().IsImmutable)
                that_49 = state_19 != this.__if_OBwi9EHNfQkNMUB5i4v9I0 || state_31 != this.__if_LQvko7iOEMALk7Yi1jtmCX ? new ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV(this)
                {__if_OBwi9EHNfQkNMUB5i4v9I0 = state_19, __if_LQvko7iOEMALk7Yi1jtmCX = state_31} : that_49;
            else
            {
                this.__if_OBwi9EHNfQkNMUB5i4v9I0 = state_19;
                this.__if_LQvko7iOEMALk7Yi1jtmCX = state_31;
            }

            return that_49;
        }

        public n41.ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n41.ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV that_0 = this;
            this.__if_OBwi9EHNfQkNMUB5i4v9I0 = default(n2.Object);
            this.__if_LQvko7iOEMALk7Yi1jtmCX = default(n2.Object);
            return that_0;
        }

        public n41.ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV __CreateDefault__()
        {
            n41.ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV that_0 = this;
            this.__if_OBwi9EHNfQkNMUB5i4v9I0 = default(n2.Object);
            this.__if_LQvko7iOEMALk7Yi1jtmCX = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_OBwi9EHNfQkNMUB5i4v9I0);
            n1.CompilationHelper.SafeDispose(this.__if_LQvko7iOEMALk7Yi1jtmCX);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 48622U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "EkY3lpuIZwJLSQeENLkgk2", Name = "__slot_EkY3lpuIZwJLSQeENLkgk2")]
        public static string __slot_EkY3lpuIZwJLSQeENLkgk2 = "Resource copy if pixel format matches";
        [n1.ElementAttribute(TracingId = 48786U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "HmdKSBaXKs3ObBayVTCUpW", Name = "__slot_HmdKSBaXKs3ObBayVTCUpW")]
        public static string __slot_HmdKSBaXKs3ObBayVTCUpW = "Render if pixel format doesn't match.";
        [n1.ElementAttribute(TracingId = 48601U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "UATntHwj44TNOwbUQKB2Fb", Name = "__slot_UATntHwj44TNOwbUQKB2Fb")]
        public static n7.TextureFlags __slot_UATntHwj44TNOwbUQKB2Fb = n1.CompilationHelper.Deserialize<n7.TextureFlags>("ShaderResource", false, "BzGvoB2aLhzP7WO4jVw5sI", "UATntHwj44TNOwbUQKB2Fb");
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_OBwi9EHNfQkNMUB5i4v9I0;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_LQvko7iOEMALk7Yi1jtmCX;
        static ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV()
        {
        }

        public ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV(ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV other): base(other)
        {
            this.__if_OBwi9EHNfQkNMUB5i4v9I0 = other.__if_OBwi9EHNfQkNMUB5i4v9I0;
            this.__if_LQvko7iOEMALk7Yi1jtmCX = other.__if_LQvko7iOEMALk7Yi1jtmCX;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_OBwi9EHNfQkNMUB5i4v9I0", in __if_OBwi9EHNfQkNMUB5i4v9I0), n1.CompilationHelper.GetValueOrExisting(values, "__if_LQvko7iOEMALk7Yi1jtmCX", in __if_LQvko7iOEMALk7Yi1jtmCX));
        }

        internal ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV __WITH__(n2.Object __if_OBwi9EHNfQkNMUB5i4v9I0, n2.Object __if_LQvko7iOEMALk7Yi1jtmCX)
        {
            n41.ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_OBwi9EHNfQkNMUB5i4v9I0 != this.__if_OBwi9EHNfQkNMUB5i4v9I0 || __if_LQvko7iOEMALk7Yi1jtmCX != this.__if_LQvko7iOEMALk7Yi1jtmCX ? new ChangeFormat_RrwOcCmgdsKOgmTkIHE6fV(this)
                {__if_OBwi9EHNfQkNMUB5i4v9I0 = __if_OBwi9EHNfQkNMUB5i4v9I0, __if_LQvko7iOEMALk7Yi1jtmCX = __if_LQvko7iOEMALk7Yi1jtmCX} : that_0;
            else
            {
                this.__if_OBwi9EHNfQkNMUB5i4v9I0 = __if_OBwi9EHNfQkNMUB5i4v9I0;
                this.__if_LQvko7iOEMALk7Yi1jtmCX = __if_LQvko7iOEMALk7Yi1jtmCX;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "Eb8ysPunDB7LrMp9DYGQ3T", Name = "__Eb8ysPunDB7LrMp9DYGQ3T")]
        [n2.SerializableAttribute]
        public class __Eb8ysPunDB7LrMp9DYGQ3T : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_RgnogG6muL9LkzRZdrBUK3);
                return;
            }

            [n1.ElementAttribute(TracingId = 48588U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "RgnogG6muL9LkzRZdrBUK3", Name = "CopyTexture", IsManaged = true, IsAutoGenerated = true)]
            public n46.CopyTexture_UGdw4Tvemx5QK60AS7AHcT __p_RgnogG6muL9LkzRZdrBUK3;
            public __Eb8ysPunDB7LrMp9DYGQ3T(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Eb8ysPunDB7LrMp9DYGQ3T(__Eb8ysPunDB7LrMp9DYGQ3T other): base(other)
            {
                this.__p_RgnogG6muL9LkzRZdrBUK3 = other.__p_RgnogG6muL9LkzRZdrBUK3;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_RgnogG6muL9LkzRZdrBUK3", in __p_RgnogG6muL9LkzRZdrBUK3));
            }

            internal __Eb8ysPunDB7LrMp9DYGQ3T __WITH__(n46.CopyTexture_UGdw4Tvemx5QK60AS7AHcT __p_RgnogG6muL9LkzRZdrBUK3)
            {
                __Eb8ysPunDB7LrMp9DYGQ3T that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_RgnogG6muL9LkzRZdrBUK3 != this.__p_RgnogG6muL9LkzRZdrBUK3 ? new __Eb8ysPunDB7LrMp9DYGQ3T(this)
                    {__p_RgnogG6muL9LkzRZdrBUK3 = __p_RgnogG6muL9LkzRZdrBUK3} : that_0;
                else
                {
                    this.__p_RgnogG6muL9LkzRZdrBUK3 = __p_RgnogG6muL9LkzRZdrBUK3;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "Q3E9Pnrcx7MNXhRPCTxZdn", Name = "__Q3E9Pnrcx7MNXhRPCTxZdn")]
        [n2.SerializableAttribute]
        public class __Q3E9Pnrcx7MNXhRPCTxZdn : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_IlWBjOgJQ9KOxFxa61Qeft);
                n1.CompilationHelper.SafeDispose(this.__p_T2Z7X5LFXRqPMJFZReTGVK);
                n1.CompilationHelper.SafeDispose(this.__if_UFah7MSb4q5OZ3BSlZS9oL);
                return;
            }

            [n1.ElementAttribute(TracingId = 48695U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "IlWBjOgJQ9KOxFxa61Qeft", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
            public n32.Changed_A8JGbead2bxNdnPybiEqVS<n7.Texture> __p_IlWBjOgJQ9KOxFxa61Qeft;
            [n1.ElementAttribute(TracingId = 48704U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "T2Z7X5LFXRqPMJFZReTGVK", Name = "PassThrough", IsManaged = true, IsAutoGenerated = true, NodeName = "PassThrough", NodeCategory = "Stride.Textures.Utils.Advanced")]
            public n1.IVLNode __p_T2Z7X5LFXRqPMJFZReTGVK;
            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_UFah7MSb4q5OZ3BSlZS9oL;
            public __Q3E9Pnrcx7MNXhRPCTxZdn(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Q3E9Pnrcx7MNXhRPCTxZdn(__Q3E9Pnrcx7MNXhRPCTxZdn other): base(other)
            {
                this.__p_IlWBjOgJQ9KOxFxa61Qeft = other.__p_IlWBjOgJQ9KOxFxa61Qeft;
                this.__p_T2Z7X5LFXRqPMJFZReTGVK = other.__p_T2Z7X5LFXRqPMJFZReTGVK;
                this.__if_UFah7MSb4q5OZ3BSlZS9oL = other.__if_UFah7MSb4q5OZ3BSlZS9oL;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IlWBjOgJQ9KOxFxa61Qeft", in __p_IlWBjOgJQ9KOxFxa61Qeft), n1.CompilationHelper.GetValueOrExisting(values, "__p_T2Z7X5LFXRqPMJFZReTGVK", in __p_T2Z7X5LFXRqPMJFZReTGVK), n1.CompilationHelper.GetValueOrExisting(values, "__if_UFah7MSb4q5OZ3BSlZS9oL", in __if_UFah7MSb4q5OZ3BSlZS9oL));
            }

            internal __Q3E9Pnrcx7MNXhRPCTxZdn __WITH__(n32.Changed_A8JGbead2bxNdnPybiEqVS<n7.Texture> __p_IlWBjOgJQ9KOxFxa61Qeft, n1.IVLNode __p_T2Z7X5LFXRqPMJFZReTGVK, n2.Object __if_UFah7MSb4q5OZ3BSlZS9oL)
            {
                __Q3E9Pnrcx7MNXhRPCTxZdn that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_IlWBjOgJQ9KOxFxa61Qeft != this.__p_IlWBjOgJQ9KOxFxa61Qeft || __p_T2Z7X5LFXRqPMJFZReTGVK != this.__p_T2Z7X5LFXRqPMJFZReTGVK || __if_UFah7MSb4q5OZ3BSlZS9oL != this.__if_UFah7MSb4q5OZ3BSlZS9oL ? new __Q3E9Pnrcx7MNXhRPCTxZdn(this)
                    {__p_IlWBjOgJQ9KOxFxa61Qeft = __p_IlWBjOgJQ9KOxFxa61Qeft, __p_T2Z7X5LFXRqPMJFZReTGVK = __p_T2Z7X5LFXRqPMJFZReTGVK, __if_UFah7MSb4q5OZ3BSlZS9oL = __if_UFah7MSb4q5OZ3BSlZS9oL} : that_0;
                else
                {
                    this.__p_IlWBjOgJQ9KOxFxa61Qeft = __p_IlWBjOgJQ9KOxFxa61Qeft;
                    this.__p_T2Z7X5LFXRqPMJFZReTGVK = __p_T2Z7X5LFXRqPMJFZReTGVK;
                    this.__if_UFah7MSb4q5OZ3BSlZS9oL = __if_UFah7MSb4q5OZ3BSlZS9oL;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "Mo09qk5gBVXLZNrDSBvqOj", Name = "__Mo09qk5gBVXLZNrDSBvqOj")]
        [n2.SerializableAttribute]
        public class __Mo09qk5gBVXLZNrDSBvqOj : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_LZzYcp4060POsVEslf5NUc);
                return;
            }

            [n1.ElementAttribute(TracingId = 48663U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "LZzYcp4060POsVEslf5NUc", Name = "MipMap", IsManaged = true, IsAutoGenerated = true, NodeName = "MipMap", NodeCategory = "Stride.Textures.Experimental.Utils")]
            public n1.IVLNode __p_LZzYcp4060POsVEslf5NUc;
            public __Mo09qk5gBVXLZNrDSBvqOj(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Mo09qk5gBVXLZNrDSBvqOj(__Mo09qk5gBVXLZNrDSBvqOj other): base(other)
            {
                this.__p_LZzYcp4060POsVEslf5NUc = other.__p_LZzYcp4060POsVEslf5NUc;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_LZzYcp4060POsVEslf5NUc", in __p_LZzYcp4060POsVEslf5NUc));
            }

            internal __Mo09qk5gBVXLZNrDSBvqOj __WITH__(n1.IVLNode __p_LZzYcp4060POsVEslf5NUc)
            {
                __Mo09qk5gBVXLZNrDSBvqOj that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_LZzYcp4060POsVEslf5NUc != this.__p_LZzYcp4060POsVEslf5NUc ? new __Mo09qk5gBVXLZNrDSBvqOj(this)
                    {__p_LZzYcp4060POsVEslf5NUc = __p_LZzYcp4060POsVEslf5NUc} : that_0;
                else
                {
                    this.__p_LZzYcp4060POsVEslf5NUc = __p_LZzYcp4060POsVEslf5NUc;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 53949U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "NPAHlPHnYkaLnenemMS3ba", Name = "Feedback_NPAHlPHnYkaLnenemMS3ba")]
    [n2.SerializableAttribute]
    public class Feedback_NPAHlPHnYkaLnenemMS3ba : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n41.Feedback_NPAHlPHnYkaLnenemMS3ba Create(n1.NodeContext Node_Context)
        {
            var instance = new Feedback_NPAHlPHnYkaLnenemMS3ba(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n41.Feedback_NPAHlPHnYkaLnenemMS3ba CreateDefault()
        {
            var instance = new Feedback_NPAHlPHnYkaLnenemMS3ba(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n41.Feedback_NPAHlPHnYkaLnenemMS3ba SetTexture(n7.Texture Feedback_In)
        {
            bool Copy_Content_On_Clone_0 = false;
            n9.PixelFormat Format_1 = default(n9.PixelFormat);
            n7.TextureFlags Flags_2 = default(n7.TextureFlags);
            bool Dispose_Cached_Texture_3 = true;
            bool To_Shared_Texture_4 = false;
            bool Auto_Render_5 = true;
            var State_Output_8 = this.__p_QMTv0jdjywBORPuVdN8JED.Update(Input_In: Feedback_In, Copy_Content_On_Clone_In: Copy_Content_On_Clone_0, Format_In: Format_1, Flags_In: Flags_2, Dispose_Cached_Texture_In: Dispose_Cached_Texture_3, To_Shared_Texture_In: To_Shared_Texture_4, Auto_Render_In: Auto_Render_5, Renderer_Out: out n47.CopyTextureRenderer_C Renderer_6, Output_Out: out n7.Texture Output_7);
            n7.Texture __auto_9 = Output_7;
            n41.Feedback_NPAHlPHnYkaLnenemMS3ba that_10 = this;
            if (this.__GetContext__().IsImmutable)
                that_10 = State_Output_8 != this.__p_QMTv0jdjywBORPuVdN8JED || Output_7 != this.Last_Frame ? new Feedback_NPAHlPHnYkaLnenemMS3ba(this)
                {__p_QMTv0jdjywBORPuVdN8JED = State_Output_8, Last_Frame = Output_7} : that_10;
            else
            {
                this.__p_QMTv0jdjywBORPuVdN8JED = State_Output_8;
                this.Last_Frame = Output_7;
            }

            return that_10;
        }

        public n41.Feedback_NPAHlPHnYkaLnenemMS3ba Update(n7.Texture Initial_Input_In, bool Initialize_In, out n7.Texture Output_Out)
        {
            n7.Texture __auto_0 = this.Last_Frame;
            n25.ObjectHelpers.IsAssigned(x: __auto_0, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            var Output_3 = Not_Assigned_2 || Initialize_In;
            n29._Operations_.Switch_Boolean<n7.Texture>(Condition_In: Output_3, Input_In: __auto_0, Input_2_In: Initial_Input_In, Output_Out: out n7.Texture Output_4);
            Output_Out = Output_4;
            return this;
        }

        public n41.Feedback_NPAHlPHnYkaLnenemMS3ba __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "QMTv0jdjywBORPuVdN8JED", 53992U);
            var Output_1 = n46.CopyTexture_UGdw4Tvemx5QK60AS7AHcT.Create(Node_Context: Node_Context_0);
            n41.Feedback_NPAHlPHnYkaLnenemMS3ba that_2 = this;
            this.Last_Frame = default(n7.Texture);
            this.__p_QMTv0jdjywBORPuVdN8JED = Output_1;
            return that_2;
        }

        public n41.Feedback_NPAHlPHnYkaLnenemMS3ba __CreateDefault__()
        {
            n41.Feedback_NPAHlPHnYkaLnenemMS3ba that_0 = this;
            this.Last_Frame = default(n7.Texture);
            this.__p_QMTv0jdjywBORPuVdN8JED = n46.CopyTexture_UGdw4Tvemx5QK60AS7AHcT.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_QMTv0jdjywBORPuVdN8JED);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 53962U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "VDJ5Y5C6hImK95e9xzoQ4X", Name = "Last Frame")]
        public n7.Texture Last_Frame;
        [n1.ElementAttribute(TracingId = 53992U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "QMTv0jdjywBORPuVdN8JED", Name = "CopyTexture", IsManaged = true, IsAutoGenerated = true)]
        public n46.CopyTexture_UGdw4Tvemx5QK60AS7AHcT __p_QMTv0jdjywBORPuVdN8JED;
        public Feedback_NPAHlPHnYkaLnenemMS3ba(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Feedback_NPAHlPHnYkaLnenemMS3ba(Feedback_NPAHlPHnYkaLnenemMS3ba other): base(other)
        {
            this.Last_Frame = other.Last_Frame;
            this.__p_QMTv0jdjywBORPuVdN8JED = other.__p_QMTv0jdjywBORPuVdN8JED;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Last_Frame", in Last_Frame), n1.CompilationHelper.GetValueOrExisting(values, "__p_QMTv0jdjywBORPuVdN8JED", in __p_QMTv0jdjywBORPuVdN8JED));
        }

        internal Feedback_NPAHlPHnYkaLnenemMS3ba __WITH__(n7.Texture Last_Frame, n46.CopyTexture_UGdw4Tvemx5QK60AS7AHcT __p_QMTv0jdjywBORPuVdN8JED)
        {
            n41.Feedback_NPAHlPHnYkaLnenemMS3ba that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Last_Frame != this.Last_Frame || __p_QMTv0jdjywBORPuVdN8JED != this.__p_QMTv0jdjywBORPuVdN8JED ? new Feedback_NPAHlPHnYkaLnenemMS3ba(this)
                {Last_Frame = Last_Frame, __p_QMTv0jdjywBORPuVdN8JED = __p_QMTv0jdjywBORPuVdN8JED} : that_0;
            else
            {
                this.Last_Frame = Last_Frame;
                this.__p_QMTv0jdjywBORPuVdN8JED = __p_QMTv0jdjywBORPuVdN8JED;
            }

            return that_0;
        }
    }
}

namespace _VL_Stride_Rendering_TextureFX_.Stride.Textures.Source
{
    [n1.ElementAttribute(TracingId = 54103U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "F770KqlwOMYPQifLlstupw", Name = "Electricity_C")]
    [n2.SerializableAttribute]
    public class Electricity_C : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n48.Electricity_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new Electricity_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n48.Electricity_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new Electricity_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n48.Electricity_C Update(out n7.Texture Output_Out)
        {
            n7.Texture __auto_0 = this.Volume_Noise;
            float __pad_NdBbw9jnzfpLiLpeAb4QBA_1 = this.__slot_NdBbw9jnzfpLiLpeAb4QBA;
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[1], ref __auto_0);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            bool Pause_2 = false;
            bool Update_3 = true;
            var Output_4 = this.__p_DXBmed7fB4UL92QX6IFFSA;
            if (Update_3)
            {
                Output_4 = this.__p_DXBmed7fB4UL92QX6IFFSA.Update(Period_In: __pad_NdBbw9jnzfpLiLpeAb4QBA_1, Pause_In: Pause_2);
            }

            this.__p_DXBmed7fB4UL92QX6IFFSA = Output_4;
            var Output_8 = Output_4.GetValues(Phase_Out: out float Phase_5, On_New_Cycle_Out: out bool On_New_Cycle_6, Cycles_Out: out int Cycles_7);
            this.__p_DXBmed7fB4UL92QX6IFFSA = Output_8;
            float Input_2_9 = n2.Convert.ToSingle(On_New_Cycle_6);
            var Output_10 = Phase_5 + Input_2_9;
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[2], ref Output_10);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            n1.CompilationHelper.ReadPin(this.__p_RJYITwkP2cbMZMehGuFsSV.Outputs[0], out n7.Texture out_11);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            Output_Out = out_11;
            return this;
        }

        public n48.Electricity_C SetSpeed([n4.SerializedDefaultValueAttribute("0.5", false)] float Speed_In)
        {
            n49._Operations_.ByHalf<float, n13.__AdaptiveImplementations__BzGvoB2aLhzP7WO4jVw5sI>(Input_In: Speed_In, Output_Out: out float Output_0);
            n49._Operations_.OneOver<float, n13.__AdaptiveImplementations__BzGvoB2aLhzP7WO4jVw5sI>(Input_In: Output_0, Output_Out: out float Output_1);
            this.__slot_NdBbw9jnzfpLiLpeAb4QBA = Output_1;
            float __pad_NdBbw9jnzfpLiLpeAb4QBA_2 = Output_1;
            return this;
        }

        public n48.Electricity_C SetBackgroundColor([n4.SerializedDefaultValueAttribute("0, 0, 0, 1", false)] n6.Color4 Background_Color_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[3], ref Background_Color_In);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            return this;
        }

        public n48.Electricity_C SetElectricityColor4([n4.SerializedDefaultValueAttribute("1, 1, 1, 1", false)] n6.Color4 Electricity_Color_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[4], ref Electricity_Color_In);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            return this;
        }

        public n48.Electricity_C SetHeight([n4.SerializedDefaultValueAttribute("0.25", false)] float Height_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[5], ref Height_In);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            return this;
        }

        public n48.Electricity_C SetGlowStrength([n4.SerializedDefaultValueAttribute("0.5", false)] float Glow_Strength_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[7], ref Glow_Strength_In);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            return this;
        }

        public n48.Electricity_C SetGlowFallOff([n4.SerializedDefaultValueAttribute("0.5", false)] float Glow_Fall_Off_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[8], ref Glow_Fall_Off_In);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            return this;
        }

        public n48.Electricity_C SetAmbientGlow([n4.SerializedDefaultValueAttribute("0.25", false)] float Ambient_Glow_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[9], ref Ambient_Glow_In);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            return this;
        }

        public n48.Electricity_C SetAmbientGlowHeightScale([n4.SerializedDefaultValueAttribute("0.5", false)] float Ambient_Glow_Height_Scale_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[10], ref Ambient_Glow_Height_Scale_In);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            return this;
        }

        public n48.Electricity_C SetVertexNoise([n4.SerializedDefaultValueAttribute("0.5", false)] float Vertex_Noise_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[6], ref Vertex_Noise_In);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            return this;
        }

        public n48.Electricity_C SetOutputSize([n4.SerializedDefaultValueAttribute("512, 512", false)] n6.Int2 Output_Size_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[11], ref Output_Size_In);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            return this;
        }

        public n48.Electricity_C SetOutputFormat([n4.SerializedDefaultValueAttribute("R16G16B16A16_Float", false)] n9.PixelFormat Output_Format_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[12], ref Output_Format_In);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            return this;
        }

        public n48.Electricity_C SetRenderFormat([n4.SerializedDefaultValueAttribute("None", false)] n9.PixelFormat Render_Format_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[13], ref Render_Format_In);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            return this;
        }

        public n48.Electricity_C SetOutputTexture(n7.Texture Output_Texture_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[14], ref Output_Texture_In);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            return this;
        }

        public n48.Electricity_C SetEnabled([n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In)
        {
            n1.CompilationHelper.WritePin(this.__p_RJYITwkP2cbMZMehGuFsSV.Inputs[15], ref Enabled_In);
            this.__p_RJYITwkP2cbMZMehGuFsSV = this.__p_RJYITwkP2cbMZMehGuFsSV;
            return this;
        }

        public n48.Electricity_C __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            this.__slot_BdRMv7o9yCOPH1UIvk0cJv = default(n50.ContentManager);
            this.__slot_NdBbw9jnzfpLiLpeAb4QBA = 0F;
            this.Volume_Noise = default(n7.Texture);
            string __pad_ESeqcZbJsFePAzmal4yaal_0 = __slot_ESeqcZbJsFePAzmal4yaal;
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "RlS31TrJ44JPbFfTFg98eC", 54315U);
            var Output_2 = n24.Game_NFOYCtbjpVWPQqunXUGp2r.Create(Node_Context_In: Node_Context_1);
            this.__p_RlS31TrJ44JPbFfTFg98eC = Output_2;
            var State_Output_4 = Output_2.Update(Output_Out: out n51.Game Output_3);
            this.__p_RlS31TrJ44JPbFfTFg98eC = State_Output_4;
            n52.IGame Input_5 = (n52.IGame)Output_3;
            var Content_6 = Input_5.Content;
            n50.ContentManagerLoaderSettings Settings_7 = default(n50.ContentManagerLoaderSettings);
            var Result_8 = Content_6.Load<n7.Texture>(url: __pad_ESeqcZbJsFePAzmal4yaal_0, settings: Settings_7);
            this.__slot_BdRMv7o9yCOPH1UIvk0cJv = Content_6;
            n50.ContentManager __pad_BdRMv7o9yCOPH1UIvk0cJv_9 = Content_6;
            this.Volume_Noise = Result_8;
            n7.Texture __auto_10 = Result_8;
            Electricity_C Instance_11 = this;
            var node_12 = n1.CompilationHelper.CreateNodeById(Node_Context, "Electricity (Internal)", "Stride.Textures.Source");
            this.__p_RJYITwkP2cbMZMehGuFsSV = node_12;
            n1.NodeContext Node_Context_13 = Node_Context.CreateSubContext("BzGvoB2aLhzP7WO4jVw5sI", "DXBmed7fB4UL92QX6IFFSA", 54255U);
            n54.IFrameClock Clock_14 = n53._Operations_.CreateDefault();
            var Output_15 = n55.LFO_F48sA9CC7kzM1Y1LIpWRrD.Create(Node_Context: Node_Context_13, Clock_In: Clock_14);
            this.__p_DXBmed7fB4UL92QX6IFFSA = Output_15;
            float Speed_16 = 0.5F;
            var Output_17 = Instance_11.SetSpeed(Speed_In: Speed_16);
            this.__p_SLKY88Ox3GiPbfZT0sfFtC = n56._Operations_.CreateDefault();
            return this;
        }

        public n48.Electricity_C Dispose_()
        {
            string __pad_ESeqcZbJsFePAzmal4yaal_0 = __slot_ESeqcZbJsFePAzmal4yaal;
            n50.ContentManager __pad_BdRMv7o9yCOPH1UIvk0cJv_1 = this.__slot_BdRMv7o9yCOPH1UIvk0cJv;
            __pad_BdRMv7o9yCOPH1UIvk0cJv_1.Unload(url: __pad_ESeqcZbJsFePAzmal4yaal_0);
            n1.CompilationHelper.SafeDispose(this.__p_RJYITwkP2cbMZMehGuFsSV);
            n1.CompilationHelper.SafeDispose(this.__p_DXBmed7fB4UL92QX6IFFSA);
            n1.CompilationHelper.SafeDispose(this.__p_RlS31TrJ44JPbFfTFg98eC);
            n1.CompilationHelper.SafeDispose(this.__p_SLKY88Ox3GiPbfZT0sfFtC);
            return this;
        }

        public n48.Electricity_C __CreateDefault__()
        {
            this.__slot_BdRMv7o9yCOPH1UIvk0cJv = default(n50.ContentManager);
            this.__slot_NdBbw9jnzfpLiLpeAb4QBA = 0F;
            this.Volume_Noise = default(n7.Texture);
            this.__p_RJYITwkP2cbMZMehGuFsSV = default(n1.IVLNode);
            this.__p_DXBmed7fB4UL92QX6IFFSA = n55.LFO_F48sA9CC7kzM1Y1LIpWRrD.CreateDefault();
            this.__p_RlS31TrJ44JPbFfTFg98eC = n24.Game_NFOYCtbjpVWPQqunXUGp2r.CreateDefault();
            this.__p_SLKY88Ox3GiPbfZT0sfFtC = n56._Operations_.CreateDefault();
            return this;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 55200U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "ESeqcZbJsFePAzmal4yaal", Name = "__slot_ESeqcZbJsFePAzmal4yaal")]
        public static string __slot_ESeqcZbJsFePAzmal4yaal = "Textures/noise_volume_128";
        [n1.ElementAttribute(TracingId = 55243U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "BdRMv7o9yCOPH1UIvk0cJv", Name = "__slot_BdRMv7o9yCOPH1UIvk0cJv")]
        public n50.ContentManager __slot_BdRMv7o9yCOPH1UIvk0cJv;
        [n1.ElementAttribute(TracingId = 55897U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "NdBbw9jnzfpLiLpeAb4QBA", Name = "__slot_NdBbw9jnzfpLiLpeAb4QBA")]
        public float __slot_NdBbw9jnzfpLiLpeAb4QBA;
        [n1.ElementAttribute(TracingId = 55211U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "RCOAu57bkB8MJAux0U2GBU", Name = "Volume Noise")]
        public n7.Texture Volume_Noise;
        [n1.ElementAttribute(TracingId = 54106U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "RJYITwkP2cbMZMehGuFsSV", Name = "Electricity", IsManaged = true, IsAutoGenerated = true, NodeName = "Electricity (Internal)", NodeCategory = "Stride.Textures.Source")]
        public n1.IVLNode __p_RJYITwkP2cbMZMehGuFsSV;
        [n1.ElementAttribute(TracingId = 54255U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "DXBmed7fB4UL92QX6IFFSA", Name = "LFO", IsManaged = true, IsAutoGenerated = true)]
        public n55.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_DXBmed7fB4UL92QX6IFFSA;
        [n1.ElementAttribute(TracingId = 54315U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "RlS31TrJ44JPbFfTFg98eC", Name = "Game", IsManaged = true, IsAutoGenerated = true)]
        public n24.Game_NFOYCtbjpVWPQqunXUGp2r __p_RlS31TrJ44JPbFfTFg98eC;
        [n1.ElementAttribute(TracingId = 55866U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "SLKY88Ox3GiPbfZT0sfFtC", Name = "This", IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __p_SLKY88Ox3GiPbfZT0sfFtC;
        static Electricity_C()
        {
        }

        public Electricity_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Electricity_C(Electricity_C other): base(other)
        {
            this.__slot_BdRMv7o9yCOPH1UIvk0cJv = other.__slot_BdRMv7o9yCOPH1UIvk0cJv;
            this.__slot_NdBbw9jnzfpLiLpeAb4QBA = other.__slot_NdBbw9jnzfpLiLpeAb4QBA;
            this.Volume_Noise = other.Volume_Noise;
            this.__p_RJYITwkP2cbMZMehGuFsSV = other.__p_RJYITwkP2cbMZMehGuFsSV;
            this.__p_DXBmed7fB4UL92QX6IFFSA = other.__p_DXBmed7fB4UL92QX6IFFSA;
            this.__p_RlS31TrJ44JPbFfTFg98eC = other.__p_RlS31TrJ44JPbFfTFg98eC;
            this.__p_SLKY88Ox3GiPbfZT0sfFtC = other.__p_SLKY88Ox3GiPbfZT0sfFtC;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_BdRMv7o9yCOPH1UIvk0cJv", in __slot_BdRMv7o9yCOPH1UIvk0cJv), n1.CompilationHelper.GetValueOrExisting(values, "__slot_NdBbw9jnzfpLiLpeAb4QBA", in __slot_NdBbw9jnzfpLiLpeAb4QBA), n1.CompilationHelper.GetValueOrExisting(values, "Volume_Noise", in Volume_Noise), n1.CompilationHelper.GetValueOrExisting(values, "__p_RJYITwkP2cbMZMehGuFsSV", in __p_RJYITwkP2cbMZMehGuFsSV), n1.CompilationHelper.GetValueOrExisting(values, "__p_DXBmed7fB4UL92QX6IFFSA", in __p_DXBmed7fB4UL92QX6IFFSA), n1.CompilationHelper.GetValueOrExisting(values, "__p_RlS31TrJ44JPbFfTFg98eC", in __p_RlS31TrJ44JPbFfTFg98eC), n1.CompilationHelper.GetValueOrExisting(values, "__p_SLKY88Ox3GiPbfZT0sfFtC", in __p_SLKY88Ox3GiPbfZT0sfFtC));
        }

        internal Electricity_C __WITH__(n50.ContentManager __slot_BdRMv7o9yCOPH1UIvk0cJv, float __slot_NdBbw9jnzfpLiLpeAb4QBA, n7.Texture Volume_Noise, n1.IVLNode __p_RJYITwkP2cbMZMehGuFsSV, n55.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_DXBmed7fB4UL92QX6IFFSA, n24.Game_NFOYCtbjpVWPQqunXUGp2r __p_RlS31TrJ44JPbFfTFg98eC, n2.Object __p_SLKY88Ox3GiPbfZT0sfFtC)
        {
            n48.Electricity_C that_0 = this;
            this.__slot_BdRMv7o9yCOPH1UIvk0cJv = __slot_BdRMv7o9yCOPH1UIvk0cJv;
            this.__slot_NdBbw9jnzfpLiLpeAb4QBA = __slot_NdBbw9jnzfpLiLpeAb4QBA;
            this.Volume_Noise = Volume_Noise;
            this.__p_RJYITwkP2cbMZMehGuFsSV = __p_RJYITwkP2cbMZMehGuFsSV;
            this.__p_DXBmed7fB4UL92QX6IFFSA = __p_DXBmed7fB4UL92QX6IFFSA;
            this.__p_RlS31TrJ44JPbFfTFg98eC = __p_RlS31TrJ44JPbFfTFg98eC;
            this.__p_SLKY88Ox3GiPbfZT0sfFtC = __p_SLKY88Ox3GiPbfZT0sfFtC;
            return that_0;
        }
    }
}

namespace _VL_Stride_Rendering_TextureFX_.Stride.Textures
{
    [n1.ElementAttribute(TracingId = 56204U, DocumentId = "BzGvoB2aLhzP7WO4jVw5sI", PersistentId = "U6vd7MA9h1ZQcPz63aoyUC", Name = "VL_Stride_Rendering_TextureFXApplication_U6vd7MA9h1ZQcPz63aoyUC")]
    [n2.SerializableAttribute]
    public class VL_Stride_Rendering_TextureFXApplication_U6vd7MA9h1ZQcPz63aoyUC : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n57.VL_Stride_Rendering_TextureFXApplication_U6vd7MA9h1ZQcPz63aoyUC Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_Stride_Rendering_TextureFXApplication_U6vd7MA9h1ZQcPz63aoyUC(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n57.VL_Stride_Rendering_TextureFXApplication_U6vd7MA9h1ZQcPz63aoyUC CreateDefault()
        {
            var instance = new VL_Stride_Rendering_TextureFXApplication_U6vd7MA9h1ZQcPz63aoyUC(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n57.VL_Stride_Rendering_TextureFXApplication_U6vd7MA9h1ZQcPz63aoyUC Update()
        {
            return this;
        }

        public n57.VL_Stride_Rendering_TextureFXApplication_U6vd7MA9h1ZQcPz63aoyUC __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n57.VL_Stride_Rendering_TextureFXApplication_U6vd7MA9h1ZQcPz63aoyUC __CreateDefault__()
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

        public VL_Stride_Rendering_TextureFXApplication_U6vd7MA9h1ZQcPz63aoyUC(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_Stride_Rendering_TextureFXApplication_U6vd7MA9h1ZQcPz63aoyUC(VL_Stride_Rendering_TextureFXApplication_U6vd7MA9h1ZQcPz63aoyUC other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_Stride_Rendering_TextureFXApplication_U6vd7MA9h1ZQcPz63aoyUC __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Stride_Rendering_TextureFX_
{
    public struct __AdaptiveImplementations__BzGvoB2aLhzP7WO4jVw5sI : n61.IAdaptiveMin<int>, n61.IAdaptiveOperatorLess<int>, n61.IAdaptiveMax<int>, n61.IAdaptiveOperatorGreater<int>, n62.IAdaptiveCreateDefault<n7.Texture>, n61.IAdaptiveOne<float>, n61.IAdaptiveOperatorDivide<float>, n61.IAdaptiveHalf<float>, n61.IAdaptiveOperatorMulitply_Scale<float>, n61.IAdaptiveOperatorMulitply<float>
    {
        public void Min(int Input_In, int Input_2_In, out int Output_Out)
        {
            n14._Operations_.Min<int, n13.__AdaptiveImplementations__BzGvoB2aLhzP7WO4jVw5sI>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorLess(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In < Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void Max(int Input_In, int Input_2_In, out int Output_Out)
        {
            n14._Operations_.Max<int, n13.__AdaptiveImplementations__BzGvoB2aLhzP7WO4jVw5sI>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorGreater(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In > Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void CreateDefault(out n7.Texture Output_Out)
        {
            n58._Operations_.CreateDefault_Generic<n7.Texture>(Output_Out: out n7.Texture Output_0);
            Output_Out = Output_0;
            return;
        }

        public void One(out float One_Out)
        {
            var One_0 = n59.Float32Extensions.One;
            One_Out = One_0;
            return;
        }

        public void OperatorDivide(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = (float)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void Half(out float Half_Out)
        {
            n60._Operations_.Half<float, n13.__AdaptiveImplementations__BzGvoB2aLhzP7WO4jVw5sI>(Half_Out: out float Half_0);
            Half_Out = Half_0;
            return;
        }

        public void OperatorMulitply_Scale(float Input_In, float Scalar_In, out float Output_Out)
        {
            var Output_0 = n59.Float32Extensions.Scale(input: Input_In, scalar: Scalar_In);
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply(float Input_In, float Input_2_In, out float Output_Out)
        {
            var Output_0 = Input_In * Input_2_In;
            Output_Out = Output_0;
            return;
        }
    }
}