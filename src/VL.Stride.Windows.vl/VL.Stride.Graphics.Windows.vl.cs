extern alias e22;
extern alias e42;
extern alias e31;
extern alias e26;
extern alias e3;
extern alias e2;
extern alias e29;
extern alias e4;

using n15 = _VL_Stride_Rendering_.Stride.Rendering;
using n14 = e26::Stride.Graphics;
using n24 = _CoreLibBasics_._3D.Matrix;
using n33 = _VL_Stride_Graphics_.Stride.Utils.Advanced;
using n37 = e2::VL.Lib.Collections;
using n7 = e3::VL.Lib.Primitive.CacheRegion;
using n44 = _CoreLibBasics_.Primitive.Object.Advanced;
using n48 = _VL_Collections_.Collections.Builder.SpreadBuilder.Advanced;
using n39 = _CoreLibBasics_.Control;
using n23 = _VL_Stride_Graphics_.Stride.Textures.Utils.Obsolete;
using n18 = _VL_CoreLib_Experimental_.Control.Try__1_Output.Obsolete.Experimental;
using n19 = global::System.IO.MemoryMappedFiles;
using n31 = _CoreLibBasics_.Primitive.IntPtr.Advanced;
using n38 = _VL_Stride_Graphics_Windows_;
using n52 = _CoreLibBasics_.Primitive.String;
using n17 = e3::VL.Lib.Control;
using n25 = _CoreLibBasics_._2D.Transform;
using n34 = e42::VL.Stride.Windows;
using n11 = global::System.Collections.Generic;
using n26 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.BlendStateDescription.Advanced;
using n55 = _CoreLibBasics_.Primitive.Advanced.Adaptive;
using n8 = _VL_Stride_Graphics_Windows_.Stride.Textures.Spout.SpoutSender_SharedTexture;
using n47 = global::System.Text;
using n50 = e3::VL.Lib.Primitive;
using n51 = e3::VL.Lib.Text;
using n43 = global::Microsoft.Win32;
using n29 = e3::VL.Lib.Mathematics;
using n46 = _CoreLibBasics_.Text.StringBuilder.Advanced;
using n42 = global::SharpDX.Direct3D11;
using n1 = e2::VL.Core;
using n32 = e31::VL.Stride.Rendering;
using n5 = e22::Stride.Graphics;
using n2 = global::System;
using n21 = e4::Stride.Core.Mathematics;
using n3 = _VL_Stride_Graphics_Windows_.Stride.Textures.Spout;
using n6 = e42::VL.Stride.Spout;
using n9 = e3::VL.Lib.Primitive.Object;
using n4 = e2::VL.Core.CompilerServices;
using n22 = _VL_Stride_Graphics_Windows_.Stride.Textures;
using n36 = _VL_Stride_Rendering_.Stride.Models.Meshes.Advanced;
using n16 = _VL_Collections_.Collections.Mutable.MutableArray.Advanced;
using n13 = _VL_Stride_Rendering_.Stride.Textures;
using n28 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.DepthStencilStateDescription.Advanced;
using n35 = _VL_Stride_Engine_.Stride;
using n27 = _VL_Stride_Runtime_TypeForwards_.Stride.API.Graphics.RasterizerStateDescription.Advanced;
using n49 = _VL_Stride_Graphics_Windows_.Stride;
using n30 = e29::Stride.Rendering;
using n53 = _VL_Collections_.Collections.Sequence;
using n10 = global::System.Runtime.CompilerServices;
using n12 = _VL_Stride_Graphics_.Stride.Textures.Utils;
using n41 = _VL_Stride_Graphics_Windows_.Stride.Graphics.Texture.Advanced;
using n40 = _VL_Collections_.Collections.Spread;
using n45 = _VL_CoreLib_Experimental_.Control.Experimental;
using n54 = _CoreLibBasics_.Primitive.Advanced;
using n20 = global::System.IO;

namespace _VL_Stride_Graphics_Windows_.Stride.Textures.Spout
{
    [n1.ElementAttribute(TracingId = 1775U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "L7TotBk1tgjMgvGlVThbN8", Name = "SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8")]
    [n2.SerializableAttribute]
    public class SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 Create(n1.NodeContext Node_Context)
        {
            var instance = new SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 CreateDefault()
        {
            var instance = new SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 Update(n5.Texture Shared_Texture_In, [n4.SerializedDefaultValueAttribute("vvvv", false)] string Sender_Name_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Set_As_Active_Sender_In, bool Reset_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out bool Success_Out)
        {
            bool __pad_D1VsYudIm5TNWorXx1kfCw_0 = __slot_D1VsYudIm5TNWorXx1kfCw;
            var manager_1 = this.__cache_MDBg3O7McKeONdgF365zAD;
            if (manager_1 is null)
            {
                manager_1 = new n7.Manager<n2.ValueTuple<string, n5.Texture, bool>, n2.ValueTuple<n6.SpoutSender>>(n2.ValueTuple.Create(default(n6.SpoutSender)));
            }

            var inputs_2 = (Sender_Name_In, Shared_Texture_In, Enabled_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Reset_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (__pad_D1VsYudIm5TNWorXx1kfCw_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__UxIyXbJZjfTMNNSOUgU9Wa>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __UxIyXbJZjfTMNNSOUgU9Wa(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "S9KvGiI7dSVPP47A7Ifq4D", 1821U);
                    var Output_7 = n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8.Create(Node_Context: Node_Context_6);
                    state_5.__p_S9KvGiI7dSVPP47A7Ifq4D = Output_7;
                }

                n9.ObjectHelpers.IsAssigned(x: Shared_Texture_In, result: out bool Result_8, notAssigned: out bool Not_Assigned_9);
                var Result_10 = string.IsNullOrWhiteSpace(value: Sender_Name_In);
                var Output_11 = !Result_10;
                var Output_12 = Result_8 && Output_11;
                var Output_13 = Output_12 && Enabled_In;
                n6.SpoutSender __auto_14;
                if (Output_13)
                {
                    var Output_16 = new n6.SpoutSender(senderName: Sender_Name_In, srcTexture: Shared_Texture_In);
                    Output_16.Initialize();
                    __auto_14 = Output_16;
                }
                else
                {
                    __auto_14 = default(n6.SpoutSender);
                }

                var Output_17 = !Enabled_In;
                var Output_18 = state_5.__p_S9KvGiI7dSVPP47A7Ifq4D;
                if (Output_17)
                {
                    Output_18 = state_5.__p_S9KvGiI7dSVPP47A7Ifq4D.Update(Sender_Name_In: Sender_Name_In);
                }

                if (state_5.__GetContext__().IsImmutable)
                    state_5 = Output_18 != state_5.__p_S9KvGiI7dSVPP47A7Ifq4D ? new __UxIyXbJZjfTMNNSOUgU9Wa(state_5)
                    {__p_S9KvGiI7dSVPP47A7Ifq4D = Output_18} : state_5;
                else
                {
                    state_5.__p_S9KvGiI7dSVPP47A7Ifq4D = Output_18;
                }

                outputs_3 = n2.ValueTuple.Create(__auto_14);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, __pad_D1VsYudIm5TNWorXx1kfCw_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, __pad_D1VsYudIm5TNWorXx1kfCw_0);
            }

            var __auto_19 = outputs_3.Item1;
            n9.ObjectHelpers.IsAssigned(x: __auto_19, result: out bool Result_20, notAssigned: out bool Not_Assigned_21);
            var Output_22 = Result_20 && Enabled_In;
            var Output_23 = Output_22 && Set_As_Active_Sender_In;
            bool Update_24 = true;
            var Output_25 = this.__p_DSzVQgpO7wULGUjXrQszdN;
            if (Update_24)
            {
                Output_25 = this.__p_DSzVQgpO7wULGUjXrQszdN.Update(Sender_Name_In: Sender_Name_In, Set_In: Output_23);
            }

            string __pad_VwRDCKbB4c2Lk1pKthVCiB_26 = Sender_Name_In;
            Success_Out = Result_20;
            n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 that_27 = this;
            if (this.__GetContext__().IsImmutable)
                that_27 = manager_1 != this.__cache_MDBg3O7McKeONdgF365zAD || Output_25 != this.__p_DSzVQgpO7wULGUjXrQszdN || Sender_Name_In != this.__slot_VwRDCKbB4c2Lk1pKthVCiB ? new SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8(this)
                {__cache_MDBg3O7McKeONdgF365zAD = manager_1, __p_DSzVQgpO7wULGUjXrQszdN = Output_25, __slot_VwRDCKbB4c2Lk1pKthVCiB = Sender_Name_In} : that_27;
            else
            {
                this.__cache_MDBg3O7McKeONdgF365zAD = manager_1;
                this.__p_DSzVQgpO7wULGUjXrQszdN = Output_25;
                this.__slot_VwRDCKbB4c2Lk1pKthVCiB = Sender_Name_In;
            }

            return that_27;
        }

