extern alias e27;
extern alias e26;
extern alias e2;
extern alias e40;
extern alias e5;
extern alias e1;
extern alias e20;

using n24 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.Texture.Advanced;
using n43 = _VL_Stride_Graphics_.Stride.Utils.Advanced;
using n33 = e2::VL.Lib.Primitive;
using n37 = _CoreLibBasics_.Control;
using n32 = _VL_Stride_Rendering_Temp_;
using n21 = _VL_Stride_Rendering_ShaderFX_.Stride.Materials.Inputs;
using n39 = _CoreLibBasics_.Math.Generic.Advanced;
using n40 = e2::VL.Lib.Mathematics;
using n47 = _System_Memory_.System.Advanced.Adaptive;
using n23 = e40::VL.Stride.Graphics;
using n27 = _VL_Stride_Games_.Stride.Utils;
using n10 = e27::Stride.Graphics;
using n30 = _VL_Stride_Rendering_.Stride.Rendering.Utils;
using n12 = e2::VL.Lib.Primitive.Object;
using n5 = e5::VL.Core.CompilerServices;
using n16 = _VL_Stride_Rendering_Temp_.Stride.Textures.Utils.JoinChannels_Textures.Internal;
using n18 = global::System.Collections.Generic;
using n8 = e1::Stride.Core.Mathematics;
using n38 = _CoreLibBasics_.Math.Generic;
using n48 = _CoreLibBasics_.Math.Adaptive;
using n49 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n17 = _VL_Stride_Graphics_.Stride.Textures.Utils.Advanced;
using n31 = e40::VL.Stride.Rendering.ComputeEffect;
using n20 = e2::VL.Lib.Primitive.CacheRegion;
using n9 = _VL_Collections_.Collections.Spread.Advanced;
using n45 = _CoreLibBasics_.Math.Ranges.Generic.Advanced;
using n34 = e26::Stride.Rendering;
using n1 = e5::VL.Core;
using n19 = e20::Stride.Graphics;
using n42 = _VL_Stride_Rendering_ShaderFX_.Stride.Rendering.ShaderFX.Variables.Experimental;
using n4 = _VL_Stride_Rendering_Temp_.Stride.Textures.Utils;
using n7 = _VL_Stride_Rendering_Temp_.Stride.Textures;
using n3 = global::System;
using n6 = e40::VL.Stride.Shaders.ShaderFX;
using n44 = e2::VL.Lib;
using n41 = _CoreLibBasics_.Color.RGBA;
using n22 = _VL_Stride_Graphics_.Stride.Buffers;
using n28 = _VL_Stride_Graphics_.Stride.Textures;
using n25 = _VL_Stride_Rendering_Temp_.Stride.Textures.Utils.SplitChannels_Textures;
using n15 = _VL_Collections_.Collections.Mutable.MutableArray.Advanced;
using n29 = _VL_Stride_Rendering_Temp_.Stride;
using n36 = _VL_Stride_Rendering_.Stride.Buffers.Advanced;
using n14 = global::System.Runtime.CompilerServices;
using n26 = _VL_Stride_Graphics_.Stride.Textures.Utils;
using n11 = e5::VL.Lib.Collections;
using n35 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Core.Utils.Advanced;
using n13 = _VL_Collections_.Collections.Spread;
using n46 = _CoreLibBasics_._3D.Vector4;

namespace _VL_Stride_Rendering_Temp_.Stride.Textures
{
    [n1.ElementAttribute(TracingId = 198193U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "BwxvNT8Q2cPQatQmLGHL8I", Name = "Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I")]
    [n3.SerializableAttribute]
    public class Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I : n1.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I Create(n1.NodeContext Node_Context)
        {
            var instance = new Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I CreateDefault()
        {
            var instance = new Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I Update(n10.Texture Texture_In, n11.Spread<n8.Vector2> Positions_In, bool Convert_To_SRgb_In, n10.SamplerState Texture_Sampler_In, float Sample_Level_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Always_Update_In, [n5.SerializedDefaultValueAttribute("2", false)] int Frame_Delay_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out bool Dummy_Out)
        {
            bool __pad_P0K7v7ehwLkPSfyB9CWjWl_0 = __slot_P0K7v7ehwLkPSfyB9CWjWl;
            n9._Operations_.GetInternalArray<n8.Vector2>(Input_In: Positions_In, Result_Out: out n8.Vector2[] Result_1);
            var State_Output_3 = this.__p_Ik52WKMmuDCMKEqhNI7wcq.Update(Texture_In: Texture_In, Positions_In: Result_1, Convert_To_SRgb_In: Convert_To_SRgb_In, Texture_Sampler_In: Texture_Sampler_In, Sample_Level_In: Sample_Level_In, Always_Update_In: Always_Update_In, Frame_Delay_In: Frame_Delay_In, Enabled_In: Enabled_In, Output_Out: out n8.Color4[] Output_2);
            n8.Color4[] __auto_4 = Output_2;
            Dummy_Out = __pad_P0K7v7ehwLkPSfyB9CWjWl_0;
            n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I that_5 = this;
            if (this.__GetContext__().IsImmutable)
                that_5 = State_Output_3 != this.__p_Ik52WKMmuDCMKEqhNI7wcq || Output_2 != this.Array ? new Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I(this)
                {__p_Ik52WKMmuDCMKEqhNI7wcq = State_Output_3, Array = Output_2} : that_5;
            else
            {
                this.__p_Ik52WKMmuDCMKEqhNI7wcq = State_Output_3;
                this.Array = Output_2;
            }

            return that_5;
        }

        public n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I GetColorSpread(out n11.Spread<n8.Color4> Output_Out)
        {
            n8.Color4[] __auto_0 = this.Array;
            n12.ObjectHelpers.IsAssigned(x: __auto_0, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            n11.Spread<n8.Color4> __auto_3;
            var state_4 = n1.CompilationHelper.Restore<__Ma3ROM2pG4GQTUiWDMIssW>(this.__if_EKUQvx0362dPCygtRHLG7s, __GetContext__());
            if (Result_1)
            {
                if (state_4 == null)
                {
                    state_4 = new __Ma3ROM2pG4GQTUiWDMIssW(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_HBH0Yx42YuQNoPwDL23n2F = n13._Operations_.CreateDefault<n8.Color4>()};
                }

                var builder_10 = n5.CollectionBuilders.GetBuilder(state_4.__cp_HBH0Yx42YuQNoPwDL23n2F, 16);
                n11.Spread<n8.Color4> output_11;
                try
                {
                    var i_7 = 0;
                    foreach (var item_5 in __auto_0)
                    {
                        var splicer_6 = item_5;
                        var i_local_8 = i_7;
                        builder_10.Add(splicer_6);
                        i_7++;
                    }
                }
                finally
                {
                    output_11 = builder_10.Commit();
                }

                __auto_3 = output_11;
                if (state_4.__GetContext__().IsImmutable)
                    state_4 = output_11 != state_4.__cp_HBH0Yx42YuQNoPwDL23n2F ? new __Ma3ROM2pG4GQTUiWDMIssW(state_4)
                    {__cp_HBH0Yx42YuQNoPwDL23n2F = output_11} : state_4;
                else
                {
                    state_4.__cp_HBH0Yx42YuQNoPwDL23n2F = output_11;
                }
            }
            else
            {
                __auto_3 = n13._Operations_.CreateDefault<n8.Color4>();
            }

            Output_Out = __auto_3;
            n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = state_4 != this.__if_EKUQvx0362dPCygtRHLG7s ? new Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I(this)
                {__if_EKUQvx0362dPCygtRHLG7s = state_4} : that_12;
            else
            {
                this.__if_EKUQvx0362dPCygtRHLG7s = state_4;
            }

            return that_12;
        }

        public n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I GetColorArray(out n8.Color4[] Output_Array_Out)
        {
            n8.Color4[] __auto_0 = this.Array;
            Output_Array_Out = __auto_0;
            return this;
        }

        public n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I GetColorBuffer(out n10.Buffer Output_Buffer_Out)
        {
            var Output_1 = this.__p_Ik52WKMmuDCMKEqhNI7wcq.GetColorBuffer(Output_Buffer_Out: out n10.Buffer Output_Buffer_0);
            Output_Buffer_Out = Output_Buffer_0;
            n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_Ik52WKMmuDCMKEqhNI7wcq ? new Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I(this)
                {__p_Ik52WKMmuDCMKEqhNI7wcq = Output_1} : that_2;
            else
            {
                this.__p_Ik52WKMmuDCMKEqhNI7wcq = Output_1;
            }

            return that_2;
        }

        public n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I GetIsBlocking(out bool Is_Blocking_Out)
        {
            var Output_1 = this.__p_Ik52WKMmuDCMKEqhNI7wcq.GetIsBlocking(Is_Blocking_Out: out bool Is_Blocking_0);
            Is_Blocking_Out = Is_Blocking_0;
            n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_Ik52WKMmuDCMKEqhNI7wcq ? new Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I(this)
                {__p_Ik52WKMmuDCMKEqhNI7wcq = Output_1} : that_2;
            else
            {
                this.__p_Ik52WKMmuDCMKEqhNI7wcq = Output_1;
            }

            return that_2;
        }

        public n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "Ik52WKMmuDCMKEqhNI7wcq", 198288U);
            var Output_1 = n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ.Create(Node_Context: Node_Context_0);
            n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I that_2 = this;
            this.Array = n15._Operations_.CreateDefault<n8.Color4>();
            this.__p_Ik52WKMmuDCMKEqhNI7wcq = Output_1;
            this.__if_EKUQvx0362dPCygtRHLG7s = default(n3.Object);
            return that_2;
        }

        public n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I __CreateDefault__()
        {
            n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I that_0 = this;
            this.Array = n15._Operations_.CreateDefault<n8.Color4>();
            this.__p_Ik52WKMmuDCMKEqhNI7wcq = n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ.CreateDefault();
            this.__if_EKUQvx0362dPCygtRHLG7s = default(n3.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Ik52WKMmuDCMKEqhNI7wcq);
            n1.CompilationHelper.SafeDispose(this.__if_EKUQvx0362dPCygtRHLG7s);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 198221U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "QqaCrFq32FtPtv6NpJTDlF", Name = "__slot_QqaCrFq32FtPtv6NpJTDlF")]
        public static string __slot_QqaCrFq32FtPtv6NpJTDlF = "< a dummy hidden output to not have the \"Update\" input pin on this node";
        [n1.ElementAttribute(TracingId = 198225U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "P0K7v7ehwLkPSfyB9CWjWl", Name = "__slot_P0K7v7ehwLkPSfyB9CWjWl")]
        public static bool __slot_P0K7v7ehwLkPSfyB9CWjWl = false;
        [n1.ElementAttribute(TracingId = 198309U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "NPMiYcNXg2fOrTpEUw5wQ5", Name = "__slot_NPMiYcNXg2fOrTpEUw5wQ5")]
        public static string __slot_NPMiYcNXg2fOrTpEUw5wQ5 = "(AllocationFree)";
        [n1.ElementAttribute(TracingId = 198199U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "G0Q6ZGZFYIXNVU99JVTzM9", Name = "Array")]
        public n8.Color4[] Array;
        [n1.ElementAttribute(TracingId = 198288U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "Ik52WKMmuDCMKEqhNI7wcq", Name = "Pipet (AllocationFree Relative)", IsManaged = true, IsAutoGenerated = true)]
        public n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ __p_Ik52WKMmuDCMKEqhNI7wcq;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n3.Object __if_EKUQvx0362dPCygtRHLG7s;
        static Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I()
        {
        }

        public Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I(Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I other): base(other)
        {
            this.Array = other.Array;
            this.__p_Ik52WKMmuDCMKEqhNI7wcq = other.__p_Ik52WKMmuDCMKEqhNI7wcq;
            this.__if_EKUQvx0362dPCygtRHLG7s = other.__if_EKUQvx0362dPCygtRHLG7s;
        }

        protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Array", in Array), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ik52WKMmuDCMKEqhNI7wcq", in __p_Ik52WKMmuDCMKEqhNI7wcq), n1.CompilationHelper.GetValueOrExisting(values, "__if_EKUQvx0362dPCygtRHLG7s", in __if_EKUQvx0362dPCygtRHLG7s));
        }

        internal Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I __WITH__(n8.Color4[] Array, n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ __p_Ik52WKMmuDCMKEqhNI7wcq, n3.Object __if_EKUQvx0362dPCygtRHLG7s)
        {
            n7.Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Array != this.Array || __p_Ik52WKMmuDCMKEqhNI7wcq != this.__p_Ik52WKMmuDCMKEqhNI7wcq || __if_EKUQvx0362dPCygtRHLG7s != this.__if_EKUQvx0362dPCygtRHLG7s ? new Pipet_Relative_BwxvNT8Q2cPQatQmLGHL8I(this)
                {Array = Array, __p_Ik52WKMmuDCMKEqhNI7wcq = __p_Ik52WKMmuDCMKEqhNI7wcq, __if_EKUQvx0362dPCygtRHLG7s = __if_EKUQvx0362dPCygtRHLG7s} : that_0;
            else
            {
                this.Array = Array;
                this.__p_Ik52WKMmuDCMKEqhNI7wcq = __p_Ik52WKMmuDCMKEqhNI7wcq;
                this.__if_EKUQvx0362dPCygtRHLG7s = __if_EKUQvx0362dPCygtRHLG7s;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "Ma3ROM2pG4GQTUiWDMIssW", Name = "__Ma3ROM2pG4GQTUiWDMIssW")]
        [n3.SerializableAttribute]
        public class __Ma3ROM2pG4GQTUiWDMIssW : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n8.Color4> __cp_HBH0Yx42YuQNoPwDL23n2F;
            public __Ma3ROM2pG4GQTUiWDMIssW(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Ma3ROM2pG4GQTUiWDMIssW(__Ma3ROM2pG4GQTUiWDMIssW other): base(other)
            {
                this.__cp_HBH0Yx42YuQNoPwDL23n2F = other.__cp_HBH0Yx42YuQNoPwDL23n2F;
            }

            protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_HBH0Yx42YuQNoPwDL23n2F", in __cp_HBH0Yx42YuQNoPwDL23n2F));
            }

            internal __Ma3ROM2pG4GQTUiWDMIssW __WITH__(n11.Spread<n8.Color4> __cp_HBH0Yx42YuQNoPwDL23n2F)
            {
                __Ma3ROM2pG4GQTUiWDMIssW that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_HBH0Yx42YuQNoPwDL23n2F != this.__cp_HBH0Yx42YuQNoPwDL23n2F ? new __Ma3ROM2pG4GQTUiWDMIssW(this)
                    {__cp_HBH0Yx42YuQNoPwDL23n2F = __cp_HBH0Yx42YuQNoPwDL23n2F} : that_0;
                else
                {
                    this.__cp_HBH0Yx42YuQNoPwDL23n2F = __cp_HBH0Yx42YuQNoPwDL23n2F;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 198430U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "T4SXmmL9FNFLFT9GzCcXjJ", Name = "Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ")]
    [n3.SerializableAttribute]
    public class Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ : n1.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ Create(n1.NodeContext Node_Context)
        {
            var instance = new Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ CreateDefault()
        {
            var instance = new Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ Update(n10.Texture Texture_In, n8.Vector2[] Positions_In, bool Convert_To_SRgb_In, n10.SamplerState Texture_Sampler_In, float Sample_Level_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Always_Update_In, [n5.SerializedDefaultValueAttribute("2", false)] int Frame_Delay_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n8.Color4[] Output_Out)
        {
            n15._Operations_.Length<n8.Vector2>(Input_In: Positions_In, Output_Out: out n8.Vector2[] Output_0, Length_Out: out int Length_1);
            int Input_2_2 = 0;
            var Result_3 = Length_1 > Input_2_2;
            var Output_4 = Result_3 && Enabled_In;
            bool Force_5 = false;
            bool Dispose_Cached_Outputs_6 = false;
            var manager_7 = this.__cache_J2fF5EIKD40LkaBHY4MtoQ;
            if (manager_7 is null)
            {
                manager_7 = new n20.Manager<n3.ValueTuple<int>, n3.ValueTuple<n10.Buffer>>(n3.ValueTuple.Create(default(n10.Buffer)));
            }

            var inputs_8 = n3.ValueTuple.Create(Length_1);
            var outputs_9 = manager_7.Outputs;
            var Has_Changed_10 = Force_5 || manager_7.InputsChanged(inputs_8);
            if (Has_Changed_10)
            {
                if (Dispose_Cached_Outputs_6)
                    manager_7.DisposeOutputs();
                var state_11 = n1.CompilationHelper.Restore<__ErGJ55xPGtPM92q72kVHup>(manager_7.State, __GetContext__());
                if (state_11 == null)
                {
                    state_11 = new __ErGJ55xPGtPM92q72kVHup(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_12 = __GetContext__().CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "MaX7zcU5EEAPYzIFcHR9lP", 198668U);
                    var Output_13 = n22.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM.Create(Node_Context: Node_Context_12);
                    state_11.__p_MaX7zcU5EEAPYzIFcHR9lP = Output_13;
                }

                int Element_Size_In_Bytes_14 = 16;
                n23.IGraphicsDataProvider Initial_Data_15 = default(n23.IGraphicsDataProvider);
                bool Is_Unordered_Access_16 = true;
                n23.StructuredBufferType Structured_Buffer_Type_17 = n1.CompilationHelper.Deserialize<n23.StructuredBufferType>("StructuredBuffer", false, null, null);
                bool Is_Stream_Output_18 = false;
                bool Allow_Raw_Views_19 = false;
                bool Recreate_20 = false;
                var State_Output_23 = state_11.__p_MaX7zcU5EEAPYzIFcHR9lP.Update(Element_Count_In: Length_1, Element_Size_In_Bytes_In: Element_Size_In_Bytes_14, Initial_Data_In: Initial_Data_15, Is_Unordered_Access_In: Is_Unordered_Access_16, Structured_Buffer_Type_In: Structured_Buffer_Type_17, Is_Stream_Output_In: Is_Stream_Output_18, Allow_Raw_Views_In: Allow_Raw_Views_19, Recreate_In: Recreate_20, Output_Out: out n10.Buffer Output_21, Has_Changed_Out: out bool Has_Changed_22);
                if (state_11.__GetContext__().IsImmutable)
                    state_11 = State_Output_23 != state_11.__p_MaX7zcU5EEAPYzIFcHR9lP ? new __ErGJ55xPGtPM92q72kVHup(state_11)
                    {__p_MaX7zcU5EEAPYzIFcHR9lP = State_Output_23} : state_11;
                else
                {
                    state_11.__p_MaX7zcU5EEAPYzIFcHR9lP = State_Output_23;
                }

                outputs_9 = n3.ValueTuple.Create(Output_21);
                manager_7 = manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6, state_11, outputs_9);
            }
            else
            {
                manager_7.Update(inputs_8, __GetContext__().IsImmutable, Dispose_Cached_Outputs_6);
            }

            var __auto_24 = outputs_9.Item1;
            bool __auto_25;
            var state_26 = n1.CompilationHelper.Restore<__Po2iwCDk20LMje7h0pFt3z>(this.__if_NS4vj9k0gfLNt6FKrS3Wp4, __GetContext__());
            if (Output_4)
            {
                if (state_26 == null)
                {
                    state_26 = new __Po2iwCDk20LMje7h0pFt3z(__GetContext__(), n1.VLObject.NewIdentity());
                }

                bool Dispose_Cached_Outputs_27 = false;
                var manager_28 = state_26.__cache_J5d0UYj6nRuLOyTT2MXocP;
                if (manager_28 is null)
                {
                    manager_28 = new n20.Manager<n3.ValueTuple<int, n8.Vector2[], n10.Texture, n10.SamplerState, float, bool>, n3.ValueTuple>(n3.ValueTuple.Create());
                }

                var inputs_29 = (Length_1, Positions_In, Texture_In, Texture_Sampler_In, Sample_Level_In, Convert_To_SRgb_In);
                var outputs_30 = manager_28.Outputs;
                var Has_Changed_31 = Always_Update_In || manager_28.InputsChanged(inputs_29);
                if (Has_Changed_31)
                {
                    if (Dispose_Cached_Outputs_27)
                        manager_28.DisposeOutputs();
                    var state_32 = n1.CompilationHelper.Restore<__V5vsoH2YZRAN77vckAgEW0>(manager_28.State, __GetContext__());
                    if (state_32 == null)
                    {
                        state_32 = new __V5vsoH2YZRAN77vckAgEW0(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_33 = __GetContext__().CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "VpCJxIiANRaPkkbLqSYopC", 198484U);
                        var Output_34 = n27.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D.Create(Node_Context: Node_Context_33);
                        state_32.__p_VpCJxIiANRaPkkbLqSYopC = Output_34;
                        var node_35 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "SampleTextureShader", "Stride.Rendering.ComputeShaders");
                        state_32.__p_EHOtFVpdlpEL9OncWVfoFu = node_35;
                        n1.NodeContext Node_Context_36 = __GetContext__().CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "Gsd8GyuWpRaLBl9Aym938O", 198523U);
                        var Output_37 = n22.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n8.Vector2[]>.Create(Node_Context: Node_Context_36);
                        state_32.__p_Gsd8GyuWpRaLBl9Aym938O = Output_37;
                        var node_38 = n1.CompilationHelper.CreateNodeById(__GetContext__(), "DirectDispatcher", "Stride.Rendering.Advanced");
                        state_32.__p_VaP7xYIEab7No9OgkHuqWA = node_38;
                    }

                    int Thread_Group_Size_39 = 64;
                    n30._Operations_.CalcDispatchArgs1D(Count_In: Length_1, Thread_Group_Size_In: Thread_Group_Size_39, Thread_Group_Count_Out: out n8.Int3 Thread_Group_Count_40, Thread_Group_Size_Out: out n8.Int3 Thread_Group_Size_41);
                    n1.CompilationHelper.WritePin(state_32.__p_VaP7xYIEab7No9OgkHuqWA.Inputs[0], ref Thread_Group_Count_40);
                    n1.CompilationHelper.ReadPin(state_32.__p_VaP7xYIEab7No9OgkHuqWA.Outputs[0], out n31.IComputeEffectDispatcher out_42);
                    n1.CompilationHelper.WritePin(state_32.__p_EHOtFVpdlpEL9OncWVfoFu.Inputs[0], ref out_42);
                    n1.CompilationHelper.WritePin(state_32.__p_EHOtFVpdlpEL9OncWVfoFu.Inputs[1], ref Thread_Group_Size_41);
                    n1.CompilationHelper.WritePin(state_32.__p_EHOtFVpdlpEL9OncWVfoFu.Inputs[2], ref Texture_Sampler_In);
                    int Element_Size_In_Bytes_43 = 0;
                    int Offset_In_Bytes_44 = 0;
                    bool Is_Structured_Buffer_45 = false;
                    bool Is_Vertex_Buffer_46 = false;
                    bool Is_Index_Buffer_47 = false;
                    bool Allow_Raw_Views_48 = false;
                    bool Recreate_49 = false;
                    bool Apply_50 = true;
                    var State_Output_53 = state_32.__p_Gsd8GyuWpRaLBl9Aym938O.Update<n32.__AdaptiveImplementations__VCMcVJqu2AbNoidKDyIIxx>(Input_In: Positions_In, Element_Size_In_Bytes_In: Element_Size_In_Bytes_43, Offset_In_Bytes_In: Offset_In_Bytes_44, Is_Structured_Buffer_In: Is_Structured_Buffer_45, Is_Vertex_Buffer_In: Is_Vertex_Buffer_46, Is_Index_Buffer_In: Is_Index_Buffer_47, Allow_Raw_Views_In: Allow_Raw_Views_48, Recreate_In: Recreate_49, Apply_In: Apply_50, Output_Out: out n10.Buffer Output_51, Has_Changed_Out: out bool Has_Changed_52);
                    n1.CompilationHelper.WritePin(state_32.__p_EHOtFVpdlpEL9OncWVfoFu.Inputs[3], ref Output_51);
                    n1.CompilationHelper.WritePin(state_32.__p_EHOtFVpdlpEL9OncWVfoFu.Inputs[4], ref Texture_In);
                    n1.CompilationHelper.WritePin(state_32.__p_EHOtFVpdlpEL9OncWVfoFu.Inputs[5], ref __auto_24);
                    var Result_54 = n33.IntegerConversions.ToUInt32(input: Length_1);
                    n1.CompilationHelper.WritePin(state_32.__p_EHOtFVpdlpEL9OncWVfoFu.Inputs[6], ref Result_54);
                    n1.CompilationHelper.WritePin(state_32.__p_EHOtFVpdlpEL9OncWVfoFu.Inputs[7], ref Sample_Level_In);
                    n1.CompilationHelper.WritePin(state_32.__p_EHOtFVpdlpEL9OncWVfoFu.Inputs[8], ref Convert_To_SRgb_In);
                    n1.CompilationHelper.ReadPin(state_32.__p_EHOtFVpdlpEL9OncWVfoFu.Outputs[0], out n34.IGraphicsRendererBase out_55);
                    bool Schedule_56 = true;
                    var Output_57 = state_32.__p_VpCJxIiANRaPkkbLqSYopC;
                    if (Schedule_56)
                    {
                        Output_57 = state_32.__p_VpCJxIiANRaPkkbLqSYopC.Schedule(Renderer_In: out_55);
                    }

                    if (state_32.__GetContext__().IsImmutable)
                        state_32 = state_32.__p_VaP7xYIEab7No9OgkHuqWA != state_32.__p_VaP7xYIEab7No9OgkHuqWA || state_32.__p_EHOtFVpdlpEL9OncWVfoFu != state_32.__p_EHOtFVpdlpEL9OncWVfoFu || State_Output_53 != state_32.__p_Gsd8GyuWpRaLBl9Aym938O || Output_57 != state_32.__p_VpCJxIiANRaPkkbLqSYopC ? new __V5vsoH2YZRAN77vckAgEW0(state_32)
                        {__p_VaP7xYIEab7No9OgkHuqWA = state_32.__p_VaP7xYIEab7No9OgkHuqWA, __p_EHOtFVpdlpEL9OncWVfoFu = state_32.__p_EHOtFVpdlpEL9OncWVfoFu, __p_Gsd8GyuWpRaLBl9Aym938O = State_Output_53, __p_VpCJxIiANRaPkkbLqSYopC = Output_57} : state_32;
                    else
                    {
                        state_32.__p_VaP7xYIEab7No9OgkHuqWA = state_32.__p_VaP7xYIEab7No9OgkHuqWA;
                        state_32.__p_EHOtFVpdlpEL9OncWVfoFu = state_32.__p_EHOtFVpdlpEL9OncWVfoFu;
                        state_32.__p_Gsd8GyuWpRaLBl9Aym938O = State_Output_53;
                        state_32.__p_VpCJxIiANRaPkkbLqSYopC = Output_57;
                    }

                    outputs_30 = n3.ValueTuple.Create();
                    manager_28 = manager_28.Update(inputs_29, __GetContext__().IsImmutable, Dispose_Cached_Outputs_27, state_32, outputs_30);
                }
                else
                {
                    manager_28.Update(inputs_29, __GetContext__().IsImmutable, Dispose_Cached_Outputs_27);
                }

                __auto_25 = Has_Changed_31;
                if (state_26.__GetContext__().IsImmutable)
                    state_26 = manager_28 != state_26.__cache_J5d0UYj6nRuLOyTT2MXocP ? new __Po2iwCDk20LMje7h0pFt3z(state_26)
                    {__cache_J5d0UYj6nRuLOyTT2MXocP = manager_28} : state_26;
                else
                {
                    state_26.__cache_J5d0UYj6nRuLOyTT2MXocP = manager_28;
                }
            }
            else
            {
                __auto_25 = false;
            }

            n35._Operations_.EnsureOne<int, n32.__AdaptiveImplementations__VCMcVJqu2AbNoidKDyIIxx>(Input_In: Frame_Delay_In, Output_Out: out int Output_58);
            bool Retriggerable_59 = true;
            bool Reset_60 = false;
            var Output_63 = this.__p_Muc8ElSNNMVQB2ykcbFts8.Update(Set_In: __auto_25, Frames_In: Output_58, Retriggerable_In: Retriggerable_59, Reset_In: Reset_60, Value_Out: out bool Value_61, Inverse_Output_Out: out bool Inverse_Output_62);
            var State_Output_69 = this.__p_Hq8cjMTe1UUMbps9eRdf6w.Update(Input_In: __auto_24, Frame_Delay_In: Output_58, Auto_Draw_In: Value_61, Output_Out: out n8.Color4[] Output_64, Result_Available_Out: out bool Result_Available_65, Is_Blocking_Out: out bool Is_Blocking_66, Readback_Time_Out: out float Readback_Time_67, Renderer_Out: out n34.IGraphicsRendererBase Renderer_68);
            bool __pad_Ov0fc6oEZJVOodVgEvlO8T_70 = Is_Blocking_66;
            Output_Out = Output_64;
            n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ that_71 = this;
            if (this.__GetContext__().IsImmutable)
                that_71 = manager_7 != this.__cache_J2fF5EIKD40LkaBHY4MtoQ || state_26 != this.__if_NS4vj9k0gfLNt6FKrS3Wp4 || Output_63 != this.__p_Muc8ElSNNMVQB2ykcbFts8 || State_Output_69 != this.__p_Hq8cjMTe1UUMbps9eRdf6w || Is_Blocking_66 != this.__slot_Ov0fc6oEZJVOodVgEvlO8T ? new Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ(this)
                {__cache_J2fF5EIKD40LkaBHY4MtoQ = manager_7, __if_NS4vj9k0gfLNt6FKrS3Wp4 = state_26, __p_Muc8ElSNNMVQB2ykcbFts8 = Output_63, __p_Hq8cjMTe1UUMbps9eRdf6w = State_Output_69, __slot_Ov0fc6oEZJVOodVgEvlO8T = Is_Blocking_66} : that_71;
            else
            {
                this.__cache_J2fF5EIKD40LkaBHY4MtoQ = manager_7;
                this.__if_NS4vj9k0gfLNt6FKrS3Wp4 = state_26;
                this.__p_Muc8ElSNNMVQB2ykcbFts8 = Output_63;
                this.__p_Hq8cjMTe1UUMbps9eRdf6w = State_Output_69;
                this.__slot_Ov0fc6oEZJVOodVgEvlO8T = Is_Blocking_66;
            }

            return that_71;
        }

        public n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ GetColorBuffer(out n10.Buffer Output_Buffer_Out)
        {
            var manager_0 = this.__cache_J2fF5EIKD40LkaBHY4MtoQ;
            if (manager_0 is null)
            {
                manager_0 = new n20.Manager<n3.ValueTuple<int>, n3.ValueTuple<n10.Buffer>>(n3.ValueTuple.Create(default(n10.Buffer)));
            }

            var __auto_1 = manager_0.Outputs.Item1;
            Output_Buffer_Out = __auto_1;
            return this;
        }

        public n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ GetIsBlocking(out bool Is_Blocking_Out)
        {
            bool __pad_Ov0fc6oEZJVOodVgEvlO8T_0 = this.__slot_Ov0fc6oEZJVOodVgEvlO8T;
            Is_Blocking_Out = __pad_Ov0fc6oEZJVOodVgEvlO8T_0;
            return this;
        }

        public n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "Hq8cjMTe1UUMbps9eRdf6w", 198705U);
            var Output_1 = n36.ReadBackBuffer_LDYyNy9GNrCPqD5w3TYk8x<n8.Color4>.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "Muc8ElSNNMVQB2ykcbFts8", 198738U);
            var Output_3 = n37.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX.Create(Node_Context: Node_Context_2);
            n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ that_4 = this;
            this.__slot_Ov0fc6oEZJVOodVgEvlO8T = false;
            this.__p_Hq8cjMTe1UUMbps9eRdf6w = Output_1;
            this.__p_Muc8ElSNNMVQB2ykcbFts8 = Output_3;
            this.__cache_J2fF5EIKD40LkaBHY4MtoQ = null;
            this.__if_NS4vj9k0gfLNt6FKrS3Wp4 = default(n3.Object);
            return that_4;
        }

        public n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ __CreateDefault__()
        {
            n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ that_0 = this;
            this.__slot_Ov0fc6oEZJVOodVgEvlO8T = false;
            this.__cache_J2fF5EIKD40LkaBHY4MtoQ = null;
            this.__if_NS4vj9k0gfLNt6FKrS3Wp4 = default(n3.Object);
            this.__p_Muc8ElSNNMVQB2ykcbFts8 = n37.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX.CreateDefault();
            this.__p_Hq8cjMTe1UUMbps9eRdf6w = n36.ReadBackBuffer_LDYyNy9GNrCPqD5w3TYk8x<n8.Color4>.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_J2fF5EIKD40LkaBHY4MtoQ);
            n1.CompilationHelper.SafeDispose(this.__if_NS4vj9k0gfLNt6FKrS3Wp4);
            n1.CompilationHelper.SafeDispose(this.__p_Muc8ElSNNMVQB2ykcbFts8);
            n1.CompilationHelper.SafeDispose(this.__p_Hq8cjMTe1UUMbps9eRdf6w);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 198759U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "Ov0fc6oEZJVOodVgEvlO8T", Name = "__slot_Ov0fc6oEZJVOodVgEvlO8T")]
        public bool __slot_Ov0fc6oEZJVOodVgEvlO8T;
        [n1.ElementAttribute(TracingId = 198656U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "J2fF5EIKD40LkaBHY4MtoQ", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n20.Manager<n3.ValueTuple<int>, n3.ValueTuple<n10.Buffer>> __cache_J2fF5EIKD40LkaBHY4MtoQ = null;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n3.Object __if_NS4vj9k0gfLNt6FKrS3Wp4;
        [n1.ElementAttribute(TracingId = 198738U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "Muc8ElSNNMVQB2ykcbFts8", Name = "MonoFlop (FrameBased)", IsManaged = true, IsAutoGenerated = true)]
        public n37.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_Muc8ElSNNMVQB2ykcbFts8;
        [n1.ElementAttribute(TracingId = 198705U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "Hq8cjMTe1UUMbps9eRdf6w", Name = "ReadBackBuffer", IsManaged = true, IsAutoGenerated = true)]
        public n36.ReadBackBuffer_LDYyNy9GNrCPqD5w3TYk8x<n8.Color4> __p_Hq8cjMTe1UUMbps9eRdf6w;
        public Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ(Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ other): base(other)
        {
            this.__slot_Ov0fc6oEZJVOodVgEvlO8T = other.__slot_Ov0fc6oEZJVOodVgEvlO8T;
            this.__cache_J2fF5EIKD40LkaBHY4MtoQ = other.__cache_J2fF5EIKD40LkaBHY4MtoQ;
            this.__if_NS4vj9k0gfLNt6FKrS3Wp4 = other.__if_NS4vj9k0gfLNt6FKrS3Wp4;
            this.__p_Muc8ElSNNMVQB2ykcbFts8 = other.__p_Muc8ElSNNMVQB2ykcbFts8;
            this.__p_Hq8cjMTe1UUMbps9eRdf6w = other.__p_Hq8cjMTe1UUMbps9eRdf6w;
        }

        protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Ov0fc6oEZJVOodVgEvlO8T", in __slot_Ov0fc6oEZJVOodVgEvlO8T), n1.CompilationHelper.GetValueOrExisting(values, "__cache_J2fF5EIKD40LkaBHY4MtoQ", in __cache_J2fF5EIKD40LkaBHY4MtoQ), n1.CompilationHelper.GetValueOrExisting(values, "__if_NS4vj9k0gfLNt6FKrS3Wp4", in __if_NS4vj9k0gfLNt6FKrS3Wp4), n1.CompilationHelper.GetValueOrExisting(values, "__p_Muc8ElSNNMVQB2ykcbFts8", in __p_Muc8ElSNNMVQB2ykcbFts8), n1.CompilationHelper.GetValueOrExisting(values, "__p_Hq8cjMTe1UUMbps9eRdf6w", in __p_Hq8cjMTe1UUMbps9eRdf6w));
        }

        internal Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ __WITH__(bool __slot_Ov0fc6oEZJVOodVgEvlO8T, n20.Manager<n3.ValueTuple<int>, n3.ValueTuple<n10.Buffer>> __cache_J2fF5EIKD40LkaBHY4MtoQ, n3.Object __if_NS4vj9k0gfLNt6FKrS3Wp4, n37.MonoFlop_FrameBased_MOvFgvcWss4OfcgJRMKKqX __p_Muc8ElSNNMVQB2ykcbFts8, n36.ReadBackBuffer_LDYyNy9GNrCPqD5w3TYk8x<n8.Color4> __p_Hq8cjMTe1UUMbps9eRdf6w)
        {
            n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_Ov0fc6oEZJVOodVgEvlO8T != this.__slot_Ov0fc6oEZJVOodVgEvlO8T || __cache_J2fF5EIKD40LkaBHY4MtoQ != this.__cache_J2fF5EIKD40LkaBHY4MtoQ || __if_NS4vj9k0gfLNt6FKrS3Wp4 != this.__if_NS4vj9k0gfLNt6FKrS3Wp4 || __p_Muc8ElSNNMVQB2ykcbFts8 != this.__p_Muc8ElSNNMVQB2ykcbFts8 || __p_Hq8cjMTe1UUMbps9eRdf6w != this.__p_Hq8cjMTe1UUMbps9eRdf6w ? new Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ(this)
                {__slot_Ov0fc6oEZJVOodVgEvlO8T = __slot_Ov0fc6oEZJVOodVgEvlO8T, __cache_J2fF5EIKD40LkaBHY4MtoQ = __cache_J2fF5EIKD40LkaBHY4MtoQ, __if_NS4vj9k0gfLNt6FKrS3Wp4 = __if_NS4vj9k0gfLNt6FKrS3Wp4, __p_Muc8ElSNNMVQB2ykcbFts8 = __p_Muc8ElSNNMVQB2ykcbFts8, __p_Hq8cjMTe1UUMbps9eRdf6w = __p_Hq8cjMTe1UUMbps9eRdf6w} : that_0;
            else
            {
                this.__slot_Ov0fc6oEZJVOodVgEvlO8T = __slot_Ov0fc6oEZJVOodVgEvlO8T;
                this.__cache_J2fF5EIKD40LkaBHY4MtoQ = __cache_J2fF5EIKD40LkaBHY4MtoQ;
                this.__if_NS4vj9k0gfLNt6FKrS3Wp4 = __if_NS4vj9k0gfLNt6FKrS3Wp4;
                this.__p_Muc8ElSNNMVQB2ykcbFts8 = __p_Muc8ElSNNMVQB2ykcbFts8;
                this.__p_Hq8cjMTe1UUMbps9eRdf6w = __p_Hq8cjMTe1UUMbps9eRdf6w;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "ErGJ55xPGtPM92q72kVHup", Name = "__ErGJ55xPGtPM92q72kVHup")]
        [n3.SerializableAttribute]
        public class __ErGJ55xPGtPM92q72kVHup : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_MaX7zcU5EEAPYzIFcHR9lP);
                return;
            }

            [n1.ElementAttribute(TracingId = 198668U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "MaX7zcU5EEAPYzIFcHR9lP", Name = "ComputeBuffer", IsManaged = true, IsAutoGenerated = true)]
            public n22.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM __p_MaX7zcU5EEAPYzIFcHR9lP;
            public __ErGJ55xPGtPM92q72kVHup(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __ErGJ55xPGtPM92q72kVHup(__ErGJ55xPGtPM92q72kVHup other): base(other)
            {
                this.__p_MaX7zcU5EEAPYzIFcHR9lP = other.__p_MaX7zcU5EEAPYzIFcHR9lP;
            }

            protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_MaX7zcU5EEAPYzIFcHR9lP", in __p_MaX7zcU5EEAPYzIFcHR9lP));
            }

            internal __ErGJ55xPGtPM92q72kVHup __WITH__(n22.ComputeBuffer_DmEfvnY9LhgL0IgudEOxyM __p_MaX7zcU5EEAPYzIFcHR9lP)
            {
                __ErGJ55xPGtPM92q72kVHup that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_MaX7zcU5EEAPYzIFcHR9lP != this.__p_MaX7zcU5EEAPYzIFcHR9lP ? new __ErGJ55xPGtPM92q72kVHup(this)
                    {__p_MaX7zcU5EEAPYzIFcHR9lP = __p_MaX7zcU5EEAPYzIFcHR9lP} : that_0;
                else
                {
                    this.__p_MaX7zcU5EEAPYzIFcHR9lP = __p_MaX7zcU5EEAPYzIFcHR9lP;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "Po2iwCDk20LMje7h0pFt3z", Name = "__Po2iwCDk20LMje7h0pFt3z")]
        [n3.SerializableAttribute]
        public class __Po2iwCDk20LMje7h0pFt3z : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__cache_J5d0UYj6nRuLOyTT2MXocP);
                return;
            }

            [n1.ElementAttribute(TracingId = 198462U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "J5d0UYj6nRuLOyTT2MXocP", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n20.Manager<n3.ValueTuple<int, n8.Vector2[], n10.Texture, n10.SamplerState, float, bool>, n3.ValueTuple> __cache_J5d0UYj6nRuLOyTT2MXocP = null;
            public __Po2iwCDk20LMje7h0pFt3z(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __Po2iwCDk20LMje7h0pFt3z(__Po2iwCDk20LMje7h0pFt3z other): base(other)
            {
                this.__cache_J5d0UYj6nRuLOyTT2MXocP = other.__cache_J5d0UYj6nRuLOyTT2MXocP;
            }

            protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_J5d0UYj6nRuLOyTT2MXocP", in __cache_J5d0UYj6nRuLOyTT2MXocP));
            }

            internal __Po2iwCDk20LMje7h0pFt3z __WITH__(n20.Manager<n3.ValueTuple<int, n8.Vector2[], n10.Texture, n10.SamplerState, float, bool>, n3.ValueTuple> __cache_J5d0UYj6nRuLOyTT2MXocP)
            {
                __Po2iwCDk20LMje7h0pFt3z that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cache_J5d0UYj6nRuLOyTT2MXocP != this.__cache_J5d0UYj6nRuLOyTT2MXocP ? new __Po2iwCDk20LMje7h0pFt3z(this)
                    {__cache_J5d0UYj6nRuLOyTT2MXocP = __cache_J5d0UYj6nRuLOyTT2MXocP} : that_0;
                else
                {
                    this.__cache_J5d0UYj6nRuLOyTT2MXocP = __cache_J5d0UYj6nRuLOyTT2MXocP;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "V5vsoH2YZRAN77vckAgEW0", Name = "__V5vsoH2YZRAN77vckAgEW0")]
        [n3.SerializableAttribute]
        public class __V5vsoH2YZRAN77vckAgEW0 : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_VpCJxIiANRaPkkbLqSYopC);
                n1.CompilationHelper.SafeDispose(this.__p_EHOtFVpdlpEL9OncWVfoFu);
                n1.CompilationHelper.SafeDispose(this.__p_Gsd8GyuWpRaLBl9Aym938O);
                n1.CompilationHelper.SafeDispose(this.__p_VaP7xYIEab7No9OgkHuqWA);
                return;
            }

            [n1.ElementAttribute(TracingId = 198484U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "VpCJxIiANRaPkkbLqSYopC", Name = "RendererScheduler", IsManaged = true, IsAutoGenerated = true)]
            public n27.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D __p_VpCJxIiANRaPkkbLqSYopC;
            [n1.ElementAttribute(TracingId = 198492U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "EHOtFVpdlpEL9OncWVfoFu", Name = "SampleTextureShader", IsManaged = true, IsAutoGenerated = true, NodeName = "SampleTextureShader", NodeCategory = "Stride.Rendering.ComputeShaders")]
            public n1.IVLNode __p_EHOtFVpdlpEL9OncWVfoFu;
            [n1.ElementAttribute(TracingId = 198523U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "Gsd8GyuWpRaLBl9Aym938O", Name = "DynamicBuffer", IsManaged = true, IsAutoGenerated = true)]
            public n22.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n8.Vector2[]> __p_Gsd8GyuWpRaLBl9Aym938O;
            [n1.ElementAttribute(TracingId = 198570U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "VaP7xYIEab7No9OgkHuqWA", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
            public n1.IVLNode __p_VaP7xYIEab7No9OgkHuqWA;
            public __V5vsoH2YZRAN77vckAgEW0(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __V5vsoH2YZRAN77vckAgEW0(__V5vsoH2YZRAN77vckAgEW0 other): base(other)
            {
                this.__p_VpCJxIiANRaPkkbLqSYopC = other.__p_VpCJxIiANRaPkkbLqSYopC;
                this.__p_EHOtFVpdlpEL9OncWVfoFu = other.__p_EHOtFVpdlpEL9OncWVfoFu;
                this.__p_Gsd8GyuWpRaLBl9Aym938O = other.__p_Gsd8GyuWpRaLBl9Aym938O;
                this.__p_VaP7xYIEab7No9OgkHuqWA = other.__p_VaP7xYIEab7No9OgkHuqWA;
            }

            protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_VpCJxIiANRaPkkbLqSYopC", in __p_VpCJxIiANRaPkkbLqSYopC), n1.CompilationHelper.GetValueOrExisting(values, "__p_EHOtFVpdlpEL9OncWVfoFu", in __p_EHOtFVpdlpEL9OncWVfoFu), n1.CompilationHelper.GetValueOrExisting(values, "__p_Gsd8GyuWpRaLBl9Aym938O", in __p_Gsd8GyuWpRaLBl9Aym938O), n1.CompilationHelper.GetValueOrExisting(values, "__p_VaP7xYIEab7No9OgkHuqWA", in __p_VaP7xYIEab7No9OgkHuqWA));
            }

            internal __V5vsoH2YZRAN77vckAgEW0 __WITH__(n27.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D __p_VpCJxIiANRaPkkbLqSYopC, n1.IVLNode __p_EHOtFVpdlpEL9OncWVfoFu, n22.DynamicBuffer_C82b44KM7nmOgoP82JqMWO<n8.Vector2[]> __p_Gsd8GyuWpRaLBl9Aym938O, n1.IVLNode __p_VaP7xYIEab7No9OgkHuqWA)
            {
                __V5vsoH2YZRAN77vckAgEW0 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_VpCJxIiANRaPkkbLqSYopC != this.__p_VpCJxIiANRaPkkbLqSYopC || __p_EHOtFVpdlpEL9OncWVfoFu != this.__p_EHOtFVpdlpEL9OncWVfoFu || __p_Gsd8GyuWpRaLBl9Aym938O != this.__p_Gsd8GyuWpRaLBl9Aym938O || __p_VaP7xYIEab7No9OgkHuqWA != this.__p_VaP7xYIEab7No9OgkHuqWA ? new __V5vsoH2YZRAN77vckAgEW0(this)
                    {__p_VpCJxIiANRaPkkbLqSYopC = __p_VpCJxIiANRaPkkbLqSYopC, __p_EHOtFVpdlpEL9OncWVfoFu = __p_EHOtFVpdlpEL9OncWVfoFu, __p_Gsd8GyuWpRaLBl9Aym938O = __p_Gsd8GyuWpRaLBl9Aym938O, __p_VaP7xYIEab7No9OgkHuqWA = __p_VaP7xYIEab7No9OgkHuqWA} : that_0;
                else
                {
                    this.__p_VpCJxIiANRaPkkbLqSYopC = __p_VpCJxIiANRaPkkbLqSYopC;
                    this.__p_EHOtFVpdlpEL9OncWVfoFu = __p_EHOtFVpdlpEL9OncWVfoFu;
                    this.__p_Gsd8GyuWpRaLBl9Aym938O = __p_Gsd8GyuWpRaLBl9Aym938O;
                    this.__p_VaP7xYIEab7No9OgkHuqWA = __p_VaP7xYIEab7No9OgkHuqWA;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 198927U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "MqYqrVR1BTcORjCCg8elsd", Name = "Pipet_MqYqrVR1BTcORjCCg8elsd")]
    [n3.SerializableAttribute]
    public class Pipet_MqYqrVR1BTcORjCCg8elsd : n1.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n7.Pipet_MqYqrVR1BTcORjCCg8elsd Create(n1.NodeContext Node_Context)
        {
            var instance = new Pipet_MqYqrVR1BTcORjCCg8elsd(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n7.Pipet_MqYqrVR1BTcORjCCg8elsd CreateDefault()
        {
            var instance = new Pipet_MqYqrVR1BTcORjCCg8elsd(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.Pipet_MqYqrVR1BTcORjCCg8elsd Update(n10.Texture Texture_In, n11.Spread<n8.Int2> Positions_In, bool Convert_To_SRgb_In, n10.SamplerState Texture_Sampler_In, float Sample_Level_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Always_Update_In, [n5.SerializedDefaultValueAttribute("2", false)] int Frame_Delay_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out bool Dummy_Out)
        {
            bool __pad_IjqVCQdzinPMTsK9fqRpyN_0 = __slot_IjqVCQdzinPMTsK9fqRpyN;
            n9._Operations_.GetInternalArray<n8.Int2>(Input_In: Positions_In, Result_Out: out n8.Int2[] Result_1);
            var State_Output_3 = this.__p_DzqyAX9F2jzLhhsXr6Nks6.Update(Texture_In: Texture_In, Positions_In: Result_1, Convert_To_SRgb_In: Convert_To_SRgb_In, Texture_Sampler_In: Texture_Sampler_In, Sample_Level_In: Sample_Level_In, Always_Update_In: Always_Update_In, Frame_Delay_In: Frame_Delay_In, Enabled_In: Enabled_In, Output_Out: out n8.Color4[] Output_2);
            n8.Color4[] __auto_4 = Output_2;
            Dummy_Out = __pad_IjqVCQdzinPMTsK9fqRpyN_0;
            n7.Pipet_MqYqrVR1BTcORjCCg8elsd that_5 = this;
            if (this.__GetContext__().IsImmutable)
                that_5 = State_Output_3 != this.__p_DzqyAX9F2jzLhhsXr6Nks6 || Output_2 != this.Array ? new Pipet_MqYqrVR1BTcORjCCg8elsd(this)
                {__p_DzqyAX9F2jzLhhsXr6Nks6 = State_Output_3, Array = Output_2} : that_5;
            else
            {
                this.__p_DzqyAX9F2jzLhhsXr6Nks6 = State_Output_3;
                this.Array = Output_2;
            }

            return that_5;
        }

        public n7.Pipet_MqYqrVR1BTcORjCCg8elsd GetColorSpread(out n11.Spread<n8.Color4> Output_Out)
        {
            n8.Color4[] __auto_0 = this.Array;
            n12.ObjectHelpers.IsAssigned(x: __auto_0, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            n11.Spread<n8.Color4> __auto_3;
            var state_4 = n1.CompilationHelper.Restore<__ULNFAwy2DJbLMLLnoyhlEH>(this.__if_ECY6FYfmobaOPtmyWpWzOJ, __GetContext__());
            if (Result_1)
            {
                if (state_4 == null)
                {
                    state_4 = new __ULNFAwy2DJbLMLLnoyhlEH(__GetContext__(), n1.VLObject.NewIdentity())
                    {__cp_D5nIMqBGad8M0oo0h0gc0W = n13._Operations_.CreateDefault<n8.Color4>()};
                }

                var builder_10 = n5.CollectionBuilders.GetBuilder(state_4.__cp_D5nIMqBGad8M0oo0h0gc0W, 16);
                n11.Spread<n8.Color4> output_11;
                try
                {
                    var i_7 = 0;
                    foreach (var item_5 in __auto_0)
                    {
                        var splicer_6 = item_5;
                        var i_local_8 = i_7;
                        builder_10.Add(splicer_6);
                        i_7++;
                    }
                }
                finally
                {
                    output_11 = builder_10.Commit();
                }

                __auto_3 = output_11;
                if (state_4.__GetContext__().IsImmutable)
                    state_4 = output_11 != state_4.__cp_D5nIMqBGad8M0oo0h0gc0W ? new __ULNFAwy2DJbLMLLnoyhlEH(state_4)
                    {__cp_D5nIMqBGad8M0oo0h0gc0W = output_11} : state_4;
                else
                {
                    state_4.__cp_D5nIMqBGad8M0oo0h0gc0W = output_11;
                }
            }
            else
            {
                __auto_3 = n13._Operations_.CreateDefault<n8.Color4>();
            }

            Output_Out = __auto_3;
            n7.Pipet_MqYqrVR1BTcORjCCg8elsd that_12 = this;
            if (this.__GetContext__().IsImmutable)
                that_12 = state_4 != this.__if_ECY6FYfmobaOPtmyWpWzOJ ? new Pipet_MqYqrVR1BTcORjCCg8elsd(this)
                {__if_ECY6FYfmobaOPtmyWpWzOJ = state_4} : that_12;
            else
            {
                this.__if_ECY6FYfmobaOPtmyWpWzOJ = state_4;
            }

            return that_12;
        }

        public n7.Pipet_MqYqrVR1BTcORjCCg8elsd GetColorArray(out n8.Color4[] Output_Array_Out)
        {
            n8.Color4[] __auto_0 = this.Array;
            Output_Array_Out = __auto_0;
            return this;
        }

        public n7.Pipet_MqYqrVR1BTcORjCCg8elsd GetColorBuffer(out n10.Buffer Output_Texture_Out)
        {
            var Output_1 = this.__p_DzqyAX9F2jzLhhsXr6Nks6.GetColorBuffer(Output_Buffer_Out: out n10.Buffer Output_Buffer_0);
            Output_Texture_Out = Output_Buffer_0;
            n7.Pipet_MqYqrVR1BTcORjCCg8elsd that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_DzqyAX9F2jzLhhsXr6Nks6 ? new Pipet_MqYqrVR1BTcORjCCg8elsd(this)
                {__p_DzqyAX9F2jzLhhsXr6Nks6 = Output_1} : that_2;
            else
            {
                this.__p_DzqyAX9F2jzLhhsXr6Nks6 = Output_1;
            }

            return that_2;
        }

        public n7.Pipet_MqYqrVR1BTcORjCCg8elsd GetIsBlocking(out bool Is_Blocking_Out)
        {
            var Output_1 = this.__p_DzqyAX9F2jzLhhsXr6Nks6.GetIsBlocking(Is_Blocking_Out: out bool Is_Blocking_0);
            Is_Blocking_Out = Is_Blocking_0;
            n7.Pipet_MqYqrVR1BTcORjCCg8elsd that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_DzqyAX9F2jzLhhsXr6Nks6 ? new Pipet_MqYqrVR1BTcORjCCg8elsd(this)
                {__p_DzqyAX9F2jzLhhsXr6Nks6 = Output_1} : that_2;
            else
            {
                this.__p_DzqyAX9F2jzLhhsXr6Nks6 = Output_1;
            }

            return that_2;
        }

        public n7.Pipet_MqYqrVR1BTcORjCCg8elsd __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "DzqyAX9F2jzLhhsXr6Nks6", 198995U);
            var Output_1 = n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb.Create(Node_Context: Node_Context_0);
            n7.Pipet_MqYqrVR1BTcORjCCg8elsd that_2 = this;
            this.Array = n15._Operations_.CreateDefault<n8.Color4>();
            this.__p_DzqyAX9F2jzLhhsXr6Nks6 = Output_1;
            this.__if_ECY6FYfmobaOPtmyWpWzOJ = default(n3.Object);
            return that_2;
        }

        public n7.Pipet_MqYqrVR1BTcORjCCg8elsd __CreateDefault__()
        {
            n7.Pipet_MqYqrVR1BTcORjCCg8elsd that_0 = this;
            this.Array = n15._Operations_.CreateDefault<n8.Color4>();
            this.__p_DzqyAX9F2jzLhhsXr6Nks6 = n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb.CreateDefault();
            this.__if_ECY6FYfmobaOPtmyWpWzOJ = default(n3.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_DzqyAX9F2jzLhhsXr6Nks6);
            n1.CompilationHelper.SafeDispose(this.__if_ECY6FYfmobaOPtmyWpWzOJ);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 198948U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "F7UBWG7hYYtPLxC8yhJAaX", Name = "__slot_F7UBWG7hYYtPLxC8yhJAaX")]
        public static string __slot_F7UBWG7hYYtPLxC8yhJAaX = "< a dummy hidden output to not have the \"Update\" input pin on this node";
        [n1.ElementAttribute(TracingId = 198952U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "IjqVCQdzinPMTsK9fqRpyN", Name = "__slot_IjqVCQdzinPMTsK9fqRpyN")]
        public static bool __slot_IjqVCQdzinPMTsK9fqRpyN = false;
        [n1.ElementAttribute(TracingId = 199023U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "Huyyt7ugBKRQVfJD41I0sp", Name = "__slot_Huyyt7ugBKRQVfJD41I0sp")]
        public static string __slot_Huyyt7ugBKRQVfJD41I0sp = "(AllocationFree)";
        [n1.ElementAttribute(TracingId = 198931U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "UcP6ZhbGBCtM8CyLaHd3YQ", Name = "Array")]
        public n8.Color4[] Array;
        [n1.ElementAttribute(TracingId = 198995U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "DzqyAX9F2jzLhhsXr6Nks6", Name = "Pipet (AllocationFree)", IsManaged = true, IsAutoGenerated = true)]
        public n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb __p_DzqyAX9F2jzLhhsXr6Nks6;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n3.Object __if_ECY6FYfmobaOPtmyWpWzOJ;
        static Pipet_MqYqrVR1BTcORjCCg8elsd()
        {
        }

        public Pipet_MqYqrVR1BTcORjCCg8elsd(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Pipet_MqYqrVR1BTcORjCCg8elsd(Pipet_MqYqrVR1BTcORjCCg8elsd other): base(other)
        {
            this.Array = other.Array;
            this.__p_DzqyAX9F2jzLhhsXr6Nks6 = other.__p_DzqyAX9F2jzLhhsXr6Nks6;
            this.__if_ECY6FYfmobaOPtmyWpWzOJ = other.__if_ECY6FYfmobaOPtmyWpWzOJ;
        }

        protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Array", in Array), n1.CompilationHelper.GetValueOrExisting(values, "__p_DzqyAX9F2jzLhhsXr6Nks6", in __p_DzqyAX9F2jzLhhsXr6Nks6), n1.CompilationHelper.GetValueOrExisting(values, "__if_ECY6FYfmobaOPtmyWpWzOJ", in __if_ECY6FYfmobaOPtmyWpWzOJ));
        }

        internal Pipet_MqYqrVR1BTcORjCCg8elsd __WITH__(n8.Color4[] Array, n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb __p_DzqyAX9F2jzLhhsXr6Nks6, n3.Object __if_ECY6FYfmobaOPtmyWpWzOJ)
        {
            n7.Pipet_MqYqrVR1BTcORjCCg8elsd that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Array != this.Array || __p_DzqyAX9F2jzLhhsXr6Nks6 != this.__p_DzqyAX9F2jzLhhsXr6Nks6 || __if_ECY6FYfmobaOPtmyWpWzOJ != this.__if_ECY6FYfmobaOPtmyWpWzOJ ? new Pipet_MqYqrVR1BTcORjCCg8elsd(this)
                {Array = Array, __p_DzqyAX9F2jzLhhsXr6Nks6 = __p_DzqyAX9F2jzLhhsXr6Nks6, __if_ECY6FYfmobaOPtmyWpWzOJ = __if_ECY6FYfmobaOPtmyWpWzOJ} : that_0;
            else
            {
                this.Array = Array;
                this.__p_DzqyAX9F2jzLhhsXr6Nks6 = __p_DzqyAX9F2jzLhhsXr6Nks6;
                this.__if_ECY6FYfmobaOPtmyWpWzOJ = __if_ECY6FYfmobaOPtmyWpWzOJ;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "ULNFAwy2DJbLMLLnoyhlEH", Name = "__ULNFAwy2DJbLMLLnoyhlEH")]
        [n3.SerializableAttribute]
        public class __ULNFAwy2DJbLMLLnoyhlEH : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n11.Spread<n8.Color4> __cp_D5nIMqBGad8M0oo0h0gc0W;
            public __ULNFAwy2DJbLMLLnoyhlEH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __ULNFAwy2DJbLMLLnoyhlEH(__ULNFAwy2DJbLMLLnoyhlEH other): base(other)
            {
                this.__cp_D5nIMqBGad8M0oo0h0gc0W = other.__cp_D5nIMqBGad8M0oo0h0gc0W;
            }

            protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cp_D5nIMqBGad8M0oo0h0gc0W", in __cp_D5nIMqBGad8M0oo0h0gc0W));
            }

            internal __ULNFAwy2DJbLMLLnoyhlEH __WITH__(n11.Spread<n8.Color4> __cp_D5nIMqBGad8M0oo0h0gc0W)
            {
                __ULNFAwy2DJbLMLLnoyhlEH that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cp_D5nIMqBGad8M0oo0h0gc0W != this.__cp_D5nIMqBGad8M0oo0h0gc0W ? new __ULNFAwy2DJbLMLLnoyhlEH(this)
                    {__cp_D5nIMqBGad8M0oo0h0gc0W = __cp_D5nIMqBGad8M0oo0h0gc0W} : that_0;
                else
                {
                    this.__cp_D5nIMqBGad8M0oo0h0gc0W = __cp_D5nIMqBGad8M0oo0h0gc0W;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 199131U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "ASzS8IB8paoL1QHnoaJ2Yb", Name = "Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb")]
    [n3.SerializableAttribute]
    public class Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb : n1.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb Create(n1.NodeContext Node_Context)
        {
            var instance = new Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb CreateDefault()
        {
            var instance = new Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb Update(n10.Texture Texture_In, n8.Int2[] Positions_In, bool Convert_To_SRgb_In, n10.SamplerState Texture_Sampler_In, float Sample_Level_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Always_Update_In, [n5.SerializedDefaultValueAttribute("2", false)] int Frame_Delay_In, [n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out n8.Color4[] Output_Out)
        {
            n8.Vector2[] __auto_0 = this.Default;
            n12.ObjectHelpers.IsAssigned(x: Texture_In, result: out bool Result_1, notAssigned: out bool Not_Assigned_2);
            n12.ObjectHelpers.IsAssigned(x: Positions_In, result: out bool Result_3, notAssigned: out bool Not_Assigned_4);
            var Output_5 = Result_1 && Result_3;
            n8.Vector2[] __auto_6;
            var state_7 = n1.CompilationHelper.Restore<__FbWfOoRx6PyMRVSb5BqJe5>(this.__if_IbAXsqPwL7pQWeWjbJpqRI, __GetContext__());
            if (Output_5)
            {
                if (state_7 == null)
                {
                    state_7 = new __FbWfOoRx6PyMRVSb5BqJe5(__GetContext__(), n1.VLObject.NewIdentity());
                }

                var View_Width_8 = Texture_In.ViewWidth;
                var View_Height_9 = Texture_In.ViewHeight;
                float Y_10 = (float)View_Height_9;
                float X_11 = (float)View_Width_8;
                var Output_12 = new n8.Vector2(x: X_11, y: Y_10);
                n38._Operations_.OneOver<n8.Vector2, n32.__AdaptiveImplementations__VCMcVJqu2AbNoidKDyIIxx>(Input_In: Output_12, Output_Out: out n8.Vector2 Output_13);
                n15._Operations_.Length<n8.Int2>(Input_In: Positions_In, Output_Out: out n8.Int2[] Output_14, Length_Out: out int Length_15);
                bool Force_16 = false;
                bool Dispose_Cached_Outputs_17 = false;
                var manager_18 = state_7.__cache_Di3itsVRF8pMNpEuwuQS3K;
                if (manager_18 is null)
                {
                    manager_18 = new n20.Manager<n3.ValueTuple<int>, n3.ValueTuple<n8.Vector2[]>>(n3.ValueTuple.Create(n15._Operations_.CreateDefault<n8.Vector2>()));
                }

                var inputs_19 = n3.ValueTuple.Create(Length_15);
                var outputs_20 = manager_18.Outputs;
                var Has_Changed_21 = Force_16 || manager_18.InputsChanged(inputs_19);
                if (Has_Changed_21)
                {
                    if (Dispose_Cached_Outputs_17)
                        manager_18.DisposeOutputs();
                    n1.NodeContext Node_Context_23 = __GetContext__().CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "EzblNV7j3jzMxyVnmSlmbs", 199282U);
                    n15._Operations_.Create<n8.Vector2>(Node_Context: Node_Context_23, Length_In: Length_15, Result_Out: out n8.Vector2[] Result_24);
                    outputs_20 = n3.ValueTuple.Create(Result_24);
                    manager_18 = manager_18.Update(inputs_19, __GetContext__().IsImmutable, Dispose_Cached_Outputs_17, default, outputs_20);
                }
                else
                {
                    manager_18.Update(inputs_19, __GetContext__().IsImmutable, Dispose_Cached_Outputs_17);
                }

                var __auto_25 = outputs_20.Item1;
                n39._Operations_.Half<n8.Vector2, n32.__AdaptiveImplementations__VCMcVJqu2AbNoidKDyIIxx>(Half_Out: out n8.Vector2 Half_26);
                var i_29 = 0;
                foreach (var item_27 in Positions_In)
                {
                    var splicer_28 = item_27;
                    var i_local_30 = i_29;
                    var Result_32 = (n8.Vector2)splicer_28;
                    n8.Vector2.Add(left: ref Result_32, right: ref Half_26, result: out n8.Vector2 Output_33);
                    n40.Vector2Nodes.Multiply(left: ref Output_33, right: ref Output_13, result: out n8.Vector2 Output_34);
                    n15._Operations_.SetItem<n8.Vector2>(Input_In: __auto_25, Index_In: i_local_30, Value_In: Output_34, Output_Out: out n8.Vector2[] Output_35);
                    i_29++;
                }

                __auto_6 = __auto_25;
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = manager_18 != state_7.__cache_Di3itsVRF8pMNpEuwuQS3K ? new __FbWfOoRx6PyMRVSb5BqJe5(state_7)
                    {__cache_Di3itsVRF8pMNpEuwuQS3K = manager_18} : state_7;
                else
                {
                    state_7.__cache_Di3itsVRF8pMNpEuwuQS3K = manager_18;
                }
            }
            else
            {
                __auto_6 = __auto_0;
            }

            var State_Output_37 = this.__p_S7QFKULPgZHM8GUVLUn3yb.Update(Texture_In: Texture_In, Positions_In: __auto_6, Convert_To_SRgb_In: Convert_To_SRgb_In, Texture_Sampler_In: Texture_Sampler_In, Sample_Level_In: Sample_Level_In, Always_Update_In: Always_Update_In, Frame_Delay_In: Frame_Delay_In, Enabled_In: Enabled_In, Output_Out: out n8.Color4[] Output_36);
            Output_Out = Output_36;
            n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb that_38 = this;
            if (this.__GetContext__().IsImmutable)
                that_38 = state_7 != this.__if_IbAXsqPwL7pQWeWjbJpqRI || State_Output_37 != this.__p_S7QFKULPgZHM8GUVLUn3yb ? new Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb(this)
                {__if_IbAXsqPwL7pQWeWjbJpqRI = state_7, __p_S7QFKULPgZHM8GUVLUn3yb = State_Output_37} : that_38;
            else
            {
                this.__if_IbAXsqPwL7pQWeWjbJpqRI = state_7;
                this.__p_S7QFKULPgZHM8GUVLUn3yb = State_Output_37;
            }

            return that_38;
        }

        public n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb GetColorBuffer(out n10.Buffer Output_Buffer_Out)
        {
            var Output_1 = this.__p_S7QFKULPgZHM8GUVLUn3yb.GetColorBuffer(Output_Buffer_Out: out n10.Buffer Output_Buffer_0);
            Output_Buffer_Out = Output_Buffer_0;
            n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_S7QFKULPgZHM8GUVLUn3yb ? new Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb(this)
                {__p_S7QFKULPgZHM8GUVLUn3yb = Output_1} : that_2;
            else
            {
                this.__p_S7QFKULPgZHM8GUVLUn3yb = Output_1;
            }

            return that_2;
        }

        public n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb GetIsBlocking(out bool Is_Blocking_Out)
        {
            var Output_1 = this.__p_S7QFKULPgZHM8GUVLUn3yb.GetIsBlocking(Is_Blocking_Out: out bool Is_Blocking_0);
            Is_Blocking_Out = Is_Blocking_0;
            n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb that_2 = this;
            if (this.__GetContext__().IsImmutable)
                that_2 = Output_1 != this.__p_S7QFKULPgZHM8GUVLUn3yb ? new Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb(this)
                {__p_S7QFKULPgZHM8GUVLUn3yb = Output_1} : that_2;
            else
            {
                this.__p_S7QFKULPgZHM8GUVLUn3yb = Output_1;
            }

            return that_2;
        }

        public n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "Plgo2LlhLXeNpZSuVnZHya", 199368U);
            int Length_1 = 0;
            n15._Operations_.Create<n8.Vector2>(Node_Context: Node_Context_0, Length_In: Length_1, Result_Out: out n8.Vector2[] Result_2);
            n8.Vector2[] __auto_3 = Result_2;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "S7QFKULPgZHM8GUVLUn3yb", 199151U);
            var Output_5 = n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ.Create(Node_Context: Node_Context_4);
            n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb that_6 = this;
            this.Default = Result_2;
            this.__p_S7QFKULPgZHM8GUVLUn3yb = Output_5;
            this.__if_IbAXsqPwL7pQWeWjbJpqRI = default(n3.Object);
            return that_6;
        }

        public n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb __CreateDefault__()
        {
            n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb that_0 = this;
            this.Default = n15._Operations_.CreateDefault<n8.Vector2>();
            this.__if_IbAXsqPwL7pQWeWjbJpqRI = default(n3.Object);
            this.__p_S7QFKULPgZHM8GUVLUn3yb = n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_IbAXsqPwL7pQWeWjbJpqRI);
            n1.CompilationHelper.SafeDispose(this.__p_S7QFKULPgZHM8GUVLUn3yb);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 199378U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "VTmlbT94qTTNW4DpAZ7btE", Name = "Default")]
        public n8.Vector2[] Default;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n3.Object __if_IbAXsqPwL7pQWeWjbJpqRI;
        [n1.ElementAttribute(TracingId = 199151U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "S7QFKULPgZHM8GUVLUn3yb", Name = "Pipet (AllocationFree Relative)", IsManaged = true, IsAutoGenerated = true)]
        public n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ __p_S7QFKULPgZHM8GUVLUn3yb;
        public Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb(Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb other): base(other)
        {
            this.Default = other.Default;
            this.__if_IbAXsqPwL7pQWeWjbJpqRI = other.__if_IbAXsqPwL7pQWeWjbJpqRI;
            this.__p_S7QFKULPgZHM8GUVLUn3yb = other.__p_S7QFKULPgZHM8GUVLUn3yb;
        }

        protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "Default", in Default), n1.CompilationHelper.GetValueOrExisting(values, "__if_IbAXsqPwL7pQWeWjbJpqRI", in __if_IbAXsqPwL7pQWeWjbJpqRI), n1.CompilationHelper.GetValueOrExisting(values, "__p_S7QFKULPgZHM8GUVLUn3yb", in __p_S7QFKULPgZHM8GUVLUn3yb));
        }

        internal Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb __WITH__(n8.Vector2[] Default, n3.Object __if_IbAXsqPwL7pQWeWjbJpqRI, n7.Pipet_AllocationFree_Relative_T4SXmmL9FNFLFT9GzCcXjJ __p_S7QFKULPgZHM8GUVLUn3yb)
        {
            n7.Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = Default != this.Default || __if_IbAXsqPwL7pQWeWjbJpqRI != this.__if_IbAXsqPwL7pQWeWjbJpqRI || __p_S7QFKULPgZHM8GUVLUn3yb != this.__p_S7QFKULPgZHM8GUVLUn3yb ? new Pipet_AllocationFree_ASzS8IB8paoL1QHnoaJ2Yb(this)
                {Default = Default, __if_IbAXsqPwL7pQWeWjbJpqRI = __if_IbAXsqPwL7pQWeWjbJpqRI, __p_S7QFKULPgZHM8GUVLUn3yb = __p_S7QFKULPgZHM8GUVLUn3yb} : that_0;
            else
            {
                this.Default = Default;
                this.__if_IbAXsqPwL7pQWeWjbJpqRI = __if_IbAXsqPwL7pQWeWjbJpqRI;
                this.__p_S7QFKULPgZHM8GUVLUn3yb = __p_S7QFKULPgZHM8GUVLUn3yb;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "FbWfOoRx6PyMRVSb5BqJe5", Name = "__FbWfOoRx6PyMRVSb5BqJe5")]
        [n3.SerializableAttribute]
        public class __FbWfOoRx6PyMRVSb5BqJe5 : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__cache_Di3itsVRF8pMNpEuwuQS3K);
                return;
            }

            [n1.ElementAttribute(TracingId = 199266U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "Di3itsVRF8pMNpEuwuQS3K", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
            public n20.Manager<n3.ValueTuple<int>, n3.ValueTuple<n8.Vector2[]>> __cache_Di3itsVRF8pMNpEuwuQS3K = null;
            public __FbWfOoRx6PyMRVSb5BqJe5(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __FbWfOoRx6PyMRVSb5BqJe5(__FbWfOoRx6PyMRVSb5BqJe5 other): base(other)
            {
                this.__cache_Di3itsVRF8pMNpEuwuQS3K = other.__cache_Di3itsVRF8pMNpEuwuQS3K;
            }

            protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_Di3itsVRF8pMNpEuwuQS3K", in __cache_Di3itsVRF8pMNpEuwuQS3K));
            }

            internal __FbWfOoRx6PyMRVSb5BqJe5 __WITH__(n20.Manager<n3.ValueTuple<int>, n3.ValueTuple<n8.Vector2[]>> __cache_Di3itsVRF8pMNpEuwuQS3K)
            {
                __FbWfOoRx6PyMRVSb5BqJe5 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __cache_Di3itsVRF8pMNpEuwuQS3K != this.__cache_Di3itsVRF8pMNpEuwuQS3K ? new __FbWfOoRx6PyMRVSb5BqJe5(this)
                    {__cache_Di3itsVRF8pMNpEuwuQS3K = __cache_Di3itsVRF8pMNpEuwuQS3K} : that_0;
                else
                {
                    this.__cache_Di3itsVRF8pMNpEuwuQS3K = __cache_Di3itsVRF8pMNpEuwuQS3K;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Stride_Rendering_Temp_.Stride.Textures.Utils
{
    [n1.ElementAttribute(TracingId = 199492U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "UVeIl2fWwDMQQ69EFMa6Mg", Name = "JoinChannels_Textures_C")]
    [n3.SerializableAttribute]
    public class JoinChannels_Textures_C : n1.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.JoinChannels_Textures_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new JoinChannels_Textures_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.JoinChannels_Textures_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new JoinChannels_Textures_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.JoinChannels_Textures_C Update(out n10.Texture Output_Out)
        {
            var State_Output_1 = this.__p_Ei1fiaUVuRbNUku7F6FEOp.Update(Output_Out: out n6.SetVar<float> Output_0);
            this.__p_Ei1fiaUVuRbNUku7F6FEOp = State_Output_1;
            n1.CompilationHelper.WritePin(this.__p_KyMVkFugetkQLtNLyzE4fA.Inputs[0], ref Output_0);
            this.__p_KyMVkFugetkQLtNLyzE4fA = this.__p_KyMVkFugetkQLtNLyzE4fA;
            var State_Output_3 = this.__p_B1BFP2OUpQHNX1SwarGxyE.Update(Output_Out: out n6.SetVar<float> Output_2);
            this.__p_B1BFP2OUpQHNX1SwarGxyE = State_Output_3;
            n1.CompilationHelper.WritePin(this.__p_KyMVkFugetkQLtNLyzE4fA.Inputs[1], ref Output_2);
            this.__p_KyMVkFugetkQLtNLyzE4fA = this.__p_KyMVkFugetkQLtNLyzE4fA;
            var State_Output_5 = this.__p_EcPfwxkV7BsO2UZBmyH03f.Update(Output_Out: out n6.SetVar<float> Output_4);
            this.__p_EcPfwxkV7BsO2UZBmyH03f = State_Output_5;
            n1.CompilationHelper.WritePin(this.__p_KyMVkFugetkQLtNLyzE4fA.Inputs[2], ref Output_4);
            this.__p_KyMVkFugetkQLtNLyzE4fA = this.__p_KyMVkFugetkQLtNLyzE4fA;
            var State_Output_7 = this.__p_NL6rcd6TRVEQSzDCIRpIaV.Update(Output_Out: out n6.SetVar<float> Output_6);
            this.__p_NL6rcd6TRVEQSzDCIRpIaV = State_Output_7;
            n1.CompilationHelper.WritePin(this.__p_KyMVkFugetkQLtNLyzE4fA.Inputs[3], ref Output_6);
            this.__p_KyMVkFugetkQLtNLyzE4fA = this.__p_KyMVkFugetkQLtNLyzE4fA;
            n1.CompilationHelper.ReadPin(this.__p_KyMVkFugetkQLtNLyzE4fA.Outputs[0], out n10.Texture out_8);
            this.__p_KyMVkFugetkQLtNLyzE4fA = this.__p_KyMVkFugetkQLtNLyzE4fA;
            float Fallback_Value_9 = 1F;
            bool SetFallbackValue_10 = true;
            var Output_11 = State_Output_1;
            if (SetFallbackValue_10)
            {
                Output_11 = State_Output_1.SetFallbackValue(Fallback_Value_In: Fallback_Value_9);
            }

            this.__p_Ei1fiaUVuRbNUku7F6FEOp = Output_11;
            float Fallback_Value_12 = 1F;
            bool SetFallbackValue_13 = true;
            var Output_14 = State_Output_3;
            if (SetFallbackValue_13)
            {
                Output_14 = State_Output_3.SetFallbackValue(Fallback_Value_In: Fallback_Value_12);
            }

            this.__p_B1BFP2OUpQHNX1SwarGxyE = Output_14;
            float Fallback_Value_15 = 1F;
            bool SetFallbackValue_16 = true;
            var Output_17 = State_Output_5;
            if (SetFallbackValue_16)
            {
                Output_17 = State_Output_5.SetFallbackValue(Fallback_Value_In: Fallback_Value_15);
            }

            this.__p_EcPfwxkV7BsO2UZBmyH03f = Output_17;
            float Fallback_Value_18 = 1F;
            bool SetFallbackValue_19 = true;
            var Output_20 = State_Output_7;
            if (SetFallbackValue_19)
            {
                Output_20 = State_Output_7.SetFallbackValue(Fallback_Value_In: Fallback_Value_18);
            }

            this.__p_NL6rcd6TRVEQSzDCIRpIaV = Output_20;
            Output_Out = out_8;
            return this;
        }

        public n4.JoinChannels_Textures_C SetInput(n10.Texture Channel_0_In, n10.Texture Channel_1_In, n10.Texture Channel_2_In, n10.Texture Channel_3_In, n8.Int2 Output_Size_In)
        {
            bool SetTexure_0 = true;
            var Output_1 = this.__p_Ei1fiaUVuRbNUku7F6FEOp;
            if (SetTexure_0)
            {
                Output_1 = this.__p_Ei1fiaUVuRbNUku7F6FEOp.SetTexure(Texture_In: Channel_0_In);
            }

            this.__p_Ei1fiaUVuRbNUku7F6FEOp = Output_1;
            n16._Operations_.CalcCommonSize(Channel_0_In: Channel_0_In, Channel_1_In: Channel_1_In, Channel_2_In: Channel_2_In, Channel_3_In: Channel_3_In, Output_Out: out n8.Int2 Output_2);
            bool SetTexure_3 = true;
            var Output_4 = this.__p_B1BFP2OUpQHNX1SwarGxyE;
            if (SetTexure_3)
            {
                Output_4 = this.__p_B1BFP2OUpQHNX1SwarGxyE.SetTexure(Texture_In: Channel_1_In);
            }

            this.__p_B1BFP2OUpQHNX1SwarGxyE = Output_4;
            bool SetTexure_5 = true;
            var Output_6 = this.__p_EcPfwxkV7BsO2UZBmyH03f;
            if (SetTexure_5)
            {
                Output_6 = this.__p_EcPfwxkV7BsO2UZBmyH03f.SetTexure(Texture_In: Channel_2_In);
            }

            this.__p_EcPfwxkV7BsO2UZBmyH03f = Output_6;
            bool SetTexure_7 = true;
            var Output_8 = this.__p_NL6rcd6TRVEQSzDCIRpIaV;
            if (SetTexure_7)
            {
                Output_8 = this.__p_NL6rcd6TRVEQSzDCIRpIaV.SetTexure(Texture_In: Channel_3_In);
            }

            this.__p_NL6rcd6TRVEQSzDCIRpIaV = Output_8;
            n17._Operations_.ReplaceSize(Size_In: Output_2, Replace_Size_In: Output_Size_In, Output_Out: out n8.Int2 Output_9);
            n1.CompilationHelper.WritePin(this.__p_KyMVkFugetkQLtNLyzE4fA.Inputs[4], ref Output_9);
            this.__p_KyMVkFugetkQLtNLyzE4fA = this.__p_KyMVkFugetkQLtNLyzE4fA;
            return this;
        }

        public n4.JoinChannels_Textures_C SetOutputFormat([n5.SerializedDefaultValueAttribute("R8G8B8A8_UNorm_SRgb", false)] n19.PixelFormat Output_Format_In)
        {
            n1.CompilationHelper.WritePin(this.__p_KyMVkFugetkQLtNLyzE4fA.Inputs[5], ref Output_Format_In);
            this.__p_KyMVkFugetkQLtNLyzE4fA = this.__p_KyMVkFugetkQLtNLyzE4fA;
            return this;
        }

        public n4.JoinChannels_Textures_C SetRenderFormat([n5.SerializedDefaultValueAttribute("None", false)] n19.PixelFormat Render_Format_In)
        {
            n1.CompilationHelper.WritePin(this.__p_KyMVkFugetkQLtNLyzE4fA.Inputs[6], ref Render_Format_In);
            this.__p_KyMVkFugetkQLtNLyzE4fA = this.__p_KyMVkFugetkQLtNLyzE4fA;
            return this;
        }

        public n4.JoinChannels_Textures_C SetOutputTexture(n10.Texture Output_Texture_In)
        {
            n1.CompilationHelper.WritePin(this.__p_KyMVkFugetkQLtNLyzE4fA.Inputs[7], ref Output_Texture_In);
            this.__p_KyMVkFugetkQLtNLyzE4fA = this.__p_KyMVkFugetkQLtNLyzE4fA;
            return this;
        }

        public n4.JoinChannels_Textures_C SetEnabled([n5.SerializedDefaultValueAttribute("True", false)] bool Enabled_In)
        {
            n1.CompilationHelper.WritePin(this.__p_KyMVkFugetkQLtNLyzE4fA.Inputs[8], ref Enabled_In);
            this.__p_KyMVkFugetkQLtNLyzE4fA = this.__p_KyMVkFugetkQLtNLyzE4fA;
            return this;
        }

        public n4.JoinChannels_Textures_C __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "JoinChannels", "Stride.Textures.Utils");
            this.__p_KyMVkFugetkQLtNLyzE4fA = node_0;
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "Ei1fiaUVuRbNUku7F6FEOp", 199520U);
            var Output_2 = n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu.Create(Node_Context: Node_Context_1);
            this.__p_Ei1fiaUVuRbNUku7F6FEOp = Output_2;
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "B1BFP2OUpQHNX1SwarGxyE", 199690U);
            var Output_4 = n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu.Create(Node_Context: Node_Context_3);
            this.__p_B1BFP2OUpQHNX1SwarGxyE = Output_4;
            n1.NodeContext Node_Context_5 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "EcPfwxkV7BsO2UZBmyH03f", 199704U);
            var Output_6 = n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu.Create(Node_Context: Node_Context_5);
            this.__p_EcPfwxkV7BsO2UZBmyH03f = Output_6;
            n1.NodeContext Node_Context_7 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "NL6rcd6TRVEQSzDCIRpIaV", 199715U);
            var Output_8 = n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu.Create(Node_Context: Node_Context_7);
            this.__p_NL6rcd6TRVEQSzDCIRpIaV = Output_8;
            return this;
        }

        public n4.JoinChannels_Textures_C __CreateDefault__()
        {
            this.__p_Ei1fiaUVuRbNUku7F6FEOp = n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu.CreateDefault();
            this.__p_KyMVkFugetkQLtNLyzE4fA = default(n1.IVLNode);
            this.__p_B1BFP2OUpQHNX1SwarGxyE = n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu.CreateDefault();
            this.__p_EcPfwxkV7BsO2UZBmyH03f = n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu.CreateDefault();
            this.__p_NL6rcd6TRVEQSzDCIRpIaV = n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Ei1fiaUVuRbNUku7F6FEOp);
            n1.CompilationHelper.SafeDispose(this.__p_KyMVkFugetkQLtNLyzE4fA);
            n1.CompilationHelper.SafeDispose(this.__p_B1BFP2OUpQHNX1SwarGxyE);
            n1.CompilationHelper.SafeDispose(this.__p_EcPfwxkV7BsO2UZBmyH03f);
            n1.CompilationHelper.SafeDispose(this.__p_NL6rcd6TRVEQSzDCIRpIaV);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 199520U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "Ei1fiaUVuRbNUku7F6FEOp", Name = "ValueMap", IsManaged = true, IsAutoGenerated = true)]
        public n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu __p_Ei1fiaUVuRbNUku7F6FEOp;
        [n1.ElementAttribute(TracingId = 199497U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "KyMVkFugetkQLtNLyzE4fA", Name = "JoinChannels", IsManaged = true, IsAutoGenerated = true, NodeName = "JoinChannels", NodeCategory = "Stride.Textures.Utils")]
        public n1.IVLNode __p_KyMVkFugetkQLtNLyzE4fA;
        [n1.ElementAttribute(TracingId = 199690U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "B1BFP2OUpQHNX1SwarGxyE", Name = "ValueMap", IsManaged = true, IsAutoGenerated = true)]
        public n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu __p_B1BFP2OUpQHNX1SwarGxyE;
        [n1.ElementAttribute(TracingId = 199704U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "EcPfwxkV7BsO2UZBmyH03f", Name = "ValueMap", IsManaged = true, IsAutoGenerated = true)]
        public n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu __p_EcPfwxkV7BsO2UZBmyH03f;
        [n1.ElementAttribute(TracingId = 199715U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "NL6rcd6TRVEQSzDCIRpIaV", Name = "ValueMap", IsManaged = true, IsAutoGenerated = true)]
        public n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu __p_NL6rcd6TRVEQSzDCIRpIaV;
        public JoinChannels_Textures_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal JoinChannels_Textures_C(JoinChannels_Textures_C other): base(other)
        {
            this.__p_Ei1fiaUVuRbNUku7F6FEOp = other.__p_Ei1fiaUVuRbNUku7F6FEOp;
            this.__p_KyMVkFugetkQLtNLyzE4fA = other.__p_KyMVkFugetkQLtNLyzE4fA;
            this.__p_B1BFP2OUpQHNX1SwarGxyE = other.__p_B1BFP2OUpQHNX1SwarGxyE;
            this.__p_EcPfwxkV7BsO2UZBmyH03f = other.__p_EcPfwxkV7BsO2UZBmyH03f;
            this.__p_NL6rcd6TRVEQSzDCIRpIaV = other.__p_NL6rcd6TRVEQSzDCIRpIaV;
        }

        protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Ei1fiaUVuRbNUku7F6FEOp", in __p_Ei1fiaUVuRbNUku7F6FEOp), n1.CompilationHelper.GetValueOrExisting(values, "__p_KyMVkFugetkQLtNLyzE4fA", in __p_KyMVkFugetkQLtNLyzE4fA), n1.CompilationHelper.GetValueOrExisting(values, "__p_B1BFP2OUpQHNX1SwarGxyE", in __p_B1BFP2OUpQHNX1SwarGxyE), n1.CompilationHelper.GetValueOrExisting(values, "__p_EcPfwxkV7BsO2UZBmyH03f", in __p_EcPfwxkV7BsO2UZBmyH03f), n1.CompilationHelper.GetValueOrExisting(values, "__p_NL6rcd6TRVEQSzDCIRpIaV", in __p_NL6rcd6TRVEQSzDCIRpIaV));
        }

        internal JoinChannels_Textures_C __WITH__(n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu __p_Ei1fiaUVuRbNUku7F6FEOp, n1.IVLNode __p_KyMVkFugetkQLtNLyzE4fA, n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu __p_B1BFP2OUpQHNX1SwarGxyE, n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu __p_EcPfwxkV7BsO2UZBmyH03f, n21.ValueMap_MSDYzfiuxQTMHIqVDSqrQu __p_NL6rcd6TRVEQSzDCIRpIaV)
        {
            n4.JoinChannels_Textures_C that_0 = this;
            this.__p_Ei1fiaUVuRbNUku7F6FEOp = __p_Ei1fiaUVuRbNUku7F6FEOp;
            this.__p_KyMVkFugetkQLtNLyzE4fA = __p_KyMVkFugetkQLtNLyzE4fA;
            this.__p_B1BFP2OUpQHNX1SwarGxyE = __p_B1BFP2OUpQHNX1SwarGxyE;
            this.__p_EcPfwxkV7BsO2UZBmyH03f = __p_EcPfwxkV7BsO2UZBmyH03f;
            this.__p_NL6rcd6TRVEQSzDCIRpIaV = __p_NL6rcd6TRVEQSzDCIRpIaV;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 199802U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "Il4hhPpE6dDO1UQ1RvG3V7", Name = "SplitChannels_C")]
    [n3.SerializableAttribute]
    public class SplitChannels_C : n1.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.SplitChannels_C Create(n1.NodeContext Node_Context)
        {
            Node_Context = Node_Context.WithIsImmutable(false);
            var instance = new SplitChannels_C(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.SplitChannels_C CreateDefault()
        {
            var context = n1.NodeContext.Default.WithIsImmutable(false);
            var instance = new SplitChannels_C(context, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.SplitChannels_C Update(n10.Texture Input_In, out n6.SetVar<float> Channel_0_Out, out n6.SetVar<float> Channel_1_Out, out n6.SetVar<float> Channel_2_Out, out n6.SetVar<float> Channel_3_Out)
        {
            bool SetTexure_0 = true;
            var Output_1 = this.__p_QiKs8SXMc1xMlT6PXMtXQU;
            if (SetTexure_0)
            {
                Output_1 = this.__p_QiKs8SXMc1xMlT6PXMtXQU.SetTexure(Texture_In: Input_In);
            }

            this.__p_QiKs8SXMc1xMlT6PXMtXQU = Output_1;
            var State_Output_3 = Output_1.Update(Output_Out: out n6.SetVar<n8.Vector4> Output_2);
            this.__p_QiKs8SXMc1xMlT6PXMtXQU = State_Output_3;
            n8.Color4 Fallback_Color_4 = n41._Operations_.CreateDefault();
            bool Fallback_Color_Premultiply_Alpha_5 = false;
            bool Is_Normal_6 = false;
            bool SetFallbackColor_7 = true;
            var Output_8 = State_Output_3;
            if (SetFallbackColor_7)
            {
                Output_8 = State_Output_3.SetFallbackColor(Fallback_Color_In: Fallback_Color_4, Fallback_Color_Premultiply_Alpha_In: Fallback_Color_Premultiply_Alpha_5, Is_Normal_In: Is_Normal_6);
            }

            this.__p_QiKs8SXMc1xMlT6PXMtXQU = Output_8;
            var State_Output_10 = this.__p_M2231j8TmM4MMNY781d1Os.Update<n32.__AdaptiveImplementations__VCMcVJqu2AbNoidKDyIIxx>(Input_In: Output_2, Output_Out: out n6.SetVar<float> Output_9);
            this.__p_M2231j8TmM4MMNY781d1Os = State_Output_10;
            var State_Output_12 = this.__p_IceAn1AheC6OoiiUf1fNlf.Update<n32.__AdaptiveImplementations__VCMcVJqu2AbNoidKDyIIxx>(Input_In: Output_2, Output_Out: out n6.SetVar<float> Output_11);
            this.__p_IceAn1AheC6OoiiUf1fNlf = State_Output_12;
            var State_Output_14 = this.__p_Gjvmxm460urOGDT7Zf1Djt.Update<n32.__AdaptiveImplementations__VCMcVJqu2AbNoidKDyIIxx>(Input_In: Output_2, Output_Out: out n6.SetVar<float> Output_13);
            this.__p_Gjvmxm460urOGDT7Zf1Djt = State_Output_14;
            var State_Output_16 = this.__p_OB50Oa5knMULiVQvCuoaBM.Update<n32.__AdaptiveImplementations__VCMcVJqu2AbNoidKDyIIxx>(Input_In: Output_2, Output_Out: out n6.SetVar<float> Output_15);
            this.__p_OB50Oa5knMULiVQvCuoaBM = State_Output_16;
            Channel_0_Out = Output_9;
            Channel_1_Out = Output_11;
            Channel_2_Out = Output_13;
            Channel_3_Out = Output_15;
            return this;
        }

        public n4.SplitChannels_C __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "QiKs8SXMc1xMlT6PXMtXQU", 199805U);
            var Output_1 = n21.ColorMap_KOxQ1z1ZXvlODfQvuwEtGx.Create(Node_Context: Node_Context_0);
            this.__p_QiKs8SXMc1xMlT6PXMtXQU = Output_1;
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "M2231j8TmM4MMNY781d1Os", 199811U);
            var Output_3 = n42.r_IoKIq3QPdj5LVI9eEiWV1a<n8.Vector4>.Create(Node_Context: Node_Context_2);
            this.__p_M2231j8TmM4MMNY781d1Os = Output_3;
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "IceAn1AheC6OoiiUf1fNlf", 199814U);
            var Output_5 = n42.g_Pk3C87Vwkd9Lo2viZMg7ou<n8.Vector4>.Create(Node_Context: Node_Context_4);
            this.__p_IceAn1AheC6OoiiUf1fNlf = Output_5;
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "Gjvmxm460urOGDT7Zf1Djt", 199822U);
            var Output_7 = n42.b_MP5PFxVYo3rPueEvyoP76m<n8.Vector4>.Create(Node_Context: Node_Context_6);
            this.__p_Gjvmxm460urOGDT7Zf1Djt = Output_7;
            n1.NodeContext Node_Context_8 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "OB50Oa5knMULiVQvCuoaBM", 199825U);
            var Output_9 = n42.a_PAHGUQ4zz0DNDBcaJgwciU<n8.Vector4>.Create(Node_Context: Node_Context_8);
            this.__p_OB50Oa5knMULiVQvCuoaBM = Output_9;
            return this;
        }

        public n4.SplitChannels_C __CreateDefault__()
        {
            this.__p_QiKs8SXMc1xMlT6PXMtXQU = n21.ColorMap_KOxQ1z1ZXvlODfQvuwEtGx.CreateDefault();
            this.__p_M2231j8TmM4MMNY781d1Os = n42.r_IoKIq3QPdj5LVI9eEiWV1a<n8.Vector4>.CreateDefault();
            this.__p_IceAn1AheC6OoiiUf1fNlf = n42.g_Pk3C87Vwkd9Lo2viZMg7ou<n8.Vector4>.CreateDefault();
            this.__p_Gjvmxm460urOGDT7Zf1Djt = n42.b_MP5PFxVYo3rPueEvyoP76m<n8.Vector4>.CreateDefault();
            this.__p_OB50Oa5knMULiVQvCuoaBM = n42.a_PAHGUQ4zz0DNDBcaJgwciU<n8.Vector4>.CreateDefault();
            return this;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_QiKs8SXMc1xMlT6PXMtXQU);
            n1.CompilationHelper.SafeDispose(this.__p_M2231j8TmM4MMNY781d1Os);
            n1.CompilationHelper.SafeDispose(this.__p_IceAn1AheC6OoiiUf1fNlf);
            n1.CompilationHelper.SafeDispose(this.__p_Gjvmxm460urOGDT7Zf1Djt);
            n1.CompilationHelper.SafeDispose(this.__p_OB50Oa5knMULiVQvCuoaBM);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 199805U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "QiKs8SXMc1xMlT6PXMtXQU", Name = "ColorMap", IsManaged = true, IsAutoGenerated = true)]
        public n21.ColorMap_KOxQ1z1ZXvlODfQvuwEtGx __p_QiKs8SXMc1xMlT6PXMtXQU;
        [n1.ElementAttribute(TracingId = 199811U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "M2231j8TmM4MMNY781d1Os", Name = "r", IsManaged = true, IsAutoGenerated = true)]
        public n42.r_IoKIq3QPdj5LVI9eEiWV1a<n8.Vector4> __p_M2231j8TmM4MMNY781d1Os;
        [n1.ElementAttribute(TracingId = 199814U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "IceAn1AheC6OoiiUf1fNlf", Name = "g", IsManaged = true, IsAutoGenerated = true)]
        public n42.g_Pk3C87Vwkd9Lo2viZMg7ou<n8.Vector4> __p_IceAn1AheC6OoiiUf1fNlf;
        [n1.ElementAttribute(TracingId = 199822U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "Gjvmxm460urOGDT7Zf1Djt", Name = "b", IsManaged = true, IsAutoGenerated = true)]
        public n42.b_MP5PFxVYo3rPueEvyoP76m<n8.Vector4> __p_Gjvmxm460urOGDT7Zf1Djt;
        [n1.ElementAttribute(TracingId = 199825U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "OB50Oa5knMULiVQvCuoaBM", Name = "a", IsManaged = true, IsAutoGenerated = true)]
        public n42.a_PAHGUQ4zz0DNDBcaJgwciU<n8.Vector4> __p_OB50Oa5knMULiVQvCuoaBM;
        public SplitChannels_C(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SplitChannels_C(SplitChannels_C other): base(other)
        {
            this.__p_QiKs8SXMc1xMlT6PXMtXQU = other.__p_QiKs8SXMc1xMlT6PXMtXQU;
            this.__p_M2231j8TmM4MMNY781d1Os = other.__p_M2231j8TmM4MMNY781d1Os;
            this.__p_IceAn1AheC6OoiiUf1fNlf = other.__p_IceAn1AheC6OoiiUf1fNlf;
            this.__p_Gjvmxm460urOGDT7Zf1Djt = other.__p_Gjvmxm460urOGDT7Zf1Djt;
            this.__p_OB50Oa5knMULiVQvCuoaBM = other.__p_OB50Oa5knMULiVQvCuoaBM;
        }

        protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QiKs8SXMc1xMlT6PXMtXQU", in __p_QiKs8SXMc1xMlT6PXMtXQU), n1.CompilationHelper.GetValueOrExisting(values, "__p_M2231j8TmM4MMNY781d1Os", in __p_M2231j8TmM4MMNY781d1Os), n1.CompilationHelper.GetValueOrExisting(values, "__p_IceAn1AheC6OoiiUf1fNlf", in __p_IceAn1AheC6OoiiUf1fNlf), n1.CompilationHelper.GetValueOrExisting(values, "__p_Gjvmxm460urOGDT7Zf1Djt", in __p_Gjvmxm460urOGDT7Zf1Djt), n1.CompilationHelper.GetValueOrExisting(values, "__p_OB50Oa5knMULiVQvCuoaBM", in __p_OB50Oa5knMULiVQvCuoaBM));
        }

        internal SplitChannels_C __WITH__(n21.ColorMap_KOxQ1z1ZXvlODfQvuwEtGx __p_QiKs8SXMc1xMlT6PXMtXQU, n42.r_IoKIq3QPdj5LVI9eEiWV1a<n8.Vector4> __p_M2231j8TmM4MMNY781d1Os, n42.g_Pk3C87Vwkd9Lo2viZMg7ou<n8.Vector4> __p_IceAn1AheC6OoiiUf1fNlf, n42.b_MP5PFxVYo3rPueEvyoP76m<n8.Vector4> __p_Gjvmxm460urOGDT7Zf1Djt, n42.a_PAHGUQ4zz0DNDBcaJgwciU<n8.Vector4> __p_OB50Oa5knMULiVQvCuoaBM)
        {
            n4.SplitChannels_C that_0 = this;
            this.__p_QiKs8SXMc1xMlT6PXMtXQU = __p_QiKs8SXMc1xMlT6PXMtXQU;
            this.__p_M2231j8TmM4MMNY781d1Os = __p_M2231j8TmM4MMNY781d1Os;
            this.__p_IceAn1AheC6OoiiUf1fNlf = __p_IceAn1AheC6OoiiUf1fNlf;
            this.__p_Gjvmxm460urOGDT7Zf1Djt = __p_Gjvmxm460urOGDT7Zf1Djt;
            this.__p_OB50Oa5knMULiVQvCuoaBM = __p_OB50Oa5knMULiVQvCuoaBM;
            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 199853U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "LOI5hd0svvkP8BO1rUF0ci", Name = "SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci")]
    [n3.SerializableAttribute]
    public class SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci : n1.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n4.SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci Create(n1.NodeContext Node_Context)
        {
            var instance = new SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n4.SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci CreateDefault()
        {
            var instance = new SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n4.SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci Update(n10.Texture Input_In, [n5.SerializedDefaultValueAttribute("R32_Float", false)] n19.PixelFormat Output_Format_In, out n10.Texture Channel_0_Out, out n10.Texture Channel_1_Out, out n10.Texture Channel_2_Out, out n10.Texture Channel_3_Out)
        {
            n8.Int2 __pad_H65G9Hg4rUoQS4FubDHrxV_0 = __slot_H65G9Hg4rUoQS4FubDHrxV;
            var State_Output_8 = this.__p_TdLVO1y2oUCPAzqjOF3gNj.Update(Input_In: Input_In, New_Format_In: Output_Format_In, Output_Out: out n10.Texture Output_1, Size_Out: out n8.Int2 Size_2, Channel_0_Out: out n10.Texture Channel_0_3, Channel_1_Out: out n10.Texture Channel_1_4, Channel_2_Out: out n10.Texture Channel_2_5, Channel_3_Out: out n10.Texture Channel_3_6, Exists_Out: out bool Exists_7);
            n30._Operations_.CalcDispatchArgs2D(Count_In: Size_2, Thread_Group_Size_In: __pad_H65G9Hg4rUoQS4FubDHrxV_0, Thread_Group_Count_Out: out n8.Int3 Thread_Group_Count_9, Thread_Group_Size_Out: out n8.Int3 Thread_Group_Size_10);
            n1.CompilationHelper.WritePin(this.__p_DUisa9Zsn8NPsw0Jzz6DWX.Inputs[0], ref Thread_Group_Count_9);
            n1.CompilationHelper.ReadPin(this.__p_DUisa9Zsn8NPsw0Jzz6DWX.Outputs[0], out n31.IComputeEffectDispatcher out_11);
            n1.CompilationHelper.WritePin(this.__p_DWX7mhdtaCVNw3tLjL28iR.Inputs[0], ref out_11);
            n1.CompilationHelper.WritePin(this.__p_DWX7mhdtaCVNw3tLjL28iR.Inputs[1], ref Thread_Group_Size_10);
            n1.CompilationHelper.WritePin(this.__p_DWX7mhdtaCVNw3tLjL28iR.Inputs[3], ref Output_1);
            n1.CompilationHelper.WritePin(this.__p_DWX7mhdtaCVNw3tLjL28iR.Inputs[4], ref Channel_0_3);
            n1.CompilationHelper.WritePin(this.__p_DWX7mhdtaCVNw3tLjL28iR.Inputs[5], ref Channel_1_4);
            n1.CompilationHelper.WritePin(this.__p_DWX7mhdtaCVNw3tLjL28iR.Inputs[6], ref Channel_2_5);
            n1.CompilationHelper.WritePin(this.__p_DWX7mhdtaCVNw3tLjL28iR.Inputs[7], ref Channel_3_6);
            n1.CompilationHelper.WritePin(this.__p_DWX7mhdtaCVNw3tLjL28iR.Inputs[8], ref Size_2);
            n1.CompilationHelper.WritePin(this.__p_DWX7mhdtaCVNw3tLjL28iR.Inputs[9], ref Exists_7);
            n1.CompilationHelper.ReadPin(this.__p_DWX7mhdtaCVNw3tLjL28iR.Outputs[0], out n34.IGraphicsRendererBase out_12);
            bool Schedule_13 = true;
            var Output_14 = this.__p_AIHuOL6Bi54QUTRLbxIqDr;
            if (Schedule_13)
            {
                Output_14 = this.__p_AIHuOL6Bi54QUTRLbxIqDr.Schedule(Renderer_In: out_12);
            }

            Channel_0_Out = Channel_0_3;
            Channel_1_Out = Channel_1_4;
            Channel_2_Out = Channel_2_5;
            Channel_3_Out = Channel_3_6;
            n4.SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci that_15 = this;
            if (this.__GetContext__().IsImmutable)
                that_15 = State_Output_8 != this.__p_TdLVO1y2oUCPAzqjOF3gNj || this.__p_DUisa9Zsn8NPsw0Jzz6DWX != this.__p_DUisa9Zsn8NPsw0Jzz6DWX || this.__p_DWX7mhdtaCVNw3tLjL28iR != this.__p_DWX7mhdtaCVNw3tLjL28iR || Output_14 != this.__p_AIHuOL6Bi54QUTRLbxIqDr ? new SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci(this)
                {__p_TdLVO1y2oUCPAzqjOF3gNj = State_Output_8, __p_DUisa9Zsn8NPsw0Jzz6DWX = this.__p_DUisa9Zsn8NPsw0Jzz6DWX, __p_DWX7mhdtaCVNw3tLjL28iR = this.__p_DWX7mhdtaCVNw3tLjL28iR, __p_AIHuOL6Bi54QUTRLbxIqDr = Output_14} : that_15;
            else
            {
                this.__p_TdLVO1y2oUCPAzqjOF3gNj = State_Output_8;
                this.__p_DUisa9Zsn8NPsw0Jzz6DWX = this.__p_DUisa9Zsn8NPsw0Jzz6DWX;
                this.__p_DWX7mhdtaCVNw3tLjL28iR = this.__p_DWX7mhdtaCVNw3tLjL28iR;
                this.__p_AIHuOL6Bi54QUTRLbxIqDr = Output_14;
            }

            return that_15;
        }

        public n4.SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            var node_0 = n1.CompilationHelper.CreateNodeById(Node_Context, "SplitChannelsShader (Internal)", "Stride.Rendering.ComputeShaders");
            n1.NodeContext Node_Context_1 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "TdLVO1y2oUCPAzqjOF3gNj", 200109U);
            var Output_2 = n25.ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r.Create(Node_Context: Node_Context_1);
            n1.NodeContext Node_Context_3 = Node_Context.CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "AIHuOL6Bi54QUTRLbxIqDr", 200157U);
            var Output_4 = n27.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D.Create(Node_Context: Node_Context_3);
            var node_5 = n1.CompilationHelper.CreateNodeById(Node_Context, "DirectDispatcher", "Stride.Rendering.Advanced");
            n4.SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci that_6 = this;
            this.__p_DWX7mhdtaCVNw3tLjL28iR = node_0;
            this.__p_TdLVO1y2oUCPAzqjOF3gNj = Output_2;
            this.__p_AIHuOL6Bi54QUTRLbxIqDr = Output_4;
            this.__p_DUisa9Zsn8NPsw0Jzz6DWX = node_5;
            return that_6;
        }

        public n4.SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci __CreateDefault__()
        {
            n4.SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci that_0 = this;
            this.__p_TdLVO1y2oUCPAzqjOF3gNj = n25.ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r.CreateDefault();
            this.__p_DUisa9Zsn8NPsw0Jzz6DWX = default(n1.IVLNode);
            this.__p_DWX7mhdtaCVNw3tLjL28iR = default(n1.IVLNode);
            this.__p_AIHuOL6Bi54QUTRLbxIqDr = n27.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_TdLVO1y2oUCPAzqjOF3gNj);
            n1.CompilationHelper.SafeDispose(this.__p_DUisa9Zsn8NPsw0Jzz6DWX);
            n1.CompilationHelper.SafeDispose(this.__p_DWX7mhdtaCVNw3tLjL28iR);
            n1.CompilationHelper.SafeDispose(this.__p_AIHuOL6Bi54QUTRLbxIqDr);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 200200U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "H65G9Hg4rUoQS4FubDHrxV", Name = "__slot_H65G9Hg4rUoQS4FubDHrxV")]
        public static n8.Int2 __slot_H65G9Hg4rUoQS4FubDHrxV = n1.CompilationHelper.Deserialize<n8.Int2>("8, 8", false, "VCMcVJqu2AbNoidKDyIIxx", "H65G9Hg4rUoQS4FubDHrxV");
        [n1.ElementAttribute(TracingId = 200109U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "TdLVO1y2oUCPAzqjOF3gNj", Name = "ChannelTexturesFromInput", IsManaged = true, IsAutoGenerated = true)]
        public n25.ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r __p_TdLVO1y2oUCPAzqjOF3gNj;
        [n1.ElementAttribute(TracingId = 200162U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "DUisa9Zsn8NPsw0Jzz6DWX", Name = "DirectDispatcher", IsManaged = true, IsAutoGenerated = true, NodeName = "DirectDispatcher", NodeCategory = "Stride.Rendering.Advanced")]
        public n1.IVLNode __p_DUisa9Zsn8NPsw0Jzz6DWX;
        [n1.ElementAttribute(TracingId = 199856U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "DWX7mhdtaCVNw3tLjL28iR", Name = "SplitChannelsShader", IsManaged = true, IsAutoGenerated = true, NodeName = "SplitChannelsShader (Internal)", NodeCategory = "Stride.Rendering.ComputeShaders")]
        public n1.IVLNode __p_DWX7mhdtaCVNw3tLjL28iR;
        [n1.ElementAttribute(TracingId = 200157U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "AIHuOL6Bi54QUTRLbxIqDr", Name = "RendererScheduler", IsManaged = true, IsAutoGenerated = true)]
        public n27.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D __p_AIHuOL6Bi54QUTRLbxIqDr;
        static SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci()
        {
        }

        public SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci(SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci other): base(other)
        {
            this.__p_TdLVO1y2oUCPAzqjOF3gNj = other.__p_TdLVO1y2oUCPAzqjOF3gNj;
            this.__p_DUisa9Zsn8NPsw0Jzz6DWX = other.__p_DUisa9Zsn8NPsw0Jzz6DWX;
            this.__p_DWX7mhdtaCVNw3tLjL28iR = other.__p_DWX7mhdtaCVNw3tLjL28iR;
            this.__p_AIHuOL6Bi54QUTRLbxIqDr = other.__p_AIHuOL6Bi54QUTRLbxIqDr;
        }

        protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TdLVO1y2oUCPAzqjOF3gNj", in __p_TdLVO1y2oUCPAzqjOF3gNj), n1.CompilationHelper.GetValueOrExisting(values, "__p_DUisa9Zsn8NPsw0Jzz6DWX", in __p_DUisa9Zsn8NPsw0Jzz6DWX), n1.CompilationHelper.GetValueOrExisting(values, "__p_DWX7mhdtaCVNw3tLjL28iR", in __p_DWX7mhdtaCVNw3tLjL28iR), n1.CompilationHelper.GetValueOrExisting(values, "__p_AIHuOL6Bi54QUTRLbxIqDr", in __p_AIHuOL6Bi54QUTRLbxIqDr));
        }

        internal SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci __WITH__(n25.ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r __p_TdLVO1y2oUCPAzqjOF3gNj, n1.IVLNode __p_DUisa9Zsn8NPsw0Jzz6DWX, n1.IVLNode __p_DWX7mhdtaCVNw3tLjL28iR, n27.RendererScheduler_A5jsSvRdG3aQXzlHCbUc8D __p_AIHuOL6Bi54QUTRLbxIqDr)
        {
            n4.SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_TdLVO1y2oUCPAzqjOF3gNj != this.__p_TdLVO1y2oUCPAzqjOF3gNj || __p_DUisa9Zsn8NPsw0Jzz6DWX != this.__p_DUisa9Zsn8NPsw0Jzz6DWX || __p_DWX7mhdtaCVNw3tLjL28iR != this.__p_DWX7mhdtaCVNw3tLjL28iR || __p_AIHuOL6Bi54QUTRLbxIqDr != this.__p_AIHuOL6Bi54QUTRLbxIqDr ? new SplitChannels_Textures_LOI5hd0svvkP8BO1rUF0ci(this)
                {__p_TdLVO1y2oUCPAzqjOF3gNj = __p_TdLVO1y2oUCPAzqjOF3gNj, __p_DUisa9Zsn8NPsw0Jzz6DWX = __p_DUisa9Zsn8NPsw0Jzz6DWX, __p_DWX7mhdtaCVNw3tLjL28iR = __p_DWX7mhdtaCVNw3tLjL28iR, __p_AIHuOL6Bi54QUTRLbxIqDr = __p_AIHuOL6Bi54QUTRLbxIqDr} : that_0;
            else
            {
                this.__p_TdLVO1y2oUCPAzqjOF3gNj = __p_TdLVO1y2oUCPAzqjOF3gNj;
                this.__p_DUisa9Zsn8NPsw0Jzz6DWX = __p_DUisa9Zsn8NPsw0Jzz6DWX;
                this.__p_DWX7mhdtaCVNw3tLjL28iR = __p_DWX7mhdtaCVNw3tLjL28iR;
                this.__p_AIHuOL6Bi54QUTRLbxIqDr = __p_AIHuOL6Bi54QUTRLbxIqDr;
            }

            return that_0;
        }
    }
}