        public n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "E8aodbFOP67NZyxO84Knij", 1870U);
            var Output_1 = n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "DSzVQgpO7wULGUjXrQszdN", 1874U);
            var Output_3 = n3.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk.Create(Node_Context: Node_Context_2);
            n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 that_4 = this;
            this.__slot_VwRDCKbB4c2Lk1pKthVCiB = "";
            this.__p_E8aodbFOP67NZyxO84Knij = Output_1;
            this.__p_DSzVQgpO7wULGUjXrQszdN = Output_3;
            this.__cache_MDBg3O7McKeONdgF365zAD = null;
            return that_4;
        }

        public n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 Dispose_()
        {
            string __pad_VwRDCKbB4c2Lk1pKthVCiB_0 = this.__slot_VwRDCKbB4c2Lk1pKthVCiB;
            bool Update_1 = true;
            var Output_2 = this.__p_E8aodbFOP67NZyxO84Knij;
            if (Update_1)
            {
                Output_2 = this.__p_E8aodbFOP67NZyxO84Knij.Update(Sender_Name_In: __pad_VwRDCKbB4c2Lk1pKthVCiB_0);
            }

            n1.CompilationHelper.SafeDispose(this.__cache_MDBg3O7McKeONdgF365zAD);
            n1.CompilationHelper.SafeDispose(this.__p_DSzVQgpO7wULGUjXrQszdN);
            n1.CompilationHelper.SafeDispose(Output_2);
            n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 that_3 = this;
            if (this.__GetContext__().IsImmutable)
                that_3 = Output_2 != this.__p_E8aodbFOP67NZyxO84Knij ? new SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8(this)
                {__p_E8aodbFOP67NZyxO84Knij = Output_2} : that_3;
            else
            {
                this.__p_E8aodbFOP67NZyxO84Knij = Output_2;
            }

            return that_3;
        }

        public n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 __CreateDefault__()
        {
            n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 that_0 = this;
            this.__slot_VwRDCKbB4c2Lk1pKthVCiB = "";
            this.__cache_MDBg3O7McKeONdgF365zAD = null;
            this.__p_DSzVQgpO7wULGUjXrQszdN = n3.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk.CreateDefault();
            this.__p_E8aodbFOP67NZyxO84Knij = n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8.CreateDefault();
            return that_0;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            var __returnValue__ = Dispose_();
        }

        [n1.ElementAttribute(TracingId = 1825U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "D1VsYudIm5TNWorXx1kfCw", Name = "__slot_D1VsYudIm5TNWorXx1kfCw")]
        public static bool __slot_D1VsYudIm5TNWorXx1kfCw = true;
        [n1.ElementAttribute(TracingId = 1872U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "VwRDCKbB4c2Lk1pKthVCiB", Name = "__slot_VwRDCKbB4c2Lk1pKthVCiB")]
        public string __slot_VwRDCKbB4c2Lk1pKthVCiB;
        [n1.ElementAttribute(TracingId = 1778U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "MDBg3O7McKeONdgF365zAD", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<string, n5.Texture, bool>, n2.ValueTuple<n6.SpoutSender>> __cache_MDBg3O7McKeONdgF365zAD = null;
        [n1.ElementAttribute(TracingId = 1874U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "DSzVQgpO7wULGUjXrQszdN", Name = "SetActiveSender", IsManaged = true, IsAutoGenerated = true)]
        public n3.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk __p_DSzVQgpO7wULGUjXrQszdN;
        [n1.ElementAttribute(TracingId = 1870U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "E8aodbFOP67NZyxO84Knij", Name = "ActiveSenderClearer", IsManaged = true, IsAutoGenerated = true)]
        public n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 __p_E8aodbFOP67NZyxO84Knij;
        static SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8()
        {
        }

        public SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8(SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 other): base(other)
        {
            this.__slot_VwRDCKbB4c2Lk1pKthVCiB = other.__slot_VwRDCKbB4c2Lk1pKthVCiB;
            this.__cache_MDBg3O7McKeONdgF365zAD = other.__cache_MDBg3O7McKeONdgF365zAD;
            this.__p_DSzVQgpO7wULGUjXrQszdN = other.__p_DSzVQgpO7wULGUjXrQszdN;
            this.__p_E8aodbFOP67NZyxO84Knij = other.__p_E8aodbFOP67NZyxO84Knij;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_VwRDCKbB4c2Lk1pKthVCiB", in __slot_VwRDCKbB4c2Lk1pKthVCiB), n1.CompilationHelper.GetValueOrExisting(values, "__cache_MDBg3O7McKeONdgF365zAD", in __cache_MDBg3O7McKeONdgF365zAD), n1.CompilationHelper.GetValueOrExisting(values, "__p_DSzVQgpO7wULGUjXrQszdN", in __p_DSzVQgpO7wULGUjXrQszdN), n1.CompilationHelper.GetValueOrExisting(values, "__p_E8aodbFOP67NZyxO84Knij", in __p_E8aodbFOP67NZyxO84Knij));
        }

        internal SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 __WITH__(string __slot_VwRDCKbB4c2Lk1pKthVCiB, n7.Manager<n2.ValueTuple<string, n5.Texture, bool>, n2.ValueTuple<n6.SpoutSender>> __cache_MDBg3O7McKeONdgF365zAD, n3.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk __p_DSzVQgpO7wULGUjXrQszdN, n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 __p_E8aodbFOP67NZyxO84Knij)
        {
            n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 that_1 = this;
            if (this.__GetContext__().IsImmutable)
                that_1 = __slot_VwRDCKbB4c2Lk1pKthVCiB != this.__slot_VwRDCKbB4c2Lk1pKthVCiB || __cache_MDBg3O7McKeONdgF365zAD != this.__cache_MDBg3O7McKeONdgF365zAD || __p_DSzVQgpO7wULGUjXrQszdN != this.__p_DSzVQgpO7wULGUjXrQszdN || __p_E8aodbFOP67NZyxO84Knij != this.__p_E8aodbFOP67NZyxO84Knij ? new SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8(this)
                {__slot_VwRDCKbB4c2Lk1pKthVCiB = __slot_VwRDCKbB4c2Lk1pKthVCiB, __cache_MDBg3O7McKeONdgF365zAD = __cache_MDBg3O7McKeONdgF365zAD, __p_DSzVQgpO7wULGUjXrQszdN = __p_DSzVQgpO7wULGUjXrQszdN, __p_E8aodbFOP67NZyxO84Knij = __p_E8aodbFOP67NZyxO84Knij} : that_1;
            else
            {
                this.__slot_VwRDCKbB4c2Lk1pKthVCiB = __slot_VwRDCKbB4c2Lk1pKthVCiB;
                this.__cache_MDBg3O7McKeONdgF365zAD = __cache_MDBg3O7McKeONdgF365zAD;
                this.__p_DSzVQgpO7wULGUjXrQszdN = __p_DSzVQgpO7wULGUjXrQszdN;
                this.__p_E8aodbFOP67NZyxO84Knij = __p_E8aodbFOP67NZyxO84Knij;
            }

            return that_1;
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "UxIyXbJZjfTMNNSOUgU9Wa", Name = "__UxIyXbJZjfTMNNSOUgU9Wa")]
        [n2.SerializableAttribute]
        public class __UxIyXbJZjfTMNNSOUgU9Wa : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_S9KvGiI7dSVPP47A7Ifq4D);
                return;
            }

            [n1.ElementAttribute(TracingId = 1821U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "S9KvGiI7dSVPP47A7Ifq4D", Name = "ActiveSenderClearer", IsManaged = true, IsAutoGenerated = true)]
            public n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 __p_S9KvGiI7dSVPP47A7Ifq4D;
            public __UxIyXbJZjfTMNNSOUgU9Wa(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __UxIyXbJZjfTMNNSOUgU9Wa(__UxIyXbJZjfTMNNSOUgU9Wa other): base(other)
            {
                this.__p_S9KvGiI7dSVPP47A7Ifq4D = other.__p_S9KvGiI7dSVPP47A7Ifq4D;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_S9KvGiI7dSVPP47A7Ifq4D", in __p_S9KvGiI7dSVPP47A7Ifq4D));
            }

            internal __UxIyXbJZjfTMNNSOUgU9Wa __WITH__(n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 __p_S9KvGiI7dSVPP47A7Ifq4D)
            {
                __UxIyXbJZjfTMNNSOUgU9Wa that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_S9KvGiI7dSVPP47A7Ifq4D != this.__p_S9KvGiI7dSVPP47A7Ifq4D ? new __UxIyXbJZjfTMNNSOUgU9Wa(this)
                    {__p_S9KvGiI7dSVPP47A7Ifq4D = __p_S9KvGiI7dSVPP47A7Ifq4D} : that_0;
                else
                {
                    this.__p_S9KvGiI7dSVPP47A7Ifq4D = __p_S9KvGiI7dSVPP47A7Ifq4D;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 1927U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "GyYmjQ1jJAzLvYrhfgN7iZ", Name = "SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ")]
    [n2.SerializableAttribute]
    public class SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ Create(n1.NodeContext Node_Context)
        {
            var instance = new SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ CreateDefault()
        {
            var instance = new SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ Update(n5.Texture Source_In, [n4.SerializedDefaultValueAttribute("vvvv", false)] string Sender_Name_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Set_As_Active_Sender_In, bool Reset_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Enabled_In, out bool Success_Out)
        {
            n12._Operations_.IsShared(Input_In: Source_In, Output_Out: out n5.Texture Output_0, Is_Shared_Out: out bool Is_Shared_1, Shared_Handle_Out: out n2.IntPtr Shared_Handle_2, Exists_Out: out bool Exists_3);
            var Output_4 = !Is_Shared_1;
            n5.Texture __auto_5;
            var state_6 = n1.CompilationHelper.Restore<__QBjEXgem1IaMqi64Sk2MWN>(this.__if_GyAYVw4VN5xNGZIFcfV6q3, __GetContext__());
            if (Output_4)
            {
                if (state_6 == null)
                {
                    state_6 = new __QBjEXgem1IaMqi64Sk2MWN(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "D7OoF3cLwC8NK4ehQr2F4p", 1945U);
                    var Output_8 = n13.CopyTexture_UGdw4Tvemx5QK60AS7AHcT.Create(Node_Context: Node_Context_7);
                    state_6.__p_D7OoF3cLwC8NK4ehQr2F4p = Output_8;
                }

                bool __pad_UmaYIXQoun2LfbtbCuwaYS_9 = __slot_UmaYIXQoun2LfbtbCuwaYS;
                bool Copy_Content_On_Clone_10 = false;
                n14.PixelFormat Format_11 = default(n14.PixelFormat);
                n5.TextureFlags Flags_12 = default(n5.TextureFlags);
                bool Dispose_Cached_Texture_13 = true;
                bool Auto_Render_14 = true;
                var State_Output_17 = state_6.__p_D7OoF3cLwC8NK4ehQr2F4p.Update(Input_In: Output_0, Copy_Content_On_Clone_In: Copy_Content_On_Clone_10, Format_In: Format_11, Flags_In: Flags_12, Dispose_Cached_Texture_In: Dispose_Cached_Texture_13, To_Shared_Texture_In: __pad_UmaYIXQoun2LfbtbCuwaYS_9, Auto_Render_In: Auto_Render_14, Renderer_Out: out n15.CopyTextureRenderer_C Renderer_15, Output_Out: out n5.Texture Output_16);
                __auto_5 = Output_16;
                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_17 != state_6.__p_D7OoF3cLwC8NK4ehQr2F4p ? new __QBjEXgem1IaMqi64Sk2MWN(state_6)
                    {__p_D7OoF3cLwC8NK4ehQr2F4p = State_Output_17} : state_6;
                else
                {
                    state_6.__p_D7OoF3cLwC8NK4ehQr2F4p = State_Output_17;
                }
            }
            else
            {
                __auto_5 = Output_0;
            }

            var Output_19 = this.__p_EVsON1KMx8eOmd43keXy0t.Update(Shared_Texture_In: __auto_5, Sender_Name_In: Sender_Name_In, Set_As_Active_Sender_In: Set_As_Active_Sender_In, Reset_In: Reset_In, Enabled_In: Enabled_In, Success_Out: out bool Success_18);
            Success_Out = Success_18;
            n3.SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ that_20 = this;
            if (this.__GetContext__().IsImmutable)
                that_20 = state_6 != this.__if_GyAYVw4VN5xNGZIFcfV6q3 || Output_19 != this.__p_EVsON1KMx8eOmd43keXy0t ? new SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ(this)
                {__if_GyAYVw4VN5xNGZIFcfV6q3 = state_6, __p_EVsON1KMx8eOmd43keXy0t = Output_19} : that_20;
            else
            {
                this.__if_GyAYVw4VN5xNGZIFcfV6q3 = state_6;
                this.__p_EVsON1KMx8eOmd43keXy0t = Output_19;
            }

            return that_20;
        }

        public n3.SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "EVsON1KMx8eOmd43keXy0t", 1930U);
            var Output_1 = n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8.Create(Node_Context: Node_Context_0);
            n3.SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ that_2 = this;
            this.__p_EVsON1KMx8eOmd43keXy0t = Output_1;
            this.__if_GyAYVw4VN5xNGZIFcfV6q3 = default(n2.Object);
            return that_2;
        }

        public n3.SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ __CreateDefault__()
        {
            n3.SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ that_0 = this;
            this.__if_GyAYVw4VN5xNGZIFcfV6q3 = default(n2.Object);
            this.__p_EVsON1KMx8eOmd43keXy0t = n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_GyAYVw4VN5xNGZIFcfV6q3);
            n1.CompilationHelper.SafeDispose(this.__p_EVsON1KMx8eOmd43keXy0t);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 1950U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "UmaYIXQoun2LfbtbCuwaYS", Name = "__slot_UmaYIXQoun2LfbtbCuwaYS")]
        public static bool __slot_UmaYIXQoun2LfbtbCuwaYS = true;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_GyAYVw4VN5xNGZIFcfV6q3;
        [n1.ElementAttribute(TracingId = 1930U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "EVsON1KMx8eOmd43keXy0t", Name = "SpoutSender (SharedTexture)", IsManaged = true, IsAutoGenerated = true)]
        public n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 __p_EVsON1KMx8eOmd43keXy0t;
        static SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ()
        {
        }

        public SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ(SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ other): base(other)
        {
            this.__if_GyAYVw4VN5xNGZIFcfV6q3 = other.__if_GyAYVw4VN5xNGZIFcfV6q3;
            this.__p_EVsON1KMx8eOmd43keXy0t = other.__p_EVsON1KMx8eOmd43keXy0t;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_GyAYVw4VN5xNGZIFcfV6q3", in __if_GyAYVw4VN5xNGZIFcfV6q3), n1.CompilationHelper.GetValueOrExisting(values, "__p_EVsON1KMx8eOmd43keXy0t", in __p_EVsON1KMx8eOmd43keXy0t));
        }

        internal SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ __WITH__(n2.Object __if_GyAYVw4VN5xNGZIFcfV6q3, n3.SpoutSender_SharedTexture_L7TotBk1tgjMgvGlVThbN8 __p_EVsON1KMx8eOmd43keXy0t)
        {
            n3.SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __if_GyAYVw4VN5xNGZIFcfV6q3 != this.__if_GyAYVw4VN5xNGZIFcfV6q3 || __p_EVsON1KMx8eOmd43keXy0t != this.__p_EVsON1KMx8eOmd43keXy0t ? new SpoutSender_GyYmjQ1jJAzLvYrhfgN7iZ(this)
                {__if_GyAYVw4VN5xNGZIFcfV6q3 = __if_GyAYVw4VN5xNGZIFcfV6q3, __p_EVsON1KMx8eOmd43keXy0t = __p_EVsON1KMx8eOmd43keXy0t} : that_0;
            else
            {
                this.__if_GyAYVw4VN5xNGZIFcfV6q3 = __if_GyAYVw4VN5xNGZIFcfV6q3;
                this.__p_EVsON1KMx8eOmd43keXy0t = __p_EVsON1KMx8eOmd43keXy0t;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "QBjEXgem1IaMqi64Sk2MWN", Name = "__QBjEXgem1IaMqi64Sk2MWN")]
        [n2.SerializableAttribute]
        public class __QBjEXgem1IaMqi64Sk2MWN : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_D7OoF3cLwC8NK4ehQr2F4p);
                return;
            }

            [n1.ElementAttribute(TracingId = 1945U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "D7OoF3cLwC8NK4ehQr2F4p", Name = "CopyTexture", IsManaged = true, IsAutoGenerated = true)]
            public n13.CopyTexture_UGdw4Tvemx5QK60AS7AHcT __p_D7OoF3cLwC8NK4ehQr2F4p;
            public __QBjEXgem1IaMqi64Sk2MWN(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __QBjEXgem1IaMqi64Sk2MWN(__QBjEXgem1IaMqi64Sk2MWN other): base(other)
            {
                this.__p_D7OoF3cLwC8NK4ehQr2F4p = other.__p_D7OoF3cLwC8NK4ehQr2F4p;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_D7OoF3cLwC8NK4ehQr2F4p", in __p_D7OoF3cLwC8NK4ehQr2F4p));
            }

            internal __QBjEXgem1IaMqi64Sk2MWN __WITH__(n13.CopyTexture_UGdw4Tvemx5QK60AS7AHcT __p_D7OoF3cLwC8NK4ehQr2F4p)
            {
                __QBjEXgem1IaMqi64Sk2MWN that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_D7OoF3cLwC8NK4ehQr2F4p != this.__p_D7OoF3cLwC8NK4ehQr2F4p ? new __QBjEXgem1IaMqi64Sk2MWN(this)
                    {__p_D7OoF3cLwC8NK4ehQr2F4p = __p_D7OoF3cLwC8NK4ehQr2F4p} : that_0;
                else
                {
                    this.__p_D7OoF3cLwC8NK4ehQr2F4p = __p_D7OoF3cLwC8NK4ehQr2F4p;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 1981U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "PO0iXa0KkRwLo98DekIq4O", Name = "ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O")]
    [n2.SerializableAttribute]
    public class ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O Create(n1.NodeContext Node_Context)
        {
            var instance = new ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O CreateDefault()
        {
            var instance = new ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O Update(bool Read_In, [n4.SerializedDefaultValueAttribute("", false)] string Name_In, [n4.SerializedDefaultValueAttribute("1024", false)] int Length_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Flush_In, out byte[] Bytes_Out, out bool Success_Out, out string Error_Out)
        {
            bool __pad_FhpjiVO1E8YL7cvKK1EfUR_0 = __slot_FhpjiVO1E8YL7cvKK1EfUR;
            n1.NodeContext Node_Context_1 = __GetContext__().CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "EnMz10HYNErQU6Kq2RpY6z", 1984U);
            n16._Operations_.Create<byte>(Node_Context: Node_Context_1, Length_In: Length_In, Result_Out: out byte[] Result_2);
            byte[] __auto_3 = Result_2;
            bool __pad_Vo6qvdqEAj0OjSxMizpJhM_4 = Flush_In;
            byte[] Bytes_5;
            bool Success_6;
            string __auto_7;
            var state_8 = n1.CompilationHelper.Restore<__BaTcZ8yj7v2QPjM24J0S6L>(this.__if_VRbs47YGeHrOFW9CYefFui, __GetContext__());
            if (Read_In)
            {
                if (state_8 == null)
                {
                    state_8 = new __BaTcZ8yj7v2QPjM24J0S6L(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_9 = __GetContext__().CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "SSRuxO6g6eAQbOIF8niW6j", 2005U);
                    n18._Operations_.Create_H<n2.Object>(Node_Context: Node_Context_9, Output_Out: out n17.TryStateful<n2.Object> Output_10);
                    state_8.__p_SSRuxO6g6eAQbOIF8niW6j = Output_10;
                }

                bool Re_Initialize_11 = false;
                var __fallback___12 = n1.ServiceRegistry.Current;
                n18._Operations_.Update_H<n2.Object, byte[]>(Input_In: state_8.__p_SSRuxO6g6eAQbOIF8niW6j, Default_Output_In: __auto_3, Re_Initialize_In: Re_Initialize_11, Try_In: (n2.Object s_15) =>
                {
                    using var __current_13 = __fallback___12.MakeCurrentIfNone();
                    var state_14 = n1.CompilationHelper.Restore<__LYthg5XoFGoP3myYGt8l7m>(s_15, __GetContext__());
                    var Result_16 = n19.MemoryMappedFile.OpenExisting(mapName: Name_In);
                    var Result_17 = Result_16.CreateViewStream();
                    var Output_18 = Result_17;
                    if (__pad_Vo6qvdqEAj0OjSxMizpJhM_4)
                    {
                        Result_17.Flush();
                    }

                    var Output_19 = n20.Stream.Synchronized(stream: Output_18);
                    int Offset_20 = 0;
                    var Result_21 = Output_19.Read(buffer: __auto_3, offset: Offset_20, count: Length_In);
                    int __pad_EAViC60i0hKNdSHXaB4SFV_22 = Result_21;
                    if (state_14.__GetContext__().IsImmutable)
                        state_14 = Result_21 != state_14.__slot_EAViC60i0hKNdSHXaB4SFV ? new __LYthg5XoFGoP3myYGt8l7m(state_14)
                        {__slot_EAViC60i0hKNdSHXaB4SFV = Result_21} : state_14;
                    else
                    {
                        state_14.__slot_EAViC60i0hKNdSHXaB4SFV = Result_21;
                    }

                    return n2.Tuple.Create<n2.Object, byte[]>(state_14, Result_2);
                }

                , Create_In: () =>
                {
                    using var __current_23 = __fallback___12.MakeCurrentIfNone();
                    var state_14 = new __LYthg5XoFGoP3myYGt8l7m(__GetContext__(), n1.VLObject.NewIdentity());
                    return state_14;
                }

                , Output_Out: out n17.TryStateful<n2.Object> Output_24, Result_Out: out byte[] Result_25, Success_Out: out bool Success_26, Error_Message_Out: out string Error_Message_27);
                Bytes_5 = Result_25;
                Success_6 = Success_26;
                __auto_7 = Error_Message_27;
                if (state_8.__GetContext__().IsImmutable)
                    state_8 = Output_24 != state_8.__p_SSRuxO6g6eAQbOIF8niW6j ? new __BaTcZ8yj7v2QPjM24J0S6L(state_8)
                    {__p_SSRuxO6g6eAQbOIF8niW6j = Output_24} : state_8;
                else
                {
                    state_8.__p_SSRuxO6g6eAQbOIF8niW6j = Output_24;
                }
            }
            else
            {
                Bytes_5 = __auto_3;
                Success_6 = __pad_FhpjiVO1E8YL7cvKK1EfUR_0;
                __auto_7 = "";
            }

            bool __pad_Rc2Yws1M194PTIUBfj7zkF_28 = Success_6;
            string __pad_LhxLkevjjEyMKiJ0ElJKod_29 = __auto_7;
            Bytes_Out = Bytes_5;
            Success_Out = __pad_Rc2Yws1M194PTIUBfj7zkF_28;
            Error_Out = __pad_LhxLkevjjEyMKiJ0ElJKod_29;
            n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O that_30 = this;
            if (this.__GetContext__().IsImmutable)
                that_30 = Result_2 != this.Result || Flush_In != this.__slot_Vo6qvdqEAj0OjSxMizpJhM || state_8 != this.__if_VRbs47YGeHrOFW9CYefFui || Success_6 != this.__slot_Rc2Yws1M194PTIUBfj7zkF || __auto_7 != this.__slot_LhxLkevjjEyMKiJ0ElJKod ? new ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O(this)
                {Result = Result_2, __slot_Vo6qvdqEAj0OjSxMizpJhM = Flush_In, __if_VRbs47YGeHrOFW9CYefFui = state_8, __slot_Rc2Yws1M194PTIUBfj7zkF = Success_6, __slot_LhxLkevjjEyMKiJ0ElJKod = __auto_7} : that_30;
            else
            {
                this.Result = Result_2;
                this.__slot_Vo6qvdqEAj0OjSxMizpJhM = Flush_In;
                this.__if_VRbs47YGeHrOFW9CYefFui = state_8;
                this.__slot_Rc2Yws1M194PTIUBfj7zkF = Success_6;
                this.__slot_LhxLkevjjEyMKiJ0ElJKod = __auto_7;
            }

            return that_30;
        }

        public n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O that_0 = this;
            this.__slot_Vo6qvdqEAj0OjSxMizpJhM = false;
            this.__slot_Rc2Yws1M194PTIUBfj7zkF = false;
            this.__slot_LhxLkevjjEyMKiJ0ElJKod = "";
            this.Result = n16._Operations_.CreateDefault<byte>();
            this.__if_VRbs47YGeHrOFW9CYefFui = default(n2.Object);
            return that_0;
        }

        public n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O __CreateDefault__()
        {
            n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O that_0 = this;
            this.__slot_Vo6qvdqEAj0OjSxMizpJhM = false;
            this.__slot_Rc2Yws1M194PTIUBfj7zkF = false;
            this.__slot_LhxLkevjjEyMKiJ0ElJKod = "";
            this.Result = n16._Operations_.CreateDefault<byte>();
            this.__if_VRbs47YGeHrOFW9CYefFui = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_VRbs47YGeHrOFW9CYefFui);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 1990U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "Vo6qvdqEAj0OjSxMizpJhM", Name = "__slot_Vo6qvdqEAj0OjSxMizpJhM")]
        public bool __slot_Vo6qvdqEAj0OjSxMizpJhM;
        [n1.ElementAttribute(TracingId = 1992U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "Rc2Yws1M194PTIUBfj7zkF", Name = "__slot_Rc2Yws1M194PTIUBfj7zkF")]
        public bool __slot_Rc2Yws1M194PTIUBfj7zkF;
        [n1.ElementAttribute(TracingId = 1994U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "LhxLkevjjEyMKiJ0ElJKod", Name = "__slot_LhxLkevjjEyMKiJ0ElJKod")]
        public string __slot_LhxLkevjjEyMKiJ0ElJKod;
        [n1.ElementAttribute(TracingId = 2044U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "FhpjiVO1E8YL7cvKK1EfUR", Name = "__slot_FhpjiVO1E8YL7cvKK1EfUR")]
        public static bool __slot_FhpjiVO1E8YL7cvKK1EfUR = false;
        [n1.ElementAttribute(TracingId = 2042U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "E034k0iJJ48OfLPZdXj2EW", Name = "Result")]
        public byte[] Result;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_VRbs47YGeHrOFW9CYefFui;
        static ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O()
        {
        }

        public ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O(ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O other): base(other)
        {
            this.__slot_Vo6qvdqEAj0OjSxMizpJhM = other.__slot_Vo6qvdqEAj0OjSxMizpJhM;
            this.__slot_Rc2Yws1M194PTIUBfj7zkF = other.__slot_Rc2Yws1M194PTIUBfj7zkF;
            this.__slot_LhxLkevjjEyMKiJ0ElJKod = other.__slot_LhxLkevjjEyMKiJ0ElJKod;
            this.Result = other.Result;
            this.__if_VRbs47YGeHrOFW9CYefFui = other.__if_VRbs47YGeHrOFW9CYefFui;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_Vo6qvdqEAj0OjSxMizpJhM", in __slot_Vo6qvdqEAj0OjSxMizpJhM), n1.CompilationHelper.GetValueOrExisting(values, "__slot_Rc2Yws1M194PTIUBfj7zkF", in __slot_Rc2Yws1M194PTIUBfj7zkF), n1.CompilationHelper.GetValueOrExisting(values, "__slot_LhxLkevjjEyMKiJ0ElJKod", in __slot_LhxLkevjjEyMKiJ0ElJKod), n1.CompilationHelper.GetValueOrExisting(values, "Result", in Result), n1.CompilationHelper.GetValueOrExisting(values, "__if_VRbs47YGeHrOFW9CYefFui", in __if_VRbs47YGeHrOFW9CYefFui));
        }

        internal ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O __WITH__(bool __slot_Vo6qvdqEAj0OjSxMizpJhM, bool __slot_Rc2Yws1M194PTIUBfj7zkF, string __slot_LhxLkevjjEyMKiJ0ElJKod, byte[] Result, n2.Object __if_VRbs47YGeHrOFW9CYefFui)
        {
            n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_Vo6qvdqEAj0OjSxMizpJhM != this.__slot_Vo6qvdqEAj0OjSxMizpJhM || __slot_Rc2Yws1M194PTIUBfj7zkF != this.__slot_Rc2Yws1M194PTIUBfj7zkF || __slot_LhxLkevjjEyMKiJ0ElJKod != this.__slot_LhxLkevjjEyMKiJ0ElJKod || Result != this.Result || __if_VRbs47YGeHrOFW9CYefFui != this.__if_VRbs47YGeHrOFW9CYefFui ? new ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O(this)
                {__slot_Vo6qvdqEAj0OjSxMizpJhM = __slot_Vo6qvdqEAj0OjSxMizpJhM, __slot_Rc2Yws1M194PTIUBfj7zkF = __slot_Rc2Yws1M194PTIUBfj7zkF, __slot_LhxLkevjjEyMKiJ0ElJKod = __slot_LhxLkevjjEyMKiJ0ElJKod, Result = Result, __if_VRbs47YGeHrOFW9CYefFui = __if_VRbs47YGeHrOFW9CYefFui} : that_0;
            else
            {
                this.__slot_Vo6qvdqEAj0OjSxMizpJhM = __slot_Vo6qvdqEAj0OjSxMizpJhM;
                this.__slot_Rc2Yws1M194PTIUBfj7zkF = __slot_Rc2Yws1M194PTIUBfj7zkF;
                this.__slot_LhxLkevjjEyMKiJ0ElJKod = __slot_LhxLkevjjEyMKiJ0ElJKod;
                this.Result = Result;
                this.__if_VRbs47YGeHrOFW9CYefFui = __if_VRbs47YGeHrOFW9CYefFui;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "BaTcZ8yj7v2QPjM24J0S6L", Name = "__BaTcZ8yj7v2QPjM24J0S6L")]
        [n2.SerializableAttribute]
        public class __BaTcZ8yj7v2QPjM24J0S6L : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_SSRuxO6g6eAQbOIF8niW6j);
                return;
            }

            [n1.ElementAttribute(TracingId = 2005U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "SSRuxO6g6eAQbOIF8niW6j", Name = "Try (1 Output)", IsManaged = true, IsAutoGenerated = true)]
            public n17.TryStateful<n2.Object> __p_SSRuxO6g6eAQbOIF8niW6j;
            public __BaTcZ8yj7v2QPjM24J0S6L(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __BaTcZ8yj7v2QPjM24J0S6L(__BaTcZ8yj7v2QPjM24J0S6L other): base(other)
            {
                this.__p_SSRuxO6g6eAQbOIF8niW6j = other.__p_SSRuxO6g6eAQbOIF8niW6j;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_SSRuxO6g6eAQbOIF8niW6j", in __p_SSRuxO6g6eAQbOIF8niW6j));
            }

            internal __BaTcZ8yj7v2QPjM24J0S6L __WITH__(n17.TryStateful<n2.Object> __p_SSRuxO6g6eAQbOIF8niW6j)
            {
                __BaTcZ8yj7v2QPjM24J0S6L that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_SSRuxO6g6eAQbOIF8niW6j != this.__p_SSRuxO6g6eAQbOIF8niW6j ? new __BaTcZ8yj7v2QPjM24J0S6L(this)
                    {__p_SSRuxO6g6eAQbOIF8niW6j = __p_SSRuxO6g6eAQbOIF8niW6j} : that_0;
                else
                {
                    this.__p_SSRuxO6g6eAQbOIF8niW6j = __p_SSRuxO6g6eAQbOIF8niW6j;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "LYthg5XoFGoP3myYGt8l7m", Name = "__LYthg5XoFGoP3myYGt8l7m")]
        [n2.SerializableAttribute]
        public class __LYthg5XoFGoP3myYGt8l7m : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            [n1.ElementAttribute(TracingId = 2030U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "EAViC60i0hKNdSHXaB4SFV", Name = "__slot_EAViC60i0hKNdSHXaB4SFV")]
            public int __slot_EAViC60i0hKNdSHXaB4SFV;
            public __LYthg5XoFGoP3myYGt8l7m(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __LYthg5XoFGoP3myYGt8l7m(__LYthg5XoFGoP3myYGt8l7m other): base(other)
            {
                this.__slot_EAViC60i0hKNdSHXaB4SFV = other.__slot_EAViC60i0hKNdSHXaB4SFV;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_EAViC60i0hKNdSHXaB4SFV", in __slot_EAViC60i0hKNdSHXaB4SFV));
            }

            internal __LYthg5XoFGoP3myYGt8l7m __WITH__(int __slot_EAViC60i0hKNdSHXaB4SFV)
            {
                __LYthg5XoFGoP3myYGt8l7m that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __slot_EAViC60i0hKNdSHXaB4SFV != this.__slot_EAViC60i0hKNdSHXaB4SFV ? new __LYthg5XoFGoP3myYGt8l7m(this)
                    {__slot_EAViC60i0hKNdSHXaB4SFV = __slot_EAViC60i0hKNdSHXaB4SFV} : that_0;
                else
                {
                    this.__slot_EAViC60i0hKNdSHXaB4SFV = __slot_EAViC60i0hKNdSHXaB4SFV;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 2093U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "CrGVtt0vTtwLMcNcjmdoDG", Name = "GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG")]
    [n2.SerializableAttribute]
    public class GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG Create(n1.NodeContext Node_Context)
        {
            var instance = new GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG CreateDefault()
        {
            var instance = new GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG Update(string Name_In, bool Refresh_In, out n2.IntPtr Result_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_S2O2PiMS3f6L4kMHAWNp3p;
            if (manager_1 is null)
            {
                manager_1 = new n7.Manager<n2.ValueTuple<string>, n2.ValueTuple<n2.IntPtr>>(n2.ValueTuple.Create(n31._Operations_.CreateDefault()));
            }

            var inputs_2 = n2.ValueTuple.Create(Name_In);
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Refresh_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__SW56yMN7KZeQQC40ZETLFI>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __SW56yMN7KZeQQC40ZETLFI(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "SHiZTLH7gyzMa9Qx1TuX0x", 2170U);
                    var Output_7 = n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O.Create(Node_Context: Node_Context_6);
                    state_5.__p_SHiZTLH7gyzMa9Qx1TuX0x = Output_7;
                }

                bool __pad_RL2EovZBiEfLrC6HLX93yT_8 = __slot_RL2EovZBiEfLrC6HLX93yT;
                int __pad_V4YPSjKR9K1LyJoozD6pkZ_9 = __slot_V4YPSjKR9K1LyJoozD6pkZ;
                bool Flush_10 = false;
                var Output_14 = state_5.__p_SHiZTLH7gyzMa9Qx1TuX0x.Update(Read_In: __pad_RL2EovZBiEfLrC6HLX93yT_8, Name_In: Name_In, Length_In: __pad_V4YPSjKR9K1LyJoozD6pkZ_9, Flush_In: Flush_10, Bytes_Out: out byte[] Bytes_11, Success_Out: out bool Success_12, Error_Out: out string Error_13);
                n9.ObjectHelpers.IsAssigned(x: Bytes_11, result: out bool Result_15, notAssigned: out bool Not_Assigned_16);
                n2.IntPtr __auto_17;
                if (Result_15)
                {
                    n16._Operations_.Length<byte>(Input_In: Bytes_11, Output_Out: out byte[] Output_19, Length_Out: out int Length_20);
                    int Input_2_21 = 3;
                    var Result_22 = Length_20 > Input_2_21;
                    n2.IntPtr __auto_23;
                    if (Result_22)
                    {
                        int Start_Index_25 = 0;
                        var Result_26 = n2.BitConverter.ToInt32(value: Bytes_11, startIndex: Start_Index_25);
                        n1.NodeContext Node_Context_27 = __GetContext__().CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "JJ1IBDwbUcuNrwwjv9qDyj", 2119U);
                        n31._Operations_.Create(Node_Context: Node_Context_27, Value_In: Result_26, Output_Out: out n2.IntPtr Output_28);
                        __auto_23 = Output_28;
                    }
                    else
                    {
                        __auto_23 = n31._Operations_.CreateDefault();
                    }

                    __auto_17 = __auto_23;
                }
                else
                {
                    __auto_17 = n31._Operations_.CreateDefault();
                }

                if (state_5.__GetContext__().IsImmutable)
                    state_5 = Output_14 != state_5.__p_SHiZTLH7gyzMa9Qx1TuX0x ? new __SW56yMN7KZeQQC40ZETLFI(state_5)
                    {__p_SHiZTLH7gyzMa9Qx1TuX0x = Output_14} : state_5;
                else
                {
                    state_5.__p_SHiZTLH7gyzMa9Qx1TuX0x = Output_14;
                }

                outputs_3 = n2.ValueTuple.Create(__auto_17);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var __auto_29 = outputs_3.Item1;
            Result_Out = __auto_29;
            n3.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG that_30 = this;
            if (this.__GetContext__().IsImmutable)
                that_30 = manager_1 != this.__cache_S2O2PiMS3f6L4kMHAWNp3p ? new GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG(this)
                {__cache_S2O2PiMS3f6L4kMHAWNp3p = manager_1} : that_30;
            else
            {
                this.__cache_S2O2PiMS3f6L4kMHAWNp3p = manager_1;
            }

            return that_30;
        }

        public n3.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG that_0 = this;
            this.__cache_S2O2PiMS3f6L4kMHAWNp3p = null;
            return that_0;
        }

        public n3.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG __CreateDefault__()
        {
            n3.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG that_0 = this;
            this.__cache_S2O2PiMS3f6L4kMHAWNp3p = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_S2O2PiMS3f6L4kMHAWNp3p);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 2098U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "S2O2PiMS3f6L4kMHAWNp3p", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<string>, n2.ValueTuple<n2.IntPtr>> __cache_S2O2PiMS3f6L4kMHAWNp3p = null;
        [n1.ElementAttribute(TracingId = 2165U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "RL2EovZBiEfLrC6HLX93yT", Name = "__slot_RL2EovZBiEfLrC6HLX93yT")]
        public static bool __slot_RL2EovZBiEfLrC6HLX93yT = true;
        [n1.ElementAttribute(TracingId = 2162U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "V4YPSjKR9K1LyJoozD6pkZ", Name = "__slot_V4YPSjKR9K1LyJoozD6pkZ")]
        public static int __slot_V4YPSjKR9K1LyJoozD6pkZ = 4;
        static GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG()
        {
        }

        public GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG(GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG other): base(other)
        {
            this.__cache_S2O2PiMS3f6L4kMHAWNp3p = other.__cache_S2O2PiMS3f6L4kMHAWNp3p;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_S2O2PiMS3f6L4kMHAWNp3p", in __cache_S2O2PiMS3f6L4kMHAWNp3p));
        }

        internal GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG __WITH__(n7.Manager<n2.ValueTuple<string>, n2.ValueTuple<n2.IntPtr>> __cache_S2O2PiMS3f6L4kMHAWNp3p)
        {
            n3.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_S2O2PiMS3f6L4kMHAWNp3p != this.__cache_S2O2PiMS3f6L4kMHAWNp3p ? new GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG(this)
                {__cache_S2O2PiMS3f6L4kMHAWNp3p = __cache_S2O2PiMS3f6L4kMHAWNp3p} : that_0;
            else
            {
                this.__cache_S2O2PiMS3f6L4kMHAWNp3p = __cache_S2O2PiMS3f6L4kMHAWNp3p;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "SW56yMN7KZeQQC40ZETLFI", Name = "__SW56yMN7KZeQQC40ZETLFI")]
        [n2.SerializableAttribute]
        public class __SW56yMN7KZeQQC40ZETLFI : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_SHiZTLH7gyzMa9Qx1TuX0x);
                return;
            }

            [n1.ElementAttribute(TracingId = 2170U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "SHiZTLH7gyzMa9Qx1TuX0x", Name = "ReadSharedMemory", IsManaged = true, IsAutoGenerated = true)]
            public n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O __p_SHiZTLH7gyzMa9Qx1TuX0x;
            public __SW56yMN7KZeQQC40ZETLFI(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __SW56yMN7KZeQQC40ZETLFI(__SW56yMN7KZeQQC40ZETLFI other): base(other)
            {
                this.__p_SHiZTLH7gyzMa9Qx1TuX0x = other.__p_SHiZTLH7gyzMa9Qx1TuX0x;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_SHiZTLH7gyzMa9Qx1TuX0x", in __p_SHiZTLH7gyzMa9Qx1TuX0x));
            }

            internal __SW56yMN7KZeQQC40ZETLFI __WITH__(n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O __p_SHiZTLH7gyzMa9Qx1TuX0x)
            {
                __SW56yMN7KZeQQC40ZETLFI that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_SHiZTLH7gyzMa9Qx1TuX0x != this.__p_SHiZTLH7gyzMa9Qx1TuX0x ? new __SW56yMN7KZeQQC40ZETLFI(this)
                    {__p_SHiZTLH7gyzMa9Qx1TuX0x = __p_SHiZTLH7gyzMa9Qx1TuX0x} : that_0;
                else
                {
                    this.__p_SHiZTLH7gyzMa9Qx1TuX0x = __p_SHiZTLH7gyzMa9Qx1TuX0x;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 2245U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "OTKQUMjfRmcMgwFRcW0SM1", Name = "SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1")]
    [n2.SerializableAttribute]
    public class SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1 Create(n1.NodeContext Node_Context)
        {
            var instance = new SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1 CreateDefault()
        {
            var instance = new SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1 Update([n4.SerializedDefaultValueAttribute("True", false)] bool Use_Active_Sender_In, [n4.SerializedDefaultValueAttribute("vvvv", false)] string Sender_Name_In, [n4.SerializedDefaultValueAttribute("True", false)] bool Is_SRgb_In, bool Refresh_In, out n5.Texture Output_Out)
        {
            int Index_0 = n2.Convert.ToInt32(Use_Active_Sender_In);
            var Output_3 = this.__p_QkOIncgzhdVMfib9XGdSvG.Update(Value_In: Use_Active_Sender_In, Result_Out: out bool Result_1, Unchanged_Out: out bool Unchanged_2);
            var Output_4 = Result_1 || Refresh_In;
            var State_Output_6 = this.__p_V0VL8KGvzuxOBV2ykLLMS1.Update(Update_In: Output_4, Output_Out: out string Output_5);
            var builder_7 = n4.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5, 2);
            builder_7.Add(Sender_Name_In);
            builder_7.Add(Output_5);
            var __pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5_8 = builder_7.Commit();
            n39._Operations_.Switch<string, n38.__AdaptiveImplementations__CWTbJ7dBwqtLwCqXKAv402>(Index_In: Index_0, Input_In: __pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5_8, Output_Out: out string Output_9);
            var Output_11 = this.__p_KKjlEOoeQoDOK53WR0tPl8.Update(Name_In: Output_9, Refresh_In: Output_4, Result_Out: out n2.IntPtr Result_10);
            var State_Output_13 = this.__p_VcPobSyDvITLwM346bUehF.Update(Texture_Handle_In: Result_10, Output_Out: out n5.Texture Output_12);
            n9.ObjectHelpers.IsAssigned(x: Output_12, result: out bool Result_14, notAssigned: out bool Not_Assigned_15);
            var Output_16 = Result_14 && Is_SRgb_In;
            n5.Texture __auto_17;
            var state_18 = n1.CompilationHelper.Restore<__AaMGjllkXGjLX7EzkotHJK>(this.__if_TqLNgQQzzfWPODkwRVCsGY, __GetContext__());
            if (Output_16)
            {
                if (state_18 == null)
                {
                    state_18 = new __AaMGjllkXGjLX7EzkotHJK(__GetContext__(), n1.VLObject.NewIdentity());
                }

                var Format_19 = Output_12.Format;
                var Result_20 = n14.PixelFormatExtensions.IsSRgb(fmt: Format_19);
                var Output_21 = !Result_20;
                n5.Texture __auto_22;
                var state_23 = n1.CompilationHelper.Restore<__MLUpBu2tDqeOLP8gSltLKg>(state_18.__if_MedarCU2rOmNnhmjUvJLk5, __GetContext__());
                if (Output_21)
                {
                    if (state_23 == null)
                    {
                        state_23 = new __MLUpBu2tDqeOLP8gSltLKg(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_24 = __GetContext__().CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "CpNy95ak9fsP5qHXFunJj0", 2283U);
                        var Output_25 = n13.CopyTexture_UGdw4Tvemx5QK60AS7AHcT.Create(Node_Context: Node_Context_24);
                        state_23.__p_CpNy95ak9fsP5qHXFunJj0 = Output_25;
                    }

                    var Output_26 = n14.PixelFormatExtensions.ToSRgb(format: Format_19);
                    bool Copy_Content_On_Clone_27 = false;
                    n5.TextureFlags Flags_28 = default(n5.TextureFlags);
                    bool Dispose_Cached_Texture_29 = true;
                    bool To_Shared_Texture_30 = false;
                    bool Auto_Render_31 = true;
                    var State_Output_34 = state_23.__p_CpNy95ak9fsP5qHXFunJj0.Update(Input_In: Output_12, Copy_Content_On_Clone_In: Copy_Content_On_Clone_27, Format_In: Output_26, Flags_In: Flags_28, Dispose_Cached_Texture_In: Dispose_Cached_Texture_29, To_Shared_Texture_In: To_Shared_Texture_30, Auto_Render_In: Auto_Render_31, Renderer_Out: out n15.CopyTextureRenderer_C Renderer_32, Output_Out: out n5.Texture Output_33);
                    __auto_22 = Output_33;
                    if (state_23.__GetContext__().IsImmutable)
                        state_23 = State_Output_34 != state_23.__p_CpNy95ak9fsP5qHXFunJj0 ? new __MLUpBu2tDqeOLP8gSltLKg(state_23)
                        {__p_CpNy95ak9fsP5qHXFunJj0 = State_Output_34} : state_23;
                    else
                    {
                        state_23.__p_CpNy95ak9fsP5qHXFunJj0 = State_Output_34;
                    }
                }
                else
                {
                    __auto_22 = Output_12;
                }

                __auto_17 = __auto_22;
                if (state_18.__GetContext__().IsImmutable)
                    state_18 = state_23 != state_18.__if_MedarCU2rOmNnhmjUvJLk5 ? new __AaMGjllkXGjLX7EzkotHJK(state_18)
                    {__if_MedarCU2rOmNnhmjUvJLk5 = state_23} : state_18;
                else
                {
                    state_18.__if_MedarCU2rOmNnhmjUvJLk5 = state_23;
                }
            }
            else
            {
                __auto_17 = Output_12;
            }

            Output_Out = __auto_17;
            n3.SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1 that_35 = this;
            if (this.__GetContext__().IsImmutable)
                that_35 = Output_3 != this.__p_QkOIncgzhdVMfib9XGdSvG || State_Output_6 != this.__p_V0VL8KGvzuxOBV2ykLLMS1 || __pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5_8 != this.__pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5 || Output_11 != this.__p_KKjlEOoeQoDOK53WR0tPl8 || State_Output_13 != this.__p_VcPobSyDvITLwM346bUehF || state_18 != this.__if_TqLNgQQzzfWPODkwRVCsGY ? new SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1(this)
                {__p_QkOIncgzhdVMfib9XGdSvG = Output_3, __p_V0VL8KGvzuxOBV2ykLLMS1 = State_Output_6, __pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5 = __pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5_8, __p_KKjlEOoeQoDOK53WR0tPl8 = Output_11, __p_VcPobSyDvITLwM346bUehF = State_Output_13, __if_TqLNgQQzzfWPODkwRVCsGY = state_18} : that_35;
            else
            {
                this.__p_QkOIncgzhdVMfib9XGdSvG = Output_3;
                this.__p_V0VL8KGvzuxOBV2ykLLMS1 = State_Output_6;
                this.__pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5 = __pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5_8;
                this.__p_KKjlEOoeQoDOK53WR0tPl8 = Output_11;
                this.__p_VcPobSyDvITLwM346bUehF = State_Output_13;
                this.__if_TqLNgQQzzfWPODkwRVCsGY = state_18;
            }

            return that_35;
        }

        public n3.SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1 __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "VcPobSyDvITLwM346bUehF", 2248U);
            var Output_1 = n41.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "KKjlEOoeQoDOK53WR0tPl8", 2253U);
            var Output_3 = n3.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "V0VL8KGvzuxOBV2ykLLMS1", 2322U);
            var Output_5 = n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "QkOIncgzhdVMfib9XGdSvG", 2338U);
            bool Changed_On_Create_7 = true;
            var Output_8 = n39.Changed_A8JGbead2bxNdnPybiEqVS<bool>.Create<n38.__AdaptiveImplementations__CWTbJ7dBwqtLwCqXKAv402>(Node_Context: Node_Context_6, Changed_On_Create_In: Changed_On_Create_7);
            n3.SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1 that_9 = this;
            this.__pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5 = n40._Operations_.CreateDefault<string>();
            this.__p_VcPobSyDvITLwM346bUehF = Output_1;
            this.__p_KKjlEOoeQoDOK53WR0tPl8 = Output_3;
            this.__p_V0VL8KGvzuxOBV2ykLLMS1 = Output_5;
            this.__p_QkOIncgzhdVMfib9XGdSvG = Output_8;
            this.__if_TqLNgQQzzfWPODkwRVCsGY = default(n2.Object);
            return that_9;
        }

        public n3.SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1 __CreateDefault__()
        {
            n3.SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1 that_0 = this;
            this.__pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5 = n40._Operations_.CreateDefault<string>();
            this.__p_QkOIncgzhdVMfib9XGdSvG = n39.Changed_A8JGbead2bxNdnPybiEqVS<bool>.CreateDefault<n38.__AdaptiveImplementations__CWTbJ7dBwqtLwCqXKAv402>();
            this.__p_V0VL8KGvzuxOBV2ykLLMS1 = n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs.CreateDefault();
            this.__p_KKjlEOoeQoDOK53WR0tPl8 = n3.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG.CreateDefault();
            this.__p_VcPobSyDvITLwM346bUehF = n41.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo.CreateDefault();
            this.__if_TqLNgQQzzfWPODkwRVCsGY = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_QkOIncgzhdVMfib9XGdSvG);
            n1.CompilationHelper.SafeDispose(this.__p_V0VL8KGvzuxOBV2ykLLMS1);
            n1.CompilationHelper.SafeDispose(this.__p_KKjlEOoeQoDOK53WR0tPl8);
            n1.CompilationHelper.SafeDispose(this.__p_VcPobSyDvITLwM346bUehF);
            n1.CompilationHelper.SafeDispose(this.__if_TqLNgQQzzfWPODkwRVCsGY);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 2338U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "QkOIncgzhdVMfib9XGdSvG", Name = "Changed", IsManaged = true, IsAutoGenerated = true)]
        public n39.Changed_A8JGbead2bxNdnPybiEqVS<bool> __p_QkOIncgzhdVMfib9XGdSvG;
        [n1.ElementAttribute(TracingId = 2322U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "V0VL8KGvzuxOBV2ykLLMS1", Name = "ActiveSender", IsManaged = true, IsAutoGenerated = true)]
        public n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs __p_V0VL8KGvzuxOBV2ykLLMS1;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n37.Spread<string> __pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5 = default(n37.Spread<string>);
        [n1.ElementAttribute(TracingId = 2253U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "KKjlEOoeQoDOK53WR0tPl8", Name = "GetSpoutHandle", IsManaged = true, IsAutoGenerated = true)]
        public n3.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG __p_KKjlEOoeQoDOK53WR0tPl8;
        [n1.ElementAttribute(TracingId = 2248U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "VcPobSyDvITLwM346bUehF", Name = "FromSharedHandle", IsManaged = true, IsAutoGenerated = true)]
        public n41.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo __p_VcPobSyDvITLwM346bUehF;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_TqLNgQQzzfWPODkwRVCsGY;
        public SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1(SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1 other): base(other)
        {
            this.__p_QkOIncgzhdVMfib9XGdSvG = other.__p_QkOIncgzhdVMfib9XGdSvG;
            this.__p_V0VL8KGvzuxOBV2ykLLMS1 = other.__p_V0VL8KGvzuxOBV2ykLLMS1;
            this.__pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5 = other.__pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5;
            this.__p_KKjlEOoeQoDOK53WR0tPl8 = other.__p_KKjlEOoeQoDOK53WR0tPl8;
            this.__p_VcPobSyDvITLwM346bUehF = other.__p_VcPobSyDvITLwM346bUehF;
            this.__if_TqLNgQQzzfWPODkwRVCsGY = other.__if_TqLNgQQzzfWPODkwRVCsGY;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_QkOIncgzhdVMfib9XGdSvG", in __p_QkOIncgzhdVMfib9XGdSvG), n1.CompilationHelper.GetValueOrExisting(values, "__p_V0VL8KGvzuxOBV2ykLLMS1", in __p_V0VL8KGvzuxOBV2ykLLMS1), n1.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5", in __pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5), n1.CompilationHelper.GetValueOrExisting(values, "__p_KKjlEOoeQoDOK53WR0tPl8", in __p_KKjlEOoeQoDOK53WR0tPl8), n1.CompilationHelper.GetValueOrExisting(values, "__p_VcPobSyDvITLwM346bUehF", in __p_VcPobSyDvITLwM346bUehF), n1.CompilationHelper.GetValueOrExisting(values, "__if_TqLNgQQzzfWPODkwRVCsGY", in __if_TqLNgQQzzfWPODkwRVCsGY));
        }

        internal SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1 __WITH__(n39.Changed_A8JGbead2bxNdnPybiEqVS<bool> __p_QkOIncgzhdVMfib9XGdSvG, n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs __p_V0VL8KGvzuxOBV2ykLLMS1, n37.Spread<string> __pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5, n3.GetSpoutHandle_CrGVtt0vTtwLMcNcjmdoDG __p_KKjlEOoeQoDOK53WR0tPl8, n41.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo __p_VcPobSyDvITLwM346bUehF, n2.Object __if_TqLNgQQzzfWPODkwRVCsGY)
        {
            n3.SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_QkOIncgzhdVMfib9XGdSvG != this.__p_QkOIncgzhdVMfib9XGdSvG || __p_V0VL8KGvzuxOBV2ykLLMS1 != this.__p_V0VL8KGvzuxOBV2ykLLMS1 || __pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5 != this.__pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5 || __p_KKjlEOoeQoDOK53WR0tPl8 != this.__p_KKjlEOoeQoDOK53WR0tPl8 || __p_VcPobSyDvITLwM346bUehF != this.__p_VcPobSyDvITLwM346bUehF || __if_TqLNgQQzzfWPODkwRVCsGY != this.__if_TqLNgQQzzfWPODkwRVCsGY ? new SpoutReceiver_OTKQUMjfRmcMgwFRcW0SM1(this)
                {__p_QkOIncgzhdVMfib9XGdSvG = __p_QkOIncgzhdVMfib9XGdSvG, __p_V0VL8KGvzuxOBV2ykLLMS1 = __p_V0VL8KGvzuxOBV2ykLLMS1, __pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5 = __pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5, __p_KKjlEOoeQoDOK53WR0tPl8 = __p_KKjlEOoeQoDOK53WR0tPl8, __p_VcPobSyDvITLwM346bUehF = __p_VcPobSyDvITLwM346bUehF, __if_TqLNgQQzzfWPODkwRVCsGY = __if_TqLNgQQzzfWPODkwRVCsGY} : that_0;
            else
            {
                this.__p_QkOIncgzhdVMfib9XGdSvG = __p_QkOIncgzhdVMfib9XGdSvG;
                this.__p_V0VL8KGvzuxOBV2ykLLMS1 = __p_V0VL8KGvzuxOBV2ykLLMS1;
                this.__pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5 = __pin_group_Input_In_RBgPeehqHAwOXkQlh0c5Q5;
                this.__p_KKjlEOoeQoDOK53WR0tPl8 = __p_KKjlEOoeQoDOK53WR0tPl8;
                this.__p_VcPobSyDvITLwM346bUehF = __p_VcPobSyDvITLwM346bUehF;
                this.__if_TqLNgQQzzfWPODkwRVCsGY = __if_TqLNgQQzzfWPODkwRVCsGY;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "AaMGjllkXGjLX7EzkotHJK", Name = "__AaMGjllkXGjLX7EzkotHJK")]
        [n2.SerializableAttribute]
        public class __AaMGjllkXGjLX7EzkotHJK : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__if_MedarCU2rOmNnhmjUvJLk5);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_MedarCU2rOmNnhmjUvJLk5;
            public __AaMGjllkXGjLX7EzkotHJK(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __AaMGjllkXGjLX7EzkotHJK(__AaMGjllkXGjLX7EzkotHJK other): base(other)
            {
                this.__if_MedarCU2rOmNnhmjUvJLk5 = other.__if_MedarCU2rOmNnhmjUvJLk5;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_MedarCU2rOmNnhmjUvJLk5", in __if_MedarCU2rOmNnhmjUvJLk5));
            }

            internal __AaMGjllkXGjLX7EzkotHJK __WITH__(n2.Object __if_MedarCU2rOmNnhmjUvJLk5)
            {
                __AaMGjllkXGjLX7EzkotHJK that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __if_MedarCU2rOmNnhmjUvJLk5 != this.__if_MedarCU2rOmNnhmjUvJLk5 ? new __AaMGjllkXGjLX7EzkotHJK(this)
                    {__if_MedarCU2rOmNnhmjUvJLk5 = __if_MedarCU2rOmNnhmjUvJLk5} : that_0;
                else
                {
                    this.__if_MedarCU2rOmNnhmjUvJLk5 = __if_MedarCU2rOmNnhmjUvJLk5;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "MLUpBu2tDqeOLP8gSltLKg", Name = "__MLUpBu2tDqeOLP8gSltLKg")]
        [n2.SerializableAttribute]
        public class __MLUpBu2tDqeOLP8gSltLKg : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_CpNy95ak9fsP5qHXFunJj0);
                return;
            }

            [n1.ElementAttribute(TracingId = 2283U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "CpNy95ak9fsP5qHXFunJj0", Name = "CopyTexture", IsManaged = true, IsAutoGenerated = true)]
            public n13.CopyTexture_UGdw4Tvemx5QK60AS7AHcT __p_CpNy95ak9fsP5qHXFunJj0;
            public __MLUpBu2tDqeOLP8gSltLKg(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __MLUpBu2tDqeOLP8gSltLKg(__MLUpBu2tDqeOLP8gSltLKg other): base(other)
            {
                this.__p_CpNy95ak9fsP5qHXFunJj0 = other.__p_CpNy95ak9fsP5qHXFunJj0;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_CpNy95ak9fsP5qHXFunJj0", in __p_CpNy95ak9fsP5qHXFunJj0));
            }

            internal __MLUpBu2tDqeOLP8gSltLKg __WITH__(n13.CopyTexture_UGdw4Tvemx5QK60AS7AHcT __p_CpNy95ak9fsP5qHXFunJj0)
            {
                __MLUpBu2tDqeOLP8gSltLKg that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_CpNy95ak9fsP5qHXFunJj0 != this.__p_CpNy95ak9fsP5qHXFunJj0 ? new __MLUpBu2tDqeOLP8gSltLKg(this)
                    {__p_CpNy95ak9fsP5qHXFunJj0 = __p_CpNy95ak9fsP5qHXFunJj0} : that_0;
                else
                {
                    this.__p_CpNy95ak9fsP5qHXFunJj0 = __p_CpNy95ak9fsP5qHXFunJj0;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 2411U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "DE1TLLzzndoM8ZsJ6Wsir9", Name = "SenderNames_DE1TLLzzndoM8ZsJ6Wsir9")]
    [n2.SerializableAttribute]
    public class SenderNames_DE1TLLzzndoM8ZsJ6Wsir9 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SenderNames_DE1TLLzzndoM8ZsJ6Wsir9 Create(n1.NodeContext Node_Context)
        {
            var instance = new SenderNames_DE1TLLzzndoM8ZsJ6Wsir9(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SenderNames_DE1TLLzzndoM8ZsJ6Wsir9 CreateDefault()
        {
            var instance = new SenderNames_DE1TLLzzndoM8ZsJ6Wsir9(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SenderNames_DE1TLLzzndoM8ZsJ6Wsir9 Update(bool Update_In, out n37.Spread<string> Output_Out)
        {
            var State_Output_1 = this.__p_Vb7XuQs8FaPPzde4mhiRKb.Update(Simulate_In: Update_In, Output_Out: out bool Output_0);
            bool Dispose_Cached_Outputs_2 = false;
            var manager_3 = this.__cache_BDtPstOG0kxPMRScH4szxt;
            if (manager_3 is null)
            {
                manager_3 = new n7.Manager<n2.ValueTuple, n2.ValueTuple<n37.Spread<string>>>(n2.ValueTuple.Create(n40._Operations_.CreateDefault<string>()));
            }

            var inputs_4 = n2.ValueTuple.Create();
            var outputs_5 = manager_3.Outputs;
            var Has_Changed_6 = Output_0 || manager_3.InputsChanged(inputs_4);
            if (Has_Changed_6)
            {
                if (Dispose_Cached_Outputs_2)
                    manager_3.DisposeOutputs();
                var state_7 = n1.CompilationHelper.Restore<__FhRBfeHnjEGL0DFCNYse7s>(manager_3.State, __GetContext__());
                if (state_7 == null)
                {
                    state_7 = new __FhRBfeHnjEGL0DFCNYse7s(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_8 = __GetContext__().CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "TU2lueswguoOsrgSBEkR58", 2425U);
                    var Output_9 = n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O.Create(Node_Context: Node_Context_8);
                    state_7.__p_TU2lueswguoOsrgSBEkR58 = Output_9;
                }

                bool __pad_TYpplqifdZdQJ8eyjrMCp5_10 = __slot_TYpplqifdZdQJ8eyjrMCp5;
                string __pad_L7qcMZtigyNMOygVX4h1Xi_11 = __slot_L7qcMZtigyNMOygVX4h1Xi;
                int __pad_QBo2FNpuwTzMuo0OVM8A8i_12 = __slot_QBo2FNpuwTzMuo0OVM8A8i;
                int __pad_HbAT5X6d9XsNrQ5IeIDQMV_13 = __slot_HbAT5X6d9XsNrQ5IeIDQMV;
                var Current_User_14 = n43.Registry.CurrentUser;
                string Name_15 = "Software\\Leading Edge\\Spout";
                var Result_16 = Current_User_14.OpenSubKey(name: Name_15);
                n9.ObjectHelpers.IsAssigned(x: Result_16, result: out bool Result_17, notAssigned: out bool Not_Assigned_18);
                int __auto_19;
                if (Result_17)
                {
                    int __pad_CVzXPNeaIOQNTcDdUzWAVD_21 = __slot_CVzXPNeaIOQNTcDdUzWAVD;
                    string Name_22 = "MaxSenders";
                    var Result_23 = Result_16.GetValue(name: Name_22);
                    int Default_24 = 0;
                    n44._Operations_.CastAs<int>(Input_In: Result_23, Default_In: Default_24, Result_Out: out int Result_25, Success_Out: out bool Success_26);
                    var Output_27 = __pad_CVzXPNeaIOQNTcDdUzWAVD_21 * Result_25;
                    __auto_19 = Output_27;
                }
                else
                {
                    __auto_19 = __pad_QBo2FNpuwTzMuo0OVM8A8i_12;
                }

                bool Flush_28 = false;
                var Output_32 = state_7.__p_TU2lueswguoOsrgSBEkR58.Update(Read_In: __pad_TYpplqifdZdQJ8eyjrMCp5_10, Name_In: __pad_L7qcMZtigyNMOygVX4h1Xi_11, Length_In: __auto_19, Flush_In: Flush_28, Bytes_Out: out byte[] Bytes_29, Success_Out: out bool Success_30, Error_Out: out string Error_31);
                n16._Operations_.Length<byte>(Input_In: Bytes_29, Output_Out: out byte[] Output_33, Length_Out: out int Length_34);
                n47.StringBuilder accumulator_36 = n46._Operations_.CreateDefault();
                n37.SpreadBuilder<string> accumulator_37 = n48._Operations_.CreateDefault<string>();
                int accumulator_38 = 0;
                for (var i_35 = 0; i_35 < __pad_HbAT5X6d9XsNrQ5IeIDQMV_13; i_35++)
                {
                    var i_local_39 = i_35;
                    n16._Operations_.GetItem<byte>(Input_In: Bytes_29, Index_In: accumulator_38, Output_Out: out byte[] Output_41, Item_Out: out byte Item_42);
                    byte Input_2_43 = 0;
                    var Result_44 = Item_42 == Input_2_43;
                    n47.StringBuilder __auto_45;
                    n37.SpreadBuilder<string> __auto_46;
                    int __auto_47;
                    if (Result_44)
                    {
                        int __pad_SBDim3d5YRcL32CIc1Y1Zu_49 = __slot_SBDim3d5YRcL32CIc1Y1Zu;
                        var Length_50 = accumulator_36.Length;
                        int Input_2_51 = 0;
                        var Result_52 = Length_50 == Input_2_51;
                        var Output_53 = !Result_52;
                        n47.StringBuilder __auto_54;
                        n37.SpreadBuilder<string> __auto_55;
                        if (Output_53)
                        {
                            var Result_57 = accumulator_36.ToString();
                            n48._Operations_.Add<string>(Input_In: accumulator_37, Item_In: Result_57, Output_Out: out n37.SpreadBuilder<string> Output_58);
                            bool Condition_59 = true;
                            n47.StringBuilder __auto_60;
                            if (Condition_59)
                            {
                                var Result_62 = accumulator_36.Clear();
                                __auto_60 = Result_62;
                            }
                            else
                            {
                                __auto_60 = accumulator_36;
                            }

                            __auto_54 = __auto_60;
                            __auto_55 = Output_58;
                        }
                        else
                        {
                            __auto_54 = accumulator_36;
                            __auto_55 = accumulator_37;
                        }

                        __auto_45 = __auto_54;
                        __auto_46 = __auto_55;
                        var Output_63 = accumulator_38 % __pad_SBDim3d5YRcL32CIc1Y1Zu_49;
                        int Input_3_64 = 1;
                        var Output_65 = __pad_SBDim3d5YRcL32CIc1Y1Zu_49 - Output_63;
                        var Output_66 = Output_65 - Input_3_64;
                        var Output_67 = accumulator_38 + Output_66;
                        __auto_47 = Output_67;
                    }
                    else
                    {
                        __auto_45 = accumulator_36;
                        __auto_46 = accumulator_37;
                        __auto_47 = accumulator_38;
                    }

                    var Output_68 = n50.Integer32Extensions.Inc(input: __auto_47);
                    var Result_69 = Output_68 >= Length_34;
                    var Output_70 = !Result_44;
                    n47.StringBuilder __auto_71;
                    if (Output_70)
                    {
                        var Result_73 = n50.IntegerConversions.ToChar(input: Item_42);
                        var Result_74 = __auto_45.Append(value: Result_73);
                        __auto_71 = Result_74;
                    }
                    else
                    {
                        __auto_71 = __auto_45;
                    }

                    accumulator_36 = __auto_71;
                    accumulator_37 = __auto_46;
                    accumulator_38 = Output_68;
                    if (Result_69)
                    {
                        break;
                    }
                }

                n48._Operations_.ToSpread<string>(Input_In: accumulator_37, Output_Out: out n37.SpreadBuilder<string> Output_75, Result_Out: out n37.Spread<string> Result_76);
                n40._Operations_.Sort<string>(Input_In: Result_76, Output_Out: out n37.Spread<string> Output_77);
                if (state_7.__GetContext__().IsImmutable)
                    state_7 = Output_32 != state_7.__p_TU2lueswguoOsrgSBEkR58 ? new __FhRBfeHnjEGL0DFCNYse7s(state_7)
                    {__p_TU2lueswguoOsrgSBEkR58 = Output_32} : state_7;
                else
                {
                    state_7.__p_TU2lueswguoOsrgSBEkR58 = Output_32;
                }

                outputs_5 = n2.ValueTuple.Create(Output_77);
                manager_3 = manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2, state_7, outputs_5);
            }
            else
            {
                manager_3.Update(inputs_4, __GetContext__().IsImmutable, Dispose_Cached_Outputs_2);
            }

            var __auto_78 = outputs_5.Item1;
            Output_Out = __auto_78;
            n3.SenderNames_DE1TLLzzndoM8ZsJ6Wsir9 that_79 = this;
            if (this.__GetContext__().IsImmutable)
                that_79 = State_Output_1 != this.__p_Vb7XuQs8FaPPzde4mhiRKb || manager_3 != this.__cache_BDtPstOG0kxPMRScH4szxt ? new SenderNames_DE1TLLzzndoM8ZsJ6Wsir9(this)
                {__p_Vb7XuQs8FaPPzde4mhiRKb = State_Output_1, __cache_BDtPstOG0kxPMRScH4szxt = manager_3} : that_79;
            else
            {
                this.__p_Vb7XuQs8FaPPzde4mhiRKb = State_Output_1;
                this.__cache_BDtPstOG0kxPMRScH4szxt = manager_3;
            }

            return that_79;
        }

        public n3.SenderNames_DE1TLLzzndoM8ZsJ6Wsir9 __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "Vb7XuQs8FaPPzde4mhiRKb", 2750U);
            var Output_1 = n39.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.Create(Node_Context: Node_Context_0);
            n3.SenderNames_DE1TLLzzndoM8ZsJ6Wsir9 that_2 = this;
            this.__p_Vb7XuQs8FaPPzde4mhiRKb = Output_1;
            this.__cache_BDtPstOG0kxPMRScH4szxt = null;
            return that_2;
        }

        public n3.SenderNames_DE1TLLzzndoM8ZsJ6Wsir9 __CreateDefault__()
        {
            n3.SenderNames_DE1TLLzzndoM8ZsJ6Wsir9 that_0 = this;
            this.__p_Vb7XuQs8FaPPzde4mhiRKb = n39.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz.CreateDefault();
            this.__cache_BDtPstOG0kxPMRScH4szxt = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Vb7XuQs8FaPPzde4mhiRKb);
            n1.CompilationHelper.SafeDispose(this.__cache_BDtPstOG0kxPMRScH4szxt);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 2750U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "Vb7XuQs8FaPPzde4mhiRKb", Name = "OnOpen", IsManaged = true, IsAutoGenerated = true)]
        public n39.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_Vb7XuQs8FaPPzde4mhiRKb;
        [n1.ElementAttribute(TracingId = 2415U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "BDtPstOG0kxPMRScH4szxt", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple, n2.ValueTuple<n37.Spread<string>>> __cache_BDtPstOG0kxPMRScH4szxt = null;
        [n1.ElementAttribute(TracingId = 2424U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "TYpplqifdZdQJ8eyjrMCp5", Name = "__slot_TYpplqifdZdQJ8eyjrMCp5")]
        public static bool __slot_TYpplqifdZdQJ8eyjrMCp5 = true;
        [n1.ElementAttribute(TracingId = 2433U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "L7qcMZtigyNMOygVX4h1Xi", Name = "__slot_L7qcMZtigyNMOygVX4h1Xi")]
        public static string __slot_L7qcMZtigyNMOygVX4h1Xi = "SpoutSenderNames";
        [n1.ElementAttribute(TracingId = 2423U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "QBo2FNpuwTzMuo0OVM8A8i", Name = "__slot_QBo2FNpuwTzMuo0OVM8A8i")]
        public static int __slot_QBo2FNpuwTzMuo0OVM8A8i = 16384;
        [n1.ElementAttribute(TracingId = 2712U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "HbAT5X6d9XsNrQ5IeIDQMV", Name = "__slot_HbAT5X6d9XsNrQ5IeIDQMV")]
        public static int __slot_HbAT5X6d9XsNrQ5IeIDQMV = 999999;
        [n1.ElementAttribute(TracingId = 2739U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "CVzXPNeaIOQNTcDdUzWAVD", Name = "__slot_CVzXPNeaIOQNTcDdUzWAVD")]
        public static int __slot_CVzXPNeaIOQNTcDdUzWAVD = 256;
        [n1.ElementAttribute(TracingId = 2508U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "SBDim3d5YRcL32CIc1Y1Zu", Name = "__slot_SBDim3d5YRcL32CIc1Y1Zu")]
        public static int __slot_SBDim3d5YRcL32CIc1Y1Zu = 256;
        static SenderNames_DE1TLLzzndoM8ZsJ6Wsir9()
        {
        }

        public SenderNames_DE1TLLzzndoM8ZsJ6Wsir9(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SenderNames_DE1TLLzzndoM8ZsJ6Wsir9(SenderNames_DE1TLLzzndoM8ZsJ6Wsir9 other): base(other)
        {
            this.__p_Vb7XuQs8FaPPzde4mhiRKb = other.__p_Vb7XuQs8FaPPzde4mhiRKb;
            this.__cache_BDtPstOG0kxPMRScH4szxt = other.__cache_BDtPstOG0kxPMRScH4szxt;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Vb7XuQs8FaPPzde4mhiRKb", in __p_Vb7XuQs8FaPPzde4mhiRKb), n1.CompilationHelper.GetValueOrExisting(values, "__cache_BDtPstOG0kxPMRScH4szxt", in __cache_BDtPstOG0kxPMRScH4szxt));
        }

        internal SenderNames_DE1TLLzzndoM8ZsJ6Wsir9 __WITH__(n39.OnOpen_FuW9Q3o4A1QLNwSJwTBGFz __p_Vb7XuQs8FaPPzde4mhiRKb, n7.Manager<n2.ValueTuple, n2.ValueTuple<n37.Spread<string>>> __cache_BDtPstOG0kxPMRScH4szxt)
        {
            n3.SenderNames_DE1TLLzzndoM8ZsJ6Wsir9 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Vb7XuQs8FaPPzde4mhiRKb != this.__p_Vb7XuQs8FaPPzde4mhiRKb || __cache_BDtPstOG0kxPMRScH4szxt != this.__cache_BDtPstOG0kxPMRScH4szxt ? new SenderNames_DE1TLLzzndoM8ZsJ6Wsir9(this)
                {__p_Vb7XuQs8FaPPzde4mhiRKb = __p_Vb7XuQs8FaPPzde4mhiRKb, __cache_BDtPstOG0kxPMRScH4szxt = __cache_BDtPstOG0kxPMRScH4szxt} : that_0;
            else
            {
                this.__p_Vb7XuQs8FaPPzde4mhiRKb = __p_Vb7XuQs8FaPPzde4mhiRKb;
                this.__cache_BDtPstOG0kxPMRScH4szxt = __cache_BDtPstOG0kxPMRScH4szxt;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "FhRBfeHnjEGL0DFCNYse7s", Name = "__FhRBfeHnjEGL0DFCNYse7s")]
        [n2.SerializableAttribute]
        public class __FhRBfeHnjEGL0DFCNYse7s : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_TU2lueswguoOsrgSBEkR58);
                return;
            }

            [n1.ElementAttribute(TracingId = 2425U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "TU2lueswguoOsrgSBEkR58", Name = "ReadSharedMemory", IsManaged = true, IsAutoGenerated = true)]
            public n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O __p_TU2lueswguoOsrgSBEkR58;
            public __FhRBfeHnjEGL0DFCNYse7s(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __FhRBfeHnjEGL0DFCNYse7s(__FhRBfeHnjEGL0DFCNYse7s other): base(other)
            {
                this.__p_TU2lueswguoOsrgSBEkR58 = other.__p_TU2lueswguoOsrgSBEkR58;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TU2lueswguoOsrgSBEkR58", in __p_TU2lueswguoOsrgSBEkR58));
            }

            internal __FhRBfeHnjEGL0DFCNYse7s __WITH__(n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O __p_TU2lueswguoOsrgSBEkR58)
            {
                __FhRBfeHnjEGL0DFCNYse7s that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_TU2lueswguoOsrgSBEkR58 != this.__p_TU2lueswguoOsrgSBEkR58 ? new __FhRBfeHnjEGL0DFCNYse7s(this)
                    {__p_TU2lueswguoOsrgSBEkR58 = __p_TU2lueswguoOsrgSBEkR58} : that_0;
                else
                {
                    this.__p_TU2lueswguoOsrgSBEkR58 = __p_TU2lueswguoOsrgSBEkR58;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 2869U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "GP70vnZCHDTOGK77SB6cvs", Name = "ActiveSender_GP70vnZCHDTOGK77SB6cvs")]
    [n2.SerializableAttribute]
    public class ActiveSender_GP70vnZCHDTOGK77SB6cvs : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs Create(n1.NodeContext Node_Context)
        {
            var instance = new ActiveSender_GP70vnZCHDTOGK77SB6cvs(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs CreateDefault()
        {
            var instance = new ActiveSender_GP70vnZCHDTOGK77SB6cvs(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs Update(bool Update_In, out string Output_Out)
        {
            bool Dispose_Cached_Outputs_0 = false;
            var manager_1 = this.__cache_SgAwlnrNFGXPOyIUEDEEb4;
            if (manager_1 is null)
            {
                manager_1 = new n7.Manager<n2.ValueTuple, n2.ValueTuple<string>>(n2.ValueTuple.Create(""));
            }

            var inputs_2 = n2.ValueTuple.Create();
            var outputs_3 = manager_1.Outputs;
            var Has_Changed_4 = Update_In || manager_1.InputsChanged(inputs_2);
            if (Has_Changed_4)
            {
                if (Dispose_Cached_Outputs_0)
                    manager_1.DisposeOutputs();
                var state_5 = n1.CompilationHelper.Restore<__ELBRSlS7wHoNzMfuGeVE1I>(manager_1.State, __GetContext__());
                if (state_5 == null)
                {
                    state_5 = new __ELBRSlS7wHoNzMfuGeVE1I(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_6 = __GetContext__().CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "TkZlrOPS3nTL57Ha1YLfju", 2887U);
                    var Output_7 = n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O.Create(Node_Context: Node_Context_6);
                    state_5.__p_TkZlrOPS3nTL57Ha1YLfju = Output_7;
                }

                string __pad_TTETcEJe5scQQkZUknEouk_8 = __slot_TTETcEJe5scQQkZUknEouk;
                int __pad_V5jXSpxtemOPOf4R7MLCD6_9 = __slot_V5jXSpxtemOPOf4R7MLCD6;
                bool Read_10 = true;
                bool Flush_11 = false;
                var Output_15 = state_5.__p_TkZlrOPS3nTL57Ha1YLfju.Update(Read_In: Read_10, Name_In: __pad_TTETcEJe5scQQkZUknEouk_8, Length_In: __pad_V5jXSpxtemOPOf4R7MLCD6_9, Flush_In: Flush_11, Bytes_Out: out byte[] Bytes_12, Success_Out: out bool Success_13, Error_Out: out string Error_14);
                n11.IEnumerable<byte> Input_16 = (n11.IEnumerable<byte>)Bytes_12;
                string __auto_17;
                if (Success_13)
                {
                    n51.Encodings Encoding_19 = __c_SiytlrHR7tzQPb1U17f77E;
                    var Result_20 = n50.StringExtensions.FromBytes(input: Input_16, encoding: Encoding_19);
                    byte Input_21 = 0;
                    var Result_22 = n50.IntegerConversions.ToChar(input: Input_21);
                    var Result_23 = char.ToString(c: Result_22);
                    n2.StringSplitOptions Options_24 = __c_DwgwuQ56zd5Pp2sAehgGPS;
                    n52._Operations_.Split_String(Input_In: Result_20, Separator_In: Result_23, Options_In: Options_24, Output_Out: out n37.Spread<string> Output_25);
                    string Default_Value_26 = "";
                    n53._Operations_.FirstOrDefault<n37.Spread<string>, string>(Input_In: Output_25, Default_Value_In: Default_Value_26, Output_Out: out n37.Spread<string> Output_27, Result_Out: out string Result_28);
                    __auto_17 = Result_28;
                }
                else
                {
                    __auto_17 = "";
                }

                if (state_5.__GetContext__().IsImmutable)
                    state_5 = Output_15 != state_5.__p_TkZlrOPS3nTL57Ha1YLfju ? new __ELBRSlS7wHoNzMfuGeVE1I(state_5)
                    {__p_TkZlrOPS3nTL57Ha1YLfju = Output_15} : state_5;
                else
                {
                    state_5.__p_TkZlrOPS3nTL57Ha1YLfju = Output_15;
                }

                outputs_3 = n2.ValueTuple.Create(__auto_17);
                manager_1 = manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0, state_5, outputs_3);
            }
            else
            {
                manager_1.Update(inputs_2, __GetContext__().IsImmutable, Dispose_Cached_Outputs_0);
            }

            var __auto_29 = outputs_3.Item1;
            Output_Out = __auto_29;
            n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs that_30 = this;
            if (this.__GetContext__().IsImmutable)
                that_30 = manager_1 != this.__cache_SgAwlnrNFGXPOyIUEDEEb4 ? new ActiveSender_GP70vnZCHDTOGK77SB6cvs(this)
                {__cache_SgAwlnrNFGXPOyIUEDEEb4 = manager_1} : that_30;
            else
            {
                this.__cache_SgAwlnrNFGXPOyIUEDEEb4 = manager_1;
            }

            return that_30;
        }

        public n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs that_0 = this;
            this.__cache_SgAwlnrNFGXPOyIUEDEEb4 = null;
            return that_0;
        }

        public n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs __CreateDefault__()
        {
            n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs that_0 = this;
            this.__cache_SgAwlnrNFGXPOyIUEDEEb4 = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_SgAwlnrNFGXPOyIUEDEEb4);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 2875U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "SgAwlnrNFGXPOyIUEDEEb4", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple, n2.ValueTuple<string>> __cache_SgAwlnrNFGXPOyIUEDEEb4 = null;
        [n1.ElementAttribute(TracingId = 2903U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "TTETcEJe5scQQkZUknEouk", Name = "__slot_TTETcEJe5scQQkZUknEouk")]
        public static string __slot_TTETcEJe5scQQkZUknEouk = "ActiveSenderName";
        [n1.ElementAttribute(TracingId = 2965U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "V5jXSpxtemOPOf4R7MLCD6", Name = "__slot_V5jXSpxtemOPOf4R7MLCD6")]
        public static int __slot_V5jXSpxtemOPOf4R7MLCD6 = 256;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n51.Encodings __c_SiytlrHR7tzQPb1U17f77E = n1.CompilationHelper.Deserialize<n51.Encodings>("ASCII", false, "CWTbJ7dBwqtLwCqXKAv402", "SiytlrHR7tzQPb1U17f77E");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n2.StringSplitOptions __c_DwgwuQ56zd5Pp2sAehgGPS = n1.CompilationHelper.Deserialize<n2.StringSplitOptions>("None", false, "CWTbJ7dBwqtLwCqXKAv402", "DwgwuQ56zd5Pp2sAehgGPS");
        static ActiveSender_GP70vnZCHDTOGK77SB6cvs()
        {
        }

        public ActiveSender_GP70vnZCHDTOGK77SB6cvs(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ActiveSender_GP70vnZCHDTOGK77SB6cvs(ActiveSender_GP70vnZCHDTOGK77SB6cvs other): base(other)
        {
            this.__cache_SgAwlnrNFGXPOyIUEDEEb4 = other.__cache_SgAwlnrNFGXPOyIUEDEEb4;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_SgAwlnrNFGXPOyIUEDEEb4", in __cache_SgAwlnrNFGXPOyIUEDEEb4));
        }

        internal ActiveSender_GP70vnZCHDTOGK77SB6cvs __WITH__(n7.Manager<n2.ValueTuple, n2.ValueTuple<string>> __cache_SgAwlnrNFGXPOyIUEDEEb4)
        {
            n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_SgAwlnrNFGXPOyIUEDEEb4 != this.__cache_SgAwlnrNFGXPOyIUEDEEb4 ? new ActiveSender_GP70vnZCHDTOGK77SB6cvs(this)
                {__cache_SgAwlnrNFGXPOyIUEDEEb4 = __cache_SgAwlnrNFGXPOyIUEDEEb4} : that_0;
            else
            {
                this.__cache_SgAwlnrNFGXPOyIUEDEEb4 = __cache_SgAwlnrNFGXPOyIUEDEEb4;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "ELBRSlS7wHoNzMfuGeVE1I", Name = "__ELBRSlS7wHoNzMfuGeVE1I")]
        [n2.SerializableAttribute]
        public class __ELBRSlS7wHoNzMfuGeVE1I : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_TkZlrOPS3nTL57Ha1YLfju);
                return;
            }

            [n1.ElementAttribute(TracingId = 2887U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "TkZlrOPS3nTL57Ha1YLfju", Name = "ReadSharedMemory", IsManaged = true, IsAutoGenerated = true)]
            public n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O __p_TkZlrOPS3nTL57Ha1YLfju;
            public __ELBRSlS7wHoNzMfuGeVE1I(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __ELBRSlS7wHoNzMfuGeVE1I(__ELBRSlS7wHoNzMfuGeVE1I other): base(other)
            {
                this.__p_TkZlrOPS3nTL57Ha1YLfju = other.__p_TkZlrOPS3nTL57Ha1YLfju;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_TkZlrOPS3nTL57Ha1YLfju", in __p_TkZlrOPS3nTL57Ha1YLfju));
            }

            internal __ELBRSlS7wHoNzMfuGeVE1I __WITH__(n3.ReadSharedMemory_PO0iXa0KkRwLo98DekIq4O __p_TkZlrOPS3nTL57Ha1YLfju)
            {
                __ELBRSlS7wHoNzMfuGeVE1I that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_TkZlrOPS3nTL57Ha1YLfju != this.__p_TkZlrOPS3nTL57Ha1YLfju ? new __ELBRSlS7wHoNzMfuGeVE1I(this)
                    {__p_TkZlrOPS3nTL57Ha1YLfju = __p_TkZlrOPS3nTL57Ha1YLfju} : that_0;
                else
                {
                    this.__p_TkZlrOPS3nTL57Ha1YLfju = __p_TkZlrOPS3nTL57Ha1YLfju;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 3129U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "OK6ltAN4ZU8O1dfuWgbnmH", Name = "WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH")]
    [n2.SerializableAttribute]
    public class WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH Create(n1.NodeContext Node_Context)
        {
            var instance = new WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH CreateDefault()
        {
            var instance = new WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH Update(bool Write_In, [n4.SerializedDefaultValueAttribute("", false)] string Name_In, byte[] Buffer_In, out bool Success_Out, out string Error_Out)
        {
            bool __pad_Kon6RFwx0FoM154aqXRdnH_0 = __slot_Kon6RFwx0FoM154aqXRdnH;
            bool __auto_1;
            string __auto_2;
            var state_3 = n1.CompilationHelper.Restore<__RRHsXAPVLU0MMSiVcaH5Xs>(this.__if_Nmw6xRCNkQAPAuLE1BkiHa, __GetContext__());
            if (Write_In)
            {
                if (state_3 == null)
                {
                    state_3 = new __RRHsXAPVLU0MMSiVcaH5Xs(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_4 = __GetContext__().CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "UNXhtz80hZ4O5r5tkorhcE", 3153U);
                    n18._Operations_.Create_H<n2.Object>(Node_Context: Node_Context_4, Output_Out: out n17.TryStateful<n2.Object> Output_5);
                    state_3.__p_UNXhtz80hZ4O5r5tkorhcE = Output_5;
                }

                bool Re_Initialize_6 = false;
                var __fallback___7 = n1.ServiceRegistry.Current;
                n18._Operations_.Update_H<n2.Object, byte[]>(Input_In: state_3.__p_UNXhtz80hZ4O5r5tkorhcE, Default_Output_In: Buffer_In, Re_Initialize_In: Re_Initialize_6, Try_In: (n2.Object s_10) =>
                {
                    using var __current_8 = __fallback___7.MakeCurrentIfNone();
                    var state_9 = n1.CompilationHelper.Restore<__ATTCjcbVOoXMRQ632aJkXS>(s_10, __GetContext__());
                    var Result_11 = n19.MemoryMappedFile.OpenExisting(mapName: Name_In);
                    var Result_12 = Result_11.CreateViewStream();
                    var Output_13 = n20.Stream.Synchronized(stream: Result_12);
                    n16._Operations_.Length<byte>(Input_In: Buffer_In, Output_Out: out byte[] Output_14, Length_Out: out int Length_15);
                    int Offset_16 = 0;
                    Output_13.Write(buffer: Output_14, offset: Offset_16, count: Length_15);
                    return n2.Tuple.Create<n2.Object, byte[]>(state_9, n16._Operations_.CreateDefault<byte>());
                }

                , Create_In: () =>
                {
                    using var __current_17 = __fallback___7.MakeCurrentIfNone();
                    var state_9 = new __ATTCjcbVOoXMRQ632aJkXS(__GetContext__(), n1.VLObject.NewIdentity());
                    return state_9;
                }

                , Output_Out: out n17.TryStateful<n2.Object> Output_18, Result_Out: out byte[] Result_19, Success_Out: out bool Success_20, Error_Message_Out: out string Error_Message_21);
                __auto_1 = Success_20;
                __auto_2 = Error_Message_21;
                if (state_3.__GetContext__().IsImmutable)
                    state_3 = Output_18 != state_3.__p_UNXhtz80hZ4O5r5tkorhcE ? new __RRHsXAPVLU0MMSiVcaH5Xs(state_3)
                    {__p_UNXhtz80hZ4O5r5tkorhcE = Output_18} : state_3;
                else
                {
                    state_3.__p_UNXhtz80hZ4O5r5tkorhcE = Output_18;
                }
            }
            else
            {
                __auto_1 = __pad_Kon6RFwx0FoM154aqXRdnH_0;
                __auto_2 = "";
            }

            bool __pad_C5COuBKt3TyMLjj2n8fWYO_22 = __auto_1;
            string __pad_VrTBWWDoVDCP7nnrS4ZCNL_23 = __auto_2;
            Success_Out = __pad_C5COuBKt3TyMLjj2n8fWYO_22;
            Error_Out = __pad_VrTBWWDoVDCP7nnrS4ZCNL_23;
            n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH that_24 = this;
            if (this.__GetContext__().IsImmutable)
                that_24 = state_3 != this.__if_Nmw6xRCNkQAPAuLE1BkiHa || __auto_1 != this.__slot_C5COuBKt3TyMLjj2n8fWYO || __auto_2 != this.__slot_VrTBWWDoVDCP7nnrS4ZCNL ? new WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH(this)
                {__if_Nmw6xRCNkQAPAuLE1BkiHa = state_3, __slot_C5COuBKt3TyMLjj2n8fWYO = __auto_1, __slot_VrTBWWDoVDCP7nnrS4ZCNL = __auto_2} : that_24;
            else
            {
                this.__if_Nmw6xRCNkQAPAuLE1BkiHa = state_3;
                this.__slot_C5COuBKt3TyMLjj2n8fWYO = __auto_1;
                this.__slot_VrTBWWDoVDCP7nnrS4ZCNL = __auto_2;
            }

            return that_24;
        }

        public n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH that_0 = this;
            this.__slot_C5COuBKt3TyMLjj2n8fWYO = false;
            this.__slot_VrTBWWDoVDCP7nnrS4ZCNL = "";
            this.__if_Nmw6xRCNkQAPAuLE1BkiHa = default(n2.Object);
            return that_0;
        }

        public n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH __CreateDefault__()
        {
            n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH that_0 = this;
            this.__slot_C5COuBKt3TyMLjj2n8fWYO = false;
            this.__slot_VrTBWWDoVDCP7nnrS4ZCNL = "";
            this.__if_Nmw6xRCNkQAPAuLE1BkiHa = default(n2.Object);
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__if_Nmw6xRCNkQAPAuLE1BkiHa);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 3135U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "C5COuBKt3TyMLjj2n8fWYO", Name = "__slot_C5COuBKt3TyMLjj2n8fWYO")]
        public bool __slot_C5COuBKt3TyMLjj2n8fWYO;
        [n1.ElementAttribute(TracingId = 3139U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "VrTBWWDoVDCP7nnrS4ZCNL", Name = "__slot_VrTBWWDoVDCP7nnrS4ZCNL")]
        public string __slot_VrTBWWDoVDCP7nnrS4ZCNL;
        [n1.ElementAttribute(TracingId = 3496U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "Kon6RFwx0FoM154aqXRdnH", Name = "__slot_Kon6RFwx0FoM154aqXRdnH")]
        public static bool __slot_Kon6RFwx0FoM154aqXRdnH = false;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_Nmw6xRCNkQAPAuLE1BkiHa;
        static WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH()
        {
        }

        public WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH(WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH other): base(other)
        {
            this.__slot_C5COuBKt3TyMLjj2n8fWYO = other.__slot_C5COuBKt3TyMLjj2n8fWYO;
            this.__slot_VrTBWWDoVDCP7nnrS4ZCNL = other.__slot_VrTBWWDoVDCP7nnrS4ZCNL;
            this.__if_Nmw6xRCNkQAPAuLE1BkiHa = other.__if_Nmw6xRCNkQAPAuLE1BkiHa;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__slot_C5COuBKt3TyMLjj2n8fWYO", in __slot_C5COuBKt3TyMLjj2n8fWYO), n1.CompilationHelper.GetValueOrExisting(values, "__slot_VrTBWWDoVDCP7nnrS4ZCNL", in __slot_VrTBWWDoVDCP7nnrS4ZCNL), n1.CompilationHelper.GetValueOrExisting(values, "__if_Nmw6xRCNkQAPAuLE1BkiHa", in __if_Nmw6xRCNkQAPAuLE1BkiHa));
        }

        internal WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH __WITH__(bool __slot_C5COuBKt3TyMLjj2n8fWYO, string __slot_VrTBWWDoVDCP7nnrS4ZCNL, n2.Object __if_Nmw6xRCNkQAPAuLE1BkiHa)
        {
            n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_C5COuBKt3TyMLjj2n8fWYO != this.__slot_C5COuBKt3TyMLjj2n8fWYO || __slot_VrTBWWDoVDCP7nnrS4ZCNL != this.__slot_VrTBWWDoVDCP7nnrS4ZCNL || __if_Nmw6xRCNkQAPAuLE1BkiHa != this.__if_Nmw6xRCNkQAPAuLE1BkiHa ? new WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH(this)
                {__slot_C5COuBKt3TyMLjj2n8fWYO = __slot_C5COuBKt3TyMLjj2n8fWYO, __slot_VrTBWWDoVDCP7nnrS4ZCNL = __slot_VrTBWWDoVDCP7nnrS4ZCNL, __if_Nmw6xRCNkQAPAuLE1BkiHa = __if_Nmw6xRCNkQAPAuLE1BkiHa} : that_0;
            else
            {
                this.__slot_C5COuBKt3TyMLjj2n8fWYO = __slot_C5COuBKt3TyMLjj2n8fWYO;
                this.__slot_VrTBWWDoVDCP7nnrS4ZCNL = __slot_VrTBWWDoVDCP7nnrS4ZCNL;
                this.__if_Nmw6xRCNkQAPAuLE1BkiHa = __if_Nmw6xRCNkQAPAuLE1BkiHa;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "RRHsXAPVLU0MMSiVcaH5Xs", Name = "__RRHsXAPVLU0MMSiVcaH5Xs")]
        [n2.SerializableAttribute]
        public class __RRHsXAPVLU0MMSiVcaH5Xs : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_UNXhtz80hZ4O5r5tkorhcE);
                return;
            }

            [n1.ElementAttribute(TracingId = 3153U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "UNXhtz80hZ4O5r5tkorhcE", Name = "Try (1 Output)", IsManaged = true, IsAutoGenerated = true)]
            public n17.TryStateful<n2.Object> __p_UNXhtz80hZ4O5r5tkorhcE;
            public __RRHsXAPVLU0MMSiVcaH5Xs(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __RRHsXAPVLU0MMSiVcaH5Xs(__RRHsXAPVLU0MMSiVcaH5Xs other): base(other)
            {
                this.__p_UNXhtz80hZ4O5r5tkorhcE = other.__p_UNXhtz80hZ4O5r5tkorhcE;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_UNXhtz80hZ4O5r5tkorhcE", in __p_UNXhtz80hZ4O5r5tkorhcE));
            }

            internal __RRHsXAPVLU0MMSiVcaH5Xs __WITH__(n17.TryStateful<n2.Object> __p_UNXhtz80hZ4O5r5tkorhcE)
            {
                __RRHsXAPVLU0MMSiVcaH5Xs that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_UNXhtz80hZ4O5r5tkorhcE != this.__p_UNXhtz80hZ4O5r5tkorhcE ? new __RRHsXAPVLU0MMSiVcaH5Xs(this)
                    {__p_UNXhtz80hZ4O5r5tkorhcE = __p_UNXhtz80hZ4O5r5tkorhcE} : that_0;
                else
                {
                    this.__p_UNXhtz80hZ4O5r5tkorhcE = __p_UNXhtz80hZ4O5r5tkorhcE;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "ATTCjcbVOoXMRQ632aJkXS", Name = "__ATTCjcbVOoXMRQ632aJkXS")]
        [n2.SerializableAttribute]
        public class __ATTCjcbVOoXMRQ632aJkXS : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                return;
            }

            public __ATTCjcbVOoXMRQ632aJkXS(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __ATTCjcbVOoXMRQ632aJkXS(__ATTCjcbVOoXMRQ632aJkXS other): base(other)
            {
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__();
            }

            internal __ATTCjcbVOoXMRQ632aJkXS __WITH__()
            {
                return this;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 3640U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "K4PndZCtNHIPp47hKbO3Fk", Name = "SetActiveSender_K4PndZCtNHIPp47hKbO3Fk")]
    [n2.SerializableAttribute]
    public class SetActiveSender_K4PndZCtNHIPp47hKbO3Fk : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n3.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk Create(n1.NodeContext Node_Context)
        {
            var instance = new SetActiveSender_K4PndZCtNHIPp47hKbO3Fk(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n3.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk CreateDefault()
        {
            var instance = new SetActiveSender_K4PndZCtNHIPp47hKbO3Fk(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n3.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk Update([n4.SerializedDefaultValueAttribute("vvvv", false)] string Sender_Name_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Set_In)
        {
            n37.Spread<byte> __pad_F6AbxOHLzzQPsgpDwQTn2n_0 = __slot_F6AbxOHLzzQPsgpDwQTn2n;
            n51.Encodings Encoding_1 = __c_IAjX2Lnh5SCOrpVaHcSdgS;
            var Result_2 = n50.StringExtensions.ToBytes(input: Sender_Name_In, encoding: Encoding_1);
            n11.IEnumerable<byte> Input_3 = (n11.IEnumerable<byte>)Result_2;
            n11.IEnumerable<byte> Input_2_4 = (n11.IEnumerable<byte>)__pad_F6AbxOHLzzQPsgpDwQTn2n_0;
            n53._Operations_.Concat<byte>(Input_In: Input_3, Input_2_In: Input_2_4, Output_Out: out n11.IEnumerable<byte> Output_5);
            n16._Operations_.FromSequence<byte>(Input_In: Output_5, Result_Out: out byte[] Result_6);
            string Name_7 = "ActiveSenderName";
            var Output_10 = this.__p_Vtq8DT8ZN81OXdEeEa7o67.Update(Write_In: Set_In, Name_In: Name_7, Buffer_In: Result_6, Success_Out: out bool Success_8, Error_Out: out string Error_9);
            n3.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk that_11 = this;
            if (this.__GetContext__().IsImmutable)
                that_11 = Output_10 != this.__p_Vtq8DT8ZN81OXdEeEa7o67 ? new SetActiveSender_K4PndZCtNHIPp47hKbO3Fk(this)
                {__p_Vtq8DT8ZN81OXdEeEa7o67 = Output_10} : that_11;
            else
            {
                this.__p_Vtq8DT8ZN81OXdEeEa7o67 = Output_10;
            }

            return that_11;
        }

        public n3.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "Vtq8DT8ZN81OXdEeEa7o67", 3643U);
            var Output_1 = n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH.Create(Node_Context: Node_Context_0);
            n3.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk that_2 = this;
            this.__p_Vtq8DT8ZN81OXdEeEa7o67 = Output_1;
            return that_2;
        }

        public n3.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk __CreateDefault__()
        {
            n3.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk that_0 = this;
            this.__p_Vtq8DT8ZN81OXdEeEa7o67 = n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_Vtq8DT8ZN81OXdEeEa7o67);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 3660U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "F6AbxOHLzzQPsgpDwQTn2n", Name = "__slot_F6AbxOHLzzQPsgpDwQTn2n")]
        public static n37.Spread<byte> __slot_F6AbxOHLzzQPsgpDwQTn2n = n1.CompilationHelper.Deserialize<n37.Spread<byte>>("0", false, "CWTbJ7dBwqtLwCqXKAv402", "F6AbxOHLzzQPsgpDwQTn2n");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n51.Encodings __c_IAjX2Lnh5SCOrpVaHcSdgS = n1.CompilationHelper.Deserialize<n51.Encodings>("ASCII", false, "CWTbJ7dBwqtLwCqXKAv402", "IAjX2Lnh5SCOrpVaHcSdgS");
        [n1.ElementAttribute(TracingId = 3643U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "Vtq8DT8ZN81OXdEeEa7o67", Name = "WriteSharedMemory", IsManaged = true, IsAutoGenerated = true)]
        public n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH __p_Vtq8DT8ZN81OXdEeEa7o67;
        static SetActiveSender_K4PndZCtNHIPp47hKbO3Fk()
        {
        }

        public SetActiveSender_K4PndZCtNHIPp47hKbO3Fk(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal SetActiveSender_K4PndZCtNHIPp47hKbO3Fk(SetActiveSender_K4PndZCtNHIPp47hKbO3Fk other): base(other)
        {
            this.__p_Vtq8DT8ZN81OXdEeEa7o67 = other.__p_Vtq8DT8ZN81OXdEeEa7o67;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Vtq8DT8ZN81OXdEeEa7o67", in __p_Vtq8DT8ZN81OXdEeEa7o67));
        }

        internal SetActiveSender_K4PndZCtNHIPp47hKbO3Fk __WITH__(n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH __p_Vtq8DT8ZN81OXdEeEa7o67)
        {
            n3.SetActiveSender_K4PndZCtNHIPp47hKbO3Fk that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_Vtq8DT8ZN81OXdEeEa7o67 != this.__p_Vtq8DT8ZN81OXdEeEa7o67 ? new SetActiveSender_K4PndZCtNHIPp47hKbO3Fk(this)
                {__p_Vtq8DT8ZN81OXdEeEa7o67 = __p_Vtq8DT8ZN81OXdEeEa7o67} : that_0;
            else
            {
                this.__p_Vtq8DT8ZN81OXdEeEa7o67 = __p_Vtq8DT8ZN81OXdEeEa7o67;
            }

            return that_0;
        }
    }
}