namespace _VL_Stride_Rendering_Temp_.Stride.Textures.Utils.JoinChannels_Textures.Internal
{
    [n1.ElementAttribute(TracingId = 198182U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", Name = "_Operations_")]
    public static partial class _Operations_
    {
        public static void CalcCommonSize(n10.Texture Channel_0_In, n10.Texture Channel_1_In, n10.Texture Channel_2_In, n10.Texture Channel_3_In, out n8.Int2 Output_Out)
        {
            n24._Operations_.ViewSize(Input_In: Channel_0_In, Output_Out: out n10.Texture Output_0, View_Size_Out: out n8.Int2 View_Size_1, View_Format_Out: out n19.PixelFormat View_Format_2, Exists_Out: out bool Exists_3);
            n24._Operations_.ViewSize(Input_In: Channel_1_In, Output_Out: out n10.Texture Output_4, View_Size_Out: out n8.Int2 View_Size_5, View_Format_Out: out n19.PixelFormat View_Format_6, Exists_Out: out bool Exists_7);
            n8.Int2.Max(left: ref View_Size_1, right: ref View_Size_5, result: out n8.Int2 Output_8);
            n24._Operations_.ViewSize(Input_In: Channel_2_In, Output_Out: out n10.Texture Output_9, View_Size_Out: out n8.Int2 View_Size_10, View_Format_Out: out n19.PixelFormat View_Format_11, Exists_Out: out bool Exists_12);
            n8.Int2.Max(left: ref Output_8, right: ref View_Size_10, result: out n8.Int2 Output_13);
            n24._Operations_.ViewSize(Input_In: Channel_3_In, Output_Out: out n10.Texture Output_14, View_Size_Out: out n8.Int2 View_Size_15, View_Format_Out: out n19.PixelFormat View_Format_16, Exists_Out: out bool Exists_17);
            n8.Int2.Max(left: ref Output_13, right: ref View_Size_15, result: out n8.Int2 Output_18);
            Output_Out = Output_18;
            return;
        }
    }
}

namespace _VL_Stride_Rendering_Temp_.Stride.Textures.Utils.SplitChannels_Textures
{
    [n1.ElementAttribute(TracingId = 199868U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "U2k1Xq4nBUjMGIeS79cY6r", Name = "ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r")]
    [n3.SerializableAttribute]
    public class ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r : n1.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n25.ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r Create(n1.NodeContext Node_Context)
        {
            var instance = new ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n25.ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r CreateDefault()
        {
            var instance = new ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n25.ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r Update(n10.Texture Input_In, [n5.SerializedDefaultValueAttribute("None", false)] n19.PixelFormat New_Format_In, out n10.Texture Output_Out, out n8.Int2 Size_Out, out n10.Texture Channel_0_Out, out n10.Texture Channel_1_Out, out n10.Texture Channel_2_Out, out n10.Texture Channel_3_Out, out bool Exists_Out)
        {
            n26._Operations_.Info(Input_In: Input_In, Output_Out: out n10.Texture Output_0, View_Size_Out: out n8.Int2 View_Size_1, View_Format_Out: out n19.PixelFormat View_Format_2, Resource_Size_Out: out n8.Int2 Resource_Size_3, Resource_Format_Out: out n19.PixelFormat Resource_Format_4, Exists_Out: out bool Exists_5);
            n10.Texture __auto_6;
            n10.Texture __auto_7;
            n10.Texture __auto_8;
            n10.Texture __auto_9;
            var state_10 = n1.CompilationHelper.Restore<__C7RpipQxzRGLdQ2hHVPiFK>(this.__if_I86UmO7K52tOIfwpF4j8F4, __GetContext__());
            if (Exists_5)
            {
                if (state_10 == null)
                {
                    state_10 = new __C7RpipQxzRGLdQ2hHVPiFK(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "FSjRuNY4nGQNGk6teY8au5", 199903U);
                    var Output_12 = n28.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy.Create(Node_Context: Node_Context_11);
                    state_10.__p_FSjRuNY4nGQNGk6teY8au5 = Output_12;
                    n1.NodeContext Node_Context_13 = __GetContext__().CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "OYphXoMH84FMSHU6bIN4Cb", 199925U);
                    var Output_14 = n28.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy.Create(Node_Context: Node_Context_13);
                    state_10.__p_OYphXoMH84FMSHU6bIN4Cb = Output_14;
                    n1.NodeContext Node_Context_15 = __GetContext__().CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "VxFqmuJLa5WLScIZUo8JGi", 199937U);
                    var Output_16 = n28.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy.Create(Node_Context: Node_Context_15);
                    state_10.__p_VxFqmuJLa5WLScIZUo8JGi = Output_16;
                    n1.NodeContext Node_Context_17 = __GetContext__().CreateSubContext("VCMcVJqu2AbNoidKDyIIxx", "P603nOUIDHHNKlziUhi6Vx", 199955U);
                    var Output_18 = n28.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy.Create(Node_Context: Node_Context_17);
                    state_10.__p_P603nOUIDHHNKlziUhi6Vx = Output_18;
                }

                n17._Operations_.ReplaceFormat(Input_In: View_Format_2, New_Format_In: New_Format_In, Output_Out: out n19.PixelFormat Output_19);
                n23.IGraphicsDataProvider[] Initial_Data_20 = n15._Operations_.CreateDefault<n23.IGraphicsDataProvider>();
                int Array_Size_21 = 1;
                int Mip_Levels_22 = 1;
                bool Is_Unordered_Access_23 = true;
                bool Is_Render_Target_24 = false;
                bool Is_Depth_Stencil_25 = false;
                bool Is_Shared_26 = false;
                bool Recreate_27 = false;
                var State_Output_30 = state_10.__p_FSjRuNY4nGQNGk6teY8au5.Update(Size_In: View_Size_1, Initial_Data_In: Initial_Data_20, Array_Size_In: Array_Size_21, Mip_Levels_In: Mip_Levels_22, Format_In: Output_19, Is_Unordered_Access_In: Is_Unordered_Access_23, Is_Render_Target_In: Is_Render_Target_24, Is_Depth_Stencil_In: Is_Depth_Stencil_25, Is_Shared_In: Is_Shared_26, Recreate_In: Recreate_27, Output_Out: out n10.Texture Output_28, Has_Changed_Out: out bool Has_Changed_29);
                n23.IGraphicsDataProvider[] Initial_Data_31 = n15._Operations_.CreateDefault<n23.IGraphicsDataProvider>();
                int Array_Size_32 = 1;
                int Mip_Levels_33 = 1;
                bool Is_Unordered_Access_34 = true;
                bool Is_Render_Target_35 = false;
                bool Is_Depth_Stencil_36 = false;
                bool Is_Shared_37 = false;
                bool Recreate_38 = false;
                var State_Output_41 = state_10.__p_OYphXoMH84FMSHU6bIN4Cb.Update(Size_In: View_Size_1, Initial_Data_In: Initial_Data_31, Array_Size_In: Array_Size_32, Mip_Levels_In: Mip_Levels_33, Format_In: Output_19, Is_Unordered_Access_In: Is_Unordered_Access_34, Is_Render_Target_In: Is_Render_Target_35, Is_Depth_Stencil_In: Is_Depth_Stencil_36, Is_Shared_In: Is_Shared_37, Recreate_In: Recreate_38, Output_Out: out n10.Texture Output_39, Has_Changed_Out: out bool Has_Changed_40);
                __auto_7 = Output_39;
                n23.IGraphicsDataProvider[] Initial_Data_42 = n15._Operations_.CreateDefault<n23.IGraphicsDataProvider>();
                int Array_Size_43 = 1;
                int Mip_Levels_44 = 1;
                bool Is_Unordered_Access_45 = true;
                bool Is_Render_Target_46 = false;
                bool Is_Depth_Stencil_47 = false;
                bool Is_Shared_48 = false;
                bool Recreate_49 = false;
                var State_Output_52 = state_10.__p_VxFqmuJLa5WLScIZUo8JGi.Update(Size_In: View_Size_1, Initial_Data_In: Initial_Data_42, Array_Size_In: Array_Size_43, Mip_Levels_In: Mip_Levels_44, Format_In: Output_19, Is_Unordered_Access_In: Is_Unordered_Access_45, Is_Render_Target_In: Is_Render_Target_46, Is_Depth_Stencil_In: Is_Depth_Stencil_47, Is_Shared_In: Is_Shared_48, Recreate_In: Recreate_49, Output_Out: out n10.Texture Output_50, Has_Changed_Out: out bool Has_Changed_51);
                __auto_8 = Output_50;
                n23.IGraphicsDataProvider[] Initial_Data_53 = n15._Operations_.CreateDefault<n23.IGraphicsDataProvider>();
                int Array_Size_54 = 1;
                int Mip_Levels_55 = 1;
                bool Is_Unordered_Access_56 = true;
                bool Is_Render_Target_57 = false;
                bool Is_Depth_Stencil_58 = false;
                bool Is_Shared_59 = false;
                bool Recreate_60 = false;
                var State_Output_63 = state_10.__p_P603nOUIDHHNKlziUhi6Vx.Update(Size_In: View_Size_1, Initial_Data_In: Initial_Data_53, Array_Size_In: Array_Size_54, Mip_Levels_In: Mip_Levels_55, Format_In: Output_19, Is_Unordered_Access_In: Is_Unordered_Access_56, Is_Render_Target_In: Is_Render_Target_57, Is_Depth_Stencil_In: Is_Depth_Stencil_58, Is_Shared_In: Is_Shared_59, Recreate_In: Recreate_60, Output_Out: out n10.Texture Output_61, Has_Changed_Out: out bool Has_Changed_62);
                __auto_9 = Output_61;
                __auto_6 = Output_28;
                if (state_10.__GetContext__().IsImmutable)
                    state_10 = State_Output_30 != state_10.__p_FSjRuNY4nGQNGk6teY8au5 || State_Output_41 != state_10.__p_OYphXoMH84FMSHU6bIN4Cb || State_Output_52 != state_10.__p_VxFqmuJLa5WLScIZUo8JGi || State_Output_63 != state_10.__p_P603nOUIDHHNKlziUhi6Vx ? new __C7RpipQxzRGLdQ2hHVPiFK(state_10)
                    {__p_FSjRuNY4nGQNGk6teY8au5 = State_Output_30, __p_OYphXoMH84FMSHU6bIN4Cb = State_Output_41, __p_VxFqmuJLa5WLScIZUo8JGi = State_Output_52, __p_P603nOUIDHHNKlziUhi6Vx = State_Output_63} : state_10;
                else
                {
                    state_10.__p_FSjRuNY4nGQNGk6teY8au5 = State_Output_30;
                    state_10.__p_OYphXoMH84FMSHU6bIN4Cb = State_Output_41;
                    state_10.__p_VxFqmuJLa5WLScIZUo8JGi = State_Output_52;
                    state_10.__p_P603nOUIDHHNKlziUhi6Vx = State_Output_63;
                }
            }
            else
            {
                __auto_6 = default(n10.Texture);
                __auto_7 = default(n10.Texture);
                __auto_8 = default(n10.Texture);
                __auto_9 = default(n10.Texture);
            }

            Output_Out = Output_0;
            Size_Out = View_Size_1;
            Channel_0_Out = __auto_6;
            Channel_1_Out = __auto_7;
            Channel_2_Out = __auto_8;
            Channel_3_Out = __auto_9;
            Exists_Out = Exists_5;
            n25.ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r that_64 = this;
            if (this.__GetContext__().IsImmutable)
                that_64 = state_10 != this.__if_I86UmO7K52tOIfwpF4j8F4 ? new ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r(this)
                {__if_I86UmO7K52tOIfwpF4j8F4 = state_10} : that_64;
            else
            {
                this.__if_I86UmO7K52tOIfwpF4j8F4 = state_10;
            }

            return that_64;
        }

        public n25.ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            n25.ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r that_0 = this;
            this.__if_I86UmO7K52tOIfwpF4j8F4 = default(n3.Object);
            return that_0;
        }

        public n25.ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r __CreateDefault__()
        {
            n25.ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r that_0 = this;
            this.__if_I86UmO7K52tOIfwpF4j8F4 = default(n3.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_I86UmO7K52tOIfwpF4j8F4);
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n3.Object __if_I86UmO7K52tOIfwpF4j8F4;
        public ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r(ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r other): base(other)
        {
            this.__if_I86UmO7K52tOIfwpF4j8F4 = other.__if_I86UmO7K52tOIfwpF4j8F4;
        }

        protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_I86UmO7K52tOIfwpF4j8F4", in __if_I86UmO7K52tOIfwpF4j8F4));
        }

        internal ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r __WITH__(n3.Object __if_I86UmO7K52tOIfwpF4j8F4)
        {
            n25.ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_I86UmO7K52tOIfwpF4j8F4 != this.__if_I86UmO7K52tOIfwpF4j8F4 ? new ChannelTexturesFromInput_U2k1Xq4nBUjMGIeS79cY6r(this)
                {__if_I86UmO7K52tOIfwpF4j8F4 = __if_I86UmO7K52tOIfwpF4j8F4} : that_0;
            else
            {
                this.__if_I86UmO7K52tOIfwpF4j8F4 = __if_I86UmO7K52tOIfwpF4j8F4;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "C7RpipQxzRGLdQ2hHVPiFK", Name = "__C7RpipQxzRGLdQ2hHVPiFK")]
        [n3.SerializableAttribute]
        public class __C7RpipQxzRGLdQ2hHVPiFK : n1.VLObject, n3.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_FSjRuNY4nGQNGk6teY8au5);
                n1.CompilationHelper.SafeDispose(this.__p_OYphXoMH84FMSHU6bIN4Cb);
                n1.CompilationHelper.SafeDispose(this.__p_VxFqmuJLa5WLScIZUo8JGi);
                n1.CompilationHelper.SafeDispose(this.__p_P603nOUIDHHNKlziUhi6Vx);
                return;
            }

            [n1.ElementAttribute(TracingId = 199903U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "FSjRuNY4nGQNGk6teY8au5", Name = "ComputeTexture2D", IsManaged = true, IsAutoGenerated = true)]
            public n28.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_FSjRuNY4nGQNGk6teY8au5;
            [n1.ElementAttribute(TracingId = 199925U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "OYphXoMH84FMSHU6bIN4Cb", Name = "ComputeTexture2D", IsManaged = true, IsAutoGenerated = true)]
            public n28.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_OYphXoMH84FMSHU6bIN4Cb;
            [n1.ElementAttribute(TracingId = 199937U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "VxFqmuJLa5WLScIZUo8JGi", Name = "ComputeTexture2D", IsManaged = true, IsAutoGenerated = true)]
            public n28.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_VxFqmuJLa5WLScIZUo8JGi;
            [n1.ElementAttribute(TracingId = 199955U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "P603nOUIDHHNKlziUhi6Vx", Name = "ComputeTexture2D", IsManaged = true, IsAutoGenerated = true)]
            public n28.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_P603nOUIDHHNKlziUhi6Vx;
            public __C7RpipQxzRGLdQ2hHVPiFK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __C7RpipQxzRGLdQ2hHVPiFK(__C7RpipQxzRGLdQ2hHVPiFK other): base(other)
            {
                this.__p_FSjRuNY4nGQNGk6teY8au5 = other.__p_FSjRuNY4nGQNGk6teY8au5;
                this.__p_OYphXoMH84FMSHU6bIN4Cb = other.__p_OYphXoMH84FMSHU6bIN4Cb;
                this.__p_VxFqmuJLa5WLScIZUo8JGi = other.__p_VxFqmuJLa5WLScIZUo8JGi;
                this.__p_P603nOUIDHHNKlziUhi6Vx = other.__p_P603nOUIDHHNKlziUhi6Vx;
            }

            protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FSjRuNY4nGQNGk6teY8au5", in __p_FSjRuNY4nGQNGk6teY8au5), n1.CompilationHelper.GetValueOrExisting(values, "__p_OYphXoMH84FMSHU6bIN4Cb", in __p_OYphXoMH84FMSHU6bIN4Cb), n1.CompilationHelper.GetValueOrExisting(values, "__p_VxFqmuJLa5WLScIZUo8JGi", in __p_VxFqmuJLa5WLScIZUo8JGi), n1.CompilationHelper.GetValueOrExisting(values, "__p_P603nOUIDHHNKlziUhi6Vx", in __p_P603nOUIDHHNKlziUhi6Vx));
            }

            internal __C7RpipQxzRGLdQ2hHVPiFK __WITH__(n28.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_FSjRuNY4nGQNGk6teY8au5, n28.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_OYphXoMH84FMSHU6bIN4Cb, n28.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_VxFqmuJLa5WLScIZUo8JGi, n28.ComputeTexture2D_Vao5mu9muXYOjpaceyFIMy __p_P603nOUIDHHNKlziUhi6Vx)
            {
                __C7RpipQxzRGLdQ2hHVPiFK that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_FSjRuNY4nGQNGk6teY8au5 != this.__p_FSjRuNY4nGQNGk6teY8au5 || __p_OYphXoMH84FMSHU6bIN4Cb != this.__p_OYphXoMH84FMSHU6bIN4Cb || __p_VxFqmuJLa5WLScIZUo8JGi != this.__p_VxFqmuJLa5WLScIZUo8JGi || __p_P603nOUIDHHNKlziUhi6Vx != this.__p_P603nOUIDHHNKlziUhi6Vx ? new __C7RpipQxzRGLdQ2hHVPiFK(this)
                    {__p_FSjRuNY4nGQNGk6teY8au5 = __p_FSjRuNY4nGQNGk6teY8au5, __p_OYphXoMH84FMSHU6bIN4Cb = __p_OYphXoMH84FMSHU6bIN4Cb, __p_VxFqmuJLa5WLScIZUo8JGi = __p_VxFqmuJLa5WLScIZUo8JGi, __p_P603nOUIDHHNKlziUhi6Vx = __p_P603nOUIDHHNKlziUhi6Vx} : that_0;
                else
                {
                    this.__p_FSjRuNY4nGQNGk6teY8au5 = __p_FSjRuNY4nGQNGk6teY8au5;
                    this.__p_OYphXoMH84FMSHU6bIN4Cb = __p_OYphXoMH84FMSHU6bIN4Cb;
                    this.__p_VxFqmuJLa5WLScIZUo8JGi = __p_VxFqmuJLa5WLScIZUo8JGi;
                    this.__p_P603nOUIDHHNKlziUhi6Vx = __p_P603nOUIDHHNKlziUhi6Vx;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Stride_Rendering_Temp_.Stride
{
    [n1.ElementAttribute(TracingId = 200315U, DocumentId = "VCMcVJqu2AbNoidKDyIIxx", PersistentId = "CT9MqmZSVJMQaus7z1oqZL", Name = "VL_Stride_Rendering_TempApplication_CT9MqmZSVJMQaus7z1oqZL")]
    [n3.SerializableAttribute]
    public class VL_Stride_Rendering_TempApplication_CT9MqmZSVJMQaus7z1oqZL : n1.VLObject, n3.IDisposable
    {
        [n5.CreateNewAttribute]
        public static n29.VL_Stride_Rendering_TempApplication_CT9MqmZSVJMQaus7z1oqZL Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_Stride_Rendering_TempApplication_CT9MqmZSVJMQaus7z1oqZL(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n5.CreateDefaultAttribute]
        public static n29.VL_Stride_Rendering_TempApplication_CT9MqmZSVJMQaus7z1oqZL CreateDefault()
        {
            var instance = new VL_Stride_Rendering_TempApplication_CT9MqmZSVJMQaus7z1oqZL(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n29.VL_Stride_Rendering_TempApplication_CT9MqmZSVJMQaus7z1oqZL Update()
        {
            return this;
        }

        public n29.VL_Stride_Rendering_TempApplication_CT9MqmZSVJMQaus7z1oqZL __Create__(n1.NodeContext Node_Context)
        {
            n14.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n29.VL_Stride_Rendering_TempApplication_CT9MqmZSVJMQaus7z1oqZL __CreateDefault__()
        {
            return this;
        }

        public void Dispose()
        {
            return;
        }

        void n3.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        public VL_Stride_Rendering_TempApplication_CT9MqmZSVJMQaus7z1oqZL(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_Stride_Rendering_TempApplication_CT9MqmZSVJMQaus7z1oqZL(VL_Stride_Rendering_TempApplication_CT9MqmZSVJMQaus7z1oqZL other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n18.IReadOnlyDictionary<string, n3.Object> values)
        {
            return __WITH__();
        }

        internal VL_Stride_Rendering_TempApplication_CT9MqmZSVJMQaus7z1oqZL __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Stride_Rendering_Temp_
{
    public struct __AdaptiveImplementations__VCMcVJqu2AbNoidKDyIIxx : n43.IAdaptiveSetGraphicsData<n8.Vector2[]>, n47.IAdaptiveAsReadOnlyMemory<n8.Vector2[], n8.Vector2>, n48.IAdaptiveMax<int>, n48.IAdaptiveOperatorGreater<int>, n48.IAdaptiveOne<int>, n48.IAdaptiveOne<n8.Vector2>, n48.IAdaptiveOperatorDivide<n8.Vector2>, n48.IAdaptiveOperatorMulitply_Scale<n8.Vector2>, n49.IAdaptiveCreateDefault<n8.Vector4>
    {
        public void SetGraphicsData(n23.MemoryDataProvider Input_In, n8.Vector2[] Data_In, int Offset_In_Bytes_In, int Size_In_Bytes_In, int Element_Size_In_Bytes_In, int Row_Size_In_Bytes_In, int Slice_Size_In_Bytes_In, out n23.MemoryDataProvider Output_Out)
        {
            n43._Operations_.SetGraphicsData<n8.Vector2[], n8.Vector2, n32.__AdaptiveImplementations__VCMcVJqu2AbNoidKDyIIxx>(Input_In: Input_In, Data_In: Data_In, Offset_In_Bytes_In: Offset_In_Bytes_In, Size_In_Bytes_In: Size_In_Bytes_In, Element_Size_In_Bytes_In: Element_Size_In_Bytes_In, Row_Size_In_Bytes_In: Row_Size_In_Bytes_In, Slice_Size_In_Bytes_In: Slice_Size_In_Bytes_In, Output_Out: out n23.MemoryDataProvider Output_0);
            Output_Out = Output_0;
            return;
        }

        public void AsReadOnlyMemory(n8.Vector2[] Input_In, out n3.ReadOnlyMemory<n8.Vector2> Result_Out)
        {
            var Result_0 = n44.MemoryUtils.AsReadOnlyMemory<n8.Vector2>(input: Input_In);
            Result_Out = Result_0;
            return;
        }

        public void Max(int Input_In, int Input_2_In, out int Output_Out)
        {
            n45._Operations_.Max<int, n32.__AdaptiveImplementations__VCMcVJqu2AbNoidKDyIIxx>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out int Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorGreater(int Input_In, int Input_2_In, out bool Result_Out)
        {
            var Result_0 = Input_In > Input_2_In;
            Result_Out = Result_0;
            return;
        }

        public void One(out int One_Out)
        {
            var One_0 = n33.Integer32Extensions.One;
            One_Out = One_0;
            return;
        }

        public void One(out n8.Vector2 One_Out)
        {
            var One_0 = n8.Vector2.One;
            One_Out = One_0;
            return;
        }

        public void OperatorDivide(n8.Vector2 Input_In, n8.Vector2 Input_2_In, out n8.Vector2 Output_Out)
        {
            var Output_0 = (n8.Vector2)Input_In / Input_2_In;
            Output_Out = Output_0;
            return;
        }

        public void OperatorMulitply_Scale(n8.Vector2 Input_In, float Scalar_In, out n8.Vector2 Output_Out)
        {
            n40.Vector2Nodes.Scale(input: ref Input_In, scalar: Scalar_In, output: out n8.Vector2 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void CreateDefault(out n8.Vector4 Output_Out)
        {
            var Unit_W_0 = n46._Operations_.CreateDefault();
            Output_Out = Unit_W_0;
            return;
        }
    }
}