namespace _VL_Stride_Graphics_Windows_.Stride.Textures.Spout.SpoutSender_SharedTexture
{
    [n1.ElementAttribute(TracingId = 1841U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "UZC3QR1ejxdL0alqGo8IR8", Name = "ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8")]
    [n2.SerializableAttribute]
    public class ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 Create(n1.NodeContext Node_Context)
        {
            var instance = new ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 CreateDefault()
        {
            var instance = new ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 Update(string Sender_Name_In)
        {
            byte[] __pad_V6zZDnMQXyuPBmmpkBJTfd_0 = __slot_V6zZDnMQXyuPBmmpkBJTfd;
            bool Update_1 = true;
            var State_Output_3 = this.__p_NGaZqCHvPJqLjd5o8Pn53J.Update(Update_In: Update_1, Output_Out: out string Output_2);
            var Result_4 = Sender_Name_In == Output_2;
            string Name_5 = "ActiveSenderName";
            var Output_8 = this.__p_H882uT8N79YLvfIyNcqn9I.Update(Write_In: Result_4, Name_In: Name_5, Buffer_In: __pad_V6zZDnMQXyuPBmmpkBJTfd_0, Success_Out: out bool Success_6, Error_Out: out string Error_7);
            n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 that_9 = this;
            if (this.__GetContext__().IsImmutable)
                that_9 = State_Output_3 != this.__p_NGaZqCHvPJqLjd5o8Pn53J || Output_8 != this.__p_H882uT8N79YLvfIyNcqn9I ? new ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8(this)
                {__p_NGaZqCHvPJqLjd5o8Pn53J = State_Output_3, __p_H882uT8N79YLvfIyNcqn9I = Output_8} : that_9;
            else
            {
                this.__p_NGaZqCHvPJqLjd5o8Pn53J = State_Output_3;
                this.__p_H882uT8N79YLvfIyNcqn9I = Output_8;
            }

            return that_9;
        }

        public n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "H882uT8N79YLvfIyNcqn9I", 1844U);
            var Output_1 = n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "NGaZqCHvPJqLjd5o8Pn53J", 1851U);
            var Output_3 = n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs.Create(Node_Context: Node_Context_2);
            n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 that_4 = this;
            this.__p_H882uT8N79YLvfIyNcqn9I = Output_1;
            this.__p_NGaZqCHvPJqLjd5o8Pn53J = Output_3;
            return that_4;
        }

        public n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 __CreateDefault__()
        {
            n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 that_0 = this;
            this.__p_NGaZqCHvPJqLjd5o8Pn53J = n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs.CreateDefault();
            this.__p_H882uT8N79YLvfIyNcqn9I = n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_NGaZqCHvPJqLjd5o8Pn53J);
            n1.CompilationHelper.SafeDispose(this.__p_H882uT8N79YLvfIyNcqn9I);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 1850U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "V6zZDnMQXyuPBmmpkBJTfd", Name = "__slot_V6zZDnMQXyuPBmmpkBJTfd")]
        public static byte[] __slot_V6zZDnMQXyuPBmmpkBJTfd = n1.CompilationHelper.Deserialize<byte[]>("0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0", false, "CWTbJ7dBwqtLwCqXKAv402", "V6zZDnMQXyuPBmmpkBJTfd");
        [n1.ElementAttribute(TracingId = 1851U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "NGaZqCHvPJqLjd5o8Pn53J", Name = "ActiveSender", IsManaged = true, IsAutoGenerated = true)]
        public n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs __p_NGaZqCHvPJqLjd5o8Pn53J;
        [n1.ElementAttribute(TracingId = 1844U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "H882uT8N79YLvfIyNcqn9I", Name = "WriteSharedMemory", IsManaged = true, IsAutoGenerated = true)]
        public n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH __p_H882uT8N79YLvfIyNcqn9I;
        static ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8()
        {
        }

        public ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8(ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 other): base(other)
        {
            this.__p_NGaZqCHvPJqLjd5o8Pn53J = other.__p_NGaZqCHvPJqLjd5o8Pn53J;
            this.__p_H882uT8N79YLvfIyNcqn9I = other.__p_H882uT8N79YLvfIyNcqn9I;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_NGaZqCHvPJqLjd5o8Pn53J", in __p_NGaZqCHvPJqLjd5o8Pn53J), n1.CompilationHelper.GetValueOrExisting(values, "__p_H882uT8N79YLvfIyNcqn9I", in __p_H882uT8N79YLvfIyNcqn9I));
        }

        internal ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 __WITH__(n3.ActiveSender_GP70vnZCHDTOGK77SB6cvs __p_NGaZqCHvPJqLjd5o8Pn53J, n3.WriteSharedMemory_OK6ltAN4ZU8O1dfuWgbnmH __p_H882uT8N79YLvfIyNcqn9I)
        {
            n8.ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_NGaZqCHvPJqLjd5o8Pn53J != this.__p_NGaZqCHvPJqLjd5o8Pn53J || __p_H882uT8N79YLvfIyNcqn9I != this.__p_H882uT8N79YLvfIyNcqn9I ? new ActiveSenderClearer_UZC3QR1ejxdL0alqGo8IR8(this)
                {__p_NGaZqCHvPJqLjd5o8Pn53J = __p_NGaZqCHvPJqLjd5o8Pn53J, __p_H882uT8N79YLvfIyNcqn9I = __p_H882uT8N79YLvfIyNcqn9I} : that_0;
            else
            {
                this.__p_NGaZqCHvPJqLjd5o8Pn53J = __p_NGaZqCHvPJqLjd5o8Pn53J;
                this.__p_H882uT8N79YLvfIyNcqn9I = __p_H882uT8N79YLvfIyNcqn9I;
            }

            return that_0;
        }
    }
}

namespace _VL_Stride_Graphics_Windows_.Stride.Textures
{
    [n1.ElementAttribute(TracingId = 3678U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "OoOHw5RAoRgNQ154myBJ7l", Name = "UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l")]
    [n2.SerializableAttribute]
    public class UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n22.UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l Create(n1.NodeContext Node_Context)
        {
            var instance = new UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n22.UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l CreateDefault()
        {
            var instance = new UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n22.UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l Update(n5.Texture Input_In, [n4.SerializedDefaultValueAttribute("VL.Stride", false)] string Title_In, [n4.SerializedDefaultValueAttribute("I am from VL.Stride", false)] string Description_In, [n4.SerializedDefaultValueAttribute("guest", false)] string Username_In, [n4.SerializedDefaultValueAttribute("guest", false)] string Password_In, [n4.SerializedDefaultValueAttribute("False", false)] bool Upload_In, out string Output_Out, out n5.Texture Uploaded_Texture_Out)
        {
            n14.PixelFormat __pad_QJ9hbLuYJhpLuCUADVU2JY_0 = __slot_QJ9hbLuYJhpLuCUADVU2JY;
            n21.Vector2 __pad_PXznXerEd0vQHo9Y6Fdux8_1 = __slot_PXznXerEd0vQHo9Y6Fdux8;
            n23._Operations_.TextureInfo_Basic(Input_In: Input_In, Output_Out: out n5.Texture Output_2, Size_Out: out n21.Int2 Size_3, Width_Out: out int Width_4, Height_Out: out int Height_5, Format_Out: out n14.PixelFormat Format_6, Loaded_Out: out bool Loaded_7);
            n21.Matrix Input_8 = n24._Operations_.CreateDefault();
            n25._Operations_.Scale(Input_In: Input_8, Scaling_In: __pad_PXznXerEd0vQHo9Y6Fdux8_1, Output_Out: out n21.Matrix Output_9);
            n21.Color4 Color_10 = __c_TIXeQKvqWCUOGuHWoDtpuZ;
            n5.BlendStateDescription Blend_State_11 = n26._Operations_.CreateDefault_H();
            n5.RasterizerStateDescription Rasterizer_State_12 = n27._Operations_.CreateDefault_H();
            n5.DepthStencilStateDescription Depth_Stencil_State_13 = n28._Operations_.CreateDefault_H();
            n29.SizeMode Aspect_Ratio_Correction_Mode_14 = __c_BFpJQicEy0NOHlM4ftPki5;
            n29.RectangleAnchor Anchor_15 = __c_PPAEqBdyUmmLMczpGZDUkT;
            var State_Output_17 = this.__p_HVj14qmEGPKOXSrYictRi5.Update(Transformation_In: Output_9, Texture_In: Input_In, Color_In: Color_10, Blend_State_In: Blend_State_11, Rasterizer_State_In: Rasterizer_State_12, Depth_Stencil_State_In: Depth_Stencil_State_13, Aspect_Ratio_Correction_Mode_In: Aspect_Ratio_Correction_Mode_14, Anchor_In: Anchor_15, Output_Out: out n15.MeshRenderer_C Output_16);
            n30.IGraphicsRendererBase Input_18 = (n30.IGraphicsRendererBase)Output_16;
            n21.Matrix View_19 = __c_IAC15dIJVTJNFjxtYj1xbA;
            n21.Matrix Projection_20 = n24._Operations_.CreateDefault();
            float Near_Plane_21 = 0.05F;
            float Far_Plane_22 = 100F;
            var State_Output_24 = this.__p_GGpnXkpF5ZmLYBzsCbpI7g.Update(View_In: View_19, Projection_In: Projection_20, Near_Plane_In: Near_Plane_21, Far_Plane_In: Far_Plane_22, Output_Out: out n30.RenderView Output_23);
            var Output_27 = this.__p_ESsWzMdNcJCPpuRp4MME51.Update(Value_In: Upload_In, Up_Edge_Out: out bool Up_Edge_25, Down_Edge_Out: out bool Down_Edge_26);
            bool Color_Shared_28 = false;
            n14.PixelFormat Depth_Format_29 = __c_NTki3EYrTbMLDIkaBniAT1;
            bool Depth_Shared_30 = false;
            n30.ClearRendererFlags Clear_Flags_31 = default(n30.ClearRendererFlags);
            n21.Color4 Clear_Color_32 = __c_KuLtn9cadqROQAEUJJXAVy;
            float Clear_Depth_33 = 1F;
            byte Clear_Stencil_34 = 0;
            bool Clear_35 = true;
            var Output_39 = this.__p_IPTzAje68hpQLh9wWCS0xi.Update(Input_In: Input_18, Size_In: Size_3, Render_View_In: Output_23, Format_In: __pad_QJ9hbLuYJhpLuCUADVU2JY_0, Color_Shared_In: Color_Shared_28, Depth_Format_In: Depth_Format_29, Depth_Shared_In: Depth_Shared_30, Clear_Flags_In: Clear_Flags_31, Clear_Color_In: Clear_Color_32, Clear_Depth_In: Clear_Depth_33, Clear_Stencil_In: Clear_Stencil_34, Clear_In: Clear_35, Auto_Render_In: Up_Edge_25, Layer_Out: out n32.WithRenderTargetAndViewPort Layer_36, Color_Out: out n5.Texture Color_37, Depth_Out: out n5.Texture Depth_38);
            var Output_41 = this.__p_Ek8kSpkjbJlPIyrWvMqDxz.GetValue(Value_Out: out bool Value_40);
            bool SetValue_42 = true;
            var Output_43 = Output_41;
            if (SetValue_42)
            {
                Output_43 = Output_41.SetValue(Value_In: Up_Edge_25);
            }

            bool Dispose_Cached_Outputs_44 = false;
            var manager_45 = this.__cache_AjQJrkPTb46M46S7Hr4owo;
            if (manager_45 is null)
            {
                manager_45 = new n7.Manager<n2.ValueTuple, n2.ValueTuple<string>>(n2.ValueTuple.Create(""));
            }

            var inputs_46 = n2.ValueTuple.Create();
            var outputs_47 = manager_45.Outputs;
            var Has_Changed_48 = Value_40 || manager_45.InputsChanged(inputs_46);
            if (Has_Changed_48)
            {
                if (Dispose_Cached_Outputs_44)
                    manager_45.DisposeOutputs();
                var state_49 = n1.CompilationHelper.Restore<__UJdOBqzG7JzM1n7cIwJpT6>(manager_45.State, __GetContext__());
                if (state_49 == null)
                {
                    state_49 = new __UJdOBqzG7JzM1n7cIwJpT6(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_50 = __GetContext__().CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "IEfoGjZ1DVdNlth7aJ8tjx", 3700U);
                    var Output_51 = n33.GraphicsContext_LZGVLOdpi83QS6XklGOZVK.Create(Node_Context_In: Node_Context_50);
                    state_49.__p_IEfoGjZ1DVdNlth7aJ8tjx = Output_51;
                }

                var State_Output_53 = state_49.__p_IEfoGjZ1DVdNlth7aJ8tjx.Update(Output_Out: out n5.GraphicsContext Output_52);
                var Command_List_54 = Output_52.CommandList;
                var Result_55 = n34.UploadScreenshot.UploadTextureToVVVVOrg(input: Color_37, commandList: Command_List_54, title: Title_In, description: Description_In, username: Username_In, password: Password_In);
                if (state_49.__GetContext__().IsImmutable)
                    state_49 = State_Output_53 != state_49.__p_IEfoGjZ1DVdNlth7aJ8tjx ? new __UJdOBqzG7JzM1n7cIwJpT6(state_49)
                    {__p_IEfoGjZ1DVdNlth7aJ8tjx = State_Output_53} : state_49;
                else
                {
                    state_49.__p_IEfoGjZ1DVdNlth7aJ8tjx = State_Output_53;
                }

                outputs_47 = n2.ValueTuple.Create(Result_55);
                manager_45 = manager_45.Update(inputs_46, __GetContext__().IsImmutable, Dispose_Cached_Outputs_44, state_49, outputs_47);
            }
            else
            {
                manager_45.Update(inputs_46, __GetContext__().IsImmutable, Dispose_Cached_Outputs_44);
            }

            var __auto_56 = outputs_47.Item1;
            Output_Out = __auto_56;
            Uploaded_Texture_Out = Color_37;
            n22.UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l that_57 = this;
            if (this.__GetContext__().IsImmutable)
                that_57 = State_Output_17 != this.__p_HVj14qmEGPKOXSrYictRi5 || State_Output_24 != this.__p_GGpnXkpF5ZmLYBzsCbpI7g || Output_27 != this.__p_ESsWzMdNcJCPpuRp4MME51 || Output_39 != this.__p_IPTzAje68hpQLh9wWCS0xi || Output_43 != this.__p_Ek8kSpkjbJlPIyrWvMqDxz || manager_45 != this.__cache_AjQJrkPTb46M46S7Hr4owo ? new UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l(this)
                {__p_HVj14qmEGPKOXSrYictRi5 = State_Output_17, __p_GGpnXkpF5ZmLYBzsCbpI7g = State_Output_24, __p_ESsWzMdNcJCPpuRp4MME51 = Output_27, __p_IPTzAje68hpQLh9wWCS0xi = Output_39, __p_Ek8kSpkjbJlPIyrWvMqDxz = Output_43, __cache_AjQJrkPTb46M46S7Hr4owo = manager_45} : that_57;
            else
            {
                this.__p_HVj14qmEGPKOXSrYictRi5 = State_Output_17;
                this.__p_GGpnXkpF5ZmLYBzsCbpI7g = State_Output_24;
                this.__p_ESsWzMdNcJCPpuRp4MME51 = Output_27;
                this.__p_IPTzAje68hpQLh9wWCS0xi = Output_39;
                this.__p_Ek8kSpkjbJlPIyrWvMqDxz = Output_43;
                this.__cache_AjQJrkPTb46M46S7Hr4owo = manager_45;
            }

            return that_57;
        }

        public n22.UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n1.NodeContext Node_Context_0 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "IPTzAje68hpQLh9wWCS0xi", 3710U);
            var Output_1 = n35.RenderTexture_IYQobGzVbWEQYcMFud8H4J.Create(Node_Context: Node_Context_0);
            n1.NodeContext Node_Context_2 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "HVj14qmEGPKOXSrYictRi5", 3731U);
            var Output_3 = n36.QuadRenderer_THN6uQm7kG3OaRum91XHwL.Create(Node_Context: Node_Context_2);
            n1.NodeContext Node_Context_4 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "GGpnXkpF5ZmLYBzsCbpI7g", 3746U);
            var Output_5 = n15.RenderView_NalvfCkTVBPN12jxpmho9b.Create(Node_Context: Node_Context_4);
            n1.NodeContext Node_Context_6 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "Ek8kSpkjbJlPIyrWvMqDxz", 3752U);
            bool Initial_Value_7 = false;
            var Output_8 = n39.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool>.Create(Node_Context: Node_Context_6, Initial_Value_In: Initial_Value_7);
            n1.NodeContext Node_Context_9 = Node_Context.CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "ESsWzMdNcJCPpuRp4MME51", 3756U);
            var Output_10 = n39.TogEdge_GJoUlOOEtqiM4g67HVecyr.Create(Node_Context: Node_Context_9);
            n22.UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l that_11 = this;
            this.__p_IPTzAje68hpQLh9wWCS0xi = Output_1;
            this.__p_HVj14qmEGPKOXSrYictRi5 = Output_3;
            this.__p_GGpnXkpF5ZmLYBzsCbpI7g = Output_5;
            this.__p_Ek8kSpkjbJlPIyrWvMqDxz = Output_8;
            this.__p_ESsWzMdNcJCPpuRp4MME51 = Output_10;
            this.__cache_AjQJrkPTb46M46S7Hr4owo = null;
            return that_11;
        }

        public n22.UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l __CreateDefault__()
        {
            n22.UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l that_0 = this;
            this.__p_HVj14qmEGPKOXSrYictRi5 = n36.QuadRenderer_THN6uQm7kG3OaRum91XHwL.CreateDefault();
            this.__p_GGpnXkpF5ZmLYBzsCbpI7g = n15.RenderView_NalvfCkTVBPN12jxpmho9b.CreateDefault();
            this.__p_ESsWzMdNcJCPpuRp4MME51 = n39.TogEdge_GJoUlOOEtqiM4g67HVecyr.CreateDefault();
            this.__p_IPTzAje68hpQLh9wWCS0xi = n35.RenderTexture_IYQobGzVbWEQYcMFud8H4J.CreateDefault();
            this.__p_Ek8kSpkjbJlPIyrWvMqDxz = n39.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool>.CreateDefault();
            this.__cache_AjQJrkPTb46M46S7Hr4owo = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__p_HVj14qmEGPKOXSrYictRi5);
            n1.CompilationHelper.SafeDispose(this.__p_GGpnXkpF5ZmLYBzsCbpI7g);
            n1.CompilationHelper.SafeDispose(this.__p_ESsWzMdNcJCPpuRp4MME51);
            n1.CompilationHelper.SafeDispose(this.__p_IPTzAje68hpQLh9wWCS0xi);
            n1.CompilationHelper.SafeDispose(this.__p_Ek8kSpkjbJlPIyrWvMqDxz);
            n1.CompilationHelper.SafeDispose(this.__cache_AjQJrkPTb46M46S7Hr4owo);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 3730U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "QJ9hbLuYJhpLuCUADVU2JY", Name = "__slot_QJ9hbLuYJhpLuCUADVU2JY")]
        public static n14.PixelFormat __slot_QJ9hbLuYJhpLuCUADVU2JY = n1.CompilationHelper.Deserialize<n14.PixelFormat>("R8G8B8A8_UNorm_SRgb", false, "CWTbJ7dBwqtLwCqXKAv402", "QJ9hbLuYJhpLuCUADVU2JY");
        [n1.ElementAttribute(TracingId = 3745U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "PXznXerEd0vQHo9Y6Fdux8", Name = "__slot_PXznXerEd0vQHo9Y6Fdux8")]
        public static n21.Vector2 __slot_PXznXerEd0vQHo9Y6Fdux8 = n1.CompilationHelper.Deserialize<n21.Vector2>("2, 2", false, "CWTbJ7dBwqtLwCqXKAv402", "PXznXerEd0vQHo9Y6Fdux8");
        [n1.ElementAttribute(TracingId = 3731U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "HVj14qmEGPKOXSrYictRi5", Name = "QuadRenderer", IsManaged = true, IsAutoGenerated = true)]
        public n36.QuadRenderer_THN6uQm7kG3OaRum91XHwL __p_HVj14qmEGPKOXSrYictRi5;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n21.Color4 __c_TIXeQKvqWCUOGuHWoDtpuZ = n1.CompilationHelper.Deserialize<n21.Color4>("1, 1, 1, 1", false, "CWTbJ7dBwqtLwCqXKAv402", "TIXeQKvqWCUOGuHWoDtpuZ");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n29.SizeMode __c_BFpJQicEy0NOHlM4ftPki5 = n1.CompilationHelper.Deserialize<n29.SizeMode>("Size", false, "CWTbJ7dBwqtLwCqXKAv402", "BFpJQicEy0NOHlM4ftPki5");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n29.RectangleAnchor __c_PPAEqBdyUmmLMczpGZDUkT = n1.CompilationHelper.Deserialize<n29.RectangleAnchor>("Center", false, "CWTbJ7dBwqtLwCqXKAv402", "PPAEqBdyUmmLMczpGZDUkT");
        [n1.ElementAttribute(TracingId = 3746U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "GGpnXkpF5ZmLYBzsCbpI7g", Name = "RenderView", IsManaged = true, IsAutoGenerated = true)]
        public n15.RenderView_NalvfCkTVBPN12jxpmho9b __p_GGpnXkpF5ZmLYBzsCbpI7g;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n21.Matrix __c_IAC15dIJVTJNFjxtYj1xbA = n1.CompilationHelper.Deserialize<n21.Matrix>("1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1", false, "CWTbJ7dBwqtLwCqXKAv402", "IAC15dIJVTJNFjxtYj1xbA");
        [n1.ElementAttribute(TracingId = 3756U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "ESsWzMdNcJCPpuRp4MME51", Name = "TogEdge", IsManaged = true, IsAutoGenerated = true)]
        public n39.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_ESsWzMdNcJCPpuRp4MME51;
        [n1.ElementAttribute(TracingId = 3710U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "IPTzAje68hpQLh9wWCS0xi", Name = "RenderTexture", IsManaged = true, IsAutoGenerated = true)]
        public n35.RenderTexture_IYQobGzVbWEQYcMFud8H4J __p_IPTzAje68hpQLh9wWCS0xi;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n14.PixelFormat __c_NTki3EYrTbMLDIkaBniAT1 = n1.CompilationHelper.Deserialize<n14.PixelFormat>("D24_UNorm_S8_UInt", false, "CWTbJ7dBwqtLwCqXKAv402", "NTki3EYrTbMLDIkaBniAT1");
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public static n21.Color4 __c_KuLtn9cadqROQAEUJJXAVy = n1.CompilationHelper.Deserialize<n21.Color4>("0, 0, 0, 1", false, "CWTbJ7dBwqtLwCqXKAv402", "KuLtn9cadqROQAEUJJXAVy");
        [n1.ElementAttribute(TracingId = 3752U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "Ek8kSpkjbJlPIyrWvMqDxz", Name = "FrameDelay", IsManaged = true, IsAutoGenerated = true)]
        public n39.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool> __p_Ek8kSpkjbJlPIyrWvMqDxz;
        [n1.ElementAttribute(TracingId = 3681U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "AjQJrkPTb46M46S7Hr4owo", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple, n2.ValueTuple<string>> __cache_AjQJrkPTb46M46S7Hr4owo = null;
        static UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l()
        {
        }

        public UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l(UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l other): base(other)
        {
            this.__p_HVj14qmEGPKOXSrYictRi5 = other.__p_HVj14qmEGPKOXSrYictRi5;
            this.__p_GGpnXkpF5ZmLYBzsCbpI7g = other.__p_GGpnXkpF5ZmLYBzsCbpI7g;
            this.__p_ESsWzMdNcJCPpuRp4MME51 = other.__p_ESsWzMdNcJCPpuRp4MME51;
            this.__p_IPTzAje68hpQLh9wWCS0xi = other.__p_IPTzAje68hpQLh9wWCS0xi;
            this.__p_Ek8kSpkjbJlPIyrWvMqDxz = other.__p_Ek8kSpkjbJlPIyrWvMqDxz;
            this.__cache_AjQJrkPTb46M46S7Hr4owo = other.__cache_AjQJrkPTb46M46S7Hr4owo;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_HVj14qmEGPKOXSrYictRi5", in __p_HVj14qmEGPKOXSrYictRi5), n1.CompilationHelper.GetValueOrExisting(values, "__p_GGpnXkpF5ZmLYBzsCbpI7g", in __p_GGpnXkpF5ZmLYBzsCbpI7g), n1.CompilationHelper.GetValueOrExisting(values, "__p_ESsWzMdNcJCPpuRp4MME51", in __p_ESsWzMdNcJCPpuRp4MME51), n1.CompilationHelper.GetValueOrExisting(values, "__p_IPTzAje68hpQLh9wWCS0xi", in __p_IPTzAje68hpQLh9wWCS0xi), n1.CompilationHelper.GetValueOrExisting(values, "__p_Ek8kSpkjbJlPIyrWvMqDxz", in __p_Ek8kSpkjbJlPIyrWvMqDxz), n1.CompilationHelper.GetValueOrExisting(values, "__cache_AjQJrkPTb46M46S7Hr4owo", in __cache_AjQJrkPTb46M46S7Hr4owo));
        }

        internal UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l __WITH__(n36.QuadRenderer_THN6uQm7kG3OaRum91XHwL __p_HVj14qmEGPKOXSrYictRi5, n15.RenderView_NalvfCkTVBPN12jxpmho9b __p_GGpnXkpF5ZmLYBzsCbpI7g, n39.TogEdge_GJoUlOOEtqiM4g67HVecyr __p_ESsWzMdNcJCPpuRp4MME51, n35.RenderTexture_IYQobGzVbWEQYcMFud8H4J __p_IPTzAje68hpQLh9wWCS0xi, n39.FrameDelay_VYPkCl1PIexL9IROxeL6ju<bool> __p_Ek8kSpkjbJlPIyrWvMqDxz, n7.Manager<n2.ValueTuple, n2.ValueTuple<string>> __cache_AjQJrkPTb46M46S7Hr4owo)
        {
            n22.UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __p_HVj14qmEGPKOXSrYictRi5 != this.__p_HVj14qmEGPKOXSrYictRi5 || __p_GGpnXkpF5ZmLYBzsCbpI7g != this.__p_GGpnXkpF5ZmLYBzsCbpI7g || __p_ESsWzMdNcJCPpuRp4MME51 != this.__p_ESsWzMdNcJCPpuRp4MME51 || __p_IPTzAje68hpQLh9wWCS0xi != this.__p_IPTzAje68hpQLh9wWCS0xi || __p_Ek8kSpkjbJlPIyrWvMqDxz != this.__p_Ek8kSpkjbJlPIyrWvMqDxz || __cache_AjQJrkPTb46M46S7Hr4owo != this.__cache_AjQJrkPTb46M46S7Hr4owo ? new UploadToVVVVOrg_OoOHw5RAoRgNQ154myBJ7l(this)
                {__p_HVj14qmEGPKOXSrYictRi5 = __p_HVj14qmEGPKOXSrYictRi5, __p_GGpnXkpF5ZmLYBzsCbpI7g = __p_GGpnXkpF5ZmLYBzsCbpI7g, __p_ESsWzMdNcJCPpuRp4MME51 = __p_ESsWzMdNcJCPpuRp4MME51, __p_IPTzAje68hpQLh9wWCS0xi = __p_IPTzAje68hpQLh9wWCS0xi, __p_Ek8kSpkjbJlPIyrWvMqDxz = __p_Ek8kSpkjbJlPIyrWvMqDxz, __cache_AjQJrkPTb46M46S7Hr4owo = __cache_AjQJrkPTb46M46S7Hr4owo} : that_0;
            else
            {
                this.__p_HVj14qmEGPKOXSrYictRi5 = __p_HVj14qmEGPKOXSrYictRi5;
                this.__p_GGpnXkpF5ZmLYBzsCbpI7g = __p_GGpnXkpF5ZmLYBzsCbpI7g;
                this.__p_ESsWzMdNcJCPpuRp4MME51 = __p_ESsWzMdNcJCPpuRp4MME51;
                this.__p_IPTzAje68hpQLh9wWCS0xi = __p_IPTzAje68hpQLh9wWCS0xi;
                this.__p_Ek8kSpkjbJlPIyrWvMqDxz = __p_Ek8kSpkjbJlPIyrWvMqDxz;
                this.__cache_AjQJrkPTb46M46S7Hr4owo = __cache_AjQJrkPTb46M46S7Hr4owo;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "UJdOBqzG7JzM1n7cIwJpT6", Name = "__UJdOBqzG7JzM1n7cIwJpT6")]
        [n2.SerializableAttribute]
        public class __UJdOBqzG7JzM1n7cIwJpT6 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_IEfoGjZ1DVdNlth7aJ8tjx);
                return;
            }

            [n1.ElementAttribute(TracingId = 3700U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "IEfoGjZ1DVdNlth7aJ8tjx", Name = "GraphicsContext", IsManaged = true, IsAutoGenerated = true)]
            public n33.GraphicsContext_LZGVLOdpi83QS6XklGOZVK __p_IEfoGjZ1DVdNlth7aJ8tjx;
            public __UJdOBqzG7JzM1n7cIwJpT6(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __UJdOBqzG7JzM1n7cIwJpT6(__UJdOBqzG7JzM1n7cIwJpT6 other): base(other)
            {
                this.__p_IEfoGjZ1DVdNlth7aJ8tjx = other.__p_IEfoGjZ1DVdNlth7aJ8tjx;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_IEfoGjZ1DVdNlth7aJ8tjx", in __p_IEfoGjZ1DVdNlth7aJ8tjx));
            }

            internal __UJdOBqzG7JzM1n7cIwJpT6 __WITH__(n33.GraphicsContext_LZGVLOdpi83QS6XklGOZVK __p_IEfoGjZ1DVdNlth7aJ8tjx)
            {
                __UJdOBqzG7JzM1n7cIwJpT6 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_IEfoGjZ1DVdNlth7aJ8tjx != this.__p_IEfoGjZ1DVdNlth7aJ8tjx ? new __UJdOBqzG7JzM1n7cIwJpT6(this)
                    {__p_IEfoGjZ1DVdNlth7aJ8tjx = __p_IEfoGjZ1DVdNlth7aJ8tjx} : that_0;
                else
                {
                    this.__p_IEfoGjZ1DVdNlth7aJ8tjx = __p_IEfoGjZ1DVdNlth7aJ8tjx;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Stride_Graphics_Windows_.Stride.Graphics.Texture.Advanced
{
    [n1.ElementAttribute(TracingId = 3806U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "Uje1mp1ZQS9MiWnGjYtyAz", Name = "FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz")]
    [n2.SerializableAttribute]
    public class FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n41.FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz Create(n1.NodeContext Node_Context)
        {
            var instance = new FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n41.FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz CreateDefault()
        {
            var instance = new FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n41.FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz Update(n42.Texture2D Native_Texture_In, out n5.Texture Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = false;
            var manager_2 = this.__cache_T2v44Phhq3nQD513uCeI8s;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n42.Texture2D>, n2.ValueTuple<n5.Texture>>(n2.ValueTuple.Create(default(n5.Texture)));
            }

            var inputs_3 = n2.ValueTuple.Create(Native_Texture_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__VKlQPiDr9MPM9PEi18xNm4>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __VKlQPiDr9MPM9PEi18xNm4(__GetContext__(), n1.VLObject.NewIdentity());
                }

                n9.ObjectHelpers.IsAssigned(x: Native_Texture_In, result: out bool Result_7, notAssigned: out bool Not_Assigned_8);
                n5.Texture __auto_9;
                var state_10 = n1.CompilationHelper.Restore<__EdRN5c2mvAXOXPiQpZRRdH>(state_6.__if_TlmAtYNqp1LLt1b7D5YzVc, __GetContext__());
                if (Result_7)
                {
                    if (state_10 == null)
                    {
                        state_10 = new __EdRN5c2mvAXOXPiQpZRRdH(__GetContext__(), n1.VLObject.NewIdentity());
                        n1.NodeContext Node_Context_11 = __GetContext__().CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "Uo9P6Z6hvAbMI1qkNBMgZ8", 3835U);
                        var Output_12 = n33.GraphicsDevice_V0mXf77TurpOVQNzgviejb.Create(Node_Context_In: Node_Context_11);
                        state_10.__p_Uo9P6Z6hvAbMI1qkNBMgZ8 = Output_12;
                    }

                    var State_Output_14 = state_10.__p_Uo9P6Z6hvAbMI1qkNBMgZ8.Update(Output_Out: out n5.GraphicsDevice Output_13);
                    bool Take_Ownership_15 = false;
                    bool Is_SRgb_16 = false;
                    var Result_17 = n5.SharpDXInterop.CreateTextureFromNative(device: Output_13, dxTexture2D: Native_Texture_In, takeOwnership: Take_Ownership_15, isSRgb: Is_SRgb_16);
                    __auto_9 = Result_17;
                    if (state_10.__GetContext__().IsImmutable)
                        state_10 = State_Output_14 != state_10.__p_Uo9P6Z6hvAbMI1qkNBMgZ8 ? new __EdRN5c2mvAXOXPiQpZRRdH(state_10)
                        {__p_Uo9P6Z6hvAbMI1qkNBMgZ8 = State_Output_14} : state_10;
                    else
                    {
                        state_10.__p_Uo9P6Z6hvAbMI1qkNBMgZ8 = State_Output_14;
                    }
                }
                else
                {
                    __auto_9 = default(n5.Texture);
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = state_10 != state_6.__if_TlmAtYNqp1LLt1b7D5YzVc ? new __VKlQPiDr9MPM9PEi18xNm4(state_6)
                    {__if_TlmAtYNqp1LLt1b7D5YzVc = state_10} : state_6;
                else
                {
                    state_6.__if_TlmAtYNqp1LLt1b7D5YzVc = state_10;
                }

                outputs_4 = n2.ValueTuple.Create(__auto_9);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_18 = outputs_4.Item1;
            Output_Out = __auto_18;
            n41.FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz that_19 = this;
            if (this.__GetContext__().IsImmutable)
                that_19 = manager_2 != this.__cache_T2v44Phhq3nQD513uCeI8s ? new FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz(this)
                {__cache_T2v44Phhq3nQD513uCeI8s = manager_2} : that_19;
            else
            {
                this.__cache_T2v44Phhq3nQD513uCeI8s = manager_2;
            }

            return that_19;
        }

        public n41.FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n41.FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz that_0 = this;
            this.__cache_T2v44Phhq3nQD513uCeI8s = null;
            return that_0;
        }

        public n41.FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz __CreateDefault__()
        {
            n41.FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz that_0 = this;
            this.__cache_T2v44Phhq3nQD513uCeI8s = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_T2v44Phhq3nQD513uCeI8s);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 3809U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "T2v44Phhq3nQD513uCeI8s", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n42.Texture2D>, n2.ValueTuple<n5.Texture>> __cache_T2v44Phhq3nQD513uCeI8s = null;
        public FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz(FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz other): base(other)
        {
            this.__cache_T2v44Phhq3nQD513uCeI8s = other.__cache_T2v44Phhq3nQD513uCeI8s;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_T2v44Phhq3nQD513uCeI8s", in __cache_T2v44Phhq3nQD513uCeI8s));
        }

        internal FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz __WITH__(n7.Manager<n2.ValueTuple<n42.Texture2D>, n2.ValueTuple<n5.Texture>> __cache_T2v44Phhq3nQD513uCeI8s)
        {
            n41.FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_T2v44Phhq3nQD513uCeI8s != this.__cache_T2v44Phhq3nQD513uCeI8s ? new FromNativeTexture_Uje1mp1ZQS9MiWnGjYtyAz(this)
                {__cache_T2v44Phhq3nQD513uCeI8s = __cache_T2v44Phhq3nQD513uCeI8s} : that_0;
            else
            {
                this.__cache_T2v44Phhq3nQD513uCeI8s = __cache_T2v44Phhq3nQD513uCeI8s;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "VKlQPiDr9MPM9PEi18xNm4", Name = "__VKlQPiDr9MPM9PEi18xNm4")]
        [n2.SerializableAttribute]
        public class __VKlQPiDr9MPM9PEi18xNm4 : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__if_TlmAtYNqp1LLt1b7D5YzVc);
                return;
            }

            [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
            public n2.Object __if_TlmAtYNqp1LLt1b7D5YzVc;
            public __VKlQPiDr9MPM9PEi18xNm4(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __VKlQPiDr9MPM9PEi18xNm4(__VKlQPiDr9MPM9PEi18xNm4 other): base(other)
            {
                this.__if_TlmAtYNqp1LLt1b7D5YzVc = other.__if_TlmAtYNqp1LLt1b7D5YzVc;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__if_TlmAtYNqp1LLt1b7D5YzVc", in __if_TlmAtYNqp1LLt1b7D5YzVc));
            }

            internal __VKlQPiDr9MPM9PEi18xNm4 __WITH__(n2.Object __if_TlmAtYNqp1LLt1b7D5YzVc)
            {
                __VKlQPiDr9MPM9PEi18xNm4 that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __if_TlmAtYNqp1LLt1b7D5YzVc != this.__if_TlmAtYNqp1LLt1b7D5YzVc ? new __VKlQPiDr9MPM9PEi18xNm4(this)
                    {__if_TlmAtYNqp1LLt1b7D5YzVc = __if_TlmAtYNqp1LLt1b7D5YzVc} : that_0;
                else
                {
                    this.__if_TlmAtYNqp1LLt1b7D5YzVc = __if_TlmAtYNqp1LLt1b7D5YzVc;
                }

                return that_0;
            }
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "EdRN5c2mvAXOXPiQpZRRdH", Name = "__EdRN5c2mvAXOXPiQpZRRdH")]
        [n2.SerializableAttribute]
        public class __EdRN5c2mvAXOXPiQpZRRdH : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_Uo9P6Z6hvAbMI1qkNBMgZ8);
                return;
            }

            [n1.ElementAttribute(TracingId = 3835U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "Uo9P6Z6hvAbMI1qkNBMgZ8", Name = "GraphicsDevice", IsManaged = true, IsAutoGenerated = true)]
            public n33.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_Uo9P6Z6hvAbMI1qkNBMgZ8;
            public __EdRN5c2mvAXOXPiQpZRRdH(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __EdRN5c2mvAXOXPiQpZRRdH(__EdRN5c2mvAXOXPiQpZRRdH other): base(other)
            {
                this.__p_Uo9P6Z6hvAbMI1qkNBMgZ8 = other.__p_Uo9P6Z6hvAbMI1qkNBMgZ8;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_Uo9P6Z6hvAbMI1qkNBMgZ8", in __p_Uo9P6Z6hvAbMI1qkNBMgZ8));
            }

            internal __EdRN5c2mvAXOXPiQpZRRdH __WITH__(n33.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_Uo9P6Z6hvAbMI1qkNBMgZ8)
            {
                __EdRN5c2mvAXOXPiQpZRRdH that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_Uo9P6Z6hvAbMI1qkNBMgZ8 != this.__p_Uo9P6Z6hvAbMI1qkNBMgZ8 ? new __EdRN5c2mvAXOXPiQpZRRdH(this)
                    {__p_Uo9P6Z6hvAbMI1qkNBMgZ8 = __p_Uo9P6Z6hvAbMI1qkNBMgZ8} : that_0;
                else
                {
                    this.__p_Uo9P6Z6hvAbMI1qkNBMgZ8 = __p_Uo9P6Z6hvAbMI1qkNBMgZ8;
                }

                return that_0;
            }
        }
    }

    [n1.ElementAttribute(TracingId = 3857U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "JhCoWFfyhrdNGNVPfy0KHo", Name = "FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo")]
    [n2.SerializableAttribute]
    public class FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n41.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo Create(n1.NodeContext Node_Context)
        {
            var instance = new FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n41.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo CreateDefault()
        {
            var instance = new FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n41.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo Update(n2.IntPtr Texture_Handle_In, out n5.Texture Output_Out)
        {
            bool Force_0 = false;
            bool Dispose_Cached_Outputs_1 = true;
            var manager_2 = this.__cache_PphpQPfSfscOgWflWKiKNR;
            if (manager_2 is null)
            {
                manager_2 = new n7.Manager<n2.ValueTuple<n2.IntPtr>, n2.ValueTuple<n5.Texture>>(n2.ValueTuple.Create(default(n5.Texture)));
            }

            var inputs_3 = n2.ValueTuple.Create(Texture_Handle_In);
            var outputs_4 = manager_2.Outputs;
            var Has_Changed_5 = Force_0 || manager_2.InputsChanged(inputs_3);
            if (Has_Changed_5)
            {
                if (Dispose_Cached_Outputs_1)
                    manager_2.DisposeOutputs();
                var state_6 = n1.CompilationHelper.Restore<__UNHQc4cl6HSNTjvehB22mp>(manager_2.State, __GetContext__());
                if (state_6 == null)
                {
                    state_6 = new __UNHQc4cl6HSNTjvehB22mp(__GetContext__(), n1.VLObject.NewIdentity());
                    n1.NodeContext Node_Context_7 = __GetContext__().CreateSubContext("CWTbJ7dBwqtLwCqXKAv402", "FZmVfZozt32MG8xSCPXtze", 3878U);
                    var Output_8 = n33.GraphicsDevice_V0mXf77TurpOVQNzgviejb.Create(Node_Context_In: Node_Context_7);
                    state_6.__p_FZmVfZozt32MG8xSCPXtze = Output_8;
                }

                var State_Output_10 = state_6.__p_FZmVfZozt32MG8xSCPXtze.Update(Output_Out: out n5.GraphicsDevice Output_9);
                var Result_11 = n5.SharpDXInterop.GetNativeDevice(device: Output_9);
                n42.Device Default_12 = default(n42.Device);
                n44._Operations_.CastAs<n42.Device>(Input_In: Result_11, Default_In: Default_12, Result_Out: out n42.Device Result_13, Success_Out: out bool Success_14);
                n2.IntPtr Input_2_15 = n31._Operations_.CreateDefault();
                var Result_16 = Texture_Handle_In != Input_2_15;
                var Output_17 = Success_14 && Result_16;
                n5.Texture __auto_18;
                if (Output_17)
                {
                    var __fallback___20 = n1.ServiceRegistry.Current;
                    n45._Operations_.TryCatch_Stateless<n5.Texture>(Try_In: () =>
                    {
                        using var __current_21 = __fallback___20.MakeCurrentIfNone();
                        var Result_22 = Result_13.OpenSharedResource<n42.Texture2D>(resourceHandle: Texture_Handle_In);
                        n42.Texture2D __pad_ExdUMGuCTYdPisnBriAfdU_23 = Result_22;
                        bool Take_Ownership_24 = true;
                        bool Is_SRgb_25 = false;
                        var Result_26 = n5.SharpDXInterop.CreateTextureFromNative(device: Output_9, dxTexture2D: __pad_ExdUMGuCTYdPisnBriAfdU_23, takeOwnership: Take_Ownership_24, isSRgb: Is_SRgb_25);
                        return Result_26;
                    }

                    , Catch_In: (n2.Exception Input_In_28) =>
                    {
                        using var __current_27 = __fallback___20.MakeCurrentIfNone();
                        return default(n5.Texture);
                    }

                    , Result_Out: out n5.Texture Result_29);
                    __auto_18 = Result_29;
                }
                else
                {
                    __auto_18 = default(n5.Texture);
                }

                if (state_6.__GetContext__().IsImmutable)
                    state_6 = State_Output_10 != state_6.__p_FZmVfZozt32MG8xSCPXtze ? new __UNHQc4cl6HSNTjvehB22mp(state_6)
                    {__p_FZmVfZozt32MG8xSCPXtze = State_Output_10} : state_6;
                else
                {
                    state_6.__p_FZmVfZozt32MG8xSCPXtze = State_Output_10;
                }

                outputs_4 = n2.ValueTuple.Create(__auto_18);
                manager_2 = manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1, state_6, outputs_4);
            }
            else
            {
                manager_2.Update(inputs_3, __GetContext__().IsImmutable, Dispose_Cached_Outputs_1);
            }

            var __auto_30 = outputs_4.Item1;
            Output_Out = __auto_30;
            n41.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo that_31 = this;
            if (this.__GetContext__().IsImmutable)
                that_31 = manager_2 != this.__cache_PphpQPfSfscOgWflWKiKNR ? new FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo(this)
                {__cache_PphpQPfSfscOgWflWKiKNR = manager_2} : that_31;
            else
            {
                this.__cache_PphpQPfSfscOgWflWKiKNR = manager_2;
            }

            return that_31;
        }

        public n41.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            n41.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo that_0 = this;
            this.__cache_PphpQPfSfscOgWflWKiKNR = null;
            return that_0;
        }

        public n41.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo __CreateDefault__()
        {
            n41.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo that_0 = this;
            this.__cache_PphpQPfSfscOgWflWKiKNR = null;
            return that_0;
        }

        public void Dispose()
        {
            n1.CompilationHelper.SafeDispose(this.__cache_PphpQPfSfscOgWflWKiKNR);
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        [n1.ElementAttribute(TracingId = 3861U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "PphpQPfSfscOgWflWKiKNR", Name = "Cache", IsManaged = true, IsAutoGenerated = true)]
        public n7.Manager<n2.ValueTuple<n2.IntPtr>, n2.ValueTuple<n5.Texture>> __cache_PphpQPfSfscOgWflWKiKNR = null;
        public FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo(FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo other): base(other)
        {
            this.__cache_PphpQPfSfscOgWflWKiKNR = other.__cache_PphpQPfSfscOgWflWKiKNR;
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__cache_PphpQPfSfscOgWflWKiKNR", in __cache_PphpQPfSfscOgWflWKiKNR));
        }

        internal FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo __WITH__(n7.Manager<n2.ValueTuple<n2.IntPtr>, n2.ValueTuple<n5.Texture>> __cache_PphpQPfSfscOgWflWKiKNR)
        {
            n41.FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __cache_PphpQPfSfscOgWflWKiKNR != this.__cache_PphpQPfSfscOgWflWKiKNR ? new FromSharedHandle_JhCoWFfyhrdNGNVPfy0KHo(this)
                {__cache_PphpQPfSfscOgWflWKiKNR = __cache_PphpQPfSfscOgWflWKiKNR} : that_0;
            else
            {
                this.__cache_PphpQPfSfscOgWflWKiKNR = __cache_PphpQPfSfscOgWflWKiKNR;
            }

            return that_0;
        }

        [n1.ElementAttribute(DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "UNHQc4cl6HSNTjvehB22mp", Name = "__UNHQc4cl6HSNTjvehB22mp")]
        [n2.SerializableAttribute]
        public class __UNHQc4cl6HSNTjvehB22mp : n1.VLObject, n2.IDisposable
        {
            public void Dispose()
            {
                n1.CompilationHelper.SafeDispose(this.__p_FZmVfZozt32MG8xSCPXtze);
                return;
            }

            [n1.ElementAttribute(TracingId = 3878U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "FZmVfZozt32MG8xSCPXtze", Name = "GraphicsDevice", IsManaged = true, IsAutoGenerated = true)]
            public n33.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_FZmVfZozt32MG8xSCPXtze;
            public __UNHQc4cl6HSNTjvehB22mp(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
            {
            }

            internal __UNHQc4cl6HSNTjvehB22mp(__UNHQc4cl6HSNTjvehB22mp other): base(other)
            {
                this.__p_FZmVfZozt32MG8xSCPXtze = other.__p_FZmVfZozt32MG8xSCPXtze;
            }

            protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
            {
                return __WITH__(n1.CompilationHelper.GetValueOrExisting(values, "__p_FZmVfZozt32MG8xSCPXtze", in __p_FZmVfZozt32MG8xSCPXtze));
            }

            internal __UNHQc4cl6HSNTjvehB22mp __WITH__(n33.GraphicsDevice_V0mXf77TurpOVQNzgviejb __p_FZmVfZozt32MG8xSCPXtze)
            {
                __UNHQc4cl6HSNTjvehB22mp that_0 = this;
                if (this.__GetContext__().IsImmutable)
                    that_0 = __p_FZmVfZozt32MG8xSCPXtze != this.__p_FZmVfZozt32MG8xSCPXtze ? new __UNHQc4cl6HSNTjvehB22mp(this)
                    {__p_FZmVfZozt32MG8xSCPXtze = __p_FZmVfZozt32MG8xSCPXtze} : that_0;
                else
                {
                    this.__p_FZmVfZozt32MG8xSCPXtze = __p_FZmVfZozt32MG8xSCPXtze;
                }

                return that_0;
            }
        }
    }
}

namespace _VL_Stride_Graphics_Windows_.Stride
{
    [n1.ElementAttribute(TracingId = 3948U, DocumentId = "CWTbJ7dBwqtLwCqXKAv402", PersistentId = "RG5iKypeWUxLXGWYlK6wyw", Name = "VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw")]
    [n2.SerializableAttribute]
    public class VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw : n1.VLObject, n2.IDisposable
    {
        [n4.CreateNewAttribute]
        public static n49.VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw Create(n1.NodeContext Node_Context)
        {
            var instance = new VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw(Node_Context, n1.VLObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [n4.CreateDefaultAttribute]
        public static n49.VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw CreateDefault()
        {
            var instance = new VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw(n1.NodeContext.Default, n1.VLObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        public n49.VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw Update()
        {
            return this;
        }

        public n49.VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw __Create__(n1.NodeContext Node_Context)
        {
            n10.RuntimeHelpers.EnsureSufficientExecutionStack();
            return this;
        }

        public n49.VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw __CreateDefault__()
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

        public VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw(n1.NodeContext __context__, uint __identity__): base(__context__, __identity__)
        {
        }

        internal VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw(VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw other): base(other)
        {
        }

        protected override n1.IVLObject __With__(n11.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal VL_Stride_Graphics_WindowsApplication_RG5iKypeWUxLXGWYlK6wyw __WITH__()
        {
            return this;
        }
    }
}

namespace _VL_Stride_Graphics_Windows_
{
    public struct __AdaptiveImplementations__CWTbJ7dBwqtLwCqXKAv402 : n55.IAdaptiveCreateDefault<string>, n55.IAdaptiveCreateDefault<bool>
    {
        public void CreateDefault(out string Output_Out)
        {
            var Empty_0 = n52._Operations_.CreateDefault();
            Output_Out = Empty_0;
            return;
        }

        public void CreateDefault(out bool Output_Out)
        {
            n54._Operations_.CreateDefault_Generic<bool>(Output_Out: out bool Output_0);
            Output_Out = Output_0;
            return;
        }
    }
}